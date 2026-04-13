using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmAPTT : frmOBView
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
	}

	public frmAPTT(string Menuid)
		: base(Menuid)
	{
		InitializeComponent();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
		((Control)cmdChgCode).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdEdit).Location;
		((Control)cmdEdit).Location = ((Control)cmdDel).Location;
		((Control)cmdDel).Location = ((Control)cmdChgCode).Location;
	}

	protected override void GetData(params object[] @params)
	{
		base.GetData(CompanyInformations.CompanyID, MyMenuInfo.par1);
		base.SourceTable.Columns["du_tt_nt"].Expression = "t_tt_nt-tien_da_tt_nt";
		base.SourceTable.Columns["du_tt"].Expression = "t_tt-tien_da_tt";
	}

	protected override void Delete()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		DataRowView dataRowView = (DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvDM).DataSource)].Current;
		if (Operators.ConditionalCompareObjectLessEqual(dataRowView["ngay_ct"], (object)Environment.GetSIConfiguration().ngay_ks, false))
		{
			CMessageBox.Show(50136);
		}
		else
		{
			base.Delete();
		}
	}
}
