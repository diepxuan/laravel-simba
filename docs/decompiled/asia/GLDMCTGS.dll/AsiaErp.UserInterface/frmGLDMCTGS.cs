using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLDMCTGS : frmDMView
{
	private IContainer components;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public frmGLDMCTGS(string menuid)
		: base(menuid)
	{
		InitializeComponent();
		((Control)cmdPrint).Visible = false;
		((Control)cmdChgCode).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdDel).Location;
		((Control)cmdEdit).Location = ((Control)cmdChgCode).Location;
		((Control)cmdDel).Location = ((Control)cmdPrint).Location;
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		components = new Container();
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).Text = "frmGLDMCTGS";
	}
}
