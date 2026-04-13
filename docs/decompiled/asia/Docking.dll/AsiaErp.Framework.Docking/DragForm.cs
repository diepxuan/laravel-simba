using System;
using System.Windows.Forms;

namespace AsiaErp.Framework.Docking;

internal class DragForm : Form
{
	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).CreateParams;
			createParams.ExStyle |= 0x80;
			return createParams;
		}
	}

	public DragForm()
	{
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).ShowInTaskbar = false;
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).Enabled = false;
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).Msg == 132)
		{
			((Message)(ref m)).Result = (IntPtr)(-1L);
		}
		else
		{
			((Form)this).WndProc(ref m);
		}
	}

	public virtual void Show(bool bActivate)
	{
		if (bActivate)
		{
			((Control)this).Show();
		}
		else
		{
			NativeMethods.ShowWindow(((Control)this).Handle, 4);
		}
	}
}
