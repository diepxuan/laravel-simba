using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmFAAdjustKHTSEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("txtKh_N3")]
	private AsTextNumeric _txtKh_N3;

	[AccessedThroughProperty("txtT_Kh_Th")]
	private AsTextNumeric _txtT_Kh_Th;

	[AccessedThroughProperty("txtKh_N4")]
	private AsTextNumeric _txtKh_N4;

	[AccessedThroughProperty("chkSua_kh")]
	private CheckBox _chkSua_kh;

	[AccessedThroughProperty("txtTen_Ts")]
	private TextBox _txtTen_Ts;

	[AccessedThroughProperty("txtMa_Ts_TgNg")]
	private TextBox _txtMa_Ts_TgNg;

	[AccessedThroughProperty("txtMa_Ts")]
	private TextBox _txtMa_Ts;

	[AccessedThroughProperty("lblTong_Cong")]
	private Label _lblTong_Cong;

	[AccessedThroughProperty("lblTen_TS")]
	private Label _lblTen_TS;

	[AccessedThroughProperty("lblMa_TS_TGNG")]
	private Label _lblMa_TS_TGNG;

	[AccessedThroughProperty("lblMa_Ts")]
	private Label _lblMa_Ts;

	[AccessedThroughProperty("lblNV4")]
	private Label _lblNV4;

	[AccessedThroughProperty("lblNV3")]
	private Label _lblNV3;

	[AccessedThroughProperty("lblNV2")]
	private Label _lblNV2;

	[AccessedThroughProperty("lblNV1")]
	private Label _lblNV1;

	[AccessedThroughProperty("lblNguyen_Gia")]
	private Label _lblNguyen_Gia;

	[AccessedThroughProperty("lblGT_KH_DT")]
	private Label _lblGT_KH_DT;

	[AccessedThroughProperty("lblGT_CL_DT")]
	private Label _lblGT_CL_DT;

	[AccessedThroughProperty("lblGT_KH_TK")]
	private Label _lblGT_KH_TK;

	[AccessedThroughProperty("txtKh_N1")]
	private AsTextNumeric _txtKh_N1;

	[AccessedThroughProperty("txtKh_N2")]
	private AsTextNumeric _txtKh_N2;

	[AccessedThroughProperty("txtT_Gt_Cl")]
	private AsTextNumeric _txtT_Gt_Cl;

	[AccessedThroughProperty("txtT_Gt_Da_Kh")]
	private AsTextNumeric _txtT_Gt_Da_Kh;

	[AccessedThroughProperty("txtT_Ng_gia")]
	private AsTextNumeric _txtT_Ng_gia;

	internal virtual AsTextNumeric txtKh_N3
	{
		get
		{
			return _txtKh_N3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtKh_N1_Validated;
			if (_txtKh_N3 != null)
			{
				((Control)_txtKh_N3).Validated -= eventHandler;
			}
			_txtKh_N3 = value;
			if (_txtKh_N3 != null)
			{
				((Control)_txtKh_N3).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtT_Kh_Th
	{
		get
		{
			return _txtT_Kh_Th;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtT_Kh_Th = value;
		}
	}

	internal virtual AsTextNumeric txtKh_N4
	{
		get
		{
			return _txtKh_N4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtKh_N1_Validated;
			if (_txtKh_N4 != null)
			{
				((Control)_txtKh_N4).Validated -= eventHandler;
			}
			_txtKh_N4 = value;
			if (_txtKh_N4 != null)
			{
				((Control)_txtKh_N4).Validated += eventHandler;
			}
		}
	}

	internal virtual CheckBox chkSua_kh
	{
		get
		{
			return _chkSua_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = chkSua_kh_CheckedChanged;
			if (_chkSua_kh != null)
			{
				_chkSua_kh.CheckedChanged -= eventHandler;
			}
			_chkSua_kh = value;
			if (_chkSua_kh != null)
			{
				_chkSua_kh.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual TextBox txtTen_Ts
	{
		get
		{
			return _txtTen_Ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTen_Ts = value;
		}
	}

	internal virtual TextBox txtMa_Ts_TgNg
	{
		get
		{
			return _txtMa_Ts_TgNg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_Ts_TgNg = value;
		}
	}

	internal virtual TextBox txtMa_Ts
	{
		get
		{
			return _txtMa_Ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_Ts = value;
		}
	}

	internal virtual Label lblTong_Cong
	{
		get
		{
			return _lblTong_Cong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTong_Cong = value;
		}
	}

	internal virtual Label lblTen_TS
	{
		get
		{
			return _lblTen_TS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_TS = value;
		}
	}

	internal virtual Label lblMa_TS_TGNG
	{
		get
		{
			return _lblMa_TS_TGNG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_TS_TGNG = value;
		}
	}

	internal virtual Label lblMa_Ts
	{
		get
		{
			return _lblMa_Ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_Ts = value;
		}
	}

	internal virtual Label lblNV4
	{
		get
		{
			return _lblNV4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNV4 = value;
		}
	}

	internal virtual Label lblNV3
	{
		get
		{
			return _lblNV3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNV3 = value;
		}
	}

	internal virtual Label lblNV2
	{
		get
		{
			return _lblNV2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNV2 = value;
		}
	}

	internal virtual Label lblNV1
	{
		get
		{
			return _lblNV1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNV1 = value;
		}
	}

	internal virtual Label lblNguyen_Gia
	{
		get
		{
			return _lblNguyen_Gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNguyen_Gia = value;
		}
	}

	internal virtual Label lblGT_KH_DT
	{
		get
		{
			return _lblGT_KH_DT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblGT_KH_DT = value;
		}
	}

	internal virtual Label lblGT_CL_DT
	{
		get
		{
			return _lblGT_CL_DT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblGT_CL_DT = value;
		}
	}

	internal virtual Label lblGT_KH_TK
	{
		get
		{
			return _lblGT_KH_TK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblGT_KH_TK = value;
		}
	}

	internal virtual AsTextNumeric txtKh_N1
	{
		get
		{
			return _txtKh_N1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtKh_N1_Validated;
			if (_txtKh_N1 != null)
			{
				((Control)_txtKh_N1).Validated -= eventHandler;
			}
			_txtKh_N1 = value;
			if (_txtKh_N1 != null)
			{
				((Control)_txtKh_N1).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtKh_N2
	{
		get
		{
			return _txtKh_N2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtKh_N1_Validated;
			if (_txtKh_N2 != null)
			{
				((Control)_txtKh_N2).Validated -= eventHandler;
			}
			_txtKh_N2 = value;
			if (_txtKh_N2 != null)
			{
				((Control)_txtKh_N2).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtT_Gt_Cl
	{
		get
		{
			return _txtT_Gt_Cl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtT_Gt_Cl = value;
		}
	}

	internal virtual AsTextNumeric txtT_Gt_Da_Kh
	{
		get
		{
			return _txtT_Gt_Da_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtT_Gt_Da_Kh = value;
		}
	}

	internal virtual AsTextNumeric txtT_Ng_gia
	{
		get
		{
			return _txtT_Ng_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtT_Ng_gia = value;
		}
	}

	public frmFAAdjustKHTSEdit()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc8: Expected O, but got Unknown
		//IL_0fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd3: Expected O, but got Unknown
		//IL_116c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176: Expected O, but got Unknown
		//IL_1254: Unknown result type (might be due to invalid IL or missing references)
		//IL_125e: Expected O, but got Unknown
		//IL_133c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1346: Expected O, but got Unknown
		txtKh_N3 = new AsTextNumeric();
		lblTong_Cong = new Label();
		lblTen_TS = new Label();
		lblMa_TS_TGNG = new Label();
		lblMa_Ts = new Label();
		lblNV4 = new Label();
		lblNV3 = new Label();
		lblNV2 = new Label();
		lblNV1 = new Label();
		lblNguyen_Gia = new Label();
		lblGT_KH_DT = new Label();
		lblGT_CL_DT = new Label();
		lblGT_KH_TK = new Label();
		chkSua_kh = new CheckBox();
		txtTen_Ts = new TextBox();
		txtMa_Ts_TgNg = new TextBox();
		txtMa_Ts = new TextBox();
		txtKh_N2 = new AsTextNumeric();
		txtKh_N1 = new AsTextNumeric();
		txtT_Kh_Th = new AsTextNumeric();
		txtKh_N4 = new AsTextNumeric();
		txtT_Ng_gia = new AsTextNumeric();
		txtT_Gt_Da_Kh = new AsTextNumeric();
		txtT_Gt_Cl = new AsTextNumeric();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Enabled = false;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(543, 300);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 361);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 361);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtT_Gt_Cl);
		((Control)gbLine).Controls.Add((Control)(object)txtT_Gt_Da_Kh);
		((Control)gbLine).Controls.Add((Control)(object)txtT_Ng_gia);
		((Control)gbLine).Controls.Add((Control)(object)txtT_Kh_Th);
		((Control)gbLine).Controls.Add((Control)(object)txtKh_N4);
		((Control)gbLine).Controls.Add((Control)(object)chkSua_kh);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Ts);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Ts_TgNg);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Ts);
		((Control)gbLine).Controls.Add((Control)(object)lblTong_Cong);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_TS);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_TS_TGNG);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Ts);
		((Control)gbLine).Controls.Add((Control)(object)lblNV4);
		((Control)gbLine).Controls.Add((Control)(object)lblNV3);
		((Control)gbLine).Controls.Add((Control)(object)lblNV2);
		((Control)gbLine).Controls.Add((Control)(object)lblNV1);
		((Control)gbLine).Controls.Add((Control)(object)lblNguyen_Gia);
		((Control)gbLine).Controls.Add((Control)(object)lblGT_KH_DT);
		((Control)gbLine).Controls.Add((Control)(object)lblGT_CL_DT);
		((Control)gbLine).Controls.Add((Control)(object)lblGT_KH_TK);
		((Control)gbLine).Controls.Add((Control)(object)txtKh_N1);
		((Control)gbLine).Controls.Add((Control)(object)txtKh_N3);
		((Control)gbLine).Controls.Add((Control)(object)txtKh_N2);
		GroupBox obj3 = gbLine;
		Size size = new Size(647, 349);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtKh_N2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtKh_N3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtKh_N1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGT_KH_TK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGT_CL_DT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGT_KH_DT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNguyen_Gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNV1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNV2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNV3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNV4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_TS_TGNG, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_TS, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTong_Cong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Ts_TgNg, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkSua_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtKh_N4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtT_Kh_Th, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtT_Ng_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtT_Gt_Da_Kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtT_Gt_Cl, 0);
		txtKh_N3.DecimalSymbol = ".";
		txtKh_N3.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtKh_N3;
		location = new Point(249, 264);
		((Control)asTextNumeric).Location = location;
		txtKh_N3.Mask = "### ### ### ###.##";
		((Control)txtKh_N3).Name = "txtKh_N3";
		AsTextNumeric asTextNumeric2 = txtKh_N3;
		size = new Size(112, 20);
		((Control)asTextNumeric2).Size = size;
		txtKh_N3.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtKh_N3).TabIndex = 9;
		((TextBox)txtKh_N3).Text = "0.00";
		((TextBox)txtKh_N3).TextAlign = (HorizontalAlignment)1;
		txtKh_N3.Value = 0;
		((Control)lblTong_Cong).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1);
		lblTong_Cong.ImeMode = (ImeMode)0;
		Label obj4 = lblTong_Cong;
		location = new Point(22, 318);
		((Control)obj4).Location = location;
		((Control)lblTong_Cong).Name = "lblTong_Cong";
		Label obj5 = lblTong_Cong;
		size = new Size(168, 16);
		((Control)obj5).Size = size;
		((Control)lblTong_Cong).TabIndex = 109;
		lblTong_Cong.Text = "Tổng cộng";
		lblTen_TS.ImeMode = (ImeMode)0;
		Label obj6 = lblTen_TS;
		location = new Point(22, 70);
		((Control)obj6).Location = location;
		((Control)lblTen_TS).Name = "lblTen_TS";
		Label obj7 = lblTen_TS;
		size = new Size(168, 16);
		((Control)obj7).Size = size;
		((Control)lblTen_TS).TabIndex = 110;
		lblTen_TS.Text = "Tên tài sản";
		lblMa_TS_TGNG.ImeMode = (ImeMode)0;
		Label obj8 = lblMa_TS_TGNG;
		location = new Point(22, 44);
		((Control)obj8).Location = location;
		((Control)lblMa_TS_TGNG).Name = "lblMa_TS_TGNG";
		Label obj9 = lblMa_TS_TGNG;
		size = new Size(168, 16);
		((Control)obj9).Size = size;
		((Control)lblMa_TS_TGNG).TabIndex = 111;
		lblMa_TS_TGNG.Text = "Mã tài sản tăng giảm nguyên giá";
		lblMa_Ts.ImeMode = (ImeMode)0;
		Label obj10 = lblMa_Ts;
		location = new Point(22, 18);
		((Control)obj10).Location = location;
		((Control)lblMa_Ts).Name = "lblMa_Ts";
		Label obj11 = lblMa_Ts;
		size = new Size(168, 16);
		((Control)obj11).Size = size;
		((Control)lblMa_Ts).TabIndex = 100;
		lblMa_Ts.Text = "Mã tài sản";
		lblNV4.ImeMode = (ImeMode)0;
		Label obj12 = lblNV4;
		location = new Point(22, 292);
		((Control)obj12).Location = location;
		((Control)lblNV4).Name = "lblNV4";
		Label obj13 = lblNV4;
		size = new Size(168, 16);
		((Control)obj13).Size = size;
		((Control)lblNV4).TabIndex = 106;
		lblNV4.Text = "Nguồn vốn 4";
		lblNV3.ImeMode = (ImeMode)0;
		Label obj14 = lblNV3;
		location = new Point(22, 266);
		((Control)obj14).Location = location;
		((Control)lblNV3).Name = "lblNV3";
		Label obj15 = lblNV3;
		size = new Size(168, 16);
		((Control)obj15).Size = size;
		((Control)lblNV3).TabIndex = 104;
		lblNV3.Text = "Nguồn vốn 3";
		lblNV2.ImeMode = (ImeMode)0;
		Label obj16 = lblNV2;
		location = new Point(22, 240);
		((Control)obj16).Location = location;
		((Control)lblNV2).Name = "lblNV2";
		Label obj17 = lblNV2;
		size = new Size(168, 16);
		((Control)obj17).Size = size;
		((Control)lblNV2).TabIndex = 103;
		lblNV2.Text = "Nguồn vốn 2";
		lblNV1.ImeMode = (ImeMode)0;
		Label obj18 = lblNV1;
		location = new Point(22, 214);
		((Control)obj18).Location = location;
		((Control)lblNV1).Name = "lblNV1";
		Label obj19 = lblNV1;
		size = new Size(168, 16);
		((Control)obj19).Size = size;
		((Control)lblNV1).TabIndex = 101;
		lblNV1.Text = "Nguồn vốn 1";
		lblNguyen_Gia.ImeMode = (ImeMode)0;
		Label obj20 = lblNguyen_Gia;
		location = new Point(22, 96);
		((Control)obj20).Location = location;
		((Control)lblNguyen_Gia).Name = "lblNguyen_Gia";
		Label obj21 = lblNguyen_Gia;
		size = new Size(168, 16);
		((Control)obj21).Size = size;
		((Control)lblNguyen_Gia).TabIndex = 102;
		lblNguyen_Gia.Text = "Nguyên giá";
		lblGT_KH_DT.ImeMode = (ImeMode)0;
		Label obj22 = lblGT_KH_DT;
		location = new Point(22, 122);
		((Control)obj22).Location = location;
		((Control)lblGT_KH_DT).Name = "lblGT_KH_DT";
		Label obj23 = lblGT_KH_DT;
		size = new Size(176, 16);
		((Control)obj23).Size = size;
		((Control)lblGT_KH_DT).TabIndex = 105;
		lblGT_KH_DT.Text = "Giá trị đã khấu hao đến đầu tháng";
		lblGT_CL_DT.ImeMode = (ImeMode)0;
		Label obj24 = lblGT_CL_DT;
		location = new Point(22, 148);
		((Control)obj24).Location = location;
		((Control)lblGT_CL_DT).Name = "lblGT_CL_DT";
		Label obj25 = lblGT_CL_DT;
		size = new Size(168, 16);
		((Control)obj25).Size = size;
		((Control)lblGT_CL_DT).TabIndex = 107;
		lblGT_CL_DT.Text = "Giá trị còn lại đến đầu tháng";
		((Control)lblGT_KH_TK).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblGT_KH_TK).ForeColor = Color.Black;
		lblGT_KH_TK.ImeMode = (ImeMode)0;
		Label obj26 = lblGT_KH_TK;
		location = new Point(22, 190);
		((Control)obj26).Location = location;
		((Control)lblGT_KH_TK).Name = "lblGT_KH_TK";
		Label obj27 = lblGT_KH_TK;
		size = new Size(168, 16);
		((Control)obj27).Size = size;
		((Control)lblGT_KH_TK).TabIndex = 108;
		lblGT_KH_TK.Text = "Giá trị khấu hao trong kỳ";
		((ButtonBase)chkSua_kh).ImeMode = (ImeMode)0;
		CheckBox obj28 = chkSua_kh;
		location = new Point(249, 190);
		((Control)obj28).Location = location;
		((Control)chkSua_kh).Name = "chkSua_kh";
		CheckBox obj29 = chkSua_kh;
		size = new Size(96, 16);
		((Control)obj29).Size = size;
		((Control)chkSua_kh).TabIndex = 6;
		((ButtonBase)chkSua_kh).Text = "Sửa khấu hao";
		txtTen_Ts.CharacterCasing = (CharacterCasing)1;
		TextBox obj30 = txtTen_Ts;
		location = new Point(249, 68);
		((Control)obj30).Location = location;
		((TextBoxBase)txtTen_Ts).MaxLength = 20;
		((Control)txtTen_Ts).Name = "txtTen_Ts";
		((TextBoxBase)txtTen_Ts).ReadOnly = true;
		TextBox obj31 = txtTen_Ts;
		size = new Size(392, 20);
		((Control)obj31).Size = size;
		((Control)txtTen_Ts).TabIndex = 2;
		((Control)txtTen_Ts).TabStop = false;
		txtMa_Ts_TgNg.CharacterCasing = (CharacterCasing)1;
		TextBox obj32 = txtMa_Ts_TgNg;
		location = new Point(249, 42);
		((Control)obj32).Location = location;
		((TextBoxBase)txtMa_Ts_TgNg).MaxLength = 20;
		((Control)txtMa_Ts_TgNg).Name = "txtMa_Ts_TgNg";
		((TextBoxBase)txtMa_Ts_TgNg).ReadOnly = true;
		TextBox obj33 = txtMa_Ts_TgNg;
		size = new Size(96, 20);
		((Control)obj33).Size = size;
		((Control)txtMa_Ts_TgNg).TabIndex = 1;
		((Control)txtMa_Ts_TgNg).TabStop = false;
		txtMa_Ts.CharacterCasing = (CharacterCasing)1;
		TextBox obj34 = txtMa_Ts;
		location = new Point(249, 16);
		((Control)obj34).Location = location;
		((TextBoxBase)txtMa_Ts).MaxLength = 20;
		((Control)txtMa_Ts).Name = "txtMa_Ts";
		((TextBoxBase)txtMa_Ts).ReadOnly = true;
		TextBox obj35 = txtMa_Ts;
		size = new Size(96, 20);
		((Control)obj35).Size = size;
		((Control)txtMa_Ts).TabIndex = 0;
		((Control)txtMa_Ts).TabStop = false;
		txtKh_N2.DecimalSymbol = ".";
		txtKh_N2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtKh_N2;
		location = new Point(249, 238);
		((Control)asTextNumeric3).Location = location;
		txtKh_N2.Mask = "### ### ### ###.##";
		((Control)txtKh_N2).Name = "txtKh_N2";
		AsTextNumeric asTextNumeric4 = txtKh_N2;
		size = new Size(112, 20);
		((Control)asTextNumeric4).Size = size;
		txtKh_N2.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtKh_N2).TabIndex = 8;
		((TextBox)txtKh_N2).Text = "0.00";
		((TextBox)txtKh_N2).TextAlign = (HorizontalAlignment)1;
		txtKh_N2.Value = 0;
		txtKh_N1.DecimalSymbol = ".";
		txtKh_N1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtKh_N1;
		location = new Point(249, 212);
		((Control)asTextNumeric5).Location = location;
		txtKh_N1.Mask = "### ### ### ###.##";
		((Control)txtKh_N1).Name = "txtKh_N1";
		AsTextNumeric asTextNumeric6 = txtKh_N1;
		size = new Size(112, 20);
		((Control)asTextNumeric6).Size = size;
		txtKh_N1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtKh_N1).TabIndex = 7;
		((TextBox)txtKh_N1).Text = "0.00";
		((TextBox)txtKh_N1).TextAlign = (HorizontalAlignment)1;
		txtKh_N1.Value = 0;
		txtT_Kh_Th.DecimalSymbol = ".";
		((Control)txtT_Kh_Th).Enabled = false;
		((Control)txtT_Kh_Th).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_Kh_Th.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtT_Kh_Th;
		location = new Point(249, 316);
		((Control)asTextNumeric7).Location = location;
		txtT_Kh_Th.Mask = "### ### ### ###.##";
		((Control)txtT_Kh_Th).Name = "txtT_Kh_Th";
		((TextBoxBase)txtT_Kh_Th).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_Kh_Th;
		size = new Size(112, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_Kh_Th.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_Kh_Th).TabIndex = 11;
		((TextBox)txtT_Kh_Th).Text = "0.00";
		((TextBox)txtT_Kh_Th).TextAlign = (HorizontalAlignment)1;
		txtT_Kh_Th.Value = 0;
		txtKh_N4.DecimalSymbol = ".";
		txtKh_N4.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric9 = txtKh_N4;
		location = new Point(249, 290);
		((Control)asTextNumeric9).Location = location;
		txtKh_N4.Mask = "### ### ### ###.##";
		((Control)txtKh_N4).Name = "txtKh_N4";
		AsTextNumeric asTextNumeric10 = txtKh_N4;
		size = new Size(112, 20);
		((Control)asTextNumeric10).Size = size;
		txtKh_N4.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtKh_N4).TabIndex = 10;
		((TextBox)txtKh_N4).Text = "0.00";
		((TextBox)txtKh_N4).TextAlign = (HorizontalAlignment)1;
		txtKh_N4.Value = 0;
		txtT_Ng_gia.DecimalSymbol = ".";
		((Control)txtT_Ng_gia).Enabled = false;
		((Control)txtT_Ng_gia).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_Ng_gia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric11 = txtT_Ng_gia;
		location = new Point(249, 94);
		((Control)asTextNumeric11).Location = location;
		txtT_Ng_gia.Mask = "### ### ### ###.##";
		((Control)txtT_Ng_gia).Name = "txtT_Ng_gia";
		((TextBoxBase)txtT_Ng_gia).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtT_Ng_gia;
		size = new Size(112, 20);
		((Control)asTextNumeric12).Size = size;
		txtT_Ng_gia.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_Ng_gia).TabIndex = 3;
		((TextBox)txtT_Ng_gia).Text = "0.00";
		((TextBox)txtT_Ng_gia).TextAlign = (HorizontalAlignment)1;
		txtT_Ng_gia.Value = 0;
		txtT_Gt_Da_Kh.DecimalSymbol = ".";
		((Control)txtT_Gt_Da_Kh).Enabled = false;
		((Control)txtT_Gt_Da_Kh).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_Gt_Da_Kh.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric13 = txtT_Gt_Da_Kh;
		location = new Point(249, 120);
		((Control)asTextNumeric13).Location = location;
		txtT_Gt_Da_Kh.Mask = "### ### ### ###.##";
		((Control)txtT_Gt_Da_Kh).Name = "txtT_Gt_Da_Kh";
		((TextBoxBase)txtT_Gt_Da_Kh).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtT_Gt_Da_Kh;
		size = new Size(112, 20);
		((Control)asTextNumeric14).Size = size;
		txtT_Gt_Da_Kh.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_Gt_Da_Kh).TabIndex = 4;
		((TextBox)txtT_Gt_Da_Kh).Text = "0.00";
		((TextBox)txtT_Gt_Da_Kh).TextAlign = (HorizontalAlignment)1;
		txtT_Gt_Da_Kh.Value = 0;
		txtT_Gt_Cl.DecimalSymbol = ".";
		((Control)txtT_Gt_Cl).Enabled = false;
		((Control)txtT_Gt_Cl).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_Gt_Cl.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric15 = txtT_Gt_Cl;
		location = new Point(249, 146);
		((Control)asTextNumeric15).Location = location;
		txtT_Gt_Cl.Mask = "### ### ### ###.##";
		((Control)txtT_Gt_Cl).Name = "txtT_Gt_Cl";
		((TextBoxBase)txtT_Gt_Cl).ReadOnly = true;
		AsTextNumeric asTextNumeric16 = txtT_Gt_Cl;
		size = new Size(112, 20);
		((Control)asTextNumeric16).Size = size;
		txtT_Gt_Cl.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_Gt_Cl).TabIndex = 5;
		((TextBox)txtT_Gt_Cl).Text = "0.00";
		((TextBox)txtT_Gt_Cl).TextAlign = (HorizontalAlignment)1;
		txtT_Gt_Cl.Value = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(671, 396);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFAAdjustKHTSEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_Ts;
		CreateDataBinding(ref ojb, "Ma_Ts");
		txtMa_Ts = (TextBox)ojb;
		ojb = (Control)(object)txtMa_Ts_TgNg;
		CreateDataBinding(ref ojb, "ma_ts_tgng");
		txtMa_Ts_TgNg = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Ts;
		CreateDataBinding(ref ojb, "Ten_Ts");
		txtTen_Ts = (TextBox)ojb;
		ojb = (Control)(object)txtT_Ng_gia;
		CreateDataBinding(ref ojb, "T_Ng_gia", "value");
		txtT_Ng_gia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtT_Gt_Da_Kh;
		CreateDataBinding(ref ojb, "T_Gt_Da_Kh", "value");
		txtT_Gt_Da_Kh = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtT_Gt_Cl;
		CreateDataBinding(ref ojb, "T_gt_cl", "value");
		txtT_Gt_Cl = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)chkSua_kh;
		CreateDataBinding(ref ojb, "sua_kh", "Checked");
		chkSua_kh = (CheckBox)ojb;
		ojb = (Control)(object)txtKh_N1;
		CreateDataBinding(ref ojb, "Kh_N1", "value");
		txtKh_N1 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtKh_N2;
		CreateDataBinding(ref ojb, "Kh_N2", "value");
		txtKh_N2 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtKh_N3;
		CreateDataBinding(ref ojb, "Kh_N3", "value");
		txtKh_N3 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtKh_N4;
		CreateDataBinding(ref ojb, "Kh_N4", "value");
		txtKh_N4 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtT_Kh_Th;
		CreateDataBinding(ref ojb, "T_Kh_Th", "value");
		txtT_Kh_Th = (AsTextNumeric)(object)ojb;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		InittabTTKH();
		ChkSua_Kh_ChecChanged();
	}

	private void InittabTTKH()
	{
		DataTable dataTable = Commons.FAGetTenNguonVon(CompanyInformations.CompanyID);
		checked
		{
			if (dataTable.Rows.Count != 0)
			{
				ArrayList arrayList = new ArrayList();
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["ten_nv"]), isNum: false)));
				}
				int num2 = 4 - arrayList.Count;
				for (int j = 0; j <= num2; j++)
				{
					arrayList.Add("");
				}
				lblNV1.Text = Conversions.ToString(arrayList[0]);
				lblNV2.Text = Conversions.ToString(arrayList[1]);
				lblNV3.Text = Conversions.ToString(arrayList[2]);
				lblNV4.Text = Conversions.ToString(arrayList[3]);
			}
		}
	}

	private void chkSua_kh_CheckedChanged(object sender, EventArgs e)
	{
		ChkSua_Kh_ChecChanged();
	}

	private void ChkSua_Kh_ChecChanged()
	{
		if (chkSua_kh.Checked)
		{
			((TextBoxBase)txtKh_N1).ReadOnly = false;
			((TextBoxBase)txtKh_N2).ReadOnly = false;
			((TextBoxBase)txtKh_N3).ReadOnly = false;
			((TextBoxBase)txtKh_N4).ReadOnly = false;
		}
		else
		{
			((TextBoxBase)txtKh_N1).ReadOnly = true;
			((TextBoxBase)txtKh_N2).ReadOnly = true;
			((TextBoxBase)txtKh_N3).ReadOnly = true;
			((TextBoxBase)txtKh_N4).ReadOnly = true;
		}
	}

	private void txtKh_N1_Validated(object sender, EventArgs e)
	{
		txtT_Kh_Th.Value = Operators.AddObject(Operators.AddObject(Operators.AddObject(txtKh_N1.Value, txtKh_N2.Value), txtKh_N3.Value), txtKh_N4.Value);
	}
}
