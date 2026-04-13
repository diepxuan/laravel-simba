using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLRptF5CTGS02 : frmDrilldownReport
{
	private IContainer components;

	private DateTime dNgay1;

	private DateTime dNgay2;

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
		components = new Container();
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).Text = "frmGLRptF5CTGS02";
	}

	public frmGLRptF5CTGS02(ReportInformation motherReportInfo, string drilldownMenuId, AsDictionary formularFields, bool isNT, string nhan_in, string filter4Tilte, string formatedColList, object datasource, params object[] arg)
		: base(motherReportInfo, drilldownMenuId, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, RuntimeHelpers.GetObjectValue(datasource), arg)
	{
		dNgay1 = Conversions.ToDate(arg[2]);
		dNgay2 = Conversions.ToDate(arg[3]);
		InitializeComponent();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		((Control)base.dgvBC).Select();
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		DataRowView dataRowView = (DataRowView)NewLateBinding.LateGet(get_MyDGVSource(isSet2Print: true), (Type)null, "DefaultView", new object[1] { ((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index }, (string[])null, (Type[])null, (bool[])null);
		if ((int)keycode != 116)
		{
			base.CancelDrilldown = true;
			return null;
		}
		ArrayList arrayList = new ArrayList();
		if ((int)modifierKeys == 0)
		{
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(dNgay1);
			arrayList.Add(dNgay2);
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ngay_lo"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["so_lo"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["tk"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["tk_du"]));
			filterCondition4title = dataRowView["so_lo"].ToString() + " - " + dataRowView["dien_giai"].ToString();
			return arrayList;
		}
		base.CancelDrilldown = true;
		return null;
	}
}
