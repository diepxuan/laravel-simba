using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Layout;
using System.Xml;
using AsiaErp.Framework.Docking.Win32;

namespace AsiaErp.Framework.Docking;

[DefaultEvent("ActiveContentChanged")]
[DefaultProperty("DocumentStyle")]
[ToolboxBitmap(typeof(resfinder), "AsiaErp.Framework.Docking.DockPanel.bmp")]
[LocalizedDescription("DockPanel_Description")]
[Designer(typeof(ControlDesigner))]
public class DockPanel : Panel
{
	private interface IFocusManager
	{
		bool IsFocusTrackingSuspended { get; }

		IDockContent ActiveContent { get; }

		DockPane ActivePane { get; }

		IDockContent ActiveDocument { get; }

		DockPane ActiveDocumentPane { get; }

		void SuspendFocusTracking();

		void ResumeFocusTracking();
	}

	private class FocusManagerImpl : Component, IContentFocusManager, IFocusManager
	{
		private class HookEventArgs : EventArgs
		{
			public int HookCode;

			public IntPtr wParam;

			public IntPtr lParam;
		}

		private class LocalWindowsHook : IDisposable
		{
			public delegate void HookEventHandler(object sender, HookEventArgs e);

			private IntPtr m_hHook = IntPtr.Zero;

			private NativeMethods.HookProc m_filterFunc;

			private HookType m_hookType;

			public event HookEventHandler HookInvoked;

			protected void OnHookInvoked(HookEventArgs e)
			{
				if (this.HookInvoked != null)
				{
					this.HookInvoked(this, e);
				}
			}

			public LocalWindowsHook(HookType hook)
			{
				m_hookType = hook;
				m_filterFunc = CoreHookProc;
			}

			public IntPtr CoreHookProc(int code, IntPtr wParam, IntPtr lParam)
			{
				if (code < 0)
				{
					return NativeMethods.CallNextHookEx(m_hHook, code, wParam, lParam);
				}
				HookEventArgs e = new HookEventArgs();
				e.HookCode = code;
				e.wParam = wParam;
				e.lParam = lParam;
				OnHookInvoked(e);
				return NativeMethods.CallNextHookEx(m_hHook, code, wParam, lParam);
			}

			public void Install()
			{
				if (m_hHook != IntPtr.Zero)
				{
					Uninstall();
				}
				int currentThreadId = NativeMethods.GetCurrentThreadId();
				m_hHook = NativeMethods.SetWindowsHookEx(m_hookType, m_filterFunc, IntPtr.Zero, currentThreadId);
			}

			public void Uninstall()
			{
				if (m_hHook != IntPtr.Zero)
				{
					NativeMethods.UnhookWindowsHookEx(m_hHook);
					m_hHook = IntPtr.Zero;
				}
			}

			~LocalWindowsHook()
			{
				Dispose(disposing: false);
			}

			public void Dispose()
			{
				Dispose(disposing: true);
				GC.SuppressFinalize(this);
			}

			protected virtual void Dispose(bool disposing)
			{
				Uninstall();
			}
		}

		private LocalWindowsHook m_localWindowsHook;

		private LocalWindowsHook.HookEventHandler m_hookEventHandler;

		private DockPanel m_dockPanel;

		private bool m_disposed;

		private IDockContent m_contentActivating;

		private List<IDockContent> m_listContent = new List<IDockContent>();

		private IDockContent m_lastActiveContent;

		private int m_countSuspendFocusTracking;

		private bool m_inRefreshActiveWindow;

		private DockPane m_activePane;

		private IDockContent m_activeContent;

		private DockPane m_activeDocumentPane;

		private IDockContent m_activeDocument;

		public DockPanel DockPanel => m_dockPanel;

		private IDockContent ContentActivating
		{
			get
			{
				return m_contentActivating;
			}
			set
			{
				m_contentActivating = value;
			}
		}

		private List<IDockContent> ListContent => m_listContent;

		private IDockContent LastActiveContent
		{
			get
			{
				return m_lastActiveContent;
			}
			set
			{
				m_lastActiveContent = value;
			}
		}

		public bool IsFocusTrackingSuspended => m_countSuspendFocusTracking != 0;

		private bool InRefreshActiveWindow => m_inRefreshActiveWindow;

		public DockPane ActivePane => m_activePane;

		public IDockContent ActiveContent => m_activeContent;

		public DockPane ActiveDocumentPane => m_activeDocumentPane;

		public IDockContent ActiveDocument => m_activeDocument;

		public FocusManagerImpl(DockPanel dockPanel)
		{
			m_dockPanel = dockPanel;
			m_localWindowsHook = new LocalWindowsHook(HookType.WH_CALLWNDPROCRET);
			m_hookEventHandler = HookEventHandler;
			m_localWindowsHook.HookInvoked += m_hookEventHandler;
			m_localWindowsHook.Install();
		}

		protected override void Dispose(bool disposing)
		{
			lock (this)
			{
				if (!m_disposed && disposing)
				{
					m_localWindowsHook.Dispose();
					m_disposed = true;
				}
				base.Dispose(disposing);
			}
		}

		public void Activate(IDockContent content)
		{
			if (IsFocusTrackingSuspended)
			{
				ContentActivating = content;
			}
			else
			{
				if (content == null)
				{
					return;
				}
				DockContentHandler dockHandler = content.DockHandler;
				if (!((Control)dockHandler.Form).IsDisposed)
				{
					if (ContentContains(content, dockHandler.ActiveWindowHandle))
					{
						NativeMethods.SetFocus(dockHandler.ActiveWindowHandle);
					}
					if (!((Control)dockHandler.Form).ContainsFocus && !((Control)dockHandler.Form).SelectNextControl(((ContainerControl)dockHandler.Form).ActiveControl, true, true, true, true))
					{
						NativeMethods.SetFocus(((Control)dockHandler.Form).Handle);
					}
				}
			}
		}

		public void AddToList(IDockContent content)
		{
			if (!ListContent.Contains(content) && !IsInActiveList(content))
			{
				ListContent.Add(content);
			}
		}

		public void RemoveFromList(IDockContent content)
		{
			if (IsInActiveList(content))
			{
				RemoveFromActiveList(content);
			}
			if (ListContent.Contains(content))
			{
				ListContent.Remove(content);
			}
		}

		private bool IsInActiveList(IDockContent content)
		{
			if (content.DockHandler.NextActive == null)
			{
				return LastActiveContent == content;
			}
			return true;
		}

		private void AddLastToActiveList(IDockContent content)
		{
			IDockContent lastActiveContent = LastActiveContent;
			if (lastActiveContent != content)
			{
				DockContentHandler dockHandler = content.DockHandler;
				if (IsInActiveList(content))
				{
					RemoveFromActiveList(content);
				}
				dockHandler.PreviousActive = lastActiveContent;
				dockHandler.NextActive = null;
				LastActiveContent = content;
				if (lastActiveContent != null)
				{
					lastActiveContent.DockHandler.NextActive = LastActiveContent;
				}
			}
		}

		private void RemoveFromActiveList(IDockContent content)
		{
			if (LastActiveContent == content)
			{
				LastActiveContent = content.DockHandler.PreviousActive;
			}
			IDockContent previousActive = content.DockHandler.PreviousActive;
			IDockContent nextActive = content.DockHandler.NextActive;
			if (previousActive != null)
			{
				previousActive.DockHandler.NextActive = nextActive;
			}
			if (nextActive != null)
			{
				nextActive.DockHandler.PreviousActive = previousActive;
			}
			content.DockHandler.PreviousActive = null;
			content.DockHandler.NextActive = null;
		}

		public void GiveUpFocus(IDockContent content)
		{
			DockContentHandler dockHandler = content.DockHandler;
			if (!((Control)dockHandler.Form).ContainsFocus)
			{
				return;
			}
			if (IsFocusTrackingSuspended)
			{
				DockPanel.DummyControl.Focus();
			}
			if (LastActiveContent == content)
			{
				IDockContent previousActive = dockHandler.PreviousActive;
				if (previousActive != null)
				{
					Activate(previousActive);
				}
				else if (ListContent.Count > 0)
				{
					Activate(ListContent[ListContent.Count - 1]);
				}
			}
			else if (LastActiveContent != null)
			{
				Activate(LastActiveContent);
			}
			else if (ListContent.Count > 0)
			{
				Activate(ListContent[ListContent.Count - 1]);
			}
		}

		private static bool ContentContains(IDockContent content, IntPtr hWnd)
		{
			Control val = Control.FromChildHandle(hWnd);
			for (Control val2 = val; val2 != null; val2 = val2.Parent)
			{
				if ((object)val2 == content.DockHandler.Form)
				{
					return true;
				}
			}
			return false;
		}

		public void SuspendFocusTracking()
		{
			m_countSuspendFocusTracking++;
			m_localWindowsHook.HookInvoked -= m_hookEventHandler;
		}

		public void ResumeFocusTracking()
		{
			if (m_countSuspendFocusTracking > 0)
			{
				m_countSuspendFocusTracking--;
			}
			if (m_countSuspendFocusTracking == 0)
			{
				if (ContentActivating != null)
				{
					Activate(ContentActivating);
					ContentActivating = null;
				}
				m_localWindowsHook.HookInvoked += m_hookEventHandler;
				if (!InRefreshActiveWindow)
				{
					RefreshActiveWindow();
				}
			}
		}

		private void HookEventHandler(object sender, HookEventArgs e)
		{
			switch ((Msgs)Marshal.ReadInt32(e.lParam, IntPtr.Size * 3))
			{
			case Msgs.WM_KILLFOCUS:
			{
				IntPtr hWnd = Marshal.ReadIntPtr(e.lParam, IntPtr.Size * 2);
				DockPane paneFromHandle = GetPaneFromHandle(hWnd);
				if (paneFromHandle == null)
				{
					RefreshActiveWindow();
				}
				break;
			}
			case Msgs.WM_SETFOCUS:
				RefreshActiveWindow();
				break;
			}
		}

		private DockPane GetPaneFromHandle(IntPtr hWnd)
		{
			Control val = Control.FromChildHandle(hWnd);
			IDockContent dockContent = null;
			DockPane dockPane = null;
			while (val != null)
			{
				dockContent = val as IDockContent;
				if (dockContent != null)
				{
					dockContent.DockHandler.ActiveWindowHandle = hWnd;
				}
				if (dockContent != null && dockContent.DockHandler.DockPanel == DockPanel)
				{
					return dockContent.DockHandler.Pane;
				}
				dockPane = val as DockPane;
				if (dockPane != null && dockPane.DockPanel == DockPanel)
				{
					break;
				}
				val = val.Parent;
			}
			return dockPane;
		}

		private void RefreshActiveWindow()
		{
			SuspendFocusTracking();
			m_inRefreshActiveWindow = true;
			DockPane activePane = ActivePane;
			IDockContent activeContent = ActiveContent;
			IDockContent activeDocument = ActiveDocument;
			SetActivePane();
			SetActiveContent();
			SetActiveDocumentPane();
			SetActiveDocument();
			DockPanel.AutoHideWindow.RefreshActivePane();
			ResumeFocusTracking();
			m_inRefreshActiveWindow = false;
			if (activeContent != ActiveContent)
			{
				DockPanel.OnActiveContentChanged(EventArgs.Empty);
			}
			if (activeDocument != ActiveDocument)
			{
				DockPanel.OnActiveDocumentChanged(EventArgs.Empty);
			}
			if (activePane != ActivePane)
			{
				DockPanel.OnActivePaneChanged(EventArgs.Empty);
			}
		}

		private void SetActivePane()
		{
			DockPane paneFromHandle = GetPaneFromHandle(NativeMethods.GetFocus());
			if (m_activePane != paneFromHandle)
			{
				if (m_activePane != null)
				{
					m_activePane.SetIsActivated(value: false);
				}
				m_activePane = paneFromHandle;
				if (m_activePane != null)
				{
					m_activePane.SetIsActivated(value: true);
				}
			}
		}

		internal void SetActiveContent()
		{
			IDockContent dockContent = ((ActivePane == null) ? null : ActivePane.ActiveContent);
			if (m_activeContent == dockContent)
			{
				return;
			}
			if (m_activeContent != null)
			{
				m_activeContent.DockHandler.IsActivated = false;
			}
			m_activeContent = dockContent;
			if (m_activeContent != null)
			{
				m_activeContent.DockHandler.IsActivated = true;
				if (!DockHelper.IsDockStateAutoHide(m_activeContent.DockHandler.DockState))
				{
					AddLastToActiveList(m_activeContent);
				}
			}
		}

		private void SetActiveDocumentPane()
		{
			DockPane dockPane = null;
			if (ActivePane != null && ActivePane.DockState == DockState.Document)
			{
				dockPane = ActivePane;
			}
			if (dockPane == null && DockPanel.DockWindows != null)
			{
				dockPane = ((ActiveDocumentPane == null) ? DockPanel.DockWindows[DockState.Document].DefaultPane : ((ActiveDocumentPane.DockPanel == DockPanel && ActiveDocumentPane.DockState == DockState.Document) ? ActiveDocumentPane : DockPanel.DockWindows[DockState.Document].DefaultPane));
			}
			if (m_activeDocumentPane != dockPane)
			{
				if (m_activeDocumentPane != null)
				{
					m_activeDocumentPane.SetIsActiveDocumentPane(value: false);
				}
				m_activeDocumentPane = dockPane;
				if (m_activeDocumentPane != null)
				{
					m_activeDocumentPane.SetIsActiveDocumentPane(value: true);
				}
			}
		}

		private void SetActiveDocument()
		{
			IDockContent dockContent = ((ActiveDocumentPane == null) ? null : ActiveDocumentPane.ActiveContent);
			if (m_activeDocument != dockContent)
			{
				m_activeDocument = dockContent;
			}
		}
	}

	private class MdiClientController : NativeWindow, IComponent, IDisposable
	{
		private bool m_autoScroll = true;

		private BorderStyle m_borderStyle = (BorderStyle)2;

		private MdiClient m_mdiClient;

		private Form m_parentForm;

		private ISite m_site;

		private LayoutEventHandler m_Layout;

		private PaintEventHandler m_Paint;

		public bool AutoScroll
		{
			get
			{
				return m_autoScroll;
			}
			set
			{
				m_autoScroll = value;
				if (MdiClient != null)
				{
					UpdateStyles();
				}
			}
		}

		public BorderStyle BorderStyle
		{
			set
			{
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_001f: Unknown result type (might be due to invalid IL or missing references)
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Expected I4, but got Unknown
				if (!Enum.IsDefined(typeof(BorderStyle), value))
				{
					throw new InvalidEnumArgumentException();
				}
				m_borderStyle = value;
				if (MdiClient != null && (Site == null || !Site.DesignMode))
				{
					int num = NativeMethods.GetWindowLong(((Control)MdiClient).Handle, -16);
					int num2 = NativeMethods.GetWindowLong(((Control)MdiClient).Handle, -20);
					BorderStyle borderStyle = m_borderStyle;
					switch ((int)borderStyle)
					{
					case 2:
						num2 |= 0x200;
						num &= -8388609;
						break;
					case 1:
						num2 &= -513;
						num |= 0x800000;
						break;
					case 0:
						num &= -8388609;
						num2 &= -513;
						break;
					}
					NativeMethods.SetWindowLong(((Control)MdiClient).Handle, -16, num);
					NativeMethods.SetWindowLong(((Control)MdiClient).Handle, -20, num2);
					UpdateStyles();
				}
			}
		}

		public MdiClient MdiClient => m_mdiClient;

		[Browsable(false)]
		public Form ParentForm
		{
			get
			{
				return m_parentForm;
			}
			set
			{
				if (m_parentForm != null)
				{
					((Control)m_parentForm).HandleCreated -= ParentFormHandleCreated;
					m_parentForm.MdiChildActivate -= ParentFormMdiChildActivate;
				}
				m_parentForm = value;
				if (m_parentForm != null)
				{
					if (((Control)m_parentForm).IsHandleCreated)
					{
						InitializeMdiClient();
						RefreshProperties();
					}
					else
					{
						((Control)m_parentForm).HandleCreated += ParentFormHandleCreated;
					}
					m_parentForm.MdiChildActivate += ParentFormMdiChildActivate;
				}
			}
		}

		public ISite Site
		{
			get
			{
				return m_site;
			}
			set
			{
				m_site = value;
				if (m_site != null && value.GetService(typeof(IDesignerHost)) is IDesignerHost designerHost)
				{
					IComponent rootComponent = designerHost.RootComponent;
					Form val = (Form)((rootComponent is Form) ? rootComponent : null);
					if (val != null)
					{
						ParentForm = val;
					}
				}
			}
		}

		public event EventHandler Disposed;

		public event EventHandler HandleAssigned;

		public event EventHandler MdiChildActivate;

		public event LayoutEventHandler Layout
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0017: Expected O, but got Unknown
				this.m_Layout = (LayoutEventHandler)Delegate.Combine((Delegate?)(object)this.m_Layout, (Delegate?)(object)value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0017: Expected O, but got Unknown
				this.m_Layout = (LayoutEventHandler)Delegate.Remove((Delegate?)(object)this.m_Layout, (Delegate?)(object)value);
			}
		}

