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
public class frmCaVchCA4Find : frmVoucherFind
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("lblTen_Tk_Co")]
	private Label _lblTen_Tk_Co;

	[AccessedThroughProperty("txtTk_Co")]
	private AsTextBox _txtTk_Co;

	[AccessedThroughProperty("lblTk_Co")]
	private Label _lblTk_Co;

	[AccessedThroughProperty("lblNguoi_Gd")]
	private Label _lblNguoi_Gd;

	[AccessedThroughProperty("txtNguoi_Gd")]
	private TextBox _txtNguoi_Gd;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTk_no")]
	private Label _lblTk_no;

	[AccessedThroughProperty("lblTen_Spct")]
	private Label _lblTen_Spct;

	[AccessedThroughProperty("txtMa_Spct")]
	private AsTextBox _txtMa_Spct;

	[AccessedThroughProperty("lblMa_Spct")]
	private Label _lblMa_Spct;

	[AccessedThroughProperty("lblTen_Ku")]
	private Label _lblTen_Ku;

	[AccessedThroughProperty("txtMa_Ku")]
	private AsTextBox _txtMa_Ku;

	[AccessedThroughProperty("lblMa_Ku")]
	private Label _lblMa_Ku;

	[AccessedThroughProperty("lblTen_Hd")]
	private Label _lblTen_Hd;

	[AccessedThroughProperty("txtMa_Hd")]
	private AsTextBox _txtMa_Hd;

	[AccessedThroughProperty("lblMa_Hd")]
	private Label _lblMa_Hd;

	[AccessedThroughProperty("lblTen_Phi")]
	private Label _lblTen_Phi;

	[AccessedThroughProperty("txtMa_Phi")]
	private AsTextBox _txtMa_Phi;

	[AccessedThroughProperty("lblMa_Phi")]
	private Label _lblMa_Phi;

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

	[AccessedThroughProperty("txtMa_Bp")]
	private AsTextBox _txtMa_Bp;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("lblDien_giai")]
	private Label _lblDien_giai;

	internal virtual Label lblTen_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Kh = value;
		}
	}

	internal virtual AsTextBox txtMa_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Kh = value;
		}
	}

	internal virtual Label lblMa_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Kh = value;
		}
	}

	internal virtual Label lblTen_Tk_Co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_Co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_Co = value;
		}
	}

	internal virtual AsTextBox txtTk_Co
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Co = value;
		}
	}

	internal virtual Label lblTk_Co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Co = value;
		}
	}

	internal virtual Label lblNguoi_Gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguoi_Gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguoi_Gd = value;
		}
	}

	internal virtual TextBox txtNguoi_Gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNguoi_Gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNguoi_Gd = value;
		}
	}

	internal virtual Label lblTen_Tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk = value;
		}
	}

	internal virtual AsTextBox txtTk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk = value;
		}
	}

	internal virtual Label lblTk_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_no = value;
		}
	}

	internal virtual Label lblTen_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Spct = value;
		}
	}

	internal virtual AsTextBox txtMa_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Spct = value;
		}
	}

	internal virtual Label lblMa_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Spct = value;
		}
	}

	internal virtual Label lblTen_Ku
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Ku = value;
		}
	}

	internal virtual AsTextBox txtMa_Ku
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Ku = value;
		}
	}

	internal virtual Label lblMa_Ku
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Ku = value;
		}
	}

	internal virtual Label lblTen_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Hd = value;
		}
	}

	internal virtual AsTextBox txtMa_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Hd = value;
		}
	}

	internal virtual Label lblMa_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Hd = value;
		}
	}

	internal virtual Label lblTen_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Phi = value;
		}
	}

	internal virtual AsTextBox txtMa_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Phi = value;
		}
	}

	internal virtual Label lblMa_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Phi = value;
		}
	}

	internal virtual Label lblTen_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Bp = value;
		}
	}

	internal virtual AsTextBox txtMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Bp = value;
		}
	}

	internal virtual Label lblMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Bp = value;
		}
	}

	internal virtual TextBox txtDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDien_giai = value;
		}
	}

	internal virtual Label lblDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDien_giai = value;
		}
	}

	[DebuggerNonUserCode]
	public frmCaVchCA4Find()
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblTen_Tk_Co = new Label();
		txtTk_Co = new AsTextBox();
		lblTk_Co = new Label();
		lblNguoi_Gd = new Label();
		txtNguoi_Gd = new TextBox();
		lblTen_Tk = new Label();
		txtTk = new AsTextBox();
		lblTk_no = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_Bp = new Label();
		lblTen_Phi = new Label();
		txtMa_Phi = new AsTextBox();
		lblMa_Phi = new Label();
		lblTen_Hd = new Label();
		txtMa_Hd = new AsTextBox();
		lblMa_Hd = new Label();
		lblTen_Ku = new Label();
		txtMa_Ku = new AsTextBox();
		lblMa_Ku = new Label();
		lblTen_Spct = new Label();
		txtMa_Spct = new AsTextBox();
		lblMa_Spct = new Label();
		txtDien_giai = new TextBox();
		lblDien_giai = new Label();
		((Control)gbPh).SuspendLayout();
		((Control)gbCt).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 376);
		((Control)obj).Location = location;
		Button obj2 = cmdOk;
		location = new Point(12, 376);
		((Control)obj2).Location = location;
		((Control)gbPh).Controls.Add((Control)(object)lblNguoi_Gd);
		((Control)gbPh).Controls.Add((Control)(object)txtNguoi_Gd);
		((Control)gbPh).Controls.Add((Control)(object)lblTen_Tk_Co);
		((Control)gbPh).Controls.Add((Control)(object)txtTk_Co);
		((Control)gbPh).Controls.Add((Control)(object)lblTk_Co);
		((Control)gbPh).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbPh).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbPh).Controls.Add((Control)(object)lblMa_Kh);
		GroupBox obj3 = gbPh;
		Size size = new Size(641, 180);
		((Control)obj3).Size = size;
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblNgay_Ct1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtNgay_Ct1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblNgay_Ct2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtNgay_Ct2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblSo_Ct1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblSo_Ct2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtSo_Ct1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtSo_Ct2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblSo_tien1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtSo_tien1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblSo_tien2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtSo_tien2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblTk_Co, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtTk_Co, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblTen_Tk_Co, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtNguoi_Gd, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblNguoi_Gd, 0);
		((Control)gbCt).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbCt).Controls.Add((Control)(object)lblDien_giai);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Spct);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Spct);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_Spct);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Hd);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Hd);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_Hd);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Phi);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Phi);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_Phi);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Bp);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Bp);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_Bp);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Tk);
		((Control)gbCt).Controls.Add((Control)(object)txtTk);
		((Control)gbCt).Controls.Add((Control)(object)lblTk_no);
		GroupBox obj4 = gbCt;
		location = new Point(12, 189);
		((Control)obj4).Location = location;
		GroupBox obj5 = gbCt;
		size = new Size(641, 181);
		((Control)obj5).Size = size;
		TextBox obj6 = txtSo_Ct1;
		location = new Point(148, 45);
		((Control)obj6).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct2;
		location = new Point(328, 20);
		((Control)asMaskedTextBox).Location = location;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_Ct1;
		location = new Point(148, 19);
		((Control)asMaskedTextBox2).Location = location;
		TextBox obj7 = txtSo_Ct2;
		location = new Point(328, 45);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct2;
		location = new Point(259, 49);
		((Control)obj8).Location = location;
		Label obj9 = lblNgay_Ct2;
		location = new Point(259, 22);
		((Control)obj9).Location = location;
		Label obj10 = lblSo_tien2;
		location = new Point(261, 74);
		((Control)obj10).Location = location;
		txtSo_tien1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtSo_tien1;
		location = new Point(148, 71);
		((Control)asTextNumeric).Location = location;
		txtSo_tien1.SpecialType = Commons.NumericSpecialType.Other;
		txtSo_tien1.Type = Commons.NumericType.ORTHER_;
		txtSo_tien2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric2 = txtSo_tien2;
		location = new Point(328, 71);
		((Control)asTextNumeric2).Location = location;
		txtSo_tien2.SpecialType = Commons.NumericSpecialType.Other;
		txtSo_tien2.Type = Commons.NumericType.ORTHER_;
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj11 = lblTen_Kh;
		location = new Point(236, 126);
		((Control)obj11).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj12 = lblTen_Kh;
		size = new Size(366, 13);
		((Control)obj12).Size = size;
		((Control)lblTen_Kh).TabIndex = 137;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = false;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(148, 123);
		((Control)asTextBox).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		AsTextBox asTextBox2 = txtMa_Kh;
		size = new Size(82, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Kh).TabIndex = 7;
		txtMa_Kh.UseAutoCompleteSource = true;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj13 = lblMa_Kh;
		location = new Point(6, 127);
		((Control)obj13).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj14 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj14).Size = size;
		((Control)lblMa_Kh).TabIndex = 136;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblTen_Tk_Co.ImeMode = (ImeMode)0;
		Label obj15 = lblTen_Tk_Co;
		location = new Point(236, 101);
		((Control)obj15).Location = location;
		((Control)lblTen_Tk_Co).Name = "lblTen_Tk_Co";
		Label obj16 = lblTen_Tk_Co;
		size = new Size(366, 13);
		((Control)obj16).Size = size;
		((Control)lblTen_Tk_Co).TabIndex = 220;
		lblTen_Tk_Co.TextAlign = (ContentAlignment)16;
		((TextBox)txtTk_Co).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk_Co.AutoLookup = true;
		txtTk_Co.AutoValid = false;
		((TextBoxBase)txtTk_Co).BackColor = SystemColors.Info;
		((TextBox)txtTk_Co).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk_Co;
		location = new Point(148, 97);
		((Control)asTextBox3).Location = location;
		txtTk_Co.LookupCodeName = "TK";
		((Control)txtTk_Co).Name = "txtTk_Co";
		txtTk_Co.NameControl = lblTen_Tk_Co;
		AsTextBox asTextBox4 = txtTk_Co;
		size = new Size(82, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk_Co).TabIndex = 6;
		txtTk_Co.UseAutoCompleteSource = true;
		lblTk_Co.ImeMode = (ImeMode)0;
		Label obj17 = lblTk_Co;
		location = new Point(6, 100);
		((Control)obj17).Location = location;
		((Control)lblTk_Co).Name = "lblTk_Co";
		Label obj18 = lblTk_Co;
		size = new Size(98, 14);
		((Control)obj18).Size = size;
		((Control)lblTk_Co).TabIndex = 219;
		lblTk_Co.Text = "Tài khoản có";
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj19 = lblNguoi_Gd;
		location = new Point(6, 152);
		((Control)obj19).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj20 = lblNguoi_Gd;
		size = new Size(98, 14);
		((Control)obj20).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 222;
		lblNguoi_Gd.Text = "Người giao dịch";
		TextBox obj21 = txtNguoi_Gd;
		location = new Point(148, 149);
		((Control)obj21).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj22 = txtNguoi_Gd;
		size = new Size(178, 20);
		((Control)obj22).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 8;
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj23 = lblTen_Tk;
		location = new Point(236, 23);
		((Control)obj23).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj24 = lblTen_Tk;
		size = new Size(366, 13);
		((Control)obj24).Size = size;
		((Control)lblTen_Tk).TabIndex = 218;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = false;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTk;
		location = new Point(148, 20);
		((Control)asTextBox5).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk;
		AsTextBox asTextBox6 = txtTk;
		size = new Size(82, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTk).TabIndex = 0;
		txtTk.UseAutoCompleteSource = true;
		lblTk_no.AutoSize = true;
		lblTk_no.ImeMode = (ImeMode)0;
		Label obj25 = lblTk_no;
		location = new Point(6, 23);
		((Control)obj25).Location = location;
		((Control)lblTk_no).Name = "lblTk_no";
		Label obj26 = lblTk_no;
		size = new Size(36, 13);
		((Control)obj26).Size = size;
		((Control)lblTk_no).TabIndex = 217;
		lblTk_no.Text = "TK nợ";
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj27 = lblTen_Bp;
		location = new Point(236, 49);
		((Control)obj27).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj28 = lblTen_Bp;
		size = new Size(366, 13);
		((Control)obj28).Size = size;
		((Control)lblTen_Bp).TabIndex = 221;
		lblTen_Bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_Bp;
		location = new Point(148, 46);
		((Control)asTextBox7).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox8 = txtMa_Bp;
		size = new Size(82, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_Bp).TabIndex = 1;
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_Bp.AutoSize = true;
		lblMa_Bp.ImeMode = (ImeMode)0;
		Label obj29 = lblMa_Bp;
		location = new Point(6, 49);
		((Control)obj29).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj30 = lblMa_Bp;
		size = new Size(64, 13);
		((Control)obj30).Size = size;
		((Control)lblMa_Bp).TabIndex = 220;
		lblMa_Bp.Text = "Mã bộ phận";
		lblTen_Phi.ImeMode = (ImeMode)0;
		Label obj31 = lblTen_Phi;
		location = new Point(236, 75);
		((Control)obj31).Location = location;
		((Control)lblTen_Phi).Name = "lblTen_Phi";
		Label obj32 = lblTen_Phi;
		size = new Size(366, 13);
		((Control)obj32).Size = size;
		((Control)lblTen_Phi).TabIndex = 224;
		lblTen_Phi.TextAlign = (ContentAlignment)16;
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_Phi;
		location = new Point(148, 72);
		((Control)asTextBox9).Location = location;
		txtMa_Phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		txtMa_Phi.NameControl = lblTen_Phi;
		AsTextBox asTextBox10 = txtMa_Phi;
		size = new Size(82, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_Phi).TabIndex = 2;
		txtMa_Phi.UseAutoCompleteSource = true;
		lblMa_Phi.AutoSize = true;
		lblMa_Phi.ImeMode = (ImeMode)0;
		Label obj33 = lblMa_Phi;
		location = new Point(6, 75);
		((Control)obj33).Location = location;
		((Control)lblMa_Phi).Name = "lblMa_Phi";
		Label obj34 = lblMa_Phi;
		size = new Size(41, 13);
		((Control)obj34).Size = size;
		((Control)lblMa_Phi).TabIndex = 223;
		lblMa_Phi.Text = "Mã phí";
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj35 = lblTen_Hd;
		location = new Point(236, 101);
		((Control)obj35).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj36 = lblTen_Hd;
		size = new Size(366, 13);
		((Control)obj36).Size = size;
		((Control)lblTen_Hd).TabIndex = 227;
		lblTen_Hd.TextAlign = (ContentAlignment)16;
		txtMa_Hd.AutoLookup = true;
		txtMa_Hd.AutoValid = false;
		((TextBoxBase)txtMa_Hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtMa_Hd;
		location = new Point(148, 98);
		((Control)asTextBox11).Location = location;
		txtMa_Hd.LookupCodeName = "MA_HD";
		((Control)txtMa_Hd).Name = "txtMa_Hd";
		txtMa_Hd.NameControl = lblTen_Hd;
		AsTextBox asTextBox12 = txtMa_Hd;
		size = new Size(82, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtMa_Hd).TabIndex = 3;
		txtMa_Hd.UseAutoCompleteSource = true;
		lblMa_Hd.AutoSize = true;
		lblMa_Hd.ImeMode = (ImeMode)0;
		Label obj37 = lblMa_Hd;
		location = new Point(6, 101);
		((Control)obj37).Location = location;
		((Control)lblMa_Hd).Name = "lblMa_Hd";
		Label obj38 = lblMa_Hd;
		size = new Size(71, 13);
		((Control)obj38).Size = size;
		((Control)lblMa_Hd).TabIndex = 226;
		lblMa_Hd.Text = "Mã hợp đồng";
		((Control)lblTen_Ku).Enabled = false;
		lblTen_Ku.ImeMode = (ImeMode)0;
		Label obj39 = lblTen_Ku;
		location = new Point(419, 414);
		((Control)obj39).Location = location;
		((Control)lblTen_Ku).Name = "lblTen_Ku";
		Label obj40 = lblTen_Ku;
		size = new Size(366, 13);
		((Control)obj40).Size = size;
		((Control)lblTen_Ku).TabIndex = 230;
		lblTen_Ku.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Ku).Visible = false;
		txtMa_Ku.AutoLookup = true;
		txtMa_Ku.AutoValid = false;
		((TextBoxBase)txtMa_Ku).BackColor = SystemColors.Info;
		((TextBox)txtMa_Ku).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_Ku).Enabled = false;
		AsTextBox asTextBox13 = txtMa_Ku;
		location = new Point(331, 411);
		((Control)asTextBox13).Location = location;
		txtMa_Ku.LookupCodeName = "MA_KU";
		((Control)txtMa_Ku).Name = "txtMa_Ku";
		txtMa_Ku.NameControl = lblTen_Ku;
		AsTextBox asTextBox14 = txtMa_Ku;
		size = new Size(82, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtMa_Ku).TabIndex = 4;
		txtMa_Ku.UseAutoCompleteSource = true;
		((Control)txtMa_Ku).Visible = false;
		lblMa_Ku.AutoSize = true;
		((Control)lblMa_Ku).Enabled = false;
		lblMa_Ku.ImeMode = (ImeMode)0;
		Label obj41 = lblMa_Ku;
		location = new Point(189, 414);
		((Control)obj41).Location = location;
		((Control)lblMa_Ku).Name = "lblMa_Ku";
		Label obj42 = lblMa_Ku;
		size = new Size(64, 13);
		((Control)obj42).Size = size;
		((Control)lblMa_Ku).TabIndex = 229;
		lblMa_Ku.Text = "Mã khế ước";
		((Control)lblMa_Ku).Visible = false;
		lblTen_Spct.ImeMode = (ImeMode)0;
		Label obj43 = lblTen_Spct;
		location = new Point(236, 153);
		((Control)obj43).Location = location;
		((Control)lblTen_Spct).Name = "lblTen_Spct";
		Label obj44 = lblTen_Spct;
		size = new Size(366, 13);
		((Control)obj44).Size = size;
		((Control)lblTen_Spct).TabIndex = 233;
		lblTen_Spct.TextAlign = (ContentAlignment)16;
		txtMa_Spct.AutoLookup = true;
		txtMa_Spct.AutoValid = false;
		((TextBoxBase)txtMa_Spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_Spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox15 = txtMa_Spct;
		location = new Point(148, 124);
		((Control)asTextBox15).Location = location;
		txtMa_Spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_Spct).Name = "txtMa_Spct";
		txtMa_Spct.NameControl = lblTen_Spct;
		AsTextBox asTextBox16 = txtMa_Spct;
		size = new Size(82, 20);
		((Control)asTextBox16).Size = size;
		((Control)txtMa_Spct).TabIndex = 5;
		txtMa_Spct.UseAutoCompleteSource = true;
		lblMa_Spct.AutoSize = true;
		lblMa_Spct.ImeMode = (ImeMode)0;
		Label obj45 = lblMa_Spct;
		location = new Point(6, 127);
		((Control)obj45).Location = location;
		((Control)lblMa_Spct).Name = "lblMa_Spct";
		Label obj46 = lblMa_Spct;
		size = new Size(53, 13);
		((Control)obj46).Size = size;
		((Control)lblMa_Spct).TabIndex = 232;
		lblMa_Spct.Text = "Mã SPCT";
		txtDien_giai.AutoCompleteMode = (AutoCompleteMode)1;
		txtDien_giai.AutoCompleteSource = (AutoCompleteSource)7;
		TextBox obj47 = txtDien_giai;
		location = new Point(148, 150);
		((Control)obj47).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj48 = txtDien_giai;
		size = new Size(454, 20);
		((Control)obj48).Size = size;
		((Control)txtDien_giai).TabIndex = 6;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj49 = lblDien_giai;
		location = new Point(6, 153);
		((Control)obj49).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj50 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj50).Size = size;
		((Control)lblDien_giai).TabIndex = 235;
		lblDien_giai.Text = "Diễn giải";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(665, 411);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtMa_Ku);
		((Control)this).Controls.Add((Control)(object)lblTen_Ku);
		((Control)this).Controls.Add((Control)(object)lblMa_Ku);
		((Control)this).Name = "frmCaVchCA4Find";
		((Form)this).Text = "Tìm kiếm";
		((Control)this).Controls.SetChildIndex((Control)(object)lblMa_Ku, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen_Ku, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtMa_Ku, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPh, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbCt, 0);
		((Control)gbPh).ResumeLayout(false);
		((Control)gbPh).PerformLayout();
		((Control)gbCt).ResumeLayout(false);
		((Control)gbCt).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
