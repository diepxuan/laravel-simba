using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSOND51phhd : frmDMComplexView
{
	private IContainer components;

	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	internal virtual Button btnPrint
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnPrint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnPrint_Click;
			if (_btnPrint != null)
			{
				((Control)_btnPrint).Click -= eventHandler;
			}
			_btnPrint = value;
			if (_btnPrint != null)
			{
				((Control)_btnPrint).Click += eventHandler;
			}
		}
	}

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

	protected frmSOND51phhd(string menuid)
		: base(menuid)
	{
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		btnPrint = new Button();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdChgCode).TabIndex = 5;
		((Control)cmdChgCode).Visible = false;
		((Control)txtValue).TabIndex = 2;
		((Control)cmdAdd).Location = ((Control)cmdEdit).Location;
		((Control)cmdAdd).TabIndex = 3;
		((Control)cmdEdit).Location = ((Control)cmdDel).Location;
		((Control)cmdEdit).TabIndex = 4;
		((Control)cmdDel).Location = ((Control)cmdChgCode).Location;
		((Control)cboFilter).TabIndex = 0;
		((Control)cmdSearch).TabIndex = 1;
		((Control)cmdPrint).Visible = false;
		((Control)cmdClose).TabIndex = 7;
		((Control)btnPrint).Anchor = (AnchorStyles)10;
		((ButtonBase)btnPrint).Image = (Image)(object)Resources.imgPrint;
		((ButtonBase)btnPrint).ImageAlign = (ContentAlignment)16;
		((Control)btnPrint).Location = ((Control)cmdPrint).Location;
		((Control)btnPrint).Name = "btnPrint";
		Button obj = btnPrint;
		Size size = new Size(65, 23);
		((Control)obj).Size = size;
		((Control)btnPrint).TabIndex = 6;
		((ButtonBase)btnPrint).Text = "&In";
		((ButtonBase)btnPrint).UseVisualStyleBackColor = true;
		((Control)this).Controls.Add((Control)(object)btnPrint);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)btnPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdClose, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cboFilter, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtValue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdChgCode, 0);
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		ArrayList reportInformation = AsiaErp.Framework.Environment.GetReportInformation(MyMenuID);
		ReportInformation reportInformation2 = (ReportInformation)reportInformation[0];
		ArrayList arrayList = new ArrayList();
		ReportDocument val = new ReportDocument();
		DataTable dataTable = new DataTable();
		val.Load(SystemInformations.ReportPath + reportInformation2.rptname);
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)dgvDM).CurrentRow.Cells["ma_tb"].Value));
		dataTable = Commons.GetDataTable(reportInformation2.spname, arrayList.ToArray());
		val.SetDataSource(dataTable);
		val.DataDefinition.FormulaFields["strHeadCompanyName"].Text = "'" + CompanyInformations.ParentCompanyName + "'";
		val.DataDefinition.FormulaFields["strCompanyName"].Text = "'" + CompanyInformations.CompanyName + "'";
		val.DataDefinition.FormulaFields["strTitle"].Text = "'" + reportInformation2.title + "'";
		frmViewCrystal frmViewCrystal = new frmViewCrystal();
		((Form)frmViewCrystal).Text = reportInformation2.title;
		frmViewCrystal.MyReportSource = val;
		frmViewCrystal.Show();
	}
}
