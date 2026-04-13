using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmSIDMCT : frmDMView
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

	public frmSIDMCT(string MenuID)
		: base(MenuID)
	{
		__ENCAddToList(this);
		InitializeComponent();
		AsDataGridView asDataGridView = dgvDM;
		Size size = checked(new Size(((Control)cmdClose).Right - 10, ((Control)cmdClose).Top - 15));
		((Control)asDataGridView).Size = size;
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
		Button obj = cmdChgCode;
		Point location = new Point(592, 441);
		((Control)obj).Location = location;
		((Control)cmdChgCode).Visible = false;
		TextBox obj2 = txtValue;
		location = new Point(142, 408);
		((Control)obj2).Location = location;
		Button obj3 = cmdDel;
		location = new Point(522, 443);
		((Control)obj3).Location = location;
		((Control)cmdDel).Visible = false;
		ComboBox obj4 = cboFilter;
		location = new Point(59, 408);
		((Control)obj4).Location = location;
		Button obj5 = cmdEdit;
		location = new Point(592, 407);
		((Control)obj5).Location = location;
		Button obj6 = cmdSearch;
		location = new Point(236, 407);
		((Control)obj6).Location = location;
		Button obj7 = cmdAdd;
		location = new Point(382, 441);
		((Control)obj7).Location = location;
		((Control)cmdAdd).Visible = false;
		Label obj8 = lblTen;
		location = new Point(8, 410);
		((Control)obj8).Location = location;
		Button obj9 = cmdPrint;
		location = new Point(662, 407);
		((Control)obj9).Location = location;
		Button obj10 = cmdClose;
		location = new Point(731, 407);
		((Control)obj10).Location = location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		Size clientSize = new Size(805, 440);
		((Form)this).ClientSize = clientSize;
		((Control)this).Name = "frmSIDMCT";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void GetData(params object[] @params)
	{
		base.GetData(CompanyInformations.CompanyID, "", MyMenuInfo.moduleid);
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
		}
		return base.ProcessCmdKey(ref msg, keyData);
	}
}
