using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaERP.DataAccess;
using AsiaErp.Framework;
using AsiaErp.UserInterface;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmGLSdDkTk : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("gbLine")]
	private GroupBox _gbLine;

	[AccessedThroughProperty("lblDu_co_dn_nt")]
	private Label _lblDu_co_dn_nt;

	[AccessedThroughProperty("lblDu_co_dn")]
	private Label _lblDu_co_dn;

	[AccessedThroughProperty("lblDu_co_dk_nt")]
	private Label _lblDu_co_dk_nt;

	[AccessedThroughProperty("lblDu_no_dn_nt")]
	private Label _lblDu_no_dn_nt;

	[AccessedThroughProperty("lblDu_co_dk")]
	private Label _lblDu_co_dk;

	[AccessedThroughProperty("lblDu_no_dn")]
	private Label _lblDu_no_dn;

	[AccessedThroughProperty("lblDu_no_dk_nt")]
	private Label _lblDu_no_dk_nt;

	[AccessedThroughProperty("lblDu_no_dk")]
	private Label _lblDu_no_dk;

	[AccessedThroughProperty("txtDu_no_dk")]
	private AsTextNumeric _txtDu_no_dk;

	[AccessedThroughProperty("txtDu_co_dk_nt")]
	private AsTextNumeric _txtDu_co_dk_nt;

	[AccessedThroughProperty("txtDu_co_dk")]
	private AsTextNumeric _txtDu_co_dk;

	[AccessedThroughProperty("txtDu_no_dk_nt")]
	private AsTextNumeric _txtDu_no_dk_nt;

	[AccessedThroughProperty("txtDu_co_dn_nt")]
	private AsTextNumeric _txtDu_co_dn_nt;

	[AccessedThroughProperty("txtDu_co_dn")]
	private AsTextNumeric _txtDu_co_dn;

	[AccessedThroughProperty("txtDu_no_dn_nt")]
	private AsTextNumeric _txtDu_no_dn_nt;

	[AccessedThroughProperty("txtDu_no_dn")]
	private AsTextNumeric _txtDu_no_dn;

	internal virtual GroupBox gbLine
	{
		[DebuggerNonUserCode]
		get
		{
			return _gbLine;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_gbLine = value;
		}
	}

	internal virtual Label lblDu_co_dn_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_co_dn_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_co_dn_nt = value;
		}
	}

	internal virtual Label lblDu_co_dn
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_co_dn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_co_dn = value;
		}
	}

	internal virtual Label lblDu_co_dk_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_co_dk_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_co_dk_nt = value;
		}
	}

	internal virtual Label lblDu_no_dn_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_no_dn_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_no_dn_nt = value;
		}
	}

	internal virtual Label lblDu_co_dk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_co_dk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_co_dk = value;
		}
	}

	internal virtual Label lblDu_no_dn
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_no_dn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_no_dn = value;
		}
	}

	internal virtual Label lblDu_no_dk_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_no_dk_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_no_dk_nt = value;
		}
	}

	internal virtual Label lblDu_no_dk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_no_dk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_no_dk = value;
		}
	}

	internal virtual AsTextNumeric txtDu_no_dk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_no_dk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDu_no_dk = value;
		}
	}

	internal virtual AsTextNumeric txtDu_co_dk_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_co_dk_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDu_co_dk_nt = value;
		}
	}

	internal virtual AsTextNumeric txtDu_co_dk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_co_dk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDu_co_dk = value;
		}
	}

	internal virtual AsTextNumeric txtDu_no_dk_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_no_dk_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDu_no_dk_nt = value;
		}
	}

	internal virtual AsTextNumeric txtDu_co_dn_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_co_dn_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDu_co_dn_nt = value;
		}
	}

	internal virtual AsTextNumeric txtDu_co_dn
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_co_dn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDu_co_dn = value;
		}
	}

	internal virtual AsTextNumeric txtDu_no_dn_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_no_dn_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDu_no_dn_nt = value;
		}
	}

	internal virtual AsTextNumeric txtDu_no_dn
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_no_dn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDu_no_dn = value;
		}
	}

	[DebuggerNonUserCode]
	public frmGLSdDkTk()
	{
		((Form)this).Load += frmGLSdDkTk_Load;
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		gbLine = new GroupBox();
		txtDu_co_dn_nt = new AsTextNumeric();
		txtDu_no_dn = new AsTextNumeric();
		txtDu_co_dn = new AsTextNumeric();
		txtDu_no_dn_nt = new AsTextNumeric();
		txtDu_co_dk_nt = new AsTextNumeric();
		txtDu_co_dk = new AsTextNumeric();
		txtDu_no_dk_nt = new AsTextNumeric();
		txtDu_no_dk = new AsTextNumeric();
		lblDu_co_dn_nt = new Label();
		lblDu_co_dn = new Label();
		lblDu_co_dk_nt = new Label();
		lblDu_no_dn_nt = new Label();
		lblDu_co_dk = new Label();
		lblDu_no_dn = new Label();
		lblDu_no_dk_nt = new Label();
		lblDu_no_dk = new Label();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)gbLine).Controls.Add((Control)(object)txtDu_co_dn_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_no_dn);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_co_dn);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_no_dn_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_co_dk_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_co_dk);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_no_dk_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_no_dk);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_co_dn_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_co_dn);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_co_dk_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_no_dn_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_co_dk);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_no_dn);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_no_dk_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblDu_no_dk);
		GroupBox obj = gbLine;
		Point location = new Point(12, 7);
		((Control)obj).Location = location;
		((Control)gbLine).Name = "gbLine";
		GroupBox obj2 = gbLine;
		Size size = new Size(463, 133);
		((Control)obj2).Size = size;
		((Control)gbLine).TabIndex = 0;
		gbLine.TabStop = false;
		txtDu_co_dn_nt.DecimalSymbol = ".";
		txtDu_co_dn_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtDu_co_dn_nt;
		location = new Point(335, 94);
		((Control)asTextNumeric).Location = location;
		txtDu_co_dn_nt.Mask = "### ### ### ###.##";
		((Control)txtDu_co_dn_nt).Name = "txtDu_co_dn_nt";
		((TextBoxBase)txtDu_co_dn_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtDu_co_dn_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtDu_co_dn_nt).TabIndex = 7;
		((Control)txtDu_co_dn_nt).Tag = "FA";
		((TextBox)txtDu_co_dn_nt).Text = "0.00";
		((TextBox)txtDu_co_dn_nt).TextAlign = (HorizontalAlignment)1;
		txtDu_co_dn_nt.Value = 0;
		txtDu_no_dn.DecimalSymbol = ".";
		txtDu_no_dn.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtDu_no_dn;
		location = new Point(335, 16);
		((Control)asTextNumeric3).Location = location;
		txtDu_no_dn.Mask = "### ### ### ###.##";
		((Control)txtDu_no_dn).Name = "txtDu_no_dn";
		((TextBoxBase)txtDu_no_dn).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtDu_no_dn;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtDu_no_dn).TabIndex = 4;
		((Control)txtDu_no_dn).Tag = "OA";
		((TextBox)txtDu_no_dn).Text = "0.00";
		((TextBox)txtDu_no_dn).TextAlign = (HorizontalAlignment)1;
		txtDu_no_dn.Value = 0;
		txtDu_co_dn.DecimalSymbol = ".";
		txtDu_co_dn.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtDu_co_dn;
		location = new Point(335, 68);
		((Control)asTextNumeric5).Location = location;
		txtDu_co_dn.Mask = "### ### ### ###.##";
		((Control)txtDu_co_dn).Name = "txtDu_co_dn";
		((TextBoxBase)txtDu_co_dn).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtDu_co_dn;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtDu_co_dn).TabIndex = 6;
		((Control)txtDu_co_dn).Tag = "OA";
		((TextBox)txtDu_co_dn).Text = "0.00";
		((TextBox)txtDu_co_dn).TextAlign = (HorizontalAlignment)1;
		txtDu_co_dn.Value = 0;
		txtDu_no_dn_nt.DecimalSymbol = ".";
		txtDu_no_dn_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtDu_no_dn_nt;
		location = new Point(335, 42);
		((Control)asTextNumeric7).Location = location;
		txtDu_no_dn_nt.Mask = "### ### ### ###.##";
		((Control)txtDu_no_dn_nt).Name = "txtDu_no_dn_nt";
		((TextBoxBase)txtDu_no_dn_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtDu_no_dn_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtDu_no_dn_nt).TabIndex = 5;
		((Control)txtDu_no_dn_nt).Tag = "FA";
		((TextBox)txtDu_no_dn_nt).Text = "0.00";
		((TextBox)txtDu_no_dn_nt).TextAlign = (HorizontalAlignment)1;
		txtDu_no_dn_nt.Value = 0;
		txtDu_co_dk_nt.DecimalSymbol = ".";
		txtDu_co_dk_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric9 = txtDu_co_dk_nt;
		location = new Point(115, 92);
		((Control)asTextNumeric9).Location = location;
		txtDu_co_dk_nt.Mask = "### ### ### ###.##";
		((Control)txtDu_co_dk_nt).Name = "txtDu_co_dk_nt";
		((TextBoxBase)txtDu_co_dk_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtDu_co_dk_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric10).Size = size;
		((Control)txtDu_co_dk_nt).TabIndex = 3;
		((Control)txtDu_co_dk_nt).Tag = "FA";
		((TextBox)txtDu_co_dk_nt).Text = "0.00";
		((TextBox)txtDu_co_dk_nt).TextAlign = (HorizontalAlignment)1;
		txtDu_co_dk_nt.Value = 0;
		txtDu_co_dk.DecimalSymbol = ".";
		txtDu_co_dk.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric11 = txtDu_co_dk;
		location = new Point(115, 67);
		((Control)asTextNumeric11).Location = location;
		txtDu_co_dk.Mask = "### ### ### ###.##";
		((Control)txtDu_co_dk).Name = "txtDu_co_dk";
		((TextBoxBase)txtDu_co_dk).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtDu_co_dk;
		size = new Size(100, 20);
		((Control)asTextNumeric12).Size = size;
		((Control)txtDu_co_dk).TabIndex = 2;
		((Control)txtDu_co_dk).Tag = "OA";
		((TextBox)txtDu_co_dk).Text = "0.00";
		((TextBox)txtDu_co_dk).TextAlign = (HorizontalAlignment)1;
		txtDu_co_dk.Value = 0;
		txtDu_no_dk_nt.DecimalSymbol = ".";
		txtDu_no_dk_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric13 = txtDu_no_dk_nt;
		location = new Point(115, 42);
		((Control)asTextNumeric13).Location = location;
		txtDu_no_dk_nt.Mask = "### ### ### ###.##";
		((Control)txtDu_no_dk_nt).Name = "txtDu_no_dk_nt";
		((TextBoxBase)txtDu_no_dk_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtDu_no_dk_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric14).Size = size;
		((Control)txtDu_no_dk_nt).TabIndex = 1;
		((Control)txtDu_no_dk_nt).Tag = "FA";
		((TextBox)txtDu_no_dk_nt).Text = "0.00";
		((TextBox)txtDu_no_dk_nt).TextAlign = (HorizontalAlignment)1;
		txtDu_no_dk_nt.Value = 0;
		txtDu_no_dk.DecimalSymbol = ".";
		txtDu_no_dk.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric15 = txtDu_no_dk;
		location = new Point(115, 17);
		((Control)asTextNumeric15).Location = location;
		txtDu_no_dk.Mask = "### ### ### ###.##";
		((Control)txtDu_no_dk).Name = "txtDu_no_dk";
		((TextBoxBase)txtDu_no_dk).ReadOnly = true;
		AsTextNumeric asTextNumeric16 = txtDu_no_dk;
		size = new Size(100, 20);
		((Control)asTextNumeric16).Size = size;
		((Control)txtDu_no_dk).TabIndex = 0;
		((Control)txtDu_no_dk).Tag = "OA";
		((TextBox)txtDu_no_dk).Text = "0.00";
		((TextBox)txtDu_no_dk).TextAlign = (HorizontalAlignment)1;
		txtDu_no_dk.Value = 0;
		lblDu_co_dn_nt.AutoSize = true;
		Label obj3 = lblDu_co_dn_nt;
		location = new Point(229, 98);
		((Control)obj3).Location = location;
		((Control)lblDu_co_dn_nt).Name = "lblDu_co_dn_nt";
		Label obj4 = lblDu_co_dn_nt;
		size = new Size(99, 13);
		((Control)obj4).Size = size;
		((Control)lblDu_co_dn_nt).TabIndex = 0;
		lblDu_co_dn_nt.Text = "Dư có đầu năm NT";
		lblDu_co_dn.AutoSize = true;
		Label obj5 = lblDu_co_dn;
		location = new Point(229, 72);
		((Control)obj5).Location = location;
		((Control)lblDu_co_dn).Name = "lblDu_co_dn";
		Label obj6 = lblDu_co_dn;
		size = new Size(81, 13);
		((Control)obj6).Size = size;
		((Control)lblDu_co_dn).TabIndex = 0;
		lblDu_co_dn.Text = "Dư có đầu năm";
		lblDu_co_dk_nt.AutoSize = true;
		Label obj7 = lblDu_co_dk_nt;
		location = new Point(17, 96);
		((Control)obj7).Location = location;
		((Control)lblDu_co_dk_nt).Name = "lblDu_co_dk_nt";
		Label obj8 = lblDu_co_dk_nt;
		size = new Size(90, 13);
		((Control)obj8).Size = size;
		((Control)lblDu_co_dk_nt).TabIndex = 0;
		lblDu_co_dk_nt.Text = "Dư có đầu kỳ NT";
		lblDu_no_dn_nt.AutoSize = true;
		Label obj9 = lblDu_no_dn_nt;
		location = new Point(229, 46);
		((Control)obj9).Location = location;
		((Control)lblDu_no_dn_nt).Name = "lblDu_no_dn_nt";
		Label obj10 = lblDu_no_dn_nt;
		size = new Size(99, 13);
		((Control)obj10).Size = size;
		((Control)lblDu_no_dn_nt).TabIndex = 0;
		lblDu_no_dn_nt.Text = "Dư nợ đầu năm NT";
		lblDu_co_dk.AutoSize = true;
		Label obj11 = lblDu_co_dk;
		location = new Point(17, 71);
		((Control)obj11).Location = location;
		((Control)lblDu_co_dk).Name = "lblDu_co_dk";
		Label obj12 = lblDu_co_dk;
		size = new Size(72, 13);
		((Control)obj12).Size = size;
		((Control)lblDu_co_dk).TabIndex = 0;
		lblDu_co_dk.Text = "Dư có đầu kỳ";
		lblDu_no_dn.AutoSize = true;
		Label obj13 = lblDu_no_dn;
		location = new Point(229, 20);
		((Control)obj13).Location = location;
		((Control)lblDu_no_dn).Name = "lblDu_no_dn";
		Label obj14 = lblDu_no_dn;
		size = new Size(81, 13);
		((Control)obj14).Size = size;
		((Control)lblDu_no_dn).TabIndex = 0;
		lblDu_no_dn.Text = "Dư nợ đầu năm";
		lblDu_no_dk_nt.AutoSize = true;
		Label obj15 = lblDu_no_dk_nt;
		location = new Point(17, 46);
		((Control)obj15).Location = location;
		((Control)lblDu_no_dk_nt).Name = "lblDu_no_dk_nt";
		Label obj16 = lblDu_no_dk_nt;
		size = new Size(90, 13);
		((Control)obj16).Size = size;
		((Control)lblDu_no_dk_nt).TabIndex = 0;
		lblDu_no_dk_nt.Text = "Dư nợ đầu kỳ NT";
		lblDu_no_dk.AutoSize = true;
		Label obj17 = lblDu_no_dk;
		location = new Point(17, 20);
		((Control)obj17).Location = location;
		((Control)lblDu_no_dk).Name = "lblDu_no_dk";
		Label obj18 = lblDu_no_dk;
		size = new Size(72, 13);
		((Control)obj18).Size = size;
		((Control)lblDu_no_dk).TabIndex = 0;
		lblDu_no_dk.Text = "Dư nợ đầu kỳ";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(489, 155);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)gbLine);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmGLSdDkTk";
		((Form)this).Text = "Tổng số dư TK";
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmGLSdDkTk_Load(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		frmGLCDTKFilterTk frmGLCDTKFilterTk = new frmGLCDTKFilterTk();
		frmGLCDTKFilterTk.txtYear.Value = SystemInformations.FinancialYear;
		if ((int)((Form)frmGLCDTKFilterTk).ShowDialog() == 1)
		{
			ICalcSumTKDAO calcSumTKDAO = (ICalcSumTKDAO)DAOFactory.CreateDAOInstance("CalcSumTkDAO", "GLCDTK");
			DataTable dataTable = new DataTable();
			dataTable = calcSumTKDAO.CalcSumCdTk(CompanyInformations.CompanyID, ((TextBox)frmGLCDTKFilterTk.txtMa_tk).Text, Conversions.ToInteger(frmGLCDTKFilterTk.txtYear.Value), "");
			foreach (DataRow row in dataTable.Rows)
			{
				txtDu_co_dk.Value = RuntimeHelpers.GetObjectValue(row["du_co"]);
				txtDu_co_dk_nt.Value = RuntimeHelpers.GetObjectValue(row["du_co_nt"]);
				txtDu_co_dn.Value = RuntimeHelpers.GetObjectValue(row["du_co00"]);
				txtDu_co_dn_nt.Value = RuntimeHelpers.GetObjectValue(row["du_co_nt00"]);
				txtDu_no_dk.Value = RuntimeHelpers.GetObjectValue(row["du_no"]);
				txtDu_no_dk_nt.Value = RuntimeHelpers.GetObjectValue(row["du_no_nt"]);
				txtDu_no_dn.Value = RuntimeHelpers.GetObjectValue(row["du_no00"]);
				txtDu_no_dn_nt.Value = RuntimeHelpers.GetObjectValue(row["du_no_nt00"]);
				if (Operators.CompareString(((TextBox)frmGLCDTKFilterTk.txtMa_tk).Text, "", false) != 0)
				{
					((Form)this).Text = ((Form)this).Text + " " + ((TextBox)frmGLCDTKFilterTk.txtMa_tk).Text.Trim();
					if (Operators.CompareString(frmGLCDTKFilterTk.lblTen_tk.Text.Trim(), "", false) != 0)
					{
						((Form)this).Text = ((Form)this).Text + " (" + frmGLCDTKFilterTk.lblTen_tk.Text + ")";
					}
				}
			}
			((Component)(object)frmGLCDTKFilterTk).Dispose();
		}
		else
		{
			((Component)(object)frmGLCDTKFilterTk).Dispose();
			((Form)this).Close();
		}
		MaskTextBoxAll(((Control)gbLine).Controls);
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
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void MaskTextBoxAll(ControlCollection ctl)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (Control item in ctl)
		{
			Control val = item;
			if (val is AsTextNumeric)
			{
				AsTextNumeric asTextNumeric = (AsTextNumeric)(object)val;
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCPrice_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"QT", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format;
				}
			}
		}
	}
}
