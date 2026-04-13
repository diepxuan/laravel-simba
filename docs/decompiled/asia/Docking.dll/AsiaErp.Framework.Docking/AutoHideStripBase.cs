using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AsiaErp.Framework.Docking;

public abstract class AutoHideStripBase : Control
{
	protected class Tab : IDisposable
	{
		private IDockContent m_content;

		public IDockContent Content => m_content;

		protected internal Tab(IDockContent content)
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

		public DockPanel DockPanel => DockPane.DockPanel;

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
				if (dockContent.DockHandler.AutoHideTab == null)
				{
					dockContent.DockHandler.AutoHideTab = DockPanel.AutoHideStripControl.CreateTab(dockContent);
				}
				return dockContent.DockHandler.AutoHideTab as Tab;
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
			return IndexOf(tab.Content);
		}

		public int IndexOf(IDockContent content)
		{
			return DockPane.DisplayingContents.IndexOf(content);
		}
	}

	protected class Pane : IDisposable
	{
		private DockPane m_dockPane;

		public DockPane DockPane => m_dockPane;

		public TabCollection AutoHideTabs
		{
			get
			{
				if (DockPane.AutoHideTabs == null)
				{
					DockPane.AutoHideTabs = new TabCollection(DockPane);
				}
				return DockPane.AutoHideTabs as TabCollection;
			}
		}

		protected internal Pane(DockPane dockPane)
		{
			m_dockPane = dockPane;
		}

		~Pane()
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

	protected sealed class PaneCollection : IEnumerable<Pane>, IEnumerable
	{
		private class AutoHideState
		{
			public DockState m_dockState;

			public bool m_selected;

			public DockState DockState => m_dockState;

			public bool Selected
			{
				get
				{
					return m_selected;
				}
				set
				{
					m_selected = value;
				}
			}

			public AutoHideState(DockState dockState)
			{
				m_dockState = dockState;
			}
		}

		private class AutoHideStateCollection
		{
			private AutoHideState[] m_states;

			public AutoHideState this[DockState dockState]
			{
				get
				{
					for (int i = 0; i < m_states.Length; i++)
					{
						if (m_states[i].DockState == dockState)
						{
							return m_states[i];
						}
					}
					throw new ArgumentOutOfRangeException("dockState");
				}
			}

			public AutoHideStateCollection()
			{
				m_states = new AutoHideState[4]
				{
					new AutoHideState(DockState.DockTopAutoHide),
					new AutoHideState(DockState.DockBottomAutoHide),
					new AutoHideState(DockState.DockLeftAutoHide),
					new AutoHideState(DockState.DockRightAutoHide)
				};
			}

			public bool ContainsPane(DockPane pane)
			{
				if (pane.IsHidden)
				{
					return false;
				}
				for (int i = 0; i < m_states.Length; i++)
				{
					if (m_states[i].DockState == pane.DockState && m_states[i].Selected)
					{
						return true;
					}
				}
				return false;
			}
		}

		private DockPanel m_dockPanel;

		private AutoHideStateCollection m_states;

		public DockPanel DockPanel => m_dockPanel;

		private AutoHideStateCollection States => m_states;

		public int Count
		{
			get
			{
				int num = 0;
				foreach (DockPane pane in DockPanel.Panes)
				{
					if (States.ContainsPane(pane))
					{
						num++;
					}
				}
				return num;
			}
		}

		public Pane this[int index]
		{
			get
			{
				int num = 0;
				foreach (DockPane pane in DockPanel.Panes)
				{
					if (!States.ContainsPane(pane))
					{
						continue;
					}
					if (num == index)
					{
						if (pane.AutoHidePane == null)
						{
							pane.AutoHidePane = DockPanel.AutoHideStripControl.CreatePane(pane);
						}
						return pane.AutoHidePane as Pane;
					}
					num++;
				}
				throw new ArgumentOutOfRangeException("index");
			}
		}

		internal PaneCollection(DockPanel panel, DockState dockState)
		{
			m_dockPanel = panel;
			m_states = new AutoHideStateCollection();
			States[DockState.DockTopAutoHide].Selected = dockState == DockState.DockTopAutoHide;
			States[DockState.DockBottomAutoHide].Selected = dockState == DockState.DockBottomAutoHide;
			States[DockState.DockLeftAutoHide].Selected = dockState == DockState.DockLeftAutoHide;
			States[DockState.DockRightAutoHide].Selected = dockState == DockState.DockRightAutoHide;
		}

		public bool Contains(Pane pane)
		{
			return IndexOf(pane) != -1;
		}

		public int IndexOf(Pane pane)
		{
			if (pane == null)
			{
				return -1;
			}
			int num = 0;
			foreach (DockPane pane2 in DockPanel.Panes)
			{
				if (States.ContainsPane(pane.DockPane))
				{
					if (pane == pane2.AutoHidePane)
					{
						return num;
					}
					num++;
				}
			}
			return -1;
		}

		IEnumerator<Pane> IEnumerable<Pane>.GetEnumerator()
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
	}

	private DockPanel m_dockPanel;

	private PaneCollection m_panesTop;

	private PaneCollection m_panesBottom;

	private PaneCollection m_panesLeft;

	private PaneCollection m_panesRight;

	private GraphicsPath m_displayingArea;

	protected DockPanel DockPanel => m_dockPanel;

	protected PaneCollection PanesTop => m_panesTop;

	protected PaneCollection PanesBottom => m_panesBottom;

	protected PaneCollection PanesLeft => m_panesLeft;

	protected PaneCollection PanesRight => m_panesRight;

	protected Rectangle RectangleTopLeft
	{
		get
		{
			int num = MeasureHeight();
			if (PanesTop.Count <= 0 || PanesLeft.Count <= 0)
			{
				return Rectangle.Empty;
			}
			return new Rectangle(0, 0, num, num);
		}
	}

	protected Rectangle RectangleTopRight
	{
		get
		{
			int num = MeasureHeight();
			if (PanesTop.Count <= 0 || PanesRight.Count <= 0)
			{
				return Rectangle.Empty;
			}
			return new Rectangle(((Control)this).Width - num, 0, num, num);
		}
	}

	protected Rectangle RectangleBottomLeft
	{
		get
		{
			int num = MeasureHeight();
			if (PanesBottom.Count <= 0 || PanesLeft.Count <= 0)
			{
				return Rectangle.Empty;
			}
			return new Rectangle(0, ((Control)this).Height - num, num, num);
		}
	}

	protected Rectangle RectangleBottomRight
	{
		get
		{
			int num = MeasureHeight();
			if (PanesBottom.Count <= 0 || PanesRight.Count <= 0)
			{
				return Rectangle.Empty;
			}
			return new Rectangle(((Control)this).Width - num, ((Control)this).Height - num, num, num);
		}
	}

	private GraphicsPath DisplayingArea
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			if (m_displayingArea == null)
			{
				m_displayingArea = new GraphicsPath();
			}
			return m_displayingArea;
		}
	}

	protected AutoHideStripBase(DockPanel panel)
	{
		m_dockPanel = panel;
		m_panesTop = new PaneCollection(panel, DockState.DockTopAutoHide);
		m_panesBottom = new PaneCollection(panel, DockState.DockBottomAutoHide);
		m_panesLeft = new PaneCollection(panel, DockState.DockLeftAutoHide);
		m_panesRight = new PaneCollection(panel, DockState.DockRightAutoHide);
		((Control)this).SetStyle((ControlStyles)131072, true);
		((Control)this).SetStyle((ControlStyles)512, false);
	}

	protected PaneCollection GetPanes(DockState dockState)
	{
		return dockState switch
		{
			DockState.DockTopAutoHide => PanesTop, 
			DockState.DockBottomAutoHide => PanesBottom, 
			DockState.DockLeftAutoHide => PanesLeft, 
			DockState.DockRightAutoHide => PanesRight, 
			_ => throw new ArgumentOutOfRangeException("dockState"), 
		};
	}

	internal int GetNumberOfPanes(DockState dockState)
	{
		return GetPanes(dockState).Count;
	}

	protected internal Rectangle GetTabStripRectangle(DockState dockState)
	{
		int num = MeasureHeight();
		if (dockState == DockState.DockTopAutoHide && PanesTop.Count > 0)
		{
			return new Rectangle(RectangleTopLeft.Width, 0, ((Control)this).Width - RectangleTopLeft.Width - RectangleTopRight.Width, num);
		}
		if (dockState == DockState.DockBottomAutoHide && PanesBottom.Count > 0)
		{
			return new Rectangle(RectangleBottomLeft.Width, ((Control)this).Height - num, ((Control)this).Width - RectangleBottomLeft.Width - RectangleBottomRight.Width, num);
		}
		if (dockState == DockState.DockLeftAutoHide && PanesLeft.Count > 0)
		{
			return new Rectangle(0, RectangleTopLeft.Width, num, ((Control)this).Height - RectangleTopLeft.Height - RectangleBottomLeft.Height);
		}
		if (dockState == DockState.DockRightAutoHide && PanesRight.Count > 0)
		{
			return new Rectangle(((Control)this).Width - num, RectangleTopRight.Width, num, ((Control)this).Height - RectangleTopRight.Height - RectangleBottomRight.Height);
		}
		return Rectangle.Empty;
	}

	private void SetRegion()
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		DisplayingArea.Reset();
		DisplayingArea.AddRectangle(RectangleTopLeft);
		DisplayingArea.AddRectangle(RectangleTopRight);
		DisplayingArea.AddRectangle(RectangleBottomLeft);
		DisplayingArea.AddRectangle(RectangleBottomRight);
		DisplayingArea.AddRectangle(GetTabStripRectangle(DockState.DockTopAutoHide));
		DisplayingArea.AddRectangle(GetTabStripRectangle(DockState.DockBottomAutoHide));
		DisplayingArea.AddRectangle(GetTabStripRectangle(DockState.DockLeftAutoHide));
		DisplayingArea.AddRectangle(GetTabStripRectangle(DockState.DockRightAutoHide));
		((Control)this).Region = new Region(DisplayingArea);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		if ((int)e.Button == 1048576)
		{
			HitTest()?.DockHandler.Activate();
		}
	}

	protected override void OnMouseHover(EventArgs e)
	{
		((Control)this).OnMouseHover(e);
		IDockContent dockContent = HitTest();
		if (dockContent != null && DockPanel.ActiveAutoHideContent != dockContent)
		{
			DockPanel.ActiveAutoHideContent = dockContent;
		}
		((Control)this).ResetMouseEventArgs();
	}

	protected override void OnLayout(LayoutEventArgs levent)
	{
		RefreshChanges();
		((Control)this).OnLayout(levent);
	}

	internal void RefreshChanges()
	{
		if (!((Control)this).IsDisposed)
		{
			SetRegion();
			OnRefreshChanges();
		}
	}

	protected virtual void OnRefreshChanges()
	{
	}

	protected internal abstract int MeasureHeight();

	private IDockContent HitTest()
	{
		Point point = ((Control)this).PointToClient(Control.MousePosition);
		return HitTest(point);
	}

	protected virtual Tab CreateTab(IDockContent content)
	{
		return new Tab(content);
	}

	protected virtual Pane CreatePane(DockPane dockPane)
	{
		return new Pane(dockPane);
	}

	protected abstract IDockContent HitTest(Point point);
}
