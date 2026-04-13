using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLMauPL01 : frmDMView
{
	private string ma_mau;

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

	public frmGLMauPL01(string menuid, string code_name, string Mau)
		: base(menuid, code_name)
	{
		InitializeComponent();
		ma_mau = Mau;
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherBeforeLoadData();
		base.SourceTable.Columns["ma_so"].DefaultValue = "";
	}

	protected override void GetData(params object[] @params)
	{
		base.GetData(CompanyInformations.CompanyID, ma_mau);
	}

	protected override void InitOtherBeforeLoadData()
	{
		base.InitOtherBeforeLoadData();
		((Control)base.cmdChgCode).Visible = false;
		((Control)base.lblTen).Visible = false;
		((Control)base.cboFilter).Visible = false;
		((Control)base.txtValue).Visible = false;
		((Control)base.cmdSearch).Visible = false;
		((Control)base.cmdAdd).Location = ((Control)base.cmdEdit).Location;
		((Control)base.cmdEdit).Location = ((Control)base.cmdDel).Location;
		((Control)base.cmdDel).Location = ((Control)base.cmdChgCode).Location;
	}
}
