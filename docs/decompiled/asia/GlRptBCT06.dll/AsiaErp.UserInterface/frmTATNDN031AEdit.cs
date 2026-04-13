using System;
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
public class frmTATNDN031AEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("chkCach_tinh")]
	private AsCheckBox _chkCach_tinh;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtCach_tinh")]
	private TextBox _txtCach_tinh;

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

	[AccessedThroughProperty("txtUser_sort")]
	private AsTextNumeric _txtUser_sort;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	internal virtual AsCheckBox chkCach_tinh
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkCach_tinh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkCach_tinh_Click;
			EventHandler eventHandler2 = chkCach_tinh_Validated;
			if (_chkCach_tinh != null)
			{
				((Control)_chkCach_tinh).Click -= eventHandler;
				((Control)_chkCach_tinh).Validated -= eventHandler2;
			}
			_chkCach_tinh = value;
			if (_chkCach_tinh != null)
			{
				((Control)_chkCach_tinh).Click += eventHandler;
				((Control)_chkCach_tinh).Validated += eventHandler2;
			}
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
			_txtMa_so = value;
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

	[DebuggerNonUserCode]
	public frmTATNDN031AEdit()
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
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
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
		chkCach_tinh = new AsCheckBox();
		Label8 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		txtCach_tinh = new TextBox();
		Label12 = new Label();
		txtDsTk_co = new AsTextBox();
		txtDsTK_no = new AsTextBox();
		Label9 = new Label();
		cboLoaiPS = new AsComboBoxTT();
		txtUser_sort = new AsTextNumeric();
		Label7 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(639, 434);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 350);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 350);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtUser_sort);
		((Control)gbLine).Controls.Add((Control)(object)cboLoaiPS);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)txtDsTK_no);
		((Control)gbLine).Controls.Add((Control)(object)Label9);
		((Control)gbLine).Controls.Add((Control)(object)chkCach_tinh);
		((Control)gbLine).Controls.Add((Control)(object)txtDsTk_co);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)Label12);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)GroupBox2);
		((Control)gbLine).Controls.Add((Control)(object)txtCach_tinh);
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
		GroupBox obj3 = gbLine;
		Size size = new Size(560, 338);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
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
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtCach_tinh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)GroupBox2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label12, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDsTk_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkCach_tinh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label9, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDsTK_no, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoaiPS, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtUser_sort, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)GroupBox5).BackColor = SystemColors.ButtonFace;
		GroupBox groupBox = GroupBox5;
		location = new Point(16, 125);
		((Control)groupBox).Location = location;
		((Control)GroupBox5).Name = "GroupBox5";
		GroupBox groupBox2 = GroupBox5;
		size = new Size(525, 4);
		((Control)groupBox2).Size = size;
		((Control)GroupBox5).TabIndex = 129;
		GroupBox5.TabStop = false;
		Label11.AutoSize = true;
		Label label = Label11;
		location = new Point(16, 50);
		((Control)label).Location = location;
		((Control)Label11).Name = "Label11";
		Label label2 = Label11;
		size = new Size(50, 13);
		((Control)label2).Size = size;
		((Control)Label11).TabIndex = 132;
		Label11.Text = "Số thứ tự";
		TextBox obj4 = txtStt;
		location = new Point(96, 46);
		((Control)obj4).Location = location;
		((TextBoxBase)txtStt).MaxLength = 16;
		((Control)txtStt).Name = "txtStt";
		TextBox obj5 = txtStt;
		size = new Size(100, 20);
		((Control)obj5).Size = size;
		((Control)txtStt).TabIndex = 1;
		txtStt.TextAlign = (HorizontalAlignment)1;
		Label1.AutoSize = true;
		Label label3 = Label1;
		location = new Point(16, 76);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(36, 13);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 129;
		Label1.Text = "Mã số";
		TextBox obj6 = txtMa_so;
		location = new Point(96, 72);
		((Control)obj6).Location = location;
		((Control)txtMa_so).Name = "txtMa_so";
		TextBox obj7 = txtMa_so;
		size = new Size(100, 20);
		((Control)obj7).Size = size;
		((Control)txtMa_so).TabIndex = 2;
		txtMa_so.TextAlign = (HorizontalAlignment)1;
		TextBox obj8 = txtChi_tieu;
		location = new Point(96, 98);
		((Control)obj8).Location = location;
		((Control)txtChi_tieu).Name = "txtChi_tieu";
		TextBox obj9 = txtChi_tieu;
		size = new Size(445, 20);
		((Control)obj9).Size = size;
		((Control)txtChi_tieu).TabIndex = 3;
		Label2.AutoSize = true;
		Label label5 = Label2;
		location = new Point(16, 102);
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
		location = new Point(96, 167);
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
		location = new Point(16, 169);
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
		location = new Point(96, 144);
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
		location = new Point(16, 146);
		((Control)label9).Location = location;
		((Control)Label3).Name = "Label3";
		Label label10 = Label3;
		size = new Size(16, 13);
		((Control)label10).Size = size;
		((Control)Label3).TabIndex = 135;
		Label3.Text = "In";
		((Control)GroupBox2).BackColor = SystemColors.ButtonFace;
		GroupBox groupBox3 = GroupBox2;
		location = new Point(16, 193);
		((Control)groupBox3).Location = location;
		((Control)GroupBox2).Name = "GroupBox2";
		GroupBox groupBox4 = GroupBox2;
		size = new Size(525, 4);
		((Control)groupBox4).Size = size;
		((Control)GroupBox2).TabIndex = 142;
		GroupBox2.TabStop = false;
		((ButtonBase)chkCach_tinh).AutoSize = true;
		chkCach_tinh.Checked = false;
		AsCheckBox asCheckBox6 = chkCach_tinh;
		location = new Point(96, 203);
		((Control)asCheckBox6).Location = location;
		((Control)chkCach_tinh).Name = "chkCach_tinh";
		AsCheckBox asCheckBox7 = chkCach_tinh;
		size = new Size(254, 17);
		((Control)asCheckBox7).Size = size;
		((Control)chkCach_tinh).TabIndex = 6;
		((ButtonBase)chkCach_tinh).Text = "Tính theo số dư tài khoản / tính theo công thức";
		chkCach_tinh.TextValue = "0";
		((ButtonBase)chkCach_tinh).UseVisualStyleBackColor = true;
		Label8.AutoSize = true;
		Label label11 = Label8;
		location = new Point(31, 309);
		((Control)label11).Location = location;
		((Control)Label8).Name = "Label8";
		Label label12 = Label8;
		size = new Size(62, 13);
		((Control)label12).Size = size;
		((Control)Label8).TabIndex = 150;
		Label8.Text = "- Công thức";
		Label5.AutoSize = true;
		Label label13 = Label5;
		location = new Point(16, 205);
		((Control)label13).Location = location;
		((Control)Label5).Name = "Label5";
		Label label14 = Label5;
		size = new Size(54, 13);
		((Control)label14).Size = size;
		((Control)Label5).TabIndex = 149;
		Label5.Text = "Cách tính";
		Label4.AutoSize = true;
		Label label15 = Label4;
		location = new Point(31, 230);
		((Control)label15).Location = location;
		((Control)Label4).Name = "Label4";
		Label label16 = Label4;
		size = new Size(48, 13);
		((Control)label16).Size = size;
		((Control)Label4).TabIndex = 148;
		Label4.Text = "- DS TK ";
		TextBox obj10 = txtCach_tinh;
		location = new Point(96, 305);
		((Control)obj10).Location = location;
		((Control)txtCach_tinh).Name = "txtCach_tinh";
		TextBox obj11 = txtCach_tinh;
		size = new Size(445, 20);
		((Control)obj11).Size = size;
		((Control)txtCach_tinh).TabIndex = 10;
		Label12.AutoSize = true;
		Label label17 = Label12;
		location = new Point(31, 283);
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
		location = new Point(96, 279);
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
		location = new Point(96, 226);
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
		location = new Point(31, 256);
		((Control)label19).Location = location;
		((Control)Label9).Name = "Label9";
		Label label20 = Label9;
		size = new Size(50, 13);
		((Control)label20).Size = size;
		((Control)Label9).TabIndex = 155;
		Label9.Text = "- Loại PS";
		((ComboBox)cboLoaiPS).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoaiPS).FormattingEnabled = true;
		AsComboBoxTT asComboBoxTT = cboLoaiPS;
		location = new Point(96, 252);
		((Control)asComboBoxTT).Location = location;
		cboLoaiPS.Ma_Ct = null;
		((Control)cboLoaiPS).Name = "cboLoaiPS";
		AsComboBoxTT asComboBoxTT2 = cboLoaiPS;
		size = new Size(121, 21);
		((Control)asComboBoxTT2).Size = size;
		((Control)cboLoaiPS).TabIndex = 8;
		cboLoaiPS.Trang_Thai = "";
		txtUser_sort.DecimalSymbol = ".";
		txtUser_sort.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtUser_sort;
		location = new Point(96, 19);
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
		Label7.AutoSize = true;
		Label label21 = Label7;
		location = new Point(16, 23);
		((Control)label21).Location = location;
		((Control)Label7).Name = "Label7";
		Label label22 = Label7;
		size = new Size(46, 13);
		((Control)label22).Size = size;
		((Control)Label7).TabIndex = 157;
		Label7.Text = "Sắp xếp";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(584, 385);
		((Form)this).ClientSize = size;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmTATNDN031AEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
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
		if (!EditMode)
		{
			((CheckBox)chkCach_tinh).CheckState = (CheckState)1;
		}
		if (Operators.CompareString(((TextBox)txtDsTK_no).Text.Trim(), "", false) == 0 && Operators.CompareString(((TextBox)txtDsTk_co).Text.Trim(), "", false) == 0 && Operators.CompareString(txtCach_tinh.Text.Trim(), "", false) != 0)
		{
			((CheckBox)chkCach_tinh).CheckState = (CheckState)0;
		}
		if (Operators.CompareString(txtCach_tinh.Text.Trim(), "", false) == 0 && (Operators.CompareString(((TextBox)txtDsTK_no).Text.Trim(), "", false) != 0 || Operators.CompareString(((TextBox)txtDsTk_co).Text.Trim(), "", false) != 0))
		{
			((CheckBox)chkCach_tinh).CheckState = (CheckState)1;
		}
		chkCach_tinh_Click(null, null);
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
		ojb = (Control)(object)txtCach_tinh;
		CreateDataBinding(ref ojb, "cach_tinh");
		txtCach_tinh = (TextBox)ojb;
		ojb = (Control)(object)chkIn_ck;
		CreateDataBinding(ref ojb, "in_ck", "Checked");
		chkIn_ck = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkBold;
		CreateDataBinding(ref ojb, "bold", "Checked");
		chkBold = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)cboLoaiPS;
		CreateDataBinding(ref ojb, "no_co", "SelectedValue");
		cboLoaiPS = (AsComboBoxTT)(object)ojb;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_so).Enabled = false;
	}

	private void chkCach_tinh_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		CheckState checkState = ((CheckBox)chkCach_tinh).CheckState;
		if ((int)checkState == 1)
		{
			((TextBoxBase)txtCach_tinh).ReadOnly = true;
			((Control)txtCach_tinh).TabStop = false;
			((TextBoxBase)txtDsTK_no).ReadOnly = false;
			((TextBoxBase)txtDsTk_co).ReadOnly = false;
			((Control)txtDsTK_no).TabStop = true;
			((Control)txtDsTk_co).TabStop = true;
			((TextBoxBase)txtCach_tinh).Clear();
			((Control)txtDsTK_no).Focus();
			((Control)cboLoaiPS).Enabled = true;
		}
		else
		{
			((TextBoxBase)txtCach_tinh).ReadOnly = false;
			((Control)txtCach_tinh).TabStop = true;
			((TextBoxBase)txtDsTK_no).ReadOnly = true;
			((TextBoxBase)txtDsTk_co).ReadOnly = true;
			((Control)txtDsTK_no).TabStop = false;
			((Control)txtDsTk_co).TabStop = false;
			((Control)cboLoaiPS).Enabled = false;
			((ComboBox)cboLoaiPS).SelectedIndex = -1;
			((TextBoxBase)txtDsTK_no).Clear();
			((TextBoxBase)txtDsTk_co).Clear();
			((Control)txtCach_tinh).Focus();
		}
	}

	private void chkCach_tinh_Validated(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
		switch (((CheckBox)chkCach_tinh).CheckState - 1)
		{
		case 0:
			break;
		case 1:
			((Control)txtDsTk_co).Select();
			break;
		default:
			((Control)txtCach_tinh).Select();
			break;
		}
	}
}
