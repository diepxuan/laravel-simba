using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSOND51mhdEdit : frmDMEdit
{
	private IContainer components;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtTen_mau")]
	private TextBox _txtTen_mau;

	[AccessedThroughProperty("txtMa_loai")]
	private AsTextBox _txtMa_loai;

	[AccessedThroughProperty("txtGhi_chu")]
	private TextBox _txtGhi_chu;

	[AccessedThroughProperty("txtSo_dong")]
	private TextBox _txtSo_dong;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtKh_hd")]
	private AsTextBox _txtKh_hd;

	[AccessedThroughProperty("ShapeContainer1")]
	private ShapeContainer _ShapeContainer1;

	[AccessedThroughProperty("LineShape2")]
	private LineShape _LineShape2;

	[AccessedThroughProperty("LineShape1")]
	private LineShape _LineShape1;

	[AccessedThroughProperty("txtLoaiin")]
	private TextBox _txtLoaiin;

	[AccessedThroughProperty("lblMau_so")]
	private Label _lblMau_so;

	[AccessedThroughProperty("lblSo_seri")]
	private Label _lblSo_seri;

	[AccessedThroughProperty("txtKh_nam")]
	private AsTextNumeric _txtKh_nam;

	[AccessedThroughProperty("txtSo_hd")]
	private AsTextNumeric _txtSo_hd;

	[AccessedThroughProperty("txtLien")]
	private AsTextNumeric _txtLien;

	[AccessedThroughProperty("txtLoai_in")]
	private AsTextBox _txtLoai_in;

	[AccessedThroughProperty("dgvLien")]
	private AsInputDGV _dgvLien;

	[AccessedThroughProperty("Lien")]
	private DataGridViewTextBoxColumn _Lien;

	[AccessedThroughProperty("Mota")]
	private DataGridViewTextBoxColumn _Mota;

	[AccessedThroughProperty("txtLoai_hd")]
	private TextBox _txtLoai_hd;

	private string sHd;

	private DataTable oDt;

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

	internal virtual TextBox txtTen_mau
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_mau;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_mau = value;
		}
	}

	internal virtual AsTextBox txtMa_loai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_loai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_loai = value;
		}
	}

	internal virtual TextBox txtGhi_chu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGhi_chu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGhi_chu = value;
		}
	}

	internal virtual TextBox txtSo_dong
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_dong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_dong = value;
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

	internal virtual AsTextBox txtKh_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtKh_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = KyHieuChanged;
			if (_txtKh_hd != null)
			{
				((Control)_txtKh_hd).TextChanged -= eventHandler;
			}
			_txtKh_hd = value;
			if (_txtKh_hd != null)
			{
				((Control)_txtKh_hd).TextChanged += eventHandler;
			}
		}
	}

	internal virtual ShapeContainer ShapeContainer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ShapeContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ShapeContainer1 = value;
		}
	}

	internal virtual LineShape LineShape2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LineShape2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LineShape2 = value;
		}
	}

	internal virtual LineShape LineShape1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LineShape1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LineShape1 = value;
		}
	}

	internal virtual TextBox txtLoaiin
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLoaiin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtLoaiin = value;
		}
	}

	internal virtual Label lblMau_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMau_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMau_so = value;
		}
	}

	internal virtual Label lblSo_seri
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_seri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_seri = value;
		}
	}

	internal virtual AsTextNumeric txtKh_nam
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtKh_nam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtKh_nam_Leave;
			EventHandler eventHandler2 = KyHieuChanged;
			if (_txtKh_nam != null)
			{
				((Control)_txtKh_nam).Leave -= eventHandler;
				((Control)_txtKh_nam).TextChanged -= eventHandler2;
			}
			_txtKh_nam = value;
			if (_txtKh_nam != null)
			{
				((Control)_txtKh_nam).Leave += eventHandler;
				((Control)_txtKh_nam).TextChanged += eventHandler2;
			}
		}
	}

	internal virtual AsTextNumeric txtSo_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtSo_hd_Leave;
			EventHandler eventHandler2 = MauSoChanged;
			if (_txtSo_hd != null)
			{
				((Control)_txtSo_hd).Leave -= eventHandler;
				((Control)_txtSo_hd).TextChanged -= eventHandler2;
			}
			_txtSo_hd = value;
			if (_txtSo_hd != null)
			{
				((Control)_txtSo_hd).Leave += eventHandler;
				((Control)_txtSo_hd).TextChanged += eventHandler2;
			}
		}
	}

	internal virtual AsTextNumeric txtLien
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtLien_Leave;
			EventHandler eventHandler2 = MauSoChanged;
			if (_txtLien != null)
			{
				((Control)_txtLien).Leave -= eventHandler;
				((Control)_txtLien).TextChanged -= eventHandler2;
			}
			_txtLien = value;
			if (_txtLien != null)
			{
				((Control)_txtLien).Leave += eventHandler;
				((Control)_txtLien).TextChanged += eventHandler2;
			}
		}
	}

	internal virtual AsTextBox txtLoai_in
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLoai_in;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = KyHieuChanged;
			EventHandler eventHandler2 = txtLoai_in_TextChanged;
			if (_txtLoai_in != null)
			{
				((Control)_txtLoai_in).TextChanged -= eventHandler;
				((Control)_txtLoai_in).TextChanged -= eventHandler2;
			}
			_txtLoai_in = value;
			if (_txtLoai_in != null)
			{
				((Control)_txtLoai_in).TextChanged += eventHandler;
				((Control)_txtLoai_in).TextChanged += eventHandler2;
			}
		}
	}

	internal virtual AsInputDGV dgvLien
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvLien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvLien = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Lien
	{
		[DebuggerNonUserCode]
		get
		{
			return _Lien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Lien = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Mota
	{
		[DebuggerNonUserCode]
		get
		{
			return _Mota;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Mota = value;
		}
	}

	internal virtual TextBox txtLoai_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLoai_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtLoai_hd = value;
		}
	}

	public frmSOND51mhdEdit()
	{
		oDt = new DataTable();
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1199: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a3: Expected O, but got Unknown
		//IL_1232: Unknown result type (might be due to invalid IL or missing references)
		//IL_123c: Expected O, but got Unknown
		//IL_12cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d5: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		txtMa_loai = new AsTextBox();
		txtTen_mau = new TextBox();
		txtLoai_in = new AsTextBox();
		txtSo_dong = new TextBox();
		txtGhi_chu = new TextBox();
		Label8 = new Label();
		txtKh_hd = new AsTextBox();
		ShapeContainer1 = new ShapeContainer();
		LineShape2 = new LineShape();
		LineShape1 = new LineShape();
		txtLoaiin = new TextBox();
		lblMau_so = new Label();
		lblSo_seri = new Label();
		txtLien = new AsTextNumeric();
		txtSo_hd = new AsTextNumeric();
		txtKh_nam = new AsTextNumeric();
		dgvLien = new AsInputDGV();
		Lien = new DataGridViewTextBoxColumn();
		Mota = new DataGridViewTextBoxColumn();
		txtLoai_hd = new TextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((ISupportInitialize)dgvLien).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(134, 152);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 439);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 119;
		Button obj2 = cmdSave;
		location = new Point(12, 439);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 118;
		((Control)gbLine).Controls.Add((Control)(object)txtLoai_hd);
		((Control)gbLine).Controls.Add((Control)(object)dgvLien);
		((Control)gbLine).Controls.Add((Control)(object)txtKh_nam);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_hd);
		((Control)gbLine).Controls.Add((Control)(object)txtLien);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_seri);
		((Control)gbLine).Controls.Add((Control)(object)lblMau_so);
		((Control)gbLine).Controls.Add((Control)(object)txtLoaiin);
		((Control)gbLine).Controls.Add((Control)(object)txtKh_hd);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)txtGhi_chu);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_dong);
		((Control)gbLine).Controls.Add((Control)(object)txtLoai_in);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_mau);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_loai);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)ShapeContainer1);
		GroupBox obj3 = gbLine;
		Size size = new Size(396, 427);
		((Control)obj3).Size = size;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)ShapeContainer1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_loai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_mau, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtLoai_in, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_dong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGhi_chu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtKh_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtLoaiin, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMau_so, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_seri, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtLien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtKh_nam, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)dgvLien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtLoai_hd, 0);
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(17, 23);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(70, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 100;
		Label1.Text = "Loại hoá đơn";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(17, 49);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(42, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 101;
		Label2.Text = "Mẫu số";
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(17, 76);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(49, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 102;
		Label3.Text = "Tên mẫu";
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(17, 102);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(38, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 103;
		Label4.Text = "Loại in";
		Label5.AutoSize = true;
		Label label9 = Label5;
		location = new Point(17, 128);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(42, 13);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 104;
		Label5.Text = "Ký hiệu";
		Label6.AutoSize = true;
		Label label11 = Label6;
		location = new Point(17, 154);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(47, 13);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 105;
		Label6.Text = "Số dòng";
		Label7.AutoSize = true;
		Label label13 = Label7;
		location = new Point(17, 180);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(44, 13);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 106;
		Label7.Text = "Ghi chú";
		txtMa_loai.AutoLookup = false;
		txtMa_loai.AutoValid = false;
		((TextBoxBase)txtMa_loai).BackColor = Color.White;
		((TextBox)txtMa_loai).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_loai).Enabled = false;
		AsTextBox asTextBox = txtMa_loai;
		location = new Point(97, 45);
		((Control)asTextBox).Location = location;
		txtMa_loai.LookupCodeName = "";
		((Control)txtMa_loai).Name = "txtMa_loai";
		txtMa_loai.NameControl = null;
		AsTextBox asTextBox2 = txtMa_loai;
		size = new Size(53, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_loai).TabIndex = 108;
		txtMa_loai.UseAutoCompleteSource = true;
		((TextBoxBase)txtTen_mau).BackColor = Color.White;
		TextBox obj4 = txtTen_mau;
		location = new Point(97, 72);
		((Control)obj4).Location = location;
		((Control)txtTen_mau).Name = "txtTen_mau";
		TextBox obj5 = txtTen_mau;
		size = new Size(279, 20);
		((Control)obj5).Size = size;
		((Control)txtTen_mau).TabIndex = 111;
		txtLoai_in.AutoLookup = false;
		txtLoai_in.AutoValid = false;
		((TextBoxBase)txtLoai_in).BackColor = Color.White;
		((TextBox)txtLoai_in).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtLoai_in;
		location = new Point(97, 98);
		((Control)asTextBox3).Location = location;
		txtLoai_in.LookupCodeName = "";
		((Control)txtLoai_in).Name = "txtLoai_in";
		txtLoai_in.NameControl = null;
		AsTextBox asTextBox4 = txtLoai_in;
		size = new Size(53, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtLoai_in).TabIndex = 112;
		txtLoai_in.UseAutoCompleteSource = true;
		((TextBoxBase)txtSo_dong).BackColor = Color.White;
		TextBox obj6 = txtSo_dong;
		location = new Point(97, 150);
		((Control)obj6).Location = location;
		((Control)txtSo_dong).Name = "txtSo_dong";
		TextBox obj7 = txtSo_dong;
		size = new Size(29, 20);
		((Control)obj7).Size = size;
		((Control)txtSo_dong).TabIndex = 116;
		((TextBoxBase)txtGhi_chu).BackColor = Color.White;
		TextBox obj8 = txtGhi_chu;
		location = new Point(97, 176);
		((Control)obj8).Location = location;
		((Control)txtGhi_chu).Name = "txtGhi_chu";
		TextBox obj9 = txtGhi_chu;
		size = new Size(279, 20);
		((Control)obj9).Size = size;
		((Control)txtGhi_chu).TabIndex = 117;
		Label8.AutoSize = true;
		Label label15 = Label8;
		location = new Point(161, 102);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(97, 13);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 116;
		Label8.Text = "T - Tự in; P - Đặt in";
		txtKh_hd.AutoLookup = false;
		txtKh_hd.AutoValid = false;
		((TextBoxBase)txtKh_hd).BackColor = Color.White;
		((TextBox)txtKh_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtKh_hd;
		location = new Point(97, 124);
		((Control)asTextBox5).Location = location;
		txtKh_hd.LookupCodeName = "";
		((Control)txtKh_hd).Name = "txtKh_hd";
		txtKh_hd.NameControl = null;
		AsTextBox asTextBox6 = txtKh_hd;
		size = new Size(53, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtKh_hd).TabIndex = 113;
		((TextBox)txtKh_hd).Text = "AA";
		((TextBox)txtKh_hd).TextAlign = (HorizontalAlignment)1;
		txtKh_hd.UseAutoCompleteSource = true;
		ShapeContainer shapeContainer = ShapeContainer1;
		location = new Point(3, 16);
		((Control)shapeContainer).Location = location;
		ShapeContainer shapeContainer2 = ShapeContainer1;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Control)shapeContainer2).Margin = margin;
		((Control)ShapeContainer1).Name = "ShapeContainer1";
		ShapeContainer1.Shapes.AddRange(new Shape[2] { LineShape2, LineShape1 });
		ShapeContainer shapeContainer3 = ShapeContainer1;
		size = new Size(390, 408);
		((Control)shapeContainer3).Size = size;
		((Control)ShapeContainer1).TabIndex = 121;
		((Control)ShapeContainer1).TabStop = false;
		LineShape2.Name = "LineShape2";
		LineShape2.X1 = 200;
		LineShape2.X2 = 193;
		LineShape2.Y1 = 30;
		LineShape2.Y2 = 47;
		LineShape1.Name = "LineShape1";
		LineShape1.X1 = 157;
		LineShape1.X2 = 150;
		LineShape1.Y1 = 109;
		LineShape1.Y2 = 126;
		((TextBoxBase)txtLoaiin).BackColor = Color.White;
		((Control)txtLoaiin).Enabled = false;
		TextBox obj10 = txtLoaiin;
		location = new Point(206, 124);
		((Control)obj10).Location = location;
		((Control)txtLoaiin).Name = "txtLoaiin";
		TextBox obj11 = txtLoaiin;
		size = new Size(48, 20);
		((Control)obj11).Size = size;
		((Control)txtLoaiin).TabIndex = 115;
		Label obj12 = lblMau_so;
		location = new Point(268, 45);
		((Control)obj12).Location = location;
		((Control)lblMau_so).Name = "lblMau_so";
		Label obj13 = lblMau_so;
		size = new Size(99, 20);
		((Control)obj13).Size = size;
		((Control)lblMau_so).TabIndex = 122;
		lblMau_so.TextAlign = (ContentAlignment)16;
		Label obj14 = lblSo_seri;
		location = new Point(268, 124);
		((Control)obj14).Location = location;
		((Control)lblSo_seri).Name = "lblSo_seri";
		Label obj15 = lblSo_seri;
		size = new Size(99, 20);
		((Control)obj15).Size = size;
		((Control)lblSo_seri).TabIndex = 123;
		lblSo_seri.TextAlign = (ContentAlignment)16;
		((TextBoxBase)txtLien).BackColor = Color.White;
		txtLien.DecimalSymbol = ".";
		txtLien.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtLien;
		location = new Point(153, 45);
		((Control)asTextNumeric).Location = location;
		txtLien.Mask = "0";
		((Control)txtLien).Name = "txtLien";
		AsTextNumeric asTextNumeric2 = txtLien;
		size = new Size(40, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtLien).TabIndex = 109;
		((TextBox)txtLien).Text = "2";
		((TextBox)txtLien).TextAlign = (HorizontalAlignment)1;
		txtLien.Value = 2;
		((TextBoxBase)txtSo_hd).BackColor = Color.White;
		txtSo_hd.DecimalSymbol = ".";
		txtSo_hd.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtSo_hd;
		location = new Point(207, 45);
		((Control)asTextNumeric3).Location = location;
		txtSo_hd.Mask = "000";
		((Control)txtSo_hd).Name = "txtSo_hd";
		AsTextNumeric asTextNumeric4 = txtSo_hd;
		size = new Size(40, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtSo_hd).TabIndex = 110;
		((TextBox)txtSo_hd).Text = "1";
		((TextBox)txtSo_hd).TextAlign = (HorizontalAlignment)1;
		txtSo_hd.Value = 1;
		((TextBoxBase)txtKh_nam).BackColor = Color.White;
		txtKh_nam.DecimalSymbol = ".";
		txtKh_nam.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtKh_nam;
		location = new Point(164, 124);
		((Control)asTextNumeric5).Location = location;
		txtKh_nam.Mask = "00";
		((Control)txtKh_nam).Name = "txtKh_nam";
		AsTextNumeric asTextNumeric6 = txtKh_nam;
		size = new Size(40, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtKh_nam).TabIndex = 114;
		((TextBox)txtKh_nam).Text = "11";
		((TextBox)txtKh_nam).TextAlign = (HorizontalAlignment)1;
		txtKh_nam.Value = 11;
		((DataGridView)dgvLien).AllowUserToAddRows = false;
		((DataGridView)dgvLien).AllowUserToDeleteRows = false;
		((DataGridView)dgvLien).BackgroundColor = Color.White;
		((DataGridView)dgvLien).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvLien).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)dgvLien).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvLien).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)Lien,
			(DataGridViewColumn)Mota
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvLien).DefaultCellStyle = val2;
		((DataGridView)dgvLien).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = dgvLien;
		location = new Point(14, 205);
		((Control)asInputDGV).Location = location;
		((Control)dgvLien).Name = "dgvLien";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvLien).RowHeadersDefaultCellStyle = val3;
		((DataGridView)dgvLien).RowHeadersVisible = false;
		((DataGridView)dgvLien).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)dgvLien).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = dgvLien;
		size = new Size(362, 203);
		((Control)asInputDGV2).Size = size;
		((Control)dgvLien).TabIndex = 124;
		((DataGridViewColumn)Lien).DataPropertyName = "lien";
		((DataGridViewColumn)Lien).HeaderText = "Liên";
		((DataGridViewColumn)Lien).Name = "Lien";
		((DataGridViewColumn)Lien).ReadOnly = true;
		((DataGridViewColumn)Lien).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)Lien).Width = 70;
		((DataGridViewColumn)Mota).DataPropertyName = "mota";
		((DataGridViewColumn)Mota).HeaderText = "Mô Ta\u0309";
		((DataGridViewColumn)Mota).Name = "Mota";
		((DataGridViewColumn)Mota).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)Mota).Width = 289;
		((Control)txtLoai_hd).Enabled = false;
		TextBox obj16 = txtLoai_hd;
		location = new Point(97, 19);
		((Control)obj16).Location = location;
		((Control)txtLoai_hd).Name = "txtLoai_hd";
		TextBox obj17 = txtLoai_hd;
		size = new Size(279, 20);
		((Control)obj17).Size = size;
		((Control)txtLoai_hd).TabIndex = 107;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(420, 474);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSOND51mhdEdit";
		((Form)this).Text = "frmSODMMHDEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((ISupportInitialize)dgvLien).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((Control)txtLien).Select();
		MakeTable();
		NapGrid(3);
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		GetData();
		SetMauSo();
		SetKyHieu();
		((Control)txtTen_mau).Select();
		((Control)txtLien).Select();
	}

	protected override bool ValidData()
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(((TextBox)txtLien).Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtLien, Helper.GetMess(50002).Description);
			return false;
		}
		if (Operators.CompareString(((TextBox)txtSo_hd).Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtSo_hd, Helper.GetMess(50002).Description);
			return false;
		}
		if (!EditMode && Conversions.ToDouble(((TextBox)txtSo_hd).Text) == 0.0)
		{
			CMessageBox.Show(50153);
			((Control)txtSo_hd).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtTen_mau))
		{
			epNotice.SetError((Control)(object)txtTen_mau, Helper.GetMess(50002).Description);
			return false;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtLoai_in))
		{
			epNotice.SetError((Control)(object)txtLoai_in, Helper.GetMess(50002).Description);
			return false;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtKh_hd))
		{
			epNotice.SetError((Control)(object)txtKh_hd, Helper.GetMess(50002).Description);
			return false;
		}
		if (Operators.CompareString(((TextBox)txtKh_nam).Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtKh_nam, Helper.GetMess(50002).Description);
			return false;
		}
		if (!ChkEmtyTextBox(txtSo_dong))
		{
			epNotice.SetError((Control)(object)txtSo_dong, Helper.GetMess(50002).Description);
			return false;
		}
		switch (Convert.ToInt32(((TextBox)txtLien).Text))
		{
		case 3:
			if (!CheckGrid(2))
			{
				return false;
			}
			break;
		case 4:
			if (!CheckGrid(2))
			{
				return false;
			}
			if (!CheckGrid(3))
			{
				return false;
			}
			break;
		case 5:
			if (!CheckGrid(2))
			{
				return false;
			}
			if (!CheckGrid(3))
			{
				return false;
			}
			if (!CheckGrid(4))
			{
				return false;
			}
			break;
		case 6:
			if (!CheckGrid(2))
			{
				return false;
			}
			if (!CheckGrid(3))
			{
				return false;
			}
			if (!CheckGrid(4))
			{
				return false;
			}
			if (!CheckGrid(5))
			{
				return false;
			}
			break;
		case 7:
			if (!CheckGrid(2))
			{
				return false;
			}
			if (!CheckGrid(3))
			{
				return false;
			}
			if (!CheckGrid(4))
			{
				return false;
			}
			if (!CheckGrid(5))
			{
				return false;
			}
			if (!CheckGrid(6))
			{
				return false;
			}
			break;
		case 8:
			if (!CheckGrid(2))
			{
				return false;
			}
			if (!CheckGrid(3))
			{
				return false;
			}
			if (!CheckGrid(4))
			{
				return false;
			}
			if (!CheckGrid(5))
			{
				return false;
			}
			if (!CheckGrid(6))
			{
				return false;
			}
			if (!CheckGrid(7))
			{
				return false;
			}
			break;
		case 9:
			if (!CheckGrid(2))
			{
				return false;
			}
			if (!CheckGrid(3))
			{
				return false;
			}
			if (!CheckGrid(4))
			{
				return false;
			}
			if (!CheckGrid(5))
			{
				return false;
			}
			if (!CheckGrid(6))
			{
				return false;
			}
			if (!CheckGrid(7))
			{
				return false;
			}
			if (!CheckGrid(8))
			{
				return false;
			}
			break;
		}
		return base.ValidData();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtSo_hd).Enabled = false;
	}

	protected override bool InsertToDB()
	{
		((Control)txtTen_mau).Select();
		bool flag = base.InsertToDB();
		if (flag)
		{
			InsertToCTPH();
		}
		else
		{
			((Control)txtSo_hd).Select();
		}
		return flag;
	}

	protected override bool UpdateDB()
	{
		bool flag = base.UpdateDB();
		if (flag)
		{
			SOND51mhdDAO sOND51mhdDAO = (SOND51mhdDAO)DAOFactory.CreateDAOInstance("SOND51mhdDAO", "SOND51mhd");
			int num = sOND51mhdDAO.Delete(((TextBox)txtMa_loai).Text, ((TextBox)txtSo_hd).Text);
			sOND51mhdDAO.Destroy();
			InsertToCTPH();
		}
		return flag;
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtLoai_hd;
		CreateDataBinding(ref ojb, "loai_hd");
		txtLoai_hd = (TextBox)ojb;
		ojb = (Control)(object)txtMa_loai;
		CreateDataBinding(ref ojb, "ma_loai");
		txtMa_loai = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtLien;
		CreateDataBinding(ref ojb, "lien");
		txtLien = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSo_hd;
		CreateDataBinding(ref ojb, "so_hd");
		txtSo_hd = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)lblMau_so;
		CreateDataBinding(ref ojb, "mau_so");
		lblMau_so = (Label)ojb;
		ojb = (Control)(object)txtTen_mau;
		CreateDataBinding(ref ojb, "ten_mau");
		txtTen_mau = (TextBox)ojb;
		ojb = (Control)(object)txtLoai_in;
		CreateDataBinding(ref ojb, "loai_in");
		txtLoai_in = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtKh_hd;
		CreateDataBinding(ref ojb, "kh_hd");
		txtKh_hd = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtKh_nam;
		CreateDataBinding(ref ojb, "kh_nam");
		txtKh_nam = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)lblSo_seri;
		CreateDataBinding(ref ojb, "so_seri");
		lblSo_seri = (Label)ojb;
		ojb = (Control)(object)txtSo_dong;
		CreateDataBinding(ref ojb, "so_dong");
		txtSo_dong = (TextBox)ojb;
		ojb = (Control)(object)txtGhi_chu;
		CreateDataBinding(ref ojb, "ghi_chu");
		txtGhi_chu = (TextBox)ojb;
	}

	private void txtLoai_in_TextChanged(object sender, EventArgs e)
	{
		txtLoaiin.Text = ((TextBox)txtLoai_in).Text;
	}

	private void MauSoChanged(object sender, EventArgs e)
	{
		SetMauSo();
	}

	private void KyHieuChanged(object sender, EventArgs e)
	{
		SetKyHieu();
	}

	private void txtLien_Leave(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if ((Conversions.ToDouble(((TextBox)txtLien).Text) < 2.0) | (Conversions.ToDouble(((TextBox)txtLien).Text) > 9.0))
		{
			CMessageBox.Show(50154);
			return;
		}
		int so_lien = checked(Convert.ToInt32(((TextBox)txtLien).Text) - 1);
		NapGrid(so_lien);
		if (EditMode)
		{
			GetData();
		}
	}

	private void txtSo_hd_Leave(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(((TextBox)txtSo_hd).Text) < 1.0)
		{
			CMessageBox.Show(50153);
			((Control)txtSo_hd).Select();
		}
		((TextBox)txtSo_hd).Text = sHd;
	}

	private void txtKh_nam_Leave(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(((TextBox)txtKh_nam).Text) < 1.0)
		{
			CMessageBox.Show(50155);
			((Control)txtKh_nam).Select();
		}
	}

	protected void GetData()
	{
		SOND51mhdDAO sOND51mhdDAO = (SOND51mhdDAO)DAOFactory.CreateDAOInstance("SOND51mhdDAO", "SOND51mhd");
		DataTable data = sOND51mhdDAO.GetData(((TextBox)txtMa_loai).Text, ((TextBox)txtSo_hd).Text);
		sOND51mhdDAO.Destroy();
		checked
		{
			if (data.Rows.Count != 0)
			{
				int num = ((DataGridView)dgvLien).RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					((DataGridView)dgvLien)["mota", i].Value = data.Rows[0][i].ToString();
				}
			}
		}
	}

	protected void InsertToCTPH()
	{
		SOND51mhdDAO sOND51mhdDAO = (SOND51mhdDAO)DAOFactory.CreateDAOInstance("SOND51mhdDAO", "SOND51mhd");
		string text = ((TextBox)txtLien).Text;
		if (Operators.CompareString(text, Conversions.ToString(3), false) == 0)
		{
			int num = sOND51mhdDAO.Insert(((TextBox)txtMa_loai).Text, ((TextBox)txtSo_hd).Text, Conversions.ToString(((DataGridView)dgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 2].Value));
		}
		else if (Operators.CompareString(text, Conversions.ToString(4), false) == 0)
		{
			int num = sOND51mhdDAO.Insert(((TextBox)txtMa_loai).Text, ((TextBox)txtSo_hd).Text, Conversions.ToString(((DataGridView)dgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 2].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 3].Value));
		}
		else if (Operators.CompareString(text, Conversions.ToString(5), false) == 0)
		{
			int num = sOND51mhdDAO.Insert(((TextBox)txtMa_loai).Text, ((TextBox)txtSo_hd).Text, Conversions.ToString(((DataGridView)dgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 2].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 3].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 4].Value));
		}
		else if (Operators.CompareString(text, Conversions.ToString(6), false) == 0)
		{
			int num = sOND51mhdDAO.Insert(((TextBox)txtMa_loai).Text, ((TextBox)txtSo_hd).Text, Conversions.ToString(((DataGridView)dgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 2].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 3].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 4].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 5].Value));
		}
		else if (Operators.CompareString(text, Conversions.ToString(7), false) == 0)
		{
			int num = sOND51mhdDAO.Insert(((TextBox)txtMa_loai).Text, ((TextBox)txtSo_hd).Text, Conversions.ToString(((DataGridView)dgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 2].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 3].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 4].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 5].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 6].Value));
		}
		else if (Operators.CompareString(text, Conversions.ToString(8), false) == 0)
		{
			int num = sOND51mhdDAO.Insert(((TextBox)txtMa_loai).Text, ((TextBox)txtSo_hd).Text, Conversions.ToString(((DataGridView)dgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 2].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 3].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 4].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 5].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 6].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 7].Value));
		}
		else if (Operators.CompareString(text, Conversions.ToString(9), false) == 0)
		{
			int num = sOND51mhdDAO.Insert(((TextBox)txtMa_loai).Text, ((TextBox)txtSo_hd).Text, Conversions.ToString(((DataGridView)dgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 2].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 3].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 4].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 5].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 6].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 7].Value), Conversions.ToString(((DataGridView)dgvLien)["mota", 8].Value));
		}
		sOND51mhdDAO.Destroy();
	}

	protected bool CheckGrid(int lien)
	{
		string text = "Liên " + Conversions.ToString(checked(lien + 1)) + ":";
		if (Operators.CompareString(((DataGridView)dgvLien)["mota", lien].Value.ToString(), "", false) == 0)
		{
			((DataGridView)dgvLien)[((DataGridViewColumn)Mota).Name, lien].ErrorText = Helper.GetMess(50002).Description;
			return false;
		}
		if (((DataGridView)dgvLien)["mota", lien].Value.ToString().Length < 8)
		{
			((DataGridView)dgvLien)[((DataGridViewColumn)Mota).Name, lien].ErrorText = "Phải bắt đầu bằng '" + text + "'!";
			return false;
		}
		if (Operators.CompareString(((DataGridView)dgvLien)["mota", lien].Value.ToString().Substring(0, 7), text, false) != 0)
		{
			((DataGridView)dgvLien)[((DataGridViewColumn)Mota).Name, lien].ErrorText = "Phải bắt đầu bằng '" + text + "'!";
			return false;
		}
		return true;
	}

	protected void SetMauSo()
	{
		sHd = ((TextBox)txtSo_hd).Text;
		switch (sHd.Length)
		{
		case 1:
			sHd = "00" + sHd;
			break;
		case 2:
			sHd = "0" + sHd;
			break;
		}
		lblMau_so.Text = ((TextBox)txtMa_loai).Text + ((TextBox)txtLien).Text + "/" + sHd;
	}

	protected void SetKyHieu()
	{
		lblSo_seri.Text = ((TextBox)txtKh_hd).Text + "/" + ((TextBox)txtKh_nam).Text + txtLoaiin.Text;
	}

	protected void MakeTable()
	{
		DataColumn column = new DataColumn("lien");
		DataColumn column2 = new DataColumn("mota");
		oDt.Columns.Add(column);
		oDt.Columns.Add(column2);
		((DataGridView)dgvLien).DataSource = oDt;
	}

	protected void NapGrid(int so_lien)
	{
		ClearList();
		checked
		{
			if (((DataGridView)dgvLien).RowCount == 0)
			{
				for (int i = 1; i <= so_lien; i++)
				{
					DataRow dataRow = oDt.NewRow();
					dataRow["lien"] = "Liên " + Conversions.ToString(i);
					dataRow["mota"] = "";
					oDt.Rows.Add(dataRow);
				}
			}
			else
			{
				for (int j = 2; j <= so_lien; j++)
				{
					DataRow dataRow = oDt.NewRow();
					dataRow["lien"] = "Liên " + Conversions.ToString(j + 1);
					dataRow["mota"] = "";
					oDt.Rows.Add(dataRow);
				}
			}
			((DataGridView)dgvLien)["mota", 0].ReadOnly = true;
			((DataGridView)dgvLien)["mota", 1].ReadOnly = true;
		}
	}

	protected void ClearList()
	{
		checked
		{
			for (int i = ((DataGridView)dgvLien).RowCount - 1; i >= 2; i += -1)
			{
				((DataGridView)dgvLien).Rows.RemoveAt(i);
			}
		}
	}
}
