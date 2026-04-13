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
public class frmGlVchGL1Find : frmVoucherFind
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("lblTen_Tk_No")]
	private Label _lblTen_Tk_No;

	[AccessedThroughProperty("lblTk_No")]
	private Label _lblTk_No;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTen_Spct")]
	private Label _lblTen_Spct;

	[AccessedThroughProperty("txtMa_Spct")]
	private AsTextBox _txtMa_Spct;

	[AccessedThroughProperty("lblMa_Spct")]
	private Label _lblMa_Spct;

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

	[AccessedThroughProperty("lblten_lo")]
	private Label _lblten_lo;

	[AccessedThroughProperty("txtma_lo")]
	private AsTextBox _txtma_lo;

	[AccessedThroughProperty("lblma_lo")]
	private Label _lblma_lo;

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

	internal virtual Label lblTen_Tk_No
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_No;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_No = value;
		}
	}

	internal virtual Label lblTk_No
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_No;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_No = value;
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

	internal virtual Label lblten_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblten_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblten_lo = value;
		}
	}

	internal virtual AsTextBox txtma_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtma_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtma_lo = value;
		}
	}

	internal virtual Label lblma_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblma_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblma_lo = value;
		}
	}

	[DebuggerNonUserCode]
	public frmGlVchGL1Find()
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
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblTen_Tk_No = new Label();
		txtTk = new AsTextBox();
		lblTk_No = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_Bp = new Label();
		lblTen_Phi = new Label();
		txtMa_Phi = new AsTextBox();
		lblMa_Phi = new Label();
		lblTen_Hd = new Label();
		txtMa_Hd = new AsTextBox();
		lblMa_Hd = new Label();
		lblTen_Spct = new Label();
		txtMa_Spct = new AsTextBox();
		lblMa_Spct = new Label();
		txtDien_giai = new TextBox();
		lblDien_giai = new Label();
		lblten_lo = new Label();
		txtma_lo = new AsTextBox();
		lblma_lo = new Label();
		((Control)gbPh).SuspendLayout();
		((Control)gbCt).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 373);
		((Control)obj).Location = location;
		Button obj2 = cmdOk;
		location = new Point(12, 373);
		((Control)obj2).Location = location;
		GroupBox obj3 = gbPh;
		Size size = new Size(613, 114);
		((Control)obj3).Size = size;
		((Control)gbCt).Controls.Add((Control)(object)lblten_lo);
		((Control)gbCt).Controls.Add((Control)(object)txtma_lo);
		((Control)gbCt).Controls.Add((Control)(object)lblma_lo);
		((Control)gbCt).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbCt).Controls.Add((Control)(object)lblDien_giai);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Tk_No);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Spct);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbCt).Controls.Add((Control)(object)txtTk);
		((Control)gbCt).Controls.Add((Control)(object)lblTk_No);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Spct);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_Kh);
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
		GroupBox obj4 = gbCt;
		location = new Point(12, 124);
		((Control)obj4).Location = location;
		GroupBox obj5 = gbCt;
		size = new Size(613, 241);
		((Control)obj5).Size = size;
		TextBox obj6 = txtSo_Ct1;
		location = new Point(141, 47);
		((Control)obj6).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct2;
		location = new Point(322, 21);
		((Control)asMaskedTextBox).Location = location;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_Ct1;
		location = new Point(141, 21);
		((Control)asMaskedTextBox2).Location = location;
		TextBox obj7 = txtSo_Ct2;
		location = new Point(322, 47);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct2;
		location = new Point(255, 51);
		((Control)obj8).Location = location;
		Label obj9 = lblSo_Ct1;
		location = new Point(8, 50);
		((Control)obj9).Location = location;
		Label obj10 = lblNgay_Ct2;
		location = new Point(253, 25);
		((Control)obj10).Location = location;
		Label obj11 = lblNgay_Ct1;
		location = new Point(8, 24);
		((Control)obj11).Location = location;
		Label obj12 = lblSo_tien2;
		location = new Point(254, 77);
		((Control)obj12).Location = location;
		txtSo_tien1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtSo_tien1;
		location = new Point(141, 73);
		((Control)asTextNumeric).Location = location;
		txtSo_tien1.SpecialType = Commons.NumericSpecialType.Other;
		txtSo_tien1.Type = Commons.NumericType.ORTHER_;
		Label obj13 = lblSo_tien1;
		location = new Point(5, 76);
		((Control)obj13).Location = location;
		txtSo_tien2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric2 = txtSo_tien2;
		location = new Point(321, 73);
		((Control)asTextNumeric2).Location = location;
		txtSo_tien2.SpecialType = Commons.NumericSpecialType.Other;
		txtSo_tien2.Type = Commons.NumericType.ORTHER_;
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj14 = lblTen_Kh;
		location = new Point(229, 28);
		((Control)obj14).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj15 = lblTen_Kh;
		size = new Size(366, 13);
		((Control)obj15).Size = size;
		((Control)lblTen_Kh).TabIndex = 137;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = false;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(141, 25);
		((Control)asTextBox).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		AsTextBox asTextBox2 = txtMa_Kh;
		size = new Size(82, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Kh).TabIndex = 0;
		txtMa_Kh.UseAutoCompleteSource = true;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj16 = lblMa_Kh;
		location = new Point(8, 28);
		((Control)obj16).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj17 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj17).Size = size;
		((Control)lblMa_Kh).TabIndex = 136;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblTen_Tk_No.ImeMode = (ImeMode)0;
		Label obj18 = lblTen_Tk_No;
		location = new Point(229, 53);
		((Control)obj18).Location = location;
		((Control)lblTen_Tk_No).Name = "lblTen_Tk_No";
		Label obj19 = lblTen_Tk_No;
		size = new Size(366, 13);
		((Control)obj19).Size = size;
		((Control)lblTen_Tk_No).TabIndex = 220;
		lblTen_Tk_No.TextAlign = (ContentAlignment)16;
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = false;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk;
		location = new Point(141, 49);
		((Control)asTextBox3).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk_No;
		AsTextBox asTextBox4 = txtTk;
		size = new Size(82, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk).TabIndex = 1;
		txtTk.UseAutoCompleteSource = true;
		lblTk_No.AutoSize = true;
		lblTk_No.ImeMode = (ImeMode)0;
		Label obj20 = lblTk_No;
		location = new Point(8, 52);
		((Control)obj20).Location = location;
		((Control)lblTk_No).Name = "lblTk_No";
		Label obj21 = lblTk_No;
		size = new Size(55, 13);
		((Control)obj21).Size = size;
		((Control)lblTk_No).TabIndex = 219;
		lblTk_No.Text = "Tài khoản";
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj22 = lblTen_Bp;
		location = new Point(229, 78);
		((Control)obj22).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj23 = lblTen_Bp;
		size = new Size(366, 13);
		((Control)obj23).Size = size;
		((Control)lblTen_Bp).TabIndex = 221;
		lblTen_Bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_Bp;
		location = new Point(141, 75);
		((Control)asTextBox5).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox6 = txtMa_Bp;
		size = new Size(82, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_Bp).TabIndex = 3;
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_Bp.AutoSize = true;
		lblMa_Bp.ImeMode = (ImeMode)0;
		Label obj24 = lblMa_Bp;
		location = new Point(8, 78);
		((Control)obj24).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj25 = lblMa_Bp;
		size = new Size(64, 13);
		((Control)obj25).Size = size;
		((Control)lblMa_Bp).TabIndex = 220;
		lblMa_Bp.Text = "Mã bộ phận";
		lblTen_Phi.ImeMode = (ImeMode)0;
		Label obj26 = lblTen_Phi;
		location = new Point(229, 102);
		((Control)obj26).Location = location;
		((Control)lblTen_Phi).Name = "lblTen_Phi";
		Label obj27 = lblTen_Phi;
		size = new Size(366, 13);
		((Control)obj27).Size = size;
		((Control)lblTen_Phi).TabIndex = 224;
		lblTen_Phi.TextAlign = (ContentAlignment)16;
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_Phi;
		location = new Point(141, 99);
		((Control)asTextBox7).Location = location;
		txtMa_Phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		txtMa_Phi.NameControl = lblTen_Phi;
		AsTextBox asTextBox8 = txtMa_Phi;
		size = new Size(82, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_Phi).TabIndex = 4;
		txtMa_Phi.UseAutoCompleteSource = true;
		lblMa_Phi.AutoSize = true;
		lblMa_Phi.ImeMode = (ImeMode)0;
		Label obj28 = lblMa_Phi;
		location = new Point(8, 102);
		((Control)obj28).Location = location;
		((Control)lblMa_Phi).Name = "lblMa_Phi";
		Label obj29 = lblMa_Phi;
		size = new Size(41, 13);
		((Control)obj29).Size = size;
		((Control)lblMa_Phi).TabIndex = 223;
		lblMa_Phi.Text = "Mã phí";
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj30 = lblTen_Hd;
		location = new Point(229, 126);
		((Control)obj30).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj31 = lblTen_Hd;
		size = new Size(366, 13);
		((Control)obj31).Size = size;
		((Control)lblTen_Hd).TabIndex = 227;
		lblTen_Hd.TextAlign = (ContentAlignment)16;
		txtMa_Hd.AutoLookup = true;
		txtMa_Hd.AutoValid = false;
		((TextBoxBase)txtMa_Hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_Hd;
		location = new Point(141, 123);
		((Control)asTextBox9).Location = location;
		txtMa_Hd.LookupCodeName = "MA_HD";
		((Control)txtMa_Hd).Name = "txtMa_Hd";
		txtMa_Hd.NameControl = lblTen_Hd;
		AsTextBox asTextBox10 = txtMa_Hd;
		size = new Size(82, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_Hd).TabIndex = 5;
		txtMa_Hd.UseAutoCompleteSource = true;
		lblMa_Hd.AutoSize = true;
		lblMa_Hd.ImeMode = (ImeMode)0;
		Label obj32 = lblMa_Hd;
		location = new Point(8, 126);
		((Control)obj32).Location = location;
		((Control)lblMa_Hd).Name = "lblMa_Hd";
		Label obj33 = lblMa_Hd;
		size = new Size(71, 13);
		((Control)obj33).Size = size;
		((Control)lblMa_Hd).TabIndex = 226;
		lblMa_Hd.Text = "Mã hợp đồng";
		lblTen_Spct.ImeMode = (ImeMode)0;
		Label obj34 = lblTen_Spct;
		location = new Point(229, 174);
		((Control)obj34).Location = location;
		((Control)lblTen_Spct).Name = "lblTen_Spct";
		Label obj35 = lblTen_Spct;
		size = new Size(366, 13);
		((Control)obj35).Size = size;
		((Control)lblTen_Spct).TabIndex = 233;
		lblTen_Spct.TextAlign = (ContentAlignment)16;
		txtMa_Spct.AutoLookup = true;
		txtMa_Spct.AutoValid = false;
		((TextBoxBase)txtMa_Spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_Spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtMa_Spct;
		location = new Point(141, 149);
		((Control)asTextBox11).Location = location;
		txtMa_Spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_Spct).Name = "txtMa_Spct";
		txtMa_Spct.NameControl = lblTen_Spct;
		AsTextBox asTextBox12 = txtMa_Spct;
		size = new Size(82, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtMa_Spct).TabIndex = 7;
		txtMa_Spct.UseAutoCompleteSource = true;
		lblMa_Spct.AutoSize = true;
		lblMa_Spct.ImeMode = (ImeMode)0;
		Label obj36 = lblMa_Spct;
		location = new Point(8, 152);
		((Control)obj36).Location = location;
		((Control)lblMa_Spct).Name = "lblMa_Spct";
		Label obj37 = lblMa_Spct;
		size = new Size(53, 13);
		((Control)obj37).Size = size;
		((Control)lblMa_Spct).TabIndex = 232;
		lblMa_Spct.Text = "Mã SPCT";
		txtDien_giai.AutoCompleteMode = (AutoCompleteMode)1;
		txtDien_giai.AutoCompleteSource = (AutoCompleteSource)7;
		TextBox obj38 = txtDien_giai;
		location = new Point(141, 206);
		((Control)obj38).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj39 = txtDien_giai;
		size = new Size(454, 20);
		((Control)obj39).Size = size;
		((Control)txtDien_giai).TabIndex = 9;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj40 = lblDien_giai;
		location = new Point(8, 209);
		((Control)obj40).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj41 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj41).Size = size;
		((Control)lblDien_giai).TabIndex = 235;
		lblDien_giai.Text = "Diễn giải";
		lblten_lo.ImeMode = (ImeMode)0;
		Label obj42 = lblten_lo;
		location = new Point(229, 178);
		((Control)obj42).Location = location;
		((Control)lblten_lo).Name = "lblten_lo";
		Label obj43 = lblten_lo;
		size = new Size(366, 13);
		((Control)obj43).Size = size;
		((Control)lblten_lo).TabIndex = 238;
		lblten_lo.TextAlign = (ContentAlignment)16;
		txtma_lo.AutoLookup = true;
		txtma_lo.AutoValid = false;
		((TextBoxBase)txtma_lo).BackColor = SystemColors.Info;
		((TextBox)txtma_lo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox13 = txtma_lo;
		location = new Point(141, 175);
		((Control)asTextBox13).Location = location;
		txtma_lo.LookupCodeName = "MA_LO";
		((Control)txtma_lo).Name = "txtma_lo";
		txtma_lo.NameControl = lblten_lo;
		AsTextBox asTextBox14 = txtma_lo;
		size = new Size(82, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtma_lo).TabIndex = 8;
		txtma_lo.UseAutoCompleteSource = true;
		lblma_lo.AutoSize = true;
		lblma_lo.ImeMode = (ImeMode)0;
		Label obj44 = lblma_lo;
		location = new Point(8, 178);
		((Control)obj44).Location = location;
		((Control)lblma_lo).Name = "lblma_lo";
		Label obj45 = lblma_lo;
		size = new Size(33, 13);
		((Control)obj45).Size = size;
		((Control)lblma_lo).TabIndex = 237;
		lblma_lo.Text = "Mã lô";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(637, 408);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlVchGL1Find";
		((Form)this).Text = "Tìm kiếm";
		((Control)gbPh).ResumeLayout(false);
		((Control)gbPh).PerformLayout();
		((Control)gbCt).ResumeLayout(false);
		((Control)gbCt).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
