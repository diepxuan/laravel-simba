using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSORptF5BCPT06 : frmDrilldownReport
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

	public frmSORptF5BCPT06(ReportInformation motherReportInfo, string drilldown_menuid, AsDictionary formularFields, bool isNT, string nhan_in, string filter4Title, string formatedColList, object datasource, params object[] arg)
		: base(motherReportInfo, drilldown_menuid, formularFields, isNT, nhan_in, filter4Title, formatedColList, RuntimeHelpers.GetObjectValue(datasource), arg)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	public frmSORptF5BCPT06()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		components = new Container();
	}
}
