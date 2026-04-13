using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmINRptTHX02 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblMa_nhvt")]
	private Label _lblMa_nhvt;

	[AccessedThroughProperty("txtMa_nhvt")]
	private AsTextBox _txtMa_nhvt;

	[AccessedThroughProperty("lblTen_nhvt")]
	private Label _lblTen_nhvt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("txtSo_Ct2")]
	private TextBox _txtSo_Ct2;

	[AccessedThroughProperty("txtSo_Ct1")]
	private TextBox _txtSo_Ct1;

	[AccessedThroughProperty("lblSo_Ct2")]
	private Label _lblSo_Ct2;

	[AccessedThroughProperty("lblSo_Ct1")]
	private Label _lblSo_Ct1;

	[AccessedThroughProperty("lblTen_kho_nhap")]
	private Label _lblTen_kho_nhap;

	[AccessedThroughProperty("txtKho_nhap")]
	private AsTextBox _txtKho_nhap;

	[AccessedThroughProperty("lblMa_kho_nhap")]
	private Label _lblMa_kho_nhap;

	[AccessedThroughProperty("txtTk_Du")]
	private AsTextBox _txtTk_Du;

	[AccessedThroughProperty("lblTen_Tk_Du")]
	private Label _lblTen_Tk_Du;

	[AccessedThroughProperty("lblTk_Du")]
	private Label _lblTk_Du;

	[AccessedThroughProperty("lblTen_Tkvt")]
	private Label _lblTen_Tkvt;

	[AccessedThroughProperty("txtTk_vt")]
	private AsTextBox _txtTk_vt;

	[AccessedThroughProperty("lblTk_vt")]
	private Label _lblTk_vt;

	[AccessedThroughProperty("lblTen_dangNX")]
	private Label _lblTen_dangNX;

	[AccessedThroughProperty("txtMa_NX")]
	private AsTextBox _txtMa_NX;

	[AccessedThroughProperty("lblMa_NX")]
	private Label _lblMa_NX;

	[AccessedThroughProperty("lblTen_Hd")]
	private Label _lblTen_Hd;

	[AccessedThroughProperty("txtMa_Hd")]
	private AsTextBox _txtMa_Hd;

	[AccessedThroughProperty("lblMa_Hd")]
	private Label _lblMa_Hd;

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

	[AccessedThroughProperty("txtMa_Bp")]
	private AsTextBox _txtMa_Bp;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	[AccessedThroughProperty("lblPS_dc")]
	private Label _lblPS_dc;

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("txtMa_vitri")]
	private AsTextBox _txtMa_vitri;

	[AccessedThroughProperty("lblMa_vitri")]
	private Label _lblMa_vitri;

	[AccessedThroughProperty("lblTen_kho_xuat")]
	private Label _lblTen_kho_xuat;

	[AccessedThroughProperty("txtMa_kho_xuat")]
	private AsTextBox _txtMa_kho_xuat;

	[AccessedThroughProperty("lblMa_kho_xuat")]
	private Label _lblMa_kho_xuat;

	[AccessedThroughProperty("ChkTinh_Ps")]
	private AsCheckBox _ChkTinh_Ps;

	[AccessedThroughProperty("lblMa_loaiPx")]
	private Label _lblMa_loaiPx;

	[AccessedThroughProperty("cboLoai_px")]
	private ComboBox _cboLoai_px;

	[AccessedThroughProperty("lblChi_tiet")]
	private Label _lblChi_tiet;

	[AccessedThroughProperty("cboChi_tiet")]
	private ComboBox _cboChi_tiet;

	[AccessedThroughProperty("lblNhom")]
	private Label _lblNhom;

	[AccessedThroughProperty("cboNhom")]
	private ComboBox _cboNhom;

	[AccessedThroughProperty("lblTen_nhkh")]
	private Label _lblTen_nhkh;

	[AccessedThroughProperty("txtMa_nhkh")]
	private AsTextBox _txtMa_nhkh;

	[AccessedThroughProperty("lblMa_nhKh")]
	private Label _lblMa_nhKh;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("cboLoai_gd")]
	private ComboBox _cboLoai_gd;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("lblTenPhi")]
	private Label _lblTenPhi;

	[AccessedThroughProperty("txtMa_Phi")]
	private AsTextBox _txtMa_Phi;

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("txtMa_lo")]
	private AsTextBox _txtMa_lo;

	[AccessedThroughProperty("lblMaLo")]
	private Label _lblMaLo;

	[AccessedThroughProperty("lblDVT")]
	private Label _lblDVT;

	[AccessedThroughProperty("cboDVT")]
	private ComboBox _cboDVT;

	internal virtual Label lblMa_nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhvt = value;
		}
	}

	internal virtual AsTextBox txtMa_nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhvt = value;
		}
	}

	internal virtual Label lblTen_nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nhvt = value;
		}
	}

	internal virtual Label lblTen_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_vt = value;
		}
	}

	internal virtual AsTextBox txtMa_vt
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
			_txtMa_vt = value;
		}
	}

	internal virtual Label lblMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_vt = value;
		}
	}

	internal virtual Label lblTen_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Kh = value;
		}
	}

	internal virtual AsTextBox txtMa_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Kh = value;
		}
	}

	internal virtual Label lblMa_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Kh = value;
		}
	}

	internal virtual TextBox txtSo_Ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_Ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_Ct2 = value;
		}
	}

	internal virtual TextBox txtSo_Ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_Ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_Ct1 = value;
		}
	}

	internal virtual Label lblSo_Ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_Ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_Ct2 = value;
		}
	}

	internal virtual Label lblSo_Ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_Ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_Ct1 = value;
		}
	}

	internal virtual Label lblTen_kho_nhap
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kho_nhap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kho_nhap = value;
		}
	}

	internal virtual AsTextBox txtKho_nhap
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtKho_nhap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtKho_nhap = value;
		}
	}

	internal virtual Label lblMa_kho_nhap
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kho_nhap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kho_nhap = value;
		}
	}

	private virtual AsTextBox txtTk_Du
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Du = value;
		}
	}

	private virtual Label lblTen_Tk_Du
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_Du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_Du = value;
		}
	}

	private virtual Label lblTk_Du
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Du = value;
		}
	}

	internal virtual Label lblTen_Tkvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tkvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tkvt = value;
		}
	}

	private virtual AsTextBox txtTk_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_vt = value;
		}
	}

	private virtual Label lblTk_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_vt = value;
		}
	}

	internal virtual Label lblTen_dangNX
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_dangNX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_dangNX = value;
		}
	}

	internal virtual AsTextBox txtMa_NX
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_NX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_NX = value;
		}
	}

	internal virtual Label lblMa_NX
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_NX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_NX = value;
		}
	}

	internal virtual Label lblTen_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Hd = value;
		}
	}

	internal virtual AsTextBox txtMa_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Hd = value;
		}
	}

	internal virtual Label lblMa_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Hd = value;
		}
	}

	internal virtual Label lblTen_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Bp = value;
		}
	}

	internal virtual AsTextBox txtMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Bp = value;
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

	internal virtual Label lblPS_dc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPS_dc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPS_dc = value;
		}
	}

	internal virtual Label lblTen_vitri
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_vitri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_vitri = value;
		}
	}

	internal virtual AsTextBox txtMa_vitri
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_vitri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_vitri = value;
		}
	}

	internal virtual Label lblMa_vitri
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_vitri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_vitri = value;
		}
	}

	internal virtual Label lblTen_kho_xuat
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kho_xuat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kho_xuat = value;
		}
	}

	internal virtual AsTextBox txtMa_kho_xuat
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kho_xuat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kho_xuat = value;
		}
	}

	internal virtual Label lblMa_kho_xuat
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kho_xuat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kho_xuat = value;
		}
	}

	internal virtual AsCheckBox ChkTinh_Ps
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkTinh_Ps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkTinh_Ps = value;
		}
	}

	internal virtual Label lblMa_loaiPx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_loaiPx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_loaiPx = value;
		}
	}

	internal virtual ComboBox cboLoai_px
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_px;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboLoai_px_SelectedValueChanged;
			if (_cboLoai_px != null)
			{
				((ListControl)_cboLoai_px).SelectedValueChanged -= eventHandler;
			}
			_cboLoai_px = value;
			if (_cboLoai_px != null)
			{
				((ListControl)_cboLoai_px).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblChi_tiet
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblChi_tiet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblChi_tiet = value;
		}
	}

	internal virtual ComboBox cboChi_tiet
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboChi_tiet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboChi_tiet = value;
		}
	}

	internal virtual Label lblNhom
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNhom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNhom = value;
		}
	}

	internal virtual ComboBox cboNhom
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNhom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboNhom = value;
		}
	}

	internal virtual Label lblTen_nhkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nhkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nhkh = value;
		}
	}

	internal virtual AsTextBox txtMa_nhkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhkh = value;
		}
	}

	internal virtual Label lblMa_nhKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhKh = value;
		}
	}

	internal virtual Label lblTen_spct
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

	internal virtual AsTextBox txtMa_spct
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

	internal virtual ComboBox cboLoai_gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_gd = value;
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

	internal virtual Label lblTenPhi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTenPhi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTenPhi = value;
		}
	}

	internal virtual AsTextBox txtMa_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Phi = value;
		}
	}

	internal virtual Label lblTen_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_lo = value;
		}
	}

	internal virtual AsTextBox txtMa_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_lo = value;
		}
	}

	internal virtual Label lblMaLo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMaLo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMaLo = value;
		}
	}

	internal virtual Label lblDVT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDVT = value;
		}
	}

	internal virtual ComboBox cboDVT
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboDVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboDVT = value;
		}
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

	public frmINRptTHX02(string MenuId)
		: base(MenuId)
	{
		__ENCAddToList(this);
		InitializeComponent();
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
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
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
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
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
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_36d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_36de: Expected O, but got Unknown
		txtSo_Ct2 = new TextBox();
		txtSo_Ct1 = new TextBox();
		lblSo_Ct2 = new Label();
		lblSo_Ct1 = new Label();
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblMa_nhvt = new Label();
		txtMa_nhvt = new AsTextBox();
		lblTen_nhvt = new Label();
		lblTen_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		lblTen_Hd = new Label();
		txtMa_Hd = new AsTextBox();
		lblMa_Hd = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_Bp = new Label();
		lblTen_dangNX = new Label();
		txtMa_NX = new AsTextBox();
		lblMa_NX = new Label();
		lblTen_Tkvt = new Label();
		txtTk_vt = new AsTextBox();
		lblTk_vt = new Label();
		txtTk_Du = new AsTextBox();
		lblTen_Tk_Du = new Label();
		lblTk_Du = new Label();
		lblTen_kho_nhap = new Label();
		txtKho_nhap = new AsTextBox();
		lblMa_kho_nhap = new Label();
		lblTen_kho_xuat = new Label();
		txtMa_kho_xuat = new AsTextBox();
		lblMa_kho_xuat = new Label();
		lblTen_vitri = new Label();
		txtMa_vitri = new AsTextBox();
		lblMa_vitri = new Label();
		lblPS_dc = new Label();
		ChkTinh_Ps = new AsCheckBox();
		cboLoai_px = new ComboBox();
		lblMa_loaiPx = new Label();
		lblNhom = new Label();
		cboNhom = new ComboBox();
		lblChi_tiet = new Label();
		cboChi_tiet = new ComboBox();
		lblTen_nhkh = new Label();
		txtMa_nhkh = new AsTextBox();
		lblMa_nhKh = new Label();
		txtMa_spct = new AsTextBox();
		lblTen_spct = new Label();
		Label1 = new Label();
		Label2 = new Label();
		cboLoai_gd = new ComboBox();
		Label8 = new Label();
		lblTenPhi = new Label();
		txtMa_Phi = new AsTextBox();
		lblTen_lo = new Label();
		txtMa_lo = new AsTextBox();
		lblMaLo = new Label();
		lblDVT = new Label();
		cboDVT = new ComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(1037, 630);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)lblDVT);
		((Control)tabFilter).Controls.Add((Control)(object)cboDVT);
		((Control)tabFilter).Controls.Add((Control)(object)Label8);
		((Control)tabFilter).Controls.Add((Control)(object)lblTenPhi);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lo);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_lo);
		((Control)tabFilter).Controls.Add((Control)(object)lblMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai_gd);
		((Control)tabFilter).Controls.Add((Control)(object)Label2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhkh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhkh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhKh);
		((Control)tabFilter).Controls.Add((Control)(object)lblChi_tiet);
		((Control)tabFilter).Controls.Add((Control)(object)cboChi_tiet);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_loaiPx);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai_px);
		((Control)tabFilter).Controls.Add((Control)(object)ChkTinh_Ps);
		((Control)tabFilter).Controls.Add((Control)(object)lblPS_dc);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho_xuat);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho_xuat);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho_xuat);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho_nhap);
		((Control)tabFilter).Controls.Add((Control)(object)txtKho_nhap);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho_nhap);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk_Du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk_Du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk_Du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tkvt);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_Ct2);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_Ct1);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct2);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct1);
		TabPage obj = tabFilter;
		size = new Size(1029, 601);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_Ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_Ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tkvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk_Du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk_Du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk_Du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho_nhap, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtKho_nhap, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho_nhap, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho_xuat, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho_xuat, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho_xuat, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPS_dc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkTinh_Ps, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai_px, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_loaiPx, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboChi_tiet, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblChi_tiet, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhKh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhkh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhkh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai_gd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTenPhi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboDVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDVT, 0);
		Label obj2 = lbl2;
		Point location = new Point(338, 68);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 564);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(357, 64);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 557);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(504, 13);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 25;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(267, 64);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(159, 64);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(24, 67);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(159, 15);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 23;
		((Control)cboMau_bc).TabStop = false;
		Label obj9 = lblMau_bc;
		location = new Point(24, 18);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(159, 499);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 23;
		Label obj10 = lblMauBC;
		location = new Point(204, 503);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 22;
		RadioButton obj11 = optVND;
		location = new Point(291, 501);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 24;
		RadioButton obj12 = optNt;
		location = new Point(345, 501);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 24;
		Label obj13 = lblMa_nt;
		location = new Point(24, 501);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(22, 530);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 25;
		Label obj15 = lblTieu_de;
		location = new Point(24, 43);
		((Control)obj15).Location = location;
		TextBox obj16 = txtTieu_De;
		location = new Point(159, 40);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 24;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj17 = tabGrid;
		size = new Size(989, 554);
		((Control)obj17).Size = size;
		TextBox obj18 = txtSo_Ct2;
		location = new Point(342, 139);
		((Control)obj18).Location = location;
		((Control)txtSo_Ct2).Name = "txtSo_Ct2";
		TextBox obj19 = txtSo_Ct2;
		size = new Size(82, 20);
		((Control)obj19).Size = size;
		((Control)txtSo_Ct2).TabIndex = 8;
		TextBox obj20 = txtSo_Ct1;
		location = new Point(159, 139);
		((Control)obj20).Location = location;
		((Control)txtSo_Ct1).Name = "txtSo_Ct1";
		TextBox obj21 = txtSo_Ct1;
		size = new Size(82, 20);
		((Control)obj21).Size = size;
		((Control)txtSo_Ct1).TabIndex = 7;
		lblSo_Ct2.AutoSize = true;
		Label obj22 = lblSo_Ct2;
		location = new Point(276, 142);
		((Control)obj22).Location = location;
		((Control)lblSo_Ct2).Name = "lblSo_Ct2";
		Label obj23 = lblSo_Ct2;
		size = new Size(40, 13);
		((Control)obj23).Size = size;
		((Control)lblSo_Ct2).TabIndex = 1023;
		lblSo_Ct2.Text = "đến số";
		lblSo_Ct1.AutoSize = true;
		Label obj24 = lblSo_Ct1;
		location = new Point(24, 142);
		((Control)obj24).Location = location;
		((Control)lblSo_Ct1).Name = "lblSo_Ct1";
		Label obj25 = lblSo_Ct1;
		size = new Size(64, 13);
		((Control)obj25).Size = size;
		((Control)lblSo_Ct1).TabIndex = 1022;
		lblSo_Ct1.Text = "Chứng từ số";
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj26 = lblTen_Kh;
		location = new Point(247, 310);
		((Control)obj26).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj27 = lblTen_Kh;
		size = new Size(479, 13);
		((Control)obj27).Size = size;
		((Control)lblTen_Kh).TabIndex = 1033;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = false;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_Kh;
		location = new Point(159, 307);
		((Control)asTextBox2).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		AsTextBox asTextBox3 = txtMa_Kh;
		size = new Size(82, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_Kh).TabIndex = 15;
		txtMa_Kh.UseAutoCompleteSource = true;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj28 = lblMa_Kh;
		location = new Point(24, 311);
		((Control)obj28).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj29 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj29).Size = size;
		((Control)lblMa_Kh).TabIndex = 1032;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblMa_nhvt.AutoSize = true;
		lblMa_nhvt.ImeMode = (ImeMode)0;
		Label obj30 = lblMa_nhvt;
		location = new Point(24, 239);
		((Control)obj30).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj31 = lblMa_nhvt;
		size = new Size(65, 13);
		((Control)obj31).Size = size;
		((Control)lblMa_nhvt).TabIndex = 1038;
		lblMa_nhvt.Text = "Nhóm vật tư";
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_nhvt;
		location = new Point(159, 235);
		((Control)asTextBox4).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((TextBoxBase)txtMa_nhvt).MaxLength = 8;
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_nhvt;
		AsTextBox asTextBox5 = txtMa_nhvt;
		size = new Size(82, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_nhvt).TabIndex = 12;
		((Control)txtMa_nhvt).Tag = "MA_NHVT";
		txtMa_nhvt.UseAutoCompleteSource = true;
		lblTen_nhvt.ImeMode = (ImeMode)0;
		Label obj32 = lblTen_nhvt;
		location = new Point(247, 238);
		((Control)obj32).Location = location;
		((Control)lblTen_nhvt).Name = "lblTen_nhvt";
		Label obj33 = lblTen_nhvt;
		size = new Size(479, 13);
		((Control)obj33).Size = size;
		((Control)lblTen_nhvt).TabIndex = 1039;
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj34 = lblTen_vt;
		location = new Point(247, 214);
		((Control)obj34).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj35 = lblTen_vt;
		size = new Size(479, 13);
		((Control)obj35).Size = size;
		((Control)lblTen_vt).TabIndex = 1037;
		((TextBox)txtMa_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_vt;
		location = new Point(159, 211);
		((Control)asTextBox6).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox7 = txtMa_vt;
		size = new Size(82, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_vt).TabIndex = 11;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_vt.AutoSize = true;
		lblMa_vt.ImeMode = (ImeMode)0;
		Label obj36 = lblMa_vt;
		location = new Point(24, 215);
		((Control)obj36).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj37 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj37).Size = size;
		((Control)lblMa_vt).TabIndex = 1036;
		lblMa_vt.Text = "Mã vật tư";
		lblMa_vt.TextAlign = (ContentAlignment)16;
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj38 = lblTen_Hd;
		location = new Point(247, 360);
		((Control)obj38).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj39 = lblTen_Hd;
		size = new Size(479, 13);
		((Control)obj39).Size = size;
		((Control)lblTen_Hd).TabIndex = 1050;
		lblTen_Hd.TextAlign = (ContentAlignment)16;
		txtMa_Hd.AutoLookup = true;
		txtMa_Hd.AutoValid = false;
		((TextBoxBase)txtMa_Hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_Hd;
		location = new Point(159, 355);
		((Control)asTextBox8).Location = location;
		txtMa_Hd.LookupCodeName = "MA_HD";
		((Control)txtMa_Hd).Name = "txtMa_Hd";
		txtMa_Hd.NameControl = lblTen_Hd;
		AsTextBox asTextBox9 = txtMa_Hd;
		size = new Size(82, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_Hd).TabIndex = 17;
		txtMa_Hd.UseAutoCompleteSource = true;
		lblMa_Hd.AutoSize = true;
		lblMa_Hd.ImeMode = (ImeMode)0;
		Label obj40 = lblMa_Hd;
		location = new Point(24, 359);
		((Control)obj40).Location = location;
		((Control)lblMa_Hd).Name = "lblMa_Hd";
		Label obj41 = lblMa_Hd;
		size = new Size(71, 13);
		((Control)obj41).Size = size;
		((Control)lblMa_Hd).TabIndex = 1049;
		lblMa_Hd.Text = "Mã hợp đồng";
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj42 = lblTen_Bp;
		location = new Point(247, 334);
		((Control)obj42).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj43 = lblTen_Bp;
		size = new Size(479, 13);
		((Control)obj43).Size = size;
		((Control)lblTen_Bp).TabIndex = 1048;
		lblTen_Bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_Bp;
		location = new Point(159, 331);
		((Control)asTextBox10).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox11 = txtMa_Bp;
		size = new Size(82, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_Bp).TabIndex = 16;
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_Bp.AutoSize = true;
		lblMa_Bp.ImeMode = (ImeMode)0;
		Label obj44 = lblMa_Bp;
		location = new Point(24, 335);
		((Control)obj44).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj45 = lblMa_Bp;
		size = new Size(64, 13);
		((Control)obj45).Size = size;
		((Control)lblMa_Bp).TabIndex = 1047;
		lblMa_Bp.Text = "Mã bộ phận";
		lblTen_dangNX.ImeMode = (ImeMode)0;
		Label obj46 = lblTen_dangNX;
		location = new Point(465, 698);
		((Control)obj46).Location = location;
		((Control)lblTen_dangNX).Name = "lblTen_dangNX";
		Label obj47 = lblTen_dangNX;
		size = new Size(300, 13);
		((Control)obj47).Size = size;
		((Control)lblTen_dangNX).TabIndex = 1053;
		lblTen_dangNX.TextAlign = (ContentAlignment)16;
		((Control)lblTen_dangNX).Visible = false;
		txtMa_NX.AutoLookup = true;
		txtMa_NX.AutoValid = false;
		((TextBoxBase)txtMa_NX).BackColor = SystemColors.Info;
		((TextBox)txtMa_NX).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_NX;
		location = new Point(377, 694);
		((Control)asTextBox12).Location = location;
		txtMa_NX.LookupCodeName = "MA_NX";
		((Control)txtMa_NX).Name = "txtMa_NX";
		txtMa_NX.NameControl = lblTen_dangNX;
		AsTextBox asTextBox13 = txtMa_NX;
		size = new Size(82, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_NX).TabIndex = 20;
		((Control)txtMa_NX).Tag = "MA_NX";
		txtMa_NX.UseAutoCompleteSource = true;
		((Control)txtMa_NX).Visible = false;
		lblMa_NX.AutoSize = true;
		lblMa_NX.ImeMode = (ImeMode)0;
		Label obj48 = lblMa_NX;
		location = new Point(288, 698);
		((Control)obj48).Location = location;
		((Control)lblMa_NX).Name = "lblMa_NX";
		Label obj49 = lblMa_NX;
		size = new Size(72, 13);
		((Control)obj49).Size = size;
		((Control)lblMa_NX).TabIndex = 1052;
		lblMa_NX.Text = "Mã dạng N/X";
		((Control)lblMa_NX).Visible = false;
		lblTen_Tkvt.ImeMode = (ImeMode)0;
		Label obj50 = lblTen_Tkvt;
		location = new Point(247, 263);
		((Control)obj50).Location = location;
		((Control)lblTen_Tkvt).Name = "lblTen_Tkvt";
		Label obj51 = lblTen_Tkvt;
		size = new Size(479, 13);
		((Control)obj51).Size = size;
		((Control)lblTen_Tkvt).TabIndex = 1056;
		((TextBox)txtTk_vt).AutoCompleteMode = (AutoCompleteMode)1;
		((TextBox)txtTk_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk_vt.AutoLookup = true;
		txtTk_vt.AutoValid = false;
		((TextBoxBase)txtTk_vt).BackColor = SystemColors.Info;
		((TextBox)txtTk_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtTk_vt;
		location = new Point(159, 259);
		((Control)asTextBox14).Location = location;
		txtTk_vt.LookupCodeName = "TK";
		((Control)txtTk_vt).Name = "txtTk_vt";
		txtTk_vt.NameControl = lblTen_Tkvt;
		AsTextBox asTextBox15 = txtTk_vt;
		size = new Size(82, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtTk_vt).TabIndex = 13;
		((Control)txtTk_vt).Tag = "@pTk";
		txtTk_vt.UseAutoCompleteSource = true;
		lblTk_vt.AutoSize = true;
		lblTk_vt.ImeMode = (ImeMode)0;
		Label obj52 = lblTk_vt;
		location = new Point(24, 263);
		((Control)obj52).Location = location;
		((Control)lblTk_vt).Name = "lblTk_vt";
		Label obj53 = lblTk_vt;
		size = new Size(51, 13);
		((Control)obj53).Size = size;
		((Control)lblTk_vt).TabIndex = 1055;
		lblTk_vt.Text = "TK vật tư";
		((TextBox)txtTk_Du).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk_Du.AutoLookup = true;
		txtTk_Du.AutoValid = false;
		((TextBoxBase)txtTk_Du).BackColor = SystemColors.Info;
		((TextBox)txtTk_Du).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox16 = txtTk_Du;
		location = new Point(159, 283);
		((Control)asTextBox16).Location = location;
		txtTk_Du.LookupCodeName = "TK";
		((Control)txtTk_Du).Name = "txtTk_Du";
		txtTk_Du.NameControl = lblTen_Tk_Du;
		AsTextBox asTextBox17 = txtTk_Du;
		size = new Size(82, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtTk_Du).TabIndex = 14;
		((Control)txtTk_Du).Tag = "@pTk";
		txtTk_Du.UseAutoCompleteSource = true;
		lblTen_Tk_Du.ImeMode = (ImeMode)0;
		Label obj54 = lblTen_Tk_Du;
		location = new Point(247, 286);
		((Control)obj54).Location = location;
		((Control)lblTen_Tk_Du).Name = "lblTen_Tk_Du";
		Label obj55 = lblTen_Tk_Du;
		size = new Size(479, 13);
		((Control)obj55).Size = size;
		((Control)lblTen_Tk_Du).TabIndex = 1059;
		lblTen_Tk_Du.TextAlign = (ContentAlignment)16;
		lblTk_Du.AutoSize = true;
		lblTk_Du.ImeMode = (ImeMode)0;
		Label obj56 = lblTk_Du;
		location = new Point(24, 287);
		((Control)obj56).Location = location;
		((Control)lblTk_Du).Name = "lblTk_Du";
		Label obj57 = lblTk_Du;
		size = new Size(60, 13);
		((Control)obj57).Size = size;
		((Control)lblTk_Du).TabIndex = 1058;
		lblTk_Du.Text = "TK đối ứng";
		lblTen_kho_nhap.ImeMode = (ImeMode)0;
		Label obj58 = lblTen_kho_nhap;
		location = new Point(247, 166);
		((Control)obj58).Location = location;
		((Control)lblTen_kho_nhap).Name = "lblTen_kho_nhap";
		Label obj59 = lblTen_kho_nhap;
		size = new Size(479, 13);
		((Control)obj59).Size = size;
		((Control)lblTen_kho_nhap).TabIndex = 1062;
		lblTen_kho_nhap.TextAlign = (ContentAlignment)16;
		txtKho_nhap.AutoLookup = true;
		txtKho_nhap.AutoValid = false;
		((TextBoxBase)txtKho_nhap).BackColor = SystemColors.Info;
		((TextBox)txtKho_nhap).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox18 = txtKho_nhap;
		location = new Point(159, 163);
		((Control)asTextBox18).Location = location;
		txtKho_nhap.LookupCodeName = "MA_KHO";
		((Control)txtKho_nhap).Name = "txtKho_nhap";
		txtKho_nhap.NameControl = lblTen_kho_nhap;
		AsTextBox asTextBox19 = txtKho_nhap;
		size = new Size(82, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtKho_nhap).TabIndex = 9;
		((Control)txtKho_nhap).Tag = "MA_KHO";
		txtKho_nhap.UseAutoCompleteSource = true;
		lblMa_kho_nhap.AutoSize = true;
		lblMa_kho_nhap.ImeMode = (ImeMode)0;
		Label obj60 = lblMa_kho_nhap;
		location = new Point(24, 166);
		((Control)obj60).Location = location;
		((Control)lblMa_kho_nhap).Name = "lblMa_kho_nhap";
		Label obj61 = lblMa_kho_nhap;
		size = new Size(70, 13);
		((Control)obj61).Size = size;
		((Control)lblMa_kho_nhap).TabIndex = 1061;
		lblMa_kho_nhap.Text = "Mã kho nhập";
		lblTen_kho_xuat.ImeMode = (ImeMode)0;
		Label obj62 = lblTen_kho_xuat;
		location = new Point(247, 190);
		((Control)obj62).Location = location;
		((Control)lblTen_kho_xuat).Name = "lblTen_kho_xuat";
		Label obj63 = lblTen_kho_xuat;
		size = new Size(479, 13);
		((Control)obj63).Size = size;
		((Control)lblTen_kho_xuat).TabIndex = 1065;
		lblTen_kho_xuat.TextAlign = (ContentAlignment)16;
		txtMa_kho_xuat.AutoLookup = true;
		txtMa_kho_xuat.AutoValid = false;
		((TextBoxBase)txtMa_kho_xuat).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho_xuat).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtMa_kho_xuat;
		location = new Point(159, 187);
		((Control)asTextBox20).Location = location;
		txtMa_kho_xuat.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho_xuat).Name = "txtMa_kho_xuat";
		txtMa_kho_xuat.NameControl = lblTen_kho_xuat;
		AsTextBox asTextBox21 = txtMa_kho_xuat;
		size = new Size(82, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMa_kho_xuat).TabIndex = 10;
		((Control)txtMa_kho_xuat).Tag = "MA_KHO";
		txtMa_kho_xuat.UseAutoCompleteSource = true;
		lblMa_kho_xuat.AutoSize = true;
		lblMa_kho_xuat.ImeMode = (ImeMode)0;
		Label obj64 = lblMa_kho_xuat;
		location = new Point(24, 191);
		((Control)obj64).Location = location;
		((Control)lblMa_kho_xuat).Name = "lblMa_kho_xuat";
		Label obj65 = lblMa_kho_xuat;
		size = new Size(66, 13);
		((Control)obj65).Size = size;
		((Control)lblMa_kho_xuat).TabIndex = 1064;
		lblMa_kho_xuat.Text = "Mã kho xuất";
		((Control)lblTen_vitri).Enabled = false;
		lblTen_vitri.ImeMode = (ImeMode)0;
		Label obj66 = lblTen_vitri;
		location = new Point(333, 610);
		((Control)obj66).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj67 = lblTen_vitri;
		size = new Size(300, 13);
		((Control)obj67).Size = size;
		((Control)lblTen_vitri).TabIndex = 1068;
		lblTen_vitri.TextAlign = (ContentAlignment)16;
		((Control)lblTen_vitri).Visible = false;
		txtMa_vitri.AutoLookup = true;
		txtMa_vitri.AutoValid = false;
		((TextBoxBase)txtMa_vitri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vitri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vitri).Enabled = false;
		AsTextBox asTextBox22 = txtMa_vitri;
		location = new Point(245, 606);
		((Control)asTextBox22).Location = location;
		txtMa_vitri.LookupCodeName = "MA_vitri";
		((Control)txtMa_vitri).Name = "txtMa_vitri";
		txtMa_vitri.NameControl = lblTen_vitri;
		AsTextBox asTextBox23 = txtMa_vitri;
		size = new Size(82, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMa_vitri).TabIndex = 17;
		((Control)txtMa_vitri).Tag = "MA_vitri";
		txtMa_vitri.UseAutoCompleteSource = true;
		((Control)txtMa_vitri).Visible = false;
		lblMa_vitri.AutoSize = true;
		((Control)lblMa_vitri).Enabled = false;
		lblMa_vitri.ImeMode = (ImeMode)0;
		Label obj68 = lblMa_vitri;
		location = new Point(156, 610);
		((Control)obj68).Location = location;
		((Control)lblMa_vitri).Name = "lblMa_vitri";
		Label obj69 = lblMa_vitri;
		size = new Size(46, 13);
		((Control)obj69).Size = size;
		((Control)lblMa_vitri).TabIndex = 1067;
		lblMa_vitri.Text = "Mã vị trí";
		((Control)lblMa_vitri).Visible = false;
		lblPS_dc.AutoSize = true;
		lblPS_dc.ImeMode = (ImeMode)0;
		Label obj70 = lblPS_dc;
		location = new Point(24, 478);
		((Control)obj70).Location = location;
		((Control)lblPS_dc).Name = "lblPS_dc";
		Label obj71 = lblPS_dc;
		size = new Size(83, 13);
		((Control)obj71).Size = size;
		((Control)lblPS_dc).TabIndex = 1069;
		lblPS_dc.Text = "PS điều chuyển";
		((ButtonBase)ChkTinh_Ps).AutoSize = true;
		ChkTinh_Ps.Checked = true;
		((CheckBox)ChkTinh_Ps).CheckState = (CheckState)1;
		AsCheckBox chkTinh_Ps = ChkTinh_Ps;
		location = new Point(159, 476);
		((Control)chkTinh_Ps).Location = location;
		((Control)ChkTinh_Ps).Name = "ChkTinh_Ps";
		AsCheckBox chkTinh_Ps2 = ChkTinh_Ps;
		size = new Size(157, 17);
		((Control)chkTinh_Ps2).Size = size;
		((Control)ChkTinh_Ps).TabIndex = 22;
		((ButtonBase)ChkTinh_Ps).Text = "Tính phát sinh điều chuyển";
		((ButtonBase)ChkTinh_Ps).UseVisualStyleBackColor = true;
		cboLoai_px.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_px).FormattingEnabled = true;
		cboLoai_px.Items.AddRange(new object[7] { "Phiếu xuất kho", "Phiếu xuất chuyển kho", "Phiếu xuất công cụ, dụng cụ", "Phiếu xuất trả lại NCC", "Xuất hàng", "Hóa đơn", "Tất cả" });
		ComboBox obj72 = cboLoai_px;
		location = new Point(159, 114);
		((Control)obj72).Location = location;
		((Control)cboLoai_px).Name = "cboLoai_px";
		ComboBox obj73 = cboLoai_px;
		size = new Size(175, 21);
		((Control)obj73).Size = size;
		((Control)cboLoai_px).TabIndex = 5;
		lblMa_loaiPx.AutoSize = true;
		Label obj74 = lblMa_loaiPx;
		location = new Point(24, 117);
		((Control)obj74).Location = location;
		((Control)lblMa_loaiPx).Name = "lblMa_loaiPx";
		Label obj75 = lblMa_loaiPx;
		size = new Size(79, 13);
		((Control)obj75).Size = size;
		((Control)lblMa_loaiPx).TabIndex = 1072;
		lblMa_loaiPx.Text = "Loại phiếu xuất";
		lblNhom.AutoSize = true;
		Label obj76 = lblNhom;
		location = new Point(24, 92);
		((Control)obj76).Location = location;
		((Control)lblNhom).Name = "lblNhom";
		Label obj77 = lblNhom;
		size = new Size(59, 13);
		((Control)obj77).Size = size;
		((Control)lblNhom).TabIndex = 1074;
		lblNhom.Text = "Nhóm theo";
		cboNhom.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom).FormattingEnabled = true;
		cboNhom.Items.AddRange(new object[5] { "Khách hàng", "Dạng Nhập/Xuất", "Hợp đồng", "Sản phẩm công trình", "Mặt hàng" });
		ComboBox obj78 = cboNhom;
		location = new Point(159, 89);
		((Control)obj78).Location = location;
		((Control)cboNhom).Name = "cboNhom";
		ComboBox obj79 = cboNhom;
		size = new Size(175, 21);
		((Control)obj79).Size = size;
		((Control)cboNhom).TabIndex = 3;
		lblChi_tiet.AutoSize = true;
		Label obj80 = lblChi_tiet;
		location = new Point(357, 93);
		((Control)obj80).Location = location;
		((Control)lblChi_tiet).Name = "lblChi_tiet";
		Label obj81 = lblChi_tiet;
		size = new Size(63, 13);
		((Control)obj81).Size = size;
		((Control)lblChi_tiet).TabIndex = 1076;
		lblChi_tiet.Text = "Chi tiết theo";
		cboChi_tiet.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboChi_tiet).FormattingEnabled = true;
		cboChi_tiet.Items.AddRange(new object[5] { "Khách hàng", "Dạng Nhập/Xuất", "Hợp đồng", "Sản phẩm công trình", "Mặt hàng" });
		ComboBox obj82 = cboChi_tiet;
		location = new Point(437, 89);
		((Control)obj82).Location = location;
		((Control)cboChi_tiet).Name = "cboChi_tiet";
		ComboBox obj83 = cboChi_tiet;
		size = new Size(142, 21);
		((Control)obj83).Size = size;
		((Control)cboChi_tiet).TabIndex = 4;
		((Control)lblTen_nhkh).Enabled = false;
		lblTen_nhkh.ImeMode = (ImeMode)0;
		Label obj84 = lblTen_nhkh;
		location = new Point(333, 584);
		((Control)obj84).Location = location;
		((Control)lblTen_nhkh).Name = "lblTen_nhkh";
		Label obj85 = lblTen_nhkh;
		size = new Size(300, 13);
		((Control)obj85).Size = size;
		((Control)lblTen_nhkh).TabIndex = 1079;
		((Control)lblTen_nhkh).Visible = false;
		((TextBox)txtMa_nhkh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_nhkh.AutoLookup = true;
		txtMa_nhkh.AutoValid = false;
		((TextBoxBase)txtMa_nhkh).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhkh).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_nhkh).Enabled = false;
		AsTextBox asTextBox24 = txtMa_nhkh;
		location = new Point(245, 580);
		((Control)asTextBox24).Location = location;
		txtMa_nhkh.LookupCodeName = "MA_NHKH";
		((Control)txtMa_nhkh).Name = "txtMa_nhkh";
		txtMa_nhkh.NameControl = lblTen_nhkh;
		AsTextBox asTextBox25 = txtMa_nhkh;
		size = new Size(82, 20);
		((Control)asTextBox25).Size = size;
		((Control)txtMa_nhkh).TabIndex = 8;
		((Control)txtMa_nhkh).Tag = "MA_NHKH";
		txtMa_nhkh.UseAutoCompleteSource = true;
		((Control)txtMa_nhkh).Visible = false;
		lblMa_nhKh.AutoSize = true;
		((Control)lblMa_nhKh).Enabled = false;
		lblMa_nhKh.ImeMode = (ImeMode)0;
		Label obj86 = lblMa_nhKh;
		location = new Point(156, 584);
		((Control)obj86).Location = location;
		((Control)lblMa_nhKh).Name = "lblMa_nhKh";
		Label obj87 = lblMa_nhKh;
		size = new Size(69, 13);
		((Control)obj87).Size = size;
		((Control)lblMa_nhKh).TabIndex = 1078;
		lblMa_nhKh.Text = "Mã nhóm KH";
		lblMa_nhKh.TextAlign = (ContentAlignment)16;
		((Control)lblMa_nhKh).Visible = false;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox26 = txtMa_spct;
		location = new Point(159, 379);
		((Control)asTextBox26).Location = location;
		txtMa_spct.LookupCodeName = "ma_spct";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox27 = txtMa_spct;
		size = new Size(82, 20);
		((Control)asTextBox27).Size = size;
		((Control)txtMa_spct).TabIndex = 18;
		((Control)txtMa_spct).Tag = "";
		txtMa_spct.UseAutoCompleteSource = true;
		lblTen_spct.ImeMode = (ImeMode)0;
		Label obj88 = lblTen_spct;
		location = new Point(247, 382);
		((Control)obj88).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj89 = lblTen_spct;
		size = new Size(479, 13);
		((Control)obj89).Size = size;
		((Control)lblTen_spct).TabIndex = 1082;
		lblTen_spct.TextAlign = (ContentAlignment)16;
		Label1.AutoSize = true;
		Label1.ImeMode = (ImeMode)0;
		Label label = Label1;
		location = new Point(24, 383);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(53, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1081;
		Label1.Text = "Mã SPCT";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(357, 118);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(73, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 1083;
		Label2.Text = "Loại giao dịch";
		cboLoai_gd.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_gd).FormattingEnabled = true;
		ComboBox obj90 = cboLoai_gd;
		location = new Point(437, 114);
		((Control)obj90).Location = location;
		((Control)cboLoai_gd).Name = "cboLoai_gd";
		ComboBox obj91 = cboLoai_gd;
		size = new Size(142, 21);
		((Control)obj91).Size = size;
		((Control)cboLoai_gd).TabIndex = 6;
		Label8.AutoSize = true;
		Label label5 = Label8;
		location = new Point(24, 407);
		((Control)label5).Location = location;
		((Control)Label8).Name = "Label8";
		Label label6 = Label8;
		size = new Size(41, 13);
		((Control)label6).Size = size;
		((Control)Label8).TabIndex = 1387;
		Label8.Text = "Mã phí";
		Label obj92 = lblTenPhi;
		location = new Point(247, 406);
		((Control)obj92).Location = location;
		((Control)lblTenPhi).Name = "lblTenPhi";
		Label obj93 = lblTenPhi;
		size = new Size(479, 13);
		((Control)obj93).Size = size;
		((Control)lblTenPhi).TabIndex = 1386;
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox28 = txtMa_Phi;
		location = new Point(159, 403);
		((Control)asTextBox28).Location = location;
		txtMa_Phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		txtMa_Phi.NameControl = lblTenPhi;
		AsTextBox asTextBox29 = txtMa_Phi;
		size = new Size(82, 20);
		((Control)asTextBox29).Size = size;
		((Control)txtMa_Phi).TabIndex = 19;
		((Control)txtMa_Phi).Tag = "MA_PHI";
		txtMa_Phi.UseAutoCompleteSource = true;
		Label obj94 = lblTen_lo;
		location = new Point(247, 430);
		((Control)obj94).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj95 = lblTen_lo;
		size = new Size(479, 13);
		((Control)obj95).Size = size;
		((Control)lblTen_lo).TabIndex = 1384;
		txtMa_lo.AutoLookup = true;
		txtMa_lo.AutoValid = false;
		((TextBoxBase)txtMa_lo).BackColor = SystemColors.Info;
		((TextBox)txtMa_lo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox30 = txtMa_lo;
		location = new Point(159, 427);
		((Control)asTextBox30).Location = location;
		txtMa_lo.LookupCodeName = "MA_LO";
		((Control)txtMa_lo).Name = "txtMa_lo";
		txtMa_lo.NameControl = lblTen_lo;
		AsTextBox asTextBox31 = txtMa_lo;
		size = new Size(82, 20);
		((Control)asTextBox31).Size = size;
		((Control)txtMa_lo).TabIndex = 20;
		((Control)txtMa_lo).Tag = "MA_LO";
		txtMa_lo.UseAutoCompleteSource = true;
		lblMaLo.AutoSize = true;
		Label obj96 = lblMaLo;
		location = new Point(24, 431);
		((Control)obj96).Location = location;
		((Control)lblMaLo).Name = "lblMaLo";
		Label obj97 = lblMaLo;
		size = new Size(33, 13);
		((Control)obj97).Size = size;
		((Control)lblMaLo).TabIndex = 1385;
		lblMaLo.Text = "Mã lô";
		lblDVT.AutoSize = true;
		Label obj98 = lblDVT;
		location = new Point(24, 454);
		((Control)obj98).Location = location;
		((Control)lblDVT).Name = "lblDVT";
		Label obj99 = lblDVT;
		size = new Size(57, 13);
		((Control)obj99).Size = size;
		((Control)lblDVT).TabIndex = 1389;
		lblDVT.Text = "Theo ĐVT";
		cboDVT.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboDVT).FormattingEnabled = true;
		cboDVT.Items.AddRange(new object[4] { "Chứng từ", "Kho", "Mua", "Bán" });
		ComboBox obj100 = cboDVT;
		location = new Point(159, 451);
		((Control)obj100).Location = location;
		((Control)cboDVT).Name = "cboDVT";
		ComboBox obj101 = cboDVT;
		size = new Size(94, 21);
		((Control)obj101).Size = size;
		((Control)cboDVT).TabIndex = 21;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(1037, 655);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)lblTen_dangNX);
		((Control)this).Controls.Add((Control)(object)lblMa_NX);
		((Control)this).Controls.Add((Control)(object)txtMa_NX);
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmINRptTHX02";
		((Control)this).Controls.SetChildIndex((Control)(object)txtMa_NX, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblMa_NX, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen_dangNX, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		base.InitOtherComponents();
		cboLoai_px.DataSource = AsiaErp.Framework.Environment.GetDanhSachChungTuXuat();
		((ListControl)cboLoai_px).ValueMember = "Key";
		((ListControl)cboLoai_px).DisplayMember = "Value";
		cboLoai_px.SelectedIndex = 0;
		cboChi_tiet.SelectedIndex = 0;
		cboNhom.SelectedIndex = 0;
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		ComboBox val = cboNhom;
		dictionary.Add("MA_KH", Conversions.ToString(val.Items[0]));
		dictionary.Add("MA_NX", Conversions.ToString(val.Items[1]));
		dictionary.Add("MA_HD", Conversions.ToString(val.Items[2]));
		dictionary.Add("MA_SPCT", Conversions.ToString(val.Items[3]));
		dictionary.Add("MA_VT", Conversions.ToString(val.Items[4]));
		BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
		val.DataSource = dataSource;
		((ListControl)val).DisplayMember = "value";
		((ListControl)val).ValueMember = "key";
		val.SelectedIndex = 0;
		val = null;
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		ComboBox val2 = cboChi_tiet;
		dictionary2.Add("MA_KH", Conversions.ToString(val2.Items[0]));
		dictionary2.Add("MA_NX", Conversions.ToString(val2.Items[1]));
		dictionary2.Add("MA_HD", Conversions.ToString(val2.Items[2]));
		dictionary2.Add("MA_SPCT", Conversions.ToString(val2.Items[3]));
		dictionary2.Add("MA_VT", Conversions.ToString(val2.Items[4]));
		BindingSource dataSource2 = new BindingSource((object)dictionary2, (string)null);
		val2.DataSource = dataSource2;
		((ListControl)val2).DisplayMember = "value";
		((ListControl)val2).ValueMember = "key";
		val2.SelectedIndex = 0;
		val2 = null;
		Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
		ComboBox val3 = cboDVT;
		dictionary3.Add("0", Conversions.ToString(val3.Items[0]));
		dictionary3.Add("1", Conversions.ToString(val3.Items[1]));
		dictionary3.Add("2", Conversions.ToString(val3.Items[2]));
		dictionary3.Add("3", Conversions.ToString(val3.Items[3]));
		BindingSource dataSource3 = new BindingSource((object)dictionary3, (string)null);
		val3.DataSource = dataSource3;
		((ListControl)val3).DisplayMember = "value";
		((ListControl)val3).ValueMember = "key";
		val3.SelectedIndex = 0;
		val3 = null;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(txtSo_Ct1.Text);
		arrayList.Add(txtSo_Ct2.Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_px).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_gd).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboNhom).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboChi_tiet).SelectedValue));
		arrayList.Add(((TextBox)txtMa_Kh).Text);
		arrayList.Add(((TextBox)txtMa_nhkh).Text);
		arrayList.Add(((TextBox)txtMa_Hd).Text);
		arrayList.Add(((TextBox)txtMa_NX).Text);
		arrayList.Add(((TextBox)txtMa_kho_xuat).Text);
		arrayList.Add(((TextBox)txtKho_nhap).Text);
		arrayList.Add(((TextBox)txtMa_vitri).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add(((TextBox)txtTk_vt).Text);
		arrayList.Add(((TextBox)txtMa_Bp).Text);
		arrayList.Add(ChkTinh_Ps.TextValue);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(((TextBox)txtTk_Du).Text);
		arrayList.Add(((TextBox)txtMa_lo).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Phi).Text.Trim());
		if (optVND.Checked)
		{
			arrayList.Add("0");
		}
		else
		{
			arrayList.Add("1");
		}
		arrayList.Add(((TextBox)txtMa_spct).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboDVT).SelectedValue));
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		if (Operators.CompareString(MyReportInfo.ma_mau, "02", false) == 0)
		{
			base.MyFomularFields.Clear();
			base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
			base.MyFomularFields.Add("detailsType", RuntimeHelpers.GetObjectValue(((ListControl)cboChi_tiet).SelectedValue));
		}
		else
		{
			base.MyFomularFields.Clear();
			base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		}
		return true;
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		DataRowView dataRowView;
		ArrayList result;
		try
		{
			dataRowView = new DataView((DataTable)base.dgvBC.DataSource)[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index];
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			base.CancelDrilldown = true;
			result = null;
			ProjectData.ClearProjectError();
			goto IL_0af7;
		}
		ArrayList arrayList = new ArrayList();
		if (Operators.CompareString(MyReportInfo.ma_mau, "02", false) == 0)
		{
			if (Conversions.ToBoolean((Conversions.ToBoolean((object)((int)keycode != 116)) || Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false), (object)"", false), Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false), (object)"", false)))) ? ((object)true) : ((object)false)))
			{
				base.CancelDrilldown = true;
				result = null;
			}
			else
			{
				arrayList.Add(CompanyInformations.CompanyID);
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
				arrayList.Add(txtSo_Ct1.Text);
				arrayList.Add(txtSo_Ct2.Text);
				arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_px).SelectedValue));
				arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboNhom).SelectedValue));
				arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboChi_tiet).SelectedValue));
				if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom).SelectedValue, (object)"MA_KH", false))
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
				}
				else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChi_tiet).SelectedValue, (object)"MA_KH", false))
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
				}
				else
				{
					arrayList.Add(((TextBox)txtMa_Kh).Text);
				}
				arrayList.Add(((TextBox)txtMa_nhkh).Text);
				if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom).SelectedValue, (object)"MA_HD", false))
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
				}
				else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChi_tiet).SelectedValue, (object)"MA_HD", false))
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
				}
				else
				{
					arrayList.Add(((TextBox)txtMa_Hd).Text);
				}
				if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom).SelectedValue, (object)"MA_NX", false))
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
				}
				else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChi_tiet).SelectedValue, (object)"MA_NX", false))
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
				}
				else
				{
					arrayList.Add(((TextBox)txtMa_NX).Text);
				}
				arrayList.Add(((TextBox)txtMa_kho_xuat).Text);
				arrayList.Add(((TextBox)txtKho_nhap).Text);
				arrayList.Add(((TextBox)txtMa_vitri).Text);
				if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom).SelectedValue, (object)"MA_VT", false))
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
				}
				else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChi_tiet).SelectedValue, (object)"MA_VT", false))
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
				}
				else
				{
					arrayList.Add(((TextBox)txtMa_vt).Text);
				}
				arrayList.Add(((TextBox)txtMa_nhvt).Text);
				arrayList.Add(((TextBox)txtTk_vt).Text);
				if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom).SelectedValue, (object)"MA_SPCT", false))
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
				}
				else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChi_tiet).SelectedValue, (object)"MA_SPCT", false))
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
				}
				else
				{
					arrayList.Add(((TextBox)txtMa_spct).Text);
				}
				arrayList.Add(((TextBox)txtMa_Bp).Text);
				arrayList.Add(ChkTinh_Ps.TextValue);
				arrayList.Add(((TextBox)txtMa_Nt).Text);
				arrayList.Add(((TextBox)txtTk_Du).Text);
				arrayList.Add("");
				arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_gd).SelectedValue));
				if (!Information.IsDBNull((object)arrayList))
				{
					filterCondition4title = dataRowView["ma_group"].ToString() + "- " + dataRowView["ma_Detail"].ToString();
					goto IL_0af2;
				}
				base.CancelDrilldown = true;
				result = null;
			}
			goto IL_0af7;
		}
		if (Operators.CompareString(MyReportInfo.ma_mau, "01", false) == 0)
		{
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			arrayList.Add(txtSo_Ct1.Text);
			arrayList.Add(txtSo_Ct2.Text);
			arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_px).SelectedValue));
			arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboNhom).SelectedValue));
			arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboChi_tiet).SelectedValue));
			if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom).SelectedValue, (object)"MA_KH", false))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
			}
			else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChi_tiet).SelectedValue, (object)"MA_KH", false))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
			}
			else
			{
				arrayList.Add(((TextBox)txtMa_Kh).Text);
			}
			arrayList.Add(((TextBox)txtMa_nhkh).Text);
			if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom).SelectedValue, (object)"MA_HD", false))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
			}
			else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChi_tiet).SelectedValue, (object)"MA_HD", false))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
			}
			else
			{
				arrayList.Add(((TextBox)txtMa_Hd).Text);
			}
			if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom).SelectedValue, (object)"MA_NX", false))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
			}
			else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChi_tiet).SelectedValue, (object)"MA_NX", false))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
			}
			else
			{
				arrayList.Add(((TextBox)txtMa_NX).Text);
			}
			arrayList.Add(((TextBox)txtMa_kho_xuat).Text);
			arrayList.Add(((TextBox)txtKho_nhap).Text);
			arrayList.Add(((TextBox)txtMa_vitri).Text);
			if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom).SelectedValue, (object)"MA_VT", false))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
			}
			else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChi_tiet).SelectedValue, (object)"MA_VT", false))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
			}
			else
			{
				arrayList.Add(((TextBox)txtMa_vt).Text);
			}
			arrayList.Add(((TextBox)txtMa_nhvt).Text);
			arrayList.Add(((TextBox)txtTk_vt).Text);
			if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom).SelectedValue, (object)"MA_SPCT", false))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
			}
			else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChi_tiet).SelectedValue, (object)"MA_SPCT", false))
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
			}
			else
			{
				arrayList.Add(((TextBox)txtMa_spct).Text);
			}
			arrayList.Add(((TextBox)txtMa_Bp).Text);
			arrayList.Add(ChkTinh_Ps.TextValue);
			arrayList.Add(((TextBox)txtMa_Nt).Text);
			arrayList.Add(((TextBox)txtTk_Du).Text);
			arrayList.Add("");
			arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_gd).SelectedValue));
			if (Information.IsDBNull((object)arrayList))
			{
				base.CancelDrilldown = true;
				result = null;
				goto IL_0af7;
			}
			filterCondition4title = dataRowView["ma_group"].ToString() + "- " + dataRowView["ma_Detail"].ToString();
			if (!base.MyFomularFields.Contains("ngay_ct2"))
			{
				base.MyFomularFields.Add("ngay_ct2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			}
			if (!base.MyFomularFields.Contains("ngay_ct1"))
			{
				base.MyFomularFields.Add("ngay_ct1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			}
		}
		goto IL_0af2;
		IL_0af7:
		return result;
		IL_0af2:
		result = arrayList;
		goto IL_0af7;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (cboNhom.SelectedIndex != -1)
		{
			text = text + lblNhom.Text + ": [" + cboNhom.Text + "]; ";
		}
		if (cboChi_tiet.SelectedIndex != -1)
		{
			text = text + lblChi_tiet.Text + ": [" + cboChi_tiet.Text + "]; ";
		}
		if (cboLoai_px.SelectedIndex != -1)
		{
			text = text + lblMa_loaiPx.Text + ": [" + cboLoai_px.Text + "]; ";
		}
		if (Operators.CompareString(txtSo_Ct1.Text.Trim(), "", false) != 0)
		{
			text = text + lblSo_Ct1.Text + ": [" + txtSo_Ct1.Text.Trim() + "]; ";
		}
		if (Operators.CompareString(txtSo_Ct2.Text.Trim(), "", false) != 0)
		{
			text = text + lblSo_Ct2.Text + ": [" + txtSo_Ct2.Text.Trim() + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Kh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Kh.Text + ": [" + ((TextBox)txtMa_Kh).Text + " - " + lblTen_Kh.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhkh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nhKh.Text + ": [" + ((TextBox)txtMa_nhkh).Text + " - " + lblTen_nhkh.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
		{
			text = text + lblMa_vt.Text + ": [" + ((TextBox)txtMa_vt).Text + " - " + lblTen_vt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhvt).Text, "", false) != 0)
		{
			text = text + lblMa_nhvt.Text + ": [" + ((TextBox)txtMa_nhvt).Text + " - " + lblTen_nhvt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtTk_vt).Text.Trim(), "", false) != 0)
		{
			text = text + lblTk_vt.Text + ": [" + ((TextBox)txtTk_vt).Text + " - " + lblTen_Tkvt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtTk_Du).Text.Trim(), "", false) != 0)
		{
			text = text + lblTk_Du.Text + ": [" + ((TextBox)txtTk_Du).Text + " - " + lblTen_Tk_Du.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Bp).Text.Trim(), "", false) != 0)
		{
			text = text + lblTk_Du.Text + ": [" + ((TextBox)txtMa_Bp).Text + " - " + lblTen_Bp.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Hd).Text, "", false) != 0)
		{
			text = text + lblMa_Hd.Text + ": [" + ((TextBox)txtMa_Hd).Text + " - " + lblTen_Hd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_NX).Text, "", false) != 0)
		{
			text = text + lblMa_NX.Text + ": [" + ((TextBox)txtMa_NX).Text + " - " + lblTen_dangNX.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtKho_nhap).Text, "", false) != 0)
		{
			text = text + lblMa_kho_nhap.Text + ": [" + ((TextBox)txtKho_nhap).Text + " - " + lblTen_kho_nhap.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho_xuat).Text, "", false) != 0)
		{
			text = text + lblMa_kho_xuat.Text + ": [" + ((TextBox)txtMa_kho_xuat).Text + " - " + lblTen_kho_xuat.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vitri).Text, "", false) != 0)
		{
			text = text + lblMa_vitri.Text + ": [" + ((TextBox)txtMa_vitri).Text + " - " + lblTen_vitri.Text + "]; ";
		}
		if (Conversions.ToBoolean(ChkTinh_Ps.Checked))
		{
			text += ((ButtonBase)ChkTinh_Ps).Text;
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": [" + ((TextBox)txtMa_Nt).Text + "] ";
		}
		return text;
	}

	private void SetDataSourceToCmb(ComboBox combobox, ArrayList ar, string member, string value)
	{
		ArrayList arrayList = new ArrayList();
		DmMaGd dmMaGd = new DmMaGd();
		dmMaGd.ma_ct = ((ListControl)cboLoai_px).SelectedValue.ToString();
		dmMaGd.ma_gd = Conversions.ToString(0);
		dmMaGd.mo_ta = AsiaErp.Framework.Environment.getLangSysMessageResX("#SYS_ALL").value;
		dmMaGd.ngam_dinh = true;
		arrayList.Add(dmMaGd);
		if (ar != null)
		{
			foreach (DmMaGd item in ar)
			{
				arrayList.Add(item);
			}
		}
		combobox.DataSource = arrayList;
		((ListControl)combobox).DisplayMember = member;
		((ListControl)combobox).ValueMember = value;
		combobox.SelectedIndex = 0;
	}

	private void cboLoai_px_SelectedValueChanged(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			SetDataSourceToCmb(cboLoai_gd, AsiaErp.Framework.Environment.GetDmMagd(((ListControl)cboLoai_px).SelectedValue.ToString()), "mo_ta", "ma_gd");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}
}
