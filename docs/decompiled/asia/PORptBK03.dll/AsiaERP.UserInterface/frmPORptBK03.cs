using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmPORptBK03 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("txtSo_CT2")]
	private TextBox _txtSo_CT2;

	[AccessedThroughProperty("lblSo_ct2")]
	private Label _lblSo_ct2;

	[AccessedThroughProperty("txtSo_CT1")]
	private TextBox _txtSo_CT1;

	[AccessedThroughProperty("lblSo_ct1")]
	private Label _lblSo_ct1;

	[AccessedThroughProperty("cboNhom_theo")]
	private ComboBox _cboNhom_theo;

	[AccessedThroughProperty("lblNhom_theo")]
	private Label _lblNhom_theo;

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

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("txtMaLo")]
	private AsTextBox _txtMaLo;

	[AccessedThroughProperty("lblMaLo")]
	private Label _lblMaLo;

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("txtMa_vtri")]
	private AsTextBox _txtMa_vtri;

	[AccessedThroughProperty("lblMa_vitri")]
	private Label _lblMa_vitri;

	[AccessedThroughProperty("txtMa_nhhd")]
	private AsTextBox _txtMa_nhhd;

	[AccessedThroughProperty("lblTen_Nhhd")]
	private Label _lblTen_Nhhd;

	[AccessedThroughProperty("lblMa_nhhd")]
	private Label _lblMa_nhhd;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("lblTen_nh_vt")]
	private Label _lblTen_nh_vt;

	[AccessedThroughProperty("txtMa_nh_vt")]
	private AsTextBox _txtMa_nh_vt;

	[AccessedThroughProperty("lblMa_nh_vt")]
	private Label _lblMa_nh_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("lblTen_nh_kh")]
	private Label _lblTen_nh_kh;

	[AccessedThroughProperty("lblTen_kh")]
	private Label _lblTen_kh;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

	[AccessedThroughProperty("txtMa_nh_ncc")]
	private AsTextBox _txtMa_nh_ncc;

	[AccessedThroughProperty("lblMa_nh_ncc")]
	private Label _lblMa_nh_ncc;

	[AccessedThroughProperty("txtMa_ncc")]
	private AsTextBox _txtMa_ncc;

	[AccessedThroughProperty("lblMa_ncc")]
	private Label _lblMa_ncc;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("txtPl_ncc1")]
	private AsTextBox _txtPl_ncc1;

	[AccessedThroughProperty("lblTen_pl_kh1")]
	private Label _lblTen_pl_kh1;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblPl_ncc1")]
	private Label _lblPl_ncc1;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("lblPl_ncc2")]
	private Label _lblPl_ncc2;

	[AccessedThroughProperty("txtPl_ncc2")]
	private AsTextBox _txtPl_ncc2;

	[AccessedThroughProperty("lblTen_pl_kh2")]
	private Label _lblTen_pl_kh2;

	[AccessedThroughProperty("lblPl_ncc3")]
	private Label _lblPl_ncc3;

	[AccessedThroughProperty("txtPl_ncc3")]
	private AsTextBox _txtPl_ncc3;

	[AccessedThroughProperty("lblTen_pl_kh3")]
	private Label _lblTen_pl_kh3;

	[AccessedThroughProperty("lblTenPhi")]
	private Label _lblTenPhi;

	[AccessedThroughProperty("txtMa_Plvt1")]
	private AsTextBox _txtMa_Plvt1;

	[AccessedThroughProperty("lblTen_plvt1")]
	private Label _lblTen_plvt1;

	[AccessedThroughProperty("txtMaPhi")]
	private AsTextBox _txtMaPhi;

	[AccessedThroughProperty("lblMaPhi")]
	private Label _lblMaPhi;

	[AccessedThroughProperty("lblPlvt3")]
	private Label _lblPlvt3;

	[AccessedThroughProperty("txtMa_plvt3")]
	private AsTextBox _txtMa_plvt3;

	[AccessedThroughProperty("lblTen_plvt3")]
	private Label _lblTen_plvt3;

	[AccessedThroughProperty("lblPlvt2")]
	private Label _lblPlvt2;

	[AccessedThroughProperty("txtMa_Plvt2")]
	private AsTextBox _txtMa_Plvt2;

	[AccessedThroughProperty("lblTen_plvt2")]
	private Label _lblTen_plvt2;

	[AccessedThroughProperty("lblPlvt1")]
	private Label _lblPlvt1;

	internal virtual Label lblTen_bp
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

	internal virtual AsTextBox txtMa_bp
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

	internal virtual TextBox txtSo_CT2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_CT2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_CT2 = value;
		}
	}

	internal virtual Label lblSo_ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_ct2 = value;
		}
	}

	internal virtual TextBox txtSo_CT1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_CT1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_CT1 = value;
		}
	}

	internal virtual Label lblSo_ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_ct1 = value;
		}
	}

	internal virtual ComboBox cboNhom_theo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNhom_theo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboNhom_theo = value;
		}
	}

	internal virtual Label lblNhom_theo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNhom_theo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNhom_theo = value;
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

	internal virtual AsTextBox txtMa_vtri
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_vtri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_vtri = value;
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

	internal virtual Label lblTen_Nhhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhhd = value;
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

	internal virtual Label lblTen_nh_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nh_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nh_vt = value;
		}
	}

	internal virtual AsTextBox txtMa_nh_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nh_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nh_vt = value;
		}
	}

	internal virtual Label lblMa_nh_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nh_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nh_vt = value;
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

	internal virtual Label lblTen_hd
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

	internal virtual Label lblTen_nh_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nh_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nh_kh = value;
		}
	}

	internal virtual Label lblTen_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kh = value;
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

	internal virtual AsTextBox txtMa_nh_ncc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nh_ncc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nh_ncc = value;
		}
	}

	internal virtual Label lblMa_nh_ncc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nh_ncc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nh_ncc = value;
		}
	}

	internal virtual AsTextBox txtMa_ncc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ncc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_ncc = value;
		}
	}

	internal virtual Label lblMa_ncc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_ncc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_ncc = value;
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

	internal virtual AsTextBox txtPl_ncc1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPl_ncc1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPl_ncc1 = value;
		}
	}

	internal virtual Label lblTen_pl_kh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_pl_kh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_pl_kh1 = value;
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

	internal virtual Label lblPl_ncc1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPl_ncc1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPl_ncc1 = value;
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

	internal virtual Label lblPl_ncc2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPl_ncc2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPl_ncc2 = value;
		}
	}

	internal virtual AsTextBox txtPl_ncc2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPl_ncc2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPl_ncc2 = value;
		}
	}

	internal virtual Label lblTen_pl_kh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_pl_kh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_pl_kh2 = value;
		}
	}

	internal virtual Label lblPl_ncc3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPl_ncc3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPl_ncc3 = value;
		}
	}

	internal virtual AsTextBox txtPl_ncc3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPl_ncc3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPl_ncc3 = value;
		}
	}

	internal virtual Label lblTen_pl_kh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_pl_kh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_pl_kh3 = value;
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

	internal virtual AsTextBox txtMa_Plvt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Plvt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Plvt1 = value;
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

	internal virtual AsTextBox txtMaPhi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMaPhi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMaPhi = value;
		}
	}

	internal virtual Label lblMaPhi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMaPhi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMaPhi = value;
		}
	}

	internal virtual Label lblPlvt3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPlvt3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPlvt3 = value;
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

	internal virtual Label lblPlvt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPlvt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPlvt2 = value;
		}
	}

	internal virtual AsTextBox txtMa_Plvt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Plvt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Plvt2 = value;
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

	internal virtual Label lblPlvt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPlvt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPlvt1 = value;
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

	public frmPORptBK03(string menuID)
		: base(menuID)
	{
		__ENCAddToList(this);
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
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
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_3b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b6e: Expected O, but got Unknown
		lblTen_bp = new Label();
		txtMa_bp = new AsTextBox();
		lblMa_bp = new Label();
		txtSo_CT2 = new TextBox();
		lblSo_ct2 = new Label();
		txtSo_CT1 = new TextBox();
		lblSo_ct1 = new Label();
		lblNhom_theo = new Label();
		cboNhom_theo = new ComboBox();
		lblTen_TT = new Label();
		txtMA_DKTT = new AsTextBox();
		lblDkTT = new Label();
		lblTenHTTT = new Label();
		txtMA_HTTT = new AsTextBox();
		lblHTTT = new Label();
		lblTen_lo = new Label();
		txtMaLo = new AsTextBox();
		lblMaLo = new Label();
		lblTen_vitri = new Label();
		txtMa_vtri = new AsTextBox();
		lblMa_vitri = new Label();
		txtMa_nhhd = new AsTextBox();
		lblTen_Nhhd = new Label();
		lblMa_nhhd = new Label();
		lblTen_kho = new Label();
		txtMa_kho = new AsTextBox();
		lblMa_kho = new Label();
		lblTen_nh_vt = new Label();
		txtMa_nh_vt = new AsTextBox();
		lblMa_nh_vt = new Label();
		lblTen_vt = new Label();
		lblTen_hd = new Label();
		lblTen_nh_kh = new Label();
		lblTen_kh = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		txtMa_hd = new AsTextBox();
		lblMa_hd = new Label();
		txtMa_nh_ncc = new AsTextBox();
		lblMa_nh_ncc = new Label();
		txtMa_ncc = new AsTextBox();
		lblMa_ncc = new Label();
		lblTen_spct = new Label();
		txtPl_ncc1 = new AsTextBox();
		lblTen_pl_kh1 = new Label();
		txtMa_spct = new AsTextBox();
		lblPl_ncc1 = new Label();
		lblMa_spct = new Label();
		lblPl_ncc2 = new Label();
		txtPl_ncc2 = new AsTextBox();
		lblTen_pl_kh2 = new Label();
		lblPl_ncc3 = new Label();
		txtPl_ncc3 = new AsTextBox();
		lblTen_pl_kh3 = new Label();
		lblTenPhi = new Label();
		txtMa_Plvt1 = new AsTextBox();
		lblTen_plvt1 = new Label();
		txtMaPhi = new AsTextBox();
		lblMaPhi = new Label();
		lblPlvt3 = new Label();
		txtMa_plvt3 = new AsTextBox();
		lblTen_plvt3 = new Label();
		lblPlvt2 = new Label();
		txtMa_Plvt2 = new AsTextBox();
		lblTen_plvt2 = new Label();
		lblPlvt1 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(950, 560);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_TT);
		((Control)tabFilter).Controls.Add((Control)(object)txtPl_ncc1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblPl_ncc1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_DKTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblPl_ncc2);
		((Control)tabFilter).Controls.Add((Control)(object)lblDkTT);
		((Control)tabFilter).Controls.Add((Control)(object)txtPl_ncc2);
		((Control)tabFilter).Controls.Add((Control)(object)lblPl_ncc3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTenHTTT);
		((Control)tabFilter).Controls.Add((Control)(object)txtPl_ncc3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_pl_kh1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_HTTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_pl_kh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_pl_kh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblHTTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTenPhi);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lo);
		((Control)tabFilter).Controls.Add((Control)(object)txtMaPhi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMaPhi);
		((Control)tabFilter).Controls.Add((Control)(object)txtMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlvt3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlvt2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlvt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vtri);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_theo);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom_theo);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_CT2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nh_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_ct2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nh_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_CT1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nh_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_ct1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nh_kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nh_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nh_ncc);
		TabPage obj = tabFilter;
		size = new Size(942, 531);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nh_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nh_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nh_kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nh_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_CT1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nh_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nh_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_CT2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom_theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vtri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMaPhi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMaPhi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTenPhi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblHTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_pl_kh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_pl_kh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_HTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_pl_kh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtPl_ncc3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTenHTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPl_ncc3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtPl_ncc2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDkTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPl_ncc2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_DKTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPl_ncc1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtPl_ncc1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_TT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		Label obj2 = lbl2;
		Point location = new Point(341, 69);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 2;
		Button obj3 = cmdExcel;
		location = new Point(700, 659);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 26;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(360, 65);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 3;
		Button obj4 = cmdCancel;
		location = new Point(619, 659);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 25;
		Button obj5 = cmdModifyReport;
		location = new Point(519, 16);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 15;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(270, 65);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 2;
		ComboBox obj6 = cboKyBc;
		location = new Point(174, 65);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 1;
		Label obj7 = lblKyBc;
		location = new Point(24, 69);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(174, 18);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 14;
		Label obj9 = lblMau_bc;
		location = new Point(24, 21);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(174, 451);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 20;
		Label obj10 = lblMauBC;
		location = new Point(222, 455);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 10;
		RadioButton obj11 = optVND;
		location = new Point(309, 453);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 21;
		RadioButton obj12 = optNt;
		location = new Point(363, 453);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 22;
		Label obj13 = lblMa_nt;
		location = new Point(24, 453);
		((Control)obj13).Location = location;
		((Control)lblMa_nt).TabIndex = 8;
		Button obj14 = cmdOk;
		location = new Point(27, 499);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 23;
		Label obj15 = lblTieu_de;
		location = new Point(24, 47);
		((Control)obj15).Location = location;
		((Control)lblTieu_de).TabIndex = 23;
		TextBox obj16 = txtTieu_De;
		location = new Point(174, 43);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 0;
		((Control)lblTen_bp).Enabled = false;
		lblTen_bp.ImeMode = (ImeMode)0;
		Label obj17 = lblTen_bp;
		location = new Point(828, 160);
		((Control)obj17).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj18 = lblTen_bp;
		size = new Size(43, 13);
		((Control)obj18).Size = size;
		((Control)lblTen_bp).TabIndex = 1302;
		lblTen_bp.TextAlign = (ContentAlignment)16;
		((Control)lblTen_bp).Visible = false;
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_bp).Enabled = false;
		AsTextBox asTextBox2 = txtMa_bp;
		location = new Point(706, 157);
		((Control)asTextBox2).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((TextBoxBase)txtMa_bp).MaxLength = 20;
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox3 = txtMa_bp;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_bp).TabIndex = 16;
		txtMa_bp.UseAutoCompleteSource = true;
		((Control)txtMa_bp).Visible = false;
		lblMa_bp.AutoSize = true;
		((Control)lblMa_bp).Enabled = false;
		Label obj19 = lblMa_bp;
		location = new Point(607, 160);
		((Control)obj19).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj20 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj20).Size = size;
		((Control)lblMa_bp).TabIndex = 1301;
		lblMa_bp.Text = "Mã bộ phận";
		((Control)lblMa_bp).Visible = false;
		TextBox obj21 = txtSo_CT2;
		location = new Point(337, 90);
		((Control)obj21).Location = location;
		((Control)txtSo_CT2).Name = "txtSo_CT2";
		TextBox obj22 = txtSo_CT2;
		size = new Size(90, 20);
		((Control)obj22).Size = size;
		((Control)txtSo_CT2).TabIndex = 5;
		lblSo_ct2.AutoSize = true;
		Label obj23 = lblSo_ct2;
		location = new Point(280, 93);
		((Control)obj23).Location = location;
		((Control)lblSo_ct2).Name = "lblSo_ct2";
		Label obj24 = lblSo_ct2;
		size = new Size(41, 13);
		((Control)obj24).Size = size;
		((Control)lblSo_ct2).TabIndex = 4;
		lblSo_ct2.Text = "Đến số";
		TextBox obj25 = txtSo_CT1;
		location = new Point(174, 90);
		((Control)obj25).Location = location;
		((Control)txtSo_CT1).Name = "txtSo_CT1";
		TextBox obj26 = txtSo_CT1;
		size = new Size(90, 20);
		((Control)obj26).Size = size;
		((Control)txtSo_CT1).TabIndex = 4;
		lblSo_ct1.AutoSize = true;
		Label obj27 = lblSo_ct1;
		location = new Point(24, 93);
		((Control)obj27).Location = location;
		((Control)lblSo_ct1).Name = "lblSo_ct1";
		Label obj28 = lblSo_ct1;
		size = new Size(64, 13);
		((Control)obj28).Size = size;
		((Control)lblSo_ct1).TabIndex = 1281;
		lblSo_ct1.Text = "Chứng từ số";
		lblNhom_theo.AutoSize = true;
		Label obj29 = lblNhom_theo;
		location = new Point(24, 117);
		((Control)obj29).Location = location;
		((Control)lblNhom_theo).Name = "lblNhom_theo";
		Label obj30 = lblNhom_theo;
		size = new Size(59, 13);
		((Control)obj30).Size = size;
		((Control)lblNhom_theo).TabIndex = 1303;
		lblNhom_theo.Text = "Nhóm theo";
		cboNhom_theo.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_theo).FormattingEnabled = true;
		cboNhom_theo.Items.AddRange(new object[7] { "Nhà cung cấp", "Bộ phận ", "Hợp đồng", "Hình thức thanh toán", "Vật tư", "Chứng từ", "Sản phẩm công trình" });
		ComboBox obj31 = cboNhom_theo;
		location = new Point(174, 114);
		((Control)obj31).Location = location;
		((Control)cboNhom_theo).Name = "cboNhom_theo";
		ComboBox obj32 = cboNhom_theo;
		size = new Size(253, 21);
		((Control)obj32).Size = size;
		((Control)cboNhom_theo).TabIndex = 6;
		((Control)lblTen_TT).Enabled = false;
		Label obj33 = lblTen_TT;
		location = new Point(818, 114);
		((Control)obj33).Location = location;
		((Control)lblTen_TT).Name = "lblTen_TT";
		Label obj34 = lblTen_TT;
		size = new Size(22, 13);
		((Control)obj34).Size = size;
		((Control)lblTen_TT).TabIndex = 1397;
		((Control)lblTen_TT).Visible = false;
		txtMA_DKTT.AutoLookup = true;
		txtMA_DKTT.AutoValid = false;
		((TextBoxBase)txtMA_DKTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_DKTT).CharacterCasing = (CharacterCasing)1;
		((Control)txtMA_DKTT).Enabled = false;
		AsTextBox asTextBox4 = txtMA_DKTT;
		location = new Point(706, 110);
		((Control)asTextBox4).Location = location;
		txtMA_DKTT.LookupCodeName = "MA_TT_PO";
		((Control)txtMA_DKTT).Name = "txtMA_DKTT";
		txtMA_DKTT.NameControl = lblTen_TT;
		AsTextBox asTextBox5 = txtMA_DKTT;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMA_DKTT).TabIndex = 10;
		((Control)txtMA_DKTT).Tag = "MA_TT";
		txtMA_DKTT.UseAutoCompleteSource = true;
		((Control)txtMA_DKTT).Visible = false;
		lblDkTT.AutoSize = true;
		((Control)lblDkTT).Enabled = false;
		Label obj35 = lblDkTT;
		location = new Point(607, 112);
		((Control)obj35).Location = location;
		((Control)lblDkTT).Name = "lblDkTT";
		Label obj36 = lblDkTT;
		size = new Size(79, 13);
		((Control)obj36).Size = size;
		((Control)lblDkTT).TabIndex = 1398;
		lblDkTT.Text = "Điều khoản TT";
		((Control)lblDkTT).Visible = false;
		Label obj37 = lblTenHTTT;
		location = new Point(267, 287);
		((Control)obj37).Location = location;
		((Control)lblTenHTTT).Name = "lblTenHTTT";
		Label obj38 = lblTenHTTT;
		size = new Size(442, 13);
		((Control)obj38).Size = size;
		((Control)lblTenHTTT).TabIndex = 1395;
		txtMA_HTTT.AutoLookup = true;
		txtMA_HTTT.AutoValid = false;
		((TextBoxBase)txtMA_HTTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_HTTT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMA_HTTT;
		location = new Point(174, 283);
		((Control)asTextBox6).Location = location;
		txtMA_HTTT.LookupCodeName = "MA_HTTT";
		txtMA_HTTT.LookupWhereCondition = "moduleid='po'";
		((Control)txtMA_HTTT).Name = "txtMA_HTTT";
		txtMA_HTTT.NameControl = lblTenHTTT;
		AsTextBox asTextBox7 = txtMA_HTTT;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMA_HTTT).TabIndex = 13;
		((Control)txtMA_HTTT).Tag = "MA_HTTT";
		txtMA_HTTT.UseAutoCompleteSource = true;
		lblHTTT.AutoSize = true;
		Label obj39 = lblHTTT;
		location = new Point(24, 287);
		((Control)obj39).Location = location;
		((Control)lblHTTT).Name = "lblHTTT";
		Label obj40 = lblHTTT;
		size = new Size(70, 13);
		((Control)obj40).Size = size;
		((Control)lblHTTT).TabIndex = 1396;
		lblHTTT.Text = "Hình thức TT";
		Label obj41 = lblTen_lo;
		location = new Point(267, 335);
		((Control)obj41).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj42 = lblTen_lo;
		size = new Size(442, 13);
		((Control)obj42).Size = size;
		((Control)lblTen_lo).TabIndex = 1391;
		txtMaLo.AutoLookup = true;
		txtMaLo.AutoValid = false;
		((TextBoxBase)txtMaLo).BackColor = SystemColors.Info;
		((TextBox)txtMaLo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMaLo;
		location = new Point(174, 331);
		((Control)asTextBox8).Location = location;
		txtMaLo.LookupCodeName = "MA_LO";
		((Control)txtMaLo).Name = "txtMaLo";
		txtMaLo.NameControl = lblTen_lo;
		AsTextBox asTextBox9 = txtMaLo;
		size = new Size(90, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMaLo).TabIndex = 15;
		((Control)txtMaLo).Tag = "MA_LO";
		txtMaLo.UseAutoCompleteSource = true;
		lblMaLo.AutoSize = true;
		Label obj43 = lblMaLo;
		location = new Point(24, 335);
		((Control)obj43).Location = location;
		((Control)lblMaLo).Name = "lblMaLo";
		Label obj44 = lblMaLo;
		size = new Size(33, 13);
		((Control)obj44).Size = size;
		((Control)lblMaLo).TabIndex = 1392;
		lblMaLo.Text = "Mã lô";
		((Control)lblTen_vitri).Enabled = false;
		lblTen_vitri.ImeMode = (ImeMode)0;
		Label obj45 = lblTen_vitri;
		location = new Point(818, 139);
		((Control)obj45).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj46 = lblTen_vitri;
		size = new Size(22, 13);
		((Control)obj46).Size = size;
		((Control)lblTen_vitri).TabIndex = 1390;
		lblTen_vitri.TextAlign = (ContentAlignment)16;
		((Control)lblTen_vitri).Visible = false;
		txtMa_vtri.AutoLookup = true;
		txtMa_vtri.AutoValid = false;
		((TextBoxBase)txtMa_vtri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vtri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vtri).Enabled = false;
		AsTextBox asTextBox10 = txtMa_vtri;
		location = new Point(706, 133);
		((Control)asTextBox10).Location = location;
		txtMa_vtri.LookupCodeName = "MA_VITRI";
		((TextBoxBase)txtMa_vtri).MaxLength = 20;
		((Control)txtMa_vtri).Name = "txtMa_vtri";
		txtMa_vtri.NameControl = lblTen_vitri;
		AsTextBox asTextBox11 = txtMa_vtri;
		size = new Size(90, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_vtri).TabIndex = 7;
		txtMa_vtri.UseAutoCompleteSource = true;
		((Control)txtMa_vtri).Visible = false;
		lblMa_vitri.AutoSize = true;
		((Control)lblMa_vitri).Enabled = false;
		Label obj47 = lblMa_vitri;
		location = new Point(607, 134);
		((Control)obj47).Location = location;
		((Control)lblMa_vitri).Name = "lblMa_vitri";
		Label obj48 = lblMa_vitri;
		size = new Size(46, 13);
		((Control)obj48).Size = size;
		((Control)lblMa_vitri).TabIndex = 1389;
		lblMa_vitri.Text = "Mã vị trí";
		((Control)lblMa_vitri).Visible = false;
		txtMa_nhhd.AutoLookup = true;
		txtMa_nhhd.AutoValid = false;
		((TextBoxBase)txtMa_nhhd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhhd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_nhhd;
		location = new Point(174, 259);
		((Control)asTextBox12).Location = location;
		txtMa_nhhd.LookupCodeName = "MA_NHHD";
		((Control)txtMa_nhhd).Name = "txtMa_nhhd";
		txtMa_nhhd.NameControl = lblTen_Nhhd;
		AsTextBox asTextBox13 = txtMa_nhhd;
		size = new Size(90, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_nhhd).TabIndex = 12;
		((Control)txtMa_nhhd).Tag = "MA_NHHD";
		txtMa_nhhd.UseAutoCompleteSource = true;
		Label obj49 = lblTen_Nhhd;
		location = new Point(267, 262);
		((Control)obj49).Location = location;
		((Control)lblTen_Nhhd).Name = "lblTen_Nhhd";
		Label obj50 = lblTen_Nhhd;
		size = new Size(442, 13);
		((Control)obj50).Size = size;
		((Control)lblTen_Nhhd).TabIndex = 1381;
		lblMa_nhhd.AutoSize = true;
		Label obj51 = lblMa_nhhd;
		location = new Point(24, 262);
		((Control)obj51).Location = location;
		((Control)lblMa_nhhd).Name = "lblMa_nhhd";
		Label obj52 = lblMa_nhhd;
		size = new Size(84, 13);
		((Control)obj52).Size = size;
		((Control)lblMa_nhhd).TabIndex = 1382;
		lblMa_nhhd.Text = "Nhóm hợp đồng";
		lblTen_kho.ImeMode = (ImeMode)0;
		Label obj53 = lblTen_kho;
		location = new Point(267, 311);
		((Control)obj53).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj54 = lblTen_kho;
		size = new Size(442, 13);
		((Control)obj54).Size = size;
		((Control)lblTen_kho).TabIndex = 1380;
		lblTen_kho.TextAlign = (ContentAlignment)16;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_kho;
		location = new Point(174, 307);
		((Control)asTextBox14).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((TextBoxBase)txtMa_kho).MaxLength = 20;
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox15 = txtMa_kho;
		size = new Size(90, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_kho).TabIndex = 14;
		txtMa_kho.UseAutoCompleteSource = true;
		lblMa_kho.AutoSize = true;
		Label obj55 = lblMa_kho;
		location = new Point(24, 311);
		((Control)obj55).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj56 = lblMa_kho;
		size = new Size(44, 13);
		((Control)obj56).Size = size;
		((Control)lblMa_kho).TabIndex = 1379;
		lblMa_kho.Text = "Mã Kho";
		lblTen_nh_vt.ImeMode = (ImeMode)0;
		Label obj57 = lblTen_nh_vt;
		location = new Point(267, 430);
		((Control)obj57).Location = location;
		((Control)lblTen_nh_vt).Name = "lblTen_nh_vt";
		Label obj58 = lblTen_nh_vt;
		size = new Size(442, 13);
		((Control)obj58).Size = size;
		((Control)lblTen_nh_vt).TabIndex = 1378;
		lblTen_nh_vt.TextAlign = (ContentAlignment)16;
		txtMa_nh_vt.AutoLookup = true;
		txtMa_nh_vt.AutoValid = false;
		((TextBoxBase)txtMa_nh_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nh_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox16 = txtMa_nh_vt;
		location = new Point(174, 426);
		((Control)asTextBox16).Location = location;
		txtMa_nh_vt.LookupCodeName = "MA_NHVT";
		((TextBoxBase)txtMa_nh_vt).MaxLength = 20;
		((Control)txtMa_nh_vt).Name = "txtMa_nh_vt";
		txtMa_nh_vt.NameControl = lblTen_nh_vt;
		AsTextBox asTextBox17 = txtMa_nh_vt;
		size = new Size(90, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtMa_nh_vt).TabIndex = 19;
		txtMa_nh_vt.UseAutoCompleteSource = true;
		lblMa_nh_vt.AutoSize = true;
		Label obj59 = lblMa_nh_vt;
		location = new Point(24, 429);
		((Control)obj59).Location = location;
		((Control)lblMa_nh_vt).Name = "lblMa_nh_vt";
		Label obj60 = lblMa_nh_vt;
		size = new Size(81, 13);
		((Control)obj60).Size = size;
		((Control)lblMa_nh_vt).TabIndex = 1377;
		lblMa_nh_vt.Text = "Mã nhóm vật tư";
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj61 = lblTen_vt;
		location = new Point(267, 406);
		((Control)obj61).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj62 = lblTen_vt;
		size = new Size(442, 13);
		((Control)obj62).Size = size;
		((Control)lblTen_vt).TabIndex = 1376;
		lblTen_vt.TextAlign = (ContentAlignment)16;
		lblTen_hd.ImeMode = (ImeMode)0;
		Label obj63 = lblTen_hd;
		location = new Point(267, 239);
		((Control)obj63).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj64 = lblTen_hd;
		size = new Size(442, 13);
		((Control)obj64).Size = size;
		((Control)lblTen_hd).TabIndex = 1375;
		lblTen_hd.TextAlign = (ContentAlignment)16;
		((Control)lblTen_nh_kh).Enabled = false;
		lblTen_nh_kh.ImeMode = (ImeMode)0;
		Label obj65 = lblTen_nh_kh;
		location = new Point(818, 88);
		((Control)obj65).Location = location;
		((Control)lblTen_nh_kh).Name = "lblTen_nh_kh";
		Label obj66 = lblTen_nh_kh;
		size = new Size(22, 13);
		((Control)obj66).Size = size;
		((Control)lblTen_nh_kh).TabIndex = 1371;
		lblTen_nh_kh.TextAlign = (ContentAlignment)16;
		((Control)lblTen_nh_kh).Visible = false;
		lblTen_kh.ImeMode = (ImeMode)0;
		Label obj67 = lblTen_kh;
		location = new Point(267, 143);
		((Control)obj67).Location = location;
		((Control)lblTen_kh).Name = "lblTen_kh";
		Label obj68 = lblTen_kh;
		size = new Size(442, 13);
		((Control)obj68).Size = size;
		((Control)lblTen_kh).TabIndex = 1370;
		lblTen_kh.TextAlign = (ContentAlignment)16;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox18 = txtMa_vt;
		location = new Point(174, 402);
		((Control)asTextBox18).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((TextBoxBase)txtMa_vt).MaxLength = 20;
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox19 = txtMa_vt;
		size = new Size(90, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtMa_vt).TabIndex = 18;
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_vt.AutoSize = true;
		Label obj69 = lblMa_vt;
		location = new Point(24, 405);
		((Control)obj69).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj70 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj70).Size = size;
		((Control)lblMa_vt).TabIndex = 1369;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtMa_hd;
		location = new Point(174, 235);
		((Control)asTextBox20).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((TextBoxBase)txtMa_hd).MaxLength = 20;
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox21 = txtMa_hd;
		size = new Size(90, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMa_hd).TabIndex = 11;
		txtMa_hd.UseAutoCompleteSource = true;
		lblMa_hd.AutoSize = true;
		Label obj71 = lblMa_hd;
		location = new Point(24, 239);
		((Control)obj71).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj72 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj72).Size = size;
		((Control)lblMa_hd).TabIndex = 1368;
		lblMa_hd.Text = "Mã hợp đồng";
		txtMa_nh_ncc.AutoLookup = true;
		txtMa_nh_ncc.AutoValid = false;
		((TextBoxBase)txtMa_nh_ncc).BackColor = SystemColors.Info;
		((TextBox)txtMa_nh_ncc).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_nh_ncc).Enabled = false;
		AsTextBox asTextBox22 = txtMa_nh_ncc;
		location = new Point(706, 84);
		((Control)asTextBox22).Location = location;
		txtMa_nh_ncc.LookupCodeName = "MA_NHKH";
		((TextBoxBase)txtMa_nh_ncc).MaxLength = 20;
		((Control)txtMa_nh_ncc).Name = "txtMa_nh_ncc";
		txtMa_nh_ncc.NameControl = lblTen_nh_kh;
		AsTextBox asTextBox23 = txtMa_nh_ncc;
		size = new Size(90, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMa_nh_ncc).TabIndex = 1;
		txtMa_nh_ncc.UseAutoCompleteSource = true;
		((Control)txtMa_nh_ncc).Visible = false;
		lblMa_nh_ncc.AutoSize = true;
		((Control)lblMa_nh_ncc).Enabled = false;
		Label obj73 = lblMa_nh_ncc;
		location = new Point(607, 88);
		((Control)obj73).Location = location;
		((Control)lblMa_nh_ncc).Name = "lblMa_nh_ncc";
		Label obj74 = lblMa_nh_ncc;
		size = new Size(76, 13);
		((Control)obj74).Size = size;
		((Control)lblMa_nh_ncc).TabIndex = 1364;
		lblMa_nh_ncc.Text = "Mã nhóm NCC";
		((Control)lblMa_nh_ncc).Visible = false;
		txtMa_ncc.AutoLookup = true;
		txtMa_ncc.AutoValid = false;
		((TextBoxBase)txtMa_ncc).BackColor = SystemColors.Info;
		((TextBox)txtMa_ncc).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox24 = txtMa_ncc;
		location = new Point(174, 139);
		((Control)asTextBox24).Location = location;
		txtMa_ncc.LookupCodeName = "MA_NCC";
		txtMa_ncc.LookupWhereCondition = "isncc=1";
		((TextBoxBase)txtMa_ncc).MaxLength = 20;
		((Control)txtMa_ncc).Name = "txtMa_ncc";
		txtMa_ncc.NameControl = lblTen_kh;
		AsTextBox asTextBox25 = txtMa_ncc;
		size = new Size(90, 20);
		((Control)asTextBox25).Size = size;
		((Control)txtMa_ncc).TabIndex = 7;
		txtMa_ncc.UseAutoCompleteSource = true;
		lblMa_ncc.AutoSize = true;
		Label obj75 = lblMa_ncc;
		location = new Point(24, 143);
		((Control)obj75).Location = location;
		((Control)lblMa_ncc).Name = "lblMa_ncc";
		Label obj76 = lblMa_ncc;
		size = new Size(91, 13);
		((Control)obj76).Size = size;
		((Control)lblMa_ncc).TabIndex = 1363;
		lblMa_ncc.Text = "Mã nhà cung cấp";
		Label obj77 = lblTen_spct;
		location = new Point(267, 382);
		((Control)obj77).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj78 = lblTen_spct;
		size = new Size(442, 13);
		((Control)obj78).Size = size;
		((Control)lblTen_spct).TabIndex = 23;
		txtPl_ncc1.AutoLookup = true;
		txtPl_ncc1.AutoValid = false;
		((TextBoxBase)txtPl_ncc1).BackColor = SystemColors.Info;
		((TextBox)txtPl_ncc1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox26 = txtPl_ncc1;
		location = new Point(174, 163);
		((Control)asTextBox26).Location = location;
		txtPl_ncc1.LookupCodeName = "MA_PLKH";
		txtPl_ncc1.LookupWhereCondition = "loai = 1";
		((TextBoxBase)txtPl_ncc1).MaxLength = 20;
		((Control)txtPl_ncc1).Name = "txtPl_ncc1";
		txtPl_ncc1.NameControl = lblTen_pl_kh1;
		AsTextBox asTextBox27 = txtPl_ncc1;
		size = new Size(90, 20);
		((Control)asTextBox27).Size = size;
		((Control)txtPl_ncc1).TabIndex = 8;
		txtPl_ncc1.UseAutoCompleteSource = true;
		lblTen_pl_kh1.ImeMode = (ImeMode)0;
		Label obj79 = lblTen_pl_kh1;
		location = new Point(267, 167);
		((Control)obj79).Location = location;
		((Control)lblTen_pl_kh1).Name = "lblTen_pl_kh1";
		Label obj80 = lblTen_pl_kh1;
		size = new Size(442, 13);
		((Control)obj80).Size = size;
		((Control)lblTen_pl_kh1).TabIndex = 1372;
		lblTen_pl_kh1.TextAlign = (ContentAlignment)16;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox28 = txtMa_spct;
		location = new Point(174, 378);
		((Control)asTextBox28).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox29 = txtMa_spct;
		size = new Size(90, 20);
		((Control)asTextBox29).Size = size;
		((Control)txtMa_spct).TabIndex = 17;
		((Control)txtMa_spct).Tag = "MA_SPCT";
		txtMa_spct.UseAutoCompleteSource = true;
		lblPl_ncc1.AutoSize = true;
		Label obj81 = lblPl_ncc1;
		location = new Point(24, 167);
		((Control)obj81).Location = location;
		((Control)lblPl_ncc1).Name = "lblPl_ncc1";
		Label obj82 = lblPl_ncc1;
		size = new Size(67, 13);
		((Control)obj82).Size = size;
		((Control)lblPl_ncc1).TabIndex = 1365;
		lblPl_ncc1.Text = "P loại  NCC1";
		lblMa_spct.AutoSize = true;
		Label obj83 = lblMa_spct;
		location = new Point(24, 382);
		((Control)obj83).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj84 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj84).Size = size;
		((Control)lblMa_spct).TabIndex = 1400;
		lblMa_spct.Text = "Mã SPCT";
		lblPl_ncc2.AutoSize = true;
		Label obj85 = lblPl_ncc2;
		location = new Point(24, 191);
		((Control)obj85).Location = location;
		((Control)lblPl_ncc2).Name = "lblPl_ncc2";
		Label obj86 = lblPl_ncc2;
		size = new Size(64, 13);
		((Control)obj86).Size = size;
		((Control)lblPl_ncc2).TabIndex = 1366;
		lblPl_ncc2.Text = "P loại NCC2";
		txtPl_ncc2.AutoLookup = true;
		txtPl_ncc2.AutoValid = false;
		((TextBoxBase)txtPl_ncc2).BackColor = SystemColors.Info;
		((TextBox)txtPl_ncc2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox30 = txtPl_ncc2;
		location = new Point(174, 187);
		((Control)asTextBox30).Location = location;
		txtPl_ncc2.LookupCodeName = "MA_PLKH";
		txtPl_ncc2.LookupWhereCondition = "loai = 2";
		((TextBoxBase)txtPl_ncc2).MaxLength = 20;
		((Control)txtPl_ncc2).Name = "txtPl_ncc2";
		txtPl_ncc2.NameControl = lblTen_pl_kh2;
		AsTextBox asTextBox31 = txtPl_ncc2;
		size = new Size(90, 20);
		((Control)asTextBox31).Size = size;
		((Control)txtPl_ncc2).TabIndex = 9;
		txtPl_ncc2.UseAutoCompleteSource = true;
		lblTen_pl_kh2.ImeMode = (ImeMode)0;
		Label obj87 = lblTen_pl_kh2;
		location = new Point(267, 191);
		((Control)obj87).Location = location;
		((Control)lblTen_pl_kh2).Name = "lblTen_pl_kh2";
		Label obj88 = lblTen_pl_kh2;
		size = new Size(442, 13);
		((Control)obj88).Size = size;
		((Control)lblTen_pl_kh2).TabIndex = 1373;
		lblTen_pl_kh2.TextAlign = (ContentAlignment)16;
		lblPl_ncc3.AutoSize = true;
		Label obj89 = lblPl_ncc3;
		location = new Point(24, 215);
		((Control)obj89).Location = location;
		((Control)lblPl_ncc3).Name = "lblPl_ncc3";
		Label obj90 = lblPl_ncc3;
		size = new Size(64, 13);
		((Control)obj90).Size = size;
		((Control)lblPl_ncc3).TabIndex = 1367;
		lblPl_ncc3.Text = "P loại NCC3";
		txtPl_ncc3.AutoLookup = true;
		txtPl_ncc3.AutoValid = false;
		((TextBoxBase)txtPl_ncc3).BackColor = SystemColors.Info;
		((TextBox)txtPl_ncc3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox32 = txtPl_ncc3;
		location = new Point(174, 211);
		((Control)asTextBox32).Location = location;
		txtPl_ncc3.LookupCodeName = "MA_PLKH";
		txtPl_ncc3.LookupWhereCondition = "loai = 3";
		((TextBoxBase)txtPl_ncc3).MaxLength = 20;
		((Control)txtPl_ncc3).Name = "txtPl_ncc3";
		txtPl_ncc3.NameControl = lblTen_pl_kh3;
		AsTextBox asTextBox33 = txtPl_ncc3;
		size = new Size(90, 20);
		((Control)asTextBox33).Size = size;
		((Control)txtPl_ncc3).TabIndex = 10;
		txtPl_ncc3.UseAutoCompleteSource = true;
		lblTen_pl_kh3.ImeMode = (ImeMode)0;
		Label obj91 = lblTen_pl_kh3;
		location = new Point(267, 215);
		((Control)obj91).Location = location;
		((Control)lblTen_pl_kh3).Name = "lblTen_pl_kh3";
		Label obj92 = lblTen_pl_kh3;
		size = new Size(442, 13);
		((Control)obj92).Size = size;
		((Control)lblTen_pl_kh3).TabIndex = 1374;
		lblTen_pl_kh3.TextAlign = (ContentAlignment)16;
		Label obj93 = lblTenPhi;
		location = new Point(267, 359);
		((Control)obj93).Location = location;
		((Control)lblTenPhi).Name = "lblTenPhi";
		Label obj94 = lblTenPhi;
		size = new Size(442, 13);
		((Control)obj94).Size = size;
		((Control)lblTenPhi).TabIndex = 1393;
		txtMa_Plvt1.AutoLookup = true;
		txtMa_Plvt1.AutoValid = false;
		((TextBoxBase)txtMa_Plvt1).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plvt1).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_Plvt1).Enabled = false;
		AsTextBox asTextBox34 = txtMa_Plvt1;
		location = new Point(706, 6);
		((Control)asTextBox34).Location = location;
		txtMa_Plvt1.LookupCodeName = "MA_PLVT";
		txtMa_Plvt1.LookupWhereCondition = "loai='1'";
		((Control)txtMa_Plvt1).Name = "txtMa_Plvt1";
		txtMa_Plvt1.NameControl = lblTen_plvt1;
		AsTextBox asTextBox35 = txtMa_Plvt1;
		size = new Size(90, 20);
		((Control)asTextBox35).Size = size;
		((Control)txtMa_Plvt1).TabIndex = 3;
		((Control)txtMa_Plvt1).Tag = "MA_PLVT";
		txtMa_Plvt1.UseAutoCompleteSource = true;
		((Control)txtMa_Plvt1).Visible = false;
		((Control)lblTen_plvt1).Enabled = false;
		Label obj95 = lblTen_plvt1;
		location = new Point(818, 10);
		((Control)obj95).Location = location;
		((Control)lblTen_plvt1).Name = "lblTen_plvt1";
		Label obj96 = lblTen_plvt1;
		size = new Size(22, 13);
		((Control)obj96).Size = size;
		((Control)lblTen_plvt1).TabIndex = 1383;
		((Control)lblTen_plvt1).Visible = false;
		txtMaPhi.AutoLookup = true;
		txtMaPhi.AutoValid = false;
		((TextBoxBase)txtMaPhi).BackColor = SystemColors.Info;
		((TextBox)txtMaPhi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox36 = txtMaPhi;
		location = new Point(174, 355);
		((Control)asTextBox36).Location = location;
		txtMaPhi.LookupCodeName = "MA_PHI";
		((Control)txtMaPhi).Name = "txtMaPhi";
		txtMaPhi.NameControl = lblTenPhi;
		AsTextBox asTextBox37 = txtMaPhi;
		size = new Size(90, 20);
		((Control)asTextBox37).Size = size;
		((Control)txtMaPhi).TabIndex = 16;
		((Control)txtMaPhi).Tag = "MA_PHI";
		txtMaPhi.UseAutoCompleteSource = true;
		lblMaPhi.AutoSize = true;
		Label obj97 = lblMaPhi;
		location = new Point(24, 359);
		((Control)obj97).Location = location;
		((Control)lblMaPhi).Name = "lblMaPhi";
		Label obj98 = lblMaPhi;
		size = new Size(41, 13);
		((Control)obj98).Size = size;
		((Control)lblMaPhi).TabIndex = 1394;
		lblMaPhi.Text = "Mã phí";
		lblPlvt3.AutoSize = true;
		((Control)lblPlvt3).Enabled = false;
		Label obj99 = lblPlvt3;
		location = new Point(607, 62);
		((Control)obj99).Location = location;
		((Control)lblPlvt3).Name = "lblPlvt3";
		Label obj100 = lblPlvt3;
		size = new Size(56, 13);
		((Control)obj100).Size = size;
		((Control)lblPlvt3).TabIndex = 1386;
		lblPlvt3.Text = "P.loại VT3";
		((Control)lblPlvt3).Visible = false;
		txtMa_plvt3.AutoLookup = true;
		txtMa_plvt3.AutoValid = false;
		((TextBoxBase)txtMa_plvt3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt3).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt3).Enabled = false;
		AsTextBox asTextBox38 = txtMa_plvt3;
		location = new Point(706, 58);
		((Control)asTextBox38).Location = location;
		txtMa_plvt3.LookupCodeName = "MA_PLVT";
		txtMa_plvt3.LookupWhereCondition = "loai='3'";
		((Control)txtMa_plvt3).Name = "txtMa_plvt3";
		txtMa_plvt3.NameControl = lblTen_plvt3;
		AsTextBox asTextBox39 = txtMa_plvt3;
		size = new Size(90, 20);
		((Control)asTextBox39).Size = size;
		((Control)txtMa_plvt3).TabIndex = 5;
		((Control)txtMa_plvt3).Tag = "MA_PLVT";
		txtMa_plvt3.UseAutoCompleteSource = true;
		((Control)txtMa_plvt3).Visible = false;
		((Control)lblTen_plvt3).Enabled = false;
		Label obj101 = lblTen_plvt3;
		location = new Point(818, 62);
		((Control)obj101).Location = location;
		((Control)lblTen_plvt3).Name = "lblTen_plvt3";
		Label obj102 = lblTen_plvt3;
		size = new Size(22, 13);
		((Control)obj102).Size = size;
		((Control)lblTen_plvt3).TabIndex = 1385;
		((Control)lblTen_plvt3).Visible = false;
		lblPlvt2.AutoSize = true;
		((Control)lblPlvt2).Enabled = false;
		Label obj103 = lblPlvt2;
		location = new Point(607, 36);
		((Control)obj103).Location = location;
		((Control)lblPlvt2).Name = "lblPlvt2";
		Label obj104 = lblPlvt2;
		size = new Size(56, 13);
		((Control)obj104).Size = size;
		((Control)lblPlvt2).TabIndex = 1387;
		lblPlvt2.Text = "P.loại VT2";
		((Control)lblPlvt2).Visible = false;
		txtMa_Plvt2.AutoLookup = true;
		txtMa_Plvt2.AutoValid = false;
		((TextBoxBase)txtMa_Plvt2).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plvt2).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_Plvt2).Enabled = false;
		AsTextBox asTextBox40 = txtMa_Plvt2;
		location = new Point(706, 32);
		((Control)asTextBox40).Location = location;
		txtMa_Plvt2.LookupCodeName = "MA_PLVT";
		txtMa_Plvt2.LookupWhereCondition = "loai='2'";
		((Control)txtMa_Plvt2).Name = "txtMa_Plvt2";
		txtMa_Plvt2.NameControl = lblTen_plvt2;
		AsTextBox asTextBox41 = txtMa_Plvt2;
		size = new Size(90, 20);
		((Control)asTextBox41).Size = size;
		((Control)txtMa_Plvt2).TabIndex = 4;
		((Control)txtMa_Plvt2).Tag = "MA_PLVT";
		txtMa_Plvt2.UseAutoCompleteSource = true;
		((Control)txtMa_Plvt2).Visible = false;
		((Control)lblTen_plvt2).Enabled = false;
		Label obj105 = lblTen_plvt2;
		location = new Point(818, 36);
		((Control)obj105).Location = location;
		((Control)lblTen_plvt2).Name = "lblTen_plvt2";
		Label obj106 = lblTen_plvt2;
		size = new Size(22, 13);
		((Control)obj106).Size = size;
		((Control)lblTen_plvt2).TabIndex = 1384;
		((Control)lblTen_plvt2).Visible = false;
		lblPlvt1.AutoSize = true;
		((Control)lblPlvt1).Enabled = false;
		Label obj107 = lblPlvt1;
		location = new Point(607, 10);
		((Control)obj107).Location = location;
		((Control)lblPlvt1).Name = "lblPlvt1";
		Label obj108 = lblPlvt1;
		size = new Size(56, 13);
		((Control)obj108).Size = size;
		((Control)lblPlvt1).TabIndex = 1388;
		lblPlvt1.Text = "P.loại VT1";
		((Control)lblPlvt1).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(950, 582);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmPORptBK03";
		((Form)this).Text = "frmPORptBK03";
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
		ComboBox val = cboNhom_theo;
		ArrayList arrayList = new ArrayList();
		DictionaryEntry dictionaryEntry = new DictionaryEntry("MA_KH", RuntimeHelpers.GetObjectValue(val.Items[0]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("MA_BP", RuntimeHelpers.GetObjectValue(val.Items[1]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("MA_HD", RuntimeHelpers.GetObjectValue(val.Items[2]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("MA_HTTT", RuntimeHelpers.GetObjectValue(val.Items[3]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("MA_VT", RuntimeHelpers.GetObjectValue(val.Items[4]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("STT_REC", RuntimeHelpers.GetObjectValue(val.Items[5]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("MA_SPCT", RuntimeHelpers.GetObjectValue(val.Items[6]));
		arrayList.Add(dictionaryEntry);
		val.Items.Clear();
		val.DataSource = arrayList;
		((ListControl)val).ValueMember = "Key";
		((ListControl)val).DisplayMember = "Value";
		val.SelectedIndex = 0;
		val = null;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_ncc).Text);
		arrayList.Add(((TextBox)txtMa_nh_ncc).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_nh_vt).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_bp).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(txtSo_CT1.Text);
		arrayList.Add(txtSo_CT2.Text);
		arrayList.Add(((TextBox)txtPl_ncc1).Text);
		arrayList.Add(((TextBox)txtPl_ncc2).Text);
		arrayList.Add(((TextBox)txtPl_ncc3).Text);
		DictionaryEntry dictionaryEntry = (DictionaryEntry)cboNhom_theo.SelectedItem;
		arrayList.Add(RuntimeHelpers.GetObjectValue(dictionaryEntry.Key));
		arrayList.Add(((TextBox)txtMa_nhhd).Text);
		arrayList.Add(((TextBox)txtMa_Plvt1).Text);
		arrayList.Add(((TextBox)txtMa_Plvt2).Text);
		arrayList.Add(((TextBox)txtMa_plvt3).Text);
		arrayList.Add(((TextBox)txtMa_vtri).Text);
		arrayList.Add(((TextBox)txtMaLo).Text);
		arrayList.Add(((TextBox)txtMA_HTTT).Text);
		arrayList.Add(((TextBox)txtMA_DKTT).Text);
		arrayList.Add(((TextBox)txtMa_spct).Text);
		arrayList.Add(((TextBox)txtMaPhi).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(((TextBox)txtMa_vtri).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_vitri.Text + ":" + ((TextBox)txtMa_vtri).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMaLo).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_lo.Text + ":" + ((TextBox)txtMaLo).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMA_HTTT).Text.Trim(), "", false) != 0)
		{
			text = text + lblHTTT.Text + ":" + ((TextBox)txtMA_HTTT).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMA_DKTT).Text.Trim(), "", false) != 0)
		{
			text = text + lblDkTT.Text + ":" + ((TextBox)txtMA_DKTT).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_spct).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_spct.Text + ":" + ((TextBox)txtMa_spct).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMaPhi).Text.Trim(), "", false) != 0)
		{
			text = text + lblTenPhi.Text + ":" + ((TextBox)txtMaPhi).Text + "; ";
		}
		text = text + lblNhom_theo.Text + ": " + cboNhom_theo.Text + "; ";
		if (Operators.CompareString(txtSo_CT1.Text, "", false) != 0)
		{
			text = text + lblSo_ct1.Text + ": " + txtSo_CT1.Text + "; ";
		}
		if (Operators.CompareString(txtSo_CT2.Text, "", false) != 0)
		{
			text = text + lblSo_ct2.Text + ": " + txtSo_CT2.Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_ncc).Text, "", false) != 0)
		{
			text = text + lblMa_ncc.Text + " : " + ((TextBox)txtMa_ncc).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nh_ncc).Text, "", false) != 0)
		{
			text = text + lblMa_nh_ncc.Text + ": " + ((TextBox)txtMa_nh_ncc).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtPl_ncc1).Text, "", false) != 0)
		{
			text = text + lblPl_ncc1.Text + ": " + ((TextBox)txtPl_ncc1).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtPl_ncc2).Text, "", false) != 0)
		{
			text = text + lblPl_ncc2.Text + ": " + ((TextBox)txtPl_ncc2).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtPl_ncc3).Text, "", false) != 0)
		{
			text = text + lblPl_ncc3.Text + ": " + ((TextBox)txtPl_ncc3).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_hd).Text, "", false) != 0)
		{
			text = text + lblMa_hd.Text + ": " + ((TextBox)txtMa_hd).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
		{
			text = text + lblMa_vt.Text + ": " + ((TextBox)txtMa_vt).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nh_vt).Text, "", false) != 0)
		{
			text = text + lblMa_nh_vt.Text + ": " + ((TextBox)txtMa_nh_vt).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text, "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": " + ((TextBox)txtMa_kho).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_bp).Text, "", false) != 0)
		{
			text = text + lblMa_bp.Text + ": " + ((TextBox)txtMa_bp).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
		}
		return text;
	}
}
