using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaERP.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmFAGiamTSEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_ts")]
	private AsTextBox _txtMa_ts;

	[AccessedThroughProperty("txtT_ng_gia")]
	private AsTextNumeric _txtT_ng_gia;

	[AccessedThroughProperty("txtTen_ts")]
	private TextBox _txtTen_ts;

	[AccessedThroughProperty("txtSo_ct_giam")]
	private TextBox _txtSo_ct_giam;

	[AccessedThroughProperty("lblNguyen_gia")]
	private Label _lblNguyen_gia;

	[AccessedThroughProperty("txtma_giam_ts")]
	private AsTextBox _txtma_giam_ts;

	[AccessedThroughProperty("lblSo_ct")]
	private Label _lblSo_ct;

	[AccessedThroughProperty("lblLy_do_giam")]
	private Label _lblLy_do_giam;

	[AccessedThroughProperty("lblMa_ts")]
	private Label _lblMa_ts;

	[AccessedThroughProperty("lblNgay_ct")]
	private Label _lblNgay_ct;

	[AccessedThroughProperty("lblNgay_giam")]
	private Label _lblNgay_giam;

	[AccessedThroughProperty("lblTen_ts")]
	private Label _lblTen_ts;

	[AccessedThroughProperty("txtNgay_giam")]
	private AsMaskedTextBox _txtNgay_giam;

	[AccessedThroughProperty("txtNgay_ct_giam")]
	private AsMaskedTextBox _txtNgay_ct_giam;

	[AccessedThroughProperty("lblTen_ld_giam")]
	private Label _lblTen_ld_giam;

	private DateTime dtm_ngay_tang;

	private DateTime dtm_ngay_bdkh;

	private int intSt_kh;

	private int so_luong;

	internal virtual AsTextBox txtMa_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_ts_AfterCodeValidating;
			if (_txtMa_ts != null)
			{
				_txtMa_ts.AfterCodeValidating -= obj;
			}
			_txtMa_ts = value;
			if (_txtMa_ts != null)
			{
				_txtMa_ts.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual AsTextNumeric txtT_ng_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_ng_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_ng_gia = value;
		}
	}

	internal virtual TextBox txtTen_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_ts = value;
		}
	}

	internal virtual TextBox txtSo_ct_giam
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ct_giam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ct_giam = value;
		}
	}

	internal virtual Label lblNguyen_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguyen_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguyen_gia = value;
		}
	}

	internal virtual AsTextBox txtma_giam_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtma_giam_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtma_giam_ts = value;
		}
	}

	internal virtual Label lblSo_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_ct = value;
		}
	}

	internal virtual Label lblLy_do_giam
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLy_do_giam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLy_do_giam = value;
		}
	}

	internal virtual Label lblMa_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_ts = value;
		}
	}

	internal virtual Label lblNgay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_ct = value;
		}
	}

	internal virtual Label lblNgay_giam
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_giam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_giam = value;
		}
	}

	internal virtual Label lblTen_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ts = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_giam
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_giam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_giam = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_ct_giam
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ct_giam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_ct_giam = value;
		}
	}

	internal virtual Label lblTen_ld_giam
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ld_giam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ld_giam = value;
		}
	}

	[DebuggerNonUserCode]
	public frmFAGiamTSEdit()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
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
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		lblTen_ts = new Label();
		lblNgay_giam = new Label();
		lblNgay_ct = new Label();
		lblMa_ts = new Label();
		lblLy_do_giam = new Label();
		lblSo_ct = new Label();
		txtma_giam_ts = new AsTextBox();
		lblTen_ld_giam = new Label();
		lblNguyen_gia = new Label();
		txtSo_ct_giam = new TextBox();
		txtTen_ts = new TextBox();
		txtT_ng_gia = new AsTextNumeric();
		txtMa_ts = new AsTextBox();
		txtNgay_ct_giam = new AsMaskedTextBox();
		txtNgay_giam = new AsMaskedTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(416, 379);
		((Control)asCheckBox).Location = location;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 226);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 226);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblTen_ld_giam);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_giam);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct_giam);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_ts);
		((Control)gbLine).Controls.Add((Control)(object)txtT_ng_gia);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_ts);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct_giam);
		((Control)gbLine).Controls.Add((Control)(object)lblNguyen_gia);
		((Control)gbLine).Controls.Add((Control)(object)txtma_giam_ts);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)lblLy_do_giam);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_ts);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_ct);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_giam);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_ts);
		GroupBox obj3 = gbLine;
		location = new Point(12, 5);
		((Control)obj3).Location = location;
		GroupBox obj4 = gbLine;
		Size size = new Size(449, 214);
		((Control)obj4).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_giam, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblLy_do_giam, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtma_giam_ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNguyen_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct_giam, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtT_ng_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct_giam, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_giam, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_ld_giam, 0);
		lblTen_ts.AutoSize = true;
		Label obj5 = lblTen_ts;
		location = new Point(16, 50);
		((Control)obj5).Location = location;
		((Control)lblTen_ts).Name = "lblTen_ts";
		Label obj6 = lblTen_ts;
		size = new Size(60, 13);
		((Control)obj6).Size = size;
		((Control)lblTen_ts).TabIndex = 100;
		lblTen_ts.Text = "Tên tài sản";
		lblNgay_giam.AutoSize = true;
		Label obj7 = lblNgay_giam;
		location = new Point(16, 155);
		((Control)obj7).Location = location;
		((Control)lblNgay_giam).Name = "lblNgay_giam";
		Label obj8 = lblNgay_giam;
		size = new Size(57, 13);
		((Control)obj8).Size = size;
		((Control)lblNgay_giam).TabIndex = 100;
		lblNgay_giam.Text = "Ngày giảm";
		lblNgay_ct.AutoSize = true;
		Label obj9 = lblNgay_ct;
		location = new Point(16, 130);
		((Control)obj9).Location = location;
		((Control)lblNgay_ct).Name = "lblNgay_ct";
		Label obj10 = lblNgay_ct;
		size = new Size(61, 13);
		((Control)obj10).Size = size;
		((Control)lblNgay_ct).TabIndex = 100;
		lblNgay_ct.Text = "Ngày ct/bb";
		lblMa_ts.AutoSize = true;
		Label obj11 = lblMa_ts;
		location = new Point(16, 22);
		((Control)obj11).Location = location;
		((Control)lblMa_ts).Name = "lblMa_ts";
		Label obj12 = lblMa_ts;
		size = new Size(56, 13);
		((Control)obj12).Size = size;
		((Control)lblMa_ts).TabIndex = 100;
		lblMa_ts.Text = "Mã tài sản";
		lblLy_do_giam.AutoSize = true;
		Label obj13 = lblLy_do_giam;
		location = new Point(16, 181);
		((Control)obj13).Location = location;
		((Control)lblLy_do_giam).Name = "lblLy_do_giam";
		Label obj14 = lblLy_do_giam;
		size = new Size(58, 13);
		((Control)obj14).Size = size;
		((Control)lblLy_do_giam).TabIndex = 100;
		lblLy_do_giam.Text = "Lý do giảm";
		lblSo_ct.AutoSize = true;
		Label obj15 = lblSo_ct;
		location = new Point(16, 105);
		((Control)obj15).Location = location;
		((Control)lblSo_ct).Name = "lblSo_ct";
		Label obj16 = lblSo_ct;
		size = new Size(49, 13);
		((Control)obj16).Size = size;
		((Control)lblSo_ct).TabIndex = 100;
		lblSo_ct.Text = "Số ct/bb";
		txtma_giam_ts.AutoLookup = true;
		txtma_giam_ts.AutoValid = true;
		((TextBoxBase)txtma_giam_ts).BackColor = SystemColors.Info;
		((TextBox)txtma_giam_ts).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtma_giam_ts;
		location = new Point(94, 178);
		((Control)asTextBox).Location = location;
		txtma_giam_ts.LookupCodeName = "MA_LDTG";
		txtma_giam_ts.LookupWhereCondition = "tg='G'";
		((Control)txtma_giam_ts).Name = "txtma_giam_ts";
		txtma_giam_ts.NameControl = lblTen_ld_giam;
		txtma_giam_ts.SD = true;
		AsTextBox asTextBox2 = txtma_giam_ts;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtma_giam_ts).TabIndex = 6;
		txtma_giam_ts.UseAutoCompleteSource = true;
		Label obj17 = lblTen_ld_giam;
		location = new Point(200, 182);
		((Control)obj17).Location = location;
		((Control)lblTen_ld_giam).Name = "lblTen_ld_giam";
		Label obj18 = lblTen_ld_giam;
		size = new Size(228, 13);
		((Control)obj18).Size = size;
		((Control)lblTen_ld_giam).TabIndex = 101;
		lblNguyen_gia.AutoSize = true;
		Label obj19 = lblNguyen_gia;
		location = new Point(16, 77);
		((Control)obj19).Location = location;
		((Control)lblNguyen_gia).Name = "lblNguyen_gia";
		Label obj20 = lblNguyen_gia;
		size = new Size(61, 13);
		((Control)obj20).Size = size;
		((Control)lblNguyen_gia).TabIndex = 100;
		lblNguyen_gia.Text = "Nguyên giá";
		TextBox obj21 = txtSo_ct_giam;
		location = new Point(94, 99);
		((Control)obj21).Location = location;
		((Control)txtSo_ct_giam).Name = "txtSo_ct_giam";
		TextBox obj22 = txtSo_ct_giam;
		size = new Size(100, 20);
		((Control)obj22).Size = size;
		((Control)txtSo_ct_giam).TabIndex = 3;
		((Control)txtTen_ts).Enabled = false;
		TextBox obj23 = txtTen_ts;
		location = new Point(94, 46);
		((Control)obj23).Location = location;
		((Control)txtTen_ts).Name = "txtTen_ts";
		TextBox obj24 = txtTen_ts;
		size = new Size(334, 20);
		((Control)obj24).Size = size;
		((Control)txtTen_ts).TabIndex = 1;
		txtT_ng_gia.DecimalSymbol = ".";
		((Control)txtT_ng_gia).Enabled = false;
		txtT_ng_gia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtT_ng_gia;
		location = new Point(94, 73);
		((Control)asTextNumeric).Location = location;
		txtT_ng_gia.Mask = "### ### ### ###.##";
		((Control)txtT_ng_gia).Name = "txtT_ng_gia";
		AsTextNumeric asTextNumeric2 = txtT_ng_gia;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		txtT_ng_gia.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_ng_gia).TabIndex = 2;
		((TextBox)txtT_ng_gia).Text = "0.00";
		((TextBox)txtT_ng_gia).TextAlign = (HorizontalAlignment)1;
		txtT_ng_gia.Value = 0;
		txtMa_ts.AutoLookup = true;
		txtMa_ts.AutoValid = true;
		((TextBoxBase)txtMa_ts).BackColor = SystemColors.Info;
		((TextBox)txtMa_ts).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_ts;
		location = new Point(94, 19);
		((Control)asTextBox3).Location = location;
		txtMa_ts.LookupCodeName = "MA_TS";
		((Control)txtMa_ts).Name = "txtMa_ts";
		txtMa_ts.NameControl = null;
		AsTextBox asTextBox4 = txtMa_ts;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_ts).TabIndex = 0;
		txtMa_ts.UseAutoCompleteSource = true;
		txtMa_ts.ValidReturnFieldList = "ten_ts,t_ng_gia,ngay_tang,so_luong,ngay_bdkh,st_kh";
		txtNgay_ct_giam.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct_giam).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct_giam;
		location = new Point(94, 126);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ct_giam).Mask = "##/##/####";
		((Control)txtNgay_ct_giam).Name = "txtNgay_ct_giam";
		((MaskedTextBox)txtNgay_ct_giam).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ct_giam;
		size = new Size(78, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ct_giam).TabIndex = 4;
		((MaskedTextBox)txtNgay_ct_giam).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ct_giam;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtNgay_giam.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_giam).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_giam;
		location = new Point(94, 152);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_giam).Mask = "##/##/####";
		((Control)txtNgay_giam).Name = "txtNgay_giam";
		((MaskedTextBox)txtNgay_giam).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_giam;
		size = new Size(78, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_giam).TabIndex = 5;
		((MaskedTextBox)txtNgay_giam).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_giam;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(473, 261);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFAGiamTSEdit";
		((Form)this).Text = "frmFAGiamTSEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_ts).Enabled = false;
		((Control)txtTen_ts).Enabled = false;
		((Control)txtT_ng_gia).Enabled = false;
		((Control)txtSo_ct_giam).Select();
	}

	protected override void DataBinding()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_ts;
		CreateDataBinding(ref ojb, "Ma_ts");
		txtMa_ts = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTen_ts;
		CreateDataBinding(ref ojb, "Ten_ts");
		txtTen_ts = (TextBox)ojb;
		ojb = (Control)(object)txtT_ng_gia;
		CreateDataBinding(ref ojb, "T_ng_gia", "value");
		txtT_ng_gia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSo_ct_giam;
		CreateDataBinding(ref ojb, "so_ct_giam");
		txtSo_ct_giam = (TextBox)ojb;
		ojb = (Control)(object)txtNgay_ct_giam;
		CreateDataBinding(ref ojb, "ngay_ct_giam", "value");
		txtNgay_ct_giam = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_giam;
		CreateDataBinding(ref ojb, "ngay_giam", "value");
		txtNgay_giam = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtma_giam_ts;
		CreateDataBinding(ref ojb, "ma_giam_ts");
		txtma_giam_ts = (AsTextBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_ts))
		{
			return false;
		}
		if (!ChkEmtyTextBox(txtSo_ct_giam))
		{
			return false;
		}
		if (Operators.ConditionalCompareObjectEqual(txtNgay_ct_giam.Value, (object)new DateTime(599266080000000000L), false))
		{
			epNotice.SetError((Control)(object)txtNgay_ct_giam, Helper.GetMessContent(50002));
			return false;
		}
		if (Operators.ConditionalCompareObjectEqual(txtNgay_giam.Value, (object)new DateTime(599266080000000000L), false))
		{
			epNotice.SetError((Control)(object)txtNgay_giam, Helper.GetMessContent(50002));
			return false;
		}
		if (Operators.ConditionalCompareObjectGreater((object)dtm_ngay_tang, txtNgay_giam.Value, false))
		{
			CMessageBox.Show(50066);
			((Control)txtNgay_giam).Focus();
			return false;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtma_giam_ts))
		{
			return false;
		}
		bool flag = false;
		FAGiamTSDAO fAGiamTSDAO = (FAGiamTSDAO)DAOFactory.CreateDAOInstance("FAGiamTSDAO", "FAGiamTS");
		flag = ((!EditMode) ? fAGiamTSDAO.ChkGiamTs(CompanyInformations.CompanyID, ((TextBox)txtMa_ts).Text.Trim(), Conversions.ToDate(txtNgay_giam.Value), "M") : fAGiamTSDAO.ChkGiamTs(CompanyInformations.CompanyID, ((TextBox)txtMa_ts).Text.Trim(), Conversions.ToDate(txtNgay_giam.Value), "S"));
		fAGiamTSDAO.Destroy();
		if (0u - (flag ? 1u : 0u) != 0)
		{
			CMessageBox.Show(50053);
			return false;
		}
		return base.ValidData();
	}

	protected override bool InsertToDB()
	{
		return UpdateDB();
	}

	protected override bool UpdateDB()
	{
		FAGiamTSDAO fAGiamTSDAO = (FAGiamTSDAO)DAOFactory.CreateDAOInstance("FAGiamTSDAO", "FAGiamTS");
		int num = fAGiamTSDAO.Update(CompanyInformations.CompanyID, Conversions.ToString(RowToEdit["ma_ts"]), ((TextBox)txtma_giam_ts).Text, Conversions.ToDate(txtNgay_giam.Value), so_luong, txtSo_ct_giam.Text, Conversions.ToDate(txtNgay_ct_giam.Value), SystemInformations.UserName);
		fAGiamTSDAO.Destroy();
		return num == 0;
	}

	protected override bool SetToRow()
	{
		base.SetToRow();
		if (!EditMode)
		{
			RowToEdit["ngay_tang"] = dtm_ngay_tang;
			RowToEdit["ngay_bdkh"] = dtm_ngay_bdkh;
			RowToEdit["st_kh"] = intSt_kh;
		}
		return true;
	}

	private void txtMa_ts_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		txtTen_ts.Text = Conversions.ToString(e.ValidatedRow["ten_ts"]);
		txtT_ng_gia.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["t_ng_gia"]);
		dtm_ngay_tang = Conversions.ToDate(e.ValidatedRow["ngay_tang"]);
		dtm_ngay_bdkh = Conversions.ToDate(e.ValidatedRow["ngay_bdkh"]);
		intSt_kh = Conversions.ToInteger(e.ValidatedRow["st_kh"]);
		so_luong = Conversions.ToInteger(e.ValidatedRow["so_luong"]);
	}
}
