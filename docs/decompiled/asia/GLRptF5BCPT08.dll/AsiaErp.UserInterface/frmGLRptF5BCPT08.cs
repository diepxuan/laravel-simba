using System;
using System.Collections;
using System.Collections.Generic;
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
public class frmGLRptF5BCPT08 : frmDrilldownReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

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
		components = new Container();
	}

	public frmGLRptF5BCPT08(ReportInformation motherReportInfo, string drilldownMenuId, AsDictionary formularFields, bool isNT, string nhan_in, string filter4Tilte, string formatedColList, object datasource, params object[] arg)
		: base(motherReportInfo, drilldownMenuId, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, RuntimeHelpers.GetObjectValue(datasource), arg)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	public frmGLRptF5BCPT08()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		((Control)base.dgvBC).Select();
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Invalid comparison between Unknown and I4
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Invalid comparison between Unknown and I4
		if ((int)keycode != 116)
		{
			base.CancelDrilldown = true;
			return null;
		}
		DataRowView dataRowView = ((DataView)((DataGridView)base.dgvBC).DataSource)[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
		ArrayList arrayList = new ArrayList();
		if ((int)modifierKeys == 0)
		{
			if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["cach_tinh"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk"]), isNum: false), (object)"", false)) ? true : false)
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
			if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk"]), isNum: false), (object)"", false))
			{
				sDrilldownMenuId = drilldownInfo.drilldown_menuid1;
				arrayList.Add(CompanyInformations.CompanyID);
				arrayList.Add(dataRowView["tk"].ToString());
				arrayList.Add(RuntimeHelpers.GetObjectValue(base.Parameters4DrillDown["ngay_ct1"]));
				arrayList.Add(RuntimeHelpers.GetObjectValue(base.Parameters4DrillDown["ngay_ct2"]));
				arrayList.Add(RuntimeHelpers.GetObjectValue(base.Parameters4DrillDown["ma_nt"]));
				filterCondition4title = dataRowView["tk"].ToString();
				if (base.Parameters4DrillDown.Contains("tk"))
				{
					base.Parameters4DrillDown["tk"] = RuntimeHelpers.GetObjectValue(dataRowView["tk"]);
				}
				else
				{
					base.Parameters4DrillDown.Add("tk", RuntimeHelpers.GetObjectValue(dataRowView["tk"]));
				}
				return arrayList;
			}
		}
		else if ((int)modifierKeys == 131072)
		{
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk"]), isNum: false), (object)"", false))
			{
				base.CancelDrilldown = true;
				return null;
			}
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(RuntimeHelpers.GetObjectValue(base.Parameters4DrillDown["tk"]));
			arrayList.Add(dataRowView["tk_du"].ToString());
			arrayList.Add(RuntimeHelpers.GetObjectValue(base.Parameters4DrillDown["ngay_ct1"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(base.Parameters4DrillDown["ngay_ct2"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(base.Parameters4DrillDown["ma_nt"]));
			filterCondition4title = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(base.Parameters4DrillDown["tk"], (object)"/"), (object)dataRowView["tk_du"].ToString()));
		}
		else
		{
			if ((int)modifierKeys != 65536)
			{
				base.CancelDrilldown = true;
				return null;
			}
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk"]), isNum: false), (object)"", false) || (Operators.ConditionalCompareObjectNotEqual(dataRowView["cong_no"], (object)"1", false) ? true : false))
			{
				base.CancelDrilldown = true;
				return null;
			}
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk"]), isNum: false), (object)"", false) || (Operators.ConditionalCompareObjectNotEqual(dataRowView["cong_no"], (object)"1", false) ? true : false))
			{
				base.CancelDrilldown = true;
				return null;
			}
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(dataRowView["tk"].ToString());
			arrayList.Add(RuntimeHelpers.GetObjectValue(base.Parameters4DrillDown["ngay_ct1"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(base.Parameters4DrillDown["ngay_ct2"]));
			filterCondition4title = dataRowView["tk"].ToString();
		}
		return arrayList;
	}
}
