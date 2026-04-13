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
using AsiaErp.SOUtilities;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSoVchSO4 : frmVoucher
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

	[AccessedThroughProperty("chkGia_tb")]
	private AsCheckBox _chkGia_tb;

	[AccessedThroughProperty("tabHach_toan")]
	private TabPage _tabHach_toan;

	[AccessedThroughProperty("adgvHach_toan")]
	private AsInputDGV _adgvHach_toan;

	[AccessedThroughProperty("chkSua_thue")]
	private AsCheckBox _chkSua_thue;

	[AccessedThroughProperty("chkSua_tien")]
	private AsCheckBox _chkSua_tien;

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

	[AccessedThroughProperty("lblT_Thue")]
	private Label _lblT_Thue;

	[AccessedThroughProperty("txtT_Tien2")]
	private AsTextNumeric _txtT_Tien2;

	[AccessedThroughProperty("lblT_Tien")]
	private Label _lblT_Tien;

	[AccessedThroughProperty("txtT_tt_nt")]
	private AsTextNumeric _txtT_tt_nt;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtGh_no")]
	private AsTextNumeric _txtGh_no;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtDu13")]
	private AsTextNumeric _txtDu13;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtDia_chi_vat")]
	private TextBox _txtDia_chi_vat;

	[AccessedThroughProperty("lblDia_chi")]
	private Label _lblDia_chi;

	[AccessedThroughProperty("txtMa_so_thue")]
	private TextBox _txtMa_so_thue;

	[AccessedThroughProperty("lblMa_so_thue")]
	private Label _lblMa_so_thue;

	[AccessedThroughProperty("adgvDetail")]
	private AsInputDGV _adgvDetail;

	[AccessedThroughProperty("txtMa_Httt")]
	private AsTextBox _txtMa_Httt;

	[AccessedThroughProperty("lblTen_Httt")]
	private Label _lblTen_Httt;

	[AccessedThroughProperty("lblMa_httt")]
	private Label _lblMa_httt;

	[AccessedThroughProperty("txtT_So_luong")]
	private AsTextNumeric _txtT_So_luong;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("txtSo_hd")]
	private TextBox _txtSo_hd;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txtT_tien")]
	private AsTextNumeric _txtT_tien;

	[AccessedThroughProperty("txtT_tien_nt")]
	private AsTextNumeric _txtT_tien_nt;

	[AccessedThroughProperty("tabTain")]
	private TabPage _tabTain;

	[AccessedThroughProperty("cmdGetTaInFromDetail")]
	private Button _cmdGetTaInFromDetail;

	[AccessedThroughProperty("SplitContainer1")]
	private SplitContainer _SplitContainer1;

	[AccessedThroughProperty("txtNgay_hd")]
	private AsMaskedTextBox _txtNgay_hd;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("ctlTaIn")]
	private ctlTaIn _ctlTaIn;

	[AccessedThroughProperty("txtT_ck")]
	private AsTextNumeric _txtT_ck;

	[AccessedThroughProperty("txtT_ck_nt")]
	private AsTextNumeric _txtT_ck_nt;

	[AccessedThroughProperty("lblT_ck")]
	private Label _lblT_ck;

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

	[AccessedThroughProperty("dgvcTien_ck_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_ck_ht;

	[AccessedThroughProperty("dgvcThue_Gtgt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcThue_Gtgt_ht;

	[AccessedThroughProperty("dgvcTien_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_ht;

	[AccessedThroughProperty("dgvcTk_tl")]
	private DataGridViewAsTextBoxColumn _dgvcTk_tl;

	[AccessedThroughProperty("dgvcTk_gv")]
	private DataGridViewAsTextBoxColumn _dgvcTk_gv;

	[AccessedThroughProperty("dgvcTk_vt")]
	private DataGridViewAsTextBoxColumn _dgvcTk_vt;

	[AccessedThroughProperty("dgvcTk_ck")]
	private DataGridViewAsTextBoxColumn _dgvcTk_ck;

	[AccessedThroughProperty("dgvcMa_vt_ht")]
	private DataGridViewTextBoxColumn _dgvcMa_vt_ht;

	[AccessedThroughProperty("txtSo_seri_mhd")]
	private TextBox _txtSo_seri_mhd;

	[AccessedThroughProperty("lblSo_seri_mhd")]
	private Label _lblSo_seri_mhd;

	[AccessedThroughProperty("cmdChon_px")]
	private Button _cmdChon_px;

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

	[AccessedThroughProperty("dgvcTL_CK")]
	private DataGridViewAsTextNumericColumn _dgvcTL_CK;

	[AccessedThroughProperty("dgvcTien_CK_nt")]
	private DataGridViewAsTextNumericColumn _dgvcTien_CK_nt;

	[AccessedThroughProperty("dgvcTs_gtgt")]
	private DataGridViewAsTextNumericColumn _dgvcTs_gtgt;

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

	[AccessedThroughProperty("dgvcSo_hd")]
	private DataGridViewTextBoxColumn _dgvcSo_hd;

	private const string HOA_DON = "1";

	private const string HOA_DON_KIEM_PHIEU_XUAT = "2";

	private bool f_isGetKhInfo;

	private string f_sTien_von;

	private string f_sGia_von;

	private string f_sGia_ban;

	private string f_sTien_ban;

	private string f_sTien_ck;

	private string f_sTien_thue;

	private string f_ma_httt_old;

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

	internal virtual AsCheckBox chkGia_tb
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkGia_tb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkGia_tb = value;
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

	internal virtual AsCheckBox chkSua_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkSua_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkSua_thue_CheckedChanged;
			if (_chkSua_thue != null)
			{
				((CheckBox)_chkSua_thue).CheckedChanged -= eventHandler;
			}
			_chkSua_thue = value;
			if (_chkSua_thue != null)
			{
				((CheckBox)_chkSua_thue).CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual AsCheckBox chkSua_tien
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkSua_tien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkSua_tien_CheckedChanged;
			if (_chkSua_tien != null)
			{
				((CheckBox)_chkSua_tien).CheckedChanged -= eventHandler;
			}
			_chkSua_tien = value;
			if (_chkSua_tien != null)
			{
				((CheckBox)_chkSua_tien).CheckedChanged += eventHandler;
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

	internal virtual AsTextNumeric txtDu13
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			AsInputDGV.SetDependentFieldsWhenCellValueChangedHandler obj = adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged;
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvDetail_CellEnter);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvDetail_CellValueChanged);
			if (_adgvDetail != null)
			{
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged -= obj;
				((DataGridView)_adgvDetail).CellEnter -= val;
				((DataGridView)_adgvDetail).CellValueChanged -= val2;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged += obj;
				((DataGridView)_adgvDetail).CellEnter += val;
				((DataGridView)_adgvDetail).CellValueChanged += val2;
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

	internal virtual Label lblMa_httt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_httt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_httt = value;
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

	protected internal virtual Label Label7
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

	internal virtual AsTextNumeric txtT_tien
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tien = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_ck_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_ck_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_ck_ht = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_Gtgt_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_Gtgt_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_Gtgt_ht = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_tl
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_tl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_tl = value;
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

	internal virtual Button cmdChon_px
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdChon_px;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdChon_px_Click;
			if (_cmdChon_px != null)
			{
				((Control)_cmdChon_px).Click -= eventHandler;
			}
			_cmdChon_px = value;
			if (_cmdChon_px != null)
			{
				((Control)_cmdChon_px).Click += eventHandler;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcTL_CK
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTL_CK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTL_CK = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_CK_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_CK_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_CK_nt = value;
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

	internal virtual DataGridViewTextBoxColumn dgvcSo_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_hd = value;
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

	public frmSoVchSO4()
	{
		__ENCAddToList(this);
		f_isGetKhInfo = false;
		f_sTien_von = "";
		f_sGia_von = "";
		f_sGia_ban = "";
		f_sTien_ban = "";
		f_sTien_ck = "";
		f_sTien_thue = "";
		f_ma_httt_old = "";
		InitializeComponent();
	}

	public frmSoVchSO4(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_isGetKhInfo = false;
		f_sTien_von = "";
		f_sGia_von = "";
		f_sGia_ban = "";
		f_sTien_ban = "";
		f_sTien_ck = "";
		f_sTien_thue = "";
		f_ma_httt_old = "";
		InitializeComponent();
	}

	public frmSoVchSO4(string MenuID, string Stt_rec)
		: base(MenuID, Stt_rec)
	{
		__ENCAddToList(this);
		f_isGetKhInfo = false;
		f_sTien_von = "";
		f_sGia_von = "";
		f_sGia_ban = "";
		f_sTien_ban = "";
		f_sTien_ck = "";
		f_sTien_thue = "";
		f_ma_httt_old = "";
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
		//IL_000e: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected O, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected O, but got Unknown
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_1c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1d: Expected O, but got Unknown
		//IL_1f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4f: Expected O, but got Unknown
		//IL_2008: Unknown result type (might be due to invalid IL or missing references)
		//IL_2012: Expected O, but got Unknown
		//IL_2bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bdb: Expected O, but got Unknown
		//IL_2cd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce0: Expected O, but got Unknown
		//IL_2dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_2de8: Expected O, but got Unknown
		//IL_2ee6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef0: Expected O, but got Unknown
		//IL_2fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff8: Expected O, but got Unknown
		//IL_30e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ef: Expected O, but got Unknown
		//IL_3198: Unknown result type (might be due to invalid IL or missing references)
		//IL_31a2: Expected O, but got Unknown
		//IL_325c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3266: Expected O, but got Unknown
		//IL_3353: Unknown result type (might be due to invalid IL or missing references)
		//IL_335d: Expected O, but got Unknown
		//IL_3413: Unknown result type (might be due to invalid IL or missing references)
		//IL_341d: Expected O, but got Unknown
		//IL_350e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3518: Expected O, but got Unknown
		//IL_368a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3694: Expected O, but got Unknown
		//IL_3a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a10: Expected O, but got Unknown
		//IL_3b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ba7: Expected O, but got Unknown
		//IL_3c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c6a: Expected O, but got Unknown
		//IL_4d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d50: Expected O, but got Unknown
		//IL_4df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e03: Expected O, but got Unknown
		//IL_4ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ec7: Expected O, but got Unknown
		//IL_4fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fcf: Expected O, but got Unknown
		//IL_5114: Unknown result type (might be due to invalid IL or missing references)
		//IL_5242: Unknown result type (might be due to invalid IL or missing references)
		//IL_544d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5457: Expected O, but got Unknown
		//IL_5555: Unknown result type (might be due to invalid IL or missing references)
		//IL_555f: Expected O, but got Unknown
		//IL_564c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5656: Expected O, but got Unknown
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
		txtMa_Kh = new AsTextBox();
		lblTen_Kh = new Label();
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
		chkGia_tb = new AsCheckBox();
		tabHach_toan = new TabPage();
		SplitContainer1 = new SplitContainer();
		adgvHach_toan = new AsInputDGV();
		dgvcTen_vt_ht = new DataGridViewTextBoxColumn();
		dgvcTien_nt2_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_ck_nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt_nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien2_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_ck_ht = new DataGridViewAsTextNumericColumn();
		dgvcThue_Gtgt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_ht = new DataGridViewAsTextNumericColumn();
		dgvcTk_tl = new DataGridViewAsTextBoxColumn();
		dgvcTk_gv = new DataGridViewAsTextBoxColumn();
		dgvcTk_vt = new DataGridViewAsTextBoxColumn();
		dgvcTk_ck = new DataGridViewAsTextBoxColumn();
		dgvcMa_vt_ht = new DataGridViewTextBoxColumn();
		chkSua_thue = new AsCheckBox();
		chkSua_tien = new AsCheckBox();
		txtT_So_luong = new AsTextNumeric();
		txtT_tt = new AsTextNumeric();
		txtT_Tien_nt2 = new AsTextNumeric();
		txtT_Thue = new AsTextNumeric();
		txtT_thue_nt = new AsTextNumeric();
		lblT_Tt = new Label();
		lblT_Thue = new Label();
		txtT_Tien2 = new AsTextNumeric();
		lblT_Tien = new Label();
		txtT_tt_nt = new AsTextNumeric();
		txtGh_no = new AsTextNumeric();
		Label4 = new Label();
		txtDu13 = new AsTextNumeric();
		Label3 = new Label();
		txtDia_chi_vat = new TextBox();
		lblDia_chi = new Label();
		txtMa_so_thue = new TextBox();
		lblMa_so_thue = new Label();
		adgvDetail = new AsInputDGV();
		dgvcMa_vt = new DataGridViewAsTextBoxColumn();
		dgvcTen_vt = new DataGridViewTextBoxColumn();
		dgvcDvt = new DataGridViewTextBoxColumn();
		dgvcMa_kho = new DataGridViewAsTextBoxColumn();
		dgvcTon = new DataGridViewAsTextNumericColumn();
		dgvcSo_luong = new DataGridViewAsTextNumericColumn();
		dgvcGia_nt2 = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt2 = new DataGridViewAsTextNumericColumn();
		dgvcTL_CK = new DataGridViewAsTextNumericColumn();
		dgvcTien_CK_nt = new DataGridViewAsTextNumericColumn();
		dgvcTs_gtgt = new DataGridViewAsTextNumericColumn();
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
		dgvcSo_hd = new DataGridViewTextBoxColumn();
		txtMa_Httt = new AsTextBox();
		lblTen_Httt = new Label();
		lblMa_httt = new Label();
		Label7 = new Label();
		txtSo_hd = new TextBox();
		Label2 = new Label();
		Label5 = new Label();
		txtT_tien = new AsTextNumeric();
		txtT_tien_nt = new AsTextNumeric();
		tabTain = new TabPage();
		cmdGetTaInFromDetail = new Button();
		ctlTaIn = new ctlTaIn();
		txtNgay_hd = new AsMaskedTextBox();
		Label6 = new Label();
		txtT_ck = new AsTextNumeric();
		txtT_ck_nt = new AsTextNumeric();
		lblT_ck = new Label();
		txtSo_seri_mhd = new TextBox();
		lblSo_seri_mhd = new Label();
		cmdChon_px = new Button();
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
		((Control)SplitContainer1.Panel1).SuspendLayout();
		((Control)SplitContainer1.Panel2).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((ISupportInitialize)adgvHach_toan).BeginInit();
		((ISupportInitialize)adgvDetail).BeginInit();
		((Control)tabTain).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdAdd;
		Point location = new Point(3, 492);
		((Control)obj).Location = location;
		((Control)cmdAdd).TabIndex = 3;
		Button obj2 = cmdPrint;
		location = new Point(73, 492);
		((Control)obj2).Location = location;
		((Control)cmdPrint).TabIndex = 4;
		Button obj3 = cmdLast;
		location = new Point(715, 492);
		((Control)obj3).Location = location;
		((Control)cmdLast).TabIndex = 12;
		Button obj4 = cmdNext;
		location = new Point(690, 492);
		((Control)obj4).Location = location;
		((Control)cmdNext).TabIndex = 11;
		Button obj5 = cmdPrevious;
		location = new Point(665, 492);
		((Control)obj5).Location = location;
		((Control)cmdPrevious).TabIndex = 10;
		Button obj6 = cmdFirst;
		location = new Point(640, 492);
		((Control)obj6).Location = location;
		((Control)cmdFirst).TabIndex = 9;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(215, 128);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct;
		Size size = new Size(38, 13);
		((Control)obj8).Size = size;
		lblSo_Ct.Text = "Số ctừ";
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		Label obj9 = lblNgay_Ct;
		location = new Point(9, 128);
		((Control)obj9).Location = location;
		Label obj10 = lblNgay_Ct;
		size = new Size(50, 13);
		((Control)obj10).Size = size;
		lblNgay_Ct.Text = "Ngày ctừ";
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)5;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(108, 124);
		((Control)asMaskedTextBox).Location = location;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_Ct;
		size = new Size(75, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_Ct).TabIndex = 6;
		((Control)gbPH).Controls.Add((Control)(object)cmdChon_px);
		((Control)gbPH).Controls.Add((Control)(object)txtDu13);
		((Control)gbPH).Controls.Add((Control)(object)Label3);
		((Control)gbPH).Controls.Add((Control)(object)txtGh_no);
		((Control)gbPH).Controls.Add((Control)(object)Label4);
		((Control)gbPH).Controls.Add((Control)(object)txtSo_seri_mhd);
		((Control)gbPH).Controls.Add((Control)(object)lblSo_seri_mhd);
		((Control)gbPH).Controls.Add((Control)(object)txtNgay_hd);
		((Control)gbPH).Controls.Add((Control)(object)Label6);
		((Control)gbPH).Controls.Add((Control)(object)Label7);
		((Control)gbPH).Controls.Add((Control)(object)txtDia_chi_vat);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)lblDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)txtSo_hd);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Httt);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Httt);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_httt);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Kh);
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
		size = new Size(735, 177);
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
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_hd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDia_chi_vat, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_hd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_seri_mhd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_seri_mhd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtGh_no, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDu13, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cmdChon_px, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(559, 492);
		((Control)splitButton).Location = location;
		((Control)cmdSearch).TabIndex = 8;
		((Control)AsTabControl).Controls.Add((Control)(object)tabHach_toan);
		((Control)AsTabControl).Controls.Add((Control)(object)tabTain);
		AsTabControl asTabControl = AsTabControl;
		location = new Point(0, 177);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(741, 216);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabTain, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabHach_toan, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabOptFields, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabDetail, 0);
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj13 = tabDetail;
		size = new Size(733, 187);
		((Control)obj13).Size = size;
		TabPage obj14 = tabOptFields;
		size = new Size(733, 187);
		((Control)obj14).Size = size;
		Button obj15 = cmdCopy;
		location = new Point(283, 492);
		((Control)obj15).Location = location;
		((Control)cmdCopy).TabIndex = 7;
		Button obj16 = cmdDelete;
		location = new Point(213, 492);
		((Control)obj16).Location = location;
		((Control)cmdDelete).TabIndex = 6;
		Button obj17 = cmdEdit;
		location = new Point(143, 492);
		((Control)obj17).Location = location;
		((Control)cmdEdit).TabIndex = 5;
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		TextBox obj18 = txtSo_Ct;
		location = new Point(274, 124);
		((Control)obj18).Location = location;
		((Control)txtSo_Ct).TabIndex = 7;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(108, 14);
		((Control)asTextBox).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		txtMa_Kh.LookupWhereCondition = "isKh=1";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		txtMa_Kh.SD = true;
		AsTextBox asTextBox2 = txtMa_Kh;
		size = new Size(75, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Kh).TabIndex = 0;
		txtMa_Kh.UseAutoCompleteSource = true;
		txtMa_Kh.ValidReturnFieldList = "ten_kh,dia_chi,ma_so_thue,nguoi_gd,tel,gh_no,ma_tt";
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj19 = lblTen_Kh;
		location = new Point(189, 18);
		((Control)obj19).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj20 = lblTen_Kh;
		size = new Size(322, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_Kh).TabIndex = 251;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj21 = lblMa_Kh;
		location = new Point(9, 18);
		((Control)obj21).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj22 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj22).Size = size;
		((Control)lblMa_Kh).TabIndex = 139;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj23 = lblNguoi_Gd;
		location = new Point(9, 61);
		((Control)obj23).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj24 = lblNguoi_Gd;
		size = new Size(82, 14);
		((Control)obj24).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 143;
		lblNguoi_Gd.Text = "Người giao dịch";
		TextBox obj25 = txtDien_giai;
		location = new Point(108, 80);
		((Control)obj25).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj26 = txtDien_giai;
		size = new Size(403, 20);
		((Control)obj26).Size = size;
		((Control)txtDien_giai).TabIndex = 4;
		TextBox obj27 = txtNguoi_Gd;
		location = new Point(108, 58);
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
		location = new Point(9, 84);
		((Control)obj29).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj30 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj30).Size = size;
		((Control)lblDien_giai).TabIndex = 144;
		lblDien_giai.Text = "Diễn giải";
		txtSo_Seri.CharacterCasing = (CharacterCasing)1;
		TextBox obj31 = txtSo_Seri;
		location = new Point(651, 37);
		((Control)obj31).Location = location;
		((Control)txtSo_Seri).Name = "txtSo_Seri";
		TextBox obj32 = txtSo_Seri;
		size = new Size(78, 20);
		((Control)obj32).Size = size;
		((Control)txtSo_Seri).TabIndex = 9;
		lblSo_seri.AutoSize = true;
		Label obj33 = lblSo_seri;
		location = new Point(558, 41);
		((Control)obj33).Location = location;
		((Control)lblSo_seri).Name = "lblSo_seri";
		Label obj34 = lblSo_seri;
		size = new Size(39, 13);
		((Control)obj34).Size = size;
		((Control)lblSo_seri).TabIndex = 232;
		lblSo_seri.Text = "Số seri";
		txtNgay_lct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_lct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_lct;
		location = new Point(651, 103);
		((Control)asMaskedTextBox3).Location = location;
		((MaskedTextBox)txtNgay_lct).Mask = "##/##/####";
		((Control)txtNgay_lct).Name = "txtNgay_lct";
		((MaskedTextBox)txtNgay_lct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_lct;
		size = new Size(78, 20);
		((Control)asMaskedTextBox4).Size = size;
		((Control)txtNgay_lct).TabIndex = 12;
		((MaskedTextBox)txtNgay_lct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_lct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox5.Value = dateTime;
		lblNgay_Lct.AutoSize = true;
		lblNgay_Lct.ImeMode = (ImeMode)0;
		Label obj35 = lblNgay_Lct;
		location = new Point(558, 107);
		((Control)obj35).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj36 = lblNgay_Lct;
		size = new Size(49, 13);
		((Control)obj36).Size = size;
		((Control)lblNgay_Lct).TabIndex = 234;
		lblNgay_Lct.Text = "Ngày lập";
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(665, 125);
		((Control)asTextNumeric).Location = location;
		txtTy_gia.Mask = "### ###.##";
		((Control)txtTy_gia).Name = "txtTy_gia";
		AsTextNumeric asTextNumeric2 = txtTy_gia;
		size = new Size(64, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTy_gia).TabIndex = 14;
		((TextBox)txtTy_gia).Text = "0.00";
		((TextBox)txtTy_gia).TextAlign = (HorizontalAlignment)1;
		txtTy_gia.Value = 0.0;
		((ComboBox)cboMa_NT).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboMa_NT).Enabled = false;
		((ListControl)cboMa_NT).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_NT;
		location = new Point(613, 125);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(47, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 13;
		lblMa_Nt.AutoSize = true;
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj37 = lblMa_Nt;
		location = new Point(558, 129);
		((Control)obj37).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj38 = lblMa_Nt;
		size = new Size(36, 13);
		((Control)obj38).Size = size;
		((Control)lblMa_Nt).TabIndex = 237;
		lblMa_Nt.Text = "Tỷ giá";
		txtTk_pt.AutoLookup = true;
		txtTk_pt.AutoValid = true;
		((TextBoxBase)txtTk_pt).BackColor = SystemColors.Info;
		((TextBox)txtTk_pt).CharacterCasing = (CharacterCasing)1;
		((Control)txtTk_pt).Enabled = false;
		AsTextBox asTextBox3 = txtTk_pt;
		location = new Point(100, 2);
		((Control)asTextBox3).Location = location;
		txtTk_pt.LookupCodeName = "TK";
		txtTk_pt.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_pt).Name = "txtTk_pt";
		txtTk_pt.NameControl = null;
		txtTk_pt.SD = true;
		AsTextBox asTextBox4 = txtTk_pt;
		size = new Size(78, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk_pt).TabIndex = 15;
		txtTk_pt.UseAutoCompleteSource = false;
		lblTk_pt.ImeMode = (ImeMode)0;
		Label obj39 = lblTk_pt;
		location = new Point(0, 5);
		((Control)obj39).Location = location;
		((Control)lblTk_pt).Name = "lblTk_pt";
		Label obj40 = lblTk_pt;
		size = new Size(98, 14);
		((Control)obj40).Size = size;
		((Control)lblTk_pt).TabIndex = 239;
		lblTk_pt.Text = "Tài khoản có";
		txtTk_thue.AutoLookup = true;
		txtTk_thue.AutoValid = true;
		((TextBoxBase)txtTk_thue).BackColor = SystemColors.Info;
		((TextBox)txtTk_thue).CharacterCasing = (CharacterCasing)1;
		((Control)txtTk_thue).Enabled = false;
		AsTextBox asTextBox5 = txtTk_thue;
		location = new Point(290, 2);
		((Control)asTextBox5).Location = location;
		txtTk_thue.LookupCodeName = "TK";
		txtTk_thue.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_thue).Name = "txtTk_thue";
		txtTk_thue.NameControl = null;
		txtTk_thue.SD = true;
		AsTextBox asTextBox6 = txtTk_thue;
		size = new Size(78, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTk_thue).TabIndex = 16;
		txtTk_thue.UseAutoCompleteSource = false;
		lblTk_thue.ImeMode = (ImeMode)0;
		Label obj41 = lblTk_thue;
		location = new Point(186, 5);
		((Control)obj41).Location = location;
		((Control)lblTk_thue).Name = "lblTk_thue";
		Label obj42 = lblTk_thue;
		size = new Size(98, 14);
		((Control)obj42).Size = size;
		((Control)lblTk_thue).TabIndex = 242;
		lblTk_thue.Text = "Tài khoản thuế";
		((Control)chkGia_tb).Anchor = (AnchorStyles)6;
		((ButtonBase)chkGia_tb).AutoSize = true;
		chkGia_tb.Checked = false;
		AsCheckBox asCheckBox = chkGia_tb;
		location = new Point(4, 466);
		((Control)asCheckBox).Location = location;
		((Control)chkGia_tb).Name = "chkGia_tb";
		AsCheckBox asCheckBox2 = chkGia_tb;
		size = new Size(143, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkGia_tb).TabIndex = 2;
		((Control)chkGia_tb).TabStop = false;
		((ButtonBase)chkGia_tb).Text = "Nhập theo giá trung bình";
		chkGia_tb.TextValue = "0";
		((ButtonBase)chkGia_tb).UseVisualStyleBackColor = true;
		tabHach_toan.BackColor = SystemColors.Control;
		((Control)tabHach_toan).Controls.Add((Control)(object)SplitContainer1);
		TabPage obj43 = tabHach_toan;
		location = new Point(4, 25);
		obj43.Location = location;
		((Control)tabHach_toan).Name = "tabHach_toan";
		TabPage obj44 = tabHach_toan;
		Padding val38 = default(Padding);
		((Padding)(ref val38))._002Ector(3);
		((Control)obj44).Padding = val38;
		TabPage obj45 = tabHach_toan;
		size = new Size(733, 187);
		((Control)obj45).Size = size;
		tabHach_toan.TabIndex = 1;
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
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)lblTk_pt);
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)lblTk_thue);
		SplitContainer splitContainer2 = SplitContainer1;
		size = new Size(727, 181);
		((Control)splitContainer2).Size = size;
		SplitContainer1.SplitterDistance = 152;
		((Control)SplitContainer1).TabIndex = 0;
		((DataGridView)adgvHach_toan).AllowUserToAddRows = false;
		((DataGridView)adgvHach_toan).AllowUserToDeleteRows = false;
		((DataGridView)adgvHach_toan).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvHach_toan).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)adgvHach_toan).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvHach_toan).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[14]
		{
			(DataGridViewColumn)dgvcTen_vt_ht,
			dgvcTien_nt2_ht,
			dgvcTien_ck_nt_ht,
			dgvcThue_gtgt_nt_ht,
			dgvcTien_nt_ht,
			dgvcTien2_ht,
			dgvcTien_ck_ht,
			dgvcThue_Gtgt_ht,
			dgvcTien_ht,
			dgvcTk_tl,
			dgvcTk_gv,
			dgvcTk_vt,
			dgvcTk_ck,
			(DataGridViewColumn)dgvcMa_vt_ht
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvHach_toan).DefaultCellStyle = val2;
		((Control)adgvHach_toan).Dock = (DockStyle)5;
		((DataGridView)adgvHach_toan).GridColor = SystemColors.Control;
		adgvHach_toan.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV = adgvHach_toan;
		location = new Point(0, 0);
		((Control)asInputDGV).Location = location;
		((Control)adgvHach_toan).Name = "adgvHach_toan";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).RowHeadersDefaultCellStyle = val3;
		((DataGridView)adgvHach_toan).RowHeadersWidth = 35;
		((DataGridView)adgvHach_toan).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = adgvHach_toan;
		size = new Size(727, 152);
		((Control)asInputDGV2).Size = size;
		((Control)adgvHach_toan).TabIndex = 0;
		((DataGridViewColumn)dgvcTen_vt_ht).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vt_ht).Frozen = true;
		((DataGridViewColumn)dgvcTen_vt_ht).HeaderText = "Tên vật tư";
		((DataGridViewColumn)dgvcTen_vt_ht).Name = "dgvcTen_vt_ht";
		((DataGridViewColumn)dgvcTen_vt_ht).ReadOnly = true;
		dgvcTen_vt_ht.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_vt_ht).Width = 170;
		((DataGridViewColumn)dgvcTien_nt2_ht).DataPropertyName = "tien_nt2";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2_ht).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcTien_nt2_ht).HeaderText = "Tiền hàng";
		dgvcTien_nt2_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2_ht).Name = "dgvcTien_nt2_ht";
		((DataGridViewColumn)dgvcTien_nt2_ht).ReadOnly = true;
		dgvcTien_nt2_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt2_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt2_ht).Width = 80;
		((DataGridViewColumn)dgvcTien_ck_nt_ht).DataPropertyName = "tien_ck_nt";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck_nt_ht).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcTien_ck_nt_ht).HeaderText = "C. khấu";
		dgvcTien_ck_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck_nt_ht).Name = "dgvcTien_ck_nt_ht";
		((DataGridViewColumn)dgvcTien_ck_nt_ht).Resizable = (DataGridViewTriState)1;
		dgvcTien_ck_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ck_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_ck_nt_ht).Width = 90;
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).DataPropertyName = "thue_gtgt_nt";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).HeaderText = "VAT";
		dgvcThue_gtgt_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).Name = "dgvcThue_gtgt_nt_ht";
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).ReadOnly = true;
		dgvcThue_gtgt_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).ToolTipText = "Thuế giá trị gia tăng";
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).Width = 70;
		((DataGridViewColumn)dgvcTien_nt_ht).DataPropertyName = "tien_nt";
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = "Tiền vốn";
		dgvcTien_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).Name = "dgvcTien_nt_ht";
		((DataGridViewColumn)dgvcTien_nt_ht).ReadOnly = true;
		dgvcTien_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt_ht).Width = 90;
		((DataGridViewColumn)dgvcTien2_ht).DataPropertyName = "tien2";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien2_ht).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcTien2_ht).HeaderText = "Tiền bán VND";
		dgvcTien2_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien2_ht).Name = "dgvcTien2_ht";
		((DataGridViewColumn)dgvcTien2_ht).ReadOnly = true;
		dgvcTien2_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien2_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien2_ht).Width = 90;
		((DataGridViewColumn)dgvcTien_ck_ht).DataPropertyName = "tien_ck";
		val9.Alignment = (DataGridViewContentAlignment)64;
		val9.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck_ht).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcTien_ck_ht).HeaderText = "C.Khấu VND";
		dgvcTien_ck_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck_ht).Name = "dgvcTien_ck_ht";
		dgvcTien_ck_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ck_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_ck_ht).Width = 90;
		((DataGridViewColumn)dgvcThue_Gtgt_ht).DataPropertyName = "thue_gtgt";
		val10.Alignment = (DataGridViewContentAlignment)64;
		val10.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Gtgt_ht).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcThue_Gtgt_ht).HeaderText = "VAT VND";
		dgvcThue_Gtgt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_Gtgt_ht).Name = "dgvcThue_Gtgt_ht";
		((DataGridViewColumn)dgvcThue_Gtgt_ht).ReadOnly = true;
		dgvcThue_Gtgt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_Gtgt_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_Gtgt_ht).Width = 80;
		((DataGridViewColumn)dgvcTien_ht).DataPropertyName = "tien";
		val11.Alignment = (DataGridViewContentAlignment)64;
		val11.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ht).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcTien_ht).HeaderText = "Tiền vốn VND";
		dgvcTien_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ht).Name = "dgvcTien_ht";
		((DataGridViewColumn)dgvcTien_ht).ReadOnly = true;
		dgvcTien_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_ht).Width = 90;
		dgvcTk_tl.AutoFill = true;
		dgvcTk_tl.AutoLookup = true;
		dgvcTk_tl.AutoValid = true;
		((DataGridViewColumn)dgvcTk_tl).DataPropertyName = "tk_tl";
		val12.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_tl).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcTk_tl).HeaderText = "Tk hbtl";
		dgvcTk_tl.LookupCodeName = "TK";
		dgvcTk_tl.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_tl).Name = "dgvcTk_tl";
		dgvcTk_tl.ReceiverValidFieldList = "ten_tk_tl";
		dgvcTk_tl.SD = true;
		dgvcTk_tl.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_tl.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_tl).Width = 65;
		dgvcTk_gv.AutoFill = true;
		dgvcTk_gv.AutoLookup = true;
		dgvcTk_gv.AutoValid = true;
		((DataGridViewColumn)dgvcTk_gv).DataPropertyName = "tk_gv";
		val13.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_gv).DefaultCellStyle = val13;
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
		val14.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_vt).DefaultCellStyle = val14;
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
		val15.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_ck).DefaultCellStyle = val15;
		((DataGridViewColumn)dgvcTk_ck).HeaderText = "Tk ck";
		dgvcTk_ck.LookupCodeName = "TK";
		dgvcTk_ck.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_ck).Name = "dgvcTk_ck";
		dgvcTk_ck.ReceiverValidFieldList = "";
		dgvcTk_ck.SD = true;
		dgvcTk_ck.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_ck.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcTk_ck).Width = 65;
		((DataGridViewColumn)dgvcMa_vt_ht).DataPropertyName = "ma_vt";
		((DataGridViewColumn)dgvcMa_vt_ht).HeaderText = "Mã hàng";
		((DataGridViewColumn)dgvcMa_vt_ht).Name = "dgvcMa_vt_ht";
		((DataGridViewColumn)dgvcMa_vt_ht).ReadOnly = true;
		dgvcMa_vt_ht.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_vt_ht).Visible = false;
		((DataGridViewColumn)dgvcMa_vt_ht).Width = 70;
		((Control)chkSua_thue).Anchor = (AnchorStyles)6;
		((ButtonBase)chkSua_thue).AutoSize = true;
		chkSua_thue.Checked = false;
		((Control)chkSua_thue).Enabled = false;
		AsCheckBox asCheckBox3 = chkSua_thue;
		location = new Point(445, 498);
		((Control)asCheckBox3).Location = location;
		((Control)chkSua_thue).Name = "chkSua_thue";
		AsCheckBox asCheckBox4 = chkSua_thue;
		size = new Size(89, 17);
		((Control)asCheckBox4).Size = size;
		((Control)chkSua_thue).TabIndex = 250;
		((Control)chkSua_thue).TabStop = false;
		((ButtonBase)chkSua_thue).Text = "Sửa tiền thuế";
		chkSua_thue.TextValue = "0";
		((ButtonBase)chkSua_thue).UseVisualStyleBackColor = true;
		((Control)chkSua_thue).Visible = false;
		((Control)chkSua_tien).Anchor = (AnchorStyles)6;
		((ButtonBase)chkSua_tien).AutoSize = true;
		chkSua_tien.Checked = false;
		((Control)chkSua_tien).Enabled = false;
		AsCheckBox asCheckBox5 = chkSua_tien;
		location = new Point(339, 498);
		((Control)asCheckBox5).Location = location;
		((Control)chkSua_tien).Name = "chkSua_tien";
		AsCheckBox asCheckBox6 = chkSua_tien;
		size = new Size(92, 17);
		((Control)asCheckBox6).Size = size;
		((Control)chkSua_tien).TabIndex = 254;
		((Control)chkSua_tien).TabStop = false;
		((ButtonBase)chkSua_tien).Text = "Sửa tiền hàng";
		chkSua_tien.TextValue = "0";
		((ButtonBase)chkSua_tien).UseVisualStyleBackColor = true;
		((Control)chkSua_tien).Visible = false;
		((Control)txtT_So_luong).Anchor = (AnchorStyles)6;
		txtT_So_luong.DecimalSymbol = ".";
		((Control)txtT_So_luong).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtT_So_luong;
		location = new Point(61, 399);
		((Control)asTextNumeric3).Location = location;
		txtT_So_luong.Mask = "### ### ### ###";
		((Control)txtT_So_luong).Name = "txtT_So_luong";
		((TextBoxBase)txtT_So_luong).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtT_So_luong;
		size = new Size(83, 20);
		((Control)asTextNumeric4).Size = size;
		txtT_So_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((Control)txtT_So_luong).TabIndex = 270;
		((Control)txtT_So_luong).TabStop = false;
		((TextBox)txtT_So_luong).Text = "0";
		((TextBox)txtT_So_luong).TextAlign = (HorizontalAlignment)1;
		txtT_So_luong.Value = 0.0;
		((Control)txtT_tt).Anchor = (AnchorStyles)6;
		txtT_tt.DecimalSymbol = ".";
		((Control)txtT_tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric5 = txtT_tt;
		location = new Point(632, 467);
		((Control)asTextNumeric5).Location = location;
		txtT_tt.Mask = "### ### ### ###";
		((Control)txtT_tt).Name = "txtT_tt";
		((TextBoxBase)txtT_tt).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtT_tt;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		txtT_tt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_tt).TabIndex = 231;
		((Control)txtT_tt).TabStop = false;
		((TextBox)txtT_tt).Text = "0";
		((TextBox)txtT_tt).TextAlign = (HorizontalAlignment)1;
		txtT_tt.Value = 0.0;
		((Control)txtT_Tien_nt2).Anchor = (AnchorStyles)6;
		txtT_Tien_nt2.DecimalSymbol = ".";
		((Control)txtT_Tien_nt2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric7 = txtT_Tien_nt2;
		location = new Point(526, 399);
		((Control)asTextNumeric7).Location = location;
		txtT_Tien_nt2.Mask = "### ### ### ###";
		((Control)txtT_Tien_nt2).Name = "txtT_Tien_nt2";
		((TextBoxBase)txtT_Tien_nt2).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_Tien_nt2;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_Tien_nt2.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_Tien_nt2).TabIndex = 236;
		((Control)txtT_Tien_nt2).TabStop = false;
		((TextBox)txtT_Tien_nt2).Text = "0";
		((TextBox)txtT_Tien_nt2).TextAlign = (HorizontalAlignment)1;
		txtT_Tien_nt2.Value = 0.0;
		((Control)txtT_Thue).Anchor = (AnchorStyles)6;
		txtT_Thue.DecimalSymbol = ".";
		((Control)txtT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric9 = txtT_Thue;
		location = new Point(632, 445);
		((Control)asTextNumeric9).Location = location;
		txtT_Thue.Mask = "### ### ### ###";
		((Control)txtT_Thue).Name = "txtT_Thue";
		((TextBoxBase)txtT_Thue).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtT_Thue;
		size = new Size(100, 20);
		((Control)asTextNumeric10).Size = size;
		txtT_Thue.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Thue).TabIndex = 230;
		((Control)txtT_Thue).TabStop = false;
		((TextBox)txtT_Thue).Text = "0";
		((TextBox)txtT_Thue).TextAlign = (HorizontalAlignment)1;
		txtT_Thue.Value = 0.0;
		((Control)txtT_thue_nt).Anchor = (AnchorStyles)6;
		txtT_thue_nt.DecimalSymbol = ".";
		((Control)txtT_thue_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric11 = txtT_thue_nt;
		location = new Point(526, 445);
		((Control)asTextNumeric11).Location = location;
		txtT_thue_nt.Mask = "### ### ### ###";
		((Control)txtT_thue_nt).Name = "txtT_thue_nt";
		((TextBoxBase)txtT_thue_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtT_thue_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric12).Size = size;
		txtT_thue_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_thue_nt).TabIndex = 237;
		((Control)txtT_thue_nt).TabStop = false;
		((TextBox)txtT_thue_nt).Text = "0";
		((TextBox)txtT_thue_nt).TextAlign = (HorizontalAlignment)1;
		txtT_thue_nt.Value = 0.0;
		((Control)lblT_Tt).Anchor = (AnchorStyles)6;
		((Control)lblT_Tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		lblT_Tt.ImeMode = (ImeMode)0;
		Label obj46 = lblT_Tt;
		location = new Point(438, 470);
		((Control)obj46).Location = location;
		((Control)lblT_Tt).Name = "lblT_Tt";
		Label obj47 = lblT_Tt;
		size = new Size(82, 13);
		((Control)obj47).Size = size;
		((Control)lblT_Tt).TabIndex = 233;
		lblT_Tt.Text = "Thanh toán";
		lblT_Tt.TextAlign = (ContentAlignment)16;
		((Control)lblT_Thue).Anchor = (AnchorStyles)6;
		((Control)lblT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Thue.ImeMode = (ImeMode)0;
		Label obj48 = lblT_Thue;
		location = new Point(438, 448);
		((Control)obj48).Location = location;
		((Control)lblT_Thue).Name = "lblT_Thue";
		Label obj49 = lblT_Thue;
		size = new Size(82, 13);
		((Control)obj49).Size = size;
		((Control)lblT_Thue).TabIndex = 232;
		lblT_Thue.Text = "Thuế GTGT";
		lblT_Thue.TextAlign = (ContentAlignment)16;
		((Control)txtT_Tien2).Anchor = (AnchorStyles)6;
		txtT_Tien2.DecimalSymbol = ".";
		((Control)txtT_Tien2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric13 = txtT_Tien2;
		location = new Point(632, 399);
		((Control)asTextNumeric13).Location = location;
		txtT_Tien2.Mask = "### ### ### ###";
		((Control)txtT_Tien2).Name = "txtT_Tien2";
		((TextBoxBase)txtT_Tien2).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtT_Tien2;
		size = new Size(100, 20);
		((Control)asTextNumeric14).Size = size;
		txtT_Tien2.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tien2).TabIndex = 229;
		((Control)txtT_Tien2).TabStop = false;
		((TextBox)txtT_Tien2).Text = "0";
		((TextBox)txtT_Tien2).TextAlign = (HorizontalAlignment)1;
		txtT_Tien2.Value = 0.0;
		((Control)lblT_Tien).Anchor = (AnchorStyles)6;
		((Control)lblT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Tien.ImeMode = (ImeMode)0;
		Label obj50 = lblT_Tien;
		location = new Point(5, 402);
		((Control)obj50).Location = location;
		((Control)lblT_Tien).Name = "lblT_Tien";
		Label obj51 = lblT_Tien;
		size = new Size(55, 13);
		((Control)obj51).Size = size;
		((Control)lblT_Tien).TabIndex = 228;
		lblT_Tien.Text = "Số lượng";
		lblT_Tien.TextAlign = (ContentAlignment)16;
		((Control)txtT_tt_nt).Anchor = (AnchorStyles)6;
		txtT_tt_nt.DecimalSymbol = ".";
		((Control)txtT_tt_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric15 = txtT_tt_nt;
		location = new Point(526, 467);
		((Control)asTextNumeric15).Location = location;
		txtT_tt_nt.Mask = "### ### ### ###";
		((Control)txtT_tt_nt).Name = "txtT_tt_nt";
		((TextBoxBase)txtT_tt_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric16 = txtT_tt_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric16).Size = size;
		txtT_tt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tt_nt).TabIndex = 238;
		((Control)txtT_tt_nt).TabStop = false;
		((TextBox)txtT_tt_nt).Text = "0";
		((TextBox)txtT_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tt_nt.Value = 0.0;
		txtGh_no.DecimalSymbol = ".";
		((Control)txtGh_no).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric17 = txtGh_no;
		location = new Point(108, 146);
		((Control)asTextNumeric17).Location = location;
		txtGh_no.Mask = "### ### ### ###";
		((Control)txtGh_no).Name = "txtGh_no";
		((TextBoxBase)txtGh_no).ReadOnly = true;
		AsTextNumeric asTextNumeric18 = txtGh_no;
		size = new Size(100, 20);
		((Control)asTextNumeric18).Size = size;
		txtGh_no.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtGh_no).TabIndex = 256;
		((Control)txtGh_no).TabStop = false;
		((TextBox)txtGh_no).Text = "0";
		((TextBox)txtGh_no).TextAlign = (HorizontalAlignment)1;
		txtGh_no.Value = 0.0;
		Label4.AutoSize = true;
		Label4.ImeMode = (ImeMode)0;
		Label label = Label4;
		location = new Point(10, 150);
		((Control)label).Location = location;
		((Control)Label4).Name = "Label4";
		Label label2 = Label4;
		size = new Size(61, 13);
		((Control)label2).Size = size;
		((Control)Label4).TabIndex = 255;
		Label4.Text = "Giới hạn nợ";
		txtDu13.DecimalSymbol = ".";
		((Control)txtDu13).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric19 = txtDu13;
		location = new Point(411, 146);
		((Control)asTextNumeric19).Location = location;
		txtDu13.Mask = "### ### ### ###";
		((Control)txtDu13).Name = "txtDu13";
		((TextBoxBase)txtDu13).ReadOnly = true;
		AsTextNumeric asTextNumeric20 = txtDu13;
		size = new Size(100, 20);
		((Control)asTextNumeric20).Size = size;
		txtDu13.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtDu13).TabIndex = 254;
		((Control)txtDu13).TabStop = false;
		((TextBox)txtDu13).Text = "0";
		((TextBox)txtDu13).TextAlign = (HorizontalAlignment)1;
		txtDu13.Value = 0.0;
		Label3.AutoSize = true;
		Label3.ImeMode = (ImeMode)0;
		Label label3 = Label3;
		location = new Point(305, 150);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		Label label4 = Label3;
		size = new Size(64, 13);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 253;
		Label3.Text = "Dư hiện thời";
		TextBox obj52 = txtDia_chi_vat;
		location = new Point(108, 36);
		((Control)obj52).Location = location;
		((Control)txtDia_chi_vat).Name = "txtDia_chi_vat";
		TextBox obj53 = txtDia_chi_vat;
		size = new Size(403, 20);
		((Control)obj53).Size = size;
		((Control)txtDia_chi_vat).TabIndex = 1;
		lblDia_chi.AutoSize = true;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj54 = lblDia_chi;
		location = new Point(10, 40);
		((Control)obj54).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj55 = lblDia_chi;
		size = new Size(40, 13);
		((Control)obj55).Size = size;
		((Control)lblDia_chi).TabIndex = 146;
		lblDia_chi.Text = "Địa chỉ";
		TextBox obj56 = txtMa_so_thue;
		location = new Point(383, 58);
		((Control)obj56).Location = location;
		((Control)txtMa_so_thue).Name = "txtMa_so_thue";
		TextBox obj57 = txtMa_so_thue;
		size = new Size(128, 20);
		((Control)obj57).Size = size;
		((Control)txtMa_so_thue).TabIndex = 3;
		lblMa_so_thue.AutoSize = true;
		lblMa_so_thue.ImeMode = (ImeMode)0;
		Label obj58 = lblMa_so_thue;
		location = new Point(277, 62);
		((Control)obj58).Location = location;
		((Control)lblMa_so_thue).Name = "lblMa_so_thue";
		Label obj59 = lblMa_so_thue;
		size = new Size(60, 13);
		((Control)obj59).Size = size;
		((Control)lblMa_so_thue).TabIndex = 246;
		lblMa_so_thue.Text = "Mã số thuế";
		lblMa_so_thue.TextAlign = (ContentAlignment)16;
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
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[22]
		{
			dgvcMa_vt,
			(DataGridViewColumn)dgvcTen_vt,
			(DataGridViewColumn)dgvcDvt,
			dgvcMa_kho,
			dgvcTon,
			dgvcSo_luong,
			dgvcGia_nt2,
			dgvcTien_nt2,
			dgvcTL_CK,
			dgvcTien_CK_nt,
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
			dgvcMa_Nvkd,
			(DataGridViewColumn)dgvcSo_hd
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
		size = new Size(727, 181);
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
		dgvcMa_vt.ReceiverValidFieldList = "ten_vt,dvt,tk_vt,tk_gv,tk_dt,tk_ck,tk_tl,tk_km,ton_kho,gia_ton,ts_gtgt,ma_thue,ma_kho";
		dgvcMa_vt.SD = true;
		dgvcMa_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_vt.ValidReturnFieldList = "ten_vt,dvt,tk_vt,tk_gv,tk_dt,tk_ck,tk_tl,tk_km,ton_kho,gia_ton,ts_gtgt,ma_thue,ma_kho,ma_vitri";
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
		((DataGridViewColumn)dgvcMa_kho).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
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
		((DataGridViewColumn)dgvcMa_kho).Width = 32;
		((DataGridViewColumn)dgvcTon).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcTon).DataPropertyName = "ton";
		val21.Alignment = (DataGridViewContentAlignment)64;
		val21.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTon).DefaultCellStyle = val21;
		((DataGridViewColumn)dgvcTon).HeaderText = "Tồn";
		dgvcTon.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTon).Name = "dgvcTon";
		((DataGridViewColumn)dgvcTon).ReadOnly = true;
		dgvcTon.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTon).Width = 32;
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
		((DataGridViewColumn)dgvcGia_nt2).DataPropertyName = "gia_nt2";
		val23.Alignment = (DataGridViewContentAlignment)64;
		val23.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt2).DefaultCellStyle = val23;
		((DataGridViewColumn)dgvcGia_nt2).HeaderText = "Giá";
		dgvcGia_nt2.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt2).Name = "dgvcGia_nt2";
		dgvcGia_nt2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia_nt2.SpecialType = Commons.NumericSpecialType.FCPrice;
		((DataGridViewColumn)dgvcGia_nt2).Width = 80;
		((DataGridViewColumn)dgvcTien_nt2).DataPropertyName = "tien_nt2";
		val24.Alignment = (DataGridViewContentAlignment)64;
		val24.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2).DefaultCellStyle = val24;
		((DataGridViewColumn)dgvcTien_nt2).HeaderText = "Tiền bán";
		dgvcTien_nt2.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2).Name = "dgvcTien_nt2";
		((DataGridViewColumn)dgvcTien_nt2).ReadOnly = true;
		dgvcTien_nt2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt2.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt2).Width = 90;
		((DataGridViewColumn)dgvcTL_CK).DataPropertyName = "TL_CK";
		val25.Alignment = (DataGridViewContentAlignment)64;
		val25.Format = "####.##";
		((DataGridViewColumn)dgvcTL_CK).DefaultCellStyle = val25;
		((DataGridViewColumn)dgvcTL_CK).HeaderText = "% CK";
		dgvcTL_CK.Mask = "####.##";
		((DataGridViewColumn)dgvcTL_CK).Name = "dgvcTL_CK";
		((DataGridViewColumn)dgvcTL_CK).Resizable = (DataGridViewTriState)1;
		dgvcTL_CK.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTL_CK).Width = 60;
		((DataGridViewColumn)dgvcTien_CK_nt).DataPropertyName = "TIEN_CK_NT";
		val26.Alignment = (DataGridViewContentAlignment)64;
		val26.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_CK_nt).DefaultCellStyle = val26;
		((DataGridViewColumn)dgvcTien_CK_nt).HeaderText = "C.Khấu";
		dgvcTien_CK_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_CK_nt).Name = "dgvcTien_CK_nt";
		((DataGridViewColumn)dgvcTien_CK_nt).ReadOnly = true;
		dgvcTien_CK_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_CK_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTs_gtgt).DataPropertyName = "ts_gtgt";
		val27.Alignment = (DataGridViewContentAlignment)64;
		val27.Format = "##.##";
		((DataGridViewColumn)dgvcTs_gtgt).DefaultCellStyle = val27;
		((DataGridViewColumn)dgvcTs_gtgt).HeaderText = "% VAT";
		dgvcTs_gtgt.Mask = "##.##";
		((DataGridViewColumn)dgvcTs_gtgt).Name = "dgvcTs_gtgt";
		dgvcTs_gtgt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTs_gtgt).Width = 45;
		((DataGridViewColumn)dgvcThue_gtgt_nt).DataPropertyName = "thue_gtgt_nt";
		val28.Alignment = (DataGridViewContentAlignment)64;
		val28.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).DefaultCellStyle = val28;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = "VAT";
		dgvcThue_gtgt_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).Name = "dgvcThue_gtgt_nt";
		((DataGridViewColumn)dgvcThue_gtgt_nt).ReadOnly = true;
		dgvcThue_gtgt_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_gtgt_nt).Width = 80;
		((DataGridViewColumn)dgvcGia2).DataPropertyName = "gia2";
		val29.Alignment = (DataGridViewContentAlignment)64;
		val29.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcGia2).DefaultCellStyle = val29;
		((DataGridViewColumn)dgvcGia2).HeaderText = "Giá VND";
		dgvcGia2.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcGia2).Name = "dgvcGia2";
		((DataGridViewColumn)dgvcGia2).ReadOnly = true;
		dgvcGia2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia2.SpecialType = Commons.NumericSpecialType.ACPrice;
		((DataGridViewColumn)dgvcGia2).Width = 80;
		((DataGridViewColumn)dgvcTien2).DataPropertyName = "tien2";
		val30.Alignment = (DataGridViewContentAlignment)64;
		val30.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcTien2).DefaultCellStyle = val30;
		((DataGridViewColumn)dgvcTien2).HeaderText = "T. bán VND";
		dgvcTien2.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcTien2).Name = "dgvcTien2";
		((DataGridViewColumn)dgvcTien2).ReadOnly = true;
		dgvcTien2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien2.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien2).Width = 90;
		((DataGridViewColumn)dgvcTien_ck).DataPropertyName = "TIEN_CK";
		val31.Alignment = (DataGridViewContentAlignment)64;
		val31.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcTien_ck).DefaultCellStyle = val31;
		((DataGridViewColumn)dgvcTien_ck).HeaderText = "C.Khấu VND";
		dgvcTien_ck.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcTien_ck).Name = "dgvcTien_ck";
		((DataGridViewColumn)dgvcTien_ck).ReadOnly = true;
		dgvcTien_ck.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ck.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_ck).Width = 90;
		((DataGridViewColumn)dgvcThue_gtgt).DataPropertyName = "thue_gtgt";
		val32.Alignment = (DataGridViewContentAlignment)64;
		val32.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcThue_gtgt).DefaultCellStyle = val32;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = "VAT VND";
		dgvcThue_gtgt.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcThue_gtgt).Name = "dgvcThue_gtgt";
		((DataGridViewColumn)dgvcThue_gtgt).ReadOnly = true;
		dgvcThue_gtgt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_gtgt).Width = 80;
		((DataGridViewColumn)dgvcGia_nt).DataPropertyName = "gia_nt";
		val33.Alignment = (DataGridViewContentAlignment)64;
		val33.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt).DefaultCellStyle = val33;
		((DataGridViewColumn)dgvcGia_nt).HeaderText = "Giá vốn";
		dgvcGia_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt).Name = "dgvcGia_nt";
		((DataGridViewColumn)dgvcGia_nt).ReadOnly = true;
		dgvcGia_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia_nt.SpecialType = Commons.NumericSpecialType.FCPrice;
		((DataGridViewColumn)dgvcGia_nt).Width = 90;
		((DataGridViewColumn)dgvcTien_nt).DataPropertyName = "tien_nt";
		val34.Alignment = (DataGridViewContentAlignment)64;
		val34.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt).DefaultCellStyle = val34;
		((DataGridViewColumn)dgvcTien_nt).HeaderText = "Tiền vốn";
		dgvcTien_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt).Name = "dgvcTien_nt";
		((DataGridViewColumn)dgvcTien_nt).ReadOnly = true;
		dgvcTien_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt).Width = 90;
		((DataGridViewColumn)dgvcGia).DataPropertyName = "gia";
		val35.Alignment = (DataGridViewContentAlignment)64;
		val35.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcGia).DefaultCellStyle = val35;
		((DataGridViewColumn)dgvcGia).HeaderText = "Giá vốn VND";
		dgvcGia.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcGia).Name = "dgvcGia";
		((DataGridViewColumn)dgvcGia).ReadOnly = true;
		dgvcGia.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia.SpecialType = Commons.NumericSpecialType.ACPrice;
		((DataGridViewColumn)dgvcGia).Width = 90;
		((DataGridViewColumn)dgvcTien).DataPropertyName = "tien";
		val36.Alignment = (DataGridViewContentAlignment)64;
		val36.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcTien).DefaultCellStyle = val36;
		((DataGridViewColumn)dgvcTien).HeaderText = "T. vốn VND";
		dgvcTien.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcTien).Name = "dgvcTien";
		((DataGridViewColumn)dgvcTien).ReadOnly = true;
		dgvcTien.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien).Width = 90;
		dgvcMa_Nvkd.AutoFill = true;
		dgvcMa_Nvkd.AutoLookup = true;
		dgvcMa_Nvkd.AutoValid = true;
		((DataGridViewColumn)dgvcMa_Nvkd).DataPropertyName = "ma_nvkd";
		val37.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_Nvkd).DefaultCellStyle = val37;
		((DataGridViewColumn)dgvcMa_Nvkd).HeaderText = "NVKD";
		dgvcMa_Nvkd.LookupCodeName = "MA_NVKD";
		dgvcMa_Nvkd.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_Nvkd).Name = "dgvcMa_Nvkd";
		dgvcMa_Nvkd.ReceiverValidFieldList = "ten_nvkd";
		dgvcMa_Nvkd.SD = true;
		dgvcMa_Nvkd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_Nvkd.ValidReturnFieldList = "ten_nvkd";
		((DataGridViewColumn)dgvcMa_Nvkd).Width = 60;
		((DataGridViewColumn)dgvcSo_hd).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcSo_hd).DataPropertyName = "so_hd";
		((DataGridViewColumn)dgvcSo_hd).HeaderText = "Số HĐ";
		((DataGridViewColumn)dgvcSo_hd).Name = "dgvcSo_hd";
		((DataGridViewColumn)dgvcSo_hd).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_hd).Width = 64;
		txtMa_Httt.AutoLookup = true;
		txtMa_Httt.AutoValid = true;
		((TextBoxBase)txtMa_Httt).BackColor = SystemColors.Info;
		((TextBox)txtMa_Httt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_Httt;
		location = new Point(108, 102);
		((Control)asTextBox7).Location = location;
		txtMa_Httt.LookupCodeName = "MA_HTTT";
		txtMa_Httt.LookupWhereCondition = "moduleid='SO'";
		((Control)txtMa_Httt).Name = "txtMa_Httt";
		txtMa_Httt.NameControl = lblTen_Httt;
		txtMa_Httt.SD = true;
		AsTextBox asTextBox8 = txtMa_Httt;
		size = new Size(75, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_Httt).TabIndex = 5;
		txtMa_Httt.UseAutoCompleteSource = true;
		txtMa_Httt.ValidReturnFieldList = "tk,tk_thue_gtgt_mua,ten_httt";
		lblTen_Httt.ImeMode = (ImeMode)0;
		Label obj60 = lblTen_Httt;
		location = new Point(187, 106);
		((Control)obj60).Location = location;
		((Control)lblTen_Httt).Name = "lblTen_Httt";
		Label obj61 = lblTen_Httt;
		size = new Size(324, 13);
		((Control)obj61).Size = size;
		((Control)lblTen_Httt).TabIndex = 257;
		lblTen_Httt.TextAlign = (ContentAlignment)16;
		lblMa_httt.AutoSize = true;
		lblMa_httt.ImeMode = (ImeMode)0;
		Label obj62 = lblMa_httt;
		location = new Point(9, 106);
		((Control)obj62).Location = location;
		((Control)lblMa_httt).Name = "lblMa_httt";
		Label obj63 = lblMa_httt;
		size = new Size(76, 13);
		((Control)obj63).Size = size;
		((Control)lblMa_httt).TabIndex = 256;
		lblMa_httt.Text = "Mã thanh toán";
		Label7.AutoSize = true;
		Label7.ImeMode = (ImeMode)0;
		Label label5 = Label7;
		location = new Point(558, 85);
		((Control)label5).Location = location;
		((Control)Label7).Name = "Label7";
		Label label6 = Label7;
		size = new Size(63, 13);
		((Control)label6).Size = size;
		((Control)Label7).TabIndex = 266;
		Label7.Text = "Số hoá đơn";
		TextBox obj64 = txtSo_hd;
		location = new Point(651, 81);
		((Control)obj64).Location = location;
		((TextBoxBase)txtSo_hd).MaxLength = 12;
		((Control)txtSo_hd).Name = "txtSo_hd";
		TextBox obj65 = txtSo_hd;
		size = new Size(78, 20);
		((Control)obj65).Size = size;
		((Control)txtSo_hd).TabIndex = 11;
		((Control)Label2).Anchor = (AnchorStyles)6;
		((Control)Label2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label2.ImeMode = (ImeMode)0;
		Label label7 = Label2;
		location = new Point(438, 402);
		((Control)label7).Location = location;
		((Control)Label2).Name = "Label2";
		Label label8 = Label2;
		size = new Size(82, 13);
		((Control)label8).Size = size;
		((Control)Label2).TabIndex = 271;
		Label2.Text = "Tiền hàng";
		Label2.TextAlign = (ContentAlignment)16;
		((Control)Label5).Anchor = (AnchorStyles)6;
		((Control)Label5).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label5.ImeMode = (ImeMode)0;
		Label label9 = Label5;
		location = new Point(145, 402);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(69, 13);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 274;
		Label5.Text = "Tiền nhập";
		Label5.TextAlign = (ContentAlignment)16;
		((Control)txtT_tien).Anchor = (AnchorStyles)6;
		txtT_tien.DecimalSymbol = ".";
		((Control)txtT_tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric21 = txtT_tien;
		location = new Point(321, 399);
		((Control)asTextNumeric21).Location = location;
		txtT_tien.Mask = "### ### ### ###";
		((Control)txtT_tien).Name = "txtT_tien";
		((TextBoxBase)txtT_tien).ReadOnly = true;
		AsTextNumeric asTextNumeric22 = txtT_tien;
		size = new Size(100, 20);
		((Control)asTextNumeric22).Size = size;
		txtT_tien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_tien).TabIndex = 272;
		((Control)txtT_tien).TabStop = false;
		((TextBox)txtT_tien).Text = "0";
		((TextBox)txtT_tien).TextAlign = (HorizontalAlignment)1;
		txtT_tien.Value = 0.0;
		((Control)txtT_tien_nt).Anchor = (AnchorStyles)6;
		txtT_tien_nt.DecimalSymbol = ".";
		((Control)txtT_tien_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric23 = txtT_tien_nt;
		location = new Point(215, 399);
		((Control)asTextNumeric23).Location = location;
		txtT_tien_nt.Mask = "### ### ### ###";
		((Control)txtT_tien_nt).Name = "txtT_tien_nt";
		((TextBoxBase)txtT_tien_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric24 = txtT_tien_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric24).Size = size;
		txtT_tien_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tien_nt).TabIndex = 273;
		((Control)txtT_tien_nt).TabStop = false;
		((TextBox)txtT_tien_nt).Text = "0";
		((TextBox)txtT_tien_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tien_nt.Value = 0.0;
		tabTain.BackColor = SystemColors.Control;
		((Control)tabTain).Controls.Add((Control)(object)cmdGetTaInFromDetail);
		((Control)tabTain).Controls.Add((Control)(object)ctlTaIn);
		TabPage obj66 = tabTain;
		location = new Point(4, 25);
		obj66.Location = location;
		((Control)tabTain).Name = "tabTain";
		TabPage obj67 = tabTain;
		((Padding)(ref val38))._002Ector(3);
		((Control)obj67).Padding = val38;
		TabPage obj68 = tabTain;
		size = new Size(733, 187);
		((Control)obj68).Size = size;
		tabTain.TabIndex = 9;
		tabTain.Text = "Thuế &gtgt";
		((Control)cmdGetTaInFromDetail).Anchor = (AnchorStyles)10;
		Button obj69 = cmdGetTaInFromDetail;
		location = new Point(584, 158);
		((Control)obj69).Location = location;
		((Control)cmdGetTaInFromDetail).Name = "cmdGetTaInFromDetail";
		Button obj70 = cmdGetTaInFromDetail;
		size = new Size(144, 23);
		((Control)obj70).Size = size;
		((Control)cmdGetTaInFromDetail).TabIndex = 2;
		((ButtonBase)cmdGetTaInFromDetail).Text = "Lấ&y từ chi tiết";
		((ButtonBase)cmdGetTaInFromDetail).UseVisualStyleBackColor = true;
		ctlTaIn.DataSource = bsTain;
		((Control)ctlTaIn).Dock = (DockStyle)5;
		ctlTaIn.HasThueNK = false;
		ctlTaIn.HasThueTTDB = false;
		ctlTaIn obj71 = ctlTaIn;
		location = new Point(3, 3);
		((Control)obj71).Location = location;
		ctlTaIn obj72 = ctlTaIn;
		((Padding)(ref val38))._002Ector(0);
		((Control)obj72).Margin = val38;
		((Control)ctlTaIn).Name = "ctlTaIn";
		ctlTaIn.PHDataSource = bsPH;
		ctlTaIn obj73 = ctlTaIn;
		size = new Size(727, 181);
		((Control)obj73).Size = size;
		((Control)ctlTaIn).TabIndex = 3;
		ctlTaIn.TAINTable = null;
		ctlTaIn.Tk_Du = "";
		ctlTaIn.Tk_Thue = "";
		txtNgay_hd.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_hd).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_hd;
		location = new Point(651, 59);
		((Control)asMaskedTextBox6).Location = location;
		((MaskedTextBox)txtNgay_hd).Mask = "##/##/####";
		((Control)txtNgay_hd).Name = "txtNgay_hd";
		((MaskedTextBox)txtNgay_hd).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox7 = txtNgay_hd;
		size = new Size(78, 20);
		((Control)asMaskedTextBox7).Size = size;
		((Control)txtNgay_hd).TabIndex = 10;
		((MaskedTextBox)txtNgay_hd).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox8 = txtNgay_hd;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox8.Value = dateTime;
		Label6.AutoSize = true;
		Label6.ImeMode = (ImeMode)0;
		Label label11 = Label6;
		location = new Point(558, 63);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(75, 13);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 268;
		Label6.Text = "Ngày hoá đơn";
		((Control)txtT_ck).Anchor = (AnchorStyles)6;
		txtT_ck.DecimalSymbol = ".";
		((Control)txtT_ck).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric25 = txtT_ck;
		location = new Point(632, 422);
		((Control)asTextNumeric25).Location = location;
		txtT_ck.Mask = "### ### ### ###";
		((Control)txtT_ck).Name = "txtT_ck";
		((TextBoxBase)txtT_ck).ReadOnly = true;
		AsTextNumeric asTextNumeric26 = txtT_ck;
		size = new Size(100, 20);
		((Control)asTextNumeric26).Size = size;
		txtT_ck.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_ck).TabIndex = 275;
		((Control)txtT_ck).TabStop = false;
		((TextBox)txtT_ck).Text = "0";
		((TextBox)txtT_ck).TextAlign = (HorizontalAlignment)1;
		txtT_ck.Value = 0.0;
		((Control)txtT_ck_nt).Anchor = (AnchorStyles)6;
		txtT_ck_nt.DecimalSymbol = ".";
		((Control)txtT_ck_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric27 = txtT_ck_nt;
		location = new Point(526, 422);
		((Control)asTextNumeric27).Location = location;
		txtT_ck_nt.Mask = "### ### ### ###";
		((Control)txtT_ck_nt).Name = "txtT_ck_nt";
		((TextBoxBase)txtT_ck_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric28 = txtT_ck_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric28).Size = size;
		txtT_ck_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_ck_nt).TabIndex = 277;
		((Control)txtT_ck_nt).TabStop = false;
		((TextBox)txtT_ck_nt).Text = "0";
		((TextBox)txtT_ck_nt).TextAlign = (HorizontalAlignment)1;
		txtT_ck_nt.Value = 0.0;
		((Control)lblT_ck).Anchor = (AnchorStyles)6;
		((Control)lblT_ck).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_ck.ImeMode = (ImeMode)0;
		Label obj74 = lblT_ck;
		location = new Point(438, 425);
		((Control)obj74).Location = location;
		((Control)lblT_ck).Name = "lblT_ck";
		Label obj75 = lblT_ck;
		size = new Size(82, 13);
		((Control)obj75).Size = size;
		((Control)lblT_ck).TabIndex = 276;
		lblT_ck.Text = "Giảm giá/CK";
		lblT_ck.TextAlign = (ContentAlignment)16;
		txtSo_seri_mhd.CharacterCasing = (CharacterCasing)1;
		TextBox obj76 = txtSo_seri_mhd;
		location = new Point(651, 15);
		((Control)obj76).Location = location;
		((Control)txtSo_seri_mhd).Name = "txtSo_seri_mhd";
		TextBox obj77 = txtSo_seri_mhd;
		size = new Size(78, 20);
		((Control)obj77).Size = size;
		((Control)txtSo_seri_mhd).TabIndex = 8;
		lblSo_seri_mhd.AutoSize = true;
		Label obj78 = lblSo_seri_mhd;
		location = new Point(558, 19);
		((Control)obj78).Location = location;
		((Control)lblSo_seri_mhd).Name = "lblSo_seri_mhd";
		Label obj79 = lblSo_seri_mhd;
		size = new Size(65, 13);
		((Control)obj79).Size = size;
		((Control)lblSo_seri_mhd).TabIndex = 271;
		lblSo_seri_mhd.Text = "Ký hiệu mẫu";
		((ButtonBase)cmdChon_px).FlatStyle = (FlatStyle)1;
		Button obj80 = cmdChon_px;
		location = new Point(640, 148);
		((Control)obj80).Location = location;
		((Control)cmdChon_px).Name = "cmdChon_px";
		Button obj81 = cmdChon_px;
		size = new Size(89, 21);
		((Control)obj81).Size = size;
		((Control)cmdChon_px).TabIndex = 15;
		((ButtonBase)cmdChon_px).Text = "Chọ&n Hóa đơn";
		((ButtonBase)cmdChon_px).UseVisualStyleBackColor = true;
		size = new Size(741, 540);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtT_ck);
		((Control)this).Controls.Add((Control)(object)txtT_ck_nt);
		((Control)this).Controls.Add((Control)(object)lblT_ck);
		((Control)this).Controls.Add((Control)(object)chkSua_tien);
		((Control)this).Controls.Add((Control)(object)chkSua_thue);
		((Control)this).Controls.Add((Control)(object)txtT_Tien2);
		((Control)this).Controls.Add((Control)(object)lblT_Tien);
		((Control)this).Controls.Add((Control)(object)txtT_So_luong);
		((Control)this).Controls.Add((Control)(object)txtT_Tien_nt2);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)txtT_tien);
		((Control)this).Controls.Add((Control)(object)txtT_tien_nt);
		((Control)this).Controls.Add((Control)(object)chkGia_tb);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)txtT_thue_nt);
		((Control)this).Controls.Add((Control)(object)txtT_tt);
		((Control)this).Controls.Add((Control)(object)txtT_tt_nt);
		((Control)this).Controls.Add((Control)(object)lblT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_Thue);
		((Control)this).Controls.Add((Control)(object)lblT_Tt);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmSoVchSO4";
		((Form)this).Text = "frmSoVchSO4";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_thue_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkGia_tb, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tien_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien_nt2, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_So_luong, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien2, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkSua_thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkSua_tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_ck, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck, 0);
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
		((Control)SplitContainer1.Panel1).ResumeLayout(false);
		((Control)SplitContainer1.Panel2).ResumeLayout(false);
		((Control)SplitContainer1.Panel2).PerformLayout();
		((Control)SplitContainer1).ResumeLayout(false);
		((ISupportInitialize)adgvHach_toan).EndInit();
		((ISupportInitialize)adgvDetail).EndInit();
		((Control)tabTain).ResumeLayout(false);
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
				txtTy_gia_Validated(null, null);
			}
			ctlTaIn.Ma_Nt = cboMa_NT.MA_NT;
		}
	}

	private void txtMa_Kh_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if ((base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !((TextBoxBase)txtMa_Kh).ReadOnly && ((Control)txtMa_Kh).Enabled && ((Control)txtMa_Kh).Visible && e.ValidatedRow != null) || 1 == 0)
		{
			txtDia_chi_vat.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["dia_chi"]), isNum: false));
			txtNguoi_Gd.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["nguoi_gd"]), isNum: false));
			txtMa_so_thue.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_so_thue"]), isNum: false));
			txtGh_no.Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["gh_no"]), isNum: true));
			GetKhInfo();
			f_isGetKhInfo = true;
		}
	}

	private void txtMa_Httt_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if ((base.ActionMode != Commons.ApplicationMode.VIEW_MODE && e.ValidatedRow != null && !IsValidateCalledFromValidData) || 1 == 0)
		{
			((TextBox)txtTk_pt).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			((TextBox)txtTk_thue).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_mua"]), isNum: false));
			CurrentPHRow["Tk_pt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			CurrentPHRow["Tk_thue"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_mua"]), isNum: false));
			if ((TAINTable != null && TAINTable.Rows.Count > 0 && base.ActionMode == Commons.ApplicationMode.ADD_MODE) || 1 == 0)
			{
				ctlTaIn.Tk_Du = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
				ctlTaIn.Tk_Thue = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_mua"]), isNum: false));
			}
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

	private void chkSua_tien_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		if ((int)((CheckBox)chkSua_tien).CheckState != 0)
		{
			return;
		}
		foreach (DataGridViewRow item in (IEnumerable)((DataGridView)adgvDetail).Rows)
		{
			DataGridViewRow val = item;
			Calc_TienHang(base.CT1Voucher[((DataGridViewBand)val).Index]);
		}
	}

	private void chkSua_thue_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		if ((int)((CheckBox)chkSua_thue).CheckState != 0)
		{
			return;
		}
		foreach (DataGridViewRow item in (IEnumerable)((DataGridView)adgvDetail).Rows)
		{
			DataGridViewRow val = item;
			Calc_Thue_gtgt(base.CT1Voucher[((DataGridViewBand)val).Index]);
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_nt2).Name, false) == 0)
			{
				V_Gia_Nt2(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt2).Name, false) == 0)
			{
				V_Tien_Nt2(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien2).Name, false) == 0)
			{
				V_Tien2(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_CK_nt).Name, false) == 0)
			{
				V_Tien_Ck_Nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_ck).Name, false) == 0)
			{
				V_Tien_Ck(oDv);
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia2).Name, false) == 0)
			{
				V_Gia2(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_nt).Name, false) == 0)
			{
				V_Gia_Nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt).Name, false) == 0)
			{
				V_Tien_nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien).Name, false) == 0)
			{
				V_tien(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia).Name, false) == 0)
			{
				V_Gia(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_vt).Name, false) == 0)
			{
				V_Ma_Vt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kho).Name, false) == 0)
			{
				V_Ma_Kho(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_CK_nt).Name, false) == 0)
			{
				V_Tien_Ck_Nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_ck).Name, false) == 0)
			{
				V_Tien_Ck(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTL_CK).Name, false) == 0)
			{
				V_Tl_Ck(oDv);
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
		if ((CTTable == null || base.IsLoading || CT1Voucher.Count <= 0) ? true : false)
		{
			return;
		}
		DataRowView dataRowView = CT1Voucher[e.RowIndex];
		try
		{
			object obj = null;
			DataGridViewCell currentCell = ((DataGridView)adgvDetail).CurrentCell;
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt2).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Nt2(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien2).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien2(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia2).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Gia2(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Nt(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Gia_nt(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Gia(dataRowView);
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_CK_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Ck_Nt(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kho).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["ten_kho"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_Nvkd).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["ten_nvkd"]);
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
		if ((CTTable != null && !base.IsLoading && CT1Voucher.Count > 0) || 1 == 0)
		{
			DataRowView dataRowView = CT1Voucher[e.RowIndex];
			object obj = null;
			string name = ((DataGridView)adgvHach_toan).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_tl).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_tl"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_vt).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_vt"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_gv).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_gv"]);
			}
			obj = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(obj), isNum: false));
			((ToolStripItem)tsslInfo).Text = Conversions.ToString(obj);
		}
	}

	private void cmdChon_px_Click(object sender, EventArgs e)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Invalid comparison between Unknown and I4
		if (Operators.CompareString(((TextBox)txtMa_Kh).Text.Trim(), "", false) == 0 || base.ActionMode != Commons.ApplicationMode.ADD_MODE)
		{
			((Control)this).SelectNextControl((Control)(object)cmdChon_px, true, true, true, true);
			return;
		}
		frmSoVchSo4FindSO3 frmSoVchSo4FindSO4 = new frmSoVchSo4FindSO3();
		((Form)frmSoVchSo4FindSO4).Text = ((ButtonBase)cmdChon_px).Text.Replace("&", "");
		frmSoVchSo4FindSO4.sMa_kh = ((TextBox)txtMa_Kh).Text.Trim();
		((TextBox)frmSoVchSo4FindSO4.txtMa_Kh).Text = ((TextBox)txtMa_Kh).Text.Trim();
		frmSoVchSo4FindSO4.txtNgay_hd1.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("ngay_ct1"));
		frmSoVchSo4FindSO4.txtNgay_hd2.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("ngay_ct2"));
		((Form)frmSoVchSo4FindSO4).ShowDialog();
		if ((int)((Form)frmSoVchSo4FindSO4).DialogResult == 1)
		{
			LookupHD(frmSoVchSo4FindSO4.sWhereKey);
		}
		((Component)(object)frmSoVchSo4FindSO4).Dispose();
		((Control)this).SelectNextControl((Control)(object)cmdChon_px, true, true, true, true);
	}

	private void cmdGetTaInFromDetail_Click(object sender, EventArgs e)
	{
		GetTaInFromDetail();
		UpdateList();
	}

	private void ctlTaIn_TAINValueChanged(object sender, EventArgs e)
	{
		UpdateList();
	}

	private void adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged(object sender, SetDependentFieldsWhenCellValueChangedEventArgs e)
	{
		if ((!base.MyVoucherInfo.ct_carry_field_list.ToUpper().Contains("MA_KHO") || ((DataGridViewCellEventArgs)e).RowIndex <= 0) && 0 == 0 && ((e.ValidatedRow != null && ((DataGridView)adgvDetail).Columns[((DataGridViewCellEventArgs)e).ColumnIndex].Name.Equals(((DataGridViewColumn)dgvcMa_vt).Name) && dgvcMa_vt.ValidReturnFieldList.Contains("ma_kho") && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_kho"]), isNum: false), (object)"", false)) ? true : false))
		{
			CurrentCTRowView["ma_kho"] = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_kho"]);
			CurrentCTRowView["ma_vitri"] = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_vitri"]);
			((DataGridView)dgvDetail).AutoResizeColumn(((DataGridViewBand)dgvcMa_kho).Index);
			DataRow pDrw = null;
			if (Commons.ValidMa(ref pDrw, "MA_KHO", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentCTRowView["ma_kho"]), isNum: false)), "", "kho_dl,tk_dl", pSd: true) && ((Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)true, false) && Operators.ConditionalCompareObjectNotEqual(pDrw["tk_dl"], (object)"", false)) ? true : false))
			{
				CurrentCTRowView["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["tk_dl"]);
			}
		}
	}

	private bool W_Ma_Vt(DataRowView oDv)
	{
		return Conversions.ToBoolean((!Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["stt_rec_px"]), isNum: false), (object)"", false)) || !Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["stt_rec_hd"]), isNum: false), (object)"", false))) ? ((object)false) : ((object)true));
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
		return true;
	}

	private bool W_Gia_nt(DataRowView oDv)
	{
		return true;
	}

	private bool W_Tien(DataRowView oDv)
	{
		return true;
	}

	private bool W_Gia(DataRowView oDv)
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

	private bool W_Tien_Ck_Nt(DataRowView oDv)
	{
		return true;
	}

	private void V_Ma_Vt(DataRowView oDv)
	{
		ReCalcTonKhoTucThoi(oDv);
		DataRow pDrw = null;
		if (((Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_kho"]), isNum: false), (object)"", false) && Commons.ValidMa(ref pDrw, "MA_KHO", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_kho"]), isNum: false)), "", "kho_dl,tk_dl", pSd: true)) ? true : false) && ((Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)true, false) && Operators.ConditionalCompareObjectNotEqual(pDrw["tk_dl"], (object)"", false)) ? true : false))
		{
			oDv["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["tk_dl"]);
		}
	}

	private void V_Ma_Kho(DataRowView oDv)
	{
		oDv["ma_vitri"] = "";
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
		Calc_TienHang(oDv);
		Calc_ChietKhau(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		Calc_TienVon(oDv);
		Calc_So_luong_qd(oDv);
		UpdateList();
	}

	private void V_Gia_Nt2(DataRowView oDv)
	{
		Calc_GiaBan(oDv);
		Calc_TienHang(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Gia2(DataRowView oDv)
	{
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
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien_Nt2(DataRowView oDv)
	{
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
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia2"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia2"]), isNum: true)),
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
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt2"]), isNum: true), txtTy_gia.Value),
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
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien2(DataRowView oDv)
	{
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
		Calc_Thue_gtgt(oDv);
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
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj);
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
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true)),
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
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), txtTy_gia.Value),
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
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
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
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Thue_gtgt(DataRowView oDv)
	{
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien_Ck_Nt(DataRowView oDv)
	{
		if ((Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false) && (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0 || Operators.ConditionalCompareObjectEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true)), (object)0, false))) ? true : false)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj);
		}
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien_Ck(DataRowView oDv)
	{
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tl_Ck(DataRowView oDv)
	{
		Calc_ChietKhau(oDv);
		Calc_Thue_gtgt(oDv);
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
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt2"]), isNum: true)), (object)100),
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
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true)), (object)100),
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
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck_ds_Nt"]), isNum: true))), (object)100),
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
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_nt"]), isNum: true)),
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
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ck_ds"]), isNum: true))), (object)100),
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
	}

	private void Calc_TienVon(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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
			oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj);
		}
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true)),
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
			oDv["Tien_Nt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true)),
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
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)),
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
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj4);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle5 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj5);
		}
	}

	private void Calc_So_luong_qd(DataRowView oDv)
	{
		oDv["so_luong_qd"] = RuntimeHelpers.GetObjectValue(oDv["so_luong"]);
	}

	private void V_Ty_Gia()
	{
		if ((Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false) && CT1Voucher != null) ? true : false)
		{
			foreach (DataRowView item in CT1Voucher)
			{
				if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
				{
					Type? typeFromHandle = typeof(Math);
					object[] array = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt2"]), isNum: true)),
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
					object[] array3;
					SIConfiguration sIConfiguration;
					object[] array;
					bool[] array5;
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

	private void GetKhInfo()
	{
		DataTable dataTable = Commons.Get_KhInfo(((TextBox)txtMa_Kh).Text, DateAndTime.Month(Conversions.ToDate(txtNgay_Ct.Value)), DateAndTime.Year(Conversions.ToDate(txtNgay_Ct.Value)));
		DataRow[] array = dataTable.Select("ma='DUHT'");
		if (array.Length > 0)
		{
			DataRow dataRow = array[0];
			txtDu13.Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Tien_Nt"]), isNum: true));
		}
		else
		{
			txtDu13.Value = 0;
		}
		dataTable.Dispose();
	}

	private void LookupHD(string aKey)
	{
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		DataTable oTblPh = null;
		DataTable oTblCt = null;
		if (SOCommon.SOLookupHD4PN(aKey, ref oTblPh, ref oTblCt))
		{
			frmSoVchSO4SeachSO2SO3 frmSoVchSO4SeachSO2SO4 = new frmSoVchSO4SeachSO2SO3();
			((Form)frmSoVchSO4SeachSO2SO4).Text = ((ButtonBase)cmdChon_px).Text.Replace("&", "");
			frmSoVchSO4SeachSO2SO4.PHTable = oTblPh;
			frmSoVchSO4SeachSO2SO4.CTTable = oTblCt;
			if ((int)((Form)frmSoVchSO4SeachSO2SO4).ShowDialog() != 1)
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
			DataRow[] array3 = array;
			foreach (DataRow dataRow3 in array3)
			{
				DataRow[] array4 = oTblCt.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", dataRow3["Stt_rec"]), (object)"' And Chon=True")));
				foreach (DataRow dataRow4 in array4)
				{
					DataRow dataRow5 = CTTable.NewRow();
					dataRow5["Stt_Rec"] = RuntimeHelpers.GetObjectValue(CurrentPHRow["Stt_Rec"]);
					dataRow5["Stt_Rec0"] = Commons.Get_SttRec0(Conversions.ToString(CurrentPHRow["Stt_Rec"]), CTTable);
					dataRow5["Stt_Rec_hd"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec"]);
					dataRow5["Stt_Rec0_hd"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec0"]);
					dataRow5["So_hd"] = RuntimeHelpers.GetObjectValue(dataRow3["So_Ct"]);
					dataRow5["Stt_Rec_Px"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec_px"]);
					dataRow5["Stt_Rec0_Px"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec0_px"]);
					dataRow5["So_Px"] = RuntimeHelpers.GetObjectValue(dataRow4["So_px"]);
					dataRow5["Stt_Rec_dh"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec_Dh"]);
					dataRow5["Stt_Rec0_dh"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec0_dh"]);
					dataRow5["So_dh"] = RuntimeHelpers.GetObjectValue(dataRow4["so_dh"]);
					dataRow5["ma_vt"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_vt"]);
					dataRow5["ten_Vt"] = RuntimeHelpers.GetObjectValue(dataRow4["ten_Vt"]);
					dataRow5["Dvt"] = RuntimeHelpers.GetObjectValue(dataRow4["Dvt"]);
					dataRow5["tra_ck"] = RuntimeHelpers.GetObjectValue(dataRow4["tra_ck"]);
					dataRow5["khuyen_mai"] = RuntimeHelpers.GetObjectValue(dataRow4["khuyen_mai"]);
					dataRow5["Tk_Gv"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow4["Tk_Gv"]), isNum: false));
					dataRow5["Tk_Vt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow4["Tk_Vt"]), isNum: false));
					dataRow5["Tk_tl"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow4["Tk_tl"]), isNum: false));
					dataRow5["Tk_Ck"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow4["Tk_Ck"]), isNum: false));
					dataRow5["Tk_km"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow4["Tk_km"]), isNum: false));
					dataRow5["ma_kho"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_kho"]);
					dataRow5["So_luong"] = RuntimeHelpers.GetObjectValue(dataRow4["ton"]);
					dataRow5["So_luong_qd"] = RuntimeHelpers.GetObjectValue(dataRow4["ton_qd"]);
					dataRow5["Gia_nt2"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia_nt2"]);
					dataRow5["Gia2"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia2"]);
					dataRow5["Tien_Nt2"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_nt2"]);
					dataRow5["Tien2"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien2"]);
					dataRow5["Tl_Ck"] = RuntimeHelpers.GetObjectValue(dataRow4["Tl_Ck"]);
					dataRow5["Tien_Ck_nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_Ck_nt"]);
					dataRow5["Tien_Ck"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_Ck"]);
					dataRow5["Ts_Gtgt"] = RuntimeHelpers.GetObjectValue(dataRow4["Ts_Gtgt"]);
					dataRow5["Thue_Gtgt_Nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Thue_Gtgt_Nt"]);
					dataRow5["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(dataRow4["Thue_Gtgt"]);
					dataRow5["Gia_nt2"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia_nt2"]);
					dataRow5["Gia2"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia2"]);
					dataRow5["Gia_Nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia_Nt"]);
					dataRow5["Gia"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia"]);
					dataRow5["Tien_Nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_nt"]);
					dataRow5["Tien"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien"]);
					dataRow5["ma_bp"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_bp"]);
					dataRow5["ma_vitri"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_vitri"]);
					dataRow5["ma_lo"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_lo"]);
					dataRow5["ma_nvkd"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_nvkd"]);
					CTTable.Rows.Add(dataRow5);
					ReCalcTonKhoTucThoi(dataRow5);
				}
			}
			((TextBoxBase)txtMa_Kh).ReadOnly = true;
			base.CurrentPHRow["tao_tu_hd"] = true;
		}
		else
		{
			CMessageBox.Show(50016);
		}
	}

	private void SetTexboxValue(ref TextBox oTxt, string value, bool isnumeric = false)
	{
		if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(oTxt.Text, isNum: false), (object)"", false))
		{
			oTxt.Text = Conversions.ToString(Helper.Repl_Null(value, isnumeric));
		}
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
		DataRow dataRow;
		DataRow pDrw;
		if (Conversions.ToDouble(AsiaErp.Framework.Environment.GetPOConfiguration().ke_gtgt_mua_chi_tiet_theo_vt) == 1.0)
		{
			foreach (DataRowView item2 in base.CT1Voucher)
			{
				dataRow = base.TAINTable.NewRow();
				dataRow["ma_cty"] = CompanyInformations.CompanyID;
				dataRow["stt_rec"] = RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]);
				dataRow["stt_rec0"] = Commons.Get_SttRec0(Conversions.ToString(base.CurrentPHRow["stt_rec"]), base.TAINTable);
				dataRow["so_seri_mhd"] = txtSo_seri_mhd.Text.Trim();
				dataRow["so_seri0"] = txtSo_Seri.Text.Trim();
				dataRow["so_ct0"] = txtSo_hd.Text.Trim();
				dataRow["ngay_ct0"] = RuntimeHelpers.GetObjectValue(txtNgay_hd.Value);
				dataRow["ma_nt"] = cboMa_NT.MA_NT;
				dataRow["ty_gia"] = RuntimeHelpers.GetObjectValue(txtTy_gia.Value);
				dataRow["tk_thue_no"] = ((TextBox)txtTk_thue).Text;
				dataRow["Tk_Du"] = ((TextBox)txtTk_pt).Text;
				dataRow["ma_kh"] = ((TextBox)txtMa_Kh).Text.Trim();
				pDrw = null;
				Commons.ValidMa(ref pDrw, "MA_KH", ((TextBox)txtMa_Kh).Text.Trim(), "", "ten_kh,dia_chi,ma_so_thue", pSd: true);
				if (pDrw != null)
				{
					dataRow["ten_kh"] = RuntimeHelpers.GetObjectValue(pDrw["ten_kh"]);
					dataRow["dia_chi"] = RuntimeHelpers.GetObjectValue(pDrw["dia_chi"]);
					dataRow["ma_so_thue"] = RuntimeHelpers.GetObjectValue(pDrw["ma_so_thue"]);
				}
				dataRow["ma_vt"] = RuntimeHelpers.GetObjectValue(item2["ma_vt"]);
				dataRow["ten_vt"] = RuntimeHelpers.GetObjectValue(item2["ten_vt"]);
				dataRow["tien_hang_nt"] = RuntimeHelpers.GetObjectValue(item2["tien_nt2"]);
				dataRow["tien_hang"] = RuntimeHelpers.GetObjectValue(item2["tien2"]);
				dataRow["t_tien_nt"] = RuntimeHelpers.GetObjectValue(item2["tien_nt2"]);
				dataRow["t_tien"] = RuntimeHelpers.GetObjectValue(item2["tien2"]);
				dataRow["thue_suat"] = RuntimeHelpers.GetObjectValue(item2["ts_gtgt"]);
				dataRow["t_thue_nt"] = RuntimeHelpers.GetObjectValue(item2["thue_gtgt_nt"]);
				dataRow["t_thue"] = RuntimeHelpers.GetObjectValue(item2["thue_gtgt"]);
				dataRow["ma_bp"] = RuntimeHelpers.GetObjectValue(item2["ma_bp"]);
				base.TAINTable.Rows.Add(dataRow);
			}
			return;
		}
		dataRow = base.TAINTable.NewRow();
		dataRow["ma_cty"] = CompanyInformations.CompanyID;
		dataRow["stt_rec"] = RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]);
		dataRow["stt_rec0"] = Commons.Get_SttRec0(Conversions.ToString(base.CurrentPHRow["stt_rec"]), base.TAINTable);
		dataRow["so_seri_mhd"] = txtSo_seri_mhd.Text.Trim();
		dataRow["so_seri0"] = txtSo_Seri.Text.Trim();
		dataRow["so_ct0"] = txtSo_hd.Text.Trim();
		dataRow["ngay_ct0"] = RuntimeHelpers.GetObjectValue(txtNgay_hd.Value);
		dataRow["ma_nt"] = cboMa_NT.MA_NT;
		dataRow["ty_gia"] = RuntimeHelpers.GetObjectValue(txtTy_gia.Value);
		dataRow["tk_thue_no"] = ((TextBox)txtTk_thue).Text;
		dataRow["Tk_Du"] = ((TextBox)txtTk_pt).Text;
		dataRow["ma_kh"] = ((TextBox)txtMa_Kh).Text.Trim();
		pDrw = null;
		Commons.ValidMa(ref pDrw, "MA_KH", ((TextBox)txtMa_Kh).Text.Trim(), "", "ten_kh,dia_chi,ma_so_thue", pSd: true);
		if (pDrw != null)
		{
			dataRow["ten_kh"] = RuntimeHelpers.GetObjectValue(pDrw["ten_kh"]);
			dataRow["dia_chi"] = RuntimeHelpers.GetObjectValue(pDrw["dia_chi"]);
			dataRow["ma_so_thue"] = RuntimeHelpers.GetObjectValue(pDrw["ma_so_thue"]);
		}
		dataRow["ten_vt"] = txtDien_giai.Text.Trim();
		dataRow["tien_hang_nt"] = RuntimeHelpers.GetObjectValue(txtT_Tien_nt2.Value);
		dataRow["tien_hang"] = RuntimeHelpers.GetObjectValue(txtT_Tien2.Value);
		dataRow["t_tien_nt"] = RuntimeHelpers.GetObjectValue(txtT_Tien_nt2.Value);
		dataRow["t_tien"] = RuntimeHelpers.GetObjectValue(txtT_Tien2.Value);
		dataRow["thue_suat"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(txtT_Tien_nt2.Value, (object)0, false), (object)0, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[1] { Operators.DivideObject(txtT_thue_nt.Value, txtT_Tien_nt2.Value) }, (string[])null, (Type[])null, (bool[])null))));
		dataRow["t_thue_nt"] = RuntimeHelpers.GetObjectValue(txtT_thue_nt.Value);
		dataRow["t_thue"] = RuntimeHelpers.GetObjectValue(txtT_Thue.Value);
		base.TAINTable.Rows.Add(dataRow);
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
				Operators.DivideObject(Operators.MultiplyObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true)), (object)100),
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
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_CK_nt).Name, index], dbA3, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, Cmess, ref CmessGHDC);
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
				Operators.DivideObject(Operators.MultiplyObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true)), (object)100),
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
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_CK_nt).Name, index], dbA7, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcThue_gtgt_nt).Name, index], dbA8, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
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
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		base.PHTable.Columns["tao_tu_hd"].DefaultValue = false;
		((DataGridView)adgvHach_toan).DataSource = base.bsCT;
		ctlTaIn.DataSource = bsTain;
		ctlTaIn.TAINTable = base.TAINTable;
		AddControl2ListOfDrivedControls((Control)(object)chkGia_tb);
		AddControl2ListOfDrivedControls((Control)(object)ctlTaIn.chkKe_tain);
		AddControl2ListOfDrivedControls((Control)(object)txtTk_pt);
		AddControl2ListOfDrivedControls((Control)(object)txtTk_thue);
		AddControl2ListOfDrivedControls((Control)(object)cmdGetTaInFromDetail);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Tien_nt2);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_thue_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tien_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tt_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_ck_nt);
		AddDGV(adgvHach_toan);
		string ma_nt = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		f_sTien_von = ((DataGridViewColumn)dgvcTien_nt).HeaderText;
		f_sGia_von = ((DataGridViewColumn)dgvcGia_nt).HeaderText;
		f_sGia_ban = ((DataGridViewColumn)dgvcGia_nt2).HeaderText;
		f_sTien_ban = ((DataGridViewColumn)dgvcTien_nt2).HeaderText;
		f_sTien_ck = ((DataGridViewColumn)dgvcTien_CK_nt).HeaderText;
		f_sTien_thue = ((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText;
		((DataGridViewColumn)dgvcGia2).HeaderText = f_sGia_ban + " " + ma_nt;
		((DataGridViewColumn)dgvcTien2).HeaderText = f_sTien_ban + " " + ma_nt;
		((DataGridViewColumn)dgvcTien2_ht).HeaderText = f_sTien_ban + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = f_sTien_thue + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_Gtgt_ht).HeaderText = f_sTien_thue + " " + ma_nt;
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
		((Control)txtT_tien).Visible = flag;
		((Control)txtT_Thue).Visible = flag;
		((Control)txtT_tt).Visible = flag;
		((Control)txtT_ck).Visible = flag;
		((DataGridViewColumn)dgvcGia2).Visible = flag;
		((DataGridViewColumn)dgvcTien2).Visible = flag;
		((DataGridViewColumn)dgvcTien).Visible = flag;
		((DataGridViewColumn)dgvcThue_gtgt).Visible = flag;
		((DataGridViewColumn)dgvcTien_ck).Visible = flag;
		((DataGridViewColumn)dgvcGia).Visible = ((flag && view_giavon) ? true : false);
		((DataGridViewColumn)dgvcTien).Visible = ((flag && view_giavon) ? true : false);
		((DataGridViewColumn)dgvcGia_nt).Visible = view_giavon;
		((DataGridViewColumn)dgvcTien_nt).Visible = view_giavon;
		((DataGridViewColumn)dgvcTien_nt_ht).Visible = view_giavon;
		((DataGridViewColumn)dgvcTien2_ht).Visible = flag;
		((DataGridViewColumn)dgvcThue_Gtgt_ht).Visible = flag;
		((DataGridViewColumn)dgvcTien_ck_ht).Visible = flag;
		((DataGridViewColumn)dgvcTien_ht).Visible = ((flag && view_giavon) ? true : false);
		string mA_NT = cboMa_NT.MA_NT;
		((DataGridViewColumn)dgvcGia_nt2).HeaderText = f_sGia_ban + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt2).HeaderText = f_sTien_ban + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = f_sTien_thue + " " + mA_NT;
		((DataGridViewColumn)dgvcGia_nt).HeaderText = f_sGia_von + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt).HeaderText = f_sTien_von + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_CK_nt).HeaderText = f_sTien_ck + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt2_ht).HeaderText = f_sTien_ban + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).HeaderText = f_sTien_thue + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = f_sTien_von + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_ck_nt_ht).HeaderText = f_sTien_ck + " " + mA_NT;
	}

	protected override void SetFocus4FirstEditControl()
	{
		if ((base.ActionMode == Commons.ApplicationMode.EDIT_MODE && base.CurrentPHRow != null && Operators.ConditionalCompareObjectEqual(base.CurrentPHRow["tao_tu_hd"], (object)true, false)) ? true : false)
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
			txtT_thue_nt.Value = ctlTaIn.get_T_Thue_Nt("");
			txtT_ck_nt.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_ck_nt)", filter));
			txtT_tt_nt.Value = Operators.AddObject(Operators.SubtractObject(txtT_Tien_nt2.Value, txtT_ck_nt.Value), txtT_thue_nt.Value);
			txtT_tien_nt.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_nt)", filter));
			txtT_Tien2.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien2)", filter));
			txtT_Thue.Value = ctlTaIn.get_T_Thue("");
			txtT_ck.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_ck)", filter));
			txtT_tt.Value = Operators.AddObject(Operators.SubtractObject(txtT_Tien2.Value, txtT_ck.Value), txtT_Thue.Value);
			txtT_tien.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien)", filter));
			txtT_So_luong.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(so_luong)", filter));
		}
	}

	protected override bool ValidData()
	{
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		ctlTaIn.Ma_Nt = cboMa_NT.MA_NT;
		ctlTaIn.Ty_Gia = Conversions.ToDouble(txtTy_gia.Value);
		bool CmessGHDC = false;
		checked
		{
			if ((ChkEmtyTextBox((TextBox)(object)txtMa_Kh) && base.ValidData() && ctlTaIn.ValidData()) ? true : false)
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
				if ((Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(txtT_Thue.Value, txtT_thue_nt.Value), (object)0, false) && !ChkEmtyTextBox((TextBox)(object)txtTk_thue)) ? true : false)
				{
					((TabControl)AsTabControl).SelectedTab = tabHach_toan;
					return false;
				}
				bool flag = true;
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
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_tl"]), isNum: false), (object)"", false))
					{
						return ValidGridCell(1, ((DataGridView)adgvHach_toan)[((DataGridViewColumn)dgvcTk_tl).Name, num2], 50023);
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_gv"]), isNum: false), (object)"", false))
					{
						return ValidGridCell(1, ((DataGridView)adgvHach_toan)[((DataGridViewColumn)dgvcTk_gv).Name, num2], 50039);
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_vt"]), isNum: false), (object)"", false))
					{
						return ValidGridCell(1, ((DataGridView)adgvHach_toan)[((DataGridViewColumn)dgvcTk_vt).Name, num2], 50039);
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Vt"]), isNum: false), (object)"", false))
					{
						return ValidGridCell(0, ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_vt).Name, num2], 50062);
					}
					if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Kho"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ton_kho"]), isNum: false), (object)"1", false)) ? true : false)
					{
						return ValidGridCell(0, ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_kho).Name, num2], 50056);
					}
					if ((Operators.ConditionalCompareObjectGreater(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tien_ck_nt"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_ck"]), isNum: false), (object)string.Empty, false)) ? true : false)
					{
						return ValidGridCell(1, ((DataGridView)adgvHach_toan)[((DataGridViewColumn)dgvcTk_ck).Name, num2], 50091);
					}
					if ((Operators.ConditionalCompareObjectEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true)), (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ton_kho"]), isNum: false), (object)"1", false)) ? true : false)
					{
						((TabControl)AsTabControl).SelectedTab = tabDetail;
						((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcSo_luong).Name, num2].ErrorText = Helper.GetMessContent(50037);
						((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_nt2).Name, num2].ErrorText = Helper.GetMessContent(50037);
						flag = false;
					}
					if ((Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tien2"]), isNum: true), (object)0, false)) ? true : false)
					{
						return ValidGridCell(0, ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien2).Name, num2], 50037);
					}
					ValidAdjustOver(num2, dataRowView, ref CmessGHDC, 50130);
					num2++;
				}
				if (CmessGHDC)
				{
					return Commons.ProcessAdjustOver();
				}
				if (!flag)
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
			if ((base.CurrentPHRow != null && Operators.ConditionalCompareObjectEqual(base.CurrentPHRow["tao_tu_hd"], (object)true, false)) ? true : false)
			{
				((TextBoxBase)txtMa_Kh).ReadOnly = true;
			}
			else
			{
				((TextBoxBase)txtMa_Kh).ReadOnly = false;
			}
			ctlTaIn.adgvTaIn.ReadOnly = false;
			adgvHach_toan.ReadOnly = false;
		}
		else
		{
			ctlTaIn.adgvTaIn.ReadOnly = true;
			adgvHach_toan.ReadOnly = true;
		}
		((TextBoxBase)txtGh_no).ReadOnly = true;
		((TextBoxBase)txtDu13).ReadOnly = true;
	}

	protected override void PHDataBinding()
	{
		base.PHDataBinding();
		CreateDataBinding((Control)(object)txtMa_Kh, "Ma_Kh");
		CreateDataBinding((Control)(object)lblTen_Kh, "Ten_Kh_vat");
		CreateDataBinding((Control)(object)txtDia_chi_vat, "Dia_chi_vat");
		CreateDataBinding((Control)(object)txtMa_so_thue, "ma_so_thue");
		CreateDataBinding((Control)(object)txtNguoi_Gd, "Nguoi_Gd");
		CreateDataBinding((Control)(object)txtDien_giai, "Dien_Giai");
		CreateDataBinding((Control)(object)txtSo_Seri, "so_seri");
		CreateDataBinding((Control)(object)txtNgay_Ct, "ngay_ct", "Value");
		CreateDataBinding((Control)(object)txtSo_Ct, "so_ct");
		CreateDataBinding((Control)(object)txtSo_hd, "so_hd");
		CreateDataBinding((Control)(object)txtNgay_hd, "ngay_hd", "Value");
		CreateDataBinding((Control)(object)txtNgay_lct, "ngay_lct", "Value");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)txtMa_Httt, "Ma_Httt");
		CreateDataBinding((Control)(object)txtTk_pt, "tk_pt");
		CreateDataBinding((Control)(object)txtTk_thue, "tk_thue");
		CreateDataBinding((Control)(object)txtT_Tien2, "t_tien2", "Value");
		CreateDataBinding((Control)(object)txtT_tien, "t_tien", "Value");
		CreateDataBinding((Control)(object)txtT_Thue, "t_thue", "Value");
		CreateDataBinding((Control)(object)txtT_tt, "t_tt", "Value");
		CreateDataBinding((Control)(object)txtT_Tien_nt2, "t_tien_nt2", "Value");
		CreateDataBinding((Control)(object)txtT_thue_nt, "t_thue_nt", "Value");
		CreateDataBinding((Control)(object)txtT_tt_nt, "t_tt_nt", "Value");
		CreateDataBinding((Control)(object)txtT_tien_nt, "t_tien_nt", "Value");
		CreateDataBinding((Control)(object)txtT_So_luong, "T_So_luong", "Value");
		CreateDataBinding((Control)(object)txtT_ck_nt, "t_ck_nt", "Value");
		CreateDataBinding((Control)(object)txtT_ck, "t_ck", "Value");
		CreateDataBinding((Control)(object)chkGia_tb, "gia_tb", "Checked");
		CreateDataBinding((Control)(object)chkSua_thue, "sua_thue", "Checked");
		CreateDataBinding((Control)(object)chkSua_tien, "sua_tien", "Checked");
		CreateDataBinding((Control)(object)ctlTaIn.chkKe_tain, "kht_tain", "Checked");
		CreateDataBinding((Control)(object)txtSo_seri_mhd, "so_seri_mhd");
	}

	protected override void SetPHDefaultValues(DataRow drwPh)
	{
		drwPh["ngay_lct"] = RuntimeHelpers.GetObjectValue(drwPh["ngay_ct"]);
		drwPh["ma_gd"] = "1";
	}

	protected override void VoucherPositionChanged()
	{
		base.VoucherPositionChanged();
		if (!base.IsLoading)
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

	protected override void Find()
	{
		base.Find();
		RefreshDGVInput();
	}

	protected override void SetReportFomularFields(DataRow odrPrintPHRow)
	{
		base.SetReportFomularFields(odrPrintPHRow);
		string text = "";
		string text2 = "";
		foreach (DataRowView item in CT1Voucher)
		{
			if (!text.Contains(Conversions.ToString(item["tk_vt"])))
			{
				text = Conversions.ToString(Operators.AddObject((object)text, Interaction.IIf(Operators.CompareString(text, string.Empty, false) == 0, RuntimeHelpers.GetObjectValue(item["tk_vt"]), Operators.AddObject((object)",", item["tk_vt"]))));
			}
			if (!text2.Contains(Conversions.ToString(item["tk_gv"])))
			{
				text2 = Conversions.ToString(Operators.AddObject((object)text2, Interaction.IIf(Operators.CompareString(text2, string.Empty, false) == 0, RuntimeHelpers.GetObjectValue(item["tk_gv"]), Operators.AddObject((object)",", item["tk_gv"]))));
			}
		}
		base.MyFomularFields.Add("tk_no", text);
		base.MyFomularFields.Add("tk_co", text2);
	}
}
