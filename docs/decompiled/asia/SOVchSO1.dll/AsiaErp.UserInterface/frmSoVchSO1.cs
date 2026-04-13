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
using AsiaErp.SOUtilities;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSoVchSO1 : frmVoucher
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

	[AccessedThroughProperty("txtHan_Giao")]
	private AsMaskedTextBox _txtHan_Giao;

	[AccessedThroughProperty("lblHan_giao")]
	private Label _lblHan_giao;

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

	[AccessedThroughProperty("lblTong")]
	private Label _lblTong;

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

	[AccessedThroughProperty("chkSua_tien")]
	private AsCheckBox _chkSua_tien;

	[AccessedThroughProperty("adgvDetail")]
	private AsInputDGV _adgvDetail;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("lblTrang_thai")]
	private Label _lblTrang_thai;

	[AccessedThroughProperty("cboTrang_thai")]
	private AsComboBoxTT _cboTrang_thai;

	[AccessedThroughProperty("txtT_So_luong")]
	private AsTextNumeric _txtT_So_luong;

	[AccessedThroughProperty("txtDu13")]
	private AsTextNumeric _txtDu13;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("FolderBrowserDialog1")]
	private FolderBrowserDialog _FolderBrowserDialog1;

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

	[AccessedThroughProperty("txtMa_Httt")]
	private AsTextBox _txtMa_Httt;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("chkCk_st")]
	private AsCheckBox _chkCk_st;

	[AccessedThroughProperty("txtTl_ck_ds")]
	private AsTextNumeric _txtTl_ck_ds;

	[AccessedThroughProperty("txtT_ck_ds")]
	private AsTextNumeric _txtT_ck_ds;

	[AccessedThroughProperty("txtT_ck_ds_nt")]
	private AsTextNumeric _txtT_ck_ds_nt;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("lblTen_Httt")]
	private Label _lblTen_Httt;

	[AccessedThroughProperty("dgvcMa_vt")]
	private DataGridViewAsTextBoxColumn _dgvcMa_vt;

	[AccessedThroughProperty("dgvcTen_vt")]
	private DataGridViewTextBoxColumn _dgvcTen_vt;

	[AccessedThroughProperty("dgvcDvt")]
	private DataGridViewTextBoxColumn _dgvcDvt;

	[AccessedThroughProperty("dgvcMa_kho")]
	private DataGridViewAsTextBoxColumn _dgvcMa_kho;

	[AccessedThroughProperty("dgvcMa_Vitri")]
	private DataGridViewAsTextBoxColumn _dgvcMa_Vitri;

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

	[AccessedThroughProperty("dgvcKhuyen_mai")]
	private DataGridViewCheckBoxColumn _dgvcKhuyen_mai;

	[AccessedThroughProperty("dgvcMa_lo")]
	private DataGridViewAsTextBoxColumn _dgvcMa_lo;

	[AccessedThroughProperty("dgvcMa_Bp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_Bp;

	[AccessedThroughProperty("dgvcMa_NvKd")]
	private DataGridViewAsTextBoxColumn _dgvcMa_NvKd;

	[AccessedThroughProperty("chkGia_st")]
	private AsCheckBox _chkGia_st;

	private bool f_isGetKhInfo;

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

	internal virtual AsMaskedTextBox txtHan_Giao
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHan_Giao;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtHan_Giao = value;
		}
	}

	internal virtual Label lblHan_giao
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblHan_giao;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblHan_giao = value;
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

	internal virtual Label lblTong
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTong = value;
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

	protected internal virtual Label lblTrang_thai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTrang_thai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTrang_thai = value;
		}
	}

	protected internal virtual AsComboBoxTT cboTrang_thai
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboTrang_thai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboTrang_thai = value;
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

	internal virtual FolderBrowserDialog FolderBrowserDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _FolderBrowserDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FolderBrowserDialog1 = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_Vitri
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_Vitri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_Vitri = value;
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

	internal virtual DataGridViewCheckBoxColumn dgvcKhuyen_mai
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcKhuyen_mai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcKhuyen_mai = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_lo = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_Bp = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_NvKd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_NvKd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_NvKd = value;
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

	public frmSoVchSO1()
	{
		__ENCAddToList(this);
		f_isGetKhInfo = false;
		f_sGia_ban = "";
		f_sTien_ban = "";
		f_sTien_ck = "";
		f_sTien_thue = "";
		InitializeComponent();
	}

	public frmSoVchSO1(string menuid)
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

	public frmSoVchSO1(string MenuID, string Stt_rec)
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
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_13d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13da: Expected O, but got Unknown
		//IL_1490: Unknown result type (might be due to invalid IL or missing references)
		//IL_149a: Expected O, but got Unknown
		//IL_1554: Unknown result type (might be due to invalid IL or missing references)
		//IL_155e: Expected O, but got Unknown
		//IL_165c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1666: Expected O, but got Unknown
		//IL_1764: Unknown result type (might be due to invalid IL or missing references)
		//IL_176e: Expected O, but got Unknown
		//IL_1868: Unknown result type (might be due to invalid IL or missing references)
		//IL_1872: Expected O, but got Unknown
		//IL_1928: Unknown result type (might be due to invalid IL or missing references)
		//IL_1932: Expected O, but got Unknown
		//IL_19ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f6: Expected O, but got Unknown
		//IL_1af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afe: Expected O, but got Unknown
		//IL_1bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c06: Expected O, but got Unknown
		//IL_1d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0e: Expected O, but got Unknown
		//IL_1e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e16: Expected O, but got Unknown
		//IL_1f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1e: Expected O, but got Unknown
		//IL_1ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2008: Expected O, but got Unknown
		//IL_20f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ff: Expected O, but got Unknown
		//IL_21e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f2: Expected O, but got Unknown
		//IL_22ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b6: Expected O, but got Unknown
		//IL_264a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2654: Expected O, but got Unknown
		//IL_27d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_27da: Expected O, but got Unknown
		//IL_2893: Unknown result type (might be due to invalid IL or missing references)
		//IL_289d: Expected O, but got Unknown
		//IL_39c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_39ce: Expected O, but got Unknown
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
		txtMa_Kh = new AsTextBox();
		lblTen_Kh = new Label();
		lblMa_Kh = new Label();
		lblNguoi_Gd = new Label();
		txtDien_giai = new TextBox();
		txtNguoi_Gd = new TextBox();
		lblDien_giai = new Label();
		txtHan_Giao = new AsMaskedTextBox();
		lblHan_giao = new Label();
		txtTy_gia = new AsTextNumeric();
		cboMa_NT = new AsComboBoxNT();
		lblMa_Nt = new Label();
		lblT_Tt = new Label();
		lblT_Thue = new Label();
		txtT_tt = new AsTextNumeric();
		txtT_Thue = new AsTextNumeric();
		txtT_Tien2 = new AsTextNumeric();
		lblTong = new Label();
		lblT_ck = new Label();
		txtT_ck = new AsTextNumeric();
		txtT_ck_nt = new AsTextNumeric();
		txtT_tt_nt = new AsTextNumeric();
		txtT_thue_nt = new AsTextNumeric();
		txtT_Tien_nt2 = new AsTextNumeric();
		txtTl_ck_ds = new AsTextNumeric();
		txtT_ck_ds = new AsTextNumeric();
		txtT_ck_ds_nt = new AsTextNumeric();
		Label7 = new Label();
		txtT_So_luong = new AsTextNumeric();
		chkSua_thue = new AsCheckBox();
		chkSua_ck = new AsCheckBox();
		chkSua_tien = new AsCheckBox();
		adgvDetail = new AsInputDGV();
		dgvcMa_vt = new DataGridViewAsTextBoxColumn();
		dgvcTen_vt = new DataGridViewTextBoxColumn();
		dgvcDvt = new DataGridViewTextBoxColumn();
		dgvcMa_kho = new DataGridViewAsTextBoxColumn();
		dgvcMa_Vitri = new DataGridViewAsTextBoxColumn();
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
		dgvcKhuyen_mai = new DataGridViewCheckBoxColumn();
		dgvcMa_lo = new DataGridViewAsTextBoxColumn();
		dgvcMa_Bp = new DataGridViewAsTextBoxColumn();
		dgvcMa_NvKd = new DataGridViewAsTextBoxColumn();
		lblTrang_thai = new Label();
		cboTrang_thai = new AsComboBoxTT();
		txtDu13 = new AsTextNumeric();
		Label14 = new Label();
		FolderBrowserDialog1 = new FolderBrowserDialog();
		txtGh_no = new AsTextNumeric();
		Label4 = new Label();
		lblMa_so_thue = new Label();
		txtMa_so_thue = new TextBox();
		lblDia_chi = new Label();
		txtDia_chi_vat = new TextBox();
		txtMa_Httt = new AsTextBox();
		lblTen_Httt = new Label();
		Label6 = new Label();
		chkCk_st = new AsCheckBox();
		chkGia_st = new AsCheckBox();
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
		((Control)this).SuspendLayout();
		Button obj = cmdAdd;
		Point location = new Point(4, 477);
		((Control)obj).Location = location;
		((Control)cmdAdd).TabIndex = 6;
		Button obj2 = cmdPrint;
		location = new Point(74, 477);
		((Control)obj2).Location = location;
		((Control)cmdPrint).TabIndex = 8;
		Button obj3 = cmdLast;
		location = new Point(685, 477);
		((Control)obj3).Location = location;
		((Control)cmdLast).TabIndex = 16;
		Button obj4 = cmdNext;
		location = new Point(660, 477);
		((Control)obj4).Location = location;
		((Control)cmdNext).TabIndex = 15;
		Button obj5 = cmdPrevious;
		location = new Point(635, 477);
		((Control)obj5).Location = location;
		((Control)cmdPrevious).TabIndex = 14;
		Button obj6 = cmdFirst;
		location = new Point(610, 477);
		((Control)obj6).Location = location;
		((Control)cmdFirst).TabIndex = 13;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(513, 43);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct;
		Size size = new Size(69, 13);
		((Control)obj8).Size = size;
		lblSo_Ct.Text = "Số đơn hàng";
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		Label obj9 = lblNgay_Ct;
		location = new Point(513, 17);
		((Control)obj9).Location = location;
		Label obj10 = lblNgay_Ct;
		size = new Size(81, 13);
		((Control)obj10).Size = size;
		lblNgay_Ct.Text = "Ngày đơn hàng";
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)5;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(618, 13);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay_Ct).TabIndex = 8;
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Httt);
		((Control)gbPH).Controls.Add((Control)(object)txtGh_no);
		((Control)gbPH).Controls.Add((Control)(object)Label4);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)lblDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)txtDia_chi_vat);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Httt);
		((Control)gbPH).Controls.Add((Control)(object)Label6);
		((Control)gbPH).Controls.Add((Control)(object)txtDu13);
		((Control)gbPH).Controls.Add((Control)(object)Label14);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)lblTrang_thai);
		((Control)gbPH).Controls.Add((Control)(object)cboTrang_thai);
		((Control)gbPH).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbPH).Controls.Add((Control)(object)lblDien_giai);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)txtNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)lblNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)txtTy_gia);
		((Control)gbPH).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Nt);
		((Control)gbPH).Controls.Add((Control)(object)txtHan_Giao);
		((Control)gbPH).Controls.Add((Control)(object)lblHan_giao);
		gbPH.FlatStyle = (FlatStyle)0;
		GroupBox obj11 = gbPH;
		location = new Point(4, -2);
		((Control)obj11).Location = location;
		GroupBox obj12 = gbPH;
		size = new Size(704, 155);
		((Control)obj12).Size = size;
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblHan_giao, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtHan_Giao, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTy_gia, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboTrang_thai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTrang_thai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label14, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDu13, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDia_chi_vat, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtGh_no, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Httt, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(529, 477);
		((Control)splitButton).Location = location;
		((Control)cmdSearch).TabIndex = 12;
		AsTabControl asTabControl = AsTabControl;
		location = new Point(2, 156);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(709, 201);
		((Control)asTabControl2).Size = size;
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj13 = tabDetail;
		size = new Size(701, 172);
		((Control)obj13).Size = size;
		TabPage obj14 = tabOptFields;
		size = new Size(701, 172);
		((Control)obj14).Size = size;
		Button obj15 = cmdCopy;
		location = new Point(284, 477);
		((Control)obj15).Location = location;
		((Control)cmdCopy).TabIndex = 11;
		Button obj16 = cmdDelete;
		location = new Point(214, 477);
		((Control)obj16).Location = location;
		((Control)cmdDelete).TabIndex = 10;
		Button obj17 = cmdEdit;
		location = new Point(144, 477);
		((Control)obj17).Location = location;
		((Control)cmdEdit).TabIndex = 9;
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		TextBox obj18 = txtSo_Ct;
		location = new Point(618, 39);
		((Control)obj18).Location = location;
		((Control)txtSo_Ct).TabIndex = 9;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(94, 13);
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
		location = new Point(173, 16);
		((Control)obj19).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj20 = lblTen_Kh;
		size = new Size(314, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_Kh).TabIndex = 250;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj21 = lblMa_Kh;
		location = new Point(6, 16);
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
		location = new Point(6, 62);
		((Control)obj23).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj24 = lblNguoi_Gd;
		size = new Size(71, 14);
		((Control)obj24).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 143;
		lblNguoi_Gd.Text = "Người mua";
		TextBox obj25 = txtDien_giai;
		location = new Point(94, 82);
		((Control)obj25).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj26 = txtDien_giai;
		size = new Size(403, 20);
		((Control)obj26).Size = size;
		((Control)txtDien_giai).TabIndex = 4;
		TextBox obj27 = txtNguoi_Gd;
		location = new Point(94, 59);
		((Control)obj27).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj28 = txtNguoi_Gd;
		size = new Size(168, 20);
		((Control)obj28).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 2;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj29 = lblDien_giai;
		location = new Point(6, 86);
		((Control)obj29).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj30 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj30).Size = size;
		((Control)lblDien_giai).TabIndex = 144;
		lblDien_giai.Text = "Diễn giải";
		txtHan_Giao.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtHan_Giao).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox2 = txtHan_Giao;
		location = new Point(618, 65);
		((Control)asMaskedTextBox2).Location = location;
		((MaskedTextBox)txtHan_Giao).Mask = "##/##/####";
		((Control)txtHan_Giao).Name = "txtHan_Giao";
		((MaskedTextBox)txtHan_Giao).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox3 = txtHan_Giao;
		size = new Size(78, 20);
		((Control)asMaskedTextBox3).Size = size;
		((Control)txtHan_Giao).TabIndex = 10;
		((MaskedTextBox)txtHan_Giao).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox4 = txtHan_Giao;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox4.Value = dateTime;
		lblHan_giao.AutoSize = true;
		lblHan_giao.ImeMode = (ImeMode)0;
		Label obj31 = lblHan_giao;
		location = new Point(512, 69);
		((Control)obj31).Location = location;
		((Control)lblHan_giao).Name = "lblHan_giao";
		Label obj32 = lblHan_giao;
		size = new Size(50, 13);
		((Control)obj32).Size = size;
		((Control)lblHan_giao).TabIndex = 234;
		lblHan_giao.Text = "Hạn giao";
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(627, 91);
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
		location = new Point(577, 91);
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
		location = new Point(512, 95);
		((Control)obj33).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj34 = lblMa_Nt;
		size = new Size(36, 13);
		((Control)obj34).Size = size;
		((Control)lblMa_Nt).TabIndex = 237;
		lblMa_Nt.Text = "Tỷ giá";
		((Control)lblT_Tt).Anchor = (AnchorStyles)6;
		lblT_Tt.AutoSize = true;
		((Control)lblT_Tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		lblT_Tt.ImeMode = (ImeMode)0;
		Label obj35 = lblT_Tt;
		location = new Point(287, 451);
		((Control)obj35).Location = location;
		((Control)lblT_Tt).Name = "lblT_Tt";
		Label obj36 = lblT_Tt;
		size = new Size(72, 13);
		((Control)obj36).Size = size;
		((Control)lblT_Tt).TabIndex = 233;
		lblT_Tt.Text = "Thanh toán";
		lblT_Tt.TextAlign = (ContentAlignment)16;
		((Control)lblT_Thue).Anchor = (AnchorStyles)6;
		lblT_Thue.AutoSize = true;
		((Control)lblT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Thue.ImeMode = (ImeMode)0;
		Label obj37 = lblT_Thue;
		location = new Point(287, 433);
		((Control)obj37).Location = location;
		((Control)lblT_Thue).Name = "lblT_Thue";
		Label obj38 = lblT_Thue;
		size = new Size(65, 13);
		((Control)obj38).Size = size;
		((Control)lblT_Thue).TabIndex = 232;
		lblT_Thue.Text = "Thuế GTGT";
		lblT_Thue.TextAlign = (ContentAlignment)16;
		((Control)txtT_tt).Anchor = (AnchorStyles)6;
		txtT_tt.DecimalSymbol = ".";
		((Control)txtT_tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtT_tt;
		location = new Point(608, 451);
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
		location = new Point(608, 429);
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
		location = new Point(608, 363);
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
		((Control)lblTong).Anchor = (AnchorStyles)6;
		lblTong.AutoSize = true;
		((Control)lblTong).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblTong.ImeMode = (ImeMode)0;
		Label obj39 = lblTong;
		location = new Point(287, 366);
		((Control)obj39).Location = location;
		((Control)lblTong).Name = "lblTong";
		Label obj40 = lblTong;
		size = new Size(59, 13);
		((Control)obj40).Size = size;
		((Control)lblTong).TabIndex = 228;
		lblTong.Text = "Tổng cộng";
		lblTong.TextAlign = (ContentAlignment)16;
		((Control)lblT_ck).Anchor = (AnchorStyles)6;
		lblT_ck.AutoSize = true;
		((Control)lblT_ck).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_ck.ImeMode = (ImeMode)0;
		Label obj41 = lblT_ck;
		location = new Point(287, 389);
		((Control)obj41).Location = location;
		((Control)lblT_ck).Name = "lblT_ck";
		Label obj42 = lblT_ck;
		size = new Size(105, 13);
		((Control)obj42).Size = size;
		((Control)lblT_ck).TabIndex = 235;
		lblT_ck.Text = "Chiết khấu mặt hàng";
		lblT_ck.TextAlign = (ContentAlignment)16;
		((Control)txtT_ck).Anchor = (AnchorStyles)6;
		txtT_ck.DecimalSymbol = ".";
		((Control)txtT_ck).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric9 = txtT_ck;
		location = new Point(608, 385);
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
		location = new Point(502, 385);
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
		location = new Point(502, 451);
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
		location = new Point(502, 429);
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
		location = new Point(502, 363);
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
		((Control)txtTl_ck_ds).Anchor = (AnchorStyles)6;
		txtTl_ck_ds.DecimalSymbol = ".";
		((Control)txtTl_ck_ds).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric19 = txtTl_ck_ds;
		location = new Point(445, 407);
		((Control)asTextNumeric19).Location = location;
		txtTl_ck_ds.Mask = "### ### ### ###.0#";
		((Control)txtTl_ck_ds).Name = "txtTl_ck_ds";
		((TextBoxBase)txtTl_ck_ds).ReadOnly = true;
		AsTextNumeric asTextNumeric20 = txtTl_ck_ds;
		size = new Size(51, 20);
		((Control)asTextNumeric20).Size = size;
		((Control)txtTl_ck_ds).TabIndex = 4;
		((TextBox)txtTl_ck_ds).Text = "0.00";
		((TextBox)txtTl_ck_ds).TextAlign = (HorizontalAlignment)1;
		txtTl_ck_ds.Value = 0.0;
		((Control)txtT_ck_ds).Anchor = (AnchorStyles)6;
		txtT_ck_ds.DecimalSymbol = ".";
		((Control)txtT_ck_ds).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric21 = txtT_ck_ds;
		location = new Point(608, 407);
		((Control)asTextNumeric21).Location = location;
		txtT_ck_ds.Mask = "### ### ### ###";
		((Control)txtT_ck_ds).Name = "txtT_ck_ds";
		((TextBoxBase)txtT_ck_ds).ReadOnly = true;
		AsTextNumeric asTextNumeric22 = txtT_ck_ds;
		size = new Size(100, 20);
		((Control)asTextNumeric22).Size = size;
		txtT_ck_ds.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_ck_ds).TabIndex = 5;
		((TextBox)txtT_ck_ds).Text = "0";
		((TextBox)txtT_ck_ds).TextAlign = (HorizontalAlignment)1;
		txtT_ck_ds.Value = 0.0;
		((Control)txtT_ck_ds_nt).Anchor = (AnchorStyles)6;
		txtT_ck_ds_nt.DecimalSymbol = ".";
		((Control)txtT_ck_ds_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric23 = txtT_ck_ds_nt;
		location = new Point(502, 407);
		((Control)asTextNumeric23).Location = location;
		txtT_ck_ds_nt.Mask = "### ### ### ###";
		((Control)txtT_ck_ds_nt).Name = "txtT_ck_ds_nt";
		((TextBoxBase)txtT_ck_ds_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric24 = txtT_ck_ds_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric24).Size = size;
		txtT_ck_ds_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_ck_ds_nt).TabIndex = 1;
		((TextBox)txtT_ck_ds_nt).Text = "0";
		((TextBox)txtT_ck_ds_nt).TextAlign = (HorizontalAlignment)1;
		txtT_ck_ds_nt.Value = 0.0;
		((Control)Label7).Anchor = (AnchorStyles)6;
		Label7.AutoSize = true;
		((Control)Label7).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label7.ImeMode = (ImeMode)0;
		Label label = Label7;
		location = new Point(287, 410);
		((Control)label).Location = location;
		((Control)Label7).Name = "Label7";
		Label label2 = Label7;
		size = new Size(101, 13);
		((Control)label2).Size = size;
		((Control)Label7).TabIndex = 279;
		Label7.Text = "Chiết khấu hóa đơn";
		Label7.TextAlign = (ContentAlignment)16;
		((Control)txtT_So_luong).Anchor = (AnchorStyles)6;
		txtT_So_luong.DecimalSymbol = ".";
		((Control)txtT_So_luong).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric25 = txtT_So_luong;
		location = new Point(399, 363);
		((Control)asTextNumeric25).Location = location;
		txtT_So_luong.Mask = "### ### ### ###";
		((Control)txtT_So_luong).Name = "txtT_So_luong";
		((TextBoxBase)txtT_So_luong).ReadOnly = true;
		AsTextNumeric asTextNumeric26 = txtT_So_luong;
		size = new Size(100, 20);
		((Control)asTextNumeric26).Size = size;
		txtT_So_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((Control)txtT_So_luong).TabIndex = 257;
		((Control)txtT_So_luong).TabStop = false;
		((TextBox)txtT_So_luong).Text = "0";
		((TextBox)txtT_So_luong).TextAlign = (HorizontalAlignment)1;
		txtT_So_luong.Value = 0.0;
		((ButtonBase)chkSua_thue).AutoSize = true;
		chkSua_thue.Checked = false;
		((Control)chkSua_thue).Enabled = false;
		AsCheckBox asCheckBox = chkSua_thue;
		location = new Point(69, 484);
		((Control)asCheckBox).Location = location;
		((Control)chkSua_thue).Name = "chkSua_thue";
		AsCheckBox asCheckBox2 = chkSua_thue;
		size = new Size(69, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkSua_thue).TabIndex = 7;
		((Control)chkSua_thue).TabStop = false;
		((ButtonBase)chkSua_thue).Text = "Sửa thuế";
		chkSua_thue.TextValue = "0";
		((ButtonBase)chkSua_thue).UseVisualStyleBackColor = true;
		((Control)chkSua_thue).Visible = false;
		((ButtonBase)chkSua_ck).AutoSize = true;
		chkSua_ck.Checked = false;
		((Control)chkSua_ck).Enabled = false;
		AsCheckBox asCheckBox3 = chkSua_ck;
		location = new Point(180, 474);
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
		((ButtonBase)chkSua_tien).AutoSize = true;
		chkSua_tien.Checked = false;
		((Control)chkSua_tien).Enabled = false;
		AsCheckBox asCheckBox5 = chkSua_tien;
		location = new Point(174, 497);
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
		((DataGridView)adgvDetail).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[21]
		{
			dgvcMa_vt,
			(DataGridViewColumn)dgvcTen_vt,
			(DataGridViewColumn)dgvcDvt,
			dgvcMa_kho,
			dgvcMa_Vitri,
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
			(DataGridViewColumn)dgvcKhuyen_mai,
			dgvcMa_lo,
			dgvcMa_Bp,
			dgvcMa_NvKd
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
		size = new Size(695, 166);
		((Control)asInputDGV2).Size = size;
		((Control)adgvDetail).TabIndex = 1;
		dgvcMa_vt.AutoFill = true;
		dgvcMa_vt.AutoLookup = true;
		dgvcMa_vt.AutoValid = true;
		((DataGridViewColumn)dgvcMa_vt).DataPropertyName = "ma_vt";
		val4.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_vt).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcMa_vt).HeaderText = "Mã hàng";
		dgvcMa_vt.LookupCodeName = "MA_VT";
		dgvcMa_vt.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_vt).Name = "dgvcMa_vt";
		dgvcMa_vt.ReceiverValidFieldList = "ten_vt,dvt,tk_vt,tk_gv,tk_dt,tk_ck,tk_tl,tk_km,ton_kho,gia_ton,ma_thue";
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
		((DataGridViewColumn)dgvcDvt).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcDvt).Width = 49;
		dgvcMa_kho.AutoFill = true;
		dgvcMa_kho.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_kho).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_kho.AutoValid = true;
		((DataGridViewColumn)dgvcMa_kho).DataPropertyName = "ma_kho";
		val5.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_kho).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcMa_kho).HeaderText = "Kho";
		dgvcMa_kho.LookupCodeName = "MA_KHO";
		dgvcMa_kho.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_kho).Name = "dgvcMa_kho";
		dgvcMa_kho.ReceiverValidFieldList = "ten_kho";
		dgvcMa_kho.SD = true;
		dgvcMa_kho.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_kho.ValidReturnFieldList = "ten_kho";
		((DataGridViewColumn)dgvcMa_kho).Width = 32;
		dgvcMa_Vitri.AutoFill = true;
		dgvcMa_Vitri.AutoLookup = true;
		dgvcMa_Vitri.AutoValid = true;
		((DataGridViewColumn)dgvcMa_Vitri).DataPropertyName = "ma_vitri";
		val6.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_Vitri).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcMa_Vitri).HeaderText = "Vị trí";
		dgvcMa_Vitri.LookupCodeName = "MA_VITRI";
		dgvcMa_Vitri.LookupWhereCondition = "ma_kho = '[ma_kho]'";
		((DataGridViewColumn)dgvcMa_Vitri).Name = "dgvcMa_Vitri";
		dgvcMa_Vitri.ReceiverValidFieldList = "ten_vitri";
		dgvcMa_Vitri.SD = true;
		dgvcMa_Vitri.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_Vitri.ValidReturnFieldList = "ten_vitri";
		((DataGridViewColumn)dgvcMa_Vitri).Width = 60;
		((DataGridViewColumn)dgvcTon).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcTon).DataPropertyName = "ton";
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTon).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcTon).HeaderText = "Tồn";
		dgvcTon.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTon).Name = "dgvcTon";
		((DataGridViewColumn)dgvcTon).ReadOnly = true;
		dgvcTon.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTon).Width = 32;
		((DataGridViewColumn)dgvcSo_luong).DataPropertyName = "so_luong";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcSo_luong).HeaderText = "Số lượng";
		dgvcSo_luong.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).Name = "dgvcSo_luong";
		dgvcSo_luong.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSo_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcSo_luong).Width = 70;
		((DataGridViewColumn)dgvcGia_nt2).DataPropertyName = "gia_nt2";
		val9.Alignment = (DataGridViewContentAlignment)64;
		val9.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt2).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcGia_nt2).HeaderText = "Giá";
		dgvcGia_nt2.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt2).Name = "dgvcGia_nt2";
		dgvcGia_nt2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia_nt2.SpecialType = Commons.NumericSpecialType.FCPrice;
		((DataGridViewColumn)dgvcGia_nt2).Width = 80;
		((DataGridViewColumn)dgvcTien_nt2).DataPropertyName = "tien_nt2";
		val10.Alignment = (DataGridViewContentAlignment)64;
		val10.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcTien_nt2).HeaderText = "Tiền bán";
		dgvcTien_nt2.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt2).Name = "dgvcTien_nt2";
		((DataGridViewColumn)dgvcTien_nt2).ReadOnly = true;
		dgvcTien_nt2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt2.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt2).Width = 90;
		((DataGridViewColumn)dgvcTl_ck).DataPropertyName = "tl_ck";
		val11.Alignment = (DataGridViewContentAlignment)64;
		val11.Format = "### ### ###.##";
		((DataGridViewColumn)dgvcTl_ck).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcTl_ck).HeaderText = "% CK";
		dgvcTl_ck.Mask = "### ### ###.##";
		((DataGridViewColumn)dgvcTl_ck).Name = "dgvcTl_ck";
		dgvcTl_ck.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTl_ck).Width = 40;
		((DataGridViewColumn)dgvcTien_ck_nt).DataPropertyName = "tien_ck_nt";
		val12.Alignment = (DataGridViewContentAlignment)64;
		val12.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ck_nt).DefaultCellStyle = val12;
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
		val13.BackColor = SystemColors.Window;
		val13.Format = "##.##";
		((DataGridViewColumn)dgvcTs_gtgt).DefaultCellStyle = val13;
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
		val14.Alignment = (DataGridViewContentAlignment)64;
		val14.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).DefaultCellStyle = val14;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = "VAT";
		dgvcThue_gtgt_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).Name = "dgvcThue_gtgt_nt";
		((DataGridViewColumn)dgvcThue_gtgt_nt).ReadOnly = true;
		dgvcThue_gtgt_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_gtgt_nt).Width = 80;
		((DataGridViewColumn)dgvcGia2).DataPropertyName = "gia2";
		val15.Alignment = (DataGridViewContentAlignment)64;
		val15.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcGia2).DefaultCellStyle = val15;
		((DataGridViewColumn)dgvcGia2).HeaderText = "Giá VND";
		dgvcGia2.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcGia2).Name = "dgvcGia2";
		((DataGridViewColumn)dgvcGia2).ReadOnly = true;
		dgvcGia2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia2.SpecialType = Commons.NumericSpecialType.ACPrice;
		((DataGridViewColumn)dgvcGia2).Width = 85;
		((DataGridViewColumn)dgvcTien2).DataPropertyName = "tien2";
		val16.Alignment = (DataGridViewContentAlignment)64;
		val16.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcTien2).DefaultCellStyle = val16;
		((DataGridViewColumn)dgvcTien2).HeaderText = "T. bán VND";
		dgvcTien2.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcTien2).Name = "dgvcTien2";
		((DataGridViewColumn)dgvcTien2).ReadOnly = true;
		dgvcTien2.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien2.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien2).Width = 90;
		((DataGridViewColumn)dgvcTien_ck).DataPropertyName = "tien_ck";
		val17.Alignment = (DataGridViewContentAlignment)64;
		val17.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcTien_ck).DefaultCellStyle = val17;
		((DataGridViewColumn)dgvcTien_ck).HeaderText = "C. khấu VND";
		dgvcTien_ck.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcTien_ck).Name = "dgvcTien_ck";
		((DataGridViewColumn)dgvcTien_ck).ReadOnly = true;
		dgvcTien_ck.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ck.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_ck).Width = 90;
		((DataGridViewColumn)dgvcThue_gtgt).DataPropertyName = "thue_gtgt";
		val18.Alignment = (DataGridViewContentAlignment)64;
		val18.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcThue_gtgt).DefaultCellStyle = val18;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = "VAT VND";
		dgvcThue_gtgt.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcThue_gtgt).Name = "dgvcThue_gtgt";
		((DataGridViewColumn)dgvcThue_gtgt).ReadOnly = true;
		dgvcThue_gtgt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_gtgt).Width = 80;
		((DataGridViewColumn)dgvcKhuyen_mai).DataPropertyName = "khuyen_mai";
		((DataGridViewColumn)dgvcKhuyen_mai).HeaderText = "KM";
		((DataGridViewColumn)dgvcKhuyen_mai).Name = "dgvcKhuyen_mai";
		((DataGridViewColumn)dgvcKhuyen_mai).Visible = false;
		((DataGridViewColumn)dgvcKhuyen_mai).Width = 30;
		dgvcMa_lo.AutoFill = true;
		dgvcMa_lo.AutoLookup = true;
		dgvcMa_lo.AutoValid = true;
		((DataGridViewColumn)dgvcMa_lo).DataPropertyName = "ma_lo";
		val19.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_lo).DefaultCellStyle = val19;
		((DataGridViewColumn)dgvcMa_lo).HeaderText = "Lô";
		dgvcMa_lo.LookupCodeName = "MA_LO";
		dgvcMa_lo.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_lo).Name = "dgvcMa_lo";
		dgvcMa_lo.ReceiverValidFieldList = "ten_lo";
		dgvcMa_lo.SD = true;
		dgvcMa_lo.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_lo).ToolTipText = "Mã lô sản xuất";
		dgvcMa_lo.ValidReturnFieldList = "ten_lo";
		((DataGridViewColumn)dgvcMa_lo).Width = 70;
		dgvcMa_Bp.AutoFill = true;
		dgvcMa_Bp.AutoLookup = true;
		dgvcMa_Bp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_Bp).DataPropertyName = "ma_bp";
		val20.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_Bp).DefaultCellStyle = val20;
		((DataGridViewColumn)dgvcMa_Bp).HeaderText = "Bộ phận";
		dgvcMa_Bp.LookupCodeName = "MA_BP";
		dgvcMa_Bp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_Bp).Name = "dgvcMa_Bp";
		dgvcMa_Bp.ReceiverValidFieldList = "Ten_Bp";
		dgvcMa_Bp.SD = true;
		dgvcMa_Bp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_Bp.ValidReturnFieldList = "Ten_Bp";
		((DataGridViewColumn)dgvcMa_Bp).Width = 60;
		dgvcMa_NvKd.AutoFill = true;
		dgvcMa_NvKd.AutoLookup = true;
		dgvcMa_NvKd.AutoValid = true;
		((DataGridViewColumn)dgvcMa_NvKd).DataPropertyName = "ma_nvkd";
		val21.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_NvKd).DefaultCellStyle = val21;
		((DataGridViewColumn)dgvcMa_NvKd).HeaderText = "NVKD";
		dgvcMa_NvKd.LookupCodeName = "MA_NVKD";
		dgvcMa_NvKd.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_NvKd).Name = "dgvcMa_NvKd";
		dgvcMa_NvKd.ReceiverValidFieldList = "ten_nvkd";
		dgvcMa_NvKd.SD = true;
		dgvcMa_NvKd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_NvKd.ValidReturnFieldList = "ten_nvkd";
		((DataGridViewColumn)dgvcMa_NvKd).Width = 60;
		lblTrang_thai.AutoSize = true;
		lblTrang_thai.ImeMode = (ImeMode)0;
		Label obj43 = lblTrang_thai;
		location = new Point(513, 120);
		((Control)obj43).Location = location;
		((Control)lblTrang_thai).Name = "lblTrang_thai";
		Label obj44 = lblTrang_thai;
		size = new Size(55, 13);
		((Control)obj44).Size = size;
		((Control)lblTrang_thai).TabIndex = 256;
		lblTrang_thai.Text = "Trạng thái";
		((ComboBox)cboTrang_thai).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboTrang_thai).Enabled = false;
		((ListControl)cboTrang_thai).FormattingEnabled = true;
		AsComboBoxTT asComboBoxTT = cboTrang_thai;
		location = new Point(577, 117);
		((Control)asComboBoxTT).Location = location;
		cboTrang_thai.Ma_Ct = null;
		((Control)cboTrang_thai).Name = "cboTrang_thai";
		AsComboBoxTT asComboBoxTT2 = cboTrang_thai;
		size = new Size(119, 21);
		((Control)asComboBoxTT2).Size = size;
		((Control)cboTrang_thai).TabIndex = 13;
		cboTrang_thai.Trang_Thai = "";
		txtDu13.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric27 = txtDu13;
		location = new Point(386, 128);
		((Control)asTextNumeric27).Location = location;
		txtDu13.Mask = "### ### ### ###";
		((Control)txtDu13).Name = "txtDu13";
		((TextBoxBase)txtDu13).ReadOnly = true;
		AsTextNumeric asTextNumeric28 = txtDu13;
		size = new Size(111, 20);
		((Control)asTextNumeric28).Size = size;
		((Control)txtDu13).TabIndex = 7;
		((Control)txtDu13).TabStop = false;
		((TextBox)txtDu13).Text = "0";
		((TextBox)txtDu13).TextAlign = (HorizontalAlignment)1;
		txtDu13.Value = 0.0;
		Label14.AutoSize = true;
		Label14.ImeMode = (ImeMode)0;
		Label label3 = Label14;
		location = new Point(312, 132);
		((Control)label3).Location = location;
		((Control)Label14).Name = "Label14";
		Label label4 = Label14;
		size = new Size(64, 13);
		((Control)label4).Size = size;
		((Control)Label14).TabIndex = 259;
		Label14.Text = "Dư hiện thời";
		txtGh_no.DecimalSymbol = ".";
		((Control)txtGh_no).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric29 = txtGh_no;
		location = new Point(94, 128);
		((Control)asTextNumeric29).Location = location;
		txtGh_no.Mask = "### ### ### ###";
		((Control)txtGh_no).Name = "txtGh_no";
		((TextBoxBase)txtGh_no).ReadOnly = true;
		AsTextNumeric asTextNumeric30 = txtGh_no;
		size = new Size(100, 20);
		((Control)asTextNumeric30).Size = size;
		txtGh_no.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtGh_no).TabIndex = 6;
		((Control)txtGh_no).TabStop = false;
		((TextBox)txtGh_no).Text = "0";
		((TextBox)txtGh_no).TextAlign = (HorizontalAlignment)1;
		txtGh_no.Value = 0.0;
		Label4.AutoSize = true;
		Label4.ImeMode = (ImeMode)0;
		Label label5 = Label4;
		location = new Point(6, 132);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		Label label6 = Label4;
		size = new Size(61, 13);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 266;
		Label4.Text = "Giới hạn nợ";
		lblMa_so_thue.AutoSize = true;
		lblMa_so_thue.ImeMode = (ImeMode)0;
		Label obj45 = lblMa_so_thue;
		location = new Point(303, 63);
		((Control)obj45).Location = location;
		((Control)lblMa_so_thue).Name = "lblMa_so_thue";
		((Control)lblMa_so_thue).RightToLeft = (RightToLeft)1;
		Label obj46 = lblMa_so_thue;
		size = new Size(60, 13);
		((Control)obj46).Size = size;
		((Control)lblMa_so_thue).TabIndex = 265;
		lblMa_so_thue.Text = "Mã số thuế";
		lblMa_so_thue.TextAlign = (ContentAlignment)16;
		TextBox obj47 = txtMa_so_thue;
		location = new Point(369, 59);
		((Control)obj47).Location = location;
		((Control)txtMa_so_thue).Name = "txtMa_so_thue";
		TextBox obj48 = txtMa_so_thue;
		size = new Size(128, 20);
		((Control)obj48).Size = size;
		((Control)txtMa_so_thue).TabIndex = 3;
		lblDia_chi.AutoSize = true;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj49 = lblDia_chi;
		location = new Point(6, 40);
		((Control)obj49).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj50 = lblDia_chi;
		size = new Size(40, 13);
		((Control)obj50).Size = size;
		((Control)lblDia_chi).TabIndex = 264;
		lblDia_chi.Text = "Địa chỉ";
		TextBox obj51 = txtDia_chi_vat;
		location = new Point(94, 36);
		((Control)obj51).Location = location;
		((Control)txtDia_chi_vat).Name = "txtDia_chi_vat";
		TextBox obj52 = txtDia_chi_vat;
		size = new Size(403, 20);
		((Control)obj52).Size = size;
		((Control)txtDia_chi_vat).TabIndex = 1;
		txtMa_Httt.AutoLookup = true;
		txtMa_Httt.AutoValid = true;
		((TextBoxBase)txtMa_Httt).BackColor = SystemColors.Info;
		((TextBox)txtMa_Httt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_Httt;
		location = new Point(94, 105);
		((Control)asTextBox3).Location = location;
		txtMa_Httt.LookupCodeName = "MA_HTTT";
		txtMa_Httt.LookupWhereCondition = "moduleid='SO'";
		((Control)txtMa_Httt).Name = "txtMa_Httt";
		txtMa_Httt.NameControl = lblTen_Httt;
		txtMa_Httt.SD = true;
		AsTextBox asTextBox4 = txtMa_Httt;
		size = new Size(75, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_Httt).TabIndex = 5;
		txtMa_Httt.UseAutoCompleteSource = true;
		txtMa_Httt.ValidReturnFieldList = "ten_httt,tk,tk_thue_gtgt_ban,tk_ck";
		((Control)lblTen_Httt).Enabled = false;
		lblTen_Httt.ImeMode = (ImeMode)0;
		Label obj53 = lblTen_Httt;
		location = new Point(175, 109);
		((Control)obj53).Location = location;
		((Control)lblTen_Httt).Name = "lblTen_Httt";
		Label obj54 = lblTen_Httt;
		size = new Size(322, 13);
		((Control)obj54).Size = size;
		((Control)lblTen_Httt).TabIndex = 269;
		lblTen_Httt.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Httt).Visible = false;
		Label6.AutoSize = true;
		Label6.ImeMode = (ImeMode)0;
		Label label7 = Label6;
		location = new Point(6, 109);
		((Control)label7).Location = location;
		((Control)Label6).Name = "Label6";
		Label label8 = Label6;
		size = new Size(76, 13);
		((Control)label8).Size = size;
		((Control)Label6).TabIndex = 268;
		Label6.Text = "Mã thanh toán";
		((Control)chkCk_st).Anchor = (AnchorStyles)6;
		((ButtonBase)chkCk_st).AutoSize = true;
		chkCk_st.Checked = false;
		AsCheckBox asCheckBox7 = chkCk_st;
		location = new Point(4, 365);
		((Control)asCheckBox7).Location = location;
		((Control)chkCk_st).Name = "chkCk_st";
		AsCheckBox asCheckBox8 = chkCk_st;
		size = new Size(121, 17);
		((Control)asCheckBox8).Size = size;
		((Control)chkCk_st).TabIndex = 2;
		((Control)chkCk_st).TabStop = false;
		((ButtonBase)chkCk_st).Text = "Chiết khấu sau thuế";
		chkCk_st.TextValue = "0";
		((ButtonBase)chkCk_st).UseVisualStyleBackColor = true;
		((Control)chkGia_st).Anchor = (AnchorStyles)6;
		((ButtonBase)chkGia_st).AutoSize = true;
		chkGia_st.Checked = false;
		AsCheckBox asCheckBox9 = chkGia_st;
		location = new Point(4, 388);
		((Control)asCheckBox9).Location = location;
		((Control)chkGia_st).Name = "chkGia_st";
		AsCheckBox asCheckBox10 = chkGia_st;
		size = new Size(86, 17);
		((Control)asCheckBox10).Size = size;
		((Control)chkGia_st).TabIndex = 3;
		((Control)chkGia_st).TabStop = false;
		((ButtonBase)chkGia_st).Text = "Giá sau thuế";
		chkGia_st.TextValue = "0";
		((ButtonBase)chkGia_st).UseVisualStyleBackColor = true;
		size = new Size(712, 525);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtTl_ck_ds);
		((Control)this).Controls.Add((Control)(object)chkGia_st);
		((Control)this).Controls.Add((Control)(object)txtT_ck_ds);
		((Control)this).Controls.Add((Control)(object)chkCk_st);
		((Control)this).Controls.Add((Control)(object)txtT_ck_ds_nt);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)txtT_So_luong);
		((Control)this).Controls.Add((Control)(object)txtT_tt);
		((Control)this).Controls.Add((Control)(object)txtT_Tien_nt2);
		((Control)this).Controls.Add((Control)(object)txtT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_thue_nt);
		((Control)this).Controls.Add((Control)(object)lblT_Tt);
		((Control)this).Controls.Add((Control)(object)txtT_ck);
		((Control)this).Controls.Add((Control)(object)lblT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_ck_nt);
		((Control)this).Controls.Add((Control)(object)txtT_Tien2);
		((Control)this).Controls.Add((Control)(object)lblTong);
		((Control)this).Controls.Add((Control)(object)lblT_ck);
		((Control)this).Controls.Add((Control)(object)chkSua_ck);
		((Control)this).Controls.Add((Control)(object)txtT_tt_nt);
		((Control)this).Controls.Add((Control)(object)chkSua_thue);
		((Control)this).Controls.Add((Control)(object)chkSua_tien);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmSoVchSO1";
		((Form)this).Text = "frmSoVchSO1";
		((Control)this).Controls.SetChildIndex((Control)(object)chkSua_tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkSua_thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkSua_ck, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_ck, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTong, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien2, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_thue_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien_nt2, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_So_luong, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck_ds_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkCk_st, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_ck_ds, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkGia_st, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtTl_ck_ds, 0);
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
		if ((base.ActionMode != Commons.ApplicationMode.VIEW_MODE && e.ValidatedRow != null && !IsValidateCalledFromValidData) || 1 == 0)
		{
			CurrentPHRow["Tk_pt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			CurrentPHRow["Tk_thue"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_ban"]), isNum: false));
			CurrentPHRow["Tk_ck_ds"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_ck"]), isNum: false));
		}
	}

	private void txtTy_gia_Validated(object sender, EventArgs e)
	{
		if ((!base.IsLoading && base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !IsValidateCalledFromValidData) || 1 == 0)
		{
			V_Ty_Gia();
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia2).Name, false) == 0)
			{
				V_Gia2(oDv);
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kho).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["ten_kho"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_lo).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["ten_lo"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_Vitri).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["ten_vitri"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_Bp).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["ten_bp"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_NvKd).Name, false) == 0)
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

	private void adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged(object sender, SetDependentFieldsWhenCellValueChangedEventArgs e)
	{
		if ((!base.MyVoucherInfo.ct_carry_field_list.ToUpper().Contains("MA_KHO") || ((DataGridViewCellEventArgs)e).RowIndex <= 0) && 0 == 0 && ((e.ValidatedRow != null && ((DataGridView)adgvDetail).Columns[((DataGridViewCellEventArgs)e).ColumnIndex].Name.Equals(((DataGridViewColumn)dgvcMa_vt).Name) && dgvcMa_vt.ValidReturnFieldList.Contains("ma_kho") && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_kho"]), isNum: false), (object)"", false)) ? true : false))
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
		if ((base.IsLoading || base.ActionMode == Commons.ApplicationMode.VIEW_MODE || IsValidateCalledFromValidData) ? true : false)
		{
			return;
		}
		Calc_Ck_ds();
		foreach (DataRowView item in base.CT1Voucher)
		{
			Calc_ChietKhau(item);
			Calc_Thue_gtgt(item);
			Calc_ThanhToan(item);
		}
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
			oDv["Gia_Nt2"] = SOCommon.Get_GiaBan(((TextBox)txtMa_Kh).Text.Trim(), Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_vt"]), isNum: false)), Conversions.ToDate(cboMa_NT.MA_NT));
			if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["so_luong"]), isNum: true), (object)0, false))
			{
				Calc_TienHang(oDv);
			}
			double arGiamGia = 0.0;
			string arTl = "1";
			SOCommon.Get_GiaGiamGia(((TextBox)txtMa_Kh).Text.Trim(), Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_vt"]), isNum: false)), cboMa_NT.MA_NT, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)), ref arTl, ref arGiamGia, DateTime.MinValue);
			if (Operators.CompareString(arTl, "1", false) == 0)
			{
				oDv["Tl_Ck"] = arGiamGia;
				Calc_ChietKhau(oDv);
			}
			else
			{
				oDv["Tien_Ck_Nt"] = arGiamGia;
				oDv["Tl_Ck"] = 0;
				if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
				{
					Type? typeFromHandle = typeof(Math);
					object[] array = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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
				else
				{
					Type? typeFromHandle2 = typeof(Math);
					object[] array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_Nt"]), isNum: true)),
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
			}
		}
		DataRow pDrw = null;
		if (Commons.ValidMa(ref pDrw, "MA_THUE", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_thue"]), isNum: false)), "", "ts_gtgt", pSd: true))
		{
			oDv["ts_gtgt"] = RuntimeHelpers.GetObjectValue(pDrw["ts_gtgt"]);
		}
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		ReCalcTonKhoTucThoi(oDv);
		UpdateList();
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
		Calc_TienHang(oDv);
		Calc_ChietKhau(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		Calc_So_luong_qd(oDv);
		UpdateList();
	}

	private void V_Gia_Nt2(DataRowView oDv)
	{
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
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
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
		Calc_ChietKhau(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Tien2(DataRowView oDv)
	{
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
		if (Conversions.ToBoolean(Operators.AndObject((object)(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0), Operators.CompareObjectEqual(txtTy_gia.Value, (object)1, false))))
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
		else if (Conversions.ToBoolean(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true))))
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
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck"]), isNum: true))), (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck"]), isNum: true))), (object)100),
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
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Thue_gtgt(DataRowView oDv)
	{
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void Calc_ChietKhau(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[2]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt2"]), isNum: true)), (object)100),
				num
			};
			object[] array2 = array;
			bool[] array3 = new bool[2] { false, true };
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
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_Nt"]), isNum: true)),
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
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_Nt"]), isNum: true), txtTy_gia.Value),
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
		object[] array = new object[2]
		{
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_Nt"]), isNum: true))), (object)100),
			num
		};
		object[] array2 = array;
		bool[] array3 = new bool[2] { false, true };
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
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck"]), isNum: true))), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck"]), isNum: true))), (object)100),
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

	private void Calc_ThanhToan(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[2]
		{
			Operators.AddObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck_Nt"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true)),
			num
		};
		object[] array2 = array;
		bool[] array3 = new bool[2] { false, true };
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
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.AddObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			array = new object[3]
			{
				Operators.AddObject(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Ck"]), isNum: true)), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)),
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
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tt_Nt"]), isNum: true), txtTy_gia.Value),
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
			object[] array = new object[2]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt2"]), isNum: true)),
				num
			};
			object[] array6 = array;
			bool[] array5 = new bool[2] { false, true };
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

	private void Calc_So_luong_qd(DataRowView oDv)
	{
		oDv["so_luong_qd"] = RuntimeHelpers.GetObjectValue(oDv["so_luong"]);
	}

	private void ReCalcTonKhoTucThoi(DataRowView odv)
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
					if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
					{
						Type? typeFromHandle5 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt2"]), isNum: true), txtTy_gia.Value),
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
						item["gia2"] = RuntimeHelpers.GetObjectValue(obj5);
					}
					if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia2"]), isNum: true)), (object)0, false))
					{
						Type? typeFromHandle6 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia2"]), isNum: true)),
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
						item["Tien2"] = RuntimeHelpers.GetObjectValue(obj6);
					}
					else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
					{
						Type? typeFromHandle7 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt2"]), isNum: true), txtTy_gia.Value),
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
						item["Tien2"] = RuntimeHelpers.GetObjectValue(obj7);
					}
					if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien2"]), isNum: true)), (object)0, false))
					{
						Type? typeFromHandle8 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien2"]), isNum: true)), (object)100),
							null,
							null
						};
						object[] array18 = array3;
						SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array18[1] = sIConfiguration.Round;
						array3[2] = MidpointRounding.AwayFromZero;
						object[] array = array3;
						object[] array19 = array;
						bool[] array5 = new bool[3] { false, true, false };
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
						object[] array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Ck_Nt"]), isNum: true), txtTy_gia.Value),
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
						item["Tien_Ck"] = RuntimeHelpers.GetObjectValue(obj9);
					}
					if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Ck"]), isNum: true))), (object)0, false))
					{
						Type? typeFromHandle10 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Ck"]), isNum: true))), (object)100),
							null,
							null
						};
						object[] array22 = array3;
						SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array22[1] = sIConfiguration.Round;
						array3[2] = MidpointRounding.AwayFromZero;
						object[] array = array3;
						object[] array23 = array;
						bool[] array5 = new bool[3] { false, true, false };
						object obj10 = NewLateBinding.LateGet((object)null, typeFromHandle10, "Round", array23, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						item["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj10);
					}
					else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
					{
						Type? typeFromHandle11 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_nt"]), isNum: true), txtTy_gia.Value),
							null,
							null
						};
						object[] array24 = array3;
						SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array24[1] = sIConfiguration.Round;
						array3[2] = MidpointRounding.AwayFromZero;
						object[] array = array3;
						object[] array25 = array;
						bool[] array5 = new bool[3] { false, true, false };
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

	private void ValidAdjustOver(int i, DataRowView odv, ref bool CmessGHDC, int Cmess)
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
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia2"]), isNum: true)),
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
			double num3 = Conversions.ToDouble(obj4);
			if ((num3 == 0.0 && Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false)) ? true : false)
			{
				Type? typeFromHandle5 = typeof(Math);
				array = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true), txtTy_gia.Value),
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
				num3 = Conversions.ToDouble(obj5);
			}
			Type? typeFromHandle6 = typeof(Math);
			array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tl_Ck"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien2"]), isNum: true)), (object)100),
				null,
				null
			};
			object[] array11 = array;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array11[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			array4 = array;
			object[] array12 = array4;
			array3 = new bool[3] { false, true, false };
			object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array12, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double num4 = Conversions.ToDouble(obj6);
			if ((num4 == 0.0 && Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false)) ? true : false)
			{
				Type? typeFromHandle7 = typeof(Math);
				array = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true), txtTy_gia.Value),
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
				num4 = Conversions.ToDouble(obj7);
			}
			Type? typeFromHandle8 = typeof(Math);
			array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true), Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck"]), isNum: true))), (object)100),
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
			double num5 = Conversions.ToDouble(obj8);
			if ((num5 == 0.0 && Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false)) ? true : false)
			{
				Type? typeFromHandle9 = typeof(Math);
				array = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Gtgt_nt"]), isNum: true), txtTy_gia.Value),
					null,
					null
				};
				object[] array17 = array;
				sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array17[1] = sIConfiguration.Round;
				array[2] = MidpointRounding.AwayFromZero;
				array4 = array;
				object[] array18 = array4;
				array3 = new bool[3] { false, true, false };
				object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle9, "Round", array18, (string[])null, (Type[])null, array3);
				if (array3[1])
				{
					sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
				}
				num5 = Conversions.ToDouble(obj9);
			}
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien2).Name, i], Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien2"]), isNum: true)), num3, gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_ck).Name, i], Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien_ck"]), isNum: true)), num4, gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcThue_gtgt).Name, i], Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Gtgt"]), isNum: true)), num5, gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_nt2).Name, i], dbA, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, Cmess, ref CmessGHDC);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_ck_nt).Name, i], dbA2, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, Cmess, ref CmessGHDC);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcThue_gtgt_nt).Name, i], dbA3, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, Cmess, ref CmessGHDC);
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
			object[] array19 = array4;
			bool[] array3 = new bool[3] { false, true, false };
			object obj10 = NewLateBinding.LateGet((object)null, typeFromHandle10, "Round", array19, (string[])null, (Type[])null, array3);
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
			object[] array20 = array4;
			array3 = new bool[3] { false, true, false };
			object obj11 = NewLateBinding.LateGet((object)null, typeFromHandle11, "Round", array20, (string[])null, (Type[])null, array3);
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
			object[] array21 = array4;
			array3 = new bool[3] { false, true, false };
			object obj12 = NewLateBinding.LateGet((object)null, typeFromHandle12, "Round", array21, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA6 = Conversions.ToDouble(obj12);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_nt2).Name, i], dbA4, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt2"]), isNum: true)), gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_ck_nt).Name, i], dbA5, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Ck_Nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
			RecipeABC(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcThue_gtgt_nt).Name, i], dbA6, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, Cmess, ref CmessGHDC);
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

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherBeforeLoadData();
		cboTrang_thai.Ma_Ct = MyVoucherInfo.voucher_code;
		foreach (DmTrangThai item in (IEnumerable)((ComboBox)cboTrang_thai).DataSource)
		{
			if (Conversions.ToBoolean(item.ngam_dinh))
			{
				base.PHTable.Columns["trang_thai"].DefaultValue = item.trang_thai;
				break;
			}
		}
		AddControl2ListOfDrivedControls((Control)(object)chkCk_st);
		AddControl2ListOfDrivedControls((Control)(object)chkGia_st);
		AddControl2ListOfDrivedControls((Control)(object)txtT_ck_ds_nt);
		AddControl2ListOfDrivedControls((Control)(object)txtT_ck_ds);
		AddControl2ListOfDrivedControls((Control)(object)txtTl_ck_ds);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Tien_nt2);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_thue_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_ck_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tt_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_ck_ds_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_ck_ds);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Tien_nt2);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_thue_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_ck_nt);
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
		((Control)txtT_Tien2).Visible = visible;
		((Control)txtT_ck).Visible = visible;
		((Control)txtT_ck_ds).Visible = visible;
		((Control)txtT_Thue).Visible = visible;
		((Control)txtT_tt).Visible = visible;
		((DataGridViewColumn)dgvcGia2).Visible = visible;
		((DataGridViewColumn)dgvcTien2).Visible = visible;
		((DataGridViewColumn)dgvcTien_ck).Visible = visible;
		((DataGridViewColumn)dgvcThue_gtgt).Visible = visible;
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
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		bool CmessGHDC = false;
		checked
		{
			if ((ChkEmtyTextBox((TextBox)(object)txtMa_Kh) && base.ValidData()) ? true : false)
			{
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
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Vt"]), isNum: false), (object)"", false))
					{
						((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_vt).Name, num2].ErrorText = Helper.GetMessContent(50062);
						((TabControl)AsTabControl).SelectedTab = tabDetail;
						((Control)adgvDetail).Select();
						((DataGridView)adgvDetail).CurrentCell = ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_vt).Name, num2];
						CMessageBox.Show(50062);
						return false;
					}
					if ((Operators.ConditionalCompareObjectEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Nt2"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true)), (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ton_kho"]), isNum: false), (object)"1", false)) ? true : false)
					{
						((TabControl)AsTabControl).SelectedTab = tabDetail;
						((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcSo_luong).Name, num2].ErrorText = Helper.GetMessContent(50037);
						flag = false;
					}
					if ((Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tien2"]), isNum: true), (object)0, false)) ? true : false)
					{
						CMessageBox.Show(50037);
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
		CreateDataBinding((Control)(object)txtMa_Httt, "ma_httt");
		CreateDataBinding((Control)(object)lblTen_Httt, "ten_httt");
		CreateDataBinding((Control)(object)txtNgay_Ct, "ngay_ct", "Value");
		CreateDataBinding((Control)(object)txtSo_Ct, "so_ct");
		CreateDataBinding((Control)(object)txtHan_Giao, "ngay_hh", "Value");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)txtT_Tien2, "t_tien2", "Value");
		CreateDataBinding((Control)(object)txtT_ck, "t_ck", "Value");
		CreateDataBinding((Control)(object)txtT_Thue, "t_thue", "Value");
		CreateDataBinding((Control)(object)txtT_tt, "t_tt", "Value");
		CreateDataBinding((Control)(object)txtT_Tien_nt2, "t_tien_nt2", "Value");
		CreateDataBinding((Control)(object)txtTl_ck_ds, "tl_ck_ds", "Value");
		CreateDataBinding((Control)(object)txtT_ck_ds, "t_ck_ds", "Value");
		CreateDataBinding((Control)(object)txtT_ck_ds_nt, "t_ck_ds_nt", "Value");
		CreateDataBinding((Control)(object)txtT_ck_nt, "t_ck_nt", "Value");
		CreateDataBinding((Control)(object)txtT_thue_nt, "t_thue_nt", "Value");
		CreateDataBinding((Control)(object)txtT_tt_nt, "t_tt_nt", "Value");
		CreateDataBinding((Control)(object)txtT_So_luong, "t_so_luong", "Value");
		CreateDataBinding((Control)(object)chkCk_st, "ck_st", "Checked");
		CreateDataBinding((Control)(object)chkGia_st, "gia_st", "Checked");
		CreateDataBinding((Control)(object)cboTrang_thai, "trang_thai", "Trang_Thai");
	}

	protected override void SetPHDefaultValues(DataRow drwPh)
	{
		drwPh["ngay_lct"] = RuntimeHelpers.GetObjectValue(drwPh["ngay_ct"]);
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

	protected override bool ChkStatusRight([Optional][DefaultParameterValue("")] ref string retMess)
	{
		return SOCommon.SOChkStatusRightSO1(Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentPHRow["stt_rec"]), isNum: false)), ref retMess);
	}
}
