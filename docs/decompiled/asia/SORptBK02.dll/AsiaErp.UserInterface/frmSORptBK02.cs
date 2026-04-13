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

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSORptBK02 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cboNhom_theo")]
	private AsComboBox _cboNhom_theo;

	[AccessedThroughProperty("lblNhom_theo")]
	private Label _lblNhom_theo;

	[AccessedThroughProperty("txtSo_ct2")]
	private TextBox _txtSo_ct2;

	[AccessedThroughProperty("txtSo_ct1")]
	private TextBox _txtSo_ct1;

	[AccessedThroughProperty("lblSo_ct2")]
	private Label _lblSo_ct2;

	[AccessedThroughProperty("lblSo_Ct1")]
	private Label _lblSo_Ct1;

	[AccessedThroughProperty("lblTrang_Thai")]
	private Label _lblTrang_Thai;

	[AccessedThroughProperty("cboTrang_Thai")]
	private AsComboBox _cboTrang_Thai;

	[AccessedThroughProperty("cboLoaiPhieu")]
	private AsComboBox _cboLoaiPhieu;

	[AccessedThroughProperty("lblLoaiPhieu")]
	private Label _lblLoaiPhieu;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

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

	[AccessedThroughProperty("txtMa_Lo")]
	private AsTextBox _txtMa_Lo;

	[AccessedThroughProperty("lblMaLo")]
	private Label _lblMaLo;

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("txtMa_vitri")]
	private AsTextBox _txtMa_vitri;

	[AccessedThroughProperty("lblMavitri")]
	private Label _lblMavitri;

	[AccessedThroughProperty("txtMa_nvkd")]
	private AsTextBox _txtMa_nvkd;

	[AccessedThroughProperty("lblTen_nvkd")]
	private Label _lblTen_nvkd;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("txtMa_plvt3")]
	private AsTextBox _txtMa_plvt3;

	[AccessedThroughProperty("lblTen_plvt3")]
	private Label _lblTen_plvt3;

	[AccessedThroughProperty("txtMa_plvt2")]
	private AsTextBox _txtMa_plvt2;

	[AccessedThroughProperty("lblTen_plvt2")]
	private Label _lblTen_plvt2;

	[AccessedThroughProperty("txtMa_plvt1")]
	private AsTextBox _txtMa_plvt1;

	[AccessedThroughProperty("lblTen_plvt1")]
	private Label _lblTen_plvt1;

	[AccessedThroughProperty("txtMa_nhvt")]
	private AsTextBox _txtMa_nhvt;

	[AccessedThroughProperty("lblTen_nhvt")]
	private Label _lblTen_nhvt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("txtMa_nhhd")]
	private AsTextBox _txtMa_nhhd;

	[AccessedThroughProperty("lblTen_nhhd")]
	private Label _lblTen_nhhd;

	[AccessedThroughProperty("lblMa_nvkd")]
	private Label _lblMa_nvkd;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("lblMa_plvt3")]
	private Label _lblMa_plvt3;

	[AccessedThroughProperty("lblMa_plvt2")]
	private Label _lblMa_plvt2;

	[AccessedThroughProperty("lblMa_plvt1")]
	private Label _lblMa_plvt1;

	[AccessedThroughProperty("lblMa_nhvt")]
	private Label _lblMa_nhvt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("txtMa_plkh3")]
	private AsTextBox _txtMa_plkh3;

	[AccessedThroughProperty("lblTen_plkh3")]
	private Label _lblTen_plkh3;

	[AccessedThroughProperty("txtMa_plkh2")]
	private AsTextBox _txtMa_plkh2;

	[AccessedThroughProperty("lblTen_plkh2")]
	private Label _lblTen_plkh2;

	[AccessedThroughProperty("txtMa_plkh1")]
	private AsTextBox _txtMa_plkh1;

	[AccessedThroughProperty("lblTen_plkh1")]
	private Label _lblTen_plkh1;

	[AccessedThroughProperty("txtMa_nhkh")]
	private AsTextBox _txtMa_nhkh;

	[AccessedThroughProperty("lblTen_nhkh")]
	private Label _lblTen_nhkh;

	[AccessedThroughProperty("txtMa_kh")]
	private AsTextBox _txtMa_kh;

	[AccessedThroughProperty("lblTen_kh")]
	private Label _lblTen_kh;

	[AccessedThroughProperty("lblMa_kh")]
	private Label _lblMa_kh;

	[AccessedThroughProperty("lblMa_nhkh")]
	private Label _lblMa_nhkh;

	[AccessedThroughProperty("lblMa_plkh1")]
	private Label _lblMa_plkh1;

	[AccessedThroughProperty("lblMa_plkh2")]
	private Label _lblMa_plkh2;

	[AccessedThroughProperty("lblMa_plkh3")]
	private Label _lblMa_plkh3;

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

	[AccessedThroughProperty("lblMa_nhhd")]
	private Label _lblMa_nhhd;

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

	internal virtual AsComboBox cboNhom_theo
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

	internal virtual TextBox txtSo_ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ct2 = value;
		}
	}

	internal virtual TextBox txtSo_ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ct1 = value;
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

	internal virtual Label lblLoaiPhieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoaiPhieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoaiPhieu = value;
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

	internal virtual AsTextBox txtMa_Lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Lo = value;
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

	private virtual AsTextBox txtMa_kho
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

	private virtual Label lblTen_kho
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

	private virtual AsTextBox txtMa_plvt3
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

	private virtual Label lblTen_plvt3
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

	private virtual AsTextBox txtMa_plvt2
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

	private virtual Label lblTen_plvt2
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

	private virtual AsTextBox txtMa_plvt1
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

	private virtual Label lblTen_plvt1
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

	private virtual AsTextBox txtMa_nhvt
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

	private virtual Label lblTen_nhvt
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
			_txtMa_vt = value;
		}
	}

	private virtual Label lblTen_vt
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

	private virtual AsTextBox txtMa_nhhd
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

	private virtual Label lblTen_nhhd
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

	internal virtual Label lblMa_plvt3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_plvt3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_plvt3 = value;
		}
	}

	internal virtual Label lblMa_plvt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_plvt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_plvt2 = value;
		}
	}

	internal virtual Label lblMa_plvt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_plvt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_plvt1 = value;
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

	private virtual AsTextBox txtMa_plkh3
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

	private virtual Label lblTen_plkh3
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

	private virtual AsTextBox txtMa_plkh2
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

	private virtual Label lblTen_plkh2
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

	private virtual AsTextBox txtMa_plkh1
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

	private virtual Label lblTen_plkh1
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

	private virtual AsTextBox txtMa_nhkh
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

	private virtual Label lblTen_nhkh
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
			_txtMa_kh = value;
		}
	}

	private virtual Label lblTen_kh
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

	internal virtual Label lblMa_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kh = value;
		}
	}

	internal virtual Label lblMa_nhkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhkh = value;
		}
	}

	internal virtual Label lblMa_plkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_plkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_plkh1 = value;
		}
	}

	internal virtual Label lblMa_plkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_plkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_plkh2 = value;
		}
	}

	internal virtual Label lblMa_plkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_plkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_plkh3 = value;
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
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
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
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_4024: Unknown result type (might be due to invalid IL or missing references)
		//IL_402e: Expected O, but got Unknown
		lblNhom_theo = new Label();
		cboNhom_theo = new AsComboBox();
		lblSo_Ct1 = new Label();
		lblSo_ct2 = new Label();
		txtSo_ct1 = new TextBox();
		txtSo_ct2 = new TextBox();
		lblTrang_Thai = new Label();
		cboTrang_Thai = new AsComboBox();
		cboLoaiPhieu = new AsComboBox();
		lblLoaiPhieu = new Label();
		lblTen_TT = new Label();
		txtMA_DKTT = new AsTextBox();
		lblDkTT = new Label();
		lblTenHTTT = new Label();
		txtMA_HTTT = new AsTextBox();
		lblHTTT = new Label();
		txtMa_nvkd = new AsTextBox();
		lblTen_nvkd = new Label();
		txtMa_bp = new AsTextBox();
		lblTen_bp = new Label();
		txtMa_nhvt = new AsTextBox();
		lblTen_nhvt = new Label();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		txtMa_nhhd = new AsTextBox();
		lblTen_nhhd = new Label();
		lblMa_nvkd = new Label();
		lblMa_bp = new Label();
		lblMa_nhvt = new Label();
		lblMa_vt = new Label();
		txtMa_hd = new AsTextBox();
		lblTen_hd = new Label();
		txtMa_nhkh = new AsTextBox();
		lblTen_nhkh = new Label();
		txtMa_kh = new AsTextBox();
		lblTen_kh = new Label();
		lblMa_kh = new Label();
		lblMa_nhkh = new Label();
		lblMa_hd = new Label();
		lblMa_nhhd = new Label();
		lblTen_spct = new Label();
		txtMa_plkh1 = new AsTextBox();
		lblTen_plkh1 = new Label();
		txtMa_spct = new AsTextBox();
		lblMa_spct = new Label();
		lblTen_plkh2 = new Label();
		lblTen_plkh3 = new Label();
		lblMa_plkh3 = new Label();
		lblMa_plkh2 = new Label();
		lblMa_plkh1 = new Label();
		txtMa_plkh2 = new AsTextBox();
		txtMa_plkh3 = new AsTextBox();
		lblTen_lo = new Label();
		txtMa_plvt1 = new AsTextBox();
		lblTen_plvt1 = new Label();
		txtMa_Lo = new AsTextBox();
		lblMa_plvt1 = new Label();
		lblMaLo = new Label();
		lblMa_plvt2 = new Label();
		lblTen_vitri = new Label();
		lblMa_plvt3 = new Label();
		txtMa_vitri = new AsTextBox();
		lblMavitri = new Label();
		lblTen_plvt2 = new Label();
		lblTen_plvt3 = new Label();
		txtMa_plvt2 = new AsTextBox();
		txtMa_kho = new AsTextBox();
		lblTen_kho = new Label();
		txtMa_plvt3 = new AsTextBox();
		lblMa_kho = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(1101, 629);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_TT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_DKTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoaiPhieu);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblDkTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoaiPhieu);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTenHTTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_HTTT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblHTTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lo);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Lo);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMavitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhkh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_ct2);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhkh);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_ct1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_ct2);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTrang_Thai);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_hd);
		((Control)tabFilter).Controls.Add((Control)(object)cboTrang_Thai);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhkh);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_theo);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom_theo);
		TabPage obj = tabFilter;
		size = new Size(1093, 600);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom_theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhkh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboTrang_Thai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTrang_Thai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhkh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhkh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMavitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblHTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_HTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTenHTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoaiPhieu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDkTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoaiPhieu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_DKTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_TT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		Label obj2 = lbl2;
		Point location = new Point(327, 69);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 2;
		Button obj3 = cmdExcel;
		location = new Point(710, 957);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 27;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(346, 65);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(629, 955);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 32;
		Button obj5 = cmdModifyReport;
		location = new Point(505, 16);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 35;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(256, 65);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(160, 65);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(20, 69);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(160, 16);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 33;
		Label obj9 = lblMau_bc;
		location = new Point(20, 19);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(160, 504);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 22;
		Label obj10 = lblMauBC;
		location = new Point(203, 508);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 11;
		RadioButton obj11 = optVND;
		location = new Point(281, 506);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 23;
		RadioButton obj12 = optNt;
		location = new Point(335, 506);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 24;
		Label obj13 = lblMa_nt;
		location = new Point(20, 505);
		((Control)obj13).Location = location;
		((Control)lblMa_nt).TabIndex = 9;
		Button obj14 = cmdOk;
		location = new Point(20, 533);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 25;
		Label obj15 = lblTieu_de;
		location = new Point(20, 45);
		((Control)obj15).Location = location;
		((Control)lblTieu_de).TabIndex = 29;
		TextBox obj16 = txtTieu_De;
		location = new Point(160, 41);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 34;
		lblNhom_theo.AutoSize = true;
		Label obj17 = lblNhom_theo;
		location = new Point(20, 117);
		((Control)obj17).Location = location;
		((Control)lblNhom_theo).Name = "lblNhom_theo";
		Label obj18 = lblNhom_theo;
		size = new Size(59, 13);
		((Control)obj18).Size = size;
		((Control)lblNhom_theo).TabIndex = 1016;
		lblNhom_theo.Text = "Nhóm theo";
		((ComboBox)cboNhom_theo).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_theo).FormattingEnabled = true;
		((ComboBox)cboNhom_theo).Items.AddRange(new object[10] { "Khách hàng", "Bộ phận", "Hợp đồng", "Hình thức thanh toán", "Nhân viên kinh doanh", "Sản phẩm công trình", "Vật tư", "Kho", "Lô", "Chứng từ" });
		AsComboBox asComboBox = cboNhom_theo;
		location = new Point(160, 116);
		((Control)asComboBox).Location = location;
		((Control)cboNhom_theo).Name = "cboNhom_theo";
		AsComboBox asComboBox2 = cboNhom_theo;
		size = new Size(207, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboNhom_theo).TabIndex = 7;
		lblSo_Ct1.AutoSize = true;
		Label obj19 = lblSo_Ct1;
		location = new Point(20, 91);
		((Control)obj19).Location = location;
		((Control)lblSo_Ct1).Name = "lblSo_Ct1";
		Label obj20 = lblSo_Ct1;
		size = new Size(49, 13);
		((Control)obj20).Size = size;
		((Control)lblSo_Ct1).TabIndex = 1177;
		lblSo_Ct1.Text = "Ctừ từ số";
		lblSo_ct2.AutoSize = true;
		Label obj21 = lblSo_ct2;
		location = new Point(267, 93);
		((Control)obj21).Location = location;
		((Control)lblSo_ct2).Name = "lblSo_ct2";
		Label obj22 = lblSo_ct2;
		size = new Size(40, 13);
		((Control)obj22).Size = size;
		((Control)lblSo_ct2).TabIndex = 1178;
		lblSo_ct2.Text = "đến số";
		TextBox obj23 = txtSo_ct1;
		location = new Point(160, 90);
		((Control)obj23).Location = location;
		((Control)txtSo_ct1).Name = "txtSo_ct1";
		TextBox obj24 = txtSo_ct1;
		size = new Size(90, 20);
		((Control)obj24).Size = size;
		((Control)txtSo_ct1).TabIndex = 3;
		TextBox obj25 = txtSo_ct2;
		location = new Point(323, 90);
		((Control)obj25).Location = location;
		((Control)txtSo_ct2).Name = "txtSo_ct2";
		TextBox obj26 = txtSo_ct2;
		size = new Size(90, 20);
		((Control)obj26).Size = size;
		((Control)txtSo_ct2).TabIndex = 4;
		lblTrang_Thai.AutoSize = true;
		((Control)lblTrang_Thai).Enabled = false;
		Label obj27 = lblTrang_Thai;
		location = new Point(827, 84);
		((Control)obj27).Location = location;
		((Control)lblTrang_Thai).Name = "lblTrang_Thai";
		Label obj28 = lblTrang_Thai;
		size = new Size(55, 13);
		((Control)obj28).Size = size;
		((Control)lblTrang_Thai).TabIndex = 1180;
		lblTrang_Thai.Text = "Trạng thái";
		((Control)lblTrang_Thai).Visible = false;
		((ComboBox)cboTrang_Thai).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboTrang_Thai).Enabled = false;
		((ListControl)cboTrang_Thai).FormattingEnabled = true;
		((ComboBox)cboTrang_Thai).Items.AddRange(new object[1] { "Tất cả" });
		AsComboBox asComboBox3 = cboTrang_Thai;
		location = new Point(888, 81);
		((Control)asComboBox3).Location = location;
		((Control)cboTrang_Thai).Name = "cboTrang_Thai";
		AsComboBox asComboBox4 = cboTrang_Thai;
		size = new Size(146, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboTrang_Thai).TabIndex = 6;
		((Control)cboTrang_Thai).Visible = false;
		((ComboBox)cboLoaiPhieu).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoaiPhieu).FormattingEnabled = true;
		((ComboBox)cboLoaiPhieu).Items.AddRange(new object[1] { "Tất cả" });
		AsComboBox asComboBox5 = cboLoaiPhieu;
		location = new Point(160, 143);
		((Control)asComboBox5).Location = location;
		((Control)cboLoaiPhieu).Name = "cboLoaiPhieu";
		AsComboBox asComboBox6 = cboLoaiPhieu;
		size = new Size(207, 21);
		((Control)asComboBox6).Size = size;
		((Control)cboLoaiPhieu).TabIndex = 5;
		lblLoaiPhieu.AutoSize = true;
		Label obj29 = lblLoaiPhieu;
		location = new Point(20, 144);
		((Control)obj29).Location = location;
		((Control)lblLoaiPhieu).Name = "lblLoaiPhieu";
		Label obj30 = lblLoaiPhieu;
		size = new Size(56, 13);
		((Control)obj30).Size = size;
		((Control)lblLoaiPhieu).TabIndex = 1182;
		lblLoaiPhieu.Text = "Loại phiếu";
		((Control)lblTen_TT).Enabled = false;
		Label obj31 = lblTen_TT;
		location = new Point(858, 399);
		((Control)obj31).Location = location;
		((Control)lblTen_TT).Name = "lblTen_TT";
		Label obj32 = lblTen_TT;
		size = new Size(246, 13);
		((Control)obj32).Size = size;
		((Control)lblTen_TT).TabIndex = 1314;
		((Control)lblTen_TT).Visible = false;
		txtMA_DKTT.AutoLookup = true;
		txtMA_DKTT.AutoValid = false;
		((TextBoxBase)txtMA_DKTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_DKTT).CharacterCasing = (CharacterCasing)1;
		((Control)txtMA_DKTT).Enabled = false;
		AsTextBox asTextBox2 = txtMA_DKTT;
		location = new Point(765, 390);
		((Control)asTextBox2).Location = location;
		txtMA_DKTT.LookupCodeName = "MA_TT";
		((Control)txtMA_DKTT).Name = "txtMA_DKTT";
		txtMA_DKTT.NameControl = lblTen_TT;
		AsTextBox asTextBox3 = txtMA_DKTT;
		size = new Size(88, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMA_DKTT).TabIndex = 9;
		((Control)txtMA_DKTT).Tag = "MA_TT";
		txtMA_DKTT.UseAutoCompleteSource = true;
		((Control)txtMA_DKTT).Visible = false;
		lblDkTT.AutoSize = true;
		((Control)lblDkTT).Enabled = false;
		Label obj33 = lblDkTT;
		location = new Point(667, 392);
		((Control)obj33).Location = location;
		((Control)lblDkTT).Name = "lblDkTT";
		Label obj34 = lblDkTT;
		size = new Size(79, 13);
		((Control)obj34).Size = size;
		((Control)lblDkTT).TabIndex = 1315;
		lblDkTT.Text = "Điều khoản TT";
		((Control)lblDkTT).Visible = false;
		Label obj35 = lblTenHTTT;
		location = new Point(253, 412);
		((Control)obj35).Location = location;
		((Control)lblTenHTTT).Name = "lblTenHTTT";
		Label obj36 = lblTenHTTT;
		size = new Size(521, 13);
		((Control)obj36).Size = size;
		((Control)lblTenHTTT).TabIndex = 1312;
		txtMA_HTTT.AutoLookup = true;
		txtMA_HTTT.AutoValid = false;
		((TextBoxBase)txtMA_HTTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_HTTT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMA_HTTT;
		location = new Point(160, 408);
		((Control)asTextBox4).Location = location;
		txtMA_HTTT.LookupCodeName = "MA_HTTT";
		txtMA_HTTT.LookupWhereCondition = "moduleid='so'";
		((Control)txtMA_HTTT).Name = "txtMA_HTTT";
		txtMA_HTTT.NameControl = lblTenHTTT;
		AsTextBox asTextBox5 = txtMA_HTTT;
		size = new Size(88, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMA_HTTT).TabIndex = 18;
		((Control)txtMA_HTTT).Tag = "MA_HTTT";
		txtMA_HTTT.UseAutoCompleteSource = true;
		lblHTTT.AutoSize = true;
		Label obj37 = lblHTTT;
		location = new Point(20, 412);
		((Control)obj37).Location = location;
		((Control)lblHTTT).Name = "lblHTTT";
		Label obj38 = lblHTTT;
		size = new Size(70, 13);
		((Control)obj38).Size = size;
		((Control)lblHTTT).TabIndex = 1313;
		lblHTTT.Text = "Hình thức TT";
		((TextBox)txtMa_nvkd).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_nvkd.AutoLookup = true;
		txtMa_nvkd.AutoValid = false;
		((TextBoxBase)txtMa_nvkd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nvkd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_nvkd;
		location = new Point(160, 384);
		((Control)asTextBox6).Location = location;
		txtMa_nvkd.LookupCodeName = "Ma_nvkd";
		((Control)txtMa_nvkd).Name = "txtMa_nvkd";
		txtMa_nvkd.NameControl = lblTen_nvkd;
		AsTextBox asTextBox7 = txtMa_nvkd;
		size = new Size(88, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_nvkd).TabIndex = 17;
		((Control)txtMa_nvkd).Tag = "@pMa_nvkd";
		txtMa_nvkd.UseAutoCompleteSource = true;
		lblTen_nvkd.ImeMode = (ImeMode)0;
		Label obj39 = lblTen_nvkd;
		location = new Point(253, 388);
		((Control)obj39).Location = location;
		((Control)lblTen_nvkd).Name = "lblTen_nvkd";
		Label obj40 = lblTen_nvkd;
		size = new Size(521, 13);
		((Control)obj40).Size = size;
		((Control)lblTen_nvkd).TabIndex = 1307;
		lblTen_nvkd.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_bp;
		location = new Point(160, 360);
		((Control)asTextBox8).Location = location;
		txtMa_bp.LookupCodeName = "Ma_bp";
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox9 = txtMa_bp;
		size = new Size(88, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_bp).TabIndex = 16;
		((Control)txtMa_bp).Tag = "@pMa_bp";
		txtMa_bp.UseAutoCompleteSource = true;
		lblTen_bp.ImeMode = (ImeMode)0;
		Label obj41 = lblTen_bp;
		location = new Point(253, 364);
		((Control)obj41).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj42 = lblTen_bp;
		size = new Size(521, 13);
		((Control)obj42).Size = size;
		((Control)lblTen_bp).TabIndex = 1306;
		lblTen_bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_nhvt).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_nhvt;
		location = new Point(160, 336);
		((Control)asTextBox10).Location = location;
		txtMa_nhvt.LookupCodeName = "Ma_nhvt";
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_nhvt;
		AsTextBox asTextBox11 = txtMa_nhvt;
		size = new Size(88, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_nhvt).TabIndex = 15;
		((Control)txtMa_nhvt).Tag = "@pMa_nhvt";
		txtMa_nhvt.UseAutoCompleteSource = true;
		lblTen_nhvt.ImeMode = (ImeMode)0;
		Label obj43 = lblTen_nhvt;
		location = new Point(253, 340);
		((Control)obj43).Location = location;
		((Control)lblTen_nhvt).Name = "lblTen_nhvt";
		Label obj44 = lblTen_nhvt;
		size = new Size(521, 13);
		((Control)obj44).Size = size;
		((Control)lblTen_nhvt).TabIndex = 1301;
		lblTen_nhvt.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_vt;
		location = new Point(160, 312);
		((Control)asTextBox12).Location = location;
		txtMa_vt.LookupCodeName = "Ma_vt";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox13 = txtMa_vt;
		size = new Size(88, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_vt).TabIndex = 14;
		((Control)txtMa_vt).Tag = "@pMa_vt";
		txtMa_vt.UseAutoCompleteSource = true;
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj45 = lblTen_vt;
		location = new Point(253, 316);
		((Control)obj45).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj46 = lblTen_vt;
		size = new Size(521, 13);
		((Control)obj46).Size = size;
		((Control)lblTen_vt).TabIndex = 1300;
		lblTen_vt.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_nhhd).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_nhhd.AutoLookup = true;
		txtMa_nhhd.AutoValid = false;
		((TextBoxBase)txtMa_nhhd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhhd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_nhhd;
		location = new Point(160, 288);
		((Control)asTextBox14).Location = location;
		txtMa_nhhd.LookupCodeName = "Ma_nhhd";
		((Control)txtMa_nhhd).Name = "txtMa_nhhd";
		txtMa_nhhd.NameControl = lblTen_nhhd;
		AsTextBox asTextBox15 = txtMa_nhhd;
		size = new Size(88, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_nhhd).TabIndex = 13;
		((Control)txtMa_nhhd).Tag = "@pMa_nhhd";
		txtMa_nhhd.UseAutoCompleteSource = true;
		lblTen_nhhd.ImeMode = (ImeMode)0;
		Label obj47 = lblTen_nhhd;
		location = new Point(253, 292);
		((Control)obj47).Location = location;
		((Control)lblTen_nhhd).Name = "lblTen_nhhd";
		Label obj48 = lblTen_nhhd;
		size = new Size(521, 13);
		((Control)obj48).Size = size;
		((Control)lblTen_nhhd).TabIndex = 1299;
		lblTen_nhhd.TextAlign = (ContentAlignment)16;
		lblMa_nvkd.AutoSize = true;
		Label obj49 = lblMa_nvkd;
		location = new Point(20, 388);
		((Control)obj49).Location = location;
		((Control)lblMa_nvkd).Name = "lblMa_nvkd";
		Label obj50 = lblMa_nvkd;
		size = new Size(55, 13);
		((Control)obj50).Size = size;
		((Control)lblMa_nvkd).TabIndex = 1292;
		lblMa_nvkd.Text = "Mã NVKD";
		lblMa_bp.AutoSize = true;
		Label obj51 = lblMa_bp;
		location = new Point(20, 364);
		((Control)obj51).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj52 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj52).Size = size;
		((Control)lblMa_bp).TabIndex = 1291;
		lblMa_bp.Text = "Mã bộ phận";
		lblMa_nhvt.AutoSize = true;
		Label obj53 = lblMa_nhvt;
		location = new Point(20, 340);
		((Control)obj53).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj54 = lblMa_nhvt;
		size = new Size(81, 13);
		((Control)obj54).Size = size;
		((Control)lblMa_nhvt).TabIndex = 1286;
		lblMa_nhvt.Text = "Mã nhóm vật tư";
		lblMa_vt.AutoSize = true;
		Label obj55 = lblMa_vt;
		location = new Point(20, 316);
		((Control)obj55).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj56 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj56).Size = size;
		((Control)lblMa_vt).TabIndex = 1285;
		lblMa_vt.Text = "Mã vật tư";
		((TextBox)txtMa_hd).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox16 = txtMa_hd;
		location = new Point(160, 264);
		((Control)asTextBox16).Location = location;
		txtMa_hd.LookupCodeName = "Ma_hd";
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox17 = txtMa_hd;
		size = new Size(88, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtMa_hd).TabIndex = 12;
		((Control)txtMa_hd).Tag = "@pMa_hd";
		txtMa_hd.UseAutoCompleteSource = true;
		lblTen_hd.ImeMode = (ImeMode)0;
		Label obj57 = lblTen_hd;
		location = new Point(253, 268);
		((Control)obj57).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj58 = lblTen_hd;
		size = new Size(521, 13);
		((Control)obj58).Size = size;
		((Control)lblTen_hd).TabIndex = 1298;
		lblTen_hd.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_nhkh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_nhkh.AutoLookup = true;
		txtMa_nhkh.AutoValid = false;
		((TextBoxBase)txtMa_nhkh).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhkh).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_nhkh).Enabled = false;
		AsTextBox asTextBox18 = txtMa_nhkh;
		location = new Point(765, 365);
		((Control)asTextBox18).Location = location;
		txtMa_nhkh.LookupCodeName = "Ma_nhkh";
		((Control)txtMa_nhkh).Name = "txtMa_nhkh";
		txtMa_nhkh.NameControl = lblTen_nhkh;
		AsTextBox asTextBox19 = txtMa_nhkh;
		size = new Size(88, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtMa_nhkh).TabIndex = 1;
		((Control)txtMa_nhkh).Tag = "@pMa_nhkh";
		txtMa_nhkh.UseAutoCompleteSource = true;
		((Control)txtMa_nhkh).Visible = false;
		((Control)lblTen_nhkh).Enabled = false;
		lblTen_nhkh.ImeMode = (ImeMode)0;
		Label obj59 = lblTen_nhkh;
		location = new Point(858, 372);
		((Control)obj59).Location = location;
		((Control)lblTen_nhkh).Name = "lblTen_nhkh";
		Label obj60 = lblTen_nhkh;
		size = new Size(246, 13);
		((Control)obj60).Size = size;
		((Control)lblTen_nhkh).TabIndex = 1294;
		lblTen_nhkh.TextAlign = (ContentAlignment)16;
		((Control)lblTen_nhkh).Visible = false;
		((TextBox)txtMa_kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = false;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtMa_kh;
		location = new Point(160, 168);
		((Control)asTextBox20).Location = location;
		txtMa_kh.LookupCodeName = "Ma_kh";
		txtMa_kh.LookupWhereCondition = "isKh=1";
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = lblTen_kh;
		AsTextBox asTextBox21 = txtMa_kh;
		size = new Size(88, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMa_kh).TabIndex = 8;
		((Control)txtMa_kh).Tag = "@pMa_kh";
		txtMa_kh.UseAutoCompleteSource = true;
		lblTen_kh.ImeMode = (ImeMode)0;
		Label obj61 = lblTen_kh;
		location = new Point(253, 172);
		((Control)obj61).Location = location;
		((Control)lblTen_kh).Name = "lblTen_kh";
		Label obj62 = lblTen_kh;
		size = new Size(521, 13);
		((Control)obj62).Size = size;
		((Control)lblTen_kh).TabIndex = 1293;
		lblTen_kh.TextAlign = (ContentAlignment)16;
		lblMa_kh.AutoSize = true;
		Label obj63 = lblMa_kh;
		location = new Point(20, 172);
		((Control)obj63).Location = location;
		((Control)lblMa_kh).Name = "lblMa_kh";
		Label obj64 = lblMa_kh;
		size = new Size(82, 13);
		((Control)obj64).Size = size;
		((Control)lblMa_kh).TabIndex = 1278;
		lblMa_kh.Text = "Mã khách hàng";
		lblMa_nhkh.AutoSize = true;
		((Control)lblMa_nhkh).Enabled = false;
		Label obj65 = lblMa_nhkh;
		location = new Point(667, 365);
		((Control)obj65).Location = location;
		((Control)lblMa_nhkh).Name = "lblMa_nhkh";
		Label obj66 = lblMa_nhkh;
		size = new Size(69, 13);
		((Control)obj66).Size = size;
		((Control)lblMa_nhkh).TabIndex = 1279;
		lblMa_nhkh.Text = "Mã nhóm KH";
		((Control)lblMa_nhkh).Visible = false;
		lblMa_hd.AutoSize = true;
		Label obj67 = lblMa_hd;
		location = new Point(20, 268);
		((Control)obj67).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj68 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj68).Size = size;
		((Control)lblMa_hd).TabIndex = 1283;
		lblMa_hd.Text = "Mã hợp đồng";
		lblMa_nhhd.AutoSize = true;
		Label obj69 = lblMa_nhhd;
		location = new Point(20, 292);
		((Control)obj69).Location = location;
		((Control)lblMa_nhhd).Name = "lblMa_nhhd";
		Label obj70 = lblMa_nhhd;
		size = new Size(84, 13);
		((Control)obj70).Size = size;
		((Control)lblMa_nhhd).TabIndex = 1284;
		lblMa_nhhd.Text = "Nhóm hợp đồng";
		Label obj71 = lblTen_spct;
		location = new Point(253, 484);
		((Control)obj71).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj72 = lblTen_spct;
		size = new Size(521, 13);
		((Control)obj72).Size = size;
		((Control)lblTen_spct).TabIndex = 1316;
		((TextBox)txtMa_plkh1).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_plkh1.AutoLookup = true;
		txtMa_plkh1.AutoValid = false;
		((TextBoxBase)txtMa_plkh1).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox22 = txtMa_plkh1;
		location = new Point(160, 192);
		((Control)asTextBox22).Location = location;
		txtMa_plkh1.LookupCodeName = "Ma_plkh";
		txtMa_plkh1.LookupWhereCondition = "loai=1";
		((Control)txtMa_plkh1).Name = "txtMa_plkh1";
		txtMa_plkh1.NameControl = lblTen_plkh1;
		AsTextBox asTextBox23 = txtMa_plkh1;
		size = new Size(88, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMa_plkh1).TabIndex = 9;
		((Control)txtMa_plkh1).Tag = "@pMa_plkh";
		txtMa_plkh1.UseAutoCompleteSource = true;
		lblTen_plkh1.ImeMode = (ImeMode)0;
		Label obj73 = lblTen_plkh1;
		location = new Point(253, 196);
		((Control)obj73).Location = location;
		((Control)lblTen_plkh1).Name = "lblTen_plkh1";
		Label obj74 = lblTen_plkh1;
		size = new Size(521, 13);
		((Control)obj74).Size = size;
		((Control)lblTen_plkh1).TabIndex = 1295;
		lblTen_plkh1.TextAlign = (ContentAlignment)16;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox24 = txtMa_spct;
		location = new Point(160, 480);
		((Control)asTextBox24).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox25 = txtMa_spct;
		size = new Size(88, 20);
		((Control)asTextBox25).Size = size;
		((Control)txtMa_spct).TabIndex = 21;
		((Control)txtMa_spct).Tag = "MA_SPCT";
		txtMa_spct.UseAutoCompleteSource = true;
		lblMa_spct.AutoSize = true;
		Label obj75 = lblMa_spct;
		location = new Point(20, 483);
		((Control)obj75).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj76 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj76).Size = size;
		((Control)lblMa_spct).TabIndex = 1317;
		lblMa_spct.Text = "Mã SPCT";
		lblMa_spct.TextAlign = (ContentAlignment)32;
		lblTen_plkh2.ImeMode = (ImeMode)0;
		Label obj77 = lblTen_plkh2;
		location = new Point(253, 220);
		((Control)obj77).Location = location;
		((Control)lblTen_plkh2).Name = "lblTen_plkh2";
		Label obj78 = lblTen_plkh2;
		size = new Size(521, 13);
		((Control)obj78).Size = size;
		((Control)lblTen_plkh2).TabIndex = 1296;
		lblTen_plkh2.TextAlign = (ContentAlignment)16;
		lblTen_plkh3.ImeMode = (ImeMode)0;
		Label obj79 = lblTen_plkh3;
		location = new Point(253, 244);
		((Control)obj79).Location = location;
		((Control)lblTen_plkh3).Name = "lblTen_plkh3";
		Label obj80 = lblTen_plkh3;
		size = new Size(521, 13);
		((Control)obj80).Size = size;
		((Control)lblTen_plkh3).TabIndex = 1297;
		lblTen_plkh3.TextAlign = (ContentAlignment)16;
		lblMa_plkh3.AutoSize = true;
		Label obj81 = lblMa_plkh3;
		location = new Point(20, 244);
		((Control)obj81).Location = location;
		((Control)lblMa_plkh3).Name = "lblMa_plkh3";
		Label obj82 = lblMa_plkh3;
		size = new Size(57, 13);
		((Control)obj82).Size = size;
		((Control)lblMa_plkh3).TabIndex = 1282;
		lblMa_plkh3.Text = "P.loại KH3";
		lblMa_plkh2.AutoSize = true;
		Label obj83 = lblMa_plkh2;
		location = new Point(20, 220);
		((Control)obj83).Location = location;
		((Control)lblMa_plkh2).Name = "lblMa_plkh2";
		Label obj84 = lblMa_plkh2;
		size = new Size(57, 13);
		((Control)obj84).Size = size;
		((Control)lblMa_plkh2).TabIndex = 1281;
		lblMa_plkh2.Text = "P.loại KH2";
		lblMa_plkh1.AutoSize = true;
		Label obj85 = lblMa_plkh1;
		location = new Point(20, 196);
		((Control)obj85).Location = location;
		((Control)lblMa_plkh1).Name = "lblMa_plkh1";
		Label obj86 = lblMa_plkh1;
		size = new Size(60, 13);
		((Control)obj86).Size = size;
		((Control)lblMa_plkh1).TabIndex = 1280;
		lblMa_plkh1.Text = "P. loại KH1";
		((TextBox)txtMa_plkh2).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_plkh2.AutoLookup = true;
		txtMa_plkh2.AutoValid = false;
		((TextBoxBase)txtMa_plkh2).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox26 = txtMa_plkh2;
		location = new Point(160, 216);
		((Control)asTextBox26).Location = location;
		txtMa_plkh2.LookupCodeName = "Ma_plkh";
		txtMa_plkh2.LookupWhereCondition = "loai=2";
		((Control)txtMa_plkh2).Name = "txtMa_plkh2";
		txtMa_plkh2.NameControl = lblTen_plkh2;
		AsTextBox asTextBox27 = txtMa_plkh2;
		size = new Size(88, 20);
		((Control)asTextBox27).Size = size;
		((Control)txtMa_plkh2).TabIndex = 10;
		((Control)txtMa_plkh2).Tag = "@pMa_plkh";
		txtMa_plkh2.UseAutoCompleteSource = true;
		((TextBox)txtMa_plkh3).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_plkh3.AutoLookup = true;
		txtMa_plkh3.AutoValid = false;
		((TextBoxBase)txtMa_plkh3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox28 = txtMa_plkh3;
		location = new Point(160, 240);
		((Control)asTextBox28).Location = location;
		txtMa_plkh3.LookupCodeName = "Ma_plkh";
		txtMa_plkh3.LookupWhereCondition = "loai=3";
		((Control)txtMa_plkh3).Name = "txtMa_plkh3";
		txtMa_plkh3.NameControl = lblTen_plkh3;
		AsTextBox asTextBox29 = txtMa_plkh3;
		size = new Size(88, 20);
		((Control)asTextBox29).Size = size;
		((Control)txtMa_plkh3).TabIndex = 11;
		((Control)txtMa_plkh3).Tag = "@pMa_plkh";
		txtMa_plkh3.UseAutoCompleteSource = true;
		Label obj87 = lblTen_lo;
		location = new Point(253, 460);
		((Control)obj87).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj88 = lblTen_lo;
		size = new Size(521, 13);
		((Control)obj88).Size = size;
		((Control)lblTen_lo).TabIndex = 1310;
		((TextBox)txtMa_plvt1).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_plvt1.AutoLookup = true;
		txtMa_plvt1.AutoValid = false;
		((TextBoxBase)txtMa_plvt1).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt1).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt1).Enabled = false;
		AsTextBox asTextBox30 = txtMa_plvt1;
		location = new Point(765, 262);
		((Control)asTextBox30).Location = location;
		txtMa_plvt1.LookupCodeName = "Ma_plvt";
		txtMa_plvt1.LookupWhereCondition = "loai=1";
		((Control)txtMa_plvt1).Name = "txtMa_plvt1";
		txtMa_plvt1.NameControl = lblTen_plvt1;
		AsTextBox asTextBox31 = txtMa_plvt1;
		size = new Size(88, 20);
		((Control)asTextBox31).Size = size;
		((Control)txtMa_plvt1).TabIndex = 3;
		((Control)txtMa_plvt1).Tag = "@pMa_plvt";
		txtMa_plvt1.UseAutoCompleteSource = true;
		((Control)txtMa_plvt1).Visible = false;
		((Control)lblTen_plvt1).Enabled = false;
		lblTen_plvt1.ImeMode = (ImeMode)0;
		Label obj89 = lblTen_plvt1;
		location = new Point(858, 268);
		((Control)obj89).Location = location;
		((Control)lblTen_plvt1).Name = "lblTen_plvt1";
		Label obj90 = lblTen_plvt1;
		size = new Size(246, 13);
		((Control)obj90).Size = size;
		((Control)lblTen_plvt1).TabIndex = 1302;
		lblTen_plvt1.TextAlign = (ContentAlignment)16;
		((Control)lblTen_plvt1).Visible = false;
		txtMa_Lo.AutoLookup = true;
		txtMa_Lo.AutoValid = false;
		((TextBoxBase)txtMa_Lo).BackColor = SystemColors.Info;
		((TextBox)txtMa_Lo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox32 = txtMa_Lo;
		location = new Point(160, 456);
		((Control)asTextBox32).Location = location;
		txtMa_Lo.LookupCodeName = "MA_LO";
		((Control)txtMa_Lo).Name = "txtMa_Lo";
		txtMa_Lo.NameControl = lblTen_lo;
		AsTextBox asTextBox33 = txtMa_Lo;
		size = new Size(88, 20);
		((Control)asTextBox33).Size = size;
		((Control)txtMa_Lo).TabIndex = 20;
		((Control)txtMa_Lo).Tag = "MA_LO";
		txtMa_Lo.UseAutoCompleteSource = true;
		lblMa_plvt1.AutoSize = true;
		((Control)lblMa_plvt1).Enabled = false;
		Label obj91 = lblMa_plvt1;
		location = new Point(666, 266);
		((Control)obj91).Location = location;
		((Control)lblMa_plvt1).Name = "lblMa_plvt1";
		Label obj92 = lblMa_plvt1;
		size = new Size(56, 13);
		((Control)obj92).Size = size;
		((Control)lblMa_plvt1).TabIndex = 1287;
		lblMa_plvt1.Text = "P.loại VT1";
		((Control)lblMa_plvt1).Visible = false;
		lblMaLo.AutoSize = true;
		Label obj93 = lblMaLo;
		location = new Point(20, 460);
		((Control)obj93).Location = location;
		((Control)lblMaLo).Name = "lblMaLo";
		Label obj94 = lblMaLo;
		size = new Size(33, 13);
		((Control)obj94).Size = size;
		((Control)lblMaLo).TabIndex = 1311;
		lblMaLo.Text = "Mã lô";
		lblMa_plvt2.AutoSize = true;
		((Control)lblMa_plvt2).Enabled = false;
		Label obj95 = lblMa_plvt2;
		location = new Point(666, 291);
		((Control)obj95).Location = location;
		((Control)lblMa_plvt2).Name = "lblMa_plvt2";
		Label obj96 = lblMa_plvt2;
		size = new Size(56, 13);
		((Control)obj96).Size = size;
		((Control)lblMa_plvt2).TabIndex = 1288;
		lblMa_plvt2.Text = "P.loại VT2";
		((Control)lblMa_plvt2).Visible = false;
		((Control)lblTen_vitri).Enabled = false;
		Label obj97 = lblTen_vitri;
		location = new Point(858, 347);
		((Control)obj97).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj98 = lblTen_vitri;
		size = new Size(246, 13);
		((Control)obj98).Size = size;
		((Control)lblTen_vitri).TabIndex = 1308;
		((Control)lblTen_vitri).Visible = false;
		lblMa_plvt3.AutoSize = true;
		((Control)lblMa_plvt3).Enabled = false;
		Label obj99 = lblMa_plvt3;
		location = new Point(666, 316);
		((Control)obj99).Location = location;
		((Control)lblMa_plvt3).Name = "lblMa_plvt3";
		Label obj100 = lblMa_plvt3;
		size = new Size(56, 13);
		((Control)obj100).Size = size;
		((Control)lblMa_plvt3).TabIndex = 1289;
		lblMa_plvt3.Text = "P.loại VT3";
		((Control)lblMa_plvt3).Visible = false;
		txtMa_vitri.AutoLookup = true;
		txtMa_vitri.AutoValid = false;
		((TextBoxBase)txtMa_vitri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vitri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vitri).Enabled = false;
		AsTextBox asTextBox34 = txtMa_vitri;
		location = new Point(765, 339);
		((Control)asTextBox34).Location = location;
		txtMa_vitri.LookupCodeName = "MA_VITRI";
		((Control)txtMa_vitri).Name = "txtMa_vitri";
		txtMa_vitri.NameControl = lblTen_vitri;
		AsTextBox asTextBox35 = txtMa_vitri;
		size = new Size(88, 20);
		((Control)asTextBox35).Size = size;
		((Control)txtMa_vitri).TabIndex = 7;
		((Control)txtMa_vitri).Tag = "MA_VITRI";
		txtMa_vitri.UseAutoCompleteSource = true;
		((Control)txtMa_vitri).Visible = false;
		lblMavitri.AutoSize = true;
		((Control)lblMavitri).Enabled = false;
		Label obj101 = lblMavitri;
		location = new Point(666, 341);
		((Control)obj101).Location = location;
		((Control)lblMavitri).Name = "lblMavitri";
		Label obj102 = lblMavitri;
		size = new Size(46, 13);
		((Control)obj102).Size = size;
		((Control)lblMavitri).TabIndex = 1309;
		lblMavitri.Text = "Mã vị trí";
		((Control)lblMavitri).Visible = false;
		((Control)lblTen_plvt2).Enabled = false;
		lblTen_plvt2.ImeMode = (ImeMode)0;
		Label obj103 = lblTen_plvt2;
		location = new Point(858, 295);
		((Control)obj103).Location = location;
		((Control)lblTen_plvt2).Name = "lblTen_plvt2";
		Label obj104 = lblTen_plvt2;
		size = new Size(246, 13);
		((Control)obj104).Size = size;
		((Control)lblTen_plvt2).TabIndex = 1303;
		lblTen_plvt2.TextAlign = (ContentAlignment)16;
		((Control)lblTen_plvt2).Visible = false;
		((Control)lblTen_plvt3).Enabled = false;
		lblTen_plvt3.ImeMode = (ImeMode)0;
		Label obj105 = lblTen_plvt3;
		location = new Point(858, 320);
		((Control)obj105).Location = location;
		((Control)lblTen_plvt3).Name = "lblTen_plvt3";
		Label obj106 = lblTen_plvt3;
		size = new Size(246, 13);
		((Control)obj106).Size = size;
		((Control)lblTen_plvt3).TabIndex = 1304;
		lblTen_plvt3.TextAlign = (ContentAlignment)16;
		((Control)lblTen_plvt3).Visible = false;
		((TextBox)txtMa_plvt2).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_plvt2.AutoLookup = true;
		txtMa_plvt2.AutoValid = false;
		((TextBoxBase)txtMa_plvt2).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt2).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt2).Enabled = false;
		AsTextBox asTextBox36 = txtMa_plvt2;
		location = new Point(765, 287);
		((Control)asTextBox36).Location = location;
		txtMa_plvt2.LookupCodeName = "Ma_plvt";
		txtMa_plvt2.LookupWhereCondition = "loai=2";
		((Control)txtMa_plvt2).Name = "txtMa_plvt2";
		txtMa_plvt2.NameControl = lblTen_plvt2;
		AsTextBox asTextBox37 = txtMa_plvt2;
		size = new Size(88, 20);
		((Control)asTextBox37).Size = size;
		((Control)txtMa_plvt2).TabIndex = 4;
		((Control)txtMa_plvt2).Tag = "@pMa_plvt";
		txtMa_plvt2.UseAutoCompleteSource = true;
		((Control)txtMa_plvt2).Visible = false;
		((TextBox)txtMa_kho).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox38 = txtMa_kho;
		location = new Point(160, 432);
		((Control)asTextBox38).Location = location;
		txtMa_kho.LookupCodeName = "Ma_kho";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox39 = txtMa_kho;
		size = new Size(88, 20);
		((Control)asTextBox39).Size = size;
		((Control)txtMa_kho).TabIndex = 19;
		((Control)txtMa_kho).Tag = "@pMa_kho";
		txtMa_kho.UseAutoCompleteSource = true;
		lblTen_kho.ImeMode = (ImeMode)0;
		Label obj107 = lblTen_kho;
		location = new Point(253, 436);
		((Control)obj107).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj108 = lblTen_kho;
		size = new Size(521, 13);
		((Control)obj108).Size = size;
		((Control)lblTen_kho).TabIndex = 1305;
		lblTen_kho.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_plvt3).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_plvt3.AutoLookup = true;
		txtMa_plvt3.AutoValid = false;
		((TextBoxBase)txtMa_plvt3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt3).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt3).Enabled = false;
		AsTextBox asTextBox40 = txtMa_plvt3;
		location = new Point(765, 313);
		((Control)asTextBox40).Location = location;
		txtMa_plvt3.LookupCodeName = "Ma_plvt";
		txtMa_plvt3.LookupWhereCondition = "loai=3";
		((Control)txtMa_plvt3).Name = "txtMa_plvt3";
		txtMa_plvt3.NameControl = lblTen_plvt3;
		AsTextBox asTextBox41 = txtMa_plvt3;
		size = new Size(88, 20);
		((Control)asTextBox41).Size = size;
		((Control)txtMa_plvt3).TabIndex = 5;
		((Control)txtMa_plvt3).Tag = "@pMa_plvt";
		txtMa_plvt3.UseAutoCompleteSource = true;
		((Control)txtMa_plvt3).Visible = false;
		lblMa_kho.AutoSize = true;
		Label obj109 = lblMa_kho;
		location = new Point(20, 436);
		((Control)obj109).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj110 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj110).Size = size;
		((Control)lblMa_kho).TabIndex = 1290;
		lblMa_kho.Text = "Mã kho";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(1101, 651);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmSORptBK02";
		((Form)this).Text = "frmSORptBK02";
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public frmSORptBK02(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		AsComboBox asComboBox = cboNhom_theo;
		ArrayList arrayList = new ArrayList();
		DictionaryEntry dictionaryEntry = new DictionaryEntry("MA_KH", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox).Items[0]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Ma_BP", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox).Items[1]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Ma_HD", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox).Items[2]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Ma_HTTT", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox).Items[3]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Ma_NVKD", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox).Items[4]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Ma_SPCT", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox).Items[5]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Ma_VT", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox).Items[6]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Ma_KHO", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox).Items[7]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("Ma_LO", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox).Items[8]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("STT_REC", RuntimeHelpers.GetObjectValue(((ComboBox)asComboBox).Items[9]));
		arrayList.Add(dictionaryEntry);
		((ComboBox)asComboBox).Items.Clear();
		((ComboBox)asComboBox).DataSource = arrayList;
		((ListControl)asComboBox).ValueMember = "Key";
		((ListControl)asComboBox).DisplayMember = "Value";
		((ComboBox)asComboBox).SelectedIndex = 0;
		asComboBox = null;
		ArrayList arrayList2 = new ArrayList();
		arrayList2.Add(CompanyInformations.CompanyID);
		arrayList2.Add(MyMenuInfo.moduleid);
		arrayList2.Add("0");
		arrayList2.Add(SystemInformations.CurrentCultureName);
		ArrayList arrayList3 = CBO<lstVoucherInfo>.FillCollection(Commons.GetDataReader("asSIGetDmSo_ct", arrayList2.ToArray()));
		arrayList3.Add(new lstVoucherInfo("", AsiaErp.Framework.Environment.getLangSysMessageResX("#SYS_ALL").value));
		((ComboBox)cboLoaiPhieu).DataSource = arrayList3;
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
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoaiPhieu).SelectedValue));
		arrayList.Add("");
		arrayList.Add(((TextBox)txtMa_kh).Text);
		arrayList.Add(((TextBox)txtMa_nhkh).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_vitri).Text);
		arrayList.Add(((TextBox)txtMa_Lo).Text);
		arrayList.Add(((TextBox)txtMA_HTTT).Text);
		arrayList.Add(((TextBox)txtMA_DKTT).Text);
		arrayList.Add(((TextBox)txtMa_bp).Text);
		arrayList.Add(((TextBox)txtMa_nvkd).Text);
		arrayList.Add(((TextBox)txtMa_spct).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtMa_nhhd).Text);
		arrayList.Add(txtSo_ct1.Text);
		arrayList.Add(txtSo_ct2.Text);
		arrayList.Add(((TextBox)txtMa_plkh1).Text);
		arrayList.Add(((TextBox)txtMa_plkh2).Text);
		arrayList.Add(((TextBox)txtMa_plkh3).Text);
		arrayList.Add(((TextBox)txtMa_plvt1).Text);
		arrayList.Add(((TextBox)txtMa_plvt2).Text);
		arrayList.Add(((TextBox)txtMa_plvt3).Text);
		DictionaryEntry dictionaryEntry = (DictionaryEntry)((ComboBox)cboNhom_theo).SelectedItem;
		arrayList.Add(RuntimeHelpers.GetObjectValue(dictionaryEntry.Key));
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		base.MyFomularFields.Add("detailsType", RuntimeHelpers.GetObjectValue(((ListControl)cboNhom_theo).SelectedValue));
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(txtSo_ct1.Text, "", false) != 0)
		{
			text = text + lblSo_Ct1.Text + ": [" + txtSo_ct1.Text + "]; ";
		}
		if (Operators.CompareString(txtSo_ct2.Text, "", false) != 0)
		{
			text = text + lblSo_ct2.Text + ": [" + txtSo_ct2.Text + "]; ";
		}
		if (Operators.CompareString(((ListControl)cboLoaiPhieu).SelectedValue.ToString(), "", false) != 0)
		{
			text = text + lblLoaiPhieu.Text + ": [" + ((ListControl)cboLoaiPhieu).SelectedValue.ToString() + "]; ";
		}
		if (((ComboBox)cboNhom_theo).SelectedIndex > -1)
		{
			text = text + lblNhom_theo.Text + ": [" + ((ComboBox)cboNhom_theo).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kh).Text, "", false) != 0)
		{
			text = text + lblMa_kh.Text + ": [" + ((TextBox)txtMa_kh).Text + " - " + lblTen_kh.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhkh).Text, "", false) != 0)
		{
			text = text + lblMa_nhkh.Text + ": [" + ((TextBox)txtMa_nhkh).Text + " - " + lblTen_nhkh.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plkh1).Text, "", false) != 0)
		{
			text = text + lblMa_plkh1.Text + ": [" + ((TextBox)txtMa_plkh1).Text + " - " + lblTen_plkh1.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plkh2).Text, "", false) != 0)
		{
			text = text + lblMa_plkh2.Text + ": [" + ((TextBox)txtMa_plkh2).Text + " - " + lblTen_plkh2.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plkh3).Text, "", false) != 0)
		{
			text = text + lblMa_plkh3.Text + ": [" + ((TextBox)txtMa_plkh3).Text + " - " + lblTen_plkh3.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_hd).Text, "", false) != 0)
		{
			text = text + lblMa_hd.Text + ": [" + ((TextBox)txtMa_hd).Text + " - " + lblTen_hd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhhd).Text, "", false) != 0)
		{
			text = text + lblMa_nhhd.Text + ": [" + ((TextBox)txtMa_nhhd).Text + " - " + lblTen_nhhd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
		{
			text = text + lblMa_vt.Text + ": [" + ((TextBox)txtMa_vt).Text + " - " + lblTen_vt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhvt).Text, "", false) != 0)
		{
			text = text + lblMa_nhvt.Text + ": [" + ((TextBox)txtMa_nhvt).Text + " - " + lblTen_nhvt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt1).Text, "", false) != 0)
		{
			text = text + lblMa_plvt1.Text + ": [" + ((TextBox)txtMa_plvt1).Text + " - " + lblTen_plvt1.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt2).Text, "", false) != 0)
		{
			text = text + lblMa_plvt2.Text + ": [" + ((TextBox)txtMa_plvt2).Text + " - " + lblTen_plvt2.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt3).Text, "", false) != 0)
		{
			text = text + lblMa_plvt3.Text + ": [" + ((TextBox)txtMa_plvt3).Text + " - " + lblTen_plvt3.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_bp).Text, "", false) != 0)
		{
			text = text + lblMa_bp.Text + ": [" + ((TextBox)txtMa_bp).Text + " - " + lblTen_bp.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nvkd).Text, "", false) != 0)
		{
			text = text + lblMa_nvkd.Text + ": [" + ((TextBox)txtMa_nvkd).Text + " - " + lblTen_nvkd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMA_HTTT).Text.Trim(), "", false) != 0)
		{
			text = text + lblHTTT.Text + ": [" + ((TextBox)txtMA_HTTT).Text + " - " + lblHTTT.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMA_DKTT).Text.Trim(), "", false) != 0)
		{
			text = text + lblDkTT.Text + ": [" + ((TextBox)txtMA_DKTT).Text + " - " + lblDkTT.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text, "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": [" + ((TextBox)txtMa_kho).Text + " - " + lblTen_kho.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vitri).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_vitri.Text + ": [" + ((TextBox)txtMa_vitri).Text + " - " + lblTen_vitri.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Lo).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_lo.Text + ": [" + ((TextBox)txtMa_Lo).Text + " - " + lblTen_lo.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_spct).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_spct.Text + ": [" + ((TextBox)txtMa_spct).Text + " - " + lblTen_spct.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": [" + ((TextBox)txtMa_Nt).Text + "]; ";
		}
		return text;
	}

	private void cboMau_bc_SelectedIndexChanged(object sender, EventArgs e)
	{
		((ListControl)cboLoaiPhieu).SelectedValue = base.MyReportInfo.par0;
	}
}
