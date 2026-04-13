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
public class frmPOVchPO7 : frmVoucher
{
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

	[AccessedThroughProperty("ctlTaIn")]
	private ctlTaIn _ctlTaIn;

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

	[AccessedThroughProperty("txtSo_Hd")]
	private TextBox _txtSo_Hd;

	[AccessedThroughProperty("txtNgay_hd")]
	private AsMaskedTextBox _txtNgay_hd;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("lblMau_hd")]
	private Label _lblMau_hd;

	[AccessedThroughProperty("cboMau_Hd")]
	private ComboBox _cboMau_Hd;

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

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("txtT_Thue_Nk_Nt")]
	private AsTextNumeric _txtT_Thue_Nk_Nt;

	[AccessedThroughProperty("txtT_Thue_nk")]
	private AsTextNumeric _txtT_Thue_nk;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtT_Thue_ttdb_nt")]
	private AsTextNumeric _txtT_Thue_ttdb_nt;

	[AccessedThroughProperty("txtT_Thue_Ttdb")]
	private AsTextNumeric _txtT_Thue_Ttdb;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("txtT_tt_nt_cp")]
	private AsTextNumeric _txtT_tt_nt_cp;

	[AccessedThroughProperty("txtT_thue_nt_cp")]
	private AsTextNumeric _txtT_thue_nt_cp;

	[AccessedThroughProperty("txtT_Tien_Cp_nt_Cp")]
	private AsTextNumeric _txtT_Tien_Cp_nt_Cp;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("cmdGetTaInFromDetail")]
	private Button _cmdGetTaInFromDetail;

	[AccessedThroughProperty("bsTT_PB")]
	private BindingSource _bsTT_PB;

	[AccessedThroughProperty("sCChiPhi")]
	private SplitContainer _sCChiPhi;

	[AccessedThroughProperty("SplitContainer1")]
	private SplitContainer _SplitContainer1;

	[AccessedThroughProperty("lblDia_chi")]
	private Label _lblDia_chi;

	[AccessedThroughProperty("txtDia_chi")]
	private TextBox _txtDia_chi;

	[AccessedThroughProperty("lblMa_so_thue")]
	private Label _lblMa_so_thue;

	[AccessedThroughProperty("txtMa_so_thue")]
	private TextBox _txtMa_so_thue;

	[AccessedThroughProperty("cmdThanh_toan")]
	private Button _cmdThanh_toan;

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

	[AccessedThroughProperty("dgvcTien_cp_nt")]
	private DataGridViewAsTextNumericColumn _dgvcTien_cp_nt;

	[AccessedThroughProperty("dgvcTs_Nk")]
	private DataGridViewAsTextNumericColumn _dgvcTs_Nk;

	[AccessedThroughProperty("dgvcThue_Nk_Nt")]
	private DataGridViewAsTextNumericColumn _dgvcThue_Nk_Nt;

	[AccessedThroughProperty("dgvcTs_ttdb")]
	private DataGridViewAsTextNumericColumn _dgvcTs_ttdb;

	[AccessedThroughProperty("dgvcThue_TtDb_Nt")]
	private DataGridViewAsTextNumericColumn _dgvcThue_TtDb_Nt;

	[AccessedThroughProperty("dgvcTs_gtgt")]
	private DataGridViewAsTextNumericColumn _dgvcTs_gtgt;

	[AccessedThroughProperty("dgvcThue_gtgt_nt")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt_nt;

	[AccessedThroughProperty("dgvcGia0")]
	private DataGridViewAsTextNumericColumn _dgvcGia0;

	[AccessedThroughProperty("dgvcTien0")]
	private DataGridViewAsTextNumericColumn _dgvcTien0;

	[AccessedThroughProperty("dgvcTien_cp")]
	private DataGridViewAsTextNumericColumn _dgvcTien_cp;

	[AccessedThroughProperty("dgvcThue_Nk")]
	private DataGridViewAsTextNumericColumn _dgvcThue_Nk;

	[AccessedThroughProperty("dgvcThue_Ttdb")]
	private DataGridViewAsTextNumericColumn _dgvcThue_Ttdb;

	[AccessedThroughProperty("dgvcThue_gtgt")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt;

	[AccessedThroughProperty("dgvcSo_ct_cp")]
	private DataGridViewTextBoxColumn _dgvcSo_ct_cp;

	[AccessedThroughProperty("dgvcNgay_ct_cp")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcNgay_ct_cp;

	[AccessedThroughProperty("dgvcMa_Ncc_cp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_Ncc_cp;

	[AccessedThroughProperty("dgvcTen_Ncc_cp")]
	private DataGridViewTextBoxColumn _dgvcTen_Ncc_cp;

	[AccessedThroughProperty("dgvcTk_pt")]
	private DataGridViewAsTextBoxColumn _dgvcTk_pt;

	[AccessedThroughProperty("dgvcMa_chiphi")]
	private DataGridViewAsTextBoxColumn _dgvcMa_chiphi;

	[AccessedThroughProperty("dgvcTen_chi_phi")]
	private DataGridViewTextBoxColumn _dgvcTen_chi_phi;

	[AccessedThroughProperty("dgvcTien_cp_nt_cp")]
	private DataGridViewAsTextNumericColumn _dgvcTien_cp_nt_cp;

	[AccessedThroughProperty("dgvcTs_gtgt_cp")]
	private DataGridViewAsTextNumericColumn _dgvcTs_gtgt_cp;

	[AccessedThroughProperty("dgvcThue_Gtgt_nt_cp")]
	private DataGridViewAsTextNumericColumn _dgvcThue_Gtgt_nt_cp;

	[AccessedThroughProperty("dgvcTt_nt_Cp")]
	private DataGridViewAsTextNumericColumn _dgvcTt_nt_Cp;

	[AccessedThroughProperty("dgvcTien_cp_cp")]
	private DataGridViewAsTextNumericColumn _dgvcTien_cp_cp;

	[AccessedThroughProperty("dgvcThue_Gtgt_cp")]
	private DataGridViewAsTextNumericColumn _dgvcThue_Gtgt_cp;

	[AccessedThroughProperty("dgvcTt_Cp")]
	private DataGridViewAsTextNumericColumn _dgvcTt_Cp;

	[AccessedThroughProperty("dgvcMa_Bp_cp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_Bp_cp;

	[AccessedThroughProperty("dgvcMa_phi_cp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_phi_cp;

	[AccessedThroughProperty("dgvcMa_spct_cp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_spct_cp;

	[AccessedThroughProperty("dgvcMa_lo_cp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_lo_cp;

	[AccessedThroughProperty("dgvcTT_PB")]
	private DataGridViewComboBoxColumn _dgvcTT_PB;

	[AccessedThroughProperty("dgvcCp_Nk")]
	private DataGridViewCheckBoxColumn _dgvcCp_Nk;

	[AccessedThroughProperty("dgvcTen_vt_ht")]
	private DataGridViewTextBoxColumn _dgvcTen_vt_ht;

	[AccessedThroughProperty("dgvcTien_nt0_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt0_ht;

	[AccessedThroughProperty("dgvcThue_Nk_Nt_Ht")]
	private DataGridViewAsTextNumericColumn _dgvcThue_Nk_Nt_Ht;

	[AccessedThroughProperty("dgvcThue_Ttdb_nt_Ht")]
	private DataGridViewAsTextNumericColumn _dgvcThue_Ttdb_nt_Ht;

	[AccessedThroughProperty("dgvcCp_Nt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcCp_Nt_ht;

	[AccessedThroughProperty("dgvcTien_nt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt_ht;

	[AccessedThroughProperty("dgvcTien0_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien0_ht;

	[AccessedThroughProperty("dgvcThue_Nk_Ht")]
	private DataGridViewAsTextNumericColumn _dgvcThue_Nk_Ht;

	[AccessedThroughProperty("dgvcThue_Ttdb_Ht")]
	private DataGridViewAsTextNumericColumn _dgvcThue_Ttdb_Ht;

	[AccessedThroughProperty("dgvcCp_ht")]
	private DataGridViewAsTextNumericColumn _dgvcCp_ht;

	[AccessedThroughProperty("dgvcTien_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_ht;

	[AccessedThroughProperty("dgvcTk_vt")]
	private DataGridViewAsTextBoxColumn _dgvcTk_vt;

	[AccessedThroughProperty("dgvcTk_thue_nk")]
	private DataGridViewAsTextBoxColumn _dgvcTk_thue_nk;

	[AccessedThroughProperty("dgvcTk_Thue_ttdb")]
	private DataGridViewAsTextBoxColumn _dgvcTk_Thue_ttdb;

	[AccessedThroughProperty("dgvcTk_co")]
	private DataGridViewAsTextBoxColumn _dgvcTk_co;

	[AccessedThroughProperty("dgvcMa_vt_ht")]
	private DataGridViewTextBoxColumn _dgvcMa_vt_ht;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	[AccessedThroughProperty("DataGridViewTextBoxColumn5")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

	private string f_sMa_Gd_Default;

	private string f_sMa_kh;

	private string f_sGia_header;

	private string f_sTien0_header;

	private string f_sTien_header;

	private string f_sTien0_cp_header;

	private string f_sChi_phi_header;

	private string f_sThue_header;

	private string f_sThue_ttdb_header;

	private string f_sThue_Nk_header;

	private bool hasVATinDetal;

	private bool hasTTDB;

	private bool isMa_HtttChanged;

	private string f_Tk_Thue;

	private string f_Tk_Thue_Nk;

	private string f_Tk_Thue_TtDb;

	private double TyGia_cur;

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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvDetail_CellEnter);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvDetail_CellValueChanged);
			AsInputDGV.SetDependentFieldsWhenCellValueChangedHandler obj = adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellEnter -= val;
				((DataGridView)_adgvDetail).CellValueChanged -= val2;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged -= obj;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellEnter += val;
				((DataGridView)_adgvDetail).CellValueChanged += val2;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged += obj;
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

	protected internal virtual TextBox txtSo_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_Hd = value;
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

	internal virtual Label lblMau_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMau_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMau_hd = value;
		}
	}

	internal virtual ComboBox cboMau_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboMau_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboMau_Hd_SelectedIndexChanged;
			if (_cboMau_Hd != null)
			{
				_cboMau_Hd.SelectedIndexChanged -= eventHandler;
			}
			_cboMau_Hd = value;
			if (_cboMau_Hd != null)
			{
				_cboMau_Hd.SelectedIndexChanged += eventHandler;
			}
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

	internal virtual AsTextNumeric txtT_Thue_Nk_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Thue_Nk_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Thue_Nk_Nt = value;
		}
	}

	internal virtual AsTextNumeric txtT_Thue_nk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Thue_nk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Thue_nk = value;
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

	internal virtual AsTextNumeric txtT_Thue_ttdb_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Thue_ttdb_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Thue_ttdb_nt = value;
		}
	}

	internal virtual AsTextNumeric txtT_Thue_Ttdb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Thue_Ttdb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Thue_Ttdb = value;
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

	internal virtual Label Label13
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

	internal virtual DataGridViewAsTextNumericColumn dgvcTs_Nk
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTs_Nk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTs_Nk = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_Nk_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_Nk_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_Nk_Nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTs_ttdb
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTs_ttdb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTs_ttdb = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_TtDb_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_TtDb_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_TtDb_Nt = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_Nk
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_Nk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_Nk = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_Ttdb
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_Ttdb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_Ttdb = value;
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

	internal virtual DataGridViewTextBoxColumn dgvcSo_ct_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_ct_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_ct_cp = value;
		}
	}

	internal virtual DataGridViewAsMaskedTextBoxColumn dgvcNgay_ct_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcNgay_ct_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcNgay_ct_cp = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_Ncc_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_Ncc_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_Ncc_cp = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_Ncc_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_Ncc_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_Ncc_cp = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_pt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_pt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_pt = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_Gtgt_nt_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_Gtgt_nt_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_Gtgt_nt_cp = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_Bp_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_Bp_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_Bp_cp = value;
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

	internal virtual DataGridViewCheckBoxColumn dgvcCp_Nk
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCp_Nk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCp_Nk = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_Nk_Nt_Ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_Nk_Nt_Ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_Nk_Nt_Ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_Ttdb_nt_Ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_Ttdb_nt_Ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_Ttdb_nt_Ht = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_Nk_Ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_Nk_Ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_Nk_Ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_Ttdb_Ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_Ttdb_Ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_Ttdb_Ht = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_thue_nk
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_thue_nk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_thue_nk = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_Thue_ttdb
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_Thue_ttdb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_Thue_ttdb = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_co
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn3 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn4 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn5 = value;
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

	public frmPOVchPO7()
	{
		__ENCAddToList(this);
		f_sMa_Gd_Default = "1";
		f_sMa_kh = "";
		f_sGia_header = "Gia";
		f_sTien0_header = "Tien";
		f_sTien_header = "Tien";
		f_sTien0_cp_header = "Tien";
		f_sChi_phi_header = "Chi phi";
		f_sThue_header = "VAT";
		f_sThue_ttdb_header = "Thue TTDB";
		f_sThue_Nk_header = "Thue NK";
		hasVATinDetal = true;
		hasTTDB = false;
		isMa_HtttChanged = false;
		f_Tk_Thue = "";
		f_Tk_Thue_Nk = "";
		f_Tk_Thue_TtDb = "";
		TyGia_cur = 0.0;
		InitializeComponent();
	}

	public frmPOVchPO7(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_sMa_Gd_Default = "1";
		f_sMa_kh = "";
		f_sGia_header = "Gia";
		f_sTien0_header = "Tien";
		f_sTien_header = "Tien";
		f_sTien0_cp_header = "Tien";
		f_sChi_phi_header = "Chi phi";
		f_sThue_header = "VAT";
		f_sThue_ttdb_header = "Thue TTDB";
		f_sThue_Nk_header = "Thue NK";
		hasVATinDetal = true;
		hasTTDB = false;
		isMa_HtttChanged = false;
		f_Tk_Thue = "";
		f_Tk_Thue_Nk = "";
		f_Tk_Thue_TtDb = "";
		TyGia_cur = 0.0;
		InitializeComponent();
	}

	public frmPOVchPO7(string MenuID, string Stt_rec)
		: base(MenuID, Stt_rec)
	{
		__ENCAddToList(this);
		f_sMa_Gd_Default = "1";
		f_sMa_kh = "";
		f_sGia_header = "Gia";
		f_sTien0_header = "Tien";
		f_sTien_header = "Tien";
		f_sTien0_cp_header = "Tien";
		f_sChi_phi_header = "Chi phi";
		f_sThue_header = "VAT";
		f_sThue_ttdb_header = "Thue TTDB";
		f_sThue_Nk_header = "Thue NK";
		hasVATinDetal = true;
		hasTTDB = false;
		isMa_HtttChanged = false;
		f_Tk_Thue = "";
		f_Tk_Thue_Nk = "";
		f_Tk_Thue_TtDb = "";
		TyGia_cur = 0.0;
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
		//IL_0052: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected O, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected O, but got Unknown
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected O, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected O, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected O, but got Unknown
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected O, but got Unknown
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected O, but got Unknown
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected O, but got Unknown
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected O, but got Unknown
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected O, but got Unknown
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected O, but got Unknown
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Expected O, but got Unknown
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected O, but got Unknown
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected O, but got Unknown
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected O, but got Unknown
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Expected O, but got Unknown
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Expected O, but got Unknown
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected O, but got Unknown
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected O, but got Unknown
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected O, but got Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected O, but got Unknown
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected O, but got Unknown
		//IL_196e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8e: Expected O, but got Unknown
		//IL_1d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0d: Expected O, but got Unknown
		//IL_1dc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd0: Expected O, but got Unknown
		//IL_2acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad5: Expected O, but got Unknown
		//IL_2c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c49: Expected O, but got Unknown
		//IL_2ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf5: Expected O, but got Unknown
		//IL_2d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d97: Expected O, but got Unknown
		//IL_2e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e58: Expected O, but got Unknown
		//IL_2f52: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f5c: Expected O, but got Unknown
		//IL_3083: Unknown result type (might be due to invalid IL or missing references)
		//IL_308d: Expected O, but got Unknown
		//IL_320e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3218: Expected O, but got Unknown
		//IL_32d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_32db: Expected O, but got Unknown
		//IL_3fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_41a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_41ad: Expected O, but got Unknown
		//IL_42ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_42f7: Expected O, but got Unknown
		//IL_43b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_43ba: Expected O, but got Unknown
		//IL_5424: Unknown result type (might be due to invalid IL or missing references)
		//IL_5545: Unknown result type (might be due to invalid IL or missing references)
		//IL_55f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_5603: Expected O, but got Unknown
		//IL_56ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_56c4: Expected O, but got Unknown
		//IL_57bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_57c5: Expected O, but got Unknown
		//IL_587c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5886: Expected O, but got Unknown
		//IL_5984: Unknown result type (might be due to invalid IL or missing references)
		//IL_598e: Expected O, but got Unknown
		//IL_5a8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a96: Expected O, but got Unknown
		//IL_5b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b9a: Expected O, but got Unknown
		//IL_5c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c50: Expected O, but got Unknown
		//IL_5d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d58: Expected O, but got Unknown
		//IL_5e52: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e5c: Expected O, but got Unknown
		//IL_5f08: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f12: Expected O, but got Unknown
		//IL_6010: Unknown result type (might be due to invalid IL or missing references)
		//IL_601a: Expected O, but got Unknown
		//IL_6118: Unknown result type (might be due to invalid IL or missing references)
		//IL_6122: Expected O, but got Unknown
		//IL_6220: Unknown result type (might be due to invalid IL or missing references)
		//IL_622a: Expected O, but got Unknown
		//IL_6328: Unknown result type (might be due to invalid IL or missing references)
		//IL_6332: Expected O, but got Unknown
		//IL_642d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6437: Expected O, but got Unknown
		//IL_6532: Unknown result type (might be due to invalid IL or missing references)
		//IL_653c: Expected O, but got Unknown
		//IL_663a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6644: Expected O, but got Unknown
		//IL_6742: Unknown result type (might be due to invalid IL or missing references)
		//IL_674c: Expected O, but got Unknown
		//IL_6843: Unknown result type (might be due to invalid IL or missing references)
		//IL_684d: Expected O, but got Unknown
		//IL_68f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_68ff: Expected O, but got Unknown
		//IL_69b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_69bc: Expected O, but got Unknown
		//IL_6a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a7c: Expected O, but got Unknown
		//IL_7043: Unknown result type (might be due to invalid IL or missing references)
		//IL_704d: Expected O, but got Unknown
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
		DataGridViewCellStyle val47 = new DataGridViewCellStyle();
		DataGridViewCellStyle val48 = new DataGridViewCellStyle();
		DataGridViewCellStyle val49 = new DataGridViewCellStyle();
		DataGridViewCellStyle val50 = new DataGridViewCellStyle();
		DataGridViewCellStyle val51 = new DataGridViewCellStyle();
		DataGridViewCellStyle val52 = new DataGridViewCellStyle();
		DataGridViewCellStyle val53 = new DataGridViewCellStyle();
		DataGridViewCellStyle val54 = new DataGridViewCellStyle();
		DataGridViewCellStyle val55 = new DataGridViewCellStyle();
		DataGridViewCellStyle val56 = new DataGridViewCellStyle();
		DataGridViewCellStyle val57 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmPOVchPO7));
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
		dgvcSo_ct_cp = new DataGridViewTextBoxColumn();
		dgvcNgay_ct_cp = new DataGridViewAsMaskedTextBoxColumn();
		dgvcMa_Ncc_cp = new DataGridViewAsTextBoxColumn();
		dgvcTen_Ncc_cp = new DataGridViewTextBoxColumn();
		dgvcTk_pt = new DataGridViewAsTextBoxColumn();
		dgvcMa_chiphi = new DataGridViewAsTextBoxColumn();
		dgvcTen_chi_phi = new DataGridViewTextBoxColumn();
		dgvcTien_cp_nt_cp = new DataGridViewAsTextNumericColumn();
		dgvcTs_gtgt_cp = new DataGridViewAsTextNumericColumn();
		dgvcThue_Gtgt_nt_cp = new DataGridViewAsTextNumericColumn();
		dgvcTt_nt_Cp = new DataGridViewAsTextNumericColumn();
		dgvcTien_cp_cp = new DataGridViewAsTextNumericColumn();
		dgvcThue_Gtgt_cp = new DataGridViewAsTextNumericColumn();
		dgvcTt_Cp = new DataGridViewAsTextNumericColumn();
		dgvcMa_Bp_cp = new DataGridViewAsTextBoxColumn();
		dgvcMa_phi_cp = new DataGridViewAsTextBoxColumn();
		dgvcMa_spct_cp = new DataGridViewAsTextBoxColumn();
		dgvcMa_lo_cp = new DataGridViewAsTextBoxColumn();
		dgvcTT_PB = new DataGridViewComboBoxColumn();
		dgvcCp_Nk = new DataGridViewCheckBoxColumn();
		txtT_Tien_Cp_nt_Cp = new AsTextNumeric();
		cmdPhan_bo = new Button();
		Label13 = new Label();
		Label12 = new Label();
		Label11 = new Label();
		txtT_thue_nt_cp = new AsTextNumeric();
		txtT_tt_nt_cp = new AsTextNumeric();
		adgvDetail = new AsInputDGV();
		dgvcMa_vt = new DataGridViewAsTextBoxColumn();
		dgvcTen_vt = new DataGridViewTextBoxColumn();
		dgvcDvt = new DataGridViewTextBoxColumn();
		dgvcMa_kho = new DataGridViewAsTextBoxColumn();
		dgvcTon = new DataGridViewAsTextNumericColumn();
		dgvcSo_luong = new DataGridViewAsTextNumericColumn();
		dgvcGia_nt0 = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt0 = new DataGridViewAsTextNumericColumn();
		dgvcTien_cp_nt = new DataGridViewAsTextNumericColumn();
		dgvcTs_Nk = new DataGridViewAsTextNumericColumn();
		dgvcThue_Nk_Nt = new DataGridViewAsTextNumericColumn();
		dgvcTs_ttdb = new DataGridViewAsTextNumericColumn();
		dgvcThue_TtDb_Nt = new DataGridViewAsTextNumericColumn();
		dgvcTs_gtgt = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt_nt = new DataGridViewAsTextNumericColumn();
		dgvcGia0 = new DataGridViewAsTextNumericColumn();
		dgvcTien0 = new DataGridViewAsTextNumericColumn();
		dgvcTien_cp = new DataGridViewAsTextNumericColumn();
		dgvcThue_Nk = new DataGridViewAsTextNumericColumn();
		dgvcThue_Ttdb = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt = new DataGridViewAsTextNumericColumn();
		tabHach_toan = new TabPage();
		SplitContainer1 = new SplitContainer();
		adgvHach_toan = new AsInputDGV();
		dgvcTen_vt_ht = new DataGridViewTextBoxColumn();
		dgvcTien_nt0_ht = new DataGridViewAsTextNumericColumn();
		dgvcThue_Nk_Nt_Ht = new DataGridViewAsTextNumericColumn();
		dgvcThue_Ttdb_nt_Ht = new DataGridViewAsTextNumericColumn();
		dgvcCp_Nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien0_ht = new DataGridViewAsTextNumericColumn();
		dgvcThue_Nk_Ht = new DataGridViewAsTextNumericColumn();
		dgvcThue_Ttdb_Ht = new DataGridViewAsTextNumericColumn();
		dgvcCp_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_ht = new DataGridViewAsTextNumericColumn();
		dgvcTk_vt = new DataGridViewAsTextBoxColumn();
		dgvcTk_thue_nk = new DataGridViewAsTextBoxColumn();
		dgvcTk_Thue_ttdb = new DataGridViewAsTextBoxColumn();
		dgvcTk_co = new DataGridViewAsTextBoxColumn();
		dgvcMa_vt_ht = new DataGridViewTextBoxColumn();
		txtTk_pt = new AsTextBox();
		txtTk_thue = new AsTextBox();
		lblTk_thue = new Label();
		lblTk_pt = new Label();
		lblTen_httt = new Label();
		txtMa_Httt = new AsTextBox();
		Label2 = new Label();
		tabTain = new TabPage();
		cmdGetTaInFromDetail = new Button();
		ctlTaIn = new ctlTaIn();
		Label10 = new Label();
		txtT_tien_nt = new AsTextNumeric();
		Label9 = new Label();
		txtT_Tien = new AsTextNumeric();
		txtT_Thue_Nk_Nt = new AsTextNumeric();
		txtT_Thue_nk = new AsTextNumeric();
		Label3 = new Label();
		txtT_Thue_ttdb_nt = new AsTextNumeric();
		txtT_Thue_Ttdb = new AsTextNumeric();
		Label1 = new Label();
		txtT_thue_Nt = new AsTextNumeric();
		txtT_Thue = new AsTextNumeric();
		txtT_tt = new AsTextNumeric();
		txtT_tt_nt = new AsTextNumeric();
		txtT_cp_nt = new AsTextNumeric();
		txtT_Tien_nt0 = new AsTextNumeric();
		txtT_Tien0 = new AsTextNumeric();
		txtT_cp = new AsTextNumeric();
		txtT_So_luong = new AsTextNumeric();
		lblT_Thue = new Label();
		Label5 = new Label();
		Label8 = new Label();
		Label7 = new Label();
		txtNgay_hd = new AsMaskedTextBox();
		Label4 = new Label();
		Label6 = new Label();
		txtSo_Hd = new TextBox();
		lblMau_hd = new Label();
		cboMau_Hd = new ComboBox();
		bsTT_PB = new BindingSource(components);
		lblDia_chi = new Label();
		txtDia_chi = new TextBox();
		lblMa_so_thue = new Label();
		txtMa_so_thue = new TextBox();
		cmdThanh_toan = new Button();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
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
		Button obj2 = cmdPrint;
		location = new Point(73, 460);
		((Control)obj2).Location = location;
		Button obj3 = cmdLast;
		location = new Point(728, 460);
		((Control)obj3).Location = location;
		((Control)cmdLast).TabIndex = 12;
		Button obj4 = cmdNext;
		location = new Point(703, 460);
		((Control)obj4).Location = location;
		((Control)cmdNext).TabIndex = 11;
		Button obj5 = cmdPrevious;
		location = new Point(678, 460);
		((Control)obj5).Location = location;
		((Control)cmdPrevious).TabIndex = 10;
		Button obj6 = cmdFirst;
		location = new Point(653, 460);
		((Control)obj6).Location = location;
		((Control)cmdFirst).TabIndex = 9;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(571, 41);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct;
		Size size = new Size(38, 13);
		((Control)obj8).Size = size;
		lblSo_Ct.Text = "Số ctừ";
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		Label obj9 = lblNgay_Ct;
		location = new Point(571, 18);
		((Control)obj9).Location = location;
		Label obj10 = lblNgay_Ct;
		size = new Size(50, 13);
		((Control)obj10).Size = size;
		lblNgay_Ct.Text = "Ngày ctừ";
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)5;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(664, 14);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay_Ct).TabIndex = 7;
		((Control)gbPH).Controls.Add((Control)(object)lblMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)lblDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)txtDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)lblMau_hd);
		((Control)gbPH).Controls.Add((Control)(object)cboMau_Hd);
		((Control)gbPH).Controls.Add((Control)(object)Label6);
		((Control)gbPH).Controls.Add((Control)(object)txtSo_Hd);
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
		size = new Size(748, 158);
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
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Hd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboMau_Hd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMau_hd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_so_thue, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(572, 460);
		((Control)splitButton).Location = location;
		((Control)cmdSearch).TabIndex = 8;
		((Control)AsTabControl).Controls.Add((Control)(object)tabHach_toan);
		((Control)AsTabControl).Controls.Add((Control)(object)tabChi_phi);
		((Control)AsTabControl).Controls.Add((Control)(object)tabTain);
		AsTabControl asTabControl = AsTabControl;
		location = new Point(1, 158);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(753, 204);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabTain, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabChi_phi, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabHach_toan, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabOptFields, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabDetail, 0);
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj13 = tabDetail;
		size = new Size(745, 175);
		((Control)obj13).Size = size;
		TabPage obj14 = tabOptFields;
		size = new Size(745, 175);
		((Control)obj14).Size = size;
		Button obj15 = cmdCopy;
		location = new Point(353, 460);
		((Control)obj15).Location = location;
		((Control)cmdCopy).TabIndex = 7;
		Button obj16 = cmdDelete;
		location = new Point(283, 460);
		((Control)obj16).Location = location;
		((Control)cmdDelete).TabIndex = 6;
		Button obj17 = cmdEdit;
		location = new Point(213, 460);
		((Control)obj17).Location = location;
		((Control)cmdEdit).TabIndex = 5;
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		TextBox obj18 = txtSo_Ct;
		location = new Point(664, 37);
		((Control)obj18).Location = location;
		((Control)txtSo_Ct).TabIndex = 8;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(116, 37);
		((Control)asTextBox).Location = location;
		txtMa_Kh.LookupCodeName = "MA_NCC";
		txtMa_Kh.LookupWhereCondition = "isNcc=1";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		txtMa_Kh.SD = true;
		AsTextBox asTextBox2 = txtMa_Kh;
		size = new Size(75, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Kh).TabIndex = 1;
		txtMa_Kh.UseAutoCompleteSource = true;
		txtMa_Kh.ValidReturnFieldList = "ten_kh,dia_chi,ma_so_thue,nguoi_gd,tel,gh_no,ma_httt_po";
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj19 = lblTen_Kh;
		location = new Point(197, 41);
		((Control)obj19).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj20 = lblTen_Kh;
		size = new Size(344, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_Kh).TabIndex = 251;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj21 = lblMa_Kh;
		location = new Point(6, 41);
		((Control)obj21).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj22 = lblMa_Kh;
		size = new Size(47, 13);
		((Control)obj22).Size = size;
		((Control)lblMa_Kh).TabIndex = 139;
		lblMa_Kh.Text = "Mã NCC";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblNguoi_Gd.AutoSize = true;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj23 = lblNguoi_Gd;
		location = new Point(6, 87);
		((Control)obj23).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj24 = lblNguoi_Gd;
		size = new Size(56, 13);
		((Control)obj24).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 143;
		lblNguoi_Gd.Text = "Người bán";
		TextBox obj25 = txtDien_giai;
		location = new Point(116, 106);
		((Control)obj25).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj26 = txtDien_giai;
		size = new Size(425, 20);
		((Control)obj26).Size = size;
		((Control)txtDien_giai).TabIndex = 5;
		TextBox obj27 = txtNguoi_Gd;
		location = new Point(116, 83);
		((Control)obj27).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj28 = txtNguoi_Gd;
		size = new Size(145, 20);
		((Control)obj28).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 3;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj29 = lblDien_giai;
		location = new Point(6, 110);
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
		location = new Point(664, 60);
		((Control)asMaskedTextBox2).Location = location;
		((MaskedTextBox)txtNgay_lct).Mask = "##/##/####";
		((Control)txtNgay_lct).Name = "txtNgay_lct";
		((MaskedTextBox)txtNgay_lct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_lct;
		size = new Size(78, 20);
		((Control)asMaskedTextBox3).Size = size;
		((Control)txtNgay_lct).TabIndex = 9;
		((MaskedTextBox)txtNgay_lct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_lct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox4.Value = dateTime;
		lblNgay_Lct.AutoSize = true;
		lblNgay_Lct.ImeMode = (ImeMode)0;
		Label obj31 = lblNgay_Lct;
		location = new Point(571, 64);
		((Control)obj31).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj32 = lblNgay_Lct;
		size = new Size(49, 13);
		((Control)obj32).Size = size;
		((Control)lblNgay_Lct).TabIndex = 234;
		lblNgay_Lct.Text = "Ngày lập";
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(673, 129);
		((Control)asTextNumeric).Location = location;
		txtTy_gia.Mask = "### ###.##";
		((Control)txtTy_gia).Name = "txtTy_gia";
		AsTextNumeric asTextNumeric2 = txtTy_gia;
		size = new Size(69, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTy_gia).TabIndex = 13;
		((TextBox)txtTy_gia).Text = "0.00";
		((TextBox)txtTy_gia).TextAlign = (HorizontalAlignment)1;
		txtTy_gia.Value = 0.0;
		((ComboBox)cboMa_NT).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboMa_NT).Enabled = false;
		((ListControl)cboMa_NT).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_NT;
		location = new Point(623, 129);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(47, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 12;
		lblMa_Nt.AutoSize = true;
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj33 = lblMa_Nt;
		location = new Point(571, 133);
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
		Padding val58 = default(Padding);
		((Padding)(ref val58))._002Ector(3);
		((Control)obj36).Padding = val58;
		TabPage obj37 = tabChi_phi;
		size = new Size(687, 221);
		((Control)obj37).Size = size;
		tabChi_phi.TabIndex = 7;
		tabChi_phi.Text = "Chi phí nhập &khẩu";
		sCChiPhi.Dock = (DockStyle)5;
		sCChiPhi.FixedPanel = (FixedPanel)2;
		SplitContainer obj38 = sCChiPhi;
		location = new Point(3, 3);
		((Control)obj38).Location = location;
		((Control)sCChiPhi).Name = "sCChiPhi";
		sCChiPhi.Orientation = (Orientation)0;
		((Control)sCChiPhi.Panel1).Controls.Add((Control)(object)adgvChi_phi);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)txtT_Tien_Cp_nt_Cp);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)cmdPhan_bo);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)Label13);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)Label12);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)Label11);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)txtT_thue_nt_cp);
		((Control)sCChiPhi.Panel2).Controls.Add((Control)(object)txtT_tt_nt_cp);
		SplitContainer obj39 = sCChiPhi;
		size = new Size(681, 215);
		((Control)obj39).Size = size;
		sCChiPhi.SplitterDistance = 182;
		((Control)sCChiPhi).TabIndex = 286;
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
		((DataGridView)adgvChi_phi).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[20]
		{
			(DataGridViewColumn)dgvcSo_ct_cp,
			dgvcNgay_ct_cp,
			dgvcMa_Ncc_cp,
			(DataGridViewColumn)dgvcTen_Ncc_cp,
			dgvcTk_pt,
			dgvcMa_chiphi,
			(DataGridViewColumn)dgvcTen_chi_phi,
			dgvcTien_cp_nt_cp,
			dgvcTs_gtgt_cp,
			dgvcThue_Gtgt_nt_cp,
			dgvcTt_nt_Cp,
			dgvcTien_cp_cp,
			dgvcThue_Gtgt_cp,
			dgvcTt_Cp,
			dgvcMa_Bp_cp,
			dgvcMa_phi_cp,
			dgvcMa_spct_cp,
			dgvcMa_lo_cp,
			(DataGridViewColumn)dgvcTT_PB,
			(DataGridViewColumn)dgvcCp_Nk
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
		size = new Size(681, 182);
		((Control)asInputDGV2).Size = size;
		((Control)adgvChi_phi).TabIndex = 261;
		((DataGridViewColumn)dgvcSo_ct_cp).DataPropertyName = "so_ct";
		((DataGridViewColumn)dgvcSo_ct_cp).HeaderText = "Số Ct";
		((DataGridViewColumn)dgvcSo_ct_cp).Name = "dgvcSo_ct_cp";
		((DataGridViewColumn)dgvcSo_ct_cp).Width = 70;
		((DataGridViewColumn)dgvcNgay_ct_cp).DataPropertyName = "ngay_ct";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct_cp).DefaultCellStyle = val4;
		dgvcNgay_ct_cp.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct_cp).HeaderText = "Ngày Ct";
		dgvcNgay_ct_cp.Mask = "##/##/####";
		((DataGridViewColumn)dgvcNgay_ct_cp).Name = "dgvcNgay_ct_cp";
		dgvcNgay_ct_cp.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcNgay_ct_cp).Width = 75;
		dgvcMa_Ncc_cp.AutoFill = true;
		dgvcMa_Ncc_cp.AutoLookup = true;
		dgvcMa_Ncc_cp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_Ncc_cp).DataPropertyName = "ma_ncc";
		val5.BackColor = SystemColors.Window;
		((DataGridViewColumn)dgvcMa_Ncc_cp).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcMa_Ncc_cp).HeaderText = "Mã Ncc";
		dgvcMa_Ncc_cp.LookupCodeName = "MA_NCC";
		dgvcMa_Ncc_cp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_Ncc_cp).Name = "dgvcMa_Ncc_cp";
		dgvcMa_Ncc_cp.ReceiverValidFieldList = "ten_ncc";
		dgvcMa_Ncc_cp.SD = true;
		dgvcMa_Ncc_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_Ncc_cp.ValidReturnFieldList = "ten_kh";
		((DataGridViewColumn)dgvcMa_Ncc_cp).Width = 80;
		((DataGridViewColumn)dgvcTen_Ncc_cp).DataPropertyName = "ten_ncc";
		((DataGridViewColumn)dgvcTen_Ncc_cp).HeaderText = "Tên nhà cung cấp";
		((DataGridViewColumn)dgvcTen_Ncc_cp).Name = "dgvcTen_Ncc_cp";
		((DataGridViewColumn)dgvcTen_Ncc_cp).Width = 255;
		dgvcTk_pt.AutoFill = true;
		dgvcTk_pt.AutoLookup = true;
		dgvcTk_pt.AutoValid = true;
		((DataGridViewColumn)dgvcTk_pt).DataPropertyName = "tk_pt";
		val6.BackColor = SystemColors.Window;
		((DataGridViewColumn)dgvcTk_pt).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcTk_pt).HeaderText = "Tk pt";
		dgvcTk_pt.LookupCodeName = "TK";
		dgvcTk_pt.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_pt).Name = "dgvcTk_pt";
		dgvcTk_pt.ReceiverValidFieldList = "";
		dgvcTk_pt.SD = true;
		dgvcTk_pt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_pt.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcTk_pt).Width = 75;
		dgvcMa_chiphi.AutoFill = true;
		dgvcMa_chiphi.AutoLookup = true;
		dgvcMa_chiphi.AutoValid = true;
		((DataGridViewColumn)dgvcMa_chiphi).DataPropertyName = "ma_cp";
		val7.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_chiphi).DefaultCellStyle = val7;
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
		((DataGridViewColumn)dgvcTen_chi_phi).DataPropertyName = "ten_cp";
		((DataGridViewColumn)dgvcTen_chi_phi).HeaderText = "Diễn giải";
		((DataGridViewColumn)dgvcTen_chi_phi).Name = "dgvcTen_chi_phi";
		dgvcTen_chi_phi.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_chi_phi).Width = 170;
		((DataGridViewColumn)dgvcTien_cp_nt_cp).DataPropertyName = "tien_cp_nt";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp_nt_cp).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcTien_cp_nt_cp).HeaderText = "Chi phí";
		dgvcTien_cp_nt_cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp_nt_cp).Name = "dgvcTien_cp_nt_cp";
		dgvcTien_cp_nt_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_cp_nt_cp.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_cp_nt_cp).Width = 80;
		((DataGridViewColumn)dgvcTs_gtgt_cp).DataPropertyName = "ts_gtgt";
		val9.Alignment = (DataGridViewContentAlignment)64;
		val9.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_gtgt_cp).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcTs_gtgt_cp).HeaderText = "%VAT";
		dgvcTs_gtgt_cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_gtgt_cp).Name = "dgvcTs_gtgt_cp";
		dgvcTs_gtgt_cp.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTs_gtgt_cp).Width = 40;
		((DataGridViewColumn)dgvcThue_Gtgt_nt_cp).DataPropertyName = "thue_gtgt_nt";
		val10.Alignment = (DataGridViewContentAlignment)64;
		val10.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Gtgt_nt_cp).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcThue_Gtgt_nt_cp).HeaderText = "VAT";
		dgvcThue_Gtgt_nt_cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Gtgt_nt_cp).Name = "dgvcThue_Gtgt_nt_cp";
		((DataGridViewColumn)dgvcThue_Gtgt_nt_cp).ReadOnly = true;
		dgvcThue_Gtgt_nt_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_Gtgt_nt_cp.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_Gtgt_nt_cp).Width = 60;
		((DataGridViewColumn)dgvcTt_nt_Cp).DataPropertyName = "tt_nt";
		val11.Alignment = (DataGridViewContentAlignment)64;
		val11.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTt_nt_Cp).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcTt_nt_Cp).HeaderText = "Tổng tiền";
		dgvcTt_nt_Cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTt_nt_Cp).Name = "dgvcTt_nt_Cp";
		((DataGridViewColumn)dgvcTt_nt_Cp).ReadOnly = true;
		dgvcTt_nt_Cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTt_nt_Cp.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTt_nt_Cp).Width = 90;
		((DataGridViewColumn)dgvcTien_cp_cp).DataPropertyName = "tien_cp";
		val12.Alignment = (DataGridViewContentAlignment)64;
		val12.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp_cp).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcTien_cp_cp).HeaderText = "Chi phí VNĐ";
		dgvcTien_cp_cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp_cp).Name = "dgvcTien_cp_cp";
		((DataGridViewColumn)dgvcTien_cp_cp).ReadOnly = true;
		dgvcTien_cp_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_cp_cp.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_Gtgt_cp).DataPropertyName = "thue_gtgt";
		val13.Alignment = (DataGridViewContentAlignment)64;
		val13.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Gtgt_cp).DefaultCellStyle = val13;
		((DataGridViewColumn)dgvcThue_Gtgt_cp).HeaderText = "VAT VNĐ";
		dgvcThue_Gtgt_cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Gtgt_cp).Name = "dgvcThue_Gtgt_cp";
		((DataGridViewColumn)dgvcThue_Gtgt_cp).ReadOnly = true;
		dgvcThue_Gtgt_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_Gtgt_cp.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_Gtgt_cp).Width = 70;
		((DataGridViewColumn)dgvcTt_Cp).DataPropertyName = "tt";
		val14.Alignment = (DataGridViewContentAlignment)64;
		val14.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTt_Cp).DefaultCellStyle = val14;
		((DataGridViewColumn)dgvcTt_Cp).HeaderText = "Tổng tiền VNĐ";
		dgvcTt_Cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTt_Cp).Name = "dgvcTt_Cp";
		((DataGridViewColumn)dgvcTt_Cp).ReadOnly = true;
		dgvcTt_Cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTt_Cp.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTt_Cp).Width = 90;
		dgvcMa_Bp_cp.AutoFill = true;
		dgvcMa_Bp_cp.AutoLookup = true;
		dgvcMa_Bp_cp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_Bp_cp).DataPropertyName = "ma_bp";
		val15.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_Bp_cp).DefaultCellStyle = val15;
		((DataGridViewColumn)dgvcMa_Bp_cp).HeaderText = "Bộ phận";
		dgvcMa_Bp_cp.LookupCodeName = "ma_bp";
		dgvcMa_Bp_cp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_Bp_cp).Name = "dgvcMa_Bp_cp";
		dgvcMa_Bp_cp.ReceiverValidFieldList = "";
		((DataGridViewColumn)dgvcMa_Bp_cp).Resizable = (DataGridViewTriState)1;
		dgvcMa_Bp_cp.SD = true;
		dgvcMa_Bp_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_Bp_cp.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcMa_Bp_cp).Width = 70;
		dgvcMa_phi_cp.AutoFill = true;
		dgvcMa_phi_cp.AutoLookup = true;
		dgvcMa_phi_cp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_phi_cp).DataPropertyName = "ma_phi";
		val16.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_phi_cp).DefaultCellStyle = val16;
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
		val17.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_spct_cp).DefaultCellStyle = val17;
		((DataGridViewColumn)dgvcMa_spct_cp).HeaderText = "Spct";
		dgvcMa_spct_cp.LookupCodeName = "ma_spct";
		dgvcMa_spct_cp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_spct_cp).Name = "dgvcMa_spct_cp";
		dgvcMa_spct_cp.ReceiverValidFieldList = "";
		((DataGridViewColumn)dgvcMa_spct_cp).Resizable = (DataGridViewTriState)1;
		dgvcMa_spct_cp.SD = true;
		dgvcMa_spct_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_spct_cp.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcMa_spct_cp).Width = 60;
		dgvcMa_lo_cp.AutoFill = true;
		dgvcMa_lo_cp.AutoLookup = true;
		dgvcMa_lo_cp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_lo_cp).DataPropertyName = "ma_lo";
		val18.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_lo_cp).DefaultCellStyle = val18;
		((DataGridViewColumn)dgvcMa_lo_cp).HeaderText = "Lô";
		dgvcMa_lo_cp.LookupCodeName = "ma_lo";
		dgvcMa_lo_cp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_lo_cp).Name = "dgvcMa_lo_cp";
		dgvcMa_lo_cp.ReceiverValidFieldList = "";
		dgvcMa_lo_cp.SD = true;
		dgvcMa_lo_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_lo_cp.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcMa_lo_cp).Width = 60;
		((DataGridViewColumn)dgvcTT_PB).DataPropertyName = "TT_PB";
		((DataGridViewColumn)dgvcTT_PB).HeaderText = "Tiêu thức phân bổ";
		((DataGridViewColumn)dgvcTT_PB).Name = "dgvcTT_PB";
		((DataGridViewColumn)dgvcTT_PB).Width = 110;
		((DataGridViewColumn)dgvcCp_Nk).HeaderText = "CPNK";
		((DataGridViewColumn)dgvcCp_Nk).Name = "dgvcCp_Nk";
		((Control)txtT_Tien_Cp_nt_Cp).Anchor = (AnchorStyles)6;
		txtT_Tien_Cp_nt_Cp.DecimalSymbol = ".";
		((Control)txtT_Tien_Cp_nt_Cp).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtT_Tien_Cp_nt_Cp;
		location = new Point(83, 5);
		((Control)asTextNumeric3).Location = location;
		txtT_Tien_Cp_nt_Cp.Mask = "### ### ### ###";
		((Control)txtT_Tien_Cp_nt_Cp).Name = "txtT_Tien_Cp_nt_Cp";
		((TextBoxBase)txtT_Tien_Cp_nt_Cp).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtT_Tien_Cp_nt_Cp;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		txtT_Tien_Cp_nt_Cp.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_Tien_Cp_nt_Cp).TabIndex = 281;
		((Control)txtT_Tien_Cp_nt_Cp).TabStop = false;
		((TextBox)txtT_Tien_Cp_nt_Cp).Text = "0";
		((TextBox)txtT_Tien_Cp_nt_Cp).TextAlign = (HorizontalAlignment)1;
		txtT_Tien_Cp_nt_Cp.Value = 0.0;
		((Control)cmdPhan_bo).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdPhan_bo).FlatStyle = (FlatStyle)1;
		Button obj40 = cmdPhan_bo;
		location = new Point(587, 5);
		((Control)obj40).Location = location;
		((Control)cmdPhan_bo).Name = "cmdPhan_bo";
		Button obj41 = cmdPhan_bo;
		size = new Size(91, 22);
		((Control)obj41).Size = size;
		((Control)cmdPhan_bo).TabIndex = 260;
		((ButtonBase)cmdPhan_bo).Text = "Phân &bổ";
		((Control)Label13).Anchor = (AnchorStyles)6;
		((Control)Label13).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label13.ImeMode = (ImeMode)0;
		Label label = Label13;
		location = new Point(4, 9);
		((Control)label).Location = location;
		((Control)Label13).Name = "Label13";
		Label label2 = Label13;
		size = new Size(76, 13);
		((Control)label2).Size = size;
		((Control)Label13).TabIndex = 280;
		Label13.Text = "Chi phí";
		Label13.TextAlign = (ContentAlignment)16;
		((Control)Label12).Anchor = (AnchorStyles)6;
		((Control)Label12).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label12.ImeMode = (ImeMode)0;
		Label label3 = Label12;
		location = new Point(189, 9);
		((Control)label3).Location = location;
		((Control)Label12).Name = "Label12";
		Label label4 = Label12;
		size = new Size(65, 13);
		((Control)label4).Size = size;
		((Control)Label12).TabIndex = 284;
		Label12.Text = "Thuế GTGT";
		((Control)Label11).Anchor = (AnchorStyles)6;
		((Control)Label11).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label11.ImeMode = (ImeMode)0;
		Label label5 = Label11;
		location = new Point(391, 9);
		((Control)label5).Location = location;
		((Control)Label11).Name = "Label11";
		Label label6 = Label11;
		size = new Size(78, 13);
		((Control)label6).Size = size;
		((Control)Label11).TabIndex = 285;
		Label11.Text = "Thanh toán";
		Label11.TextAlign = (ContentAlignment)16;
		((Control)txtT_thue_nt_cp).Anchor = (AnchorStyles)6;
		txtT_thue_nt_cp.DecimalSymbol = ".";
		((Control)txtT_thue_nt_cp).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric5 = txtT_thue_nt_cp;
		location = new Point(260, 6);
		((Control)asTextNumeric5).Location = location;
		txtT_thue_nt_cp.Mask = "### ### ### ###";
		((Control)txtT_thue_nt_cp).Name = "txtT_thue_nt_cp";
		((TextBoxBase)txtT_thue_nt_cp).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtT_thue_nt_cp;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		txtT_thue_nt_cp.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_thue_nt_cp).TabIndex = 282;
		((Control)txtT_thue_nt_cp).TabStop = false;
		((TextBox)txtT_thue_nt_cp).Text = "0";
		((TextBox)txtT_thue_nt_cp).TextAlign = (HorizontalAlignment)1;
		txtT_thue_nt_cp.Value = 0.0;
		((Control)txtT_tt_nt_cp).Anchor = (AnchorStyles)6;
		txtT_tt_nt_cp.DecimalSymbol = ".";
		((Control)txtT_tt_nt_cp).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric7 = txtT_tt_nt_cp;
		location = new Point(499, 6);
		((Control)asTextNumeric7).Location = location;
		txtT_tt_nt_cp.Mask = "### ### ### ###";
		((Control)txtT_tt_nt_cp).Name = "txtT_tt_nt_cp";
		((TextBoxBase)txtT_tt_nt_cp).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_tt_nt_cp;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_tt_nt_cp.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tt_nt_cp).TabIndex = 283;
		((Control)txtT_tt_nt_cp).TabStop = false;
		((TextBox)txtT_tt_nt_cp).Text = "0";
		((TextBox)txtT_tt_nt_cp).TextAlign = (HorizontalAlignment)1;
		txtT_tt_nt_cp.Value = 0.0;
		((DataGridView)adgvDetail).AllowUserToAddRows = false;
		((DataGridView)adgvDetail).AllowUserToDeleteRows = false;
		((DataGridView)adgvDetail).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvDetail).BorderStyle = (BorderStyle)2;
		val19.Alignment = (DataGridViewContentAlignment)16;
		val19.BackColor = SystemColors.Control;
		val19.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val19.ForeColor = SystemColors.WindowText;
		val19.SelectionBackColor = SystemColors.Highlight;
		val19.SelectionForeColor = SystemColors.HighlightText;
		val19.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail).ColumnHeadersDefaultCellStyle = val19;
		((DataGridView)adgvDetail).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[21]
		{
			dgvcMa_vt,
			(DataGridViewColumn)dgvcTen_vt,
			(DataGridViewColumn)dgvcDvt,
			dgvcMa_kho,
			dgvcTon,
			dgvcSo_luong,
			dgvcGia_nt0,
			dgvcTien_nt0,
			dgvcTien_cp_nt,
			dgvcTs_Nk,
			dgvcThue_Nk_Nt,
			dgvcTs_ttdb,
			dgvcThue_TtDb_Nt,
			dgvcTs_gtgt,
			dgvcThue_gtgt_nt,
			dgvcGia0,
			dgvcTien0,
			dgvcTien_cp,
			dgvcThue_Nk,
			dgvcThue_Ttdb,
			dgvcThue_gtgt
		});
		val20.Alignment = (DataGridViewContentAlignment)16;
		val20.BackColor = SystemColors.Window;
		val20.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val20.ForeColor = SystemColors.ControlText;
		val20.SelectionBackColor = SystemColors.Highlight;
		val20.SelectionForeColor = SystemColors.HighlightText;
		val20.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvDetail).DefaultCellStyle = val20;
		((Control)adgvDetail).Dock = (DockStyle)5;
		((DataGridView)adgvDetail).GridColor = SystemColors.Control;
		adgvDetail.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV3 = adgvDetail;
		location = new Point(3, 3);
		((Control)asInputDGV3).Location = location;
		((Control)adgvDetail).Name = "adgvDetail";
		val21.Alignment = (DataGridViewContentAlignment)32;
		val21.BackColor = SystemColors.Control;
		val21.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val21.ForeColor = SystemColors.WindowText;
		val21.SelectionBackColor = SystemColors.Highlight;
		val21.SelectionForeColor = SystemColors.HighlightText;
		val21.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail).RowHeadersDefaultCellStyle = val21;
		((DataGridView)adgvDetail).RowHeadersWidth = 35;
		((DataGridView)adgvDetail).RowTemplate.Height = 20;
		AsInputDGV asInputDGV4 = adgvDetail;
		size = new Size(739, 169);
		((Control)asInputDGV4).Size = size;
		((Control)adgvDetail).TabIndex = 1;
		dgvcMa_vt.AutoFill = true;
		dgvcMa_vt.AutoLookup = true;
		dgvcMa_vt.AutoValid = true;
		((DataGridViewColumn)dgvcMa_vt).DataPropertyName = "ma_vt";
		val22.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_vt).DefaultCellStyle = val22;
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
		val23.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_kho).DefaultCellStyle = val23;
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
		val24.Alignment = (DataGridViewContentAlignment)64;
		val24.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTon).DefaultCellStyle = val24;
		((DataGridViewColumn)dgvcTon).HeaderText = "Tồn";
		dgvcTon.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTon).Name = "dgvcTon";
		((DataGridViewColumn)dgvcTon).ReadOnly = true;
		dgvcTon.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTon.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcTon).Width = 60;
		((DataGridViewColumn)dgvcSo_luong).DataPropertyName = "so_luong";
		val25.Alignment = (DataGridViewContentAlignment)64;
		val25.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).DefaultCellStyle = val25;
		((DataGridViewColumn)dgvcSo_luong).HeaderText = "Số lượng";
		dgvcSo_luong.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).Name = "dgvcSo_luong";
		dgvcSo_luong.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSo_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcSo_luong).Width = 70;
		((DataGridViewColumn)dgvcGia_nt0).DataPropertyName = "gia_nt0";
		val26.Alignment = (DataGridViewContentAlignment)64;
		val26.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt0).DefaultCellStyle = val26;
		((DataGridViewColumn)dgvcGia_nt0).HeaderText = "Đơn giá";
		dgvcGia_nt0.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt0).Name = "dgvcGia_nt0";
		dgvcGia_nt0.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia_nt0.SpecialType = Commons.NumericSpecialType.FCPrice;
		((DataGridViewColumn)dgvcGia_nt0).Width = 85;
		((DataGridViewColumn)dgvcTien_nt0).DataPropertyName = "tien_nt0";
		val27.Alignment = (DataGridViewContentAlignment)64;
		val27.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt0).DefaultCellStyle = val27;
		((DataGridViewColumn)dgvcTien_nt0).HeaderText = "Thành tiền";
		dgvcTien_nt0.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt0).Name = "dgvcTien_nt0";
		((DataGridViewColumn)dgvcTien_nt0).ReadOnly = true;
		dgvcTien_nt0.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt0.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt0).Width = 90;
		((DataGridViewColumn)dgvcTien_cp_nt).DataPropertyName = "cp_nt";
		val28.Alignment = (DataGridViewContentAlignment)64;
		val28.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp_nt).DefaultCellStyle = val28;
		((DataGridViewColumn)dgvcTien_cp_nt).HeaderText = "Chi phí";
		dgvcTien_cp_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp_nt).Name = "dgvcTien_cp_nt";
		dgvcTien_cp_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_cp_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_cp_nt).Width = 86;
		((DataGridViewColumn)dgvcTs_Nk).DataPropertyName = "ts_nk";
		val29.Alignment = (DataGridViewContentAlignment)64;
		val29.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_Nk).DefaultCellStyle = val29;
		((DataGridViewColumn)dgvcTs_Nk).HeaderText = "%NK";
		dgvcTs_Nk.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_Nk).Name = "dgvcTs_Nk";
		dgvcTs_Nk.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTs_Nk).Width = 50;
		((DataGridViewColumn)dgvcThue_Nk_Nt).DataPropertyName = "thue_nk_nt";
		val30.Alignment = (DataGridViewContentAlignment)64;
		val30.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Nk_Nt).DefaultCellStyle = val30;
		((DataGridViewColumn)dgvcThue_Nk_Nt).HeaderText = "Thuế NK";
		dgvcThue_Nk_Nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Nk_Nt).Name = "dgvcThue_Nk_Nt";
		dgvcThue_Nk_Nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_Nk_Nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_Nk_Nt).Width = 82;
		((DataGridViewColumn)dgvcTs_ttdb).DataPropertyName = "ts_ttdb";
		val31.Alignment = (DataGridViewContentAlignment)64;
		val31.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_ttdb).DefaultCellStyle = val31;
		((DataGridViewColumn)dgvcTs_ttdb).HeaderText = "%TTĐB";
		dgvcTs_ttdb.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_ttdb).Name = "dgvcTs_ttdb";
		dgvcTs_ttdb.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTs_ttdb).Width = 50;
		((DataGridViewColumn)dgvcThue_TtDb_Nt).DataPropertyName = "thue_ttdb_nt";
		val32.Alignment = (DataGridViewContentAlignment)64;
		val32.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_TtDb_Nt).DefaultCellStyle = val32;
		((DataGridViewColumn)dgvcThue_TtDb_Nt).HeaderText = "Thuế TTĐB";
		dgvcThue_TtDb_Nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_TtDb_Nt).Name = "dgvcThue_TtDb_Nt";
		dgvcThue_TtDb_Nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_TtDb_Nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTs_gtgt).DataPropertyName = "ts_gtgt";
		val33.Alignment = (DataGridViewContentAlignment)64;
		val33.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_gtgt).DefaultCellStyle = val33;
		((DataGridViewColumn)dgvcTs_gtgt).HeaderText = "%VAT";
		dgvcTs_gtgt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_gtgt).Name = "dgvcTs_gtgt";
		dgvcTs_gtgt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTs_gtgt).Width = 50;
		((DataGridViewColumn)dgvcThue_gtgt_nt).DataPropertyName = "thue_gtgt_nt";
		val34.Alignment = (DataGridViewContentAlignment)64;
		val34.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).DefaultCellStyle = val34;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = "VAT";
		dgvcThue_gtgt_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).Name = "dgvcThue_gtgt_nt";
		dgvcThue_gtgt_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_gtgt_nt).Width = 80;
		((DataGridViewColumn)dgvcGia0).DataPropertyName = "gia0";
		val35.Alignment = (DataGridViewContentAlignment)64;
		val35.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia0).DefaultCellStyle = val35;
		((DataGridViewColumn)dgvcGia0).HeaderText = "Đơn giá VND";
		dgvcGia0.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia0).Name = "dgvcGia0";
		((DataGridViewColumn)dgvcGia0).ReadOnly = true;
		dgvcGia0.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia0.SpecialType = Commons.NumericSpecialType.ACPrice;
		((DataGridViewColumn)dgvcGia0).Width = 80;
		((DataGridViewColumn)dgvcTien0).DataPropertyName = "tien0";
		val36.Alignment = (DataGridViewContentAlignment)64;
		val36.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien0).DefaultCellStyle = val36;
		((DataGridViewColumn)dgvcTien0).HeaderText = "Tiền VND";
		dgvcTien0.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien0).Name = "dgvcTien0";
		((DataGridViewColumn)dgvcTien0).ReadOnly = true;
		dgvcTien0.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien0.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien0).Width = 90;
		((DataGridViewColumn)dgvcTien_cp).DataPropertyName = "cp";
		val37.Alignment = (DataGridViewContentAlignment)64;
		val37.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp).DefaultCellStyle = val37;
		((DataGridViewColumn)dgvcTien_cp).HeaderText = "CP VND";
		dgvcTien_cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_cp).Name = "dgvcTien_cp";
		dgvcTien_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_cp.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_cp).Width = 80;
		((DataGridViewColumn)dgvcThue_Nk).DataPropertyName = "thue_nk";
		val38.Alignment = (DataGridViewContentAlignment)64;
		val38.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Nk).DefaultCellStyle = val38;
		((DataGridViewColumn)dgvcThue_Nk).HeaderText = "Thuế NK VND";
		dgvcThue_Nk.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Nk).Name = "dgvcThue_Nk";
		dgvcThue_Nk.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_Nk.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_Nk).Width = 90;
		((DataGridViewColumn)dgvcThue_Ttdb).DataPropertyName = "thue_ttdb";
		val39.Alignment = (DataGridViewContentAlignment)64;
		val39.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Ttdb).DefaultCellStyle = val39;
		((DataGridViewColumn)dgvcThue_Ttdb).HeaderText = "Thuế TTĐB VND";
		dgvcThue_Ttdb.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Ttdb).Name = "dgvcThue_Ttdb";
		dgvcThue_Ttdb.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_Ttdb.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_gtgt).DataPropertyName = "thue_gtgt";
		val40.Alignment = (DataGridViewContentAlignment)64;
		val40.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt).DefaultCellStyle = val40;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = "VAT VND";
		dgvcThue_gtgt.Mask = "### ### ### ###.##";
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
		((Padding)(ref val58))._002Ector(3);
		((Control)obj43).Padding = val58;
		TabPage obj44 = tabHach_toan;
		size = new Size(687, 221);
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
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)txtTk_thue);
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)lblTk_thue);
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)lblTk_pt);
		SplitContainer splitContainer2 = SplitContainer1;
		size = new Size(681, 215);
		((Control)splitContainer2).Size = size;
		SplitContainer1.SplitterDistance = 185;
		((Control)SplitContainer1).TabIndex = 0;
		((DataGridView)adgvHach_toan).AllowUserToAddRows = false;
		((DataGridView)adgvHach_toan).AllowUserToDeleteRows = false;
		((DataGridView)adgvHach_toan).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvHach_toan).BorderStyle = (BorderStyle)2;
		val41.Alignment = (DataGridViewContentAlignment)16;
		val41.BackColor = SystemColors.Control;
		val41.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val41.ForeColor = SystemColors.WindowText;
		val41.SelectionBackColor = SystemColors.Highlight;
		val41.SelectionForeColor = SystemColors.HighlightText;
		val41.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).ColumnHeadersDefaultCellStyle = val41;
		((DataGridView)adgvHach_toan).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvHach_toan).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[16]
		{
			(DataGridViewColumn)dgvcTen_vt_ht,
			dgvcTien_nt0_ht,
			dgvcThue_Nk_Nt_Ht,
			dgvcThue_Ttdb_nt_Ht,
			dgvcCp_Nt_ht,
			dgvcTien_nt_ht,
			dgvcTien0_ht,
			dgvcThue_Nk_Ht,
			dgvcThue_Ttdb_Ht,
			dgvcCp_ht,
			dgvcTien_ht,
			dgvcTk_vt,
			dgvcTk_thue_nk,
			dgvcTk_Thue_ttdb,
			dgvcTk_co,
			(DataGridViewColumn)dgvcMa_vt_ht
		});
		val42.Alignment = (DataGridViewContentAlignment)16;
		val42.BackColor = SystemColors.Window;
		val42.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val42.ForeColor = SystemColors.ControlText;
		val42.SelectionBackColor = SystemColors.Highlight;
		val42.SelectionForeColor = SystemColors.HighlightText;
		val42.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvHach_toan).DefaultCellStyle = val42;
		((Control)adgvHach_toan).Dock = (DockStyle)5;
		((DataGridView)adgvHach_toan).GridColor = SystemColors.Control;
		adgvHach_toan.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV5 = adgvHach_toan;
		location = new Point(0, 0);
		((Control)asInputDGV5).Location = location;
		((Control)adgvHach_toan).Name = "adgvHach_toan";
		val43.Alignment = (DataGridViewContentAlignment)32;
		val43.BackColor = SystemColors.Control;
		val43.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val43.ForeColor = SystemColors.WindowText;
		val43.SelectionBackColor = SystemColors.Highlight;
		val43.SelectionForeColor = SystemColors.HighlightText;
		val43.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).RowHeadersDefaultCellStyle = val43;
		((DataGridView)adgvHach_toan).RowHeadersWidth = 35;
		((DataGridView)adgvHach_toan).RowTemplate.Height = 20;
		AsInputDGV asInputDGV6 = adgvHach_toan;
		size = new Size(681, 185);
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
		val44.Alignment = (DataGridViewContentAlignment)64;
		val44.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt0_ht).DefaultCellStyle = val44;
		((DataGridViewColumn)dgvcTien_nt0_ht).HeaderText = "Tiền hàng";
		dgvcTien_nt0_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt0_ht).Name = "dgvcTien_nt0_ht";
		((DataGridViewColumn)dgvcTien_nt0_ht).ReadOnly = true;
		dgvcTien_nt0_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt0_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt0_ht).Width = 95;
		((DataGridViewColumn)dgvcThue_Nk_Nt_Ht).DataPropertyName = "thue_nk_nt";
		val45.Alignment = (DataGridViewContentAlignment)64;
		val45.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Nk_Nt_Ht).DefaultCellStyle = val45;
		((DataGridViewColumn)dgvcThue_Nk_Nt_Ht).HeaderText = "Thuế NK";
		dgvcThue_Nk_Nt_Ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Nk_Nt_Ht).Name = "dgvcThue_Nk_Nt_Ht";
		((DataGridViewColumn)dgvcThue_Nk_Nt_Ht).ReadOnly = true;
		((DataGridViewColumn)dgvcThue_Nk_Nt_Ht).Resizable = (DataGridViewTriState)1;
		dgvcThue_Nk_Nt_Ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_Nk_Nt_Ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_Ttdb_nt_Ht).DataPropertyName = "thue_ttdb_nt";
		val46.Alignment = (DataGridViewContentAlignment)64;
		val46.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Ttdb_nt_Ht).DefaultCellStyle = val46;
		((DataGridViewColumn)dgvcThue_Ttdb_nt_Ht).HeaderText = "Thuế TTĐB";
		dgvcThue_Ttdb_nt_Ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Ttdb_nt_Ht).Name = "dgvcThue_Ttdb_nt_Ht";
		((DataGridViewColumn)dgvcThue_Ttdb_nt_Ht).ReadOnly = true;
		((DataGridViewColumn)dgvcThue_Ttdb_nt_Ht).Resizable = (DataGridViewTriState)1;
		dgvcThue_Ttdb_nt_Ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_Ttdb_nt_Ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_Ttdb_nt_Ht).Width = 120;
		((DataGridViewColumn)dgvcCp_Nt_ht).DataPropertyName = "cp_nt";
		val47.Alignment = (DataGridViewContentAlignment)64;
		val47.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_Nt_ht).DefaultCellStyle = val47;
		((DataGridViewColumn)dgvcCp_Nt_ht).HeaderText = "Chi phí";
		dgvcCp_Nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_Nt_ht).Name = "dgvcCp_Nt_ht";
		((DataGridViewColumn)dgvcCp_Nt_ht).ReadOnly = true;
		dgvcCp_Nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcCp_Nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcCp_Nt_ht).Width = 80;
		((DataGridViewColumn)dgvcTien_nt_ht).DataPropertyName = "tien_nt";
		val48.Alignment = (DataGridViewContentAlignment)64;
		val48.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).DefaultCellStyle = val48;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = "Tổng tiền";
		dgvcTien_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).Name = "dgvcTien_nt_ht";
		((DataGridViewColumn)dgvcTien_nt_ht).ReadOnly = true;
		dgvcTien_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt_ht).Width = 95;
		((DataGridViewColumn)dgvcTien0_ht).DataPropertyName = "tien0";
		val49.Alignment = (DataGridViewContentAlignment)64;
		val49.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien0_ht).DefaultCellStyle = val49;
		((DataGridViewColumn)dgvcTien0_ht).HeaderText = "Tiền hàng VNĐ";
		dgvcTien0_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien0_ht).Name = "dgvcTien0_ht";
		((DataGridViewColumn)dgvcTien0_ht).ReadOnly = true;
		dgvcTien0_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien0_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien0_ht).Width = 120;
		((DataGridViewColumn)dgvcThue_Nk_Ht).DataPropertyName = "thue_nk";
		val50.Alignment = (DataGridViewContentAlignment)64;
		val50.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Nk_Ht).DefaultCellStyle = val50;
		((DataGridViewColumn)dgvcThue_Nk_Ht).HeaderText = "Thuế Nk VNĐ";
		dgvcThue_Nk_Ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Nk_Ht).Name = "dgvcThue_Nk_Ht";
		((DataGridViewColumn)dgvcThue_Nk_Ht).ReadOnly = true;
		((DataGridViewColumn)dgvcThue_Nk_Ht).Resizable = (DataGridViewTriState)1;
		dgvcThue_Nk_Ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_Nk_Ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_Ttdb_Ht).DataPropertyName = "thue_ttdb";
		val51.Alignment = (DataGridViewContentAlignment)64;
		val51.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Ttdb_Ht).DefaultCellStyle = val51;
		((DataGridViewColumn)dgvcThue_Ttdb_Ht).HeaderText = "Thuế TTĐB VNĐ";
		dgvcThue_Ttdb_Ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Ttdb_Ht).Name = "dgvcThue_Ttdb_Ht";
		((DataGridViewColumn)dgvcThue_Ttdb_Ht).ReadOnly = true;
		((DataGridViewColumn)dgvcThue_Ttdb_Ht).Resizable = (DataGridViewTriState)1;
		dgvcThue_Ttdb_Ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_Ttdb_Ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_Ttdb_Ht).Width = 120;
		((DataGridViewColumn)dgvcCp_ht).DataPropertyName = "cp";
		val52.Alignment = (DataGridViewContentAlignment)64;
		val52.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_ht).DefaultCellStyle = val52;
		((DataGridViewColumn)dgvcCp_ht).HeaderText = "CP VNĐ";
		dgvcCp_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_ht).Name = "dgvcCp_ht";
		((DataGridViewColumn)dgvcCp_ht).ReadOnly = true;
		dgvcCp_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcCp_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_ht).DataPropertyName = "tien";
		val53.Alignment = (DataGridViewContentAlignment)64;
		val53.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcTien_ht).DefaultCellStyle = val53;
		((DataGridViewColumn)dgvcTien_ht).HeaderText = "Tổng tiền VNĐ";
		dgvcTien_ht.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcTien_ht).Name = "dgvcTien_ht";
		((DataGridViewColumn)dgvcTien_ht).ReadOnly = true;
		dgvcTien_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		dgvcTk_vt.AutoFill = true;
		dgvcTk_vt.AutoLookup = true;
		dgvcTk_vt.AutoValid = true;
		((DataGridViewColumn)dgvcTk_vt).DataPropertyName = "tk_vt";
		val54.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_vt).DefaultCellStyle = val54;
		((DataGridViewColumn)dgvcTk_vt).HeaderText = "TK kho";
		dgvcTk_vt.LookupCodeName = "TK";
		dgvcTk_vt.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_vt).Name = "dgvcTk_vt";
		dgvcTk_vt.ReceiverValidFieldList = "ten_tk_vt";
		dgvcTk_vt.SD = true;
		dgvcTk_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_vt.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_vt).Width = 65;
		dgvcTk_thue_nk.AutoFill = true;
		dgvcTk_thue_nk.AutoLookup = true;
		dgvcTk_thue_nk.AutoValid = true;
		((DataGridViewColumn)dgvcTk_thue_nk).DataPropertyName = "tk_thue_nk";
		val55.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_thue_nk).DefaultCellStyle = val55;
		((DataGridViewColumn)dgvcTk_thue_nk).HeaderText = "TK thuế NK";
		dgvcTk_thue_nk.LookupCodeName = "TK";
		dgvcTk_thue_nk.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_thue_nk).Name = "dgvcTk_thue_nk";
		dgvcTk_thue_nk.ReceiverValidFieldList = "";
		((DataGridViewColumn)dgvcTk_thue_nk).Resizable = (DataGridViewTriState)1;
		dgvcTk_thue_nk.SD = true;
		dgvcTk_thue_nk.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_thue_nk.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcTk_thue_nk).Width = 90;
		dgvcTk_Thue_ttdb.AutoFill = true;
		dgvcTk_Thue_ttdb.AutoLookup = true;
		dgvcTk_Thue_ttdb.AutoValid = true;
		((DataGridViewColumn)dgvcTk_Thue_ttdb).DataPropertyName = "tk_thue_ttdb";
		val56.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_Thue_ttdb).DefaultCellStyle = val56;
		((DataGridViewColumn)dgvcTk_Thue_ttdb).HeaderText = "TK thuế TTDB";
		dgvcTk_Thue_ttdb.LookupCodeName = "TK";
		dgvcTk_Thue_ttdb.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_Thue_ttdb).Name = "dgvcTk_Thue_ttdb";
		dgvcTk_Thue_ttdb.ReceiverValidFieldList = "";
		((DataGridViewColumn)dgvcTk_Thue_ttdb).Resizable = (DataGridViewTriState)1;
		dgvcTk_Thue_ttdb.SD = true;
		dgvcTk_Thue_ttdb.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_Thue_ttdb.ValidReturnFieldList = "";
		dgvcTk_co.AutoFill = true;
		dgvcTk_co.AutoLookup = true;
		dgvcTk_co.AutoValid = true;
		((DataGridViewColumn)dgvcTk_co).DataPropertyName = "tk_co";
		val57.BackColor = SystemColors.Window;
		((DataGridViewColumn)dgvcTk_co).DefaultCellStyle = val57;
		((DataGridViewColumn)dgvcTk_co).HeaderText = "Tk có";
		dgvcTk_co.LookupCodeName = "";
		dgvcTk_co.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcTk_co).Name = "dgvcTk_co";
		dgvcTk_co.ReceiverValidFieldList = "";
		((DataGridViewColumn)dgvcTk_co).Resizable = (DataGridViewTriState)1;
		dgvcTk_co.SD = true;
		dgvcTk_co.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_co.ValidReturnFieldList = "";
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
		location = new Point(160, 3);
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
		txtTk_thue.AutoLookup = true;
		txtTk_thue.AutoValid = true;
		((TextBoxBase)txtTk_thue).BackColor = SystemColors.Info;
		((TextBox)txtTk_thue).CharacterCasing = (CharacterCasing)1;
		((Control)txtTk_thue).Enabled = false;
		AsTextBox asTextBox5 = txtTk_thue;
		location = new Point(391, 3);
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
		lblTk_thue.AutoSize = true;
		((Control)lblTk_thue).Enabled = false;
		lblTk_thue.ImeMode = (ImeMode)0;
		Label obj45 = lblTk_thue;
		location = new Point(294, 7);
		((Control)obj45).Location = location;
		((Control)lblTk_thue).Name = "lblTk_thue";
		Label obj46 = lblTk_thue;
		size = new Size(79, 13);
		((Control)obj46).Size = size;
		((Control)lblTk_thue).TabIndex = 260;
		lblTk_thue.Text = "Tài khoản thuế";
		((Control)lblTk_thue).Visible = false;
		lblTk_pt.AutoSize = true;
		lblTk_pt.ImeMode = (ImeMode)0;
		Label obj47 = lblTk_pt;
		location = new Point(4, 7);
		((Control)obj47).Location = location;
		((Control)lblTk_pt).Name = "lblTk_pt";
		Label obj48 = lblTk_pt;
		size = new Size(93, 13);
		((Control)obj48).Size = size;
		((Control)lblTk_pt).TabIndex = 259;
		lblTk_pt.Text = "Tài khoản phải trả";
		lblTen_httt.ImeMode = (ImeMode)0;
		Label obj49 = lblTen_httt;
		location = new Point(197, 132);
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
		location = new Point(116, 129);
		((Control)asTextBox7).Location = location;
		txtMa_Httt.LookupCodeName = "MA_HTTT";
		txtMa_Httt.LookupWhereCondition = "moduleid='PO'";
		((Control)txtMa_Httt).Name = "txtMa_Httt";
		txtMa_Httt.NameControl = lblTen_httt;
		txtMa_Httt.SD = true;
		AsTextBox asTextBox8 = txtMa_Httt;
		size = new Size(75, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_Httt).TabIndex = 6;
		txtMa_Httt.UseAutoCompleteSource = true;
		txtMa_Httt.ValidReturnFieldList = "ten_httt,tk,tk_thue_nk,tk_thue_ttdb,tk_thue_gtgt_mua,tk_gtgt_nk_co,tk_gtgt_nk_no";
		Label2.AutoSize = true;
		Label2.ImeMode = (ImeMode)0;
		Label label7 = Label2;
		location = new Point(6, 133);
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
		((Padding)(ref val58))._002Ector(3);
		((Control)obj52).Padding = val58;
		TabPage obj53 = tabTain;
		size = new Size(687, 221);
		((Control)obj53).Size = size;
		tabTain.TabIndex = 10;
		tabTain.Text = "Thuế &gtgt";
		((Control)cmdGetTaInFromDetail).Anchor = (AnchorStyles)10;
		Button obj54 = cmdGetTaInFromDetail;
		location = new Point(546, 192);
		((Control)obj54).Location = location;
		((Control)cmdGetTaInFromDetail).Name = "cmdGetTaInFromDetail";
		Button obj55 = cmdGetTaInFromDetail;
		size = new Size(141, 23);
		((Control)obj55).Size = size;
		((Control)cmdGetTaInFromDetail).TabIndex = 4;
		((ButtonBase)cmdGetTaInFromDetail).Text = "Lấ&y từ chi tiết";
		ctlTaIn.DataSource = bsTain;
		((Control)ctlTaIn).Dock = (DockStyle)5;
		ctlTaIn.HasThueNK = true;
		ctlTaIn.HasThueTTDB = false;
		ctlTaIn obj56 = ctlTaIn;
		location = new Point(3, 3);
		((Control)obj56).Location = location;
		ctlTaIn obj57 = ctlTaIn;
		((Padding)(ref val58))._002Ector(0);
		((Control)obj57).Margin = val58;
		((Control)ctlTaIn).Name = "ctlTaIn";
		ctlTaIn.PHDataSource = bsPH;
		ctlTaIn obj58 = ctlTaIn;
		size = new Size(681, 215);
		((Control)obj58).Size = size;
		((Control)ctlTaIn).TabIndex = 3;
		ctlTaIn.TAINTable = null;
		ctlTaIn.Tk_Du = "";
		ctlTaIn.Tk_Thue = "";
		((Control)Label10).Anchor = (AnchorStyles)6;
		Label10.AutoSize = true;
		((Control)Label10).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label10.ImeMode = (ImeMode)0;
		Label label9 = Label10;
		location = new Point(9, 438);
		((Control)label9).Location = location;
		((Control)Label10).Name = "Label10";
		Label label10 = Label10;
		size = new Size(49, 13);
		((Control)label10).Size = size;
		((Control)Label10).TabIndex = 283;
		Label10.Text = "Tiền vốn";
		Label10.TextAlign = (ContentAlignment)16;
		((Control)txtT_tien_nt).Anchor = (AnchorStyles)6;
		txtT_tien_nt.DecimalSymbol = ".";
		((Control)txtT_tien_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric9 = txtT_tien_nt;
		location = new Point(91, 434);
		((Control)asTextNumeric9).Location = location;
		txtT_tien_nt.Mask = "### ### ### ###";
		((Control)txtT_tien_nt).Name = "txtT_tien_nt";
		((TextBoxBase)txtT_tien_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtT_tien_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric10).Size = size;
		txtT_tien_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tien_nt).TabIndex = 267;
		((Control)txtT_tien_nt).TabStop = false;
		((TextBox)txtT_tien_nt).Text = "0";
		((TextBox)txtT_tien_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tien_nt.Value = 0.0;
		((Control)Label9).Anchor = (AnchorStyles)6;
		Label9.AutoSize = true;
		((Control)Label9).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label9.ImeMode = (ImeMode)0;
		Label label11 = Label9;
		location = new Point(9, 371);
		((Control)label11).Location = location;
		((Control)Label9).Name = "Label9";
		Label label12 = Label9;
		size = new Size(49, 13);
		((Control)label12).Size = size;
		((Control)Label9).TabIndex = 282;
		Label9.Text = "Số lượng";
		Label9.TextAlign = (ContentAlignment)16;
		((Control)txtT_Tien).Anchor = (AnchorStyles)6;
		txtT_Tien.DecimalSymbol = ".";
		((Control)txtT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric11 = txtT_Tien;
		location = new Point(194, 434);
		((Control)asTextNumeric11).Location = location;
		txtT_Tien.Mask = "### ### ### ###";
		((Control)txtT_Tien).Name = "txtT_Tien";
		((TextBoxBase)txtT_Tien).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtT_Tien;
		size = new Size(100, 20);
		((Control)asTextNumeric12).Size = size;
		txtT_Tien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tien).TabIndex = 266;
		((Control)txtT_Tien).TabStop = false;
		((TextBox)txtT_Tien).Text = "0";
		((TextBox)txtT_Tien).TextAlign = (HorizontalAlignment)1;
		txtT_Tien.Value = 0.0;
		((Control)txtT_Thue_Nk_Nt).Anchor = (AnchorStyles)6;
		txtT_Thue_Nk_Nt.DecimalSymbol = ".";
		((Control)txtT_Thue_Nk_Nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric13 = txtT_Thue_Nk_Nt;
		location = new Point(542, 368);
		((Control)asTextNumeric13).Location = location;
		txtT_Thue_Nk_Nt.Mask = "### ### ### ###";
		((Control)txtT_Thue_Nk_Nt).Name = "txtT_Thue_Nk_Nt";
		((TextBoxBase)txtT_Thue_Nk_Nt).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtT_Thue_Nk_Nt;
		size = new Size(100, 20);
		((Control)asTextNumeric14).Size = size;
		txtT_Thue_Nk_Nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_Thue_Nk_Nt).TabIndex = 281;
		((Control)txtT_Thue_Nk_Nt).TabStop = false;
		((TextBox)txtT_Thue_Nk_Nt).Text = "0";
		((TextBox)txtT_Thue_Nk_Nt).TextAlign = (HorizontalAlignment)1;
		txtT_Thue_Nk_Nt.Value = 0.0;
		((Control)txtT_Thue_nk).Anchor = (AnchorStyles)6;
		txtT_Thue_nk.DecimalSymbol = ".";
		((Control)txtT_Thue_nk).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric15 = txtT_Thue_nk;
		location = new Point(645, 368);
		((Control)asTextNumeric15).Location = location;
		txtT_Thue_nk.Mask = "### ### ### ###";
		((Control)txtT_Thue_nk).Name = "txtT_Thue_nk";
		((TextBoxBase)txtT_Thue_nk).ReadOnly = true;
		AsTextNumeric asTextNumeric16 = txtT_Thue_nk;
		size = new Size(100, 20);
		((Control)asTextNumeric16).Size = size;
		txtT_Thue_nk.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Thue_nk).TabIndex = 279;
		((Control)txtT_Thue_nk).TabStop = false;
		((TextBox)txtT_Thue_nk).Text = "0";
		((TextBox)txtT_Thue_nk).TextAlign = (HorizontalAlignment)1;
		txtT_Thue_nk.Value = 0.0;
		((Control)Label3).Anchor = (AnchorStyles)6;
		Label3.AutoSize = true;
		((Control)Label3).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label3.ImeMode = (ImeMode)0;
		Label label13 = Label3;
		location = new Point(462, 371);
		((Control)label13).Location = location;
		((Control)Label3).Name = "Label3";
		Label label14 = Label3;
		size = new Size(50, 13);
		((Control)label14).Size = size;
		((Control)Label3).TabIndex = 280;
		Label3.Text = "Thuế NK";
		((Control)txtT_Thue_ttdb_nt).Anchor = (AnchorStyles)6;
		txtT_Thue_ttdb_nt.DecimalSymbol = ".";
		((Control)txtT_Thue_ttdb_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric17 = txtT_Thue_ttdb_nt;
		location = new Point(542, 390);
		((Control)asTextNumeric17).Location = location;
		txtT_Thue_ttdb_nt.Mask = "### ### ### ###";
		((Control)txtT_Thue_ttdb_nt).Name = "txtT_Thue_ttdb_nt";
		((TextBoxBase)txtT_Thue_ttdb_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric18 = txtT_Thue_ttdb_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric18).Size = size;
		txtT_Thue_ttdb_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_Thue_ttdb_nt).TabIndex = 278;
		((Control)txtT_Thue_ttdb_nt).TabStop = false;
		((TextBox)txtT_Thue_ttdb_nt).Text = "0";
		((TextBox)txtT_Thue_ttdb_nt).TextAlign = (HorizontalAlignment)1;
		txtT_Thue_ttdb_nt.Value = 0.0;
		((Control)txtT_Thue_Ttdb).Anchor = (AnchorStyles)6;
		txtT_Thue_Ttdb.DecimalSymbol = ".";
		((Control)txtT_Thue_Ttdb).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric19 = txtT_Thue_Ttdb;
		location = new Point(645, 390);
		((Control)asTextNumeric19).Location = location;
		txtT_Thue_Ttdb.Mask = "### ### ### ###";
		((Control)txtT_Thue_Ttdb).Name = "txtT_Thue_Ttdb";
		((TextBoxBase)txtT_Thue_Ttdb).ReadOnly = true;
		AsTextNumeric asTextNumeric20 = txtT_Thue_Ttdb;
		size = new Size(100, 20);
		((Control)asTextNumeric20).Size = size;
		txtT_Thue_Ttdb.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Thue_Ttdb).TabIndex = 276;
		((Control)txtT_Thue_Ttdb).TabStop = false;
		((TextBox)txtT_Thue_Ttdb).Text = "0";
		((TextBox)txtT_Thue_Ttdb).TextAlign = (HorizontalAlignment)1;
		txtT_Thue_Ttdb.Value = 0.0;
		((Control)Label1).Anchor = (AnchorStyles)6;
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label1.ImeMode = (ImeMode)0;
		Label label15 = Label1;
		location = new Point(462, 393);
		((Control)label15).Location = location;
		((Control)Label1).Name = "Label1";
		Label label16 = Label1;
		size = new Size(64, 13);
		((Control)label16).Size = size;
		((Control)Label1).TabIndex = 277;
		Label1.Text = "Thuế TTDB";
		((Control)txtT_thue_Nt).Anchor = (AnchorStyles)6;
		txtT_thue_Nt.DecimalSymbol = ".";
		((Control)txtT_thue_Nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric21 = txtT_thue_Nt;
		location = new Point(542, 412);
		((Control)asTextNumeric21).Location = location;
		txtT_thue_Nt.Mask = "### ### ### ###";
		((Control)txtT_thue_Nt).Name = "txtT_thue_Nt";
		((TextBoxBase)txtT_thue_Nt).ReadOnly = true;
		AsTextNumeric asTextNumeric22 = txtT_thue_Nt;
		size = new Size(100, 20);
		((Control)asTextNumeric22).Size = size;
		txtT_thue_Nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_thue_Nt).TabIndex = 275;
		((Control)txtT_thue_Nt).TabStop = false;
		((TextBox)txtT_thue_Nt).Text = "0";
		((TextBox)txtT_thue_Nt).TextAlign = (HorizontalAlignment)1;
		txtT_thue_Nt.Value = 0.0;
		((Control)txtT_Thue).Anchor = (AnchorStyles)6;
		txtT_Thue.DecimalSymbol = ".";
		((Control)txtT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric23 = txtT_Thue;
		location = new Point(645, 412);
		((Control)asTextNumeric23).Location = location;
		txtT_Thue.Mask = "### ### ### ###";
		((Control)txtT_Thue).Name = "txtT_Thue";
		((TextBoxBase)txtT_Thue).ReadOnly = true;
		AsTextNumeric asTextNumeric24 = txtT_Thue;
		size = new Size(100, 20);
		((Control)asTextNumeric24).Size = size;
		txtT_Thue.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Thue).TabIndex = 273;
		((Control)txtT_Thue).TabStop = false;
		((TextBox)txtT_Thue).Text = "0";
		((TextBox)txtT_Thue).TextAlign = (HorizontalAlignment)1;
		txtT_Thue.Value = 0.0;
		((Control)txtT_tt).Anchor = (AnchorStyles)6;
		txtT_tt.DecimalSymbol = ".";
		((Control)txtT_tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric25 = txtT_tt;
		location = new Point(645, 434);
		((Control)asTextNumeric25).Location = location;
		txtT_tt.Mask = "### ### ### ###";
		((Control)txtT_tt).Name = "txtT_tt";
		((TextBoxBase)txtT_tt).ReadOnly = true;
		AsTextNumeric asTextNumeric26 = txtT_tt;
		size = new Size(100, 20);
		((Control)asTextNumeric26).Size = size;
		txtT_tt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_tt).TabIndex = 271;
		((Control)txtT_tt).TabStop = false;
		((TextBox)txtT_tt).Text = "0";
		((TextBox)txtT_tt).TextAlign = (HorizontalAlignment)1;
		txtT_tt.Value = 0.0;
		((Control)txtT_tt_nt).Anchor = (AnchorStyles)6;
		txtT_tt_nt.DecimalSymbol = ".";
		((Control)txtT_tt_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric27 = txtT_tt_nt;
		location = new Point(542, 434);
		((Control)asTextNumeric27).Location = location;
		txtT_tt_nt.Mask = "### ### ### ###";
		((Control)txtT_tt_nt).Name = "txtT_tt_nt";
		((TextBoxBase)txtT_tt_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric28 = txtT_tt_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric28).Size = size;
		txtT_tt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tt_nt).TabIndex = 272;
		((Control)txtT_tt_nt).TabStop = false;
		((TextBox)txtT_tt_nt).Text = "0";
		((TextBox)txtT_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tt_nt.Value = 0.0;
		((Control)txtT_cp_nt).Anchor = (AnchorStyles)6;
		txtT_cp_nt.DecimalSymbol = ".";
		((Control)txtT_cp_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric29 = txtT_cp_nt;
		location = new Point(91, 412);
		((Control)asTextNumeric29).Location = location;
		txtT_cp_nt.Mask = "### ### ### ###";
		((Control)txtT_cp_nt).Name = "txtT_cp_nt";
		((TextBoxBase)txtT_cp_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric30 = txtT_cp_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric30).Size = size;
		txtT_cp_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_cp_nt).TabIndex = 266;
		((Control)txtT_cp_nt).TabStop = false;
		((TextBox)txtT_cp_nt).Text = "0";
		((TextBox)txtT_cp_nt).TextAlign = (HorizontalAlignment)1;
		txtT_cp_nt.Value = 0.0;
		((Control)txtT_Tien_nt0).Anchor = (AnchorStyles)6;
		txtT_Tien_nt0.DecimalSymbol = ".";
		((Control)txtT_Tien_nt0).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric31 = txtT_Tien_nt0;
		location = new Point(91, 390);
		((Control)asTextNumeric31).Location = location;
		txtT_Tien_nt0.Mask = "### ### ### ###";
		((Control)txtT_Tien_nt0).Name = "txtT_Tien_nt0";
		((TextBoxBase)txtT_Tien_nt0).ReadOnly = true;
		AsTextNumeric asTextNumeric32 = txtT_Tien_nt0;
		size = new Size(100, 20);
		((Control)asTextNumeric32).Size = size;
		txtT_Tien_nt0.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_Tien_nt0).TabIndex = 267;
		((Control)txtT_Tien_nt0).TabStop = false;
		((TextBox)txtT_Tien_nt0).Text = "0";
		((TextBox)txtT_Tien_nt0).TextAlign = (HorizontalAlignment)1;
		txtT_Tien_nt0.Value = 0.0;
		((Control)txtT_Tien0).Anchor = (AnchorStyles)6;
		txtT_Tien0.DecimalSymbol = ".";
		((Control)txtT_Tien0).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric33 = txtT_Tien0;
		location = new Point(194, 390);
		((Control)asTextNumeric33).Location = location;
		txtT_Tien0.Mask = "### ### ### ###";
		((Control)txtT_Tien0).Name = "txtT_Tien0";
		((TextBoxBase)txtT_Tien0).ReadOnly = true;
		AsTextNumeric asTextNumeric34 = txtT_Tien0;
		size = new Size(100, 20);
		((Control)asTextNumeric34).Size = size;
		txtT_Tien0.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tien0).TabIndex = 264;
		((Control)txtT_Tien0).TabStop = false;
		((TextBox)txtT_Tien0).Text = "0";
		((TextBox)txtT_Tien0).TextAlign = (HorizontalAlignment)1;
		txtT_Tien0.Value = 0.0;
		((Control)txtT_cp).Anchor = (AnchorStyles)6;
		txtT_cp.DecimalSymbol = ".";
		((Control)txtT_cp).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric35 = txtT_cp;
		location = new Point(194, 412);
		((Control)asTextNumeric35).Location = location;
		txtT_cp.Mask = "### ### ### ###";
		((Control)txtT_cp).Name = "txtT_cp";
		((TextBoxBase)txtT_cp).ReadOnly = true;
		AsTextNumeric asTextNumeric36 = txtT_cp;
		size = new Size(100, 20);
		((Control)asTextNumeric36).Size = size;
		txtT_cp.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_cp).TabIndex = 265;
		((Control)txtT_cp).TabStop = false;
		((TextBox)txtT_cp).Text = "0";
		((TextBox)txtT_cp).TextAlign = (HorizontalAlignment)1;
		txtT_cp.Value = 0.0;
		((Control)txtT_So_luong).Anchor = (AnchorStyles)6;
		txtT_So_luong.DecimalSymbol = ".";
		((Control)txtT_So_luong).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric37 = txtT_So_luong;
		location = new Point(91, 368);
		((Control)asTextNumeric37).Location = location;
		txtT_So_luong.Mask = "### ### ### ###";
		((Control)txtT_So_luong).Name = "txtT_So_luong";
		((TextBoxBase)txtT_So_luong).ReadOnly = true;
		AsTextNumeric asTextNumeric38 = txtT_So_luong;
		size = new Size(100, 20);
		((Control)asTextNumeric38).Size = size;
		txtT_So_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((Control)txtT_So_luong).TabIndex = 269;
		((Control)txtT_So_luong).TabStop = false;
		((TextBox)txtT_So_luong).Text = "0";
		((TextBox)txtT_So_luong).TextAlign = (HorizontalAlignment)1;
		txtT_So_luong.Value = 0.0;
		((Control)lblT_Thue).Anchor = (AnchorStyles)6;
		lblT_Thue.AutoSize = true;
		((Control)lblT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Thue.ImeMode = (ImeMode)0;
		Label obj59 = lblT_Thue;
		location = new Point(462, 415);
		((Control)obj59).Location = location;
		((Control)lblT_Thue).Name = "lblT_Thue";
		Label obj60 = lblT_Thue;
		size = new Size(65, 13);
		((Control)obj60).Size = size;
		((Control)lblT_Thue).TabIndex = 274;
		lblT_Thue.Text = "Thuế GTGT";
		((Control)Label5).Anchor = (AnchorStyles)6;
		Label5.AutoSize = true;
		((Control)Label5).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label5.ImeMode = (ImeMode)0;
		Label label17 = Label5;
		location = new Point(9, 393);
		((Control)label17).Location = location;
		((Control)Label5).Name = "Label5";
		Label label18 = Label5;
		size = new Size(55, 13);
		((Control)label18).Size = size;
		((Control)Label5).TabIndex = 268;
		Label5.Text = "Tiền hàng";
		Label5.TextAlign = (ContentAlignment)16;
		((Control)Label8).Anchor = (AnchorStyles)6;
		Label8.AutoSize = true;
		((Control)Label8).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label8.ImeMode = (ImeMode)0;
		Label label19 = Label8;
		location = new Point(462, 438);
		((Control)label19).Location = location;
		((Control)Label8).Name = "Label8";
		Label label20 = Label8;
		size = new Size(68, 13);
		((Control)label20).Size = size;
		((Control)Label8).TabIndex = 270;
		Label8.Text = "Tổng cộng";
		Label8.TextAlign = (ContentAlignment)16;
		((Control)Label7).Anchor = (AnchorStyles)6;
		Label7.AutoSize = true;
		((Control)Label7).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label7.ImeMode = (ImeMode)0;
		Label label21 = Label7;
		location = new Point(9, 415);
		((Control)label21).Location = location;
		((Control)Label7).Name = "Label7";
		Label label22 = Label7;
		size = new Size(41, 13);
		((Control)label22).Size = size;
		((Control)Label7).TabIndex = 263;
		Label7.Text = "Chi phí";
		Label7.TextAlign = (ContentAlignment)16;
		txtNgay_hd.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_hd).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_hd;
		location = new Point(664, 83);
		((Control)asMaskedTextBox5).Location = location;
		((MaskedTextBox)txtNgay_hd).Mask = "##/##/####";
		((Control)txtNgay_hd).Name = "txtNgay_hd";
		((MaskedTextBox)txtNgay_hd).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_hd;
		size = new Size(78, 20);
		((Control)asMaskedTextBox6).Size = size;
		((Control)txtNgay_hd).TabIndex = 10;
		((MaskedTextBox)txtNgay_hd).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox7 = txtNgay_hd;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox7.Value = dateTime;
		Label4.AutoSize = true;
		Label4.ImeMode = (ImeMode)0;
		Label label23 = Label4;
		location = new Point(571, 87);
		((Control)label23).Location = location;
		((Control)Label4).Name = "Label4";
		Label label24 = Label4;
		size = new Size(75, 13);
		((Control)label24).Size = size;
		((Control)Label4).TabIndex = 262;
		Label4.Text = "Ngày hoá đơn";
		Label6.AutoSize = true;
		Label6.ImeMode = (ImeMode)0;
		Label label25 = Label6;
		location = new Point(571, 110);
		((Control)label25).Location = location;
		((Control)Label6).Name = "Label6";
		Label label26 = Label6;
		size = new Size(63, 13);
		((Control)label26).Size = size;
		((Control)Label6).TabIndex = 264;
		Label6.Text = "Số hoá đơn";
		TextBox obj61 = txtSo_Hd;
		location = new Point(664, 106);
		((Control)obj61).Location = location;
		((TextBoxBase)txtSo_Hd).MaxLength = 12;
		((Control)txtSo_Hd).Name = "txtSo_Hd";
		TextBox obj62 = txtSo_Hd;
		size = new Size(78, 20);
		((Control)obj62).Size = size;
		((Control)txtSo_Hd).TabIndex = 11;
		lblMau_hd.AutoSize = true;
		lblMau_hd.ImeMode = (ImeMode)0;
		Label obj63 = lblMau_hd;
		location = new Point(6, 16);
		((Control)obj63).Location = location;
		((Control)lblMau_hd).Name = "lblMau_hd";
		Label obj64 = lblMau_hd;
		size = new Size(71, 13);
		((Control)obj64).Size = size;
		((Control)lblMau_hd).TabIndex = 0;
		lblMau_hd.Text = "Mẫu hoá đơn";
		lblMau_hd.TextAlign = (ContentAlignment)16;
		cboMau_Hd.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMau_Hd).FormattingEnabled = true;
		cboMau_Hd.Items.AddRange(new object[2] { "Chuẩn", "Thuế TTĐB" });
		ComboBox obj65 = cboMau_Hd;
		location = new Point(116, 12);
		((Control)obj65).Location = location;
		((Control)cboMau_Hd).Name = "cboMau_Hd";
		ComboBox obj66 = cboMau_Hd;
		size = new Size(175, 21);
		((Control)obj66).Size = size;
		((Control)cboMau_Hd).TabIndex = 0;
		lblDia_chi.AutoSize = true;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj67 = lblDia_chi;
		location = new Point(6, 64);
		((Control)obj67).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj68 = lblDia_chi;
		size = new Size(40, 13);
		((Control)obj68).Size = size;
		((Control)lblDia_chi).TabIndex = 270;
		lblDia_chi.Text = "Địa chỉ";
		TextBox obj69 = txtDia_chi;
		location = new Point(116, 60);
		((Control)obj69).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj70 = txtDia_chi;
		size = new Size(425, 20);
		((Control)obj70).Size = size;
		((Control)txtDia_chi).TabIndex = 2;
		lblMa_so_thue.AutoSize = true;
		lblMa_so_thue.ImeMode = (ImeMode)0;
		Label obj71 = lblMa_so_thue;
		location = new Point(307, 87);
		((Control)obj71).Location = location;
		((Control)lblMa_so_thue).Name = "lblMa_so_thue";
		Label obj72 = lblMa_so_thue;
		size = new Size(60, 13);
		((Control)obj72).Size = size;
		((Control)lblMa_so_thue).TabIndex = 272;
		lblMa_so_thue.Text = "Mã số thuế";
		lblMa_so_thue.TextAlign = (ContentAlignment)16;
		TextBox obj73 = txtMa_so_thue;
		location = new Point(413, 83);
		((Control)obj73).Location = location;
		((Control)txtMa_so_thue).Name = "txtMa_so_thue";
		TextBox obj74 = txtMa_so_thue;
		size = new Size(128, 20);
		((Control)obj74).Size = size;
		((Control)txtMa_so_thue).TabIndex = 4;
		((Control)cmdThanh_toan).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdThanh_toan).Image = (Image)componentResourceManager.GetObject("cmdThanh_toan.Image");
		((ButtonBase)cmdThanh_toan).ImageAlign = (ContentAlignment)16;
		Button obj75 = cmdThanh_toan;
		location = new Point(143, 460);
		((Control)obj75).Location = location;
		((Control)cmdThanh_toan).Name = "cmdThanh_toan";
		Button obj76 = cmdThanh_toan;
		size = new Size(64, 23);
		((Control)obj76).Size = size;
		((Control)cmdThanh_toan).TabIndex = 4;
		((ButtonBase)cmdThanh_toan).Text = "Chi tiền";
		((ButtonBase)cmdThanh_toan).TextAlign = (ContentAlignment)64;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).DataPropertyName = "so_ct";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).HeaderText = "Số Ct";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Width = 70;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).DataPropertyName = "ten_ncc";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).HeaderText = "Tên nhà cung cấp";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Name = "DataGridViewTextBoxColumn2";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Width = 255;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).DataPropertyName = "ten_cp";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).HeaderText = "Diễn giải";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Name = "DataGridViewTextBoxColumn3";
		DataGridViewTextBoxColumn3.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Width = 170;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).DataPropertyName = "ten_vt";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Frozen = true;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).HeaderText = "Tên vật tư";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Name = "DataGridViewTextBoxColumn4";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).ReadOnly = true;
		DataGridViewTextBoxColumn4.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Width = 200;
		((DataGridViewColumn)DataGridViewTextBoxColumn5).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)DataGridViewTextBoxColumn5).DataPropertyName = "ma_vt";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).HeaderText = "Mã hàng";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).Name = "DataGridViewTextBoxColumn5";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).ReadOnly = true;
		DataGridViewTextBoxColumn5.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewTextBoxColumn5).Visible = false;
		size = new Size(754, 508);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdThanh_toan);
		((Control)this).Controls.Add((Control)(object)txtT_Thue_Nk_Nt);
		((Control)this).Controls.Add((Control)(object)Label10);
		((Control)this).Controls.Add((Control)(object)txtT_Thue_nk);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)txtT_Thue_ttdb_nt);
		((Control)this).Controls.Add((Control)(object)txtT_tien_nt);
		((Control)this).Controls.Add((Control)(object)txtT_Thue_Ttdb);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)Label9);
		((Control)this).Controls.Add((Control)(object)txtT_thue_Nt);
		((Control)this).Controls.Add((Control)(object)txtT_Tien);
		((Control)this).Controls.Add((Control)(object)txtT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_tt);
		((Control)this).Controls.Add((Control)(object)txtT_tt_nt);
		((Control)this).Controls.Add((Control)(object)lblT_Thue);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)txtT_cp_nt);
		((Control)this).Controls.Add((Control)(object)txtT_So_luong);
		((Control)this).Controls.Add((Control)(object)txtT_Tien_nt0);
		((Control)this).Controls.Add((Control)(object)txtT_cp);
		((Control)this).Controls.Add((Control)(object)txtT_Tien0);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmPOVchPO7";
		((Form)this).Text = "frmPoVchPO7";
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien0, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_cp, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien_nt0, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_So_luong, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_cp_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_thue_Nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label9, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue_Ttdb, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tien_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue_ttdb_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue_nk, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label10, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue_Nk_Nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdThanh_toan, 0);
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
			((TextBox)txtTk_thue).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_gtgt_nk_no"]), isNum: false));
			CurrentPHRow["tk_pt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			isMa_HtttChanged = true;
			f_Tk_Thue = Conversions.ToString(Interaction.IIf(Operators.CompareString(f_Tk_Thue, "", false) == 0, RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_mua"]), isNum: false)), (object)f_Tk_Thue));
			f_Tk_Thue_Nk = Conversions.ToString(Interaction.IIf(Operators.CompareString(f_Tk_Thue_Nk, "", false) == 0, RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_nk"]), isNum: false)), (object)f_Tk_Thue_Nk));
			f_Tk_Thue_TtDb = Conversions.ToString(Interaction.IIf(Operators.CompareString(f_Tk_Thue_TtDb, "", false) == 0, RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_ttdb"]), isNum: false)), (object)f_Tk_Thue_TtDb));
			ctlTaIn.Tk_Du = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_gtgt_nk_co"]), isNum: false));
			ctlTaIn.Tk_Thue = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_gtgt_nk_no"]), isNum: false));
			setTk4Ct();
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

	private void adgvDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if ((CTTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			bool flag = true;
			DataRowView oDv = CT1Voucher[e.RowIndex];
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcSo_luong).Name, false) == 0)
			{
				V_So_Luong(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_nt0).Name, false) == 0)
			{
				V_Gia_Nt0(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt0).Name, false) == 0)
			{
				V_Tien_nt0(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia0).Name, false) == 0)
			{
				V_Gia0(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien0).Name, false) == 0)
			{
				V_Tien0(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_cp_nt).Name, false) == 0)
			{
				V_Cp_Nt(oDv);
				V_Tien_Cp_Nt_ChiTiet(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_cp).Name, false) == 0)
			{
				V_Cp(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTs_Nk).Name, false) == 0)
			{
				V_Ts_nk(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_Nk_Nt).Name, false) == 0)
			{
				V_Thue_nk_Nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_Nk).Name, false) == 0)
			{
				V_Thue_nk(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTs_ttdb).Name, false) == 0)
			{
				V_Ts_TtDb(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_TtDb_Nt).Name, false) == 0)
			{
				V_Thue_TtDb_Nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_Ttdb).Name, false) == 0)
			{
				V_Thue_TtDb(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTs_gtgt).Name, false) == 0)
			{
				V_Ts_gtgt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt_nt).Name, false) == 0)
			{
				V_Thue_gtgt_nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt).Name, false) == 0)
			{
				V_Thue_gtgt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_vt).Name, false) == 0)
			{
				V_Ma_Vt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kho).Name, false) == 0)
			{
				V_Ma_Kho(oDv);
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
		DataRowView dataRowView = CT1Voucher[e.RowIndex];
		try
		{
			object obj = null;
			DataGridViewCell currentCell = ((DataGridView)adgvDetail).CurrentCell;
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt0).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Nt0(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien0).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien0(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia0).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Gia0(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Thue_Gtgt_Nt(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Thue_Gtgt(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_vt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Ma_Vt(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kho).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["ten_kho"]);
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

	private void adgvChi_phi_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if ((CPTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			DataRowView currentCPRowView = CurrentCPRowView;
			DataGridViewCell currentCell = ((DataGridView)adgvChi_phi).CurrentCell;
			string name = ((DataGridView)adgvChi_phi).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_Gtgt_nt_cp).Name, false) == 0)
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
		if ((CPTable == null || e.RowIndex < 0 || base.IsLoading) ? true : false)
		{
			return;
		}
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
		else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTs_gtgt_cp).Name, false) != 0)
		{
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_Gtgt_nt_cp).Name, false) == 0)
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
		}
		if (flag)
		{
			((DataGridView)adgvChi_phi).InvalidateRow(e.RowIndex);
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

	private void cboMau_Hd_SelectedIndexChanged(object sender, EventArgs e)
	{
		RefreshGridByMau_Hd();
		RefreshDGVInput();
	}

	private void ctlTaIn_TAINValueChanged(object sender, EventArgs e)
	{
		UpdateList();
	}

	private void adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged(object sender, SetDependentFieldsWhenCellValueChangedEventArgs e)
	{
		if ((!base.MyVoucherInfo.ct_carry_field_list.ToUpper().Contains("MA_KHO") || ((DataGridViewCellEventArgs)e).RowIndex <= 0) && 0 == 0 && ((e.ValidatedRow != null && ((DataGridView)adgvDetail).Columns[((DataGridViewCellEventArgs)e).ColumnIndex].Name.Equals(((DataGridViewColumn)dgvcMa_vt).Name) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_kho"]), isNum: false), (object)"", false)) ? true : false))
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

	private bool W_Thue_Nk_Nt(DataRowView oDv)
	{
		return true;
	}

	private bool W_Thue_Nk(DataRowView oDv)
	{
		return true;
	}

	private bool W_Thue_Ttdb_Nt(DataRowView oDv)
	{
		return true;
	}

	private bool W_Thue_Ttdb(DataRowView oDv)
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
		Calc_TienMua(oDv);
		Calc_Thue_nk(oDv);
		Calc_Thue_Ttdb(oDv);
		Calc_TienVon(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_So_luong_qd(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Gia_Nt0(DataRowView oDv)
	{
		CalC_GiaMua(oDv);
		Calc_TienMua(oDv);
		Calc_Thue_nk(oDv);
		Calc_Thue_Ttdb(oDv);
		Calc_TienVon(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Gia0(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia0"]), isNum: true)), (object)0, false))
		{
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
			oDv["Tien0"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt0"]), isNum: true), txtTy_gia.Value),
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
			oDv["Tien0"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		Calc_Thue_nk(oDv);
		Calc_Thue_Ttdb(oDv);
		Calc_TienVon(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien_nt0(DataRowView oDv)
	{
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
			CalC_GiaMua(oDv);
		}
		Calc_Thue_nk(oDv);
		Calc_Thue_Ttdb(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien0(DataRowView oDv)
	{
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
		Calc_Thue_nk(oDv);
		Calc_Thue_Ttdb(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Ts_gtgt(DataRowView oDv)
	{
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Thue_gtgt_nt(DataRowView oDv)
	{
		if ((Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0 && Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)1, false)) ? true : false)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_NT"]), isNum: true)),
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
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.AddObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Nk"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Ttdb"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["cp"]), isNum: true))), (object)100),
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
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Thue_gtgt(DataRowView oDv)
	{
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Ts_nk(DataRowView oDv)
	{
		Calc_Thue_nk(oDv);
		Calc_Thue_Ttdb(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Thue_nk_Nt(DataRowView oDv)
	{
		if ((Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0 && Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)1, false)) ? true : false)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Nk_nt"]), isNum: true)),
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
			oDv["Thue_Nk"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Nk"]), isNum: true), Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["cp"]), isNum: true))), (object)100),
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
				oDv["Thue_Nk"] = num;
			}
			else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
			{
				Type? typeFromHandle3 = typeof(Math);
				array3 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Nk_nt"]), isNum: true), txtTy_gia.Value),
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
				oDv["Thue_Nk"] = RuntimeHelpers.GetObjectValue(obj3);
			}
		}
		Calc_Thue_Ttdb(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Thue_nk(DataRowView oDv)
	{
		Calc_Thue_Ttdb(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Ts_TtDb(DataRowView oDv)
	{
		Calc_Thue_Ttdb(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Thue_TtDb_Nt(DataRowView oDv)
	{
		if ((Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0 && Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)1, false)) ? true : false)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Ttdb_NT"]), isNum: true)),
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
			oDv["Thue_Ttdb"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Ttdb"]), isNum: true), Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Nk"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["cp"]), isNum: true))), (object)100),
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
				oDv["Thue_Ttdb"] = num;
			}
			else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
			{
				Type? typeFromHandle3 = typeof(Math);
				array3 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Ttdb_nt"]), isNum: true), txtTy_gia.Value),
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
				oDv["Thue_Ttdb"] = RuntimeHelpers.GetObjectValue(obj3);
			}
		}
		Calc_TienVon(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Thue_TtDb(DataRowView oDv)
	{
		Calc_TienVon(oDv);
		Calc_Thue_gtgt(oDv);
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
		Calc_Thue_nk(oDv);
		Calc_Thue_Ttdb(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateCPList();
	}

	private void V_Cp(DataRowView oDv)
	{
		Calc_Thue_nk(oDv);
		Calc_Thue_Ttdb(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateCPList();
		UpdateList();
	}

	private void V_Cp_Nt(DataRowView oDv)
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
		Calc_Thue_nk(oDv);
		Calc_Thue_Ttdb(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_TienVon(oDv);
		Calc_ThanhToan(oDv);
		UpdateCPList();
		UpdateList();
	}

	private void CalC_GiaMua(DataRowView odv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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
			odv["Gia0"] = RuntimeHelpers.GetObjectValue(obj);
		}
	}

	private void Calc_ThanhToan(DataRowView oDv)
	{
		oDv["Tt_Nt"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true));
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tt_nt"]), isNum: true)),
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
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)),
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
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tt_nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Tt"] = RuntimeHelpers.GetObjectValue(obj3);
		}
	}

	private void Calc_TienMua(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt0"]), isNum: true)), (object)0, false))
		{
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
		}
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt0"]), isNum: true)),
				null,
				null
			};
			object[] array4 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array4[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array6 = array5;
			bool[] array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tien0"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia0"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia0"]), isNum: true)),
				null,
				null
			};
			object[] array7 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array7[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array8 = array5;
			bool[] array3 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tien0"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt0"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array9 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array10 = array5;
			bool[] array3 = new bool[3] { false, true, false };
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
		oDv["Tien_Nt"] = Operators.AddObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Nk_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Ttdb_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Cp_Nt"]), isNum: true));
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true)),
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
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else
		{
			double num3 = Conversions.ToDouble(Operators.AddObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Nk"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Ttdb"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Cp"]), isNum: true)));
			if (num3 != 0.0)
			{
				oDv["Tien"] = Operators.AddObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Nk"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Ttdb"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Cp"]), isNum: true));
			}
			else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
			{
				Type? typeFromHandle2 = typeof(Math);
				object[] array3 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true), txtTy_gia.Value),
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
				oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
			}
		}
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["so_luong"]), isNum: true), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["so_luong"]), isNum: true)),
				num2,
				MidpointRounding.AwayFromZero
			};
			object[] array8 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Gia_Nt"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array3 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true)),
				null,
				null
			};
			object[] array9 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round_Gia;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array10 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj4);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["so_luong"]), isNum: true), (object)0, false))
		{
			Type? typeFromHandle5 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["so_luong"]), isNum: true)),
				null,
				null
			};
			object[] array11 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array11[1] = sIConfiguration.Round_Gia;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array12 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array12, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj5);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle6 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
				null,
				null
			};
			object[] array13 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array13[1] = sIConfiguration.Round_Gia;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array14 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array14, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj6);
		}
	}

	private void Calc_Thue_nk(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		object[] array;
		bool[] array3;
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Nk"]), isNum: true), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Nk"]), isNum: true), Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["cp_nt"]), isNum: true))), (object)100),
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
			oDv["Thue_Nk_Nt"] = RuntimeHelpers.GetObjectValue(obj);
		}
		SIConfiguration sIConfiguration;
		object[] array5;
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Nk_nt"]), isNum: true)),
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
			oDv["Thue_Nk"] = RuntimeHelpers.GetObjectValue(obj2);
			return;
		}
		Type? typeFromHandle3 = typeof(Math);
		array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Nk"]), isNum: true), Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["cp"]), isNum: true))), (object)100),
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
			oDv["Thue_Nk"] = num2;
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Nk_nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Thue_Nk"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	private void Calc_Thue_Ttdb(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Ttdb"]), isNum: true), Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Nk_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["cp_nt"]), isNum: true))), (object)100),
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
		oDv["Thue_Ttdb_Nt"] = RuntimeHelpers.GetObjectValue(obj);
		SIConfiguration sIConfiguration;
		object[] array5;
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Ttdb_Nt"]), isNum: true)),
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
			oDv["Thue_Ttdb"] = RuntimeHelpers.GetObjectValue(obj2);
			return;
		}
		Type? typeFromHandle3 = typeof(Math);
		array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Ttdb"]), isNum: true), Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Nk"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["cp"]), isNum: true))), (object)100),
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
			oDv["Thue_Ttdb"] = num2;
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Ttdb_Nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Thue_Ttdb"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	private void Calc_Thue_gtgt(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.AddObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Nk_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Ttdb_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["cp_nt"]), isNum: true))), (object)100),
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
		SIConfiguration sIConfiguration;
		object[] array5;
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true)),
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
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj2);
			return;
		}
		Type? typeFromHandle3 = typeof(Math);
		array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.AddObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Nk"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Ttdb"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["cp"]), isNum: true))), (object)100),
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
			oDv["Thue_Gtgt"] = num2;
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	private void Calc_So_luong_qd(DataRowView oDv)
	{
		oDv["so_luong_qd"] = RuntimeHelpers.GetObjectValue(oDv["so_luong"]);
	}

	private void V_Ty_Gia()
	{
		if ((Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false) && base.CT1Voucher != null) ? true : false)
		{
			if (Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)TyGia_cur, false))
			{
				return;
			}
			foreach (DataRowView item in CT1Voucher)
			{
				if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
				{
					Type? typeFromHandle = typeof(Math);
					object[] array = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt0"]), isNum: true)),
						null,
						null
					};
					object[] array2 = array;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array2[1] = sIConfiguration.Round_Gia;
					array[2] = MidpointRounding.AwayFromZero;
					object[] array3 = array;
					object[] array4 = array3;
					bool[] array5 = new bool[3] { false, true, false };
					object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
					}
					item["gia0"] = RuntimeHelpers.GetObjectValue(obj);
					Type? typeFromHandle2 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt0"]), isNum: true)),
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
					item["Tien0"] = RuntimeHelpers.GetObjectValue(obj2);
					Type? typeFromHandle3 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["cp_nt"]), isNum: true)),
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
					item["cp"] = RuntimeHelpers.GetObjectValue(obj3);
					Type? typeFromHandle4 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt"]), isNum: true)),
						null,
						null
					};
					object[] array10 = array3;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array10[1] = sIConfiguration.Round_Gia;
					array3[2] = MidpointRounding.AwayFromZero;
					array = array3;
					object[] array11 = array;
					array5 = new bool[3] { false, true, false };
					object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array11, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item["gia"] = RuntimeHelpers.GetObjectValue(obj4);
					Type? typeFromHandle5 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt"]), isNum: true)),
						null,
						null
					};
					object[] array12 = array3;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array12[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					array = array3;
					object[] array13 = array;
					array5 = new bool[3] { false, true, false };
					object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array13, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item["Tien"] = RuntimeHelpers.GetObjectValue(obj5);
					Type? typeFromHandle6 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_nt"]), isNum: true)),
						null,
						null
					};
					object[] array14 = array3;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array14[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					array = array3;
					object[] array15 = array;
					array5 = new bool[3] { false, true, false };
					object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array15, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj6);
					Type? typeFromHandle7 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Nk_nt"]), isNum: true)),
						null,
						null
					};
					object[] array16 = array3;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array16[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					array = array3;
					object[] array17 = array;
					array5 = new bool[3] { false, true, false };
					object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle7, "Round", array17, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item["Thue_Nk"] = RuntimeHelpers.GetObjectValue(obj7);
					Type? typeFromHandle8 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Ttdb_Nt"]), isNum: true)),
						null,
						null
					};
					object[] array18 = array3;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array18[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					array = array3;
					object[] array19 = array;
					array5 = new bool[3] { false, true, false };
					object obj8 = NewLateBinding.LateGet((object)null, typeFromHandle8, "Round", array19, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item["Thue_Ttdb"] = RuntimeHelpers.GetObjectValue(obj8);
				}
				else
				{
					object[] array3;
					SIConfiguration sIConfiguration;
					object[] array;
					bool[] array5;
					if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
					{
						Type? typeFromHandle9 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt0"]), isNum: true), txtTy_gia.Value),
							null,
							null
						};
						object[] array20 = array3;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array20[1] = sIConfiguration.Round_Gia;
						array3[2] = MidpointRounding.AwayFromZero;
						array = array3;
						object[] array21 = array;
						array5 = new bool[3] { false, true, false };
						object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle9, "Round", array21, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						item["gia0"] = RuntimeHelpers.GetObjectValue(obj9);
					}
					if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia0"]), isNum: true)), (object)0, false))
					{
						Type? typeFromHandle10 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia0"]), isNum: true)),
							null,
							null
						};
						object[] array22 = array3;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array22[1] = sIConfiguration.Round;
						array3[2] = MidpointRounding.AwayFromZero;
						array = array3;
						object[] array23 = array;
						array5 = new bool[3] { false, true, false };
						object obj10 = NewLateBinding.LateGet((object)null, typeFromHandle10, "Round", array23, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						item["Tien0"] = RuntimeHelpers.GetObjectValue(obj10);
					}
					else
					{
						Type? typeFromHandle11 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_nt0"]), isNum: true), txtTy_gia.Value),
							null,
							null
						};
						object[] array24 = array3;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array24[1] = sIConfiguration.Round;
						array3[2] = MidpointRounding.AwayFromZero;
						array = array3;
						object[] array25 = array;
						array5 = new bool[3] { false, true, false };
						object obj11 = NewLateBinding.LateGet((object)null, typeFromHandle11, "Round", array25, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						item["Tien0"] = RuntimeHelpers.GetObjectValue(obj11);
					}
					if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
					{
						Type? typeFromHandle12 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["cp_nt"]), isNum: true), txtTy_gia.Value),
							null,
							null
						};
						object[] array26 = array3;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array26[1] = sIConfiguration.Round;
						array3[2] = MidpointRounding.AwayFromZero;
						array = array3;
						object[] array27 = array;
						array5 = new bool[3] { false, true, false };
						object obj12 = NewLateBinding.LateGet((object)null, typeFromHandle12, "Round", array27, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						item["cp"] = RuntimeHelpers.GetObjectValue(obj12);
					}
					Type? typeFromHandle13 = typeof(Math);
					array3 = new object[3]
					{
						Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ts_Nk"]), isNum: true), Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["cp"]), isNum: true))), (object)100),
						null,
						null
					};
					object[] array28 = array3;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array28[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					array = array3;
					object[] array29 = array;
					array5 = new bool[3] { false, true, false };
					object obj13 = NewLateBinding.LateGet((object)null, typeFromHandle13, "Round", array29, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					double num = Conversions.ToDouble(obj13);
					if (num != 0.0)
					{
						item["Thue_Nk"] = num;
					}
					else
					{
						Type? typeFromHandle14 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Nk_nt"]), isNum: true), txtTy_gia.Value),
							null,
							null
						};
						object[] array30 = array3;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array30[1] = sIConfiguration.Round;
						array3[2] = MidpointRounding.AwayFromZero;
						array = array3;
						object[] array31 = array;
						array5 = new bool[3] { false, true, false };
						object obj14 = NewLateBinding.LateGet((object)null, typeFromHandle14, "Round", array31, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						item["Thue_Nk"] = RuntimeHelpers.GetObjectValue(obj14);
					}
					Type? typeFromHandle15 = typeof(Math);
					array3 = new object[3]
					{
						Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ts_Ttdb"]), isNum: true), Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Nk"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["cp"]), isNum: true))), (object)100),
						null,
						null
					};
					object[] array32 = array3;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array32[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					array = array3;
					object[] array33 = array;
					array5 = new bool[3] { false, true, false };
					object obj15 = NewLateBinding.LateGet((object)null, typeFromHandle15, "Round", array33, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					double num2 = Conversions.ToDouble(obj15);
					if (num2 != 0.0)
					{
						item["Thue_Ttdb"] = num2;
					}
					else
					{
						Type? typeFromHandle16 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Ttdb_Nt"]), isNum: true), txtTy_gia.Value),
							null,
							null
						};
						object[] array34 = array3;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array34[1] = sIConfiguration.Round;
						array3[2] = MidpointRounding.AwayFromZero;
						array = array3;
						object[] array35 = array;
						array5 = new bool[3] { false, true, false };
						object obj16 = NewLateBinding.LateGet((object)null, typeFromHandle16, "Round", array35, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						item["Thue_Ttdb"] = RuntimeHelpers.GetObjectValue(obj16);
					}
					Type? typeFromHandle17 = typeof(Math);
					array3 = new object[3]
					{
						Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ts_Gtgt"]), isNum: true), Operators.AddObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Nk"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Ttdb"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["cp"]), isNum: true))), (object)100),
						null,
						null
					};
					object[] array36 = array3;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array36[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					array = array3;
					object[] array37 = array;
					array5 = new bool[3] { false, true, false };
					object obj17 = NewLateBinding.LateGet((object)null, typeFromHandle17, "Round", array37, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					double num3 = Conversions.ToDouble(obj17);
					if (num3 != 0.0)
					{
						item["Thue_Gtgt"] = num3;
					}
					else
					{
						Type? typeFromHandle18 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_Nt"]), isNum: true), txtTy_gia.Value),
							null,
							null
						};
						object[] array38 = array3;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array38[1] = sIConfiguration.Round;
						array3[2] = MidpointRounding.AwayFromZero;
						array = array3;
						object[] array39 = array;
						array5 = new bool[3] { false, true, false };
						object obj18 = NewLateBinding.LateGet((object)null, typeFromHandle18, "Round", array39, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						item["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj18);
					}
					double num4 = Conversions.ToDouble(Operators.AddObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Nk"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Ttdb"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Cp"]), isNum: true)));
					if (num4 == 0.0)
					{
						item["Tien"] = Operators.AddObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Nk"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Ttdb"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Cp"]), isNum: true));
					}
					else
					{
						Type? typeFromHandle19 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt"]), isNum: true), txtTy_gia.Value),
							null,
							null
						};
						object[] array40 = array3;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array40[1] = sIConfiguration.Round;
						array3[2] = MidpointRounding.AwayFromZero;
						array = array3;
						object[] array41 = array;
						array5 = new bool[3] { false, true, false };
						object obj19 = NewLateBinding.LateGet((object)null, typeFromHandle19, "Round", array41, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						item["Tien"] = RuntimeHelpers.GetObjectValue(obj19);
					}
					if (Operators.ConditionalCompareObjectGreater(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["so_luong"]), isNum: true), (object)0, false))
					{
						Type? typeFromHandle20 = typeof(Math);
						array3 = new object[3]
						{
							Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["so_luong"]), isNum: true)),
							null,
							null
						};
						object[] array42 = array3;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array42[1] = sIConfiguration.Round_Gia;
						array3[2] = MidpointRounding.AwayFromZero;
						array = array3;
						object[] array43 = array;
						array5 = new bool[3] { false, true, false };
						object obj20 = NewLateBinding.LateGet((object)null, typeFromHandle20, "Round", array43, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						item["Gia"] = RuntimeHelpers.GetObjectValue(obj20);
					}
					else
					{
						Type? typeFromHandle21 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
							null,
							null
						};
						object[] array44 = array3;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array44[1] = sIConfiguration.Round_Gia;
						array3[2] = MidpointRounding.AwayFromZero;
						array = array3;
						object[] array45 = array;
						array5 = new bool[3] { false, true, false };
						object obj21 = NewLateBinding.LateGet((object)null, typeFromHandle21, "Round", array45, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						item["Gia"] = RuntimeHelpers.GetObjectValue(obj21);
					}
				}
				Calc_ThanhToan(item);
			}
			foreach (DataRowView item2 in CP1Voucher)
			{
				if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
				{
					Type? typeFromHandle22 = typeof(Math);
					object[] array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp_nt"]), isNum: true)),
						null,
						null
					};
					object[] array46 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array46[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array47 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj22 = NewLateBinding.LateGet((object)null, typeFromHandle22, "Round", array47, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["tien_cp"] = RuntimeHelpers.GetObjectValue(obj22);
					Type? typeFromHandle23 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt_nt"]), isNum: true)),
						null,
						null
					};
					object[] array48 = array3;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array48[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					array = array3;
					object[] array49 = array;
					array5 = new bool[3] { false, true, false };
					object obj23 = NewLateBinding.LateGet((object)null, typeFromHandle23, "Round", array49, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj23);
					Type? typeFromHandle24 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tt_nt"]), isNum: true)),
						null,
						null
					};
					object[] array50 = array3;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array50[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					array = array3;
					object[] array51 = array;
					array5 = new bool[3] { false, true, false };
					object obj24 = NewLateBinding.LateGet((object)null, typeFromHandle24, "Round", array51, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["Tt"] = RuntimeHelpers.GetObjectValue(obj24);
					continue;
				}
				if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
				{
					Type? typeFromHandle25 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp_nt"]), isNum: true), txtTy_gia.Value),
						null,
						null
					};
					object[] array52 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array52[1] = sIConfiguration.Round_Gia;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array53 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj25 = NewLateBinding.LateGet((object)null, typeFromHandle25, "Round", array53, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["tien_cp"] = RuntimeHelpers.GetObjectValue(obj25);
				}
				if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tien_Cp"]), isNum: true)), (object)0, false))
				{
					Type? typeFromHandle26 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tien_Cp"]), isNum: true)), (object)100),
						null,
						null
					};
					object[] array54 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array54[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array55 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj26 = NewLateBinding.LateGet((object)null, typeFromHandle26, "Round", array55, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj26);
				}
				else
				{
					Type? typeFromHandle27 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt"]), isNum: true), txtTy_gia.Value),
						null,
						null
					};
					object[] array56 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array56[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array57 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj27 = NewLateBinding.LateGet((object)null, typeFromHandle27, "Round", array57, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj27);
				}
				if (Operators.ConditionalCompareObjectNotEqual(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt"]), isNum: true)), (object)0, false))
				{
					Type? typeFromHandle28 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt"]), isNum: true)),
						null,
						null
					};
					object[] array58 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array58[1] = sIConfiguration.Round_Gia;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array59 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj28 = NewLateBinding.LateGet((object)null, typeFromHandle28, "Round", array59, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["Tt"] = RuntimeHelpers.GetObjectValue(obj28);
				}
				else
				{
					Type? typeFromHandle29 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tt_nt"]), isNum: true), txtTy_gia.Value),
						null,
						null
					};
					object[] array60 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array60[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array61 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj29 = NewLateBinding.LateGet((object)null, typeFromHandle29, "Round", array61, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["Tt"] = RuntimeHelpers.GetObjectValue(obj29);
				}
			}
		}
		TyGia_cur = Conversions.ToDouble(txtTy_gia.Value);
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

	private void Calc_Thue_gtgt_Cp(DataRowView oDv)
	{
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp_Nt"]), isNum: true)), (object)100),
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
			oDv["Thue_Gtgt_Nt"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp_Nt"]), isNum: true)), (object)100),
				null,
				null
			};
			object[] array6 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round_Nt;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array7 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round_Nt = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Thue_Gtgt_Nt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true)),
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
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp"]), isNum: true)), (object)100),
				null,
				null
			};
			object[] array10 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array10[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array11 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array11, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj4);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle5 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array12 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array12[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array13 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array13, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj5);
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
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tt_nt"]), isNum: true)),
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
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["tien_cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["tien_cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)),
				null,
				null
			};
			object[] array6 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round_Gia;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array7 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tt_nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Tt"] = RuntimeHelpers.GetObjectValue(obj3);
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
			Calc_Thue_nk(item2);
			Calc_Thue_Ttdb(item2);
			Calc_Thue_gtgt(item2);
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
		Calc_Thue_nk(dataRowView4);
		Calc_Thue_Ttdb(dataRowView4);
		Calc_Thue_gtgt(dataRowView4);
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
			array[2] = MidpointRounding.AwayFromZero;
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
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp"]), isNum: true)), (object)100),
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
		oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj);
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

	private void setTk4Ct()
	{
		if (!isMa_HtttChanged)
		{
			return;
		}
		foreach (DataRowView item in CT1Voucher)
		{
			item["tk_thue"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tk_thue"]), isNum: false), (object)"", false), (object)f_Tk_Thue, RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tk_thue"]), isNum: false))));
			item["tk_thue_nk"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tk_thue_nk"]), isNum: false), (object)"", false), (object)f_Tk_Thue_Nk, RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tk_thue_nk"]), isNum: false))));
			item["tk_thue_ttdb"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tk_thue_ttdb"]), isNum: false), (object)"", false), (object)f_Tk_Thue_TtDb, RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tk_thue_ttdb"]), isNum: false))));
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
		odr["Tt_Nt"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tien_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Thue_Gtgt_Nt"]), isNum: true));
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

	private void RefreshGridByMau_Hd()
	{
		switch (cboMau_Hd.SelectedIndex)
		{
		case 0:
			hasTTDB = false;
			ctlTaIn.HasThueTTDB = false;
			break;
		case 1:
			hasTTDB = true;
			ctlTaIn.HasThueTTDB = true;
			break;
		}
		if (hasTTDB || base.CT1Voucher == null || 1 == 0)
		{
			return;
		}
		foreach (object item in base.CT1Voucher)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(item);
			NewLateBinding.LateIndexSet(objectValue, new object[2] { "ts_ttdb", 0 }, (string[])null);
			NewLateBinding.LateIndexSet(objectValue, new object[2] { "thue_ttdb", 0 }, (string[])null);
			NewLateBinding.LateIndexSet(objectValue, new object[2] { "thue_ttdb_nt", 0 }, (string[])null);
			Calc_TienVon((DataRowView)objectValue);
			Calc_Thue_gtgt((DataRowView)objectValue);
			Calc_ThanhToan((DataRowView)objectValue);
			UpdateList();
		}
	}

	private void Calc_ThueVAT()
	{
		string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
		int digits = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		double num = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(tien_nt)", filter)), isNum: true));
		double num2 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(tien)", filter)), isNum: true));
		double num3 = Convert.ToDouble(ctlTaIn.get_T_Thue(""));
		double num4 = Convert.ToDouble(ctlTaIn.get_T_Thue_Nt(""));
		foreach (DataRowView item in base.CT1Voucher)
		{
			if (num != 0.0)
			{
				double num5 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien_nt"]), isNum: true));
				item["thue_gtgt_nt"] = Math.Round(num4 * num5 / num, digits, MidpointRounding.AwayFromZero);
				double num6 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien"]), isNum: true));
				item["thue_gtgt"] = Math.Round(num3 * num6 / num2, AsiaErp.Framework.Environment.GetSIConfiguration().Round, MidpointRounding.AwayFromZero);
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
		if (Conversions.ToDouble(AsiaErp.Framework.Environment.GetPOConfiguration().ke_gtgt_mua_chi_tiet_theo_vt) != 1.0)
		{
			IOrderedEnumerable<VB_0024AnonymousType_2<decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal>> orderedEnumerable = from _0024VB_0024It in (from row in CTTable.AsEnumerable()
					where Operators.ConditionalCompareObjectEqual(row["stt_rec"], _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()["stt_rec"], false)
					select row).GroupBy([SpecialName] (DataRow row) => row.Field<decimal?>("ts_gtgt") ?? 0m, [SpecialName] (DataRow row) => row, [SpecialName] (decimal ts_gtgt, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_1<decimal, IEnumerable<DataRow>, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal>(ts_gtgt, _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien_nt0") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien0") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_gtgt_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_gtgt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_nk_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_nk") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_ttdb_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_ttdb") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("cp_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("cp") ?? 0m)))
				select new VB_0024AnonymousType_2<decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal>(_0024VB_0024It.ts_gtgt, _0024VB_0024It.tien_nt0, _0024VB_0024It.tien0, _0024VB_0024It.thue_gtgt_nt, _0024VB_0024It.thue_gtgt, _0024VB_0024It.thue_nk_nt, _0024VB_0024It.thue_nk, _0024VB_0024It.thue_ttdb_nt, _0024VB_0024It.thue_ttdb, _0024VB_0024It.tien_nt, _0024VB_0024It.tien, _0024VB_0024It.cp_nt, _0024VB_0024It.cp) into _0024VB_0024It
				orderby _0024VB_0024It.ts_gtgt
				select _0024VB_0024It;
			{
				foreach (VB_0024AnonymousType_2<decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal, decimal> item2 in orderedEnumerable)
				{
					DataRow dataRow = base.TAINTable.NewRow();
					dataRow["ma_cty"] = CompanyInformations.CompanyID;
					dataRow["stt_rec"] = RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]);
					dataRow["stt_rec0"] = Commons.Get_SttRec0(Conversions.ToString(base.CurrentPHRow["stt_rec"]), base.TAINTable);
					dataRow["so_ct0"] = txtSo_Hd.Text.Trim();
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
					dataRow["tien_hang_nt"] = item2.tien_nt0;
					dataRow["tien_hang"] = item2.tien0;
					dataRow["t_thue_nt"] = item2.thue_gtgt_nt;
					dataRow["t_thue"] = item2.thue_gtgt;
					dataRow["thue_nk_nt"] = item2.thue_nk_nt;
					dataRow["thue_nk"] = item2.thue_nk;
					dataRow["thue_ttdb_nt"] = item2.thue_ttdb_nt;
					dataRow["thue_ttdb"] = item2.thue_ttdb;
					dataRow["t_tien_nt"] = item2.tien_nt;
					dataRow["t_tien"] = item2.tien;
					dataRow["thue_suat"] = item2.ts_gtgt;
					base.TAINTable.Rows.Add(dataRow);
				}
				return;
			}
		}
		foreach (DataRowView item3 in base.CT1Voucher)
		{
			DataRow dataRow = base.TAINTable.NewRow();
			dataRow["ma_cty"] = CompanyInformations.CompanyID;
			dataRow["stt_rec"] = RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]);
			dataRow["stt_rec0"] = Commons.Get_SttRec0(Conversions.ToString(base.CurrentPHRow["stt_rec"]), base.TAINTable);
			dataRow["so_ct0"] = txtSo_Hd.Text.Trim();
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
			dataRow["ma_vt"] = RuntimeHelpers.GetObjectValue(item3["ma_vt"]);
			dataRow["ten_vt"] = RuntimeHelpers.GetObjectValue(item3["ten_vt"]);
			dataRow["tien_hang_nt"] = RuntimeHelpers.GetObjectValue(item3["tien_nt0"]);
			dataRow["tien_hang"] = RuntimeHelpers.GetObjectValue(item3["tien0"]);
			dataRow["t_tien_nt"] = RuntimeHelpers.GetObjectValue(item3["tien_nt0"]);
			dataRow["t_tien"] = RuntimeHelpers.GetObjectValue(item3["tien0"]);
			dataRow["thue_suat"] = RuntimeHelpers.GetObjectValue(item3["ts_gtgt"]);
			dataRow["t_thue_nt"] = RuntimeHelpers.GetObjectValue(item3["thue_gtgt_nt"]);
			dataRow["t_thue"] = RuntimeHelpers.GetObjectValue(item3["thue_gtgt"]);
			dataRow["ma_bp"] = RuntimeHelpers.GetObjectValue(item3["ma_bp"]);
			dataRow["ma_spct"] = RuntimeHelpers.GetObjectValue(item3["ma_spct"]);
			dataRow["thue_nk"] = RuntimeHelpers.GetObjectValue(item3["thue_nk"]);
			dataRow["thue_nk_nt"] = RuntimeHelpers.GetObjectValue(item3["thue_nk_nt"]);
			dataRow["thue_ttdb"] = RuntimeHelpers.GetObjectValue(item3["thue_ttdb"]);
			dataRow["thue_ttdb_nt"] = RuntimeHelpers.GetObjectValue(item3["thue_ttdb_nt"]);
			base.TAINTable.Rows.Add(dataRow);
		}
	}

	private void SetVatNk_To_TAIN()
	{
		if (Tain1Voucher == null || Tain1Voucher.Count <= 0 || false || base.ActionMode != Commons.ApplicationMode.ADD_MODE)
		{
			return;
		}
		foreach (DataRowView item in Tain1Voucher)
		{
			item["VAT_NK"] = 0;
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
		double gia_tri_dieu_chinh_toi_da = AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_toi_da;
		double gia_tri_dieu_chinh_tien_nt_toi_da = AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_tien_nt_toi_da;
		int num = AsiaErp.Framework.Environment.GetSIConfiguration().Round;
		int num2 = AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt;
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
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true), Operators.AddObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Nk_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Ttdb_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["cp_nt"]), isNum: true))), (object)100),
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
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Nk"]), isNum: true), Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["cp_nt"]), isNum: true))), (object)100),
				num2,
				MidpointRounding.AwayFromZero
			};
			object[] array6 = array4;
			array3 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array6, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA3 = Conversions.ToDouble(obj3);
			Type? typeFromHandle4 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Ttdb"]), isNum: true), Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Nk_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["cp_nt"]), isNum: true))), (object)100),
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
			double dbA4 = Conversions.ToDouble(obj4);
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
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia0"]), isNum: true)),
				null,
				null
			};
			object[] array9 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			array4 = array;
			object[] array10 = array4;
			array3 = new bool[3] { false, true, false };
			object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array10, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double num3 = Conversions.ToDouble(obj6);
			if (num3 == 0.0)
			{
				Type? typeFromHandle7 = typeof(Math);
				array4 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_nt0"]), isNum: true), txtTy_gia.Value),
					num,
					MidpointRounding.AwayFromZero
				};
				object[] array11 = array4;
				array3 = new bool[3] { false, true, false };
				object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle7, "Round", array11, (string[])null, (Type[])null, array3);
				if (array3[1])
				{
					num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
				}
				num3 = Conversions.ToDouble(obj7);
			}
			Type? typeFromHandle8 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Nk"]), isNum: true), Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["cp"]), isNum: true))), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array12 = array4;
			array3 = new bool[3] { false, true, false };
			object obj8 = NewLateBinding.LateGet((object)null, typeFromHandle8, "Round", array12, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double num4 = Conversions.ToDouble(obj8);
			if (num4 == 0.0)
			{
				Type? typeFromHandle9 = typeof(Math);
				array = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Nk_nt"]), isNum: true), txtTy_gia.Value),
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
				object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle9, "Round", array14, (string[])null, (Type[])null, array3);
				if (array3[1])
				{
					sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
				}
				num4 = Conversions.ToDouble(obj9);
			}
			Type? typeFromHandle10 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Ttdb"]), isNum: true), Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Nk"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["cp"]), isNum: true))), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array15 = array4;
			array3 = new bool[3] { false, true, false };
			object obj10 = NewLateBinding.LateGet((object)null, typeFromHandle10, "Round", array15, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double num5 = Conversions.ToDouble(obj10);
			if (num5 == 0.0)
			{
				Type? typeFromHandle11 = typeof(Math);
				array = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Ttdb_Nt"]), isNum: true), txtTy_gia.Value),
					null,
					null
				};
				object[] array16 = array;
				sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array16[1] = sIConfiguration.Round;
				array[2] = MidpointRounding.AwayFromZero;
				array4 = array;
				object[] array17 = array4;
				array3 = new bool[3] { false, true, false };
				object obj11 = NewLateBinding.LateGet((object)null, typeFromHandle11, "Round", array17, (string[])null, (Type[])null, array3);
				if (array3[1])
				{
					sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
				}
				odv["Thue_Ttdb"] = RuntimeHelpers.GetObjectValue(obj11);
			}
			Type? typeFromHandle12 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true), Operators.AddObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Nk"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Ttdb"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["cp"]), isNum: true))), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array18 = array4;
			array3 = new bool[3] { false, true, false };
			object obj12 = NewLateBinding.LateGet((object)null, typeFromHandle12, "Round", array18, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double num6 = Conversions.ToDouble(obj12);
			if (num6 == 0.0)
			{
				Type? typeFromHandle13 = typeof(Math);
				array = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Gtgt_Nt"]), isNum: true), txtTy_gia.Value),
					null,
					null
				};
				object[] array19 = array;
				sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array19[1] = sIConfiguration.Round;
				array[2] = MidpointRounding.AwayFromZero;
				array4 = array;
				object[] array20 = array4;
				array3 = new bool[3] { false, true, false };
				object obj13 = NewLateBinding.LateGet((object)null, typeFromHandle13, "Round", array20, (string[])null, (Type[])null, array3);
				if (array3[1])
				{
					sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
				}
				odv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj13);
			}
			RecipeABC(dgvcTien0, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien0"]), isNum: true)), num3, gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcTien_cp, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Cp"]), isNum: true)), dbB, gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_gtgt, num6, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_Nk, num4, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["thue_nk"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_Ttdb, num5, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["thue_ttdb"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcTien_nt0, dbA, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt0"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_gtgt_nt, dbA2, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_Nk_Nt, dbA3, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["thue_nk_nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_TtDb_Nt, dbA4, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["thue_ttdb_nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, index, Cmess, ref CmessGHDC);
		}
		else
		{
			Type? typeFromHandle14 = typeof(Math);
			object[] array4 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia_Nt0"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array21 = array4;
			bool[] array3 = new bool[3] { false, true, false };
			object obj14 = NewLateBinding.LateGet((object)null, typeFromHandle14, "Round", array21, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA5 = Conversions.ToDouble(obj14);
			Type? typeFromHandle15 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true), Operators.AddObject(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Nk_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Ttdb_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["cp_nt"]), isNum: true))), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array22 = array4;
			array3 = new bool[3] { false, true, false };
			object obj15 = NewLateBinding.LateGet((object)null, typeFromHandle15, "Round", array22, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA6 = Conversions.ToDouble(obj15);
			Type? typeFromHandle16 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Nk"]), isNum: true), Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["cp_nt"]), isNum: true))), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array23 = array4;
			array3 = new bool[3] { false, true, false };
			object obj16 = NewLateBinding.LateGet((object)null, typeFromHandle16, "Round", array23, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA7 = Conversions.ToDouble(obj16);
			Type? typeFromHandle17 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Ttdb"]), isNum: true), Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt0"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Nk_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["cp_nt"]), isNum: true))), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array24 = array4;
			array3 = new bool[3] { false, true, false };
			object obj17 = NewLateBinding.LateGet((object)null, typeFromHandle17, "Round", array24, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA8 = Conversions.ToDouble(obj17);
			RecipeABC(dgvcTien_nt0, dbA5, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt0"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_gtgt_nt, dbA6, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_Nk_Nt, dbA7, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["thue_nk_nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_TtDb_Nt, dbA8, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["thue_ttdb_nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
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
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_nk_Nt"]), isNum: true)),
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
			item["Thue_nk_Nt"] = RuntimeHelpers.GetObjectValue(obj6);
			Type? typeFromHandle7 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_ttdb_Nt"]), isNum: true)),
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
			item["Thue_ttdb_Nt"] = RuntimeHelpers.GetObjectValue(obj7);
			Type? typeFromHandle8 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["cp_nt"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array11 = array4;
			array3 = new bool[3] { false, true, false };
			object obj8 = NewLateBinding.LateGet((object)null, typeFromHandle8, "Round", array11, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			item["cp_nt"] = RuntimeHelpers.GetObjectValue(obj8);
			Type? typeFromHandle9 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tt_nt"]), isNum: true)),
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
			item["Tt_nt"] = RuntimeHelpers.GetObjectValue(obj9);
		}
		foreach (DataRowView item2 in base.CP1Voucher)
		{
			Type? typeFromHandle10 = typeof(Math);
			object[] array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp_nt"]), isNum: true)),
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
			item2["tien_cp_nt"] = RuntimeHelpers.GetObjectValue(obj10);
			Type? typeFromHandle11 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt_nt"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array14 = array4;
			array3 = new bool[3] { false, true, false };
			object obj11 = NewLateBinding.LateGet((object)null, typeFromHandle11, "Round", array14, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			item2["Thue_Gtgt_nt"] = RuntimeHelpers.GetObjectValue(obj11);
			Type? typeFromHandle12 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tt_nt"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array15 = array4;
			array3 = new bool[3] { false, true, false };
			object obj12 = NewLateBinding.LateGet((object)null, typeFromHandle12, "Round", array15, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			item2["Tt_nt"] = RuntimeHelpers.GetObjectValue(obj12);
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
				IEnumerable<VB_0024AnonymousType_5<object, decimal, decimal, object, object, object, object, object>> enumerable = from _0024VB_0024It in (from row in base.CTTable.AsEnumerable()
						where Operators.ConditionalCompareObjectEqual(row["Stt_Rec"], _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()["stt_rec"], false)
						select row).GroupBy([SpecialName] (DataRow row) => new VB_0024AnonymousType_3<object, object, object, object, object, object>(RuntimeHelpers.GetObjectValue(row["tk_vt"]), RuntimeHelpers.GetObjectValue(row["ma_hd"]), RuntimeHelpers.GetObjectValue(row["ma_bp"]), RuntimeHelpers.GetObjectValue(row["ma_phi"]), RuntimeHelpers.GetObjectValue(row["ma_spct"]), RuntimeHelpers.GetObjectValue(row["ma_lo"])), [SpecialName] (DataRow row) => row, [SpecialName] (VB_0024AnonymousType_3<object, object, object, object, object, object> _0024VB_0024Key, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_4<object, object, object, object, object, object, IEnumerable<DataRow>, decimal, decimal>(RuntimeHelpers.GetObjectValue(_0024VB_0024Key.tk), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_hd), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_bp), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_phi), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_spct), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_lo), _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien") ?? 0m)))
					select new VB_0024AnonymousType_5<object, decimal, decimal, object, object, object, object, object>(RuntimeHelpers.GetObjectValue(_0024VB_0024It.tk), _0024VB_0024It.ps_no_nt, _0024VB_0024It.ps_no, RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_hd), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_bp), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_phi), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_spct), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_lo));
				foreach (VB_0024AnonymousType_5<object, decimal, decimal, object, object, object, object, object> item in enumerable)
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
				IEnumerable<VB_0024AnonymousType_8<object, decimal, decimal, object, object, object>> enumerable2 = from _0024VB_0024It in (from row in base.TAINTable.AsEnumerable()
						where Operators.ConditionalCompareObjectEqual(row["Stt_Rec"], _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()["stt_rec"], false)
						select row).GroupBy([SpecialName] (DataRow row) => new VB_0024AnonymousType_6<object, object, object, object>(RuntimeHelpers.GetObjectValue(row["tk_thue_no"]), RuntimeHelpers.GetObjectValue(row["ma_bp"]), RuntimeHelpers.GetObjectValue(row["ma_spct"]), RuntimeHelpers.GetObjectValue(row["ma_lo"])), [SpecialName] (DataRow row) => row, [SpecialName] (VB_0024AnonymousType_6<object, object, object, object> _0024VB_0024Key, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_7<object, object, object, object, IEnumerable<DataRow>, decimal, decimal>(RuntimeHelpers.GetObjectValue(_0024VB_0024Key.tk), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_bp), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_spct), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_lo), _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("t_thue_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("t_thue") ?? 0m)))
					select new VB_0024AnonymousType_8<object, decimal, decimal, object, object, object>(RuntimeHelpers.GetObjectValue(_0024VB_0024It.tk), _0024VB_0024It.ps_no_nt, _0024VB_0024It.ps_no, RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_bp), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_spct), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_lo));
				foreach (VB_0024AnonymousType_8<object, decimal, decimal, object, object, object> item2 in enumerable2)
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

	protected override void InitOtherBeforeLoadData()
	{
		base.InitOtherBeforeLoadData();
		ArrayList arrayList = new ArrayList();
		DictionaryEntry dictionaryEntry = new DictionaryEntry("1", AsiaErp.Framework.Environment.getLangSysMessageResX("#POVCHPO4_TTPB_SOLUONG").value);
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("2", AsiaErp.Framework.Environment.getLangSysMessageResX("#POVCHPO4_TTPB_GIATRI").value);
		arrayList.Add(dictionaryEntry);
		bsTT_PB.DataSource = arrayList;
		dgvcTT_PB.DisplayMember = "Value";
		dgvcTT_PB.ValueMember = "Key";
		dgvcTT_PB.DataSource = bsTT_PB;
		cboMau_Hd.SelectedIndex = 0;
		f_sGia_header = ((DataGridViewColumn)dgvcGia_nt0).HeaderText;
		f_sTien_header = ((DataGridViewColumn)dgvcTien_nt_ht).HeaderText;
		f_sTien0_header = ((DataGridViewColumn)dgvcTien_nt0).HeaderText;
		f_sChi_phi_header = ((DataGridViewColumn)dgvcTien_cp_nt).HeaderText;
		f_sThue_header = ((DataGridViewColumn)dgvcThue_Gtgt_nt_cp).HeaderText;
		f_sTien0_cp_header = ((DataGridViewColumn)dgvcTien_nt0_ht).HeaderText;
		f_sThue_ttdb_header = ((DataGridViewColumn)dgvcThue_TtDb_Nt).HeaderText;
		f_sThue_Nk_header = ((DataGridViewColumn)dgvcThue_Nk_Nt).HeaderText;
		string ma_nt = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		((DataGridViewColumn)dgvcGia0).HeaderText = f_sGia_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien0).HeaderText = f_sTien0_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien_cp).HeaderText = f_sChi_phi_header + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_Ttdb).HeaderText = f_sThue_ttdb_header + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_Nk).HeaderText = f_sThue_Nk_header + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = f_sThue_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien_ht).HeaderText = f_sTien_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien0_ht).HeaderText = f_sTien0_cp_header + " " + ma_nt;
		((DataGridViewColumn)dgvcCp_ht).HeaderText = f_sChi_phi_header + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_Ttdb_Ht).HeaderText = f_sThue_ttdb_header + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_Nk_Ht).HeaderText = f_sThue_Nk_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien_cp_cp).HeaderText = f_sChi_phi_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTt_Cp).HeaderText = f_sTien_header + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_Gtgt_cp).HeaderText = f_sThue_header + " " + ma_nt;
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		base.PHTable.Columns["ma_gd"].DefaultValue = f_sMa_Gd_Default;
		base.PHTable.Columns["tao_tu_pn"].DefaultValue = false;
		base.PHTable.Columns["mau_hd"].DefaultValue = "0";
		base.CTTable.Columns["tk_thue"].DefaultValue = f_Tk_Thue;
		base.CTTable.Columns["tk_thue_nk"].DefaultValue = f_Tk_Thue_Nk;
		base.CTTable.Columns["tk_thue_ttdb"].DefaultValue = f_Tk_Thue_TtDb;
		base.CTTable.Columns["ts_nk"].DefaultValue = 0;
		base.CTTable.Columns["ts_ttdb"].DefaultValue = 0;
		base.CTTable.Columns["ts_gtgt"].DefaultValue = 0;
		base.CPTable.Columns["TT_PB"].DefaultValue = "1";
		((DataGridView)adgvHach_toan).DataSource = bsCT;
		((DataGridView)adgvChi_phi).DataSource = bsCP;
		ctlTaIn.DataSource = bsTain;
		ctlTaIn.TAINTable = base.TAINTable;
		AddControl2ListOfDrivedControls((Control)(object)cmdGetTaInFromDetail);
		AddControl2ListOfDrivedControls((Control)(object)ctlTaIn.chkKe_tain);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Tien_nt0);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tien_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_thue_Nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_cp_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tt_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Thue_Nk_Nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Thue_ttdb_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tt_nt_cp);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_thue_nt_cp);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Tien_Cp_nt_Cp);
		AddDGV(adgvChi_phi);
		AddDGV(adgvHach_toan);
		TyGia_cur = Conversions.ToDouble(txtTy_gia.Value);
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
				base.CurrentPHRow["ty_gia"] = RuntimeHelpers.GetObjectValue(txtTy_gia.Value);
			}
		}
		((Control)txtT_Tien0).Visible = flag;
		((Control)txtT_cp).Visible = flag;
		((Control)txtT_Tien).Visible = flag;
		((Control)txtT_Thue_nk).Visible = flag;
		((Control)txtT_Thue_Ttdb).Visible = flag;
		((Control)txtT_Thue).Visible = flag;
		((Control)txtT_tt).Visible = flag;
		((DataGridViewColumn)dgvcGia0).Visible = flag;
		((DataGridViewColumn)dgvcTien0).Visible = flag;
		((DataGridViewColumn)dgvcTien_cp).Visible = flag;
		((DataGridViewColumn)dgvcThue_Nk).Visible = flag;
		((DataGridViewColumn)dgvcThue_Ttdb).Visible = ((flag && hasTTDB) ? true : false);
		((DataGridViewColumn)dgvcThue_gtgt).Visible = ((flag && hasVATinDetal) ? true : false);
		((DataGridViewColumn)dgvcTien0_ht).Visible = flag;
		((DataGridViewColumn)dgvcCp_ht).Visible = flag;
		((DataGridViewColumn)dgvcTien_ht).Visible = flag;
		((DataGridViewColumn)dgvcThue_Nk_Ht).Visible = flag;
		((DataGridViewColumn)dgvcThue_Ttdb_Ht).Visible = ((flag && hasTTDB) ? true : false);
		((DataGridViewColumn)dgvcTien_cp_cp).Visible = flag;
		((DataGridViewColumn)dgvcThue_Gtgt_cp).Visible = flag;
		((DataGridViewColumn)dgvcTt_Cp).Visible = flag;
		((DataGridViewColumn)dgvcTs_gtgt).Visible = hasVATinDetal;
		((DataGridViewColumn)dgvcThue_gtgt_nt).Visible = hasVATinDetal;
		((DataGridViewColumn)dgvcTs_ttdb).Visible = hasTTDB;
		((DataGridViewColumn)dgvcThue_TtDb_Nt).Visible = hasTTDB;
		((DataGridViewColumn)dgvcThue_Ttdb_nt_Ht).Visible = hasTTDB;
		((DataGridViewColumn)dgvcTk_Thue_ttdb).Visible = hasTTDB;
		string mA_NT = cboMa_NT.MA_NT;
		((DataGridViewColumn)dgvcGia_nt0).HeaderText = f_sGia_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt0).HeaderText = f_sTien0_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_cp_nt).HeaderText = f_sChi_phi_header + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_TtDb_Nt).HeaderText = f_sThue_ttdb_header + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_Nk_Nt).HeaderText = f_sThue_Nk_header + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = f_sThue_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = f_sTien_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt0_ht).HeaderText = f_sTien0_cp_header + " " + mA_NT;
		((DataGridViewColumn)dgvcCp_Nt_ht).HeaderText = f_sChi_phi_header + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_Ttdb_nt_Ht).HeaderText = f_sThue_ttdb_header + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_Nk_Nt_Ht).HeaderText = f_sThue_Nk_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_cp_nt_cp).HeaderText = f_sChi_phi_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTt_nt_Cp).HeaderText = f_sTien_header + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_Gtgt_nt_cp).HeaderText = f_sThue_header + " " + mA_NT;
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
			txtT_Tien_nt0.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(tien_nt0)", filter));
			txtT_cp_nt.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(cp_nt)", filter));
			txtT_Thue_Nk_Nt.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(thue_nk_nt)", filter));
			txtT_Thue_ttdb_nt.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(thue_ttdb_nt)", filter));
			txtT_thue_Nt.Value = ctlTaIn.get_T_Thue_Nt("");
			txtT_Tien0.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(tien0)", filter));
			txtT_cp.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(cp)", filter));
			txtT_Thue_nk.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(thue_nk)", filter));
			txtT_Thue_Ttdb.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(thue_ttdb)", filter));
			txtT_Thue.Value = ctlTaIn.get_T_Thue("");
			txtT_Thue_nk.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(thue_nk)", filter));
			txtT_Thue_Ttdb.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(thue_ttdb)", filter));
			txtT_Tien.Value = Operators.AddObject(Operators.AddObject(Operators.AddObject(txtT_Tien0.Value, txtT_cp.Value), txtT_Thue_Ttdb.Value), txtT_Thue_nk.Value);
			txtT_tien_nt.Value = Operators.AddObject(Operators.AddObject(Operators.AddObject(txtT_Tien_nt0.Value, txtT_cp_nt.Value), txtT_Thue_Nk_Nt.Value), txtT_Thue_ttdb_nt.Value);
			txtT_tt.Value = Operators.AddObject(txtT_Tien.Value, txtT_Thue.Value);
			txtT_tt_nt.Value = Operators.AddObject(txtT_tien_nt.Value, txtT_thue_Nt.Value);
			txtT_So_luong.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(So_luong)", filter));
		}
	}

	protected override bool ValidData()
	{
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		setTk4Ct();
		SetVatNk_To_TAIN();
		ctlTaIn.Ma_Nt = cboMa_NT.MA_NT;
		ctlTaIn.Ty_Gia = Conversions.ToDouble(txtTy_gia.Value);
		bool flag = true;
		bool CmessGHDC = false;
		checked
		{
			if ((ChkEmtyTextBox((TextBox)(object)txtMa_Kh) && ChkEmtyTextBox((TextBox)(object)txtMa_Httt) && base.ValidData() && ctlTaIn.ValidData()) ? true : false)
			{
				bool flag2 = true;
				int num = CT1Voucher.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					DataRowView dataRowView = CT1Voucher[num2];
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
					if ((Operators.ConditionalCompareObjectGreater(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["thue_nk_nt"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_thue_nk"]), isNum: false), (object)"", false)) ? true : false)
					{
						return ValidGridHT(num2, dgvcTk_thue_nk, 50023);
					}
					if ((Operators.ConditionalCompareObjectGreater(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["thue_ttdb_nt"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_thue_ttdb"]), isNum: false), (object)"", false)) ? true : false)
					{
						return ValidGridHT(num2, dgvcTk_Thue_ttdb, 50023);
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
				if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(cp_nt)", filter)), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp_nt)", filter)), isNum: true), false) || (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(cp)", filter)), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp)", filter)), isNum: true), false) ? true : false))
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
		CreateDataBinding((Control)(object)cboMau_Hd, "mau_hd", "SelectedIndex");
		CreateDataBinding((Control)(object)txtMa_Kh, "Ma_Kh");
		CreateDataBinding((Control)(object)lblTen_Kh, "Ten_Kh");
		CreateDataBinding((Control)(object)txtDia_chi, "Dia_chi");
		CreateDataBinding((Control)(object)txtMa_so_thue, "Ma_so_thue");
		CreateDataBinding((Control)(object)txtNguoi_Gd, "Nguoi_Gd");
		CreateDataBinding((Control)(object)txtDien_giai, "Dien_Giai");
		CreateDataBinding((Control)(object)txtNgay_Ct, "ngay_ct", "Value");
		CreateDataBinding((Control)(object)txtSo_Ct, "so_ct");
		CreateDataBinding((Control)(object)txtNgay_lct, "ngay_lct", "Value");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)txtNgay_hd, "ngay_hd", "Value");
		CreateDataBinding((Control)(object)txtSo_Hd, "so_hd");
		CreateDataBinding((Control)(object)txtMa_Httt, "ma_httt");
		CreateDataBinding((Control)(object)lblTen_httt, "ten_httt");
		CreateDataBinding((Control)(object)txtTk_pt, "tk_pt");
		CreateDataBinding((Control)(object)txtT_tt, "T_tt", "Value");
		CreateDataBinding((Control)(object)txtT_tt_nt, "T_tt_nt", "Value");
		CreateDataBinding((Control)(object)txtT_Tien0, "T_Tien0", "Value");
		CreateDataBinding((Control)(object)txtT_Tien_nt0, "T_Tien_nt0", "Value");
		CreateDataBinding((Control)(object)txtT_cp_nt, "T_cp_nt", "Value");
		CreateDataBinding((Control)(object)txtT_cp, "T_cp", "Value");
		CreateDataBinding((Control)(object)txtT_Thue, "T_Thue", "Value");
		CreateDataBinding((Control)(object)txtT_thue_Nt, "T_thue_Nt", "Value");
		CreateDataBinding((Control)(object)txtT_Tien, "T_Tien", "Value");
		CreateDataBinding((Control)(object)txtT_tien_nt, "T_tien_nt", "Value");
		CreateDataBinding((Control)(object)txtT_Thue_nk, "T_Thue_nk", "Value");
		CreateDataBinding((Control)(object)txtT_Thue_Nk_Nt, "T_Thue_nk_nt", "Value");
		CreateDataBinding((Control)(object)txtT_Thue_Ttdb, "T_Thue_ttdb", "Value");
		CreateDataBinding((Control)(object)txtT_Thue_ttdb_nt, "T_Thue_ttdb_nt", "Value");
		CreateDataBinding((Control)(object)txtT_So_luong, "T_So_luong", "Value");
		CreateDataBinding((Control)(object)ctlTaIn.chkKe_tain, "kht_tain", "Checked");
	}

	protected override void SetPHDefaultValues(DataRow drwPh)
	{
		drwPh["ngay_lct"] = RuntimeHelpers.GetObjectValue(drwPh["ngay_ct"]);
		drwPh["ngay_hd"] = RuntimeHelpers.GetObjectValue(drwPh["ngay_ct"]);
	}

	protected override void SaveData2Datatable()
	{
		if (!hasVATinDetal)
		{
			Calc_ThueVAT();
		}
	}

	protected override void Cancel()
	{
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

	[SpecialName]
	[DebuggerNonUserCode]
	protected DataRow _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()
	{
		return base.CurrentPHRow;
	}
}
