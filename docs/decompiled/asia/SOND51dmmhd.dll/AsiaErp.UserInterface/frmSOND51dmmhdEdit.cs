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

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSOND51dmmhdEdit : frmDMEdit
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

	[AccessedThroughProperty("txtKh_hd")]
	private AsTextBox _txtKh_hd;

	[AccessedThroughProperty("txtLoai_in")]
	private TextBox _txtLoai_in;

	[AccessedThroughProperty("lblMau_so")]
	private Label _lblMau_so;

	[AccessedThroughProperty("lblSo_seri")]
	private Label _lblSo_seri;

	[AccessedThroughProperty("txtKh_nam")]
	private AsTextNumeric _txtKh_nam;

	[AccessedThroughProperty("adgvLien")]
	private AsInputDGV _adgvLien;

	[AccessedThroughProperty("Lien")]
	private DataGridViewTextBoxColumn _Lien;

	[AccessedThroughProperty("Mota")]
	private DataGridViewTextBoxColumn _Mota;

	[AccessedThroughProperty("txtTen_loai")]
	private TextBox _txtTen_loai;

	[AccessedThroughProperty("chkDat_in")]
	private RadioButton _chkDat_in;

	[AccessedThroughProperty("chkTu_in")]
	private RadioButton _chkTu_in;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("txtSo_hd")]
	private AsTextNumeric _txtSo_hd;

	[AccessedThroughProperty("txtSo_lien")]
	private AsTextNumeric _txtSo_lien;

	private string sHd;

	private string sMau_so;

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

	internal virtual TextBox txtLoai_in
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
			if (_txtLoai_in != null)
			{
				((Control)_txtLoai_in).TextChanged -= eventHandler;
			}
			_txtLoai_in = value;
			if (_txtLoai_in != null)
			{
				((Control)_txtLoai_in).TextChanged += eventHandler;
			}
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

	internal virtual AsInputDGV adgvLien
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvLien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvLien = value;
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

	internal virtual TextBox txtTen_loai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_loai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_loai = value;
		}
	}

	internal virtual RadioButton chkDat_in
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkDat_in;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkDat_in = value;
		}
	}

	internal virtual RadioButton chkTu_in
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkTu_in;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkTu_in_CheckedChanged;
			if (_chkTu_in != null)
			{
				_chkTu_in.CheckedChanged -= eventHandler;
			}
			_chkTu_in = value;
			if (_chkTu_in != null)
			{
				_chkTu_in.CheckedChanged += eventHandler;
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

	internal virtual AsTextNumeric txtSo_lien
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_lien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtLien_Leave;
			EventHandler eventHandler2 = MauSoChanged;
			if (_txtSo_lien != null)
			{
				((Control)_txtSo_lien).Leave -= eventHandler;
				((Control)_txtSo_lien).TextChanged -= eventHandler2;
			}
			_txtSo_lien = value;
			if (_txtSo_lien != null)
			{
				((Control)_txtSo_lien).Leave += eventHandler;
				((Control)_txtSo_lien).TextChanged += eventHandler2;
			}
		}
	}

	public frmSOND51dmmhdEdit()
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
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0e15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1f: Expected O, but got Unknown
		//IL_0eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb8: Expected O, but got Unknown
		//IL_0f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f51: Expected O, but got Unknown
		//IL_1211: Unknown result type (might be due to invalid IL or missing references)
		//IL_121b: Expected O, but got Unknown
		//IL_1419: Unknown result type (might be due to invalid IL or missing references)
		//IL_1423: Expected O, but got Unknown
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
		txtSo_dong = new TextBox();
		txtGhi_chu = new TextBox();
		txtKh_hd = new AsTextBox();
		txtLoai_in = new TextBox();
		lblMau_so = new Label();
		lblSo_seri = new Label();
		txtKh_nam = new AsTextNumeric();
		adgvLien = new AsInputDGV();
		Lien = new DataGridViewTextBoxColumn();
		Mota = new DataGridViewTextBoxColumn();
		txtTen_loai = new TextBox();
		chkTu_in = new RadioButton();
		chkDat_in = new RadioButton();
		Label8 = new Label();
		txtSo_hd = new AsTextNumeric();
		txtSo_lien = new AsTextNumeric();
		Label9 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((ISupportInitialize)adgvLien).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(134, 152);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 11;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 439);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 439);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)Label9);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_hd);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_lien);
		((Control)gbLine).Controls.Add((Control)(object)chkDat_in);
		((Control)gbLine).Controls.Add((Control)(object)chkTu_in);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_loai);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)adgvLien);
		((Control)gbLine).Controls.Add((Control)(object)txtKh_nam);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_seri);
		((Control)gbLine).Controls.Add((Control)(object)lblMau_so);
		((Control)gbLine).Controls.Add((Control)(object)txtLoai_in);
		((Control)gbLine).Controls.Add((Control)(object)txtKh_hd);
		((Control)gbLine).Controls.Add((Control)(object)txtGhi_chu);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_dong);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_mau);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_loai);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		GroupBox obj3 = gbLine;
		Size size = new Size(396, 427);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_loai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_mau, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_dong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGhi_chu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtKh_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtLoai_in, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMau_so, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_seri, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtKh_nam, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)adgvLien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_loai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkTu_in, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkDat_in, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_lien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label9, 0);
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
		((Control)txtMa_loai).TabIndex = 1;
		txtMa_loai.UseAutoCompleteSource = true;
		((TextBoxBase)txtTen_mau).BackColor = Color.White;
		TextBox obj4 = txtTen_mau;
		location = new Point(97, 72);
		((Control)obj4).Location = location;
		((Control)txtTen_mau).Name = "txtTen_mau";
		TextBox obj5 = txtTen_mau;
		size = new Size(279, 20);
		((Control)obj5).Size = size;
		((Control)txtTen_mau).TabIndex = 4;
		((TextBoxBase)txtSo_dong).BackColor = Color.White;
		TextBox obj6 = txtSo_dong;
		location = new Point(97, 150);
		((Control)obj6).Location = location;
		((Control)txtSo_dong).Name = "txtSo_dong";
		TextBox obj7 = txtSo_dong;
		size = new Size(29, 20);
		((Control)obj7).Size = size;
		((Control)txtSo_dong).TabIndex = 10;
		((TextBoxBase)txtGhi_chu).BackColor = Color.White;
		TextBox obj8 = txtGhi_chu;
		location = new Point(97, 176);
		((Control)obj8).Location = location;
		((Control)txtGhi_chu).Name = "txtGhi_chu";
		TextBox obj9 = txtGhi_chu;
		size = new Size(279, 20);
		((Control)obj9).Size = size;
		((Control)txtGhi_chu).TabIndex = 12;
		txtKh_hd.AutoLookup = false;
		txtKh_hd.AutoValid = false;
		((TextBoxBase)txtKh_hd).BackColor = Color.White;
		((TextBox)txtKh_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtKh_hd;
		location = new Point(97, 124);
		((Control)asTextBox3).Location = location;
		txtKh_hd.LookupCodeName = "";
		((Control)txtKh_hd).Name = "txtKh_hd";
		txtKh_hd.NameControl = null;
		AsTextBox asTextBox4 = txtKh_hd;
		size = new Size(53, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtKh_hd).TabIndex = 7;
		((TextBox)txtKh_hd).Text = "AA";
		((TextBox)txtKh_hd).TextAlign = (HorizontalAlignment)1;
		txtKh_hd.UseAutoCompleteSource = true;
		((TextBoxBase)txtLoai_in).BackColor = Color.White;
		((Control)txtLoai_in).Enabled = false;
		TextBox obj10 = txtLoai_in;
		location = new Point(206, 124);
		((Control)obj10).Location = location;
		((Control)txtLoai_in).Name = "txtLoai_in";
		TextBox obj11 = txtLoai_in;
		size = new Size(48, 20);
		((Control)obj11).Size = size;
		((Control)txtLoai_in).TabIndex = 9;
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
		((TextBoxBase)txtKh_nam).BackColor = Color.White;
		txtKh_nam.DecimalSymbol = ".";
		txtKh_nam.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtKh_nam;
		location = new Point(164, 124);
		((Control)asTextNumeric).Location = location;
		txtKh_nam.Mask = "00";
		((Control)txtKh_nam).Name = "txtKh_nam";
		AsTextNumeric asTextNumeric2 = txtKh_nam;
		size = new Size(40, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtKh_nam).TabIndex = 8;
		((TextBox)txtKh_nam).Text = "11";
		((TextBox)txtKh_nam).TextAlign = (HorizontalAlignment)1;
		txtKh_nam.Value = 11;
		((DataGridView)adgvLien).AllowUserToAddRows = false;
		((DataGridView)adgvLien).AllowUserToDeleteRows = false;
		((DataGridView)adgvLien).BackgroundColor = Color.White;
		((DataGridView)adgvLien).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvLien).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)adgvLien).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvLien).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
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
		((DataGridView)adgvLien).DefaultCellStyle = val2;
		((DataGridView)adgvLien).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = adgvLien;
		location = new Point(14, 205);
		((Control)asInputDGV).Location = location;
		((Control)adgvLien).Name = "adgvLien";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvLien).RowHeadersDefaultCellStyle = val3;
		((DataGridView)adgvLien).RowHeadersVisible = false;
		((DataGridView)adgvLien).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)adgvLien).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = adgvLien;
		size = new Size(362, 203);
		((Control)asInputDGV2).Size = size;
		((Control)adgvLien).TabIndex = 13;
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
		((Control)txtTen_loai).Enabled = false;
		TextBox obj16 = txtTen_loai;
		location = new Point(97, 19);
		((Control)obj16).Location = location;
		((Control)txtTen_loai).Name = "txtTen_loai";
		TextBox obj17 = txtTen_loai;
		size = new Size(279, 20);
		((Control)obj17).Size = size;
		((Control)txtTen_loai).TabIndex = 0;
		((ButtonBase)chkTu_in).AutoSize = true;
		chkTu_in.Checked = true;
		RadioButton obj18 = chkTu_in;
		location = new Point(97, 100);
		((Control)obj18).Location = location;
		((Control)chkTu_in).Name = "chkTu_in";
		RadioButton obj19 = chkTu_in;
		size = new Size(65, 17);
		((Control)obj19).Size = size;
		((Control)chkTu_in).TabIndex = 5;
		chkTu_in.TabStop = true;
		((ButtonBase)chkTu_in).Text = "Tự in (T)";
		((ButtonBase)chkTu_in).UseVisualStyleBackColor = true;
		((ButtonBase)chkDat_in).AutoSize = true;
		RadioButton obj20 = chkDat_in;
		location = new Point(173, 100);
		((Control)obj20).Location = location;
		((Control)chkDat_in).Name = "chkDat_in";
		RadioButton obj21 = chkDat_in;
		size = new Size(69, 17);
		((Control)obj21).Size = size;
		((Control)chkDat_in).TabIndex = 6;
		chkDat_in.TabStop = true;
		((ButtonBase)chkDat_in).Text = "Đặt in (P)";
		((ButtonBase)chkDat_in).UseVisualStyleBackColor = true;
		Label8.AutoSize = true;
		((Control)Label8).BackColor = Color.Transparent;
		((Control)Label8).Font = new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label15 = Label8;
		location = new Point(194, 43);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(15, 24);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 127;
		Label8.Text = "/";
		((TextBoxBase)txtSo_hd).BackColor = Color.White;
		txtSo_hd.DecimalSymbol = ".";
		txtSo_hd.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtSo_hd;
		location = new Point(209, 45);
		((Control)asTextNumeric3).Location = location;
		txtSo_hd.Mask = "000";
		((Control)txtSo_hd).Name = "txtSo_hd";
		AsTextNumeric asTextNumeric4 = txtSo_hd;
		size = new Size(40, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtSo_hd).TabIndex = 3;
		((TextBox)txtSo_hd).Text = "1";
		((TextBox)txtSo_hd).TextAlign = (HorizontalAlignment)1;
		txtSo_hd.Value = 1;
		((TextBoxBase)txtSo_lien).BackColor = Color.White;
		txtSo_lien.DecimalSymbol = ".";
		txtSo_lien.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtSo_lien;
		location = new Point(154, 45);
		((Control)asTextNumeric5).Location = location;
		txtSo_lien.Mask = "0";
		((Control)txtSo_lien).Name = "txtSo_lien";
		AsTextNumeric asTextNumeric6 = txtSo_lien;
		size = new Size(40, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtSo_lien).TabIndex = 2;
		((TextBox)txtSo_lien).Text = "2";
		((TextBox)txtSo_lien).TextAlign = (HorizontalAlignment)1;
		txtSo_lien.Value = 2;
		Label9.AutoSize = true;
		((Control)Label9).BackColor = Color.Transparent;
		((Control)Label9).Font = new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label17 = Label9;
		location = new Point(151, 122);
		((Control)label17).Location = location;
		((Control)Label9).Name = "Label9";
		Label label18 = Label9;
		size = new Size(15, 24);
		((Control)label18).Size = size;
		((Control)Label9).TabIndex = 130;
		Label9.Text = "/";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(420, 474);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSOND51dmmhdEdit";
		((Form)this).Text = "frmSODMMHDEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((ISupportInitialize)adgvLien).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		MakeTable();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		NapGrid(Conversions.ToInteger(txtSo_lien.Value));
		SetMauSo();
		SetKyHieu();
		if (!chkTu_in.Checked)
		{
			chkDat_in.Checked = true;
		}
		((Control)txtTen_mau).Select();
		((Control)txtSo_lien).Select();
		sMau_so = lblMau_so.Text;
		GetData();
	}

	protected override bool ValidData()
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(((TextBox)txtSo_lien).Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtSo_lien, Helper.GetMess(50002).Description);
			return false;
		}
		if (Operators.CompareString(((TextBox)txtSo_hd).Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtSo_hd, Helper.GetMess(50002).Description);
			return false;
		}
		if (!EditMode && Conversions.ToDouble(((TextBox)txtSo_hd).Text) == 0.0)
		{
			CMessageBox.Show(50157);
			((Control)txtSo_hd).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtTen_mau))
		{
			epNotice.SetError((Control)(object)txtTen_mau, Helper.GetMess(50002).Description);
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
		switch (Convert.ToInt32(((TextBox)txtSo_lien).Text))
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
			if (Operators.CompareString(txtLoai_in.Text, "T", false) == 0)
			{
				RowToEdit["loaiin"] = "Tự in (T)";
			}
			else
			{
				RowToEdit["loaiin"] = "Đặt in (P)";
			}
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
			SOND51dmmhdDAO sOND51dmmhdDAO = (SOND51dmmhdDAO)DAOFactory.CreateDAOInstance("SOND51dmmhdDAO", "SOND51dmmhd");
			int num = sOND51dmmhdDAO.Delete(sMau_so);
			sOND51dmmhdDAO.Destroy();
			InsertToCTPH();
			if (Operators.CompareString(txtLoai_in.Text, "T", false) == 0)
			{
				RowToEdit["loaiin"] = "Tự in (T)";
			}
			else
			{
				RowToEdit["loaiin"] = "Đặt in (P)";
			}
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
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtTen_loai;
		CreateDataBinding(ref ojb, "ten_loai");
		txtTen_loai = (TextBox)ojb;
		ojb = (Control)(object)txtMa_loai;
		CreateDataBinding(ref ojb, "ma_loai");
		txtMa_loai = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_lien;
		CreateDataBinding(ref ojb, "so_lien");
		txtSo_lien = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSo_hd;
		CreateDataBinding(ref ojb, "so_hd");
		txtSo_hd = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)lblMau_so;
		CreateDataBinding(ref ojb, "mau_so");
		lblMau_so = (Label)ojb;
		ojb = (Control)(object)txtTen_mau;
		CreateDataBinding(ref ojb, "ten_mau");
		txtTen_mau = (TextBox)ojb;
		ojb = (Control)(object)chkTu_in;
		CreateDataBinding(ref ojb, "loai_in", "Checked");
		chkTu_in = (RadioButton)ojb;
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

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
		}
		if ((int)keyData == 13)
		{
			int rowCount = ((DataGridView)adgvLien).RowCount;
			if (rowCount > 0 && ((DataGridView)adgvLien)["mota", checked(rowCount - 1)].Selected)
			{
				((Control)cmdSave).Focus();
			}
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void chkTu_in_CheckedChanged(object sender, EventArgs e)
	{
		if (chkTu_in.Checked)
		{
			txtLoai_in.Text = "T";
		}
		else
		{
			txtLoai_in.Text = "P";
		}
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
		if ((Conversions.ToDouble(((TextBox)txtSo_lien).Text) < 2.0) | (Conversions.ToDouble(((TextBox)txtSo_lien).Text) > 9.0))
		{
			CMessageBox.Show(50164);
			((Control)txtSo_lien).Select();
			return;
		}
		int so_lien = Convert.ToInt32(((TextBox)txtSo_lien).Text);
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
			CMessageBox.Show(50157);
			((Control)txtSo_hd).Select();
		}
		((TextBox)txtSo_hd).Text = sHd;
	}

	private void txtKh_nam_Leave(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(((TextBox)txtKh_nam).Text) < 1.0)
		{
			CMessageBox.Show(50165);
			((Control)txtKh_nam).Select();
		}
	}

	protected void GetData()
	{
		SOND51dmmhdDAO sOND51dmmhdDAO = (SOND51dmmhdDAO)DAOFactory.CreateDAOInstance("SOND51dmmhdDAO", "SOND51dmmhd");
		DataTable data = sOND51dmmhdDAO.GetData(sMau_so);
		sOND51dmmhdDAO.Destroy();
		checked
		{
			if (data.Rows.Count != 0)
			{
				int num = ((DataGridView)adgvLien).RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					((DataGridView)adgvLien)["mota", i].Value = data.Rows[0][i].ToString();
				}
			}
		}
	}

	protected void InsertToCTPH()
	{
		SOND51dmmhdDAO sOND51dmmhdDAO = (SOND51dmmhdDAO)DAOFactory.CreateDAOInstance("SOND51dmmhdDAO", "SOND51dmmhd");
		string text = ((TextBox)txtSo_lien).Text;
		if (Operators.CompareString(text, Conversions.ToString(2), false) == 0)
		{
			int num = sOND51dmmhdDAO.Insert(lblMau_so.Text, Conversions.ToString(((DataGridView)adgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 1].Value));
		}
		else if (Operators.CompareString(text, Conversions.ToString(3), false) == 0)
		{
			int num = sOND51dmmhdDAO.Insert(lblMau_so.Text, Conversions.ToString(((DataGridView)adgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 2].Value));
		}
		else if (Operators.CompareString(text, Conversions.ToString(4), false) == 0)
		{
			int num = sOND51dmmhdDAO.Insert(lblMau_so.Text, Conversions.ToString(((DataGridView)adgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 2].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 3].Value));
		}
		else if (Operators.CompareString(text, Conversions.ToString(5), false) == 0)
		{
			int num = sOND51dmmhdDAO.Insert(lblMau_so.Text, Conversions.ToString(((DataGridView)adgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 2].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 3].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 4].Value));
		}
		else if (Operators.CompareString(text, Conversions.ToString(6), false) == 0)
		{
			int num = sOND51dmmhdDAO.Insert(lblMau_so.Text, Conversions.ToString(((DataGridView)adgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 2].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 3].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 4].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 5].Value));
		}
		else if (Operators.CompareString(text, Conversions.ToString(7), false) == 0)
		{
			int num = sOND51dmmhdDAO.Insert(lblMau_so.Text, Conversions.ToString(((DataGridView)adgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 2].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 3].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 4].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 5].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 6].Value));
		}
		else if (Operators.CompareString(text, Conversions.ToString(8), false) == 0)
		{
			int num = sOND51dmmhdDAO.Insert(lblMau_so.Text, Conversions.ToString(((DataGridView)adgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 2].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 3].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 4].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 5].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 6].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 7].Value));
		}
		else if (Operators.CompareString(text, Conversions.ToString(9), false) == 0)
		{
			int num = sOND51dmmhdDAO.Insert(lblMau_so.Text, Conversions.ToString(((DataGridView)adgvLien)["mota", 0].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 1].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 2].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 3].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 4].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 5].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 6].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 7].Value), Conversions.ToString(((DataGridView)adgvLien)["mota", 8].Value));
		}
		sOND51dmmhdDAO.Destroy();
	}

	protected bool CheckGrid(int lien)
	{
		string text = "Liên " + Conversions.ToString(checked(lien + 1)) + ":";
		if (Operators.CompareString(((DataGridView)adgvLien)["mota", lien].Value.ToString(), "", false) == 0)
		{
			((DataGridView)adgvLien)[((DataGridViewColumn)Mota).Name, lien].ErrorText = Helper.GetMess(50002).Description;
			return false;
		}
		if ((((DataGridView)adgvLien)["mota", lien].Value.ToString().Length < 8) | (Operators.CompareString(((DataGridView)adgvLien)["mota", lien].Value.ToString().Substring(0, 7), text, false) != 0))
		{
			((DataGridView)adgvLien)[((DataGridViewColumn)Mota).Name, lien].ErrorText = "Phải bắt đầu bằng '" + text + "'!";
			return false;
		}
		((DataGridView)adgvLien)[((DataGridViewColumn)Mota).Name, lien].ErrorText = "";
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
		lblMau_so.Text = ((TextBox)txtMa_loai).Text + ((TextBox)txtSo_lien).Text + "/" + sHd;
	}

	protected void SetKyHieu()
	{
		lblSo_seri.Text = ((TextBox)txtKh_hd).Text + "/" + ((TextBox)txtKh_nam).Text + txtLoai_in.Text;
	}

	protected void MakeTable()
	{
		DataColumn column = new DataColumn("lien");
		DataColumn column2 = new DataColumn("mota");
		oDt.Columns.Add(column);
		oDt.Columns.Add(column2);
		((DataGridView)adgvLien).DataSource = oDt;
	}

	protected void NapGrid(int so_lien)
	{
		ClearList(so_lien);
		checked
		{
			if (((DataGridView)adgvLien).RowCount == 0)
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
				int count = oDt.Rows.Count;
				int num = so_lien - 1;
				for (int j = count; j <= num; j++)
				{
					DataRow dataRow = oDt.NewRow();
					dataRow["lien"] = "Liên " + Conversions.ToString(j + 1);
					dataRow["mota"] = "";
					oDt.Rows.Add(dataRow);
				}
			}
			((DataGridView)adgvLien)["mota", 0].ReadOnly = true;
			((DataGridView)adgvLien)["mota", 1].ReadOnly = true;
		}
	}

	protected void ClearList(object so_lien)
	{
		object obj = default(object);
		object obj2 = default(object);
		if (ForLoopControl.ForLoopInitObj(obj, (object)checked(((DataGridView)adgvLien).RowCount - 1), so_lien, (object)(-1), ref obj2, ref obj))
		{
			do
			{
				((DataGridView)adgvLien).Rows.RemoveAt(Conversions.ToInteger(obj));
			}
			while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
		}
	}
}
