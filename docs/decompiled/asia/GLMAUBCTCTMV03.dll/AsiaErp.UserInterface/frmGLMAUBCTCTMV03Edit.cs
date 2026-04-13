using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLMAUBCTCTMV03Edit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("lblTK")]
	private Label _lblTK;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtTaikhoan")]
	private AsTextBox _txtTaikhoan;

	[AccessedThroughProperty("txtCach_tinh")]
	private TextBox _txtCach_tinh;

	[AccessedThroughProperty("txtNd_chtieu")]
	private TextBox _txtNd_chtieu;

	[AccessedThroughProperty("txtChi_tieu")]
	private TextBox _txtChi_tieu;

	[AccessedThroughProperty("txtMa_chtieu")]
	private AsTextBox _txtMa_chtieu;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtMauQD")]
	private AsTextBox _txtMauQD;

	[AccessedThroughProperty("cboLoai_ps_dk")]
	private AsComboBox _cboLoai_ps_dk;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("cboLoai_ps_ck")]
	private AsComboBox _cboLoai_ps_ck;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("ChkIs_italic")]
	private CheckBox _ChkIs_italic;

	[AccessedThroughProperty("ChkIs_print")]
	private CheckBox _ChkIs_print;

	private static ArrayList oLoaiPS_DK;

	private static ArrayList oLoaiPS_CK;

	internal virtual Label lblTK
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual AsTextBox txtTaikhoan
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTaikhoan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTaikhoan = value;
		}
	}

	internal virtual TextBox txtCach_tinh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCach_tinh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCach_tinh = value;
		}
	}

	internal virtual TextBox txtNd_chtieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNd_chtieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNd_chtieu = value;
		}
	}

	internal virtual TextBox txtChi_tieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtChi_tieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtChi_tieu = value;
		}
	}

	internal virtual AsTextBox txtMa_chtieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_chtieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_chtieu = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual AsTextBox txtMauQD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMauQD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMauQD = value;
		}
	}

	internal virtual AsComboBox cboLoai_ps_dk
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_ps_dk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_ps_dk = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual AsComboBox cboLoai_ps_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_ps_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_ps_ck = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual CheckBox ChkIs_italic
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkIs_italic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkIs_italic = value;
		}
	}

	internal virtual CheckBox ChkIs_print
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkIs_print;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkIs_print = value;
		}
	}

	private static ArrayList LoaiPS_DK
	{
		get
		{
			if (oLoaiPS_DK == null)
			{
				oLoaiPS_DK = new ArrayList();
				ArrayList arrayList = oLoaiPS_DK;
				DictionaryEntry dictionaryEntry = new DictionaryEntry("", "");
				arrayList.Add(dictionaryEntry);
				ArrayList arrayList2 = oLoaiPS_DK;
				dictionaryEntry = new DictionaryEntry("NODK", "Dư nợ đầu kỳ");
				arrayList2.Add(dictionaryEntry);
				ArrayList arrayList3 = oLoaiPS_DK;
				dictionaryEntry = new DictionaryEntry("CODK", "Dư có đầu kỳ");
				arrayList3.Add(dictionaryEntry);
				ArrayList arrayList4 = oLoaiPS_DK;
				dictionaryEntry = new DictionaryEntry("NODKCN", "Dư nợ đầu kỳ công nợ");
				arrayList4.Add(dictionaryEntry);
				ArrayList arrayList5 = oLoaiPS_DK;
				dictionaryEntry = new DictionaryEntry("CODKCN", "Dư có đầu kỳ công nợ");
				arrayList5.Add(dictionaryEntry);
			}
			return oLoaiPS_DK;
		}
	}

	private static ArrayList LoaiPS_CK
	{
		get
		{
			if (oLoaiPS_CK == null)
			{
				oLoaiPS_CK = new ArrayList();
				ArrayList arrayList = oLoaiPS_CK;
				DictionaryEntry dictionaryEntry = new DictionaryEntry("", "");
				arrayList.Add(dictionaryEntry);
				ArrayList arrayList2 = oLoaiPS_CK;
				dictionaryEntry = new DictionaryEntry("NOCK", "Dư nợ cuối kỳ");
				arrayList2.Add(dictionaryEntry);
				ArrayList arrayList3 = oLoaiPS_CK;
				dictionaryEntry = new DictionaryEntry("COCK", "Dư có cuối kỳ");
				arrayList3.Add(dictionaryEntry);
				ArrayList arrayList4 = oLoaiPS_CK;
				dictionaryEntry = new DictionaryEntry("NOCKCN", "Dư nợ cuối kỳ công nợ");
				arrayList4.Add(dictionaryEntry);
				ArrayList arrayList5 = oLoaiPS_CK;
				dictionaryEntry = new DictionaryEntry("COCKCN", "Dư có cuối kỳ công nợ");
				arrayList5.Add(dictionaryEntry);
			}
			return oLoaiPS_CK;
		}
	}

	[DebuggerNonUserCode]
	public frmGLMAUBCTCTMV03Edit()
	{
		((Form)this).Load += frmGLMAUBCTCTMV03Edit_Load;
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		lblTK = new Label();
		Label8 = new Label();
		txtTaikhoan = new AsTextBox();
		txtCach_tinh = new TextBox();
		txtNd_chtieu = new TextBox();
		txtChi_tieu = new TextBox();
		txtMa_chtieu = new AsTextBox();
		Label6 = new Label();
		Label4 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		txtMauQD = new AsTextBox();
		cboLoai_ps_dk = new AsComboBox();
		Label7 = new Label();
		cboLoai_ps_ck = new AsComboBox();
		Label3 = new Label();
		ChkIs_italic = new CheckBox();
		ChkIs_print = new CheckBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(258, 282);
		((Control)asCheckBox).Location = location;
		AsCheckBox asCheckBox2 = chkKsd;
		Size size = new Size(59, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkKsd).TabIndex = 9;
		((Control)chkKsd).TabStop = true;
		((ButtonBase)chkKsd).Text = "In đậm";
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 321);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 321);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)ChkIs_italic);
		((Control)gbLine).Controls.Add((Control)(object)ChkIs_print);
		((Control)gbLine).Controls.Add((Control)(object)cboLoai_ps_ck);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)cboLoai_ps_dk);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)txtCach_tinh);
		((Control)gbLine).Controls.Add((Control)(object)txtNd_chtieu);
		((Control)gbLine).Controls.Add((Control)(object)txtChi_tieu);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_chtieu);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)lblTK);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)txtTaikhoan);
		GroupBox obj3 = gbLine;
		size = new Size(620, 309);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTaikhoan, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_chtieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtChi_tieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNd_chtieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtCach_tinh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai_ps_dk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai_ps_ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)ChkIs_print, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)ChkIs_italic, 0);
		Label obj4 = lblTK;
		location = new Point(206, 201);
		((Control)obj4).Location = location;
		((Control)lblTK).Name = "lblTK";
		Label obj5 = lblTK;
		size = new Size(388, 20);
		((Control)obj5).Size = size;
		((Control)lblTK).TabIndex = 164;
		lblTK.TextAlign = (ContentAlignment)16;
		Label8.AutoSize = true;
		Label label = Label8;
		location = new Point(15, 206);
		((Control)label).Location = location;
		((Control)Label8).Name = "Label8";
		Label label2 = Label8;
		size = new Size(55, 13);
		((Control)label2).Size = size;
		((Control)Label8).TabIndex = 163;
		Label8.Text = "Tài khoản";
		txtTaikhoan.AutoLookup = true;
		txtTaikhoan.AutoValid = true;
		((TextBoxBase)txtTaikhoan).BackColor = SystemColors.Info;
		((TextBox)txtTaikhoan).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTaikhoan;
		location = new Point(120, 202);
		((Control)asTextBox).Location = location;
		txtTaikhoan.LookupCodeName = "TK";
		((Control)txtTaikhoan).Name = "txtTaikhoan";
		txtTaikhoan.NameControl = lblTK;
		AsTextBox asTextBox2 = txtTaikhoan;
		size = new Size(80, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTaikhoan).TabIndex = 4;
		txtTaikhoan.UseAutoCompleteSource = true;
		TextBox obj6 = txtCach_tinh;
		location = new Point(120, 176);
		((Control)obj6).Location = location;
		((TextBoxBase)txtCach_tinh).MaxLength = 50;
		((Control)txtCach_tinh).Name = "txtCach_tinh";
		TextBox obj7 = txtCach_tinh;
		size = new Size(484, 20);
		((Control)obj7).Size = size;
		((Control)txtCach_tinh).TabIndex = 3;
		TextBox obj8 = txtNd_chtieu;
		location = new Point(120, 72);
		((Control)obj8).Location = location;
		txtNd_chtieu.Multiline = true;
		((Control)txtNd_chtieu).Name = "txtNd_chtieu";
		txtNd_chtieu.ScrollBars = (ScrollBars)2;
		TextBox obj9 = txtNd_chtieu;
		size = new Size(484, 98);
		((Control)obj9).Size = size;
		((Control)txtNd_chtieu).TabIndex = 2;
		TextBox obj10 = txtChi_tieu;
		location = new Point(120, 45);
		((Control)obj10).Location = location;
		((Control)txtChi_tieu).Name = "txtChi_tieu";
		TextBox obj11 = txtChi_tieu;
		size = new Size(484, 20);
		((Control)obj11).Size = size;
		((Control)txtChi_tieu).TabIndex = 1;
		txtMa_chtieu.AutoLookup = false;
		txtMa_chtieu.AutoValid = false;
		((TextBoxBase)txtMa_chtieu).BackColor = SystemColors.Window;
		((TextBox)txtMa_chtieu).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_chtieu;
		location = new Point(120, 19);
		((Control)asTextBox3).Location = location;
		txtMa_chtieu.LookupCodeName = "";
		((Control)txtMa_chtieu).Name = "txtMa_chtieu";
		txtMa_chtieu.NameControl = null;
		AsTextBox asTextBox4 = txtMa_chtieu;
		size = new Size(80, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_chtieu).TabIndex = 0;
		txtMa_chtieu.UseAutoCompleteSource = true;
		Label6.AutoSize = true;
		Label label3 = Label6;
		location = new Point(15, 180);
		((Control)label3).Location = location;
		((Control)Label6).Name = "Label6";
		Label label4 = Label6;
		size = new Size(56, 13);
		((Control)label4).Size = size;
		((Control)Label6).TabIndex = 170;
		Label6.Text = "Công thức";
		Label4.AutoSize = true;
		Label label5 = Label4;
		location = new Point(15, 72);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		Label label6 = Label4;
		size = new Size(87, 13);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 168;
		Label4.Text = "Nội dung chỉ tiêu";
		Label2.AutoSize = true;
		Label label7 = Label2;
		location = new Point(15, 48);
		((Control)label7).Location = location;
		((Control)Label2).Name = "Label2";
		Label label8 = Label2;
		size = new Size(42, 13);
		((Control)label8).Size = size;
		((Control)Label2).TabIndex = 166;
		Label2.Text = "Chỉ tiêu";
		Label1.AutoSize = true;
		Label label9 = Label1;
		location = new Point(15, 23);
		((Control)label9).Location = location;
		((Control)Label1).Name = "Label1";
		Label label10 = Label1;
		size = new Size(59, 13);
		((Control)label10).Size = size;
		((Control)Label1).TabIndex = 165;
		Label1.Text = "Mã chỉ tiêu";
		txtMauQD.AutoLookup = false;
		txtMauQD.AutoValid = false;
		((TextBoxBase)txtMauQD).BackColor = SystemColors.Window;
		((TextBox)txtMauQD).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMauQD;
		location = new Point(536, 25);
		((Control)asTextBox5).Location = location;
		txtMauQD.LookupCodeName = "";
		((Control)txtMauQD).Name = "txtMauQD";
		txtMauQD.NameControl = null;
		AsTextBox asTextBox6 = txtMauQD;
		size = new Size(80, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMauQD).TabIndex = 173;
		((Control)txtMauQD).TabStop = false;
		txtMauQD.UseAutoCompleteSource = true;
		((ComboBox)cboLoai_ps_dk).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_ps_dk).FormattingEnabled = true;
		AsComboBox asComboBox = cboLoai_ps_dk;
		location = new Point(120, 228);
		((Control)asComboBox).Location = location;
		((Control)cboLoai_ps_dk).Name = "cboLoai_ps_dk";
		AsComboBox asComboBox2 = cboLoai_ps_dk;
		size = new Size(197, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboLoai_ps_dk).TabIndex = 5;
		Label7.AutoSize = true;
		Label label11 = Label7;
		location = new Point(15, 232);
		((Control)label11).Location = location;
		((Control)Label7).Name = "Label7";
		Label label12 = Label7;
		size = new Size(60, 13);
		((Control)label12).Size = size;
		((Control)Label7).TabIndex = 172;
		Label7.Text = "Loại dư ĐK";
		((ComboBox)cboLoai_ps_ck).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_ps_ck).FormattingEnabled = true;
		AsComboBox asComboBox3 = cboLoai_ps_ck;
		location = new Point(120, 255);
		((Control)asComboBox3).Location = location;
		((Control)cboLoai_ps_ck).Name = "cboLoai_ps_ck";
		AsComboBox asComboBox4 = cboLoai_ps_ck;
		size = new Size(197, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboLoai_ps_ck).TabIndex = 6;
		Label3.AutoSize = true;
		Label label13 = Label3;
		location = new Point(15, 259);
		((Control)label13).Location = location;
		((Control)Label3).Name = "Label3";
		Label label14 = Label3;
		size = new Size(59, 13);
		((Control)label14).Size = size;
		((Control)Label3).TabIndex = 174;
		Label3.Text = "Loại dư CK";
		((ButtonBase)ChkIs_italic).AutoSize = true;
		CheckBox chkIs_italic = ChkIs_italic;
		location = new Point(176, 282);
		((Control)chkIs_italic).Location = location;
		((Control)ChkIs_italic).Name = "ChkIs_italic";
		CheckBox chkIs_italic2 = ChkIs_italic;
		size = new Size(76, 17);
		((Control)chkIs_italic2).Size = size;
		((Control)ChkIs_italic).TabIndex = 8;
		((ButtonBase)ChkIs_italic).Text = "In nghiêng";
		((ButtonBase)ChkIs_italic).UseVisualStyleBackColor = true;
		((ButtonBase)ChkIs_print).AutoSize = true;
		CheckBox chkIs_print = ChkIs_print;
		location = new Point(120, 282);
		((Control)chkIs_print).Location = location;
		((Control)ChkIs_print).Name = "ChkIs_print";
		CheckBox chkIs_print2 = ChkIs_print;
		size = new Size(50, 17);
		((Control)chkIs_print2).Size = size;
		((Control)ChkIs_print).TabIndex = 7;
		((ButtonBase)ChkIs_print).Text = "Có in";
		((ButtonBase)ChkIs_print).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(644, 356);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtMauQD);
		((Control)this).Name = "frmGLMAUBCTCTMV03Edit";
		((Control)this).Controls.SetChildIndex((Control)(object)txtMauQD, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbLine, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSave, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((ComboBox)cboLoai_ps_dk).DataSource = LoaiPS_DK;
		((ListControl)cboLoai_ps_dk).ValueMember = "Key";
		((ListControl)cboLoai_ps_dk).DisplayMember = "Value";
		((ComboBox)cboLoai_ps_dk).SelectedIndex = -1;
		((ComboBox)cboLoai_ps_ck).DataSource = LoaiPS_CK;
		((ListControl)cboLoai_ps_ck).ValueMember = "Key";
		((ListControl)cboLoai_ps_ck).DisplayMember = "Value";
		((ComboBox)cboLoai_ps_ck).SelectedIndex = -1;
		((TextBoxBase)txtMa_chtieu).MaxLength = base.MyDictComplexInfo.code_length;
		((Control)txtMa_chtieu).Select();
	}

	protected override bool ValidData()
	{
		txtNd_chtieu.Text = txtNd_chtieu.Text.Trim();
		if (Operators.CompareString(((TextBox)txtMauQD).Text.Trim(), "", false) == 0)
		{
			((TextBox)txtMauQD).Text = CompanyInformations.Qd_cdkt;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_chtieu))
		{
			epNotice.SetError((Control)(object)txtMa_chtieu, Helper.GetMess(50002).Description);
			((Control)txtMa_chtieu).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtChi_tieu))
		{
			epNotice.SetError((Control)(object)txtChi_tieu, Helper.GetMess(50002).Description);
			((Control)txtChi_tieu).Select();
			return false;
		}
		return base.ValidData();
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_chtieu).Select();
		}
		return flag;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMauQD).Enabled = false;
		((Control)txtMa_chtieu).Enabled = false;
		((Control)txtChi_tieu).Select();
	}

	protected override void DataBinding()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMauQD;
		CreateDataBinding(ref ojb, "mau");
		txtMauQD = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_chtieu;
		CreateDataBinding(ref ojb, "ma_so");
		txtMa_chtieu = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtChi_tieu;
		CreateDataBinding(ref ojb, "chi_tieu");
		txtChi_tieu = (TextBox)ojb;
		ojb = (Control)(object)txtNd_chtieu;
		CreateDataBinding(ref ojb, "nd_chtieu");
		txtNd_chtieu = (TextBox)ojb;
		ojb = (Control)(object)txtCach_tinh;
		CreateDataBinding(ref ojb, "cach_tinh");
		txtCach_tinh = (TextBox)ojb;
		ojb = (Control)(object)cboLoai_ps_dk;
		CreateDataBinding(ref ojb, "loai_ps_dk", "SelectedValue");
		cboLoai_ps_dk = (AsComboBox)(object)ojb;
		ojb = (Control)(object)cboLoai_ps_ck;
		CreateDataBinding(ref ojb, "loai_ps_ck", "SelectedValue");
		cboLoai_ps_ck = (AsComboBox)(object)ojb;
		ojb = (Control)(object)txtTaikhoan;
		CreateDataBinding(ref ojb, "tk_01");
		txtTaikhoan = (AsTextBox)(object)ojb;
		ojb = (Control)(object)ChkIs_italic;
		CreateDataBinding(ref ojb, "IsItalic", "Checked");
		ChkIs_italic = (CheckBox)ojb;
		ojb = (Control)(object)ChkIs_print;
		CreateDataBinding(ref ojb, "IsPrint", "Checked");
		ChkIs_print = (CheckBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "bold", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	private void frmGLMAUBCTCTMV03Edit_Load(object sender, EventArgs e)
	{
		if (!EditMode)
		{
			ChkIs_print.Checked = true;
		}
	}

	protected override bool ProcessKeyPreview(ref Message m)
	{
		if (!((Control)txtNd_chtieu).Focused)
		{
			return base.ProcessKeyPreview(ref m);
		}
		bool result = default(bool);
		return result;
	}
}
