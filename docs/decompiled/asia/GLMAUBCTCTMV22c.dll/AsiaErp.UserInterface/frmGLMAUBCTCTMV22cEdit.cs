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
public class frmGLMAUBCTCTMV22cEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("txtCach_tinh")]
	private TextBox _txtCach_tinh;

	[AccessedThroughProperty("txtNd_chtieu")]
	private TextBox _txtNd_chtieu;

	[AccessedThroughProperty("txtChi_tieu")]
	private TextBox _txtChi_tieu;

	[AccessedThroughProperty("lblTK")]
	private Label _lblTK;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtTaikhoan")]
	private AsTextBox _txtTaikhoan;

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
	private TextBox _txtMauQD;

	[AccessedThroughProperty("ChkIs_italic")]
	private CheckBox _ChkIs_italic;

	[AccessedThroughProperty("ChkIs_print")]
	private CheckBox _ChkIs_print;

	[AccessedThroughProperty("cboLoai_ps")]
	private AsComboBox _cboLoai_ps;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	private static ArrayList oLoaiPS;

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

	internal virtual TextBox txtMauQD
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

	internal virtual AsComboBox cboLoai_ps
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_ps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_ps = value;
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

	private static ArrayList LoaiPS
	{
		get
		{
			if (oLoaiPS == null)
			{
				oLoaiPS = new ArrayList();
				ArrayList arrayList = oLoaiPS;
				DictionaryEntry dictionaryEntry = new DictionaryEntry("", "");
				arrayList.Add(dictionaryEntry);
				ArrayList arrayList2 = oLoaiPS;
				dictionaryEntry = new DictionaryEntry("NODK", "Dư nợ đầu kỳ");
				arrayList2.Add(dictionaryEntry);
				ArrayList arrayList3 = oLoaiPS;
				dictionaryEntry = new DictionaryEntry("CODK", "Dư có đầu kỳ");
				arrayList3.Add(dictionaryEntry);
				ArrayList arrayList4 = oLoaiPS;
				dictionaryEntry = new DictionaryEntry("NOCK", "Dư nợ cuối kỳ");
				arrayList4.Add(dictionaryEntry);
				ArrayList arrayList5 = oLoaiPS;
				dictionaryEntry = new DictionaryEntry("COCK", "Dư có cuối kỳ");
				arrayList5.Add(dictionaryEntry);
				ArrayList arrayList6 = oLoaiPS;
				dictionaryEntry = new DictionaryEntry("PSNO", "Phát sinh nợ");
				arrayList6.Add(dictionaryEntry);
				ArrayList arrayList7 = oLoaiPS;
				dictionaryEntry = new DictionaryEntry("PSCO", "Phát sinh có");
				arrayList7.Add(dictionaryEntry);
			}
			return oLoaiPS;
		}
	}

	[DebuggerNonUserCode]
	public frmGLMAUBCTCTMV22cEdit()
	{
		((Form)this).Load += frmGLMAUBCTCTMV22CEdit_Load;
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
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
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		txtCach_tinh = new TextBox();
		txtNd_chtieu = new TextBox();
		txtChi_tieu = new TextBox();
		lblTK = new Label();
		Label8 = new Label();
		txtTaikhoan = new AsTextBox();
		txtMa_chtieu = new AsTextBox();
		Label6 = new Label();
		Label4 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		txtMauQD = new TextBox();
		ChkIs_italic = new CheckBox();
		ChkIs_print = new CheckBox();
		cboLoai_ps = new AsComboBox();
		Label7 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(257, 284);
		((Control)asCheckBox).Location = location;
		AsCheckBox asCheckBox2 = chkKsd;
		Size size = new Size(59, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkKsd).TabIndex = 8;
		((Control)chkKsd).TabStop = true;
		((ButtonBase)chkKsd).Text = "In đậm";
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 324);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 324);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)cboLoai_ps);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)ChkIs_italic);
		((Control)gbLine).Controls.Add((Control)(object)ChkIs_print);
		((Control)gbLine).Controls.Add((Control)(object)txtCach_tinh);
		((Control)gbLine).Controls.Add((Control)(object)txtNd_chtieu);
		((Control)gbLine).Controls.Add((Control)(object)txtChi_tieu);
		((Control)gbLine).Controls.Add((Control)(object)lblTK);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)txtTaikhoan);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_chtieu);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		GroupBox obj3 = gbLine;
		size = new Size(621, 312);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_chtieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTaikhoan, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtChi_tieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNd_chtieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtCach_tinh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)ChkIs_print, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)ChkIs_italic, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai_ps, 0);
		TextBox obj4 = txtCach_tinh;
		location = new Point(119, 205);
		((Control)obj4).Location = location;
		((TextBoxBase)txtCach_tinh).MaxLength = 50;
		((Control)txtCach_tinh).Name = "txtCach_tinh";
		TextBox obj5 = txtCach_tinh;
		size = new Size(484, 20);
		((Control)obj5).Size = size;
		((Control)txtCach_tinh).TabIndex = 3;
		TextBox obj6 = txtNd_chtieu;
		location = new Point(119, 72);
		((Control)obj6).Location = location;
		txtNd_chtieu.Multiline = true;
		((Control)txtNd_chtieu).Name = "txtNd_chtieu";
		txtNd_chtieu.ScrollBars = (ScrollBars)2;
		TextBox obj7 = txtNd_chtieu;
		size = new Size(484, 127);
		((Control)obj7).Size = size;
		((Control)txtNd_chtieu).TabIndex = 2;
		TextBox obj8 = txtChi_tieu;
		location = new Point(119, 45);
		((Control)obj8).Location = location;
		((Control)txtChi_tieu).Name = "txtChi_tieu";
		TextBox obj9 = txtChi_tieu;
		size = new Size(484, 20);
		((Control)obj9).Size = size;
		((Control)txtChi_tieu).TabIndex = 1;
		Label obj10 = lblTK;
		location = new Point(197, 231);
		((Control)obj10).Location = location;
		((Control)lblTK).Name = "lblTK";
		Label obj11 = lblTK;
		size = new Size(404, 20);
		((Control)obj11).Size = size;
		((Control)lblTK).TabIndex = 147;
		lblTK.TextAlign = (ContentAlignment)16;
		Label8.AutoSize = true;
		Label label = Label8;
		location = new Point(12, 235);
		((Control)label).Location = location;
		((Control)Label8).Name = "Label8";
		Label label2 = Label8;
		size = new Size(55, 13);
		((Control)label2).Size = size;
		((Control)Label8).TabIndex = 146;
		Label8.Text = "Tài khoản";
		txtTaikhoan.AutoLookup = true;
		txtTaikhoan.AutoValid = true;
		((TextBoxBase)txtTaikhoan).BackColor = SystemColors.Info;
		((TextBox)txtTaikhoan).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTaikhoan;
		location = new Point(117, 231);
		((Control)asTextBox).Location = location;
		txtTaikhoan.LookupCodeName = "TK";
		((Control)txtTaikhoan).Name = "txtTaikhoan";
		txtTaikhoan.NameControl = lblTK;
		AsTextBox asTextBox2 = txtTaikhoan;
		size = new Size(74, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTaikhoan).TabIndex = 4;
		txtTaikhoan.UseAutoCompleteSource = true;
		txtMa_chtieu.AutoLookup = false;
		txtMa_chtieu.AutoValid = false;
		((TextBoxBase)txtMa_chtieu).BackColor = SystemColors.Window;
		((TextBox)txtMa_chtieu).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_chtieu;
		location = new Point(119, 19);
		((Control)asTextBox3).Location = location;
		txtMa_chtieu.LookupCodeName = "";
		((Control)txtMa_chtieu).Name = "txtMa_chtieu";
		txtMa_chtieu.NameControl = null;
		AsTextBox asTextBox4 = txtMa_chtieu;
		size = new Size(74, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_chtieu).TabIndex = 0;
		txtMa_chtieu.UseAutoCompleteSource = true;
		Label6.AutoSize = true;
		Label label3 = Label6;
		location = new Point(14, 209);
		((Control)label3).Location = location;
		((Control)Label6).Name = "Label6";
		Label label4 = Label6;
		size = new Size(56, 13);
		((Control)label4).Size = size;
		((Control)Label6).TabIndex = 136;
		Label6.Text = "Công thức";
		Label4.AutoSize = true;
		Label label5 = Label4;
		location = new Point(14, 72);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		Label label6 = Label4;
		size = new Size(87, 13);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 134;
		Label4.Text = "Nội dung chỉ tiêu";
		Label2.AutoSize = true;
		Label label7 = Label2;
		location = new Point(14, 49);
		((Control)label7).Location = location;
		((Control)Label2).Name = "Label2";
		Label label8 = Label2;
		size = new Size(42, 13);
		((Control)label8).Size = size;
		((Control)Label2).TabIndex = 132;
		Label2.Text = "Chỉ tiêu";
		Label1.AutoSize = true;
		Label label9 = Label1;
		location = new Point(14, 23);
		((Control)label9).Location = location;
		((Control)Label1).Name = "Label1";
		Label label10 = Label1;
		size = new Size(59, 13);
		((Control)label10).Size = size;
		((Control)Label1).TabIndex = 131;
		Label1.Text = "Mã chỉ tiêu";
		TextBox obj12 = txtMauQD;
		location = new Point(541, 26);
		((Control)obj12).Location = location;
		((Control)txtMauQD).Name = "txtMauQD";
		TextBox obj13 = txtMauQD;
		size = new Size(74, 20);
		((Control)obj13).Size = size;
		((Control)txtMauQD).TabIndex = 145;
		((Control)txtMauQD).TabStop = false;
		((ButtonBase)ChkIs_italic).AutoSize = true;
		CheckBox chkIs_italic = ChkIs_italic;
		location = new Point(175, 284);
		((Control)chkIs_italic).Location = location;
		((Control)ChkIs_italic).Name = "ChkIs_italic";
		CheckBox chkIs_italic2 = ChkIs_italic;
		size = new Size(76, 17);
		((Control)chkIs_italic2).Size = size;
		((Control)ChkIs_italic).TabIndex = 7;
		((ButtonBase)ChkIs_italic).Text = "In nghiêng";
		((ButtonBase)ChkIs_italic).UseVisualStyleBackColor = true;
		((ButtonBase)ChkIs_print).AutoSize = true;
		CheckBox chkIs_print = ChkIs_print;
		location = new Point(119, 284);
		((Control)chkIs_print).Location = location;
		((Control)ChkIs_print).Name = "ChkIs_print";
		CheckBox chkIs_print2 = ChkIs_print;
		size = new Size(50, 17);
		((Control)chkIs_print2).Size = size;
		((Control)ChkIs_print).TabIndex = 6;
		((ButtonBase)ChkIs_print).Text = "Có in";
		((ButtonBase)ChkIs_print).UseVisualStyleBackColor = true;
		((ComboBox)cboLoai_ps).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_ps).FormattingEnabled = true;
		AsComboBox asComboBox = cboLoai_ps;
		location = new Point(117, 257);
		((Control)asComboBox).Location = location;
		((Control)cboLoai_ps).Name = "cboLoai_ps";
		AsComboBox asComboBox2 = cboLoai_ps;
		size = new Size(197, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboLoai_ps).TabIndex = 5;
		Label7.AutoSize = true;
		Label label11 = Label7;
		location = new Point(12, 261);
		((Control)label11).Location = location;
		((Control)Label7).Name = "Label7";
		Label label12 = Label7;
		size = new Size(73, 13);
		((Control)label12).Size = size;
		((Control)Label7).TabIndex = 259;
		Label7.Text = "Loại phát sinh";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(645, 359);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtMauQD);
		((Control)this).Name = "frmGLMAUBCTCTMV22cEdit";
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
		((ComboBox)cboLoai_ps).DataSource = LoaiPS;
		((ListControl)cboLoai_ps).ValueMember = "Key";
		((ListControl)cboLoai_ps).DisplayMember = "Value";
		((ComboBox)cboLoai_ps).SelectedIndex = -1;
		((TextBoxBase)txtMa_chtieu).MaxLength = base.MyDictComplexInfo.code_length;
		((Control)txtMa_chtieu).Select();
	}

	protected override bool ValidData()
	{
		txtNd_chtieu.Text = txtNd_chtieu.Text.Trim();
		if (Operators.CompareString(txtMauQD.Text.Trim(), "", false) == 0)
		{
			txtMauQD.Text = CompanyInformations.Qd_cdkt;
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
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMauQD;
		CreateDataBinding(ref ojb, "mau");
		txtMauQD = (TextBox)ojb;
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
		ojb = (Control)(object)txtTaikhoan;
		CreateDataBinding(ref ojb, "tk_01");
		txtTaikhoan = (AsTextBox)(object)ojb;
		ojb = (Control)(object)cboLoai_ps;
		CreateDataBinding(ref ojb, "loai_ps", "SelectedValue");
		cboLoai_ps = (AsComboBox)(object)ojb;
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

	private void frmGLMAUBCTCTMV22CEdit_Load(object sender, EventArgs e)
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
