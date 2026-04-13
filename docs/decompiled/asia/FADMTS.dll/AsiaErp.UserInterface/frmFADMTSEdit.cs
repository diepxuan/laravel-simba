using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmFADMTSEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblMa_TS")]
	private Label _lblMa_TS;

	[AccessedThroughProperty("txtMa_ts")]
	private TextBox _txtMa_ts;

	[AccessedThroughProperty("txtTen_ts")]
	private TextBox _txtTen_ts;

	[AccessedThroughProperty("lblTen_TS")]
	private Label _lblTen_TS;

	[AccessedThroughProperty("TabCtlTai_san")]
	private AsTabControl _TabCtlTai_san;

	[AccessedThroughProperty("tabTTC")]
	private TabPage _tabTTC;

	[AccessedThroughProperty("tabTTKH")]
	private TabPage _tabTTKH;

	[AccessedThroughProperty("tabPT_LK")]
	private TabPage _tabPT_LK;

	[AccessedThroughProperty("txtNha_cc")]
	private TextBox _txtNha_cc;

	[AccessedThroughProperty("lblNha_cc")]
	private Label _lblNha_cc;

	[AccessedThroughProperty("txtcong_suat")]
	private TextBox _txtcong_suat;

	[AccessedThroughProperty("lblCong_suat")]
	private Label _lblCong_suat;

	[AccessedThroughProperty("txtNuoc_sx")]
	private TextBox _txtNuoc_sx;

	[AccessedThroughProperty("lblNuoc_sx")]
	private Label _lblNuoc_sx;

	[AccessedThroughProperty("chkSua_kh")]
	private AsCheckBox _chkSua_kh;

	[AccessedThroughProperty("txtTen_lk")]
	private TextBox _txtTen_lk;

	[AccessedThroughProperty("lblTen_lk")]
	private Label _lblTen_lk;

	[AccessedThroughProperty("lblMa_LK")]
	private Label _lblMa_LK;

	[AccessedThroughProperty("txtDvt_Lk")]
	private TextBox _txtDvt_Lk;

	[AccessedThroughProperty("lblDVT1")]
	private Label _lblDVT1;

	[AccessedThroughProperty("chkKSD_LK")]
	private AsCheckBox _chkKSD_LK;

	[AccessedThroughProperty("cmdAdd_lk")]
	private Button _cmdAdd_lk;

	[AccessedThroughProperty("dgvLinh_kien")]
	private AsInputDGV _dgvLinh_kien;

	[AccessedThroughProperty("cmdDel_lk")]
	private Button _cmdDel_lk;

	[AccessedThroughProperty("lblDVT")]
	private Label _lblDVT;

	[AccessedThroughProperty("txtDvt")]
	private TextBox _txtDvt;

	[AccessedThroughProperty("lblNgay_DVSD")]
	private Label _lblNgay_DVSD;

	[AccessedThroughProperty("txtNgay_dvsd")]
	private AsMaskedTextBox _txtNgay_dvsd;

	[AccessedThroughProperty("txtSo_luong")]
	private AsTextNumeric _txtSo_luong;

	[AccessedThroughProperty("lblSlg")]
	private Label _lblSlg;

	[AccessedThroughProperty("txtNam_sx")]
	private AsTextNumeric _txtNam_sx;

	[AccessedThroughProperty("lblNam_sx")]
	private Label _lblNam_sx;

	[AccessedThroughProperty("txtLd_dc")]
	private TextBox _txtLd_dc;

	[AccessedThroughProperty("lblLd_dc")]
	private Label _lblLd_dc;

	[AccessedThroughProperty("lblNgay_DC")]
	private Label _lblNgay_DC;

	[AccessedThroughProperty("txtNgay_dc")]
	private AsMaskedTextBox _txtNgay_dc;

	[AccessedThroughProperty("lblNgay_GN_GTCL")]
	private Label _lblNgay_GN_GTCL;

	[AccessedThroughProperty("txtNgay_gt_cl")]
	private AsMaskedTextBox _txtNgay_gt_cl;

	[AccessedThroughProperty("lblNgay_BH_KH")]
	private Label _lblNgay_BH_KH;

	[AccessedThroughProperty("txtNgay_bdkh")]
	private AsMaskedTextBox _txtNgay_bdkh;

	[AccessedThroughProperty("lblNgay_tang")]
	private Label _lblNgay_tang;

	[AccessedThroughProperty("txtNgay_tang")]
	private AsMaskedTextBox _txtNgay_tang;

	[AccessedThroughProperty("lblMa_LDT")]
	private Label _lblMa_LDT;

	[AccessedThroughProperty("txtMA_LDTG")]
	private AsTextBox _txtMA_LDTG;

	[AccessedThroughProperty("lblMa_nhts1")]
	private Label _lblMa_nhts1;

	[AccessedThroughProperty("txtMa_nhts1")]
	private AsTextBox _txtMa_nhts1;

	[AccessedThroughProperty("lblNgay_ct")]
	private Label _lblNgay_ct;

	[AccessedThroughProperty("txtNgay_ct")]
	private AsMaskedTextBox _txtNgay_ct;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("lblSO_ct")]
	private Label _lblSO_ct;

	[AccessedThroughProperty("lblMa_BPSD")]
	private Label _lblMa_BPSD;

	[AccessedThroughProperty("txtMa_bpsd")]
	private AsTextBox _txtMa_bpsd;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblMa_phi")]
	private Label _lblMa_phi;

	[AccessedThroughProperty("txtMa_phi")]
	private AsTextBox _txtMa_phi;

	[AccessedThroughProperty("lblMa_nhts3")]
	private Label _lblMa_nhts3;

	[AccessedThroughProperty("txtMa_nhts3")]
	private AsTextBox _txtMa_nhts3;

	[AccessedThroughProperty("lblMa_nhts2")]
	private Label _lblMa_nhts2;

	[AccessedThroughProperty("txtMa_nhts2")]
	private AsTextBox _txtMa_nhts2;

	[AccessedThroughProperty("lblTy_Le_KH_THANG")]
	private Label _lblTy_Le_KH_THANG;

	[AccessedThroughProperty("txtTl_kh")]
	private AsTextNumeric _txtTl_kh;

	[AccessedThroughProperty("lblSo_thang_kh")]
	private Label _lblSo_thang_kh;

	[AccessedThroughProperty("txtSt_kh")]
	private AsTextNumeric _txtSt_kh;

	[AccessedThroughProperty("txtTk_kh")]
	private AsTextBox _txtTk_kh;

	[AccessedThroughProperty("lblTK_KH")]
	private Label _lblTK_KH;

	[AccessedThroughProperty("txtTk_ts")]
	private AsTextBox _txtTk_ts;

	[AccessedThroughProperty("lblTk_TS")]
	private Label _lblTk_TS;

	[AccessedThroughProperty("chkTinh_kh")]
	private AsCheckBox _chkTinh_kh;

	[AccessedThroughProperty("grbChi_Tiet_NV")]
	private GroupBox _grbChi_Tiet_NV;

	[AccessedThroughProperty("txtTk_cp")]
	private AsTextBox _txtTk_cp;

	[AccessedThroughProperty("lblTK_CP")]
	private Label _lblTK_CP;

	[AccessedThroughProperty("lblNguyen_gia")]
	private Label _lblNguyen_gia;

	[AccessedThroughProperty("txtNg_gia_n4")]
	private AsTextNumeric _txtNg_gia_n4;

	[AccessedThroughProperty("txtNg_gia_n3")]
	private AsTextNumeric _txtNg_gia_n3;

	[AccessedThroughProperty("txtNg_gia_n2")]
	private AsTextNumeric _txtNg_gia_n2;

	[AccessedThroughProperty("txtNg_gia_n1")]
	private AsTextNumeric _txtNg_gia_n1;

	[AccessedThroughProperty("lblNguon_von4")]
	private Label _lblNguon_von4;

	[AccessedThroughProperty("lblNguon_von3")]
	private Label _lblNguon_von3;

	[AccessedThroughProperty("lblNguon_von2")]
	private Label _lblNguon_von2;

	[AccessedThroughProperty("lblNguon_von1")]
	private Label _lblNguon_von1;

	[AccessedThroughProperty("lblTong_cong")]
	private Label _lblTong_cong;

	[AccessedThroughProperty("txtT_kh_th")]
	private AsTextNumeric _txtT_kh_th;

	[AccessedThroughProperty("txtT_gt_cl")]
	private AsTextNumeric _txtT_gt_cl;

	[AccessedThroughProperty("txtT_gt_kh")]
	private AsTextNumeric _txtT_gt_kh;

	[AccessedThroughProperty("txtT_ng_gia")]
	private AsTextNumeric _txtT_ng_gia;

	[AccessedThroughProperty("lblGT_KH_1Thang")]
	private Label _lblGT_KH_1Thang;

	[AccessedThroughProperty("txtkh_th_n4")]
	private AsTextNumeric _txtkh_th_n4;

	[AccessedThroughProperty("txtkh_th_n3")]
	private AsTextNumeric _txtkh_th_n3;

	[AccessedThroughProperty("txtkh_th_n2")]
	private AsTextNumeric _txtkh_th_n2;

	[AccessedThroughProperty("txtkh_th_n1")]
	private AsTextNumeric _txtkh_th_n1;

	[AccessedThroughProperty("lblGT_CL")]
	private Label _lblGT_CL;

	[AccessedThroughProperty("txtGt_cl_n4")]
	private AsTextNumeric _txtGt_cl_n4;

	[AccessedThroughProperty("txtGt_cl_n3")]
	private AsTextNumeric _txtGt_cl_n3;

	[AccessedThroughProperty("txtGt_cl_n2")]
	private AsTextNumeric _txtGt_cl_n2;

	[AccessedThroughProperty("txtGt_cl_n1")]
	private AsTextNumeric _txtGt_cl_n1;

	[AccessedThroughProperty("lblGT_DA_KH")]
	private Label _lblGT_DA_KH;

	[AccessedThroughProperty("txtGt_kh_n4")]
	private AsTextNumeric _txtGt_kh_n4;

	[AccessedThroughProperty("txtGt_kh_n3")]
	private AsTextNumeric _txtGt_kh_n3;

	[AccessedThroughProperty("txtGt_kh_n2")]
	private AsTextNumeric _txtGt_kh_n2;

	[AccessedThroughProperty("txtGt_kh_n1")]
	private AsTextNumeric _txtGt_kh_n1;

	[AccessedThroughProperty("txtMa_Lk")]
	private TextBox _txtMa_Lk;

	[AccessedThroughProperty("lblGT")]
	private Label _lblGT;

	[AccessedThroughProperty("txtGia_tri")]
	private AsTextNumeric _txtGia_tri;

	[AccessedThroughProperty("lblSlg1")]
	private Label _lblSlg1;

	[AccessedThroughProperty("txtSo_luonglk")]
	private AsTextNumeric _txtSo_luonglk;

	[AccessedThroughProperty("Ma_cty")]
	private DataGridViewTextBoxColumn _Ma_cty;

	[AccessedThroughProperty("ma_ts")]
	private DataGridViewTextBoxColumn _ma_ts;

	[AccessedThroughProperty("ma_lk")]
	private DataGridViewTextBoxColumn _ma_lk;

	[AccessedThroughProperty("ten_lk")]
	private DataGridViewTextBoxColumn _ten_lk;

	[AccessedThroughProperty("dvt")]
	private DataGridViewTextBoxColumn _dvt;

	[AccessedThroughProperty("so_luong")]
	private DataGridViewAsTextNumericColumn _so_luong;

	[AccessedThroughProperty("Gia_tri")]
	private DataGridViewAsTextNumericColumn _Gia_tri;

	[AccessedThroughProperty("KSD")]
	private DataGridViewCheckBoxColumn _KSD;

	private DataTable f_oTblLK;

	internal virtual Label lblMa_TS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_TS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_TS = value;
		}
	}

	internal virtual TextBox txtMa_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_ts = value;
		}
	}

	internal virtual TextBox txtTen_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_ts = value;
		}
	}

	internal virtual Label lblTen_TS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TS = value;
		}
	}

	internal virtual AsTabControl TabCtlTai_san
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabCtlTai_san;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabCtlTai_san = value;
		}
	}

	internal virtual TabPage tabTTC
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabTTC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabTTC = value;
		}
	}

	internal virtual TabPage tabTTKH
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabTTKH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabTTKH = value;
		}
	}

	internal virtual TabPage tabPT_LK
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabPT_LK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabPT_LK = value;
		}
	}

	internal virtual TextBox txtNha_cc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNha_cc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNha_cc = value;
		}
	}

	internal virtual Label lblNha_cc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNha_cc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNha_cc = value;
		}
	}

	internal virtual TextBox txtcong_suat
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtcong_suat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtcong_suat = value;
		}
	}

	internal virtual Label lblCong_suat
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCong_suat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCong_suat = value;
		}
	}

	internal virtual TextBox txtNuoc_sx
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNuoc_sx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNuoc_sx = value;
		}
	}

	internal virtual Label lblNuoc_sx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNuoc_sx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNuoc_sx = value;
		}
	}

	internal virtual AsCheckBox chkSua_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkSua_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkSua_kh_CheckedChanged;
			if (_chkSua_kh != null)
			{
				((CheckBox)_chkSua_kh).CheckedChanged -= eventHandler;
			}
			_chkSua_kh = value;
			if (_chkSua_kh != null)
			{
				((CheckBox)_chkSua_kh).CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual TextBox txtTen_lk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_lk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_lk = value;
		}
	}

	internal virtual Label lblTen_lk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_lk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_lk = value;
		}
	}

	internal virtual Label lblMa_LK
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_LK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_LK = value;
		}
	}

	internal virtual TextBox txtDvt_Lk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDvt_Lk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDvt_Lk = value;
		}
	}

	internal virtual Label lblDVT1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDVT1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDVT1 = value;
		}
	}

	internal virtual AsCheckBox chkKSD_LK
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkKSD_LK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkKSD_LK = value;
		}
	}

	internal virtual Button cmdAdd_lk
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdAdd_lk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdAdd_lk_Click;
			if (_cmdAdd_lk != null)
			{
				((Control)_cmdAdd_lk).Click -= eventHandler;
			}
			_cmdAdd_lk = value;
			if (_cmdAdd_lk != null)
			{
				((Control)_cmdAdd_lk).Click += eventHandler;
			}
		}
	}

	internal virtual AsInputDGV dgvLinh_kien
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvLinh_kien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvLinh_kien = value;
		}
	}

	internal virtual Button cmdDel_lk
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdDel_lk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdDel_lk_Click;
			if (_cmdDel_lk != null)
			{
				((Control)_cmdDel_lk).Click -= eventHandler;
			}
			_cmdDel_lk = value;
			if (_cmdDel_lk != null)
			{
				((Control)_cmdDel_lk).Click += eventHandler;
			}
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

	internal virtual TextBox txtDvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDvt = value;
		}
	}

	internal virtual Label lblNgay_DVSD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_DVSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_DVSD = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_dvsd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_dvsd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNgay_dvsd_Validated;
			if (_txtNgay_dvsd != null)
			{
				((Control)_txtNgay_dvsd).Validated -= eventHandler;
			}
			_txtNgay_dvsd = value;
			if (_txtNgay_dvsd != null)
			{
				((Control)_txtNgay_dvsd).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtSo_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_luong = value;
		}
	}

	internal virtual Label lblSlg
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSlg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSlg = value;
		}
	}

	internal virtual AsTextNumeric txtNam_sx
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNam_sx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNam_sx = value;
		}
	}

	internal virtual Label lblNam_sx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNam_sx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNam_sx = value;
		}
	}

	internal virtual TextBox txtLd_dc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLd_dc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtLd_dc = value;
		}
	}

	internal virtual Label lblLd_dc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLd_dc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLd_dc = value;
		}
	}

	internal virtual Label lblNgay_DC
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_DC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_DC = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_dc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_dc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_dc = value;
		}
	}

	internal virtual Label lblNgay_GN_GTCL
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_GN_GTCL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_GN_GTCL = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_gt_cl
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_gt_cl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_gt_cl = value;
		}
	}

	internal virtual Label lblNgay_BH_KH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_BH_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_BH_KH = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_bdkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_bdkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_bdkh = value;
		}
	}

	internal virtual Label lblNgay_tang
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_tang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_tang = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_tang
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_tang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNgay_dvsd_Validated;
			if (_txtNgay_tang != null)
			{
				((Control)_txtNgay_tang).Validated -= eventHandler;
			}
			_txtNgay_tang = value;
			if (_txtNgay_tang != null)
			{
				((Control)_txtNgay_tang).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblMa_LDT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_LDT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_LDT = value;
		}
	}

	internal virtual AsTextBox txtMA_LDTG
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMA_LDTG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMA_LDTG = value;
		}
	}

	internal virtual Label lblMa_nhts1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhts1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhts1 = value;
		}
	}

	internal virtual AsTextBox txtMa_nhts1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhts1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhts1 = value;
		}
	}

	internal virtual Label lblNgay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_ct = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_ct = value;
		}
	}

	internal virtual TextBox txtSo_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ct = value;
		}
	}

	internal virtual Label lblSO_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSO_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSO_ct = value;
		}
	}

	internal virtual Label lblMa_BPSD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_BPSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_BPSD = value;
		}
	}

	internal virtual AsTextBox txtMa_bpsd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_bpsd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_bpsd = value;
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

	internal virtual Label lblMa_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_phi = value;
		}
	}

	internal virtual AsTextBox txtMa_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_phi = value;
		}
	}

	internal virtual Label lblMa_nhts3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhts3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhts3 = value;
		}
	}

	internal virtual AsTextBox txtMa_nhts3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhts3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhts3 = value;
		}
	}

	internal virtual Label lblMa_nhts2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhts2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhts2 = value;
		}
	}

	internal virtual AsTextBox txtMa_nhts2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhts2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhts2 = value;
		}
	}

	internal virtual Label lblTy_Le_KH_THANG
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTy_Le_KH_THANG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTy_Le_KH_THANG = value;
		}
	}

	internal virtual AsTextNumeric txtTl_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTl_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTl_kh = value;
		}
	}

	internal virtual Label lblSo_thang_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_thang_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_thang_kh = value;
		}
	}

	internal virtual AsTextNumeric txtSt_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSt_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtSt_kh_Validated;
			if (_txtSt_kh != null)
			{
				((Control)_txtSt_kh).Validated -= eventHandler;
			}
			_txtSt_kh = value;
			if (_txtSt_kh != null)
			{
				((Control)_txtSt_kh).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextBox txtTk_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_kh = value;
		}
	}

	internal virtual Label lblTK_KH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_KH = value;
		}
	}

	internal virtual AsTextBox txtTk_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_ts = value;
		}
	}

	internal virtual Label lblTk_TS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_TS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_TS = value;
		}
	}

	internal virtual AsCheckBox chkTinh_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkTinh_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkTinh_kh_CheckedChanged;
			if (_chkTinh_kh != null)
			{
				((CheckBox)_chkTinh_kh).CheckedChanged -= eventHandler;
			}
			_chkTinh_kh = value;
			if (_chkTinh_kh != null)
			{
				((CheckBox)_chkTinh_kh).CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual GroupBox grbChi_Tiet_NV
	{
		[DebuggerNonUserCode]
		get
		{
			return _grbChi_Tiet_NV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grbChi_Tiet_NV = value;
		}
	}

	internal virtual AsTextBox txtTk_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_cp = value;
		}
	}

	internal virtual Label lblTK_CP
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_CP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_CP = value;
		}
	}

	internal virtual Label lblNguyen_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguyen_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguyen_gia = value;
		}
	}

	internal virtual AsTextNumeric txtNg_gia_n4
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNg_gia_n4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNg_gia_n4_Validated;
			if (_txtNg_gia_n4 != null)
			{
				((Control)_txtNg_gia_n4).Validated -= eventHandler;
			}
			_txtNg_gia_n4 = value;
			if (_txtNg_gia_n4 != null)
			{
				((Control)_txtNg_gia_n4).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtNg_gia_n3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNg_gia_n3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNg_gia_n4_Validated;
			if (_txtNg_gia_n3 != null)
			{
				((Control)_txtNg_gia_n3).Validated -= eventHandler;
			}
			_txtNg_gia_n3 = value;
			if (_txtNg_gia_n3 != null)
			{
				((Control)_txtNg_gia_n3).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtNg_gia_n2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNg_gia_n2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNg_gia_n4_Validated;
			if (_txtNg_gia_n2 != null)
			{
				((Control)_txtNg_gia_n2).Validated -= eventHandler;
			}
			_txtNg_gia_n2 = value;
			if (_txtNg_gia_n2 != null)
			{
				((Control)_txtNg_gia_n2).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtNg_gia_n1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNg_gia_n1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNg_gia_n4_Validated;
			if (_txtNg_gia_n1 != null)
			{
				((Control)_txtNg_gia_n1).Validated -= eventHandler;
			}
			_txtNg_gia_n1 = value;
			if (_txtNg_gia_n1 != null)
			{
				((Control)_txtNg_gia_n1).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblNguon_von4
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguon_von4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguon_von4 = value;
		}
	}

	internal virtual Label lblNguon_von3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguon_von3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguon_von3 = value;
		}
	}

	internal virtual Label lblNguon_von2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguon_von2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguon_von2 = value;
		}
	}

	internal virtual Label lblNguon_von1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguon_von1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguon_von1 = value;
		}
	}

	internal virtual Label lblTong_cong
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTong_cong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTong_cong = value;
		}
	}

	internal virtual AsTextNumeric txtT_kh_th
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_kh_th;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_kh_th = value;
		}
	}

	internal virtual AsTextNumeric txtT_gt_cl
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_gt_cl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_gt_cl = value;
		}
	}

	internal virtual AsTextNumeric txtT_gt_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_gt_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_gt_kh = value;
		}
	}

	internal virtual AsTextNumeric txtT_ng_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_ng_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_ng_gia = value;
		}
	}

	internal virtual Label lblGT_KH_1Thang
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGT_KH_1Thang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGT_KH_1Thang = value;
		}
	}

	internal virtual AsTextNumeric txtkh_th_n4
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtkh_th_n4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNumeric_Validated;
			if (_txtkh_th_n4 != null)
			{
				((Control)_txtkh_th_n4).Validated -= eventHandler;
			}
			_txtkh_th_n4 = value;
			if (_txtkh_th_n4 != null)
			{
				((Control)_txtkh_th_n4).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtkh_th_n3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtkh_th_n3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNumeric_Validated;
			if (_txtkh_th_n3 != null)
			{
				((Control)_txtkh_th_n3).Validated -= eventHandler;
			}
			_txtkh_th_n3 = value;
			if (_txtkh_th_n3 != null)
			{
				((Control)_txtkh_th_n3).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtkh_th_n2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtkh_th_n2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNumeric_Validated;
			if (_txtkh_th_n2 != null)
			{
				((Control)_txtkh_th_n2).Validated -= eventHandler;
			}
			_txtkh_th_n2 = value;
			if (_txtkh_th_n2 != null)
			{
				((Control)_txtkh_th_n2).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtkh_th_n1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtkh_th_n1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNumeric_Validated;
			if (_txtkh_th_n1 != null)
			{
				((Control)_txtkh_th_n1).Validated -= eventHandler;
			}
			_txtkh_th_n1 = value;
			if (_txtkh_th_n1 != null)
			{
				((Control)_txtkh_th_n1).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblGT_CL
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGT_CL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGT_CL = value;
		}
	}

	internal virtual AsTextNumeric txtGt_cl_n4
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGt_cl_n4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGt_cl_n4 = value;
		}
	}

	internal virtual AsTextNumeric txtGt_cl_n3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGt_cl_n3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGt_cl_n3 = value;
		}
	}

	internal virtual AsTextNumeric txtGt_cl_n2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGt_cl_n2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGt_cl_n2 = value;
		}
	}

	internal virtual AsTextNumeric txtGt_cl_n1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGt_cl_n1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGt_cl_n1 = value;
		}
	}

	internal virtual Label lblGT_DA_KH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGT_DA_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGT_DA_KH = value;
		}
	}

	internal virtual AsTextNumeric txtGt_kh_n4
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGt_kh_n4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtGt_kh_n4_Validated;
			if (_txtGt_kh_n4 != null)
			{
				((Control)_txtGt_kh_n4).Validated -= eventHandler;
			}
			_txtGt_kh_n4 = value;
			if (_txtGt_kh_n4 != null)
			{
				((Control)_txtGt_kh_n4).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtGt_kh_n3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGt_kh_n3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtGt_kh_n4_Validated;
			if (_txtGt_kh_n3 != null)
			{
				((Control)_txtGt_kh_n3).Validated -= eventHandler;
			}
			_txtGt_kh_n3 = value;
			if (_txtGt_kh_n3 != null)
			{
				((Control)_txtGt_kh_n3).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtGt_kh_n2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGt_kh_n2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtGt_kh_n4_Validated;
			if (_txtGt_kh_n2 != null)
			{
				((Control)_txtGt_kh_n2).Validated -= eventHandler;
			}
			_txtGt_kh_n2 = value;
			if (_txtGt_kh_n2 != null)
			{
				((Control)_txtGt_kh_n2).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtGt_kh_n1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGt_kh_n1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtGt_kh_n4_Validated;
			if (_txtGt_kh_n1 != null)
			{
				((Control)_txtGt_kh_n1).Validated -= eventHandler;
			}
			_txtGt_kh_n1 = value;
			if (_txtGt_kh_n1 != null)
			{
				((Control)_txtGt_kh_n1).Validated += eventHandler;
			}
		}
	}

	internal virtual TextBox txtMa_Lk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Lk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Lk = value;
		}
	}

	internal virtual Label lblGT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGT = value;
		}
	}

	internal virtual AsTextNumeric txtGia_tri
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGia_tri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGia_tri = value;
		}
	}

	internal virtual Label lblSlg1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSlg1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSlg1 = value;
		}
	}

	internal virtual AsTextNumeric txtSo_luonglk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_luonglk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_luonglk = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Ma_cty
	{
		[DebuggerNonUserCode]
		get
		{
			return _Ma_cty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Ma_cty = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ma_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _ma_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ma_ts = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ma_lk
	{
		[DebuggerNonUserCode]
		get
		{
			return _ma_lk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ma_lk = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ten_lk
	{
		[DebuggerNonUserCode]
		get
		{
			return _ten_lk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ten_lk = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dvt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn so_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _so_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_so_luong = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn Gia_tri
	{
		[DebuggerNonUserCode]
		get
		{
			return _Gia_tri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Gia_tri = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn KSD
	{
		[DebuggerNonUserCode]
		get
		{
			return _KSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_KSD = value;
		}
	}

	private DictionaryController LKController => ControllerFactory.GetDictionaryControllerByCodeName("MA_LK");

	[DebuggerNonUserCode]
	public frmFADMTSEdit()
	{
		__ENCAddToList(this);
		InitializeComponent();
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected O, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected O, but got Unknown
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected O, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected O, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected O, but got Unknown
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2648: Unknown result type (might be due to invalid IL or missing references)
		//IL_29bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c9: Expected O, but got Unknown
		//IL_2a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a70: Expected O, but got Unknown
		//IL_2b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b83: Expected O, but got Unknown
		//IL_2c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c96: Expected O, but got Unknown
		//IL_2d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2da9: Expected O, but got Unknown
		//IL_4cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ccd: Expected O, but got Unknown
		//IL_4daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_4db4: Expected O, but got Unknown
		//IL_4e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e83: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		lblMa_TS = new Label();
		txtMa_ts = new TextBox();
		txtTen_ts = new TextBox();
		lblTen_TS = new Label();
		TabCtlTai_san = new AsTabControl();
		tabTTC = new TabPage();
		lblMa_BPSD = new Label();
		txtMa_bpsd = new AsTextBox();
		lblMa_spct = new Label();
		txtMa_spct = new AsTextBox();
		lblMa_phi = new Label();
		txtMa_phi = new AsTextBox();
		lblMa_nhts3 = new Label();
		txtMa_nhts3 = new AsTextBox();
		lblMa_nhts2 = new Label();
		txtMa_nhts2 = new AsTextBox();
		lblMa_nhts1 = new Label();
		txtMa_nhts1 = new AsTextBox();
		lblNgay_ct = new Label();
		txtNgay_ct = new AsMaskedTextBox();
		txtSo_ct = new TextBox();
		lblSO_ct = new Label();
		lblMa_LDT = new Label();
		txtMA_LDTG = new AsTextBox();
		txtLd_dc = new TextBox();
		lblLd_dc = new Label();
		lblNgay_DC = new Label();
		txtNgay_dc = new AsMaskedTextBox();
		lblNgay_GN_GTCL = new Label();
		txtNgay_gt_cl = new AsMaskedTextBox();
		lblNgay_BH_KH = new Label();
		txtNgay_bdkh = new AsMaskedTextBox();
		lblNgay_tang = new Label();
		txtNgay_tang = new AsMaskedTextBox();
		lblNgay_DVSD = new Label();
		txtNgay_dvsd = new AsMaskedTextBox();
		txtSo_luong = new AsTextNumeric();
		lblSlg = new Label();
		txtNam_sx = new AsTextNumeric();
		lblNam_sx = new Label();
		txtNuoc_sx = new TextBox();
		lblNuoc_sx = new Label();
		txtNha_cc = new TextBox();
		lblNha_cc = new Label();
		txtcong_suat = new TextBox();
		lblCong_suat = new Label();
		tabTTKH = new TabPage();
		grbChi_Tiet_NV = new GroupBox();
		lblTong_cong = new Label();
		txtT_kh_th = new AsTextNumeric();
		txtT_gt_cl = new AsTextNumeric();
		txtT_gt_kh = new AsTextNumeric();
		txtT_ng_gia = new AsTextNumeric();
		lblGT_KH_1Thang = new Label();
		txtkh_th_n4 = new AsTextNumeric();
		txtkh_th_n3 = new AsTextNumeric();
		txtkh_th_n2 = new AsTextNumeric();
		txtkh_th_n1 = new AsTextNumeric();
		lblGT_CL = new Label();
		txtGt_cl_n4 = new AsTextNumeric();
		txtGt_cl_n3 = new AsTextNumeric();
		txtGt_cl_n2 = new AsTextNumeric();
		txtGt_cl_n1 = new AsTextNumeric();
		lblGT_DA_KH = new Label();
		txtGt_kh_n4 = new AsTextNumeric();
		txtGt_kh_n3 = new AsTextNumeric();
		txtGt_kh_n2 = new AsTextNumeric();
		txtGt_kh_n1 = new AsTextNumeric();
		lblNguyen_gia = new Label();
		txtNg_gia_n4 = new AsTextNumeric();
		txtNg_gia_n3 = new AsTextNumeric();
		txtNg_gia_n2 = new AsTextNumeric();
		txtNg_gia_n1 = new AsTextNumeric();
		lblNguon_von4 = new Label();
		lblNguon_von3 = new Label();
		lblNguon_von2 = new Label();
		lblNguon_von1 = new Label();
		txtTk_cp = new AsTextBox();
		lblTK_CP = new Label();
		txtTk_kh = new AsTextBox();
		lblTK_KH = new Label();
		txtTk_ts = new AsTextBox();
		lblTk_TS = new Label();
		chkTinh_kh = new AsCheckBox();
		lblTy_Le_KH_THANG = new Label();
		txtTl_kh = new AsTextNumeric();
		lblSo_thang_kh = new Label();
		txtSt_kh = new AsTextNumeric();
		chkSua_kh = new AsCheckBox();
		tabPT_LK = new TabPage();
		lblGT = new Label();
		txtGia_tri = new AsTextNumeric();
		lblSlg1 = new Label();
		txtSo_luonglk = new AsTextNumeric();
		txtMa_Lk = new TextBox();
		dgvLinh_kien = new AsInputDGV();
		Ma_cty = new DataGridViewTextBoxColumn();
		ma_ts = new DataGridViewTextBoxColumn();
		ma_lk = new DataGridViewTextBoxColumn();
		ten_lk = new DataGridViewTextBoxColumn();
		dvt = new DataGridViewTextBoxColumn();
		so_luong = new DataGridViewAsTextNumericColumn();
		Gia_tri = new DataGridViewAsTextNumericColumn();
		KSD = new DataGridViewCheckBoxColumn();
		cmdDel_lk = new Button();
		cmdAdd_lk = new Button();
		chkKSD_LK = new AsCheckBox();
		txtDvt_Lk = new TextBox();
		lblDVT1 = new Label();
		txtTen_lk = new TextBox();
		lblTen_lk = new Label();
		lblMa_LK = new Label();
		lblDVT = new Label();
		txtDvt = new TextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)TabCtlTai_san).SuspendLayout();
		((Control)tabTTC).SuspendLayout();
		((Control)tabTTKH).SuspendLayout();
		((Control)grbChi_Tiet_NV).SuspendLayout();
		((Control)tabPT_LK).SuspendLayout();
		((ISupportInitialize)dgvLinh_kien).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		Point location = new Point(93, 398);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 5;
		Button obj2 = cmdSave;
		location = new Point(12, 398);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 4;
		((Control)gbLine).Anchor = (AnchorStyles)14;
		GroupBox obj3 = gbLine;
		location = new Point(-2, 387);
		((Control)obj3).Location = location;
		GroupBox obj4 = gbLine;
		Size size = new Size(629, 2);
		((Control)obj4).Size = size;
		((Control)gbLine).Visible = false;
		lblMa_TS.AutoSize = true;
		Label obj5 = lblMa_TS;
		location = new Point(17, 16);
		((Control)obj5).Location = location;
		((Control)lblMa_TS).Name = "lblMa_TS";
		Label obj6 = lblMa_TS;
		size = new Size(56, 13);
		((Control)obj6).Size = size;
		((Control)lblMa_TS).TabIndex = 0;
		lblMa_TS.Text = "Mã tài sản";
		txtMa_ts.CharacterCasing = (CharacterCasing)1;
		TextBox obj7 = txtMa_ts;
		location = new Point(83, 12);
		((Control)obj7).Location = location;
		((TextBoxBase)txtMa_ts).MaxLength = 20;
		((Control)txtMa_ts).Name = "txtMa_ts";
		TextBox obj8 = txtMa_ts;
		size = new Size(100, 20);
		((Control)obj8).Size = size;
		((Control)txtMa_ts).TabIndex = 0;
		TextBox obj9 = txtTen_ts;
		location = new Point(260, 13);
		((Control)obj9).Location = location;
		((Control)txtTen_ts).Name = "txtTen_ts";
		TextBox obj10 = txtTen_ts;
		size = new Size(333, 20);
		((Control)obj10).Size = size;
		((Control)txtTen_ts).TabIndex = 1;
		lblTen_TS.AutoSize = true;
		Label obj11 = lblTen_TS;
		location = new Point(194, 17);
		((Control)obj11).Location = location;
		((Control)lblTen_TS).Name = "lblTen_TS";
		Label obj12 = lblTen_TS;
		size = new Size(60, 13);
		((Control)obj12).Size = size;
		((Control)lblTen_TS).TabIndex = 18;
		lblTen_TS.Text = "Tên tài sản";
		((Control)TabCtlTai_san).Anchor = (AnchorStyles)14;
		((Control)TabCtlTai_san).Controls.Add((Control)(object)tabTTC);
		((Control)TabCtlTai_san).Controls.Add((Control)(object)tabTTKH);
		((Control)TabCtlTai_san).Controls.Add((Control)(object)tabPT_LK);
		((TabControl)TabCtlTai_san).DrawMode = (TabDrawMode)1;
		AsTabControl tabCtlTai_san = TabCtlTai_san;
		location = new Point(2, 64);
		((Control)tabCtlTai_san).Location = location;
		((Control)TabCtlTai_san).Name = "TabCtlTai_san";
		((TabControl)TabCtlTai_san).SelectedIndex = 0;
		AsTabControl tabCtlTai_san2 = TabCtlTai_san;
		size = new Size(623, 331);
		((Control)tabCtlTai_san2).Size = size;
		((Control)TabCtlTai_san).TabIndex = 3;
		tabTTC.BackColor = Color.White;
		((Control)tabTTC).Controls.Add((Control)(object)lblMa_BPSD);
		((Control)tabTTC).Controls.Add((Control)(object)txtMa_bpsd);
		((Control)tabTTC).Controls.Add((Control)(object)lblMa_spct);
		((Control)tabTTC).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabTTC).Controls.Add((Control)(object)lblMa_phi);
		((Control)tabTTC).Controls.Add((Control)(object)txtMa_phi);
		((Control)tabTTC).Controls.Add((Control)(object)lblMa_nhts3);
		((Control)tabTTC).Controls.Add((Control)(object)txtMa_nhts3);
		((Control)tabTTC).Controls.Add((Control)(object)lblMa_nhts2);
		((Control)tabTTC).Controls.Add((Control)(object)txtMa_nhts2);
		((Control)tabTTC).Controls.Add((Control)(object)lblMa_nhts1);
		((Control)tabTTC).Controls.Add((Control)(object)txtMa_nhts1);
		((Control)tabTTC).Controls.Add((Control)(object)lblNgay_ct);
		((Control)tabTTC).Controls.Add((Control)(object)txtNgay_ct);
		((Control)tabTTC).Controls.Add((Control)(object)txtSo_ct);
		((Control)tabTTC).Controls.Add((Control)(object)lblSO_ct);
		((Control)tabTTC).Controls.Add((Control)(object)lblMa_LDT);
		((Control)tabTTC).Controls.Add((Control)(object)txtMA_LDTG);
		((Control)tabTTC).Controls.Add((Control)(object)txtLd_dc);
		((Control)tabTTC).Controls.Add((Control)(object)lblLd_dc);
		((Control)tabTTC).Controls.Add((Control)(object)lblNgay_DC);
		((Control)tabTTC).Controls.Add((Control)(object)txtNgay_dc);
		((Control)tabTTC).Controls.Add((Control)(object)lblNgay_GN_GTCL);
		((Control)tabTTC).Controls.Add((Control)(object)txtNgay_gt_cl);
		((Control)tabTTC).Controls.Add((Control)(object)lblNgay_BH_KH);
		((Control)tabTTC).Controls.Add((Control)(object)txtNgay_bdkh);
		((Control)tabTTC).Controls.Add((Control)(object)lblNgay_tang);
		((Control)tabTTC).Controls.Add((Control)(object)txtNgay_tang);
		((Control)tabTTC).Controls.Add((Control)(object)lblNgay_DVSD);
		((Control)tabTTC).Controls.Add((Control)(object)txtNgay_dvsd);
		((Control)tabTTC).Controls.Add((Control)(object)txtSo_luong);
		((Control)tabTTC).Controls.Add((Control)(object)lblSlg);
		((Control)tabTTC).Controls.Add((Control)(object)txtNam_sx);
		((Control)tabTTC).Controls.Add((Control)(object)lblNam_sx);
		((Control)tabTTC).Controls.Add((Control)(object)txtNuoc_sx);
		((Control)tabTTC).Controls.Add((Control)(object)lblNuoc_sx);
		((Control)tabTTC).Controls.Add((Control)(object)txtNha_cc);
		((Control)tabTTC).Controls.Add((Control)(object)lblNha_cc);
		((Control)tabTTC).Controls.Add((Control)(object)txtcong_suat);
		((Control)tabTTC).Controls.Add((Control)(object)lblCong_suat);
		TabPage obj13 = tabTTC;
		location = new Point(4, 25);
		obj13.Location = location;
		((Control)tabTTC).Name = "tabTTC";
		TabPage obj14 = tabTTC;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)obj14).Padding = padding;
		TabPage obj15 = tabTTC;
		size = new Size(615, 302);
		((Control)obj15).Size = size;
		tabTTC.TabIndex = 0;
		tabTTC.Text = "Thông tin &chung";
		lblMa_BPSD.AutoSize = true;
		Label obj16 = lblMa_BPSD;
		location = new Point(431, 272);
		((Control)obj16).Location = location;
		((Control)lblMa_BPSD).Name = "lblMa_BPSD";
		Label obj17 = lblMa_BPSD;
		size = new Size(54, 13);
		((Control)obj17).Size = size;
		((Control)lblMa_BPSD).TabIndex = 63;
		lblMa_BPSD.Text = "Mã BPSD";
		txtMa_bpsd.AutoLookup = true;
		txtMa_bpsd.AutoValid = true;
		((TextBoxBase)txtMa_bpsd).BackColor = SystemColors.Info;
		((TextBox)txtMa_bpsd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_bpsd;
		location = new Point(515, 268);
		((Control)asTextBox).Location = location;
		txtMa_bpsd.LookupCodeName = "MA_BPSD";
		((Control)txtMa_bpsd).Name = "txtMa_bpsd";
		txtMa_bpsd.NameControl = null;
		txtMa_bpsd.SD = true;
		AsTextBox asTextBox2 = txtMa_bpsd;
		size = new Size(82, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_bpsd).TabIndex = 19;
		((Control)txtMa_bpsd).Tag = "MA_BPSD";
		txtMa_bpsd.UseAutoCompleteSource = true;
		lblMa_spct.AutoSize = true;
		Label obj18 = lblMa_spct;
		location = new Point(431, 246);
		((Control)obj18).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj19 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_spct).TabIndex = 61;
		lblMa_spct.Text = "Mã SPCT";
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = true;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_spct;
		location = new Point(515, 242);
		((Control)asTextBox3).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = null;
		txtMa_spct.SD = true;
		AsTextBox asTextBox4 = txtMa_spct;
		size = new Size(82, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_spct).TabIndex = 18;
		((Control)txtMa_spct).Tag = "MA_SPCT";
		txtMa_spct.UseAutoCompleteSource = true;
		lblMa_phi.AutoSize = true;
		Label obj20 = lblMa_phi;
		location = new Point(431, 220);
		((Control)obj20).Location = location;
		((Control)lblMa_phi).Name = "lblMa_phi";
		Label obj21 = lblMa_phi;
		size = new Size(41, 13);
		((Control)obj21).Size = size;
		((Control)lblMa_phi).TabIndex = 59;
		lblMa_phi.Text = "Mã phí";
		txtMa_phi.AutoLookup = true;
		txtMa_phi.AutoValid = true;
		((TextBoxBase)txtMa_phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_phi;
		location = new Point(515, 216);
		((Control)asTextBox5).Location = location;
		txtMa_phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_phi).Name = "txtMa_phi";
		txtMa_phi.NameControl = null;
		txtMa_phi.SD = true;
		AsTextBox asTextBox6 = txtMa_phi;
		size = new Size(82, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_phi).TabIndex = 17;
		((Control)txtMa_phi).Tag = "MA_PHI";
		txtMa_phi.UseAutoCompleteSource = true;
		lblMa_nhts3.AutoSize = true;
		Label obj22 = lblMa_nhts3;
		location = new Point(431, 155);
		((Control)obj22).Location = location;
		((Control)lblMa_nhts3).Name = "lblMa_nhts3";
		Label obj23 = lblMa_nhts3;
		size = new Size(78, 13);
		((Control)obj23).Size = size;
		((Control)lblMa_nhts3).TabIndex = 57;
		lblMa_nhts3.Text = "Nhóm tài sản 3";
		txtMa_nhts3.AutoLookup = true;
		txtMa_nhts3.AutoValid = true;
		((TextBoxBase)txtMa_nhts3).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhts3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_nhts3;
		location = new Point(515, 152);
		((Control)asTextBox7).Location = location;
		txtMa_nhts3.LookupCodeName = "MA_NHTS";
		txtMa_nhts3.LookupWhereCondition = "loai_nh=3";
		((Control)txtMa_nhts3).Name = "txtMa_nhts3";
		txtMa_nhts3.NameControl = null;
		txtMa_nhts3.SD = true;
		AsTextBox asTextBox8 = txtMa_nhts3;
		size = new Size(82, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_nhts3).TabIndex = 16;
		((Control)txtMa_nhts3).Tag = "MA_NHTS";
		txtMa_nhts3.UseAutoCompleteSource = true;
		lblMa_nhts2.AutoSize = true;
		Label obj24 = lblMa_nhts2;
		location = new Point(431, 129);
		((Control)obj24).Location = location;
		((Control)lblMa_nhts2).Name = "lblMa_nhts2";
		Label obj25 = lblMa_nhts2;
		size = new Size(78, 13);
		((Control)obj25).Size = size;
		((Control)lblMa_nhts2).TabIndex = 55;
		lblMa_nhts2.Text = "Nhóm tài sản 2";
		txtMa_nhts2.AutoLookup = true;
		txtMa_nhts2.AutoValid = true;
		((TextBoxBase)txtMa_nhts2).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhts2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_nhts2;
		location = new Point(515, 126);
		((Control)asTextBox9).Location = location;
		txtMa_nhts2.LookupCodeName = "MA_NHTS";
		txtMa_nhts2.LookupWhereCondition = "loai_nh=2";
		((Control)txtMa_nhts2).Name = "txtMa_nhts2";
		txtMa_nhts2.NameControl = null;
		txtMa_nhts2.SD = true;
		AsTextBox asTextBox10 = txtMa_nhts2;
		size = new Size(82, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_nhts2).TabIndex = 15;
		((Control)txtMa_nhts2).Tag = "MA_NHTS";
		txtMa_nhts2.UseAutoCompleteSource = true;
		lblMa_nhts1.AutoSize = true;
		Label obj26 = lblMa_nhts1;
		location = new Point(431, 103);
		((Control)obj26).Location = location;
		((Control)lblMa_nhts1).Name = "lblMa_nhts1";
		Label obj27 = lblMa_nhts1;
		size = new Size(78, 13);
		((Control)obj27).Size = size;
		((Control)lblMa_nhts1).TabIndex = 53;
		lblMa_nhts1.Text = "Nhóm tài sản 1";
		txtMa_nhts1.AutoLookup = true;
		txtMa_nhts1.AutoValid = true;
		((TextBoxBase)txtMa_nhts1).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhts1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtMa_nhts1;
		location = new Point(515, 100);
		((Control)asTextBox11).Location = location;
		txtMa_nhts1.LookupCodeName = "MA_NHTS";
		txtMa_nhts1.LookupWhereCondition = "loai_nh=1";
		((Control)txtMa_nhts1).Name = "txtMa_nhts1";
		txtMa_nhts1.NameControl = null;
		txtMa_nhts1.SD = true;
		AsTextBox asTextBox12 = txtMa_nhts1;
		size = new Size(82, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtMa_nhts1).TabIndex = 14;
		((Control)txtMa_nhts1).Tag = "MA_NHTS";
		txtMa_nhts1.UseAutoCompleteSource = true;
		lblNgay_ct.AutoSize = true;
		Label obj28 = lblNgay_ct;
		location = new Point(431, 38);
		((Control)obj28).Location = location;
		((Control)lblNgay_ct).Name = "lblNgay_ct";
		Label obj29 = lblNgay_ct;
		size = new Size(77, 13);
		((Control)obj29).Size = size;
		((Control)lblNgay_ct).TabIndex = 51;
		lblNgay_ct.Text = "Ngày chứng từ";
		txtNgay_ct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct;
		location = new Point(515, 34);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ct).Mask = "##/##/####";
		((Control)txtNgay_ct).Name = "txtNgay_ct";
		((MaskedTextBox)txtNgay_ct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ct;
		size = new Size(82, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ct).TabIndex = 13;
		((MaskedTextBox)txtNgay_ct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		TextBox obj30 = txtSo_ct;
		location = new Point(515, 8);
		((Control)obj30).Location = location;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj31 = txtSo_ct;
		size = new Size(82, 20);
		((Control)obj31).Size = size;
		((Control)txtSo_ct).TabIndex = 12;
		((Control)txtSo_ct).Tag = "";
		lblSO_ct.AutoSize = true;
		Label obj32 = lblSO_ct;
		location = new Point(431, 12);
		((Control)obj32).Location = location;
		((Control)lblSO_ct).Name = "lblSO_ct";
		Label obj33 = lblSO_ct;
		size = new Size(65, 13);
		((Control)obj33).Size = size;
		((Control)lblSO_ct).TabIndex = 49;
		lblSO_ct.Text = "Số chứng từ";
		lblMa_LDT.AutoSize = true;
		Label obj34 = lblMa_LDT;
		location = new Point(206, 168);
		((Control)obj34).Location = location;
		((Control)lblMa_LDT).Name = "lblMa_LDT";
		Label obj35 = lblMa_LDT;
		size = new Size(57, 13);
		((Control)obj35).Size = size;
		((Control)lblMa_LDT).TabIndex = 47;
		lblMa_LDT.Text = "Lý do tăng";
		txtMA_LDTG.AutoLookup = true;
		txtMA_LDTG.AutoValid = true;
		((TextBoxBase)txtMA_LDTG).BackColor = SystemColors.Info;
		((TextBox)txtMA_LDTG).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox13 = txtMA_LDTG;
		location = new Point(269, 164);
		((Control)asTextBox13).Location = location;
		txtMA_LDTG.LookupCodeName = "MA_LDTG";
		txtMA_LDTG.LookupWhereCondition = "tg='T'";
		((Control)txtMA_LDTG).Name = "txtMA_LDTG";
		txtMA_LDTG.NameControl = null;
		txtMA_LDTG.SD = true;
		AsTextBox asTextBox14 = txtMA_LDTG;
		size = new Size(82, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtMA_LDTG).TabIndex = 7;
		((Control)txtMA_LDTG).Tag = "MA_LDTG";
		txtMA_LDTG.UseAutoCompleteSource = true;
		TextBox obj36 = txtLd_dc;
		location = new Point(123, 268);
		((Control)obj36).Location = location;
		((Control)txtLd_dc).Name = "txtLd_dc";
		TextBox obj37 = txtLd_dc;
		size = new Size(228, 20);
		((Control)obj37).Size = size;
		((Control)txtLd_dc).TabIndex = 11;
		lblLd_dc.AutoSize = true;
		Label obj38 = lblLd_dc;
		location = new Point(10, 272);
		((Control)obj38).Location = location;
		((Control)lblLd_dc).Name = "lblLd_dc";
		Label obj39 = lblLd_dc;
		size = new Size(74, 13);
		((Control)obj39).Size = size;
		((Control)lblLd_dc).TabIndex = 44;
		lblLd_dc.Text = "Lý do đình chỉ";
		lblNgay_DC.AutoSize = true;
		Label obj40 = lblNgay_DC;
		location = new Point(10, 246);
		((Control)obj40).Location = location;
		((Control)lblNgay_DC).Name = "lblNgay_DC";
		Label obj41 = lblNgay_DC;
		size = new Size(73, 13);
		((Control)obj41).Size = size;
		((Control)lblNgay_DC).TabIndex = 43;
		lblNgay_DC.Text = "Ngày đình chỉ";
		txtNgay_dc.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_dc).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_dc;
		location = new Point(123, 242);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_dc).Mask = "##/##/####";
		((Control)txtNgay_dc).Name = "txtNgay_dc";
		((MaskedTextBox)txtNgay_dc).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_dc;
		size = new Size(82, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_dc).TabIndex = 10;
		((MaskedTextBox)txtNgay_dc).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_dc;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		lblNgay_GN_GTCL.AutoSize = true;
		Label obj42 = lblNgay_GN_GTCL;
		location = new Point(10, 220);
		((Control)obj42).Location = location;
		((Control)lblNgay_GN_GTCL).Name = "lblNgay_GN_GTCL";
		Label obj43 = lblNgay_GN_GTCL;
		size = new Size(107, 13);
		((Control)obj43).Size = size;
		((Control)lblNgay_GN_GTCL).TabIndex = 41;
		lblNgay_GN_GTCL.Text = "Ngày ghi nhận GTCL";
		txtNgay_gt_cl.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_gt_cl).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox7 = txtNgay_gt_cl;
		location = new Point(123, 216);
		((Control)asMaskedTextBox7).Location = location;
		((MaskedTextBox)txtNgay_gt_cl).Mask = "##/##/####";
		((Control)txtNgay_gt_cl).Name = "txtNgay_gt_cl";
		((MaskedTextBox)txtNgay_gt_cl).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox8 = txtNgay_gt_cl;
		size = new Size(82, 20);
		((Control)asMaskedTextBox8).Size = size;
		((Control)txtNgay_gt_cl).TabIndex = 9;
		((Control)txtNgay_gt_cl).Tag = "2";
		((MaskedTextBox)txtNgay_gt_cl).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox9 = txtNgay_gt_cl;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox9.Value = dateTime;
		lblNgay_BH_KH.AutoSize = true;
		Label obj44 = lblNgay_BH_KH;
		location = new Point(10, 194);
		((Control)obj44).Location = location;
		((Control)lblNgay_BH_KH).Name = "lblNgay_BH_KH";
		Label obj45 = lblNgay_BH_KH;
		size = new Size(90, 13);
		((Control)obj45).Size = size;
		((Control)lblNgay_BH_KH).TabIndex = 39;
		lblNgay_BH_KH.Text = "Ngày bắt đầu KH";
		txtNgay_bdkh.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_bdkh).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox10 = txtNgay_bdkh;
		location = new Point(123, 190);
		((Control)asMaskedTextBox10).Location = location;
		((MaskedTextBox)txtNgay_bdkh).Mask = "##/##/####";
		((Control)txtNgay_bdkh).Name = "txtNgay_bdkh";
		((MaskedTextBox)txtNgay_bdkh).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox11 = txtNgay_bdkh;
		size = new Size(82, 20);
		((Control)asMaskedTextBox11).Size = size;
		((Control)txtNgay_bdkh).TabIndex = 8;
		((Control)txtNgay_bdkh).Tag = "1";
		((MaskedTextBox)txtNgay_bdkh).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox12 = txtNgay_bdkh;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox12.Value = dateTime;
		lblNgay_tang.AutoSize = true;
		Label obj46 = lblNgay_tang;
		location = new Point(10, 168);
		((Control)obj46).Location = location;
		((Control)lblNgay_tang).Name = "lblNgay_tang";
		Label obj47 = lblNgay_tang;
		size = new Size(56, 13);
		((Control)obj47).Size = size;
		((Control)lblNgay_tang).TabIndex = 37;
		lblNgay_tang.Text = "Ngày tăng";
		txtNgay_tang.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_tang).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox13 = txtNgay_tang;
		location = new Point(123, 164);
		((Control)asMaskedTextBox13).Location = location;
		((MaskedTextBox)txtNgay_tang).Mask = "##/##/####";
		((Control)txtNgay_tang).Name = "txtNgay_tang";
		((MaskedTextBox)txtNgay_tang).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox14 = txtNgay_tang;
		size = new Size(82, 20);
		((Control)asMaskedTextBox14).Size = size;
		((Control)txtNgay_tang).TabIndex = 6;
		((Control)txtNgay_tang).Tag = "0";
		((MaskedTextBox)txtNgay_tang).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox15 = txtNgay_tang;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox15.Value = dateTime;
		lblNgay_DVSD.AutoSize = true;
		Label obj48 = lblNgay_DVSD;
		location = new Point(10, 142);
		((Control)obj48).Location = location;
		((Control)lblNgay_DVSD).Name = "lblNgay_DVSD";
		Label obj49 = lblNgay_DVSD;
		size = new Size(93, 13);
		((Control)obj49).Size = size;
		((Control)lblNgay_DVSD).TabIndex = 35;
		lblNgay_DVSD.Text = "Ngày đưa vào SD";
		txtNgay_dvsd.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_dvsd).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox16 = txtNgay_dvsd;
		location = new Point(123, 138);
		((Control)asMaskedTextBox16).Location = location;
		((MaskedTextBox)txtNgay_dvsd).Mask = "##/##/####";
		((Control)txtNgay_dvsd).Name = "txtNgay_dvsd";
		((MaskedTextBox)txtNgay_dvsd).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox17 = txtNgay_dvsd;
		size = new Size(82, 20);
		((Control)asMaskedTextBox17).Size = size;
		((Control)txtNgay_dvsd).TabIndex = 5;
		((MaskedTextBox)txtNgay_dvsd).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox18 = txtNgay_dvsd;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox18.Value = dateTime;
		txtSo_luong.DecimalSymbol = ".";
		txtSo_luong.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtSo_luong;
		location = new Point(123, 112);
		((Control)asTextNumeric).Location = location;
		txtSo_luong.Mask = "### ### ### ###";
		((Control)txtSo_luong).Name = "txtSo_luong";
		AsTextNumeric asTextNumeric2 = txtSo_luong;
		size = new Size(82, 20);
		((Control)asTextNumeric2).Size = size;
		txtSo_luong.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSo_luong).TabIndex = 4;
		((TextBox)txtSo_luong).Text = "0";
		((TextBox)txtSo_luong).TextAlign = (HorizontalAlignment)1;
		txtSo_luong.Value = 0;
		lblSlg.AutoSize = true;
		Label obj50 = lblSlg;
		location = new Point(10, 116);
		((Control)obj50).Location = location;
		((Control)lblSlg).Name = "lblSlg";
		Label obj51 = lblSlg;
		size = new Size(49, 13);
		((Control)obj51).Size = size;
		((Control)lblSlg).TabIndex = 32;
		lblSlg.Text = "Số lượng";
		txtNam_sx.DecimalSymbol = ".";
		txtNam_sx.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtNam_sx;
		location = new Point(123, 86);
		((Control)asTextNumeric3).Location = location;
		txtNam_sx.Mask = "####";
		((Control)txtNam_sx).Name = "txtNam_sx";
		AsTextNumeric asTextNumeric4 = txtNam_sx;
		size = new Size(82, 20);
		((Control)asTextNumeric4).Size = size;
		txtNam_sx.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNam_sx).TabIndex = 3;
		((TextBox)txtNam_sx).Text = "0";
		((TextBox)txtNam_sx).TextAlign = (HorizontalAlignment)1;
		txtNam_sx.Value = 0;
		lblNam_sx.AutoSize = true;
		Label obj52 = lblNam_sx;
		location = new Point(10, 90);
		((Control)obj52).Location = location;
		((Control)lblNam_sx).Name = "lblNam_sx";
		Label obj53 = lblNam_sx;
		size = new Size(72, 13);
		((Control)obj53).Size = size;
		((Control)lblNam_sx).TabIndex = 30;
		lblNam_sx.Text = "Năm sản xuất";
		TextBox obj54 = txtNuoc_sx;
		location = new Point(123, 34);
		((Control)obj54).Location = location;
		((Control)txtNuoc_sx).Name = "txtNuoc_sx";
		TextBox obj55 = txtNuoc_sx;
		size = new Size(228, 20);
		((Control)obj55).Size = size;
		((Control)txtNuoc_sx).TabIndex = 1;
		lblNuoc_sx.AutoSize = true;
		Label obj56 = lblNuoc_sx;
		location = new Point(10, 38);
		((Control)obj56).Location = location;
		((Control)lblNuoc_sx).Name = "lblNuoc_sx";
		Label obj57 = lblNuoc_sx;
		size = new Size(76, 13);
		((Control)obj57).Size = size;
		((Control)lblNuoc_sx).TabIndex = 4;
		lblNuoc_sx.Text = "Nước sản xuất";
		TextBox obj58 = txtNha_cc;
		location = new Point(123, 8);
		((Control)obj58).Location = location;
		((Control)txtNha_cc).Name = "txtNha_cc";
		TextBox obj59 = txtNha_cc;
		size = new Size(228, 20);
		((Control)obj59).Size = size;
		((Control)txtNha_cc).TabIndex = 0;
		((Control)txtNha_cc).Tag = "";
		lblNha_cc.AutoSize = true;
		Label obj60 = lblNha_cc;
		location = new Point(10, 12);
		((Control)obj60).Location = location;
		((Control)lblNha_cc).Name = "lblNha_cc";
		Label obj61 = lblNha_cc;
		size = new Size(75, 13);
		((Control)obj61).Size = size;
		((Control)lblNha_cc).TabIndex = 2;
		lblNha_cc.Text = "Nhà cung cấp";
		TextBox obj62 = txtcong_suat;
		location = new Point(123, 60);
		((Control)obj62).Location = location;
		((Control)txtcong_suat).Name = "txtcong_suat";
		TextBox obj63 = txtcong_suat;
		size = new Size(228, 20);
		((Control)obj63).Size = size;
		((Control)txtcong_suat).TabIndex = 2;
		lblCong_suat.AutoSize = true;
		Label obj64 = lblCong_suat;
		location = new Point(10, 64);
		((Control)obj64).Location = location;
		((Control)lblCong_suat).Name = "lblCong_suat";
		Label obj65 = lblCong_suat;
		size = new Size(55, 13);
		((Control)obj65).Size = size;
		((Control)lblCong_suat).TabIndex = 0;
		lblCong_suat.Text = "Công suất";
		tabTTKH.BackColor = Color.White;
		((Control)tabTTKH).Controls.Add((Control)(object)grbChi_Tiet_NV);
		((Control)tabTTKH).Controls.Add((Control)(object)txtTk_cp);
		((Control)tabTTKH).Controls.Add((Control)(object)lblTK_CP);
		((Control)tabTTKH).Controls.Add((Control)(object)txtTk_kh);
		((Control)tabTTKH).Controls.Add((Control)(object)lblTK_KH);
		((Control)tabTTKH).Controls.Add((Control)(object)txtTk_ts);
		((Control)tabTTKH).Controls.Add((Control)(object)lblTk_TS);
		((Control)tabTTKH).Controls.Add((Control)(object)chkTinh_kh);
		((Control)tabTTKH).Controls.Add((Control)(object)lblTy_Le_KH_THANG);
		((Control)tabTTKH).Controls.Add((Control)(object)txtTl_kh);
		((Control)tabTTKH).Controls.Add((Control)(object)lblSo_thang_kh);
		((Control)tabTTKH).Controls.Add((Control)(object)txtSt_kh);
		((Control)tabTTKH).Controls.Add((Control)(object)chkSua_kh);
		TabPage obj66 = tabTTKH;
		location = new Point(4, 25);
		obj66.Location = location;
		((Control)tabTTKH).Name = "tabTTKH";
		TabPage obj67 = tabTTKH;
		((Padding)(ref padding))._002Ector(3);
		((Control)obj67).Padding = padding;
		TabPage obj68 = tabTTKH;
		size = new Size(615, 302);
		((Control)obj68).Size = size;
		tabTTKH.TabIndex = 1;
		tabTTKH.Text = "Thông tin &khấu hao";
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblTong_cong);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtT_kh_th);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtT_gt_cl);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtT_gt_kh);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtT_ng_gia);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblGT_KH_1Thang);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtkh_th_n4);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtkh_th_n3);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtkh_th_n2);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtkh_th_n1);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblGT_CL);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtGt_cl_n4);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtGt_cl_n3);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtGt_cl_n2);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtGt_cl_n1);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblGT_DA_KH);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtGt_kh_n4);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtGt_kh_n3);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtGt_kh_n2);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtGt_kh_n1);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblNguyen_gia);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtNg_gia_n4);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtNg_gia_n3);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtNg_gia_n2);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtNg_gia_n1);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblNguon_von4);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblNguon_von3);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblNguon_von2);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblNguon_von1);
		GroupBox obj69 = grbChi_Tiet_NV;
		location = new Point(4, 120);
		((Control)obj69).Location = location;
		((Control)grbChi_Tiet_NV).Name = "grbChi_Tiet_NV";
		GroupBox obj70 = grbChi_Tiet_NV;
		size = new Size(607, 177);
		((Control)obj70).Size = size;
		((Control)grbChi_Tiet_NV).TabIndex = 44;
		grbChi_Tiet_NV.TabStop = false;
		grbChi_Tiet_NV.Text = "Chi tiết nguồn vốn";
		lblTong_cong.AutoSize = true;
		((Control)lblTong_cong).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj71 = lblTong_cong;
		location = new Point(17, 147);
		((Control)obj71).Location = location;
		((Control)lblTong_cong).Name = "lblTong_cong";
		Label obj72 = lblTong_cong;
		size = new Size(68, 13);
		((Control)obj72).Size = size;
		((Control)lblTong_cong).TabIndex = 70;
		lblTong_cong.Text = "Tổng cộng";
		((TextBoxBase)txtT_kh_th).BackColor = Color.White;
		txtT_kh_th.DecimalSymbol = ".";
		((Control)txtT_kh_th).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_kh_th.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtT_kh_th;
		location = new Point(491, 144);
		((Control)asTextNumeric5).Location = location;
		txtT_kh_th.Mask = "### ### ### ###.##";
		((Control)txtT_kh_th).Name = "txtT_kh_th";
		((TextBoxBase)txtT_kh_th).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtT_kh_th;
		size = new Size(111, 20);
		((Control)asTextNumeric6).Size = size;
		txtT_kh_th.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_kh_th).TabIndex = 19;
		((Control)txtT_kh_th).Tag = "OA";
		((TextBox)txtT_kh_th).Text = "0.00";
		((TextBox)txtT_kh_th).TextAlign = (HorizontalAlignment)1;
		txtT_kh_th.Value = 0;
		((TextBoxBase)txtT_gt_cl).BackColor = Color.White;
		txtT_gt_cl.DecimalSymbol = ".";
		((Control)txtT_gt_cl).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_gt_cl.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtT_gt_cl;
		location = new Point(374, 144);
		((Control)asTextNumeric7).Location = location;
		txtT_gt_cl.Mask = "### ### ### ###.##";
		((Control)txtT_gt_cl).Name = "txtT_gt_cl";
		((TextBoxBase)txtT_gt_cl).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_gt_cl;
		size = new Size(111, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_gt_cl.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_gt_cl).TabIndex = 14;
		((Control)txtT_gt_cl).Tag = "OA";
		((TextBox)txtT_gt_cl).Text = "0.00";
		((TextBox)txtT_gt_cl).TextAlign = (HorizontalAlignment)1;
		txtT_gt_cl.Value = 0;
		((TextBoxBase)txtT_gt_kh).BackColor = Color.White;
		txtT_gt_kh.DecimalSymbol = ".";
		((Control)txtT_gt_kh).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_gt_kh.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric9 = txtT_gt_kh;
		location = new Point(257, 144);
		((Control)asTextNumeric9).Location = location;
		txtT_gt_kh.Mask = "### ### ### ###.##";
		((Control)txtT_gt_kh).Name = "txtT_gt_kh";
		((TextBoxBase)txtT_gt_kh).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtT_gt_kh;
		size = new Size(111, 20);
		((Control)asTextNumeric10).Size = size;
		txtT_gt_kh.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_gt_kh).TabIndex = 9;
		((Control)txtT_gt_kh).Tag = "OA";
		((TextBox)txtT_gt_kh).Text = "0.00";
		((TextBox)txtT_gt_kh).TextAlign = (HorizontalAlignment)1;
		txtT_gt_kh.Value = 0;
		((TextBoxBase)txtT_ng_gia).BackColor = Color.White;
		txtT_ng_gia.DecimalSymbol = ".";
		((Control)txtT_ng_gia).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_ng_gia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric11 = txtT_ng_gia;
		location = new Point(140, 144);
		((Control)asTextNumeric11).Location = location;
		txtT_ng_gia.Mask = "### ### ### ###.##";
		((Control)txtT_ng_gia).Name = "txtT_ng_gia";
		((TextBoxBase)txtT_ng_gia).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtT_ng_gia;
		size = new Size(111, 20);
		((Control)asTextNumeric12).Size = size;
		txtT_ng_gia.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_ng_gia).TabIndex = 4;
		((Control)txtT_ng_gia).Tag = "OA";
		((TextBox)txtT_ng_gia).Text = "0.00";
		((TextBox)txtT_ng_gia).TextAlign = (HorizontalAlignment)1;
		txtT_ng_gia.Value = 0;
		lblGT_KH_1Thang.AutoSize = true;
		Label obj73 = lblGT_KH_1Thang;
		location = new Point(490, 22);
		((Control)obj73).Location = location;
		((Control)lblGT_KH_1Thang).Name = "lblGT_KH_1Thang";
		Label obj74 = lblGT_KH_1Thang;
		size = new Size(91, 13);
		((Control)obj74).Size = size;
		((Control)lblGT_KH_1Thang).TabIndex = 65;
		lblGT_KH_1Thang.Text = "Giá trị KH 1 tháng";
		((TextBoxBase)txtkh_th_n4).BackColor = Color.White;
		txtkh_th_n4.DecimalSymbol = ".";
		((Control)txtkh_th_n4).Enabled = false;
		txtkh_th_n4.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric13 = txtkh_th_n4;
		location = new Point(491, 118);
		((Control)asTextNumeric13).Location = location;
		txtkh_th_n4.Mask = "### ### ### ###.##";
		((Control)txtkh_th_n4).Name = "txtkh_th_n4";
		AsTextNumeric asTextNumeric14 = txtkh_th_n4;
		size = new Size(111, 20);
		((Control)asTextNumeric14).Size = size;
		txtkh_th_n4.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtkh_th_n4).TabIndex = 18;
		((Control)txtkh_th_n4).Tag = "OA";
		((TextBox)txtkh_th_n4).Text = "0.00";
		((TextBox)txtkh_th_n4).TextAlign = (HorizontalAlignment)1;
		txtkh_th_n4.Value = 0;
		((TextBoxBase)txtkh_th_n3).BackColor = Color.White;
		txtkh_th_n3.DecimalSymbol = ".";
		((Control)txtkh_th_n3).Enabled = false;
		txtkh_th_n3.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric15 = txtkh_th_n3;
		location = new Point(491, 92);
		((Control)asTextNumeric15).Location = location;
		txtkh_th_n3.Mask = "### ### ### ###.##";
		((Control)txtkh_th_n3).Name = "txtkh_th_n3";
		AsTextNumeric asTextNumeric16 = txtkh_th_n3;
		size = new Size(111, 20);
		((Control)asTextNumeric16).Size = size;
		txtkh_th_n3.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtkh_th_n3).TabIndex = 17;
		((Control)txtkh_th_n3).Tag = "OA";
		((TextBox)txtkh_th_n3).Text = "0.00";
		((TextBox)txtkh_th_n3).TextAlign = (HorizontalAlignment)1;
		txtkh_th_n3.Value = 0;
		((TextBoxBase)txtkh_th_n2).BackColor = Color.White;
		txtkh_th_n2.DecimalSymbol = ".";
		((Control)txtkh_th_n2).Enabled = false;
		txtkh_th_n2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric17 = txtkh_th_n2;
		location = new Point(491, 66);
		((Control)asTextNumeric17).Location = location;
		txtkh_th_n2.Mask = "### ### ### ###.##";
		((Control)txtkh_th_n2).Name = "txtkh_th_n2";
		AsTextNumeric asTextNumeric18 = txtkh_th_n2;
		size = new Size(111, 20);
		((Control)asTextNumeric18).Size = size;
		txtkh_th_n2.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtkh_th_n2).TabIndex = 16;
		((Control)txtkh_th_n2).Tag = "OA";
		((TextBox)txtkh_th_n2).Text = "0.00";
		((TextBox)txtkh_th_n2).TextAlign = (HorizontalAlignment)1;
		txtkh_th_n2.Value = 0;
		((TextBoxBase)txtkh_th_n1).BackColor = Color.White;
		txtkh_th_n1.DecimalSymbol = ".";
		((Control)txtkh_th_n1).Enabled = false;
		txtkh_th_n1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric19 = txtkh_th_n1;
		location = new Point(491, 40);
		((Control)asTextNumeric19).Location = location;
		txtkh_th_n1.Mask = "### ### ### ###.##";
		((Control)txtkh_th_n1).Name = "txtkh_th_n1";
		AsTextNumeric asTextNumeric20 = txtkh_th_n1;
		size = new Size(111, 20);
		((Control)asTextNumeric20).Size = size;
		txtkh_th_n1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtkh_th_n1).TabIndex = 15;
		((Control)txtkh_th_n1).Tag = "OA";
		((TextBox)txtkh_th_n1).Text = "0.00";
		((TextBox)txtkh_th_n1).TextAlign = (HorizontalAlignment)1;
		txtkh_th_n1.Value = 0;
		lblGT_CL.AutoSize = true;
		Label obj75 = lblGT_CL;
		location = new Point(373, 22);
		((Control)obj75).Location = location;
		((Control)lblGT_CL).Name = "lblGT_CL";
		Label obj76 = lblGT_CL;
		size = new Size(68, 13);
		((Control)obj76).Size = size;
		((Control)lblGT_CL).TabIndex = 60;
		lblGT_CL.Text = "Giá trị còn lại";
		((TextBoxBase)txtGt_cl_n4).BackColor = Color.White;
		txtGt_cl_n4.DecimalSymbol = ".";
		((Control)txtGt_cl_n4).Enabled = false;
		txtGt_cl_n4.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric21 = txtGt_cl_n4;
		location = new Point(374, 118);
		((Control)asTextNumeric21).Location = location;
		txtGt_cl_n4.Mask = "### ### ### ###.##";
		((Control)txtGt_cl_n4).Name = "txtGt_cl_n4";
		AsTextNumeric asTextNumeric22 = txtGt_cl_n4;
		size = new Size(111, 20);
		((Control)asTextNumeric22).Size = size;
		txtGt_cl_n4.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_cl_n4).TabIndex = 13;
		((Control)txtGt_cl_n4).Tag = "OA";
		((TextBox)txtGt_cl_n4).Text = "0.00";
		((TextBox)txtGt_cl_n4).TextAlign = (HorizontalAlignment)1;
		txtGt_cl_n4.Value = 0;
		((TextBoxBase)txtGt_cl_n3).BackColor = Color.White;
		txtGt_cl_n3.DecimalSymbol = ".";
		((Control)txtGt_cl_n3).Enabled = false;
		txtGt_cl_n3.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric23 = txtGt_cl_n3;
		location = new Point(374, 92);
		((Control)asTextNumeric23).Location = location;
		txtGt_cl_n3.Mask = "### ### ### ###.##";
		((Control)txtGt_cl_n3).Name = "txtGt_cl_n3";
		AsTextNumeric asTextNumeric24 = txtGt_cl_n3;
		size = new Size(111, 20);
		((Control)asTextNumeric24).Size = size;
		txtGt_cl_n3.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_cl_n3).TabIndex = 12;
		((Control)txtGt_cl_n3).Tag = "OA";
		((TextBox)txtGt_cl_n3).Text = "0.00";
		((TextBox)txtGt_cl_n3).TextAlign = (HorizontalAlignment)1;
		txtGt_cl_n3.Value = 0;
		((TextBoxBase)txtGt_cl_n2).BackColor = Color.White;
		txtGt_cl_n2.DecimalSymbol = ".";
		((Control)txtGt_cl_n2).Enabled = false;
		txtGt_cl_n2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric25 = txtGt_cl_n2;
		location = new Point(374, 66);
		((Control)asTextNumeric25).Location = location;
		txtGt_cl_n2.Mask = "### ### ### ###.##";
		((Control)txtGt_cl_n2).Name = "txtGt_cl_n2";
		AsTextNumeric asTextNumeric26 = txtGt_cl_n2;
		size = new Size(111, 20);
		((Control)asTextNumeric26).Size = size;
		txtGt_cl_n2.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_cl_n2).TabIndex = 11;
		((Control)txtGt_cl_n2).Tag = "OA";
		((TextBox)txtGt_cl_n2).Text = "0.00";
		((TextBox)txtGt_cl_n2).TextAlign = (HorizontalAlignment)1;
		txtGt_cl_n2.Value = 0;
		((TextBoxBase)txtGt_cl_n1).BackColor = Color.White;
		txtGt_cl_n1.DecimalSymbol = ".";
		((Control)txtGt_cl_n1).Enabled = false;
		txtGt_cl_n1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric27 = txtGt_cl_n1;
		location = new Point(374, 40);
		((Control)asTextNumeric27).Location = location;
		txtGt_cl_n1.Mask = "### ### ### ###.##";
		((Control)txtGt_cl_n1).Name = "txtGt_cl_n1";
		AsTextNumeric asTextNumeric28 = txtGt_cl_n1;
		size = new Size(111, 20);
		((Control)asTextNumeric28).Size = size;
		txtGt_cl_n1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_cl_n1).TabIndex = 10;
		((Control)txtGt_cl_n1).Tag = "OA";
		((TextBox)txtGt_cl_n1).Text = "0.00";
		((TextBox)txtGt_cl_n1).TextAlign = (HorizontalAlignment)1;
		txtGt_cl_n1.Value = 0;
		lblGT_DA_KH.AutoSize = true;
		Label obj77 = lblGT_DA_KH;
		location = new Point(256, 22);
		((Control)obj77).Location = location;
		((Control)lblGT_DA_KH).Name = "lblGT_DA_KH";
		Label obj78 = lblGT_DA_KH;
		size = new Size(68, 13);
		((Control)obj78).Size = size;
		((Control)lblGT_DA_KH).TabIndex = 55;
		lblGT_DA_KH.Text = "Giá trị đã KH";
		txtGt_kh_n4.DecimalSymbol = ".";
		txtGt_kh_n4.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric29 = txtGt_kh_n4;
		location = new Point(257, 118);
		((Control)asTextNumeric29).Location = location;
		txtGt_kh_n4.Mask = "### ### ### ###.##";
		((Control)txtGt_kh_n4).Name = "txtGt_kh_n4";
		AsTextNumeric asTextNumeric30 = txtGt_kh_n4;
		size = new Size(111, 20);
		((Control)asTextNumeric30).Size = size;
		txtGt_kh_n4.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_kh_n4).TabIndex = 8;
		((Control)txtGt_kh_n4).Tag = "OA";
		((TextBox)txtGt_kh_n4).Text = "0.00";
		((TextBox)txtGt_kh_n4).TextAlign = (HorizontalAlignment)1;
		txtGt_kh_n4.Value = 0;
		txtGt_kh_n3.DecimalSymbol = ".";
		txtGt_kh_n3.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric31 = txtGt_kh_n3;
		location = new Point(257, 92);
		((Control)asTextNumeric31).Location = location;
		txtGt_kh_n3.Mask = "### ### ### ###.##";
		((Control)txtGt_kh_n3).Name = "txtGt_kh_n3";
		AsTextNumeric asTextNumeric32 = txtGt_kh_n3;
		size = new Size(111, 20);
		((Control)asTextNumeric32).Size = size;
		txtGt_kh_n3.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_kh_n3).TabIndex = 7;
		((Control)txtGt_kh_n3).Tag = "OA";
		((TextBox)txtGt_kh_n3).Text = "0.00";
		((TextBox)txtGt_kh_n3).TextAlign = (HorizontalAlignment)1;
		txtGt_kh_n3.Value = 0;
		txtGt_kh_n2.DecimalSymbol = ".";
		txtGt_kh_n2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric33 = txtGt_kh_n2;
		location = new Point(257, 66);
		((Control)asTextNumeric33).Location = location;
		txtGt_kh_n2.Mask = "### ### ### ###.##";
		((Control)txtGt_kh_n2).Name = "txtGt_kh_n2";
		AsTextNumeric asTextNumeric34 = txtGt_kh_n2;
		size = new Size(111, 20);
		((Control)asTextNumeric34).Size = size;
		txtGt_kh_n2.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_kh_n2).TabIndex = 6;
		((Control)txtGt_kh_n2).Tag = "OA";
		((TextBox)txtGt_kh_n2).Text = "0.00";
		((TextBox)txtGt_kh_n2).TextAlign = (HorizontalAlignment)1;
		txtGt_kh_n2.Value = 0;
		txtGt_kh_n1.DecimalSymbol = ".";
		txtGt_kh_n1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric35 = txtGt_kh_n1;
		location = new Point(257, 40);
		((Control)asTextNumeric35).Location = location;
		txtGt_kh_n1.Mask = "### ### ### ###.##";
		((Control)txtGt_kh_n1).Name = "txtGt_kh_n1";
		AsTextNumeric asTextNumeric36 = txtGt_kh_n1;
		size = new Size(111, 20);
		((Control)asTextNumeric36).Size = size;
		txtGt_kh_n1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_kh_n1).TabIndex = 5;
		((Control)txtGt_kh_n1).Tag = "OA";
		((TextBox)txtGt_kh_n1).Text = "0.00";
		((TextBox)txtGt_kh_n1).TextAlign = (HorizontalAlignment)1;
		txtGt_kh_n1.Value = 0;
		lblNguyen_gia.AutoSize = true;
		Label obj79 = lblNguyen_gia;
		location = new Point(139, 22);
		((Control)obj79).Location = location;
		((Control)lblNguyen_gia).Name = "lblNguyen_gia";
		Label obj80 = lblNguyen_gia;
		size = new Size(61, 13);
		((Control)obj80).Size = size;
		((Control)lblNguyen_gia).TabIndex = 50;
		lblNguyen_gia.Text = "Nguyên giá";
		txtNg_gia_n4.DecimalSymbol = ".";
		txtNg_gia_n4.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric37 = txtNg_gia_n4;
		location = new Point(140, 118);
		((Control)asTextNumeric37).Location = location;
		txtNg_gia_n4.Mask = "### ### ### ###.##";
		((Control)txtNg_gia_n4).Name = "txtNg_gia_n4";
		AsTextNumeric asTextNumeric38 = txtNg_gia_n4;
		size = new Size(111, 20);
		((Control)asTextNumeric38).Size = size;
		txtNg_gia_n4.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNg_gia_n4).TabIndex = 3;
		((Control)txtNg_gia_n4).Tag = "OA";
		((TextBox)txtNg_gia_n4).Text = "0.00";
		((TextBox)txtNg_gia_n4).TextAlign = (HorizontalAlignment)1;
		txtNg_gia_n4.Value = 0;
		txtNg_gia_n3.DecimalSymbol = ".";
		txtNg_gia_n3.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric39 = txtNg_gia_n3;
		location = new Point(140, 92);
		((Control)asTextNumeric39).Location = location;
		txtNg_gia_n3.Mask = "### ### ### ###.##";
		((Control)txtNg_gia_n3).Name = "txtNg_gia_n3";
		AsTextNumeric asTextNumeric40 = txtNg_gia_n3;
		size = new Size(111, 20);
		((Control)asTextNumeric40).Size = size;
		txtNg_gia_n3.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNg_gia_n3).TabIndex = 2;
		((Control)txtNg_gia_n3).Tag = "OA";
		((TextBox)txtNg_gia_n3).Text = "0.00";
		((TextBox)txtNg_gia_n3).TextAlign = (HorizontalAlignment)1;
		txtNg_gia_n3.Value = 0;
		txtNg_gia_n2.DecimalSymbol = ".";
		txtNg_gia_n2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric41 = txtNg_gia_n2;
		location = new Point(140, 66);
		((Control)asTextNumeric41).Location = location;
		txtNg_gia_n2.Mask = "### ### ### ###.##";
		((Control)txtNg_gia_n2).Name = "txtNg_gia_n2";
		AsTextNumeric asTextNumeric42 = txtNg_gia_n2;
		size = new Size(111, 20);
		((Control)asTextNumeric42).Size = size;
		txtNg_gia_n2.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNg_gia_n2).TabIndex = 1;
		((Control)txtNg_gia_n2).Tag = "OA";
		((TextBox)txtNg_gia_n2).Text = "0.00";
		((TextBox)txtNg_gia_n2).TextAlign = (HorizontalAlignment)1;
		txtNg_gia_n2.Value = 0;
		txtNg_gia_n1.DecimalSymbol = ".";
		txtNg_gia_n1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric43 = txtNg_gia_n1;
		location = new Point(140, 40);
		((Control)asTextNumeric43).Location = location;
		txtNg_gia_n1.Mask = "### ### ### ###.##";
		((Control)txtNg_gia_n1).Name = "txtNg_gia_n1";
		AsTextNumeric asTextNumeric44 = txtNg_gia_n1;
		size = new Size(111, 20);
		((Control)asTextNumeric44).Size = size;
		txtNg_gia_n1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNg_gia_n1).TabIndex = 0;
		((Control)txtNg_gia_n1).Tag = "OA";
		((TextBox)txtNg_gia_n1).Text = "0.00";
		((TextBox)txtNg_gia_n1).TextAlign = (HorizontalAlignment)1;
		txtNg_gia_n1.Value = 0;
		Label obj81 = lblNguon_von4;
		location = new Point(17, 121);
		((Control)obj81).Location = location;
		((Control)lblNguon_von4).Name = "lblNguon_von4";
		Label obj82 = lblNguon_von4;
		size = new Size(117, 13);
		((Control)obj82).Size = size;
		((Control)lblNguon_von4).TabIndex = 45;
		Label obj83 = lblNguon_von3;
		location = new Point(17, 95);
		((Control)obj83).Location = location;
		((Control)lblNguon_von3).Name = "lblNguon_von3";
		Label obj84 = lblNguon_von3;
		size = new Size(117, 13);
		((Control)obj84).Size = size;
		((Control)lblNguon_von3).TabIndex = 44;
		Label obj85 = lblNguon_von2;
		location = new Point(17, 69);
		((Control)obj85).Location = location;
		((Control)lblNguon_von2).Name = "lblNguon_von2";
		Label obj86 = lblNguon_von2;
		size = new Size(117, 13);
		((Control)obj86).Size = size;
		((Control)lblNguon_von2).TabIndex = 43;
		Label obj87 = lblNguon_von1;
		location = new Point(17, 43);
		((Control)obj87).Location = location;
		((Control)lblNguon_von1).Name = "lblNguon_von1";
		Label obj88 = lblNguon_von1;
		size = new Size(117, 13);
		((Control)obj88).Size = size;
		((Control)lblNguon_von1).TabIndex = 42;
		txtTk_cp.AutoLookup = true;
		txtTk_cp.AutoValid = true;
		((TextBoxBase)txtTk_cp).BackColor = SystemColors.Info;
		((TextBox)txtTk_cp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox15 = txtTk_cp;
		location = new Point(506, 60);
		((Control)asTextBox15).Location = location;
		txtTk_cp.LookupCodeName = "TK";
		txtTk_cp.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_cp).Name = "txtTk_cp";
		txtTk_cp.NameControl = null;
		txtTk_cp.SD = true;
		AsTextBox asTextBox16 = txtTk_cp;
		size = new Size(80, 20);
		((Control)asTextBox16).Size = size;
		((Control)txtTk_cp).TabIndex = 5;
		((Control)txtTk_cp).Tag = "@pTK";
		txtTk_cp.UseAutoCompleteSource = true;
		lblTK_CP.AutoSize = true;
		Label obj89 = lblTK_CP;
		location = new Point(397, 64);
		((Control)obj89).Location = location;
		((Control)lblTK_CP).Name = "lblTK_CP";
		Label obj90 = lblTK_CP;
		size = new Size(91, 13);
		((Control)obj90).Size = size;
		((Control)lblTK_CP).TabIndex = 43;
		lblTK_CP.Text = "Tài khoản chi phí";
		txtTk_kh.AutoLookup = true;
		txtTk_kh.AutoValid = true;
		((TextBoxBase)txtTk_kh).BackColor = SystemColors.Info;
		((TextBox)txtTk_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox17 = txtTk_kh;
		location = new Point(506, 34);
		((Control)asTextBox17).Location = location;
		txtTk_kh.LookupCodeName = "TK";
		txtTk_kh.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_kh).Name = "txtTk_kh";
		txtTk_kh.NameControl = null;
		txtTk_kh.SD = true;
		AsTextBox asTextBox18 = txtTk_kh;
		size = new Size(80, 20);
		((Control)asTextBox18).Size = size;
		((Control)txtTk_kh).TabIndex = 4;
		((Control)txtTk_kh).Tag = "@pTK";
		txtTk_kh.UseAutoCompleteSource = true;
		lblTK_KH.AutoSize = true;
		Label obj91 = lblTK_KH;
		location = new Point(397, 38);
		((Control)obj91).Location = location;
		((Control)lblTK_KH).Name = "lblTK_KH";
		Label obj92 = lblTK_KH;
		size = new Size(103, 13);
		((Control)obj92).Size = size;
		((Control)lblTK_KH).TabIndex = 41;
		lblTK_KH.Text = "Tài khoản khấu hao";
		txtTk_ts.AutoLookup = true;
		txtTk_ts.AutoValid = true;
		((TextBoxBase)txtTk_ts).BackColor = SystemColors.Info;
		((TextBox)txtTk_ts).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox19 = txtTk_ts;
		location = new Point(506, 8);
		((Control)asTextBox19).Location = location;
		txtTk_ts.LookupCodeName = "TK";
		txtTk_ts.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_ts).Name = "txtTk_ts";
		txtTk_ts.NameControl = null;
		txtTk_ts.SD = true;
		AsTextBox asTextBox20 = txtTk_ts;
		size = new Size(80, 20);
		((Control)asTextBox20).Size = size;
		((Control)txtTk_ts).TabIndex = 3;
		((Control)txtTk_ts).Tag = "@pTK";
		txtTk_ts.UseAutoCompleteSource = true;
		lblTk_TS.AutoSize = true;
		Label obj93 = lblTk_TS;
		location = new Point(397, 12);
		((Control)obj93).Location = location;
		((Control)lblTk_TS).Name = "lblTk_TS";
		Label obj94 = lblTk_TS;
		size = new Size(89, 13);
		((Control)obj94).Size = size;
		((Control)lblTk_TS).TabIndex = 39;
		lblTk_TS.Text = "Tài khoản tài sản";
		((ButtonBase)chkTinh_kh).AutoSize = true;
		chkTinh_kh.Checked = true;
		((CheckBox)chkTinh_kh).CheckState = (CheckState)1;
		AsCheckBox asCheckBox = chkTinh_kh;
		location = new Point(94, 60);
		((Control)asCheckBox).Location = location;
		((Control)chkTinh_kh).Name = "chkTinh_kh";
		AsCheckBox asCheckBox2 = chkTinh_kh;
		size = new Size(67, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkTinh_kh).TabIndex = 2;
		((ButtonBase)chkTinh_kh).Text = "Tính KH";
		((ButtonBase)chkTinh_kh).UseVisualStyleBackColor = true;
		lblTy_Le_KH_THANG.AutoSize = true;
		Label obj95 = lblTy_Le_KH_THANG;
		location = new Point(10, 38);
		((Control)obj95).Location = location;
		((Control)lblTy_Le_KH_THANG).Name = "lblTy_Le_KH_THANG";
		Label obj96 = lblTy_Le_KH_THANG;
		size = new Size(78, 13);
		((Control)obj96).Size = size;
		((Control)lblTy_Le_KH_THANG).TabIndex = 36;
		lblTy_Le_KH_THANG.Text = "Tỷ lệ KH tháng";
		((TextBoxBase)txtTl_kh).BackColor = Color.White;
		txtTl_kh.DecimalSymbol = ".";
		txtTl_kh.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric45 = txtTl_kh;
		location = new Point(94, 34);
		((Control)asTextNumeric45).Location = location;
		txtTl_kh.Mask = "### ### ### ###.###";
		((Control)txtTl_kh).Name = "txtTl_kh";
		((TextBoxBase)txtTl_kh).ReadOnly = true;
		AsTextNumeric asTextNumeric46 = txtTl_kh;
		size = new Size(82, 20);
		((Control)asTextNumeric46).Size = size;
		txtTl_kh.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTl_kh).TabIndex = 1;
		((TextBox)txtTl_kh).Text = "0.000";
		((TextBox)txtTl_kh).TextAlign = (HorizontalAlignment)1;
		txtTl_kh.Value = 0;
		lblSo_thang_kh.AutoSize = true;
		Label obj97 = lblSo_thang_kh;
		location = new Point(10, 12);
		((Control)obj97).Location = location;
		((Control)lblSo_thang_kh).Name = "lblSo_thang_kh";
		Label obj98 = lblSo_thang_kh;
		size = new Size(68, 13);
		((Control)obj98).Size = size;
		((Control)lblSo_thang_kh).TabIndex = 34;
		lblSo_thang_kh.Text = "Số tháng KH";
		((TextBoxBase)txtSt_kh).BackColor = Color.White;
		txtSt_kh.DecimalSymbol = ".";
		txtSt_kh.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric47 = txtSt_kh;
		location = new Point(94, 9);
		((Control)asTextNumeric47).Location = location;
		txtSt_kh.Mask = "####";
		((Control)txtSt_kh).Name = "txtSt_kh";
		AsTextNumeric asTextNumeric48 = txtSt_kh;
		size = new Size(82, 20);
		((Control)asTextNumeric48).Size = size;
		txtSt_kh.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSt_kh).TabIndex = 0;
		((TextBox)txtSt_kh).Text = "0";
		((TextBox)txtSt_kh).TextAlign = (HorizontalAlignment)1;
		txtSt_kh.Value = 0;
		((ButtonBase)chkSua_kh).AutoSize = true;
		chkSua_kh.Checked = false;
		AsCheckBox asCheckBox3 = chkSua_kh;
		location = new Point(506, 86);
		((Control)asCheckBox3).Location = location;
		((Control)chkSua_kh).Name = "chkSua_kh";
		AsCheckBox asCheckBox4 = chkSua_kh;
		size = new Size(63, 17);
		((Control)asCheckBox4).Size = size;
		((Control)chkSua_kh).TabIndex = 6;
		((ButtonBase)chkSua_kh).Text = "Sửa KH";
		chkSua_kh.TextValue = "0";
		((ButtonBase)chkSua_kh).UseVisualStyleBackColor = true;
		tabPT_LK.BackColor = Color.White;
		((Control)tabPT_LK).Controls.Add((Control)(object)lblGT);
		((Control)tabPT_LK).Controls.Add((Control)(object)txtGia_tri);
		((Control)tabPT_LK).Controls.Add((Control)(object)lblSlg1);
		((Control)tabPT_LK).Controls.Add((Control)(object)txtSo_luonglk);
		((Control)tabPT_LK).Controls.Add((Control)(object)txtMa_Lk);
		((Control)tabPT_LK).Controls.Add((Control)(object)dgvLinh_kien);
		((Control)tabPT_LK).Controls.Add((Control)(object)cmdDel_lk);
		((Control)tabPT_LK).Controls.Add((Control)(object)cmdAdd_lk);
		((Control)tabPT_LK).Controls.Add((Control)(object)chkKSD_LK);
		((Control)tabPT_LK).Controls.Add((Control)(object)txtDvt_Lk);
		((Control)tabPT_LK).Controls.Add((Control)(object)lblDVT1);
		((Control)tabPT_LK).Controls.Add((Control)(object)txtTen_lk);
		((Control)tabPT_LK).Controls.Add((Control)(object)lblTen_lk);
		((Control)tabPT_LK).Controls.Add((Control)(object)lblMa_LK);
		TabPage obj99 = tabPT_LK;
		location = new Point(4, 25);
		obj99.Location = location;
		((Control)tabPT_LK).Name = "tabPT_LK";
		TabPage obj100 = tabPT_LK;
		size = new Size(615, 302);
		((Control)obj100).Size = size;
		tabPT_LK.TabIndex = 2;
		tabPT_LK.Text = "Phụ &tùng, linh kiện";
		lblGT.AutoSize = true;
		Label obj101 = lblGT;
		location = new Point(9, 116);
		((Control)obj101).Location = location;
		((Control)lblGT).Name = "lblGT";
		Label obj102 = lblGT;
		size = new Size(34, 13);
		((Control)obj102).Size = size;
		((Control)lblGT).TabIndex = 40;
		lblGT.Text = "Giá trị";
		((TextBoxBase)txtGia_tri).BackColor = Color.White;
		txtGia_tri.DecimalSymbol = ".";
		txtGia_tri.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric49 = txtGia_tri;
		location = new Point(85, 112);
		((Control)asTextNumeric49).Location = location;
		txtGia_tri.Mask = "### ### ### ###.##";
		((Control)txtGia_tri).Name = "txtGia_tri";
		AsTextNumeric asTextNumeric50 = txtGia_tri;
		size = new Size(142, 20);
		((Control)asTextNumeric50).Size = size;
		txtGia_tri.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGia_tri).TabIndex = 4;
		((TextBox)txtGia_tri).Text = "0.00";
		((TextBox)txtGia_tri).TextAlign = (HorizontalAlignment)1;
		txtGia_tri.Value = 0;
		lblSlg1.AutoSize = true;
		Label obj103 = lblSlg1;
		location = new Point(9, 90);
		((Control)obj103).Location = location;
		((Control)lblSlg1).Name = "lblSlg1";
		Label obj104 = lblSlg1;
		size = new Size(49, 13);
		((Control)obj104).Size = size;
		((Control)lblSlg1).TabIndex = 38;
		lblSlg1.Text = "Số lượng";
		((TextBoxBase)txtSo_luonglk).BackColor = Color.White;
		txtSo_luonglk.DecimalSymbol = ".";
		txtSo_luonglk.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric51 = txtSo_luonglk;
		location = new Point(85, 86);
		((Control)asTextNumeric51).Location = location;
		txtSo_luonglk.Mask = "### ### ### ###";
		((Control)txtSo_luonglk).Name = "txtSo_luonglk";
		AsTextNumeric asTextNumeric52 = txtSo_luonglk;
		size = new Size(75, 20);
		((Control)asTextNumeric52).Size = size;
		txtSo_luonglk.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSo_luonglk).TabIndex = 3;
		((TextBox)txtSo_luonglk).Text = "0";
		((TextBox)txtSo_luonglk).TextAlign = (HorizontalAlignment)1;
		txtSo_luonglk.Value = 0;
		((TextBoxBase)txtMa_Lk).BackColor = Color.White;
		txtMa_Lk.CharacterCasing = (CharacterCasing)1;
		TextBox obj105 = txtMa_Lk;
		location = new Point(85, 8);
		((Control)obj105).Location = location;
		((Control)txtMa_Lk).Name = "txtMa_Lk";
		TextBox obj106 = txtMa_Lk;
		size = new Size(75, 20);
		((Control)obj106).Size = size;
		((Control)txtMa_Lk).TabIndex = 0;
		((DataGridView)dgvLinh_kien).AllowUserToAddRows = false;
		((DataGridView)dgvLinh_kien).AllowUserToDeleteRows = false;
		((Control)dgvLinh_kien).Anchor = (AnchorStyles)14;
		((DataGridView)dgvLinh_kien).BackgroundColor = Color.White;
		((DataGridView)dgvLinh_kien).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvLinh_kien).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvLinh_kien).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)dgvLinh_kien).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvLinh_kien).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)Ma_cty,
			(DataGridViewColumn)ma_ts,
			(DataGridViewColumn)ma_lk,
			(DataGridViewColumn)ten_lk,
			(DataGridViewColumn)dvt,
			so_luong,
			Gia_tri,
			(DataGridViewColumn)KSD
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvLinh_kien).DefaultCellStyle = val2;
		((DataGridView)dgvLinh_kien).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvLinh_kien).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = dgvLinh_kien;
		location = new Point(3, 142);
		((Control)asInputDGV).Location = location;
		((Control)dgvLinh_kien).Name = "dgvLinh_kien";
		dgvLinh_kien.ReadOnly = true;
		((DataGridView)dgvLinh_kien).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvLinh_kien).RowHeadersDefaultCellStyle = val3;
		((DataGridView)dgvLinh_kien).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = dgvLinh_kien;
		size = new Size(608, 155);
		((Control)asInputDGV2).Size = size;
		((Control)dgvLinh_kien).TabIndex = 12;
		((DataGridViewColumn)Ma_cty).DataPropertyName = "ma_cty";
		((DataGridViewColumn)Ma_cty).HeaderText = "Mã CTy";
		((DataGridViewColumn)Ma_cty).Name = "Ma_cty";
		((DataGridViewColumn)Ma_cty).Visible = false;
		((DataGridViewColumn)ma_ts).DataPropertyName = "ma_ts";
		((DataGridViewColumn)ma_ts).HeaderText = "Mã Ts";
		((DataGridViewColumn)ma_ts).Name = "ma_ts";
		((DataGridViewColumn)ma_ts).Visible = false;
		((DataGridViewColumn)ma_lk).DataPropertyName = "ma_lk";
		((DataGridViewColumn)ma_lk).HeaderText = "Mã LK";
		((DataGridViewColumn)ma_lk).Name = "ma_lk";
		((DataGridViewColumn)ten_lk).DataPropertyName = "ten_lk";
		((DataGridViewColumn)ten_lk).HeaderText = "Tên LK";
		((DataGridViewColumn)ten_lk).Name = "ten_lk";
		((DataGridViewColumn)dvt).DataPropertyName = "dvt";
		((DataGridViewColumn)dvt).HeaderText = "ĐVT";
		((DataGridViewColumn)dvt).Name = "dvt";
		((DataGridViewColumn)so_luong).DataPropertyName = "so_luong";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "### ### ### ###.##";
		((DataGridViewColumn)so_luong).DefaultCellStyle = val4;
		((DataGridViewColumn)so_luong).HeaderText = "Số lượng";
		so_luong.Mask = "### ### ### ###.##";
		((DataGridViewColumn)so_luong).Name = "so_luong";
		((DataGridViewColumn)so_luong).Resizable = (DataGridViewTriState)1;
		so_luong.SortMode = (DataGridViewColumnSortMode)1;
		so_luong.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)Gia_tri).DataPropertyName = "Gia_tri";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "### ### ### ###.##";
		((DataGridViewColumn)Gia_tri).DefaultCellStyle = val5;
		((DataGridViewColumn)Gia_tri).HeaderText = "Giá trị";
		Gia_tri.Mask = "### ### ### ###.##";
		((DataGridViewColumn)Gia_tri).Name = "Gia_tri";
		((DataGridViewColumn)Gia_tri).Resizable = (DataGridViewTriState)1;
		Gia_tri.SortMode = (DataGridViewColumnSortMode)0;
		Gia_tri.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)KSD).HeaderText = "KSD";
		((DataGridViewColumn)KSD).Name = "KSD";
		((DataGridViewColumn)KSD).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)KSD).SortMode = (DataGridViewColumnSortMode)1;
		((Control)cmdDel_lk).Anchor = (AnchorStyles)10;
		Button obj107 = cmdDel_lk;
		location = new Point(515, 111);
		((Control)obj107).Location = location;
		((Control)cmdDel_lk).Name = "cmdDel_lk";
		Button obj108 = cmdDel_lk;
		size = new Size(75, 23);
		((Control)obj108).Size = size;
		((Control)cmdDel_lk).TabIndex = 10;
		((ButtonBase)cmdDel_lk).Text = "&Xóa";
		((ButtonBase)cmdDel_lk).UseVisualStyleBackColor = true;
		((Control)cmdAdd_lk).Anchor = (AnchorStyles)10;
		Button obj109 = cmdAdd_lk;
		location = new Point(515, 82);
		((Control)obj109).Location = location;
		((Control)cmdAdd_lk).Name = "cmdAdd_lk";
		Button obj110 = cmdAdd_lk;
		size = new Size(75, 23);
		((Control)obj110).Size = size;
		((Control)cmdAdd_lk).TabIndex = 6;
		((ButtonBase)cmdAdd_lk).Text = "&Thêm";
		((ButtonBase)cmdAdd_lk).UseVisualStyleBackColor = true;
		((Control)chkKSD_LK).Anchor = (AnchorStyles)10;
		((ButtonBase)chkKSD_LK).AutoSize = true;
		chkKSD_LK.Checked = false;
		AsCheckBox asCheckBox5 = chkKSD_LK;
		location = new Point(508, 63);
		((Control)asCheckBox5).Location = location;
		((Control)chkKSD_LK).Name = "chkKSD_LK";
		AsCheckBox asCheckBox6 = chkKSD_LK;
		size = new Size(98, 17);
		((Control)asCheckBox6).Size = size;
		((Control)chkKSD_LK).TabIndex = 5;
		((ButtonBase)chkKSD_LK).Text = "Không sử dụng";
		chkKSD_LK.TextValue = "0";
		((ButtonBase)chkKSD_LK).UseVisualStyleBackColor = true;
		((TextBoxBase)txtDvt_Lk).BackColor = Color.White;
		TextBox obj111 = txtDvt_Lk;
		location = new Point(85, 60);
		((Control)obj111).Location = location;
		((Control)txtDvt_Lk).Name = "txtDvt_Lk";
		TextBox obj112 = txtDvt_Lk;
		size = new Size(44, 20);
		((Control)obj112).Size = size;
		((Control)txtDvt_Lk).TabIndex = 2;
		lblDVT1.AutoSize = true;
		Label obj113 = lblDVT1;
		location = new Point(9, 64);
		((Control)obj113).Location = location;
		((Control)lblDVT1).Name = "lblDVT1";
		Label obj114 = lblDVT1;
		size = new Size(60, 13);
		((Control)obj114).Size = size;
		((Control)lblDVT1).TabIndex = 12;
		lblDVT1.Text = "Đơn vị tính";
		((TextBoxBase)txtTen_lk).BackColor = Color.White;
		TextBox obj115 = txtTen_lk;
		location = new Point(85, 34);
		((Control)obj115).Location = location;
		((Control)txtTen_lk).Name = "txtTen_lk";
		TextBox obj116 = txtTen_lk;
		size = new Size(320, 20);
		((Control)obj116).Size = size;
		((Control)txtTen_lk).TabIndex = 1;
		lblTen_lk.AutoSize = true;
		Label obj117 = lblTen_lk;
		location = new Point(9, 38);
		((Control)obj117).Location = location;
		((Control)lblTen_lk).Name = "lblTen_lk";
		Label obj118 = lblTen_lk;
		size = new Size(68, 13);
		((Control)obj118).Size = size;
		((Control)lblTen_lk).TabIndex = 10;
		lblTen_lk.Text = "Tên linh kiện";
		lblMa_LK.AutoSize = true;
		Label obj119 = lblMa_LK;
		location = new Point(9, 12);
		((Control)obj119).Location = location;
		((Control)lblMa_LK).Name = "lblMa_LK";
		Label obj120 = lblMa_LK;
		size = new Size(64, 13);
		((Control)obj120).Size = size;
		((Control)lblMa_LK).TabIndex = 7;
		lblMa_LK.Text = "Mã linh kiện";
		lblDVT.AutoSize = true;
		Label obj121 = lblDVT;
		location = new Point(16, 42);
		((Control)obj121).Location = location;
		((Control)lblDVT).Name = "lblDVT";
		Label obj122 = lblDVT;
		size = new Size(60, 13);
		((Control)obj122).Size = size;
		((Control)lblDVT).TabIndex = 20;
		lblDVT.Text = "Đơn vị tính";
		TextBox obj123 = txtDvt;
		location = new Point(82, 38);
		((Control)obj123).Location = location;
		((Control)txtDvt).Name = "txtDvt";
		TextBox obj124 = txtDvt;
		size = new Size(100, 20);
		((Control)obj124).Size = size;
		((Control)txtDvt).TabIndex = 2;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(626, 433);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)TabCtlTai_san);
		((Control)this).Controls.Add((Control)(object)lblDVT);
		((Control)this).Controls.Add((Control)(object)txtDvt);
		((Control)this).Controls.Add((Control)(object)lblMa_TS);
		((Control)this).Controls.Add((Control)(object)lblTen_TS);
		((Control)this).Controls.Add((Control)(object)txtMa_ts);
		((Control)this).Controls.Add((Control)(object)txtTen_ts);
		((Control)this).Name = "frmFADMTSEdit";
		((Control)this).Controls.SetChildIndex((Control)(object)txtTen_ts, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtMa_ts, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen_TS, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblMa_TS, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbLine, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSave, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtDvt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblDVT, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)TabCtlTai_san, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)TabCtlTai_san).ResumeLayout(false);
		((Control)tabTTC).ResumeLayout(false);
		((Control)tabTTC).PerformLayout();
		((Control)tabTTKH).ResumeLayout(false);
		((Control)tabTTKH).PerformLayout();
		((Control)grbChi_Tiet_NV).ResumeLayout(false);
		((Control)grbChi_Tiet_NV).PerformLayout();
		((Control)tabPT_LK).ResumeLayout(false);
		((Control)tabPT_LK).PerformLayout();
		((ISupportInitialize)dgvLinh_kien).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitAfterGetData()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		base.InitAfterGetData();
		foreach (TabPage tabPage in ((TabControl)TabCtlTai_san).TabPages)
		{
			TabPage val = tabPage;
			if (!((Control)val).Created)
			{
				((Control)val).CreateControl();
				((Control)val).Show();
				((Control)val).Hide();
			}
		}
		InitTabPTLK();
		if (!EditMode)
		{
			chkTinh_kh.Checked = true;
		}
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_ts).Enabled = false;
		((Control)txtTen_ts).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_ts;
		CreateDataBinding(ref ojb, "ma_ts");
		txtMa_ts = (TextBox)ojb;
		ojb = (Control)(object)txtTen_ts;
		CreateDataBinding(ref ojb, "ten_ts");
		txtTen_ts = (TextBox)ojb;
		ojb = (Control)(object)txtDvt;
		CreateDataBinding(ref ojb, "Dvt");
		txtDvt = (TextBox)ojb;
		ojb = (Control)(object)txtNha_cc;
		CreateDataBinding(ref ojb, "nha_cc");
		txtNha_cc = (TextBox)ojb;
		ojb = (Control)(object)txtNuoc_sx;
		CreateDataBinding(ref ojb, "nuoc_sx");
		txtNuoc_sx = (TextBox)ojb;
		ojb = (Control)(object)txtcong_suat;
		CreateDataBinding(ref ojb, "cong_suat");
		txtcong_suat = (TextBox)ojb;
		ojb = (Control)(object)txtNam_sx;
		CreateDataBinding(ref ojb, "nam_sx", "Value");
		txtNam_sx = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSo_luong;
		CreateDataBinding(ref ojb, "so_luong", "Value");
		txtSo_luong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtNgay_dvsd;
		CreateDataBinding(ref ojb, "ngay_dvsd", "Value");
		txtNgay_dvsd = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_tang;
		CreateDataBinding(ref ojb, "ngay_tang", "Value");
		txtNgay_tang = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtMA_LDTG;
		CreateDataBinding(ref ojb, "ma_tg_ts");
		txtMA_LDTG = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_bdkh;
		CreateDataBinding(ref ojb, "ngay_bdkh", "Value");
		txtNgay_bdkh = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_gt_cl;
		CreateDataBinding(ref ojb, "ngay_gt_cl", "Value");
		txtNgay_gt_cl = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_dc;
		CreateDataBinding(ref ojb, "ngay_dc", "Value");
		txtNgay_dc = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtLd_dc;
		CreateDataBinding(ref ojb, "ld_dc");
		txtLd_dc = (TextBox)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "So_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)txtNgay_ct;
		CreateDataBinding(ref ojb, "Ngay_ct", "Value");
		txtNgay_ct = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_nhts1;
		CreateDataBinding(ref ojb, "ma_nhts1");
		txtMa_nhts1 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_nhts2;
		CreateDataBinding(ref ojb, "ma_nhts2");
		txtMa_nhts2 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_nhts3;
		CreateDataBinding(ref ojb, "ma_nhts3");
		txtMa_nhts3 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_phi;
		CreateDataBinding(ref ojb, "ma_phi");
		txtMa_phi = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_spct;
		CreateDataBinding(ref ojb, "ma_spct");
		txtMa_spct = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_bpsd;
		CreateDataBinding(ref ojb, "Ma_bpsd");
		txtMa_bpsd = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtSt_kh;
		CreateDataBinding(ref ojb, "st_kh", "Value");
		txtSt_kh = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTl_kh;
		CreateDataBinding(ref ojb, "tl_kh", "Value");
		txtTl_kh = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)chkTinh_kh;
		CreateDataBinding(ref ojb, "tinh_kh", "Checked");
		chkTinh_kh = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)txtTk_ts;
		CreateDataBinding(ref ojb, "Tk_ts");
		txtTk_ts = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk_kh;
		CreateDataBinding(ref ojb, "Tk_kh");
		txtTk_kh = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk_cp;
		CreateDataBinding(ref ojb, "Tk_cp");
		txtTk_cp = (AsTextBox)(object)ojb;
		ojb = (Control)(object)chkSua_kh;
		CreateDataBinding(ref ojb, "sua_kh", "Checked");
		chkSua_kh = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)txtNg_gia_n1;
		CreateDataBinding(ref ojb, "Ng_gia_n1", "Value");
		txtNg_gia_n1 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtNg_gia_n2;
		CreateDataBinding(ref ojb, "Ng_gia_n2", "Value");
		txtNg_gia_n2 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtNg_gia_n3;
		CreateDataBinding(ref ojb, "Ng_gia_n3", "Value");
		txtNg_gia_n3 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtNg_gia_n4;
		CreateDataBinding(ref ojb, "Ng_gia_n4", "Value");
		txtNg_gia_n4 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtT_ng_gia;
		CreateDataBinding(ref ojb, "T_ng_gia", "Value");
		txtT_ng_gia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt_kh_n1;
		CreateDataBinding(ref ojb, "Gt_kh_n1", "Value");
		txtGt_kh_n1 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt_kh_n2;
		CreateDataBinding(ref ojb, "Gt_kh_n2", "Value");
		txtGt_kh_n2 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt_kh_n3;
		CreateDataBinding(ref ojb, "Gt_kh_n3", "Value");
		txtGt_kh_n3 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt_kh_n4;
		CreateDataBinding(ref ojb, "Gt_kh_n4", "Value");
		txtGt_kh_n4 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtT_gt_kh;
		CreateDataBinding(ref ojb, "T_gt_kh", "Value");
		txtT_gt_kh = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt_cl_n1;
		CreateDataBinding(ref ojb, "Gt_cl_n1", "Value");
		txtGt_cl_n1 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt_cl_n2;
		CreateDataBinding(ref ojb, "Gt_cl_n2", "Value");
		txtGt_cl_n2 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt_cl_n3;
		CreateDataBinding(ref ojb, "Gt_cl_n3", "Value");
		txtGt_cl_n3 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt_cl_n4;
		CreateDataBinding(ref ojb, "Gt_cl_n4", "Value");
		txtGt_cl_n4 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtT_gt_cl;
		CreateDataBinding(ref ojb, "T_gt_cl", "Value");
		txtT_gt_cl = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtkh_th_n1;
		CreateDataBinding(ref ojb, "kh_th_n1", "Value");
		txtkh_th_n1 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtkh_th_n2;
		CreateDataBinding(ref ojb, "kh_th_n2", "Value");
		txtkh_th_n2 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtkh_th_n3;
		CreateDataBinding(ref ojb, "kh_th_n3", "Value");
		txtkh_th_n3 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtkh_th_n4;
		CreateDataBinding(ref ojb, "kh_th_n4", "Value");
		txtkh_th_n4 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtT_kh_th;
		CreateDataBinding(ref ojb, "T_kh_th", "Value");
		txtT_kh_th = (AsTextNumeric)(object)ojb;
	}

	protected override bool ValidData()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		foreach (TabPage tabPage in ((TabControl)TabCtlTai_san).TabPages)
		{
			TabPage val = tabPage;
			if (!((Control)val).Created)
			{
				((Control)val).CreateControl();
				((Control)val).Show();
				((Control)val).Hide();
			}
		}
		if (!Chk_Double_Code_Val())
		{
			return false;
		}
		if (!ChkEmtyTextBox(txtTen_ts))
		{
			SetControlError((Control)(object)txtTen_ts, Helper.GetMessContent(50002));
			((TabControl)TabCtlTai_san).SelectedTab = tabTTC;
			((Control)txtTen_ts).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectLessEqual(txtNgay_tang.Value, (object)"#1/1/1900#", false) || (Operators.ConditionalCompareObjectGreater(txtNgay_tang.Value, (object)DateTime.MaxValue, false) ? true : false))
		{
			SetControlError((Control)(object)txtNgay_tang, Helper.GetMessContent(50002));
			((TabControl)TabCtlTai_san).SelectedTab = tabTTC;
			((Control)txtNgay_tang).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectEqual(txtNgay_bdkh.Value, (object)"#1/1/1900#", false) || (Operators.ConditionalCompareObjectGreater(txtNgay_bdkh.Value, (object)DateTime.MaxValue, false) ? true : false))
		{
			SetControlError((Control)(object)txtNgay_bdkh, Helper.GetMessContent(50002));
			((TabControl)TabCtlTai_san).SelectedTab = tabTTC;
			((Control)txtNgay_bdkh).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectEqual(txtNgay_gt_cl.Value, (object)"#1/1/1900#", false) || (Operators.ConditionalCompareObjectGreater(txtNgay_gt_cl.Value, (object)DateTime.MaxValue, false) ? true : false))
		{
			SetControlError((Control)(object)txtNgay_gt_cl, Helper.GetMessContent(50002));
			((TabControl)TabCtlTai_san).SelectedTab = tabTTC;
			((Control)txtNgay_gt_cl).Select();
			return false;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtMA_LDTG))
		{
			((TabControl)TabCtlTai_san).SelectedTab = tabTTC;
			((Control)txtMA_LDTG).Select();
			return false;
		}
		if ((Operators.ConditionalCompareObjectLess(txtNgay_gt_cl.Value, txtNgay_bdkh.Value, false) || Operators.ConditionalCompareObjectLess(txtNgay_bdkh.Value, txtNgay_tang.Value, false) || Operators.ConditionalCompareObjectLess(txtNgay_gt_cl.Value, txtNgay_tang.Value, false)) ? true : false)
		{
			CMessageBox.Show(50144);
			((TabControl)TabCtlTai_san).SelectedTab = tabTTC;
			return false;
		}
		if (Conversions.ToBoolean(Operators.NotObject(chkTinh_kh.Checked)))
		{
			return true;
		}
		if (Operators.ConditionalCompareObjectLessEqual(txtSt_kh.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtSt_kh, Helper.GetMessContent(50034));
			((TabControl)TabCtlTai_san).SelectedTab = tabTTKH;
			((Control)txtSt_kh).Select();
			return false;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtTk_ts))
		{
			((TabControl)TabCtlTai_san).SelectedTab = tabTTKH;
			((Control)txtTk_ts).Select();
			return false;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtTk_kh))
		{
			((TabControl)TabCtlTai_san).SelectedTab = tabTTKH;
			((Control)txtTk_kh).Select();
			return false;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtTk_cp))
		{
			((TabControl)TabCtlTai_san).SelectedTab = tabTTKH;
			((Control)txtTk_cp).Select();
			return false;
		}
		if (Conversions.ToBoolean((!Conversions.ToBoolean(chkTinh_kh.Checked) || !Conversions.ToBoolean((object)Operators.ConditionalCompareObjectLessEqual(txtNg_gia_n1.Value, (object)0, false)) || !Conversions.ToBoolean((object)Operators.ConditionalCompareObjectLessEqual(txtNg_gia_n2.Value, (object)0, false)) || !Conversions.ToBoolean((object)Operators.ConditionalCompareObjectLessEqual(txtNg_gia_n3.Value, (object)0, false)) || !Conversions.ToBoolean((object)Operators.ConditionalCompareObjectLessEqual(txtNg_gia_n4.Value, (object)0, false))) ? ((object)false) : ((object)true)))
		{
			CMessageBox.Show(50145);
			return false;
		}
		return base.ValidData();
	}

	protected override bool UpdateDB()
	{
		bool flag = true;
		LKController.MyDAO.RequireTrans = true;
		DataRow[] array = f_oTblLK.Select("", "", DataViewRowState.Deleted);
		int num = 0;
		checked
		{
			bool result;
			while (true)
			{
				if (num < array.Length)
				{
					DataRow oDr = array[num];
					if (!LKController.DeleteDeletedRow(oDr))
					{
						LKController.MyDAO.RollBackTrans();
						result = false;
						break;
					}
					num++;
					continue;
				}
				DataRow[] array2 = f_oTblLK.Select("", "", DataViewRowState.Added);
				int num2 = 0;
				while (true)
				{
					if (num2 < array2.Length)
					{
						DataRow oDr2 = array2[num2];
						if (!LKController.Insert(oDr2))
						{
							LKController.MyDAO.RollBackTrans();
							result = false;
							break;
						}
						num2++;
						continue;
					}
					if (!MyController.Update(RowToEdit))
					{
						LKController.MyDAO.RollBackTrans();
						result = false;
						break;
					}
					try
					{
						LKController.MyDAO.CommitTrans();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						result = false;
						ProjectData.ClearProjectError();
						break;
					}
					result = true;
					break;
				}
				break;
			}
			return result;
		}
	}

	protected override bool InsertToDB()
	{
		bool flag = true;
		LKController.MyDAO.RequireTrans = true;
		DataRow[] array = f_oTblLK.Select("", "", DataViewRowState.Added);
		int num = 0;
		bool result;
		while (true)
		{
			if (num < array.Length)
			{
				DataRow oDr = array[num];
				if (!LKController.Insert(oDr))
				{
					LKController.MyDAO.RollBackTrans();
					result = false;
					break;
				}
				num = checked(num + 1);
				continue;
			}
			if (!MyController.Insert(RowToEdit))
			{
				LKController.MyDAO.RollBackTrans();
				result = false;
				break;
			}
			try
			{
				LKController.MyDAO.CommitTrans();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = false;
				ProjectData.ClearProjectError();
				break;
			}
			result = true;
			break;
		}
		return result;
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		MaskTextBoxAll(((Control)grbChi_Tiet_NV).Controls);
		txtGia_tri.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		InittabTTKH();
	}

	private void MyInit()
	{
		InitTabPTLK();
		InittabTTKH();
	}

	private void MaskTextBoxAll(ControlCollection ctl)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (Control item in ctl)
		{
			Control val = item;
			if (val is AsTextNumeric)
			{
				AsTextNumeric asTextNumeric = (AsTextNumeric)(object)val;
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OP", false))
				{
					asTextNumeric.Mask = Conversions.ToString(AsiaErp.Framework.Environment.GetSIConfiguration().Price_decimal);
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FP", false))
				{
					asTextNumeric.Mask = Conversions.ToString(AsiaErp.Framework.Environment.GetSIConfiguration().FCPrice_decimal);
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"QT", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format;
				}
			}
		}
	}

	private void InittabTTKH()
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DataTable dataTable = Commons.FAGetTenNguonVon(CompanyInformations.CompanyID);
			if (dataTable.Rows.Count == 0)
			{
				CMessageBox.Show(50143);
			}
			lblNguon_von1.Text = dataTable.Rows[0][1].ToString();
			lblNguon_von2.Text = dataTable.Rows[1][1].ToString();
			lblNguon_von3.Text = dataTable.Rows[2][1].ToString();
			lblNguon_von4.Text = dataTable.Rows[3][1].ToString();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(99999);
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void InitTabPTLK()
	{
		f_oTblLK = LKController.GetData(CompanyInformations.CompanyID, RuntimeHelpers.GetObjectValue(RowToEdit["ma_ts"]));
		((DataGridView)dgvLinh_kien).DataSource = f_oTblLK.DefaultView;
	}

	private void txtNgay_dvsd_Validated(object sender, EventArgs e)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if ((((!Operators.ConditionalCompareObjectLessEqual(txtNgay_tang.Value, (object)"#1/1/1900#", false) || !Operators.ConditionalCompareObjectGreater(txtNgay_tang.Value, (object)DateTime.MaxValue, false)) && (!Operators.ConditionalCompareObjectLessEqual(txtNgay_dvsd.Value, (object)"#1/1/1900#", false) || !Operators.ConditionalCompareObjectGreater(txtNgay_dvsd.Value, (object)DateTime.MaxValue, false))) || 1 == 0) && Operators.ConditionalCompareObjectGreater(txtNgay_tang.Value, txtNgay_dvsd.Value, false))
		{
			CMessageBox.Show(50013);
		}
	}

	private void cmdAdd_lk_Click(object sender, EventArgs e)
	{
		if (ValidLinhKien())
		{
			DataRow dataRow = f_oTblLK.NewRow();
			if (EditMode)
			{
				dataRow["ma_ts"] = RuntimeHelpers.GetObjectValue(RowToEdit["ma_ts"]);
			}
			else
			{
				dataRow["ma_ts"] = txtMa_ts.Text.Trim();
			}
			dataRow["ma_cty"] = CompanyInformations.CompanyID;
			dataRow["ma_lk"] = txtMa_Lk.Text;
			dataRow["ten_lk"] = txtTen_lk.Text;
			dataRow["dvt"] = txtDvt_Lk.Text;
			dataRow["so_luong"] = RuntimeHelpers.GetObjectValue(txtSo_luonglk.Value);
			dataRow["gia_tri"] = RuntimeHelpers.GetObjectValue(txtGia_tri.Value);
			f_oTblLK.Rows.Add(dataRow);
			txtMa_Lk.Text = "";
			txtTen_lk.Text = "";
			txtDvt_Lk.Text = "";
			txtSo_luonglk.Value = 0;
			txtGia_tri.Value = 0;
		}
	}

	private void cmdDel_lk_Click(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		if ((((DataGridView)dgvLinh_kien).RowCount > 0 && ((DataGridView)dgvLinh_kien).CurrentRow != null && ((DataGridViewBand)((DataGridView)dgvLinh_kien).CurrentRow).Index >= 0 && (int)CMessageBox.Show(50003, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)256) == 6) ? true : false)
		{
			DataRowView dataRowView = f_oTblLK.DefaultView[((DataGridViewBand)((DataGridView)dgvLinh_kien).CurrentRow).Index];
			dataRowView.Delete();
		}
	}

	private void txtNg_gia_n4_Validated(object sender, EventArgs e)
	{
		if (Chk_Ng_gia_Vals())
		{
			Tong_Ng_gia();
			Tinh_gt_cl();
			if (Operators.ConditionalCompareObjectGreater(txtSt_kh.Value, (object)0, false))
			{
				Tinh_kh_thang();
			}
		}
	}

	private void txtGt_kh_n4_Validated(object sender, EventArgs e)
	{
		if (Chk_Gt_Kh_Vals())
		{
			Tong_kh_th();
			Tinh_gt_cl();
		}
	}

	private void txtSt_kh_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreater(txtSt_kh.Value, (object)0, false))
		{
			txtTl_kh.Value = Operators.DivideObject((object)1, txtSt_kh.Value);
			Tinh_kh_thang();
		}
	}

	private void chkSua_kh_CheckedChanged(object sender, EventArgs e)
	{
		Sua_Kh(Conversions.ToBoolean(chkSua_kh.Checked));
	}

	private void chkTinh_kh_CheckedChanged(object sender, EventArgs e)
	{
		Tinh_Kh(Conversions.ToBoolean(chkTinh_kh.Checked));
	}

	private void txtNumeric_Validated(object sender, EventArgs e)
	{
		txtT_kh_th.Value = Operators.AddObject(Operators.AddObject(Operators.AddObject(txtkh_th_n1.Value, txtkh_th_n2.Value), txtkh_th_n3.Value), txtkh_th_n4.Value);
	}

	private void Tong_Ng_gia()
	{
		txtT_ng_gia.Value = Operators.AddObject(Operators.AddObject(Operators.AddObject(txtNg_gia_n1.Value, txtNg_gia_n2.Value), txtNg_gia_n3.Value), txtNg_gia_n4.Value);
	}

	private void Tong_kh_th()
	{
		txtT_gt_kh.Value = Operators.AddObject(Operators.AddObject(Operators.AddObject(txtGt_kh_n1.Value, txtGt_kh_n2.Value), txtGt_kh_n3.Value), txtGt_kh_n4.Value);
	}

	private bool Chk_Ng_gia_Vals()
	{
		if (Operators.ConditionalCompareObjectLess(txtNg_gia_n1.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtNg_gia_n1, Helper.GetMessContent(50034));
			((Control)txtNg_gia_n1).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectLess(txtNg_gia_n2.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtNg_gia_n2, Helper.GetMessContent(50034));
			((Control)txtNg_gia_n2).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectLess(txtNg_gia_n3.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtNg_gia_n3, Helper.GetMessContent(50034));
			((Control)txtNg_gia_n3).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectLess(txtNg_gia_n4.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtNg_gia_n4, Helper.GetMessContent(50034));
			((Control)txtNg_gia_n4).Select();
			return false;
		}
		return true;
	}

	private bool Chk_Gt_Kh_Vals()
	{
		if (Operators.ConditionalCompareObjectLess(txtGt_kh_n1.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtGt_kh_n1, Helper.GetMessContent(50034));
			((Control)txtNg_gia_n1).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectLess(txtGt_kh_n2.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtGt_kh_n2, Helper.GetMessContent(50034));
			((Control)txtNg_gia_n2).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectLess(txtGt_kh_n3.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtGt_kh_n3, Helper.GetMessContent(50034));
			((Control)txtNg_gia_n3).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectLess(txtGt_kh_n4.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtGt_kh_n4, Helper.GetMessContent(50034));
			((Control)txtNg_gia_n4).Select();
			return false;
		}
		return true;
	}

	private void Tinh_gt_cl()
	{
		txtGt_cl_n1.Value = Operators.SubtractObject(txtNg_gia_n1.Value, txtGt_kh_n1.Value);
		txtGt_cl_n2.Value = Operators.SubtractObject(txtNg_gia_n2.Value, txtGt_kh_n2.Value);
		txtGt_cl_n3.Value = Operators.SubtractObject(txtNg_gia_n3.Value, txtGt_kh_n3.Value);
		txtGt_cl_n4.Value = Operators.SubtractObject(txtNg_gia_n4.Value, txtGt_kh_n4.Value);
		txtT_gt_cl.Value = Operators.SubtractObject(txtT_ng_gia.Value, txtT_gt_kh.Value);
	}

	private void Tinh_kh_thang()
	{
		txtkh_th_n1.Value = Operators.DivideObject(txtNg_gia_n1.Value, txtSt_kh.Value);
		txtkh_th_n2.Value = Operators.DivideObject(txtNg_gia_n2.Value, txtSt_kh.Value);
		txtkh_th_n3.Value = Operators.DivideObject(txtNg_gia_n3.Value, txtSt_kh.Value);
		txtkh_th_n4.Value = Operators.DivideObject(txtNg_gia_n4.Value, txtSt_kh.Value);
		txtT_kh_th.Value = Operators.AddObject(Operators.AddObject(Operators.AddObject(txtkh_th_n1.Value, txtkh_th_n2.Value), txtkh_th_n3.Value), txtkh_th_n4.Value);
	}

	private bool ValidLinhKien()
	{
		if (Operators.CompareString(txtMa_Lk.Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtMa_Lk, Helper.GetMessContent(50002));
			((TabControl)TabCtlTai_san).SelectedTab = tabPT_LK;
			((Control)txtMa_Lk).Focus();
			return false;
		}
		if (Operators.CompareString(txtTen_lk.Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtTen_lk, Helper.GetMessContent(50002));
			((TabControl)TabCtlTai_san).SelectedTab = tabPT_LK;
			((Control)txtTen_lk).Focus();
			return false;
		}
		if (Operators.CompareString(txtMa_Lk.Text, txtMa_ts.Text, false) == 0)
		{
			SetControlError((Control)(object)txtMa_Lk, Helper.GetMessContent(50123));
			((TabControl)TabCtlTai_san).SelectedTab = tabPT_LK;
			((Control)txtMa_Lk).Focus();
			return false;
		}
		if (Operators.ConditionalCompareObjectGreater(f_oTblLK.Compute("count(ma_lk)", "ma_lk='" + txtMa_Lk.Text.Trim() + "'"), (object)0, false))
		{
			SetControlError((Control)(object)txtMa_Lk, Helper.GetMessContent(50011));
			((TabControl)TabCtlTai_san).SelectedTab = tabPT_LK;
			((Control)txtMa_Lk).Focus();
			return false;
		}
		return true;
	}

	private void Tinh_Kh(bool p)
	{
		((TextBoxBase)txtSt_kh).ReadOnly = !p;
		((TextBoxBase)txtTk_cp).ReadOnly = !p;
		((TextBoxBase)txtTk_kh).ReadOnly = !p;
		((TextBoxBase)txtTk_ts).ReadOnly = !p;
		((Control)chkSua_kh).Enabled = p;
		((Control)grbChi_Tiet_NV).Enabled = p;
		if (!p)
		{
		}
	}

	private void Sua_Kh(bool p)
	{
		if (p)
		{
			((Control)txtkh_th_n1).Enabled = true;
			((Control)txtkh_th_n2).Enabled = true;
			((Control)txtkh_th_n3).Enabled = true;
			((Control)txtkh_th_n4).Enabled = true;
		}
		else
		{
			((Control)txtkh_th_n1).Enabled = false;
			((Control)txtkh_th_n2).Enabled = false;
			((Control)txtkh_th_n3).Enabled = false;
			((Control)txtkh_th_n4).Enabled = false;
		}
	}

	private bool Chk_Double_Code_Val()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (f_oTblLK.Select("", "", DataViewRowState.Added).Any([SpecialName] (DataRow oDr) => Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDr["ma_lk"]), isNum: false), (object)txtMa_ts.Text.Trim(), false)))
		{
			CMessageBox.Show(50123);
			return false;
		}
		return true;
	}
}
