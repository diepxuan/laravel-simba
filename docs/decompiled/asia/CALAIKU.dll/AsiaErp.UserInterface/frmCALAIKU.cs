using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCALAIKU : frmDMComplexView
{
	private IContainer components;

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
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdChgCode).Visible = false;
		((Control)txtValue).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdDel).Location;
		((Control)cmdDel).Location = ((Control)cmdPrint).Location;
		((Control)cboFilter).Visible = false;
		((Control)cmdEdit).Location = ((Control)cmdChgCode).Location;
		((Control)cmdSearch).Visible = false;
		((Control)lblTen).Visible = false;
		((Control)cmdPrint).Visible = false;
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public frmCALAIKU(string menuid)
		: base(menuid)
	{
		InitializeComponent();
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		((Control)base.cmdEdit).Location = ((Control)base.cmdDel).Location;
		((Control)base.cmdDel).Location = ((Control)base.cmdChgCode).Location;
		((Component)(object)base.cmdAdd).Dispose();
		((Component)(object)base.cmdChgCode).Dispose();
	}

	protected override void Edit()
	{
		if (((DataGridView)base.dgvDM).RowCount != 0 && (Operators.ConditionalCompareObjectEqual(((DataGridView)base.dgvDM)["sua_goc", ((DataGridViewBand)((DataGridView)base.dgvDM).CurrentRow).Index].Value, (object)"1", false) || Operators.ConditionalCompareObjectEqual(((DataGridView)base.dgvDM)["sua_lai", ((DataGridViewBand)((DataGridView)base.dgvDM).CurrentRow).Index].Value, (object)"1", false)))
		{
			base.Edit();
		}
	}
}
