using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using AsiaERP.UserInterface.My.Resources;
using AsiaErp.Framework;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmSODMKM : frmDMView
{
	private IContainer components;

	[AccessedThroughProperty("cmdHang_TKM")]
	private Button _cmdHang_TKM;

	[AccessedThroughProperty("cmdHang_KM")]
	private Button _cmdHang_KM;

	[AccessedThroughProperty("cmdPrintKM")]
	private Button _cmdPrintKM;

	internal virtual Button cmdHang_TKM
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdHang_TKM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdHang_TKM_Click;
			if (_cmdHang_TKM != null)
			{
				((Control)_cmdHang_TKM).Click -= eventHandler;
			}
			_cmdHang_TKM = value;
			if (_cmdHang_TKM != null)
			{
				((Control)_cmdHang_TKM).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdHang_KM
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdHang_KM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdHang_KM_Click;
			if (_cmdHang_KM != null)
			{
				((Control)_cmdHang_KM).Click -= eventHandler;
			}
			_cmdHang_KM = value;
			if (_cmdHang_KM != null)
			{
				((Control)_cmdHang_KM).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdPrintKM
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPrintKM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdPrintKM_Click;
			if (_cmdPrintKM != null)
			{
				((Control)_cmdPrintKM).Click -= eventHandler;
			}
			_cmdPrintKM = value;
			if (_cmdPrintKM != null)
			{
				((Control)_cmdPrintKM).Click += eventHandler;
			}
		}
	}

	public frmSODMKM(string MenuID)
		: base(MenuID)
	{
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		cmdHang_TKM = new Button();
		cmdHang_KM = new Button();
		cmdPrintKM = new Button();
		((Control)this).SuspendLayout();
		Button obj = cmdChgCode;
		Point location = new Point(772, 488);
		((Control)obj).Location = location;
		((Control)cmdChgCode).TabIndex = 6;
		TextBox obj2 = txtValue;
		location = new Point(134, 489);
		((Control)obj2).Location = location;
		((Control)txtValue).TabIndex = 10;
		Button obj3 = cmdDel;
		location = new Point(636, 488);
		((Control)obj3).Location = location;
		((Control)cmdDel).TabIndex = 4;
		ComboBox obj4 = cboFilter;
		location = new Point(51, 489);
		((Control)obj4).Location = location;
		((Control)cboFilter).TabIndex = 9;
		Button obj5 = cmdEdit;
		location = new Point(566, 488);
		((Control)obj5).Location = location;
		((Control)cmdEdit).TabIndex = 3;
		Button obj6 = cmdSearch;
		location = new Point(228, 488);
		((Control)obj6).Location = location;
		((Control)cmdSearch).TabIndex = 11;
		Button obj7 = cmdAdd;
		location = new Point(496, 488);
		((Control)obj7).Location = location;
		((Control)cmdAdd).TabIndex = 2;
		Label obj8 = lblTen;
		location = new Point(8, 491);
		((Control)obj8).Location = location;
		Label obj9 = lblTen;
		Size size = new Size(37, 17);
		((Control)obj9).Size = size;
		((Control)lblTen).TabIndex = 8;
		Button obj10 = cmdPrint;
		location = new Point(706, 445);
		((Control)obj10).Location = location;
		((Control)cmdPrint).TabIndex = 5;
		((Control)cmdPrint).Visible = false;
		Button obj11 = cmdClose;
		location = new Point(842, 488);
		((Control)obj11).Location = location;
		((Control)cmdClose).TabIndex = 7;
		((Control)cmdHang_TKM).Anchor = (AnchorStyles)10;
		Button obj12 = cmdHang_TKM;
		location = new Point(415, 488);
		((Control)obj12).Location = location;
		((Control)cmdHang_TKM).Name = "cmdHang_TKM";
		Button obj13 = cmdHang_TKM;
		size = new Size(75, 23);
		((Control)obj13).Size = size;
		((Control)cmdHang_TKM).TabIndex = 1;
		((ButtonBase)cmdHang_TKM).Text = "Hàng trả KM";
		((ButtonBase)cmdHang_TKM).UseVisualStyleBackColor = true;
		((Control)cmdHang_KM).Anchor = (AnchorStyles)10;
		Button obj14 = cmdHang_KM;
		location = new Point(349, 488);
		((Control)obj14).Location = location;
		((Control)cmdHang_KM).Name = "cmdHang_KM";
		Button obj15 = cmdHang_KM;
		size = new Size(60, 23);
		((Control)obj15).Size = size;
		((Control)cmdHang_KM).TabIndex = 0;
		((ButtonBase)cmdHang_KM).Text = "Hàng KM";
		((ButtonBase)cmdHang_KM).UseVisualStyleBackColor = true;
		((Control)cmdPrintKM).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdPrintKM).Image = (Image)(object)Resources.cmdPrint;
		((ButtonBase)cmdPrintKM).ImageAlign = (ContentAlignment)16;
		Button obj16 = cmdPrintKM;
		location = new Point(706, 488);
		((Control)obj16).Location = location;
		((Control)cmdPrintKM).Name = "cmdPrintKM";
		Button obj17 = cmdPrintKM;
		size = new Size(60, 23);
		((Control)obj17).Size = size;
		((Control)cmdPrintKM).TabIndex = 40;
		((ButtonBase)cmdPrintKM).Text = "&In";
		((ButtonBase)cmdPrintKM).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdPrintKM).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(914, 521);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdPrintKM);
		((Control)this).Controls.Add((Control)(object)cmdHang_TKM);
		((Control)this).Controls.Add((Control)(object)cmdHang_KM);
		((Control)this).Name = "frmSODMKM";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdHang_KM, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdHang_TKM, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrintKM, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdChgCode, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdClose, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtValue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cboFilter, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen, 0);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdHang_TKM_Click(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		Assembly assembly = Assembly.Load("SODMTKM");
		frmDMComplexView frmDMComplexView = (frmDMComplexView)assembly.CreateInstance("AsiaERP.UserInterface.frmSODMTKM", ignoreCase: true, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, new object[1] { "06.90.39" }, Thread.CurrentThread.CurrentCulture, null);
		((Form)frmDMComplexView).ShowDialog();
		((Component)(object)frmDMComplexView).Dispose();
	}

	private void cmdHang_KM_Click(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		Assembly assembly = Assembly.Load("SODMHHKM");
		frmDMComplexView frmDMComplexView = (frmDMComplexView)assembly.CreateInstance("AsiaERP.UserInterface.frmSODMHHKM", ignoreCase: true, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, new object[1] { "06.90.40" }, Thread.CurrentThread.CurrentCulture, null);
		((Form)frmDMComplexView).ShowDialog();
		((Component)(object)frmDMComplexView).Dispose();
	}

	private void cmdPrintKM_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		frmFilterKM frmFilterKM2 = new frmFilterKM();
		if ((int)((Form)frmFilterKM2).ShowDialog() == 1)
		{
			ReportDocument val = new ReportDocument();
			DataTable dataTable = new DataTable();
			val.Load(SystemInformations.ReportPath + "SoDMKM.rpt");
			dataTable = Commons.GetDataTable("asSoRptDMKM", CompanyInformations.CompanyID, ((TextBox)frmFilterKM2.txtMa_km).Text, RuntimeHelpers.GetObjectValue(frmFilterKM2.txtNgay1.Value), RuntimeHelpers.GetObjectValue(frmFilterKM2.txtNgay2.Value));
			val.SetDataSource(dataTable);
			val.DataDefinition.FormulaFields["strHeadCompanyName"].Text = "'" + CompanyInformations.ParentCompanyName + "'";
			val.DataDefinition.FormulaFields["strCompanyName"].Text = "'" + CompanyInformations.CompanyName + "'";
			val.DataDefinition.FormulaFields["strTitle"].Text = "'" + frmFilterKM2.txtTenmau.Text + "'";
			frmViewCrystal frmViewCrystal = new frmViewCrystal();
			((Form)frmViewCrystal).Text = frmFilterKM2.txtTenmau.Text;
			frmViewCrystal.MyReportSource = val;
			frmViewCrystal.Show();
		}
	}
}
