using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmAPPost2TTFind : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblCbo")]
	private Label _lblCbo;

	[AccessedThroughProperty("cboLoai_ct")]
	private ComboBox _cboLoai_ct;

	[AccessedThroughProperty("txtTu_so")]
	private TextBox _txtTu_so;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtDen_so")]
	private TextBox _txtDen_so;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txtTu_ngay")]
	private AsMaskedTextBox _txtTu_ngay;

	[AccessedThroughProperty("txtDen_ngay")]
	private AsMaskedTextBox _txtDen_ngay;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("lblTen_kh")]
	private Label _lblTen_kh;

	[AccessedThroughProperty("txtMa_kh")]
	private AsTextBox _txtMa_kh;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("btnNhan")]
	private Button _btnNhan;

	[AccessedThroughProperty("btnThoat")]
	private Button _btnThoat;

	[AccessedThroughProperty("txtTai_khoan")]
	private AsTextBox _txtTai_khoan;

	[AccessedThroughProperty("lblTai_khoan")]
	private Label _lblTai_khoan;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	internal DataRowView f_oRow;

	internal DataTable f_oDt;

	internal DataTable f_oDtct;

	internal bool f_bIns;

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

	internal virtual Label lblCbo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCbo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCbo = value;
		}
	}

	internal virtual ComboBox cboLoai_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_ct = value;
		}
	}

	internal virtual TextBox txtTu_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTu_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTu_so = value;
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

	internal virtual TextBox txtDen_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDen_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDen_so = value;
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

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual AsMaskedTextBox txtTu_ngay
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTu_ngay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTu_ngay = value;
		}
	}

	internal virtual AsMaskedTextBox txtDen_ngay
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDen_ngay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDen_ngay = value;
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

	internal virtual Label lblTen_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kh = value;
		}
	}

	internal virtual AsTextBox txtMa_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kh = value;
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

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Button btnNhan
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnNhan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnNhan_Click;
			if (_btnNhan != null)
			{
				((Control)_btnNhan).Click -= eventHandler;
			}
			_btnNhan = value;
			if (_btnNhan != null)
			{
				((Control)_btnNhan).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnThoat
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnThoat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnThoat_Click;
			if (_btnThoat != null)
			{
				((Control)_btnThoat).Click -= eventHandler;
			}
			_btnThoat = value;
			if (_btnThoat != null)
			{
				((Control)_btnThoat).Click += eventHandler;
			}
		}
	}

	internal virtual AsTextBox txtTai_khoan
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTai_khoan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTai_khoan = value;
		}
	}

	internal virtual Label lblTai_khoan
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTai_khoan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTai_khoan = value;
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

	[DebuggerNonUserCode]
	public frmAPPost2TTFind()
	{
		((Form)this).Load += frmARPost2TTFind_Load;
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		Label1 = new Label();
		lblCbo = new Label();
		cboLoai_ct = new ComboBox();
		txtTu_so = new TextBox();
		Label3 = new Label();
		txtDen_so = new TextBox();
		Label4 = new Label();
		Label5 = new Label();
		txtTu_ngay = new AsMaskedTextBox();
		txtDen_ngay = new AsMaskedTextBox();
		Label6 = new Label();
		lblTen_kh = new Label();
		txtMa_kh = new AsTextBox();
		Label7 = new Label();
		txtDien_giai = new TextBox();
		GroupBox1 = new GroupBox();
		btnNhan = new Button();
		btnThoat = new Button();
		txtTai_khoan = new AsTextBox();
		lblTai_khoan = new Label();
		Label8 = new Label();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		Label1.AutoSize = true;
		Label label = Label1;
		Point location = new Point(17, 127);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(64, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 0;
		Label1.Text = "Chứng từ số";
		lblCbo.AutoSize = true;
		Label obj = lblCbo;
		location = new Point(17, 22);
		((Control)obj).Location = location;
		((Control)lblCbo).Name = "lblCbo";
		Label obj2 = lblCbo;
		size = new Size(72, 13);
		((Control)obj2).Size = size;
		((Control)lblCbo).TabIndex = 1;
		lblCbo.Text = "Loại chứng từ";
		cboLoai_ct.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_ct).FormattingEnabled = true;
		ComboBox obj3 = cboLoai_ct;
		location = new Point(105, 18);
		((Control)obj3).Location = location;
		((Control)cboLoai_ct).Name = "cboLoai_ct";
		ComboBox obj4 = cboLoai_ct;
		size = new Size(222, 21);
		((Control)obj4).Size = size;
		((Control)cboLoai_ct).TabIndex = 0;
		TextBox obj5 = txtTu_so;
		location = new Point(105, 123);
		((Control)obj5).Location = location;
		((Control)txtTu_so).Name = "txtTu_so";
		TextBox obj6 = txtTu_so;
		size = new Size(79, 20);
		((Control)obj6).Size = size;
		((Control)txtTu_so).TabIndex = 7;
		Label3.AutoSize = true;
		Label label3 = Label3;
		location = new Point(190, 127);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		Label label4 = Label3;
		size = new Size(40, 13);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 4;
		Label3.Text = "đến số";
		TextBox obj7 = txtDen_so;
		location = new Point(248, 123);
		((Control)obj7).Location = location;
		((Control)txtDen_so).Name = "txtDen_so";
		TextBox obj8 = txtDen_so;
		size = new Size(79, 20);
		((Control)obj8).Size = size;
		((Control)txtDen_so).TabIndex = 8;
		Label4.AutoSize = true;
		Label label5 = Label4;
		location = new Point(17, 101);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		Label label6 = Label4;
		size = new Size(76, 13);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 6;
		Label4.Text = "Chứng từ ngày";
		Label5.AutoSize = true;
		Label label7 = Label5;
		location = new Point(190, 101);
		((Control)label7).Location = location;
		((Control)Label5).Name = "Label5";
		Label label8 = Label5;
		size = new Size(52, 13);
		((Control)label8).Size = size;
		((Control)Label5).TabIndex = 9;
		Label5.Text = "đến ngày";
		txtTu_ngay.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtTu_ngay).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtTu_ngay;
		location = new Point(105, 97);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtTu_ngay).Mask = "##/##/####";
		((Control)txtTu_ngay).Name = "txtTu_ngay";
		((MaskedTextBox)txtTu_ngay).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtTu_ngay;
		size = new Size(79, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtTu_ngay).TabIndex = 5;
		((MaskedTextBox)txtTu_ngay).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtTu_ngay;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtDen_ngay.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtDen_ngay).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtDen_ngay;
		location = new Point(248, 97);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtDen_ngay).Mask = "##/##/####";
		((Control)txtDen_ngay).Name = "txtDen_ngay";
		((MaskedTextBox)txtDen_ngay).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtDen_ngay;
		size = new Size(79, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtDen_ngay).TabIndex = 6;
		((MaskedTextBox)txtDen_ngay).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtDen_ngay;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		Label6.AutoSize = true;
		Label label9 = Label6;
		location = new Point(17, 49);
		((Control)label9).Location = location;
		((Control)Label6).Name = "Label6";
		Label label10 = Label6;
		size = new Size(65, 13);
		((Control)label10).Size = size;
		((Control)Label6).TabIndex = 12;
		Label6.Text = "Khách hàng";
		Label obj9 = lblTen_kh;
		location = new Point(193, 45);
		((Control)obj9).Location = location;
		((Control)lblTen_kh).Name = "lblTen_kh";
		Label obj10 = lblTen_kh;
		size = new Size(265, 20);
		((Control)obj10).Size = size;
		((Control)lblTen_kh).TabIndex = 2;
		lblTen_kh.TextAlign = (ContentAlignment)16;
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = true;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_kh;
		location = new Point(105, 45);
		((Control)asTextBox).Location = location;
		txtMa_kh.LookupCodeName = "MA_KH";
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = lblTen_kh;
		AsTextBox asTextBox2 = txtMa_kh;
		size = new Size(79, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_kh).TabIndex = 1;
		txtMa_kh.UseAutoCompleteSource = true;
		Label7.AutoSize = true;
		Label label11 = Label7;
		location = new Point(17, 158);
		((Control)label11).Location = location;
		((Control)Label7).Name = "Label7";
		Label label12 = Label7;
		size = new Size(48, 13);
		((Control)label12).Size = size;
		((Control)Label7).TabIndex = 16;
		Label7.Text = "Diễn giải";
		TextBox obj11 = txtDien_giai;
		location = new Point(105, 154);
		((Control)obj11).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj12 = txtDien_giai;
		size = new Size(353, 20);
		((Control)obj12).Size = size;
		((Control)txtDien_giai).TabIndex = 9;
		((Control)GroupBox1).Anchor = (AnchorStyles)15;
		((Control)GroupBox1).Controls.Add((Control)(object)txtTai_khoan);
		((Control)GroupBox1).Controls.Add((Control)(object)lblTai_khoan);
		((Control)GroupBox1).Controls.Add((Control)(object)Label8);
		((Control)GroupBox1).Controls.Add((Control)(object)txtDen_ngay);
		((Control)GroupBox1).Controls.Add((Control)(object)txtDien_giai);
		((Control)GroupBox1).Controls.Add((Control)(object)Label1);
		((Control)GroupBox1).Controls.Add((Control)(object)Label7);
		((Control)GroupBox1).Controls.Add((Control)(object)lblCbo);
		((Control)GroupBox1).Controls.Add((Control)(object)txtMa_kh);
		((Control)GroupBox1).Controls.Add((Control)(object)cboLoai_ct);
		((Control)GroupBox1).Controls.Add((Control)(object)lblTen_kh);
		((Control)GroupBox1).Controls.Add((Control)(object)txtTu_so);
		((Control)GroupBox1).Controls.Add((Control)(object)Label6);
		((Control)GroupBox1).Controls.Add((Control)(object)Label3);
		((Control)GroupBox1).Controls.Add((Control)(object)txtDen_so);
		((Control)GroupBox1).Controls.Add((Control)(object)txtTu_ngay);
		((Control)GroupBox1).Controls.Add((Control)(object)Label4);
		((Control)GroupBox1).Controls.Add((Control)(object)Label5);
		GroupBox groupBox = GroupBox1;
		location = new Point(12, 12);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(472, 186);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 0;
		GroupBox1.TabStop = false;
		((Control)btnNhan).Anchor = (AnchorStyles)6;
		((ButtonBase)btnNhan).Image = (Image)(object)Resources.imgFind;
		((ButtonBase)btnNhan).ImageAlign = (ContentAlignment)16;
		Button obj13 = btnNhan;
		location = new Point(12, 205);
		((Control)obj13).Location = location;
		((Control)btnNhan).Name = "btnNhan";
		Button obj14 = btnNhan;
		size = new Size(75, 23);
		((Control)obj14).Size = size;
		((Control)btnNhan).TabIndex = 1;
		((ButtonBase)btnNhan).Text = "&Nhận";
		((ButtonBase)btnNhan).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnNhan).UseVisualStyleBackColor = true;
		((Control)btnThoat).Anchor = (AnchorStyles)6;
		((ButtonBase)btnThoat).Image = (Image)(object)Resources.imgExit;
		((ButtonBase)btnThoat).ImageAlign = (ContentAlignment)16;
		Button obj15 = btnThoat;
		location = new Point(100, 205);
		((Control)obj15).Location = location;
		((Control)btnThoat).Name = "btnThoat";
		Button obj16 = btnThoat;
		size = new Size(75, 23);
		((Control)obj16).Size = size;
		((Control)btnThoat).TabIndex = 2;
		((ButtonBase)btnThoat).Text = "&Quay ra";
		((ButtonBase)btnThoat).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnThoat).UseVisualStyleBackColor = true;
		txtTai_khoan.AutoLookup = true;
		txtTai_khoan.AutoValid = true;
		((TextBoxBase)txtTai_khoan).BackColor = SystemColors.Info;
		((TextBox)txtTai_khoan).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTai_khoan;
		location = new Point(105, 71);
		((Control)asTextBox3).Location = location;
		txtTai_khoan.LookupCodeName = "TK";
		txtTai_khoan.LookupWhereCondition = "TK_CN = 1";
		((Control)txtTai_khoan).Name = "txtTai_khoan";
		txtTai_khoan.NameControl = lblTai_khoan;
		AsTextBox asTextBox4 = txtTai_khoan;
		size = new Size(79, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTai_khoan).TabIndex = 3;
		txtTai_khoan.UseAutoCompleteSource = true;
		Label obj17 = lblTai_khoan;
		location = new Point(193, 71);
		((Control)obj17).Location = location;
		((Control)lblTai_khoan).Name = "lblTai_khoan";
		Label obj18 = lblTai_khoan;
		size = new Size(265, 20);
		((Control)obj18).Size = size;
		((Control)lblTai_khoan).TabIndex = 4;
		lblTai_khoan.TextAlign = (ContentAlignment)16;
		Label8.AutoSize = true;
		Label label13 = Label8;
		location = new Point(17, 75);
		((Control)label13).Location = location;
		((Control)Label8).Name = "Label8";
		Label label14 = Label8;
		size = new Size(55, 13);
		((Control)label14).Size = size;
		((Control)Label8).TabIndex = 18;
		Label8.Text = "Tài khoản";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(496, 234);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)btnThoat);
		((Control)this).Controls.Add((Control)(object)btnNhan);
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Name = "frmAPPost2TTFind";
		((Form)this).Text = "Lọc chứng từ";
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void frmARPost2TTFind_Load(object sender, EventArgs e)
	{
		((TextBox)txtTai_khoan).Text = AsiaErp.Framework.Environment.GetPOConfiguration().tk_pt;
		((Control)txtTai_khoan).Select();
		if (f_bIns)
		{
			LoadCombo();
			((Control)cboLoai_ct).Select();
		}
		else
		{
			cboLoai_ct.Text = "";
			((Control)cboLoai_ct).Enabled = false;
			((Control)txtMa_kh).Select();
		}
		AsMaskedTextBox asMaskedTextBox = txtTu_ngay;
		DateTime dateTime = new DateTime(SystemInformations.FinancialYear, 1, 1);
		asMaskedTextBox.Value = dateTime;
		txtDen_ngay.Value = DateTime.Now;
	}

	private void btnThoat_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btnNhan_Click(object sender, EventArgs e)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		frmAPPost2TTResult frmAPPost2TTResult2 = new frmAPPost2TTResult();
		ArrayList arrayList = new ArrayList();
		if (f_bIns)
		{
			arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_ct).SelectedValue));
		}
		else
		{
			arrayList.Add("");
		}
		arrayList.Add(txtTu_so.Text);
		arrayList.Add(txtDen_so.Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtTu_ngay.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtDen_ngay.Value));
		arrayList.Add(((TextBox)txtMa_kh).Text);
		arrayList.Add(((TextBox)txtTai_khoan).Text);
		arrayList.Add(txtDien_giai.Text);
		APPost2TTDAO aPPost2TTDAO = (APPost2TTDAO)DAOFactory.CreateDAOInstance("APPost2TTDAO", "APPost2TT");
		f_oDt = aPPost2TTDAO.GetDataCT(arrayList.ToArray());
		aPPost2TTDAO.Destroy();
		frmAPPost2TTResult2.f_Tk = ((TextBox)txtTai_khoan).Text;
		frmAPPost2TTResult2.f_oDt = f_oDt;
		frmAPPost2TTResult2.f_bIns = f_bIns;
		((Form)frmAPPost2TTResult2).ShowDialog();
		f_oRow = frmAPPost2TTResult2.f_oRow;
		f_oDtct = frmAPPost2TTResult2.f_oDtct;
		((Form)this).Close();
	}

	protected void LoadCombo()
	{
		APPost2TTDAO aPPost2TTDAO = (APPost2TTDAO)DAOFactory.CreateDAOInstance("APPost2TTDAO", "APPost2TT");
		DataTable dataTable = new DataTable();
		dataTable = aPPost2TTDAO.GetData();
		aPPost2TTDAO.Destroy();
		((ListControl)cboLoai_ct).DisplayMember = "ten_ct";
		((ListControl)cboLoai_ct).ValueMember = "ma_ct";
		cboLoai_ct.DataSource = dataTable;
	}
}
