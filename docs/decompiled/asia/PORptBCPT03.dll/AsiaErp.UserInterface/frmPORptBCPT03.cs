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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmPORptBCPT03 : frmReport
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

	[AccessedThroughProperty("lblTen_lkh1")]
	private Label _lblTen_lkh1;

	[AccessedThroughProperty("lblPlkh1")]
	private Label _lblPlkh1;

	[AccessedThroughProperty("txtMa_Plkh2")]
	private AsTextBox _txtMa_Plkh2;

	[AccessedThroughProperty("lblTen_lkh2")]
	private Label _lblTen_lkh2;

	[AccessedThroughProperty("lblPlkh2")]
	private Label _lblPlkh2;

	[AccessedThroughProperty("txtMa_Plkh3")]
	private AsTextBox _txtMa_Plkh3;

	[AccessedThroughProperty("lblTen_lkh3")]
	private Label _lblTen_lkh3;

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

	[AccessedThroughProperty("lblDKTT")]
	private Label _lblDKTT;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtMa_DKTT")]
	private AsTextBox _txtMa_DKTT;

	[AccessedThroughProperty("txtMa_phi")]
	private AsTextBox _txtMa_phi;

	[AccessedThroughProperty("lblMa_phi")]
	private Label _lblMa_phi;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtMa_lo")]
	private AsTextBox _txtMa_lo;

	[AccessedThroughProperty("lblMa_lo")]
	private Label _lblMa_lo;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("txtMa_vitri")]
	private AsTextBox _txtMa_vitri;

	[AccessedThroughProperty("lblMa_vitri")]
	private Label _lblMa_vitri;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	private ToolTip oToolTip;

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

	internal virtual Label lblTen_lkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_lkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_lkh1 = value;
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

	internal virtual Label lblTen_lkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_lkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_lkh2 = value;
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

	internal virtual Label lblTen_lkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_lkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_lkh3 = value;
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

	internal virtual Label lblDKTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDKTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDKTT = value;
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

	internal virtual AsTextBox txtMa_DKTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_DKTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_DKTT = value;
		}
	}

	internal virtual AsTextBox txtMa_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_phi = value;
		}
	}

	internal virtual Label lblMa_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_phi = value;
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

	internal virtual AsTextBox txtMa_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_lo = value;
		}
	}

	internal virtual Label lblMa_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_lo = value;
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

	internal virtual AsTextBox txtMa_vitri
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_vitri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_vitri = value;
		}
	}

	internal virtual Label lblMa_vitri
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_vitri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_vitri = value;
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

	internal virtual AsTextBox txtMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_spct = value;
		}
	}

	internal virtual Label lblMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_spct = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
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

	public frmPORptBCPT03(ref string MenuId)
		: base(MenuId)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		__ENCAddToList(this);
		oToolTip = new ToolTip();
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
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_39d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_39e3: Expected O, but got Unknown
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
		lblTen_lkh1 = new Label();
		lblPlkh1 = new Label();
		txtMa_Plkh2 = new AsTextBox();
		lblTen_lkh2 = new Label();
		lblPlkh2 = new Label();
		txtMa_Plkh3 = new AsTextBox();
		lblTen_lkh3 = new Label();
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
		lblDKTT = new Label();
		Label2 = new Label();
		txtMa_DKTT = new AsTextBox();
		txtMa_vitri = new AsTextBox();
		lblMa_vitri = new Label();
		Label4 = new Label();
		txtMa_lo = new AsTextBox();
		lblMa_lo = new Label();
		Label6 = new Label();
		txtMa_phi = new AsTextBox();
		lblMa_phi = new Label();
		Label8 = new Label();
		txtMa_spct = new AsTextBox();
		lblMa_spct = new Label();
		Label10 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(956, 544);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)Label10);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_phi);
		((Control)tabFilter).Controls.Add((Control)(object)Label8);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_phi);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_lo);
		((Control)tabFilter).Controls.Add((Control)(object)Label6);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_lo);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)Label4);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblDKTT);
		((Control)tabFilter).Controls.Add((Control)(object)Label2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_DKTT);
		((Control)tabFilter).Controls.Add((Control)(object)ChkTra_lai);
		((Control)tabFilter).Controls.Add((Control)(object)lblTru);
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
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_Theo);
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
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lkh1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lkh3);
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
		size = new Size(948, 515);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lkh1, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_Theo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTru, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkTra_lai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_DKTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDKTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label10, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		Label obj2 = lbl2;
		Point location = new Point(368, 72);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 2;
		Button obj3 = cmdExcel;
		location = new Point(791, 358);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(387, 68);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(710, 358);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 25;
		Button obj5 = cmdModifyReport;
		location = new Point(546, 17);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 28;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(297, 68);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(201, 68);
		((Control)obj6).Location = location;
		ComboBox obj7 = cboKyBc;
		size = new Size(87, 21);
		((Control)obj7).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		Label obj8 = lblKyBc;
		location = new Point(25, 72);
		((Control)obj8).Location = location;
		ComboBox obj9 = cboMau_bc;
		location = new Point(201, 19);
		((Control)obj9).Location = location;
		((Control)cboMau_bc).TabIndex = 26;
		Label obj10 = lblMau_bc;
		location = new Point(25, 22);
		((Control)obj10).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(201, 443);
		((Control)asTextBox).Location = location;
		((TextBoxBase)txtMa_Nt).MaxLength = 8;
		((Control)txtMa_Nt).TabIndex = 19;
		Label obj11 = lblMauBC;
		location = new Point(265, 442);
		((Control)obj11).Location = location;
		RadioButton obj12 = optVND;
		location = new Point(368, 441);
		((Control)obj12).Location = location;
		((Control)optVND).TabIndex = 24;
		RadioButton obj13 = optNt;
		location = new Point(422, 443);
		((Control)obj13).Location = location;
		((Control)optNt).TabIndex = 20;
		Label obj14 = lblMa_nt;
		location = new Point(25, 445);
		((Control)obj14).Location = location;
		Button obj15 = cmdOk;
		location = new Point(25, 477);
		((Control)obj15).Location = location;
		((Control)cmdOk).TabIndex = 21;
		Label obj16 = lblTieu_de;
		location = new Point(25, 47);
		((Control)obj16).Location = location;
		TextBox obj17 = txtTieu_De;
		location = new Point(201, 44);
		((Control)obj17).Location = location;
		((Control)txtTieu_De).TabIndex = 27;
		TabPage obj18 = tabGrid;
		size = new Size(948, 588);
		((Control)obj18).Size = size;
		txtMa_Plvt1.AutoLookup = true;
		txtMa_Plvt1.AutoValid = false;
		((TextBoxBase)txtMa_Plvt1).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plvt1).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_Plvt1).Enabled = false;
		AsTextBox asTextBox2 = txtMa_Plvt1;
		location = new Point(698, 229);
		((Control)asTextBox2).Location = location;
		txtMa_Plvt1.LookupCodeName = "MA_PLVT";
		txtMa_Plvt1.LookupWhereCondition = "loai='1'";
		((TextBoxBase)txtMa_Plvt1).MaxLength = 8;
		((Control)txtMa_Plvt1).Name = "txtMa_Plvt1";
		txtMa_Plvt1.NameControl = lblTen_plvt1;
		AsTextBox asTextBox3 = txtMa_Plvt1;
		size = new Size(87, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_Plvt1).TabIndex = 19;
		txtMa_Plvt1.UseAutoCompleteSource = true;
		((Control)txtMa_Plvt1).Visible = false;
		((Control)lblTen_plvt1).BackColor = Color.Transparent;
		((Control)lblTen_plvt1).Enabled = false;
		Label obj19 = lblTen_plvt1;
		location = new Point(791, 233);
		((Control)obj19).Location = location;
		((Control)lblTen_plvt1).Name = "lblTen_plvt1";
		Label obj20 = lblTen_plvt1;
		size = new Size(75, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_plvt1).TabIndex = 1032;
		((Control)lblTen_plvt1).Visible = false;
		lblPlvt1.AutoSize = true;
		((Control)lblPlvt1).Enabled = false;
		Label obj21 = lblPlvt1;
		location = new Point(624, 233);
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
		location = new Point(698, 251);
		((Control)asTextBox4).Location = location;
		txtMa_Plvt2.LookupCodeName = "MA_PLVT";
		txtMa_Plvt2.LookupWhereCondition = "loai='2'";
		((TextBoxBase)txtMa_Plvt2).MaxLength = 8;
		((Control)txtMa_Plvt2).Name = "txtMa_Plvt2";
		txtMa_Plvt2.NameControl = lblTen_plvt2;
		AsTextBox asTextBox5 = txtMa_Plvt2;
		size = new Size(87, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_Plvt2).TabIndex = 20;
		txtMa_Plvt2.UseAutoCompleteSource = true;
		((Control)txtMa_Plvt2).Visible = false;
		((Control)lblTen_plvt2).BackColor = Color.Transparent;
		((Control)lblTen_plvt2).Enabled = false;
		Label obj23 = lblTen_plvt2;
		location = new Point(791, 255);
		((Control)obj23).Location = location;
		((Control)lblTen_plvt2).Name = "lblTen_plvt2";
		Label obj24 = lblTen_plvt2;
		size = new Size(75, 13);
		((Control)obj24).Size = size;
		((Control)lblTen_plvt2).TabIndex = 1031;
		((Control)lblTen_plvt2).Visible = false;
		lblPlvt2.AutoSize = true;
		((Control)lblPlvt2).Enabled = false;
		Label obj25 = lblPlvt2;
		location = new Point(624, 255);
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
		location = new Point(698, 271);
		((Control)asTextBox6).Location = location;
		txtMa_plvt3.LookupCodeName = "MA_PLVT";
		txtMa_plvt3.LookupWhereCondition = "loai='3'";
		((TextBoxBase)txtMa_plvt3).MaxLength = 8;
		((Control)txtMa_plvt3).Name = "txtMa_plvt3";
		txtMa_plvt3.NameControl = lblTen_plvt3;
		AsTextBox asTextBox7 = txtMa_plvt3;
		size = new Size(87, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_plvt3).TabIndex = 21;
		txtMa_plvt3.UseAutoCompleteSource = true;
		((Control)txtMa_plvt3).Visible = false;
		((Control)lblTen_plvt3).BackColor = Color.Transparent;
		((Control)lblTen_plvt3).Enabled = false;
		Label obj27 = lblTen_plvt3;
		location = new Point(791, 275);
		((Control)obj27).Location = location;
		((Control)lblTen_plvt3).Name = "lblTen_plvt3";
		Label obj28 = lblTen_plvt3;
		size = new Size(75, 13);
		((Control)obj28).Size = size;
		((Control)lblTen_plvt3).TabIndex = 1030;
		((Control)lblTen_plvt3).Visible = false;
		lblPlvt3.AutoSize = true;
		((Control)lblPlvt3).Enabled = false;
		Label obj29 = lblPlvt3;
		location = new Point(624, 275);
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
		location = new Point(201, 142);
		((Control)asTextBox8).Location = location;
		txtMa_Plkh1.LookupCodeName = "MA_PLKH";
		txtMa_Plkh1.LookupWhereCondition = "loai='1'";
		((TextBoxBase)txtMa_Plkh1).MaxLength = 8;
		((Control)txtMa_Plkh1).Name = "txtMa_Plkh1";
		txtMa_Plkh1.NameControl = lblTen_lkh1;
		AsTextBox asTextBox9 = txtMa_Plkh1;
		size = new Size(87, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_Plkh1).TabIndex = 6;
		txtMa_Plkh1.UseAutoCompleteSource = true;
		((Control)lblTen_lkh1).BackColor = Color.Transparent;
		Label obj31 = lblTen_lkh1;
		location = new Point(297, 146);
		((Control)obj31).Location = location;
		((Control)lblTen_lkh1).Name = "lblTen_lkh1";
		Label obj32 = lblTen_lkh1;
		size = new Size(500, 13);
		((Control)obj32).Size = size;
		((Control)lblTen_lkh1).TabIndex = 1041;
		lblPlkh1.AutoSize = true;
		Label obj33 = lblPlkh1;
		location = new Point(25, 146);
		((Control)obj33).Location = location;
		((Control)lblPlkh1).Name = "lblPlkh1";
		Label obj34 = lblPlkh1;
		size = new Size(64, 13);
		((Control)obj34).Size = size;
		((Control)lblPlkh1).TabIndex = 1037;
		lblPlkh1.Text = "P.loại NCC1";
		txtMa_Plkh2.AutoLookup = true;
		txtMa_Plkh2.AutoValid = false;
		((TextBoxBase)txtMa_Plkh2).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_Plkh2;
		location = new Point(201, 165);
		((Control)asTextBox10).Location = location;
		txtMa_Plkh2.LookupCodeName = "MA_PLKH";
		txtMa_Plkh2.LookupWhereCondition = "loai='2'";
		((TextBoxBase)txtMa_Plkh2).MaxLength = 8;
		((Control)txtMa_Plkh2).Name = "txtMa_Plkh2";
		txtMa_Plkh2.NameControl = lblTen_lkh2;
		AsTextBox asTextBox11 = txtMa_Plkh2;
		size = new Size(87, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_Plkh2).TabIndex = 7;
		txtMa_Plkh2.UseAutoCompleteSource = true;
		((Control)lblTen_lkh2).BackColor = Color.Transparent;
		Label obj35 = lblTen_lkh2;
		location = new Point(297, 169);
		((Control)obj35).Location = location;
		((Control)lblTen_lkh2).Name = "lblTen_lkh2";
		Label obj36 = lblTen_lkh2;
		size = new Size(500, 13);
		((Control)obj36).Size = size;
		((Control)lblTen_lkh2).TabIndex = 1040;
		lblPlkh2.AutoSize = true;
		Label obj37 = lblPlkh2;
		location = new Point(25, 169);
		((Control)obj37).Location = location;
		((Control)lblPlkh2).Name = "lblPlkh2";
		Label obj38 = lblPlkh2;
		size = new Size(64, 13);
		((Control)obj38).Size = size;
		((Control)lblPlkh2).TabIndex = 1038;
		lblPlkh2.Text = "P.loại NCC2";
		txtMa_Plkh3.AutoLookup = true;
		txtMa_Plkh3.AutoValid = false;
		((TextBoxBase)txtMa_Plkh3).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_Plkh3;
		location = new Point(201, 188);
		((Control)asTextBox12).Location = location;
		txtMa_Plkh3.LookupCodeName = "MA_PLKH";
		txtMa_Plkh3.LookupWhereCondition = "loai='3'";
		((TextBoxBase)txtMa_Plkh3).MaxLength = 8;
		((Control)txtMa_Plkh3).Name = "txtMa_Plkh3";
		txtMa_Plkh3.NameControl = lblTen_lkh3;
		AsTextBox asTextBox13 = txtMa_Plkh3;
		size = new Size(87, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_Plkh3).TabIndex = 8;
		txtMa_Plkh3.UseAutoCompleteSource = true;
		((Control)lblTen_lkh3).BackColor = Color.Transparent;
		Label obj39 = lblTen_lkh3;
		location = new Point(297, 192);
		((Control)obj39).Location = location;
		((Control)lblTen_lkh3).Name = "lblTen_lkh3";
		Label obj40 = lblTen_lkh3;
		size = new Size(500, 13);
		((Control)obj40).Size = size;
		((Control)lblTen_lkh3).TabIndex = 1039;
		lblPlkh3.AutoSize = true;
		Label obj41 = lblPlkh3;
		location = new Point(25, 192);
		((Control)obj41).Location = location;
		((Control)lblPlkh3).Name = "lblPlkh3";
		Label obj42 = lblPlkh3;
		size = new Size(64, 13);
		((Control)obj42).Size = size;
		((Control)lblPlkh3).TabIndex = 1036;
		lblPlkh3.Text = "P.loại NCC3";
		lblNhom_Theo.AutoSize = true;
		Label obj43 = lblNhom_Theo;
		location = new Point(25, 97);
		((Control)obj43).Location = location;
		((Control)lblNhom_Theo).Name = "lblNhom_Theo";
		Label obj44 = lblNhom_Theo;
		size = new Size(59, 13);
		((Control)obj44).Size = size;
		((Control)lblNhom_Theo).TabIndex = 1043;
		lblNhom_Theo.Text = "Nhóm theo";
		lblChi_Tiet_Theo.AutoSize = true;
		Label obj45 = lblChi_Tiet_Theo;
		location = new Point(384, 97);
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
		location = new Point(201, 119);
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
		location = new Point(297, 123);
		((Control)obj47).Location = location;
		((Control)lblTen_KH).Name = "lblTen_KH";
		Label obj48 = lblTen_KH;
		size = new Size(500, 13);
		((Control)obj48).Size = size;
		((Control)lblTen_KH).TabIndex = 1051;
		lblMa_Kh.AutoSize = true;
		Label obj49 = lblMa_Kh;
		location = new Point(25, 123);
		((Control)obj49).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj50 = lblMa_Kh;
		size = new Size(60, 13);
		((Control)obj50).Size = size;
		((Control)lblMa_Kh).TabIndex = 1049;
		lblMa_Kh.Text = "Mã nhà CC";
		txtMa_Nhkh.AutoLookup = true;
		txtMa_Nhkh.AutoValid = false;
		((TextBoxBase)txtMa_Nhkh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nhkh).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_Nhkh).Enabled = false;
		AsTextBox asTextBox16 = txtMa_Nhkh;
		location = new Point(710, 327);
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
		location = new Point(803, 331);
		((Control)obj51).Location = location;
		((Control)lblTen_nhkh).Name = "lblTen_nhkh";
		Label obj52 = lblTen_nhkh;
		size = new Size(75, 13);
		((Control)obj52).Size = size;
		((Control)lblTen_nhkh).TabIndex = 1050;
		((Control)lblTen_nhkh).Visible = false;
		lblMa_Nhkh.AutoSize = true;
		((Control)lblMa_Nhkh).Enabled = false;
		Label obj53 = lblMa_Nhkh;
		location = new Point(624, 331);
		((Control)obj53).Location = location;
		((Control)lblMa_Nhkh).Name = "lblMa_Nhkh";
		Label obj54 = lblMa_Nhkh;
		size = new Size(76, 13);
		((Control)obj54).Size = size;
		((Control)lblMa_Nhkh).TabIndex = 1048;
		lblMa_Nhkh.Text = "Mã nhóm NCC";
		((Control)lblMa_Nhkh).Visible = false;
		lblMa_hd.AutoSize = true;
		Label obj55 = lblMa_hd;
		location = new Point(25, 215);
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
		location = new Point(201, 211);
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
		location = new Point(297, 215);
		((Control)obj57).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj58 = lblTen_hd;
		size = new Size(500, 13);
		((Control)obj58).Size = size;
		((Control)lblTen_hd).TabIndex = 1057;
		txtMa_nhhd.AutoLookup = true;
		txtMa_nhhd.AutoValid = false;
		((TextBoxBase)txtMa_nhhd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhhd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtMa_nhhd;
		location = new Point(201, 234);
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
		location = new Point(297, 238);
		((Control)obj59).Location = location;
		((Control)lblTen_Nhhd).Name = "lblTen_Nhhd";
		Label obj60 = lblTen_Nhhd;
		size = new Size(500, 13);
		((Control)obj60).Size = size;
		((Control)lblTen_Nhhd).TabIndex = 1056;
		lblMa_nhhd.AutoSize = true;
		Label obj61 = lblMa_nhhd;
		location = new Point(25, 238);
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
		location = new Point(201, 280);
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
		location = new Point(297, 284);
		((Control)obj63).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj64 = lblTen_kho;
		size = new Size(500, 13);
		((Control)obj64).Size = size;
		((Control)lblTen_kho).TabIndex = 1066;
		lblMa_kho.AutoSize = true;
		Label obj65 = lblMa_kho;
		location = new Point(25, 284);
		((Control)obj65).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj66 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj66).Size = size;
		((Control)lblMa_kho).TabIndex = 1062;
		lblMa_kho.Text = "Mã kho";
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox24 = txtMa_vt;
		location = new Point(201, 372);
		((Control)asTextBox24).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((TextBoxBase)txtMa_vt).MaxLength = 20;
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox25 = txtMa_vt;
		size = new Size(87, 20);
		((Control)asTextBox25).Size = size;
		((Control)txtMa_vt).TabIndex = 16;
		txtMa_vt.UseAutoCompleteSource = true;
		((Control)lblTen_vt).BackColor = Color.Transparent;
		Label obj67 = lblTen_vt;
		location = new Point(297, 376);
		((Control)obj67).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj68 = lblTen_vt;
		size = new Size(500, 13);
		((Control)obj68).Size = size;
		((Control)lblTen_vt).TabIndex = 1072;
		lblMa_vt.AutoSize = true;
		Label obj69 = lblMa_vt;
		location = new Point(25, 376);
		((Control)obj69).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj70 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj70).Size = size;
		((Control)lblMa_vt).TabIndex = 1070;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox26 = txtMa_nhvt;
		location = new Point(201, 395);
		((Control)asTextBox26).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((TextBoxBase)txtMa_nhvt).MaxLength = 8;
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_Nhvt;
		AsTextBox asTextBox27 = txtMa_nhvt;
		size = new Size(87, 20);
		((Control)asTextBox27).Size = size;
		((Control)txtMa_nhvt).TabIndex = 17;
		txtMa_nhvt.UseAutoCompleteSource = true;
		((Control)lblTen_Nhvt).BackColor = Color.Transparent;
		Label obj71 = lblTen_Nhvt;
		location = new Point(297, 399);
		((Control)obj71).Location = location;
		((Control)lblTen_Nhvt).Name = "lblTen_Nhvt";
		Label obj72 = lblTen_Nhvt;
		size = new Size(500, 13);
		((Control)obj72).Size = size;
		((Control)lblTen_Nhvt).TabIndex = 1071;
		lblMa_nhvt.AutoSize = true;
		Label obj73 = lblMa_nhvt;
		location = new Point(25, 399);
		((Control)obj73).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj74 = lblMa_nhvt;
		size = new Size(65, 13);
		((Control)obj74).Size = size;
		((Control)lblMa_nhvt).TabIndex = 1069;
		lblMa_nhvt.Text = "Nhóm vật tư";
		txtMa_HTTT.AutoLookup = true;
		txtMa_HTTT.AutoValid = false;
		((TextBoxBase)txtMa_HTTT).BackColor = SystemColors.Info;
		((TextBox)txtMa_HTTT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox28 = txtMa_HTTT;
		location = new Point(201, 257);
		((Control)asTextBox28).Location = location;
		txtMa_HTTT.LookupCodeName = "MA_HTTT";
		((TextBoxBase)txtMa_HTTT).MaxLength = 20;
		((Control)txtMa_HTTT).Name = "txtMa_HTTT";
		txtMa_HTTT.NameControl = lblTen_HTTT;
		AsTextBox asTextBox29 = txtMa_HTTT;
		size = new Size(87, 20);
		((Control)asTextBox29).Size = size;
		((Control)txtMa_HTTT).TabIndex = 11;
		txtMa_HTTT.UseAutoCompleteSource = true;
		((Control)lblTen_HTTT).BackColor = Color.Transparent;
		Label obj75 = lblTen_HTTT;
		location = new Point(297, 261);
		((Control)obj75).Location = location;
		((Control)lblTen_HTTT).Name = "lblTen_HTTT";
		Label obj76 = lblTen_HTTT;
		size = new Size(500, 13);
		((Control)obj76).Size = size;
		((Control)lblTen_HTTT).TabIndex = 1075;
		lblMa_HTTT.AutoSize = true;
		Label obj77 = lblMa_HTTT;
		location = new Point(25, 261);
		((Control)obj77).Location = location;
		((Control)lblMa_HTTT).Name = "lblMa_HTTT";
		Label obj78 = lblMa_HTTT;
		size = new Size(54, 13);
		((Control)obj78).Size = size;
		((Control)lblMa_HTTT).TabIndex = 1074;
		lblMa_HTTT.Text = "Mã HTTT";
		((ListControl)cboNhom_Theo).DisplayMember = "0";
		((ComboBox)cboNhom_Theo).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_Theo).FormattingEnabled = true;
		((ComboBox)cboNhom_Theo).Items.AddRange(new object[5] { "Nhà cung cấp", "Bộ phận", "Hợp đồng", "Hình thức thanh toán", "Vật tư" });
		AsComboBox asComboBox = cboNhom_Theo;
		location = new Point(201, 93);
		((Control)asComboBox).Location = location;
		((Control)cboNhom_Theo).Name = "cboNhom_Theo";
		AsComboBox asComboBox2 = cboNhom_Theo;
		size = new Size(163, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboNhom_Theo).TabIndex = 3;
		((ListControl)cboNhom_Theo).ValueMember = "0";
		((ComboBox)cboChi_Tiet_Theo).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboChi_Tiet_Theo).FormattingEnabled = true;
		((ComboBox)cboChi_Tiet_Theo).Items.AddRange(new object[5] { "Vật tư", "Nhà cung cấp", "Bộ phận", "Hợp đồng", "Hình thức thanh toán" });
		AsComboBox asComboBox3 = cboChi_Tiet_Theo;
		location = new Point(453, 93);
		((Control)asComboBox3).Location = location;
		((Control)cboChi_Tiet_Theo).Name = "cboChi_Tiet_Theo";
		AsComboBox asComboBox4 = cboChi_Tiet_Theo;
		size = new Size(168, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboChi_Tiet_Theo).TabIndex = 4;
		((ButtonBase)ChkTra_lai).AutoSize = true;
		ChkTra_lai.Checked = true;
		((CheckBox)ChkTra_lai).CheckState = (CheckState)1;
		AsCheckBox chkTra_lai = ChkTra_lai;
		location = new Point(201, 421);
		((Control)chkTra_lai).Location = location;
		((Control)ChkTra_lai).Name = "ChkTra_lai";
		AsCheckBox chkTra_lai2 = ChkTra_lai;
		size = new Size(172, 17);
		((Control)chkTra_lai2).Size = size;
		((Control)ChkTra_lai).TabIndex = 18;
		((ButtonBase)ChkTra_lai).Text = "Hàng xuất trả lại nhà cung cấp";
		((ButtonBase)ChkTra_lai).UseVisualStyleBackColor = true;
		lblTru.AutoSize = true;
		lblTru.ImeMode = (ImeMode)0;
		Label obj79 = lblTru;
		location = new Point(25, 422);
		((Control)obj79).Location = location;
		((Control)lblTru).Name = "lblTru";
		Label obj80 = lblTru;
		size = new Size(23, 13);
		((Control)obj80).Size = size;
		((Control)lblTru).TabIndex = 1081;
		lblTru.Text = "Trừ";
		((Control)lblDKTT).BackColor = Color.Transparent;
		((Control)lblDKTT).Enabled = false;
		Label obj81 = lblDKTT;
		location = new Point(803, 386);
		((Control)obj81).Location = location;
		((Control)lblDKTT).Name = "lblDKTT";
		Label obj82 = lblDKTT;
		size = new Size(75, 13);
		((Control)obj82).Size = size;
		((Control)lblDKTT).TabIndex = 1084;
		((Control)lblDKTT).Visible = false;
		Label2.AutoSize = true;
		((Control)Label2).Enabled = false;
		Label label = Label2;
		location = new Point(624, 386);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(54, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 1083;
		Label2.Text = "Mã ĐKTT";
		((Control)Label2).Visible = false;
		txtMa_DKTT.AutoLookup = true;
		txtMa_DKTT.AutoValid = false;
		((TextBoxBase)txtMa_DKTT).BackColor = SystemColors.Info;
		((TextBox)txtMa_DKTT).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_DKTT).Enabled = false;
		AsTextBox asTextBox30 = txtMa_DKTT;
		location = new Point(710, 382);
		((Control)asTextBox30).Location = location;
		txtMa_DKTT.LookupCodeName = "MA_TT_PO";
		((TextBoxBase)txtMa_DKTT).MaxLength = 20;
		((Control)txtMa_DKTT).Name = "txtMa_DKTT";
		txtMa_DKTT.NameControl = lblDKTT;
		AsTextBox asTextBox31 = txtMa_DKTT;
		size = new Size(87, 20);
		((Control)asTextBox31).Size = size;
		((Control)txtMa_DKTT).TabIndex = 8;
		txtMa_DKTT.UseAutoCompleteSource = true;
		((Control)txtMa_DKTT).Visible = false;
		txtMa_vitri.AutoLookup = true;
		txtMa_vitri.AutoValid = false;
		((TextBoxBase)txtMa_vitri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vitri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vitri).Enabled = false;
		AsTextBox asTextBox32 = txtMa_vitri;
		location = new Point(710, 356);
		((Control)asTextBox32).Location = location;
		txtMa_vitri.LookupCodeName = "MA_VITRI";
		((TextBoxBase)txtMa_vitri).MaxLength = 20;
		((Control)txtMa_vitri).Name = "txtMa_vitri";
		txtMa_vitri.NameControl = lblMa_vitri;
		AsTextBox asTextBox33 = txtMa_vitri;
		size = new Size(87, 20);
		((Control)asTextBox33).Size = size;
		((Control)txtMa_vitri).TabIndex = 10;
		txtMa_vitri.UseAutoCompleteSource = true;
		((Control)txtMa_vitri).Visible = false;
		((Control)lblMa_vitri).BackColor = Color.Transparent;
		((Control)lblMa_vitri).Enabled = false;
		Label obj83 = lblMa_vitri;
		location = new Point(803, 360);
		((Control)obj83).Location = location;
		((Control)lblMa_vitri).Name = "lblMa_vitri";
		Label obj84 = lblMa_vitri;
		size = new Size(75, 13);
		((Control)obj84).Size = size;
		((Control)lblMa_vitri).TabIndex = 1087;
		((Control)lblMa_vitri).Visible = false;
		Label4.AutoSize = true;
		((Control)Label4).Enabled = false;
		Label label3 = Label4;
		location = new Point(624, 360);
		((Control)label3).Location = location;
		((Control)Label4).Name = "Label4";
		Label label4 = Label4;
		size = new Size(46, 13);
		((Control)label4).Size = size;
		((Control)Label4).TabIndex = 1086;
		Label4.Text = "Mã vị trí";
		((Control)Label4).Visible = false;
		txtMa_lo.AutoLookup = true;
		txtMa_lo.AutoValid = false;
		((TextBoxBase)txtMa_lo).BackColor = SystemColors.Info;
		((TextBox)txtMa_lo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox34 = txtMa_lo;
		location = new Point(201, 303);
		((Control)asTextBox34).Location = location;
		txtMa_lo.LookupCodeName = "MA_LO";
		((TextBoxBase)txtMa_lo).MaxLength = 20;
		((Control)txtMa_lo).Name = "txtMa_lo";
		txtMa_lo.NameControl = lblMa_lo;
		AsTextBox asTextBox35 = txtMa_lo;
		size = new Size(87, 20);
		((Control)asTextBox35).Size = size;
		((Control)txtMa_lo).TabIndex = 13;
		txtMa_lo.UseAutoCompleteSource = true;
		((Control)lblMa_lo).BackColor = Color.Transparent;
		Label obj85 = lblMa_lo;
		location = new Point(297, 307);
		((Control)obj85).Location = location;
		((Control)lblMa_lo).Name = "lblMa_lo";
		Label obj86 = lblMa_lo;
		size = new Size(500, 13);
		((Control)obj86).Size = size;
		((Control)lblMa_lo).TabIndex = 1090;
		Label6.AutoSize = true;
		Label label5 = Label6;
		location = new Point(25, 307);
		((Control)label5).Location = location;
		((Control)Label6).Name = "Label6";
		Label label6 = Label6;
		size = new Size(33, 13);
		((Control)label6).Size = size;
		((Control)Label6).TabIndex = 1089;
		Label6.Text = "Mã lô";
		txtMa_phi.AutoLookup = true;
		txtMa_phi.AutoValid = false;
		((TextBoxBase)txtMa_phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox36 = txtMa_phi;
		location = new Point(201, 326);
		((Control)asTextBox36).Location = location;
		txtMa_phi.LookupCodeName = "MA_PHI";
		((TextBoxBase)txtMa_phi).MaxLength = 20;
		((Control)txtMa_phi).Name = "txtMa_phi";
		txtMa_phi.NameControl = lblMa_phi;
		AsTextBox asTextBox37 = txtMa_phi;
		size = new Size(87, 20);
		((Control)asTextBox37).Size = size;
		((Control)txtMa_phi).TabIndex = 14;
		txtMa_phi.UseAutoCompleteSource = true;
		((Control)lblMa_phi).BackColor = Color.Transparent;
		Label obj87 = lblMa_phi;
		location = new Point(297, 330);
		((Control)obj87).Location = location;
		((Control)lblMa_phi).Name = "lblMa_phi";
		Label obj88 = lblMa_phi;
		size = new Size(500, 13);
		((Control)obj88).Size = size;
		((Control)lblMa_phi).TabIndex = 1093;
		Label8.AutoSize = true;
		Label label7 = Label8;
		location = new Point(25, 330);
		((Control)label7).Location = location;
		((Control)Label8).Name = "Label8";
		Label label8 = Label8;
		size = new Size(41, 13);
		((Control)label8).Size = size;
		((Control)Label8).TabIndex = 1092;
		Label8.Text = "Mã phí";
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox38 = txtMa_spct;
		location = new Point(201, 349);
		((Control)asTextBox38).Location = location;
		txtMa_spct.LookupCodeName = "MA_VT";
		((TextBoxBase)txtMa_spct).MaxLength = 20;
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblMa_spct;
		AsTextBox asTextBox39 = txtMa_spct;
		size = new Size(87, 20);
		((Control)asTextBox39).Size = size;
		((Control)txtMa_spct).TabIndex = 15;
		txtMa_spct.UseAutoCompleteSource = true;
		((Control)lblMa_spct).BackColor = Color.Transparent;
		Label obj89 = lblMa_spct;
		location = new Point(297, 353);
		((Control)obj89).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj90 = lblMa_spct;
		size = new Size(500, 13);
		((Control)obj90).Size = size;
		((Control)lblMa_spct).TabIndex = 1096;
		Label10.AutoSize = true;
		Label label9 = Label10;
		location = new Point(25, 353);
		((Control)label9).Location = location;
		((Control)Label10).Name = "Label10";
		Label label10 = Label10;
		size = new Size(53, 13);
		((Control)label10).Size = size;
		((Control)Label10).TabIndex = 1095;
		Label10.Text = "Mã SPCT";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).AutoSize = true;
		size = new Size(956, 569);
		((Form)this).ClientSize = size;
		((Control)this).Cursor = Cursors.Arrow;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmPORptBCPT03";
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		base.InitOtherComponents();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		AsComboBox asComboBox = cboChi_Tiet_Theo;
		dictionary.Add("MA_VT", Conversions.ToString(((ComboBox)asComboBox).Items[0]));
		dictionary.Add("MA_KH", Conversions.ToString(((ComboBox)asComboBox).Items[1]));
		dictionary.Add("MA_BP", Conversions.ToString(((ComboBox)asComboBox).Items[2]));
		dictionary.Add("MA_HD", Conversions.ToString(((ComboBox)asComboBox).Items[3]));
		dictionary.Add("MA_HTTT", Conversions.ToString(((ComboBox)asComboBox).Items[4]));
		BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
		((ComboBox)asComboBox).DataSource = dataSource;
		((ListControl)asComboBox).DisplayMember = "value";
		((ListControl)asComboBox).ValueMember = "key";
		((ComboBox)asComboBox).SelectedIndex = 0;
		asComboBox = null;
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		AsComboBox asComboBox2 = cboNhom_Theo;
		dictionary2.Add("MA_KH", Conversions.ToString(((ComboBox)asComboBox2).Items[0]));
		dictionary2.Add("MA_BP", Conversions.ToString(((ComboBox)asComboBox2).Items[1]));
		dictionary2.Add("MA_HD", Conversions.ToString(((ComboBox)asComboBox2).Items[2]));
		dictionary2.Add("MA_HTTT", Conversions.ToString(((ComboBox)asComboBox2).Items[3]));
		dictionary2.Add("MA_VT", Conversions.ToString(((ComboBox)asComboBox2).Items[4]));
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
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtMa_nhhd).Text);
		arrayList.Add(((TextBox)txtMa_HTTT).Text);
		arrayList.Add(((TextBox)txtMa_DKTT).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_vitri).Text);
		arrayList.Add(((TextBox)txtMa_lo).Text);
		arrayList.Add(((TextBox)txtMa_phi).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add(((TextBox)txtMa_Plvt1).Text);
		arrayList.Add(((TextBox)txtMa_Plvt2).Text);
		arrayList.Add(((TextBox)txtMa_plvt3).Text);
		arrayList.Add(((TextBox)txtMa_spct).Text);
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

	private object convertoToInt(bool ck)
	{
		int num = 0;
		num = (ck ? 1 : 0);
		return num;
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		DataRowView dataRowView = get_MyDGVSource(isSet2Print: true).DefaultView[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
		if ((int)keycode != 116 || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]), isNum: false), (object)"", false) ? true : false))
		{
			base.CancelDrilldown = true;
			return null;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_vitri).Text);
		arrayList.Add(((TextBox)txtMa_phi).Text);
		arrayList.Add(((TextBox)txtMa_spct).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ma_group"]));
		arrayList.Add(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dataRowView["bold"], (object)"1", false), (object)"", RuntimeHelpers.GetObjectValue(dataRowView["Ma_Detail"]))));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboNhom_Theo).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboChi_Tiet_Theo).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_lai.Checked));
		if (Information.IsDBNull((object)arrayList))
		{
			base.CancelDrilldown = true;
			return null;
		}
		filterCondition4title = dataRowView["ma_group"].ToString() + "- " + dataRowView["Ma_Detail"].ToString();
		return arrayList;
	}

	private string GetFilterTitle()
	{
		string text = string.Empty;
		if (Operators.CompareString(((ComboBox)cboNhom_Theo).Text.Trim(), "", false) != 0)
		{
			text = text + lblNhom_Theo.Text + ": " + ((ComboBox)cboNhom_Theo).Text + "; ";
		}
		if (Operators.CompareString(((ComboBox)cboChi_Tiet_Theo).Text.Trim(), "", false) != 0)
		{
			text = text + lblChi_Tiet_Theo.Text + ": " + ((ComboBox)cboChi_Tiet_Theo).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Kh.Text + ": " + ((TextBox)txtMa_kh).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nhkh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Nhkh.Text + ": " + ((TextBox)txtMa_Nhkh).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plkh1).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlkh1.Text + ": " + ((TextBox)txtMa_Plkh1).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plkh2).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlkh2.Text + ": " + ((TextBox)txtMa_Plkh2).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plkh3).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlkh3.Text + ": " + ((TextBox)txtMa_Plkh3).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_hd).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_hd.Text + ": " + ((TextBox)txtMa_hd).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhhd).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nhhd.Text + ": " + ((TextBox)txtMa_nhhd).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_HTTT).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_HTTT.Text + ": " + ((TextBox)txtMa_HTTT).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_DKTT).Text.Trim(), "", false) != 0)
		{
			text = text + lblDKTT.Text + ": " + ((TextBox)txtMa_DKTT).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_spct).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_spct.Text + ": " + ((TextBox)txtMa_spct).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_lo).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_lo.Text + ": " + ((TextBox)txtMa_lo).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_phi).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_phi.Text + ": " + ((TextBox)txtMa_phi).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": " + ((TextBox)txtMa_kho).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_vt.Text + ":" + ((TextBox)txtMa_vt).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhvt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nhvt.Text + ": " + ((TextBox)txtMa_nhvt).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plvt1).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlvt1.Text + ": " + ((TextBox)txtMa_Plvt1).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Plvt2).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlvt2.Text + ": " + ((TextBox)txtMa_Plvt2).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt3).Text.Trim(), "", false) != 0)
		{
			text = text + lblPlvt3.Text + ": " + ((TextBox)txtMa_plvt3).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
		}
		return text;
	}

	private void cboChi_Tiet_Theo_GotFocus(object sender, EventArgs e)
	{
		if ((((ComboBox)cboNhom_Theo).SelectedIndex > -1 && (float)((ComboBox)cboNhom_Theo).Text.Length * ((Control)cboNhom_Theo).Font.Size > (float)((Control)cboNhom_Theo).Width) ? true : false)
		{
			oToolTip.Show(((ComboBox)cboNhom_Theo).Text, (IWin32Window)(object)cboNhom_Theo);
		}
		else
		{
			oToolTip.Hide((IWin32Window)(object)cboNhom_Theo);
		}
		if ((((ComboBox)cboChi_Tiet_Theo).SelectedIndex > -1 && (float)((ComboBox)cboChi_Tiet_Theo).Text.Length * ((Control)cboChi_Tiet_Theo).Font.Size > (float)((Control)cboChi_Tiet_Theo).Width) ? true : false)
		{
			oToolTip.Show(((ComboBox)cboChi_Tiet_Theo).Text, (IWin32Window)(object)cboChi_Tiet_Theo);
		}
		else
		{
			oToolTip.Hide((IWin32Window)(object)cboChi_Tiet_Theo);
		}
	}

	private void cboNhom_Theo_SelectedIndexChanged(object sender, EventArgs e)
	{
		cboChi_Tiet_Theo_GotFocus(null, null);
		checked
		{
			if (Operators.CompareString(((ComboBox)cboNhom_Theo).Text, ((ComboBox)cboChi_Tiet_Theo).Text, false) == 0)
			{
				if (((ComboBox)cboChi_Tiet_Theo).SelectedIndex == ((ComboBox)cboChi_Tiet_Theo).Items.Count - 1)
				{
					((ComboBox)cboChi_Tiet_Theo).SelectedIndex = 0;
					return;
				}
				AsComboBox asComboBox = cboChi_Tiet_Theo;
				((ComboBox)asComboBox).SelectedIndex = ((ComboBox)asComboBox).SelectedIndex + 1;
			}
		}
	}
}
