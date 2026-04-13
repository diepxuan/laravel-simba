using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class Form3 : Form
{
	private IContainer components;

	[AccessedThroughProperty("pFilter")]
	private Panel _pFilter;

	[AccessedThroughProperty("palMa_plkh1")]
	private Panel _palMa_plkh1;

	[AccessedThroughProperty("txtMa_Plkh1")]
	private AsTextBox _txtMa_Plkh1;

	[AccessedThroughProperty("lblTen_lkh1")]
	private Label _lblTen_lkh1;

	[AccessedThroughProperty("lblPlkh1")]
	private Label _lblPlkh1;

	[AccessedThroughProperty("palMa_plkh2")]
	private Panel _palMa_plkh2;

	[AccessedThroughProperty("txtMa_Plkh2")]
	private AsTextBox _txtMa_Plkh2;

	[AccessedThroughProperty("lblTen_lkh2")]
	private Label _lblTen_lkh2;

	[AccessedThroughProperty("lblPlkh2")]
	private Label _lblPlkh2;

	[AccessedThroughProperty("palMa_plkh3")]
	private Panel _palMa_plkh3;

	[AccessedThroughProperty("txtMa_Plkh3")]
	private AsTextBox _txtMa_Plkh3;

	[AccessedThroughProperty("lblTen_lkh3")]
	private Label _lblTen_lkh3;

	[AccessedThroughProperty("lblPlkh3")]
	private Label _lblPlkh3;

	[AccessedThroughProperty("palMa_plvt1")]
	private Panel _palMa_plvt1;

	[AccessedThroughProperty("txtMa_Plvt1")]
	private AsTextBox _txtMa_Plvt1;

	[AccessedThroughProperty("lblTen_plvt1")]
	private Label _lblTen_plvt1;

	[AccessedThroughProperty("lblPlvt1")]
	private Label _lblPlvt1;

	[AccessedThroughProperty("palMa_plvt2")]
	private Panel _palMa_plvt2;

	[AccessedThroughProperty("txtMa_Plvt2")]
	private AsTextBox _txtMa_Plvt2;

	[AccessedThroughProperty("lblTen_plvt2")]
	private Label _lblTen_plvt2;

	[AccessedThroughProperty("lblPlvt2")]
	private Label _lblPlvt2;

	[AccessedThroughProperty("palMa_plvt3")]
	private Panel _palMa_plvt3;

	[AccessedThroughProperty("txtMa_plvt3")]
	private AsTextBox _txtMa_plvt3;

	[AccessedThroughProperty("lblTen_plvt3")]
	private Label _lblTen_plvt3;

	[AccessedThroughProperty("lblPlvt3")]
	private Label _lblPlvt3;

	[AccessedThroughProperty("palMa_spct")]
	private Panel _palMa_spct;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("palMa_kho")]
	private Panel _palMa_kho;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("palMa_vitri")]
	private Panel _palMa_vitri;

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("txtMa_vitri")]
	private AsTextBox _txtMa_vitri;

	[AccessedThroughProperty("lblMavitri")]
	private Label _lblMavitri;

	[AccessedThroughProperty("palMa_lo")]
	private Panel _palMa_lo;

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("txtMaLo")]
	private AsTextBox _txtMaLo;

	[AccessedThroughProperty("lblMaLo")]
	private Label _lblMaLo;

	[AccessedThroughProperty("palMa_kh")]
	private Panel _palMa_kh;

	[AccessedThroughProperty("txtMa_kh")]
	private AsTextBox _txtMa_kh;

	[AccessedThroughProperty("lblTen_kh")]
	private Label _lblTen_kh;

	[AccessedThroughProperty("lblMa_kh")]
	private Label _lblMa_kh;

	[AccessedThroughProperty("palMa_nhkh")]
	private Panel _palMa_nhkh;

	[AccessedThroughProperty("txtMa_Nhkh")]
	private AsTextBox _txtMa_Nhkh;

	[AccessedThroughProperty("lblTen_nhkh")]
	private Label _lblTen_nhkh;

	[AccessedThroughProperty("lblMa_Nhkh")]
	private Label _lblMa_Nhkh;

	[AccessedThroughProperty("palMa_hd")]
	private Panel _palMa_hd;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

	[AccessedThroughProperty("palMa_nhhd")]
	private Panel _palMa_nhhd;

	[AccessedThroughProperty("txtMa_nhhd")]
	private AsTextBox _txtMa_nhhd;

	[AccessedThroughProperty("lblTen_Nhhd")]
	private Label _lblTen_Nhhd;

	[AccessedThroughProperty("lblMa_nhhd")]
	private Label _lblMa_nhhd;

	[AccessedThroughProperty("palMa_vt")]
	private Panel _palMa_vt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("palMa_nhvt")]
	private Panel _palMa_nhvt;

	[AccessedThroughProperty("txtMa_nhvt")]
	private AsTextBox _txtMa_nhvt;

	[AccessedThroughProperty("lblTen_Nhvt")]
	private Label _lblTen_Nhvt;

	[AccessedThroughProperty("lblMa_nhvt")]
	private Label _lblMa_nhvt;

	[AccessedThroughProperty("palMa_bp")]
	private Panel _palMa_bp;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("palMa_nvkd")]
	private Panel _palMa_nvkd;

	[AccessedThroughProperty("txtMa_nvkd")]
	private AsTextBox _txtMa_nvkd;

	[AccessedThroughProperty("lblTen_nvkd")]
	private Label _lblTen_nvkd;

	[AccessedThroughProperty("lblMa_nvkd")]
	private Label _lblMa_nvkd;

	[AccessedThroughProperty("palMa_httt")]
	private Panel _palMa_httt;

	[AccessedThroughProperty("txtMA_HTTT")]
	private AsTextBox _txtMA_HTTT;

	[AccessedThroughProperty("lblTenHTTT")]
	private Label _lblTenHTTT;

	[AccessedThroughProperty("lblHTTT")]
	private Label _lblHTTT;

	[AccessedThroughProperty("palMa_tt")]
	private Panel _palMa_tt;

	[AccessedThroughProperty("txtMA_DKTT")]
	private AsTextBox _txtMA_DKTT;

	[AccessedThroughProperty("lblTen_TT")]
	private Label _lblTen_TT;

	[AccessedThroughProperty("lblDkTT")]
	private Label _lblDkTT;

	internal virtual Panel pFilter
	{
		[DebuggerNonUserCode]
		get
		{
			return _pFilter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_pFilter = value;
		}
	}

	internal virtual Panel palMa_plkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_plkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_plkh1 = value;
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

	internal virtual Panel palMa_plkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_plkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_plkh2 = value;
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

	internal virtual Panel palMa_plkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_plkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_plkh3 = value;
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

	internal virtual Panel palMa_plvt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_plvt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_plvt1 = value;
		}
	}

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

	internal virtual Panel palMa_plvt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_plvt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_plvt2 = value;
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

	internal virtual Panel palMa_plvt3
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_plvt3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_plvt3 = value;
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

	internal virtual Panel palMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_spct = value;
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

	internal virtual Panel palMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_kho = value;
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

	internal virtual Panel palMa_vitri
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_vitri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_vitri = value;
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

	internal virtual Panel palMa_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_lo = value;
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

	internal virtual Panel palMa_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_kh = value;
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

	internal virtual Label lblTen_kh
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

	internal virtual Label lblMa_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kh = value;
		}
	}

	internal virtual Panel palMa_nhkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_nhkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_nhkh = value;
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

	internal virtual Panel palMa_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_hd = value;
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

	internal virtual Panel palMa_nhhd
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_nhhd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_nhhd = value;
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

	internal virtual Panel palMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_vt = value;
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

	internal virtual Panel palMa_nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_nhvt = value;
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

	internal virtual Panel palMa_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_bp = value;
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

	internal virtual Panel palMa_nvkd
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_nvkd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_nvkd = value;
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

	internal virtual Panel palMa_httt
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_httt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_httt = value;
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

	internal virtual Panel palMa_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _palMa_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_palMa_tt = value;
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

	[DebuggerNonUserCode]
	public Form3()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_100e: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1938: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2224: Unknown result type (might be due to invalid IL or missing references)
		//IL_245d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2696: Unknown result type (might be due to invalid IL or missing references)
		//IL_28cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d47: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f90: Unknown result type (might be due to invalid IL or missing references)
		//IL_31dc: Unknown result type (might be due to invalid IL or missing references)
		pFilter = new Panel();
		palMa_plkh1 = new Panel();
		txtMa_Plkh1 = new AsTextBox();
		lblTen_lkh1 = new Label();
		lblPlkh1 = new Label();
		palMa_plkh2 = new Panel();
		txtMa_Plkh2 = new AsTextBox();
		lblTen_lkh2 = new Label();
		lblPlkh2 = new Label();
		palMa_plkh3 = new Panel();
		txtMa_Plkh3 = new AsTextBox();
		lblTen_lkh3 = new Label();
		lblPlkh3 = new Label();
		palMa_plvt1 = new Panel();
		txtMa_Plvt1 = new AsTextBox();
		lblTen_plvt1 = new Label();
		lblPlvt1 = new Label();
		palMa_plvt2 = new Panel();
		txtMa_Plvt2 = new AsTextBox();
		lblTen_plvt2 = new Label();
		lblPlvt2 = new Label();
		palMa_plvt3 = new Panel();
		txtMa_plvt3 = new AsTextBox();
		lblTen_plvt3 = new Label();
		lblPlvt3 = new Label();
		palMa_spct = new Panel();
		txtMa_spct = new AsTextBox();
		lblTen_spct = new Label();
		lblMa_spct = new Label();
		palMa_kho = new Panel();
		txtMa_kho = new AsTextBox();
		lblTen_kho = new Label();
		lblMa_kho = new Label();
		palMa_vitri = new Panel();
		lblTen_vitri = new Label();
		txtMa_vitri = new AsTextBox();
		lblMavitri = new Label();
		palMa_lo = new Panel();
		lblTen_lo = new Label();
		txtMaLo = new AsTextBox();
		lblMaLo = new Label();
		palMa_kh = new Panel();
		txtMa_kh = new AsTextBox();
		lblTen_kh = new Label();
		lblMa_kh = new Label();
		palMa_nhkh = new Panel();
		txtMa_Nhkh = new AsTextBox();
		lblTen_nhkh = new Label();
		lblMa_Nhkh = new Label();
		palMa_hd = new Panel();
		txtMa_hd = new AsTextBox();
		lblTen_hd = new Label();
		lblMa_hd = new Label();
		palMa_nhhd = new Panel();
		txtMa_nhhd = new AsTextBox();
		lblTen_Nhhd = new Label();
		lblMa_nhhd = new Label();
		palMa_vt = new Panel();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		lblMa_vt = new Label();
		palMa_nhvt = new Panel();
		txtMa_nhvt = new AsTextBox();
		lblTen_Nhvt = new Label();
		lblMa_nhvt = new Label();
		palMa_bp = new Panel();
		txtMa_bp = new AsTextBox();
		lblTen_bp = new Label();
		lblMa_bp = new Label();
		palMa_nvkd = new Panel();
		txtMa_nvkd = new AsTextBox();
		lblTen_nvkd = new Label();
		lblMa_nvkd = new Label();
		palMa_httt = new Panel();
		txtMA_HTTT = new AsTextBox();
		lblTenHTTT = new Label();
		lblHTTT = new Label();
		palMa_tt = new Panel();
		txtMA_DKTT = new AsTextBox();
		lblTen_TT = new Label();
		lblDkTT = new Label();
		((Control)pFilter).SuspendLayout();
		((Control)palMa_plkh1).SuspendLayout();
		((Control)palMa_plkh2).SuspendLayout();
		((Control)palMa_plkh3).SuspendLayout();
		((Control)palMa_plvt1).SuspendLayout();
		((Control)palMa_plvt2).SuspendLayout();
		((Control)palMa_plvt3).SuspendLayout();
		((Control)palMa_spct).SuspendLayout();
		((Control)palMa_kho).SuspendLayout();
		((Control)palMa_vitri).SuspendLayout();
		((Control)palMa_lo).SuspendLayout();
		((Control)palMa_kh).SuspendLayout();
		((Control)palMa_nhkh).SuspendLayout();
		((Control)palMa_hd).SuspendLayout();
		((Control)palMa_nhhd).SuspendLayout();
		((Control)palMa_vt).SuspendLayout();
		((Control)palMa_nhvt).SuspendLayout();
		((Control)palMa_bp).SuspendLayout();
		((Control)palMa_nvkd).SuspendLayout();
		((Control)palMa_httt).SuspendLayout();
		((Control)palMa_tt).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)pFilter).Controls.Add((Control)(object)palMa_plkh1);
		((Control)pFilter).Controls.Add((Control)(object)palMa_plkh2);
		((Control)pFilter).Controls.Add((Control)(object)palMa_plkh3);
		((Control)pFilter).Controls.Add((Control)(object)palMa_plvt1);
		((Control)pFilter).Controls.Add((Control)(object)palMa_plvt2);
		((Control)pFilter).Controls.Add((Control)(object)palMa_plvt3);
		((Control)pFilter).Controls.Add((Control)(object)palMa_spct);
		((Control)pFilter).Controls.Add((Control)(object)palMa_kho);
		((Control)pFilter).Controls.Add((Control)(object)palMa_vitri);
		((Control)pFilter).Controls.Add((Control)(object)palMa_lo);
		((Control)pFilter).Controls.Add((Control)(object)palMa_kh);
		((Control)pFilter).Controls.Add((Control)(object)palMa_nhkh);
		((Control)pFilter).Controls.Add((Control)(object)palMa_hd);
		((Control)pFilter).Controls.Add((Control)(object)palMa_nhhd);
		((Control)pFilter).Controls.Add((Control)(object)palMa_vt);
		((Control)pFilter).Controls.Add((Control)(object)palMa_nhvt);
		((Control)pFilter).Controls.Add((Control)(object)palMa_bp);
		((Control)pFilter).Controls.Add((Control)(object)palMa_nvkd);
		((Control)pFilter).Controls.Add((Control)(object)palMa_httt);
		((Control)pFilter).Controls.Add((Control)(object)palMa_tt);
		Panel obj = pFilter;
		Point location = new Point(12, 12);
		((Control)obj).Location = location;
		((Control)pFilter).Name = "pFilter";
		Panel obj2 = pFilter;
		Size size = new Size(1030, 305);
		((Control)obj2).Size = size;
		((Control)pFilter).TabIndex = 71;
		((Control)palMa_plkh1).Controls.Add((Control)(object)txtMa_Plkh1);
		((Control)palMa_plkh1).Controls.Add((Control)(object)lblPlkh1);
		((Control)palMa_plkh1).Controls.Add((Control)(object)lblTen_lkh1);
		Panel obj3 = palMa_plkh1;
		location = new Point(472, 0);
		((Control)obj3).Location = location;
		Panel obj4 = palMa_plkh1;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Control)obj4).Margin = margin;
		((Control)palMa_plkh1).Name = "palMa_plkh1";
		Panel obj5 = palMa_plkh1;
		size = new Size(482, 25);
		((Control)obj5).Size = size;
		((Control)palMa_plkh1).TabIndex = 188;
		((Control)palMa_plkh1).Visible = false;
		txtMa_Plkh1.AutoLookup = true;
		txtMa_Plkh1.AutoValid = false;
		((TextBoxBase)txtMa_Plkh1).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Plkh1;
		location = new Point(101, 2);
		((Control)asTextBox).Location = location;
		txtMa_Plkh1.LookupCodeName = "MA_PLKH";
		txtMa_Plkh1.LookupWhereCondition = "loai='1'";
		((Control)txtMa_Plkh1).Name = "txtMa_Plkh1";
		txtMa_Plkh1.NameControl = lblTen_lkh1;
		AsTextBox asTextBox2 = txtMa_Plkh1;
		size = new Size(90, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Plkh1).TabIndex = 174;
		((Control)txtMa_Plkh1).Tag = "MA_PLKH";
		txtMa_Plkh1.UseAutoCompleteSource = true;
		((Control)lblTen_lkh1).Anchor = (AnchorStyles)13;
		Label obj6 = lblTen_lkh1;
		location = new Point(196, 6);
		((Control)obj6).Location = location;
		((Control)lblTen_lkh1).Name = "lblTen_lkh1";
		Label obj7 = lblTen_lkh1;
		size = new Size(268, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_lkh1).TabIndex = 184;
		lblPlkh1.AutoSize = true;
		Label obj8 = lblPlkh1;
		location = new Point(15, 6);
		((Control)obj8).Location = location;
		((Control)lblPlkh1).Name = "lblPlkh1";
		Label obj9 = lblPlkh1;
		size = new Size(57, 13);
		((Control)obj9).Size = size;
		((Control)lblPlkh1).TabIndex = 197;
		lblPlkh1.Text = "P.loại KH1";
		((Control)palMa_plkh2).Controls.Add((Control)(object)txtMa_Plkh2);
		((Control)palMa_plkh2).Controls.Add((Control)(object)lblPlkh2);
		((Control)palMa_plkh2).Controls.Add((Control)(object)lblTen_lkh2);
		Panel obj10 = palMa_plkh2;
		location = new Point(472, 25);
		((Control)obj10).Location = location;
		Panel obj11 = palMa_plkh2;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj11).Margin = margin;
		((Control)palMa_plkh2).Name = "palMa_plkh2";
		Panel obj12 = palMa_plkh2;
		size = new Size(482, 25);
		((Control)obj12).Size = size;
		((Control)palMa_plkh2).TabIndex = 189;
		((Control)palMa_plkh2).Visible = false;
		txtMa_Plkh2.AutoLookup = true;
		txtMa_Plkh2.AutoValid = false;
		((TextBoxBase)txtMa_Plkh2).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_Plkh2;
		location = new Point(101, 3);
		((Control)asTextBox3).Location = location;
		txtMa_Plkh2.LookupCodeName = "MA_PLKH";
		txtMa_Plkh2.LookupWhereCondition = "loai='2'";
		((Control)txtMa_Plkh2).Name = "txtMa_Plkh2";
		txtMa_Plkh2.NameControl = lblTen_lkh2;
		AsTextBox asTextBox4 = txtMa_Plkh2;
		size = new Size(90, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_Plkh2).TabIndex = 175;
		((Control)txtMa_Plkh2).Tag = "MA_PLKH";
		txtMa_Plkh2.UseAutoCompleteSource = true;
		((Control)lblTen_lkh2).Anchor = (AnchorStyles)13;
		Label obj13 = lblTen_lkh2;
		location = new Point(196, 7);
		((Control)obj13).Location = location;
		((Control)lblTen_lkh2).Name = "lblTen_lkh2";
		Label obj14 = lblTen_lkh2;
		size = new Size(268, 13);
		((Control)obj14).Size = size;
		((Control)lblTen_lkh2).TabIndex = 185;
		lblPlkh2.AutoSize = true;
		Label obj15 = lblPlkh2;
		location = new Point(15, 7);
		((Control)obj15).Location = location;
		((Control)lblPlkh2).Name = "lblPlkh2";
		Label obj16 = lblPlkh2;
		size = new Size(57, 13);
		((Control)obj16).Size = size;
		((Control)lblPlkh2).TabIndex = 196;
		lblPlkh2.Text = "P.loại KH2";
		((Control)palMa_plkh3).Controls.Add((Control)(object)txtMa_Plkh3);
		((Control)palMa_plkh3).Controls.Add((Control)(object)lblPlkh3);
		((Control)palMa_plkh3).Controls.Add((Control)(object)lblTen_lkh3);
		Panel obj17 = palMa_plkh3;
		location = new Point(472, 50);
		((Control)obj17).Location = location;
		Panel obj18 = palMa_plkh3;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj18).Margin = margin;
		((Control)palMa_plkh3).Name = "palMa_plkh3";
		Panel obj19 = palMa_plkh3;
		size = new Size(482, 25);
		((Control)obj19).Size = size;
		((Control)palMa_plkh3).TabIndex = 190;
		((Control)palMa_plkh3).Visible = false;
		txtMa_Plkh3.AutoLookup = true;
		txtMa_Plkh3.AutoValid = false;
		((TextBoxBase)txtMa_Plkh3).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plkh3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_Plkh3;
		location = new Point(101, 4);
		((Control)asTextBox5).Location = location;
		txtMa_Plkh3.LookupCodeName = "MA_PLKH";
		txtMa_Plkh3.LookupWhereCondition = "loai='3'";
		((Control)txtMa_Plkh3).Name = "txtMa_Plkh3";
		txtMa_Plkh3.NameControl = lblTen_lkh3;
		AsTextBox asTextBox6 = txtMa_Plkh3;
		size = new Size(90, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_Plkh3).TabIndex = 176;
		((Control)txtMa_Plkh3).Tag = "MA_PLKH";
		txtMa_Plkh3.UseAutoCompleteSource = true;
		((Control)lblTen_lkh3).Anchor = (AnchorStyles)13;
		Label obj20 = lblTen_lkh3;
		location = new Point(196, 8);
		((Control)obj20).Location = location;
		((Control)lblTen_lkh3).Name = "lblTen_lkh3";
		Label obj21 = lblTen_lkh3;
		size = new Size(268, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_lkh3).TabIndex = 186;
		lblPlkh3.AutoSize = true;
		Label obj22 = lblPlkh3;
		location = new Point(15, 8);
		((Control)obj22).Location = location;
		((Control)lblPlkh3).Name = "lblPlkh3";
		Label obj23 = lblPlkh3;
		size = new Size(57, 13);
		((Control)obj23).Size = size;
		((Control)lblPlkh3).TabIndex = 195;
		lblPlkh3.Text = "P.loại KH3";
		((Control)palMa_plvt1).Controls.Add((Control)(object)txtMa_Plvt1);
		((Control)palMa_plvt1).Controls.Add((Control)(object)lblTen_plvt1);
		((Control)palMa_plvt1).Controls.Add((Control)(object)lblPlvt1);
		Panel obj24 = palMa_plvt1;
		location = new Point(472, 75);
		((Control)obj24).Location = location;
		Panel obj25 = palMa_plvt1;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj25).Margin = margin;
		((Control)palMa_plvt1).Name = "palMa_plvt1";
		Panel obj26 = palMa_plvt1;
		size = new Size(482, 25);
		((Control)obj26).Size = size;
		((Control)palMa_plvt1).TabIndex = 191;
		((Control)palMa_plvt1).Visible = false;
		txtMa_Plvt1.AutoLookup = true;
		txtMa_Plvt1.AutoValid = false;
		((TextBoxBase)txtMa_Plvt1).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plvt1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_Plvt1;
		location = new Point(101, 3);
		((Control)asTextBox7).Location = location;
		txtMa_Plvt1.LookupCodeName = "MA_PLVT";
		txtMa_Plvt1.LookupWhereCondition = "loai='1'";
		((Control)txtMa_Plvt1).Name = "txtMa_Plvt1";
		txtMa_Plvt1.NameControl = lblTen_plvt1;
		AsTextBox asTextBox8 = txtMa_Plvt1;
		size = new Size(90, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_Plvt1).TabIndex = 177;
		((Control)txtMa_Plvt1).Tag = "MA_PLVT";
		txtMa_Plvt1.UseAutoCompleteSource = true;
		((Control)lblTen_plvt1).Anchor = (AnchorStyles)13;
		Label obj27 = lblTen_plvt1;
		location = new Point(196, 7);
		((Control)obj27).Location = location;
		((Control)lblTen_plvt1).Name = "lblTen_plvt1";
		Label obj28 = lblTen_plvt1;
		size = new Size(268, 13);
		((Control)obj28).Size = size;
		((Control)lblTen_plvt1).TabIndex = 187;
		lblPlvt1.AutoSize = true;
		Label obj29 = lblPlvt1;
		location = new Point(15, 7);
		((Control)obj29).Location = location;
		((Control)lblPlvt1).Name = "lblPlvt1";
		Label obj30 = lblPlvt1;
		size = new Size(56, 13);
		((Control)obj30).Size = size;
		((Control)lblPlvt1).TabIndex = 194;
		lblPlvt1.Text = "P.loại VT1";
		((Control)palMa_plvt2).Controls.Add((Control)(object)txtMa_Plvt2);
		((Control)palMa_plvt2).Controls.Add((Control)(object)lblTen_plvt2);
		((Control)palMa_plvt2).Controls.Add((Control)(object)lblPlvt2);
		Panel obj31 = palMa_plvt2;
		location = new Point(472, 100);
		((Control)obj31).Location = location;
		Panel obj32 = palMa_plvt2;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj32).Margin = margin;
		((Control)palMa_plvt2).Name = "palMa_plvt2";
		Panel obj33 = palMa_plvt2;
		size = new Size(482, 25);
		((Control)obj33).Size = size;
		((Control)palMa_plvt2).TabIndex = 192;
		((Control)palMa_plvt2).Visible = false;
		txtMa_Plvt2.AutoLookup = true;
		txtMa_Plvt2.AutoValid = false;
		((TextBoxBase)txtMa_Plvt2).BackColor = SystemColors.Info;
		((TextBox)txtMa_Plvt2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_Plvt2;
		location = new Point(101, 4);
		((Control)asTextBox9).Location = location;
		txtMa_Plvt2.LookupCodeName = "MA_PLVT";
		txtMa_Plvt2.LookupWhereCondition = "loai='2'";
		((Control)txtMa_Plvt2).Name = "txtMa_Plvt2";
		txtMa_Plvt2.NameControl = lblTen_plvt2;
		AsTextBox asTextBox10 = txtMa_Plvt2;
		size = new Size(90, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_Plvt2).TabIndex = 178;
		((Control)txtMa_Plvt2).Tag = "MA_PLVT";
		txtMa_Plvt2.UseAutoCompleteSource = true;
		((Control)lblTen_plvt2).Anchor = (AnchorStyles)13;
		Label obj34 = lblTen_plvt2;
		location = new Point(196, 8);
		((Control)obj34).Location = location;
		((Control)lblTen_plvt2).Name = "lblTen_plvt2";
		Label obj35 = lblTen_plvt2;
		size = new Size(268, 13);
		((Control)obj35).Size = size;
		((Control)lblTen_plvt2).TabIndex = 188;
		lblPlvt2.AutoSize = true;
		Label obj36 = lblPlvt2;
		location = new Point(15, 8);
		((Control)obj36).Location = location;
		((Control)lblPlvt2).Name = "lblPlvt2";
		Label obj37 = lblPlvt2;
		size = new Size(56, 13);
		((Control)obj37).Size = size;
		((Control)lblPlvt2).TabIndex = 193;
		lblPlvt2.Text = "P.loại VT2";
		((Control)palMa_plvt3).Controls.Add((Control)(object)txtMa_plvt3);
		((Control)palMa_plvt3).Controls.Add((Control)(object)lblTen_plvt3);
		((Control)palMa_plvt3).Controls.Add((Control)(object)lblPlvt3);
		Panel obj38 = palMa_plvt3;
		location = new Point(472, 125);
		((Control)obj38).Location = location;
		Panel obj39 = palMa_plvt3;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj39).Margin = margin;
		((Control)palMa_plvt3).Name = "palMa_plvt3";
		Panel obj40 = palMa_plvt3;
		size = new Size(482, 25);
		((Control)obj40).Size = size;
		((Control)palMa_plvt3).TabIndex = 193;
		((Control)palMa_plvt3).Visible = false;
		txtMa_plvt3.AutoLookup = true;
		txtMa_plvt3.AutoValid = false;
		((TextBoxBase)txtMa_plvt3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtMa_plvt3;
		location = new Point(101, 3);
		((Control)asTextBox11).Location = location;
		txtMa_plvt3.LookupCodeName = "MA_PLVT";
		txtMa_plvt3.LookupWhereCondition = "loai='3'";
		((Control)txtMa_plvt3).Name = "txtMa_plvt3";
		txtMa_plvt3.NameControl = lblTen_plvt3;
		AsTextBox asTextBox12 = txtMa_plvt3;
		size = new Size(90, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtMa_plvt3).TabIndex = 179;
		((Control)txtMa_plvt3).Tag = "MA_PLVT";
		txtMa_plvt3.UseAutoCompleteSource = true;
		((Control)lblTen_plvt3).Anchor = (AnchorStyles)13;
		Label obj41 = lblTen_plvt3;
		location = new Point(196, 7);
		((Control)obj41).Location = location;
		((Control)lblTen_plvt3).Name = "lblTen_plvt3";
		Label obj42 = lblTen_plvt3;
		size = new Size(268, 13);
		((Control)obj42).Size = size;
		((Control)lblTen_plvt3).TabIndex = 189;
		lblPlvt3.AutoSize = true;
		Label obj43 = lblPlvt3;
		location = new Point(15, 7);
		((Control)obj43).Location = location;
		((Control)lblPlvt3).Name = "lblPlvt3";
		Label obj44 = lblPlvt3;
		size = new Size(56, 13);
		((Control)obj44).Size = size;
		((Control)lblPlvt3).TabIndex = 192;
		lblPlvt3.Text = "P.loại VT3";
		((Control)palMa_spct).Controls.Add((Control)(object)txtMa_spct);
		((Control)palMa_spct).Controls.Add((Control)(object)lblTen_spct);
		((Control)palMa_spct).Controls.Add((Control)(object)lblMa_spct);
		Panel obj45 = palMa_spct;
		location = new Point(472, 150);
		((Control)obj45).Location = location;
		Panel obj46 = palMa_spct;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj46).Margin = margin;
		((Control)palMa_spct).Name = "palMa_spct";
		Panel obj47 = palMa_spct;
		size = new Size(482, 25);
		((Control)obj47).Size = size;
		((Control)palMa_spct).TabIndex = 194;
		((Control)palMa_spct).Visible = false;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox13 = txtMa_spct;
		location = new Point(101, 3);
		((Control)asTextBox13).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox14 = txtMa_spct;
		size = new Size(90, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtMa_spct).TabIndex = 180;
		((Control)txtMa_spct).Tag = "MA_SPCT";
		txtMa_spct.UseAutoCompleteSource = true;
		((Control)lblTen_spct).Anchor = (AnchorStyles)13;
		Label obj48 = lblTen_spct;
		location = new Point(196, 7);
		((Control)obj48).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj49 = lblTen_spct;
		size = new Size(268, 13);
		((Control)obj49).Size = size;
		((Control)lblTen_spct).TabIndex = 202;
		lblMa_spct.AutoSize = true;
		Label obj50 = lblMa_spct;
		location = new Point(15, 7);
		((Control)obj50).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj51 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj51).Size = size;
		((Control)lblMa_spct).TabIndex = 203;
		lblMa_spct.Text = "Mã SPCT";
		lblMa_spct.TextAlign = (ContentAlignment)32;
		((Control)palMa_kho).Controls.Add((Control)(object)txtMa_kho);
		((Control)palMa_kho).Controls.Add((Control)(object)lblMa_kho);
		((Control)palMa_kho).Controls.Add((Control)(object)lblTen_kho);
		Panel obj52 = palMa_kho;
		location = new Point(472, 175);
		((Control)obj52).Location = location;
		Panel obj53 = palMa_kho;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj53).Margin = margin;
		((Control)palMa_kho).Name = "palMa_kho";
		Panel obj54 = palMa_kho;
		size = new Size(482, 25);
		((Control)obj54).Size = size;
		((Control)palMa_kho).TabIndex = 195;
		((Control)palMa_kho).Visible = false;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox15 = txtMa_kho;
		location = new Point(101, 4);
		((Control)asTextBox15).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox16 = txtMa_kho;
		size = new Size(90, 20);
		((Control)asTextBox16).Size = size;
		((Control)txtMa_kho).TabIndex = 181;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		((Control)lblTen_kho).Anchor = (AnchorStyles)13;
		Label obj55 = lblTen_kho;
		location = new Point(195, 8);
		((Control)obj55).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj56 = lblTen_kho;
		size = new Size(268, 13);
		((Control)obj56).Size = size;
		((Control)lblTen_kho).TabIndex = 190;
		lblMa_kho.AutoSize = true;
		Label obj57 = lblMa_kho;
		location = new Point(15, 8);
		((Control)obj57).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj58 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj58).Size = size;
		((Control)lblMa_kho).TabIndex = 191;
		lblMa_kho.Text = "Mã kho";
		((Control)palMa_vitri).Controls.Add((Control)(object)lblTen_vitri);
		((Control)palMa_vitri).Controls.Add((Control)(object)txtMa_vitri);
		((Control)palMa_vitri).Controls.Add((Control)(object)lblMavitri);
		Panel obj59 = palMa_vitri;
		location = new Point(472, 200);
		((Control)obj59).Location = location;
		Panel obj60 = palMa_vitri;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj60).Margin = margin;
		((Control)palMa_vitri).Name = "palMa_vitri";
		Panel obj61 = palMa_vitri;
		size = new Size(482, 25);
		((Control)obj61).Size = size;
		((Control)palMa_vitri).TabIndex = 196;
		((Control)palMa_vitri).Visible = false;
		((Control)lblTen_vitri).Anchor = (AnchorStyles)13;
		Label obj62 = lblTen_vitri;
		location = new Point(196, 7);
		((Control)obj62).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj63 = lblTen_vitri;
		size = new Size(268, 13);
		((Control)obj63).Size = size;
		((Control)lblTen_vitri).TabIndex = 200;
		txtMa_vitri.AutoLookup = true;
		txtMa_vitri.AutoValid = false;
		((TextBoxBase)txtMa_vitri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vitri).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox17 = txtMa_vitri;
		location = new Point(101, 3);
		((Control)asTextBox17).Location = location;
		txtMa_vitri.LookupCodeName = "MA_VITRI";
		((Control)txtMa_vitri).Name = "txtMa_vitri";
		txtMa_vitri.NameControl = lblTen_vitri;
		AsTextBox asTextBox18 = txtMa_vitri;
		size = new Size(90, 20);
		((Control)asTextBox18).Size = size;
		((Control)txtMa_vitri).TabIndex = 182;
		((Control)txtMa_vitri).Tag = "MA_VITRI";
		txtMa_vitri.UseAutoCompleteSource = true;
		lblMavitri.AutoSize = true;
		Label obj64 = lblMavitri;
		location = new Point(15, 7);
		((Control)obj64).Location = location;
		((Control)lblMavitri).Name = "lblMavitri";
		Label obj65 = lblMavitri;
		size = new Size(46, 13);
		((Control)obj65).Size = size;
		((Control)lblMavitri).TabIndex = 201;
		lblMavitri.Text = "Mã vị trí";
		((Control)palMa_lo).Controls.Add((Control)(object)lblTen_lo);
		((Control)palMa_lo).Controls.Add((Control)(object)txtMaLo);
		((Control)palMa_lo).Controls.Add((Control)(object)lblMaLo);
		Panel obj66 = palMa_lo;
		location = new Point(472, 225);
		((Control)obj66).Location = location;
		Panel obj67 = palMa_lo;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj67).Margin = margin;
		((Control)palMa_lo).Name = "palMa_lo";
		Panel obj68 = palMa_lo;
		size = new Size(482, 25);
		((Control)obj68).Size = size;
		((Control)palMa_lo).TabIndex = 197;
		((Control)palMa_lo).Visible = false;
		((Control)lblTen_lo).Anchor = (AnchorStyles)13;
		Label obj69 = lblTen_lo;
		location = new Point(195, 7);
		((Control)obj69).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj70 = lblTen_lo;
		size = new Size(268, 13);
		((Control)obj70).Size = size;
		((Control)lblTen_lo).TabIndex = 198;
		txtMaLo.AutoLookup = true;
		txtMaLo.AutoValid = false;
		((TextBoxBase)txtMaLo).BackColor = SystemColors.Info;
		((TextBox)txtMaLo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox19 = txtMaLo;
		location = new Point(101, 3);
		((Control)asTextBox19).Location = location;
		txtMaLo.LookupCodeName = "MA_LO";
		((Control)txtMaLo).Name = "txtMaLo";
		txtMaLo.NameControl = lblTen_lo;
		AsTextBox asTextBox20 = txtMaLo;
		size = new Size(90, 20);
		((Control)asTextBox20).Size = size;
		((Control)txtMaLo).TabIndex = 183;
		((Control)txtMaLo).Tag = "MA_LO";
		txtMaLo.UseAutoCompleteSource = true;
		lblMaLo.AutoSize = true;
		Label obj71 = lblMaLo;
		location = new Point(15, 7);
		((Control)obj71).Location = location;
		((Control)lblMaLo).Name = "lblMaLo";
		Label obj72 = lblMaLo;
		size = new Size(33, 13);
		((Control)obj72).Size = size;
		((Control)lblMaLo).TabIndex = 199;
		lblMaLo.Text = "Mã lô";
		((Control)palMa_kh).Controls.Add((Control)(object)txtMa_kh);
		((Control)palMa_kh).Controls.Add((Control)(object)lblTen_kh);
		((Control)palMa_kh).Controls.Add((Control)(object)lblMa_kh);
		Panel obj73 = palMa_kh;
		location = new Point(4, 0);
		((Control)obj73).Location = location;
		Panel obj74 = palMa_kh;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj74).Margin = margin;
		((Control)palMa_kh).Name = "palMa_kh";
		Panel obj75 = palMa_kh;
		size = new Size(454, 25);
		((Control)obj75).Size = size;
		((Control)palMa_kh).TabIndex = 178;
		((Control)palMa_kh).Visible = false;
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = false;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox21 = txtMa_kh;
		location = new Point(96, 4);
		((Control)asTextBox21).Location = location;
		txtMa_kh.LookupCodeName = "MA_KH";
		txtMa_kh.LookupWhereCondition = "isKh=1";
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = lblTen_kh;
		AsTextBox asTextBox22 = txtMa_kh;
		size = new Size(90, 20);
		((Control)asTextBox22).Size = size;
		((Control)txtMa_kh).TabIndex = 142;
		((Control)txtMa_kh).Tag = "Ma_KH";
		txtMa_kh.UseAutoCompleteSource = true;
		Label obj76 = lblTen_kh;
		location = new Point(192, 7);
		((Control)obj76).Location = location;
		((Control)lblTen_kh).Name = "lblTen_kh";
		Label obj77 = lblTen_kh;
		size = new Size(229, 13);
		((Control)obj77).Size = size;
		((Control)lblTen_kh).TabIndex = 152;
		lblMa_kh.AutoSize = true;
		Label obj78 = lblMa_kh;
		location = new Point(8, 7);
		((Control)obj78).Location = location;
		((Control)lblMa_kh).Name = "lblMa_kh";
		Label obj79 = lblMa_kh;
		size = new Size(82, 13);
		((Control)obj79).Size = size;
		((Control)lblMa_kh).TabIndex = 167;
		lblMa_kh.Text = "Mã khách hàng";
		((Control)palMa_nhkh).Controls.Add((Control)(object)txtMa_Nhkh);
		((Control)palMa_nhkh).Controls.Add((Control)(object)lblMa_Nhkh);
		((Control)palMa_nhkh).Controls.Add((Control)(object)lblTen_nhkh);
		Panel obj80 = palMa_nhkh;
		location = new Point(4, 25);
		((Control)obj80).Location = location;
		Panel obj81 = palMa_nhkh;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj81).Margin = margin;
		((Control)palMa_nhkh).Name = "palMa_nhkh";
		Panel obj82 = palMa_nhkh;
		size = new Size(454, 25);
		((Control)obj82).Size = size;
		((Control)palMa_nhkh).TabIndex = 179;
		((Control)palMa_nhkh).Visible = false;
		txtMa_Nhkh.AutoLookup = true;
		txtMa_Nhkh.AutoValid = false;
		((TextBoxBase)txtMa_Nhkh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nhkh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox23 = txtMa_Nhkh;
		location = new Point(96, 3);
		((Control)asTextBox23).Location = location;
		txtMa_Nhkh.LookupCodeName = "MA_NHKH";
		((Control)txtMa_Nhkh).Name = "txtMa_Nhkh";
		txtMa_Nhkh.NameControl = lblTen_nhkh;
		AsTextBox asTextBox24 = txtMa_Nhkh;
		size = new Size(90, 20);
		((Control)asTextBox24).Size = size;
		((Control)txtMa_Nhkh).TabIndex = 143;
		((Control)txtMa_Nhkh).Tag = "MA_NHKH";
		txtMa_Nhkh.UseAutoCompleteSource = true;
		((Control)lblTen_nhkh).Anchor = (AnchorStyles)13;
		Label obj83 = lblTen_nhkh;
		location = new Point(191, 7);
		((Control)obj83).Location = location;
		((Control)lblTen_nhkh).Name = "lblTen_nhkh";
		Label obj84 = lblTen_nhkh;
		size = new Size(230, 13);
		((Control)obj84).Size = size;
		((Control)lblTen_nhkh).TabIndex = 153;
		lblMa_Nhkh.AutoSize = true;
		Label obj85 = lblMa_Nhkh;
		location = new Point(10, 7);
		((Control)obj85).Location = location;
		((Control)lblMa_Nhkh).Name = "lblMa_Nhkh";
		Label obj86 = lblMa_Nhkh;
		size = new Size(53, 13);
		((Control)obj86).Size = size;
		((Control)lblMa_Nhkh).TabIndex = 166;
		lblMa_Nhkh.Text = "Nhóm KH";
		((Control)palMa_hd).Controls.Add((Control)(object)txtMa_hd);
		((Control)palMa_hd).Controls.Add((Control)(object)lblTen_hd);
		((Control)palMa_hd).Controls.Add((Control)(object)lblMa_hd);
		Panel obj87 = palMa_hd;
		location = new Point(4, 50);
		((Control)obj87).Location = location;
		Panel obj88 = palMa_hd;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj88).Margin = margin;
		((Control)palMa_hd).Name = "palMa_hd";
		Panel obj89 = palMa_hd;
		size = new Size(454, 25);
		((Control)obj89).Size = size;
		((Control)palMa_hd).TabIndex = 180;
		((Control)palMa_hd).Visible = false;
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox25 = txtMa_hd;
		location = new Point(96, 3);
		((Control)asTextBox25).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox26 = txtMa_hd;
		size = new Size(90, 20);
		((Control)asTextBox26).Size = size;
		((Control)txtMa_hd).TabIndex = 144;
		((Control)txtMa_hd).Tag = "MA_HD";
		txtMa_hd.UseAutoCompleteSource = true;
		((Control)lblTen_hd).Anchor = (AnchorStyles)13;
		Label obj90 = lblTen_hd;
		location = new Point(191, 7);
		((Control)obj90).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj91 = lblTen_hd;
		size = new Size(230, 13);
		((Control)obj91).Size = size;
		((Control)lblTen_hd).TabIndex = 154;
		lblMa_hd.AutoSize = true;
		Label obj92 = lblMa_hd;
		location = new Point(10, 7);
		((Control)obj92).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj93 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj93).Size = size;
		((Control)lblMa_hd).TabIndex = 165;
		lblMa_hd.Text = "Mã hợp đồng";
		((Control)palMa_nhhd).Controls.Add((Control)(object)txtMa_nhhd);
		((Control)palMa_nhhd).Controls.Add((Control)(object)lblMa_nhhd);
		((Control)palMa_nhhd).Controls.Add((Control)(object)lblTen_Nhhd);
		Panel obj94 = palMa_nhhd;
		location = new Point(4, 75);
		((Control)obj94).Location = location;
		Panel obj95 = palMa_nhhd;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj95).Margin = margin;
		((Control)palMa_nhhd).Name = "palMa_nhhd";
		Panel obj96 = palMa_nhhd;
		size = new Size(454, 25);
		((Control)obj96).Size = size;
		((Control)palMa_nhhd).TabIndex = 181;
		((Control)palMa_nhhd).Visible = false;
		txtMa_nhhd.AutoLookup = true;
		txtMa_nhhd.AutoValid = false;
		((TextBoxBase)txtMa_nhhd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhhd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox27 = txtMa_nhhd;
		location = new Point(96, 4);
		((Control)asTextBox27).Location = location;
		txtMa_nhhd.LookupCodeName = "MA_NHHD";
		((Control)txtMa_nhhd).Name = "txtMa_nhhd";
		txtMa_nhhd.NameControl = lblTen_Nhhd;
		AsTextBox asTextBox28 = txtMa_nhhd;
		size = new Size(90, 20);
		((Control)asTextBox28).Size = size;
		((Control)txtMa_nhhd).TabIndex = 145;
		((Control)txtMa_nhhd).Tag = "MA_NHHD";
		txtMa_nhhd.UseAutoCompleteSource = true;
		((Control)lblTen_Nhhd).Anchor = (AnchorStyles)13;
		Label obj97 = lblTen_Nhhd;
		location = new Point(191, 8);
		((Control)obj97).Location = location;
		((Control)lblTen_Nhhd).Name = "lblTen_Nhhd";
		Label obj98 = lblTen_Nhhd;
		size = new Size(230, 13);
		((Control)obj98).Size = size;
		((Control)lblTen_Nhhd).TabIndex = 155;
		lblMa_nhhd.AutoSize = true;
		Label obj99 = lblMa_nhhd;
		location = new Point(10, 8);
		((Control)obj99).Location = location;
		((Control)lblMa_nhhd).Name = "lblMa_nhhd";
		Label obj100 = lblMa_nhhd;
		size = new Size(84, 13);
		((Control)obj100).Size = size;
		((Control)lblMa_nhhd).TabIndex = 164;
		lblMa_nhhd.Text = "Nhóm hợp đồng";
		((Control)palMa_vt).Controls.Add((Control)(object)txtMa_vt);
		((Control)palMa_vt).Controls.Add((Control)(object)lblTen_vt);
		((Control)palMa_vt).Controls.Add((Control)(object)lblMa_vt);
		Panel obj101 = palMa_vt;
		location = new Point(4, 100);
		((Control)obj101).Location = location;
		Panel obj102 = palMa_vt;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj102).Margin = margin;
		((Control)palMa_vt).Name = "palMa_vt";
		Panel obj103 = palMa_vt;
		size = new Size(454, 25);
		((Control)obj103).Size = size;
		((Control)palMa_vt).TabIndex = 182;
		((Control)palMa_vt).Visible = false;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox29 = txtMa_vt;
		location = new Point(96, 3);
		((Control)asTextBox29).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox30 = txtMa_vt;
		size = new Size(90, 20);
		((Control)asTextBox30).Size = size;
		((Control)txtMa_vt).TabIndex = 146;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		((Control)lblTen_vt).Anchor = (AnchorStyles)13;
		Label obj104 = lblTen_vt;
		location = new Point(192, 7);
		((Control)obj104).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj105 = lblTen_vt;
		size = new Size(230, 13);
		((Control)obj105).Size = size;
		((Control)lblTen_vt).TabIndex = 156;
		lblMa_vt.AutoSize = true;
		Label obj106 = lblMa_vt;
		location = new Point(10, 7);
		((Control)obj106).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj107 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj107).Size = size;
		((Control)lblMa_vt).TabIndex = 163;
		lblMa_vt.Text = "Mã vật tư";
		((Control)palMa_nhvt).Controls.Add((Control)(object)txtMa_nhvt);
		((Control)palMa_nhvt).Controls.Add((Control)(object)lblTen_Nhvt);
		((Control)palMa_nhvt).Controls.Add((Control)(object)lblMa_nhvt);
		Panel obj108 = palMa_nhvt;
		location = new Point(4, 125);
		((Control)obj108).Location = location;
		Panel obj109 = palMa_nhvt;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj109).Margin = margin;
		((Control)palMa_nhvt).Name = "palMa_nhvt";
		Panel obj110 = palMa_nhvt;
		size = new Size(454, 25);
		((Control)obj110).Size = size;
		((Control)palMa_nhvt).TabIndex = 183;
		((Control)palMa_nhvt).Visible = false;
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox31 = txtMa_nhvt;
		location = new Point(96, 4);
		((Control)asTextBox31).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_Nhvt;
		AsTextBox asTextBox32 = txtMa_nhvt;
		size = new Size(90, 20);
		((Control)asTextBox32).Size = size;
		((Control)txtMa_nhvt).TabIndex = 147;
		((Control)txtMa_nhvt).Tag = "MA_NHVT";
		txtMa_nhvt.UseAutoCompleteSource = true;
		((Control)lblTen_Nhvt).Anchor = (AnchorStyles)13;
		Label obj111 = lblTen_Nhvt;
		location = new Point(192, 8);
		((Control)obj111).Location = location;
		((Control)lblTen_Nhvt).Name = "lblTen_Nhvt";
		Label obj112 = lblTen_Nhvt;
		size = new Size(230, 13);
		((Control)obj112).Size = size;
		((Control)lblTen_Nhvt).TabIndex = 157;
		lblMa_nhvt.AutoSize = true;
		Label obj113 = lblMa_nhvt;
		location = new Point(10, 8);
		((Control)obj113).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj114 = lblMa_nhvt;
		size = new Size(65, 13);
		((Control)obj114).Size = size;
		((Control)lblMa_nhvt).TabIndex = 162;
		lblMa_nhvt.Text = "Nhóm vật tư";
		((Control)palMa_bp).Controls.Add((Control)(object)txtMa_bp);
		((Control)palMa_bp).Controls.Add((Control)(object)lblTen_bp);
		((Control)palMa_bp).Controls.Add((Control)(object)lblMa_bp);
		Panel obj115 = palMa_bp;
		location = new Point(4, 150);
		((Control)obj115).Location = location;
		Panel obj116 = palMa_bp;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj116).Margin = margin;
		((Control)palMa_bp).Name = "palMa_bp";
		Panel obj117 = palMa_bp;
		size = new Size(454, 25);
		((Control)obj117).Size = size;
		((Control)palMa_bp).TabIndex = 184;
		((Control)palMa_bp).Visible = false;
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox33 = txtMa_bp;
		location = new Point(96, 3);
		((Control)asTextBox33).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox34 = txtMa_bp;
		size = new Size(90, 20);
		((Control)asTextBox34).Size = size;
		((Control)txtMa_bp).TabIndex = 148;
		((Control)txtMa_bp).Tag = "MA_BP";
		txtMa_bp.UseAutoCompleteSource = true;
		((Control)lblTen_bp).Anchor = (AnchorStyles)13;
		Label obj118 = lblTen_bp;
		location = new Point(191, 7);
		((Control)obj118).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj119 = lblTen_bp;
		size = new Size(230, 13);
		((Control)obj119).Size = size;
		((Control)lblTen_bp).TabIndex = 158;
		lblMa_bp.AutoSize = true;
		Label obj120 = lblMa_bp;
		location = new Point(10, 7);
		((Control)obj120).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj121 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj121).Size = size;
		((Control)lblMa_bp).TabIndex = 161;
		lblMa_bp.Text = "Mã bộ phận";
		((Control)palMa_nvkd).Controls.Add((Control)(object)txtMa_nvkd);
		((Control)palMa_nvkd).Controls.Add((Control)(object)lblTen_nvkd);
		((Control)palMa_nvkd).Controls.Add((Control)(object)lblMa_nvkd);
		Panel obj122 = palMa_nvkd;
		location = new Point(4, 175);
		((Control)obj122).Location = location;
		Panel obj123 = palMa_nvkd;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj123).Margin = margin;
		((Control)palMa_nvkd).Name = "palMa_nvkd";
		Panel obj124 = palMa_nvkd;
		size = new Size(454, 25);
		((Control)obj124).Size = size;
		((Control)palMa_nvkd).TabIndex = 185;
		((Control)palMa_nvkd).Visible = false;
		txtMa_nvkd.AutoLookup = true;
		txtMa_nvkd.AutoValid = false;
		((TextBoxBase)txtMa_nvkd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nvkd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox35 = txtMa_nvkd;
		location = new Point(96, 4);
		((Control)asTextBox35).Location = location;
		txtMa_nvkd.LookupCodeName = "MA_NVKD";
		((Control)txtMa_nvkd).Name = "txtMa_nvkd";
		txtMa_nvkd.NameControl = lblTen_nvkd;
		AsTextBox asTextBox36 = txtMa_nvkd;
		size = new Size(90, 20);
		((Control)asTextBox36).Size = size;
		((Control)txtMa_nvkd).TabIndex = 149;
		((Control)txtMa_nvkd).Tag = "MA_NVKD";
		txtMa_nvkd.UseAutoCompleteSource = true;
		((Control)lblTen_nvkd).Anchor = (AnchorStyles)13;
		Label obj125 = lblTen_nvkd;
		location = new Point(191, 8);
		((Control)obj125).Location = location;
		((Control)lblTen_nvkd).Name = "lblTen_nvkd";
		Label obj126 = lblTen_nvkd;
		size = new Size(230, 13);
		((Control)obj126).Size = size;
		((Control)lblTen_nvkd).TabIndex = 159;
		lblMa_nvkd.AutoSize = true;
		Label obj127 = lblMa_nvkd;
		location = new Point(10, 8);
		((Control)obj127).Location = location;
		((Control)lblMa_nvkd).Name = "lblMa_nvkd";
		Label obj128 = lblMa_nvkd;
		size = new Size(55, 13);
		((Control)obj128).Size = size;
		((Control)lblMa_nvkd).TabIndex = 160;
		lblMa_nvkd.Text = "Mã NVKD";
		lblMa_nvkd.TextAlign = (ContentAlignment)32;
		((Control)palMa_httt).Controls.Add((Control)(object)txtMA_HTTT);
		((Control)palMa_httt).Controls.Add((Control)(object)lblHTTT);
		((Control)palMa_httt).Controls.Add((Control)(object)lblTenHTTT);
		Panel obj129 = palMa_httt;
		location = new Point(4, 200);
		((Control)obj129).Location = location;
		Panel obj130 = palMa_httt;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj130).Margin = margin;
		((Control)palMa_httt).Name = "palMa_httt";
		Panel obj131 = palMa_httt;
		size = new Size(454, 25);
		((Control)obj131).Size = size;
		((Control)palMa_httt).TabIndex = 186;
		((Control)palMa_httt).Visible = false;
		txtMA_HTTT.AutoLookup = true;
		txtMA_HTTT.AutoValid = false;
		((TextBoxBase)txtMA_HTTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_HTTT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox37 = txtMA_HTTT;
		location = new Point(96, 3);
		((Control)asTextBox37).Location = location;
		txtMA_HTTT.LookupCodeName = "MA_HTTT";
		txtMA_HTTT.LookupWhereCondition = "moduleid='so'";
		((Control)txtMA_HTTT).Name = "txtMA_HTTT";
		txtMA_HTTT.NameControl = lblTenHTTT;
		AsTextBox asTextBox38 = txtMA_HTTT;
		size = new Size(90, 20);
		((Control)asTextBox38).Size = size;
		((Control)txtMA_HTTT).TabIndex = 150;
		((Control)txtMA_HTTT).Tag = "MA_HTTT";
		txtMA_HTTT.UseAutoCompleteSource = true;
		((Control)lblTenHTTT).Anchor = (AnchorStyles)13;
		Label obj132 = lblTenHTTT;
		location = new Point(191, 7);
		((Control)obj132).Location = location;
		((Control)lblTenHTTT).Name = "lblTenHTTT";
		Label obj133 = lblTenHTTT;
		size = new Size(230, 13);
		((Control)obj133).Size = size;
		((Control)lblTenHTTT).TabIndex = 168;
		lblHTTT.AutoSize = true;
		Label obj134 = lblHTTT;
		location = new Point(10, 7);
		((Control)obj134).Location = location;
		((Control)lblHTTT).Name = "lblHTTT";
		Label obj135 = lblHTTT;
		size = new Size(70, 13);
		((Control)obj135).Size = size;
		((Control)lblHTTT).TabIndex = 169;
		lblHTTT.Text = "Hình thức TT";
		((Control)palMa_tt).Controls.Add((Control)(object)txtMA_DKTT);
		((Control)palMa_tt).Controls.Add((Control)(object)lblTen_TT);
		((Control)palMa_tt).Controls.Add((Control)(object)lblDkTT);
		Panel obj136 = palMa_tt;
		location = new Point(4, 225);
		((Control)obj136).Location = location;
		Panel obj137 = palMa_tt;
		((Padding)(ref margin))._002Ector(0);
		((Control)obj137).Margin = margin;
		((Control)palMa_tt).Name = "palMa_tt";
		Panel obj138 = palMa_tt;
		size = new Size(454, 25);
		((Control)obj138).Size = size;
		((Control)palMa_tt).TabIndex = 187;
		((Control)palMa_tt).Visible = false;
		txtMA_DKTT.AutoLookup = true;
		txtMA_DKTT.AutoValid = false;
		((TextBoxBase)txtMA_DKTT).BackColor = SystemColors.Info;
		((TextBox)txtMA_DKTT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox39 = txtMA_DKTT;
		location = new Point(96, 4);
		((Control)asTextBox39).Location = location;
		txtMA_DKTT.LookupCodeName = "MA_TT";
		((Control)txtMA_DKTT).Name = "txtMA_DKTT";
		txtMA_DKTT.NameControl = lblTen_TT;
		AsTextBox asTextBox40 = txtMA_DKTT;
		size = new Size(90, 20);
		((Control)asTextBox40).Size = size;
		((Control)txtMA_DKTT).TabIndex = 151;
		((Control)txtMA_DKTT).Tag = "MA_TT";
		txtMA_DKTT.UseAutoCompleteSource = true;
		((Control)lblTen_TT).Anchor = (AnchorStyles)13;
		Label obj139 = lblTen_TT;
		location = new Point(191, 8);
		((Control)obj139).Location = location;
		((Control)lblTen_TT).Name = "lblTen_TT";
		Label obj140 = lblTen_TT;
		size = new Size(230, 13);
		((Control)obj140).Size = size;
		((Control)lblTen_TT).TabIndex = 170;
		lblDkTT.AutoSize = true;
		Label obj141 = lblDkTT;
		location = new Point(10, 8);
		((Control)obj141).Location = location;
		((Control)lblDkTT).Name = "lblDkTT";
		Label obj142 = lblDkTT;
		size = new Size(79, 13);
		((Control)obj142).Size = size;
		((Control)lblDkTT).TabIndex = 171;
		lblDkTT.Text = "Điều khoản TT";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(963, 577);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)pFilter);
		((Control)this).Name = "Form3";
		((Form)this).Text = "Form3";
		((Control)pFilter).ResumeLayout(false);
		((Control)palMa_plkh1).ResumeLayout(false);
		((Control)palMa_plkh1).PerformLayout();
		((Control)palMa_plkh2).ResumeLayout(false);
		((Control)palMa_plkh2).PerformLayout();
		((Control)palMa_plkh3).ResumeLayout(false);
		((Control)palMa_plkh3).PerformLayout();
		((Control)palMa_plvt1).ResumeLayout(false);
		((Control)palMa_plvt1).PerformLayout();
		((Control)palMa_plvt2).ResumeLayout(false);
		((Control)palMa_plvt2).PerformLayout();
		((Control)palMa_plvt3).ResumeLayout(false);
		((Control)palMa_plvt3).PerformLayout();
		((Control)palMa_spct).ResumeLayout(false);
		((Control)palMa_spct).PerformLayout();
		((Control)palMa_kho).ResumeLayout(false);
		((Control)palMa_kho).PerformLayout();
		((Control)palMa_vitri).ResumeLayout(false);
		((Control)palMa_vitri).PerformLayout();
		((Control)palMa_lo).ResumeLayout(false);
		((Control)palMa_lo).PerformLayout();
		((Control)palMa_kh).ResumeLayout(false);
		((Control)palMa_kh).PerformLayout();
		((Control)palMa_nhkh).ResumeLayout(false);
		((Control)palMa_nhkh).PerformLayout();
		((Control)palMa_hd).ResumeLayout(false);
		((Control)palMa_hd).PerformLayout();
		((Control)palMa_nhhd).ResumeLayout(false);
		((Control)palMa_nhhd).PerformLayout();
		((Control)palMa_vt).ResumeLayout(false);
		((Control)palMa_vt).PerformLayout();
		((Control)palMa_nhvt).ResumeLayout(false);
		((Control)palMa_nhvt).PerformLayout();
		((Control)palMa_bp).ResumeLayout(false);
		((Control)palMa_bp).PerformLayout();
		((Control)palMa_nvkd).ResumeLayout(false);
		((Control)palMa_nvkd).PerformLayout();
		((Control)palMa_httt).ResumeLayout(false);
		((Control)palMa_httt).PerformLayout();
		((Control)palMa_tt).ResumeLayout(false);
		((Control)palMa_tt).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
