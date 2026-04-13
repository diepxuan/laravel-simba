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
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSORptBCPT06 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_Plvt1")]
	private AsTextBox _txtMa_Plvt1;

	[AccessedThroughProperty("lblTen_plvt1")]
	private Label _lblTen_plvt1;

	[AccessedThroughProperty("lblPlvt1")]
	private Label _lblPlvt1;

	[AccessedThroughProperty("txtMa_Plvt2")]
	private AsTextBox _txtMa_Plvt2;

	[AccessedThroughProperty("lblTen_plvt2")]
	private Label _lblTen_plvt2;

	[AccessedThroughProperty("lblPlvt2")]
	private Label _lblPlvt2;

	[AccessedThroughProperty("txtMa_plvt3")]
	private AsTextBox _txtMa_plvt3;

	[AccessedThroughProperty("lblTen_plvt3")]
	private Label _lblTen_plvt3;

	[AccessedThroughProperty("lblPlvt3")]
	private Label _lblPlvt3;

	[AccessedThroughProperty("txtMa_Plkh1")]
	private AsTextBox _txtMa_Plkh1;

	[AccessedThroughProperty("lblTen_Plkh1")]
	private Label _lblTen_Plkh1;

	[AccessedThroughProperty("lblPlkh1")]
	private Label _lblPlkh1;

	[AccessedThroughProperty("txtMa_Plkh2")]
	private AsTextBox _txtMa_Plkh2;

	[AccessedThroughProperty("lblTen_Plkh2")]
	private Label _lblTen_Plkh2;

	[AccessedThroughProperty("lblPlkh2")]
	private Label _lblPlkh2;

	[AccessedThroughProperty("txtMa_Plkh3")]
	private AsTextBox _txtMa_Plkh3;

	[AccessedThroughProperty("lblTen_Plkh3")]
	private Label _lblTen_Plkh3;

	[AccessedThroughProperty("lblPlkh3")]
	private Label _lblPlkh3;

	[AccessedThroughProperty("lblNhom_Theo")]
	private Label _lblNhom_Theo;

	[AccessedThroughProperty("lblChi_Tiet_Theo")]
	private Label _lblChi_Tiet_Theo;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("txtMa_nvkd")]
	private AsTextBox _txtMa_nvkd;

	[AccessedThroughProperty("lblTen_nvkd")]
	private Label _lblTen_nvkd;

	[AccessedThroughProperty("lblMa_nvkd")]
	private Label _lblMa_nvkd;

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("txtMa_nhhd")]
	private AsTextBox _txtMa_nhhd;

	[AccessedThroughProperty("lblTen_Nhhd")]
	private Label _lblTen_Nhhd;

	[AccessedThroughProperty("lblMa_nhhd")]
	private Label _lblMa_nhhd;

	[AccessedThroughProperty("txtMa_kh")]
	private AsTextBox _txtMa_kh;

	[AccessedThroughProperty("lblTen_KH")]
	private Label _lblTen_KH;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("txtMa_Nhkh")]
	private AsTextBox _txtMa_Nhkh;

	[AccessedThroughProperty("lblTen_nhkh")]
	private Label _lblTen_nhkh;

	[AccessedThroughProperty("lblMa_Nhkh")]
	private Label _lblMa_Nhkh;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtMa_nhvt")]
	private AsTextBox _txtMa_nhvt;

	[AccessedThroughProperty("lblTen_Nhvt")]
	private Label _lblTen_Nhvt;

	[AccessedThroughProperty("lblMa_nhvt")]
	private Label _lblMa_nhvt;

	[AccessedThroughProperty("lblTen_HTTT")]
	private Label _lblTen_HTTT;

	[AccessedThroughProperty("lblMa_HTTT")]
	private Label _lblMa_HTTT;

	[AccessedThroughProperty("txtMa_HTTT")]
	private AsTextBox _txtMa_HTTT;

	[AccessedThroughProperty("cboChi_Tiet_Theo")]
	private AsComboBox _cboChi_Tiet_Theo;

	[AccessedThroughProperty("cboNhom_Theo")]
	private AsComboBox _cboNhom_Theo;

	[AccessedThroughProperty("ChkTra_lai")]
	private AsCheckBox _ChkTra_lai;

	[AccessedThroughProperty("lblTru")]
	private Label _lblTru;

	[AccessedThroughProperty("ChkTra_ck")]
	private AsCheckBox _ChkTra_ck;

	[AccessedThroughProperty("ChkKhuyen_mai")]
	private AsCheckBox _ChkKhuyen_mai;

	[AccessedThroughProperty("ChkHang_ban")]
	private AsCheckBox _ChkHang_ban;

	[AccessedThroughProperty("lblLoai_hang")]
	private Label _lblLoai_hang;

	private readonly ToolTip _oToolTip;

	internal virtual AsTextBox txtMa_Plvt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Plvt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Plvt1 = value;
		}
	}

	internal virtual Label lblTen_plvt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_plvt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_plvt1 = value;
		}
	}

	internal virtual Label lblPlvt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPlvt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPlvt1 = value;
		}
	}

	internal virtual AsTextBox txtMa_Plvt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Plvt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Plvt2 = value;
		}
	}

	internal virtual Label lblTen_plvt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_plvt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_plvt2 = value;
		}
	}

	internal virtual Label lblPlvt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPlvt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPlvt2 = value;
		}
	}

	internal virtual AsTextBox txtMa_plvt3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_plvt3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_plvt3 = value;
		}
	}

	internal virtual Label lblTen_plvt3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_plvt3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_plvt3 = value;
		}
	}

	internal virtual Label lblPlvt3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPlvt3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPlvt3 = value;
		}
	}

	internal virtual AsTextBox txtMa_Plkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Plkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Plkh1 = value;
		}
	}

	internal virtual Label lblTen_Plkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Plkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Plkh1 = value;
		}
	}

	internal virtual Label lblPlkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPlkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPlkh1 = value;
		}
	}

	internal virtual AsTextBox txtMa_Plkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Plkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Plkh2 = value;
		}
	}

	internal virtual Label lblTen_Plkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Plkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Plkh2 = value;
		}
	}

	internal virtual Label lblPlkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPlkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPlkh2 = value;
		}
	}

	internal virtual AsTextBox txtMa_Plkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Plkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Plkh3 = value;
		}
	}

	internal virtual Label lblTen_Plkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Plkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Plkh3 = value;
		}
	}

	internal virtual Label lblPlkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPlkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPlkh3 = value;
		}
	}

	internal virtual Label lblNhom_Theo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNhom_Theo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNhom_Theo = value;
		}
	}

	internal virtual Label lblChi_Tiet_Theo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblChi_Tiet_Theo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblChi_Tiet_Theo = value;
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

	internal virtual Label lblTen_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kho = value;
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

	internal virtual AsTextBox txtMa_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_bp = value;
		}
	}

	internal virtual Label lblTen_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_bp = value;
		}
	}

	internal virtual Label lblMa_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_bp = value;
		}
	}

	internal virtual AsTextBox txtMa_nvkd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nvkd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nvkd = value;
		}
	}

	internal virtual Label lblTen_nvkd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nvkd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nvkd = value;
		}
	}

	internal virtual Label lblMa_nvkd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nvkd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nvkd = value;
		}
	}

	internal virtual Label lblMa_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_hd = value;
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

	internal virtual Label lblTen_hd
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

	internal virtual AsTextBox txtMa_nhhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhhd = value;
		}
	}

	internal virtual Label lblTen_Nhhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhhd = value;
		}
	}

	internal virtual Label lblMa_nhhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhhd = value;
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

	internal virtual Label lblTen_KH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_KH = value;
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

	internal virtual AsTextBox txtMa_Nhkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Nhkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Nhkh = value;
		}
	}

	internal virtual Label lblTen_nhkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nhkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nhkh = value;
		}
	}

	internal virtual Label lblMa_Nhkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nhkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nhkh = value;
		}
	}

	internal virtual AsTextBox txtMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_vt = value;
		}
	}

	internal virtual Label lblTen_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_vt = value;
		}
	}

	internal virtual Label lblMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_vt = value;
		}
	}

	internal virtual AsTextBox txtMa_nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhvt = value;
		}
	}

	internal virtual Label lblTen_Nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhvt = value;
		}
	}

	internal virtual Label lblMa_nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhvt = value;
		}
	}

	internal virtual Label lblTen_HTTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_HTTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_HTTT = value;
		}
	}

	internal virtual Label lblMa_HTTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_HTTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_HTTT = value;
		}
	}

	internal virtual AsTextBox txtMa_HTTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_HTTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_HTTT = value;
		}
	}

	internal virtual AsComboBox cboChi_Tiet_Theo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboChi_Tiet_Theo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboNhom_Theo_SelectedIndexChanged;
			EventHandler eventHandler2 = cboChi_Tiet_Theo_GotFocus;
			if (_cboChi_Tiet_Theo != null)
			{
				((ComboBox)_cboChi_Tiet_Theo).SelectedIndexChanged -= eventHandler;
				((Control)_cboChi_Tiet_Theo).GotFocus -= eventHandler2;
			}
			_cboChi_Tiet_Theo = value;
			if (_cboChi_Tiet_Theo != null)
			{
				((ComboBox)_cboChi_Tiet_Theo).SelectedIndexChanged += eventHandler;
				((Control)_cboChi_Tiet_Theo).GotFocus += eventHandler2;
			}
		}
	}

	internal virtual AsComboBox cboNhom_Theo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNhom_Theo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboNhom_Theo_SelectedIndexChanged;
			EventHandler eventHandler2 = cboChi_Tiet_Theo_GotFocus;
			if (_cboNhom_Theo != null)
			{
				((ComboBox)_cboNhom_Theo).SelectedIndexChanged -= eventHandler;
				((Control)_cboNhom_Theo).GotFocus -= eventHandler2;
			}
			_cboNhom_Theo = value;
			if (_cboNhom_Theo != null)
			{
				((ComboBox)_cboNhom_Theo).SelectedIndexChanged += eventHandler;
				((Control)_cboNhom_Theo).GotFocus += eventHandler2;
			}
		}
	}

	internal virtual AsCheckBox ChkTra_lai
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkTra_lai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkTra_lai = value;
		}
	}

	private virtual Label lblTru
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTru;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTru = value;
		}
	}

	internal virtual AsCheckBox ChkTra_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkTra_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkTra_ck = value;
		}
	}

	internal virtual AsCheckBox ChkKhuyen_mai
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkKhuyen_mai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkKhuyen_mai = value;
		}
	}

	internal virtual AsCheckBox ChkHang_ban
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkHang_ban;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkHang_ban = value;
		}
	}

	private virtual Label lblLoai_hang
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai_hang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai_hang = value;
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

	public frmSORptBCPT06(ref string MenuId)
		: base(MenuId)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		__ENCAddToList(this);
		_oToolTip = new ToolTip();
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_362a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3634: Expected O, but got Unknown
		txtMa_Plvt1 = new AsTextBox();
		lblTen_plvt1 = new Label();
		lblPlvt1 = new Label();
		txtMa_Plvt2 = new AsTextBox();
		lblTen_plvt2 = new Label();
		lblPlvt2 = new Label();
		txtMa_plvt3 = new AsTextBox();
		lblTen_plvt3 = new Label();
		lblPlvt3 = new Label();
		txtMa_Plkh1 = new AsTextBox();
		lblTen_Plkh1 = new Label();
		lblPlkh1 = new Label();
		txtMa_Plkh2 = new AsTextBox();
		lblTen_Plkh2 = new Label();
		lblPlkh2 = new Label();
		txtMa_Plkh3 = new AsTextBox();
		lblTen_Plkh3 = new Label();
		lblPlkh3 = new Label();
		lblNhom_Theo = new Label();
		lblChi_Tiet_Theo = new Label();
		txtMa_kh = new AsTextBox();
		lblTen_KH = new Label();
		lblMa_Kh = new Label();
		txtMa_Nhkh = new AsTextBox();
		lblTen_nhkh = new Label();
		lblMa_Nhkh = new Label();
		lblMa_hd = new Label();
		txtMa_hd = new AsTextBox();
		lblTen_hd = new Label();
		txtMa_nhhd = new AsTextBox();
		lblTen_Nhhd = new Label();
		lblMa_nhhd = new Label();
		txtMa_kho = new AsTextBox();
		lblTen_kho = new Label();
		lblMa_kho = new Label();
		txtMa_bp = new AsTextBox();
		lblTen_bp = new Label();
		lblMa_bp = new Label();
		txtMa_nvkd = new AsTextBox();
		lblTen_nvkd = new Label();
		lblMa_nvkd = new Label();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		lblMa_vt = new Label();
		txtMa_nhvt = new AsTextBox();
		lblTen_Nhvt = new Label();
		lblMa_nhvt = new Label();
		txtMa_HTTT = new AsTextBox();
		lblTen_HTTT = new Label();
		lblMa_HTTT = new Label();
		cboNhom_Theo = new AsComboBox();
		cboChi_Tiet_Theo = new AsComboBox();
		ChkTra_lai = new AsCheckBox();
		lblTru = new Label();
		ChkTra_ck = new AsCheckBox();
		ChkKhuyen_mai = new AsCheckBox();
		ChkHang_ban = new AsCheckBox();
		lblLoai_hang = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)AsTabControl).Anchor = (AnchorStyles)5;
		((Control)AsTabControl).Dock = (DockStyle)5;
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(953, 540);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)ChkTra_lai);
		((Control)tabFilter).Controls.Add((Control)(object)lblTru);
		((Control)tabFilter).Controls.Add((Control)(object)ChkTra_ck);
		((Control)tabFilter).Controls.Add((Control)(object)ChkKhuyen_mai);
		((Control)tabFilter).Controls.Add((Control)(object)ChkHang_ban);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoai_hang);
		((Control)tabFilter).Controls.Add((Control)(object)cboChi_Tiet_Theo);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_HTTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_HTTT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_HTTT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bp);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_Theo);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Nhkh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Nhkh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_KH);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhkh);
		((Control)tabFilter).Controls.Add((Control)(object)lblChi_Tiet_Theo);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom_Theo);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlkh1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlkh2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlvt1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlvt2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt3);
		TabPage obj = tabFilter;
		size = new Size(945, 511);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom_Theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblChi_Tiet_Theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhkh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_KH, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Nhkh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nhkh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_Theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_HTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_HTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_HTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboChi_Tiet_Theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoai_hang, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkHang_ban, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkKhuyen_mai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkTra_ck, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTru, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkTra_lai, 0);
		Label obj2 = lbl2;
		Point location = new Point(329, 67);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 2;
		Button obj3 = cmdExcel;
		location = new Point(700, 830);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(348, 63);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 830);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 25;
		Button obj5 = cmdModifyReport;
		location = new Point(507, 12);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 201;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(258, 63);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(162, 63);
		((Control)obj6).Location = location;
		ComboBox obj7 = cboKyBc;
		size = new Size(87, 21);
		((Control)obj7).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		Label obj8 = lblKyBc;
		location = new Point(21, 67);
		((Control)obj8).Location = location;
		ComboBox obj9 = cboMau_bc;
		location = new Point(162, 14);
		((Control)obj9).Location = location;
		((Control)cboMau_bc).TabIndex = 200;
		Label obj10 = lblMau_bc;
		location = new Point(21, 17);
		((Control)obj10).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(162, 424);
		((Control)asTextBox).Location = location;
		((TextBoxBase)txtMa_Nt).MaxLength = 8;
		((Control)txtMa_Nt).TabIndex = 23;
		Label obj11 = lblMauBC;
		location = new Point(226, 428);
		((Control)obj11).Location = location;
		RadioButton obj12 = optVND;
		location = new Point(329, 426);
		((Control)obj12).Location = location;
		((Control)optVND).TabIndex = 24;
		RadioButton obj13 = optNt;
		location = new Point(389, 426);
		((Control)obj13).Location = location;
		((Control)optNt).TabIndex = 30;
		Label obj14 = lblMa_nt;
		location = new Point(21, 426);
		((Control)obj14).Location = location;
		Button obj15 = cmdOk;
		location = new Point(21, 460);
		((Control)obj15).Location = location;
		((Control)cmdOk).TabIndex = 18;
		Label obj16 = lblTieu_de;
		location = new Point(21, 42);
		((Control)obj16).Location = location;
		TextBox obj17 = txtTieu_De;
		location = new Point(162, 39);
		((Control)obj17).Location = location;
		((Control)txtTieu_De).TabIndex = 202;
		TabPage obj18 = tabGrid;
		size = new Size(782, 459);
		((Control)obj18).Size = size;
		txtMa_Plvt1.AutoLookup = true;
		txtMa_Plvt1.AutoValid = false;
		((TextBoxBase)txtMa_Plvt1).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plvt1).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_Plvt1).Enabled = false;
		AsTextBox asTextBox2 = txtMa_Plvt1;
		location = new Point(655, 234);
		((Control)asTextBox2).Location = location;
		txtMa_Plvt1.LookupCodeName = "MA_PLVT";
		txtMa_Plvt1.LookupWhereCondition = "loai='1'";
		((TextBoxBase)txtMa_Plvt1).MaxLength = 8;
		((Control)txtMa_Plvt1).Name = "txtMa_Plvt1";
		txtMa_Plvt1.NameControl = lblTen_plvt1;
		AsTextBox asTextBox3 = txtMa_Plvt1;
		size = new Size(87, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_Plvt1).TabIndex = 20;
		txtMa_Plvt1.UseAutoCompleteSource = true;
		((Control)txtMa_Plvt1).Visible = false;
		((Control)lblTen_plvt1).BackColor = Color.Transparent;
		((Control)lblTen_plvt1).Enabled = false;
		Label obj19 = lblTen_plvt1;
		location = new Point(751, 242);
		((Control)obj19).Location = location;
		((Control)lblTen_plvt1).Name = "lblTen_plvt1";
		Label obj20 = lblTen_plvt1;
		size = new Size(324, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_plvt1).TabIndex = 1032;
		((Control)lblTen_plvt1).Visible = false;
		lblPlvt1.AutoSize = true;
		((Control)lblPlvt1).Enabled = false;
		Label obj21 = lblPlvt1;
		location = new Point(592, 238);
		((Control)obj21).Location = location;
		((Control)lblPlvt1).Name = "lblPlvt1";
		Label obj22 = lblPlvt1;
		size = new Size(56, 13);
		((Control)obj22).Size = size;
		((Control)lblPlvt1).TabIndex = 1028;
		lblPlvt1.Text = "P.loại VT1";
		((Control)lblPlvt1).Visible = false;
		txtMa_Plvt2.AutoLookup = true;
		txtMa_Plvt2.AutoValid = false;
		((TextBoxBase)txtMa_Plvt2).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plvt2).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_Plvt2).Enabled = false;
		AsTextBox asTextBox4 = txtMa_Plvt2;
		location = new Point(655, 257);
		((Control)asTextBox4).Location = location;
		txtMa_Plvt2.LookupCodeName = "MA_PLVT";
		txtMa_Plvt2.LookupWhereCondition = "loai='2'";
		((TextBoxBase)txtMa_Plvt2).MaxLength = 8;
		((Control)txtMa_Plvt2).Name = "txtMa_Plvt2";
		txtMa_Plvt2.NameControl = lblTen_plvt2;
		AsTextBox asTextBox5 = txtMa_Plvt2;
		size = new Size(87, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_Plvt2).TabIndex = 21;
		txtMa_Plvt2.UseAutoCompleteSource = true;
		((Control)txtMa_Plvt2).Visible = false;
		((Control)lblTen_plvt2).BackColor = Color.Transparent;
		((Control)lblTen_plvt2).Enabled = false;
		Label obj23 = lblTen_plvt2;
		location = new Point(751, 265);
		((Control)obj23).Location = location;
		((Control)lblTen_plvt2).Name = "lblTen_plvt2";
		Label obj24 = lblTen_plvt2;
		size = new Size(324, 13);
		((Control)obj24).Size = size;
		((Control)lblTen_plvt2).TabIndex = 1031;
		((Control)lblTen_plvt2).Visible = false;
		lblPlvt2.AutoSize = true;
		((Control)lblPlvt2).Enabled = false;
		Label obj25 = lblPlvt2;
		location = new Point(592, 262);
		((Control)obj25).Location = location;
		((Control)lblPlvt2).Name = "lblPlvt2";
		Label obj26 = lblPlvt2;
		size = new Size(56, 13);
		((Control)obj26).Size = size;
		((Control)lblPlvt2).TabIndex = 1029;
		lblPlvt2.Text = "P.loại VT2";
		((Control)lblPlvt2).Visible = false;
		txtMa_plvt3.AutoLookup = true;
		txtMa_plvt3.AutoValid = false;
		((TextBoxBase)txtMa_plvt3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt3).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt3).Enabled = false;
		AsTextBox asTextBox6 = txtMa_plvt3;
		location = new Point(655, 278);
		((Control)asTextBox6).Location = location;
		txtMa_plvt3.LookupCodeName = "MA_PLVT";
		txtMa_plvt3.LookupWhereCondition = "loai='3'";
		((TextBoxBase)txtMa_plvt3).MaxLength = 8;
		((Control)txtMa_plvt3).Name = "txtMa_plvt3";
		txtMa_plvt3.NameControl = lblTen_plvt3;
		AsTextBox asTextBox7 = txtMa_plvt3;
		size = new Size(87, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_plvt3).TabIndex = 22;
		txtMa_plvt3.UseAutoCompleteSource = true;
		((Control)txtMa_plvt3).Visible = false;
		((Control)lblTen_plvt3).BackColor = Color.Transparent;
		((Control)lblTen_plvt3).Enabled = false;
		Label obj27 = lblTen_plvt3;
		location = new Point(751, 286);
		((Control)obj27).Location = location;
		((Control)lblTen_plvt3).Name = "lblTen_plvt3";
		Label obj28 = lblTen_plvt3;
		size = new Size(324, 13);
		((Control)obj28).Size = size;
		((Control)lblTen_plvt3).TabIndex = 1030;
		((Control)lblTen_plvt3).Visible = false;
		lblPlvt3.AutoSize = true;
		((Control)lblPlvt3).Enabled = false;
		Label obj29 = lblPlvt3;
		location = new Point(592, 283);
		((Control)obj29).Location = location;
		((Control)lblPlvt3).Name = "lblPlvt3";
		Label obj30 = lblPlvt3;
		size = new Size(56, 13);
		((Control)obj30).Size = size;
		((Control)lblPlvt3).TabIndex = 1027;
		lblPlvt3.Text = "P.loại VT3";
		((Control)lblPlvt3).Visible = false;
		txtMa_Plkh1.AutoLookup = true;
		txtMa_Plkh1.AutoValid = false;
		((TextBoxBase)txtMa_Plkh1).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_Plkh1;
		location = new Point(162, 136);
		((Control)asTextBox8).Location = location;
		txtMa_Plkh1.LookupCodeName = "MA_PLKH";
		txtMa_Plkh1.LookupWhereCondition = "loai='1'";
		((TextBoxBase)txtMa_Plkh1).MaxLength = 8;
		((Control)txtMa_Plkh1).Name = "txtMa_Plkh1";
		txtMa_Plkh1.NameControl = lblTen_Plkh1;
		AsTextBox asTextBox9 = txtMa_Plkh1;
		size = new Size(87, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_Plkh1).TabIndex = 6;
		txtMa_Plkh1.UseAutoCompleteSource = true;
		((Control)lblTen_Plkh1).BackColor = Color.Transparent;
		Label obj31 = lblTen_Plkh1;
		location = new Point(258, 140);
		((Control)obj31).Location = location;
		((Control)lblTen_Plkh1).Name = "lblTen_Plkh1";
		Label obj32 = lblTen_Plkh1;
		size = new Size(484, 13);
		((Control)obj32).Size = size;
		((Control)lblTen_Plkh1).TabIndex = 1041;
		lblPlkh1.AutoSize = true;
		Label obj33 = lblPlkh1;
		location = new Point(21, 140);
		((Control)obj33).Location = location;
		((Control)lblPlkh1).Name = "lblPlkh1";
		Label obj34 = lblPlkh1;
		size = new Size(57, 13);
		((Control)obj34).Size = size;
		((Control)lblPlkh1).TabIndex = 1037;
		lblPlkh1.Text = "P.loại KH1";
		txtMa_Plkh2.AutoLookup = true;
		txtMa_Plkh2.AutoValid = false;
		((TextBoxBase)txtMa_Plkh2).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_Plkh2;
		location = new Point(162, 160);
		((Control)asTextBox10).Location = location;
		txtMa_Plkh2.LookupCodeName = "MA_PLKH";
		txtMa_Plkh2.LookupWhereCondition = "loai='2'";
		((TextBoxBase)txtMa_Plkh2).MaxLength = 8;
		((Control)txtMa_Plkh2).Name = "txtMa_Plkh2";
		txtMa_Plkh2.NameControl = lblTen_Plkh2;
		AsTextBox asTextBox11 = txtMa_Plkh2;
		size = new Size(87, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_Plkh2).TabIndex = 7;
		txtMa_Plkh2.UseAutoCompleteSource = true;
		((Control)lblTen_Plkh2).BackColor = Color.Transparent;
		Label obj35 = lblTen_Plkh2;
		location = new Point(258, 164);
		((Control)obj35).Location = location;
		((Control)lblTen_Plkh2).Name = "lblTen_Plkh2";
		Label obj36 = lblTen_Plkh2;
		size = new Size(484, 13);
		((Control)obj36).Size = size;
		((Control)lblTen_Plkh2).TabIndex = 1040;
		lblPlkh2.AutoSize = true;
		Label obj37 = lblPlkh2;
		location = new Point(21, 164);
		((Control)obj37).Location = location;
		((Control)lblPlkh2).Name = "lblPlkh2";
		Label obj38 = lblPlkh2;
		size = new Size(57, 13);
		((Control)obj38).Size = size;
		((Control)lblPlkh2).TabIndex = 1038;
		lblPlkh2.Text = "P.loại KH2";
		txtMa_Plkh3.AutoLookup = true;
		txtMa_Plkh3.AutoValid = false;
		((TextBoxBase)txtMa_Plkh3).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_Plkh3;
		location = new Point(162, 184);
		((Control)asTextBox12).Location = location;
		txtMa_Plkh3.LookupCodeName = "MA_PLKH";
		txtMa_Plkh3.LookupWhereCondition = "loai='3'";
		((TextBoxBase)txtMa_Plkh3).MaxLength = 8;
		((Control)txtMa_Plkh3).Name = "txtMa_Plkh3";
		txtMa_Plkh3.NameControl = lblTen_Plkh3;
		AsTextBox asTextBox13 = txtMa_Plkh3;
		size = new Size(87, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_Plkh3).TabIndex = 8;
		txtMa_Plkh3.UseAutoCompleteSource = true;
		((Control)lblTen_Plkh3).BackColor = Color.Transparent;
		Label obj39 = lblTen_Plkh3;
		location = new Point(258, 188);
		((Control)obj39).Location = location;
		((Control)lblTen_Plkh3).Name = "lblTen_Plkh3";
		Label obj40 = lblTen_Plkh3;
		size = new Size(484, 13);
		((Control)obj40).Size = size;
		((Control)lblTen_Plkh3).TabIndex = 1039;
		lblPlkh3.AutoSize = true;
		Label obj41 = lblPlkh3;
		location = new Point(21, 188);
		((Control)obj41).Location = location;
		((Control)lblPlkh3).Name = "lblPlkh3";
		Label obj42 = lblPlkh3;
		size = new Size(57, 13);
		((Control)obj42).Size = size;
		((Control)lblPlkh3).TabIndex = 1036;
		lblPlkh3.Text = "P.loại KH3";
		lblNhom_Theo.AutoSize = true;
		Label obj43 = lblNhom_Theo;
		location = new Point(21, 91);
		((Control)obj43).Location = location;
		((Control)lblNhom_Theo).Name = "lblNhom_Theo";
		Label obj44 = lblNhom_Theo;
		size = new Size(59, 13);
		((Control)obj44).Size = size;
		((Control)lblNhom_Theo).TabIndex = 1043;
		lblNhom_Theo.Text = "Nhóm theo";
		lblChi_Tiet_Theo.AutoSize = true;
		Label obj45 = lblChi_Tiet_Theo;
		location = new Point(374, 91);
		((Control)obj45).Location = location;
		((Control)lblChi_Tiet_Theo).Name = "lblChi_Tiet_Theo";
		Label obj46 = lblChi_Tiet_Theo;
		size = new Size(63, 13);
		((Control)obj46).Size = size;
		((Control)lblChi_Tiet_Theo).TabIndex = 1044;
		lblChi_Tiet_Theo.Text = "Chi tiết theo";
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = false;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_kh;
		location = new Point(162, 112);
		((Control)asTextBox14).Location = location;
		txtMa_kh.LookupCodeName = "Ma_KH";
		txtMa_kh.LookupWhereCondition = " 1=1";
		((TextBoxBase)txtMa_kh).MaxLength = 20;
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = lblTen_KH;
		AsTextBox asTextBox15 = txtMa_kh;
		size = new Size(87, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_kh).TabIndex = 5;
		txtMa_kh.UseAutoCompleteSource = true;
		((Control)lblTen_KH).BackColor = Color.Transparent;
		Label obj47 = lblTen_KH;
		location = new Point(258, 116);
		((Control)obj47).Location = location;
		((Control)lblTen_KH).Name = "lblTen_KH";
		Label obj48 = lblTen_KH;
		size = new Size(484, 13);
		((Control)obj48).Size = size;
		((Control)lblTen_KH).TabIndex = 1051;
		lblMa_Kh.AutoSize = true;
		Label obj49 = lblMa_Kh;
		location = new Point(21, 116);
		((Control)obj49).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj50 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj50).Size = size;
		((Control)lblMa_Kh).TabIndex = 1049;
		lblMa_Kh.Text = "Mã khách hàng";
		txtMa_Nhkh.AutoLookup = true;
		txtMa_Nhkh.AutoValid = false;
		((TextBoxBase)txtMa_Nhkh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nhkh).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_Nhkh).Enabled = false;
		AsTextBox asTextBox16 = txtMa_Nhkh;
		location = new Point(562, 451);
		((Control)asTextBox16).Location = location;
		txtMa_Nhkh.LookupCodeName = "MA_NHKH";
		((TextBoxBase)txtMa_Nhkh).MaxLength = 8;
		((Control)txtMa_Nhkh).Name = "txtMa_Nhkh";
		txtMa_Nhkh.NameControl = lblTen_nhkh;
		AsTextBox asTextBox17 = txtMa_Nhkh;
		size = new Size(87, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtMa_Nhkh).TabIndex = 4;
		txtMa_Nhkh.UseAutoCompleteSource = true;
		((Control)txtMa_Nhkh).Visible = false;
		((Control)lblTen_nhkh).BackColor = Color.Transparent;
		((Control)lblTen_nhkh).Enabled = false;
		Label obj51 = lblTen_nhkh;
		location = new Point(658, 451);
		((Control)obj51).Location = location;
		((Control)lblTen_nhkh).Name = "lblTen_nhkh";
		Label obj52 = lblTen_nhkh;
		size = new Size(324, 13);
		((Control)obj52).Size = size;
		((Control)lblTen_nhkh).TabIndex = 1050;
		((Control)lblTen_nhkh).Visible = false;
		lblMa_Nhkh.AutoSize = true;
		((Control)lblMa_Nhkh).Enabled = false;
		Label obj53 = lblMa_Nhkh;
		location = new Point(476, 456);
		((Control)obj53).Location = location;
		((Control)lblMa_Nhkh).Name = "lblMa_Nhkh";
		Label obj54 = lblMa_Nhkh;
		size = new Size(56, 13);
		((Control)obj54).Size = size;
		((Control)lblMa_Nhkh).TabIndex = 1048;
		lblMa_Nhkh.Text = "Nhóm  KH";
		((Control)lblMa_Nhkh).Visible = false;
		lblMa_hd.AutoSize = true;
		Label obj55 = lblMa_hd;
		location = new Point(21, 212);
		((Control)obj55).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj56 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj56).Size = size;
		((Control)lblMa_hd).TabIndex = 1055;
		lblMa_hd.Text = "Mã hợp đồng";
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox18 = txtMa_hd;
		location = new Point(162, 208);
		((Control)asTextBox18).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((TextBoxBase)txtMa_hd).MaxLength = 20;
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox19 = txtMa_hd;
		size = new Size(87, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtMa_hd).TabIndex = 9;
		txtMa_hd.UseAutoCompleteSource = true;
		((Control)lblTen_hd).BackColor = Color.Transparent;
		Label obj57 = lblTen_hd;
		location = new Point(258, 212);
		((Control)obj57).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj58 = lblTen_hd;
		size = new Size(484, 13);
		((Control)obj58).Size = size;
		((Control)lblTen_hd).TabIndex = 1057;
		txtMa_nhhd.AutoLookup = true;
		txtMa_nhhd.AutoValid = false;
		((TextBoxBase)txtMa_nhhd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhhd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtMa_nhhd;
		location = new Point(162, 232);
		((Control)asTextBox20).Location = location;
		txtMa_nhhd.LookupCodeName = "MA_NHHD";
		((TextBoxBase)txtMa_nhhd).MaxLength = 8;
		((Control)txtMa_nhhd).Name = "txtMa_nhhd";
		txtMa_nhhd.NameControl = lblTen_Nhhd;
		AsTextBox asTextBox21 = txtMa_nhhd;
		size = new Size(87, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMa_nhhd).TabIndex = 10;
		txtMa_nhhd.UseAutoCompleteSource = true;
		((Control)lblTen_Nhhd).BackColor = Color.Transparent;
		Label obj59 = lblTen_Nhhd;
		location = new Point(258, 236);
		((Control)obj59).Location = location;
		((Control)lblTen_Nhhd).Name = "lblTen_Nhhd";
		Label obj60 = lblTen_Nhhd;
		size = new Size(484, 13);
		((Control)obj60).Size = size;
		((Control)lblTen_Nhhd).TabIndex = 1056;
		lblMa_nhhd.AutoSize = true;
		Label obj61 = lblMa_nhhd;
		location = new Point(21, 236);
		((Control)obj61).Location = location;
		((Control)lblMa_nhhd).Name = "lblMa_nhhd";
		Label obj62 = lblMa_nhhd;
		size = new Size(84, 13);
		((Control)obj62).Size = size;
		((Control)lblMa_nhhd).TabIndex = 1054;
		lblMa_nhhd.Text = "Nhóm hợp đồng";
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox22 = txtMa_kho;
		location = new Point(162, 280);
		((Control)asTextBox22).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((TextBoxBase)txtMa_kho).MaxLength = 20;
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox23 = txtMa_kho;
		size = new Size(87, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMa_kho).TabIndex = 12;
		txtMa_kho.UseAutoCompleteSource = true;
		((Control)lblTen_kho).BackColor = Color.Transparent;
		Label obj63 = lblTen_kho;
		location = new Point(258, 284);
		((Control)obj63).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj64 = lblTen_kho;
		size = new Size(484, 13);
		((Control)obj64).Size = size;
		((Control)lblTen_kho).TabIndex = 1066;
		lblMa_kho.AutoSize = true;
		Label obj65 = lblMa_kho;
		location = new Point(21, 284);
		((Control)obj65).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj66 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj66).Size = size;
		((Control)lblMa_kho).TabIndex = 1062;
		lblMa_kho.Text = "Mã kho";
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox24 = txtMa_bp;
		location = new Point(162, 304);
		((Control)asTextBox24).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((TextBoxBase)txtMa_bp).MaxLength = 20;
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox25 = txtMa_bp;
		size = new Size(87, 20);
		((Control)asTextBox25).Size = size;
		((Control)txtMa_bp).TabIndex = 13;
		txtMa_bp.UseAutoCompleteSource = true;
		((Control)lblTen_bp).BackColor = Color.Transparent;
		Label obj67 = lblTen_bp;
		location = new Point(258, 308);
		((Control)obj67).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj68 = lblTen_bp;
		size = new Size(484, 13);
		((Control)obj68).Size = size;
		((Control)lblTen_bp).TabIndex = 1065;
		lblMa_bp.AutoSize = true;
		Label obj69 = lblMa_bp;
		location = new Point(21, 308);
		((Control)obj69).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj70 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj70).Size = size;
		((Control)lblMa_bp).TabIndex = 1063;
		lblMa_bp.Text = "Mã bộ phận";
		txtMa_nvkd.AutoLookup = true;
		txtMa_nvkd.AutoValid = false;
		((TextBoxBase)txtMa_nvkd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nvkd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox26 = txtMa_nvkd;
		location = new Point(162, 328);
		((Control)asTextBox26).Location = location;
		txtMa_nvkd.LookupCodeName = "MA_NVKD";
		((TextBoxBase)txtMa_nvkd).MaxLength = 20;
		((Control)txtMa_nvkd).Name = "txtMa_nvkd";
		txtMa_nvkd.NameControl = lblTen_nvkd;
		AsTextBox asTextBox27 = txtMa_nvkd;
		size = new Size(87, 20);
		((Control)asTextBox27).Size = size;
		((Control)txtMa_nvkd).TabIndex = 14;
		txtMa_nvkd.UseAutoCompleteSource = true;
		((Control)lblTen_nvkd).BackColor = Color.Transparent;
		Label obj71 = lblTen_nvkd;
		location = new Point(258, 332);
		((Control)obj71).Location = location;
		((Control)lblTen_nvkd).Name = "lblTen_nvkd";
		Label obj72 = lblTen_nvkd;
		size = new Size(484, 13);
		((Control)obj72).Size = size;
		((Control)lblTen_nvkd).TabIndex = 1064;
		lblMa_nvkd.AutoSize = true;
		Label obj73 = lblMa_nvkd;
		location = new Point(21, 332);
		((Control)obj73).Location = location;
		((Control)lblMa_nvkd).Name = "lblMa_nvkd";
		Label obj74 = lblMa_nvkd;
		size = new Size(55, 13);
		((Control)obj74).Size = size;
		((Control)lblMa_nvkd).TabIndex = 1061;
		lblMa_nvkd.Text = "Mã NVKD";
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox28 = txtMa_vt;
		location = new Point(162, 352);
		((Control)asTextBox28).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((TextBoxBase)txtMa_vt).MaxLength = 20;
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox29 = txtMa_vt;
		size = new Size(87, 20);
		((Control)asTextBox29).Size = size;
		((Control)txtMa_vt).TabIndex = 15;
		txtMa_vt.UseAutoCompleteSource = true;
		((Control)lblTen_vt).BackColor = Color.Transparent;
		Label obj75 = lblTen_vt;
		location = new Point(258, 356);
		((Control)obj75).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj76 = lblTen_vt;
		size = new Size(484, 13);
		((Control)obj76).Size = size;
		((Control)lblTen_vt).TabIndex = 1072;
		lblMa_vt.AutoSize = true;
		Label obj77 = lblMa_vt;
		location = new Point(21, 356);
		((Control)obj77).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj78 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj78).Size = size;
		((Control)lblMa_vt).TabIndex = 1070;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox30 = txtMa_nhvt;
		location = new Point(162, 376);
		((Control)asTextBox30).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((TextBoxBase)txtMa_nhvt).MaxLength = 8;
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_Nhvt;
		AsTextBox asTextBox31 = txtMa_nhvt;
		size = new Size(87, 20);
		((Control)asTextBox31).Size = size;
		((Control)txtMa_nhvt).TabIndex = 16;
		txtMa_nhvt.UseAutoCompleteSource = true;
		((Control)lblTen_Nhvt).BackColor = Color.Transparent;
		Label obj79 = lblTen_Nhvt;
		location = new Point(258, 380);
		((Control)obj79).Location = location;
		((Control)lblTen_Nhvt).Name = "lblTen_Nhvt";
		Label obj80 = lblTen_Nhvt;
		size = new Size(484, 13);
		((Control)obj80).Size = size;
		((Control)lblTen_Nhvt).TabIndex = 1071;
		lblMa_nhvt.AutoSize = true;
		Label obj81 = lblMa_nhvt;
		location = new Point(21, 380);
		((Control)obj81).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj82 = lblMa_nhvt;
		size = new Size(65, 13);
		((Control)obj82).Size = size;
		((Control)lblMa_nhvt).TabIndex = 1069;
		lblMa_nhvt.Text = "Nhóm vật tư";
		txtMa_HTTT.AutoLookup = true;
		txtMa_HTTT.AutoValid = false;
		((TextBoxBase)txtMa_HTTT).BackColor = SystemColors.Info;
		((TextBox)txtMa_HTTT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox32 = txtMa_HTTT;
		location = new Point(162, 256);
		((Control)asTextBox32).Location = location;
		txtMa_HTTT.LookupCodeName = "MA_HTTT";
		txtMa_HTTT.LookupWhereCondition = "MODULEID = 'SO'";
		((TextBoxBase)txtMa_HTTT).MaxLength = 20;
		((Control)txtMa_HTTT).Name = "txtMa_HTTT";
		txtMa_HTTT.NameControl = lblTen_HTTT;
		AsTextBox asTextBox33 = txtMa_HTTT;
		size = new Size(87, 20);
		((Control)asTextBox33).Size = size;
		((Control)txtMa_HTTT).TabIndex = 11;
		txtMa_HTTT.UseAutoCompleteSource = true;
		((Control)lblTen_HTTT).BackColor = Color.Transparent;
		Label obj83 = lblTen_HTTT;
		location = new Point(258, 260);
		((Control)obj83).Location = location;
		((Control)lblTen_HTTT).Name = "lblTen_HTTT";
		Label obj84 = lblTen_HTTT;
		size = new Size(484, 13);
		((Control)obj84).Size = size;
		((Control)lblTen_HTTT).TabIndex = 1075;
		lblMa_HTTT.AutoSize = true;
		Label obj85 = lblMa_HTTT;
		location = new Point(21, 260);
		((Control)obj85).Location = location;
		((Control)lblMa_HTTT).Name = "lblMa_HTTT";
		Label obj86 = lblMa_HTTT;
		size = new Size(54, 13);
		((Control)obj86).Size = size;
		((Control)lblMa_HTTT).TabIndex = 1074;
		lblMa_HTTT.Text = "Mã HTTT";
		((ListControl)cboNhom_Theo).DisplayMember = "0";
		((ComboBox)cboNhom_Theo).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_Theo).FormattingEnabled = true;
		((ComboBox)cboNhom_Theo).Items.AddRange(new object[6] { "Khách hàng", "Bộ phận", "Hợp đồng", "Hình thức thanh toán", "Nhân viên kinh doanh", "Vật tư" });
		AsComboBox asComboBox = cboNhom_Theo;
		location = new Point(162, 87);
		((Control)asComboBox).Location = location;
		((Control)cboNhom_Theo).Name = "cboNhom_Theo";
		AsComboBox asComboBox2 = cboNhom_Theo;
		size = new Size(122, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboNhom_Theo).TabIndex = 3;
		((ListControl)cboNhom_Theo).ValueMember = "0";
		((ComboBox)cboChi_Tiet_Theo).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboChi_Tiet_Theo).FormattingEnabled = true;
		((ComboBox)cboChi_Tiet_Theo).Items.AddRange(new object[6] { "Vật tư", "Khách hàng", "Bộ phận", "Hợp đồng", "HTTT", "NVKD" });
		AsComboBox asComboBox3 = cboChi_Tiet_Theo;
		location = new Point(460, 87);
		((Control)asComboBox3).Location = location;
		((Control)cboChi_Tiet_Theo).Name = "cboChi_Tiet_Theo";
		AsComboBox asComboBox4 = cboChi_Tiet_Theo;
		size = new Size(122, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboChi_Tiet_Theo).TabIndex = 4;
		((ButtonBase)ChkTra_lai).AutoSize = true;
		ChkTra_lai.Checked = true;
		((CheckBox)ChkTra_lai).CheckState = (CheckState)1;
		AsCheckBox chkTra_lai = ChkTra_lai;
		location = new Point(162, 402);
		((Control)chkTra_lai).Location = location;
		((Control)ChkTra_lai).Name = "ChkTra_lai";
		AsCheckBox chkTra_lai2 = ChkTra_lai;
		size = new Size(101, 17);
		((Control)chkTra_lai2).Size = size;
		((Control)ChkTra_lai).TabIndex = 17;
		((ButtonBase)ChkTra_lai).Text = "Hàng bán trả lại";
		((ButtonBase)ChkTra_lai).UseVisualStyleBackColor = true;
		lblTru.AutoSize = true;
		lblTru.ImeMode = (ImeMode)0;
		Label obj87 = lblTru;
		location = new Point(21, 404);
		((Control)obj87).Location = location;
		((Control)lblTru).Name = "lblTru";
		Label obj88 = lblTru;
		size = new Size(23, 13);
		((Control)obj88).Size = size;
		((Control)lblTru).TabIndex = 1081;
		lblTru.Text = "Trừ";
		((ButtonBase)ChkTra_ck).AutoSize = true;
		ChkTra_ck.Checked = true;
		((CheckBox)ChkTra_ck).CheckState = (CheckState)1;
		((Control)ChkTra_ck).Enabled = false;
		AsCheckBox chkTra_ck = ChkTra_ck;
		location = new Point(796, 415);
		((Control)chkTra_ck).Location = location;
		((Control)ChkTra_ck).Name = "ChkTra_ck";
		AsCheckBox chkTra_ck2 = ChkTra_ck;
		size = new Size(105, 17);
		((Control)chkTra_ck2).Size = size;
		((Control)ChkTra_ck).TabIndex = 15;
		((ButtonBase)ChkTra_ck).Text = "Hàng chiết khấu";
		((ButtonBase)ChkTra_ck).UseVisualStyleBackColor = true;
		((Control)ChkTra_ck).Visible = false;
		((ButtonBase)ChkKhuyen_mai).AutoSize = true;
		ChkKhuyen_mai.Checked = true;
		((CheckBox)ChkKhuyen_mai).CheckState = (CheckState)1;
		((Control)ChkKhuyen_mai).Enabled = false;
		AsCheckBox chkKhuyen_mai = ChkKhuyen_mai;
		location = new Point(741, 377);
		((Control)chkKhuyen_mai).Location = location;
		((Control)ChkKhuyen_mai).Name = "ChkKhuyen_mai";
		AsCheckBox chkKhuyen_mai2 = ChkKhuyen_mai;
		size = new Size(91, 17);
		((Control)chkKhuyen_mai2).Size = size;
		((Control)ChkKhuyen_mai).TabIndex = 14;
		((ButtonBase)ChkKhuyen_mai).Text = "Hàng trả K/M";
		((ButtonBase)ChkKhuyen_mai).UseVisualStyleBackColor = true;
		((Control)ChkKhuyen_mai).Visible = false;
		((ButtonBase)ChkHang_ban).AutoSize = true;
		ChkHang_ban.Checked = true;
		((CheckBox)ChkHang_ban).CheckState = (CheckState)1;
		((Control)ChkHang_ban).Enabled = false;
		AsCheckBox chkHang_ban = ChkHang_ban;
		location = new Point(662, 376);
		((Control)chkHang_ban).Location = location;
		((Control)ChkHang_ban).Name = "ChkHang_ban";
		AsCheckBox chkHang_ban2 = ChkHang_ban;
		size = new Size(73, 17);
		((Control)chkHang_ban2).Size = size;
		((Control)ChkHang_ban).TabIndex = 13;
		((ButtonBase)ChkHang_ban).Text = "Hàng bán";
		((ButtonBase)ChkHang_ban).UseVisualStyleBackColor = true;
		((Control)ChkHang_ban).Visible = false;
		lblLoai_hang.AutoSize = true;
		((Control)lblLoai_hang).Enabled = false;
		lblLoai_hang.ImeMode = (ImeMode)0;
		Label obj89 = lblLoai_hang;
		location = new Point(576, 381);
		((Control)obj89).Location = location;
		((Control)lblLoai_hang).Name = "lblLoai_hang";
		Label obj90 = lblLoai_hang;
		size = new Size(54, 13);
		((Control)obj90).Size = size;
		((Control)lblLoai_hang).TabIndex = 1080;
		lblLoai_hang.Text = "Loại hàng";
		((Control)lblLoai_hang).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).AutoScroll = true;
		((Form)this).AutoSize = true;
		size = new Size(953, 562);
		((Form)this).ClientSize = size;
		((Control)this).Cursor = Cursors.Arrow;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmSORptBCPT06";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		base.InitOtherComponents();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		AsComboBox asComboBox = cboChi_Tiet_Theo;
		dictionary.Add("Ma_VT", Conversions.ToString(((ComboBox)asComboBox).Items[0]));
		dictionary.Add("Ma_KH", Conversions.ToString(((ComboBox)asComboBox).Items[1]));
		dictionary.Add("MA_BP", Conversions.ToString(((ComboBox)asComboBox).Items[2]));
		dictionary.Add("MA_HD", Conversions.ToString(((ComboBox)asComboBox).Items[3]));
		dictionary.Add("MA_HTTT", Conversions.ToString(((ComboBox)asComboBox).Items[4]));
		dictionary.Add("MA_NVKD", Conversions.ToString(((ComboBox)asComboBox).Items[5]));
		BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
		((ComboBox)asComboBox).DataSource = dataSource;
		((ListControl)asComboBox).DisplayMember = "value";
		((ListControl)asComboBox).ValueMember = "key";
		((ComboBox)asComboBox).SelectedIndex = 0;
		asComboBox = null;
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		AsComboBox asComboBox2 = cboNhom_Theo;
		dictionary2.Add("Ma_KH", Conversions.ToString(((ComboBox)asComboBox2).Items[0]));
		dictionary2.Add("MA_BP", Conversions.ToString(((ComboBox)asComboBox2).Items[1]));
		dictionary2.Add("Ma_HD", Conversions.ToString(((ComboBox)asComboBox2).Items[2]));
		dictionary2.Add("Ma_HTTT", Conversions.ToString(((ComboBox)asComboBox2).Items[3]));
		dictionary2.Add("MA_NVKD", Conversions.ToString(((ComboBox)asComboBox2).Items[4]));
		dictionary2.Add("MA_VT", Conversions.ToString(((ComboBox)asComboBox2).Items[5]));
		BindingSource dataSource2 = new BindingSource((object)dictionary2, (string)null);
		((ComboBox)asComboBox2).DataSource = dataSource2;
		((ListControl)asComboBox2).ValueMember = "Key";
		((ListControl)asComboBox2).DisplayMember = "Value";
		((ComboBox)asComboBox2).SelectedIndex = 0;
		asComboBox2 = null;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_kh).Text);
		arrayList.Add(((TextBox)txtMa_Nhkh).Text);
		arrayList.Add(((TextBox)txtMa_Plkh1).Text);
		arrayList.Add(((TextBox)txtMa_Plkh2).Text);
		arrayList.Add(((TextBox)txtMa_Plkh3).Text);
		arrayList.Add(((TextBox)txtMa_bp).Text);
		arrayList.Add(((TextBox)txtMa_nvkd).Text);
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtMa_nhhd).Text);
		arrayList.Add(((TextBox)txtMa_Plvt1).Text);
		arrayList.Add(((TextBox)txtMa_Plvt2).Text);
		arrayList.Add(((TextBox)txtMa_plvt3).Text);
		arrayList.Add(((TextBox)txtMa_HTTT).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkHang_ban.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkKhuyen_mai.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_ck.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_lai.Checked));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboNhom_Theo).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboChi_Tiet_Theo).SelectedValue));
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		base.MyFomularFields.Add("detailsType", RuntimeHelpers.GetObjectValue(((ListControl)cboChi_Tiet_Theo).SelectedValue));
		return true;
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		if ((int)keycode == 116)
		{
			ArrayList arrayList = new ArrayList();
			DataRowView dataRowView = get_MyDGVSource(isSet2Print: true).DefaultView[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			arrayList.Add(MyMenuInfo.par1);
			string text = ((ListControl)cboNhom_Theo).SelectedValue.ToString().ToUpper();
			if (Operators.CompareString(text, "MA_KH", false) == 0)
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]));
			}
			else
			{
				string text2 = ((ListControl)cboChi_Tiet_Theo).SelectedValue.ToString().ToUpper();
				if (Operators.CompareString(text2, "MA_KH", false) == 0)
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_detail"]));
				}
				else
				{
					arrayList.Add(((TextBox)txtMa_kh).Text);
				}
			}
			arrayList.Add(((TextBox)txtMa_Nhkh).Text);
			arrayList.Add(((TextBox)txtMa_Plkh1).Text);
			arrayList.Add(((TextBox)txtMa_Plkh2).Text);
			arrayList.Add(((TextBox)txtMa_Plkh3).Text);
			string text3 = ((ListControl)cboNhom_Theo).SelectedValue.ToString().ToUpper();
			if (Operators.CompareString(text3, "MA_VT", false) == 0)
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]));
			}
			else
			{
				string text4 = ((ListControl)cboChi_Tiet_Theo).SelectedValue.ToString().ToUpper();
				if (Operators.CompareString(text4, "MA_VT", false) == 0)
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_detail"]));
				}
				else
				{
					arrayList.Add(((TextBox)txtMa_vt).Text);
				}
			}
			arrayList.Add(((TextBox)txtMa_nhvt).Text);
			arrayList.Add("");
			arrayList.Add(((TextBox)txtMa_kho).Text);
			string text5 = ((ListControl)cboNhom_Theo).SelectedValue.ToString().ToUpper();
			if (Operators.CompareString(text5, "MA_BP", false) == 0)
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]));
			}
			else
			{
				string text6 = ((ListControl)cboChi_Tiet_Theo).SelectedValue.ToString().ToUpper();
				if (Operators.CompareString(text6, "MA_BP", false) == 0)
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_detail"]));
				}
				else
				{
					arrayList.Add(((TextBox)txtMa_bp).Text);
				}
			}
			string text7 = ((ListControl)cboNhom_Theo).SelectedValue.ToString().ToUpper();
			if (Operators.CompareString(text7, "MA_NVKD", false) == 0)
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]));
			}
			else
			{
				string text8 = ((ListControl)cboChi_Tiet_Theo).SelectedValue.ToString().ToUpper();
				if (Operators.CompareString(text8, "MA_NVKD", false) == 0)
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_detail"]));
				}
				else
				{
					arrayList.Add(((TextBox)txtMa_nvkd).Text);
				}
			}
			string text9 = ((ListControl)cboNhom_Theo).SelectedValue.ToString().ToUpper();
			if (Operators.CompareString(text9, "MA_HD", false) == 0)
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]));
			}
			else
			{
				string text10 = ((ListControl)cboChi_Tiet_Theo).SelectedValue.ToString().ToUpper();
				if (Operators.CompareString(text10, "MA_HD", false) == 0)
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_detail"]));
				}
				else
				{
					arrayList.Add(((TextBox)txtMa_hd).Text);
				}
			}
			string text11 = ((ListControl)cboNhom_Theo).SelectedValue.ToString().ToUpper();
			if (Operators.CompareString(text11, "MA_HTTT", false) == 0)
			{
				arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]));
			}
			else
			{
				string text12 = ((ListControl)cboChi_Tiet_Theo).SelectedValue.ToString().ToUpper();
				if (Operators.CompareString(text12, "MA_HTTT", false) == 0)
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_detail"]));
				}
				else
				{
					arrayList.Add(((TextBox)txtMa_HTTT).Text);
				}
			}
			arrayList.Add(RuntimeHelpers.GetObjectValue(convertoToInt(Conversions.ToBoolean(ChkKhuyen_mai.Checked))));
			arrayList.Add(RuntimeHelpers.GetObjectValue(convertoToInt(Conversions.ToBoolean(ChkTra_ck.Checked))));
			arrayList.Add(RuntimeHelpers.GetObjectValue(convertoToInt(Conversions.ToBoolean(ChkHang_ban.Checked))));
			arrayList.Add(RuntimeHelpers.GetObjectValue(convertoToInt(Conversions.ToBoolean(Operators.NotObject(ChkTra_lai.Checked)))));
			arrayList.Add(((TextBox)txtMa_Nt).Text);
			arrayList.Add("");
			filterCondition4title = dataRowView["ma_group"].ToString() + dataRowView["ten_group"].ToString();
			return arrayList;
		}
		base.CancelDrilldown = true;
		return null;
	}

	private object convertoToInt(bool ck)
	{
		int num = 0;
		num = (ck ? 1 : 0);
		return num;
	}

	private string GetFilterTitle()
	{
		string text = string.Empty;
		if (Operators.CompareString(((ComboBox)cboNhom_Theo).Text.Trim(), "", false) != 0)
		{
			text = text + lblNhom_Theo.Text + ": [" + ((ComboBox)cboNhom_Theo).Text + "]; ";
		}
		if (Operators.CompareString(((ComboBox)cboChi_Tiet_Theo).Text.Trim(), "", false) != 0)
		{
			text = text + lblChi_Tiet_Theo.Text + ": [" + ((ComboBox)cboChi_Tiet_Theo).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Kh.Text + ": [" + ((TextBox)txtMa_kh).Text + " - " + lblTen_KH.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nhkh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Nhkh.Text + ": [" + ((TextBox)txtMa_Nhkh).Text + " - " + lblTen_nhkh.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plkh1).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlkh1.Text + ": [" + ((TextBox)txtMa_Plkh1).Text + " - " + lblTen_Plkh1.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plkh2).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlkh2.Text + ": [" + ((TextBox)txtMa_Plkh2).Text + " - " + lblTen_Plkh2.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plkh3).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlkh3.Text + ": [" + ((TextBox)txtMa_Plkh3).Text + " - " + lblTen_Plkh3.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_hd).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_hd.Text + ": [" + ((TextBox)txtMa_hd).Text + " - " + lblTen_hd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhhd).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nhhd.Text + ": [" + ((TextBox)txtMa_nhhd).Text + " - " + lblTen_Nhhd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_HTTT).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_HTTT.Text + ": [" + ((TextBox)txtMa_HTTT).Text + " - " + lblTen_HTTT.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": [" + ((TextBox)txtMa_kho).Text + " - " + lblTen_kho.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_bp).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_bp.Text + ": [" + ((TextBox)txtMa_bp).Text + " - " + lblTen_bp.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nvkd).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nvkd.Text + ": [" + ((TextBox)txtMa_nvkd).Text + " - " + lblTen_nvkd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_vt.Text + ":" + ((TextBox)txtMa_vt).Text + " - " + lblTen_vt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhvt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nhvt.Text + ": [" + ((TextBox)txtMa_nhvt).Text + " - " + lblTen_Nhvt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plvt1).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlvt1.Text + ": [" + ((TextBox)txtMa_Plvt1).Text + " - " + lblTen_plvt1.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plvt2).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlvt2.Text + ": [" + ((TextBox)txtMa_Plvt2).Text + " - " + lblTen_plvt2.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt3).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlvt3.Text + ": [" + ((TextBox)txtMa_plvt3).Text + " - " + lblTen_plvt3.Text + "]; ";
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(ChkHang_ban.Checked, ChkKhuyen_mai.Checked), ChkTra_ck.Checked)))
		{
			text = text + lblLoai_hang.Text + ": [";
			if (Conversions.ToBoolean(ChkHang_ban.Checked))
			{
				text = text + ((ButtonBase)ChkHang_ban).Text + " - ";
			}
			if (Conversions.ToBoolean(ChkKhuyen_mai.Checked))
			{
				text = text + ((ButtonBase)ChkKhuyen_mai).Text + " - ";
			}
			if (Conversions.ToBoolean(ChkTra_ck.Checked))
			{
				text += ((ButtonBase)ChkTra_ck).Text;
			}
			text += "]; ";
		}
		if (Conversions.ToBoolean(ChkTra_lai.Checked))
		{
			text = text + lblTru.Text + ": [" + ((ButtonBase)ChkTra_lai).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": [" + ((TextBox)txtMa_Nt).Text + "]; ";
		}
		return text;
	}

	private void cboChi_Tiet_Theo_GotFocus(object sender, EventArgs e)
	{
		if ((((ComboBox)cboNhom_Theo).SelectedIndex > -1 && (float)((ComboBox)cboNhom_Theo).Text.Length * ((Control)cboNhom_Theo).Font.Size > (float)((Control)cboNhom_Theo).Width) ? true : false)
		{
			_oToolTip.Show(((ComboBox)cboNhom_Theo).Text, (IWin32Window)(object)cboNhom_Theo);
		}
		else
		{
			_oToolTip.Hide((IWin32Window)(object)cboNhom_Theo);
		}
		if ((((ComboBox)cboChi_Tiet_Theo).SelectedIndex > -1 && (float)((ComboBox)cboChi_Tiet_Theo).Text.Length * ((Control)cboChi_Tiet_Theo).Font.Size > (float)((Control)cboChi_Tiet_Theo).Width) ? true : false)
		{
			_oToolTip.Show(((ComboBox)cboChi_Tiet_Theo).Text, (IWin32Window)(object)cboChi_Tiet_Theo);
		}
		else
		{
			_oToolTip.Hide((IWin32Window)(object)cboChi_Tiet_Theo);
		}
	}

	private void cboNhom_Theo_SelectedIndexChanged(object sender, EventArgs e)
	{
		cboChi_Tiet_Theo_GotFocus(null, null);
	}
}
