using System;
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
public class frmPOTAINEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	[AccessedThroughProperty("txtDia_chi")]
	private TextBox _txtDia_chi;

	[AccessedThroughProperty("label0")]
	private Label _label0;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtNgay_ct")]
	private AsMaskedTextBox _txtNgay_ct;

	[AccessedThroughProperty("txtMa_kh")]
	private AsTextBox _txtMa_kh;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("txtSo_ct0")]
	private TextBox _txtSo_ct0;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("txtMST")]
	private TextBox _txtMST;

	[AccessedThroughProperty("txtThue_nk")]
	private AsTextNumeric _txtThue_nk;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("txtT_Thue")]
	private AsTextNumeric _txtT_Thue;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("txtThue_suat")]
	private AsTextNumeric _txtThue_suat;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("txtT_tien")]
	private AsTextNumeric _txtT_tien;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtTK_thue")]
	private AsTextBox _txtTK_thue;

	[AccessedThroughProperty("lblTen_Tkthue")]
	private Label _lblTen_Tkthue;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("txtTK_du")]
	private AsTextBox _txtTK_du;

	[AccessedThroughProperty("lblTen_tkdu")]
	private Label _lblTen_tkdu;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("txtTen_Kh")]
	private TextBox _txtTen_Kh;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("txtTen_vt")]
	private TextBox _txtTen_vt;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("txtGhi_chu")]
	private TextBox _txtGhi_chu;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("txtGia")]
	private AsTextNumeric _txtGia;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("txtSo_luong")]
	private AsTextNumeric _txtSo_luong;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("txtSo_seri0")]
	private TextBox _txtSo_seri0;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("txtNgay_ct0")]
	private AsMaskedTextBox _txtNgay_ct0;

	[AccessedThroughProperty("txtMau_bc")]
	private TextBox _txtMau_bc;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("txtTien_hang")]
	private AsTextNumeric _txtTien_hang;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("txtThue_TTDB")]
	private AsTextNumeric _txtThue_TTDB;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("txtSo_seri_mhd")]
	private TextBox _txtSo_seri_mhd;

	[AccessedThroughProperty("lblSo_seri_mhd")]
	private Label _lblSo_seri_mhd;

	private double tien_hang;

	internal virtual TextBox txtSo_ct
	{
		get
		{
			return _txtSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_ct = value;
		}
	}

	internal virtual Label lblMa_Bp
	{
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_Bp = value;
		}
	}

	internal virtual TextBox txtDia_chi
	{
		get
		{
			return _txtDia_chi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtDia_chi = value;
		}
	}

	internal virtual Label label0
	{
		get
		{
			return _label0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_label0 = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	protected virtual AsMaskedTextBox txtNgay_ct
	{
		get
		{
			return _txtNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNgay_ct = value;
		}
	}

	private virtual AsTextBox txtMa_kh
	{
		get
		{
			return _txtMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_kh_AfterCodeValidating;
			if (_txtMa_kh != null)
			{
				_txtMa_kh.AfterCodeValidating -= obj;
			}
			_txtMa_kh = value;
			if (_txtMa_kh != null)
			{
				_txtMa_kh.AfterCodeValidating += obj;
			}
		}
	}

	private virtual Label lblTk
	{
		get
		{
			return _lblTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTk = value;
		}
	}

	internal virtual TextBox txtSo_ct0
	{
		get
		{
			return _txtSo_ct0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_ct0 = value;
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	private virtual Label Label5
	{
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label5 = value;
		}
	}

	private virtual AsTextBox txtMa_vt
	{
		get
		{
			return _txtMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_vt_AfterCodeValidating;
			if (_txtMa_vt != null)
			{
				_txtMa_vt.AfterCodeValidating -= obj;
			}
			_txtMa_vt = value;
			if (_txtMa_vt != null)
			{
				_txtMa_vt.AfterCodeValidating += obj;
			}
		}
	}

	private virtual Label Label6
	{
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual TextBox txtMST
	{
		get
		{
			return _txtMST;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMST = value;
		}
	}

	internal virtual AsTextNumeric txtThue_nk
	{
		get
		{
			return _txtThue_nk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtThue_nk_Validated;
			if (_txtThue_nk != null)
			{
				((Control)_txtThue_nk).TextChanged -= eventHandler;
			}
			_txtThue_nk = value;
			if (_txtThue_nk != null)
			{
				((Control)_txtThue_nk).TextChanged += eventHandler;
			}
		}
	}

	private virtual Label Label7
	{
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual AsTextNumeric txtT_Thue
	{
		get
		{
			return _txtT_Thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtT_Thue = value;
		}
	}

	private virtual Label Label10
	{
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual AsTextNumeric txtThue_suat
	{
		get
		{
			return _txtThue_suat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtThue_suat_Validated;
			if (_txtThue_suat != null)
			{
				((Control)_txtThue_suat).TextChanged -= eventHandler;
			}
			_txtThue_suat = value;
			if (_txtThue_suat != null)
			{
				((Control)_txtThue_suat).TextChanged += eventHandler;
			}
		}
	}

	private virtual Label Label9
	{
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual AsTextNumeric txtT_tien
	{
		get
		{
			return _txtT_tien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtT_tien_Validated;
			if (_txtT_tien != null)
			{
				((Control)_txtT_tien).TextChanged -= eventHandler;
			}
			_txtT_tien = value;
			if (_txtT_tien != null)
			{
				((Control)_txtT_tien).TextChanged += eventHandler;
			}
		}
	}

	private virtual Label Label8
	{
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label8 = value;
		}
	}

	private virtual AsTextBox txtTK_thue
	{
		get
		{
			return _txtTK_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTK_thue = value;
		}
	}

	private virtual Label lblTen_Tkthue
	{
		get
		{
			return _lblTen_Tkthue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Tkthue = value;
		}
	}

	private virtual Label Label13
	{
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label13 = value;
		}
	}

	private virtual AsTextBox txtMa_spct
	{
		get
		{
			return _txtMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_spct = value;
		}
	}

	private virtual Label lblTen_spct
	{
		get
		{
			return _lblTen_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_spct = value;
		}
	}

	private virtual Label Label21
	{
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label21 = value;
		}
	}

	private virtual AsTextBox txtMa_bp
	{
		get
		{
			return _txtMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_bp = value;
		}
	}

	private virtual Label lblTen_bp
	{
		get
		{
			return _lblTen_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_bp = value;
		}
	}

	private virtual Label Label19
	{
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label19 = value;
		}
	}

	private virtual AsTextBox txtTK_du
	{
		get
		{
			return _txtTK_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTK_du = value;
		}
	}

	private virtual Label lblTen_tkdu
	{
		get
		{
			return _lblTen_tkdu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_tkdu = value;
		}
	}

	private virtual Label Label15
	{
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label15 = value;
		}
	}

	internal virtual TextBox txtTen_Kh
	{
		get
		{
			return _txtTen_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTen_Kh = value;
		}
	}

	internal virtual Label Label22
	{
		get
		{
			return _Label22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label22 = value;
		}
	}

	internal virtual TextBox txtTen_vt
	{
		get
		{
			return _txtTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTen_vt = value;
		}
	}

	internal virtual Label Label23
	{
		get
		{
			return _Label23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label23 = value;
		}
	}

	internal virtual TextBox txtGhi_chu
	{
		get
		{
			return _txtGhi_chu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGhi_chu = value;
		}
	}

	internal virtual Label Label24
	{
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label24 = value;
		}
	}

	internal virtual AsTextNumeric txtGia
	{
		get
		{
			return _txtGia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtGia_Validated;
			if (_txtGia != null)
			{
				((Control)_txtGia).TextChanged -= eventHandler;
			}
			_txtGia = value;
			if (_txtGia != null)
			{
				((Control)_txtGia).TextChanged += eventHandler;
			}
		}
	}

	private virtual Label Label14
	{
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual AsTextNumeric txtSo_luong
	{
		get
		{
			return _txtSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtGia_Validated;
			EventHandler eventHandler2 = txtSo_luong_Validated;
			if (_txtSo_luong != null)
			{
				((Control)_txtSo_luong).TextChanged -= eventHandler;
				((Control)_txtSo_luong).TextChanged -= eventHandler2;
			}
			_txtSo_luong = value;
			if (_txtSo_luong != null)
			{
				((Control)_txtSo_luong).TextChanged += eventHandler;
				((Control)_txtSo_luong).TextChanged += eventHandler2;
			}
		}
	}

	private virtual Label Label16
	{
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label16 = value;
		}
	}

	internal virtual TextBox txtSo_seri0
	{
		get
		{
			return _txtSo_seri0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_seri0 = value;
		}
	}

	internal virtual Label Label18
	{
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label18 = value;
		}
	}

	protected virtual AsMaskedTextBox txtNgay_ct0
	{
		get
		{
			return _txtNgay_ct0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNgay_ct0 = value;
		}
	}

	internal virtual TextBox txtMau_bc
	{
		get
		{
			return _txtMau_bc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMau_bc = value;
		}
	}

	internal virtual Label Label20
	{
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label20 = value;
		}
	}

	internal virtual AsTextNumeric txtTien_hang
	{
		get
		{
			return _txtTien_hang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtTien_hang_Validated;
			if (_txtTien_hang != null)
			{
				((Control)_txtTien_hang).TextChanged -= eventHandler;
			}
			_txtTien_hang = value;
			if (_txtTien_hang != null)
			{
				((Control)_txtTien_hang).TextChanged += eventHandler;
			}
		}
	}

	private virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label4 = value;
		}
	}

	private virtual Label Label11
	{
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual AsTextNumeric txtThue_TTDB
	{
		get
		{
			return _txtThue_TTDB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtThue_TTDB_Validated;
			if (_txtThue_TTDB != null)
			{
				((Control)_txtThue_TTDB).TextChanged -= eventHandler;
			}
			_txtThue_TTDB = value;
			if (_txtThue_TTDB != null)
			{
				((Control)_txtThue_TTDB).TextChanged += eventHandler;
			}
		}
	}

	private virtual Label Label12
	{
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual TextBox txtSo_seri_mhd
	{
		get
		{
			return _txtSo_seri_mhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_seri_mhd = value;
		}
	}

	internal virtual Label lblSo_seri_mhd
	{
		get
		{
			return _lblSo_seri_mhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblSo_seri_mhd = value;
		}
	}

	public frmPOTAINEdit()
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
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
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		txtSo_ct = new TextBox();
		lblMa_Bp = new Label();
		txtDia_chi = new TextBox();
		label0 = new Label();
		txtNgay_ct = new AsMaskedTextBox();
		Label1 = new Label();
		Label2 = new Label();
		txtNgay_ct0 = new AsMaskedTextBox();
		txtSo_ct0 = new TextBox();
		Label3 = new Label();
		txtMa_kh = new AsTextBox();
		lblTk = new Label();
		Label5 = new Label();
		txtMST = new TextBox();
		txtMa_vt = new AsTextBox();
		Label6 = new Label();
		Label7 = new Label();
		txtThue_nk = new AsTextNumeric();
		txtT_tien = new AsTextNumeric();
		Label8 = new Label();
		txtThue_suat = new AsTextNumeric();
		Label9 = new Label();
		txtT_Thue = new AsTextNumeric();
		Label10 = new Label();
		txtTK_thue = new AsTextBox();
		lblTen_Tkthue = new Label();
		Label13 = new Label();
		txtTK_du = new AsTextBox();
		lblTen_tkdu = new Label();
		Label15 = new Label();
		txtMa_bp = new AsTextBox();
		lblTen_bp = new Label();
		Label19 = new Label();
		txtMa_spct = new AsTextBox();
		lblTen_spct = new Label();
		Label21 = new Label();
		txtTen_Kh = new TextBox();
		Label22 = new Label();
		txtTen_vt = new TextBox();
		Label23 = new Label();
		txtGhi_chu = new TextBox();
		Label24 = new Label();
		txtGia = new AsTextNumeric();
		Label14 = new Label();
		txtSo_luong = new AsTextNumeric();
		Label16 = new Label();
		txtSo_seri0 = new TextBox();
		Label18 = new Label();
		txtMau_bc = new TextBox();
		Label20 = new Label();
		Label4 = new Label();
		txtTien_hang = new AsTextNumeric();
		Label11 = new Label();
		GroupBox1 = new GroupBox();
		Label12 = new Label();
		txtThue_TTDB = new AsTextNumeric();
		txtSo_seri_mhd = new TextBox();
		lblSo_seri_mhd = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(584, 458);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 2;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 462);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 462);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtSo_seri_mhd);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_seri_mhd);
		((Control)gbLine).Controls.Add((Control)(object)Label14);
		((Control)gbLine).Controls.Add((Control)(object)txtThue_TTDB);
		((Control)gbLine).Controls.Add((Control)(object)Label12);
		((Control)gbLine).Controls.Add((Control)(object)GroupBox1);
		((Control)gbLine).Controls.Add((Control)(object)Label11);
		((Control)gbLine).Controls.Add((Control)(object)txtMau_bc);
		((Control)gbLine).Controls.Add((Control)(object)Label20);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_seri0);
		((Control)gbLine).Controls.Add((Control)(object)Label18);
		((Control)gbLine).Controls.Add((Control)(object)txtGia);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_luong);
		((Control)gbLine).Controls.Add((Control)(object)Label16);
		((Control)gbLine).Controls.Add((Control)(object)txtGhi_chu);
		((Control)gbLine).Controls.Add((Control)(object)Label24);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_vt);
		((Control)gbLine).Controls.Add((Control)(object)Label23);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Kh);
		((Control)gbLine).Controls.Add((Control)(object)Label22);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_spct);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_spct);
		((Control)gbLine).Controls.Add((Control)(object)Label21);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_bp);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_bp);
		((Control)gbLine).Controls.Add((Control)(object)Label19);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_du);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tkdu);
		((Control)gbLine).Controls.Add((Control)(object)Label15);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_thue);
		((Control)gbLine).Controls.Add((Control)(object)Label13);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tkthue);
		((Control)gbLine).Controls.Add((Control)(object)txtT_Thue);
		((Control)gbLine).Controls.Add((Control)(object)txtThue_suat);
		((Control)gbLine).Controls.Add((Control)(object)Label9);
		((Control)gbLine).Controls.Add((Control)(object)Label10);
		((Control)gbLine).Controls.Add((Control)(object)txtT_tien);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)txtThue_nk);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)txtTien_hang);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)txtMST);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_kh);
		((Control)gbLine).Controls.Add((Control)(object)lblTk);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct0);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct0);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtDia_chi);
		((Control)gbLine).Controls.Add((Control)(object)label0);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Bp);
		GroupBox obj3 = gbLine;
		Size size = new Size(795, 449);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)label0, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDia_chi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct0, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct0, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMST, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTien_hang, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtThue_nk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtT_tien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label10, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label9, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtThue_suat, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtT_Thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tkthue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label13, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label15, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tkdu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_du, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label19, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label21, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label22, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label23, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label24, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGhi_chu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label16, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_luong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label18, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_seri0, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label20, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMau_bc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label11, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)GroupBox1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label12, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtThue_TTDB, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label14, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_seri_mhd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_seri_mhd, 0);
		TextBox obj4 = txtSo_ct;
		location = new Point(120, 46);
		((Control)obj4).Location = location;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj5 = txtSo_ct;
		size = new Size(100, 20);
		((Control)obj5).Size = size;
		((Control)txtSo_ct).TabIndex = 1;
		lblMa_Bp.AutoSize = true;
		Label obj6 = lblMa_Bp;
		location = new Point(16, 49);
		((Control)obj6).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj7 = lblMa_Bp;
		size = new Size(65, 13);
		((Control)obj7).Size = size;
		((Control)lblMa_Bp).TabIndex = 2;
		lblMa_Bp.Text = "Số chứng từ";
		TextBox obj8 = txtDia_chi;
		location = new Point(120, 254);
		((Control)obj8).Location = location;
		((TextBoxBase)txtDia_chi).MaxLength = 128;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj9 = txtDia_chi;
		size = new Size(282, 20);
		((Control)obj9).Size = size;
		((Control)txtDia_chi).TabIndex = 9;
		label0.AutoSize = true;
		Label obj10 = label0;
		location = new Point(16, 257);
		((Control)obj10).Location = location;
		((Control)label0).Name = "label0";
		Label obj11 = label0;
		size = new Size(40, 13);
		((Control)obj11).Size = size;
		((Control)label0).TabIndex = 4;
		label0.Text = "Địa chỉ";
		txtNgay_ct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct;
		location = new Point(120, 20);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ct).Mask = "##/##/####";
		((Control)txtNgay_ct).Name = "txtNgay_ct";
		((MaskedTextBox)txtNgay_ct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ct;
		size = new Size(100, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ct).TabIndex = 0;
		((MaskedTextBox)txtNgay_ct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(16, 23);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(77, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 8;
		Label1.Text = "Ngày chứng từ";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(16, 75);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(75, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 10;
		Label2.Text = "Ngày hóa đơn";
		txtNgay_ct0.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct0).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_ct0;
		location = new Point(120, 72);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_ct0).Mask = "##/##/####";
		((Control)txtNgay_ct0).Name = "txtNgay_ct0";
		((MaskedTextBox)txtNgay_ct0).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_ct0;
		size = new Size(100, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_ct0).TabIndex = 2;
		((MaskedTextBox)txtNgay_ct0).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_ct0;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		TextBox obj12 = txtSo_ct0;
		location = new Point(120, 98);
		((Control)obj12).Location = location;
		((Control)txtSo_ct0).Name = "txtSo_ct0";
		TextBox obj13 = txtSo_ct0;
		size = new Size(100, 20);
		((Control)obj13).Size = size;
		((Control)txtSo_ct0).TabIndex = 3;
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(16, 101);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(63, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 12;
		Label3.Text = "Số hóa đơn";
		((TextBox)txtMa_kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = true;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_kh;
		location = new Point(120, 202);
		((Control)asTextBox).Location = location;
		txtMa_kh.LookupCodeName = "MA_KH";
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = null;
		txtMa_kh.SD = true;
		AsTextBox asTextBox2 = txtMa_kh;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_kh).TabIndex = 7;
		((Control)txtMa_kh).Tag = "@pMA_KH";
		txtMa_kh.UseAutoCompleteSource = true;
		txtMa_kh.ValidReturnFieldList = "ten_kh,ma_so_thue,dia_chi";
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj14 = lblTk;
		location = new Point(16, 205);
		((Control)obj14).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj15 = lblTk;
		size = new Size(47, 13);
		((Control)obj15).Size = size;
		((Control)lblTk).TabIndex = 1019;
		lblTk.Text = "Mã NCC";
		Label5.AutoSize = true;
		Label5.ImeMode = (ImeMode)0;
		Label label7 = Label5;
		location = new Point(16, 283);
		((Control)label7).Location = location;
		((Control)Label5).Name = "Label5";
		Label label8 = Label5;
		size = new Size(60, 13);
		((Control)label8).Size = size;
		((Control)Label5).TabIndex = 1022;
		Label5.Text = "Mã số thuế";
		TextBox obj16 = txtMST;
		location = new Point(120, 280);
		((Control)obj16).Location = location;
		((Control)txtMST).Name = "txtMST";
		TextBox obj17 = txtMST;
		size = new Size(148, 20);
		((Control)obj17).Size = size;
		((Control)txtMST).TabIndex = 10;
		((TextBox)txtMa_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = true;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_vt;
		location = new Point(495, 23);
		((Control)asTextBox3).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = null;
		txtMa_vt.SD = true;
		AsTextBox asTextBox4 = txtMa_vt;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_vt).TabIndex = 11;
		((Control)txtMa_vt).Tag = "@pMA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		txtMa_vt.ValidReturnFieldList = "ten_vt";
		Label6.AutoSize = true;
		Label6.ImeMode = (ImeMode)0;
		Label label9 = Label6;
		location = new Point(413, 23);
		((Control)label9).Location = location;
		((Control)Label6).Name = "Label6";
		Label label10 = Label6;
		size = new Size(39, 13);
		((Control)label10).Size = size;
		((Control)Label6).TabIndex = 1026;
		Label6.Text = "Mã VT";
		Label7.AutoSize = true;
		Label7.ImeMode = (ImeMode)0;
		Label label11 = Label7;
		location = new Point(413, 153);
		((Control)label11).Location = location;
		((Control)Label7).Name = "Label7";
		Label label12 = Label7;
		size = new Size(50, 13);
		((Control)label12).Size = size;
		((Control)Label7).TabIndex = 1034;
		Label7.Text = "Thuế NK";
		txtThue_nk.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtThue_nk;
		location = new Point(495, 153);
		((Control)asTextNumeric).Location = location;
		txtThue_nk.Mask = "### ### ### ###.##";
		((Control)txtThue_nk).Name = "txtThue_nk";
		AsTextNumeric asTextNumeric2 = txtThue_nk;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtThue_nk).TabIndex = 16;
		((TextBox)txtThue_nk).Text = "0.00";
		((TextBox)txtThue_nk).TextAlign = (HorizontalAlignment)1;
		txtThue_nk.Value = 0.0;
		((TextBoxBase)txtT_tien).BackColor = SystemColors.Window;
		txtT_tien.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric3 = txtT_tien;
		location = new Point(495, 205);
		((Control)asTextNumeric3).Location = location;
		txtT_tien.Mask = "### ### ### ###.##";
		((Control)txtT_tien).Name = "txtT_tien";
		AsTextNumeric asTextNumeric4 = txtT_tien;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtT_tien).TabIndex = 18;
		((TextBox)txtT_tien).Text = "0.00";
		((TextBox)txtT_tien).TextAlign = (HorizontalAlignment)1;
		txtT_tien.Value = 0.0;
		Label8.AutoSize = true;
		Label8.ImeMode = (ImeMode)0;
		Label label13 = Label8;
		location = new Point(413, 205);
		((Control)label13).Location = location;
		((Control)Label8).Name = "Label8";
		Label label14 = Label8;
		size = new Size(52, 13);
		((Control)label14).Size = size;
		((Control)Label8).TabIndex = 1036;
		Label8.Text = "Tổng tiền";
		txtThue_suat.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric5 = txtThue_suat;
		location = new Point(495, 231);
		((Control)asTextNumeric5).Location = location;
		txtThue_suat.Mask = "### ### ### ###.##";
		((Control)txtThue_suat).Name = "txtThue_suat";
		AsTextNumeric asTextNumeric6 = txtThue_suat;
		size = new Size(73, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtThue_suat).TabIndex = 19;
		((TextBox)txtThue_suat).Text = "0.00";
		((TextBox)txtThue_suat).TextAlign = (HorizontalAlignment)1;
		txtThue_suat.Value = 0.0;
		Label9.AutoSize = true;
		Label9.ImeMode = (ImeMode)0;
		Label label15 = Label9;
		location = new Point(413, 231);
		((Control)label15).Location = location;
		((Control)Label9).Name = "Label9";
		Label label16 = Label9;
		size = new Size(79, 13);
		((Control)label16).Size = size;
		((Control)Label9).TabIndex = 1038;
		Label9.Text = "Thuế suất VAT";
		txtT_Thue.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric7 = txtT_Thue;
		location = new Point(495, 257);
		((Control)asTextNumeric7).Location = location;
		txtT_Thue.Mask = "### ### ### ###.##";
		((Control)txtT_Thue).Name = "txtT_Thue";
		AsTextNumeric asTextNumeric8 = txtT_Thue;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtT_Thue).TabIndex = 20;
		((TextBox)txtT_Thue).Text = "0.00";
		((TextBox)txtT_Thue).TextAlign = (HorizontalAlignment)1;
		txtT_Thue.Value = 0.0;
		Label10.AutoSize = true;
		Label10.ImeMode = (ImeMode)0;
		Label label17 = Label10;
		location = new Point(413, 257);
		((Control)label17).Location = location;
		((Control)Label10).Name = "Label10";
		Label label18 = Label10;
		size = new Size(65, 13);
		((Control)label18).Size = size;
		((Control)Label10).TabIndex = 1042;
		Label10.Text = "Thuế GTGT";
		((TextBox)txtTK_thue).AutoCompleteSource = (AutoCompleteSource)64;
		txtTK_thue.AutoLookup = true;
		txtTK_thue.AutoValid = true;
		((TextBoxBase)txtTK_thue).BackColor = SystemColors.Info;
		((TextBox)txtTK_thue).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTK_thue;
		location = new Point(147, 346);
		((Control)asTextBox5).Location = location;
		txtTK_thue.LookupCodeName = "TK";
		txtTK_thue.LookupWhereCondition = "CHI_TIET ='1'";
		((Control)txtTK_thue).Name = "txtTK_thue";
		txtTK_thue.NameControl = lblTen_Tkthue;
		txtTK_thue.SD = true;
		AsTextBox asTextBox6 = txtTK_thue;
		size = new Size(100, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTK_thue).TabIndex = 22;
		((Control)txtTK_thue).Tag = "@pTK";
		txtTK_thue.UseAutoCompleteSource = true;
		lblTen_Tkthue.ImeMode = (ImeMode)0;
		Label obj18 = lblTen_Tkthue;
		location = new Point(253, 350);
		((Control)obj18).Location = location;
		((Control)lblTen_Tkthue).Name = "lblTen_Tkthue";
		Label obj19 = lblTen_Tkthue;
		size = new Size(472, 13);
		((Control)obj19).Size = size;
		((Control)lblTen_Tkthue).TabIndex = 1047;
		lblTen_Tkthue.TextAlign = (ContentAlignment)16;
		Label13.AutoSize = true;
		Label13.ImeMode = (ImeMode)0;
		Label label19 = Label13;
		location = new Point(16, 349);
		((Control)label19).Location = location;
		((Control)Label13).Name = "Label13";
		Label label20 = Label13;
		size = new Size(45, 13);
		((Control)label20).Size = size;
		((Control)Label13).TabIndex = 1046;
		Label13.Text = "TK thuế";
		((TextBox)txtTK_du).AutoCompleteSource = (AutoCompleteSource)64;
		txtTK_du.AutoLookup = true;
		txtTK_du.AutoValid = true;
		((TextBoxBase)txtTK_du).BackColor = SystemColors.Info;
		((TextBox)txtTK_du).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtTK_du;
		location = new Point(147, 372);
		((Control)asTextBox7).Location = location;
		txtTK_du.LookupCodeName = "TK";
		txtTK_du.LookupWhereCondition = "CHI_TIET ='1'";
		((Control)txtTK_du).Name = "txtTK_du";
		txtTK_du.NameControl = lblTen_tkdu;
		txtTK_du.SD = true;
		AsTextBox asTextBox8 = txtTK_du;
		size = new Size(100, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtTK_du).TabIndex = 23;
		((Control)txtTK_du).Tag = "@pTK";
		txtTK_du.UseAutoCompleteSource = true;
		lblTen_tkdu.ImeMode = (ImeMode)0;
		Label obj20 = lblTen_tkdu;
		location = new Point(253, 376);
		((Control)obj20).Location = location;
		((Control)lblTen_tkdu).Name = "lblTen_tkdu";
		Label obj21 = lblTen_tkdu;
		size = new Size(472, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_tkdu).TabIndex = 1050;
		lblTen_tkdu.TextAlign = (ContentAlignment)16;
		Label15.AutoSize = true;
		Label15.ImeMode = (ImeMode)0;
		Label label21 = Label15;
		location = new Point(16, 375);
		((Control)label21).Location = location;
		((Control)Label15).Name = "Label15";
		Label label22 = Label15;
		size = new Size(60, 13);
		((Control)label22).Size = size;
		((Control)Label15).TabIndex = 1049;
		Label15.Text = "TK đối ứng";
		((TextBox)txtMa_bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = true;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_bp;
		location = new Point(147, 398);
		((Control)asTextBox9).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		txtMa_bp.SD = true;
		AsTextBox asTextBox10 = txtMa_bp;
		size = new Size(100, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_bp).TabIndex = 24;
		((Control)txtMa_bp).Tag = "@pMA_BP";
		txtMa_bp.UseAutoCompleteSource = true;
		lblTen_bp.ImeMode = (ImeMode)0;
		Label obj22 = lblTen_bp;
		location = new Point(253, 402);
		((Control)obj22).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj23 = lblTen_bp;
		size = new Size(472, 13);
		((Control)obj23).Size = size;
		((Control)lblTen_bp).TabIndex = 1053;
		lblTen_bp.TextAlign = (ContentAlignment)16;
		Label19.AutoSize = true;
		Label19.ImeMode = (ImeMode)0;
		Label label23 = Label19;
		location = new Point(16, 401);
		((Control)label23).Location = location;
		((Control)Label19).Name = "Label19";
		Label label24 = Label19;
		size = new Size(39, 13);
		((Control)label24).Size = size;
		((Control)Label19).TabIndex = 1052;
		Label19.Text = "Mã BP";
		((TextBox)txtMa_spct).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = true;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtMa_spct;
		location = new Point(147, 424);
		((Control)asTextBox11).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		txtMa_spct.SD = true;
		AsTextBox asTextBox12 = txtMa_spct;
		size = new Size(100, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtMa_spct).TabIndex = 25;
		((Control)txtMa_spct).Tag = "@pMA_SPCT";
		txtMa_spct.UseAutoCompleteSource = true;
		lblTen_spct.ImeMode = (ImeMode)0;
		Label obj24 = lblTen_spct;
		location = new Point(253, 428);
		((Control)obj24).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj25 = lblTen_spct;
		size = new Size(472, 13);
		((Control)obj25).Size = size;
		((Control)lblTen_spct).TabIndex = 1059;
		lblTen_spct.TextAlign = (ContentAlignment)16;
		Label21.AutoSize = true;
		Label21.ImeMode = (ImeMode)0;
		Label label25 = Label21;
		location = new Point(16, 427);
		((Control)label25).Location = location;
		((Control)Label21).Name = "Label21";
		Label label26 = Label21;
		size = new Size(53, 13);
		((Control)label26).Size = size;
		((Control)Label21).TabIndex = 1058;
		Label21.Text = "Mã SPCT";
		TextBox obj26 = txtTen_Kh;
		location = new Point(120, 228);
		((Control)obj26).Location = location;
		((Control)txtTen_Kh).Name = "txtTen_Kh";
		TextBox obj27 = txtTen_Kh;
		size = new Size(282, 20);
		((Control)obj27).Size = size;
		((Control)txtTen_Kh).TabIndex = 8;
		Label22.AutoSize = true;
		Label label27 = Label22;
		location = new Point(16, 231);
		((Control)label27).Location = location;
		((Control)Label22).Name = "Label22";
		Label label28 = Label22;
		size = new Size(51, 13);
		((Control)label28).Size = size;
		((Control)Label22).TabIndex = 1061;
		Label22.Text = "Tên NCC";
		TextBox obj28 = txtTen_vt;
		location = new Point(495, 49);
		((Control)obj28).Location = location;
		((Control)txtTen_vt).Name = "txtTen_vt";
		TextBox obj29 = txtTen_vt;
		size = new Size(264, 20);
		((Control)obj29).Size = size;
		((Control)txtTen_vt).TabIndex = 12;
		Label23.AutoSize = true;
		Label label29 = Label23;
		location = new Point(413, 49);
		((Control)label29).Location = location;
		((Control)Label23).Name = "Label23";
		Label label30 = Label23;
		size = new Size(43, 13);
		((Control)label30).Size = size;
		((Control)Label23).TabIndex = 1063;
		Label23.Text = "Tên VT";
		TextBox obj30 = txtGhi_chu;
		location = new Point(120, 306);
		((Control)obj30).Location = location;
		((Control)txtGhi_chu).Name = "txtGhi_chu";
		TextBox obj31 = txtGhi_chu;
		size = new Size(610, 20);
		((Control)obj31).Size = size;
		((Control)txtGhi_chu).TabIndex = 21;
		Label24.AutoSize = true;
		Label label31 = Label24;
		location = new Point(16, 309);
		((Control)label31).Location = location;
		((Control)Label24).Name = "Label24";
		Label label32 = Label24;
		size = new Size(44, 13);
		((Control)label32).Size = size;
		((Control)Label24).TabIndex = 1065;
		Label24.Text = "Ghi chú";
		txtGia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric9 = txtGia;
		location = new Point(495, 101);
		((Control)asTextNumeric9).Location = location;
		txtGia.Mask = "### ### ### ###.##";
		((Control)txtGia).Name = "txtGia";
		AsTextNumeric asTextNumeric10 = txtGia;
		size = new Size(100, 20);
		((Control)asTextNumeric10).Size = size;
		((Control)txtGia).TabIndex = 14;
		((TextBox)txtGia).Text = "0.00";
		((TextBox)txtGia).TextAlign = (HorizontalAlignment)1;
		txtGia.Value = 0.0;
		Label14.AutoSize = true;
		Label14.ImeMode = (ImeMode)0;
		Label label33 = Label14;
		location = new Point(413, 101);
		((Control)label33).Location = location;
		((Control)Label14).Name = "Label14";
		Label label34 = Label14;
		size = new Size(44, 13);
		((Control)label34).Size = size;
		((Control)Label14).TabIndex = 1070;
		Label14.Text = "Đơn giá";
		((TextBoxBase)txtSo_luong).BackColor = SystemColors.Window;
		txtSo_luong.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric11 = txtSo_luong;
		location = new Point(495, 75);
		((Control)asTextNumeric11).Location = location;
		txtSo_luong.Mask = "### ### ### ###.##";
		((Control)txtSo_luong).Name = "txtSo_luong";
		AsTextNumeric asTextNumeric12 = txtSo_luong;
		size = new Size(100, 20);
		((Control)asTextNumeric12).Size = size;
		((Control)txtSo_luong).TabIndex = 13;
		((TextBox)txtSo_luong).Text = "0.00";
		((TextBox)txtSo_luong).TextAlign = (HorizontalAlignment)1;
		txtSo_luong.Value = 0.0;
		Label16.AutoSize = true;
		Label16.ImeMode = (ImeMode)0;
		Label label35 = Label16;
		location = new Point(413, 75);
		((Control)label35).Location = location;
		((Control)Label16).Name = "Label16";
		Label label36 = Label16;
		size = new Size(49, 13);
		((Control)label36).Size = size;
		((Control)Label16).TabIndex = 1069;
		Label16.Text = "Số lượng";
		TextBox obj32 = txtSo_seri0;
		location = new Point(120, 124);
		((Control)obj32).Location = location;
		((Control)txtSo_seri0).Name = "txtSo_seri0";
		TextBox obj33 = txtSo_seri0;
		size = new Size(100, 20);
		((Control)obj33).Size = size;
		((Control)txtSo_seri0).TabIndex = 4;
		Label18.AutoSize = true;
		Label label37 = Label18;
		location = new Point(16, 127);
		((Control)label37).Location = location;
		((Control)Label18).Name = "Label18";
		Label label38 = Label18;
		size = new Size(41, 13);
		((Control)label38).Size = size;
		((Control)Label18).TabIndex = 1074;
		Label18.Text = "Số Sêri";
		TextBox obj34 = txtMau_bc;
		location = new Point(120, 150);
		((Control)obj34).Location = location;
		((Control)txtMau_bc).Name = "txtMau_bc";
		TextBox obj35 = txtMau_bc;
		size = new Size(100, 20);
		((Control)obj35).Size = size;
		((Control)txtMau_bc).TabIndex = 5;
		Label20.AutoSize = true;
		Label label39 = Label20;
		location = new Point(16, 153);
		((Control)label39).Location = location;
		((Control)Label20).Name = "Label20";
		Label label40 = Label20;
		size = new Size(51, 13);
		((Control)label40).Size = size;
		((Control)Label20).TabIndex = 1076;
		Label20.Text = "Phân loại";
		Label4.AutoSize = true;
		Label4.ImeMode = (ImeMode)0;
		Label label41 = Label4;
		location = new Point(413, 127);
		((Control)label41).Location = location;
		((Control)Label4).Name = "Label4";
		Label label42 = Label4;
		size = new Size(55, 13);
		((Control)label42).Size = size;
		((Control)Label4).TabIndex = 1029;
		Label4.Text = "Tiền hàng";
		txtTien_hang.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric13 = txtTien_hang;
		location = new Point(495, 127);
		((Control)asTextNumeric13).Location = location;
		txtTien_hang.Mask = "### ### ### ###.##";
		((Control)txtTien_hang).Name = "txtTien_hang";
		AsTextNumeric asTextNumeric14 = txtTien_hang;
		size = new Size(100, 20);
		((Control)asTextNumeric14).Size = size;
		((Control)txtTien_hang).TabIndex = 15;
		((TextBox)txtTien_hang).Text = "0.00";
		((TextBox)txtTien_hang).TextAlign = (HorizontalAlignment)1;
		txtTien_hang.Value = 0.0;
		Label11.AutoSize = true;
		Label11.ImeMode = (ImeMode)0;
		Label label43 = Label11;
		location = new Point(574, 234);
		((Control)label43).Location = location;
		((Control)Label11).Name = "Label11";
		Label label44 = Label11;
		size = new Size(21, 13);
		((Control)label44).Size = size;
		((Control)Label11).TabIndex = 1077;
		Label11.Text = "(%)";
		GroupBox groupBox = GroupBox1;
		location = new Point(19, 331);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(738, 5);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 1078;
		GroupBox1.TabStop = false;
		Label12.AutoSize = true;
		Label12.ImeMode = (ImeMode)0;
		Label label45 = Label12;
		location = new Point(413, 178);
		((Control)label45).Location = location;
		((Control)Label12).Name = "Label12";
		Label label46 = Label12;
		size = new Size(64, 13);
		((Control)label46).Size = size;
		((Control)Label12).TabIndex = 1079;
		Label12.Text = "Thuế TTĐB";
		txtThue_TTDB.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric15 = txtThue_TTDB;
		location = new Point(495, 179);
		((Control)asTextNumeric15).Location = location;
		txtThue_TTDB.Mask = "### ### ### ###.##";
		((Control)txtThue_TTDB).Name = "txtThue_TTDB";
		AsTextNumeric asTextNumeric16 = txtThue_TTDB;
		size = new Size(100, 20);
		((Control)asTextNumeric16).Size = size;
		((Control)txtThue_TTDB).TabIndex = 17;
		((TextBox)txtThue_TTDB).Text = "0.00";
		((TextBox)txtThue_TTDB).TextAlign = (HorizontalAlignment)1;
		txtThue_TTDB.Value = 0.0;
		txtSo_seri_mhd.CharacterCasing = (CharacterCasing)1;
		TextBox obj36 = txtSo_seri_mhd;
		location = new Point(120, 176);
		((Control)obj36).Location = location;
		((Control)txtSo_seri_mhd).Name = "txtSo_seri_mhd";
		TextBox obj37 = txtSo_seri_mhd;
		size = new Size(100, 20);
		((Control)obj37).Size = size;
		((Control)txtSo_seri_mhd).TabIndex = 6;
		lblSo_seri_mhd.AutoSize = true;
		Label obj38 = lblSo_seri_mhd;
		location = new Point(16, 178);
		((Control)obj38).Location = location;
		((Control)lblSo_seri_mhd).Name = "lblSo_seri_mhd";
		Label obj39 = lblSo_seri_mhd;
		size = new Size(65, 13);
		((Control)obj39).Size = size;
		((Control)lblSo_seri_mhd).TabIndex = 1082;
		lblSo_seri_mhd.Text = "Ký hiệu mẫu";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(817, 492);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmPOTAINEdit";
		((Form)this).Text = "frmSiDMBpEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtSo_ct).MaxLength = 12;
		((TextBoxBase)txtSo_ct0).MaxLength = 12;
		((TextBoxBase)txtSo_seri0).MaxLength = 12;
		((Control)txtNgay_ct).Select();
		txtSo_luong.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format;
		txtGia.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
		txtTien_hang.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtThue_nk.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtThue_TTDB.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtT_tien.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtThue_suat.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtT_Thue.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			txtNgay_ct.Value = DateAndTime.Now.Date;
			txtNgay_ct0.Value = DateAndTime.Now.Date;
		}
	}

	protected override void DataBinding()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtNgay_ct;
		CreateDataBinding(ref ojb, "ngay_ct", "Value");
		txtNgay_ct = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_ct0;
		CreateDataBinding(ref ojb, "ngay_ct0", "Value");
		txtNgay_ct0 = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "so_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)txtSo_ct0;
		CreateDataBinding(ref ojb, "so_ct0");
		txtSo_ct0 = (TextBox)ojb;
		ojb = (Control)(object)txtSo_seri0;
		CreateDataBinding(ref ojb, "so_seri0");
		txtSo_seri0 = (TextBox)ojb;
		ojb = (Control)(object)txtMau_bc;
		CreateDataBinding(ref ojb, "mau_bc");
		txtMau_bc = (TextBox)ojb;
		ojb = (Control)(object)txtMa_kh;
		CreateDataBinding(ref ojb, "ma_kh");
		txtMa_kh = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTen_Kh;
		CreateDataBinding(ref ojb, "ten_kh");
		txtTen_Kh = (TextBox)ojb;
		ojb = (Control)(object)txtMST;
		CreateDataBinding(ref ojb, "ma_so_thue");
		txtMST = (TextBox)ojb;
		ojb = (Control)(object)txtDia_chi;
		CreateDataBinding(ref ojb, "dia_chi");
		txtDia_chi = (TextBox)ojb;
		ojb = (Control)(object)txtMa_vt;
		CreateDataBinding(ref ojb, "ma_vt");
		txtMa_vt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTen_vt;
		CreateDataBinding(ref ojb, "ten_vt");
		txtTen_vt = (TextBox)ojb;
		ojb = (Control)(object)txtSo_luong;
		CreateDataBinding(ref ojb, "so_luong", "Value");
		txtSo_luong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGia;
		CreateDataBinding(ref ojb, "gia", "Value");
		txtGia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_hang;
		CreateDataBinding(ref ojb, "tien_hang", "Value");
		txtTien_hang = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtThue_nk;
		CreateDataBinding(ref ojb, "thue_nk", "Value");
		txtThue_nk = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtThue_TTDB;
		CreateDataBinding(ref ojb, "thue_ttdb", "Value");
		txtThue_TTDB = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtThue_suat;
		CreateDataBinding(ref ojb, "thue_suat", "Value");
		txtThue_suat = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtT_tien;
		CreateDataBinding(ref ojb, "t_tien", "Value");
		txtT_tien = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTK_thue;
		CreateDataBinding(ref ojb, "tk_thue_no");
		txtTK_thue = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTK_du;
		CreateDataBinding(ref ojb, "tk_du");
		txtTK_du = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_bp;
		CreateDataBinding(ref ojb, "ma_bp");
		txtMa_bp = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_spct;
		CreateDataBinding(ref ojb, "ma_spct");
		txtMa_spct = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtGhi_chu;
		CreateDataBinding(ref ojb, "ghi_chu");
		txtGhi_chu = (TextBox)ojb;
		ojb = (Control)(object)txtT_Thue;
		CreateDataBinding(ref ojb, "t_thue", "Value");
		txtT_Thue = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSo_seri_mhd;
		CreateDataBinding(ref ojb, "so_seri_mhd");
		txtSo_seri_mhd = (TextBox)ojb;
	}

	protected override bool ValidData()
	{
		if (Operators.ConditionalCompareObjectLessEqual(txtNgay_ct.Value, (object)AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks, false))
		{
			epNotice.SetError((Control)(object)txtNgay_ct, Helper.GetMess(50136).Description);
			((Control)txtNgay_ct).Select();
			return false;
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(txtNgay_ct.Value, (object)"1/1/1900", false), Operators.CompareObjectEqual(txtNgay_ct0.Value, (object)"1/1/1900", false))))
		{
			epNotice.SetError((Control)(object)txtNgay_ct, Helper.GetMess(50013).Description);
			((Control)txtNgay_ct).Select();
			return false;
		}
		if (Operators.CompareString(txtSo_ct.Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtSo_ct, Helper.GetMess(50002).Description);
			((Control)txtSo_ct).Select();
			return false;
		}
		if (Operators.CompareString(((TextBox)txtTK_thue).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtTK_thue, Helper.GetMess(50099).Description);
			((Control)txtTK_thue).Select();
			return false;
		}
		if (!CanhBaoDieuChinh())
		{
			return false;
		}
		return true;
	}

	protected override bool SetToRow()
	{
		base.SetToRow();
		if (!EditMode)
		{
			RowToEdit["stt_rec"] = Commons.Get_SttRec(base.MyMenuInfo.par1);
			Commons.Get_SttRec0(Conversions.ToString(RowToEdit["stt_rec"]), RowToEdit.Table);
		}
		return true;
	}

	private bool CanhBaoDieuChinh()
	{
		if (Conversions.ToDouble(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh) == 0.0)
		{
			return true;
		}
		int num = checked((int)Math.Round(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_gia_toi_da));
		bool flag = false;
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.MultiplyObject(txtSo_luong.Value, txtGia.Value), txtTien_hang.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
		{
			epNotice.SetError((Control)(object)txtTien_hang, Helper.GetMess(50047).Description);
			flag = true;
		}
		else
		{
			epNotice.SetError((Control)(object)txtTien_hang, "");
		}
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.AddObject(Operators.AddObject(txtTien_hang.Value, txtThue_nk.Value), txtThue_TTDB.Value), txtT_tien.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
		{
			epNotice.SetError((Control)(object)txtT_tien, Helper.GetMess(50047).Description);
			flag = true;
		}
		else
		{
			epNotice.SetError((Control)(object)txtT_tien, "");
		}
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.DivideObject(Operators.MultiplyObject(txtT_tien.Value, txtThue_suat.Value), (object)100), txtT_Thue.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
		{
			epNotice.SetError((Control)(object)txtT_Thue, Helper.GetMess(50047).Description);
			flag = true;
		}
		else
		{
			epNotice.SetError((Control)(object)txtT_Thue, "");
		}
		if (flag)
		{
			return Commons.ProcessAdjustOver();
		}
		return true;
	}

	private void txtMa_kh_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (Operators.CompareString(((TextBox)txtMa_kh).Text.Trim(), "", false) != 0)
		{
			txtTen_Kh.Text = Conversions.ToString(e.ValidatedRow["ten_kh"]);
			txtMST.Text = Conversions.ToString(e.ValidatedRow["ma_so_thue"]);
			txtDia_chi.Text = Conversions.ToString(e.ValidatedRow["dia_chi"]);
		}
	}

	private void txtMa_vt_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (Operators.CompareString(((TextBox)txtMa_vt).Text.Trim(), "", false) != 0)
		{
			txtTen_vt.Text = Conversions.ToString(e.ValidatedRow["ten_vt"]);
		}
	}

	private void txtSo_luong_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectLess(txtSo_luong.Value, (object)0, false))
		{
			epNotice.SetError((Control)(object)txtSo_luong, Helper.GetMess(50017).Description);
			return;
		}
		SetControlError((Control)(object)txtSo_luong, "", additive: false);
		if (Operators.ConditionalCompareObjectLess(txtGia.Value, (object)0, false))
		{
			return;
		}
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[2]
		{
			Operators.MultiplyObject(txtSo_luong.Value, txtGia.Value),
			null
		};
		object[] array2 = array;
		SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
		array2[1] = sIConfiguration.Round;
		object[] array3 = array;
		object[] array4 = array3;
		bool[] array5 = new bool[2] { false, true };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
		if (array5[1])
		{
			sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
		}
		tien_hang = Conversions.ToDouble(obj);
		txtTien_hang.Value = tien_hang;
		if (!Operators.ConditionalCompareObjectLess(txtT_Thue.Value, (object)0, false))
		{
			txtT_tien.Value = Operators.AddObject(Operators.AddObject(txtTien_hang.Value, txtThue_nk.Value), txtThue_TTDB.Value);
			AsTextNumeric asTextNumeric = txtT_Thue;
			Type? typeFromHandle2 = typeof(Math);
			array3 = new object[2]
			{
				Operators.DivideObject(Operators.MultiplyObject(txtT_tien.Value, txtThue_suat.Value), (object)100),
				null
			};
			object[] array6 = array3;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array = array3;
			object[] array7 = array;
			array5 = new bool[2] { false, true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj2);
		}
	}

	private void txtGia_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectLess(txtGia.Value, (object)0, false))
		{
			epNotice.SetError((Control)(object)txtGia, Helper.GetMess(50017).Description);
			return;
		}
		SetControlError((Control)(object)txtGia, "", additive: false);
		if (Operators.ConditionalCompareObjectLess(txtSo_luong.Value, (object)0, false))
		{
			return;
		}
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[2]
		{
			Operators.MultiplyObject(txtSo_luong.Value, txtGia.Value),
			null
		};
		object[] array2 = array;
		SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
		array2[1] = sIConfiguration.Round;
		object[] array3 = array;
		object[] array4 = array3;
		bool[] array5 = new bool[2] { false, true };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
		if (array5[1])
		{
			sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
		}
		tien_hang = Conversions.ToDouble(obj);
		txtTien_hang.Value = tien_hang;
		if (Operators.ConditionalCompareObjectLess(txtT_Thue.Value, (object)0, false))
		{
			return;
		}
		txtT_tien.Value = Operators.AddObject(Operators.AddObject(txtTien_hang.Value, txtThue_nk.Value), txtThue_TTDB.Value);
		if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(txtTien_hang.Value, (object)0, false), Operators.CompareObjectLess(txtThue_suat.Value, (object)0, false))))
		{
			AsTextNumeric asTextNumeric = txtT_Thue;
			Type? typeFromHandle2 = typeof(Math);
			array3 = new object[2]
			{
				Operators.DivideObject(Operators.MultiplyObject(txtT_tien.Value, txtThue_suat.Value), (object)100),
				null
			};
			object[] array6 = array3;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array = array3;
			object[] array7 = array;
			array5 = new bool[2] { false, true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj2);
		}
	}

	private void txtTien_hang_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectLess(txtTien_hang.Value, (object)0, false))
		{
			epNotice.SetError((Control)(object)txtTien_hang, Helper.GetMessContent(50017));
			return;
		}
		SetControlError((Control)(object)txtTien_hang, "", additive: false);
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(txtTien_hang.Value, (object)0, false), Operators.CompareObjectLess(txtT_Thue.Value, (object)0, false))))
		{
			return;
		}
		txtT_tien.Value = Operators.AddObject(Operators.AddObject(txtTien_hang.Value, txtThue_nk.Value), txtThue_TTDB.Value);
		if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(txtThue_nk.Value, (object)0, false), Operators.CompareObjectLess(txtThue_suat.Value, (object)0, false))))
		{
			AsTextNumeric asTextNumeric = txtT_Thue;
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[2]
			{
				Operators.DivideObject(Operators.MultiplyObject(txtT_tien.Value, txtThue_suat.Value), (object)100),
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round;
			object[] array2 = array;
			bool[] array3 = new bool[2] { false, true };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj);
		}
	}

	private void txtThue_nk_Validated(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectLess(txtThue_nk.Value, (object)0, false))
		{
			epNotice.SetError((Control)(object)txtThue_nk, Helper.GetMessContent(50017));
			return;
		}
		SetControlError((Control)(object)txtThue_nk, "", additive: false);
		if (Operators.ConditionalCompareObjectLess(txtT_Thue.Value, (object)0, false))
		{
			CMessageBox.Show(50017);
			return;
		}
		txtT_tien.Value = Operators.AddObject(Operators.AddObject(txtTien_hang.Value, txtThue_nk.Value), txtThue_TTDB.Value);
		if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(txtTien_hang.Value, (object)0, false), Operators.CompareObjectLess(txtThue_suat.Value, (object)0, false))))
		{
			AsTextNumeric asTextNumeric = txtT_Thue;
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[2]
			{
				Operators.DivideObject(Operators.MultiplyObject(txtT_tien.Value, txtThue_suat.Value), (object)100),
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round;
			object[] array2 = array;
			bool[] array3 = new bool[2] { false, true };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj);
		}
	}

	private void txtThue_suat_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectLess(txtThue_suat.Value, (object)0, false))
		{
			epNotice.SetError((Control)(object)txtThue_suat, Helper.GetMessContent(50017));
			return;
		}
		SetControlError((Control)(object)txtThue_suat, "", additive: false);
		if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(txtTien_hang.Value, (object)0, false), Operators.CompareObjectLess(txtThue_nk.Value, (object)0, false))))
		{
			AsTextNumeric asTextNumeric = txtT_Thue;
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[2]
			{
				Operators.DivideObject(Operators.MultiplyObject(txtT_tien.Value, txtThue_suat.Value), (object)100),
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round;
			object[] array2 = array;
			bool[] array3 = new bool[2] { false, true };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj);
		}
	}

	private void txtT_tien_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectLess(txtT_tien.Value, (object)0, false))
		{
			epNotice.SetError((Control)(object)txtT_tien, Helper.GetMessContent(50017));
			return;
		}
		AsTextNumeric asTextNumeric = txtT_Thue;
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[2]
		{
			Operators.DivideObject(Operators.MultiplyObject(txtT_tien.Value, txtThue_suat.Value), (object)100),
			null
		};
		SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
		array[1] = sIConfiguration.Round;
		object[] array2 = array;
		bool[] array3 = new bool[2] { false, true };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
		}
		asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj);
	}

	private void txtThue_TTDB_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectLess(txtT_Thue.Value, (object)0, false))
		{
			return;
		}
		txtT_tien.Value = Operators.AddObject(Operators.AddObject(txtTien_hang.Value, txtThue_nk.Value), txtThue_TTDB.Value);
		if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(txtTien_hang.Value, (object)0, false), Operators.CompareObjectLess(txtThue_suat.Value, (object)0, false))))
		{
			AsTextNumeric asTextNumeric = txtT_Thue;
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[2]
			{
				Operators.DivideObject(Operators.MultiplyObject(txtT_tien.Value, txtThue_suat.Value), (object)100),
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round;
			object[] array2 = array;
			bool[] array3 = new bool[2] { false, true };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj);
		}
	}
}
