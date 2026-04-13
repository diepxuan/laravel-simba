using System;
using System.Collections;
using System.Collections.Generic;
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
public class frmARRptBCCN06 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

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

	[AccessedThroughProperty("lblHan_ky3")]
	private Label _lblHan_ky3;

	[AccessedThroughProperty("txtHan_ky3")]
	private AsTextNumeric _txtHan_ky3;

	[AccessedThroughProperty("lblMadktt")]
	private Label _lblMadktt;

	[AccessedThroughProperty("txtMaTT")]
	private AsTextBox _txtMaTT;

	[AccessedThroughProperty("lblTen_dktt")]
	private Label _lblTen_dktt;

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
			EventHandler eventHandler = lblHan_ky2_Validated;
			if (_lblHan_ky2 != null)
			{
				((Control)_lblHan_ky2).Validated -= eventHandler;
			}
			_lblHan_ky2 = value;
			if (_lblHan_ky2 != null)
			{
				((Control)_lblHan_ky2).Validated += eventHandler;
			}
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
			_txtHan_ky2 = value;
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

	internal virtual Label lblMadktt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMadktt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMadktt = value;
		}
	}

	internal virtual AsTextBox txtMaTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMaTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMaTT = value;
		}
	}

	internal virtual Label lblTen_dktt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_dktt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_dktt = value;
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

	public frmARRptBCCN06(string MenuId)
		: base(MenuId)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
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
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
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
		lblMadktt = new Label();
		txtMaTT = new AsTextBox();
		lblTen_dktt = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)AsTabControl).Cursor = Cursors.Default;
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(580, 396);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblMadktt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMaTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_dktt);
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
		size = new Size(572, 367);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_dktt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMaTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMadktt, 0);
		Label obj2 = lbl2;
		Point location = new Point(573, 366);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(700, 410);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(592, 362);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		((Control)txtNgay2).Visible = false;
		Button obj4 = cmdCancel;
		location = new Point(619, 410);
		((Control)obj4).Location = location;
		((Control)cmdModifyReport).TabIndex = 12;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(502, 384);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		((Control)txtNgay1).Visible = false;
		ComboBox obj5 = cboKyBc;
		location = new Point(406, 384);
		((Control)obj5).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		((Control)cboKyBc).Visible = false;
		Label obj6 = lblKyBc;
		location = new Point(320, 388);
		((Control)obj6).Location = location;
		((Control)lblKyBc).Visible = false;
		ComboBox obj7 = cboMau_bc;
		location = new Point(110, 24);
		((Control)obj7).Location = location;
		((Control)cboMau_bc).TabIndex = 10;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 264);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 7;
		Label obj8 = lblMauBC;
		location = new Point(155, 263);
		((Control)obj8).Location = location;
		RadioButton obj9 = optVND;
		location = new Point(235, 262);
		((Control)obj9).Location = location;
		((Control)optVND).TabIndex = 8;
		RadioButton obj10 = optNt;
		location = new Point(292, 263);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 19;
		Label obj11 = lblMa_nt;
		location = new Point(24, 266);
		((Control)obj11).Location = location;
		Button obj12 = cmdOk;
		location = new Point(27, 296);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 9;
		Label obj13 = lblTieu_de;
		location = new Point(24, 55);
		((Control)obj13).Location = location;
		TextBox obj14 = txtTieu_De;
		location = new Point(110, 51);
		((Control)obj14).Location = location;
		((Control)txtTieu_De).TabIndex = 11;
		TabPage obj15 = tabGrid;
		size = new Size(572, 367);
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
		txtMa_Kh.LookupWhereCondition = "isKh=1";
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
		size = new Size(55, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_Kh).TabIndex = 1035;
		lblMa_Kh.Text = "Mã khách";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblMa_NhKh.AutoSize = true;
		lblMa_NhKh.ImeMode = (ImeMode)0;
		Label obj20 = lblMa_NhKh;
		location = new Point(24, 211);
		((Control)obj20).Location = location;
		((Control)lblMa_NhKh).Name = "lblMa_NhKh";
		Label obj21 = lblMa_NhKh;
		size = new Size(69, 13);
		((Control)obj21).Size = size;
		((Control)lblMa_NhKh).TabIndex = 1086;
		lblMa_NhKh.Text = "Mã nhóm KH";
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
		txtHan_ky1.SpecialType = Commons.NumericSpecialType.Other;
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
		txtHan_ky2.SpecialType = Commons.NumericSpecialType.Other;
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
		txtHan_ky3.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtHan_ky3).TabIndex = 3;
		((TextBox)txtHan_ky3).Text = "0";
		((TextBox)txtHan_ky3).TextAlign = (HorizontalAlignment)1;
		txtHan_ky3.Value = 0;
		lblMadktt.AutoSize = true;
		lblMadktt.ImeMode = (ImeMode)0;
		Label obj32 = lblMadktt;
		location = new Point(24, 237);
		((Control)obj32).Location = location;
		((Control)lblMadktt).Name = "lblMadktt";
		Label obj33 = lblMadktt;
		size = new Size(79, 13);
		((Control)obj33).Size = size;
		((Control)lblMadktt).TabIndex = 1110;
		lblMadktt.Text = "Điều khoản TT";
		txtMaTT.AutoLookup = true;
		txtMaTT.AutoValid = false;
		((TextBoxBase)txtMaTT).BackColor = SystemColors.Info;
		((TextBox)txtMaTT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMaTT;
		location = new Point(110, 233);
		((Control)asTextBox6).Location = location;
		txtMaTT.LookupCodeName = "MA_TT";
		((TextBoxBase)txtMaTT).MaxLength = 8;
		((Control)txtMaTT).Name = "txtMaTT";
		txtMaTT.NameControl = lblTen_dktt;
		AsTextBox asTextBox7 = txtMaTT;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMaTT).TabIndex = 6;
		((Control)txtMaTT).Tag = "MA_TT";
		txtMaTT.UseAutoCompleteSource = true;
		lblTen_dktt.ImeMode = (ImeMode)0;
		Label obj34 = lblTen_dktt;
		location = new Point(206, 237);
		((Control)obj34).Location = location;
		((Control)lblTen_dktt).Name = "lblTen_dktt";
		Label obj35 = lblTen_dktt;
		size = new Size(358, 13);
		((Control)obj35).Size = size;
		((Control)lblTen_dktt).TabIndex = 1111;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(580, 421);
		((Form)this).ClientSize = size;
		((Control)this).Cursor = Cursors.Arrow;
		((Control)this).Name = "frmARRptBCCN06";
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
		txtHan_ky1.Value = AsiaErp.Framework.Environment.GetSOConfiguration().han_tt_ss1;
		txtHan_ky2.Value = AsiaErp.Framework.Environment.GetSOConfiguration().han_tt_ss2;
		txtHan_ky3.Value = AsiaErp.Framework.Environment.GetSOConfiguration().han_tt_ss3;
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
		arrayList.Add(((TextBox)txtMa_Nt).Text.Trim());
		arrayList.Add(((TextBox)txtMaTT).Text.Trim());
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		base.MyFomularFields.Add("han_ky1", ((TextBox)txtHan_ky1).Text);
		base.MyFomularFields.Add("han_ky2", ((TextBox)txtHan_ky2).Text);
		base.MyFomularFields.Add("han_ky3", ((TextBox)txtHan_ky3).Text);
		cboKyBc.SelectedIndex = checked(Conversions.ToDate(txtNgay_Ss.Value).Month - 1);
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
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
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

	private void lblHan_ky2_Validated(object sender, EventArgs e)
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
