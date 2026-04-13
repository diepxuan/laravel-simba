using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSODMCK : frmDMComplexView
{
	private IContainer components;

	protected internal override Button cmdSearch
	{
		get
		{
			return base.cmdSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdSearch_Click;
			if (base.cmdSearch != null)
			{
				((Control)base.cmdSearch).Click -= eventHandler;
			}
			base.cmdSearch = value;
			if (base.cmdSearch != null)
			{
				((Control)base.cmdSearch).Click += eventHandler;
			}
		}
	}

	public frmSODMCK(ref string MenuId)
		: base(MenuId)
	{
		InitializeComponent();
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
		((Control)cmdDel).Location = ((Control)cmdPrint).Location;
		((Control)cboFilter).Visible = false;
		((Control)cmdEdit).Location = ((Control)cmdChgCode).Location;
		((Control)cmdSearch).Visible = false;
		((Control)lblTen).Visible = false;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdSearch_Click(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		frmLoc frmLoc2 = new frmLoc();
		((Control)frmLoc2.txtMa_NHVT).Select();
		((Form)frmLoc2).ShowDialog();
		((DataGridView)dgvDM).DataSource = frmLoc2.f_oTblDM.DefaultView;
		((Component)(object)frmLoc2).Dispose();
	}
}
