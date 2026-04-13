using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmGLBudget : frmDMView
{
	private IContainer components;

	internal DataTable dt;

	public frmGLBudget(string menuid)
		: base(menuid)
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
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdChgCode).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdEdit).Location;
		((Control)cmdEdit).Location = ((Control)cmdDel).Location;
		((Control)cmdDel).Location = ((Control)cmdChgCode).Location;
		((Control)this).Name = "frmGLBudget";
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void GetData(params object[] @params)
	{
		base.GetData(CompanyInformations.CompanyID, SystemInformations.FinancialYear);
	}

	protected override void FormatGridView()
	{
		base.FormatGridView();
		if (((BaseCollection)((DataGridView)base.dgvDM).Columns).Count > 7)
		{
			int num = 0;
			do
			{
				((DataGridView)base.dgvDM).Columns[num].Frozen = true;
				num = checked(num + 1);
			}
			while (num <= 7);
		}
	}
}
