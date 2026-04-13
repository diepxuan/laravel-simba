using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGlRptF5Bctc04 : frmDrilldownReport
{
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		components = new Container();
	}

	public frmGlRptF5Bctc04(ReportInformation motherReportInfo, string drilldownMenuId, AsDictionary formularFields, bool isNT, string nhan_in, string filter4Tilte, string formatedColList, object datasource, params object[] arg)
		: base(motherReportInfo, drilldownMenuId, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, RuntimeHelpers.GetObjectValue(datasource), arg)
	{
		InitializeComponent();
	}

	public frmGlRptF5Bctc04()
	{
		InitializeComponent();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		((Control)base.dgvBC).Select();
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)keycode != 116 || (int)modifierKeys != 0)
		{
			base.CancelDrilldown = true;
			return null;
		}
		DataRowView dataRowView;
		try
		{
			dataRowView = ((DataView)((DataGridView)base.dgvBC).DataSource)[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			base.CancelDrilldown = true;
			ArrayList result = null;
			ProjectData.ClearProjectError();
			return result;
		}
		if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["cach_tinh"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_no"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_co"]), isNum: false), (object)"", false))
		{
			base.CancelDrilldown = true;
			return null;
		}
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["cach_tinh"]), isNum: false), (object)"", false))
		{
			sDrilldownMenuId = drilldownInfo.drilldown_menuid;
			string rowFilter = "ma_so in('" + dataRowView["cach_tinh"].ToString().Trim().Replace(" ", "")
				.Replace("+", "','")
				.Replace("-", "','") + "')";
			DataView dataView = new DataView((DataTable)get_MyDGVSource(isSet2Print: true), rowFilter, "", DataViewRowState.CurrentRows);
			filterCondition4title = dataRowView["ma_so"].ToString() + " = " + dataRowView["cach_tinh"].ToString();
			datasource = dataView;
			if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(datasource)))
			{
				base.CancelDrilldown = true;
			}
			return null;
		}
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_no"]), isNum: false), (object)"", false) || Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_co"]), isNum: false), (object)"", false))
		{
			sDrilldownMenuId = drilldownInfo.drilldown_menuid1;
			DateTime dateTime = (DateTime)base.MyFomularFields["ngay_ct2"];
			DateTime dateTime2 = (DateTime)base.MyFomularFields["ngay_ct1"];
			ArrayList arrayList = new ArrayList();
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(dataRowView["tk_no"].ToString());
			arrayList.Add(dataRowView["tk_co"].ToString());
			arrayList.Add(null);
			arrayList.Add(dateTime2);
			arrayList.Add(dateTime);
			filterCondition4title = dataRowView["chi_tieu"].ToString();
			return arrayList;
		}
		base.CancelDrilldown = true;
		return null;
	}
}
