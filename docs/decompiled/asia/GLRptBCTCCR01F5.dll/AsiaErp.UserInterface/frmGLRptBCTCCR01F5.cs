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
public class frmGLRptBCTCCR01F5 : frmDrilldownReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
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
		components = new Container();
	}

	public frmGLRptBCTCCR01F5(ReportInformation motherReportInfo, string drilldownMenuId, AsDictionary formularFields, bool isNT, string nhan_in, string filter4Tilte, string formatedColList, object datasource, params object[] arg)
		: base(motherReportInfo, drilldownMenuId, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, RuntimeHelpers.GetObjectValue(datasource), arg)
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	public frmGLRptBCTCCR01F5()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		((Control)base.dgvBC).Select();
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		DataRowView dataRowView = (DataRowView)NewLateBinding.LateGet(get_MyDGVSource(isSet2Print: true), (Type)null, "DefaultView", new object[1] { ((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index }, (string[])null, (Type[])null, (bool[])null);
		if ((int)keycode != 116 || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_du"]), isNum: false), (object)"", false) ? true : false))
		{
			base.CancelDrilldown = true;
			return null;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(base.Parameters4DrillDown["tk"]));
		arrayList.Add(dataRowView["tk_du"].ToString());
		arrayList.Add(RuntimeHelpers.GetObjectValue(base.Parameters4DrillDown["ngay_ct1"]));
		arrayList.Add(RuntimeHelpers.GetObjectValue(base.Parameters4DrillDown["ngay_ct2"]));
		arrayList.Add(RuntimeHelpers.GetObjectValue(base.Parameters4DrillDown["ma_nt"]));
		filterCondition4title = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(base.Parameters4DrillDown["tk"], (object)"/"), (object)dataRowView["tk_du"].ToString()));
		return arrayList;
	}
}
