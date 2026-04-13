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
public class frmGLMauBS01 : frmDMView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private string ma_mau;

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

	public frmGLMauBS01(string menuid, string code_name, string Mau)
		: base(menuid, code_name)
	{
		__ENCAddToList(this);
		InitializeComponent();
		ma_mau = Mau;
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
	}

	protected override void GetData(params object[] @params)
	{
		base.GetData(CompanyInformations.CompanyID, ma_mau);
	}

	protected override void InitOtherBeforeLoadData()
	{
		base.InitOtherBeforeLoadData();
		((Control)base.txtValue).Visible = false;
		((Control)base.lblTen).Visible = false;
		((Control)base.cmdSearch).Visible = false;
		((Control)base.cboFilter).Visible = false;
		((Control)base.cmdChgCode).Visible = false;
		((Control)base.cmdAdd).Location = ((Control)cmdEdit).Location;
		((Control)base.cmdEdit).Location = ((Control)cmdDel).Location;
		((Control)base.cmdDel).Location = ((Control)cmdChgCode).Location;
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		base.SourceTable.Columns["mau"].DefaultValue = ma_mau;
		base.SourceTable.Columns["ma_so"].DefaultValue = "";
	}
}
