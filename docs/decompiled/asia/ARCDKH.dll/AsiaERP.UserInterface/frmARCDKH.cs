using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmARCDKH : frmOBView
{
	private IContainer components;

	private string _strMaTk;

	private string _strMaHd;

	private string _strMaBp;

	private string _strMaSpct;

	private string _strMaKh;

	private string _strLoai;

	private bool _check;

	public frmARCDKH(string MenuID)
		: base(MenuID)
	{
		((Form)this).Shown += frmARCDKH_Shown;
		_strMaTk = "";
		_strMaHd = "";
		_strMaBp = "";
		_strMaSpct = "";
		_strMaKh = "";
		_strLoai = "";
		_check = false;
		InitializeComponent();
		AsDataGridView asDataGridView = dgvDM;
		Size size = checked(new Size(((Control)cmdClose).Right - 10, ((Control)cmdClose).Top - 16));
		((Control)asDataGridView).Size = size;
		((Control)cmdChgCode).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdEdit).Location;
		((Control)cmdEdit).Location = ((Control)cmdDel).Location;
		((Control)cmdDel).Location = ((Control)cmdChgCode).Location;
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
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool Login()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		frmARCDKHFilter frmARCDKHFilter2 = new frmARCDKHFilter();
		frmARCDKHFilter2.txtYear.Text = Conversions.ToString(SystemInformations.FinancialYear);
		if ((int)((Form)frmARCDKHFilter2).ShowDialog() == 1)
		{
			_strMaBp = ((TextBox)frmARCDKHFilter2.txtMa_bp).Text;
			_strMaHd = ((TextBox)frmARCDKHFilter2.txtMa_hd).Text;
			_strMaKh = ((TextBox)frmARCDKHFilter2.txtMa_kh).Text;
			_strMaSpct = ((TextBox)frmARCDKHFilter2.txtMa_spct).Text;
			_strMaTk = ((TextBox)frmARCDKHFilter2.txtMa_tk).Text;
			_strLoai = Conversions.ToString(frmARCDKHFilter2.cboCategory.Text[0]);
			_check = true;
			return _check;
		}
		_check = false;
		return true;
	}

	protected override void GetData(params object[] @params)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(SystemInformations.FinancialYear);
		arrayList.Add(_strMaTk);
		arrayList.Add(_strMaKh);
		arrayList.Add(_strMaHd);
		arrayList.Add(_strMaBp);
		arrayList.Add(_strMaSpct);
		arrayList.Add(_strLoai);
		base.SourceTable = base.MyController.GetData(arrayList.ToArray());
	}

	private void frmARCDKH_Shown(object sender, EventArgs e)
	{
		if (!_check)
		{
			((Form)this).Close();
		}
	}
}
