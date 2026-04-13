using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSOND51mchhdEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtNgay_guicqt")]
	private AsMaskedTextBox _txtNgay_guicqt;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("txtNgay_xl")]
	private AsMaskedTextBox _txtNgay_xl;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("txtPhut_xl")]
	private AsTextNumeric _txtPhut_xl;

	[AccessedThroughProperty("txtGio_xl")]
	private AsTextNumeric _txtGio_xl;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("txtGhi_chu")]
	private TextBox _txtGhi_chu;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtMa_thue")]
	private TextBox _txtMa_thue;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("txtDia_chi")]
	private TextBox _txtDia_chi;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("txtDai_dien")]
	private TextBox _txtDai_dien;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txtTen_tc")]
	private TextBox _txtTen_tc;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtNoi_nhan")]
	private TextBox _txtNoi_nhan;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtMa_tb")]
	private AsTextBox _txtMa_tb;

	[AccessedThroughProperty("txtNgay_tb")]
	private AsMaskedTextBox _txtNgay_tb;

	[AccessedThroughProperty("adgvHD")]
	private AsInputDGV _adgvHD;

	[AccessedThroughProperty("btnChon_hd")]
	private Button _btnChon_hd;

	[AccessedThroughProperty("stt_rec")]
	private DataGridViewTextBoxColumn _stt_rec;

	[AccessedThroughProperty("loai_hd")]
	private DataGridViewTextBoxColumn _loai_hd;

	[AccessedThroughProperty("Mau_so")]
	private DataGridViewTextBoxColumn _Mau_so;

	[AccessedThroughProperty("Ky_hieu")]
	private DataGridViewTextBoxColumn _Ky_hieu;

	[AccessedThroughProperty("Tu_so")]
	private DataGridViewTextBoxColumn _Tu_so;

	[AccessedThroughProperty("Den_so")]
	private DataGridViewTextBoxColumn _Den_so;

	[AccessedThroughProperty("So_luong")]
	private DataGridViewTextBoxColumn _So_luong;

	[AccessedThroughProperty("Lien_so")]
	private DataGridViewTextBoxColumn _Lien_so;

	[AccessedThroughProperty("Ghi_chu")]
	private DataGridViewTextBoxColumn _Ghi_chu;

	private DataTable oDthd;

	private int iIndex;

	internal virtual AsMaskedTextBox txtNgay_guicqt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_guicqt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_guicqt = value;
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

	internal virtual AsMaskedTextBox txtNgay_xl
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_xl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_xl = value;
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

	internal virtual AsTextNumeric txtPhut_xl
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPhut_xl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtPhut_Leave;
			if (_txtPhut_xl != null)
			{
				((Control)_txtPhut_xl).Leave -= eventHandler;
			}
			_txtPhut_xl = value;
			if (_txtPhut_xl != null)
			{
				((Control)_txtPhut_xl).Leave += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtGio_xl
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGio_xl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtGio_Leave;
			if (_txtGio_xl != null)
			{
				((Control)_txtGio_xl).Leave -= eventHandler;
			}
			_txtGio_xl = value;
			if (_txtGio_xl != null)
			{
				((Control)_txtGio_xl).Leave += eventHandler;
			}
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

	internal virtual TextBox txtMa_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_thue = value;
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

	internal virtual TextBox txtDia_chi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDia_chi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDia_chi = value;
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

	internal virtual TextBox txtDai_dien
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDai_dien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDai_dien = value;
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

	internal virtual TextBox txtTen_tc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_tc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_tc = value;
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

	internal virtual TextBox txtNoi_nhan
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNoi_nhan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNoi_nhan = value;
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

	internal virtual AsTextBox txtMa_tb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_tb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyPressEventHandler val = new KeyPressEventHandler(txtMa_tb_KeyPress);
			EventHandler eventHandler = txtMa_tb_Leave;
			if (_txtMa_tb != null)
			{
				((Control)_txtMa_tb).KeyPress -= val;
				((Control)_txtMa_tb).Leave -= eventHandler;
			}
			_txtMa_tb = value;
			if (_txtMa_tb != null)
			{
				((Control)_txtMa_tb).KeyPress += val;
				((Control)_txtMa_tb).Leave += eventHandler;
			}
		}
	}

	internal virtual AsMaskedTextBox txtNgay_tb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_tb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_tb = value;
		}
	}

	internal virtual AsInputDGV adgvHD
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvHD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvHD = value;
		}
	}

	internal virtual Button btnChon_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnChon_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnChon_hd_Click;
			if (_btnChon_hd != null)
			{
				((Control)_btnChon_hd).Click -= eventHandler;
			}
			_btnChon_hd = value;
			if (_btnChon_hd != null)
			{
				((Control)_btnChon_hd).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn stt_rec
	{
		[DebuggerNonUserCode]
		get
		{
			return _stt_rec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_stt_rec = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn loai_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _loai_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_loai_hd = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Mau_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _Mau_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Mau_so = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Ky_hieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _Ky_hieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Ky_hieu = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Tu_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _Tu_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Tu_so = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Den_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _Den_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Den_so = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn So_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _So_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_So_luong = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Lien_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _Lien_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Lien_so = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Ghi_chu
	{
		[DebuggerNonUserCode]
		get
		{
			return _Ghi_chu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Ghi_chu = value;
		}
	}

	public frmSOND51mchhdEdit()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		oDthd = new DataTable();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_143f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1449: Expected O, but got Unknown
		//IL_1535: Unknown result type (might be due to invalid IL or missing references)
		//IL_153f: Expected O, but got Unknown
		//IL_15e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ea: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		txtNgay_tb = new AsMaskedTextBox();
		txtMa_tb = new AsTextBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		txtNoi_nhan = new TextBox();
		Label4 = new Label();
		txtTen_tc = new TextBox();
		Label5 = new Label();
		txtDai_dien = new TextBox();
		Label6 = new Label();
		txtDia_chi = new TextBox();
		Label7 = new Label();
		txtMa_thue = new TextBox();
		Label8 = new Label();
		txtGhi_chu = new TextBox();
		Label9 = new Label();
		txtGio_xl = new AsTextNumeric();
		txtPhut_xl = new AsTextNumeric();
		Label10 = new Label();
		Label11 = new Label();
		txtNgay_xl = new AsMaskedTextBox();
		Label12 = new Label();
		txtNgay_guicqt = new AsMaskedTextBox();
		adgvHD = new AsInputDGV();
		stt_rec = new DataGridViewTextBoxColumn();
		loai_hd = new DataGridViewTextBoxColumn();
		Mau_so = new DataGridViewTextBoxColumn();
		Ky_hieu = new DataGridViewTextBoxColumn();
		Tu_so = new DataGridViewTextBoxColumn();
		Den_so = new DataGridViewTextBoxColumn();
		So_luong = new DataGridViewTextBoxColumn();
		Lien_so = new DataGridViewTextBoxColumn();
		Ghi_chu = new DataGridViewTextBoxColumn();
		btnChon_hd = new Button();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((ISupportInitialize)adgvHD).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(499, 212);
		((Control)asCheckBox).Location = location;
		AsCheckBox asCheckBox2 = chkKsd;
		Size size = new Size(15, 14);
		((Control)asCheckBox2).Size = size;
		((ButtonBase)chkKsd).Text = "";
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 438);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 115;
		Button obj2 = cmdSave;
		location = new Point(12, 438);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 114;
		((Control)gbLine).Controls.Add((Control)(object)btnChon_hd);
		((Control)gbLine).Controls.Add((Control)(object)adgvHD);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_guicqt);
		((Control)gbLine).Controls.Add((Control)(object)Label12);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_xl);
		((Control)gbLine).Controls.Add((Control)(object)Label11);
		((Control)gbLine).Controls.Add((Control)(object)Label10);
		((Control)gbLine).Controls.Add((Control)(object)txtPhut_xl);
		((Control)gbLine).Controls.Add((Control)(object)txtGio_xl);
		((Control)gbLine).Controls.Add((Control)(object)Label9);
		((Control)gbLine).Controls.Add((Control)(object)txtGhi_chu);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_thue);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)txtDia_chi);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)txtDai_dien);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_tc);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)txtNoi_nhan);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_tb);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_tb);
		GroupBox obj3 = gbLine;
		size = new Size(721, 426);
		((Control)obj3).Size = size;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_tb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_tb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNoi_nhan, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_tc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDai_dien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDia_chi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGhi_chu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label9, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGio_xl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtPhut_xl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label10, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label11, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_xl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label12, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_guicqt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)adgvHD, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)btnChon_hd, 0);
		txtNgay_tb.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_tb).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_tb;
		location = new Point(139, 19);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_tb).Mask = "##/##/####";
		((Control)txtNgay_tb).Name = "txtNgay_tb";
		((MaskedTextBox)txtNgay_tb).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_tb;
		size = new Size(80, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_tb).TabIndex = 100;
		((MaskedTextBox)txtNgay_tb).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_tb;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtMa_tb.AutoLookup = false;
		txtMa_tb.AutoValid = false;
		((TextBoxBase)txtMa_tb).BackColor = SystemColors.Window;
		((TextBox)txtMa_tb).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_tb;
		location = new Point(321, 19);
		((Control)asTextBox).Location = location;
		txtMa_tb.LookupCodeName = "";
		((Control)txtMa_tb).Name = "txtMa_tb";
		txtMa_tb.NameControl = null;
		AsTextBox asTextBox2 = txtMa_tb;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_tb).TabIndex = 101;
		txtMa_tb.UseAutoCompleteSource = true;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(15, 23);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(83, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 102;
		Label1.Text = "Ngày thông báo";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(242, 23);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(71, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 103;
		Label2.Text = "Số thông báo";
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(15, 48);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(101, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 104;
		Label3.Text = "Nơi nhận thông báo";
		TextBox obj4 = txtNoi_nhan;
		location = new Point(139, 44);
		((Control)obj4).Location = location;
		((Control)txtNoi_nhan).Name = "txtNoi_nhan";
		TextBox obj5 = txtNoi_nhan;
		size = new Size(562, 20);
		((Control)obj5).Size = size;
		((Control)txtNoi_nhan).TabIndex = 102;
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(15, 73);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(110, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 106;
		Label4.Text = "Tên tổ chức, cá nhân";
		TextBox obj6 = txtTen_tc;
		location = new Point(139, 69);
		((Control)obj6).Location = location;
		((Control)txtTen_tc).Name = "txtTen_tc";
		TextBox obj7 = txtTen_tc;
		size = new Size(562, 20);
		((Control)obj7).Size = size;
		((Control)txtTen_tc).TabIndex = 103;
		Label5.AutoSize = true;
		Label label9 = Label5;
		location = new Point(15, 98);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(76, 13);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 108;
		Label5.Text = "Người đại diện";
		TextBox obj8 = txtDai_dien;
		location = new Point(139, 94);
		((Control)obj8).Location = location;
		((Control)txtDai_dien).Name = "txtDai_dien";
		TextBox obj9 = txtDai_dien;
		size = new Size(562, 20);
		((Control)obj9).Size = size;
		((Control)txtDai_dien).TabIndex = 104;
		Label6.AutoSize = true;
		Label label11 = Label6;
		location = new Point(15, 123);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(40, 13);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 110;
		Label6.Text = "Địa chỉ";
		TextBox obj10 = txtDia_chi;
		location = new Point(139, 119);
		((Control)obj10).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj11 = txtDia_chi;
		size = new Size(382, 20);
		((Control)obj11).Size = size;
		((Control)txtDia_chi).TabIndex = 105;
		Label7.AutoSize = true;
		Label label13 = Label7;
		location = new Point(533, 123);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(60, 13);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 112;
		Label7.Text = "Mã số thuế";
		TextBox obj12 = txtMa_thue;
		location = new Point(601, 119);
		((Control)obj12).Location = location;
		((Control)txtMa_thue).Name = "txtMa_thue";
		TextBox obj13 = txtMa_thue;
		size = new Size(100, 20);
		((Control)obj13).Size = size;
		((Control)txtMa_thue).TabIndex = 106;
		Label8.AutoSize = true;
		Label label15 = Label8;
		location = new Point(15, 144);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(112, 13);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 114;
		Label8.Text = "Lý do mất, cháy, hỏng";
		TextBox obj14 = txtGhi_chu;
		location = new Point(139, 144);
		((Control)obj14).Location = location;
		txtGhi_chu.Multiline = true;
		((Control)txtGhi_chu).Name = "txtGhi_chu";
		txtGhi_chu.ScrollBars = (ScrollBars)2;
		TextBox obj15 = txtGhi_chu;
		size = new Size(562, 60);
		((Control)obj15).Size = size;
		((Control)txtGhi_chu).TabIndex = 107;
		Label9.AutoSize = true;
		Label label17 = Label9;
		location = new Point(15, 213);
		((Control)label17).Location = location;
		((Control)Label9).Name = "Label9";
		Label label18 = Label9;
		size = new Size(23, 13);
		((Control)label18).Size = size;
		((Control)Label9).TabIndex = 116;
		Label9.Text = "Hồi";
		txtGio_xl.DecimalSymbol = ".";
		txtGio_xl.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtGio_xl;
		location = new Point(139, 209);
		((Control)asTextNumeric).Location = location;
		txtGio_xl.Mask = "00";
		((Control)txtGio_xl).Name = "txtGio_xl";
		AsTextNumeric asTextNumeric2 = txtGio_xl;
		size = new Size(32, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtGio_xl).TabIndex = 108;
		((TextBox)txtGio_xl).Text = "0";
		((TextBox)txtGio_xl).TextAlign = (HorizontalAlignment)1;
		txtGio_xl.Value = 0;
		txtPhut_xl.DecimalSymbol = ".";
		txtPhut_xl.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtPhut_xl;
		location = new Point(196, 209);
		((Control)asTextNumeric3).Location = location;
		txtPhut_xl.Mask = "00";
		((Control)txtPhut_xl).Name = "txtPhut_xl";
		AsTextNumeric asTextNumeric4 = txtPhut_xl;
		size = new Size(32, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtPhut_xl).TabIndex = 109;
		((TextBox)txtPhut_xl).Text = "0";
		((TextBox)txtPhut_xl).TextAlign = (HorizontalAlignment)1;
		txtPhut_xl.Value = 0;
		Label10.AutoSize = true;
		Label label19 = Label10;
		location = new Point(173, 213);
		((Control)label19).Location = location;
		((Control)Label10).Name = "Label10";
		Label label20 = Label10;
		size = new Size(21, 13);
		((Control)label20).Size = size;
		((Control)Label10).TabIndex = 119;
		Label10.Text = "giờ";
		Label11.AutoSize = true;
		Label label21 = Label11;
		location = new Point(242, 213);
		((Control)label21).Location = location;
		((Control)Label11).Name = "Label11";
		Label label22 = Label11;
		size = new Size(32, 13);
		((Control)label22).Size = size;
		((Control)Label11).TabIndex = 120;
		Label11.Text = "Ngày";
		txtNgay_xl.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_xl).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_xl;
		location = new Point(280, 209);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_xl).Mask = "##/##/####";
		((Control)txtNgay_xl).Name = "txtNgay_xl";
		((MaskedTextBox)txtNgay_xl).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_xl;
		size = new Size(80, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_xl).TabIndex = 110;
		((MaskedTextBox)txtNgay_xl).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_xl;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		Label12.AutoSize = true;
		Label label23 = Label12;
		location = new Point(375, 213);
		((Control)label23).Location = location;
		((Control)Label12).Name = "Label12";
		Label label24 = Label12;
		size = new Size(106, 13);
		((Control)label24).Size = size;
		((Control)Label12).TabIndex = 122;
		Label12.Text = "Đã gửi CQ thuế ngày";
		txtNgay_guicqt.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_guicqt).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox7 = txtNgay_guicqt;
		location = new Point(515, 209);
		((Control)asMaskedTextBox7).Location = location;
		((MaskedTextBox)txtNgay_guicqt).Mask = "##/##/####";
		((Control)txtNgay_guicqt).Name = "txtNgay_guicqt";
		((MaskedTextBox)txtNgay_guicqt).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox8 = txtNgay_guicqt;
		size = new Size(80, 20);
		((Control)asMaskedTextBox8).Size = size;
		((Control)txtNgay_guicqt).TabIndex = 111;
		((MaskedTextBox)txtNgay_guicqt).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox9 = txtNgay_guicqt;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox9.Value = dateTime;
		((DataGridView)adgvHD).AllowUserToAddRows = false;
		((DataGridView)adgvHD).AllowUserToDeleteRows = false;
		((DataGridView)adgvHD).BackgroundColor = Color.White;
		((DataGridView)adgvHD).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHD).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)adgvHD).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvHD).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[9]
		{
			(DataGridViewColumn)stt_rec,
			(DataGridViewColumn)loai_hd,
			(DataGridViewColumn)Mau_so,
			(DataGridViewColumn)Ky_hieu,
			(DataGridViewColumn)Tu_so,
			(DataGridViewColumn)Den_so,
			(DataGridViewColumn)So_luong,
			(DataGridViewColumn)Lien_so,
			(DataGridViewColumn)Ghi_chu
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvHD).DefaultCellStyle = val2;
		((DataGridView)adgvHD).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = adgvHD;
		location = new Point(15, 237);
		((Control)asInputDGV).Location = location;
		((Control)adgvHD).Name = "adgvHD";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHD).RowHeadersDefaultCellStyle = val3;
		((DataGridView)adgvHD).RowHeadersVisible = false;
		((DataGridView)adgvHD).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = adgvHD;
		size = new Size(686, 176);
		((Control)asInputDGV2).Size = size;
		((Control)adgvHD).TabIndex = 113;
		((DataGridViewColumn)stt_rec).DataPropertyName = "stt_rec";
		((DataGridViewColumn)stt_rec).HeaderText = "SCT";
		((DataGridViewColumn)stt_rec).Name = "stt_rec";
		((DataGridViewColumn)stt_rec).Visible = false;
		((DataGridViewColumn)loai_hd).DataPropertyName = "loai_hd";
		((DataGridViewColumn)loai_hd).HeaderText = "Tên Loa\u0323i Hoa\u0301 Đơn";
		((DataGridViewColumn)loai_hd).Name = "loai_hd";
		((DataGridViewColumn)loai_hd).ReadOnly = true;
		((DataGridViewColumn)loai_hd).Width = 200;
		((DataGridViewColumn)Mau_so).DataPropertyName = "mau_so";
		((DataGridViewColumn)Mau_so).HeaderText = "Mâ\u0303u Sô\u0301";
		((DataGridViewColumn)Mau_so).Name = "Mau_so";
		((DataGridViewColumn)Mau_so).ReadOnly = true;
		((DataGridViewColumn)Mau_so).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)Mau_so).Width = 70;
		((DataGridViewColumn)Ky_hieu).DataPropertyName = "so_seri";
		((DataGridViewColumn)Ky_hieu).HeaderText = "Ky\u0301 Hiê\u0323u";
		((DataGridViewColumn)Ky_hieu).Name = "Ky_hieu";
		((DataGridViewColumn)Ky_hieu).ReadOnly = true;
		((DataGridViewColumn)Ky_hieu).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)Ky_hieu).Width = 70;
		((DataGridViewColumn)Tu_so).DataPropertyName = "tu_so";
		((DataGridViewColumn)Tu_so).HeaderText = "Tư\u0300 Sô\u0301";
		((DataGridViewColumn)Tu_so).Name = "Tu_so";
		((DataGridViewColumn)Tu_so).ReadOnly = true;
		((DataGridViewColumn)Tu_so).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)Tu_so).Width = 70;
		((DataGridViewColumn)Den_so).DataPropertyName = "den_so";
		((DataGridViewColumn)Den_so).HeaderText = "Đê\u0301n Sô\u0301";
		((DataGridViewColumn)Den_so).Name = "Den_so";
		((DataGridViewColumn)Den_so).ReadOnly = true;
		((DataGridViewColumn)Den_so).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)Den_so).Width = 70;
		((DataGridViewColumn)So_luong).DataPropertyName = "so_luong";
		val4.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)So_luong).DefaultCellStyle = val4;
		((DataGridViewColumn)So_luong).HeaderText = "Sô\u0301 Lươ\u0323ng";
		((DataGridViewColumn)So_luong).Name = "So_luong";
		((DataGridViewColumn)So_luong).ReadOnly = true;
		((DataGridViewColumn)So_luong).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)So_luong).Width = 80;
		((DataGridViewColumn)Lien_so).DataPropertyName = "lien_so";
		val5.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)Lien_so).DefaultCellStyle = val5;
		((DataGridViewColumn)Lien_so).HeaderText = "Liên Sô\u0301";
		((DataGridViewColumn)Lien_so).Name = "Lien_so";
		((DataGridViewColumn)Lien_so).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)Lien_so).Width = 70;
		((DataGridViewColumn)Ghi_chu).DataPropertyName = "ghi_chu";
		((DataGridViewColumn)Ghi_chu).HeaderText = "Ghi Chu\u0301";
		((DataGridViewColumn)Ghi_chu).Name = "Ghi_chu";
		Button obj16 = btnChon_hd;
		location = new Point(626, 208);
		((Control)obj16).Location = location;
		((Control)btnChon_hd).Name = "btnChon_hd";
		Button obj17 = btnChon_hd;
		size = new Size(75, 23);
		((Control)obj17).Size = size;
		((Control)btnChon_hd).TabIndex = 112;
		((ButtonBase)btnChon_hd).Text = "&Chọn HĐ";
		((ButtonBase)btnChon_hd).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(745, 473);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSOND51mchhdEdit";
		((Form)this).Text = "frmSOMCHHDEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((ISupportInitialize)adgvHD).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_tb).MaxLength = MyDictInfo.code_length;
		((Control)txtNgay_tb).Select();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		GetData();
		if (!EditMode)
		{
			txtNgay_tb.Value = DateTime.Now;
			txtNgay_xl.Value = DateTime.Now;
			txtGio_xl.Value = DateTime.Now.Hour.ToString();
			txtPhut_xl.Value = DateTime.Now.Minute;
			txtTen_tc.Text = CompanyInformations.CompanyName;
			txtDia_chi.Text = CompanyInformations.CompanyAddress;
			((Control)txtNgay_guicqt).Enabled = false;
			((Control)chkKsd).Enabled = false;
			txtMa_tb_Format();
		}
		else if (Conversions.ToBoolean(chkKsd.Checked))
		{
			((Control)txtNgay_guicqt).Enabled = false;
			((Control)chkKsd).Enabled = false;
		}
		else
		{
			((Control)txtNgay_guicqt).Enabled = true;
			((Control)chkKsd).Enabled = true;
		}
	}

	protected override bool ValidData()
	{
		if (Operators.CompareString(((MaskedTextBox)txtNgay_tb).Text.ToString().Replace("/", "").Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtNgay_tb, Helper.GetMess(50002).Description);
			((Control)txtNgay_tb).Select();
			return false;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_tb))
		{
			epNotice.SetError((Control)(object)txtMa_tb, Helper.GetMess(50002).Description);
			((Control)txtMa_tb).Select();
			return false;
		}
		if (Conversions.ToDouble(((TextBox)txtMa_tb).Text) < 1.0)
		{
			epNotice.SetError((Control)(object)txtMa_tb, Helper.GetMess(50154).Description);
			((Control)txtMa_tb).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtNoi_nhan))
		{
			epNotice.SetError((Control)(object)txtNoi_nhan, Helper.GetMess(50002).Description);
			((Control)txtNoi_nhan).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtTen_tc))
		{
			epNotice.SetError((Control)(object)txtTen_tc, Helper.GetMess(50002).Description);
			((Control)txtTen_tc).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtDai_dien))
		{
			epNotice.SetError((Control)(object)txtDai_dien, Helper.GetMess(50002).Description);
			((Control)txtDai_dien).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtDia_chi))
		{
			epNotice.SetError((Control)(object)txtDia_chi, Helper.GetMess(50002).Description);
			((Control)txtDia_chi).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtMa_thue))
		{
			epNotice.SetError((Control)(object)txtMa_thue, Helper.GetMess(50002).Description);
			((Control)txtMa_thue).Select();
			return false;
		}
		if (Operators.CompareString(((MaskedTextBox)txtNgay_tb).Text, ((MaskedTextBox)txtNgay_xl).Text, false) < 0)
		{
			epNotice.SetError((Control)(object)txtNgay_xl, Helper.GetMess(50098).Description);
			((Control)txtNgay_xl).Select();
			return false;
		}
		if (Conversions.ToBoolean((!Conversions.ToBoolean((object)EditMode) || !Conversions.ToBoolean(chkKsd.Checked)) ? ((object)false) : ((object)true)))
		{
			if (Operators.CompareString(((MaskedTextBox)txtNgay_guicqt).Text.ToString().Replace("/", "").Trim(), "", false) == 0)
			{
				epNotice.SetError((Control)(object)txtNgay_guicqt, Helper.GetMess(50002).Description);
				((Control)txtNgay_guicqt).Select();
				return false;
			}
			if (Operators.CompareString(((MaskedTextBox)txtNgay_tb).Text, ((MaskedTextBox)txtNgay_guicqt).Text, false) > 0)
			{
				epNotice.SetError((Control)(object)txtNgay_guicqt, Helper.GetMess(50098).Description);
				((Control)txtNgay_guicqt).Select();
				return false;
			}
		}
		checked
		{
			int num = ((DataGridView)adgvHD).RowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Operators.CompareString(((DataGridView)adgvHD)[((DataGridViewColumn)Lien_so).Name, num2].Value.ToString(), "", false) == 0)
				{
					((DataGridView)adgvHD)[((DataGridViewColumn)Lien_so).Name, num2].ErrorText = Helper.GetMess(50002).Description;
					((DataGridView)adgvHD)[((DataGridViewColumn)Lien_so).Name, num2].Selected = true;
					return false;
				}
				num2++;
			}
			return base.ValidData();
		}
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_tb).Enabled = false;
	}

	protected override bool InsertToDB()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (((DataGridView)adgvHD).RowCount == 0)
		{
			CMessageBox.Show(50155);
			return false;
		}
		bool flag = base.InsertToDB();
		if (flag)
		{
			InsertToCTHD();
		}
		else
		{
			((Control)txtMa_tb).Select();
		}
		return flag;
	}

	protected override bool UpdateDB()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (((DataGridView)adgvHD).RowCount == 0)
		{
			CMessageBox.Show(50155);
			return false;
		}
		bool result = base.UpdateDB();
		if (Conversions.ToBoolean(Operators.NotObject(chkKsd.Checked)))
		{
			SOND51mchhdDAO sOND51mchhdDAO = (SOND51mchhdDAO)DAOFactory.CreateDAOInstance("SOMCHHDDAO", "SOMCHHD");
			int num = sOND51mchhdDAO.Delete(((TextBox)txtMa_tb).Text);
			sOND51mchhdDAO.Destroy();
			InsertToCTHD();
		}
		return result;
	}

	protected override void DataBinding()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtNgay_tb;
		CreateDataBinding(ref ojb, "ngay_tb", "Value");
		txtNgay_tb = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_tb;
		CreateDataBinding(ref ojb, "ma_tb");
		txtMa_tb = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtNoi_nhan;
		CreateDataBinding(ref ojb, "noi_nhan");
		txtNoi_nhan = (TextBox)ojb;
		ojb = (Control)(object)txtTen_tc;
		CreateDataBinding(ref ojb, "ten_tc");
		txtTen_tc = (TextBox)ojb;
		ojb = (Control)(object)txtDai_dien;
		CreateDataBinding(ref ojb, "dai_dien");
		txtDai_dien = (TextBox)ojb;
		ojb = (Control)(object)txtDia_chi;
		CreateDataBinding(ref ojb, "dia_chi");
		txtDia_chi = (TextBox)ojb;
		ojb = (Control)(object)txtMa_thue;
		CreateDataBinding(ref ojb, "ma_thue");
		txtMa_thue = (TextBox)ojb;
		ojb = (Control)(object)txtGhi_chu;
		CreateDataBinding(ref ojb, "ghi_chu");
		txtGhi_chu = (TextBox)ojb;
		ojb = (Control)(object)txtGio_xl;
		CreateDataBinding(ref ojb, "gio_xl");
		txtGio_xl = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtPhut_xl;
		CreateDataBinding(ref ojb, "phut_xl");
		txtPhut_xl = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtNgay_xl;
		CreateDataBinding(ref ojb, "ngay_xl", "Value");
		txtNgay_xl = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "gui_cqt", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)txtNgay_guicqt;
		CreateDataBinding(ref ojb, "ngay_guicqt", "Value");
		txtNgay_guicqt = (AsMaskedTextBox)(object)ojb;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 119)
		{
			DeleteRow();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void txtMa_tb_Leave(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(((TextBox)txtMa_tb).Text) < 1.0)
		{
			CMessageBox.Show(50153);
			((Control)txtMa_tb).Select();
		}
		txtMa_tb_Format();
	}

	private void txtMa_tb_KeyPress(object sender, KeyPressEventArgs e)
	{
		int KeyAscii = Strings.Asc(e.KeyChar);
		e.Handled = DigitsFilter(ref KeyAscii);
	}

	private void btnChon_hd_Click(object sender, EventArgs e)
	{
		frmChonHD frmChonHD2 = new frmChonHD();
		frmChonHD2.f_oDthd = oDthd;
		frmChonHD2.Show();
	}

	private void txtGio_Leave(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if ((Conversions.ToDouble(((TextBox)txtGio_xl).Text) < 0.0) | (Conversions.ToDouble(((TextBox)txtGio_xl).Text) > 23.0))
		{
			CMessageBox.Show(50156);
			((Control)txtGio_xl).Select();
		}
	}

	private void txtPhut_Leave(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if ((Conversions.ToDouble(((TextBox)txtPhut_xl).Text) < 0.0) | (Conversions.ToDouble(((TextBox)txtPhut_xl).Text) > 59.0))
		{
			CMessageBox.Show(50156);
			((Control)txtPhut_xl).Select();
		}
	}

	protected void GetData()
	{
		SOND51mchhdDAO sOND51mchhdDAO = (SOND51mchhdDAO)DAOFactory.CreateDAOInstance("SOMCHHDDAO", "SOMCHHD");
		oDthd = sOND51mchhdDAO.GetData(((TextBox)txtMa_tb).Text);
		((DataGridView)adgvHD).DataSource = oDthd;
		sOND51mchhdDAO.Destroy();
	}

	protected void DeleteRow()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		if ((int)CMessageBox.Show(Helper.GetMessContent(50003), SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256) != 7)
		{
			((DataGridView)adgvHD).Rows.RemoveAt(iIndex);
		}
	}

	protected void InsertToCTHD()
	{
		int rowCount = ((DataGridView)adgvHD).RowCount;
		SOND51mchhdDAO sOND51mchhdDAO = (SOND51mchhdDAO)DAOFactory.CreateDAOInstance("SOMCHHDDAO", "SOMCHHD");
		checked
		{
			int num = rowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				int num5 = sOND51mchhdDAO.Insert(((TextBox)txtMa_tb).Text, Conversions.ToString(((DataGridView)adgvHD)[0, num2].Value), Conversions.ToString(((DataGridView)adgvHD)[1, num2].Value), Conversions.ToString(((DataGridView)adgvHD)[2, num2].Value), Conversions.ToString(((DataGridView)adgvHD)[3, num2].Value), Conversions.ToString(((DataGridView)adgvHD)[4, num2].Value), Conversions.ToString(((DataGridView)adgvHD)[5, num2].Value), Conversions.ToString(((DataGridView)adgvHD)[6, num2].Value), Conversions.ToString(((DataGridView)adgvHD)[7, num2].Value), Conversions.ToString(((DataGridView)adgvHD)[8, num2].Value));
				num2++;
			}
			sOND51mchhdDAO.Destroy();
		}
	}

	protected void txtMa_tb_Format()
	{
		int length = ((TextBox)txtMa_tb).Text.Length;
		if (Operators.CompareString(((TextBox)txtMa_tb).Text, "", false) == 0)
		{
			((TextBox)txtMa_tb).Text = "00000000";
			return;
		}
		checked
		{
			int num = MyDictInfo.code_length - length;
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					((TextBox)txtMa_tb).Text = "0" + ((TextBox)txtMa_tb).Text;
					num2++;
					continue;
				}
				break;
			}
		}
	}

	protected bool DigitsFilter(ref int KeyAscii)
	{
		if (KeyAscii >= 32 && Strings.InStr("0987654321", Conversions.ToString(Strings.Chr(KeyAscii)), (CompareMethod)0) <= 0)
		{
			return true;
		}
		bool result = default(bool);
		return result;
	}
}
