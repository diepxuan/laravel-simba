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
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmPORptBK01 : frmReport2DGV
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtCT2")]
	private TextBox _txtCT2;

	[AccessedThroughProperty("lblct2")]
	private Label _lblct2;

	[AccessedThroughProperty("txtCT1")]
	private TextBox _txtCT1;

	[AccessedThroughProperty("lblSo_ct1")]
	private Label _lblSo_ct1;

	[AccessedThroughProperty("lblTen_nv_kd")]
	private Label _lblTen_nv_kd;

	[AccessedThroughProperty("lblNv_kd")]
	private Label _lblNv_kd;

	[AccessedThroughProperty("txtNv_kd")]
	private AsTextBox _txtNv_kd;

	[AccessedThroughProperty("lblNh_theo")]
	private Label _lblNh_theo;

	[AccessedThroughProperty("chkNh_Ncc")]
	private AsCheckBox _chkNh_Ncc;

	[AccessedThroughProperty("cboLoaiPhieu")]
	private AsComboBox _cboLoaiPhieu;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblTrang_Thai")]
	private Label _lblTrang_Thai;

	[AccessedThroughProperty("cboTrang_Thai")]
	private AsComboBox _cboTrang_Thai;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("txtMa_nhhd")]
	private AsTextBox _txtMa_nhhd;

	[AccessedThroughProperty("lblTen_Nhhd")]
	private Label _lblTen_Nhhd;

	[AccessedThroughProperty("lblMa_nhhd")]
	private Label _lblMa_nhhd;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

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

	[AccessedThroughProperty("lblTen_nh_vt")]
	private Label _lblTen_nh_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("txtMa_nh_vt")]
	private AsTextBox _txtMa_nh_vt;

	[AccessedThroughProperty("lblMa_nh_vt")]
	private Label _lblMa_nh_vt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("lblTen_nh_ncc")]
	private Label _lblTen_nh_ncc;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("txtMaLo")]
	private AsTextBox _txtMaLo;

	[AccessedThroughProperty("lblTen_ncc")]
	private Label _lblTen_ncc;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("txtMa_nh_ncc")]
	private AsTextBox _txtMa_nh_ncc;

	[AccessedThroughProperty("lblMaLo")]
	private Label _lblMaLo;

	[AccessedThroughProperty("lblMa_nh_ncc")]
	private Label _lblMa_nh_ncc;

	[AccessedThroughProperty("lblMa_vitri")]
	private Label _lblMa_vitri;

	[AccessedThroughProperty("txtMa_ncc")]
	private AsTextBox _txtMa_ncc;

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("lblMa_ncc")]
	private Label _lblMa_ncc;

	[AccessedThroughProperty("txtMa_vtri")]
	private AsTextBox _txtMa_vtri;

	[AccessedThroughProperty("lblTenPhi")]
	private Label _lblTenPhi;

	[AccessedThroughProperty("txtPl_ncc1")]
	private AsTextBox _txtPl_ncc1;

	[AccessedThroughProperty("lblTen_pl_ncc1")]
	private Label _lblTen_pl_ncc1;

	[AccessedThroughProperty("txtMaPhi")]
	private AsTextBox _txtMaPhi;

	[AccessedThroughProperty("lblPl_ncc1")]
	private Label _lblPl_ncc1;

	[AccessedThroughProperty("lblPl_ncc2")]
	private Label _lblPl_ncc2;

	[AccessedThroughProperty("txtPl_ncc2")]
	private AsTextBox _txtPl_ncc2;

	[AccessedThroughProperty("lblTen_pl_ncc2")]
	private Label _lblTen_pl_ncc2;

	[AccessedThroughProperty("lblPl_ncc3")]
	private Label _lblPl_ncc3;

	[AccessedThroughProperty("txtPl_ncc3")]
	private AsTextBox _txtPl_ncc3;

	[AccessedThroughProperty("lblTen_pl_ncc3")]
	private Label _lblTen_pl_ncc3;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("lblTen_plvt3")]
	private Label _lblTen_plvt3;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("txtMa_Plvt1")]
	private AsTextBox _txtMa_Plvt1;

	[AccessedThroughProperty("lblTen_plvt1")]
	private Label _lblTen_plvt1;

	[AccessedThroughProperty("lblTen_plvt2")]
	private Label _lblTen_plvt2;

	[AccessedThroughProperty("lblPlvt3")]
	private Label _lblPlvt3;

	[AccessedThroughProperty("txtMa_plvt3")]
	private AsTextBox _txtMa_plvt3;

	[AccessedThroughProperty("lblPlvt2")]
	private Label _lblPlvt2;

	[AccessedThroughProperty("lblPlvt1")]
	private Label _lblPlvt1;

	[AccessedThroughProperty("txtMa_Plvt2")]
	private AsTextBox _txtMa_Plvt2;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

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

	internal virtual TextBox txtCT2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCT2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCT2 = value;
		}
	}

	internal virtual Label lblct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblct2 = value;
		}
	}

	internal virtual TextBox txtCT1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCT1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCT1 = value;
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

	internal virtual Label lblTen_nv_kd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nv_kd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nv_kd = value;
		}
	}

	internal virtual Label lblNv_kd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNv_kd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNv_kd = value;
		}
	}

	internal virtual AsTextBox txtNv_kd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNv_kd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNv_kd = value;
		}
	}

	internal virtual Label lblNh_theo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNh_theo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNh_theo = value;
		}
	}

	internal virtual AsCheckBox chkNh_Ncc
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkNh_Ncc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkNh_Ncc = value;
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

	internal virtual Label lblTen_nh_ncc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nh_ncc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nh_ncc = value;
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

	internal virtual Label lblTen_ncc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ncc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ncc = value;
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

	internal virtual Label lblTen_pl_ncc1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_pl_ncc1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_pl_ncc1 = value;
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

	internal virtual Label lblTen_pl_ncc2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_pl_ncc2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_pl_ncc2 = value;
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

	internal virtual Label lblTen_pl_ncc3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_pl_ncc3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_pl_ncc3 = value;
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

	public frmPORptBK01(string menuID)
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
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
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
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
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		txtCT2 = new TextBox();
		lblct2 = new Label();
		txtCT1 = new TextBox();
		lblSo_ct1 = new Label();
		lblTen_nv_kd = new Label();
		lblNv_kd = new Label();
		txtNv_kd = new AsTextBox();
		chkNh_Ncc = new AsCheckBox();
		lblNh_theo = new Label();
		cboLoaiPhieu = new AsComboBox();
		Label1 = new Label();
		lblTrang_Thai = new Label();
		cboTrang_Thai = new AsComboBox();
		lblTen_bp = new Label();
		txtMa_bp = new AsTextBox();
		lblMa_bp = new Label();
		txtMa_nhhd = new AsTextBox();
		lblTen_Nhhd = new Label();
		lblMa_nhhd = new Label();
		lblTen_hd = new Label();
		txtMa_hd = new AsTextBox();
		lblMa_hd = new Label();
		lblTen_TT = new Label();
		txtMA_DKTT = new AsTextBox();
		lblDkTT = new Label();
		lblTenHTTT = new Label();
		txtMA_HTTT = new AsTextBox();
		lblHTTT = new Label();
		lblTen_nh_vt = new Label();
		lblTen_vt = new Label();
		txtMa_nh_vt = new AsTextBox();
		lblMa_nh_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		lblTen_lo = new Label();
		lblTen_nh_ncc = new Label();
		txtMa_kho = new AsTextBox();
		lblTen_kho = new Label();
		txtMaLo = new AsTextBox();
		lblTen_ncc = new Label();
		lblMa_kho = new Label();
		txtMa_nh_ncc = new AsTextBox();
		lblMaLo = new Label();
		lblMa_nh_ncc = new Label();
		lblMa_vitri = new Label();
		txtMa_ncc = new AsTextBox();
		lblTen_vitri = new Label();
		lblMa_ncc = new Label();
		txtMa_vtri = new AsTextBox();
		lblTenPhi = new Label();
		txtPl_ncc1 = new AsTextBox();
		lblTen_pl_ncc1 = new Label();
		txtMaPhi = new AsTextBox();
		lblPl_ncc1 = new Label();
		lblPl_ncc2 = new Label();
		txtPl_ncc2 = new AsTextBox();
		lblTen_pl_ncc2 = new Label();
		lblPl_ncc3 = new Label();
		txtPl_ncc3 = new AsTextBox();
		lblTen_pl_ncc3 = new Label();
		lblTen_spct = new Label();
		lblTen_plvt3 = new Label();
		txtMa_spct = new AsTextBox();
		lblMa_spct = new Label();
		txtMa_Plvt1 = new AsTextBox();
		lblTen_plvt1 = new Label();
		lblTen_plvt2 = new Label();
		lblPlvt3 = new Label();
		txtMa_plvt3 = new AsTextBox();
		lblPlvt2 = new Label();
		lblPlvt1 = new Label();
		txtMa_Plvt2 = new AsTextBox();
		Label8 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)tabGrid).SuspendLayout();
		((Control)scGrid).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(1006, 580);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((ScrollableControl)tabFilter).AutoScroll = false;
		((Control)tabFilter).Controls.Add((Control)(object)Label8);
		((Control)tabFilter).Controls.Add((Control)(object)lblTenPhi);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)txtPl_ncc1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMaPhi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)lblPl_ncc1);
		((Control)tabFilter).Controls.Add((Control)(object)lblPl_ncc2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)txtPl_ncc2);
		((Control)tabFilter).Controls.Add((Control)(object)lblPl_ncc3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtPl_ncc3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_pl_ncc1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_pl_ncc2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_pl_ncc3);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_TT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_DKTT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblDkTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTenHTTT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlvt2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_HTTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlvt1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblHTTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nh_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoaiPhieu);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nh_vt);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nh_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTrang_Thai);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)cboTrang_Thai);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblNh_theo);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lo);
		((Control)tabFilter).Controls.Add((Control)(object)chkNh_Ncc);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nh_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nv_kd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtCT2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)lblct2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)txtCT1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_ct1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nh_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)lblMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nh_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)txtNv_kd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblNv_kd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vtri);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		TabPage obj = tabFilter;
		size = new Size(998, 551);
		((Control)obj).Size = size;
		tabFilter.Text = "Điều kiện lọc";
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vtri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNv_kd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNv_kd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nh_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nh_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtCT1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtCT2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nv_kd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nh_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)chkNh_Ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNh_theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboTrang_Thai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTrang_Thai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nh_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nh_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoaiPhieu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nh_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblHTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_HTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTenHTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDkTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_DKTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_TT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_pl_ncc3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_pl_ncc2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_pl_ncc1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtPl_ncc3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPl_ncc3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtPl_ncc2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPl_ncc2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPl_ncc1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMaPhi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtPl_ncc1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTenPhi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label8, 0);
		Label obj2 = lbl2;
		Point location = new Point(328, 71);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 2;
		Button obj3 = cmdExcel;
		location = new Point(700, 689);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 25;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(347, 67);
		((Control)asMaskedTextBox).Location = location;
		Button obj4 = cmdCancel;
		location = new Point(619, 689);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 24;
		Button obj5 = cmdModifyReport;
		location = new Point(506, 16);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 15;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(257, 67);
		((Control)asMaskedTextBox2).Location = location;
		ComboBox obj6 = cboKyBc;
		location = new Point(161, 67);
		((Control)obj6).Location = location;
		Label obj7 = lblKyBc;
		location = new Point(25, 71);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(161, 18);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 14;
		Label obj9 = lblMau_bc;
		location = new Point(25, 21);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(161, 453);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 22;
		lblMauBC.AutoSize = true;
		Label obj10 = lblMauBC;
		location = new Point(217, 457);
		((Control)obj10).Location = location;
		Label obj11 = lblMauBC;
		size = new Size(70, 13);
		((Control)obj11).Size = size;
		((Control)lblMauBC).TabIndex = 10;
		((ButtonBase)optVND).AutoSize = true;
		RadioButton obj12 = optVND;
		location = new Point(304, 455);
		((Control)obj12).Location = location;
		RadioButton obj13 = optVND;
		size = new Size(48, 17);
		((Control)obj13).Size = size;
		((Control)optVND).TabIndex = 23;
		((ButtonBase)optNt).AutoSize = true;
		RadioButton obj14 = optNt;
		location = new Point(358, 455);
		((Control)obj14).Location = location;
		RadioButton obj15 = optNt;
		size = new Size(65, 17);
		((Control)obj15).Size = size;
		((Control)optNt).TabIndex = 24;
		Label obj16 = lblMa_nt;
		location = new Point(25, 457);
		((Control)obj16).Location = location;
		((Control)lblMa_nt).TabIndex = 8;
		Button obj17 = cmdOk;
		location = new Point(25, 484);
		((Control)obj17).Location = location;
		((Control)cmdOk).TabIndex = 25;
		Label obj18 = lblTieu_de;
		location = new Point(25, 47);
		((Control)obj18).Location = location;
		((Control)lblTieu_de).TabIndex = 23;
		TextBox obj19 = txtTieu_De;
		location = new Point(161, 43);
		((Control)obj19).Location = location;
		((Control)txtTieu_De).TabIndex = 0;
		TabPage obj20 = tabGrid;
		size = new Size(784, 483);
		((Control)obj20).Size = size;
		SplitContainer obj21 = scGrid;
		size = new Size(778, 477);
		((Control)obj21).Size = size;
		scGrid.SplitterDistance = 319;
		TextBox obj22 = txtCT2;
		location = new Point(328, 92);
		((Control)obj22).Location = location;
		((Control)txtCT2).Name = "txtCT2";
		TextBox obj23 = txtCT2;
		size = new Size(90, 20);
		((Control)obj23).Size = size;
		((Control)txtCT2).TabIndex = 6;
		lblct2.AutoSize = true;
		Label obj24 = lblct2;
		location = new Point(267, 95);
		((Control)obj24).Location = location;
		((Control)lblct2).Name = "lblct2";
		Label obj25 = lblct2;
		size = new Size(41, 13);
		((Control)obj25).Size = size;
		((Control)lblct2).TabIndex = 1067;
		lblct2.Text = "Đến số";
		TextBox obj26 = txtCT1;
		location = new Point(161, 92);
		((Control)obj26).Location = location;
		((Control)txtCT1).Name = "txtCT1";
		TextBox obj27 = txtCT1;
		size = new Size(90, 20);
		((Control)obj27).Size = size;
		((Control)txtCT1).TabIndex = 5;
		lblSo_ct1.AutoSize = true;
		Label obj28 = lblSo_ct1;
		location = new Point(25, 95);
		((Control)obj28).Location = location;
		((Control)lblSo_ct1).Name = "lblSo_ct1";
		Label obj29 = lblSo_ct1;
		size = new Size(64, 13);
		((Control)obj29).Size = size;
		((Control)lblSo_ct1).TabIndex = 1066;
		lblSo_ct1.Text = "Chứng từ số";
		lblTen_nv_kd.ImeMode = (ImeMode)0;
		Label obj30 = lblTen_nv_kd;
		location = new Point(610, 711);
		((Control)obj30).Location = location;
		((Control)lblTen_nv_kd).Name = "lblTen_nv_kd";
		Label obj31 = lblTen_nv_kd;
		size = new Size(314, 13);
		((Control)obj31).Size = size;
		((Control)lblTen_nv_kd).TabIndex = 1119;
		lblTen_nv_kd.TextAlign = (ContentAlignment)16;
		((Control)lblTen_nv_kd).Visible = false;
		lblNv_kd.AutoSize = true;
		Label obj32 = lblNv_kd;
		location = new Point(423, 708);
		((Control)obj32).Location = location;
		((Control)lblNv_kd).Name = "lblNv_kd";
		Label obj33 = lblNv_kd;
		size = new Size(55, 13);
		((Control)obj33).Size = size;
		((Control)lblNv_kd).TabIndex = 1118;
		lblNv_kd.Text = "Mã NVKD";
		((Control)lblNv_kd).Visible = false;
		txtNv_kd.AutoLookup = true;
		txtNv_kd.AutoValid = false;
		((TextBoxBase)txtNv_kd).BackColor = SystemColors.Info;
		((TextBox)txtNv_kd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtNv_kd;
		location = new Point(513, 705);
		((Control)asTextBox2).Location = location;
		txtNv_kd.LookupCodeName = "MA_NVKD";
		((TextBoxBase)txtNv_kd).MaxLength = 20;
		((Control)txtNv_kd).Name = "txtNv_kd";
		txtNv_kd.NameControl = lblTen_nv_kd;
		AsTextBox asTextBox3 = txtNv_kd;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtNv_kd).TabIndex = 23;
		txtNv_kd.UseAutoCompleteSource = true;
		((Control)txtNv_kd).Visible = false;
		((ButtonBase)chkNh_Ncc).AutoSize = true;
		chkNh_Ncc.Checked = false;
		AsCheckBox asCheckBox = chkNh_Ncc;
		location = new Point(681, 731);
		((Control)asCheckBox).Location = location;
		((Control)chkNh_Ncc).Name = "chkNh_Ncc";
		AsCheckBox asCheckBox2 = chkNh_Ncc;
		size = new Size(94, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkNh_Ncc).TabIndex = 17;
		((ButtonBase)chkNh_Ncc).Text = "Nhà cung cấp";
		chkNh_Ncc.TextValue = "0";
		((ButtonBase)chkNh_Ncc).UseVisualStyleBackColor = true;
		((Control)chkNh_Ncc).Visible = false;
		lblNh_theo.AutoSize = true;
		Label obj34 = lblNh_theo;
		location = new Point(616, 732);
		((Control)obj34).Location = location;
		((Control)lblNh_theo).Name = "lblNh_theo";
		Label obj35 = lblNh_theo;
		size = new Size(59, 13);
		((Control)obj35).Size = size;
		((Control)lblNh_theo).TabIndex = 1124;
		lblNh_theo.Text = "Nhóm theo";
		((Control)lblNh_theo).Visible = false;
		((ComboBox)cboLoaiPhieu).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoaiPhieu).FormattingEnabled = true;
		((ComboBox)cboLoaiPhieu).Items.AddRange(new object[1] { "Tất cả" });
		AsComboBox asComboBox = cboLoaiPhieu;
		location = new Point(161, 116);
		((Control)asComboBox).Location = location;
		((Control)cboLoaiPhieu).Name = "cboLoaiPhieu";
		AsComboBox asComboBox2 = cboLoaiPhieu;
		size = new Size(183, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboLoaiPhieu).TabIndex = 7;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(25, 119);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(56, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1128;
		Label1.Text = "Loại phiếu";
		lblTrang_Thai.AutoSize = true;
		((Control)lblTrang_Thai).Enabled = false;
		Label obj36 = lblTrang_Thai;
		location = new Point(350, 119);
		((Control)obj36).Location = location;
		((Control)lblTrang_Thai).Name = "lblTrang_Thai";
		Label obj37 = lblTrang_Thai;
		size = new Size(55, 13);
		((Control)obj37).Size = size;
		((Control)lblTrang_Thai).TabIndex = 1127;
		lblTrang_Thai.Text = "Trạng thái";
		((Control)lblTrang_Thai).Visible = false;
		((ComboBox)cboTrang_Thai).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboTrang_Thai).Enabled = false;
		((ListControl)cboTrang_Thai).FormattingEnabled = true;
		((ComboBox)cboTrang_Thai).Items.AddRange(new object[1] { "Tất cả" });
		AsComboBox asComboBox3 = cboTrang_Thai;
		location = new Point(417, 116);
		((Control)asComboBox3).Location = location;
		((Control)cboTrang_Thai).Name = "cboTrang_Thai";
		AsComboBox asComboBox4 = cboTrang_Thai;
		size = new Size(164, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboTrang_Thai).TabIndex = 8;
		((Control)cboTrang_Thai).Visible = false;
		Label obj38 = lblTen_bp;
		location = new Point(609, 686);
		((Control)obj38).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj39 = lblTen_bp;
		size = new Size(339, 13);
		((Control)obj39).Size = size;
		((Control)lblTen_bp).TabIndex = 1145;
		((Control)lblTen_bp).Visible = false;
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_bp;
		location = new Point(513, 679);
		((Control)asTextBox4).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox5 = txtMa_bp;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_bp).TabIndex = 22;
		((Control)txtMa_bp).Tag = "MA_BP";
		txtMa_bp.UseAutoCompleteSource = true;
		((Control)txtMa_bp).Visible = false;
		lblMa_bp.AutoSize = true;
		Label obj40 = lblMa_bp;
		location = new Point(423, 682);
		((Control)obj40).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj41 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj41).Size = size;
		((Control)lblMa_bp).TabIndex = 1146;
		lblMa_bp.Text = "Mã bộ phận";
		((Control)lblMa_bp).Visible = false;
		txtMa_nhhd.AutoLookup = true;
		txtMa_nhhd.AutoValid = false;
		((TextBoxBase)txtMa_nhhd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhhd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_nhhd;
		location = new Point(161, 261);
		((Control)asTextBox6).Location = location;
		txtMa_nhhd.LookupCodeName = "MA_NHHD";
		((Control)txtMa_nhhd).Name = "txtMa_nhhd";
		txtMa_nhhd.NameControl = lblTen_Nhhd;
		AsTextBox asTextBox7 = txtMa_nhhd;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_nhhd).TabIndex = 14;
		((Control)txtMa_nhhd).Tag = "MA_NHHD";
		txtMa_nhhd.UseAutoCompleteSource = true;
		Label obj42 = lblTen_Nhhd;
		location = new Point(254, 265);
		((Control)obj42).Location = location;
		((Control)lblTen_Nhhd).Name = "lblTen_Nhhd";
		Label obj43 = lblTen_Nhhd;
		size = new Size(515, 13);
		((Control)obj43).Size = size;
		((Control)lblTen_Nhhd).TabIndex = 1221;
		lblMa_nhhd.AutoSize = true;
		Label obj44 = lblMa_nhhd;
		location = new Point(25, 265);
		((Control)obj44).Location = location;
		((Control)lblMa_nhhd).Name = "lblMa_nhhd";
		Label obj45 = lblMa_nhhd;
		size = new Size(84, 13);
		((Control)obj45).Size = size;
		((Control)lblMa_nhhd).TabIndex = 1222;
		lblMa_nhhd.Text = "Nhóm hợp đồng";
		lblTen_hd.ImeMode = (ImeMode)0;
		Label obj46 = lblTen_hd;
		location = new Point(254, 241);
		((Control)obj46).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj47 = lblTen_hd;
		size = new Size(515, 13);
		((Control)obj47).Size = size;
		((Control)lblTen_hd).TabIndex = 1220;
		lblTen_hd.TextAlign = (ContentAlignment)16;
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_hd;
		location = new Point(161, 237);
		((Control)asTextBox8).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((TextBoxBase)txtMa_hd).MaxLength = 20;
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox9 = txtMa_hd;
		size = new Size(90, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_hd).TabIndex = 13;
		txtMa_hd.UseAutoCompleteSource = true;
		lblMa_hd.AutoSize = true;
		Label obj48 = lblMa_hd;
		location = new Point(25, 241);
		((Control)obj48).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj49 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj49).Size = size;
		((Control)lblMa_hd).TabIndex = 1219;
		lblMa_hd.Text = "Mã hợp đồng";
		((Control)lblTen_TT).Enabled = false;
		Label obj50 = lblTen_TT;
		location = new Point(774, 110);
		((Control)obj50).Location = location;
		((Control)lblTen_TT).Name = "lblTen_TT";
		Label obj51 = lblTen_TT;
		size = new Size(82, 13);
		((Control)obj51).Size = size;
		((Control)lblTen_TT).TabIndex = 1209;
		((Control)lblTen_TT).Visible = false;
		txtMA_DKTT.AutoLookup = true;
		txtMA_DKTT.AutoValid = false;
		((TextBoxBase)txtMA_DKTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_DKTT).CharacterCasing = (CharacterCasing)1;
		((Control)txtMA_DKTT).Enabled = false;
		AsTextBox asTextBox10 = txtMA_DKTT;
		location = new Point(679, 106);
		((Control)asTextBox10).Location = location;
		txtMA_DKTT.LookupCodeName = "MA_TT_PO";
		((Control)txtMA_DKTT).Name = "txtMA_DKTT";
		txtMA_DKTT.NameControl = lblTen_TT;
		AsTextBox asTextBox11 = txtMA_DKTT;
		size = new Size(90, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMA_DKTT).TabIndex = 10;
		((Control)txtMA_DKTT).Tag = "MA_TT";
		txtMA_DKTT.UseAutoCompleteSource = true;
		((Control)txtMA_DKTT).Visible = false;
		lblDkTT.AutoSize = true;
		((Control)lblDkTT).Enabled = false;
		Label obj52 = lblDkTT;
		location = new Point(588, 110);
		((Control)obj52).Location = location;
		((Control)lblDkTT).Name = "lblDkTT";
		Label obj53 = lblDkTT;
		size = new Size(79, 13);
		((Control)obj53).Size = size;
		((Control)lblDkTT).TabIndex = 1210;
		lblDkTT.Text = "Điều khoản TT";
		((Control)lblDkTT).Visible = false;
		Label obj54 = lblTenHTTT;
		location = new Point(254, 289);
		((Control)obj54).Location = location;
		((Control)lblTenHTTT).Name = "lblTenHTTT";
		Label obj55 = lblTenHTTT;
		size = new Size(515, 13);
		((Control)obj55).Size = size;
		((Control)lblTenHTTT).TabIndex = 1207;
		txtMA_HTTT.AutoLookup = true;
		txtMA_HTTT.AutoValid = false;
		((TextBoxBase)txtMA_HTTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_HTTT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMA_HTTT;
		location = new Point(161, 285);
		((Control)asTextBox12).Location = location;
		txtMA_HTTT.LookupCodeName = "MA_HTTT";
		txtMA_HTTT.LookupWhereCondition = "moduleid='po'";
		((Control)txtMA_HTTT).Name = "txtMA_HTTT";
		txtMA_HTTT.NameControl = lblTenHTTT;
		AsTextBox asTextBox13 = txtMA_HTTT;
		size = new Size(90, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMA_HTTT).TabIndex = 15;
		((Control)txtMA_HTTT).Tag = "MA_HTTT";
		txtMA_HTTT.UseAutoCompleteSource = true;
		lblHTTT.AutoSize = true;
		Label obj56 = lblHTTT;
		location = new Point(25, 289);
		((Control)obj56).Location = location;
		((Control)lblHTTT).Name = "lblHTTT";
		Label obj57 = lblHTTT;
		size = new Size(70, 13);
		((Control)obj57).Size = size;
		((Control)lblHTTT).TabIndex = 1208;
		lblHTTT.Text = "Hình thức TT";
		lblTen_nh_vt.ImeMode = (ImeMode)0;
		Label obj58 = lblTen_nh_vt;
		location = new Point(254, 433);
		((Control)obj58).Location = location;
		((Control)lblTen_nh_vt).Name = "lblTen_nh_vt";
		Label obj59 = lblTen_nh_vt;
		size = new Size(515, 13);
		((Control)obj59).Size = size;
		((Control)lblTen_nh_vt).TabIndex = 1200;
		lblTen_nh_vt.TextAlign = (ContentAlignment)16;
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj60 = lblTen_vt;
		location = new Point(254, 409);
		((Control)obj60).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj61 = lblTen_vt;
		size = new Size(515, 13);
		((Control)obj61).Size = size;
		((Control)lblTen_vt).TabIndex = 1199;
		lblTen_vt.TextAlign = (ContentAlignment)16;
		txtMa_nh_vt.AutoLookup = true;
		txtMa_nh_vt.AutoValid = false;
		((TextBoxBase)txtMa_nh_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nh_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_nh_vt;
		location = new Point(161, 429);
		((Control)asTextBox14).Location = location;
		txtMa_nh_vt.LookupCodeName = "MA_NHVT";
		((TextBoxBase)txtMa_nh_vt).MaxLength = 20;
		((Control)txtMa_nh_vt).Name = "txtMa_nh_vt";
		txtMa_nh_vt.NameControl = lblTen_nh_vt;
		AsTextBox asTextBox15 = txtMa_nh_vt;
		size = new Size(90, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_nh_vt).TabIndex = 21;
		txtMa_nh_vt.UseAutoCompleteSource = true;
		lblMa_nh_vt.AutoSize = true;
		Label obj62 = lblMa_nh_vt;
		location = new Point(25, 433);
		((Control)obj62).Location = location;
		((Control)lblMa_nh_vt).Name = "lblMa_nh_vt";
		Label obj63 = lblMa_nh_vt;
		size = new Size(81, 13);
		((Control)obj63).Size = size;
		((Control)lblMa_nh_vt).TabIndex = 1198;
		lblMa_nh_vt.Text = "Mã nhóm vật tư";
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox16 = txtMa_vt;
		location = new Point(161, 405);
		((Control)asTextBox16).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((TextBoxBase)txtMa_vt).MaxLength = 20;
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox17 = txtMa_vt;
		size = new Size(90, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtMa_vt).TabIndex = 20;
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_vt.AutoSize = true;
		Label obj64 = lblMa_vt;
		location = new Point(25, 409);
		((Control)obj64).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj65 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj65).Size = size;
		((Control)lblMa_vt).TabIndex = 1197;
		lblMa_vt.Text = "Mã vật tư";
		Label obj66 = lblTen_lo;
		location = new Point(254, 337);
		((Control)obj66).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj67 = lblTen_lo;
		size = new Size(515, 13);
		((Control)obj67).Size = size;
		((Control)lblTen_lo).TabIndex = 1205;
		((Control)lblTen_nh_ncc).Enabled = false;
		lblTen_nh_ncc.ImeMode = (ImeMode)0;
		Label obj68 = lblTen_nh_ncc;
		location = new Point(775, 136);
		((Control)obj68).Location = location;
		((Control)lblTen_nh_ncc).Name = "lblTen_nh_ncc";
		Label obj69 = lblTen_nh_ncc;
		size = new Size(82, 13);
		((Control)obj69).Size = size;
		((Control)lblTen_nh_ncc).TabIndex = 1193;
		lblTen_nh_ncc.TextAlign = (ContentAlignment)16;
		((Control)lblTen_nh_ncc).Visible = false;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox18 = txtMa_kho;
		location = new Point(161, 309);
		((Control)asTextBox18).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((TextBoxBase)txtMa_kho).MaxLength = 20;
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox19 = txtMa_kho;
		size = new Size(90, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtMa_kho).TabIndex = 16;
		txtMa_kho.UseAutoCompleteSource = true;
		lblTen_kho.ImeMode = (ImeMode)0;
		Label obj70 = lblTen_kho;
		location = new Point(254, 313);
		((Control)obj70).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj71 = lblTen_kho;
		size = new Size(515, 13);
		((Control)obj71).Size = size;
		((Control)lblTen_kho).TabIndex = 1203;
		lblTen_kho.TextAlign = (ContentAlignment)16;
		txtMaLo.AutoLookup = true;
		txtMaLo.AutoValid = false;
		((TextBoxBase)txtMaLo).BackColor = SystemColors.Info;
		((TextBox)txtMaLo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtMaLo;
		location = new Point(161, 333);
		((Control)asTextBox20).Location = location;
		txtMaLo.LookupCodeName = "MA_LO";
		((Control)txtMaLo).Name = "txtMaLo";
		txtMaLo.NameControl = lblTen_lo;
		AsTextBox asTextBox21 = txtMaLo;
		size = new Size(90, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMaLo).TabIndex = 17;
		((Control)txtMaLo).Tag = "MA_LO";
		txtMaLo.UseAutoCompleteSource = true;
		lblTen_ncc.ImeMode = (ImeMode)0;
		Label obj72 = lblTen_ncc;
		location = new Point(254, 145);
		((Control)obj72).Location = location;
		((Control)lblTen_ncc).Name = "lblTen_ncc";
		Label obj73 = lblTen_ncc;
		size = new Size(515, 13);
		((Control)obj73).Size = size;
		((Control)lblTen_ncc).TabIndex = 1192;
		lblTen_ncc.TextAlign = (ContentAlignment)16;
		lblMa_kho.AutoSize = true;
		Label obj74 = lblMa_kho;
		location = new Point(25, 313);
		((Control)obj74).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj75 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj75).Size = size;
		((Control)lblMa_kho).TabIndex = 1201;
		lblMa_kho.Text = "Mã kho";
		txtMa_nh_ncc.AutoLookup = true;
		txtMa_nh_ncc.AutoValid = false;
		((TextBoxBase)txtMa_nh_ncc).BackColor = SystemColors.Info;
		((TextBox)txtMa_nh_ncc).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_nh_ncc).Enabled = false;
		AsTextBox asTextBox22 = txtMa_nh_ncc;
		location = new Point(679, 132);
		((Control)asTextBox22).Location = location;
		txtMa_nh_ncc.LookupCodeName = "MA_NHKH";
		((TextBoxBase)txtMa_nh_ncc).MaxLength = 20;
		((Control)txtMa_nh_ncc).Name = "txtMa_nh_ncc";
		txtMa_nh_ncc.NameControl = lblTen_nh_ncc;
		AsTextBox asTextBox23 = txtMa_nh_ncc;
		size = new Size(90, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMa_nh_ncc).TabIndex = 1;
		txtMa_nh_ncc.UseAutoCompleteSource = true;
		((Control)txtMa_nh_ncc).Visible = false;
		lblMaLo.AutoSize = true;
		Label obj76 = lblMaLo;
		location = new Point(25, 337);
		((Control)obj76).Location = location;
		((Control)lblMaLo).Name = "lblMaLo";
		Label obj77 = lblMaLo;
		size = new Size(33, 13);
		((Control)obj77).Size = size;
		((Control)lblMaLo).TabIndex = 1206;
		lblMaLo.Text = "Mã lô";
		lblMa_nh_ncc.AutoSize = true;
		((Control)lblMa_nh_ncc).Enabled = false;
		Label obj78 = lblMa_nh_ncc;
		location = new Point(589, 136);
		((Control)obj78).Location = location;
		((Control)lblMa_nh_ncc).Name = "lblMa_nh_ncc";
		Label obj79 = lblMa_nh_ncc;
		size = new Size(76, 13);
		((Control)obj79).Size = size;
		((Control)lblMa_nh_ncc).TabIndex = 1188;
		lblMa_nh_ncc.Text = "Mã nhóm NCC";
		((Control)lblMa_nh_ncc).Visible = false;
		lblMa_vitri.AutoSize = true;
		((Control)lblMa_vitri).Enabled = false;
		Label obj80 = lblMa_vitri;
		location = new Point(589, 84);
		((Control)obj80).Location = location;
		((Control)lblMa_vitri).Name = "lblMa_vitri";
		Label obj81 = lblMa_vitri;
		size = new Size(46, 13);
		((Control)obj81).Size = size;
		((Control)lblMa_vitri).TabIndex = 1202;
		lblMa_vitri.Text = "Mã vị trí";
		((Control)lblMa_vitri).Visible = false;
		((TextBox)txtMa_ncc).AutoCompleteMode = (AutoCompleteMode)2;
		txtMa_ncc.AutoLookup = true;
		txtMa_ncc.AutoValid = false;
		((TextBoxBase)txtMa_ncc).BackColor = SystemColors.Info;
		((TextBox)txtMa_ncc).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox24 = txtMa_ncc;
		location = new Point(161, 141);
		((Control)asTextBox24).Location = location;
		txtMa_ncc.LookupCodeName = "MA_NCC";
		txtMa_ncc.LookupWhereCondition = "isNcc=1";
		((TextBoxBase)txtMa_ncc).MaxLength = 20;
		((Control)txtMa_ncc).Name = "txtMa_ncc";
		txtMa_ncc.NameControl = lblTen_ncc;
		AsTextBox asTextBox25 = txtMa_ncc;
		size = new Size(90, 20);
		((Control)asTextBox25).Size = size;
		((Control)txtMa_ncc).TabIndex = 9;
		txtMa_ncc.UseAutoCompleteSource = true;
		((Control)lblTen_vitri).Enabled = false;
		lblTen_vitri.ImeMode = (ImeMode)0;
		Label obj82 = lblTen_vitri;
		location = new Point(775, 84);
		((Control)obj82).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj83 = lblTen_vitri;
		size = new Size(82, 13);
		((Control)obj83).Size = size;
		((Control)lblTen_vitri).TabIndex = 1204;
		lblTen_vitri.TextAlign = (ContentAlignment)16;
		((Control)lblTen_vitri).Visible = false;
		lblMa_ncc.AutoSize = true;
		Label obj84 = lblMa_ncc;
		location = new Point(25, 145);
		((Control)obj84).Location = location;
		((Control)lblMa_ncc).Name = "lblMa_ncc";
		Label obj85 = lblMa_ncc;
		size = new Size(47, 13);
		((Control)obj85).Size = size;
		((Control)lblMa_ncc).TabIndex = 1187;
		lblMa_ncc.Text = "Mã NCC";
		txtMa_vtri.AutoLookup = true;
		txtMa_vtri.AutoValid = false;
		((TextBoxBase)txtMa_vtri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vtri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vtri).Enabled = false;
		AsTextBox asTextBox26 = txtMa_vtri;
		location = new Point(679, 80);
		((Control)asTextBox26).Location = location;
		txtMa_vtri.LookupCodeName = "MA_VITRI";
		((TextBoxBase)txtMa_vtri).MaxLength = 20;
		((Control)txtMa_vtri).Name = "txtMa_vtri";
		txtMa_vtri.NameControl = lblTen_vitri;
		AsTextBox asTextBox27 = txtMa_vtri;
		size = new Size(90, 20);
		((Control)asTextBox27).Size = size;
		((Control)txtMa_vtri).TabIndex = 7;
		txtMa_vtri.UseAutoCompleteSource = true;
		((Control)txtMa_vtri).Visible = false;
		Label obj86 = lblTenPhi;
		location = new Point(254, 361);
		((Control)obj86).Location = location;
		((Control)lblTenPhi).Name = "lblTenPhi";
		Label obj87 = lblTenPhi;
		size = new Size(515, 13);
		((Control)obj87).Size = size;
		((Control)lblTenPhi).TabIndex = 1223;
		((TextBox)txtPl_ncc1).AutoCompleteMode = (AutoCompleteMode)1;
		txtPl_ncc1.AutoLookup = true;
		txtPl_ncc1.AutoValid = false;
		((TextBoxBase)txtPl_ncc1).BackColor = SystemColors.Info;
		((TextBox)txtPl_ncc1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox28 = txtPl_ncc1;
		location = new Point(161, 165);
		((Control)asTextBox28).Location = location;
		txtPl_ncc1.LookupCodeName = "MA_PLKH";
		txtPl_ncc1.LookupWhereCondition = "loai = 1";
		((TextBoxBase)txtPl_ncc1).MaxLength = 20;
		((Control)txtPl_ncc1).Name = "txtPl_ncc1";
		txtPl_ncc1.NameControl = lblTen_pl_ncc1;
		AsTextBox asTextBox29 = txtPl_ncc1;
		size = new Size(90, 20);
		((Control)asTextBox29).Size = size;
		((Control)txtPl_ncc1).TabIndex = 10;
		txtPl_ncc1.UseAutoCompleteSource = true;
		lblTen_pl_ncc1.ImeMode = (ImeMode)0;
		Label obj88 = lblTen_pl_ncc1;
		location = new Point(254, 169);
		((Control)obj88).Location = location;
		((Control)lblTen_pl_ncc1).Name = "lblTen_pl_ncc1";
		Label obj89 = lblTen_pl_ncc1;
		size = new Size(515, 13);
		((Control)obj89).Size = size;
		((Control)lblTen_pl_ncc1).TabIndex = 1194;
		lblTen_pl_ncc1.TextAlign = (ContentAlignment)16;
		txtMaPhi.AutoLookup = true;
		txtMaPhi.AutoValid = false;
		((TextBoxBase)txtMaPhi).BackColor = SystemColors.Info;
		((TextBox)txtMaPhi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox30 = txtMaPhi;
		location = new Point(161, 357);
		((Control)asTextBox30).Location = location;
		txtMaPhi.LookupCodeName = "MA_PHI";
		((Control)txtMaPhi).Name = "txtMaPhi";
		txtMaPhi.NameControl = lblTenPhi;
		AsTextBox asTextBox31 = txtMaPhi;
		size = new Size(90, 20);
		((Control)asTextBox31).Size = size;
		((Control)txtMaPhi).TabIndex = 18;
		((Control)txtMaPhi).Tag = "MA_PHI";
		txtMaPhi.UseAutoCompleteSource = true;
		lblPl_ncc1.AutoSize = true;
		Label obj90 = lblPl_ncc1;
		location = new Point(25, 169);
		((Control)obj90).Location = location;
		((Control)lblPl_ncc1).Name = "lblPl_ncc1";
		Label obj91 = lblPl_ncc1;
		size = new Size(64, 13);
		((Control)obj91).Size = size;
		((Control)lblPl_ncc1).TabIndex = 1189;
		lblPl_ncc1.Text = "P loại NCC1";
		lblPl_ncc2.AutoSize = true;
		Label obj92 = lblPl_ncc2;
		location = new Point(25, 193);
		((Control)obj92).Location = location;
		((Control)lblPl_ncc2).Name = "lblPl_ncc2";
		Label obj93 = lblPl_ncc2;
		size = new Size(64, 13);
		((Control)obj93).Size = size;
		((Control)lblPl_ncc2).TabIndex = 1190;
		lblPl_ncc2.Text = "P loại NCC2";
		txtPl_ncc2.AutoLookup = true;
		txtPl_ncc2.AutoValid = false;
		((TextBoxBase)txtPl_ncc2).BackColor = SystemColors.Info;
		((TextBox)txtPl_ncc2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox32 = txtPl_ncc2;
		location = new Point(161, 189);
		((Control)asTextBox32).Location = location;
		txtPl_ncc2.LookupCodeName = "MA_PLKH";
		txtPl_ncc2.LookupWhereCondition = "loai = 2";
		((TextBoxBase)txtPl_ncc2).MaxLength = 20;
		((Control)txtPl_ncc2).Name = "txtPl_ncc2";
		txtPl_ncc2.NameControl = lblTen_pl_ncc2;
		AsTextBox asTextBox33 = txtPl_ncc2;
		size = new Size(90, 20);
		((Control)asTextBox33).Size = size;
		((Control)txtPl_ncc2).TabIndex = 11;
		txtPl_ncc2.UseAutoCompleteSource = true;
		lblTen_pl_ncc2.ImeMode = (ImeMode)0;
		Label obj94 = lblTen_pl_ncc2;
		location = new Point(254, 193);
		((Control)obj94).Location = location;
		((Control)lblTen_pl_ncc2).Name = "lblTen_pl_ncc2";
		Label obj95 = lblTen_pl_ncc2;
		size = new Size(515, 13);
		((Control)obj95).Size = size;
		((Control)lblTen_pl_ncc2).TabIndex = 1195;
		lblTen_pl_ncc2.TextAlign = (ContentAlignment)16;
		lblPl_ncc3.AutoSize = true;
		Label obj96 = lblPl_ncc3;
		location = new Point(25, 217);
		((Control)obj96).Location = location;
		((Control)lblPl_ncc3).Name = "lblPl_ncc3";
		Label obj97 = lblPl_ncc3;
		size = new Size(64, 13);
		((Control)obj97).Size = size;
		((Control)lblPl_ncc3).TabIndex = 1191;
		lblPl_ncc3.Text = "P loại NCC3";
		txtPl_ncc3.AutoLookup = true;
		txtPl_ncc3.AutoValid = false;
		((TextBoxBase)txtPl_ncc3).BackColor = SystemColors.Info;
		((TextBox)txtPl_ncc3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox34 = txtPl_ncc3;
		location = new Point(161, 213);
		((Control)asTextBox34).Location = location;
		txtPl_ncc3.LookupCodeName = "MA_PLKH";
		txtPl_ncc3.LookupWhereCondition = "loai = 3";
		((TextBoxBase)txtPl_ncc3).MaxLength = 20;
		((Control)txtPl_ncc3).Name = "txtPl_ncc3";
		txtPl_ncc3.NameControl = lblTen_pl_ncc3;
		AsTextBox asTextBox35 = txtPl_ncc3;
		size = new Size(90, 20);
		((Control)asTextBox35).Size = size;
		((Control)txtPl_ncc3).TabIndex = 12;
		txtPl_ncc3.UseAutoCompleteSource = true;
		lblTen_pl_ncc3.ImeMode = (ImeMode)0;
		Label obj98 = lblTen_pl_ncc3;
		location = new Point(254, 217);
		((Control)obj98).Location = location;
		((Control)lblTen_pl_ncc3).Name = "lblTen_pl_ncc3";
		Label obj99 = lblTen_pl_ncc3;
		size = new Size(515, 13);
		((Control)obj99).Size = size;
		((Control)lblTen_pl_ncc3).TabIndex = 1196;
		lblTen_pl_ncc3.TextAlign = (ContentAlignment)16;
		Label obj100 = lblTen_spct;
		location = new Point(254, 385);
		((Control)obj100).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj101 = lblTen_spct;
		size = new Size(515, 13);
		((Control)obj101).Size = size;
		((Control)lblTen_spct).TabIndex = 1211;
		((Control)lblTen_plvt3).Enabled = false;
		Label obj102 = lblTen_plvt3;
		location = new Point(774, 59);
		((Control)obj102).Location = location;
		((Control)lblTen_plvt3).Name = "lblTen_plvt3";
		Label obj103 = lblTen_plvt3;
		size = new Size(82, 13);
		((Control)obj103).Size = size;
		((Control)lblTen_plvt3).TabIndex = 1215;
		((Control)lblTen_plvt3).Visible = false;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox36 = txtMa_spct;
		location = new Point(161, 381);
		((Control)asTextBox36).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox37 = txtMa_spct;
		size = new Size(90, 20);
		((Control)asTextBox37).Size = size;
		((Control)txtMa_spct).TabIndex = 19;
		((Control)txtMa_spct).Tag = "MA_SPCT";
		txtMa_spct.UseAutoCompleteSource = true;
		lblMa_spct.AutoSize = true;
		Label obj104 = lblMa_spct;
		location = new Point(25, 385);
		((Control)obj104).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj105 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj105).Size = size;
		((Control)lblMa_spct).TabIndex = 1212;
		lblMa_spct.Text = "Mã SPCT";
		txtMa_Plvt1.AutoLookup = true;
		txtMa_Plvt1.AutoValid = false;
		((TextBoxBase)txtMa_Plvt1).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plvt1).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_Plvt1).Enabled = false;
		AsTextBox asTextBox38 = txtMa_Plvt1;
		location = new Point(679, 6);
		((Control)asTextBox38).Location = location;
		txtMa_Plvt1.LookupCodeName = "MA_PLVT";
		txtMa_Plvt1.LookupWhereCondition = "loai='1'";
		((Control)txtMa_Plvt1).Name = "txtMa_Plvt1";
		txtMa_Plvt1.NameControl = lblTen_plvt1;
		AsTextBox asTextBox39 = txtMa_Plvt1;
		size = new Size(90, 20);
		((Control)asTextBox39).Size = size;
		((Control)txtMa_Plvt1).TabIndex = 3;
		((Control)txtMa_Plvt1).Tag = "MA_PLVT";
		txtMa_Plvt1.UseAutoCompleteSource = true;
		((Control)txtMa_Plvt1).Visible = false;
		((Control)lblTen_plvt1).Enabled = false;
		Label obj106 = lblTen_plvt1;
		location = new Point(774, 7);
		((Control)obj106).Location = location;
		((Control)lblTen_plvt1).Name = "lblTen_plvt1";
		Label obj107 = lblTen_plvt1;
		size = new Size(82, 13);
		((Control)obj107).Size = size;
		((Control)lblTen_plvt1).TabIndex = 1213;
		((Control)lblTen_plvt1).Visible = false;
		((Control)lblTen_plvt2).Enabled = false;
		Label obj108 = lblTen_plvt2;
		location = new Point(774, 33);
		((Control)obj108).Location = location;
		((Control)lblTen_plvt2).Name = "lblTen_plvt2";
		Label obj109 = lblTen_plvt2;
		size = new Size(82, 13);
		((Control)obj109).Size = size;
		((Control)lblTen_plvt2).TabIndex = 1214;
		((Control)lblTen_plvt2).Visible = false;
		lblPlvt3.AutoSize = true;
		((Control)lblPlvt3).Enabled = false;
		Label obj110 = lblPlvt3;
		location = new Point(589, 59);
		((Control)obj110).Location = location;
		((Control)lblPlvt3).Name = "lblPlvt3";
		Label obj111 = lblPlvt3;
		size = new Size(56, 13);
		((Control)obj111).Size = size;
		((Control)lblPlvt3).TabIndex = 1216;
		lblPlvt3.Text = "P.loại VT3";
		((Control)lblPlvt3).Visible = false;
		txtMa_plvt3.AutoLookup = true;
		txtMa_plvt3.AutoValid = false;
		((TextBoxBase)txtMa_plvt3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt3).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt3).Enabled = false;
		AsTextBox asTextBox40 = txtMa_plvt3;
		location = new Point(679, 55);
		((Control)asTextBox40).Location = location;
		txtMa_plvt3.LookupCodeName = "MA_PLVT";
		txtMa_plvt3.LookupWhereCondition = "loai='3'";
		((Control)txtMa_plvt3).Name = "txtMa_plvt3";
		txtMa_plvt3.NameControl = lblTen_plvt3;
		AsTextBox asTextBox41 = txtMa_plvt3;
		size = new Size(90, 20);
		((Control)asTextBox41).Size = size;
		((Control)txtMa_plvt3).TabIndex = 5;
		((Control)txtMa_plvt3).Tag = "MA_PLVT";
		txtMa_plvt3.UseAutoCompleteSource = true;
		((Control)txtMa_plvt3).Visible = false;
		lblPlvt2.AutoSize = true;
		((Control)lblPlvt2).Enabled = false;
		Label obj112 = lblPlvt2;
		location = new Point(589, 33);
		((Control)obj112).Location = location;
		((Control)lblPlvt2).Name = "lblPlvt2";
		Label obj113 = lblPlvt2;
		size = new Size(56, 13);
		((Control)obj113).Size = size;
		((Control)lblPlvt2).TabIndex = 1217;
		lblPlvt2.Text = "P.loại VT2";
		((Control)lblPlvt2).Visible = false;
		lblPlvt1.AutoSize = true;
		((Control)lblPlvt1).Enabled = false;
		Label obj114 = lblPlvt1;
		location = new Point(589, 7);
		((Control)obj114).Location = location;
		((Control)lblPlvt1).Name = "lblPlvt1";
		Label obj115 = lblPlvt1;
		size = new Size(56, 13);
		((Control)obj115).Size = size;
		((Control)lblPlvt1).TabIndex = 1218;
		lblPlvt1.Text = "P.loại VT1";
		((Control)lblPlvt1).Visible = false;
		txtMa_Plvt2.AutoLookup = true;
		txtMa_Plvt2.AutoValid = false;
		((TextBoxBase)txtMa_Plvt2).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plvt2).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_Plvt2).Enabled = false;
		AsTextBox asTextBox42 = txtMa_Plvt2;
		location = new Point(679, 29);
		((Control)asTextBox42).Location = location;
		txtMa_Plvt2.LookupCodeName = "MA_PLVT";
		txtMa_Plvt2.LookupWhereCondition = "loai='2'";
		((Control)txtMa_Plvt2).Name = "txtMa_Plvt2";
		txtMa_Plvt2.NameControl = lblTen_plvt2;
		AsTextBox asTextBox43 = txtMa_Plvt2;
		size = new Size(90, 20);
		((Control)asTextBox43).Size = size;
		((Control)txtMa_Plvt2).TabIndex = 4;
		((Control)txtMa_Plvt2).Tag = "MA_PLVT";
		txtMa_Plvt2.UseAutoCompleteSource = true;
		((Control)txtMa_Plvt2).Visible = false;
		Label8.AutoSize = true;
		Label label3 = Label8;
		location = new Point(25, 361);
		((Control)label3).Location = location;
		((Control)Label8).Name = "Label8";
		Label label4 = Label8;
		size = new Size(41, 13);
		((Control)label4).Size = size;
		((Control)Label8).TabIndex = 1224;
		Label8.Text = "Mã phí";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(1006, 580);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmPORptBK01";
		((Form)this).Text = "frmPORptBK01";
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
		arrayList.Add("");
		arrayList.Add(txtCT1.Text);
		arrayList.Add(txtCT2.Text);
		arrayList.Add(((TextBox)txtMa_ncc).Text);
		arrayList.Add(((TextBox)txtMa_nh_ncc).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_nh_vt).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_vtri).Text);
		arrayList.Add(((TextBox)txtNv_kd).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtPl_ncc1).Text);
		arrayList.Add(((TextBox)txtPl_ncc2).Text);
		arrayList.Add(((TextBox)txtPl_ncc3).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoaiPhieu).SelectedValue));
		arrayList.Add(((TextBox)txtMaLo).Text);
		arrayList.Add(((TextBox)txtMA_HTTT).Text);
		arrayList.Add(((TextBox)txtMA_DKTT).Text);
		arrayList.Add(((TextBox)txtMa_bp).Text);
		arrayList.Add(((TextBox)txtMa_spct).Text);
		arrayList.Add(((TextBox)txtMa_Plvt1).Text);
		arrayList.Add(((TextBox)txtMa_Plvt2).Text);
		arrayList.Add(((TextBox)txtMa_plvt3).Text);
		arrayList.Add(((TextBox)txtMa_nhhd).Text);
		arrayList.Add(((TextBox)txtMaPhi).Text);
		DataSet dataSet = base.MyController.GetDataSet(arrayList.ToArray());
		set_MyDGVPhSource(isSet2Print: true, dataSet.Tables[1]);
		set_MyDGVCtSource(isSet2Print: true, dataSet.Tables[0]);
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		base.MyFomularFields.Add("groupType", "1");
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(((ListControl)cboLoaiPhieu).SelectedValue.ToString(), "", false) != 0)
		{
			text = text + "Loại Phiếu:" + ((ListControl)cboLoaiPhieu).SelectedValue.ToString() + "; ";
		}
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
		if (((ComboBox)cboTrang_Thai).SelectedIndex > -1)
		{
			text = text + lblTrang_Thai.Text + ": " + ((ComboBox)cboTrang_Thai).Text + "; ";
		}
		if (Operators.CompareString(txtCT1.Text, "", false) != 0)
		{
			text = text + lblSo_ct1.Text + ": " + txtCT1.Text + "; ";
		}
		if (Operators.CompareString(txtCT2.Text, "", false) != 0)
		{
			text = text + lblct2.Text + ": " + txtCT2.Text + ";";
		}
		if (Operators.CompareString(((TextBox)txtMa_ncc).Text, "", false) != 0)
		{
			text = text + lblMa_ncc.Text + ": " + ((TextBox)txtMa_ncc).Text + "; ";
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
			text = text + lblPl_ncc2.Text + " : " + ((TextBox)txtPl_ncc2).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtPl_ncc3).Text, "", false) != 0)
		{
			text = text + lblPl_ncc3.Text + ": " + ((TextBox)txtPl_ncc3).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
		{
			text = text + lblMa_vt.Text + ": " + ((TextBox)txtMa_vt).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nh_vt).Text, "", false) != 0)
		{
			text = text + lblMa_nh_vt.Text + ": " + ((TextBox)txtMa_nh_vt).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plvt1).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlvt1.Text + ":" + ((TextBox)txtMa_Plvt1).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plvt2).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlvt2.Text + ":" + ((TextBox)txtMa_Plvt2).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt3).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlvt3.Text + ":" + ((TextBox)txtMa_plvt3).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text, "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": " + ((TextBox)txtMa_kho).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtNv_kd).Text, "", false) != 0)
		{
			text = text + lblNv_kd.Text + ": " + ((TextBox)txtNv_kd).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_bp).Text, "", false) != 0)
		{
			text = text + lblTen_bp.Text + ": " + ((TextBox)txtMa_bp).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_hd).Text, "", false) != 0)
		{
			text = text + lblMa_hd.Text + ": " + ((TextBox)txtMa_hd).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhhd).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nhhd.Text + ":" + ((TextBox)txtMa_nhhd).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
		}
		return text;
	}

	private void dgvBCPh_RowEnter(object sender, DataGridViewCellEventArgs e)
	{
		get_MyDGVCtSource(isSet2Print: true).DefaultView.RowFilter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", get_MyDGVPhSource(isSet2Print: true).DefaultView[e.RowIndex]["stt_rec"]), (object)"'"));
	}

	private void cboMau_bc_SelectedIndexChanged(object sender, EventArgs e)
	{
		((ListControl)cboLoaiPhieu).SelectedValue = base.MyReportInfo.par0;
	}
}