		public event PaintEventHandler Paint
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0017: Expected O, but got Unknown
				this.m_Paint = (PaintEventHandler)Delegate.Combine((Delegate?)(object)this.m_Paint, (Delegate?)(object)value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0017: Expected O, but got Unknown
				this.m_Paint = (PaintEventHandler)Delegate.Remove((Delegate?)(object)this.m_Paint, (Delegate?)(object)value);
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposing)
			{
				return;
			}
			lock (this)
			{
				if (Site != null && Site.Container != null)
				{
					Site.Container.Remove(this);
				}
				if (this.Disposed != null)
				{
					this.Disposed(this, EventArgs.Empty);
				}
			}
		}

		public void RenewMdiClient()
		{
			InitializeMdiClient();
			RefreshProperties();
		}

		protected virtual void OnHandleAssigned(EventArgs e)
		{
			if (this.HandleAssigned != null)
			{
				this.HandleAssigned(this, e);
			}
		}

		protected virtual void OnMdiChildActivate(EventArgs e)
		{
			if (this.MdiChildActivate != null)
			{
				this.MdiChildActivate(this, e);
			}
		}

		protected virtual void OnLayout(LayoutEventArgs e)
		{
			if (this.Layout != null)
			{
				this.Layout.Invoke((object)this, e);
			}
		}

		protected virtual void OnPaint(PaintEventArgs e)
		{
			if (this.Paint != null)
			{
				this.Paint.Invoke((object)this, e);
			}
		}

		protected override void WndProc(ref Message m)
		{
			int msg = ((Message)(ref m)).Msg;
			if (msg == 131 && !AutoScroll)
			{
				NativeMethods.ShowScrollBar(((Message)(ref m)).HWnd, 3, 0);
			}
			((NativeWindow)this).WndProc(ref m);
		}

		private void ParentFormHandleCreated(object sender, EventArgs e)
		{
			((Control)m_parentForm).HandleCreated -= ParentFormHandleCreated;
			InitializeMdiClient();
			RefreshProperties();
		}

		private void ParentFormMdiChildActivate(object sender, EventArgs e)
		{
			OnMdiChildActivate(e);
		}

		private void MdiClientLayout(object sender, LayoutEventArgs e)
		{
			OnLayout(e);
		}

		private void MdiClientHandleDestroyed(object sender, EventArgs e)
		{
			if (m_mdiClient != null)
			{
				((Control)m_mdiClient).HandleDestroyed -= MdiClientHandleDestroyed;
				m_mdiClient = null;
			}
			((NativeWindow)this).ReleaseHandle();
		}

		private void InitializeMdiClient()
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			if (MdiClient != null)
			{
				((Control)MdiClient).HandleDestroyed -= MdiClientHandleDestroyed;
				((Control)MdiClient).Layout -= new LayoutEventHandler(MdiClientLayout);
			}
			if (ParentForm == null)
			{
				return;
			}
			foreach (Control item in (ArrangedElementCollection)((Control)ParentForm).Controls)
			{
				Control val = item;
				m_mdiClient = (MdiClient)(object)((val is MdiClient) ? val : null);
				if (m_mdiClient != null)
				{
					((NativeWindow)this).ReleaseHandle();
					((NativeWindow)this).AssignHandle(((Control)MdiClient).Handle);
					OnHandleAssigned(EventArgs.Empty);
					((Control)MdiClient).HandleDestroyed += MdiClientHandleDestroyed;
					((Control)MdiClient).Layout += new LayoutEventHandler(MdiClientLayout);
					break;
				}
			}
		}

		private void RefreshProperties()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			BorderStyle = m_borderStyle;
			AutoScroll = m_autoScroll;
		}

		private void UpdateStyles()
		{
			NativeMethods.SetWindowPos(((Control)MdiClient).Handle, IntPtr.Zero, 0, 0, 0, 0, FlagsSetWindowPos.SWP_NOSIZE | FlagsSetWindowPos.SWP_NOMOVE | FlagsSetWindowPos.SWP_NOZORDER | FlagsSetWindowPos.SWP_NOACTIVATE | FlagsSetWindowPos.SWP_FRAMECHANGED | FlagsSetWindowPos.SWP_NOOWNERZORDER);
		}
	}

	private static class Persistor
	{
		private class DummyContent : DockContent
		{
		}

		private struct DockPanelStruct
		{
			private double m_dockLeftPortion;

			private double m_dockRightPortion;

			private double m_dockTopPortion;

			private double m_dockBottomPortion;

			private int m_indexActiveDocumentPane;

			private int m_indexActivePane;

			public double DockLeftPortion
			{
				get
				{
					return m_dockLeftPortion;
				}
				set
				{
					m_dockLeftPortion = value;
				}
			}

			public double DockRightPortion
			{
				get
				{
					return m_dockRightPortion;
				}
				set
				{
					m_dockRightPortion = value;
				}
			}

			public double DockTopPortion
			{
				get
				{
					return m_dockTopPortion;
				}
				set
				{
					m_dockTopPortion = value;
				}
			}

			public double DockBottomPortion
			{
				get
				{
					return m_dockBottomPortion;
				}
				set
				{
					m_dockBottomPortion = value;
				}
			}

			public int IndexActiveDocumentPane
			{
				get
				{
					return m_indexActiveDocumentPane;
				}
				set
				{
					m_indexActiveDocumentPane = value;
				}
			}

			public int IndexActivePane
			{
				get
				{
					return m_indexActivePane;
				}
				set
				{
					m_indexActivePane = value;
				}
			}
		}

		private struct ContentStruct
		{
			private string m_persistString;

			private double m_autoHidePortion;

			private bool m_isHidden;

			private bool m_isFloat;

			public string PersistString
			{
				get
				{
					return m_persistString;
				}
				set
				{
					m_persistString = value;
				}
			}

			public double AutoHidePortion
			{
				get
				{
					return m_autoHidePortion;
				}
				set
				{
					m_autoHidePortion = value;
				}
			}

			public bool IsHidden
			{
				get
				{
					return m_isHidden;
				}
				set
				{
					m_isHidden = value;
				}
			}

			public bool IsFloat
			{
				get
				{
					return m_isFloat;
				}
				set
				{
					m_isFloat = value;
				}
			}
		}

		private struct PaneStruct
		{
			private DockState m_dockState;

			private int m_indexActiveContent;

			private int[] m_indexContents;

			private int m_zOrderIndex;

			public DockState DockState
			{
				get
				{
					return m_dockState;
				}
				set
				{
					m_dockState = value;
				}
			}

			public int IndexActiveContent
			{
				get
				{
					return m_indexActiveContent;
				}
				set
				{
					m_indexActiveContent = value;
				}
			}

			public int[] IndexContents
			{
				get
				{
					return m_indexContents;
				}
				set
				{
					m_indexContents = value;
				}
			}

			public int ZOrderIndex
			{
				get
				{
					return m_zOrderIndex;
				}
				set
				{
					m_zOrderIndex = value;
				}
			}
		}

		private struct NestedPane
		{
			private int m_indexPane;

			private int m_indexPrevPane;

			private DockAlignment m_alignment;

			private double m_proportion;

			public int IndexPane
			{
				get
				{
					return m_indexPane;
				}
				set
				{
					m_indexPane = value;
				}
			}

			public int IndexPrevPane
			{
				get
				{
					return m_indexPrevPane;
				}
				set
				{
					m_indexPrevPane = value;
				}
			}

			public DockAlignment Alignment
			{
				get
				{
					return m_alignment;
				}
				set
				{
					m_alignment = value;
				}
			}

			public double Proportion
			{
				get
				{
					return m_proportion;
				}
				set
				{
					m_proportion = value;
				}
			}
		}

		private struct DockWindowStruct
		{
			private DockState m_dockState;

			private int m_zOrderIndex;

			private NestedPane[] m_nestedPanes;

			public DockState DockState
			{
				get
				{
					return m_dockState;
				}
				set
				{
					m_dockState = value;
				}
			}

			public int ZOrderIndex
			{
				get
				{
					return m_zOrderIndex;
				}
				set
				{
					m_zOrderIndex = value;
				}
			}

			public NestedPane[] NestedPanes
			{
				get
				{
					return m_nestedPanes;
				}
				set
				{
					m_nestedPanes = value;
				}
			}
		}

		private struct FloatWindowStruct
		{
			private Rectangle m_bounds;

			private int m_zOrderIndex;

			private NestedPane[] m_nestedPanes;

			public Rectangle Bounds
			{
				get
				{
					return m_bounds;
				}
				set
				{
					m_bounds = value;
				}
			}

			public int ZOrderIndex
			{
				get
				{
					return m_zOrderIndex;
				}
				set
				{
					m_zOrderIndex = value;
				}
			}

			public NestedPane[] NestedPanes
			{
				get
				{
					return m_nestedPanes;
				}
				set
				{
					m_nestedPanes = value;
				}
			}
		}

		private const string ConfigFileVersion = "1.0";

		private static string[] CompatibleConfigFileVersions = new string[0];

		public static void SaveAsXml(DockPanel dockPanel, string fileName)
		{
			SaveAsXml(dockPanel, fileName, Encoding.Unicode);
		}

		public static void SaveAsXml(DockPanel dockPanel, string fileName, Encoding encoding)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Create);
			try
			{
				SaveAsXml(dockPanel, fileStream, encoding);
			}
			finally
			{
				fileStream.Close();
			}
		}

		public static void SaveAsXml(DockPanel dockPanel, Stream stream, Encoding encoding)
		{
			SaveAsXml(dockPanel, stream, encoding, upstream: false);
		}

		public static void SaveAsXml(DockPanel dockPanel, Stream stream, Encoding encoding, bool upstream)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Expected O, but got Unknown
			XmlTextWriter val = new XmlTextWriter(stream, encoding);
			val.Formatting = (Formatting)1;
			if (!upstream)
			{
				((XmlWriter)val).WriteStartDocument();
			}
			((XmlWriter)val).WriteComment(Strings.DockPanel_Persistor_XmlFileComment1);
			((XmlWriter)val).WriteComment(Strings.DockPanel_Persistor_XmlFileComment2);
			((XmlWriter)val).WriteStartElement("DockPanel");
			((XmlWriter)val).WriteAttributeString("FormatVersion", "1.0");
			((XmlWriter)val).WriteAttributeString("DockLeftPortion", dockPanel.DockLeftPortion.ToString(CultureInfo.InvariantCulture));
			((XmlWriter)val).WriteAttributeString("DockRightPortion", dockPanel.DockRightPortion.ToString(CultureInfo.InvariantCulture));
			((XmlWriter)val).WriteAttributeString("DockTopPortion", dockPanel.DockTopPortion.ToString(CultureInfo.InvariantCulture));
			((XmlWriter)val).WriteAttributeString("DockBottomPortion", dockPanel.DockBottomPortion.ToString(CultureInfo.InvariantCulture));
			((XmlWriter)val).WriteAttributeString("ActiveDocumentPane", dockPanel.Panes.IndexOf(dockPanel.ActiveDocumentPane).ToString(CultureInfo.InvariantCulture));
			((XmlWriter)val).WriteAttributeString("ActivePane", dockPanel.Panes.IndexOf(dockPanel.ActivePane).ToString(CultureInfo.InvariantCulture));
			((XmlWriter)val).WriteStartElement("Contents");
			((XmlWriter)val).WriteAttributeString("Count", dockPanel.Contents.Count.ToString(CultureInfo.InvariantCulture));
			foreach (IDockContent content in dockPanel.Contents)
			{
				((XmlWriter)val).WriteStartElement("Content");
				((XmlWriter)val).WriteAttributeString("ID", dockPanel.Contents.IndexOf(content).ToString(CultureInfo.InvariantCulture));
				((XmlWriter)val).WriteAttributeString("PersistString", content.DockHandler.PersistString);
				((XmlWriter)val).WriteAttributeString("AutoHidePortion", content.DockHandler.AutoHidePortion.ToString(CultureInfo.InvariantCulture));
				((XmlWriter)val).WriteAttributeString("IsHidden", content.DockHandler.IsHidden.ToString(CultureInfo.InvariantCulture));
				((XmlWriter)val).WriteAttributeString("IsFloat", content.DockHandler.IsFloat.ToString(CultureInfo.InvariantCulture));
				((XmlWriter)val).WriteEndElement();
			}
			((XmlWriter)val).WriteEndElement();
			((XmlWriter)val).WriteStartElement("Panes");
			((XmlWriter)val).WriteAttributeString("Count", dockPanel.Panes.Count.ToString(CultureInfo.InvariantCulture));
			foreach (DockPane pane in dockPanel.Panes)
			{
				((XmlWriter)val).WriteStartElement("Pane");
				((XmlWriter)val).WriteAttributeString("ID", dockPanel.Panes.IndexOf(pane).ToString(CultureInfo.InvariantCulture));
				((XmlWriter)val).WriteAttributeString("DockState", pane.DockState.ToString());
				((XmlWriter)val).WriteAttributeString("ActiveContent", dockPanel.Contents.IndexOf(pane.ActiveContent).ToString(CultureInfo.InvariantCulture));
				((XmlWriter)val).WriteStartElement("Contents");
				((XmlWriter)val).WriteAttributeString("Count", pane.Contents.Count.ToString(CultureInfo.InvariantCulture));
				foreach (IDockContent content2 in pane.Contents)
				{
					((XmlWriter)val).WriteStartElement("Content");
					((XmlWriter)val).WriteAttributeString("ID", pane.Contents.IndexOf(content2).ToString(CultureInfo.InvariantCulture));
					((XmlWriter)val).WriteAttributeString("RefID", dockPanel.Contents.IndexOf(content2).ToString(CultureInfo.InvariantCulture));
					((XmlWriter)val).WriteEndElement();
				}
				((XmlWriter)val).WriteEndElement();
				((XmlWriter)val).WriteEndElement();
			}
			((XmlWriter)val).WriteEndElement();
			((XmlWriter)val).WriteStartElement("DockWindows");
			int num = 0;
			foreach (DockWindow dockWindow in dockPanel.DockWindows)
			{
				((XmlWriter)val).WriteStartElement("DockWindow");
				((XmlWriter)val).WriteAttributeString("ID", num.ToString(CultureInfo.InvariantCulture));
				num++;
				((XmlWriter)val).WriteAttributeString("DockState", dockWindow.DockState.ToString());
				((XmlWriter)val).WriteAttributeString("ZOrderIndex", ((Control)dockPanel).Controls.IndexOf((Control)(object)dockWindow).ToString(CultureInfo.InvariantCulture));
				((XmlWriter)val).WriteStartElement("NestedPanes");
				((XmlWriter)val).WriteAttributeString("Count", dockWindow.NestedPanes.Count.ToString(CultureInfo.InvariantCulture));
				foreach (DockPane nestedPane in dockWindow.NestedPanes)
				{
					((XmlWriter)val).WriteStartElement("Pane");
					((XmlWriter)val).WriteAttributeString("ID", dockWindow.NestedPanes.IndexOf(nestedPane).ToString(CultureInfo.InvariantCulture));
					((XmlWriter)val).WriteAttributeString("RefID", dockPanel.Panes.IndexOf(nestedPane).ToString(CultureInfo.InvariantCulture));
					NestedDockingStatus nestedDockingStatus = nestedPane.NestedDockingStatus;
					((XmlWriter)val).WriteAttributeString("PrevPane", dockPanel.Panes.IndexOf(nestedDockingStatus.PreviousPane).ToString(CultureInfo.InvariantCulture));
					((XmlWriter)val).WriteAttributeString("Alignment", nestedDockingStatus.Alignment.ToString());
					((XmlWriter)val).WriteAttributeString("Proportion", nestedDockingStatus.Proportion.ToString(CultureInfo.InvariantCulture));
					((XmlWriter)val).WriteEndElement();
				}
				((XmlWriter)val).WriteEndElement();
				((XmlWriter)val).WriteEndElement();
			}
			((XmlWriter)val).WriteEndElement();
			RectangleConverter rectangleConverter = new RectangleConverter();
			((XmlWriter)val).WriteStartElement("FloatWindows");
			((XmlWriter)val).WriteAttributeString("Count", dockPanel.FloatWindows.Count.ToString(CultureInfo.InvariantCulture));
			foreach (FloatWindow floatWindow in dockPanel.FloatWindows)
			{
				((XmlWriter)val).WriteStartElement("FloatWindow");
				((XmlWriter)val).WriteAttributeString("ID", dockPanel.FloatWindows.IndexOf(floatWindow).ToString(CultureInfo.InvariantCulture));
				((XmlWriter)val).WriteAttributeString("Bounds", rectangleConverter.ConvertToInvariantString(((Control)floatWindow).Bounds));
				((XmlWriter)val).WriteAttributeString("ZOrderIndex", floatWindow.DockPanel.FloatWindows.IndexOf(floatWindow).ToString(CultureInfo.InvariantCulture));
				((XmlWriter)val).WriteStartElement("NestedPanes");
				((XmlWriter)val).WriteAttributeString("Count", floatWindow.NestedPanes.Count.ToString(CultureInfo.InvariantCulture));
				foreach (DockPane nestedPane2 in floatWindow.NestedPanes)
				{
					((XmlWriter)val).WriteStartElement("Pane");
					((XmlWriter)val).WriteAttributeString("ID", floatWindow.NestedPanes.IndexOf(nestedPane2).ToString(CultureInfo.InvariantCulture));
					((XmlWriter)val).WriteAttributeString("RefID", dockPanel.Panes.IndexOf(nestedPane2).ToString(CultureInfo.InvariantCulture));
					NestedDockingStatus nestedDockingStatus2 = nestedPane2.NestedDockingStatus;
					((XmlWriter)val).WriteAttributeString("PrevPane", dockPanel.Panes.IndexOf(nestedDockingStatus2.PreviousPane).ToString(CultureInfo.InvariantCulture));
					((XmlWriter)val).WriteAttributeString("Alignment", nestedDockingStatus2.Alignment.ToString());
					((XmlWriter)val).WriteAttributeString("Proportion", nestedDockingStatus2.Proportion.ToString(CultureInfo.InvariantCulture));
					((XmlWriter)val).WriteEndElement();
				}
				((XmlWriter)val).WriteEndElement();
				((XmlWriter)val).WriteEndElement();
			}
			((XmlWriter)val).WriteEndElement();
			((XmlWriter)val).WriteEndElement();
			if (!upstream)
			{
				((XmlWriter)val).WriteEndDocument();
				((XmlWriter)val).Close();
			}
			else
			{
				((XmlWriter)val).Flush();
			}
		}

		public static void LoadFromXml(DockPanel dockPanel, string fileName, DeserializeDockContent deserializeContent)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			try
			{
				LoadFromXml(dockPanel, fileStream, deserializeContent);
			}
			finally
			{
				fileStream.Close();
			}
		}

		public static void LoadFromXml(DockPanel dockPanel, Stream stream, DeserializeDockContent deserializeContent)
		{
			LoadFromXml(dockPanel, stream, deserializeContent, closeStream: true);
		}

		private static ContentStruct[] LoadContents(XmlTextReader xmlIn)
		{
			int num = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("Count"), CultureInfo.InvariantCulture);
			ContentStruct[] array = new ContentStruct[num];
			MoveToNextElement(xmlIn);
			for (int i = 0; i < num; i++)
			{
				int num2 = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("ID"), CultureInfo.InvariantCulture);
				if (((XmlReader)xmlIn).Name != "Content" || num2 != i)
				{
					throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
				}
				array[i].PersistString = ((XmlReader)xmlIn).GetAttribute("PersistString");
				array[i].AutoHidePortion = Convert.ToDouble(((XmlReader)xmlIn).GetAttribute("AutoHidePortion"), CultureInfo.InvariantCulture);
				array[i].IsHidden = Convert.ToBoolean(((XmlReader)xmlIn).GetAttribute("IsHidden"), CultureInfo.InvariantCulture);
				array[i].IsFloat = Convert.ToBoolean(((XmlReader)xmlIn).GetAttribute("IsFloat"), CultureInfo.InvariantCulture);
				MoveToNextElement(xmlIn);
			}
			return array;
		}

		private static PaneStruct[] LoadPanes(XmlTextReader xmlIn)
		{
			EnumConverter enumConverter = new EnumConverter(typeof(DockState));
			int num = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("Count"), CultureInfo.InvariantCulture);
			PaneStruct[] array = new PaneStruct[num];
			MoveToNextElement(xmlIn);
			for (int i = 0; i < num; i++)
			{
				int num2 = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("ID"), CultureInfo.InvariantCulture);
				if (((XmlReader)xmlIn).Name != "Pane" || num2 != i)
				{
					throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
				}
				array[i].DockState = (DockState)enumConverter.ConvertFrom(((XmlReader)xmlIn).GetAttribute("DockState"));
				array[i].IndexActiveContent = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("ActiveContent"), CultureInfo.InvariantCulture);
				array[i].ZOrderIndex = -1;
				MoveToNextElement(xmlIn);
				if (((XmlReader)xmlIn).Name != "Contents")
				{
					throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
				}
				int num3 = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("Count"), CultureInfo.InvariantCulture);
				array[i].IndexContents = new int[num3];
				MoveToNextElement(xmlIn);
				for (int j = 0; j < num3; j++)
				{
					int num4 = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("ID"), CultureInfo.InvariantCulture);
					if (((XmlReader)xmlIn).Name != "Content" || num4 != j)
					{
						throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
					}
					array[i].IndexContents[j] = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("RefID"), CultureInfo.InvariantCulture);
					MoveToNextElement(xmlIn);
				}
			}
			return array;
		}

		private static DockWindowStruct[] LoadDockWindows(XmlTextReader xmlIn, DockPanel dockPanel)
		{
			EnumConverter enumConverter = new EnumConverter(typeof(DockState));
			EnumConverter enumConverter2 = new EnumConverter(typeof(DockAlignment));
			int count = dockPanel.DockWindows.Count;
			DockWindowStruct[] array = new DockWindowStruct[count];
			MoveToNextElement(xmlIn);
			for (int i = 0; i < count; i++)
			{
				int num = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("ID"), CultureInfo.InvariantCulture);
				if (((XmlReader)xmlIn).Name != "DockWindow" || num != i)
				{
					throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
				}
				array[i].DockState = (DockState)enumConverter.ConvertFrom(((XmlReader)xmlIn).GetAttribute("DockState"));
				array[i].ZOrderIndex = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("ZOrderIndex"), CultureInfo.InvariantCulture);
				MoveToNextElement(xmlIn);
				if (((XmlReader)xmlIn).Name != "DockList" && ((XmlReader)xmlIn).Name != "NestedPanes")
				{
					throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
				}
				int num2 = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("Count"), CultureInfo.InvariantCulture);
				array[i].NestedPanes = new NestedPane[num2];
				MoveToNextElement(xmlIn);
				for (int j = 0; j < num2; j++)
				{
					int num3 = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("ID"), CultureInfo.InvariantCulture);
					if (((XmlReader)xmlIn).Name != "Pane" || num3 != j)
					{
						throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
					}
					array[i].NestedPanes[j].IndexPane = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("RefID"), CultureInfo.InvariantCulture);
					array[i].NestedPanes[j].IndexPrevPane = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("PrevPane"), CultureInfo.InvariantCulture);
					array[i].NestedPanes[j].Alignment = (DockAlignment)enumConverter2.ConvertFrom(((XmlReader)xmlIn).GetAttribute("Alignment"));
					array[i].NestedPanes[j].Proportion = Convert.ToDouble(((XmlReader)xmlIn).GetAttribute("Proportion"), CultureInfo.InvariantCulture);
					MoveToNextElement(xmlIn);
				}
			}
			return array;
		}

		private static FloatWindowStruct[] LoadFloatWindows(XmlTextReader xmlIn)
		{
			EnumConverter enumConverter = new EnumConverter(typeof(DockAlignment));
			RectangleConverter rectangleConverter = new RectangleConverter();
			int num = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("Count"), CultureInfo.InvariantCulture);
			FloatWindowStruct[] array = new FloatWindowStruct[num];
			MoveToNextElement(xmlIn);
			for (int i = 0; i < num; i++)
			{
				int num2 = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("ID"), CultureInfo.InvariantCulture);
				if (((XmlReader)xmlIn).Name != "FloatWindow" || num2 != i)
				{
					throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
				}
				array[i].Bounds = (Rectangle)rectangleConverter.ConvertFromInvariantString(((XmlReader)xmlIn).GetAttribute("Bounds"));
				array[i].ZOrderIndex = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("ZOrderIndex"), CultureInfo.InvariantCulture);
				MoveToNextElement(xmlIn);
				if (((XmlReader)xmlIn).Name != "DockList" && ((XmlReader)xmlIn).Name != "NestedPanes")
				{
					throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
				}
				int num3 = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("Count"), CultureInfo.InvariantCulture);
				array[i].NestedPanes = new NestedPane[num3];
				MoveToNextElement(xmlIn);
				for (int j = 0; j < num3; j++)
				{
					int num4 = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("ID"), CultureInfo.InvariantCulture);
					if (((XmlReader)xmlIn).Name != "Pane" || num4 != j)
					{
						throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
					}
					array[i].NestedPanes[j].IndexPane = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("RefID"), CultureInfo.InvariantCulture);
					array[i].NestedPanes[j].IndexPrevPane = Convert.ToInt32(((XmlReader)xmlIn).GetAttribute("PrevPane"), CultureInfo.InvariantCulture);
					array[i].NestedPanes[j].Alignment = (DockAlignment)enumConverter.ConvertFrom(((XmlReader)xmlIn).GetAttribute("Alignment"));
					array[i].NestedPanes[j].Proportion = Convert.ToDouble(((XmlReader)xmlIn).GetAttribute("Proportion"), CultureInfo.InvariantCulture);
					MoveToNextElement(xmlIn);
				}
			}
			return array;
		}

		public static void LoadFromXml(DockPanel dockPanel, Stream stream, DeserializeDockContent deserializeContent, bool closeStream)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			if (dockPanel.Contents.Count != 0)
			{
				throw new InvalidOperationException(Strings.DockPanel_LoadFromXml_AlreadyInitialized);
			}
			XmlTextReader val = new XmlTextReader(stream);
			val.WhitespaceHandling = (WhitespaceHandling)2;
			((XmlReader)val).MoveToContent();
			while (!((XmlReader)val).Name.Equals("DockPanel"))
			{
				if (!MoveToNextElement(val))
				{
					throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
				}
			}
			string attribute = ((XmlReader)val).GetAttribute("FormatVersion");
			if (!IsFormatVersionValid(attribute))
			{
				throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidFormatVersion);
			}
			DockPanelStruct dockPanelStruct = new DockPanelStruct
			{
				DockLeftPortion = Convert.ToDouble(((XmlReader)val).GetAttribute("DockLeftPortion"), CultureInfo.InvariantCulture),
				DockRightPortion = Convert.ToDouble(((XmlReader)val).GetAttribute("DockRightPortion"), CultureInfo.InvariantCulture),
				DockTopPortion = Convert.ToDouble(((XmlReader)val).GetAttribute("DockTopPortion"), CultureInfo.InvariantCulture),
				DockBottomPortion = Convert.ToDouble(((XmlReader)val).GetAttribute("DockBottomPortion"), CultureInfo.InvariantCulture),
				IndexActiveDocumentPane = Convert.ToInt32(((XmlReader)val).GetAttribute("ActiveDocumentPane"), CultureInfo.InvariantCulture),
				IndexActivePane = Convert.ToInt32(((XmlReader)val).GetAttribute("ActivePane"), CultureInfo.InvariantCulture)
			};
			MoveToNextElement(val);
			if (((XmlReader)val).Name != "Contents")
			{
				throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
			}
			ContentStruct[] array = LoadContents(val);
			if (((XmlReader)val).Name != "Panes")
			{
				throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
			}
			PaneStruct[] array2 = LoadPanes(val);
			if (((XmlReader)val).Name != "DockWindows")
			{
				throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
			}
			DockWindowStruct[] array3 = LoadDockWindows(val, dockPanel);
			if (((XmlReader)val).Name != "FloatWindows")
			{
				throw new ArgumentException(Strings.DockPanel_LoadFromXml_InvalidXmlFormat);
			}
			FloatWindowStruct[] array4 = LoadFloatWindows(val);
			if (closeStream)
			{
				((XmlReader)val).Close();
			}
			dockPanel.SuspendLayout(allWindows: true);
			dockPanel.DockLeftPortion = dockPanelStruct.DockLeftPortion;
			dockPanel.DockRightPortion = dockPanelStruct.DockRightPortion;
			dockPanel.DockTopPortion = dockPanelStruct.DockTopPortion;
			dockPanel.DockBottomPortion = dockPanelStruct.DockBottomPortion;
			int num = int.MaxValue;
			for (int i = 0; i < array3.Length; i++)
			{
				int num2 = -1;
				int num3 = -1;
				for (int j = 0; j < array3.Length; j++)
				{
					if (array3[j].ZOrderIndex > num2 && array3[j].ZOrderIndex < num)
					{
						num2 = array3[j].ZOrderIndex;
						num3 = j;
					}
				}
				((Control)dockPanel.DockWindows[array3[num3].DockState]).BringToFront();
				num = num2;
			}
			for (int k = 0; k < array.Length; k++)
			{
				IDockContent dockContent = deserializeContent(array[k].PersistString);
				if (dockContent == null)
				{
					dockContent = new DummyContent();
				}
				dockContent.DockHandler.DockPanel = dockPanel;
				dockContent.DockHandler.AutoHidePortion = array[k].AutoHidePortion;
				dockContent.DockHandler.IsHidden = true;
				dockContent.DockHandler.IsFloat = array[k].IsFloat;
			}
			for (int l = 0; l < array2.Length; l++)
			{
				DockPane dockPane = null;
				for (int m = 0; m < array2[l].IndexContents.Length; m++)
				{
					IDockContent dockContent2 = dockPanel.Contents[array2[l].IndexContents[m]];
					if (m == 0)
					{
						dockPane = dockPanel.DockPaneFactory.CreateDockPane(dockContent2, array2[l].DockState, show: false);
					}
					else if (array2[l].DockState == DockState.Float)
					{
						dockContent2.DockHandler.FloatPane = dockPane;
					}
					else
					{
						dockContent2.DockHandler.PanelPane = dockPane;
					}
				}
			}
			for (int n = 0; n < array3.Length; n++)
			{
				for (int num4 = 0; num4 < array3[n].NestedPanes.Length; num4++)
				{
					DockWindow dockWindow = dockPanel.DockWindows[array3[n].DockState];
					int indexPane = array3[n].NestedPanes[num4].IndexPane;
					DockPane dockPane2 = dockPanel.Panes[indexPane];
					int indexPrevPane = array3[n].NestedPanes[num4].IndexPrevPane;
					DockPane previousPane = ((indexPrevPane == -1) ? dockWindow.NestedPanes.GetDefaultPreviousPane(dockPane2) : dockPanel.Panes[indexPrevPane]);
					DockAlignment alignment = array3[n].NestedPanes[num4].Alignment;
					double proportion = array3[n].NestedPanes[num4].Proportion;
					dockPane2.DockTo(dockWindow, previousPane, alignment, proportion);
					if (array2[indexPane].DockState == dockWindow.DockState)
					{
						array2[indexPane].ZOrderIndex = array3[n].ZOrderIndex;
					}
				}
			}
			for (int num5 = 0; num5 < array4.Length; num5++)
			{
				FloatWindow floatWindow = null;
				for (int num6 = 0; num6 < array4[num5].NestedPanes.Length; num6++)
				{
					int indexPane2 = array4[num5].NestedPanes[num6].IndexPane;
					DockPane dockPane3 = dockPanel.Panes[indexPane2];
					if (num6 == 0)
					{
						floatWindow = dockPanel.FloatWindowFactory.CreateFloatWindow(dockPanel, dockPane3, array4[num5].Bounds);
					}
					else
					{
						int indexPrevPane2 = array4[num5].NestedPanes[num6].IndexPrevPane;
						DockPane previousPane2 = ((indexPrevPane2 == -1) ? null : dockPanel.Panes[indexPrevPane2]);
						DockAlignment alignment2 = array4[num5].NestedPanes[num6].Alignment;
						double proportion2 = array4[num5].NestedPanes[num6].Proportion;
						dockPane3.DockTo(floatWindow, previousPane2, alignment2, proportion2);
					}
					if (array2[indexPane2].DockState == floatWindow.DockState)
					{
						array2[indexPane2].ZOrderIndex = array4[num5].ZOrderIndex;
					}
				}
			}
			int[] array5 = null;
			if (array.Length > 0)
			{
				array5 = new int[array.Length];
				for (int num7 = 0; num7 < array.Length; num7++)
				{
					array5[num7] = num7;
				}
				_ = array.Length;
				for (int num8 = 0; num8 < array.Length - 1; num8++)
				{
					for (int num9 = num8 + 1; num9 < array.Length; num9++)
					{
						DockPane pane = dockPanel.Contents[array5[num8]].DockHandler.Pane;
						int num10 = ((pane != null) ? array2[dockPanel.Panes.IndexOf(pane)].ZOrderIndex : 0);
						DockPane pane2 = dockPanel.Contents[array5[num9]].DockHandler.Pane;
						int num11 = ((pane2 != null) ? array2[dockPanel.Panes.IndexOf(pane2)].ZOrderIndex : 0);
						if (num10 > num11)
						{
							int num12 = array5[num8];
							array5[num8] = array5[num9];
							array5[num9] = num12;
						}
					}
				}
			}
			for (int num13 = 0; num13 < array.Length; num13++)
			{
				IDockContent dockContent3 = dockPanel.Contents[array5[num13]];
				if (dockContent3.DockHandler.Pane != null && dockContent3.DockHandler.Pane.DockState != DockState.Document)
				{
					dockContent3.DockHandler.IsHidden = array[array5[num13]].IsHidden;
				}
			}
			for (int num14 = 0; num14 < array.Length; num14++)
			{
				IDockContent dockContent4 = dockPanel.Contents[array5[num14]];
				if (dockContent4.DockHandler.Pane != null && dockContent4.DockHandler.Pane.DockState == DockState.Document)
				{
					dockContent4.DockHandler.IsHidden = array[array5[num14]].IsHidden;
				}
			}
			for (int num15 = 0; num15 < array2.Length; num15++)
			{
				dockPanel.Panes[num15].ActiveContent = ((array2[num15].IndexActiveContent == -1) ? null : dockPanel.Contents[array2[num15].IndexActiveContent]);
			}
			if (dockPanelStruct.IndexActiveDocumentPane != -1)
			{
				dockPanel.Panes[dockPanelStruct.IndexActiveDocumentPane].Activate();
			}
			if (dockPanelStruct.IndexActivePane != -1)
			{
				dockPanel.Panes[dockPanelStruct.IndexActivePane].Activate();
			}
			for (int num16 = dockPanel.Contents.Count - 1; num16 >= 0; num16--)
			{
				if (dockPanel.Contents[num16] is DummyContent)
				{
					dockPanel.Contents[num16].DockHandler.Form.Close();
				}
			}
			dockPanel.ResumeLayout(performLayout: true, allWindows: true);
		}

		private static bool MoveToNextElement(XmlTextReader xmlIn)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Invalid comparison between Unknown and I4
			if (!((XmlReader)xmlIn).Read())
			{
				return false;
			}
			while ((int)((XmlReader)xmlIn).NodeType == 15)
			{
				if (!((XmlReader)xmlIn).Read())
				{
					return false;
				}
			}
			return true;
		}

		private static bool IsFormatVersionValid(string formatVersion)
		{
			if (formatVersion == "1.0")
			{
				return true;
			}
			string[] compatibleConfigFileVersions = CompatibleConfigFileVersions;
			foreach (string text in compatibleConfigFileVersions)
			{
				if (text == formatVersion)
				{
					return true;
				}
			}
			return false;
		}
	}

	private abstract class DragHandlerBase : NativeWindow, IMessageFilter
	{
		private Point m_startMousePosition = Point.Empty;

		protected abstract Control DragControl { get; }

		protected Point StartMousePosition
		{
			get
			{
				return m_startMousePosition;
			}
			private set
			{
				m_startMousePosition = value;
			}
		}

		protected bool BeginDrag()
		{
			lock (this)
			{
				if (DragControl == null)
				{
					return false;
				}
				StartMousePosition = Control.MousePosition;
				if (!NativeMethods.DragDetect(DragControl.Handle, StartMousePosition))
				{
					return false;
				}
				((Control)DragControl.FindForm()).Capture = true;
				((NativeWindow)this).AssignHandle(((Control)DragControl.FindForm()).Handle);
				Application.AddMessageFilter((IMessageFilter)(object)this);
				return true;
			}
		}

		protected abstract void OnDragging();

		protected abstract void OnEndDrag(bool abort);

		private void EndDrag(bool abort)
		{
			((NativeWindow)this).ReleaseHandle();
			Application.RemoveMessageFilter((IMessageFilter)(object)this);
			((Control)DragControl.FindForm()).Capture = false;
			OnEndDrag(abort);
		}

		bool IMessageFilter.PreFilterMessage(ref Message m)
		{
			if (((Message)(ref m)).Msg == 512)
			{
				OnDragging();
			}
			else if (((Message)(ref m)).Msg == 514)
			{
				EndDrag(abort: false);
			}
			else if (((Message)(ref m)).Msg == 533)
			{
				EndDrag(abort: true);
			}
			else if (((Message)(ref m)).Msg == 256 && (int)((Message)(ref m)).WParam == 27)
			{
				EndDrag(abort: true);
			}
			return OnPreFilterMessage(ref m);
		}

		protected virtual bool OnPreFilterMessage(ref Message m)
		{
			return false;
		}

		protected sealed override void WndProc(ref Message m)
		{
			if (((Message)(ref m)).Msg == 31 || ((Message)(ref m)).Msg == 533)
			{
				EndDrag(abort: true);
			}
			((NativeWindow)this).WndProc(ref m);
		}
	}

	private abstract class DragHandler : DragHandlerBase
	{
		private DockPanel m_dockPanel;

		private IDragSource m_dragSource;

		public DockPanel DockPanel => m_dockPanel;

		protected IDragSource DragSource
		{
			get
			{
				return m_dragSource;
			}
			set
			{
				m_dragSource = value;
			}
		}

		protected sealed override Control DragControl
		{
			get
			{
				if (DragSource != null)
				{
					return DragSource.DragControl;
				}
				return null;
			}
		}

		protected DragHandler(DockPanel dockPanel)
		{
			m_dockPanel = dockPanel;
		}

		protected sealed override bool OnPreFilterMessage(ref Message m)
		{
			if ((((Message)(ref m)).Msg == 256 || ((Message)(ref m)).Msg == 257) && ((int)((Message)(ref m)).WParam == 17 || (int)((Message)(ref m)).WParam == 16))
			{
				OnDragging();
			}
			return base.OnPreFilterMessage(ref m);
		}
	}

	private sealed class SplitterDragHandler : DragHandler
	{
		private class SplitterOutline
		{
			private DragForm m_dragForm;

			private DragForm DragForm => m_dragForm;

			public SplitterOutline()
			{
				m_dragForm = new DragForm();
				SetDragForm(Rectangle.Empty);
				((Control)DragForm).BackColor = Color.Black;
				((Form)DragForm).Opacity = 0.7;
				DragForm.Show(bActivate: false);
			}

			public void Show(Rectangle rect)
			{
				SetDragForm(rect);
			}

			public void Close()
			{
				((Form)DragForm).Close();
			}

			private void SetDragForm(Rectangle rect)
			{
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Expected O, but got Unknown
				((Control)DragForm).Bounds = rect;
				if (rect == Rectangle.Empty)
				{
					((Control)DragForm).Region = new Region(Rectangle.Empty);
				}
				else if (((Control)DragForm).Region != null)
				{
					((Control)DragForm).Region = null;
				}
			}
		}

		private SplitterOutline m_outline;

		private Rectangle m_rectSplitter;

		public new ISplitterDragSource DragSource
		{
			get
			{
				return base.DragSource as ISplitterDragSource;
			}
			private set
			{
				base.DragSource = value;
			}
		}

		private SplitterOutline Outline
		{
			get
			{
				return m_outline;
			}
			set
			{
				m_outline = value;
			}
		}

		private Rectangle RectSplitter
		{
			get
			{
				return m_rectSplitter;
			}
			set
			{
				m_rectSplitter = value;
			}
		}

		public SplitterDragHandler(DockPanel dockPanel)
			: base(dockPanel)
		{
		}

		public void BeginDrag(ISplitterDragSource dragSource, Rectangle rectSplitter)
		{
			DragSource = dragSource;
			RectSplitter = rectSplitter;
			if (!BeginDrag())
			{
				DragSource = null;
				return;
			}
			Outline = new SplitterOutline();
			Outline.Show(rectSplitter);
			DragSource.BeginDrag(rectSplitter);
		}

		protected override void OnDragging()
		{
			Outline.Show(GetSplitterOutlineBounds(Control.MousePosition));
		}

		protected override void OnEndDrag(bool abort)
		{
			base.DockPanel.SuspendLayout(allWindows: true);
			Outline.Close();
			if (!abort)
			{
				DragSource.MoveSplitter(GetMovingOffset(Control.MousePosition));
			}
			DragSource.EndDrag();
			base.DockPanel.ResumeLayout(performLayout: true, allWindows: true);
		}

		private int GetMovingOffset(Point ptMouse)
		{
			Rectangle splitterOutlineBounds = GetSplitterOutlineBounds(ptMouse);
			if (DragSource.IsVertical)
			{
				return splitterOutlineBounds.X - RectSplitter.X;
			}
			return splitterOutlineBounds.Y - RectSplitter.Y;
		}

		private Rectangle GetSplitterOutlineBounds(Point ptMouse)
		{
			Rectangle dragLimitBounds = DragSource.DragLimitBounds;
			Rectangle rectSplitter = RectSplitter;
			if (dragLimitBounds.Width <= 0 || dragLimitBounds.Height <= 0)
			{
				return rectSplitter;
			}
			if (DragSource.IsVertical)
			{
				rectSplitter.X += ptMouse.X - base.StartMousePosition.X;
				rectSplitter.Height = dragLimitBounds.Height;
			}
			else
			{
				rectSplitter.Y += ptMouse.Y - base.StartMousePosition.Y;
				rectSplitter.Width = dragLimitBounds.Width;
			}
			if (rectSplitter.Left < dragLimitBounds.Left)
			{
				rectSplitter.X = dragLimitBounds.X;
			}
			if (rectSplitter.Top < dragLimitBounds.Top)
			{
				rectSplitter.Y = dragLimitBounds.Y;
			}
			if (rectSplitter.Right > dragLimitBounds.Right)
			{
				rectSplitter.X -= rectSplitter.Right - dragLimitBounds.Right;
			}
			if (rectSplitter.Bottom > dragLimitBounds.Bottom)
			{
				rectSplitter.Y -= rectSplitter.Bottom - dragLimitBounds.Bottom;
			}
			return rectSplitter;
		}
	}

	private sealed class DockDragHandler : DragHandler
	{
		private class DockIndicator : DragForm
		{
			private interface IHitTest
			{
				DockStyle Status { get; set; }

				DockStyle HitTest(Point pt);
			}

			private class PanelIndicator : PictureBox, IHitTest
			{
				private static Image _imagePanelLeft = (Image)(object)Resources.DockIndicator_PanelLeft;

				private static Image _imagePanelRight = (Image)(object)Resources.DockIndicator_PanelRight;

				private static Image _imagePanelTop = (Image)(object)Resources.DockIndicator_PanelTop;

				private static Image _imagePanelBottom = (Image)(object)Resources.DockIndicator_PanelBottom;

				private static Image _imagePanelFill = (Image)(object)Resources.DockIndicator_PanelFill;

				private static Image _imagePanelLeftActive = (Image)(object)Resources.DockIndicator_PanelLeft_Active;

				private static Image _imagePanelRightActive = (Image)(object)Resources.DockIndicator_PanelRight_Active;

				private static Image _imagePanelTopActive = (Image)(object)Resources.DockIndicator_PanelTop_Active;

				private static Image _imagePanelBottomActive = (Image)(object)Resources.DockIndicator_PanelBottom_Active;

				private static Image _imagePanelFillActive = (Image)(object)Resources.DockIndicator_PanelFill_Active;

				private DockStyle m_dockStyle;

				private DockStyle m_status;

				private bool m_isActivated;

				private DockStyle DockStyle => m_dockStyle;

				public DockStyle Status
				{
					get
					{
						//IL_0001: Unknown result type (might be due to invalid IL or missing references)
						return m_status;
					}
					set
					{
						//IL_0000: Unknown result type (might be due to invalid IL or missing references)
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0013: Unknown result type (might be due to invalid IL or missing references)
						//IL_0018: Unknown result type (might be due to invalid IL or missing references)
						//IL_0009: Unknown result type (might be due to invalid IL or missing references)
						//IL_001d: Unknown result type (might be due to invalid IL or missing references)
						//IL_001e: Unknown result type (might be due to invalid IL or missing references)
						//IL_0025: Unknown result type (might be due to invalid IL or missing references)
						//IL_002b: Invalid comparison between Unknown and I4
						if (value != DockStyle && (int)value != 0)
						{
							throw new InvalidEnumArgumentException();
						}
						if (m_status != value)
						{
							m_status = value;
							IsActivated = (int)m_status != 0;
						}
					}
				}

				private Image ImageInactive
				{
					get
					{
						//IL_0001: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Invalid comparison between Unknown and I4
						//IL_0010: Unknown result type (might be due to invalid IL or missing references)
						//IL_0016: Invalid comparison between Unknown and I4
						//IL_001f: Unknown result type (might be due to invalid IL or missing references)
						//IL_0025: Invalid comparison between Unknown and I4
						//IL_002e: Unknown result type (might be due to invalid IL or missing references)
						//IL_0034: Invalid comparison between Unknown and I4
						//IL_003d: Unknown result type (might be due to invalid IL or missing references)
						//IL_0043: Invalid comparison between Unknown and I4
						if ((int)DockStyle == 3)
						{
							return _imagePanelLeft;
						}
						if ((int)DockStyle == 4)
						{
							return _imagePanelRight;
						}
						if ((int)DockStyle == 1)
						{
							return _imagePanelTop;
						}
						if ((int)DockStyle == 2)
						{
							return _imagePanelBottom;
						}
						if ((int)DockStyle == 5)
						{
							return _imagePanelFill;
						}
						return null;
					}
				}

				private Image ImageActive
				{
					get
					{
						//IL_0001: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Invalid comparison between Unknown and I4
						//IL_0010: Unknown result type (might be due to invalid IL or missing references)
						//IL_0016: Invalid comparison between Unknown and I4
						//IL_001f: Unknown result type (might be due to invalid IL or missing references)
						//IL_0025: Invalid comparison between Unknown and I4
						//IL_002e: Unknown result type (might be due to invalid IL or missing references)
						//IL_0034: Invalid comparison between Unknown and I4
						//IL_003d: Unknown result type (might be due to invalid IL or missing references)
						//IL_0043: Invalid comparison between Unknown and I4
						if ((int)DockStyle == 3)
						{
							return _imagePanelLeftActive;
						}
						if ((int)DockStyle == 4)
						{
							return _imagePanelRightActive;
						}
						if ((int)DockStyle == 1)
						{
							return _imagePanelTopActive;
						}
						if ((int)DockStyle == 2)
						{
							return _imagePanelBottomActive;
						}
						if ((int)DockStyle == 5)
						{
							return _imagePanelFillActive;
						}
						return null;
					}
				}

				private bool IsActivated
				{
					get
					{
						return m_isActivated;
					}
					set
					{
						m_isActivated = value;
						((PictureBox)this).Image = (IsActivated ? ImageActive : ImageInactive);
					}
				}

				public PanelIndicator(DockStyle dockStyle)
				{
					//IL_0007: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					m_dockStyle = dockStyle;
					((PictureBox)this).SizeMode = (PictureBoxSizeMode)2;
					((PictureBox)this).Image = ImageInactive;
				}

				public DockStyle HitTest(Point pt)
				{
					//IL_0022: Unknown result type (might be due to invalid IL or missing references)
					if (!((Control)this).Visible || !((Control)this).ClientRectangle.Contains(((Control)this).PointToClient(pt)))
					{
						return (DockStyle)0;
					}
					return DockStyle;
				}
			}

			private class PaneIndicator : PictureBox, IHitTest
			{
				private struct HotSpotIndex
				{
					private int m_x;

					private int m_y;

					private DockStyle m_dockStyle;

					public int X => m_x;

					public int Y => m_y;

					public DockStyle DockStyle => m_dockStyle;

					public HotSpotIndex(int x, int y, DockStyle dockStyle)
					{
						//IL_000f: Unknown result type (might be due to invalid IL or missing references)
						//IL_0010: Unknown result type (might be due to invalid IL or missing references)
						m_x = x;
						m_y = y;
						m_dockStyle = dockStyle;
					}
				}

				private static Bitmap _bitmapPaneDiamond = Resources.DockIndicator_PaneDiamond;

				private static Bitmap _bitmapPaneDiamondLeft = Resources.DockIndicator_PaneDiamond_Left;

				private static Bitmap _bitmapPaneDiamondRight = Resources.DockIndicator_PaneDiamond_Right;

				private static Bitmap _bitmapPaneDiamondTop = Resources.DockIndicator_PaneDiamond_Top;

				private static Bitmap _bitmapPaneDiamondBottom = Resources.DockIndicator_PaneDiamond_Bottom;

				private static Bitmap _bitmapPaneDiamondFill = Resources.DockIndicator_PaneDiamond_Fill;

				private static Bitmap _bitmapPaneDiamondHotSpot = Resources.DockIndicator_PaneDiamond_HotSpot;

				private static Bitmap _bitmapPaneDiamondHotSpotIndex = Resources.DockIndicator_PaneDiamond_HotSpotIndex;

				private static HotSpotIndex[] _hotSpots = new HotSpotIndex[5]
				{
					new HotSpotIndex(1, 0, (DockStyle)1),
					new HotSpotIndex(0, 1, (DockStyle)3),
					new HotSpotIndex(1, 1, (DockStyle)5),
					new HotSpotIndex(2, 1, (DockStyle)4),
					new HotSpotIndex(1, 2, (DockStyle)2)
				};

				private static GraphicsPath _displayingGraphicsPath = DrawHelper.CalculateGraphicsPathFromBitmap(_bitmapPaneDiamond);

				private DockStyle m_status;

				public static GraphicsPath DisplayingGraphicsPath => _displayingGraphicsPath;

				public DockStyle Status
				{
					get
					{
						//IL_0001: Unknown result type (might be due to invalid IL or missing references)
						return m_status;
					}
					set
					{
						//IL_0001: Unknown result type (might be due to invalid IL or missing references)
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0008: Unknown result type (might be due to invalid IL or missing references)
						//IL_001c: Unknown result type (might be due to invalid IL or missing references)
						//IL_0022: Invalid comparison between Unknown and I4
						//IL_0031: Unknown result type (might be due to invalid IL or missing references)
						//IL_0037: Invalid comparison between Unknown and I4
						//IL_0046: Unknown result type (might be due to invalid IL or missing references)
						//IL_004c: Invalid comparison between Unknown and I4
						//IL_005b: Unknown result type (might be due to invalid IL or missing references)
						//IL_0061: Invalid comparison between Unknown and I4
						//IL_0070: Unknown result type (might be due to invalid IL or missing references)
						//IL_0076: Invalid comparison between Unknown and I4
						m_status = value;
						if ((int)m_status == 0)
						{
							((PictureBox)this).Image = (Image)(object)_bitmapPaneDiamond;
						}
						else if ((int)m_status == 3)
						{
							((PictureBox)this).Image = (Image)(object)_bitmapPaneDiamondLeft;
						}
						else if ((int)m_status == 4)
						{
							((PictureBox)this).Image = (Image)(object)_bitmapPaneDiamondRight;
						}
						else if ((int)m_status == 1)
						{
							((PictureBox)this).Image = (Image)(object)_bitmapPaneDiamondTop;
						}
						else if ((int)m_status == 2)
						{
							((PictureBox)this).Image = (Image)(object)_bitmapPaneDiamondBottom;
						}
						else if ((int)m_status == 5)
						{
							((PictureBox)this).Image = (Image)(object)_bitmapPaneDiamondFill;
						}
					}
				}

				public PaneIndicator()
				{
					//IL_001e: Unknown result type (might be due to invalid IL or missing references)
					//IL_0028: Expected O, but got Unknown
					((PictureBox)this).SizeMode = (PictureBoxSizeMode)2;
					((PictureBox)this).Image = (Image)(object)_bitmapPaneDiamond;
					((Control)this).Region = new Region(DisplayingGraphicsPath);
				}

				public DockStyle HitTest(Point pt)
				{
					//IL_0088: Unknown result type (might be due to invalid IL or missing references)
					if (((Control)this).Visible)
					{
						pt = ((Control)this).PointToClient(pt);
						if (((Control)this).ClientRectangle.Contains(pt))
						{
							for (int i = _hotSpots.GetLowerBound(0); i <= _hotSpots.GetUpperBound(0); i++)
							{
								if (_bitmapPaneDiamondHotSpot.GetPixel(pt.X, pt.Y) == _bitmapPaneDiamondHotSpotIndex.GetPixel(_hotSpots[i].X, _hotSpots[i].Y))
								{
									return _hotSpots[i].DockStyle;
								}
							}
							return (DockStyle)0;
						}
						return (DockStyle)0;
					}
					return (DockStyle)0;
				}
			}

			private int _PanelIndicatorMargin = 10;

			private DockDragHandler m_dragHandler;

			private PaneIndicator m_paneDiamond;

			private PanelIndicator m_panelLeft;

			private PanelIndicator m_panelRight;

			private PanelIndicator m_panelTop;

			private PanelIndicator m_panelBottom;

			private PanelIndicator m_panelFill;

			private bool m_fullPanelEdge;

			private DockPane m_dockPane;

			private IHitTest m_hitTest;

			private PaneIndicator PaneDiamond
			{
				get
				{
					if (m_paneDiamond == null)
					{
						m_paneDiamond = new PaneIndicator();
					}
					return m_paneDiamond;
				}
			}

			private PanelIndicator PanelLeft
			{
				get
				{
					if (m_panelLeft == null)
					{
						m_panelLeft = new PanelIndicator((DockStyle)3);
					}
					return m_panelLeft;
				}
			}

			private PanelIndicator PanelRight
			{
				get
				{
					if (m_panelRight == null)
					{
						m_panelRight = new PanelIndicator((DockStyle)4);
					}
					return m_panelRight;
				}
			}

			private PanelIndicator PanelTop
			{
				get
				{
					if (m_panelTop == null)
					{
						m_panelTop = new PanelIndicator((DockStyle)1);
					}
					return m_panelTop;
				}
			}

			private PanelIndicator PanelBottom
			{
				get
				{
					if (m_panelBottom == null)
					{
						m_panelBottom = new PanelIndicator((DockStyle)2);
					}
					return m_panelBottom;
				}
			}

			private PanelIndicator PanelFill
			{
				get
				{
					if (m_panelFill == null)
					{
						m_panelFill = new PanelIndicator((DockStyle)5);
					}
					return m_panelFill;
				}
			}

			public bool FullPanelEdge
			{
				get
				{
					return m_fullPanelEdge;
				}
				set
				{
					if (m_fullPanelEdge != value)
					{
						m_fullPanelEdge = value;
						RefreshChanges();
					}
				}
			}

			public DockDragHandler DragHandler => m_dragHandler;

			public DockPanel DockPanel => DragHandler.DockPanel;

			public DockPane DockPane
			{
				get
				{
					return m_dockPane;
				}
				internal set
				{
					if (m_dockPane != value)
					{
						DockPane displayingPane = DisplayingPane;
						m_dockPane = value;
						if (displayingPane != DisplayingPane)
						{
							RefreshChanges();
						}
					}
				}
			}

			private IHitTest HitTestResult
			{
				get
				{
					return m_hitTest;
				}
				set
				{
					if (m_hitTest != value)
					{
						if (m_hitTest != null)
						{
							m_hitTest.Status = (DockStyle)0;
						}
						m_hitTest = value;
					}
				}
			}

			private DockPane DisplayingPane
			{
				get
				{
					if (!ShouldPaneDiamondVisible())
					{
						return null;
					}
					return DockPane;
				}
			}

			public DockIndicator(DockDragHandler dragHandler)
			{
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Expected O, but got Unknown
				m_dragHandler = dragHandler;
				((Control)this).Controls.AddRange((Control[])(object)new Control[6]
				{
					(Control)PaneDiamond,
					(Control)PanelLeft,
					(Control)PanelRight,
					(Control)PanelTop,
					(Control)PanelBottom,
					(Control)PanelFill
				});
				((Control)this).Region = new Region(Rectangle.Empty);
			}

			private void RefreshChanges()
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ea: Expected O, but got Unknown
				Region val = new Region(Rectangle.Empty);
				Rectangle rectangle = (FullPanelEdge ? DockPanel.DockArea : DockPanel.DocumentWindowBounds);
				rectangle = ((Control)this).RectangleToClient(((Control)DockPanel).RectangleToScreen(rectangle));
				if (ShouldPanelIndicatorVisible(DockState.DockLeft))
				{
					((Control)PanelLeft).Location = new Point(rectangle.X + _PanelIndicatorMargin, rectangle.Y + (rectangle.Height - ((Control)PanelRight).Height) / 2);
					((Control)PanelLeft).Visible = true;
					val.Union(((Control)PanelLeft).Bounds);
				}
				else
				{
					((Control)PanelLeft).Visible = false;
				}
				if (ShouldPanelIndicatorVisible(DockState.DockRight))
				{
					((Control)PanelRight).Location = new Point(rectangle.X + rectangle.Width - ((Control)PanelRight).Width - _PanelIndicatorMargin, rectangle.Y + (rectangle.Height - ((Control)PanelRight).Height) / 2);
					((Control)PanelRight).Visible = true;
					val.Union(((Control)PanelRight).Bounds);
				}
				else
				{
					((Control)PanelRight).Visible = false;
				}
				if (ShouldPanelIndicatorVisible(DockState.DockTop))
				{
					((Control)PanelTop).Location = new Point(rectangle.X + (rectangle.Width - ((Control)PanelTop).Width) / 2, rectangle.Y + _PanelIndicatorMargin);
					((Control)PanelTop).Visible = true;
					val.Union(((Control)PanelTop).Bounds);
				}
				else
				{
					((Control)PanelTop).Visible = false;
				}
				if (ShouldPanelIndicatorVisible(DockState.DockBottom))
				{
					((Control)PanelBottom).Location = new Point(rectangle.X + (rectangle.Width - ((Control)PanelBottom).Width) / 2, rectangle.Y + rectangle.Height - ((Control)PanelBottom).Height - _PanelIndicatorMargin);
					((Control)PanelBottom).Visible = true;
					val.Union(((Control)PanelBottom).Bounds);
				}
				else
				{
					((Control)PanelBottom).Visible = false;
				}
				if (ShouldPanelIndicatorVisible(DockState.Document))
				{
					Rectangle rectangle2 = ((Control)this).RectangleToClient(((Control)DockPanel).RectangleToScreen(DockPanel.DocumentWindowBounds));
					((Control)PanelFill).Location = new Point(rectangle2.X + (rectangle2.Width - ((Control)PanelFill).Width) / 2, rectangle2.Y + (rectangle2.Height - ((Control)PanelFill).Height) / 2);
					((Control)PanelFill).Visible = true;
					val.Union(((Control)PanelFill).Bounds);
				}
				else
				{
					((Control)PanelFill).Visible = false;
				}
				if (ShouldPaneDiamondVisible())
				{
					Rectangle rectangle3 = ((Control)this).RectangleToClient(((Control)DockPane).RectangleToScreen(((Control)DockPane).ClientRectangle));
					((Control)PaneDiamond).Location = new Point(rectangle3.Left + (rectangle3.Width - ((Control)PaneDiamond).Width) / 2, rectangle3.Top + (rectangle3.Height - ((Control)PaneDiamond).Height) / 2);
					((Control)PaneDiamond).Visible = true;
					object obj = PaneIndicator.DisplayingGraphicsPath.Clone();
					GraphicsPath val2 = (GraphicsPath)((obj is GraphicsPath) ? obj : null);
					try
					{
						Point[] array = new Point[3]
						{
							new Point(((Control)PaneDiamond).Left, ((Control)PaneDiamond).Top),
							new Point(((Control)PaneDiamond).Right, ((Control)PaneDiamond).Top),
							new Point(((Control)PaneDiamond).Left, ((Control)PaneDiamond).Bottom)
						};
						Matrix val3 = new Matrix(((Control)PaneDiamond).ClientRectangle, array);
						try
						{
							val2.Transform(val3);
						}
						finally
						{
							((IDisposable)val3)?.Dispose();
						}
						val.Union(val2);
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
				}
				else
				{
					((Control)PaneDiamond).Visible = false;
				}
				((Control)this).Region = val;
			}

			private bool ShouldPanelIndicatorVisible(DockState dockState)
			{
				if (!((Control)this).Visible)
				{
					return false;
				}
				if (((Control)DockPanel.DockWindows[dockState]).Visible)
				{
					return false;
				}
				return DragHandler.DragSource.IsDockStateValid(dockState);
			}

			private bool ShouldPaneDiamondVisible()
			{
				if (DockPane == null)
				{
					return false;
				}
				if (!DockPanel.AllowEndUserNestedDocking)
				{
					return false;
				}
				return DragHandler.DragSource.CanDockTo(DockPane);
			}

			public override void Show(bool bActivate)
			{
				base.Show(bActivate);
				((Control)this).Bounds = SystemInformation.VirtualScreen;
				RefreshChanges();
			}

			public void TestDrop()
			{
				//IL_001f: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0118: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				Point mousePosition = Control.MousePosition;
				DockPane = DockHelper.PaneAtPoint(mousePosition, DockPanel);
				if ((int)TestDrop(PanelLeft, mousePosition) != 0)
				{
					HitTestResult = PanelLeft;
				}
				else if ((int)TestDrop(PanelRight, mousePosition) != 0)
				{
					HitTestResult = PanelRight;
				}
				else if ((int)TestDrop(PanelTop, mousePosition) != 0)
				{
					HitTestResult = PanelTop;
				}
				else if ((int)TestDrop(PanelBottom, mousePosition) != 0)
				{
					HitTestResult = PanelBottom;
				}
				else if ((int)TestDrop(PanelFill, mousePosition) != 0)
				{
					HitTestResult = PanelFill;
				}
				else if ((int)TestDrop(PaneDiamond, mousePosition) != 0)
				{
					HitTestResult = PaneDiamond;
				}
				else
				{
					HitTestResult = null;
				}
				if (HitTestResult != null)
				{
					if (HitTestResult is PaneIndicator)
					{
						DragHandler.Outline.Show(DockPane, HitTestResult.Status);
					}
					else
					{
						DragHandler.Outline.Show(DockPanel, HitTestResult.Status, FullPanelEdge);
					}
				}
			}

			private static DockStyle TestDrop(IHitTest hitTest, Point pt)
			{
				//IL_0003: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				return hitTest.Status = hitTest.HitTest(pt);
			}
		}

		private class DockOutline : DockOutlineBase
		{
			private DragForm m_dragForm;

			private DragForm DragForm => m_dragForm;

			public DockOutline()
			{
				m_dragForm = new DragForm();
				SetDragForm(Rectangle.Empty);
				((Control)DragForm).BackColor = SystemColors.ActiveCaption;
				((Form)DragForm).Opacity = 0.5;
				DragForm.Show(bActivate: false);
			}

			protected override void OnShow()
			{
				CalculateRegion();
			}

			protected override void OnClose()
			{
				((Form)DragForm).Close();
			}

			private void CalculateRegion()
			{
				//IL_0040: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				if (!base.SameAsOldValue)
				{
					if (!base.FloatWindowBounds.IsEmpty)
					{
						SetOutline(base.FloatWindowBounds);
					}
					else if (base.DockTo is DockPanel)
					{
						SetOutline(base.DockTo as DockPanel, base.Dock, base.ContentIndex != 0);
					}
					else if (base.DockTo is DockPane)
					{
						SetOutline(base.DockTo as DockPane, base.Dock, base.ContentIndex);
					}
					else
					{
						SetOutline();
					}
				}
			}

			private void SetOutline()
			{
				SetDragForm(Rectangle.Empty);
			}

			private void SetOutline(Rectangle floatWindowBounds)
			{
				SetDragForm(floatWindowBounds);
			}

			private void SetOutline(DockPanel dockPanel, DockStyle dock, bool fullPanelEdge)
			{
				//IL_0026: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Invalid comparison between Unknown and I4
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Invalid comparison between Unknown and I4
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Invalid comparison between Unknown and I4
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Invalid comparison between Unknown and I4
				//IL_00de: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e0: Invalid comparison between Unknown and I4
				Rectangle dragForm = (fullPanelEdge ? dockPanel.DockArea : dockPanel.DocumentWindowBounds);
				dragForm.Location = ((Control)dockPanel).PointToScreen(dragForm.Location);
				if ((int)dock == 1)
				{
					int dockWindowSize = dockPanel.GetDockWindowSize(DockState.DockTop);
					dragForm = new Rectangle(dragForm.X, dragForm.Y, dragForm.Width, dockWindowSize);
				}
				else if ((int)dock == 2)
				{
					int dockWindowSize2 = dockPanel.GetDockWindowSize(DockState.DockBottom);
					dragForm = new Rectangle(dragForm.X, dragForm.Bottom - dockWindowSize2, dragForm.Width, dockWindowSize2);
				}
				else if ((int)dock == 3)
				{
					int dockWindowSize3 = dockPanel.GetDockWindowSize(DockState.DockLeft);
					dragForm = new Rectangle(dragForm.X, dragForm.Y, dockWindowSize3, dragForm.Height);
				}
				else if ((int)dock == 4)
				{
					int dockWindowSize4 = dockPanel.GetDockWindowSize(DockState.DockRight);
					dragForm = new Rectangle(dragForm.Right - dockWindowSize4, dragForm.Y, dockWindowSize4, dragForm.Height);
				}
				else if ((int)dock == 5)
				{
					dragForm = dockPanel.DocumentWindowBounds;
					dragForm.Location = ((Control)dockPanel).PointToScreen(dragForm.Location);
				}
				SetDragForm(dragForm);
			}

			private void SetOutline(DockPane pane, DockStyle dock, int contentIndex)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0002: Invalid comparison between Unknown and I4
				//IL_000e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0010: Invalid comparison between Unknown and I4
				//IL_0029: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Invalid comparison between Unknown and I4
				//IL_0154: Unknown result type (might be due to invalid IL or missing references)
				//IL_015b: Expected O, but got Unknown
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0046: Invalid comparison between Unknown and I4
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Invalid comparison between Unknown and I4
				//IL_0172: Unknown result type (might be due to invalid IL or missing references)
				//IL_0179: Expected O, but got Unknown
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				//IL_0065: Invalid comparison between Unknown and I4
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_0069: Invalid comparison between Unknown and I4
				if ((int)dock != 5)
				{
					Rectangle displayingRectangle = pane.DisplayingRectangle;
					if ((int)dock == 4)
					{
						displayingRectangle.X += displayingRectangle.Width / 2;
					}
					if ((int)dock == 2)
					{
						displayingRectangle.Y += displayingRectangle.Height / 2;
					}
					if ((int)dock == 3 || (int)dock == 4)
					{
						displayingRectangle.Width -= displayingRectangle.Width / 2;
					}
					if ((int)dock == 1 || (int)dock == 2)
					{
						displayingRectangle.Height -= displayingRectangle.Height / 2;
					}
					displayingRectangle.Location = ((Control)pane).PointToScreen(displayingRectangle.Location);
					SetDragForm(displayingRectangle);
					return;
				}
				if (contentIndex == -1)
				{
					Rectangle displayingRectangle2 = pane.DisplayingRectangle;
					displayingRectangle2.Location = ((Control)pane).PointToScreen(displayingRectangle2.Location);
					SetDragForm(displayingRectangle2);
					return;
				}
				GraphicsPath outline = pane.TabStripControl.GetOutline(contentIndex);
				try
				{
					RectangleF bounds = outline.GetBounds();
					Rectangle rectangle = new Rectangle((int)bounds.X, (int)bounds.Y, (int)bounds.Width, (int)bounds.Height);
					Matrix val = new Matrix(rectangle, new Point[3]
					{
						new Point(0, 0),
						new Point(rectangle.Width, 0),
						new Point(0, rectangle.Height)
					});
					try
					{
						outline.Transform(val);
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
					Region region = new Region(outline);
					SetDragForm(rectangle, region);
				}
				finally
				{
					((IDisposable)outline)?.Dispose();
				}
			}

			private void SetDragForm(Rectangle rect)
			{
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Expected O, but got Unknown
				((Control)DragForm).Bounds = rect;
				if (rect == Rectangle.Empty)
				{
					((Control)DragForm).Region = new Region(Rectangle.Empty);
				}
				else if (((Control)DragForm).Region != null)
				{
					((Control)DragForm).Region = null;
				}
			}

			private void SetDragForm(Rectangle rect, Region region)
			{
				((Control)DragForm).Bounds = rect;
				((Control)DragForm).Region = region;
			}
		}

		private DockOutlineBase m_outline;

		private DockIndicator m_indicator;

		private Rectangle m_floatOutlineBounds;

		public new IDockDragSource DragSource
		{
			get
			{
				return base.DragSource as IDockDragSource;
			}
			set
			{
				base.DragSource = value;
			}
		}

		public DockOutlineBase Outline
		{
			get
			{
				return m_outline;
			}
			private set
			{
				m_outline = value;
			}
		}

		private DockIndicator Indicator
		{
			get
			{
				return m_indicator;
			}
			set
			{
				m_indicator = value;
			}
		}

		private Rectangle FloatOutlineBounds
		{
			get
			{
				return m_floatOutlineBounds;
			}
			set
			{
				m_floatOutlineBounds = value;
			}
		}

		public DockDragHandler(DockPanel panel)
			: base(panel)
		{
		}

		public void BeginDrag(IDockDragSource dragSource)
		{
			DragSource = dragSource;
			if (!BeginDrag())
			{
				DragSource = null;
				return;
			}
			Outline = new DockOutline();
			Indicator = new DockIndicator(this);
			Indicator.Show(bActivate: false);
			FloatOutlineBounds = DragSource.BeginDrag(base.StartMousePosition);
		}

		protected override void OnDragging()
		{
			TestDrop();
		}

		protected override void OnEndDrag(bool abort)
		{
			base.DockPanel.SuspendLayout(allWindows: true);
			Outline.Close();
			((Form)Indicator).Close();
			EndDrag(abort);
			base.DockPanel.PerformMdiClientLayout();
			base.DockPanel.ResumeLayout(performLayout: true, allWindows: true);
			DragSource = null;
		}

		private void TestDrop()
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Invalid comparison between Unknown and I4
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			Outline.FlagTestDrop = false;
			Indicator.FullPanelEdge = (Control.ModifierKeys & 0x10000) != 0;
			if ((Control.ModifierKeys & 0x20000) == 0)
			{
				Indicator.TestDrop();
				if (!Outline.FlagTestDrop)
				{
					DockPane dockPane = DockHelper.PaneAtPoint(Control.MousePosition, base.DockPanel);
					if (dockPane != null && DragSource.IsDockStateValid(dockPane.DockState))
					{
						dockPane.TestDrop(DragSource, Outline);
					}
				}
				if (!Outline.FlagTestDrop && DragSource.IsDockStateValid(DockState.Float))
				{
					DockHelper.FloatWindowAtPoint(Control.MousePosition, base.DockPanel)?.TestDrop(DragSource, Outline);
				}
			}
			else
			{
				Indicator.DockPane = DockHelper.PaneAtPoint(Control.MousePosition, base.DockPanel);
			}
			if (!Outline.FlagTestDrop && DragSource.IsDockStateValid(DockState.Float))
			{
				Rectangle floatOutlineBounds = FloatOutlineBounds;
				floatOutlineBounds.Offset(Control.MousePosition.X - base.StartMousePosition.X, Control.MousePosition.Y - base.StartMousePosition.Y);
				Outline.Show(floatOutlineBounds);
			}
			if (!Outline.FlagTestDrop)
			{
				Cursor.Current = Cursors.No;
				Outline.Show();
			}
			else
			{
				Cursor.Current = DragControl.Cursor;
			}
		}

		private void EndDrag(bool abort)
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			if (!abort)
			{
				if (!Outline.FloatWindowBounds.IsEmpty)
				{
					DragSource.FloatAt(Outline.FloatWindowBounds);
				}
				else if (Outline.DockTo is DockPane)
				{
					DockPane pane = Outline.DockTo as DockPane;
					DragSource.DockTo(pane, Outline.Dock, Outline.ContentIndex);
				}
				else if (Outline.DockTo is DockPanel)
				{
					DockPanel dockPanel = Outline.DockTo as DockPanel;
					dockPanel.UpdateDockWindowZOrder(Outline.Dock, Outline.FlagFullEdge);
					DragSource.DockTo(dockPanel, Outline.Dock);
				}
			}
		}
	}

	private class AutoHideWindowControl : Panel, ISplitterDragSource, IDragSource
	{
		private class SplitterControl : SplitterBase
		{
			private AutoHideWindowControl m_autoHideWindow;

			private AutoHideWindowControl AutoHideWindow => m_autoHideWindow;

			protected override int SplitterSize => 4;

			public SplitterControl(AutoHideWindowControl autoHideWindow)
			{
				m_autoHideWindow = autoHideWindow;
			}

			protected override void StartDrag()
			{
				AutoHideWindow.DockPanel.BeginDrag(AutoHideWindow, ((Control)AutoHideWindow).RectangleToScreen(((Control)this).Bounds));
			}
		}

		private const int ANIMATE_TIME = 100;

		private Timer m_timerMouseTrack;

		private SplitterControl m_splitter;

		private DockPanel m_dockPanel;

		private DockPane m_activePane;

		private IDockContent m_activeContent;

		private bool m_flagAnimate = true;

		private bool m_flagDragging;

		public DockPanel DockPanel => m_dockPanel;

		public DockPane ActivePane => m_activePane;

		public IDockContent ActiveContent
		{
			get
			{
				return m_activeContent;
			}
			set
			{
				if (value == m_activeContent)
				{
					return;
				}
				if (value != null && (!DockHelper.IsDockStateAutoHide(value.DockHandler.DockState) || value.DockHandler.DockPanel != DockPanel))
				{
					throw new InvalidOperationException(Strings.DockPanel_ActiveAutoHideContent_InvalidValue);
				}
				((Control)DockPanel).SuspendLayout();
				if (m_activeContent != null)
				{
					if (((Control)m_activeContent.DockHandler.Form).ContainsFocus)
					{
						DockPanel.ContentFocusManager.GiveUpFocus(m_activeContent);
					}
					AnimateWindow(show: false);
				}
				m_activeContent = value;
				SetActivePane();
				if (ActivePane != null)
				{
					ActivePane.ActiveContent = m_activeContent;
				}
				if (m_activeContent != null)
				{
					AnimateWindow(show: true);
				}
				((Control)DockPanel).ResumeLayout();
				DockPanel.RefreshAutoHideStrip();
				SetTimerMouseTrack();
			}
		}

		public DockState DockState
		{
			get
			{
				if (ActiveContent != null)
				{
					return ActiveContent.DockHandler.DockState;
				}
				return DockState.Unknown;
			}
		}

		private bool FlagAnimate
		{
			get
			{
				return m_flagAnimate;
			}
			set
			{
				m_flagAnimate = value;
			}
		}

		internal bool FlagDragging
		{
			get
			{
				return m_flagDragging;
			}
			set
			{
				if (m_flagDragging != value)
				{
					m_flagDragging = value;
					SetTimerMouseTrack();
				}
			}
		}

		protected virtual Rectangle DisplayingRectangle
		{
			get
			{
				Rectangle clientRectangle = ((Control)this).ClientRectangle;
				if (DockState == DockState.DockBottomAutoHide)
				{
					clientRectangle.Y += 6;
					clientRectangle.Height -= 6;
				}
				else if (DockState == DockState.DockRightAutoHide)
				{
					clientRectangle.X += 6;
					clientRectangle.Width -= 6;
				}
				else if (DockState == DockState.DockTopAutoHide)
				{
					clientRectangle.Height -= 6;
				}
				else if (DockState == DockState.DockLeftAutoHide)
				{
					clientRectangle.Width -= 6;
				}
				return clientRectangle;
			}
		}

		bool ISplitterDragSource.IsVertical
		{
			get
			{
				if (DockState != DockState.DockLeftAutoHide)
				{
					return DockState == DockState.DockRightAutoHide;
				}
				return true;
			}
		}

		Rectangle ISplitterDragSource.DragLimitBounds
		{
			get
			{
				Rectangle dockArea = DockPanel.DockArea;
				if (((ISplitterDragSource)this).IsVertical)
				{
					dockArea.X += 24;
					dockArea.Width -= 48;
				}
				else
				{
					dockArea.Y += 24;
					dockArea.Height -= 48;
				}
				return ((Control)DockPanel).RectangleToScreen(dockArea);
			}
		}

		Control IDragSource.DragControl => (Control)(object)this;

		public AutoHideWindowControl(DockPanel dockPanel)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			m_dockPanel = dockPanel;
			m_timerMouseTrack = new Timer();
			m_timerMouseTrack.Tick += TimerMouseTrack_Tick;
			((Control)this).Visible = false;
			m_splitter = new SplitterControl(this);
			((Control)this).Controls.Add((Control)(object)m_splitter);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				((Component)(object)m_timerMouseTrack).Dispose();
			}
			((Control)this).Dispose(disposing);
		}

		private void SetActivePane()
		{
			DockPane dockPane = ((ActiveContent == null) ? null : ActiveContent.DockHandler.Pane);
			if (dockPane != m_activePane)
			{
				m_activePane = dockPane;
			}
		}

		private void AnimateWindow(bool show)
		{
			if (!FlagAnimate && ((Control)this).Visible != show)
			{
				((Control)this).Visible = show;
				return;
			}
			((Control)this).Parent.SuspendLayout();
			Rectangle rectangle = GetRectangle(!show);
			Rectangle rectangle2 = GetRectangle(show);
			int num2;
			int num3;
			int num4;
			int num = (num2 = (num3 = (num4 = 0)));
			if (DockState == DockState.DockTopAutoHide)
			{
				num4 = (show ? 1 : (-1));
			}
			else if (DockState == DockState.DockLeftAutoHide)
			{
				num3 = (show ? 1 : (-1));
			}
			else if (DockState == DockState.DockRightAutoHide)
			{
				num = ((!show) ? 1 : (-1));
				num3 = (show ? 1 : (-1));
			}
			else if (DockState == DockState.DockBottomAutoHide)
			{
				num2 = ((!show) ? 1 : (-1));
				num4 = (show ? 1 : (-1));
			}
			if (show)
			{
				((Control)this).Bounds = DockPanel.GetAutoHideWindowBounds(new Rectangle(-rectangle2.Width, -rectangle2.Height, rectangle2.Width, rectangle2.Height));
				if (!((Control)this).Visible)
				{
					((Control)this).Visible = true;
				}
				((Control)this).PerformLayout();
			}
			((Control)this).SuspendLayout();
			LayoutAnimateWindow(rectangle);
			if (!((Control)this).Visible)
			{
				((Control)this).Visible = true;
			}
			int num5 = 1;
			int num6 = ((rectangle.Width != rectangle2.Width) ? Math.Abs(rectangle.Width - rectangle2.Width) : Math.Abs(rectangle.Height - rectangle2.Height));
			int num7 = num6;
			DateTime now = DateTime.Now;
			while (rectangle != rectangle2)
			{
				DateTime now2 = DateTime.Now;
				rectangle.X += num * num5;
				rectangle.Y += num2 * num5;
				rectangle.Width += num3 * num5;
				rectangle.Height += num4 * num5;
				if (Math.Sign(rectangle2.X - rectangle.X) != Math.Sign(num))
				{
					rectangle.X = rectangle2.X;
				}
				if (Math.Sign(rectangle2.Y - rectangle.Y) != Math.Sign(num2))
				{
					rectangle.Y = rectangle2.Y;
				}
				if (Math.Sign(rectangle2.Width - rectangle.Width) != Math.Sign(num3))
				{
					rectangle.Width = rectangle2.Width;
				}
				if (Math.Sign(rectangle2.Height - rectangle.Height) != Math.Sign(num4))
				{
					rectangle.Height = rectangle2.Height;
				}
				LayoutAnimateWindow(rectangle);
				if (((Control)this).Parent != null)
				{
					((Control)this).Parent.Update();
				}
				num7 -= num5;
				do
				{
					TimeSpan timeSpan = new TimeSpan(0, 0, 0, 0, 100);
					TimeSpan timeSpan2 = DateTime.Now - now2;
					TimeSpan timeSpan3 = DateTime.Now - now;
					if ((int)(timeSpan - timeSpan3).TotalMilliseconds <= 0)
					{
						num5 = num7;
						break;
					}
					num5 = num7 * (int)timeSpan2.TotalMilliseconds / (int)(timeSpan - timeSpan3).TotalMilliseconds;
				}
				while (num5 < 1);
			}
			((Control)this).ResumeLayout();
			((Control)this).Parent.ResumeLayout();
		}

		private void LayoutAnimateWindow(Rectangle rect)
		{
			((Control)this).Bounds = DockPanel.GetAutoHideWindowBounds(rect);
			Rectangle clientRectangle = ((Control)this).ClientRectangle;
			if (DockState == DockState.DockLeftAutoHide)
			{
				((Control)ActivePane).Location = new Point(clientRectangle.Right - 2 - 4 - ((Control)ActivePane).Width, ((Control)ActivePane).Location.Y);
			}
			else if (DockState == DockState.DockTopAutoHide)
			{
				((Control)ActivePane).Location = new Point(((Control)ActivePane).Location.X, clientRectangle.Bottom - 2 - 4 - ((Control)ActivePane).Height);
			}
		}

		private Rectangle GetRectangle(bool show)
		{
			if (DockState == DockState.Unknown)
			{
				return Rectangle.Empty;
			}
			Rectangle autoHideWindowRectangle = DockPanel.AutoHideWindowRectangle;
			if (show)
			{
				return autoHideWindowRectangle;
			}
			if (DockState == DockState.DockLeftAutoHide)
			{
				autoHideWindowRectangle.Width = 0;
			}
			else if (DockState == DockState.DockRightAutoHide)
			{
				autoHideWindowRectangle.X += autoHideWindowRectangle.Width;
				autoHideWindowRectangle.Width = 0;
			}
			else if (DockState == DockState.DockTopAutoHide)
			{
				autoHideWindowRectangle.Height = 0;
			}
			else
			{
				autoHideWindowRectangle.Y += autoHideWindowRectangle.Height;
				autoHideWindowRectangle.Height = 0;
			}
			return autoHideWindowRectangle;
		}

		private void SetTimerMouseTrack()
		{
			if (ActivePane == null || ActivePane.IsActivated || FlagDragging)
			{
				m_timerMouseTrack.Enabled = false;
				return;
			}
			int num = SystemInformation.MouseHoverTime;
			if (num <= 0)
			{
				num = 400;
			}
			m_timerMouseTrack.Interval = 2 * num;
			m_timerMouseTrack.Enabled = true;
		}

		protected override void OnLayout(LayoutEventArgs levent)
		{
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			((ScrollableControl)this).DockPadding.All = 0;
			if (DockState == DockState.DockLeftAutoHide)
			{
				((ScrollableControl)this).DockPadding.Right = 2;
				((Control)m_splitter).Dock = (DockStyle)4;
			}
			else if (DockState == DockState.DockRightAutoHide)
			{
				((ScrollableControl)this).DockPadding.Left = 2;
				((Control)m_splitter).Dock = (DockStyle)3;
			}
			else if (DockState == DockState.DockTopAutoHide)
			{
				((ScrollableControl)this).DockPadding.Bottom = 2;
				((Control)m_splitter).Dock = (DockStyle)2;
			}
			else if (DockState == DockState.DockBottomAutoHide)
			{
				((ScrollableControl)this).DockPadding.Top = 2;
				((Control)m_splitter).Dock = (DockStyle)1;
			}
			Rectangle displayingRectangle = DisplayingRectangle;
			Rectangle bounds = new Rectangle(-displayingRectangle.Width, displayingRectangle.Y, displayingRectangle.Width, displayingRectangle.Height);
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is DockPane dockPane)
				{
					if (dockPane == ActivePane)
					{
						((Control)dockPane).Bounds = displayingRectangle;
					}
					else
					{
						((Control)dockPane).Bounds = bounds;
					}
				}
			}
			((ScrollableControl)this).OnLayout(levent);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			if (DockState == DockState.DockBottomAutoHide)
			{
				graphics.DrawLine(SystemPens.ControlLightLight, 0, 1, ((Control)this).ClientRectangle.Right, 1);
			}
			else if (DockState == DockState.DockRightAutoHide)
			{
				graphics.DrawLine(SystemPens.ControlLightLight, 1, 0, 1, ((Control)this).ClientRectangle.Bottom);
			}
			else if (DockState == DockState.DockTopAutoHide)
			{
				graphics.DrawLine(SystemPens.ControlDark, 0, ((Control)this).ClientRectangle.Height - 2, ((Control)this).ClientRectangle.Right, ((Control)this).ClientRectangle.Height - 2);
				graphics.DrawLine(SystemPens.ControlDarkDark, 0, ((Control)this).ClientRectangle.Height - 1, ((Control)this).ClientRectangle.Right, ((Control)this).ClientRectangle.Height - 1);
			}
			else if (DockState == DockState.DockLeftAutoHide)
			{
				graphics.DrawLine(SystemPens.ControlDark, ((Control)this).ClientRectangle.Width - 2, 0, ((Control)this).ClientRectangle.Width - 2, ((Control)this).ClientRectangle.Bottom);
				graphics.DrawLine(SystemPens.ControlDarkDark, ((Control)this).ClientRectangle.Width - 1, 0, ((Control)this).ClientRectangle.Width - 1, ((Control)this).ClientRectangle.Bottom);
			}
			((Control)this).OnPaint(e);
		}

		public void RefreshActiveContent()
		{
			if (ActiveContent != null && !DockHelper.IsDockStateAutoHide(ActiveContent.DockHandler.DockState))
			{
				FlagAnimate = false;
				ActiveContent = null;
				FlagAnimate = true;
			}
		}

		public void RefreshActivePane()
		{
			SetTimerMouseTrack();
		}

		private void TimerMouseTrack_Tick(object sender, EventArgs e)
		{
			if (((Control)this).IsDisposed)
			{
				return;
			}
			if (ActivePane == null || ActivePane.IsActivated)
			{
				m_timerMouseTrack.Enabled = false;
				return;
			}
			DockPane activePane = ActivePane;
			Point pt = ((Control)this).PointToClient(Control.MousePosition);
			Point pt2 = ((Control)DockPanel).PointToClient(Control.MousePosition);
			Rectangle tabStripRectangle = DockPanel.GetTabStripRectangle(activePane.DockState);
			if (!((Control)this).ClientRectangle.Contains(pt) && !tabStripRectangle.Contains(pt2))
			{
				ActiveContent = null;
				m_timerMouseTrack.Enabled = false;
			}
		}

		void ISplitterDragSource.BeginDrag(Rectangle rectSplitter)
		{
			FlagDragging = true;
		}

		void ISplitterDragSource.EndDrag()
		{
			FlagDragging = false;
		}

		void ISplitterDragSource.MoveSplitter(int offset)
		{
			Rectangle dockArea = DockPanel.DockArea;
			IDockContent activeContent = ActiveContent;
			if (DockState == DockState.DockLeftAutoHide && dockArea.Width > 0)
			{
				if (activeContent.DockHandler.AutoHidePortion < 1.0)
				{
					activeContent.DockHandler.AutoHidePortion += (double)offset / (double)dockArea.Width;
				}
				else
				{
					activeContent.DockHandler.AutoHidePortion = ((Control)this).Width + offset;
				}
			}
			else if (DockState == DockState.DockRightAutoHide && dockArea.Width > 0)
			{
				if (activeContent.DockHandler.AutoHidePortion < 1.0)
				{
					activeContent.DockHandler.AutoHidePortion -= (double)offset / (double)dockArea.Width;
				}
				else
				{
					activeContent.DockHandler.AutoHidePortion = ((Control)this).Width - offset;
				}
			}
			else if (DockState == DockState.DockBottomAutoHide && dockArea.Height > 0)
			{
				if (activeContent.DockHandler.AutoHidePortion < 1.0)
				{
					activeContent.DockHandler.AutoHidePortion -= (double)offset / (double)dockArea.Height;
				}
				else
				{
					activeContent.DockHandler.AutoHidePortion = ((Control)this).Height - offset;
				}
			}
			else if (DockState == DockState.DockTopAutoHide && dockArea.Height > 0)
			{
				if (activeContent.DockHandler.AutoHidePortion < 1.0)
				{
					activeContent.DockHandler.AutoHidePortion += (double)offset / (double)dockArea.Height;
				}
				else
				{
					activeContent.DockHandler.AutoHidePortion = ((Control)this).Height + offset;
				}
			}
		}
	}

	private static readonly object ActiveDocumentChangedEvent;

	private static readonly object ActiveContentChangedEvent;

	private static readonly object ActivePaneChangedEvent;

	private FocusManagerImpl m_focusManager;

	private DockPanelExtender m_extender;

	private DockPaneCollection m_panes;

	private FloatWindowCollection m_floatWindows;

	private AutoHideWindowControl m_autoHideWindow;

	private DockWindowCollection m_dockWindows;

	private DockContent m_dummyContent;

	private Control m_dummyControl;

	private Color m_BackColor;

	private AutoHideStripBase m_autoHideStripControl;

	private bool m_disposed;

	private bool m_allowEndUserDocking = true;

	private bool m_allowEndUserNestedDocking = true;

	private DockContentCollection m_contents = new DockContentCollection();

	private bool m_rightToLeftLayout;

	private bool m_showDocumentIcon;

	private DockPanelSkin m_dockPanelSkin = new DockPanelSkin();

	private DocumentTabStripLocation m_documentTabStripLocation;

	private double m_dockBottomPortion = 0.25;

	private double m_dockLeftPortion = 0.25;

	private double m_dockRightPortion = 0.25;

	private double m_dockTopPortion = 0.25;

	private Size m_defaultFloatWindowSize = new Size(300, 300);

	private DocumentStyle m_documentStyle;

	private PaintEventHandler m_dummyControlPaintEventHandler;

	private Rectangle[] m_clipRects;

	private static readonly object ContentAddedEvent;

	private static readonly object ContentRemovedEvent;

	private MdiClientController m_mdiClientController;

	private SplitterDragHandler m_splitterDragHandler;

	private DockDragHandler m_dockDragHandler;

	private IFocusManager FocusManager => m_focusManager;

	internal IContentFocusManager ContentFocusManager => m_focusManager;

	[Browsable(false)]
	public IDockContent ActiveContent => FocusManager.ActiveContent;

	[Browsable(false)]
	public DockPane ActivePane => FocusManager.ActivePane;

	[Browsable(false)]
	public IDockContent ActiveDocument => FocusManager.ActiveDocument;

	[Browsable(false)]
	public DockPane ActiveDocumentPane => FocusManager.ActiveDocumentPane;

	[Description("Determines the color with which the client rectangle will be drawn.\r\nIf this property is used instead of the BackColor it will not have any influence on the borders to the surrounding controls (DockPane).\r\nThe BackColor property changes the borders of surrounding controls (DockPane).\r\nAlternatively both properties may be used (BackColor to draw and define the color of the borders and DockBackColor to define the color of the client rectangle).\r\nFor Backgroundimages: Set your prefered Image, then set the DockBackColor and the BackColor to the same Color (Control).")]
	public Color DockBackColor
	{
		get
		{
			if (m_BackColor.IsEmpty)
			{
				return ((Control)this).BackColor;
			}
			return m_BackColor;
		}
		set
		{
			if (m_BackColor != value)
			{
				m_BackColor = value;
				((Control)this).Refresh();
			}
		}
	}

	internal AutoHideStripBase AutoHideStripControl
	{
		get
		{
			if (m_autoHideStripControl == null)
			{
				m_autoHideStripControl = AutoHideStripFactory.CreateAutoHideStrip(this);
				((Control)this).Controls.Add((Control)(object)m_autoHideStripControl);
			}
			return m_autoHideStripControl;
		}
	}

	[Browsable(false)]
	public IDockContent ActiveAutoHideContent
	{
		get
		{
			return AutoHideWindow.ActiveContent;
		}
		set
		{
			AutoHideWindow.ActiveContent = value;
		}
	}

	[LocalizedDescription("DockPanel_AllowEndUserDocking_Description")]
	[LocalizedCategory("Category_Docking")]
	[DefaultValue(true)]
	public bool AllowEndUserDocking
	{
		get
		{
			return m_allowEndUserDocking;
		}
		set
		{
			m_allowEndUserDocking = value;
		}
	}

	[LocalizedCategory("Category_Docking")]
	[LocalizedDescription("DockPanel_AllowEndUserNestedDocking_Description")]
	[DefaultValue(true)]
	public bool AllowEndUserNestedDocking
	{
		get
		{
			return m_allowEndUserNestedDocking;
		}
		set
		{
			m_allowEndUserNestedDocking = value;
		}
	}

	[Browsable(false)]
	public DockContentCollection Contents => m_contents;

	internal DockContent DummyContent => m_dummyContent;

	[LocalizedDescription("DockPanel_RightToLeftLayout_Description")]
	[DefaultValue(false)]
	[LocalizedCategory("Appearance")]
	public bool RightToLeftLayout
	{
		get
		{
			return m_rightToLeftLayout;
		}
		set
		{
			if (m_rightToLeftLayout == value)
			{
				return;
			}
			m_rightToLeftLayout = value;
			foreach (FloatWindow floatWindow in FloatWindows)
			{
				((Form)floatWindow).RightToLeftLayout = value;
			}
		}
	}

	[LocalizedCategory("Category_Docking")]
	[DefaultValue(false)]
	[LocalizedDescription("DockPanel_ShowDocumentIcon_Description")]
	public bool ShowDocumentIcon
	{
		get
		{
			return m_showDocumentIcon;
		}
		set
		{
			if (m_showDocumentIcon != value)
			{
				m_showDocumentIcon = value;
				((Control)this).Refresh();
			}
		}
	}

	[LocalizedCategory("Category_Docking")]
	[LocalizedDescription("DockPanel_DockPanelSkin")]
	public DockPanelSkin Skin
	{
		get
		{
			return m_dockPanelSkin;
		}
		set
		{
			m_dockPanelSkin = value;
		}
	}

	[DefaultValue(DocumentTabStripLocation.Top)]
	[LocalizedCategory("Category_Docking")]
	[LocalizedDescription("DockPanel_DocumentTabStripLocation")]
	public DocumentTabStripLocation DocumentTabStripLocation
	{
		get
		{
			return m_documentTabStripLocation;
		}
		set
		{
			m_documentTabStripLocation = value;
		}
	}

	[Browsable(false)]
	public DockPanelExtender Extender => m_extender;

	[Browsable(false)]
	public DockPanelExtender.IDockPaneFactory DockPaneFactory => Extender.DockPaneFactory;

	[Browsable(false)]
	public DockPanelExtender.IFloatWindowFactory FloatWindowFactory => Extender.FloatWindowFactory;

	internal DockPanelExtender.IDockPaneCaptionFactory DockPaneCaptionFactory => Extender.DockPaneCaptionFactory;

	internal DockPanelExtender.IDockPaneStripFactory DockPaneStripFactory => Extender.DockPaneStripFactory;

	internal DockPanelExtender.IAutoHideStripFactory AutoHideStripFactory => Extender.AutoHideStripFactory;

	[Browsable(false)]
	public DockPaneCollection Panes => m_panes;

	internal Rectangle DockArea => new Rectangle(((ScrollableControl)this).DockPadding.Left, ((ScrollableControl)this).DockPadding.Top, ((Control)this).ClientRectangle.Width - ((ScrollableControl)this).DockPadding.Left - ((ScrollableControl)this).DockPadding.Right, ((Control)this).ClientRectangle.Height - ((ScrollableControl)this).DockPadding.Top - ((ScrollableControl)this).DockPadding.Bottom);

	[DefaultValue(0.25)]
	[LocalizedCategory("Category_Docking")]
	[LocalizedDescription("DockPanel_DockBottomPortion_Description")]
	public double DockBottomPortion
	{
		get
		{
			return m_dockBottomPortion;
		}
		set
		{
			if (value <= 0.0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (value != m_dockBottomPortion)
			{
				m_dockBottomPortion = value;
				if (m_dockBottomPortion < 1.0 && m_dockTopPortion < 1.0 && m_dockTopPortion + m_dockBottomPortion > 1.0)
				{
					m_dockTopPortion = 1.0 - m_dockBottomPortion;
				}
				((Control)this).PerformLayout();
			}
		}
	}

	[LocalizedDescription("DockPanel_DockLeftPortion_Description")]
	[LocalizedCategory("Category_Docking")]
	[DefaultValue(0.25)]
	public double DockLeftPortion
	{
		get
		{
			return m_dockLeftPortion;
		}
		set
		{
			if (value <= 0.0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (value != m_dockLeftPortion)
			{
				m_dockLeftPortion = value;
				if (m_dockLeftPortion < 1.0 && m_dockRightPortion < 1.0 && m_dockLeftPortion + m_dockRightPortion > 1.0)
				{
					m_dockRightPortion = 1.0 - m_dockLeftPortion;
				}
				((Control)this).PerformLayout();
			}
		}
	}

	[LocalizedCategory("Category_Docking")]
	[LocalizedDescription("DockPanel_DockRightPortion_Description")]
	[DefaultValue(0.25)]
	public double DockRightPortion
	{
		get
		{
			return m_dockRightPortion;
		}
		set
		{
			if (value <= 0.0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (value != m_dockRightPortion)
			{
				m_dockRightPortion = value;
				if (m_dockLeftPortion < 1.0 && m_dockRightPortion < 1.0 && m_dockLeftPortion + m_dockRightPortion > 1.0)
				{
					m_dockLeftPortion = 1.0 - m_dockRightPortion;
				}
				((Control)this).PerformLayout();
			}
		}
	}

	[LocalizedDescription("DockPanel_DockTopPortion_Description")]
	[LocalizedCategory("Category_Docking")]
	[DefaultValue(0.25)]
	public double DockTopPortion
	{
		get
		{
			return m_dockTopPortion;
		}
		set
		{
			if (value <= 0.0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (value != m_dockTopPortion)
			{
				m_dockTopPortion = value;
				if (m_dockTopPortion < 1.0 && m_dockBottomPortion < 1.0 && m_dockTopPortion + m_dockBottomPortion > 1.0)
				{
					m_dockBottomPortion = 1.0 - m_dockTopPortion;
				}
				((Control)this).PerformLayout();
			}
		}
	}

	[Browsable(false)]
	public DockWindowCollection DockWindows => m_dockWindows;

	[Browsable(false)]
	public int DocumentsCount
	{
		get
		{
			int num = 0;
			foreach (IDockContent document in Documents)
			{
				_ = document;
				num++;
			}
			return num;
		}
	}

	[Browsable(false)]
	public IEnumerable<IDockContent> Documents
	{
		get
		{
			foreach (IDockContent content in Contents)
			{
				if (content.DockHandler.DockState == DockState.Document)
				{
					yield return content;
				}
			}
		}
	}

	private Rectangle DocumentRectangle
	{
		get
		{
			Rectangle dockArea = DockArea;
			if (DockWindows[DockState.DockLeft].VisibleNestedPanes.Count != 0)
			{
				dockArea.X += (int)((double)DockArea.Width * DockLeftPortion);
				dockArea.Width -= (int)((double)DockArea.Width * DockLeftPortion);
			}
			if (DockWindows[DockState.DockRight].VisibleNestedPanes.Count != 0)
			{
				dockArea.Width -= (int)((double)DockArea.Width * DockRightPortion);
			}
			if (DockWindows[DockState.DockTop].VisibleNestedPanes.Count != 0)
			{
				dockArea.Y += (int)((double)DockArea.Height * DockTopPortion);
				dockArea.Height -= (int)((double)DockArea.Height * DockTopPortion);
			}
			if (DockWindows[DockState.DockBottom].VisibleNestedPanes.Count != 0)
			{
				dockArea.Height -= (int)((double)DockArea.Height * DockBottomPortion);
			}
			return dockArea;
		}
	}

	private Control DummyControl => m_dummyControl;

	[Browsable(false)]
	public FloatWindowCollection FloatWindows => m_floatWindows;

	[Category("Layout")]
	[LocalizedDescription("DockPanel_DefaultFloatWindowSize_Description")]
	public Size DefaultFloatWindowSize
	{
		get
		{
			return m_defaultFloatWindowSize;
		}
		set
		{
			m_defaultFloatWindowSize = value;
		}
	}

	[LocalizedDescription("DockPanel_DocumentStyle_Description")]
	[DefaultValue(DocumentStyle.DockingMdi)]
	[LocalizedCategory("Category_Docking")]
	public DocumentStyle DocumentStyle
	{
		get
		{
			return m_documentStyle;
		}
		set
		{
			if (value == m_documentStyle)
			{
				return;
			}
			if (!Enum.IsDefined(typeof(DocumentStyle), value))
			{
				throw new InvalidEnumArgumentException();
			}
			if (value == DocumentStyle.SystemMdi && DockWindows[DockState.Document].VisibleNestedPanes.Count > 0)
			{
				throw new InvalidEnumArgumentException();
			}
			m_documentStyle = value;
			SuspendLayout(allWindows: true);
			SetAutoHideWindowParent();
			SetMdiClient();
			InvalidateWindowRegion();
			foreach (IDockContent content in Contents)
			{
				if (content.DockHandler.DockState == DockState.Document)
				{
					content.DockHandler.SetPaneAndVisible(content.DockHandler.Pane);
				}
			}
			PerformMdiClientLayout();
			ResumeLayout(performLayout: true, allWindows: true);
		}
	}

	internal Form ParentForm
	{
		get
		{
			if (!IsParentFormValid())
			{
				throw new InvalidOperationException(Strings.DockPanel_ParentForm_Invalid);
			}
			return GetMdiClientController().ParentForm;
		}
	}

	private Rectangle SystemMdiClientBounds
	{
		get
		{
			if (!IsParentFormValid() || !((Control)this).Visible)
			{
				return Rectangle.Empty;
			}
			return ((Control)ParentForm).RectangleToClient(((Control)this).RectangleToScreen(DocumentWindowBounds));
		}
	}

	internal Rectangle DocumentWindowBounds
	{
		get
		{
			Rectangle displayRectangle = ((Control)this).DisplayRectangle;
			if (((Control)DockWindows[DockState.DockLeft]).Visible)
			{
				displayRectangle.X += ((Control)DockWindows[DockState.DockLeft]).Width;
				displayRectangle.Width -= ((Control)DockWindows[DockState.DockLeft]).Width;
			}
			if (((Control)DockWindows[DockState.DockRight]).Visible)
			{
				displayRectangle.Width -= ((Control)DockWindows[DockState.DockRight]).Width;
			}
			if (((Control)DockWindows[DockState.DockTop]).Visible)
			{
				displayRectangle.Y += ((Control)DockWindows[DockState.DockTop]).Height;
				displayRectangle.Height -= ((Control)DockWindows[DockState.DockTop]).Height;
			}
			if (((Control)DockWindows[DockState.DockBottom]).Visible)
			{
				displayRectangle.Height -= ((Control)DockWindows[DockState.DockBottom]).Height;
			}
			return displayRectangle;
		}
	}

	private bool MdiClientExists => GetMdiClientController().MdiClient != null;

	private AutoHideWindowControl AutoHideWindow => m_autoHideWindow;

	internal Control AutoHideControl => (Control)(object)m_autoHideWindow;

	internal Rectangle AutoHideWindowRectangle
	{
		get
		{
			DockState dockState = AutoHideWindow.DockState;
			Rectangle dockArea = DockArea;
			if (ActiveAutoHideContent == null)
			{
				return Rectangle.Empty;
			}
			if (((Control)this).Parent == null)
			{
				return Rectangle.Empty;
			}
			Rectangle empty = Rectangle.Empty;
			double num = ActiveAutoHideContent.DockHandler.AutoHidePortion;
			switch (dockState)
			{
			case DockState.DockLeftAutoHide:
				if (num < 1.0)
				{
					num = (double)dockArea.Width * num;
				}
				if (num > (double)(dockArea.Width - 24))
				{
					num = dockArea.Width - 24;
				}
				empty.X = dockArea.X;
				empty.Y = dockArea.Y;
				empty.Width = (int)num;
				empty.Height = dockArea.Height;
				break;
			case DockState.DockRightAutoHide:
				if (num < 1.0)
				{
					num = (double)dockArea.Width * num;
				}
				if (num > (double)(dockArea.Width - 24))
				{
					num = dockArea.Width - 24;
				}
				empty.X = dockArea.X + dockArea.Width - (int)num;
				empty.Y = dockArea.Y;
				empty.Width = (int)num;
				empty.Height = dockArea.Height;
				break;
			case DockState.DockTopAutoHide:
				if (num < 1.0)
				{
					num = (double)dockArea.Height * num;
				}
				if (num > (double)(dockArea.Height - 24))
				{
					num = dockArea.Height - 24;
				}
				empty.X = dockArea.X;
				empty.Y = dockArea.Y;
				empty.Width = dockArea.Width;
				empty.Height = (int)num;
				break;
			case DockState.DockBottomAutoHide:
				if (num < 1.0)
				{
					num = (double)dockArea.Height * num;
				}
				if (num > (double)(dockArea.Height - 24))
				{
					num = dockArea.Height - 24;
				}
				empty.X = dockArea.X;
				empty.Y = dockArea.Y + dockArea.Height - (int)num;
				empty.Width = dockArea.Width;
				empty.Height = (int)num;
				break;
			}
			return empty;
		}
	}

	[LocalizedDescription("DockPanel_ActiveDocumentChanged_Description")]
	[LocalizedCategory("Category_PropertyChanged")]
	public event EventHandler ActiveDocumentChanged
	{
		add
		{
			((Component)this).Events.AddHandler(ActiveDocumentChangedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(ActiveDocumentChangedEvent, value);
		}
	}

	[LocalizedDescription("DockPanel_ActiveContentChanged_Description")]
	[LocalizedCategory("Category_PropertyChanged")]
	public event EventHandler ActiveContentChanged
	{
		add
		{
			((Component)this).Events.AddHandler(ActiveContentChangedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(ActiveContentChangedEvent, value);
		}
	}

	[LocalizedDescription("DockPanel_ActivePaneChanged_Description")]
	[LocalizedCategory("Category_PropertyChanged")]
	public event EventHandler ActivePaneChanged
	{
		add
		{
			((Component)this).Events.AddHandler(ActivePaneChangedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(ActivePaneChangedEvent, value);
		}
	}

	[LocalizedDescription("DockPanel_ContentAdded_Description")]
	[LocalizedCategory("Category_DockingNotification")]
	public event EventHandler<DockContentEventArgs> ContentAdded
	{
		add
		{
			((Component)this).Events.AddHandler(ContentAddedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(ContentAddedEvent, value);
		}
	}

	[LocalizedDescription("DockPanel_ContentRemoved_Description")]
	[LocalizedCategory("Category_DockingNotification")]
	public event EventHandler<DockContentEventArgs> ContentRemoved
	{
		add
		{
			((Component)this).Events.AddHandler(ContentRemovedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(ContentRemovedEvent, value);
		}
	}

	internal void SaveFocus()
	{
		DummyControl.Focus();
	}

	protected virtual void OnActiveDocumentChanged(EventArgs e)
	{
		((EventHandler)((Component)this).Events[ActiveDocumentChanged])?.Invoke(this, e);
	}

	protected void OnActiveContentChanged(EventArgs e)
	{
		((EventHandler)((Component)this).Events[ActiveContentChanged])?.Invoke(this, e);
	}

	protected virtual void OnActivePaneChanged(EventArgs e)
	{
		((EventHandler)((Component)this).Events[ActivePaneChanged])?.Invoke(this, e);
	}

	public DockPanel()
	{
		m_focusManager = new FocusManagerImpl(this);
		m_extender = new DockPanelExtender(this);
		m_panes = new DockPaneCollection();
		m_floatWindows = new FloatWindowCollection();
		((Control)this).SuspendLayout();
		m_autoHideWindow = new AutoHideWindowControl(this);
		((Control)m_autoHideWindow).Visible = false;
		SetAutoHideWindowParent();
		m_dummyControl = (Control)(object)new DummyControl();
		m_dummyControl.Bounds = new Rectangle(0, 0, 1, 1);
		((Control)this).Controls.Add(m_dummyControl);
		m_dockWindows = new DockWindowCollection(this);
		((Control)this).Controls.AddRange((Control[])(object)new Control[5]
		{
			(Control)DockWindows[DockState.Document],
			(Control)DockWindows[DockState.DockLeft],
			(Control)DockWindows[DockState.DockRight],
			(Control)DockWindows[DockState.DockTop],
			(Control)DockWindows[DockState.DockBottom]
		});
		m_dummyContent = new DockContent();
		((Control)this).ResumeLayout();
	}

	internal void ResetAutoHideStripControl()
	{
		if (m_autoHideStripControl != null)
		{
			((Component)(object)m_autoHideStripControl).Dispose();
		}
		m_autoHideStripControl = null;
	}

	private void MdiClientHandleAssigned(object sender, EventArgs e)
	{
		SetMdiClient();
		((Control)this).PerformLayout();
	}

	private void MdiClient_Layout(object sender, LayoutEventArgs e)
	{
		if (DocumentStyle != DocumentStyle.DockingMdi)
		{
			return;
		}
		foreach (DockPane pane in Panes)
		{
			if (pane.DockState == DockState.Document)
			{
				pane.SetContentBounds();
			}
		}
		InvalidateWindowRegion();
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		lock (this)
		{
			if (!m_disposed && disposing)
			{
				m_focusManager.Dispose();
				if (m_mdiClientController != null)
				{
					m_mdiClientController.HandleAssigned -= MdiClientHandleAssigned;
					m_mdiClientController.MdiChildActivate -= ParentFormMdiChildActivate;
					m_mdiClientController.Layout -= new LayoutEventHandler(MdiClient_Layout);
					m_mdiClientController.Dispose();
				}
				FloatWindows.Dispose();
				Panes.Dispose();
				((Component)(object)DummyContent).Dispose();
				m_disposed = true;
			}
			((Control)this).Dispose(disposing);
		}
	}

	protected override void OnRightToLeftChanged(EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		((ScrollableControl)this).OnRightToLeftChanged(e);
		foreach (FloatWindow floatWindow in FloatWindows)
		{
			if (((Control)floatWindow).RightToLeft != ((Control)this).RightToLeft)
			{
				((Control)floatWindow).RightToLeft = ((Control)this).RightToLeft;
			}
		}
	}

	public void UpdateDockWindowZOrder(DockStyle dockStyle, bool fullPanelEdge)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		if ((int)dockStyle == 3)
		{
			if (fullPanelEdge)
			{
				((Control)DockWindows[DockState.DockLeft]).SendToBack();
			}
			else
			{
				((Control)DockWindows[DockState.DockLeft]).BringToFront();
			}
		}
		else if ((int)dockStyle == 4)
		{
			if (fullPanelEdge)
			{
				((Control)DockWindows[DockState.DockRight]).SendToBack();
			}
			else
			{
				((Control)DockWindows[DockState.DockRight]).BringToFront();
			}
		}
		else if ((int)dockStyle == 1)
		{
			if (fullPanelEdge)
			{
				((Control)DockWindows[DockState.DockTop]).SendToBack();
			}
			else
			{
				((Control)DockWindows[DockState.DockTop]).BringToFront();
			}
		}
		else if ((int)dockStyle == 2)
		{
			if (fullPanelEdge)
			{
				((Control)DockWindows[DockState.DockBottom]).SendToBack();
			}
			else
			{
				((Control)DockWindows[DockState.DockBottom]).BringToFront();
			}
		}
	}

	public IDockContent[] DocumentsToArray()
	{
		int documentsCount = DocumentsCount;
		IDockContent[] array = new IDockContent[documentsCount];
		int num = 0;
		foreach (IDockContent document in Documents)
		{
			array[num] = document;
			num++;
		}
		return array;
	}

	private bool ShouldSerializeDefaultFloatWindowSize()
	{
		return DefaultFloatWindowSize != new Size(300, 300);
	}

	private int GetDockWindowSize(DockState dockState)
	{
		switch (dockState)
		{
		case DockState.DockLeft:
		case DockState.DockRight:
		{
			int num5 = ((Control)this).ClientRectangle.Width - ((ScrollableControl)this).DockPadding.Left - ((ScrollableControl)this).DockPadding.Right;
			int num6 = ((m_dockLeftPortion >= 1.0) ? ((int)m_dockLeftPortion) : ((int)((double)num5 * m_dockLeftPortion)));
			int num7 = ((m_dockRightPortion >= 1.0) ? ((int)m_dockRightPortion) : ((int)((double)num5 * m_dockRightPortion)));
			if (num6 < 24)
			{
				num6 = 24;
			}
			if (num7 < 24)
			{
				num7 = 24;
			}
			if (num6 + num7 > num5 - 24)
			{
				int num8 = num6 + num7 - (num5 - 24);
				num6 -= num8 / 2;
				num7 -= num8 / 2;
			}
			if (dockState != DockState.DockLeft)
			{
				return num7;
			}
			return num6;
		}
		case DockState.DockTop:
		case DockState.DockBottom:
		{
			int num = ((Control)this).ClientRectangle.Height - ((ScrollableControl)this).DockPadding.Top - ((ScrollableControl)this).DockPadding.Bottom;
			int num2 = ((m_dockTopPortion >= 1.0) ? ((int)m_dockTopPortion) : ((int)((double)num * m_dockTopPortion)));
			int num3 = ((m_dockBottomPortion >= 1.0) ? ((int)m_dockBottomPortion) : ((int)((double)num * m_dockBottomPortion)));
			if (num2 < 24)
			{
				num2 = 24;
			}
			if (num3 < 24)
			{
				num3 = 24;
			}
			if (num2 + num3 > num - 24)
			{
				int num4 = num2 + num3 - (num - 24);
				num2 -= num4 / 2;
				num3 -= num4 / 2;
			}
			if (dockState != DockState.DockTop)
			{
				return num3;
			}
			return num2;
		}
		default:
			return 0;
		}
	}

	protected override void OnLayout(LayoutEventArgs levent)
	{
		SuspendLayout(allWindows: true);
		((Control)AutoHideStripControl).Bounds = ((Control)this).ClientRectangle;
		CalculateDockPadding();
		((Control)DockWindows[DockState.DockLeft]).Width = GetDockWindowSize(DockState.DockLeft);
		((Control)DockWindows[DockState.DockRight]).Width = GetDockWindowSize(DockState.DockRight);
		((Control)DockWindows[DockState.DockTop]).Height = GetDockWindowSize(DockState.DockTop);
		((Control)DockWindows[DockState.DockBottom]).Height = GetDockWindowSize(DockState.DockBottom);
		((Control)AutoHideWindow).Bounds = GetAutoHideWindowBounds(AutoHideWindowRectangle);
		((Control)DockWindows[DockState.Document]).BringToFront();
		((Control)AutoHideWindow).BringToFront();
		((ScrollableControl)this).OnLayout(levent);
		if (DocumentStyle == DocumentStyle.SystemMdi && MdiClientExists)
		{
			SetMdiClientBounds(SystemMdiClientBounds);
			InvalidateWindowRegion();
		}
		else if (DocumentStyle == DocumentStyle.DockingMdi)
		{
			InvalidateWindowRegion();
		}
		ResumeLayout(performLayout: true, allWindows: true);
	}

	internal Rectangle GetTabStripRectangle(DockState dockState)
	{
		return AutoHideStripControl.GetTabStripRectangle(dockState);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		if (!(DockBackColor == ((Control)this).BackColor))
		{
			Graphics graphics = e.Graphics;
			SolidBrush val = new SolidBrush(DockBackColor);
			graphics.FillRectangle((Brush)(object)val, ((Control)this).ClientRectangle);
		}
	}

	internal void AddContent(IDockContent content)
	{
		if (content == null)
		{
			throw new ArgumentNullException();
		}
		if (!Contents.Contains(content))
		{
			Contents.Add(content);
			OnContentAdded(new DockContentEventArgs(content));
		}
	}

	internal void AddPane(DockPane pane)
	{
		if (!Panes.Contains(pane))
		{
			Panes.Add(pane);
		}
	}

	internal void AddFloatWindow(FloatWindow floatWindow)
	{
		if (!FloatWindows.Contains(floatWindow))
		{
			FloatWindows.Add(floatWindow);
		}
	}

	private void CalculateDockPadding()
	{
		((ScrollableControl)this).DockPadding.All = 0;
		int num = AutoHideStripControl.MeasureHeight();
		if (AutoHideStripControl.GetNumberOfPanes(DockState.DockLeftAutoHide) > 0)
		{
			((ScrollableControl)this).DockPadding.Left = num;
		}
		if (AutoHideStripControl.GetNumberOfPanes(DockState.DockRightAutoHide) > 0)
		{
			((ScrollableControl)this).DockPadding.Right = num;
		}
		if (AutoHideStripControl.GetNumberOfPanes(DockState.DockTopAutoHide) > 0)
		{
			((ScrollableControl)this).DockPadding.Top = num;
		}
		if (AutoHideStripControl.GetNumberOfPanes(DockState.DockBottomAutoHide) > 0)
		{
			((ScrollableControl)this).DockPadding.Bottom = num;
		}
	}

	internal void RemoveContent(IDockContent content)
	{
		if (content == null)
		{
			throw new ArgumentNullException();
		}
		if (Contents.Contains(content))
		{
			Contents.Remove(content);
			OnContentRemoved(new DockContentEventArgs(content));
		}
	}

	internal void RemovePane(DockPane pane)
	{
		if (Panes.Contains(pane))
		{
			Panes.Remove(pane);
		}
	}

	internal void RemoveFloatWindow(FloatWindow floatWindow)
	{
		if (FloatWindows.Contains(floatWindow))
		{
			FloatWindows.Remove(floatWindow);
		}
	}

	public void SetPaneIndex(DockPane pane, int index)
	{
		int num = Panes.IndexOf(pane);
		if (num == -1)
		{
			throw new ArgumentException(Strings.DockPanel_SetPaneIndex_InvalidPane);
		}
		if ((index < 0 || index > Panes.Count - 1) && index != -1)
		{
			throw new ArgumentOutOfRangeException(Strings.DockPanel_SetPaneIndex_InvalidIndex);
		}
		if (num != index && (num != Panes.Count - 1 || index != -1))
		{
			Panes.Remove(pane);
			if (index == -1)
			{
				Panes.Add(pane);
			}
			else if (num < index)
			{
				Panes.AddAt(pane, index - 1);
			}
			else
			{
				Panes.AddAt(pane, index);
			}
		}
	}

	public void SuspendLayout(bool allWindows)
	{
		FocusManager.SuspendFocusTracking();
		((Control)this).SuspendLayout();
		if (allWindows)
		{
			SuspendMdiClientLayout();
		}
	}

	public void ResumeLayout(bool performLayout, bool allWindows)
	{
		FocusManager.ResumeFocusTracking();
		((Control)this).ResumeLayout(performLayout);
		if (allWindows)
		{
			ResumeMdiClientLayout(performLayout);
		}
	}

	private bool IsParentFormValid()
	{
		if (DocumentStyle == DocumentStyle.DockingSdi || DocumentStyle == DocumentStyle.DockingWindow)
		{
			return true;
		}
		if (!MdiClientExists)
		{
			GetMdiClientController().RenewMdiClient();
		}
		return MdiClientExists;
	}

	protected override void OnParentChanged(EventArgs e)
	{
		SetAutoHideWindowParent();
		MdiClientController mdiClientController = GetMdiClientController();
		Control parent = ((Control)this).Parent;
		mdiClientController.ParentForm = (Form)(object)((parent is Form) ? parent : null);
		((Control)this).OnParentChanged(e);
	}

	private void SetAutoHideWindowParent()
	{
		Control val = (Control)(object)((DocumentStyle != DocumentStyle.DockingMdi && DocumentStyle != DocumentStyle.SystemMdi) ? this : ((DockPanel)(object)((Control)this).Parent));
		if (((Control)AutoHideWindow).Parent != val)
		{
			((Control)AutoHideWindow).Parent = val;
			((Control)AutoHideWindow).BringToFront();
		}
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		((ScrollableControl)this).OnVisibleChanged(e);
		if (((Control)this).Visible)
		{
			SetMdiClient();
		}
	}

	private void InvalidateWindowRegion()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		if (!((Component)this).DesignMode)
		{
			if (m_dummyControlPaintEventHandler == null)
			{
				m_dummyControlPaintEventHandler = new PaintEventHandler(DummyControl_Paint);
			}
			DummyControl.Paint += m_dummyControlPaintEventHandler;
			DummyControl.Invalidate();
		}
	}

	private void DummyControl_Paint(object sender, PaintEventArgs e)
	{
		DummyControl.Paint -= m_dummyControlPaintEventHandler;
		UpdateWindowRegion();
	}

	private void UpdateWindowRegion()
	{
		if (DocumentStyle == DocumentStyle.DockingMdi)
		{
			UpdateWindowRegion_ClipContent();
		}
		else if (DocumentStyle == DocumentStyle.DockingSdi || DocumentStyle == DocumentStyle.DockingWindow)
		{
			UpdateWindowRegion_FullDocumentArea();
		}
		else if (DocumentStyle == DocumentStyle.SystemMdi)
		{
			UpdateWindowRegion_EmptyDocumentArea();
		}
	}

	private void UpdateWindowRegion_FullDocumentArea()
	{
		SetRegion(null);
	}

	private void UpdateWindowRegion_EmptyDocumentArea()
	{
		Rectangle documentWindowBounds = DocumentWindowBounds;
		SetRegion(new Rectangle[1] { documentWindowBounds });
	}

	private void UpdateWindowRegion_ClipContent()
	{
		int num = 0;
		foreach (DockPane pane in Panes)
		{
			if (((Control)pane).Visible && pane.DockState == DockState.Document)
			{
				num++;
			}
		}
		if (num == 0)
		{
			SetRegion(null);
			return;
		}
		Rectangle[] array = new Rectangle[num];
		int num2 = 0;
		foreach (DockPane pane2 in Panes)
		{
			if (((Control)pane2).Visible && pane2.DockState == DockState.Document)
			{
				ref Rectangle reference = ref array[num2];
				reference = ((Control)this).RectangleToClient(((Control)pane2).RectangleToScreen(pane2.ContentRectangle));
				num2++;
			}
		}
		SetRegion(array);
	}

	private void SetRegion(Rectangle[] clipRects)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (!IsClipRectsChanged(clipRects))
		{
			return;
		}
		m_clipRects = clipRects;
		if (m_clipRects == null || m_clipRects.GetLength(0) == 0)
		{
			((Control)this).Region = null;
			return;
		}
		Region val = new Region(new Rectangle(0, 0, ((Control)this).Width, ((Control)this).Height));
		Rectangle[] clipRects2 = m_clipRects;
		foreach (Rectangle rectangle in clipRects2)
		{
			val.Exclude(rectangle);
		}
		((Control)this).Region = val;
	}

	private bool IsClipRectsChanged(Rectangle[] clipRects)
	{
		if (clipRects == null && m_clipRects == null)
		{
			return false;
		}
		if (clipRects == null != (m_clipRects == null))
		{
			return true;
		}
		foreach (Rectangle rectangle in clipRects)
		{
			bool flag = false;
			Rectangle[] clipRects2 = m_clipRects;
			foreach (Rectangle rectangle2 in clipRects2)
			{
				if (rectangle == rectangle2)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return true;
			}
		}
		Rectangle[] clipRects3 = m_clipRects;
		foreach (Rectangle rectangle3 in clipRects3)
		{
			bool flag2 = false;
			foreach (Rectangle rectangle4 in clipRects)
			{
				if (rectangle4 == rectangle3)
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				return true;
			}
		}
		return false;
	}

	protected virtual void OnContentAdded(DockContentEventArgs e)
	{
		((EventHandler<DockContentEventArgs>)((Component)this).Events[ContentAdded])?.Invoke(this, e);
	}

	protected virtual void OnContentRemoved(DockContentEventArgs e)
	{
		((EventHandler<DockContentEventArgs>)((Component)this).Events[ContentRemoved])?.Invoke(this, e);
	}

	private MdiClientController GetMdiClientController()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		if (m_mdiClientController == null)
		{
			m_mdiClientController = new MdiClientController();
			m_mdiClientController.HandleAssigned += MdiClientHandleAssigned;
			m_mdiClientController.MdiChildActivate += ParentFormMdiChildActivate;
			m_mdiClientController.Layout += new LayoutEventHandler(MdiClient_Layout);
		}
		return m_mdiClientController;
	}

	private void ParentFormMdiChildActivate(object sender, EventArgs e)
	{
		if (GetMdiClientController().ParentForm != null && GetMdiClientController().ParentForm.ActiveMdiChild is IDockContent dockContent && dockContent.DockHandler.DockPanel == this && dockContent.DockHandler.Pane != null)
		{
			dockContent.DockHandler.Pane.ActiveContent = dockContent;
		}
	}

	private void SetMdiClientBounds(Rectangle bounds)
	{
		((Control)GetMdiClientController().MdiClient).Bounds = bounds;
	}

	private void SuspendMdiClientLayout()
	{
		if (GetMdiClientController().MdiClient != null)
		{
			((Control)GetMdiClientController().MdiClient).SuspendLayout();
		}
	}

	private void ResumeMdiClientLayout(bool perform)
	{
		if (GetMdiClientController().MdiClient != null)
		{
			((Control)GetMdiClientController().MdiClient).ResumeLayout(perform);
		}
	}

	private void PerformMdiClientLayout()
	{
		if (GetMdiClientController().MdiClient != null)
		{
			((Control)GetMdiClientController().MdiClient).PerformLayout();
		}
	}

	private void SetMdiClient()
	{
		MdiClientController mdiClientController = GetMdiClientController();
		if (DocumentStyle == DocumentStyle.DockingMdi)
		{
			mdiClientController.AutoScroll = false;
			mdiClientController.BorderStyle = (BorderStyle)0;
			if (MdiClientExists)
			{
				((Control)mdiClientController.MdiClient).Dock = (DockStyle)5;
			}
		}
		else if (DocumentStyle == DocumentStyle.DockingSdi || DocumentStyle == DocumentStyle.DockingWindow)
		{
			mdiClientController.AutoScroll = true;
			mdiClientController.BorderStyle = (BorderStyle)2;
			if (MdiClientExists)
			{
				((Control)mdiClientController.MdiClient).Dock = (DockStyle)5;
			}
		}
		else if (DocumentStyle == DocumentStyle.SystemMdi)
		{
			mdiClientController.AutoScroll = true;
			mdiClientController.BorderStyle = (BorderStyle)2;
			if (mdiClientController.MdiClient != null)
			{
				((Control)mdiClientController.MdiClient).Dock = (DockStyle)0;
				((Control)mdiClientController.MdiClient).Bounds = SystemMdiClientBounds;
			}
		}
	}

	internal Rectangle RectangleToMdiClient(Rectangle rect)
	{
		if (MdiClientExists)
		{
			return ((Control)GetMdiClientController().MdiClient).RectangleToClient(rect);
		}
		return Rectangle.Empty;
	}

	public void SaveAsXml(string fileName)
	{
		Persistor.SaveAsXml(this, fileName);
	}

	public void SaveAsXml(string fileName, Encoding encoding)
	{
		Persistor.SaveAsXml(this, fileName, encoding);
	}

	public void SaveAsXml(Stream stream, Encoding encoding)
	{
		Persistor.SaveAsXml(this, stream, encoding);
	}

	public void SaveAsXml(Stream stream, Encoding encoding, bool upstream)
	{
		Persistor.SaveAsXml(this, stream, encoding, upstream);
	}

	public void LoadFromXml(string fileName, DeserializeDockContent deserializeContent)
	{
		Persistor.LoadFromXml(this, fileName, deserializeContent);
	}

	public void LoadFromXml(Stream stream, DeserializeDockContent deserializeContent)
	{
		Persistor.LoadFromXml(this, stream, deserializeContent);
	}

	public void LoadFromXml(Stream stream, DeserializeDockContent deserializeContent, bool closeStream)
	{
		Persistor.LoadFromXml(this, stream, deserializeContent, closeStream);
	}

	private SplitterDragHandler GetSplitterDragHandler()
	{
		if (m_splitterDragHandler == null)
		{
			m_splitterDragHandler = new SplitterDragHandler(this);
		}
		return m_splitterDragHandler;
	}

	internal void BeginDrag(ISplitterDragSource dragSource, Rectangle rectSplitter)
	{
		GetSplitterDragHandler().BeginDrag(dragSource, rectSplitter);
	}

	private DockDragHandler GetDockDragHandler()
	{
		if (m_dockDragHandler == null)
		{
			m_dockDragHandler = new DockDragHandler(this);
		}
		return m_dockDragHandler;
	}

	internal void BeginDrag(IDockDragSource dragSource)
	{
		GetDockDragHandler().BeginDrag(dragSource);
	}

	internal void RefreshActiveAutoHideContent()
	{
		AutoHideWindow.RefreshActiveContent();
	}

	internal Rectangle GetAutoHideWindowBounds(Rectangle rectAutoHideWindow)
	{
		if (DocumentStyle == DocumentStyle.SystemMdi || DocumentStyle == DocumentStyle.DockingMdi)
		{
			if (((Control)this).Parent != null)
			{
				return ((Control)this).Parent.RectangleToClient(((Control)this).RectangleToScreen(rectAutoHideWindow));
			}
			return Rectangle.Empty;
		}
		return rectAutoHideWindow;
	}

	internal void RefreshAutoHideStrip()
	{
		AutoHideStripControl.RefreshChanges();
	}

	static DockPanel()
	{
		ActiveDocumentChanged = new object();
		ActiveContentChanged = new object();
		ActivePaneChanged = new object();
		ContentAdded = new object();
		ContentRemoved = new object();
	}
}
