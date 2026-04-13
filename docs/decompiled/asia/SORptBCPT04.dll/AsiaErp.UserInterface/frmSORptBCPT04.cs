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
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSORptBCPT04 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

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

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("txtMa_vitri")]
	private AsTextBox _txtMa_vitri;

	[AccessedThroughProperty("lblMavitri")]
	private Label _lblMavitri;

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("txtMaLo")]
	private AsTextBox _txtMaLo;

	[AccessedThroughProperty("lblMaLo")]
	private Label _lblMaLo;

	[AccessedThroughProperty("lblTen_TT")]
	private Label _lblTen_TT;

	[AccessedThroughProperty("txtMA_DKTT")]
	private AsTextBox _txtMA_DKTT;

	[AccessedThroughProperty("lblDkTT")]
	private Label _lblDkTT;

	[AccessedThroughProperty("lblTenHTTT")]
	private Label _lblTenHTTT;

	[AccessedThroughProperty("txtMA_HTTT")]
	private AsTextBox _txtMA_HTTT;

	[AccessedThroughProperty("lblHTTT")]
	private Label _lblHTTT;

	[AccessedThroughProperty("lblTen_Nvkd")]
	private Label _lblTen_Nvkd;

	[AccessedThroughProperty("txtMa_Nvkd")]
	private AsTextBox _txtMa_Nvkd;

	[AccessedThroughProperty("lblMa_nvkd")]
	private Label _lblMa_nvkd;

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

	[AccessedThroughProperty("txtMa_Bp")]
	private AsTextBox _txtMa_Bp;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("lblMa_nhvt")]
	private Label _lblMa_nhvt;

	[AccessedThroughProperty("txtMa_nhvt")]
	private AsTextBox _txtMa_nhvt;

	[AccessedThroughProperty("lblTen_nhvt")]
	private Label _lblTen_nhvt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("lblMa_nhhd")]
	private Label _lblMa_nhhd;

	[AccessedThroughProperty("txtMa_nhhd")]
	private AsTextBox _txtMa_nhhd;

	[AccessedThroughProperty("lblTen_nhhd")]
	private Label _lblTen_nhhd;

	[AccessedThroughProperty("lblTen_Hd")]
	private Label _lblTen_Hd;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

	[AccessedThroughProperty("lblMa_NhKh")]
	private Label _lblMa_NhKh;

	[AccessedThroughProperty("txtMa_NhKh")]
	private AsTextBox _txtMa_NhKh;

	[AccessedThroughProperty("lblTen_NhKh")]
	private Label _lblTen_NhKh;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("txtMa_Plkh1")]
	private AsTextBox _txtMa_Plkh1;

	[AccessedThroughProperty("lblTen_Plkh1")]
	private Label _lblTen_Plkh1;

	[AccessedThroughProperty("lblTen_Plkh3")]
	private Label _lblTen_Plkh3;

	[AccessedThroughProperty("lblTen_Plkh2")]
	private Label _lblTen_Plkh2;

	[AccessedThroughProperty("lblPlkh3")]
	private Label _lblPlkh3;

	[AccessedThroughProperty("txtMa_Plkh3")]
	private AsTextBox _txtMa_Plkh3;

	[AccessedThroughProperty("lblPlkh2")]
	private Label _lblPlkh2;

	[AccessedThroughProperty("txtMa_Plkh2")]
	private AsTextBox _txtMa_Plkh2;

	[AccessedThroughProperty("lblPlkh1")]
	private Label _lblPlkh1;

	[AccessedThroughProperty("txtMa_plvt1")]
	private AsTextBox _txtMa_plvt1;

	[AccessedThroughProperty("lblTen_plvt1")]
	private Label _lblTen_plvt1;

	[AccessedThroughProperty("lblPLVt1")]
	private Label _lblPLVt1;

	[AccessedThroughProperty("lblTen_plvt2")]
	private Label _lblTen_plvt2;

	[AccessedThroughProperty("txtMa_plvt2")]
	private AsTextBox _txtMa_plvt2;

	[AccessedThroughProperty("lblPLVt2")]
	private Label _lblPLVt2;

	[AccessedThroughProperty("lblTen_plvt3")]
	private Label _lblTen_plvt3;

	[AccessedThroughProperty("txtMa_plvt3")]
	private AsTextBox _txtMa_plvt3;

	[AccessedThroughProperty("lblPLVt3")]
	private Label _lblPLVt3;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

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

	internal virtual Label lblTen_vitri
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_vitri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_vitri = value;
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

	internal virtual Label lblMavitri
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMavitri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMavitri = value;
		}
	}

	internal virtual Label lblTen_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_lo = value;
		}
	}

	internal virtual AsTextBox txtMaLo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMaLo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMaLo = value;
		}
	}

	internal virtual Label lblMaLo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMaLo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMaLo = value;
		}
	}

	internal virtual Label lblTen_TT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TT = value;
		}
	}

	internal virtual AsTextBox txtMA_DKTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMA_DKTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMA_DKTT = value;
		}
	}

	internal virtual Label lblDkTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDkTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDkTT = value;
		}
	}

	internal virtual Label lblTenHTTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTenHTTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTenHTTT = value;
		}
	}

	internal virtual AsTextBox txtMA_HTTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMA_HTTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMA_HTTT = value;
		}
	}

	internal virtual Label lblHTTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblHTTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblHTTT = value;
		}
	}

	internal virtual Label lblTen_Nvkd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nvkd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nvkd = value;
		}
	}

	internal virtual AsTextBox txtMa_Nvkd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Nvkd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Nvkd = value;
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

	internal virtual Label lblTen_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Bp = value;
		}
	}

	internal virtual AsTextBox txtMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Bp = value;
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

	internal virtual Label lblTen_nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nhvt = value;
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

	internal virtual Label lblTen_nhhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nhhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nhhd = value;
		}
	}

	internal virtual Label lblTen_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Hd = value;
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

	internal virtual Label lblMa_NhKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_NhKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_NhKh = value;
		}
	}

	internal virtual AsTextBox txtMa_NhKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_NhKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_NhKh = value;
		}
	}

	internal virtual Label lblTen_NhKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_NhKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_NhKh = value;
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
			_txtMa_Kh = value;
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

	internal virtual AsTextBox txtMa_plvt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_plvt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_plvt1 = value;
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

	internal virtual Label lblPLVt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPLVt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPLVt1 = value;
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

	internal virtual AsTextBox txtMa_plvt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_plvt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_plvt2 = value;
		}
	}

	internal virtual Label lblPLVt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPLVt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPLVt2 = value;
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

	internal virtual Label lblPLVt3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPLVt3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPLVt3 = value;
		}
	}

	internal virtual Label lblTen_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_spct = value;
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

	private virtual CrystalReportViewer crvReportViewer
	{
		[DebuggerNonUserCode]
		get
		{
			return _crvReportViewer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_crvReportViewer = value;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	public frmSORptBCPT04(object MenuId)
		: base(Conversions.ToString(MenuId))
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
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
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
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
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_3ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ead: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		ChkTra_lai = new AsCheckBox();
		lblTru = new Label();
		ChkTra_ck = new AsCheckBox();
		ChkKhuyen_mai = new AsCheckBox();
		ChkHang_ban = new AsCheckBox();
		lblLoai_hang = new Label();
		lblTen_TT = new Label();
		txtMA_DKTT = new AsTextBox();
		lblDkTT = new Label();
		lblTenHTTT = new Label();
		txtMA_HTTT = new AsTextBox();
		lblHTTT = new Label();
		lblTen_Nvkd = new Label();
		txtMa_Nvkd = new AsTextBox();
		lblMa_nvkd = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_bp = new Label();
		lblMa_nhvt = new Label();
		txtMa_nhvt = new AsTextBox();
		lblTen_nhvt = new Label();
		lblTen_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		lblMa_nhhd = new Label();
		txtMa_nhhd = new AsTextBox();
		lblTen_nhhd = new Label();
		lblTen_Hd = new Label();
		txtMa_hd = new AsTextBox();
		lblMa_hd = new Label();
		lblMa_NhKh = new Label();
		txtMa_NhKh = new AsTextBox();
		lblTen_NhKh = new Label();
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblTen_vitri = new Label();
		txtMa_Plkh1 = new AsTextBox();
		lblTen_Plkh1 = new Label();
		txtMa_vitri = new AsTextBox();
		lblTen_Plkh3 = new Label();
		lblMavitri = new Label();
		lblTen_Plkh2 = new Label();
		lblTen_lo = new Label();
		txtMaLo = new AsTextBox();
		lblPlkh3 = new Label();
		lblMaLo = new Label();
		txtMa_Plkh3 = new AsTextBox();
		lblPlkh2 = new Label();
		txtMa_Plkh2 = new AsTextBox();
		lblPlkh1 = new Label();
		txtMa_plvt1 = new AsTextBox();
		lblTen_plvt1 = new Label();
		lblPLVt1 = new Label();
		lblTen_plvt2 = new Label();
		txtMa_plvt2 = new AsTextBox();
		lblPLVt2 = new Label();
		lblTen_plvt3 = new Label();
		txtMa_plvt3 = new AsTextBox();
		lblTen_kho = new Label();
		lblPLVt3 = new Label();
		txtMa_kho = new AsTextBox();
		lblMa_kho = new Label();
		lblTen_spct = new Label();
		txtMa_spct = new AsTextBox();
		lblMa_spct = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(840, 585);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_TT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_DKTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblMavitri);
		((Control)tabFilter).Controls.Add((Control)(object)ChkTra_lai);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblDkTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lo);
		((Control)tabFilter).Controls.Add((Control)(object)lblTru);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTenHTTT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)ChkTra_ck);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlkh3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_HTTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)ChkKhuyen_mai);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblHTTT);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlkh2);
		((Control)tabFilter).Controls.Add((Control)(object)ChkHang_ban);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblPlkh1);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoai_hang);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLVt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLVt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLVt3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhhd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_NhKh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_NhKh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_NhKh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Kh);
		TabPage obj = tabFilter;
		size = new Size(832, 556);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_NhKh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_NhKh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_NhKh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLVt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLVt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLVt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoai_hang, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkHang_ban, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblHTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkKhuyen_mai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_HTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPlkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkTra_ck, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTenHTTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTru, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDkTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkTra_lai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMavitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_DKTT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_TT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		Label obj2 = lbl2;
		Point location = new Point(329, 65);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(734, 485);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(348, 61);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 3;
		Button obj4 = cmdCancel;
		location = new Point(653, 509);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(507, 12);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 1;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(258, 61);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(162, 61);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(23, 65);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(162, 14);
		((Control)obj8).Location = location;
		Label obj9 = lblMau_bc;
		location = new Point(23, 17);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(162, 447);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 19;
		Label obj10 = lblMauBC;
		location = new Point(217, 451);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 9;
		RadioButton obj11 = optVND;
		location = new Point(304, 449);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 20;
		RadioButton obj12 = optNt;
		location = new Point(358, 449);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 20;
		Label obj13 = lblMa_nt;
		location = new Point(23, 449);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(24, 480);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 21;
		Label obj15 = lblTieu_de;
		location = new Point(23, 42);
		((Control)obj15).Location = location;
		TextBox obj16 = txtTieu_De;
		location = new Point(162, 38);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 2;
		crvReportViewer.ActiveViewIndex = -1;
		((UserControl)crvReportViewer).BorderStyle = (BorderStyle)1;
		crvReportViewer.DisplayGroupTree = false;
		((Control)crvReportViewer).Dock = (DockStyle)5;
		CrystalReportViewer obj17 = crvReportViewer;
		location = new Point(0, 0);
		((Control)obj17).Location = location;
		((Control)crvReportViewer).Name = "crvReportViewer";
		crvReportViewer.SelectionFormula = "";
		crvReportViewer.ShowRefreshButton = false;
		CrystalReportViewer obj18 = crvReportViewer;
		size = new Size(782, 459);
		((Control)obj18).Size = size;
		((Control)crvReportViewer).TabIndex = 0;
		crvReportViewer.ViewTimeSelectionFormula = "";
		((ButtonBase)ChkTra_lai).AutoSize = true;
		ChkTra_lai.Checked = true;
		((CheckBox)ChkTra_lai).CheckState = (CheckState)1;
		AsCheckBox chkTra_lai = ChkTra_lai;
		location = new Point(162, 424);
		((Control)chkTra_lai).Location = location;
		((Control)ChkTra_lai).Name = "ChkTra_lai";
		AsCheckBox chkTra_lai2 = ChkTra_lai;
		size = new Size(101, 17);
		((Control)chkTra_lai2).Size = size;
		((Control)ChkTra_lai).TabIndex = 18;
		((ButtonBase)ChkTra_lai).Text = "Hàng bán trả lại";
		((ButtonBase)ChkTra_lai).UseVisualStyleBackColor = true;
		lblTru.AutoSize = true;
		lblTru.ImeMode = (ImeMode)0;
		Label obj19 = lblTru;
		location = new Point(23, 425);
		((Control)obj19).Location = location;
		((Control)lblTru).Name = "lblTru";
		Label obj20 = lblTru;
		size = new Size(23, 13);
		((Control)obj20).Size = size;
		((Control)lblTru).TabIndex = 1061;
		lblTru.Text = "Trừ";
		((ButtonBase)ChkTra_ck).AutoSize = true;
		ChkTra_ck.Checked = true;
		((CheckBox)ChkTra_ck).CheckState = (CheckState)1;
		((Control)ChkTra_ck).Enabled = false;
		AsCheckBox chkTra_ck = ChkTra_ck;
		location = new Point(734, 411);
		((Control)chkTra_ck).Location = location;
		((Control)ChkTra_ck).Name = "ChkTra_ck";
		AsCheckBox chkTra_ck2 = ChkTra_ck;
		size = new Size(105, 17);
		((Control)chkTra_ck2).Size = size;
		((Control)ChkTra_ck).TabIndex = 6;
		((ButtonBase)ChkTra_ck).Text = "Hàng chiết khấu";
		((ButtonBase)ChkTra_ck).UseVisualStyleBackColor = true;
		((Control)ChkTra_ck).Visible = false;
		((ButtonBase)ChkKhuyen_mai).AutoSize = true;
		ChkKhuyen_mai.Checked = true;
		((CheckBox)ChkKhuyen_mai).CheckState = (CheckState)1;
		((Control)ChkKhuyen_mai).Enabled = false;
		AsCheckBox chkKhuyen_mai = ChkKhuyen_mai;
		location = new Point(634, 435);
		((Control)chkKhuyen_mai).Location = location;
		((Control)ChkKhuyen_mai).Name = "ChkKhuyen_mai";
		AsCheckBox chkKhuyen_mai2 = ChkKhuyen_mai;
		size = new Size(91, 17);
		((Control)chkKhuyen_mai2).Size = size;
		((Control)ChkKhuyen_mai).TabIndex = 5;
		((ButtonBase)ChkKhuyen_mai).Text = "Hàng trả K/M";
		((ButtonBase)ChkKhuyen_mai).UseVisualStyleBackColor = true;
		((Control)ChkKhuyen_mai).Visible = false;
		((ButtonBase)ChkHang_ban).AutoSize = true;
		ChkHang_ban.Checked = true;
		((CheckBox)ChkHang_ban).CheckState = (CheckState)1;
		((Control)ChkHang_ban).Enabled = false;
		AsCheckBox chkHang_ban = ChkHang_ban;
		location = new Point(555, 439);
		((Control)chkHang_ban).Location = location;
		((Control)ChkHang_ban).Name = "ChkHang_ban";
		AsCheckBox chkHang_ban2 = ChkHang_ban;
		size = new Size(73, 17);
		((Control)chkHang_ban2).Size = size;
		((Control)ChkHang_ban).TabIndex = 4;
		((ButtonBase)ChkHang_ban).Text = "Hàng bán";
		((ButtonBase)ChkHang_ban).UseVisualStyleBackColor = true;
		((Control)ChkHang_ban).Visible = false;
		lblLoai_hang.AutoSize = true;
		((Control)lblLoai_hang).Enabled = false;
		lblLoai_hang.ImeMode = (ImeMode)0;
		Label obj21 = lblLoai_hang;
		location = new Point(469, 449);
		((Control)obj21).Location = location;
		((Control)lblLoai_hang).Name = "lblLoai_hang";
		Label obj22 = lblLoai_hang;
		size = new Size(54, 13);
		((Control)obj22).Size = size;
		((Control)lblLoai_hang).TabIndex = 1060;
		lblLoai_hang.Text = "Loại hàng";
		((Control)lblLoai_hang).Visible = false;
		((Control)lblTen_TT).Anchor = (AnchorStyles)13;
		((Control)lblTen_TT).Enabled = false;
		Label obj23 = lblTen_TT;
		location = new Point(792, 128);
		((Control)obj23).Location = location;
		((Control)lblTen_TT).Name = "lblTen_TT";
		Label obj24 = lblTen_TT;
		size = new Size(442, 13);
		((Control)obj24).Size = size;
		((Control)lblTen_TT).TabIndex = 1141;
		((Control)lblTen_TT).Visible = false;
		txtMA_DKTT.AutoLookup = true;
		txtMA_DKTT.AutoValid = false;
		((TextBoxBase)txtMA_DKTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_DKTT).CharacterCasing = (CharacterCasing)1;
		((Control)txtMA_DKTT).Enabled = false;
		AsTextBox asTextBox2 = txtMA_DKTT;
		location = new Point(642, 147);
		((Control)asTextBox2).Location = location;
		txtMA_DKTT.LookupCodeName = "MA_TT";
		((Control)txtMA_DKTT).Name = "txtMA_DKTT";
		txtMA_DKTT.NameControl = lblTen_TT;
		AsTextBox asTextBox3 = txtMA_DKTT;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMA_DKTT).TabIndex = 9;
		((Control)txtMA_DKTT).Tag = "MA_TT";
		txtMA_DKTT.UseAutoCompleteSource = true;
		((Control)txtMA_DKTT).Visible = false;
		lblDkTT.AutoSize = true;
		((Control)lblDkTT).Enabled = false;
		Label obj25 = lblDkTT;
		location = new Point(556, 152);
		((Control)obj25).Location = location;
		((Control)lblDkTT).Name = "lblDkTT";
		Label obj26 = lblDkTT;
		size = new Size(79, 13);
		((Control)obj26).Size = size;
		((Control)lblDkTT).TabIndex = 1142;
		lblDkTT.Text = "Điều khoản TT";
		((Control)lblDkTT).Visible = false;
		((Control)lblTenHTTT).Anchor = (AnchorStyles)13;
		Label obj27 = lblTenHTTT;
		location = new Point(256, 330);
		((Control)obj27).Location = location;
		((Control)lblTenHTTT).Name = "lblTenHTTT";
		Label obj28 = lblTenHTTT;
		size = new Size(438, 13);
		((Control)obj28).Size = size;
		((Control)lblTenHTTT).TabIndex = 1139;
		txtMA_HTTT.AutoLookup = true;
		txtMA_HTTT.AutoValid = false;
		((TextBoxBase)txtMA_HTTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_HTTT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMA_HTTT;
		location = new Point(162, 326);
		((Control)asTextBox4).Location = location;
		txtMA_HTTT.LookupCodeName = "MA_HTTT";
		txtMA_HTTT.LookupWhereCondition = "moduleid='so'";
		((Control)txtMA_HTTT).Name = "txtMA_HTTT";
		txtMA_HTTT.NameControl = lblTenHTTT;
		AsTextBox asTextBox5 = txtMA_HTTT;
		size = new Size(88, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMA_HTTT).TabIndex = 14;
		((Control)txtMA_HTTT).Tag = "MA_HTTT";
		txtMA_HTTT.UseAutoCompleteSource = true;
		lblHTTT.AutoSize = true;
		Label obj29 = lblHTTT;
		location = new Point(23, 330);
		((Control)obj29).Location = location;
		((Control)lblHTTT).Name = "lblHTTT";
		Label obj30 = lblHTTT;
		size = new Size(70, 13);
		((Control)obj30).Size = size;
		((Control)lblHTTT).TabIndex = 1140;
		lblHTTT.Text = "Hình thức TT";
		((Control)lblTen_Nvkd).Anchor = (AnchorStyles)13;
		lblTen_Nvkd.ImeMode = (ImeMode)0;
		Label obj31 = lblTen_Nvkd;
		location = new Point(256, 306);
		((Control)obj31).Location = location;
		((Control)lblTen_Nvkd).Name = "lblTen_Nvkd";
		Label obj32 = lblTen_Nvkd;
		size = new Size(438, 13);
		((Control)obj32).Size = size;
		((Control)lblTen_Nvkd).TabIndex = 1132;
		((TextBox)txtMa_Nvkd).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Nvkd.AutoLookup = true;
		txtMa_Nvkd.AutoValid = false;
		((TextBoxBase)txtMa_Nvkd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nvkd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_Nvkd;
		location = new Point(162, 302);
		((Control)asTextBox6).Location = location;
		txtMa_Nvkd.LookupCodeName = "MA_NVKD";
		((Control)txtMa_Nvkd).Name = "txtMa_Nvkd";
		txtMa_Nvkd.NameControl = lblTen_Nvkd;
		AsTextBox asTextBox7 = txtMa_Nvkd;
		size = new Size(88, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_Nvkd).TabIndex = 13;
		((Control)txtMa_Nvkd).Tag = "MA_NVKD";
		txtMa_Nvkd.UseAutoCompleteSource = true;
		lblMa_nvkd.AutoSize = true;
		lblMa_nvkd.ImeMode = (ImeMode)0;
		Label obj33 = lblMa_nvkd;
		location = new Point(23, 306);
		((Control)obj33).Location = location;
		((Control)lblMa_nvkd).Name = "lblMa_nvkd";
		Label obj34 = lblMa_nvkd;
		size = new Size(55, 13);
		((Control)obj34).Size = size;
		((Control)lblMa_nvkd).TabIndex = 1131;
		lblMa_nvkd.Text = "Mã NVKD";
		((Control)lblTen_Bp).Anchor = (AnchorStyles)13;
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj35 = lblTen_Bp;
		location = new Point(256, 281);
		((Control)obj35).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj36 = lblTen_Bp;
		size = new Size(438, 13);
		((Control)obj36).Size = size;
		((Control)lblTen_Bp).TabIndex = 1130;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_Bp;
		location = new Point(162, 278);
		((Control)asTextBox8).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox9 = txtMa_Bp;
		size = new Size(88, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_Bp).TabIndex = 12;
		((Control)txtMa_Bp).Tag = "MA_BP";
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_bp.AutoSize = true;
		lblMa_bp.ImeMode = (ImeMode)0;
		Label obj37 = lblMa_bp;
		location = new Point(23, 282);
		((Control)obj37).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj38 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj38).Size = size;
		((Control)lblMa_bp).TabIndex = 1129;
		lblMa_bp.Text = "Mã bộ phận";
		lblMa_nhvt.AutoSize = true;
		lblMa_nhvt.ImeMode = (ImeMode)0;
		Label obj39 = lblMa_nhvt;
		location = new Point(23, 258);
		((Control)obj39).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj40 = lblMa_nhvt;
		size = new Size(65, 13);
		((Control)obj40).Size = size;
		((Control)lblMa_nhvt).TabIndex = 1118;
		lblMa_nhvt.Text = "Nhóm vật tư";
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_nhvt;
		location = new Point(162, 254);
		((Control)asTextBox10).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((TextBoxBase)txtMa_nhvt).MaxLength = 8;
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_nhvt;
		AsTextBox asTextBox11 = txtMa_nhvt;
		size = new Size(88, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_nhvt).TabIndex = 11;
		((Control)txtMa_nhvt).Tag = "MA_NHVT";
		txtMa_nhvt.UseAutoCompleteSource = true;
		((Control)lblTen_nhvt).Anchor = (AnchorStyles)13;
		lblTen_nhvt.ImeMode = (ImeMode)0;
		Label obj41 = lblTen_nhvt;
		location = new Point(256, 258);
		((Control)obj41).Location = location;
		((Control)lblTen_nhvt).Name = "lblTen_nhvt";
		Label obj42 = lblTen_nhvt;
		size = new Size(438, 13);
		((Control)obj42).Size = size;
		((Control)lblTen_nhvt).TabIndex = 1119;
		((Control)lblTen_vt).Anchor = (AnchorStyles)13;
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj43 = lblTen_vt;
		location = new Point(256, 234);
		((Control)obj43).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj44 = lblTen_vt;
		size = new Size(438, 13);
		((Control)obj44).Size = size;
		((Control)lblTen_vt).TabIndex = 1117;
		((TextBox)txtMa_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_vt;
		location = new Point(162, 230);
		((Control)asTextBox12).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox13 = txtMa_vt;
		size = new Size(88, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_vt).TabIndex = 10;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_vt.AutoSize = true;
		lblMa_vt.ImeMode = (ImeMode)0;
		Label obj45 = lblMa_vt;
		location = new Point(23, 234);
		((Control)obj45).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj46 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj46).Size = size;
		((Control)lblMa_vt).TabIndex = 1116;
		lblMa_vt.Text = "Mã vật tư";
		lblMa_nhhd.AutoSize = true;
		lblMa_nhhd.ImeMode = (ImeMode)0;
		Label obj47 = lblMa_nhhd;
		location = new Point(23, 210);
		((Control)obj47).Location = location;
		((Control)lblMa_nhhd).Name = "lblMa_nhhd";
		Label obj48 = lblMa_nhhd;
		size = new Size(84, 13);
		((Control)obj48).Size = size;
		((Control)lblMa_nhhd).TabIndex = 1114;
		lblMa_nhhd.Text = "Nhóm hợp đồng";
		txtMa_nhhd.AutoLookup = true;
		txtMa_nhhd.AutoValid = false;
		((TextBoxBase)txtMa_nhhd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhhd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_nhhd;
		location = new Point(162, 206);
		((Control)asTextBox14).Location = location;
		txtMa_nhhd.LookupCodeName = "MA_NHHD";
		((TextBoxBase)txtMa_nhhd).MaxLength = 8;
		((Control)txtMa_nhhd).Name = "txtMa_nhhd";
		txtMa_nhhd.NameControl = lblTen_nhhd;
		AsTextBox asTextBox15 = txtMa_nhhd;
		size = new Size(88, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_nhhd).TabIndex = 9;
		((Control)txtMa_nhhd).Tag = "MA_NHHD";
		txtMa_nhhd.UseAutoCompleteSource = true;
		((Control)lblTen_nhhd).Anchor = (AnchorStyles)13;
		lblTen_nhhd.ImeMode = (ImeMode)0;
		Label obj49 = lblTen_nhhd;
		location = new Point(256, 210);
		((Control)obj49).Location = location;
		((Control)lblTen_nhhd).Name = "lblTen_nhhd";
		Label obj50 = lblTen_nhhd;
		size = new Size(438, 13);
		((Control)obj50).Size = size;
		((Control)lblTen_nhhd).TabIndex = 1115;
		((Control)lblTen_Hd).Anchor = (AnchorStyles)13;
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj51 = lblTen_Hd;
		location = new Point(256, 186);
		((Control)obj51).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj52 = lblTen_Hd;
		size = new Size(438, 13);
		((Control)obj52).Size = size;
		((Control)lblTen_Hd).TabIndex = 1113;
		((TextBox)txtMa_hd).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox16 = txtMa_hd;
		location = new Point(162, 182);
		((Control)asTextBox16).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_Hd;
		AsTextBox asTextBox17 = txtMa_hd;
		size = new Size(88, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtMa_hd).TabIndex = 8;
		((Control)txtMa_hd).Tag = "MA_HD";
		txtMa_hd.UseAutoCompleteSource = true;
		lblMa_hd.AutoSize = true;
		lblMa_hd.ImeMode = (ImeMode)0;
		Label obj53 = lblMa_hd;
		location = new Point(23, 186);
		((Control)obj53).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj54 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj54).Size = size;
		((Control)lblMa_hd).TabIndex = 1112;
		lblMa_hd.Text = "Mã hợp đồng";
		lblMa_NhKh.AutoSize = true;
		((Control)lblMa_NhKh).Enabled = false;
		lblMa_NhKh.ImeMode = (ImeMode)0;
		Label obj55 = lblMa_NhKh;
		location = new Point(556, 125);
		((Control)obj55).Location = location;
		((Control)lblMa_NhKh).Name = "lblMa_NhKh";
		Label obj56 = lblMa_NhKh;
		size = new Size(53, 13);
		((Control)obj56).Size = size;
		((Control)lblMa_NhKh).TabIndex = 1110;
		lblMa_NhKh.Text = "Nhóm KH";
		((Control)lblMa_NhKh).Visible = false;
		txtMa_NhKh.AutoLookup = true;
		txtMa_NhKh.AutoValid = false;
		((TextBoxBase)txtMa_NhKh).BackColor = SystemColors.Info;
		((TextBox)txtMa_NhKh).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_NhKh).Enabled = false;
		AsTextBox asTextBox18 = txtMa_NhKh;
		location = new Point(642, 121);
		((Control)asTextBox18).Location = location;
		txtMa_NhKh.LookupCodeName = "MA_NHKH";
		((TextBoxBase)txtMa_NhKh).MaxLength = 8;
		((Control)txtMa_NhKh).Name = "txtMa_NhKh";
		txtMa_NhKh.NameControl = lblTen_NhKh;
		AsTextBox asTextBox19 = txtMa_NhKh;
		size = new Size(90, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtMa_NhKh).TabIndex = 1;
		((Control)txtMa_NhKh).Tag = "MA_NHKH";
		txtMa_NhKh.UseAutoCompleteSource = true;
		((Control)txtMa_NhKh).Visible = false;
		((Control)lblTen_NhKh).Anchor = (AnchorStyles)13;
		((Control)lblTen_NhKh).Enabled = false;
		lblTen_NhKh.ImeMode = (ImeMode)0;
		Label obj57 = lblTen_NhKh;
		location = new Point(738, 40);
		((Control)obj57).Location = location;
		((Control)lblTen_NhKh).Name = "lblTen_NhKh";
		Label obj58 = lblTen_NhKh;
		size = new Size(442, 13);
		((Control)obj58).Size = size;
		((Control)lblTen_NhKh).TabIndex = 1111;
		((Control)lblTen_NhKh).Visible = false;
		((Control)lblTen_Kh).Anchor = (AnchorStyles)13;
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj59 = lblTen_Kh;
		location = new Point(256, 90);
		((Control)obj59).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj60 = lblTen_Kh;
		size = new Size(438, 13);
		((Control)obj60).Size = size;
		((Control)lblTen_Kh).TabIndex = 1109;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = false;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtMa_Kh;
		location = new Point(162, 86);
		((Control)asTextBox20).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		txtMa_Kh.LookupWhereCondition = " 1=1";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		AsTextBox asTextBox21 = txtMa_Kh;
		size = new Size(88, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMa_Kh).TabIndex = 4;
		((Control)txtMa_Kh).Tag = "MA_KH";
		txtMa_Kh.UseAutoCompleteSource = true;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj61 = lblMa_Kh;
		location = new Point(23, 90);
		((Control)obj61).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj62 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj62).Size = size;
		((Control)lblMa_Kh).TabIndex = 1108;
		lblMa_Kh.Text = "Mã khách hàng";
		((Control)lblTen_vitri).Anchor = (AnchorStyles)13;
		((Control)lblTen_vitri).Enabled = false;
		Label obj63 = lblTen_vitri;
		location = new Point(738, 259);
		((Control)obj63).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj64 = lblTen_vitri;
		size = new Size(285, 13);
		((Control)obj64).Size = size;
		((Control)lblTen_vitri).TabIndex = 1145;
		((Control)lblTen_vitri).Visible = false;
		txtMa_Plkh1.AutoLookup = true;
		txtMa_Plkh1.AutoValid = false;
		((TextBoxBase)txtMa_Plkh1).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox22 = txtMa_Plkh1;
		location = new Point(162, 110);
		((Control)asTextBox22).Location = location;
		txtMa_Plkh1.LookupCodeName = "MA_PLKH";
		txtMa_Plkh1.LookupWhereCondition = "loai='1'";
		((Control)txtMa_Plkh1).Name = "txtMa_Plkh1";
		txtMa_Plkh1.NameControl = lblTen_Plkh1;
		AsTextBox asTextBox23 = txtMa_Plkh1;
		size = new Size(88, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMa_Plkh1).TabIndex = 5;
		((Control)txtMa_Plkh1).Tag = "MA_PLKH";
		txtMa_Plkh1.UseAutoCompleteSource = true;
		((Control)lblTen_Plkh1).Anchor = (AnchorStyles)13;
		Label obj65 = lblTen_Plkh1;
		location = new Point(256, 114);
		((Control)obj65).Location = location;
		((Control)lblTen_Plkh1).Name = "lblTen_Plkh1";
		Label obj66 = lblTen_Plkh1;
		size = new Size(438, 13);
		((Control)obj66).Size = size;
		((Control)lblTen_Plkh1).TabIndex = 1133;
		txtMa_vitri.AutoLookup = true;
		txtMa_vitri.AutoValid = false;
		((TextBoxBase)txtMa_vitri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vitri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vitri).Enabled = false;
		AsTextBox asTextBox24 = txtMa_vitri;
		location = new Point(642, 255);
		((Control)asTextBox24).Location = location;
		txtMa_vitri.LookupCodeName = "MA_VITRI";
		((Control)txtMa_vitri).Name = "txtMa_vitri";
		txtMa_vitri.NameControl = lblTen_vitri;
		AsTextBox asTextBox25 = txtMa_vitri;
		size = new Size(90, 20);
		((Control)asTextBox25).Size = size;
		((Control)txtMa_vitri).TabIndex = 7;
		((Control)txtMa_vitri).Tag = "MA_VITRI";
		txtMa_vitri.UseAutoCompleteSource = true;
		((Control)txtMa_vitri).Visible = false;
		((Control)lblTen_Plkh3).Anchor = (AnchorStyles)13;
		Label obj67 = lblTen_Plkh3;
		location = new Point(256, 162);
		((Control)obj67).Location = location;
		((Control)lblTen_Plkh3).Name = "lblTen_Plkh3";
		Label obj68 = lblTen_Plkh3;
		size = new Size(438, 13);
		((Control)obj68).Size = size;
		((Control)lblTen_Plkh3).TabIndex = 1135;
		lblMavitri.AutoSize = true;
		((Control)lblMavitri).Enabled = false;
		Label obj69 = lblMavitri;
		location = new Point(556, 260);
		((Control)obj69).Location = location;
		((Control)lblMavitri).Name = "lblMavitri";
		Label obj70 = lblMavitri;
		size = new Size(46, 13);
		((Control)obj70).Size = size;
		((Control)lblMavitri).TabIndex = 1146;
		lblMavitri.Text = "Mã vị trí";
		((Control)lblMavitri).Visible = false;
		((Control)lblTen_Plkh2).Anchor = (AnchorStyles)13;
		Label obj71 = lblTen_Plkh2;
		location = new Point(256, 138);
		((Control)obj71).Location = location;
		((Control)lblTen_Plkh2).Name = "lblTen_Plkh2";
		Label obj72 = lblTen_Plkh2;
		size = new Size(438, 13);
		((Control)obj72).Size = size;
		((Control)lblTen_Plkh2).TabIndex = 1134;
		((Control)lblTen_lo).Anchor = (AnchorStyles)13;
		Label obj73 = lblTen_lo;
		location = new Point(256, 378);
		((Control)obj73).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj74 = lblTen_lo;
		size = new Size(438, 13);
		((Control)obj74).Size = size;
		((Control)lblTen_lo).TabIndex = 1143;
		txtMaLo.AutoLookup = true;
		txtMaLo.AutoValid = false;
		((TextBoxBase)txtMaLo).BackColor = SystemColors.Info;
		((TextBox)txtMaLo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox26 = txtMaLo;
		location = new Point(162, 374);
		((Control)asTextBox26).Location = location;
		txtMaLo.LookupCodeName = "MA_LO";
		((Control)txtMaLo).Name = "txtMaLo";
		txtMaLo.NameControl = lblTen_lo;
		AsTextBox asTextBox27 = txtMaLo;
		size = new Size(88, 20);
		((Control)asTextBox27).Size = size;
		((Control)txtMaLo).TabIndex = 16;
		((Control)txtMaLo).Tag = "MA_LO";
		txtMaLo.UseAutoCompleteSource = true;
		lblPlkh3.AutoSize = true;
		Label obj75 = lblPlkh3;
		location = new Point(23, 162);
		((Control)obj75).Location = location;
		((Control)lblPlkh3).Name = "lblPlkh3";
		Label obj76 = lblPlkh3;
		size = new Size(57, 13);
		((Control)obj76).Size = size;
		((Control)lblPlkh3).TabIndex = 1136;
		lblPlkh3.Text = "P.loại KH3";
		lblMaLo.AutoSize = true;
		Label obj77 = lblMaLo;
		location = new Point(23, 378);
		((Control)obj77).Location = location;
		((Control)lblMaLo).Name = "lblMaLo";
		Label obj78 = lblMaLo;
		size = new Size(33, 13);
		((Control)obj78).Size = size;
		((Control)lblMaLo).TabIndex = 1144;
		lblMaLo.Text = "Mã lô";
		txtMa_Plkh3.AutoLookup = true;
		txtMa_Plkh3.AutoValid = false;
		((TextBoxBase)txtMa_Plkh3).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox28 = txtMa_Plkh3;
		location = new Point(162, 158);
		((Control)asTextBox28).Location = location;
		txtMa_Plkh3.LookupCodeName = "MA_PLKH";
		txtMa_Plkh3.LookupWhereCondition = "loai='3'";
		((Control)txtMa_Plkh3).Name = "txtMa_Plkh3";
		txtMa_Plkh3.NameControl = lblTen_Plkh3;
		AsTextBox asTextBox29 = txtMa_Plkh3;
		size = new Size(88, 20);
		((Control)asTextBox29).Size = size;
		((Control)txtMa_Plkh3).TabIndex = 7;
		((Control)txtMa_Plkh3).Tag = "MA_PLKH";
		txtMa_Plkh3.UseAutoCompleteSource = true;
		lblPlkh2.AutoSize = true;
		Label obj79 = lblPlkh2;
		location = new Point(23, 138);
		((Control)obj79).Location = location;
		((Control)lblPlkh2).Name = "lblPlkh2";
		Label obj80 = lblPlkh2;
		size = new Size(57, 13);
		((Control)obj80).Size = size;
		((Control)lblPlkh2).TabIndex = 1137;
		lblPlkh2.Text = "P.loại KH2";
		txtMa_Plkh2.AutoLookup = true;
		txtMa_Plkh2.AutoValid = false;
		((TextBoxBase)txtMa_Plkh2).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox30 = txtMa_Plkh2;
		location = new Point(162, 134);
		((Control)asTextBox30).Location = location;
		txtMa_Plkh2.LookupCodeName = "MA_PLKH";
		txtMa_Plkh2.LookupWhereCondition = "loai='2'";
		((Control)txtMa_Plkh2).Name = "txtMa_Plkh2";
		txtMa_Plkh2.NameControl = lblTen_Plkh2;
		AsTextBox asTextBox31 = txtMa_Plkh2;
		size = new Size(88, 20);
		((Control)asTextBox31).Size = size;
		((Control)txtMa_Plkh2).TabIndex = 6;
		((Control)txtMa_Plkh2).Tag = "MA_PLKH";
		txtMa_Plkh2.UseAutoCompleteSource = true;
		lblPlkh1.AutoSize = true;
		Label obj81 = lblPlkh1;
		location = new Point(23, 114);
		((Control)obj81).Location = location;
		((Control)lblPlkh1).Name = "lblPlkh1";
		Label obj82 = lblPlkh1;
		size = new Size(57, 13);
		((Control)obj82).Size = size;
		((Control)lblPlkh1).TabIndex = 1138;
		lblPlkh1.Text = "P.loại KH1";
		txtMa_plvt1.AutoLookup = true;
		txtMa_plvt1.AutoValid = false;
		((TextBoxBase)txtMa_plvt1).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt1).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt1).Enabled = false;
		AsTextBox asTextBox32 = txtMa_plvt1;
		location = new Point(642, 175);
		((Control)asTextBox32).Location = location;
		txtMa_plvt1.LookupCodeName = "MA_PLVT";
		txtMa_plvt1.LookupWhereCondition = "loai='1'";
		((TextBoxBase)txtMa_plvt1).MaxLength = 8;
		((Control)txtMa_plvt1).Name = "txtMa_plvt1";
		txtMa_plvt1.NameControl = lblTen_plvt1;
		AsTextBox asTextBox33 = txtMa_plvt1;
		size = new Size(90, 20);
		((Control)asTextBox33).Size = size;
		((Control)txtMa_plvt1).TabIndex = 3;
		((Control)txtMa_plvt1).Tag = "MA_PLVT1";
		txtMa_plvt1.UseAutoCompleteSource = true;
		((Control)txtMa_plvt1).Visible = false;
		((Control)lblTen_plvt1).Anchor = (AnchorStyles)13;
		((Control)lblTen_plvt1).Enabled = false;
		lblTen_plvt1.ImeMode = (ImeMode)0;
		Label obj83 = lblTen_plvt1;
		location = new Point(685, 179);
		((Control)obj83).Location = location;
		((Control)lblTen_plvt1).Name = "lblTen_plvt1";
		Label obj84 = lblTen_plvt1;
		size = new Size(285, 13);
		((Control)obj84).Size = size;
		((Control)lblTen_plvt1).TabIndex = 1121;
		((Control)lblTen_plvt1).Visible = false;
		lblPLVt1.AutoSize = true;
		((Control)lblPLVt1).Enabled = false;
		lblPLVt1.ImeMode = (ImeMode)0;
		Label obj85 = lblPLVt1;
		location = new Point(556, 180);
		((Control)obj85).Location = location;
		((Control)lblPLVt1).Name = "lblPLVt1";
		Label obj86 = lblPLVt1;
		size = new Size(60, 13);
		((Control)obj86).Size = size;
		((Control)lblPLVt1).TabIndex = 1120;
		lblPLVt1.Text = "P.Loại VT1";
		((Control)lblPLVt1).Visible = false;
		((Control)lblTen_plvt2).Anchor = (AnchorStyles)13;
		((Control)lblTen_plvt2).Enabled = false;
		lblTen_plvt2.ImeMode = (ImeMode)0;
		Label obj87 = lblTen_plvt2;
		location = new Point(738, 206);
		((Control)obj87).Location = location;
		((Control)lblTen_plvt2).Name = "lblTen_plvt2";
		Label obj88 = lblTen_plvt2;
		size = new Size(285, 13);
		((Control)obj88).Size = size;
		((Control)lblTen_plvt2).TabIndex = 1123;
		((Control)lblTen_plvt2).Visible = false;
		txtMa_plvt2.AutoLookup = true;
		txtMa_plvt2.AutoValid = false;
		((TextBoxBase)txtMa_plvt2).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt2).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt2).Enabled = false;
		AsTextBox asTextBox34 = txtMa_plvt2;
		location = new Point(642, 202);
		((Control)asTextBox34).Location = location;
		txtMa_plvt2.LookupCodeName = "MA_PLVT";
		txtMa_plvt2.LookupWhereCondition = "loai='2'";
		((TextBoxBase)txtMa_plvt2).MaxLength = 8;
		((Control)txtMa_plvt2).Name = "txtMa_plvt2";
		txtMa_plvt2.NameControl = lblTen_plvt2;
		AsTextBox asTextBox35 = txtMa_plvt2;
		size = new Size(90, 20);
		((Control)asTextBox35).Size = size;
		((Control)txtMa_plvt2).TabIndex = 4;
		((Control)txtMa_plvt2).Tag = "MA_PLVT2";
		txtMa_plvt2.UseAutoCompleteSource = true;
		((Control)txtMa_plvt2).Visible = false;
		lblPLVt2.AutoSize = true;
		((Control)lblPLVt2).Enabled = false;
		lblPLVt2.ImeMode = (ImeMode)0;
		Label obj89 = lblPLVt2;
		location = new Point(556, 207);
		((Control)obj89).Location = location;
		((Control)lblPLVt2).Name = "lblPLVt2";
		Label obj90 = lblPLVt2;
		size = new Size(60, 13);
		((Control)obj90).Size = size;
		((Control)lblPLVt2).TabIndex = 1122;
		lblPLVt2.Text = "P.Loại VT2";
		((Control)lblPLVt2).Visible = false;
		((Control)lblTen_plvt3).Anchor = (AnchorStyles)13;
		((Control)lblTen_plvt3).Enabled = false;
		lblTen_plvt3.ImeMode = (ImeMode)0;
		Label obj91 = lblTen_plvt3;
		location = new Point(738, 233);
		((Control)obj91).Location = location;
		((Control)lblTen_plvt3).Name = "lblTen_plvt3";
		Label obj92 = lblTen_plvt3;
		size = new Size(285, 13);
		((Control)obj92).Size = size;
		((Control)lblTen_plvt3).TabIndex = 1126;
		((Control)lblTen_plvt3).Visible = false;
		txtMa_plvt3.AutoLookup = true;
		txtMa_plvt3.AutoValid = false;
		((TextBoxBase)txtMa_plvt3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt3).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt3).Enabled = false;
		AsTextBox asTextBox36 = txtMa_plvt3;
		location = new Point(642, 229);
		((Control)asTextBox36).Location = location;
		txtMa_plvt3.LookupCodeName = "MA_PLVT";
		txtMa_plvt3.LookupWhereCondition = "loai='3'";
		((TextBoxBase)txtMa_plvt3).MaxLength = 8;
		((Control)txtMa_plvt3).Name = "txtMa_plvt3";
		txtMa_plvt3.NameControl = lblTen_plvt3;
		AsTextBox asTextBox37 = txtMa_plvt3;
		size = new Size(90, 20);
		((Control)asTextBox37).Size = size;
		((Control)txtMa_plvt3).TabIndex = 5;
		((Control)txtMa_plvt3).Tag = "MA_PLVT3";
		txtMa_plvt3.UseAutoCompleteSource = true;
		((Control)txtMa_plvt3).Visible = false;
		((Control)lblTen_kho).Anchor = (AnchorStyles)13;
		lblTen_kho.ImeMode = (ImeMode)0;
		Label obj93 = lblTen_kho;
		location = new Point(256, 354);
		((Control)obj93).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj94 = lblTen_kho;
		size = new Size(438, 13);
		((Control)obj94).Size = size;
		((Control)lblTen_kho).TabIndex = 1128;
		lblPLVt3.AutoSize = true;
		((Control)lblPLVt3).Enabled = false;
		lblPLVt3.ImeMode = (ImeMode)0;
		Label obj95 = lblPLVt3;
		location = new Point(556, 234);
		((Control)obj95).Location = location;
		((Control)lblPLVt3).Name = "lblPLVt3";
		Label obj96 = lblPLVt3;
		size = new Size(60, 13);
		((Control)obj96).Size = size;
		((Control)lblPLVt3).TabIndex = 1125;
		lblPLVt3.Text = "P.Loại VT3";
		((Control)lblPLVt3).Visible = false;
		((TextBox)txtMa_kho).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox38 = txtMa_kho;
		location = new Point(162, 350);
		((Control)asTextBox38).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox39 = txtMa_kho;
		size = new Size(88, 20);
		((Control)asTextBox39).Size = size;
		((Control)txtMa_kho).TabIndex = 15;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		lblMa_kho.AutoSize = true;
		lblMa_kho.ImeMode = (ImeMode)0;
		Label obj97 = lblMa_kho;
		location = new Point(23, 354);
		((Control)obj97).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj98 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj98).Size = size;
		((Control)lblMa_kho).TabIndex = 1127;
		lblMa_kho.Text = "Mã kho";
		Label obj99 = lblTen_spct;
		location = new Point(256, 402);
		((Control)obj99).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj100 = lblTen_spct;
		size = new Size(284, 13);
		((Control)obj100).Size = size;
		((Control)lblTen_spct).TabIndex = 1279;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox40 = txtMa_spct;
		location = new Point(162, 398);
		((Control)asTextBox40).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox41 = txtMa_spct;
		size = new Size(88, 20);
		((Control)asTextBox41).Size = size;
		((Control)txtMa_spct).TabIndex = 17;
		((Control)txtMa_spct).Tag = "MA_SPCT";
		txtMa_spct.UseAutoCompleteSource = true;
		lblMa_spct.AutoSize = true;
		Label obj101 = lblMa_spct;
		location = new Point(23, 402);
		((Control)obj101).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj102 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj102).Size = size;
		((Control)lblMa_spct).TabIndex = 1280;
		lblMa_spct.Text = "Mã SPCT";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(840, 607);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmSORptBCPT04";
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_Kh).Text);
		arrayList.Add(((TextBox)txtMa_NhKh).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_Bp).Text);
		arrayList.Add(((TextBox)txtMa_Nvkd).Text);
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtMa_nhhd).Text);
		arrayList.Add(((TextBox)txtMa_plvt1).Text);
		arrayList.Add(((TextBox)txtMa_plvt2).Text);
		arrayList.Add(((TextBox)txtMa_plvt3).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkKhuyen_mai.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_ck.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkHang_ban.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_lai.Checked));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(((TextBox)txtMa_Plkh1).Text);
		arrayList.Add(((TextBox)txtMa_Plkh2).Text);
		arrayList.Add(((TextBox)txtMa_Plkh3).Text);
		arrayList.Add(((TextBox)txtMA_HTTT).Text);
		arrayList.Add(((TextBox)txtMA_DKTT).Text);
		arrayList.Add(((TextBox)txtMa_vitri).Text);
		arrayList.Add(((TextBox)txtMaLo).Text);
		arrayList.Add(((ListControl)cboMau_bc).SelectedValue.ToString());
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		DataRowView dataRowView;
		ArrayList result;
		try
		{
			dataRowView = new DataView((DataTable)base.dgvBC.DataSource)[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index];
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			base.CancelDrilldown = true;
			result = null;
			ProjectData.ClearProjectError();
			goto IL_0255;
		}
		if ((int)keycode != 116 || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false), (object)"", false) ? true : false))
		{
			base.CancelDrilldown = true;
			result = null;
		}
		else
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(((TextBox)txtMa_Kh).Text.Trim());
			arrayList.Add(((TextBox)txtMa_NhKh).Text.Trim());
			arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false)));
			arrayList.Add(((TextBox)txtMa_nhvt).Text.Trim());
			arrayList.Add(((TextBox)txtMa_kho).Text.Trim());
			arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_BP"]), isNum: false)));
			arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Nvkd"]), isNum: false)));
			arrayList.Add(((TextBox)txtMa_hd).Text.Trim());
			arrayList.Add(RuntimeHelpers.GetObjectValue(ChkKhuyen_mai.Checked));
			arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_ck.Checked));
			arrayList.Add(RuntimeHelpers.GetObjectValue(ChkHang_ban.Checked));
			arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_lai.Checked));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			if (Information.IsDBNull((object)arrayList))
			{
				base.CancelDrilldown = true;
				result = null;
			}
			else
			{
				filterCondition4title = dataRowView["ma_vt"].ToString() + ": [" + dataRowView["ten_vt"].ToString();
				result = arrayList;
			}
		}
		goto IL_0255;
		IL_0255:
		return result;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(((TextBox)txtMa_Kh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Kh.Text + ": [" + ((TextBox)txtMa_Kh).Text + " - " + lblTen_Kh.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_NhKh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_NhKh.Text + ": [" + ((TextBox)txtMa_NhKh).Text + " - " + lblTen_NhKh.Text + "]; ";
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
			text = text + lblPlkh3.Text + ": [" + ((TextBox)txtMa_Plkh3).Text + " - " + lblTen_Plkh2.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vitri).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_vitri.Text + ": [" + ((TextBox)txtMa_vitri).Text + " - " + lblTen_vitri.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMaLo).Text.Trim(), "", false) != 0)
		{
			text = text + lblTen_lo.Text + ": [" + ((TextBox)txtMaLo).Text + " - " + lblTen_lo.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMA_HTTT).Text.Trim(), "", false) != 0)
		{
			text = text + lblHTTT.Text + ": [" + ((TextBox)txtMA_HTTT).Text + " - " + lblHTTT.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMA_DKTT).Text.Trim(), "", false) != 0)
		{
			text = text + lblDkTT.Text + ": [" + ((TextBox)txtMA_DKTT).Text + " - " + lblDkTT.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_hd).Text, "", false) != 0)
		{
			text = text + lblMa_hd.Text + ": [" + ((TextBox)txtMa_hd).Text + " - " + lblTen_Hd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhhd).Text, "", false) != 0)
		{
			text = text + lblMa_nhhd.Text + ": [" + ((TextBox)txtMa_nhhd).Text + " - " + lblTen_nhhd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
		{
			text = text + lblMa_vt.Text + ": [" + ((TextBox)txtMa_vt).Text + " - " + lblTen_vt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhvt).Text, "", false) != 0)
		{
			text = text + lblMa_nhvt.Text + ": [" + ((TextBox)txtMa_nhvt).Text + " - " + lblTen_nhvt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt1).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLVt1.Text + ": [" + ((TextBox)txtMa_plvt1).Text + " - " + lblTen_plvt1.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt2).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLVt2.Text + ": [" + ((TextBox)txtMa_plvt2).Text + " - " + lblTen_plvt2.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt3).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLVt3.Text + ": [" + ((TextBox)txtMa_plvt3).Text + " - " + lblTen_plvt3.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text, "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": [" + ((TextBox)txtMa_kho).Text + " - " + lblTen_kho.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nvkd).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_bp.Text + ": [" + ((TextBox)txtMa_Nvkd).Text.Trim() + " - " + lblTen_Nvkd.Text + "]; ";
		}
		if (Conversions.ToBoolean(ChkTra_lai.Checked))
		{
			text = text + lblTru.Text + ": [" + ((ButtonBase)ChkTra_lai).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": [" + ((TextBox)txtMa_Nt).Text + "]; ";
		}
		if (text.Length > 2)
		{
			text = text.Substring(0, checked(text.Length - 2));
		}
		return text;
	}
}
