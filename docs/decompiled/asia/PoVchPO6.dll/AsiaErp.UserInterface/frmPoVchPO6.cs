using System;
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
public class frmPoVchPO6 : frmVoucher
{
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

	[AccessedThroughProperty("txtT_Tien")]
	private AsTextNumeric _txtT_Tien;

	[AccessedThroughProperty("lblT_Tien")]
	private Label _lblT_Tien;

	[AccessedThroughProperty("txtT_tt_nt")]
	private AsTextNumeric _txtT_tt_nt;

	[AccessedThroughProperty("txtT_thue_nt")]
	private AsTextNumeric _txtT_thue_nt;

	[AccessedThroughProperty("txtT_Tien_nt")]
	private AsTextNumeric _txtT_Tien_nt;

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

	[AccessedThroughProperty("txtMa_Httt")]
	private AsTextBox _txtMa_Httt;

	[AccessedThroughProperty("lblTen_Httt")]
	private Label _lblTen_Httt;

	[AccessedThroughProperty("tabTain")]
	private TabPage _tabTain;

	[AccessedThroughProperty("ctlTaIn")]
	private ctlTaIn _ctlTaIn;

	[AccessedThroughProperty("cmdGetTaInFromDetail")]
	private Button _cmdGetTaInFromDetail;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtSo_hd")]
	private TextBox _txtSo_hd;

