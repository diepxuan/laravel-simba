using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmPODMHTTT : frmDMComplexView
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

	public frmPODMHTTT(string menuID)
		: base(menuID)
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		((Control)this).SuspendLayout();
		Button obj = cmdChgCode;
		Point location = new Point(315, 397);
		((Control)obj).Location = location;
		((Control)cmdChgCode).Visible = false;
		TextBox obj2 = txtValue;
		location = new Point(124, 399);
		((Control)obj2).Location = location;
		Button obj3 = cmdDel;
		location = new Point(529, 397);
		((Control)obj3).Location = location;
		ComboBox obj4 = cboFilter;
		location = new Point(41, 398);
		((Control)obj4).Location = location;
		Button obj5 = cmdEdit;
		location = new Point(459, 397);
		((Control)obj5).Location = location;
		Button obj6 = cmdSearch;
		location = new Point(218, 397);
		((Control)obj6).Location = location;
		Button obj7 = cmdAdd;
		location = new Point(389, 397);
		((Control)obj7).Location = location;
		Label obj8 = lblTen;
		location = new Point(8, 401);
		((Control)obj8).Location = location;
		Button obj9 = cmdPrint;
		location = new Point(599, 397);
		((Control)obj9).Location = location;
		Button obj10 = cmdClose;
		location = new Point(668, 397);
		((Control)obj10).Location = location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(742, 429);
		((Form)this).ClientSize = clientSize;
		((Control)this).Name = "frmPODMHTTT";
		((Form)this).Text = "frmPODMHTTT";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void GetData(params object[] @params)
	{
		base.GetData(CompanyInformations.CompanyID, "", base.MyMenuInfo.par1);
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		POConfiguration pOConfiguration = AsiaErp.Framework.Environment.GetPOConfiguration();
		base.SourceTable.Columns["Tk"].DefaultValue = pOConfiguration.tk_pt;
		base.SourceTable.Columns["tk_thue_gtgt_mua"].DefaultValue = pOConfiguration.tk_thue_gtgt;
		base.SourceTable.Columns["tk_thue_nk"].DefaultValue = pOConfiguration.tk_thue_nk;
		base.SourceTable.Columns["tk_gtgt_nk_no"].DefaultValue = pOConfiguration.tk_gtgt_nk_no;
		base.SourceTable.Columns["tk_gtgt_nk_co"].DefaultValue = pOConfiguration.tk_gtgt_nk_co;
		base.SourceTable.Columns["tk_thue_ttdb"].DefaultValue = pOConfiguration.tk_thue_ttdb;
		base.SourceTable.Columns["tk_ck"].DefaultValue = pOConfiguration.tk_ck;
	}
}
