using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmTATNDN03Edit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtCong_thuc")]
	private TextBox _txtCong_thuc;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("chkBold")]
	private AsCheckBox _chkBold;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("chkIn_ck")]
	private AsCheckBox _chkIn_ck;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("GroupBox5")]
	private GroupBox _GroupBox5;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("txtStt")]
	private TextBox _txtStt;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtMa_so")]
	private TextBox _txtMa_so;

	[AccessedThroughProperty("txtChi_tieu")]
	private TextBox _txtChi_tieu;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("txtDsTk_co")]
	private AsTextBox _txtDsTk_co;

	[AccessedThroughProperty("txtDsTK_no")]
	private AsTextBox _txtDsTK_no;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("cboLoaiPS")]
	private AsComboBoxTT _cboLoaiPS;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("txtUser_sort")]
	private AsTextNumeric _txtUser_sort;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("ChkTu_nhap")]
	private RadioButton _ChkTu_nhap;

	[AccessedThroughProperty("ChkTai_khoan")]
	private RadioButton _ChkTai_khoan;

	[AccessedThroughProperty("ChkCong_thuc")]
	private RadioButton _ChkCong_thuc;

	private string sDsTK_co;

	private string sDsTK_no;

	private string sCong_thuc;

	private int iLoaiPS;

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

	internal virtual TextBox txtCong_thuc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCong_thuc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCong_thuc = value;
		}
	}

	internal virtual GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal virtual AsCheckBox chkBold
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkBold;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkBold = value;
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

	internal virtual AsCheckBox chkIn_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkIn_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkIn_ck = value;
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

	internal virtual GroupBox GroupBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox5 = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual TextBox txtStt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtStt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtStt = value;
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

	internal virtual TextBox txtMa_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyPressEventHandler val = new KeyPressEventHandler(txtMa_so_KeyPress);
			if (_txtMa_so != null)
			{
				((Control)_txtMa_so).KeyPress -= val;
			}
			_txtMa_so = value;
			if (_txtMa_so != null)
			{
				((Control)_txtMa_so).KeyPress += val;
			}
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

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual AsTextBox txtDsTk_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDsTk_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDsTk_co = value;
		}
	}

	internal virtual AsTextBox txtDsTK_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDsTK_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDsTK_no = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual AsComboBoxTT cboLoaiPS
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoaiPS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoaiPS = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual AsTextNumeric txtUser_sort
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtUser_sort;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtUser_sort = value;
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual RadioButton ChkTu_nhap
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkTu_nhap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ChkCach_tinh_CheckedChanged;
			if (_ChkTu_nhap != null)
			{
				_ChkTu_nhap.CheckedChanged -= eventHandler;
			}
			_ChkTu_nhap = value;
			if (_ChkTu_nhap != null)
			{
				_ChkTu_nhap.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton ChkTai_khoan
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkTai_khoan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ChkCach_tinh_CheckedChanged;
			if (_ChkTai_khoan != null)
			{
				_ChkTai_khoan.CheckedChanged -= eventHandler;
			}
			_ChkTai_khoan = value;
			if (_ChkTai_khoan != null)
			{
				_ChkTai_khoan.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton ChkCong_thuc
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkCong_thuc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ChkCach_tinh_CheckedChanged;
			if (_ChkCong_thuc != null)
			{
				_ChkCong_thuc.CheckedChanged -= eventHandler;
			}
			_ChkCong_thuc = value;
			if (_ChkCong_thuc != null)
			{
				_ChkCong_thuc.CheckedChanged += eventHandler;
			}
		}
	}

	public frmTATNDN03Edit()
	{
		sDsTK_co = "";
		sDsTK_no = "";
		sCong_thuc = "";
		iLoaiPS = -1;
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
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
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		GroupBox5 = new GroupBox();
		Label11 = new Label();
		txtStt = new TextBox();
		Label1 = new Label();
		txtMa_so = new TextBox();
		txtChi_tieu = new TextBox();
		Label2 = new Label();
		chkBold = new AsCheckBox();
		Label6 = new Label();
		chkIn_ck = new AsCheckBox();
		Label3 = new Label();
		GroupBox2 = new GroupBox();
		Label8 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		txtCong_thuc = new TextBox();
		Label12 = new Label();
		txtDsTk_co = new AsTextBox();
		txtDsTK_no = new AsTextBox();
		Label9 = new Label();
		cboLoaiPS = new AsComboBoxTT();
		Label10 = new Label();
		txtUser_sort = new AsTextNumeric();
		Panel1 = new Panel();
		ChkTu_nhap = new RadioButton();
		ChkTai_khoan = new RadioButton();
		ChkCong_thuc = new RadioButton();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(639, 434);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 343);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 0;
		Button obj2 = cmdSave;
		location = new Point(12, 343);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)Panel1);
		((Control)gbLine).Controls.Add((Control)(object)Label10);
		((Control)gbLine).Controls.Add((Control)(object)txtUser_sort);
		((Control)gbLine).Controls.Add((Control)(object)cboLoaiPS);
		((Control)gbLine).Controls.Add((Control)(object)txtDsTK_no);
		((Control)gbLine).Controls.Add((Control)(object)Label9);
		((Control)gbLine).Controls.Add((Control)(object)txtDsTk_co);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)Label12);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)GroupBox2);
		((Control)gbLine).Controls.Add((Control)(object)txtCong_thuc);
		((Control)gbLine).Controls.Add((Control)(object)chkIn_ck);
		((Control)gbLine).Controls.Add((Control)(object)chkBold);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)GroupBox5);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label11);
		((Control)gbLine).Controls.Add((Control)(object)txtStt);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_so);
		((Control)gbLine).Controls.Add((Control)(object)txtChi_tieu);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		GroupBox obj3 = gbLine;
		Size size = new Size(558, 331);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtChi_tieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_so, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtStt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label11, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)GroupBox5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkBold, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkIn_ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtCong_thuc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)GroupBox2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label12, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDsTk_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label9, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDsTK_no, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoaiPS, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtUser_sort, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label10, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Panel1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)GroupBox5).BackColor = SystemColors.ButtonFace;
		GroupBox groupBox = GroupBox5;
		location = new Point(16, 124);
		((Control)groupBox).Location = location;
		((Control)GroupBox5).Name = "GroupBox5";
		GroupBox groupBox2 = GroupBox5;
		size = new Size(525, 4);
		((Control)groupBox2).Size = size;
		((Control)GroupBox5).TabIndex = 129;
		GroupBox5.TabStop = false;
		Label11.AutoSize = true;
		Label label = Label11;
		location = new Point(13, 49);
		((Control)label).Location = location;
		((Control)Label11).Name = "Label11";
		Label label2 = Label11;
		size = new Size(50, 13);
		((Control)label2).Size = size;
		((Control)Label11).TabIndex = 132;
		Label11.Text = "Số thứ tự";
		TextBox obj4 = txtStt;
		location = new Point(93, 45);
		((Control)obj4).Location = location;
		((Control)txtStt).Name = "txtStt";
		TextBox obj5 = txtStt;
		size = new Size(100, 20);
		((Control)obj5).Size = size;
		((Control)txtStt).TabIndex = 1;
		txtStt.TextAlign = (HorizontalAlignment)1;
		Label1.AutoSize = true;
		Label label3 = Label1;
		location = new Point(13, 75);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(36, 13);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 129;
		Label1.Text = "Mã số";
		TextBox obj6 = txtMa_so;
		location = new Point(93, 71);
		((Control)obj6).Location = location;
		((TextBoxBase)txtMa_so).MaxLength = 16;
		((Control)txtMa_so).Name = "txtMa_so";
		TextBox obj7 = txtMa_so;
		size = new Size(100, 20);
		((Control)obj7).Size = size;
		((Control)txtMa_so).TabIndex = 2;
		txtMa_so.TextAlign = (HorizontalAlignment)1;
		TextBox obj8 = txtChi_tieu;
		location = new Point(93, 97);
		((Control)obj8).Location = location;
		((Control)txtChi_tieu).Name = "txtChi_tieu";
		TextBox obj9 = txtChi_tieu;
		size = new Size(448, 20);
		((Control)obj9).Size = size;
		((Control)txtChi_tieu).TabIndex = 3;
		Label2.AutoSize = true;
		Label label5 = Label2;
		location = new Point(13, 101);
		((Control)label5).Location = location;
		((Control)Label2).Name = "Label2";
		Label label6 = Label2;
		size = new Size(42, 13);
		((Control)label6).Size = size;
		((Control)Label2).TabIndex = 130;
		Label2.Text = "Chỉ tiêu";
		((ButtonBase)chkBold).AutoSize = true;
		chkBold.Checked = false;
		((Control)chkBold).ForeColor = Color.Black;
		AsCheckBox asCheckBox2 = chkBold;
		location = new Point(93, 166);
		((Control)asCheckBox2).Location = location;
		((Control)chkBold).Name = "chkBold";
		AsCheckBox asCheckBox3 = chkBold;
		size = new Size(113, 17);
		((Control)asCheckBox3).Size = size;
		((Control)chkBold).TabIndex = 5;
		((ButtonBase)chkBold).Text = "Đậm / không đậm";
		chkBold.TextValue = "0";
		((ButtonBase)chkBold).UseVisualStyleBackColor = true;
		Label6.AutoSize = true;
		Label label7 = Label6;
		location = new Point(13, 168);
		((Control)label7).Location = location;
		((Control)Label6).Name = "Label6";
		Label label8 = Label6;
		size = new Size(49, 13);
		((Control)label8).Size = size;
		((Control)Label6).TabIndex = 136;
		Label6.Text = "Kiểu chữ";
		((ButtonBase)chkIn_ck).AutoSize = true;
		chkIn_ck.Checked = false;
		((ButtonBase)chkIn_ck).FlatAppearance.BorderColor = SystemColors.Control;
		((Control)chkIn_ck).ForeColor = Color.Black;
		AsCheckBox asCheckBox4 = chkIn_ck;
		location = new Point(93, 143);
		((Control)asCheckBox4).Location = location;
		((Control)chkIn_ck).Name = "chkIn_ck";
		AsCheckBox asCheckBox5 = chkIn_ck;
		size = new Size(87, 17);
		((Control)asCheckBox5).Size = size;
		((Control)chkIn_ck).TabIndex = 4;
		((ButtonBase)chkIn_ck).Text = "In / không in";
		chkIn_ck.TextValue = "0";
		((ButtonBase)chkIn_ck).UseVisualStyleBackColor = true;
		Label3.AutoSize = true;
		Label label9 = Label3;
		location = new Point(13, 145);
		((Control)label9).Location = location;
		((Control)Label3).Name = "Label3";
		Label label10 = Label3;
		size = new Size(16, 13);
		((Control)label10).Size = size;
		((Control)Label3).TabIndex = 135;
		Label3.Text = "In";
		((Control)GroupBox2).BackColor = SystemColors.ButtonFace;
		GroupBox groupBox3 = GroupBox2;
		location = new Point(16, 192);
		((Control)groupBox3).Location = location;
		((Control)GroupBox2).Name = "GroupBox2";
		GroupBox groupBox4 = GroupBox2;
		size = new Size(525, 4);
		((Control)groupBox4).Size = size;
		((Control)GroupBox2).TabIndex = 142;
		GroupBox2.TabStop = false;
		Label8.AutoSize = true;
		Label label11 = Label8;
		location = new Point(26, 308);
		((Control)label11).Location = location;
		((Control)Label8).Name = "Label8";
		Label label12 = Label8;
		size = new Size(62, 13);
		((Control)label12).Size = size;
		((Control)Label8).TabIndex = 150;
		Label8.Text = "- Công thức";
		Label5.AutoSize = true;
		Label label13 = Label5;
		location = new Point(13, 204);
		((Control)label13).Location = location;
		((Control)Label5).Name = "Label5";
		Label label14 = Label5;
		size = new Size(54, 13);
		((Control)label14).Size = size;
		((Control)Label5).TabIndex = 149;
		Label5.Text = "Cách tính";
		Label4.AutoSize = true;
		Label label15 = Label4;
		location = new Point(26, 229);
		((Control)label15).Location = location;
		((Control)Label4).Name = "Label4";
		Label label16 = Label4;
		size = new Size(48, 13);
		((Control)label16).Size = size;
		((Control)Label4).TabIndex = 148;
		Label4.Text = "- DS TK ";
		TextBox obj10 = txtCong_thuc;
		location = new Point(93, 304);
		((Control)obj10).Location = location;
		((Control)txtCong_thuc).Name = "txtCong_thuc";
		TextBox obj11 = txtCong_thuc;
		size = new Size(448, 20);
		((Control)obj11).Size = size;
		((Control)txtCong_thuc).TabIndex = 10;
		Label12.AutoSize = true;
		Label label17 = Label12;
		location = new Point(26, 282);
		((Control)label17).Location = location;
		((Control)Label12).Name = "Label12";
		Label label18 = Label12;
		size = new Size(58, 13);
		((Control)label18).Size = size;
		((Control)Label12).TabIndex = 151;
		Label12.Text = "- DSTK đư";
		txtDsTk_co.AutoLookup = true;
		txtDsTk_co.AutoValid = false;
		((TextBoxBase)txtDsTk_co).BackColor = SystemColors.Control;
		((TextBox)txtDsTk_co).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtDsTk_co;
		location = new Point(93, 278);
		((Control)asTextBox).Location = location;
		txtDsTk_co.LookupCodeName = "TK";
		((Control)txtDsTk_co).Name = "txtDsTk_co";
		txtDsTk_co.NameControl = null;
		((TextBoxBase)txtDsTk_co).ReadOnly = true;
		AsTextBox asTextBox2 = txtDsTk_co;
		size = new Size(172, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtDsTk_co).TabIndex = 9;
		((Control)txtDsTk_co).Tag = "@pTK";
		txtDsTk_co.UseAutoCompleteSource = true;
		txtDsTK_no.AutoLookup = true;
		txtDsTK_no.AutoValid = false;
		((TextBoxBase)txtDsTK_no).BackColor = SystemColors.Control;
		((TextBox)txtDsTK_no).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtDsTK_no;
		location = new Point(93, 225);
		((Control)asTextBox3).Location = location;
		txtDsTK_no.LookupCodeName = "TK";
		((Control)txtDsTK_no).Name = "txtDsTK_no";
		txtDsTK_no.NameControl = null;
		((TextBoxBase)txtDsTK_no).ReadOnly = true;
		AsTextBox asTextBox4 = txtDsTK_no;
		size = new Size(172, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtDsTK_no).TabIndex = 7;
		((Control)txtDsTK_no).Tag = "@pTK";
		txtDsTK_no.UseAutoCompleteSource = true;
		Label9.AutoSize = true;
		Label label19 = Label9;
		location = new Point(30, 255);
		((Control)label19).Location = location;
		((Control)Label9).Name = "Label9";
		Label label20 = Label9;
		size = new Size(44, 13);
		((Control)label20).Size = size;
		((Control)Label9).TabIndex = 155;
		Label9.Text = "Loại PS";
		((ComboBox)cboLoaiPS).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoaiPS).FormattingEnabled = true;
		AsComboBoxTT asComboBoxTT = cboLoaiPS;
		location = new Point(93, 251);
		((Control)asComboBoxTT).Location = location;
		cboLoaiPS.Ma_Ct = null;
		((Control)cboLoaiPS).Name = "cboLoaiPS";
		AsComboBoxTT asComboBoxTT2 = cboLoaiPS;
		size = new Size(121, 21);
		((Control)asComboBoxTT2).Size = size;
		((Control)cboLoaiPS).TabIndex = 8;
		cboLoaiPS.Trang_Thai = "";
		Label10.AutoSize = true;
		Label label21 = Label10;
		location = new Point(13, 23);
		((Control)label21).Location = location;
		((Control)Label10).Name = "Label10";
		Label label22 = Label10;
		size = new Size(46, 13);
		((Control)label22).Size = size;
		((Control)Label10).TabIndex = 160;
		Label10.Text = "Sắp xếp";
		txtUser_sort.DecimalSymbol = ".";
		txtUser_sort.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtUser_sort;
		location = new Point(93, 19);
		((Control)asTextNumeric).Location = location;
		txtUser_sort.Mask = "00000";
		((Control)txtUser_sort).Name = "txtUser_sort";
		AsTextNumeric asTextNumeric2 = txtUser_sort;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtUser_sort).TabIndex = 0;
		((TextBox)txtUser_sort).Text = "0";
		((TextBox)txtUser_sort).TextAlign = (HorizontalAlignment)1;
		txtUser_sort.Value = 0;
		((Control)Panel1).Controls.Add((Control)(object)ChkCong_thuc);
		((Control)Panel1).Controls.Add((Control)(object)ChkTu_nhap);
		((Control)Panel1).Controls.Add((Control)(object)ChkTai_khoan);
		Panel panel = Panel1;
		location = new Point(93, 196);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(445, 23);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 6;
		((ButtonBase)ChkTu_nhap).AutoSize = true;
		RadioButton chkTu_nhap = ChkTu_nhap;
		location = new Point(287, 3);
		((Control)chkTu_nhap).Location = location;
		((Control)ChkTu_nhap).Name = "ChkTu_nhap";
		RadioButton chkTu_nhap2 = ChkTu_nhap;
		size = new Size(65, 17);
		((Control)chkTu_nhap2).Size = size;
		((Control)ChkTu_nhap).TabIndex = 2;
		((ButtonBase)ChkTu_nhap).Text = "Tự nhập";
		((ButtonBase)ChkTu_nhap).UseVisualStyleBackColor = true;
		((ButtonBase)ChkTai_khoan).AutoSize = true;
		ChkTai_khoan.Checked = true;
		RadioButton chkTai_khoan = ChkTai_khoan;
		location = new Point(4, 3);
		((Control)chkTai_khoan).Location = location;
		((Control)ChkTai_khoan).Name = "ChkTai_khoan";
		RadioButton chkTai_khoan2 = ChkTai_khoan;
		size = new Size(148, 17);
		((Control)chkTai_khoan2).Size = size;
		((Control)ChkTai_khoan).TabIndex = 0;
		ChkTai_khoan.TabStop = true;
		((ButtonBase)ChkTai_khoan).Text = "Tính theo số dư tài khoản";
		((ButtonBase)ChkTai_khoan).UseVisualStyleBackColor = true;
		((ButtonBase)ChkCong_thuc).AutoSize = true;
		RadioButton chkCong_thuc = ChkCong_thuc;
		location = new Point(157, 3);
		((Control)chkCong_thuc).Location = location;
		((Control)ChkCong_thuc).Name = "ChkCong_thuc";
		RadioButton chkCong_thuc2 = ChkCong_thuc;
		size = new Size(123, 17);
		((Control)chkCong_thuc2).Size = size;
		((Control)ChkCong_thuc).TabIndex = 1;
		((ButtonBase)ChkCong_thuc).Text = "Tính theo công thức";
		((ButtonBase)ChkCong_thuc).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(582, 378);
		((Form)this).ClientSize = size;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmTATNDN03Edit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		if (!EditMode)
		{
			RowToEdit["stt"] = RuntimeHelpers.GetObjectValue(RowToEdit.Table.Compute("count(ma_cty)", ""));
		}
		((Control)txtMa_so).Focus();
		((Control)txtMa_so).Select();
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add("Key", Type.GetType("System.String"));
		dataTable.Columns.Add("Value", Type.GetType("System.String"));
		dataTable.Rows.Add("NO", "1. PS nợ");
		dataTable.Rows.Add("CO", "2. PS Có");
		((ComboBox)cboLoaiPS).DataSource = dataTable;
		((ListControl)cboLoaiPS).ValueMember = "Key";
		((ListControl)cboLoaiPS).DisplayMember = "Value";
		((ComboBox)cboLoaiPS).SelectedIndex = -1;
		((Control)txtUser_sort).Select();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		sDsTK_co = ((TextBox)txtDsTk_co).Text;
		sDsTK_no = ((TextBox)txtDsTK_no).Text;
		sCong_thuc = txtCong_thuc.Text;
		iLoaiPS = ((ComboBox)cboLoaiPS).SelectedIndex;
		if (Conversions.ToBoolean(RowToEdit["modify"]))
		{
			ChkTu_nhap.Checked = true;
		}
		else if (Operators.CompareString(txtCong_thuc.Text, "", false) == 0)
		{
			ChkTai_khoan.Checked = true;
		}
		else
		{
			ChkCong_thuc.Checked = true;
		}
	}

	protected override void DataBinding()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtUser_sort;
		CreateDataBinding(ref ojb, "user_sort", "Value");
		txtUser_sort = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtStt;
		CreateDataBinding(ref ojb, "stt");
		txtStt = (TextBox)ojb;
		ojb = (Control)(object)txtMa_so;
		CreateDataBinding(ref ojb, "ma_so");
		txtMa_so = (TextBox)ojb;
		ojb = (Control)(object)txtChi_tieu;
		CreateDataBinding(ref ojb, "chi_tieu");
		txtChi_tieu = (TextBox)ojb;
		ojb = (Control)(object)txtDsTK_no;
		CreateDataBinding(ref ojb, "tk");
		txtDsTK_no = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtDsTk_co;
		CreateDataBinding(ref ojb, "tk_du");
		txtDsTk_co = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtCong_thuc;
		CreateDataBinding(ref ojb, "cach_tinh");
		txtCong_thuc = (TextBox)ojb;
		ojb = (Control)(object)chkIn_ck;
		CreateDataBinding(ref ojb, "in_ck", "Checked");
		chkIn_ck = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkBold;
		CreateDataBinding(ref ojb, "bold", "Checked");
		chkBold = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)cboLoaiPS;
		CreateDataBinding(ref ojb, "no_co", "SelectedValue");
		cboLoaiPS = (AsComboBoxTT)(object)ojb;
		ojb = (Control)(object)ChkTu_nhap;
		CreateDataBinding(ref ojb, "modify", "Checked");
		ChkTu_nhap = (RadioButton)ojb;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_so).Enabled = false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_so).Select();
		}
		return flag;
	}

	private void ChkCach_tinh_CheckedChanged(object sender, EventArgs e)
	{
		if (ChkTai_khoan.Checked)
		{
			((TextBoxBase)txtDsTK_no).ReadOnly = false;
			((TextBoxBase)txtDsTk_co).ReadOnly = false;
			((TextBoxBase)txtCong_thuc).ReadOnly = true;
			((Control)txtDsTK_no).TabStop = true;
			((Control)txtDsTk_co).TabStop = true;
			((Control)txtCong_thuc).TabStop = false;
			((TextBoxBase)txtCong_thuc).Clear();
			((TextBox)txtDsTk_co).Text = sDsTK_co;
			((TextBox)txtDsTK_no).Text = sDsTK_no;
			((ComboBox)cboLoaiPS).SelectedIndex = iLoaiPS;
			((Control)cboLoaiPS).Enabled = true;
			((Control)txtDsTK_no).Focus();
		}
		else if (ChkCong_thuc.Checked)
		{
			((TextBoxBase)txtDsTK_no).ReadOnly = true;
			((TextBoxBase)txtDsTk_co).ReadOnly = true;
			((TextBoxBase)txtCong_thuc).ReadOnly = false;
			((Control)txtDsTK_no).TabStop = false;
			((Control)txtDsTk_co).TabStop = false;
			((Control)txtCong_thuc).TabStop = true;
			txtCong_thuc.Text = sCong_thuc;
			((TextBoxBase)txtDsTK_no).Clear();
			((TextBoxBase)txtDsTk_co).Clear();
			((ComboBox)cboLoaiPS).SelectedIndex = -1;
			((Control)cboLoaiPS).Enabled = false;
			((Control)txtCong_thuc).Focus();
		}
		else
		{
			((TextBoxBase)txtDsTk_co).ReadOnly = true;
			((TextBoxBase)txtDsTK_no).ReadOnly = true;
			((TextBoxBase)txtCong_thuc).ReadOnly = true;
			((Control)txtDsTK_no).TabStop = false;
			((Control)txtDsTk_co).TabStop = false;
			((Control)txtCong_thuc).TabStop = false;
			((Control)cboLoaiPS).Enabled = false;
			((TextBoxBase)txtCong_thuc).Clear();
			((TextBoxBase)txtDsTK_no).Clear();
			((TextBoxBase)txtDsTk_co).Clear();
			((ComboBox)cboLoaiPS).SelectedIndex = -1;
		}
	}

	private void txtMa_so_KeyPress(object sender, KeyPressEventArgs e)
	{
		string text = "qwertyuiopasdfghjklzxcvbnm";
		char key = e.KeyChar;
		bool handled = digitsFilter(ref key, text + text.ToUpper());
		e.KeyChar = key;
		e.Handled = handled;
	}

	public bool digitsFilter(ref char key, string str = "")
	{
		string text = str + "0987654321";
		if (Strings.Asc(key) < 32)
		{
			return false;
		}
		if (Strings.InStr(text, Conversions.ToString(key), (CompareMethod)0) <= 0)
		{
			return true;
		}
		return false;
	}
}