	[AccessedThroughProperty("txtNgay_hd")]
	private AsMaskedTextBox _txtNgay_hd;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("lblDia_chi")]
	private Label _lblDia_chi;

	[AccessedThroughProperty("txtDia_chi")]
	private TextBox _txtDia_chi;

	[AccessedThroughProperty("lblMa_so_thue")]
	private Label _lblMa_so_thue;

	[AccessedThroughProperty("txtMa_so_thue")]
	private TextBox _txtMa_so_thue;

	[AccessedThroughProperty("tabHach_toan")]
	private TabPage _tabHach_toan;

	[AccessedThroughProperty("splcHoach_toan")]
	private SplitContainer _splcHoach_toan;

	[AccessedThroughProperty("adgvHach_toan")]
	private AsInputDGV _adgvHach_toan;

	[AccessedThroughProperty("txtTk_thue")]
	private AsTextBox _txtTk_thue;

	[AccessedThroughProperty("lblTk_pt")]
	private Label _lblTk_pt;

	[AccessedThroughProperty("txtTk_pt")]
	private AsTextBox _txtTk_pt;

	[AccessedThroughProperty("lblTk_thue")]
	private Label _lblTk_thue;

	[AccessedThroughProperty("dgvcTen_vt_ht")]
	private DataGridViewTextBoxColumn _dgvcTen_vt_ht;

	[AccessedThroughProperty("dgvcTien_nt_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt_ht;

	[AccessedThroughProperty("dgvcTien_ht")]
	private DataGridViewAsTextNumericColumn _dgvcTien_ht;

	[AccessedThroughProperty("dgvcTk_no_ht")]
	private DataGridViewTextBoxColumn _dgvcTk_no_ht;

	[AccessedThroughProperty("dgvcMa_vt_ht")]
	private DataGridViewTextBoxColumn _dgvcMa_vt_ht;

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

	[AccessedThroughProperty("dgvcGia_Nt")]
	private DataGridViewAsTextNumericColumn _dgvcGia_Nt;

	[AccessedThroughProperty("dgvcTien_nt")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt;

	[AccessedThroughProperty("dgvcTs_gtgt")]
	private DataGridViewAsTextNumericColumn _dgvcTs_gtgt;

	[AccessedThroughProperty("dgvcThue_gtgt_nt")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt_nt;

	[AccessedThroughProperty("dgvcGia")]
	private DataGridViewAsTextNumericColumn _dgvcGia;

	[AccessedThroughProperty("dgvcTien")]
	private DataGridViewAsTextNumericColumn _dgvcTien;

	[AccessedThroughProperty("dgvcThue_gtgt")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt;

	[AccessedThroughProperty("dgvcTk_no")]
	private DataGridViewAsTextBoxColumn _dgvcTk_no;

	private string f_sGia_ban;

	private string f_sTien;

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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvDetail_CellValueChanged);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvDetail_CellEnter);
			AsInputDGV.SetDependentFieldsWhenCellValueChangedHandler obj = adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellValueChanged -= val;
				((DataGridView)_adgvDetail).CellEnter -= val2;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged -= obj;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellValueChanged += val;
				((DataGridView)_adgvDetail).CellEnter += val2;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged += obj;
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

	internal virtual AsTextNumeric txtT_Tien_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Tien_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Tien_nt = value;
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

	protected internal virtual Label Label3
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

	internal virtual DataGridViewTextBoxColumn dgvcTk_no_ht
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_no_ht;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_no_ht = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcGia_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcGia_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcGia_Nt = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_no = value;
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

	public frmPoVchPO6()
	{
		__ENCAddToList(this);
		f_sGia_ban = "";
		f_sTien = "";
		f_sTien_ck = "";
		f_sTien_thue = "";
		InitializeComponent();
	}

	public frmPoVchPO6(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_sGia_ban = "";
		f_sTien = "";
		f_sTien_ck = "";
		f_sTien_thue = "";
		InitializeComponent();
	}

	public frmPoVchPO6(string MenuID, string Stt_rec)
		: base(MenuID, Stt_rec)
	{
		__ENCAddToList(this);
		f_sGia_ban = "";
		f_sTien = "";
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
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea7: Expected O, but got Unknown
		//IL_0fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc6: Expected O, but got Unknown
		//IL_108c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1096: Expected O, but got Unknown
		//IL_1c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6c: Expected O, but got Unknown
		//IL_1d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d2c: Expected O, but got Unknown
		//IL_1de6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df0: Expected O, but got Unknown
		//IL_1eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef8: Expected O, but got Unknown
		//IL_1ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2000: Expected O, but got Unknown
		//IL_20fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2104: Expected O, but got Unknown
		//IL_21be: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c8: Expected O, but got Unknown
		//IL_22c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d0: Expected O, but got Unknown
		//IL_23ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d8: Expected O, but got Unknown
		//IL_2acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_316a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3174: Expected O, but got Unknown
		//IL_3233: Unknown result type (might be due to invalid IL or missing references)
		//IL_323d: Expected O, but got Unknown
		//IL_32fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3304: Expected O, but got Unknown
		//IL_38de: Unknown result type (might be due to invalid IL or missing references)
		//IL_38e8: Expected O, but got Unknown
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmPoVchPO6));
		txtDien_giai = new TextBox();
		lblDien_giai = new Label();
		adgvDetail = new AsInputDGV();
		dgvcMa_vt = new DataGridViewAsTextBoxColumn();
		dgvcTen_vt = new DataGridViewTextBoxColumn();
		dgvcDvt = new DataGridViewTextBoxColumn();
		dgvcSo_luong = new DataGridViewAsTextNumericColumn();
		dgvcGia_Nt = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt = new DataGridViewAsTextNumericColumn();
		dgvcTs_gtgt = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt_nt = new DataGridViewAsTextNumericColumn();
		dgvcGia = new DataGridViewAsTextNumericColumn();
		dgvcTien = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt = new DataGridViewAsTextNumericColumn();
		dgvcTk_no = new DataGridViewAsTextBoxColumn();
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
		txtT_Tien = new AsTextNumeric();
		lblT_Tien = new Label();
		txtT_tt_nt = new AsTextNumeric();
		txtT_thue_nt = new AsTextNumeric();
		txtT_Tien_nt = new AsTextNumeric();
		Label6 = new Label();
		lblTen_Kh = new Label();
		lblNguoi_Gd = new Label();
		txtNguoi_Gd = new TextBox();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		txtMa_Httt = new AsTextBox();
		lblTen_Httt = new Label();
		tabTain = new TabPage();
		cmdGetTaInFromDetail = new Button();
		ctlTaIn = new ctlTaIn();
		Label3 = new Label();
		txtSo_hd = new TextBox();
		txtNgay_hd = new AsMaskedTextBox();
		Label4 = new Label();
		lblDia_chi = new Label();
		txtDia_chi = new TextBox();
		lblMa_so_thue = new Label();
		txtMa_so_thue = new TextBox();
		tabHach_toan = new TabPage();
		splcHoach_toan = new SplitContainer();
		adgvHach_toan = new AsInputDGV();
		dgvcTen_vt_ht = new DataGridViewTextBoxColumn();
		dgvcTien_nt_ht = new DataGridViewAsTextNumericColumn();
		dgvcTien_ht = new DataGridViewAsTextNumericColumn();
		dgvcTk_no_ht = new DataGridViewTextBoxColumn();
		dgvcMa_vt_ht = new DataGridViewTextBoxColumn();
		txtTk_thue = new AsTextBox();
		lblTk_pt = new Label();
		txtTk_pt = new AsTextBox();
		lblTk_thue = new Label();
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
		((Control)tabTain).SuspendLayout();
		((Control)tabHach_toan).SuspendLayout();
		((Control)splcHoach_toan.Panel1).SuspendLayout();
		((Control)splcHoach_toan.Panel2).SuspendLayout();
		((Control)splcHoach_toan).SuspendLayout();
		((ISupportInitialize)adgvHach_toan).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = cmdAdd;
		Point location = new Point(3, 453);
		((Control)obj).Location = location;
		Button obj2 = cmdPrint;
		location = new Point(73, 453);
		((Control)obj2).Location = location;
		Button obj3 = cmdLast;
		location = new Point(755, 453);
		((Control)obj3).Location = location;
		((Control)cmdLast).TabIndex = 12;
		Button obj4 = cmdNext;
		location = new Point(730, 453);
		((Control)obj4).Location = location;
		((Control)cmdNext).TabIndex = 11;
		Button obj5 = cmdPrevious;
		location = new Point(705, 453);
		((Control)obj5).Location = location;
		((Control)cmdPrevious).TabIndex = 10;
		Button obj6 = cmdFirst;
		location = new Point(680, 453);
		((Control)obj6).Location = location;
		((Control)cmdFirst).TabIndex = 9;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(386, 126);
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
		location = new Point(105, 125);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay_Ct).TabIndex = 6;
		((Control)gbPH).Controls.Add((Control)(object)lblMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_so_thue);
		((Control)gbPH).Controls.Add((Control)(object)lblDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)txtDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)Label3);
		((Control)gbPH).Controls.Add((Control)(object)txtSo_hd);
		((Control)gbPH).Controls.Add((Control)(object)txtNgay_hd);
		((Control)gbPH).Controls.Add((Control)(object)Label4);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Httt);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Httt);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbPH).Controls.Add((Control)(object)lblNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)txtNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)Label6);
		((Control)gbPH).Controls.Add((Control)(object)txtTy_gia);
		((Control)gbPH).Controls.Add((Control)(object)txtSo_Seri);
		((Control)gbPH).Controls.Add((Control)(object)lblSo_seri);
		((Control)gbPH).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Nt);
		((Control)gbPH).Controls.Add((Control)(object)txtNgay_lct);
		((Control)gbPH).Controls.Add((Control)(object)lblNgay_Lct);
		((Control)gbPH).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbPH).Controls.Add((Control)(object)lblDien_giai);
		gbPH.FlatStyle = (FlatStyle)0;
		GroupBox obj11 = gbPH;
		location = new Point(3, -3);
		((Control)obj11).Location = location;
		GroupBox obj12 = gbPH;
		size = new Size(775, 152);
		((Control)obj12).Size = size;
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_seri, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Seri, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTy_gia, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Httt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_hd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_hd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_so_thue, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_so_thue, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(599, 453);
		((Control)splitButton).Location = location;
		((Control)cmdSearch).TabIndex = 8;
		((Control)AsTabControl).Controls.Add((Control)(object)tabHach_toan);
		((Control)AsTabControl).Controls.Add((Control)(object)tabTain);
		AsTabControl asTabControl = AsTabControl;
		location = new Point(0, 152);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(781, 225);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabTain, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabHach_toan, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabOptFields, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabDetail, 0);
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj13 = tabDetail;
		size = new Size(773, 196);
		((Control)obj13).Size = size;
		TabPage obj14 = tabOptFields;
		size = new Size(773, 196);
		((Control)obj14).Size = size;
		Button obj15 = cmdCopy;
		location = new Point(353, 453);
		((Control)obj15).Location = location;
		((Control)cmdCopy).TabIndex = 7;
		Button obj16 = cmdDelete;
		location = new Point(283, 453);
		((Control)obj16).Location = location;
		((Control)cmdDelete).TabIndex = 6;
		Button obj17 = cmdEdit;
		location = new Point(213, 453);
		((Control)obj17).Location = location;
		((Control)cmdEdit).TabIndex = 5;
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		TextBox obj18 = txtSo_Ct;
		location = new Point(451, 123);
		((Control)obj18).Location = location;
		((Control)txtSo_Ct).TabIndex = 7;
		TextBox obj19 = txtDien_giai;
		location = new Point(105, 81);
		((Control)obj19).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj20 = txtDien_giai;
		size = new Size(424, 20);
		((Control)obj20).Size = size;
		((Control)txtDien_giai).TabIndex = 4;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj21 = lblDien_giai;
		location = new Point(9, 85);
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
		((DataGridView)adgvDetail).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[12]
		{
			dgvcMa_vt,
			(DataGridViewColumn)dgvcTen_vt,
			(DataGridViewColumn)dgvcDvt,
			dgvcSo_luong,
			dgvcGia_Nt,
			dgvcTien_nt,
			dgvcTs_gtgt,
			dgvcThue_gtgt_nt,
			dgvcGia,
			dgvcTien,
			dgvcThue_gtgt,
			dgvcTk_no
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
		((DataGridView)adgvDetail).EditMode = (DataGridViewEditMode)1;
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
		size = new Size(767, 190);
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
		dgvcMa_vt.LookupWhereCondition = "loai=4";
		((DataGridViewColumn)dgvcMa_vt).Name = "dgvcMa_vt";
		dgvcMa_vt.ReceiverValidFieldList = "ten_vt,dvt";
		dgvcMa_vt.SD = true;
		dgvcMa_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_vt.ValidReturnFieldList = "ten_vt,dvt,tk_vt";
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
		((DataGridViewColumn)dgvcSo_luong).Width = 70;
		((DataGridViewColumn)dgvcGia_Nt).DataPropertyName = "gia_nt";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_Nt).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcGia_Nt).HeaderText = "Giá";
		dgvcGia_Nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_Nt).Name = "dgvcGia_Nt";
		((DataGridViewColumn)dgvcGia_Nt).Resizable = (DataGridViewTriState)1;
		dgvcGia_Nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia_Nt.SpecialType = Commons.NumericSpecialType.FCPrice;
		((DataGridViewColumn)dgvcGia_Nt).Width = 90;
		((DataGridViewColumn)dgvcTien_nt).DataPropertyName = "tien_nt";
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcTien_nt).HeaderText = "Tiền";
		dgvcTien_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt).Name = "dgvcTien_nt";
		dgvcTien_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt).Width = 90;
		((DataGridViewColumn)dgvcTs_gtgt).DataPropertyName = "ts_gtgt";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "###.##";
		((DataGridViewColumn)dgvcTs_gtgt).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcTs_gtgt).HeaderText = "% VAT";
		dgvcTs_gtgt.Mask = "###.##";
		((DataGridViewColumn)dgvcTs_gtgt).Name = "dgvcTs_gtgt";
		dgvcTs_gtgt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTs_gtgt).Width = 45;
		((DataGridViewColumn)dgvcThue_gtgt_nt).DataPropertyName = "thue_gtgt_nt";
		val9.Alignment = (DataGridViewContentAlignment)64;
		val9.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText = "VAT";
		dgvcThue_gtgt_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt_nt).Name = "dgvcThue_gtgt_nt";
		((DataGridViewColumn)dgvcThue_gtgt_nt).ReadOnly = true;
		dgvcThue_gtgt_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_gtgt_nt).Width = 70;
		((DataGridViewColumn)dgvcGia).DataPropertyName = "gia";
		val10.Alignment = (DataGridViewContentAlignment)64;
		val10.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcGia).HeaderText = "Giá VND";
		dgvcGia.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia).Name = "dgvcGia";
		dgvcGia.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia.SpecialType = Commons.NumericSpecialType.ACPrice;
		((DataGridViewColumn)dgvcGia).Width = 90;
		((DataGridViewColumn)dgvcTien).DataPropertyName = "tien";
		val11.Alignment = (DataGridViewContentAlignment)64;
		val11.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcTien).HeaderText = "Tiền VND";
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
		((DataGridViewColumn)dgvcThue_gtgt).ReadOnly = true;
		dgvcThue_gtgt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_gtgt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_gtgt).Width = 80;
		dgvcTk_no.AutoFill = true;
		dgvcTk_no.AutoLookup = true;
		dgvcTk_no.AutoValid = true;
		((DataGridViewColumn)dgvcTk_no).DataPropertyName = "tk_no";
		val13.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_no).DefaultCellStyle = val13;
		((DataGridViewColumn)dgvcTk_no).HeaderText = "TK nợ";
		dgvcTk_no.LookupCodeName = "TK";
		dgvcTk_no.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_no).Name = "dgvcTk_no";
		dgvcTk_no.ReceiverValidFieldList = "ten_tk_dt";
		dgvcTk_no.SD = true;
		dgvcTk_no.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_no.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_no).Width = 65;
		txtSo_Seri.CharacterCasing = (CharacterCasing)1;
		TextBox obj23 = txtSo_Seri;
		location = new Point(691, 38);
		((Control)obj23).Location = location;
		((Control)txtSo_Seri).Name = "txtSo_Seri";
		TextBox obj24 = txtSo_Seri;
		size = new Size(78, 20);
		((Control)obj24).Size = size;
		((Control)txtSo_Seri).TabIndex = 8;
		lblSo_seri.AutoSize = true;
		Label obj25 = lblSo_seri;
		location = new Point(573, 41);
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
		location = new Point(691, 16);
		((Control)asMaskedTextBox2).Location = location;
		((MaskedTextBox)txtNgay_lct).Mask = "##/##/####";
		((Control)txtNgay_lct).Name = "txtNgay_lct";
		((MaskedTextBox)txtNgay_lct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_lct;
		size = new Size(78, 20);
		((Control)asMaskedTextBox3).Size = size;
		((Control)txtNgay_lct).TabIndex = 7;
		((MaskedTextBox)txtNgay_lct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_lct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox4.Value = dateTime;
		lblNgay_Lct.AutoSize = true;
		lblNgay_Lct.ImeMode = (ImeMode)0;
		Label obj27 = lblNgay_Lct;
		location = new Point(573, 18);
		((Control)obj27).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj28 = lblNgay_Lct;
		size = new Size(49, 13);
		((Control)obj28).Size = size;
		((Control)lblNgay_Lct).TabIndex = 234;
		lblNgay_Lct.Text = "Ngày lập";
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(700, 104);
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
		location = new Point(650, 104);
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
		location = new Point(573, 106);
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
		location = new Point(447, 430);
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
		location = new Point(447, 408);
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
		location = new Point(672, 427);
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
		location = new Point(672, 405);
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
		((Control)txtT_Tien).Anchor = (AnchorStyles)6;
		txtT_Tien.DecimalSymbol = ".";
		((Control)txtT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric7 = txtT_Tien;
		location = new Point(672, 383);
		((Control)asTextNumeric7).Location = location;
		txtT_Tien.Mask = "### ### ### ###";
		((Control)txtT_Tien).Name = "txtT_Tien";
		((TextBoxBase)txtT_Tien).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_Tien;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_Tien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tien).TabIndex = 229;
		((Control)txtT_Tien).TabStop = false;
		((TextBox)txtT_Tien).Text = "0";
		((TextBox)txtT_Tien).TextAlign = (HorizontalAlignment)1;
		txtT_Tien.Value = 0.0;
		((Control)lblT_Tien).Anchor = (AnchorStyles)6;
		lblT_Tien.AutoSize = true;
		((Control)lblT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Tien.ImeMode = (ImeMode)0;
		Label obj35 = lblT_Tien;
		location = new Point(447, 386);
		((Control)obj35).Location = location;
		((Control)lblT_Tien).Name = "lblT_Tien";
		Label obj36 = lblT_Tien;
		size = new Size(55, 13);
		((Control)obj36).Size = size;
		((Control)lblT_Tien).TabIndex = 228;
		lblT_Tien.Text = "Tiền hàng";
		lblT_Tien.TextAlign = (ContentAlignment)16;
		((Control)txtT_tt_nt).Anchor = (AnchorStyles)6;
		txtT_tt_nt.DecimalSymbol = ".";
		((Control)txtT_tt_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric9 = txtT_tt_nt;
		location = new Point(566, 427);
		((Control)asTextNumeric9).Location = location;
		txtT_tt_nt.Mask = "### ### ### ###";
		((Control)txtT_tt_nt).Name = "txtT_tt_nt";
		((TextBoxBase)txtT_tt_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtT_tt_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric10).Size = size;
		txtT_tt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tt_nt).TabIndex = 238;
		((Control)txtT_tt_nt).TabStop = false;
		((TextBox)txtT_tt_nt).Text = "0";
		((TextBox)txtT_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tt_nt.Value = 0.0;
		((Control)txtT_thue_nt).Anchor = (AnchorStyles)6;
		txtT_thue_nt.DecimalSymbol = ".";
		((Control)txtT_thue_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric11 = txtT_thue_nt;
		location = new Point(566, 405);
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
		((Control)txtT_Tien_nt).Anchor = (AnchorStyles)6;
		txtT_Tien_nt.DecimalSymbol = ".";
		((Control)txtT_Tien_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric13 = txtT_Tien_nt;
		location = new Point(566, 383);
		((Control)asTextNumeric13).Location = location;
		txtT_Tien_nt.Mask = "### ### ### ###";
		((Control)txtT_Tien_nt).Name = "txtT_Tien_nt";
		((TextBoxBase)txtT_Tien_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtT_Tien_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric14).Size = size;
		txtT_Tien_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_Tien_nt).TabIndex = 236;
		((Control)txtT_Tien_nt).TabStop = false;
		((TextBox)txtT_Tien_nt).Text = "0";
		((TextBox)txtT_Tien_nt).TextAlign = (HorizontalAlignment)1;
		txtT_Tien_nt.Value = 0.0;
		Label6.AutoSize = true;
		Label6.ImeMode = (ImeMode)0;
		Label label = Label6;
		location = new Point(9, 107);
		((Control)label).Location = location;
		((Control)Label6).Name = "Label6";
		Label label2 = Label6;
		size = new Size(76, 13);
		((Control)label2).Size = size;
		((Control)Label6).TabIndex = 262;
		Label6.Text = "Mã thanh toán";
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj37 = lblTen_Kh;
		location = new Point(186, 18);
		((Control)obj37).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj38 = lblTen_Kh;
		size = new Size(287, 13);
		((Control)obj38).Size = size;
		((Control)lblTen_Kh).TabIndex = 268;
		lblNguoi_Gd.AutoSize = true;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj39 = lblNguoi_Gd;
		location = new Point(9, 62);
		((Control)obj39).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj40 = lblNguoi_Gd;
		size = new Size(56, 13);
		((Control)obj40).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 267;
		lblNguoi_Gd.Text = "Người bán";
		TextBox obj41 = txtNguoi_Gd;
		location = new Point(105, 59);
		((Control)obj41).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj42 = txtNguoi_Gd;
		size = new Size(145, 20);
		((Control)obj42).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 2;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(105, 15);
		((Control)asTextBox).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		txtMa_Kh.LookupWhereCondition = "isNcc=1";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		txtMa_Kh.SD = true;
		AsTextBox asTextBox2 = txtMa_Kh;
		size = new Size(78, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Kh).TabIndex = 0;
		txtMa_Kh.UseAutoCompleteSource = true;
		txtMa_Kh.ValidReturnFieldList = "ten_kh,dia_chi,ma_so_thue,nguoi_gd,tel,gh_no, ma_httt_po";
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj43 = lblMa_Kh;
		location = new Point(9, 19);
		((Control)obj43).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj44 = lblMa_Kh;
		size = new Size(47, 13);
		((Control)obj44).Size = size;
		((Control)lblMa_Kh).TabIndex = 266;
		lblMa_Kh.Text = "Mã NCC";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		txtMa_Httt.AutoLookup = true;
		txtMa_Httt.AutoValid = true;
		((TextBoxBase)txtMa_Httt).BackColor = SystemColors.Info;
		((TextBox)txtMa_Httt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_Httt;
		location = new Point(105, 103);
		((Control)asTextBox3).Location = location;
		txtMa_Httt.LookupCodeName = "MA_HTTT";
		txtMa_Httt.LookupWhereCondition = "moduleid='PO'";
		((Control)txtMa_Httt).Name = "txtMa_Httt";
		txtMa_Httt.NameControl = lblTen_Httt;
		txtMa_Httt.SD = true;
		AsTextBox asTextBox4 = txtMa_Httt;
		size = new Size(78, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_Httt).TabIndex = 5;
		txtMa_Httt.UseAutoCompleteSource = true;
		txtMa_Httt.ValidReturnFieldList = "ten_httt,tk,tk_thue_gtgt_mua";
		lblTen_Httt.ImeMode = (ImeMode)0;
		Label obj45 = lblTen_Httt;
		location = new Point(184, 107);
		((Control)obj45).Location = location;
		((Control)lblTen_Httt).Name = "lblTen_Httt";
		Label obj46 = lblTen_Httt;
		size = new Size(345, 13);
		((Control)obj46).Size = size;
		((Control)lblTen_Httt).TabIndex = 270;
		lblTen_Httt.TextAlign = (ContentAlignment)16;
		tabTain.BackColor = SystemColors.Control;
		((Control)tabTain).Controls.Add((Control)(object)cmdGetTaInFromDetail);
		((Control)tabTain).Controls.Add((Control)(object)ctlTaIn);
		TabPage obj47 = tabTain;
		location = new Point(4, 25);
		obj47.Location = location;
		((Control)tabTain).Name = "tabTain";
		TabPage obj48 = tabTain;
		size = new Size(773, 196);
		((Control)obj48).Size = size;
		tabTain.TabIndex = 3;
		tabTain.Text = "Thuế &gtgt";
		((Control)cmdGetTaInFromDetail).Anchor = (AnchorStyles)10;
		Button obj49 = cmdGetTaInFromDetail;
		location = new Point(624, 170);
		((Control)obj49).Location = location;
		((Control)cmdGetTaInFromDetail).Name = "cmdGetTaInFromDetail";
		Button obj50 = cmdGetTaInFromDetail;
		size = new Size(141, 23);
		((Control)obj50).Size = size;
		((Control)cmdGetTaInFromDetail).TabIndex = 5;
		((ButtonBase)cmdGetTaInFromDetail).Text = "Lấ&y từ chi tiết";
		ctlTaIn.DataSource = bsTain;
		((Control)ctlTaIn).Dock = (DockStyle)5;
		ctlTaIn.HasThueNK = false;
		ctlTaIn.HasThueTTDB = false;
		ctlTaIn obj51 = ctlTaIn;
		location = new Point(0, 0);
		((Control)obj51).Location = location;
		ctlTaIn obj52 = ctlTaIn;
		Padding val19 = default(Padding);
		((Padding)(ref val19))._002Ector(0);
		((Control)obj52).Margin = val19;
		((Control)ctlTaIn).Name = "ctlTaIn";
		ctlTaIn.PHDataSource = bsPH;
		ctlTaIn obj53 = ctlTaIn;
		size = new Size(773, 196);
		((Control)obj53).Size = size;
		((Control)ctlTaIn).TabIndex = 4;
		ctlTaIn.TAINTable = null;
		ctlTaIn.Tk_Du = "";
		ctlTaIn.Tk_Thue = "";
		Label3.AutoSize = true;
		Label3.ImeMode = (ImeMode)0;
		Label label3 = Label3;
		location = new Point(573, 85);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		Label label4 = Label3;
		size = new Size(63, 13);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 274;
		Label3.Text = "Số hoá đơn";
		TextBox obj54 = txtSo_hd;
		location = new Point(691, 82);
		((Control)obj54).Location = location;
		((TextBoxBase)txtSo_hd).MaxLength = 12;
		((Control)txtSo_hd).Name = "txtSo_hd";
		TextBox obj55 = txtSo_hd;
		size = new Size(78, 20);
		((Control)obj55).Size = size;
		((Control)txtSo_hd).TabIndex = 10;
		txtNgay_hd.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_hd).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_hd;
		location = new Point(691, 60);
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
		Label label5 = Label4;
		location = new Point(573, 62);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		Label label6 = Label4;
		size = new Size(75, 13);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 273;
		Label4.Text = "Ngày hoá đơn";
		lblDia_chi.AutoSize = true;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj56 = lblDia_chi;
		location = new Point(9, 42);
		((Control)obj56).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj57 = lblDia_chi;
		size = new Size(40, 13);
		((Control)obj57).Size = size;
		((Control)lblDia_chi).TabIndex = 276;
		lblDia_chi.Text = "Địa chỉ";
		TextBox obj58 = txtDia_chi;
		location = new Point(105, 37);
		((Control)obj58).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj59 = txtDia_chi;
		size = new Size(424, 20);
		((Control)obj59).Size = size;
		((Control)txtDia_chi).TabIndex = 1;
		lblMa_so_thue.AutoSize = true;
		lblMa_so_thue.ImeMode = (ImeMode)0;
		Label obj60 = lblMa_so_thue;
		location = new Point(321, 63);
		((Control)obj60).Location = location;
		((Control)lblMa_so_thue).Name = "lblMa_so_thue";
		Label obj61 = lblMa_so_thue;
		size = new Size(60, 13);
		((Control)obj61).Size = size;
		((Control)lblMa_so_thue).TabIndex = 278;
		lblMa_so_thue.Text = "Mã số thuế";
		lblMa_so_thue.TextAlign = (ContentAlignment)16;
		TextBox obj62 = txtMa_so_thue;
		location = new Point(401, 59);
		((Control)obj62).Location = location;
		((Control)txtMa_so_thue).Name = "txtMa_so_thue";
		TextBox obj63 = txtMa_so_thue;
		size = new Size(128, 20);
		((Control)obj63).Size = size;
		((Control)txtMa_so_thue).TabIndex = 3;
		tabHach_toan.BackColor = SystemColors.Control;
		((Control)tabHach_toan).Controls.Add((Control)(object)splcHoach_toan);
		TabPage obj64 = tabHach_toan;
		location = new Point(4, 25);
		obj64.Location = location;
		((Control)tabHach_toan).Name = "tabHach_toan";
		TabPage obj65 = tabHach_toan;
		((Padding)(ref val19))._002Ector(3);
		((Control)obj65).Padding = val19;
		TabPage obj66 = tabHach_toan;
		size = new Size(773, 196);
		((Control)obj66).Size = size;
		tabHach_toan.TabIndex = 4;
		tabHach_toan.Text = "Hạch toá&n";
		splcHoach_toan.Dock = (DockStyle)5;
		splcHoach_toan.FixedPanel = (FixedPanel)2;
		SplitContainer obj67 = splcHoach_toan;
		location = new Point(3, 3);
		((Control)obj67).Location = location;
		((Control)splcHoach_toan).Name = "splcHoach_toan";
		splcHoach_toan.Orientation = (Orientation)0;
		((Control)splcHoach_toan.Panel1).Controls.Add((Control)(object)adgvHach_toan);
		((Control)splcHoach_toan.Panel2).Controls.Add((Control)(object)txtTk_thue);
		((Control)splcHoach_toan.Panel2).Controls.Add((Control)(object)lblTk_pt);
		((Control)splcHoach_toan.Panel2).Controls.Add((Control)(object)txtTk_pt);
		((Control)splcHoach_toan.Panel2).Controls.Add((Control)(object)lblTk_thue);
		SplitContainer obj68 = splcHoach_toan;
		size = new Size(767, 190);
		((Control)obj68).Size = size;
		splcHoach_toan.SplitterDistance = 161;
		((Control)splcHoach_toan).TabIndex = 1;
		((DataGridView)adgvHach_toan).AllowUserToAddRows = false;
		((DataGridView)adgvHach_toan).AllowUserToDeleteRows = false;
		((DataGridView)adgvHach_toan).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvHach_toan).BorderStyle = (BorderStyle)2;
		val14.Alignment = (DataGridViewContentAlignment)16;
		val14.BackColor = SystemColors.Control;
		val14.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val14.ForeColor = SystemColors.WindowText;
		val14.SelectionBackColor = SystemColors.Highlight;
		val14.SelectionForeColor = SystemColors.HighlightText;
		val14.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).ColumnHeadersDefaultCellStyle = val14;
		((DataGridView)adgvHach_toan).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvHach_toan).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)dgvcTen_vt_ht,
			dgvcTien_nt_ht,
			dgvcTien_ht,
			(DataGridViewColumn)dgvcTk_no_ht,
			(DataGridViewColumn)dgvcMa_vt_ht
		});
		val15.Alignment = (DataGridViewContentAlignment)16;
		val15.BackColor = SystemColors.Window;
		val15.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val15.ForeColor = SystemColors.ControlText;
		val15.SelectionBackColor = SystemColors.Highlight;
		val15.SelectionForeColor = SystemColors.HighlightText;
		val15.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvHach_toan).DefaultCellStyle = val15;
		((Control)adgvHach_toan).Dock = (DockStyle)5;
		((DataGridView)adgvHach_toan).GridColor = SystemColors.Control;
		adgvHach_toan.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV3 = adgvHach_toan;
		location = new Point(0, 0);
		((Control)asInputDGV3).Location = location;
		((Control)adgvHach_toan).Name = "adgvHach_toan";
		val16.Alignment = (DataGridViewContentAlignment)32;
		val16.BackColor = SystemColors.Control;
		val16.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		val16.ForeColor = SystemColors.WindowText;
		val16.SelectionBackColor = SystemColors.Highlight;
		val16.SelectionForeColor = SystemColors.HighlightText;
		val16.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHach_toan).RowHeadersDefaultCellStyle = val16;
		((DataGridView)adgvHach_toan).RowHeadersWidth = 35;
		((DataGridView)adgvHach_toan).RowTemplate.Height = 20;
		AsInputDGV asInputDGV4 = adgvHach_toan;
		size = new Size(767, 161);
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
		val17.Alignment = (DataGridViewContentAlignment)64;
		val17.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).DefaultCellStyle = val17;
		((DataGridViewColumn)dgvcTien_nt_ht).HeaderText = "Tổng tiền";
		dgvcTien_nt_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt_ht).Name = "dgvcTien_nt_ht";
		((DataGridViewColumn)dgvcTien_nt_ht).ReadOnly = true;
		dgvcTien_nt_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt_ht.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcTien_nt_ht).Width = 95;
		((DataGridViewColumn)dgvcTien_ht).DataPropertyName = "tien";
		val18.Alignment = (DataGridViewContentAlignment)64;
		val18.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ht).DefaultCellStyle = val18;
		((DataGridViewColumn)dgvcTien_ht).HeaderText = "Tổng tiền VNĐ";
		dgvcTien_ht.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ht).Name = "dgvcTien_ht";
		((DataGridViewColumn)dgvcTien_ht).ReadOnly = true;
		dgvcTien_ht.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ht.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien_ht).Visible = false;
		((DataGridViewColumn)dgvcTk_no_ht).DataPropertyName = "tk_no";
		((DataGridViewColumn)dgvcTk_no_ht).HeaderText = "Tk nợ";
		((DataGridViewColumn)dgvcTk_no_ht).Name = "dgvcTk_no_ht";
		((DataGridViewColumn)dgvcTk_no_ht).Width = 65;
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
		((Control)txtTk_thue).Enabled = false;
		AsTextBox asTextBox5 = txtTk_thue;
		location = new Point(421, 2);
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
		txtTk_thue.UseAutoCompleteSource = false;
		((Control)txtTk_thue).Visible = false;
		lblTk_pt.AutoSize = true;
		lblTk_pt.ImeMode = (ImeMode)0;
		Label obj69 = lblTk_pt;
		location = new Point(8, 5);
		((Control)obj69).Location = location;
		((Control)lblTk_pt).Name = "lblTk_pt";
		Label obj70 = lblTk_pt;
		size = new Size(93, 13);
		((Control)obj70).Size = size;
		((Control)lblTk_pt).TabIndex = 259;
		lblTk_pt.Text = "Tài khoản phải trả";
		txtTk_pt.AutoLookup = true;
		txtTk_pt.AutoValid = true;
		((TextBoxBase)txtTk_pt).BackColor = SystemColors.Info;
		((TextBox)txtTk_pt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtTk_pt;
		location = new Point(168, 2);
		((Control)asTextBox7).Location = location;
		txtTk_pt.LookupCodeName = "TK";
		txtTk_pt.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_pt).Name = "txtTk_pt";
		txtTk_pt.NameControl = null;
		txtTk_pt.SD = true;
		AsTextBox asTextBox8 = txtTk_pt;
		size = new Size(78, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtTk_pt).TabIndex = 0;
		txtTk_pt.UseAutoCompleteSource = false;
		lblTk_thue.AutoSize = true;
		((Control)lblTk_thue).Enabled = false;
		lblTk_thue.ImeMode = (ImeMode)0;
		Label obj71 = lblTk_thue;
		location = new Point(298, 5);
		((Control)obj71).Location = location;
		((Control)lblTk_thue).Name = "lblTk_thue";
		Label obj72 = lblTk_thue;
		size = new Size(79, 13);
		((Control)obj72).Size = size;
		((Control)lblTk_thue).TabIndex = 260;
		lblTk_thue.Text = "Tài khoản thuế";
		((Control)lblTk_thue).Visible = false;
		((Control)cmdThanh_toan).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdThanh_toan).Image = (Image)componentResourceManager.GetObject("cmdThanh_toan.Image");
		((ButtonBase)cmdThanh_toan).ImageAlign = (ContentAlignment)16;
		Button obj73 = cmdThanh_toan;
		location = new Point(143, 453);
		((Control)obj73).Location = location;
		((Control)cmdThanh_toan).Name = "cmdThanh_toan";
		Button obj74 = cmdThanh_toan;
		size = new Size(64, 23);
		((Control)obj74).Size = size;
		((Control)cmdThanh_toan).TabIndex = 4;
		((ButtonBase)cmdThanh_toan).Text = "Chi tiền";
		((ButtonBase)cmdThanh_toan).TextAlign = (ContentAlignment)64;
		size = new Size(781, 501);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdThanh_toan);
		((Control)this).Controls.Add((Control)(object)txtT_tt);
		((Control)this).Controls.Add((Control)(object)txtT_Tien_nt);
		((Control)this).Controls.Add((Control)(object)txtT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_thue_nt);
		((Control)this).Controls.Add((Control)(object)lblT_Tt);
		((Control)this).Controls.Add((Control)(object)lblT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_Tien);
		((Control)this).Controls.Add((Control)(object)lblT_Tien);
		((Control)this).Controls.Add((Control)(object)txtT_tt_nt);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmPoVchPO6";
		((Form)this).Text = "";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_thue_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
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
		((Control)tabTain).ResumeLayout(false);
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
			((TextBox)txtTk_thue).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_mua"]), isNum: false));
			CurrentPHRow["tk_pt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk"]), isNum: false));
			CurrentPHRow["Tk_thue"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_thue_gtgt_mua"]), isNum: false));
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
		if (!base.MyVoucherInfo.ct_carry_field_list.ToUpper().Contains("TK_NO") && ((e.ValidatedRow != null && ((DataGridView)adgvDetail).Columns[((DataGridViewCellEventArgs)e).ColumnIndex].Name.Equals(((DataGridViewColumn)dgvcMa_vt).Name) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_vt"]), isNum: false), (object)"", false)) ? true : false))
		{
			CurrentCTRowView["tk_no"] = RuntimeHelpers.GetObjectValue(e.ValidatedRow["tk_vt"]);
		}
	}

	private void adgvDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if ((CTTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			bool flag = true;
			DataRowView oDv = CT1Voucher[e.RowIndex];
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_vt).Name, false) == 0)
			{
				V_Ma_Vt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcSo_luong).Name, false) == 0)
			{
				V_So_Luong(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_Nt).Name, false) == 0)
			{
				V_Gia_Nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia).Name, false) == 0)
			{
				V_Gia(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt).Name, false) == 0)
			{
				V_tien_nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien).Name, false) == 0)
			{
				V_tien(oDv);
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
		if (CTTable == null || (base.IsLoading ? true : false))
		{
			return;
		}
		DataRowView oDv = CT1Voucher[e.RowIndex];
		object obj = null;
		DataGridViewCell currentCell = ((DataGridView)adgvDetail).CurrentCell;
		string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
		if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien).Name, false) == 0)
		{
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				currentCell.ReadOnly = !W_tien(oDv);
			}
		}
		else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt_nt).Name, false) == 0)
		{
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				currentCell.ReadOnly = !W_Thue_Gtgt_Nt(oDv);
			}
		}
		else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcThue_gtgt).Name, false) == 0 && ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			currentCell.ReadOnly = !W_Thue_Gtgt(oDv);
		}
		obj = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(obj), isNum: false));
		((ToolStripItem)tsslInfo).Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(obj, (object)"", false), (object)frmVoucher.BASEVOUCHER_INPUTGRID_TIP_TEXT, RuntimeHelpers.GetObjectValue(obj)));
	}

	private void ctlTaIn_TAINValueChanged(object sender, EventArgs e)
	{
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

	private bool W_tien(DataRowView oDv)
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
	}

	private void V_Gia_Nt(DataRowView oDv)
	{
		Calc_Gia(oDv);
		Calc_TienMua(oDv);
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_Gia(DataRowView oDv)
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
		Calc_Thue_gtgt(oDv);
		Calc_ThanhToan(oDv);
		UpdateList();
	}

	private void V_So_Luong(DataRowView oDv)
	{
		Calc_TienMua(oDv);
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
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["tien_Nt"]), isNum: true)),
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
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia"]), isNum: true)), (object)0, false))
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
			oDv["tien"] = RuntimeHelpers.GetObjectValue(obj2);
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
			oDv["tien"] = RuntimeHelpers.GetObjectValue(obj3);
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
		if ((Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0 && Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)1, false)) ? true : false)
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

	private void Calc_TienMua(DataRowView oDv)
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

	private void Calc_Thue_gtgt(DataRowView oDv)
	{
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["tien_nt"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["tien_nt"]), isNum: true)), (object)100),
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
		}
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array = new object[3]
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
			bool[] array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Ts_Gtgt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true)), (object)100),
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
			oDv["Thue_Gtgt"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array = new object[3]
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
			bool[] array3 = new bool[3] { false, true, false };
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
		if (Operators.ConditionalCompareObjectNotEqual(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["tien_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["tien_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Thue_Gtgt_Nt"]), isNum: true)),
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
		}
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array = new object[3]
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
			bool[] array3 = new bool[3] { false, true, false };
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
			object[] array = new object[3]
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
			bool[] array3 = new bool[3] { false, true, false };
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
			object[] array = new object[3]
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
			bool[] array3 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tt"] = RuntimeHelpers.GetObjectValue(obj4);
		}
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
			IOrderedEnumerable<VB_0024AnonymousType_2<decimal, decimal, decimal, decimal, decimal>> orderedEnumerable = from _0024VB_0024It in (from row in CTTable.AsEnumerable()
					where Operators.ConditionalCompareObjectEqual(row["stt_rec"], _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()["stt_rec"], false)
					select row).GroupBy([SpecialName] (DataRow row) => row.Field<decimal?>("ts_gtgt") ?? 0m, [SpecialName] (DataRow row) => row, [SpecialName] (decimal ts_gtgt, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_1<decimal, IEnumerable<DataRow>, decimal, decimal, decimal, decimal>(ts_gtgt, _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_gtgt_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("thue_gtgt") ?? 0m)))
				select new VB_0024AnonymousType_2<decimal, decimal, decimal, decimal, decimal>(_0024VB_0024It.ts_gtgt, _0024VB_0024It.tien_nt, _0024VB_0024It.tien, _0024VB_0024It.thue_gtgt_nt, _0024VB_0024It.thue_gtgt) into _0024VB_0024It
				orderby _0024VB_0024It.ts_gtgt
				select _0024VB_0024It;
			{
				foreach (VB_0024AnonymousType_2<decimal, decimal, decimal, decimal, decimal> item2 in orderedEnumerable)
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
					dataRow["tien_hang_nt"] = item2.tien_nt;
					dataRow["tien_hang"] = item2.tien;
					dataRow["t_tien_nt"] = item2.tien_nt;
					dataRow["t_tien"] = item2.tien;
					dataRow["t_thue_nt"] = item2.thue_gtgt_nt;
					dataRow["t_thue"] = item2.thue_gtgt;
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
			dataRow["so_seri0"] = txtSo_Seri.Text;
			dataRow["so_ct0"] = txtSo_hd.Text;
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
			dataRow["tien_hang_nt"] = RuntimeHelpers.GetObjectValue(item3["tien_nt"]);
			dataRow["tien_hang"] = RuntimeHelpers.GetObjectValue(item3["tien"]);
			dataRow["t_tien_nt"] = RuntimeHelpers.GetObjectValue(item3["tien_nt"]);
			dataRow["t_tien"] = RuntimeHelpers.GetObjectValue(item3["tien"]);
			dataRow["thue_suat"] = RuntimeHelpers.GetObjectValue(item3["ts_gtgt"]);
			dataRow["t_thue_nt"] = RuntimeHelpers.GetObjectValue(item3["thue_gtgt_nt"]);
			dataRow["t_thue"] = RuntimeHelpers.GetObjectValue(item3["thue_gtgt"]);
			dataRow["ma_bp"] = RuntimeHelpers.GetObjectValue(item3["ma_bp"]);
			dataRow["ma_spct"] = RuntimeHelpers.GetObjectValue(item3["ma_spct"]);
			base.TAINTable.Rows.Add(dataRow);
		}
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
			RecipeABC(dgvcTien, Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tien"]), isNum: true)), num3, gia_tri_dieu_chinh_toi_da, index, Cmess, ref CmessGHDC);
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
						select row).GroupBy([SpecialName] (DataRow row) => new VB_0024AnonymousType_3<object, object, object, object, object, object>(RuntimeHelpers.GetObjectValue(row["tk_no"]), RuntimeHelpers.GetObjectValue(row["ma_hd"]), RuntimeHelpers.GetObjectValue(row["ma_bp"]), RuntimeHelpers.GetObjectValue(row["ma_phi"]), RuntimeHelpers.GetObjectValue(row["ma_spct"]), RuntimeHelpers.GetObjectValue(row["ma_lo"])), [SpecialName] (DataRow row) => row, [SpecialName] (VB_0024AnonymousType_3<object, object, object, object, object, object> _0024VB_0024Key, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_4<object, object, object, object, object, object, IEnumerable<DataRow>, decimal, decimal>(RuntimeHelpers.GetObjectValue(_0024VB_0024Key.tk), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_hd), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_bp), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_phi), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_spct), RuntimeHelpers.GetObjectValue(_0024VB_0024Key.ma_lo), _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("tien") ?? 0m)))
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

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		ctlTaIn.DataSource = base.bsTain;
		ctlTaIn.TAINTable = base.TAINTable;
		((DataGridView)adgvHach_toan).DataSource = bsCT;
		AddControl2ListOfDrivedControls((Control)(object)txtTk_pt);
		AddControl2ListOfDrivedControls((Control)(object)txtTk_thue);
		AddControl2ListOfDrivedControls((Control)(object)ctlTaIn.chkKe_tain);
		AddControl2ListOfDrivedControls((Control)(object)cmdGetTaInFromDetail);
		f_sGia_ban = ((DataGridViewColumn)dgvcGia_Nt).HeaderText;
		f_sTien = ((DataGridViewColumn)dgvcTien_nt).HeaderText;
		f_sTien_thue = ((DataGridViewColumn)dgvcThue_gtgt_nt).HeaderText;
		string ma_nt = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		((DataGridViewColumn)dgvcGia).HeaderText = f_sGia_ban + " " + ma_nt;
		((DataGridViewColumn)dgvcTien).HeaderText = f_sTien + " " + ma_nt;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = f_sTien_thue + " " + ma_nt;
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Tien_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_thue_nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tt_nt);
		AddDGV(adgvHach_toan);
	}

	protected override void RefreshDGVInput()
	{
		base.RefreshDGVInput();
		if (CTTable == null)
		{
			return;
		}
		string text = "";
		bool visible = false;
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			text = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
			txtTy_gia.Value = 1;
			((TextBoxBase)txtTy_gia).ReadOnly = true;
			((Control)txtTy_gia).TabStop = false;
		}
		else
		{
			text = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			visible = true;
			((TextBoxBase)txtTy_gia).ReadOnly = ActionMode == Commons.ApplicationMode.VIEW_MODE;
			((Control)txtTy_gia).TabStop = true;
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				txtTy_gia.Value = Commons.Get_TyGia(cboMa_NT.MA_NT, Conversions.ToDate(txtNgay_Ct.Value));
			}
		}
		((DataGridViewColumn)dgvcGia).Visible = visible;
		((DataGridViewColumn)dgvcTien).Visible = visible;
		((DataGridViewColumn)dgvcThue_gtgt).Visible = visible;
		((Control)txtT_Tien).Visible = visible;
		((Control)txtT_Thue).Visible = visible;
		((Control)txtT_tt).Visible = visible;
		string mA_NT = cboMa_NT.MA_NT;
		((DataGridViewColumn)dgvcGia_Nt).HeaderText = f_sGia_ban + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt).HeaderText = f_sTien + " " + mA_NT;
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
			string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
			txtT_Tien_nt.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_nt)", filter));
			txtT_thue_nt.Value = ctlTaIn.get_T_Thue_Nt("");
			txtT_tt_nt.Value = Operators.AddObject(txtT_Tien_nt.Value, txtT_thue_nt.Value);
			txtT_Tien.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien)", filter));
			txtT_Thue.Value = ctlTaIn.get_T_Thue("");
			txtT_tt.Value = Operators.AddObject(txtT_Tien.Value, txtT_Thue.Value);
		}
	}

	protected override bool ValidData()
	{
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		ctlTaIn.Ma_Nt = cboMa_NT.MA_NT;
		ctlTaIn.Ty_Gia = Conversions.ToDouble(txtTy_gia.Value);
		bool flag = true;
		bool CmessGHDC = false;
		checked
		{
			if ((ChkEmtyTextBox((TextBox)(object)txtMa_Kh) && ChkEmtyTextBox((TextBox)(object)txtMa_Httt) && ctlTaIn.ValidData()) ? true : false)
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
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_no"]), isNum: false), (object)"", false))
					{
						return ValidGridCT(num2, dgvcTk_no, 50023);
					}
					if ((Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tien"]), isNum: true), (object)0, false)) ? true : false)
					{
						return ValidGridCT(num2, dgvcTien, 50037);
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
				return base.ValidData();
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
			ctlTaIn.adgvTaIn.ReadOnly = false;
			((TextBoxBase)txtMa_so_thue).ReadOnly = true;
			((TextBoxBase)txtMa_so_thue).BackColor = ClientConfiguration.DEFAULT_FORM_BACKCOLOR;
		}
		else
		{
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
		CreateDataBinding((Control)(object)txtSo_Seri, "so_seri");
		CreateDataBinding((Control)(object)txtNgay_hd, "ngay_hd", "Value");
		CreateDataBinding((Control)(object)txtSo_hd, "so_hd");
		CreateDataBinding((Control)(object)txtNgay_Ct, "ngay_ct", "Value");
		CreateDataBinding((Control)(object)txtSo_Ct, "so_ct");
		CreateDataBinding((Control)(object)txtNgay_lct, "ngay_lct", "Value");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)txtMa_Httt, "ma_httt");
		CreateDataBinding((Control)(object)lblTen_Httt, "ten_httt");
		CreateDataBinding((Control)(object)txtTk_pt, "tk_pt");
		CreateDataBinding((Control)(object)txtTk_thue, "tk_thue");
		CreateDataBinding((Control)(object)txtT_Tien, "t_tien", "Value");
		CreateDataBinding((Control)(object)txtT_Thue, "t_thue", "Value");
		CreateDataBinding((Control)(object)txtT_tt, "t_tt", "Value");
		CreateDataBinding((Control)(object)txtT_Tien_nt, "t_tien_nt", "Value");
		CreateDataBinding((Control)(object)txtT_thue_nt, "t_thue_nt", "Value");
		CreateDataBinding((Control)(object)txtT_tt_nt, "t_tt_nt", "Value");
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
		((DataGridView)ctlTaIn.adgvTaIn).CancelEdit();
		((DataGridView)adgvHach_toan).CancelEdit();
		base.Cancel();
	}

	protected override bool ChkStatusRight([Optional][DefaultParameterValue("")] ref string retMess)
	{
		return POCommon.POChkStatusRightPO6(Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentPHRow["stt_rec"]), isNum: false)), ref retMess);
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
