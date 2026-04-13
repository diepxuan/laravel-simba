using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmINDMVTEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lbTen_vt")]
	private Label _lbTen_vt;

	[AccessedThroughProperty("lblMa_Vt")]
	private Label _lblMa_Vt;

	[AccessedThroughProperty("lblMa_Nhvt")]
	private Label _lblMa_Nhvt;

	[AccessedThroughProperty("lblDvt")]
	private Label _lblDvt;

	[AccessedThroughProperty("txtTen_Vt")]
	private TextBox _txtTen_Vt;

	[AccessedThroughProperty("txtMa_Vt")]
	private TextBox _txtMa_Vt;

	[AccessedThroughProperty("cboGia_ton")]
	private ComboBox _cboGia_ton;

	[AccessedThroughProperty("lblGia_ton")]
	private Label _lblGia_ton;

	[AccessedThroughProperty("cboLoai")]
	private ComboBox _cboLoai;

	[AccessedThroughProperty("lblLoai")]
	private Label _lblLoai;

	[AccessedThroughProperty("lblTen_NhVt")]
	private Label _lblTen_NhVt;

	[AccessedThroughProperty("txtMa_Nhvt")]
	private AsTextBox _txtMa_Nhvt;

	[AccessedThroughProperty("cboDvt")]
	private ComboBox _cboDvt;

	[AccessedThroughProperty("chkTon_kho")]
	private AsCheckBox _chkTon_kho;

	[AccessedThroughProperty("txtMa_nhvat")]
	private AsTextBox _txtMa_nhvat;

	[AccessedThroughProperty("lblTen_NhVat")]
	private Label _lblTen_NhVat;

	[AccessedThroughProperty("lblMa_NhVat")]
	private Label _lblMa_NhVat;

	[AccessedThroughProperty("lblTen_Tk_Ck")]
	private Label _lblTen_Tk_Ck;

	[AccessedThroughProperty("lblTen_Tk_tl")]
	private Label _lblTen_Tk_tl;

	[AccessedThroughProperty("lblTen_Tk_gv")]
	private Label _lblTen_Tk_gv;

	[AccessedThroughProperty("lblTen_Tk_Dtnb")]
	private Label _lblTen_Tk_Dtnb;

	[AccessedThroughProperty("lblTen_Tk_Dt")]
	private Label _lblTen_Tk_Dt;

	[AccessedThroughProperty("lblTen_Tk_Vt")]
	private Label _lblTen_Tk_Vt;

	[AccessedThroughProperty("txtTk_Ck")]
	private AsTextBox _txtTk_Ck;

	[AccessedThroughProperty("lblTk_Ck")]
	private Label _lblTk_Ck;

	[AccessedThroughProperty("txtTk_Tl")]
	private AsTextBox _txtTk_Tl;

	[AccessedThroughProperty("lblTk_Tl")]
	private Label _lblTk_Tl;

	[AccessedThroughProperty("txtTk_Gv")]
	private AsTextBox _txtTk_Gv;

	[AccessedThroughProperty("lblTk_Gv")]
	private Label _lblTk_Gv;

	[AccessedThroughProperty("txtTk_DtNb")]
	private AsTextBox _txtTk_DtNb;

	[AccessedThroughProperty("lblTk_DtNb")]
	private Label _lblTk_DtNb;

	[AccessedThroughProperty("txtTk_Dt")]
	private AsTextBox _txtTk_Dt;

	[AccessedThroughProperty("lblTk_Dt")]
	private Label _lblTk_Dt;

	[AccessedThroughProperty("txtTk_Vt")]
	private AsTextBox _txtTk_Vt;

	[AccessedThroughProperty("lblTk_Vt")]
	private Label _lblTk_Vt;

	[AccessedThroughProperty("txtTs_ttdb")]
	private AsTextNumeric _txtTs_ttdb;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblTs_Gtgt")]
	private Label _lblTs_Gtgt;

	[AccessedThroughProperty("txtTs_Xk")]
	private AsTextNumeric _txtTs_Xk;

	[AccessedThroughProperty("lblTs_Xk")]
	private Label _lblTs_Xk;

	[AccessedThroughProperty("txtTs_Nk")]
	private AsTextNumeric _txtTs_Nk;

	[AccessedThroughProperty("lblTs_Nk")]
	private Label _lblTs_Nk;

	[AccessedThroughProperty("txtSl_max")]
	private AsTextNumeric _txtSl_max;

	[AccessedThroughProperty("lblSl_max")]
	private Label _lblSl_max;

	[AccessedThroughProperty("txtSl_min")]
	private AsTextNumeric _txtSl_min;

	[AccessedThroughProperty("lblSl_min")]
	private Label _lblSl_min;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblTen_Kho")]
	private Label _lblTen_Kho;

	[AccessedThroughProperty("lblMa_thue")]
	private Label _lblMa_thue;

	[AccessedThroughProperty("txtMa_Thue")]
	private AsTextBox _txtMa_Thue;

	[AccessedThroughProperty("txtTs_Gtgt")]
	private AsTextNumeric _txtTs_Gtgt;

	[AccessedThroughProperty("txtHs_dvtban")]
	private AsTextNumeric _txtHs_dvtban;

	[AccessedThroughProperty("txtHs_dvtmua")]
	private AsTextNumeric _txtHs_dvtmua;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("cboDvt_ban")]
	private AsComboBox _cboDvt_ban;

	[AccessedThroughProperty("cboDvt_mua")]
	private AsComboBox _cboDvt_mua;

	[AccessedThroughProperty("txtGia_nt2")]
	private AsTextNumeric _txtGia_nt2;

	[AccessedThroughProperty("lblGia_ban")]
	private Label _lblGia_ban;

	[AccessedThroughProperty("txtGia_nt0")]
	private AsTextNumeric _txtGia_nt0;

	[AccessedThroughProperty("lblGia_mua")]
	private Label _lblGia_mua;

	internal virtual Label lbTen_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbTen_vt = value;
		}
	}

	internal virtual Label lblMa_Vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Vt = value;
		}
	}

	internal virtual Label lblMa_Nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nhvt = value;
		}
	}

	internal virtual Label lblDvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDvt = value;
		}
	}

	internal virtual TextBox txtTen_Vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Vt = value;
		}
	}

	internal virtual TextBox txtMa_Vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Vt = value;
		}
	}

	internal virtual ComboBox cboGia_ton
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboGia_ton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboGia_ton = value;
		}
	}

	internal virtual Label lblGia_ton
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGia_ton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGia_ton = value;
		}
	}

	internal virtual ComboBox cboLoai
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboLoai_SelectedValueChanged;
			if (_cboLoai != null)
			{
				((ListControl)_cboLoai).SelectedValueChanged -= eventHandler;
			}
			_cboLoai = value;
			if (_cboLoai != null)
			{
				((ListControl)_cboLoai).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblLoai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai = value;
		}
	}

	internal virtual Label lblTen_NhVt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_NhVt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_NhVt = value;
		}
	}

	internal virtual AsTextBox txtMa_Nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_Nhvt_AfterCodeValidating;
			if (_txtMa_Nhvt != null)
			{
				_txtMa_Nhvt.AfterCodeValidating -= obj;
			}
			_txtMa_Nhvt = value;
			if (_txtMa_Nhvt != null)
			{
				_txtMa_Nhvt.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual ComboBox cboDvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboDvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboDvt = value;
		}
	}

	internal virtual AsCheckBox chkTon_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkTon_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkTon_kho = value;
		}
	}

	internal virtual AsTextBox txtMa_nhvat
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhvat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhvat = value;
		}
	}

	internal virtual Label lblTen_NhVat
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_NhVat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_NhVat = value;
		}
	}

	internal virtual Label lblMa_NhVat
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_NhVat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_NhVat = value;
		}
	}

	internal virtual Label lblTen_Tk_Ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_Ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_Ck = value;
		}
	}

	internal virtual Label lblTen_Tk_tl
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_tl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_tl = value;
		}
	}

	internal virtual Label lblTen_Tk_gv
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_gv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_gv = value;
		}
	}

	internal virtual Label lblTen_Tk_Dtnb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_Dtnb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_Dtnb = value;
		}
	}

	internal virtual Label lblTen_Tk_Dt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_Dt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_Dt = value;
		}
	}

	internal virtual Label lblTen_Tk_Vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_Vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_Vt = value;
		}
	}

	internal virtual AsTextBox txtTk_Ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Ck = value;
		}
	}

	internal virtual Label lblTk_Ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Ck = value;
		}
	}

	internal virtual AsTextBox txtTk_Tl
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Tl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Tl = value;
		}
	}

	internal virtual Label lblTk_Tl
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Tl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Tl = value;
		}
	}

	internal virtual AsTextBox txtTk_Gv
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Gv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Gv = value;
		}
	}

	internal virtual Label lblTk_Gv
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Gv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Gv = value;
		}
	}

	internal virtual AsTextBox txtTk_DtNb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_DtNb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_DtNb = value;
		}
	}

	internal virtual Label lblTk_DtNb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_DtNb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_DtNb = value;
		}
	}

	internal virtual AsTextBox txtTk_Dt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Dt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Dt = value;
		}
	}

	internal virtual Label lblTk_Dt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Dt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Dt = value;
		}
	}

	internal virtual AsTextBox txtTk_Vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Vt = value;
		}
	}

	internal virtual Label lblTk_Vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Vt = value;
		}
	}

	internal virtual AsTextNumeric txtTs_ttdb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTs_ttdb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTs_ttdb = value;
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

	internal virtual Label lblTs_Gtgt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTs_Gtgt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTs_Gtgt = value;
		}
	}

	internal virtual AsTextNumeric txtTs_Xk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTs_Xk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTs_Xk = value;
		}
	}

	internal virtual Label lblTs_Xk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTs_Xk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTs_Xk = value;
		}
	}

	internal virtual AsTextNumeric txtTs_Nk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTs_Nk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTs_Nk = value;
		}
	}

	internal virtual Label lblTs_Nk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTs_Nk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTs_Nk = value;
		}
	}

	internal virtual AsTextNumeric txtSl_max
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSl_max;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSl_max = value;
		}
	}

	internal virtual Label lblSl_max
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSl_max;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSl_max = value;
		}
	}

	internal virtual AsTextNumeric txtSl_min
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSl_min;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSl_min = value;
		}
	}

	internal virtual Label lblSl_min
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSl_min;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSl_min = value;
		}
	}

	internal virtual Label lblMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kho = value;
		}
	}

	internal virtual AsTextBox txtMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kho = value;
		}
	}

	internal virtual Label lblTen_Kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Kho = value;
		}
	}

	internal virtual Label lblMa_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_thue = value;
		}
	}

	internal virtual AsTextBox txtMa_Thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Thue = value;
		}
	}

	internal virtual AsTextNumeric txtTs_Gtgt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTs_Gtgt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTs_Gtgt = value;
		}
	}

	internal virtual AsTextNumeric txtHs_dvtban
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHs_dvtban;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtHs_dvtban = value;
		}
	}

	internal virtual AsTextNumeric txtHs_dvtmua
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHs_dvtmua;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtHs_dvtmua = value;
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

	internal virtual AsComboBox cboDvt_ban
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboDvt_ban;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboDvt_ban = value;
		}
	}

	internal virtual AsComboBox cboDvt_mua
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboDvt_mua;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboDvt_mua = value;
		}
	}

	internal virtual AsTextNumeric txtGia_nt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGia_nt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGia_nt2 = value;
		}
	}

	internal virtual Label lblGia_ban
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGia_ban;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGia_ban = value;
		}
	}

	internal virtual AsTextNumeric txtGia_nt0
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGia_nt0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGia_nt0 = value;
		}
	}

	internal virtual Label lblGia_mua
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGia_mua;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGia_mua = value;
		}
	}

	[DebuggerNonUserCode]
	public frmINDMVTEdit()
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		lblMa_thue = new Label();
		txtMa_Thue = new AsTextBox();
		txtTs_ttdb = new AsTextNumeric();
		Label1 = new Label();
		txtTs_Xk = new AsTextNumeric();
		lblTs_Xk = new Label();
		txtTs_Nk = new AsTextNumeric();
		lblTs_Nk = new Label();
		lblTen_Tk_Ck = new Label();
		lblTen_Tk_tl = new Label();
		lblTen_Tk_gv = new Label();
		lblTen_Tk_Dtnb = new Label();
		lblTen_Tk_Dt = new Label();
		lblTen_Tk_Vt = new Label();
		txtTk_Ck = new AsTextBox();
		lblTk_Ck = new Label();
		txtTk_Tl = new AsTextBox();
		lblTk_Tl = new Label();
		txtTk_Gv = new AsTextBox();
		lblTk_Gv = new Label();
		txtTk_DtNb = new AsTextBox();
		lblTk_DtNb = new Label();
		txtTk_Dt = new AsTextBox();
		lblTk_Dt = new Label();
		txtTk_Vt = new AsTextBox();
		lblTk_Vt = new Label();
		txtTs_Gtgt = new AsTextNumeric();
		lblTs_Gtgt = new Label();
		txtSl_max = new AsTextNumeric();
		lblSl_max = new Label();
		txtSl_min = new AsTextNumeric();
		lblSl_min = new Label();
		Label5 = new Label();
		Label4 = new Label();
		txtHs_dvtban = new AsTextNumeric();
		txtHs_dvtmua = new AsTextNumeric();
		chkTon_kho = new AsCheckBox();
		cboDvt = new ComboBox();
		txtMa_Nhvt = new AsTextBox();
		lblTen_NhVt = new Label();
		cboGia_ton = new ComboBox();
		lblGia_ton = new Label();
		cboLoai = new ComboBox();
		lblLoai = new Label();
		lblDvt = new Label();
		lblMa_Nhvt = new Label();
		lbTen_vt = new Label();
		lblMa_Vt = new Label();
		txtMa_Vt = new TextBox();
		txtTen_Vt = new TextBox();
		lblMa_NhVat = new Label();
		lblTen_NhVat = new Label();
		txtMa_nhvat = new AsTextBox();
		txtMa_kho = new AsTextBox();
		lblTen_Kho = new Label();
		lblMa_kho = new Label();
		cboDvt_mua = new AsComboBox();
		cboDvt_ban = new AsComboBox();
		txtGia_nt2 = new AsTextNumeric();
		lblGia_ban = new Label();
		txtGia_nt0 = new AsTextNumeric();
		lblGia_mua = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(119, 347);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 26;
		((CheckBox)chkKsd).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(86, 387);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(5, 387);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Anchor = (AnchorStyles)13;
		((Control)gbLine).Controls.Add((Control)(object)txtGia_nt2);
		((Control)gbLine).Controls.Add((Control)(object)lblGia_ban);
		((Control)gbLine).Controls.Add((Control)(object)txtGia_nt0);
		((Control)gbLine).Controls.Add((Control)(object)lblGia_mua);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_thue);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Thue);
		((Control)gbLine).Controls.Add((Control)(object)txtTs_ttdb);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtTs_Xk);
		((Control)gbLine).Controls.Add((Control)(object)lblTs_Xk);
		((Control)gbLine).Controls.Add((Control)(object)txtTs_Nk);
		((Control)gbLine).Controls.Add((Control)(object)lblTs_Nk);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_Ck);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_tl);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_gv);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_Dtnb);
		((Control)gbLine).Controls.Add((Control)(object)txtSl_max);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_Dt);
		((Control)gbLine).Controls.Add((Control)(object)lblSl_max);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_Vt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_kho);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Ck);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Ck);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_kho);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Tl);
		((Control)gbLine).Controls.Add((Control)(object)txtSl_min);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Tl);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Gv);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Gv);
		((Control)gbLine).Controls.Add((Control)(object)lblSl_min);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_DtNb);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_DtNb);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Dt);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Dt);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Vt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Kho);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Vt);
		((Control)gbLine).Controls.Add((Control)(object)lblLoai);
		((Control)gbLine).Controls.Add((Control)(object)cboDvt_ban);
		((Control)gbLine).Controls.Add((Control)(object)cboLoai);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Vt);
		((Control)gbLine).Controls.Add((Control)(object)chkTon_kho);
		((Control)gbLine).Controls.Add((Control)(object)cboDvt_mua);
		((Control)gbLine).Controls.Add((Control)(object)lbTen_vt);
		((Control)gbLine).Controls.Add((Control)(object)txtHs_dvtban);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Vt);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Vt);
		((Control)gbLine).Controls.Add((Control)(object)cboDvt);
		((Control)gbLine).Controls.Add((Control)(object)lblDvt);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Nhvt);
		((Control)gbLine).Controls.Add((Control)(object)cboGia_ton);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Nhvt);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)lblGia_ton);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_NhVt);
		((Control)gbLine).Controls.Add((Control)(object)txtHs_dvtmua);
		GroupBox obj3 = gbLine;
		location = new Point(6, -2);
		((Control)obj3).Location = location;
		GroupBox obj4 = gbLine;
		Size size = new Size(745, 381);
		((Control)obj4).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtHs_dvtmua, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_NhVt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGia_ton, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Nhvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboGia_ton, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Nhvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboDvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtHs_dvtban, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lbTen_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboDvt_mua, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkTon_kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboDvt_ban, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblLoai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Dt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Dt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_DtNb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_DtNb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSl_min, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Gv, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Gv, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Tl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSl_min, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Tl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_Vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSl_max, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_Dt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSl_max, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_Dtnb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_gv, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_tl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_Ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTs_Nk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTs_Nk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTs_Xk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTs_Xk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTs_ttdb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGia_mua, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGia_nt0, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGia_ban, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGia_nt2, 0);
		lblMa_thue.AutoSize = true;
		lblMa_thue.ImeMode = (ImeMode)0;
		Label obj5 = lblMa_thue;
		location = new Point(521, 167);
		((Control)obj5).Location = location;
		((Control)lblMa_thue).Name = "lblMa_thue";
		Label obj6 = lblMa_thue;
		size = new Size(88, 13);
		((Control)obj6).Size = size;
		((Control)lblMa_thue).TabIndex = 257;
		lblMa_thue.Text = "Thuế suất GTGT";
		lblMa_thue.TextAlign = (ContentAlignment)16;
		txtMa_Thue.AutoLookup = true;
		txtMa_Thue.AutoValid = true;
		((TextBoxBase)txtMa_Thue).BackColor = SystemColors.Info;
		((TextBox)txtMa_Thue).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Thue;
		location = new Point(663, 163);
		((Control)asTextBox).Location = location;
		txtMa_Thue.LookupCodeName = "MA_THUE";
		((Control)txtMa_Thue).Name = "txtMa_Thue";
		txtMa_Thue.NameControl = null;
		txtMa_Thue.SD = true;
		AsTextBox asTextBox2 = txtMa_Thue;
		size = new Size(65, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Thue).TabIndex = 18;
		((TextBox)txtMa_Thue).TextAlign = (HorizontalAlignment)1;
		txtMa_Thue.UseAutoCompleteSource = true;
		txtTs_ttdb.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTs_ttdb;
		location = new Point(663, 215);
		((Control)asTextNumeric).Location = location;
		txtTs_ttdb.Mask = "### ### ### ###.##";
		((Control)txtTs_ttdb).Name = "txtTs_ttdb";
		AsTextNumeric asTextNumeric2 = txtTs_ttdb;
		size = new Size(65, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTs_ttdb).TabIndex = 20;
		((TextBox)txtTs_ttdb).Text = "0.00";
		((TextBox)txtTs_ttdb).TextAlign = (HorizontalAlignment)1;
		txtTs_ttdb.Value = 0.0;
		Label1.AutoSize = true;
		Label1.ImeMode = (ImeMode)0;
		Label label = Label1;
		location = new Point(521, 219);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(87, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 255;
		Label1.Text = "Thuế suất TTĐB";
		Label1.TextAlign = (ContentAlignment)16;
		txtTs_Xk.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric3 = txtTs_Xk;
		location = new Point(663, 241);
		((Control)asTextNumeric3).Location = location;
		txtTs_Xk.Mask = "### ### ### ###.##";
		((Control)txtTs_Xk).Name = "txtTs_Xk";
		AsTextNumeric asTextNumeric4 = txtTs_Xk;
		size = new Size(65, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtTs_Xk).TabIndex = 21;
		((TextBox)txtTs_Xk).Text = "0.00";
		((TextBox)txtTs_Xk).TextAlign = (HorizontalAlignment)1;
		txtTs_Xk.Value = 0.0;
		lblTs_Xk.AutoSize = true;
		lblTs_Xk.ImeMode = (ImeMode)0;
		Label obj7 = lblTs_Xk;
		location = new Point(521, 245);
		((Control)obj7).Location = location;
		((Control)lblTs_Xk).Name = "lblTs_Xk";
		Label obj8 = lblTs_Xk;
		size = new Size(72, 13);
		((Control)obj8).Size = size;
		((Control)lblTs_Xk).TabIndex = 252;
		lblTs_Xk.Text = "Thuế suất XK";
		lblTs_Xk.TextAlign = (ContentAlignment)16;
		txtTs_Nk.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric5 = txtTs_Nk;
		location = new Point(663, 189);
		((Control)asTextNumeric5).Location = location;
		txtTs_Nk.Mask = "### ### ### ###.##";
		((Control)txtTs_Nk).Name = "txtTs_Nk";
		AsTextNumeric asTextNumeric6 = txtTs_Nk;
		size = new Size(65, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtTs_Nk).TabIndex = 19;
		((TextBox)txtTs_Nk).Text = "0.00";
		((TextBox)txtTs_Nk).TextAlign = (HorizontalAlignment)1;
		txtTs_Nk.Value = 0.0;
		lblTs_Nk.AutoSize = true;
		lblTs_Nk.ImeMode = (ImeMode)0;
		Label obj9 = lblTs_Nk;
		location = new Point(521, 193);
		((Control)obj9).Location = location;
		((Control)lblTs_Nk).Name = "lblTs_Nk";
		Label obj10 = lblTs_Nk;
		size = new Size(73, 13);
		((Control)obj10).Size = size;
		((Control)lblTs_Nk).TabIndex = 251;
		lblTs_Nk.Text = "Thuế suất NK";
		lblTs_Nk.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Tk_Ck).Anchor = (AnchorStyles)13;
		lblTen_Tk_Ck.AutoSize = true;
		lblTen_Tk_Ck.ImeMode = (ImeMode)0;
		Label obj11 = lblTen_Tk_Ck;
		location = new Point(215, 271);
		((Control)obj11).Location = location;
		((Control)lblTen_Tk_Ck).Name = "lblTen_Tk_Ck";
		Label obj12 = lblTen_Tk_Ck;
		size = new Size(96, 13);
		((Control)obj12).Size = size;
		((Control)lblTen_Tk_Ck).TabIndex = 216;
		lblTen_Tk_Ck.Text = "Tên TK chiết khấu";
		lblTen_Tk_Ck.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Tk_tl).Anchor = (AnchorStyles)13;
		lblTen_Tk_tl.AutoSize = true;
		lblTen_Tk_tl.ImeMode = (ImeMode)0;
		Label obj13 = lblTen_Tk_tl;
		location = new Point(215, 297);
		((Control)obj13).Location = location;
		((Control)lblTen_Tk_tl).Name = "lblTen_Tk_tl";
		Label obj14 = lblTen_Tk_tl;
		size = new Size(71, 13);
		((Control)obj14).Size = size;
		((Control)lblTen_Tk_tl).TabIndex = 215;
		lblTen_Tk_tl.Text = "Tên TK trả lại";
		lblTen_Tk_tl.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Tk_gv).Anchor = (AnchorStyles)13;
		lblTen_Tk_gv.AutoSize = true;
		lblTen_Tk_gv.ImeMode = (ImeMode)0;
		Label obj15 = lblTen_Tk_gv;
		location = new Point(215, 245);
		((Control)obj15).Location = location;
		((Control)lblTen_Tk_gv).Name = "lblTen_Tk_gv";
		Label obj16 = lblTen_Tk_gv;
		size = new Size(81, 13);
		((Control)obj16).Size = size;
		((Control)lblTen_Tk_gv).TabIndex = 214;
		lblTen_Tk_gv.Text = "Tên TK giá vốn";
		lblTen_Tk_gv.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Tk_Dtnb).Anchor = (AnchorStyles)13;
		lblTen_Tk_Dtnb.AutoSize = true;
		lblTen_Tk_Dtnb.ImeMode = (ImeMode)0;
		Label obj17 = lblTen_Tk_Dtnb;
		location = new Point(215, 323);
		((Control)obj17).Location = location;
		((Control)lblTen_Tk_Dtnb).Name = "lblTen_Tk_Dtnb";
		Label obj18 = lblTen_Tk_Dtnb;
		size = new Size(93, 13);
		((Control)obj18).Size = size;
		((Control)lblTen_Tk_Dtnb).TabIndex = 213;
		lblTen_Tk_Dtnb.Text = "Tên TK DT nội bộ";
		lblTen_Tk_Dtnb.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Tk_Dt).Anchor = (AnchorStyles)13;
		lblTen_Tk_Dt.AutoSize = true;
		lblTen_Tk_Dt.ImeMode = (ImeMode)0;
		Label obj19 = lblTen_Tk_Dt;
		location = new Point(215, 219);
		((Control)obj19).Location = location;
		((Control)lblTen_Tk_Dt).Name = "lblTen_Tk_Dt";
		Label obj20 = lblTen_Tk_Dt;
		size = new Size(94, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_Tk_Dt).TabIndex = 212;
		lblTen_Tk_Dt.Text = "Tên TK doanh thu";
		lblTen_Tk_Dt.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Tk_Vt).Anchor = (AnchorStyles)13;
		lblTen_Tk_Vt.AutoSize = true;
		lblTen_Tk_Vt.ImeMode = (ImeMode)0;
		Label obj21 = lblTen_Tk_Vt;
		location = new Point(215, 193);
		((Control)obj21).Location = location;
		((Control)lblTen_Tk_Vt).Name = "lblTen_Tk_Vt";
		Label obj22 = lblTen_Tk_Vt;
		size = new Size(73, 13);
		((Control)obj22).Size = size;
		((Control)lblTen_Tk_Vt).TabIndex = 211;
		lblTen_Tk_Vt.Text = "Tên TK vật tư";
		lblTen_Tk_Vt.TextAlign = (ContentAlignment)16;
		((Control)txtTk_Ck).Anchor = (AnchorStyles)7;
		txtTk_Ck.AutoLookup = true;
		txtTk_Ck.AutoValid = true;
		((TextBoxBase)txtTk_Ck).BackColor = SystemColors.Info;
		((TextBox)txtTk_Ck).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk_Ck;
		location = new Point(119, 267);
		((Control)asTextBox3).Location = location;
		txtTk_Ck.LookupCodeName = "TK";
		txtTk_Ck.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Ck).Name = "txtTk_Ck";
		txtTk_Ck.NameControl = lblTen_Tk_Ck;
		txtTk_Ck.SD = true;
		AsTextBox asTextBox4 = txtTk_Ck;
		size = new Size(90, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk_Ck).TabIndex = 15;
		txtTk_Ck.UseAutoCompleteSource = true;
		((Control)lblTk_Ck).Anchor = (AnchorStyles)7;
		lblTk_Ck.AutoSize = true;
		lblTk_Ck.ImeMode = (ImeMode)0;
		Label obj23 = lblTk_Ck;
		location = new Point(17, 271);
		((Control)obj23).Location = location;
		((Control)lblTk_Ck).Name = "lblTk_Ck";
		Label obj24 = lblTk_Ck;
		size = new Size(74, 13);
		((Control)obj24).Size = size;
		((Control)lblTk_Ck).TabIndex = 179;
		lblTk_Ck.Text = "TK chiết khấu";
		lblTk_Ck.TextAlign = (ContentAlignment)16;
		((Control)txtTk_Tl).Anchor = (AnchorStyles)7;
		txtTk_Tl.AutoLookup = true;
		txtTk_Tl.AutoValid = true;
		((TextBoxBase)txtTk_Tl).BackColor = SystemColors.Info;
		((TextBox)txtTk_Tl).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTk_Tl;
		location = new Point(119, 293);
		((Control)asTextBox5).Location = location;
		txtTk_Tl.LookupCodeName = "TK";
		txtTk_Tl.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Tl).Name = "txtTk_Tl";
		txtTk_Tl.NameControl = lblTen_Tk_tl;
		txtTk_Tl.SD = true;
		AsTextBox asTextBox6 = txtTk_Tl;
		size = new Size(90, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTk_Tl).TabIndex = 16;
		txtTk_Tl.UseAutoCompleteSource = true;
		((Control)lblTk_Tl).Anchor = (AnchorStyles)7;
		lblTk_Tl.AutoSize = true;
		lblTk_Tl.ImeMode = (ImeMode)0;
		Label obj25 = lblTk_Tl;
		location = new Point(17, 297);
		((Control)obj25).Location = location;
		((Control)lblTk_Tl).Name = "lblTk_Tl";
		Label obj26 = lblTk_Tl;
		size = new Size(49, 13);
		((Control)obj26).Size = size;
		((Control)lblTk_Tl).TabIndex = 177;
		lblTk_Tl.Text = "TK trả lại";
		lblTk_Tl.TextAlign = (ContentAlignment)16;
		((Control)txtTk_Gv).Anchor = (AnchorStyles)7;
		txtTk_Gv.AutoLookup = true;
		txtTk_Gv.AutoValid = true;
		((TextBoxBase)txtTk_Gv).BackColor = SystemColors.Info;
		((TextBox)txtTk_Gv).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtTk_Gv;
		location = new Point(119, 241);
		((Control)asTextBox7).Location = location;
		txtTk_Gv.LookupCodeName = "TK";
		txtTk_Gv.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Gv).Name = "txtTk_Gv";
		txtTk_Gv.NameControl = lblTen_Tk_gv;
		txtTk_Gv.SD = true;
		AsTextBox asTextBox8 = txtTk_Gv;
		size = new Size(90, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtTk_Gv).TabIndex = 14;
		txtTk_Gv.UseAutoCompleteSource = true;
		((Control)lblTk_Gv).Anchor = (AnchorStyles)7;
		lblTk_Gv.AutoSize = true;
		lblTk_Gv.ImeMode = (ImeMode)0;
		Label obj27 = lblTk_Gv;
		location = new Point(17, 245);
		((Control)obj27).Location = location;
		((Control)lblTk_Gv).Name = "lblTk_Gv";
		Label obj28 = lblTk_Gv;
		size = new Size(59, 13);
		((Control)obj28).Size = size;
		((Control)lblTk_Gv).TabIndex = 175;
		lblTk_Gv.Text = "TK giá vốn";
		lblTk_Gv.TextAlign = (ContentAlignment)16;
		((Control)txtTk_DtNb).Anchor = (AnchorStyles)7;
		txtTk_DtNb.AutoLookup = true;
		txtTk_DtNb.AutoValid = true;
		((TextBoxBase)txtTk_DtNb).BackColor = SystemColors.Info;
		((TextBox)txtTk_DtNb).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtTk_DtNb;
		location = new Point(119, 319);
		((Control)asTextBox9).Location = location;
		txtTk_DtNb.LookupCodeName = "TK";
		txtTk_DtNb.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_DtNb).Name = "txtTk_DtNb";
		txtTk_DtNb.NameControl = lblTen_Tk_Dtnb;
		txtTk_DtNb.SD = true;
		AsTextBox asTextBox10 = txtTk_DtNb;
		size = new Size(90, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtTk_DtNb).TabIndex = 17;
		txtTk_DtNb.UseAutoCompleteSource = true;
		((Control)lblTk_DtNb).Anchor = (AnchorStyles)7;
		lblTk_DtNb.AutoSize = true;
		lblTk_DtNb.ImeMode = (ImeMode)0;
		Label obj29 = lblTk_DtNb;
		location = new Point(17, 323);
		((Control)obj29).Location = location;
		((Control)lblTk_DtNb).Name = "lblTk_DtNb";
		Label obj30 = lblTk_DtNb;
		size = new Size(71, 13);
		((Control)obj30).Size = size;
		((Control)lblTk_DtNb).TabIndex = 173;
		lblTk_DtNb.Text = "TK DT nội bộ";
		lblTk_DtNb.TextAlign = (ContentAlignment)16;
		((Control)txtTk_Dt).Anchor = (AnchorStyles)7;
		txtTk_Dt.AutoLookup = true;
		txtTk_Dt.AutoValid = true;
		((TextBoxBase)txtTk_Dt).BackColor = SystemColors.Info;
		((TextBox)txtTk_Dt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtTk_Dt;
		location = new Point(119, 215);
		((Control)asTextBox11).Location = location;
		txtTk_Dt.LookupCodeName = "TK";
		txtTk_Dt.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Dt).Name = "txtTk_Dt";
		txtTk_Dt.NameControl = lblTen_Tk_Dt;
		txtTk_Dt.SD = true;
		AsTextBox asTextBox12 = txtTk_Dt;
		size = new Size(90, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtTk_Dt).TabIndex = 13;
		txtTk_Dt.UseAutoCompleteSource = true;
		((Control)lblTk_Dt).Anchor = (AnchorStyles)7;
		lblTk_Dt.AutoSize = true;
		lblTk_Dt.ImeMode = (ImeMode)0;
		Label obj31 = lblTk_Dt;
		location = new Point(17, 219);
		((Control)obj31).Location = location;
		((Control)lblTk_Dt).Name = "lblTk_Dt";
		Label obj32 = lblTk_Dt;
		size = new Size(72, 13);
		((Control)obj32).Size = size;
		((Control)lblTk_Dt).TabIndex = 171;
		lblTk_Dt.Text = "TK doanh thu";
		lblTk_Dt.TextAlign = (ContentAlignment)16;
		((Control)txtTk_Vt).Anchor = (AnchorStyles)7;
		txtTk_Vt.AutoLookup = true;
		txtTk_Vt.AutoValid = true;
		((TextBoxBase)txtTk_Vt).BackColor = SystemColors.Info;
		((TextBox)txtTk_Vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox13 = txtTk_Vt;
		location = new Point(119, 189);
		((Control)asTextBox13).Location = location;
		txtTk_Vt.LookupCodeName = "TK";
		txtTk_Vt.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Vt).Name = "txtTk_Vt";
		txtTk_Vt.NameControl = lblTen_Tk_Vt;
		txtTk_Vt.SD = true;
		AsTextBox asTextBox14 = txtTk_Vt;
		size = new Size(90, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtTk_Vt).TabIndex = 12;
		txtTk_Vt.UseAutoCompleteSource = true;
		((Control)lblTk_Vt).Anchor = (AnchorStyles)7;
		lblTk_Vt.AutoSize = true;
		lblTk_Vt.ImeMode = (ImeMode)0;
		Label obj33 = lblTk_Vt;
		location = new Point(17, 193);
		((Control)obj33).Location = location;
		((Control)lblTk_Vt).Name = "lblTk_Vt";
		Label obj34 = lblTk_Vt;
		size = new Size(42, 13);
		((Control)obj34).Size = size;
		((Control)lblTk_Vt).TabIndex = 169;
		lblTk_Vt.Text = "TK kho";
		lblTk_Vt.TextAlign = (ContentAlignment)16;
		txtTs_Gtgt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric7 = txtTs_Gtgt;
		location = new Point(629, 556);
		((Control)asTextNumeric7).Location = location;
		txtTs_Gtgt.Mask = "### ### ### ###.##";
		((Control)txtTs_Gtgt).Name = "txtTs_Gtgt";
		AsTextNumeric asTextNumeric8 = txtTs_Gtgt;
		size = new Size(65, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtTs_Gtgt).TabIndex = 1;
		((TextBox)txtTs_Gtgt).Text = "0.00";
		((TextBox)txtTs_Gtgt).TextAlign = (HorizontalAlignment)1;
		txtTs_Gtgt.Value = 0.0;
		((Control)txtTs_Gtgt).Visible = false;
		lblTs_Gtgt.AutoSize = true;
		lblTs_Gtgt.ImeMode = (ImeMode)0;
		Label obj35 = lblTs_Gtgt;
		location = new Point(541, 560);
		((Control)obj35).Location = location;
		((Control)lblTs_Gtgt).Name = "lblTs_Gtgt";
		Label obj36 = lblTs_Gtgt;
		size = new Size(88, 13);
		((Control)obj36).Size = size;
		((Control)lblTs_Gtgt).TabIndex = 253;
		lblTs_Gtgt.Text = "Thuế suất GTGT";
		lblTs_Gtgt.TextAlign = (ContentAlignment)16;
		((Control)lblTs_Gtgt).Visible = false;
		txtSl_max.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric9 = txtSl_max;
		location = new Point(617, 345);
		((Control)asTextNumeric9).Location = location;
		txtSl_max.Mask = "### ### ### ###.##";
		((Control)txtSl_max).Name = "txtSl_max";
		AsTextNumeric asTextNumeric10 = txtSl_max;
		size = new Size(111, 20);
		((Control)asTextNumeric10).Size = size;
		((Control)txtSl_max).TabIndex = 25;
		((TextBox)txtSl_max).Text = "0.00";
		((TextBox)txtSl_max).TextAlign = (HorizontalAlignment)1;
		txtSl_max.Value = 0.0;
		lblSl_max.AutoSize = true;
		lblSl_max.ImeMode = (ImeMode)0;
		Label obj37 = lblSl_max;
		location = new Point(521, 349);
		((Control)obj37).Location = location;
		((Control)lblSl_max).Name = "lblSl_max";
		Label obj38 = lblSl_max;
		size = new Size(56, 13);
		((Control)obj38).Size = size;
		((Control)lblSl_max).TabIndex = 250;
		lblSl_max.Text = "Tồn tối đa";
		lblSl_max.TextAlign = (ContentAlignment)16;
		txtSl_min.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric11 = txtSl_min;
		location = new Point(617, 319);
		((Control)asTextNumeric11).Location = location;
		txtSl_min.Mask = "### ### ### ###.##";
		((Control)txtSl_min).Name = "txtSl_min";
		AsTextNumeric asTextNumeric12 = txtSl_min;
		size = new Size(111, 20);
		((Control)asTextNumeric12).Size = size;
		((Control)txtSl_min).TabIndex = 24;
		((TextBox)txtSl_min).Text = "0.00";
		((TextBox)txtSl_min).TextAlign = (HorizontalAlignment)1;
		txtSl_min.Value = 0.0;
		lblSl_min.AutoSize = true;
		lblSl_min.ImeMode = (ImeMode)0;
		Label obj39 = lblSl_min;
		location = new Point(521, 323);
		((Control)obj39).Location = location;
		((Control)lblSl_min).Name = "lblSl_min";
		Label obj40 = lblSl_min;
		size = new Size(66, 13);
		((Control)obj40).Size = size;
		((Control)lblSl_min).TabIndex = 248;
		lblSl_min.Text = "Tồn tối thiểu";
		lblSl_min.TextAlign = (ContentAlignment)16;
		Label5.AutoSize = true;
		Label5.ImeMode = (ImeMode)0;
		Label label3 = Label5;
		location = new Point(513, 48);
		((Control)label3).Location = location;
		((Control)Label5).Name = "Label5";
		Label label4 = Label5;
		size = new Size(78, 13);
		((Control)label4).Size = size;
		((Control)Label5).TabIndex = 262;
		Label5.Text = "Đvt bán/Hệ số";
		Label5.TextAlign = (ContentAlignment)16;
		Label4.AutoSize = true;
		Label4.ImeMode = (ImeMode)0;
		Label label5 = Label4;
		location = new Point(255, 48);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		Label label6 = Label4;
		size = new Size(80, 13);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 261;
		Label4.Text = "Đvt mua/Hệ số";
		Label4.TextAlign = (ContentAlignment)16;
		txtHs_dvtban.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric13 = txtHs_dvtban;
		location = new Point(673, 45);
		((Control)asTextNumeric13).Location = location;
		txtHs_dvtban.Mask = "### ### ### ###.##";
		((Control)txtHs_dvtban).Name = "txtHs_dvtban";
		AsTextNumeric asTextNumeric14 = txtHs_dvtban;
		size = new Size(55, 20);
		((Control)asTextNumeric14).Size = size;
		((Control)txtHs_dvtban).TabIndex = 6;
		((TextBox)txtHs_dvtban).Text = "0.00";
		((TextBox)txtHs_dvtban).TextAlign = (HorizontalAlignment)1;
		txtHs_dvtban.Value = 0.0;
		txtHs_dvtmua.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric15 = txtHs_dvtmua;
		location = new Point(417, 44);
		((Control)asTextNumeric15).Location = location;
		txtHs_dvtmua.Mask = "### ### ### ###.##";
		((Control)txtHs_dvtmua).Name = "txtHs_dvtmua";
		AsTextNumeric asTextNumeric16 = txtHs_dvtmua;
		size = new Size(55, 20);
		((Control)asTextNumeric16).Size = size;
		((Control)txtHs_dvtmua).TabIndex = 4;
		((TextBox)txtHs_dvtmua).Text = "0.00";
		((TextBox)txtHs_dvtmua).TextAlign = (HorizontalAlignment)1;
		txtHs_dvtmua.Value = 0.0;
		((ButtonBase)chkTon_kho).AutoSize = true;
		chkTon_kho.Checked = false;
		AsCheckBox asCheckBox2 = chkTon_kho;
		location = new Point(258, 76);
		((Control)asCheckBox2).Location = location;
		((Control)chkTon_kho).Name = "chkTon_kho";
		AsCheckBox asCheckBox3 = chkTon_kho;
		size = new Size(107, 17);
		((Control)asCheckBox3).Size = size;
		((Control)chkTon_kho).TabIndex = 8;
		((Control)chkTon_kho).TabStop = false;
		((ButtonBase)chkTon_kho).Text = "Theo dõi tồn kho";
		((CheckBox)chkTon_kho).TextAlign = (ContentAlignment)64;
		chkTon_kho.TextValue = "0";
		((ButtonBase)chkTon_kho).UseVisualStyleBackColor = true;
		cboDvt.AutoCompleteCustomSource.AddRange(new string[6] { "Cái", "Chiếc", "Con", "Cặp", "Bộ", "Đôi" });
		cboDvt.AutoCompleteMode = (AutoCompleteMode)3;
		cboDvt.AutoCompleteSource = (AutoCompleteSource)256;
		((ListControl)cboDvt).FormattingEnabled = true;
		cboDvt.Items.AddRange(new object[6] { "Cái", "Chiếc", "Con", "Cặp", "Bộ", "Đôi" });
		ComboBox obj41 = cboDvt;
		location = new Point(119, 45);
		((Control)obj41).Location = location;
		((Control)cboDvt).Name = "cboDvt";
		ComboBox obj42 = cboDvt;
		size = new Size(90, 21);
		((Control)obj42).Size = size;
		((Control)cboDvt).TabIndex = 2;
		txtMa_Nhvt.AutoLookup = true;
		txtMa_Nhvt.AutoValid = true;
		((TextBoxBase)txtMa_Nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox15 = txtMa_Nhvt;
		location = new Point(119, 137);
		((Control)asTextBox15).Location = location;
		txtMa_Nhvt.LookupCodeName = "MA_NHVT";
		((Control)txtMa_Nhvt).Name = "txtMa_Nhvt";
		txtMa_Nhvt.NameControl = lblTen_NhVt;
		txtMa_Nhvt.SD = true;
		AsTextBox asTextBox16 = txtMa_Nhvt;
		size = new Size(90, 20);
		((Control)asTextBox16).Size = size;
		((Control)txtMa_Nhvt).TabIndex = 10;
		txtMa_Nhvt.UseAutoCompleteSource = true;
		txtMa_Nhvt.ValidReturnFieldList = "TK_VT,TK_DT,TK_DTNB,TK_GV,TK_TL,TK_CK,TEN_NHVT";
		((Control)lblTen_NhVt).Anchor = (AnchorStyles)13;
		lblTen_NhVt.AutoSize = true;
		lblTen_NhVt.ImeMode = (ImeMode)0;
		Label obj43 = lblTen_NhVt;
		location = new Point(215, 141);
		((Control)obj43).Location = location;
		((Control)lblTen_NhVt).Name = "lblTen_NhVt";
		Label obj44 = lblTen_NhVt;
		size = new Size(85, 13);
		((Control)obj44).Size = size;
		((Control)lblTen_NhVt).TabIndex = 205;
		lblTen_NhVt.Text = "Tên nhóm vật tư";
		cboGia_ton.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboGia_ton).FormattingEnabled = true;
		ComboBox obj45 = cboGia_ton;
		location = new Point(119, 99);
		((Control)obj45).Location = location;
		((Control)cboGia_ton).Name = "cboGia_ton";
		ComboBox obj46 = cboGia_ton;
		size = new Size(126, 21);
		((Control)obj46).Size = size;
		((Control)cboGia_ton).TabIndex = 9;
		lblGia_ton.AutoSize = true;
		lblGia_ton.ImeMode = (ImeMode)0;
		Label obj47 = lblGia_ton;
		location = new Point(17, 103);
		((Control)obj47).Location = location;
		((Control)lblGia_ton).Name = "lblGia_ton";
		Label obj48 = lblGia_ton;
		size = new Size(41, 13);
		((Control)obj48).Size = size;
		((Control)lblGia_ton).TabIndex = 195;
		lblGia_ton.Text = "Giá tồn";
		cboLoai.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai).FormattingEnabled = true;
		ComboBox obj49 = cboLoai;
		location = new Point(119, 72);
		((Control)obj49).Location = location;
		((Control)cboLoai).Name = "cboLoai";
		ComboBox obj50 = cboLoai;
		size = new Size(126, 21);
		((Control)obj50).Size = size;
		((Control)cboLoai).TabIndex = 7;
		lblLoai.AutoSize = true;
		lblLoai.ImeMode = (ImeMode)0;
		Label obj51 = lblLoai;
		location = new Point(17, 76);
		((Control)obj51).Location = location;
		((Control)lblLoai).Name = "lblLoai";
		Label obj52 = lblLoai;
		size = new Size(30, 13);
		((Control)obj52).Size = size;
		((Control)lblLoai).TabIndex = 193;
		lblLoai.Text = "Loại ";
		lblDvt.AutoSize = true;
		Label obj53 = lblDvt;
		location = new Point(17, 48);
		((Control)obj53).Location = location;
		((Control)lblDvt).Name = "lblDvt";
		Label obj54 = lblDvt;
		size = new Size(24, 13);
		((Control)obj54).Size = size;
		((Control)lblDvt).TabIndex = 182;
		lblDvt.Text = "Đvt";
		lblMa_Nhvt.AutoSize = true;
		lblMa_Nhvt.ImeMode = (ImeMode)0;
		Label obj55 = lblMa_Nhvt;
		location = new Point(17, 141);
		((Control)obj55).Location = location;
		((Control)lblMa_Nhvt).Name = "lblMa_Nhvt";
		Label obj56 = lblMa_Nhvt;
		size = new Size(35, 13);
		((Control)obj56).Size = size;
		((Control)lblMa_Nhvt).TabIndex = 181;
		lblMa_Nhvt.Text = "Nhóm";
		lbTen_vt.AutoSize = true;
		lbTen_vt.ImeMode = (ImeMode)0;
		Label obj57 = lbTen_vt;
		location = new Point(255, 23);
		((Control)obj57).Location = location;
		((Control)lbTen_vt).Name = "lbTen_vt";
		Label obj58 = lbTen_vt;
		size = new Size(26, 13);
		((Control)obj58).Size = size;
		((Control)lbTen_vt).TabIndex = 117;
		lbTen_vt.Text = "Tên";
		lblMa_Vt.AutoSize = true;
		lblMa_Vt.ImeMode = (ImeMode)0;
		Label obj59 = lblMa_Vt;
		location = new Point(17, 23);
		((Control)obj59).Location = location;
		((Control)lblMa_Vt).Name = "lblMa_Vt";
		Label obj60 = lblMa_Vt;
		size = new Size(52, 13);
		((Control)obj60).Size = size;
		((Control)lblMa_Vt).TabIndex = 116;
		lblMa_Vt.Text = "Mã vật tư";
		txtMa_Vt.CharacterCasing = (CharacterCasing)1;
		TextBox obj61 = txtMa_Vt;
		location = new Point(119, 19);
		((Control)obj61).Location = location;
		((Control)txtMa_Vt).Name = "txtMa_Vt";
		TextBox obj62 = txtMa_Vt;
		size = new Size(126, 20);
		((Control)obj62).Size = size;
		((Control)txtMa_Vt).TabIndex = 0;
		TextBox obj63 = txtTen_Vt;
		location = new Point(341, 19);
		((Control)obj63).Location = location;
		((TextBoxBase)txtTen_Vt).MaxLength = 128;
		((Control)txtTen_Vt).Name = "txtTen_Vt";
		TextBox obj64 = txtTen_Vt;
		size = new Size(387, 20);
		((Control)obj64).Size = size;
		((Control)txtTen_Vt).TabIndex = 1;
		lblMa_NhVat.AutoSize = true;
		lblMa_NhVat.ImeMode = (ImeMode)0;
		Label obj65 = lblMa_NhVat;
		location = new Point(242, 555);
		((Control)obj65).Location = location;
		((Control)lblMa_NhVat).Name = "lblMa_NhVat";
		Label obj66 = lblMa_NhVat;
		size = new Size(59, 13);
		((Control)obj66).Size = size;
		((Control)lblMa_NhVat).TabIndex = 187;
		lblMa_NhVat.Text = "Nhóm VAT";
		((Control)lblMa_NhVat).Visible = false;
		((Control)lblTen_NhVat).Anchor = (AnchorStyles)13;
		lblTen_NhVat.AutoSize = true;
		lblTen_NhVat.ImeMode = (ImeMode)0;
		Label obj67 = lblTen_NhVat;
		location = new Point(415, 556);
		((Control)obj67).Location = location;
		((Control)lblTen_NhVat).Name = "lblTen_NhVat";
		Label obj68 = lblTen_NhVat;
		size = new Size(79, 13);
		((Control)obj68).Size = size;
		((Control)lblTen_NhVat).TabIndex = 208;
		lblTen_NhVat.Text = "Tên nhóm VAT";
		((Control)lblTen_NhVat).Visible = false;
		txtMa_nhvat.AutoLookup = true;
		txtMa_nhvat.AutoValid = true;
		((TextBoxBase)txtMa_nhvat).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvat).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox17 = txtMa_nhvat;
		location = new Point(322, 553);
		((Control)asTextBox17).Location = location;
		txtMa_nhvat.LookupCodeName = "MA_NHVAT";
		((Control)txtMa_nhvat).Name = "txtMa_nhvat";
		txtMa_nhvat.NameControl = lblTen_NhVat;
		txtMa_nhvat.SD = true;
		AsTextBox asTextBox18 = txtMa_nhvat;
		size = new Size(90, 20);
		((Control)asTextBox18).Size = size;
		((Control)txtMa_nhvat).TabIndex = 10;
		txtMa_nhvat.UseAutoCompleteSource = true;
		((Control)txtMa_nhvat).Visible = false;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = true;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox19 = txtMa_kho;
		location = new Point(119, 163);
		((Control)asTextBox19).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_Kho;
		txtMa_kho.SD = true;
		AsTextBox asTextBox20 = txtMa_kho;
		size = new Size(90, 20);
		((Control)asTextBox20).Size = size;
		((Control)txtMa_kho).TabIndex = 11;
		txtMa_kho.UseAutoCompleteSource = true;
		((Control)lblTen_Kho).Anchor = (AnchorStyles)13;
		lblTen_Kho.AutoSize = true;
		lblTen_Kho.ImeMode = (ImeMode)0;
		Label obj69 = lblTen_Kho;
		location = new Point(215, 167);
		((Control)obj69).Location = location;
		((Control)lblTen_Kho).Name = "lblTen_Kho";
		Label obj70 = lblTen_Kho;
		size = new Size(47, 13);
		((Control)obj70).Size = size;
		((Control)lblTen_Kho).TabIndex = 254;
		lblTen_Kho.Text = "Ten kho";
		lblMa_kho.AutoSize = true;
		lblMa_kho.ImeMode = (ImeMode)0;
		Label obj71 = lblMa_kho;
		location = new Point(17, 167);
		((Control)obj71).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj72 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj72).Size = size;
		((Control)lblMa_kho).TabIndex = 252;
		lblMa_kho.Text = "Mã kho";
		((ListControl)cboDvt_mua).FormattingEnabled = true;
		((ComboBox)cboDvt_mua).Items.AddRange(new object[6] { "Cái", "Chiếc", "Con", "Cặp", "Bộ", "Đôi" });
		AsComboBox asComboBox = cboDvt_mua;
		location = new Point(341, 44);
		((Control)asComboBox).Location = location;
		((Control)cboDvt_mua).Name = "cboDvt_mua";
		AsComboBox asComboBox2 = cboDvt_mua;
		size = new Size(70, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboDvt_mua).TabIndex = 3;
		((ListControl)cboDvt_ban).FormattingEnabled = true;
		((ComboBox)cboDvt_ban).Items.AddRange(new object[6] { "Cái", "Chiếc", "Con", "Cặp", "Bộ", "Đôi" });
		AsComboBox asComboBox3 = cboDvt_ban;
		location = new Point(597, 45);
		((Control)asComboBox3).Location = location;
		((Control)cboDvt_ban).Name = "cboDvt_ban";
		AsComboBox asComboBox4 = cboDvt_ban;
		size = new Size(70, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboDvt_ban).TabIndex = 5;
		txtGia_nt2.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric17 = txtGia_nt2;
		location = new Point(617, 293);
		((Control)asTextNumeric17).Location = location;
		txtGia_nt2.Mask = "### ### ### ###.##";
		((Control)txtGia_nt2).Name = "txtGia_nt2";
		AsTextNumeric asTextNumeric18 = txtGia_nt2;
		size = new Size(111, 20);
		((Control)asTextNumeric18).Size = size;
		((Control)txtGia_nt2).TabIndex = 23;
		((TextBox)txtGia_nt2).Text = "0.00";
		((TextBox)txtGia_nt2).TextAlign = (HorizontalAlignment)1;
		txtGia_nt2.Value = 0.0;
		lblGia_ban.AutoSize = true;
		lblGia_ban.ImeMode = (ImeMode)0;
		Label obj73 = lblGia_ban;
		location = new Point(521, 295);
		((Control)obj73).Location = location;
		((Control)lblGia_ban).Name = "lblGia_ban";
		Label obj74 = lblGia_ban;
		size = new Size(44, 13);
		((Control)obj74).Size = size;
		((Control)lblGia_ban).TabIndex = 266;
		lblGia_ban.Text = "Giá bán";
		lblGia_ban.TextAlign = (ContentAlignment)16;
		txtGia_nt0.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric19 = txtGia_nt0;
		location = new Point(617, 267);
		((Control)asTextNumeric19).Location = location;
		txtGia_nt0.Mask = "### ### ### ###.##";
		((Control)txtGia_nt0).Name = "txtGia_nt0";
		AsTextNumeric asTextNumeric20 = txtGia_nt0;
		size = new Size(111, 20);
		((Control)asTextNumeric20).Size = size;
		((Control)txtGia_nt0).TabIndex = 22;
		((TextBox)txtGia_nt0).Text = "0.00";
		((TextBox)txtGia_nt0).TextAlign = (HorizontalAlignment)1;
		txtGia_nt0.Value = 0.0;
		lblGia_mua.AutoSize = true;
		lblGia_mua.ImeMode = (ImeMode)0;
		Label obj75 = lblGia_mua;
		location = new Point(521, 271);
		((Control)obj75).Location = location;
		((Control)lblGia_mua).Name = "lblGia_mua";
		Label obj76 = lblGia_mua;
		size = new Size(46, 13);
		((Control)obj76).Size = size;
		((Control)lblGia_mua).TabIndex = 265;
		lblGia_mua.Text = "Giá mua";
		lblGia_mua.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(757, 417);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtMa_nhvat);
		((Control)this).Controls.Add((Control)(object)lblMa_NhVat);
		((Control)this).Controls.Add((Control)(object)lblTen_NhVat);
		((Control)this).Controls.Add((Control)(object)txtTs_Gtgt);
		((Control)this).Controls.Add((Control)(object)lblTs_Gtgt);
		((Control)this).Name = "frmINDMVTEdit";
		((Control)this).Controls.SetChildIndex((Control)(object)lblTs_Gtgt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtTs_Gtgt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen_NhVat, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblMa_NhVat, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtMa_nhvat, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbLine, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSave, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		cboLoai.DataSource = AsiaErp.Framework.Environment.GetDmLoaiVt();
		((ListControl)cboLoai).ValueMember = "id";
		((ListControl)cboLoai).DisplayMember = "mo_ta";
		cboLoai.SelectedIndex = 0;
		cboGia_ton.DataSource = AsiaErp.Framework.Environment.GetDmLoaiGiaTon();
		((ListControl)cboGia_ton).ValueMember = "id";
		((ListControl)cboGia_ton).DisplayMember = "mo_ta";
		cboGia_ton.SelectedIndex = 0;
		cboDvt.SelectedIndex = 0;
		((TextBoxBase)txtMa_Vt).MaxLength = MyDictInfo.code_length;
		((Control)txtMa_Vt).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((TextBoxBase)txtMa_Vt).ReadOnly = true;
		((Control)txtMa_Vt).TabStop = false;
		((Control)txtTen_Vt).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_Vt;
		CreateDataBinding(ref ojb, "Ma_Vt");
		txtMa_Vt = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Vt;
		CreateDataBinding(ref ojb, "Ten_Vt");
		txtTen_Vt = (TextBox)ojb;
		ojb = (Control)(object)cboDvt;
		CreateDataBinding(ref ojb, "Dvt");
		cboDvt = (ComboBox)ojb;
		ojb = (Control)(object)txtMa_Nhvt;
		CreateDataBinding(ref ojb, "Ma_Nhvt");
		txtMa_Nhvt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_NhVt;
		CreateDataBinding(ref ojb, "Ten_NhVt");
		lblTen_NhVt = (Label)ojb;
		ojb = (Control)(object)txtMa_nhvat;
		CreateDataBinding(ref ojb, "Ma_nhvat");
		txtMa_nhvat = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_NhVat;
		CreateDataBinding(ref ojb, "Ten_Nhvat");
		lblTen_NhVat = (Label)ojb;
		ojb = (Control)(object)txtMa_kho;
		CreateDataBinding(ref ojb, "Ma_kho");
		txtMa_kho = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Kho;
		CreateDataBinding(ref ojb, "Ten_Kho");
		lblTen_Kho = (Label)ojb;
		ojb = (Control)(object)cboLoai;
		CreateDataBinding(ref ojb, "Loai", "SelectedValue");
		cboLoai = (ComboBox)ojb;
		ojb = (Control)(object)cboGia_ton;
		CreateDataBinding(ref ojb, "Gia_ton", "SelectedValue");
		cboGia_ton = (ComboBox)ojb;
		ojb = (Control)(object)txtSl_min;
		CreateDataBinding(ref ojb, "Sl_min", "Value");
		txtSl_min = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSl_max;
		CreateDataBinding(ref ojb, "Sl_max", "Value");
		txtSl_max = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGia_nt0;
		CreateDataBinding(ref ojb, "Gia_nt0", "Value");
		txtGia_nt0 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGia_nt2;
		CreateDataBinding(ref ojb, "Gia_nt2", "Value");
		txtGia_nt2 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTs_Gtgt;
		CreateDataBinding(ref ojb, "Ts_Gtgt", "Value");
		txtTs_Gtgt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTs_Nk;
		CreateDataBinding(ref ojb, "Ts_Nk", "Value");
		txtTs_Nk = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTs_Xk;
		CreateDataBinding(ref ojb, "Ts_Xk", "Value");
		txtTs_Xk = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)cboDvt_mua;
		CreateDataBinding(ref ojb, "Dvt_mua");
		cboDvt_mua = (AsComboBox)(object)ojb;
		ojb = (Control)(object)txtHs_dvtmua;
		CreateDataBinding(ref ojb, "Hs_dvtmua", "Value");
		txtHs_dvtmua = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)cboDvt_ban;
		CreateDataBinding(ref ojb, "Dvt_ban");
		cboDvt_ban = (AsComboBox)(object)ojb;
		ojb = (Control)(object)txtHs_dvtban;
		CreateDataBinding(ref ojb, "Hs_dvtban", "Value");
		txtHs_dvtban = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTk_Ck;
		CreateDataBinding(ref ojb, "Tk_Ck");
		txtTk_Ck = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Tk_Ck;
		CreateDataBinding(ref ojb, "Ten_Tk_Ck");
		lblTen_Tk_Ck = (Label)ojb;
		ojb = (Control)(object)txtTk_Dt;
		CreateDataBinding(ref ojb, "Tk_Dt");
		txtTk_Dt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Tk_Dt;
		CreateDataBinding(ref ojb, "Ten_Tk_Dt");
		lblTen_Tk_Dt = (Label)ojb;
		ojb = (Control)(object)txtTk_DtNb;
		CreateDataBinding(ref ojb, "Tk_DtNb");
		txtTk_DtNb = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Tk_Dtnb;
		CreateDataBinding(ref ojb, "Ten_Tk_DtNb");
		lblTen_Tk_Dtnb = (Label)ojb;
		ojb = (Control)(object)txtTk_Gv;
		CreateDataBinding(ref ojb, "Tk_Gv");
		txtTk_Gv = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Tk_gv;
		CreateDataBinding(ref ojb, "Ten_Tk_Gv");
		lblTen_Tk_gv = (Label)ojb;
		ojb = (Control)(object)txtTk_Tl;
		CreateDataBinding(ref ojb, "Tk_Tl");
		txtTk_Tl = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Tk_tl;
		CreateDataBinding(ref ojb, "Ten_Tk_tl");
		lblTen_Tk_tl = (Label)ojb;
		ojb = (Control)(object)txtTk_Vt;
		CreateDataBinding(ref ojb, "Tk_Vt");
		txtTk_Vt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Tk_Vt;
		CreateDataBinding(ref ojb, "Ten_tk_vt");
		lblTen_Tk_Vt = (Label)ojb;
		ojb = (Control)(object)chkTon_kho;
		CreateDataBinding(ref ojb, "ton_kho", "Checked");
		chkTon_kho = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)txtTs_ttdb;
		CreateDataBinding(ref ojb, "Ts_ttdb", "Value");
		txtTs_ttdb = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMa_Thue;
		CreateDataBinding(ref ojb, "ma_thue");
		txtMa_Thue = (AsTextBox)(object)ojb;
	}

	protected override bool SetToRow()
	{
		bool flag = base.SetToRow();
		if (flag)
		{
			if (cboLoai.SelectedItem != null)
			{
				base.RowToEdit["ten_loai"] = ((DmLoaiVatTu)cboLoai.SelectedItem).mo_ta;
			}
			if (cboGia_ton.SelectedItem != null)
			{
				base.RowToEdit["ten_loai_gia"] = ((DmLoaiGiaTon)cboGia_ton.SelectedItem).mo_ta;
			}
		}
		return flag;
	}

	protected override bool ValidData()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (!ChkEmtyTextBox(txtMa_Vt) || !ChkEmtyTextBox(txtTen_Vt))
		{
			return false;
		}
		if ((int)((CheckBox)chkTon_kho).CheckState == 1)
		{
			if (Operators.CompareString(cboDvt.Text, "", false) == 0)
			{
				((Control)cboDvt).Select();
				CMessageBox.Show(50002);
				return false;
			}
			if (!ChkEmtyTextBox((TextBox)(object)txtTk_Vt))
			{
				((Control)txtTk_Vt).Focus();
				return false;
			}
		}
		return base.ValidData();
	}

	private void txtMa_Nhvt_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (!EditMode && e.ValidatedRow != null)
		{
			((TextBox)txtTk_Vt).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["Tk_Vt"]), isNum: false));
			((TextBox)txtTk_Dt).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["Tk_Dt"]), isNum: false));
			((TextBox)txtTk_DtNb).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["Tk_DtNb"]), isNum: false));
			((TextBox)txtTk_Gv).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["Tk_Gv"]), isNum: false));
			((TextBox)txtTk_Tl).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["Tk_Tl"]), isNum: false));
			((TextBox)txtTk_Ck).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["Tk_Ck"]), isNum: false));
		}
	}

	private void cboLoai_SelectedValueChanged(object sender, EventArgs e)
	{
		if (!base.IsLoading)
		{
			chkTon_kho.Checked = ((DmLoaiVatTu)cboLoai.SelectedItem).ton_kho;
			((Control)chkTon_kho).Enabled = Conversions.ToBoolean(Operators.NotObject(chkTon_kho.Checked));
		}
	}
}
