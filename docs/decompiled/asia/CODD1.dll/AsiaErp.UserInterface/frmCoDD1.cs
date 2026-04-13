using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCoDD1 : frmDMComplexView
{
	private IContainer components;

	internal int f_iThang;

	private bool check;

	public frmCoDD1(string menuid)
		: base(menuid)
	{
		((Form)this).Shown += frmCoDD1_Shown;
		check = false;
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
		((Control)cmdPrint).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdDel).Location;
		((Control)cmdEdit).Location = ((Control)cmdChgCode).Location;
		((Control)cmdDel).Location = ((Control)cmdPrint).Location;
		((Control)this).Name = "frmCoDD1";
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		base.SourceTable.Columns["nam"].DefaultValue = SystemInformations.FinancialYear;
		base.SourceTable.Columns["thang"].DefaultValue = f_iThang;
	}

	protected override bool Login()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		frmCoDD1Filter frmCoDD1Filter2 = new frmCoDD1Filter();
		((TextBox)frmCoDD1Filter2.txtNam).Text = Conversions.ToString(SystemInformations.FinancialYear);
		frmCoDD1Filter2.txtThang.Value = (int)AsiaErp.Framework.Environment.get_PublicVariables("Thang2");
		((Form)frmCoDD1Filter2).Text = MyMenuInfo.bar.Trim();
		((Form)frmCoDD1Filter2).ShowDialog();
		DialogResult dialogResult = ((Form)frmCoDD1Filter2).DialogResult;
		if ((int)dialogResult == 1)
		{
			f_iThang = Conversions.ToInteger(frmCoDD1Filter2.txtThang.Value);
			check = true;
			DateTime t = new DateTime(SystemInformations.FinancialYear, f_iThang, DateTime.DaysInMonth(SystemInformations.FinancialYear, f_iThang));
			if (Operators.CompareString(frmCoDD1Filter2.txtThang.Value.ToString(), "0", false) != 0 && DateTime.Compare(t, AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks) <= 0)
			{
				CMessageBox.Show(50136);
				check = false;
			}
		}
		return true;
	}

	protected override void GetData(params object[] @params)
	{
		base.GetData(CompanyInformations.CompanyID, SystemInformations.FinancialYear, f_iThang, "", "");
	}

	private void frmCoDD1_Shown(object sender, EventArgs e)
	{
		if (!check)
		{
			((Form)this).Close();
		}
	}
}
