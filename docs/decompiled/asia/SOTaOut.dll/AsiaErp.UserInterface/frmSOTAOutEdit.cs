using System;
using System.Collections;
using System.Collections.Generic;
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
public class frmSOTAOutEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

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

	[AccessedThroughProperty("txtSo_seri")]
	private TextBox _txtSo_seri;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtNgay_lap")]
	private AsMaskedTextBox _txtNgay_lap;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("txtMST")]
	private TextBox _txtMST;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtTy_gia")]
	private AsTextNumeric _txtTy_gia;

	[AccessedThroughProperty("txtThue_suat")]
	private AsTextNumeric _txtThue_suat;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("txtTongThue")]
	private AsTextNumeric _txtTongThue;

	[AccessedThroughProperty("lblT_thue")]
	private Label _lblT_thue;

	[AccessedThroughProperty("txtTongThue_Nt")]
	private AsTextNumeric _txtTongThue_Nt;

	[AccessedThroughProperty("lblT_THUE_NT")]
	private Label _lblT_THUE_NT;

	[AccessedThroughProperty("txtTong")]
	private AsTextNumeric _txtTong;

	[AccessedThroughProperty("lblT_tien")]
	private Label _lblT_tien;

	[AccessedThroughProperty("txtTong_NT")]
	private AsTextNumeric _txtTong_NT;

	[AccessedThroughProperty("lblT_Tien_nt")]
	private Label _lblT_Tien_nt;

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

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

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

	[AccessedThroughProperty("txtGhi_chu")]
	private TextBox _txtGhi_chu;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("txtGia")]
	private AsTextNumeric _txtGia;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("txtSo_luong")]
	private AsTextNumeric _txtSo_luong;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("cboNgoai_te")]
	private AsComboBoxNT _cboNgoai_te;

	[AccessedThroughProperty("txtMa_thue")]
	private AsTextBox _txtMa_thue;

	[AccessedThroughProperty("txtTen_vt")]
	private TextBox _txtTen_vt;

	[AccessedThroughProperty("txtSo_seri_mhd")]
	private TextBox _txtSo_seri_mhd;

	[AccessedThroughProperty("lblSo_seri_mhd")]
	private Label _lblSo_seri_mhd;

	private double _tongTienNt;

	internal virtual TextBox txtSo_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ct = value;
		}
	}

	internal virtual Label lblMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Bp = value;
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

	internal virtual Label label0
	{
		[DebuggerNonUserCode]
		get
		{
			return _label0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_label0 = value;
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

	protected virtual AsMaskedTextBox txtNgay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNgay_ct_Validated;
			if (_txtNgay_ct != null)
			{
				((Control)_txtNgay_ct).Validated -= eventHandler;
			}
			_txtNgay_ct = value;
			if (_txtNgay_ct != null)
			{
				((Control)_txtNgay_ct).Validated += eventHandler;
			}
		}
	}

	private virtual AsTextBox txtMa_kh
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
		[DebuggerNonUserCode]
		get
		{
			return _lblTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk = value;
		}
	}

	internal virtual TextBox txtSo_seri
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_seri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_seri = value;
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

	protected virtual AsMaskedTextBox txtNgay_lap
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_lap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNgay_lap_Validated;
			if (_txtNgay_lap != null)
			{
				((Control)_txtNgay_lap).Validated -= eventHandler;
			}
			_txtNgay_lap = value;
			if (_txtNgay_lap != null)
			{
				((Control)_txtNgay_lap).Validated += eventHandler;
			}
		}
	}

	private virtual Label Label5
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

	private virtual AsTextBox txtMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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

	internal virtual TextBox txtMST
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMST;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMST = value;
		}
	}

	private virtual Label Label4
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

	internal virtual AsTextNumeric txtTy_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTy_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = txtTy_gia_ValueChanged;
			if (_txtTy_gia != null)
			{
				_txtTy_gia.ValueChanged -= obj;
			}
			_txtTy_gia = value;
			if (_txtTy_gia != null)
			{
				_txtTy_gia.ValueChanged += obj;
			}
		}
	}

	internal virtual AsTextNumeric txtThue_suat
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtThue_suat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = txtThue_suat_TextChanged;
			EventHandler obj2 = txtThue_suat_ValueChanged;
			if (_txtThue_suat != null)
			{
				_txtThue_suat.ValueChanged -= obj;
				_txtThue_suat.ValueChanged -= obj2;
			}
			_txtThue_suat = value;
			if (_txtThue_suat != null)
			{
				_txtThue_suat.ValueChanged += obj;
				_txtThue_suat.ValueChanged += obj2;
			}
		}
	}

	private virtual Label Label7
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

	internal virtual AsTextNumeric txtTongThue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTongThue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTongThue = value;
		}
	}

	private virtual Label lblT_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_thue = value;
		}
	}

	internal virtual AsTextNumeric txtTongThue_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTongThue_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTongThue_Nt = value;
		}
	}

	private virtual Label lblT_THUE_NT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_THUE_NT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_THUE_NT = value;
		}
	}

	internal virtual AsTextNumeric txtTong
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = txtTong_ValueChanged;
			if (_txtTong != null)
			{
				_txtTong.ValueChanged -= obj;
			}
			_txtTong = value;
			if (_txtTong != null)
			{
				_txtTong.ValueChanged += obj;
			}
		}
	}

	private virtual Label lblT_tien
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_tien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_tien = value;
		}
	}

	internal virtual AsTextNumeric txtTong_NT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTong_NT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = txtTong_NT_ValueChanged;
			if (_txtTong_NT != null)
			{
				_txtTong_NT.ValueChanged -= obj;
			}
			_txtTong_NT = value;
			if (_txtTong_NT != null)
			{
				_txtTong_NT.ValueChanged += obj;
			}
		}
	}

	private virtual Label lblT_Tien_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_Tien_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_Tien_nt = value;
		}
	}

	private virtual AsTextBox txtTK_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_thue = value;
		}
	}

	private virtual Label lblTen_Tkthue
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tkthue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tkthue = value;
		}
	}

	private virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	private virtual AsTextBox txtMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_spct = value;
		}
	}

	private virtual Label lblTen_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_spct = value;
		}
	}

	private virtual Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label21 = value;
		}
	}

	private virtual AsTextBox txtMa_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_hd = value;
		}
	}

	private virtual Label lblTen_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_hd = value;
		}
	}

	private virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	private virtual AsTextBox txtMa_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_bp = value;
		}
	}

	private virtual Label lblTen_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_bp = value;
		}
	}

	private virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
		}
	}

	private virtual AsTextBox txtTK_du
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_du = value;
		}
	}

	private virtual Label lblTen_tkdu
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tkdu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tkdu = value;
		}
	}

	private virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
		}
	}

	internal virtual TextBox txtTen_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Kh = value;
		}
	}

	internal virtual Label Label22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label22 = value;
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

	internal virtual Label Label24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label24 = value;
		}
	}

	private virtual Label Label12
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

	internal virtual AsTextNumeric txtGia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = txtGia_ValueChanged;
			if (_txtGia != null)
			{
				_txtGia.ValueChanged -= obj;
			}
			_txtGia = value;
			if (_txtGia != null)
			{
				_txtGia.ValueChanged += obj;
			}
		}
	}

	private virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual AsTextNumeric txtSo_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = txtSo_luong_ValueChanged;
			if (_txtSo_luong != null)
			{
				_txtSo_luong.ValueChanged -= obj;
			}
			_txtSo_luong = value;
			if (_txtSo_luong != null)
			{
				_txtSo_luong.ValueChanged += obj;
			}
		}
	}

	private virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
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

	internal virtual AsComboBoxNT cboNgoai_te
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNgoai_te;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboNgoai_te_SelectedIndexChanged;
			if (_cboNgoai_te != null)
			{
				((ComboBox)_cboNgoai_te).SelectedIndexChanged -= eventHandler;
			}
			_cboNgoai_te = value;
			if (_cboNgoai_te != null)
			{
				((ComboBox)_cboNgoai_te).SelectedIndexChanged += eventHandler;
			}
		}
	}

	private virtual AsTextBox txtMa_thue
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
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_thue_AfterCodeValidating;
			if (_txtMa_thue != null)
			{
				_txtMa_thue.AfterCodeValidating -= obj;
			}
			_txtMa_thue = value;
			if (_txtMa_thue != null)
			{
				_txtMa_thue.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual TextBox txtTen_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_vt = value;
		}
	}

	internal virtual TextBox txtSo_seri_mhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_seri_mhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_seri_mhd = value;
		}
	}

	internal virtual Label lblSo_seri_mhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_seri_mhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_seri_mhd = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSOTAOutEdit()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		txtSo_ct = new TextBox();
		lblMa_Bp = new Label();
		txtDia_chi = new TextBox();
		label0 = new Label();
		txtNgay_ct = new AsMaskedTextBox();
		Label1 = new Label();
		Label2 = new Label();
		txtNgay_lap = new AsMaskedTextBox();
		txtSo_seri = new TextBox();
		Label3 = new Label();
		txtMa_kh = new AsTextBox();
		lblTk = new Label();
		Label5 = new Label();
		txtMST = new TextBox();
		txtMa_vt = new AsTextBox();
		Label6 = new Label();
		Label4 = new Label();
		txtTy_gia = new AsTextNumeric();
		Label7 = new Label();
		txtThue_suat = new AsTextNumeric();
		txtTong_NT = new AsTextNumeric();
		lblT_Tien_nt = new Label();
		txtTong = new AsTextNumeric();
		lblT_tien = new Label();
		txtTongThue = new AsTextNumeric();
		lblT_thue = new Label();
		txtTongThue_Nt = new AsTextNumeric();
		lblT_THUE_NT = new Label();
		txtTK_thue = new AsTextBox();
		lblTen_Tkthue = new Label();
		Label13 = new Label();
		txtTK_du = new AsTextBox();
		lblTen_tkdu = new Label();
		Label15 = new Label();
		txtMa_hd = new AsTextBox();
		lblTen_hd = new Label();
		Label17 = new Label();
		txtMa_bp = new AsTextBox();
		lblTen_bp = new Label();
		Label19 = new Label();
		txtMa_spct = new AsTextBox();
		lblTen_spct = new Label();
		Label21 = new Label();
		txtTen_Kh = new TextBox();
		Label22 = new Label();
		txtGhi_chu = new TextBox();
		Label24 = new Label();
		Label12 = new Label();
		txtGia = new AsTextNumeric();
		Label14 = new Label();
		txtSo_luong = new AsTextNumeric();
		Label16 = new Label();
		GroupBox1 = new GroupBox();
		cboNgoai_te = new AsComboBoxNT();
		txtMa_thue = new AsTextBox();
		txtTen_vt = new TextBox();
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
		location = new Point(92, 456);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 456);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtSo_seri_mhd);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_seri_mhd);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_vt);
		((Control)gbLine).Controls.Add((Control)(object)GroupBox1);
		((Control)gbLine).Controls.Add((Control)(object)Label24);
		((Control)gbLine).Controls.Add((Control)(object)txtGhi_chu);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_spct);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Kh);
		((Control)gbLine).Controls.Add((Control)(object)Label22);
		((Control)gbLine).Controls.Add((Control)(object)cboNgoai_te);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_thue);
		((Control)gbLine).Controls.Add((Control)(object)Label14);
		((Control)gbLine).Controls.Add((Control)(object)txtGia);
		((Control)gbLine).Controls.Add((Control)(object)Label16);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_thue);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_luong);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_spct);
		((Control)gbLine).Controls.Add((Control)(object)Label21);
		((Control)gbLine).Controls.Add((Control)(object)Label12);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_hd);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_hd);
		((Control)gbLine).Controls.Add((Control)(object)Label17);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_bp);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_bp);
		((Control)gbLine).Controls.Add((Control)(object)txtTong_NT);
		((Control)gbLine).Controls.Add((Control)(object)Label19);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_du);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tkdu);
		((Control)gbLine).Controls.Add((Control)(object)Label15);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tkthue);
		((Control)gbLine).Controls.Add((Control)(object)Label13);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Bp);
		((Control)gbLine).Controls.Add((Control)(object)txtMST);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_kh);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)lblT_thue);
		((Control)gbLine).Controls.Add((Control)(object)txtTongThue_Nt);
		((Control)gbLine).Controls.Add((Control)(object)lblT_THUE_NT);
		((Control)gbLine).Controls.Add((Control)(object)txtTongThue);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_seri);
		((Control)gbLine).Controls.Add((Control)(object)lblT_Tien_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtTong);
		((Control)gbLine).Controls.Add((Control)(object)lblT_tien);
		((Control)gbLine).Controls.Add((Control)(object)txtThue_suat);
		((Control)gbLine).Controls.Add((Control)(object)lblTk);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)txtTy_gia);
		((Control)gbLine).Controls.Add((Control)(object)txtDia_chi);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_lap);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)label0);
		GroupBox obj3 = gbLine;
		Size size = new Size(788, 443);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)label0, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_lap, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDia_chi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTy_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtThue_suat, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblT_tien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblT_Tien_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_seri, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTongThue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblT_THUE_NT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTongThue_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblT_thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMST, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label13, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tkthue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label15, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tkdu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_du, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label19, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTong_NT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label17, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label12, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label21, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_luong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label16, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label14, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboNgoai_te, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label22, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGhi_chu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label24, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)GroupBox1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_seri_mhd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_seri_mhd, 0);
		TextBox obj4 = txtSo_ct;
		location = new Point(97, 38);
		((Control)obj4).Location = location;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj5 = txtSo_ct;
		size = new Size(100, 20);
		((Control)obj5).Size = size;
		((Control)txtSo_ct).TabIndex = 1;
		lblMa_Bp.AutoSize = true;
		Label obj6 = lblMa_Bp;
		location = new Point(14, 41);
		((Control)obj6).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj7 = lblMa_Bp;
		size = new Size(37, 13);
		((Control)obj7).Size = size;
		((Control)lblMa_Bp).TabIndex = 2;
		lblMa_Bp.Text = "Số CT";
		TextBox obj8 = txtDia_chi;
		location = new Point(97, 220);
		((Control)obj8).Location = location;
		((TextBoxBase)txtDia_chi).MaxLength = 128;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj9 = txtDia_chi;
		size = new Size(427, 20);
		((Control)obj9).Size = size;
		((Control)txtDia_chi).TabIndex = 8;
		label0.AutoSize = true;
		Label obj10 = label0;
		location = new Point(14, 223);
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
		location = new Point(97, 12);
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
		location = new Point(14, 15);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(49, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 8;
		Label1.Text = "Ngày CT";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(14, 67);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(66, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 10;
		Label2.Text = "Ngày lập CT";
		txtNgay_lap.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_lap).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_lap;
		location = new Point(97, 64);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_lap).Mask = "##/##/####";
		((Control)txtNgay_lap).Name = "txtNgay_lap";
		((MaskedTextBox)txtNgay_lap).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_lap;
		size = new Size(100, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_lap).TabIndex = 2;
		((MaskedTextBox)txtNgay_lap).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_lap;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		TextBox obj12 = txtSo_seri;
		location = new Point(97, 116);
		((Control)obj12).Location = location;
		((Control)txtSo_seri).Name = "txtSo_seri";
		TextBox obj13 = txtSo_seri;
		size = new Size(100, 20);
		((Control)obj13).Size = size;
		((Control)txtSo_seri).TabIndex = 5;
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(14, 118);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(41, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 12;
		Label3.Text = "Số Sêri";
		((TextBox)txtMa_kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = true;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_kh;
		location = new Point(97, 168);
		((Control)asTextBox).Location = location;
		txtMa_kh.LookupCodeName = "MA_KH";
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = null;
		AsTextBox asTextBox2 = txtMa_kh;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_kh).TabIndex = 6;
		((Control)txtMa_kh).Tag = "@pMA_KH";
		txtMa_kh.UseAutoCompleteSource = true;
		txtMa_kh.ValidReturnFieldList = "ten_kh,ma_so_thue,dia_chi";
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj14 = lblTk;
		location = new Point(14, 171);
		((Control)obj14).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj15 = lblTk;
		size = new Size(40, 13);
		((Control)obj15).Size = size;
		((Control)lblTk).TabIndex = 1019;
		lblTk.Text = "Mã KH";
		Label5.AutoSize = true;
		Label5.ImeMode = (ImeMode)0;
		Label label7 = Label5;
		location = new Point(14, 249);
		((Control)label7).Location = location;
		((Control)Label5).Name = "Label5";
		Label label8 = Label5;
		size = new Size(60, 13);
		((Control)label8).Size = size;
		((Control)Label5).TabIndex = 1022;
		Label5.Text = "Mã số thuế";
		TextBox obj16 = txtMST;
		location = new Point(97, 246);
		((Control)obj16).Location = location;
		((Control)txtMST).Name = "txtMST";
		TextBox obj17 = txtMST;
		size = new Size(177, 20);
		((Control)obj17).Size = size;
		((Control)txtMST).TabIndex = 9;
		((TextBox)txtMa_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = true;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_vt;
		location = new Point(397, 12);
		((Control)asTextBox3).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = null;
		AsTextBox asTextBox4 = txtMa_vt;
		size = new Size(57, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_vt).TabIndex = 11;
		((Control)txtMa_vt).Tag = "@pMA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		txtMa_vt.ValidReturnFieldList = "ten_vt";
		Label6.AutoSize = true;
		Label6.ImeMode = (ImeMode)0;
		Label label9 = Label6;
		location = new Point(311, 15);
		((Control)label9).Location = location;
		((Control)Label6).Name = "Label6";
		Label label10 = Label6;
		size = new Size(39, 13);
		((Control)label10).Size = size;
		((Control)Label6).TabIndex = 1026;
		Label6.Text = "Mã VT";
		Label4.AutoSize = true;
		Label4.ImeMode = (ImeMode)0;
		Label label11 = Label4;
		location = new Point(311, 93);
		((Control)label11).Location = location;
		((Control)Label4).Name = "Label4";
		Label label12 = Label4;
		size = new Size(47, 13);
		((Control)label12).Size = size;
		((Control)Label4).TabIndex = 1029;
		Label4.Text = "Ngoại tệ";
		((TextBoxBase)txtTy_gia).BackColor = Color.White;
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(460, 90);
		((Control)asTextNumeric).Location = location;
		txtTy_gia.Mask = "### ### ### ###.##";
		((Control)txtTy_gia).Name = "txtTy_gia";
		AsTextNumeric asTextNumeric2 = txtTy_gia;
		size = new Size(64, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTy_gia).TabIndex = 16;
		((TextBox)txtTy_gia).Text = "0.00";
		((TextBox)txtTy_gia).TextAlign = (HorizontalAlignment)1;
		txtTy_gia.Value = 0.0;
		Label7.AutoSize = true;
		Label7.ImeMode = (ImeMode)0;
		Label label13 = Label7;
		location = new Point(311, 146);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(46, 13);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 1034;
		Label7.Text = "Mã thuế";
		txtThue_suat.DecimalSymbol = ".";
		((Control)txtThue_suat).Enabled = false;
		AsTextNumeric asTextNumeric3 = txtThue_suat;
		location = new Point(467, 142);
		((Control)asTextNumeric3).Location = location;
		txtThue_suat.Mask = "### ### ### ###.##";
		((Control)txtThue_suat).Name = "txtThue_suat";
		AsTextNumeric asTextNumeric4 = txtThue_suat;
		size = new Size(33, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtThue_suat).TabIndex = 20;
		((TextBox)txtThue_suat).Text = "0.00";
		((TextBox)txtThue_suat).TextAlign = (HorizontalAlignment)1;
		txtThue_suat.Value = 0.0;
		((TextBoxBase)txtTong_NT).BackColor = Color.White;
		txtTong_NT.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric5 = txtTong_NT;
		location = new Point(397, 116);
		((Control)asTextNumeric5).Location = location;
		txtTong_NT.Mask = "### ### ### ###.##";
		((Control)txtTong_NT).Name = "txtTong_NT";
		AsTextNumeric asTextNumeric6 = txtTong_NT;
		size = new Size(127, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtTong_NT).TabIndex = 17;
		((TextBox)txtTong_NT).Text = "0.00";
		((TextBox)txtTong_NT).TextAlign = (HorizontalAlignment)1;
		txtTong_NT.Value = 0.0;
		lblT_Tien_nt.AutoSize = true;
		lblT_Tien_nt.ImeMode = (ImeMode)0;
		Label obj18 = lblT_Tien_nt;
		location = new Point(311, 120);
		((Control)obj18).Location = location;
		((Control)lblT_Tien_nt).Name = "lblT_Tien_nt";
		Label obj19 = lblT_Tien_nt;
		size = new Size(70, 13);
		((Control)obj19).Size = size;
		((Control)lblT_Tien_nt).TabIndex = 1036;
		lblT_Tien_nt.Text = "Tổng tiền NT";
		txtTong.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric7 = txtTong;
		location = new Point(644, 116);
		((Control)asTextNumeric7).Location = location;
		txtTong.Mask = "### ### ### ###";
		((Control)txtTong).Name = "txtTong";
		AsTextNumeric asTextNumeric8 = txtTong;
		size = new Size(127, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtTong).TabIndex = 18;
		((TextBox)txtTong).Text = "0";
		((TextBox)txtTong).TextAlign = (HorizontalAlignment)1;
		txtTong.Value = 0.0;
		lblT_tien.AutoSize = true;
		lblT_tien.ImeMode = (ImeMode)0;
		Label obj20 = lblT_tien;
		location = new Point(571, 120);
		((Control)obj20).Location = location;
		((Control)lblT_tien).Name = "lblT_tien";
		Label obj21 = lblT_tien;
		size = new Size(52, 13);
		((Control)obj21).Size = size;
		((Control)lblT_tien).TabIndex = 1038;
		lblT_tien.Text = "Tổng tiền";
		txtTongThue.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric9 = txtTongThue;
		location = new Point(644, 169);
		((Control)asTextNumeric9).Location = location;
		txtTongThue.Mask = "### ### ### ###";
		((Control)txtTongThue).Name = "txtTongThue";
		AsTextNumeric asTextNumeric10 = txtTongThue;
		size = new Size(127, 20);
		((Control)asTextNumeric10).Size = size;
		((Control)txtTongThue).TabIndex = 23;
		((TextBox)txtTongThue).Text = "0";
		((TextBox)txtTongThue).TextAlign = (HorizontalAlignment)1;
		txtTongThue.Value = 0.0;
		lblT_thue.AutoSize = true;
		lblT_thue.ImeMode = (ImeMode)0;
		Label obj22 = lblT_thue;
		location = new Point(571, 172);
		((Control)obj22).Location = location;
		((Control)lblT_thue).Name = "lblT_thue";
		Label obj23 = lblT_thue;
		size = new Size(56, 13);
		((Control)obj23).Size = size;
		((Control)lblT_thue).TabIndex = 1042;
		lblT_thue.Text = "Tổng thuế";
		((TextBoxBase)txtTongThue_Nt).BackColor = Color.White;
		txtTongThue_Nt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric11 = txtTongThue_Nt;
		location = new Point(397, 168);
		((Control)asTextNumeric11).Location = location;
		txtTongThue_Nt.Mask = "### ### ### ###.##";
		((Control)txtTongThue_Nt).Name = "txtTongThue_Nt";
		AsTextNumeric asTextNumeric12 = txtTongThue_Nt;
		size = new Size(127, 20);
		((Control)asTextNumeric12).Size = size;
		((Control)txtTongThue_Nt).TabIndex = 22;
		((TextBox)txtTongThue_Nt).Text = "0.00";
		((TextBox)txtTongThue_Nt).TextAlign = (HorizontalAlignment)1;
		txtTongThue_Nt.Value = 0.0;
		lblT_THUE_NT.AutoSize = true;
		lblT_THUE_NT.ImeMode = (ImeMode)0;
		Label obj24 = lblT_THUE_NT;
		location = new Point(311, 171);
		((Control)obj24).Location = location;
		((Control)lblT_THUE_NT).Name = "lblT_THUE_NT";
		Label obj25 = lblT_THUE_NT;
		size = new Size(74, 13);
		((Control)obj25).Size = size;
		((Control)lblT_THUE_NT).TabIndex = 1040;
		lblT_THUE_NT.Text = "Tổng thuế NT";
		((TextBox)txtTK_thue).AutoCompleteSource = (AutoCompleteSource)64;
		txtTK_thue.AutoLookup = true;
		txtTK_thue.AutoValid = true;
		((TextBoxBase)txtTK_thue).BackColor = SystemColors.Info;
		((TextBox)txtTK_thue).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTK_thue;
		location = new Point(97, 313);
		((Control)asTextBox5).Location = location;
		txtTK_thue.LookupCodeName = "TK";
		txtTK_thue.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTK_thue).Name = "txtTK_thue";
		txtTK_thue.NameControl = lblTen_Tkthue;
		AsTextBox asTextBox6 = txtTK_thue;
		size = new Size(100, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTK_thue).TabIndex = 24;
		((Control)txtTK_thue).Tag = "@pTK";
		txtTK_thue.UseAutoCompleteSource = true;
		lblTen_Tkthue.ImeMode = (ImeMode)0;
		Label obj26 = lblTen_Tkthue;
		location = new Point(203, 316);
		((Control)obj26).Location = location;
		((Control)lblTen_Tkthue).Name = "lblTen_Tkthue";
		Label obj27 = lblTen_Tkthue;
		size = new Size(472, 13);
		((Control)obj27).Size = size;
		((Control)lblTen_Tkthue).TabIndex = 1047;
		lblTen_Tkthue.TextAlign = (ContentAlignment)16;
		Label13.AutoSize = true;
		Label13.ImeMode = (ImeMode)0;
		Label label15 = Label13;
		location = new Point(14, 316);
		((Control)label15).Location = location;
		((Control)Label13).Name = "Label13";
		Label label16 = Label13;
		size = new Size(45, 13);
		((Control)label16).Size = size;
		((Control)Label13).TabIndex = 1046;
		Label13.Text = "TK thuế";
		((TextBox)txtTK_du).AutoCompleteSource = (AutoCompleteSource)64;
		txtTK_du.AutoLookup = true;
		txtTK_du.AutoValid = true;
		((TextBoxBase)txtTK_du).BackColor = SystemColors.Info;
		((TextBox)txtTK_du).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtTK_du;
		location = new Point(97, 339);
		((Control)asTextBox7).Location = location;
		txtTK_du.LookupCodeName = "TK";
		txtTK_du.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTK_du).Name = "txtTK_du";
		txtTK_du.NameControl = lblTen_tkdu;
		AsTextBox asTextBox8 = txtTK_du;
		size = new Size(100, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtTK_du).TabIndex = 25;
		((Control)txtTK_du).Tag = "@pTK";
		txtTK_du.UseAutoCompleteSource = true;
		lblTen_tkdu.ImeMode = (ImeMode)0;
		Label obj28 = lblTen_tkdu;
		location = new Point(203, 342);
		((Control)obj28).Location = location;
		((Control)lblTen_tkdu).Name = "lblTen_tkdu";
		Label obj29 = lblTen_tkdu;
		size = new Size(472, 13);
		((Control)obj29).Size = size;
		((Control)lblTen_tkdu).TabIndex = 1050;
		lblTen_tkdu.TextAlign = (ContentAlignment)16;
		Label15.AutoSize = true;
		Label15.ImeMode = (ImeMode)0;
		Label label17 = Label15;
		location = new Point(14, 342);
		((Control)label17).Location = location;
		((Control)Label15).Name = "Label15";
		Label label18 = Label15;
		size = new Size(60, 13);
		((Control)label18).Size = size;
		((Control)Label15).TabIndex = 1049;
		Label15.Text = "TK đối ứng";
		((TextBox)txtMa_hd).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = true;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_hd;
		location = new Point(97, 391);
		((Control)asTextBox9).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox10 = txtMa_hd;
		size = new Size(100, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_hd).TabIndex = 27;
		((Control)txtMa_hd).Tag = "@pMA_HD";
		txtMa_hd.UseAutoCompleteSource = true;
		lblTen_hd.ImeMode = (ImeMode)0;
		Label obj30 = lblTen_hd;
		location = new Point(203, 394);
		((Control)obj30).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj31 = lblTen_hd;
		size = new Size(472, 13);
		((Control)obj31).Size = size;
		((Control)lblTen_hd).TabIndex = 1056;
		lblTen_hd.TextAlign = (ContentAlignment)16;
		Label17.AutoSize = true;
		Label17.ImeMode = (ImeMode)0;
		Label label19 = Label17;
		location = new Point(14, 394);
		((Control)label19).Location = location;
		((Control)Label17).Name = "Label17";
		Label label20 = Label17;
		size = new Size(41, 13);
		((Control)label20).Size = size;
		((Control)Label17).TabIndex = 1055;
		Label17.Text = "Mã HĐ";
		((TextBox)txtMa_bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = true;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtMa_bp;
		location = new Point(97, 365);
		((Control)asTextBox11).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox12 = txtMa_bp;
		size = new Size(100, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtMa_bp).TabIndex = 26;
		((Control)txtMa_bp).Tag = "@pMA_BP";
		txtMa_bp.UseAutoCompleteSource = true;
		lblTen_bp.ImeMode = (ImeMode)0;
		Label obj32 = lblTen_bp;
		location = new Point(203, 368);
		((Control)obj32).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj33 = lblTen_bp;
		size = new Size(472, 13);
		((Control)obj33).Size = size;
		((Control)lblTen_bp).TabIndex = 1053;
		lblTen_bp.TextAlign = (ContentAlignment)16;
		Label19.AutoSize = true;
		Label19.ImeMode = (ImeMode)0;
		Label label21 = Label19;
		location = new Point(14, 368);
		((Control)label21).Location = location;
		((Control)Label19).Name = "Label19";
		Label label22 = Label19;
		size = new Size(39, 13);
		((Control)label22).Size = size;
		((Control)Label19).TabIndex = 1052;
		Label19.Text = "Mã BP";
		((TextBox)txtMa_spct).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = true;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox13 = txtMa_spct;
		location = new Point(97, 417);
		((Control)asTextBox13).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox14 = txtMa_spct;
		size = new Size(100, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtMa_spct).TabIndex = 28;
		((Control)txtMa_spct).Tag = "@pMA_SPCT";
		txtMa_spct.UseAutoCompleteSource = true;
		lblTen_spct.ImeMode = (ImeMode)0;
		Label obj34 = lblTen_spct;
		location = new Point(203, 420);
		((Control)obj34).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj35 = lblTen_spct;
		size = new Size(472, 13);
		((Control)obj35).Size = size;
		((Control)lblTen_spct).TabIndex = 1059;
		lblTen_spct.TextAlign = (ContentAlignment)16;
		Label21.AutoSize = true;
		Label21.ImeMode = (ImeMode)0;
		Label label23 = Label21;
		location = new Point(14, 420);
		((Control)label23).Location = location;
		((Control)Label21).Name = "Label21";
		Label label24 = Label21;
		size = new Size(53, 13);
		((Control)label24).Size = size;
		((Control)Label21).TabIndex = 1058;
		Label21.Text = "Mã SPCT";
		TextBox obj36 = txtTen_Kh;
		location = new Point(97, 194);
		((Control)obj36).Location = location;
		((Control)txtTen_Kh).Name = "txtTen_Kh";
		TextBox obj37 = txtTen_Kh;
		size = new Size(427, 20);
		((Control)obj37).Size = size;
		((Control)txtTen_Kh).TabIndex = 7;
		Label22.AutoSize = true;
		Label label25 = Label22;
		location = new Point(14, 197);
		((Control)label25).Location = location;
		((Control)Label22).Name = "Label22";
		Label label26 = Label22;
		size = new Size(44, 13);
		((Control)label26).Size = size;
		((Control)Label22).TabIndex = 1061;
		Label22.Text = "Tên KH";
		TextBox obj38 = txtGhi_chu;
		location = new Point(97, 272);
		((Control)obj38).Location = location;
		((Control)txtGhi_chu).Name = "txtGhi_chu";
		TextBox obj39 = txtGhi_chu;
		size = new Size(674, 20);
		((Control)obj39).Size = size;
		((Control)txtGhi_chu).TabIndex = 10;
		Label24.AutoSize = true;
		Label label27 = Label24;
		location = new Point(14, 274);
		((Control)label27).Location = location;
		((Control)Label24).Name = "Label24";
		Label label28 = Label24;
		size = new Size(44, 13);
		((Control)label28).Size = size;
		((Control)Label24).TabIndex = 1065;
		Label24.Text = "Ghi chú";
		Label12.AutoSize = true;
		Label12.ImeMode = (ImeMode)0;
		Label label29 = Label12;
		location = new Point(506, 144);
		((Control)label29).Location = location;
		((Control)Label12).Name = "Label12";
		Label label30 = Label12;
		size = new Size(21, 13);
		((Control)label30).Size = size;
		((Control)Label12).TabIndex = 21;
		Label12.Text = "(%)";
		txtGia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric13 = txtGia;
		location = new Point(397, 64);
		((Control)asTextNumeric13).Location = location;
		txtGia.Mask = "### ### ### ###";
		((Control)txtGia).Name = "txtGia";
		AsTextNumeric asTextNumeric14 = txtGia;
		size = new Size(127, 20);
		((Control)asTextNumeric14).Size = size;
		((Control)txtGia).TabIndex = 14;
		((TextBox)txtGia).Text = "0";
		((TextBox)txtGia).TextAlign = (HorizontalAlignment)1;
		txtGia.Value = 0.0;
		Label14.AutoSize = true;
		Label14.ImeMode = (ImeMode)0;
		Label label31 = Label14;
		location = new Point(311, 67);
		((Control)label31).Location = location;
		((Control)Label14).Name = "Label14";
		Label label32 = Label14;
		size = new Size(44, 13);
		((Control)label32).Size = size;
		((Control)Label14).TabIndex = 1070;
		Label14.Text = "Đơn giá";
		((TextBoxBase)txtSo_luong).BackColor = SystemColors.Window;
		txtSo_luong.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric15 = txtSo_luong;
		location = new Point(397, 38);
		((Control)asTextNumeric15).Location = location;
		txtSo_luong.Mask = "### ### ### ###.##";
		((Control)txtSo_luong).Name = "txtSo_luong";
		AsTextNumeric asTextNumeric16 = txtSo_luong;
		size = new Size(57, 20);
		((Control)asTextNumeric16).Size = size;
		((Control)txtSo_luong).TabIndex = 13;
		((TextBox)txtSo_luong).Text = "0.00";
		((TextBox)txtSo_luong).TextAlign = (HorizontalAlignment)1;
		txtSo_luong.Value = 0.0;
		Label16.AutoSize = true;
		Label16.ImeMode = (ImeMode)0;
		Label label33 = Label16;
		location = new Point(311, 41);
		((Control)label33).Location = location;
		((Control)Label16).Name = "Label16";
		Label label34 = Label16;
		size = new Size(49, 13);
		((Control)label34).Size = size;
		((Control)Label16).TabIndex = 1069;
		Label16.Text = "Số lượng";
		GroupBox groupBox = GroupBox1;
		location = new Point(17, 298);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(751, 5);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 1072;
		GroupBox1.TabStop = false;
		((ComboBox)cboNgoai_te).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNgoai_te).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboNgoai_te;
		location = new Point(397, 90);
		((Control)asComboBoxNT).Location = location;
		cboNgoai_te.MA_NT = "";
		((Control)cboNgoai_te).Name = "cboNgoai_te";
		AsComboBoxNT asComboBoxNT2 = cboNgoai_te;
		size = new Size(57, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboNgoai_te).TabIndex = 15;
		((TextBox)txtMa_thue).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_thue.AutoLookup = true;
		txtMa_thue.AutoValid = true;
		((TextBoxBase)txtMa_thue).BackColor = SystemColors.Info;
		((TextBox)txtMa_thue).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox15 = txtMa_thue;
		location = new Point(397, 142);
		((Control)asTextBox15).Location = location;
		txtMa_thue.LookupCodeName = "MA_THUE";
		((Control)txtMa_thue).Name = "txtMa_thue";
		txtMa_thue.NameControl = null;
		AsTextBox asTextBox16 = txtMa_thue;
		size = new Size(64, 20);
		((Control)asTextBox16).Size = size;
		((Control)txtMa_thue).TabIndex = 19;
		((Control)txtMa_thue).Tag = "";
		txtMa_thue.UseAutoCompleteSource = true;
		txtMa_thue.ValidReturnFieldList = "ts_gtgt";
		TextBox obj40 = txtTen_vt;
		location = new Point(460, 12);
		((Control)obj40).Location = location;
		((Control)txtTen_vt).Name = "txtTen_vt";
		TextBox obj41 = txtTen_vt;
		size = new Size(311, 20);
		((Control)obj41).Size = size;
		((Control)txtTen_vt).TabIndex = 12;
		txtSo_seri_mhd.CharacterCasing = (CharacterCasing)1;
		TextBox obj42 = txtSo_seri_mhd;
		location = new Point(97, 90);
		((Control)obj42).Location = location;
		((Control)txtSo_seri_mhd).Name = "txtSo_seri_mhd";
		TextBox obj43 = txtSo_seri_mhd;
		size = new Size(100, 20);
		((Control)obj43).Size = size;
		((Control)txtSo_seri_mhd).TabIndex = 4;
		lblSo_seri_mhd.AutoSize = true;
		Label obj44 = lblSo_seri_mhd;
		location = new Point(14, 91);
		((Control)obj44).Location = location;
		((Control)lblSo_seri_mhd).Name = "lblSo_seri_mhd";
		Label obj45 = lblSo_seri_mhd;
		size = new Size(65, 13);
		((Control)obj45).Size = size;
		((Control)lblSo_seri_mhd).TabIndex = 1075;
		lblSo_seri_mhd.Text = "Ký hiệu mẫu";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(810, 486);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSOTAOutEdit";
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
		ArrayList arrayList = new ArrayList();
		foreach (DMNTInformation item in AsiaErp.Framework.Environment.GetDMNT())
		{
			if (!item.ksd)
			{
				arrayList.Add(item);
			}
		}
		((ComboBox)cboNgoai_te).DataSource = arrayList;
		((ListControl)cboNgoai_te).DisplayMember = "ma_nt";
		((ListControl)cboNgoai_te).ValueMember = "ma_nt";
		((TextBoxBase)txtSo_ct).MaxLength = 12;
		((TextBoxBase)txtSo_seri).MaxLength = 12;
		((Control)txtNgay_ct).Select();
		txtSo_luong.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format;
		txtGia.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
		txtThue_suat.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtTong_NT.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		txtTongThue_Nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		txtTong.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtTongThue.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			txtNgay_ct.Value = DateAndTime.Now.Date;
			txtNgay_lap.Value = DateAndTime.Now.Date;
			string ma_nt = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
			if (Operators.CompareString(ma_nt, (string)null, false) != 0)
			{
				((ListControl)cboNgoai_te).SelectedValue = ma_nt;
				txtTy_gia.Value = Commons.Get_TyGia(ma_nt, DateAndTime.Now.Date);
			}
		}
	}

	private void LockWhenVND(bool p)
	{
		((Control)txtTong_NT).Enabled = !p;
		((Control)txtTongThue_Nt).Enabled = !p;
		((Control)txtTy_gia).Enabled = !p;
	}

	protected override bool SetToRow()
	{
		base.SetToRow();
		if (!EditMode)
		{
			RowToEdit["stt_rec"] = Commons.Get_SttRec(MyMenuInfo.par1);
		}
		RowToEdit["thang"] = Conversions.ToDate(txtNgay_ct.Value).Month;
		RowToEdit["nam"] = Conversions.ToDate(txtNgay_ct.Value).Year;
		return true;
	}

	protected override void DataBinding()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtNgay_ct;
		CreateDataBinding(ref ojb, "ngay_ct", "Value");
		txtNgay_ct = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_lap;
		CreateDataBinding(ref ojb, "ngay_lct", "Value");
		txtNgay_lap = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "so_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)txtSo_seri;
		CreateDataBinding(ref ojb, "so_seri");
		txtSo_seri = (TextBox)ojb;
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
		ojb = (Control)(object)cboNgoai_te;
		CreateDataBinding(ref ojb, "ma_nt");
		cboNgoai_te = (AsComboBoxNT)(object)ojb;
		ojb = (Control)(object)txtSo_luong;
		CreateDataBinding(ref ojb, "so_luong", "Value");
		txtSo_luong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGia;
		CreateDataBinding(ref ojb, "gia", "Value");
		txtGia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTy_gia;
		CreateDataBinding(ref ojb, "ty_gia", "Value");
		txtTy_gia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMa_thue;
		CreateDataBinding(ref ojb, "ma_thue");
		txtMa_thue = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtThue_suat;
		CreateDataBinding(ref ojb, "thue_suat", "Value");
		txtThue_suat = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTong_NT;
		CreateDataBinding(ref ojb, "t_tien_nt", "Value");
		txtTong_NT = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTong;
		CreateDataBinding(ref ojb, "t_tien", "Value");
		txtTong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTongThue_Nt;
		CreateDataBinding(ref ojb, "t_thue_nt", "Value");
		txtTongThue_Nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTongThue;
		CreateDataBinding(ref ojb, "t_thue", "Value");
		txtTongThue = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTK_thue;
		CreateDataBinding(ref ojb, "tk_thue");
		txtTK_thue = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTK_du;
		CreateDataBinding(ref ojb, "tk_du");
		txtTK_du = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_bp;
		CreateDataBinding(ref ojb, "ma_bp");
		txtMa_bp = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_hd;
		CreateDataBinding(ref ojb, "ma_hd");
		txtMa_hd = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_spct;
		CreateDataBinding(ref ojb, "ma_spct");
		txtMa_spct = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtGhi_chu;
		CreateDataBinding(ref ojb, "ghi_chu");
		txtGhi_chu = (TextBox)ojb;
		ojb = (Control)(object)txtSo_seri_mhd;
		CreateDataBinding(ref ojb, "so_seri_mhd");
		txtSo_seri_mhd = (TextBox)ojb;
	}

	protected override bool ValidData()
	{
		if (Operators.ConditionalCompareObjectLessEqual(txtNgay_ct.Value, (object)AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks, false))
		{
			SetControlError((Control)(object)txtNgay_ct, Helper.GetMessContent(50136));
			((Control)txtNgay_ct).Select();
			return false;
		}
		if (DateAndTime.Year(Conversions.ToDate(txtNgay_ct.Value)) != SystemInformations.FinancialYear)
		{
			SetControlError((Control)(object)txtNgay_ct, Helper.GetMessContent(50013));
			((Control)txtNgay_ct).Select();
			return false;
		}
		if (Operators.CompareString(((TextBox)txtTK_du).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtTK_du, Helper.GetMess(50002).Description);
			((Control)txtTK_du).Select();
			return false;
		}
		epNotice.SetError((Control)(object)txtTK_du, "");
		if (Operators.CompareString(((TextBox)txtTK_thue).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtTK_thue, Helper.GetMess(50002).Description);
			((Control)txtTK_thue).Select();
			return false;
		}
		epNotice.SetError((Control)(object)txtTK_thue, "");
		if (Operators.CompareString(((TextBox)txtTK_du).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtTK_du, Helper.GetMess(50002).Description);
			((Control)txtTK_du).Select();
			return false;
		}
		epNotice.SetError((Control)(object)txtTK_du, "");
		if (!CanhBaoDieuChinh())
		{
			return false;
		}
		return base.ValidData();
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
		try
		{
			txtTen_vt.Text = Conversions.ToString(e.ValidatedRow["ten_vt"]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void cboNgoai_te_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ComboBox)cboNgoai_te).SelectedIndex != -1)
		{
			if (Operators.CompareString(((ComboBox)cboNgoai_te).Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				txtGia.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
				txtTy_gia.Value = 1;
			}
			else
			{
				txtGia.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCPrice_Input_Format;
				txtTy_gia.Value = Commons.Get_TyGia(cboNgoai_te.MA_NT, Conversions.ToDate(txtNgay_ct.Value));
			}
			((Control)txtTy_gia).Enabled = Operators.CompareString(cboNgoai_te.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) != 0;
			RefreshControls();
			if ((!Operators.ConditionalCompareObjectEqual(txtSo_luong.Value, (object)0, false) || !Operators.ConditionalCompareObjectEqual(txtGia.Value, (object)0, false)) && 0 == 0)
			{
				Calc_Tien_nt();
			}
		}
	}

	private void RefreshControls()
	{
		string text = "Tổng tiền ";
		string text2 = "Tổng thuế ";
		if (Operators.CompareString(AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, cboNgoai_te.MA_NT, false) == 0)
		{
			lblT_Tien_nt.Text = text;
			lblT_THUE_NT.Text = text2;
			txtTong_NT.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
			txtTongThue_Nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
			((Control)lblT_tien).Visible = false;
			((Control)lblT_thue).Visible = false;
			((Control)txtTong).Visible = false;
			((Control)txtTongThue).Visible = false;
		}
		else
		{
			lblT_Tien_nt.Text = text + cboNgoai_te.MA_NT;
			lblT_THUE_NT.Text = text2 + cboNgoai_te.MA_NT;
			txtTong_NT.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			txtTongThue_Nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			((Control)lblT_tien).Visible = true;
			((Control)lblT_thue).Visible = true;
			((Control)txtTong).Visible = true;
			((Control)txtTongThue).Visible = true;
		}
	}

	private void Calc_Tien()
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			txtTong.Value = Operators.MultiplyObject(txtTong_NT.Value, txtTy_gia.Value);
			AsTextNumeric asTextNumeric = txtTongThue;
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[2]
			{
				Operators.DivideObject(Operators.MultiplyObject(txtTong.Value, txtThue_suat.Value), (object)100),
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

	private void Calc_Tien_nt()
	{
		if (Operators.ConditionalCompareObjectLess(txtSo_luong.Value, (object)0, false))
		{
			epNotice.SetError((Control)(object)txtSo_luong, Helper.GetMess(50017).Description);
			return;
		}
		epNotice.SetError((Control)(object)txtSo_luong, "");
		AsTextNumeric asTextNumeric = txtTong_NT;
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[2]
		{
			Operators.MultiplyObject(txtSo_luong.Value, txtGia.Value),
			null
		};
		object[] array2 = array;
		SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
		array2[1] = sIConfiguration.Round_Nt;
		object[] array3 = array;
		object[] array4 = array3;
		bool[] array5 = new bool[2] { false, true };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
		if (array5[1])
		{
			sIConfiguration.Round_Nt = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
		}
		asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj);
		AsTextNumeric asTextNumeric2 = txtTongThue_Nt;
		Type? typeFromHandle2 = typeof(Math);
		array3 = new object[2]
		{
			Operators.DivideObject(Operators.MultiplyObject(txtTong_NT.Value, txtThue_suat.Value), (object)100),
			null
		};
		object[] array6 = array3;
		sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
		array6[1] = sIConfiguration.Round_Nt;
		array = array3;
		object[] array7 = array;
		array5 = new bool[2] { false, true };
		object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
		if (array5[1])
		{
			sIConfiguration.Round_Nt = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		asTextNumeric2.Value = RuntimeHelpers.GetObjectValue(obj2);
		Calc_Tien();
	}

	private void Cal_Thue()
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtThue_suat.Value, (object)0, false))
		{
			AsTextNumeric asTextNumeric = txtTongThue;
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[2]
			{
				Operators.DivideObject(Operators.MultiplyObject(txtTong.Value, txtThue_suat.Value), (object)100),
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
		else
		{
			txtTongThue.Value = 0;
		}
	}

	private void Cal_Thue_nt()
	{
		if (Operators.CompareString(((ComboBox)cboNgoai_te).Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			if (Operators.ConditionalCompareObjectNotEqual(txtThue_suat.Value, (object)0, false))
			{
				AsTextNumeric asTextNumeric = txtTongThue_Nt;
				Type? typeFromHandle = typeof(Math);
				object[] array = new object[2]
				{
					Operators.DivideObject(Operators.MultiplyObject(txtTong_NT.Value, txtThue_suat.Value), (object)100),
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
				asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj);
			}
			else
			{
				txtTongThue_Nt.Value = 0;
			}
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtThue_suat.Value, (object)0, false))
		{
			AsTextNumeric asTextNumeric2 = txtTongThue_Nt;
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[2]
			{
				Operators.DivideObject(Operators.MultiplyObject(txtTong_NT.Value, txtThue_suat.Value), (object)100),
				null
			};
			object[] array6 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round_Nt;
			object[] array = array3;
			object[] array7 = array;
			bool[] array5 = new bool[2] { false, true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round_Nt = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			asTextNumeric2.Value = RuntimeHelpers.GetObjectValue(obj2);
		}
		else
		{
			txtTongThue_Nt.Value = 0;
		}
	}

	private void MaskTextBoxAll(ControlCollection ctl)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (Control item in ctl)
		{
			Control val = item;
			if (val is AsTextNumeric)
			{
				AsTextNumeric asTextNumeric = (AsTextNumeric)(object)val;
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCPrice_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"QT", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format;
				}
			}
		}
	}

	private bool CanhBaoDieuChinh()
	{
		if (Conversions.ToDouble(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh) == 0.0)
		{
			return true;
		}
		checked
		{
			int num = (int)Math.Round(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_gia_toi_da);
			int num2 = (int)Math.Round(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_tien_nt_toi_da);
			bool flag = false;
			if (Operators.CompareString(((ComboBox)cboNgoai_te).Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.MultiplyObject(txtSo_luong.Value, txtGia.Value), txtTong_NT.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTong_NT, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTong_NT, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.DivideObject(Operators.MultiplyObject(txtTong_NT.Value, txtThue_suat.Value), (object)100), txtTongThue_Nt.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTongThue, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTongThue, "");
				}
			}
			else
			{
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.MultiplyObject(txtSo_luong.Value, txtGia.Value), txtTong_NT.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num2, false))
				{
					epNotice.SetError((Control)(object)txtTong_NT, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTong_NT, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.DivideObject(Operators.MultiplyObject(txtTong_NT.Value, txtThue_suat.Value), (object)100), txtTongThue_Nt.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num2, false))
				{
					epNotice.SetError((Control)(object)txtTongThue_Nt, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTongThue_Nt, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.MultiplyObject(txtTong_NT.Value, txtTy_gia.Value), txtTong.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTong, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTong, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.DivideObject(Operators.MultiplyObject(txtTong.Value, txtThue_suat.Value), (object)100), txtTongThue.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTongThue, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTongThue, "");
				}
			}
			if (flag)
			{
				return Commons.ProcessAdjustOver();
			}
			return true;
		}
	}

	private void txtTy_gia_ValueChanged(object sender, EventArgs e)
	{
		txtTong.Value = Operators.MultiplyObject(txtTong_NT.Value, txtTy_gia.Value);
		txtTongThue.Value = Operators.DivideObject(Operators.MultiplyObject(txtTong.Value, txtThue_suat.Value), (object)100);
		Cal_Thue();
		Cal_Thue_nt();
	}

	private void txtThue_suat_ValueChanged(object sender, EventArgs e)
	{
		Cal_Thue();
		Cal_Thue_nt();
	}

	private void txtThue_suat_TextChanged(object sender, EventArgs e)
	{
		Cal_Thue();
		Cal_Thue_nt();
	}

	private void txtTong_ValueChanged(object sender, EventArgs e)
	{
		Cal_Thue();
	}

	private void txtTong_NT_ValueChanged(object sender, EventArgs e)
	{
		Calc_Tien();
		Cal_Thue_nt();
	}

	private void txtSo_luong_ValueChanged(object sender, EventArgs e)
	{
		Calc_Tien_nt();
		Cal_Thue();
		Cal_Thue_nt();
	}

	private void txtGia_ValueChanged(object sender, EventArgs e)
	{
		Calc_Tien_nt();
		Cal_Thue();
		Cal_Thue_nt();
	}

	private void txtNgay_ct_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(txtNgay_ct.Value, (object)"#1/1/1900#", false))
		{
			epNotice.SetError((Control)(object)txtNgay_ct, Helper.GetMessContent(50013));
			((Control)txtNgay_ct).Select();
		}
	}

	private void txtNgay_lap_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(txtNgay_lap.Value, (object)"#1/1/1900#", false))
		{
			epNotice.SetError((Control)(object)txtNgay_lap, Helper.GetMessContent(50013));
			((Control)txtNgay_lap).Select();
		}
	}

	private void txtMa_thue_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (e.ValidatedRow != null)
		{
			txtThue_suat.Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ts_gtgt"]), isNum: true));
		}
		else
		{
			txtThue_suat.Value = 0;
		}
	}
}
