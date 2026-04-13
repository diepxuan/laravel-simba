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
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLRptF5BCTC02CT : frmDrilldownReport
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

	public frmGLRptF5BCTC02CT(ReportInformation motherReportInfo, string drilldownMenuId, AsDictionary formularFields, bool isNT, string nhan_in, string filter4Tilte, string formatedColList, object datasource, params object[] arg)
		: base(motherReportInfo, drilldownMenuId, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, RuntimeHelpers.GetObjectValue(datasource), arg)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	public frmGLRptF5BCTC02CT()
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)modifierKeys != 0 || (int)keycode != 116)
		{
			base.CancelDrilldown = true;
			return null;
		}
		DataRowView dataRowView = ((DataView)((DataGridView)base.dgvBC).DataSource)[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_du"]), isNum: false), (object)"", false))
		{
			ArrayList arrayList = new ArrayList();
			DateTime dateTime = (DateTime)base.MyFomularFields["ngay_ct2"];
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add("");
			arrayList.Add(dataRowView["tk_du"].ToString());
			DateTime dateTime2 = new DateTime(dateTime.Year, 1, 1);
			arrayList.Add(dateTime2);
			arrayList.Add(dateTime);
			arrayList.Add("");
			filterCondition4title = dataRowView["tk_du"].ToString();
			return arrayList;
		}
		base.CancelDrilldown = true;
		return null;
	}
}
