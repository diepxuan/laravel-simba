using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSODMHTTT : frmDMComplexView
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

	public frmSODMHTTT(string MenuId)
		: base(MenuId)
	{
		__ENCAddToList(this);
		InitializeComponent();
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
		((Control)cmdChgCode).Visible = false;
		((Control)txtValue).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdDel).Location;
		((Control)cmdEdit).Location = ((Control)cmdChgCode).Location;
		((Control)cmdDel).Location = ((Control)cmdPrint).Location;
		((Control)cboFilter).Visible = false;
		((Control)cmdSearch).Visible = false;
		((Control)lblTen).Visible = false;
		((Control)cmdPrint).Visible = false;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void GetData(params object[] @params)
	{
		base.GetData(CompanyInformations.CompanyID, "", MyMenuInfo.moduleid);
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		SOConfiguration sOConfiguration = AsiaErp.Framework.Environment.GetSOConfiguration();
		base.SourceTable.Columns["Moduleid"].DefaultValue = base.MyMenuInfo.moduleid;
		base.SourceTable.Columns["Tk"].DefaultValue = sOConfiguration.tk_pt;
		base.SourceTable.Columns["tk_thue_gtgt_ban"].DefaultValue = sOConfiguration.tk_thue_gtgt;
		base.SourceTable.Columns["tk_thue_gtgt_mua"].DefaultValue = sOConfiguration.tk_thue_gtgt_tl;
		base.SourceTable.Columns["tk_thue_xk"].DefaultValue = sOConfiguration.tk_thue_xk;
		base.SourceTable.Columns["tk_thue_gtgt_xk"].DefaultValue = sOConfiguration.tk_thue_gtgt_xk;
		base.SourceTable.Columns["tk_thue_ttdb"].DefaultValue = sOConfiguration.tk_thue_ttdb;
		base.SourceTable.Columns["tk_ck"].DefaultValue = sOConfiguration.tk_ck;
	}
}
