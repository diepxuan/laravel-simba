using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Permissions;
using System.Windows.Forms;

namespace AsiaErp.Framework.Docking;

public abstract class DockPaneStripBase : Control
{
	protected internal class Tab : IDisposable
	{
		private IDockContent m_content;

		public IDockContent Content => m_content;

		public Form ContentForm
		{
			get
			{
				IDockContent content = m_content;
				return (Form)((content is Form) ? content : null);
			}
		}

		public Tab(IDockContent content)
		{
			m_content = content;
		}

		~Tab()
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
		}
	}

	protected sealed class TabCollection : IEnumerable<Tab>, IEnumerable
	{
		private DockPane m_dockPane;

		public DockPane DockPane => m_dockPane;

		public int Count => DockPane.DisplayingContents.Count;

		public Tab this[int index]
		{
			get
			{
				IDockContent dockContent = DockPane.DisplayingContents[index];
				if (dockContent == null)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return dockContent.DockHandler.GetTab(DockPane.TabStripControl);
			}
		}

		IEnumerator<Tab> IEnumerable<Tab>.GetEnumerator()
		{
			for (int i = 0; i < Count; i++)
			{
				yield return this[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			for (int i = 0; i < Count; i++)
			{
				yield return this[i];
			}
		}

		internal TabCollection(DockPane pane)
		{
			m_dockPane = pane;
		}

		public bool Contains(Tab tab)
		{
			return IndexOf(tab) != -1;
		}

		public bool Contains(IDockContent content)
		{
			return IndexOf(content) != -1;
		}

		public int IndexOf(Tab tab)
		{
			if (tab == null)
			{
				return -1;
			}
			return DockPane.DisplayingContents.IndexOf(tab.Content);
		}

		public int IndexOf(IDockContent content)
		{
			return DockPane.DisplayingContents.IndexOf(content);
		}
	}

	private DockPane m_dockPane;

	private TabCollection m_tabs;

	protected DockPane DockPane => m_dockPane;

	protected DockPane.AppearanceStyle Appearance => DockPane.Appearance;

	protected TabCollection Tabs
	{
		get
		{
			if (m_tabs == null)
			{
				m_tabs = new TabCollection(DockPane);
			}
			return m_tabs;
		}
	}

	protected bool HasTabPageContextMenu => DockPane.HasTabPageContextMenu;

	protected DockPaneStripBase(DockPane pane)
	{
		m_dockPane = pane;
		((Control)this).SetStyle((ControlStyles)131072, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).AllowDrop = true;
	}

	internal void RefreshChanges()
	{
		if (!((Control)this).IsDisposed)
		{
			OnRefreshChanges();
		}
	}

	protected virtual void OnRefreshChanges()
	{
	}

	protected internal abstract int MeasureHeight();

	protected internal abstract void EnsureTabVisible(IDockContent content);

	protected int HitTest()
	{
		return HitTest(((Control)this).PointToClient(Control.MousePosition));
	}

	protected internal abstract int HitTest(Point point);

	protected internal abstract GraphicsPath GetOutline(int index);

	protected internal virtual Tab CreateTab(IDockContent content)
	{
		return new Tab(content);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		int num = HitTest();
		if (num != -1)
		{
			IDockContent content = Tabs[num].Content;
			if (DockPane.ActiveContent != content)
			{
				DockPane.ActiveContent = content;
			}
		}
		if ((int)e.Button == 1048576 && DockPane.DockPanel.AllowEndUserDocking && DockPane.AllowDockDragAndDrop && DockPane.ActiveContent.DockHandler.AllowEndUserDocking)
		{
			DockPane.DockPanel.BeginDrag(DockPane.ActiveContent.DockHandler);
		}
	}

	protected void ShowTabPageContextMenu(Point position)
	{
		DockPane.ShowTabPageContextMenu((Control)(object)this, position);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		((Control)this).OnMouseUp(e);
		if ((int)e.Button == 2097152)
		{
			ShowTabPageContextMenu(new Point(e.X, e.Y));
		}
		else if ((int)e.Button == 4194304 && DockPane.Appearance == DockPane.AppearanceStyle.Document)
		{
			int num = HitTest();
			if (num != -1)
			{
				IDockContent content = Tabs[num].Content;
				DockPane.CloseContent(content);
			}
		}
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).Msg == 515)
		{
			((Control)this).WndProc(ref m);
			int num = HitTest();
			if (DockPane.DockPanel.AllowEndUserDocking && num != -1)
			{
				IDockContent content = Tabs[num].Content;
				if (content.DockHandler.CheckDockState(!content.DockHandler.IsFloat) != DockState.Unknown)
				{
					content.DockHandler.IsFloat = !content.DockHandler.IsFloat;
				}
			}
		}
		else
		{
			((Control)this).WndProc(ref m);
		}
	}

	protected override void OnDragOver(DragEventArgs drgevent)
	{
		((Control)this).OnDragOver(drgevent);
		int num = HitTest();
		if (num != -1)
		{
			IDockContent content = Tabs[num].Content;
			if (DockPane.ActiveContent != content)
			{
				DockPane.ActiveContent = content;
			}
		}
	}
}
