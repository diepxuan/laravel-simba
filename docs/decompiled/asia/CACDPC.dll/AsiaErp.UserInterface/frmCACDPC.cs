using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCACDPC : frmOBView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public frmCACDPC(string MenuId)
		: base(MenuId)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
		AsDataGridView asDataGridView = dgvDM;
		Size size = checked(new Size(((Control)cmdClose).Right - 10, ((Control)cmdClose).Top - 15));
		((Control)asDataGridView).Size = size;
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Control)cmdAdd).Location = ((Control)cmdEdit).Location;
		((Control)cmdEdit).Location = ((Control)cmdDel).Location;
		((Control)cmdDel).Location = ((Control)cmdChgCode).Location;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void GetData(params object[] @params)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(base.MyMenuInfo.par1);
		base.SourceTable = base.MyController.GetData(arrayList.ToArray());
		base.SourceTable.Columns["ma_nt"].DefaultValue = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		base.SourceTable.Columns["ty_gia"].DefaultValue = 1;
		base.SourceTable.Columns["so_du"].Expression = "tien_pc-tien_da_tt";
		base.SourceTable.Columns["so_du_nt"].Expression = "tien_pc_nt-tien_da_tt_nt";
	}
}
