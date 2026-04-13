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
public class frmSORptBCPT03 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

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

	[AccessedThroughProperty("lblPLKh3")]
	private Label _lblPLKh3;

	[AccessedThroughProperty("txtMa_plkh3")]
	private AsTextBox _txtMa_plkh3;

	[AccessedThroughProperty("lblTen_plkh3")]
	private Label _lblTen_plkh3;

	[AccessedThroughProperty("lblPLKh2")]
	private Label _lblPLKh2;

	[AccessedThroughProperty("txtMa_plkh2")]
	private AsTextBox _txtMa_plkh2;

	[AccessedThroughProperty("lblTen_plkh2")]
	private Label _lblTen_plkh2;

	[AccessedThroughProperty("lblPLKh1")]
	private Label _lblPLKh1;

	[AccessedThroughProperty("txtMa_plkh1")]
	private AsTextBox _txtMa_plkh1;

	[AccessedThroughProperty("lblTen_plkh1")]
	private Label _lblTen_plkh1;

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

	[AccessedThroughProperty("lblPLVt3")]
	private Label _lblPLVt3;

	[AccessedThroughProperty("txtMa_plvt3")]
	private AsTextBox _txtMa_plvt3;

	[AccessedThroughProperty("lblTen_plvt3")]
	private Label _lblTen_plvt3;

	[AccessedThroughProperty("lblPLVt2")]
	private Label _lblPLVt2;

	[AccessedThroughProperty("txtMa_plvt2")]
	private AsTextBox _txtMa_plvt2;

	[AccessedThroughProperty("lblTen_plvt2")]
	private Label _lblTen_plvt2;

	[AccessedThroughProperty("lblPLVt1")]
	private Label _lblPLVt1;

	[AccessedThroughProperty("txtMa_plvt1")]
	private AsTextBox _txtMa_plvt1;

	[AccessedThroughProperty("lblTen_plvt1")]
	private Label _lblTen_plvt1;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

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

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

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

	[AccessedThroughProperty("txtTK_QL")]
	private AsTextBox _txtTK_QL;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtTk_BH")]
	private AsTextBox _txtTk_BH;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("rbCP_No")]
	private RadioButton _rbCP_No;

	[AccessedThroughProperty("rbCP_CO")]
	private RadioButton _rbCP_CO;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("rbDT_No")]
	private RadioButton _rbDT_No;

	[AccessedThroughProperty("rbDS_Co")]
	private RadioButton _rbDS_Co;

	[AccessedThroughProperty("chkNc_QL")]
	private CheckBox _chkNc_QL;

	[AccessedThroughProperty("chkNC_BH")]
	private CheckBox _chkNC_BH;

	[AccessedThroughProperty("txtTK_QKDN_DU")]
	private AsTextBox _txtTK_QKDN_DU;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtTK_CPBH_DU")]
	private AsTextBox _txtTK_CPBH_DU;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

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

	internal virtual Label lblPLKh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPLKh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPLKh3 = value;
		}
	}

	internal virtual AsTextBox txtMa_plkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_plkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_plkh3 = value;
		}
	}

	internal virtual Label lblTen_plkh3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_plkh3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_plkh3 = value;
		}
	}

	internal virtual Label lblPLKh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPLKh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPLKh2 = value;
		}
	}

	internal virtual AsTextBox txtMa_plkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_plkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_plkh2 = value;
		}
	}

	internal virtual Label lblTen_plkh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_plkh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_plkh2 = value;
		}
	}

	internal virtual Label lblPLKh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPLKh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPLKh1 = value;
		}
	}

	internal virtual AsTextBox txtMa_plkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_plkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_plkh1 = value;
		}
	}

	internal virtual Label lblTen_plkh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_plkh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_plkh1 = value;
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

	internal virtual AsTextBox txtTK_QL
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_QL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_QL = value;
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

	internal virtual AsTextBox txtTk_BH
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_BH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_BH = value;
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

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual RadioButton rbCP_No
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbCP_No;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbCP_No_CheckedChanged;
			if (_rbCP_No != null)
			{
				_rbCP_No.CheckedChanged -= eventHandler;
			}
			_rbCP_No = value;
			if (_rbCP_No != null)
			{
				_rbCP_No.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton rbCP_CO
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbCP_CO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rbCP_CO = value;
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual RadioButton rbDT_No
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbDT_No;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbDT_No_CheckedChanged;
			if (_rbDT_No != null)
			{
				_rbDT_No.CheckedChanged -= eventHandler;
			}
			_rbDT_No = value;
			if (_rbDT_No != null)
			{
				_rbDT_No.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton rbDS_Co
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbDS_Co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rbDS_Co = value;
		}
	}

	internal virtual CheckBox chkNc_QL
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkNc_QL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkNc_QL = value;
		}
	}

	internal virtual CheckBox chkNC_BH
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkNC_BH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkNC_BH = value;
		}
	}

	internal virtual AsTextBox txtTK_QKDN_DU
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_QKDN_DU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_QKDN_DU = value;
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

	internal virtual AsTextBox txtTK_CPBH_DU
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_CPBH_DU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_CPBH_DU = value;
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

	public frmSORptBCPT03(object MenuId)
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
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
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
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_3f15: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f1f: Expected O, but got Unknown
		lblMa_nhhd = new Label();
		txtMa_nhhd = new AsTextBox();
		lblTen_nhhd = new Label();
		lblTen_Hd = new Label();
		txtMa_hd = new AsTextBox();
		lblMa_hd = new Label();
		lblPLKh3 = new Label();
		txtMa_plkh3 = new AsTextBox();
		lblTen_plkh3 = new Label();
		lblPLKh2 = new Label();
		txtMa_plkh2 = new AsTextBox();
		lblTen_plkh2 = new Label();
		lblPLKh1 = new Label();
		txtMa_plkh1 = new AsTextBox();
		lblTen_plkh1 = new Label();
		lblMa_NhKh = new Label();
		txtMa_NhKh = new AsTextBox();
		lblTen_NhKh = new Label();
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblPLVt3 = new Label();
		txtMa_plvt3 = new AsTextBox();
		lblTen_plvt3 = new Label();
		lblPLVt2 = new Label();
		txtMa_plvt2 = new AsTextBox();
		lblTen_plvt2 = new Label();
		lblPLVt1 = new Label();
		txtMa_plvt1 = new AsTextBox();
		lblTen_plvt1 = new Label();
		lblTen_Tk = new Label();
		lblMa_nhvt = new Label();
		txtMa_nhvt = new AsTextBox();
		lblTen_nhvt = new Label();
		lblTen_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		lblTen_kho = new Label();
		txtMa_kho = new AsTextBox();
		lblMa_kho = new Label();
		ChkTra_lai = new AsCheckBox();
		lblTru = new Label();
		ChkTra_ck = new AsCheckBox();
		ChkKhuyen_mai = new AsCheckBox();
		ChkHang_ban = new AsCheckBox();
		lblLoai_hang = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_bp = new Label();
		lblTen_Nvkd = new Label();
		txtMa_Nvkd = new AsTextBox();
		lblMa_nvkd = new Label();
		txtTK_QL = new AsTextBox();
		Label2 = new Label();
		txtTk_BH = new AsTextBox();
		Label4 = new Label();
		Panel2 = new Panel();
		rbCP_No = new RadioButton();
		rbCP_CO = new RadioButton();
		Panel1 = new Panel();
		rbDT_No = new RadioButton();
		rbDS_Co = new RadioButton();
		chkNc_QL = new CheckBox();
		chkNC_BH = new CheckBox();
		txtTK_CPBH_DU = new AsTextBox();
		Label1 = new Label();
		txtTK_QKDN_DU = new AsTextBox();
		Label3 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(948, 619);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)txtTK_QKDN_DU);
		((Control)tabFilter).Controls.Add((Control)(object)Label3);
		((Control)tabFilter).Controls.Add((Control)(object)txtTK_CPBH_DU);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)Panel2);
		((Control)tabFilter).Controls.Add((Control)(object)Panel1);
		((Control)tabFilter).Controls.Add((Control)(object)chkNc_QL);
		((Control)tabFilter).Controls.Add((Control)(object)chkNC_BH);
		((Control)tabFilter).Controls.Add((Control)(object)txtTK_QL);
		((Control)tabFilter).Controls.Add((Control)(object)Label2);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk_BH);
		((Control)tabFilter).Controls.Add((Control)(object)Label4);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)ChkTra_lai);
		((Control)tabFilter).Controls.Add((Control)(object)lblTru);
		((Control)tabFilter).Controls.Add((Control)(object)ChkTra_ck);
		((Control)tabFilter).Controls.Add((Control)(object)ChkKhuyen_mai);
		((Control)tabFilter).Controls.Add((Control)(object)ChkHang_ban);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoai_hang);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLVt3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLVt2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLVt1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhvt);
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
		((Control)tabFilter).Controls.Add((Control)(object)lblPLKh3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLKh2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLKh1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_NhKh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_NhKh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_NhKh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Kh);
		TabPage obj = tabFilter;
		size = new Size(940, 590);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_NhKh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_NhKh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_NhKh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLKh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLKh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLKh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhhd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLVt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLVt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLVt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoai_hang, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkHang_ban, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkKhuyen_mai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkTra_ck, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTru, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkTra_lai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk_BH, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK_QL, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)chkNC_BH, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)chkNc_QL, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Panel1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Panel2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK_CPBH_DU, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK_QKDN_DU, 0);
		Label obj2 = lbl2;
		Point location = new Point(327, 65);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 4;
		Button obj3 = cmdExcel;
		location = new Point(748, 471);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(349, 61);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(667, 483);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(503, 10);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 31;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(254, 61);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(158, 61);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(19, 65);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(158, 12);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 29;
		Label obj9 = lblMau_bc;
		location = new Point(19, 15);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(158, 469);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 26;
		Label obj10 = lblMauBC;
		location = new Point(203, 473);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 32;
		RadioButton obj11 = optVND;
		location = new Point(290, 471);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 27;
		RadioButton obj12 = optNt;
		location = new Point(344, 471);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 35;
		Label obj13 = lblMa_nt;
		location = new Point(19, 471);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(19, 500);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 19;
		Label obj15 = lblTieu_de;
		location = new Point(19, 41);
		((Control)obj15).Location = location;
		TextBox obj16 = txtTieu_De;
		location = new Point(158, 37);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 30;
		TabPage obj17 = tabGrid;
		size = new Size(940, 590);
		((Control)obj17).Size = size;
		lblMa_nhhd.AutoSize = true;
		lblMa_nhhd.ImeMode = (ImeMode)0;
		Label obj18 = lblMa_nhhd;
		location = new Point(19, 210);
		((Control)obj18).Location = location;
		((Control)lblMa_nhhd).Name = "lblMa_nhhd";
		Label obj19 = lblMa_nhhd;
		size = new Size(84, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_nhhd).TabIndex = 1035;
		lblMa_nhhd.Text = "Nhóm hợp đồng";
		txtMa_nhhd.AutoLookup = true;
		txtMa_nhhd.AutoValid = false;
		((TextBoxBase)txtMa_nhhd).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhhd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_nhhd;
		location = new Point(158, 206);
		((Control)asTextBox2).Location = location;
		txtMa_nhhd.LookupCodeName = "MA_NHHD";
		((TextBoxBase)txtMa_nhhd).MaxLength = 8;
		((Control)txtMa_nhhd).Name = "txtMa_nhhd";
		txtMa_nhhd.NameControl = lblTen_nhhd;
		AsTextBox asTextBox3 = txtMa_nhhd;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_nhhd).TabIndex = 8;
		((Control)txtMa_nhhd).Tag = "MA_NHHD";
		txtMa_nhhd.UseAutoCompleteSource = true;
		lblTen_nhhd.ImeMode = (ImeMode)0;
		Label obj20 = lblTen_nhhd;
		location = new Point(254, 210);
		((Control)obj20).Location = location;
		((Control)lblTen_nhhd).Name = "lblTen_nhhd";
		Label obj21 = lblTen_nhhd;
		size = new Size(485, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_nhhd).TabIndex = 1036;
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj22 = lblTen_Hd;
		location = new Point(254, 186);
		((Control)obj22).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj23 = lblTen_Hd;
		size = new Size(485, 13);
		((Control)obj23).Size = size;
		((Control)lblTen_Hd).TabIndex = 1034;
		((TextBox)txtMa_hd).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_hd;
		location = new Point(158, 182);
		((Control)asTextBox4).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_Hd;
		AsTextBox asTextBox5 = txtMa_hd;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_hd).TabIndex = 7;
		((Control)txtMa_hd).Tag = "MA_HD";
		txtMa_hd.UseAutoCompleteSource = true;
		lblMa_hd.AutoSize = true;
		lblMa_hd.ImeMode = (ImeMode)0;
		Label obj24 = lblMa_hd;
		location = new Point(19, 186);
		((Control)obj24).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj25 = lblMa_hd;
		size = new Size(55, 13);
		((Control)obj25).Size = size;
		((Control)lblMa_hd).TabIndex = 1033;
		lblMa_hd.Text = "Hợp đồng";
		lblPLKh3.AutoSize = true;
		lblPLKh3.ImeMode = (ImeMode)0;
		Label obj26 = lblPLKh3;
		location = new Point(19, 162);
		((Control)obj26).Location = location;
		((Control)lblPLKh3).Name = "lblPLKh3";
		Label obj27 = lblPLKh3;
		size = new Size(46, 13);
		((Control)obj27).Size = size;
		((Control)lblPLKh3).TabIndex = 1031;
		lblPLKh3.Text = "P.Loại 3";
		txtMa_plkh3.AutoLookup = true;
		txtMa_plkh3.AutoValid = false;
		((TextBoxBase)txtMa_plkh3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_plkh3;
		location = new Point(158, 158);
		((Control)asTextBox6).Location = location;
		txtMa_plkh3.LookupCodeName = "MA_PLKH";
		txtMa_plkh3.LookupWhereCondition = "loai='3'";
		((TextBoxBase)txtMa_plkh3).MaxLength = 8;
		((Control)txtMa_plkh3).Name = "txtMa_plkh3";
		txtMa_plkh3.NameControl = lblTen_plkh3;
		AsTextBox asTextBox7 = txtMa_plkh3;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_plkh3).TabIndex = 6;
		((Control)txtMa_plkh3).Tag = "MA_PLKH3";
		txtMa_plkh3.UseAutoCompleteSource = true;
		lblTen_plkh3.ImeMode = (ImeMode)0;
		Label obj28 = lblTen_plkh3;
		location = new Point(254, 162);
		((Control)obj28).Location = location;
		((Control)lblTen_plkh3).Name = "lblTen_plkh3";
		Label obj29 = lblTen_plkh3;
		size = new Size(485, 13);
		((Control)obj29).Size = size;
		((Control)lblTen_plkh3).TabIndex = 1032;
		lblPLKh2.AutoSize = true;
		lblPLKh2.ImeMode = (ImeMode)0;
		Label obj30 = lblPLKh2;
		location = new Point(19, 138);
		((Control)obj30).Location = location;
		((Control)lblPLKh2).Name = "lblPLKh2";
		Label obj31 = lblPLKh2;
		size = new Size(46, 13);
		((Control)obj31).Size = size;
		((Control)lblPLKh2).TabIndex = 1029;
		lblPLKh2.Text = "P.Loại 2";
		txtMa_plkh2.AutoLookup = true;
		txtMa_plkh2.AutoValid = false;
		((TextBoxBase)txtMa_plkh2).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_plkh2;
		location = new Point(158, 134);
		((Control)asTextBox8).Location = location;
		txtMa_plkh2.LookupCodeName = "MA_PLKH";
		txtMa_plkh2.LookupWhereCondition = "loai='2'";
		((TextBoxBase)txtMa_plkh2).MaxLength = 8;
		((Control)txtMa_plkh2).Name = "txtMa_plkh2";
		txtMa_plkh2.NameControl = lblTen_plkh2;
		AsTextBox asTextBox9 = txtMa_plkh2;
		size = new Size(90, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_plkh2).TabIndex = 5;
		((Control)txtMa_plkh2).Tag = "MA_PLKH2";
		txtMa_plkh2.UseAutoCompleteSource = true;
		lblTen_plkh2.ImeMode = (ImeMode)0;
		Label obj32 = lblTen_plkh2;
		location = new Point(254, 138);
		((Control)obj32).Location = location;
		((Control)lblTen_plkh2).Name = "lblTen_plkh2";
		Label obj33 = lblTen_plkh2;
		size = new Size(485, 13);
		((Control)obj33).Size = size;
		((Control)lblTen_plkh2).TabIndex = 1030;
		lblPLKh1.AutoSize = true;
		lblPLKh1.ImeMode = (ImeMode)0;
		Label obj34 = lblPLKh1;
		location = new Point(19, 114);
		((Control)obj34).Location = location;
		((Control)lblPLKh1).Name = "lblPLKh1";
		Label obj35 = lblPLKh1;
		size = new Size(46, 13);
		((Control)obj35).Size = size;
		((Control)lblPLKh1).TabIndex = 1027;
		lblPLKh1.Text = "P.Loại 1";
		txtMa_plkh1.AutoLookup = true;
		txtMa_plkh1.AutoValid = false;
		((TextBoxBase)txtMa_plkh1).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_plkh1;
		location = new Point(158, 110);
		((Control)asTextBox10).Location = location;
		txtMa_plkh1.LookupCodeName = "MA_PLKH";
		txtMa_plkh1.LookupWhereCondition = "loai='1'";
		((TextBoxBase)txtMa_plkh1).MaxLength = 8;
		((Control)txtMa_plkh1).Name = "txtMa_plkh1";
		txtMa_plkh1.NameControl = lblTen_plkh1;
		AsTextBox asTextBox11 = txtMa_plkh1;
		size = new Size(90, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_plkh1).TabIndex = 4;
		((Control)txtMa_plkh1).Tag = "MA_PLKH1";
		txtMa_plkh1.UseAutoCompleteSource = true;
		lblTen_plkh1.ImeMode = (ImeMode)0;
		Label obj36 = lblTen_plkh1;
		location = new Point(254, 114);
		((Control)obj36).Location = location;
		((Control)lblTen_plkh1).Name = "lblTen_plkh1";
		Label obj37 = lblTen_plkh1;
		size = new Size(485, 13);
		((Control)obj37).Size = size;
		((Control)lblTen_plkh1).TabIndex = 1028;
		lblMa_NhKh.AutoSize = true;
		((Control)lblMa_NhKh).Enabled = false;
		lblMa_NhKh.ImeMode = (ImeMode)0;
		Label obj38 = lblMa_NhKh;
		location = new Point(462, 472);
		((Control)obj38).Location = location;
		((Control)lblMa_NhKh).Name = "lblMa_NhKh";
		Label obj39 = lblMa_NhKh;
		size = new Size(53, 13);
		((Control)obj39).Size = size;
		((Control)lblMa_NhKh).TabIndex = 1024;
		lblMa_NhKh.Text = "Nhóm KH";
		((Control)lblMa_NhKh).Visible = false;
		txtMa_NhKh.AutoLookup = true;
		txtMa_NhKh.AutoValid = false;
		((TextBoxBase)txtMa_NhKh).BackColor = SystemColors.Info;
		((TextBox)txtMa_NhKh).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_NhKh).Enabled = false;
		AsTextBox asTextBox12 = txtMa_NhKh;
		location = new Point(550, 466);
		((Control)asTextBox12).Location = location;
		txtMa_NhKh.LookupCodeName = "MA_NHKH";
		((TextBoxBase)txtMa_NhKh).MaxLength = 8;
		((Control)txtMa_NhKh).Name = "txtMa_NhKh";
		txtMa_NhKh.NameControl = lblTen_NhKh;
		AsTextBox asTextBox13 = txtMa_NhKh;
		size = new Size(90, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_NhKh).TabIndex = 2;
		((Control)txtMa_NhKh).Tag = "MA_NHKH";
		txtMa_NhKh.UseAutoCompleteSource = true;
		((Control)txtMa_NhKh).Visible = false;
		((Control)lblTen_NhKh).Enabled = false;
		lblTen_NhKh.ImeMode = (ImeMode)0;
		Label obj40 = lblTen_NhKh;
		location = new Point(646, 468);
		((Control)obj40).Location = location;
		((Control)lblTen_NhKh).Name = "lblTen_NhKh";
		Label obj41 = lblTen_NhKh;
		size = new Size(323, 13);
		((Control)obj41).Size = size;
		((Control)lblTen_NhKh).TabIndex = 1026;
		((Control)lblTen_NhKh).Visible = false;
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj42 = lblTen_Kh;
		location = new Point(254, 90);
		((Control)obj42).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj43 = lblTen_Kh;
		size = new Size(485, 13);
		((Control)obj43).Size = size;
		((Control)lblTen_Kh).TabIndex = 1021;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = false;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_Kh;
		location = new Point(158, 86);
		((Control)asTextBox14).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		txtMa_Kh.LookupWhereCondition = " 1=1";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		AsTextBox asTextBox15 = txtMa_Kh;
		size = new Size(90, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_Kh).TabIndex = 3;
		((Control)txtMa_Kh).Tag = "MA_KH";
		txtMa_Kh.UseAutoCompleteSource = true;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj44 = lblMa_Kh;
		location = new Point(19, 90);
		((Control)obj44).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj45 = lblMa_Kh;
		size = new Size(65, 13);
		((Control)obj45).Size = size;
		((Control)lblMa_Kh).TabIndex = 1019;
		lblMa_Kh.Text = "Khách hàng";
		lblPLVt3.AutoSize = true;
		((Control)lblPLVt3).Enabled = false;
		lblPLVt3.ImeMode = (ImeMode)0;
		Label obj46 = lblPLVt3;
		location = new Point(579, 299);
		((Control)obj46).Location = location;
		((Control)lblPLVt3).Name = "lblPLVt3";
		Label obj47 = lblPLVt3;
		size = new Size(60, 13);
		((Control)obj47).Size = size;
		((Control)lblPLVt3).TabIndex = 1051;
		lblPLVt3.Text = "P.Loại VT3";
		((Control)lblPLVt3).Visible = false;
		txtMa_plvt3.AutoLookup = true;
		txtMa_plvt3.AutoValid = false;
		((TextBoxBase)txtMa_plvt3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt3).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt3).Enabled = false;
		AsTextBox asTextBox16 = txtMa_plvt3;
		location = new Point(649, 295);
		((Control)asTextBox16).Location = location;
		txtMa_plvt3.LookupCodeName = "MA_PLVT";
		txtMa_plvt3.LookupWhereCondition = "loai='3'";
		((TextBoxBase)txtMa_plvt3).MaxLength = 8;
		((Control)txtMa_plvt3).Name = "txtMa_plvt3";
		txtMa_plvt3.NameControl = lblTen_plvt3;
		AsTextBox asTextBox17 = txtMa_plvt3;
		size = new Size(90, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtMa_plvt3).TabIndex = 25;
		((Control)txtMa_plvt3).Tag = "MA_PLVT3";
		txtMa_plvt3.UseAutoCompleteSource = true;
		((Control)txtMa_plvt3).Visible = false;
		((Control)lblTen_plvt3).Enabled = false;
		lblTen_plvt3.ImeMode = (ImeMode)0;
		Label obj48 = lblTen_plvt3;
		location = new Point(745, 290);
		((Control)obj48).Location = location;
		((Control)lblTen_plvt3).Name = "lblTen_plvt3";
		Label obj49 = lblTen_plvt3;
		size = new Size(323, 13);
		((Control)obj49).Size = size;
		((Control)lblTen_plvt3).TabIndex = 1052;
		((Control)lblTen_plvt3).Visible = false;
		lblPLVt2.AutoSize = true;
		((Control)lblPLVt2).Enabled = false;
		lblPLVt2.ImeMode = (ImeMode)0;
		Label obj50 = lblPLVt2;
		location = new Point(579, 270);
		((Control)obj50).Location = location;
		((Control)lblPLVt2).Name = "lblPLVt2";
		Label obj51 = lblPLVt2;
		size = new Size(60, 13);
		((Control)obj51).Size = size;
		((Control)lblPLVt2).TabIndex = 1048;
		lblPLVt2.Text = "P.Loại VT2";
		((Control)lblPLVt2).Visible = false;
		txtMa_plvt2.AutoLookup = true;
		txtMa_plvt2.AutoValid = false;
		((TextBoxBase)txtMa_plvt2).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt2).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt2).Enabled = false;
		AsTextBox asTextBox18 = txtMa_plvt2;
		location = new Point(649, 266);
		((Control)asTextBox18).Location = location;
		txtMa_plvt2.LookupCodeName = "MA_PLVT";
		txtMa_plvt2.LookupWhereCondition = "loai='2'";
		((TextBoxBase)txtMa_plvt2).MaxLength = 8;
		((Control)txtMa_plvt2).Name = "txtMa_plvt2";
		txtMa_plvt2.NameControl = lblTen_plvt2;
		AsTextBox asTextBox19 = txtMa_plvt2;
		size = new Size(90, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtMa_plvt2).TabIndex = 24;
		((Control)txtMa_plvt2).Tag = "MA_PLVT2";
		txtMa_plvt2.UseAutoCompleteSource = true;
		((Control)txtMa_plvt2).Visible = false;
		((Control)lblTen_plvt2).Enabled = false;
		lblTen_plvt2.ImeMode = (ImeMode)0;
		Label obj52 = lblTen_plvt2;
		location = new Point(745, 264);
		((Control)obj52).Location = location;
		((Control)lblTen_plvt2).Name = "lblTen_plvt2";
		Label obj53 = lblTen_plvt2;
		size = new Size(323, 13);
		((Control)obj53).Size = size;
		((Control)lblTen_plvt2).TabIndex = 1049;
		((Control)lblTen_plvt2).Visible = false;
		lblPLVt1.AutoSize = true;
		((Control)lblPLVt1).Enabled = false;
		lblPLVt1.ImeMode = (ImeMode)0;
		Label obj54 = lblPLVt1;
		location = new Point(579, 272);
		((Control)obj54).Location = location;
		((Control)lblPLVt1).Name = "lblPLVt1";
		Label obj55 = lblPLVt1;
		size = new Size(60, 13);
		((Control)obj55).Size = size;
		((Control)lblPLVt1).TabIndex = 1046;
		lblPLVt1.Text = "P.Loại VT1";
		((Control)lblPLVt1).Visible = false;
		txtMa_plvt1.AutoLookup = true;
		txtMa_plvt1.AutoValid = false;
		((TextBoxBase)txtMa_plvt1).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt1).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt1).Enabled = false;
		AsTextBox asTextBox20 = txtMa_plvt1;
		location = new Point(649, 271);
		((Control)asTextBox20).Location = location;
		txtMa_plvt1.LookupCodeName = "MA_PLVT";
		txtMa_plvt1.LookupWhereCondition = "loai='1'";
		((TextBoxBase)txtMa_plvt1).MaxLength = 8;
		((Control)txtMa_plvt1).Name = "txtMa_plvt1";
		txtMa_plvt1.NameControl = lblTen_plvt1;
		AsTextBox asTextBox21 = txtMa_plvt1;
		size = new Size(90, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMa_plvt1).TabIndex = 23;
		((Control)txtMa_plvt1).Tag = "MA_PLVT1";
		txtMa_plvt1.UseAutoCompleteSource = true;
		((Control)txtMa_plvt1).Visible = false;
		((Control)lblTen_plvt1).Enabled = false;
		lblTen_plvt1.ImeMode = (ImeMode)0;
		Label obj56 = lblTen_plvt1;
		location = new Point(745, 274);
		((Control)obj56).Location = location;
		((Control)lblTen_plvt1).Name = "lblTen_plvt1";
		Label obj57 = lblTen_plvt1;
		size = new Size(323, 13);
		((Control)obj57).Size = size;
		((Control)lblTen_plvt1).TabIndex = 1047;
		((Control)lblTen_plvt1).Visible = false;
		((Control)lblTen_Tk).Enabled = false;
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj58 = lblTen_Tk;
		location = new Point(763, 265);
		((Control)obj58).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj59 = lblTen_Tk;
		size = new Size(323, 13);
		((Control)obj59).Size = size;
		((Control)lblTen_Tk).TabIndex = 1050;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Tk).Visible = false;
		lblMa_nhvt.AutoSize = true;
		lblMa_nhvt.ImeMode = (ImeMode)0;
		Label obj60 = lblMa_nhvt;
		location = new Point(19, 258);
		((Control)obj60).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj61 = lblMa_nhvt;
		size = new Size(65, 13);
		((Control)obj61).Size = size;
		((Control)lblMa_nhvt).TabIndex = 1044;
		lblMa_nhvt.Text = "Nhóm vật tư";
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox22 = txtMa_nhvt;
		location = new Point(158, 254);
		((Control)asTextBox22).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((TextBoxBase)txtMa_nhvt).MaxLength = 8;
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_nhvt;
		AsTextBox asTextBox23 = txtMa_nhvt;
		size = new Size(90, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMa_nhvt).TabIndex = 10;
		((Control)txtMa_nhvt).Tag = "MA_NHVT";
		txtMa_nhvt.UseAutoCompleteSource = true;
		lblTen_nhvt.ImeMode = (ImeMode)0;
		Label obj62 = lblTen_nhvt;
		location = new Point(254, 258);
		((Control)obj62).Location = location;
		((Control)lblTen_nhvt).Name = "lblTen_nhvt";
		Label obj63 = lblTen_nhvt;
		size = new Size(485, 13);
		((Control)obj63).Size = size;
		((Control)lblTen_nhvt).TabIndex = 1045;
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj64 = lblTen_vt;
		location = new Point(254, 234);
		((Control)obj64).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj65 = lblTen_vt;
		size = new Size(485, 13);
		((Control)obj65).Size = size;
		((Control)lblTen_vt).TabIndex = 1043;
		((TextBox)txtMa_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox24 = txtMa_vt;
		location = new Point(158, 230);
		((Control)asTextBox24).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox25 = txtMa_vt;
		size = new Size(90, 20);
		((Control)asTextBox25).Size = size;
		((Control)txtMa_vt).TabIndex = 9;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_vt.AutoSize = true;
		lblMa_vt.ImeMode = (ImeMode)0;
		Label obj66 = lblMa_vt;
		location = new Point(19, 234);
		((Control)obj66).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj67 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj67).Size = size;
		((Control)lblMa_vt).TabIndex = 1042;
		lblMa_vt.Text = "Mã vật tư";
		lblTen_kho.ImeMode = (ImeMode)0;
		Label obj68 = lblTen_kho;
		location = new Point(254, 282);
		((Control)obj68).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj69 = lblTen_kho;
		size = new Size(485, 13);
		((Control)obj69).Size = size;
		((Control)lblTen_kho).TabIndex = 1055;
		((TextBox)txtMa_kho).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox26 = txtMa_kho;
		location = new Point(158, 278);
		((Control)asTextBox26).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox27 = txtMa_kho;
		size = new Size(90, 20);
		((Control)asTextBox27).Size = size;
		((Control)txtMa_kho).TabIndex = 11;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		lblMa_kho.AutoSize = true;
		lblMa_kho.ImeMode = (ImeMode)0;
		Label obj70 = lblMa_kho;
		location = new Point(19, 282);
		((Control)obj70).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj71 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj71).Size = size;
		((Control)lblMa_kho).TabIndex = 1054;
		lblMa_kho.Text = "Mã kho";
		((ButtonBase)ChkTra_lai).AutoSize = true;
		ChkTra_lai.Checked = true;
		((CheckBox)ChkTra_lai).CheckState = (CheckState)1;
		AsCheckBox chkTra_lai = ChkTra_lai;
		location = new Point(158, 448);
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
		Label obj72 = lblTru;
		location = new Point(19, 450);
		((Control)obj72).Location = location;
		((Control)lblTru).Name = "lblTru";
		Label obj73 = lblTru;
		size = new Size(23, 13);
		((Control)obj73).Size = size;
		((Control)lblTru).TabIndex = 1061;
		lblTru.Text = "Trừ";
		((ButtonBase)ChkTra_ck).AutoSize = true;
		ChkTra_ck.Checked = false;
		((Control)ChkTra_ck).Enabled = false;
		AsCheckBox chkTra_ck = ChkTra_ck;
		location = new Point(782, 407);
		((Control)chkTra_ck).Location = location;
		((Control)ChkTra_ck).Name = "ChkTra_ck";
		AsCheckBox chkTra_ck2 = ChkTra_ck;
		size = new Size(105, 17);
		((Control)chkTra_ck2).Size = size;
		((Control)ChkTra_ck).TabIndex = 17;
		((ButtonBase)ChkTra_ck).Text = "Hàng chiết khấu";
		ChkTra_ck.TextValue = "0";
		((ButtonBase)ChkTra_ck).UseVisualStyleBackColor = true;
		((Control)ChkTra_ck).Visible = false;
		((ButtonBase)ChkKhuyen_mai).AutoSize = true;
		ChkKhuyen_mai.Checked = false;
		((Control)ChkKhuyen_mai).Enabled = false;
		AsCheckBox chkKhuyen_mai = ChkKhuyen_mai;
		location = new Point(685, 414);
		((Control)chkKhuyen_mai).Location = location;
		((Control)ChkKhuyen_mai).Name = "ChkKhuyen_mai";
		AsCheckBox chkKhuyen_mai2 = ChkKhuyen_mai;
		size = new Size(91, 17);
		((Control)chkKhuyen_mai2).Size = size;
		((Control)ChkKhuyen_mai).TabIndex = 16;
		((ButtonBase)ChkKhuyen_mai).Text = "Hàng trả K/M";
		ChkKhuyen_mai.TextValue = "0";
		((ButtonBase)ChkKhuyen_mai).UseVisualStyleBackColor = true;
		((Control)ChkKhuyen_mai).Visible = false;
		((ButtonBase)ChkHang_ban).AutoSize = true;
		ChkHang_ban.Checked = false;
		((Control)ChkHang_ban).Enabled = false;
		AsCheckBox chkHang_ban = ChkHang_ban;
		location = new Point(896, 425);
		((Control)chkHang_ban).Location = location;
		((Control)ChkHang_ban).Name = "ChkHang_ban";
		AsCheckBox chkHang_ban2 = ChkHang_ban;
		size = new Size(73, 17);
		((Control)chkHang_ban2).Size = size;
		((Control)ChkHang_ban).TabIndex = 18;
		((ButtonBase)ChkHang_ban).Text = "Hàng bán";
		ChkHang_ban.TextValue = "0";
		((ButtonBase)ChkHang_ban).UseVisualStyleBackColor = true;
		((Control)ChkHang_ban).Visible = false;
		lblLoai_hang.AutoSize = true;
		((Control)lblLoai_hang).Enabled = false;
		lblLoai_hang.ImeMode = (ImeMode)0;
		Label obj74 = lblLoai_hang;
		location = new Point(597, 424);
		((Control)obj74).Location = location;
		((Control)lblLoai_hang).Name = "lblLoai_hang";
		Label obj75 = lblLoai_hang;
		size = new Size(54, 13);
		((Control)obj75).Size = size;
		((Control)lblLoai_hang).TabIndex = 1060;
		lblLoai_hang.Text = "Loại hàng";
		((Control)lblLoai_hang).Visible = false;
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj76 = lblTen_Bp;
		location = new Point(254, 306);
		((Control)obj76).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj77 = lblTen_Bp;
		size = new Size(485, 13);
		((Control)obj77).Size = size;
		((Control)lblTen_Bp).TabIndex = 1064;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox28 = txtMa_Bp;
		location = new Point(158, 302);
		((Control)asTextBox28).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox29 = txtMa_Bp;
		size = new Size(90, 20);
		((Control)asTextBox29).Size = size;
		((Control)txtMa_Bp).TabIndex = 12;
		((Control)txtMa_Bp).Tag = "MA_BP";
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_bp.AutoSize = true;
		lblMa_bp.ImeMode = (ImeMode)0;
		Label obj78 = lblMa_bp;
		location = new Point(19, 306);
		((Control)obj78).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj79 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj79).Size = size;
		((Control)lblMa_bp).TabIndex = 1063;
		lblMa_bp.Text = "Mã bộ phận";
		lblTen_Nvkd.ImeMode = (ImeMode)0;
		Label obj80 = lblTen_Nvkd;
		location = new Point(254, 330);
		((Control)obj80).Location = location;
		((Control)lblTen_Nvkd).Name = "lblTen_Nvkd";
		Label obj81 = lblTen_Nvkd;
		size = new Size(485, 13);
		((Control)obj81).Size = size;
		((Control)lblTen_Nvkd).TabIndex = 1067;
		((TextBox)txtMa_Nvkd).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Nvkd.AutoLookup = true;
		txtMa_Nvkd.AutoValid = false;
		((TextBoxBase)txtMa_Nvkd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nvkd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox30 = txtMa_Nvkd;
		location = new Point(158, 326);
		((Control)asTextBox30).Location = location;
		txtMa_Nvkd.LookupCodeName = "MA_NVKD";
		((Control)txtMa_Nvkd).Name = "txtMa_Nvkd";
		txtMa_Nvkd.NameControl = lblTen_Nvkd;
		AsTextBox asTextBox31 = txtMa_Nvkd;
		size = new Size(90, 20);
		((Control)asTextBox31).Size = size;
		((Control)txtMa_Nvkd).TabIndex = 13;
		((Control)txtMa_Nvkd).Tag = "MA_NVKD";
		txtMa_Nvkd.UseAutoCompleteSource = true;
		lblMa_nvkd.AutoSize = true;
		lblMa_nvkd.ImeMode = (ImeMode)0;
		Label obj82 = lblMa_nvkd;
		location = new Point(19, 330);
		((Control)obj82).Location = location;
		((Control)lblMa_nvkd).Name = "lblMa_nvkd";
		Label obj83 = lblMa_nvkd;
		size = new Size(55, 13);
		((Control)obj83).Size = size;
		((Control)lblMa_nvkd).TabIndex = 1066;
		lblMa_nvkd.Text = "Mã NVKD";
		((TextBox)txtTK_QL).AutoCompleteSource = (AutoCompleteSource)64;
		txtTK_QL.AutoLookup = true;
		txtTK_QL.AutoValid = false;
		((TextBoxBase)txtTK_QL).BackColor = SystemColors.Info;
		((TextBox)txtTK_QL).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox32 = txtTK_QL;
		location = new Point(158, 398);
		((Control)asTextBox32).Location = location;
		txtTK_QL.LookupCodeName = "TK";
		txtTK_QL.LookupWhereCondition = "tk like '64%'";
		((Control)txtTK_QL).Name = "txtTK_QL";
		txtTK_QL.NameControl = null;
		AsTextBox asTextBox33 = txtTK_QL;
		size = new Size(90, 20);
		((Control)asTextBox33).Size = size;
		((Control)txtTK_QL).TabIndex = 16;
		((Control)txtTK_QL).Tag = "MA_NVKD";
		txtTK_QL.UseAutoCompleteSource = true;
		Label2.AutoSize = true;
		Label2.ImeMode = (ImeMode)0;
		Label label = Label2;
		location = new Point(19, 402);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(71, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 1072;
		Label2.Text = "TK CP QLDN";
		((TextBox)txtTk_BH).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk_BH.AutoLookup = true;
		txtTk_BH.AutoValid = false;
		((TextBoxBase)txtTk_BH).BackColor = SystemColors.Info;
		((TextBox)txtTk_BH).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox34 = txtTk_BH;
		location = new Point(158, 350);
		((Control)asTextBox34).Location = location;
		txtTk_BH.LookupCodeName = "TK";
		txtTk_BH.LookupWhereCondition = "tk like '64%'";
		((Control)txtTk_BH).Name = "txtTk_BH";
		txtTk_BH.NameControl = null;
		AsTextBox asTextBox35 = txtTk_BH;
		size = new Size(90, 20);
		((Control)asTextBox35).Size = size;
		((Control)txtTk_BH).TabIndex = 14;
		((Control)txtTk_BH).Tag = "MA_BP";
		txtTk_BH.UseAutoCompleteSource = true;
		Label4.AutoSize = true;
		Label4.ImeMode = (ImeMode)0;
		Label label3 = Label4;
		location = new Point(19, 354);
		((Control)label3).Location = location;
		((Control)Label4).Name = "Label4";
		Label label4 = Label4;
		size = new Size(86, 13);
		((Control)label4).Size = size;
		((Control)Label4).TabIndex = 1070;
		Label4.Text = "TK CP bán hàng";
		((Control)Panel2).Controls.Add((Control)(object)rbCP_No);
		((Control)Panel2).Controls.Add((Control)(object)rbCP_CO);
		Panel panel = Panel2;
		location = new Point(257, 398);
		((Control)panel).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel2 = Panel2;
		size = new Size(151, 20);
		((Control)panel2).Size = size;
		((Control)Panel2).TabIndex = 14;
		((ButtonBase)rbCP_No).AutoSize = true;
		rbCP_No.Checked = true;
		RadioButton obj84 = rbCP_No;
		location = new Point(11, 2);
		((Control)obj84).Location = location;
		((Control)rbCP_No).Name = "rbCP_No";
		RadioButton obj85 = rbCP_No;
		size = new Size(39, 17);
		((Control)obj85).Size = size;
		((Control)rbCP_No).TabIndex = 0;
		rbCP_No.TabStop = true;
		((ButtonBase)rbCP_No).Text = "Nợ";
		((ButtonBase)rbCP_No).UseVisualStyleBackColor = true;
		((ButtonBase)rbCP_CO).AutoSize = true;
		RadioButton obj86 = rbCP_CO;
		location = new Point(56, 2);
		((Control)obj86).Location = location;
		((Control)rbCP_CO).Name = "rbCP_CO";
		RadioButton obj87 = rbCP_CO;
		size = new Size(38, 17);
		((Control)obj87).Size = size;
		((Control)rbCP_CO).TabIndex = 1;
		((ButtonBase)rbCP_CO).Text = "Có";
		((ButtonBase)rbCP_CO).UseVisualStyleBackColor = true;
		((Control)Panel1).Controls.Add((Control)(object)rbDT_No);
		((Control)Panel1).Controls.Add((Control)(object)rbDS_Co);
		Panel panel3 = Panel1;
		location = new Point(257, 350);
		((Control)panel3).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel4 = Panel1;
		size = new Size(151, 20);
		((Control)panel4).Size = size;
		((Control)Panel1).TabIndex = 11;
		((ButtonBase)rbDT_No).AutoSize = true;
		rbDT_No.Checked = true;
		RadioButton obj88 = rbDT_No;
		location = new Point(8, 2);
		((Control)obj88).Location = location;
		((Control)rbDT_No).Name = "rbDT_No";
		RadioButton obj89 = rbDT_No;
		size = new Size(39, 17);
		((Control)obj89).Size = size;
		((Control)rbDT_No).TabIndex = 0;
		rbDT_No.TabStop = true;
		((ButtonBase)rbDT_No).Text = "Nợ";
		((ButtonBase)rbDT_No).UseVisualStyleBackColor = true;
		((ButtonBase)rbDS_Co).AutoSize = true;
		RadioButton obj90 = rbDS_Co;
		location = new Point(56, 2);
		((Control)obj90).Location = location;
		((Control)rbDS_Co).Name = "rbDS_Co";
		RadioButton obj91 = rbDS_Co;
		size = new Size(38, 17);
		((Control)obj91).Size = size;
		((Control)rbDS_Co).TabIndex = 1;
		((ButtonBase)rbDS_Co).Text = "Có";
		((ButtonBase)rbDS_Co).UseVisualStyleBackColor = true;
		((ButtonBase)chkNc_QL).AutoSize = true;
		CheckBox obj92 = chkNc_QL;
		location = new Point(482, 397);
		((Control)obj92).Location = location;
		((Control)chkNc_QL).Name = "chkNc_QL";
		CheckBox obj93 = chkNc_QL;
		size = new Size(95, 17);
		((Control)obj93).Size = size;
		((Control)chkNc_QL).TabIndex = 41;
		((ButtonBase)chkNc_QL).Text = "Lấy PS Nợ/Có";
		((ButtonBase)chkNc_QL).UseVisualStyleBackColor = true;
		((Control)chkNc_QL).Visible = false;
		((ButtonBase)chkNC_BH).AutoSize = true;
		CheckBox obj94 = chkNC_BH;
		location = new Point(482, 353);
		((Control)obj94).Location = location;
		((Control)chkNC_BH).Name = "chkNC_BH";
		CheckBox obj95 = chkNC_BH;
		size = new Size(95, 17);
		((Control)obj95).Size = size;
		((Control)chkNC_BH).TabIndex = 40;
		((ButtonBase)chkNC_BH).Text = "Lấy PS Nợ/Có";
		((ButtonBase)chkNC_BH).UseVisualStyleBackColor = true;
		((Control)chkNC_BH).Visible = false;
		((TextBox)txtTK_CPBH_DU).AutoCompleteSource = (AutoCompleteSource)64;
		txtTK_CPBH_DU.AutoLookup = true;
		txtTK_CPBH_DU.AutoValid = false;
		((TextBoxBase)txtTK_CPBH_DU).BackColor = SystemColors.Info;
		((TextBox)txtTK_CPBH_DU).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox36 = txtTK_CPBH_DU;
		location = new Point(158, 374);
		((Control)asTextBox36).Location = location;
		txtTK_CPBH_DU.LookupCodeName = "TK";
		((Control)txtTK_CPBH_DU).Name = "txtTK_CPBH_DU";
		txtTK_CPBH_DU.NameControl = null;
		AsTextBox asTextBox37 = txtTK_CPBH_DU;
		size = new Size(90, 20);
		((Control)asTextBox37).Size = size;
		((Control)txtTK_CPBH_DU).TabIndex = 15;
		((Control)txtTK_CPBH_DU).Tag = "MA_BP";
		txtTK_CPBH_DU.UseAutoCompleteSource = true;
		Label1.AutoSize = true;
		Label1.ImeMode = (ImeMode)0;
		Label label5 = Label1;
		location = new Point(19, 378);
		((Control)label5).Location = location;
		((Control)Label1).Name = "Label1";
		Label label6 = Label1;
		size = new Size(40, 13);
		((Control)label6).Size = size;
		((Control)Label1).TabIndex = 1079;
		Label1.Text = "TK DU";
		((TextBox)txtTK_QKDN_DU).AutoCompleteSource = (AutoCompleteSource)64;
		txtTK_QKDN_DU.AutoLookup = true;
		txtTK_QKDN_DU.AutoValid = false;
		((TextBoxBase)txtTK_QKDN_DU).BackColor = SystemColors.Info;
		((TextBox)txtTK_QKDN_DU).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox38 = txtTK_QKDN_DU;
		location = new Point(158, 422);
		((Control)asTextBox38).Location = location;
		txtTK_QKDN_DU.LookupCodeName = "TK";
		((Control)txtTK_QKDN_DU).Name = "txtTK_QKDN_DU";
		txtTK_QKDN_DU.NameControl = null;
		AsTextBox asTextBox39 = txtTK_QKDN_DU;
		size = new Size(90, 20);
		((Control)asTextBox39).Size = size;
		((Control)txtTK_QKDN_DU).TabIndex = 17;
		((Control)txtTK_QKDN_DU).Tag = "MA_BP";
		txtTK_QKDN_DU.UseAutoCompleteSource = true;
		Label3.AutoSize = true;
		Label3.ImeMode = (ImeMode)0;
		Label label7 = Label3;
		location = new Point(19, 426);
		((Control)label7).Location = location;
		((Control)Label3).Name = "Label3";
		Label label8 = Label3;
		size = new Size(40, 13);
		((Control)label8).Size = size;
		((Control)Label3).TabIndex = 1081;
		Label3.Text = "TK DU";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).AutoScroll = true;
		size = new Size(948, 644);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmSORptBCPT03";
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		((TextBox)txtTk_BH).Text = MyMenuInfo.par3;
		((TextBox)txtTK_QL).Text = MyMenuInfo.par4;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_Kh).Text);
		arrayList.Add(((TextBox)txtMa_NhKh).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text.Trim());
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_Bp).Text);
		arrayList.Add(((TextBox)txtMa_Nvkd).Text);
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtMa_nhhd).Text);
		arrayList.Add(((TextBox)txtMa_plkh1).Text);
		arrayList.Add(((TextBox)txtMa_plkh2).Text);
		arrayList.Add(((TextBox)txtMa_plkh3).Text);
		arrayList.Add(((TextBox)txtMa_plvt1).Text);
		arrayList.Add(((TextBox)txtMa_plvt2).Text);
		arrayList.Add(((TextBox)txtMa_plvt3).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkKhuyen_mai.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_ck.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkHang_ban.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_lai.Checked));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(((TextBox)txtTk_BH).Text);
		arrayList.Add(((TextBox)txtTK_QL).Text);
		arrayList.Add(chkNC_BH.Checked);
		arrayList.Add(chkNc_QL.Checked);
		arrayList.Add(((TextBox)txtTK_CPBH_DU).Text);
		arrayList.Add(((TextBox)txtTK_QKDN_DU).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		DataRowView dataRowView = get_MyDGVSource(isSet2Print: true).DefaultView[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
		if ((int)keycode != 116 || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false), (object)"", false) ? true : false))
		{
			base.CancelDrilldown = true;
			return null;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_Kh).Text);
		arrayList.Add(((TextBox)txtMa_NhKh).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false)));
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_Bp).Text);
		arrayList.Add(((TextBox)txtMa_Nvkd).Text);
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtMa_nhhd).Text);
		arrayList.Add(((TextBox)txtMa_plkh1).Text);
		arrayList.Add(((TextBox)txtMa_plkh2).Text);
		arrayList.Add(((TextBox)txtMa_plkh3).Text);
		arrayList.Add(((TextBox)txtMa_plvt1).Text);
		arrayList.Add(((TextBox)txtMa_plvt2).Text);
		arrayList.Add(((TextBox)txtMa_plvt3).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkKhuyen_mai.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_ck.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkHang_ban.Checked));
		arrayList.Add(RuntimeHelpers.GetObjectValue(ChkTra_lai.Checked));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		if (Information.IsDBNull((object)arrayList))
		{
			base.CancelDrilldown = true;
			return null;
		}
		filterCondition4title = "Mã vật tư- " + dataRowView["ma_vt"].ToString();
		return arrayList;
	}

	private void rbDT_No_CheckedChanged(object sender, EventArgs e)
	{
		chkNC_BH.Checked = !rbDT_No.Checked;
	}

	private void rbCP_No_CheckedChanged(object sender, EventArgs e)
	{
		chkNc_QL.Checked = !rbCP_No.Checked;
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
		if (Operators.CompareString(((TextBox)txtMa_plkh1).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLKh1.Text + ": [" + ((TextBox)txtMa_plkh1).Text + " - " + lblTen_plkh1.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plkh2).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLKh2.Text + ": [" + ((TextBox)txtMa_plkh2).Text + " - " + lblTen_plkh2.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plkh3).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLKh3.Text + ": [" + ((TextBox)txtMa_plkh3).Text + " - " + lblTen_plkh3.Text + "]; ";
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
		if (Operators.CompareString(((TextBox)txtMa_plkh2).Text.Trim(), "", false) != 0)
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
			text = text + lblMa_bp.Text + ":" + ((TextBox)txtMa_Nvkd).Text.Trim() + " - " + lblTen_Nvkd.Text + "]; ";
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(ChkHang_ban.Checked, ChkKhuyen_mai.Checked), ChkTra_ck.Checked)))
		{
			text += lblLoai_hang.Text;
		}
		if (Conversions.ToBoolean(ChkHang_ban.Checked))
		{
			text = text + "[" + ((ButtonBase)ChkHang_ban).Text + "]; ";
		}
		if (Conversions.ToBoolean(ChkKhuyen_mai.Checked))
		{
			text = text + "[" + ((ButtonBase)ChkKhuyen_mai).Text + "]; ";
		}
		if (Conversions.ToBoolean(ChkTra_ck.Checked))
		{
			text = text + "[" + ((ButtonBase)ChkTra_ck).Text + "]; ";
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
