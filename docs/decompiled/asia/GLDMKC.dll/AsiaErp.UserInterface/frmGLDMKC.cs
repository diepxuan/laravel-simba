using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLDMKC : frmDMComplexView
{
	private IContainer components;

	private static string SttMax;

	public static string GetSttMax => SttMax;

	public frmGLDMKC(string menuid)
		: base(menuid)
	{
		InitializeComponent();
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
		((Control)this).Name = "frmGLDMKC";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void GetData(params object[] @params)
	{
		string par = MyMenuInfo.par1;
		base.GetData(CompanyInformations.CompanyID, par, "0");
	}

	protected override void AddNew()
	{
		SttMax = Conversions.ToString(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(SourceTable.Compute("max(stt)", "")), isNum: true), (object)1));
		base.AddNew();
	}
}
