using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.SOUtilities;
using CrystalDecisions.Shared;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSoVchSO3 : frmVoucher
{
	private enum LOAI_GRID
	{
		CHI_TIET,
		HOACH_TOAN
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

	[AccessedThroughProperty("txtSo_Seri")]
	private TextBox _txtSo_Seri;

	[AccessedThroughProperty("lblSo_seri")]
	private Label _lblSo_seri;

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

	[AccessedThroughProperty("txtTk_pt")]
	private AsTextBox _txtTk_pt;

	[AccessedThroughProperty("lblTk_pt")]
	private Label _lblTk_pt;

	[AccessedThroughProperty("txtTk_thue")]
	private AsTextBox _txtTk_thue;

	[AccessedThroughProperty("lblTk_thue")]
	private Label _lblTk_thue;

	[AccessedThroughProperty("chkGia_dd")]
	private AsCheckBox _chkGia_dd;

	[AccessedThroughProperty("tabHach_toan")]
	private TabPage _tabHach_toan;

	[AccessedThroughProperty("adgvHach_toan")]
	private AsInputDGV _adgvHach_toan;

	[AccessedThroughProperty("txtT_tt")]
	private AsTextNumeric _txtT_tt;

	[AccessedThroughProperty("txtT_Tien_nt2")]
	private AsTextNumeric _txtT_Tien_nt2;

	[AccessedThroughProperty("txtT_Thue")]
	private AsTextNumeric _txtT_Thue;

	[AccessedThroughProperty("txtT_thue_nt")]
	private AsTextNumeric _txtT_thue_nt;

	[AccessedThroughProperty("lblT_Tt")]
	private Label _lblT_Tt;

	[AccessedThroughProperty("txtT_ck")]
	private AsTextNumeric _txtT_ck;

	[AccessedThroughProperty("lblT_Thue")]
	private Label _lblT_Thue;

	[AccessedThroughProperty("txtT_ck_nt")]
	private AsTextNumeric _txtT_ck_nt;

	[AccessedThroughProperty("txtT_Tien2")]
	private AsTextNumeric _txtT_Tien2;

	[AccessedThroughProperty("lblT_Tien")]
	private Label _lblT_Tien;

	[AccessedThroughProperty("lblT_ck")]
	private Label _lblT_ck;

	[AccessedThroughProperty("txtT_tt_nt")]
	private AsTextNumeric _txtT_tt_nt;

	[AccessedThroughProperty("adgvDetail")]
	private AsInputDGV _adgvDetail;

	[AccessedThroughProperty("txtMa_Httt")]
	private AsTextBox _txtMa_Httt;

	[AccessedThroughProperty("lblTen_Httt")]
	private Label _lblTen_Httt;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("txtGh_no")]
	private AsTextNumeric _txtGh_no;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("lblMa_so_thue")]
	private Label _lblMa_so_thue;

	[AccessedThroughProperty("txtMa_so_thue")]
	private TextBox _txtMa_so_thue;

	[AccessedThroughProperty("lblDia_chi")]
	private Label _lblDia_chi;

	[AccessedThroughProperty("txtDia_chi_vat")]
	private TextBox _txtDia_chi_vat;

	[AccessedThroughProperty("txtT_So_luong")]
	private AsTextNumeric _txtT_So_luong;

	[AccessedThroughProperty("txtDu13")]
	private AsTextNumeric _txtDu13;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	[AccessedThroughProperty("SplitContainerHachToan")]
	private SplitContainer _SplitContainerHachToan;

	[AccessedThroughProperty("txtTk_ck_ds")]
	private AsTextBox _txtTk_ck_ds;

	[AccessedThroughProperty("lblTkckhd")]
	private Label _lblTkckhd;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("txtT_ck_ds")]
	private AsTextNumeric _txtT_ck_ds;

	[AccessedThroughProperty("txtT_ck_ds_nt")]
	private AsTextNumeric _txtT_ck_ds_nt;

	[AccessedThroughProperty("txtTl_ck_ds")]
	private AsTextNumeric _txtTl_ck_ds;

	[AccessedThroughProperty("txtSo_seri_mhd")]
	private TextBox _txtSo_seri_mhd;

	[AccessedThroughProperty("lblSo_seri_mhd")]
	private Label _lblSo_seri_mhd;

	[AccessedThroughProperty("cmdThanh_toan")]
	private Button _cmdThanh_toan;

	[AccessedThroughProperty("txtSo_px")]
	private TextBox _txtSo_px;

	[AccessedThroughProperty("lblSo_px")]
	private Label _lblSo_px;

	[AccessedThroughProperty("cboHttt")]
	private ComboBox _cboHttt;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("chkCk_st")]
	private AsCheckBox _chkCk_st;

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

	[AccessedThroughProperty("dgvcGia_nt2")]
	private DataGridViewAsTextNumericColumn _dgvcGia_nt2;

	[AccessedThroughProperty("dgvcTien_nt2")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt2;

	[AccessedThroughProperty("dgvcTl_ck")]
	private DataGridViewAsTextNumericColumn _dgvcTl_ck;

	[AccessedThroughProperty("dgvcTien_ck_nt")]
	private DataGridViewAsTextNumericColumn _dgvcTien_ck_nt;

	[AccessedThroughProperty("dgvcTs_gtgt")]
	private DataGridViewAsTextBoxColumn _dgvcTs_gtgt;

	[AccessedThroughProperty("dgvcThue_gtgt_nt")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt_nt;

	[AccessedThroughProperty("dgvcGia2")]
	private DataGridViewAsTextNumericColumn _dgvcGia2;

	[AccessedThroughProperty("dgvcTien2")]
	private DataGridViewAsTextNumericColumn _dgvcTien2;

	[AccessedThroughProperty("dgvcTien_ck")]
	private DataGridViewAsTextNumericColumn _dgvcTien_ck;

	[AccessedThroughProperty("dgvcThue_gtgt")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt;

	[AccessedThroughProperty("dgvcGia_nt")]
	private DataGridViewAsTextNumericColumn _dgvcGia_nt;

	[AccessedThroughProperty("dgvcTien_nt")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt;

	[AccessedThroughProperty("dgvcGia")]
	private DataGridViewAsTextNumericColumn _dgvcGia;

	[AccessedThroughProperty("dgvcTien")]
	private DataGridViewAsTextNumericColumn _dgvcTien;

	[AccessedThroughProperty("dgvcMa_Nvkd")]
	private DataGridViewAsTextBoxColumn _dgvcMa_Nvkd;

	[AccessedThroughProperty("dgvcTen_vt_ht")]
	private DataGridViewTextBoxColumn _dgvcTen_vt_ht;

	[AccessedThroughProperty("dgvcTien_nt2_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt2_ht;

	[AccessedThroughProperty("dgvcTien_ck_nt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_ck_nt_ht;

	[AccessedThroughProperty("dgvcThue_gtgt_nt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt_nt_ht;

	[AccessedThroughProperty("dgvcTien_nt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt_ht;

	[AccessedThroughProperty("dgvcTien2_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien2_ht;

	[AccessedThroughProperty("dgvcTien_Ck_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_Ck_ht;

	[AccessedThroughProperty("dgvcThue_gtgt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt_ht;

	[AccessedThroughProperty("dgvcTien_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_ht;

	[AccessedThroughProperty("dgvcTk_dt")]
	private DataGridViewAsTextBoxColumn _dgvcTk_dt;

	[AccessedThroughProperty("dgvcTk_gv")]
	private DataGridViewAsTextBoxColumn _dgvcTk_gv;

	[AccessedThroughProperty("dgvcTk_vt")]
	private DataGridViewAsTextBoxColumn _dgvcTk_vt;

	[AccessedThroughProperty("dgvcTk_ck")]
	private DataGridViewAsTextBoxColumn _dgvcTk_ck;

	[AccessedThroughProperty("dgvcMa_vt_ht")]
	private DataGridViewTextBoxColumn _dgvcMa_vt_ht;

	[AccessedThroughProperty("cmdChon_dh")]
	private Button _cmdChon_dh;

	[AccessedThroughProperty("chkGia_st")]
	private AsCheckBox _chkGia_st;

	[AccessedThroughProperty("txtTen_kh")]
	private TextBox _txtTen_kh;

	private const string HOA_DON_KIEM_PHIEU_XUAT = "1";

	private const string HOA_DON = "2";

	private bool f_isGetKhInfo;

	private string f_sMa_Gd_Default;

	private string f_sTien_von;

	private string f_sGia_von;

	private string f_sGia_ban;

	private string f_sTien_ban;

	private string f_sTien_ck;

	private string f_sTien_thue;

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

	internal virtual TextBox txtSo_Seri
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_Seri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_Seri = value;
		}
	}

	internal virtual Label lblSo_seri
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_seri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_seri = value;
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
			EventHandler obj = txtTy_gia_ValueChanged;
			if (_txtTy_gia != null)
			{
				_txtTy_gia.ValueChanged -= obj;
			}
			_txtTy_gia = value;
			if (_txtTy_gia != null)
			{
				_txtTy_gia.ValueChanged += obj;
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

	internal virtual AsCheckBox chkGia_dd
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkGia_dd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkGia_dd = value;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvHach_toan_CellEnter);
			if (_adgvHach_toan != null)
			{
				((DataGridView)_adgvHach_toan).CellEnter -= val;
			}
			_adgvHach_toan = value;
			if (_adgvHach_toan != null)
			{
				((DataGridView)_adgvHach_toan).CellEnter += val;
			}
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

	internal virtual AsTextNumeric txtT_Tien_nt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Tien_nt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Tien_nt2 = value;
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

	internal virtual AsTextNumeric txtT_thue_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_thue_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_thue_nt = value;
		}
	}

	internal virtual Label lblT_Tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_Tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_Tt = value;
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
			_txtT_ck = value;
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
			_txtT_ck_nt = value;
		}
	}

	internal virtual AsTextNumeric txtT_Tien2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Tien2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Tien2 = value;
		}
	}

	internal virtual Label lblT_Tien
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_Tien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_Tien = value;
		}
	}

	internal virtual Label lblT_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_ck = value;
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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvDetail_CellEnter);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvDetail_CellValueChanged);
			DataGridViewCellValidatingEventHandler val3 = new DataGridViewCellValidatingEventHandler(adgvDetail_CellValidating);
			AsInputDGV.SetDependentFieldsWhenCellValueChangedHandler obj = adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellEnter -= val;
				((DataGridView)_adgvDetail).CellValueChanged -= val2;
				((DataGridView)_adgvDetail).CellValidating -= val3;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged -= obj;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellEnter += val;
				((DataGridView)_adgvDetail).CellValueChanged += val2;
				((DataGridView)_adgvDetail).CellValidating += val3;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged += obj;
			}
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

	internal virtual Label lblTen_Httt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Httt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Httt = value;
		}
	}

	internal virtual Label Label6
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

	internal virtual AsTextNumeric txtGh_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGh_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGh_no = value;
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

	internal virtual TextBox txtDia_chi_vat
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDia_chi_vat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDia_chi_vat = value;
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

	private virtual AsTextNumeric txtDu13
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDu13 = value;
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
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

	internal virtual SplitContainer SplitContainerHachToan
	{
		[DebuggerNonUserCode]
		get
		{
			return _SplitContainerHachToan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SplitContainerHachToan = value;
		}
	}

	internal virtual AsTextBox txtTk_ck_ds
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_ck_ds;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_ck_ds = value;
		}
	}

	internal virtual Label lblTkckhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTkckhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTkckhd = value;
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

	internal virtual AsTextNumeric txtT_ck_ds
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_ck_ds;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = txtT_ck_ds_ValueChanged;
			if (_txtT_ck_ds != null)
			{
				_txtT_ck_ds.ValueChanged -= obj;
			}
			_txtT_ck_ds = value;
			if (_txtT_ck_ds != null)
			{
				_txtT_ck_ds.ValueChanged += obj;
			}
		}
	}

	internal virtual AsTextNumeric txtT_ck_ds_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_ck_ds_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = txtT_ck_ds_nt_ValueChanged;
			if (_txtT_ck_ds_nt != null)
			{
				_txtT_ck_ds_nt.ValueChanged -= obj;
			}
			_txtT_ck_ds_nt = value;
			if (_txtT_ck_ds_nt != null)
			{
				_txtT_ck_ds_nt.ValueChanged += obj;
			}
		}
	}

	internal virtual AsTextNumeric txtTl_ck_ds
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTl_ck_ds;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = txtTl_ck_ds_ValueChanged;
			if (_txtTl_ck_ds != null)
			{
				_txtTl_ck_ds.ValueChanged -= obj;
			}
			_txtTl_ck_ds = value;
			if (_txtTl_ck_ds != null)
			{
				_txtTl_ck_ds.ValueChanged += obj;
			}
		}
	}

	internal virtual TextBox txtSo_seri_mhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_seri_mhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_seri_mhd = value;
		}
	}

	internal virtual Label lblSo_seri_mhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_seri_mhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_seri_mhd = value;
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

	internal virtual TextBox txtSo_px
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_px;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_px = value;
		}
	}

	internal virtual Label lblSo_px
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_px;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_px = value;
		}
	}

	internal virtual ComboBox cboHttt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboHttt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboHttt = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcGia_nt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcGia_nt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcGia_nt2 = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_nt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_nt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_nt2 = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_ck_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_ck_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_ck_nt = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTs_gtgt
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

	internal virtual DataGridViewAsTextNumericColumn dgvcGia2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcGia2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcGia2 = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien2 = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_ck = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcGia_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcGia_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcGia_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcGia
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcGia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcGia = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_Nvkd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_Nvkd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_Nvkd = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_nt2_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_nt2_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_nt2_ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_ck_nt_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_ck_nt_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_ck_nt_ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_gtgt_nt_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_gtgt_nt_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_gtgt_nt_ht = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcTien2_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien2_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien2_ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_Ck_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_Ck_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_Ck_ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_gtgt_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_gtgt_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_gtgt_ht = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_dt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_dt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_dt = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_gv
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_gv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_gv = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_ck = value;
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

	protected virtual AsCheckBox chkGia_st
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkGia_st;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkGia_st_CheckedChanged;
			if (_chkGia_st != null)
			{
				((CheckBox)_chkGia_st).CheckedChanged -= eventHandler;
			}
			_chkGia_st = value;
			if (_chkGia_st != null)
			{
				((CheckBox)_chkGia_st).CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual TextBox txtTen_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_kh = value;
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

	public frmSoVchSO3()
	{
		__ENCAddToList(this);
		f_isGetKhInfo = false;
		f_sMa_Gd_Default = "1";
		f_sTien_von = "";
		f_sGia_von = "";
		f_sGia_ban = "";
		f_sTien_ban = "";
		f_sTien_ck = "";
		f_sTien_thue = "";
		InitializeComponent();
	}

	public frmSoVchSO3(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_isGetKhInfo = false;
		f_sMa_Gd_Default = "1";
		f_sTien_von = "";
		f_sGia_von = "";
		f_sGia_ban = "";
		f_sTien_ban = "";
		f_sTien_ck = "";
		f_sTien_thue = "";
		InitializeComponent();
	}

	public frmSoVchSO3(string MenuID, string Stt_rec)
		: base(MenuID, Stt_rec)
	{
		__ENCAddToList(this);
		f_isGetKhInfo = false;
		f_sMa_Gd_Default = "1";
		f_sTien_von = "";
		f_sGia_von = "";
		f_sGia_ban = "";
		f_sTien_ban = "";
		f_sTien_ck = "";
		f_sTien_thue = "";
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
		//IL_0008: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected O, but got Unknown
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected O, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected O, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected O, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected O, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_1b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e40: Expected O, but got Unknown
		//IL_290e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2918: Expected O, but got Unknown
		//IL_29ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d8: Expected O, but got Unknown
		//IL_2ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac2: Expected O, but got Unknown
		//IL_2bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc6: Expected O, but got Unknown
		//IL_2cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ccb: Expected O, but got Unknown
		//IL_2dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dcb: Expected O, but got Unknown
		//IL_2e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e8f: Expected O, but got Unknown
		//IL_2f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f93: Expected O, but got Unknown
		//IL_3080: Unknown result type (might be due to invalid IL or missing references)
		//IL_308a: Expected O, but got Unknown
		//IL_3184: Unknown result type (might be due to invalid IL or missing references)
		//IL_318e: Expected O, but got Unknown
		//IL_327b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3285: Expected O, but got Unknown
		//IL_337b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3385: Expected O, but got Unknown
		//IL_343b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3445: Expected O, but got Unknown
		//IL_34ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3509: Expected O, but got Unknown
		//IL_3604: Unknown result type (might be due to invalid IL or missing references)
		//IL_360e: Expected O, but got Unknown
		//IL_3705: Unknown result type (might be due to invalid IL or missing references)
		//IL_370f: Expected O, but got Unknown
		//IL_37c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_37d3: Expected O, but got Unknown
		//IL_38ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_38d4: Expected O, but got Unknown
		//IL_3981: Unknown result type (might be due to invalid IL or missing references)
		//IL_398b: Expected O, but got Unknown
		//IL_3e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e78: Expected O, but got Unknown
		//IL_5278: Unknown result type (might be due to invalid IL or missing references)
		//IL_5282: Expected O, but got Unknown
		//IL_596b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5975: Expected O, but got Unknown
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSoVchSO3));
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblNguoi_Gd = new Label();
		txtDien_giai = new TextBox();
		txtNguoi_Gd = new TextBox();
		lblDien_giai = new Label();
		txtSo_Seri = new TextBox();
		lblSo_seri = new Label();
		txtNgay_lct = new AsMaskedTextBox();
		lblNgay_Lct = new Label();
		txtTy_gia = new AsTextNumeric();
		cboMa_NT = new AsComboBoxNT();
		lblMa_Nt = new Label();
		txtTk_pt = new AsTextBox();
		lblTk_pt = new Label();
		txtTk_thue = new AsTextBox();
		lblTk_thue = new Label();
		chkGia_dd = new AsCheckBox();
		tabHach_toan = new TabPage();
		SplitContainerHachToan = new SplitContainer();
		adgvHach_toan = new AsInputDGV();
		dgvcTen_vt_ht = new DataGridViewTextBoxColumn();
		dgvcTien_nt2_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_ck_nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt_nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien2_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_Ck_ht = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_ht = new DataGridViewAsTextNumericColumn();
		dgvcTk_dt = new DataGridViewAsTextBoxColumn();
		dgvcTk_gv = new DataGridViewAsTextBoxColumn();
		dgvcTk_vt = new DataGridViewAsTextBoxColumn();
		dgvcTk_ck = new DataGridViewAsTextBoxColumn();
		dgvcMa_vt_ht = new DataGridViewTextBoxColumn();
		txtTk_ck_ds = new AsTextBox();
		lblTkckhd = new Label();
		txtTl_ck_ds = new AsTextNumeric();
		txtT_So_luong = new AsTextNumeric();
		txtT_tt = new AsTextNumeric();
		txtT_Tien_nt2 = new AsTextNumeric();
		lblT_Tt = new Label();
		txtT_ck = new AsTextNumeric();
		txtT_ck_ds = new AsTextNumeric();
		txtT_ck_nt = new AsTextNumeric();
		txtT_ck_ds_nt = new AsTextNumeric();
		txtT_Tien2 = new AsTextNumeric();
		Label7 = new Label();
		lblT_Tien = new Label();
		txtT_Thue = new AsTextNumeric();
		txtT_thue_nt = new AsTextNumeric();
		lblT_ck = new Label();
		txtT_tt_nt = new AsTextNumeric();
		lblT_Thue = new Label();
		txtGh_no = new AsTextNumeric();
		Label4 = new Label();
		lblMa_so_thue = new Label();
		txtMa_so_thue = new TextBox();
		lblDia_chi = new Label();
		txtDia_chi_vat = new TextBox();
		adgvDetail = new AsInputDGV();
		dgvcMa_vt = new DataGridViewAsTextBoxColumn();
		dgvcTen_vt = new DataGridViewTextBoxColumn();
		dgvcDvt = new DataGridViewTextBoxColumn();
		dgvcMa_kho = new DataGridViewAsTextBoxColumn();
		dgvcTon = new DataGridViewAsTextNumericColumn();
		dgvcSo_luong = new DataGridViewAsTextNumericColumn();
		dgvcGia_nt2 = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt2 = new DataGridViewAsTextNumericColumn();
		dgvcTl_ck = new DataGridViewAsTextNumericColumn();
		dgvcTien_ck_nt = new DataGridViewAsTextNumericColumn();
		dgvcTs_gtgt = new DataGridViewAsTextBoxColumn();
		dgvcThue_gtgt_nt = new DataGridViewAsTextNumericColumn();
		dgvcGia2 = new DataGridViewAsTextNumericColumn();
		dgvcTien2 = new DataGridViewAsTextNumericColumn();
		dgvcTien_ck = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt = new DataGridViewAsTextNumericColumn();
		dgvcGia_nt = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt = new DataGridViewAsTextNumericColumn();
		dgvcGia = new DataGridViewAsTextNumericColumn();
		dgvcTien = new DataGridViewAsTextNumericColumn();
		dgvcMa_Nvkd = new DataGridViewAsTextBoxColumn();
		txtMa_Httt = new AsTextBox();
		lblTen_Httt = new Label();
		Label6 = new Label();
		txtDu13 = new AsTextNumeric();
		Label14 = new Label();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		txtSo_seri_mhd = new TextBox();
		lblSo_seri_mhd = new Label();
		cmdThanh_toan = new Button();
		txtSo_px = new TextBox();
		lblSo_px = new Label();
		cboHttt = new ComboBox();
		Label1 = new Label();
		chkCk_st = new AsCheckBox();
		cmdChon_dh = new Button();
		chkGia_st = new AsCheckBox();
		txtTen_kh = new TextBox();
		((Control)gbPH).SuspendLayout();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabDetail).SuspendLayout();
		((ISupportInitialize)bsPH).BeginInit();
		((ISupportInitialize)bsCT).BeginInit();
		((ISupportInitialize)bsCP).BeginInit();
		((ISupportInitialize)bsTain).BeginInit();
		((ISupportInitialize)bsTaout).BeginInit();
		((Control)tabHach_toan).SuspendLayout();
		((Control)SplitContainerHachToan.Panel1).SuspendLayout();
		((Control)SplitContainerHachToan.Panel2).SuspendLayout();
		((Control)SplitContainerHachToan).SuspendLayout();
		((ISupportInitialize)adgvHach_toan).BeginInit();
		((ISupportInitialize)adgvDetail).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = cmdAdd;
		Point location = new Point(3, 477);
		((Control)obj).Location = location;
		((Control)cmdAdd).TabIndex = 13;
		Button obj2 = cmdPrint;
		location = new Point(73, 477);
		((Control)obj2).Location = location;
		((Control)cmdPrint).TabIndex = 14;
		Button obj3 = cmdLast;
		location = new Point(706, 477);
		((Control)obj3).Location = location;
		((Control)cmdLast).TabIndex = 23;
		Button obj4 = cmdNext;
		location = new Point(681, 477);
		((Control)obj4).Location = location;
		((Control)cmdNext).TabIndex = 22;
		Button obj5 = cmdPrevious;
		location = new Point(656, 477);
		((Control)obj5).Location = location;
		((Control)cmdPrevious).TabIndex = 21;
		Button obj6 = cmdFirst;
		location = new Point(631, 477);
		((Control)obj6).Location = location;
		((Control)cmdFirst).TabIndex = 20;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(536, 60);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct;
		Size size = new Size(63, 13);
		((Control)obj8).Size = size;
		lblSo_Ct.Text = "Số hoá đơn";
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		Label obj9 = lblNgay_Ct;
		location = new Point(536, 38);
		((Control)obj9).Location = location;
		Label obj10 = lblNgay_Ct;
		size = new Size(75, 13);
		((Control)obj10).Size = size;
		lblNgay_Ct.Text = "Ngày hoá đơn";
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)5;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(638, 34);
		((Control)asMaskedTextBox).Location = location;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_Ct;
		size = new Size(78, 19);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_Ct).TabIndex = 9;
		((Control)gbPH).Controls.Add((Control)(object)txtTen_kh);
		((Control)gbPH).Controls.Add((Control)(object)cboHttt);
		((Control)gbPH).Controls.Add((Control)(object)Label1);
		((Control)gbPH).Controls.Add((Control)(object)txtSo_px);
		((Control)gbPH).Controls.Add((Control)(object)lblSo_px);
		((Control)gbPH).Controls.Add((Control)(object)txtGh_no);
		((Control)gbPH).Controls.Add((Control)(object)Label4);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)txtDu13);
		((Control)gbPH).Controls.Add((Control)(object)Label14);
		((Control)gbPH).Controls.Add((Control)(object)lblDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)txtDia_chi_vat);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Httt);
		((Control)gbPH).Controls.Add((Control)(object)Label6);
		((Control)gbPH).Controls.Add((Control)(object)txtSo_Seri);
		((Control)gbPH).Controls.Add((Control)(object)txtTy_gia);
		((Control)gbPH).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Nt);
		((Control)gbPH).Controls.Add((Control)(object)txtNgay_lct);
		((Control)gbPH).Controls.Add((Control)(object)lblNgay_Lct);
		((Control)gbPH).Controls.Add((Control)(object)lblSo_seri);
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
		size = new Size(726, 147);
		((Control)obj12).Size = size;
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_seri, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTy_gia, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Seri, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDia_chi_vat, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label14, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDu13, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtGh_no, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_px, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_px, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboHttt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTen_kh, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(550, 477);
		((Control)splitButton).Location = location;
		((Control)cmdSearch).TabIndex = 19;
		((Control)AsTabControl).Controls.Add((Control)(object)tabHach_toan);
		AsTabControl asTabControl = AsTabControl;
		location = new Point(0, 147);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(732, 212);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl).TabIndex = 2;
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabHach_toan, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabOptFields, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabDetail, 0);
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj13 = tabDetail;
		size = new Size(724, 183);
		((Control)obj13).Size = size;
		TabPage obj14 = tabOptFields;
		size = new Size(724, 183);
		((Control)obj14).Size = size;
		Button obj15 = cmdCopy;
		location = new Point(353, 477);
		((Control)obj15).Location = location;
		((Control)cmdCopy).TabIndex = 18;
		Button obj16 = cmdDelete;
		location = new Point(283, 477);
		((Control)obj16).Location = location;
		((Control)cmdDelete).TabIndex = 17;
		Button obj17 = cmdEdit;
		location = new Point(213, 477);
		((Control)obj17).Location = location;
		((Control)cmdEdit).TabIndex = 16;
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		TextBox obj18 = txtSo_Ct;
		location = new Point(638, 56);
		((Control)obj18).Location = location;
		TextBox obj19 = txtSo_Ct;
		size = new Size(78, 19);
		((Control)obj19).Size = size;
		((Control)txtSo_Ct).TabIndex = 10;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(94, 11);
		((Control)asTextBox).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		txtMa_Kh.LookupWhereCondition = "isKh=1";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = null;
		txtMa_Kh.SD = true;
		AsTextBox asTextBox2 = txtMa_Kh;
		size = new Size(75, 19);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Kh).TabIndex = 0;
		txtMa_Kh.UseAutoCompleteSource = true;
		txtMa_Kh.ValidReturnFieldList = "ten_kh,dia_chi,ma_so_thue,nguoi_gd,tel,gh_no,ma_tt,ma_httt";
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj20 = lblMa_Kh;
		location = new Point(9, 15);
		((Control)obj20).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj21 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj21).Size = size;
		((Control)lblMa_Kh).TabIndex = 0;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblNguoi_Gd.AutoSize = true;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj22 = lblNguoi_Gd;
		location = new Point(9, 59);
		((Control)obj22).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj23 = lblNguoi_Gd;
		size = new Size(58, 13);
		((Control)obj23).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 143;
		lblNguoi_Gd.Text = "Người mua";
		TextBox obj24 = txtDien_giai;
		location = new Point(94, 78);
		((Control)obj24).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj25 = txtDien_giai;
		size = new Size(403, 19);
		((Control)obj25).Size = size;
		((Control)txtDien_giai).TabIndex = 5;
		TextBox obj26 = txtNguoi_Gd;
		location = new Point(94, 56);
		((Control)obj26).Location = location;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj27 = txtNguoi_Gd;
		size = new Size(180, 19);
		((Control)obj27).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 3;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj28 = lblDien_giai;
		location = new Point(9, 82);
		((Control)obj28).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj29 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj29).Size = size;
		((Control)lblDien_giai).TabIndex = 144;
		lblDien_giai.Text = "Diễn giải";
		txtSo_Seri.CharacterCasing = (CharacterCasing)1;
		TextBox obj30 = txtSo_Seri;
		location = new Point(638, 12);
		((Control)obj30).Location = location;
		((Control)txtSo_Seri).Name = "txtSo_Seri";
		TextBox obj31 = txtSo_Seri;
		size = new Size(78, 19);
		((Control)obj31).Size = size;
		((Control)txtSo_Seri).TabIndex = 8;
		lblSo_seri.AutoSize = true;
		Label obj32 = lblSo_seri;
		location = new Point(536, 16);
		((Control)obj32).Location = location;
		((Control)lblSo_seri).Name = "lblSo_seri";
		Label obj33 = lblSo_seri;
		size = new Size(39, 13);
		((Control)obj33).Size = size;
		((Control)lblSo_seri).TabIndex = 232;
		lblSo_seri.Text = "Số seri";
		txtNgay_lct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_lct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_lct;
		location = new Point(638, 100);
		((Control)asMaskedTextBox3).Location = location;
		((MaskedTextBox)txtNgay_lct).Mask = "##/##/####";
		((Control)txtNgay_lct).Name = "txtNgay_lct";
		((MaskedTextBox)txtNgay_lct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_lct;
		size = new Size(78, 19);
		((Control)asMaskedTextBox4).Size = size;
		((Control)txtNgay_lct).TabIndex = 12;
		((MaskedTextBox)txtNgay_lct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_lct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox5.Value = dateTime;
		lblNgay_Lct.AutoSize = true;
		lblNgay_Lct.ImeMode = (ImeMode)0;
		Label obj34 = lblNgay_Lct;
		location = new Point(536, 104);
		((Control)obj34).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj35 = lblNgay_Lct;
		size = new Size(49, 13);
		((Control)obj35).Size = size;
		((Control)lblNgay_Lct).TabIndex = 234;
		lblNgay_Lct.Text = "Ngày lập";
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(647, 122);
		((Control)asTextNumeric).Location = location;
		txtTy_gia.Mask = "### ### ### ###.##";
		((Control)txtTy_gia).Name = "txtTy_gia";
		AsTextNumeric asTextNumeric2 = txtTy_gia;
		size = new Size(69, 19);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTy_gia).TabIndex = 14;
		((TextBox)txtTy_gia).Text = "0.00";
		((TextBox)txtTy_gia).TextAlign = (HorizontalAlignment)1;
		txtTy_gia.Value = 0.0;
		((ComboBox)cboMa_NT).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboMa_NT).Enabled = false;
		((ListControl)cboMa_NT).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_NT;
		location = new Point(598, 121);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(47, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 13;
		lblMa_Nt.AutoSize = true;
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj36 = lblMa_Nt;
		location = new Point(536, 126);
		((Control)obj36).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj37 = lblMa_Nt;
		size = new Size(36, 13);
		((Control)obj37).Size = size;
		((Control)lblMa_Nt).TabIndex = 237;
		lblMa_Nt.Text = "Tỷ giá";
		txtTk_pt.AutoLookup = true;
		txtTk_pt.AutoValid = true;
		((TextBoxBase)txtTk_pt).BackColor = SystemColors.Info;
		((TextBox)txtTk_pt).CharacterCasing = (CharacterCasing)1;
		((Control)txtTk_pt).Enabled = false;
		AsTextBox asTextBox3 = txtTk_pt;
		location = new Point(109, 3);
		((Control)asTextBox3).Location = location;
		txtTk_pt.LookupCodeName = "TK";
		txtTk_pt.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_pt).Name = "txtTk_pt";
		txtTk_pt.NameControl = null;
		txtTk_pt.SD = true;
		AsTextBox asTextBox4 = txtTk_pt;
		size = new Size(78, 19);
		((Control)asTextBox4).Size = size;
		((Control)txtTk_pt).TabIndex = 0;
		txtTk_pt.UseAutoCompleteSource = false;
		lblTk_pt.ImeMode = (ImeMode)0;
		Label obj38 = lblTk_pt;
		location = new Point(5, 6);
		((Control)obj38).Location = location;
		((Control)lblTk_pt).Name = "lblTk_pt";
		Label obj39 = lblTk_pt;
		size = new Size(98, 14);
		((Control)obj39).Size = size;
		((Control)lblTk_pt).TabIndex = 239;
		lblTk_pt.Text = "Tài khoản phải thu";
		txtTk_thue.AutoLookup = true;
		txtTk_thue.AutoValid = true;
		((TextBoxBase)txtTk_thue).BackColor = SystemColors.Info;
		((TextBox)txtTk_thue).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTk_thue;
		location = new Point(283, 3);
		((Control)asTextBox5).Location = location;
		txtTk_thue.LookupCodeName = "TK";
		txtTk_thue.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_thue).Name = "txtTk_thue";
		txtTk_thue.NameControl = null;
		txtTk_thue.SD = true;
		AsTextBox asTextBox6 = txtTk_thue;
		size = new Size(78, 19);
		((Control)asTextBox6).Size = size;
		((Control)txtTk_thue).TabIndex = 1;
		txtTk_thue.UseAutoCompleteSource = false;
		lblTk_thue.ImeMode = (ImeMode)0;
		Label obj40 = lblTk_thue;
		location = new Point(193, 6);
		((Control)obj40).Location = location;
		((Control)lblTk_thue).Name = "lblTk_thue";
		Label obj41 = lblTk_thue;
		size = new Size(84, 14);
		((Control)obj41).Size = size;
		((Control)lblTk_thue).TabIndex = 242;
		lblTk_thue.Text = "Tài khoản thuế";
		((Control)chkGia_dd).Anchor = (AnchorStyles)6;
		((ButtonBase)chkGia_dd).AutoSize = true;
		chkGia_dd.Checked = false;
		AsCheckBox asCheckBox = chkGia_dd;
		location = new Point(3, 361);
		((Control)asCheckBox).Location = location;
		((Control)chkGia_dd).Name = "chkGia_dd";
		AsCheckBox asCheckBox2 = chkGia_dd;
		size = new Size(116, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkGia_dd).TabIndex = 3;
		((Control)chkGia_dd).TabStop = false;
		((ButtonBase)chkGia_dd).Text = "Giá vốn đích danh";
		chkGia_dd.TextValue = "0";
		((ButtonBase)chkGia_dd).UseVisualStyleBackColor = true;
		tabHach_toan.BackColor = SystemColors.Control;
		((Control)tabHach_toan).Controls.Add((Control)(object)SplitContainerHachToan);
		TabPage obj42 = tabHach_toan;
		location = new Point(4, 25);
		obj42.Location = location;
		((Control)tabHach_toan).Name = "tabHach_toan";
		TabPage obj43 = tabHach_toan;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)obj43).Padding = padding;
		TabPage obj44 = tabHach_toan;
		size = new Size(724, 183);
		((Control)obj44).Size = size;
		tabHach_toan.TabIndex = 1;
		tabHach_toan.Text = "Hạch toá&n";
		SplitContainerHachToan.Dock = (DockStyle)5;
		SplitContainerHachToan.FixedPanel = (FixedPanel)2;
		SplitContainer splitContainerHachToan = SplitContainerHachToan;
		location = new Point(3, 3);
		((Control)splitContainerHachToan).Location = location;
		((Control)SplitContainerHachToan).Name = "SplitContainerHachToan";
		SplitContainerHachToan.Orientation = (Orientation)0;
		((Control)SplitContainerHachToan.Panel1).Controls.Add((Control)(object)adgvHach_toan);
		((Control)SplitContainerHachToan.Panel2).Controls.Add((Control)(object)lblTk_thue);
		((Control)SplitContainerHachToan.Panel2).Controls.Add((Control)(object)txtTk_thue);
		((Control)SplitContainerHachToan.Panel2).Controls.Add((Control)(object)txtTk_pt);
		((Control)SplitContainerHachToan.Panel2).Controls.Add((Control)(object)txtTk_ck_ds);
		((Control)SplitContainerHachToan.Panel2).Controls.Add((Control)(object)lblTk_pt);
		((Control)SplitContainerHachToan.Panel2).Controls.Add((Control)(object)lblTkckhd);
		SplitContainer splitContainerHachToan2 = SplitContainerHachToan;
		size = new Size(718, 177);
		((Control)splitContainerHachToan2).Size = size;
		SplitContainerHachToan.SplitterDistance = 147;
		((Control)SplitContainerHachToan).TabIndex = 243;
		((DataGridView)adgvHach_toan).AllowUserToAddRows = false;
		((DataGridView)adgvHach_toan).AllowUserToDeleteRows = false;
		((DataGridView)adgvHach_toan).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvHach_toan).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvHach_toan).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvHach_toan).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[14]
		{
			(DataGridViewColumn)dgvcTen_vt_ht,
			dgvcTien_nt2_ht,
			dgvcTien_ck_nt_ht,
			dgvcThue_gtgt_nt_ht,
			dgvcTien_nt_ht,
			dgvcTien2_ht,
			dgvcTien_Ck_ht,
			dgvcThue_gtgt_ht,
			dgvcTien_ht,
			dgvcTk_dt,
			dgvcTk_gv,
			dgvcTk_vt,
			dgvcTk_ck,
			(DataGridViewColumn)dgvcMa_vt_ht
		});
		((Control)adgvHach_toan).Dock = (DockStyle)5;
		((DataGridView)adgvHach_toan).GridColor = SystemColors.Control;
		adgvHach_toan.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV = adgvHach_toan;
		location = new Point(0, 0);
		((Control)asInputDGV).Location = location;
		((Control)adgvHach_toan).Name = "adgvHach_toan";
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 7.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).RowHeadersDefaultCellStyle = val;
		((DataGridView)adgvHach_toan).RowHeadersWidth = 35;
		((DataGridView)adgvHach_toan).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = adgvHach_toan;
		size = new Size(718, 147);
		((Control)asInputDGV2).Size = size;
		((Control)adgvHach_toan).TabIndex = 2;
		((DataGridViewColumn)dgvcTen_vt_ht).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vt_ht).Frozen = true;
		((DataGridViewColumn)dgvcTen_vt_ht).HeaderText = "Tên vật tư";
		((DataGridViewColumn)dgvcTen_vt_ht).Name = "dgvcTen_vt_ht";
		((DataGridViewColumn)dgvcTen_vt_ht).ReadOnly = true;
		dgvcTen_vt_ht.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_vt_ht).Width = 170;
		((DataGridViewColumn)dgvcTien_nt2_ht).DataPropertyName = "tien_nt2";
		val2.Alignment = (DataGridViewContentAlignment)64;
		val2.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2_ht).DefaultCellStyle = val2;
		((DataGridViewColumn)dgvcTien_nt2_ht).HeaderText = "Tiền hàng";
		dgvcTien_nt2_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2_ht).Name = "dgvcTien_nt2_ht";
		((DataGridViewColumn)dgvcTien_nt2_ht).ReadOnly = true;
		dgvcTien_nt2_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt2_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt2_ht).Width = 90;
		((DataGridViewColumn)dgvcTien_ck_nt_ht).DataPropertyName = "tien_ck_nt";
		val3.Alignment = (DataGridViewContentAlignment)64;
		val3.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck_nt_ht).DefaultCellStyle = val3;
		((DataGridViewColumn)dgvcTien_ck_nt_ht).HeaderText = "C. khấu";
		dgvcTien_ck_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck_nt_ht).Name = "dgvcTien_ck_nt_ht";
		((DataGridViewColumn)dgvcTien_ck_nt_ht).ReadOnly = true;
		dgvcTien_ck_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ck_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_ck_nt_ht).ToolTipText = "Chiết khấu tiền hàng (trước thuế)/giảm giá";
		((DataGridViewColumn)dgvcTien_ck_nt_ht).Width = 90;
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).DataPropertyName = "thue_gtgt_nt";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).HeaderText = "VAT";
		dgvcThue_gtgt_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).Name = "dgvcThue_gtgt_nt_ht";
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).ReadOnly = true;
		dgvcThue_gtgt_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).ToolTipText = "Thuế giá trị gia tăng";
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).Width = 80;
		((DataGridViewColumn)dgvcTien_nt_ht).DataPropertyName = "tien_nt";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = "Tiền vốn";
		dgvcTien_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).Name = "dgvcTien_nt_ht";
		((DataGridViewColumn)dgvcTien_nt_ht).ReadOnly = true;
		dgvcTien_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt_ht).Width = 90;
		((DataGridViewColumn)dgvcTien2_ht).DataPropertyName = "tien2";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien2_ht).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcTien2_ht).HeaderText = "Tiền hàng VNĐ";
		dgvcTien2_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien2_ht).Name = "dgvcTien2_ht";
		((DataGridViewColumn)dgvcTien2_ht).ReadOnly = true;
		dgvcTien2_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien2_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien2_ht).Width = 90;
		((DataGridViewColumn)dgvcTien_Ck_ht).DataPropertyName = "tien_ck";
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_Ck_ht).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcTien_Ck_ht).HeaderText = "CK VNĐ";
		dgvcTien_Ck_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_Ck_ht).Name = "dgvcTien_Ck_ht";
		((DataGridViewColumn)dgvcTien_Ck_ht).ReadOnly = true;
		dgvcTien_Ck_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_Ck_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_Ck_ht).Width = 90;
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_ht).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcThue_gtgt_ht).HeaderText = "Thuế VNĐ";
		dgvcThue_gtgt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_ht).Name = "dgvcThue_gtgt_ht";
		((DataGridViewColumn)dgvcThue_gtgt_ht).ReadOnly = true;
		dgvcThue_gtgt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_gtgt_ht).Width = 80;
		((DataGridViewColumn)dgvcTien_ht).DataPropertyName = "tien";
		val9.Alignment = (DataGridViewContentAlignment)64;
		val9.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ht).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcTien_ht).HeaderText = "Tiền vốn VNĐ";
		dgvcTien_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ht).Name = "dgvcTien_ht";
		((DataGridViewColumn)dgvcTien_ht).ReadOnly = true;
		dgvcTien_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_ht).Width = 90;
		dgvcTk_dt.AutoFill = true;
		dgvcTk_dt.AutoLookup = true;
		dgvcTk_dt.AutoValid = true;
		((DataGridViewColumn)dgvcTk_dt).DataPropertyName = "tk_dt";
		val10.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_dt).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcTk_dt).HeaderText = "Tk dt";
		dgvcTk_dt.LookupCodeName = "TK";
		dgvcTk_dt.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_dt).Name = "dgvcTk_dt";
		dgvcTk_dt.ReceiverValidFieldList = "ten_tk_dt";
		dgvcTk_dt.SD = true;
		dgvcTk_dt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_dt.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_dt).Width = 65;
		dgvcTk_gv.AutoFill = true;
		dgvcTk_gv.AutoLookup = true;
		dgvcTk_gv.AutoValid = true;
		((DataGridViewColumn)dgvcTk_gv).DataPropertyName = "tk_gv";
		val11.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_gv).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcTk_gv).HeaderText = "Tk gv";
		dgvcTk_gv.LookupCodeName = "TK";
		dgvcTk_gv.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_gv).Name = "dgvcTk_gv";
		dgvcTk_gv.ReceiverValidFieldList = "ten_tk_gv";
		dgvcTk_gv.SD = true;
		dgvcTk_gv.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_gv.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_gv).Width = 65;
		dgvcTk_vt.AutoFill = true;
		dgvcTk_vt.AutoLookup = true;
		dgvcTk_vt.AutoValid = true;
		((DataGridViewColumn)dgvcTk_vt).DataPropertyName = "tk_vt";
		val12.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_vt).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcTk_vt).HeaderText = "Tk kho";
		dgvcTk_vt.LookupCodeName = "TK";
		dgvcTk_vt.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_vt).Name = "dgvcTk_vt";
		dgvcTk_vt.ReceiverValidFieldList = "ten_tk_vt";
		dgvcTk_vt.SD = true;
		dgvcTk_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_vt.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_vt).Width = 65;
		dgvcTk_ck.AutoFill = true;
		dgvcTk_ck.AutoLookup = true;
		dgvcTk_ck.AutoValid = true;
		((DataGridViewColumn)dgvcTk_ck).DataPropertyName = "tk_ck";
		val13.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_ck).DefaultCellStyle = val13;
		((DataGridViewColumn)dgvcTk_ck).HeaderText = "Tk Ck";
		dgvcTk_ck.LookupCodeName = "TK";
		dgvcTk_ck.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_ck).Name = "dgvcTk_ck";
		dgvcTk_ck.ReceiverValidFieldList = "ten_tk_ck";
		dgvcTk_ck.SD = true;
		dgvcTk_ck.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_ck.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_ck).Width = 65;
		((DataGridViewColumn)dgvcMa_vt_ht).DataPropertyName = "ma_vt";
		((DataGridViewColumn)dgvcMa_vt_ht).HeaderText = "Mã hàng";
		((DataGridViewColumn)dgvcMa_vt_ht).Name = "dgvcMa_vt_ht";
		((DataGridViewColumn)dgvcMa_vt_ht).ReadOnly = true;
		dgvcMa_vt_ht.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_vt_ht).Visible = false;
		((DataGridViewColumn)dgvcMa_vt_ht).Width = 70;
		txtTk_ck_ds.AutoLookup = true;
		txtTk_ck_ds.AutoValid = true;
		((TextBoxBase)txtTk_ck_ds).BackColor = SystemColors.Info;
		((TextBox)txtTk_ck_ds).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtTk_ck_ds;
		location = new Point(528, 3);
		((Control)asTextBox7).Location = location;
		txtTk_ck_ds.LookupCodeName = "TK";
		txtTk_ck_ds.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_ck_ds).Name = "txtTk_ck_ds";
		txtTk_ck_ds.NameControl = null;
		txtTk_ck_ds.SD = true;
		AsTextBox asTextBox8 = txtTk_ck_ds;
		size = new Size(78, 19);
		((Control)asTextBox8).Size = size;
		((Control)txtTk_ck_ds).TabIndex = 2;
		txtTk_ck_ds.UseAutoCompleteSource = false;
		lblTkckhd.AutoSize = true;
		((Control)lblTkckhd).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblTkckhd.ImeMode = (ImeMode)0;
		Label obj45 = lblTkckhd;
		location = new Point(367, 6);
		((Control)obj45).Location = location;
		((Control)lblTkckhd).Name = "lblTkckhd";
		Label obj46 = lblTkckhd;
		size = new Size(117, 13);
		((Control)obj46).Size = size;
		((Control)lblTkckhd).TabIndex = 284;
		lblTkckhd.Text = "TK chiết khấu hóa đơn";
		lblTkckhd.TextAlign = (ContentAlignment)16;
		((Control)txtTl_ck_ds).Anchor = (AnchorStyles)6;
		txtTl_ck_ds.DecimalSymbol = ".";
		((Control)txtTl_ck_ds).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtTl_ck_ds;
		location = new Point(456, 403);
		((Control)asTextNumeric3).Location = location;
		txtTl_ck_ds.Mask = "### ### ### ###.0#";
		((Control)txtTl_ck_ds).Name = "txtTl_ck_ds";
		((TextBoxBase)txtTl_ck_ds).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtTl_ck_ds;
		size = new Size(51, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtTl_ck_ds).TabIndex = 6;
		((TextBox)txtTl_ck_ds).Text = "0.00";
		((TextBox)txtTl_ck_ds).TextAlign = (HorizontalAlignment)1;
		txtTl_ck_ds.Value = 0.0;
		((Control)txtT_So_luong).Anchor = (AnchorStyles)6;
		txtT_So_luong.DecimalSymbol = ".";
		((Control)txtT_So_luong).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric5 = txtT_So_luong;
		location = new Point(407, 359);
		((Control)asTextNumeric5).Location = location;
		txtT_So_luong.Mask = "### ### ### ###.#0";
		((Control)txtT_So_luong).Name = "txtT_So_luong";
		((TextBoxBase)txtT_So_luong).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtT_So_luong;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		txtT_So_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((Control)txtT_So_luong).TabIndex = 0;
		((Control)txtT_So_luong).TabStop = false;
		((TextBox)txtT_So_luong).Text = "0.00";
		((TextBox)txtT_So_luong).TextAlign = (HorizontalAlignment)1;
		txtT_So_luong.Value = 0.0;
		((Control)txtT_tt).Anchor = (AnchorStyles)6;
		txtT_tt.DecimalSymbol = ".";
		((Control)txtT_tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric7 = txtT_tt;
		location = new Point(619, 447);
		((Control)asTextNumeric7).Location = location;
		txtT_tt.Mask = "### ### ### ###";
		((Control)txtT_tt).Name = "txtT_tt";
		((TextBoxBase)txtT_tt).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_tt;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_tt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_tt).TabIndex = 12;
		((Control)txtT_tt).TabStop = false;
		((TextBox)txtT_tt).Text = "0";
		((TextBox)txtT_tt).TextAlign = (HorizontalAlignment)1;
		txtT_tt.Value = 0.0;
		((Control)txtT_Tien_nt2).Anchor = (AnchorStyles)6;
		txtT_Tien_nt2.DecimalSymbol = ".";
		((Control)txtT_Tien_nt2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric9 = txtT_Tien_nt2;
		location = new Point(513, 359);
		((Control)asTextNumeric9).Location = location;
		txtT_Tien_nt2.Mask = "### ### ### ###";
		((Control)txtT_Tien_nt2).Name = "txtT_Tien_nt2";
		((TextBoxBase)txtT_Tien_nt2).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtT_Tien_nt2;
		size = new Size(100, 20);
		((Control)asTextNumeric10).Size = size;
		txtT_Tien_nt2.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_Tien_nt2).TabIndex = 1;
		((Control)txtT_Tien_nt2).TabStop = false;
		((TextBox)txtT_Tien_nt2).Text = "0";
		((TextBox)txtT_Tien_nt2).TextAlign = (HorizontalAlignment)1;
		txtT_Tien_nt2.Value = 0.0;
		((Control)lblT_Tt).Anchor = (AnchorStyles)6;
		lblT_Tt.AutoSize = true;
		((Control)lblT_Tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		lblT_Tt.ImeMode = (ImeMode)0;
		Label obj47 = lblT_Tt;
		location = new Point(318, 450);
		((Control)obj47).Location = location;
		((Control)lblT_Tt).Name = "lblT_Tt";
		Label obj48 = lblT_Tt;
		size = new Size(72, 13);
		((Control)obj48).Size = size;
		((Control)lblT_Tt).TabIndex = 233;
		lblT_Tt.Text = "Thanh toán";
		lblT_Tt.TextAlign = (ContentAlignment)16;
		((Control)txtT_ck).Anchor = (AnchorStyles)6;
		txtT_ck.DecimalSymbol = ".";
		((Control)txtT_ck).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric11 = txtT_ck;
		location = new Point(619, 381);
		((Control)asTextNumeric11).Location = location;
		txtT_ck.Mask = "### ### ### ###";
		((Control)txtT_ck).Name = "txtT_ck";
		((TextBoxBase)txtT_ck).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtT_ck;
		size = new Size(100, 20);
		((Control)asTextNumeric12).Size = size;
		txtT_ck.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_ck).TabIndex = 4;
		((Control)txtT_ck).TabStop = false;
		((TextBox)txtT_ck).Text = "0";
		((TextBox)txtT_ck).TextAlign = (HorizontalAlignment)1;
		txtT_ck.Value = 0.0;
		((Control)txtT_ck_ds).Anchor = (AnchorStyles)6;
		txtT_ck_ds.DecimalSymbol = ".";
		((Control)txtT_ck_ds).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric13 = txtT_ck_ds;
		location = new Point(619, 403);
		((Control)asTextNumeric13).Location = location;
		txtT_ck_ds.Mask = "### ### ### ###";
		((Control)txtT_ck_ds).Name = "txtT_ck_ds";
		((TextBoxBase)txtT_ck_ds).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtT_ck_ds;
		size = new Size(100, 20);
		((Control)asTextNumeric14).Size = size;
		txtT_ck_ds.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_ck_ds).TabIndex = 8;
		((TextBox)txtT_ck_ds).Text = "0";
		((TextBox)txtT_ck_ds).TextAlign = (HorizontalAlignment)1;
		txtT_ck_ds.Value = 0.0;
		((Control)txtT_ck_nt).Anchor = (AnchorStyles)6;
		txtT_ck_nt.DecimalSymbol = ".";
		((Control)txtT_ck_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric15 = txtT_ck_nt;
		location = new Point(513, 381);
		((Control)asTextNumeric15).Location = location;
		txtT_ck_nt.Mask = "### ### ### ###";
		((Control)txtT_ck_nt).Name = "txtT_ck_nt";
		((TextBoxBase)txtT_ck_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric16 = txtT_ck_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric16).Size = size;
		txtT_ck_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_ck_nt).TabIndex = 3;
		((Control)txtT_ck_nt).TabStop = false;
		((TextBox)txtT_ck_nt).Text = "0";
		((TextBox)txtT_ck_nt).TextAlign = (HorizontalAlignment)1;
		txtT_ck_nt.Value = 0.0;
		((Control)txtT_ck_ds_nt).Anchor = (AnchorStyles)6;
		txtT_ck_ds_nt.DecimalSymbol = ".";
		((Control)txtT_ck_ds_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric17 = txtT_ck_ds_nt;
		location = new Point(513, 403);
		((Control)asTextNumeric17).Location = location;
		txtT_ck_ds_nt.Mask = "### ### ### ###";
		((Control)txtT_ck_ds_nt).Name = "txtT_ck_ds_nt";
		((TextBoxBase)txtT_ck_ds_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric18 = txtT_ck_ds_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric18).Size = size;
		txtT_ck_ds_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_ck_ds_nt).TabIndex = 7;
		((TextBox)txtT_ck_ds_nt).Text = "0";
		((TextBox)txtT_ck_ds_nt).TextAlign = (HorizontalAlignment)1;
		txtT_ck_ds_nt.Value = 0.0;
		((Control)txtT_Tien2).Anchor = (AnchorStyles)6;
		txtT_Tien2.DecimalSymbol = ".";
		((Control)txtT_Tien2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric19 = txtT_Tien2;
		location = new Point(619, 359);
		((Control)asTextNumeric19).Location = location;
		txtT_Tien2.Mask = "### ### ### ###";
		((Control)txtT_Tien2).Name = "txtT_Tien2";
		((TextBoxBase)txtT_Tien2).ReadOnly = true;
		AsTextNumeric asTextNumeric20 = txtT_Tien2;
		size = new Size(100, 20);
		((Control)asTextNumeric20).Size = size;
		txtT_Tien2.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tien2).TabIndex = 2;
		((Control)txtT_Tien2).TabStop = false;
		((TextBox)txtT_Tien2).Text = "0";
		((TextBox)txtT_Tien2).TextAlign = (HorizontalAlignment)1;
		txtT_Tien2.Value = 0.0;
		((Control)Label7).Anchor = (AnchorStyles)6;
		Label7.AutoSize = true;
		((Control)Label7).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label7.ImeMode = (ImeMode)0;
		Label label = Label7;
		location = new Point(318, 406);
		((Control)label).Location = location;
		((Control)Label7).Name = "Label7";
		Label label2 = Label7;
		size = new Size(101, 13);
		((Control)label2).Size = size;
		((Control)Label7).TabIndex = 272;
		Label7.Text = "Chiết khấu hóa đơn";
		Label7.TextAlign = (ContentAlignment)16;
		((Control)lblT_Tien).Anchor = (AnchorStyles)6;
		lblT_Tien.AutoSize = true;
		((Control)lblT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Tien.ImeMode = (ImeMode)0;
		Label obj49 = lblT_Tien;
		location = new Point(318, 362);
		((Control)obj49).Location = location;
		((Control)lblT_Tien).Name = "lblT_Tien";
		Label obj50 = lblT_Tien;
		size = new Size(59, 13);
		((Control)obj50).Size = size;
		((Control)lblT_Tien).TabIndex = 228;
		lblT_Tien.Text = "Tổng cộng";
		lblT_Tien.TextAlign = (ContentAlignment)16;
		((Control)txtT_Thue).Anchor = (AnchorStyles)6;
		txtT_Thue.DecimalSymbol = ".";
		((Control)txtT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric21 = txtT_Thue;
		location = new Point(619, 425);
		((Control)asTextNumeric21).Location = location;
		txtT_Thue.Mask = "### ### ### ###";
		((Control)txtT_Thue).Name = "txtT_Thue";
		((TextBoxBase)txtT_Thue).ReadOnly = true;
		AsTextNumeric asTextNumeric22 = txtT_Thue;
		size = new Size(100, 20);
		((Control)asTextNumeric22).Size = size;
		txtT_Thue.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Thue).TabIndex = 10;
		((Control)txtT_Thue).TabStop = false;
		((TextBox)txtT_Thue).Text = "0";
		((TextBox)txtT_Thue).TextAlign = (HorizontalAlignment)1;
		txtT_Thue.Value = 0.0;
		((Control)txtT_thue_nt).Anchor = (AnchorStyles)6;
		txtT_thue_nt.DecimalSymbol = ".";
		((Control)txtT_thue_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric23 = txtT_thue_nt;
		location = new Point(513, 425);
		((Control)asTextNumeric23).Location = location;
		txtT_thue_nt.Mask = "### ### ### ###";
		((Control)txtT_thue_nt).Name = "txtT_thue_nt";
		((TextBoxBase)txtT_thue_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric24 = txtT_thue_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric24).Size = size;
		txtT_thue_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_thue_nt).TabIndex = 9;
		((Control)txtT_thue_nt).TabStop = false;
		((TextBox)txtT_thue_nt).Text = "0";
		((TextBox)txtT_thue_nt).TextAlign = (HorizontalAlignment)1;
		txtT_thue_nt.Value = 0.0;
		((Control)lblT_ck).Anchor = (AnchorStyles)6;
		lblT_ck.AutoSize = true;
		((Control)lblT_ck).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_ck.ImeMode = (ImeMode)0;
		Label obj51 = lblT_ck;
		location = new Point(318, 384);
		((Control)obj51).Location = location;
		((Control)lblT_ck).Name = "lblT_ck";
		Label obj52 = lblT_ck;
		size = new Size(105, 13);
		((Control)obj52).Size = size;
		((Control)lblT_ck).TabIndex = 235;
		lblT_ck.Text = "Chiết khấu mặt hàng";
		lblT_ck.TextAlign = (ContentAlignment)16;
		((Control)txtT_tt_nt).Anchor = (AnchorStyles)6;
		txtT_tt_nt.DecimalSymbol = ".";
		((Control)txtT_tt_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric25 = txtT_tt_nt;
		location = new Point(513, 447);
		((Control)asTextNumeric25).Location = location;
		txtT_tt_nt.Mask = "### ### ### ###";
		((Control)txtT_tt_nt).Name = "txtT_tt_nt";
		((TextBoxBase)txtT_tt_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric26 = txtT_tt_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric26).Size = size;
		txtT_tt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tt_nt).TabIndex = 11;
		((Control)txtT_tt_nt).TabStop = false;
		((TextBox)txtT_tt_nt).Text = "0";
		((TextBox)txtT_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tt_nt.Value = 0.0;
		((Control)lblT_Thue).Anchor = (AnchorStyles)6;
		lblT_Thue.AutoSize = true;
		((Control)lblT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Thue.ImeMode = (ImeMode)0;
		Label obj53 = lblT_Thue;
		location = new Point(318, 428);
		((Control)obj53).Location = location;
		((Control)lblT_Thue).Name = "lblT_Thue";
		Label obj54 = lblT_Thue;
		size = new Size(65, 13);
		((Control)obj54).Size = size;
		((Control)lblT_Thue).TabIndex = 232;
		lblT_Thue.Text = "Thuế GTGT";
		lblT_Thue.TextAlign = (ContentAlignment)16;
		txtGh_no.DecimalSymbol = ".";
		((Control)txtGh_no).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric27 = txtGh_no;
		location = new Point(94, 122);
		((Control)asTextNumeric27).Location = location;
		txtGh_no.Mask = "### ### ### ###";
		((Control)txtGh_no).Name = "txtGh_no";
		((TextBoxBase)txtGh_no).ReadOnly = true;
		AsTextNumeric asTextNumeric28 = txtGh_no;
		size = new Size(100, 20);
		((Control)asTextNumeric28).Size = size;
		txtGh_no.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtGh_no).TabIndex = 256;
		((Control)txtGh_no).TabStop = false;
		((TextBox)txtGh_no).Text = "0";
		((TextBox)txtGh_no).TextAlign = (HorizontalAlignment)1;
		txtGh_no.Value = 0.0;
		Label4.AutoSize = true;
		Label4.ImeMode = (ImeMode)0;
		Label label3 = Label4;
		location = new Point(9, 126);
		((Control)label3).Location = location;
		((Control)Label4).Name = "Label4";
		Label label4 = Label4;
		size = new Size(61, 13);
		((Control)label4).Size = size;
		((Control)Label4).TabIndex = 255;
		Label4.Text = "Giới hạn nợ";
		lblMa_so_thue.AutoSize = true;
		lblMa_so_thue.ImeMode = (ImeMode)0;
		Label obj55 = lblMa_so_thue;
		location = new Point(303, 59);
		((Control)obj55).Location = location;
		((Control)lblMa_so_thue).Name = "lblMa_so_thue";
		((Control)lblMa_so_thue).RightToLeft = (RightToLeft)1;
		Label obj56 = lblMa_so_thue;
		size = new Size(60, 13);
		((Control)obj56).Size = size;
		((Control)lblMa_so_thue).TabIndex = 246;
		lblMa_so_thue.Text = "Mã số thuế";
		lblMa_so_thue.TextAlign = (ContentAlignment)16;
		TextBox obj57 = txtMa_so_thue;
		location = new Point(369, 56);
		((Control)obj57).Location = location;
		((Control)txtMa_so_thue).Name = "txtMa_so_thue";
		TextBox obj58 = txtMa_so_thue;
		size = new Size(128, 19);
		((Control)obj58).Size = size;
		((Control)txtMa_so_thue).TabIndex = 4;
		lblDia_chi.AutoSize = true;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj59 = lblDia_chi;
		location = new Point(9, 38);
		((Control)obj59).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj60 = lblDia_chi;
		size = new Size(40, 13);
		((Control)obj60).Size = size;
		((Control)lblDia_chi).TabIndex = 146;
		lblDia_chi.Text = "Địa chỉ";
		TextBox obj61 = txtDia_chi_vat;
		location = new Point(94, 34);
		((Control)obj61).Location = location;
		((Control)txtDia_chi_vat).Name = "txtDia_chi_vat";
		TextBox obj62 = txtDia_chi_vat;
		size = new Size(403, 19);
		((Control)obj62).Size = size;
		((Control)txtDia_chi_vat).TabIndex = 2;
		((DataGridView)adgvDetail).AllowUserToAddRows = false;
		((DataGridView)adgvDetail).AllowUserToDeleteRows = false;
		((DataGridView)adgvDetail).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvDetail).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvDetail).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[21]
		{
			dgvcMa_vt,
			(DataGridViewColumn)dgvcTen_vt,
			(DataGridViewColumn)dgvcDvt,
			dgvcMa_kho,
			dgvcTon,
			dgvcSo_luong,
			dgvcGia_nt2,
			dgvcTien_nt2,
			dgvcTl_ck,
			dgvcTien_ck_nt,
			dgvcTs_gtgt,
			dgvcThue_gtgt_nt,
			dgvcGia2,
			dgvcTien2,
			dgvcTien_ck,
			dgvcThue_gtgt,
			dgvcGia_nt,
			dgvcTien_nt,
			dgvcGia,
			dgvcTien,
			dgvcMa_Nvkd
		});
		((Control)adgvDetail).Dock = (DockStyle)5;
		((DataGridView)adgvDetail).GridColor = SystemColors.Control;
		adgvDetail.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV3 = adgvDetail;
		location = new Point(3, 3);
		((Control)asInputDGV3).Location = location;
		((Control)adgvDetail).Name = "adgvDetail";
		val14.Alignment = (DataGridViewContentAlignment)32;
		val14.BackColor = SystemColors.Control;
		val14.Font = new Font("Microsoft Sans Serif", 7.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val14.ForeColor = SystemColors.WindowText;
		val14.SelectionBackColor = SystemColors.Highlight;
		val14.SelectionForeColor = SystemColors.HighlightText;
		val14.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail).RowHeadersDefaultCellStyle = val14;
		((DataGridView)adgvDetail).RowHeadersWidth = 35;
		((DataGridView)adgvDetail).RowTemplate.Height = 20;
		AsInputDGV asInputDGV4 = adgvDetail;
		size = new Size(718, 177);
		((Control)asInputDGV4).Size = size;
		((Control)adgvDetail).TabIndex = 1;
		dgvcMa_vt.AutoFill = true;
		dgvcMa_vt.AutoLookup = true;
		dgvcMa_vt.AutoValid = true;
		((DataGridViewColumn)dgvcMa_vt).DataPropertyName = "ma_vt";
		val15.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_vt).DefaultCellStyle = val15;
		((DataGridViewColumn)dgvcMa_vt).HeaderText = "Mã hàng";
		dgvcMa_vt.LookupCodeName = "MA_VT";
		dgvcMa_vt.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_vt).Name = "dgvcMa_vt";
		dgvcMa_vt.ReceiverValidFieldList = "ten_vt,dvt,tk_vt,tk_gv,tk_dt,tk_ck,tk_tl,tk_km,ton_kho,gia_ton,ma_thue,ma_kho";
		dgvcMa_vt.SD = true;
		dgvcMa_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_vt.ValidReturnFieldList = "ten_vt,dvt,tk_vt,tk_gv,tk_dt,tk_ck,tk_tl,tk_km,ton_kho,gia_ton,ma_thue,ma_kho,ma_vitri";
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
		val16.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_kho).DefaultCellStyle = val16;
		((DataGridViewColumn)dgvcMa_kho).HeaderText = "Kho";
		dgvcMa_kho.LookupCodeName = "MA_KHO";
		dgvcMa_kho.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_kho).Name = "dgvcMa_kho";
		dgvcMa_kho.ReceiverValidFieldList = "ten_kho";
		dgvcMa_kho.SD = true;
		dgvcMa_kho.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_kho.ValidReturnFieldList = "ten_kho";
		((DataGridViewColumn)dgvcMa_kho).Width = 70;
		((DataGridViewColumn)dgvcTon).DataPropertyName = "ton";
		val17.Alignment = (DataGridViewContentAlignment)64;
		val17.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTon).DefaultCellStyle = val17;
		((DataGridViewColumn)dgvcTon).HeaderText = "Tồn";
		dgvcTon.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTon).Name = "dgvcTon";
		((DataGridViewColumn)dgvcTon).ReadOnly = true;
		dgvcTon.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTon.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcTon).Width = 70;
		((DataGridViewColumn)dgvcSo_luong).DataPropertyName = "so_luong";
		val18.Alignment = (DataGridViewContentAlignment)64;
		val18.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).DefaultCellStyle = val18;
		((DataGridViewColumn)dgvcSo_luong).HeaderText = "Số lượng";
		dgvcSo_luong.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).Name = "dgvcSo_luong";
		dgvcSo_luong.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSo_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcSo_luong).Width = 70;
		((DataGridViewColumn)dgvcGia_nt2).DataPropertyName = "gia_nt2";
		val19.Alignment = (DataGridViewContentAlignment)64;
		val19.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt2).DefaultCellStyle = val19;
		((DataGridViewColumn)dgvcGia_nt2).HeaderText = "Giá";
		dgvcGia_nt2.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt2).Name = "dgvcGia_nt2";
		dgvcGia_nt2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia_nt2.SpecialType = Commons.NumericSpecialType.FCPrice;
		((DataGridViewColumn)dgvcGia_nt2).Width = 70;
		((DataGridViewColumn)dgvcTien_nt2).DataPropertyName = "tien_nt2";
		val20.Alignment = (DataGridViewContentAlignment)64;
		val20.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2).DefaultCellStyle = val20;
		((DataGridViewColumn)dgvcTien_nt2).HeaderText = "Tiền bán";
		dgvcTien_nt2.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2).Name = "dgvcTien_nt2";
		((DataGridViewColumn)dgvcTien_nt2).ReadOnly = true;
		dgvcTien_nt2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt2.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt2).Width = 90;
		((DataGridViewColumn)dgvcTl_ck).DataPropertyName = "tl_ck";
		val21.Alignment = (DataGridViewContentAlignment)64;
		val21.Format = "##.##";
		((DataGridViewColumn)dgvcTl_ck).DefaultCellStyle = val21;
		((DataGridViewColumn)dgvcTl_ck).HeaderText = "% CK";
		dgvcTl_ck.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTl_ck).Name = "dgvcTl_ck";
		dgvcTl_ck.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTl_ck).Width = 40;
		((DataGridViewColumn)dgvcTien_ck_nt).DataPropertyName = "tien_ck_nt";
		val22.Alignment = (DataGridViewContentAlignment)64;
		val22.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck_nt).DefaultCellStyle = val22;
		((DataGridViewColumn)dgvcTien_ck_nt).HeaderText = "CK";
		dgvcTien_ck_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck_nt).Name = "dgvcTien_ck_nt";
		((DataGridViewColumn)dgvcTien_ck_nt).ReadOnly = true;
		dgvcTien_ck_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ck_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_ck_nt).Width = 90;
		dgvcTs_gtgt.AutoFill = true;
		dgvcTs_gtgt.AutoLookup = true;
		dgvcTs_gtgt.AutoValid = true;
		((DataGridViewColumn)dgvcTs_gtgt).DataPropertyName = "ma_thue";
		val23.BackColor = SystemColors.Window;
		val23.Format = "##.##";
		((DataGridViewColumn)dgvcTs_gtgt).DefaultCellStyle = val23;
		((DataGridViewColumn)dgvcTs_gtgt).HeaderText = "% VAT";
		dgvcTs_gtgt.LookupCodeName = "MA_THUE";
		dgvcTs_gtgt.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcTs_gtgt).Name = "dgvcTs_gtgt";
		dgvcTs_gtgt.ReceiverValidFieldList = "ts_gtgt";
		((DataGridViewColumn)dgvcTs_gtgt).Resizable = (DataGridViewTriState)1;
		dgvcTs_gtgt.SD = true;
		dgvcTs_gtgt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTs_gtgt.ValidReturnFieldList = "ts_gtgt";
		((DataGridViewColumn)dgvcTs_gtgt).Width = 45;
		((DataGridViewColumn)dgvcThue_gtgt_nt).DataPropertyName = "thue_gtgt_nt";
		val24.Alignment = (DataGridViewContentAlignment)64;
		val24.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).DefaultCellStyle = val24;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = "VAT";
		dgvcThue_gtgt_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).Name = "dgvcThue_gtgt_nt";
		((DataGridViewColumn)dgvcThue_gtgt_nt).ReadOnly = true;
		dgvcThue_gtgt_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_gtgt_nt).Width = 80;
		((DataGridViewColumn)dgvcGia2).DataPropertyName = "gia2";
		val25.Alignment = (DataGridViewContentAlignment)64;
		val25.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia2).DefaultCellStyle = val25;
		((DataGridViewColumn)dgvcGia2).HeaderText = "Giá VND";
		dgvcGia2.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia2).Name = "dgvcGia2";
		((DataGridViewColumn)dgvcGia2).ReadOnly = true;
		dgvcGia2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia2.SpecialType = Commons.NumericSpecialType.ACPrice;
		((DataGridViewColumn)dgvcGia2).Width = 90;
		((DataGridViewColumn)dgvcTien2).DataPropertyName = "tien2";
		val26.Alignment = (DataGridViewContentAlignment)64;
		val26.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien2).DefaultCellStyle = val26;
		((DataGridViewColumn)dgvcTien2).HeaderText = "T. bán VND";
		dgvcTien2.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien2).Name = "dgvcTien2";
		((DataGridViewColumn)dgvcTien2).ReadOnly = true;
		dgvcTien2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien2.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien2).Width = 90;
		((DataGridViewColumn)dgvcTien_ck).DataPropertyName = "tien_ck";
		val27.Alignment = (DataGridViewContentAlignment)64;
		val27.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck).DefaultCellStyle = val27;
		((DataGridViewColumn)dgvcTien_ck).HeaderText = "CK VND";
		dgvcTien_ck.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck).Name = "dgvcTien_ck";
		((DataGridViewColumn)dgvcTien_ck).ReadOnly = true;
		dgvcTien_ck.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ck.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_ck).Width = 90;
		((DataGridViewColumn)dgvcThue_gtgt).DataPropertyName = "thue_gtgt";
		val28.Alignment = (DataGridViewContentAlignment)64;
		val28.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt).DefaultCellStyle = val28;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = "VAT VND";
		dgvcThue_gtgt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt).Name = "dgvcThue_gtgt";
		((DataGridViewColumn)dgvcThue_gtgt).ReadOnly = true;
		dgvcThue_gtgt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_gtgt).Width = 80;
		((DataGridViewColumn)dgvcGia_nt).DataPropertyName = "gia_nt";
		val29.Alignment = (DataGridViewContentAlignment)64;
		val29.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt).DefaultCellStyle = val29;
		((DataGridViewColumn)dgvcGia_nt).HeaderText = "Giá vốn";
		dgvcGia_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt).Name = "dgvcGia_nt";
		((DataGridViewColumn)dgvcGia_nt).ReadOnly = true;
		dgvcGia_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia_nt.SpecialType = Commons.NumericSpecialType.FCPrice;
		((DataGridViewColumn)dgvcGia_nt).Width = 90;
		((DataGridViewColumn)dgvcTien_nt).DataPropertyName = "tien_nt";
		val30.Alignment = (DataGridViewContentAlignment)64;
		val30.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt).DefaultCellStyle = val30;
		((DataGridViewColumn)dgvcTien_nt).HeaderText = "Tiền vốn";
		dgvcTien_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt).Name = "dgvcTien_nt";
		((DataGridViewColumn)dgvcTien_nt).ReadOnly = true;
		dgvcTien_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt).Width = 90;
		((DataGridViewColumn)dgvcGia).DataPropertyName = "gia";
		val31.Alignment = (DataGridViewContentAlignment)64;
		val31.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia).DefaultCellStyle = val31;
		((DataGridViewColumn)dgvcGia).HeaderText = "Giá vốn VND";
		dgvcGia.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia).Name = "dgvcGia";
		((DataGridViewColumn)dgvcGia).ReadOnly = true;
		dgvcGia.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcGia).Width = 90;
		((DataGridViewColumn)dgvcTien).DataPropertyName = "tien";
		val32.Alignment = (DataGridViewContentAlignment)64;
		val32.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien).DefaultCellStyle = val32;
		((DataGridViewColumn)dgvcTien).HeaderText = "T. vốn VND";
		dgvcTien.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien).Name = "dgvcTien";
		((DataGridViewColumn)dgvcTien).ReadOnly = true;
		dgvcTien.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien).Width = 90;
		dgvcMa_Nvkd.AutoFill = true;
		dgvcMa_Nvkd.AutoLookup = true;
		dgvcMa_Nvkd.AutoValid = true;
		((DataGridViewColumn)dgvcMa_Nvkd).DataPropertyName = "ma_nvkd";
		val33.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_Nvkd).DefaultCellStyle = val33;
		((DataGridViewColumn)dgvcMa_Nvkd).HeaderText = "NVKD";
		dgvcMa_Nvkd.LookupCodeName = "MA_NVKD";
		dgvcMa_Nvkd.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_Nvkd).Name = "dgvcMa_Nvkd";
		dgvcMa_Nvkd.ReceiverValidFieldList = "ten_nvkd";
		dgvcMa_Nvkd.SD = true;
		dgvcMa_Nvkd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_Nvkd.ValidReturnFieldList = "ten_nvkd";
		((DataGridViewColumn)dgvcMa_Nvkd).Width = 60;
		txtMa_Httt.AutoLookup = true;
		txtMa_Httt.AutoValid = true;
		((TextBoxBase)txtMa_Httt).BackColor = SystemColors.Info;
		((TextBox)txtMa_Httt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_Httt;
		location = new Point(94, 100);
		((Control)asTextBox9).Location = location;
		txtMa_Httt.LookupCodeName = "MA_HTTT";
		txtMa_Httt.LookupWhereCondition = "moduleid='SO'";
		((Control)txtMa_Httt).Name = "txtMa_Httt";
		txtMa_Httt.NameControl = lblTen_Httt;
		txtMa_Httt.SD = true;
		AsTextBox asTextBox10 = txtMa_Httt;
		size = new Size(75, 19);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_Httt).TabIndex = 6;
		txtMa_Httt.UseAutoCompleteSource = true;
		txtMa_Httt.ValidReturnFieldList = "ten_httt,tk,tk_thue_gtgt_ban,tk_ck";
		((Control)lblTen_Httt).Enabled = false;
		lblTen_Httt.ImeMode = (ImeMode)0;
		Label obj63 = lblTen_Httt;
		location = new Point(122, 454);
		((Control)obj63).Location = location;
		((Control)lblTen_Httt).Name = "lblTen_Httt";
		Label obj64 = lblTen_Httt;
		size = new Size(225, 13);
		((Control)obj64).Size = size;
		((Control)lblTen_Httt).TabIndex = 257;
		lblTen_Httt.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Httt).Visible = false;
		Label6.AutoSize = true;
		Label6.ImeMode = (ImeMode)0;
		Label label5 = Label6;
		location = new Point(9, 104);
		((Control)label5).Location = location;
		((Control)Label6).Name = "Label6";
		Label label6 = Label6;
		size = new Size(76, 13);
		((Control)label6).Size = size;
		((Control)Label6).TabIndex = 256;
		Label6.Text = "Mã thanh toán";
		txtDu13.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric29 = txtDu13;
		location = new Point(369, 123);
		((Control)asTextNumeric29).Location = location;
		txtDu13.Mask = "### ### ### ###";
		((Control)txtDu13).Name = "txtDu13";
		((TextBoxBase)txtDu13).ReadOnly = true;
		AsTextNumeric asTextNumeric30 = txtDu13;
		size = new Size(128, 19);
		((Control)asTextNumeric30).Size = size;
		((Control)txtDu13).TabIndex = 262;
		((Control)txtDu13).TabStop = false;
		((TextBox)txtDu13).Text = "0";
		((TextBox)txtDu13).TextAlign = (HorizontalAlignment)1;
		txtDu13.Value = 0.0;
		Label14.AutoSize = true;
		Label14.ImeMode = (ImeMode)0;
		Label label7 = Label14;
		location = new Point(299, 126);
		((Control)label7).Location = location;
		((Control)Label14).Name = "Label14";
		((Control)Label14).RightToLeft = (RightToLeft)1;
		Label label8 = Label14;
		size = new Size(64, 13);
		((Control)label8).Size = size;
		((Control)Label14).TabIndex = 261;
		Label14.Text = "Dư hiện thời";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).DataPropertyName = "ten_vt";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).HeaderText = "Tên hàng";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).ReadOnly = true;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Width = 160;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).DataPropertyName = "ma_kho";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).HeaderText = "Kho";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Name = "DataGridViewTextBoxColumn2";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).ReadOnly = true;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Width = 60;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).DataPropertyName = "ten_vt";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Frozen = true;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).HeaderText = "Tên vật tư";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Name = "DataGridViewTextBoxColumn3";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).ReadOnly = true;
		DataGridViewTextBoxColumn3.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Width = 170;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).DataPropertyName = "ma_vt";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).HeaderText = "Mã hàng";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Name = "DataGridViewTextBoxColumn4";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).ReadOnly = true;
		DataGridViewTextBoxColumn4.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Visible = false;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Width = 70;
		txtSo_seri_mhd.CharacterCasing = (CharacterCasing)1;
		((Control)txtSo_seri_mhd).Enabled = false;
		TextBox obj65 = txtSo_seri_mhd;
		location = new Point(164, 431);
		((Control)obj65).Location = location;
		((Control)txtSo_seri_mhd).Name = "txtSo_seri_mhd";
		TextBox obj66 = txtSo_seri_mhd;
		size = new Size(78, 19);
		((Control)obj66).Size = size;
		((Control)txtSo_seri_mhd).TabIndex = 6;
		((Control)txtSo_seri_mhd).Visible = false;
		lblSo_seri_mhd.AutoSize = true;
		((Control)lblSo_seri_mhd).Enabled = false;
		Label obj67 = lblSo_seri_mhd;
		location = new Point(71, 435);
		((Control)obj67).Location = location;
		((Control)lblSo_seri_mhd).Name = "lblSo_seri_mhd";
		Label obj68 = lblSo_seri_mhd;
		size = new Size(65, 13);
		((Control)obj68).Size = size;
		((Control)lblSo_seri_mhd).TabIndex = 264;
		lblSo_seri_mhd.Text = "Ký hiệu mẫu";
		((Control)lblSo_seri_mhd).Visible = false;
		((Control)cmdThanh_toan).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdThanh_toan).Image = (Image)componentResourceManager.GetObject("cmdThanh_toan.Image");
		((ButtonBase)cmdThanh_toan).ImageAlign = (ContentAlignment)16;
		Button obj69 = cmdThanh_toan;
		location = new Point(143, 477);
		((Control)obj69).Location = location;
		((Control)cmdThanh_toan).Name = "cmdThanh_toan";
		Button obj70 = cmdThanh_toan;
		size = new Size(64, 23);
		((Control)obj70).Size = size;
		((Control)cmdThanh_toan).TabIndex = 15;
		((ButtonBase)cmdThanh_toan).Text = "Th&u tiền";
		((ButtonBase)cmdThanh_toan).TextAlign = (ContentAlignment)64;
		TextBox obj71 = txtSo_px;
		location = new Point(638, 78);
		((Control)obj71).Location = location;
		((Control)txtSo_px).Name = "txtSo_px";
		TextBox obj72 = txtSo_px;
		size = new Size(78, 19);
		((Control)obj72).Size = size;
		((Control)txtSo_px).TabIndex = 11;
		lblSo_px.AutoSize = true;
		Label obj73 = lblSo_px;
		location = new Point(536, 82);
		((Control)obj73).Location = location;
		((Control)lblSo_px).Name = "lblSo_px";
		Label obj74 = lblSo_px;
		size = new Size(72, 13);
		((Control)obj74).Size = size;
		((Control)lblSo_px).TabIndex = 264;
		lblSo_px.Text = "Số phiếu xuất";
		cboHttt.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboHttt).FormattingEnabled = true;
		cboHttt.Items.AddRange(new object[3] { "TM/CK", "TM", "CK" });
		ComboBox obj75 = cboHttt;
		location = new Point(369, 100);
		((Control)obj75).Location = location;
		((Control)cboHttt).Name = "cboHttt";
		ComboBox obj76 = cboHttt;
		size = new Size(128, 21);
		((Control)obj76).Size = size;
		((Control)cboHttt).TabIndex = 7;
		Label1.AutoSize = true;
		Label label9 = Label1;
		location = new Point(259, 103);
		((Control)label9).Location = location;
		((Control)Label1).Name = "Label1";
		((Control)Label1).RightToLeft = (RightToLeft)1;
		Label label10 = Label1;
		size = new Size(107, 13);
		((Control)label10).Size = size;
		((Control)Label1).TabIndex = 266;
		Label1.Text = "Hình thức thanh toán";
		((Control)chkCk_st).Anchor = (AnchorStyles)6;
		((ButtonBase)chkCk_st).AutoSize = true;
		chkCk_st.Checked = false;
		AsCheckBox asCheckBox3 = chkCk_st;
		location = new Point(3, 384);
		((Control)asCheckBox3).Location = location;
		((Control)chkCk_st).Name = "chkCk_st";
		AsCheckBox asCheckBox4 = chkCk_st;
		size = new Size(121, 17);
		((Control)asCheckBox4).Size = size;
		((Control)chkCk_st).TabIndex = 4;
		((Control)chkCk_st).TabStop = false;
		((ButtonBase)chkCk_st).Text = "Chiết khấu sau thuế";
		chkCk_st.TextValue = "0";
		((ButtonBase)chkCk_st).UseVisualStyleBackColor = true;
		((Control)cmdChon_dh).Enabled = false;
		((ButtonBase)cmdChon_dh).ImageAlign = (ContentAlignment)16;
		Button obj77 = cmdChon_dh;
		location = new Point(601, 147);
		((Control)obj77).Location = location;
		((Control)cmdChon_dh).Name = "cmdChon_dh";
		Button obj78 = cmdChon_dh;
		size = new Size(118, 23);
		((Control)obj78).Size = size;
		((Control)cmdChon_dh).TabIndex = 1;
		((ButtonBase)cmdChon_dh).Text = "Chọn đơn hàng";
		((Control)chkGia_st).Anchor = (AnchorStyles)6;
		((ButtonBase)chkGia_st).AutoSize = true;
		chkGia_st.Checked = false;
		((Control)chkGia_st).Enabled = false;
		AsCheckBox asCheckBox5 = chkGia_st;
		location = new Point(3, 405);
		((Control)asCheckBox5).Location = location;
		((Control)chkGia_st).Name = "chkGia_st";
		AsCheckBox asCheckBox6 = chkGia_st;
		size = new Size(107, 17);
		((Control)asCheckBox6).Size = size;
		((Control)chkGia_st).TabIndex = 5;
		((Control)chkGia_st).TabStop = false;
		((ButtonBase)chkGia_st).Text = "Giá bán sau thuế";
		chkGia_st.TextValue = "0";
		((ButtonBase)chkGia_st).UseVisualStyleBackColor = true;
		((Control)chkGia_st).Visible = false;
		TextBox obj79 = txtTen_kh;
		location = new Point(175, 11);
		((Control)obj79).Location = location;
		((Control)txtTen_kh).Name = "txtTen_kh";
		TextBox obj80 = txtTen_kh;
		size = new Size(322, 19);
		((Control)obj80).Size = size;
		((Control)txtTen_kh).TabIndex = 1;
		size = new Size(732, 525);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)chkGia_st);
		((Control)this).Controls.Add((Control)(object)cmdChon_dh);
		((Control)this).Controls.Add((Control)(object)chkCk_st);
		((Control)this).Controls.Add((Control)(object)cmdThanh_toan);
		((Control)this).Controls.Add((Control)(object)txtSo_seri_mhd);
		((Control)this).Controls.Add((Control)(object)txtTl_ck_ds);
		((Control)this).Controls.Add((Control)(object)lblSo_seri_mhd);
		((Control)this).Controls.Add((Control)(object)txtT_So_luong);
		((Control)this).Controls.Add((Control)(object)txtT_tt);
		((Control)this).Controls.Add((Control)(object)txtT_Tien_nt2);
		((Control)this).Controls.Add((Control)(object)lblT_Tt);
		((Control)this).Controls.Add((Control)(object)txtT_ck);
		((Control)this).Controls.Add((Control)(object)lblTen_Httt);
		((Control)this).Controls.Add((Control)(object)txtT_ck_ds);
		((Control)this).Controls.Add((Control)(object)txtT_ck_nt);
		((Control)this).Controls.Add((Control)(object)txtT_ck_ds_nt);
		((Control)this).Controls.Add((Control)(object)chkGia_dd);
		((Control)this).Controls.Add((Control)(object)txtT_Tien2);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)lblT_Tien);
		((Control)this).Controls.Add((Control)(object)txtT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_thue_nt);
		((Control)this).Controls.Add((Control)(object)lblT_Thue);
		((Control)this).Controls.Add((Control)(object)lblT_ck);
		((Control)this).Controls.Add((Control)(object)txtT_tt_nt);
		dgvDetail = adgvDetail;
		((Control)this).Font = new Font("Microsoft Sans Serif", 7.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmSoVchSO3";
		((Form)this).Text = "frmSoVchSO3";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_ck, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_thue_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien2, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkGia_dd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck_ds_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck_ds, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen_Httt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien_nt2, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_So_luong, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblSo_seri_mhd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtTl_ck_ds, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtSo_seri_mhd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdThanh_toan, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkCk_st, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdChon_dh, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkGia_st, 0);
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
		((Control)tabHach_toan).ResumeLayout(false);
		((Control)SplitContainerHachToan.Panel1).ResumeLayout(false);
		((Control)SplitContainerHachToan.Panel2).ResumeLayout(false);
		((Control)SplitContainerHachToan.Panel2).PerformLayout();
		((Control)SplitContainerHachToan).ResumeLayout(false);
		((ISupportInitialize)adgvHach_toan).EndInit();
		((ISupportInitialize)adgvDetail).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cboMa_NT_SelectedValueChanged(object sender, EventArgs e)
	{
		if (!IsLoading)
		{
			RefreshDGVInput();
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				RefreshValueByMa_Nt();
				txtTy_gia_ValueChanged(null, null);
			}
		}
	}

	private void txtMa_Kh_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if ((base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !((TextBoxBase)txtMa_Kh).ReadOnly && ((Control)txtMa_Kh).Enabled && ((Control)txtMa_Kh).Visible && e.ValidatedRow != null) || 1 == 0)
		{
			txtTen_kh.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ten_kh"]), isNum: false));
			txtDia_chi_vat.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["dia_chi"]), isNum: false));
			txtNguoi_Gd.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["nguoi_gd"]), isNum: false));
			txtMa_so_thue.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_so_thue"]), isNum: false));
			((TextBox)txtMa_Httt).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["MA_HTTT"]), isNum: false));
			txtMa_Httt.ForcedValid();
			txtGh_no.Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["gh_no"]), isNum: true));
			f_isGetKhInfo = true;
			GetKhInfo();
		}
	}

	private void txtMa_Httt_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if ((base.ActionMode != Commons.ApplicationMode.VIEW_MODE && e.ValidatedRow != null && !IsValidateCalledFromValidData) || 1 == 0)
		{
			((TextBox)txtTk_pt).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			((TextBox)txtTk_thue).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_ban"]), isNum: false));
			((TextBox)txtTk_ck_ds).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_ck"]), isNum: false));
			txtTk_pt.ForcedValid();
			txtTk_thue.ForcedValid();
			CurrentPHRow["Tk_pt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			CurrentPHRow["Tk_thue"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_ban"]), isNum: false));
			CurrentPHRow["Tk_ck_ds"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_ck"]), isNum: false));
			txtDu13.Value = Commons.GetDuArkh(((TextBox)txtMa_Kh).Text, ((TextBox)txtTk_pt).Text, Conversions.ToDate(txtNgay_Ct.Value));
		}
	}

	private void txtTy_gia_ValueChanged(object sender, EventArgs e)
	{
		if ((!base.IsLoading && base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !IsValidateCalledFromValidData) || 1 == 0)
		{
			V_Ty_Gia();
		}
	}

	private void adgvDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
	{
		if ((ActionMode == Commons.ApplicationMode.VIEW_MODE || CTTable == null || e.RowIndex < 0 || base.IsLoading) ? true : false)
		{
			return;
		}
		DataRowView currentCTRowView = CurrentCTRowView;
		string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
		if (Operators.CompareString(name, ((DataGridViewColumn)dgvcSo_luong).Name, false) == 0 && ((Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(currentCTRowView["ma_vt"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(currentCTRowView["ma_kho"]), isNum: false), (object)"", false) && ActionMode == Commons.ApplicationMode.ADD_MODE) ? true : false))
		{
			double result = 0.0;
			if (double.TryParse(e.FormattedValue.ToString(), out result) && Operators.ConditionalCompareObjectGreater((object)result, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(currentCTRowView["ton"]), isNum: true), false))
			{
				((CancelEventArgs)(object)e).Cancel = !Commons.ProcessLackOfInventory2Issue();
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_nt2).Name, false) == 0)
			{
				V_Gia_Nt2(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt2).Name, false) == 0)
			{
				V_Tien_Nt2(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien2).Name, false) == 0)
			{
				V_Tien2(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTl_ck).Name, false) == 0)
			{
				V_Tl_Ck(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_ck_nt).Name, false) == 0)
			{
				V_Tien_Ck_Nt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_ck).Name, false) == 0)
			{
				V_Tien_Ck(currentCTRowView);
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia2).Name, false) == 0)
			{
				V_Gia2(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_nt).Name, false) == 0)
			{
				V_Gia_Nt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt).Name, false) == 0)
			{
				V_Tien_nt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien).Name, false) == 0)
			{
				V_tien(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia).Name, false) == 0)
			{
				V_Gia(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_vt).Name, false) == 0)
			{
				V_Ma_Vt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kho).Name, false) == 0)
			{
				V_Ma_Kho(currentCTRowView);
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
		DataRowView currentCTRowView = CurrentCTRowView;
		try
		{
			object obj = null;
			DataGridViewCell currentCell = ((DataGridView)adgvDetail).CurrentCell;
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt2).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Nt2(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien2).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien2(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia2).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Gia2(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Nt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Gia_nt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Gia(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_ck_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Ck_Nt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Thue_Gtgt_Nt(currentCTRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_ck).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Ck(currentCTRowView);
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_Nvkd).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(currentCTRowView["ten_nvkd"]);
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

	private void adgvHach_toan_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (CTTable != null && !base.IsLoading && 0 == 0)
		{
			DataRowView currentCTRowView = CurrentCTRowView;
			object obj = null;
			string name = ((DataGridView)adgvHach_toan).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_dt).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(currentCTRowView["Ten_Tk_dt"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_vt).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(currentCTRowView["Ten_Tk_vt"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_gv).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(currentCTRowView["Ten_Tk_gv"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_ck).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(currentCTRowView["Ten_Tk_ck"]);
			}
			obj = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(obj), isNum: false));
			((ToolStripItem)tsslInfo).Text = Conversions.ToString(obj);
		}
	}

	private void txtTl_ck_ds_ValueChanged(object sender, EventArgs e)
	{
		if ((!base.IsLoading && base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !IsValidateCalledFromValidData) || 1 == 0)
		{
			Calc_Ck_ds();
			UpdateList();
		}
	}

	private void txtT_ck_ds_nt_ValueChanged(object sender, EventArgs e)
	{
		if ((base.IsLoading || base.ActionMode == Commons.ApplicationMode.VIEW_MODE || IsValidateCalledFromValidData) ? true : false)
		{
			return;
		}
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			AsTextNumeric asTextNumeric = txtT_ck_ds;
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtT_ck_ds_nt.Value), isNum: true), txtTy_gia.Value),
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
		PhanBoChietKhauDoanhSo();
		UpdateList();
	}

	private void txtT_ck_ds_ValueChanged(object sender, EventArgs e)
	{
		if ((!base.IsLoading && base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !IsValidateCalledFromValidData) || 1 == 0)
		{
			PhanBoChietKhauDoanhSo();
			UpdateList();
		}
	}

	private void chkCk_st_CheckedChanged(object sender, EventArgs e)
	{
		if (base.ActionMode == Commons.ApplicationMode.VIEW_MODE || ((Operators.ConditionalCompareObjectEqual(txtT_ck_ds.Value, (object)0, false) && Operators.ConditionalCompareObjectEqual(txtT_ck_ds_nt.Value, (object)0, false)) ? true : false))
		{
			return;
		}
		foreach (DataRowView item in base.CT1Voucher)
		{
			Calc_ChietKhau(item);
			Calc_Thue_gtgt(item);
			Calc_ThanhToan(item);
		}
		UpdateList();
		Calc_Ck_ds();
		UpdateList();
	}

	private void chkGia_st_CheckedChanged(object sender, EventArgs e)
	{
		if ((base.IsLoading || base.ActionMode == Commons.ApplicationMode.VIEW_MODE || IsValidateCalledFromValidData) ? true : false)
		{
			return;
		}
		foreach (DataRowView item in base.CT1Voucher)
		{
			Calc_ChietKhau(item);
			Calc_Thue_gtgt(item);
			Calc_ThanhToan(item);
		}
		UpdateList();
	}

	private void adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged(object sender, SetDependentFieldsWhenCellValueChangedEventArgs e)
	{
		if ((!base.MyVoucherInfo.ct_carry_field_list.ToUpper().Contains("MA_KHO") || ((DataGridViewCellEventArgs)e).RowIndex <= 0) && 0 == 0 && ((e.ValidatedRow != null && ((DataGridView)adgvDetail).Columns[((DataGridViewCellEventArgs)e).ColumnIndex].Name.Equals(((DataGridViewColumn)dgvcMa_vt).Name) && dgvcMa_vt.ValidReturnFieldList.Contains("ma_kho") && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_kho"]), isNum: false), (object)"", false)) ? true : false))
		{
			((DataGridView)dgvDetail).AutoResizeColumn(((DataGridViewBand)dgvcMa_kho).Index);
			DataRow pDrw = null;
			if (Commons.ValidMa(ref pDrw, "MA_KHO", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentCTRowView["ma_kho"]), isNum: false)), "", "kho_dl,tk_dl", pSd: true) && ((Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)true, false) && Operators.ConditionalCompareObjectNotEqual(pDrw["tk_dl"], (object)"", false)) ? true : false))
			{
				CurrentCTRowView["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["tk_dl"]);
			}
		}
	}

	private void cmdThanh_toan_Click(object sender, EventArgs e)
	{
		Thanh_toan();
	}

	private bool W_Ma_Vt(DataRowView oDv)
	{
		return Conversions.ToBoolean((!Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["stt_rec_px"]), isNum: false), (object)"", false)) || !Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["stt_rec_dh"]), isNum: false), (object)"", false))) ? ((object)false) : ((object)true));
	}

	private bool W_Tien_Nt2(DataRowView oDv)
	{
		return true;
	}

	private bool W_Tien2(DataRowView oDv)
	{
		return true;
	}

	private bool W_Gia2(DataRowView oDv)
	{
		return true;
	}

	private bool W_Tien_Nt(DataRowView oDv)
	{
		return Conversions.ToBoolean((Conversions.ToBoolean(chkGia_dd.Checked) || Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia_ton"]), isNum: true), (object)"4", false))) ? ((object)true) : ((object)false));
	}

	private bool W_Gia_nt(DataRowView oDv)
	{
		return Conversions.ToBoolean((Conversions.ToBoolean(chkGia_dd.Checked) || Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia_ton"]), isNum: true), (object)"4", false))) ? ((object)true) : ((object)false));
	}

	private bool W_Tien(DataRowView oDv)
	{
		return Conversions.ToBoolean((Conversions.ToBoolean(chkGia_dd.Checked) || Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia_ton"]), isNum: true), (object)"4", false))) ? ((object)true) : ((object)false));
	}

	private bool W_Gia(DataRowView oDv)
	{
		return Conversions.ToBoolean((Conversions.ToBoolean(chkGia_dd.Checked) || Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia_ton"]), isNum: true), (object)"4", false))) ? ((object)true) : ((object)false));
	}

	private bool W_Tien_Ck_Nt(DataRowView oDv)
	{
		return true;
	}

	private bool W_Thue_Gtgt_Nt(DataRowView oDv)
	{
		return true;
	}

	private bool W_Tien_Ck(DataRowView oDv)
	{
		return true;
	}

	private bool W_Thue_Gtgt(DataRowView oDv)
	{
		return true;
	}

	private void V_Ma_Vt(DataRowView oDv)
	{
		if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			if (Operators.CompareString(AsiaErp.Framework.Environment.GetSOConfiguration().lay_gia_ban, "0", false) != 0)
			{
				oDv["Gia_Nt2"] = SOCommon.Get_GiaBan(Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_vt"]), isNum: false)), cboMa_NT.MA_NT, Conversions.ToDate(txtNgay_Ct.Value));
				V_Gia_Nt2(oDv);
			}
			DataRow pDrw = null;
			if (Commons.ValidMa(ref pDrw, "MA_THUE", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_thue"]), isNum: false)), "", "ts_gtgt", pSd: true))
			{
				oDv["ts_gtgt"] = RuntimeHelpers.GetObjectValue(pDrw["ts_gtgt"]);
			}
			ReCalcTonKhoTucThoi(oDv);
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		Calc_TienHang(oDv);
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
		Calc_ThanhToan(oDv);
		Calc_TienVon(oDv);
		Calc_So_luong_qd(oDv);
		UpdateList();
	}

	private void V_Gia_Nt3(DataRowView oDv)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		int num = 0;
		if ((int)((CheckBox)chkGia_st).CheckState == 1)
		{
			num = 1;
		}
		if (num == 1)
		{
			Calc_Tien3(oDv);
			if (!Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["so_luong"]), isNum: true), (object)0, false))
			{
				int num2 = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
				Type? typeFromHandle = typeof(Math);
				object[] array = new object[3]
				{
					Operators.DivideObject(Operators.MultiplyObject((object)100, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["tien_nt3"]), isNum: true)), Operators.AddObject((object)100, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ts_gtgt"]), isNum: true))),
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
				oDv["Tien_nt2"] = RuntimeHelpers.GetObjectValue(obj);
				oDv["Thue_gtgt_nt"] = Operators.SubtractObject(oDv["tien_nt3"], oDv["tien_nt2"]);
				bool flag = Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0;
				oDv["Gia_nt2"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[3]
				{
					Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
					RuntimeHelpers.GetObjectValue(Interaction.IIf(flag, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia_Nt)),
					MidpointRounding.AwayFromZero
				}, (string[])null, (Type[])null, (bool[])null));
				V_Tien_Nt2(oDv);
			}
		}
		else
		{
			oDv["Gia_nt2"] = RuntimeHelpers.GetObjectValue(oDv["Gia_nt3"]);
			V_Gia_Nt2(oDv);
		}
	}

	private void V_Tien_Nt3(DataRowView oDv)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		int num = 0;
		if ((int)((CheckBox)chkGia_st).CheckState == 1)
		{
			num = 1;
		}
		if (num == 1)
		{
			Calc_Tien3(oDv);
			if (!Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["so_luong"]), isNum: true), (object)0, false))
			{
				int num2 = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
				Type? typeFromHandle = typeof(Math);
				object[] array = new object[3]
				{
					Operators.DivideObject(Operators.MultiplyObject((object)100, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["tien_nt3"]), isNum: true)), Operators.AddObject((object)100, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ts_gtgt"]), isNum: true))),
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
				oDv["Tien_nt2"] = RuntimeHelpers.GetObjectValue(obj);
				bool flag = Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0;
				oDv["Gia_nt2"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[3]
				{
					Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
					RuntimeHelpers.GetObjectValue(Interaction.IIf(flag, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia_Nt)),
					MidpointRounding.AwayFromZero
				}, (string[])null, (Type[])null, (bool[])null));
				V_Tien_Nt2(oDv);
			}
		}
		else
		{
			oDv["Tien_nt2"] = RuntimeHelpers.GetObjectValue(oDv["Tien_nt3"]);
			V_Tien_Nt2(oDv);
		}
	}

	private void V_Gia_Nt2(DataRowView oDv)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		Calc_GiaBan(oDv);
		Calc_TienHang(oDv);
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
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Gia2(DataRowView oDv)
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia2"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia2"]), isNum: true)),
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
			oDv["Tien2"] = RuntimeHelpers.GetObjectValue(obj);
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
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien_Nt2(DataRowView oDv)
	{
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Invalid comparison between Unknown and I4
		bool flag = Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0;
		if (flag)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt2"]), isNum: true)),
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
			oDv["Tien2"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt2"]), isNum: true), txtTy_gia.Value),
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
			oDv["Tien2"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia2"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia2"]), isNum: true)),
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
			oDv["Tien2"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_nt2"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true), (object)0, false)) ? true : false)
		{
			oDv["Gia_nt2"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
				RuntimeHelpers.GetObjectValue(Interaction.IIf(flag, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia_Nt)),
				MidpointRounding.AwayFromZero
			}, (string[])null, (Type[])null, (bool[])null));
			Calc_GiaBan(oDv);
		}
		if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			if (Operators.ConditionalCompareObjectNotEqual(txtTl_ck_ds.Value, (object)0, false))
			{
				string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", base.CurrentPHRow["Stt_Rec"]), (object)"'"));
				txtT_Tien_nt2.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_nt2)", filter));
				txtT_Tien2.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien2)", filter));
				int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
				AsTextNumeric asTextNumeric = txtT_ck_ds_nt;
				Type? typeFromHandle4 = typeof(Math);
				object[] array = new object[3]
				{
					Operators.DivideObject(Operators.MultiplyObject(txtT_Tien_nt2.Value, txtTl_ck_ds.Value), (object)100),
					num,
					MidpointRounding.AwayFromZero
				};
				object[] array10 = array;
				bool[] array5 = new bool[3] { false, true, false };
				object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array5);
				if (array5[1])
				{
					num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj4);
				AsTextNumeric asTextNumeric2 = txtT_ck_ds;
				Type? typeFromHandle5 = typeof(Math);
				object[] array3 = new object[3]
				{
					Operators.DivideObject(Operators.MultiplyObject(txtT_Tien2.Value, txtTl_ck_ds.Value), (object)100),
					null,
					null
				};
				object[] array11 = array3;
				SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array11[1] = sIConfiguration.Round;
				array3[2] = MidpointRounding.AwayFromZero;
				array = array3;
				object[] array12 = array;
				array5 = new bool[3] { false, true, false };
				object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array12, (string[])null, (Type[])null, array5);
				if (array5[1])
				{
					sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				asTextNumeric2.Value = RuntimeHelpers.GetObjectValue(obj5);
			}
			PhanBoChietKhauDoanhSo();
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
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien2(DataRowView oDv)
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Invalid comparison between Unknown and I4
		if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia2"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true), (object)0, false)) ? true : false)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
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
			oDv["Gia2"] = RuntimeHelpers.GetObjectValue(obj);
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
		Calc_ThanhToan(oDv);
		UpdateList();
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
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien_Ck_Nt(DataRowView oDv)
	{
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Invalid comparison between Unknown and I4
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_nt"]), isNum: true)),
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
			oDv["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj);
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
			oDv["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj3);
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
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien_Ck(DataRowView oDv)
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
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Gia_Nt(DataRowView oDv)
	{
		Calc_GiaVon(oDv);
		Calc_TienVon(oDv);
		UpdateList();
	}

	private void V_Gia(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)),
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
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), txtTy_gia.Value),
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
		UpdateList();
	}

	private void V_Tien_nt(DataRowView oDv)
	{
		bool flag = Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0;
		if (flag)
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
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)),
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
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_nt"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true), (object)0, false)) ? true : false)
		{
			oDv["Gia_nt"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
				RuntimeHelpers.GetObjectValue(Interaction.IIf(flag, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia_Nt)),
				MidpointRounding.AwayFromZero
			}, (string[])null, (Type[])null, (bool[])null));
			Calc_GiaVon(oDv);
		}
		UpdateList();
	}

	private void V_tien(DataRowView oDv)
	{
		if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true), (object)0, false)) ? true : false)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
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
			oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj);
		}
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
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Invalid comparison between Unknown and I4
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
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck_ds"]), isNum: true))), (object)100),
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

	private void Calc_GiaBan(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt2"]), isNum: true), txtTy_gia.Value),
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
			oDv["Gia2"] = RuntimeHelpers.GetObjectValue(obj);
		}
	}

	private void Calc_GiaVon(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj);
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
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt2"]), isNum: true), Operators.MultiplyObject((object)num2, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true)))), (object)100),
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
			oDv["Tien_Ck_Nt"] = RuntimeHelpers.GetObjectValue(obj);
		}
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_nt"]), isNum: true)),
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
			oDv["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true), Operators.MultiplyObject((object)num2, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)))), (object)100),
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
			oDv["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj4);
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
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt2"]), isNum: true), Operators.MultiplyObject((object)num2, Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck_ds_Nt"]), isNum: true))))), (object)100),
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
			Type? typeFromHandle3 = typeof(Math);
			array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true), Operators.MultiplyObject((object)num2, Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck_ds"]), isNum: true))))), (object)100),
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
			double num3 = Conversions.ToDouble(obj3);
			if (num3 != 0.0)
			{
				oDv["Thue_Gtgt"] = num3;
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
		if (num2 == 0)
		{
			Calc_ChietKhau(oDv);
		}
	}

	private void Calc_ThanhToan(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck_ds_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true)),
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
		SIConfiguration sIConfiguration;
		object[] array5;
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
			oDv["Tt"] = RuntimeHelpers.GetObjectValue(obj2);
			return;
		}
		Type? typeFromHandle3 = typeof(Math);
		array = new object[3]
		{
			Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck_ds"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)),
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
			oDv["Tt"] = num2;
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tt_Nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Tt"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	private void Calc_TienHang(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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
			oDv["Gia2"] = RuntimeHelpers.GetObjectValue(obj);
		}
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt2"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt2"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array6 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien_Nt2"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt2"]), isNum: true)),
				null,
				null
			};
			object[] array7 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array7[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array8 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien2"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia2"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia2"]), isNum: true)),
				null,
				null
			};
			object[] array9 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array10 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien2"] = RuntimeHelpers.GetObjectValue(obj4);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle5 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt2"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array11 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array11[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array12 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array12, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien2"] = RuntimeHelpers.GetObjectValue(obj5);
		}
		if (ActionMode == Commons.ApplicationMode.VIEW_MODE)
		{
			return;
		}
		if (Operators.ConditionalCompareObjectNotEqual(txtTl_ck_ds.Value, (object)0, false))
		{
			string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", base.CurrentPHRow["Stt_Rec"]), (object)"'"));
			txtT_Tien_nt2.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_nt2)", filter));
			txtT_Tien2.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien2)", filter));
			AsTextNumeric asTextNumeric = txtT_ck_ds_nt;
			Type? typeFromHandle6 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(txtT_Tien_nt2.Value, txtTl_ck_ds.Value), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array13 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array13, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj6);
			AsTextNumeric asTextNumeric2 = txtT_ck_ds;
			Type? typeFromHandle7 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(txtT_Tien2.Value, txtTl_ck_ds.Value), (object)100),
				null,
				null
			};
			object[] array14 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array14[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			array = array3;
			object[] array15 = array;
			array5 = new bool[3] { false, true, false };
			object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle7, "Round", array15, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			asTextNumeric2.Value = RuntimeHelpers.GetObjectValue(obj7);
		}
		PhanBoChietKhauDoanhSo();
	}

	private void Calc_Tien3(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt3"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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
			oDv["Gia3"] = RuntimeHelpers.GetObjectValue(obj);
		}
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt3"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt3"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array6 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien_Nt3"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt3"]), isNum: true)),
				null,
				null
			};
			object[] array7 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array7[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array8 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien3"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia3"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia3"]), isNum: true)),
				null,
				null
			};
			object[] array9 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array10 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien3"] = RuntimeHelpers.GetObjectValue(obj4);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle5 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt3"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array11 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array11[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array12 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array12, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien3"] = RuntimeHelpers.GetObjectValue(obj5);
		}
	}

	private void Calc_TienVon(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true)),
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
		}
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array = new object[3]
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
			bool[] array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)),
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
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	private void Calc_So_luong_qd(DataRowView oDv)
	{
		oDv["so_luong_qd"] = RuntimeHelpers.GetObjectValue(oDv["so_luong"]);
	}

	private void V_Ty_Gia()
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			object[] array3;
			SIConfiguration sIConfiguration;
			object[] array;
			bool[] array5;
			if (CT1Voucher != null)
			{
				foreach (DataRowView item in CT1Voucher)
				{
					if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
					{
						Type? typeFromHandle = typeof(Math);
						array = new object[3]
						{
							RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt2"]), isNum: true)),
							null,
							null
						};
						object[] array2 = array;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array2[1] = sIConfiguration.Round_Gia;
						array[2] = MidpointRounding.AwayFromZero;
						array3 = array;
						object[] array4 = array3;
						array5 = new bool[3] { false, true, false };
						object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
						}
						item["gia2"] = RuntimeHelpers.GetObjectValue(obj);
						Type? typeFromHandle2 = typeof(Math);
						array3 = new object[3]
						{
							RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt2"]), isNum: true)),
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
						item["Tien2"] = RuntimeHelpers.GetObjectValue(obj2);
						Type? typeFromHandle3 = typeof(Math);
						array3 = new object[3]
						{
							RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Ck_Nt"]), isNum: true)),
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
						item["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj3);
						Type? typeFromHandle4 = typeof(Math);
						array3 = new object[3]
						{
							RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_nt"]), isNum: true)),
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
						item["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj4);
						Type? typeFromHandle5 = typeof(Math);
						array3 = new object[3]
						{
							RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt"]), isNum: true)),
							null,
							null
						};
						object[] array12 = array3;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array12[1] = sIConfiguration.Round_Gia;
						array3[2] = MidpointRounding.AwayFromZero;
						array = array3;
						object[] array13 = array;
						array5 = new bool[3] { false, true, false };
						object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array13, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						item["gia"] = RuntimeHelpers.GetObjectValue(obj5);
						Type? typeFromHandle6 = typeof(Math);
						array3 = new object[3]
						{
							RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt"]), isNum: true)),
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
						item["Tien"] = RuntimeHelpers.GetObjectValue(obj6);
					}
					else
					{
						if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
						{
							Type? typeFromHandle7 = typeof(Math);
							array3 = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt2"]), isNum: true), txtTy_gia.Value),
								null,
								null
							};
							object[] array16 = array3;
							sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
							array16[1] = sIConfiguration.Round_Gia;
							array3[2] = MidpointRounding.AwayFromZero;
							array = array3;
							object[] array17 = array;
							array5 = new bool[3] { false, true, false };
							object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle7, "Round", array17, (string[])null, (Type[])null, array5);
							if (array5[1])
							{
								sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
							}
							item["gia2"] = RuntimeHelpers.GetObjectValue(obj7);
						}
						if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia2"]), isNum: true)), (object)0, false))
						{
							Type? typeFromHandle8 = typeof(Math);
							array3 = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia2"]), isNum: true)),
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
							item["Tien2"] = RuntimeHelpers.GetObjectValue(obj8);
						}
						else
						{
							Type? typeFromHandle9 = typeof(Math);
							array3 = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_nt2"]), isNum: true), txtTy_gia.Value),
								null,
								null
							};
							object[] array20 = array3;
							sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
							array20[1] = sIConfiguration.Round;
							array3[2] = MidpointRounding.AwayFromZero;
							array = array3;
							object[] array21 = array;
							array5 = new bool[3] { false, true, false };
							object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle9, "Round", array21, (string[])null, (Type[])null, array5);
							if (array5[1])
							{
								sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
							}
							item["Tien2"] = RuntimeHelpers.GetObjectValue(obj9);
						}
						if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
						{
							Type? typeFromHandle10 = typeof(Math);
							array3 = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt"]), isNum: true), txtTy_gia.Value),
								null,
								null
							};
							object[] array22 = array3;
							sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
							array22[1] = sIConfiguration.Round_Gia;
							array3[2] = MidpointRounding.AwayFromZero;
							array = array3;
							object[] array23 = array;
							array5 = new bool[3] { false, true, false };
							object obj10 = NewLateBinding.LateGet((object)null, typeFromHandle10, "Round", array23, (string[])null, (Type[])null, array5);
							if (array5[1])
							{
								sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
							}
							item["gia"] = RuntimeHelpers.GetObjectValue(obj10);
						}
						if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia"]), isNum: true)), (object)0, false))
						{
							Type? typeFromHandle11 = typeof(Math);
							array3 = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia"]), isNum: true)),
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
							item["Tien"] = RuntimeHelpers.GetObjectValue(obj11);
						}
						else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
						{
							Type? typeFromHandle12 = typeof(Math);
							array3 = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt"]), isNum: true), txtTy_gia.Value),
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
							item["Tien"] = RuntimeHelpers.GetObjectValue(obj12);
						}
						if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien2"]), isNum: true)), (object)0, false))
						{
							Type? typeFromHandle13 = typeof(Math);
							array3 = new object[3]
							{
								Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien2"]), isNum: true)), (object)100),
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
							item["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj13);
						}
						else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
						{
							Type? typeFromHandle14 = typeof(Math);
							array3 = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Ck_nt"]), isNum: true), txtTy_gia.Value),
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
							item["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj14);
						}
						Type? typeFromHandle15 = typeof(Math);
						array3 = new object[3]
						{
							Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Ck"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ck_ds"]), isNum: true))), (object)100),
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
						double num = Conversions.ToDouble(obj15);
						if (num != 0.0)
						{
							item["Thue_Gtgt"] = num;
						}
						else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
						{
							Type? typeFromHandle16 = typeof(Math);
							array3 = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_Nt"]), isNum: true), txtTy_gia.Value),
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
							item["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj16);
						}
					}
					Calc_ThanhToan(item);
				}
			}
			AsTextNumeric asTextNumeric = txtT_ck_ds;
			Type? typeFromHandle17 = typeof(Math);
			array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtT_ck_ds_nt.Value), isNum: true), txtTy_gia.Value),
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
			asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj17);
			PhanBoChietKhauDoanhSo();
		}
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

	private void Calc_Ck_ds()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		int num2 = 0;
		if ((int)((CheckBox)chkCk_st).CheckState == 1)
		{
			num2 = 1;
		}
		AsTextNumeric asTextNumeric = txtT_ck_ds_nt;
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Operators.AddObject(txtT_Tien_nt2.Value, Operators.MultiplyObject((object)num2, txtT_thue_nt.Value)), txtTl_ck_ds.Value), (object)100),
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
		AsTextNumeric asTextNumeric2 = txtT_ck_ds;
		Type? typeFromHandle2 = typeof(Math);
		array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Operators.AddObject(txtT_Tien2.Value, Operators.MultiplyObject((object)num2, txtT_Thue.Value)), txtTl_ck_ds.Value), (object)100),
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
		PhanBoChietKhauDoanhSo();
	}

	private void LookupDH(string aKey)
	{
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		DataTable oTblPh = null;
		DataTable oTblCt = null;
		if (SOCommon.SOLookupDH4HD(aKey, ref oTblPh, ref oTblCt))
		{
			frmSoVchSO3SeachSO1 frmSoVchSO3SeachSO2 = new frmSoVchSO3SeachSO1();
			((Form)frmSoVchSO3SeachSO2).Text = ((ButtonBase)cmdChon_dh).Text.Replace("&", "");
			frmSoVchSO3SeachSO2.PHTable = oTblPh;
			frmSoVchSO3SeachSO2.CTTable = oTblCt;
			if ((int)((Form)frmSoVchSO3SeachSO2).ShowDialog() != 1)
			{
				return;
			}
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
			Control oTxt = (Control)(object)txtTy_gia;
			SetTexboxValue(ref oTxt, Conversions.ToString(dataRow2["Ty_Gia"]));
			txtTy_gia = (AsTextNumeric)(object)oTxt;
			((TextBox)txtMa_Kh).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow2["ma_kh"]), isNum: false));
			oTxt = (Control)(object)txtDia_chi_vat;
			SetTexboxValue(ref oTxt, Conversions.ToString(dataRow2["Dia_chi_vat"]));
			txtDia_chi_vat = (TextBox)oTxt;
			oTxt = (Control)(object)txtTen_kh;
			SetTexboxValue(ref oTxt, Conversions.ToString(dataRow2["ten_kh_vat"]));
			txtTen_kh = (TextBox)oTxt;
			txtMa_so_thue.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow2["ma_so_thue"]), isNum: false));
			oTxt = (Control)(object)txtNguoi_Gd;
			SetTexboxValue(ref oTxt, Conversions.ToString(dataRow2["nguoi_gd"]));
			txtNguoi_Gd = (TextBox)oTxt;
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
					dataRow5["tra_ck"] = RuntimeHelpers.GetObjectValue(dataRow4["tra_ck"]);
					dataRow5["khuyen_mai"] = RuntimeHelpers.GetObjectValue(dataRow4["khuyen_mai"]);
					dataRow5["Tk_Gv"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow4["Tk_Gv"]), isNum: false));
					dataRow5["Tk_Vt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow4["Tk_Vt"]), isNum: false));
					dataRow5["Tk_Dt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow4["Tk_Dt"]), isNum: false));
					dataRow5["Tk_Ck"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow4["Tk_Ck"]), isNum: false));
					dataRow5["Tk_km"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow4["Tk_km"]), isNum: false));
					dataRow5["Tk_tl"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow4["Tk_tl"]), isNum: false));
					dataRow5["ma_kho"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_kho"]);
					dataRow5["ma_vitri"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_vitri"]);
					dataRow5["So_luong"] = RuntimeHelpers.GetObjectValue(dataRow4["ton"]);
					dataRow5["So_luong_qd"] = RuntimeHelpers.GetObjectValue(dataRow4["ton_qd"]);
					dataRow5["Gia_nt2"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia_nt2"]);
					dataRow5["Gia2"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia2"]);
					dataRow5["Tien_Nt2"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_nt2"]);
					dataRow5["Tien2"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien2"]);
					dataRow5["Tl_Ck"] = RuntimeHelpers.GetObjectValue(dataRow4["Tl_Ck"]);
					dataRow5["Tien_Ck_nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_Ck_nt"]);
					dataRow5["Tien_Ck"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_Ck"]);
					dataRow5["ma_thue"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_thue"]);
					dataRow5["Ts_Gtgt"] = RuntimeHelpers.GetObjectValue(dataRow4["Ts_Gtgt"]);
					dataRow5["Thue_Gtgt_Nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Thue_Gtgt_Nt"]);
					dataRow5["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(dataRow4["Thue_Gtgt"]);
					dataRow5["Gia_nt2"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia_nt2"]);
					dataRow5["Gia2"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia2"]);
					dataRow5["ma_bp"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_bp"]);
					dataRow5["ma_phi"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_phi"]);
					dataRow5["ma_spct"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_spct"]);
					dataRow5["ma_hd"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_hd"]);
					dataRow5["ma_lo"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_lo"]);
					dataRow5["ma_nvkd"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_nvkd"]);
					CTTable.Rows.Add(dataRow5);
					ReCalcTonKhoTucThoi(dataRow5);
				}
			}
			((TextBoxBase)txtMa_Kh).ReadOnly = true;
		}
		else
		{
			CMessageBox.Show(50016);
		}
	}

	private void GetKhInfo()
	{
		txtDu13.Value = Commons.GetDuArkh(((TextBox)txtMa_Kh).Text, ((TextBox)txtTk_pt).Text, Conversions.ToDate(txtNgay_Ct.Value));
	}

	private void SetTexboxValue(ref Control oTxt, string value, bool isnumeric = false)
	{
		if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(oTxt.Text, isNum: false), (object)"", false))
		{
			oTxt.Text = Conversions.ToString(Helper.Repl_Null(value, isnumeric));
		}
	}

	private void ClearGiaVon(object drct)
	{
		NewLateBinding.LateIndexSet(drct, new object[2] { "gia", 0 }, (string[])null);
		NewLateBinding.LateIndexSet(drct, new object[2] { "gia_nt", 0 }, (string[])null);
		NewLateBinding.LateIndexSet(drct, new object[2] { "tien", 0 }, (string[])null);
		NewLateBinding.LateIndexSet(drct, new object[2] { "tien_nt", 0 }, (string[])null);
	}

	private bool ValidGridCell(int TypeGrid, DataGridViewCell Cell, int Cmess)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		Cell.ErrorText = Helper.GetMessContent(Cmess);
		switch (TypeGrid)
		{
		case 0:
			((TabControl)AsTabControl).SelectedTab = tabDetail;
			((Control)adgvDetail).Select();
			((DataGridView)adgvDetail).CurrentCell = Cell;
			break;
		case 1:
			((TabControl)AsTabControl).SelectedTab = tabHach_toan;
			((Control)adgvHach_toan).Select();
			((DataGridView)adgvHach_toan).CurrentCell = Cell;
			break;
		}
		CMessageBox.Show(Cmess);
		return false;
	}

	private void RecipeABC(DataGridViewCell Cell, double dbA, double dbB, double dbC, int Cmess, ref bool CmessGHDC)
	{
		if (dbA != 0.0)
		{
			Cell.ErrorText = string.Empty;
			if (Math.Abs(dbA - dbB) > dbC)
			{
				Cell.ErrorText = Helper.GetMessContent(Cmess);
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
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia_Nt2"]), isNum: true)),
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
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia_Nt"]), isNum: true)),
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
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tl_Ck"]), isNum: true)), (object)100),
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
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ck_ds_Nt"]), isNum: true))), (object)100),
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
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia2"]), isNum: true)),
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
			double num3 = Conversions.ToDouble(obj5);
			if (num3 == 0.0)
			{
				Type? typeFromHandle6 = typeof(Math);
				array4 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_nt2"]), isNum: true), txtTy_gia.Value),
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
				odv["Tien2"] = RuntimeHelpers.GetObjectValue(obj6);
			}
			Type? typeFromHandle7 = typeof(Math);
			array4 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia"]), isNum: true)),
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
			double num4 = Conversions.ToDouble(obj7);
			if (num4 == 0.0)
			{
				Type? typeFromHandle8 = typeof(Math);
				array4 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt"]), isNum: true), txtTy_gia.Value),
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
				odv["Tien"] = RuntimeHelpers.GetObjectValue(obj8);
			}
			Type? typeFromHandle9 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien2"]), isNum: true)), (object)100),
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
			double num5 = Conversions.ToDouble(obj9);
			if (num5 == 0.0)
			{
				Type? typeFromHandle10 = typeof(Math);
				array4 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_nt"]), isNum: true), txtTy_gia.Value),
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
				odv["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj10);
			}
			Type? typeFromHandle11 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ck_ds"]), isNum: true))), (object)100),
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
			double num6 = Conversions.ToDouble(obj11);
			if (num6 == 0.0)
			{
				Type? typeFromHandle12 = typeof(Math);
				array = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Gtgt_Nt"]), isNum: true), txtTy_gia.Value),
					null,
					null
				};
				object[] array15 = array;
				SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array15[1] = sIConfiguration.Round;
				array[2] = MidpointRounding.AwayFromZero;
				array4 = array;
				object[] array16 = array4;
				array3 = new bool[3] { false, true, false };
				object obj12 = NewLateBinding.LateGet((object)null, typeFromHandle12, "Round", array16, (string[])null, (Type[])null, array3);
				if (array3[1])
				{
					sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
				}
				odv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj12);
			}
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien2).Name, index], Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien2"]), isNum: true)), num3, gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_ck).Name, index], Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien_ck"]), isNum: true)), num5, gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcThue_gtgt).Name, index], Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Gtgt"]), isNum: true)), num6, gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_nt2).Name, index], dbA, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, Cmess, ref CmessGHDC);
			if (AsiaErp.Framework.Environment.GetSIConfiguration().view_giavon)
			{
				RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien).Name, index], Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien"]), isNum: true)), num4, gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
				RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_nt).Name, index], dbA2, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, Cmess, ref CmessGHDC);
			}
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_ck_nt).Name, index], dbA3, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, Cmess, ref CmessGHDC);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcThue_gtgt_nt).Name, index], dbA4, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, Cmess, ref CmessGHDC);
		}
		else
		{
			Type? typeFromHandle13 = typeof(Math);
			object[] array4 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia_Nt2"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array17 = array4;
			bool[] array3 = new bool[3] { false, true, false };
			object obj13 = NewLateBinding.LateGet((object)null, typeFromHandle13, "Round", array17, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA5 = Conversions.ToDouble(obj13);
			Type? typeFromHandle14 = typeof(Math);
			array4 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia_Nt"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array18 = array4;
			array3 = new bool[3] { false, true, false };
			object obj14 = NewLateBinding.LateGet((object)null, typeFromHandle14, "Round", array18, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA6 = Conversions.ToDouble(obj14);
			Type? typeFromHandle15 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tl_Ck"]), isNum: true)), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array19 = array4;
			array3 = new bool[3] { false, true, false };
			object obj15 = NewLateBinding.LateGet((object)null, typeFromHandle15, "Round", array19, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA7 = Conversions.ToDouble(obj15);
			Type? typeFromHandle16 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ck_ds_Nt"]), isNum: true))), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array20 = array4;
			array3 = new bool[3] { false, true, false };
			object obj16 = NewLateBinding.LateGet((object)null, typeFromHandle16, "Round", array20, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA8 = Conversions.ToDouble(obj16);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_nt2).Name, index], dbA5, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true)), gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
			if (AsiaErp.Framework.Environment.GetSIConfiguration().view_giavon)
			{
				RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_nt).Name, index], dbA6, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
			}
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_ck_nt).Name, index], dbA7, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcThue_gtgt_nt).Name, index], dbA8, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
		}
	}

	private void PhanBoChietKhauDoanhSo()
	{
		if (CT1Voucher.Count == 0)
		{
			return;
		}
		string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
		int digits = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		double num = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(tien_nt2)", filter)), isNum: true));
		double num2 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("Sum(tien2)", filter)), isNum: true));
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		num5 = Conversions.ToDouble(txtT_ck_ds.Value);
		num6 = Conversions.ToDouble(txtT_ck_ds_nt.Value);
		foreach (DataRowView item in base.CT1Voucher)
		{
			if ((num6 != 0.0 && num != 0.0) ? true : false)
			{
				double num7 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien_nt2"]), isNum: true));
				double num8 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien2"]), isNum: true));
				num3 = Math.Round(num6 * num7 / num, digits, MidpointRounding.AwayFromZero);
				num4 = Math.Round(num5 * num8 / num2, AsiaErp.Framework.Environment.GetSIConfiguration().Round, MidpointRounding.AwayFromZero);
			}
			item["ck_ds"] = num4;
			item["ck_ds_nt"] = num3;
			Calc_Thue_gtgt(item);
			Calc_ThanhToan(item);
		}
		double num9 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(ck_ds_nt)", filter)), isNum: true));
		double num10 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(ck_ds)", filter)), isNum: true));
		CT1Voucher.Sort = "ck_ds_nt desc";
		DataRowView dataRowView2 = CT1Voucher[0];
		CT1Voucher.Sort = "";
		DataRowView dataRowView3 = dataRowView2;
		DataRowView dataRowView4 = dataRowView3;
		string property = "ck_ds";
		dataRowView4[property] = Operators.AddObject(dataRowView3[property], (object)(num5 - num10));
		dataRowView3 = dataRowView2;
		DataRowView dataRowView5 = dataRowView3;
		property = "ck_ds_nt";
		dataRowView5[property] = Operators.AddObject(dataRowView3[property], (object)(num6 - num9));
		Calc_Thue_gtgt(dataRowView2);
		Calc_ThanhToan(dataRowView2);
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
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien_nt2"]), isNum: true)),
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
			item["tien_nt2"] = RuntimeHelpers.GetObjectValue(obj3);
			Type? typeFromHandle4 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt2"]), isNum: true)),
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
			item["gia_nt2"] = RuntimeHelpers.GetObjectValue(obj4);
			Type? typeFromHandle5 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien_ck_nt"]), isNum: true)),
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
			item["tien_ck_nt"] = RuntimeHelpers.GetObjectValue(obj5);
			Type? typeFromHandle6 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_Nt"]), isNum: true)),
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
			item["Thue_Gtgt_Nt"] = RuntimeHelpers.GetObjectValue(obj6);
			Type? typeFromHandle7 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ck_ds_Nt"]), isNum: true)),
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
			item["Ck_ds_Nt"] = RuntimeHelpers.GetObjectValue(obj7);
			Type? typeFromHandle8 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tt_nt"]), isNum: true)),
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
			item["Tt_nt"] = RuntimeHelpers.GetObjectValue(obj8);
		}
	}

	private void Thanh_toan()
	{
		//IL_09ae: Unknown result type (might be due to invalid IL or missing references)
		frmCA4SO frmCA4SO = new frmCA4SO();
		MenuInformation menuInformation = AsiaErp.Framework.Environment.GetMenuInformation(base.MyMenuInfo.par1);
		MenuInformation menuInformation2 = AsiaErp.Framework.Environment.GetMenuInformation(base.MyMenuInfo.par2);
		DataTable dataTable = Commons.GetDataTable("asSOGetCA4SO", CompanyInformations.CompanyID, "CA", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]), isNum: false)));
		if (dataTable == null || dataTable.Rows.Count == 0)
		{
			VoucherInformation voucherInformation = AsiaErp.Framework.Environment.GetVoucherInformation(menuInformation.code_name);
			SiDmCt siDMCTByMa_Ct = AsiaErp.Framework.Environment.GetSiDMCTByMa_Ct(voucherInformation.voucher_code);
			frmCA4SO.MyMenuInfo = menuInformation;
			frmCA4SO.f_CAVoucherInfo = voucherInformation;
			frmCA4SO.f_mode = "M";
			frmCA4SO.txtNgay_Ct.Value = RuntimeHelpers.GetObjectValue(txtNgay_Ct.Value);
			frmCA4SO.txtSo_Ct.Text = Commons.Get_SoCt(voucherInformation.voucher_code, Conversions.ToDate(txtNgay_Ct.Value));
			((TextBox)frmCA4SO.txtTk_No).Text = siDMCTByMa_Ct.tk_no;
			frmCA4SO.txtNguoi_Gd.Text = txtNguoi_Gd.Text;
			frmCA4SO.txtDien_giai.Text = txtDien_giai.Text;
			frmCA4SO.f_Dia_chi_kh = txtDia_chi_vat.Text;
			frmCA4SO.f_Ma_kh = ((TextBox)txtMa_Kh).Text;
			frmCA4SO.f_Ma_nt = cboMa_NT.MA_NT;
			frmCA4SO.f_Ty_gia = Conversions.ToDecimal(txtTy_gia.Value);
			DataTable dataTable2 = new DataTable("CaCt1");
			dataTable2.Columns.Add("ma_cty", typeof(string)).DefaultValue = CompanyInformations.CompanyID;
			dataTable2.Columns.Add("stt_rec", typeof(string)).DefaultValue = "";
			dataTable2.Columns.Add("stt_rec0", typeof(string)).DefaultValue = "";
			dataTable2.Columns.Add("Tk", typeof(string));
			dataTable2.Columns.Add("Ten_Tk", typeof(string)).DefaultValue = "";
			dataTable2.Columns.Add("Ps_co", typeof(decimal));
			dataTable2.Columns.Add("Ps_co_nt", typeof(decimal));
			dataTable2.Columns.Add("ma_kh", typeof(string)).DefaultValue = frmCA4SO.f_Ma_kh;
			dataTable2.Columns.Add("ma_hd", typeof(string));
			dataTable2.Columns.Add("ma_bp", typeof(string));
			dataTable2.Columns.Add("ma_phi", typeof(string));
			dataTable2.Columns.Add("ma_spct", typeof(string));
			dataTable2.Columns.Add("ma_lo", typeof(string));
			DataRow pDrw = default(DataRow);
			if ((Commons.ValidMa(ref pDrw, "TK", ((TextBox)txtTk_pt).Text.Trim(), "", "tk_cn") && pDrw != null && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(pDrw["tk_cn"]), isNum: true), (object)false, false)) ? true : false)
			{
				IEnumerable<VB_0024AnonymousType_3<object, decimal, decimal, object, object, object, object, object>> enumerable = from _0024VB_0024It in (from row in base.CTTable.AsEnumerable()
						where Operators.ConditionalCompareObjectEqual(row["Stt_Rec"], _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()["stt_rec"], false)
						select row).GroupBy([SpecialName] (DataRow row) => new VB_0024AnonymousType_0<object, object, object, object, object, object>(RuntimeHelpers.GetObjectValue(row["tk_dt"]), RuntimeHelpers.GetObjectValue(row["ma_hd"]), RuntimeHelpers.GetObjectValue(row["ma_bp"]), RuntimeHelpers.GetObjectValue(row["ma_phi"]), RuntimeHelpers.GetObjectValue(row["ma_spct"]), RuntimeHelpers.GetObjectValue(row["ma_lo"])), [SpecialName] (DataRow row) => row, [SpecialName] (VB_0024AnonymousType_0<object, object, object, object, object, object> _0024VB_0024Key, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_2<object, object, object, object, object, object, IEnumerable<DataRow>, decimal, decimal>(RuntimeHelpers.GetObjectValue(_0024VB_0024Key.tk), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_hd), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_bp), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_phi), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_spct), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_lo), _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => decimal.Subtract(decimal.Subtract(row.Field<decimal?>("tien_nt2") ?? 0m, row.Field<decimal?>("Ck_Ds_nt") ?? 0m), row.Field<decimal?>("Tien_Ck_nt") ?? 0m)), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => decimal.Subtract(decimal.Subtract(row.Field<decimal?>("tien2") ?? 0m, row.Field<decimal?>("Ck_Ds") ?? 0m), row.Field<decimal?>("Tien_Ck") ?? 0m))))
					select new VB_0024AnonymousType_3<object, decimal, decimal, object, object, object, object, object>(RuntimeHelpers.GetObjectValue(_0024VB_0024It.tk), _0024VB_0024It.ps_co_nt, _0024VB_0024It.ps_co, RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_hd), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_bp), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_phi), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_spct), RuntimeHelpers.GetObjectValue(_0024VB_0024It.ma_lo));
				foreach (VB_0024AnonymousType_3<object, decimal, decimal, object, object, object, object, object> item in enumerable)
				{
					pDrw = dataTable2.NewRow();
					pDrw["stt_rec0"] = Commons.Get_SttRec0("", dataTable2);
					pDrw["tk"] = RuntimeHelpers.GetObjectValue(item.tk);
					pDrw["ps_co"] = item.ps_co;
					pDrw["ps_co_nt"] = item.ps_co_nt;
					pDrw["ma_hd"] = RuntimeHelpers.GetObjectValue(item.ma_hd);
					pDrw["ma_bp"] = RuntimeHelpers.GetObjectValue(item.ma_bp);
					pDrw["ma_phi"] = RuntimeHelpers.GetObjectValue(item.ma_phi);
					pDrw["ma_spct"] = RuntimeHelpers.GetObjectValue(item.ma_spct);
					pDrw["ma_lo"] = RuntimeHelpers.GetObjectValue(item.ma_lo);
					dataTable2.Rows.Add(pDrw);
				}
				pDrw = dataTable2.NewRow();
				pDrw["stt_rec0"] = Commons.Get_SttRec0("", dataTable2);
				pDrw["tk"] = ((TextBox)txtTk_thue).Text.Trim();
				pDrw["ps_co"] = RuntimeHelpers.GetObjectValue(txtT_Thue.Value);
				pDrw["ps_co_nt"] = RuntimeHelpers.GetObjectValue(txtT_thue_nt.Value);
				DataRowView currentCTRowView = base.CurrentCTRowView;
				pDrw["ma_hd"] = RuntimeHelpers.GetObjectValue(currentCTRowView["ma_hd"]);
				pDrw["ma_bp"] = RuntimeHelpers.GetObjectValue(currentCTRowView["ma_bp"]);
				pDrw["ma_phi"] = RuntimeHelpers.GetObjectValue(currentCTRowView["ma_phi"]);
				pDrw["ma_spct"] = RuntimeHelpers.GetObjectValue(currentCTRowView["ma_spct"]);
				pDrw["ma_lo"] = RuntimeHelpers.GetObjectValue(currentCTRowView["ma_lo"]);
				dataTable2.Rows.Add(pDrw);
			}
			else
			{
				pDrw = dataTable2.NewRow();
				pDrw["stt_rec0"] = Commons.Get_SttRec0("", dataTable2);
				pDrw["tk"] = ((TextBox)txtTk_pt).Text.Trim();
				pDrw["ps_co"] = RuntimeHelpers.GetObjectValue(txtT_tt.Value);
				pDrw["ps_co_nt"] = RuntimeHelpers.GetObjectValue(txtT_tt_nt.Value);
				DataRowView currentCTRowView2 = base.CurrentCTRowView;
				pDrw["ma_hd"] = RuntimeHelpers.GetObjectValue(currentCTRowView2["ma_hd"]);
				pDrw["ma_bp"] = RuntimeHelpers.GetObjectValue(currentCTRowView2["ma_bp"]);
				pDrw["ma_phi"] = RuntimeHelpers.GetObjectValue(currentCTRowView2["ma_phi"]);
				pDrw["ma_spct"] = RuntimeHelpers.GetObjectValue(currentCTRowView2["ma_spct"]);
				pDrw["ma_lo"] = RuntimeHelpers.GetObjectValue(currentCTRowView2["ma_lo"]);
				dataTable2.Rows.Add(pDrw);
			}
			dataTable2.AcceptChanges();
			frmCA4SO.f_oTblCt = dataTable2;
		}
		else
		{
			DataRow dataRow = dataTable.Rows[0];
			frmCA4SO.txtNgay_Ct.Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ngay_ct"]), isNum: false));
			frmCA4SO.txtSo_Ct.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["so_ct"]), isNum: false));
			frmCA4SO.f_Ma_nt = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ma_nt"]), isNum: false));
			frmCA4SO.f_Ty_gia = Conversions.ToDecimal(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ty_gia"]), isNum: true));
			((TextBox)frmCA4SO.txtTk_No).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["tk_no"]), isNum: false));
			frmCA4SO.f_Ma_kh = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ma_kh"]), isNum: false));
			frmCA4SO.txtNguoi_Gd.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["nguoi_gd"]), isNum: false));
			frmCA4SO.txtDien_giai.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["dien_giai"]), isNum: false));
			frmCA4SO.f_Dia_chi_kh = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["dia_chi"]), isNum: false));
			frmCA4SO.f_stt_rec = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["stt_rec"]), isNum: false));
			string text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["ma_ct"]), isNum: false));
			if (Operators.CompareString(text, "CA3", false) == 0)
			{
				frmCA4SO.rbCA3.Checked = true;
			}
			frmCA4SO.f_mode = "X";
			frmCA4SO.f_oTblCt = dataTable;
		}
		frmCA4SO.f_stt_rec_hd = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]), isNum: false));
		frmCA4SO.f_CA1_MenuInfo = menuInformation;
		frmCA4SO.f_CA3_MenuInfo = menuInformation2;
		((Form)frmCA4SO).ShowDialog();
		if (frmCA4SO.isOK)
		{
			string text2 = frmCA4SO.f_CAVoucherInfo.voucher_code + ": " + frmCA4SO.txtSo_Ct.Text + " - " + Conversions.ToDate(frmCA4SO.txtNgay_Ct.Value).ToString("dd/MM/yyyy");
			base.CurrentPHRow["ten_trang_thai"] = text2;
			((ToolStripItem)tsslTrangThai).Text = text2;
			((ToolStripItem)tsslTrangThai).Visible = true;
		}
		((Component)(object)frmCA4SO).Dispose();
	}

	protected override void InitOtherBeforeLoadData()
	{
		base.InitOtherBeforeLoadData();
		string[] array = AsiaErp.Framework.Environment.GetSOConfiguration().ds_httt.Split(new char[1] { ';' });
		cboHttt.Items.Clear();
		cboHttt.Items.AddRange((object[])array);
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		base.PHTable.Columns["ma_gd"].DefaultValue = f_sMa_Gd_Default;
		base.PHTable.Columns["tao_tu_px"].DefaultValue = false;
		((DataGridView)adgvHach_toan).DataSource = base.bsCT;
		AddControl2ListOfDrivedControls((Control)(object)chkGia_dd);
		AddControl2ListOfDrivedControls((Control)(object)chkCk_st);
		AddControl2ListOfDrivedControls((Control)(object)chkGia_st);
		AddControl2ListOfDrivedControls((Control)(object)txtTk_pt);
		AddControl2ListOfDrivedControls((Control)(object)txtTk_thue);
		AddControl2ListOfDrivedControls((Control)(object)txtTk_ck_ds);
		AddControl2ListOfDrivedControls((Control)(object)txtT_ck_ds_nt);
		AddControl2ListOfDrivedControls((Control)(object)txtT_ck_ds);
		AddControl2ListOfDrivedControls((Control)(object)txtTl_ck_ds);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Tien_nt2);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_thue_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_ck_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tt_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_ck_ds_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_ck_ds);
		AddDGV(adgvHach_toan);
		string ma_nt = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		f_sTien_von = ((DataGridViewColumn)dgvcTien_nt).HeaderText;
		f_sGia_von = ((DataGridViewColumn)dgvcGia_nt).HeaderText;
		f_sGia_ban = ((DataGridViewColumn)dgvcGia_nt2).HeaderText;
		f_sTien_ban = ((DataGridViewColumn)dgvcTien_nt2).HeaderText;
		f_sTien_ck = ((DataGridViewColumn)dgvcTien_ck_nt).HeaderText;
		f_sTien_thue = ((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText;
		((DataGridViewColumn)dgvcGia2).HeaderText = f_sGia_ban + " " + ma_nt;
		((DataGridViewColumn)dgvcTien2).HeaderText = f_sTien_ban + " " + ma_nt;
		((DataGridViewColumn)dgvcTien2_ht).HeaderText = f_sTien_ban + " " + ma_nt;
		((DataGridViewColumn)dgvcTien_ck).HeaderText = f_sTien_ck + " " + ma_nt;
		((DataGridViewColumn)dgvcTien_Ck_ht).HeaderText = f_sTien_ck + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = f_sTien_thue + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_gtgt_ht).HeaderText = f_sTien_thue + " " + ma_nt;
		((DataGridViewColumn)dgvcGia).HeaderText = f_sGia_von + " " + ma_nt;
		((DataGridViewColumn)dgvcTien).HeaderText = f_sTien_von + " " + ma_nt;
		((DataGridViewColumn)dgvcTien_ht).HeaderText = f_sTien_von + " " + ma_nt;
		GetKhInfo();
		f_isGetKhInfo = true;
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
		bool view_giavon = AsiaErp.Framework.Environment.GetSIConfiguration().view_giavon;
		((Control)txtT_Tien2).Visible = flag;
		((Control)txtT_ck).Visible = flag;
		((Control)txtT_ck_ds).Visible = flag;
		((Control)txtT_Thue).Visible = flag;
		((Control)txtT_tt).Visible = flag;
		((DataGridViewColumn)dgvcGia2).Visible = flag;
		((DataGridViewColumn)dgvcTien2).Visible = flag;
		((DataGridViewColumn)dgvcTien_ck).Visible = flag;
		((DataGridViewColumn)dgvcThue_gtgt).Visible = flag;
		((DataGridViewColumn)dgvcTien2_ht).Visible = flag;
		((DataGridViewColumn)dgvcTien_Ck_ht).Visible = flag;
		((DataGridViewColumn)dgvcThue_gtgt_ht).Visible = flag;
		((DataGridViewColumn)dgvcGia).Visible = ((flag && view_giavon) ? true : false);
		((DataGridViewColumn)dgvcTien).Visible = ((flag && view_giavon) ? true : false);
		((DataGridViewColumn)dgvcTien_ht).Visible = ((flag && view_giavon) ? true : false);
		((DataGridViewColumn)dgvcGia_nt).Visible = view_giavon;
		((DataGridViewColumn)dgvcTien_nt).Visible = view_giavon;
		((DataGridViewColumn)dgvcTien_nt_ht).Visible = view_giavon;
		string mA_NT = cboMa_NT.MA_NT;
		((DataGridViewColumn)dgvcGia_nt2).HeaderText = f_sGia_ban + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt2).HeaderText = f_sTien_ban + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_ck_nt).HeaderText = f_sTien_ck + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = f_sTien_thue + " " + mA_NT;
		((DataGridViewColumn)dgvcGia_nt).HeaderText = f_sGia_von + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt).HeaderText = f_sTien_von + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt2_ht).HeaderText = f_sTien_ban + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_ck_nt_ht).HeaderText = f_sTien_ck + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).HeaderText = f_sTien_thue + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = f_sTien_von + " " + mA_NT;
		((Control)chkGia_dd).Enabled = view_giavon;
		((Control)chkGia_dd).Visible = view_giavon;
		((DataGridViewColumn)dgvcGia_nt).Visible = view_giavon;
		((DataGridViewColumn)dgvcTien_nt).Visible = view_giavon;
	}

	protected override void SetFocus4FirstEditControl()
	{
		if ((base.ActionMode == Commons.ApplicationMode.EDIT_MODE && base.CurrentPHRow != null && Operators.ConditionalCompareObjectEqual(base.CurrentPHRow["tao_tu_px"], (object)true, false)) ? true : false)
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
			string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", base.CurrentPHRow["Stt_Rec"]), (object)"'"));
			txtT_Tien_nt2.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_nt2)", filter));
			txtT_thue_nt.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(thue_gtgt_nt)", filter));
			txtT_ck_nt.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_ck_nt)", filter));
			txtT_tt_nt.Value = Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(txtT_Tien_nt2.Value, txtT_thue_nt.Value), txtT_ck_nt.Value), txtT_ck_ds_nt.Value);
			txtT_Tien2.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien2)", filter));
			txtT_Thue.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(thue_gtgt)", filter));
			txtT_ck.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_ck)", filter));
			txtT_tt.Value = Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(txtT_Tien2.Value, txtT_Thue.Value), txtT_ck.Value), txtT_ck_ds.Value);
			txtT_So_luong.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(so_luong)", filter));
		}
	}

	protected override bool ValidData()
	{
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		bool CmessGHDC = false;
		checked
		{
			if ((ChkEmtyTextBox((TextBox)(object)txtMa_Kh) && base.ValidData()) ? true : false)
			{
				if (!ChkEmtyTextBox((TextBox)(object)txtMa_Httt))
				{
					((TabControl)AsTabControl).SelectedTab = tabHach_toan;
					return false;
				}
				if (!ChkEmtyTextBox((TextBox)(object)txtTk_pt))
				{
					((TabControl)AsTabControl).SelectedTab = tabHach_toan;
					return false;
				}
				bool flag = false;
				DataRow pDrw = null;
				Commons.ValidMa(ref pDrw, "TK", ((TextBox)txtTk_pt).Text, "", "tk_cn");
				if (pDrw != null)
				{
					flag = Conversions.ToBoolean(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(pDrw["tk_cn"]), isNum: false));
				}
				if (((flag && Operators.ConditionalCompareObjectGreater(txtGh_no.Value, (object)0, false) && Operators.ConditionalCompareObjectGreater(txtT_tt_nt.Value, txtGh_no.Value, false)) ? true : false) && !Commons.ProcessOverDeptLimit())
				{
					return false;
				}
				if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(txtT_Thue.Value, txtT_thue_nt.Value), (object)0, false))
				{
					if (!ChkEmtyTextBox((TextBox)(object)txtTk_thue))
					{
						((TabControl)AsTabControl).SelectedTab = tabHach_toan;
						return false;
					}
					if (!ChkEmtyTextBox(txtMa_so_thue) || !ChkEmtyTextBox(txtDia_chi_vat))
					{
						return false;
					}
				}
				if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(txtT_ck_ds_nt.Value, txtT_ck_ds.Value), (object)0, false) && !ChkEmtyTextBox((TextBox)(object)txtTk_ck_ds))
				{
					((TabControl)AsTabControl).SelectedTab = tabHach_toan;
					return false;
				}
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
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_dt"]), isNum: false), (object)"", false))
					{
						return ValidGridCell(1, ((DataGridView)adgvHach_toan)[((DataGridViewColumn)dgvcTk_dt).Name, num2], 50023);
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_gv"]), isNum: false), (object)"", false))
					{
						return ValidGridCell(1, ((DataGridView)adgvHach_toan)[((DataGridViewColumn)dgvcTk_gv).Name, num2], 50023);
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_vt"]), isNum: false), (object)"", false))
					{
						return ValidGridCell(1, ((DataGridView)adgvHach_toan)[((DataGridViewColumn)dgvcTk_vt).Name, num2], 50023);
					}
					if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_ck"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Ck_Nt"]), isNum: true)), (object)0, false)) ? true : false)
					{
						return ValidGridCell(1, ((DataGridView)adgvHach_toan)[((DataGridViewColumn)dgvcTk_ck).Name, num2], 50023);
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Vt"]), isNum: false), (object)"", false))
					{
						return ValidGridCell(0, ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_vt).Name, num2], 50062);
					}
					if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Kho"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ton_kho"]), isNum: false), (object)"1", false)) ? true : false)
					{
						return ValidGridCell(0, ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_kho).Name, num2], 50056);
					}
					if ((Operators.ConditionalCompareObjectEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true)), (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ton_kho"]), isNum: false), (object)"1", false)) ? true : false)
					{
						((TabControl)AsTabControl).SelectedTab = tabDetail;
						((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcSo_luong).Name, num2].ErrorText = Helper.GetMessContent(50037);
						flag2 = false;
					}
					if ((Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tien2"]), isNum: true), (object)0, false)) ? true : false)
					{
						return ValidGridCell(0, ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien2).Name, num2], 50037);
					}
					ValidAdjustOver(num2, dataRowView, ref CmessGHDC, 50130);
					num2++;
				}
				if ((Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.MultiplyObject(txtT_ck_ds_nt.Value, txtTy_gia.Value), txtT_ck_ds.Value) }, (string[])null, (Type[])null, (bool[])null), (object)AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_toi_da, false) && Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false)) ? true : false)
				{
					((TabControl)AsTabControl).SelectedTab = tabDetail;
					epNotice.SetError((Control)(object)txtT_ck_ds, Helper.GetMessContent(50130));
					CMessageBox.Show(50130);
					((Control)txtT_ck_ds).Focus();
					return false;
				}
				if (CmessGHDC)
				{
					return Commons.ProcessAdjustOver();
				}
				if (!flag2)
				{
					CMessageBox.Show(50037);
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
		}
		else
		{
			adgvHach_toan.ReadOnly = true;
		}
		((TextBoxBase)txtGh_no).ReadOnly = true;
		((TextBoxBase)txtDu13).ReadOnly = true;
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

	protected override void PHDataBinding()
	{
		base.PHDataBinding();
		CreateDataBinding((Control)(object)txtMa_Kh, "Ma_Kh");
		CreateDataBinding((Control)(object)txtTen_kh, "Ten_Kh_vat");
		CreateDataBinding((Control)(object)txtDia_chi_vat, "Dia_chi_vat");
		CreateDataBinding((Control)(object)txtMa_so_thue, "ma_so_thue");
		CreateDataBinding((Control)(object)txtNguoi_Gd, "Nguoi_Gd");
		CreateDataBinding((Control)(object)txtDien_giai, "Dien_Giai");
		CreateDataBinding((Control)(object)txtSo_Seri, "so_seri");
		CreateDataBinding((Control)(object)txtNgay_Ct, "ngay_ct", "Value");
		CreateDataBinding((Control)(object)txtSo_Ct, "so_ct");
		CreateDataBinding((Control)(object)txtSo_px, "so_px");
		CreateDataBinding((Control)(object)txtNgay_lct, "ngay_lct", "Value");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)txtMa_Httt, "ma_httt");
		CreateDataBinding((Control)(object)lblTen_Httt, "ten_httt");
		CreateDataBinding((Control)(object)cboHttt, "Httt");
		CreateDataBinding((Control)(object)txtTk_pt, "tk_pt");
		CreateDataBinding((Control)(object)txtTk_thue, "tk_thue");
		CreateDataBinding((Control)(object)txtTk_ck_ds, "tk_ck_ds");
		CreateDataBinding((Control)(object)txtTl_ck_ds, "tl_ck_ds", "Value");
		CreateDataBinding((Control)(object)txtT_Tien2, "t_tien2", "Value");
		CreateDataBinding((Control)(object)txtT_ck, "t_ck", "Value");
		CreateDataBinding((Control)(object)txtT_Thue, "t_thue", "Value");
		CreateDataBinding((Control)(object)txtT_tt, "t_tt", "Value");
		CreateDataBinding((Control)(object)txtT_Tien_nt2, "t_tien_nt2", "Value");
		CreateDataBinding((Control)(object)txtT_ck_nt, "t_ck_nt", "Value");
		CreateDataBinding((Control)(object)txtT_thue_nt, "t_thue_nt", "Value");
		CreateDataBinding((Control)(object)txtT_tt_nt, "t_tt_nt", "Value");
		CreateDataBinding((Control)(object)txtT_So_luong, "t_so_luong", "Value");
		CreateDataBinding((Control)(object)txtT_ck_ds, "t_ck_ds", "Value");
		CreateDataBinding((Control)(object)txtT_ck_ds_nt, "t_ck_ds_nt", "Value");
		CreateDataBinding((Control)(object)chkGia_dd, "gia_dd", "Checked");
		CreateDataBinding((Control)(object)chkCk_st, "ck_st", "Checked");
		CreateDataBinding((Control)(object)chkGia_st, "gia_st", "Checked");
		CreateDataBinding((Control)(object)txtSo_seri_mhd, "so_seri_mhd");
	}

	protected override void SetPHDefaultValues(DataRow drwPh)
	{
		drwPh["ngay_ct"] = DateAndTime.Now;
		drwPh["ngay_lct"] = DateAndTime.Now;
	}

	protected override void SetNextInputGridControlFocus()
	{
		((Control)cmdAdd).Focus();
	}

	protected override void VoucherPositionChanged()
	{
		base.VoucherPositionChanged();
		if (base.IsLoading)
		{
			GetKhInfo();
			f_isGetKhInfo = true;
		}
	}

	protected override void Cancel()
	{
		((DataGridView)adgvHach_toan).CancelEdit();
		base.Cancel();
	}

	protected override void Print(DataRow odrPrintPHRow)
	{
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Invalid comparison between Unknown and I4
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (CurrentPHRow == null)
			{
				return;
			}
			bool pIs_oke = false;
			int iLimitedPrint = 0;
			string myMenuID = MyMenuID;
			bool blnViewRight = true;
			bool blnInsertRight = true;
			bool blnUpdateRight = true;
			bool blnDeleteRight = true;
			Commons.GetRights(myMenuID, ref blnViewRight, ref blnInsertRight, ref blnUpdateRight, ref blnDeleteRight, ref iLimitedPrint);
			pIs_oke = SOCommon.Get_RightPrint(CompanyInformations.CompanyID, txtSo_Ct.Text, txtSo_Seri.Text, iLimitedPrint, pIs_oke);
			if (!pIs_oke)
			{
				CMessageBox.Show(50150);
				return;
			}
			MyFomularFields.Clear();
			MyPrintOption = Commons.PrintOption.Cancel;
			CollectReportInformations(CurrentPHRow);
			if (MyPrintOption == Commons.PrintOption.Cancel || !LoadReport(CurrentPHRow) || 1 == 0)
			{
				return;
			}
			SetReportDataSource(CurrentPHRow);
			SetReportFomularFields(CurrentPHRow);
			base.SetReportExtensionFormulaField();
			switch ((int)MyPrintOption)
			{
			case 1:
			{
				PrintDialog val = new PrintDialog();
				val.UseEXDialog = true;
				val.AllowSomePages = false;
				PrintDialog val2 = val;
				val2.PrinterSettings.Copies = checked((short)MyVoucherInfo.number_of_copy);
				val2.PrinterSettings.Collate = true;
				PrinterSettings printerSettings = val2.PrinterSettings;
				PageSettings val3 = new PageSettings();
				if ((int)((CommonDialog)val2).ShowDialog() == 1)
				{
					MyReportDocument.PrintOptions.PrinterName = val2.PrinterSettings.PrinterName;
					MyReportDocument.PrintOptions.PaperSource = (PaperSource)7;
					try
					{
						MyReportDocument.PrintToPrinter((int)val2.PrinterSettings.Copies, val2.PrinterSettings.Collate, val2.PrinterSettings.FromPage, val2.PrinterSettings.ToPage);
						ArrayList arrayList = new ArrayList();
						arrayList.Add(CompanyInformations.CompanyID);
						arrayList.Add(SystemInformations.UserName);
						arrayList.Add(MyMenuID);
						arrayList.Add(RuntimeHelpers.GetObjectValue(CurrentPHRow["stt_rec"]));
						arrayList.Add(RuntimeHelpers.GetObjectValue(CurrentPHRow["ma_ct"]));
						arrayList.Add(RuntimeHelpers.GetObjectValue(CurrentPHRow["so_ct"]));
						arrayList.Add(RuntimeHelpers.GetObjectValue(CurrentPHRow["so_seri"]));
						arrayList.Add(RuntimeHelpers.GetObjectValue(CurrentPHRow["ngay_ct"]));
						arrayList.Add(MyReportInfo.ma_mau);
						arrayList.Add(DateTime.Now);
						SOCommon.SoInsLogPrint(arrayList.ToArray());
						break;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Helper.ProcessError(ex2.ToString());
						CMessageBox.Show(ex2.Message);
						ClearError();
						ProjectData.ClearProjectError();
						break;
					}
				}
				break;
			}
			case 2:
			{
				frmSoVchSo3ViewCrystal frmSoVchSo3ViewCrystal2 = new frmSoVchSo3ViewCrystal();
				frmSoVchSo3ViewCrystal2.rp = base.MyReportDocument;
				((Form)frmSoVchSo3ViewCrystal2).Text = MyVoucherInfo.description;
				frmSoVchSo3ViewCrystal2.CurrentPHRow = CurrentPHRow;
				frmSoVchSo3ViewCrystal2.MyMenuID = MyMenuID;
				frmSoVchSo3ViewCrystal2.Ma_mau = MyReportInfo.ma_mau;
				frmSoVchSo3ViewCrystal2.is_oke = pIs_oke;
				((Form)frmSoVchSo3ViewCrystal2).ShowInTaskbar = false;
				((Form)frmSoVchSo3ViewCrystal2).ShowDialog((IWin32Window)(object)this);
				break;
			}
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Helper.ProcessError(ex4.ToString());
			ProjectData.ClearProjectError();
		}
	}

	protected override void SetReportFomularFields(DataRow odrPrintPHRow)
	{
		base.SetReportFomularFields(odrPrintPHRow);
		string text = "";
		string text2 = "";
		foreach (DataRowView item in CT1Voucher)
		{
			if (!text.Contains(Conversions.ToString(item["tk_gv"])))
			{
				text = Conversions.ToString(Operators.AddObject((object)text, Interaction.IIf(Operators.CompareString(text, string.Empty, false) == 0, RuntimeHelpers.GetObjectValue(item["tk_gv"]), Operators.AddObject((object)",", item["tk_gv"]))));
			}
			if (!text2.Contains(Conversions.ToString(item["tk_vt"])))
			{
				text2 = Conversions.ToString(Operators.AddObject((object)text2, Interaction.IIf(Operators.CompareString(text2, string.Empty, false) == 0, RuntimeHelpers.GetObjectValue(item["tk_vt"]), Operators.AddObject((object)",", item["tk_vt"]))));
			}
		}
		base.MyFomularFields.Add("tk_no", text);
		base.MyFomularFields.Add("tk_co", text2);
	}

	protected override bool ChkStatusRight([Optional][DefaultParameterValue("")] ref string retMess)
	{
		return SOCommon.SOChkStatusRightSO3(Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentPHRow["stt_rec"]), isNum: false)), ref retMess);
	}

	protected override void SaveData2Datatable()
	{
		base.SaveData2Datatable();
		string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", base.CurrentPHRow["Stt_Rec"]), (object)"'"));
		CurrentPHRow["t_tien_nt"] = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_nt)", filter));
		CurrentPHRow["t_tien"] = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien)", filter));
	}

	protected override void Addnew()
	{
		base.Addnew();
		base.CurrentPHRow["so_px"] = Commons.Get_SoCt("IN2", Conversions.ToDate(base.CurrentPHRow["Ngay_ct"]));
	}

	protected override void F8_KeyPress()
	{
		base.F8_KeyPress();
		if (Operators.ConditionalCompareObjectNotEqual(txtT_ck_ds_nt.Value, (object)0, false))
		{
			PhanBoChietKhauDoanhSo();
		}
	}

	private void cmdChon_dh_Click(object sender, EventArgs e)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Invalid comparison between Unknown and I4
		frmSoVchSo3FindSO1 frmSoVchSo3FindSO2 = new frmSoVchSo3FindSO1();
		((Form)frmSoVchSo3FindSO2).Text = ((ButtonBase)cmdChon_dh).Text.Replace("&", "");
		((TextBox)frmSoVchSo3FindSO2.txtMa_Kh).Text = ((TextBox)txtMa_Kh).Text.Trim();
		frmSoVchSo3FindSO2.txtNgay_hd1.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("ngay_ct1"));
		frmSoVchSo3FindSO2.txtNgay_hd2.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("ngay_ct2"));
		((Form)frmSoVchSo3FindSO2).ShowDialog();
		if ((int)((Form)frmSoVchSo3FindSO2).DialogResult == 1)
		{
			LookupDH(frmSoVchSo3FindSO2.sWhereKey);
		}
		((Component)(object)frmSoVchSo3FindSO2).Dispose();
	}

	[SpecialName]
	[DebuggerNonUserCode]
	protected DataRow _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()
	{
		return base.CurrentPHRow;
	}
}
