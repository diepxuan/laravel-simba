using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework.Docking;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmLeftMenuModul : DockContent
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("UcModuleMenu1")]
	private ucModuleMenu _UcModuleMenu1;

	internal virtual ucModuleMenu UcModuleMenu1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcModuleMenu1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcModuleMenu1 = value;
		}
	}

	[DebuggerNonUserCode]
	public frmLeftMenuModul()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		UcModuleMenu1 = new ucModuleMenu();
		((Control)this).SuspendLayout();
		((Control)UcModuleMenu1).Dock = (DockStyle)5;
		((Control)UcModuleMenu1).ForeColor = Color.FromArgb(228, 191, 93);
		ucModuleMenu ucModuleMenu2 = UcModuleMenu1;
		Point location = new Point(0, 0);
		((Control)ucModuleMenu2).Location = location;
		ucModuleMenu ucModuleMenu3 = UcModuleMenu1;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Control)ucModuleMenu3).Margin = margin;
		((Control)UcModuleMenu1).Name = "UcModuleMenu1";
		ucModuleMenu ucModuleMenu4 = UcModuleMenu1;
		Size size = new Size(243, 366);
		((Control)ucModuleMenu4).Size = size;
		((Control)UcModuleMenu1).TabIndex = 1;
		AllowEndUserDocking = false;
		AutoHidePortion = 0.1;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)0;
		((Form)this).AutoScroll = true;
		((Control)this).CausesValidation = false;
		size = new Size(243, 366);
		((Form)this).ClientSize = size;
		CloseButton = false;
		CloseButtonVisible = false;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)UcModuleMenu1);
		DockAreas = DockAreas.DockLeft;
		((Control)this).DoubleBuffered = true;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmLeftMenuModul";
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).SizeGripStyle = (SizeGripStyle)2;
		((Form)this).StartPosition = (FormStartPosition)0;
		TabText = "PHÂN HỆ";
		((Control)this).ResumeLayout(false);
	}
}
