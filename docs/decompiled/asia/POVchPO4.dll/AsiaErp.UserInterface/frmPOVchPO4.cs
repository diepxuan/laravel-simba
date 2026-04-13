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
public class frmPOVchPO4 : frmVoucher
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

	[AccessedThroughProperty("cmdChon_dh")]
	private Button _cmdChon_dh;

	[AccessedThroughProperty("tabHach_toan")]
	private TabPage _tabHach_toan;

	[AccessedThroughProperty("adgvHach_toan")]
	private AsInputDGV _adgvHach_toan;

	[AccessedThroughProperty("txtT_cp_nt")]
	private AsTextNumeric _txtT_cp_nt;

	[AccessedThroughProperty("txtT_cp")]
	private AsTextNumeric _txtT_cp;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("lblTen_httt")]
	private Label _lblTen_httt;

	[AccessedThroughProperty("txtMa_Httt")]
	private AsTextBox _txtMa_Httt;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("tabTain")]
	private TabPage _tabTain;

	[AccessedThroughProperty("adgvChi_phi")]
	private AsInputDGV _adgvChi_phi;

	[AccessedThroughProperty("ctlTaIn")]
	private ctlTaIn _ctlTaIn;

	[AccessedThroughProperty("cmdPhan_bo")]
	private Button _cmdPhan_bo;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtT_tt")]
	private AsTextNumeric _txtT_tt;

	[AccessedThroughProperty("txtT_tt_nt")]
	private AsTextNumeric _txtT_tt_nt;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtTien_Cp_Pb_nt")]
	private AsTextNumeric _txtTien_Cp_Pb_nt;

	[AccessedThroughProperty("txtTien_cp_pb")]
	private AsTextNumeric _txtTien_cp_pb;

	[AccessedThroughProperty("txtT_thue_Nt")]
	private AsTextNumeric _txtT_thue_Nt;

	[AccessedThroughProperty("txtT_Thue")]
	private AsTextNumeric _txtT_Thue;

	[AccessedThroughProperty("cmdGetTaInFromDetail")]
	private Button _cmdGetTaInFromDetail;

	[AccessedThroughProperty("bsTT_PB")]
	private BindingSource _bsTT_PB;

	[AccessedThroughProperty("dgvcTen_vt_ht")]
	private DataGridViewTextBoxColumn _dgvcTen_vt_ht;

	[AccessedThroughProperty("dgvcTien_nt0_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt0_ht;

	[AccessedThroughProperty("dgvcCp_Nt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcCp_Nt_ht;

	[AccessedThroughProperty("dgvcTien_nt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt_ht;

	[AccessedThroughProperty("dgvcTien0_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien0_ht;

	[AccessedThroughProperty("dgvcCp_ht")]
	private DataGridViewAsTextNumericColumn _dgvcCp_ht;

	[AccessedThroughProperty("dgvcTien_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_ht;

	[AccessedThroughProperty("dgvcTk_vt")]
	private DataGridViewAsTextBoxColumn _dgvcTk_vt;

	[AccessedThroughProperty("dgvcTk_co")]
	private DataGridViewAsTextBoxColumn _dgvcTk_co;

	[AccessedThroughProperty("dgvcMa_vt_ht")]
	private DataGridViewTextBoxColumn _dgvcMa_vt_ht;

	[AccessedThroughProperty("dgvcMa_chiphi")]
	private DataGridViewAsTextBoxColumn _dgvcMa_chiphi;

	[AccessedThroughProperty("dgvcTT_PB")]
	private DataGridViewComboBoxColumn _dgvcTT_PB;

	[AccessedThroughProperty("dgvcTen_chi_phi")]
	private DataGridViewTextBoxColumn _dgvcTen_chi_phi;

	[AccessedThroughProperty("dgvcTien_cp_nt_cp")]
	private DataGridViewAsTextNumericColumn _dgvcTien_cp_nt_cp;

	[AccessedThroughProperty("dgvcTs_Gtgt")]
	private DataGridViewAsTextNumericColumn _dgvcTs_Gtgt;

	[AccessedThroughProperty("dgvcThue_gtgt_nt_cp")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt_nt_cp;

	[AccessedThroughProperty("dgvcTt_nt_cp")]
	private DataGridViewAsTextNumericColumn _dgvcTt_nt_cp;

	[AccessedThroughProperty("dgvcTien_cp_cp")]
	private DataGridViewAsTextNumericColumn _dgvcTien_cp_cp;

	[AccessedThroughProperty("dgvcThue_gtgt_cp")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt_cp;

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

	[AccessedThroughProperty("scChiPhi")]
	private SplitContainer _scChiPhi;

	[AccessedThroughProperty("dgvcMa_vt")]
	private DataGridViewAsTextBoxColumn _dgvcMa_vt;

	[AccessedThroughProperty("dgvcTen_vt")]
	private DataGridViewTextBoxColumn _dgvcTen_vt;

	[AccessedThroughProperty("dgvcDvt")]
	private DataGridViewTextBoxColumn _dgvcDvt;

	[AccessedThroughProperty("dgvcMa_kho")]
	private DataGridViewAsTextBoxColumn _dgvcMa_kho;

	[AccessedThroughProperty("dgvcSo_luong")]
	private DataGridViewAsTextNumericColumn _dgvcSo_luong;

	[AccessedThroughProperty("dgvcMa_nt")]
	private DataGridViewTextBoxColumn _dgvcMa_nt;

	[AccessedThroughProperty("dgvcTien_nt0")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt0;

	[AccessedThroughProperty("dgvcCp_nt")]
	private DataGridViewAsTextNumericColumn _dgvcCp_nt;

	[AccessedThroughProperty("dgvcTien0")]
	private DataGridViewAsTextNumericColumn _dgvcTien0;

	[AccessedThroughProperty("dgvcCp")]
	private DataGridViewAsTextNumericColumn _dgvcCp;

	[AccessedThroughProperty("dgvSo_pn")]
	private DataGridViewTextBoxColumn _dgvSo_pn;

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

	[AccessedThroughProperty("txtTk_pt")]
	private AsTextBox _txtTk_pt;

	[AccessedThroughProperty("lblTk_pt")]
	private Label _lblTk_pt;

	[AccessedThroughProperty("lblTk_thue")]
	private Label _lblTk_thue;

	[AccessedThroughProperty("txtTk_thue")]
	private AsTextBox _txtTk_thue;

	[AccessedThroughProperty("cmdThanh_toan")]
	private Button _cmdThanh_toan;

	private string f_sMa_kh;

	private string f_sTien0_header;

	private string f_sTien_header;

	private string f_sTien0_cp_header;

	private string f_sChi_phi_header;

	private string f_sThue_header;

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
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellEnter -= val;
				((DataGridView)_adgvDetail).CellValueChanged -= val2;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellEnter += val;
				((DataGridView)_adgvDetail).CellValueChanged += val2;
			}
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

	internal virtual AsTextNumeric txtTien_Cp_Pb_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_Cp_Pb_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTien_Cp_Pb_nt = value;
		}
	}

	internal virtual AsTextNumeric txtTien_cp_pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_cp_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTien_cp_pb = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcTs_Gtgt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTs_Gtgt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTs_Gtgt = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcTt_nt_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTt_nt_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTt_nt_cp = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_gtgt_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_gtgt_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_gtgt_cp = value;
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

	internal virtual SplitContainer scChiPhi
	{
		[DebuggerNonUserCode]
		get
		{
			return _scChiPhi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_scChiPhi = value;
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

	internal virtual DataGridViewTextBoxColumn dgvcMa_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_nt = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcCp_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCp_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCp_nt = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcCp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCp = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvSo_pn
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvSo_pn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvSo_pn = value;
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

	public frmPOVchPO4()
	{
		__ENCAddToList(this);
		f_sMa_kh = "";
		f_sTien0_header = "Tien";
		f_sTien_header = "Tien";
		f_sTien0_cp_header = "Tien";
		f_sChi_phi_header = "Chi phi";
		f_sThue_header = "VAT";
		InitializeComponent();
	}

	public frmPOVchPO4(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_sMa_kh = "";
		f_sTien0_header = "Tien";
		f_sTien_header = "Tien";
		f_sTien0_cp_header = "Tien";
		f_sChi_phi_header = "Chi phi";
		f_sThue_header = "VAT";
		InitializeComponent();
	}

	public frmPOVchPO4(string MenuID, string Stt_rec)
		: base(MenuID, Stt_rec)
	{
		__ENCAddToList(this);
		f_sMa_kh = "";
		f_sTien0_header = "Tien";
		f_sTien_header = "Tien";
		f_sTien0_cp_header = "Tien";
		f_sChi_phi_header = "Chi phi";
		f_sThue_header = "VAT";
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
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
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
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected O, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected O, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		//IL_1582: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f7: Expected O, but got Unknown
		//IL_181f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1829: Expected O, but got Unknown
		//IL_18e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ec: Expected O, but got Unknown
		//IL_2304: Unknown result type (might be due to invalid IL or missing references)
		//IL_230e: Expected O, but got Unknown
		//IL_23fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2406: Expected O, but got Unknown
		//IL_252e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2538: Expected O, but got Unknown
		//IL_2641: Unknown result type (might be due to invalid IL or missing references)
		//IL_264b: Expected O, but got Unknown
		//IL_2704: Unknown result type (might be due to invalid IL or missing references)
		//IL_270e: Expected O, but got Unknown
		//IL_2ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_307a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3084: Expected O, but got Unknown
		//IL_3181: Unknown result type (might be due to invalid IL or missing references)
		//IL_318b: Expected O, but got Unknown
		//IL_3244: Unknown result type (might be due to invalid IL or missing references)
		//IL_324e: Expected O, but got Unknown
		//IL_3c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c62: Expected O, but got Unknown
		//IL_3d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d6a: Expected O, but got Unknown
		//IL_3e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e6e: Expected O, but got Unknown
		//IL_414f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4270: Unknown result type (might be due to invalid IL or missing references)
		//IL_4324: Unknown result type (might be due to invalid IL or missing references)
		//IL_432e: Expected O, but got Unknown
		//IL_43e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_43f2: Expected O, but got Unknown
		//IL_44f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_44fa: Expected O, but got Unknown
		//IL_45f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_45fe: Expected O, but got Unknown
		//IL_46b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_46c2: Expected O, but got Unknown
		//IL_47c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_47ca: Expected O, but got Unknown
		//IL_4a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a80: Expected O, but got Unknown
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmPOVchPO4));
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
		scChiPhi = new SplitContainer();
		adgvChi_phi = new AsInputDGV();
		dgvcMa_chiphi = new DataGridViewAsTextBoxColumn();
		dgvcTT_PB = new DataGridViewComboBoxColumn();
		dgvcTen_chi_phi = new DataGridViewTextBoxColumn();
		dgvcTien_cp_nt_cp = new DataGridViewAsTextNumericColumn();
		dgvcTs_Gtgt = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt_nt_cp = new DataGridViewAsTextNumericColumn();
		dgvcTt_nt_cp = new DataGridViewAsTextNumericColumn();
		dgvcTien_cp_cp = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt_cp = new DataGridViewAsTextNumericColumn();
		dgvcTt_Cp = new DataGridViewAsTextNumericColumn();
		dgvcMa_bp_cp = new DataGridViewAsTextBoxColumn();
		dgvcMa_phi_cp = new DataGridViewAsTextBoxColumn();
		dgvcMa_spct_cp = new DataGridViewAsTextBoxColumn();
		dgvcMa_lo_cp = new DataGridViewAsTextBoxColumn();
		cmdPhan_bo = new Button();
		txtTien_Cp_Pb_nt = new AsTextNumeric();
		txtTien_cp_pb = new AsTextNumeric();
		adgvDetail = new AsInputDGV();
		dgvcMa_vt = new DataGridViewAsTextBoxColumn();
		dgvcTen_vt = new DataGridViewTextBoxColumn();
		dgvcDvt = new DataGridViewTextBoxColumn();
		dgvcMa_kho = new DataGridViewAsTextBoxColumn();
		dgvcSo_luong = new DataGridViewAsTextNumericColumn();
		dgvcMa_nt = new DataGridViewTextBoxColumn();
		dgvcTien_nt0 = new DataGridViewAsTextNumericColumn();
		dgvcCp_nt = new DataGridViewAsTextNumericColumn();
		dgvcTien0 = new DataGridViewAsTextNumericColumn();
		dgvcCp = new DataGridViewAsTextNumericColumn();
		dgvSo_pn = new DataGridViewTextBoxColumn();
		cmdChon_dh = new Button();
		tabHach_toan = new TabPage();
		SplitContainer1 = new SplitContainer();
		adgvHach_toan = new AsInputDGV();
		dgvcTen_vt_ht = new DataGridViewTextBoxColumn();
		dgvcTien_nt0_ht = new DataGridViewAsTextNumericColumn();
		dgvcCp_Nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien0_ht = new DataGridViewAsTextNumericColumn();
		dgvcCp_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_ht = new DataGridViewAsTextNumericColumn();
		dgvcTk_vt = new DataGridViewAsTextBoxColumn();
		dgvcTk_co = new DataGridViewAsTextBoxColumn();
		dgvcMa_vt_ht = new DataGridViewTextBoxColumn();
		txtTk_pt = new AsTextBox();
		lblTk_pt = new Label();
		lblTk_thue = new Label();
		txtTk_thue = new AsTextBox();
		txtT_cp_nt = new AsTextNumeric();
		txtT_cp = new AsTextNumeric();
		Label7 = new Label();
		lblTen_httt = new Label();
		txtMa_Httt = new AsTextBox();
		Label2 = new Label();
		tabTain = new TabPage();
		cmdGetTaInFromDetail = new Button();
		ctlTaIn = new ctlTaIn();
		Label8 = new Label();
		txtT_tt = new AsTextNumeric();
		txtT_tt_nt = new AsTextNumeric();
		Label1 = new Label();
		txtT_thue_Nt = new AsTextNumeric();
		txtT_Thue = new AsTextNumeric();
		bsTT_PB = new BindingSource(components);
		lblDia_chi = new Label();
		txtDia_chi = new TextBox();
		lblMa_so_thue = new Label();
		txtMa_so_thue = new TextBox();
		cmdThanh_toan = new Button();
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
		((Control)scChiPhi.Panel1).SuspendLayout();
		((Control)scChiPhi.Panel2).SuspendLayout();
		((Control)scChiPhi).SuspendLayout();
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
		Point location = new Point(3, 447);
		((Control)obj).Location = location;
		Button obj2 = cmdPrint;
		location = new Point(73, 447);
		((Control)obj2).Location = location;
		Button obj3 = cmdLast;
		location = new Point(733, 447);
		((Control)obj3).Location = location;
		((Control)cmdLast).TabIndex = 12;
		Button obj4 = cmdNext;
		location = new Point(708, 447);
		((Control)obj4).Location = location;
		((Control)cmdNext).TabIndex = 11;
		Button obj5 = cmdPrevious;
		location = new Point(683, 447);
		((Control)obj5).Location = location;
		((Control)cmdPrevious).TabIndex = 10;
		Button obj6 = cmdFirst;
		location = new Point(658, 447);
		((Control)obj6).Location = location;
		((Control)cmdFirst).TabIndex = 9;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(573, 43);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct;
		Size size = new Size(35, 13);
		((Control)obj8).Size = size;
		lblSo_Ct.Text = "Số pn";
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		Label obj9 = lblNgay_Ct;
		location = new Point(573, 17);
		((Control)obj9).Location = location;
		Label obj10 = lblNgay_Ct;
		size = new Size(47, 13);
		((Control)obj10).Size = size;
		lblNgay_Ct.Text = "Ngày pn";
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)5;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(666, 13);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay_Ct).TabIndex = 6;
		((Control)gbPH).Controls.Add((Control)(object)lblMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)lblDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)txtDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_httt);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Httt);
		((Control)gbPH).Controls.Add((Control)(object)Label2);
		((Control)gbPH).Controls.Add((Control)(object)cmdChon_dh);
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
		size = new Size(753, 145);
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
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cmdChon_dh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_so_thue, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(577, 447);
		((Control)splitButton).Location = location;
		((Control)cmdSearch).TabIndex = 8;
		((Control)AsTabControl).Controls.Add((Control)(object)tabChi_phi);
		((Control)AsTabControl).Controls.Add((Control)(object)tabHach_toan);
		((Control)AsTabControl).Controls.Add((Control)(object)tabTain);
		AsTabControl asTabControl = AsTabControl;
		location = new Point(0, 145);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(759, 226);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabTain, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabHach_toan, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabChi_phi, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabOptFields, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabDetail, 0);
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj13 = tabDetail;
		size = new Size(751, 197);
		((Control)obj13).Size = size;
		TabPage obj14 = tabOptFields;
		size = new Size(751, 197);
		((Control)obj14).Size = size;
		Button obj15 = cmdCopy;
		location = new Point(353, 447);
		((Control)obj15).Location = location;
		((Control)cmdCopy).TabIndex = 7;
		Button obj16 = cmdDelete;
		location = new Point(283, 447);
		((Control)obj16).Location = location;
		((Control)cmdDelete).TabIndex = 6;
		Button obj17 = cmdEdit;
		location = new Point(213, 447);
		((Control)obj17).Location = location;
		((Control)cmdEdit).TabIndex = 5;
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		TextBox obj18 = txtSo_Ct;
		location = new Point(666, 39);
		((Control)obj18).Location = location;
		((Control)txtSo_Ct).TabIndex = 7;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(118, 13);
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
		txtMa_Kh.ValidReturnFieldList = "tk,ten_kh,dia_chi,ma_so_thue,nguoi_gd,tel,gh_no,ma_httt_po";
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj19 = lblTen_Kh;
		location = new Point(200, 17);
		((Control)obj19).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj20 = lblTen_Kh;
		size = new Size(343, 13);
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
		location = new Point(8, 68);
		((Control)obj23).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj24 = lblNguoi_Gd;
		size = new Size(71, 14);
		((Control)obj24).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 143;
		lblNguoi_Gd.Text = "Người bán";
		TextBox obj25 = txtDien_giai;
		location = new Point(118, 91);
		((Control)obj25).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj26 = txtDien_giai;
		size = new Size(425, 20);
		((Control)obj26).Size = size;
		((Control)txtDien_giai).TabIndex = 4;
		TextBox obj27 = txtNguoi_Gd;
		location = new Point(118, 65);
		((Control)obj27).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj28 = txtNguoi_Gd;
		size = new Size(145, 20);
		((Control)obj28).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 2;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj29 = lblDien_giai;
		location = new Point(8, 95);
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
		location = new Point(666, 65);
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
		location = new Point(573, 69);
		((Control)obj31).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj32 = lblNgay_Lct;
		size = new Size(49, 13);
		((Control)obj32).Size = size;
		((Control)lblNgay_Lct).TabIndex = 234;
		lblNgay_Lct.Text = "Ngày lập";
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(675, 91);
		((Control)asTextNumeric).Location = location;
		txtTy_gia.Mask = "### ###.##";
		((Control)txtTy_gia).Name = "txtTy_gia";
		AsTextNumeric asTextNumeric2 = txtTy_gia;
		size = new Size(69, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTy_gia).TabIndex = 10;
		((TextBox)txtTy_gia).Text = "0.00";
		((TextBox)txtTy_gia).TextAlign = (HorizontalAlignment)1;
		txtTy_gia.Value = 0.0;
		((ComboBox)cboMa_NT).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboMa_NT).Enabled = false;
		((ListControl)cboMa_NT).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_NT;
		location = new Point(625, 91);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(47, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 9;
		lblMa_Nt.AutoSize = true;
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj33 = lblMa_Nt;
		location = new Point(573, 95);
		((Control)obj33).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj34 = lblMa_Nt;
		size = new Size(36, 13);
		((Control)obj34).Size = size;
		((Control)lblMa_Nt).TabIndex = 237;
		lblMa_Nt.Text = "Tỷ giá";
		tabChi_phi.BackColor = SystemColors.Control;
		((Control)tabChi_phi).Controls.Add((Control)(object)scChiPhi);
		TabPage obj35 = tabChi_phi;
		location = new Point(4, 25);
		obj35.Location = location;
		((Control)tabChi_phi).Name = "tabChi_phi";
		TabPage obj36 = tabChi_phi;
		Padding val37 = default(Padding);
		((Padding)(ref val37))._002Ector(3);
		((Control)obj36).Padding = val37;
		TabPage obj37 = tabChi_phi;
		size = new Size(751, 197);
		((Control)obj37).Size = size;
		tabChi_phi.TabIndex = 7;
		tabChi_phi.Text = "Chi &phí";
		scChiPhi.Dock = (DockStyle)5;
		scChiPhi.FixedPanel = (FixedPanel)2;
		SplitContainer obj38 = scChiPhi;
		location = new Point(3, 3);
		((Control)obj38).Location = location;
		((Control)scChiPhi).Name = "scChiPhi";
		scChiPhi.Orientation = (Orientation)0;
		((Control)scChiPhi.Panel1).Controls.Add((Control)(object)adgvChi_phi);
		((Control)scChiPhi.Panel2).Controls.Add((Control)(object)cmdPhan_bo);
		SplitContainer obj39 = scChiPhi;
		size = new Size(745, 191);
		((Control)obj39).Size = size;
		scChiPhi.SplitterDistance = 160;
		((Control)scChiPhi).TabIndex = 261;
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
			dgvcTs_Gtgt,
			dgvcThue_gtgt_nt_cp,
			dgvcTt_nt_cp,
			dgvcTien_cp_cp,
			dgvcThue_gtgt_cp,
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
		size = new Size(745, 160);
		((Control)asInputDGV2).Size = size;
		((Control)adgvChi_phi).TabIndex = 1;
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
		((DataGridViewColumn)dgvcTT_PB).HeaderText = "Tiêu thức phân bổ";
		((DataGridViewColumn)dgvcTT_PB).Name = "dgvcTT_PB";
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
		((DataGridViewColumn)dgvcTs_Gtgt).DataPropertyName = "ts_gtgt";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_Gtgt).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcTs_Gtgt).HeaderText = "%VAT";
		dgvcTs_Gtgt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTs_Gtgt).Name = "dgvcTs_Gtgt";
		dgvcTs_Gtgt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTs_Gtgt).Width = 40;
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
		((DataGridViewColumn)dgvcTt_nt_cp).DataPropertyName = "tt_nt";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTt_nt_cp).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcTt_nt_cp).HeaderText = "Tổng tiền";
		dgvcTt_nt_cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTt_nt_cp).Name = "dgvcTt_nt_cp";
		dgvcTt_nt_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTt_nt_cp.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTt_nt_cp).Width = 90;
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
		((DataGridViewColumn)dgvcThue_gtgt_cp).DataPropertyName = "thue_gtgt";
		val10.Alignment = (DataGridViewContentAlignment)64;
		val10.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_cp).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcThue_gtgt_cp).HeaderText = "VAT VNĐ";
		dgvcThue_gtgt_cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_cp).Name = "dgvcThue_gtgt_cp";
		((DataGridViewColumn)dgvcThue_gtgt_cp).ReadOnly = true;
		dgvcThue_gtgt_cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_cp.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTt_Cp).DataPropertyName = "tt";
		val11.Alignment = (DataGridViewContentAlignment)64;
		val11.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTt_Cp).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcTt_Cp).HeaderText = "Tổng tiền VNĐ";
		dgvcTt_Cp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTt_Cp).Name = "dgvcTt_Cp";
		dgvcTt_Cp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTt_Cp.SpecialType = Commons.NumericSpecialType.ACAmount;
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
		((Control)cmdPhan_bo).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdPhan_bo).FlatStyle = (FlatStyle)1;
		Button obj40 = cmdPhan_bo;
		location = new Point(664, 3);
		((Control)obj40).Location = location;
		((Control)cmdPhan_bo).Name = "cmdPhan_bo";
		Button obj41 = cmdPhan_bo;
		size = new Size(78, 20);
		((Control)obj41).Size = size;
		((Control)cmdPhan_bo).TabIndex = 258;
		((ButtonBase)cmdPhan_bo).Text = "Phân &bổ";
		txtTien_Cp_Pb_nt.DecimalSymbol = ".";
		((Control)txtTien_Cp_Pb_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtTien_Cp_Pb_nt;
		location = new Point(105, 395);
		((Control)asTextNumeric3).Location = location;
		txtTien_Cp_Pb_nt.Mask = "### ### ### ###";
		((Control)txtTien_Cp_Pb_nt).Name = "txtTien_Cp_Pb_nt";
		((TextBoxBase)txtTien_Cp_Pb_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtTien_Cp_Pb_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtTien_Cp_Pb_nt).TabIndex = 260;
		((Control)txtTien_Cp_Pb_nt).TabStop = false;
		((TextBox)txtTien_Cp_Pb_nt).Text = "0";
		((TextBox)txtTien_Cp_Pb_nt).TextAlign = (HorizontalAlignment)1;
		txtTien_Cp_Pb_nt.Value = 0.0;
		((Control)txtTien_Cp_Pb_nt).Visible = false;
		txtTien_cp_pb.DecimalSymbol = ".";
		((Control)txtTien_cp_pb).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric5 = txtTien_cp_pb;
		location = new Point(123, 421);
		((Control)asTextNumeric5).Location = location;
		txtTien_cp_pb.Mask = "### ### ### ###";
		((Control)txtTien_cp_pb).Name = "txtTien_cp_pb";
		((TextBoxBase)txtTien_cp_pb).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtTien_cp_pb;
		size = new Size(97, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtTien_cp_pb).TabIndex = 259;
		((Control)txtTien_cp_pb).TabStop = false;
		((TextBox)txtTien_cp_pb).Text = "0";
		((TextBox)txtTien_cp_pb).TextAlign = (HorizontalAlignment)1;
		txtTien_cp_pb.Value = 0.0;
		((Control)txtTien_cp_pb).Visible = false;
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
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[11]
		{
			dgvcMa_vt,
			(DataGridViewColumn)dgvcTen_vt,
			(DataGridViewColumn)dgvcDvt,
			dgvcMa_kho,
			dgvcSo_luong,
			(DataGridViewColumn)dgvcMa_nt,
			dgvcTien_nt0,
			dgvcCp_nt,
			dgvcTien0,
			dgvcCp,
			(DataGridViewColumn)dgvSo_pn
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
		size = new Size(745, 191);
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
		((DataGridViewColumn)dgvcMa_vt).ReadOnly = true;
		dgvcMa_vt.ReceiverValidFieldList = "ten_vt,dvt,tk_vt,tk_gv,tk_dt,tk_ck,ton_kho,gia_ton";
		dgvcMa_vt.SD = true;
		dgvcMa_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_vt.ValidReturnFieldList = "ten_vt,dvt,tk_vt,tk_gv,tk_dt,tk_ck,ton_kho,gia_ton";
		((DataGridViewColumn)dgvcMa_vt).Width = 80;
		((DataGridViewColumn)dgvcTen_vt).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vt).HeaderText = "Tên hàng";
		dgvcTen_vt.MaxInputLength = 128;
		((DataGridViewColumn)dgvcTen_vt).Name = "dgvcTen_vt";
		((DataGridViewColumn)dgvcTen_vt).ReadOnly = true;
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
		((DataGridViewColumn)dgvcMa_kho).ReadOnly = true;
		dgvcMa_kho.ReceiverValidFieldList = "ten_kho";
		dgvcMa_kho.SD = true;
		dgvcMa_kho.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_kho.ValidReturnFieldList = "ten_kho";
		((DataGridViewColumn)dgvcMa_kho).Width = 65;
		((DataGridViewColumn)dgvcSo_luong).DataPropertyName = "so_luong";
		val21.Alignment = (DataGridViewContentAlignment)64;
		val21.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).DefaultCellStyle = val21;
		((DataGridViewColumn)dgvcSo_luong).HeaderText = "Số lượng";
		dgvcSo_luong.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).Name = "dgvcSo_luong";
		((DataGridViewColumn)dgvcSo_luong).ReadOnly = true;
		dgvcSo_luong.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSo_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcSo_luong).Width = 70;
		((DataGridViewColumn)dgvcMa_nt).DataPropertyName = "ma_nt";
		((DataGridViewColumn)dgvcMa_nt).HeaderText = "Mã NT";
		((DataGridViewColumn)dgvcMa_nt).Name = "dgvcMa_nt";
		((DataGridViewColumn)dgvcMa_nt).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_nt).Width = 70;
		((DataGridViewColumn)dgvcTien_nt0).DataPropertyName = "tien_nt0";
		val22.Alignment = (DataGridViewContentAlignment)64;
		val22.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt0).DefaultCellStyle = val22;
		((DataGridViewColumn)dgvcTien_nt0).HeaderText = "Thành tiền";
		dgvcTien_nt0.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt0).Name = "dgvcTien_nt0";
		((DataGridViewColumn)dgvcTien_nt0).ReadOnly = true;
		dgvcTien_nt0.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt0.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt0).Width = 90;
		((DataGridViewColumn)dgvcCp_nt).DataPropertyName = "cp_nt";
		val23.Alignment = (DataGridViewContentAlignment)64;
		val23.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_nt).DefaultCellStyle = val23;
		((DataGridViewColumn)dgvcCp_nt).HeaderText = "Chi phí";
		dgvcCp_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_nt).Name = "dgvcCp_nt";
		dgvcCp_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcCp_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcCp_nt).Width = 82;
		((DataGridViewColumn)dgvcTien0).DataPropertyName = "tien0";
		val24.Alignment = (DataGridViewContentAlignment)64;
		val24.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien0).DefaultCellStyle = val24;
		((DataGridViewColumn)dgvcTien0).HeaderText = "Tiền VNĐ";
		dgvcTien0.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien0).Name = "dgvcTien0";
		((DataGridViewColumn)dgvcTien0).ReadOnly = true;
		dgvcTien0.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien0.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien0).Width = 90;
		((DataGridViewColumn)dgvcCp).DataPropertyName = "cp";
		val25.Alignment = (DataGridViewContentAlignment)64;
		val25.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp).DefaultCellStyle = val25;
		((DataGridViewColumn)dgvcCp).HeaderText = "CP VNĐ";
		dgvcCp.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp).Name = "dgvcCp";
		dgvcCp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcCp.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcCp).Width = 82;
		((DataGridViewColumn)dgvSo_pn).DataPropertyName = "so_pn";
		((DataGridViewColumn)dgvSo_pn).HeaderText = "Số PN";
		((DataGridViewColumn)dgvSo_pn).Name = "dgvSo_pn";
		((DataGridViewColumn)dgvSo_pn).ReadOnly = true;
		((DataGridViewColumn)dgvSo_pn).Width = 80;
		((ButtonBase)cmdChon_dh).FlatStyle = (FlatStyle)1;
		Button obj42 = cmdChon_dh;
		location = new Point(625, 116);
		((Control)obj42).Location = location;
		((Control)cmdChon_dh).Name = "cmdChon_dh";
		Button obj43 = cmdChon_dh;
		size = new Size(119, 23);
		((Control)obj43).Size = size;
		((Control)cmdChon_dh).TabIndex = 11;
		((ButtonBase)cmdChon_dh).Text = "Chọ&n HĐ";
		tabHach_toan.BackColor = SystemColors.Control;
		((Control)tabHach_toan).Controls.Add((Control)(object)SplitContainer1);
		TabPage obj44 = tabHach_toan;
		location = new Point(4, 25);
		obj44.Location = location;
		((Control)tabHach_toan).Name = "tabHach_toan";
		TabPage obj45 = tabHach_toan;
		((Padding)(ref val37))._002Ector(3);
		((Control)obj45).Padding = val37;
		TabPage obj46 = tabHach_toan;
		size = new Size(751, 197);
		((Control)obj46).Size = size;
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
		size = new Size(745, 191);
		((Control)splitContainer2).Size = size;
		SplitContainer1.SplitterDistance = 162;
		((Control)SplitContainer1).TabIndex = 0;
		((DataGridView)adgvHach_toan).AllowUserToAddRows = false;
		((DataGridView)adgvHach_toan).AllowUserToDeleteRows = false;
		((DataGridView)adgvHach_toan).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvHach_toan).BorderStyle = (BorderStyle)2;
		val26.Alignment = (DataGridViewContentAlignment)16;
		val26.BackColor = SystemColors.Control;
		val26.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val26.ForeColor = SystemColors.WindowText;
		val26.SelectionBackColor = SystemColors.Highlight;
		val26.SelectionForeColor = SystemColors.HighlightText;
		val26.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).ColumnHeadersDefaultCellStyle = val26;
		((DataGridView)adgvHach_toan).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvHach_toan).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[10]
		{
			(DataGridViewColumn)dgvcTen_vt_ht,
			dgvcTien_nt0_ht,
			dgvcCp_Nt_ht,
			dgvcTien_nt_ht,
			dgvcTien0_ht,
			dgvcCp_ht,
			dgvcTien_ht,
			dgvcTk_vt,
			dgvcTk_co,
			(DataGridViewColumn)dgvcMa_vt_ht
		});
		val27.Alignment = (DataGridViewContentAlignment)16;
		val27.BackColor = SystemColors.Window;
		val27.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val27.ForeColor = SystemColors.ControlText;
		val27.SelectionBackColor = SystemColors.Highlight;
		val27.SelectionForeColor = SystemColors.HighlightText;
		val27.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvHach_toan).DefaultCellStyle = val27;
		((Control)adgvHach_toan).Dock = (DockStyle)5;
		((DataGridView)adgvHach_toan).GridColor = SystemColors.Control;
		adgvHach_toan.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV5 = adgvHach_toan;
		location = new Point(0, 0);
		((Control)asInputDGV5).Location = location;
		((Control)adgvHach_toan).Name = "adgvHach_toan";
		val28.Alignment = (DataGridViewContentAlignment)32;
		val28.BackColor = SystemColors.Control;
		val28.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val28.ForeColor = SystemColors.WindowText;
		val28.SelectionBackColor = SystemColors.Highlight;
		val28.SelectionForeColor = SystemColors.HighlightText;
		val28.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).RowHeadersDefaultCellStyle = val28;
		((DataGridView)adgvHach_toan).RowHeadersWidth = 35;
		((DataGridView)adgvHach_toan).RowTemplate.Height = 20;
		AsInputDGV asInputDGV6 = adgvHach_toan;
		size = new Size(745, 162);
		((Control)asInputDGV6).Size = size;
		((Control)adgvHach_toan).TabIndex = 0;
		((DataGridViewColumn)dgvcTen_vt_ht).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vt_ht).Frozen = true;
		((DataGridViewColumn)dgvcTen_vt_ht).HeaderText = "Tên vật tư";
		((DataGridViewColumn)dgvcTen_vt_ht).Name = "dgvcTen_vt_ht";
		((DataGridViewColumn)dgvcTen_vt_ht).ReadOnly = true;
		dgvcTen_vt_ht.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_vt_ht).Width = 200;
		((DataGridViewColumn)dgvcTien_nt0_ht).DataPropertyName = "tien_nt0";
		val29.Alignment = (DataGridViewContentAlignment)64;
		val29.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt0_ht).DefaultCellStyle = val29;
		((DataGridViewColumn)dgvcTien_nt0_ht).HeaderText = "Tiền hàng";
		dgvcTien_nt0_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt0_ht).Name = "dgvcTien_nt0_ht";
		((DataGridViewColumn)dgvcTien_nt0_ht).ReadOnly = true;
		dgvcTien_nt0_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt0_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt0_ht).Visible = false;
		((DataGridViewColumn)dgvcTien_nt0_ht).Width = 95;
		((DataGridViewColumn)dgvcCp_Nt_ht).DataPropertyName = "cp_nt";
		val30.Alignment = (DataGridViewContentAlignment)64;
		val30.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_Nt_ht).DefaultCellStyle = val30;
		((DataGridViewColumn)dgvcCp_Nt_ht).HeaderText = "Chi phí";
		dgvcCp_Nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_Nt_ht).Name = "dgvcCp_Nt_ht";
		((DataGridViewColumn)dgvcCp_Nt_ht).ReadOnly = true;
		dgvcCp_Nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcCp_Nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcCp_Nt_ht).Width = 80;
		((DataGridViewColumn)dgvcTien_nt_ht).DataPropertyName = "tien_nt";
		val31.Alignment = (DataGridViewContentAlignment)64;
		val31.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).DefaultCellStyle = val31;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = "Tổng tiền";
		dgvcTien_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).Name = "dgvcTien_nt_ht";
		((DataGridViewColumn)dgvcTien_nt_ht).ReadOnly = true;
		dgvcTien_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt_ht).Visible = false;
		((DataGridViewColumn)dgvcTien_nt_ht).Width = 95;
		((DataGridViewColumn)dgvcTien0_ht).DataPropertyName = "tien0";
		val32.Alignment = (DataGridViewContentAlignment)64;
		val32.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien0_ht).DefaultCellStyle = val32;
		((DataGridViewColumn)dgvcTien0_ht).HeaderText = "Tiền hàng VNĐ";
		dgvcTien0_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien0_ht).Name = "dgvcTien0_ht";
		((DataGridViewColumn)dgvcTien0_ht).ReadOnly = true;
		dgvcTien0_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien0_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien0_ht).Visible = false;
		((DataGridViewColumn)dgvcCp_ht).DataPropertyName = "cp";
		val33.Alignment = (DataGridViewContentAlignment)64;
		val33.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_ht).DefaultCellStyle = val33;
		((DataGridViewColumn)dgvcCp_ht).HeaderText = "CP VNĐ";
		dgvcCp_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcCp_ht).Name = "dgvcCp_ht";
		((DataGridViewColumn)dgvcCp_ht).ReadOnly = true;
		dgvcCp_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcCp_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_ht).DataPropertyName = "tien";
		val34.Alignment = (DataGridViewContentAlignment)64;
		val34.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ht).DefaultCellStyle = val34;
		((DataGridViewColumn)dgvcTien_ht).HeaderText = "Tổng tiền VNĐ";
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
		val35.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_vt).DefaultCellStyle = val35;
		((DataGridViewColumn)dgvcTk_vt).HeaderText = "Tk kho";
		dgvcTk_vt.LookupCodeName = "TK";
		dgvcTk_vt.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_vt).Name = "dgvcTk_vt";
		dgvcTk_vt.ReceiverValidFieldList = "ten_tk_vt";
		dgvcTk_vt.SD = true;
		dgvcTk_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_vt.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_vt).Width = 65;
		dgvcTk_co.AutoFill = true;
		dgvcTk_co.AutoLookup = true;
		dgvcTk_co.AutoValid = true;
		((DataGridViewColumn)dgvcTk_co).DataPropertyName = "tk_co";
		val36.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_co).DefaultCellStyle = val36;
		((DataGridViewColumn)dgvcTk_co).HeaderText = "Tk có";
		dgvcTk_co.LookupCodeName = "TK";
		dgvcTk_co.LookupWhereCondition = "chi_tiet=1";
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
		location = new Point(135, 3);
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
		Label obj47 = lblTk_pt;
		location = new Point(0, 6);
		((Control)obj47).Location = location;
		((Control)lblTk_pt).Name = "lblTk_pt";
		Label obj48 = lblTk_pt;
		size = new Size(93, 13);
		((Control)obj48).Size = size;
		((Control)lblTk_pt).TabIndex = 263;
		lblTk_pt.Text = "Tài khoản phải trả";
		lblTk_thue.AutoSize = true;
		((Control)lblTk_thue).Enabled = false;
		lblTk_thue.ImeMode = (ImeMode)0;
		Label obj49 = lblTk_thue;
		location = new Point(285, 7);
		((Control)obj49).Location = location;
		((Control)lblTk_thue).Name = "lblTk_thue";
		Label obj50 = lblTk_thue;
		size = new Size(79, 13);
		((Control)obj50).Size = size;
		((Control)lblTk_thue).TabIndex = 264;
		lblTk_thue.Text = "Tài khoản thuế";
		((Control)lblTk_thue).Visible = false;
		txtTk_thue.AutoLookup = true;
		txtTk_thue.AutoValid = true;
		((TextBoxBase)txtTk_thue).BackColor = SystemColors.Info;
		((TextBox)txtTk_thue).CharacterCasing = (CharacterCasing)1;
		((Control)txtTk_thue).Enabled = false;
		AsTextBox asTextBox5 = txtTk_thue;
		location = new Point(382, 3);
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
		((Control)txtT_cp_nt).Anchor = (AnchorStyles)6;
		txtT_cp_nt.DecimalSymbol = ".";
		((Control)txtT_cp_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric7 = txtT_cp_nt;
		location = new Point(544, 377);
		((Control)asTextNumeric7).Location = location;
		txtT_cp_nt.Mask = "### ### ### ###";
		((Control)txtT_cp_nt).Name = "txtT_cp_nt";
		((TextBoxBase)txtT_cp_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_cp_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_cp_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_cp_nt).TabIndex = 236;
		((Control)txtT_cp_nt).TabStop = false;
		((TextBox)txtT_cp_nt).Text = "0";
		((TextBox)txtT_cp_nt).TextAlign = (HorizontalAlignment)1;
		txtT_cp_nt.Value = 0.0;
		((Control)txtT_cp).Anchor = (AnchorStyles)6;
		txtT_cp.DecimalSymbol = ".";
		((Control)txtT_cp).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric9 = txtT_cp;
		location = new Point(647, 377);
		((Control)asTextNumeric9).Location = location;
		txtT_cp.Mask = "### ### ### ###";
		((Control)txtT_cp).Name = "txtT_cp";
		((TextBoxBase)txtT_cp).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtT_cp;
		size = new Size(100, 20);
		((Control)asTextNumeric10).Size = size;
		txtT_cp.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_cp).TabIndex = 229;
		((Control)txtT_cp).TabStop = false;
		((TextBox)txtT_cp).Text = "0";
		((TextBox)txtT_cp).TextAlign = (HorizontalAlignment)1;
		txtT_cp.Value = 0.0;
		((Control)Label7).Anchor = (AnchorStyles)6;
		Label7.AutoSize = true;
		((Control)Label7).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label7.ImeMode = (ImeMode)0;
		Label label = Label7;
		location = new Point(416, 381);
		((Control)label).Location = location;
		((Control)Label7).Name = "Label7";
		Label label2 = Label7;
		size = new Size(41, 13);
		((Control)label2).Size = size;
		((Control)Label7).TabIndex = 228;
		Label7.Text = "Chi phí";
		Label7.TextAlign = (ContentAlignment)16;
		lblTen_httt.ImeMode = (ImeMode)0;
		Label obj51 = lblTen_httt;
		location = new Point(199, 121);
		((Control)obj51).Location = location;
		((Control)lblTen_httt).Name = "lblTen_httt";
		Label obj52 = lblTen_httt;
		size = new Size(344, 13);
		((Control)obj52).Size = size;
		((Control)lblTen_httt).TabIndex = 257;
		lblTen_httt.TextAlign = (ContentAlignment)16;
		txtMa_Httt.AutoLookup = true;
		txtMa_Httt.AutoValid = true;
		((TextBoxBase)txtMa_Httt).BackColor = SystemColors.Info;
		((TextBox)txtMa_Httt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_Httt;
		location = new Point(118, 117);
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
		txtMa_Httt.ValidReturnFieldList = "ten_httt,tk,tk_thue_gtgt_mua";
		Label2.AutoSize = true;
		Label2.ImeMode = (ImeMode)0;
		Label label3 = Label2;
		location = new Point(8, 121);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(76, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 256;
		Label2.Text = "Mã thanh toán";
		tabTain.BackColor = SystemColors.Control;
		((Control)tabTain).Controls.Add((Control)(object)cmdGetTaInFromDetail);
		((Control)tabTain).Controls.Add((Control)(object)ctlTaIn);
		TabPage obj53 = tabTain;
		location = new Point(4, 25);
		obj53.Location = location;
		((Control)tabTain).Name = "tabTain";
		TabPage obj54 = tabTain;
		((Padding)(ref val37))._002Ector(3);
		((Control)obj54).Padding = val37;
		TabPage obj55 = tabTain;
		size = new Size(751, 197);
		((Control)obj55).Size = size;
		tabTain.TabIndex = 10;
		tabTain.Text = "Thuế &gtgt";
		((Control)cmdGetTaInFromDetail).Anchor = (AnchorStyles)10;
		Button obj56 = cmdGetTaInFromDetail;
		location = new Point(603, 168);
		((Control)obj56).Location = location;
		((Control)cmdGetTaInFromDetail).Name = "cmdGetTaInFromDetail";
		Button obj57 = cmdGetTaInFromDetail;
		size = new Size(140, 23);
		((Control)obj57).Size = size;
		((Control)cmdGetTaInFromDetail).TabIndex = 4;
		((ButtonBase)cmdGetTaInFromDetail).Text = "Lấ&y từ chi tiết";
		ctlTaIn.DataSource = bsTain;
		((Control)ctlTaIn).Dock = (DockStyle)5;
		ctlTaIn.HasThueNK = false;
		ctlTaIn.HasThueTTDB = false;
		ctlTaIn obj58 = ctlTaIn;
		location = new Point(3, 3);
		((Control)obj58).Location = location;
		ctlTaIn obj59 = ctlTaIn;
		((Padding)(ref val37))._002Ector(0);
		((Control)obj59).Margin = val37;
		((Control)ctlTaIn).Name = "ctlTaIn";
		ctlTaIn.PHDataSource = bsPH;
		ctlTaIn obj60 = ctlTaIn;
		size = new Size(745, 191);
		((Control)obj60).Size = size;
		((Control)ctlTaIn).TabIndex = 3;
		ctlTaIn.TAINTable = null;
		ctlTaIn.Tk_Du = "";
		ctlTaIn.Tk_Thue = "";
		((Control)Label8).Anchor = (AnchorStyles)6;
		Label8.AutoSize = true;
		((Control)Label8).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label8.ImeMode = (ImeMode)0;
		Label label5 = Label8;
		location = new Point(416, 425);
		((Control)label5).Location = location;
		((Control)Label8).Name = "Label8";
		Label label6 = Label8;
		size = new Size(68, 13);
		((Control)label6).Size = size;
		((Control)Label8).TabIndex = 257;
		Label8.Text = "Tổng cộng";
		Label8.TextAlign = (ContentAlignment)16;
		((Control)txtT_tt).Anchor = (AnchorStyles)6;
		txtT_tt.DecimalSymbol = ".";
		((Control)txtT_tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric11 = txtT_tt;
		location = new Point(647, 421);
		((Control)asTextNumeric11).Location = location;
		txtT_tt.Mask = "### ### ### ###";
		((Control)txtT_tt).Name = "txtT_tt";
		((TextBoxBase)txtT_tt).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtT_tt;
		size = new Size(100, 20);
		((Control)asTextNumeric12).Size = size;
		txtT_tt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_tt).TabIndex = 258;
		((Control)txtT_tt).TabStop = false;
		((TextBox)txtT_tt).Text = "0";
		((TextBox)txtT_tt).TextAlign = (HorizontalAlignment)1;
		txtT_tt.Value = 0.0;
		((Control)txtT_tt_nt).Anchor = (AnchorStyles)6;
		txtT_tt_nt.DecimalSymbol = ".";
		((Control)txtT_tt_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric13 = txtT_tt_nt;
		location = new Point(544, 421);
		((Control)asTextNumeric13).Location = location;
		txtT_tt_nt.Mask = "### ### ### ###";
		((Control)txtT_tt_nt).Name = "txtT_tt_nt";
		((TextBoxBase)txtT_tt_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtT_tt_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric14).Size = size;
		txtT_tt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tt_nt).TabIndex = 259;
		((Control)txtT_tt_nt).TabStop = false;
		((TextBox)txtT_tt_nt).Text = "0";
		((TextBox)txtT_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tt_nt.Value = 0.0;
		((Control)Label1).Anchor = (AnchorStyles)6;
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label1.ImeMode = (ImeMode)0;
		Label label7 = Label1;
		location = new Point(416, 403);
		((Control)label7).Location = location;
		((Control)Label1).Name = "Label1";
		Label label8 = Label1;
		size = new Size(32, 13);
		((Control)label8).Size = size;
		((Control)Label1).TabIndex = 263;
		Label1.Text = "Thuế";
		Label1.TextAlign = (ContentAlignment)16;
		((Control)txtT_thue_Nt).Anchor = (AnchorStyles)6;
		txtT_thue_Nt.DecimalSymbol = ".";
		((Control)txtT_thue_Nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric15 = txtT_thue_Nt;
		location = new Point(544, 399);
		((Control)asTextNumeric15).Location = location;
		txtT_thue_Nt.Mask = "### ### ### ###.##";
		((Control)txtT_thue_Nt).Name = "txtT_thue_Nt";
		((TextBoxBase)txtT_thue_Nt).ReadOnly = true;
		AsTextNumeric asTextNumeric16 = txtT_thue_Nt;
		size = new Size(100, 20);
		((Control)asTextNumeric16).Size = size;
		txtT_thue_Nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_thue_Nt).TabIndex = 262;
		((Control)txtT_thue_Nt).TabStop = false;
		((TextBox)txtT_thue_Nt).Text = "0.00";
		((TextBox)txtT_thue_Nt).TextAlign = (HorizontalAlignment)1;
		txtT_thue_Nt.Value = 0.0;
		((Control)txtT_Thue).Anchor = (AnchorStyles)6;
		txtT_Thue.DecimalSymbol = ".";
		((Control)txtT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric17 = txtT_Thue;
		location = new Point(647, 399);
		((Control)asTextNumeric17).Location = location;
		txtT_Thue.Mask = "### ### ### ###";
		((Control)txtT_Thue).Name = "txtT_Thue";
		((TextBoxBase)txtT_Thue).ReadOnly = true;
		AsTextNumeric asTextNumeric18 = txtT_Thue;
		size = new Size(100, 20);
		((Control)asTextNumeric18).Size = size;
		txtT_Thue.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Thue).TabIndex = 260;
		((Control)txtT_Thue).TabStop = false;
		((TextBox)txtT_Thue).Text = "0";
		((TextBox)txtT_Thue).TextAlign = (HorizontalAlignment)1;
		txtT_Thue.Value = 0.0;
		lblDia_chi.AutoSize = true;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj61 = lblDia_chi;
		location = new Point(10, 43);
		((Control)obj61).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj62 = lblDia_chi;
		size = new Size(40, 13);
		((Control)obj62).Size = size;
		((Control)lblDia_chi).TabIndex = 268;
		lblDia_chi.Text = "Địa chỉ";
		TextBox obj63 = txtDia_chi;
		location = new Point(118, 39);
		((Control)obj63).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj64 = txtDia_chi;
		size = new Size(425, 20);
		((Control)obj64).Size = size;
		((Control)txtDia_chi).TabIndex = 1;
		lblMa_so_thue.AutoSize = true;
		lblMa_so_thue.ImeMode = (ImeMode)0;
		Label obj65 = lblMa_so_thue;
		location = new Point(309, 69);
		((Control)obj65).Location = location;
		((Control)lblMa_so_thue).Name = "lblMa_so_thue";
		Label obj66 = lblMa_so_thue;
		size = new Size(60, 13);
		((Control)obj66).Size = size;
		((Control)lblMa_so_thue).TabIndex = 270;
		lblMa_so_thue.Text = "Mã số thuế";
		lblMa_so_thue.TextAlign = (ContentAlignment)16;
		TextBox obj67 = txtMa_so_thue;
		location = new Point(415, 65);
		((Control)obj67).Location = location;
		((Control)txtMa_so_thue).Name = "txtMa_so_thue";
		TextBox obj68 = txtMa_so_thue;
		size = new Size(128, 20);
		((Control)obj68).Size = size;
		((Control)txtMa_so_thue).TabIndex = 3;
		((Control)cmdThanh_toan).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdThanh_toan).Image = (Image)componentResourceManager.GetObject("cmdThanh_toan.Image");
		((ButtonBase)cmdThanh_toan).ImageAlign = (ContentAlignment)16;
		Button obj69 = cmdThanh_toan;
		location = new Point(143, 447);
		((Control)obj69).Location = location;
		((Control)cmdThanh_toan).Name = "cmdThanh_toan";
		Button obj70 = cmdThanh_toan;
		size = new Size(64, 23);
		((Control)obj70).Size = size;
		((Control)cmdThanh_toan).TabIndex = 4;
		((ButtonBase)cmdThanh_toan).Text = "Chi tiền";
		((ButtonBase)cmdThanh_toan).TextAlign = (ContentAlignment)64;
		size = new Size(759, 495);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdThanh_toan);
		((Control)this).Controls.Add((Control)(object)txtT_cp_nt);
		((Control)this).Controls.Add((Control)(object)txtTien_Cp_Pb_nt);
		((Control)this).Controls.Add((Control)(object)txtT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_thue_Nt);
		((Control)this).Controls.Add((Control)(object)txtTien_cp_pb);
		((Control)this).Controls.Add((Control)(object)txtT_tt);
		((Control)this).Controls.Add((Control)(object)txtT_tt_nt);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)txtT_cp);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)Label1);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmPOVchPO4";
		((Form)this).Text = "frmPoVchPO4";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_cp, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtTien_cp_pb, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_thue_Nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtTien_Cp_Pb_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_cp_nt, 0);
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
		((Control)scChiPhi.Panel1).ResumeLayout(false);
		((Control)scChiPhi.Panel2).ResumeLayout(false);
		((Control)scChiPhi).ResumeLayout(false);
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

	private void ctlTaIn_TAINValueChanged(object sender, EventArgs e)
	{
		UpdateList();
	}

	private void cmdPhan_bo_Click(object sender, EventArgs e)
	{
		if (ActionMode != Commons.ApplicationMode.VIEW_MODE && ((((DataGridView)adgvChi_phi).DataSource != null && ((DataGridView)adgvChi_phi).RowCount > 0 && CT1Voucher.Count > 0) ? true : false))
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
		if ((base.ActionMode != Commons.ApplicationMode.VIEW_MODE && e.ValidatedRow != null && !IsValidateCalledFromValidData) || 1 == 0)
		{
			CurrentPHRow["tk_pt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			((TextBox)txtTk_pt).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			((TextBox)txtTk_thue).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_mua"]), isNum: false));
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

	private void adgvDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if ((CTTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			bool flag = true;
			DataRowView oDv = CT1Voucher[e.RowIndex];
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcCp_nt).Name, false) == 0)
			{
				V_Cp_Nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcCp).Name, false) == 0)
			{
				V_Cp(oDv);
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
		if (CTTable == null || (base.IsLoading ? true : false))
		{
			return;
		}
		DataRowView dataRowView = CT1Voucher[e.RowIndex];
		try
		{
			object obj = null;
			DataGridViewCell currentCell = ((DataGridView)adgvDetail).CurrentCell;
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kho).Name, false) == 0)
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

	private void adgvChi_phi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if ((CPTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			bool flag = true;
			DataRowView currentCPRowView = CurrentCPRowView;
			string name = ((DataGridView)adgvChi_phi).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_cp_nt_cp).Name, false) == 0)
			{
				V_Tien_Cp_Nt_Cp(currentCPRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_cp_cp).Name, false) == 0)
			{
				V_Tien_Cp_Cp(currentCPRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTs_Gtgt).Name, false) == 0)
			{
				V_Ts_gtgt(currentCPRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt_nt_cp).Name, false) == 0)
			{
				V_Thue_gtgt_nt(currentCPRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt_cp).Name, false) == 0)
			{
				V_Thue_gtgt(currentCPRowView);
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

	private void adgvChi_phi_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if ((CPTable == null || e.RowIndex < 0 || base.IsLoading) ? true : false)
		{
			return;
		}
		DataRowView currentCPRowView = CurrentCPRowView;
		DataGridViewCell currentCell = ((DataGridView)adgvChi_phi).CurrentCell;
		string name = ((DataGridView)adgvChi_phi).Columns[e.ColumnIndex].Name;
		if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt_nt_cp).Name, false) == 0)
		{
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				currentCell.ReadOnly = !W_Thue_Gtgt_Nt_cp(currentCPRowView);
			}
		}
		else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt_cp).Name, false) == 0)
		{
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				currentCell.ReadOnly = !W_Thue_Gtgt_cp(currentCPRowView);
			}
		}
		else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_cp_cp).Name, false) == 0 && ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			currentCell.ReadOnly = !W_Tien_Cp(currentCPRowView);
		}
	}

	private void adgvChi_phi_MyProcessCmdKey(object sender, KeyEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			if ((int)e.KeyCode == 115)
			{
				InsertChiPhiRow();
			}
			else if (((int)e.KeyCode == 119 && ((DataGridView)adgvChi_phi).RowCount > 0) ? true : false)
			{
				DeleteChiPhiRow();
			}
			else if (adgvChi_phi.IsLastEditableDGVInputCell && (int)e.KeyCode == 13)
			{
				base.SetNextInputGridControlFocus();
			}
		}
	}

	private void cmdChon_dh_Click(object sender, EventArgs e)
	{
		if (base.ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			LookupPN();
		}
		((Control)this).SelectNextControl((Control)(object)cmdChon_dh, true, true, true, true);
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

	private void V_Ty_Gia()
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			foreach (DataRowView item in CT1Voucher)
			{
				Type? typeFromHandle = typeof(Math);
				object[] array = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["cp_nt"]), isNum: true), txtTy_gia.Value),
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
				item["cp"] = RuntimeHelpers.GetObjectValue(obj);
				Calc_ThanhToan(item);
			}
			foreach (DataRowView item2 in CP1Voucher)
			{
				if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
				{
					Type? typeFromHandle2 = typeof(Math);
					object[] array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp_nt"]), isNum: true)),
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
					item2["tien_cp"] = RuntimeHelpers.GetObjectValue(obj2);
					Type? typeFromHandle3 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt_nt"]), isNum: true)),
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
					item2["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj3);
					Type? typeFromHandle4 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tt_nt"]), isNum: true)),
						null,
						null
					};
					object[] array10 = array3;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array10[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					array = array3;
					object[] array11 = array;
					array5 = new bool[3] { false, true, false };
					object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array11, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["Tt"] = RuntimeHelpers.GetObjectValue(obj4);
					continue;
				}
				if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
				{
					Type? typeFromHandle5 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp_nt"]), isNum: true), txtTy_gia.Value),
						null,
						null
					};
					object[] array12 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array12[1] = sIConfiguration.Round_Gia;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array13 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array13, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["tien_cp"] = RuntimeHelpers.GetObjectValue(obj5);
				}
				if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tien_Cp"]), isNum: true)), (object)0, false))
				{
					Type? typeFromHandle6 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tien_Cp"]), isNum: true)), (object)100),
						null,
						null
					};
					object[] array14 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array14[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array15 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array15, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj6);
				}
				else
				{
					Type? typeFromHandle7 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt_nt"]), isNum: true), txtTy_gia.Value),
						null,
						null
					};
					object[] array16 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array16[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array17 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle7, "Round", array17, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj7);
				}
				if (Operators.ConditionalCompareObjectNotEqual(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt"]), isNum: true)), (object)0, false))
				{
					Type? typeFromHandle8 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt"]), isNum: true)),
						null,
						null
					};
					object[] array18 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array18[1] = sIConfiguration.Round_Gia;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array19 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj8 = NewLateBinding.LateGet((object)null, typeFromHandle8, "Round", array19, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["Tt"] = RuntimeHelpers.GetObjectValue(obj8);
				}
				else
				{
					Type? typeFromHandle9 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tt_nt"]), isNum: true), txtTy_gia.Value),
						null,
						null
					};
					object[] array20 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array20[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array21 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle9, "Round", array21, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					item2["Tt"] = RuntimeHelpers.GetObjectValue(obj9);
				}
			}
		}
		if ((((DataGridView)adgvChi_phi).DataSource != null && ((DataGridView)adgvChi_phi).RowCount > 0 && CT1Voucher.Count > 0) ? true : false)
		{
			Calc_ChiPhiMuaHang();
		}
		UpdateList();
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

	private void V_Tien_Cp_Nt_Cp(DataRowView oDv)
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

	private void V_Tien_Cp_Cp(DataRowView oDv)
	{
		Calc_Thue_gtgt_Cp(oDv);
		Calc_ThanhToan_CP(oDv);
		UpdateCPList();
	}

	private void V_Ts_gtgt(DataRowView oDv)
	{
		Calc_Thue_gtgt_Cp(oDv);
		Calc_ThanhToan_CP(oDv);
		UpdateCPList();
	}

	private void V_Thue_gtgt_nt(DataRowView oDv)
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
		else
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

	private void V_Thue_gtgt(DataRowView oDv)
	{
		Calc_ThanhToan_CP(oDv);
		UpdateCPList();
	}

	private void V_Cp_Nt(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Cp_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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
			oDv["Cp"] = RuntimeHelpers.GetObjectValue(obj);
		}
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Cp(DataRowView oDv)
	{
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void Calc_ThanhToan(DataRowView oDv)
	{
		oDv["Tt_Nt"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Cp_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true));
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tt_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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
			oDv["Tt"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else
		{
			oDv["Tt"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true));
		}
	}

	private void Calc_So_luong_qd(DataRowView oDv)
	{
		oDv["so_luong_qd"] = RuntimeHelpers.GetObjectValue(oDv["so_luong"]);
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
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp"]), isNum: true)), (object)100),
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
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true), txtTy_gia.Value),
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
	}

	private void Calc_ThanhToan_CP(DataRowView oDv)
	{
		oDv["Tt_Nt"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true));
		if (Operators.ConditionalCompareObjectNotEqual(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)),
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
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tt_Nt"]), isNum: true), txtTy_gia.Value),
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
		string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
		int digits = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		double num = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(tien_nt0)", filter)), isNum: true));
		double num2 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(tien0)", filter)), isNum: true));
		double num3 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(so_luong)", filter)), isNum: true));
		double num8;
		double num9;
		double num10;
		double num11;
		foreach (DataRowView item in base.CT1Voucher)
		{
			double num4 = 0.0;
			double num5 = 0.0;
			double num6 = 0.0;
			double num7 = 0.0;
			foreach (DataRowView item2 in base.CP1Voucher)
			{
				num8 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp"]), isNum: true));
				num9 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp_nt"]), isNum: true));
				num10 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["thue_gtgt"]), isNum: true));
				num11 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["thue_gtgt_nt"]), isNum: true));
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tt_pb"]), isNum: false), (object)"2", false))
				{
					if (num == 0.0)
					{
						continue;
					}
					double num12 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien_nt0"]), isNum: true));
					double num13 = Math.Round(num9 * num12 / num, digits, MidpointRounding.AwayFromZero);
					num4 += num13;
					double num14 = Math.Round(num11 * num12 / num, digits, MidpointRounding.AwayFromZero);
					num6 += num14;
					if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true), (object)0, false))
					{
						object obj = num5;
						Type? typeFromHandle = typeof(Math);
						object[] array = new object[3]
						{
							Operators.MultiplyObject((object)num13, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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
						object obj3 = num7;
						Type? typeFromHandle2 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject((object)num14, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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
						object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						num7 = Conversions.ToDouble(Operators.AddObject(obj3, obj4));
					}
					else
					{
						double num15 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien0"]), isNum: true));
						num5 += Math.Round(num8 * num15 / num2, AsiaErp.Framework.Environment.GetSIConfiguration().Round, MidpointRounding.AwayFromZero);
						num7 += Math.Round(num10 * num15 / num2, AsiaErp.Framework.Environment.GetSIConfiguration().Round, MidpointRounding.AwayFromZero);
					}
				}
				else
				{
					if (num3 == 0.0)
					{
						continue;
					}
					double num16 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["so_luong"]), isNum: true));
					double num13 = Math.Round(num9 * num16 / num3, digits, MidpointRounding.AwayFromZero);
					num4 += num13;
					double num14 = Math.Round(num11 * num16 / num3, digits, MidpointRounding.AwayFromZero);
					num6 += num14;
					if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true), (object)0, false))
					{
						object obj5 = num5;
						Type? typeFromHandle3 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.MultiplyObject((object)num13, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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
						object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array9, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						num5 = Conversions.ToDouble(Operators.AddObject(obj5, obj6));
						object obj7 = num7;
						Type? typeFromHandle4 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject((object)num14, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
							null,
							null
						};
						object[] array10 = array3;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array10[1] = sIConfiguration.Round;
						array3[2] = MidpointRounding.AwayFromZero;
						array = array3;
						object[] array11 = array;
						array5 = new bool[3] { false, true, false };
						object obj8 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array11, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						num7 = Conversions.ToDouble(Operators.AddObject(obj7, obj8));
					}
					else
					{
						num16 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["so_luong"]), isNum: true));
						num5 += Math.Round(num8 * num16 / num3, AsiaErp.Framework.Environment.GetSIConfiguration().Round, MidpointRounding.AwayFromZero);
						num7 += Math.Round(num10 * num16 / num3, AsiaErp.Framework.Environment.GetSIConfiguration().Round, MidpointRounding.AwayFromZero);
					}
				}
			}
			item["cp_nt"] = num4;
			item["cp"] = num5;
			item["thue_gtgt_nt"] = num6;
			item["thue_gtgt"] = num7;
			Calc_ThanhToan(item);
		}
		num8 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp)", filter)), isNum: true));
		num9 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp_nt)", filter)), isNum: true));
		double num17 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(cp_nt)", filter)), isNum: true));
		double num18 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(cp)", filter)), isNum: true));
		num10 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(thue_gtgt)", filter)), isNum: true));
		num11 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(thue_gtgt_nt)", filter)), isNum: true));
		double num19 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(thue_gtgt_nt)", filter)), isNum: true));
		double num20 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(thue_gtgt)", filter)), isNum: true));
		base.CT1Voucher.Sort = "cp_nt desc";
		DataRowView dataRowView3 = base.CT1Voucher[0];
		base.CT1Voucher.Sort = "";
		DataRowView dataRowView4 = dataRowView3;
		DataRowView dataRowView5 = dataRowView4;
		string property = "cp";
		dataRowView5[property] = Operators.AddObject(dataRowView4[property], (object)(num8 - num18));
		dataRowView4 = dataRowView3;
		DataRowView dataRowView6 = dataRowView4;
		property = "cp_nt";
		dataRowView6[property] = Operators.AddObject(dataRowView4[property], (object)(num9 - num17));
		dataRowView4 = dataRowView3;
		DataRowView dataRowView7 = dataRowView4;
		property = "thue_gtgt";
		dataRowView7[property] = Operators.AddObject(dataRowView4[property], (object)(num10 - num20));
		dataRowView4 = dataRowView3;
		DataRowView dataRowView8 = dataRowView4;
		property = "thue_gtgt_nt";
		dataRowView8[property] = Operators.AddObject(dataRowView4[property], (object)(num11 - num19));
		Calc_ThanhToan(dataRowView3);
		UpdateList();
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
		string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
		txtTien_Cp_Pb_nt.Value = RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp_nt)", filter));
		txtTien_cp_pb.Value = RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp)", filter));
		UpdateList();
	}

	private void LookupPN()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		frmPOVchPO4FindPO2PO3PO7 frmPOVchPO4FindPO2PO3PO8 = new frmPOVchPO4FindPO2PO3PO7();
		((Form)frmPOVchPO4FindPO2PO3PO8).Text = ((ButtonBase)cmdChon_dh).Text.Replace("&", "");
		((Form)frmPOVchPO4FindPO2PO3PO8).ShowDialog();
		if (!frmPOVchPO4FindPO2PO3PO8.SearchOK)
		{
			return;
		}
		frmPOVchPO4SeachPO2PO3PO7 frmPOVchPO4SeachPO2PO3PO8 = new frmPOVchPO4SeachPO2PO3PO7();
		((Form)frmPOVchPO4SeachPO2PO3PO8).Text = ((ButtonBase)cmdChon_dh).Text.Replace("&", "");
		frmPOVchPO4SeachPO2PO3PO8.PHTable = frmPOVchPO4FindPO2PO3PO8.PhTable;
		frmPOVchPO4SeachPO2PO3PO8.CTTable = frmPOVchPO4FindPO2PO3PO8.CtTable;
		if ((int)((Form)frmPOVchPO4SeachPO2PO3PO8).ShowDialog() == 1)
		{
			DataRow[] array = frmPOVchPO4SeachPO2PO3PO8.PHTable.Select("CHON=True");
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
			TextBox oTxt = txtNguoi_Gd;
			SetTexboxValue(ref oTxt, Conversions.ToString(dataRow2["nguoi_gd"]));
			txtNguoi_Gd = oTxt;
			DataRow[] array3 = array;
			foreach (DataRow dataRow3 in array3)
			{
				DataRow[] array4 = frmPOVchPO4SeachPO2PO3PO8.CTTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", dataRow3["Stt_rec"]), (object)"' And Chon=True")));
				foreach (DataRow dataRow4 in array4)
				{
					DataRow dataRow5 = CTTable.NewRow();
					dataRow5["Stt_Rec"] = RuntimeHelpers.GetObjectValue(CurrentPHRow["Stt_Rec"]);
					dataRow5["Stt_Rec0"] = Commons.Get_SttRec0(Conversions.ToString(CurrentPHRow["Stt_Rec"]), CTTable);
					dataRow5["Stt_Rec_pn"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec"]);
					dataRow5["Stt_Rec0_pn"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec0"]);
					dataRow5["So_pn"] = RuntimeHelpers.GetObjectValue(dataRow3["So_ct"]);
					dataRow5["ma_nt"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_nt"]);
					dataRow5["ma_vt"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_vt"]);
					dataRow5["ten_Vt"] = RuntimeHelpers.GetObjectValue(dataRow4["ten_Vt"]);
					dataRow5["Dvt"] = RuntimeHelpers.GetObjectValue(dataRow4["Dvt"]);
					dataRow5["ma_kho"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_kho"]);
					dataRow5["So_luong"] = RuntimeHelpers.GetObjectValue(dataRow4["sl_nhap"]);
					dataRow5["So_luong"] = RuntimeHelpers.GetObjectValue(dataRow4["sl_nhap_qd"]);
					dataRow5["Tien_Nt0"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_nt0"]);
					dataRow5["Tien0"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien0"]);
					dataRow5["ma_lo"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_lo"]);
					dataRow5["ma_spct"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_spct"]);
					dataRow5["ma_phi"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_phi"]);
					dataRow5["ma_bp"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_bp"]);
					dataRow5["ma_hd"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_hd"]);
					dataRow5["tk_vt"] = RuntimeHelpers.GetObjectValue(dataRow4["tk_vt"]);
					CTTable.Rows.Add(dataRow5);
					ReCalcAfterLookup(dataRow5);
				}
			}
			UpdateList();
		}
		((Component)(object)frmPOVchPO4FindPO2PO3PO8).Dispose();
		((TabControl)AsTabControl).SelectedTab = tabDetail;
	}

	private void SetTexboxValue(ref TextBox oTxt, string value, bool isnumeric = false)
	{
		if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(oTxt.Text, isNum: false), (object)"", false))
		{
			oTxt.Text = Conversions.ToString(Helper.Repl_Null(value, isnumeric));
		}
	}

	private void ReCalcAfterLookup(DataRow odr)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		odr["Tt_Nt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tien_Nt0"]), isNum: true));
		if (Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)0, false))
		{
			odr["Tt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tien0"]), isNum: true));
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Tt_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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
			odr["Tt"] = RuntimeHelpers.GetObjectValue(obj);
		}
		odr["so_luong_qd"] = RuntimeHelpers.GetObjectValue(odr["so_luong"]);
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
			IOrderedEnumerable<VB_0024AnonymousType_2<decimal, decimal, decimal, decimal, decimal>> orderedEnumerable = from _0024VB_0024It in (from row in CPTable.AsEnumerable()
					where Operators.ConditionalCompareObjectEqual(row["stt_rec"], _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()["stt_rec"], false)
					select row).GroupBy([SpecialName] (DataRow row) => row.Field<decimal?>("ts_gtgt") ?? 0m, [SpecialName] (DataRow row) => row, [SpecialName] (decimal ts_gtgt, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_1<decimal, IEnumerable<DataRow>, decimal, decimal, decimal, decimal>(ts_gtgt, _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien_cp_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien_cp") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_gtgt_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_gtgt") ?? 0m)))
				select new VB_0024AnonymousType_2<decimal, decimal, decimal, decimal, decimal>(_0024VB_0024It.ts_gtgt, _0024VB_0024It.tien_cp_nt, _0024VB_0024It.tien_cp, _0024VB_0024It.thue_gtgt_nt, _0024VB_0024It.thue_gtgt) into _0024VB_0024It
				orderby _0024VB_0024It.ts_gtgt
				select _0024VB_0024It;
			{
				foreach (VB_0024AnonymousType_2<decimal, decimal, decimal, decimal, decimal> item2 in orderedEnumerable)
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
					dataRow["ghi_chu"] = f_sChi_phi_header;
					dataRow["ten_vt"] = txtDien_giai.Text;
					dataRow["tien_hang_nt"] = item2.tien_cp_nt;
					dataRow["tien_hang"] = item2.tien_cp;
					dataRow["t_tien_nt"] = item2.tien_cp_nt;
					dataRow["t_tien"] = item2.tien_cp;
					dataRow["thue_suat"] = item2.ts_gtgt;
					dataRow["t_thue_nt"] = item2.thue_gtgt_nt;
					dataRow["t_thue"] = item2.thue_gtgt;
					base.TAINTable.Rows.Add(dataRow);
				}
				return;
			}
		}
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
	}

	private void RecipeABC(DataGridViewAsTextNumericColumn asDgvc, double dbA, double dbB, double dbC, int index, int Cmess, ref bool CmessGHDC)
	{
		if (dbA != 0.0)
		{
			((DataGridView)adgvChi_phi)[((DataGridViewColumn)asDgvc).Name, index].ErrorText = string.Empty;
			if (Math.Abs(dbA - dbB) > dbC)
			{
				((DataGridView)adgvChi_phi)[((DataGridViewColumn)asDgvc).Name, index].ErrorText = Helper.GetMessContent(Cmess);
				CmessGHDC = true;
			}
		}
	}

	private void ValidAdjustOver(int index, DataRowView odv, ref bool CmessGHDC, int Cmess)
	{
		double gia_tri_dieu_chinh_toi_da = AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_toi_da;
		double gia_tri_dieu_chinh_tien_nt_toi_da = AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_tien_nt_toi_da;
		int num = AsiaErp.Framework.Environment.GetSIConfiguration().Round;
		int round_Nt = AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt;
		if ((Operators.ConditionalCompareObjectNotEqual(((ListControl)cboMa_NT).SelectedValue, (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) && Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false)) ? true : false)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien_cp_nt"]), isNum: true), txtTy_gia.Value),
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
			double dbB = Conversions.ToDouble(obj);
			RecipeABC(dgvcTien_cp_cp, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien_cp"]), isNum: true)), dbB, gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			Type? typeFromHandle2 = typeof(Math);
			object[] array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien_cp_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true)), (object)100),
				round_Nt,
				MidpointRounding.AwayFromZero
			};
			object[] array5 = array4;
			array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array5, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				round_Nt = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbB2 = Conversions.ToDouble(obj2);
			Type? typeFromHandle3 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien_cp"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true)), (object)100),
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
			double num2 = Conversions.ToDouble(obj3);
			if (num2 == 0.0)
			{
				Type? typeFromHandle4 = typeof(Math);
				array4 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true), txtTy_gia.Value),
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
				num2 = Conversions.ToDouble(obj4);
			}
			RecipeABC(dgvcThue_gtgt_cp, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["thue_gtgt"]), isNum: true)), num2, gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_gtgt_nt_cp, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["thue_gtgt_nt"]), isNum: true)), dbB2, gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
		}
		else
		{
			Type? typeFromHandle5 = typeof(Math);
			object[] array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien_cp_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true)), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array8 = array4;
			bool[] array3 = new bool[3] { false, true, false };
			object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array8, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA = Conversions.ToDouble(obj5);
			RecipeABC(dgvcThue_gtgt_nt_cp, dbA, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
		}
	}

	private void RefreshValueByMa_Nt()
	{
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) != 0)
		{
			return;
		}
		int num = AsiaErp.Framework.Environment.GetSIConfiguration().Round;
		foreach (DataRowView item in base.CT1Voucher)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["cp_nt"]), isNum: true)),
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
			item["cp_nt"] = RuntimeHelpers.GetObjectValue(obj);
		}
		foreach (DataRowView item2 in base.CP1Voucher)
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["tien_cp_nt"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array5 = array4;
			bool[] array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array5, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			item2["tien_cp_nt"] = RuntimeHelpers.GetObjectValue(obj2);
			Type? typeFromHandle3 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Thue_Gtgt_nt"]), isNum: true)),
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
			item2["Thue_Gtgt_nt"] = RuntimeHelpers.GetObjectValue(obj3);
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
						select row).GroupBy([SpecialName] (DataRow row) => new VB_0024AnonymousType_3<object, object, object, object, object, object>(RuntimeHelpers.GetObjectValue(row["tk_vt"]), RuntimeHelpers.GetObjectValue(row["ma_hd"]), RuntimeHelpers.GetObjectValue(row["ma_bp"]), RuntimeHelpers.GetObjectValue(row["ma_phi"]), RuntimeHelpers.GetObjectValue(row["ma_spct"]), RuntimeHelpers.GetObjectValue(row["ma_lo"])), [SpecialName] (DataRow row) => row, [SpecialName] (VB_0024AnonymousType_3<object, object, object, object, object, object> _0024VB_0024Key, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_4<object, object, object, object, object, object, IEnumerable<DataRow>, decimal, decimal>(RuntimeHelpers.GetObjectValue(_0024VB_0024Key.tk), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_hd), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_bp), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_phi), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_spct), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_lo), _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("cp_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("cp") ?? 0m)))
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
		string amount_Input_Format = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		dgvcTien_cp_cp.Mask = amount_Input_Format;
		dgvcThue_gtgt_cp.Mask = amount_Input_Format;
		dgvcTt_Cp.Mask = amount_Input_Format;
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		base.CPTable.Columns["TT_PB"].DefaultValue = "1";
		((DataGridView)adgvHach_toan).DataSource = bsCT;
		((DataGridView)adgvChi_phi).DataSource = bsCP;
		ctlTaIn.DataSource = base.bsTain;
		ctlTaIn.TAINTable = base.TAINTable;
		AddControl2ListOfDrivedControls((Control)(object)cmdGetTaInFromDetail);
		AddControl2ListOfDrivedControls((Control)(object)cmdChon_dh);
		AddControl2ListOfDrivedControls((Control)(object)cmdPhan_bo);
		AddControl2ListOfDrivedControls((Control)(object)ctlTaIn.chkKe_tain);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_thue_Nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_cp_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tt_nt);
		AddDGV(adgvChi_phi);
		AddDGV(adgvHach_toan);
		f_sTien_header = ((DataGridViewColumn)dgvcTien_nt_ht).HeaderText;
		f_sTien0_header = ((DataGridViewColumn)dgvcTien_nt0).HeaderText;
		f_sChi_phi_header = ((DataGridViewColumn)dgvcCp_nt).HeaderText;
		f_sThue_header = ((DataGridViewColumn)dgvcThue_gtgt_nt_cp).HeaderText;
		f_sTien0_cp_header = ((DataGridViewColumn)dgvcTien_nt0_ht).HeaderText;
		string ma_nt = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		((DataGridViewColumn)dgvcTien0).HeaderText = f_sTien0_header + " " + ma_nt;
		((DataGridViewColumn)dgvcCp).HeaderText = f_sChi_phi_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien0_ht).HeaderText = f_sTien0_cp_header + " " + ma_nt;
		((DataGridViewColumn)dgvcCp_ht).HeaderText = f_sChi_phi_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien_ht).HeaderText = f_sTien_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien_cp_cp).HeaderText = f_sChi_phi_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTt_Cp).HeaderText = f_sTien_header + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_gtgt_cp).HeaderText = f_sThue_header + " " + ma_nt;
	}

	protected override void RefreshDGVInput()
	{
		base.RefreshDGVInput();
		if (CTTable == null)
		{
			return;
		}
		bool visible = false;
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			txtTy_gia.Value = 1;
			((TextBoxBase)txtTy_gia).ReadOnly = true;
			((Control)txtTy_gia).TabStop = false;
		}
		else
		{
			visible = true;
			((TextBoxBase)txtTy_gia).ReadOnly = ActionMode == Commons.ApplicationMode.VIEW_MODE;
			((Control)txtTy_gia).TabStop = true;
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				txtTy_gia.Value = Commons.Get_TyGia(cboMa_NT.MA_NT, Conversions.ToDate(txtNgay_Ct.Value));
			}
		}
		((Control)txtT_Thue).Visible = visible;
		((Control)txtT_cp).Visible = visible;
		((Control)txtT_tt).Visible = visible;
		((DataGridViewColumn)dgvcTien0).Visible = visible;
		((DataGridViewColumn)dgvcCp).Visible = visible;
		((DataGridViewColumn)dgvcTien_cp_cp).Visible = visible;
		((DataGridViewColumn)dgvcThue_gtgt_cp).Visible = visible;
		((DataGridViewColumn)dgvcTt_Cp).Visible = visible;
		((DataGridViewColumn)dgvcCp_ht).Visible = visible;
		string mA_NT = cboMa_NT.MA_NT;
		((DataGridViewColumn)dgvcCp_nt).HeaderText = f_sChi_phi_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt0_ht).HeaderText = f_sTien0_cp_header + " " + mA_NT;
		((DataGridViewColumn)dgvcCp_Nt_ht).HeaderText = f_sChi_phi_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = f_sTien_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_cp_nt_cp).HeaderText = f_sChi_phi_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTt_nt_cp).HeaderText = f_sTien_header + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_gtgt_nt_cp).HeaderText = f_sThue_header + " " + mA_NT;
		if (CurrentPHRow != null)
		{
			string filter = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"stt_rec='", Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentPHRow["stt_rec"]), isNum: false)), (object)"' and ma_nt<>'"), (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0), (object)"'"));
			if (Operators.ConditionalCompareObjectGreater(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("count(ma_nt)", filter)), isNum: true), (object)0, false))
			{
				dgvcTien0_ht.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			}
			else
			{
				dgvcTien0_ht.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
			}
		}
	}

	protected override void SetFocus4FirstEditControl()
	{
		((Control)txtMa_Kh).Select();
	}

	protected override void UpdateList()
	{
		if (base.CurrentPHRow != null)
		{
			string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
			txtT_cp_nt.Value = RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp_nt)", filter));
			txtT_thue_Nt.Value = ctlTaIn.get_T_Thue_Nt("");
			txtT_tt_nt.Value = Operators.AddObject(txtT_cp_nt.Value, txtT_thue_Nt.Value);
			txtT_cp.Value = RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp)", filter));
			txtT_Thue.Value = ctlTaIn.get_T_Thue("");
			txtT_tt.Value = Operators.AddObject(txtT_cp.Value, txtT_Thue.Value);
		}
	}

	protected override bool ValidData()
	{
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
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
						((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_vt).Name, num2].ErrorText = Helper.GetMessContent(50062);
						((TabControl)AsTabControl).SelectedTab = tabDetail;
						((Control)adgvDetail).Select();
						((DataGridView)adgvDetail).CurrentCell = ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_vt).Name, num2];
						CMessageBox.Show(50062);
						return false;
					}
					if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Kho"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ton_kho"]), isNum: false), (object)true, false)) ? true : false)
					{
						((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_kho).Name, num2].ErrorText = Helper.GetMessContent(50056);
						((TabControl)AsTabControl).SelectedTab = tabDetail;
						((DataGridView)adgvDetail).CurrentCell = ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_kho).Name, num2];
						((Control)adgvDetail).Select();
						CMessageBox.Show(50056);
						return false;
					}
					if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ton_kho"]), isNum: false), (object)"1", false)) ? true : false)
					{
						((TabControl)AsTabControl).SelectedTab = tabDetail;
						((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcSo_luong).Name, num2].ErrorText = Helper.GetMessContent(50037);
						flag2 = false;
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_vt"]), isNum: false), (object)"", false))
					{
						((DataGridView)adgvHach_toan)[((DataGridViewColumn)dgvcTk_vt).Name, num2].ErrorText = Helper.GetMessContent(50023);
						((TabControl)AsTabControl).SelectedTab = tabHach_toan;
						((Control)adgvHach_toan).Select();
						((DataGridView)adgvHach_toan).CurrentCell = ((DataGridView)adgvHach_toan)[((DataGridViewColumn)dgvcTk_vt).Name, num2];
						CMessageBox.Show(50023);
						return false;
					}
					num2++;
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
					DataRowView dataRowView = CP1Voucher[num6];
					ValidAdjustOver(num6, dataRowView, ref CmessGHDC, 50130);
					num6++;
				}
				if (CmessGHDC)
				{
					return Commons.ProcessAdjustOver();
				}
				if (!flag2)
				{
					CMessageBox.Show(50037);
				}
				if ((CP1Voucher != null && CP1Voucher.Count != 0) ? true : false)
				{
					int num8 = CP1Voucher.Count - 1;
					int num9 = 0;
					while (true)
					{
						int num10 = num9;
						int num4 = num8;
						if (num10 > num4)
						{
							break;
						}
						DataRowView dataRowView2 = CP1Voucher[num9];
						if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView2["tien_cp_nt"]), isNum: true), (object)0, false))
						{
							((TabControl)AsTabControl).SelectedTab = tabChi_phi;
							((Control)adgvChi_phi).Select();
							((DataGridView)adgvChi_phi).CurrentCell = ((DataGridView)adgvChi_phi)[((DataGridViewColumn)dgvcTt_nt_cp).Name, num9];
							CMessageBox.Show(50048);
							return false;
						}
						num9++;
					}
				}
				string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
				if ((Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp_nt)", filter)), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(cp_nt)", filter)), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CPTable.Compute("sum(tien_cp_nt)", filter)), isNum: true), false)) ? true : false)
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
			adgvHach_toan.ReadOnly = false;
			adgvChi_phi.ReadOnly = false;
			ctlTaIn.adgvTaIn.ReadOnly = false;
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
			if (ActionMode == Commons.ApplicationMode.EDIT_MODE)
			{
				((Control)cmdChon_dh).TabStop = false;
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
		CreateDataBinding((Control)(object)txtMa_Httt, "Ma_Httt");
		CreateDataBinding((Control)(object)lblTen_httt, "Ten_httt");
		CreateDataBinding((Control)(object)txtNgay_Ct, "ngay_ct", "Value");
		CreateDataBinding((Control)(object)txtSo_Ct, "so_ct");
		CreateDataBinding((Control)(object)txtNgay_lct, "ngay_lct", "Value");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)txtT_tt, "T_tt", "Value");
		CreateDataBinding((Control)(object)txtT_tt_nt, "T_tt_nt", "Value");
		CreateDataBinding((Control)(object)txtT_cp_nt, "T_cp_nt", "Value");
		CreateDataBinding((Control)(object)txtT_cp, "T_cp", "Value");
		CreateDataBinding((Control)(object)txtT_Thue, "T_Thue", "Value");
		CreateDataBinding((Control)(object)txtT_thue_Nt, "T_thue_Nt", "Value");
		CreateDataBinding((Control)(object)txtTk_pt, "tk_pt");
		CreateDataBinding((Control)(object)ctlTaIn.chkKe_tain, "kht_tain", "Checked");
	}

	protected override void SetPHDefaultValues(DataRow drwPh)
	{
		drwPh["ngay_lct"] = RuntimeHelpers.GetObjectValue(drwPh["ngay_ct"]);
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

	protected override bool ChkStatusRight([Optional][DefaultParameterValue("")] ref string retMess)
	{
		return POCommon.POChkStatusRightPO4(Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentPHRow["stt_rec"]), isNum: false)), ref retMess);
	}

	[SpecialName]
	[DebuggerNonUserCode]
	protected DataRow _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()
	{
		return base.CurrentPHRow;
	}
}
