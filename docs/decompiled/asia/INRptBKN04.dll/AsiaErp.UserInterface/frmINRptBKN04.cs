using System;
using System.Collections;
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
public class frmINRptBKN04 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTheo_nhom")]
	private Label _lblTheo_nhom;

	[AccessedThroughProperty("cboTheo_nhom")]
	private ComboBox _cboTheo_nhom;

	[AccessedThroughProperty("txtMa_vtri")]
	private AsTextBox _txtMa_vtri;

	[AccessedThroughProperty("lblTen_vtri")]
	private Label _lblTen_vtri;

	[AccessedThroughProperty("lblMa_vtri")]
	private Label _lblMa_vtri;

	[AccessedThroughProperty("txtMa_kh")]
	private AsTextBox _txtMa_kh;

	[AccessedThroughProperty("lblTen_KH")]
	private Label _lblTen_KH;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("cboTheo_dvt")]
	private ComboBox _cboTheo_dvt;

	[AccessedThroughProperty("cboLoai_pn")]
	private ComboBox _cboLoai_pn;

	[AccessedThroughProperty("lblTheo_dvt")]
	private Label _lblTheo_dvt;

	[AccessedThroughProperty("txtSo_Ct2")]
	private TextBox _txtSo_Ct2;

	[AccessedThroughProperty("txtSo_Ct1")]
	private TextBox _txtSo_Ct1;

	[AccessedThroughProperty("lblSo_Ct2")]
	private Label _lblSo_Ct2;

	[AccessedThroughProperty("lblSo_Ct1")]
	private Label _lblSo_Ct1;

	[AccessedThroughProperty("lblTen_Ma_d_nx")]
	private Label _lblTen_Ma_d_nx;

	[AccessedThroughProperty("lblMa_d_nx")]
	private Label _lblMa_d_nx;

	[AccessedThroughProperty("txtMa_d_nx")]
	private AsTextBox _txtMa_d_nx;

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

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("txtTK_du")]
	private AsTextBox _txtTK_du;

	[AccessedThroughProperty("lblTen_TKdu")]
	private Label _lblTen_TKdu;

	[AccessedThroughProperty("lblTK_du")]
	private Label _lblTK_du;

	[AccessedThroughProperty("txtMa_TKVT")]
	private AsTextBox _txtMa_TKVT;

	[AccessedThroughProperty("lblTen_TKVT")]
	private Label _lblTen_TKVT;

	[AccessedThroughProperty("lblMa_TKVT")]
	private Label _lblMa_TKVT;

	[AccessedThroughProperty("lblLoai_pn")]
	private Label _lblLoai_pn;

	[AccessedThroughProperty("cboLoai_gd")]
	private ComboBox _cboLoai_gd;

	[AccessedThroughProperty("lblLoai_gd")]
	private Label _lblLoai_gd;

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("txtMa_lo")]
	private AsTextBox _txtMa_lo;

	[AccessedThroughProperty("lblMaLo")]
	private Label _lblMaLo;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("lblTenPhi")]
	private Label _lblTenPhi;

	[AccessedThroughProperty("txtMa_Phi")]
	private AsTextBox _txtMa_Phi;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	internal virtual Label lblTheo_nhom
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTheo_nhom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTheo_nhom = value;
		}
	}

	internal virtual ComboBox cboTheo_nhom
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboTheo_nhom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboTheo_nhom = value;
		}
	}

	internal virtual AsTextBox txtMa_vtri
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_vtri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_vtri = value;
		}
	}

	internal virtual Label lblTen_vtri
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_vtri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_vtri = value;
		}
	}

	internal virtual Label lblMa_vtri
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_vtri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_vtri = value;
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

	internal virtual ComboBox cboTheo_dvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboTheo_dvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboTheo_dvt = value;
		}
	}

	internal virtual ComboBox cboLoai_pn
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_pn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboLoai_phieu_SelectedValueChanged;
			if (_cboLoai_pn != null)
			{
				((ListControl)_cboLoai_pn).SelectedValueChanged -= eventHandler;
			}
			_cboLoai_pn = value;
			if (_cboLoai_pn != null)
			{
				((ListControl)_cboLoai_pn).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblTheo_dvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTheo_dvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTheo_dvt = value;
		}
	}

	internal virtual TextBox txtSo_Ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_Ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_Ct2 = value;
		}
	}

	internal virtual TextBox txtSo_Ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_Ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_Ct1 = value;
		}
	}

	internal virtual Label lblSo_Ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_Ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_Ct2 = value;
		}
	}

	internal virtual Label lblSo_Ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_Ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_Ct1 = value;
		}
	}

	internal virtual Label lblTen_Ma_d_nx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Ma_d_nx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Ma_d_nx = value;
		}
	}

	internal virtual Label lblMa_d_nx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_d_nx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_d_nx = value;
		}
	}

	internal virtual AsTextBox txtMa_d_nx
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_d_nx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_d_nx = value;
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

	internal virtual AsTextBox txtTK_du
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_du = value;
		}
	}

	internal virtual Label lblTen_TKdu
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TKdu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TKdu = value;
		}
	}

	internal virtual Label lblTK_du
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_du = value;
		}
	}

	internal virtual AsTextBox txtMa_TKVT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_TKVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_TKVT = value;
		}
	}

	internal virtual Label lblTen_TKVT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TKVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TKVT = value;
		}
	}

	internal virtual Label lblMa_TKVT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_TKVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_TKVT = value;
		}
	}

	internal virtual Label lblLoai_pn
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai_pn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai_pn = value;
		}
	}

	internal virtual ComboBox cboLoai_gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_gd = value;
		}
	}

	internal virtual Label lblLoai_gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai_gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai_gd = value;
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

	internal virtual Label lblTenPhi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTenPhi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTenPhi = value;
		}
	}

	internal virtual AsTextBox txtMa_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Phi = value;
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

	public frmINRptBKN04(ref string MenuId)
		: base(MenuId)
	{
		__ENCAddToList(this);
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
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
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
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
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
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
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_2d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d92: Expected O, but got Unknown
		lblTheo_nhom = new Label();
		cboTheo_nhom = new ComboBox();
		txtMa_vtri = new AsTextBox();
		lblTen_vtri = new Label();
		lblMa_vtri = new Label();
		txtMa_kh = new AsTextBox();
		lblTen_KH = new Label();
		lblMa_Kh = new Label();
		cboTheo_dvt = new ComboBox();
		cboLoai_pn = new ComboBox();
		lblTheo_dvt = new Label();
		txtSo_Ct2 = new TextBox();
		txtSo_Ct1 = new TextBox();
		lblSo_Ct2 = new Label();
		lblSo_Ct1 = new Label();
		lblTen_Ma_d_nx = new Label();
		lblMa_d_nx = new Label();
		txtMa_d_nx = new AsTextBox();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		lblMa_vt = new Label();
		txtMa_nhvt = new AsTextBox();
		lblTen_Nhvt = new Label();
		lblMa_nhvt = new Label();
		txtMa_kho = new AsTextBox();
		lblTen_kho = new Label();
		lblMa_kho = new Label();
		txtMa_bp = new AsTextBox();
		lblTen_bp = new Label();
		lblMa_bp = new Label();
		lblMa_hd = new Label();
		txtMa_hd = new AsTextBox();
		lblTen_hd = new Label();
		txtTK_du = new AsTextBox();
		lblTen_TKdu = new Label();
		lblTK_du = new Label();
		txtMa_TKVT = new AsTextBox();
		lblTen_TKVT = new Label();
		lblMa_TKVT = new Label();
		lblLoai_pn = new Label();
		cboLoai_gd = new ComboBox();
		lblLoai_gd = new Label();
		Label8 = new Label();
		lblTenPhi = new Label();
		txtMa_Phi = new AsTextBox();
		lblTen_spct = new Label();
		txtMa_spct = new AsTextBox();
		lblMa_spct = new Label();
		lblTen_lo = new Label();
		txtMa_lo = new AsTextBox();
		lblMaLo = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(873, 611);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lo);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_lo);
		((Control)tabFilter).Controls.Add((Control)(object)lblMaLo);
		((Control)tabFilter).Controls.Add((Control)(object)Label8);
		((Control)tabFilter).Controls.Add((Control)(object)lblTenPhi);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai_gd);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoai_gd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTheo_nhom);
		((Control)tabFilter).Controls.Add((Control)(object)cboTheo_nhom);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vtri);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vtri);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vtri);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_KH);
		((Control)tabFilter).Controls.Add((Control)(object)cboTheo_dvt);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai_pn);
		((Control)tabFilter).Controls.Add((Control)(object)lblTheo_dvt);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_Ct2);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_Ct1);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct2);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Ma_d_nx);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_d_nx);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_d_nx);
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
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtTK_du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTK_du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_TKdu);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_TKVT);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_TKVT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_TKVT);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoai_pn);
		TabPage obj = tabFilter;
		size = new Size(865, 582);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoai_pn, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_TKVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_TKVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_TKVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_TKdu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK_du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK_du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_d_nx, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_d_nx, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Ma_d_nx, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_Ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_Ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTheo_dvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai_pn, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboTheo_dvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_KH, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vtri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vtri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vtri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboTheo_nhom, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTheo_nhom, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoai_gd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai_gd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTenPhi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMaLo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lo, 0);
		Label obj2 = lbl2;
		Point location = new Point(331, 70);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 24;
		Button obj3 = cmdExcel;
		location = new Point(699, 588);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 22;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(352, 66);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(618, 588);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 21;
		Button obj5 = cmdModifyReport;
		location = new Point(506, 16);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 1;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(261, 66);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(161, 66);
		((Control)obj6).Location = location;
		ComboBox obj7 = cboKyBc;
		size = new Size(87, 21);
		((Control)obj7).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		Label obj8 = lblKyBc;
		location = new Point(22, 70);
		((Control)obj8).Location = location;
		ComboBox obj9 = cboMau_bc;
		location = new Point(161, 17);
		((Control)obj9).Location = location;
		Label obj10 = lblMau_bc;
		location = new Point(22, 20);
		((Control)obj10).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(161, 455);
		((Control)asTextBox).Location = location;
		((TextBoxBase)txtMa_Nt).MaxLength = 8;
		((Control)txtMa_Nt).TabIndex = 20;
		Label obj11 = lblMauBC;
		location = new Point(206, 454);
		((Control)obj11).Location = location;
		RadioButton obj12 = optVND;
		location = new Point(293, 453);
		((Control)obj12).Location = location;
		((Control)optVND).TabIndex = 21;
		RadioButton obj13 = optNt;
		location = new Point(347, 454);
		((Control)obj13).Location = location;
		((Control)optNt).TabIndex = 22;
		Label obj14 = lblMa_nt;
		location = new Point(22, 457);
		((Control)obj14).Location = location;
		Button obj15 = cmdOk;
		location = new Point(25, 488);
		((Control)obj15).Location = location;
		((Control)cmdOk).TabIndex = 23;
		Label obj16 = lblTieu_de;
		location = new Point(22, 46);
		((Control)obj16).Location = location;
		((Control)lblTieu_de).TabIndex = 28;
		TextBox obj17 = txtTieu_De;
		location = new Point(161, 42);
		((Control)obj17).Location = location;
		((Control)txtTieu_De).TabIndex = 2;
		TabPage obj18 = tabGrid;
		size = new Size(865, 582);
		((Control)obj18).Size = size;
		lblTheo_nhom.AutoSize = true;
		Label obj19 = lblTheo_nhom;
		location = new Point(22, 122);
		((Control)obj19).Location = location;
		((Control)lblTheo_nhom).Name = "lblTheo_nhom";
		Label obj20 = lblTheo_nhom;
		size = new Size(61, 13);
		((Control)obj20).Size = size;
		((Control)lblTheo_nhom).TabIndex = 1282;
		lblTheo_nhom.Text = "Theo nhóm";
		cboTheo_nhom.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboTheo_nhom).FormattingEnabled = true;
		cboTheo_nhom.Items.AddRange(new object[8] { "", "Nhà cung cấp", "Bộ phận", "Hợp đồng", "Sản phẩm, công trình", "Dạng nhập xuất", "Vật tư", "Chứng từ" });
		ComboBox obj21 = cboTheo_nhom;
		location = new Point(161, 118);
		((Control)obj21).Location = location;
		((Control)cboTheo_nhom).Name = "cboTheo_nhom";
		ComboBox obj22 = cboTheo_nhom;
		size = new Size(180, 21);
		((Control)obj22).Size = size;
		((Control)cboTheo_nhom).TabIndex = 5;
		txtMa_vtri.AutoLookup = true;
		txtMa_vtri.AutoValid = false;
		((TextBoxBase)txtMa_vtri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vtri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vtri).Enabled = false;
		AsTextBox asTextBox2 = txtMa_vtri;
		location = new Point(400, 577);
		((Control)asTextBox2).Location = location;
		txtMa_vtri.LookupCodeName = "MA_VITRI";
		((TextBoxBase)txtMa_vtri).MaxLength = 8;
		((Control)txtMa_vtri).Name = "txtMa_vtri";
		txtMa_vtri.NameControl = lblTen_vtri;
		AsTextBox asTextBox3 = txtMa_vtri;
		size = new Size(87, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_vtri).TabIndex = 16;
		txtMa_vtri.UseAutoCompleteSource = true;
		((Control)txtMa_vtri).Visible = false;
		((Control)lblTen_vtri).BackColor = Color.Transparent;
		((Control)lblTen_vtri).Enabled = false;
		Label obj23 = lblTen_vtri;
		location = new Point(503, 581);
		((Control)obj23).Location = location;
		((Control)lblTen_vtri).Name = "lblTen_vtri";
		Label obj24 = lblTen_vtri;
		size = new Size(317, 13);
		((Control)obj24).Size = size;
		((Control)lblTen_vtri).TabIndex = 1281;
		((Control)lblTen_vtri).Visible = false;
		lblMa_vtri.AutoSize = true;
		((Control)lblMa_vtri).Enabled = false;
		Label obj25 = lblMa_vtri;
		location = new Point(295, 581);
		((Control)obj25).Location = location;
		((Control)lblMa_vtri).Name = "lblMa_vtri";
		Label obj26 = lblMa_vtri;
		size = new Size(46, 13);
		((Control)obj26).Size = size;
		((Control)lblMa_vtri).TabIndex = 1280;
		lblMa_vtri.Text = "Mã vị trí";
		((Control)lblMa_vtri).Visible = false;
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = false;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_kh;
		location = new Point(161, 285);
		((Control)asTextBox4).Location = location;
		txtMa_kh.LookupCodeName = "Ma_KH";
		((TextBoxBase)txtMa_kh).MaxLength = 20;
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = lblTen_KH;
		AsTextBox asTextBox5 = txtMa_kh;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_kh).TabIndex = 13;
		txtMa_kh.UseAutoCompleteSource = true;
		((Control)lblTen_KH).BackColor = Color.Transparent;
		Label obj27 = lblTen_KH;
		location = new Point(257, 289);
		((Control)obj27).Location = location;
		((Control)lblTen_KH).Name = "lblTen_KH";
		Label obj28 = lblTen_KH;
		size = new Size(479, 13);
		((Control)obj28).Size = size;
		((Control)lblTen_KH).TabIndex = 1279;
		lblMa_Kh.AutoSize = true;
		Label obj29 = lblMa_Kh;
		location = new Point(22, 289);
		((Control)obj29).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj30 = lblMa_Kh;
		size = new Size(55, 13);
		((Control)obj30).Size = size;
		((Control)lblMa_Kh).TabIndex = 1278;
		lblMa_Kh.Text = "Mã khách";
		cboTheo_dvt.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboTheo_dvt).FormattingEnabled = true;
		cboTheo_dvt.Items.AddRange(new object[4] { "Chứng từ", "Tồn Kho", "Mua", "Bán" });
		ComboBox obj31 = cboTheo_dvt;
		location = new Point(161, 429);
		((Control)obj31).Location = location;
		((Control)cboTheo_dvt).Name = "cboTheo_dvt";
		ComboBox obj32 = cboTheo_dvt;
		size = new Size(90, 21);
		((Control)obj32).Size = size;
		((Control)cboTheo_dvt).TabIndex = 19;
		cboLoai_pn.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_pn).FormattingEnabled = true;
		ComboBox obj33 = cboLoai_pn;
		location = new Point(161, 92);
		((Control)obj33).Location = location;
		((Control)cboLoai_pn).Name = "cboLoai_pn";
		ComboBox obj34 = cboLoai_pn;
		size = new Size(180, 21);
		((Control)obj34).Size = size;
		((Control)cboLoai_pn).TabIndex = 3;
		lblTheo_dvt.AutoSize = true;
		Label obj35 = lblTheo_dvt;
		location = new Point(22, 433);
		((Control)obj35).Location = location;
		((Control)lblTheo_dvt).Name = "lblTheo_dvt";
		Label obj36 = lblTheo_dvt;
		size = new Size(57, 13);
		((Control)obj36).Size = size;
		((Control)lblTheo_dvt).TabIndex = 1277;
		lblTheo_dvt.Text = "Theo ĐVT";
		TextBox obj37 = txtSo_Ct2;
		location = new Point(332, 142);
		((Control)obj37).Location = location;
		((TextBoxBase)txtSo_Ct2).MaxLength = 8;
		((Control)txtSo_Ct2).Name = "txtSo_Ct2";
		TextBox obj38 = txtSo_Ct2;
		size = new Size(87, 20);
		((Control)obj38).Size = size;
		((Control)txtSo_Ct2).TabIndex = 7;
		TextBox obj39 = txtSo_Ct1;
		location = new Point(161, 142);
		((Control)obj39).Location = location;
		((TextBoxBase)txtSo_Ct1).MaxLength = 8;
		((Control)txtSo_Ct1).Name = "txtSo_Ct1";
		TextBox obj40 = txtSo_Ct1;
		size = new Size(90, 20);
		((Control)obj40).Size = size;
		((Control)txtSo_Ct1).TabIndex = 6;
		lblSo_Ct2.AutoSize = true;
		Label obj41 = lblSo_Ct2;
		location = new Point(283, 146);
		((Control)obj41).Location = location;
		((Control)lblSo_Ct2).Name = "lblSo_Ct2";
		Label obj42 = lblSo_Ct2;
		size = new Size(41, 13);
		((Control)obj42).Size = size;
		((Control)lblSo_Ct2).TabIndex = 1276;
		lblSo_Ct2.Text = "Đến số";
		lblSo_Ct1.AutoSize = true;
		Label obj43 = lblSo_Ct1;
		location = new Point(22, 146);
		((Control)obj43).Location = location;
		((Control)lblSo_Ct1).Name = "lblSo_Ct1";
		Label obj44 = lblSo_Ct1;
		size = new Size(64, 13);
		((Control)obj44).Size = size;
		((Control)lblSo_Ct1).TabIndex = 1275;
		lblSo_Ct1.Text = "Chứng từ số";
		((Control)lblTen_Ma_d_nx).BackColor = Color.Transparent;
		((Control)lblTen_Ma_d_nx).Enabled = false;
		Label obj45 = lblTen_Ma_d_nx;
		location = new Point(516, 485);
		((Control)obj45).Location = location;
		((Control)lblTen_Ma_d_nx).Name = "lblTen_Ma_d_nx";
		Label obj46 = lblTen_Ma_d_nx;
		size = new Size(317, 13);
		((Control)obj46).Size = size;
		((Control)lblTen_Ma_d_nx).TabIndex = 1274;
		((Control)lblTen_Ma_d_nx).Visible = false;
		lblMa_d_nx.AutoSize = true;
		((Control)lblMa_d_nx).Enabled = false;
		Label obj47 = lblMa_d_nx;
		location = new Point(275, 488);
		((Control)obj47).Location = location;
		((Control)lblMa_d_nx).Name = "lblMa_d_nx";
		Label obj48 = lblMa_d_nx;
		size = new Size(67, 13);
		((Control)obj48).Size = size;
		((Control)lblMa_d_nx).TabIndex = 1273;
		lblMa_d_nx.Text = "Mã dạng NX";
		((Control)lblMa_d_nx).Visible = false;
		txtMa_d_nx.AutoLookup = true;
		txtMa_d_nx.AutoValid = false;
		((TextBoxBase)txtMa_d_nx).BackColor = SystemColors.Info;
		((TextBox)txtMa_d_nx).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_d_nx).Enabled = false;
		AsTextBox asTextBox6 = txtMa_d_nx;
		location = new Point(413, 484);
		((Control)asTextBox6).Location = location;
		txtMa_d_nx.LookupCodeName = "MA_HTTT";
		txtMa_d_nx.LookupWhereCondition = "ma_httt like 'NX%'";
		((TextBoxBase)txtMa_d_nx).MaxLength = 20;
		((Control)txtMa_d_nx).Name = "txtMa_d_nx";
		txtMa_d_nx.NameControl = lblTen_Ma_d_nx;
		AsTextBox asTextBox7 = txtMa_d_nx;
		size = new Size(87, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_d_nx).TabIndex = 19;
		txtMa_d_nx.UseAutoCompleteSource = true;
		((Control)txtMa_d_nx).Visible = false;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_vt;
		location = new Point(161, 189);
		((Control)asTextBox8).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((TextBoxBase)txtMa_vt).MaxLength = 20;
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox9 = txtMa_vt;
		size = new Size(90, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_vt).TabIndex = 9;
		txtMa_vt.UseAutoCompleteSource = true;
		((Control)lblTen_vt).BackColor = Color.Transparent;
		Label obj49 = lblTen_vt;
		location = new Point(257, 193);
		((Control)obj49).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj50 = lblTen_vt;
		size = new Size(479, 13);
		((Control)obj50).Size = size;
		((Control)lblTen_vt).TabIndex = 1272;
		lblMa_vt.AutoSize = true;
		Label obj51 = lblMa_vt;
		location = new Point(22, 193);
		((Control)obj51).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj52 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj52).Size = size;
		((Control)lblMa_vt).TabIndex = 1270;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_nhvt;
		location = new Point(161, 213);
		((Control)asTextBox10).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((TextBoxBase)txtMa_nhvt).MaxLength = 8;
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_Nhvt;
		AsTextBox asTextBox11 = txtMa_nhvt;
		size = new Size(90, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_nhvt).TabIndex = 10;
		txtMa_nhvt.UseAutoCompleteSource = true;
		((Control)lblTen_Nhvt).BackColor = Color.Transparent;
		Label obj53 = lblTen_Nhvt;
		location = new Point(257, 217);
		((Control)obj53).Location = location;
		((Control)lblTen_Nhvt).Name = "lblTen_Nhvt";
		Label obj54 = lblTen_Nhvt;
		size = new Size(479, 13);
		((Control)obj54).Size = size;
		((Control)lblTen_Nhvt).TabIndex = 1271;
		lblMa_nhvt.AutoSize = true;
		Label obj55 = lblMa_nhvt;
		location = new Point(22, 217);
		((Control)obj55).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj56 = lblMa_nhvt;
		size = new Size(65, 13);
		((Control)obj56).Size = size;
		((Control)lblMa_nhvt).TabIndex = 1269;
		lblMa_nhvt.Text = "Nhóm vật tư";
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_kho;
		location = new Point(161, 166);
		((Control)asTextBox12).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((TextBoxBase)txtMa_kho).MaxLength = 20;
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox13 = txtMa_kho;
		size = new Size(90, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_kho).TabIndex = 8;
		txtMa_kho.UseAutoCompleteSource = true;
		((Control)lblTen_kho).BackColor = Color.Transparent;
		Label obj57 = lblTen_kho;
		location = new Point(257, 170);
		((Control)obj57).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj58 = lblTen_kho;
		size = new Size(479, 13);
		((Control)obj58).Size = size;
		((Control)lblTen_kho).TabIndex = 1268;
		lblMa_kho.AutoSize = true;
		Label obj59 = lblMa_kho;
		location = new Point(22, 170);
		((Control)obj59).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj60 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj60).Size = size;
		((Control)lblMa_kho).TabIndex = 1265;
		lblMa_kho.Text = "Mã kho";
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_bp;
		location = new Point(161, 309);
		((Control)asTextBox14).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((TextBoxBase)txtMa_bp).MaxLength = 20;
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox15 = txtMa_bp;
		size = new Size(90, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_bp).TabIndex = 14;
		txtMa_bp.UseAutoCompleteSource = true;
		((Control)lblTen_bp).BackColor = Color.Transparent;
		Label obj61 = lblTen_bp;
		location = new Point(257, 313);
		((Control)obj61).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj62 = lblTen_bp;
		size = new Size(479, 13);
		((Control)obj62).Size = size;
		((Control)lblTen_bp).TabIndex = 1267;
		lblMa_bp.AutoSize = true;
		Label obj63 = lblMa_bp;
		location = new Point(22, 313);
		((Control)obj63).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj64 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj64).Size = size;
		((Control)lblMa_bp).TabIndex = 1266;
		lblMa_bp.Text = "Mã bộ phận";
		lblMa_hd.AutoSize = true;
		Label obj65 = lblMa_hd;
		location = new Point(22, 337);
		((Control)obj65).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj66 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj66).Size = size;
		((Control)lblMa_hd).TabIndex = 1263;
		lblMa_hd.Text = "Mã hợp đồng";
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox16 = txtMa_hd;
		location = new Point(161, 333);
		((Control)asTextBox16).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((TextBoxBase)txtMa_hd).MaxLength = 20;
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox17 = txtMa_hd;
		size = new Size(90, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtMa_hd).TabIndex = 15;
		txtMa_hd.UseAutoCompleteSource = true;
		((Control)lblTen_hd).BackColor = Color.Transparent;
		Label obj67 = lblTen_hd;
		location = new Point(257, 337);
		((Control)obj67).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj68 = lblTen_hd;
		size = new Size(479, 13);
		((Control)obj68).Size = size;
		((Control)lblTen_hd).TabIndex = 1264;
		txtTK_du.AutoLookup = true;
		txtTK_du.AutoValid = false;
		((TextBoxBase)txtTK_du).BackColor = SystemColors.Info;
		((TextBox)txtTK_du).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox18 = txtTK_du;
		location = new Point(161, 261);
		((Control)asTextBox18).Location = location;
		txtTK_du.LookupCodeName = "TK";
		((TextBoxBase)txtTK_du).MaxLength = 20;
		((Control)txtTK_du).Name = "txtTK_du";
		txtTK_du.NameControl = lblTen_TKdu;
		AsTextBox asTextBox19 = txtTK_du;
		size = new Size(90, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtTK_du).TabIndex = 12;
		txtTK_du.UseAutoCompleteSource = true;
		((Control)lblTen_TKdu).BackColor = Color.Transparent;
		Label obj69 = lblTen_TKdu;
		location = new Point(257, 265);
		((Control)obj69).Location = location;
		((Control)lblTen_TKdu).Name = "lblTen_TKdu";
		Label obj70 = lblTen_TKdu;
		size = new Size(479, 13);
		((Control)obj70).Size = size;
		((Control)lblTen_TKdu).TabIndex = 1258;
		lblTK_du.AutoSize = true;
		Label obj71 = lblTK_du;
		location = new Point(22, 265);
		((Control)obj71).Location = location;
		((Control)lblTK_du).Name = "lblTK_du";
		Label obj72 = lblTK_du;
		size = new Size(74, 13);
		((Control)obj72).Size = size;
		((Control)lblTK_du).TabIndex = 1262;
		lblTK_du.Text = "Tài khoản ĐƯ";
		txtMa_TKVT.AutoLookup = true;
		txtMa_TKVT.AutoValid = false;
		((TextBoxBase)txtMa_TKVT).BackColor = SystemColors.Info;
		((TextBox)txtMa_TKVT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtMa_TKVT;
		location = new Point(161, 237);
		((Control)asTextBox20).Location = location;
		txtMa_TKVT.LookupCodeName = "TK";
		((TextBoxBase)txtMa_TKVT).MaxLength = 20;
		((Control)txtMa_TKVT).Name = "txtMa_TKVT";
		txtMa_TKVT.NameControl = lblTen_TKVT;
		AsTextBox asTextBox21 = txtMa_TKVT;
		size = new Size(90, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMa_TKVT).TabIndex = 11;
		txtMa_TKVT.UseAutoCompleteSource = true;
		((Control)lblTen_TKVT).BackColor = Color.Transparent;
		Label obj73 = lblTen_TKVT;
		location = new Point(257, 241);
		((Control)obj73).Location = location;
		((Control)lblTen_TKVT).Name = "lblTen_TKVT";
		Label obj74 = lblTen_TKVT;
		size = new Size(479, 13);
		((Control)obj74).Size = size;
		((Control)lblTen_TKVT).TabIndex = 1261;
		lblMa_TKVT.AutoSize = true;
		Label obj75 = lblMa_TKVT;
		location = new Point(22, 241);
		((Control)obj75).Location = location;
		((Control)lblMa_TKVT).Name = "lblMa_TKVT";
		Label obj76 = lblMa_TKVT;
		size = new Size(85, 13);
		((Control)obj76).Size = size;
		((Control)lblMa_TKVT).TabIndex = 1260;
		lblMa_TKVT.Text = "Tài khoản vật tư";
		lblLoai_pn.AutoSize = true;
		Label obj77 = lblLoai_pn;
		location = new Point(22, 95);
		((Control)obj77).Location = location;
		((Control)lblLoai_pn).Name = "lblLoai_pn";
		Label obj78 = lblLoai_pn;
		size = new Size(83, 13);
		((Control)obj78).Size = size;
		((Control)lblLoai_pn).TabIndex = 1259;
		lblLoai_pn.Text = "Loại phiếu nhập";
		cboLoai_gd.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_gd).FormattingEnabled = true;
		ComboBox obj79 = cboLoai_gd;
		location = new Point(433, 92);
		((Control)obj79).Location = location;
		((Control)cboLoai_gd).Name = "cboLoai_gd";
		ComboBox obj80 = cboLoai_gd;
		size = new Size(148, 21);
		((Control)obj80).Size = size;
		((Control)cboLoai_gd).TabIndex = 4;
		lblLoai_gd.AutoSize = true;
		Label obj81 = lblLoai_gd;
		location = new Point(352, 96);
		((Control)obj81).Location = location;
		((Control)lblLoai_gd).Name = "lblLoai_gd";
		Label obj82 = lblLoai_gd;
		size = new Size(73, 13);
		((Control)obj82).Size = size;
		((Control)lblLoai_gd).TabIndex = 1299;
		lblLoai_gd.Text = "Loại giao dịch";
		Label8.AutoSize = true;
		Label label = Label8;
		location = new Point(22, 361);
		((Control)label).Location = location;
		((Control)Label8).Name = "Label8";
		Label label2 = Label8;
		size = new Size(41, 13);
		((Control)label2).Size = size;
		((Control)Label8).TabIndex = 1305;
		Label8.Text = "Mã phí";
		Label obj83 = lblTenPhi;
		location = new Point(257, 361);
		((Control)obj83).Location = location;
		((Control)lblTenPhi).Name = "lblTenPhi";
		Label obj84 = lblTenPhi;
		size = new Size(479, 13);
		((Control)obj84).Size = size;
		((Control)lblTenPhi).TabIndex = 1304;
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox22 = txtMa_Phi;
		location = new Point(161, 357);
		((Control)asTextBox22).Location = location;
		txtMa_Phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		txtMa_Phi.NameControl = lblTenPhi;
		AsTextBox asTextBox23 = txtMa_Phi;
		size = new Size(90, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMa_Phi).TabIndex = 16;
		((Control)txtMa_Phi).Tag = "MA_PHI";
		txtMa_Phi.UseAutoCompleteSource = true;
		Label obj85 = lblTen_spct;
		location = new Point(257, 383);
		((Control)obj85).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj86 = lblTen_spct;
		size = new Size(479, 13);
		((Control)obj86).Size = size;
		((Control)lblTen_spct).TabIndex = 1302;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox24 = txtMa_spct;
		location = new Point(161, 381);
		((Control)asTextBox24).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox25 = txtMa_spct;
		size = new Size(90, 20);
		((Control)asTextBox25).Size = size;
		((Control)txtMa_spct).TabIndex = 17;
		((Control)txtMa_spct).Tag = "MA_SPCT";
		txtMa_spct.UseAutoCompleteSource = true;
		lblMa_spct.AutoSize = true;
		Label obj87 = lblMa_spct;
		location = new Point(22, 385);
		((Control)obj87).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj88 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj88).Size = size;
		((Control)lblMa_spct).TabIndex = 1303;
		lblMa_spct.Text = "Mã SPCT";
		Label obj89 = lblTen_lo;
		location = new Point(254, 409);
		((Control)obj89).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj90 = lblTen_lo;
		size = new Size(515, 13);
		((Control)obj90).Size = size;
		((Control)lblTen_lo).TabIndex = 1307;
		txtMa_lo.AutoLookup = true;
		txtMa_lo.AutoValid = false;
		((TextBoxBase)txtMa_lo).BackColor = SystemColors.Info;
		((TextBox)txtMa_lo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox26 = txtMa_lo;
		location = new Point(161, 405);
		((Control)asTextBox26).Location = location;
		txtMa_lo.LookupCodeName = "MA_LO";
		((Control)txtMa_lo).Name = "txtMa_lo";
		txtMa_lo.NameControl = lblTen_lo;
		AsTextBox asTextBox27 = txtMa_lo;
		size = new Size(90, 20);
		((Control)asTextBox27).Size = size;
		((Control)txtMa_lo).TabIndex = 18;
		((Control)txtMa_lo).Tag = "MA_LO";
		txtMa_lo.UseAutoCompleteSource = true;
		lblMaLo.AutoSize = true;
		Label obj91 = lblMaLo;
		location = new Point(22, 409);
		((Control)obj91).Location = location;
		((Control)lblMaLo).Name = "lblMaLo";
		Label obj92 = lblMaLo;
		size = new Size(33, 13);
		((Control)obj92).Size = size;
		((Control)lblMaLo).TabIndex = 1308;
		lblMaLo.Text = "Mã lô";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(873, 636);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmINRptBKN04";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		base.InitOtherComponents();
		((Control)cboKyBc).Select();
		ComboBox val = cboLoai_pn;
		val.DataSource = AsiaErp.Framework.Environment.GetDanhSachChungTuNhap();
		((ListControl)val).ValueMember = "Key";
		((ListControl)val).DisplayMember = "Value";
		val.SelectedIndex = 0;
		val = null;
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		ComboBox val2 = cboTheo_dvt;
		dictionary.Add("0", Conversions.ToString(val2.Items[0]));
		dictionary.Add("1", Conversions.ToString(val2.Items[1]));
		dictionary.Add("2", Conversions.ToString(val2.Items[2]));
		dictionary.Add("3", Conversions.ToString(val2.Items[3]));
		BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
		val2.DataSource = dataSource;
		((ListControl)val2).DisplayMember = "value";
		((ListControl)val2).ValueMember = "key";
		val2.SelectedIndex = 0;
		val2 = null;
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		ComboBox val3 = cboTheo_nhom;
		dictionary2.Add("", Conversions.ToString(val3.Items[0]));
		dictionary2.Add("Ma_KH", Conversions.ToString(val3.Items[1]));
		dictionary2.Add("MA_BP", Conversions.ToString(val3.Items[2]));
		dictionary2.Add("Ma_HD", Conversions.ToString(val3.Items[3]));
		dictionary2.Add("Ma_SPCT", Conversions.ToString(val3.Items[4]));
		dictionary2.Add("MA_NX", Conversions.ToString(val3.Items[5]));
		dictionary2.Add("MA_VT", Conversions.ToString(val3.Items[6]));
		dictionary2.Add("STT_REC", Conversions.ToString(val3.Items[7]));
		BindingSource dataSource2 = new BindingSource((object)dictionary2, (string)null);
		val3.DataSource = dataSource2;
		((ListControl)val3).ValueMember = "Key";
		((ListControl)val3).DisplayMember = "Value";
		val3.SelectedIndex = 0;
		val3 = null;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(txtSo_Ct1.Text.Trim());
		arrayList.Add(txtSo_Ct2.Text.Trim());
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_pn).SelectedValue));
		arrayList.Add(((TextBox)txtMa_hd).Text.Trim());
		arrayList.Add(((TextBox)txtMa_kh).Text.Trim());
		arrayList.Add(((TextBox)txtMa_vt).Text.Trim());
		arrayList.Add(((TextBox)txtMa_kho).Text.Trim());
		arrayList.Add(((TextBox)txtMa_vtri).Text.Trim());
		arrayList.Add(((TextBox)txtMa_bp).Text.Trim());
		arrayList.Add(((TextBox)txtMa_d_nx).Text.Trim());
		arrayList.Add(((TextBox)txtMa_TKVT).Text.Trim());
		arrayList.Add(((TextBox)txtTK_du).Text.Trim());
		arrayList.Add(((TextBox)txtMa_nhvt).Text.Trim());
		arrayList.Add(((TextBox)txtMa_lo).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Phi).Text.Trim());
		arrayList.Add(((TextBox)txtMa_spct).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Nt).Text.Trim());
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboTheo_dvt).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboTheo_nhom).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_gd).SelectedValue));
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string empty = string.Empty;
		empty = empty + lblLoai_pn.Text + ": [" + cboLoai_pn.Text + "]; ";
		empty = empty + lblLoai_gd.Text + ": [" + cboLoai_gd.Text + "]; ";
		empty = empty + lblTheo_nhom.Text + ": [" + cboTheo_nhom.Text + "]; ";
		if (Operators.CompareString(txtSo_Ct1.Text.Trim(), "", false) != 0)
		{
			empty = empty + lblSo_Ct1.Text + ": [" + txtSo_Ct1.Text + "]; ";
		}
		if (Operators.CompareString(txtSo_Ct2.Text.Trim(), "", false) != 0)
		{
			empty = empty + lblSo_Ct2.Text + ": [" + txtSo_Ct2.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kh).Text.Trim(), "", false) != 0)
		{
			empty = empty + lblMa_Kh.Text + ": [" + ((TextBox)txtMa_kh).Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text.Trim(), "", false) != 0)
		{
			empty = empty + lblMa_vt.Text + ": [" + ((TextBox)txtMa_vt).Text + " - " + lblTen_vt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhvt).Text.Trim(), "", false) != 0)
		{
			empty = empty + lblMa_nhvt.Text + ": [" + ((TextBox)txtMa_nhvt).Text + " - " + lblTen_Nhvt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_TKVT).Text.Trim(), "", false) != 0)
		{
			empty = empty + lblMa_TKVT.Text + ": [" + ((TextBox)txtMa_TKVT).Text + " - " + lblTen_TKVT.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text.Trim(), "", false) != 0)
		{
			empty = empty + lblMa_kho.Text + ": [" + ((TextBox)txtMa_kho).Text + " - " + lblTen_kho.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vtri).Text.Trim(), "", false) != 0)
		{
			empty = empty + lblMa_vtri.Text + ": [" + ((TextBox)txtMa_vtri).Text + " - " + lblTen_vtri.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_bp).Text.Trim(), "", false) != 0)
		{
			empty = empty + lblMa_bp.Text + ": [" + ((TextBox)txtMa_bp).Text + " - " + lblTen_bp.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_hd).Text.Trim(), "", false) != 0)
		{
			empty = empty + lblMa_hd.Text + ": [" + ((TextBox)txtMa_hd).Text + " - " + lblTen_hd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_d_nx).Text.Trim(), "", false) != 0)
		{
			empty = empty + lblMa_d_nx.Text + ": [" + ((TextBox)txtMa_d_nx).Text + " - " + lblTen_Ma_d_nx.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtTK_du).Text.Trim(), "", false) != 0)
		{
			empty = empty + lblTK_du.Text + ": [" + ((TextBox)txtTK_du).Text + " - " + lblTen_TKdu.Text + "]; ";
		}
		if (Operators.CompareString(cboTheo_dvt.Text.Trim(), "", false) != 0)
		{
			empty = empty + lblTheo_dvt.Text + ": [" + cboTheo_dvt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text.Trim(), "", false) != 0)
		{
			empty = empty + lblMa_nt.Text + ": [" + ((TextBox)txtMa_Nt).Text + "]; ";
		}
		return empty;
	}

	private void SetDataSourceToCmb(ComboBox combobox, ArrayList ar, string member, string value)
	{
		ArrayList arrayList = new ArrayList();
		DmMaGd dmMaGd = new DmMaGd();
		dmMaGd.ma_ct = ((ListControl)cboLoai_pn).SelectedValue.ToString();
		dmMaGd.ma_gd = Conversions.ToString(0);
		dmMaGd.mo_ta = AsiaErp.Framework.Environment.getLangSysMessageResX("#SYS_ALL").value;
		dmMaGd.ngam_dinh = true;
		arrayList.Add(dmMaGd);
		if (ar != null)
		{
			foreach (DmMaGd item in ar)
			{
				arrayList.Add(item);
			}
		}
		combobox.DataSource = arrayList;
		((ListControl)combobox).DisplayMember = member;
		((ListControl)combobox).ValueMember = value;
		combobox.SelectedIndex = 0;
	}

	private void cboLoai_phieu_SelectedValueChanged(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			SetDataSourceToCmb(cboLoai_gd, AsiaErp.Framework.Environment.GetDmMagd(((ListControl)cboLoai_pn).SelectedValue.ToString()), "mo_ta", "ma_gd");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}
}
