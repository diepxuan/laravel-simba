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
public class frmSORptTH01 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblLoai_hang")]
	private Label _lblLoai_hang;

	[AccessedThroughProperty("ChkTra_lai")]
	private AsCheckBox _ChkTra_lai;

	[AccessedThroughProperty("lblTru")]
	private Label _lblTru;

	[AccessedThroughProperty("ChkTra_ck")]
	private AsCheckBox _ChkTra_ck;

	[AccessedThroughProperty("ChkKhuyen_mai")]
	private AsCheckBox _ChkKhuyen_mai;

	[AccessedThroughProperty("ChkHang_ban")]
	private AsCheckBox _ChkHang_ban;

	[AccessedThroughProperty("cboLoaiPhieu")]
	private AsComboBox _cboLoaiPhieu;

	[AccessedThroughProperty("lblLoai_Phieu")]
	private Label _lblLoai_Phieu;

	[AccessedThroughProperty("lblTrang_Thai")]
	private Label _lblTrang_Thai;

	[AccessedThroughProperty("cboTrang_Thai")]
	private AsComboBox _cboTrang_Thai;

	[AccessedThroughProperty("txtMa_nvkd")]
	private AsTextBox _txtMa_nvkd;

	[AccessedThroughProperty("lblTen_nvkd")]
	private Label _lblTen_nvkd;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("lblMa_nvkd")]
	private Label _lblMa_nvkd;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("lblTen_TT")]
	private Label _lblTen_TT;

	[AccessedThroughProperty("txtMA_DKTT")]
	private AsTextBox _txtMA_DKTT;

	[AccessedThroughProperty("lblDkTT")]
	private Label _lblDkTT;

	[AccessedThroughProperty("lblTenHTTT")]
	private Label _lblTenHTTT;

	[AccessedThroughProperty("txtMA_HTTT")]
	private AsTextBox _txtMA_HTTT;

	[AccessedThroughProperty("lblHTTT")]
	private Label _lblHTTT;

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

	[AccessedThroughProperty("lblMa_nhhd")]
	private Label _lblMa_nhhd;

	[AccessedThroughProperty("txtMa_nhhd")]
	private AsTextBox _txtMa_nhhd;

	[AccessedThroughProperty("lblTen_nhhd")]
	private Label _lblTen_nhhd;

	[AccessedThroughProperty("lblTen_Hd")]
	private Label _lblTen_Hd;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

	[AccessedThroughProperty("lblMa_NhKh")]
	private Label _lblMa_NhKh;

	[AccessedThroughProperty("txtMa_NhKh")]
	private AsTextBox _txtMa_NhKh;

	[AccessedThroughProperty("lblTen_NhKh")]
	private Label _lblTen_NhKh;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("txtMa_plkh1")]
	private AsTextBox _txtMa_plkh1;

	[AccessedThroughProperty("lblTen_plkh1")]
	private Label _lblTen_plkh1;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("lblPLKh1")]
	private Label _lblPLKh1;

	[AccessedThroughProperty("lblTen_plkh2")]
	private Label _lblTen_plkh2;

	[AccessedThroughProperty("txtMa_plkh2")]
	private AsTextBox _txtMa_plkh2;

	[AccessedThroughProperty("lblPLKh2")]
	private Label _lblPLKh2;

	[AccessedThroughProperty("lblTen_plkh3")]
	private Label _lblTen_plkh3;

	[AccessedThroughProperty("txtMa_plkh3")]
	private AsTextBox _txtMa_plkh3;

	[AccessedThroughProperty("lblPLKh3")]
	private Label _lblPLKh3;

	[AccessedThroughProperty("txtMa_plvt1")]
	private AsTextBox _txtMa_plvt1;

	[AccessedThroughProperty("lblTen_plvt1")]
	private Label _lblTen_plvt1;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("lblPLVt1")]
	private Label _lblPLVt1;

	[AccessedThroughProperty("lblTen_plvt2")]
	private Label _lblTen_plvt2;

	[AccessedThroughProperty("txtMa_plvt2")]
	private AsTextBox _txtMa_plvt2;

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("lblPLVt2")]
	private Label _lblPLVt2;

	[AccessedThroughProperty("txtMaLo")]
	private AsTextBox _txtMaLo;

	[AccessedThroughProperty("lblTen_plvt3")]
	private Label _lblTen_plvt3;

	[AccessedThroughProperty("lblMaLo")]
	private Label _lblMaLo;

	[AccessedThroughProperty("txtMa_plvt3")]
	private AsTextBox _txtMa_plvt3;

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("lblPLVt3")]
	private Label _lblPLVt3;

	[AccessedThroughProperty("txtMa_vitri")]
	private AsTextBox _txtMa_vitri;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("lblMavitri")]
	private Label _lblMavitri;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	protected override ComboBox cboMau_bc
	{
		[DebuggerNonUserCode]
		get
		{
			return base.cboMau_bc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboMau_bc_SelectedIndexChanged;
			if (base.cboMau_bc != null)
			{
				base.cboMau_bc.SelectedIndexChanged -= eventHandler;
			}
			base.cboMau_bc = value;
			if (base.cboMau_bc != null)
			{
				base.cboMau_bc.SelectedIndexChanged += eventHandler;
			}
		}
	}

	private virtual Label lblLoai_hang
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai_hang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai_hang = value;
		}
	}

	internal virtual AsCheckBox ChkTra_lai
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkTra_lai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkTra_lai = value;
		}
	}

	private virtual Label lblTru
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTru;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTru = value;
		}
	}

	internal virtual AsCheckBox ChkTra_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkTra_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkTra_ck = value;
		}
	}

	internal virtual AsCheckBox ChkKhuyen_mai
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkKhuyen_mai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkKhuyen_mai = value;
		}
	}

	internal virtual AsCheckBox ChkHang_ban
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkHang_ban;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkHang_ban = value;
		}
	}

	internal virtual AsComboBox cboLoaiPhieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoaiPhieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoaiPhieu = value;
		}
	}

	internal virtual Label lblLoai_Phieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai_Phieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai_Phieu = value;
		}
	}

	internal virtual Label lblTrang_Thai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTrang_Thai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTrang_Thai = value;
		}
	}

	internal virtual AsComboBox cboTrang_Thai
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboTrang_Thai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboTrang_Thai = value;
		}
	}

	private virtual AsTextBox txtMa_nvkd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nvkd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nvkd = value;
		}
	}

	private virtual Label lblTen_nvkd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nvkd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nvkd = value;
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

	internal virtual Label lblMa_nvkd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nvkd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nvkd = value;
		}
	}

	internal virtual Label lblMa_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_bp = value;
		}
	}

	internal virtual Label lblTen_TT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TT = value;
		}
	}

	internal virtual AsTextBox txtMA_DKTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMA_DKTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMA_DKTT = value;
		}
	}

	internal virtual Label lblDkTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDkTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDkTT = value;
		}
	}

	internal virtual Label lblTenHTTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTenHTTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTenHTTT = value;
		}
	}

	internal virtual AsTextBox txtMA_HTTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMA_HTTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMA_HTTT = value;
		}
	}

	internal virtual Label lblHTTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblHTTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblHTTT = value;
		}
	}

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

	internal virtual Label lblMa_nhhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhhd = value;
		}
	}

	internal virtual AsTextBox txtMa_nhhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhhd = value;
		}
	}

	internal virtual Label lblTen_nhhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nhhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nhhd = value;
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

	internal virtual AsTextBox txtMa_hd
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

	internal virtual Label lblMa_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_hd = value;
		}
	}

	internal virtual Label lblMa_NhKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_NhKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_NhKh = value;
		}
	}

	internal virtual AsTextBox txtMa_NhKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_NhKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_NhKh = value;
		}
	}

	internal virtual Label lblTen_NhKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_NhKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_NhKh = value;
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

	internal virtual AsTextBox txtMa_plkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_plkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_plkh1 = value;
		}
	}

	internal virtual Label lblTen_plkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_plkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_plkh1 = value;
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

	internal virtual Label lblMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_spct = value;
		}
	}

	internal virtual Label lblPLKh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPLKh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPLKh1 = value;
		}
	}

	internal virtual Label lblTen_plkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_plkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_plkh2 = value;
		}
	}

	internal virtual AsTextBox txtMa_plkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_plkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_plkh2 = value;
		}
	}

	internal virtual Label lblPLKh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPLKh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPLKh2 = value;
		}
	}

	internal virtual Label lblTen_plkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_plkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_plkh3 = value;
		}
	}

	internal virtual AsTextBox txtMa_plkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_plkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_plkh3 = value;
		}
	}

	internal virtual Label lblPLKh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPLKh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPLKh3 = value;
		}
	}

	internal virtual AsTextBox txtMa_plvt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_plvt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_plvt1 = value;
		}
	}

	internal virtual Label lblTen_plvt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_plvt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_plvt1 = value;
		}
	}

	private virtual Label lblTen_Tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk = value;
		}
	}

	internal virtual Label lblPLVt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPLVt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPLVt1 = value;
		}
	}

	internal virtual Label lblTen_plvt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_plvt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_plvt2 = value;
		}
	}

	internal virtual AsTextBox txtMa_plvt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_plvt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_plvt2 = value;
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

	internal virtual Label lblPLVt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPLVt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPLVt2 = value;
		}
	}

	internal virtual AsTextBox txtMaLo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMaLo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMaLo = value;
		}
	}

	internal virtual Label lblTen_plvt3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_plvt3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_plvt3 = value;
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

	internal virtual AsTextBox txtMa_plvt3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_plvt3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_plvt3 = value;
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

	internal virtual Label lblPLVt3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPLVt3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPLVt3 = value;
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

	internal virtual AsTextBox txtMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kho = value;
		}
	}

	internal virtual Label lblTen_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kho = value;
		}
	}

	internal virtual Label lblMavitri
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMavitri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMavitri = value;
		}
	}

	internal virtual Label lblMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kho = value;
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

	public frmSORptTH01(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
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
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
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
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_42b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_42bf: Expected O, but got Unknown
		lblLoai_hang = new Label();
		ChkHang_ban = new AsCheckBox();
		ChkKhuyen_mai = new AsCheckBox();
		ChkTra_ck = new AsCheckBox();
		lblTru = new Label();
		ChkTra_lai = new AsCheckBox();
		cboLoaiPhieu = new AsComboBox();
		lblLoai_Phieu = new Label();
		lblTrang_Thai = new Label();
		cboTrang_Thai = new AsComboBox();
		txtMa_nvkd = new AsTextBox();
		lblTen_nvkd = new Label();
		txtMa_bp = new AsTextBox();
		lblTen_bp = new Label();
		lblMa_nvkd = new Label();
		lblMa_bp = new Label();
		lblTen_TT = new Label();
		txtMA_DKTT = new AsTextBox();
		lblDkTT = new Label();
		lblTenHTTT = new Label();
		txtMA_HTTT = new AsTextBox();
		lblHTTT = new Label();
		lblMa_nhvt = new Label();
		txtMa_nhvt = new AsTextBox();
		lblTen_nhvt = new Label();
		lblTen_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		lblMa_nhhd = new Label();
		txtMa_nhhd = new AsTextBox();
		lblTen_nhhd = new Label();
		lblTen_Hd = new Label();
		txtMa_hd = new AsTextBox();
		lblMa_hd = new Label();
		lblMa_NhKh = new Label();
		txtMa_NhKh = new AsTextBox();
		lblTen_NhKh = new Label();
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblTen_spct = new Label();
		txtMa_plkh1 = new AsTextBox();
		lblTen_plkh1 = new Label();
		txtMa_spct = new AsTextBox();
		lblMa_spct = new Label();
		lblPLKh1 = new Label();
		lblTen_plkh2 = new Label();
		txtMa_plkh2 = new AsTextBox();
		lblPLKh2 = new Label();
		lblTen_plkh3 = new Label();
		txtMa_plkh3 = new AsTextBox();
		lblPLKh3 = new Label();
		txtMa_plvt1 = new AsTextBox();
		lblTen_plvt1 = new Label();
		lblTen_Tk = new Label();
		lblPLVt1 = new Label();
		lblTen_plvt2 = new Label();
		txtMa_plvt2 = new AsTextBox();
		lblTen_lo = new Label();
		lblPLVt2 = new Label();
		txtMaLo = new AsTextBox();
		lblTen_plvt3 = new Label();
		lblMaLo = new Label();
		txtMa_plvt3 = new AsTextBox();
		lblTen_vitri = new Label();
		lblPLVt3 = new Label();
		txtMa_vitri = new AsTextBox();
		txtMa_kho = new AsTextBox();
		lblTen_kho = new Label();
		lblMavitri = new Label();
		lblMa_kho = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)AsTabControl).Cursor = Cursors.Arrow;
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(960, 566);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoaiPhieu);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLKh1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoai_Phieu);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLKh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTrang_Thai);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)cboTrang_Thai);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLKh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)ChkTra_lai);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_TT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTru);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLVt1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_DKTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)ChkTra_ck);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblDkTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lo);
		((Control)tabFilter).Controls.Add((Control)(object)ChkKhuyen_mai);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLVt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTenHTTT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)ChkHang_ban);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_HTTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoai_hang);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblHTTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLVt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMavitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_NhKh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_NhKh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_NhKh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Kh);
		((Control)tabFilter).Cursor = Cursors.Arrow;
		TabPage obj = tabFilter;
		size = new Size(952, 537);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_NhKh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_NhKh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_NhKh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMavitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLVt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblHTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoai_hang, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_HTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkHang_ban, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTenHTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLVt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkKhuyen_mai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDkTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkTra_ck, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_DKTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLVt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTru, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_TT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkTra_lai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLKh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboTrang_Thai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTrang_Thai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLKh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoai_Phieu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLKh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoaiPhieu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		Label obj2 = lbl2;
		Point location = new Point(342, 69);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 3;
		Button obj3 = cmdExcel;
		location = new Point(845, 558);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(361, 65);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(764, 558);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(520, 14);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 201;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(271, 65);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(173, 65);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(20, 69);
		((Control)obj7).Location = location;
		((Control)lblKyBc).TabIndex = 0;
		ComboBox obj8 = cboMau_bc;
		location = new Point(173, 16);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 200;
		Label obj9 = lblMau_bc;
		location = new Point(20, 19);
		((Control)obj9).Location = location;
		((Control)lblMau_bc).TabIndex = 59;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(173, 450);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 19;
		Label obj10 = lblMauBC;
		location = new Point(218, 454);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 8;
		RadioButton obj11 = optVND;
		location = new Point(305, 452);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 20;
		RadioButton obj12 = optNt;
		location = new Point(359, 452);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 21;
		Label obj13 = lblMa_nt;
		location = new Point(20, 452);
		((Control)obj13).Location = location;
		((Control)lblMa_nt).TabIndex = 6;
		Button obj14 = cmdOk;
		location = new Point(20, 487);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 22;
		Label obj15 = lblTieu_de;
		location = new Point(20, 45);
		((Control)obj15).Location = location;
		((Control)lblTieu_de).TabIndex = 62;
		TextBox obj16 = txtTieu_De;
		location = new Point(173, 41);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 202;
		TabPage obj17 = tabGrid;
		size = new Size(952, 537);
		((Control)obj17).Size = size;
		lblLoai_hang.AutoSize = true;
		((Control)lblLoai_hang).Enabled = false;
		lblLoai_hang.ImeMode = (ImeMode)0;
		Label obj18 = lblLoai_hang;
		location = new Point(472, 529);
		((Control)obj18).Location = location;
		((Control)lblLoai_hang).Name = "lblLoai_hang";
		Label obj19 = lblLoai_hang;
		size = new Size(54, 13);
		((Control)obj19).Size = size;
		((Control)lblLoai_hang).TabIndex = 47;
		lblLoai_hang.Text = "Loại hàng";
		((Control)lblLoai_hang).Visible = false;
		((ButtonBase)ChkHang_ban).AutoSize = true;
		ChkHang_ban.Checked = true;
		((CheckBox)ChkHang_ban).CheckState = (CheckState)1;
		((Control)ChkHang_ban).Enabled = false;
		AsCheckBox chkHang_ban = ChkHang_ban;
		location = new Point(560, 528);
		((Control)chkHang_ban).Location = location;
		((Control)ChkHang_ban).Name = "ChkHang_ban";
		AsCheckBox chkHang_ban2 = ChkHang_ban;
		size = new Size(73, 17);
		((Control)chkHang_ban2).Size = size;
		((Control)ChkHang_ban).TabIndex = 25;
		((ButtonBase)ChkHang_ban).Text = "Hàng bán";
		((CheckBox)ChkHang_ban).ThreeState = true;
		((ButtonBase)ChkHang_ban).UseVisualStyleBackColor = true;
		((Control)ChkHang_ban).Visible = false;
		((ButtonBase)ChkKhuyen_mai).AutoSize = true;
		ChkKhuyen_mai.Checked = false;
		((Control)ChkKhuyen_mai).Enabled = false;
		AsCheckBox chkKhuyen_mai = ChkKhuyen_mai;
		location = new Point(639, 528);
		((Control)chkKhuyen_mai).Location = location;
		((Control)ChkKhuyen_mai).Name = "ChkKhuyen_mai";
		AsCheckBox chkKhuyen_mai2 = ChkKhuyen_mai;
		size = new Size(91, 17);
		((Control)chkKhuyen_mai2).Size = size;
		((Control)ChkKhuyen_mai).TabIndex = 26;
		((ButtonBase)ChkKhuyen_mai).Text = "Hàng trả K/M";
		ChkKhuyen_mai.TextValue = "0";
		((CheckBox)ChkKhuyen_mai).ThreeState = true;
		ChkKhuyen_mai.TrueValue = "0";
		((ButtonBase)ChkKhuyen_mai).UseVisualStyleBackColor = true;
		((Control)ChkKhuyen_mai).Visible = false;
		((ButtonBase)ChkTra_ck).AutoSize = true;
		ChkTra_ck.Checked = false;
		((Control)ChkTra_ck).Enabled = false;
		AsCheckBox chkTra_ck = ChkTra_ck;
		location = new Point(736, 528);
		((Control)chkTra_ck).Location = location;
		((Control)ChkTra_ck).Name = "ChkTra_ck";
		AsCheckBox chkTra_ck2 = ChkTra_ck;
		size = new Size(105, 17);
		((Control)chkTra_ck2).Size = size;
		((Control)ChkTra_ck).TabIndex = 27;
		((ButtonBase)ChkTra_ck).Text = "Hàng chiết khấu";
		ChkTra_ck.TextValue = "0";
		((CheckBox)ChkTra_ck).ThreeState = true;
		ChkTra_ck.TrueValue = "0";
		((ButtonBase)ChkTra_ck).UseVisualStyleBackColor = true;
		((Control)ChkTra_ck).Visible = false;
		lblTru.AutoSize = true;
		((Control)lblTru).Enabled = false;
		lblTru.ImeMode = (ImeMode)0;
		Label obj20 = lblTru;
		location = new Point(472, 512);
		((Control)obj20).Location = location;
		((Control)lblTru).Name = "lblTru";
		Label obj21 = lblTru;
		size = new Size(23, 13);
		((Control)obj21).Size = size;
		((Control)lblTru).TabIndex = 51;
		lblTru.Text = "Trừ";
		((Control)lblTru).Visible = false;
		((ButtonBase)ChkTra_lai).AutoSize = true;
		ChkTra_lai.Checked = false;
		((Control)ChkTra_lai).Enabled = false;
		AsCheckBox chkTra_lai = ChkTra_lai;
		location = new Point(560, 507);
		((Control)chkTra_lai).Location = location;
		((Control)ChkTra_lai).Name = "ChkTra_lai";
		AsCheckBox chkTra_lai2 = ChkTra_lai;
		size = new Size(101, 17);
		((Control)chkTra_lai2).Size = size;
		((Control)ChkTra_lai).TabIndex = 28;
		((ButtonBase)ChkTra_lai).Text = "Hàng bán trả lại";
		ChkTra_lai.TextValue = "0";
		((CheckBox)ChkTra_lai).ThreeState = true;
		ChkTra_lai.TrueValue = "0";
		((ButtonBase)ChkTra_lai).UseVisualStyleBackColor = true;
		((Control)ChkTra_lai).Visible = false;
		((ComboBox)cboLoaiPhieu).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoaiPhieu).FormattingEnabled = true;
		((ComboBox)cboLoaiPhieu).Items.AddRange(new object[1] { "Tất cả" });
		AsComboBox asComboBox = cboLoaiPhieu;
		location = new Point(173, 90);
		((Control)asComboBox).Location = location;
		((Control)cboLoaiPhieu).Name = "cboLoaiPhieu";
		AsComboBox asComboBox2 = cboLoaiPhieu;
		size = new Size(145, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboLoaiPhieu).TabIndex = 3;
		lblLoai_Phieu.AutoSize = true;
		Label obj22 = lblLoai_Phieu;
		location = new Point(20, 93);
		((Control)obj22).Location = location;
		((Control)lblLoai_Phieu).Name = "lblLoai_Phieu";
		Label obj23 = lblLoai_Phieu;
		size = new Size(56, 13);
		((Control)obj23).Size = size;
		((Control)lblLoai_Phieu).TabIndex = 1186;
		lblLoai_Phieu.Text = "Loại phiếu";
		lblTrang_Thai.AutoSize = true;
		((Control)lblTrang_Thai).Enabled = false;
		Label obj24 = lblTrang_Thai;
		location = new Point(326, 93);
		((Control)obj24).Location = location;
		((Control)lblTrang_Thai).Name = "lblTrang_Thai";
		Label obj25 = lblTrang_Thai;
		size = new Size(55, 13);
		((Control)obj25).Size = size;
		((Control)lblTrang_Thai).TabIndex = 1185;
		lblTrang_Thai.Text = "Trạng thái";
		((Control)lblTrang_Thai).Visible = false;
		((ComboBox)cboTrang_Thai).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboTrang_Thai).Enabled = false;
		((ListControl)cboTrang_Thai).FormattingEnabled = true;
		((ComboBox)cboTrang_Thai).Items.AddRange(new object[1] { "Tất cả" });
		AsComboBox asComboBox3 = cboTrang_Thai;
		location = new Point(387, 90);
		((Control)asComboBox3).Location = location;
		((Control)cboTrang_Thai).Name = "cboTrang_Thai";
		AsComboBox asComboBox4 = cboTrang_Thai;
		size = new Size(208, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboTrang_Thai).TabIndex = 4;
		((Control)cboTrang_Thai).Visible = false;
		((TextBox)txtMa_nvkd).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_nvkd.AutoLookup = true;
		txtMa_nvkd.AutoValid = false;
		((TextBoxBase)txtMa_nvkd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nvkd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_nvkd;
		location = new Point(173, 331);
		((Control)asTextBox2).Location = location;
		txtMa_nvkd.LookupCodeName = "Ma_nvkd";
		((Control)txtMa_nvkd).Name = "txtMa_nvkd";
		txtMa_nvkd.NameControl = lblTen_nvkd;
		AsTextBox asTextBox3 = txtMa_nvkd;
		size = new Size(88, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_nvkd).TabIndex = 14;
		((Control)txtMa_nvkd).Tag = "@pMa_nvkd";
		txtMa_nvkd.UseAutoCompleteSource = true;
		lblTen_nvkd.ImeMode = (ImeMode)0;
		Label obj26 = lblTen_nvkd;
		location = new Point(266, 335);
		((Control)obj26).Location = location;
		((Control)lblTen_nvkd).Name = "lblTen_nvkd";
		Label obj27 = lblTen_nvkd;
		size = new Size(464, 13);
		((Control)obj27).Size = size;
		((Control)lblTen_nvkd).TabIndex = 1275;
		lblTen_nvkd.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_bp;
		location = new Point(173, 307);
		((Control)asTextBox4).Location = location;
		txtMa_bp.LookupCodeName = "Ma_bp";
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox5 = txtMa_bp;
		size = new Size(88, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_bp).TabIndex = 13;
		((Control)txtMa_bp).Tag = "@pMa_bp";
		txtMa_bp.UseAutoCompleteSource = true;
		lblTen_bp.ImeMode = (ImeMode)0;
		Label obj28 = lblTen_bp;
		location = new Point(266, 311);
		((Control)obj28).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj29 = lblTen_bp;
		size = new Size(464, 13);
		((Control)obj29).Size = size;
		((Control)lblTen_bp).TabIndex = 1274;
		lblTen_bp.TextAlign = (ContentAlignment)16;
		lblMa_nvkd.AutoSize = true;
		Label obj30 = lblMa_nvkd;
		location = new Point(20, 335);
		((Control)obj30).Location = location;
		((Control)lblMa_nvkd).Name = "lblMa_nvkd";
		Label obj31 = lblMa_nvkd;
		size = new Size(55, 13);
		((Control)obj31).Size = size;
		((Control)lblMa_nvkd).TabIndex = 1273;
		lblMa_nvkd.Text = "Mã NVKD";
		lblMa_bp.AutoSize = true;
		Label obj32 = lblMa_bp;
		location = new Point(20, 311);
		((Control)obj32).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj33 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj33).Size = size;
		((Control)lblMa_bp).TabIndex = 1272;
		lblMa_bp.Text = "Mã bộ phận";
		((Control)lblTen_TT).Enabled = false;
		Label obj34 = lblTen_TT;
		location = new Point(820, 321);
		((Control)obj34).Location = location;
		((Control)lblTen_TT).Name = "lblTen_TT";
		Label obj35 = lblTen_TT;
		size = new Size(252, 13);
		((Control)obj35).Size = size;
		((Control)lblTen_TT).TabIndex = 1270;
		((Control)lblTen_TT).Visible = false;
		txtMA_DKTT.AutoLookup = true;
		txtMA_DKTT.AutoValid = false;
		((TextBoxBase)txtMA_DKTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_DKTT).CharacterCasing = (CharacterCasing)1;
		((Control)txtMA_DKTT).Enabled = false;
		AsTextBox asTextBox6 = txtMA_DKTT;
		location = new Point(726, 318);
		((Control)asTextBox6).Location = location;
		txtMA_DKTT.LookupCodeName = "MA_TT";
		((Control)txtMA_DKTT).Name = "txtMA_DKTT";
		txtMA_DKTT.NameControl = lblTen_TT;
		AsTextBox asTextBox7 = txtMA_DKTT;
		size = new Size(88, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMA_DKTT).TabIndex = 9;
		((Control)txtMA_DKTT).Tag = "MA_TT";
		txtMA_DKTT.UseAutoCompleteSource = true;
		((Control)txtMA_DKTT).Visible = false;
		lblDkTT.AutoSize = true;
		((Control)lblDkTT).Enabled = false;
		Label obj36 = lblDkTT;
		location = new Point(638, 324);
		((Control)obj36).Location = location;
		((Control)lblDkTT).Name = "lblDkTT";
		Label obj37 = lblDkTT;
		size = new Size(79, 13);
		((Control)obj37).Size = size;
		((Control)lblDkTT).TabIndex = 1271;
		lblDkTT.Text = "Điều khoản TT";
		((Control)lblDkTT).Visible = false;
		Label obj38 = lblTenHTTT;
		location = new Point(266, 359);
		((Control)obj38).Location = location;
		((Control)lblTenHTTT).Name = "lblTenHTTT";
		Label obj39 = lblTenHTTT;
		size = new Size(464, 13);
		((Control)obj39).Size = size;
		((Control)lblTenHTTT).TabIndex = 1268;
		txtMA_HTTT.AutoLookup = true;
		txtMA_HTTT.AutoValid = false;
		((TextBoxBase)txtMA_HTTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_HTTT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMA_HTTT;
		location = new Point(173, 355);
		((Control)asTextBox8).Location = location;
		txtMA_HTTT.LookupCodeName = "MA_HTTT";
		txtMA_HTTT.LookupWhereCondition = "moduleid='so'";
		((Control)txtMA_HTTT).Name = "txtMA_HTTT";
		txtMA_HTTT.NameControl = lblTenHTTT;
		AsTextBox asTextBox9 = txtMA_HTTT;
		size = new Size(88, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMA_HTTT).TabIndex = 15;
		((Control)txtMA_HTTT).Tag = "MA_HTTT";
		txtMA_HTTT.UseAutoCompleteSource = true;
		lblHTTT.AutoSize = true;
		Label obj40 = lblHTTT;
		location = new Point(20, 359);
		((Control)obj40).Location = location;
		((Control)lblHTTT).Name = "lblHTTT";
		Label obj41 = lblHTTT;
		size = new Size(70, 13);
		((Control)obj41).Size = size;
		((Control)lblHTTT).TabIndex = 1269;
		lblHTTT.Text = "Hình thức TT";
		lblMa_nhvt.AutoSize = true;
		lblMa_nhvt.ImeMode = (ImeMode)0;
		Label obj42 = lblMa_nhvt;
		location = new Point(20, 287);
		((Control)obj42).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj43 = lblMa_nhvt;
		size = new Size(65, 13);
		((Control)obj43).Size = size;
		((Control)lblMa_nhvt).TabIndex = 1255;
		lblMa_nhvt.Text = "Nhóm vật tư";
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_nhvt;
		location = new Point(173, 283);
		((Control)asTextBox10).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((TextBoxBase)txtMa_nhvt).MaxLength = 8;
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_nhvt;
		AsTextBox asTextBox11 = txtMa_nhvt;
		size = new Size(88, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_nhvt).TabIndex = 12;
		((Control)txtMa_nhvt).Tag = "MA_NHVT";
		txtMa_nhvt.UseAutoCompleteSource = true;
		lblTen_nhvt.ImeMode = (ImeMode)0;
		Label obj44 = lblTen_nhvt;
		location = new Point(266, 287);
		((Control)obj44).Location = location;
		((Control)lblTen_nhvt).Name = "lblTen_nhvt";
		Label obj45 = lblTen_nhvt;
		size = new Size(464, 13);
		((Control)obj45).Size = size;
		((Control)lblTen_nhvt).TabIndex = 1256;
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj46 = lblTen_vt;
		location = new Point(266, 263);
		((Control)obj46).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj47 = lblTen_vt;
		size = new Size(464, 13);
		((Control)obj47).Size = size;
		((Control)lblTen_vt).TabIndex = 1254;
		((TextBox)txtMa_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_vt;
		location = new Point(173, 259);
		((Control)asTextBox12).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox13 = txtMa_vt;
		size = new Size(88, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_vt).TabIndex = 11;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_vt.AutoSize = true;
		lblMa_vt.ImeMode = (ImeMode)0;
		Label obj48 = lblMa_vt;
		location = new Point(20, 263);
		((Control)obj48).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj49 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj49).Size = size;
		((Control)lblMa_vt).TabIndex = 1253;
		lblMa_vt.Text = "Mã vật tư";
		lblMa_nhhd.AutoSize = true;
		lblMa_nhhd.ImeMode = (ImeMode)0;
		Label obj50 = lblMa_nhhd;
		location = new Point(20, 239);
		((Control)obj50).Location = location;
		((Control)lblMa_nhhd).Name = "lblMa_nhhd";
		Label obj51 = lblMa_nhhd;
		size = new Size(84, 13);
		((Control)obj51).Size = size;
		((Control)lblMa_nhhd).TabIndex = 1248;
		lblMa_nhhd.Text = "Nhóm hợp đồng";
		txtMa_nhhd.AutoLookup = true;
		txtMa_nhhd.AutoValid = false;
		((TextBoxBase)txtMa_nhhd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhhd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_nhhd;
		location = new Point(173, 235);
		((Control)asTextBox14).Location = location;
		txtMa_nhhd.LookupCodeName = "MA_NHHD";
		((TextBoxBase)txtMa_nhhd).MaxLength = 8;
		((Control)txtMa_nhhd).Name = "txtMa_nhhd";
		txtMa_nhhd.NameControl = lblTen_nhhd;
		AsTextBox asTextBox15 = txtMa_nhhd;
		size = new Size(88, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_nhhd).TabIndex = 10;
		((Control)txtMa_nhhd).Tag = "MA_NHHD";
		txtMa_nhhd.UseAutoCompleteSource = true;
		lblTen_nhhd.ImeMode = (ImeMode)0;
		Label obj52 = lblTen_nhhd;
		location = new Point(266, 239);
		((Control)obj52).Location = location;
		((Control)lblTen_nhhd).Name = "lblTen_nhhd";
		Label obj53 = lblTen_nhhd;
		size = new Size(464, 13);
		((Control)obj53).Size = size;
		((Control)lblTen_nhhd).TabIndex = 1250;
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj54 = lblTen_Hd;
		location = new Point(266, 215);
		((Control)obj54).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj55 = lblTen_Hd;
		size = new Size(464, 13);
		((Control)obj55).Size = size;
		((Control)lblTen_Hd).TabIndex = 1245;
		((TextBox)txtMa_hd).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox16 = txtMa_hd;
		location = new Point(173, 211);
		((Control)asTextBox16).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_Hd;
		AsTextBox asTextBox17 = txtMa_hd;
		size = new Size(88, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtMa_hd).TabIndex = 9;
		((Control)txtMa_hd).Tag = "MA_HD";
		txtMa_hd.UseAutoCompleteSource = true;
		lblMa_hd.AutoSize = true;
		lblMa_hd.ImeMode = (ImeMode)0;
		Label obj56 = lblMa_hd;
		location = new Point(20, 215);
		((Control)obj56).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj57 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj57).Size = size;
		((Control)lblMa_hd).TabIndex = 1242;
		lblMa_hd.Text = "Mã hợp đồng";
		lblMa_NhKh.AutoSize = true;
		((Control)lblMa_NhKh).Enabled = false;
		lblMa_NhKh.ImeMode = (ImeMode)0;
		Label obj58 = lblMa_NhKh;
		location = new Point(638, 298);
		((Control)obj58).Location = location;
		((Control)lblMa_NhKh).Name = "lblMa_NhKh";
		Label obj59 = lblMa_NhKh;
		size = new Size(69, 13);
		((Control)obj59).Size = size;
		((Control)lblMa_NhKh).TabIndex = 1222;
		lblMa_NhKh.Text = "Mã nhóm KH";
		((Control)lblMa_NhKh).Visible = false;
		txtMa_NhKh.AutoLookup = true;
		txtMa_NhKh.AutoValid = false;
		((TextBoxBase)txtMa_NhKh).BackColor = SystemColors.Info;
		((TextBox)txtMa_NhKh).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_NhKh).Enabled = false;
		AsTextBox asTextBox18 = txtMa_NhKh;
		location = new Point(726, 292);
		((Control)asTextBox18).Location = location;
		txtMa_NhKh.LookupCodeName = "MA_NHKH";
		((TextBoxBase)txtMa_NhKh).MaxLength = 8;
		((Control)txtMa_NhKh).Name = "txtMa_NhKh";
		txtMa_NhKh.NameControl = lblTen_NhKh;
		AsTextBox asTextBox19 = txtMa_NhKh;
		size = new Size(88, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtMa_NhKh).TabIndex = 1;
		((Control)txtMa_NhKh).Tag = "MA_NHKH";
		txtMa_NhKh.UseAutoCompleteSource = true;
		((Control)txtMa_NhKh).Visible = false;
		((Control)lblTen_NhKh).Enabled = false;
		lblTen_NhKh.ImeMode = (ImeMode)0;
		Label obj60 = lblTen_NhKh;
		location = new Point(820, 296);
		((Control)obj60).Location = location;
		((Control)lblTen_NhKh).Name = "lblTen_NhKh";
		Label obj61 = lblTen_NhKh;
		size = new Size(252, 13);
		((Control)obj61).Size = size;
		((Control)lblTen_NhKh).TabIndex = 1226;
		((Control)lblTen_NhKh).Visible = false;
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj62 = lblTen_Kh;
		location = new Point(266, 119);
		((Control)obj62).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj63 = lblTen_Kh;
		size = new Size(464, 13);
		((Control)obj63).Size = size;
		((Control)lblTen_Kh).TabIndex = 1221;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = false;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtMa_Kh;
		location = new Point(173, 115);
		((Control)asTextBox20).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		txtMa_Kh.LookupWhereCondition = "isKh=1";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		AsTextBox asTextBox21 = txtMa_Kh;
		size = new Size(88, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMa_Kh).TabIndex = 5;
		((Control)txtMa_Kh).Tag = "MA_KH";
		txtMa_Kh.UseAutoCompleteSource = true;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj64 = lblMa_Kh;
		location = new Point(20, 119);
		((Control)obj64).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj65 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj65).Size = size;
		((Control)lblMa_Kh).TabIndex = 1218;
		lblMa_Kh.Text = "Mã khách hàng";
		Label obj66 = lblTen_spct;
		location = new Point(266, 431);
		((Control)obj66).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj67 = lblTen_spct;
		size = new Size(464, 13);
		((Control)obj67).Size = size;
		((Control)lblTen_spct).TabIndex = 1276;
		txtMa_plkh1.AutoLookup = true;
		txtMa_plkh1.AutoValid = false;
		((TextBoxBase)txtMa_plkh1).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox22 = txtMa_plkh1;
		location = new Point(173, 139);
		((Control)asTextBox22).Location = location;
		txtMa_plkh1.LookupCodeName = "MA_PLKH";
		txtMa_plkh1.LookupWhereCondition = "loai=1";
		((TextBoxBase)txtMa_plkh1).MaxLength = 8;
		((Control)txtMa_plkh1).Name = "txtMa_plkh1";
		txtMa_plkh1.NameControl = lblTen_plkh1;
		AsTextBox asTextBox23 = txtMa_plkh1;
		size = new Size(88, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMa_plkh1).TabIndex = 6;
		((Control)txtMa_plkh1).Tag = "MA_PLKH1";
		txtMa_plkh1.UseAutoCompleteSource = true;
		lblTen_plkh1.ImeMode = (ImeMode)0;
		Label obj68 = lblTen_plkh1;
		location = new Point(266, 143);
		((Control)obj68).Location = location;
		((Control)lblTen_plkh1).Name = "lblTen_plkh1";
		Label obj69 = lblTen_plkh1;
		size = new Size(464, 13);
		((Control)obj69).Size = size;
		((Control)lblTen_plkh1).TabIndex = 1231;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox24 = txtMa_spct;
		location = new Point(173, 427);
		((Control)asTextBox24).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox25 = txtMa_spct;
		size = new Size(88, 20);
		((Control)asTextBox25).Size = size;
		((Control)txtMa_spct).TabIndex = 18;
		((Control)txtMa_spct).Tag = "MA_SPCT";
		txtMa_spct.UseAutoCompleteSource = true;
		lblMa_spct.AutoSize = true;
		Label obj70 = lblMa_spct;
		location = new Point(20, 431);
		((Control)obj70).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj71 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj71).Size = size;
		((Control)lblMa_spct).TabIndex = 1277;
		lblMa_spct.Text = "Mã SPCT";
		lblPLKh1.AutoSize = true;
		lblPLKh1.ImeMode = (ImeMode)0;
		Label obj72 = lblPLKh1;
		location = new Point(20, 143);
		((Control)obj72).Location = location;
		((Control)lblPLKh1).Name = "lblPLKh1";
		Label obj73 = lblPLKh1;
		size = new Size(61, 13);
		((Control)obj73).Size = size;
		((Control)lblPLKh1).TabIndex = 1228;
		lblPLKh1.Text = "P.Loại KH1";
		lblTen_plkh2.ImeMode = (ImeMode)0;
		Label obj74 = lblTen_plkh2;
		location = new Point(266, 167);
		((Control)obj74).Location = location;
		((Control)lblTen_plkh2).Name = "lblTen_plkh2";
		Label obj75 = lblTen_plkh2;
		size = new Size(464, 13);
		((Control)obj75).Size = size;
		((Control)lblTen_plkh2).TabIndex = 1236;
		txtMa_plkh2.AutoLookup = true;
		txtMa_plkh2.AutoValid = false;
		((TextBoxBase)txtMa_plkh2).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox26 = txtMa_plkh2;
		location = new Point(173, 163);
		((Control)asTextBox26).Location = location;
		txtMa_plkh2.LookupCodeName = "MA_PLKH";
		txtMa_plkh2.LookupWhereCondition = "loai=2";
		((TextBoxBase)txtMa_plkh2).MaxLength = 8;
		((Control)txtMa_plkh2).Name = "txtMa_plkh2";
		txtMa_plkh2.NameControl = lblTen_plkh2;
		AsTextBox asTextBox27 = txtMa_plkh2;
		size = new Size(88, 20);
		((Control)asTextBox27).Size = size;
		((Control)txtMa_plkh2).TabIndex = 7;
		((Control)txtMa_plkh2).Tag = "MA_PLKH2";
		txtMa_plkh2.UseAutoCompleteSource = true;
		lblPLKh2.AutoSize = true;
		lblPLKh2.ImeMode = (ImeMode)0;
		Label obj76 = lblPLKh2;
		location = new Point(20, 167);
		((Control)obj76).Location = location;
		((Control)lblPLKh2).Name = "lblPLKh2";
		Label obj77 = lblPLKh2;
		size = new Size(61, 13);
		((Control)obj77).Size = size;
		((Control)lblPLKh2).TabIndex = 1232;
		lblPLKh2.Text = "P.Loại KH2";
		lblTen_plkh3.ImeMode = (ImeMode)0;
		Label obj78 = lblTen_plkh3;
		location = new Point(266, 191);
		((Control)obj78).Location = location;
		((Control)lblTen_plkh3).Name = "lblTen_plkh3";
		Label obj79 = lblTen_plkh3;
		size = new Size(464, 13);
		((Control)obj79).Size = size;
		((Control)lblTen_plkh3).TabIndex = 1240;
		txtMa_plkh3.AutoLookup = true;
		txtMa_plkh3.AutoValid = false;
		((TextBoxBase)txtMa_plkh3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox28 = txtMa_plkh3;
		location = new Point(173, 187);
		((Control)asTextBox28).Location = location;
		txtMa_plkh3.LookupCodeName = "MA_PLKH";
		txtMa_plkh3.LookupWhereCondition = "loai=3";
		((TextBoxBase)txtMa_plkh3).MaxLength = 8;
		((Control)txtMa_plkh3).Name = "txtMa_plkh3";
		txtMa_plkh3.NameControl = lblTen_plkh3;
		AsTextBox asTextBox29 = txtMa_plkh3;
		size = new Size(88, 20);
		((Control)asTextBox29).Size = size;
		((Control)txtMa_plkh3).TabIndex = 8;
		((Control)txtMa_plkh3).Tag = "MA_PLKH3";
		txtMa_plkh3.UseAutoCompleteSource = true;
		lblPLKh3.AutoSize = true;
		lblPLKh3.ImeMode = (ImeMode)0;
		Label obj80 = lblPLKh3;
		location = new Point(20, 191);
		((Control)obj80).Location = location;
		((Control)lblPLKh3).Name = "lblPLKh3";
		Label obj81 = lblPLKh3;
		size = new Size(61, 13);
		((Control)obj81).Size = size;
		((Control)lblPLKh3).TabIndex = 1238;
		lblPLKh3.Text = "P.Loại KH3";
		txtMa_plvt1.AutoLookup = true;
		txtMa_plvt1.AutoValid = false;
		((TextBoxBase)txtMa_plvt1).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt1).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt1).Enabled = false;
		AsTextBox asTextBox30 = txtMa_plvt1;
		location = new Point(724, 188);
		((Control)asTextBox30).Location = location;
		txtMa_plvt1.LookupCodeName = "MA_PLVT";
		txtMa_plvt1.LookupWhereCondition = "loai=1";
		((TextBoxBase)txtMa_plvt1).MaxLength = 8;
		((Control)txtMa_plvt1).Name = "txtMa_plvt1";
		txtMa_plvt1.NameControl = lblTen_plvt1;
		AsTextBox asTextBox31 = txtMa_plvt1;
		size = new Size(90, 20);
		((Control)asTextBox31).Size = size;
		((Control)txtMa_plvt1).TabIndex = 3;
		((Control)txtMa_plvt1).Tag = "MA_PLVT1";
		txtMa_plvt1.UseAutoCompleteSource = true;
		((Control)txtMa_plvt1).Visible = false;
		((Control)lblTen_plvt1).Enabled = false;
		lblTen_plvt1.ImeMode = (ImeMode)0;
		Label obj82 = lblTen_plvt1;
		location = new Point(820, 192);
		((Control)obj82).Location = location;
		((Control)lblTen_plvt1).Name = "lblTen_plvt1";
		Label obj83 = lblTen_plvt1;
		size = new Size(252, 13);
		((Control)obj83).Size = size;
		((Control)lblTen_plvt1).TabIndex = 1258;
		((Control)lblTen_plvt1).Visible = false;
		((Control)lblTen_Tk).Enabled = false;
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj84 = lblTen_Tk;
		location = new Point(820, 192);
		((Control)obj84).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj85 = lblTen_Tk;
		size = new Size(252, 13);
		((Control)obj85).Size = size;
		((Control)lblTen_Tk).TabIndex = 1261;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Tk).Visible = false;
		lblPLVt1.AutoSize = true;
		((Control)lblPLVt1).Enabled = false;
		lblPLVt1.ImeMode = (ImeMode)0;
		Label obj86 = lblPLVt1;
		location = new Point(636, 192);
		((Control)obj86).Location = location;
		((Control)lblPLVt1).Name = "lblPLVt1";
		Label obj87 = lblPLVt1;
		size = new Size(60, 13);
		((Control)obj87).Size = size;
		((Control)lblPLVt1).TabIndex = 1257;
		lblPLVt1.Text = "P.Loại VT1";
		((Control)lblPLVt1).Visible = false;
		((Control)lblTen_plvt2).Enabled = false;
		lblTen_plvt2.ImeMode = (ImeMode)0;
		Label obj88 = lblTen_plvt2;
		location = new Point(820, 218);
		((Control)obj88).Location = location;
		((Control)lblTen_plvt2).Name = "lblTen_plvt2";
		Label obj89 = lblTen_plvt2;
		size = new Size(252, 13);
		((Control)obj89).Size = size;
		((Control)lblTen_plvt2).TabIndex = 1260;
		((Control)lblTen_plvt2).Visible = false;
		txtMa_plvt2.AutoLookup = true;
		txtMa_plvt2.AutoValid = false;
		((TextBoxBase)txtMa_plvt2).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt2).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt2).Enabled = false;
		AsTextBox asTextBox32 = txtMa_plvt2;
		location = new Point(724, 214);
		((Control)asTextBox32).Location = location;
		txtMa_plvt2.LookupCodeName = "MA_PLVT";
		txtMa_plvt2.LookupWhereCondition = "loai=2";
		((TextBoxBase)txtMa_plvt2).MaxLength = 8;
		((Control)txtMa_plvt2).Name = "txtMa_plvt2";
		txtMa_plvt2.NameControl = lblTen_plvt2;
		AsTextBox asTextBox33 = txtMa_plvt2;
		size = new Size(90, 20);
		((Control)asTextBox33).Size = size;
		((Control)txtMa_plvt2).TabIndex = 4;
		((Control)txtMa_plvt2).Tag = "MA_PLVT2";
		txtMa_plvt2.UseAutoCompleteSource = true;
		((Control)txtMa_plvt2).Visible = false;
		Label obj90 = lblTen_lo;
		location = new Point(266, 407);
		((Control)obj90).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj91 = lblTen_lo;
		size = new Size(464, 13);
		((Control)obj91).Size = size;
		((Control)lblTen_lo).TabIndex = 1266;
		lblPLVt2.AutoSize = true;
		((Control)lblPLVt2).Enabled = false;
		lblPLVt2.ImeMode = (ImeMode)0;
		Label obj92 = lblPLVt2;
		location = new Point(636, 218);
		((Control)obj92).Location = location;
		((Control)lblPLVt2).Name = "lblPLVt2";
		Label obj93 = lblPLVt2;
		size = new Size(60, 13);
		((Control)obj93).Size = size;
		((Control)lblPLVt2).TabIndex = 1259;
		lblPLVt2.Text = "P.Loại VT2";
		((Control)lblPLVt2).Visible = false;
		txtMaLo.AutoLookup = true;
		txtMaLo.AutoValid = false;
		((TextBoxBase)txtMaLo).BackColor = SystemColors.Info;
		((TextBox)txtMaLo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox34 = txtMaLo;
		location = new Point(173, 403);
		((Control)asTextBox34).Location = location;
		txtMaLo.LookupCodeName = "MA_LO";
		((Control)txtMaLo).Name = "txtMaLo";
		txtMaLo.NameControl = lblTen_lo;
		AsTextBox asTextBox35 = txtMaLo;
		size = new Size(88, 20);
		((Control)asTextBox35).Size = size;
		((Control)txtMaLo).TabIndex = 17;
		((Control)txtMaLo).Tag = "MA_LO";
		txtMaLo.UseAutoCompleteSource = true;
		((Control)lblTen_plvt3).Enabled = false;
		lblTen_plvt3.ImeMode = (ImeMode)0;
		Label obj94 = lblTen_plvt3;
		location = new Point(820, 244);
		((Control)obj94).Location = location;
		((Control)lblTen_plvt3).Name = "lblTen_plvt3";
		Label obj95 = lblTen_plvt3;
		size = new Size(252, 13);
		((Control)obj95).Size = size;
		((Control)lblTen_plvt3).TabIndex = 1263;
		((Control)lblTen_plvt3).Visible = false;
		lblMaLo.AutoSize = true;
		Label obj96 = lblMaLo;
		location = new Point(20, 407);
		((Control)obj96).Location = location;
		((Control)lblMaLo).Name = "lblMaLo";
		Label obj97 = lblMaLo;
		size = new Size(33, 13);
		((Control)obj97).Size = size;
		((Control)lblMaLo).TabIndex = 1267;
		lblMaLo.Text = "Mã lô";
		txtMa_plvt3.AutoLookup = true;
		txtMa_plvt3.AutoValid = false;
		((TextBoxBase)txtMa_plvt3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt3).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt3).Enabled = false;
		AsTextBox asTextBox36 = txtMa_plvt3;
		location = new Point(724, 240);
		((Control)asTextBox36).Location = location;
		txtMa_plvt3.LookupCodeName = "MA_PLVT";
		txtMa_plvt3.LookupWhereCondition = "loai=3";
		((TextBoxBase)txtMa_plvt3).MaxLength = 8;
		((Control)txtMa_plvt3).Name = "txtMa_plvt3";
		txtMa_plvt3.NameControl = lblTen_plvt3;
		AsTextBox asTextBox37 = txtMa_plvt3;
		size = new Size(90, 20);
		((Control)asTextBox37).Size = size;
		((Control)txtMa_plvt3).TabIndex = 5;
		((Control)txtMa_plvt3).Tag = "MA_PLVT3";
		txtMa_plvt3.UseAutoCompleteSource = true;
		((Control)txtMa_plvt3).Visible = false;
		((Control)lblTen_vitri).Enabled = false;
		Label obj98 = lblTen_vitri;
		location = new Point(820, 270);
		((Control)obj98).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj99 = lblTen_vitri;
		size = new Size(252, 13);
		((Control)obj99).Size = size;
		((Control)lblTen_vitri).TabIndex = 1264;
		((Control)lblTen_vitri).Visible = false;
		lblPLVt3.AutoSize = true;
		((Control)lblPLVt3).Enabled = false;
		lblPLVt3.ImeMode = (ImeMode)0;
		Label obj100 = lblPLVt3;
		location = new Point(636, 244);
		((Control)obj100).Location = location;
		((Control)lblPLVt3).Name = "lblPLVt3";
		Label obj101 = lblPLVt3;
		size = new Size(60, 13);
		((Control)obj101).Size = size;
		((Control)lblPLVt3).TabIndex = 1262;
		lblPLVt3.Text = "P.Loại VT3";
		((Control)lblPLVt3).Visible = false;
		txtMa_vitri.AutoLookup = true;
		txtMa_vitri.AutoValid = false;
		((TextBoxBase)txtMa_vitri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vitri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vitri).Enabled = false;
		AsTextBox asTextBox38 = txtMa_vitri;
		location = new Point(726, 267);
		((Control)asTextBox38).Location = location;
		txtMa_vitri.LookupCodeName = "MA_VITRI";
		((Control)txtMa_vitri).Name = "txtMa_vitri";
		txtMa_vitri.NameControl = lblTen_vitri;
		AsTextBox asTextBox39 = txtMa_vitri;
		size = new Size(88, 20);
		((Control)asTextBox39).Size = size;
		((Control)txtMa_vitri).TabIndex = 7;
		((Control)txtMa_vitri).Tag = "MA_VITRI";
		txtMa_vitri.UseAutoCompleteSource = true;
		((Control)txtMa_vitri).Visible = false;
		((TextBox)txtMa_kho).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox40 = txtMa_kho;
		location = new Point(173, 379);
		((Control)asTextBox40).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox41 = txtMa_kho;
		size = new Size(88, 20);
		((Control)asTextBox41).Size = size;
		((Control)txtMa_kho).TabIndex = 16;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		lblTen_kho.ImeMode = (ImeMode)0;
		Label obj102 = lblTen_kho;
		location = new Point(266, 383);
		((Control)obj102).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj103 = lblTen_kho;
		size = new Size(464, 13);
		((Control)obj103).Size = size;
		((Control)lblTen_kho).TabIndex = 1252;
		lblMavitri.AutoSize = true;
		((Control)lblMavitri).Enabled = false;
		Label obj104 = lblMavitri;
		location = new Point(638, 271);
		((Control)obj104).Location = location;
		((Control)lblMavitri).Name = "lblMavitri";
		Label obj105 = lblMavitri;
		size = new Size(46, 13);
		((Control)obj105).Size = size;
		((Control)lblMavitri).TabIndex = 1265;
		lblMavitri.Text = "Mã vị trí";
		((Control)lblMavitri).Visible = false;
		lblMa_kho.AutoSize = true;
		lblMa_kho.ImeMode = (ImeMode)0;
		Label obj106 = lblMa_kho;
		location = new Point(20, 383);
		((Control)obj106).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj107 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj107).Size = size;
		((Control)lblMa_kho).TabIndex = 1251;
		lblMa_kho.Text = "Mã kho";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).AutoScroll = true;
		size = new Size(960, 591);
		((Form)this).ClientSize = size;
		((Control)this).Cursor = Cursors.Arrow;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "lstVoucherInfo";
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(MyMenuInfo.moduleid);
		arrayList.Add("0");
		arrayList.Add(SystemInformations.CurrentCultureName);
		ArrayList arrayList2 = CBO<lstVoucherInfo>.FillCollection(Commons.GetDataReader("asSIGetDmSo_ct", arrayList.ToArray()));
		arrayList2.Add(new lstVoucherInfo("", AsiaErp.Framework.Environment.getLangSysMessageResX("#SYS_ALL").value));
		((ComboBox)cboLoaiPhieu).DataSource = arrayList2;
		((ListControl)cboLoaiPhieu).DisplayMember = "TEN_CT";
		((ListControl)cboLoaiPhieu).ValueMember = "MA_CT";
		((ListControl)cboLoaiPhieu).SelectedValue = base.MyReportInfo.par0;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_Kh).Text);
		arrayList.Add(((TextBox)txtMa_NhKh).Text);
		arrayList.Add(((TextBox)txtMa_plkh1).Text);
		arrayList.Add(((TextBox)txtMa_plkh2).Text);
		arrayList.Add(((TextBox)txtMa_plkh3).Text);
		arrayList.Add(((TextBox)txtMa_plvt1).Text);
		arrayList.Add(((TextBox)txtMa_plvt2).Text);
		arrayList.Add(((TextBox)txtMa_plvt3).Text);
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtMa_nhhd).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkHang_ban.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkKhuyen_mai.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_ck.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_lai.Checked));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoaiPhieu).SelectedValue));
		arrayList.Add("");
		arrayList.Add(((TextBox)txtMaLo).Text);
		arrayList.Add(((TextBox)txtMa_vitri).Text);
		arrayList.Add(((TextBox)txtMA_HTTT).Text);
		arrayList.Add(((TextBox)txtMA_DKTT).Text);
		arrayList.Add(((TextBox)txtMa_bp).Text);
		arrayList.Add(((TextBox)txtMa_nvkd).Text);
		arrayList.Add(((TextBox)txtMa_spct).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(((ListControl)cboLoaiPhieu).SelectedValue.ToString(), "", false) != 0)
		{
			text = text + lblLoai_Phieu.Text + ": [" + ((ListControl)cboLoaiPhieu).SelectedValue.ToString() + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vitri).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_vitri.Text + ": [" + ((TextBox)txtMa_vitri).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMaLo).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_lo.Text + ": [" + ((TextBox)txtMaLo).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMA_HTTT).Text.Trim(), "", false) != 0)
		{
			text = text + lblHTTT.Text + ": [" + ((TextBox)txtMA_HTTT).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMA_DKTT).Text.Trim(), "", false) != 0)
		{
			text = text + lblDkTT.Text + ": [" + ((TextBox)txtMA_DKTT).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_spct).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_spct.Text + ": [" + ((TextBox)txtMa_spct).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Kh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Kh.Text + ": [" + ((TextBox)txtMa_Kh).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_NhKh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_NhKh.Text + ": [" + ((TextBox)txtMa_NhKh).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plkh1).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLKh1.Text + ": [" + ((TextBox)txtMa_plkh1).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plkh2).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLKh2.Text + ": [" + ((TextBox)txtMa_plkh2).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plkh3).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLKh3.Text + ": [" + ((TextBox)txtMa_plkh3).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_hd).Text, "", false) != 0)
		{
			text = text + lblMa_hd.Text + ": [" + ((TextBox)txtMa_hd).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhhd).Text, "", false) != 0)
		{
			text = text + lblMa_nhhd.Text + ": [" + ((TextBox)txtMa_nhhd).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text, "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": [" + ((TextBox)txtMa_kho).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
		{
			text = text + lblMa_vt.Text + ": [" + ((TextBox)txtMa_vt).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhvt).Text, "", false) != 0)
		{
			text = text + lblMa_nhvt.Text + ": [" + ((TextBox)txtMa_nhvt).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt1).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLVt1.Text + ": [" + ((TextBox)txtMa_plvt1).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt2).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLVt2.Text + ": [" + ((TextBox)txtMa_plvt2).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt3).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLVt3.Text + ": [" + ((TextBox)txtMa_plvt3).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_bp).Text, "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": [" + ((TextBox)txtMa_kho).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nvkd).Text, "", false) != 0)
		{
			text = text + lblMa_nvkd.Text + ": [" + ((TextBox)txtMa_nvkd).Text + "]; ";
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(ChkHang_ban.Checked, ChkKhuyen_mai.Checked), ChkTra_ck.Checked)))
		{
			text = text + lblLoai_hang.Text + ": [";
		}
		if (Conversions.ToBoolean(ChkHang_ban.Checked))
		{
			text = text + ((ButtonBase)ChkHang_ban).Text + "]; ";
		}
		if (Conversions.ToBoolean(ChkKhuyen_mai.Checked))
		{
			text = text + ((ButtonBase)ChkKhuyen_mai).Text + "]; ";
		}
		if (Conversions.ToBoolean(ChkTra_ck.Checked))
		{
			text = text + ((ButtonBase)ChkTra_ck).Text + "]; ";
		}
		if (Conversions.ToBoolean(ChkTra_lai.Checked))
		{
			text = text + lblTru.Text + ": [" + ((ButtonBase)ChkTra_ck).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": [" + ((TextBox)txtMa_Nt).Text + "]; ";
		}
		return text;
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		DataRowView dataRowView = get_MyDGVSource(isSet2Print: true).DefaultView[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
		if ((int)keycode != 116 || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false), (object)"", false) ? true : false))
		{
			base.CancelDrilldown = true;
			return null;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoaiPhieu).SelectedValue));
		arrayList.Add(((TextBox)txtMa_Kh).Text);
		arrayList.Add(((TextBox)txtMa_NhKh).Text);
		arrayList.Add(((TextBox)txtMa_plkh1).Text);
		arrayList.Add(((TextBox)txtMa_plkh2).Text);
		arrayList.Add(((TextBox)txtMa_plkh3).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["Ma_vt"]));
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add("");
		arrayList.Add(((TextBox)txtMa_plvt1).Text);
		arrayList.Add(((TextBox)txtMa_plvt2).Text);
		arrayList.Add(((TextBox)txtMa_plvt3).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_bp).Text);
		arrayList.Add(((TextBox)txtMa_nvkd).Text);
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtMa_nhhd).Text);
		arrayList.Add("");
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkHang_ban.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkKhuyen_mai.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_ck.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_lai.Checked));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add("");
		arrayList.Add(((TextBox)txtMA_DKTT).Text);
		if (Information.IsDBNull((object)arrayList))
		{
			base.CancelDrilldown = true;
			return null;
		}
		filterCondition4title = dataRowView["ma_vt"].ToString() + ": [" + dataRowView["ten_vt"].ToString();
		return arrayList;
	}

	private void cboMau_bc_SelectedIndexChanged(object sender, EventArgs e)
	{
		((ListControl)cboLoaiPhieu).SelectedValue = base.MyReportInfo.par0;
	}
}
