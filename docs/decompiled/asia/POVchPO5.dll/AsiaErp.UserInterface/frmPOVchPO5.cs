using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.POUtilities;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmPOVchPO5 : frmVoucher
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

	[AccessedThroughProperty("adgvDetail")]
	private AsInputDGV _adgvDetail;

	[AccessedThroughProperty("cmdChon_Pn")]
	private Button _cmdChon_Pn;

	[AccessedThroughProperty("tabHach_toan")]
	private TabPage _tabHach_toan;

	[AccessedThroughProperty("lblTen_httt")]
	private Label _lblTen_httt;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtT_thue_Nt")]
	private AsTextNumeric _txtT_thue_Nt;

	[AccessedThroughProperty("txtT_Thue")]
	private AsTextNumeric _txtT_Thue;

	[AccessedThroughProperty("txtT_tt")]
	private AsTextNumeric _txtT_tt;

	[AccessedThroughProperty("txtT_tt_nt")]
	private AsTextNumeric _txtT_tt_nt;

	[AccessedThroughProperty("txtT_So_luong")]
	private AsTextNumeric _txtT_So_luong;

	[AccessedThroughProperty("lblT_Thue")]
	private Label _lblT_Thue;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

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

	[AccessedThroughProperty("txtT_tien_nt")]
	private AsTextNumeric _txtT_tien_nt;

	[AccessedThroughProperty("txtT_Tien")]
	private AsTextNumeric _txtT_Tien;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtSo_Seri")]
	private TextBox _txtSo_Seri;

	[AccessedThroughProperty("lblSo_seri")]
	private Label _lblSo_seri;

	[AccessedThroughProperty("txtMa_Httt")]
	private AsTextBox _txtMa_Httt;

	[AccessedThroughProperty("chkGia_dd")]
	private AsCheckBox _chkGia_dd;

	[AccessedThroughProperty("splcHoach_toan")]
	private SplitContainer _splcHoach_toan;

	[AccessedThroughProperty("lblMa_so_thue")]
	private Label _lblMa_so_thue;

	[AccessedThroughProperty("txtMa_so_thue")]
	private TextBox _txtMa_so_thue;

	[AccessedThroughProperty("lblDia_chi")]
	private Label _lblDia_chi;

	[AccessedThroughProperty("txtDia_chi")]
	private TextBox _txtDia_chi;

	[AccessedThroughProperty("dgvcTen_vt_ht")]
	private DataGridViewTextBoxColumn _dgvcTen_vt_ht;

	[AccessedThroughProperty("dgvcTien_nt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt_ht;

	[AccessedThroughProperty("dgvcTien_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_ht;

	[AccessedThroughProperty("dgvcTk_vt")]
	private DataGridViewAsTextBoxColumn _dgvcTk_vt;

	[AccessedThroughProperty("dgvcTk_pt")]
	private DataGridViewTextBoxColumn _dgvcTk_pt;

	[AccessedThroughProperty("dgvcMa_vt_ht")]
	private DataGridViewTextBoxColumn _dgvcMa_vt_ht;

	[AccessedThroughProperty("txtSo_seri_mhd")]
	private TextBox _txtSo_seri_mhd;

	[AccessedThroughProperty("lblSo_seri_mhd")]
	private Label _lblSo_seri_mhd;

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

	[AccessedThroughProperty("dgvcGia_nt")]
	private DataGridViewAsTextNumericColumn _dgvcGia_nt;

	[AccessedThroughProperty("dgvcTien_nt")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt;

	[AccessedThroughProperty("dgvcTs_gtgt")]
	private DataGridViewAsTextBoxColumn _dgvcTs_gtgt;

	[AccessedThroughProperty("dgvcThue_gtgt_nt")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt_nt;

	[AccessedThroughProperty("dgvcGia")]
	private DataGridViewAsTextNumericColumn _dgvcGia;

	[AccessedThroughProperty("dgvcTien")]
	private DataGridViewAsTextNumericColumn _dgvcTien;

	[AccessedThroughProperty("dgvcThue_gtgt")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt;

	[AccessedThroughProperty("dgvcSo_hd")]
	private DataGridViewTextBoxColumn _dgvcSo_hd;

	private string f_sMa_kh;

	private string f_sGia_header;

	private string f_sTien_header;

	private string f_sThue_header;

	private string f_sMa_Gd_Default;

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
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			AsInputDGV.SetDependentFieldsWhenCellValueChangedHandler obj = adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged;
			DataGridViewCellValidatingEventHandler val = new DataGridViewCellValidatingEventHandler(adgvDetail_CellValidating);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvDetail_CellEnter);
			DataGridViewCellEventHandler val3 = new DataGridViewCellEventHandler(adgvDetail_CellValueChanged);
			if (_adgvDetail != null)
			{
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged -= obj;
				((DataGridView)_adgvDetail).CellValidating -= val;
				((DataGridView)_adgvDetail).CellEnter -= val2;
				((DataGridView)_adgvDetail).CellValueChanged -= val3;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged += obj;
				((DataGridView)_adgvDetail).CellValidating += val;
				((DataGridView)_adgvDetail).CellEnter += val2;
				((DataGridView)_adgvDetail).CellValueChanged += val3;
			}
		}
	}

	internal virtual Button cmdChon_Pn
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdChon_Pn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdChon_Pn_Click;
			if (_cmdChon_Pn != null)
			{
				((Control)_cmdChon_Pn).Click -= eventHandler;
			}
			_cmdChon_Pn = value;
			if (_cmdChon_Pn != null)
			{
				((Control)_cmdChon_Pn).Click += eventHandler;
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
			EventHandler eventHandler = txtTk_thue_Validated;
			if (_txtTk_thue != null)
			{
				((Control)_txtTk_thue).Validated -= eventHandler;
			}
			_txtTk_thue = value;
			if (_txtTk_thue != null)
			{
				((Control)_txtTk_thue).Validated += eventHandler;
			}
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

	internal virtual SplitContainer splcHoach_toan
	{
		[DebuggerNonUserCode]
		get
		{
			return _splcHoach_toan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_splcHoach_toan = value;
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

	internal virtual DataGridViewTextBoxColumn dgvcTk_pt
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

	public frmPOVchPO5()
	{
		__ENCAddToList(this);
		f_sMa_kh = "";
		f_sGia_header = "Gia";
		f_sTien_header = "Tien";
		f_sThue_header = "VAT";
		f_sMa_Gd_Default = "1";
		InitializeComponent();
	}

	public frmPOVchPO5(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_sMa_kh = "";
		f_sGia_header = "Gia";
		f_sTien_header = "Tien";
		f_sThue_header = "VAT";
		f_sMa_Gd_Default = "1";
		InitializeComponent();
	}

	public frmPOVchPO5(string MenuID, string Stt_rec)
		: base(MenuID, Stt_rec)
	{
		__ENCAddToList(this);
		f_sMa_kh = "";
		f_sGia_header = "Gia";
		f_sTien_header = "Tien";
		f_sThue_header = "VAT";
		f_sMa_Gd_Default = "1";
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
		//IL_0031: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_005f: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
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
		//IL_1538: Unknown result type (might be due to invalid IL or missing references)
		//IL_1542: Expected O, but got Unknown
		//IL_1f3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_21be: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c8: Expected O, but got Unknown
		//IL_2956: Unknown result type (might be due to invalid IL or missing references)
		//IL_2960: Expected O, but got Unknown
		//IL_2a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a68: Expected O, but got Unknown
		//IL_2b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b70: Expected O, but got Unknown
		//IL_2c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c78: Expected O, but got Unknown
		//IL_2d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d80: Expected O, but got Unknown
		//IL_2e6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e77: Expected O, but got Unknown
		//IL_2f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f1c: Expected O, but got Unknown
		//IL_2fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fcf: Expected O, but got Unknown
		//IL_3089: Unknown result type (might be due to invalid IL or missing references)
		//IL_3093: Expected O, but got Unknown
		//IL_3191: Unknown result type (might be due to invalid IL or missing references)
		//IL_319b: Expected O, but got Unknown
		//IL_3288: Unknown result type (might be due to invalid IL or missing references)
		//IL_3292: Expected O, but got Unknown
		//IL_3921: Unknown result type (might be due to invalid IL or missing references)
		//IL_392b: Expected O, but got Unknown
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
		adgvDetail = new AsInputDGV();
		dgvcMa_vt = new DataGridViewAsTextBoxColumn();
		dgvcTen_vt = new DataGridViewTextBoxColumn();
		dgvcDvt = new DataGridViewTextBoxColumn();
		dgvcMa_kho = new DataGridViewAsTextBoxColumn();
		dgvcTon = new DataGridViewAsTextNumericColumn();
		dgvcSo_luong = new DataGridViewAsTextNumericColumn();
		dgvcGia_nt = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt = new DataGridViewAsTextNumericColumn();
		dgvcTs_gtgt = new DataGridViewAsTextBoxColumn();
		dgvcThue_gtgt_nt = new DataGridViewAsTextNumericColumn();
		dgvcGia = new DataGridViewAsTextNumericColumn();
		dgvcTien = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt = new DataGridViewAsTextNumericColumn();
		dgvcSo_hd = new DataGridViewTextBoxColumn();
		cmdChon_Pn = new Button();
		tabHach_toan = new TabPage();
		splcHoach_toan = new SplitContainer();
		adgvHach_toan = new AsInputDGV();
		dgvcTen_vt_ht = new DataGridViewTextBoxColumn();
		dgvcTien_nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_ht = new DataGridViewAsTextNumericColumn();
		dgvcTk_vt = new DataGridViewAsTextBoxColumn();
		dgvcTk_pt = new DataGridViewTextBoxColumn();
		dgvcMa_vt_ht = new DataGridViewTextBoxColumn();
		txtTk_thue = new AsTextBox();
		lblTk_pt = new Label();
		txtTk_pt = new AsTextBox();
		lblTk_thue = new Label();
		lblTen_httt = new Label();
		Label2 = new Label();
		txtT_thue_Nt = new AsTextNumeric();
		txtT_Thue = new AsTextNumeric();
		txtT_tt = new AsTextNumeric();
		txtT_tt_nt = new AsTextNumeric();
		txtT_So_luong = new AsTextNumeric();
		lblT_Thue = new Label();
		Label5 = new Label();
		Label8 = new Label();
		txtT_tien_nt = new AsTextNumeric();
		txtT_Tien = new AsTextNumeric();
		Label1 = new Label();
		txtSo_Seri = new TextBox();
		lblSo_seri = new Label();
		txtMa_Httt = new AsTextBox();
		chkGia_dd = new AsCheckBox();
		lblMa_so_thue = new Label();
		txtMa_so_thue = new TextBox();
		lblDia_chi = new Label();
		txtDia_chi = new TextBox();
		txtSo_seri_mhd = new TextBox();
		lblSo_seri_mhd = new Label();
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
		((Control)tabHach_toan).SuspendLayout();
		((Control)splcHoach_toan.Panel1).SuspendLayout();
		((Control)splcHoach_toan.Panel2).SuspendLayout();
		((Control)splcHoach_toan).SuspendLayout();
		((ISupportInitialize)adgvHach_toan).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = cmdAdd;
		Point location = new Point(3, 460);
		((Control)obj).Location = location;
		((Control)cmdAdd).TabIndex = 3;
		Button obj2 = cmdPrint;
		location = new Point(73, 460);
		((Control)obj2).Location = location;
		((Control)cmdPrint).TabIndex = 4;
		Button obj3 = cmdLast;
		location = new Point(737, 460);
		((Control)obj3).Location = location;
		((Control)cmdLast).TabIndex = 12;
		Button obj4 = cmdNext;
		location = new Point(712, 460);
		((Control)obj4).Location = location;
		((Control)cmdNext).TabIndex = 11;
		Button obj5 = cmdPrevious;
		location = new Point(687, 460);
		((Control)obj5).Location = location;
		((Control)cmdPrevious).TabIndex = 10;
		Button obj6 = cmdFirst;
		location = new Point(662, 460);
		((Control)obj6).Location = location;
		((Control)cmdFirst).TabIndex = 9;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(563, 83);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct;
		Size size = new Size(83, 13);
		((Control)obj8).Size = size;
		lblSo_Ct.Text = "Số ctừ/hóa đơn";
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		Label obj9 = lblNgay_Ct;
		location = new Point(563, 60);
		((Control)obj9).Location = location;
		Label obj10 = lblNgay_Ct;
		size = new Size(95, 13);
		((Control)obj10).Size = size;
		lblNgay_Ct.Text = "Ngày ctừ/hóa đơn";
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)5;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(670, 57);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay_Ct).TabIndex = 8;
		((Control)gbPH).Controls.Add((Control)(object)txtSo_seri_mhd);
		((Control)gbPH).Controls.Add((Control)(object)lblSo_seri_mhd);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)txtSo_Seri);
		((Control)gbPH).Controls.Add((Control)(object)lblSo_seri);
		((Control)gbPH).Controls.Add((Control)(object)lblDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_httt);
		((Control)gbPH).Controls.Add((Control)(object)txtDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Httt);
		((Control)gbPH).Controls.Add((Control)(object)Label2);
		((Control)gbPH).Controls.Add((Control)(object)cmdChon_Pn);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbPH).Controls.Add((Control)(object)txtTy_gia);
		((Control)gbPH).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Nt);
		((Control)gbPH).Controls.Add((Control)(object)lblNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbPH).Controls.Add((Control)(object)txtNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)lblDien_giai);
		((Control)gbPH).Controls.Add((Control)(object)txtNgay_lct);
		((Control)gbPH).Controls.Add((Control)(object)lblNgay_Lct);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Kh);
		gbPH.FlatStyle = (FlatStyle)0;
		GroupBox obj11 = gbPH;
		location = new Point(3, -3);
		((Control)obj11).Location = location;
		GroupBox obj12 = gbPH;
		size = new Size(757, 173);
		((Control)obj12).Size = size;
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTy_gia, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cmdChon_Pn, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_seri, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Seri, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_seri_mhd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_seri_mhd, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(581, 460);
		((Control)splitButton).Location = location;
		((Control)cmdSearch).TabIndex = 8;
		((Control)AsTabControl).Controls.Add((Control)(object)tabHach_toan);
		AsTabControl asTabControl = AsTabControl;
		location = new Point(1, 173);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(762, 211);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabHach_toan, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabOptFields, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabDetail, 0);
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj13 = tabDetail;
		size = new Size(754, 182);
		((Control)obj13).Size = size;
		TabPage obj14 = tabOptFields;
		size = new Size(754, 182);
		((Control)obj14).Size = size;
		Button obj15 = cmdCopy;
		location = new Point(283, 460);
		((Control)obj15).Location = location;
		((Control)cmdCopy).TabIndex = 7;
		Button obj16 = cmdDelete;
		location = new Point(213, 460);
		((Control)obj16).Location = location;
		((Control)cmdDelete).TabIndex = 6;
		Button obj17 = cmdEdit;
		location = new Point(143, 460);
		((Control)obj17).Location = location;
		((Control)cmdEdit).TabIndex = 5;
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		TextBox obj18 = txtSo_Ct;
		location = new Point(670, 79);
		((Control)obj18).Location = location;
		((Control)txtSo_Ct).TabIndex = 9;
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
		location = new Point(202, 17);
		((Control)obj19).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj20 = lblTen_Kh;
		size = new Size(339, 13);
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
		lblNguoi_Gd.AutoSize = true;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj23 = lblNguoi_Gd;
		location = new Point(9, 68);
		((Control)obj23).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj24 = lblNguoi_Gd;
		size = new Size(81, 13);
		((Control)obj24).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 143;
		lblNguoi_Gd.Text = "Người giao dịch";
		TextBox obj25 = txtDien_giai;
		location = new Point(117, 91);
		((Control)obj25).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj26 = txtDien_giai;
		size = new Size(424, 20);
		((Control)obj26).Size = size;
		((Control)txtDien_giai).TabIndex = 4;
		TextBox obj27 = txtNguoi_Gd;
		location = new Point(117, 65);
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
		location = new Point(670, 101);
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
		Label obj31 = lblNgay_Lct;
		location = new Point(563, 103);
		((Control)obj31).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj32 = lblNgay_Lct;
		size = new Size(49, 13);
		((Control)obj32).Size = size;
		((Control)lblNgay_Lct).TabIndex = 234;
		lblNgay_Lct.Text = "Ngày lập";
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(679, 123);
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
		location = new Point(629, 123);
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
		location = new Point(563, 127);
		((Control)obj33).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj34 = lblMa_Nt;
		size = new Size(36, 13);
		((Control)obj34).Size = size;
		((Control)lblMa_Nt).TabIndex = 237;
		lblMa_Nt.Text = "Tỷ giá";
		((DataGridView)adgvDetail).AllowUserToAddRows = false;
		((DataGridView)adgvDetail).AllowUserToDeleteRows = false;
		((DataGridView)adgvDetail).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvDetail).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvDetail).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[14]
		{
			dgvcMa_vt,
			(DataGridViewColumn)dgvcTen_vt,
			(DataGridViewColumn)dgvcDvt,
			dgvcMa_kho,
			dgvcTon,
			dgvcSo_luong,
			dgvcGia_nt,
			dgvcTien_nt,
			dgvcTs_gtgt,
			dgvcThue_gtgt_nt,
			dgvcGia,
			dgvcTien,
			dgvcThue_gtgt,
			(DataGridViewColumn)dgvcSo_hd
		});
		((Control)adgvDetail).Dock = (DockStyle)5;
		((DataGridView)adgvDetail).GridColor = SystemColors.Control;
		adgvDetail.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV = adgvDetail;
		location = new Point(3, 3);
		((Control)asInputDGV).Location = location;
		((Control)adgvDetail).Name = "adgvDetail";
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail).RowHeadersDefaultCellStyle = val;
		((DataGridView)adgvDetail).RowHeadersWidth = 35;
		((DataGridView)adgvDetail).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = adgvDetail;
		size = new Size(748, 176);
		((Control)asInputDGV2).Size = size;
		((Control)adgvDetail).TabIndex = 1;
		dgvcMa_vt.AutoFill = true;
		dgvcMa_vt.AutoLookup = true;
		dgvcMa_vt.AutoValid = true;
		((DataGridViewColumn)dgvcMa_vt).DataPropertyName = "ma_vt";
		val2.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_vt).DefaultCellStyle = val2;
		((DataGridViewColumn)dgvcMa_vt).HeaderText = "Mã hàng";
		dgvcMa_vt.LookupCodeName = "MA_VT";
		dgvcMa_vt.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_vt).Name = "dgvcMa_vt";
		dgvcMa_vt.ReceiverValidFieldList = "ten_vt,dvt,tk_vt,tk_gv,tk_dt,tk_ck,ton_kho,gia_ton,ma_thue,ma_kho";
		dgvcMa_vt.SD = true;
		dgvcMa_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_vt.ValidReturnFieldList = "ten_vt,dvt,tk_vt,tk_gv,tk_dt,tk_ck,ton_kho,gia_ton,ma_thue,ma_kho,ma_vitri";
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
		val3.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_kho).DefaultCellStyle = val3;
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
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTon).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcTon).HeaderText = "Tồn";
		dgvcTon.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTon).Name = "dgvcTon";
		((DataGridViewColumn)dgvcTon).ReadOnly = true;
		dgvcTon.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTon.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcTon).Width = 60;
		((DataGridViewColumn)dgvcSo_luong).DataPropertyName = "so_luong";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcSo_luong).HeaderText = "Số lượng";
		dgvcSo_luong.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).Name = "dgvcSo_luong";
		dgvcSo_luong.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSo_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcSo_luong).Width = 70;
		((DataGridViewColumn)dgvcGia_nt).DataPropertyName = "gia_nt";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcGia_nt).HeaderText = "Đơn giá";
		dgvcGia_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt).Name = "dgvcGia_nt";
		dgvcGia_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia_nt.SpecialType = Commons.NumericSpecialType.FCPrice;
		((DataGridViewColumn)dgvcGia_nt).Width = 85;
		((DataGridViewColumn)dgvcTien_nt).DataPropertyName = "tien_nt";
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcTien_nt).HeaderText = "Thành tiền";
		dgvcTien_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt).Name = "dgvcTien_nt";
		((DataGridViewColumn)dgvcTien_nt).ReadOnly = true;
		dgvcTien_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt).Width = 90;
		dgvcTs_gtgt.AutoFill = true;
		dgvcTs_gtgt.AutoLookup = true;
		dgvcTs_gtgt.AutoValid = true;
		((DataGridViewColumn)dgvcTs_gtgt).DataPropertyName = "ma_thue";
		val8.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTs_gtgt).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcTs_gtgt).HeaderText = "%VAT";
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
		val9.Alignment = (DataGridViewContentAlignment)64;
		val9.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = "VAT";
		dgvcThue_gtgt_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).Name = "dgvcThue_gtgt_nt";
		dgvcThue_gtgt_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_gtgt_nt).Width = 80;
		((DataGridViewColumn)dgvcGia).DataPropertyName = "gia";
		val10.Alignment = (DataGridViewContentAlignment)64;
		val10.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcGia).HeaderText = "Đơn giá VNĐ";
		dgvcGia.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia).Name = "dgvcGia";
		((DataGridViewColumn)dgvcGia).ReadOnly = true;
		dgvcGia.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia.SpecialType = Commons.NumericSpecialType.ACPrice;
		((DataGridViewColumn)dgvcGia).Width = 80;
		((DataGridViewColumn)dgvcTien).DataPropertyName = "tien";
		val11.Alignment = (DataGridViewContentAlignment)64;
		val11.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcTien).HeaderText = "Tiền VNĐ";
		dgvcTien.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien).Name = "dgvcTien";
		((DataGridViewColumn)dgvcTien).ReadOnly = true;
		dgvcTien.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien).Width = 90;
		((DataGridViewColumn)dgvcThue_gtgt).DataPropertyName = "thue_gtgt";
		val12.Alignment = (DataGridViewContentAlignment)64;
		val12.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = "VAT VND";
		dgvcThue_gtgt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt).Name = "dgvcThue_gtgt";
		dgvcThue_gtgt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_gtgt).Width = 80;
		((DataGridViewColumn)dgvcSo_hd).DataPropertyName = "so_hd";
		((DataGridViewColumn)dgvcSo_hd).HeaderText = "Số HĐ";
		((DataGridViewColumn)dgvcSo_hd).Name = "dgvcSo_hd";
		((DataGridViewColumn)dgvcSo_hd).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_hd).Resizable = (DataGridViewTriState)1;
		dgvcSo_hd.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcSo_hd).Width = 80;
		((ButtonBase)cmdChon_Pn).FlatStyle = (FlatStyle)1;
		Button obj35 = cmdChon_Pn;
		location = new Point(657, 145);
		((Control)obj35).Location = location;
		((Control)cmdChon_Pn).Name = "cmdChon_Pn";
		Button obj36 = cmdChon_Pn;
		size = new Size(91, 23);
		((Control)obj36).Size = size;
		((Control)cmdChon_Pn).TabIndex = 13;
		((ButtonBase)cmdChon_Pn).Text = "Chọ&n HĐ";
		tabHach_toan.BackColor = SystemColors.Control;
		((Control)tabHach_toan).Controls.Add((Control)(object)splcHoach_toan);
		TabPage obj37 = tabHach_toan;
		location = new Point(4, 25);
		obj37.Location = location;
		((Control)tabHach_toan).Name = "tabHach_toan";
		TabPage obj38 = tabHach_toan;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)obj38).Padding = padding;
		TabPage obj39 = tabHach_toan;
		size = new Size(687, 221);
		((Control)obj39).Size = size;
		tabHach_toan.TabIndex = 9;
		tabHach_toan.Text = "Hạch toá&n";
		splcHoach_toan.Dock = (DockStyle)5;
		splcHoach_toan.FixedPanel = (FixedPanel)2;
		SplitContainer obj40 = splcHoach_toan;
		location = new Point(3, 3);
		((Control)obj40).Location = location;
		((Control)splcHoach_toan).Name = "splcHoach_toan";
		splcHoach_toan.Orientation = (Orientation)0;
		((Control)splcHoach_toan.Panel1).Controls.Add((Control)(object)adgvHach_toan);
		((Control)splcHoach_toan.Panel2).Controls.Add((Control)(object)txtTk_thue);
		((Control)splcHoach_toan.Panel2).Controls.Add((Control)(object)lblTk_pt);
		((Control)splcHoach_toan.Panel2).Controls.Add((Control)(object)txtTk_pt);
		((Control)splcHoach_toan.Panel2).Controls.Add((Control)(object)lblTk_thue);
		SplitContainer obj41 = splcHoach_toan;
		size = new Size(681, 215);
		((Control)obj41).Size = size;
		splcHoach_toan.SplitterDistance = 186;
		((Control)splcHoach_toan).TabIndex = 0;
		((DataGridView)adgvHach_toan).AllowUserToAddRows = false;
		((DataGridView)adgvHach_toan).AllowUserToDeleteRows = false;
		((DataGridView)adgvHach_toan).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvHach_toan).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvHach_toan).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvHach_toan).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)dgvcTen_vt_ht,
			dgvcTien_nt_ht,
			dgvcTien_ht,
			dgvcTk_vt,
			(DataGridViewColumn)dgvcTk_pt,
			(DataGridViewColumn)dgvcMa_vt_ht
		});
		((Control)adgvHach_toan).Dock = (DockStyle)5;
		((DataGridView)adgvHach_toan).GridColor = SystemColors.Control;
		adgvHach_toan.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV3 = adgvHach_toan;
		location = new Point(0, 0);
		((Control)asInputDGV3).Location = location;
		((Control)adgvHach_toan).Name = "adgvHach_toan";
		val13.Alignment = (DataGridViewContentAlignment)32;
		val13.BackColor = SystemColors.Control;
		val13.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		val13.ForeColor = SystemColors.WindowText;
		val13.SelectionBackColor = SystemColors.Highlight;
		val13.SelectionForeColor = SystemColors.HighlightText;
		val13.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).RowHeadersDefaultCellStyle = val13;
		((DataGridView)adgvHach_toan).RowHeadersWidth = 35;
		((DataGridView)adgvHach_toan).RowTemplate.Height = 20;
		AsInputDGV asInputDGV4 = adgvHach_toan;
		size = new Size(681, 186);
		((Control)asInputDGV4).Size = size;
		((Control)adgvHach_toan).TabIndex = 1;
		((DataGridViewColumn)dgvcTen_vt_ht).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vt_ht).Frozen = true;
		((DataGridViewColumn)dgvcTen_vt_ht).HeaderText = "Tên vật tư";
		((DataGridViewColumn)dgvcTen_vt_ht).Name = "dgvcTen_vt_ht";
		((DataGridViewColumn)dgvcTen_vt_ht).ReadOnly = true;
		dgvcTen_vt_ht.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_vt_ht).Width = 200;
		((DataGridViewColumn)dgvcTien_nt_ht).DataPropertyName = "tien_nt";
		val14.Alignment = (DataGridViewContentAlignment)64;
		val14.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).DefaultCellStyle = val14;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = "Tổng tiền";
		dgvcTien_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).Name = "dgvcTien_nt_ht";
		((DataGridViewColumn)dgvcTien_nt_ht).ReadOnly = true;
		dgvcTien_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt_ht).Width = 95;
		((DataGridViewColumn)dgvcTien_ht).DataPropertyName = "tien";
		val15.Alignment = (DataGridViewContentAlignment)64;
		val15.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ht).DefaultCellStyle = val15;
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
		val16.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_vt).DefaultCellStyle = val16;
		((DataGridViewColumn)dgvcTk_vt).HeaderText = "Tk kho";
		dgvcTk_vt.LookupCodeName = "TK";
		dgvcTk_vt.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_vt).Name = "dgvcTk_vt";
		dgvcTk_vt.ReceiverValidFieldList = "ten_tk_vt";
		dgvcTk_vt.SD = true;
		dgvcTk_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_vt.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_vt).Width = 65;
		((DataGridViewColumn)dgvcTk_pt).DataPropertyName = "tk_pt";
		((DataGridViewColumn)dgvcTk_pt).HeaderText = "Tk nợ";
		((DataGridViewColumn)dgvcTk_pt).Name = "dgvcTk_pt";
		((DataGridViewColumn)dgvcTk_pt).Visible = false;
		((DataGridViewColumn)dgvcTk_pt).Width = 65;
		((DataGridViewColumn)dgvcMa_vt_ht).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcMa_vt_ht).DataPropertyName = "ma_vt";
		((DataGridViewColumn)dgvcMa_vt_ht).HeaderText = "Mã hàng";
		((DataGridViewColumn)dgvcMa_vt_ht).Name = "dgvcMa_vt_ht";
		((DataGridViewColumn)dgvcMa_vt_ht).ReadOnly = true;
		dgvcMa_vt_ht.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_vt_ht).Visible = false;
		txtTk_thue.AutoLookup = true;
		txtTk_thue.AutoValid = true;
		((TextBoxBase)txtTk_thue).BackColor = SystemColors.Info;
		((TextBox)txtTk_thue).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk_thue;
		location = new Point(359, 2);
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
		lblTk_pt.ImeMode = (ImeMode)0;
		Label obj42 = lblTk_pt;
		location = new Point(8, 5);
		((Control)obj42).Location = location;
		((Control)lblTk_pt).Name = "lblTk_pt";
		Label obj43 = lblTk_pt;
		size = new Size(121, 14);
		((Control)obj43).Size = size;
		((Control)lblTk_pt).TabIndex = 259;
		lblTk_pt.Text = "Tài khoản thanh toán";
		txtTk_pt.AutoLookup = true;
		txtTk_pt.AutoValid = true;
		((TextBoxBase)txtTk_pt).BackColor = SystemColors.Info;
		((TextBox)txtTk_pt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTk_pt;
		location = new Point(135, 2);
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
		lblTk_thue.AutoSize = true;
		lblTk_thue.ImeMode = (ImeMode)0;
		Label obj44 = lblTk_thue;
		location = new Point(274, 5);
		((Control)obj44).Location = location;
		((Control)lblTk_thue).Name = "lblTk_thue";
		Label obj45 = lblTk_thue;
		size = new Size(79, 13);
		((Control)obj45).Size = size;
		((Control)lblTk_thue).TabIndex = 260;
		lblTk_thue.Text = "Tài khoản thuế";
		lblTen_httt.ImeMode = (ImeMode)0;
		Label obj46 = lblTen_httt;
		location = new Point(198, 121);
		((Control)obj46).Location = location;
		((Control)lblTen_httt).Name = "lblTen_httt";
		Label obj47 = lblTen_httt;
		size = new Size(343, 13);
		((Control)obj47).Size = size;
		((Control)lblTen_httt).TabIndex = 257;
		lblTen_httt.TextAlign = (ContentAlignment)16;
		Label2.AutoSize = true;
		Label2.ImeMode = (ImeMode)0;
		Label label = Label2;
		location = new Point(9, 121);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(76, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 256;
		Label2.Text = "Mã thanh toán";
		((Control)txtT_thue_Nt).Anchor = (AnchorStyles)6;
		txtT_thue_Nt.DecimalSymbol = ".";
		((Control)txtT_thue_Nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtT_thue_Nt;
		location = new Point(548, 408);
		((Control)asTextNumeric3).Location = location;
		txtT_thue_Nt.Mask = "### ### ### ###.##";
		((Control)txtT_thue_Nt).Name = "txtT_thue_Nt";
		((TextBoxBase)txtT_thue_Nt).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtT_thue_Nt;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		txtT_thue_Nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_thue_Nt).TabIndex = 275;
		((Control)txtT_thue_Nt).TabStop = false;
		((TextBox)txtT_thue_Nt).Text = "0.00";
		((TextBox)txtT_thue_Nt).TextAlign = (HorizontalAlignment)1;
		txtT_thue_Nt.Value = 0.0;
		((Control)txtT_Thue).Anchor = (AnchorStyles)6;
		txtT_Thue.DecimalSymbol = ".";
		((Control)txtT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric5 = txtT_Thue;
		location = new Point(651, 408);
		((Control)asTextNumeric5).Location = location;
		txtT_Thue.Mask = "### ### ### ###";
		((Control)txtT_Thue).Name = "txtT_Thue";
		((TextBoxBase)txtT_Thue).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtT_Thue;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		txtT_Thue.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Thue).TabIndex = 273;
		((Control)txtT_Thue).TabStop = false;
		((TextBox)txtT_Thue).Text = "0";
		((TextBox)txtT_Thue).TextAlign = (HorizontalAlignment)1;
		txtT_Thue.Value = 0.0;
		((Control)txtT_tt).Anchor = (AnchorStyles)6;
		txtT_tt.DecimalSymbol = ".";
		((Control)txtT_tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric7 = txtT_tt;
		location = new Point(651, 430);
		((Control)asTextNumeric7).Location = location;
		txtT_tt.Mask = "### ### ### ###";
		((Control)txtT_tt).Name = "txtT_tt";
		((TextBoxBase)txtT_tt).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_tt;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_tt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_tt).TabIndex = 271;
		((Control)txtT_tt).TabStop = false;
		((TextBox)txtT_tt).Text = "0";
		((TextBox)txtT_tt).TextAlign = (HorizontalAlignment)1;
		txtT_tt.Value = 0.0;
		((Control)txtT_tt_nt).Anchor = (AnchorStyles)6;
		txtT_tt_nt.DecimalSymbol = ".";
		((Control)txtT_tt_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric9 = txtT_tt_nt;
		location = new Point(548, 430);
		((Control)asTextNumeric9).Location = location;
		txtT_tt_nt.Mask = "### ### ### ###";
		((Control)txtT_tt_nt).Name = "txtT_tt_nt";
		((TextBoxBase)txtT_tt_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtT_tt_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric10).Size = size;
		txtT_tt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tt_nt).TabIndex = 272;
		((Control)txtT_tt_nt).TabStop = false;
		((TextBox)txtT_tt_nt).Text = "0";
		((TextBox)txtT_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tt_nt.Value = 0.0;
		((Control)txtT_So_luong).Anchor = (AnchorStyles)6;
		txtT_So_luong.DecimalSymbol = ".";
		((Control)txtT_So_luong).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric11 = txtT_So_luong;
		location = new Point(325, 386);
		((Control)asTextNumeric11).Location = location;
		txtT_So_luong.Mask = "### ### ### ###";
		((Control)txtT_So_luong).Name = "txtT_So_luong";
		((TextBoxBase)txtT_So_luong).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtT_So_luong;
		size = new Size(100, 20);
		((Control)asTextNumeric12).Size = size;
		txtT_So_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((Control)txtT_So_luong).TabIndex = 269;
		((Control)txtT_So_luong).TabStop = false;
		((TextBox)txtT_So_luong).Text = "0";
		((TextBox)txtT_So_luong).TextAlign = (HorizontalAlignment)1;
		txtT_So_luong.Value = 0.0;
		((Control)lblT_Thue).Anchor = (AnchorStyles)6;
		((Control)lblT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Thue.ImeMode = (ImeMode)0;
		Label obj48 = lblT_Thue;
		location = new Point(431, 411);
		((Control)obj48).Location = location;
		((Control)lblT_Thue).Name = "lblT_Thue";
		Label obj49 = lblT_Thue;
		size = new Size(111, 13);
		((Control)obj49).Size = size;
		((Control)lblT_Thue).TabIndex = 274;
		lblT_Thue.Text = "Thuế GTGT";
		((Control)Label5).Anchor = (AnchorStyles)6;
		((Control)Label5).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label5.ImeMode = (ImeMode)0;
		Label label3 = Label5;
		location = new Point(232, 390);
		((Control)label3).Location = location;
		((Control)Label5).Name = "Label5";
		Label label4 = Label5;
		size = new Size(87, 13);
		((Control)label4).Size = size;
		((Control)Label5).TabIndex = 268;
		Label5.Text = "Số lượng";
		Label5.TextAlign = (ContentAlignment)16;
		((Control)Label8).Anchor = (AnchorStyles)6;
		((Control)Label8).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label8.ImeMode = (ImeMode)0;
		Label label5 = Label8;
		location = new Point(431, 434);
		((Control)label5).Location = location;
		((Control)Label8).Name = "Label8";
		Label label6 = Label8;
		size = new Size(111, 13);
		((Control)label6).Size = size;
		((Control)Label8).TabIndex = 270;
		Label8.Text = "Tổng cộng";
		Label8.TextAlign = (ContentAlignment)16;
		((Control)txtT_tien_nt).Anchor = (AnchorStyles)6;
		txtT_tien_nt.DecimalSymbol = ".";
		((Control)txtT_tien_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric13 = txtT_tien_nt;
		location = new Point(548, 386);
		((Control)asTextNumeric13).Location = location;
		txtT_tien_nt.Mask = "### ### ### ###";
		((Control)txtT_tien_nt).Name = "txtT_tien_nt";
		((TextBoxBase)txtT_tien_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtT_tien_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric14).Size = size;
		txtT_tien_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tien_nt).TabIndex = 267;
		((Control)txtT_tien_nt).TabStop = false;
		((TextBox)txtT_tien_nt).Text = "0";
		((TextBox)txtT_tien_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tien_nt.Value = 0.0;
		((Control)txtT_Tien).Anchor = (AnchorStyles)6;
		txtT_Tien.DecimalSymbol = ".";
		((Control)txtT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric15 = txtT_Tien;
		location = new Point(651, 386);
		((Control)asTextNumeric15).Location = location;
		txtT_Tien.Mask = "### ### ### ###";
		((Control)txtT_Tien).Name = "txtT_Tien";
		((TextBoxBase)txtT_Tien).ReadOnly = true;
		AsTextNumeric asTextNumeric16 = txtT_Tien;
		size = new Size(100, 20);
		((Control)asTextNumeric16).Size = size;
		txtT_Tien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tien).TabIndex = 266;
		((Control)txtT_Tien).TabStop = false;
		((TextBox)txtT_Tien).Text = "0";
		((TextBox)txtT_Tien).TextAlign = (HorizontalAlignment)1;
		txtT_Tien.Value = 0.0;
		((Control)Label1).Anchor = (AnchorStyles)6;
		((Control)Label1).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label1.ImeMode = (ImeMode)0;
		Label label7 = Label1;
		location = new Point(431, 390);
		((Control)label7).Location = location;
		((Control)Label1).Name = "Label1";
		Label label8 = Label1;
		size = new Size(111, 13);
		((Control)label8).Size = size;
		((Control)Label1).TabIndex = 276;
		Label1.Text = "Tiền hàng";
		Label1.TextAlign = (ContentAlignment)16;
		txtSo_Seri.CharacterCasing = (CharacterCasing)1;
		TextBox obj50 = txtSo_Seri;
		location = new Point(670, 35);
		((Control)obj50).Location = location;
		((Control)txtSo_Seri).Name = "txtSo_Seri";
		TextBox obj51 = txtSo_Seri;
		size = new Size(78, 20);
		((Control)obj51).Size = size;
		((Control)txtSo_Seri).TabIndex = 7;
		lblSo_seri.AutoSize = true;
		Label obj52 = lblSo_seri;
		location = new Point(563, 38);
		((Control)obj52).Location = location;
		((Control)lblSo_seri).Name = "lblSo_seri";
		Label obj53 = lblSo_seri;
		size = new Size(39, 13);
		((Control)obj53).Size = size;
		((Control)lblSo_seri).TabIndex = 268;
		lblSo_seri.Text = "Số seri";
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
		txtMa_Httt.ValidReturnFieldList = "ten_httt,tk,tk_thue_nk,tk_thue_ttdb,tk_thue_gtgt_ban";
		((Control)chkGia_dd).Anchor = (AnchorStyles)6;
		chkGia_dd.Checked = false;
		AsCheckBox asCheckBox = chkGia_dd;
		location = new Point(12, 388);
		((Control)asCheckBox).Location = location;
		((Control)chkGia_dd).Name = "chkGia_dd";
		AsCheckBox asCheckBox2 = chkGia_dd;
		size = new Size(160, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkGia_dd).TabIndex = 2;
		((ButtonBase)chkGia_dd).Text = "Phiếu xuất giá đích danh";
		chkGia_dd.TextValue = "0";
		lblMa_so_thue.AutoSize = true;
		lblMa_so_thue.ImeMode = (ImeMode)0;
		Label obj54 = lblMa_so_thue;
		location = new Point(333, 69);
		((Control)obj54).Location = location;
		((Control)lblMa_so_thue).Name = "lblMa_so_thue";
		Label obj55 = lblMa_so_thue;
		size = new Size(60, 13);
		((Control)obj55).Size = size;
		((Control)lblMa_so_thue).TabIndex = 246;
		lblMa_so_thue.Text = "Mã số thuế";
		lblMa_so_thue.TextAlign = (ContentAlignment)16;
		TextBox obj56 = txtMa_so_thue;
		location = new Point(413, 65);
		((Control)obj56).Location = location;
		((Control)txtMa_so_thue).Name = "txtMa_so_thue";
		TextBox obj57 = txtMa_so_thue;
		size = new Size(128, 20);
		((Control)obj57).Size = size;
		((Control)txtMa_so_thue).TabIndex = 3;
		lblDia_chi.AutoSize = true;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj58 = lblDia_chi;
		location = new Point(9, 43);
		((Control)obj58).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj59 = lblDia_chi;
		size = new Size(40, 13);
		((Control)obj59).Size = size;
		((Control)lblDia_chi).TabIndex = 146;
		lblDia_chi.Text = "Địa chỉ";
		TextBox obj60 = txtDia_chi;
		location = new Point(117, 39);
		((Control)obj60).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj61 = txtDia_chi;
		size = new Size(424, 20);
		((Control)obj61).Size = size;
		((Control)txtDia_chi).TabIndex = 1;
		txtSo_seri_mhd.CharacterCasing = (CharacterCasing)1;
		TextBox obj62 = txtSo_seri_mhd;
		location = new Point(670, 13);
		((Control)obj62).Location = location;
		((Control)txtSo_seri_mhd).Name = "txtSo_seri_mhd";
		TextBox obj63 = txtSo_seri_mhd;
		size = new Size(78, 20);
		((Control)obj63).Size = size;
		((Control)txtSo_seri_mhd).TabIndex = 6;
		lblSo_seri_mhd.AutoSize = true;
		Label obj64 = lblSo_seri_mhd;
		location = new Point(563, 16);
		((Control)obj64).Location = location;
		((Control)lblSo_seri_mhd).Name = "lblSo_seri_mhd";
		Label obj65 = lblSo_seri_mhd;
		size = new Size(65, 13);
		((Control)obj65).Size = size;
		((Control)lblSo_seri_mhd).TabIndex = 273;
		lblSo_seri_mhd.Text = "Ký hiệu mẫu";
		size = new Size(763, 508);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)chkGia_dd);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)txtT_tien_nt);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)lblT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_thue_Nt);
		((Control)this).Controls.Add((Control)(object)txtT_Tien);
		((Control)this).Controls.Add((Control)(object)txtT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_tt);
		((Control)this).Controls.Add((Control)(object)txtT_tt_nt);
		((Control)this).Controls.Add((Control)(object)txtT_So_luong);
		((Control)this).Controls.Add((Control)(object)Label5);
		dgvDetail = adgvDetail;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		((Control)this).Name = "frmPOVchPO5";
		((Form)this).Text = "frmPoVchPO5";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_So_luong, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_thue_Nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tien_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkGia_dd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
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
		((Control)tabHach_toan).ResumeLayout(false);
		((Control)splcHoach_toan.Panel1).ResumeLayout(false);
		((Control)splcHoach_toan.Panel2).ResumeLayout(false);
		((Control)splcHoach_toan.Panel2).PerformLayout();
		((Control)splcHoach_toan).ResumeLayout(false);
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
			((TextBox)txtTk_pt).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			((TextBox)txtTk_thue).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_ban"]), isNum: false));
			CurrentPHRow["tk_pt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			CurrentPHRow["tk_thue"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_ban"]), isNum: false));
			setCTValue("tk_thue", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_ban"]), isNum: false)));
		}
	}

	private void txtTk_thue_Validated(object sender, EventArgs e)
	{
		if (base.ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			setCTValue("tk_thue", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(((TextBox)txtTk_thue).Text.Trim(), isNum: false)));
		}
	}

	private void txtTy_gia_Validated(object sender, EventArgs e)
	{
		if ((!base.IsLoading && base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !IsValidateCalledFromValidData) || 1 == 0)
		{
			V_Ty_Gia();
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_nt).Name, false) == 0)
			{
				V_gia_nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt).Name, false) == 0)
			{
				V_tien_nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien).Name, false) == 0)
			{
				V_tien(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia).Name, false) == 0)
			{
				V_gia(oDv);
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
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Nt(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Gia(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Gia_Nt(dataRowView);
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

	private void adgvDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
	{
		if ((ActionMode != Commons.ApplicationMode.VIEW_MODE && CTTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			DataRowView dataRowView = CT1Voucher[e.RowIndex];
		}
	}

	private void cmdChon_Pn_Click(object sender, EventArgs e)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		if (Operators.CompareString(((TextBox)txtMa_Kh).Text.Trim(), "", false) != 0 && base.ActionMode == Commons.ApplicationMode.ADD_MODE && 0 == 0)
		{
			frmPOVchPO5FindPO3PO7 frmPOVchPO5FindPO3PO8 = new frmPOVchPO5FindPO3PO7();
			((Form)frmPOVchPO5FindPO3PO8).Text = ((ButtonBase)cmdChon_Pn).Text.Replace("&", "");
			frmPOVchPO5FindPO3PO8.sMa_kh = ((TextBox)txtMa_Kh).Text.Trim();
			frmPOVchPO5FindPO3PO8.txtNgay_hd1.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("ngay_ct1"));
			frmPOVchPO5FindPO3PO8.txtNgay_hd2.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("ngay_ct2"));
			((Form)frmPOVchPO5FindPO3PO8).ShowDialog();
			if ((int)((Form)frmPOVchPO5FindPO3PO8).DialogResult == 1)
			{
				LookupHD(frmPOVchPO5FindPO3PO8.sWhereKey);
			}
			((Component)(object)frmPOVchPO5FindPO3PO8).Dispose();
			((Control)this).SelectNextControl((Control)(object)cmdChon_Pn, true, true, true, true);
		}
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
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia_Nt"]), isNum: true)),
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
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true)), (object)100),
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
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia"]), isNum: true)),
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
			double num3 = Conversions.ToDouble(obj3);
			if (num3 == 0.0)
			{
				Type? typeFromHandle4 = typeof(Math);
				array4 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_nt"]), isNum: true), txtTy_gia.Value),
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
				num3 = Conversions.ToDouble(obj4);
			}
			Type? typeFromHandle5 = typeof(Math);
			array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien"]), isNum: true)), (object)100),
				null,
				null
			};
			object[] array8 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array8[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			array4 = array;
			object[] array9 = array4;
			array3 = new bool[3] { false, true, false };
			object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array9, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double num4 = Conversions.ToDouble(obj5);
			if (num4 == 0.0)
			{
				Type? typeFromHandle6 = typeof(Math);
				array4 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Gtgt_nt"]), isNum: true), txtTy_gia.Value),
					num,
					MidpointRounding.AwayFromZero
				};
				object[] array10 = array4;
				array3 = new bool[3] { false, true, false };
				object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array10, (string[])null, (Type[])null, array3);
				if (array3[1])
				{
					num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
				}
				num4 = Conversions.ToDouble(obj6);
			}
			RecipeABC(dgvcTien, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tien"]), isNum: true)), num3, gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_gtgt, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_Gtgt"]), isNum: true)), num4, gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcTien_nt, dbA, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_gtgt_nt, dbA2, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_tien_nt_toi_da, index, Cmess, ref CmessGHDC);
		}
		else
		{
			Type? typeFromHandle7 = typeof(Math);
			object[] array4 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Gia_Nt"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array11 = array4;
			bool[] array3 = new bool[3] { false, true, false };
			object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle7, "Round", array11, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			double dbA3 = Conversions.ToDouble(obj7);
			Type? typeFromHandle8 = typeof(Math);
			array4 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Ts_Gtgt"]), isNum: true)), (object)100),
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
			double dbA4 = Conversions.ToDouble(obj8);
			RecipeABC(dgvcTien_nt, dbA3, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien_Nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
			RecipeABC(dgvcThue_gtgt_nt, dbA4, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Thue_gtgt_nt"]), isNum: true)), gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
		}
	}

	private bool W_Ma_Vt(DataRowView oDv)
	{
		return Conversions.ToBoolean((!Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["stt_rec_hd"]), isNum: false), (object)"", false)) || !Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["stt_rec_pn"]), isNum: false), (object)"", false))) ? ((object)false) : ((object)true));
	}

	private bool W_Tien_Nt(DataRowView oDv)
	{
		return Conversions.ToBoolean((Conversions.ToBoolean(chkGia_dd.Checked) || Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia_ton"]), isNum: false), (object)"4", false))) ? ((object)true) : ((object)false));
	}

	private bool W_Gia_Nt(DataRowView oDv)
	{
		return Conversions.ToBoolean((Conversions.ToBoolean(chkGia_dd.Checked) || Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia_ton"]), isNum: false), (object)"4", false))) ? ((object)true) : ((object)false));
	}

	private bool W_Tien(DataRowView oDv)
	{
		return Conversions.ToBoolean((Conversions.ToBoolean(chkGia_dd.Checked) || Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia_ton"]), isNum: false), (object)"4", false))) ? ((object)true) : ((object)false));
	}

	private bool W_Gia(DataRowView oDv)
	{
		return Conversions.ToBoolean((Conversions.ToBoolean(chkGia_dd.Checked) || Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia_ton"]), isNum: false), (object)"4", false))) ? ((object)true) : ((object)false));
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
		DataRow pDrw = null;
		if (Commons.ValidMa(ref pDrw, "MA_THUE", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_thue"]), isNum: false)), "", "ts_gtgt", pSd: true))
		{
			oDv["ts_gtgt"] = RuntimeHelpers.GetObjectValue(pDrw["ts_gtgt"]);
			Calc_Thue_gtgt(oDv);
			Calc_ThanhToan(oDv);
		}
		ReCalcTonKhoTucThoi(oDv);
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
		Calc_TienVon(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_So_luong_qd(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_gia_nt(DataRowView oDv)
	{
		Calc_Gia(oDv);
		Calc_TienVon(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_gia(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia"]), isNum: true)),
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
			oDv["tien"] = RuntimeHelpers.GetObjectValue(obj);
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
			oDv["tien"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		Calc_TienVon(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_tien_nt(DataRowView oDv)
	{
		bool flag = Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0;
		if (flag)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["tien_nt"]), isNum: true)),
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
			oDv["tien"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia"]), isNum: true)),
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
				oDv["tien"] = num;
			}
			else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
			{
				Type? typeFromHandle3 = typeof(Math);
				array3 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), txtTy_gia.Value),
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
				oDv["tien"] = RuntimeHelpers.GetObjectValue(obj3);
			}
		}
		if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_nt"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true), (object)0, false)) ? true : false)
		{
			oDv["Gia_nt"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
				RuntimeHelpers.GetObjectValue(Interaction.IIf(flag, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia_Nt)),
				MidpointRounding.AwayFromZero
			}, (string[])null, (Type[])null, (bool[])null));
			Calc_Gia(oDv);
		}
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
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
		if ((Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0 && Operators.ConditionalCompareObjectGreater(txtTy_gia.Value, (object)0, false)) ? true : false)
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
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true)), (object)100),
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

	private void Calc_Gia(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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

	private void Calc_ThanhToan(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true)),
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
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tt_nt"]), isNum: true)),
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
				Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt"]), isNum: true)),
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

	private void Calc_TienVon(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		if (!Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true)), (object)0, false))
		{
			return;
		}
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
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			array = new object[3]
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
			array3 = new bool[3] { false, true, false };
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
			array = new object[3]
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
			array3 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	private void Calc_Thue_gtgt(DataRowView oDv)
	{
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true)), (object)100),
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
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true)), (object)100),
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
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_nt"]), isNum: true)),
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
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true)), (object)100),
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
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt"]), isNum: true)),
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
					item["gia"] = RuntimeHelpers.GetObjectValue(obj);
					Type? typeFromHandle2 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt"]), isNum: true)),
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
					item["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
					Type? typeFromHandle3 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_nt"]), isNum: true)),
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
					item["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj3);
				}
				else
				{
					if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
					{
						Type? typeFromHandle4 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt"]), isNum: true), txtTy_gia.Value),
							null,
							null
						};
						object[] array10 = array3;
						SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array10[1] = sIConfiguration.Round_Gia;
						array3[2] = MidpointRounding.AwayFromZero;
						object[] array = array3;
						object[] array11 = array;
						bool[] array5 = new bool[3] { false, true, false };
						object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array11, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						item["gia"] = RuntimeHelpers.GetObjectValue(obj4);
					}
					if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia"]), isNum: true)), (object)0, false))
					{
						Type? typeFromHandle5 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia"]), isNum: true)),
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
						item["Tien"] = RuntimeHelpers.GetObjectValue(obj5);
					}
					else
					{
						Type? typeFromHandle6 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt"]), isNum: true), txtTy_gia.Value),
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
						item["Tien"] = RuntimeHelpers.GetObjectValue(obj6);
					}
					if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien"]), isNum: true)), (object)0, false))
					{
						Type? typeFromHandle7 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien"]), isNum: true)), (object)100),
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
						item["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj7);
					}
					else
					{
						Type? typeFromHandle8 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_nt"]), isNum: true), txtTy_gia.Value),
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
						item["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj8);
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

	private void LookupHD(string aKey)
	{
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		DataTable oTblPh = null;
		DataTable oTblCt = null;
		if (POCommon.POLookupHD4PX(aKey, ref oTblPh, ref oTblCt))
		{
			frmPOVchPO5SeachPO2PO3PO7 frmPOVchPO5SeachPO2PO3PO8 = new frmPOVchPO5SeachPO2PO3PO7();
			((Form)frmPOVchPO5SeachPO2PO3PO8).Text = ((ButtonBase)cmdChon_Pn).Text.Replace("&", "");
			frmPOVchPO5SeachPO2PO3PO8.PHTable = oTblPh;
			frmPOVchPO5SeachPO2PO3PO8.CTTable = oTblCt;
			if ((int)((Form)frmPOVchPO5SeachPO2PO3PO8).ShowDialog() == 1)
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
						dataRow5["Stt_Rec_dh"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec_dh"]);
						dataRow5["Stt_Rec0_dh"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec0_dh"]);
						dataRow5["Stt_Rec_pn"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec_pn"]);
						dataRow5["Stt_Rec0_pn"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec0_pn"]);
						dataRow5["Stt_Rec_hd"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec"]);
						dataRow5["Stt_Rec0_hd"] = RuntimeHelpers.GetObjectValue(dataRow4["Stt_Rec0"]);
						dataRow5["So_hd"] = RuntimeHelpers.GetObjectValue(dataRow3["So_Ct"]);
						dataRow5["So_pn"] = RuntimeHelpers.GetObjectValue(dataRow4["So_pn"]);
						dataRow5["So_dh"] = RuntimeHelpers.GetObjectValue(dataRow4["So_dh"]);
						dataRow5["ma_vt"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_vt"]);
						dataRow5["ten_Vt"] = RuntimeHelpers.GetObjectValue(dataRow4["ten_Vt"]);
						dataRow5["Dvt"] = RuntimeHelpers.GetObjectValue(dataRow4["Dvt"]);
						dataRow5["tk_Vt"] = RuntimeHelpers.GetObjectValue(dataRow4["tk_Vt"]);
						dataRow5["ma_kho"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_kho"]);
						dataRow5["So_luong"] = RuntimeHelpers.GetObjectValue(dataRow4["sl_ton"]);
						dataRow5["So_luong_qd"] = RuntimeHelpers.GetObjectValue(dataRow4["sl_ton"]);
						dataRow5["gia_nt"] = RuntimeHelpers.GetObjectValue(dataRow4["gia_nt"]);
						dataRow5["gia"] = RuntimeHelpers.GetObjectValue(dataRow4["gia"]);
						dataRow5["tien_nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_ton_nt0"]);
						dataRow5["tien"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_ton0"]);
						dataRow5["Gia_nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia_nt"]);
						dataRow5["Gia"] = RuntimeHelpers.GetObjectValue(dataRow4["Gia"]);
						dataRow5["Tien_Nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_ton_nt"]);
						dataRow5["Tien"] = RuntimeHelpers.GetObjectValue(dataRow4["Tien_ton"]);
						dataRow5["Ts_Gtgt"] = RuntimeHelpers.GetObjectValue(dataRow4["Ts_Gtgt"]);
						dataRow5["Thue_Gtgt_Nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Thue_Gtgt_Nt"]);
						dataRow5["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(dataRow4["Thue_Gtgt"]);
						dataRow5["Tt_Nt"] = RuntimeHelpers.GetObjectValue(dataRow4["Tt_Nt"]);
						dataRow5["Tt"] = RuntimeHelpers.GetObjectValue(dataRow4["Tt"]);
						dataRow5["ma_lo"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_lo"]);
						dataRow5["ma_spct"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_spct"]);
						dataRow5["ma_phi"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_phi"]);
						dataRow5["ma_hd"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_hd"]);
						dataRow5["ma_bp"] = RuntimeHelpers.GetObjectValue(dataRow4["ma_bp"]);
						CTTable.Rows.Add(dataRow5);
						ReCalcTonKhoTucThoi(dataRow5);
					}
				}
				UpdateList();
				((TextBoxBase)txtMa_Kh).ReadOnly = true;
				base.CurrentPHRow["tao_tu_pn"] = true;
			}
			((TabControl)AsTabControl).SelectedTab = tabDetail;
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
			Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["gia_nt"]), isNum: true)),
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
		odr["tien_nt"] = RuntimeHelpers.GetObjectValue(obj);
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
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["tien_nt"]), isNum: true)), (object)100),
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
			Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["tien"]), isNum: true)), (object)100),
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
		if ((Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["gia"]), isNum: true)), (object)0, false)) ? true : false)
		{
			Type? typeFromHandle5 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["gia"]), isNum: true)),
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
			odr["tien"] = RuntimeHelpers.GetObjectValue(obj5);
			odr["Tien"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["Cp"]), isNum: true));
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
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odr["tien_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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
			odr["tien"] = RuntimeHelpers.GetObjectValue(obj7);
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
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Thue_Gtgt_Nt"]), isNum: true)),
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
			item["Thue_Gtgt_Nt"] = RuntimeHelpers.GetObjectValue(obj3);
			Type? typeFromHandle4 = typeof(Math);
			array4 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tt_nt"]), isNum: true)),
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
			item["Tt_nt"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		base.PHTable.Columns["ma_gd"].DefaultValue = f_sMa_Gd_Default;
		base.PHTable.Columns["tao_tu_pn"].DefaultValue = false;
		((DataGridView)adgvHach_toan).DataSource = bsCT;
		f_sGia_header = ((DataGridViewColumn)dgvcGia_nt).HeaderText;
		f_sTien_header = ((DataGridViewColumn)dgvcTien_nt).HeaderText;
		string ma_nt = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		((DataGridViewColumn)dgvcGia).HeaderText = f_sGia_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien).HeaderText = f_sTien_header + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = f_sThue_header + " " + ma_nt;
		((DataGridViewColumn)dgvcTien_ht).HeaderText = f_sTien_header + " " + ma_nt;
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tien_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_thue_Nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tt_nt);
		AddDGV(adgvHach_toan);
		AddControl2ListOfDrivedControls((Control)(object)txtTk_pt);
		AddControl2ListOfDrivedControls((Control)(object)txtTk_thue);
		AddControl2ListOfDrivedControls((Control)(object)txtDia_chi);
		AddControl2ListOfDrivedControls((Control)(object)txtMa_so_thue);
		AddControl2ListOfDrivedControls((Control)(object)chkGia_dd);
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
		((Control)txtT_Tien).Visible = visible;
		((Control)txtT_Thue).Visible = visible;
		((Control)txtT_tt).Visible = visible;
		((DataGridViewColumn)dgvcGia).Visible = visible;
		((DataGridViewColumn)dgvcTien).Visible = visible;
		((DataGridViewColumn)dgvcThue_gtgt).Visible = visible;
		((DataGridViewColumn)dgvcTien_ht).Visible = visible;
		string mA_NT = cboMa_NT.MA_NT;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = f_sThue_header + " " + mA_NT;
		((DataGridViewColumn)dgvcGia_nt).HeaderText = f_sGia_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt).HeaderText = f_sTien_header + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = f_sTien_header + " " + mA_NT;
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
			txtT_tien_nt.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(tien_nt)", filter));
			txtT_thue_Nt.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(thue_gtgt_nt)", filter));
			txtT_tt_nt.Value = Operators.AddObject(txtT_tien_nt.Value, txtT_thue_Nt.Value);
			txtT_Tien.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(tien)", filter));
			txtT_Thue.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(thue_gtgt)", filter));
			txtT_tt.Value = Operators.AddObject(txtT_Tien.Value, txtT_Thue.Value);
			txtT_So_luong.Value = RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(So_luong)", filter));
		}
	}

	protected override bool ValidData()
	{
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		bool CmessGHDC = false;
		checked
		{
			if ((ChkEmtyTextBox((TextBox)(object)txtMa_Kh) && base.ValidData()) ? true : false)
			{
				if (!ChkEmtyTextBox((TextBox)(object)txtTk_pt))
				{
					((TabControl)AsTabControl).SelectedTab = tabHach_toan;
					return false;
				}
				if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(txtT_Thue.Value, txtT_thue_Nt.Value), (object)0, false) && !ChkEmtyTextBox((TextBox)(object)txtTk_thue))
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
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Vt"]), isNum: false), (object)"", false))
					{
						return ValidGridCT(num2, dgvcMa_vt, 50062);
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Kho"]), isNum: false), (object)"", false))
					{
						return ValidGridCT(num2, dgvcMa_kho, 50056);
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), (object)0, false))
					{
						((TabControl)AsTabControl).SelectedTab = tabDetail;
						((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcSo_luong).Name, num2].ErrorText = Helper.GetMessContent(50037);
						flag = false;
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
			adgvHach_toan.ReadOnly = false;
			if ((base.CurrentPHRow != null && Operators.ConditionalCompareObjectEqual(base.CurrentPHRow["tao_tu_pn"], (object)true, false)) ? true : false)
			{
				((TextBoxBase)txtMa_Kh).ReadOnly = true;
			}
			else
			{
				((TextBoxBase)txtMa_Kh).ReadOnly = false;
			}
		}
		else
		{
			adgvHach_toan.ReadOnly = true;
		}
	}

	protected override void PHDataBinding()
	{
		base.PHDataBinding();
		CreateDataBinding((Control)(object)txtMa_Kh, "Ma_Kh");
		CreateDataBinding((Control)(object)lblTen_Kh, "Ten_Kh_vat");
		CreateDataBinding((Control)(object)txtDia_chi, "Dia_chi_vat");
		CreateDataBinding((Control)(object)txtMa_so_thue, "Ma_so_thue");
		CreateDataBinding((Control)(object)txtNguoi_Gd, "Nguoi_Gd");
		CreateDataBinding((Control)(object)txtDien_giai, "Dien_Giai");
		CreateDataBinding((Control)(object)txtNgay_Ct, "ngay_ct", "Value");
		CreateDataBinding((Control)(object)txtSo_Ct, "so_ct");
		CreateDataBinding((Control)(object)txtSo_Seri, "so_seri");
		CreateDataBinding((Control)(object)txtNgay_lct, "ngay_lct", "Value");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)txtTk_pt, "tk_pt");
		CreateDataBinding((Control)(object)txtTk_thue, "tk_thue");
		CreateDataBinding((Control)(object)txtMa_Httt, "ma_httt");
		CreateDataBinding((Control)(object)lblTen_httt, "ten_httt");
		CreateDataBinding((Control)(object)txtT_tt, "T_tt", "Value");
		CreateDataBinding((Control)(object)txtT_tt_nt, "T_tt_nt", "Value");
		CreateDataBinding((Control)(object)txtT_Tien, "T_tien", "Value");
		CreateDataBinding((Control)(object)txtT_tien_nt, "T_tien_nt", "Value");
		CreateDataBinding((Control)(object)txtT_Thue, "T_Thue", "Value");
		CreateDataBinding((Control)(object)txtT_thue_Nt, "T_thue_Nt", "Value");
		CreateDataBinding((Control)(object)txtT_So_luong, "T_So_luong", "Value");
		CreateDataBinding((Control)(object)chkGia_dd, "gia_dd", "Checked");
		CreateDataBinding((Control)(object)txtSo_seri_mhd, "so_seri_mhd");
	}

	protected override void SetPHDefaultValues(DataRow drwPh)
	{
		drwPh["ngay_lct"] = RuntimeHelpers.GetObjectValue(drwPh["ngay_ct"]);
	}

	protected override void Cancel()
	{
		((DataGridView)dgvDetail).CancelEdit();
		((DataGridView)adgvHach_toan).CancelEdit();
		base.Cancel();
	}

	protected override void SetReportFomularFields(DataRow odrPrintPHRow)
	{
		base.SetReportFomularFields(odrPrintPHRow);
		string text = "";
		string text2 = "";
		text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentPHRowView["tk_pt"]), isNum: false));
		foreach (DataRowView item in CT1Voucher)
		{
			if (!text2.Contains(Conversions.ToString(item["tk_vt"])))
			{
				text2 = Conversions.ToString(Operators.AddObject((object)text2, Interaction.IIf(Operators.CompareString(text2, string.Empty, false) == 0, RuntimeHelpers.GetObjectValue(item["tk_vt"]), Operators.AddObject((object)",", item["tk_vt"]))));
			}
		}
		base.MyFomularFields.Add("tk_no", text);
		base.MyFomularFields.Add("tk_co", text2);
	}
}
