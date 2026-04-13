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
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmINRptTHX01 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

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

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("txtSo_Ct2")]
	private TextBox _txtSo_Ct2;

	[AccessedThroughProperty("txtSo_Ct1")]
	private TextBox _txtSo_Ct1;

	[AccessedThroughProperty("lblSo_Ct2")]
	private Label _lblSo_Ct2;

	[AccessedThroughProperty("lblSo_Ct1")]
	private Label _lblSo_Ct1;

	[AccessedThroughProperty("lblTen_kho_nhap")]
	private Label _lblTen_kho_nhap;

	[AccessedThroughProperty("txtMa_Kho_nhap")]
	private AsTextBox _txtMa_Kho_nhap;

	[AccessedThroughProperty("lblMa_kho_nhap")]
	private Label _lblMa_kho_nhap;

	[AccessedThroughProperty("txtTk_Du")]
	private AsTextBox _txtTk_Du;

	[AccessedThroughProperty("lblTen_Tk_Du")]
	private Label _lblTen_Tk_Du;

	[AccessedThroughProperty("lblTk_Du")]
	private Label _lblTk_Du;

	[AccessedThroughProperty("lblTen_Tkvt")]
	private Label _lblTen_Tkvt;

	[AccessedThroughProperty("txtTk_vt")]
	private AsTextBox _txtTk_vt;

	[AccessedThroughProperty("lblTk_vt")]
	private Label _lblTk_vt;

	[AccessedThroughProperty("lblTen_dangNX")]
	private Label _lblTen_dangNX;

	[AccessedThroughProperty("txtMa_NX")]
	private AsTextBox _txtMa_NX;

	[AccessedThroughProperty("lblMa_NX")]
	private Label _lblMa_NX;

	[AccessedThroughProperty("lblTen_Hd")]
	private Label _lblTen_Hd;

	[AccessedThroughProperty("txtMa_Hd")]
	private AsTextBox _txtMa_Hd;

	[AccessedThroughProperty("lblMa_Hd")]
	private Label _lblMa_Hd;

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

	[AccessedThroughProperty("txtMa_Bp")]
	private AsTextBox _txtMa_Bp;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	[AccessedThroughProperty("lblPS_dc")]
	private Label _lblPS_dc;

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("txtMa_lo")]
	private AsTextBox _txtMa_lo;

	[AccessedThroughProperty("lblMa_lo")]
	private Label _lblMa_lo;

	[AccessedThroughProperty("lblTen_kho_xuat")]
	private Label _lblTen_kho_xuat;

	[AccessedThroughProperty("txtMa_kho_xuat")]
	private AsTextBox _txtMa_kho_xuat;

	[AccessedThroughProperty("lblMa_kho_xuat")]
	private Label _lblMa_kho_xuat;

	[AccessedThroughProperty("ChkPsdc")]
	private AsCheckBox _ChkPsdc;

	[AccessedThroughProperty("lblMa_loaiPx")]
	private Label _lblMa_loaiPx;

	[AccessedThroughProperty("cboLoai_px")]
	private ComboBox _cboLoai_px;

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

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

	internal virtual Label lblTen_kho_nhap
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kho_nhap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kho_nhap = value;
		}
	}

	internal virtual AsTextBox txtMa_Kho_nhap
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Kho_nhap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Kho_nhap = value;
		}
	}

	internal virtual Label lblMa_kho_nhap
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kho_nhap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kho_nhap = value;
		}
	}

	private virtual AsTextBox txtTk_Du
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Du = value;
		}
	}

	private virtual Label lblTen_Tk_Du
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_Du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_Du = value;
		}
	}

	private virtual Label lblTk_Du
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Du = value;
		}
	}

	internal virtual Label lblTen_Tkvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tkvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tkvt = value;
		}
	}

	private virtual AsTextBox txtTk_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_vt = value;
		}
	}

	private virtual Label lblTk_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_vt = value;
		}
	}

	internal virtual Label lblTen_dangNX
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_dangNX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_dangNX = value;
		}
	}

	internal virtual AsTextBox txtMa_NX
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_NX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_NX = value;
		}
	}

	internal virtual Label lblMa_NX
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_NX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_NX = value;
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

	internal virtual AsTextBox txtMa_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Hd = value;
		}
	}

	internal virtual Label lblMa_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Hd = value;
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

	internal virtual Label lblMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Bp = value;
		}
	}

	internal virtual Label lblPS_dc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPS_dc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPS_dc = value;
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

	internal virtual Label lblTen_kho_xuat
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kho_xuat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kho_xuat = value;
		}
	}

	internal virtual AsTextBox txtMa_kho_xuat
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kho_xuat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kho_xuat = value;
		}
	}

	internal virtual Label lblMa_kho_xuat
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kho_xuat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kho_xuat = value;
		}
	}

	internal virtual AsCheckBox ChkPsdc
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkPsdc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkPsdc = value;
		}
	}

	internal virtual Label lblMa_loaiPx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_loaiPx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_loaiPx = value;
		}
	}

	internal virtual ComboBox cboLoai_px
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_px;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_px = value;
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

	public frmINRptTHX01(string MenuId)
		: base(MenuId)
	{
		__ENCAddToList(this);
		InitializeComponent();
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
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
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
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_265a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2664: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		txtSo_Ct2 = new TextBox();
		txtSo_Ct1 = new TextBox();
		lblSo_Ct2 = new Label();
		lblSo_Ct1 = new Label();
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblMa_nhvt = new Label();
		txtMa_nhvt = new AsTextBox();
		lblTen_nhvt = new Label();
		lblTen_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		lblTen_Hd = new Label();
		txtMa_Hd = new AsTextBox();
		lblMa_Hd = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_Bp = new Label();
		lblTen_dangNX = new Label();
		txtMa_NX = new AsTextBox();
		lblMa_NX = new Label();
		lblTen_Tkvt = new Label();
		txtTk_vt = new AsTextBox();
		lblTk_vt = new Label();
		txtTk_Du = new AsTextBox();
		lblTen_Tk_Du = new Label();
		lblTk_Du = new Label();
		lblTen_kho_nhap = new Label();
		txtMa_Kho_nhap = new AsTextBox();
		lblMa_kho_nhap = new Label();
		lblTen_kho_xuat = new Label();
		txtMa_kho_xuat = new AsTextBox();
		lblMa_kho_xuat = new Label();
		lblTen_lo = new Label();
		txtMa_lo = new AsTextBox();
		lblMa_lo = new Label();
		lblPS_dc = new Label();
		ChkPsdc = new AsCheckBox();
		cboLoai_px = new ComboBox();
		lblMa_loaiPx = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(824, 561);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_loaiPx);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai_px);
		((Control)tabFilter).Controls.Add((Control)(object)ChkPsdc);
		((Control)tabFilter).Controls.Add((Control)(object)lblPS_dc);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lo);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_lo);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_lo);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho_xuat);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho_xuat);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho_xuat);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho_nhap);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Kho_nhap);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho_nhap);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk_Du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk_Du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk_Du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tkvt);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_dangNX);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_NX);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_NX);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_Ct2);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_Ct1);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct2);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct1);
		TabPage obj = tabFilter;
		size = new Size(816, 532);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_Ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_Ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_NX, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_NX, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_dangNX, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tkvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk_Du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk_Du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk_Du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho_nhap, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Kho_nhap, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho_nhap, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho_xuat, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho_xuat, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho_xuat, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPS_dc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkPsdc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai_px, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_loaiPx, 0);
		Label obj2 = lbl2;
		Point location = new Point(280, 81);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 586);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(299, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 586);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(458, 23);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 23;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(209, 77);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(113, 77);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(24, 81);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(113, 24);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 22;
		((Control)cboMau_bc).TabStop = false;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(113, 465);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 18;
		Label obj9 = lblMauBC;
		location = new Point(158, 464);
		((Control)obj9).Location = location;
		RadioButton obj10 = optVND;
		location = new Point(245, 463);
		((Control)obj10).Location = location;
		((Control)optVND).TabIndex = 19;
		RadioButton obj11 = optNt;
		location = new Point(299, 464);
		((Control)obj11).Location = location;
		((Control)optNt).TabIndex = 20;
		Label obj12 = lblMa_nt;
		location = new Point(24, 467);
		((Control)obj12).Location = location;
		Button obj13 = cmdOk;
		location = new Point(27, 497);
		((Control)obj13).Location = location;
		((Control)cmdOk).TabIndex = 21;
		Label obj14 = lblTieu_de;
		location = new Point(24, 55);
		((Control)obj14).Location = location;
		TextBox obj15 = txtTieu_De;
		location = new Point(113, 51);
		((Control)obj15).Location = location;
		((Control)txtTieu_De).TabIndex = 24;
		((Control)txtTieu_De).TabStop = false;
		crvReportViewer.ActiveViewIndex = -1;
		((UserControl)crvReportViewer).BorderStyle = (BorderStyle)1;
		crvReportViewer.DisplayGroupTree = false;
		((Control)crvReportViewer).Dock = (DockStyle)5;
		CrystalReportViewer obj16 = crvReportViewer;
		location = new Point(0, 0);
		((Control)obj16).Location = location;
		((Control)crvReportViewer).Name = "crvReportViewer";
		crvReportViewer.SelectionFormula = "";
		crvReportViewer.ShowRefreshButton = false;
		CrystalReportViewer obj17 = crvReportViewer;
		size = new Size(782, 459);
		((Control)obj17).Size = size;
		((Control)crvReportViewer).TabIndex = 0;
		crvReportViewer.ViewTimeSelectionFormula = "";
		TextBox obj18 = txtSo_Ct2;
		location = new Point(284, 130);
		((Control)obj18).Location = location;
		((Control)txtSo_Ct2).Name = "txtSo_Ct2";
		TextBox obj19 = txtSo_Ct2;
		size = new Size(82, 20);
		((Control)obj19).Size = size;
		((Control)txtSo_Ct2).TabIndex = 5;
		TextBox obj20 = txtSo_Ct1;
		location = new Point(113, 130);
		((Control)obj20).Location = location;
		((Control)txtSo_Ct1).Name = "txtSo_Ct1";
		TextBox obj21 = txtSo_Ct1;
		size = new Size(82, 20);
		((Control)obj21).Size = size;
		((Control)txtSo_Ct1).TabIndex = 4;
		lblSo_Ct2.AutoSize = true;
		Label obj22 = lblSo_Ct2;
		location = new Point(219, 134);
		((Control)obj22).Location = location;
		((Control)lblSo_Ct2).Name = "lblSo_Ct2";
		Label obj23 = lblSo_Ct2;
		size = new Size(40, 13);
		((Control)obj23).Size = size;
		((Control)lblSo_Ct2).TabIndex = 1023;
		lblSo_Ct2.Text = "đến số";
		lblSo_Ct1.AutoSize = true;
		Label obj24 = lblSo_Ct1;
		location = new Point(24, 134);
		((Control)obj24).Location = location;
		((Control)lblSo_Ct1).Name = "lblSo_Ct1";
		Label obj25 = lblSo_Ct1;
		size = new Size(64, 13);
		((Control)obj25).Size = size;
		((Control)lblSo_Ct1).TabIndex = 1022;
		lblSo_Ct1.Text = "Chứng từ số";
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj26 = lblTen_Kh;
		location = new Point(201, 160);
		((Control)obj26).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj27 = lblTen_Kh;
		size = new Size(366, 13);
		((Control)obj27).Size = size;
		((Control)lblTen_Kh).TabIndex = 1033;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = false;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_Kh;
		location = new Point(113, 156);
		((Control)asTextBox2).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		txtMa_Kh.LookupWhereCondition = "isKh=1";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		AsTextBox asTextBox3 = txtMa_Kh;
		size = new Size(82, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_Kh).TabIndex = 6;
		txtMa_Kh.UseAutoCompleteSource = true;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj28 = lblMa_Kh;
		location = new Point(24, 160);
		((Control)obj28).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj29 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj29).Size = size;
		((Control)lblMa_Kh).TabIndex = 1032;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblMa_nhvt.AutoSize = true;
		lblMa_nhvt.ImeMode = (ImeMode)0;
		Label obj30 = lblMa_nhvt;
		location = new Point(24, 212);
		((Control)obj30).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj31 = lblMa_nhvt;
		size = new Size(65, 13);
		((Control)obj31).Size = size;
		((Control)lblMa_nhvt).TabIndex = 1038;
		lblMa_nhvt.Text = "Nhóm vật tư";
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_nhvt;
		location = new Point(113, 208);
		((Control)asTextBox4).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((TextBoxBase)txtMa_nhvt).MaxLength = 8;
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_nhvt;
		AsTextBox asTextBox5 = txtMa_nhvt;
		size = new Size(82, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_nhvt).TabIndex = 8;
		((Control)txtMa_nhvt).Tag = "MA_NHVT";
		txtMa_nhvt.UseAutoCompleteSource = true;
		lblTen_nhvt.ImeMode = (ImeMode)0;
		Label obj32 = lblTen_nhvt;
		location = new Point(201, 212);
		((Control)obj32).Location = location;
		((Control)lblTen_nhvt).Name = "lblTen_nhvt";
		Label obj33 = lblTen_nhvt;
		size = new Size(366, 13);
		((Control)obj33).Size = size;
		((Control)lblTen_nhvt).TabIndex = 1039;
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj34 = lblTen_vt;
		location = new Point(201, 186);
		((Control)obj34).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj35 = lblTen_vt;
		size = new Size(366, 13);
		((Control)obj35).Size = size;
		((Control)lblTen_vt).TabIndex = 1037;
		((TextBox)txtMa_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_vt;
		location = new Point(113, 182);
		((Control)asTextBox6).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox7 = txtMa_vt;
		size = new Size(82, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_vt).TabIndex = 7;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_vt.AutoSize = true;
		lblMa_vt.ImeMode = (ImeMode)0;
		Label obj36 = lblMa_vt;
		location = new Point(24, 186);
		((Control)obj36).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj37 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj37).Size = size;
		((Control)lblMa_vt).TabIndex = 1036;
		lblMa_vt.Text = "Mã vật tư";
		lblMa_vt.TextAlign = (ContentAlignment)16;
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj38 = lblTen_Hd;
		location = new Point(201, 316);
		((Control)obj38).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj39 = lblTen_Hd;
		size = new Size(366, 13);
		((Control)obj39).Size = size;
		((Control)lblTen_Hd).TabIndex = 1050;
		lblTen_Hd.TextAlign = (ContentAlignment)16;
		txtMa_Hd.AutoLookup = true;
		txtMa_Hd.AutoValid = false;
		((TextBoxBase)txtMa_Hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_Hd;
		location = new Point(113, 312);
		((Control)asTextBox8).Location = location;
		txtMa_Hd.LookupCodeName = "MA_HD";
		((Control)txtMa_Hd).Name = "txtMa_Hd";
		txtMa_Hd.NameControl = lblTen_Hd;
		AsTextBox asTextBox9 = txtMa_Hd;
		size = new Size(82, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_Hd).TabIndex = 12;
		txtMa_Hd.UseAutoCompleteSource = true;
		lblMa_Hd.AutoSize = true;
		lblMa_Hd.ImeMode = (ImeMode)0;
		Label obj40 = lblMa_Hd;
		location = new Point(24, 316);
		((Control)obj40).Location = location;
		((Control)lblMa_Hd).Name = "lblMa_Hd";
		Label obj41 = lblMa_Hd;
		size = new Size(71, 13);
		((Control)obj41).Size = size;
		((Control)lblMa_Hd).TabIndex = 1049;
		lblMa_Hd.Text = "Mã hợp đồng";
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj42 = lblTen_Bp;
		location = new Point(201, 290);
		((Control)obj42).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj43 = lblTen_Bp;
		size = new Size(366, 13);
		((Control)obj43).Size = size;
		((Control)lblTen_Bp).TabIndex = 1048;
		lblTen_Bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_Bp;
		location = new Point(113, 286);
		((Control)asTextBox10).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox11 = txtMa_Bp;
		size = new Size(82, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_Bp).TabIndex = 11;
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_Bp.AutoSize = true;
		lblMa_Bp.ImeMode = (ImeMode)0;
		Label obj44 = lblMa_Bp;
		location = new Point(24, 290);
		((Control)obj44).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj45 = lblMa_Bp;
		size = new Size(64, 13);
		((Control)obj45).Size = size;
		((Control)lblMa_Bp).TabIndex = 1047;
		lblMa_Bp.Text = "Mã bộ phận";
		lblTen_dangNX.ImeMode = (ImeMode)0;
		Label obj46 = lblTen_dangNX;
		location = new Point(201, 342);
		((Control)obj46).Location = location;
		((Control)lblTen_dangNX).Name = "lblTen_dangNX";
		Label obj47 = lblTen_dangNX;
		size = new Size(366, 13);
		((Control)obj47).Size = size;
		((Control)lblTen_dangNX).TabIndex = 1053;
		lblTen_dangNX.TextAlign = (ContentAlignment)16;
		txtMa_NX.AutoLookup = true;
		txtMa_NX.AutoValid = false;
		((TextBoxBase)txtMa_NX).BackColor = SystemColors.Info;
		((TextBox)txtMa_NX).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_NX;
		location = new Point(113, 338);
		((Control)asTextBox12).Location = location;
		txtMa_NX.LookupCodeName = "MA_NX";
		txtMa_NX.LookupWhereCondition = "ma_httt like 'NX%'";
		((Control)txtMa_NX).Name = "txtMa_NX";
		txtMa_NX.NameControl = lblTen_dangNX;
		AsTextBox asTextBox13 = txtMa_NX;
		size = new Size(82, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_NX).TabIndex = 13;
		((Control)txtMa_NX).Tag = "MA_NX";
		txtMa_NX.UseAutoCompleteSource = true;
		lblMa_NX.AutoSize = true;
		lblMa_NX.ImeMode = (ImeMode)0;
		Label obj48 = lblMa_NX;
		location = new Point(24, 342);
		((Control)obj48).Location = location;
		((Control)lblMa_NX).Name = "lblMa_NX";
		Label obj49 = lblMa_NX;
		size = new Size(72, 13);
		((Control)obj49).Size = size;
		((Control)lblMa_NX).TabIndex = 1052;
		lblMa_NX.Text = "Mã dạng N/X";
		lblTen_Tkvt.ImeMode = (ImeMode)0;
		Label obj50 = lblTen_Tkvt;
		location = new Point(201, 238);
		((Control)obj50).Location = location;
		((Control)lblTen_Tkvt).Name = "lblTen_Tkvt";
		Label obj51 = lblTen_Tkvt;
		size = new Size(366, 13);
		((Control)obj51).Size = size;
		((Control)lblTen_Tkvt).TabIndex = 1056;
		((TextBox)txtTk_vt).AutoCompleteMode = (AutoCompleteMode)1;
		((TextBox)txtTk_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk_vt.AutoLookup = true;
		txtTk_vt.AutoValid = false;
		((TextBoxBase)txtTk_vt).BackColor = SystemColors.Info;
		((TextBox)txtTk_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtTk_vt;
		location = new Point(113, 234);
		((Control)asTextBox14).Location = location;
		txtTk_vt.LookupCodeName = "TK";
		((Control)txtTk_vt).Name = "txtTk_vt";
		txtTk_vt.NameControl = lblTen_Tkvt;
		AsTextBox asTextBox15 = txtTk_vt;
		size = new Size(82, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtTk_vt).TabIndex = 9;
		((Control)txtTk_vt).Tag = "@pTk";
		txtTk_vt.UseAutoCompleteSource = true;
		lblTk_vt.AutoSize = true;
		lblTk_vt.ImeMode = (ImeMode)0;
		Label obj52 = lblTk_vt;
		location = new Point(24, 238);
		((Control)obj52).Location = location;
		((Control)lblTk_vt).Name = "lblTk_vt";
		Label obj53 = lblTk_vt;
		size = new Size(72, 13);
		((Control)obj53).Size = size;
		((Control)lblTk_vt).TabIndex = 1055;
		lblTk_vt.Text = "Tài khoản VT";
		((TextBox)txtTk_Du).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk_Du.AutoLookup = true;
		txtTk_Du.AutoValid = false;
		((TextBoxBase)txtTk_Du).BackColor = SystemColors.Info;
		((TextBox)txtTk_Du).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox16 = txtTk_Du;
		location = new Point(113, 260);
		((Control)asTextBox16).Location = location;
		txtTk_Du.LookupCodeName = "TK";
		((Control)txtTk_Du).Name = "txtTk_Du";
		txtTk_Du.NameControl = lblTen_Tk_Du;
		AsTextBox asTextBox17 = txtTk_Du;
		size = new Size(82, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtTk_Du).TabIndex = 10;
		((Control)txtTk_Du).Tag = "@pTk";
		txtTk_Du.UseAutoCompleteSource = true;
		lblTen_Tk_Du.ImeMode = (ImeMode)0;
		Label obj54 = lblTen_Tk_Du;
		location = new Point(201, 264);
		((Control)obj54).Location = location;
		((Control)lblTen_Tk_Du).Name = "lblTen_Tk_Du";
		Label obj55 = lblTen_Tk_Du;
		size = new Size(366, 13);
		((Control)obj55).Size = size;
		((Control)lblTen_Tk_Du).TabIndex = 1059;
		lblTen_Tk_Du.TextAlign = (ContentAlignment)16;
		lblTk_Du.AutoSize = true;
		lblTk_Du.ImeMode = (ImeMode)0;
		Label obj56 = lblTk_Du;
		location = new Point(24, 264);
		((Control)obj56).Location = location;
		((Control)lblTk_Du).Name = "lblTk_Du";
		Label obj57 = lblTk_Du;
		size = new Size(76, 13);
		((Control)obj57).Size = size;
		((Control)lblTk_Du).TabIndex = 1058;
		lblTk_Du.Text = "Tài khoản đ/ư";
		lblTen_kho_nhap.ImeMode = (ImeMode)0;
		Label obj58 = lblTen_kho_nhap;
		location = new Point(201, 368);
		((Control)obj58).Location = location;
		((Control)lblTen_kho_nhap).Name = "lblTen_kho_nhap";
		Label obj59 = lblTen_kho_nhap;
		size = new Size(366, 13);
		((Control)obj59).Size = size;
		((Control)lblTen_kho_nhap).TabIndex = 1062;
		lblTen_kho_nhap.TextAlign = (ContentAlignment)16;
		txtMa_Kho_nhap.AutoLookup = true;
		txtMa_Kho_nhap.AutoValid = false;
		((TextBoxBase)txtMa_Kho_nhap).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kho_nhap).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox18 = txtMa_Kho_nhap;
		location = new Point(113, 364);
		((Control)asTextBox18).Location = location;
		txtMa_Kho_nhap.LookupCodeName = "MA_KHO";
		((Control)txtMa_Kho_nhap).Name = "txtMa_Kho_nhap";
		txtMa_Kho_nhap.NameControl = lblTen_kho_nhap;
		AsTextBox asTextBox19 = txtMa_Kho_nhap;
		size = new Size(82, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtMa_Kho_nhap).TabIndex = 14;
		((Control)txtMa_Kho_nhap).Tag = "MA_KHO";
		txtMa_Kho_nhap.UseAutoCompleteSource = true;
		lblMa_kho_nhap.AutoSize = true;
		lblMa_kho_nhap.ImeMode = (ImeMode)0;
		Label obj60 = lblMa_kho_nhap;
		location = new Point(24, 368);
		((Control)obj60).Location = location;
		((Control)lblMa_kho_nhap).Name = "lblMa_kho_nhap";
		Label obj61 = lblMa_kho_nhap;
		size = new Size(70, 13);
		((Control)obj61).Size = size;
		((Control)lblMa_kho_nhap).TabIndex = 1061;
		lblMa_kho_nhap.Text = "Mã kho nhập";
		lblTen_kho_xuat.ImeMode = (ImeMode)0;
		Label obj62 = lblTen_kho_xuat;
		location = new Point(201, 394);
		((Control)obj62).Location = location;
		((Control)lblTen_kho_xuat).Name = "lblTen_kho_xuat";
		Label obj63 = lblTen_kho_xuat;
		size = new Size(366, 13);
		((Control)obj63).Size = size;
		((Control)lblTen_kho_xuat).TabIndex = 1065;
		lblTen_kho_xuat.TextAlign = (ContentAlignment)16;
		txtMa_kho_xuat.AutoLookup = true;
		txtMa_kho_xuat.AutoValid = false;
		((TextBoxBase)txtMa_kho_xuat).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho_xuat).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtMa_kho_xuat;
		location = new Point(113, 390);
		((Control)asTextBox20).Location = location;
		txtMa_kho_xuat.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho_xuat).Name = "txtMa_kho_xuat";
		txtMa_kho_xuat.NameControl = lblTen_kho_xuat;
		AsTextBox asTextBox21 = txtMa_kho_xuat;
		size = new Size(82, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMa_kho_xuat).TabIndex = 15;
		((Control)txtMa_kho_xuat).Tag = "MA_KHO";
		txtMa_kho_xuat.UseAutoCompleteSource = true;
		lblMa_kho_xuat.AutoSize = true;
		lblMa_kho_xuat.ImeMode = (ImeMode)0;
		Label obj64 = lblMa_kho_xuat;
		location = new Point(24, 394);
		((Control)obj64).Location = location;
		((Control)lblMa_kho_xuat).Name = "lblMa_kho_xuat";
		Label obj65 = lblMa_kho_xuat;
		size = new Size(66, 13);
		((Control)obj65).Size = size;
		((Control)lblMa_kho_xuat).TabIndex = 1064;
		lblMa_kho_xuat.Text = "Mã kho xuất";
		lblTen_lo.ImeMode = (ImeMode)0;
		Label obj66 = lblTen_lo;
		location = new Point(201, 420);
		((Control)obj66).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj67 = lblTen_lo;
		size = new Size(366, 13);
		((Control)obj67).Size = size;
		((Control)lblTen_lo).TabIndex = 1068;
		lblTen_lo.TextAlign = (ContentAlignment)16;
		txtMa_lo.AutoLookup = true;
		txtMa_lo.AutoValid = false;
		((TextBoxBase)txtMa_lo).BackColor = SystemColors.Info;
		((TextBox)txtMa_lo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox22 = txtMa_lo;
		location = new Point(113, 416);
		((Control)asTextBox22).Location = location;
		txtMa_lo.LookupCodeName = "MA_LO";
		((Control)txtMa_lo).Name = "txtMa_lo";
		txtMa_lo.NameControl = lblTen_lo;
		AsTextBox asTextBox23 = txtMa_lo;
		size = new Size(82, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMa_lo).TabIndex = 16;
		((Control)txtMa_lo).Tag = "";
		txtMa_lo.UseAutoCompleteSource = true;
		lblMa_lo.AutoSize = true;
		lblMa_lo.ImeMode = (ImeMode)0;
		Label obj68 = lblMa_lo;
		location = new Point(24, 420);
		((Control)obj68).Location = location;
		((Control)lblMa_lo).Name = "lblMa_lo";
		Label obj69 = lblMa_lo;
		size = new Size(33, 13);
		((Control)obj69).Size = size;
		((Control)lblMa_lo).TabIndex = 1067;
		lblMa_lo.Text = "Mã lô";
		lblPS_dc.AutoSize = true;
		lblPS_dc.ImeMode = (ImeMode)0;
		Label obj70 = lblPS_dc;
		location = new Point(24, 444);
		((Control)obj70).Location = location;
		((Control)lblPS_dc).Name = "lblPS_dc";
		Label obj71 = lblPS_dc;
		size = new Size(83, 13);
		((Control)obj71).Size = size;
		((Control)lblPS_dc).TabIndex = 1069;
		lblPS_dc.Text = "PS điều chuyển";
		((ButtonBase)ChkPsdc).AutoSize = true;
		ChkPsdc.Checked = true;
		((CheckBox)ChkPsdc).CheckState = (CheckState)1;
		AsCheckBox chkPsdc = ChkPsdc;
		location = new Point(113, 442);
		((Control)chkPsdc).Location = location;
		((Control)ChkPsdc).Name = "ChkPsdc";
		AsCheckBox chkPsdc2 = ChkPsdc;
		size = new Size(157, 17);
		((Control)chkPsdc2).Size = size;
		((Control)ChkPsdc).TabIndex = 17;
		((ButtonBase)ChkPsdc).Text = "Tính phát sinh điều chuyển";
		((ButtonBase)ChkPsdc).UseVisualStyleBackColor = true;
		((ListControl)cboLoai_px).FormattingEnabled = true;
		ComboBox obj72 = cboLoai_px;
		location = new Point(113, 103);
		((Control)obj72).Location = location;
		((Control)cboLoai_px).Name = "cboLoai_px";
		ComboBox obj73 = cboLoai_px;
		size = new Size(253, 21);
		((Control)obj73).Size = size;
		((Control)cboLoai_px).TabIndex = 3;
		lblMa_loaiPx.AutoSize = true;
		Label obj74 = lblMa_loaiPx;
		location = new Point(24, 107);
		((Control)obj74).Location = location;
		((Control)lblMa_loaiPx).Name = "lblMa_loaiPx";
		Label obj75 = lblMa_loaiPx;
		size = new Size(79, 13);
		((Control)obj75).Size = size;
		((Control)lblMa_loaiPx).TabIndex = 1072;
		lblMa_loaiPx.Text = "Loại phiếu xuất";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(824, 583);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmINRptTHX01";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		cboLoai_px.DataSource = AsiaErp.Framework.Environment.GetDanhSachChungTuXuat();
		((ListControl)cboLoai_px).DisplayMember = "Value";
		((ListControl)cboLoai_px).ValueMember = "Key";
		cboLoai_px.SelectedIndex = 0;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(txtSo_Ct1.Text);
		arrayList.Add(txtSo_Ct2.Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_px).SelectedValue));
		arrayList.Add(((TextBox)txtMa_Kh).Text);
		arrayList.Add(((TextBox)txtMa_Hd).Text);
		arrayList.Add(((TextBox)txtMa_NX).Text);
		arrayList.Add(((TextBox)txtMa_kho_xuat).Text);
		arrayList.Add(((TextBox)txtMa_Kho_nhap).Text);
		arrayList.Add(((TextBox)txtMa_lo).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add(((TextBox)txtTk_vt).Text);
		arrayList.Add(((TextBox)txtMa_Bp).Text);
		arrayList.Add(ChkPsdc.TextValue);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(((TextBox)txtTk_Du).Text);
		if (optVND.Checked)
		{
			arrayList.Add("0");
		}
		if (optNt.Checked)
		{
			arrayList.Add("1");
		}
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
		arrayList.Add(dataRowView["ma_vt"].ToString());
		arrayList.Add(((TextBox)txtMa_kho_xuat).Text);
		arrayList.Add(((TextBox)txtMa_Kho_nhap).Text);
		arrayList.Add(((TextBox)txtMa_lo).Text);
		arrayList.Add(((TextBox)txtMa_Kh).Text);
		arrayList.Add(((TextBox)txtMa_Bp).Text);
		arrayList.Add(((TextBox)txtMa_Hd).Text);
		arrayList.Add(((TextBox)txtTk_Du).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_px).SelectedValue));
		arrayList.Add("2");
		arrayList.Add(ChkPsdc.TextValue);
		filterCondition4title = dataRowView["ma_vt"].ToString().Trim() + " - " + dataRowView["ten_vt"].ToString().Trim();
		if (!base.MyFomularFields.Contains("ngay_ct2"))
		{
			base.MyFomularFields.Add("ngay_ct2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		}
		if (!base.MyFomularFields.Contains("ngay_ct1"))
		{
			base.MyFomularFields.Add("ngay_ct1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		}
		return arrayList;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (cboLoai_px.SelectedIndex != -1)
		{
			text = text + lblMa_loaiPx.Text + ": " + cboLoai_px.SelectedText + ";";
		}
		if (Operators.CompareString(txtSo_Ct1.Text.Trim(), "", false) != 0)
		{
			text = text + lblSo_Ct1.Text + ": " + txtSo_Ct1.Text.Trim();
		}
		if (Operators.CompareString(txtSo_Ct2.Text.Trim(), "", false) != 0)
		{
			text = text + lblSo_Ct2.Text + ": " + txtSo_Ct2.Text.Trim();
		}
		if (Operators.CompareString(((TextBox)txtMa_Kh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Kh.Text + ": " + ((TextBox)txtMa_Kh).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
		{
			text = text + lblMa_vt.Text + ": " + ((TextBox)txtMa_vt).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhvt).Text, "", false) != 0)
		{
			text = text + lblMa_nhvt.Text + ": " + ((TextBox)txtMa_nhvt).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtTk_vt).Text.Trim(), "", false) != 0)
		{
			text = text + lblTk_vt.Text + ": " + ((TextBox)txtTk_vt).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtTk_Du).Text.Trim(), "", false) != 0)
		{
			text = text + lblTk_Du.Text + ": " + ((TextBox)txtTk_Du).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Bp).Text.Trim(), "", false) != 0)
		{
			text = text + lblTk_Du.Text + ": " + ((TextBox)txtMa_Bp).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Hd).Text, "", false) != 0)
		{
			text = text + lblMa_Hd.Text + ": " + ((TextBox)txtMa_Hd).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_NX).Text, "", false) != 0)
		{
			text = text + lblMa_NX.Text + ": " + ((TextBox)txtMa_NX).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Kho_nhap).Text, "", false) != 0)
		{
			text = text + lblMa_kho_nhap.Text + ": " + ((TextBox)txtMa_Kho_nhap).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho_xuat).Text, "", false) != 0)
		{
			text = text + lblMa_kho_xuat.Text + ": " + ((TextBox)txtMa_kho_xuat).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_lo).Text, "", false) != 0)
		{
			text = text + lblMa_lo.Text + ": " + ((TextBox)txtMa_lo).Text + "; ";
		}
		if (Conversions.ToBoolean(ChkPsdc.Checked))
		{
			text = text + ((ButtonBase)ChkPsdc).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
		}
		return text;
	}
}
