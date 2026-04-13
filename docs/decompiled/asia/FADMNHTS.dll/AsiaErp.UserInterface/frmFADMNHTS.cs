using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmFADMNHTS : frmDMComplexView
{
	private IContainer components;

	public frmFADMNHTS(string MenuID)
		: base(MenuID)
	{
		InitializeComponent();
		AsDataGridView asDataGridView = dgvDM;
		Size size = checked(new Size(((Control)cmdClose).Right - 10, ((Control)this).Height - 80));
		((Control)asDataGridView).Size = size;
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Control)cmdChgCode).Visible = false;
		((Control)txtValue).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdDel).Location;
		((Control)cmdEdit).Location = ((Control)cmdChgCode).Location;
		((Control)cmdDel).Location = ((Control)cmdPrint).Location;
		((Control)cboFilter).Visible = false;
		((Control)cmdSearch).Visible = false;
		((Control)lblTen).Visible = false;
		((Control)cmdPrint).Visible = false;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
