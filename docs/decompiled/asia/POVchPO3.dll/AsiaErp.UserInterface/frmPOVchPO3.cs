using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.POUtilities;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmPOVchPO3 : frmVoucher
{
	[CompilerGenerated]
	internal class _Closure_0024__1
	{
		public double _0024VB_0024Local_ts_gtgt;

		public frmPOVchPO3 _0024VB_0024Me;

		[DebuggerNonUserCode]
		public _Closure_0024__1(_Closure_0024__1 other)
		{
			if (other != null)
			{
				_0024VB_0024Local_ts_gtgt = other._0024VB_0024Local_ts_gtgt;
				_0024VB_0024Me = other._0024VB_0024Me;
			}
		}

		[DebuggerNonUserCode]
		public _Closure_0024__1()
		{
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("lblNguoi_Gd")]
	private Label _lblNguoi_Gd;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("txtNguoi_Gd")]
	private TextBox _txtNguoi_Gd;

	[AccessedThroughProperty("lblDien_giai")]
	private Label _lblDien_giai;

	[AccessedThroughProperty("txtNgay_lct")]
	private AsMaskedTextBox _txtNgay_lct;

	[AccessedThroughProperty("lblNgay_Lct")]
	private Label _lblNgay_Lct;

	[AccessedThroughProperty("txtTy_gia")]
	private AsTextNumeric _txtTy_gia;

	[AccessedThroughProperty("cboMa_NT")]
	private AsComboBoxNT _cboMa_NT;

	[AccessedThroughProperty("lblMa_Nt")]
	private Label _lblMa_Nt;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("tabChi_phi")]
	private TabPage _tabChi_phi;

	[AccessedThroughProperty("adgvDetail")]
	private AsInputDGV _adgvDetail;

	[AccessedThroughProperty("tabHach_toan")]
	private TabPage _tabHach_toan;

	[AccessedThroughProperty("lblTen_httt")]
	private Label _lblTen_httt;

	[AccessedThroughProperty("txtMa_Httt")]
	private AsTextBox _txtMa_Httt;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("tabTain")]
	private TabPage _tabTain;

	[AccessedThroughProperty("txtT_thue_Nt")]
	private AsTextNumeric _txtT_thue_Nt;

	[AccessedThroughProperty("txtT_Thue")]
	private AsTextNumeric _txtT_Thue;

	[AccessedThroughProperty("txtT_tt")]
	private AsTextNumeric _txtT_tt;

	[AccessedThroughProperty("txtT_tt_nt")]
	private AsTextNumeric _txtT_tt_nt;

	[AccessedThroughProperty("txtT_cp_nt")]
	private AsTextNumeric _txtT_cp_nt;

	[AccessedThroughProperty("txtT_Tien_nt0")]
	private AsTextNumeric _txtT_Tien_nt0;

	[AccessedThroughProperty("txtT_Tien0")]
	private AsTextNumeric _txtT_Tien0;

	[AccessedThroughProperty("txtT_cp")]
	private AsTextNumeric _txtT_cp;

	[AccessedThroughProperty("txtT_So_luong")]
	private AsTextNumeric _txtT_So_luong;

	[AccessedThroughProperty("lblT_Thue")]
	private Label _lblT_Thue;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("txtSo_hd")]
	private TextBox _txtSo_hd;

	[AccessedThroughProperty("txtNgay_hd")]
	private AsMaskedTextBox _txtNgay_hd;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("cmdPhan_bo")]
	private Button _cmdPhan_bo;

	[AccessedThroughProperty("adgvHach_toan")]
	private AsInputDGV _adgvHach_toan;

	[AccessedThroughProperty("txtTk_thue")]
	private AsTextBox _txtTk_thue;

	[AccessedThroughProperty("lblTk_thue")]
	private Label _lblTk_thue;

	[AccessedThroughProperty("lblTk_pt")]
	private Label _lblTk_pt;

	[AccessedThroughProperty("txtTk_pt")]
	private AsTextBox _txtTk_pt;

	[AccessedThroughProperty("adgvChi_phi")]
	private AsInputDGV _adgvChi_phi;

	[AccessedThroughProperty("txtT_tien_nt")]
	private AsTextNumeric _txtT_tien_nt;

	[AccessedThroughProperty("txtT_Tien")]
	private AsTextNumeric _txtT_Tien;

	[AccessedThroughProperty("ctlTaIn")]
	private ctlTaIn _ctlTaIn;

	[AccessedThroughProperty("cmdGetTaInFromDetail")]
	private Button _cmdGetTaInFromDetail;

	[AccessedThroughProperty("txtT_tt_nt_cp")]
	private AsTextNumeric _txtT_tt_nt_cp;

	[AccessedThroughProperty("txtT_thue_nt_cp")]
	private AsTextNumeric _txtT_thue_nt_cp;

	[AccessedThroughProperty("txtT_Tien_Cp_nt_Cp")]
	private AsTextNumeric _txtT_Tien_Cp_nt_Cp;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("bsTT_PB")]
	private BindingSource _bsTT_PB;

	[AccessedThroughProperty("dgvcMa_chiphi")]
	private DataGridViewAsTextBoxColumn _dgvcMa_chiphi;

	[AccessedThroughProperty("dgvcTT_PB")]
	private DataGridViewComboBoxColumn _dgvcTT_PB;

	[AccessedThroughProperty("dgvcTen_chi_phi")]
	private DataGridViewTextBoxColumn _dgvcTen_chi_phi;

	[AccessedThroughProperty("dgvcTien_cp_nt_cp")]
	private DataGridViewAsTextNumericColumn _dgvcTien_cp_nt_cp;

	[AccessedThroughProperty("dgvcTs_gtgt_cp")]
	private DataGridViewAsTextNumericColumn _dgvcTs_gtgt_cp;

	[AccessedThroughProperty("dgvcThue_gtgt_nt_cp")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt_nt_cp;

	[AccessedThroughProperty("dgvcTt_nt_Cp")]
	private DataGridViewAsTextNumericColumn _dgvcTt_nt_Cp;

	[AccessedThroughProperty("dgvcTien_cp_cp")]
	private DataGridViewAsTextNumericColumn _dgvcTien_cp_cp;

	[AccessedThroughProperty("dgvcThue_Gtgt_cp")]
	private DataGridViewAsTextNumericColumn _dgvcThue_Gtgt_cp;

	[AccessedThroughProperty("dgvcTt_Cp")]
	private DataGridViewAsTextNumericColumn _dgvcTt_Cp;

	[AccessedThroughProperty("dgvcMa_bp_cp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_bp_cp;

	[AccessedThroughProperty("dgvcMa_phi_cp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_phi_cp;

	[AccessedThroughProperty("dgvcMa_spct_cp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_spct_cp;

	[AccessedThroughProperty("dgvcMa_lo_cp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_lo_cp;

	[AccessedThroughProperty("sCChiPhi")]
	private SplitContainer _sCChiPhi;

	[AccessedThroughProperty("lblDia_chi")]
	private Label _lblDia_chi;

	[AccessedThroughProperty("txtDia_chi")]
	private TextBox _txtDia_chi;

	[AccessedThroughProperty("lblMa_so_thue")]
	private Label _lblMa_so_thue;

	[AccessedThroughProperty("txtMa_so_thue")]
	private TextBox _txtMa_so_thue;

	[AccessedThroughProperty("SplitContainer1")]
	private SplitContainer _SplitContainer1;

	[AccessedThroughProperty("cmdThanh_toan")]
	private Button _cmdThanh_toan;

	[AccessedThroughProperty("txtTl_ck_hd")]
	private AsTextNumeric _txtTl_ck_hd;

	[AccessedThroughProperty("txtT_ck")]
	private AsTextNumeric _txtT_ck;

	[AccessedThroughProperty("txtT_ck_nt")]
	private AsTextNumeric _txtT_ck_nt;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("chkCk_st")]
	private AsCheckBox _chkCk_st;

	[AccessedThroughProperty("dgvcTen_vt_ht")]
	private DataGridViewTextBoxColumn _dgvcTen_vt_ht;

	[AccessedThroughProperty("dgvcTien_nt0_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt0_ht;

	[AccessedThroughProperty("dgvcCk_nt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcCk_nt_ht;

	[AccessedThroughProperty("dgvcCp_Nt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcCp_Nt_ht;

	[AccessedThroughProperty("dgvcTien_nt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt_ht;

	[AccessedThroughProperty("dgvcTien0_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien0_ht;

	[AccessedThroughProperty("dgvcCk_ht")]
	private DataGridViewAsTextNumericColumn _dgvcCk_ht;

	[AccessedThroughProperty("dgvcCp_ht")]
	private DataGridViewAsTextNumericColumn _dgvcCp_ht;

	[AccessedThroughProperty("dgvcTien_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_ht;

	[AccessedThroughProperty("dgvcTk_vt")]
	private DataGridViewAsTextBoxColumn _dgvcTk_vt;

	[AccessedThroughProperty("dgvcTk_co")]
	private DataGridViewTextBoxColumn _dgvcTk_co;

	[AccessedThroughProperty("dgvcMa_vt_ht")]
	private DataGridViewTextBoxColumn _dgvcMa_vt_ht;

	[AccessedThroughProperty("dgvcMa_vt")]
	private DataGridViewAsTextBoxColumn _dgvcMa_vt;

	[AccessedThroughProperty("dgvcTen_vt")]
	private DataGridViewTextBoxColumn _dgvcTen_vt;

	[AccessedThroughProperty("dgvcDvt")]
	private DataGridViewTextBoxColumn _dgvcDvt;

	[AccessedThroughProperty("dgvcMa_kho")]
	private DataGridViewAsTextBoxColumn _dgvcMa_kho;

	[AccessedThroughProperty("dgvcTon")]
	private DataGridViewAsTextNumericColumn _dgvcTon;

	[AccessedThroughProperty("dgvcSo_luong")]
	private DataGridViewAsTextNumericColumn _dgvcSo_luong;

	[AccessedThroughProperty("dgvcGia_nt0")]
	private DataGridViewAsTextNumericColumn _dgvcGia_nt0;

	[AccessedThroughProperty("dgvcTien_nt0")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt0;

	[AccessedThroughProperty("dgvcTl_ck")]
	private DataGridViewAsTextNumericColumn _dgvcTl_ck;

	[AccessedThroughProperty("dgvcCk_nt")]
	private DataGridViewAsTextNumericColumn _dgvcCk_nt;

	[AccessedThroughProperty("dgvcTien_cp_nt")]
	private DataGridViewAsTextNumericColumn _dgvcTien_cp_nt;

	[AccessedThroughProperty("dgvcTs_gtgt")]
	private DataGridViewAsTextNumericColumn _dgvcTs_gtgt;

	[AccessedThroughProperty("dgvcThue_gtgt_nt")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt_nt;

	[AccessedThroughProperty("dgvcGia0")]
	private DataGridViewAsTextNumericColumn _dgvcGia0;

	[AccessedThroughProperty("dgvcTien0")]
	private DataGridViewAsTextNumericColumn _dgvcTien0;

	[AccessedThroughProperty("dgvcCk")]
	private DataGridViewAsTextNumericColumn _dgvcCk;

	[AccessedThroughProperty("dgvcTien_cp")]
	private DataGridViewAsTextNumericColumn _dgvcTien_cp;

	[AccessedThroughProperty("dgvcThue_gtgt")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt;

	[AccessedThroughProperty("cmdChon_dh")]
	private Button _cmdChon_dh;

	private const string HOA_DON_KIEM_PHIEU_NHAP = "1";

	private const string HOA_DON_MUA_HANG_TRONG_NUOC = "2";

	private string f_sGia_header;

	private string f_sTien0_header;

	private string f_sTien_header;

	private string f_sTien0_cp_header;

	private string f_sChi_phi_header;

	private string f_sThue_header;

	private string f_sCk_header;

	private string f_sMa_Gd_Default;

	private bool hasVATinDetal;

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
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_Kh_AfterCodeValidating;
			if (_txtMa_Kh != null)
			{
				_txtMa_Kh.AfterCodeValidating -= obj;
			}
			_txtMa_Kh = value;
			if (_txtMa_Kh != null)
			{
				_txtMa_Kh.AfterCodeValidating += obj;
			}
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

	internal virtual Label lblNguoi_Gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguoi_Gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguoi_Gd = value;
		}
	}

	internal virtual TextBox txtDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDien_giai = value;
		}
	}

	internal virtual TextBox txtNguoi_Gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNguoi_Gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNguoi_Gd = value;
		}
	}

	internal virtual Label lblDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDien_giai = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_lct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_lct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_lct = value;
		}
	}

	internal virtual Label lblNgay_Lct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_Lct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_Lct = value;
		}
	}

	private virtual AsTextNumeric txtTy_gia
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
			EventHandler eventHandler = txtTy_gia_Validated;
			if (_txtTy_gia != null)
			{
				((Control)_txtTy_gia).Validated -= eventHandler;
			}
			_txtTy_gia = value;
			if (_txtTy_gia != null)
			{
				((Control)_txtTy_gia).Validated += eventHandler;
			}
		}
	}

	private virtual AsComboBoxNT cboMa_NT
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboMa_NT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboMa_NT_SelectedValueChanged;
			if (_cboMa_NT != null)
			{
				((ListControl)_cboMa_NT).SelectedValueChanged -= eventHandler;
			}
			_cboMa_NT = value;
			if (_cboMa_NT != null)
			{
				((ListControl)_cboMa_NT).SelectedValueChanged += eventHandler;
			}
		}
	}

	private virtual Label lblMa_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nt = value;
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

	internal virtual TabPage tabChi_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabChi_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabChi_phi = value;
		}
	}

	internal virtual AsInputDGV adgvDetail
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvDetail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			DataGridViewCellValidatingEventHandler val = new DataGridViewCellValidatingEventHandler(adgvDetail_CellValidating);
			AsInputDGV.SetDependentFieldsWhenCellValueChangedHandler obj = adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged;
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvDetail_CellEnter);
			DataGridViewCellEventHandler val3 = new DataGridViewCellEventHandler(adgvDetail_CellValueChanged);
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellValidating -= val;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged -= obj;
				((DataGridView)_adgvDetail).CellEnter -= val2;
				((DataGridView)_adgvDetail).CellValueChanged -= val3;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellValidating += val;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged += obj;
				((DataGridView)_adgvDetail).CellEnter += val2;
				((DataGridView)_adgvDetail).CellValueChanged += val3;
			}
		}
	}

	internal virtual TabPage tabHach_toan
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabHach_toan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabHach_toan = value;
		}
	}

	internal virtual Label lblTen_httt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_httt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_httt = value;
		}
	}

	internal virtual AsTextBox txtMa_Httt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Httt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_Httt_AfterCodeValidating;
			if (_txtMa_Httt != null)
			{
				_txtMa_Httt.AfterCodeValidating -= obj;
			}
			_txtMa_Httt = value;
			if (_txtMa_Httt != null)
			{
				_txtMa_Httt.AfterCodeValidating += obj;
			}
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

	internal virtual TabPage tabTain
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabTain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabTain = value;
		}
	}

	internal virtual AsTextNumeric txtT_thue_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_thue_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_thue_Nt = value;
		}
	}

	internal virtual AsTextNumeric txtT_Thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Thue = value;
		}
	}

	internal virtual AsTextNumeric txtT_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tt = value;
		}
	}

	internal virtual AsTextNumeric txtT_tt_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tt_nt = value;
		}
	}

	internal virtual AsTextNumeric txtT_cp_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_cp_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_cp_nt = value;
		}
	}

	internal virtual AsTextNumeric txtT_Tien_nt0
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Tien_nt0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Tien_nt0 = value;
		}
	}

	internal virtual AsTextNumeric txtT_Tien0
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Tien0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Tien0 = value;
		}
	}

	internal virtual AsTextNumeric txtT_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_cp = value;
		}
	}

	internal virtual AsTextNumeric txtT_So_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_So_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_So_luong = value;
		}
	}

	internal virtual Label lblT_Thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_Thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_Thue = value;
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

	protected internal virtual Label Label6
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

	protected internal virtual TextBox txtSo_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_hd = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_hd = value;
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

	internal virtual Button cmdPhan_bo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPhan_bo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdPhan_bo_Click;
			if (_cmdPhan_bo != null)
			{
				((Control)_cmdPhan_bo).Click -= eventHandler;
			}
			_cmdPhan_bo = value;
			if (_cmdPhan_bo != null)
			{
				((Control)_cmdPhan_bo).Click += eventHandler;
			}
		}
	}

	internal virtual AsInputDGV adgvHach_toan
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvHach_toan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvHach_toan = value;
		}
	}

	internal virtual AsTextBox txtTk_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_thue = value;
		}
	}

	internal virtual Label lblTk_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_thue = value;
		}
	}

	internal virtual Label lblTk_pt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_pt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_pt = value;
		}
	}

	internal virtual AsTextBox txtTk_pt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_pt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_pt = value;
		}
	}

	internal virtual AsInputDGV adgvChi_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvChi_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			AsInputDGV.AsDataGridViewCmdKeyPressEventHandler obj = adgvChi_phi_MyProcessCmdKey;
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvChi_phi_CellValueChanged);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvChi_phi_CellEnter);
			if (_adgvChi_phi != null)
			{
				_adgvChi_phi.MyProcessCmdKey -= obj;
				((DataGridView)_adgvChi_phi).CellValueChanged -= val;
				((DataGridView)_adgvChi_phi).CellEnter -= val2;
			}
			_adgvChi_phi = value;
			if (_adgvChi_phi != null)
			{
				_adgvChi_phi.MyProcessCmdKey += obj;
				((DataGridView)_adgvChi_phi).CellValueChanged += val;
				((DataGridView)_adgvChi_phi).CellEnter += val2;
			}
		}
	}

	internal virtual AsTextNumeric txtT_tien_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tien_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tien_nt = value;
		}
	}

	internal virtual AsTextNumeric txtT_Tien
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Tien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Tien = value;
		}
	}

	internal virtual ctlTaIn ctlTaIn
	{
		[DebuggerNonUserCode]
		get
		{
			return _ctlTaIn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			ctlTaIn.TAINValueChangedEventHandler obj = ctlTaIn_TAINValueChanged;
			if (_ctlTaIn != null)
			{
				_ctlTaIn.TAINValueChanged -= obj;
			}
			_ctlTaIn = value;
			if (_ctlTaIn != null)
			{
				_ctlTaIn.TAINValueChanged += obj;
			}
		}
	}

	internal virtual Button cmdGetTaInFromDetail
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdGetTaInFromDetail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdGetTaInFromDetail_Click;
			if (_cmdGetTaInFromDetail != null)
			{
				((Control)_cmdGetTaInFromDetail).Click -= eventHandler;
			}
			_cmdGetTaInFromDetail = value;
			if (_cmdGetTaInFromDetail != null)
			{
				((Control)_cmdGetTaInFromDetail).Click += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtT_tt_nt_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tt_nt_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tt_nt_cp = value;
		}
	}

	internal virtual AsTextNumeric txtT_thue_nt_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_thue_nt_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_thue_nt_cp = value;
		}
	}

	internal virtual AsTextNumeric txtT_Tien_Cp_nt_Cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Tien_Cp_nt_Cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Tien_Cp_nt_Cp = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual Label Label12
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

	internal virtual BindingSource bsTT_PB
	{
		[DebuggerNonUserCode]
		get
		{
			return _bsTT_PB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_bsTT_PB = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_chiphi
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_chiphi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_chiphi = value;
		}
	}

	internal virtual DataGridViewComboBoxColumn dgvcTT_PB
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTT_PB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTT_PB = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_chi_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_chi_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_chi_phi = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_cp_nt_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_cp_nt_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_cp_nt_cp = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTs_gtgt_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTs_gtgt_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTs_gtgt_cp = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_gtgt_nt_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_gtgt_nt_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_gtgt_nt_cp = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTt_nt_Cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTt_nt_Cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTt_nt_Cp = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_cp_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_cp_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_cp_cp = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_Gtgt_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_Gtgt_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_Gtgt_cp = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTt_Cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTt_Cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTt_Cp = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_bp_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_bp_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_bp_cp = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_phi_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_phi_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_phi_cp = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_spct_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_spct_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_spct_cp = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_lo_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_lo_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_lo_cp = value;
		}
	}

	internal virtual SplitContainer sCChiPhi
	{
		[DebuggerNonUserCode]
		get
		{
			return _sCChiPhi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_sCChiPhi = value;
		}
	}

	internal virtual Label lblDia_chi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDia_chi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDia_chi = value;
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

	internal virtual Label lblMa_so_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_so_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_so_thue = value;
		}
	}

	internal virtual TextBox txtMa_so_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_so_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_so_thue = value;
		}
	}

	internal virtual SplitContainer SplitContainer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SplitContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SplitContainer1 = value;
		}
	}

	internal virtual Button cmdThanh_toan
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdThanh_toan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdThanh_toan_Click;
			if (_cmdThanh_toan != null)
			{
				((Control)_cmdThanh_toan).Click -= eventHandler;
			}
			_cmdThanh_toan = value;
			if (_cmdThanh_toan != null)
			{
				((Control)_cmdThanh_toan).Click += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtTl_ck_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTl_ck_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = txtTl_ck_hd_ValueChanged;
			if (_txtTl_ck_hd != null)
			{
				_txtTl_ck_hd.ValueChanged -= obj;
			}
			_txtTl_ck_hd = value;
			if (_txtTl_ck_hd != null)
			{
				_txtTl_ck_hd.ValueChanged += obj;
			}
		}
	}

	internal virtual AsTextNumeric txtT_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = txtT_ck_ValueChanged;
			if (_txtT_ck != null)
			{
				_txtT_ck.ValueChanged -= obj;
			}
			_txtT_ck = value;
			if (_txtT_ck != null)
			{
				_txtT_ck.ValueChanged += obj;
			}
		}
	}

	internal virtual AsTextNumeric txtT_ck_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_ck_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = txtT_ck_nt_ValueChanged;
			if (_txtT_ck_nt != null)
			{
				_txtT_ck_nt.ValueChanged -= obj;
			}
			_txtT_ck_nt = value;
			if (_txtT_ck_nt != null)
			{
				_txtT_ck_nt.ValueChanged += obj;
			}
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

	protected virtual AsCheckBox chkCk_st
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkCk_st;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkCk_st_CheckedChanged;
			if (_chkCk_st != null)
			{
				((CheckBox)_chkCk_st).CheckedChanged -= eventHandler;
			}
			_chkCk_st = value;
			if (_chkCk_st != null)
			{
				((CheckBox)_chkCk_st).CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_vt_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_vt_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_vt_ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_nt0_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_nt0_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_nt0_ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcCk_nt_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCk_nt_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCk_nt_ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcCp_Nt_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCp_Nt_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCp_Nt_ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_nt_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_nt_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_nt_ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien0_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien0_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien0_ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcCk_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCk_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCk_ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcCp_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCp_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCp_ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_ht = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_vt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTk_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_co = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_vt_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_vt_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_vt_ht = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_vt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_vt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDvt = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_kho = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTon
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTon = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcSo_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_luong = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcGia_nt0
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcGia_nt0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcGia_nt0 = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_nt0
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_nt0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_nt0 = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTl_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTl_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTl_ck = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcCk_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCk_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCk_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_cp_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_cp_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_cp_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTs_gtgt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTs_gtgt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTs_gtgt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_gtgt_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_gtgt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_gtgt_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcGia0
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcGia0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcGia0 = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien0
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien0 = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcCk
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCk = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_cp = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_gtgt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_gtgt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_gtgt = value;
		}
	}

	internal virtual Button cmdChon_dh
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdChon_dh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdChon_dh_Click;
			if (_cmdChon_dh != null)
			{
				((Control)_cmdChon_dh).Click -= eventHandler;
			}
			_cmdChon_dh = value;
			if (_cmdChon_dh != null)
			{
				((Control)_cmdChon_dh).Click += eventHandler;
			}
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

	public frmPOVchPO3()
	{
		__ENCAddToList(this);
		f_sGia_header = "Gia";
		f_sTien0_header = "Tien";
		f_sTien_header = "Tien";
		f_sTien0_cp_header = "Tien";
		f_sChi_phi_header = "Chi phi";
		f_sThue_header = "VAT";
		f_sCk_header = "";
		f_sMa_Gd_Default = "1";
		hasVATinDetal = true;
		InitializeComponent();
	}

	public frmPOVchPO3(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_sGia_header = "Gia";
		f_sTien0_header = "Tien";
		f_sTien_header = "Tien";
		f_sTien0_cp_header = "Tien";
		f_sChi_phi_header = "Chi phi";
		f_sThue_header = "VAT";
		f_sCk_header = "";
		f_sMa_Gd_Default = "1";
		hasVATinDetal = true;
		InitializeComponent();
	}

	public frmPOVchPO3(string MenuID, string Stt_rec)
		: base(MenuID, Stt_rec)
	{
		__ENCAddToList(this);
		f_sGia_header = "Gia";
		f_sTien0_header = "Tien";
		f_sTien_header = "Tien";
		f_sTien0_cp_header = "Tien";
		f_sChi_phi_header = "Chi phi";
		f_sThue_header = "VAT";
		f_sCk_header = "";
		f_sMa_Gd_Default = "1";
		hasVATinDetal = true;
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected O, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected O, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected O, but got Unknown
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected O, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected O, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected O, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected O, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected O, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected O, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected O, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected O, but got Unknown
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected O, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected O, but got Unknown
		//IL_17de: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fb: Expected O, but got Unknown
		//IL_1b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b32: Expected O, but got Unknown
		//IL_1beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf5: Expected O, but got Unknown
		//IL_2607: Unknown result type (might be due to invalid IL or missing references)
		//IL_2611: Expected O, but got Unknown
		//IL_2771: Unknown result type (might be due to invalid IL or missing references)
		//IL_277b: Expected O, but got Unknown
		//IL_280f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2819: Expected O, but got Unknown
		//IL_28c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_28cc: Expected O, but got Unknown
		//IL_29a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b2: Expected O, but got Unknown
		//IL_2a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a57: Expected O, but got Unknown
		//IL_2b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b85: Expected O, but got Unknown
		//IL_2ce2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cec: Expected O, but got Unknown
		//IL_2da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2daf: Expected O, but got Unknown
		//IL_3958: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b1e: Expected O, but got Unknown
		//IL_3c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c3d: Expected O, but got Unknown
		//IL_3cf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d00: Expected O, but got Unknown
		//IL_4983: Unknown result type (might be due to invalid IL or missing references)
		//IL_4aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bfa: Expected O, but got Unknown
		//IL_4cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d02: Expected O, but got Unknown
		//IL_4e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e0a: Expected O, but got Unknown
		//IL_4f08: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f12: Expected O, but got Unknown
		//IL_5010: Unknown result type (might be due to invalid IL or missing references)
		//IL_501a: Expected O, but got Unknown
		//IL_5118: Unknown result type (might be due to invalid IL or missing references)
		//IL_5122: Expected O, but got Unknown
		//IL_521c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5226: Expected O, but got Unknown
		//IL_52ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_52d8: Expected O, but got Unknown
		//IL_5392: Unknown result type (might be due to invalid IL or missing references)
		//IL_539c: Expected O, but got Unknown
		//IL_548d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5497: Expected O, but got Unknown
		//IL_559a: Unknown result type (might be due to invalid IL or missing references)
		//IL_55a4: Expected O, but got Unknown
		//IL_565e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5668: Expected O, but got Unknown
		//IL_576f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5779: Expected O, but got Unknown
		//IL_5840: Unknown result type (might be due to invalid IL or missing references)
		//IL_584a: Expected O, but got Unknown
		//IL_5b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b8d: Expected O, but got Unknown
		//IL_5e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e50: Expected O, but got Unknown
		//IL_5f07: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f11: Expected O, but got Unknown
		//IL_5ff1: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ffb: Expected O, but got Unknown
		//IL_60e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_60f2: Expected O, but got Unknown
		//IL_61db: Unknown result type (might be due to invalid IL or missing references)
		//IL_61e5: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		DataGridViewCellStyle val9 = new DataGridViewCellStyle();
		DataGridViewCellStyle val10 = new DataGridViewCellStyle();
		DataGridViewCellStyle val11 = new DataGridViewCellStyle();
		DataGridViewCellStyle val12 = new DataGridViewCellStyle();
		DataGridViewCellStyle val13 = new DataGridViewCellStyle();
		DataGridViewCellStyle val14 = new DataGridViewCellStyle();
		DataGridViewCellStyle val15 = new DataGridViewCellStyle();
		DataGridViewCellStyle val16 = new DataGridViewCellStyle();
		DataGridViewCellStyle val17 = new DataGridViewCellStyle();
		DataGridViewCellStyle val18 = new DataGridViewCellStyle();
		DataGridViewCellStyle val19 = new DataGridViewCellStyle();
		DataGridViewCellStyle val20 = new DataGridViewCellStyle();
		DataGridViewCellStyle val21 = new DataGridViewCellStyle();
		DataGridViewCellStyle val22 = new DataGridViewCellStyle();
		DataGridViewCellStyle val23 = new DataGridViewCellStyle();
		DataGridViewCellStyle val24 = new DataGridViewCellStyle();
		DataGridViewCellStyle val25 = new DataGridViewCellStyle();
		DataGridViewCellStyle val26 = new DataGridViewCellStyle();
		DataGridViewCellStyle val27 = new DataGridViewCellStyle();
		DataGridViewCellStyle val28 = new DataGridViewCellStyle();
		DataGridViewCellStyle val29 = new DataGridViewCellStyle();
		DataGridViewCellStyle val30 = new DataGridViewCellStyle();
		DataGridViewCellStyle val31 = new DataGridViewCellStyle();
		DataGridViewCellStyle val32 = new DataGridViewCellStyle();
		DataGridViewCellStyle val33 = new DataGridViewCellStyle();
		DataGridViewCellStyle val34 = new DataGridViewCellStyle();
		DataGridViewCellStyle val35 = new DataGridViewCellStyle();
		DataGridViewCellStyle val36 = new DataGridViewCellStyle();
		DataGridViewCellStyle val37 = new DataGridViewCellStyle();
		DataGridViewCellStyle val38 = new DataGridViewCellStyle();
		DataGridViewCellStyle val39 = new DataGridViewCellStyle();
		DataGridViewCellStyle val40 = new DataGridViewCellStyle();
		DataGridViewCellStyle val41 = new DataGridViewCellStyle();
		DataGridViewCellStyle val42 = new DataGridViewCellStyle();
		DataGridViewCellStyle val43 = new DataGridViewCellStyle();
		DataGridViewCellStyle val44 = new DataGridViewCellStyle();
		DataGridViewCellStyle val45 = new DataGridViewCellStyle();
		DataGridViewCellStyle val46 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmPOVchPO3));
		txtMa_Kh = new AsTextBox();
		lblTen_Kh = new Label();
		lblMa_Kh = new Label();
		lblNguoi_Gd = new Label();
		txtDien_giai = new TextBox();
		txtNguoi_Gd = new TextBox();
		lblDien_giai = new Label();
		txtNgay_lct = new AsMaskedTextBox();
		lblNgay_Lct = new Label();
		txtTy_gia = new AsTextNumeric();
		cboMa_NT = new AsComboBoxNT();
		lblMa_Nt = new Label();
		tabChi_phi = new TabPage();
		sCChiPhi = new SplitContainer();
		adgvChi_phi = new AsInputDGV();
		dgvcMa_chiphi = new DataGridViewAsTextBoxColumn();
		dgvcTT_PB = new DataGridViewComboBoxColumn();
		dgvcTen_chi_phi = new DataGridViewTextBoxColumn();
		dgvcTien_cp_nt_cp = new DataGridViewAsTextNumericColumn();
		dgvcTs_gtgt_cp = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt_nt_cp = new DataGridViewAsTextNumericColumn();
		dgvcTt_nt_Cp = new DataGridViewAsTextNumericColumn();
		dgvcTien_cp_cp = new DataGridViewAsTextNumericColumn();
		dgvcThue_Gtgt_cp = new DataGridViewAsTextNumericColumn();
		dgvcTt_Cp = new DataGridViewAsTextNumericColumn();
		dgvcMa_bp_cp = new DataGridViewAsTextBoxColumn();
		dgvcMa_phi_cp = new DataGridViewAsTextBoxColumn();
		dgvcMa_spct_cp = new DataGridViewAsTextBoxColumn();
		dgvcMa_lo_cp = new DataGridViewAsTextBoxColumn();
		txtT_thue_nt_cp = new AsTextNumeric();
		cmdPhan_bo = new Button();
		Label9 = new Label();
		Label11 = new Label();
		txtT_tt_nt_cp = new AsTextNumeric();
		Label10 = new Label();
		txtT_Tien_Cp_nt_Cp = new AsTextNumeric();
		adgvDetail = new AsInputDGV();
		dgvcMa_vt = new DataGridViewAsTextBoxColumn();
		dgvcTen_vt = new DataGridViewTextBoxColumn();
		dgvcDvt = new DataGridViewTextBoxColumn();
		dgvcMa_kho = new DataGridViewAsTextBoxColumn();
		dgvcTon = new DataGridViewAsTextNumericColumn();
		dgvcSo_luong = new DataGridViewAsTextNumericColumn();
		dgvcGia_nt0 = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt0 = new DataGridViewAsTextNumericColumn();
		dgvcTl_ck = new DataGridViewAsTextNumericColumn();
		dgvcCk_nt = new DataGridViewAsTextNumericColumn();
		dgvcTien_cp_nt = new DataGridViewAsTextNumericColumn();
		dgvcTs_gtgt = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt_nt = new DataGridViewAsTextNumericColumn();
		dgvcGia0 = new DataGridViewAsTextNumericColumn();
		dgvcTien0 = new DataGridViewAsTextNumericColumn();
		dgvcCk = new DataGridViewAsTextNumericColumn();
		dgvcTien_cp = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt = new DataGridViewAsTextNumericColumn();
		tabHach_toan = new TabPage();
		SplitContainer1 = new SplitContainer();
		adgvHach_toan = new AsInputDGV();
		dgvcTen_vt_ht = new DataGridViewTextBoxColumn();
		dgvcTien_nt0_ht = new DataGridViewAsTextNumericColumn();
		dgvcCk_nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcCp_Nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien0_ht = new DataGridViewAsTextNumericColumn();
		dgvcCk_ht = new DataGridViewAsTextNumericColumn();
		dgvcCp_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_ht = new DataGridViewAsTextNumericColumn();
		dgvcTk_vt = new DataGridViewAsTextBoxColumn();
		dgvcTk_co = new DataGridViewTextBoxColumn();
		dgvcMa_vt_ht = new DataGridViewTextBoxColumn();
		txtTk_pt = new AsTextBox();
		lblTk_pt = new Label();
		lblTk_thue = new Label();
		txtTk_thue = new AsTextBox();
		lblTen_httt = new Label();
		txtMa_Httt = new AsTextBox();
		Label2 = new Label();
		tabTain = new TabPage();
		cmdGetTaInFromDetail = new Button();
		ctlTaIn = new ctlTaIn();
		Label12 = new Label();
		txtT_thue_Nt = new AsTextNumeric();
		txtT_Thue = new AsTextNumeric();
		txtT_tt = new AsTextNumeric();
		txtT_tt_nt = new AsTextNumeric();
		txtT_Tien_nt0 = new AsTextNumeric();
		txtT_Tien0 = new AsTextNumeric();
		lblT_Thue = new Label();
		Label8 = new Label();
		txtT_cp_nt = new AsTextNumeric();
		txtT_tien_nt = new AsTextNumeric();
		Label7 = new Label();
		txtT_So_luong = new AsTextNumeric();
		Label5 = new Label();
		txtT_cp = new AsTextNumeric();
		txtNgay_hd = new AsMaskedTextBox();
		Label4 = new Label();
		Label6 = new Label();
		txtSo_hd = new TextBox();
		txtT_Tien = new AsTextNumeric();
		bsTT_PB = new BindingSource(components);
		lblDia_chi = new Label();
		txtDia_chi = new TextBox();
		lblMa_so_thue = new Label();
		txtMa_so_thue = new TextBox();
		cmdThanh_toan = new Button();
		txtTl_ck_hd = new AsTextNumeric();
		txtT_ck = new AsTextNumeric();
		txtT_ck_nt = new AsTextNumeric();
		Label1 = new Label();
		chkCk_st = new AsCheckBox();
		cmdChon_dh = new Button();
		((Control)gbPH).SuspendLayout();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabDetail).SuspendLayout();
		((ISupportInitialize)bsPH).BeginInit();
		((ISupportInitialize)bsCT).BeginInit();
		((ISupportInitialize)bsCP).BeginInit();
		((ISupportInitialize)bsTain).BeginInit();
		((ISupportInitialize)bsTaout).BeginInit();
		((Control)tabChi_phi).SuspendLayout();
		((Control)sCChiPhi.Panel1).SuspendLayout();
		((Control)sCChiPhi.Panel2).SuspendLayout();
		((Control)sCChiPhi).SuspendLayout();
		((ISupportInitialize)adgvChi_phi).BeginInit();
		((ISupportInitialize)adgvDetail).BeginInit();
		((Control)tabHach_toan).SuspendLayout();
		((Control)SplitContainer1.Panel1).SuspendLayout();
		((Control)SplitContainer1.Panel2).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((ISupportInitialize)adgvHach_toan).BeginInit();
		((Control)tabTain).SuspendLayout();
		((ISupportInitialize)bsTT_PB).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = cmdAdd;
		Point location = new Point(3, 460);
		((Control)obj).Location = location;
		((Control)cmdAdd).TabIndex = 6;
		Button obj2 = cmdPrint;
		location = new Point(73, 460);
		((Control)obj2).Location = location;
		((Control)cmdPrint).TabIndex = 7;
		Button obj3 = cmdLast;
		location = new Point(731, 460);
		((Control)obj3).Location = location;
		((Control)cmdLast).TabIndex = 16;
		Button obj4 = cmdNext;
		location = new Point(706, 460);
		((Control)obj4).Location = location;
		((Control)cmdNext).TabIndex = 15;
		Button obj5 = cmdPrevious;
		location = new Point(681, 460);
		((Control)obj5).Location = location;
		((Control)cmdPrevious).TabIndex = 14;
		Button obj6 = cmdFirst;
		location = new Point(656, 460);
		((Control)obj6).Location = location;
		((Control)cmdFirst).TabIndex = 13;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(565, 38);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct;
		Size size = new Size(38, 13);
		((Control)obj8).Size = size;
		lblSo_Ct.Text = "Số ctừ";
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		Label obj9 = lblNgay_Ct;
		location = new Point(565, 16);
		((Control)obj9).Location = location;
		Label obj10 = lblNgay_Ct;
		size = new Size(50, 13);
		((Control)obj10).Size = size;
		lblNgay_Ct.Text = "Ngày ctừ";
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)5;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(664, 13);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay_Ct).TabIndex = 6;
		((Control)gbPH).Controls.Add((Control)(object)lblMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)lblDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)txtDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)Label6);
		((Control)gbPH).Controls.Add((Control)(object)txtSo_hd);
		((Control)gbPH).Controls.Add((Control)(object)txtNgay_hd);
		((Control)gbPH).Controls.Add((Control)(object)Label4);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_httt);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Httt);
		((Control)gbPH).Controls.Add((Control)(object)Label2);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbPH).Controls.Add((Control)(object)txtTy_gia);
		((Control)gbPH).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Nt);
		((Control)gbPH).Controls.Add((Control)(object)txtNgay_lct);
		((Control)gbPH).Controls.Add((Control)(object)lblNgay_Lct);
		((Control)gbPH).Controls.Add((Control)(object)lblNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbPH).Controls.Add((Control)(object)txtNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)lblDien_giai);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Kh);
		gbPH.FlatStyle = (FlatStyle)0;
		GroupBox obj11 = gbPH;
		location = new Point(3, -3);
		((Control)obj11).Location = location;
		GroupBox obj12 = gbPH;
		size = new Size(751, 150);
		((Control)obj12).Size = size;
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTy_gia, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_hd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_hd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_so_thue, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(575, 460);
		((Control)splitButton).Location = location;
		((Control)cmdSearch).TabIndex = 12;
		((Control)AsTabControl).Controls.Add((Control)(object)tabChi_phi);
		((Control)AsTabControl).Controls.Add((Control)(object)tabHach_toan);
		((Control)AsTabControl).Controls.Add((Control)(object)tabTain);
		AsTabControl asTabControl = AsTabControl;
		location = new Point(1, 150);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(756, 189);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl).TabIndex = 2;
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabTain, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabHach_toan, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabChi_phi, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabOptFields, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabDetail, 0);
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj13 = tabDetail;
		size = new Size(748, 160);
		((Control)obj13).Size = size;
		TabPage obj14 = tabOptFields;
		size = new Size(748, 160);
		((Control)obj14).Size = size;
		Button obj15 = cmdCopy;
		location = new Point(353, 460);
		((Control)obj15).Location = location;
		((Control)cmdCopy).TabIndex = 11;
		Button obj16 = cmdDelete;
		location = new Point(283, 460);
		((Control)obj16).Location = location;
		((Control)cmdDelete).TabIndex = 10;
		Button obj17 = cmdEdit;
		location = new Point(213, 460);
		((Control)obj17).Location = location;
		((Control)cmdEdit).TabIndex = 9;
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		TextBox obj18 = txtSo_Ct;
		location = new Point(664, 35);
		((Control)obj18).Location = location;
		((Control)txtSo_Ct).TabIndex = 7;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(117, 13);
		((Control)asTextBox).Location = location;
		txtMa_Kh.LookupCodeName = "MA_NCC";
		txtMa_Kh.LookupWhereCondition = "isNcc=1";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		txtMa_Kh.SD = true;
		AsTextBox asTextBox2 = txtMa_Kh;
		size = new Size(75, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Kh).TabIndex = 0;
		txtMa_Kh.UseAutoCompleteSource = true;
		txtMa_Kh.ValidReturnFieldList = "ten_kh,dia_chi,ma_so_thue,nguoi_gd,tel,gh_no,ma_httt_po";
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj19 = lblTen_Kh;
		location = new Point(198, 17);
		((Control)obj19).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj20 = lblTen_Kh;
		size = new Size(344, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_Kh).TabIndex = 251;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj21 = lblMa_Kh;
		location = new Point(9, 17);
		((Control)obj21).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj22 = lblMa_Kh;
		size = new Size(47, 13);
		((Control)obj22).Size = size;
		((Control)lblMa_Kh).TabIndex = 139;
		lblMa_Kh.Text = "Mã NCC";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj23 = lblNguoi_Gd;
		location = new Point(9, 68);
		((Control)obj23).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj24 = lblNguoi_Gd;
		size = new Size(71, 14);
		((Control)obj24).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 143;
		lblNguoi_Gd.Text = "Người bán";
		TextBox obj25 = txtDien_giai;
		location = new Point(117, 91);
		((Control)obj25).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj26 = txtDien_giai;
		size = new Size(425, 20);
		((Control)obj26).Size = size;
		((Control)txtDien_giai).TabIndex = 4;
		TextBox obj27 = txtNguoi_Gd;
		location = new Point(117, 65);
		((Control)obj27).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj28 = txtNguoi_Gd;
		size = new Size(170, 20);
		((Control)obj28).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 2;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj29 = lblDien_giai;
		location = new Point(9, 95);
		((Control)obj29).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj30 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj30).Size = size;
		((Control)lblDien_giai).TabIndex = 144;
		lblDien_giai.Text = "Diễn giải";
		txtNgay_lct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_lct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_lct;
		location = new Point(664, 57);
		((Control)asMaskedTextBox2).Location = location;
		((MaskedTextBox)txtNgay_lct).Mask = "##/##/####";
		((Control)txtNgay_lct).Name = "txtNgay_lct";
		((MaskedTextBox)txtNgay_lct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_lct;
		size = new Size(78, 20);
		((Control)asMaskedTextBox3).Size = size;
		((Control)txtNgay_lct).TabIndex = 8;
		((MaskedTextBox)txtNgay_lct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_lct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox4.Value = dateTime;
		lblNgay_Lct.AutoSize = true;
		lblNgay_Lct.ImeMode = (ImeMode)0;
		Label obj31 = lblNgay_Lct;
		location = new Point(565, 59);
		((Control)obj31).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj32 = lblNgay_Lct;
		size = new Size(49, 13);
		((Control)obj32).Size = size;
		((Control)lblNgay_Lct).TabIndex = 234;
		lblNgay_Lct.Text = "Ngày lập";
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(673, 123);
		((Control)asTextNumeric).Location = location;
		txtTy_gia.Mask = "### ###.##";
		((Control)txtTy_gia).Name = "txtTy_gia";
		AsTextNumeric asTextNumeric2 = txtTy_gia;
		size = new Size(69, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTy_gia).TabIndex = 12;
		((TextBox)txtTy_gia).Text = "0.00";
		((TextBox)txtTy_gia).TextAlign = (HorizontalAlignment)1;
		txtTy_gia.Value = 0.0;
		((ComboBox)cboMa_NT).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboMa_NT).Enabled = false;
		((ListControl)cboMa_NT).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_NT;
		location = new Point(623, 123);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(47, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 11;
		lblMa_Nt.AutoSize = true;
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj33 = lblMa_Nt;
		location = new Point(565, 126);
		((Control)obj33).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj34 = lblMa_Nt;
		size = new Size(36, 13);
		((Control)obj34).Size = size;
		((Control)lblMa_Nt).TabIndex = 237;
		lblMa_Nt.Text = "Tỷ giá";
		tabChi_phi.BackColor = SystemColors.Control;
		((Control)tabChi_phi).Controls.Add((Control)(object)sCChiPhi);
		TabPage obj35 = tabChi_phi;
		location = new Point(4, 25);
		obj35.Location = location;
		((Control)tabChi_phi).Name = "tabChi_phi";
		TabPage obj36 = tabChi_phi;
		Padding val47 = default(Padding);
		((Padding)(ref val47))._002Ector(3);
		((Control)obj36).Padding = val47;
		TabPage obj37 = tabChi_phi;
		size = new Size(748, 160);
		((Control)obj37).Size = size;
		tabChi_phi.TabIndex = 7;
		tabChi_phi.Text = "Chi phí &mua hàng";
		sCChiPhi.Dock = (DockStyle)5;
		sCChiPhi.FixedPanel = (FixedPanel)2;
		SplitContainer obj38 = sCChiPhi;
		location = new Point(3, 3);
		((Control)obj38).Location = location;
		((Control)sCChiPhi).Name = "sCChiPhi";
		sCChiPhi.Orientation = (Orientation)0;
		((Control)sCChiPhi.Panel1).Controls.Add((Control)(object)adgvChi_phi);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)txtT_thue_nt_cp);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)cmdPhan_bo);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)Label9);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)Label11);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)txtT_tt_nt_cp);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)Label10);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)txtT_Tien_Cp_nt_Cp);
		SplitContainer obj39 = sCChiPhi;
		size = new Size(742, 154);
		((Control)obj39).Size = size;
		sCChiPhi.SplitterDistance = 120;
		((Control)sCChiPhi).TabIndex = 280;
		((DataGridView)adgvChi_phi).AllowUserToAddRows = false;
		((DataGridView)adgvChi_phi).AllowUserToDeleteRows = false;
		((DataGridView)adgvChi_phi).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvChi_phi).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvChi_phi).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)adgvChi_phi).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvChi_phi).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[14]
		{
			dgvcMa_chiphi,
			(DataGridViewColumn)dgvcTT_PB,
			(DataGridViewColumn)dgvcTen_chi_phi,
			dgvcTien_cp_nt_cp,
			dgvcTs_gtgt_cp,
			dgvcThue_gtgt_nt_cp,
			dgvcTt_nt_Cp,
			dgvcTien_cp_cp,
			dgvcThue_Gtgt_cp,
			dgvcTt_Cp,
			dgvcMa_bp_cp,
			dgvcMa_phi_cp,
			dgvcMa_spct_cp,
			dgvcMa_lo_cp
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvChi_phi).DefaultCellStyle = val2;
		((Control)adgvChi_phi).Dock = (DockStyle)5;
		((DataGridView)adgvChi_phi).GridColor = SystemColors.Control;
		adgvChi_phi.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV = adgvChi_phi;
		location = new Point(0, 0);
		((Control)asInputDGV).Location = location;
		((Control)adgvChi_phi).Name = "adgvChi_phi";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvChi_phi).RowHeadersDefaultCellStyle = val3;
		((DataGridView)adgvChi_phi).RowHeadersWidth = 35;
		((DataGridView)adgvChi_phi).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = adgvChi_phi;
		size = new Size(742, 120);
		((Control)asInputDGV2).Size = size;
		((Control)adgvChi_phi).TabIndex = 261;
		dgvcMa_chiphi.AutoFill = true;
		dgvcMa_chiphi.AutoLookup = true;
		dgvcMa_chiphi.AutoValid = true;
		((DataGridViewColumn)dgvcMa_chiphi).DataPropertyName = "ma_cp";
		val4.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_chiphi).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcMa_chiphi).HeaderText = "Mã CP";
		dgvcMa_chiphi.LookupCodeName = "MA_CP";
		dgvcMa_chiphi.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_chiphi).Name = "dgvcMa_chiphi";
		dgvcMa_chiphi.ReceiverValidFieldList = "ten_cp,tt_pb";
		((DataGridViewColumn)dgvcMa_chiphi).Resizable = (DataGridViewTriState)1;
		dgvcMa_chiphi.SD = true;
		dgvcMa_chiphi.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_chiphi.ValidReturnFieldList = "ten_cp,tt_pb";
		((DataGridViewColumn)dgvcMa_chiphi).Width = 70;
		((DataGridViewColumn)dgvcTT_PB).DataPropertyName = "TT_PB";
		dgvcTT_PB.DisplayStyleForCurrentCellOnly = true;
		((DataGridViewColumn)dgvcTT_PB).HeaderText = "Tiêu thức phân bổ";
		dgvcTT_PB.Items.AddRange(new object[2] { "1. Theo số lượng", "2. Theo giá trị" });
		((DataGridViewColumn)dgvcTT_PB).Name = "dgvcTT_PB";
		((DataGridViewColumn)dgvcTT_PB).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcTT_PB).Width = 110;
		((DataGridViewColumn)dgvcTen_chi_phi).DataPropertyName = "ten_cp";
		((DataGridViewColumn)dgvcTen_chi_phi).HeaderText = "Diễn giải";
		((DataGridViewColumn)dgvcTen_chi_phi).Name = "dgvcTen_chi_phi";
		dgvcTen_chi_phi.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_chi_phi).Width = 170;
		((DataGridViewColumn)dgvcTien_cp_nt_cp).DataPropertyName = "tien_cp_nt";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp_nt_cp).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcTien_cp_nt_cp).HeaderText = "Chi phí";
		dgvcTien_cp_nt_cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp_nt_cp).Name = "dgvcTien_cp_nt_cp";
		dgvcTien_cp_nt_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_cp_nt_cp.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_cp_nt_cp).Width = 80;
		((DataGridViewColumn)dgvcTs_gtgt_cp).DataPropertyName = "ts_gtgt";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_gtgt_cp).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcTs_gtgt_cp).HeaderText = "%VAT";
		dgvcTs_gtgt_cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_gtgt_cp).Name = "dgvcTs_gtgt_cp";
		dgvcTs_gtgt_cp.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTs_gtgt_cp).Width = 40;
		((DataGridViewColumn)dgvcThue_gtgt_nt_cp).DataPropertyName = "thue_gtgt_nt";
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt_cp).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcThue_gtgt_nt_cp).HeaderText = "VAT";
		dgvcThue_gtgt_nt_cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt_cp).Name = "dgvcThue_gtgt_nt_cp";
		((DataGridViewColumn)dgvcThue_gtgt_nt_cp).ReadOnly = true;
		dgvcThue_gtgt_nt_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_nt_cp.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_gtgt_nt_cp).Width = 60;
		((DataGridViewColumn)dgvcTt_nt_Cp).DataPropertyName = "tt_nt";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTt_nt_Cp).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcTt_nt_Cp).HeaderText = "Tổng tiền";
		dgvcTt_nt_Cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTt_nt_Cp).Name = "dgvcTt_nt_Cp";
		((DataGridViewColumn)dgvcTt_nt_Cp).ReadOnly = true;
		dgvcTt_nt_Cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTt_nt_Cp.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTt_nt_Cp).Width = 90;
		((DataGridViewColumn)dgvcTien_cp_cp).DataPropertyName = "tien_cp";
		val9.Alignment = (DataGridViewContentAlignment)64;
		val9.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp_cp).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcTien_cp_cp).HeaderText = "Chi phí VNĐ";
		dgvcTien_cp_cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp_cp).Name = "dgvcTien_cp_cp";
		((DataGridViewColumn)dgvcTien_cp_cp).ReadOnly = true;
		dgvcTien_cp_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_cp_cp.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_Gtgt_cp).DataPropertyName = "thue_gtgt";
		val10.Alignment = (DataGridViewContentAlignment)64;
		val10.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Gtgt_cp).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcThue_Gtgt_cp).HeaderText = "VAT VNĐ";
		dgvcThue_Gtgt_cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Gtgt_cp).Name = "dgvcThue_Gtgt_cp";
		((DataGridViewColumn)dgvcThue_Gtgt_cp).ReadOnly = true;
		dgvcThue_Gtgt_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_Gtgt_cp.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_Gtgt_cp).Width = 70;
		((DataGridViewColumn)dgvcTt_Cp).DataPropertyName = "tt";
		val11.Alignment = (DataGridViewContentAlignment)64;
		val11.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTt_Cp).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcTt_Cp).HeaderText = "Tổng tiền VNĐ";
		dgvcTt_Cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTt_Cp).Name = "dgvcTt_Cp";
		((DataGridViewColumn)dgvcTt_Cp).ReadOnly = true;
		dgvcTt_Cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTt_Cp.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTt_Cp).Width = 90;
		dgvcMa_bp_cp.AutoFill = true;
		dgvcMa_bp_cp.AutoLookup = true;
		dgvcMa_bp_cp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_bp_cp).DataPropertyName = "ma_bp";
		val12.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_bp_cp).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcMa_bp_cp).HeaderText = "Bộ phận";
		dgvcMa_bp_cp.LookupCodeName = "ma_bp";
		dgvcMa_bp_cp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_bp_cp).Name = "dgvcMa_bp_cp";
		dgvcMa_bp_cp.ReceiverValidFieldList = "";
		dgvcMa_bp_cp.SD = true;
		dgvcMa_bp_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_bp_cp.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcMa_bp_cp).Width = 60;
		dgvcMa_phi_cp.AutoFill = true;
		dgvcMa_phi_cp.AutoLookup = true;
		dgvcMa_phi_cp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_phi_cp).DataPropertyName = "ma_phi";
		val13.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_phi_cp).DefaultCellStyle = val13;
		((DataGridViewColumn)dgvcMa_phi_cp).HeaderText = "Phí";
		dgvcMa_phi_cp.LookupCodeName = "ma_phi";
		dgvcMa_phi_cp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_phi_cp).Name = "dgvcMa_phi_cp";
		dgvcMa_phi_cp.ReceiverValidFieldList = "";
		dgvcMa_phi_cp.SD = true;
		dgvcMa_phi_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_phi_cp.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcMa_phi_cp).Width = 60;
		dgvcMa_spct_cp.AutoFill = true;
		dgvcMa_spct_cp.AutoLookup = true;
		dgvcMa_spct_cp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_spct_cp).DataPropertyName = "ma_spct";
		val14.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_spct_cp).DefaultCellStyle = val14;
		((DataGridViewColumn)dgvcMa_spct_cp).HeaderText = "SPCT";
		dgvcMa_spct_cp.LookupCodeName = "ma_spct";
		dgvcMa_spct_cp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_spct_cp).Name = "dgvcMa_spct_cp";
		dgvcMa_spct_cp.ReceiverValidFieldList = "";
		dgvcMa_spct_cp.SD = true;
		dgvcMa_spct_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_spct_cp.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcMa_spct_cp).Width = 60;
		dgvcMa_lo_cp.AutoFill = true;
		dgvcMa_lo_cp.AutoLookup = true;
		dgvcMa_lo_cp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_lo_cp).DataPropertyName = "ma_lo";
		val15.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_lo_cp).DefaultCellStyle = val15;
		((DataGridViewColumn)dgvcMa_lo_cp).HeaderText = "Lô";
		dgvcMa_lo_cp.LookupCodeName = "ma_lo";
		dgvcMa_lo_cp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_lo_cp).Name = "dgvcMa_lo_cp";
		dgvcMa_lo_cp.ReceiverValidFieldList = "";
		dgvcMa_lo_cp.SD = true;
		dgvcMa_lo_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_lo_cp.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcMa_lo_cp).Width = 60;
		txtT_thue_nt_cp.DecimalSymbol = ".";
		((Control)txtT_thue_nt_cp).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtT_thue_nt_cp;
		location = new Point(289, 3);
		((Control)asTextNumeric3).Location = location;
		txtT_thue_nt_cp.Mask = "### ### ### ###";
		((Control)txtT_thue_nt_cp).Name = "txtT_thue_nt_cp";
		((TextBoxBase)txtT_thue_nt_cp).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtT_thue_nt_cp;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		txtT_thue_nt_cp.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_thue_nt_cp).TabIndex = 276;
		((Control)txtT_thue_nt_cp).TabStop = false;
		((TextBox)txtT_thue_nt_cp).Text = "0";
		((TextBox)txtT_thue_nt_cp).TextAlign = (HorizontalAlignment)1;
		txtT_thue_nt_cp.Value = 0.0;
		((Control)cmdPhan_bo).Anchor = (AnchorStyles)9;
		((ButtonBase)cmdPhan_bo).FlatStyle = (FlatStyle)1;
		Button obj40 = cmdPhan_bo;
		location = new Point(664, 2);
		((Control)obj40).Location = location;
		((Control)cmdPhan_bo).Name = "cmdPhan_bo";
		Button obj41 = cmdPhan_bo;
		size = new Size(78, 22);
		((Control)obj41).Size = size;
		((Control)cmdPhan_bo).TabIndex = 260;
		((ButtonBase)cmdPhan_bo).Text = "Phân &bổ";
		((Control)Label9).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label9.ImeMode = (ImeMode)0;
		Label label = Label9;
		location = new Point(7, 7);
		((Control)label).Location = location;
		((Control)Label9).Name = "Label9";
		Label label2 = Label9;
		size = new Size(79, 13);
		((Control)label2).Size = size;
		((Control)Label9).TabIndex = 267;
		Label9.Text = "Chi phí";
		Label9.TextAlign = (ContentAlignment)16;
		((Control)Label11).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label11.ImeMode = (ImeMode)0;
		Label label3 = Label11;
		location = new Point(396, 7);
		((Control)label3).Location = location;
		((Control)Label11).Name = "Label11";
		Label label4 = Label11;
		size = new Size(89, 13);
		((Control)label4).Size = size;
		((Control)Label11).TabIndex = 279;
		Label11.Text = "Thanh toán";
		Label11.TextAlign = (ContentAlignment)16;
		txtT_tt_nt_cp.DecimalSymbol = ".";
		((Control)txtT_tt_nt_cp).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric5 = txtT_tt_nt_cp;
		location = new Point(502, 2);
		((Control)asTextNumeric5).Location = location;
		txtT_tt_nt_cp.Mask = "### ### ### ###";
		((Control)txtT_tt_nt_cp).Name = "txtT_tt_nt_cp";
		((TextBoxBase)txtT_tt_nt_cp).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtT_tt_nt_cp;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		txtT_tt_nt_cp.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tt_nt_cp).TabIndex = 277;
		((Control)txtT_tt_nt_cp).TabStop = false;
		((TextBox)txtT_tt_nt_cp).Text = "0";
		((TextBox)txtT_tt_nt_cp).TextAlign = (HorizontalAlignment)1;
		txtT_tt_nt_cp.Value = 0.0;
		((Control)Label10).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label10.ImeMode = (ImeMode)0;
		Label label5 = Label10;
		location = new Point(198, 7);
		((Control)label5).Location = location;
		((Control)Label10).Name = "Label10";
		Label label6 = Label10;
		size = new Size(85, 13);
		((Control)label6).Size = size;
		((Control)Label10).TabIndex = 278;
		Label10.Text = "Thuế GTGT";
		txtT_Tien_Cp_nt_Cp.DecimalSymbol = ".";
		((Control)txtT_Tien_Cp_nt_Cp).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric7 = txtT_Tien_Cp_nt_Cp;
		location = new Point(92, 3);
		((Control)asTextNumeric7).Location = location;
		txtT_Tien_Cp_nt_Cp.Mask = "### ### ### ###";
		((Control)txtT_Tien_Cp_nt_Cp).Name = "txtT_Tien_Cp_nt_Cp";
		((TextBoxBase)txtT_Tien_Cp_nt_Cp).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_Tien_Cp_nt_Cp;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_Tien_Cp_nt_Cp.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_Tien_Cp_nt_Cp).TabIndex = 269;
		((Control)txtT_Tien_Cp_nt_Cp).TabStop = false;
		((TextBox)txtT_Tien_Cp_nt_Cp).Text = "0";
		((TextBox)txtT_Tien_Cp_nt_Cp).TextAlign = (HorizontalAlignment)1;
		txtT_Tien_Cp_nt_Cp.Value = 0.0;
		((DataGridView)adgvDetail).AllowUserToAddRows = false;
		((DataGridView)adgvDetail).AllowUserToDeleteRows = false;
		((DataGridView)adgvDetail).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvDetail).BorderStyle = (BorderStyle)2;
		val16.Alignment = (DataGridViewContentAlignment)16;
		val16.BackColor = SystemColors.Control;
		val16.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val16.ForeColor = SystemColors.WindowText;
		val16.SelectionBackColor = SystemColors.Highlight;
		val16.SelectionForeColor = SystemColors.HighlightText;
		val16.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail).ColumnHeadersDefaultCellStyle = val16;
		((DataGridView)adgvDetail).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[18]
		{
			dgvcMa_vt,
			(DataGridViewColumn)dgvcTen_vt,
			(DataGridViewColumn)dgvcDvt,
			dgvcMa_kho,
			dgvcTon,
			dgvcSo_luong,
			dgvcGia_nt0,
			dgvcTien_nt0,
			dgvcTl_ck,
			dgvcCk_nt,
			dgvcTien_cp_nt,
			dgvcTs_gtgt,
			dgvcThue_gtgt_nt,
			dgvcGia0,
			dgvcTien0,
			dgvcCk,
			dgvcTien_cp,
			dgvcThue_gtgt
		});
		val17.Alignment = (DataGridViewContentAlignment)16;
		val17.BackColor = SystemColors.Window;
		val17.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val17.ForeColor = SystemColors.ControlText;
		val17.SelectionBackColor = SystemColors.Highlight;
		val17.SelectionForeColor = SystemColors.HighlightText;
		val17.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvDetail).DefaultCellStyle = val17;
		((Control)adgvDetail).Dock = (DockStyle)5;
		((DataGridView)adgvDetail).GridColor = SystemColors.Control;
		adgvDetail.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV3 = adgvDetail;
		location = new Point(3, 3);
		((Control)asInputDGV3).Location = location;
		((Control)adgvDetail).Name = "adgvDetail";
		val18.Alignment = (DataGridViewContentAlignment)32;
		val18.BackColor = SystemColors.Control;
		val18.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val18.ForeColor = SystemColors.WindowText;
		val18.SelectionBackColor = SystemColors.Highlight;
		val18.SelectionForeColor = SystemColors.HighlightText;
		val18.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail).RowHeadersDefaultCellStyle = val18;
		((DataGridView)adgvDetail).RowHeadersWidth = 35;
		((DataGridView)adgvDetail).RowTemplate.Height = 20;
		AsInputDGV asInputDGV4 = adgvDetail;
		size = new Size(742, 154);
		((Control)asInputDGV4).Size = size;
		((Control)adgvDetail).TabIndex = 1;
		dgvcMa_vt.AutoFill = true;
		dgvcMa_vt.AutoLookup = true;
		dgvcMa_vt.AutoValid = true;
		((DataGridViewColumn)dgvcMa_vt).DataPropertyName = "ma_vt";
		val19.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_vt).DefaultCellStyle = val19;
		((DataGridViewColumn)dgvcMa_vt).HeaderText = "Mã hàng";
		dgvcMa_vt.LookupCodeName = "MA_VT";
		dgvcMa_vt.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_vt).Name = "dgvcMa_vt";
		dgvcMa_vt.ReceiverValidFieldList = "ten_vt,dvt,tk_vt,tk_gv,tk_dt,tk_ck,ton_kho,gia_ton,ma_kho";
		dgvcMa_vt.SD = true;
		dgvcMa_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_vt.ValidReturnFieldList = "ten_vt,dvt,tk_vt,tk_gv,tk_dt,tk_ck,ton_kho,gia_ton,ma_kho,ma_vitri";
		((DataGridViewColumn)dgvcMa_vt).Width = 80;
		((DataGridViewColumn)dgvcTen_vt).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vt).HeaderText = "Tên hàng";
		dgvcTen_vt.MaxInputLength = 128;
		((DataGridViewColumn)dgvcTen_vt).Name = "dgvcTen_vt";
		((DataGridViewColumn)dgvcTen_vt).Resizable = (DataGridViewTriState)1;
		dgvcTen_vt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_vt).Width = 160;
		((DataGridViewColumn)dgvcDvt).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcDvt).DataPropertyName = "dvt";
		((DataGridViewColumn)dgvcDvt).HeaderText = "Đvt";
		((DataGridViewColumn)dgvcDvt).Name = "dgvcDvt";
		((DataGridViewColumn)dgvcDvt).ReadOnly = true;
		((DataGridViewColumn)dgvcDvt).Width = 49;
		dgvcMa_kho.AutoFill = true;
		dgvcMa_kho.AutoLookup = true;
		dgvcMa_kho.AutoValid = true;
		((DataGridViewColumn)dgvcMa_kho).DataPropertyName = "ma_kho";
		val20.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_kho).DefaultCellStyle = val20;
		((DataGridViewColumn)dgvcMa_kho).HeaderText = "Kho";
		dgvcMa_kho.LookupCodeName = "MA_KHO";
		dgvcMa_kho.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_kho).Name = "dgvcMa_kho";
		dgvcMa_kho.ReceiverValidFieldList = "ten_kho";
		dgvcMa_kho.SD = true;
		dgvcMa_kho.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_kho.ValidReturnFieldList = "ten_kho";
		((DataGridViewColumn)dgvcMa_kho).Width = 65;
		((DataGridViewColumn)dgvcTon).DataPropertyName = "ton";
		val21.Alignment = (DataGridViewContentAlignment)64;
		val21.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTon).DefaultCellStyle = val21;
		((DataGridViewColumn)dgvcTon).HeaderText = "Tồn";
		dgvcTon.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTon).Name = "dgvcTon";
		((DataGridViewColumn)dgvcTon).ReadOnly = true;
		dgvcTon.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTon.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcTon).Width = 60;
		((DataGridViewColumn)dgvcSo_luong).DataPropertyName = "so_luong";
		val22.Alignment = (DataGridViewContentAlignment)64;
		val22.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).DefaultCellStyle = val22;
		((DataGridViewColumn)dgvcSo_luong).HeaderText = "Số lượng";
		dgvcSo_luong.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).Name = "dgvcSo_luong";
		dgvcSo_luong.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSo_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcSo_luong).Width = 70;
		((DataGridViewColumn)dgvcGia_nt0).DataPropertyName = "gia_nt0";
		val23.Alignment = (DataGridViewContentAlignment)64;
		val23.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt0).DefaultCellStyle = val23;
		((DataGridViewColumn)dgvcGia_nt0).HeaderText = "Đơn giá";
		dgvcGia_nt0.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt0).Name = "dgvcGia_nt0";
		dgvcGia_nt0.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia_nt0.SpecialType = Commons.NumericSpecialType.FCPrice;
		((DataGridViewColumn)dgvcGia_nt0).Width = 85;
		((DataGridViewColumn)dgvcTien_nt0).DataPropertyName = "tien_nt0";
		val24.Alignment = (DataGridViewContentAlignment)64;
		val24.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt0).DefaultCellStyle = val24;
		((DataGridViewColumn)dgvcTien_nt0).HeaderText = "Thành tiền";
		dgvcTien_nt0.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt0).Name = "dgvcTien_nt0";
		((DataGridViewColumn)dgvcTien_nt0).ReadOnly = true;
		dgvcTien_nt0.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt0.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt0).Width = 90;
		((DataGridViewColumn)dgvcTl_ck).DataPropertyName = "tl_ck";
		val25.Alignment = (DataGridViewContentAlignment)64;
		val25.Format = "###.##";
		((DataGridViewColumn)dgvcTl_ck).DefaultCellStyle = val25;
		((DataGridViewColumn)dgvcTl_ck).HeaderText = "%CK";
		dgvcTl_ck.Mask = "###.##";
		((DataGridViewColumn)dgvcTl_ck).Name = "dgvcTl_ck";
		dgvcTl_ck.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTl_ck).Visible = false;
		((DataGridViewColumn)dgvcTl_ck).Width = 40;
		((DataGridViewColumn)dgvcCk_nt).DataPropertyName = "ck_nt";
		val26.Alignment = (DataGridViewContentAlignment)64;
		val26.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCk_nt).DefaultCellStyle = val26;
		((DataGridViewColumn)dgvcCk_nt).HeaderText = "CK";
		dgvcCk_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCk_nt).Name = "dgvcCk_nt";
		dgvcCk_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcCk_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcCk_nt).Visible = false;
		((DataGridViewColumn)dgvcCk_nt).Width = 90;
		((DataGridViewColumn)dgvcTien_cp_nt).DataPropertyName = "cp_nt";
		val27.Alignment = (DataGridViewContentAlignment)64;
		val27.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp_nt).DefaultCellStyle = val27;
		((DataGridViewColumn)dgvcTien_cp_nt).HeaderText = "Chi phí";
		dgvcTien_cp_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp_nt).Name = "dgvcTien_cp_nt";
		dgvcTien_cp_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_cp_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_cp_nt).Width = 86;
		((DataGridViewColumn)dgvcTs_gtgt).DataPropertyName = "ts_gtgt";
		val28.Alignment = (DataGridViewContentAlignment)64;
		val28.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_gtgt).DefaultCellStyle = val28;
		((DataGridViewColumn)dgvcTs_gtgt).HeaderText = "%VAT";
		dgvcTs_gtgt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_gtgt).Name = "dgvcTs_gtgt";
		dgvcTs_gtgt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTs_gtgt).Width = 50;
		((DataGridViewColumn)dgvcThue_gtgt_nt).DataPropertyName = "thue_gtgt_nt";
		val29.Alignment = (DataGridViewContentAlignment)64;
		val29.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).DefaultCellStyle = val29;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = "VAT";
		dgvcThue_gtgt_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).Name = "dgvcThue_gtgt_nt";
		dgvcThue_gtgt_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_gtgt_nt).Width = 80;
		((DataGridViewColumn)dgvcGia0).DataPropertyName = "gia0";
		val30.Alignment = (DataGridViewContentAlignment)64;
		val30.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcGia0).DefaultCellStyle = val30;
		((DataGridViewColumn)dgvcGia0).HeaderText = "Đơn giá VNĐ";
		dgvcGia0.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcGia0).Name = "dgvcGia0";
		((DataGridViewColumn)dgvcGia0).ReadOnly = true;
		dgvcGia0.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia0.SpecialType = Commons.NumericSpecialType.ACPrice;
		((DataGridViewColumn)dgvcGia0).Width = 80;
		((DataGridViewColumn)dgvcTien0).DataPropertyName = "tien0";
		val31.Alignment = (DataGridViewContentAlignment)64;
		val31.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcTien0).DefaultCellStyle = val31;
		((DataGridViewColumn)dgvcTien0).HeaderText = "Tiền VNĐ";
		dgvcTien0.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcTien0).Name = "dgvcTien0";
		((DataGridViewColumn)dgvcTien0).ReadOnly = true;
		dgvcTien0.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien0.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien0).Width = 90;
		((DataGridViewColumn)dgvcCk).DataPropertyName = "ck";
		val32.Alignment = (DataGridViewContentAlignment)64;
		val32.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCk).DefaultCellStyle = val32;
		((DataGridViewColumn)dgvcCk).HeaderText = "CK VND";
		dgvcCk.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCk).Name = "dgvcCk";
		dgvcCk.SortMode = (DataGridViewColumnSortMode)0;
		dgvcCk.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcCk).Visible = false;
		((DataGridViewColumn)dgvcCk).Width = 90;
		((DataGridViewColumn)dgvcTien_cp).DataPropertyName = "cp";
		val33.Alignment = (DataGridViewContentAlignment)64;
		val33.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcTien_cp).DefaultCellStyle = val33;
		((DataGridViewColumn)dgvcTien_cp).HeaderText = "CP VNĐ";
		dgvcTien_cp.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcTien_cp).Name = "dgvcTien_cp";
		dgvcTien_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_cp.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_cp).Width = 80;
		((DataGridViewColumn)dgvcThue_gtgt).DataPropertyName = "thue_gtgt";
		val34.Alignment = (DataGridViewContentAlignment)64;
		val34.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcThue_gtgt).DefaultCellStyle = val34;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = "VAT VND";
		dgvcThue_gtgt.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcThue_gtgt).Name = "dgvcThue_gtgt";
		dgvcThue_gtgt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_gtgt).Width = 80;
		tabHach_toan.BackColor = SystemColors.Control;
		((Control)tabHach_toan).Controls.Add((Control)(object)SplitContainer1);
		TabPage obj42 = tabHach_toan;
		location = new Point(4, 25);
		obj42.Location = location;
		((Control)tabHach_toan).Name = "tabHach_toan";
		TabPage obj43 = tabHach_toan;
		((Padding)(ref val47))._002Ector(3);
		((Control)obj43).Padding = val47;
		TabPage obj44 = tabHach_toan;
		size = new Size(748, 160);
		((Control)obj44).Size = size;
		tabHach_toan.TabIndex = 9;
		tabHach_toan.Text = "Hạch toá&n";
		SplitContainer1.Dock = (DockStyle)5;
		SplitContainer1.FixedPanel = (FixedPanel)2;
		SplitContainer splitContainer = SplitContainer1;
		location = new Point(3, 3);
		((Control)splitContainer).Location = location;
		((Control)SplitContainer1).Name = "SplitContainer1";
		SplitContainer1.Orientation = (Orientation)0;
		((Control)SplitContainer1.Panel1).Controls.Add((Control)(object)adgvHach_toan);
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)txtTk_pt);
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)lblTk_pt);
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)lblTk_thue);
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)txtTk_thue);
		SplitContainer splitContainer2 = SplitContainer1;
		size = new Size(742, 154);
		((Control)splitContainer2).Size = size;
		SplitContainer1.SplitterDistance = 125;
		((Control)SplitContainer1).TabIndex = 0;
		((DataGridView)adgvHach_toan).AllowUserToAddRows = false;
		((DataGridView)adgvHach_toan).AllowUserToDeleteRows = false;
		((DataGridView)adgvHach_toan).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvHach_toan).BorderStyle = (BorderStyle)2;
		val35.Alignment = (DataGridViewContentAlignment)16;
		val35.BackColor = SystemColors.Control;
		val35.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val35.ForeColor = SystemColors.WindowText;
		val35.SelectionBackColor = SystemColors.Highlight;
		val35.SelectionForeColor = SystemColors.HighlightText;
		val35.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).ColumnHeadersDefaultCellStyle = val35;
		((DataGridView)adgvHach_toan).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvHach_toan).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[12]
		{
			(DataGridViewColumn)dgvcTen_vt_ht,
			dgvcTien_nt0_ht,
			dgvcCk_nt_ht,
			dgvcCp_Nt_ht,
			dgvcTien_nt_ht,
			dgvcTien0_ht,
			dgvcCk_ht,
			dgvcCp_ht,
			dgvcTien_ht,
			dgvcTk_vt,
			(DataGridViewColumn)dgvcTk_co,
			(DataGridViewColumn)dgvcMa_vt_ht
		});
		val36.Alignment = (DataGridViewContentAlignment)16;
		val36.BackColor = SystemColors.Window;
		val36.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val36.ForeColor = SystemColors.ControlText;
		val36.SelectionBackColor = SystemColors.Highlight;
		val36.SelectionForeColor = SystemColors.HighlightText;
		val36.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvHach_toan).DefaultCellStyle = val36;
		((Control)adgvHach_toan).Dock = (DockStyle)5;
		((DataGridView)adgvHach_toan).GridColor = SystemColors.Control;
		adgvHach_toan.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV5 = adgvHach_toan;
		location = new Point(0, 0);
		((Control)asInputDGV5).Location = location;
		((Control)adgvHach_toan).Name = "adgvHach_toan";
		val37.Alignment = (DataGridViewContentAlignment)32;
		val37.BackColor = SystemColors.Control;
		val37.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val37.ForeColor = SystemColors.WindowText;
		val37.SelectionBackColor = SystemColors.Highlight;
		val37.SelectionForeColor = SystemColors.HighlightText;
		val37.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).RowHeadersDefaultCellStyle = val37;
		((DataGridView)adgvHach_toan).RowHeadersWidth = 35;
		((DataGridView)adgvHach_toan).RowTemplate.Height = 20;
		AsInputDGV asInputDGV6 = adgvHach_toan;
		size = new Size(742, 125);
		((Control)asInputDGV6).Size = size;
		((Control)adgvHach_toan).TabIndex = 1;
		((DataGridViewColumn)dgvcTen_vt_ht).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vt_ht).Frozen = true;
		((DataGridViewColumn)dgvcTen_vt_ht).HeaderText = "Tên vật tư";
		((DataGridViewColumn)dgvcTen_vt_ht).Name = "dgvcTen_vt_ht";
		((DataGridViewColumn)dgvcTen_vt_ht).ReadOnly = true;
		dgvcTen_vt_ht.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_vt_ht).Width = 200;
		((DataGridViewColumn)dgvcTien_nt0_ht).DataPropertyName = "tien_nt0";
		val38.Alignment = (DataGridViewContentAlignment)64;
		val38.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt0_ht).DefaultCellStyle = val38;
		((DataGridViewColumn)dgvcTien_nt0_ht).HeaderText = "Tiền hàng";
		dgvcTien_nt0_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt0_ht).Name = "dgvcTien_nt0_ht";
		((DataGridViewColumn)dgvcTien_nt0_ht).ReadOnly = true;
		dgvcTien_nt0_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt0_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt0_ht).Width = 95;
		((DataGridViewColumn)dgvcCk_nt_ht).DataPropertyName = "ck_nt";
		val39.Alignment = (DataGridViewContentAlignment)64;
		val39.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCk_nt_ht).DefaultCellStyle = val39;
		((DataGridViewColumn)dgvcCk_nt_ht).HeaderText = "CK";
		dgvcCk_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCk_nt_ht).Name = "dgvcCk_nt_ht";
		dgvcCk_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcCk_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcCk_nt_ht).Visible = false;
		((DataGridViewColumn)dgvcCk_nt_ht).Width = 90;
		((DataGridViewColumn)dgvcCp_Nt_ht).DataPropertyName = "cp_nt";
		val40.Alignment = (DataGridViewContentAlignment)64;
		val40.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_Nt_ht).DefaultCellStyle = val40;
		((DataGridViewColumn)dgvcCp_Nt_ht).HeaderText = "Chi phí";
		dgvcCp_Nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_Nt_ht).Name = "dgvcCp_Nt_ht";
		((DataGridViewColumn)dgvcCp_Nt_ht).ReadOnly = true;
		dgvcCp_Nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcCp_Nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcCp_Nt_ht).Width = 80;
		((DataGridViewColumn)dgvcTien_nt_ht).DataPropertyName = "tien_nt";
		val41.Alignment = (DataGridViewContentAlignment)64;
		val41.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).DefaultCellStyle = val41;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = "Tổng tiền";
		dgvcTien_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).Name = "dgvcTien_nt_ht";
		((DataGridViewColumn)dgvcTien_nt_ht).ReadOnly = true;
		dgvcTien_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt_ht).Width = 95;
		((DataGridViewColumn)dgvcTien0_ht).DataPropertyName = "tien0";
		val42.Alignment = (DataGridViewContentAlignment)64;
		val42.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien0_ht).DefaultCellStyle = val42;
		((DataGridViewColumn)dgvcTien0_ht).HeaderText = "Tiền hàng VND";
		dgvcTien0_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien0_ht).Name = "dgvcTien0_ht";
		((DataGridViewColumn)dgvcTien0_ht).ReadOnly = true;
		dgvcTien0_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien0_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		val43.Alignment = (DataGridViewContentAlignment)64;
		val43.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCk_ht).DefaultCellStyle = val43;
		((DataGridViewColumn)dgvcCk_ht).HeaderText = "CK VND";
		dgvcCk_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCk_ht).Name = "dgvcCk_ht";
		dgvcCk_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcCk_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcCk_ht).Visible = false;
		((DataGridViewColumn)dgvcCk_ht).Width = 90;
		((DataGridViewColumn)dgvcCp_ht).DataPropertyName = "cp";
		val44.Alignment = (DataGridViewContentAlignment)64;
		val44.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_ht).DefaultCellStyle = val44;
		((DataGridViewColumn)dgvcCp_ht).HeaderText = "CP VND";
		dgvcCp_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_ht).Name = "dgvcCp_ht";
		((DataGridViewColumn)dgvcCp_ht).ReadOnly = true;
		dgvcCp_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcCp_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_ht).DataPropertyName = "tien";
		val45.Alignment = (DataGridViewContentAlignment)64;
		val45.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ht).DefaultCellStyle = val45;
		((DataGridViewColumn)dgvcTien_ht).HeaderText = "Tổng tiền VND";
		dgvcTien_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ht).Name = "dgvcTien_ht";
		((DataGridViewColumn)dgvcTien_ht).ReadOnly = true;
		dgvcTien_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_ht).Visible = false;
		dgvcTk_vt.AutoFill = true;
		dgvcTk_vt.AutoLookup = true;
		dgvcTk_vt.AutoValid = true;
		((DataGridViewColumn)dgvcTk_vt).DataPropertyName = "tk_vt";
		val46.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_vt).DefaultCellStyle = val46;
		((DataGridViewColumn)dgvcTk_vt).HeaderText = "Tk kho";
		dgvcTk_vt.LookupCodeName = "TK";
		dgvcTk_vt.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_vt).Name = "dgvcTk_vt";
		dgvcTk_vt.ReceiverValidFieldList = "ten_tk_vt";
		dgvcTk_vt.SD = true;
		dgvcTk_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_vt.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_vt).Width = 65;
		((DataGridViewColumn)dgvcTk_co).DataPropertyName = "tk_co";
		((DataGridViewColumn)dgvcTk_co).HeaderText = "Tk có";
		((DataGridViewColumn)dgvcTk_co).Name = "dgvcTk_co";
		((DataGridViewColumn)dgvcTk_co).Visible = false;
		((DataGridViewColumn)dgvcTk_co).Width = 65;
		((DataGridViewColumn)dgvcMa_vt_ht).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcMa_vt_ht).DataPropertyName = "ma_vt";
		((DataGridViewColumn)dgvcMa_vt_ht).HeaderText = "Mã hàng";
		((DataGridViewColumn)dgvcMa_vt_ht).Name = "dgvcMa_vt_ht";
		((DataGridViewColumn)dgvcMa_vt_ht).ReadOnly = true;
		dgvcMa_vt_ht.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_vt_ht).Visible = false;
		txtTk_pt.AutoLookup = true;
		txtTk_pt.AutoValid = true;
		((TextBoxBase)txtTk_pt).BackColor = SystemColors.Info;
		((TextBox)txtTk_pt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk_pt;
		location = new Point(121, 2);
		((Control)asTextBox3).Location = location;
		txtTk_pt.LookupCodeName = "TK";
		txtTk_pt.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_pt).Name = "txtTk_pt";
		txtTk_pt.NameControl = null;
		txtTk_pt.SD = true;
		AsTextBox asTextBox4 = txtTk_pt;
		size = new Size(78, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk_pt).TabIndex = 0;
		txtTk_pt.UseAutoCompleteSource = true;
		lblTk_pt.AutoSize = true;
		lblTk_pt.ImeMode = (ImeMode)0;
		Label obj45 = lblTk_pt;
		location = new Point(8, 5);
		((Control)obj45).Location = location;
		((Control)lblTk_pt).Name = "lblTk_pt";
		Label obj46 = lblTk_pt;
		size = new Size(93, 13);
		((Control)obj46).Size = size;
		((Control)lblTk_pt).TabIndex = 259;
		lblTk_pt.Text = "Tài khoản phải trả";
		lblTk_thue.AutoSize = true;
		((Control)lblTk_thue).Enabled = false;
		lblTk_thue.ImeMode = (ImeMode)0;
		Label obj47 = lblTk_thue;
		location = new Point(217, 5);
		((Control)obj47).Location = location;
		((Control)lblTk_thue).Name = "lblTk_thue";
		Label obj48 = lblTk_thue;
		size = new Size(79, 13);
		((Control)obj48).Size = size;
		((Control)lblTk_thue).TabIndex = 260;
		lblTk_thue.Text = "Tài khoản thuế";
		((Control)lblTk_thue).Visible = false;
		txtTk_thue.AutoLookup = true;
		txtTk_thue.AutoValid = true;
		((TextBoxBase)txtTk_thue).BackColor = SystemColors.Info;
		((TextBox)txtTk_thue).CharacterCasing = (CharacterCasing)1;
		((Control)txtTk_thue).Enabled = false;
		AsTextBox asTextBox5 = txtTk_thue;
		location = new Point(329, 2);
		((Control)asTextBox5).Location = location;
		txtTk_thue.LookupCodeName = "TK";
		txtTk_thue.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_thue).Name = "txtTk_thue";
		txtTk_thue.NameControl = null;
		txtTk_thue.SD = true;
		AsTextBox asTextBox6 = txtTk_thue;
		size = new Size(78, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTk_thue).TabIndex = 1;
		txtTk_thue.UseAutoCompleteSource = true;
		((Control)txtTk_thue).Visible = false;
		lblTen_httt.ImeMode = (ImeMode)0;
		Label obj49 = lblTen_httt;
		location = new Point(198, 120);
		((Control)obj49).Location = location;
		((Control)lblTen_httt).Name = "lblTen_httt";
		Label obj50 = lblTen_httt;
		size = new Size(344, 13);
		((Control)obj50).Size = size;
		((Control)lblTen_httt).TabIndex = 257;
		lblTen_httt.TextAlign = (ContentAlignment)16;
		txtMa_Httt.AutoLookup = true;
		txtMa_Httt.AutoValid = true;
		((TextBoxBase)txtMa_Httt).BackColor = SystemColors.Info;
		((TextBox)txtMa_Httt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_Httt;
		location = new Point(117, 117);
		((Control)asTextBox7).Location = location;
		txtMa_Httt.LookupCodeName = "MA_HTTT";
		txtMa_Httt.LookupWhereCondition = "moduleid='PO'";
		((Control)txtMa_Httt).Name = "txtMa_Httt";
		txtMa_Httt.NameControl = lblTen_httt;
		txtMa_Httt.SD = true;
		AsTextBox asTextBox8 = txtMa_Httt;
		size = new Size(75, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_Httt).TabIndex = 5;
		txtMa_Httt.UseAutoCompleteSource = true;
		txtMa_Httt.ValidReturnFieldList = "ten_httt,tk,tk_thue_nk,tk_thue_ttdb,tk_thue_gtgt_mua";
		Label2.AutoSize = true;
		Label2.ImeMode = (ImeMode)0;
		Label label7 = Label2;
		location = new Point(9, 121);
		((Control)label7).Location = location;
		((Control)Label2).Name = "Label2";
		Label label8 = Label2;
		size = new Size(76, 13);
		((Control)label8).Size = size;
		((Control)Label2).TabIndex = 256;
		Label2.Text = "Mã thanh toán";
		tabTain.BackColor = SystemColors.Control;
		((Control)tabTain).Controls.Add((Control)(object)cmdGetTaInFromDetail);
		((Control)tabTain).Controls.Add((Control)(object)ctlTaIn);
		TabPage obj51 = tabTain;
		location = new Point(4, 25);
		obj51.Location = location;
		((Control)tabTain).Name = "tabTain";
		TabPage obj52 = tabTain;
		((Padding)(ref val47))._002Ector(3);
		((Control)obj52).Padding = val47;
		TabPage obj53 = tabTain;
		size = new Size(748, 160);
		((Control)obj53).Size = size;
		tabTain.TabIndex = 10;
		tabTain.Text = "Thuế &gtgt";
		((Control)cmdGetTaInFromDetail).Anchor = (AnchorStyles)10;
		Button obj54 = cmdGetTaInFromDetail;
		location = new Point(600, 131);
		((Control)obj54).Location = location;
		((Control)cmdGetTaInFromDetail).Name = "cmdGetTaInFromDetail";
		Button obj55 = cmdGetTaInFromDetail;
		size = new Size(140, 23);
		((Control)obj55).Size = size;
		((Control)cmdGetTaInFromDetail).TabIndex = 1;
		((ButtonBase)cmdGetTaInFromDetail).Text = "Lấ&y từ chi tiết";
		ctlTaIn.DataSource = bsTain;
		((Control)ctlTaIn).Dock = (DockStyle)5;
		ctlTaIn.HasThueNK = false;
		ctlTaIn.HasThueTTDB = false;
		ctlTaIn obj56 = ctlTaIn;
		location = new Point(3, 3);
		((Control)obj56).Location = location;
		ctlTaIn obj57 = ctlTaIn;
		((Padding)(ref val47))._002Ector(0);
		((Control)obj57).Margin = val47;
		((Control)ctlTaIn).Name = "ctlTaIn";
		ctlTaIn.PHDataSource = bsPH;
		ctlTaIn obj58 = ctlTaIn;
		size = new Size(742, 154);
		((Control)obj58).Size = size;
		((Control)ctlTaIn).TabIndex = 0;
		ctlTaIn.TAINTable = null;
		ctlTaIn.Tk_Du = "";
		ctlTaIn.Tk_Thue = "";
		((Control)Label12).Anchor = (AnchorStyles)6;
		Label12.AutoSize = true;
		Label12.ImeMode = (ImeMode)0;
		Label label9 = Label12;
		location = new Point(352, 343);
		((Control)label9).Location = location;
		((Control)Label12).Name = "Label12";
		Label label10 = Label12;
		size = new Size(59, 13);
		((Control)label10).Size = size;
		((Control)Label12).TabIndex = 268;
		Label12.Text = "Tổng cộng";
		((Control)txtT_thue_Nt).Anchor = (AnchorStyles)6;
		txtT_thue_Nt.DecimalSymbol = ".";
		((Control)txtT_thue_Nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric9 = txtT_thue_Nt;
		location = new Point(547, 406);
		((Control)asTextNumeric9).Location = location;
		txtT_thue_Nt.Mask = "### ### ### ###";
		((Control)txtT_thue_Nt).Name = "txtT_thue_Nt";
		((TextBoxBase)txtT_thue_Nt).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtT_thue_Nt;
		size = new Size(100, 20);
		((Control)asTextNumeric10).Size = size;
		txtT_thue_Nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_thue_Nt).TabIndex = 275;
		((Control)txtT_thue_Nt).TabStop = false;
		((TextBox)txtT_thue_Nt).Text = "0";
		((TextBox)txtT_thue_Nt).TextAlign = (HorizontalAlignment)1;
		txtT_thue_Nt.Value = 0.0;
		((Control)txtT_Thue).Anchor = (AnchorStyles)6;
		txtT_Thue.DecimalSymbol = ".";
		((Control)txtT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric11 = txtT_Thue;
		location = new Point(653, 406);
		((Control)asTextNumeric11).Location = location;
		txtT_Thue.Mask = "### ### ### ###";
		((Control)txtT_Thue).Name = "txtT_Thue";
		((TextBoxBase)txtT_Thue).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtT_Thue;
		size = new Size(100, 20);
		((Control)asTextNumeric12).Size = size;
		txtT_Thue.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Thue).TabIndex = 273;
		((Control)txtT_Thue).TabStop = false;
		((TextBox)txtT_Thue).Text = "0";
		((TextBox)txtT_Thue).TextAlign = (HorizontalAlignment)1;
		txtT_Thue.Value = 0.0;
		((Control)txtT_tt).Anchor = (AnchorStyles)6;
		txtT_tt.DecimalSymbol = ".";
		((Control)txtT_tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric13 = txtT_tt;
		location = new Point(653, 428);
		((Control)asTextNumeric13).Location = location;
		txtT_tt.Mask = "### ### ### ###";
		((Control)txtT_tt).Name = "txtT_tt";
		((TextBoxBase)txtT_tt).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtT_tt;
		size = new Size(100, 20);
		((Control)asTextNumeric14).Size = size;
		txtT_tt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_tt).TabIndex = 271;
		((Control)txtT_tt).TabStop = false;
		((TextBox)txtT_tt).Text = "0";
		((TextBox)txtT_tt).TextAlign = (HorizontalAlignment)1;
		txtT_tt.Value = 0.0;
		((Control)txtT_tt_nt).Anchor = (AnchorStyles)6;
		txtT_tt_nt.DecimalSymbol = ".";
		((Control)txtT_tt_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric15 = txtT_tt_nt;
		location = new Point(547, 428);
		((Control)asTextNumeric15).Location = location;
		txtT_tt_nt.Mask = "### ### ### ###";
		((Control)txtT_tt_nt).Name = "txtT_tt_nt";
		((TextBoxBase)txtT_tt_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric16 = txtT_tt_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric16).Size = size;
		txtT_tt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tt_nt).TabIndex = 272;
		((Control)txtT_tt_nt).TabStop = false;
		((TextBox)txtT_tt_nt).Text = "0";
		((TextBox)txtT_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tt_nt.Value = 0.0;
		((Control)txtT_Tien_nt0).Anchor = (AnchorStyles)6;
		txtT_Tien_nt0.DecimalSymbol = ".";
		((Control)txtT_Tien_nt0).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric17 = txtT_Tien_nt0;
		location = new Point(547, 340);
		((Control)asTextNumeric17).Location = location;
		txtT_Tien_nt0.Mask = "### ### ### ###";
		((Control)txtT_Tien_nt0).Name = "txtT_Tien_nt0";
		((TextBoxBase)txtT_Tien_nt0).ReadOnly = true;
		AsTextNumeric asTextNumeric18 = txtT_Tien_nt0;
		size = new Size(100, 20);
		((Control)asTextNumeric18).Size = size;
		txtT_Tien_nt0.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_Tien_nt0).TabIndex = 267;
		((Control)txtT_Tien_nt0).TabStop = false;
		((TextBox)txtT_Tien_nt0).Text = "0";
		((TextBox)txtT_Tien_nt0).TextAlign = (HorizontalAlignment)1;
		txtT_Tien_nt0.Value = 0.0;
		((Control)txtT_Tien0).Anchor = (AnchorStyles)6;
		txtT_Tien0.DecimalSymbol = ".";
		((Control)txtT_Tien0).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric19 = txtT_Tien0;
		location = new Point(653, 340);
		((Control)asTextNumeric19).Location = location;
		txtT_Tien0.Mask = "### ### ### ###";
		((Control)txtT_Tien0).Name = "txtT_Tien0";
		((TextBoxBase)txtT_Tien0).ReadOnly = true;
		AsTextNumeric asTextNumeric20 = txtT_Tien0;
		size = new Size(100, 20);
		((Control)asTextNumeric20).Size = size;
		txtT_Tien0.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tien0).TabIndex = 264;
		((Control)txtT_Tien0).TabStop = false;
		((TextBox)txtT_Tien0).Text = "0";
		((TextBox)txtT_Tien0).TextAlign = (HorizontalAlignment)1;
		txtT_Tien0.Value = 0.0;
		((Control)lblT_Thue).Anchor = (AnchorStyles)6;
		lblT_Thue.AutoSize = true;
		((Control)lblT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Thue.ImeMode = (ImeMode)0;
		Label obj59 = lblT_Thue;
		location = new Point(352, 409);
		((Control)obj59).Location = location;
		((Control)lblT_Thue).Name = "lblT_Thue";
		Label obj60 = lblT_Thue;
		size = new Size(65, 13);
		((Control)obj60).Size = size;
		((Control)lblT_Thue).TabIndex = 274;
		lblT_Thue.Text = "Thuế GTGT";
		((Control)Label8).Anchor = (AnchorStyles)6;
		Label8.AutoSize = true;
		((Control)Label8).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label8.ImeMode = (ImeMode)0;
		Label label11 = Label8;
		location = new Point(352, 431);
		((Control)label11).Location = location;
		((Control)Label8).Name = "Label8";
		Label label12 = Label8;
		size = new Size(72, 13);
		((Control)label12).Size = size;
		((Control)Label8).TabIndex = 270;
		Label8.Text = "Thanh toán";
		Label8.TextAlign = (ContentAlignment)16;
		((Control)txtT_cp_nt).Anchor = (AnchorStyles)6;
		txtT_cp_nt.DecimalSymbol = ".";
		((Control)txtT_cp_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric21 = txtT_cp_nt;
		location = new Point(547, 384);
		((Control)asTextNumeric21).Location = location;
		txtT_cp_nt.Mask = "### ### ### ###";
		((Control)txtT_cp_nt).Name = "txtT_cp_nt";
		((TextBoxBase)txtT_cp_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric22 = txtT_cp_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric22).Size = size;
		txtT_cp_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_cp_nt).TabIndex = 266;
		((Control)txtT_cp_nt).TabStop = false;
		((TextBox)txtT_cp_nt).Text = "0";
		((TextBox)txtT_cp_nt).TextAlign = (HorizontalAlignment)1;
		txtT_cp_nt.Value = 0.0;
		txtT_tien_nt.DecimalSymbol = ".";
		((Control)txtT_tien_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric23 = txtT_tien_nt;
		location = new Point(5, 436);
		((Control)asTextNumeric23).Location = location;
		txtT_tien_nt.Mask = "### ### ### ###";
		((Control)txtT_tien_nt).Name = "txtT_tien_nt";
		((TextBoxBase)txtT_tien_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric24 = txtT_tien_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric24).Size = size;
		txtT_tien_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tien_nt).TabIndex = 267;
		((Control)txtT_tien_nt).TabStop = false;
		((TextBox)txtT_tien_nt).Text = "0";
		((TextBox)txtT_tien_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tien_nt.Value = 0.0;
		((Control)txtT_tien_nt).Visible = false;
		((Control)Label7).Anchor = (AnchorStyles)6;
		Label7.AutoSize = true;
		((Control)Label7).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label7.ImeMode = (ImeMode)0;
		Label label13 = Label7;
		location = new Point(352, 387);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(41, 13);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 263;
		Label7.Text = "Chi phí";
		Label7.TextAlign = (ContentAlignment)16;
		((Control)txtT_So_luong).Anchor = (AnchorStyles)6;
		txtT_So_luong.DecimalSymbol = ".";
		((Control)txtT_So_luong).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric25 = txtT_So_luong;
		location = new Point(441, 340);
		((Control)asTextNumeric25).Location = location;
		txtT_So_luong.Mask = "### ### ### ###";
		((Control)txtT_So_luong).Name = "txtT_So_luong";
		((TextBoxBase)txtT_So_luong).ReadOnly = true;
		AsTextNumeric asTextNumeric26 = txtT_So_luong;
		size = new Size(100, 20);
		((Control)asTextNumeric26).Size = size;
		txtT_So_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((Control)txtT_So_luong).TabIndex = 269;
		((Control)txtT_So_luong).TabStop = false;
		((TextBox)txtT_So_luong).Text = "0";
		((TextBox)txtT_So_luong).TextAlign = (HorizontalAlignment)1;
		txtT_So_luong.Value = 0.0;
		((Control)Label5).Anchor = (AnchorStyles)6;
		Label5.AutoSize = true;
		((Control)Label5).Enabled = false;
		((Control)Label5).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label5.ImeMode = (ImeMode)0;
		Label label15 = Label5;
		location = new Point(241, 388);
		((Control)label15).Location = location;
		((Control)Label5).Name = "Label5";
		Label label16 = Label5;
		size = new Size(49, 13);
		((Control)label16).Size = size;
		((Control)Label5).TabIndex = 268;
		Label5.Text = "Số lượng";
		Label5.TextAlign = (ContentAlignment)16;
		((Control)Label5).Visible = false;
		((Control)txtT_cp).Anchor = (AnchorStyles)6;
		txtT_cp.DecimalSymbol = ".";
		((Control)txtT_cp).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric27 = txtT_cp;
		location = new Point(653, 384);
		((Control)asTextNumeric27).Location = location;
		txtT_cp.Mask = "### ### ### ###";
		((Control)txtT_cp).Name = "txtT_cp";
		((TextBoxBase)txtT_cp).ReadOnly = true;
		AsTextNumeric asTextNumeric28 = txtT_cp;
		size = new Size(100, 20);
		((Control)asTextNumeric28).Size = size;
		txtT_cp.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_cp).TabIndex = 265;
		((Control)txtT_cp).TabStop = false;
		((TextBox)txtT_cp).Text = "0";
		((TextBox)txtT_cp).TextAlign = (HorizontalAlignment)1;
		txtT_cp.Value = 0.0;
		txtNgay_hd.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_hd).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_hd;
		location = new Point(664, 79);
		((Control)asMaskedTextBox5).Location = location;
		((MaskedTextBox)txtNgay_hd).Mask = "##/##/####";
		((Control)txtNgay_hd).Name = "txtNgay_hd";
		((MaskedTextBox)txtNgay_hd).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_hd;
		size = new Size(78, 20);
		((Control)asMaskedTextBox6).Size = size;
		((Control)txtNgay_hd).TabIndex = 9;
		((MaskedTextBox)txtNgay_hd).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox7 = txtNgay_hd;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox7.Value = dateTime;
		Label4.AutoSize = true;
		Label4.ImeMode = (ImeMode)0;
		Label label17 = Label4;
		location = new Point(565, 81);
		((Control)label17).Location = location;
		((Control)Label4).Name = "Label4";
		Label label18 = Label4;
		size = new Size(75, 13);
		((Control)label18).Size = size;
		((Control)Label4).TabIndex = 262;
		Label4.Text = "Ngày hoá đơn";
		Label6.AutoSize = true;
		Label6.ImeMode = (ImeMode)0;
		Label label19 = Label6;
		location = new Point(565, 104);
		((Control)label19).Location = location;
		((Control)Label6).Name = "Label6";
		Label label20 = Label6;
		size = new Size(63, 13);
		((Control)label20).Size = size;
		((Control)Label6).TabIndex = 264;
		Label6.Text = "Số hoá đơn";
		TextBox obj61 = txtSo_hd;
		location = new Point(664, 101);
		((Control)obj61).Location = location;
		((TextBoxBase)txtSo_hd).MaxLength = 12;
		((Control)txtSo_hd).Name = "txtSo_hd";
		TextBox obj62 = txtSo_hd;
		size = new Size(78, 20);
		((Control)obj62).Size = size;
		((Control)txtSo_hd).TabIndex = 10;
		((Control)txtT_Tien).Anchor = (AnchorStyles)6;
		txtT_Tien.DecimalSymbol = ".";
		((Control)txtT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric29 = txtT_Tien;
		location = new Point(228, 408);
		((Control)asTextNumeric29).Location = location;
		txtT_Tien.Mask = "### ### ### ###";
		((Control)txtT_Tien).Name = "txtT_Tien";
		((TextBoxBase)txtT_Tien).ReadOnly = true;
		AsTextNumeric asTextNumeric30 = txtT_Tien;
		size = new Size(100, 20);
		((Control)asTextNumeric30).Size = size;
		txtT_Tien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tien).TabIndex = 266;
		((Control)txtT_Tien).TabStop = false;
		((TextBox)txtT_Tien).Text = "0";
		((TextBox)txtT_Tien).TextAlign = (HorizontalAlignment)1;
		txtT_Tien.Value = 0.0;
		((Control)txtT_Tien).Visible = false;
		lblDia_chi.AutoSize = true;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj63 = lblDia_chi;
		location = new Point(9, 43);
		((Control)obj63).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj64 = lblDia_chi;
		size = new Size(40, 13);
		((Control)obj64).Size = size;
		((Control)lblDia_chi).TabIndex = 266;
		lblDia_chi.Text = "Địa chỉ";
		TextBox obj65 = txtDia_chi;
		location = new Point(117, 39);
		((Control)obj65).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj66 = txtDia_chi;
		size = new Size(425, 20);
		((Control)obj66).Size = size;
		((Control)txtDia_chi).TabIndex = 1;
		lblMa_so_thue.AutoSize = true;
		lblMa_so_thue.ImeMode = (ImeMode)0;
		Label obj67 = lblMa_so_thue;
		location = new Point(308, 69);
		((Control)obj67).Location = location;
		((Control)lblMa_so_thue).Name = "lblMa_so_thue";
		Label obj68 = lblMa_so_thue;
		size = new Size(60, 13);
		((Control)obj68).Size = size;
		((Control)lblMa_so_thue).TabIndex = 268;
		lblMa_so_thue.Text = "Mã số thuế";
		lblMa_so_thue.TextAlign = (ContentAlignment)16;
		TextBox obj69 = txtMa_so_thue;
		location = new Point(414, 65);
		((Control)obj69).Location = location;
		((Control)txtMa_so_thue).Name = "txtMa_so_thue";
		TextBox obj70 = txtMa_so_thue;
		size = new Size(128, 20);
		((Control)obj70).Size = size;
		((Control)txtMa_so_thue).TabIndex = 3;
		((Control)cmdThanh_toan).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdThanh_toan).Image = (Image)componentResourceManager.GetObject("cmdThanh_toan.Image");
		((ButtonBase)cmdThanh_toan).ImageAlign = (ContentAlignment)16;
		Button obj71 = cmdThanh_toan;
		location = new Point(143, 460);
		((Control)obj71).Location = location;
		((Control)cmdThanh_toan).Name = "cmdThanh_toan";
		Button obj72 = cmdThanh_toan;
		size = new Size(64, 23);
		((Control)obj72).Size = size;
		((Control)cmdThanh_toan).TabIndex = 8;
		((ButtonBase)cmdThanh_toan).Text = "Chi tiền";
		((ButtonBase)cmdThanh_toan).TextAlign = (ContentAlignment)64;
		((Control)txtTl_ck_hd).Anchor = (AnchorStyles)6;
		txtTl_ck_hd.DecimalSymbol = ".";
		((Control)txtTl_ck_hd).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric31 = txtTl_ck_hd;
		location = new Point(490, 362);
		((Control)asTextNumeric31).Location = location;
		txtTl_ck_hd.Mask = "### ### ### ###.0#";
		((Control)txtTl_ck_hd).Name = "txtTl_ck_hd";
		((TextBoxBase)txtTl_ck_hd).ReadOnly = true;
		AsTextNumeric asTextNumeric32 = txtTl_ck_hd;
		size = new Size(51, 20);
		((Control)asTextNumeric32).Size = size;
		((Control)txtTl_ck_hd).TabIndex = 3;
		((TextBox)txtTl_ck_hd).Text = "0.00";
		((TextBox)txtTl_ck_hd).TextAlign = (HorizontalAlignment)1;
		txtTl_ck_hd.Value = 0.0;
		((Control)txtT_ck).Anchor = (AnchorStyles)6;
		txtT_ck.DecimalSymbol = ".";
		((Control)txtT_ck).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric33 = txtT_ck;
		location = new Point(653, 362);
		((Control)asTextNumeric33).Location = location;
		txtT_ck.Mask = "### ### ### ###";
		((Control)txtT_ck).Name = "txtT_ck";
		((TextBoxBase)txtT_ck).ReadOnly = true;
		AsTextNumeric asTextNumeric34 = txtT_ck;
		size = new Size(100, 20);
		((Control)asTextNumeric34).Size = size;
		txtT_ck.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_ck).TabIndex = 5;
		((TextBox)txtT_ck).Text = "0";
		((TextBox)txtT_ck).TextAlign = (HorizontalAlignment)1;
		txtT_ck.Value = 0.0;
		((Control)txtT_ck_nt).Anchor = (AnchorStyles)6;
		txtT_ck_nt.DecimalSymbol = ".";
		((Control)txtT_ck_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric35 = txtT_ck_nt;
		location = new Point(547, 362);
		((Control)asTextNumeric35).Location = location;
		txtT_ck_nt.Mask = "### ### ### ###";
		((Control)txtT_ck_nt).Name = "txtT_ck_nt";
		((TextBoxBase)txtT_ck_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric36 = txtT_ck_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric36).Size = size;
		txtT_ck_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_ck_nt).TabIndex = 4;
		((TextBox)txtT_ck_nt).Text = "0";
		((TextBox)txtT_ck_nt).TextAlign = (HorizontalAlignment)1;
		txtT_ck_nt.Value = 0.0;
		((Control)Label1).Anchor = (AnchorStyles)6;
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label1.ImeMode = (ImeMode)0;
		Label label21 = Label1;
		location = new Point(352, 365);
		((Control)label21).Location = location;
		((Control)Label1).Name = "Label1";
		Label label22 = Label1;
		size = new Size(58, 13);
		((Control)label22).Size = size;
		((Control)Label1).TabIndex = 279;
		Label1.Text = "Chiết khấu";
		Label1.TextAlign = (ContentAlignment)16;
		((Control)chkCk_st).Anchor = (AnchorStyles)6;
		((ButtonBase)chkCk_st).AutoSize = true;
		chkCk_st.Checked = false;
		AsCheckBox asCheckBox = chkCk_st;
		location = new Point(3, 338);
		((Control)asCheckBox).Location = location;
		((Control)chkCk_st).Name = "chkCk_st";
		AsCheckBox asCheckBox2 = chkCk_st;
		size = new Size(121, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkCk_st).TabIndex = 280;
		((Control)chkCk_st).TabStop = false;
		((ButtonBase)chkCk_st).Text = "Chiết khấu sau thuế";
		chkCk_st.TextValue = "0";
		((ButtonBase)chkCk_st).UseVisualStyleBackColor = true;
		((ButtonBase)cmdChon_dh).ImageAlign = (ContentAlignment)16;
		Button obj73 = cmdChon_dh;
		location = new Point(627, 150);
		((Control)obj73).Location = location;
		((Control)cmdChon_dh).Name = "cmdChon_dh";
		Button obj74 = cmdChon_dh;
		size = new Size(118, 23);
		((Control)obj74).Size = size;
		((Control)cmdChon_dh).TabIndex = 1;
		((ButtonBase)cmdChon_dh).Text = "Chọn đơn hàng";
		size = new Size(757, 508);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdChon_dh);
		((Control)this).Controls.Add((Control)(object)chkCk_st);
		((Control)this).Controls.Add((Control)(object)txtTl_ck_hd);
		((Control)this).Controls.Add((Control)(object)txtT_ck);
		((Control)this).Controls.Add((Control)(object)txtT_ck_nt);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)cmdThanh_toan);
		((Control)this).Controls.Add((Control)(object)Label12);
		((Control)this).Controls.Add((Control)(object)txtT_thue_Nt);
		((Control)this).Controls.Add((Control)(object)txtT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_tt);
		((Control)this).Controls.Add((Control)(object)txtT_tt_nt);
		((Control)this).Controls.Add((Control)(object)txtT_Tien_nt0);
		((Control)this).Controls.Add((Control)(object)txtT_Tien0);
		((Control)this).Controls.Add((Control)(object)lblT_Thue);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)txtT_So_luong);
		((Control)this).Controls.Add((Control)(object)txtT_cp_nt);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)txtT_Tien);
		((Control)this).Controls.Add((Control)(object)txtT_tien_nt);
		((Control)this).Controls.Add((Control)(object)txtT_cp);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmPOVchPO3";
		((Form)this).Text = "frmPOVchPO3";
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_cp, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tien_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_cp_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_So_luong, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien0, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien_nt0, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_thue_Nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label12, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdThanh_toan, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtTl_ck_hd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkCk_st, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdChon_dh, 0);
		((Control)gbPH).ResumeLayout(false);
		((Control)gbPH).PerformLayout();
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabDetail).ResumeLayout(false);
		((ISupportInitialize)bsPH).EndInit();
		((ISupportInitialize)bsCT).EndInit();
		((ISupportInitialize)bsCP).EndInit();
		((ISupportInitialize)bsTain).EndInit();
		((ISupportInitialize)bsTaout).EndInit();
		((Control)tabChi_phi).ResumeLayout(false);
		((Control)sCChiPhi.Panel1).ResumeLayout(false);
		((Control)sCChiPhi.Panel2).ResumeLayout(false);
		((Control)sCChiPhi.Panel2).PerformLayout();
		((Control)sCChiPhi).ResumeLayout(false);
		((ISupportInitialize)adgvChi_phi).EndInit();
		((ISupportInitialize)adgvDetail).EndInit();
		((Control)tabHach_toan).ResumeLayout(false);
		((Control)SplitContainer1.Panel1).ResumeLayout(false);
		((Control)SplitContainer1.Panel2).ResumeLayout(false);
		((Control)SplitContainer1.Panel2).PerformLayout();
		((Control)SplitContainer1).ResumeLayout(false);
		((ISupportInitialize)adgvHach_toan).EndInit();
		((Control)tabTain).ResumeLayout(false);
		((ISupportInitialize)bsTT_PB).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdPhan_bo_Click(object sender, EventArgs e)
	{
		if (ActionMode != Commons.ApplicationMode.VIEW_MODE && ((CT1Voucher != null && CT1Voucher.Count > 0) ? true : false))
		{
			Calc_ChiPhiMuaHang();
		}
	}

	private void cboMa_NT_SelectedValueChanged(object sender, EventArgs e)
	{
		if (!IsLoading)
		{
			RefreshDGVInput();
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				RefreshValueByMa_Nt();
				txtTy_gia_Validated(null, null);
			}
			ctlTaIn.Ma_Nt = cboMa_NT.MA_NT;
		}
	}

	private void txtMa_Kh_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if ((base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !((TextBoxBase)txtMa_Kh).ReadOnly && ((Control)txtMa_Kh).Enabled && ((Control)txtMa_Kh).Visible && e.ValidatedRow != null) || 1 == 0)
		{
			txtNguoi_Gd.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["nguoi_gd"]), isNum: false));
			txtDia_chi.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["dia_chi"]), isNum: false));
			txtMa_so_thue.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_so_thue"]), isNum: false));
			((TextBox)txtMa_Httt).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["MA_HTTT_PO"]), isNum: false));
			txtMa_Httt.ForcedValid();
		}
	}

	private void txtMa_Httt_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (base.ActionMode != Commons.ApplicationMode.VIEW_MODE && e.ValidatedRow != null && 0 == 0)
		{
			((TextBox)txtTk_pt).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			txtTk_pt.ForcedValid();
			setCTValue("tk_thue", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_mua"]), isNum: false)));
			setCTValue("tk_thue_nk", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_nk"]), isNum: false)));
			setCTValue("tk_thue_ttdb", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_ttdb"]), isNum: false)));
			ctlTaIn.Tk_Du = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			ctlTaIn.Tk_Thue = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_mua"]), isNum: false));
		}
	}

	private void txtTy_gia_Validated(object sender, EventArgs e)
	{
		if ((!base.IsLoading && base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !IsValidateCalledFromValidData) || 1 == 0)
		{
			V_Ty_Gia();
			ctlTaIn.Ty_Gia = Conversions.ToDouble(txtTy_gia.Value);
		}
	}

	private void adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged(object sender, SetDependentFieldsWhenCellValueChangedEventArgs e)
	{
		if (e.ValidatedRow != null && (!base.MyVoucherInfo.ct_carry_field_list.ToUpper().Contains("MA_KHO") || ((DataGridViewCellEventArgs)e).RowIndex <= 0) && 0 == 0 && ((((DataGridView)adgvDetail).Columns[((DataGridViewCellEventArgs)e).ColumnIndex].Name.Equals(((DataGridViewColumn)dgvcMa_vt).Name) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_kho"]), isNum: false), (object)"", false)) ? true : false))
		{
			CurrentCTRowView["ma_kho"] = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_kho"]);
			((DataGridView)dgvDetail).AutoResizeColumn(((DataGridViewBand)dgvcMa_kho).Index);
			DataRow pDrw = null;
			if (Commons.ValidMa(ref pDrw, "MA_KHO", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentCTRowView["ma_kho"]), isNum: false)), "", "kho_dl,tk_dl", pSd: true) && ((Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)true, false) && Operators.ConditionalCompareObjectNotEqual(pDrw["tk_dl"], (object)"", false)) ? true : false))
			{
				CurrentCTRowView["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["tk_dl"]);
			}
		}
	}

	private void adgvDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if ((CTTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			bool flag = true;
			DataRowView currentCTRowView = CurrentCTRowView;
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcSo_luong).Name, false) == 0)
			{
				V_So_Luong(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_nt0).Name, false) == 0)
			{
				V_Gia_Nt0(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia0).Name, false) == 0)
			{
				V_Gia0(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt0).Name, false) == 0)
			{
				V_Tien_nt0(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien0).Name, false) == 0)
			{
				V_Tien0(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTs_gtgt).Name, false) == 0)
			{
				V_Ts_gtgt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt_nt).Name, false) == 0)
			{
				V_Thue_gtgt_nt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt).Name, false) == 0)
			{
				V_Thue_gtgt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTl_ck).Name, false) == 0)
			{
				V_Tl_Ck(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcCk_nt).Name, false) == 0)
			{
				V_Ck_Nt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcCk).Name, false) == 0)
			{
				V_Ck(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_vt).Name, false) == 0)
			{
				V_Ma_Vt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kho).Name, false) == 0)
			{
				V_Ma_Kho(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_cp_nt).Name, false) == 0)
			{
				V_Tien_Cp_Nt_ChiTiet(currentCTRowView);
			}
			else
			{
				flag = false;
			}
			if (flag)
			{
				((DataGridView)adgvDetail).InvalidateRow(e.RowIndex);
			}
		}
	}

	private void adgvDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if ((CTTable == null || e.RowIndex < 0 || base.IsLoading) ? true : false)
		{
			return;
		}
		DataRowView currentCTRowView = CurrentCTRowView;
		try
		{
			object obj = null;
			DataGridViewCell currentCell = ((DataGridView)adgvDetail).CurrentCell;
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt0).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Nt0(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien0).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien0(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia0).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Gia0(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Thue_Gtgt_Nt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Thue_Gtgt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_vt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Ma_Vt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kho).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(currentCTRowView["ten_kho"]);
			}
			obj = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(obj), isNum: false));
			((ToolStripItem)tsslInfo).Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(obj, (object)"", false), (object)frmVoucher.BASEVOUCHER_INPUTGRID_TIP_TEXT, RuntimeHelpers.GetObjectValue(obj)));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			((ToolStripItem)tsslInfo).Text = frmVoucher.BASEVOUCHER_INPUTGRID_TIP_TEXT;
			ProjectData.ClearProjectError();
		}
	}

	private void adgvDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
	{
		if ((ActionMode != Commons.ApplicationMode.VIEW_MODE && CTTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			DataRowView dataRowView = CT1Voucher[e.RowIndex];
		}
	}

	private void adgvChi_phi_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if ((CPTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			DataRowView currentCPRowView = CurrentCPRowView;
			DataGridViewCell currentCell = ((DataGridView)adgvChi_phi).CurrentCell;
			string name = ((DataGridView)adgvChi_phi).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt_nt_cp).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Thue_Gtgt_Nt_cp(currentCPRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_Gtgt_cp).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Thue_Gtgt_cp(currentCPRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_cp_cp).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Cp(currentCPRowView);
			}
		}
	}

	private void adgvChi_phi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if ((CPTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			bool flag = true;
			DataRowView currentCPRowView = CurrentCPRowView;
			string name = ((DataGridView)adgvChi_phi).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_cp_nt_cp).Name, false) == 0)
			{
				V_Tien_Cp_Nt(currentCPRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_cp_cp).Name, false) == 0)
			{
				V_Tien_Cp(currentCPRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTs_gtgt_cp).Name, false) == 0)
			{
				V_Ts_gtgt_cp(currentCPRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt_nt_cp).Name, false) == 0)
			{
				V_Thue_gtgt_nt_cp(currentCPRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_Gtgt_cp).Name, false) == 0)
			{
				V_Thue_gtgt_cp(currentCPRowView);
			}
			else
			{
				flag = false;
			}
			if (flag)
			{
				((DataGridView)adgvChi_phi).InvalidateRow(e.RowIndex);
			}
		}
	}

	private void adgvChi_phi_MyProcessCmdKey(object sender, KeyEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			if ((int)e.KeyCode == 115)
			{
				InsertChiPhiRow();
			}
			else if (((int)e.KeyCode == 119 && ((DataGridView)adgvChi_phi).RowCount > 0) ? true : false)
			{
				DeleteChiPhiRow();
				UpdateCPList();
			}
		}
	}

	private void ctlTaIn_TAINValueChanged(object sender, EventArgs e)
	{
		UpdateList();
	}

	private void txtTl_ck_hd_ValueChanged(object sender, EventArgs e)
	{
		if ((!base.IsLoading && base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !IsValidateCalledFromValidData) || 1 == 0)
		{
			Calc_Ck_hd();
			UpdateList();
		}
	}

	private void txtT_ck_nt_ValueChanged(object sender, EventArgs e)
	{
		if ((base.IsLoading || base.ActionMode == Commons.ApplicationMode.VIEW_MODE || IsValidateCalledFromValidData) ? true : false)
		{
			return;
		}
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			AsTextNumeric asTextNumeric = txtT_ck;
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtT_ck_nt.Value), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array2 = array;
			bool[] array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj);
		}
		PhanBoChietKhauHoaDon();
		UpdateList();
	}

	private void txtT_ck_ValueChanged(object sender, EventArgs e)
	{
		if ((!base.IsLoading && base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !IsValidateCalledFromValidData) || 1 == 0)
		{
			PhanBoChietKhauHoaDon();
			UpdateList();
		}
	}

	private void chkCk_st_CheckedChanged(object sender, EventArgs e)
	{
		if (base.ActionMode == Commons.ApplicationMode.VIEW_MODE)
		{
			return;
		}
		Calc_Ck_hd();
		foreach (DataRowView item in base.CT1Voucher)
		{
			Calc_ChietKhau(item);
			Calc_Thue_gtgt(item);
			Calc_ThanhToan(item);
		}
		UpdateList();
	}

	private void cmdGetTaInFromDetail_Click(object sender, EventArgs e)
	{
		GetTaInFromDetail();
		UpdateList();
	}

	private void cmdThanh_toan_Click(object sender, EventArgs e)
	{
		Thanh_toan();
	}

	private bool W_Ma_Vt(DataRowView oDv)
	{
		return Conversions.ToBoolean((!Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["stt_rec_pn"]), isNum: false), (object)"", false)) || !Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["stt_rec_dh"]), isNum: false), (object)"", false))) ? ((object)false) : ((object)true));
	}

	private bool W_Tien_Nt0(DataRowView oDv)
	{
		return true;
	}

	private bool W_Tien0(DataRowView oDv)
	{
		return true;
	}

	private bool W_Gia0(DataRowView oDv)
	{
		return true;
	}

	private bool W_Thue_Gtgt_Nt(DataRowView oDv)
	{
		return true;
	}

	private bool W_Thue_Gtgt(DataRowView oDv)
	{
		return true;
	}

	private void V_Ma_Vt(DataRowView oDv)
	{
		ReCalcTonKhoTucThoi(oDv);
		if (Operators.CompareString(AsiaErp.Framework.Environment.GetPOConfiguration().lay_gia_nhap, "0", false) != 0)
		{
			oDv["gia_nt0"] = POCommon.Get_GiaNhap(CompanyInformations.CompanyID, Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_vt"]), isNum: false)), cboMa_NT.MA_NT, Conversions.ToDate(txtNgay_Ct.Value));
			V_Gia_Nt0(oDv);
		}
	}

	private void V_Ma_Kho(DataRowView oDv)
	{
		ReCalcTonKhoTucThoi(oDv);
		DataRow pDrw = null;
		if (Commons.ValidMa(ref pDrw, "MA_KHO", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_kho"]), isNum: false)), "", "kho_dl,tk_dl", pSd: true) && ((Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)true, false) && Operators.ConditionalCompareObjectNotEqual(pDrw["tk_dl"], (object)"", false)) ? true : false))
		{
			oDv["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["tk_dl"]);
		}
		if ((pDrw != null && Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)false, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["MA_VT"]), isNum: false), (object)"", false)) ? true : false)
		{
			Commons.ValidMa(ref pDrw, "MA_VT", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["MA_VT"]), isNum: false)), "", "TK_VT", pSd: true);
			oDv["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["TK_VT"]);
		}
	}

	private void V_So_Luong(DataRowView oDv)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		int num = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num = 1;
		}
		Calc_TienMua(oDv);
		if (num == 1)
		{
			Calc_Thue_gtgt(oDv);
			Calc_ChietKhau(oDv);
		}
		else
		{
			Calc_Thue_gtgt(oDv);
			Calc_ChietKhau(oDv);
		}
		Calc_TienVon(oDv);
		Calc_So_luong_qd(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Gia_Nt0(DataRowView oDv)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		Calc_GiaMua(oDv);
		Calc_TienMua(oDv);
		int num = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num = 1;
		}
		if (num == 1)
		{
			Calc_Thue_gtgt(oDv);
			Calc_ChietKhau(oDv);
		}
		else
		{
			Calc_Thue_gtgt(oDv);
			Calc_ChietKhau(oDv);
		}
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Gia0(DataRowView oDv)
	{
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Invalid comparison between Unknown and I4
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia0"]), isNum: true)),
			null,
			null
		};
		object[] array2 = array;
		SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
		array2[1] = sIConfiguration.Round;
		array[2] = MidpointRounding.AwayFromZero;
		object[] array3 = array;
		object[] array4 = array3;
		bool[] array5 = new bool[3] { false, true, false };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
		if (array5[1])
		{
			sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
		}
		double num = Conversions.ToDouble(obj);
		if (num != 0.0)
		{
			oDv["Tien0"] = num;
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt0"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array6 = array3;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			array = array3;
			object[] array7 = array;
			array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien0"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		int num2 = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num2 = 1;
		}
		if (num2 == 1)
		{
			Calc_Thue_gtgt(oDv);
			Calc_ChietKhau(oDv);
		}
		else
		{
			Calc_Thue_gtgt(oDv);
			Calc_ChietKhau(oDv);
		}
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien_nt0(DataRowView oDv)
	{
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Invalid comparison between Unknown and I4
		bool flag = Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0;
		if (flag)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt0"]), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			oDv["Tien0"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia0"]), isNum: true)),
				null,
				null
			};
			object[] array6 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array7 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			double num = Conversions.ToDouble(obj2);
			if (num != 0.0)
			{
				oDv["Tien0"] = num;
			}
			else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
			{
				Type? typeFromHandle3 = typeof(Math);
				array3 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt0"]), isNum: true), txtTy_gia.Value),
					null,
					null
				};
				object[] array8 = array3;
				sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array8[1] = sIConfiguration.Round;
				array3[2] = MidpointRounding.AwayFromZero;
				array = array3;
				object[] array9 = array;
				array5 = new bool[3] { false, true, false };
				object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array9, (string[])null, (Type[])null, array5);
				if (array5[1])
				{
					sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				oDv["Tien0"] = RuntimeHelpers.GetObjectValue(obj3);
			}
		}
		if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_nt0"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true), (object)0, false)) ? true : false)
		{
			oDv["Gia_nt0"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
				RuntimeHelpers.GetObjectValue(Interaction.IIf(flag, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia_Nt)),
				MidpointRounding.AwayFromZero
			}, (string[])null, (Type[])null, (bool[])null));
			Calc_GiaMua(oDv);
		}
		int num2 = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num2 = 1;
		}
		if (num2 == 1)
		{
			Calc_Thue_gtgt(oDv);
			Calc_ChietKhau(oDv);
		}
		else
		{
			Calc_Thue_gtgt(oDv);
			Calc_ChietKhau(oDv);
		}
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien0(DataRowView oDv)
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Invalid comparison between Unknown and I4
		if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia0"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true), (object)0, false)) ? true : false)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
				null,
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round_Gia;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array2 = array;
			bool[] array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			oDv["Gia0"] = RuntimeHelpers.GetObjectValue(obj);
		}
		int num = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num = 1;
		}
		if (num == 1)
		{
			Calc_Thue_gtgt(oDv);
			Calc_ChietKhau(oDv);
		}
		else
		{
			Calc_Thue_gtgt(oDv);
			Calc_ChietKhau(oDv);
		}
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Ts_gtgt(DataRowView oDv)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		Calc_Thue_gtgt(oDv);
		int num = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num = 1;
		}
		if (num == 1)
		{
			Calc_ChietKhau(oDv);
		}
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Thue_gtgt_nt(DataRowView oDv)
	{
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Invalid comparison between Unknown and I4
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_nt"]), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true)), (object)100),
				null,
				null
			};
			object[] array6 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array7 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			double num = Conversions.ToDouble(obj2);
			if (num != 0.0)
			{
				oDv["Thue_Gtgt"] = num;
			}
			else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
			{
				Type? typeFromHandle3 = typeof(Math);
				array3 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_nt"]), isNum: true), txtTy_gia.Value),
					null,
					null
				};
				object[] array8 = array3;
				sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array8[1] = sIConfiguration.Round;
				array3[2] = MidpointRounding.AwayFromZero;
				array = array3;
				object[] array9 = array;
				array5 = new bool[3] { false, true, false };
				object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array9, (string[])null, (Type[])null, array5);
				if (array5[1])
				{
					sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj3);
			}
		}
		int num2 = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num2 = 1;
		}
		if (num2 == 1)
		{
			Calc_ChietKhau(oDv);
		}
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Thue_gtgt(DataRowView oDv)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		int num = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num = 1;
		}
		if (num == 1)
		{
			Calc_ChietKhau(oDv);
		}
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien_Cp_Nt_ChiTiet(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["cp_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
				null,
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array2 = array;
			bool[] array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			oDv["cp"] = RuntimeHelpers.GetObjectValue(obj);
		}
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateCPList();
	}

	private void V_Tl_Ck(DataRowView oDv)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		Calc_ChietKhau(oDv);
		int num = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num = 1;
		}
		if (num == 0)
		{
			Calc_Thue_gtgt(oDv);
		}
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Ck_Nt(DataRowView oDv)
	{
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Invalid comparison between Unknown and I4
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck_nt"]), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			oDv["Ck"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true)), (object)100),
				null,
				null
			};
			object[] array6 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array7 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Ck"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck_nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array8 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array8[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array9 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array9, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Ck"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		int num = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num = 1;
		}
		if (num == 0)
		{
			Calc_Thue_gtgt(oDv);
		}
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Ck(DataRowView oDv)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		int num = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num = 1;
		}
		if (num == 0)
		{
			Calc_Thue_gtgt(oDv);
		}
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void Calc_ThanhToan(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.SubtractObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Cp_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck_Nt"]), isNum: true)),
			num,
			MidpointRounding.AwayFromZero
		};
		object[] array2 = array;
		bool[] array3 = new bool[3] { false, true, false };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		oDv["Tt_Nt"] = RuntimeHelpers.GetObjectValue(obj);
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tt_Nt"]), isNum: true)),
				null,
				null
			};
			object[] array4 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array4[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array6 = array5;
			array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			array = new object[3]
			{
				Operators.SubtractObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Cp"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck"]), isNum: true)),
				null,
				null
			};
			object[] array7 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array7[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array8 = array5;
			array3 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tt"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tt_nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array9 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array10 = array5;
			array3 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tt"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	private void Calc_GiaMua(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt0"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round_Gia;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array2 = array;
			bool[] array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			oDv["Gia0"] = RuntimeHelpers.GetObjectValue(obj);
		}
	}

	private void Calc_TienMua(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt0"]), isNum: true)),
			num,
			MidpointRounding.AwayFromZero
		};
		object[] array2 = array;
		bool[] array3 = new bool[3] { false, true, false };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		oDv["Tien_Nt0"] = RuntimeHelpers.GetObjectValue(obj);
		SIConfiguration sIConfiguration;
		object[] array5;
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt0"]), isNum: true)),
				null,
				null
			};
			object[] array4 = array;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array4[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			array5 = array;
			object[] array6 = array5;
			array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tien0"] = RuntimeHelpers.GetObjectValue(obj2);
			return;
		}
		Type? typeFromHandle3 = typeof(Math);
		array = new object[3]
		{
			Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia0"]), isNum: true)),
			null,
			null
		};
		object[] array7 = array;
		sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
		array7[1] = sIConfiguration.Round;
		array[2] = MidpointRounding.AwayFromZero;
		array5 = array;
		object[] array8 = array5;
		array3 = new bool[3] { false, true, false };
		object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
		}
		double num2 = Conversions.ToDouble(obj3);
		if (num2 != 0.0)
		{
			oDv["Tien0"] = num2;
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt0"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array9 = array;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			array5 = array;
			object[] array10 = array5;
			array3 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tien0"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	private void Calc_TienVon(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		int num2 = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia_Nt));
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Cp_Nt"]), isNum: true)),
			num,
			MidpointRounding.AwayFromZero
		};
		object[] array2 = array;
		bool[] array3 = new bool[3] { false, true, false };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		oDv["Tien_Nt"] = RuntimeHelpers.GetObjectValue(obj);
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true)),
				null,
				null
			};
			object[] array4 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array4[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array6 = array5;
			array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else
		{
			double num3 = Conversions.ToDouble(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Cp"]), isNum: true)));
			if (num3 != 0.0)
			{
				oDv["Tien"] = num3;
			}
			else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
			{
				Type? typeFromHandle3 = typeof(Math);
				array = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true), txtTy_gia.Value),
					null,
					null
				};
				object[] array7 = array;
				SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array7[1] = sIConfiguration.Round;
				array[2] = MidpointRounding.AwayFromZero;
				object[] array5 = array;
				object[] array8 = array5;
				array3 = new bool[3] { false, true, false };
				object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array3);
				if (array3[1])
				{
					sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
				}
				oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj3);
			}
		}
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["so_luong"]), isNum: true), (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array5 = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["so_luong"]), isNum: true)),
				num2,
				MidpointRounding.AwayFromZero
			};
			object[] array9 = array5;
			array3 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array9, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Gia_Nt"] = RuntimeHelpers.GetObjectValue(obj4);
		}
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle5 = typeof(Math);
			array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true)),
				null,
				null
			};
			object[] array10 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array10[1] = sIConfiguration.Round_Gia;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array11 = array5;
			array3 = new bool[3] { false, true, false };
			object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array11, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj5);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["so_luong"]), isNum: true), (object)0, false))
		{
			Type? typeFromHandle6 = typeof(Math);
			array = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["so_luong"]), isNum: true)),
				null,
				null
			};
			object[] array12 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array12[1] = sIConfiguration.Round_Gia;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array13 = array5;
			array3 = new bool[3] { false, true, false };
			object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array13, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj6);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle7 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array14 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array14[1] = sIConfiguration.Round_Gia;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array15 = array5;
			array3 = new bool[3] { false, true, false };
			object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle7, "Round", array15, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj7);
		}
	}

	private void Calc_Thue_gtgt(DataRowView oDv)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		int num2 = 1;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num2 = 0;
		}
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt0"]), isNum: true), Operators.MultiplyObject((object)num2, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck_Nt"]), isNum: true)))), (object)100),
			num,
			MidpointRounding.AwayFromZero
		};
		object[] array2 = array;
		bool[] array3 = new bool[3] { false, true, false };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		oDv["Thue_Gtgt_Nt"] = RuntimeHelpers.GetObjectValue(obj);
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_nt"]), isNum: true)),
				null,
				null
			};
			object[] array4 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array4[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array6 = array5;
			array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else
		{
			double num3 = Conversions.ToDouble(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true), Operators.MultiplyObject((object)num2, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck"]), isNum: true)))));
			if (num3 != 0.0)
			{
				oDv["Thue_Gtgt"] = num3;
			}
			else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
			{
				Type? typeFromHandle3 = typeof(Math);
				array = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_nt"]), isNum: true), txtTy_gia.Value),
					null,
					null
				};
				object[] array7 = array;
				SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array7[1] = sIConfiguration.Round;
				array[2] = MidpointRounding.AwayFromZero;
				object[] array5 = array;
				object[] array8 = array5;
				array3 = new bool[3] { false, true, false };
				object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array3);
				if (array3[1])
				{
					sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
				}
				oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj3);
			}
		}
		if (num2 == 0)
		{
			Calc_ChietKhau(oDv);
		}
	}

	private void Calc_ChietKhau(DataRowView oDv)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		int num2 = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num2 = 1;
		}
		object[] array;
		bool[] array3;
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt0"]), isNum: true), Operators.MultiplyObject((object)num2, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true)))), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array2 = array;
			array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Ck_Nt"] = RuntimeHelpers.GetObjectValue(obj);
		}
		SIConfiguration sIConfiguration;
		object[] array5;
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck_nt"]), isNum: true)),
				null,
				null
			};
			object[] array4 = array;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array4[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			array5 = array;
			object[] array6 = array5;
			array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Ck"] = RuntimeHelpers.GetObjectValue(obj2);
			return;
		}
		Type? typeFromHandle3 = typeof(Math);
		array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true), Operators.MultiplyObject((object)num2, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)))), (object)100),
			null,
			null
		};
		object[] array7 = array;
		sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
		array7[1] = sIConfiguration.Round;
		array[2] = MidpointRounding.AwayFromZero;
		array5 = array;
		object[] array8 = array5;
		array3 = new bool[3] { false, true, false };
		object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
		}
		double num3 = Conversions.ToDouble(obj3);
		if (num3 != 0.0)
		{
			oDv["Ck"] = num3;
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck_nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array9 = array;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			array5 = array;
			object[] array10 = array5;
			array3 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Ck"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	private void Calc_So_luong_qd(DataRowView oDv)
	{
		oDv["so_luong_qd"] = RuntimeHelpers.GetObjectValue(oDv["so_luong"]);
	}

	private void V_Ty_Gia()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		if ((Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false) && CT1Voucher != null) ? true : false)
		{
			int num = AsiaErp.Framework.Environment.GetSIConfiguration().Round;
			int num2 = AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia;
			int num3 = 1;
			if ((int)((CheckBox)chkCk_st).CheckState == 1)
			{
				num3 = 0;
			}
			foreach (DataRowView item in CT1Voucher)
			{
				if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
				{
					Type? typeFromHandle = typeof(Math);
					object[] array = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt0"]), isNum: true)),
						num2,
						MidpointRounding.AwayFromZero
					};
					object[] array2 = array;
					bool[] array3 = new bool[3] { false, true, false };
					object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
					if (array3[1])
					{
						num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item["gia0"] = RuntimeHelpers.GetObjectValue(obj);
					Type? typeFromHandle2 = typeof(Math);
					object[] array4 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt0"]), isNum: true)),
						num,
						MidpointRounding.AwayFromZero
					};
					object[] array5 = array4;
					array3 = new bool[3] { false, true, false };
					object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array5, (string[])null, (Type[])null, array3);
					if (array3[1])
					{
						num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
					}
					item["Tien0"] = RuntimeHelpers.GetObjectValue(obj2);
					Type? typeFromHandle3 = typeof(Math);
					array4 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["cp_nt"]), isNum: true)),
						num,
						MidpointRounding.AwayFromZero
					};
					object[] array6 = array4;
					array3 = new bool[3] { false, true, false };
					object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array6, (string[])null, (Type[])null, array3);
					if (array3[1])
					{
						num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
					}
					item["cp"] = RuntimeHelpers.GetObjectValue(obj3);
					Type? typeFromHandle4 = typeof(Math);
					array4 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt"]), isNum: true)),
						num2,
						MidpointRounding.AwayFromZero
					};
					object[] array7 = array4;
					array3 = new bool[3] { false, true, false };
					object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array7, (string[])null, (Type[])null, array3);
					if (array3[1])
					{
						num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
					}
					item["gia"] = RuntimeHelpers.GetObjectValue(obj4);
					Type? typeFromHandle5 = typeof(Math);
					array4 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt"]), isNum: true)),
						num,
						MidpointRounding.AwayFromZero
					};
					object[] array8 = array4;
					array3 = new bool[3] { false, true, false };
					object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array8, (string[])null, (Type[])null, array3);
					if (array3[1])
					{
						num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
					}
					item["Tien"] = RuntimeHelpers.GetObjectValue(obj5);
					Type? typeFromHandle6 = typeof(Math);
					array4 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_nt"]), isNum: true)),
						num,
						MidpointRounding.AwayFromZero
					};
					object[] array9 = array4;
					array3 = new bool[3] { false, true, false };
					object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array9, (string[])null, (Type[])null, array3);
					if (array3[1])
					{
						num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
					}
					item["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj6);
					Type? typeFromHandle7 = typeof(Math);
					array4 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["ck_nt"]), isNum: true)),
						num,
						MidpointRounding.AwayFromZero
					};
					object[] array10 = array4;
					array3 = new bool[3] { false, true, false };
					object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle7, "Round", array10, (string[])null, (Type[])null, array3);
					if (array3[1])
					{
						num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
					}
					item["ck"] = RuntimeHelpers.GetObjectValue(obj7);
				}
				else
				{
					if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
					{
						Type? typeFromHandle8 = typeof(Math);
						object[] array4 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia_Nt0"]), isNum: true), txtTy_gia.Value),
							num2,
							MidpointRounding.AwayFromZero
						};
						object[] array11 = array4;
						bool[] array3 = new bool[3] { false, true, false };
						object obj8 = NewLateBinding.LateGet((object)null, typeFromHandle8, "Round", array11, (string[])null, (Type[])null, array3);
						if (array3[1])
						{
							num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
						}
						item["Gia0"] = RuntimeHelpers.GetObjectValue(obj8);
						Type? typeFromHandle9 = typeof(Math);
						array4 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["cp_nt"]), isNum: true), txtTy_gia.Value),
							num,
							MidpointRounding.AwayFromZero
						};
						object[] array12 = array4;
						array3 = new bool[3] { false, true, false };
						object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle9, "Round", array12, (string[])null, (Type[])null, array3);
						if (array3[1])
						{
							num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
						}
						item["cp"] = RuntimeHelpers.GetObjectValue(obj9);
					}
					if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia0"]), isNum: true)), (object)0, false))
					{
						Type? typeFromHandle10 = typeof(Math);
						object[] array4 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia0"]), isNum: true)),
							num,
							MidpointRounding.AwayFromZero
						};
						object[] array13 = array4;
						bool[] array3 = new bool[3] { false, true, false };
						object obj10 = NewLateBinding.LateGet((object)null, typeFromHandle10, "Round", array13, (string[])null, (Type[])null, array3);
						if (array3[1])
						{
							num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
						}
						item["Tien0"] = RuntimeHelpers.GetObjectValue(obj10);
					}
					else
					{
						Type? typeFromHandle11 = typeof(Math);
						object[] array4 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt0"]), isNum: true), txtTy_gia.Value),
							num,
							MidpointRounding.AwayFromZero
						};
						object[] array14 = array4;
						bool[] array3 = new bool[3] { false, true, false };
						object obj11 = NewLateBinding.LateGet((object)null, typeFromHandle11, "Round", array14, (string[])null, (Type[])null, array3);
						if (array3[1])
						{
							num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
						}
						item["Tien0"] = RuntimeHelpers.GetObjectValue(obj11);
					}
					if (Operators.ConditionalCompareObjectNotEqual(Operators.SubtractObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Cp"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["ck"]), isNum: true)), (object)0, false))
					{
						Type? typeFromHandle12 = typeof(Math);
						object[] array4 = new object[3]
						{
							Operators.SubtractObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Cp"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["ck"]), isNum: true)),
							num,
							MidpointRounding.AwayFromZero
						};
						object[] array15 = array4;
						bool[] array3 = new bool[3] { false, true, false };
						object obj12 = NewLateBinding.LateGet((object)null, typeFromHandle12, "Round", array15, (string[])null, (Type[])null, array3);
						if (array3[1])
						{
							num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
						}
						item["Tien"] = RuntimeHelpers.GetObjectValue(obj12);
					}
					else
					{
						Type? typeFromHandle13 = typeof(Math);
						object[] array4 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt"]), isNum: true), txtTy_gia.Value),
							num,
							MidpointRounding.AwayFromZero
						};
						object[] array16 = array4;
						bool[] array3 = new bool[3] { false, true, false };
						object obj13 = NewLateBinding.LateGet((object)null, typeFromHandle13, "Round", array16, (string[])null, (Type[])null, array3);
						if (array3[1])
						{
							num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
						}
						item["Tien"] = RuntimeHelpers.GetObjectValue(obj13);
					}
					if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["so_luong"]), isNum: true), (object)0, false))
					{
						Type? typeFromHandle14 = typeof(Math);
						object[] array4 = new object[3]
						{
							Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["so_luong"]), isNum: true)),
							num2,
							MidpointRounding.AwayFromZero
						};
						object[] array17 = array4;
						bool[] array3 = new bool[3] { false, true, false };
						object obj14 = NewLateBinding.LateGet((object)null, typeFromHandle14, "Round", array17, (string[])null, (Type[])null, array3);
						if (array3[1])
						{
							num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
						}
						item["Gia"] = RuntimeHelpers.GetObjectValue(obj14);
					}
					else
					{
						Type? typeFromHandle15 = typeof(Math);
						object[] array4 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
							num2,
							MidpointRounding.AwayFromZero
						};
						object[] array18 = array4;
						bool[] array3 = new bool[3] { false, true, false };
						object obj15 = NewLateBinding.LateGet((object)null, typeFromHandle15, "Round", array18, (string[])null, (Type[])null, array3);
						if (array3[1])
						{
							num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
						}
						item["Gia"] = RuntimeHelpers.GetObjectValue(obj15);
					}
					if (num3 == 0)
					{
						double num4 = Conversions.ToDouble(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien0"]), isNum: true)));
						object[] array4;
						bool[] array3;
						if (num4 != 0.0)
						{
							item["Thue_Gtgt"] = num4;
						}
						else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
						{
							Type? typeFromHandle16 = typeof(Math);
							array4 = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_nt"]), isNum: true), txtTy_gia.Value),
								num,
								MidpointRounding.AwayFromZero
							};
							object[] array19 = array4;
							array3 = new bool[3] { false, true, false };
							object obj16 = NewLateBinding.LateGet((object)null, typeFromHandle16, "Round", array19, (string[])null, (Type[])null, array3);
							if (array3[1])
							{
								num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
							}
							item["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj16);
						}
						Type? typeFromHandle17 = typeof(Math);
						object[] array = new object[3]
						{
							Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tl_Ck"]), isNum: true), Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt"]), isNum: true))), (object)100),
							null,
							null
						};
						object[] array20 = array;
						SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array20[1] = sIConfiguration.Round;
						array[2] = MidpointRounding.AwayFromZero;
						array4 = array;
						object[] array21 = array4;
						array3 = new bool[3] { false, true, false };
						object obj17 = NewLateBinding.LateGet((object)null, typeFromHandle17, "Round", array21, (string[])null, (Type[])null, array3);
						if (array3[1])
						{
							sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
						}
						double num5 = Conversions.ToDouble(obj17);
						if (num5 != 0.0)
						{
							item["Ck"] = num5;
						}
						else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
						{
							Type? typeFromHandle18 = typeof(Math);
							array = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ck_nt"]), isNum: true), txtTy_gia.Value),
								null,
								null
							};
							object[] array22 = array;
							sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
							array22[1] = sIConfiguration.Round;
							array[2] = MidpointRounding.AwayFromZero;
							array4 = array;
							object[] array23 = array4;
							array3 = new bool[3] { false, true, false };
							object obj18 = NewLateBinding.LateGet((object)null, typeFromHandle18, "Round", array23, (string[])null, (Type[])null, array3);
							if (array3[1])
							{
								sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
							}
							item["Ck"] = RuntimeHelpers.GetObjectValue(obj18);
						}
					}
					else
					{
						if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
						{
							Type? typeFromHandle19 = typeof(Math);
							object[] array4 = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["ck_nt"]), isNum: true), txtTy_gia.Value),
								num,
								MidpointRounding.AwayFromZero
							};
							object[] array24 = array4;
							bool[] array3 = new bool[3] { false, true, false };
							object obj19 = NewLateBinding.LateGet((object)null, typeFromHandle19, "Round", array24, (string[])null, (Type[])null, array3);
							if (array3[1])
							{
								num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
							}
							item["ck"] = RuntimeHelpers.GetObjectValue(obj19);
						}
						double num6 = Conversions.ToDouble(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien0"]), isNum: true), Operators.MultiplyObject((object)num3, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ck"]), isNum: true)))));
						if (num6 != 0.0)
						{
							item["Thue_Gtgt"] = num6;
						}
						else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
						{
							Type? typeFromHandle20 = typeof(Math);
							object[] array4 = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_nt"]), isNum: true), txtTy_gia.Value),
								num,
								MidpointRounding.AwayFromZero
							};
							object[] array25 = array4;
							bool[] array3 = new bool[3] { false, true, false };
							object obj20 = NewLateBinding.LateGet((object)null, typeFromHandle20, "Round", array25, (string[])null, (Type[])null, array3);
							if (array3[1])
							{
								num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
							}
							item["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj20);
						}
					}
				}
				Calc_ThanhToan(item);
			}
			if (Operators.CompareString(AsiaErp.Framework.Environment.GetPOConfiguration().chiet_khau_mua_hang, "1", false) == 0)
			{
				PhanBoChietKhauHoaDon();
			}
			foreach (DataRowView item2 in CP1Voucher)
			{
				if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
				{
					Type? typeFromHandle21 = typeof(Math);
					object[] array4 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp_nt"]), isNum: true)),
						num,
						MidpointRounding.AwayFromZero
					};
					object[] array26 = array4;
					bool[] array3 = new bool[3] { false, true, false };
					object obj21 = NewLateBinding.LateGet((object)null, typeFromHandle21, "Round", array26, (string[])null, (Type[])null, array3);
					if (array3[1])
					{
						num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
					}
					item2["tien_cp"] = RuntimeHelpers.GetObjectValue(obj21);
					Type? typeFromHandle22 = typeof(Math);
					array4 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt_nt"]), isNum: true)),
						num,
						MidpointRounding.AwayFromZero
					};
					object[] array27 = array4;
					array3 = new bool[3] { false, true, false };
					object obj22 = NewLateBinding.LateGet((object)null, typeFromHandle22, "Round", array27, (string[])null, (Type[])null, array3);
					if (array3[1])
					{
						num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
					}
					item2["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj22);
				}
				else
				{
					Type? typeFromHandle23 = typeof(Math);
					object[] array4 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp_nt"]), isNum: true), txtTy_gia.Value),
						num,
						MidpointRounding.AwayFromZero
					};
					object[] array28 = array4;
					bool[] array3 = new bool[3] { false, true, false };
					object obj23 = NewLateBinding.LateGet((object)null, typeFromHandle23, "Round", array28, (string[])null, (Type[])null, array3);
					if (array3[1])
					{
						num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
					}
					item2["tien_cp"] = RuntimeHelpers.GetObjectValue(obj23);
					if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tien_Cp"]), isNum: true)), (object)0, false))
					{
						Type? typeFromHandle24 = typeof(Math);
						array4 = new object[3]
						{
							Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tien_Cp"]), isNum: true)), (object)100),
							num,
							MidpointRounding.AwayFromZero
						};
						object[] array29 = array4;
						array3 = new bool[3] { false, true, false };
						object obj24 = NewLateBinding.LateGet((object)null, typeFromHandle24, "Round", array29, (string[])null, (Type[])null, array3);
						if (array3[1])
						{
							num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
						}
						item2["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj24);
					}
					else
					{
						Type? typeFromHandle25 = typeof(Math);
						array4 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt_nt"]), isNum: true), txtTy_gia.Value),
							num,
							MidpointRounding.AwayFromZero
						};
						object[] array30 = array4;
						array3 = new bool[3] { false, true, false };
						object obj25 = NewLateBinding.LateGet((object)null, typeFromHandle25, "Round", array30, (string[])null, (Type[])null, array3);
						if (array3[1])
						{
							num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
						}
						item2["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj25);
					}
					if (Operators.ConditionalCompareObjectNotEqual(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt"]), isNum: true)), (object)0, false))
					{
						Type? typeFromHandle26 = typeof(Math);
						array4 = new object[3]
						{
							Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt"]), isNum: true)),
							num,
							MidpointRounding.AwayFromZero
						};
						object[] array31 = array4;
						array3 = new bool[3] { false, true, false };
						object obj26 = NewLateBinding.LateGet((object)null, typeFromHandle26, "Round", array31, (string[])null, (Type[])null, array3);
						if (array3[1])
						{
							num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
						}
						item2["Tt"] = RuntimeHelpers.GetObjectValue(obj26);
					}
					else
					{
						Type? typeFromHandle27 = typeof(Math);
						array4 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tt_nt"]), isNum: true), txtTy_gia.Value),
							num,
							MidpointRounding.AwayFromZero
						};
						object[] array32 = array4;
						array3 = new bool[3] { false, true, false };
						object obj27 = NewLateBinding.LateGet((object)null, typeFromHandle27, "Round", array32, (string[])null, (Type[])null, array3);
						if (array3[1])
						{
							num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
						}
						item2["Tt"] = RuntimeHelpers.GetObjectValue(obj27);
					}
				}
				Calc_ThanhToan_CP(item2);
			}
		}
		UpdateCPList();
		UpdateList();
	}

	private void ReCalcTonKhoTucThoi(DataRowView odv)
	{
		double num = default(double);
		double num2 = default(double);
		double num3 = default(double);
		double num4 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_vt"]), isNum: false), (object)"", false) || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_kho"]), isNum: false), (object)"", false) ? true : false))
		{
			num = 0.0;
			num2 = 0.0;
			num3 = 0.0;
			num4 = 0.0;
			num5 = 0.0;
			num6 = 0.0;
		}
		else
		{
			string aMa_Kho = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_kho"]), isNum: false));
			string aMa_Vt = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_vt"]), isNum: false));
			DateTime aNgay_Ct = Conversions.ToDate(txtNgay_Ct.Value);
			decimal aTon = new decimal(num);
			decimal aTon_all = new decimal(num2);
			decimal aTon_Mua = new decimal(num3);
			decimal aTon_Mua_all = new decimal(num4);
			decimal aTon_Ban = new decimal(num5);
			decimal aTon_Ban_all = new decimal(num6);
			Commons.Get_TonKhoAll(aMa_Kho, aMa_Vt, aNgay_Ct, ref aTon, ref aTon_all, ref aTon_Mua, ref aTon_Mua_all, ref aTon_Ban, ref aTon_Ban_all);
			num6 = Convert.ToDouble(aTon_Ban_all);
			num5 = Convert.ToDouble(aTon_Ban);
			num4 = Convert.ToDouble(aTon_Mua_all);
			num3 = Convert.ToDouble(aTon_Mua);
			num2 = Convert.ToDouble(aTon_all);
			num = Convert.ToDouble(aTon);
		}
		odv["Ton"] = num;
		odv["ton_All"] = num2;
		odv["Ton_mua"] = num3;
		odv["ton_mua_All"] = num4;
		odv["Ton_ban"] = num5;
		odv["ton_ban_All"] = num6;
	}

	private void ReCalcTonKhoTucThoi(DataRow odv)
	{
		if ((!Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_vt"]), isNum: false), (object)"", false) || !Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_kho"]), isNum: false), (object)"", false)) && 0 == 0)
		{
			string aMa_Kho = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_kho"]), isNum: false));
			string aMa_Vt = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_vt"]), isNum: false));
			DateTime aNgay_Ct = Conversions.ToDate(txtNgay_Ct.Value);
			double value = default(double);
			decimal aTon = new decimal(value);
			double value2 = default(double);
			decimal aTon_all = new decimal(value2);
			double value3 = default(double);
			decimal aTon_Mua = new decimal(value3);
			double value4 = default(double);
			decimal aTon_Mua_all = new decimal(value4);
			double value5 = default(double);
			decimal aTon_Ban = new decimal(value5);
			double value6 = default(double);
			decimal aTon_Ban_all = new decimal(value6);
			Commons.Get_TonKhoAll(aMa_Kho, aMa_Vt, aNgay_Ct, ref aTon, ref aTon_all, ref aTon_Mua, ref aTon_Mua_all, ref aTon_Ban, ref aTon_Ban_all);
			value6 = Convert.ToDouble(aTon_Ban_all);
			value5 = Convert.ToDouble(aTon_Ban);
			value4 = Convert.ToDouble(aTon_Mua_all);
			value3 = Convert.ToDouble(aTon_Mua);
			value2 = Convert.ToDouble(aTon_all);
			value = Convert.ToDouble(aTon);
			odv["Ton"] = value;
			odv["ton_All"] = value2;
			odv["Ton_mua"] = value3;
			odv["ton_mua_All"] = value4;
			odv["Ton_ban"] = value5;
			odv["ton_ban_All"] = value6;
		}
	}

	private void Calc_Thue_gtgt_Cp(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp_Nt"]), isNum: true)), (object)100),
			num,
			MidpointRounding.AwayFromZero
		};
		object[] array2 = array;
		bool[] array3 = new bool[3] { false, true, false };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		oDv["Thue_Gtgt_Nt"] = RuntimeHelpers.GetObjectValue(obj);
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_nt"]), isNum: true)),
				null,
				null
			};
			object[] array4 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array4[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array6 = array5;
			array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp"]), isNum: true)), (object)100),
				null,
				null
			};
			object[] array7 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array7[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array8 = array5;
			array3 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array9 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array10 = array5;
			array3 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	private void Calc_ThanhToan_CP(DataRowView oDv)
	{
		oDv["Tt_Nt"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true));
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tt"]), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			oDv["Tt"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)), (object)0, false))
		{
			oDv["Tt"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true));
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array6 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array7 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
	}

	private void Calc_ChiPhiMuaHang()
	{
		if (((DataGridView)adgvChi_phi).RowCount <= 0)
		{
			foreach (DataRowView item in CT1Voucher)
			{
				item["cp_nt"] = 0;
				item["cp"] = 0;
				Calc_TienVon(item);
				Calc_ThanhToan(item);
			}
			UpdateList();
			return;
		}
		string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
		int digits = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		double num = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(tien_nt0)", filter)), isNum: true));
		double num2 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(tien0)", filter)), isNum: true));
		double num3 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(so_luong)", filter)), isNum: true));
		double num6;
		double num7;
		foreach (DataRowView item2 in base.CT1Voucher)
		{
			double num4 = 0.0;
			double num5 = 0.0;
			if (CP1Voucher != null && CP1Voucher.Count != 0 && 0 == 0)
			{
				foreach (DataRowView item3 in base.CP1Voucher)
				{
					num6 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item3["tien_cp"]), isNum: true));
					num7 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item3["tien_cp_nt"]), isNum: true));
					if ((num7 == 0.0 && num6 == 0.0) ? true : false)
					{
						continue;
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item3["tt_pb"]), isNum: false), (object)"2", false))
					{
						if (num == 0.0)
						{
							continue;
						}
						double num8 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_nt0"]), isNum: true));
						double num9 = Math.Round(num7 * num8 / num, digits, MidpointRounding.AwayFromZero);
						num4 += num9;
						if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true), (object)0, false))
						{
							object obj = num5;
							Type? typeFromHandle = typeof(Math);
							object[] array = new object[3]
							{
								Operators.MultiplyObject((object)num9, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
								null,
								null
							};
							object[] array2 = array;
							SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
							array2[1] = sIConfiguration.Round;
							array[2] = MidpointRounding.AwayFromZero;
							object[] array3 = array;
							object[] array4 = array3;
							bool[] array5 = new bool[3] { false, true, false };
							object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
							if (array5[1])
							{
								sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
							}
							num5 = Conversions.ToDouble(Operators.AddObject(obj, obj2));
						}
						else
						{
							double num10 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien0"]), isNum: true));
							num5 += Math.Round(num6 * num10 / num2, AsiaErp.Framework.Environment.GetSIConfiguration().Round, MidpointRounding.AwayFromZero);
						}
					}
					else
					{
						if (num3 == 0.0)
						{
							continue;
						}
						double num11 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["so_luong"]), isNum: true));
						double num9 = Math.Round(num7 * num11 / num3, digits, MidpointRounding.AwayFromZero);
						num4 += num9;
						if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true), (object)0, false))
						{
							object obj3 = num5;
							Type? typeFromHandle2 = typeof(Math);
							object[] array3 = new object[3]
							{
								Operators.MultiplyObject((object)num9, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
								null,
								null
							};
							object[] array6 = array3;
							SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
							array6[1] = sIConfiguration.Round;
							array3[2] = MidpointRounding.AwayFromZero;
							object[] array = array3;
							object[] array7 = array;
							bool[] array5 = new bool[3] { false, true, false };
							object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
							if (array5[1])
							{
								sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
							}
							num5 = Conversions.ToDouble(Operators.AddObject(obj3, obj4));
						}
						else
						{
							num11 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["so_luong"]), isNum: true));
							num5 += Math.Round(num6 * num11 / num3, AsiaErp.Framework.Environment.GetSIConfiguration().Round, MidpointRounding.AwayFromZero);
						}
					}
				}
			}
			item2["cp_nt"] = num4;
			item2["cp"] = num5;
			Calc_TienVon(item2);
			Calc_ThanhToan(item2);
		}
		num6 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp)", filter)), isNum: true));
		num7 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp_nt)", filter)), isNum: true));
		double num12 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(cp_nt)", filter)), isNum: true));
		double num13 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(cp)", filter)), isNum: true));
		base.CT1Voucher.Sort = "cp_nt desc";
		DataRowView dataRowView4 = base.CT1Voucher[0];
		base.CT1Voucher.Sort = "";
		DataRowView dataRowView5 = dataRowView4;
		DataRowView dataRowView6 = dataRowView5;
		string property = "cp";
		dataRowView6[property] = Operators.AddObject(dataRowView5[property], (object)(num6 - num13));
		dataRowView5 = dataRowView4;
		DataRowView dataRowView7 = dataRowView5;
		property = "cp_nt";
		dataRowView7[property] = Operators.AddObject(dataRowView5[property], (object)(num7 - num12));
		Calc_TienVon(dataRowView4);
		Calc_ThanhToan(dataRowView4);
		UpdateList();
	}

	private void V_Tien_Cp_Nt(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_cp_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
				null,
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.ToEven;
			object[] array2 = array;
			bool[] array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			oDv["Tien_cp"] = RuntimeHelpers.GetObjectValue(obj);
		}
		Calc_Thue_gtgt_Cp(oDv);
		Calc_ThanhToan_CP(oDv);
		UpdateCPList();
	}

	private void V_Tien_Cp(DataRowView oDv)
	{
		Calc_Thue_gtgt_Cp(oDv);
		Calc_ThanhToan_CP(oDv);
		UpdateCPList();
	}

	private void V_Ts_gtgt_cp(DataRowView oDv)
	{
		Calc_Thue_gtgt_Cp(oDv);
		Calc_ThanhToan_CP(oDv);
		UpdateCPList();
	}

	private void V_Thue_gtgt_nt_cp(DataRowView oDv)
	{
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_nt"]), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp"]), isNum: true)), (object)100),
				null,
				null
			};
			object[] array6 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array7 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array8 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array8[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array9 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array9, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		Calc_ThanhToan_CP(oDv);
		UpdateCPList();
	}

	private void V_Thue_gtgt_cp(DataRowView oDv)
	{
		Calc_ThanhToan_CP(oDv);
		UpdateCPList();
	}

	private bool W_Tien_Cp(DataRowView oDv)
	{
		return true;
	}

	private bool W_Thue_Gtgt_Nt_cp(DataRowView oDv)
	{
		return true;
	}

	private bool W_Thue_Gtgt_cp(DataRowView oDv)
	{
		return true;
	}

	private void InsertChiPhiRow()
	{
		if (base.CPTable != null)
		{
			DataRow dataRow = base.CPTable.NewRow();
			dataRow["ma_cty"] = RuntimeHelpers.GetObjectValue(base.CurrentPHRow["ma_cty"]);
			dataRow["stt_rec"] = RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]);
			dataRow["stt_rec0"] = Commons.Get_SttRec0(Conversions.ToString(base.CurrentPHRow["stt_rec"]), base.CPTable);
			base.CPTable.Rows.Add(dataRow);
			((DataGridView)adgvChi_phi).CurrentCell = ((DataGridView)adgvChi_phi)[0, checked(((DataGridView)adgvChi_phi).RowCount - 1)];
		}
	}

	private void DeleteChiPhiRow()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		if (!((((DataGridViewBand)((DataGridView)adgvChi_phi).CurrentRow).Index < 0) | (((DataGridViewBand)((DataGridView)adgvChi_phi).CurrentRow).Index > checked(base.CPTable.DefaultView.Count - 1))) && (int)CMessageBox.Show(50003, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)256) == 6)
		{
			base.CPTable.DefaultView.Delete(((DataGridViewBand)((DataGridView)adgvChi_phi).CurrentRow).Index);
		}
	}

	private void UpdateCPList()
	{
		if (base.CurrentPHRow != null)
		{
			string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
			txtT_Tien_Cp_nt_Cp.Value = RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp_nt)", filter));
			txtT_thue_nt_cp.Value = RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(thue_gtgt_nt)", filter));
			txtT_tt_nt_cp.Value = Operators.AddObject(txtT_Tien_Cp_nt_Cp.Value, txtT_thue_nt_cp.Value);
		}
	}

	private void SetTexboxValue(ref TextBox oTxt, string value, bool isnumeric = false)
	{
		if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(oTxt.Text, isNum: false), (object)"", false))
		{
			oTxt.Text = Conversions.ToString(Helper.Repl_Null(value, isnumeric));
		}
	}

	private void setCTValue(string colName, object value)
	{
		if (!base.CTTable.Columns.Contains(colName))
		{
			return;
		}
		foreach (DataRowView item in CT1Voucher)
		{
			if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(item[colName])))
			{
				item[colName] = RuntimeHelpers.GetObjectValue(value);
			}
		}
	}

	private void ReCalcAfterLookup(DataRow odr)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		int num2 = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia_Nt));
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Gia_Nt0"]), isNum: true)),
			num,
			MidpointRounding.AwayFromZero
		};
		object[] array2 = array;
		bool[] array3 = new bool[3] { false, true, false };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		odr["Tien_Nt0"] = RuntimeHelpers.GetObjectValue(obj);
		odr["Tien_Nt"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Cp_Nt"]), isNum: true));
		object[] array4;
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["so_luong"]), isNum: true), (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tien_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["so_luong"]), isNum: true)),
				num2,
				MidpointRounding.AwayFromZero
			};
			object[] array5 = array4;
			array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array5, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			odr["Gia_Nt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		Type? typeFromHandle3 = typeof(Math);
		array4 = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tien_Nt0"]), isNum: true)), (object)100),
			num,
			MidpointRounding.AwayFromZero
		};
		object[] array6 = array4;
		array3 = new bool[3] { false, true, false };
		object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array6, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
		}
		odr["Thue_Gtgt_Nt"] = RuntimeHelpers.GetObjectValue(obj3);
		odr["Tt_Nt"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tien_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Thue_Gtgt_Nt"]), isNum: true));
		Type? typeFromHandle4 = typeof(Math);
		array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tien0"]), isNum: true)), (object)100),
			null,
			null
		};
		object[] array7 = array;
		SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
		array7[1] = sIConfiguration.Round;
		array[2] = MidpointRounding.AwayFromZero;
		array4 = array;
		object[] array8 = array4;
		array3 = new bool[3] { false, true, false };
		object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array8, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
		}
		odr["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj4);
		odr["Tt"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Thue_Gtgt"]), isNum: true));
		if ((Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Gia0"]), isNum: true)), (object)0, false)) ? true : false)
		{
			Type? typeFromHandle5 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Gia0"]), isNum: true)),
				null,
				null
			};
			object[] array9 = array;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			array4 = array;
			object[] array10 = array4;
			array3 = new bool[3] { false, true, false };
			object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array10, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			odr["Tien0"] = RuntimeHelpers.GetObjectValue(obj5);
			odr["Tien"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Cp"]), isNum: true));
			Type? typeFromHandle6 = typeof(Math);
			array = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["so_luong"]), isNum: true)),
				null,
				null
			};
			object[] array11 = array;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array11[1] = sIConfiguration.Round_Gia;
			array[2] = MidpointRounding.AwayFromZero;
			array4 = array;
			object[] array12 = array4;
			array3 = new bool[3] { false, true, false };
			object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array12, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			odr["Gia"] = RuntimeHelpers.GetObjectValue(obj6);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle7 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
				null,
				null
			};
			object[] array13 = array;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array13[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			array4 = array;
			object[] array14 = array4;
			array3 = new bool[3] { false, true, false };
			object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle7, "Round", array14, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			odr["Tien0"] = RuntimeHelpers.GetObjectValue(obj7);
			Type? typeFromHandle8 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tien_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
				null,
				null
			};
			object[] array15 = array;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array15[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			array4 = array;
			object[] array16 = array4;
			array3 = new bool[3] { false, true, false };
			object obj8 = NewLateBinding.LateGet((object)null, typeFromHandle8, "Round", array16, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			odr["Tien"] = RuntimeHelpers.GetObjectValue(obj8);
			Type? typeFromHandle9 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Gia_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
				null,
				null
			};
			object[] array17 = array;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array17[1] = sIConfiguration.Round_Gia;
			array[2] = MidpointRounding.AwayFromZero;
			array4 = array;
			object[] array18 = array4;
			array3 = new bool[3] { false, true, false };
			object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle9, "Round", array18, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			odr["Gia"] = RuntimeHelpers.GetObjectValue(obj9);
		}
		odr["so_luong_qd"] = RuntimeHelpers.GetObjectValue(odr["so_luong"]);
	}

	private void Calc_ThueVAT()
	{
		string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
		int digits = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		double num = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(tien_nt)", filter)), isNum: true));
		double num2 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(tien)", filter)), isNum: true));
		double num3 = Convert.ToDouble(ctlTaIn.get_T_Thue(""));
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.DivideObject((object)ctlTaIn.get_T_Thue(""), Interaction.IIf(Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)0, false), (object)1, RuntimeHelpers.GetObjectValue(txtTy_gia.Value))),
			null,
			null
		};
		object[] array2 = array;
		SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
		array2[1] = sIConfiguration.Round_Nt;
		array[2] = MidpointRounding.AwayFromZero;
		object[] array3 = array;
		object[] array4 = array3;
		bool[] array5 = new bool[3] { false, true, false };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
		if (array5[1])
		{
			sIConfiguration.Round_Nt = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
		}
		double num4 = Conversions.ToDouble(obj);
		foreach (DataRowView item in base.CT1Voucher)
		{
			if (num != 0.0)
			{
				double num5 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien_nt"]), isNum: true));
				item["thue_gtgt_nt"] = Math.Round(num4 * num5 / num, digits, MidpointRounding.AwayFromZero);
				if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true), (object)0, false))
				{
					Type? typeFromHandle2 = typeof(Math);
					array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["thue_gtgt_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
						null,
						null
					};
					object[] array6 = array3;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array6[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					array = array3;
					object[] array7 = array;
					array5 = new bool[3] { false, true, false };
					object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item["thue_gtgt"] = RuntimeHelpers.GetObjectValue(obj2);
				}
				else
				{
					double num6 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien"]), isNum: true));
					item["thue_gtgt"] = Math.Round(num3 * num6 / num2, AsiaErp.Framework.Environment.GetSIConfiguration().Round, MidpointRounding.AwayFromZero);
				}
			}
			else
			{
				item["thue_gtgt_nt"] = 0;
				item["thue_gtgt"] = 0;
			}
			Calc_ThanhToan(item);
		}
		double num7 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(thue_gtgt_nt)", filter)), isNum: true));
		double num8 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(thue_gtgt)", filter)), isNum: true));
		base.CT1Voucher.Sort = "thue_gtgt_nt desc";
		DataRowView dataRowView2 = base.CT1Voucher[0];
		base.CT1Voucher.Sort = "";
		DataRowView dataRowView3 = dataRowView2;
		DataRowView dataRowView4 = dataRowView3;
		string property = "thue_gtgt";
		dataRowView4[property] = Operators.AddObject(dataRowView3[property], (object)(num3 - num8));
		dataRowView3 = dataRowView2;
		DataRowView dataRowView5 = dataRowView3;
		property = "thue_gtgt_nt";
		dataRowView5[property] = Operators.AddObject(dataRowView3[property], (object)(num4 - num7));
		Calc_ThanhToan(dataRowView2);
		UpdateList();
	}

	private void GetTaInFromDetail()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		if ((base.Tain1Voucher != null && base.Tain1Voucher.Count > 0) ? true : false)
		{
			if ((int)CMessageBox.Show(50148, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)0) != 6)
			{
				return;
			}
			foreach (DataRowView item in base.Tain1Voucher)
			{
				item.Delete();
			}
		}
		if (Conversions.ToDouble(AsiaErp.Framework.Environment.GetPOConfiguration().ke_gtgt_mua_chi_tiet_theo_vt) == 1.0)
		{
			foreach (DataRowView item2 in base.CT1Voucher)
			{
				DataRow dataRow = base.TAINTable.NewRow();
				dataRow["ma_cty"] = CompanyInformations.CompanyID;
				dataRow["stt_rec"] = RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]);
				dataRow["stt_rec0"] = Commons.Get_SttRec0(Conversions.ToString(base.CurrentPHRow["stt_rec"]), base.TAINTable);
				dataRow["so_ct0"] = txtSo_hd.Text.Trim();
				dataRow["ngay_ct0"] = RuntimeHelpers.GetObjectValue(txtNgay_hd.Value);
				dataRow["ma_nt"] = cboMa_NT.MA_NT;
				dataRow["ty_gia"] = RuntimeHelpers.GetObjectValue(txtTy_gia.Value);
				dataRow["tk_thue_no"] = ctlTaIn.Tk_Thue;
				dataRow["Tk_Du"] = ctlTaIn.Tk_Du;
				dataRow["ma_kh"] = ((TextBox)txtMa_Kh).Text.Trim();
				DataRow pDrw = null;
				Commons.ValidMa(ref pDrw, "MA_KH", ((TextBox)txtMa_Kh).Text.Trim(), "", "ten_kh,dia_chi,ma_so_thue", pSd: true);
				if (pDrw != null)
				{
					dataRow["ten_kh"] = RuntimeHelpers.GetObjectValue(pDrw["ten_kh"]);
					dataRow["dia_chi"] = RuntimeHelpers.GetObjectValue(pDrw["dia_chi"]);
					dataRow["ma_so_thue"] = RuntimeHelpers.GetObjectValue(pDrw["ma_so_thue"]);
				}
				dataRow["ma_vt"] = RuntimeHelpers.GetObjectValue(item2["ma_vt"]);
				dataRow["ten_vt"] = RuntimeHelpers.GetObjectValue(item2["ten_vt"]);
				dataRow["tien_hang_nt"] = RuntimeHelpers.GetObjectValue(item2["tien_nt0"]);
				dataRow["tien_hang"] = RuntimeHelpers.GetObjectValue(item2["tien0"]);
				dataRow["t_tien_nt"] = RuntimeHelpers.GetObjectValue(item2["tien_nt0"]);
				dataRow["t_tien"] = RuntimeHelpers.GetObjectValue(item2["tien0"]);
				dataRow["thue_suat"] = RuntimeHelpers.GetObjectValue(item2["ts_gtgt"]);
				dataRow["t_thue_nt"] = RuntimeHelpers.GetObjectValue(item2["thue_gtgt_nt"]);
				dataRow["t_thue"] = RuntimeHelpers.GetObjectValue(item2["thue_gtgt"]);
				dataRow["ma_bp"] = RuntimeHelpers.GetObjectValue(item2["ma_bp"]);
				dataRow["ma_spct"] = RuntimeHelpers.GetObjectValue(item2["ma_spct"]);
				base.TAINTable.Rows.Add(dataRow);
			}
			{
				foreach (DataRowView item3 in base.CP1Voucher)
				{
					DataRow dataRow = base.TAINTable.NewRow();
					dataRow["ma_cty"] = CompanyInformations.CompanyID;
					dataRow["stt_rec"] = RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]);
					dataRow["stt_rec0"] = Commons.Get_SttRec0(Conversions.ToString(base.CurrentPHRow["stt_rec"]), base.TAINTable);
					dataRow["so_ct0"] = "";
					dataRow["ngay_ct0"] = RuntimeHelpers.GetObjectValue(txtNgay_Ct.Value);
					dataRow["ma_nt"] = cboMa_NT.MA_NT;
					dataRow["ty_gia"] = RuntimeHelpers.GetObjectValue(txtTy_gia.Value);
					dataRow["tk_thue_no"] = ctlTaIn.Tk_Thue;
					dataRow["Tk_Du"] = ctlTaIn.Tk_Du;
					dataRow["ma_kh"] = ((TextBox)txtMa_Kh).Text.Trim();
					DataRow pDrw = null;
					Commons.ValidMa(ref pDrw, "MA_KH", ((TextBox)txtMa_Kh).Text.Trim(), "", "ten_kh,dia_chi,ma_so_thue", pSd: true);
					if (pDrw != null)
					{
						dataRow["ten_kh"] = RuntimeHelpers.GetObjectValue(pDrw["ten_kh"]);
						dataRow["dia_chi"] = RuntimeHelpers.GetObjectValue(pDrw["dia_chi"]);
						dataRow["ma_so_thue"] = RuntimeHelpers.GetObjectValue(pDrw["ma_so_thue"]);
					}
					dataRow["ma_vt"] = RuntimeHelpers.GetObjectValue(item3["ma_cp"]);
					dataRow["ten_vt"] = RuntimeHelpers.GetObjectValue(item3["ten_cp"]);
					dataRow["tien_hang_nt"] = RuntimeHelpers.GetObjectValue(item3["tien_cp_nt"]);
					dataRow["tien_hang"] = RuntimeHelpers.GetObjectValue(item3["tien_cp"]);
					dataRow["t_tien_nt"] = RuntimeHelpers.GetObjectValue(item3["tien_cp_nt"]);
					dataRow["t_tien"] = RuntimeHelpers.GetObjectValue(item3["tien_cp"]);
					dataRow["thue_suat"] = RuntimeHelpers.GetObjectValue(item3["ts_gtgt"]);
					dataRow["t_thue_nt"] = RuntimeHelpers.GetObjectValue(item3["thue_gtgt_nt"]);
					dataRow["t_thue"] = RuntimeHelpers.GetObjectValue(item3["thue_gtgt"]);
					dataRow["ghi_chu"] = f_sChi_phi_header;
					base.TAINTable.Rows.Add(dataRow);
				}
				return;
			}
		}
		IOrderedEnumerable<VB_0024AnonymousType_2<decimal, decimal, decimal, decimal, decimal>> orderedEnumerable = from _0024VB_0024It in (from row in CTTable.AsEnumerable()
				where Operators.ConditionalCompareObjectEqual(row["stt_rec"], _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()["stt_rec"], false)
				select row).GroupBy([SpecialName] (DataRow row) => row.Field<decimal?>("ts_gtgt") ?? 0m, [SpecialName] (DataRow row) => row, [SpecialName] (decimal ts_gtgt, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_1<decimal, IEnumerable<DataRow>, decimal, decimal, decimal, decimal>(ts_gtgt, _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien_nt0") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien0") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_gtgt_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_gtgt") ?? 0m)))
			select new VB_0024AnonymousType_2<decimal, decimal, decimal, decimal, decimal>(_0024VB_0024It.ts_gtgt, _0024VB_0024It.tien_nt0, _0024VB_0024It.tien0, _0024VB_0024It.thue_gtgt_nt, _0024VB_0024It.thue_gtgt) into _0024VB_0024It
			orderby _0024VB_0024It.ts_gtgt
			select _0024VB_0024It;
		foreach (VB_0024AnonymousType_2<decimal, decimal, decimal, decimal, decimal> item4 in orderedEnumerable)
		{
			DataRow dataRow = base.TAINTable.NewRow();
			dataRow["ma_cty"] = CompanyInformations.CompanyID;
			dataRow["stt_rec"] = RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]);
			dataRow["stt_rec0"] = Commons.Get_SttRec0(Conversions.ToString(base.CurrentPHRow["stt_rec"]), base.TAINTable);
			dataRow["so_ct0"] = txtSo_hd.Text.Trim();
			dataRow["ngay_ct0"] = RuntimeHelpers.GetObjectValue(txtNgay_hd.Value);
			dataRow["ma_nt"] = cboMa_NT.MA_NT;
			dataRow["ty_gia"] = RuntimeHelpers.GetObjectValue(txtTy_gia.Value);
			dataRow["tk_thue_no"] = ctlTaIn.Tk_Thue;
			dataRow["Tk_Du"] = ctlTaIn.Tk_Du;
			dataRow["ma_kh"] = ((TextBox)txtMa_Kh).Text.Trim();
			DataRow pDrw = null;
			Commons.ValidMa(ref pDrw, "MA_KH", ((TextBox)txtMa_Kh).Text.Trim(), "", "ten_kh,dia_chi,ma_so_thue", pSd: true);
			if (pDrw != null)
			{
				dataRow["ten_kh"] = RuntimeHelpers.GetObjectValue(pDrw["ten_kh"]);
				dataRow["dia_chi"] = RuntimeHelpers.GetObjectValue(pDrw["dia_chi"]);
				dataRow["ma_so_thue"] = RuntimeHelpers.GetObjectValue(pDrw["ma_so_thue"]);
			}
			dataRow["ten_vt"] = txtDien_giai.Text.Trim();
			dataRow["tien_hang_nt"] = item4.tien_nt0;
			dataRow["tien_hang"] = item4.tien0;
			dataRow["t_tien_nt"] = item4.tien_nt0;
			dataRow["t_tien"] = item4.tien0;
			dataRow["t_thue_nt"] = item4.thue_gtgt_nt;
			dataRow["t_thue"] = item4.thue_gtgt;
			dataRow["thue_suat"] = item4.ts_gtgt;
			base.TAINTable.Rows.Add(dataRow);
		}
		if (!Operators.ConditionalCompareObjectNotEqual(txtT_Tien_Cp_nt_Cp.Value, (object)0, false))
		{
			return;
		}
		IOrderedEnumerable<VB_0024AnonymousType_4<decimal, decimal, decimal, decimal, decimal>> orderedEnumerable2 = from _0024VB_0024It in (from row in CPTable.AsEnumerable()
				where Operators.ConditionalCompareObjectEqual(row["stt_rec"], _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()["stt_rec"], false)
				select row).GroupBy([SpecialName] (DataRow row) => row.Field<decimal?>("ts_gtgt") ?? 0m, [SpecialName] (decimal ts_gtgt, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_3<decimal, IEnumerable<DataRow>, decimal, decimal, decimal, decimal>(ts_gtgt, _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien_cp_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien_cp") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_gtgt_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_gtgt") ?? 0m)))
			select new VB_0024AnonymousType_4<decimal, decimal, decimal, decimal, decimal>(_0024VB_0024It.ts_gtgt, _0024VB_0024It.tien_cp_nt, _0024VB_0024It.tien_cp, _0024VB_0024It.thue_gtgt_nt, _0024VB_0024It.thue_gtgt) into _0024VB_0024It
			orderby _0024VB_0024It.thue_gtgt
			select _0024VB_0024It;
		using IEnumerator<VB_0024AnonymousType_4<decimal, decimal, decimal, decimal, decimal>> enumerator5 = orderedEnumerable2.GetEnumerator();
		_Closure_0024__1 closure_0024__ = default(_Closure_0024__1);
		while (enumerator5.MoveNext())
		{
			closure_0024__ = new _Closure_0024__1(closure_0024__);
			VB_0024AnonymousType_4<decimal, decimal, decimal, decimal, decimal> current2 = enumerator5.Current;
			closure_0024__._0024VB_0024Me = this;
			DataRow dataRow = base.TAINTable.NewRow();
			dataRow["ma_cty"] = CompanyInformations.CompanyID;
			dataRow["stt_rec"] = RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]);
			dataRow["stt_rec0"] = Commons.Get_SttRec0(Conversions.ToString(base.CurrentPHRow["stt_rec"]), base.TAINTable);
			dataRow["so_ct0"] = txtSo_hd.Text.Trim();
			dataRow["ngay_ct0"] = RuntimeHelpers.GetObjectValue(txtNgay_Ct.Value);
			dataRow["ma_nt"] = cboMa_NT.MA_NT;
			dataRow["ty_gia"] = RuntimeHelpers.GetObjectValue(txtTy_gia.Value);
			dataRow["tk_thue_no"] = ctlTaIn.Tk_Thue;
			dataRow["Tk_Du"] = ctlTaIn.Tk_Du;
			dataRow["ma_kh"] = ((TextBox)txtMa_Kh).Text.Trim();
			DataRow pDrw = null;
			Commons.ValidMa(ref pDrw, "MA_KH", ((TextBox)txtMa_Kh).Text.Trim(), "", "ten_kh,dia_chi,ma_so_thue", pSd: true);
			if (pDrw != null)
			{
				dataRow["ten_kh"] = RuntimeHelpers.GetObjectValue(pDrw["ten_kh"]);
				dataRow["dia_chi"] = RuntimeHelpers.GetObjectValue(pDrw["dia_chi"]);
				dataRow["ma_so_thue"] = RuntimeHelpers.GetObjectValue(pDrw["ma_so_thue"]);
			}
			dataRow["ghi_chu"] = f_sChi_phi_header;
			closure_0024__._0024VB_0024Local_ts_gtgt = Conversions.ToDouble(Helper.Repl_Null(current2.ts_gtgt, isNum: true));
			EnumerableRowCollection<VB_0024AnonymousType_5<string, string>> enumerableRowCollection = from row in CPTable.AsEnumerable().Where(closure_0024__._Lambda_0024__20)
				select new VB_0024AnonymousType_5<string, string>(row.Field<string>("ma_cp"), row.Field<string>("ten_cp"));
			string text = "";
			int num = 0;
			using (IEnumerator<VB_0024AnonymousType_5<string, string>> enumerator6 = enumerableRowCollection.GetEnumerator())
			{
				for (; enumerator6.MoveNext(); num = checked(num + 1))
				{
					VB_0024AnonymousType_5<string, string> current3 = enumerator6.Current;
					switch (num)
					{
					case 0:
						text = Conversions.ToString(Helper.Repl_Null(current3.ten_cp, isNum: false));
						continue;
					case 1:
						text = Conversions.ToString(Operators.AddObject((object)(text + "; "), Helper.Repl_Null(current3.ten_cp, isNum: false)));
						continue;
					}
					break;
				}
			}
			dataRow["ten_vt"] = text;
			dataRow["tien_hang_nt"] = current2.tien_cp_nt;
			dataRow["tien_hang"] = current2.tien_cp;
			dataRow["t_tien_nt"] = current2.tien_cp_nt;
			dataRow["t_tien"] = current2.tien_cp;
			dataRow["thue_suat"] = current2.ts_gtgt;
			dataRow["t_thue_nt"] = current2.thue_gtgt_nt;
			dataRow["t_thue"] = current2.thue_gtgt;
			base.TAINTable.Rows.Add(dataRow);
		}
	}

	private bool ValidGridHT(int index, object asDgvc, int Cmess)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object)adgvHach_toan, (Type)null, "Item", new object[2]
		{
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(asDgvc, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)),
			index
		}, (string[])null, (Type[])null, (bool[])null), (Type)null, "ErrorText", new object[1] { Helper.GetMessContent(Cmess) }, (string[])null, (Type[])null, false, true);
		((TabControl)AsTabControl).SelectedTab = tabHach_toan;
		((Control)adgvHach_toan).Select();
		((DataGridView)adgvHach_toan).CurrentCell = (DataGridViewCell)NewLateBinding.LateGet((object)adgvHach_toan, (Type)null, "Item", new object[2]
		{
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(asDgvc, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)),
			index
		}, (string[])null, (Type[])null, (bool[])null);
		CMessageBox.Show(Cmess);
		return false;
	}

	private bool ValidGridCT(int index, object asDgvc, int Cmess)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object)adgvDetail, (Type)null, "Item", new object[2]
		{
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(asDgvc, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)),
			index
		}, (string[])null, (Type[])null, (bool[])null), (Type)null, "ErrorText", new object[1] { Helper.GetMessContent(Cmess) }, (string[])null, (Type[])null, false, true);
		((TabControl)AsTabControl).SelectedTab = tabDetail;
		((Control)adgvDetail).Select();
		((DataGridView)adgvDetail).CurrentCell = (DataGridViewCell)NewLateBinding.LateGet((object)adgvDetail, (Type)null, "Item", new object[2]
		{
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(asDgvc, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)),
			index
		}, (string[])null, (Type[])null, (bool[])null);
		CMessageBox.Show(Cmess);
		return false;
	}

	private void RecipeABC(DataGridViewAsTextNumericColumn asDgvc, double dbA, double dbB, double dbC, int index, int Cmess, ref bool CmessGHDC)
	{
		if (dbA != 0.0)
		{
			((DataGridView)adgvDetail)[((DataGridViewColumn)asDgvc).Name, index].ErrorText = string.Empty;
			if (Math.Abs(dbA - dbB) > dbC)
			{
				((DataGridView)adgvDetail)[((DataGridViewColumn)asDgvc).Name, index].ErrorText = Helper.GetMessContent(Cmess);
				CmessGHDC = true;
			}
		}
	}

	private void ValidAdjustOver(int index, DataRowView odv, ref bool CmessGHDC, int Cmess)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		double gia_tri_dieu_chinh_toi_da = AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_toi_da;
		double gia_tri_dieu_chinh_tien_nt_toi_da = AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_tien_nt_toi_da;
		int num = AsiaErp.Framework.Environment.GetSIConfiguration().Round;
		int num2 = AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt;
		int num3 = 1;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num3 = 0;
		}
		if ((Operators.ConditionalCompareObjectNotEqual(((ListControl)cboMa_NT).SelectedValue, (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) && Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false)) ? true : false)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia_Nt0"]), isNum: true)),
				num2,
				MidpointRounding.AwayFromZero
			};
			object[] array2 = array;
			bool[] array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			double dbA = Conversions.ToDouble(obj);
			Type? typeFromHandle2 = typeof(Math);
			object[] array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt0"]), isNum: true), Operators.MultiplyObject((object)num3, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ck_Nt"]), isNum: true)))), (object)100),
				num2,
				MidpointRounding.AwayFromZero
			};
			object[] array5 = array4;
			array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array5, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA2 = Conversions.ToDouble(obj2);
			Type? typeFromHandle3 = typeof(Math);
			array4 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia0"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array6 = array4;
			array3 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array6, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double num4 = Conversions.ToDouble(obj3);
			if (num4 == 0.0)
			{
				Type? typeFromHandle4 = typeof(Math);
				array4 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_nt0"]), isNum: true), txtTy_gia.Value),
					num,
					MidpointRounding.AwayFromZero
				};
				object[] array7 = array4;
				array3 = new bool[3] { false, true, false };
				object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array7, (string[])null, (Type[])null, array3);
				if (array3[1])
				{
					num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
				}
				num4 = Conversions.ToDouble(obj4);
			}
			Type? typeFromHandle5 = typeof(Math);
			array4 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Cp_nt"]), isNum: true), txtTy_gia.Value),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array8 = array4;
			array3 = new bool[3] { false, true, false };
			object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array8, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbB = Conversions.ToDouble(obj5);
			Type? typeFromHandle6 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true)), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array9 = array4;
			array3 = new bool[3] { false, true, false };
			object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array9, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double num5 = Conversions.ToDouble(obj6);
			if (num5 == 0.0)
			{
				Type? typeFromHandle7 = typeof(Math);
				array4 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true), txtTy_gia.Value),
					num,
					MidpointRounding.AwayFromZero
				};
				object[] array10 = array4;
				array3 = new bool[3] { false, true, false };
				object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle7, "Round", array10, (string[])null, (Type[])null, array3);
				if (array3[1])
				{
					num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
				}
				num5 = Conversions.ToDouble(obj7);
			}
			RecipeABC(dgvcTien0, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien0"]), isNum: true)), num4, gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcTien_cp, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Cp"]), isNum: true)), dbB, gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_gtgt, num5, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcTien_nt0, dbA, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt0"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_gtgt_nt, dbA2, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, index, Cmess, ref CmessGHDC);
		}
		else
		{
			Type? typeFromHandle8 = typeof(Math);
			object[] array4 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia_Nt0"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array11 = array4;
			bool[] array3 = new bool[3] { false, true, false };
			object obj8 = NewLateBinding.LateGet((object)null, typeFromHandle8, "Round", array11, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA3 = Conversions.ToDouble(obj8);
			Type? typeFromHandle9 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt0"]), isNum: true), Operators.MultiplyObject((object)num3, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ck_Nt"]), isNum: true)))), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array12 = array4;
			array3 = new bool[3] { false, true, false };
			object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle9, "Round", array12, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA4 = Conversions.ToDouble(obj9);
			RecipeABC(dgvcTien_nt0, dbA3, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt0"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_gtgt_nt, dbA4, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
		}
	}

	private void RefreshValueByMa_Nt()
	{
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) != 0)
		{
			return;
		}
		int num = AsiaErp.Framework.Environment.GetSIConfiguration().Round;
		int num2 = AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia;
		foreach (DataRowView item in base.CT1Voucher)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien_nt"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array2 = array;
			bool[] array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			item["tien_nt"] = RuntimeHelpers.GetObjectValue(obj);
			Type? typeFromHandle2 = typeof(Math);
			object[] array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt"]), isNum: true)),
				num2,
				MidpointRounding.AwayFromZero
			};
			object[] array5 = array4;
			array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array5, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			item["gia_nt"] = RuntimeHelpers.GetObjectValue(obj2);
			Type? typeFromHandle3 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien_nt0"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array6 = array4;
			array3 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array6, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			item["tien_nt0"] = RuntimeHelpers.GetObjectValue(obj3);
			Type? typeFromHandle4 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt0"]), isNum: true)),
				num2,
				MidpointRounding.AwayFromZero
			};
			object[] array7 = array4;
			array3 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array7, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			item["gia_nt0"] = RuntimeHelpers.GetObjectValue(obj4);
			Type? typeFromHandle5 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_Nt"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array8 = array4;
			array3 = new bool[3] { false, true, false };
			object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array8, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			item["Thue_Gtgt_Nt"] = RuntimeHelpers.GetObjectValue(obj5);
			Type? typeFromHandle6 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["cp_nt"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array9 = array4;
			array3 = new bool[3] { false, true, false };
			object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array9, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			item["cp_nt"] = RuntimeHelpers.GetObjectValue(obj6);
			Type? typeFromHandle7 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tt_nt"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array10 = array4;
			array3 = new bool[3] { false, true, false };
			object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle7, "Round", array10, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			item["Tt_nt"] = RuntimeHelpers.GetObjectValue(obj7);
		}
		foreach (DataRowView item2 in base.CP1Voucher)
		{
			Type? typeFromHandle8 = typeof(Math);
			object[] array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp_nt"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array11 = array4;
			bool[] array3 = new bool[3] { false, true, false };
			object obj8 = NewLateBinding.LateGet((object)null, typeFromHandle8, "Round", array11, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			item2["tien_cp_nt"] = RuntimeHelpers.GetObjectValue(obj8);
			Type? typeFromHandle9 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt_nt"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array12 = array4;
			array3 = new bool[3] { false, true, false };
			object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle9, "Round", array12, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			item2["Thue_Gtgt_nt"] = RuntimeHelpers.GetObjectValue(obj9);
			Type? typeFromHandle10 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tt_nt"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array13 = array4;
			array3 = new bool[3] { false, true, false };
			object obj10 = NewLateBinding.LateGet((object)null, typeFromHandle10, "Round", array13, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			item2["Tt_nt"] = RuntimeHelpers.GetObjectValue(obj10);
		}
	}

	private void Thanh_toan()
	{
		//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
		frmCA4PO frmCA4PO = new frmCA4PO();
		MenuInformation menuInformation = AsiaErp.Framework.Environment.GetMenuInformation(base.MyMenuInfo.par1);
		MenuInformation menuInformation2 = AsiaErp.Framework.Environment.GetMenuInformation(base.MyMenuInfo.par2);
		DataTable dataTable = Commons.GetDataTable("asPOGetCA4PO", CompanyInformations.CompanyID, "CA", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]), isNum: false)));
		if (dataTable == null || dataTable.Rows.Count == 0)
		{
			VoucherInformation voucherInformation = AsiaErp.Framework.Environment.GetVoucherInformation(menuInformation.code_name);
			SiDmCt siDMCTByMa_Ct = AsiaErp.Framework.Environment.GetSiDMCTByMa_Ct(voucherInformation.voucher_code);
			frmCA4PO.MyMenuInfo = menuInformation;
			frmCA4PO.f_CAVoucherInfo = voucherInformation;
			frmCA4PO.f_mode = "M";
			frmCA4PO.txtNgay_Ct.Value = RuntimeHelpers.GetObjectValue(txtNgay_Ct.Value);
			frmCA4PO.txtSo_Ct.Text = Commons.Get_SoCt(voucherInformation.voucher_code, Conversions.ToDate(txtNgay_Ct.Value));
			((TextBox)frmCA4PO.txtTk_Co).Text = siDMCTByMa_Ct.tk_co;
			frmCA4PO.txtNguoi_Gd.Text = txtNguoi_Gd.Text;
			frmCA4PO.txtDien_giai.Text = txtDien_giai.Text;
			frmCA4PO.f_Ma_kh = ((TextBox)txtMa_Kh).Text;
			frmCA4PO.f_Ten_kh = lblTen_Kh.Text;
			frmCA4PO.f_Dia_chi_kh = txtDia_chi.Text;
			frmCA4PO.f_Ma_nt = cboMa_NT.MA_NT;
			frmCA4PO.f_Ty_gia = Conversions.ToDecimal(txtTy_gia.Value);
			DataTable dataTable2 = new DataTable("CaCt1");
			dataTable2.Columns.Add("ma_cty", typeof(string)).DefaultValue = CompanyInformations.CompanyID;
			dataTable2.Columns.Add("stt_rec", typeof(string)).DefaultValue = "";
			dataTable2.Columns.Add("stt_rec0", typeof(string)).DefaultValue = "";
			dataTable2.Columns.Add("Tk", typeof(string));
			dataTable2.Columns.Add("Ten_Tk", typeof(string)).DefaultValue = "";
			dataTable2.Columns.Add("Ps_no", typeof(decimal));
			dataTable2.Columns.Add("Ps_no_nt", typeof(decimal));
			dataTable2.Columns.Add("ma_kh", typeof(string)).DefaultValue = frmCA4PO.f_Ma_kh;
			dataTable2.Columns.Add("ma_hd", typeof(string));
			dataTable2.Columns.Add("ma_bp", typeof(string));
			dataTable2.Columns.Add("ma_phi", typeof(string));
			dataTable2.Columns.Add("ma_spct", typeof(string));
			dataTable2.Columns.Add("ma_lo", typeof(string));
			DataRow pDrw = default(DataRow);
			if ((Commons.ValidMa(ref pDrw, "TK", ((TextBox)txtTk_pt).Text.Trim(), "", "tk_cn") && pDrw != null && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(pDrw["tk_cn"]), isNum: true), (object)false, false)) ? true : false)
			{
				IEnumerable<VB_0024AnonymousType_8<object, decimal, decimal, object, object, object, object, object>> enumerable = from _0024VB_0024It in (from row in base.CTTable.AsEnumerable()
						where Operators.ConditionalCompareObjectEqual(row["Stt_Rec"], _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()["stt_rec"], false)
						select row).GroupBy([SpecialName] (DataRow row) => new VB_0024AnonymousType_6<object, object, object, object, object, object>(RuntimeHelpers.GetObjectValue(row["tk_vt"]), RuntimeHelpers.GetObjectValue(row["ma_hd"]), RuntimeHelpers.GetObjectValue(row["ma_bp"]), RuntimeHelpers.GetObjectValue(row["ma_phi"]), RuntimeHelpers.GetObjectValue(row["ma_spct"]), RuntimeHelpers.GetObjectValue(row["ma_lo"])), [SpecialName] (DataRow row) => row, [SpecialName] (VB_0024AnonymousType_6<object, object, object, object, object, object> _0024VB_0024Key, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_7<object, object, object, object, object, object, IEnumerable<DataRow>, decimal, decimal>(RuntimeHelpers.GetObjectValue(_0024VB_0024Key.tk), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_hd), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_bp), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_phi), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_spct), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_lo), _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien") ?? 0m)))
					select new VB_0024AnonymousType_8<object, decimal, decimal, object, object, object, object, object>(RuntimeHelpers.GetObjectValue(_0024VB_0024It.tk), _0024VB_0024It.ps_no_nt, _0024VB_0024It.ps_no, RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_hd), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_bp), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_phi), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_spct), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_lo));
				foreach (VB_0024AnonymousType_8<object, decimal, decimal, object, object, object, object, object> item in enumerable)
				{
					pDrw = dataTable2.NewRow();
					pDrw["stt_rec0"] = Commons.Get_SttRec0("", dataTable2);
					pDrw["tk"] = RuntimeHelpers.GetObjectValue(item.tk);
					pDrw["ps_no"] = item.ps_no;
					pDrw["ps_no_nt"] = item.ps_no_nt;
					pDrw["ma_hd"] = RuntimeHelpers.GetObjectValue(item.ma_hd);
					pDrw["ma_bp"] = RuntimeHelpers.GetObjectValue(item.ma_bp);
					pDrw["ma_phi"] = RuntimeHelpers.GetObjectValue(item.ma_phi);
					pDrw["ma_spct"] = RuntimeHelpers.GetObjectValue(item.ma_spct);
					pDrw["ma_lo"] = RuntimeHelpers.GetObjectValue(item.ma_lo);
					dataTable2.Rows.Add(pDrw);
				}
				IEnumerable<VB_0024AnonymousType_11<object, decimal, decimal, object, object, object>> enumerable2 = from _0024VB_0024It in (from row in base.TAINTable.AsEnumerable()
						where Operators.ConditionalCompareObjectEqual(row["Stt_Rec"], _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()["stt_rec"], false)
						select row).GroupBy([SpecialName] (DataRow row) => new VB_0024AnonymousType_9<object, object, object, object>(RuntimeHelpers.GetObjectValue(row["tk_thue_no"]), RuntimeHelpers.GetObjectValue(row["ma_bp"]), RuntimeHelpers.GetObjectValue(row["ma_spct"]), RuntimeHelpers.GetObjectValue(row["ma_lo"])), [SpecialName] (DataRow row) => row, [SpecialName] (VB_0024AnonymousType_9<object, object, object, object> _0024VB_0024Key, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_10<object, object, object, object, IEnumerable<DataRow>, decimal, decimal>(RuntimeHelpers.GetObjectValue(_0024VB_0024Key.tk), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_bp), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_spct), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_lo), _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("t_thue_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("t_thue") ?? 0m)))
					select new VB_0024AnonymousType_11<object, decimal, decimal, object, object, object>(RuntimeHelpers.GetObjectValue(_0024VB_0024It.tk), _0024VB_0024It.ps_no_nt, _0024VB_0024It.ps_no, RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_bp), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_spct), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_lo));
				foreach (VB_0024AnonymousType_11<object, decimal, decimal, object, object, object> item2 in enumerable2)
				{
					pDrw = dataTable2.NewRow();
					pDrw["stt_rec0"] = Commons.Get_SttRec0("", dataTable2);
					pDrw["tk"] = RuntimeHelpers.GetObjectValue(item2.tk);
					pDrw["ps_no"] = item2.ps_no;
					pDrw["ps_no_nt"] = item2.ps_no_nt;
					pDrw["ma_bp"] = RuntimeHelpers.GetObjectValue(item2.ma_bp);
					pDrw["ma_spct"] = RuntimeHelpers.GetObjectValue(item2.ma_spct);
					pDrw["ma_lo"] = RuntimeHelpers.GetObjectValue(item2.ma_lo);
					dataTable2.Rows.Add(pDrw);
				}
			}
			else
			{
				pDrw = dataTable2.NewRow();
				pDrw["stt_rec0"] = Commons.Get_SttRec0("", dataTable2);
				pDrw["tk"] = ((TextBox)txtTk_pt).Text.Trim();
				pDrw["ps_no"] = RuntimeHelpers.GetObjectValue(txtT_tt.Value);
				pDrw["ps_no_nt"] = RuntimeHelpers.GetObjectValue(txtT_tt_nt.Value);
				DataRowView currentCTRowView = base.CurrentCTRowView;
				pDrw["ma_hd"] = RuntimeHelpers.GetObjectValue(currentCTRowView["ma_hd"]);
				pDrw["ma_bp"] = RuntimeHelpers.GetObjectValue(currentCTRowView["ma_bp"]);
				pDrw["ma_phi"] = RuntimeHelpers.GetObjectValue(currentCTRowView["ma_phi"]);
				pDrw["ma_spct"] = RuntimeHelpers.GetObjectValue(currentCTRowView["ma_spct"]);
				pDrw["ma_lo"] = RuntimeHelpers.GetObjectValue(currentCTRowView["ma_lo"]);
				dataTable2.Rows.Add(pDrw);
			}
			dataTable2.AcceptChanges();
			frmCA4PO.f_oTblCt = dataTable2;
		}
		else
		{
			DataRow dataRow = dataTable.Rows[0];
			frmCA4PO.txtNgay_Ct.Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ngay_ct"]), isNum: false));
			frmCA4PO.txtSo_Ct.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["so_ct"]), isNum: false));
			((TextBox)frmCA4PO.txtTk_Co).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["tk_co"]), isNum: false));
			frmCA4PO.f_Ma_kh = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ma_kh"]), isNum: false));
			frmCA4PO.txtNguoi_Gd.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["nguoi_gd"]), isNum: false));
			frmCA4PO.txtDien_giai.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["dien_giai"]), isNum: false));
			frmCA4PO.f_Dia_chi_kh = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["dia_chi"]), isNum: false));
			frmCA4PO.f_Ma_nt = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ma_nt"]), isNum: false));
			frmCA4PO.f_Ty_gia = Conversions.ToDecimal(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ty_gia"]), isNum: true));
			frmCA4PO.f_stt_rec = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["stt_rec"]), isNum: false));
			string text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ma_ct"]), isNum: false));
			if (Operators.CompareString(text, "CA4", false) == 0)
			{
				frmCA4PO.rbCA4.Checked = true;
			}
			frmCA4PO.f_mode = "X";
			frmCA4PO.f_oTblCt = dataTable;
		}
		frmCA4PO.f_stt_rec_hd = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]), isNum: false));
		frmCA4PO.f_CA2_MenuInfo = menuInformation;
		frmCA4PO.f_CA4_MenuInfo = menuInformation2;
		((Form)frmCA4PO).ShowDialog();
		if (frmCA4PO.isOK)
		{
			string text2 = frmCA4PO.f_CAVoucherInfo.voucher_code + ": " + frmCA4PO.txtSo_Ct.Text + " - " + Conversions.ToDate(frmCA4PO.txtNgay_Ct.Value).ToString("dd/MM/yyyy");
			base.CurrentPHRow["ten_trang_thai"] = text2;
			((ToolStripItem)tsslTrangThai).Text = text2;
			((ToolStripItem)tsslTrangThai).Visible = true;
		}
		((Component)(object)frmCA4PO).Dispose();
	}

	private void PhanBoChietKhauHoaDon()
	{
		if (CT1Voucher.Count == 0)
		{
			return;
		}
		string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
		int digits = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		double num = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(Tien_Nt0)", filter)), isNum: true));
		double num2 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(tien0)", filter)), isNum: true));
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		num5 = Conversions.ToDouble(txtT_ck.Value);
		num6 = Conversions.ToDouble(txtT_ck_nt.Value);
		foreach (DataRowView item in base.CT1Voucher)
		{
			if ((num6 != 0.0 && num != 0.0) ? true : false)
			{
				double num7 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt0"]), isNum: true));
				double num8 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien0"]), isNum: true));
				num3 = Math.Round(num6 * num7 / num, digits, MidpointRounding.AwayFromZero);
				num4 = Math.Round(num5 * num8 / num2, AsiaErp.Framework.Environment.GetSIConfiguration().Round, MidpointRounding.AwayFromZero);
			}
			item["ck"] = num4;
			item["ck_nt"] = num3;
			Calc_Thue_gtgt(item);
			Calc_ThanhToan(item);
		}
		double num9 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(ck_nt)", filter)), isNum: true));
		double num10 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(ck)", filter)), isNum: true));
		CT1Voucher.Sort = "ck_nt desc";
		DataRowView dataRowView2 = CT1Voucher[0];
		CT1Voucher.Sort = "";
		DataRowView dataRowView3 = dataRowView2;
		DataRowView dataRowView4 = dataRowView3;
		string property = "ck";
		dataRowView4[property] = Operators.AddObject(dataRowView3[property], (object)(num5 - num10));
		dataRowView3 = dataRowView2;
		DataRowView dataRowView5 = dataRowView3;
		property = "ck_nt";
		dataRowView5[property] = Operators.AddObject(dataRowView3[property], (object)(num6 - num9));
		Calc_Thue_gtgt(dataRowView2);
		Calc_ThanhToan(dataRowView2);
	}

	private void Calc_Ck_hd()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		int num2 = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num2 = 1;
		}
		AsTextNumeric asTextNumeric = txtT_ck_nt;
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Operators.AddObject(txtT_Tien_nt0.Value, Operators.MultiplyObject((object)num2, txtT_thue_Nt.Value)), txtTl_ck_hd.Value), (object)100),
			num,
			MidpointRounding.AwayFromZero
		};
		object[] array2 = array;
		bool[] array3 = new bool[3] { false, true, false };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj);
		AsTextNumeric asTextNumeric2 = txtT_ck;
		Type? typeFromHandle2 = typeof(Math);
		array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Operators.AddObject(txtT_Tien0.Value, Operators.MultiplyObject((object)num2, txtT_Thue.Value)), txtTl_ck_hd.Value), (object)100),
			null,
			null
		};
		object[] array4 = array;
		SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
		array4[1] = sIConfiguration.Round;
		array[2] = MidpointRounding.AwayFromZero;
		object[] array5 = array;
		object[] array6 = array5;
		array3 = new bool[3] { false, true, false };
		object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
		}
		asTextNumeric2.Value = RuntimeHelpers.GetObjectValue(obj2);
		PhanBoChietKhauHoaDon();
	}

	private void LookupDH(string aKey)
	{
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		DataTable oTblPh = null;
		DataTable oTblCt = null;
		if (POCommon.POLookupDH4PN(aKey, ref oTblPh, ref oTblCt))
		{
			frmPOVchPO3SeachPO1 frmPOVchPO3SeachPO2 = new frmPOVchPO3SeachPO1();
			((Form)frmPOVchPO3SeachPO2).Text = ((ButtonBase)cmdChon_dh).Text.Replace("&", "");
			frmPOVchPO3SeachPO2.PHTable = oTblPh;
			frmPOVchPO3SeachPO2.CTTable = oTblCt;
			if ((int)((Form)frmPOVchPO3SeachPO2).ShowDialog() == 1)
			{
				DataRow[] array = oTblPh.Select("CHON=True");
				if (array.Length < 1)
				{
					return;
				}
				DataRow[] array2 = CTTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec ='", CurrentPHRow["Stt_Rec"]), (object)"'")));
				foreach (DataRow dataRow in array2)
				{
					dataRow.Delete();
				}
				DataRow dataRow2 = array[0];
				cboMa_NT.MA_NT = Conversions.ToString(dataRow2["Ma_Nt"]);
				TextBox oTxt = (TextBox)(object)txtTy_gia;
				SetTexboxValue(ref oTxt, Conversions.ToString(dataRow2["Ty_Gia"]));
				txtTy_gia = (AsTextNumeric)(object)oTxt;
				oTxt = txtNguoi_Gd;
				SetTexboxValue(ref oTxt, Conversions.ToString(dataRow2["nguoi_gd"]));
				txtNguoi_Gd = oTxt;
				DataRow[] array3 = array;
				foreach (DataRow dataRow3 in array3)
				{
					DataRow[] array4 = oTblCt.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", dataRow3["Stt_rec"]), (object)"' And Chon=True")));
					foreach (DataRow dataRow4 in array4)
					{
						DataRow dataRow5 = CTTable.NewRow();
						dataRow5["Stt_Rec"] = RuntimeHelpers.GetObjectValue(CurrentPHRow["Stt_Rec"]);
						dataRow5["Stt_Rec0"] = Commons.Get_SttRec0(Conversions.ToString(CurrentPHRow["Stt_Rec"]), CTTable);
						dataRow5["Stt_Rec_dh"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec"]);
						dataRow5["Stt_Rec0_dh"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec0"]);
						dataRow5["So_dh"] = RuntimeHelpers.GetObjectValue(dataRow3["So_Ct"]);
						dataRow5["ma_vt"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_vt"]);
						dataRow5["ten_Vt"] = RuntimeHelpers.GetObjectValue(dataRow4["ten_Vt"]);
						dataRow5["Dvt"] = RuntimeHelpers.GetObjectValue(dataRow4["Dvt"]);
						dataRow5["ma_kho"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_kho"]);
						dataRow5["So_luong"] = RuntimeHelpers.GetObjectValue(dataRow4["sl_ton"]);
						dataRow5["Gia_nt0"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia_nt0"]);
						dataRow5["Gia0"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia0"]);
						dataRow5["Tien_Nt0"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_ton_nt0"]);
						dataRow5["Tien0"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_ton0"]);
						dataRow5["Gia_nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia_nt0"]);
						dataRow5["Gia"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia0"]);
						dataRow5["Tien_Nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_ton_nt0"]);
						dataRow5["Tien"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_ton0"]);
						dataRow5["Ts_Gtgt"] = RuntimeHelpers.GetObjectValue(dataRow4["Ts_Gtgt"]);
						dataRow5["Thue_Gtgt_Nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Thue_Gtgt_Nt"]);
						dataRow5["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(dataRow4["Thue_Gtgt"]);
						dataRow5["Tt_Nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Tt_Nt"]);
						dataRow5["Tt"] = RuntimeHelpers.GetObjectValue(dataRow4["Tt"]);
						dataRow5["tk_vt"] = RuntimeHelpers.GetObjectValue(dataRow4["tk_vt"]);
						dataRow5["ma_vitri"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_vitri"]);
						dataRow5["ma_lo"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_lo"]);
						dataRow5["ma_spct"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_spct"]);
						dataRow5["ma_phi"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_phi"]);
						dataRow5["ma_bp"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_bp"]);
						CTTable.Rows.Add(dataRow5);
						ReCalcAfterLookup(dataRow5);
						ReCalcTonKhoTucThoi(dataRow5);
					}
				}
				UpdateList();
				((TextBoxBase)txtMa_Kh).ReadOnly = true;
				base.CurrentPHRow["tao_tu_dh"] = true;
			}
			((TabControl)AsTabControl).SelectedTab = tabDetail;
		}
		else
		{
			CMessageBox.Show(50016);
		}
	}

	protected override void InitOtherBeforeLoadData()
	{
		base.InitOtherBeforeLoadData();
		string chiet_khau_mua_hang = AsiaErp.Framework.Environment.GetPOConfiguration().chiet_khau_mua_hang;
		if (Operators.CompareString(chiet_khau_mua_hang, "1", false) == 0)
		{
			AddControl2ListOfDrivedControls((Control)(object)txtT_ck_nt);
			AddControl2ListOfDrivedControls((Control)(object)txtT_ck);
			AddControl2ListOfDrivedControls((Control)(object)txtTl_ck_hd);
		}
		else if (Operators.CompareString(chiet_khau_mua_hang, "2", false) == 0)
		{
			((DataGridViewColumn)dgvcTl_ck).Visible = true;
			((DataGridViewColumn)dgvcCk_nt).Visible = true;
			((DataGridViewColumn)dgvcCk).Visible = true;
			((DataGridViewColumn)dgvcCk_nt_ht).Visible = true;
			((DataGridViewColumn)dgvcCk_ht).Visible = true;
		}
		ArrayList arrayList = new ArrayList();
		DictionaryEntry dictionaryEntry = new DictionaryEntry("1", AsiaErp.Framework.Environment.getLangSysMessageResX("#POVCHPO4_TTPB_SOLUONG").value);
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("2", AsiaErp.Framework.Environment.getLangSysMessageResX("#POVCHPO4_TTPB_GIATRI").value);
		arrayList.Add(dictionaryEntry);
		bsTT_PB.DataSource = arrayList;
		dgvcTT_PB.DisplayMember = "Value";
		dgvcTT_PB.ValueMember = "Key";
		dgvcTT_PB.DataSource = bsTT_PB;
		f_sGia_header = ((DataGridViewColumn)dgvcGia_nt0).HeaderText;
		f_sTien_header = ((DataGridViewColumn)dgvcTien_nt_ht).HeaderText;
		f_sTien0_header = ((DataGridViewColumn)dgvcTien_nt0).HeaderText;
		f_sChi_phi_header = ((DataGridViewColumn)dgvcTien_cp_nt).HeaderText;
		f_sCk_header = ((DataGridViewColumn)dgvcCk_nt).HeaderText;
		f_sThue_header = ((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText;
		f_sTien0_cp_header = ((DataGridViewColumn)dgvcTien_nt0_ht).HeaderText;
		string ma_nt = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		((DataGridViewColumn)dgvcGia0).HeaderText = f_sGia_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien0).HeaderText = f_sTien0_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien_cp).HeaderText = f_sChi_phi_header + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = f_sThue_header + " " + ma_nt;
		((DataGridViewColumn)dgvcCk).HeaderText = f_sCk_header + " " + ma_nt;
		((DataGridViewColumn)dgvcCk_ht).HeaderText = f_sCk_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien0_ht).HeaderText = f_sTien0_cp_header + " " + ma_nt;
		((DataGridViewColumn)dgvcCp_Nt_ht).HeaderText = f_sChi_phi_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien_ht).HeaderText = f_sTien_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien_cp_cp).HeaderText = f_sChi_phi_header + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_Gtgt_cp).HeaderText = f_sThue_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTt_Cp).HeaderText = f_sTien_header + " " + ma_nt;
		string amount_Input_Format = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		string qty_Input_Format = AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format;
		txtT_So_luong.Mask = qty_Input_Format;
		dgvcSo_luong.Mask = qty_Input_Format;
		dgvcTon.Mask = qty_Input_Format;
		txtT_Tien0.Mask = amount_Input_Format;
		txtT_Tien.Mask = amount_Input_Format;
		txtT_Thue.Mask = amount_Input_Format;
		txtT_cp.Mask = amount_Input_Format;
		txtT_tt.Mask = amount_Input_Format;
		dgvcCp_ht.Mask = amount_Input_Format;
		dgvcTien0_ht.Mask = amount_Input_Format;
		dgvcTien_ht.Mask = amount_Input_Format;
		dgvcTien_cp_cp.Mask = amount_Input_Format;
		dgvcThue_Gtgt_cp.Mask = amount_Input_Format;
		dgvcTt_Cp.Mask = amount_Input_Format;
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		base.PHTable.Columns["ma_gd"].DefaultValue = f_sMa_Gd_Default;
		base.PHTable.Columns["tao_tu_pn"].DefaultValue = false;
		base.PHTable.Columns["mau_hd"].DefaultValue = "0";
		base.CPTable.Columns["TT_PB"].DefaultValue = "1";
		((DataGridView)adgvHach_toan).DataSource = bsCT;
		((DataGridView)adgvChi_phi).DataSource = bsCP;
		ctlTaIn.DataSource = bsTain;
		ctlTaIn.TAINTable = base.TAINTable;
		AddControl2ListOfDrivedControls((Control)(object)cmdGetTaInFromDetail);
		AddControl2ListOfDrivedControls((Control)(object)ctlTaIn.chkKe_tain);
		AddControl2ListOfDrivedControls((Control)(object)chkCk_st);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Tien_nt0);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tien_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_thue_Nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_cp_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_ck_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tt_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tt_nt_cp);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_thue_nt_cp);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Tien_Cp_nt_Cp);
		AddDGV(adgvHach_toan);
		AddDGV(adgvChi_phi);
	}

	protected override void RefreshDGVInput()
	{
		base.RefreshDGVInput();
		if (CTTable == null)
		{
			return;
		}
		bool flag = false;
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			txtTy_gia.Value = 1;
			((TextBoxBase)txtTy_gia).ReadOnly = true;
			((Control)txtTy_gia).TabStop = false;
		}
		else
		{
			flag = true;
			((TextBoxBase)txtTy_gia).ReadOnly = ActionMode == Commons.ApplicationMode.VIEW_MODE;
			((Control)txtTy_gia).TabStop = true;
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				txtTy_gia.Value = Commons.Get_TyGia(cboMa_NT.MA_NT, Conversions.ToDate(txtNgay_Ct.Value));
			}
		}
		((Control)txtT_Tien0).Visible = flag;
		((Control)txtT_Thue).Visible = flag;
		((Control)txtT_cp).Visible = flag;
		((Control)txtT_tt).Visible = flag;
		((Control)txtT_ck).Visible = flag;
		((DataGridViewColumn)dgvcGia0).Visible = flag;
		((DataGridViewColumn)dgvcTien0).Visible = flag;
		((DataGridViewColumn)dgvcTien_cp).Visible = flag;
		((DataGridViewColumn)dgvcCk).Visible = flag;
		((DataGridViewColumn)dgvcTs_gtgt).Visible = hasVATinDetal;
		((DataGridViewColumn)dgvcThue_gtgt_nt).Visible = hasVATinDetal;
		((DataGridViewColumn)dgvcThue_gtgt).Visible = ((flag && hasVATinDetal) ? true : false);
		((DataGridViewColumn)dgvcTien_cp_cp).Visible = flag;
		((DataGridViewColumn)dgvcThue_Gtgt_cp).Visible = flag;
		((DataGridViewColumn)dgvcTt_Cp).Visible = flag;
		((DataGridViewColumn)dgvcCp_ht).Visible = flag;
		((DataGridViewColumn)dgvcTien0_ht).Visible = flag;
		((DataGridViewColumn)dgvcTien_ht).Visible = flag;
		((DataGridViewColumn)dgvcCk_ht).Visible = flag;
		string mA_NT = cboMa_NT.MA_NT;
		((DataGridViewColumn)dgvcGia_nt0).HeaderText = f_sGia_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt0).HeaderText = f_sTien0_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_cp_nt).HeaderText = f_sChi_phi_header + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = f_sThue_header + " " + mA_NT;
		((DataGridViewColumn)dgvcCk_nt).HeaderText = f_sCk_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt0_ht).HeaderText = f_sTien0_cp_header + " " + mA_NT;
		((DataGridViewColumn)dgvcCp_Nt_ht).HeaderText = f_sChi_phi_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = f_sTien_header + " " + mA_NT;
		((DataGridViewColumn)dgvcCk_nt_ht).HeaderText = f_sCk_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_cp_nt_cp).HeaderText = f_sChi_phi_header + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_gtgt_nt_cp).HeaderText = f_sThue_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTt_nt_Cp).HeaderText = f_sTien_header + " " + mA_NT;
		UpdateCPList();
	}

	protected override void SetFocus4FirstEditControl()
	{
		if ((base.ActionMode == Commons.ApplicationMode.EDIT_MODE && base.CurrentPHRow != null && Operators.ConditionalCompareObjectEqual(base.CurrentPHRow["tao_tu_pn"], (object)true, false)) ? true : false)
		{
			((Control)txtNguoi_Gd).Select();
		}
		else
		{
			((Control)txtMa_Kh).Select();
		}
	}

	protected override void UpdateList()
	{
		if (base.CurrentPHRow != null)
		{
			string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
			txtT_thue_Nt.Value = ctlTaIn.get_T_Thue_Nt("");
			txtT_Thue.Value = ctlTaIn.get_T_Thue("");
			txtT_Tien0.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(tien0)", filter));
			txtT_Tien_nt0.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(tien_nt0)", filter));
			txtT_cp.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(cp)", filter));
			txtT_cp_nt.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(cp_nt)", filter));
			txtT_ck_nt.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(ck_nt)", filter));
			txtT_ck.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(ck)", filter));
			txtT_So_luong.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(So_luong)", filter));
			txtT_Tien.Value = Operators.SubtractObject(Operators.AddObject(txtT_Tien0.Value, txtT_cp.Value), txtT_ck.Value);
			txtT_tien_nt.Value = Operators.SubtractObject(Operators.AddObject(txtT_Tien_nt0.Value, txtT_cp_nt.Value), txtT_ck_nt.Value);
			txtT_tt_nt.Value = Operators.SubtractObject(Operators.AddObject(Operators.AddObject(txtT_Tien_nt0.Value, txtT_cp_nt.Value), Operators.PlusObject(txtT_thue_Nt.Value)), txtT_ck.Value);
			txtT_tt.Value = Operators.SubtractObject(Operators.AddObject(Operators.AddObject(txtT_Tien0.Value, txtT_cp.Value), txtT_Thue.Value), txtT_ck_nt.Value);
		}
	}

	protected override bool ValidData()
	{
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		ctlTaIn.Ma_Nt = cboMa_NT.MA_NT;
		ctlTaIn.Ty_Gia = Conversions.ToDouble(txtTy_gia.Value);
		bool flag = true;
		bool CmessGHDC = false;
		bool flag2 = true;
		checked
		{
			if ((ChkEmtyTextBox((TextBox)(object)txtMa_Kh) && ChkEmtyTextBox((TextBox)(object)txtMa_Httt) && base.ValidData() && ctlTaIn.ValidData()) ? true : false)
			{
				int num = base.CT1Voucher.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					DataRowView dataRowView = base.CT1Voucher[num2];
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Vt"]), isNum: false), (object)"", false))
					{
						return ValidGridCT(num2, dgvcMa_vt, 50062);
					}
					if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Kho"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ton_kho"]), isNum: false), (object)"1", false)) ? true : false)
					{
						return ValidGridCT(num2, dgvcMa_kho, 50056);
					}
					if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ton_kho"]), isNum: false), (object)"1", false)) ? true : false)
					{
						((TabControl)AsTabControl).SelectedTab = tabDetail;
						((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcSo_luong).Name, num2].ErrorText = Helper.GetMessContent(50037);
						flag2 = false;
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_vt"]), isNum: false), (object)"", false))
					{
						return ValidGridHT(num2, dgvcTk_vt, 50023);
					}
					ValidAdjustOver(num2, dataRowView, ref CmessGHDC, 50130);
					num2++;
				}
				if (CmessGHDC)
				{
					return Commons.ProcessAdjustOver();
				}
				if (!flag2)
				{
					CMessageBox.Show(50037);
				}
				int num5 = CP1Voucher.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					DataRowView dataRowView2 = CP1Voucher[num6];
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView2["tien_cp_nt"]), isNum: true), (object)0, false))
					{
						((TabControl)AsTabControl).SelectedTab = tabChi_phi;
						((Control)adgvChi_phi).Select();
						((DataGridView)adgvChi_phi).CurrentCell = ((DataGridView)adgvChi_phi)[((DataGridViewColumn)dgvcTt_nt_Cp).Name, num6];
						CMessageBox.Show(50048);
						return false;
					}
					num6++;
				}
				string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
				double num8 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(cp_nt)", filter)), isNum: true));
				double num9 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(cp)", filter)), isNum: true));
				double num10 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp_nt)", filter)), isNum: true));
				double num11 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp)", filter)), isNum: true));
				if (num8 != num10 || ((num9 != num11) ? true : false))
				{
					CMessageBox.Show(50033);
					return false;
				}
				return true;
			}
			return false;
		}
	}

	protected override void Refresh_controls()
	{
		base.Refresh_controls();
		if (base.ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				txtTy_gia.Value = 1;
				((TextBoxBase)txtTy_gia).ReadOnly = true;
				((Control)txtTy_gia).TabStop = false;
			}
			else
			{
				((TextBoxBase)txtTy_gia).ReadOnly = false;
				((Control)txtTy_gia).TabStop = true;
			}
			adgvHach_toan.ReadOnly = false;
			adgvChi_phi.ReadOnly = false;
			ctlTaIn.adgvTaIn.ReadOnly = false;
			if ((base.CurrentPHRow != null && Operators.ConditionalCompareObjectEqual(base.CurrentPHRow["tao_tu_pn"], (object)true, false)) ? true : false)
			{
				((TextBoxBase)txtMa_Kh).ReadOnly = true;
			}
			else
			{
				((TextBoxBase)txtMa_Kh).ReadOnly = false;
			}
			((TextBoxBase)txtMa_so_thue).ReadOnly = true;
			((TextBoxBase)txtMa_so_thue).BackColor = ClientConfiguration.DEFAULT_FORM_BACKCOLOR;
		}
		else
		{
			adgvHach_toan.ReadOnly = true;
			adgvChi_phi.ReadOnly = true;
			ctlTaIn.adgvTaIn.ReadOnly = true;
		}
	}

	protected override void PHDataBinding()
	{
		base.PHDataBinding();
		CreateDataBinding((Control)(object)txtMa_Kh, "Ma_Kh");
		CreateDataBinding((Control)(object)lblTen_Kh, "Ten_Kh");
		CreateDataBinding((Control)(object)txtDia_chi, "Dia_chi");
		CreateDataBinding((Control)(object)txtMa_so_thue, "Ma_so_thue");
		CreateDataBinding((Control)(object)txtNguoi_Gd, "Nguoi_Gd");
		CreateDataBinding((Control)(object)txtDien_giai, "Dien_Giai");
		CreateDataBinding((Control)(object)txtNgay_Ct, "ngay_ct", "Value");
		CreateDataBinding((Control)(object)txtSo_Ct, "so_ct");
		CreateDataBinding((Control)(object)txtNgay_hd, "ngay_hd", "Value");
		CreateDataBinding((Control)(object)txtSo_hd, "so_hd");
		CreateDataBinding((Control)(object)txtNgay_lct, "ngay_lct", "Value");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)txtMa_Httt, "ma_httt");
		CreateDataBinding((Control)(object)lblTen_httt, "ten_httt");
		CreateDataBinding((Control)(object)txtT_tt, "T_tt", "Value");
		CreateDataBinding((Control)(object)txtT_tt_nt, "T_tt_nt", "Value");
		CreateDataBinding((Control)(object)txtT_Tien0, "T_Tien0", "Value");
		CreateDataBinding((Control)(object)txtT_Tien_nt0, "T_Tien_nt0", "Value");
		CreateDataBinding((Control)(object)txtT_cp_nt, "T_cp_nt", "Value");
		CreateDataBinding((Control)(object)txtT_cp, "T_cp", "Value");
		CreateDataBinding((Control)(object)txtT_Thue, "T_Thue", "Value");
		CreateDataBinding((Control)(object)txtT_thue_Nt, "T_thue_Nt", "Value");
		CreateDataBinding((Control)(object)txtTl_ck_hd, "tl_ck_hd", "Value");
		CreateDataBinding((Control)(object)txtT_ck_nt, "t_ck_nt", "Value");
		CreateDataBinding((Control)(object)txtT_ck, "t_ck", "Value");
		CreateDataBinding((Control)(object)txtT_Tien, "T_Tien", "Value");
		CreateDataBinding((Control)(object)txtT_tien_nt, "T_tien_nt", "Value");
		CreateDataBinding((Control)(object)txtT_So_luong, "T_So_luong", "Value");
		CreateDataBinding((Control)(object)txtTk_pt, "tk_pt");
		CreateDataBinding((Control)(object)ctlTaIn.chkKe_tain, "kht_tain", "Checked");
		CreateDataBinding((Control)(object)chkCk_st, "Ck_st", "Checked");
	}

	protected override void SetPHDefaultValues(DataRow drwPh)
	{
		drwPh["ngay_lct"] = RuntimeHelpers.GetObjectValue(drwPh["ngay_ct"]);
		drwPh["ngay_hd"] = RuntimeHelpers.GetObjectValue(drwPh["ngay_ct"]);
	}

	protected override void SetNextInputGridControlFocus()
	{
		((Control)cmdAdd).Focus();
	}

	protected override void Cancel()
	{
		((DataGridView)dgvDetail).CancelEdit();
		((DataGridView)adgvHach_toan).CancelEdit();
		((DataGridView)adgvChi_phi).CancelEdit();
		((DataGridView)ctlTaIn.adgvTaIn).CancelEdit();
		base.Cancel();
	}

	protected override void VoucherPositionChanged()
	{
		UpdateCPList();
	}

	protected override void SetReportFomularFields(DataRow odrPrintPHRow)
	{
		base.SetReportFomularFields(odrPrintPHRow);
		string text = "";
		string text2 = "";
		text2 = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentPHRowView["tk_pt"]), isNum: false));
		foreach (DataRowView item in CT1Voucher)
		{
			if (!text.Contains(Conversions.ToString(item["tk_vt"])))
			{
				text = Conversions.ToString(Operators.AddObject((object)text, Interaction.IIf(Operators.CompareString(text, string.Empty, false) == 0, RuntimeHelpers.GetObjectValue(item["tk_vt"]), Operators.AddObject((object)",", item["tk_vt"]))));
			}
		}
		base.MyFomularFields.Add("tk_no", text);
		base.MyFomularFields.Add("tk_co", text2);
	}

	protected override bool ChkStatusRight([Optional][DefaultParameterValue("")] ref string retMess)
	{
		return POCommon.POChkStatusRightPO3(Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentPHRow["stt_rec"]), isNum: false)), ref retMess);
	}

	protected override void Refresh_button()
	{
		base.Refresh_button();
		if ((base.ActionMode == Commons.ApplicationMode.VIEW_MODE && base.PHTable != null && base.PHTable.Rows.Count > 0) ? true : false)
		{
			((Control)cmdThanh_toan).Enabled = true;
		}
		else
		{
			((Control)cmdThanh_toan).Enabled = false;
		}
	}

	private void cmdChon_dh_Click(object sender, EventArgs e)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		if (Operators.CompareString(((TextBox)txtMa_Kh).Text.Trim(), "", false) != 0 && base.ActionMode == Commons.ApplicationMode.ADD_MODE && 0 == 0)
		{
			frmPoVchPo3FindPO1 frmPoVchPo3FindPO2 = new frmPoVchPo3FindPO1();
			((Form)frmPoVchPo3FindPO2).Text = ((ButtonBase)cmdChon_dh).Text.Replace("&", "");
			((TextBox)frmPoVchPo3FindPO2.txtMa_Kh).Text = ((TextBox)txtMa_Kh).Text.Trim();
			frmPoVchPo3FindPO2.txtNgay_hd1.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("ngay_ct1"));
			frmPoVchPo3FindPO2.txtNgay_hd2.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("ngay_ct2"));
			((Form)frmPoVchPo3FindPO2).ShowDialog();
			if ((int)((Form)frmPoVchPo3FindPO2).DialogResult == 1)
			{
				LookupDH(frmPoVchPo3FindPO2.sWhereKey);
			}
			((Component)(object)frmPoVchPo3FindPO2).Dispose();
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	protected DataRow _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()
	{
		return base.CurrentPHRow;
	}
}
