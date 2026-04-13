using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmAPRptBK02 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("lblMa_NhKh")]
	private Label _lblMa_NhKh;

	[AccessedThroughProperty("txtMa_NhKh")]
	private AsTextBox _txtMa_NhKh;

	[AccessedThroughProperty("lblTen_NhKh")]
	private Label _lblTen_NhKh;

	[AccessedThroughProperty("lblHan_ky2")]
	private Label _lblHan_ky2;

	[AccessedThroughProperty("txtHan_ky2")]
	private AsTextNumeric _txtHan_ky2;

	[AccessedThroughProperty("lblHan_ky1")]
	private Label _lblHan_ky1;

	[AccessedThroughProperty("txtHan_ky1")]
	private AsTextNumeric _txtHan_ky1;

	[AccessedThroughProperty("lblNgay_Ss")]
	private Label _lblNgay_Ss;

	[AccessedThroughProperty("txtNgay_Ss")]
	private AsMaskedTextBox _txtNgay_Ss;

	[AccessedThroughProperty("lblChi_xem")]
	private Label _lblChi_xem;

	[AccessedThroughProperty("cboChi_xem")]
	private ComboBox _cboChi_xem;

	[AccessedThroughProperty("lblSap_xep")]
	private Label _lblSap_xep;

	[AccessedThroughProperty("ChkSap_xep")]
	private AsCheckBox _ChkSap_xep;

	[AccessedThroughProperty("lblHan_ky3")]
	private Label _lblHan_ky3;

	[AccessedThroughProperty("txtHan_ky3")]
	private AsTextNumeric _txtHan_ky3;

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

	internal virtual Label lblMa_NhKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_NhKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_NhKh = value;
		}
	}

	internal virtual AsTextBox txtMa_NhKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_NhKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_NhKh = value;
		}
	}

	internal virtual Label lblTen_NhKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_NhKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_NhKh = value;
		}
	}

	internal virtual Label lblHan_ky2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblHan_ky2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblHan_ky2 = value;
		}
	}

	internal virtual AsTextNumeric txtHan_ky2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHan_ky2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtHan_ky2_Validated;
			if (_txtHan_ky2 != null)
			{
				((Control)_txtHan_ky2).Validated -= eventHandler;
			}
			_txtHan_ky2 = value;
			if (_txtHan_ky2 != null)
			{
				((Control)_txtHan_ky2).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblHan_ky1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblHan_ky1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblHan_ky1 = value;
		}
	}

	internal virtual AsTextNumeric txtHan_ky1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHan_ky1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtHan_ky1_Validated;
			if (_txtHan_ky1 != null)
			{
				((Control)_txtHan_ky1).Validated -= eventHandler;
			}
			_txtHan_ky1 = value;
			if (_txtHan_ky1 != null)
			{
				((Control)_txtHan_ky1).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblNgay_Ss
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_Ss;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_Ss = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_Ss
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_Ss;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_Ss = value;
		}
	}

	internal virtual Label lblChi_xem
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblChi_xem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblChi_xem = value;
		}
	}

	internal virtual ComboBox cboChi_xem
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboChi_xem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboChi_xem = value;
		}
	}

	internal virtual Label lblSap_xep
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSap_xep;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSap_xep = value;
		}
	}

	internal virtual AsCheckBox ChkSap_xep
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkSap_xep;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkSap_xep = value;
		}
	}

	internal virtual Label lblHan_ky3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblHan_ky3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lblHan_ky3_Validated;
			if (_lblHan_ky3 != null)
			{
				((Control)_lblHan_ky3).Validated -= eventHandler;
			}
			_lblHan_ky3 = value;
			if (_lblHan_ky3 != null)
			{
				((Control)_lblHan_ky3).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtHan_ky3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHan_ky3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtHan_ky3 = value;
		}
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

	public frmAPRptBK02(string MenuId)
		: base(MenuId)
	{
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblMa_NhKh = new Label();
		txtMa_NhKh = new AsTextBox();
		lblTen_NhKh = new Label();
		txtNgay_Ss = new AsMaskedTextBox();
		lblNgay_Ss = new Label();
		txtHan_ky1 = new AsTextNumeric();
		lblHan_ky1 = new Label();
		lblHan_ky2 = new Label();
		txtHan_ky2 = new AsTextNumeric();
		lblHan_ky3 = new Label();
		txtHan_ky3 = new AsTextNumeric();
		ChkSap_xep = new AsCheckBox();
		lblSap_xep = new Label();
		cboChi_xem = new ComboBox();
		lblChi_xem = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)AsTabControl).Cursor = Cursors.Arrow;
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(580, 382);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblChi_xem);
		((Control)tabFilter).Controls.Add((Control)(object)cboChi_xem);
		((Control)tabFilter).Controls.Add((Control)(object)lblSap_xep);
		((Control)tabFilter).Controls.Add((Control)(object)ChkSap_xep);
		((Control)tabFilter).Controls.Add((Control)(object)lblHan_ky3);
		((Control)tabFilter).Controls.Add((Control)(object)txtHan_ky3);
		((Control)tabFilter).Controls.Add((Control)(object)lblHan_ky2);
		((Control)tabFilter).Controls.Add((Control)(object)txtHan_ky2);
		((Control)tabFilter).Controls.Add((Control)(object)lblHan_ky1);
		((Control)tabFilter).Controls.Add((Control)(object)txtHan_ky1);
		((Control)tabFilter).Controls.Add((Control)(object)lblNgay_Ss);
		((Control)tabFilter).Controls.Add((Control)(object)txtNgay_Ss);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_NhKh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_NhKh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_NhKh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Kh);
		((Control)tabFilter).Cursor = Cursors.Default;
		TabPage obj = tabFilter;
		size = new Size(572, 353);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_NhKh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_NhKh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_NhKh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay_Ss, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNgay_Ss, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtHan_ky1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblHan_ky1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtHan_ky2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblHan_ky2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtHan_ky3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblHan_ky3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkSap_xep, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSap_xep, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboChi_xem, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblChi_xem, 0);
		Label obj2 = lbl2;
		Point location = new Point(573, 366);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(700, 390);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(592, 362);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		((Control)txtNgay2).Visible = false;
		Button obj4 = cmdCancel;
		location = new Point(619, 390);
		((Control)obj4).Location = location;
		((Control)cmdModifyReport).TabIndex = 13;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(502, 362);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		((Control)txtNgay1).Visible = false;
		ComboBox obj5 = cboKyBc;
		location = new Point(406, 362);
		((Control)obj5).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		((Control)cboKyBc).Visible = false;
		Label obj6 = lblKyBc;
		location = new Point(320, 366);
		((Control)obj6).Location = location;
		((Control)lblKyBc).Visible = false;
		ComboBox obj7 = cboMau_bc;
		location = new Point(110, 24);
		((Control)obj7).Location = location;
		((Control)cboMau_bc).TabIndex = 12;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 283);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 8;
		Label obj8 = lblMauBC;
		location = new Point(155, 282);
		((Control)obj8).Location = location;
		RadioButton obj9 = optVND;
		location = new Point(235, 281);
		((Control)obj9).Location = location;
		((Control)optVND).TabIndex = 9;
		RadioButton obj10 = optNt;
		location = new Point(292, 282);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 10;
		Label obj11 = lblMa_nt;
		location = new Point(24, 285);
		((Control)obj11).Location = location;
		Button obj12 = cmdOk;
		location = new Point(27, 317);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 11;
		Label obj13 = lblTieu_de;
		location = new Point(24, 55);
		((Control)obj13).Location = location;
		TextBox obj14 = txtTieu_De;
		location = new Point(110, 51);
		((Control)obj14).Location = location;
		((Control)txtTieu_De).TabIndex = 14;
		TabPage obj15 = tabGrid;
		size = new Size(572, 353);
		((Control)obj15).Size = size;
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj16 = lblTen_Kh;
		location = new Point(206, 185);
		((Control)obj16).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj17 = lblTen_Kh;
		size = new Size(358, 13);
		((Control)obj17).Size = size;
		((Control)lblTen_Kh).TabIndex = 1036;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = false;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_Kh;
		location = new Point(110, 181);
		((Control)asTextBox2).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		txtMa_Kh.LookupWhereCondition = " 1=1";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		AsTextBox asTextBox3 = txtMa_Kh;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_Kh).TabIndex = 4;
		txtMa_Kh.UseAutoCompleteSource = true;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj18 = lblMa_Kh;
		location = new Point(24, 185);
		((Control)obj18).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj19 = lblMa_Kh;
		size = new Size(47, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_Kh).TabIndex = 1035;
		lblMa_Kh.Text = "Mã NCC";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblMa_NhKh.AutoSize = true;
		lblMa_NhKh.ImeMode = (ImeMode)0;
		Label obj20 = lblMa_NhKh;
		location = new Point(24, 211);
		((Control)obj20).Location = location;
		((Control)lblMa_NhKh).Name = "lblMa_NhKh";
		Label obj21 = lblMa_NhKh;
		size = new Size(60, 13);
		((Control)obj21).Size = size;
		((Control)lblMa_NhKh).TabIndex = 1086;
		lblMa_NhKh.Text = "Nhóm NCC";
		txtMa_NhKh.AutoLookup = true;
		txtMa_NhKh.AutoValid = false;
		((TextBoxBase)txtMa_NhKh).BackColor = SystemColors.Info;
		((TextBox)txtMa_NhKh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_NhKh;
		location = new Point(110, 207);
		((Control)asTextBox4).Location = location;
		txtMa_NhKh.LookupCodeName = "MA_NHKH";
		((TextBoxBase)txtMa_NhKh).MaxLength = 8;
		((Control)txtMa_NhKh).Name = "txtMa_NhKh";
		txtMa_NhKh.NameControl = lblTen_NhKh;
		AsTextBox asTextBox5 = txtMa_NhKh;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_NhKh).TabIndex = 5;
		((Control)txtMa_NhKh).Tag = "MA_NHKH";
		txtMa_NhKh.UseAutoCompleteSource = true;
		lblTen_NhKh.ImeMode = (ImeMode)0;
		Label obj22 = lblTen_NhKh;
		location = new Point(206, 211);
		((Control)obj22).Location = location;
		((Control)lblTen_NhKh).Name = "lblTen_NhKh";
		Label obj23 = lblTen_NhKh;
		size = new Size(358, 13);
		((Control)obj23).Size = size;
		((Control)lblTen_NhKh).TabIndex = 1089;
		txtNgay_Ss.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_Ss).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_Ss;
		location = new Point(110, 77);
		((Control)asMaskedTextBox3).Location = location;
		((MaskedTextBox)txtNgay_Ss).Mask = "##/##/####";
		((Control)txtNgay_Ss).Name = "txtNgay_Ss";
		((MaskedTextBox)txtNgay_Ss).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_Ss;
		size = new Size(90, 20);
		((Control)asMaskedTextBox4).Size = size;
		((Control)txtNgay_Ss).TabIndex = 0;
		((MaskedTextBox)txtNgay_Ss).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_Ss;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox5.Value = dateTime;
		lblNgay_Ss.AutoSize = true;
		lblNgay_Ss.ImeMode = (ImeMode)0;
		Label obj24 = lblNgay_Ss;
		location = new Point(24, 81);
		((Control)obj24).Location = location;
		((Control)lblNgay_Ss).Name = "lblNgay_Ss";
		Label obj25 = lblNgay_Ss;
		size = new Size(72, 13);
		((Control)obj25).Size = size;
		((Control)lblNgay_Ss).TabIndex = 1098;
		lblNgay_Ss.Text = "Ngày so sánh";
		lblNgay_Ss.TextAlign = (ContentAlignment)16;
		txtHan_ky1.DecimalSymbol = ".";
		txtHan_ky1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtHan_ky1;
		location = new Point(110, 103);
		((Control)asTextNumeric).Location = location;
		txtHan_ky1.Mask = "### ### ### ###";
		((Control)txtHan_ky1).Name = "txtHan_ky1";
		AsTextNumeric asTextNumeric2 = txtHan_ky1;
		size = new Size(90, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtHan_ky1).TabIndex = 1;
		((TextBox)txtHan_ky1).Text = "0";
		((TextBox)txtHan_ky1).TextAlign = (HorizontalAlignment)1;
		txtHan_ky1.Value = 0;
		lblHan_ky1.AutoSize = true;
		lblHan_ky1.ImeMode = (ImeMode)0;
		Label obj26 = lblHan_ky1;
		location = new Point(24, 107);
		((Control)obj26).Location = location;
		((Control)lblHan_ky1).Name = "lblHan_ky1";
		Label obj27 = lblHan_ky1;
		size = new Size(50, 13);
		((Control)obj27).Size = size;
		((Control)lblHan_ky1).TabIndex = 1100;
		lblHan_ky1.Text = "Hạn kỳ 1";
		lblHan_ky1.TextAlign = (ContentAlignment)16;
		lblHan_ky2.AutoSize = true;
		lblHan_ky2.ImeMode = (ImeMode)0;
		Label obj28 = lblHan_ky2;
		location = new Point(24, 133);
		((Control)obj28).Location = location;
		((Control)lblHan_ky2).Name = "lblHan_ky2";
		Label obj29 = lblHan_ky2;
		size = new Size(50, 13);
		((Control)obj29).Size = size;
		((Control)lblHan_ky2).TabIndex = 1102;
		lblHan_ky2.Text = "Hạn kỳ 2";
		lblHan_ky2.TextAlign = (ContentAlignment)16;
		txtHan_ky2.DecimalSymbol = ".";
		txtHan_ky2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtHan_ky2;
		location = new Point(110, 129);
		((Control)asTextNumeric3).Location = location;
		txtHan_ky2.Mask = "### ### ### ###";
		((Control)txtHan_ky2).Name = "txtHan_ky2";
		AsTextNumeric asTextNumeric4 = txtHan_ky2;
		size = new Size(90, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtHan_ky2).TabIndex = 2;
		((TextBox)txtHan_ky2).Text = "0";
		((TextBox)txtHan_ky2).TextAlign = (HorizontalAlignment)1;
		txtHan_ky2.Value = 0;
		lblHan_ky3.AutoSize = true;
		lblHan_ky3.ImeMode = (ImeMode)0;
		Label obj30 = lblHan_ky3;
		location = new Point(24, 159);
		((Control)obj30).Location = location;
		((Control)lblHan_ky3).Name = "lblHan_ky3";
		Label obj31 = lblHan_ky3;
		size = new Size(50, 13);
		((Control)obj31).Size = size;
		((Control)lblHan_ky3).TabIndex = 1104;
		lblHan_ky3.Text = "Hạn kỳ 3";
		lblHan_ky3.TextAlign = (ContentAlignment)16;
		txtHan_ky3.DecimalSymbol = ".";
		txtHan_ky3.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtHan_ky3;
		location = new Point(110, 155);
		((Control)asTextNumeric5).Location = location;
		txtHan_ky3.Mask = "### ### ### ###";
		((Control)txtHan_ky3).Name = "txtHan_ky3";
		AsTextNumeric asTextNumeric6 = txtHan_ky3;
		size = new Size(90, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtHan_ky3).TabIndex = 3;
		((TextBox)txtHan_ky3).Text = "0";
		((TextBox)txtHan_ky3).TextAlign = (HorizontalAlignment)1;
		txtHan_ky3.Value = 0;
		((ButtonBase)ChkSap_xep).AutoSize = true;
		ChkSap_xep.Checked = false;
		AsCheckBox chkSap_xep = ChkSap_xep;
		location = new Point(110, 233);
		((Control)chkSap_xep).Location = location;
		((Control)ChkSap_xep).Name = "ChkSap_xep";
		AsCheckBox chkSap_xep2 = ChkSap_xep;
		size = new Size(94, 17);
		((Control)chkSap_xep2).Size = size;
		((Control)ChkSap_xep).TabIndex = 6;
		((ButtonBase)ChkSap_xep).Text = "Nhà cung cấp";
		ChkSap_xep.TextValue = "0";
		((ButtonBase)ChkSap_xep).UseVisualStyleBackColor = true;
		lblSap_xep.AutoSize = true;
		lblSap_xep.ImeMode = (ImeMode)0;
		Label obj32 = lblSap_xep;
		location = new Point(24, 235);
		((Control)obj32).Location = location;
		((Control)lblSap_xep).Name = "lblSap_xep";
		Label obj33 = lblSap_xep;
		size = new Size(46, 13);
		((Control)obj33).Size = size;
		((Control)lblSap_xep).TabIndex = 1106;
		lblSap_xep.Text = "Sắp xếp";
		cboChi_xem.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboChi_xem).FormattingEnabled = true;
		cboChi_xem.Items.AddRange(new object[3] { "Các hóa đơn chưa tất toán", "Các hóa đơn đã tất toán", "Tất cả các hóa đơn" });
		ComboBox obj34 = cboChi_xem;
		location = new Point(110, 256);
		((Control)obj34).Location = location;
		((Control)cboChi_xem).Name = "cboChi_xem";
		ComboBox obj35 = cboChi_xem;
		size = new Size(173, 21);
		((Control)obj35).Size = size;
		((Control)cboChi_xem).TabIndex = 7;
		lblChi_xem.AutoSize = true;
		lblChi_xem.ImeMode = (ImeMode)0;
		Label obj36 = lblChi_xem;
		location = new Point(24, 260);
		((Control)obj36).Location = location;
		((Control)lblChi_xem).Name = "lblChi_xem";
		Label obj37 = lblChi_xem;
		size = new Size(44, 13);
		((Control)obj37).Size = size;
		((Control)lblChi_xem).TabIndex = 1108;
		lblChi_xem.Text = "Chỉ xem";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(580, 407);
		((Form)this).ClientSize = size;
		((Control)this).Cursor = Cursors.WaitCursor;
		((Control)this).Name = "frmAPRptBK02";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		txtNgay_Ss.Value = DateAndTime.Now.Date;
		cboChi_xem.SelectedIndex = 0;
		SOConfiguration sOConfiguration = new SOConfiguration();
		sOConfiguration = AsiaErp.Framework.Environment.GetSOConfiguration();
		if (!Null.IsNull(sOConfiguration))
		{
			txtHan_ky1.Value = sOConfiguration.han_tt_ss1;
			txtHan_ky2.Value = sOConfiguration.han_tt_ss2;
			txtHan_ky3.Value = sOConfiguration.han_tt_ss3;
		}
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay_Ss.Value));
		arrayList.Add(((TextBox)txtHan_ky1).Text.Trim());
		arrayList.Add(((TextBox)txtHan_ky2).Text.Trim());
		arrayList.Add(((TextBox)txtHan_ky3).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Kh).Text);
		arrayList.Add(((TextBox)txtMa_NhKh).Text);
		arrayList.Add(ChkSap_xep.TextValue);
		arrayList.Add(checked(cboChi_xem.SelectedIndex + 1).ToString());
		arrayList.Add(((TextBox)txtMa_Nt).Text.Trim());
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strSubTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(((MaskedTextBox)txtNgay_Ss).Text.Trim(), "", false) != 0)
		{
			text = text + lblNgay_Ss.Text + ": " + ((MaskedTextBox)txtNgay_Ss).Text.Trim() + "; ";
		}
		if (Operators.CompareString(((TextBox)txtHan_ky1).Text.Trim(), "", false) != 0)
		{
			text = text + lblHan_ky1.Text + ": " + ((TextBox)txtHan_ky1).Text.Trim() + "; ";
		}
		if (Operators.CompareString(((TextBox)txtHan_ky2).Text.Trim(), "", false) != 0)
		{
			text = text + lblHan_ky2.Text + ": " + ((TextBox)txtHan_ky2).Text.Trim() + "; ";
		}
		if (Operators.CompareString(((TextBox)txtHan_ky3).Text.Trim(), "", false) != 0)
		{
			text = text + lblHan_ky3.Text + ": " + ((TextBox)txtHan_ky3).Text.Trim() + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Kh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Kh.Text + ": " + ((TextBox)txtMa_Kh).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_NhKh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_NhKh.Text + ": " + ((TextBox)txtMa_NhKh).Text + "; ";
		}
		if (Conversions.ToBoolean(ChkSap_xep.Checked))
		{
			text = text + lblSap_xep.Text + ": " + ((ButtonBase)ChkSap_xep).Text.Trim();
		}
		if (cboChi_xem.SelectedIndex != -1)
		{
			text = text + lblChi_xem.Text + ": " + cboChi_xem.SelectedText + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
		}
		if (text.Length > 2)
		{
			text = text.Substring(0, checked(text.Length - 2));
		}
		return text;
	}

	private void txtHan_ky1_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectLess(txtHan_ky1.Value, (object)0, false))
		{
			epNotice.SetError((Control)(object)txtHan_ky1, Helper.GetMessContent(50017));
			((Control)txtHan_ky1).Select();
		}
	}

	private void txtHan_ky2_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectLess(txtHan_ky2.Value, (object)0, false))
		{
			epNotice.SetError((Control)(object)txtHan_ky2, Helper.GetMessContent(50017));
			((Control)txtHan_ky2).Select();
		}
	}

	private void lblHan_ky3_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectLess(txtHan_ky3.Value, (object)0, false))
		{
			epNotice.SetError((Control)(object)txtHan_ky3, Helper.GetMessContent(50017));
			((Control)txtHan_ky3).Select();
		}
	}
}
