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
public class frmSODMTS : frmDMView
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

	public frmSODMTS(string menuid)
		: base(menuid)
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
		Button obj = cmdChgCode;
		Point location = new Point(541, 397);
		((Control)obj).Location = location;
		((Control)cmdChgCode).Visible = false;
		TextBox obj2 = txtValue;
		location = new Point(141, 399);
		((Control)obj2).Location = location;
		Button obj3 = cmdDel;
		location = new Point(541, 397);
		((Control)obj3).Location = location;
		ComboBox obj4 = cboFilter;
		location = new Point(58, 399);
		((Control)obj4).Location = location;
		Button obj5 = cmdEdit;
		location = new Point(471, 397);
		((Control)obj5).Location = location;
		Button obj6 = cmdSearch;
		location = new Point(235, 398);
		((Control)obj6).Location = location;
		Button obj7 = cmdAdd;
		location = new Point(401, 397);
		((Control)obj7).Location = location;
		Label obj8 = lblTen;
		location = new Point(7, 401);
		((Control)obj8).Location = location;
		Button obj9 = cmdPrint;
		location = new Point(611, 397);
		((Control)obj9).Location = location;
		Button obj10 = cmdClose;
		location = new Point(680, 397);
		((Control)obj10).Location = location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		Size clientSize = new Size(754, 429);
		((Form)this).ClientSize = clientSize;
		((Control)this).Name = "frmSODMTS";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
