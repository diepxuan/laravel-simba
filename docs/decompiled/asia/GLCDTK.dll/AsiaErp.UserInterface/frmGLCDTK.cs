using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaERP.UserInterface;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLCDTK : frmOBView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblDuCoNT")]
	private Label _lblDuCoNT;

	[AccessedThroughProperty("txtDuNoNtDn")]
	private AsTextNumeric _txtDuNoNtDn;

	[AccessedThroughProperty("lblDuNoNT")]
	private Label _lblDuNoNT;

	[AccessedThroughProperty("txtDuCoDn")]
	private AsTextNumeric _txtDuCoDn;

	[AccessedThroughProperty("lblDuCo")]
	private Label _lblDuCo;

	[AccessedThroughProperty("lblDuNo")]
	private Label _lblDuNo;

	[AccessedThroughProperty("lblDauKy")]
	private Label _lblDauKy;

	[AccessedThroughProperty("txtDuCoNTDk")]
	private AsTextNumeric _txtDuCoNTDk;

	[AccessedThroughProperty("txtDuCoNtDn")]
	private AsTextNumeric _txtDuCoNtDn;

	[AccessedThroughProperty("txtDuNoDn")]
	private AsTextNumeric _txtDuNoDn;

	[AccessedThroughProperty("txtDuNoDk")]
	private AsTextNumeric _txtDuNoDk;

	[AccessedThroughProperty("txtDuNoNTDk")]
	private AsTextNumeric _txtDuNoNTDk;

	[AccessedThroughProperty("txtDuCoDk")]
	private AsTextNumeric _txtDuCoDk;

	[AccessedThroughProperty("lblDauNam")]
	private Label _lblDauNam;

	[AccessedThroughProperty("gbLine")]
	private GroupBox _gbLine;

	[AccessedThroughProperty("cmdSum_Tk")]
	private Button _cmdSum_Tk;

	public int g_intMonth;

	private bool check;

	internal virtual Label lblDuCoNT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDuCoNT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDuCoNT = value;
		}
	}

	internal virtual AsTextNumeric txtDuNoNtDn
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDuNoNtDn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDuNoNtDn = value;
		}
	}

	internal virtual Label lblDuNoNT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDuNoNT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDuNoNT = value;
		}
	}

	internal virtual AsTextNumeric txtDuCoDn
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDuCoDn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDuCoDn = value;
		}
	}

	internal virtual Label lblDuCo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDuCo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDuCo = value;
		}
	}

	internal virtual Label lblDuNo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDuNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDuNo = value;
		}
	}

	internal virtual Label lblDauKy
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDauKy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDauKy = value;
		}
	}

	internal virtual AsTextNumeric txtDuCoNTDk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDuCoNTDk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDuCoNTDk = value;
		}
	}

	internal virtual AsTextNumeric txtDuCoNtDn
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDuCoNtDn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDuCoNtDn = value;
		}
	}

	internal virtual AsTextNumeric txtDuNoDn
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDuNoDn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDuNoDn = value;
		}
	}

	internal virtual AsTextNumeric txtDuNoDk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDuNoDk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDuNoDk = value;
		}
	}

	internal virtual AsTextNumeric txtDuNoNTDk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDuNoNTDk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDuNoNTDk = value;
		}
	}

	internal virtual AsTextNumeric txtDuCoDk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDuCoDk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDuCoDk = value;
		}
	}

	internal virtual Label lblDauNam
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDauNam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDauNam = value;
		}
	}

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

	internal virtual Button cmdSum_Tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSum_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdSum_Tk_Click;
			if (_cmdSum_Tk != null)
			{
				((Control)_cmdSum_Tk).Click -= eventHandler;
			}
			_cmdSum_Tk = value;
			if (_cmdSum_Tk != null)
			{
				((Control)_cmdSum_Tk).Click += eventHandler;
			}
		}
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

	public frmGLCDTK(string MenuId)
		: base(MenuId)
	{
		((Form)this).Shown += frmGLCDTK_Shown;
		__ENCAddToList(this);
		InitializeComponent();
		AsDataGridView asDataGridView = dgvDM;
		Size size = checked(new Size(((Control)gbLine).Right - 10, ((Control)gbLine).Top - 15));
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		lblDuCoNT = new Label();
		txtDuNoNtDn = new AsTextNumeric();
		lblDuNoNT = new Label();
		txtDuCoDn = new AsTextNumeric();
		lblDuCo = new Label();
		lblDuNo = new Label();
		lblDauKy = new Label();
		txtDuCoNTDk = new AsTextNumeric();
		txtDuCoNtDn = new AsTextNumeric();
		txtDuNoDn = new AsTextNumeric();
		txtDuNoDk = new AsTextNumeric();
		txtDuNoNTDk = new AsTextNumeric();
		txtDuCoDk = new AsTextNumeric();
		lblDauNam = new Label();
		gbLine = new GroupBox();
		cmdSum_Tk = new Button();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdChgCode;
		Point location = new Point(637, 510);
		((Control)obj).Location = location;
		Button obj2 = cmdChgCode;
		Size size = new Size(64, 17);
		((Control)obj2).Size = size;
		((Control)cmdChgCode).Visible = false;
		((Control)txtValue).Anchor = (AnchorStyles)0;
		((Control)txtValue).Enabled = false;
		TextBox obj3 = txtValue;
		location = new Point(190, 480);
		((Control)obj3).Location = location;
		((Control)txtValue).Visible = false;
		Button obj4 = cmdDel;
		location = new Point(391, 504);
		((Control)obj4).Location = location;
		((Control)cmdDel).Visible = false;
		((Control)cboFilter).Anchor = (AnchorStyles)0;
		((Control)cboFilter).Enabled = false;
		ComboBox obj5 = cboFilter;
		location = new Point(107, 480);
		((Control)obj5).Location = location;
		((Control)cboFilter).Visible = false;
		Button obj6 = cmdEdit;
		location = new Point(637, 478);
		((Control)obj6).Location = location;
		((Control)cmdSearch).Anchor = (AnchorStyles)0;
		((Control)cmdSearch).Enabled = false;
		Button obj7 = cmdSearch;
		location = new Point(284, 479);
		((Control)obj7).Location = location;
		((Control)cmdSearch).Visible = false;
		cmdAdd.DialogResult = (DialogResult)2;
		Button obj8 = cmdAdd;
		location = new Point(461, 504);
		((Control)obj8).Location = location;
		((Control)cmdAdd).Visible = false;
		((Control)lblTen).Anchor = (AnchorStyles)0;
		((Control)lblTen).Enabled = false;
		Label obj9 = lblTen;
		location = new Point(56, 482);
		((Control)obj9).Location = location;
		((Control)lblTen).Visible = false;
		Button obj10 = cmdPrint;
		location = new Point(709, 477);
		((Control)obj10).Location = location;
		Button obj11 = cmdClose;
		location = new Point(778, 477);
		((Control)obj11).Location = location;
		((Control)lblDuCoNT).Anchor = (AnchorStyles)6;
		lblDuCoNT.AutoSize = true;
		Label obj12 = lblDuCoNT;
		location = new Point(540, 10);
		((Control)obj12).Location = location;
		((Control)lblDuCoNT).Name = "lblDuCoNT";
		Label obj13 = lblDuCoNT;
		size = new Size(54, 13);
		((Control)obj13).Size = size;
		((Control)lblDuCoNT).TabIndex = 50;
		lblDuCoNT.Text = "Dư có NT";
		((Control)txtDuNoNtDn).Anchor = (AnchorStyles)6;
		txtDuNoNtDn.DecimalSymbol = ".";
		txtDuNoNtDn.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtDuNoNtDn;
		location = new Point(391, 53);
		((Control)asTextNumeric).Location = location;
		txtDuNoNtDn.Mask = "### ### ### ###.##";
		((Control)txtDuNoNtDn).Name = "txtDuNoNtDn";
		((TextBoxBase)txtDuNoNtDn).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtDuNoNtDn;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtDuNoNtDn).TabIndex = 44;
		((Control)txtDuNoNtDn).Tag = "FA";
		((TextBox)txtDuNoNtDn).Text = "0.00";
		((TextBox)txtDuNoNtDn).TextAlign = (HorizontalAlignment)1;
		txtDuNoNtDn.Value = 0;
		((Control)lblDuNoNT).Anchor = (AnchorStyles)6;
		lblDuNoNT.AutoSize = true;
		Label obj14 = lblDuNoNT;
		location = new Point(434, 10);
		((Control)obj14).Location = location;
		((Control)lblDuNoNT).Name = "lblDuNoNT";
		Label obj15 = lblDuNoNT;
		size = new Size(54, 13);
		((Control)obj15).Size = size;
		((Control)lblDuNoNT).TabIndex = 49;
		lblDuNoNT.Text = "Dư nợ NT";
		((Control)txtDuCoDn).Anchor = (AnchorStyles)6;
		txtDuCoDn.DecimalSymbol = ".";
		txtDuCoDn.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtDuCoDn;
		location = new Point(285, 53);
		((Control)asTextNumeric3).Location = location;
		txtDuCoDn.Mask = "### ### ### ###.##";
		((Control)txtDuCoDn).Name = "txtDuCoDn";
		((TextBoxBase)txtDuCoDn).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtDuCoDn;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtDuCoDn).TabIndex = 46;
		((Control)txtDuCoDn).Tag = "OA";
		((TextBox)txtDuCoDn).Text = "0.00";
		((TextBox)txtDuCoDn).TextAlign = (HorizontalAlignment)1;
		txtDuCoDn.Value = 0;
		((Control)lblDuCo).Anchor = (AnchorStyles)6;
		lblDuCo.AutoSize = true;
		Label obj16 = lblDuCo;
		location = new Point(346, 10);
		((Control)obj16).Location = location;
		((Control)lblDuCo).Name = "lblDuCo";
		Label obj17 = lblDuCo;
		size = new Size(36, 13);
		((Control)obj17).Size = size;
		((Control)lblDuCo).TabIndex = 51;
		lblDuCo.Text = "Dư có";
		((Control)lblDuNo).Anchor = (AnchorStyles)6;
		lblDuNo.AutoSize = true;
		Label obj18 = lblDuNo;
		location = new Point(240, 10);
		((Control)obj18).Location = location;
		((Control)lblDuNo).Name = "lblDuNo";
		Label obj19 = lblDuNo;
		size = new Size(36, 13);
		((Control)obj19).Size = size;
		((Control)lblDuNo).TabIndex = 53;
		lblDuNo.Text = "Dư nợ";
		((Control)lblDauKy).Anchor = (AnchorStyles)6;
		lblDauKy.AutoSize = true;
		Label obj20 = lblDauKy;
		location = new Point(46, 32);
		((Control)obj20).Location = location;
		((Control)lblDauKy).Name = "lblDauKy";
		Label obj21 = lblDauKy;
		size = new Size(41, 13);
		((Control)obj21).Size = size;
		((Control)lblDauKy).TabIndex = 52;
		lblDauKy.Text = "Đầu kỳ";
		((Control)txtDuCoNTDk).Anchor = (AnchorStyles)6;
		txtDuCoNTDk.DecimalSymbol = ".";
		txtDuCoNTDk.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtDuCoNTDk;
		location = new Point(497, 28);
		((Control)asTextNumeric5).Location = location;
		txtDuCoNTDk.Mask = "### ### ### ###.##";
		((Control)txtDuCoNTDk).Name = "txtDuCoNTDk";
		((TextBoxBase)txtDuCoNTDk).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtDuCoNTDk;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtDuCoNTDk).TabIndex = 42;
		((Control)txtDuCoNTDk).Tag = "FA";
		((TextBox)txtDuCoNTDk).Text = "0.00";
		((TextBox)txtDuCoNTDk).TextAlign = (HorizontalAlignment)1;
		txtDuCoNTDk.Value = 0;
		((Control)txtDuCoNtDn).Anchor = (AnchorStyles)6;
		txtDuCoNtDn.DecimalSymbol = ".";
		txtDuCoNtDn.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtDuCoNtDn;
		location = new Point(497, 53);
		((Control)asTextNumeric7).Location = location;
		txtDuCoNtDn.Mask = "### ### ### ###.##";
		((Control)txtDuCoNtDn).Name = "txtDuCoNtDn";
		((TextBoxBase)txtDuCoNtDn).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtDuCoNtDn;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtDuCoNtDn).TabIndex = 41;
		((Control)txtDuCoNtDn).Tag = "FA";
		((TextBox)txtDuCoNtDn).Text = "0.00";
		((TextBox)txtDuCoNtDn).TextAlign = (HorizontalAlignment)1;
		txtDuCoNtDn.Value = 0;
		((Control)txtDuNoDn).Anchor = (AnchorStyles)6;
		txtDuNoDn.DecimalSymbol = ".";
		txtDuNoDn.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric9 = txtDuNoDn;
		location = new Point(179, 53);
		((Control)asTextNumeric9).Location = location;
		txtDuNoDn.Mask = "### ### ### ###.##";
		((Control)txtDuNoDn).Name = "txtDuNoDn";
		((TextBoxBase)txtDuNoDn).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtDuNoDn;
		size = new Size(100, 20);
		((Control)asTextNumeric10).Size = size;
		((Control)txtDuNoDn).TabIndex = 43;
		((Control)txtDuNoDn).Tag = "OA";
		((TextBox)txtDuNoDn).Text = "0.00";
		((TextBox)txtDuNoDn).TextAlign = (HorizontalAlignment)1;
		txtDuNoDn.Value = 0;
		((Control)txtDuNoDk).Anchor = (AnchorStyles)6;
		txtDuNoDk.DecimalSymbol = ".";
		txtDuNoDk.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric11 = txtDuNoDk;
		location = new Point(179, 28);
		((Control)asTextNumeric11).Location = location;
		txtDuNoDk.Mask = "### ### ### ###.##";
		((Control)txtDuNoDk).Name = "txtDuNoDk";
		((TextBoxBase)txtDuNoDk).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtDuNoDk;
		size = new Size(100, 20);
		((Control)asTextNumeric12).Size = size;
		((Control)txtDuNoDk).TabIndex = 40;
		((Control)txtDuNoDk).Tag = "OA";
		((TextBox)txtDuNoDk).Text = "0.00";
		((TextBox)txtDuNoDk).TextAlign = (HorizontalAlignment)1;
		txtDuNoDk.Value = 0;
		((Control)txtDuNoNTDk).Anchor = (AnchorStyles)6;
		txtDuNoNTDk.DecimalSymbol = ".";
		txtDuNoNTDk.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric13 = txtDuNoNTDk;
		location = new Point(391, 28);
		((Control)asTextNumeric13).Location = location;
		txtDuNoNTDk.Mask = "### ### ### ###.##";
		((Control)txtDuNoNTDk).Name = "txtDuNoNTDk";
		((TextBoxBase)txtDuNoNTDk).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtDuNoNTDk;
		size = new Size(100, 20);
		((Control)asTextNumeric14).Size = size;
		((Control)txtDuNoNTDk).TabIndex = 45;
		((Control)txtDuNoNTDk).Tag = "FA";
		((TextBox)txtDuNoNTDk).Text = "0.00";
		((TextBox)txtDuNoNTDk).TextAlign = (HorizontalAlignment)1;
		txtDuNoNTDk.Value = 0;
		((Control)txtDuCoDk).Anchor = (AnchorStyles)6;
		txtDuCoDk.DecimalSymbol = ".";
		txtDuCoDk.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric15 = txtDuCoDk;
		location = new Point(285, 28);
		((Control)asTextNumeric15).Location = location;
		txtDuCoDk.Mask = "### ### ### ###.##";
		((Control)txtDuCoDk).Name = "txtDuCoDk";
		((TextBoxBase)txtDuCoDk).ReadOnly = true;
		AsTextNumeric asTextNumeric16 = txtDuCoDk;
		size = new Size(100, 20);
		((Control)asTextNumeric16).Size = size;
		((Control)txtDuCoDk).TabIndex = 47;
		((Control)txtDuCoDk).Tag = "OA";
		((TextBox)txtDuCoDk).Text = "0.00";
		((TextBox)txtDuCoDk).TextAlign = (HorizontalAlignment)1;
		txtDuCoDk.Value = 0;
		((Control)lblDauNam).Anchor = (AnchorStyles)6;
		lblDauNam.AutoSize = true;
		Label obj22 = lblDauNam;
		location = new Point(46, 57);
		((Control)obj22).Location = location;
		((Control)lblDauNam).Name = "lblDauNam";
		Label obj23 = lblDauNam;
		size = new Size(50, 13);
		((Control)obj23).Size = size;
		((Control)lblDauNam).TabIndex = 48;
		lblDauNam.Text = "Đầu năm";
		((Control)gbLine).Anchor = (AnchorStyles)14;
		((Control)gbLine).Controls.Add((Control)(object)lblDauNam);
		((Control)gbLine).Controls.Add((Control)(object)lblDuCoNT);
		((Control)gbLine).Controls.Add((Control)(object)txtDuCoDk);
		((Control)gbLine).Controls.Add((Control)(object)txtDuNoNtDn);
		((Control)gbLine).Controls.Add((Control)(object)lblDuNoNT);
		((Control)gbLine).Controls.Add((Control)(object)txtDuCoDn);
		((Control)gbLine).Controls.Add((Control)(object)txtDuNoNTDk);
		((Control)gbLine).Controls.Add((Control)(object)txtDuNoDn);
		((Control)gbLine).Controls.Add((Control)(object)txtDuNoDk);
		((Control)gbLine).Controls.Add((Control)(object)lblDuCo);
		((Control)gbLine).Controls.Add((Control)(object)lblDauKy);
		((Control)gbLine).Controls.Add((Control)(object)txtDuCoNtDn);
		((Control)gbLine).Controls.Add((Control)(object)lblDuNo);
		((Control)gbLine).Controls.Add((Control)(object)txtDuCoNTDk);
		GroupBox obj24 = gbLine;
		location = new Point(9, 391);
		((Control)obj24).Location = location;
		((Control)gbLine).Name = "gbLine";
		GroupBox obj25 = gbLine;
		size = new Size(834, 80);
		((Control)obj25).Size = size;
		((Control)gbLine).TabIndex = 54;
		gbLine.TabStop = false;
		((Control)cmdSum_Tk).Anchor = (AnchorStyles)10;
		Button obj26 = cmdSum_Tk;
		location = new Point(552, 478);
		((Control)obj26).Location = location;
		((Control)cmdSum_Tk).Name = "cmdSum_Tk";
		Button obj27 = cmdSum_Tk;
		size = new Size(75, 23);
		((Control)obj27).Size = size;
		((Control)cmdSum_Tk).TabIndex = 55;
		((ButtonBase)cmdSum_Tk).Text = "&Tính tổng";
		((ButtonBase)cmdSum_Tk).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdClose;
		size = new Size(852, 512);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)gbLine);
		((Control)this).Controls.Add((Control)(object)cmdSum_Tk);
		((Control)this).Name = "frmGLCDTK";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSum_Tk, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdChgCode, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbLine, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtValue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cboFilter, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdClose, 0);
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		TinhTong();
		MaskTextBoxAll(((Control)gbLine).Controls);
	}

	protected override bool Login()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		frmGLCDTKFilter frmGLCDTKFilter = new frmGLCDTKFilter();
		frmGLCDTKFilter.txtYear.Value = SystemInformations.FinancialYear;
		((Form)frmGLCDTKFilter).Text = MyMenuInfo.bar.Trim();
		DialogResult val = ((Form)frmGLCDTKFilter).ShowDialog((IWin32Window)(object)this);
		if ((int)val == 1)
		{
			g_intMonth = Conversions.ToInteger(frmGLCDTKFilter.txtMonth.Value);
			AsiaErp.Framework.Environment.set_PublicVariables("g_intMonth4GLCDTKEdit", (object)g_intMonth);
			check = true;
			if ((Operators.ConditionalCompareObjectLessEqual(frmGLCDTKFilter.txtMonth.Value, (object)AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks.Month, false) && SystemInformations.FinancialYear <= AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks.Year) ? true : false)
			{
				CMessageBox.Show(50136);
				check = false;
			}
		}
		else
		{
			check = false;
		}
		return true;
	}

	protected override void GetData(params object[] @params)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(SystemInformations.FinancialYear);
		base.SourceTable = base.MyController.GetData(arrayList.ToArray());
	}

	protected override void FormatGridView()
	{
		base.FormatGridView();
		if (g_intMonth == 1)
		{
			GetDGVColumnByDataPropertyName("du_co00").Visible = false;
			GetDGVColumnByDataPropertyName("du_no00").Visible = false;
			GetDGVColumnByDataPropertyName("du_co_nt00").Visible = false;
			GetDGVColumnByDataPropertyName("du_no_nt00").Visible = false;
			((Control)lblDauNam).Visible = false;
			((Control)txtDuCoDn).Visible = false;
			((Control)txtDuCoNtDn).Visible = false;
			((Control)txtDuNoDn).Visible = false;
			((Control)txtDuNoNtDn).Visible = false;
		}
	}

	protected override void Edit()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.ConditionalCompareObjectEqual(SourceTable.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["tk_cn"], (object)true, false) && g_intMonth == 1) ? true : false)
		{
			CMessageBox.Show(50121);
			return;
		}
		AsiaErp.Framework.Environment.set_PublicVariables("g_tkcn4GLCDTKEdit", RuntimeHelpers.GetObjectValue(SourceTable.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["tk_cn"]));
		base.Edit();
		TinhTong();
	}

	private void TinhTong()
	{
		txtDuCoDk.Value = RuntimeHelpers.GetObjectValue(base.SourceTable.Compute("sum(du_co)", ""));
		txtDuCoDn.Value = RuntimeHelpers.GetObjectValue(base.SourceTable.Compute("sum(du_co00)", ""));
		txtDuCoNTDk.Value = RuntimeHelpers.GetObjectValue(base.SourceTable.Compute("sum(du_co_nt)", ""));
		txtDuCoNtDn.Value = RuntimeHelpers.GetObjectValue(base.SourceTable.Compute("sum(du_co_nt00)", ""));
		txtDuNoDk.Value = RuntimeHelpers.GetObjectValue(base.SourceTable.Compute("sum(du_no)", ""));
		txtDuNoDn.Value = RuntimeHelpers.GetObjectValue(base.SourceTable.Compute("sum(du_no00)", ""));
		txtDuNoNTDk.Value = RuntimeHelpers.GetObjectValue(base.SourceTable.Compute("sum(du_no_nt)", ""));
		txtDuNoNtDn.Value = RuntimeHelpers.GetObjectValue(base.SourceTable.Compute("sum(du_no_nt00)", ""));
	}

	private DataGridViewColumn GetDGVColumnByDataPropertyName(string propertyname)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		DataGridViewColumn val = null;
		foreach (DataGridViewColumn item in (BaseCollection)((DataGridView)dgvDM).Columns)
		{
			val = item;
			if (Operators.CompareString(val.DataPropertyName, propertyname, false) == 0)
			{
				return val;
			}
		}
		return val;
	}

	private void cmdSum_Tk_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		frmGLSdDkTk frmGLSdDkTk = new frmGLSdDkTk();
		((Form)frmGLSdDkTk).ShowDialog();
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

	private void frmGLCDTK_Shown(object sender, EventArgs e)
	{
		if (!check)
		{
			((Form)this).Close();
		}
	}
}
