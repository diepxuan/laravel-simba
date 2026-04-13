using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;

namespace AsiaErp.Framework.Docking;

public abstract class DockPaneCaptionBase : Control
{
	private DockPane m_dockPane;

	protected DockPane DockPane => m_dockPane;

	protected DockPane.AppearanceStyle Appearance => DockPane.Appearance;

	protected bool HasTabPageContextMenu => DockPane.HasTabPageContextMenu;

	protected internal DockPaneCaptionBase(DockPane pane)
	{
		m_dockPane = pane;
		((Control)this).SetStyle((ControlStyles)139282, true);
		((Control)this).SetStyle((ControlStyles)512, false);
	}

	protected void ShowTabPageContextMenu(Point position)
	{
		DockPane.ShowTabPageContextMenu((Control)(object)this, position);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseUp(e);
		if ((int)e.Button == 2097152)
		{
			ShowTabPageContextMenu(new Point(e.X, e.Y));
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		if ((int)e.Button == 1048576 && DockPane.DockPanel.AllowEndUserDocking && DockPane.AllowDockDragAndDrop && !DockHelper.IsDockStateAutoHide(DockPane.DockState) && DockPane.ActiveContent != null)
		{
			DockPane.DockPanel.BeginDrag(DockPane);
		}
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).Msg == 515)
		{
			if (DockHelper.IsDockStateAutoHide(DockPane.DockState))
			{
				DockPane.DockPanel.ActiveAutoHideContent = null;
				return;
			}
			if (DockPane.IsFloat)
			{
				DockPane.RestoreToPanel();
			}
			else
			{
				DockPane.Float();
			}
		}
		((Control)this).WndProc(ref m);
	}

	internal void RefreshChanges()
	{
		if (!((Control)this).IsDisposed)
		{
			OnRefreshChanges();
		}
	}

	protected virtual void OnRightToLeftLayoutChanged()
	{
	}

	protected virtual void OnRefreshChanges()
	{
	}

	protected internal abstract int MeasureHeight();
}
