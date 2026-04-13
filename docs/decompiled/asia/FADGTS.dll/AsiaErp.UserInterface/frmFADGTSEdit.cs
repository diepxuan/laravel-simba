using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using My;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmFADGTSEdit : frmDMComplexEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblMa_ts")]
	private Label _lblMa_ts;

	[AccessedThroughProperty("txtdien_giai")]
	private TextBox _txtdien_giai;

	[AccessedThroughProperty("lblDien_giai")]
	private Label _lblDien_giai;

	[AccessedThroughProperty("TabCtlTai_san")]
	private AsTabControl _TabCtlTai_san;

	[AccessedThroughProperty("tabTTDG")]
	private TabPage _tabTTDG;

	[AccessedThroughProperty("tabTTKH")]
	private TabPage _tabTTKH;

	[AccessedThroughProperty("tabPT_LK")]
	private TabPage _tabPT_LK;

	[AccessedThroughProperty("txtTen_lk")]
	private TextBox _txtTen_lk;

	[AccessedThroughProperty("lblTen_lk")]
	private Label _lblTen_lk;

	[AccessedThroughProperty("lblMa_lk")]
	private Label _lblMa_lk;

	[AccessedThroughProperty("txtDvt_Lk")]
	private TextBox _txtDvt_Lk;

	[AccessedThroughProperty("lblDVT")]
	private Label _lblDVT;

	[AccessedThroughProperty("cmdAdd_lk")]
	private Button _cmdAdd_lk;

	[AccessedThroughProperty("dgvLinh_kien")]
	private AsInputDGV _dgvLinh_kien;

	[AccessedThroughProperty("cmdDel_lk")]
	private Button _cmdDel_lk;

	[AccessedThroughProperty("lblKieu_DG")]
	private Label _lblKieu_DG;

	[AccessedThroughProperty("lblNgay_GTCL")]
	private Label _lblNgay_GTCL;

	[AccessedThroughProperty("txtNgay_gt_cl")]
	private AsMaskedTextBox _txtNgay_gt_cl;

	[AccessedThroughProperty("lblNgay_BD_KH")]
	private Label _lblNgay_BD_KH;

	[AccessedThroughProperty("txtNgay_bdkh")]
	private AsMaskedTextBox _txtNgay_bdkh;

	[AccessedThroughProperty("lblLy_do_TG")]
	private Label _lblLy_do_TG;

	[AccessedThroughProperty("txtMA_LDTG")]
	private AsTextBox _txtMA_LDTG;

	[AccessedThroughProperty("lblNgay_ct")]
	private Label _lblNgay_ct;

	[AccessedThroughProperty("txtNgay_ct")]
	private AsMaskedTextBox _txtNgay_ct;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("lblSo_ct")]
	private Label _lblSo_ct;

	[AccessedThroughProperty("lblTK_KH")]
	private Label _lblTK_KH;

	[AccessedThroughProperty("lblTK_TS")]
	private Label _lblTK_TS;

	[AccessedThroughProperty("grbChi_Tiet_NV1")]
	private GroupBox _grbChi_Tiet_NV1;

	[AccessedThroughProperty("lblTK_CP")]
	private Label _lblTK_CP;

	[AccessedThroughProperty("lblNguyen_gia1")]
	private Label _lblNguyen_gia1;

	[AccessedThroughProperty("txtNg_gia_n41")]
	private AsTextNumeric _txtNg_gia_n41;

	[AccessedThroughProperty("txtNg_gia_n31")]
	private AsTextNumeric _txtNg_gia_n31;

	[AccessedThroughProperty("txtNg_gia_n21")]
	private AsTextNumeric _txtNg_gia_n21;

	[AccessedThroughProperty("txtNg_gia_n11")]
	private AsTextNumeric _txtNg_gia_n11;

	[AccessedThroughProperty("lblNguon_von4")]
	private Label _lblNguon_von4;

	[AccessedThroughProperty("lblNguon_von3")]
	private Label _lblNguon_von3;

	[AccessedThroughProperty("lblNguon_von2")]
	private Label _lblNguon_von2;

	[AccessedThroughProperty("lblNguon_von1")]
	private Label _lblNguon_von1;

	[AccessedThroughProperty("lblTong_cong1")]
	private Label _lblTong_cong1;

	[AccessedThroughProperty("txtT_kh_th1")]
	private AsTextNumeric _txtT_kh_th1;

	[AccessedThroughProperty("txtT_gt_cl")]
	private AsTextNumeric _txtT_gt_cl;

	[AccessedThroughProperty("txtT_gt_kh")]
	private AsTextNumeric _txtT_gt_kh;

	[AccessedThroughProperty("txtT_ng_gia1")]
	private AsTextNumeric _txtT_ng_gia1;

	[AccessedThroughProperty("lblGT_KH_1Thang")]
	private Label _lblGT_KH_1Thang;

	[AccessedThroughProperty("txtkh_th_n41")]
	private AsTextNumeric _txtkh_th_n41;

	[AccessedThroughProperty("txtkh_th_n31")]
	private AsTextNumeric _txtkh_th_n31;

	[AccessedThroughProperty("txtkh_th_n21")]
	private AsTextNumeric _txtkh_th_n21;

	[AccessedThroughProperty("txtkh_th_n11")]
	private AsTextNumeric _txtkh_th_n11;

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

	[AccessedThroughProperty("lblSlg")]
	private Label _lblSlg;

	[AccessedThroughProperty("txtSo_luonglk")]
	private AsTextNumeric _txtSo_luonglk;

	[AccessedThroughProperty("lblMa_dg")]
	private Label _lblMa_dg;

	[AccessedThroughProperty("txtma_ts_tgng")]
	private TextBox _txtma_ts_tgng;

	[AccessedThroughProperty("chkTang_giam")]
	private AsCheckBox _chkTang_giam;

	[AccessedThroughProperty("lblTy_Le_KH_Thang")]
	private Label _lblTy_Le_KH_Thang;

	[AccessedThroughProperty("txtTl_kh")]
	private AsTextNumeric _txtTl_kh;

	[AccessedThroughProperty("lblSo_thang_KH")]
	private Label _lblSo_thang_KH;

	[AccessedThroughProperty("txtSt_kh")]
	private AsTextNumeric _txtSt_kh;

	[AccessedThroughProperty("lblNgay_TG")]
	private Label _lblNgay_TG;

	[AccessedThroughProperty("txtngay_tg")]
	private AsMaskedTextBox _txtngay_tg;

	[AccessedThroughProperty("grbChi_Tiet_NV")]
	private GroupBox _grbChi_Tiet_NV;

	[AccessedThroughProperty("lblTong_Cong")]
	private Label _lblTong_Cong;

	[AccessedThroughProperty("txtT_kh_th")]
	private AsTextNumeric _txtT_kh_th;

	[AccessedThroughProperty("txtT_ng_gia")]
	private AsTextNumeric _txtT_ng_gia;

	[AccessedThroughProperty("lblGT_KH_TD1Thang")]
	private Label _lblGT_KH_TD1Thang;

	[AccessedThroughProperty("txtkh_th_n4")]
	private AsTextNumeric _txtkh_th_n4;

	[AccessedThroughProperty("txtkh_th_n3")]
	private AsTextNumeric _txtkh_th_n3;

	[AccessedThroughProperty("txtkh_th_n2")]
	private AsTextNumeric _txtkh_th_n2;

	[AccessedThroughProperty("txtkh_th_n1")]
	private AsTextNumeric _txtkh_th_n1;

	[AccessedThroughProperty("lblNguyen_Gia")]
	private Label _lblNguyen_Gia;

	[AccessedThroughProperty("txtNg_gia_n4")]
	private AsTextNumeric _txtNg_gia_n4;

	[AccessedThroughProperty("txtNg_gia_n3")]
	private AsTextNumeric _txtNg_gia_n3;

	[AccessedThroughProperty("txtNg_gia_n2")]
	private AsTextNumeric _txtNg_gia_n2;

	[AccessedThroughProperty("txtNg_gia_n1")]
	private AsTextNumeric _txtNg_gia_n1;

	[AccessedThroughProperty("lblng_von4")]
	private Label _lblng_von4;

	[AccessedThroughProperty("lblng_von3")]
	private Label _lblng_von3;

	[AccessedThroughProperty("lblng_von2")]
	private Label _lblng_von2;

	[AccessedThroughProperty("lblng_von1")]
	private Label _lblng_von1;

	[AccessedThroughProperty("chkSua_kh")]
	private AsCheckBox _chkSua_kh;

	[AccessedThroughProperty("chkTG")]
	private AsCheckBox _chkTG;

	[AccessedThroughProperty("lblNgay_GTCL1")]
	private Label _lblNgay_GTCL1;

	[AccessedThroughProperty("txtngay_gt_con_lai")]
	private AsMaskedTextBox _txtngay_gt_con_lai;

	[AccessedThroughProperty("chkTinh_kh")]
	private AsCheckBox _chkTinh_kh;

	[AccessedThroughProperty("lblTy_le_KH_Thang1")]
	private Label _lblTy_le_KH_Thang1;

	[AccessedThroughProperty("txtty_le_kh")]
	private AsTextNumeric _txtty_le_kh;

	[AccessedThroughProperty("lblSo_Thang_KH1")]
	private Label _lblSo_Thang_KH1;

	[AccessedThroughProperty("txtso_thang_kh")]
	private AsTextNumeric _txtso_thang_kh;

	[AccessedThroughProperty("chkEdit_kh")]
	private AsCheckBox _chkEdit_kh;

	[AccessedThroughProperty("lblSlg1")]
	private Label _lblSlg1;

	[AccessedThroughProperty("txtSo_luong_kh")]
	private AsTextNumeric _txtSo_luong_kh;

	[AccessedThroughProperty("lblNgay_tang")]
	private Label _lblNgay_tang;

	[AccessedThroughProperty("txtNgay_tang")]
	private AsMaskedTextBox _txtNgay_tang;

	[AccessedThroughProperty("txtMa_ts")]
	private AsTextBox _txtMa_ts;

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

	[AccessedThroughProperty("Tang_giam")]
	private DataGridViewCheckBoxColumn _Tang_giam;

	[AccessedThroughProperty("lblTen_TS")]
	private Label _lblTen_TS;

	[AccessedThroughProperty("txtTk_cp")]
	private TextBox _txtTk_cp;

	[AccessedThroughProperty("txtTk_kh")]
	private TextBox _txtTk_kh;

	[AccessedThroughProperty("txtTk_ts")]
	private TextBox _txtTk_ts;

	[AccessedThroughProperty("lblTen_LDTG")]
	private Label _lblTen_LDTG;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("rbbGiam")]
	private RadioButton _rbbGiam;

	[AccessedThroughProperty("rbbTang")]
	private RadioButton _rbbTang;

	[AccessedThroughProperty("txtSo_luong")]
	private AsTextNumeric _txtSo_luong;

	[AccessedThroughProperty("lblSlg_TG")]
	private Label _lblSlg_TG;

	private DataTable f_oTblLK;

	internal virtual Label lblMa_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_ts = value;
		}
	}

	internal virtual TextBox txtdien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtdien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtdien_giai = value;
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

	internal virtual TabPage tabTTDG
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabTTDG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabTTDG = value;
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

	internal virtual Label lblMa_lk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_lk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_lk = value;
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

	internal virtual Label lblKieu_DG
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblKieu_DG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblKieu_DG = value;
		}
	}

	internal virtual Label lblNgay_GTCL
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_GTCL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_GTCL = value;
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

	internal virtual Label lblNgay_BD_KH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_BD_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_BD_KH = value;
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

	internal virtual Label lblLy_do_TG
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLy_do_TG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLy_do_TG = value;
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
			AsTextBox.AfterCodeValidatingHandler obj = txtMA_LDTG_AfterCodeValidating;
			if (_txtMA_LDTG != null)
			{
				_txtMA_LDTG.AfterCodeValidating -= obj;
			}
			_txtMA_LDTG = value;
			if (_txtMA_LDTG != null)
			{
				_txtMA_LDTG.AfterCodeValidating += obj;
			}
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

	internal virtual Label lblSo_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_ct = value;
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

	internal virtual Label lblTK_TS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_TS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_TS = value;
		}
	}

	internal virtual GroupBox grbChi_Tiet_NV1
	{
		[DebuggerNonUserCode]
		get
		{
			return _grbChi_Tiet_NV1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grbChi_Tiet_NV1 = value;
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

	internal virtual Label lblNguyen_gia1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguyen_gia1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguyen_gia1 = value;
		}
	}

	internal virtual AsTextNumeric txtNg_gia_n41
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNg_gia_n41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNg_gia_n4_Validated;
			if (_txtNg_gia_n41 != null)
			{
				((Control)_txtNg_gia_n41).Validated -= eventHandler;
			}
			_txtNg_gia_n41 = value;
			if (_txtNg_gia_n41 != null)
			{
				((Control)_txtNg_gia_n41).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtNg_gia_n31
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNg_gia_n31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNg_gia_n4_Validated;
			if (_txtNg_gia_n31 != null)
			{
				((Control)_txtNg_gia_n31).Validated -= eventHandler;
			}
			_txtNg_gia_n31 = value;
			if (_txtNg_gia_n31 != null)
			{
				((Control)_txtNg_gia_n31).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtNg_gia_n21
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNg_gia_n21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNg_gia_n4_Validated;
			if (_txtNg_gia_n21 != null)
			{
				((Control)_txtNg_gia_n21).Validated -= eventHandler;
			}
			_txtNg_gia_n21 = value;
			if (_txtNg_gia_n21 != null)
			{
				((Control)_txtNg_gia_n21).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtNg_gia_n11
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNg_gia_n11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNg_gia_n4_Validated;
			if (_txtNg_gia_n11 != null)
			{
				((Control)_txtNg_gia_n11).Validated -= eventHandler;
			}
			_txtNg_gia_n11 = value;
			if (_txtNg_gia_n11 != null)
			{
				((Control)_txtNg_gia_n11).Validated += eventHandler;
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

	internal virtual Label lblTong_cong1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTong_cong1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTong_cong1 = value;
		}
	}

	internal virtual AsTextNumeric txtT_kh_th1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_kh_th1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_kh_th1 = value;
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

	internal virtual AsTextNumeric txtT_ng_gia1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_ng_gia1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_ng_gia1 = value;
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

	internal virtual AsTextNumeric txtkh_th_n41
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtkh_th_n41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtkh_th_n41 = value;
		}
	}

	internal virtual AsTextNumeric txtkh_th_n31
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtkh_th_n31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtkh_th_n31 = value;
		}
	}

	internal virtual AsTextNumeric txtkh_th_n21
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtkh_th_n21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtkh_th_n21 = value;
		}
	}

	internal virtual AsTextNumeric txtkh_th_n11
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtkh_th_n11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtkh_th_n11 = value;
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
			_txtGt_kh_n4 = value;
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
			_txtGt_kh_n3 = value;
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
			_txtGt_kh_n2 = value;
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
			_txtGt_kh_n1 = value;
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

	internal virtual Label lblMa_dg
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_dg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_dg = value;
		}
	}

	internal virtual TextBox txtma_ts_tgng
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtma_ts_tgng;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtma_ts_tgng = value;
		}
	}

	internal virtual AsCheckBox chkTang_giam
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkTang_giam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkTang_giam = value;
		}
	}

	internal virtual Label lblTy_Le_KH_Thang
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTy_Le_KH_Thang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTy_Le_KH_Thang = value;
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

	internal virtual Label lblSo_thang_KH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_thang_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_thang_KH = value;
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

	internal virtual Label lblNgay_TG
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_TG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_TG = value;
		}
	}

	internal virtual AsMaskedTextBox txtngay_tg
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtngay_tg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtngay_tg = value;
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

	internal virtual Label lblTong_Cong
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTong_Cong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTong_Cong = value;
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

	internal virtual Label lblGT_KH_TD1Thang
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGT_KH_TD1Thang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGT_KH_TD1Thang = value;
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
			_txtkh_th_n4 = value;
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
			_txtkh_th_n3 = value;
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
			_txtkh_th_n2 = value;
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
			_txtkh_th_n1 = value;
		}
	}

	internal virtual Label lblNguyen_Gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguyen_Gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguyen_Gia = value;
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

	internal virtual Label lblng_von4
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblng_von4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblng_von4 = value;
		}
	}

	internal virtual Label lblng_von3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblng_von3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblng_von3 = value;
		}
	}

	internal virtual Label lblng_von2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblng_von2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblng_von2 = value;
		}
	}

	internal virtual Label lblng_von1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblng_von1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblng_von1 = value;
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

	internal virtual AsCheckBox chkTG
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkTG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkTG = value;
		}
	}

	internal virtual Label lblNgay_GTCL1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_GTCL1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_GTCL1 = value;
		}
	}

	internal virtual AsMaskedTextBox txtngay_gt_con_lai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtngay_gt_con_lai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtngay_gt_con_lai = value;
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
			_chkTinh_kh = value;
		}
	}

	internal virtual Label lblTy_le_KH_Thang1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTy_le_KH_Thang1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTy_le_KH_Thang1 = value;
		}
	}

	internal virtual AsTextNumeric txtty_le_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtty_le_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtty_le_kh = value;
		}
	}

	internal virtual Label lblSo_Thang_KH1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_Thang_KH1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_Thang_KH1 = value;
		}
	}

	internal virtual AsTextNumeric txtso_thang_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtso_thang_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtso_thang_kh = value;
		}
	}

	internal virtual AsCheckBox chkEdit_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkEdit_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkEdit_kh = value;
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

	internal virtual AsTextNumeric txtSo_luong_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_luong_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_luong_kh = value;
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
			_txtNgay_tang = value;
		}
	}

	internal virtual AsTextBox txtMa_ts
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
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_ts_AfterCodeValidating;
			if (_txtMa_ts != null)
			{
				_txtMa_ts.AfterCodeValidating -= obj;
			}
			_txtMa_ts = value;
			if (_txtMa_ts != null)
			{
				_txtMa_ts.AfterCodeValidating += obj;
			}
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

	internal virtual DataGridViewCheckBoxColumn Tang_giam
	{
		[DebuggerNonUserCode]
		get
		{
			return _Tang_giam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Tang_giam = value;
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

	internal virtual TextBox txtTk_cp
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

	internal virtual TextBox txtTk_kh
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

	internal virtual TextBox txtTk_ts
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

	internal virtual Label lblTen_LDTG
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_LDTG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_LDTG = value;
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual RadioButton rbbGiam
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbbGiam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rbbGiam = value;
		}
	}

	internal virtual RadioButton rbbTang
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbbTang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbbTang_CheckedChanged;
			if (_rbbTang != null)
			{
				_rbbTang.CheckedChanged -= eventHandler;
			}
			_rbbTang = value;
			if (_rbbTang != null)
			{
				_rbbTang.CheckedChanged += eventHandler;
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

	internal virtual Label lblSlg_TG
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSlg_TG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSlg_TG = value;
		}
	}

	private DictionaryController LKController => ControllerFactory.GetDictionaryControllerByCodeName("MA_LK");

	[DebuggerNonUserCode]
	public frmFADGTSEdit()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
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
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
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
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
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
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected O, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected O, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected O, but got Unknown
		//IL_0b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3c: Expected O, but got Unknown
		//IL_0ed9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee3: Expected O, but got Unknown
		//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff9: Expected O, but got Unknown
		//IL_2bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc2: Expected O, but got Unknown
		//IL_2c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca9: Expected O, but got Unknown
		//IL_2d61: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d6b: Expected O, but got Unknown
		//IL_3637: Unknown result type (might be due to invalid IL or missing references)
		//IL_42fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4307: Expected O, but got Unknown
		//IL_43a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_43ae: Expected O, but got Unknown
		//IL_44b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_44c1: Expected O, but got Unknown
		//IL_45ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_45d4: Expected O, but got Unknown
		//IL_46dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_46e7: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmFADGTSEdit));
		lblMa_ts = new Label();
		txtdien_giai = new TextBox();
		lblDien_giai = new Label();
		TabCtlTai_san = new AsTabControl();
		tabTTDG = new TabPage();
		lblTen_LDTG = new Label();
		grbChi_Tiet_NV = new GroupBox();
		lblTong_Cong = new Label();
		txtT_kh_th = new AsTextNumeric();
		txtT_ng_gia = new AsTextNumeric();
		lblGT_KH_TD1Thang = new Label();
		txtkh_th_n4 = new AsTextNumeric();
		txtkh_th_n3 = new AsTextNumeric();
		txtkh_th_n2 = new AsTextNumeric();
		txtkh_th_n1 = new AsTextNumeric();
		lblNguyen_Gia = new Label();
		txtNg_gia_n4 = new AsTextNumeric();
		txtNg_gia_n3 = new AsTextNumeric();
		txtNg_gia_n2 = new AsTextNumeric();
		txtNg_gia_n1 = new AsTextNumeric();
		lblng_von4 = new Label();
		lblng_von3 = new Label();
		lblng_von2 = new Label();
		lblng_von1 = new Label();
		chkSua_kh = new AsCheckBox();
		lblTy_Le_KH_Thang = new Label();
		txtTl_kh = new AsTextNumeric();
		lblSo_thang_KH = new Label();
		txtSt_kh = new AsTextNumeric();
		lblNgay_TG = new Label();
		txtngay_tg = new AsMaskedTextBox();
		lblNgay_ct = new Label();
		txtNgay_ct = new AsMaskedTextBox();
		txtSo_ct = new TextBox();
		lblSo_ct = new Label();
		lblLy_do_TG = new Label();
		txtMA_LDTG = new AsTextBox();
		lblNgay_GTCL = new Label();
		txtNgay_gt_cl = new AsMaskedTextBox();
		lblNgay_BD_KH = new Label();
		txtNgay_bdkh = new AsMaskedTextBox();
		txtSo_luong = new AsTextNumeric();
		lblSlg_TG = new Label();
		tabPT_LK = new TabPage();
		lblGT = new Label();
		txtGia_tri = new AsTextNumeric();
		lblSlg = new Label();
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
		Tang_giam = new DataGridViewCheckBoxColumn();
		cmdDel_lk = new Button();
		cmdAdd_lk = new Button();
		chkTG = new AsCheckBox();
		txtDvt_Lk = new TextBox();
		lblDVT = new Label();
		txtTen_lk = new TextBox();
		lblTen_lk = new Label();
		lblMa_lk = new Label();
		tabTTKH = new TabPage();
		txtTk_cp = new TextBox();
		txtTk_kh = new TextBox();
		txtTk_ts = new TextBox();
		chkEdit_kh = new AsCheckBox();
		lblSlg1 = new Label();
		txtSo_luong_kh = new AsTextNumeric();
		lblNgay_tang = new Label();
		txtNgay_tang = new AsMaskedTextBox();
		lblNgay_GTCL1 = new Label();
		txtngay_gt_con_lai = new AsMaskedTextBox();
		chkTinh_kh = new AsCheckBox();
		lblTy_le_KH_Thang1 = new Label();
		txtty_le_kh = new AsTextNumeric();
		lblSo_Thang_KH1 = new Label();
		txtso_thang_kh = new AsTextNumeric();
		grbChi_Tiet_NV1 = new GroupBox();
		lblTong_cong1 = new Label();
		txtT_kh_th1 = new AsTextNumeric();
		txtT_gt_cl = new AsTextNumeric();
		txtT_gt_kh = new AsTextNumeric();
		txtT_ng_gia1 = new AsTextNumeric();
		lblGT_KH_1Thang = new Label();
		txtkh_th_n41 = new AsTextNumeric();
		txtkh_th_n31 = new AsTextNumeric();
		txtkh_th_n21 = new AsTextNumeric();
		txtkh_th_n11 = new AsTextNumeric();
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
		lblNguyen_gia1 = new Label();
		txtNg_gia_n41 = new AsTextNumeric();
		txtNg_gia_n31 = new AsTextNumeric();
		txtNg_gia_n21 = new AsTextNumeric();
		txtNg_gia_n11 = new AsTextNumeric();
		lblNguon_von4 = new Label();
		lblNguon_von3 = new Label();
		lblNguon_von2 = new Label();
		lblNguon_von1 = new Label();
		lblTK_CP = new Label();
		lblTK_KH = new Label();
		lblTK_TS = new Label();
		lblKieu_DG = new Label();
		lblMa_dg = new Label();
		txtma_ts_tgng = new TextBox();
		chkTang_giam = new AsCheckBox();
		txtMa_ts = new AsTextBox();
		lblTen_TS = new Label();
		Panel1 = new Panel();
		rbbGiam = new RadioButton();
		rbbTang = new RadioButton();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)TabCtlTai_san).SuspendLayout();
		((Control)tabTTDG).SuspendLayout();
		((Control)grbChi_Tiet_NV).SuspendLayout();
		((Control)tabPT_LK).SuspendLayout();
		((ISupportInitialize)dgvLinh_kien).BeginInit();
		((Control)tabTTKH).SuspendLayout();
		((Control)grbChi_Tiet_NV1).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		Point location = new Point(93, 431);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 6;
		Button obj2 = cmdSave;
		location = new Point(12, 431);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 5;
		((Control)gbLine).Anchor = (AnchorStyles)14;
		GroupBox obj3 = gbLine;
		location = new Point(-2, 422);
		((Control)obj3).Location = location;
		GroupBox obj4 = gbLine;
		Size size = new Size(629, 2);
		((Control)obj4).Size = size;
		((Control)gbLine).Visible = false;
		lblMa_ts.AutoSize = true;
		Label obj5 = lblMa_ts;
		location = new Point(15, 16);
		((Control)obj5).Location = location;
		((Control)lblMa_ts).Name = "lblMa_ts";
		Label obj6 = lblMa_ts;
		size = new Size(56, 13);
		((Control)obj6).Size = size;
		((Control)lblMa_ts).TabIndex = 0;
		lblMa_ts.Text = "Mã tài sản";
		TextBox obj7 = txtdien_giai;
		location = new Point(261, 61);
		((Control)obj7).Location = location;
		((Control)txtdien_giai).Name = "txtdien_giai";
		TextBox obj8 = txtdien_giai;
		size = new Size(343, 20);
		((Control)obj8).Size = size;
		((Control)txtdien_giai).TabIndex = 3;
		lblDien_giai.AutoSize = true;
		Label obj9 = lblDien_giai;
		location = new Point(207, 64);
		((Control)obj9).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj10 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj10).Size = size;
		((Control)lblDien_giai).TabIndex = 18;
		lblDien_giai.Text = "Diễn giải";
		((Control)TabCtlTai_san).Anchor = (AnchorStyles)14;
		((Control)TabCtlTai_san).Controls.Add((Control)(object)tabTTDG);
		((Control)TabCtlTai_san).Controls.Add((Control)(object)tabPT_LK);
		((Control)TabCtlTai_san).Controls.Add((Control)(object)tabTTKH);
		((TabControl)TabCtlTai_san).DrawMode = (TabDrawMode)1;
		AsTabControl tabCtlTai_san = TabCtlTai_san;
		location = new Point(1, 90);
		((Control)tabCtlTai_san).Location = location;
		((Control)TabCtlTai_san).Name = "TabCtlTai_san";
		((TabControl)TabCtlTai_san).SelectedIndex = 0;
		AsTabControl tabCtlTai_san2 = TabCtlTai_san;
		size = new Size(624, 338);
		((Control)tabCtlTai_san2).Size = size;
		((Control)TabCtlTai_san).TabIndex = 4;
		tabTTDG.BackColor = Color.White;
		((Control)tabTTDG).Controls.Add((Control)(object)lblTen_LDTG);
		((Control)tabTTDG).Controls.Add((Control)(object)grbChi_Tiet_NV);
		((Control)tabTTDG).Controls.Add((Control)(object)chkSua_kh);
		((Control)tabTTDG).Controls.Add((Control)(object)lblTy_Le_KH_Thang);
		((Control)tabTTDG).Controls.Add((Control)(object)txtTl_kh);
		((Control)tabTTDG).Controls.Add((Control)(object)lblSo_thang_KH);
		((Control)tabTTDG).Controls.Add((Control)(object)txtSt_kh);
		((Control)tabTTDG).Controls.Add((Control)(object)lblNgay_TG);
		((Control)tabTTDG).Controls.Add((Control)(object)txtngay_tg);
		((Control)tabTTDG).Controls.Add((Control)(object)lblNgay_ct);
		((Control)tabTTDG).Controls.Add((Control)(object)txtNgay_ct);
		((Control)tabTTDG).Controls.Add((Control)(object)txtSo_ct);
		((Control)tabTTDG).Controls.Add((Control)(object)lblSo_ct);
		((Control)tabTTDG).Controls.Add((Control)(object)lblLy_do_TG);
		((Control)tabTTDG).Controls.Add((Control)(object)txtMA_LDTG);
		((Control)tabTTDG).Controls.Add((Control)(object)lblNgay_GTCL);
		((Control)tabTTDG).Controls.Add((Control)(object)txtNgay_gt_cl);
		((Control)tabTTDG).Controls.Add((Control)(object)lblNgay_BD_KH);
		((Control)tabTTDG).Controls.Add((Control)(object)txtNgay_bdkh);
		((Control)tabTTDG).Controls.Add((Control)(object)txtSo_luong);
		((Control)tabTTDG).Controls.Add((Control)(object)lblSlg_TG);
		TabPage obj11 = tabTTDG;
		location = new Point(4, 25);
		obj11.Location = location;
		((Control)tabTTDG).Name = "tabTTDG";
		TabPage obj12 = tabTTDG;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)obj12).Padding = padding;
		TabPage obj13 = tabTTDG;
		size = new Size(616, 309);
		((Control)obj13).Size = size;
		tabTTDG.TabIndex = 0;
		tabTTDG.Text = "Thông tin đánh giá";
		Label obj14 = lblTen_LDTG;
		location = new Point(211, 89);
		((Control)obj14).Location = location;
		((Control)lblTen_LDTG).Name = "lblTen_LDTG";
		Label obj15 = lblTen_LDTG;
		size = new Size(170, 13);
		((Control)obj15).Size = size;
		((Control)lblTen_LDTG).TabIndex = 71;
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblTong_Cong);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtT_kh_th);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtT_ng_gia);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblGT_KH_TD1Thang);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtkh_th_n4);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtkh_th_n3);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtkh_th_n2);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtkh_th_n1);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblNguyen_Gia);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtNg_gia_n4);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtNg_gia_n3);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtNg_gia_n2);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)txtNg_gia_n1);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblng_von4);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblng_von3);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblng_von2);
		((Control)grbChi_Tiet_NV).Controls.Add((Control)(object)lblng_von1);
		GroupBox obj16 = grbChi_Tiet_NV;
		location = new Point(6, 137);
		((Control)obj16).Location = location;
		((Control)grbChi_Tiet_NV).Name = "grbChi_Tiet_NV";
		GroupBox obj17 = grbChi_Tiet_NV;
		size = new Size(607, 163);
		((Control)obj17).Size = size;
		((Control)grbChi_Tiet_NV).TabIndex = 72;
		grbChi_Tiet_NV.TabStop = false;
		grbChi_Tiet_NV.Text = "Chi tiết nguồn vốn";
		lblTong_Cong.AutoSize = true;
		((Control)lblTong_Cong).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj18 = lblTong_Cong;
		location = new Point(16, 139);
		((Control)obj18).Location = location;
		((Control)lblTong_Cong).Name = "lblTong_Cong";
		Label obj19 = lblTong_Cong;
		size = new Size(68, 13);
		((Control)obj19).Size = size;
		((Control)lblTong_Cong).TabIndex = 70;
		lblTong_Cong.Text = "Tổng cộng";
		((TextBoxBase)txtT_kh_th).BackColor = Color.White;
		txtT_kh_th.DecimalSymbol = ".";
		((Control)txtT_kh_th).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_kh_th.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtT_kh_th;
		location = new Point(454, 136);
		((Control)asTextNumeric).Location = location;
		txtT_kh_th.Mask = "### ### ### ###.##";
		((Control)txtT_kh_th).Name = "txtT_kh_th";
		((TextBoxBase)txtT_kh_th).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtT_kh_th;
		size = new Size(139, 20);
		((Control)asTextNumeric2).Size = size;
		txtT_kh_th.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_kh_th).TabIndex = 9;
		((Control)txtT_kh_th).Tag = "AM";
		((TextBox)txtT_kh_th).Text = "0.00";
		((TextBox)txtT_kh_th).TextAlign = (HorizontalAlignment)1;
		txtT_kh_th.Value = 0;
		((TextBoxBase)txtT_ng_gia).BackColor = Color.White;
		txtT_ng_gia.DecimalSymbol = ".";
		((Control)txtT_ng_gia).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_ng_gia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtT_ng_gia;
		location = new Point(250, 136);
		((Control)asTextNumeric3).Location = location;
		txtT_ng_gia.Mask = "### ### ### ###.##";
		((Control)txtT_ng_gia).Name = "txtT_ng_gia";
		((TextBoxBase)txtT_ng_gia).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtT_ng_gia;
		size = new Size(92, 20);
		((Control)asTextNumeric4).Size = size;
		txtT_ng_gia.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_ng_gia).TabIndex = 4;
		((Control)txtT_ng_gia).Tag = "AM";
		((TextBox)txtT_ng_gia).Text = "0.00";
		((TextBox)txtT_ng_gia).TextAlign = (HorizontalAlignment)1;
		txtT_ng_gia.Value = 0;
		lblGT_KH_TD1Thang.AutoSize = true;
		Label obj20 = lblGT_KH_TD1Thang;
		location = new Point(451, 15);
		((Control)obj20).Location = location;
		((Control)lblGT_KH_TD1Thang).Name = "lblGT_KH_TD1Thang";
		Label obj21 = lblGT_KH_TD1Thang;
		size = new Size(132, 13);
		((Control)obj21).Size = size;
		((Control)lblGT_KH_TD1Thang).TabIndex = 65;
		lblGT_KH_TD1Thang.Text = "Giá trị KH thay đổi 1 tháng";
		((TextBoxBase)txtkh_th_n4).BackColor = Color.White;
		txtkh_th_n4.DecimalSymbol = ".";
		((Control)txtkh_th_n4).Enabled = false;
		txtkh_th_n4.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtkh_th_n4;
		location = new Point(454, 111);
		((Control)asTextNumeric5).Location = location;
		txtkh_th_n4.Mask = "### ### ### ###.##";
		((Control)txtkh_th_n4).Name = "txtkh_th_n4";
		AsTextNumeric asTextNumeric6 = txtkh_th_n4;
		size = new Size(139, 20);
		((Control)asTextNumeric6).Size = size;
		txtkh_th_n4.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtkh_th_n4).TabIndex = 8;
		((Control)txtkh_th_n4).Tag = "AM";
		((TextBox)txtkh_th_n4).Text = "0.00";
		((TextBox)txtkh_th_n4).TextAlign = (HorizontalAlignment)1;
		txtkh_th_n4.Value = 0;
		((TextBoxBase)txtkh_th_n3).BackColor = Color.White;
		txtkh_th_n3.DecimalSymbol = ".";
		((Control)txtkh_th_n3).Enabled = false;
		txtkh_th_n3.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtkh_th_n3;
		location = new Point(454, 85);
		((Control)asTextNumeric7).Location = location;
		txtkh_th_n3.Mask = "### ### ### ###.##";
		((Control)txtkh_th_n3).Name = "txtkh_th_n3";
		AsTextNumeric asTextNumeric8 = txtkh_th_n3;
		size = new Size(139, 20);
		((Control)asTextNumeric8).Size = size;
		txtkh_th_n3.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtkh_th_n3).TabIndex = 7;
		((Control)txtkh_th_n3).Tag = "AM";
		((TextBox)txtkh_th_n3).Text = "0.00";
		((TextBox)txtkh_th_n3).TextAlign = (HorizontalAlignment)1;
		txtkh_th_n3.Value = 0;
		((TextBoxBase)txtkh_th_n2).BackColor = Color.White;
		txtkh_th_n2.DecimalSymbol = ".";
		((Control)txtkh_th_n2).Enabled = false;
		txtkh_th_n2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric9 = txtkh_th_n2;
		location = new Point(454, 59);
		((Control)asTextNumeric9).Location = location;
		txtkh_th_n2.Mask = "### ### ### ###.##";
		((Control)txtkh_th_n2).Name = "txtkh_th_n2";
		AsTextNumeric asTextNumeric10 = txtkh_th_n2;
		size = new Size(139, 20);
		((Control)asTextNumeric10).Size = size;
		txtkh_th_n2.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtkh_th_n2).TabIndex = 6;
		((Control)txtkh_th_n2).Tag = "AM";
		((TextBox)txtkh_th_n2).Text = "0.00";
		((TextBox)txtkh_th_n2).TextAlign = (HorizontalAlignment)1;
		txtkh_th_n2.Value = 0;
		((TextBoxBase)txtkh_th_n1).BackColor = Color.White;
		txtkh_th_n1.DecimalSymbol = ".";
		((Control)txtkh_th_n1).Enabled = false;
		txtkh_th_n1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric11 = txtkh_th_n1;
		location = new Point(454, 33);
		((Control)asTextNumeric11).Location = location;
		txtkh_th_n1.Mask = "### ### ### ###.##";
		((Control)txtkh_th_n1).Name = "txtkh_th_n1";
		AsTextNumeric asTextNumeric12 = txtkh_th_n1;
		size = new Size(139, 20);
		((Control)asTextNumeric12).Size = size;
		txtkh_th_n1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtkh_th_n1).TabIndex = 5;
		((Control)txtkh_th_n1).Tag = "AM";
		((TextBox)txtkh_th_n1).Text = "0.00";
		((TextBox)txtkh_th_n1).TextAlign = (HorizontalAlignment)1;
		txtkh_th_n1.Value = 0;
		lblNguyen_Gia.AutoSize = true;
		Label obj22 = lblNguyen_Gia;
		location = new Point(247, 15);
		((Control)obj22).Location = location;
		((Control)lblNguyen_Gia).Name = "lblNguyen_Gia";
		Label obj23 = lblNguyen_Gia;
		size = new Size(61, 13);
		((Control)obj23).Size = size;
		((Control)lblNguyen_Gia).TabIndex = 50;
		lblNguyen_Gia.Text = "Nguyên giá";
		((TextBoxBase)txtNg_gia_n4).BackColor = Color.White;
		txtNg_gia_n4.DecimalSymbol = ".";
		txtNg_gia_n4.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric13 = txtNg_gia_n4;
		location = new Point(250, 111);
		((Control)asTextNumeric13).Location = location;
		txtNg_gia_n4.Mask = "### ### ### ###.##";
		((Control)txtNg_gia_n4).Name = "txtNg_gia_n4";
		AsTextNumeric asTextNumeric14 = txtNg_gia_n4;
		size = new Size(92, 20);
		((Control)asTextNumeric14).Size = size;
		txtNg_gia_n4.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNg_gia_n4).TabIndex = 3;
		((Control)txtNg_gia_n4).Tag = "AM";
		((TextBox)txtNg_gia_n4).Text = "0.00";
		((TextBox)txtNg_gia_n4).TextAlign = (HorizontalAlignment)1;
		txtNg_gia_n4.Value = 0;
		((TextBoxBase)txtNg_gia_n3).BackColor = Color.White;
		txtNg_gia_n3.DecimalSymbol = ".";
		txtNg_gia_n3.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric15 = txtNg_gia_n3;
		location = new Point(250, 85);
		((Control)asTextNumeric15).Location = location;
		txtNg_gia_n3.Mask = "### ### ### ###.##";
		((Control)txtNg_gia_n3).Name = "txtNg_gia_n3";
		AsTextNumeric asTextNumeric16 = txtNg_gia_n3;
		size = new Size(92, 20);
		((Control)asTextNumeric16).Size = size;
		txtNg_gia_n3.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNg_gia_n3).TabIndex = 2;
		((Control)txtNg_gia_n3).Tag = "AM";
		((TextBox)txtNg_gia_n3).Text = "0.00";
		((TextBox)txtNg_gia_n3).TextAlign = (HorizontalAlignment)1;
		txtNg_gia_n3.Value = 0;
		((TextBoxBase)txtNg_gia_n2).BackColor = Color.White;
		txtNg_gia_n2.DecimalSymbol = ".";
		txtNg_gia_n2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric17 = txtNg_gia_n2;
		location = new Point(250, 59);
		((Control)asTextNumeric17).Location = location;
		txtNg_gia_n2.Mask = "### ### ### ###.##";
		((Control)txtNg_gia_n2).Name = "txtNg_gia_n2";
		AsTextNumeric asTextNumeric18 = txtNg_gia_n2;
		size = new Size(92, 20);
		((Control)asTextNumeric18).Size = size;
		txtNg_gia_n2.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNg_gia_n2).TabIndex = 1;
		((Control)txtNg_gia_n2).Tag = "AM";
		((TextBox)txtNg_gia_n2).Text = "0.00";
		((TextBox)txtNg_gia_n2).TextAlign = (HorizontalAlignment)1;
		txtNg_gia_n2.Value = 0;
		((TextBoxBase)txtNg_gia_n1).BackColor = Color.White;
		txtNg_gia_n1.DecimalSymbol = ".";
		txtNg_gia_n1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric19 = txtNg_gia_n1;
		location = new Point(250, 33);
		((Control)asTextNumeric19).Location = location;
		txtNg_gia_n1.Mask = "### ### ### ###.##";
		((Control)txtNg_gia_n1).Name = "txtNg_gia_n1";
		AsTextNumeric asTextNumeric20 = txtNg_gia_n1;
		size = new Size(92, 20);
		((Control)asTextNumeric20).Size = size;
		txtNg_gia_n1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNg_gia_n1).TabIndex = 0;
		((Control)txtNg_gia_n1).Tag = "AM";
		((TextBox)txtNg_gia_n1).Text = "0.00";
		((TextBox)txtNg_gia_n1).TextAlign = (HorizontalAlignment)1;
		txtNg_gia_n1.Value = 0;
		lblng_von4.AutoSize = true;
		Label obj24 = lblng_von4;
		location = new Point(16, 114);
		((Control)obj24).Location = location;
		((Control)lblng_von4).Name = "lblng_von4";
		Label obj25 = lblng_von4;
		size = new Size(0, 13);
		((Control)obj25).Size = size;
		((Control)lblng_von4).TabIndex = 45;
		lblng_von3.AutoSize = true;
		Label obj26 = lblng_von3;
		location = new Point(16, 88);
		((Control)obj26).Location = location;
		((Control)lblng_von3).Name = "lblng_von3";
		Label obj27 = lblng_von3;
		size = new Size(0, 13);
		((Control)obj27).Size = size;
		((Control)lblng_von3).TabIndex = 44;
		lblng_von2.AutoSize = true;
		Label obj28 = lblng_von2;
		location = new Point(16, 62);
		((Control)obj28).Location = location;
		((Control)lblng_von2).Name = "lblng_von2";
		Label obj29 = lblng_von2;
		size = new Size(0, 13);
		((Control)obj29).Size = size;
		((Control)lblng_von2).TabIndex = 43;
		lblng_von1.AutoSize = true;
		Label obj30 = lblng_von1;
		location = new Point(16, 36);
		((Control)obj30).Location = location;
		((Control)lblng_von1).Name = "lblng_von1";
		Label obj31 = lblng_von1;
		size = new Size(0, 13);
		((Control)obj31).Size = size;
		((Control)lblng_von1).TabIndex = 42;
		((ButtonBase)chkSua_kh).AutoSize = true;
		chkSua_kh.Checked = false;
		AsCheckBox asCheckBox = chkSua_kh;
		location = new Point(515, 113);
		((Control)asCheckBox).Location = location;
		((Control)chkSua_kh).Name = "chkSua_kh";
		AsCheckBox asCheckBox2 = chkSua_kh;
		size = new Size(63, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkSua_kh).TabIndex = 10;
		((ButtonBase)chkSua_kh).Text = "Sửa KH";
		chkSua_kh.TextValue = "0";
		((ButtonBase)chkSua_kh).UseVisualStyleBackColor = true;
		lblTy_Le_KH_Thang.AutoSize = true;
		Label obj32 = lblTy_Le_KH_Thang;
		location = new Point(402, 89);
		((Control)obj32).Location = location;
		((Control)lblTy_Le_KH_Thang).Name = "lblTy_Le_KH_Thang";
		Label obj33 = lblTy_Le_KH_Thang;
		size = new Size(78, 13);
		((Control)obj33).Size = size;
		((Control)lblTy_Le_KH_Thang).TabIndex = 70;
		lblTy_Le_KH_Thang.Text = "Tỷ lệ KH tháng";
		((TextBoxBase)txtTl_kh).BackColor = Color.White;
		txtTl_kh.DecimalSymbol = ".";
		txtTl_kh.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric21 = txtTl_kh;
		location = new Point(515, 85);
		((Control)asTextNumeric21).Location = location;
		txtTl_kh.Mask = "### ### ### ###.###";
		((Control)txtTl_kh).Name = "txtTl_kh";
		((TextBoxBase)txtTl_kh).ReadOnly = true;
		AsTextNumeric asTextNumeric22 = txtTl_kh;
		size = new Size(82, 20);
		((Control)asTextNumeric22).Size = size;
		txtTl_kh.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTl_kh).TabIndex = 9;
		((TextBox)txtTl_kh).Text = "0.000";
		((TextBox)txtTl_kh).TextAlign = (HorizontalAlignment)1;
		txtTl_kh.Value = 0;
		lblSo_thang_KH.AutoSize = true;
		Label obj34 = lblSo_thang_KH;
		location = new Point(402, 63);
		((Control)obj34).Location = location;
		((Control)lblSo_thang_KH).Name = "lblSo_thang_KH";
		Label obj35 = lblSo_thang_KH;
		size = new Size(68, 13);
		((Control)obj35).Size = size;
		((Control)lblSo_thang_KH).TabIndex = 67;
		lblSo_thang_KH.Text = "Số tháng KH";
		((TextBoxBase)txtSt_kh).BackColor = Color.White;
		txtSt_kh.DecimalSymbol = ".";
		txtSt_kh.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric23 = txtSt_kh;
		location = new Point(515, 59);
		((Control)asTextNumeric23).Location = location;
		txtSt_kh.Mask = "####";
		((Control)txtSt_kh).Name = "txtSt_kh";
		AsTextNumeric asTextNumeric24 = txtSt_kh;
		size = new Size(82, 20);
		((Control)asTextNumeric24).Size = size;
		txtSt_kh.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSt_kh).TabIndex = 8;
		((TextBox)txtSt_kh).Text = "0";
		((TextBox)txtSt_kh).TextAlign = (HorizontalAlignment)1;
		txtSt_kh.Value = 0;
		lblNgay_TG.AutoSize = true;
		Label obj36 = lblNgay_TG;
		location = new Point(10, 63);
		((Control)obj36).Location = location;
		((Control)lblNgay_TG).Name = "lblNgay_TG";
		Label obj37 = lblNgay_TG;
		size = new Size(81, 13);
		((Control)obj37).Size = size;
		((Control)lblNgay_TG).TabIndex = 65;
		lblNgay_TG.Text = "Ngày tăng giảm";
		((TextBoxBase)txtngay_tg).BackColor = Color.White;
		txtngay_tg.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtngay_tg).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtngay_tg;
		location = new Point(123, 59);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtngay_tg).Mask = "##/##/####";
		((Control)txtngay_tg).Name = "txtngay_tg";
		((MaskedTextBox)txtngay_tg).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtngay_tg;
		size = new Size(82, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtngay_tg).TabIndex = 2;
		((MaskedTextBox)txtngay_tg).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtngay_tg;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		lblNgay_ct.AutoSize = true;
		Label obj38 = lblNgay_ct;
		location = new Point(10, 37);
		((Control)obj38).Location = location;
		((Control)lblNgay_ct).Name = "lblNgay_ct";
		Label obj39 = lblNgay_ct;
		size = new Size(77, 13);
		((Control)obj39).Size = size;
		((Control)lblNgay_ct).TabIndex = 51;
		lblNgay_ct.Text = "Ngày chứng từ";
		((TextBoxBase)txtNgay_ct).BackColor = Color.White;
		txtNgay_ct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_ct;
		location = new Point(123, 33);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_ct).Mask = "##/##/####";
		((Control)txtNgay_ct).Name = "txtNgay_ct";
		((MaskedTextBox)txtNgay_ct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_ct;
		size = new Size(82, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_ct).TabIndex = 1;
		((MaskedTextBox)txtNgay_ct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_ct;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		((TextBoxBase)txtSo_ct).BackColor = Color.White;
		TextBox obj40 = txtSo_ct;
		location = new Point(123, 7);
		((Control)obj40).Location = location;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj41 = txtSo_ct;
		size = new Size(127, 20);
		((Control)obj41).Size = size;
		((Control)txtSo_ct).TabIndex = 0;
		((Control)txtSo_ct).Tag = "";
		lblSo_ct.AutoSize = true;
		Label obj42 = lblSo_ct;
		location = new Point(10, 11);
		((Control)obj42).Location = location;
		((Control)lblSo_ct).Name = "lblSo_ct";
		Label obj43 = lblSo_ct;
		size = new Size(65, 13);
		((Control)obj43).Size = size;
		((Control)lblSo_ct).TabIndex = 49;
		lblSo_ct.Text = "Số chứng từ";
		lblLy_do_TG.AutoSize = true;
		Label obj44 = lblLy_do_TG;
		location = new Point(10, 89);
		((Control)obj44).Location = location;
		((Control)lblLy_do_TG).Name = "lblLy_do_TG";
		Label obj45 = lblLy_do_TG;
		size = new Size(82, 13);
		((Control)obj45).Size = size;
		((Control)lblLy_do_TG).TabIndex = 47;
		lblLy_do_TG.Text = "Lý do tăng giảm";
		txtMA_LDTG.AutoLookup = true;
		txtMA_LDTG.AutoValid = true;
		((TextBoxBase)txtMA_LDTG).BackColor = SystemColors.Info;
		((TextBox)txtMA_LDTG).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMA_LDTG;
		location = new Point(123, 85);
		((Control)asTextBox).Location = location;
		txtMA_LDTG.LookupCodeName = "MA_LDTG";
		txtMA_LDTG.LookupWhereCondition = "tg='T'";
		((Control)txtMA_LDTG).Name = "txtMA_LDTG";
		txtMA_LDTG.NameControl = lblTen_LDTG;
		txtMA_LDTG.SD = true;
		AsTextBox asTextBox2 = txtMA_LDTG;
		size = new Size(82, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMA_LDTG).TabIndex = 4;
		((Control)txtMA_LDTG).Tag = "MA_LDTG";
		txtMA_LDTG.UseAutoCompleteSource = true;
		txtMA_LDTG.ValidReturnFieldList = "ten_ldtg";
		lblNgay_GTCL.AutoSize = true;
		Label obj46 = lblNgay_GTCL;
		location = new Point(402, 37);
		((Control)obj46).Location = location;
		((Control)lblNgay_GTCL).Name = "lblNgay_GTCL";
		Label obj47 = lblNgay_GTCL;
		size = new Size(63, 13);
		((Control)obj47).Size = size;
		((Control)lblNgay_GTCL).TabIndex = 41;
		lblNgay_GTCL.Text = "Ngày GTCL";
		((TextBoxBase)txtNgay_gt_cl).BackColor = Color.White;
		txtNgay_gt_cl.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_gt_cl).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox7 = txtNgay_gt_cl;
		location = new Point(515, 33);
		((Control)asMaskedTextBox7).Location = location;
		((MaskedTextBox)txtNgay_gt_cl).Mask = "##/##/####";
		((Control)txtNgay_gt_cl).Name = "txtNgay_gt_cl";
		((MaskedTextBox)txtNgay_gt_cl).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox8 = txtNgay_gt_cl;
		size = new Size(82, 20);
		((Control)asMaskedTextBox8).Size = size;
		((Control)txtNgay_gt_cl).TabIndex = 7;
		((MaskedTextBox)txtNgay_gt_cl).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox9 = txtNgay_gt_cl;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox9.Value = dateTime;
		lblNgay_BD_KH.AutoSize = true;
		Label obj48 = lblNgay_BD_KH;
		location = new Point(402, 11);
		((Control)obj48).Location = location;
		((Control)lblNgay_BD_KH).Name = "lblNgay_BD_KH";
		Label obj49 = lblNgay_BD_KH;
		size = new Size(90, 13);
		((Control)obj49).Size = size;
		((Control)lblNgay_BD_KH).TabIndex = 39;
		lblNgay_BD_KH.Text = "Ngày bắt đầu KH";
		((TextBoxBase)txtNgay_bdkh).BackColor = Color.White;
		txtNgay_bdkh.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_bdkh).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox10 = txtNgay_bdkh;
		location = new Point(515, 7);
		((Control)asMaskedTextBox10).Location = location;
		((MaskedTextBox)txtNgay_bdkh).Mask = "##/##/####";
		((Control)txtNgay_bdkh).Name = "txtNgay_bdkh";
		((MaskedTextBox)txtNgay_bdkh).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox11 = txtNgay_bdkh;
		size = new Size(82, 20);
		((Control)asMaskedTextBox11).Size = size;
		((Control)txtNgay_bdkh).TabIndex = 6;
		((MaskedTextBox)txtNgay_bdkh).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox12 = txtNgay_bdkh;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox12.Value = dateTime;
		((TextBoxBase)txtSo_luong).BackColor = Color.White;
		txtSo_luong.DecimalSymbol = ".";
		txtSo_luong.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric25 = txtSo_luong;
		location = new Point(123, 111);
		((Control)asTextNumeric25).Location = location;
		txtSo_luong.Mask = "### ### ### ###";
		((Control)txtSo_luong).Name = "txtSo_luong";
		AsTextNumeric asTextNumeric26 = txtSo_luong;
		size = new Size(82, 20);
		((Control)asTextNumeric26).Size = size;
		txtSo_luong.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSo_luong).TabIndex = 5;
		((TextBox)txtSo_luong).Text = "0";
		((TextBox)txtSo_luong).TextAlign = (HorizontalAlignment)1;
		txtSo_luong.Value = 0;
		lblSlg_TG.AutoSize = true;
		Label obj50 = lblSlg_TG;
		location = new Point(10, 115);
		((Control)obj50).Location = location;
		((Control)lblSlg_TG).Name = "lblSlg_TG";
		Label obj51 = lblSlg_TG;
		size = new Size(98, 13);
		((Control)obj51).Size = size;
		((Control)lblSlg_TG).TabIndex = 32;
		lblSlg_TG.Text = "Số lượng tăng giảm";
		tabPT_LK.BackColor = Color.White;
		((Control)tabPT_LK).Controls.Add((Control)(object)lblGT);
		((Control)tabPT_LK).Controls.Add((Control)(object)txtGia_tri);
		((Control)tabPT_LK).Controls.Add((Control)(object)lblSlg);
		((Control)tabPT_LK).Controls.Add((Control)(object)txtSo_luonglk);
		((Control)tabPT_LK).Controls.Add((Control)(object)txtMa_Lk);
		((Control)tabPT_LK).Controls.Add((Control)(object)dgvLinh_kien);
		((Control)tabPT_LK).Controls.Add((Control)(object)cmdDel_lk);
		((Control)tabPT_LK).Controls.Add((Control)(object)cmdAdd_lk);
		((Control)tabPT_LK).Controls.Add((Control)(object)chkTG);
		((Control)tabPT_LK).Controls.Add((Control)(object)txtDvt_Lk);
		((Control)tabPT_LK).Controls.Add((Control)(object)lblDVT);
		((Control)tabPT_LK).Controls.Add((Control)(object)txtTen_lk);
		((Control)tabPT_LK).Controls.Add((Control)(object)lblTen_lk);
		((Control)tabPT_LK).Controls.Add((Control)(object)lblMa_lk);
		TabPage obj52 = tabPT_LK;
		location = new Point(4, 25);
		obj52.Location = location;
		((Control)tabPT_LK).Name = "tabPT_LK";
		TabPage obj53 = tabPT_LK;
		size = new Size(616, 309);
		((Control)obj53).Size = size;
		tabPT_LK.TabIndex = 2;
		tabPT_LK.Text = "Đánh giá phụ &tùng, linh kiện";
		lblGT.AutoSize = true;
		Label obj54 = lblGT;
		location = new Point(8, 114);
		((Control)obj54).Location = location;
		((Control)lblGT).Name = "lblGT";
		Label obj55 = lblGT;
		size = new Size(34, 13);
		((Control)obj55).Size = size;
		((Control)lblGT).TabIndex = 40;
		lblGT.Text = "Giá trị";
		((TextBoxBase)txtGia_tri).BackColor = Color.White;
		txtGia_tri.DecimalSymbol = ".";
		txtGia_tri.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric27 = txtGia_tri;
		location = new Point(84, 111);
		((Control)asTextNumeric27).Location = location;
		txtGia_tri.Mask = "### ### ### ###.##";
		((Control)txtGia_tri).Name = "txtGia_tri";
		AsTextNumeric asTextNumeric28 = txtGia_tri;
		size = new Size(142, 20);
		((Control)asTextNumeric28).Size = size;
		txtGia_tri.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGia_tri).TabIndex = 4;
		((TextBox)txtGia_tri).Text = "0.00";
		((TextBox)txtGia_tri).TextAlign = (HorizontalAlignment)1;
		txtGia_tri.Value = 0;
		lblSlg.AutoSize = true;
		Label obj56 = lblSlg;
		location = new Point(8, 89);
		((Control)obj56).Location = location;
		((Control)lblSlg).Name = "lblSlg";
		Label obj57 = lblSlg;
		size = new Size(49, 13);
		((Control)obj57).Size = size;
		((Control)lblSlg).TabIndex = 38;
		lblSlg.Text = "Số lượng";
		((TextBoxBase)txtSo_luonglk).BackColor = Color.White;
		txtSo_luonglk.DecimalSymbol = ".";
		txtSo_luonglk.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric29 = txtSo_luonglk;
		location = new Point(84, 85);
		((Control)asTextNumeric29).Location = location;
		txtSo_luonglk.Mask = "### ### ### ###";
		((Control)txtSo_luonglk).Name = "txtSo_luonglk";
		AsTextNumeric asTextNumeric30 = txtSo_luonglk;
		size = new Size(75, 20);
		((Control)asTextNumeric30).Size = size;
		txtSo_luonglk.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSo_luonglk).TabIndex = 3;
		((TextBox)txtSo_luonglk).Text = "0";
		((TextBox)txtSo_luonglk).TextAlign = (HorizontalAlignment)1;
		txtSo_luonglk.Value = 0;
		((TextBoxBase)txtMa_Lk).BackColor = Color.White;
		TextBox obj58 = txtMa_Lk;
		location = new Point(84, 7);
		((Control)obj58).Location = location;
		((Control)txtMa_Lk).Name = "txtMa_Lk";
		TextBox obj59 = txtMa_Lk;
		size = new Size(75, 20);
		((Control)obj59).Size = size;
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
			(DataGridViewColumn)Tang_giam
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvLinh_kien).DefaultCellStyle = val2;
		((DataGridView)dgvLinh_kien).EditMode = (DataGridViewEditMode)4;
		((DataGridView)dgvLinh_kien).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = dgvLinh_kien;
		location = new Point(3, 148);
		((Control)asInputDGV).Location = location;
		((Control)dgvLinh_kien).Name = "dgvLinh_kien";
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
		((Control)dgvLinh_kien).TabIndex = 8;
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
		((DataGridViewColumn)Tang_giam).DataPropertyName = "tang_giam";
		((DataGridViewColumn)Tang_giam).HeaderText = "Tăng / Giảm";
		((DataGridViewColumn)Tang_giam).Name = "Tang_giam";
		((DataGridViewColumn)Tang_giam).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)Tang_giam).SortMode = (DataGridViewColumnSortMode)1;
		((Control)cmdDel_lk).Anchor = (AnchorStyles)10;
		Button obj60 = cmdDel_lk;
		location = new Point(526, 117);
		((Control)obj60).Location = location;
		((Control)cmdDel_lk).Name = "cmdDel_lk";
		Button obj61 = cmdDel_lk;
		size = new Size(75, 23);
		((Control)obj61).Size = size;
		((Control)cmdDel_lk).TabIndex = 7;
		((ButtonBase)cmdDel_lk).Text = "&Xóa";
		((ButtonBase)cmdDel_lk).UseVisualStyleBackColor = true;
		((Control)cmdAdd_lk).Anchor = (AnchorStyles)10;
		Button obj62 = cmdAdd_lk;
		location = new Point(526, 88);
		((Control)obj62).Location = location;
		((Control)cmdAdd_lk).Name = "cmdAdd_lk";
		Button obj63 = cmdAdd_lk;
		size = new Size(75, 23);
		((Control)obj63).Size = size;
		((Control)cmdAdd_lk).TabIndex = 6;
		((ButtonBase)cmdAdd_lk).Text = "&Thêm";
		((ButtonBase)cmdAdd_lk).UseVisualStyleBackColor = true;
		((Control)chkTG).Anchor = (AnchorStyles)10;
		((ButtonBase)chkTG).AutoSize = true;
		chkTG.Checked = false;
		AsCheckBox asCheckBox3 = chkTG;
		location = new Point(280, 114);
		((Control)asCheckBox3).Location = location;
		((Control)chkTG).Name = "chkTG";
		AsCheckBox asCheckBox4 = chkTG;
		size = new Size(128, 17);
		((Control)asCheckBox4).Size = size;
		((Control)chkTG).TabIndex = 5;
		((ButtonBase)chkTG).Text = "Tăng / Giảm linh kiện";
		chkTG.TextValue = "0";
		((ButtonBase)chkTG).UseVisualStyleBackColor = true;
		((TextBoxBase)txtDvt_Lk).BackColor = Color.White;
		TextBox obj64 = txtDvt_Lk;
		location = new Point(84, 59);
		((Control)obj64).Location = location;
		((Control)txtDvt_Lk).Name = "txtDvt_Lk";
		TextBox obj65 = txtDvt_Lk;
		size = new Size(44, 20);
		((Control)obj65).Size = size;
		((Control)txtDvt_Lk).TabIndex = 2;
		lblDVT.AutoSize = true;
		Label obj66 = lblDVT;
		location = new Point(8, 63);
		((Control)obj66).Location = location;
		((Control)lblDVT).Name = "lblDVT";
		Label obj67 = lblDVT;
		size = new Size(60, 13);
		((Control)obj67).Size = size;
		((Control)lblDVT).TabIndex = 12;
		lblDVT.Text = "Đơn vị tính";
		((TextBoxBase)txtTen_lk).BackColor = Color.White;
		TextBox obj68 = txtTen_lk;
		location = new Point(84, 33);
		((Control)obj68).Location = location;
		((Control)txtTen_lk).Name = "txtTen_lk";
		TextBox obj69 = txtTen_lk;
		size = new Size(320, 20);
		((Control)obj69).Size = size;
		((Control)txtTen_lk).TabIndex = 1;
		lblTen_lk.AutoSize = true;
		Label obj70 = lblTen_lk;
		location = new Point(8, 37);
		((Control)obj70).Location = location;
		((Control)lblTen_lk).Name = "lblTen_lk";
		Label obj71 = lblTen_lk;
		size = new Size(68, 13);
		((Control)obj71).Size = size;
		((Control)lblTen_lk).TabIndex = 10;
		lblTen_lk.Text = "Tên linh kiện";
		lblMa_lk.AutoSize = true;
		Label obj72 = lblMa_lk;
		location = new Point(8, 11);
		((Control)obj72).Location = location;
		((Control)lblMa_lk).Name = "lblMa_lk";
		Label obj73 = lblMa_lk;
		size = new Size(64, 13);
		((Control)obj73).Size = size;
		((Control)lblMa_lk).TabIndex = 7;
		lblMa_lk.Text = "Mã linh kiện";
		tabTTKH.BackColor = Color.White;
		((Control)tabTTKH).Controls.Add((Control)(object)txtTk_cp);
		((Control)tabTTKH).Controls.Add((Control)(object)txtTk_kh);
		((Control)tabTTKH).Controls.Add((Control)(object)txtTk_ts);
		((Control)tabTTKH).Controls.Add((Control)(object)chkEdit_kh);
		((Control)tabTTKH).Controls.Add((Control)(object)lblSlg1);
		((Control)tabTTKH).Controls.Add((Control)(object)txtSo_luong_kh);
		((Control)tabTTKH).Controls.Add((Control)(object)lblNgay_tang);
		((Control)tabTTKH).Controls.Add((Control)(object)txtNgay_tang);
		((Control)tabTTKH).Controls.Add((Control)(object)lblNgay_GTCL1);
		((Control)tabTTKH).Controls.Add((Control)(object)txtngay_gt_con_lai);
		((Control)tabTTKH).Controls.Add((Control)(object)chkTinh_kh);
		((Control)tabTTKH).Controls.Add((Control)(object)lblTy_le_KH_Thang1);
		((Control)tabTTKH).Controls.Add((Control)(object)txtty_le_kh);
		((Control)tabTTKH).Controls.Add((Control)(object)lblSo_Thang_KH1);
		((Control)tabTTKH).Controls.Add((Control)(object)txtso_thang_kh);
		((Control)tabTTKH).Controls.Add((Control)(object)grbChi_Tiet_NV1);
		((Control)tabTTKH).Controls.Add((Control)(object)lblTK_CP);
		((Control)tabTTKH).Controls.Add((Control)(object)lblTK_KH);
		((Control)tabTTKH).Controls.Add((Control)(object)lblTK_TS);
		TabPage obj74 = tabTTKH;
		location = new Point(4, 25);
		obj74.Location = location;
		((Control)tabTTKH).Name = "tabTTKH";
		TabPage obj75 = tabTTKH;
		((Padding)(ref padding))._002Ector(3);
		((Control)obj75).Padding = padding;
		TabPage obj76 = tabTTKH;
		size = new Size(616, 309);
		((Control)obj76).Size = size;
		tabTTKH.TabIndex = 1;
		tabTTKH.Text = "Thông tin &tài sản";
		TextBox obj77 = txtTk_cp;
		location = new Point(517, 60);
		((Control)obj77).Location = location;
		((Control)txtTk_cp).Name = "txtTk_cp";
		TextBox obj78 = txtTk_cp;
		size = new Size(82, 20);
		((Control)obj78).Size = size;
		((Control)txtTk_cp).TabIndex = 8;
		TextBox obj79 = txtTk_kh;
		location = new Point(517, 34);
		((Control)obj79).Location = location;
		((Control)txtTk_kh).Name = "txtTk_kh";
		TextBox obj80 = txtTk_kh;
		size = new Size(82, 20);
		((Control)obj80).Size = size;
		((Control)txtTk_kh).TabIndex = 7;
		TextBox obj81 = txtTk_ts;
		location = new Point(517, 8);
		((Control)obj81).Location = location;
		((Control)txtTk_ts).Name = "txtTk_ts";
		TextBox obj82 = txtTk_ts;
		size = new Size(82, 20);
		((Control)obj82).Size = size;
		((Control)txtTk_ts).TabIndex = 6;
		((ButtonBase)chkEdit_kh).AutoSize = true;
		((ButtonBase)chkEdit_kh).BackColor = Color.Transparent;
		chkEdit_kh.Checked = false;
		((Control)chkEdit_kh).Enabled = false;
		((Control)chkEdit_kh).ForeColor = Color.Black;
		AsCheckBox asCheckBox5 = chkEdit_kh;
		location = new Point(515, 86);
		((Control)asCheckBox5).Location = location;
		((Control)chkEdit_kh).Name = "chkEdit_kh";
		AsCheckBox asCheckBox6 = chkEdit_kh;
		size = new Size(63, 17);
		((Control)asCheckBox6).Size = size;
		((Control)chkEdit_kh).TabIndex = 9;
		((ButtonBase)chkEdit_kh).Text = "Sửa KH";
		chkEdit_kh.TextValue = "0";
		((ButtonBase)chkEdit_kh).UseVisualStyleBackColor = false;
		lblSlg1.AutoSize = true;
		Label obj83 = lblSlg1;
		location = new Point(200, 64);
		((Control)obj83).Location = location;
		((Control)lblSlg1).Name = "lblSlg1";
		Label obj84 = lblSlg1;
		size = new Size(49, 13);
		((Control)obj84).Size = size;
		((Control)lblSlg1).TabIndex = 55;
		lblSlg1.Text = "Sổ lượng";
		((TextBoxBase)txtSo_luong_kh).BackColor = Color.White;
		txtSo_luong_kh.DecimalSymbol = ".";
		txtSo_luong_kh.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric31 = txtSo_luong_kh;
		location = new Point(284, 60);
		((Control)asTextNumeric31).Location = location;
		txtSo_luong_kh.Mask = "##";
		((Control)txtSo_luong_kh).Name = "txtSo_luong_kh";
		((TextBoxBase)txtSo_luong_kh).ReadOnly = true;
		AsTextNumeric asTextNumeric32 = txtSo_luong_kh;
		size = new Size(82, 20);
		((Control)asTextNumeric32).Size = size;
		txtSo_luong_kh.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSo_luong_kh).TabIndex = 4;
		((TextBox)txtSo_luong_kh).Text = "0";
		((TextBox)txtSo_luong_kh).TextAlign = (HorizontalAlignment)1;
		txtSo_luong_kh.Value = 0;
		lblNgay_tang.AutoSize = true;
		Label obj85 = lblNgay_tang;
		location = new Point(8, 12);
		((Control)obj85).Location = location;
		((Control)lblNgay_tang).Name = "lblNgay_tang";
		Label obj86 = lblNgay_tang;
		size = new Size(56, 13);
		((Control)obj86).Size = size;
		((Control)lblNgay_tang).TabIndex = 53;
		lblNgay_tang.Text = "Ngày tăng";
		((TextBoxBase)txtNgay_tang).BackColor = Color.White;
		txtNgay_tang.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_tang).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox13 = txtNgay_tang;
		location = new Point(86, 8);
		((Control)asMaskedTextBox13).Location = location;
		((MaskedTextBox)txtNgay_tang).Mask = "##/##/####";
		((Control)txtNgay_tang).Name = "txtNgay_tang";
		((MaskedTextBox)txtNgay_tang).PromptChar = ' ';
		((MaskedTextBox)txtNgay_tang).ReadOnly = true;
		AsMaskedTextBox asMaskedTextBox14 = txtNgay_tang;
		size = new Size(82, 20);
		((Control)asMaskedTextBox14).Size = size;
		((Control)txtNgay_tang).TabIndex = 0;
		((MaskedTextBox)txtNgay_tang).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox15 = txtNgay_tang;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox15.Value = dateTime;
		lblNgay_GTCL1.AutoSize = true;
		Label obj87 = lblNgay_GTCL1;
		location = new Point(8, 38);
		((Control)obj87).Location = location;
		((Control)lblNgay_GTCL1).Name = "lblNgay_GTCL1";
		Label obj88 = lblNgay_GTCL1;
		size = new Size(63, 13);
		((Control)obj88).Size = size;
		((Control)lblNgay_GTCL1).TabIndex = 51;
		lblNgay_GTCL1.Text = "Ngày GTCL";
		((TextBoxBase)txtngay_gt_con_lai).BackColor = Color.White;
		txtngay_gt_con_lai.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtngay_gt_con_lai).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox16 = txtngay_gt_con_lai;
		location = new Point(86, 34);
		((Control)asMaskedTextBox16).Location = location;
		((MaskedTextBox)txtngay_gt_con_lai).Mask = "##/##/####";
		((Control)txtngay_gt_con_lai).Name = "txtngay_gt_con_lai";
		((MaskedTextBox)txtngay_gt_con_lai).PromptChar = ' ';
		((MaskedTextBox)txtngay_gt_con_lai).ReadOnly = true;
		AsMaskedTextBox asMaskedTextBox17 = txtngay_gt_con_lai;
		size = new Size(82, 20);
		((Control)asMaskedTextBox17).Size = size;
		((Control)txtngay_gt_con_lai).TabIndex = 1;
		((MaskedTextBox)txtngay_gt_con_lai).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox18 = txtngay_gt_con_lai;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox18.Value = dateTime;
		((ButtonBase)chkTinh_kh).AutoSize = true;
		((ButtonBase)chkTinh_kh).BackColor = Color.Transparent;
		chkTinh_kh.Checked = false;
		((Control)chkTinh_kh).Enabled = false;
		((Control)chkTinh_kh).ForeColor = Color.Black;
		AsCheckBox asCheckBox7 = chkTinh_kh;
		location = new Point(284, 86);
		((Control)asCheckBox7).Location = location;
		((Control)chkTinh_kh).Name = "chkTinh_kh";
		AsCheckBox asCheckBox8 = chkTinh_kh;
		size = new Size(67, 17);
		((Control)asCheckBox8).Size = size;
		((Control)chkTinh_kh).TabIndex = 5;
		((ButtonBase)chkTinh_kh).Text = "Tính KH";
		chkTinh_kh.TextValue = "0";
		((ButtonBase)chkTinh_kh).UseVisualStyleBackColor = false;
		lblTy_le_KH_Thang1.AutoSize = true;
		Label obj89 = lblTy_le_KH_Thang1;
		location = new Point(200, 38);
		((Control)obj89).Location = location;
		((Control)lblTy_le_KH_Thang1).Name = "lblTy_le_KH_Thang1";
		Label obj90 = lblTy_le_KH_Thang1;
		size = new Size(78, 13);
		((Control)obj90).Size = size;
		((Control)lblTy_le_KH_Thang1).TabIndex = 49;
		lblTy_le_KH_Thang1.Text = "Tỷ lệ KH tháng";
		((TextBoxBase)txtty_le_kh).BackColor = Color.White;
		txtty_le_kh.DecimalSymbol = ".";
		txtty_le_kh.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric33 = txtty_le_kh;
		location = new Point(284, 34);
		((Control)asTextNumeric33).Location = location;
		txtty_le_kh.Mask = "### ### ### ###.###";
		((Control)txtty_le_kh).Name = "txtty_le_kh";
		((TextBoxBase)txtty_le_kh).ReadOnly = true;
		AsTextNumeric asTextNumeric34 = txtty_le_kh;
		size = new Size(82, 20);
		((Control)asTextNumeric34).Size = size;
		txtty_le_kh.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtty_le_kh).TabIndex = 3;
		((TextBox)txtty_le_kh).Text = "0.000";
		((TextBox)txtty_le_kh).TextAlign = (HorizontalAlignment)1;
		txtty_le_kh.Value = 0;
		lblSo_Thang_KH1.AutoSize = true;
		Label obj91 = lblSo_Thang_KH1;
		location = new Point(200, 12);
		((Control)obj91).Location = location;
		((Control)lblSo_Thang_KH1).Name = "lblSo_Thang_KH1";
		Label obj92 = lblSo_Thang_KH1;
		size = new Size(68, 13);
		((Control)obj92).Size = size;
		((Control)lblSo_Thang_KH1).TabIndex = 48;
		lblSo_Thang_KH1.Text = "Số tháng KH";
		((TextBoxBase)txtso_thang_kh).BackColor = Color.White;
		txtso_thang_kh.DecimalSymbol = ".";
		txtso_thang_kh.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric35 = txtso_thang_kh;
		location = new Point(284, 8);
		((Control)asTextNumeric35).Location = location;
		txtso_thang_kh.Mask = "##";
		((Control)txtso_thang_kh).Name = "txtso_thang_kh";
		((TextBoxBase)txtso_thang_kh).ReadOnly = true;
		AsTextNumeric asTextNumeric36 = txtso_thang_kh;
		size = new Size(82, 20);
		((Control)asTextNumeric36).Size = size;
		txtso_thang_kh.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtso_thang_kh).TabIndex = 2;
		((TextBox)txtso_thang_kh).Text = "0";
		((TextBox)txtso_thang_kh).TextAlign = (HorizontalAlignment)1;
		txtso_thang_kh.Value = 0;
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)lblTong_cong1);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtT_kh_th1);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtT_gt_cl);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtT_gt_kh);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtT_ng_gia1);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)lblGT_KH_1Thang);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtkh_th_n41);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtkh_th_n31);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtkh_th_n21);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtkh_th_n11);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)lblGT_CL);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtGt_cl_n4);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtGt_cl_n3);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtGt_cl_n2);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtGt_cl_n1);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)lblGT_DA_KH);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtGt_kh_n4);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtGt_kh_n3);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtGt_kh_n2);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtGt_kh_n1);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)lblNguyen_gia1);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtNg_gia_n41);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtNg_gia_n31);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtNg_gia_n21);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)txtNg_gia_n11);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)lblNguon_von4);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)lblNguon_von3);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)lblNguon_von2);
		((Control)grbChi_Tiet_NV1).Controls.Add((Control)(object)lblNguon_von1);
		GroupBox obj93 = grbChi_Tiet_NV1;
		location = new Point(3, 126);
		((Control)obj93).Location = location;
		((Control)grbChi_Tiet_NV1).Name = "grbChi_Tiet_NV1";
		GroupBox obj94 = grbChi_Tiet_NV1;
		size = new Size(606, 176);
		((Control)obj94).Size = size;
		((Control)grbChi_Tiet_NV1).TabIndex = 44;
		grbChi_Tiet_NV1.TabStop = false;
		grbChi_Tiet_NV1.Text = "Chi tiết nguồn vốn";
		lblTong_cong1.AutoSize = true;
		((Control)lblTong_cong1).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj95 = lblTong_cong1;
		location = new Point(17, 147);
		((Control)obj95).Location = location;
		((Control)lblTong_cong1).Name = "lblTong_cong1";
		Label obj96 = lblTong_cong1;
		size = new Size(68, 13);
		((Control)obj96).Size = size;
		((Control)lblTong_cong1).TabIndex = 70;
		lblTong_cong1.Text = "Tổng cộng";
		((TextBoxBase)txtT_kh_th1).BackColor = Color.White;
		txtT_kh_th1.DecimalSymbol = ".";
		((Control)txtT_kh_th1).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_kh_th1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric37 = txtT_kh_th1;
		location = new Point(501, 144);
		((Control)asTextNumeric37).Location = location;
		txtT_kh_th1.Mask = "### ### ### ###.##";
		((Control)txtT_kh_th1).Name = "txtT_kh_th1";
		((TextBoxBase)txtT_kh_th1).ReadOnly = true;
		AsTextNumeric asTextNumeric38 = txtT_kh_th1;
		size = new Size(92, 20);
		((Control)asTextNumeric38).Size = size;
		txtT_kh_th1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_kh_th1).TabIndex = 19;
		((Control)txtT_kh_th1).Tag = "AM";
		((TextBox)txtT_kh_th1).Text = "0.00";
		((TextBox)txtT_kh_th1).TextAlign = (HorizontalAlignment)1;
		txtT_kh_th1.Value = 0;
		((TextBoxBase)txtT_gt_cl).BackColor = Color.White;
		txtT_gt_cl.DecimalSymbol = ".";
		((Control)txtT_gt_cl).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_gt_cl.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric39 = txtT_gt_cl;
		location = new Point(396, 144);
		((Control)asTextNumeric39).Location = location;
		txtT_gt_cl.Mask = "### ### ### ###.##";
		((Control)txtT_gt_cl).Name = "txtT_gt_cl";
		((TextBoxBase)txtT_gt_cl).ReadOnly = true;
		AsTextNumeric asTextNumeric40 = txtT_gt_cl;
		size = new Size(92, 20);
		((Control)asTextNumeric40).Size = size;
		txtT_gt_cl.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_gt_cl).TabIndex = 14;
		((Control)txtT_gt_cl).Tag = "AM";
		((TextBox)txtT_gt_cl).Text = "0.00";
		((TextBox)txtT_gt_cl).TextAlign = (HorizontalAlignment)1;
		txtT_gt_cl.Value = 0;
		((TextBoxBase)txtT_gt_kh).BackColor = Color.White;
		txtT_gt_kh.DecimalSymbol = ".";
		((Control)txtT_gt_kh).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_gt_kh.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric41 = txtT_gt_kh;
		location = new Point(291, 144);
		((Control)asTextNumeric41).Location = location;
		txtT_gt_kh.Mask = "### ### ### ###.##";
		((Control)txtT_gt_kh).Name = "txtT_gt_kh";
		((TextBoxBase)txtT_gt_kh).ReadOnly = true;
		AsTextNumeric asTextNumeric42 = txtT_gt_kh;
		size = new Size(92, 20);
		((Control)asTextNumeric42).Size = size;
		txtT_gt_kh.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_gt_kh).TabIndex = 9;
		((Control)txtT_gt_kh).Tag = "AM";
		((TextBox)txtT_gt_kh).Text = "0.00";
		((TextBox)txtT_gt_kh).TextAlign = (HorizontalAlignment)1;
		txtT_gt_kh.Value = 0;
		((TextBoxBase)txtT_ng_gia1).BackColor = Color.White;
		txtT_ng_gia1.DecimalSymbol = ".";
		((Control)txtT_ng_gia1).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		txtT_ng_gia1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric43 = txtT_ng_gia1;
		location = new Point(186, 144);
		((Control)asTextNumeric43).Location = location;
		txtT_ng_gia1.Mask = "### ### ### ###.##";
		((Control)txtT_ng_gia1).Name = "txtT_ng_gia1";
		((TextBoxBase)txtT_ng_gia1).ReadOnly = true;
		AsTextNumeric asTextNumeric44 = txtT_ng_gia1;
		size = new Size(92, 20);
		((Control)asTextNumeric44).Size = size;
		txtT_ng_gia1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_ng_gia1).TabIndex = 4;
		((Control)txtT_ng_gia1).Tag = "AM";
		((TextBox)txtT_ng_gia1).Text = "0.00";
		((TextBox)txtT_ng_gia1).TextAlign = (HorizontalAlignment)1;
		txtT_ng_gia1.Value = 0;
		lblGT_KH_1Thang.AutoSize = true;
		Label obj97 = lblGT_KH_1Thang;
		location = new Point(498, 22);
		((Control)obj97).Location = location;
		((Control)lblGT_KH_1Thang).Name = "lblGT_KH_1Thang";
		Label obj98 = lblGT_KH_1Thang;
		size = new Size(91, 13);
		((Control)obj98).Size = size;
		((Control)lblGT_KH_1Thang).TabIndex = 65;
		lblGT_KH_1Thang.Text = "Giá trị KH 1 tháng";
		((TextBoxBase)txtkh_th_n41).BackColor = Color.White;
		txtkh_th_n41.DecimalSymbol = ".";
		txtkh_th_n41.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric45 = txtkh_th_n41;
		location = new Point(501, 118);
		((Control)asTextNumeric45).Location = location;
		txtkh_th_n41.Mask = "### ### ### ###.##";
		((Control)txtkh_th_n41).Name = "txtkh_th_n41";
		((TextBoxBase)txtkh_th_n41).ReadOnly = true;
		AsTextNumeric asTextNumeric46 = txtkh_th_n41;
		size = new Size(92, 20);
		((Control)asTextNumeric46).Size = size;
		txtkh_th_n41.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtkh_th_n41).TabIndex = 18;
		((Control)txtkh_th_n41).Tag = "AM";
		((TextBox)txtkh_th_n41).Text = "0.00";
		((TextBox)txtkh_th_n41).TextAlign = (HorizontalAlignment)1;
		txtkh_th_n41.Value = 0;
		((TextBoxBase)txtkh_th_n31).BackColor = Color.White;
		txtkh_th_n31.DecimalSymbol = ".";
		txtkh_th_n31.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric47 = txtkh_th_n31;
		location = new Point(501, 92);
		((Control)asTextNumeric47).Location = location;
		txtkh_th_n31.Mask = "### ### ### ###.##";
		((Control)txtkh_th_n31).Name = "txtkh_th_n31";
		((TextBoxBase)txtkh_th_n31).ReadOnly = true;
		AsTextNumeric asTextNumeric48 = txtkh_th_n31;
		size = new Size(92, 20);
		((Control)asTextNumeric48).Size = size;
		txtkh_th_n31.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtkh_th_n31).TabIndex = 17;
		((Control)txtkh_th_n31).Tag = "AM";
		((TextBox)txtkh_th_n31).Text = "0.00";
		((TextBox)txtkh_th_n31).TextAlign = (HorizontalAlignment)1;
		txtkh_th_n31.Value = 0;
		((TextBoxBase)txtkh_th_n21).BackColor = Color.White;
		txtkh_th_n21.DecimalSymbol = ".";
		txtkh_th_n21.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric49 = txtkh_th_n21;
		location = new Point(501, 66);
		((Control)asTextNumeric49).Location = location;
		txtkh_th_n21.Mask = "### ### ### ###.##";
		((Control)txtkh_th_n21).Name = "txtkh_th_n21";
		((TextBoxBase)txtkh_th_n21).ReadOnly = true;
		AsTextNumeric asTextNumeric50 = txtkh_th_n21;
		size = new Size(92, 20);
		((Control)asTextNumeric50).Size = size;
		txtkh_th_n21.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtkh_th_n21).TabIndex = 16;
		((Control)txtkh_th_n21).Tag = "AM";
		((TextBox)txtkh_th_n21).Text = "0.00";
		((TextBox)txtkh_th_n21).TextAlign = (HorizontalAlignment)1;
		txtkh_th_n21.Value = 0;
		((TextBoxBase)txtkh_th_n11).BackColor = Color.White;
		txtkh_th_n11.DecimalSymbol = ".";
		txtkh_th_n11.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric51 = txtkh_th_n11;
		location = new Point(501, 40);
		((Control)asTextNumeric51).Location = location;
		txtkh_th_n11.Mask = "### ### ### ###.##";
		((Control)txtkh_th_n11).Name = "txtkh_th_n11";
		((TextBoxBase)txtkh_th_n11).ReadOnly = true;
		AsTextNumeric asTextNumeric52 = txtkh_th_n11;
		size = new Size(92, 20);
		((Control)asTextNumeric52).Size = size;
		txtkh_th_n11.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtkh_th_n11).TabIndex = 15;
		((Control)txtkh_th_n11).Tag = "AM";
		((TextBox)txtkh_th_n11).Text = "0.00";
		((TextBox)txtkh_th_n11).TextAlign = (HorizontalAlignment)1;
		txtkh_th_n11.Value = 0;
		lblGT_CL.AutoSize = true;
		Label obj99 = lblGT_CL;
		location = new Point(393, 22);
		((Control)obj99).Location = location;
		((Control)lblGT_CL).Name = "lblGT_CL";
		Label obj100 = lblGT_CL;
		size = new Size(68, 13);
		((Control)obj100).Size = size;
		((Control)lblGT_CL).TabIndex = 60;
		lblGT_CL.Text = "Giá trị còn lại";
		((TextBoxBase)txtGt_cl_n4).BackColor = Color.White;
		txtGt_cl_n4.DecimalSymbol = ".";
		txtGt_cl_n4.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric53 = txtGt_cl_n4;
		location = new Point(396, 118);
		((Control)asTextNumeric53).Location = location;
		txtGt_cl_n4.Mask = "### ### ### ###.##";
		((Control)txtGt_cl_n4).Name = "txtGt_cl_n4";
		((TextBoxBase)txtGt_cl_n4).ReadOnly = true;
		AsTextNumeric asTextNumeric54 = txtGt_cl_n4;
		size = new Size(92, 20);
		((Control)asTextNumeric54).Size = size;
		txtGt_cl_n4.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_cl_n4).TabIndex = 13;
		((Control)txtGt_cl_n4).Tag = "AM";
		((TextBox)txtGt_cl_n4).Text = "0.00";
		((TextBox)txtGt_cl_n4).TextAlign = (HorizontalAlignment)1;
		txtGt_cl_n4.Value = 0;
		((TextBoxBase)txtGt_cl_n3).BackColor = Color.White;
		txtGt_cl_n3.DecimalSymbol = ".";
		txtGt_cl_n3.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric55 = txtGt_cl_n3;
		location = new Point(396, 92);
		((Control)asTextNumeric55).Location = location;
		txtGt_cl_n3.Mask = "### ### ### ###.##";
		((Control)txtGt_cl_n3).Name = "txtGt_cl_n3";
		((TextBoxBase)txtGt_cl_n3).ReadOnly = true;
		AsTextNumeric asTextNumeric56 = txtGt_cl_n3;
		size = new Size(92, 20);
		((Control)asTextNumeric56).Size = size;
		txtGt_cl_n3.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_cl_n3).TabIndex = 12;
		((Control)txtGt_cl_n3).Tag = "AM";
		((TextBox)txtGt_cl_n3).Text = "0.00";
		((TextBox)txtGt_cl_n3).TextAlign = (HorizontalAlignment)1;
		txtGt_cl_n3.Value = 0;
		((TextBoxBase)txtGt_cl_n2).BackColor = Color.White;
		txtGt_cl_n2.DecimalSymbol = ".";
		txtGt_cl_n2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric57 = txtGt_cl_n2;
		location = new Point(396, 66);
		((Control)asTextNumeric57).Location = location;
		txtGt_cl_n2.Mask = "### ### ### ###.##";
		((Control)txtGt_cl_n2).Name = "txtGt_cl_n2";
		((TextBoxBase)txtGt_cl_n2).ReadOnly = true;
		AsTextNumeric asTextNumeric58 = txtGt_cl_n2;
		size = new Size(92, 20);
		((Control)asTextNumeric58).Size = size;
		txtGt_cl_n2.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_cl_n2).TabIndex = 11;
		((Control)txtGt_cl_n2).Tag = "AM";
		((TextBox)txtGt_cl_n2).Text = "0.00";
		((TextBox)txtGt_cl_n2).TextAlign = (HorizontalAlignment)1;
		txtGt_cl_n2.Value = 0;
		((TextBoxBase)txtGt_cl_n1).BackColor = Color.White;
		txtGt_cl_n1.DecimalSymbol = ".";
		txtGt_cl_n1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric59 = txtGt_cl_n1;
		location = new Point(396, 40);
		((Control)asTextNumeric59).Location = location;
		txtGt_cl_n1.Mask = "### ### ### ###.##";
		((Control)txtGt_cl_n1).Name = "txtGt_cl_n1";
		((TextBoxBase)txtGt_cl_n1).ReadOnly = true;
		AsTextNumeric asTextNumeric60 = txtGt_cl_n1;
		size = new Size(92, 20);
		((Control)asTextNumeric60).Size = size;
		txtGt_cl_n1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_cl_n1).TabIndex = 10;
		((Control)txtGt_cl_n1).Tag = "AM";
		((TextBox)txtGt_cl_n1).Text = "0.00";
		((TextBox)txtGt_cl_n1).TextAlign = (HorizontalAlignment)1;
		txtGt_cl_n1.Value = 0;
		lblGT_DA_KH.AutoSize = true;
		Label obj101 = lblGT_DA_KH;
		location = new Point(288, 22);
		((Control)obj101).Location = location;
		((Control)lblGT_DA_KH).Name = "lblGT_DA_KH";
		Label obj102 = lblGT_DA_KH;
		size = new Size(68, 13);
		((Control)obj102).Size = size;
		((Control)lblGT_DA_KH).TabIndex = 55;
		lblGT_DA_KH.Text = "Giá trị đã KH";
		((TextBoxBase)txtGt_kh_n4).BackColor = Color.White;
		txtGt_kh_n4.DecimalSymbol = ".";
		txtGt_kh_n4.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric61 = txtGt_kh_n4;
		location = new Point(291, 118);
		((Control)asTextNumeric61).Location = location;
		txtGt_kh_n4.Mask = "### ### ### ###.##";
		((Control)txtGt_kh_n4).Name = "txtGt_kh_n4";
		((TextBoxBase)txtGt_kh_n4).ReadOnly = true;
		AsTextNumeric asTextNumeric62 = txtGt_kh_n4;
		size = new Size(92, 20);
		((Control)asTextNumeric62).Size = size;
		txtGt_kh_n4.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_kh_n4).TabIndex = 8;
		((Control)txtGt_kh_n4).Tag = "AM";
		((TextBox)txtGt_kh_n4).Text = "0.00";
		((TextBox)txtGt_kh_n4).TextAlign = (HorizontalAlignment)1;
		txtGt_kh_n4.Value = 0;
		((TextBoxBase)txtGt_kh_n3).BackColor = Color.White;
		txtGt_kh_n3.DecimalSymbol = ".";
		txtGt_kh_n3.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric63 = txtGt_kh_n3;
		location = new Point(291, 92);
		((Control)asTextNumeric63).Location = location;
		txtGt_kh_n3.Mask = "### ### ### ###.##";
		((Control)txtGt_kh_n3).Name = "txtGt_kh_n3";
		((TextBoxBase)txtGt_kh_n3).ReadOnly = true;
		AsTextNumeric asTextNumeric64 = txtGt_kh_n3;
		size = new Size(92, 20);
		((Control)asTextNumeric64).Size = size;
		txtGt_kh_n3.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_kh_n3).TabIndex = 7;
		((Control)txtGt_kh_n3).Tag = "AM";
		((TextBox)txtGt_kh_n3).Text = "0.00";
		((TextBox)txtGt_kh_n3).TextAlign = (HorizontalAlignment)1;
		txtGt_kh_n3.Value = 0;
		((TextBoxBase)txtGt_kh_n2).BackColor = Color.White;
		txtGt_kh_n2.DecimalSymbol = ".";
		txtGt_kh_n2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric65 = txtGt_kh_n2;
		location = new Point(291, 66);
		((Control)asTextNumeric65).Location = location;
		txtGt_kh_n2.Mask = "### ### ### ###.##";
		((Control)txtGt_kh_n2).Name = "txtGt_kh_n2";
		((TextBoxBase)txtGt_kh_n2).ReadOnly = true;
		AsTextNumeric asTextNumeric66 = txtGt_kh_n2;
		size = new Size(92, 20);
		((Control)asTextNumeric66).Size = size;
		txtGt_kh_n2.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_kh_n2).TabIndex = 6;
		((Control)txtGt_kh_n2).Tag = "AM";
		((TextBox)txtGt_kh_n2).Text = "0.00";
		((TextBox)txtGt_kh_n2).TextAlign = (HorizontalAlignment)1;
		txtGt_kh_n2.Value = 0;
		((TextBoxBase)txtGt_kh_n1).BackColor = Color.White;
		txtGt_kh_n1.DecimalSymbol = ".";
		txtGt_kh_n1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric67 = txtGt_kh_n1;
		location = new Point(291, 40);
		((Control)asTextNumeric67).Location = location;
		txtGt_kh_n1.Mask = "### ### ### ###.##";
		((Control)txtGt_kh_n1).Name = "txtGt_kh_n1";
		((TextBoxBase)txtGt_kh_n1).ReadOnly = true;
		AsTextNumeric asTextNumeric68 = txtGt_kh_n1;
		size = new Size(92, 20);
		((Control)asTextNumeric68).Size = size;
		txtGt_kh_n1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGt_kh_n1).TabIndex = 5;
		((Control)txtGt_kh_n1).Tag = "AM";
		((TextBox)txtGt_kh_n1).Text = "0.00";
		((TextBox)txtGt_kh_n1).TextAlign = (HorizontalAlignment)1;
		txtGt_kh_n1.Value = 0;
		lblNguyen_gia1.AutoSize = true;
		Label obj103 = lblNguyen_gia1;
		location = new Point(183, 22);
		((Control)obj103).Location = location;
		((Control)lblNguyen_gia1).Name = "lblNguyen_gia1";
		Label obj104 = lblNguyen_gia1;
		size = new Size(61, 13);
		((Control)obj104).Size = size;
		((Control)lblNguyen_gia1).TabIndex = 50;
		lblNguyen_gia1.Text = "Nguyên giá";
		((TextBoxBase)txtNg_gia_n41).BackColor = Color.White;
		txtNg_gia_n41.DecimalSymbol = ".";
		txtNg_gia_n41.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric69 = txtNg_gia_n41;
		location = new Point(186, 118);
		((Control)asTextNumeric69).Location = location;
		txtNg_gia_n41.Mask = "### ### ### ###.##";
		((Control)txtNg_gia_n41).Name = "txtNg_gia_n41";
		((TextBoxBase)txtNg_gia_n41).ReadOnly = true;
		AsTextNumeric asTextNumeric70 = txtNg_gia_n41;
		size = new Size(92, 20);
		((Control)asTextNumeric70).Size = size;
		txtNg_gia_n41.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNg_gia_n41).TabIndex = 3;
		((Control)txtNg_gia_n41).Tag = "AM";
		((TextBox)txtNg_gia_n41).Text = "0.00";
		((TextBox)txtNg_gia_n41).TextAlign = (HorizontalAlignment)1;
		txtNg_gia_n41.Value = 0;
		((TextBoxBase)txtNg_gia_n31).BackColor = Color.White;
		txtNg_gia_n31.DecimalSymbol = ".";
		txtNg_gia_n31.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric71 = txtNg_gia_n31;
		location = new Point(186, 92);
		((Control)asTextNumeric71).Location = location;
		txtNg_gia_n31.Mask = "### ### ### ###.##";
		((Control)txtNg_gia_n31).Name = "txtNg_gia_n31";
		((TextBoxBase)txtNg_gia_n31).ReadOnly = true;
		AsTextNumeric asTextNumeric72 = txtNg_gia_n31;
		size = new Size(92, 20);
		((Control)asTextNumeric72).Size = size;
		txtNg_gia_n31.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNg_gia_n31).TabIndex = 2;
		((Control)txtNg_gia_n31).Tag = "AM";
		((TextBox)txtNg_gia_n31).Text = "0.00";
		((TextBox)txtNg_gia_n31).TextAlign = (HorizontalAlignment)1;
		txtNg_gia_n31.Value = 0;
		((TextBoxBase)txtNg_gia_n21).BackColor = Color.White;
		txtNg_gia_n21.DecimalSymbol = ".";
		txtNg_gia_n21.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric73 = txtNg_gia_n21;
		location = new Point(186, 66);
		((Control)asTextNumeric73).Location = location;
		txtNg_gia_n21.Mask = "### ### ### ###.##";
		((Control)txtNg_gia_n21).Name = "txtNg_gia_n21";
		((TextBoxBase)txtNg_gia_n21).ReadOnly = true;
		AsTextNumeric asTextNumeric74 = txtNg_gia_n21;
		size = new Size(92, 20);
		((Control)asTextNumeric74).Size = size;
		txtNg_gia_n21.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNg_gia_n21).TabIndex = 1;
		((Control)txtNg_gia_n21).Tag = "AM";
		((TextBox)txtNg_gia_n21).Text = "0.00";
		((TextBox)txtNg_gia_n21).TextAlign = (HorizontalAlignment)1;
		txtNg_gia_n21.Value = 0;
		((TextBoxBase)txtNg_gia_n11).BackColor = Color.White;
		txtNg_gia_n11.DecimalSymbol = ".";
		txtNg_gia_n11.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric75 = txtNg_gia_n11;
		location = new Point(186, 40);
		((Control)asTextNumeric75).Location = location;
		txtNg_gia_n11.Mask = "### ### ### ###.##";
		((Control)txtNg_gia_n11).Name = "txtNg_gia_n11";
		((TextBoxBase)txtNg_gia_n11).ReadOnly = true;
		AsTextNumeric asTextNumeric76 = txtNg_gia_n11;
		size = new Size(92, 20);
		((Control)asTextNumeric76).Size = size;
		txtNg_gia_n11.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNg_gia_n11).TabIndex = 0;
		((Control)txtNg_gia_n11).Tag = "AM";
		((TextBox)txtNg_gia_n11).Text = "0.00";
		((TextBox)txtNg_gia_n11).TextAlign = (HorizontalAlignment)1;
		txtNg_gia_n11.Value = 0;
		lblNguon_von4.AutoSize = true;
		Label obj105 = lblNguon_von4;
		location = new Point(17, 121);
		((Control)obj105).Location = location;
		((Control)lblNguon_von4).Name = "lblNguon_von4";
		Label obj106 = lblNguon_von4;
		size = new Size(0, 13);
		((Control)obj106).Size = size;
		((Control)lblNguon_von4).TabIndex = 45;
		lblNguon_von3.AutoSize = true;
		Label obj107 = lblNguon_von3;
		location = new Point(17, 95);
		((Control)obj107).Location = location;
		((Control)lblNguon_von3).Name = "lblNguon_von3";
		Label obj108 = lblNguon_von3;
		size = new Size(0, 13);
		((Control)obj108).Size = size;
		((Control)lblNguon_von3).TabIndex = 44;
		lblNguon_von2.AutoSize = true;
		Label obj109 = lblNguon_von2;
		location = new Point(17, 69);
		((Control)obj109).Location = location;
		((Control)lblNguon_von2).Name = "lblNguon_von2";
		Label obj110 = lblNguon_von2;
		size = new Size(0, 13);
		((Control)obj110).Size = size;
		((Control)lblNguon_von2).TabIndex = 43;
		lblNguon_von1.AutoSize = true;
		Label obj111 = lblNguon_von1;
		location = new Point(17, 43);
		((Control)obj111).Location = location;
		((Control)lblNguon_von1).Name = "lblNguon_von1";
		Label obj112 = lblNguon_von1;
		size = new Size(0, 13);
		((Control)obj112).Size = size;
		((Control)lblNguon_von1).TabIndex = 42;
		lblTK_CP.AutoSize = true;
		Label obj113 = lblTK_CP;
		location = new Point(406, 64);
		((Control)obj113).Location = location;
		((Control)lblTK_CP).Name = "lblTK_CP";
		Label obj114 = lblTK_CP;
		size = new Size(91, 13);
		((Control)obj114).Size = size;
		((Control)lblTK_CP).TabIndex = 43;
		lblTK_CP.Text = "Tài khoản chi phí";
		lblTK_KH.AutoSize = true;
		Label obj115 = lblTK_KH;
		location = new Point(406, 38);
		((Control)obj115).Location = location;
		((Control)lblTK_KH).Name = "lblTK_KH";
		Label obj116 = lblTK_KH;
		size = new Size(103, 13);
		((Control)obj116).Size = size;
		((Control)lblTK_KH).TabIndex = 41;
		lblTK_KH.Text = "Tài khoản khấu hao";
		lblTK_TS.AutoSize = true;
		Label obj117 = lblTK_TS;
		location = new Point(406, 12);
		((Control)obj117).Location = location;
		((Control)lblTK_TS).Name = "lblTK_TS";
		Label obj118 = lblTK_TS;
		size = new Size(89, 13);
		((Control)obj118).Size = size;
		((Control)lblTK_TS).TabIndex = 39;
		lblTK_TS.Text = "Tài khoản tài sản";
		lblKieu_DG.AutoSize = true;
		Label obj119 = lblKieu_DG;
		location = new Point(15, 40);
		((Control)obj119).Location = location;
		((Control)lblKieu_DG).Name = "lblKieu_DG";
		Label obj120 = lblKieu_DG;
		size = new Size(73, 13);
		((Control)obj120).Size = size;
		((Control)lblKieu_DG).TabIndex = 20;
		lblKieu_DG.Text = "Kiểu đánh giá";
		lblMa_dg.AutoSize = true;
		Label obj121 = lblMa_dg;
		location = new Point(15, 65);
		((Control)obj121).Location = location;
		((Control)lblMa_dg).Name = "lblMa_dg";
		Label obj122 = lblMa_dg;
		size = new Size(67, 13);
		((Control)obj122).Size = size;
		((Control)lblMa_dg).TabIndex = 22;
		lblMa_dg.Text = "Mã đánh giá";
		txtma_ts_tgng.CharacterCasing = (CharacterCasing)1;
		TextBox obj123 = txtma_ts_tgng;
		location = new Point(94, 61);
		((Control)obj123).Location = location;
		((Control)txtma_ts_tgng).Name = "txtma_ts_tgng";
		TextBox obj124 = txtma_ts_tgng;
		size = new Size(100, 20);
		((Control)obj124).Size = size;
		((Control)txtma_ts_tgng).TabIndex = 2;
		((ButtonBase)chkTang_giam).AutoSize = true;
		chkTang_giam.Checked = false;
		AsCheckBox asCheckBox9 = chkTang_giam;
		location = new Point(261, 36);
		((Control)asCheckBox9).Location = location;
		((Control)chkTang_giam).Name = "chkTang_giam";
		AsCheckBox asCheckBox10 = chkTang_giam;
		size = new Size(141, 17);
		((Control)asCheckBox10).Size = size;
		((Control)chkTang_giam).TabIndex = 1;
		((ButtonBase)chkTang_giam).Text = "Tăng / Giảm nguyên giá";
		chkTang_giam.TextValue = "0";
		((ButtonBase)chkTang_giam).UseVisualStyleBackColor = true;
		((Control)chkTang_giam).Visible = false;
		txtMa_ts.AutoLookup = true;
		txtMa_ts.AutoValid = true;
		((TextBoxBase)txtMa_ts).BackColor = SystemColors.Info;
		((TextBox)txtMa_ts).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_ts;
		location = new Point(93, 12);
		((Control)asTextBox3).Location = location;
		txtMa_ts.LookupCodeName = "MA_TS";
		((Control)txtMa_ts).Name = "txtMa_ts";
		txtMa_ts.NameControl = lblTen_TS;
		AsTextBox asTextBox4 = txtMa_ts;
		size = new Size(101, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_ts).TabIndex = 0;
		((Control)txtMa_ts).Tag = "MA_TS";
		txtMa_ts.UseAutoCompleteSource = true;
		txtMa_ts.ValidReturnFieldList = componentResourceManager.GetString("txtMa_ts.ValidReturnFieldList");
		Label obj125 = lblTen_TS;
		location = new Point(199, 16);
		((Control)obj125).Location = location;
		((Control)lblTen_TS).Name = "lblTen_TS";
		Label obj126 = lblTen_TS;
		size = new Size(405, 13);
		((Control)obj126).Size = size;
		((Control)lblTen_TS).TabIndex = 54;
		((Control)Panel1).Controls.Add((Control)(object)rbbGiam);
		((Control)Panel1).Controls.Add((Control)(object)rbbTang);
		Panel panel = Panel1;
		location = new Point(93, 36);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(151, 24);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 1;
		((ButtonBase)rbbGiam).AutoSize = true;
		RadioButton obj127 = rbbGiam;
		location = new Point(79, 3);
		((Control)obj127).Location = location;
		((Control)rbbGiam).Name = "rbbGiam";
		RadioButton obj128 = rbbGiam;
		size = new Size(66, 17);
		((Control)obj128).Size = size;
		((Control)rbbGiam).TabIndex = 1;
		rbbGiam.TabStop = true;
		((ButtonBase)rbbGiam).Text = "Giảm TS";
		((ButtonBase)rbbGiam).UseVisualStyleBackColor = true;
		((ButtonBase)rbbTang).AutoSize = true;
		RadioButton obj129 = rbbTang;
		location = new Point(6, 3);
		((Control)obj129).Location = location;
		((Control)rbbTang).Name = "rbbTang";
		RadioButton obj130 = rbbTang;
		size = new Size(67, 17);
		((Control)obj130).Size = size;
		((Control)rbbTang).TabIndex = 0;
		((ButtonBase)rbbTang).Text = "Tăng TS";
		((ButtonBase)rbbTang).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(626, 466);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)lblTen_TS);
		((Control)this).Controls.Add((Control)(object)txtMa_ts);
		((Control)this).Controls.Add((Control)(object)lblMa_dg);
		((Control)this).Controls.Add((Control)(object)txtma_ts_tgng);
		((Control)this).Controls.Add((Control)(object)TabCtlTai_san);
		((Control)this).Controls.Add((Control)(object)lblKieu_DG);
		((Control)this).Controls.Add((Control)(object)lblMa_ts);
		((Control)this).Controls.Add((Control)(object)lblDien_giai);
		((Control)this).Controls.Add((Control)(object)txtdien_giai);
		((Control)this).Controls.Add((Control)(object)chkTang_giam);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Name = "frmFADGTSEdit";
		((Control)this).Controls.SetChildIndex((Control)(object)Panel1, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkTang_giam, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtdien_giai, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblDien_giai, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblMa_ts, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblKieu_DG, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)TabCtlTai_san, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtma_ts_tgng, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblMa_dg, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtMa_ts, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen_TS, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbLine, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSave, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)TabCtlTai_san).ResumeLayout(false);
		((Control)tabTTDG).ResumeLayout(false);
		((Control)tabTTDG).PerformLayout();
		((Control)grbChi_Tiet_NV).ResumeLayout(false);
		((Control)grbChi_Tiet_NV).PerformLayout();
		((Control)tabPT_LK).ResumeLayout(false);
		((Control)tabPT_LK).PerformLayout();
		((ISupportInitialize)dgvLinh_kien).EndInit();
		((Control)tabTTKH).ResumeLayout(false);
		((Control)tabTTKH).PerformLayout();
		((Control)grbChi_Tiet_NV1).ResumeLayout(false);
		((Control)grbChi_Tiet_NV1).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitAfterGetData()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		base.InitAfterGetData();
		MaskTextBoxAll(((Control)grbChi_Tiet_NV).Controls);
		MaskTextBoxAll(((Control)grbChi_Tiet_NV1).Controls);
		if (Operators.CompareString(((TextBox)txtMa_ts).Text.Trim(), "", false) != 0)
		{
			txtMa_ts.ForcedValid();
		}
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
		MyInit();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_ts).Enabled = false;
		((Control)txtma_ts_tgng).Enabled = false;
		((Control)txtdien_giai).Select();
	}

	protected override void DataBinding()
	{
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
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_ts;
		CreateDataBinding(ref ojb, "ma_ts");
		txtMa_ts = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_TS;
		CreateDataBinding(ref ojb, "ten_ts");
		lblTen_TS = (Label)ojb;
		ojb = (Control)(object)txtma_ts_tgng;
		CreateDataBinding(ref ojb, "ma_ts_tgng");
		txtma_ts_tgng = (TextBox)ojb;
		ojb = (Control)(object)txtdien_giai;
		CreateDataBinding(ref ojb, "dien_giai");
		txtdien_giai = (TextBox)ojb;
		ojb = (Control)(object)rbbTang;
		CreateDataBinding(ref ojb, "tang_giam", "Checked");
		rbbTang = (RadioButton)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "So_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)txtNgay_ct;
		CreateDataBinding(ref ojb, "Ngay_ct", "Value");
		txtNgay_ct = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtngay_tg;
		CreateDataBinding(ref ojb, "ngay_tg", "Value");
		txtngay_tg = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtMA_LDTG;
		CreateDataBinding(ref ojb, "ma_ldtg");
		txtMA_LDTG = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_luong;
		CreateDataBinding(ref ojb, "so_luong", "Value");
		txtSo_luong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtNgay_bdkh;
		CreateDataBinding(ref ojb, "ngay_bdkh", "Value");
		txtNgay_bdkh = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_gt_cl;
		CreateDataBinding(ref ojb, "ngay_gt_cl", "Value");
		txtNgay_gt_cl = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtSt_kh;
		CreateDataBinding(ref ojb, "st_kh", "Value");
		txtSt_kh = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTl_kh;
		CreateDataBinding(ref ojb, "Tl_kh", "Value");
		txtTl_kh = (AsTextNumeric)(object)ojb;
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
		if (!rbbTang.Checked)
		{
			((Control)rbbGiam).Select();
		}
		rbbTang_CheckedChanged(null, null);
	}

	protected override bool ValidData()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
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
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_ts))
		{
			return false;
		}
		if (!ChkEmtyTextBox(txtma_ts_tgng))
		{
			return false;
		}
		int num = CheckDgtsSauGiamTS(((TextBox)txtMa_ts).Text, Conversions.ToDate(txtNgay_ct.Value));
		if (num != 0)
		{
			CMessageBox.Show(num);
			((Control)txtNgay_ct).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectEqual(txtNgay_tang.Value, (object)"#1/1/1900#", false))
		{
			SetControlError((Control)(object)txtNgay_tang, Helper.GetMessContent(50002));
			((TabControl)TabCtlTai_san).SelectedTab = tabTTDG;
			((Control)txtNgay_tang).Select();
		}
		if (Operators.ConditionalCompareObjectEqual(txtNgay_bdkh.Value, (object)"#1/1/1900#", false))
		{
			SetControlError((Control)(object)txtNgay_bdkh, Helper.GetMessContent(50002));
			((TabControl)TabCtlTai_san).SelectedTab = tabTTDG;
			((Control)txtNgay_bdkh).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectEqual(txtNgay_gt_cl.Value, (object)"#1/1/1900#", false))
		{
			SetControlError((Control)(object)txtNgay_gt_cl, Helper.GetMessContent(50002));
			((TabControl)TabCtlTai_san).SelectedTab = tabTTDG;
			return false;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtMA_LDTG))
		{
			((TabControl)TabCtlTai_san).SelectedTab = tabTTDG;
			((Control)txtMA_LDTG).Select();
			return false;
		}
		if ((Operators.ConditionalCompareObjectLess(txtNgay_gt_cl.Value, txtNgay_bdkh.Value, false) || Operators.ConditionalCompareObjectLess(txtNgay_bdkh.Value, txtNgay_tang.Value, false) || Operators.ConditionalCompareObjectLess(txtNgay_gt_cl.Value, txtNgay_tang.Value, false)) ? true : false)
		{
			CMessageBox.Show(50144);
			((TabControl)TabCtlTai_san).SelectedTab = tabTTDG;
			return false;
		}
		if (Operators.ConditionalCompareObjectLessEqual(txtSt_kh.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtSt_kh, Helper.GetMessContent(50034));
			((Control)txtSt_kh).Select();
			return false;
		}
		if (Conversions.ToBoolean((!Conversions.ToBoolean(Operators.NotObject(chkTinh_kh.Checked)) || !Conversions.ToBoolean((object)Operators.ConditionalCompareObjectLessEqual(txtNg_gia_n1.Value, (object)0, false)) || !Conversions.ToBoolean((object)Operators.ConditionalCompareObjectLessEqual(txtNg_gia_n2.Value, (object)0, false)) || !Conversions.ToBoolean((object)Operators.ConditionalCompareObjectLessEqual(txtNg_gia_n3.Value, (object)0, false)) || !Conversions.ToBoolean((object)Operators.ConditionalCompareObjectLessEqual(txtNg_gia_n4.Value, (object)0, false))) ? ((object)false) : ((object)true)))
		{
			CMessageBox.Show(50145);
			return false;
		}
		DataRow[] array = f_oTblLK.Select("", "", DataViewRowState.Added);
		foreach (DataRow dataRow in array)
		{
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ma_lk"]), isNum: false), (object)((TextBox)txtMa_ts).Text.Trim(), false))
			{
				CMessageBox.Show(50123);
				return false;
			}
		}
		return (Commons.ChkEmtyTextBoxAndShowMessageBox((TextBox)(object)txtMA_LDTG) && base.ValidData()) ? true : false;
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
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
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
				CMessageBox.Show(ex2.ToString());
				result = false;
				ProjectData.ClearProjectError();
				break;
			}
			result = true;
			break;
		}
		return result;
	}

	protected override bool SetToRow()
	{
		RowToEdit["ten_ts"] = lblTen_TS.Text;
		RowToEdit["ldate"] = DateTime.Now;
		return base.SetToRow();
	}

	private void MyInit()
	{
		InitTabPTLK();
		InittabTTKH();
	}

	private void InittabTTKH()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = Commons.FAGetTenNguonVon(CompanyInformations.CompanyID);
		if (dataTable.Rows.Count == 0)
		{
			CMessageBox.Show(My.MySettingsProperty.Settings.NG_VON);
			((Form)this).Close();
		}
		lblng_von1.Text = Conversions.ToString(dataTable.Rows[0]["ten_nv"]);
		lblng_von2.Text = Conversions.ToString(dataTable.Rows[1]["ten_nv"]);
		lblng_von3.Text = Conversions.ToString(dataTable.Rows[2]["ten_nv"]);
		lblng_von4.Text = Conversions.ToString(dataTable.Rows[3]["ten_nv"]);
		lblNguon_von1.Text = lblng_von1.Text;
		lblNguon_von2.Text = lblng_von2.Text;
		lblNguon_von3.Text = lblng_von3.Text;
		lblNguon_von4.Text = lblng_von4.Text;
		if (!EditMode)
		{
			return;
		}
		dataTable = Commons.GetDataTable("asFaGetDmTs", CompanyInformations.CompanyID);
		if (!Operators.ConditionalCompareObjectEqual(dataTable.Compute("count(ma_ts)", "ma_ts='" + ((TextBox)txtMa_ts).Text + "'"), (object)0, false))
		{
			txtMa_ts_AfterCodeValidating(null, new AfterCodeValidatingCancelEventArgs(dataTable.Select("ma_ts='" + ((TextBox)txtMa_ts).Text + "'")[0]));
			dataTable = Commons.GetDataTable("asFAGetDmLDTG", CompanyInformations.CompanyID);
			if (!Operators.ConditionalCompareObjectEqual(dataTable.Compute("count(ma_ldtg)", "ma_ldtg='" + ((TextBox)txtMA_LDTG).Text + "'"), (object)0, false))
			{
				txtMA_LDTG_AfterCodeValidating(null, new AfterCodeValidatingCancelEventArgs(dataTable.Select("ma_ldtg='" + ((TextBox)txtMA_LDTG).Text + "'")[0]));
			}
		}
	}

	private void InitTabPTLK()
	{
		f_oTblLK = LKController.GetData(CompanyInformations.CompanyID, RuntimeHelpers.GetObjectValue(RowToEdit["ma_ts_tgng"]));
		((DataGridView)dgvLinh_kien).DataSource = f_oTblLK.DefaultView;
	}

	private void cmdAdd_lk_Click(object sender, EventArgs e)
	{
		if (ValidLinhKien())
		{
			DataRow dataRow = f_oTblLK.NewRow();
			if (EditMode)
			{
				dataRow["ma_ts"] = RuntimeHelpers.GetObjectValue(RowToEdit["ma_ts_tgng"]);
			}
			else
			{
				dataRow["ma_ts"] = txtma_ts_tgng.Text.Trim();
			}
			dataRow["ma_cty"] = CompanyInformations.CompanyID;
			dataRow["ma_lk"] = txtMa_Lk.Text;
			dataRow["ten_lk"] = txtTen_lk.Text;
			dataRow["dvt"] = txtDvt_Lk.Text;
			dataRow["so_luong"] = RuntimeHelpers.GetObjectValue(txtSo_luonglk.Value);
			dataRow["gia_tri"] = RuntimeHelpers.GetObjectValue(txtGia_tri.Value);
			dataRow["Tg"] = RuntimeHelpers.GetObjectValue(chkTG.Checked);
			f_oTblLK.Rows.Add(dataRow);
			txtMa_Lk.Text = "";
			txtTen_lk.Text = "";
			txtDvt_Lk.Text = "";
			txtSo_luonglk.Value = 0;
			txtGia_tri.Value = 0;
			chkTG.Checked = false;
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

	private void chkSua_kh_CheckedChanged(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(chkSua_kh.Checked))
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

	private void txtNg_gia_n4_Validated(object sender, EventArgs e)
	{
		txtT_ng_gia.Value = Operators.AddObject(Operators.AddObject(Operators.AddObject(txtNg_gia_n1.Value, txtNg_gia_n2.Value), txtNg_gia_n3.Value), txtNg_gia_n4.Value);
		if (Operators.ConditionalCompareObjectGreater(txtSt_kh.Value, (object)0, false))
		{
			Tinh_kh_thang();
		}
	}

	private void txtSt_kh_Validated(object sender, EventArgs e)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Operators.ConditionalCompareObjectEqual(txtSt_kh.Value, (object)0, false))
			{
				txtNgay_gt_cl_Validated(null, null);
			}
			if (Operators.ConditionalCompareObjectGreater(txtSt_kh.Value, (object)0, false))
			{
				txtTl_kh.Value = Operators.DivideObject((object)1, txtSt_kh.Value);
				Tinh_kh_thang();
			}
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

	private void Tinh_kh_thang()
	{
		txtkh_th_n1.Value = Operators.DivideObject(txtNg_gia_n1.Value, txtSt_kh.Value);
		txtkh_th_n2.Value = Operators.DivideObject(txtNg_gia_n2.Value, txtSt_kh.Value);
		txtkh_th_n3.Value = Operators.DivideObject(txtNg_gia_n3.Value, txtSt_kh.Value);
		txtkh_th_n4.Value = Operators.DivideObject(txtNg_gia_n4.Value, txtSt_kh.Value);
		txtT_kh_th.Value = Operators.AddObject(Operators.AddObject(Operators.AddObject(txtkh_th_n1.Value, txtkh_th_n2.Value), txtkh_th_n3.Value), txtkh_th_n4.Value);
	}

	private void txtMa_ts_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		lblTen_TS.Text = Conversions.ToString(e.ValidatedRow["ten_ts"]);
		txtNgay_tang.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ngay_tang"]);
		txtngay_gt_con_lai.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ngay_gt_cl"]);
		txtso_thang_kh.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["st_kh"]);
		txtty_le_kh.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["tl_kh"]);
		txtSo_luong_kh.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["so_luong"]);
		chkTinh_kh.Checked = e.ValidatedRow["tinh_kh"].ToString().Equals("True");
		txtTk_ts.Text = Conversions.ToString(e.ValidatedRow["Tk_ts"]);
		txtTk_kh.Text = Conversions.ToString(e.ValidatedRow["Tk_kh"]);
		txtTk_cp.Text = Conversions.ToString(e.ValidatedRow["Tk_cp"]);
		chkEdit_kh.Checked = e.ValidatedRow["sua_kh"].ToString().Equals("True");
		txtNg_gia_n11.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["Ng_gia_n1"]);
		txtNg_gia_n21.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["Ng_gia_n2"]);
		txtNg_gia_n31.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["Ng_gia_n3"]);
		txtNg_gia_n41.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["Ng_gia_n4"]);
		txtT_ng_gia1.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["T_ng_gia"]);
		txtGt_kh_n1.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["Gt_kh_n1"]);
		txtGt_kh_n2.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["Gt_kh_n2"]);
		txtGt_kh_n3.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["Gt_kh_n3"]);
		txtGt_kh_n4.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["Gt_kh_n4"]);
		txtT_gt_kh.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["T_gt_kh"]);
		txtGt_cl_n1.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["Gt_cl_n1"]);
		txtGt_cl_n2.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["Gt_cl_n2"]);
		txtGt_cl_n3.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["Gt_cl_n3"]);
		txtGt_cl_n4.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["Gt_cl_n4"]);
		txtT_gt_cl.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["T_gt_cl"]);
		txtkh_th_n11.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["kh_th_n1"]);
		txtkh_th_n21.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["kh_th_n2"]);
		txtkh_th_n31.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["kh_th_n3"]);
		txtkh_th_n41.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["kh_th_n4"]);
		txtT_kh_th1.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["T_kh_th"]);
		epNotice.SetError((Control)(object)txtMa_ts, "");
	}

	private void txtMA_LDTG_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (Operators.CompareString(((TextBox)txtMA_LDTG).Text.Trim(), "", false) != 0)
		{
			lblTen_LDTG.Text = e.ValidatedRow["ten_ldtg"].ToString();
		}
	}

	private void txtNgay_gt_cl_Validated(object sender, EventArgs e)
	{
		txtSt_kh.Value = Operators.SubtractObject(txtso_thang_kh.Value, (object)DateAndTime.DateDiff((DateInterval)2, Conversions.ToDate(txtngay_gt_con_lai.Value), Conversions.ToDate(txtNgay_gt_cl.Value), (FirstDayOfWeek)1, (FirstWeekOfYear)1));
	}

	private void rbbTang_CheckedChanged(object sender, EventArgs e)
	{
		txtMA_LDTG.LookupWhereCondition = Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"tg= '", Interaction.IIf(rbbTang.Checked, (object)"T", (object)"G")), (object)"'"));
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
		if (Operators.CompareString(txtMa_Lk.Text, ((TextBox)txtMa_ts).Text, false) == 0)
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

	private static void MaskTextBoxAll(ControlCollection ctl)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		foreach (Control item in ctl)
		{
			Control val = item;
			if (val is AsTextNumeric asTextNumeric)
			{
				AsTextNumeric asTextNumeric2 = asTextNumeric;
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric2).Tag, (object)"AM", false))
				{
					asTextNumeric2.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
				}
			}
		}
	}

	private int CheckDgtsSauGiamTS(string ma_ts, DateTime ngay_ct)
	{
		int num = 0;
		IFADGTSDAO iFADGTSDAO = (IFADGTSDAO)DAOFactory.CreateDAOInstance("FADGTSDAO", "FADGTS");
		num = iFADGTSDAO.CheckDgtsSauGiamTS(CompanyInformations.CompanyID, ma_ts, ngay_ct, 0);
		iFADGTSDAO.Destroy();
		return num;
	}
}
