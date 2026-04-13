using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSORptBK01 : frmReport2DGV
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTrang_Thai")]
	private Label _lblTrang_Thai;

	[AccessedThroughProperty("lblSo_ct1")]
	private Label _lblSo_ct1;

	[AccessedThroughProperty("cboTrang_Thai")]
	private AsComboBox _cboTrang_Thai;

	[AccessedThroughProperty("txtSo_ct1")]
	private TextBox _txtSo_ct1;

	[AccessedThroughProperty("lblSo_Ct2")]
	private Label _lblSo_Ct2;

	[AccessedThroughProperty("txtSo_ct2")]
	private TextBox _txtSo_ct2;

	[AccessedThroughProperty("lblLoaiPhieu")]
	private Label _lblLoaiPhieu;

	[AccessedThroughProperty("cboLoaiPhieu")]
	private AsComboBox _cboLoaiPhieu;

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("txtMa_vitri")]
	private AsTextBox _txtMa_vitri;

	[AccessedThroughProperty("lblMavitri")]
	private Label _lblMavitri;

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

	[AccessedThroughProperty("txtMa_nhhd")]
	private AsTextBox _txtMa_nhhd;

	[AccessedThroughProperty("lblTen_Nhhd")]
	private Label _lblTen_Nhhd;

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("lblMa_nhhd")]
	private Label _lblMa_nhhd;

	[AccessedThroughProperty("txtMaLo")]
	private AsTextBox _txtMaLo;

	[AccessedThroughProperty("lblMaLo")]
	private Label _lblMaLo;

	[AccessedThroughProperty("txtMa_kh")]
	private AsTextBox _txtMa_kh;

	[AccessedThroughProperty("lblTen_KH")]
	private Label _lblTen_KH;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtMa_nhvt")]
	private AsTextBox _txtMa_nhvt;

	[AccessedThroughProperty("lblTen_Nhvt")]
	private Label _lblTen_Nhvt;

	[AccessedThroughProperty("lblMa_nhvt")]
	private Label _lblMa_nhvt;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("txtMa_Nhkh")]
	private AsTextBox _txtMa_Nhkh;

	[AccessedThroughProperty("lblTen_nhkh")]
	private Label _lblTen_nhkh;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblTen_lkh3")]
	private Label _lblTen_lkh3;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("lblTen_lkh2")]
	private Label _lblTen_lkh2;

	[AccessedThroughProperty("lblTen_lkh1")]
	private Label _lblTen_lkh1;

	[AccessedThroughProperty("lblPlkh3")]
	private Label _lblPlkh3;

	[AccessedThroughProperty("txtMa_Plkh3")]
	private AsTextBox _txtMa_Plkh3;

	[AccessedThroughProperty("lblPlkh2")]
	private Label _lblPlkh2;

	[AccessedThroughProperty("txtMa_Plkh2")]
	private AsTextBox _txtMa_Plkh2;

	[AccessedThroughProperty("lblPlkh1")]
	private Label _lblPlkh1;

	[AccessedThroughProperty("txtMa_Plkh1")]
	private AsTextBox _txtMa_Plkh1;

	[AccessedThroughProperty("lblMa_Nhkh")]
	private Label _lblMa_Nhkh;

	[AccessedThroughProperty("txtMa_Plvt1")]
	private AsTextBox _txtMa_Plvt1;

	[AccessedThroughProperty("lblTen_plvt1")]
	private Label _lblTen_plvt1;

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

	[AccessedThroughProperty("lblTen_nvkd")]
	private Label _lblTen_nvkd;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblMa_nvkd")]
	private Label _lblMa_nvkd;

	[AccessedThroughProperty("txtMa_nvkd")]
	private AsTextBox _txtMa_nvkd;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

	private ToolTip oToolTip;

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

	internal virtual AsTextBox txtMa_kh
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

	internal virtual Label lblTen_KH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_KH = value;
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

	internal virtual Label lblTen_Nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhvt = value;
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

	internal virtual AsTextBox txtMa_Nhkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Nhkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Nhkh = value;
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

	internal virtual Label lblTen_lkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_lkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_lkh3 = value;
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

	internal virtual Label lblTen_lkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_lkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_lkh2 = value;
		}
	}

	internal virtual Label lblTen_lkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_lkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_lkh1 = value;
		}
	}

	internal virtual Label lblPlkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPlkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPlkh3 = value;
		}
	}

	internal virtual AsTextBox txtMa_Plkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Plkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Plkh3 = value;
		}
	}

	internal virtual Label lblPlkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPlkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPlkh2 = value;
		}
	}

	internal virtual AsTextBox txtMa_Plkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Plkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Plkh2 = value;
		}
	}

	internal virtual Label lblPlkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPlkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPlkh1 = value;
		}
	}

	internal virtual AsTextBox txtMa_Plkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Plkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Plkh1 = value;
		}
	}

	internal virtual Label lblMa_Nhkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nhkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nhkh = value;
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

	internal virtual Label lblTen_nvkd
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

	internal virtual AsTextBox txtMa_nvkd
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

	private virtual CrystalReportViewer crvReportViewer
	{
		[DebuggerNonUserCode]
		get
		{
			return _crvReportViewer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_crvReportViewer = value;
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

	public frmSORptBK01(string MenuID)
		: base(MenuID)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		__ENCAddToList(this);
		oToolTip = new ToolTip();
		InitializeComponent();
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
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
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
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		lblTrang_Thai = new Label();
		cboTrang_Thai = new AsComboBox();
		lblSo_ct1 = new Label();
		txtSo_ct2 = new TextBox();
		txtSo_ct1 = new TextBox();
		lblSo_Ct2 = new Label();
		lblLoaiPhieu = new Label();
		cboLoaiPhieu = new AsComboBox();
		lblTen_vitri = new Label();
		lblTen_spct = new Label();
		txtMa_vitri = new AsTextBox();
		lblMavitri = new Label();
		txtMa_spct = new AsTextBox();
		lblTen_lkh3 = new Label();
		lblMa_spct = new Label();
		lblTen_lkh2 = new Label();
		lblTen_lkh1 = new Label();
		lblTen_kho = new Label();
		lblPlkh3 = new Label();
		txtMa_Plkh3 = new AsTextBox();
		lblTen_lo = new Label();
		lblPlkh2 = new Label();
		txtMa_Plkh2 = new AsTextBox();
		txtMaLo = new AsTextBox();
		lblPlkh1 = new Label();
		lblMaLo = new Label();
		txtMa_kho = new AsTextBox();
		lblMa_kho = new Label();
		txtMa_Plkh1 = new AsTextBox();
		txtMa_Plvt1 = new AsTextBox();
		lblTen_plvt1 = new Label();
		lblPlvt3 = new Label();
		txtMa_plvt3 = new AsTextBox();
		lblTen_plvt3 = new Label();
		lblPlvt2 = new Label();
		txtMa_Plvt2 = new AsTextBox();
		lblTen_plvt2 = new Label();
		lblPlvt1 = new Label();
		lblTen_TT = new Label();
		txtMA_DKTT = new AsTextBox();
		lblDkTT = new Label();
		lblTenHTTT = new Label();
		txtMa_Nhkh = new AsTextBox();
		lblTen_nhkh = new Label();
		txtMA_HTTT = new AsTextBox();
		lblHTTT = new Label();
		txtMa_nhhd = new AsTextBox();
		lblTen_Nhhd = new Label();
		lblMa_nhhd = new Label();
		txtMa_kh = new AsTextBox();
		lblTen_KH = new Label();
		lblMa_Kh = new Label();
		lblMa_hd = new Label();
		txtMa_hd = new AsTextBox();
		lblTen_hd = new Label();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		lblMa_vt = new Label();
		txtMa_nhvt = new AsTextBox();
		lblTen_Nhvt = new Label();
		lblMa_nhvt = new Label();
		txtMa_bp = new AsTextBox();
		lblTen_bp = new Label();
		lblMa_Nhkh = new Label();
		lblMa_bp = new Label();
		txtMa_nvkd = new AsTextBox();
		lblTen_nvkd = new Label();
		lblMa_nvkd = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)tabGrid).SuspendLayout();
		((Control)scGrid).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(960, 584);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_TT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_DKTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblMavitri);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoaiPhieu);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblDkTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoaiPhieu);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblTenHTTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lkh1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Nhkh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlkh3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_HTTT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lo);
		((Control)tabFilter).Controls.Add((Control)(object)lblHTTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlkh2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlkh1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlvt3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhkh);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlvt2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlvt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTrang_Thai);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_KH);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_ct1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_ct1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)cboTrang_Thai);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_ct2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Nhkh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bp);
		TabPage obj = tabFilter;
		size = new Size(952, 555);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Nhkh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboTrang_Thai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_KH, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTrang_Thai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhkh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblHTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_HTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nhkh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTenHTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoaiPhieu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDkTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoaiPhieu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMavitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_DKTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_TT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vitri, 0);
		Label obj2 = lbl2;
		Point location = new Point(332, 67);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 28;
		Button obj3 = cmdExcel;
		location = new Point(804, 756);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 24;
		myHelpProvider.SetHelpKeyword((Control)(object)txtNgay2, "ttt");
		myHelpProvider.SetHelpString((Control)(object)txtNgay2, "Test");
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(351, 63);
		((Control)asMaskedTextBox).Location = location;
		myHelpProvider.SetShowHelp((Control)(object)txtNgay2, true);
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(723, 756);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 23;
		Button obj5 = cmdModifyReport;
		location = new Point(510, 14);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 29;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(261, 63);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(165, 63);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(17, 66);
		((Control)obj7).Location = location;
		((Control)lblKyBc).TabIndex = 66;
		myHelpProvider.SetHelpKeyword((Control)(object)cboMau_bc, "");
		myHelpProvider.SetHelpString((Control)(object)cboMau_bc, "");
		ComboBox obj8 = cboMau_bc;
		location = new Point(165, 15);
		((Control)obj8).Location = location;
		myHelpProvider.SetShowHelp((Control)(object)cboMau_bc, false);
		((Control)cboMau_bc).TabIndex = 28;
		Label obj9 = lblMau_bc;
		location = new Point(17, 18);
		((Control)obj9).Location = location;
		((Control)lblMau_bc).TabIndex = 68;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(165, 477);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 22;
		Label obj10 = lblMauBC;
		location = new Point(210, 476);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 23;
		RadioButton obj11 = optVND;
		location = new Point(285, 475);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 24;
		optVND.TabStop = false;
		RadioButton obj12 = optNt;
		location = new Point(351, 476);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 25;
		Label obj13 = lblMa_nt;
		location = new Point(17, 478);
		((Control)obj13).Location = location;
		((Control)lblMa_nt).TabIndex = 8;
		myHelpProvider.SetHelpKeyword((Control)(object)cmdOk, "");
		myHelpProvider.SetHelpString((Control)(object)cmdOk, "");
		Button obj14 = cmdOk;
		location = new Point(20, 512);
		((Control)obj14).Location = location;
		myHelpProvider.SetShowHelp((Control)(object)cmdOk, false);
		((Control)cmdOk).TabIndex = 26;
		Label obj15 = lblTieu_de;
		location = new Point(17, 43);
		((Control)obj15).Location = location;
		((Control)lblTieu_de).TabIndex = 67;
		TextBox obj16 = txtTieu_De;
		location = new Point(165, 40);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 30;
		TabPage obj17 = tabGrid;
		size = new Size(952, 555);
		((Control)obj17).Size = size;
		SplitContainer obj18 = scGrid;
		size = new Size(946, 549);
		((Control)obj18).Size = size;
		scGrid.SplitterDistance = 364;
		crvReportViewer.ActiveViewIndex = -1;
		((UserControl)crvReportViewer).BorderStyle = (BorderStyle)1;
		crvReportViewer.DisplayGroupTree = false;
		((Control)crvReportViewer).Dock = (DockStyle)5;
		CrystalReportViewer obj19 = crvReportViewer;
		location = new Point(0, 0);
		((Control)obj19).Location = location;
		((Control)crvReportViewer).Name = "crvReportViewer";
		crvReportViewer.SelectionFormula = "";
		crvReportViewer.ShowRefreshButton = false;
		CrystalReportViewer obj20 = crvReportViewer;
		size = new Size(952, 555);
		((Control)obj20).Size = size;
		((Control)crvReportViewer).TabIndex = 0;
		crvReportViewer.ViewTimeSelectionFormula = "";
		lblTrang_Thai.AutoSize = true;
		((Control)lblTrang_Thai).Enabled = false;
		Label obj21 = lblTrang_Thai;
		location = new Point(458, 122);
		((Control)obj21).Location = location;
		((Control)lblTrang_Thai).Name = "lblTrang_Thai";
		Label obj22 = lblTrang_Thai;
		size = new Size(55, 13);
		((Control)obj22).Size = size;
		((Control)lblTrang_Thai).TabIndex = 65;
		lblTrang_Thai.Text = "Trạng thái";
		((Control)lblTrang_Thai).Visible = false;
		((ComboBox)cboTrang_Thai).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboTrang_Thai).Enabled = false;
		((ListControl)cboTrang_Thai).FormattingEnabled = true;
		((ComboBox)cboTrang_Thai).Items.AddRange(new object[1] { "Tất cả" });
		AsComboBox asComboBox = cboTrang_Thai;
		location = new Point(519, 119);
		((Control)asComboBox).Location = location;
		((Control)cboTrang_Thai).Name = "cboTrang_Thai";
		AsComboBox asComboBox2 = cboTrang_Thai;
		size = new Size(132, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboTrang_Thai).TabIndex = 6;
		((Control)cboTrang_Thai).Visible = false;
		lblSo_ct1.AutoSize = true;
		Label obj23 = lblSo_ct1;
		location = new Point(17, 91);
		((Control)obj23).Location = location;
		((Control)lblSo_ct1).Name = "lblSo_ct1";
		Label obj24 = lblSo_ct1;
		size = new Size(64, 13);
		((Control)obj24).Size = size;
		((Control)lblSo_ct1).TabIndex = 64;
		lblSo_ct1.Text = "Chứng từ số";
		TextBox obj25 = txtSo_ct2;
		location = new Point(329, 88);
		((Control)obj25).Location = location;
		((Control)txtSo_ct2).Name = "txtSo_ct2";
		TextBox obj26 = txtSo_ct2;
		size = new Size(89, 20);
		((Control)obj26).Size = size;
		((Control)txtSo_ct2).TabIndex = 4;
		TextBox obj27 = txtSo_ct1;
		location = new Point(165, 88);
		((Control)obj27).Location = location;
		((Control)txtSo_ct1).Name = "txtSo_ct1";
		TextBox obj28 = txtSo_ct1;
		size = new Size(90, 20);
		((Control)obj28).Size = size;
		((Control)txtSo_ct1).TabIndex = 3;
		lblSo_Ct2.AutoSize = true;
		Label obj29 = lblSo_Ct2;
		location = new Point(282, 92);
		((Control)obj29).Location = location;
		((Control)lblSo_Ct2).Name = "lblSo_Ct2";
		Label obj30 = lblSo_Ct2;
		size = new Size(40, 13);
		((Control)obj30).Size = size;
		((Control)lblSo_Ct2).TabIndex = 29;
		lblSo_Ct2.Text = "đến số";
		lblLoaiPhieu.AutoSize = true;
		Label obj31 = lblLoaiPhieu;
		location = new Point(17, 115);
		((Control)obj31).Location = location;
		((Control)lblLoaiPhieu).Name = "lblLoaiPhieu";
		Label obj32 = lblLoaiPhieu;
		size = new Size(56, 13);
		((Control)obj32).Size = size;
		((Control)lblLoaiPhieu).TabIndex = 69;
		lblLoaiPhieu.Text = "Loại phiếu";
		((ComboBox)cboLoaiPhieu).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoaiPhieu).FormattingEnabled = true;
		((ComboBox)cboLoaiPhieu).Items.AddRange(new object[1] { "Tất cả" });
		AsComboBox asComboBox3 = cboLoaiPhieu;
		location = new Point(165, 112);
		((Control)asComboBox3).Location = location;
		((Control)cboLoaiPhieu).Name = "cboLoaiPhieu";
		AsComboBox asComboBox4 = cboLoaiPhieu;
		size = new Size(253, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboLoaiPhieu).TabIndex = 5;
		((Control)lblTen_vitri).Anchor = (AnchorStyles)13;
		((Control)lblTen_vitri).Enabled = false;
		Label obj33 = lblTen_vitri;
		location = new Point(830, 402);
		((Control)obj33).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj34 = lblTen_vitri;
		size = new Size(525, 13);
		((Control)obj34).Size = size;
		((Control)lblTen_vitri).TabIndex = 142;
		((Control)lblTen_vitri).Visible = false;
		((Control)lblTen_spct).Anchor = (AnchorStyles)13;
		Label obj35 = lblTen_spct;
		location = new Point(260, 407);
		((Control)obj35).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj36 = lblTen_spct;
		size = new Size(525, 13);
		((Control)obj36).Size = size;
		((Control)lblTen_spct).TabIndex = 144;
		txtMa_vitri.AutoLookup = true;
		txtMa_vitri.AutoValid = false;
		((TextBoxBase)txtMa_vitri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vitri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vitri).Enabled = false;
		AsTextBox asTextBox2 = txtMa_vitri;
		location = new Point(735, 362);
		((Control)asTextBox2).Location = location;
		txtMa_vitri.LookupCodeName = "MA_VITRI";
		((Control)txtMa_vitri).Name = "txtMa_vitri";
		txtMa_vitri.NameControl = lblTen_vitri;
		AsTextBox asTextBox3 = txtMa_vitri;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_vitri).TabIndex = 20;
		((Control)txtMa_vitri).Tag = "MA_VITRI";
		txtMa_vitri.UseAutoCompleteSource = true;
		((Control)txtMa_vitri).Visible = false;
		lblMavitri.AutoSize = true;
		((Control)lblMavitri).Enabled = false;
		Label obj37 = lblMavitri;
		location = new Point(649, 365);
		((Control)obj37).Location = location;
		((Control)lblMavitri).Name = "lblMavitri";
		Label obj38 = lblMavitri;
		size = new Size(46, 13);
		((Control)obj38).Size = size;
		((Control)lblMavitri).TabIndex = 143;
		lblMavitri.Text = "Mã vị trí";
		((Control)lblMavitri).Visible = false;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_spct;
		location = new Point(165, 403);
		((Control)asTextBox4).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox5 = txtMa_spct;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_spct).TabIndex = 18;
		((Control)txtMa_spct).Tag = "MA_SPCT";
		txtMa_spct.UseAutoCompleteSource = true;
		((Control)lblTen_lkh3).Anchor = (AnchorStyles)13;
		Label obj39 = lblTen_lkh3;
		location = new Point(260, 215);
		((Control)obj39).Location = location;
		((Control)lblTen_lkh3).Name = "lblTen_lkh3";
		Label obj40 = lblTen_lkh3;
		size = new Size(525, 13);
		((Control)obj40).Size = size;
		((Control)lblTen_lkh3).TabIndex = 110;
		lblMa_spct.AutoSize = true;
		Label obj41 = lblMa_spct;
		location = new Point(17, 407);
		((Control)obj41).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj42 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj42).Size = size;
		((Control)lblMa_spct).TabIndex = 145;
		lblMa_spct.Text = "Mã SPCT";
		lblMa_spct.TextAlign = (ContentAlignment)32;
		((Control)lblTen_lkh2).Anchor = (AnchorStyles)13;
		Label obj43 = lblTen_lkh2;
		location = new Point(260, 191);
		((Control)obj43).Location = location;
		((Control)lblTen_lkh2).Name = "lblTen_lkh2";
		Label obj44 = lblTen_lkh2;
		size = new Size(525, 13);
		((Control)obj44).Size = size;
		((Control)lblTen_lkh2).TabIndex = 109;
		((Control)lblTen_lkh1).Anchor = (AnchorStyles)13;
		Label obj45 = lblTen_lkh1;
		location = new Point(260, 167);
		((Control)obj45).Location = location;
		((Control)lblTen_lkh1).Name = "lblTen_lkh1";
		Label obj46 = lblTen_lkh1;
		size = new Size(525, 13);
		((Control)obj46).Size = size;
		((Control)lblTen_lkh1).TabIndex = 108;
		((Control)lblTen_kho).Anchor = (AnchorStyles)13;
		Label obj47 = lblTen_kho;
		location = new Point(260, 431);
		((Control)obj47).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj48 = lblTen_kho;
		size = new Size(525, 13);
		((Control)obj48).Size = size;
		((Control)lblTen_kho).TabIndex = 118;
		lblPlkh3.AutoSize = true;
		Label obj49 = lblPlkh3;
		location = new Point(17, 215);
		((Control)obj49).Location = location;
		((Control)lblPlkh3).Name = "lblPlkh3";
		Label obj50 = lblPlkh3;
		size = new Size(57, 13);
		((Control)obj50).Size = size;
		((Control)lblPlkh3).TabIndex = 131;
		lblPlkh3.Text = "P.loại KH3";
		txtMa_Plkh3.AutoLookup = true;
		txtMa_Plkh3.AutoValid = false;
		((TextBoxBase)txtMa_Plkh3).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_Plkh3;
		location = new Point(165, 211);
		((Control)asTextBox6).Location = location;
		txtMa_Plkh3.LookupCodeName = "MA_PLKH";
		txtMa_Plkh3.LookupWhereCondition = "loai='3'";
		((Control)txtMa_Plkh3).Name = "txtMa_Plkh3";
		txtMa_Plkh3.NameControl = lblTen_lkh3;
		AsTextBox asTextBox7 = txtMa_Plkh3;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_Plkh3).TabIndex = 10;
		((Control)txtMa_Plkh3).Tag = "MA_PLKH";
		txtMa_Plkh3.UseAutoCompleteSource = true;
		((Control)lblTen_lo).Anchor = (AnchorStyles)13;
		Label obj51 = lblTen_lo;
		location = new Point(260, 455);
		((Control)obj51).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj52 = lblTen_lo;
		size = new Size(525, 13);
		((Control)obj52).Size = size;
		((Control)lblTen_lo).TabIndex = 136;
		lblPlkh2.AutoSize = true;
		Label obj53 = lblPlkh2;
		location = new Point(17, 191);
		((Control)obj53).Location = location;
		((Control)lblPlkh2).Name = "lblPlkh2";
		Label obj54 = lblPlkh2;
		size = new Size(57, 13);
		((Control)obj54).Size = size;
		((Control)lblPlkh2).TabIndex = 132;
		lblPlkh2.Text = "P.loại KH2";
		txtMa_Plkh2.AutoLookup = true;
		txtMa_Plkh2.AutoValid = false;
		((TextBoxBase)txtMa_Plkh2).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_Plkh2;
		location = new Point(165, 187);
		((Control)asTextBox8).Location = location;
		txtMa_Plkh2.LookupCodeName = "MA_PLKH";
		txtMa_Plkh2.LookupWhereCondition = "loai='2'";
		((Control)txtMa_Plkh2).Name = "txtMa_Plkh2";
		txtMa_Plkh2.NameControl = lblTen_lkh2;
		AsTextBox asTextBox9 = txtMa_Plkh2;
		size = new Size(90, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_Plkh2).TabIndex = 9;
		((Control)txtMa_Plkh2).Tag = "MA_PLKH";
		txtMa_Plkh2.UseAutoCompleteSource = true;
		txtMaLo.AutoLookup = true;
		txtMaLo.AutoValid = false;
		((TextBoxBase)txtMaLo).BackColor = SystemColors.Info;
		((TextBox)txtMaLo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMaLo;
		location = new Point(165, 451);
		((Control)asTextBox10).Location = location;
		txtMaLo.LookupCodeName = "MA_LO";
		((Control)txtMaLo).Name = "txtMaLo";
		txtMaLo.NameControl = lblTen_lo;
		AsTextBox asTextBox11 = txtMaLo;
		size = new Size(90, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMaLo).TabIndex = 21;
		((Control)txtMaLo).Tag = "MA_LO";
		txtMaLo.UseAutoCompleteSource = true;
		lblPlkh1.AutoSize = true;
		Label obj55 = lblPlkh1;
		location = new Point(17, 167);
		((Control)obj55).Location = location;
		((Control)lblPlkh1).Name = "lblPlkh1";
		Label obj56 = lblPlkh1;
		size = new Size(57, 13);
		((Control)obj56).Size = size;
		((Control)lblPlkh1).TabIndex = 133;
		lblPlkh1.Text = "P.loại KH1";
		lblMaLo.AutoSize = true;
		Label obj57 = lblMaLo;
		location = new Point(17, 455);
		((Control)obj57).Location = location;
		((Control)lblMaLo).Name = "lblMaLo";
		Label obj58 = lblMaLo;
		size = new Size(33, 13);
		((Control)obj58).Size = size;
		((Control)lblMaLo).TabIndex = 137;
		lblMaLo.Text = "Mã lô";
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_kho;
		location = new Point(165, 427);
		((Control)asTextBox12).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox13 = txtMa_kho;
		size = new Size(90, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_kho).TabIndex = 19;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		lblMa_kho.AutoSize = true;
		Label obj59 = lblMa_kho;
		location = new Point(17, 431);
		((Control)obj59).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj60 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj60).Size = size;
		((Control)lblMa_kho).TabIndex = 123;
		lblMa_kho.Text = "Mã kho";
		txtMa_Plkh1.AutoLookup = true;
		txtMa_Plkh1.AutoValid = false;
		((TextBoxBase)txtMa_Plkh1).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_Plkh1;
		location = new Point(165, 163);
		((Control)asTextBox14).Location = location;
		txtMa_Plkh1.LookupCodeName = "MA_PLKH";
		txtMa_Plkh1.LookupWhereCondition = "loai='1'";
		((Control)txtMa_Plkh1).Name = "txtMa_Plkh1";
		txtMa_Plkh1.NameControl = lblTen_lkh1;
		AsTextBox asTextBox15 = txtMa_Plkh1;
		size = new Size(90, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_Plkh1).TabIndex = 8;
		((Control)txtMa_Plkh1).Tag = "MA_PLKH";
		txtMa_Plkh1.UseAutoCompleteSource = true;
		txtMa_Plvt1.AutoLookup = true;
		txtMa_Plvt1.AutoValid = false;
		((TextBoxBase)txtMa_Plvt1).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plvt1).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_Plvt1).Enabled = false;
		AsTextBox asTextBox16 = txtMa_Plvt1;
		location = new Point(735, 254);
		((Control)asTextBox16).Location = location;
		txtMa_Plvt1.LookupCodeName = "MA_PLVT";
		txtMa_Plvt1.LookupWhereCondition = "loai='1'";
		((Control)txtMa_Plvt1).Name = "txtMa_Plvt1";
		txtMa_Plvt1.NameControl = lblTen_plvt1;
		AsTextBox asTextBox17 = txtMa_Plvt1;
		size = new Size(90, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtMa_Plvt1).TabIndex = 4;
		((Control)txtMa_Plvt1).Tag = "MA_PLVT";
		txtMa_Plvt1.UseAutoCompleteSource = true;
		((Control)txtMa_Plvt1).Visible = false;
		((Control)lblTen_plvt1).Anchor = (AnchorStyles)13;
		((Control)lblTen_plvt1).Enabled = false;
		Label obj61 = lblTen_plvt1;
		location = new Point(830, 294);
		((Control)obj61).Location = location;
		((Control)lblTen_plvt1).Name = "lblTen_plvt1";
		Label obj62 = lblTen_plvt1;
		size = new Size(343, 13);
		((Control)obj62).Size = size;
		((Control)lblTen_plvt1).TabIndex = 115;
		((Control)lblTen_plvt1).Visible = false;
		lblPlvt3.AutoSize = true;
		((Control)lblPlvt3).Enabled = false;
		Label obj63 = lblPlvt3;
		location = new Point(649, 314);
		((Control)obj63).Location = location;
		((Control)lblPlvt3).Name = "lblPlvt3";
		Label obj64 = lblPlvt3;
		size = new Size(56, 13);
		((Control)obj64).Size = size;
		((Control)lblPlvt3).TabIndex = 124;
		lblPlvt3.Text = "P.loại VT3";
		((Control)lblPlvt3).Visible = false;
		txtMa_plvt3.AutoLookup = true;
		txtMa_plvt3.AutoValid = false;
		((TextBoxBase)txtMa_plvt3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt3).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt3).Enabled = false;
		AsTextBox asTextBox18 = txtMa_plvt3;
		location = new Point(735, 310);
		((Control)asTextBox18).Location = location;
		txtMa_plvt3.LookupCodeName = "MA_PLVT";
		txtMa_plvt3.LookupWhereCondition = "loai='3'";
		((Control)txtMa_plvt3).Name = "txtMa_plvt3";
		txtMa_plvt3.NameControl = lblTen_plvt3;
		AsTextBox asTextBox19 = txtMa_plvt3;
		size = new Size(90, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtMa_plvt3).TabIndex = 6;
		((Control)txtMa_plvt3).Tag = "MA_PLVT";
		txtMa_plvt3.UseAutoCompleteSource = true;
		((Control)txtMa_plvt3).Visible = false;
		((Control)lblTen_plvt3).Anchor = (AnchorStyles)13;
		((Control)lblTen_plvt3).Enabled = false;
		Label obj65 = lblTen_plvt3;
		location = new Point(830, 350);
		((Control)obj65).Location = location;
		((Control)lblTen_plvt3).Name = "lblTen_plvt3";
		Label obj66 = lblTen_plvt3;
		size = new Size(343, 13);
		((Control)obj66).Size = size;
		((Control)lblTen_plvt3).TabIndex = 117;
		((Control)lblTen_plvt3).Visible = false;
		lblPlvt2.AutoSize = true;
		((Control)lblPlvt2).Enabled = false;
		Label obj67 = lblPlvt2;
		location = new Point(649, 286);
		((Control)obj67).Location = location;
		((Control)lblPlvt2).Name = "lblPlvt2";
		Label obj68 = lblPlvt2;
		size = new Size(56, 13);
		((Control)obj68).Size = size;
		((Control)lblPlvt2).TabIndex = 125;
		lblPlvt2.Text = "P.loại VT2";
		((Control)lblPlvt2).Visible = false;
		txtMa_Plvt2.AutoLookup = true;
		txtMa_Plvt2.AutoValid = false;
		((TextBoxBase)txtMa_Plvt2).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plvt2).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_Plvt2).Enabled = false;
		AsTextBox asTextBox20 = txtMa_Plvt2;
		location = new Point(735, 282);
		((Control)asTextBox20).Location = location;
		txtMa_Plvt2.LookupCodeName = "MA_PLVT";
		txtMa_Plvt2.LookupWhereCondition = "loai='2'";
		((Control)txtMa_Plvt2).Name = "txtMa_Plvt2";
		txtMa_Plvt2.NameControl = lblTen_plvt2;
		AsTextBox asTextBox21 = txtMa_Plvt2;
		size = new Size(90, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMa_Plvt2).TabIndex = 5;
		((Control)txtMa_Plvt2).Tag = "MA_PLVT";
		txtMa_Plvt2.UseAutoCompleteSource = true;
		((Control)txtMa_Plvt2).Visible = false;
		((Control)lblTen_plvt2).Anchor = (AnchorStyles)13;
		((Control)lblTen_plvt2).Enabled = false;
		Label obj69 = lblTen_plvt2;
		location = new Point(830, 322);
		((Control)obj69).Location = location;
		((Control)lblTen_plvt2).Name = "lblTen_plvt2";
		Label obj70 = lblTen_plvt2;
		size = new Size(343, 13);
		((Control)obj70).Size = size;
		((Control)lblTen_plvt2).TabIndex = 116;
		((Control)lblTen_plvt2).Visible = false;
		lblPlvt1.AutoSize = true;
		((Control)lblPlvt1).Enabled = false;
		Label obj71 = lblPlvt1;
		location = new Point(649, 258);
		((Control)obj71).Location = location;
		((Control)lblPlvt1).Name = "lblPlvt1";
		Label obj72 = lblPlvt1;
		size = new Size(56, 13);
		((Control)obj72).Size = size;
		((Control)lblPlvt1).TabIndex = 126;
		lblPlvt1.Text = "P.loại VT1";
		((Control)lblPlvt1).Visible = false;
		((Control)lblTen_TT).Anchor = (AnchorStyles)13;
		((Control)lblTen_TT).Enabled = false;
		Label obj73 = lblTen_TT;
		location = new Point(830, 376);
		((Control)obj73).Location = location;
		((Control)lblTen_TT).Name = "lblTen_TT";
		Label obj74 = lblTen_TT;
		size = new Size(317, 13);
		((Control)obj74).Size = size;
		((Control)lblTen_TT).TabIndex = 140;
		((Control)lblTen_TT).Visible = false;
		txtMA_DKTT.AutoLookup = true;
		txtMA_DKTT.AutoValid = false;
		((TextBoxBase)txtMA_DKTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_DKTT).CharacterCasing = (CharacterCasing)1;
		((Control)txtMA_DKTT).Enabled = false;
		AsTextBox asTextBox22 = txtMA_DKTT;
		location = new Point(735, 336);
		((Control)asTextBox22).Location = location;
		txtMA_DKTT.LookupCodeName = "MA_TT";
		((Control)txtMA_DKTT).Name = "txtMA_DKTT";
		txtMA_DKTT.NameControl = lblTen_TT;
		AsTextBox asTextBox23 = txtMA_DKTT;
		size = new Size(90, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMA_DKTT).TabIndex = 9;
		((Control)txtMA_DKTT).Tag = "MA_TT";
		txtMA_DKTT.UseAutoCompleteSource = true;
		((Control)txtMA_DKTT).Visible = false;
		lblDkTT.AutoSize = true;
		((Control)lblDkTT).Enabled = false;
		Label obj75 = lblDkTT;
		location = new Point(649, 340);
		((Control)obj75).Location = location;
		((Control)lblDkTT).Name = "lblDkTT";
		Label obj76 = lblDkTT;
		size = new Size(79, 13);
		((Control)obj76).Size = size;
		((Control)lblDkTT).TabIndex = 141;
		lblDkTT.Text = "Điều khoản TT";
		((Control)lblDkTT).Visible = false;
		((Control)lblTenHTTT).Anchor = (AnchorStyles)13;
		Label obj77 = lblTenHTTT;
		location = new Point(260, 383);
		((Control)obj77).Location = location;
		((Control)lblTenHTTT).Name = "lblTenHTTT";
		Label obj78 = lblTenHTTT;
		size = new Size(525, 13);
		((Control)obj78).Size = size;
		((Control)lblTenHTTT).TabIndex = 138;
		txtMa_Nhkh.AutoLookup = true;
		txtMa_Nhkh.AutoValid = false;
		((TextBoxBase)txtMa_Nhkh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nhkh).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_Nhkh).Enabled = false;
		AsTextBox asTextBox24 = txtMa_Nhkh;
		location = new Point(735, 231);
		((Control)asTextBox24).Location = location;
		txtMa_Nhkh.LookupCodeName = "MA_NHKH";
		((Control)txtMa_Nhkh).Name = "txtMa_Nhkh";
		txtMa_Nhkh.NameControl = lblTen_nhkh;
		AsTextBox asTextBox25 = txtMa_Nhkh;
		size = new Size(90, 20);
		((Control)asTextBox25).Size = size;
		((Control)txtMa_Nhkh).TabIndex = 1;
		((Control)txtMa_Nhkh).Tag = "MA_NHKH";
		txtMa_Nhkh.UseAutoCompleteSource = true;
		((Control)txtMa_Nhkh).Visible = false;
		((Control)lblTen_nhkh).Anchor = (AnchorStyles)13;
		((Control)lblTen_nhkh).Enabled = false;
		Label obj79 = lblTen_nhkh;
		location = new Point(830, 271);
		((Control)obj79).Location = location;
		((Control)lblTen_nhkh).Name = "lblTen_nhkh";
		Label obj80 = lblTen_nhkh;
		size = new Size(317, 13);
		((Control)obj80).Size = size;
		((Control)lblTen_nhkh).TabIndex = 107;
		((Control)lblTen_nhkh).Visible = false;
		txtMA_HTTT.AutoLookup = true;
		txtMA_HTTT.AutoValid = false;
		((TextBoxBase)txtMA_HTTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_HTTT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox26 = txtMA_HTTT;
		location = new Point(165, 379);
		((Control)asTextBox26).Location = location;
		txtMA_HTTT.LookupCodeName = "MA_HTTT";
		txtMA_HTTT.LookupWhereCondition = "moduleid='so'";
		((Control)txtMA_HTTT).Name = "txtMA_HTTT";
		txtMA_HTTT.NameControl = lblTenHTTT;
		AsTextBox asTextBox27 = txtMA_HTTT;
		size = new Size(90, 20);
		((Control)asTextBox27).Size = size;
		((Control)txtMA_HTTT).TabIndex = 17;
		((Control)txtMA_HTTT).Tag = "MA_HTTT";
		txtMA_HTTT.UseAutoCompleteSource = true;
		lblHTTT.AutoSize = true;
		Label obj81 = lblHTTT;
		location = new Point(17, 383);
		((Control)obj81).Location = location;
		((Control)lblHTTT).Name = "lblHTTT";
		Label obj82 = lblHTTT;
		size = new Size(70, 13);
		((Control)obj82).Size = size;
		((Control)lblHTTT).TabIndex = 139;
		lblHTTT.Text = "Hình thức TT";
		txtMa_nhhd.AutoLookup = true;
		txtMa_nhhd.AutoValid = false;
		((TextBoxBase)txtMa_nhhd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhhd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox28 = txtMa_nhhd;
		location = new Point(165, 259);
		((Control)asTextBox28).Location = location;
		txtMa_nhhd.LookupCodeName = "MA_NHHD";
		((Control)txtMa_nhhd).Name = "txtMa_nhhd";
		txtMa_nhhd.NameControl = lblTen_Nhhd;
		AsTextBox asTextBox29 = txtMa_nhhd;
		size = new Size(90, 20);
		((Control)asTextBox29).Size = size;
		((Control)txtMa_nhhd).TabIndex = 12;
		((Control)txtMa_nhhd).Tag = "MA_NHHD";
		txtMa_nhhd.UseAutoCompleteSource = true;
		((Control)lblTen_Nhhd).Anchor = (AnchorStyles)13;
		Label obj83 = lblTen_Nhhd;
		location = new Point(260, 263);
		((Control)obj83).Location = location;
		((Control)lblTen_Nhhd).Name = "lblTen_Nhhd";
		Label obj84 = lblTen_Nhhd;
		size = new Size(525, 13);
		((Control)obj84).Size = size;
		((Control)lblTen_Nhhd).TabIndex = 112;
		lblMa_nhhd.AutoSize = true;
		Label obj85 = lblMa_nhhd;
		location = new Point(17, 263);
		((Control)obj85).Location = location;
		((Control)lblMa_nhhd).Name = "lblMa_nhhd";
		Label obj86 = lblMa_nhhd;
		size = new Size(84, 13);
		((Control)obj86).Size = size;
		((Control)lblMa_nhhd).TabIndex = 129;
		lblMa_nhhd.Text = "Nhóm hợp đồng";
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = false;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox30 = txtMa_kh;
		location = new Point(165, 139);
		((Control)asTextBox30).Location = location;
		txtMa_kh.LookupCodeName = "MA_KH";
		txtMa_kh.LookupWhereCondition = "isKh=1";
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = lblTen_KH;
		AsTextBox asTextBox31 = txtMa_kh;
		size = new Size(90, 20);
		((Control)asTextBox31).Size = size;
		((Control)txtMa_kh).TabIndex = 7;
		((Control)txtMa_kh).Tag = "Ma_KH";
		txtMa_kh.UseAutoCompleteSource = true;
		((Control)lblTen_KH).Anchor = (AnchorStyles)13;
		Label obj87 = lblTen_KH;
		location = new Point(260, 143);
		((Control)obj87).Location = location;
		((Control)lblTen_KH).Name = "lblTen_KH";
		Label obj88 = lblTen_KH;
		size = new Size(525, 13);
		((Control)obj88).Size = size;
		((Control)lblTen_KH).TabIndex = 106;
		lblMa_Kh.AutoSize = true;
		Label obj89 = lblMa_Kh;
		location = new Point(17, 143);
		((Control)obj89).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj90 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj90).Size = size;
		((Control)lblMa_Kh).TabIndex = 135;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_hd.AutoSize = true;
		Label obj91 = lblMa_hd;
		location = new Point(17, 239);
		((Control)obj91).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj92 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj92).Size = size;
		((Control)lblMa_hd).TabIndex = 130;
		lblMa_hd.Text = "Mã hợp đồng";
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox32 = txtMa_hd;
		location = new Point(165, 235);
		((Control)asTextBox32).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox33 = txtMa_hd;
		size = new Size(90, 20);
		((Control)asTextBox33).Size = size;
		((Control)txtMa_hd).TabIndex = 11;
		((Control)txtMa_hd).Tag = "MA_HD";
		txtMa_hd.UseAutoCompleteSource = true;
		((Control)lblTen_hd).Anchor = (AnchorStyles)13;
		Label obj93 = lblTen_hd;
		location = new Point(260, 239);
		((Control)obj93).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj94 = lblTen_hd;
		size = new Size(525, 13);
		((Control)obj94).Size = size;
		((Control)lblTen_hd).TabIndex = 111;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox34 = txtMa_vt;
		location = new Point(165, 283);
		((Control)asTextBox34).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox35 = txtMa_vt;
		size = new Size(90, 20);
		((Control)asTextBox35).Size = size;
		((Control)txtMa_vt).TabIndex = 13;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		((Control)lblTen_vt).Anchor = (AnchorStyles)13;
		Label obj95 = lblTen_vt;
		location = new Point(260, 287);
		((Control)obj95).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj96 = lblTen_vt;
		size = new Size(525, 13);
		((Control)obj96).Size = size;
		((Control)lblTen_vt).TabIndex = 113;
		lblMa_vt.AutoSize = true;
		Label obj97 = lblMa_vt;
		location = new Point(17, 287);
		((Control)obj97).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj98 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj98).Size = size;
		((Control)lblMa_vt).TabIndex = 128;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox36 = txtMa_nhvt;
		location = new Point(165, 307);
		((Control)asTextBox36).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_Nhvt;
		AsTextBox asTextBox37 = txtMa_nhvt;
		size = new Size(90, 20);
		((Control)asTextBox37).Size = size;
		((Control)txtMa_nhvt).TabIndex = 14;
		((Control)txtMa_nhvt).Tag = "MA_NHVT";
		txtMa_nhvt.UseAutoCompleteSource = true;
		((Control)lblTen_Nhvt).Anchor = (AnchorStyles)13;
		Label obj99 = lblTen_Nhvt;
		location = new Point(260, 311);
		((Control)obj99).Location = location;
		((Control)lblTen_Nhvt).Name = "lblTen_Nhvt";
		Label obj100 = lblTen_Nhvt;
		size = new Size(525, 13);
		((Control)obj100).Size = size;
		((Control)lblTen_Nhvt).TabIndex = 114;
		lblMa_nhvt.AutoSize = true;
		Label obj101 = lblMa_nhvt;
		location = new Point(17, 311);
		((Control)obj101).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj102 = lblMa_nhvt;
		size = new Size(65, 13);
		((Control)obj102).Size = size;
		((Control)lblMa_nhvt).TabIndex = 127;
		lblMa_nhvt.Text = "Nhóm vật tư";
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox38 = txtMa_bp;
		location = new Point(165, 331);
		((Control)asTextBox38).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox39 = txtMa_bp;
		size = new Size(90, 20);
		((Control)asTextBox39).Size = size;
		((Control)txtMa_bp).TabIndex = 15;
		((Control)txtMa_bp).Tag = "MA_BP";
		txtMa_bp.UseAutoCompleteSource = true;
		((Control)lblTen_bp).Anchor = (AnchorStyles)13;
		Label obj103 = lblTen_bp;
		location = new Point(260, 335);
		((Control)obj103).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj104 = lblTen_bp;
		size = new Size(525, 13);
		((Control)obj104).Size = size;
		((Control)lblTen_bp).TabIndex = 119;
		lblMa_Nhkh.AutoSize = true;
		((Control)lblMa_Nhkh).Enabled = false;
		Label obj105 = lblMa_Nhkh;
		location = new Point(649, 235);
		((Control)obj105).Location = location;
		((Control)lblMa_Nhkh).Name = "lblMa_Nhkh";
		Label obj106 = lblMa_Nhkh;
		size = new Size(53, 13);
		((Control)obj106).Size = size;
		((Control)lblMa_Nhkh).TabIndex = 134;
		lblMa_Nhkh.Text = "Nhóm KH";
		((Control)lblMa_Nhkh).Visible = false;
		lblMa_bp.AutoSize = true;
		Label obj107 = lblMa_bp;
		location = new Point(17, 335);
		((Control)obj107).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj108 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj108).Size = size;
		((Control)lblMa_bp).TabIndex = 122;
		lblMa_bp.Text = "Mã bộ phận";
		txtMa_nvkd.AutoLookup = true;
		txtMa_nvkd.AutoValid = false;
		((TextBoxBase)txtMa_nvkd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nvkd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox40 = txtMa_nvkd;
		location = new Point(165, 355);
		((Control)asTextBox40).Location = location;
		txtMa_nvkd.LookupCodeName = "MA_NVKD";
		((Control)txtMa_nvkd).Name = "txtMa_nvkd";
		txtMa_nvkd.NameControl = lblTen_nvkd;
		AsTextBox asTextBox41 = txtMa_nvkd;
		size = new Size(90, 20);
		((Control)asTextBox41).Size = size;
		((Control)txtMa_nvkd).TabIndex = 16;
		((Control)txtMa_nvkd).Tag = "MA_NVKD";
		txtMa_nvkd.UseAutoCompleteSource = true;
		((Control)lblTen_nvkd).Anchor = (AnchorStyles)13;
		Label obj109 = lblTen_nvkd;
		location = new Point(260, 359);
		((Control)obj109).Location = location;
		((Control)lblTen_nvkd).Name = "lblTen_nvkd";
		Label obj110 = lblTen_nvkd;
		size = new Size(525, 13);
		((Control)obj110).Size = size;
		((Control)lblTen_nvkd).TabIndex = 120;
		lblMa_nvkd.AutoSize = true;
		Label obj111 = lblMa_nvkd;
		location = new Point(17, 359);
		((Control)obj111).Location = location;
		((Control)lblMa_nvkd).Name = "lblMa_nvkd";
		Label obj112 = lblMa_nvkd;
		size = new Size(55, 13);
		((Control)obj112).Size = size;
		((Control)lblMa_nvkd).TabIndex = 121;
		lblMa_nvkd.Text = "Mã NVKD";
		lblMa_nvkd.TextAlign = (ContentAlignment)32;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).AutoScroll = true;
		size = new Size(960, 609);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSORptBK01";
		((Form)this).Text = "";
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)tabGrid).ResumeLayout(false);
		((Control)scGrid).ResumeLayout(false);
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
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoaiPhieu).SelectedValue));
		arrayList.Add("");
		arrayList.Add(((TextBox)txtMa_kh).Text);
		arrayList.Add(((TextBox)txtMa_Nhkh).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_vitri).Text);
		arrayList.Add(((TextBox)txtMaLo).Text);
		arrayList.Add(((TextBox)txtMA_HTTT).Text);
		arrayList.Add(((TextBox)txtMA_DKTT).Text);
		arrayList.Add(((TextBox)txtMa_bp).Text);
		arrayList.Add(((TextBox)txtMa_nvkd).Text);
		arrayList.Add(((TextBox)txtMa_spct).Text);
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtMa_nhhd).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(txtSo_ct1.Text);
		arrayList.Add(txtSo_ct2.Text);
		arrayList.Add(((TextBox)txtMa_Plkh1).Text);
		arrayList.Add(((TextBox)txtMa_Plkh2).Text);
		arrayList.Add(((TextBox)txtMa_Plkh3).Text);
		arrayList.Add(((TextBox)txtMa_Plvt1).Text);
		arrayList.Add(((TextBox)txtMa_Plvt2).Text);
		arrayList.Add(((TextBox)txtMa_plvt3).Text);
		DataSet dataSet = MyController.GetDataSet(arrayList.ToArray());
		set_MyDGVPhSource(isSet2Print: true, dataSet.Tables[1]);
		set_MyDGVCtSource(isSet2Print: true, dataSet.Tables[0]);
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = string.Empty;
		if (Operators.CompareString(txtSo_ct1.Text.Trim(), "", false) != 0)
		{
			text = text + lblSo_ct1.Text + ": [" + txtSo_ct1.Text + "]; ";
		}
		if (Operators.CompareString(txtSo_ct2.Text.Trim(), "", false) != 0)
		{
			text = text + lblSo_Ct2.Text + ": [" + txtSo_ct2.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Kh.Text + ": [" + ((TextBox)txtMa_kh).Text + " - " + lblTen_KH.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nhkh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Nhkh.Text + ": [" + ((TextBox)txtMa_Nhkh).Text + " - " + lblTen_nhkh.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plkh1).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlkh1.Text + ": [" + ((TextBox)txtMa_Plkh1).Text + " - " + lblTen_lkh1.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plkh2).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlkh2.Text + ": [" + ((TextBox)txtMa_Plkh2).Text + " - " + lblTen_lkh2.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plkh3).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlkh3.Text + ": [" + ((TextBox)txtMa_Plkh3).Text + " - " + lblTen_lkh3.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_hd).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_hd.Text + ": [" + ((TextBox)txtMa_hd).Text + " - " + lblTen_hd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhhd).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nhhd.Text + ": [" + ((TextBox)txtMa_nhhd).Text + " - " + lblTen_Nhhd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_vt.Text + ": [" + ((TextBox)txtMa_vt).Text + " - " + lblTen_vt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhvt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nhvt.Text + ": [" + ((TextBox)txtMa_nhvt).Text + " - " + lblTen_Nhvt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plvt1).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlvt1.Text + ": [" + ((TextBox)txtMa_Plvt1).Text + " - " + lblTen_plvt1.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plvt2).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlvt2.Text + ": [" + ((TextBox)txtMa_Plvt2).Text + " - " + lblTen_plvt2.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt3).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlvt3.Text + ": [" + ((TextBox)txtMa_plvt3).Text + " - " + lblTen_plvt3.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_bp).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_bp.Text + ": [" + ((TextBox)txtMa_bp).Text + " - " + lblTen_bp.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nvkd).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nvkd.Text + ": [" + ((TextBox)txtMa_nvkd).Text + " - " + lblTen_nvkd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMA_HTTT).Text.Trim(), "", false) != 0)
		{
			text = text + lblHTTT.Text + ": [" + ((TextBox)txtMA_HTTT).Text + " - " + lblTenHTTT.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMA_DKTT).Text.Trim(), "", false) != 0)
		{
			text = text + lblDkTT.Text + ": [" + ((TextBox)txtMA_DKTT).Text + " - " + lblDkTT.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_spct).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_spct.Text + ": [" + ((TextBox)txtMa_spct).Text + " - " + lblTen_spct.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": [" + ((TextBox)txtMa_kho).Text + " - " + lblTen_kho.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vitri).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_vitri.Text + ": [" + ((TextBox)txtMa_vitri).Text + " - " + lblTen_vitri.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMaLo).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_lo.Text + ": [" + ((TextBox)txtMaLo).Text + " - " + lblTen_lo.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": [" + ((TextBox)txtMa_Nt).Text + "]; ";
		}
		return text;
	}

	private void dgvBCPh_RowEnter(object sender, DataGridViewCellEventArgs e)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (((object)(DataTable)dgvBCPh.DataSource != DBNull.Value) & ((DataTable)dgvBCCt.DataSource != null))
			{
				((DataTable)dgvBCCt.DataSource).DefaultView.RowFilter = "stt_rec='" + ((DataTable)dgvBCPh.DataSource).DefaultView[e.RowIndex]["stt_rec"].ToString() + "'";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void cboMau_bc_SelectedIndexChanged(object sender, EventArgs e)
	{
		((ListControl)cboLoaiPhieu).SelectedValue = base.MyReportInfo.par0;
	}
}
