using System;
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
public class frmSOND51bkhdEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("adgvHDHetHan")]
	private AsInputDGV _adgvHDHetHan;

	[AccessedThroughProperty("txtNgay_tb")]
	private AsMaskedTextBox _txtNgay_tb;

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

	[AccessedThroughProperty("txtDai_dien")]
	private TextBox _txtDai_dien;

	[AccessedThroughProperty("txtTen_cty")]
	private TextBox _txtTen_cty;

	[AccessedThroughProperty("txtMa_thue")]
	private TextBox _txtMa_thue;

	[AccessedThroughProperty("txtMa_tb")]
	private AsTextBox _txtMa_tb;

	[AccessedThroughProperty("btnChonHD2")]
	private Button _btnChonHD2;

	[AccessedThroughProperty("btnChonHD1")]
	private Button _btnChonHD1;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("adgvHDGiaHan")]
	private AsInputDGV _adgvHDGiaHan;

	[AccessedThroughProperty("btnXoaHD2")]
	private Button _btnXoaHD2;

	[AccessedThroughProperty("btnXoaHD1")]
	private Button _btnXoaHD1;

	[AccessedThroughProperty("dgvcMa_ph2")]
	private DataGridViewTextBoxColumn _dgvcMa_ph2;

	[AccessedThroughProperty("dgvcLoai2")]
	private DataGridViewCheckBoxColumn _dgvcLoai2;

	[AccessedThroughProperty("dgvcTen_loai2")]
	private DataGridViewTextBoxColumn _dgvcTen_loai2;

	[AccessedThroughProperty("dgvcMau_so2")]
	private DataGridViewTextBoxColumn _dgvcMau_so2;

	[AccessedThroughProperty("dgvcSo_seri2")]
	private DataGridViewTextBoxColumn _dgvcSo_seri2;

	[AccessedThroughProperty("dgvcTu_so2")]
	private DataGridViewTextBoxColumn _dgvcTu_so2;

	[AccessedThroughProperty("dgvcDen_so2")]
	private DataGridViewTextBoxColumn _dgvcDen_so2;

	[AccessedThroughProperty("dgvcSo_luong2")]
	private DataGridViewTextBoxColumn _dgvcSo_luong2;

	[AccessedThroughProperty("dgvcSo_hdin2")]
	private DataGridViewTextBoxColumn _dgvcSo_hdin2;

	[AccessedThroughProperty("dgvcSo_hdph2")]
	private DataGridViewTextBoxColumn _dgvcSo_hdph2;

	[AccessedThroughProperty("dgvcMa_ph1")]
	private DataGridViewTextBoxColumn _dgvcMa_ph1;

	[AccessedThroughProperty("dgvcLoai1")]
	private DataGridViewCheckBoxColumn _dgvcLoai1;

	[AccessedThroughProperty("dgvcTen_loai1")]
	private DataGridViewTextBoxColumn _dgvcTen_loai1;

	[AccessedThroughProperty("dgvcMau_so1")]
	private DataGridViewTextBoxColumn _dgvcMau_so1;

	[AccessedThroughProperty("dgvcSo_seri1")]
	private DataGridViewTextBoxColumn _dgvcSo_seri1;

	[AccessedThroughProperty("dgvcTu_so1")]
	private DataGridViewTextBoxColumn _dgvcTu_so1;

	[AccessedThroughProperty("dgvcDen_so1")]
	private DataGridViewTextBoxColumn _dgvcDen_so1;

	[AccessedThroughProperty("dgvcSo_luong1")]
	private DataGridViewTextBoxColumn _dgvcSo_luong1;

	[AccessedThroughProperty("dgvcSo_hdin1")]
	private DataGridViewTextBoxColumn _dgvcSo_hdin1;

	[AccessedThroughProperty("dgvcSo_hdph1")]
	private DataGridViewTextBoxColumn _dgvcSo_hdph1;

	private DataTable f_oDtHetHan;

	private DataTable f_oDtGiaHan;

	internal virtual AsInputDGV adgvHDHetHan
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvHDHetHan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvHDHetHan_CellEnter);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvHD1_CellLeave);
			if (_adgvHDHetHan != null)
			{
				((DataGridView)_adgvHDHetHan).CellEnter -= val;
				((DataGridView)_adgvHDHetHan).CellEndEdit -= val2;
			}
			_adgvHDHetHan = value;
			if (_adgvHDHetHan != null)
			{
				((DataGridView)_adgvHDHetHan).CellEnter += val;
				((DataGridView)_adgvHDHetHan).CellEndEdit += val2;
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

	internal virtual TextBox txtTen_cty
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_cty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_cty = value;
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

	internal virtual Button btnChonHD2
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnChonHD2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnChonHD2_Click;
			if (_btnChonHD2 != null)
			{
				((Control)_btnChonHD2).Click -= eventHandler;
			}
			_btnChonHD2 = value;
			if (_btnChonHD2 != null)
			{
				((Control)_btnChonHD2).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnChonHD1
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnChonHD1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnChonHD1_Click;
			if (_btnChonHD1 != null)
			{
				((Control)_btnChonHD1).Click -= eventHandler;
			}
			_btnChonHD1 = value;
			if (_btnChonHD1 != null)
			{
				((Control)_btnChonHD1).Click += eventHandler;
			}
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

	internal virtual AsInputDGV adgvHDGiaHan
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvHDGiaHan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvHDGiaHan_CellEnter);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvHD2_CellLeave);
			if (_adgvHDGiaHan != null)
			{
				((DataGridView)_adgvHDGiaHan).CellEnter -= val;
				((DataGridView)_adgvHDGiaHan).CellEndEdit -= val2;
			}
			_adgvHDGiaHan = value;
			if (_adgvHDGiaHan != null)
			{
				((DataGridView)_adgvHDGiaHan).CellEnter += val;
				((DataGridView)_adgvHDGiaHan).CellEndEdit += val2;
			}
		}
	}

	internal virtual Button btnXoaHD2
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnXoaHD2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnXoaHD2_Click;
			if (_btnXoaHD2 != null)
			{
				((Control)_btnXoaHD2).Click -= eventHandler;
			}
			_btnXoaHD2 = value;
			if (_btnXoaHD2 != null)
			{
				((Control)_btnXoaHD2).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnXoaHD1
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnXoaHD1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnXoaHD1_Click;
			if (_btnXoaHD1 != null)
			{
				((Control)_btnXoaHD1).Click -= eventHandler;
			}
			_btnXoaHD1 = value;
			if (_btnXoaHD1 != null)
			{
				((Control)_btnXoaHD1).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_ph2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_ph2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_ph2 = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcLoai2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcLoai2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcLoai2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_loai2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_loai2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_loai2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMau_so2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMau_so2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMau_so2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_seri2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_seri2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_seri2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTu_so2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTu_so2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTu_so2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDen_so2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDen_so2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDen_so2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_luong2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_luong2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_luong2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_hdin2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_hdin2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_hdin2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_hdph2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_hdph2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_hdph2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_ph1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_ph1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_ph1 = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcLoai1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcLoai1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcLoai1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_loai1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_loai1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_loai1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMau_so1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMau_so1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMau_so1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_seri1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_seri1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_seri1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTu_so1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTu_so1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTu_so1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDen_so1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDen_so1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDen_so1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_luong1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_luong1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_luong1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_hdin1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_hdin1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_hdin1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_hdph1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_hdph1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_hdph1 = value;
		}
	}

	public frmSOND51bkhdEdit()
	{
		f_oDtHetHan = new DataTable();
		f_oDtGiaHan = new DataTable();
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
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected O, but got Unknown
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Expected O, but got Unknown
		//IL_0d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d59: Expected O, but got Unknown
		//IL_0e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e44: Expected O, but got Unknown
		//IL_0ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ede: Expected O, but got Unknown
		//IL_0f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f81: Expected O, but got Unknown
		//IL_1000: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		adgvHDHetHan = new AsInputDGV();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		txtNgay_tb = new AsMaskedTextBox();
		txtMa_tb = new AsTextBox();
		txtMa_thue = new TextBox();
		txtTen_cty = new TextBox();
		txtDai_dien = new TextBox();
		adgvHDGiaHan = new AsInputDGV();
		Label6 = new Label();
		Label7 = new Label();
		btnChonHD1 = new Button();
		btnChonHD2 = new Button();
		btnXoaHD2 = new Button();
		btnXoaHD1 = new Button();
		dgvcMa_ph1 = new DataGridViewTextBoxColumn();
		dgvcLoai1 = new DataGridViewCheckBoxColumn();
		dgvcTen_loai1 = new DataGridViewTextBoxColumn();
		dgvcMau_so1 = new DataGridViewTextBoxColumn();
		dgvcSo_seri1 = new DataGridViewTextBoxColumn();
		dgvcTu_so1 = new DataGridViewTextBoxColumn();
		dgvcDen_so1 = new DataGridViewTextBoxColumn();
		dgvcSo_luong1 = new DataGridViewTextBoxColumn();
		dgvcSo_hdin1 = new DataGridViewTextBoxColumn();
		dgvcSo_hdph1 = new DataGridViewTextBoxColumn();
		dgvcMa_ph2 = new DataGridViewTextBoxColumn();
		dgvcLoai2 = new DataGridViewCheckBoxColumn();
		dgvcTen_loai2 = new DataGridViewTextBoxColumn();
		dgvcMau_so2 = new DataGridViewTextBoxColumn();
		dgvcSo_seri2 = new DataGridViewTextBoxColumn();
		dgvcTu_so2 = new DataGridViewTextBoxColumn();
		dgvcDen_so2 = new DataGridViewTextBoxColumn();
		dgvcSo_luong2 = new DataGridViewTextBoxColumn();
		dgvcSo_hdin2 = new DataGridViewTextBoxColumn();
		dgvcSo_hdph2 = new DataGridViewTextBoxColumn();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((ISupportInitialize)adgvHDHetHan).BeginInit();
		((ISupportInitialize)adgvHDGiaHan).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(355, 97);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 432);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 432);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)btnChonHD2);
		((Control)gbLine).Controls.Add((Control)(object)btnChonHD1);
		((Control)gbLine).Controls.Add((Control)(object)btnXoaHD2);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)btnXoaHD1);
		((Control)gbLine).Controls.Add((Control)(object)adgvHDGiaHan);
		((Control)gbLine).Controls.Add((Control)(object)txtDai_dien);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_cty);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_thue);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_tb);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_tb);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)adgvHDHetHan);
		GroupBox obj3 = gbLine;
		Size size = new Size(703, 420);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)adgvHDHetHan, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_tb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_tb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_cty, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDai_dien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)adgvHDGiaHan, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)btnXoaHD1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)btnXoaHD2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)btnChonHD1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)btnChonHD2, 0);
		((DataGridView)adgvHDHetHan).AllowUserToAddRows = false;
		((DataGridView)adgvHDHetHan).AllowUserToDeleteRows = false;
		((DataGridView)adgvHDHetHan).AllowUserToResizeRows = false;
		((DataGridView)adgvHDHetHan).BackgroundColor = Color.White;
		((DataGridView)adgvHDHetHan).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHDHetHan).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)adgvHDHetHan).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvHDHetHan).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[10]
		{
			(DataGridViewColumn)dgvcMa_ph1,
			(DataGridViewColumn)dgvcLoai1,
			(DataGridViewColumn)dgvcTen_loai1,
			(DataGridViewColumn)dgvcMau_so1,
			(DataGridViewColumn)dgvcSo_seri1,
			(DataGridViewColumn)dgvcTu_so1,
			(DataGridViewColumn)dgvcDen_so1,
			(DataGridViewColumn)dgvcSo_luong1,
			(DataGridViewColumn)dgvcSo_hdin1,
			(DataGridViewColumn)dgvcSo_hdph1
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvHDHetHan).DefaultCellStyle = val2;
		((DataGridView)adgvHDHetHan).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = adgvHDHetHan;
		location = new Point(21, 121);
		((Control)asInputDGV).Location = location;
		((Control)adgvHDHetHan).Name = "adgvHDHetHan";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHDHetHan).RowHeadersDefaultCellStyle = val3;
		((DataGridView)adgvHDHetHan).RowHeadersVisible = false;
		((DataGridView)adgvHDHetHan).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = adgvHDHetHan;
		size = new Size(663, 125);
		((Control)asInputDGV2).Size = size;
		((Control)adgvHDHetHan).TabIndex = 7;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(247, 20);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(83, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 14;
		Label1.Text = "Ngày thông báo";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(18, 20);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(71, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 11;
		Label2.Text = "Số thông báo";
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(477, 20);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(60, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 15;
		Label3.Text = "Mã số thuế";
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(18, 45);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(64, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 12;
		Label4.Text = "Tên công ty";
		Label5.AutoSize = true;
		Label label9 = Label5;
		location = new Point(18, 70);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(46, 13);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 13;
		Label5.Text = "Đại diện";
		txtNgay_tb.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_tb).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_tb;
		location = new Point(342, 16);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_tb).Mask = "##/##/####";
		((Control)txtNgay_tb).Name = "txtNgay_tb";
		((MaskedTextBox)txtNgay_tb).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_tb;
		size = new Size(100, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_tb).TabIndex = 1;
		((MaskedTextBox)txtNgay_tb).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_tb;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtMa_tb.AutoLookup = false;
		txtMa_tb.AutoValid = false;
		((TextBoxBase)txtMa_tb).BackColor = SystemColors.Window;
		((TextBox)txtMa_tb).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_tb;
		location = new Point(113, 16);
		((Control)asTextBox).Location = location;
		txtMa_tb.LookupCodeName = "";
		((Control)txtMa_tb).Name = "txtMa_tb";
		txtMa_tb.NameControl = null;
		AsTextBox asTextBox2 = txtMa_tb;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_tb).TabIndex = 0;
		txtMa_tb.UseAutoCompleteSource = true;
		TextBox obj4 = txtMa_thue;
		location = new Point(543, 16);
		((Control)obj4).Location = location;
		((Control)txtMa_thue).Name = "txtMa_thue";
		TextBox obj5 = txtMa_thue;
		size = new Size(141, 20);
		((Control)obj5).Size = size;
		((Control)txtMa_thue).TabIndex = 2;
		TextBox obj6 = txtTen_cty;
		location = new Point(113, 41);
		((Control)obj6).Location = location;
		((Control)txtTen_cty).Name = "txtTen_cty";
		TextBox obj7 = txtTen_cty;
		size = new Size(571, 20);
		((Control)obj7).Size = size;
		((Control)txtTen_cty).TabIndex = 3;
		TextBox obj8 = txtDai_dien;
		location = new Point(113, 66);
		((Control)obj8).Location = location;
		((Control)txtDai_dien).Name = "txtDai_dien";
		TextBox obj9 = txtDai_dien;
		size = new Size(571, 20);
		((Control)obj9).Size = size;
		((Control)txtDai_dien).TabIndex = 4;
		((DataGridView)adgvHDGiaHan).AllowUserToAddRows = false;
		((DataGridView)adgvHDGiaHan).AllowUserToDeleteRows = false;
		((DataGridView)adgvHDGiaHan).AllowUserToResizeRows = false;
		((DataGridView)adgvHDGiaHan).BackgroundColor = Color.White;
		((DataGridView)adgvHDGiaHan).BorderStyle = (BorderStyle)2;
		val4.Alignment = (DataGridViewContentAlignment)32;
		val4.BackColor = SystemColors.Control;
		val4.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val4.ForeColor = SystemColors.WindowText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHDGiaHan).ColumnHeadersDefaultCellStyle = val4;
		((DataGridView)adgvHDGiaHan).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvHDGiaHan).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[10]
		{
			(DataGridViewColumn)dgvcMa_ph2,
			(DataGridViewColumn)dgvcLoai2,
			(DataGridViewColumn)dgvcTen_loai2,
			(DataGridViewColumn)dgvcMau_so2,
			(DataGridViewColumn)dgvcSo_seri2,
			(DataGridViewColumn)dgvcTu_so2,
			(DataGridViewColumn)dgvcDen_so2,
			(DataGridViewColumn)dgvcSo_luong2,
			(DataGridViewColumn)dgvcSo_hdin2,
			(DataGridViewColumn)dgvcSo_hdph2
		});
		val5.Alignment = (DataGridViewContentAlignment)16;
		val5.BackColor = SystemColors.Window;
		val5.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val5.ForeColor = SystemColors.ControlText;
		val5.SelectionBackColor = SystemColors.Highlight;
		val5.SelectionForeColor = SystemColors.HighlightText;
		val5.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvHDGiaHan).DefaultCellStyle = val5;
		((DataGridView)adgvHDGiaHan).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV3 = adgvHDGiaHan;
		location = new Point(21, 283);
		((Control)asInputDGV3).Location = location;
		((Control)adgvHDGiaHan).Name = "adgvHDGiaHan";
		val6.Alignment = (DataGridViewContentAlignment)32;
		val6.BackColor = SystemColors.Control;
		val6.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val6.ForeColor = SystemColors.WindowText;
		val6.SelectionBackColor = SystemColors.Highlight;
		val6.SelectionForeColor = SystemColors.HighlightText;
		val6.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHDGiaHan).RowHeadersDefaultCellStyle = val6;
		((DataGridView)adgvHDGiaHan).RowHeadersVisible = false;
		((DataGridView)adgvHDGiaHan).RowTemplate.Height = 20;
		AsInputDGV asInputDGV4 = adgvHDGiaHan;
		size = new Size(663, 125);
		((Control)asInputDGV4).Size = size;
		((Control)adgvHDGiaHan).TabIndex = 10;
		Label6.AutoSize = true;
		((Control)Label6).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label11 = Label6;
		location = new Point(18, 98);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(163, 13);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 16;
		Label6.Text = "Hoá đơn hết giá trị sử dụng";
		Label7.AutoSize = true;
		((Control)Label7).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label13 = Label7;
		location = new Point(18, 260);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(202, 13);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 17;
		Label7.Text = "Hoá đơn đăng ký tiếp tục sử dụng";
		Button obj10 = btnChonHD1;
		location = new Point(527, 93);
		((Control)obj10).Location = location;
		((Control)btnChonHD1).Name = "btnChonHD1";
		Button obj11 = btnChonHD1;
		size = new Size(75, 23);
		((Control)obj11).Size = size;
		((Control)btnChonHD1).TabIndex = 5;
		((ButtonBase)btnChonHD1).Text = "&1.Chon HĐ";
		((ButtonBase)btnChonHD1).UseVisualStyleBackColor = true;
		Button obj12 = btnChonHD2;
		location = new Point(527, 255);
		((Control)obj12).Location = location;
		((Control)btnChonHD2).Name = "btnChonHD2";
		Button obj13 = btnChonHD2;
		size = new Size(75, 23);
		((Control)obj13).Size = size;
		((Control)btnChonHD2).TabIndex = 8;
		((ButtonBase)btnChonHD2).Text = "&3.Chon HĐ";
		((ButtonBase)btnChonHD2).UseVisualStyleBackColor = true;
		Button obj14 = btnXoaHD2;
		location = new Point(609, 255);
		((Control)obj14).Location = location;
		((Control)btnXoaHD2).Name = "btnXoaHD2";
		Button obj15 = btnXoaHD2;
		size = new Size(75, 23);
		((Control)obj15).Size = size;
		((Control)btnXoaHD2).TabIndex = 9;
		((ButtonBase)btnXoaHD2).Text = "&4.Chon HĐ";
		((ButtonBase)btnXoaHD2).UseVisualStyleBackColor = true;
		Button obj16 = btnXoaHD1;
		location = new Point(609, 93);
		((Control)obj16).Location = location;
		((Control)btnXoaHD1).Name = "btnXoaHD1";
		Button obj17 = btnXoaHD1;
		size = new Size(75, 23);
		((Control)obj17).Size = size;
		((Control)btnXoaHD1).TabIndex = 6;
		((ButtonBase)btnXoaHD1).Text = "&2.Xoá HĐ";
		((ButtonBase)btnXoaHD1).UseVisualStyleBackColor = true;
		((DataGridViewColumn)dgvcMa_ph1).DataPropertyName = "ma_ph";
		((DataGridViewColumn)dgvcMa_ph1).HeaderText = "Mã PH";
		((DataGridViewColumn)dgvcMa_ph1).Name = "dgvcMa_ph1";
		((DataGridViewColumn)dgvcMa_ph1).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_ph1).Visible = false;
		((DataGridViewColumn)dgvcLoai1).DataPropertyName = "loai";
		((DataGridViewColumn)dgvcLoai1).HeaderText = "Loại bảng kê";
		((DataGridViewColumn)dgvcLoai1).Name = "dgvcLoai1";
		((DataGridViewColumn)dgvcLoai1).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcLoai1).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcLoai1).Visible = false;
		((DataGridViewColumn)dgvcTen_loai1).DataPropertyName = "ten_loai";
		((DataGridViewColumn)dgvcTen_loai1).HeaderText = "Tên Loa\u0323i Hoa\u0301 Đơn";
		((DataGridViewColumn)dgvcTen_loai1).Name = "dgvcTen_loai1";
		((DataGridViewColumn)dgvcTen_loai1).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_loai1).Width = 290;
		((DataGridViewColumn)dgvcMau_so1).DataPropertyName = "mau_so";
		((DataGridViewColumn)dgvcMau_so1).HeaderText = "Mâ\u0303u Sô\u0301";
		((DataGridViewColumn)dgvcMau_so1).Name = "dgvcMau_so1";
		((DataGridViewColumn)dgvcMau_so1).ReadOnly = true;
		((DataGridViewColumn)dgvcMau_so1).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dgvcMau_so1).Width = 80;
		((DataGridViewColumn)dgvcSo_seri1).DataPropertyName = "so_seri";
		((DataGridViewColumn)dgvcSo_seri1).HeaderText = "Ky\u0301 Hiê\u0323u";
		((DataGridViewColumn)dgvcSo_seri1).Name = "dgvcSo_seri1";
		((DataGridViewColumn)dgvcSo_seri1).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_seri1).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dgvcSo_seri1).Width = 70;
		((DataGridViewColumn)dgvcTu_so1).DataPropertyName = "tu_so";
		((DataGridViewColumn)dgvcTu_so1).HeaderText = "Tư\u0300 Sô\u0301";
		((DataGridViewColumn)dgvcTu_so1).Name = "dgvcTu_so1";
		((DataGridViewColumn)dgvcTu_so1).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dgvcTu_so1).Width = 70;
		((DataGridViewColumn)dgvcDen_so1).DataPropertyName = "den_so";
		((DataGridViewColumn)dgvcDen_so1).HeaderText = "Đê\u0301n Sô\u0301";
		((DataGridViewColumn)dgvcDen_so1).Name = "dgvcDen_so1";
		((DataGridViewColumn)dgvcDen_so1).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dgvcDen_so1).Width = 70;
		((DataGridViewColumn)dgvcSo_luong1).DataPropertyName = "so_luong";
		val7.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)dgvcSo_luong1).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcSo_luong1).HeaderText = "Sô\u0301 Lươ\u0323ng";
		((DataGridViewColumn)dgvcSo_luong1).Name = "dgvcSo_luong1";
		((DataGridViewColumn)dgvcSo_luong1).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_luong1).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dgvcSo_luong1).Width = 80;
		((DataGridViewColumn)dgvcSo_hdin1).DataPropertyName = "so_hdin";
		((DataGridViewColumn)dgvcSo_hdin1).HeaderText = "Số HĐ In";
		((DataGridViewColumn)dgvcSo_hdin1).Name = "dgvcSo_hdin1";
		((DataGridViewColumn)dgvcSo_hdin1).Visible = false;
		((DataGridViewColumn)dgvcSo_hdph1).DataPropertyName = "so_hdph";
		((DataGridViewColumn)dgvcSo_hdph1).HeaderText = "Số HĐPH";
		((DataGridViewColumn)dgvcSo_hdph1).Name = "dgvcSo_hdph1";
		((DataGridViewColumn)dgvcSo_hdph1).Visible = false;
		((DataGridViewColumn)dgvcMa_ph2).DataPropertyName = "ma_ph";
		((DataGridViewColumn)dgvcMa_ph2).HeaderText = "Mã PH";
		((DataGridViewColumn)dgvcMa_ph2).Name = "dgvcMa_ph2";
		((DataGridViewColumn)dgvcMa_ph2).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_ph2).Visible = false;
		((DataGridViewColumn)dgvcLoai2).DataPropertyName = "loai";
		((DataGridViewColumn)dgvcLoai2).HeaderText = "Loại bảng kê";
		((DataGridViewColumn)dgvcLoai2).Name = "dgvcLoai2";
		((DataGridViewColumn)dgvcLoai2).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcLoai2).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcLoai2).Visible = false;
		((DataGridViewColumn)dgvcTen_loai2).DataPropertyName = "ten_loai";
		((DataGridViewColumn)dgvcTen_loai2).HeaderText = "Tên Loa\u0323i Hoa\u0301 Đơn";
		((DataGridViewColumn)dgvcTen_loai2).Name = "dgvcTen_loai2";
		((DataGridViewColumn)dgvcTen_loai2).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_loai2).Width = 290;
		((DataGridViewColumn)dgvcMau_so2).DataPropertyName = "mau_so";
		((DataGridViewColumn)dgvcMau_so2).HeaderText = "Mâ\u0303u Sô\u0301";
		((DataGridViewColumn)dgvcMau_so2).Name = "dgvcMau_so2";
		((DataGridViewColumn)dgvcMau_so2).ReadOnly = true;
		((DataGridViewColumn)dgvcMau_so2).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dgvcMau_so2).Width = 80;
		((DataGridViewColumn)dgvcSo_seri2).DataPropertyName = "so_seri";
		((DataGridViewColumn)dgvcSo_seri2).HeaderText = "Ky\u0301 Hiê\u0323u";
		((DataGridViewColumn)dgvcSo_seri2).Name = "dgvcSo_seri2";
		((DataGridViewColumn)dgvcSo_seri2).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_seri2).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dgvcSo_seri2).Width = 70;
		((DataGridViewColumn)dgvcTu_so2).DataPropertyName = "tu_so";
		((DataGridViewColumn)dgvcTu_so2).HeaderText = "Tư\u0300 Sô\u0301";
		((DataGridViewColumn)dgvcTu_so2).Name = "dgvcTu_so2";
		((DataGridViewColumn)dgvcTu_so2).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dgvcTu_so2).Width = 70;
		((DataGridViewColumn)dgvcDen_so2).DataPropertyName = "den_so";
		((DataGridViewColumn)dgvcDen_so2).HeaderText = "Đê\u0301n Sô\u0301";
		((DataGridViewColumn)dgvcDen_so2).Name = "dgvcDen_so2";
		((DataGridViewColumn)dgvcDen_so2).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dgvcDen_so2).Width = 70;
		((DataGridViewColumn)dgvcSo_luong2).DataPropertyName = "so_luong";
		val8.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)dgvcSo_luong2).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcSo_luong2).HeaderText = "Sô\u0301 Lươ\u0323ng";
		((DataGridViewColumn)dgvcSo_luong2).Name = "dgvcSo_luong2";
		((DataGridViewColumn)dgvcSo_luong2).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_luong2).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dgvcSo_luong2).Width = 80;
		((DataGridViewColumn)dgvcSo_hdin2).DataPropertyName = "so_hdin";
		((DataGridViewColumn)dgvcSo_hdin2).HeaderText = "Số HĐ In";
		((DataGridViewColumn)dgvcSo_hdin2).Name = "dgvcSo_hdin2";
		((DataGridViewColumn)dgvcSo_hdin2).Visible = false;
		((DataGridViewColumn)dgvcSo_hdph2).DataPropertyName = "so_hdph";
		((DataGridViewColumn)dgvcSo_hdph2).HeaderText = "Số HĐPH";
		((DataGridViewColumn)dgvcSo_hdph2).Name = "dgvcSo_hdph2";
		((DataGridViewColumn)dgvcSo_hdph2).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(727, 467);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSOND51bkhdEdit";
		((Form)this).Text = "frmSOND51bkhdEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((ISupportInitialize)adgvHDHetHan).EndInit();
		((ISupportInitialize)adgvHDGiaHan).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_tb).MaxLength = MyDictComplexInfo.code_length;
		((Control)txtMa_tb).Select();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			txtNgay_tb.Value = DateTime.Now;
			txtTen_cty.Text = CompanyInformations.CompanyName;
			txtMa_thue.Text = CompanyInformations.Ma_thue;
			txtDai_dien.Text = CompanyInformations.Director_Name;
			txtMa_tb_Format();
			GetData(" ");
		}
		else
		{
			GetData(((TextBox)txtMa_tb).Text);
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
			epNotice.SetError((Control)(object)txtMa_tb, Helper.GetMess(50157).Description);
			((Control)txtMa_tb).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtTen_cty))
		{
			epNotice.SetError((Control)(object)txtTen_cty, Helper.GetMess(50002).Description);
			((Control)txtTen_cty).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtDai_dien))
		{
			epNotice.SetError((Control)(object)txtDai_dien, Helper.GetMess(50002).Description);
			((Control)txtDai_dien).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtMa_thue))
		{
			epNotice.SetError((Control)(object)txtMa_thue, Helper.GetMess(50002).Description);
			((Control)txtMa_thue).Select();
			return false;
		}
		checked
		{
			int num = ((DataGridView)adgvHDHetHan).RowCount - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcTu_so1).Name, i].Value.ToString(), "", false) == 0)
				{
					((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcTu_so1).Name, i].ErrorText = Helper.GetMess(50002).Description;
					((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcTu_so1).Name, i].Selected = true;
					return false;
				}
				if (Operators.CompareString(((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcDen_so1).Name, i].Value.ToString(), "", false) == 0)
				{
					((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcDen_so1).Name, i].ErrorText = Helper.GetMess(50002).Description;
					((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcDen_so1).Name, i].Selected = true;
					return false;
				}
			}
			int num2 = ((DataGridView)adgvHDGiaHan).RowCount - 1;
			for (int j = 0; j <= num2; j++)
			{
				if (Operators.CompareString(((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcTu_so2).Name, j].Value.ToString(), "", false) == 0)
				{
					((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcTu_so2).Name, j].ErrorText = Helper.GetMess(50002).Description;
					((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcTu_so2).Name, j].Selected = true;
					return false;
				}
				if (Operators.CompareString(((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcDen_so2).Name, j].Value.ToString(), "", false) == 0)
				{
					((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcDen_so2).Name, j].ErrorText = Helper.GetMess(50002).Description;
					((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcDen_so2).Name, j].Selected = true;
					return false;
				}
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
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if ((((DataGridView)adgvHDHetHan).RowCount == 0) & (((DataGridView)adgvHDHetHan).RowCount == 0))
		{
			CMessageBox.Show(50018);
			return false;
		}
		((Control)txtMa_thue).Select();
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
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if ((((DataGridView)adgvHDHetHan).RowCount == 0) & (((DataGridView)adgvHDHetHan).RowCount == 0))
		{
			CMessageBox.Show(50018);
			return false;
		}
		bool flag = base.UpdateDB();
		if (Conversions.ToBoolean(Operators.AndObject(Operators.NotObject(chkKsd.Checked), (object)flag)))
		{
			SOND51bkhdDAO sOND51bkhdDAO = (SOND51bkhdDAO)DAOFactory.CreateDAOInstance("SOND51bkhdDAO", "SOND51bkhd");
			int num = sOND51bkhdDAO.Delete(((TextBox)txtMa_tb).Text);
			sOND51bkhdDAO.Destroy();
			InsertToCTHD();
		}
		return flag;
	}

	protected override void DataBinding()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtNgay_tb;
		CreateDataBinding(ref ojb, "ngay_tb", "Value");
		txtNgay_tb = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_tb;
		CreateDataBinding(ref ojb, "ma_tb");
		txtMa_tb = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTen_cty;
		CreateDataBinding(ref ojb, "ten_cty");
		txtTen_cty = (TextBox)ojb;
		ojb = (Control)(object)txtDai_dien;
		CreateDataBinding(ref ojb, "dai_dien");
		txtDai_dien = (TextBox)ojb;
		ojb = (Control)(object)txtMa_thue;
		CreateDataBinding(ref ojb, "ma_thue");
		txtMa_thue = (TextBox)ojb;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 13)
		{
			int rowCount = ((DataGridView)adgvHDGiaHan).RowCount;
			if (rowCount > 0 && ((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcSo_luong2).Name, checked(rowCount - 1)].Selected)
			{
				((Control)cmdSave).Focus();
			}
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void txtMa_tb_Leave(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(((TextBox)txtMa_tb).Text) < 1.0)
		{
			CMessageBox.Show(50157);
			((Control)txtMa_tb).Select();
		}
		txtMa_tb_Format();
	}

	private void txtMa_tb_KeyPress(object sender, KeyPressEventArgs e)
	{
		int KeyAscii = Strings.Asc(e.KeyChar);
		e.Handled = DigitsFilter(ref KeyAscii);
	}

	private void btnChonHD1_Click(object sender, EventArgs e)
	{
		frmChonHD frmChonHD2 = new frmChonHD();
		frmChonHD2.f_oDthd1 = f_oDtHetHan;
		frmChonHD2.f_bLoai = true;
		frmChonHD2.Show();
	}

	private void btnChonHD2_Click(object sender, EventArgs e)
	{
		frmChonHD frmChonHD2 = new frmChonHD();
		frmChonHD2.f_oDthd2 = f_oDtGiaHan;
		frmChonHD2.f_bLoai = false;
		frmChonHD2.Show();
	}

	private void btnXoaHD1_Click(object sender, EventArgs e)
	{
		DeleteRow(loai: true);
	}

	private void btnXoaHD2_Click(object sender, EventArgs e)
	{
		DeleteRow(loai: false);
	}

	private void adgvHD1_CellLeave(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		((DataGridView)adgvHDHetHan).EndEdit();
		if ((e.ColumnIndex == 5) | (e.ColumnIndex == 6))
		{
			string text = ((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcSo_hdin1).Name, e.RowIndex].Value.ToString();
			string text2 = ((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcSo_hdph1).Name, e.RowIndex].Value.ToString();
			string text3 = ((DataGridView)adgvHDHetHan)[e.ColumnIndex, e.RowIndex].Value.ToString();
			for (int i = text3.Length; i <= 6; i = checked(i + 1))
			{
				text3 = "0" + text3;
			}
			((DataGridView)adgvHDHetHan)[e.ColumnIndex, e.RowIndex].Value = text3;
			switch (ChkCell(e.RowIndex, text3, loai: true))
			{
			case 1:
				CMessageBox.ShowWithFormat(50180, new object[1] { text2 });
				((DataGridView)adgvHDHetHan)[e.ColumnIndex, e.RowIndex].Value = text2;
				break;
			case 2:
				CMessageBox.ShowWithFormat(50181, new object[1] { text });
				((DataGridView)adgvHDHetHan)[e.ColumnIndex, e.RowIndex].Value = text;
				break;
			}
			Calculate(e.RowIndex, loai: true);
		}
	}

	private void adgvHD2_CellLeave(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		((DataGridView)adgvHDGiaHan).EndEdit();
		if ((e.ColumnIndex == 5) | (e.ColumnIndex == 6))
		{
			string text = ((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcSo_hdin2).Name, e.RowIndex].Value.ToString();
			string text2 = ((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcSo_hdph2).Name, e.RowIndex].Value.ToString();
			string text3 = ((DataGridView)adgvHDGiaHan)[e.ColumnIndex, e.RowIndex].Value.ToString();
			for (int i = text3.Length; i <= 6; i = checked(i + 1))
			{
				text3 = "0" + text3;
			}
			((DataGridView)adgvHDGiaHan)[e.ColumnIndex, e.RowIndex].Value = text3;
			switch (ChkCell(e.RowIndex, text3, loai: false))
			{
			case 1:
				CMessageBox.ShowWithFormat(50180, new object[1] { text2 });
				((DataGridView)adgvHDGiaHan)[e.ColumnIndex, e.RowIndex].Value = text2;
				break;
			case 2:
				CMessageBox.ShowWithFormat(50181, new object[1] { text });
				((DataGridView)adgvHDGiaHan)[e.ColumnIndex, e.RowIndex].Value = text;
				break;
			}
			Calculate(e.RowIndex, loai: false);
		}
	}

	private void adgvHDHetHan_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (!((DataGridView)adgvHDHetHan)[e.ColumnIndex, e.RowIndex].ReadOnly)
		{
			((DataGridView)adgvHDHetHan).BeginEdit(true);
		}
	}

	private void adgvHDGiaHan_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (!((DataGridView)adgvHDGiaHan)[e.ColumnIndex, e.RowIndex].ReadOnly)
		{
			((DataGridView)adgvHDGiaHan).BeginEdit(true);
		}
	}

	protected void GetData(string ma_tb)
	{
		SOND51bkhdDAO sOND51bkhdDAO = (SOND51bkhdDAO)DAOFactory.CreateDAOInstance("SOND51bkhdDAO", "SOND51bkhd");
		f_oDtHetHan = sOND51bkhdDAO.GetData(ma_tb, loai: true);
		((DataGridView)adgvHDHetHan).DataSource = f_oDtHetHan;
		f_oDtGiaHan = sOND51bkhdDAO.GetData(ma_tb, loai: false);
		((DataGridView)adgvHDGiaHan).DataSource = f_oDtGiaHan;
		sOND51bkhdDAO.Destroy();
	}

	protected void DeleteRow(bool loai)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		if (((((DataGridView)adgvHDHetHan).RowCount > 0) | (((DataGridView)adgvHDGiaHan).RowCount > 0)) && (int)CMessageBox.ShowWithFormat(50003, (MessageBoxButtons)4) != 7)
		{
			if (loai)
			{
				((DataGridView)adgvHDHetHan).Rows.Remove(((DataGridView)adgvHDHetHan).CurrentRow);
			}
			else
			{
				((DataGridView)adgvHDGiaHan).Rows.Remove(((DataGridView)adgvHDGiaHan).CurrentRow);
			}
		}
	}

	protected void InsertToCTHD()
	{
		SOND51bkhdDAO sOND51bkhdDAO = (SOND51bkhdDAO)DAOFactory.CreateDAOInstance("SOND51bkhdDAO", "SOND51bkhd");
		checked
		{
			int num = ((DataGridView)adgvHDHetHan).RowCount - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = sOND51bkhdDAO.Insert(((TextBox)txtMa_tb).Text, Conversions.ToString(((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcMa_ph1).Name, i].Value), Conversions.ToString(((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcMau_so1).Name, i].Value), loai: true, Conversions.ToString(((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcSo_seri1).Name, i].Value), Conversions.ToString(((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcTen_loai1).Name, i].Value), Conversions.ToString(((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcTu_so1).Name, i].Value), Conversions.ToString(((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcDen_so1).Name, i].Value), Conversions.ToString(((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcSo_luong1).Name, i].Value), Conversions.ToString(((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcSo_hdin1).Name, i].Value), Conversions.ToString(((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcSo_hdph1).Name, i].Value));
			}
			int num3 = ((DataGridView)adgvHDGiaHan).RowCount - 1;
			for (int j = 0; j <= num3; j++)
			{
				int num2 = sOND51bkhdDAO.Insert(((TextBox)txtMa_tb).Text, Conversions.ToString(((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcMa_ph2).Name, j].Value), Conversions.ToString(((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcMau_so2).Name, j].Value), loai: false, Conversions.ToString(((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcSo_seri2).Name, j].Value), Conversions.ToString(((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcTen_loai2).Name, j].Value), Conversions.ToString(((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcTu_so2).Name, j].Value), Conversions.ToString(((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcDen_so2).Name, j].Value), Conversions.ToString(((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcSo_luong2).Name, j].Value), Conversions.ToString(((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcSo_hdin2).Name, j].Value), Conversions.ToString(((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcSo_hdph2).Name, j].Value));
			}
			sOND51bkhdDAO.Destroy();
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
			int num = MyDictComplexInfo.code_length - length;
			for (int i = 1; i <= num; i++)
			{
				((TextBox)txtMa_tb).Text = "0" + ((TextBox)txtMa_tb).Text;
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

	protected int ChkCell(int index, string str, bool loai)
	{
		string text;
		string text2;
		if (loai)
		{
			text = ((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcSo_hdin1).Name, index].Value.ToString();
			text2 = ((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcSo_luong1).Name, index].Value.ToString();
		}
		else
		{
			text = ((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcSo_hdin2).Name, index].Value.ToString();
			text2 = ((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcSo_hdph2).Name, index].Value.ToString();
		}
		checked
		{
			for (int i = text.Length; i <= 6; i++)
			{
				text = "0" + text;
			}
			for (int j = text2.Length; j <= 6; j++)
			{
				text2 = "0" + text2;
			}
			if (Operators.CompareString(str, text2, false) > 0)
			{
				return 1;
			}
			if (Operators.CompareString(str, text, false) < 0)
			{
				return 2;
			}
			return 3;
		}
	}

	protected void Calculate(int index, bool loai)
	{
		checked
		{
			try
			{
				if (loai)
				{
					int num = Convert.ToInt32(((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcTu_so1).Name, index].Value.ToString());
					int num2 = Convert.ToInt32(((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcDen_so1).Name, index].Value.ToString());
					((DataGridView)adgvHDHetHan)[((DataGridViewColumn)dgvcSo_luong1).Name, index].Value = num2 - num + 1;
				}
				else
				{
					int num3 = Convert.ToInt32(((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcTu_so2).Name, index].Value.ToString());
					int num4 = Convert.ToInt32(((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcDen_so2).Name, index].Value.ToString());
					((DataGridView)adgvHDGiaHan)[((DataGridViewColumn)dgvcSo_luong2).Name, index].Value = num4 - num3 + 1;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}
}
