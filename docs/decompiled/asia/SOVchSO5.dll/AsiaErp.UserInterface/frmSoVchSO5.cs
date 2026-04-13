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
using AsiaErp.SOUtilities;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSoVchSO5 : frmVoucher
{
	private enum LOAI_GRID
	{
		CHI_TIET,
		HOACH_TOAN
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("lblDien_giai")]
	private Label _lblDien_giai;

	[AccessedThroughProperty("adgvDetail")]
	private AsInputDGV _adgvDetail;

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

	[AccessedThroughProperty("lblT_Tt")]
	private Label _lblT_Tt;

	[AccessedThroughProperty("lblT_Thue")]
	private Label _lblT_Thue;

	[AccessedThroughProperty("txtT_tt")]
	private AsTextNumeric _txtT_tt;

	[AccessedThroughProperty("txtT_Thue")]
	private AsTextNumeric _txtT_Thue;

	[AccessedThroughProperty("txtT_Tien2")]
	private AsTextNumeric _txtT_Tien2;

	[AccessedThroughProperty("lblT_Tien")]
	private Label _lblT_Tien;

	[AccessedThroughProperty("lblT_ck")]
	private Label _lblT_ck;

	[AccessedThroughProperty("txtT_ck")]
	private AsTextNumeric _txtT_ck;

	[AccessedThroughProperty("txtT_ck_nt")]
	private AsTextNumeric _txtT_ck_nt;

	[AccessedThroughProperty("txtT_tt_nt")]
	private AsTextNumeric _txtT_tt_nt;

	[AccessedThroughProperty("txtT_thue_nt")]
	private AsTextNumeric _txtT_thue_nt;

	[AccessedThroughProperty("txtT_Tien_nt2")]
	private AsTextNumeric _txtT_Tien_nt2;

	[AccessedThroughProperty("chkSua_ck")]
	private AsCheckBox _chkSua_ck;

	[AccessedThroughProperty("chkSua_thue")]
	private AsCheckBox _chkSua_thue;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("lblNguoi_Gd")]
	private Label _lblNguoi_Gd;

	[AccessedThroughProperty("txtNguoi_Gd")]
	private TextBox _txtNguoi_Gd;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("txtTk_pt")]
	private AsTextBox _txtTk_pt;

	[AccessedThroughProperty("lblTk_pt")]
	private Label _lblTk_pt;

	[AccessedThroughProperty("lblTk_thue")]
	private Label _lblTk_thue;

	[AccessedThroughProperty("txtTk_thue")]
	private AsTextBox _txtTk_thue;

	[AccessedThroughProperty("txtGh_no")]
	private AsTextNumeric _txtGh_no;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("txtDia_chi_vat")]
	private TextBox _txtDia_chi_vat;

	[AccessedThroughProperty("lblDia_chi")]
	private Label _lblDia_chi;

	[AccessedThroughProperty("txtMa_so_thue")]
	private TextBox _txtMa_so_thue;

	[AccessedThroughProperty("lblMa_so_thue")]
	private Label _lblMa_so_thue;

	[AccessedThroughProperty("txtMa_Httt")]
	private AsTextBox _txtMa_Httt;

	[AccessedThroughProperty("lblTen_Httt")]
	private Label _lblTen_Httt;

	[AccessedThroughProperty("txtDu13")]
	private AsTextNumeric _txtDu13;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

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

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("TabPage4")]
	private TabPage _TabPage4;

	[AccessedThroughProperty("DataGridView3")]
	private DataGridView _DataGridView3;

	[AccessedThroughProperty("DataGridViewTextBoxColumn6")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

	[AccessedThroughProperty("DataGridViewTextBoxColumn7")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;

	[AccessedThroughProperty("DataGridViewTextBoxColumn8")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;

	[AccessedThroughProperty("DataGridViewTextBoxColumn9")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn9;

	[AccessedThroughProperty("DataGridViewTextBoxColumn10")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn10;

	[AccessedThroughProperty("tabHach_toan")]
	private TabPage _tabHach_toan;

	[AccessedThroughProperty("SplitContainerHachToan")]
	private SplitContainer _SplitContainerHachToan;

	[AccessedThroughProperty("adgvHach_toan")]
	private AsInputDGV _adgvHach_toan;

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

	[AccessedThroughProperty("cboHttt")]
	private ComboBox _cboHttt;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("cmdThanh_toan")]
	private Button _cmdThanh_toan;

	[AccessedThroughProperty("dgvcMa_vt")]
	private DataGridViewAsTextBoxColumn _dgvcMa_vt;

	[AccessedThroughProperty("dgvcTen_vt")]
	private DataGridViewTextBoxColumn _dgvcTen_vt;

	[AccessedThroughProperty("dgvcDvt")]
	private DataGridViewTextBoxColumn _dgvcDvt;

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

	[AccessedThroughProperty("dgvcTk_dt0")]
	private DataGridViewAsTextBoxColumn _dgvcTk_dt0;

	[AccessedThroughProperty("dgvcTk_ck0")]
	private DataGridViewAsTextBoxColumn _dgvcTk_ck0;

	[AccessedThroughProperty("dgvcMa_Nvkd")]
	private DataGridViewAsTextBoxColumn _dgvcMa_Nvkd;

	private bool f_isGetKhInfo;

	private string f_sGia_ban;

	private string f_sTien_ban;

	private string f_sTien_ck;

	private string f_sTien_thue;

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
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvDetail_CellValueChanged);
			AsInputDGV.SetDependentFieldsWhenCellValueChangedHandler obj = adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged;
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvDetail_CellEnter);
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellValueChanged -= val;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged -= obj;
				((DataGridView)_adgvDetail).CellEnter -= val2;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellValueChanged += val;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged += obj;
				((DataGridView)_adgvDetail).CellEnter += val2;
			}
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

	internal virtual AsCheckBox chkSua_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkSua_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkSua_ck_CheckedChanged;
			if (_chkSua_ck != null)
			{
				((CheckBox)_chkSua_ck).CheckedChanged -= eventHandler;
			}
			_chkSua_ck = value;
			if (_chkSua_ck != null)
			{
				((CheckBox)_chkSua_ck).CheckedChanged += eventHandler;
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

	internal virtual TabPage TabPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage1 = value;
		}
	}

	internal virtual DataGridView DataGridView2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView2 = value;
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

	internal virtual TabPage TabPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage2 = value;
		}
	}

	internal virtual TabPage TabPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage3 = value;
		}
	}

	internal virtual TabPage TabPage4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage4 = value;
		}
	}

	internal virtual DataGridView DataGridView3
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView3 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn6 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn7 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn8 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn9 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn10
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn10 = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_dt0
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_dt0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_dt0 = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_ck0
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_ck0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_ck0 = value;
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

	public frmSoVchSO5()
	{
		__ENCAddToList(this);
		f_isGetKhInfo = false;
		f_sGia_ban = "";
		f_sTien_ban = "";
		f_sTien_ck = "";
		f_sTien_thue = "";
		InitializeComponent();
	}

	public frmSoVchSO5(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_isGetKhInfo = false;
		f_sGia_ban = "";
		f_sTien_ban = "";
		f_sTien_ck = "";
		f_sTien_thue = "";
		InitializeComponent();
	}

	public frmSoVchSO5(string MenuID, string Stt_rec)
		: base(MenuID, Stt_rec)
	{
		__ENCAddToList(this);
		f_isGetKhInfo = false;
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
		//IL_000f: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected O, but got Unknown
		//IL_10f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fa: Expected O, but got Unknown
		//IL_124c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1256: Expected O, but got Unknown
		//IL_130f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1319: Expected O, but got Unknown
		//IL_22f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2300: Expected O, but got Unknown
		//IL_23b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c0: Expected O, but got Unknown
		//IL_247a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2484: Expected O, but got Unknown
		//IL_2582: Unknown result type (might be due to invalid IL or missing references)
		//IL_258c: Expected O, but got Unknown
		//IL_268a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2694: Expected O, but got Unknown
		//IL_278e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2798: Expected O, but got Unknown
		//IL_284e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2858: Expected O, but got Unknown
		//IL_2912: Unknown result type (might be due to invalid IL or missing references)
		//IL_291c: Expected O, but got Unknown
		//IL_2a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a24: Expected O, but got Unknown
		//IL_2b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b2c: Expected O, but got Unknown
		//IL_2c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c34: Expected O, but got Unknown
		//IL_2d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d3c: Expected O, but got Unknown
		//IL_35f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_35fb: Expected O, but got Unknown
		//IL_3c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c93: Expected O, but got Unknown
		//IL_3d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d61: Expected O, but got Unknown
		//IL_3df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dfa: Expected O, but got Unknown
		//IL_3f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_4072: Unknown result type (might be due to invalid IL or missing references)
		//IL_40f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4100: Expected O, but got Unknown
		//IL_41c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_41ce: Expected O, but got Unknown
		//IL_425c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4266: Expected O, but got Unknown
		//IL_43da: Unknown result type (might be due to invalid IL or missing references)
		//IL_459c: Unknown result type (might be due to invalid IL or missing references)
		//IL_45a6: Expected O, but got Unknown
		//IL_46d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_46dd: Expected O, but got Unknown
		//IL_4796: Unknown result type (might be due to invalid IL or missing references)
		//IL_47a0: Expected O, but got Unknown
		//IL_5304: Unknown result type (might be due to invalid IL or missing references)
		//IL_530e: Expected O, but got Unknown
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSoVchSO5));
		txtDien_giai = new TextBox();
		lblDien_giai = new Label();
		adgvDetail = new AsInputDGV();
		dgvcMa_vt = new DataGridViewAsTextBoxColumn();
		dgvcTen_vt = new DataGridViewTextBoxColumn();
		dgvcDvt = new DataGridViewTextBoxColumn();
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
		dgvcTk_dt0 = new DataGridViewAsTextBoxColumn();
		dgvcTk_ck0 = new DataGridViewAsTextBoxColumn();
		dgvcMa_Nvkd = new DataGridViewAsTextBoxColumn();
		txtSo_Seri = new TextBox();
		lblSo_seri = new Label();
		txtNgay_lct = new AsMaskedTextBox();
		lblNgay_Lct = new Label();
		txtTy_gia = new AsTextNumeric();
		cboMa_NT = new AsComboBoxNT();
		lblMa_Nt = new Label();
		lblT_Tt = new Label();
		lblT_Thue = new Label();
		txtT_tt = new AsTextNumeric();
		txtT_Thue = new AsTextNumeric();
		txtT_Tien2 = new AsTextNumeric();
		lblT_Tien = new Label();
		lblT_ck = new Label();
		txtT_ck = new AsTextNumeric();
		txtT_ck_nt = new AsTextNumeric();
		txtT_tt_nt = new AsTextNumeric();
		txtT_thue_nt = new AsTextNumeric();
		txtT_Tien_nt2 = new AsTextNumeric();
		chkSua_thue = new AsCheckBox();
		chkSua_ck = new AsCheckBox();
		Label6 = new Label();
		lblTen_Kh = new Label();
		lblNguoi_Gd = new Label();
		txtNguoi_Gd = new TextBox();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblTk_pt = new Label();
		lblTk_thue = new Label();
		txtTk_thue = new AsTextBox();
		txtTk_pt = new AsTextBox();
		txtGh_no = new AsTextNumeric();
		Label7 = new Label();
		txtDia_chi_vat = new TextBox();
		lblDia_chi = new Label();
		txtMa_so_thue = new TextBox();
		lblMa_so_thue = new Label();
		txtMa_Httt = new AsTextBox();
		lblTen_Httt = new Label();
		txtDu13 = new AsTextNumeric();
		Label14 = new Label();
		TabPage1 = new TabPage();
		DataGridView2 = new DataGridView();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
		TabPage2 = new TabPage();
		TabPage3 = new TabPage();
		TabPage4 = new TabPage();
		DataGridView3 = new DataGridView();
		DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
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
		cboHttt = new ComboBox();
		Label1 = new Label();
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
		((ISupportInitialize)adgvDetail).BeginInit();
		((Control)TabPage1).SuspendLayout();
		((ISupportInitialize)DataGridView2).BeginInit();
		((Control)TabPage4).SuspendLayout();
		((ISupportInitialize)DataGridView3).BeginInit();
		((Control)tabHach_toan).SuspendLayout();
		((Control)SplitContainerHachToan.Panel1).SuspendLayout();
		((Control)SplitContainerHachToan.Panel2).SuspendLayout();
		((Control)SplitContainerHachToan).SuspendLayout();
		((ISupportInitialize)adgvHach_toan).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = cmdAdd;
		Point location = new Point(3, 468);
		((Control)obj).Location = location;
		Button obj2 = cmdPrint;
		location = new Point(73, 468);
		((Control)obj2).Location = location;
		Button obj3 = cmdLast;
		location = new Point(734, 468);
		((Control)obj3).Location = location;
		((Control)cmdLast).TabIndex = 12;
		Button obj4 = cmdNext;
		location = new Point(709, 468);
		((Control)obj4).Location = location;
		((Control)cmdNext).TabIndex = 11;
		Button obj5 = cmdPrevious;
		location = new Point(684, 468);
		((Control)obj5).Location = location;
		((Control)cmdPrevious).TabIndex = 10;
		Button obj6 = cmdFirst;
		location = new Point(659, 468);
		((Control)obj6).Location = location;
		((Control)cmdFirst).TabIndex = 9;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(555, 68);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct;
		Size size = new Size(63, 13);
		((Control)obj8).Size = size;
		lblSo_Ct.Text = "Số hoá đơn";
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		Label obj9 = lblNgay_Ct;
		location = new Point(554, 42);
		((Control)obj9).Location = location;
		Label obj10 = lblNgay_Ct;
		size = new Size(75, 13);
		((Control)obj10).Size = size;
		lblNgay_Ct.Text = "Ngày hoá đơn";
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)5;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(669, 38);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay_Ct).TabIndex = 8;
		((Control)gbPH).Controls.Add((Control)(object)cboHttt);
		((Control)gbPH).Controls.Add((Control)(object)Label1);
		((Control)gbPH).Controls.Add((Control)(object)txtGh_no);
		((Control)gbPH).Controls.Add((Control)(object)Label7);
		((Control)gbPH).Controls.Add((Control)(object)txtDu13);
		((Control)gbPH).Controls.Add((Control)(object)Label14);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Httt);
		((Control)gbPH).Controls.Add((Control)(object)txtDia_chi_vat);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)lblDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbPH).Controls.Add((Control)(object)lblNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)txtNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)Label6);
		((Control)gbPH).Controls.Add((Control)(object)txtTy_gia);
		((Control)gbPH).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Nt);
		((Control)gbPH).Controls.Add((Control)(object)txtNgay_lct);
		((Control)gbPH).Controls.Add((Control)(object)lblNgay_Lct);
		((Control)gbPH).Controls.Add((Control)(object)txtSo_Seri);
		((Control)gbPH).Controls.Add((Control)(object)lblSo_seri);
		((Control)gbPH).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbPH).Controls.Add((Control)(object)lblDien_giai);
		gbPH.FlatStyle = (FlatStyle)0;
		GroupBox obj11 = gbPH;
		location = new Point(3, -3);
		((Control)obj11).Location = location;
		GroupBox obj12 = gbPH;
		size = new Size(754, 151);
		((Control)obj12).Size = size;
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_seri, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Seri, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTy_gia, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDia_chi_vat, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label14, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDu13, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtGh_no, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboHttt, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(578, 468);
		((Control)splitButton).Location = location;
		((Control)cmdSearch).TabIndex = 8;
		((Control)AsTabControl).Controls.Add((Control)(object)tabHach_toan);
		AsTabControl asTabControl = AsTabControl;
		location = new Point(3, 151);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(754, 213);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabHach_toan, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabOptFields, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabDetail, 0);
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj13 = tabDetail;
		size = new Size(746, 184);
		((Control)obj13).Size = size;
		TabPage obj14 = tabOptFields;
		size = new Size(746, 184);
		((Control)obj14).Size = size;
		Button obj15 = cmdCopy;
		location = new Point(353, 468);
		((Control)obj15).Location = location;
		((Control)cmdCopy).TabIndex = 7;
		Button obj16 = cmdDelete;
		location = new Point(283, 468);
		((Control)obj16).Location = location;
		((Control)cmdDelete).TabIndex = 6;
		Button obj17 = cmdEdit;
		location = new Point(213, 468);
		((Control)obj17).Location = location;
		((Control)cmdEdit).TabIndex = 5;
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		TextBox obj18 = txtSo_Ct;
		location = new Point(669, 64);
		((Control)obj18).Location = location;
		((Control)txtSo_Ct).TabIndex = 9;
		TextBox obj19 = txtDien_giai;
		location = new Point(114, 78);
		((Control)obj19).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj20 = txtDien_giai;
		size = new Size(417, 20);
		((Control)obj20).Size = size;
		((Control)txtDien_giai).TabIndex = 4;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj21 = lblDien_giai;
		location = new Point(9, 82);
		((Control)obj21).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj22 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj22).Size = size;
		((Control)lblDien_giai).TabIndex = 144;
		lblDien_giai.Text = "Diễn giải";
		((DataGridView)adgvDetail).AllowUserToAddRows = false;
		((DataGridView)adgvDetail).AllowUserToDeleteRows = false;
		((DataGridView)adgvDetail).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvDetail).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)adgvDetail).ColumnHeadersHeight = 20;
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[17]
		{
			dgvcMa_vt,
			(DataGridViewColumn)dgvcTen_vt,
			(DataGridViewColumn)dgvcDvt,
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
			dgvcTk_dt0,
			dgvcTk_ck0,
			dgvcMa_Nvkd
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvDetail).DefaultCellStyle = val2;
		((Control)adgvDetail).Dock = (DockStyle)5;
		((DataGridView)adgvDetail).GridColor = SystemColors.Control;
		adgvDetail.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV = adgvDetail;
		location = new Point(3, 3);
		((Control)asInputDGV).Location = location;
		((Control)adgvDetail).Name = "adgvDetail";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail).RowHeadersDefaultCellStyle = val3;
		((DataGridView)adgvDetail).RowHeadersWidth = 35;
		((DataGridView)adgvDetail).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = adgvDetail;
		size = new Size(740, 178);
		((Control)asInputDGV2).Size = size;
		((Control)adgvDetail).TabIndex = 0;
		dgvcMa_vt.AutoFill = true;
		dgvcMa_vt.AutoLookup = true;
		dgvcMa_vt.AutoValid = true;
		((DataGridViewColumn)dgvcMa_vt).DataPropertyName = "ma_vt";
		val4.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_vt).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcMa_vt).HeaderText = "Mã hàng";
		dgvcMa_vt.LookupCodeName = "MA_VT";
		dgvcMa_vt.LookupWhereCondition = "loai=4";
		((DataGridViewColumn)dgvcMa_vt).Name = "dgvcMa_vt";
		dgvcMa_vt.ReceiverValidFieldList = "ten_vt,dvt,tk_dt,tk_ck";
		dgvcMa_vt.SD = true;
		dgvcMa_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_vt.ValidReturnFieldList = "ten_vt,dvt,tk_dt,tk_ck";
		((DataGridViewColumn)dgvcMa_vt).Width = 80;
		((DataGridViewColumn)dgvcTen_vt).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vt).HeaderText = "Tên hàng";
		dgvcTen_vt.MaxInputLength = 128;
		((DataGridViewColumn)dgvcTen_vt).Name = "dgvcTen_vt";
		((DataGridViewColumn)dgvcTen_vt).Resizable = (DataGridViewTriState)1;
		dgvcTen_vt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_vt).Width = 260;
		((DataGridViewColumn)dgvcDvt).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcDvt).DataPropertyName = "dvt";
		((DataGridViewColumn)dgvcDvt).HeaderText = "Đvt";
		((DataGridViewColumn)dgvcDvt).Name = "dgvcDvt";
		((DataGridViewColumn)dgvcDvt).Width = 49;
		((DataGridViewColumn)dgvcSo_luong).DataPropertyName = "so_luong";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcSo_luong).HeaderText = "Số lượng";
		dgvcSo_luong.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).Name = "dgvcSo_luong";
		dgvcSo_luong.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSo_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcSo_luong).Width = 75;
		((DataGridViewColumn)dgvcGia_nt2).DataPropertyName = "gia_nt2";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt2).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcGia_nt2).HeaderText = "Giá";
		dgvcGia_nt2.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt2).Name = "dgvcGia_nt2";
		dgvcGia_nt2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia_nt2.SpecialType = Commons.NumericSpecialType.FCPrice;
		((DataGridViewColumn)dgvcGia_nt2).Width = 90;
		((DataGridViewColumn)dgvcTien_nt2).DataPropertyName = "tien_nt2";
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcTien_nt2).HeaderText = "Tiền bán";
		dgvcTien_nt2.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2).Name = "dgvcTien_nt2";
		dgvcTien_nt2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt2.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt2).Width = 90;
		((DataGridViewColumn)dgvcTl_ck).DataPropertyName = "tl_ck";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "###.##";
		((DataGridViewColumn)dgvcTl_ck).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcTl_ck).HeaderText = "% CK";
		dgvcTl_ck.Mask = "###.##";
		((DataGridViewColumn)dgvcTl_ck).Name = "dgvcTl_ck";
		dgvcTl_ck.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTl_ck).Width = 40;
		((DataGridViewColumn)dgvcTien_ck_nt).DataPropertyName = "tien_ck_nt";
		val9.Alignment = (DataGridViewContentAlignment)64;
		val9.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck_nt).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcTien_ck_nt).HeaderText = "Chiết khấu";
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
		val10.BackColor = SystemColors.Window;
		val10.Format = "###.##";
		((DataGridViewColumn)dgvcTs_gtgt).DefaultCellStyle = val10;
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
		val11.Alignment = (DataGridViewContentAlignment)64;
		val11.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = "VAT";
		dgvcThue_gtgt_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).Name = "dgvcThue_gtgt_nt";
		((DataGridViewColumn)dgvcThue_gtgt_nt).ReadOnly = true;
		dgvcThue_gtgt_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_gtgt_nt).Width = 70;
		((DataGridViewColumn)dgvcGia2).DataPropertyName = "gia2";
		val12.Alignment = (DataGridViewContentAlignment)64;
		val12.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcGia2).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcGia2).HeaderText = "Giá VND";
		dgvcGia2.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcGia2).Name = "dgvcGia2";
		dgvcGia2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia2.SpecialType = Commons.NumericSpecialType.ACPrice;
		((DataGridViewColumn)dgvcGia2).Width = 90;
		((DataGridViewColumn)dgvcTien2).DataPropertyName = "tien2";
		val13.Alignment = (DataGridViewContentAlignment)64;
		val13.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcTien2).DefaultCellStyle = val13;
		((DataGridViewColumn)dgvcTien2).HeaderText = "T. bán VND";
		dgvcTien2.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcTien2).Name = "dgvcTien2";
		((DataGridViewColumn)dgvcTien2).ReadOnly = true;
		dgvcTien2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien2.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien2).Width = 90;
		((DataGridViewColumn)dgvcTien_ck).DataPropertyName = "tien_ck";
		val14.Alignment = (DataGridViewContentAlignment)64;
		val14.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcTien_ck).DefaultCellStyle = val14;
		((DataGridViewColumn)dgvcTien_ck).HeaderText = "C. khấu VND";
		dgvcTien_ck.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcTien_ck).Name = "dgvcTien_ck";
		((DataGridViewColumn)dgvcTien_ck).ReadOnly = true;
		dgvcTien_ck.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ck.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_ck).Width = 90;
		((DataGridViewColumn)dgvcThue_gtgt).DataPropertyName = "thue_gtgt";
		val15.Alignment = (DataGridViewContentAlignment)64;
		val15.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcThue_gtgt).DefaultCellStyle = val15;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = "VAT VND";
		dgvcThue_gtgt.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcThue_gtgt).Name = "dgvcThue_gtgt";
		((DataGridViewColumn)dgvcThue_gtgt).ReadOnly = true;
		dgvcThue_gtgt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_gtgt).Width = 80;
		dgvcTk_dt0.AutoFill = true;
		dgvcTk_dt0.AutoLookup = true;
		dgvcTk_dt0.AutoValid = true;
		((DataGridViewColumn)dgvcTk_dt0).DataPropertyName = "tk_dt";
		val16.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_dt0).DefaultCellStyle = val16;
		((DataGridViewColumn)dgvcTk_dt0).HeaderText = "Tk dt";
		dgvcTk_dt0.LookupCodeName = "TK";
		dgvcTk_dt0.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_dt0).Name = "dgvcTk_dt0";
		dgvcTk_dt0.ReceiverValidFieldList = "ten_tk_dt";
		dgvcTk_dt0.SD = true;
		dgvcTk_dt0.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_dt0.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_dt0).Visible = false;
		((DataGridViewColumn)dgvcTk_dt0).Width = 65;
		dgvcTk_ck0.AutoFill = true;
		dgvcTk_ck0.AutoLookup = true;
		dgvcTk_ck0.AutoValid = true;
		((DataGridViewColumn)dgvcTk_ck0).DataPropertyName = "tk_ck";
		val17.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_ck0).DefaultCellStyle = val17;
		((DataGridViewColumn)dgvcTk_ck0).HeaderText = "Tk ck";
		dgvcTk_ck0.LookupCodeName = "TK";
		dgvcTk_ck0.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_ck0).Name = "dgvcTk_ck0";
		dgvcTk_ck0.ReceiverValidFieldList = "ten_tk_ck";
		dgvcTk_ck0.SD = true;
		dgvcTk_ck0.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_ck0.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_ck0).Visible = false;
		((DataGridViewColumn)dgvcTk_ck0).Width = 65;
		dgvcMa_Nvkd.AutoFill = true;
		dgvcMa_Nvkd.AutoLookup = true;
		dgvcMa_Nvkd.AutoValid = true;
		((DataGridViewColumn)dgvcMa_Nvkd).DataPropertyName = "ma_nvkd";
		val18.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_Nvkd).DefaultCellStyle = val18;
		((DataGridViewColumn)dgvcMa_Nvkd).HeaderText = "NVKD";
		dgvcMa_Nvkd.LookupCodeName = "MA_NVKD";
		dgvcMa_Nvkd.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_Nvkd).Name = "dgvcMa_Nvkd";
		dgvcMa_Nvkd.ReceiverValidFieldList = "ten_nvkd";
		((DataGridViewColumn)dgvcMa_Nvkd).Resizable = (DataGridViewTriState)1;
		dgvcMa_Nvkd.SD = true;
		dgvcMa_Nvkd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_Nvkd.ValidReturnFieldList = "ten_nvkd";
		((DataGridViewColumn)dgvcMa_Nvkd).Width = 80;
		txtSo_Seri.CharacterCasing = (CharacterCasing)1;
		TextBox obj23 = txtSo_Seri;
		location = new Point(669, 12);
		((Control)obj23).Location = location;
		((Control)txtSo_Seri).Name = "txtSo_Seri";
		TextBox obj24 = txtSo_Seri;
		size = new Size(78, 20);
		((Control)obj24).Size = size;
		((Control)txtSo_Seri).TabIndex = 7;
		lblSo_seri.AutoSize = true;
		Label obj25 = lblSo_seri;
		location = new Point(554, 16);
		((Control)obj25).Location = location;
		((Control)lblSo_seri).Name = "lblSo_seri";
		Label obj26 = lblSo_seri;
		size = new Size(39, 13);
		((Control)obj26).Size = size;
		((Control)lblSo_seri).TabIndex = 232;
		lblSo_seri.Text = "Số seri";
		txtNgay_lct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_lct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_lct;
		location = new Point(669, 90);
		((Control)asMaskedTextBox2).Location = location;
		((MaskedTextBox)txtNgay_lct).Mask = "##/##/####";
		((Control)txtNgay_lct).Name = "txtNgay_lct";
		((MaskedTextBox)txtNgay_lct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_lct;
		size = new Size(78, 20);
		((Control)asMaskedTextBox3).Size = size;
		((Control)txtNgay_lct).TabIndex = 10;
		((MaskedTextBox)txtNgay_lct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_lct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox4.Value = dateTime;
		lblNgay_Lct.AutoSize = true;
		lblNgay_Lct.ImeMode = (ImeMode)0;
		Label obj27 = lblNgay_Lct;
		location = new Point(556, 94);
		((Control)obj27).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj28 = lblNgay_Lct;
		size = new Size(49, 13);
		((Control)obj28).Size = size;
		((Control)lblNgay_Lct).TabIndex = 234;
		lblNgay_Lct.Text = "Ngày lập";
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(678, 116);
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
		location = new Point(628, 116);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(47, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 11;
		lblMa_Nt.AutoSize = true;
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj29 = lblMa_Nt;
		location = new Point(556, 120);
		((Control)obj29).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj30 = lblMa_Nt;
		size = new Size(36, 13);
		((Control)obj30).Size = size;
		((Control)lblMa_Nt).TabIndex = 237;
		lblMa_Nt.Text = "Tỷ giá";
		((Control)lblT_Tt).Anchor = (AnchorStyles)6;
		lblT_Tt.AutoSize = true;
		((Control)lblT_Tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		lblT_Tt.ImeMode = (ImeMode)0;
		Label obj31 = lblT_Tt;
		location = new Point(426, 439);
		((Control)obj31).Location = location;
		((Control)lblT_Tt).Name = "lblT_Tt";
		Label obj32 = lblT_Tt;
		size = new Size(72, 13);
		((Control)obj32).Size = size;
		((Control)lblT_Tt).TabIndex = 233;
		lblT_Tt.Text = "Thanh toán";
		lblT_Tt.TextAlign = (ContentAlignment)16;
		((Control)lblT_Thue).Anchor = (AnchorStyles)6;
		lblT_Thue.AutoSize = true;
		((Control)lblT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Thue.ImeMode = (ImeMode)0;
		Label obj33 = lblT_Thue;
		location = new Point(426, 417);
		((Control)obj33).Location = location;
		((Control)lblT_Thue).Name = "lblT_Thue";
		Label obj34 = lblT_Thue;
		size = new Size(65, 13);
		((Control)obj34).Size = size;
		((Control)lblT_Thue).TabIndex = 232;
		lblT_Thue.Text = "Thuế GTGT";
		lblT_Thue.TextAlign = (ContentAlignment)16;
		((Control)txtT_tt).Anchor = (AnchorStyles)6;
		txtT_tt.DecimalSymbol = ".";
		((Control)txtT_tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtT_tt;
		location = new Point(651, 436);
		((Control)asTextNumeric3).Location = location;
		txtT_tt.Mask = "### ### ### ###";
		((Control)txtT_tt).Name = "txtT_tt";
		((TextBoxBase)txtT_tt).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtT_tt;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		txtT_tt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_tt).TabIndex = 231;
		((Control)txtT_tt).TabStop = false;
		((TextBox)txtT_tt).Text = "0";
		((TextBox)txtT_tt).TextAlign = (HorizontalAlignment)1;
		txtT_tt.Value = 0.0;
		((Control)txtT_Thue).Anchor = (AnchorStyles)6;
		txtT_Thue.DecimalSymbol = ".";
		((Control)txtT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric5 = txtT_Thue;
		location = new Point(651, 414);
		((Control)asTextNumeric5).Location = location;
		txtT_Thue.Mask = "### ### ### ###";
		((Control)txtT_Thue).Name = "txtT_Thue";
		((TextBoxBase)txtT_Thue).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtT_Thue;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		txtT_Thue.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Thue).TabIndex = 230;
		((Control)txtT_Thue).TabStop = false;
		((TextBox)txtT_Thue).Text = "0";
		((TextBox)txtT_Thue).TextAlign = (HorizontalAlignment)1;
		txtT_Thue.Value = 0.0;
		((Control)txtT_Tien2).Anchor = (AnchorStyles)6;
		txtT_Tien2.DecimalSymbol = ".";
		((Control)txtT_Tien2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric7 = txtT_Tien2;
		location = new Point(651, 370);
		((Control)asTextNumeric7).Location = location;
		txtT_Tien2.Mask = "### ### ### ###";
		((Control)txtT_Tien2).Name = "txtT_Tien2";
		((TextBoxBase)txtT_Tien2).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_Tien2;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_Tien2.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tien2).TabIndex = 229;
		((Control)txtT_Tien2).TabStop = false;
		((TextBox)txtT_Tien2).Text = "0";
		((TextBox)txtT_Tien2).TextAlign = (HorizontalAlignment)1;
		txtT_Tien2.Value = 0.0;
		((Control)lblT_Tien).Anchor = (AnchorStyles)6;
		lblT_Tien.AutoSize = true;
		((Control)lblT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Tien.ImeMode = (ImeMode)0;
		Label obj35 = lblT_Tien;
		location = new Point(426, 373);
		((Control)obj35).Location = location;
		((Control)lblT_Tien).Name = "lblT_Tien";
		Label obj36 = lblT_Tien;
		size = new Size(55, 13);
		((Control)obj36).Size = size;
		((Control)lblT_Tien).TabIndex = 228;
		lblT_Tien.Text = "Tiền hàng";
		lblT_Tien.TextAlign = (ContentAlignment)16;
		((Control)lblT_ck).Anchor = (AnchorStyles)6;
		lblT_ck.AutoSize = true;
		((Control)lblT_ck).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_ck.ImeMode = (ImeMode)0;
		Label obj37 = lblT_ck;
		location = new Point(426, 395);
		((Control)obj37).Location = location;
		((Control)lblT_ck).Name = "lblT_ck";
		Label obj38 = lblT_ck;
		size = new Size(67, 13);
		((Control)obj38).Size = size;
		((Control)lblT_ck).TabIndex = 235;
		lblT_ck.Text = "Giảm giá/CK";
		lblT_ck.TextAlign = (ContentAlignment)16;
		((Control)txtT_ck).Anchor = (AnchorStyles)6;
		txtT_ck.DecimalSymbol = ".";
		((Control)txtT_ck).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric9 = txtT_ck;
		location = new Point(651, 392);
		((Control)asTextNumeric9).Location = location;
		txtT_ck.Mask = "### ### ### ###";
		((Control)txtT_ck).Name = "txtT_ck";
		((TextBoxBase)txtT_ck).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtT_ck;
		size = new Size(100, 20);
		((Control)asTextNumeric10).Size = size;
		txtT_ck.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_ck).TabIndex = 234;
		((Control)txtT_ck).TabStop = false;
		((TextBox)txtT_ck).Text = "0";
		((TextBox)txtT_ck).TextAlign = (HorizontalAlignment)1;
		txtT_ck.Value = 0.0;
		((Control)txtT_ck_nt).Anchor = (AnchorStyles)6;
		txtT_ck_nt.DecimalSymbol = ".";
		((Control)txtT_ck_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric11 = txtT_ck_nt;
		location = new Point(545, 392);
		((Control)asTextNumeric11).Location = location;
		txtT_ck_nt.Mask = "### ### ### ###";
		((Control)txtT_ck_nt).Name = "txtT_ck_nt";
		((TextBoxBase)txtT_ck_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtT_ck_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric12).Size = size;
		txtT_ck_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_ck_nt).TabIndex = 239;
		((Control)txtT_ck_nt).TabStop = false;
		((TextBox)txtT_ck_nt).Text = "0";
		((TextBox)txtT_ck_nt).TextAlign = (HorizontalAlignment)1;
		txtT_ck_nt.Value = 0.0;
		((Control)txtT_tt_nt).Anchor = (AnchorStyles)6;
		txtT_tt_nt.DecimalSymbol = ".";
		((Control)txtT_tt_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric13 = txtT_tt_nt;
		location = new Point(545, 436);
		((Control)asTextNumeric13).Location = location;
		txtT_tt_nt.Mask = "### ### ### ###";
		((Control)txtT_tt_nt).Name = "txtT_tt_nt";
		((TextBoxBase)txtT_tt_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtT_tt_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric14).Size = size;
		txtT_tt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tt_nt).TabIndex = 238;
		((Control)txtT_tt_nt).TabStop = false;
		((TextBox)txtT_tt_nt).Text = "0";
		((TextBox)txtT_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tt_nt.Value = 0.0;
		((Control)txtT_thue_nt).Anchor = (AnchorStyles)6;
		txtT_thue_nt.DecimalSymbol = ".";
		((Control)txtT_thue_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric15 = txtT_thue_nt;
		location = new Point(545, 414);
		((Control)asTextNumeric15).Location = location;
		txtT_thue_nt.Mask = "### ### ### ###";
		((Control)txtT_thue_nt).Name = "txtT_thue_nt";
		((TextBoxBase)txtT_thue_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric16 = txtT_thue_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric16).Size = size;
		txtT_thue_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_thue_nt).TabIndex = 237;
		((Control)txtT_thue_nt).TabStop = false;
		((TextBox)txtT_thue_nt).Text = "0";
		((TextBox)txtT_thue_nt).TextAlign = (HorizontalAlignment)1;
		txtT_thue_nt.Value = 0.0;
		((Control)txtT_Tien_nt2).Anchor = (AnchorStyles)6;
		txtT_Tien_nt2.DecimalSymbol = ".";
		((Control)txtT_Tien_nt2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric17 = txtT_Tien_nt2;
		location = new Point(545, 370);
		((Control)asTextNumeric17).Location = location;
		txtT_Tien_nt2.Mask = "### ### ### ###";
		((Control)txtT_Tien_nt2).Name = "txtT_Tien_nt2";
		((TextBoxBase)txtT_Tien_nt2).ReadOnly = true;
		AsTextNumeric asTextNumeric18 = txtT_Tien_nt2;
		size = new Size(100, 20);
		((Control)asTextNumeric18).Size = size;
		txtT_Tien_nt2.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_Tien_nt2).TabIndex = 236;
		((Control)txtT_Tien_nt2).TabStop = false;
		((TextBox)txtT_Tien_nt2).Text = "0";
		((TextBox)txtT_Tien_nt2).TextAlign = (HorizontalAlignment)1;
		txtT_Tien_nt2.Value = 0.0;
		((Control)chkSua_thue).Anchor = (AnchorStyles)10;
		((ButtonBase)chkSua_thue).AutoSize = true;
		chkSua_thue.Checked = false;
		((Control)chkSua_thue).Enabled = false;
		AsCheckBox asCheckBox = chkSua_thue;
		location = new Point(37, 413);
		((Control)asCheckBox).Location = location;
		((Control)chkSua_thue).Name = "chkSua_thue";
		AsCheckBox asCheckBox2 = chkSua_thue;
		size = new Size(89, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkSua_thue).TabIndex = 250;
		((Control)chkSua_thue).TabStop = false;
		((ButtonBase)chkSua_thue).Text = "Sửa tiền thuế";
		chkSua_thue.TextValue = "0";
		((ButtonBase)chkSua_thue).UseVisualStyleBackColor = true;
		((Control)chkSua_thue).Visible = false;
		((Control)chkSua_ck).Anchor = (AnchorStyles)10;
		((ButtonBase)chkSua_ck).AutoSize = true;
		chkSua_ck.Checked = false;
		((Control)chkSua_ck).Enabled = false;
		AsCheckBox asCheckBox3 = chkSua_ck;
		location = new Point(132, 416);
		((Control)asCheckBox3).Location = location;
		((Control)chkSua_ck).Name = "chkSua_ck";
		AsCheckBox asCheckBox4 = chkSua_ck;
		size = new Size(98, 17);
		((Control)asCheckBox4).Size = size;
		((Control)chkSua_ck).TabIndex = 251;
		((Control)chkSua_ck).TabStop = false;
		((ButtonBase)chkSua_ck).Text = "Sửa chiết khấu";
		chkSua_ck.TextValue = "0";
		((ButtonBase)chkSua_ck).UseVisualStyleBackColor = true;
		((Control)chkSua_ck).Visible = false;
		Label6.AutoSize = true;
		Label6.ImeMode = (ImeMode)0;
		Label label = Label6;
		location = new Point(9, 104);
		((Control)label).Location = location;
		((Control)Label6).Name = "Label6";
		Label label2 = Label6;
		size = new Size(76, 13);
		((Control)label2).Size = size;
		((Control)Label6).TabIndex = 262;
		Label6.Text = "Mã thanh toán";
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj39 = lblTen_Kh;
		location = new Point(195, 16);
		((Control)obj39).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj40 = lblTen_Kh;
		size = new Size(336, 13);
		((Control)obj40).Size = size;
		((Control)lblTen_Kh).TabIndex = 268;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj41 = lblNguoi_Gd;
		location = new Point(9, 59);
		((Control)obj41).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj42 = lblNguoi_Gd;
		size = new Size(71, 14);
		((Control)obj42).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 267;
		lblNguoi_Gd.Text = "Người mua";
		TextBox obj43 = txtNguoi_Gd;
		location = new Point(114, 56);
		((Control)obj43).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj44 = txtNguoi_Gd;
		size = new Size(162, 20);
		((Control)obj44).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 2;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(114, 12);
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
		txtMa_Kh.ValidReturnFieldList = "ten_kh,dia_chi,ma_so_thue,nguoi_gd,tel,gh_no,ma_tt,ma_httt";
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj45 = lblMa_Kh;
		location = new Point(9, 16);
		((Control)obj45).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj46 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj46).Size = size;
		((Control)lblMa_Kh).TabIndex = 266;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		((Control)lblTk_pt).Anchor = (AnchorStyles)6;
		lblTk_pt.ImeMode = (ImeMode)0;
		Label obj47 = lblTk_pt;
		location = new Point(3, 5);
		((Control)obj47).Location = location;
		((Control)lblTk_pt).Name = "lblTk_pt";
		Label obj48 = lblTk_pt;
		size = new Size(98, 14);
		((Control)obj48).Size = size;
		((Control)lblTk_pt).TabIndex = 239;
		lblTk_pt.Text = "Tài khoản phải thu";
		((Control)lblTk_thue).Anchor = (AnchorStyles)6;
		lblTk_thue.ImeMode = (ImeMode)0;
		Label obj49 = lblTk_thue;
		location = new Point(276, 5);
		((Control)obj49).Location = location;
		((Control)lblTk_thue).Name = "lblTk_thue";
		Label obj50 = lblTk_thue;
		size = new Size(83, 14);
		((Control)obj50).Size = size;
		((Control)lblTk_thue).TabIndex = 242;
		lblTk_thue.Text = "Tài khoản thuế";
		((Control)txtTk_thue).Anchor = (AnchorStyles)6;
		txtTk_thue.AutoLookup = true;
		txtTk_thue.AutoValid = true;
		((TextBoxBase)txtTk_thue).BackColor = SystemColors.Info;
		((TextBox)txtTk_thue).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk_thue;
		location = new Point(364, 2);
		((Control)asTextBox3).Location = location;
		txtTk_thue.LookupCodeName = "TK";
		txtTk_thue.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_thue).Name = "txtTk_thue";
		txtTk_thue.NameControl = null;
		txtTk_thue.SD = true;
		AsTextBox asTextBox4 = txtTk_thue;
		size = new Size(78, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk_thue).TabIndex = 1;
		txtTk_thue.UseAutoCompleteSource = false;
		((Control)txtTk_pt).Anchor = (AnchorStyles)6;
		txtTk_pt.AutoLookup = true;
		txtTk_pt.AutoValid = true;
		((TextBoxBase)txtTk_pt).BackColor = SystemColors.Info;
		((TextBox)txtTk_pt).CharacterCasing = (CharacterCasing)1;
		((Control)txtTk_pt).Enabled = false;
		AsTextBox asTextBox5 = txtTk_pt;
		location = new Point(107, 2);
		((Control)asTextBox5).Location = location;
		txtTk_pt.LookupCodeName = "TK";
		txtTk_pt.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_pt).Name = "txtTk_pt";
		txtTk_pt.NameControl = null;
		txtTk_pt.SD = true;
		AsTextBox asTextBox6 = txtTk_pt;
		size = new Size(78, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTk_pt).TabIndex = 0;
		txtTk_pt.UseAutoCompleteSource = false;
		txtGh_no.DecimalSymbol = ".";
		((Control)txtGh_no).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric19 = txtGh_no;
		location = new Point(114, 122);
		((Control)asTextNumeric19).Location = location;
		txtGh_no.Mask = "### ### ### ###";
		((Control)txtGh_no).Name = "txtGh_no";
		((TextBoxBase)txtGh_no).ReadOnly = true;
		AsTextNumeric asTextNumeric20 = txtGh_no;
		size = new Size(113, 20);
		((Control)asTextNumeric20).Size = size;
		((Control)txtGh_no).TabIndex = 256;
		((Control)txtGh_no).TabStop = false;
		((TextBox)txtGh_no).Text = "0";
		((TextBox)txtGh_no).TextAlign = (HorizontalAlignment)1;
		txtGh_no.Value = 0.0;
		Label7.AutoSize = true;
		Label7.ImeMode = (ImeMode)0;
		Label label3 = Label7;
		location = new Point(9, 126);
		((Control)label3).Location = location;
		((Control)Label7).Name = "Label7";
		Label label4 = Label7;
		size = new Size(61, 13);
		((Control)label4).Size = size;
		((Control)Label7).TabIndex = 255;
		Label7.Text = "Giới hạn nợ";
		TextBox obj51 = txtDia_chi_vat;
		location = new Point(114, 34);
		((Control)obj51).Location = location;
		((Control)txtDia_chi_vat).Name = "txtDia_chi_vat";
		TextBox obj52 = txtDia_chi_vat;
		size = new Size(417, 20);
		((Control)obj52).Size = size;
		((Control)txtDia_chi_vat).TabIndex = 1;
		lblDia_chi.AutoSize = true;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj53 = lblDia_chi;
		location = new Point(9, 38);
		((Control)obj53).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj54 = lblDia_chi;
		size = new Size(40, 13);
		((Control)obj54).Size = size;
		((Control)lblDia_chi).TabIndex = 146;
		lblDia_chi.Text = "Địa chỉ";
		TextBox obj55 = txtMa_so_thue;
		location = new Point(407, 56);
		((Control)obj55).Location = location;
		((Control)txtMa_so_thue).Name = "txtMa_so_thue";
		TextBox obj56 = txtMa_so_thue;
		size = new Size(124, 20);
		((Control)obj56).Size = size;
		((Control)txtMa_so_thue).TabIndex = 3;
		lblMa_so_thue.AutoSize = true;
		lblMa_so_thue.ImeMode = (ImeMode)0;
		Label obj57 = lblMa_so_thue;
		location = new Point(340, 60);
		((Control)obj57).Location = location;
		((Control)lblMa_so_thue).Name = "lblMa_so_thue";
		Label obj58 = lblMa_so_thue;
		size = new Size(60, 13);
		((Control)obj58).Size = size;
		((Control)lblMa_so_thue).TabIndex = 246;
		lblMa_so_thue.Text = "Mã số thuế";
		lblMa_so_thue.TextAlign = (ContentAlignment)16;
		txtMa_Httt.AutoLookup = true;
		txtMa_Httt.AutoValid = true;
		((TextBoxBase)txtMa_Httt).BackColor = SystemColors.Info;
		((TextBox)txtMa_Httt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_Httt;
		location = new Point(114, 100);
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
		txtMa_Httt.ValidReturnFieldList = "tk,tk_thue_gtgt_ban,ten_httt";
		((Control)lblTen_Httt).Enabled = false;
		lblTen_Httt.ImeMode = (ImeMode)0;
		Label obj59 = lblTen_Httt;
		location = new Point(34, 392);
		((Control)obj59).Location = location;
		((Control)lblTen_Httt).Name = "lblTen_Httt";
		Label obj60 = lblTen_Httt;
		size = new Size(338, 13);
		((Control)obj60).Size = size;
		((Control)lblTen_Httt).TabIndex = 270;
		lblTen_Httt.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Httt).Visible = false;
		txtDu13.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric21 = txtDu13;
		location = new Point(407, 123);
		((Control)asTextNumeric21).Location = location;
		txtDu13.Mask = "### ### ### ###";
		((Control)txtDu13).Name = "txtDu13";
		AsTextNumeric asTextNumeric22 = txtDu13;
		size = new Size(124, 20);
		((Control)asTextNumeric22).Size = size;
		((Control)txtDu13).TabIndex = 272;
		((Control)txtDu13).TabStop = false;
		((TextBox)txtDu13).Text = "0";
		((TextBox)txtDu13).TextAlign = (HorizontalAlignment)1;
		txtDu13.Value = 0.0;
		Label14.AutoSize = true;
		Label14.ImeMode = (ImeMode)0;
		Label label5 = Label14;
		location = new Point(336, 127);
		((Control)label5).Location = location;
		((Control)Label14).Name = "Label14";
		Label label6 = Label14;
		size = new Size(64, 13);
		((Control)label6).Size = size;
		((Control)Label14).TabIndex = 271;
		Label14.Text = "Dư hiện thời";
		TabPage1.BackColor = SystemColors.Control;
		((Control)TabPage1).Controls.Add((Control)(object)DataGridView2);
		TabPage tabPage = TabPage1;
		location = new Point(4, 25);
		tabPage.Location = location;
		((Control)TabPage1).Name = "TabPage1";
		TabPage tabPage2 = TabPage1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).Padding = padding;
		TabPage tabPage3 = TabPage1;
		size = new Size(681, 122);
		((Control)tabPage3).Size = size;
		TabPage1.TabIndex = 0;
		TabPage1.Text = "TabPage1";
		((Control)DataGridView2).Anchor = (AnchorStyles)15;
		val19.Alignment = (DataGridViewContentAlignment)16;
		val19.BackColor = SystemColors.Control;
		val19.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val19.ForeColor = SystemColors.WindowText;
		val19.SelectionBackColor = SystemColors.Highlight;
		val19.SelectionForeColor = SystemColors.HighlightText;
		val19.WrapMode = (DataGridViewTriState)1;
		DataGridView2.ColumnHeadersDefaultCellStyle = val19;
		DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView2.Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn1,
			(DataGridViewColumn)DataGridViewTextBoxColumn2,
			(DataGridViewColumn)DataGridViewTextBoxColumn3,
			(DataGridViewColumn)DataGridViewTextBoxColumn4,
			(DataGridViewColumn)DataGridViewTextBoxColumn5
		});
		val20.Alignment = (DataGridViewContentAlignment)16;
		val20.BackColor = SystemColors.Window;
		val20.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val20.ForeColor = SystemColors.ControlText;
		val20.SelectionBackColor = SystemColors.Highlight;
		val20.SelectionForeColor = SystemColors.HighlightText;
		val20.WrapMode = (DataGridViewTriState)2;
		DataGridView2.DefaultCellStyle = val20;
		DataGridView dataGridView = DataGridView2;
		location = new Point(3, -3);
		((Control)dataGridView).Location = location;
		((Control)DataGridView2).Name = "DataGridView2";
		val21.Alignment = (DataGridViewContentAlignment)16;
		val21.BackColor = SystemColors.Control;
		val21.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val21.ForeColor = SystemColors.WindowText;
		val21.SelectionBackColor = SystemColors.Highlight;
		val21.SelectionForeColor = SystemColors.HighlightText;
		val21.WrapMode = (DataGridViewTriState)1;
		DataGridView2.RowHeadersDefaultCellStyle = val21;
		DataGridView dataGridView2 = DataGridView2;
		size = new Size(675, 0);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView2).TabIndex = 1;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).HeaderText = "Column1";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).HeaderText = "Column2";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Name = "DataGridViewTextBoxColumn2";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).HeaderText = "Column3";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Name = "DataGridViewTextBoxColumn3";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).HeaderText = "Column4";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Name = "DataGridViewTextBoxColumn4";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).HeaderText = "Column5";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).Name = "DataGridViewTextBoxColumn5";
		TabPage2.BackColor = SystemColors.Control;
		TabPage tabPage4 = TabPage2;
		location = new Point(4, 25);
		tabPage4.Location = location;
		((Control)TabPage2).Name = "TabPage2";
		TabPage tabPage5 = TabPage2;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage5).Padding = padding;
		TabPage tabPage6 = TabPage2;
		size = new Size(681, 122);
		((Control)tabPage6).Size = size;
		TabPage2.TabIndex = 1;
		TabPage2.Text = "TabPage2";
		TabPage tabPage7 = TabPage3;
		location = new Point(4, 22);
		tabPage7.Location = location;
		((Control)TabPage3).Name = "TabPage3";
		TabPage tabPage8 = TabPage3;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage8).Padding = padding;
		TabPage tabPage9 = TabPage3;
		size = new Size(673, 127);
		((Control)tabPage9).Size = size;
		TabPage3.TabIndex = 0;
		TabPage3.Text = "TabPage3";
		TabPage3.UseVisualStyleBackColor = true;
		((Control)TabPage4).Controls.Add((Control)(object)DataGridView3);
		TabPage tabPage10 = TabPage4;
		location = new Point(4, 22);
		tabPage10.Location = location;
		((Control)TabPage4).Name = "TabPage4";
		TabPage tabPage11 = TabPage4;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage11).Padding = padding;
		TabPage tabPage12 = TabPage4;
		size = new Size(673, 127);
		((Control)tabPage12).Size = size;
		TabPage4.TabIndex = 1;
		TabPage4.Text = "TabPage4";
		TabPage4.UseVisualStyleBackColor = true;
		((Control)DataGridView3).Anchor = (AnchorStyles)15;
		val22.Alignment = (DataGridViewContentAlignment)16;
		val22.BackColor = SystemColors.Control;
		val22.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val22.ForeColor = SystemColors.WindowText;
		val22.SelectionBackColor = SystemColors.Highlight;
		val22.SelectionForeColor = SystemColors.HighlightText;
		val22.WrapMode = (DataGridViewTriState)1;
		DataGridView3.ColumnHeadersDefaultCellStyle = val22;
		DataGridView3.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView3.Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn6,
			(DataGridViewColumn)DataGridViewTextBoxColumn7,
			(DataGridViewColumn)DataGridViewTextBoxColumn8,
			(DataGridViewColumn)DataGridViewTextBoxColumn9,
			(DataGridViewColumn)DataGridViewTextBoxColumn10
		});
		val23.Alignment = (DataGridViewContentAlignment)16;
		val23.BackColor = SystemColors.Window;
		val23.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val23.ForeColor = SystemColors.ControlText;
		val23.SelectionBackColor = SystemColors.Highlight;
		val23.SelectionForeColor = SystemColors.HighlightText;
		val23.WrapMode = (DataGridViewTriState)2;
		DataGridView3.DefaultCellStyle = val23;
		DataGridView dataGridView3 = DataGridView3;
		location = new Point(3, 6);
		((Control)dataGridView3).Location = location;
		((Control)DataGridView3).Name = "DataGridView3";
		val24.Alignment = (DataGridViewContentAlignment)16;
		val24.BackColor = SystemColors.Control;
		val24.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val24.ForeColor = SystemColors.WindowText;
		val24.SelectionBackColor = SystemColors.Highlight;
		val24.SelectionForeColor = SystemColors.HighlightText;
		val24.WrapMode = (DataGridViewTriState)1;
		DataGridView3.RowHeadersDefaultCellStyle = val24;
		DataGridView dataGridView4 = DataGridView3;
		size = new Size(664, 93);
		((Control)dataGridView4).Size = size;
		((Control)DataGridView3).TabIndex = 1;
		((DataGridViewColumn)DataGridViewTextBoxColumn6).HeaderText = "Column1";
		((DataGridViewColumn)DataGridViewTextBoxColumn6).Name = "DataGridViewTextBoxColumn6";
		((DataGridViewColumn)DataGridViewTextBoxColumn7).HeaderText = "Column2";
		((DataGridViewColumn)DataGridViewTextBoxColumn7).Name = "DataGridViewTextBoxColumn7";
		((DataGridViewColumn)DataGridViewTextBoxColumn8).HeaderText = "Column3";
		((DataGridViewColumn)DataGridViewTextBoxColumn8).Name = "DataGridViewTextBoxColumn8";
		((DataGridViewColumn)DataGridViewTextBoxColumn9).HeaderText = "Column4";
		((DataGridViewColumn)DataGridViewTextBoxColumn9).Name = "DataGridViewTextBoxColumn9";
		((DataGridViewColumn)DataGridViewTextBoxColumn10).HeaderText = "Column5";
		((DataGridViewColumn)DataGridViewTextBoxColumn10).Name = "DataGridViewTextBoxColumn10";
		tabHach_toan.BackColor = SystemColors.Control;
		((Control)tabHach_toan).Controls.Add((Control)(object)SplitContainerHachToan);
		TabPage obj61 = tabHach_toan;
		location = new Point(4, 25);
		obj61.Location = location;
		((Control)tabHach_toan).Name = "tabHach_toan";
		TabPage obj62 = tabHach_toan;
		((Padding)(ref padding))._002Ector(3);
		((Control)obj62).Padding = padding;
		TabPage obj63 = tabHach_toan;
		size = new Size(746, 184);
		((Control)obj63).Size = size;
		tabHach_toan.TabIndex = 2;
		tabHach_toan.Text = "Hạch toá&n";
		SplitContainerHachToan.Dock = (DockStyle)5;
		SplitContainerHachToan.FixedPanel = (FixedPanel)2;
		SplitContainer splitContainerHachToan = SplitContainerHachToan;
		location = new Point(3, 3);
		((Control)splitContainerHachToan).Location = location;
		((Control)SplitContainerHachToan).Name = "SplitContainerHachToan";
		SplitContainerHachToan.Orientation = (Orientation)0;
		((Control)SplitContainerHachToan.Panel1).Controls.Add((Control)(object)adgvHach_toan);
		((Control)SplitContainerHachToan.Panel2).Controls.Add((Control)(object)lblTk_pt);
		((Control)SplitContainerHachToan.Panel2).Controls.Add((Control)(object)txtTk_pt);
		((Control)SplitContainerHachToan.Panel2).Controls.Add((Control)(object)txtTk_thue);
		((Control)SplitContainerHachToan.Panel2).Controls.Add((Control)(object)lblTk_thue);
		SplitContainer splitContainerHachToan2 = SplitContainerHachToan;
		size = new Size(740, 178);
		((Control)splitContainerHachToan2).Size = size;
		SplitContainerHachToan.SplitterDistance = 148;
		((Control)SplitContainerHachToan).TabIndex = 244;
		((DataGridView)adgvHach_toan).AllowUserToAddRows = false;
		((DataGridView)adgvHach_toan).AllowUserToDeleteRows = false;
		((DataGridView)adgvHach_toan).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvHach_toan).BorderStyle = (BorderStyle)2;
		val25.Alignment = (DataGridViewContentAlignment)16;
		val25.BackColor = SystemColors.Control;
		val25.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val25.ForeColor = SystemColors.WindowText;
		val25.SelectionBackColor = SystemColors.Highlight;
		val25.SelectionForeColor = SystemColors.HighlightText;
		val25.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).ColumnHeadersDefaultCellStyle = val25;
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
		val26.Alignment = (DataGridViewContentAlignment)16;
		val26.BackColor = SystemColors.Window;
		val26.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val26.ForeColor = SystemColors.ControlText;
		val26.SelectionBackColor = SystemColors.Highlight;
		val26.SelectionForeColor = SystemColors.HighlightText;
		val26.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvHach_toan).DefaultCellStyle = val26;
		((Control)adgvHach_toan).Dock = (DockStyle)5;
		((DataGridView)adgvHach_toan).GridColor = SystemColors.Control;
		adgvHach_toan.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV3 = adgvHach_toan;
		location = new Point(0, 0);
		((Control)asInputDGV3).Location = location;
		((Control)adgvHach_toan).Name = "adgvHach_toan";
		val27.Alignment = (DataGridViewContentAlignment)32;
		val27.BackColor = SystemColors.Control;
		val27.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val27.ForeColor = SystemColors.WindowText;
		val27.SelectionBackColor = SystemColors.Highlight;
		val27.SelectionForeColor = SystemColors.HighlightText;
		val27.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).RowHeadersDefaultCellStyle = val27;
		((DataGridView)adgvHach_toan).RowHeadersWidth = 35;
		((DataGridView)adgvHach_toan).RowTemplate.Height = 20;
		AsInputDGV asInputDGV4 = adgvHach_toan;
		size = new Size(740, 148);
		((Control)asInputDGV4).Size = size;
		((Control)adgvHach_toan).TabIndex = 0;
		((DataGridViewColumn)dgvcTen_vt_ht).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vt_ht).Frozen = true;
		((DataGridViewColumn)dgvcTen_vt_ht).HeaderText = "Tên vật tư";
		((DataGridViewColumn)dgvcTen_vt_ht).Name = "dgvcTen_vt_ht";
		((DataGridViewColumn)dgvcTen_vt_ht).ReadOnly = true;
		dgvcTen_vt_ht.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_vt_ht).Width = 170;
		((DataGridViewColumn)dgvcTien_nt2_ht).DataPropertyName = "tien_nt2";
		val28.Alignment = (DataGridViewContentAlignment)64;
		val28.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2_ht).DefaultCellStyle = val28;
		((DataGridViewColumn)dgvcTien_nt2_ht).HeaderText = "Tiền hàng";
		dgvcTien_nt2_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2_ht).Name = "dgvcTien_nt2_ht";
		((DataGridViewColumn)dgvcTien_nt2_ht).ReadOnly = true;
		dgvcTien_nt2_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt2_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt2_ht).Width = 90;
		((DataGridViewColumn)dgvcTien_ck_nt_ht).DataPropertyName = "tien_ck_nt";
		val29.Alignment = (DataGridViewContentAlignment)64;
		val29.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck_nt_ht).DefaultCellStyle = val29;
		((DataGridViewColumn)dgvcTien_ck_nt_ht).HeaderText = "C. khấu";
		dgvcTien_ck_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck_nt_ht).Name = "dgvcTien_ck_nt_ht";
		((DataGridViewColumn)dgvcTien_ck_nt_ht).ReadOnly = true;
		dgvcTien_ck_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ck_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_ck_nt_ht).ToolTipText = "Chiết khấu tiền hàng (trước thuế)/giảm giá";
		((DataGridViewColumn)dgvcTien_ck_nt_ht).Width = 90;
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).DataPropertyName = "thue_gtgt_nt";
		val30.Alignment = (DataGridViewContentAlignment)64;
		val30.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).DefaultCellStyle = val30;
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).HeaderText = "VAT";
		dgvcThue_gtgt_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).Name = "dgvcThue_gtgt_nt_ht";
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).ReadOnly = true;
		dgvcThue_gtgt_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).ToolTipText = "Thuế giá trị gia tăng";
		((DataGridViewColumn)dgvcThue_gtgt_nt_ht).Width = 80;
		((DataGridViewColumn)dgvcTien_nt_ht).DataPropertyName = "tien_nt";
		val31.Alignment = (DataGridViewContentAlignment)64;
		val31.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).DefaultCellStyle = val31;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = "Tiền vốn";
		dgvcTien_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).Name = "dgvcTien_nt_ht";
		((DataGridViewColumn)dgvcTien_nt_ht).ReadOnly = true;
		dgvcTien_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt_ht).Visible = false;
		((DataGridViewColumn)dgvcTien_nt_ht).Width = 90;
		((DataGridViewColumn)dgvcTien2_ht).DataPropertyName = "tien2";
		val32.Alignment = (DataGridViewContentAlignment)64;
		val32.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien2_ht).DefaultCellStyle = val32;
		((DataGridViewColumn)dgvcTien2_ht).HeaderText = "Tiền hàng VNĐ";
		dgvcTien2_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien2_ht).Name = "dgvcTien2_ht";
		((DataGridViewColumn)dgvcTien2_ht).ReadOnly = true;
		dgvcTien2_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien2_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien2_ht).Width = 90;
		((DataGridViewColumn)dgvcTien_Ck_ht).DataPropertyName = "tien_ck";
		val33.Alignment = (DataGridViewContentAlignment)64;
		val33.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_Ck_ht).DefaultCellStyle = val33;
		((DataGridViewColumn)dgvcTien_Ck_ht).HeaderText = "CK VNĐ";
		dgvcTien_Ck_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_Ck_ht).Name = "dgvcTien_Ck_ht";
		((DataGridViewColumn)dgvcTien_Ck_ht).ReadOnly = true;
		dgvcTien_Ck_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_Ck_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_Ck_ht).Width = 90;
		val34.Alignment = (DataGridViewContentAlignment)64;
		val34.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_ht).DefaultCellStyle = val34;
		((DataGridViewColumn)dgvcThue_gtgt_ht).HeaderText = "Thuế VNĐ";
		dgvcThue_gtgt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_ht).Name = "dgvcThue_gtgt_ht";
		((DataGridViewColumn)dgvcThue_gtgt_ht).ReadOnly = true;
		dgvcThue_gtgt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_gtgt_ht).Width = 80;
		((DataGridViewColumn)dgvcTien_ht).DataPropertyName = "tien";
		val35.Alignment = (DataGridViewContentAlignment)64;
		val35.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ht).DefaultCellStyle = val35;
		((DataGridViewColumn)dgvcTien_ht).HeaderText = "Tiền vốn VNĐ";
		dgvcTien_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ht).Name = "dgvcTien_ht";
		((DataGridViewColumn)dgvcTien_ht).ReadOnly = true;
		dgvcTien_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_ht).Visible = false;
		((DataGridViewColumn)dgvcTien_ht).Width = 90;
		dgvcTk_dt.AutoFill = true;
		dgvcTk_dt.AutoLookup = true;
		dgvcTk_dt.AutoValid = true;
		((DataGridViewColumn)dgvcTk_dt).DataPropertyName = "tk_dt";
		val36.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_dt).DefaultCellStyle = val36;
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
		val37.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_gv).DefaultCellStyle = val37;
		((DataGridViewColumn)dgvcTk_gv).HeaderText = "Tk gv";
		dgvcTk_gv.LookupCodeName = "TK";
		dgvcTk_gv.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_gv).Name = "dgvcTk_gv";
		dgvcTk_gv.ReceiverValidFieldList = "ten_tk_gv";
		dgvcTk_gv.SD = true;
		dgvcTk_gv.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_gv.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_gv).Visible = false;
		((DataGridViewColumn)dgvcTk_gv).Width = 65;
		dgvcTk_vt.AutoFill = true;
		dgvcTk_vt.AutoLookup = true;
		dgvcTk_vt.AutoValid = true;
		((DataGridViewColumn)dgvcTk_vt).DataPropertyName = "tk_vt";
		val38.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_vt).DefaultCellStyle = val38;
		((DataGridViewColumn)dgvcTk_vt).HeaderText = "Tk kho";
		dgvcTk_vt.LookupCodeName = "TK";
		dgvcTk_vt.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_vt).Name = "dgvcTk_vt";
		dgvcTk_vt.ReceiverValidFieldList = "ten_tk_vt";
		dgvcTk_vt.SD = true;
		dgvcTk_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_vt.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_vt).Visible = false;
		((DataGridViewColumn)dgvcTk_vt).Width = 65;
		dgvcTk_ck.AutoFill = true;
		dgvcTk_ck.AutoLookup = true;
		dgvcTk_ck.AutoValid = true;
		((DataGridViewColumn)dgvcTk_ck).DataPropertyName = "tk_ck";
		val39.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_ck).DefaultCellStyle = val39;
		((DataGridViewColumn)dgvcTk_ck).HeaderText = "Tk gg";
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
		cboHttt.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboHttt).FormattingEnabled = true;
		cboHttt.Items.AddRange(new object[3] { "TM/CK", "TM", "CK" });
		ComboBox obj64 = cboHttt;
		location = new Point(406, 100);
		((Control)obj64).Location = location;
		((Control)cboHttt).Name = "cboHttt";
		ComboBox obj65 = cboHttt;
		size = new Size(125, 21);
		((Control)obj65).Size = size;
		((Control)cboHttt).TabIndex = 6;
		Label1.AutoSize = true;
		Label label7 = Label1;
		location = new Point(293, 103);
		((Control)label7).Location = location;
		((Control)Label1).Name = "Label1";
		((Control)Label1).RightToLeft = (RightToLeft)1;
		Label label8 = Label1;
		size = new Size(107, 13);
		((Control)label8).Size = size;
		((Control)Label1).TabIndex = 277;
		Label1.Text = "Hình thức thanh toán";
		((Control)cmdThanh_toan).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdThanh_toan).Image = (Image)componentResourceManager.GetObject("cmdThanh_toan.Image");
		((ButtonBase)cmdThanh_toan).ImageAlign = (ContentAlignment)16;
		Button obj66 = cmdThanh_toan;
		location = new Point(143, 468);
		((Control)obj66).Location = location;
		((Control)cmdThanh_toan).Name = "cmdThanh_toan";
		Button obj67 = cmdThanh_toan;
		size = new Size(64, 23);
		((Control)obj67).Size = size;
		((Control)cmdThanh_toan).TabIndex = 4;
		((ButtonBase)cmdThanh_toan).Text = "Th&u tiền";
		((ButtonBase)cmdThanh_toan).TextAlign = (ContentAlignment)64;
		size = new Size(760, 516);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdThanh_toan);
		((Control)this).Controls.Add((Control)(object)txtT_tt);
		((Control)this).Controls.Add((Control)(object)chkSua_ck);
		((Control)this).Controls.Add((Control)(object)txtT_Tien_nt2);
		((Control)this).Controls.Add((Control)(object)chkSua_thue);
		((Control)this).Controls.Add((Control)(object)txtT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_thue_nt);
		((Control)this).Controls.Add((Control)(object)lblT_Tt);
		((Control)this).Controls.Add((Control)(object)txtT_ck);
		((Control)this).Controls.Add((Control)(object)lblTen_Httt);
		((Control)this).Controls.Add((Control)(object)lblT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_ck_nt);
		((Control)this).Controls.Add((Control)(object)txtT_Tien2);
		((Control)this).Controls.Add((Control)(object)lblT_Tien);
		((Control)this).Controls.Add((Control)(object)lblT_ck);
		((Control)this).Controls.Add((Control)(object)txtT_tt_nt);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmSoVchSO5";
		((Form)this).Text = "frmSoVchSO5";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_ck, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien2, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen_Httt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_thue_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkSua_thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien_nt2, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkSua_ck, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt, 0);
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
		((ISupportInitialize)adgvDetail).EndInit();
		((Control)TabPage1).ResumeLayout(false);
		((ISupportInitialize)DataGridView2).EndInit();
		((Control)TabPage4).ResumeLayout(false);
		((ISupportInitialize)DataGridView3).EndInit();
		((Control)tabHach_toan).ResumeLayout(false);
		((Control)SplitContainerHachToan.Panel1).ResumeLayout(false);
		((Control)SplitContainerHachToan.Panel2).ResumeLayout(false);
		((Control)SplitContainerHachToan.Panel2).PerformLayout();
		((Control)SplitContainerHachToan).ResumeLayout(false);
		((ISupportInitialize)adgvHach_toan).EndInit();
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
		}
	}

	private void txtMa_Kh_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if ((base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !((TextBoxBase)txtMa_Kh).ReadOnly && ((Control)txtMa_Kh).Enabled && ((Control)txtMa_Kh).Visible && e.ValidatedRow != null) || 1 == 0)
		{
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
		if (base.ActionMode != Commons.ApplicationMode.VIEW_MODE && e.ValidatedRow != null && 0 == 0)
		{
			((TextBox)txtTk_pt).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			((TextBox)txtTk_thue).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_ban"]), isNum: false));
			CurrentPHRow["Tk_pt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			CurrentPHRow["Tk_thue"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_ban"]), isNum: false));
			txtDu13.Value = Commons.GetDuArkh(((TextBox)txtMa_Kh).Text, ((TextBox)txtTk_pt).Text, Conversions.ToDate(txtNgay_Ct.Value));
		}
	}

	private void txtTy_gia_Validated(object sender, EventArgs e)
	{
		if ((!base.IsLoading && base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !IsValidateCalledFromValidData) || 1 == 0)
		{
			V_Ty_Gia();
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

	private void chkSua_ck_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		if ((int)((CheckBox)chkSua_ck).CheckState != 0)
		{
			return;
		}
		foreach (DataGridViewRow item in (IEnumerable)((DataGridView)adgvDetail).Rows)
		{
			DataGridViewRow val = item;
			Calc_ChietKhau(base.CT1Voucher[((DataGridViewBand)val).Index]);
		}
	}

	private void adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged(object sender, SetDependentFieldsWhenCellValueChangedEventArgs e)
	{
		if ((CTTable != null && !base.IsLoading && e.ValidatedRow != null) || 1 == 0)
		{
			DataRowView oDv = CT1Voucher[((DataGridViewCellEventArgs)e).RowIndex];
			string name = ((DataGridView)adgvDetail).Columns[((DataGridViewCellEventArgs)e).ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_vt).Name, false) == 0)
			{
				V_Ma_Vt(oDv, e.ValidatedRow);
				e.Handled = true;
			}
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia2).Name, false) == 0)
			{
				V_Gia2(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt2).Name, false) == 0)
			{
				V_Tien_Nt2(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien2).Name, false) == 0)
			{
				V_Tien2(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTl_ck).Name, false) == 0)
			{
				V_Tl_Ck(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_ck_nt).Name, false) == 0)
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
		if (CTTable != null && !base.IsLoading && 0 == 0)
		{
			DataRowView dataRowView = CT1Voucher[e.RowIndex];
			object obj = null;
			DataGridViewCell currentCell = ((DataGridView)adgvDetail).CurrentCell;
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien2).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien2(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_ck_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Ck_Nt(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Thue_Gtgt_Nt(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_ck).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Ck(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Thue_Gtgt(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_dt).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_dt"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_ck).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_ck"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_Nvkd).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["ten_nvkd"]);
			}
			obj = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(obj), isNum: false));
			((ToolStripItem)tsslInfo).Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(obj, (object)"", false), (object)frmVoucher.BASEVOUCHER_INPUTGRID_TIP_TEXT, RuntimeHelpers.GetObjectValue(obj)));
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_ck).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(currentCTRowView["Ten_Tk_ck"]);
			}
			obj = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(obj), isNum: false));
			((ToolStripItem)tsslInfo).Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(obj, (object)"", false), (object)frmVoucher.BASEVOUCHER_INPUTGRID_TIP_TEXT, RuntimeHelpers.GetObjectValue(obj)));
		}
	}

	private void cmdThanh_toan_Click(object sender, EventArgs e)
	{
		Thanh_toan();
	}

	private bool W_Gia2(DataRowView oDv)
	{
		return true;
	}

	private bool W_Tien2(DataRowView oDv)
	{
		return true;
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

	private void V_Ma_Vt(DataRowView oDv, DataRow oDrValidated)
	{
		if (!Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_vt"]), isNum: false), (object)"", false))
		{
			oDv["ten_vt"] = RuntimeHelpers.GetObjectValue(oDrValidated["ten_vt"]);
			if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrValidated["tk_dt"]), isNum: false), (object)"", false))
			{
				oDv["tk_dt"] = RuntimeHelpers.GetObjectValue(oDrValidated["tk_dt"]);
			}
			if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrValidated["tk_ck"]), isNum: false), (object)"", false))
			{
				oDv["tk_ck"] = RuntimeHelpers.GetObjectValue(oDrValidated["tk_ck"]);
			}
			DataRow pDrw = null;
			if (Commons.ValidMa(ref pDrw, "MA_THUE", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_thue"]), isNum: false)), "", "ts_gtgt", pSd: true))
			{
				oDv["ts_gtgt"] = RuntimeHelpers.GetObjectValue(pDrw["ts_gtgt"]);
			}
			Calc_Thue_gtgt(oDv);
			Calc_ThanhToan(oDv);
		}
	}

	private void V_So_Luong(DataRowView oDv)
	{
		Calc_TienHang(oDv);
		Calc_ChietKhau(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		Calc_So_luong_qd(oDv);
		UpdateList();
	}

	private void V_Gia_Nt2(DataRowView oDv)
	{
		Calc_GiaBan(oDv);
		Calc_TienHang(oDv);
		Calc_ChietKhau(oDv);
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
		Calc_ChietKhau(oDv);
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
		else
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
		Calc_ChietKhau(oDv);
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
		Calc_ChietKhau(oDv);
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

	private void V_Tien_Ck_Nt(DataRowView oDv)
	{
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
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true)),
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
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true), txtTy_gia.Value),
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
				}
				else
				{
					object[] array3;
					SIConfiguration sIConfiguration;
					object[] array;
					bool[] array5;
					if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
					{
						Type? typeFromHandle5 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt2"]), isNum: true), txtTy_gia.Value),
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
						item["gia2"] = RuntimeHelpers.GetObjectValue(obj5);
					}
					if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia2"]), isNum: true)), (object)0, false))
					{
						Type? typeFromHandle6 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia2"]), isNum: true)),
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
						item["Tien2"] = RuntimeHelpers.GetObjectValue(obj6);
					}
					else
					{
						Type? typeFromHandle7 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_nt2"]), isNum: true), txtTy_gia.Value),
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
						item["Tien2"] = RuntimeHelpers.GetObjectValue(obj7);
					}
					if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien2"]), isNum: true)), (object)0, false))
					{
						Type? typeFromHandle8 = typeof(Math);
						array3 = new object[3]
						{
							Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien2"]), isNum: true)), (object)100),
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
						item["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj8);
					}
					else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
					{
						Type? typeFromHandle9 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Ck_nt"]), isNum: true), txtTy_gia.Value),
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
						item["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj9);
					}
					Type? typeFromHandle10 = typeof(Math);
					array3 = new object[3]
					{
						Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Ck"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ck_ds"]), isNum: true))), (object)100),
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
					double num = Conversions.ToDouble(obj10);
					if (num != 0.0)
					{
						item["Thue_Gtgt"] = num;
					}
					else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
					{
						Type? typeFromHandle11 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_Nt"]), isNum: true), txtTy_gia.Value),
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
						item["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj11);
					}
				}
				Calc_ThanhToan(item);
			}
		}
		UpdateList();
	}

	private void GetKhInfo()
	{
		txtDu13.Value = Commons.GetDuArkh(((TextBox)txtMa_Kh).Text, ((TextBox)txtTk_pt).Text, Conversions.ToDate(txtNgay_Ct.Value));
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
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tl_Ck"]), isNum: true)), (object)100),
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
				Operators.DivideObject(Operators.MultiplyObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true)), (object)100),
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
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia2"]), isNum: true)),
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
			double num3 = Conversions.ToDouble(obj4);
			if (num3 == 0.0)
			{
				Type? typeFromHandle5 = typeof(Math);
				array4 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_nt2"]), isNum: true), txtTy_gia.Value),
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
				odv["Tien2"] = RuntimeHelpers.GetObjectValue(obj5);
			}
			Type? typeFromHandle6 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien2"]), isNum: true)), (object)100),
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
			double num4 = Conversions.ToDouble(obj6);
			if (num4 == 0.0)
			{
				Type? typeFromHandle7 = typeof(Math);
				array4 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_nt"]), isNum: true), txtTy_gia.Value),
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
				odv["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj7);
			}
			Type? typeFromHandle8 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ck_ds"]), isNum: true))), (object)100),
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
			double num5 = Conversions.ToDouble(obj8);
			if (num5 == 0.0)
			{
				Type? typeFromHandle9 = typeof(Math);
				array = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Gtgt_Nt"]), isNum: true), txtTy_gia.Value),
					null,
					null
				};
				object[] array12 = array;
				SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array12[1] = sIConfiguration.Round;
				array[2] = MidpointRounding.AwayFromZero;
				array4 = array;
				object[] array13 = array4;
				array3 = new bool[3] { false, true, false };
				object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle9, "Round", array13, (string[])null, (Type[])null, array3);
				if (array3[1])
				{
					sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
				}
				odv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj9);
			}
			RecipeABC(dgvcTien2, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien2"]), isNum: true)), num3, gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcTien_ck, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien_ck"]), isNum: true)), num4, gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_gtgt, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Gtgt"]), isNum: true)), num5, gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcTien_nt2, dbA, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcTien_ck_nt, dbA2, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_gtgt_nt, dbA3, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, index, Cmess, ref CmessGHDC);
		}
		else
		{
			Type? typeFromHandle10 = typeof(Math);
			object[] array4 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia_Nt2"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array14 = array4;
			bool[] array3 = new bool[3] { false, true, false };
			object obj10 = NewLateBinding.LateGet((object)null, typeFromHandle10, "Round", array14, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA4 = Conversions.ToDouble(obj10);
			Type? typeFromHandle11 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tl_Ck"]), isNum: true)), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array15 = array4;
			array3 = new bool[3] { false, true, false };
			object obj11 = NewLateBinding.LateGet((object)null, typeFromHandle11, "Round", array15, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA5 = Conversions.ToDouble(obj11);
			Type? typeFromHandle12 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true)), (object)100),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array16 = array4;
			array3 = new bool[3] { false, true, false };
			object obj12 = NewLateBinding.LateGet((object)null, typeFromHandle12, "Round", array16, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA6 = Conversions.ToDouble(obj12);
			RecipeABC(dgvcTien_nt2, dbA4, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcTien_ck_nt, dbA5, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_gtgt_nt, dbA6, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
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
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien_nt2"]), isNum: true)),
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
			item["tien_nt2"] = RuntimeHelpers.GetObjectValue(obj);
			Type? typeFromHandle2 = typeof(Math);
			object[] array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt2"]), isNum: true)),
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
			item["gia_nt2"] = RuntimeHelpers.GetObjectValue(obj2);
			Type? typeFromHandle3 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien_ck_nt"]), isNum: true)),
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
			item["tien_ck_nt"] = RuntimeHelpers.GetObjectValue(obj3);
			Type? typeFromHandle4 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_Nt"]), isNum: true)),
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
			item["Thue_Gtgt_Nt"] = RuntimeHelpers.GetObjectValue(obj4);
			Type? typeFromHandle5 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tt_nt"]), isNum: true)),
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
			item["Tt_nt"] = RuntimeHelpers.GetObjectValue(obj5);
		}
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

	private void Thanh_toan()
	{
		//IL_09d6: Unknown result type (might be due to invalid IL or missing references)
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
			((TextBox)frmCA4SO.txtTk_No).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["tk_no"]), isNum: false));
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
		((DataGridView)adgvHach_toan).DataSource = base.bsCT;
		AddControl2ListOfDrivedControls((Control)(object)txtDia_chi_vat);
		AddControl2ListOfDrivedControls((Control)(object)txtMa_so_thue);
		AddControl2ListOfDrivedControls((Control)(object)txtTk_pt);
		AddControl2ListOfDrivedControls((Control)(object)txtTk_thue);
		AddDGV(adgvHach_toan);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Tien_nt2);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_ck_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_thue_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tt_nt);
		string ma_nt = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		f_sGia_ban = ((DataGridViewColumn)dgvcGia_nt2).HeaderText;
		f_sTien_ban = ((DataGridViewColumn)dgvcTien_nt2).HeaderText;
		f_sTien_ck = ((DataGridViewColumn)dgvcTien_ck_nt).HeaderText;
		f_sTien_thue = ((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText;
		((DataGridViewColumn)dgvcGia2).HeaderText = f_sGia_ban + " " + ma_nt;
		((DataGridViewColumn)dgvcTien2).HeaderText = f_sTien_ban + " " + ma_nt;
		((DataGridViewColumn)dgvcTien_ck).HeaderText = f_sTien_ck + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = f_sTien_thue + " " + ma_nt;
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
		string mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
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
			mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			((TextBoxBase)txtTy_gia).ReadOnly = ActionMode == Commons.ApplicationMode.VIEW_MODE;
			((Control)txtTy_gia).TabStop = true;
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				txtTy_gia.Value = Commons.Get_TyGia(cboMa_NT.MA_NT, Conversions.ToDate(txtNgay_Ct.Value));
			}
		}
		((Control)txtT_Tien2).Visible = visible;
		((Control)txtT_ck).Visible = visible;
		((Control)txtT_Thue).Visible = visible;
		((Control)txtT_tt).Visible = visible;
		((DataGridViewColumn)dgvcGia2).Visible = visible;
		((DataGridViewColumn)dgvcTien2).Visible = visible;
		((DataGridViewColumn)dgvcTien_ck).Visible = visible;
		((DataGridViewColumn)dgvcThue_gtgt).Visible = visible;
		txtT_Tien_nt2.Mask = mask;
		txtT_thue_nt.Mask = mask;
		txtT_ck_nt.Mask = mask;
		txtT_tt_nt.Mask = mask;
		string mA_NT = cboMa_NT.MA_NT;
		((DataGridViewColumn)dgvcGia_nt2).HeaderText = f_sGia_ban + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt2).HeaderText = f_sTien_ban + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_ck_nt).HeaderText = f_sTien_ck + " " + mA_NT;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = f_sTien_thue + " " + mA_NT;
	}

	protected override void SetFocus4FirstEditControl()
	{
		((Control)txtMa_Kh).Focus();
	}

	protected override void UpdateList()
	{
		if (base.CurrentPHRow != null)
		{
			string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", base.CurrentPHRow["Stt_Rec"]), (object)"'"));
			txtT_Tien_nt2.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_nt2)", filter));
			txtT_thue_nt.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(thue_gtgt_nt)", filter));
			txtT_ck_nt.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_ck_nt)", filter));
			txtT_tt_nt.Value = Operators.SubtractObject(Operators.AddObject(txtT_Tien_nt2.Value, txtT_thue_nt.Value), txtT_ck_nt.Value);
			txtT_Tien2.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien2)", filter));
			txtT_Thue.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(thue_gtgt)", filter));
			txtT_ck.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_ck)", filter));
			txtT_tt.Value = Operators.SubtractObject(Operators.AddObject(txtT_Tien2.Value, txtT_Thue.Value), txtT_ck.Value);
		}
	}

	protected override bool ValidData()
	{
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		if (!base.ValidData())
		{
			return false;
		}
		bool CmessGHDC = false;
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_Kh))
		{
			((Control)txtMa_Kh).Select();
			return false;
		}
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
			((TabControl)AsTabControl).SelectedTab = tabDetail;
			((Control)txtTk_thue).Select();
			return false;
		}
		bool flag = true;
		checked
		{
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
				if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_ck"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Ck_Nt"]), isNum: true)), (object)0, false)) ? true : false)
				{
					return ValidGridCell(1, ((DataGridView)adgvHach_toan)[((DataGridViewColumn)dgvcTk_ck).Name, num2], 50023);
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
		CreateDataBinding((Control)(object)txtNgay_lct, "ngay_lct", "Value");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)txtMa_Httt, "Ma_Httt");
		CreateDataBinding((Control)(object)cboHttt, "Httt");
		CreateDataBinding((Control)(object)txtTk_pt, "tk_pt");
		CreateDataBinding((Control)(object)txtTk_thue, "tk_thue");
		CreateDataBinding((Control)(object)txtT_Tien2, "t_tien2", "Value");
		CreateDataBinding((Control)(object)txtT_ck, "t_ck", "Value");
		CreateDataBinding((Control)(object)txtT_Thue, "t_thue", "Value");
		CreateDataBinding((Control)(object)txtT_tt, "t_tt", "Value");
		CreateDataBinding((Control)(object)txtT_Tien_nt2, "t_tien_nt2", "Value");
		CreateDataBinding((Control)(object)txtT_ck_nt, "t_ck_nt", "Value");
		CreateDataBinding((Control)(object)txtT_thue_nt, "t_thue_nt", "Value");
		CreateDataBinding((Control)(object)txtT_tt_nt, "t_tt_nt", "Value");
		CreateDataBinding((Control)(object)chkSua_ck, "sua_ck", "Checked");
		CreateDataBinding((Control)(object)chkSua_thue, "sua_thue", "Checked");
	}

	protected override void SetPHDefaultValues(DataRow drwPh)
	{
		drwPh["ngay_lct"] = RuntimeHelpers.GetObjectValue(drwPh["ngay_ct"]);
	}

	protected override void SetNextInputGridControlFocus()
	{
		((Control)cmdAdd).Focus();
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
		((DataGridView)adgvDetail).CancelEdit();
		base.Cancel();
	}

	protected override bool ChkStatusRight([Optional][DefaultParameterValue("")] ref string retMess)
	{
		return SOCommon.SOChkStatusRightSO5(Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentPHRow["stt_rec"]), isNum: false)), ref retMess);
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
