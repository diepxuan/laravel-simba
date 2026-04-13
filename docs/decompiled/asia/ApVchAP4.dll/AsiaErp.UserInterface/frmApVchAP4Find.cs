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
public class frmApVchAP4Find : frmVoucherFind
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("lblDien_giai")]
	private Label _lblDien_giai;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("lblTen_Spct")]
	private Label _lblTen_Spct;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("txtMa_Spct")]
	private AsTextBox _txtMa_Spct;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

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

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTk_co")]
	private Label _lblTk_co;

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

	internal virtual Label lblTk_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_co = value;
		}
	}

	[DebuggerNonUserCode]
	public frmApVchAP4Find()
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
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
		txtDien_giai = new TextBox();
		lblDien_giai = new Label();
		lblTen_Kh = new Label();
		lblTen_Spct = new Label();
		txtMa_Kh = new AsTextBox();
		txtMa_Spct = new AsTextBox();
		lblMa_Kh = new Label();
		lblMa_Spct = new Label();
		lblTen_Hd = new Label();
		txtMa_Hd = new AsTextBox();
		lblMa_Hd = new Label();
		lblTen_Phi = new Label();
		txtMa_Phi = new AsTextBox();
		lblMa_Phi = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_Bp = new Label();
		lblTen_Tk = new Label();
		txtTk = new AsTextBox();
		lblTk_co = new Label();
		((Control)gbPh).SuspendLayout();
		((Control)gbCt).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 337);
		((Control)obj).Location = location;
		Button obj2 = cmdOk;
		location = new Point(12, 337);
		((Control)obj2).Location = location;
		GroupBox obj3 = gbPh;
		Size size = new Size(604, 105);
		((Control)obj3).Size = size;
		((Control)gbCt).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbCt).Controls.Add((Control)(object)lblDien_giai);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Spct);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Kh);
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
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Tk);
		((Control)gbCt).Controls.Add((Control)(object)txtTk);
		((Control)gbCt).Controls.Add((Control)(object)lblTk_co);
		GroupBox obj4 = gbCt;
		location = new Point(12, 119);
		((Control)obj4).Location = location;
		GroupBox obj5 = gbCt;
		size = new Size(604, 212);
		((Control)obj5).Size = size;
		TextBox obj6 = txtSo_Ct1;
		location = new Point(149, 47);
		((Control)obj6).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct2;
		location = new Point(330, 24);
		((Control)asMaskedTextBox).Location = location;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_Ct1;
		location = new Point(149, 23);
		((Control)asMaskedTextBox2).Location = location;
		TextBox obj7 = txtSo_Ct2;
		location = new Point(330, 47);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct2;
		location = new Point(263, 51);
		((Control)obj8).Location = location;
		Label obj9 = lblSo_Ct1;
		location = new Point(7, 48);
		((Control)obj9).Location = location;
		Label obj10 = lblNgay_Ct2;
		location = new Point(263, 26);
		((Control)obj10).Location = location;
		Label obj11 = lblNgay_Ct1;
		location = new Point(7, 24);
		((Control)obj11).Location = location;
		Label obj12 = lblSo_tien2;
		location = new Point(263, 77);
		((Control)obj12).Location = location;
		txtSo_tien1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtSo_tien1;
		location = new Point(150, 74);
		((Control)asTextNumeric).Location = location;
		txtSo_tien1.SpecialType = Commons.NumericSpecialType.Other;
		txtSo_tien1.Type = Commons.NumericType.ORTHER_;
		txtSo_tien2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric2 = txtSo_tien2;
		location = new Point(330, 74);
		((Control)asTextNumeric2).Location = location;
		txtSo_tien2.SpecialType = Commons.NumericSpecialType.Other;
		txtSo_tien2.Type = Commons.NumericType.ORTHER_;
		txtDien_giai.AutoCompleteMode = (AutoCompleteMode)1;
		txtDien_giai.AutoCompleteSource = (AutoCompleteSource)7;
		TextBox obj13 = txtDien_giai;
		location = new Point(150, 175);
		((Control)obj13).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj14 = txtDien_giai;
		size = new Size(438, 20);
		((Control)obj14).Size = size;
		((Control)txtDien_giai).TabIndex = 8;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj15 = lblDien_giai;
		location = new Point(7, 179);
		((Control)obj15).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj16 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj16).Size = size;
		((Control)lblDien_giai).TabIndex = 261;
		lblDien_giai.Text = "Diễn giải";
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj17 = lblTen_Kh;
		location = new Point(238, 22);
		((Control)obj17).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj18 = lblTen_Kh;
		size = new Size(350, 13);
		((Control)obj18).Size = size;
		((Control)lblTen_Kh).TabIndex = 246;
		lblTen_Spct.ImeMode = (ImeMode)0;
		Label obj19 = lblTen_Spct;
		location = new Point(238, 152);
		((Control)obj19).Location = location;
		((Control)lblTen_Spct).Name = "lblTen_Spct";
		Label obj20 = lblTen_Spct;
		size = new Size(350, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_Spct).TabIndex = 260;
		lblTen_Spct.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = false;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(150, 19);
		((Control)asTextBox).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		AsTextBox asTextBox2 = txtMa_Kh;
		size = new Size(82, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Kh).TabIndex = 0;
		txtMa_Kh.UseAutoCompleteSource = true;
		txtMa_Spct.AutoLookup = true;
		txtMa_Spct.AutoValid = false;
		((TextBoxBase)txtMa_Spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_Spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_Spct;
		location = new Point(150, 149);
		((Control)asTextBox3).Location = location;
		txtMa_Spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_Spct).Name = "txtMa_Spct";
		txtMa_Spct.NameControl = lblTen_Spct;
		AsTextBox asTextBox4 = txtMa_Spct;
		size = new Size(82, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_Spct).TabIndex = 7;
		txtMa_Spct.UseAutoCompleteSource = true;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj21 = lblMa_Kh;
		location = new Point(7, 23);
		((Control)obj21).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj22 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj22).Size = size;
		((Control)lblMa_Kh).TabIndex = 245;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblMa_Spct.AutoSize = true;
		lblMa_Spct.ImeMode = (ImeMode)0;
		Label obj23 = lblMa_Spct;
		location = new Point(7, 153);
		((Control)obj23).Location = location;
		((Control)lblMa_Spct).Name = "lblMa_Spct";
		Label obj24 = lblMa_Spct;
		size = new Size(53, 13);
		((Control)obj24).Size = size;
		((Control)lblMa_Spct).TabIndex = 259;
		lblMa_Spct.Text = "Mã SPCT";
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj25 = lblTen_Hd;
		location = new Point(238, 127);
		((Control)obj25).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj26 = lblTen_Hd;
		size = new Size(350, 13);
		((Control)obj26).Size = size;
		((Control)lblTen_Hd).TabIndex = 256;
		lblTen_Hd.TextAlign = (ContentAlignment)16;
		txtMa_Hd.AutoLookup = true;
		txtMa_Hd.AutoValid = false;
		((TextBoxBase)txtMa_Hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_Hd;
		location = new Point(150, 123);
		((Control)asTextBox5).Location = location;
		txtMa_Hd.LookupCodeName = "MA_HD";
		((Control)txtMa_Hd).Name = "txtMa_Hd";
		txtMa_Hd.NameControl = lblTen_Hd;
		AsTextBox asTextBox6 = txtMa_Hd;
		size = new Size(82, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_Hd).TabIndex = 5;
		txtMa_Hd.UseAutoCompleteSource = true;
		lblMa_Hd.AutoSize = true;
		lblMa_Hd.ImeMode = (ImeMode)0;
		Label obj27 = lblMa_Hd;
		location = new Point(7, 127);
		((Control)obj27).Location = location;
		((Control)lblMa_Hd).Name = "lblMa_Hd";
		Label obj28 = lblMa_Hd;
		size = new Size(71, 13);
		((Control)obj28).Size = size;
		((Control)lblMa_Hd).TabIndex = 255;
		lblMa_Hd.Text = "Mã hợp đồng";
		lblTen_Phi.ImeMode = (ImeMode)0;
		Label obj29 = lblTen_Phi;
		location = new Point(238, 101);
		((Control)obj29).Location = location;
		((Control)lblTen_Phi).Name = "lblTen_Phi";
		Label obj30 = lblTen_Phi;
		size = new Size(350, 13);
		((Control)obj30).Size = size;
		((Control)lblTen_Phi).TabIndex = 254;
		lblTen_Phi.TextAlign = (ContentAlignment)16;
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_Phi;
		location = new Point(150, 97);
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
		Label obj31 = lblMa_Phi;
		location = new Point(7, 101);
		((Control)obj31).Location = location;
		((Control)lblMa_Phi).Name = "lblMa_Phi";
		Label obj32 = lblMa_Phi;
		size = new Size(41, 13);
		((Control)obj32).Size = size;
		((Control)lblMa_Phi).TabIndex = 253;
		lblMa_Phi.Text = "Mã phí";
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj33 = lblTen_Bp;
		location = new Point(239, 75);
		((Control)obj33).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj34 = lblTen_Bp;
		size = new Size(350, 13);
		((Control)obj34).Size = size;
		((Control)lblTen_Bp).TabIndex = 252;
		lblTen_Bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_Bp;
		location = new Point(151, 71);
		((Control)asTextBox9).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox10 = txtMa_Bp;
		size = new Size(82, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_Bp).TabIndex = 3;
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_Bp.AutoSize = true;
		lblMa_Bp.ImeMode = (ImeMode)0;
		Label obj35 = lblMa_Bp;
		location = new Point(8, 75);
		((Control)obj35).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj36 = lblMa_Bp;
		size = new Size(64, 13);
		((Control)obj36).Size = size;
		((Control)lblMa_Bp).TabIndex = 251;
		lblMa_Bp.Text = "Mã bộ phận";
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj37 = lblTen_Tk;
		location = new Point(238, 49);
		((Control)obj37).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj38 = lblTen_Tk;
		size = new Size(350, 13);
		((Control)obj38).Size = size;
		((Control)lblTen_Tk).TabIndex = 248;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = false;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtTk;
		location = new Point(150, 45);
		((Control)asTextBox11).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk;
		AsTextBox asTextBox12 = txtTk;
		size = new Size(82, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtTk).TabIndex = 2;
		txtTk.UseAutoCompleteSource = true;
		lblTk_co.AutoSize = true;
		lblTk_co.ImeMode = (ImeMode)0;
		Label obj39 = lblTk_co;
		location = new Point(7, 49);
		((Control)obj39).Location = location;
		((Control)lblTk_co).Name = "lblTk_co";
		Label obj40 = lblTk_co;
		size = new Size(55, 13);
		((Control)obj40).Size = size;
		((Control)lblTk_co).TabIndex = 247;
		lblTk_co.Text = "Tài khoản";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(628, 372);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmApVchAP4Find";
		((Form)this).Text = "Tìm kiếm";
		((Control)gbPh).ResumeLayout(false);
		((Control)gbPh).PerformLayout();
		((Control)gbCt).ResumeLayout(false);
		((Control)gbCt).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
