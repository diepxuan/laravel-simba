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
public class frmGLCDTKFilter : frmOBFilter
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblMonth")]
	private Label _lblMonth;

	[AccessedThroughProperty("txtYear")]
	private AsTextNumeric _txtYear;

	[AccessedThroughProperty("txtMonth")]
	private AsTextNumeric _txtMonth;

	[AccessedThroughProperty("lblYear")]
	private Label _lblYear;

	[AccessedThroughProperty("ep")]
	private ErrorProvider _ep;

	internal virtual Label lblMonth
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMonth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMonth = value;
		}
	}

	internal virtual AsTextNumeric txtYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtYear = value;
		}
	}

	internal virtual AsTextNumeric txtMonth
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMonth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMonth = value;
		}
	}

	internal virtual Label lblYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblYear = value;
		}
	}

	internal virtual ErrorProvider ep
	{
		[DebuggerNonUserCode]
		get
		{
			return _ep;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ep = value;
		}
	}

	[DebuggerNonUserCode]
	public frmGLCDTKFilter()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

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
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		components = new Container();
		lblMonth = new Label();
		txtMonth = new AsTextNumeric();
		txtYear = new AsTextNumeric();
		lblYear = new Label();
		ep = new ErrorProvider(components);
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)ep).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		Point location = new Point(93, 80);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdOk;
		location = new Point(12, 80);
		((Control)obj2).Location = location;
		((Control)cmdOk).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtMonth);
		((Control)gbLine).Controls.Add((Control)(object)lblMonth);
		((Control)gbLine).Controls.Add((Control)(object)txtYear);
		((Control)gbLine).Controls.Add((Control)(object)lblYear);
		GroupBox obj3 = gbLine;
		Size size = new Size(352, 67);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMonth, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMonth, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		lblMonth.AutoSize = true;
		Label obj4 = lblMonth;
		location = new Point(15, 30);
		((Control)obj4).Location = location;
		((Control)lblMonth).Name = "lblMonth";
		Label obj5 = lblMonth;
		size = new Size(122, 13);
		((Control)obj5).Size = size;
		((Control)lblMonth).TabIndex = 3;
		lblMonth.Text = "Số dư đầu kỳ của tháng";
		txtMonth.DecimalSymbol = ".";
		txtMonth.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtMonth;
		location = new Point(143, 26);
		((Control)asTextNumeric).Location = location;
		txtMonth.Mask = "##";
		((Control)txtMonth).Name = "txtMonth";
		AsTextNumeric asTextNumeric2 = txtMonth;
		size = new Size(62, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtMonth).TabIndex = 0;
		((TextBox)txtMonth).Text = "1";
		((TextBox)txtMonth).TextAlign = (HorizontalAlignment)1;
		txtMonth.Value = 1;
		txtYear.DecimalSymbol = ".";
		((Control)txtYear).Enabled = false;
		txtYear.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtYear;
		location = new Point(244, 26);
		((Control)asTextNumeric3).Location = location;
		txtYear.Mask = "####";
		((Control)txtYear).Name = "txtYear";
		((TextBoxBase)txtYear).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtYear;
		size = new Size(66, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtYear).TabIndex = 2;
		((Control)txtYear).TabStop = false;
		((TextBox)txtYear).Text = "0";
		((TextBox)txtYear).TextAlign = (HorizontalAlignment)1;
		txtYear.Value = 0;
		lblYear.AutoSize = true;
		Label obj6 = lblYear;
		location = new Point(211, 30);
		((Control)obj6).Location = location;
		((Control)lblYear).Name = "lblYear";
		Label obj7 = lblYear;
		size = new Size(27, 13);
		((Control)obj7).Size = size;
		((Control)lblYear).TabIndex = 1;
		lblYear.Text = "năm";
		ep.BlinkStyle = (ErrorBlinkStyle)1;
		ep.ContainerControl = (ContainerControl)(object)this;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(376, 112);
		((Form)this).ClientSize = size;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmGLCDTKFilter";
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).Text = "Số dư đầu kỳ các tài khoản";
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)ep).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ValidData()
	{
		if ((Conversions.ToInteger(txtMonth.Value) < 1) | (Conversions.ToInteger(txtMonth.Value) > 12))
		{
			ep.SetError((Control)(object)txtMonth, Helper.GetMessContent(50034));
			return false;
		}
		ep.Clear();
		return base.ValidData();
	}
}
