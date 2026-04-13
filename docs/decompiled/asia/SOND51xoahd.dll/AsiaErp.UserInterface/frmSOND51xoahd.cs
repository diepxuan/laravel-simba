using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSOND51xoahd : frmDMComplexView
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

	protected frmSOND51xoahd(string menuid)
		: base(menuid)
	{
		InitializeComponent();
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
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void GetData(params object[] @params)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add("XOA");
		base.GetData(arrayList.ToArray());
	}
}
