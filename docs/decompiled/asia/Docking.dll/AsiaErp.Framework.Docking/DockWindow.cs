using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AsiaErp.Framework.Docking;

[ToolboxItem(false)]
public class DockWindow : Panel, INestedPanesContainer, ISplitterDragSource, IDragSource
{
	private class SplitterControl : SplitterBase
	{
		protected override int SplitterSize => 4;

		protected override void StartDrag()
		{
			if (((Control)this).Parent is DockWindow dockWindow)
			{
				dockWindow.DockPanel.BeginDrag(dockWindow, ((Control)dockWindow).RectangleToScreen(((Control)this).Bounds));
			}
		}
	}

	private DockPanel m_dockPanel;

	private DockState m_dockState;

	private SplitterControl m_splitter;

	private NestedPaneCollection m_nestedPanes;

	public VisibleNestedPaneCollection VisibleNestedPanes => NestedPanes.VisibleNestedPanes;

	public NestedPaneCollection NestedPanes => m_nestedPanes;

	public DockPanel DockPanel => m_dockPanel;

	public DockState DockState => m_dockState;

	public bool IsFloat => DockState == DockState.Float;

	internal DockPane DefaultPane
	{
		get
		{
			if (VisibleNestedPanes.Count != 0)
			{
				return VisibleNestedPanes[0];
			}
			return null;
		}
	}

	public virtual Rectangle DisplayingRectangle
	{
		get
		{
			Rectangle clientRectangle = ((Control)this).ClientRectangle;
			if (DockState == DockState.Document)
			{
				clientRectangle.X++;
				clientRectangle.Y++;
				clientRectangle.Width -= 2;
				clientRectangle.Height -= 2;
			}
			else if (DockState == DockState.DockLeft)
			{
				clientRectangle.Width -= 4;
			}
			else if (DockState == DockState.DockRight)
			{
				clientRectangle.X += 4;
				clientRectangle.Width -= 4;
			}
			else if (DockState == DockState.DockTop)
			{
				clientRectangle.Height -= 4;
			}
			else if (DockState == DockState.DockBottom)
			{
				clientRectangle.Y += 4;
				clientRectangle.Height -= 4;
			}
			return clientRectangle;
		}
	}

	bool ISplitterDragSource.IsVertical
	{
		get
		{
			if (DockState != DockState.DockLeft)
			{
				return DockState == DockState.DockRight;
			}
			return true;
		}
	}

	Rectangle ISplitterDragSource.DragLimitBounds
	{
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			Rectangle dockArea = DockPanel.DockArea;
			Point point = (((Control.ModifierKeys & 0x10000) != 0) ? DockPanel.DockArea.Location : ((Control)this).Location);
			if (((ISplitterDragSource)this).IsVertical)
			{
				dockArea.X += 24;
				dockArea.Width -= 48;
				dockArea.Y = point.Y;
				if ((Control.ModifierKeys & 0x10000) == 0)
				{
					dockArea.Height = ((Control)this).Height;
				}
			}
			else
			{
				dockArea.Y += 24;
				dockArea.Height -= 48;
				dockArea.X = point.X;
				if ((Control.ModifierKeys & 0x10000) == 0)
				{
					dockArea.Width = ((Control)this).Width;
				}
			}
			return ((Control)DockPanel).RectangleToScreen(dockArea);
		}
	}

	Control IDragSource.DragControl => (Control)(object)this;

	internal DockWindow(DockPanel dockPanel, DockState dockState)
	{
		m_nestedPanes = new NestedPaneCollection(this);
		m_dockPanel = dockPanel;
		m_dockState = dockState;
		((Control)this).Visible = false;
		((Control)this).SuspendLayout();
		if (DockState == DockState.DockLeft || DockState == DockState.DockRight || DockState == DockState.DockTop || DockState == DockState.DockBottom)
		{
			m_splitter = new SplitterControl();
			((Control)this).Controls.Add((Control)(object)m_splitter);
		}
		if (DockState == DockState.DockLeft)
		{
			((Control)this).Dock = (DockStyle)3;
			((Control)m_splitter).Dock = (DockStyle)4;
		}
		else if (DockState == DockState.DockRight)
		{
			((Control)this).Dock = (DockStyle)4;
			((Control)m_splitter).Dock = (DockStyle)3;
		}
		else if (DockState == DockState.DockTop)
		{
			((Control)this).Dock = (DockStyle)1;
			((Control)m_splitter).Dock = (DockStyle)2;
		}
		else if (DockState == DockState.DockBottom)
		{
			((Control)this).Dock = (DockStyle)2;
			((Control)m_splitter).Dock = (DockStyle)1;
		}
		else if (DockState == DockState.Document)
		{
			((Control)this).Dock = (DockStyle)5;
		}
		((Control)this).ResumeLayout();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (DockState == DockState.Document)
		{
			e.Graphics.DrawRectangle(SystemPens.ControlDark, ((Control)this).ClientRectangle.X, ((Control)this).ClientRectangle.Y, ((Control)this).ClientRectangle.Width - 1, ((Control)this).ClientRectangle.Height - 1);
		}
		((Control)this).OnPaint(e);
	}

	protected override void OnLayout(LayoutEventArgs levent)
	{
		VisibleNestedPanes.Refresh();
		if (VisibleNestedPanes.Count == 0)
		{
			if (((Control)this).Visible)
			{
				((Control)this).Visible = false;
			}
		}
		else if (!((Control)this).Visible)
		{
			((Control)this).Visible = true;
			VisibleNestedPanes.Refresh();
		}
		((ScrollableControl)this).OnLayout(levent);
	}

	void ISplitterDragSource.BeginDrag(Rectangle rectSplitter)
	{
	}

	void ISplitterDragSource.EndDrag()
	{
	}

	void ISplitterDragSource.MoveSplitter(int offset)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if ((Control.ModifierKeys & 0x10000) != 0)
		{
			((Control)this).SendToBack();
		}
		Rectangle dockArea = DockPanel.DockArea;
		if (DockState == DockState.DockLeft && dockArea.Width > 0)
		{
			if (DockPanel.DockLeftPortion > 1.0)
			{
				DockPanel.DockLeftPortion = ((Control)this).Width + offset;
			}
			else
			{
				DockPanel.DockLeftPortion += (double)offset / (double)dockArea.Width;
			}
		}
		else if (DockState == DockState.DockRight && dockArea.Width > 0)
		{
			if (DockPanel.DockRightPortion > 1.0)
			{
				DockPanel.DockRightPortion = ((Control)this).Width - offset;
			}
			else
			{
				DockPanel.DockRightPortion -= (double)offset / (double)dockArea.Width;
			}
		}
		else if (DockState == DockState.DockBottom && dockArea.Height > 0)
		{
			if (DockPanel.DockBottomPortion > 1.0)
			{
				DockPanel.DockBottomPortion = ((Control)this).Height - offset;
			}
			else
			{
				DockPanel.DockBottomPortion -= (double)offset / (double)dockArea.Height;
			}
		}
		else if (DockState == DockState.DockTop && dockArea.Height > 0)
		{
			if (DockPanel.DockTopPortion > 1.0)
			{
				DockPanel.DockTopPortion = ((Control)this).Height + offset;
			}
			else
			{
				DockPanel.DockTopPortion += (double)offset / (double)dockArea.Height;
			}
		}
	}
}
