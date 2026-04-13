using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLDMCTGSEdit : frmDMEdit
{
	private IContainer components;

	[AccessedThroughProperty("lblStt")]
	private Label _lblStt;

	[AccessedThroughProperty("txtMa_ct")]
	private AsTextBox _txtMa_ct;

	[AccessedThroughProperty("txtStt")]
	private TextBox _txtStt;

	[AccessedThroughProperty("lblSo_hieu")]
	private Label _lblSo_hieu;

	[AccessedThroughProperty("lblTen_ctgs")]
	private Label _lblTen_ctgs;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("lblMa_ct")]
	private Label _lblMa_ct;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblSo_ngay")]
	private Label _lblSo_ngay;

	[AccessedThroughProperty("txtNgay")]
	private AsTextNumeric _txtNgay;

	[AccessedThroughProperty("txtSo_hieu")]
	private AsTextBox _txtSo_hieu;

	[AccessedThroughProperty("txtTen_ctgs")]
	private TextBox _txtTen_ctgs;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("lblTen_ct")]
	private Label _lblTen_ct;

	internal virtual Label lblStt
	{
		get
		{
			return _lblStt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblStt = value;
		}
	}

	internal virtual AsTextBox txtMa_ct
	{
		get
		{
			return _txtMa_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_ct = value;
		}
	}

	internal virtual TextBox txtStt
	{
		get
		{
			return _txtStt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtStt = value;
		}
	}

	internal virtual Label lblSo_hieu
	{
		get
		{
			return _lblSo_hieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblSo_hieu = value;
		}
	}

	internal virtual Label lblTen_ctgs
	{
		get
		{
			return _lblTen_ctgs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_ctgs = value;
		}
	}

	internal virtual Label lblTk
	{
		get
		{
			return _lblTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTk = value;
		}
	}

	internal virtual Label lblMa_ct
	{
		get
		{
			return _lblMa_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_ct = value;
		}
	}

	internal virtual AsTextBox txtTk
	{
		get
		{
			return _txtTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTk = value;
		}
	}

	internal virtual Label lblSo_ngay
	{
		get
		{
			return _lblSo_ngay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblSo_ngay = value;
		}
	}

	internal virtual AsTextNumeric txtNgay
	{
		get
		{
			return _txtNgay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNgay = value;
		}
	}

	internal virtual AsTextBox txtSo_hieu
	{
		get
		{
			return _txtSo_hieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_hieu = value;
		}
	}

	internal virtual TextBox txtTen_ctgs
	{
		get
		{
			return _txtTen_ctgs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTen_ctgs = value;
		}
	}

	internal virtual Label lblTen_tk
	{
		get
		{
			return _lblTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_tk = value;
		}
	}

	internal virtual Label lblTen_ct
	{
		get
		{
			return _lblTen_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_ct = value;
		}
	}

	public frmGLDMCTGSEdit()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		lblStt = new Label();
		txtStt = new TextBox();
		txtMa_ct = new AsTextBox();
		lblTen_ct = new Label();
		lblMa_ct = new Label();
		lblTk = new Label();
		lblTen_ctgs = new Label();
		lblSo_hieu = new Label();
		lblSo_ngay = new Label();
		txtTk = new AsTextBox();
		lblTen_tk = new Label();
		txtTen_ctgs = new TextBox();
		txtSo_hieu = new AsTextBox();
		txtNgay = new AsTextNumeric();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(139, 175);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 7;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 212);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 212);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_hieu);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_ctgs);
		((Control)gbLine).Controls.Add((Control)(object)txtTk);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_ngay);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_hieu);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_ctgs);
		((Control)gbLine).Controls.Add((Control)(object)lblTk);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtStt);
		((Control)gbLine).Controls.Add((Control)(object)lblStt);
		GroupBox obj3 = gbLine;
		Size size = new Size(541, 200);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblStt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtStt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_ctgs, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_hieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_ngay, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_ctgs, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_hieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		lblStt.AutoSize = true;
		Label obj4 = lblStt;
		location = new Point(20, 23);
		((Control)obj4).Location = location;
		((Control)lblStt).Name = "lblStt";
		Label obj5 = lblStt;
		size = new Size(50, 13);
		((Control)obj5).Size = size;
		((Control)lblStt).TabIndex = 8;
		lblStt.Text = "Số thứ tự";
		TextBox obj6 = txtStt;
		location = new Point(139, 19);
		((Control)obj6).Location = location;
		((Control)txtStt).Name = "txtStt";
		TextBox obj7 = txtStt;
		size = new Size(100, 20);
		((Control)obj7).Size = size;
		((Control)txtStt).TabIndex = 0;
		txtMa_ct.AutoLookup = true;
		txtMa_ct.AutoValid = true;
		((TextBoxBase)txtMa_ct).BackColor = SystemColors.Info;
		((TextBox)txtMa_ct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_ct;
		location = new Point(139, 45);
		((Control)asTextBox).Location = location;
		txtMa_ct.LookupCodeName = "MA_CT";
		((Control)txtMa_ct).Name = "txtMa_ct";
		txtMa_ct.NameControl = lblTen_ct;
		AsTextBox asTextBox2 = txtMa_ct;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_ct).TabIndex = 1;
		txtMa_ct.UseAutoCompleteSource = true;
		Label obj8 = lblTen_ct;
		location = new Point(245, 45);
		((Control)obj8).Location = location;
		((Control)lblTen_ct).Name = "lblTen_ct";
		Label obj9 = lblTen_ct;
		size = new Size(275, 20);
		((Control)obj9).Size = size;
		((Control)lblTen_ct).TabIndex = 15;
		lblTen_ct.TextAlign = (ContentAlignment)16;
		lblMa_ct.AutoSize = true;
		Label obj10 = lblMa_ct;
		location = new Point(20, 49);
		((Control)obj10).Location = location;
		((Control)lblMa_ct).Name = "lblMa_ct";
		Label obj11 = lblMa_ct;
		size = new Size(67, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_ct).TabIndex = 9;
		lblMa_ct.Text = "Mã chứng từ";
		lblTk.AutoSize = true;
		Label obj12 = lblTk;
		location = new Point(20, 75);
		((Control)obj12).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj13 = lblTk;
		size = new Size(55, 13);
		((Control)obj13).Size = size;
		((Control)lblTk).TabIndex = 10;
		lblTk.Text = "Tài khoản";
		lblTen_ctgs.AutoSize = true;
		Label obj14 = lblTen_ctgs;
		location = new Point(20, 101);
		((Control)obj14).Location = location;
		((Control)lblTen_ctgs).Name = "lblTen_ctgs";
		Label obj15 = lblTen_ctgs;
		size = new Size(102, 13);
		((Control)obj15).Size = size;
		((Control)lblTen_ctgs).TabIndex = 12;
		lblTen_ctgs.Text = "Tên chứng từ ghi sổ";
		lblSo_hieu.AutoSize = true;
		Label obj16 = lblSo_hieu;
		location = new Point(20, 127);
		((Control)obj16).Location = location;
		((Control)lblSo_hieu).Name = "lblSo_hieu";
		Label obj17 = lblSo_hieu;
		size = new Size(43, 13);
		((Control)obj17).Size = size;
		((Control)lblSo_hieu).TabIndex = 13;
		lblSo_hieu.Text = "Số hiệu";
		lblSo_ngay.AutoSize = true;
		Label obj18 = lblSo_ngay;
		location = new Point(20, 153);
		((Control)obj18).Location = location;
		((Control)lblSo_ngay).Name = "lblSo_ngay";
		Label obj19 = lblSo_ngay;
		size = new Size(46, 13);
		((Control)obj19).Size = size;
		((Control)lblSo_ngay).TabIndex = 14;
		lblSo_ngay.Text = "Số ngày";
		txtTk.AutoLookup = true;
		txtTk.AutoValid = true;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk;
		location = new Point(139, 71);
		((Control)asTextBox3).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_tk;
		AsTextBox asTextBox4 = txtTk;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk).TabIndex = 2;
		txtTk.UseAutoCompleteSource = true;
		Label obj20 = lblTen_tk;
		location = new Point(245, 71);
		((Control)obj20).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj21 = lblTen_tk;
		size = new Size(275, 20);
		((Control)obj21).Size = size;
		((Control)lblTen_tk).TabIndex = 16;
		lblTen_tk.TextAlign = (ContentAlignment)16;
		TextBox obj22 = txtTen_ctgs;
		location = new Point(139, 97);
		((Control)obj22).Location = location;
		((Control)txtTen_ctgs).Name = "txtTen_ctgs";
		TextBox obj23 = txtTen_ctgs;
		size = new Size(381, 20);
		((Control)obj23).Size = size;
		((Control)txtTen_ctgs).TabIndex = 4;
		txtSo_hieu.AutoLookup = false;
		txtSo_hieu.AutoValid = false;
		((TextBoxBase)txtSo_hieu).BackColor = SystemColors.Window;
		((TextBox)txtSo_hieu).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtSo_hieu;
		location = new Point(139, 123);
		((Control)asTextBox5).Location = location;
		txtSo_hieu.LookupCodeName = "";
		((Control)txtSo_hieu).Name = "txtSo_hieu";
		txtSo_hieu.NameControl = null;
		AsTextBox asTextBox6 = txtSo_hieu;
		size = new Size(100, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtSo_hieu).TabIndex = 5;
		txtSo_hieu.UseAutoCompleteSource = true;
		txtNgay.DecimalSymbol = ".";
		txtNgay.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtNgay;
		location = new Point(139, 149);
		((Control)asTextNumeric).Location = location;
		txtNgay.Mask = "### ###";
		((Control)txtNgay).Name = "txtNgay";
		AsTextNumeric asTextNumeric2 = txtNgay;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		txtNgay.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNgay).TabIndex = 6;
		((TextBox)txtNgay).Text = "0";
		((TextBox)txtNgay).TextAlign = (HorizontalAlignment)1;
		txtNgay.Type = Commons.NumericType.ORTHER_;
		txtNgay.Value = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(565, 247);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGLDMCTGSEdit";
		((Form)this).Text = "frmGLDMCTGSEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((Control)txtStt).Select();
	}

	protected override bool ValidData()
	{
		if (Operators.CompareString(txtStt.Text, "", false) == 0)
		{
			SetControlError((Control)(object)txtStt, Helper.GetMessContent(50002));
			((Control)txtStt).Select();
			return false;
		}
		SetControlError((Control)(object)txtStt, "");
		if (Operators.CompareString(((TextBox)txtMa_ct).Text, "", false) == 0)
		{
			SetControlError((Control)(object)txtMa_ct, Helper.GetMessContent(50002));
			((Control)txtMa_ct).Select();
			return false;
		}
		SetControlError((Control)(object)txtMa_ct, "");
		if (Operators.CompareString(txtTen_ctgs.Text, "", false) == 0)
		{
			SetControlError((Control)(object)txtTen_ctgs, Helper.GetMessContent(50002));
			((Control)txtTen_ctgs).Select();
			return false;
		}
		SetControlError((Control)(object)txtTen_ctgs, "");
		if (Operators.CompareString(((TextBox)txtSo_hieu).Text, "", false) == 0)
		{
			SetControlError((Control)(object)txtSo_hieu, Helper.GetMessContent(50002));
			((Control)txtSo_hieu).Select();
			return false;
		}
		SetControlError((Control)(object)txtSo_hieu, "");
		if (Operators.ConditionalCompareObjectEqual(txtNgay.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtNgay, Helper.GetMessContent(50002));
			((Control)txtNgay).Select();
			return false;
		}
		SetControlError((Control)(object)txtNgay, "");
		return base.ValidData();
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtStt;
		CreateDataBinding(ref ojb, "stt");
		txtStt = (TextBox)ojb;
		ojb = (Control)(object)txtMa_ct;
		CreateDataBinding(ref ojb, "ma_ct");
		txtMa_ct = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk;
		CreateDataBinding(ref ojb, "tk");
		txtTk = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_tk;
		CreateDataBinding(ref ojb, "ten_tk");
		lblTen_tk = (Label)ojb;
		ojb = (Control)(object)lblTen_ct;
		CreateDataBinding(ref ojb, "ten_ctgs");
		lblTen_ct = (Label)ojb;
		ojb = (Control)(object)txtTen_ctgs;
		CreateDataBinding(ref ojb, "ten_ctgs");
		txtTen_ctgs = (TextBox)ojb;
		ojb = (Control)(object)txtSo_hieu;
		CreateDataBinding(ref ojb, "so_hieu");
		txtSo_hieu = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay;
		CreateDataBinding(ref ojb, "ngay");
		txtNgay = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "bold", "checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_ct).Enabled = false;
		((Control)txtStt).Select();
	}
}
