using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmARTTEdit : frmOBEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtSo_ct_tt")]
	private TextBox _txtSo_ct_tt;

	[AccessedThroughProperty("txtTy_gia")]
	private AsTextNumeric _txtTy_gia;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("txtTK_pt")]
	private AsTextBox _txtTK_pt;

	[AccessedThroughProperty("txtMa_kh")]
	private AsTextBox _txtMa_kh;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("lblT_tien_nt2")]
	private Label _lblT_tien_nt2;

	[AccessedThroughProperty("txtTien_hang_nt")]
	private AsTextNumeric _txtTien_hang_nt;

	[AccessedThroughProperty("txtMa_tt")]
	private AsTextBox _txtMa_tt;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("lblDu_tt_nt")]
	private Label _lblDu_tt_nt;

	[AccessedThroughProperty("txtNgay_ct_tt")]
	private AsMaskedTextBox _txtNgay_ct_tt;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("txtTien_tt_nt")]
	private AsTextNumeric _txtTien_tt_nt;

	[AccessedThroughProperty("lblTien_tt_nt")]
	private Label _lblTien_tt_nt;

	[AccessedThroughProperty("lblT_tt_nt")]
	private Label _lblT_tt_nt;

	[AccessedThroughProperty("txtTien_thue_nt")]
	private AsTextNumeric _txtTien_thue_nt;

	[AccessedThroughProperty("lblT_thue_nt")]
	private Label _lblT_thue_nt;

	[AccessedThroughProperty("txtGhi_chu")]
	private TextBox _txtGhi_chu;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("txtDu_hd")]
	private AsTextNumeric _txtDu_hd;

	[AccessedThroughProperty("lblDu_tt")]
	private Label _lblDu_tt;

	[AccessedThroughProperty("lblTien_tt")]
	private Label _lblTien_tt;

	[AccessedThroughProperty("lblT_tt")]
	private Label _lblT_tt;

	[AccessedThroughProperty("lblT_thue")]
	private Label _lblT_thue;

	[AccessedThroughProperty("lblT_Tien2")]
	private Label _lblT_Tien2;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("txtTien_tt")]
	private AsTextNumeric _txtTien_tt;

	[AccessedThroughProperty("txtTong_tt")]
	private AsTextNumeric _txtTong_tt;

	[AccessedThroughProperty("txtTien_thue")]
	private AsTextNumeric _txtTien_thue;

	[AccessedThroughProperty("txtTien_hang")]
	private AsTextNumeric _txtTien_hang;

	[AccessedThroughProperty("cboNgoai_te")]
	private AsComboBoxNT _cboNgoai_te;

	[AccessedThroughProperty("txtNgay_ct")]
	private AsMaskedTextBox _txtNgay_ct;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("lblTen_kh")]
	private Label _lblTen_kh;

	[AccessedThroughProperty("lblTen_tt")]
	private Label _lblTen_tt;

	[AccessedThroughProperty("txtngay_tt")]
	private AsMaskedTextBox _txtngay_tt;

	[AccessedThroughProperty("txtLS_qh")]
	private AsTextNumeric _txtLS_qh;

	[AccessedThroughProperty("txtHan_tt")]
	private AsTextNumeric _txtHan_tt;

	[AccessedThroughProperty("txtTL_ck")]
	private AsTextNumeric _txtTL_ck;

	[AccessedThroughProperty("txtHan_ck")]
	private AsTextNumeric _txtHan_ck;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("gbD")]
	private GroupBox _gbD;

	[AccessedThroughProperty("txtDu_hd_nt")]
	private AsTextNumeric _txtDu_hd_nt;

	[AccessedThroughProperty("txtTong_tt_nt")]
	private AsTextNumeric _txtTong_tt_nt;

	private bool bLoading;

	private string f_sTienHang;

	private string f_sTienThue;

	private string f_sTongThanhToan;

	private string f_sDaThanhToan;

	private string f_sConPhaiThanhToan;

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

	internal virtual TextBox txtSo_ct_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ct_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ct_tt = value;
		}
	}

	internal virtual AsTextNumeric txtTy_gia
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
			EventHandler obj = TongVND_TextChanged;
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

	internal virtual AsTextBox txtTK_pt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_pt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_pt = value;
		}
	}

	internal virtual AsTextBox txtMa_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kh = value;
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

	internal virtual Label lblT_tien_nt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_tien_nt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_tien_nt2 = value;
		}
	}

	internal virtual AsTextNumeric txtTien_hang_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_hang_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = TongVND_TextChanged;
			if (_txtTien_hang_nt != null)
			{
				_txtTien_hang_nt.ValueChanged -= obj;
			}
			_txtTien_hang_nt = value;
			if (_txtTien_hang_nt != null)
			{
				_txtTien_hang_nt.ValueChanged += obj;
			}
		}
	}

	internal virtual AsTextBox txtMa_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMa_tt_Validated;
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_tt_AfterCodeValidating;
			if (_txtMa_tt != null)
			{
				((Control)_txtMa_tt).Validated -= eventHandler;
				_txtMa_tt.AfterCodeValidating -= obj;
			}
			_txtMa_tt = value;
			if (_txtMa_tt != null)
			{
				((Control)_txtMa_tt).Validated += eventHandler;
				_txtMa_tt.AfterCodeValidating += obj;
			}
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

	internal virtual Label lblDu_tt_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_tt_nt = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_ct_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ct_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_ct_tt = value;
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

	internal virtual AsTextNumeric txtTien_tt_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = DuVND_TextChanged;
			if (_txtTien_tt_nt != null)
			{
				_txtTien_tt_nt.ValueChanged -= obj;
			}
			_txtTien_tt_nt = value;
			if (_txtTien_tt_nt != null)
			{
				_txtTien_tt_nt.ValueChanged += obj;
			}
		}
	}

	internal virtual Label lblTien_tt_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTien_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTien_tt_nt = value;
		}
	}

	internal virtual Label lblT_tt_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_tt_nt = value;
		}
	}

	internal virtual AsTextNumeric txtTien_thue_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_thue_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = TongVND_TextChanged;
			if (_txtTien_thue_nt != null)
			{
				_txtTien_thue_nt.ValueChanged -= obj;
			}
			_txtTien_thue_nt = value;
			if (_txtTien_thue_nt != null)
			{
				_txtTien_thue_nt.ValueChanged += obj;
			}
		}
	}

	internal virtual Label lblT_thue_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_thue_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_thue_nt = value;
		}
	}

	internal virtual TextBox txtGhi_chu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGhi_chu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGhi_chu = value;
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	internal virtual AsTextBox txtMa_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_hd = value;
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	internal virtual AsTextNumeric txtDu_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDu_hd = value;
		}
	}

	internal virtual Label lblDu_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDu_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDu_tt = value;
		}
	}

	internal virtual Label lblTien_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTien_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTien_tt = value;
		}
	}

	internal virtual Label lblT_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_tt = value;
		}
	}

	internal virtual Label lblT_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_thue = value;
		}
	}

	internal virtual Label lblT_Tien2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_Tien2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_Tien2 = value;
		}
	}

	private virtual Label lblTen_Tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk = value;
		}
	}

	internal virtual AsTextNumeric txtTien_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = DuNT_TextChanged;
			if (_txtTien_tt != null)
			{
				_txtTien_tt.ValueChanged -= obj;
			}
			_txtTien_tt = value;
			if (_txtTien_tt != null)
			{
				_txtTien_tt.ValueChanged += obj;
			}
		}
	}

	internal virtual AsTextNumeric txtTong_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTong_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = DuNT_TextChanged;
			if (_txtTong_tt != null)
			{
				_txtTong_tt.ValueChanged -= obj;
			}
			_txtTong_tt = value;
			if (_txtTong_tt != null)
			{
				_txtTong_tt.ValueChanged += obj;
			}
		}
	}

	internal virtual AsTextNumeric txtTien_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = TongNT_TextChanged;
			if (_txtTien_thue != null)
			{
				_txtTien_thue.ValueChanged -= obj;
			}
			_txtTien_thue = value;
			if (_txtTien_thue != null)
			{
				_txtTien_thue.ValueChanged += obj;
			}
		}
	}

	internal virtual AsTextNumeric txtTien_hang
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_hang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = TongNT_TextChanged;
			if (_txtTien_hang != null)
			{
				_txtTien_hang.ValueChanged -= obj;
			}
			_txtTien_hang = value;
			if (_txtTien_hang != null)
			{
				_txtTien_hang.ValueChanged += obj;
			}
		}
	}

	internal virtual AsComboBoxNT cboNgoai_te
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNgoai_te;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboNT_SelectedIndexChanged;
			if (_cboNgoai_te != null)
			{
				((ComboBox)_cboNgoai_te).SelectedIndexChanged -= eventHandler;
			}
			_cboNgoai_te = value;
			if (_cboNgoai_te != null)
			{
				((ComboBox)_cboNgoai_te).SelectedIndexChanged += eventHandler;
			}
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

	internal virtual Label Label26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label26 = value;
		}
	}

	private virtual Label lblTen_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_hd = value;
		}
	}

	private virtual Label lblTen_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kh = value;
		}
	}

	private virtual Label lblTen_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tt = value;
		}
	}

	internal virtual AsMaskedTextBox txtngay_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtngay_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtngay_tt = value;
		}
	}

	internal virtual AsTextNumeric txtLS_qh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLS_qh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtLS_qh = value;
		}
	}

	internal virtual AsTextNumeric txtHan_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHan_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtHan_tt = value;
		}
	}

	internal virtual AsTextNumeric txtTL_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTL_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTL_ck = value;
		}
	}

	internal virtual AsTextNumeric txtHan_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHan_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtHan_ck = value;
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

	internal virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label18 = value;
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
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

	internal virtual GroupBox gbD
	{
		[DebuggerNonUserCode]
		get
		{
			return _gbD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_gbD = value;
		}
	}

	internal virtual AsTextNumeric txtDu_hd_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_hd_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDu_hd_nt = value;
		}
	}

	internal virtual AsTextNumeric txtTong_tt_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTong_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = DuVND_TextChanged;
			if (_txtTong_tt_nt != null)
			{
				_txtTong_tt_nt.ValueChanged -= obj;
			}
			_txtTong_tt_nt = value;
			if (_txtTong_tt_nt != null)
			{
				_txtTong_tt_nt.ValueChanged += obj;
			}
		}
	}

	public frmARTTEdit()
	{
		((Form)this).Load += frmARTTEdit_Load;
		((Form)this).Activated += frmARTTEdit_Activated;
		__ENCAddToList(this);
		bLoading = false;
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
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		txtSo_ct_tt = new TextBox();
		Label3 = new Label();
		Label5 = new Label();
		txtMa_kh = new AsTextBox();
		lblTen_kh = new Label();
		txtTK_pt = new AsTextBox();
		lblTen_Tk = new Label();
		Label6 = new Label();
		txtTy_gia = new AsTextNumeric();
		lblT_tien_nt2 = new Label();
		txtTien_hang_nt = new AsTextNumeric();
		txtTien_thue_nt = new AsTextNumeric();
		lblT_thue_nt = new Label();
		lblT_tt_nt = new Label();
		txtTien_tt_nt = new AsTextNumeric();
		lblTien_tt_nt = new Label();
		txtNgay_ct_tt = new AsMaskedTextBox();
		Label11 = new Label();
		lblDu_tt_nt = new Label();
		txtMa_tt = new AsTextBox();
		lblTen_tt = new Label();
		Label13 = new Label();
		txtMa_hd = new AsTextBox();
		lblTen_hd = new Label();
		Label16 = new Label();
		Label17 = new Label();
		txtGhi_chu = new TextBox();
		txtDu_hd = new AsTextNumeric();
		lblDu_tt = new Label();
		lblTien_tt = new Label();
		lblT_tt = new Label();
		lblT_thue = new Label();
		lblT_Tien2 = new Label();
		txtTien_hang = new AsTextNumeric();
		txtTien_thue = new AsTextNumeric();
		txtTong_tt = new AsTextNumeric();
		txtTien_tt = new AsTextNumeric();
		cboNgoai_te = new AsComboBoxNT();
		txtNgay_ct = new AsMaskedTextBox();
		txtSo_ct = new TextBox();
		Label26 = new Label();
		txtHan_ck = new AsTextNumeric();
		txtTL_ck = new AsTextNumeric();
		txtHan_tt = new AsTextNumeric();
		txtLS_qh = new AsTextNumeric();
		txtngay_tt = new AsMaskedTextBox();
		Label4 = new Label();
		Label14 = new Label();
		Label15 = new Label();
		Label18 = new Label();
		gbD = new GroupBox();
		txtDu_hd_nt = new AsTextNumeric();
		txtTong_tt_nt = new AsTextNumeric();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)gbD).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(11, 457);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 27;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 380);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 380);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)gbD);
		((Control)gbLine).Controls.Add((Control)(object)Label18);
		((Control)gbLine).Controls.Add((Control)(object)Label15);
		((Control)gbLine).Controls.Add((Control)(object)Label14);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)txtLS_qh);
		((Control)gbLine).Controls.Add((Control)(object)txtHan_tt);
		((Control)gbLine).Controls.Add((Control)(object)txtTL_ck);
		((Control)gbLine).Controls.Add((Control)(object)txtHan_ck);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_hd);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_kh);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tt);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)Label26);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk);
		((Control)gbLine).Controls.Add((Control)(object)cboNgoai_te);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_hd);
		((Control)gbLine).Controls.Add((Control)(object)Label16);
		((Control)gbLine).Controls.Add((Control)(object)txtGhi_chu);
		((Control)gbLine).Controls.Add((Control)(object)Label17);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_pt);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_kh);
		((Control)gbLine).Controls.Add((Control)(object)Label13);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_tt);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct_tt);
		((Control)gbLine).Controls.Add((Control)(object)Label11);
		((Control)gbLine).Controls.Add((Control)(object)txtTy_gia);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct_tt);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		GroupBox obj3 = gbLine;
		Size size = new Size(649, 368);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		gbLine.Text = "Thông tin chung";
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTy_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label11, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label13, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_pt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label17, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGhi_chu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label16, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboNgoai_te, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label26, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtHan_ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTL_ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtHan_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtLS_qh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label14, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label15, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label18, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)gbD, 0);
		((Control)Label1).Anchor = (AnchorStyles)9;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(460, 23);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(77, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 100;
		Label1.Text = "Ngày chứng từ";
		((Control)Label2).Anchor = (AnchorStyles)9;
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(460, 48);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(65, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 101;
		Label2.Text = "Số chứng từ";
		((Control)txtSo_ct_tt).Anchor = (AnchorStyles)9;
		TextBox obj4 = txtSo_ct_tt;
		location = new Point(566, 44);
		((Control)obj4).Location = location;
		((TextBoxBase)txtSo_ct_tt).MaxLength = 20;
		((Control)txtSo_ct_tt).Name = "txtSo_ct_tt";
		TextBox obj5 = txtSo_ct_tt;
		size = new Size(65, 20);
		((Control)obj5).Size = size;
		((Control)txtSo_ct_tt).TabIndex = 5;
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(16, 23);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(82, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 104;
		Label3.Text = "Mã khách hàng";
		Label5.AutoSize = true;
		Label label7 = Label5;
		location = new Point(16, 48);
		((Control)label7).Location = location;
		((Control)Label5).Name = "Label5";
		Label label8 = Label5;
		size = new Size(62, 13);
		((Control)label8).Size = size;
		((Control)Label5).TabIndex = 106;
		Label5.Text = "TK phải thu";
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = true;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_kh;
		location = new Point(105, 19);
		((Control)asTextBox).Location = location;
		txtMa_kh.LookupCodeName = "MA_KH";
		((TextBoxBase)txtMa_kh).MaxLength = 20;
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = lblTen_kh;
		AsTextBox asTextBox2 = txtMa_kh;
		size = new Size(73, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_kh).TabIndex = 0;
		txtMa_kh.UseAutoCompleteSource = true;
		((Control)lblTen_kh).Anchor = (AnchorStyles)13;
		lblTen_kh.ImeMode = (ImeMode)0;
		Label obj6 = lblTen_kh;
		location = new Point(184, 23);
		((Control)obj6).Location = location;
		((Control)lblTen_kh).Name = "lblTen_kh";
		Label obj7 = lblTen_kh;
		size = new Size(269, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_kh).TabIndex = 1039;
		lblTen_kh.TextAlign = (ContentAlignment)16;
		txtTK_pt.AutoLookup = true;
		txtTK_pt.AutoValid = true;
		((TextBoxBase)txtTK_pt).BackColor = SystemColors.Info;
		((TextBox)txtTK_pt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTK_pt;
		location = new Point(105, 44);
		((Control)asTextBox3).Location = location;
		txtTK_pt.LookupCodeName = "TK";
		txtTK_pt.LookupWhereCondition = "tk_cn=1 and  chi_tiet=1";
		((TextBoxBase)txtTK_pt).MaxLength = 20;
		((Control)txtTK_pt).Name = "txtTK_pt";
		txtTK_pt.NameControl = lblTen_Tk;
		AsTextBox asTextBox4 = txtTK_pt;
		size = new Size(73, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTK_pt).TabIndex = 1;
		txtTK_pt.UseAutoCompleteSource = true;
		((Control)lblTen_Tk).Anchor = (AnchorStyles)13;
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj8 = lblTen_Tk;
		location = new Point(184, 48);
		((Control)obj8).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj9 = lblTen_Tk;
		size = new Size(269, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_Tk).TabIndex = 1027;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		((Control)Label6).Anchor = (AnchorStyles)9;
		Label6.AutoSize = true;
		Label label9 = Label6;
		location = new Point(460, 124);
		((Control)label9).Location = location;
		((Control)Label6).Name = "Label6";
		Label label10 = Label6;
		size = new Size(47, 13);
		((Control)label10).Size = size;
		((Control)Label6).TabIndex = 8;
		Label6.Text = "Ngoại tệ";
		((Control)txtTy_gia).Anchor = (AnchorStyles)9;
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(566, 120);
		((Control)asTextNumeric).Location = location;
		txtTy_gia.Mask = "### ### ### ###.##";
		((Control)txtTy_gia).Name = "txtTy_gia";
		AsTextNumeric asTextNumeric2 = txtTy_gia;
		size = new Size(65, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTy_gia).TabIndex = 10;
		((Control)txtTy_gia).Tag = "FP";
		((TextBox)txtTy_gia).Text = "0.00";
		((TextBox)txtTy_gia).TextAlign = (HorizontalAlignment)1;
		txtTy_gia.Value = 0.0;
		lblT_tien_nt2.AutoSize = true;
		Label obj10 = lblT_tien_nt2;
		location = new Point(13, 22);
		((Control)obj10).Location = location;
		((Control)lblT_tien_nt2).Name = "lblT_tien_nt2";
		Label obj11 = lblT_tien_nt2;
		size = new Size(73, 13);
		((Control)obj11).Size = size;
		((Control)lblT_tien_nt2).TabIndex = 112;
		lblT_tien_nt2.Text = "Tiền hàng NT";
		txtTien_hang_nt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric3 = txtTien_hang_nt;
		location = new Point(153, 18);
		((Control)asTextNumeric3).Location = location;
		txtTien_hang_nt.Mask = "### ### ### ###.##";
		((Control)txtTien_hang_nt).Name = "txtTien_hang_nt";
		AsTextNumeric asTextNumeric4 = txtTien_hang_nt;
		size = new Size(120, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtTien_hang_nt).TabIndex = 0;
		((Control)txtTien_hang_nt).Tag = "FA";
		((TextBox)txtTien_hang_nt).Text = "0.00";
		((TextBox)txtTien_hang_nt).TextAlign = (HorizontalAlignment)1;
		txtTien_hang_nt.Value = 0.0;
		txtTien_thue_nt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric5 = txtTien_thue_nt;
		location = new Point(153, 44);
		((Control)asTextNumeric5).Location = location;
		txtTien_thue_nt.Mask = "### ### ### ###.##";
		((Control)txtTien_thue_nt).Name = "txtTien_thue_nt";
		AsTextNumeric asTextNumeric6 = txtTien_thue_nt;
		size = new Size(120, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtTien_thue_nt).TabIndex = 1;
		((Control)txtTien_thue_nt).Tag = "FA";
		((TextBox)txtTien_thue_nt).Text = "0.00";
		((TextBox)txtTien_thue_nt).TextAlign = (HorizontalAlignment)1;
		txtTien_thue_nt.Value = 0.0;
		lblT_thue_nt.AutoSize = true;
		Label obj12 = lblT_thue_nt;
		location = new Point(13, 48);
		((Control)obj12).Location = location;
		((Control)lblT_thue_nt).Name = "lblT_thue_nt";
		Label obj13 = lblT_thue_nt;
		size = new Size(70, 13);
		((Control)obj13).Size = size;
		((Control)lblT_thue_nt).TabIndex = 114;
		lblT_thue_nt.Text = "Tiền thuế NT";
		lblT_tt_nt.AutoSize = true;
		Label obj14 = lblT_tt_nt;
		location = new Point(13, 74);
		((Control)obj14).Location = location;
		((Control)lblT_tt_nt).Name = "lblT_tt_nt";
		Label obj15 = lblT_tt_nt;
		size = new Size(104, 13);
		((Control)obj15).Size = size;
		((Control)lblT_tt_nt).TabIndex = 116;
		lblT_tt_nt.Text = "Tổng thanh toán NT";
		txtTien_tt_nt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric7 = txtTien_tt_nt;
		location = new Point(153, 96);
		((Control)asTextNumeric7).Location = location;
		txtTien_tt_nt.Mask = "### ### ### ###.##";
		((Control)txtTien_tt_nt).Name = "txtTien_tt_nt";
		AsTextNumeric asTextNumeric8 = txtTien_tt_nt;
		size = new Size(120, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtTien_tt_nt).TabIndex = 3;
		((Control)txtTien_tt_nt).Tag = "FA";
		((TextBox)txtTien_tt_nt).Text = "0.00";
		((TextBox)txtTien_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtTien_tt_nt.Value = 0.0;
		lblTien_tt_nt.AutoSize = true;
		Label obj16 = lblTien_tt_nt;
		location = new Point(13, 100);
		((Control)obj16).Location = location;
		((Control)lblTien_tt_nt).Name = "lblTien_tt_nt";
		Label obj17 = lblTien_tt_nt;
		size = new Size(93, 13);
		((Control)obj17).Size = size;
		((Control)lblTien_tt_nt).TabIndex = 118;
		lblTien_tt_nt.Text = "Đã thanh toán NT";
		((Control)txtNgay_ct_tt).Anchor = (AnchorStyles)9;
		txtNgay_ct_tt.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct_tt).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct_tt;
		location = new Point(566, 69);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ct_tt).Mask = "##/##/####";
		((Control)txtNgay_ct_tt).Name = "txtNgay_ct_tt";
		((MaskedTextBox)txtNgay_ct_tt).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ct_tt;
		size = new Size(65, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ct_tt).TabIndex = 6;
		((MaskedTextBox)txtNgay_ct_tt).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ct_tt;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		((Control)Label11).Anchor = (AnchorStyles)9;
		Label11.AutoSize = true;
		Label label11 = Label11;
		location = new Point(460, 73);
		((Control)label11).Location = location;
		((Control)Label11).Name = "Label11";
		Label label12 = Label11;
		size = new Size(75, 13);
		((Control)label12).Size = size;
		((Control)Label11).TabIndex = 120;
		Label11.Text = "Ngày hóa đơn";
		lblDu_tt_nt.AutoSize = true;
		Label obj18 = lblDu_tt_nt;
		location = new Point(13, 127);
		((Control)obj18).Location = location;
		((Control)lblDu_tt_nt).Name = "lblDu_tt_nt";
		Label obj19 = lblDu_tt_nt;
		size = new Size(121, 13);
		((Control)obj19).Size = size;
		((Control)lblDu_tt_nt).TabIndex = 122;
		lblDu_tt_nt.Text = "Còn phải thanh toán NT";
		txtMa_tt.AutoLookup = true;
		txtMa_tt.AutoValid = true;
		((TextBoxBase)txtMa_tt).BackColor = SystemColors.Info;
		((TextBox)txtMa_tt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_tt;
		location = new Point(105, 94);
		((Control)asTextBox5).Location = location;
		txtMa_tt.LookupCodeName = "MA_TT";
		((Control)txtMa_tt).Name = "txtMa_tt";
		txtMa_tt.NameControl = lblTen_tt;
		txtMa_tt.SD = true;
		AsTextBox asTextBox6 = txtMa_tt;
		size = new Size(73, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_tt).TabIndex = 3;
		txtMa_tt.UseAutoCompleteSource = true;
		txtMa_tt.ValidReturnFieldList = "han_tt,han_ck,ls_qh,tl_ck";
		((Control)lblTen_tt).Anchor = (AnchorStyles)13;
		lblTen_tt.ImeMode = (ImeMode)0;
		Label obj20 = lblTen_tt;
		location = new Point(184, 98);
		((Control)obj20).Location = location;
		((Control)lblTen_tt).Name = "lblTen_tt";
		Label obj21 = lblTen_tt;
		size = new Size(269, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_tt).TabIndex = 1038;
		lblTen_tt.TextAlign = (ContentAlignment)16;
		Label13.AutoSize = true;
		Label label13 = Label13;
		location = new Point(16, 98);
		((Control)label13).Location = location;
		((Control)Label13).Name = "Label13";
		Label label14 = Label13;
		size = new Size(76, 13);
		((Control)label14).Size = size;
		((Control)Label13).TabIndex = 124;
		Label13.Text = "Mã thanh toán";
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = true;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_hd).ImeMode = (ImeMode)2;
		AsTextBox asTextBox7 = txtMa_hd;
		location = new Point(105, 69);
		((Control)asTextBox7).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((TextBoxBase)txtMa_hd).MaxLength = 20;
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox8 = txtMa_hd;
		size = new Size(73, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_hd).TabIndex = 2;
		txtMa_hd.UseAutoCompleteSource = true;
		((Control)lblTen_hd).Anchor = (AnchorStyles)13;
		lblTen_hd.ImeMode = (ImeMode)0;
		Label obj22 = lblTen_hd;
		location = new Point(184, 73);
		((Control)obj22).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj23 = lblTen_hd;
		size = new Size(269, 13);
		((Control)obj23).Size = size;
		((Control)lblTen_hd).TabIndex = 1040;
		lblTen_hd.TextAlign = (ContentAlignment)16;
		Label16.AutoSize = true;
		Label label15 = Label16;
		location = new Point(16, 73);
		((Control)label15).Location = location;
		((Control)Label16).Name = "Label16";
		Label label16 = Label16;
		size = new Size(71, 13);
		((Control)label16).Size = size;
		((Control)Label16).TabIndex = 130;
		Label16.Text = "Mã hợp đồng";
		Label17.AutoSize = true;
		Label label17 = Label17;
		location = new Point(16, 175);
		((Control)label17).Location = location;
		((Control)Label17).Name = "Label17";
		Label label18 = Label17;
		size = new Size(44, 13);
		((Control)label18).Size = size;
		((Control)Label17).TabIndex = 132;
		Label17.Text = "Ghi chú";
		((Control)txtGhi_chu).Anchor = (AnchorStyles)13;
		TextBox obj24 = txtGhi_chu;
		location = new Point(105, 171);
		((Control)obj24).Location = location;
		((Control)txtGhi_chu).Name = "txtGhi_chu";
		TextBox obj25 = txtGhi_chu;
		size = new Size(526, 20);
		((Control)obj25).Size = size;
		((Control)txtGhi_chu).TabIndex = 15;
		((Control)txtDu_hd).Anchor = (AnchorStyles)9;
		((TextBoxBase)txtDu_hd).BackColor = SystemColors.Window;
		txtDu_hd.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric9 = txtDu_hd;
		location = new Point(502, 123);
		((Control)asTextNumeric9).Location = location;
		txtDu_hd.Mask = "### ### ### ###";
		((Control)txtDu_hd).Name = "txtDu_hd";
		AsTextNumeric asTextNumeric10 = txtDu_hd;
		size = new Size(120, 20);
		((Control)asTextNumeric10).Size = size;
		((Control)txtDu_hd).TabIndex = 9;
		((Control)txtDu_hd).Tag = "OA";
		((TextBox)txtDu_hd).Text = "0";
		((TextBox)txtDu_hd).TextAlign = (HorizontalAlignment)1;
		txtDu_hd.Value = 0.0;
		((Control)lblDu_tt).Anchor = (AnchorStyles)9;
		lblDu_tt.AutoSize = true;
		Label obj26 = lblDu_tt;
		location = new Point(365, 127);
		((Control)obj26).Location = location;
		((Control)lblDu_tt).Name = "lblDu_tt";
		Label obj27 = lblDu_tt;
		size = new Size(103, 13);
		((Control)obj27).Size = size;
		((Control)lblDu_tt).TabIndex = 144;
		lblDu_tt.Text = "Còn phải thanh toán";
		((Control)lblTien_tt).Anchor = (AnchorStyles)9;
		lblTien_tt.AutoSize = true;
		Label obj28 = lblTien_tt;
		location = new Point(365, 100);
		((Control)obj28).Location = location;
		((Control)lblTien_tt).Name = "lblTien_tt";
		Label obj29 = lblTien_tt;
		size = new Size(78, 13);
		((Control)obj29).Size = size;
		((Control)lblTien_tt).TabIndex = 140;
		lblTien_tt.Text = "Đã thanh toán ";
		((Control)lblT_tt).Anchor = (AnchorStyles)9;
		lblT_tt.AutoSize = true;
		Label obj30 = lblT_tt;
		location = new Point(365, 74);
		((Control)obj30).Location = location;
		((Control)lblT_tt).Name = "lblT_tt";
		Label obj31 = lblT_tt;
		size = new Size(89, 13);
		((Control)obj31).Size = size;
		((Control)lblT_tt).TabIndex = 138;
		lblT_tt.Text = "Tổng thanh toán ";
		((Control)lblT_thue).Anchor = (AnchorStyles)9;
		lblT_thue.AutoSize = true;
		Label obj32 = lblT_thue;
		location = new Point(365, 48);
		((Control)obj32).Location = location;
		((Control)lblT_thue).Name = "lblT_thue";
		Label obj33 = lblT_thue;
		size = new Size(55, 13);
		((Control)obj33).Size = size;
		((Control)lblT_thue).TabIndex = 136;
		lblT_thue.Text = "Tiền thuế ";
		((Control)lblT_Tien2).Anchor = (AnchorStyles)9;
		lblT_Tien2.AutoSize = true;
		Label obj34 = lblT_Tien2;
		location = new Point(365, 22);
		((Control)obj34).Location = location;
		((Control)lblT_Tien2).Name = "lblT_Tien2";
		Label obj35 = lblT_Tien2;
		size = new Size(58, 13);
		((Control)obj35).Size = size;
		((Control)lblT_Tien2).TabIndex = 134;
		lblT_Tien2.Text = "Tiền hàng ";
		((Control)txtTien_hang).Anchor = (AnchorStyles)9;
		txtTien_hang.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric11 = txtTien_hang;
		location = new Point(502, 18);
		((Control)asTextNumeric11).Location = location;
		txtTien_hang.Mask = "### ### ### ###";
		((Control)txtTien_hang).Name = "txtTien_hang";
		AsTextNumeric asTextNumeric12 = txtTien_hang;
		size = new Size(120, 20);
		((Control)asTextNumeric12).Size = size;
		((Control)txtTien_hang).TabIndex = 5;
		((Control)txtTien_hang).Tag = "OA";
		((TextBox)txtTien_hang).Text = "0";
		((TextBox)txtTien_hang).TextAlign = (HorizontalAlignment)1;
		txtTien_hang.Value = 0.0;
		((Control)txtTien_thue).Anchor = (AnchorStyles)9;
		txtTien_thue.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric13 = txtTien_thue;
		location = new Point(502, 44);
		((Control)asTextNumeric13).Location = location;
		txtTien_thue.Mask = "### ### ### ###";
		((Control)txtTien_thue).Name = "txtTien_thue";
		AsTextNumeric asTextNumeric14 = txtTien_thue;
		size = new Size(120, 20);
		((Control)asTextNumeric14).Size = size;
		((Control)txtTien_thue).TabIndex = 6;
		((Control)txtTien_thue).Tag = "OA";
		((TextBox)txtTien_thue).Text = "0";
		((TextBox)txtTien_thue).TextAlign = (HorizontalAlignment)1;
		txtTien_thue.Value = 0.0;
		((Control)txtTong_tt).Anchor = (AnchorStyles)9;
		((TextBoxBase)txtTong_tt).BackColor = SystemColors.Window;
		txtTong_tt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric15 = txtTong_tt;
		location = new Point(502, 70);
		((Control)asTextNumeric15).Location = location;
		txtTong_tt.Mask = "### ### ### ###";
		((Control)txtTong_tt).Name = "txtTong_tt";
		AsTextNumeric asTextNumeric16 = txtTong_tt;
		size = new Size(120, 20);
		((Control)asTextNumeric16).Size = size;
		((Control)txtTong_tt).TabIndex = 7;
		((Control)txtTong_tt).Tag = "OA";
		((TextBox)txtTong_tt).Text = "0";
		((TextBox)txtTong_tt).TextAlign = (HorizontalAlignment)1;
		txtTong_tt.Value = 0.0;
		((Control)txtTien_tt).Anchor = (AnchorStyles)9;
		txtTien_tt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric17 = txtTien_tt;
		location = new Point(502, 96);
		((Control)asTextNumeric17).Location = location;
		txtTien_tt.Mask = "### ### ### ###";
		((Control)txtTien_tt).Name = "txtTien_tt";
		AsTextNumeric asTextNumeric18 = txtTien_tt;
		size = new Size(120, 20);
		((Control)asTextNumeric18).Size = size;
		((Control)txtTien_tt).TabIndex = 8;
		((Control)txtTien_tt).Tag = "OA";
		((TextBox)txtTien_tt).Text = "0";
		((TextBox)txtTien_tt).TextAlign = (HorizontalAlignment)1;
		txtTien_tt.Value = 0.0;
		((Control)cboNgoai_te).Anchor = (AnchorStyles)9;
		((ComboBox)cboNgoai_te).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNgoai_te).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboNgoai_te;
		location = new Point(513, 120);
		((Control)asComboBoxNT).Location = location;
		cboNgoai_te.MA_NT = "";
		((Control)cboNgoai_te).Name = "cboNgoai_te";
		AsComboBoxNT asComboBoxNT2 = cboNgoai_te;
		size = new Size(47, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboNgoai_te).TabIndex = 9;
		((Control)txtNgay_ct).Anchor = (AnchorStyles)9;
		txtNgay_ct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_ct;
		location = new Point(566, 19);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_ct).Mask = "##/##/####";
		((Control)txtNgay_ct).Name = "txtNgay_ct";
		((MaskedTextBox)txtNgay_ct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_ct;
		size = new Size(65, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_ct).TabIndex = 4;
		((MaskedTextBox)txtNgay_ct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_ct;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		((Control)txtSo_ct).Anchor = (AnchorStyles)9;
		TextBox obj36 = txtSo_ct;
		location = new Point(566, 94);
		((Control)obj36).Location = location;
		((TextBoxBase)txtSo_ct).MaxLength = 20;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj37 = txtSo_ct;
		size = new Size(65, 20);
		((Control)obj37).Size = size;
		((Control)txtSo_ct).TabIndex = 7;
		((Control)Label26).Anchor = (AnchorStyles)9;
		Label26.AutoSize = true;
		Label label19 = Label26;
		location = new Point(460, 98);
		((Control)label19).Location = location;
		((Control)Label26).Name = "Label26";
		Label label20 = Label26;
		size = new Size(63, 13);
		((Control)label20).Size = size;
		((Control)Label26).TabIndex = 1035;
		Label26.Text = "Số hóa đơn";
		((TextBoxBase)txtHan_ck).BackColor = SystemColors.Control;
		txtHan_ck.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric19 = txtHan_ck;
		location = new Point(105, 120);
		((Control)asTextNumeric19).Location = location;
		txtHan_ck.Mask = "### ### ### ###";
		((Control)txtHan_ck).Name = "txtHan_ck";
		((TextBoxBase)txtHan_ck).ReadOnly = true;
		AsTextNumeric asTextNumeric20 = txtHan_ck;
		size = new Size(109, 20);
		((Control)asTextNumeric20).Size = size;
		((Control)txtHan_ck).TabIndex = 11;
		((Control)txtHan_ck).TabStop = false;
		((Control)txtHan_ck).Tag = "OA";
		((TextBox)txtHan_ck).Text = "0";
		((TextBox)txtHan_ck).TextAlign = (HorizontalAlignment)1;
		txtHan_ck.Value = 0.0;
		((TextBoxBase)txtTL_ck).BackColor = SystemColors.Control;
		txtTL_ck.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric21 = txtTL_ck;
		location = new Point(105, 146);
		((Control)asTextNumeric21).Location = location;
		txtTL_ck.Mask = "### ### ### ###.##";
		((Control)txtTL_ck).Name = "txtTL_ck";
		((TextBoxBase)txtTL_ck).ReadOnly = true;
		AsTextNumeric asTextNumeric22 = txtTL_ck;
		size = new Size(109, 20);
		((Control)asTextNumeric22).Size = size;
		((Control)txtTL_ck).TabIndex = 12;
		((Control)txtTL_ck).TabStop = false;
		((Control)txtTL_ck).Tag = "";
		((TextBox)txtTL_ck).Text = "0.00";
		((TextBox)txtTL_ck).TextAlign = (HorizontalAlignment)1;
		txtTL_ck.Value = 0.0;
		((TextBoxBase)txtHan_tt).BackColor = SystemColors.Control;
		txtHan_tt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric23 = txtHan_tt;
		location = new Point(307, 120);
		((Control)asTextNumeric23).Location = location;
		txtHan_tt.Mask = "### ### ### ###";
		((Control)txtHan_tt).Name = "txtHan_tt";
		((TextBoxBase)txtHan_tt).ReadOnly = true;
		AsTextNumeric asTextNumeric24 = txtHan_tt;
		size = new Size(109, 20);
		((Control)asTextNumeric24).Size = size;
		((Control)txtHan_tt).TabIndex = 13;
		((Control)txtHan_tt).TabStop = false;
		((Control)txtHan_tt).Tag = "OA";
		((TextBox)txtHan_tt).Text = "0";
		((TextBox)txtHan_tt).TextAlign = (HorizontalAlignment)1;
		txtHan_tt.Value = 0.0;
		((TextBoxBase)txtLS_qh).BackColor = SystemColors.Control;
		txtLS_qh.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric25 = txtLS_qh;
		location = new Point(307, 146);
		((Control)asTextNumeric25).Location = location;
		txtLS_qh.Mask = "### ### ### ###.##";
		((Control)txtLS_qh).Name = "txtLS_qh";
		((TextBoxBase)txtLS_qh).ReadOnly = true;
		AsTextNumeric asTextNumeric26 = txtLS_qh;
		size = new Size(109, 20);
		((Control)asTextNumeric26).Size = size;
		((Control)txtLS_qh).TabIndex = 14;
		((Control)txtLS_qh).TabStop = false;
		((Control)txtLS_qh).Tag = "";
		((TextBox)txtLS_qh).Text = "0.00";
		((TextBox)txtLS_qh).TextAlign = (HorizontalAlignment)1;
		txtLS_qh.Value = 0.0;
		txtngay_tt.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtngay_tt).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox7 = txtngay_tt;
		location = new Point(175, 451);
		((Control)asMaskedTextBox7).Location = location;
		((MaskedTextBox)txtngay_tt).Mask = "##/##/####";
		((Control)txtngay_tt).Name = "txtngay_tt";
		((MaskedTextBox)txtngay_tt).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox8 = txtngay_tt;
		size = new Size(76, 20);
		((Control)asMaskedTextBox8).Size = size;
		((Control)txtngay_tt).TabIndex = 1045;
		((MaskedTextBox)txtngay_tt).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox9 = txtngay_tt;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox9.Value = dateTime;
		Label4.AutoSize = true;
		Label label21 = Label4;
		location = new Point(16, 124);
		((Control)label21).Location = location;
		((Control)Label4).Name = "Label4";
		Label label22 = Label4;
		size = new Size(80, 13);
		((Control)label22).Size = size;
		((Control)Label4).TabIndex = 1045;
		Label4.Text = "Hạn chiết khấu";
		Label14.AutoSize = true;
		Label label23 = Label14;
		location = new Point(16, 150);
		((Control)label23).Location = location;
		((Control)Label14).Name = "Label14";
		Label label24 = Label14;
		size = new Size(37, 13);
		((Control)label24).Size = size;
		((Control)Label14).TabIndex = 1046;
		Label14.Text = "TL CK";
		Label15.AutoSize = true;
		Label label25 = Label15;
		location = new Point(220, 124);
		((Control)label25).Location = location;
		((Control)Label15).Name = "Label15";
		Label label26 = Label15;
		size = new Size(81, 13);
		((Control)label26).Size = size;
		((Control)Label15).TabIndex = 17;
		Label15.Text = "Hạn thanh toán";
		Label18.AutoSize = true;
		Label label27 = Label18;
		location = new Point(220, 153);
		((Control)label27).Location = location;
		((Control)Label18).Name = "Label18";
		Label label28 = Label18;
		size = new Size(39, 13);
		((Control)label28).Size = size;
		((Control)Label18).TabIndex = 19;
		Label18.Text = "LS QH";
		((Control)gbD).Anchor = (AnchorStyles)13;
		((Control)gbD).Controls.Add((Control)(object)txtDu_hd_nt);
		((Control)gbD).Controls.Add((Control)(object)txtTong_tt_nt);
		((Control)gbD).Controls.Add((Control)(object)lblT_tien_nt2);
		((Control)gbD).Controls.Add((Control)(object)txtTien_tt);
		((Control)gbD).Controls.Add((Control)(object)txtTien_hang_nt);
		((Control)gbD).Controls.Add((Control)(object)txtTong_tt);
		((Control)gbD).Controls.Add((Control)(object)lblT_thue_nt);
		((Control)gbD).Controls.Add((Control)(object)txtTien_thue);
		((Control)gbD).Controls.Add((Control)(object)txtTien_hang);
		((Control)gbD).Controls.Add((Control)(object)txtTien_thue_nt);
		((Control)gbD).Controls.Add((Control)(object)lblDu_tt);
		((Control)gbD).Controls.Add((Control)(object)lblTien_tt);
		((Control)gbD).Controls.Add((Control)(object)lblT_tt_nt);
		((Control)gbD).Controls.Add((Control)(object)lblT_tt);
		((Control)gbD).Controls.Add((Control)(object)lblT_thue);
		((Control)gbD).Controls.Add((Control)(object)lblT_Tien2);
		((Control)gbD).Controls.Add((Control)(object)txtDu_hd);
		((Control)gbD).Controls.Add((Control)(object)lblTien_tt_nt);
		((Control)gbD).Controls.Add((Control)(object)lblDu_tt_nt);
		((Control)gbD).Controls.Add((Control)(object)txtTien_tt_nt);
		GroupBox obj38 = gbD;
		location = new Point(6, 201);
		((Control)obj38).Location = location;
		((Control)gbD).Name = "gbD";
		GroupBox obj39 = gbD;
		size = new Size(637, 156);
		((Control)obj39).Size = size;
		((Control)gbD).TabIndex = 100;
		gbD.TabStop = false;
		gbD.Text = "Chi tiết";
		txtDu_hd_nt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric27 = txtDu_hd_nt;
		location = new Point(153, 123);
		((Control)asTextNumeric27).Location = location;
		txtDu_hd_nt.Mask = "### ### ### ###.##";
		((Control)txtDu_hd_nt).Name = "txtDu_hd_nt";
		AsTextNumeric asTextNumeric28 = txtDu_hd_nt;
		size = new Size(120, 20);
		((Control)asTextNumeric28).Size = size;
		((Control)txtDu_hd_nt).TabIndex = 4;
		((Control)txtDu_hd_nt).Tag = "FA";
		((TextBox)txtDu_hd_nt).Text = "0.00";
		((TextBox)txtDu_hd_nt).TextAlign = (HorizontalAlignment)1;
		txtDu_hd_nt.Value = 0.0;
		txtTong_tt_nt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric29 = txtTong_tt_nt;
		location = new Point(153, 70);
		((Control)asTextNumeric29).Location = location;
		txtTong_tt_nt.Mask = "### ### ### ###.##";
		((Control)txtTong_tt_nt).Name = "txtTong_tt_nt";
		AsTextNumeric asTextNumeric30 = txtTong_tt_nt;
		size = new Size(120, 20);
		((Control)asTextNumeric30).Size = size;
		((Control)txtTong_tt_nt).TabIndex = 2;
		((Control)txtTong_tt_nt).Tag = "FA";
		((TextBox)txtTong_tt_nt).Text = "0.00";
		((TextBox)txtTong_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtTong_tt_nt.Value = 0.0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(673, 415);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtngay_tt);
		((Form)this).FormBorderStyle = (FormBorderStyle)4;
		((Control)this).Name = "frmARTTEdit";
		((Form)this).Text = "frmARTTEdit";
		((Control)this).Controls.SetChildIndex((Control)(object)txtngay_tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbLine, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSave, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)gbD).ResumeLayout(false);
		((Control)gbD).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		f_sTienHang = lblT_Tien2.Text;
		f_sTienThue = lblT_thue.Text;
		f_sTongThanhToan = lblT_tt.Text;
		f_sDaThanhToan = lblTien_tt.Text;
		f_sConPhaiThanhToan = lblDu_tt.Text;
		string ma_nt = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		lblT_Tien2.Text = f_sTienHang + " " + ma_nt;
		lblT_thue.Text = f_sTienThue + " " + ma_nt;
		lblT_tt.Text = f_sTongThanhToan + " " + ma_nt;
		lblTien_tt.Text = f_sDaThanhToan + " " + ma_nt;
		lblDu_tt.Text = f_sConPhaiThanhToan + " " + ma_nt;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		MaskTextBoxAll(((Control)gbLine).Controls);
		MaskTextBoxAll(((Control)gbD).Controls);
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (flag)
		{
			RowToEdit.AcceptChanges();
			AutoIns();
		}
		return flag;
	}

	protected override bool UpdateDB()
	{
		bool flag = base.UpdateDB();
		if (flag)
		{
			RowToEdit.AcceptChanges();
			AutoIns();
		}
		return flag;
	}

	protected override void DataBinding()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		base.DataBinding();
		bLoading = true;
		Control ojb = (Control)(object)txtNgay_ct;
		CreateDataBinding(ref ojb, "Ngay_ct_tt", "Value");
		txtNgay_ct = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_ct_tt;
		CreateDataBinding(ref ojb, "so_ct_tt");
		txtSo_ct_tt = (TextBox)ojb;
		ojb = (Control)(object)txtMa_kh;
		CreateDataBinding(ref ojb, "ma_kh");
		txtMa_kh = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTK_pt;
		CreateDataBinding(ref ojb, "tk_pt");
		txtTK_pt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTien_hang;
		CreateDataBinding(ref ojb, "t_tien2", "Value");
		txtTien_hang = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_hang_nt;
		CreateDataBinding(ref ojb, "t_tien_nt2", "Value");
		txtTien_hang_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_thue;
		CreateDataBinding(ref ojb, "t_thue", "Value");
		txtTien_thue = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_thue_nt;
		CreateDataBinding(ref ojb, "t_thue_nt", "Value");
		txtTien_thue_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTong_tt;
		CreateDataBinding(ref ojb, "t_tt", "Value");
		txtTong_tt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTong_tt_nt;
		CreateDataBinding(ref ojb, "t_tt_nt", "Value");
		txtTong_tt_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_tt;
		CreateDataBinding(ref ojb, "tien_tt", "Value");
		txtTien_tt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_tt_nt;
		CreateDataBinding(ref ojb, "tien_tt_nt", "Value");
		txtTien_tt_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDu_hd;
		CreateDataBinding(ref ojb, "du_hd", "Value");
		txtDu_hd = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDu_hd_nt;
		CreateDataBinding(ref ojb, "du_hd_nt", "Value");
		txtDu_hd_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtNgay_ct_tt;
		CreateDataBinding(ref ojb, "ngay_ct", "Value");
		txtNgay_ct_tt = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtngay_tt;
		CreateDataBinding(ref ojb, "ngay_tt", "Value");
		txtngay_tt = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "so_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)txtMa_tt;
		CreateDataBinding(ref ojb, "Ma_tt");
		txtMa_tt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtHan_ck;
		CreateDataBinding(ref ojb, "han_ck", "Value");
		txtHan_ck = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtHan_tt;
		CreateDataBinding(ref ojb, "han_tt", "Value");
		txtHan_tt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtLS_qh;
		CreateDataBinding(ref ojb, "ls_qh", "Value");
		txtLS_qh = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTL_ck;
		CreateDataBinding(ref ojb, "tl_ck", "Value");
		txtTL_ck = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMa_hd;
		CreateDataBinding(ref ojb, "ma_hd");
		txtMa_hd = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtGhi_chu;
		CreateDataBinding(ref ojb, "dien_giai");
		txtGhi_chu = (TextBox)ojb;
		ojb = (Control)(object)cboNgoai_te;
		CreateDataBinding(ref ojb, "ma_nt", "selectedValue");
		cboNgoai_te = (AsComboBoxNT)(object)ojb;
		ojb = (Control)(object)txtTy_gia;
		CreateDataBinding(ref ojb, "ty_gia", "Value");
		txtTy_gia = (AsTextNumeric)(object)ojb;
	}

	protected override bool SetToRow()
	{
		base.SetToRow();
		if (!EditMode)
		{
			RowToEdit["stt_rec"] = Commons.Get_SttRec(base.MyMenuInfo.par1);
			RowToEdit["ma_ct"] = MyMenuInfo.par1;
			RowToEdit["stt_rec_tt"] = Commons.Get_SttRec(base.MyMenuInfo.par2);
			RowToEdit["ma_ct_tt"] = MyMenuInfo.par2;
			RowToEdit["ten_kh"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(lblTen_kh.Text, isNum: false));
		}
		bool result = default(bool);
		return result;
	}

	protected override bool ValidData()
	{
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		bLoading = true;
		ClearError();
		CalVND();
		if (Operators.CompareString(((TextBox)txtMa_kh).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtMa_kh, Helper.GetMess(50002).Description);
			((Control)txtMa_kh).Focus();
			return false;
		}
		if (Operators.CompareString(((TextBox)txtTK_pt).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtTK_pt, Helper.GetMess(50002).Description);
			((Control)txtTK_pt).Focus();
			return false;
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(txtNgay_ct.Value, (object)new DateTime(599266080000000000L), false), (object)(DateAndTime.Year(Conversions.ToDate(txtNgay_ct.Value)) > SystemInformations.FinancialYear))))
		{
			epNotice.SetError((Control)(object)txtNgay_ct, Helper.GetMessContent(50013));
			((Control)txtNgay_ct).Focus();
			return false;
		}
		if (Operators.ConditionalCompareObjectLessEqual(txtNgay_ct.Value, (object)AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks, false))
		{
			CMessageBox.Show(50136);
			return false;
		}
		if (Operators.CompareString(txtSo_ct_tt.Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtSo_ct_tt, Helper.GetMess(50002).Description);
			return false;
		}
		epNotice.SetError((Control)(object)txtSo_ct_tt, "");
		if (!CanhBaoDieuChinh())
		{
			return false;
		}
		return base.ValidData();
	}

	private void CalVND()
	{
		if (!bLoading)
		{
			txtTien_hang.Value = Operators.MultiplyObject(txtTien_hang_nt.Value, txtTy_gia.Value);
			txtTien_thue.Value = Operators.MultiplyObject(txtTien_thue_nt.Value, txtTy_gia.Value);
			txtTien_tt.Value = Operators.MultiplyObject(txtTien_tt_nt.Value, txtTy_gia.Value);
		}
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
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCPrice_Input_Format;
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

	protected void InitControl(bool bShow)
	{
		string text = ((ComboBox)cboNgoai_te).Text;
		lblT_tien_nt2.Text = f_sTienHang + " " + text;
		lblT_thue_nt.Text = f_sTienThue + " " + text;
		lblT_tt_nt.Text = f_sTongThanhToan + " " + text;
		lblTien_tt_nt.Text = f_sDaThanhToan + " " + text;
		lblDu_tt_nt.Text = f_sConPhaiThanhToan + " " + text;
		((Control)txtTien_hang).Visible = bShow;
		((Control)txtTien_thue).Visible = bShow;
		((Control)txtTong_tt).Visible = bShow;
		((Control)txtTien_tt).Visible = bShow;
		((Control)txtDu_hd).Visible = bShow;
		((Control)lblT_Tien2).Visible = bShow;
		((Control)lblT_thue).Visible = bShow;
		((Control)lblT_tt).Visible = bShow;
		((Control)lblTien_tt).Visible = bShow;
		((Control)lblDu_tt).Visible = bShow;
	}

	protected void AutoIns()
	{
		if (Operators.CompareString(((ComboBox)cboNgoai_te).Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			RowToEdit["t_tien2"] = RuntimeHelpers.GetObjectValue(txtTien_hang_nt.Value);
			RowToEdit["t_thue"] = RuntimeHelpers.GetObjectValue(txtTien_thue_nt.Value);
			RowToEdit["t_tt"] = RuntimeHelpers.GetObjectValue(txtTong_tt_nt.Value);
			RowToEdit["tien_tt"] = RuntimeHelpers.GetObjectValue(txtTien_tt_nt.Value);
			RowToEdit["du_hd"] = RuntimeHelpers.GetObjectValue(txtDu_hd.Value);
		}
	}

	private bool CanhBaoDieuChinh()
	{
		if (Conversions.ToDouble(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh) == 0.0)
		{
			return true;
		}
		checked
		{
			int num = (int)Math.Round(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_gia_toi_da);
			int num2 = (int)Math.Round(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_tien_nt_toi_da);
			bool flag = false;
			if (Operators.CompareString(((ComboBox)cboNgoai_te).Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.SubtractObject(txtTong_tt_nt.Value, txtTien_hang_nt.Value), txtTien_thue_nt.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTong_tt_nt, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTong_tt_nt, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.AddObject(Operators.SubtractObject(txtDu_hd_nt.Value, txtTong_tt_nt.Value), txtTien_tt_nt.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtDu_hd_nt, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtDu_hd_nt, "");
				}
			}
			else
			{
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.SubtractObject(txtTong_tt_nt.Value, txtTien_hang_nt.Value), txtTien_thue_nt.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num2, false))
				{
					epNotice.SetError((Control)(object)txtTong_tt_nt, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTong_tt_nt, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.AddObject(Operators.SubtractObject(txtDu_hd_nt.Value, txtTong_tt_nt.Value), txtTien_tt_nt.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num2, false))
				{
					epNotice.SetError((Control)(object)txtDu_hd_nt, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtDu_hd_nt, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(txtTien_hang.Value, Operators.MultiplyObject(txtTien_hang_nt.Value, txtTy_gia.Value)) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTien_hang, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTien_hang, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(txtTien_thue.Value, Operators.MultiplyObject(txtTien_thue_nt.Value, txtTy_gia.Value)) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTien_thue, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTien_thue, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.SubtractObject(txtTong_tt.Value, txtTien_hang.Value), txtTien_thue.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTong_tt, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTong_tt, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(txtTien_tt.Value, Operators.MultiplyObject(txtTien_tt_nt.Value, txtTy_gia.Value)) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTien_tt, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTien_tt, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.AddObject(Operators.SubtractObject(txtDu_hd.Value, txtTong_tt.Value), txtTien_tt.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtDu_hd, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtDu_hd, "");
				}
			}
			if (flag)
			{
				return Commons.ProcessAdjustOver();
			}
			return true;
		}
	}

	private void frmARTTEdit_Load(object sender, EventArgs e)
	{
		if (!EditMode)
		{
			txtNgay_ct_tt.Value = DateAndTime.Now.Date;
			txtNgay_ct.Value = DateAndTime.Now.Date;
		}
		if (Operators.CompareString(((ComboBox)cboNgoai_te).Text, "VND", false) == 0)
		{
			txtTy_gia.Value = "1.00";
			((TextBoxBase)txtTy_gia).ReadOnly = true;
		}
		else if (!EditMode)
		{
			txtTy_gia.Value = Commons.Get_TyGia(((ComboBox)cboNgoai_te).Text, Conversions.ToDate(txtNgay_ct.Value));
			((TextBoxBase)txtTy_gia).ReadOnly = false;
		}
	}

	private void cboNT_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ComboBox)cboNgoai_te).Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			txtTy_gia.Value = "1.00";
			((TextBoxBase)txtTy_gia).ReadOnly = true;
			InitControl(bShow: false);
			((Control)txtTien_hang_nt).Tag = "OA";
			((Control)txtTien_thue_nt).Tag = "OA";
			((Control)txtTong_tt_nt).Tag = "OA";
			((Control)txtTien_tt_nt).Tag = "OA";
			((Control)txtDu_hd_nt).Tag = "OA";
		}
		else
		{
			if (!bLoading)
			{
				txtTy_gia.Value = Commons.Get_TyGia(((ComboBox)cboNgoai_te).Text, Conversions.ToDate(txtNgay_ct.Value));
			}
			((TextBoxBase)txtTy_gia).ReadOnly = false;
			InitControl(bShow: true);
			((Control)txtTien_hang_nt).Tag = "FA";
			((Control)txtTien_thue_nt).Tag = "FA";
			((Control)txtTong_tt_nt).Tag = "FA";
			((Control)txtTien_tt_nt).Tag = "FA";
			((Control)txtDu_hd_nt).Tag = "FA";
			((Control)txtTien_hang).Tag = "OA";
			((Control)txtTien_thue).Tag = "OA";
			((Control)txtTong_tt).Tag = "OA";
			((Control)txtTien_tt).Tag = "OA";
			((Control)txtDu_hd).Tag = "OA";
		}
		CalVND();
		MaskTextBoxAll(((Control)gbD).Controls);
	}

	private void TongNT_TextChanged(object sender, EventArgs e)
	{
		if (!bLoading)
		{
			txtTong_tt.Value = Operators.AddObject(txtTien_hang.Value, txtTien_thue.Value);
			txtDu_hd.Value = Operators.SubtractObject(txtTong_tt.Value, txtTien_tt.Value);
		}
	}

	private void DuNT_TextChanged(object sender, EventArgs e)
	{
		if (!bLoading)
		{
			txtDu_hd.Value = Operators.SubtractObject(txtTong_tt.Value, txtTien_tt.Value);
		}
	}

	private void TongVND_TextChanged(object sender, EventArgs e)
	{
		if (!bLoading)
		{
			txtTong_tt_nt.Value = Operators.AddObject(txtTien_hang_nt.Value, txtTien_thue_nt.Value);
			txtDu_hd_nt.Value = Operators.SubtractObject(txtTong_tt_nt.Value, txtTien_tt_nt.Value);
			CalVND();
		}
	}

	private void DuVND_TextChanged(object sender, EventArgs e)
	{
		if (!bLoading)
		{
			txtDu_hd_nt.Value = Operators.SubtractObject(txtTong_tt_nt.Value, txtTien_tt_nt.Value);
			CalVND();
		}
	}

	private void txtMa_tt_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (((TextBox)txtMa_tt).Text.Trim().Length > 0)
		{
			txtHan_tt.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["han_tt"]);
			txtHan_ck.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["han_ck"]);
			txtLS_qh.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ls_qh"]);
			txtTL_ck.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["tl_ck"]);
		}
		else
		{
			txtHan_tt.Value = 0;
			txtHan_ck.Value = 0;
			txtLS_qh.Value = 0;
			txtTL_ck.Value = 0;
		}
	}

	private void frmARTTEdit_Activated(object sender, EventArgs e)
	{
		if (bLoading)
		{
			cboNT_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			bLoading = false;
		}
	}

	private void txtMa_tt_Validated(object sender, EventArgs e)
	{
		if (!EditMode)
		{
			DateTime dateTime = Conversions.ToDate(txtNgay_ct.Value);
			txtngay_tt.Value = dateTime.AddDays(Conversions.ToDouble(txtHan_tt.Value));
		}
	}
}
