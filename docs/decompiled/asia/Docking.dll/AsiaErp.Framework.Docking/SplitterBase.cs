using System.Drawing;
using System.Windows.Forms;

namespace AsiaErp.Framework.Docking;

internal class SplitterBase : Control
{
	public override DockStyle Dock
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).Dock;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Invalid comparison between Unknown and I4
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Invalid comparison between Unknown and I4
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Invalid comparison between Unknown and I4
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Invalid comparison between Unknown and I4
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Invalid comparison between Unknown and I4
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Invalid comparison between Unknown and I4
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Invalid comparison between Unknown and I4
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Invalid comparison between Unknown and I4
			((Control)this).SuspendLayout();
			((Control)this).Dock = value;
			if ((int)((Control)this).Dock == 3 || (int)((Control)this).Dock == 4)
			{
				((Control)this).Width = SplitterSize;
			}
			else if ((int)((Control)this).Dock == 1 || (int)((Control)this).Dock == 2)
			{
				((Control)this).Height = SplitterSize;
			}
			else
			{
				((Control)this).Bounds = Rectangle.Empty;
			}
			if ((int)((Control)this).Dock == 3 || (int)((Control)this).Dock == 4)
			{
				((Control)this).Cursor = Cursors.VSplit;
			}
			else if ((int)((Control)this).Dock == 1 || (int)((Control)this).Dock == 2)
			{
				((Control)this).Cursor = Cursors.HSplit;
			}
			else
			{
				((Control)this).Cursor = Cursors.Default;
			}
			((Control)this).ResumeLayout();
		}
	}

	protected virtual int SplitterSize => 0;

	public SplitterBase()
	{
		((Control)this).SetStyle((ControlStyles)512, false);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		if ((int)e.Button == 1048576)
		{
			StartDrag();
		}
	}

	protected virtual void StartDrag()
	{
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).Msg != 33)
		{
			((Control)this).WndProc(ref m);
		}
	}
}
