using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmFAAdjustKHTS : frmDMComplexView
{
	private IContainer components;

	private string strMa_ts;

	private int iThang;

	private bool check;

	public frmFAAdjustKHTS(string MenuID)
		: base(MenuID)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmFAAdjustKHTS_KeyDown);
		((Form)this).Shown += frmFAAdjustKHTS_Shown;
		strMa_ts = "";
		iThang = 1;
		check = false;
		InitializeComponent();
		AsDataGridView asDataGridView = dgvDM;
		Size size = checked(new Size(((Control)cmdClose).Right - 10, ((Control)cmdClose).Top - 15));
		((Control)asDataGridView).Size = size;
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
		Button obj = cmdChgCode;
		Point location = new Point(375, 434);
		((Control)obj).Location = location;
		((Control)cmdChgCode).Visible = false;
		TextBox obj2 = txtValue;
		location = new Point(140, 435);
		((Control)obj2).Location = location;
		((Control)txtValue).Visible = false;
		((Control)cmdDel).Enabled = false;
		Button obj3 = cmdDel;
		location = new Point(149, 396);
		((Control)obj3).Location = location;
		((Control)cmdDel).TabIndex = 100;
		((Control)cmdDel).Visible = false;
		ComboBox obj4 = cboFilter;
		location = new Point(57, 435);
		((Control)obj4).Location = location;
		((Control)cboFilter).Visible = false;
		Button obj5 = cmdEdit;
		location = new Point(593, 396);
		((Control)obj5).Location = location;
		Button obj6 = cmdEdit;
		Size size = new Size(82, 23);
		((Control)obj6).Size = size;
		((Control)cmdEdit).TabIndex = 3;
		((ButtonBase)cmdEdit).Text = "Điều &chỉnh";
		Button obj7 = cmdSearch;
		location = new Point(234, 434);
		((Control)obj7).Location = location;
		((Control)cmdSearch).Visible = false;
		((Control)cmdAdd).Enabled = false;
		Button obj8 = cmdAdd;
		location = new Point(9, 396);
		((Control)obj8).Location = location;
		((Control)cmdAdd).TabIndex = 100;
		((Control)cmdAdd).Visible = false;
		Label obj9 = lblTen;
		location = new Point(6, 437);
		((Control)obj9).Location = location;
		((Control)lblTen).Visible = false;
		((Control)cmdPrint).Enabled = false;
		Button obj10 = cmdPrint;
		location = new Point(219, 396);
		((Control)obj10).Location = location;
		((Control)cmdPrint).TabIndex = 100;
		((Control)cmdPrint).Visible = false;
		Button obj11 = cmdClose;
		location = new Point(681, 396);
		((Control)obj11).Location = location;
		((Control)cmdClose).TabIndex = 4;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(755, 429);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFAAdjustKHTS";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool Login()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		frmFAAdjustKHTSFilter frmFAAdjustKHTSFilter2 = new frmFAAdjustKHTSFilter();
		((Form)frmFAAdjustKHTSFilter2).Text = MyMenuInfo.bar;
		((Form)frmFAAdjustKHTSFilter2).ShowDialog();
		DialogResult dialogResult = ((Form)frmFAAdjustKHTSFilter2).DialogResult;
		if ((int)dialogResult == 1)
		{
			strMa_ts = ((TextBox)frmFAAdjustKHTSFilter2.txtMa_Ts).Text;
			iThang = Conversions.ToInteger(((ComboBox)frmFAAdjustKHTSFilter2.cboKyBc).Text);
			check = true;
			return true;
		}
		check = false;
		return true;
	}

	protected override void GetData(params object[] @params)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(SystemInformations.FinancialYear);
		arrayList.Add(iThang);
		arrayList.Add(strMa_ts);
		base.GetData(arrayList.ToArray());
	}

	private void frmFAAdjustKHTS_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}

	private void frmFAAdjustKHTS_Shown(object sender, EventArgs e)
	{
		if (!check)
		{
			((Form)this).Close();
		}
	}
}
