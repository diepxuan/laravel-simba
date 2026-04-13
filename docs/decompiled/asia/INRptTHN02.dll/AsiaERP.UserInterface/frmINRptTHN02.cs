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
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmINRptTHN02 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblNhom_theo")]
	private Label _lblNhom_theo;

	[AccessedThroughProperty("cboNhom_theo")]
	private ComboBox _cboNhom_theo;

	[AccessedThroughProperty("cboChitiet")]
	private ComboBox _cboChitiet;

	[AccessedThroughProperty("lblChitiet")]
	private Label _lblChitiet;

	[AccessedThroughProperty("lblLoai_pn")]
	private Label _lblLoai_pn;

	[AccessedThroughProperty("cboLoai_pn")]
	private ComboBox _cboLoai_pn;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("lblTen_tk_du")]
	private Label _lblTen_tk_du;

	[AccessedThroughProperty("txtTK_du")]
	private AsTextBox _txtTK_du;

	[AccessedThroughProperty("lblTK_du")]
	private Label _lblTK_du;

	[AccessedThroughProperty("lblTen_nx")]
	private Label _lblTen_nx;

	[AccessedThroughProperty("txtMa_nx")]
	private AsTextBox _txtMa_nx;

	[AccessedThroughProperty("lblMa_nx")]
	private Label _lblMa_nx;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("txtMa_vitri")]
	private AsTextBox _txtMa_vitri;

	[AccessedThroughProperty("lblMa_vitri")]
	private Label _lblMa_vitri;

	[AccessedThroughProperty("lblTen_tk_vt")]
	private Label _lblTen_tk_vt;

	[AccessedThroughProperty("txtTK_vt")]
	private AsTextBox _txtTK_vt;

	[AccessedThroughProperty("lblTK_vt")]
	private Label _lblTK_vt;

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

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

	[AccessedThroughProperty("lblTen_pl_ncc3")]
	private Label _lblTen_pl_ncc3;

	[AccessedThroughProperty("lblTen_pl_ncc2")]
	private Label _lblTen_pl_ncc2;

	[AccessedThroughProperty("lblTen_pl_ncc1")]
	private Label _lblTen_pl_ncc1;

	[AccessedThroughProperty("lblTen_nh_ncc")]
	private Label _lblTen_nh_ncc;

	[AccessedThroughProperty("lblTen_ncc")]
	private Label _lblTen_ncc;

	[AccessedThroughProperty("txtPl_ncc3")]
	private AsTextBox _txtPl_ncc3;

	[AccessedThroughProperty("lblPl_ncc3")]
	private Label _lblPl_ncc3;

	[AccessedThroughProperty("txtPl_ncc2")]
	private AsTextBox _txtPl_ncc2;

	[AccessedThroughProperty("lblPl_ncc2")]
	private Label _lblPl_ncc2;

	[AccessedThroughProperty("txtPl_ncc1")]
	private AsTextBox _txtPl_ncc1;

	[AccessedThroughProperty("lblPl_ncc1")]
	private Label _lblPl_ncc1;

	[AccessedThroughProperty("txtMa_nh_ncc")]
	private AsTextBox _txtMa_nh_ncc;

	[AccessedThroughProperty("lblMa_nh_ncc")]
	private Label _lblMa_nh_ncc;

	[AccessedThroughProperty("txtMa_ncc")]
	private AsTextBox _txtMa_ncc;

	[AccessedThroughProperty("lblMa_ncc")]
	private Label _lblMa_ncc;

	[AccessedThroughProperty("lblNh_ncc")]
	private Label _lblNh_ncc;

	[AccessedThroughProperty("chkPS_dc")]
	private AsCheckBox _chkPS_dc;

	[AccessedThroughProperty("lblDVT")]
	private Label _lblDVT;

	[AccessedThroughProperty("cboDVT")]
	private ComboBox _cboDVT;

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

	[AccessedThroughProperty("txtSo_Ct2")]
	private TextBox _txtSo_Ct2;

	[AccessedThroughProperty("txtSo_Ct1")]
	private TextBox _txtSo_Ct1;

	[AccessedThroughProperty("lblSo_Ct2")]
	private Label _lblSo_Ct2;

	[AccessedThroughProperty("lblSo_Ct1")]
	private Label _lblSo_Ct1;

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

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
			EventHandler eventHandler = cboNhom_theo_SelectedValueChanged;
			if (_cboNhom_theo != null)
			{
				((ListControl)_cboNhom_theo).SelectedValueChanged -= eventHandler;
			}
			_cboNhom_theo = value;
			if (_cboNhom_theo != null)
			{
				((ListControl)_cboNhom_theo).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual ComboBox cboChitiet
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboChitiet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboChitiet_SelectedValueChanged;
			if (_cboChitiet != null)
			{
				((ListControl)_cboChitiet).SelectedValueChanged -= eventHandler;
			}
			_cboChitiet = value;
			if (_cboChitiet != null)
			{
				((ListControl)_cboChitiet).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblChitiet
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblChitiet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblChitiet = value;
		}
	}

	internal virtual Label lblLoai_pn
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai_pn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai_pn = value;
		}
	}

	internal virtual ComboBox cboLoai_pn
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_pn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboLoai_pn_SelectedValueChanged;
			if (_cboLoai_pn != null)
			{
				((ListControl)_cboLoai_pn).SelectedValueChanged -= eventHandler;
			}
			_cboLoai_pn = value;
			if (_cboLoai_pn != null)
			{
				((ListControl)_cboLoai_pn).SelectedValueChanged += eventHandler;
			}
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

	internal virtual Label lblTen_tk_du
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk_du = value;
		}
	}

	internal virtual AsTextBox txtTK_du
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

	internal virtual Label lblTK_du
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_du = value;
		}
	}

	internal virtual Label lblTen_nx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nx = value;
		}
	}

	internal virtual AsTextBox txtMa_nx
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nx = value;
		}
	}

	internal virtual Label lblMa_nx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nx = value;
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

	internal virtual Label lblTen_tk_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk_vt = value;
		}
	}

	internal virtual AsTextBox txtTK_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_vt = value;
		}
	}

	internal virtual Label lblTK_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_vt = value;
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

	internal virtual Label lblNh_ncc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNh_ncc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNh_ncc = value;
		}
	}

	internal virtual AsCheckBox chkPS_dc
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkPS_dc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkPS_dc = value;
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

	public frmINRptTHN02(string menuID)
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
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
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
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
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
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
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
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_3cf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d00: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		lblNhom_theo = new Label();
		cboNhom_theo = new ComboBox();
		cboChitiet = new ComboBox();
		lblChitiet = new Label();
		lblLoai_pn = new Label();
		cboLoai_pn = new ComboBox();
		lblTen_pl_ncc3 = new Label();
		lblTen_pl_ncc2 = new Label();
		lblTen_pl_ncc1 = new Label();
		lblTen_nh_ncc = new Label();
		lblTen_ncc = new Label();
		txtPl_ncc3 = new AsTextBox();
		lblPl_ncc3 = new Label();
		txtPl_ncc2 = new AsTextBox();
		lblPl_ncc2 = new Label();
		txtPl_ncc1 = new AsTextBox();
		lblPl_ncc1 = new Label();
		txtMa_nh_ncc = new AsTextBox();
		lblMa_nh_ncc = new Label();
		txtMa_ncc = new AsTextBox();
		lblMa_ncc = new Label();
		lblTen_hd = new Label();
		lblTen_bp = new Label();
		txtMa_bp = new AsTextBox();
		lblMa_bp = new Label();
		lblTen_vitri = new Label();
		txtMa_vitri = new AsTextBox();
		lblMa_vitri = new Label();
		lblTen_tk_vt = new Label();
		txtTK_vt = new AsTextBox();
		lblTK_vt = new Label();
		lblTen_kho = new Label();
		txtMa_kho = new AsTextBox();
		lblMa_kho = new Label();
		lblTen_nh_vt = new Label();
		txtMa_nh_vt = new AsTextBox();
		lblMa_nh_vt = new Label();
		lblTen_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		txtMa_hd = new AsTextBox();
		lblMa_hd = new Label();
		lblTen_tk_du = new Label();
		txtTK_du = new AsTextBox();
		lblTK_du = new Label();
		lblTen_nx = new Label();
		txtMa_nx = new AsTextBox();
		lblMa_nx = new Label();
		lblTen_spct = new Label();
		txtMa_spct = new AsTextBox();
		lblMa_spct = new Label();
		lblNh_ncc = new Label();
		chkPS_dc = new AsCheckBox();
		lblDVT = new Label();
		cboDVT = new ComboBox();
		cboLoai_gd = new ComboBox();
		Label2 = new Label();
		Label8 = new Label();
		lblTenPhi = new Label();
		txtMa_Phi = new AsTextBox();
		lblTen_lo = new Label();
		txtMa_lo = new AsTextBox();
		lblMaLo = new Label();
		txtSo_Ct2 = new TextBox();
		txtSo_Ct1 = new TextBox();
		lblSo_Ct2 = new Label();
		lblSo_Ct1 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(1037, 590);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_Ct2);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_Ct1);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct2);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct1);
		((Control)tabFilter).Controls.Add((Control)(object)Label8);
		((Control)tabFilter).Controls.Add((Control)(object)lblTenPhi);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lo);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_lo);
		((Control)tabFilter).Controls.Add((Control)(object)lblMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai_gd);
		((Control)tabFilter).Controls.Add((Control)(object)Label2);
		((Control)tabFilter).Controls.Add((Control)(object)lblDVT);
		((Control)tabFilter).Controls.Add((Control)(object)cboDVT);
		((Control)tabFilter).Controls.Add((Control)(object)lblNh_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)chkPS_dc);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tk_du);
		((Control)tabFilter).Controls.Add((Control)(object)txtTK_du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTK_du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nx);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nx);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nx);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tk_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtTK_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTK_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nh_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nh_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nh_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_pl_ncc3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_pl_ncc2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_pl_ncc1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nh_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)txtPl_ncc3);
		((Control)tabFilter).Controls.Add((Control)(object)lblPl_ncc3);
		((Control)tabFilter).Controls.Add((Control)(object)txtPl_ncc2);
		((Control)tabFilter).Controls.Add((Control)(object)lblPl_ncc2);
		((Control)tabFilter).Controls.Add((Control)(object)txtPl_ncc1);
		((Control)tabFilter).Controls.Add((Control)(object)lblPl_ncc1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nh_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nh_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoai_pn);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai_pn);
		((Control)tabFilter).Controls.Add((Control)(object)cboChitiet);
		((Control)tabFilter).Controls.Add((Control)(object)lblChitiet);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_theo);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom_theo);
		TabPage obj = tabFilter;
		size = new Size(1029, 561);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom_theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblChitiet, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboChitiet, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai_pn, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoai_pn, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nh_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nh_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPl_ncc1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtPl_ncc1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPl_ncc2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtPl_ncc2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPl_ncc3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtPl_ncc3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nh_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_pl_ncc1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_pl_ncc2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_pl_ncc3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nh_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nh_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nh_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tk_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nx, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nx, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nx, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK_du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK_du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tk_du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)chkPS_dc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNh_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboDVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai_gd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTenPhi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_Ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_Ct2, 0);
		Label obj2 = lbl2;
		Point location = new Point(339, 68);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 40;
		Button obj3 = cmdExcel;
		location = new Point(700, 589);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 42;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(358, 64);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 589);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 41;
		Button obj5 = cmdModifyReport;
		location = new Point(505, 14);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 201;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(268, 64);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(160, 64);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(25, 68);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(160, 16);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 200;
		Label obj9 = lblMau_bc;
		location = new Point(25, 19);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(160, 477);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 22;
		Label obj10 = lblMauBC;
		location = new Point(216, 477);
		((Control)obj10).Location = location;
		RadioButton obj11 = optVND;
		location = new Point(303, 477);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 23;
		RadioButton obj12 = optNt;
		location = new Point(361, 477);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 24;
		Label obj13 = lblMa_nt;
		location = new Point(25, 479);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(28, 508);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 25;
		Label obj15 = lblTieu_de;
		location = new Point(25, 44);
		((Control)obj15).Location = location;
		((Control)lblTieu_de).TabIndex = 28;
		TextBox obj16 = txtTieu_De;
		location = new Point(160, 40);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 202;
		TabPage obj17 = tabGrid;
		size = new Size(1029, 561);
		((Control)obj17).Size = size;
		crvReportViewer.ActiveViewIndex = -1;
		((UserControl)crvReportViewer).BorderStyle = (BorderStyle)1;
		crvReportViewer.DisplayGroupTree = false;
		((Control)crvReportViewer).Dock = (DockStyle)5;
		CrystalReportViewer obj18 = crvReportViewer;
		location = new Point(0, 0);
		((Control)obj18).Location = location;
		((Control)crvReportViewer).Name = "crvReportViewer";
		crvReportViewer.SelectionFormula = "";
		crvReportViewer.ShowRefreshButton = false;
		CrystalReportViewer obj19 = crvReportViewer;
		size = new Size(1029, 561);
		((Control)obj19).Size = size;
		((Control)crvReportViewer).TabIndex = 0;
		crvReportViewer.ViewTimeSelectionFormula = "";
		lblNhom_theo.AutoSize = true;
		Label obj20 = lblNhom_theo;
		location = new Point(25, 92);
		((Control)obj20).Location = location;
		((Control)lblNhom_theo).Name = "lblNhom_theo";
		Label obj21 = lblNhom_theo;
		size = new Size(59, 13);
		((Control)obj21).Size = size;
		((Control)lblNhom_theo).TabIndex = 1016;
		lblNhom_theo.Text = "Nhóm theo";
		cboNhom_theo.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_theo).FormattingEnabled = true;
		cboNhom_theo.Items.AddRange(new object[5] { "Nhà cung cấp", "Hợp đồng", "Sản phẩm công trình", "Dạng nhập xuất", "Mặt hàng" });
		ComboBox obj22 = cboNhom_theo;
		location = new Point(160, 89);
		((Control)obj22).Location = location;
		((Control)cboNhom_theo).Name = "cboNhom_theo";
		ComboBox obj23 = cboNhom_theo;
		size = new Size(175, 21);
		((Control)obj23).Size = size;
		((Control)cboNhom_theo).TabIndex = 3;
		cboChitiet.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboChitiet).FormattingEnabled = true;
		cboChitiet.Items.AddRange(new object[5] { "Mặt hàng", "Nhà cung cấp", "Hợp đồng", "Dạng nhập xuất", "Sản phẩm công trình" });
		ComboBox obj24 = cboChitiet;
		location = new Point(435, 89);
		((Control)obj24).Location = location;
		((Control)cboChitiet).Name = "cboChitiet";
		ComboBox obj25 = cboChitiet;
		size = new Size(145, 21);
		((Control)obj25).Size = size;
		((Control)cboChitiet).TabIndex = 4;
		lblChitiet.AutoSize = true;
		Label obj26 = lblChitiet;
		location = new Point(355, 92);
		((Control)obj26).Location = location;
		((Control)lblChitiet).Name = "lblChitiet";
		Label obj27 = lblChitiet;
		size = new Size(63, 13);
		((Control)obj27).Size = size;
		((Control)lblChitiet).TabIndex = 1018;
		lblChitiet.Text = "Chi tiết theo";
		lblChitiet.TextAlign = (ContentAlignment)2;
		lblLoai_pn.AutoSize = true;
		Label obj28 = lblLoai_pn;
		location = new Point(25, 117);
		((Control)obj28).Location = location;
		((Control)lblLoai_pn).Name = "lblLoai_pn";
		Label obj29 = lblLoai_pn;
		size = new Size(83, 13);
		((Control)obj29).Size = size;
		((Control)lblLoai_pn).TabIndex = 1323;
		lblLoai_pn.Text = "Loại phiếu nhập";
		cboLoai_pn.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_pn).FormattingEnabled = true;
		ComboBox obj30 = cboLoai_pn;
		location = new Point(160, 114);
		((Control)obj30).Location = location;
		((Control)cboLoai_pn).Name = "cboLoai_pn";
		ComboBox obj31 = cboLoai_pn;
		size = new Size(175, 21);
		((Control)obj31).Size = size;
		((Control)cboLoai_pn).TabIndex = 5;
		((Control)lblTen_pl_ncc3).Enabled = false;
		lblTen_pl_ncc3.ImeMode = (ImeMode)0;
		Label obj32 = lblTen_pl_ncc3;
		location = new Point(559, 597);
		((Control)obj32).Location = location;
		((Control)lblTen_pl_ncc3).Name = "lblTen_pl_ncc3";
		Label obj33 = lblTen_pl_ncc3;
		size = new Size(519, 13);
		((Control)obj33).Size = size;
		((Control)lblTen_pl_ncc3).TabIndex = 1338;
		lblTen_pl_ncc3.TextAlign = (ContentAlignment)16;
		((Control)lblTen_pl_ncc3).Visible = false;
		((Control)lblTen_pl_ncc2).Enabled = false;
		lblTen_pl_ncc2.ImeMode = (ImeMode)0;
		Label obj34 = lblTen_pl_ncc2;
		location = new Point(559, 573);
		((Control)obj34).Location = location;
		((Control)lblTen_pl_ncc2).Name = "lblTen_pl_ncc2";
		Label obj35 = lblTen_pl_ncc2;
		size = new Size(519, 13);
		((Control)obj35).Size = size;
		((Control)lblTen_pl_ncc2).TabIndex = 1337;
		lblTen_pl_ncc2.TextAlign = (ContentAlignment)16;
		((Control)lblTen_pl_ncc2).Visible = false;
		((Control)lblTen_pl_ncc1).Enabled = false;
		lblTen_pl_ncc1.ImeMode = (ImeMode)0;
		Label obj36 = lblTen_pl_ncc1;
		location = new Point(559, 549);
		((Control)obj36).Location = location;
		((Control)lblTen_pl_ncc1).Name = "lblTen_pl_ncc1";
		Label obj37 = lblTen_pl_ncc1;
		size = new Size(519, 13);
		((Control)obj37).Size = size;
		((Control)lblTen_pl_ncc1).TabIndex = 1336;
		lblTen_pl_ncc1.TextAlign = (ContentAlignment)16;
		((Control)lblTen_pl_ncc1).Visible = false;
		((Control)lblTen_nh_ncc).Enabled = false;
		lblTen_nh_ncc.ImeMode = (ImeMode)0;
		Label obj38 = lblTen_nh_ncc;
		location = new Point(700, 481);
		((Control)obj38).Location = location;
		((Control)lblTen_nh_ncc).Name = "lblTen_nh_ncc";
		Label obj39 = lblTen_nh_ncc;
		size = new Size(314, 13);
		((Control)obj39).Size = size;
		((Control)lblTen_nh_ncc).TabIndex = 1335;
		lblTen_nh_ncc.TextAlign = (ContentAlignment)16;
		((Control)lblTen_nh_ncc).Visible = false;
		lblTen_ncc.ImeMode = (ImeMode)0;
		Label obj40 = lblTen_ncc;
		location = new Point(256, 286);
		((Control)obj40).Location = location;
		((Control)lblTen_ncc).Name = "lblTen_ncc";
		Label obj41 = lblTen_ncc;
		size = new Size(519, 13);
		((Control)obj41).Size = size;
		((Control)lblTen_ncc).TabIndex = 1334;
		lblTen_ncc.TextAlign = (ContentAlignment)16;
		txtPl_ncc3.AutoLookup = true;
		txtPl_ncc3.AutoValid = false;
		((TextBoxBase)txtPl_ncc3).BackColor = SystemColors.Info;
		((TextBox)txtPl_ncc3).CharacterCasing = (CharacterCasing)1;
		((Control)txtPl_ncc3).Enabled = false;
		AsTextBox asTextBox2 = txtPl_ncc3;
		location = new Point(463, 594);
		((Control)asTextBox2).Location = location;
		txtPl_ncc3.LookupCodeName = "MA_PLKH";
		txtPl_ncc3.LookupWhereCondition = "loai =3";
		((TextBoxBase)txtPl_ncc3).MaxLength = 20;
		((Control)txtPl_ncc3).Name = "txtPl_ncc3";
		txtPl_ncc3.NameControl = lblTen_pl_ncc3;
		AsTextBox asTextBox3 = txtPl_ncc3;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtPl_ncc3).TabIndex = 10;
		txtPl_ncc3.UseAutoCompleteSource = true;
		((Control)txtPl_ncc3).Visible = false;
		lblPl_ncc3.AutoSize = true;
		((Control)lblPl_ncc3).Enabled = false;
		Label obj42 = lblPl_ncc3;
		location = new Point(328, 597);
		((Control)obj42).Location = location;
		((Control)lblPl_ncc3).Name = "lblPl_ncc3";
		Label obj43 = lblPl_ncc3;
		size = new Size(85, 13);
		((Control)obj43).Size = size;
		((Control)lblPl_ncc3).TabIndex = 1333;
		lblPl_ncc3.Text = "Phân loại NCC 3";
		((Control)lblPl_ncc3).Visible = false;
		txtPl_ncc2.AutoLookup = true;
		txtPl_ncc2.AutoValid = false;
		((TextBoxBase)txtPl_ncc2).BackColor = SystemColors.Info;
		((TextBox)txtPl_ncc2).CharacterCasing = (CharacterCasing)1;
		((Control)txtPl_ncc2).Enabled = false;
		AsTextBox asTextBox4 = txtPl_ncc2;
		location = new Point(463, 570);
		((Control)asTextBox4).Location = location;
		txtPl_ncc2.LookupCodeName = "MA_PLKH";
		txtPl_ncc2.LookupWhereCondition = "loai =2";
		((TextBoxBase)txtPl_ncc2).MaxLength = 20;
		((Control)txtPl_ncc2).Name = "txtPl_ncc2";
		txtPl_ncc2.NameControl = lblTen_pl_ncc2;
		AsTextBox asTextBox5 = txtPl_ncc2;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtPl_ncc2).TabIndex = 9;
		txtPl_ncc2.UseAutoCompleteSource = true;
		((Control)txtPl_ncc2).Visible = false;
		lblPl_ncc2.AutoSize = true;
		((Control)lblPl_ncc2).Enabled = false;
		Label obj44 = lblPl_ncc2;
		location = new Point(328, 573);
		((Control)obj44).Location = location;
		((Control)lblPl_ncc2).Name = "lblPl_ncc2";
		Label obj45 = lblPl_ncc2;
		size = new Size(85, 13);
		((Control)obj45).Size = size;
		((Control)lblPl_ncc2).TabIndex = 1332;
		lblPl_ncc2.Text = "Phân loại NCC 2";
		((Control)lblPl_ncc2).Visible = false;
		txtPl_ncc1.AutoLookup = true;
		txtPl_ncc1.AutoValid = false;
		((TextBoxBase)txtPl_ncc1).BackColor = SystemColors.Info;
		((TextBox)txtPl_ncc1).CharacterCasing = (CharacterCasing)1;
		((Control)txtPl_ncc1).Enabled = false;
		AsTextBox asTextBox6 = txtPl_ncc1;
		location = new Point(463, 546);
		((Control)asTextBox6).Location = location;
		txtPl_ncc1.LookupCodeName = "MA_PLKH";
		txtPl_ncc1.LookupWhereCondition = "loai =1";
		((TextBoxBase)txtPl_ncc1).MaxLength = 20;
		((Control)txtPl_ncc1).Name = "txtPl_ncc1";
		txtPl_ncc1.NameControl = lblTen_pl_ncc1;
		AsTextBox asTextBox7 = txtPl_ncc1;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtPl_ncc1).TabIndex = 8;
		txtPl_ncc1.UseAutoCompleteSource = true;
		((Control)txtPl_ncc1).Visible = false;
		lblPl_ncc1.AutoSize = true;
		((Control)lblPl_ncc1).Enabled = false;
		Label obj46 = lblPl_ncc1;
		location = new Point(328, 549);
		((Control)obj46).Location = location;
		((Control)lblPl_ncc1).Name = "lblPl_ncc1";
		Label obj47 = lblPl_ncc1;
		size = new Size(85, 13);
		((Control)obj47).Size = size;
		((Control)lblPl_ncc1).TabIndex = 1331;
		lblPl_ncc1.Text = "Phân loại NCC 1";
		((Control)lblPl_ncc1).Visible = false;
		txtMa_nh_ncc.AutoLookup = true;
		txtMa_nh_ncc.AutoValid = false;
		((TextBoxBase)txtMa_nh_ncc).BackColor = SystemColors.Info;
		((TextBox)txtMa_nh_ncc).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_nh_ncc).Enabled = false;
		AsTextBox asTextBox8 = txtMa_nh_ncc;
		location = new Point(595, 445);
		((Control)asTextBox8).Location = location;
		txtMa_nh_ncc.LookupCodeName = "MA_NHKH";
		((TextBoxBase)txtMa_nh_ncc).MaxLength = 20;
		((Control)txtMa_nh_ncc).Name = "txtMa_nh_ncc";
		txtMa_nh_ncc.NameControl = lblTen_nh_ncc;
		AsTextBox asTextBox9 = txtMa_nh_ncc;
		size = new Size(90, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_nh_ncc).TabIndex = 6;
		txtMa_nh_ncc.UseAutoCompleteSource = true;
		((Control)txtMa_nh_ncc).Visible = false;
		lblMa_nh_ncc.AutoSize = true;
		((Control)lblMa_nh_ncc).Enabled = false;
		Label obj48 = lblMa_nh_ncc;
		location = new Point(460, 482);
		((Control)obj48).Location = location;
		((Control)lblMa_nh_ncc).Name = "lblMa_nh_ncc";
		Label obj49 = lblMa_nh_ncc;
		size = new Size(69, 13);
		((Control)obj49).Size = size;
		((Control)lblMa_nh_ncc).TabIndex = 1330;
		lblMa_nh_ncc.Text = "Mã nhóm KH";
		((Control)lblMa_nh_ncc).Visible = false;
		txtMa_ncc.AutoLookup = true;
		txtMa_ncc.AutoValid = false;
		((TextBoxBase)txtMa_ncc).BackColor = SystemColors.Info;
		((TextBox)txtMa_ncc).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_ncc;
		location = new Point(160, 283);
		((Control)asTextBox10).Location = location;
		txtMa_ncc.LookupCodeName = "MA_NCC";
		((TextBoxBase)txtMa_ncc).MaxLength = 20;
		((Control)txtMa_ncc).Name = "txtMa_ncc";
		txtMa_ncc.NameControl = lblTen_ncc;
		AsTextBox asTextBox11 = txtMa_ncc;
		size = new Size(90, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_ncc).TabIndex = 14;
		txtMa_ncc.UseAutoCompleteSource = true;
		lblMa_ncc.AutoSize = true;
		Label obj50 = lblMa_ncc;
		location = new Point(25, 286);
		((Control)obj50).Location = location;
		((Control)lblMa_ncc).Name = "lblMa_ncc";
		Label obj51 = lblMa_ncc;
		size = new Size(91, 13);
		((Control)obj51).Size = size;
		((Control)lblMa_ncc).TabIndex = 1329;
		lblMa_ncc.Text = "Mã nhà cung cấp";
		lblTen_hd.ImeMode = (ImeMode)0;
		Label obj52 = lblTen_hd;
		location = new Point(256, 310);
		((Control)obj52).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj53 = lblTen_hd;
		size = new Size(519, 13);
		((Control)obj53).Size = size;
		((Control)lblTen_hd).TabIndex = 1359;
		lblTen_hd.TextAlign = (ContentAlignment)16;
		lblTen_bp.ImeMode = (ImeMode)0;
		Label obj54 = lblTen_bp;
		location = new Point(256, 334);
		((Control)obj54).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj55 = lblTen_bp;
		size = new Size(519, 13);
		((Control)obj55).Size = size;
		((Control)lblTen_bp).TabIndex = 1358;
		lblTen_bp.TextAlign = (ContentAlignment)16;
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_bp;
		location = new Point(160, 331);
		((Control)asTextBox12).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((TextBoxBase)txtMa_bp).MaxLength = 20;
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox13 = txtMa_bp;
		size = new Size(90, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_bp).TabIndex = 16;
		txtMa_bp.UseAutoCompleteSource = true;
		lblMa_bp.AutoSize = true;
		Label obj56 = lblMa_bp;
		location = new Point(25, 334);
		((Control)obj56).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj57 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj57).Size = size;
		((Control)lblMa_bp).TabIndex = 1357;
		lblMa_bp.Text = "Mã bộ phận";
		((Control)lblTen_vitri).Enabled = false;
		lblTen_vitri.ImeMode = (ImeMode)0;
		Label obj58 = lblTen_vitri;
		location = new Point(700, 455);
		((Control)obj58).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj59 = lblTen_vitri;
		size = new Size(314, 13);
		((Control)obj59).Size = size;
		((Control)lblTen_vitri).TabIndex = 1356;
		lblTen_vitri.TextAlign = (ContentAlignment)16;
		((Control)lblTen_vitri).Visible = false;
		txtMa_vitri.AutoLookup = true;
		txtMa_vitri.AutoValid = false;
		((TextBoxBase)txtMa_vitri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vitri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vitri).Enabled = false;
		AsTextBox asTextBox14 = txtMa_vitri;
		location = new Point(595, 419);
		((Control)asTextBox14).Location = location;
		txtMa_vitri.LookupCodeName = "MA_VITRI";
		((TextBoxBase)txtMa_vitri).MaxLength = 20;
		((Control)txtMa_vitri).Name = "txtMa_vitri";
		txtMa_vitri.NameControl = lblTen_vitri;
		AsTextBox asTextBox15 = txtMa_vitri;
		size = new Size(90, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_vitri).TabIndex = 11;
		txtMa_vitri.UseAutoCompleteSource = true;
		((Control)txtMa_vitri).Visible = false;
		lblMa_vitri.AutoSize = true;
		((Control)lblMa_vitri).Enabled = false;
		Label obj60 = lblMa_vitri;
		location = new Point(460, 455);
		((Control)obj60).Location = location;
		((Control)lblMa_vitri).Name = "lblMa_vitri";
		Label obj61 = lblMa_vitri;
		size = new Size(46, 13);
		((Control)obj61).Size = size;
		((Control)lblMa_vitri).TabIndex = 1355;
		lblMa_vitri.Text = "Mã vị trí";
		((Control)lblMa_vitri).Visible = false;
		lblTen_tk_vt.ImeMode = (ImeMode)0;
		Label obj62 = lblTen_tk_vt;
		location = new Point(256, 238);
		((Control)obj62).Location = location;
		((Control)lblTen_tk_vt).Name = "lblTen_tk_vt";
		Label obj63 = lblTen_tk_vt;
		size = new Size(519, 13);
		((Control)obj63).Size = size;
		((Control)lblTen_tk_vt).TabIndex = 1354;
		lblTen_tk_vt.TextAlign = (ContentAlignment)16;
		txtTK_vt.AutoLookup = true;
		txtTK_vt.AutoValid = false;
		((TextBoxBase)txtTK_vt).BackColor = SystemColors.Info;
		((TextBox)txtTK_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox16 = txtTK_vt;
		location = new Point(160, 235);
		((Control)asTextBox16).Location = location;
		txtTK_vt.LookupCodeName = "TK";
		((TextBoxBase)txtTK_vt).MaxLength = 20;
		((Control)txtTK_vt).Name = "txtTK_vt";
		txtTK_vt.NameControl = lblTen_tk_vt;
		AsTextBox asTextBox17 = txtTK_vt;
		size = new Size(90, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtTK_vt).TabIndex = 12;
		txtTK_vt.UseAutoCompleteSource = true;
		lblTK_vt.AutoSize = true;
		Label obj64 = lblTK_vt;
		location = new Point(25, 238);
		((Control)obj64).Location = location;
		((Control)lblTK_vt).Name = "lblTK_vt";
		Label obj65 = lblTK_vt;
		size = new Size(51, 13);
		((Control)obj65).Size = size;
		((Control)lblTK_vt).TabIndex = 1353;
		lblTK_vt.Text = "TK vật tư";
		lblTen_kho.ImeMode = (ImeMode)0;
		Label obj66 = lblTen_kho;
		location = new Point(256, 166);
		((Control)obj66).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj67 = lblTen_kho;
		size = new Size(519, 13);
		((Control)obj67).Size = size;
		((Control)lblTen_kho).TabIndex = 1352;
		lblTen_kho.TextAlign = (ContentAlignment)16;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox18 = txtMa_kho;
		location = new Point(160, 163);
		((Control)asTextBox18).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((TextBoxBase)txtMa_kho).MaxLength = 20;
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox19 = txtMa_kho;
		size = new Size(90, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtMa_kho).TabIndex = 9;
		txtMa_kho.UseAutoCompleteSource = true;
		lblMa_kho.AutoSize = true;
		Label obj68 = lblMa_kho;
		location = new Point(25, 166);
		((Control)obj68).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj69 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj69).Size = size;
		((Control)lblMa_kho).TabIndex = 1351;
		lblMa_kho.Text = "Mã kho";
		lblTen_nh_vt.ImeMode = (ImeMode)0;
		Label obj70 = lblTen_nh_vt;
		location = new Point(256, 214);
		((Control)obj70).Location = location;
		((Control)lblTen_nh_vt).Name = "lblTen_nh_vt";
		Label obj71 = lblTen_nh_vt;
		size = new Size(519, 13);
		((Control)obj71).Size = size;
		((Control)lblTen_nh_vt).TabIndex = 1350;
		lblTen_nh_vt.TextAlign = (ContentAlignment)16;
		txtMa_nh_vt.AutoLookup = true;
		txtMa_nh_vt.AutoValid = false;
		((TextBoxBase)txtMa_nh_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nh_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtMa_nh_vt;
		location = new Point(160, 211);
		((Control)asTextBox20).Location = location;
		txtMa_nh_vt.LookupCodeName = "MA_NHVT";
		((TextBoxBase)txtMa_nh_vt).MaxLength = 20;
		((Control)txtMa_nh_vt).Name = "txtMa_nh_vt";
		txtMa_nh_vt.NameControl = lblTen_nh_vt;
		AsTextBox asTextBox21 = txtMa_nh_vt;
		size = new Size(90, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMa_nh_vt).TabIndex = 11;
		txtMa_nh_vt.UseAutoCompleteSource = true;
		lblMa_nh_vt.AutoSize = true;
		Label obj72 = lblMa_nh_vt;
		location = new Point(25, 214);
		((Control)obj72).Location = location;
		((Control)lblMa_nh_vt).Name = "lblMa_nh_vt";
		Label obj73 = lblMa_nh_vt;
		size = new Size(81, 13);
		((Control)obj73).Size = size;
		((Control)lblMa_nh_vt).TabIndex = 1349;
		lblMa_nh_vt.Text = "Mã nhóm vật tư";
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj74 = lblTen_vt;
		location = new Point(256, 190);
		((Control)obj74).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj75 = lblTen_vt;
		size = new Size(519, 13);
		((Control)obj75).Size = size;
		((Control)lblTen_vt).TabIndex = 1348;
		lblTen_vt.TextAlign = (ContentAlignment)16;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox22 = txtMa_vt;
		location = new Point(160, 187);
		((Control)asTextBox22).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((TextBoxBase)txtMa_vt).MaxLength = 20;
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox23 = txtMa_vt;
		size = new Size(90, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMa_vt).TabIndex = 10;
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_vt.AutoSize = true;
		Label obj76 = lblMa_vt;
		location = new Point(25, 190);
		((Control)obj76).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj77 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj77).Size = size;
		((Control)lblMa_vt).TabIndex = 1347;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox24 = txtMa_hd;
		location = new Point(160, 307);
		((Control)asTextBox24).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((TextBoxBase)txtMa_hd).MaxLength = 20;
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox25 = txtMa_hd;
		size = new Size(90, 20);
		((Control)asTextBox25).Size = size;
		((Control)txtMa_hd).TabIndex = 15;
		txtMa_hd.UseAutoCompleteSource = true;
		lblMa_hd.AutoSize = true;
		Label obj78 = lblMa_hd;
		location = new Point(25, 310);
		((Control)obj78).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj79 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj79).Size = size;
		((Control)lblMa_hd).TabIndex = 1346;
		lblMa_hd.Text = "Mã hợp đồng";
		lblTen_tk_du.ImeMode = (ImeMode)0;
		Label obj80 = lblTen_tk_du;
		location = new Point(256, 262);
		((Control)obj80).Location = location;
		((Control)lblTen_tk_du).Name = "lblTen_tk_du";
		Label obj81 = lblTen_tk_du;
		size = new Size(519, 13);
		((Control)obj81).Size = size;
		((Control)lblTen_tk_du).TabIndex = 1366;
		lblTen_tk_du.TextAlign = (ContentAlignment)16;
		txtTK_du.AutoLookup = true;
		txtTK_du.AutoValid = false;
		((TextBoxBase)txtTK_du).BackColor = SystemColors.Info;
		((TextBox)txtTK_du).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox26 = txtTK_du;
		location = new Point(160, 259);
		((Control)asTextBox26).Location = location;
		txtTK_du.LookupCodeName = "TK";
		((TextBoxBase)txtTK_du).MaxLength = 20;
		((Control)txtTK_du).Name = "txtTK_du";
		txtTK_du.NameControl = lblTen_tk_du;
		AsTextBox asTextBox27 = txtTK_du;
		size = new Size(90, 20);
		((Control)asTextBox27).Size = size;
		((Control)txtTK_du).TabIndex = 13;
		txtTK_du.UseAutoCompleteSource = true;
		lblTK_du.AutoSize = true;
		Label obj82 = lblTK_du;
		location = new Point(25, 262);
		((Control)obj82).Location = location;
		((Control)lblTK_du).Name = "lblTK_du";
		Label obj83 = lblTK_du;
		size = new Size(60, 13);
		((Control)obj83).Size = size;
		((Control)lblTK_du).TabIndex = 1365;
		lblTK_du.Text = "TK đối ứng";
		((Control)lblTen_nx).Enabled = false;
		lblTen_nx.ImeMode = (ImeMode)0;
		Label obj84 = lblTen_nx;
		location = new Point(624, 511);
		((Control)obj84).Location = location;
		((Control)lblTen_nx).Name = "lblTen_nx";
		Label obj85 = lblTen_nx;
		size = new Size(314, 13);
		((Control)obj85).Size = size;
		((Control)lblTen_nx).TabIndex = 1364;
		lblTen_nx.TextAlign = (ContentAlignment)16;
		((Control)lblTen_nx).Visible = false;
		txtMa_nx.AutoLookup = true;
		txtMa_nx.AutoValid = false;
		((TextBoxBase)txtMa_nx).BackColor = SystemColors.Info;
		((TextBox)txtMa_nx).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_nx).Enabled = false;
		AsTextBox asTextBox28 = txtMa_nx;
		location = new Point(519, 506);
		((Control)asTextBox28).Location = location;
		txtMa_nx.LookupCodeName = "MA_NX";
		txtMa_nx.LookupWhereCondition = "moduleid = 'IN'";
		((TextBoxBase)txtMa_nx).MaxLength = 20;
		((Control)txtMa_nx).Name = "txtMa_nx";
		txtMa_nx.NameControl = lblTen_nx;
		AsTextBox asTextBox29 = txtMa_nx;
		size = new Size(90, 20);
		((Control)asTextBox29).Size = size;
		((Control)txtMa_nx).TabIndex = 21;
		txtMa_nx.UseAutoCompleteSource = true;
		((Control)txtMa_nx).Visible = false;
		lblMa_nx.AutoSize = true;
		((Control)lblMa_nx).Enabled = false;
		Label obj86 = lblMa_nx;
		location = new Point(421, 509);
		((Control)obj86).Location = location;
		((Control)lblMa_nx).Name = "lblMa_nx";
		Label obj87 = lblMa_nx;
		size = new Size(67, 13);
		((Control)obj87).Size = size;
		((Control)lblMa_nx).TabIndex = 1363;
		lblMa_nx.Text = "Mã dạng NX";
		((Control)lblMa_nx).Visible = false;
		lblTen_spct.ImeMode = (ImeMode)0;
		Label obj88 = lblTen_spct;
		location = new Point(256, 358);
		((Control)obj88).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj89 = lblTen_spct;
		size = new Size(519, 13);
		((Control)obj89).Size = size;
		((Control)lblTen_spct).TabIndex = 1369;
		lblTen_spct.TextAlign = (ContentAlignment)16;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox30 = txtMa_spct;
		location = new Point(160, 355);
		((Control)asTextBox30).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((TextBoxBase)txtMa_spct).MaxLength = 20;
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox31 = txtMa_spct;
		size = new Size(90, 20);
		((Control)asTextBox31).Size = size;
		((Control)txtMa_spct).TabIndex = 17;
		txtMa_spct.UseAutoCompleteSource = true;
		lblMa_spct.AutoSize = true;
		Label obj90 = lblMa_spct;
		location = new Point(25, 358);
		((Control)obj90).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj91 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj91).Size = size;
		((Control)lblMa_spct).TabIndex = 1368;
		lblMa_spct.Text = "Mã SPCT";
		lblNh_ncc.AutoSize = true;
		Label obj92 = lblNh_ncc;
		location = new Point(25, 454);
		((Control)obj92).Location = location;
		((Control)lblNh_ncc).Name = "lblNh_ncc";
		Label obj93 = lblNh_ncc;
		size = new Size(83, 13);
		((Control)obj93).Size = size;
		((Control)lblNh_ncc).TabIndex = 1371;
		lblNh_ncc.Text = "PS điều chuyển";
		((ButtonBase)chkPS_dc).AutoSize = true;
		chkPS_dc.Checked = false;
		AsCheckBox asCheckBox = chkPS_dc;
		location = new Point(160, 454);
		((Control)asCheckBox).Location = location;
		((Control)chkPS_dc).Name = "chkPS_dc";
		AsCheckBox asCheckBox2 = chkPS_dc;
		size = new Size(170, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkPS_dc).TabIndex = 21;
		((ButtonBase)chkPS_dc).Text = "Tính các PS điều chuyển kho";
		chkPS_dc.TextValue = "0";
		((ButtonBase)chkPS_dc).UseVisualStyleBackColor = true;
		lblDVT.AutoSize = true;
		Label obj94 = lblDVT;
		location = new Point(25, 430);
		((Control)obj94).Location = location;
		((Control)lblDVT).Name = "lblDVT";
		Label obj95 = lblDVT;
		size = new Size(57, 13);
		((Control)obj95).Size = size;
		((Control)lblDVT).TabIndex = 1373;
		lblDVT.Text = "Theo ĐVT";
		cboDVT.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboDVT).FormattingEnabled = true;
		cboDVT.Items.AddRange(new object[4] { "Chứng từ", "Kho", "Mua", "Bán" });
		ComboBox obj96 = cboDVT;
		location = new Point(160, 427);
		((Control)obj96).Location = location;
		((Control)cboDVT).Name = "cboDVT";
		ComboBox obj97 = cboDVT;
		size = new Size(94, 21);
		((Control)obj97).Size = size;
		((Control)cboDVT).TabIndex = 20;
		cboLoai_gd.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_gd).FormattingEnabled = true;
		ComboBox obj98 = cboLoai_gd;
		location = new Point(435, 114);
		((Control)obj98).Location = location;
		((Control)cboLoai_gd).Name = "cboLoai_gd";
		ComboBox obj99 = cboLoai_gd;
		size = new Size(145, 21);
		((Control)obj99).Size = size;
		((Control)cboLoai_gd).TabIndex = 6;
		Label2.AutoSize = true;
		Label label = Label2;
		location = new Point(355, 118);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(73, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 1375;
		Label2.Text = "Loại giao dịch";
		Label8.AutoSize = true;
		Label label3 = Label8;
		location = new Point(25, 383);
		((Control)label3).Location = location;
		((Control)Label8).Name = "Label8";
		Label label4 = Label8;
		size = new Size(41, 13);
		((Control)label4).Size = size;
		((Control)Label8).TabIndex = 1381;
		Label8.Text = "Mã phí";
		Label obj100 = lblTenPhi;
		location = new Point(256, 383);
		((Control)obj100).Location = location;
		((Control)lblTenPhi).Name = "lblTenPhi";
		Label obj101 = lblTenPhi;
		size = new Size(479, 13);
		((Control)obj101).Size = size;
		((Control)lblTenPhi).TabIndex = 1380;
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox32 = txtMa_Phi;
		location = new Point(160, 379);
		((Control)asTextBox32).Location = location;
		txtMa_Phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		txtMa_Phi.NameControl = lblTenPhi;
		AsTextBox asTextBox33 = txtMa_Phi;
		size = new Size(90, 20);
		((Control)asTextBox33).Size = size;
		((Control)txtMa_Phi).TabIndex = 18;
		((Control)txtMa_Phi).Tag = "MA_PHI";
		txtMa_Phi.UseAutoCompleteSource = true;
		Label obj102 = lblTen_lo;
		location = new Point(256, 407);
		((Control)obj102).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj103 = lblTen_lo;
		size = new Size(515, 13);
		((Control)obj103).Size = size;
		((Control)lblTen_lo).TabIndex = 1378;
		txtMa_lo.AutoLookup = true;
		txtMa_lo.AutoValid = false;
		((TextBoxBase)txtMa_lo).BackColor = SystemColors.Info;
		((TextBox)txtMa_lo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox34 = txtMa_lo;
		location = new Point(160, 403);
		((Control)asTextBox34).Location = location;
		txtMa_lo.LookupCodeName = "MA_LO";
		((Control)txtMa_lo).Name = "txtMa_lo";
		txtMa_lo.NameControl = lblTen_lo;
		AsTextBox asTextBox35 = txtMa_lo;
		size = new Size(90, 20);
		((Control)asTextBox35).Size = size;
		((Control)txtMa_lo).TabIndex = 19;
		((Control)txtMa_lo).Tag = "MA_LO";
		txtMa_lo.UseAutoCompleteSource = true;
		lblMaLo.AutoSize = true;
		Label obj104 = lblMaLo;
		location = new Point(25, 407);
		((Control)obj104).Location = location;
		((Control)lblMaLo).Name = "lblMaLo";
		Label obj105 = lblMaLo;
		size = new Size(33, 13);
		((Control)obj105).Size = size;
		((Control)lblMaLo).TabIndex = 1379;
		lblMaLo.Text = "Mã lô";
		TextBox obj106 = txtSo_Ct2;
		location = new Point(331, 139);
		((Control)obj106).Location = location;
		((Control)txtSo_Ct2).Name = "txtSo_Ct2";
		TextBox obj107 = txtSo_Ct2;
		size = new Size(94, 20);
		((Control)obj107).Size = size;
		((Control)txtSo_Ct2).TabIndex = 8;
		TextBox obj108 = txtSo_Ct1;
		location = new Point(160, 139);
		((Control)obj108).Location = location;
		((Control)txtSo_Ct1).Name = "txtSo_Ct1";
		TextBox obj109 = txtSo_Ct1;
		size = new Size(90, 20);
		((Control)obj109).Size = size;
		((Control)txtSo_Ct1).TabIndex = 7;
		lblSo_Ct2.AutoSize = true;
		Label obj110 = lblSo_Ct2;
		location = new Point(277, 142);
		((Control)obj110).Location = location;
		((Control)lblSo_Ct2).Name = "lblSo_Ct2";
		Label obj111 = lblSo_Ct2;
		size = new Size(40, 13);
		((Control)obj111).Size = size;
		((Control)lblSo_Ct2).TabIndex = 1385;
		lblSo_Ct2.Text = "đến số";
		lblSo_Ct1.AutoSize = true;
		Label obj112 = lblSo_Ct1;
		location = new Point(25, 142);
		((Control)obj112).Location = location;
		((Control)lblSo_Ct1).Name = "lblSo_Ct1";
		Label obj113 = lblSo_Ct1;
		size = new Size(64, 13);
		((Control)obj113).Size = size;
		((Control)lblSo_Ct1).TabIndex = 1384;
		lblSo_Ct1.Text = "Chứng từ số";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(1037, 615);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmINRptTHN02";
		((Form)this).Text = "frmINRptTHN02";
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
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		base.InitOtherComponents();
		ComboBox val = cboLoai_pn;
		val.DataSource = AsiaErp.Framework.Environment.GetDanhSachChungTuNhap();
		((ListControl)val).ValueMember = "Key";
		((ListControl)val).DisplayMember = "Value";
		val.SelectedIndex = 0;
		val = null;
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		ComboBox val2 = cboDVT;
		dictionary.Add("0", Conversions.ToString(val2.Items[0]));
		dictionary.Add("1", Conversions.ToString(val2.Items[1]));
		dictionary.Add("2", Conversions.ToString(val2.Items[2]));
		dictionary.Add("3", Conversions.ToString(val2.Items[3]));
		BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
		val2.DataSource = dataSource;
		((ListControl)val2).DisplayMember = "value";
		((ListControl)val2).ValueMember = "key";
		val2.SelectedIndex = 0;
		val2 = null;
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		ComboBox val3 = cboNhom_theo;
		dictionary2.Add("MA_KH", Conversions.ToString(val3.Items[0]));
		dictionary2.Add("MA_HD", Conversions.ToString(val3.Items[1]));
		dictionary2.Add("MA_SPCT", Conversions.ToString(val3.Items[2]));
		dictionary2.Add("MA_NX", Conversions.ToString(val3.Items[3]));
		dictionary2.Add("MA_VT", Conversions.ToString(val3.Items[4]));
		BindingSource dataSource2 = new BindingSource((object)dictionary2, (string)null);
		val3.DataSource = dataSource2;
		((ListControl)val3).DisplayMember = "value";
		((ListControl)val3).ValueMember = "key";
		val3.SelectedIndex = 0;
		val3 = null;
		Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
		ComboBox val4 = cboChitiet;
		dictionary3.Add("MA_VT", Conversions.ToString(val4.Items[0]));
		dictionary3.Add("MA_KH", Conversions.ToString(val4.Items[1]));
		dictionary3.Add("MA_HD", Conversions.ToString(val4.Items[2]));
		dictionary3.Add("MA_NX", Conversions.ToString(val4.Items[3]));
		dictionary3.Add("MA_SPCT", Conversions.ToString(val4.Items[4]));
		BindingSource dataSource3 = new BindingSource((object)dictionary3, (string)null);
		val4.DataSource = dataSource3;
		((ListControl)val4).DisplayMember = "value";
		((ListControl)val4).ValueMember = "key";
		val4.SelectedIndex = 0;
		val4 = null;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(txtSo_Ct1.Text);
		arrayList.Add(txtSo_Ct2.Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboNhom_theo).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboChitiet).SelectedValue));
		arrayList.Add(((TextBox)txtMa_ncc).Text);
		arrayList.Add(((TextBox)txtMa_nh_ncc).Text);
		arrayList.Add(((TextBox)txtPl_ncc1).Text);
		arrayList.Add(((TextBox)txtPl_ncc2).Text);
		arrayList.Add(((TextBox)txtPl_ncc3).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_pn).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_gd).SelectedValue));
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_vitri).Text);
		arrayList.Add(((TextBox)txtMa_bp).Text);
		arrayList.Add(((TextBox)txtMa_spct).Text);
		arrayList.Add(((TextBox)txtTK_vt).Text);
		arrayList.Add(((TextBox)txtTK_du).Text);
		arrayList.Add(((TextBox)txtMa_nh_vt).Text);
		arrayList.Add(chkPS_dc.TextValue);
		arrayList.Add(((TextBox)txtMa_nx).Text);
		arrayList.Add(((TextBox)txtMa_lo).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Phi).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboDVT).SelectedValue));
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		base.MyFomularFields.Add("detailsType", RuntimeHelpers.GetObjectValue(((ListControl)cboChitiet).SelectedValue));
		return true;
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
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
			goto IL_085d;
		}
		if (Operators.CompareString(base.MyReportInfo.ma_mau, "01", false) == 0)
		{
			if ((int)keycode != 116 || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false), (object)"", false) ? true : false))
			{
				base.CancelDrilldown = true;
				result = null;
			}
			else
			{
				ArrayList arrayList = new ArrayList();
				arrayList.Add(CompanyInformations.CompanyID);
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
				arrayList.Add(((TextBox)txtMa_vt).Text);
				arrayList.Add(((TextBox)txtMa_kho).Text);
				arrayList.Add("");
				arrayList.Add(((TextBox)txtMa_vitri).Text);
				arrayList.Add(((TextBox)txtMa_ncc).Text);
				arrayList.Add(((TextBox)txtMa_bp).Text);
				arrayList.Add(((TextBox)txtMa_hd).Text);
				arrayList.Add(((TextBox)txtTK_du).Text);
				arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_pn).SelectedValue));
				arrayList.Add("1");
				arrayList.Add(chkPS_dc.TextValue);
				arrayList.Add(((TextBox)txtMa_nh_ncc).Text);
				arrayList.Add(((TextBox)txtMa_nx).Text);
				arrayList.Add(((TextBox)txtMa_nh_vt).Text);
				arrayList.Add(((TextBox)txtTK_vt).Text);
				arrayList.Add(((TextBox)txtMa_spct).Text);
				arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_gd).SelectedValue));
				base.MyFomularFields.Clear();
				base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
				if (!base.MyFomularFields.Contains("ngay_ct2"))
				{
					base.MyFomularFields.Add("ngay_ct2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
				}
				if (!base.MyFomularFields.Contains("ngay_ct1"))
				{
					base.MyFomularFields.Add("ngay_ct1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
				}
				result = arrayList;
			}
		}
		else if (Conversions.ToBoolean((Conversions.ToBoolean((object)((int)keycode != 116)) || Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false), (object)"", false), Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false), (object)"", false)))) ? ((object)true) : ((object)false)))
		{
			base.CancelDrilldown = true;
			result = null;
		}
		else
		{
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(CompanyInformations.CompanyID);
			arrayList2.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList2.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			arrayList2.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboNhom_theo).SelectedValue));
			arrayList2.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboChitiet).SelectedValue));
			if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom_theo).SelectedValue, (object)"MA_KH", false))
			{
				arrayList2.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
			}
			else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChitiet).SelectedValue, (object)"MA_KH", false))
			{
				arrayList2.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
			}
			else
			{
				arrayList2.Add(((TextBox)txtMa_ncc).Text);
			}
			arrayList2.Add(((TextBox)txtMa_nh_ncc).Text);
			arrayList2.Add(((TextBox)txtPl_ncc1).Text);
			arrayList2.Add(((TextBox)txtPl_ncc2).Text);
			arrayList2.Add(((TextBox)txtPl_ncc3).Text);
			arrayList2.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_pn).SelectedValue));
			if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom_theo).SelectedValue, (object)"MA_HD", false))
			{
				arrayList2.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
			}
			else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChitiet).SelectedValue, (object)"MA_HD", false))
			{
				arrayList2.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
			}
			else
			{
				arrayList2.Add(((TextBox)txtMa_hd).Text);
			}
			if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom_theo).SelectedValue, (object)"MA_VT", false))
			{
				arrayList2.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
			}
			else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChitiet).SelectedValue, (object)"MA_VT", false))
			{
				arrayList2.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
			}
			else
			{
				arrayList2.Add(((TextBox)txtMa_vt).Text);
			}
			arrayList2.Add(((TextBox)txtMa_kho).Text);
			arrayList2.Add(((TextBox)txtMa_vitri).Text);
			arrayList2.Add(((TextBox)txtMa_bp).Text);
			if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom_theo).SelectedValue, (object)"MA_SPCT", false))
			{
				arrayList2.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
			}
			else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChitiet).SelectedValue, (object)"MA_SPCT", false))
			{
				arrayList2.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
			}
			else
			{
				arrayList2.Add(((TextBox)txtMa_spct).Text);
			}
			arrayList2.Add(((TextBox)txtTK_vt).Text);
			arrayList2.Add(((TextBox)txtTK_du).Text);
			arrayList2.Add(((TextBox)txtMa_nh_vt).Text);
			arrayList2.Add(chkPS_dc.TextValue);
			if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNhom_theo).SelectedValue, (object)"MA_NX", false))
			{
				arrayList2.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false)));
			}
			else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboChitiet).SelectedValue, (object)"MA_NX", false))
			{
				arrayList2.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_Detail"]), isNum: false)));
			}
			else
			{
				arrayList2.Add(((TextBox)txtMa_nx).Text);
			}
			arrayList2.Add(((TextBox)txtMa_Nt).Text);
			arrayList2.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboDVT).SelectedValue));
			arrayList2.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_gd).SelectedValue));
			if (Information.IsDBNull((object)arrayList2))
			{
				base.CancelDrilldown = true;
				result = null;
			}
			else
			{
				base.MyFomularFields.Clear();
				base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
				filterCondition4title = dataRowView["ma_group"].ToString() + " - " + dataRowView["ma_Detail"].ToString();
				result = arrayList2;
			}
		}
		goto IL_085d;
		IL_085d:
		return result;
	}

	private string GetFilterTitle()
	{
		string text = "";
		text = text + lblNhom_theo.Text + ": [" + cboNhom_theo.Text + "]; ";
		text = text + lblChitiet.Text + ": [" + cboChitiet.Text + "]; ";
		text = text + lblLoai_pn.Text + ": [" + cboLoai_pn.Text + "]; ";
		if (Operators.CompareString(((TextBox)txtMa_ncc).Text, "", false) != 0)
		{
			text = text + lblMa_ncc.Text + ": [" + ((TextBox)txtMa_ncc).Text + " - " + lblTen_ncc.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nh_ncc).Text, "", false) != 0)
		{
			text = text + lblMa_nh_ncc.Text + ": [" + ((TextBox)txtMa_nh_ncc).Text + " - " + lblTen_nh_ncc.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtPl_ncc1).Text, "", false) != 0)
		{
			text = text + lblPl_ncc1.Text + ": [" + ((TextBox)txtPl_ncc1).Text + " - " + lblTen_pl_ncc1.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtPl_ncc2).Text, "", false) != 0)
		{
			text = text + lblPl_ncc2.Text + ": [" + ((TextBox)txtPl_ncc2).Text + " - " + lblTen_pl_ncc2.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtPl_ncc3).Text, "", false) != 0)
		{
			text = text + lblPl_ncc3.Text + ": [" + ((TextBox)txtPl_ncc3).Text + " - " + lblTen_pl_ncc3.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
		{
			text = text + lblMa_vt.Text + ": [" + ((TextBox)txtMa_vt).Text + " - " + lblTen_vt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nh_vt).Text, "", false) != 0)
		{
			text = text + lblMa_nh_vt.Text + ": [" + ((TextBox)txtMa_nh_vt).Text + " - " + lblTen_nh_vt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtTK_vt).Text, "", false) != 0)
		{
			text = text + lblTK_vt.Text + ": [" + ((TextBox)txtTK_vt).Text + " - " + lblTen_tk_vt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text, "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": [" + ((TextBox)txtMa_kho).Text + " - " + lblTen_kho.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vitri).Text, "", false) != 0)
		{
			text = text + lblMa_vitri.Text + ": " + ((TextBox)txtMa_vitri).Text + " - " + lblTen_vitri.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_hd).Text, "", false) != 0)
		{
			text = text + lblMa_hd.Text + ": [" + ((TextBox)txtMa_hd).Text + " - " + lblTen_hd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nx).Text, "", false) != 0)
		{
			text = text + lblMa_nx.Text + ": [" + ((TextBox)txtMa_nx).Text + " - " + lblTen_nx.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtTK_du).Text, "", false) != 0)
		{
			text = text + lblTK_du.Text + ": [" + ((TextBox)txtTK_du).Text + " - " + lblTen_tk_du.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_bp).Text, "", false) != 0)
		{
			text = text + lblMa_bp.Text + ": [" + ((TextBox)txtMa_bp).Text + " - " + lblTen_bp.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_spct).Text, "", false) != 0)
		{
			text = text + lblMa_spct.Text + ": [" + ((TextBox)txtMa_spct).Text + " - " + lblTen_spct.Text + "]; ";
		}
		if (Operators.CompareString(cboDVT.Text, "", false) != 0)
		{
			text = text + lblDVT.Text + ": [" + cboDVT.Text + " - " + lblDVT.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": [" + ((TextBox)txtMa_Nt).Text + "]; ";
		}
		return text;
	}

	private bool CheckDataSoucreCB()
	{
		bool result = false;
		if ((cboNhom_theo.Items.Count > 0) & (cboChitiet.Items.Count > 0))
		{
			result = true;
		}
		return result;
	}

	private void SetDataSourceToCmb(ComboBox combobox, ArrayList ar, string member, string value)
	{
		ArrayList arrayList = new ArrayList();
		DmMaGd dmMaGd = new DmMaGd();
		dmMaGd.ma_ct = ((ListControl)cboLoai_pn).SelectedValue.ToString();
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

	private void cboLoai_pn_SelectedValueChanged(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			SetDataSourceToCmb(cboLoai_gd, AsiaErp.Framework.Environment.GetDmMagd(((ListControl)cboLoai_pn).SelectedValue.ToString()), "mo_ta", "ma_gd");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void cboNhom_theo_SelectedValueChanged(object sender, EventArgs e)
	{
		checked
		{
			if (((ListControl)cboNhom_theo).SelectedValue == ((ListControl)cboChitiet).SelectedValue)
			{
				if (cboChitiet.SelectedIndex == cboChitiet.Items.Count - 1)
				{
					cboChitiet.SelectedIndex = 0;
					return;
				}
				ComboBox val = cboChitiet;
				val.SelectedIndex += 1;
			}
		}
	}

	private void cboChitiet_SelectedValueChanged(object sender, EventArgs e)
	{
		checked
		{
			if (((ListControl)cboNhom_theo).SelectedValue == ((ListControl)cboChitiet).SelectedValue)
			{
				if (cboNhom_theo.SelectedIndex == cboNhom_theo.Items.Count - 1)
				{
					cboNhom_theo.SelectedIndex = 0;
					return;
				}
				ComboBox val = cboNhom_theo;
				val.SelectedIndex += 1;
			}
		}
	}
}
