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

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmINRptTHN01 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblNh_ncc")]
	private Label _lblNh_ncc;

	[AccessedThroughProperty("chkPS_dc")]
	private AsCheckBox _chkPS_dc;

	[AccessedThroughProperty("lblTen_tk_vt")]
	private Label _lblTen_tk_vt;

	[AccessedThroughProperty("txtTK_vt")]
	private AsTextBox _txtTK_vt;

	[AccessedThroughProperty("lblTK_vt")]
	private Label _lblTK_vt;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("lblTen_nh_vt")]
	private Label _lblTen_nh_vt;

	[AccessedThroughProperty("txtMa_nh_vt")]
	private AsTextBox _txtMa_nh_vt;

	[AccessedThroughProperty("lblMa_nh_vt")]
	private Label _lblMa_nh_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblTen_ncc")]
	private Label _lblTen_ncc;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

	[AccessedThroughProperty("txtMa_ncc")]
	private AsTextBox _txtMa_ncc;

	[AccessedThroughProperty("lblMa_ncc")]
	private Label _lblMa_ncc;

	[AccessedThroughProperty("txtSo_CT2")]
	private TextBox _txtSo_CT2;

	[AccessedThroughProperty("lblSo_ct2")]
	private Label _lblSo_ct2;

	[AccessedThroughProperty("txtSo_CT1")]
	private TextBox _txtSo_CT1;

	[AccessedThroughProperty("lblSo_ct1")]
	private Label _lblSo_ct1;

	[AccessedThroughProperty("cboLoai_pn")]
	private ComboBox _cboLoai_pn;

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("txtMa_vitri")]
	private AsTextBox _txtMa_vitri;

	[AccessedThroughProperty("lblMa_vitri")]
	private Label _lblMa_vitri;

	[AccessedThroughProperty("lblTen_tk_du")]
	private Label _lblTen_tk_du;

	[AccessedThroughProperty("txtTK_du")]
	private AsTextBox _txtTK_du;

	[AccessedThroughProperty("lblTK_du")]
	private Label _lblTK_du;

	[AccessedThroughProperty("lblTen_nx")]
	private Label _lblTen_nx;

	[AccessedThroughProperty("txtMa_nx")]
	private AsTextBox _txtMa_nx;

	[AccessedThroughProperty("lblMa_nx")]
	private Label _lblMa_nx;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("lblLoai_pn")]
	private Label _lblLoai_pn;

	[AccessedThroughProperty("lblDVT")]
	private Label _lblDVT;

	[AccessedThroughProperty("cboDVT")]
	private ComboBox _cboDVT;

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

	internal virtual Label lblNh_ncc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNh_ncc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNh_ncc = value;
		}
	}

	internal virtual AsCheckBox chkPS_dc
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkPS_dc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkPS_dc = value;
		}
	}

	internal virtual Label lblTen_tk_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk_vt = value;
		}
	}

	internal virtual AsTextBox txtTK_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_vt = value;
		}
	}

	internal virtual Label lblTK_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_vt = value;
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

	internal virtual Label lblTen_nh_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nh_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nh_vt = value;
		}
	}

	internal virtual AsTextBox txtMa_nh_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nh_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nh_vt = value;
		}
	}

	internal virtual Label lblMa_nh_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nh_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nh_vt = value;
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

	internal virtual Label lblTen_ncc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ncc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ncc = value;
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

	internal virtual AsTextBox txtMa_ncc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ncc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_ncc = value;
		}
	}

	internal virtual Label lblMa_ncc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_ncc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_ncc = value;
		}
	}

	internal virtual TextBox txtSo_CT2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_CT2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_CT2 = value;
		}
	}

	internal virtual Label lblSo_ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_ct2 = value;
		}
	}

	internal virtual TextBox txtSo_CT1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_CT1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_CT1 = value;
		}
	}

	internal virtual Label lblSo_ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_ct1 = value;
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
			_cboLoai_pn = value;
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

	internal virtual Label lblTen_tk_du
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk_du = value;
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

	internal virtual Label lblTen_nx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nx = value;
		}
	}

	internal virtual AsTextBox txtMa_nx
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nx = value;
		}
	}

	internal virtual Label lblMa_nx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nx = value;
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

	internal virtual Label lblDVT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDVT = value;
		}
	}

	internal virtual ComboBox cboDVT
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboDVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboDVT = value;
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

	public frmINRptTHN01(string menuID)
		: base(menuID)
	{
		__ENCAddToList(this);
		InitializeComponent();
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
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
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
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
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
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_2541: Unknown result type (might be due to invalid IL or missing references)
		//IL_254b: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		lblNh_ncc = new Label();
		chkPS_dc = new AsCheckBox();
		lblTen_tk_vt = new Label();
		txtTK_vt = new AsTextBox();
		lblTK_vt = new Label();
		lblTen_kho = new Label();
		txtMa_kho = new AsTextBox();
		lblMa_kho = new Label();
		lblTen_nh_vt = new Label();
		txtMa_nh_vt = new AsTextBox();
		lblMa_nh_vt = new Label();
		lblTen_vt = new Label();
		lblTen_ncc = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		txtMa_hd = new AsTextBox();
		lblTen_hd = new Label();
		lblMa_hd = new Label();
		txtMa_ncc = new AsTextBox();
		lblMa_ncc = new Label();
		txtSo_CT2 = new TextBox();
		lblSo_ct2 = new Label();
		txtSo_CT1 = new TextBox();
		lblSo_ct1 = new Label();
		cboLoai_pn = new ComboBox();
		lblTen_vitri = new Label();
		txtMa_vitri = new AsTextBox();
		lblMa_vitri = new Label();
		lblTen_bp = new Label();
		txtMa_bp = new AsTextBox();
		lblMa_bp = new Label();
		lblTen_nx = new Label();
		txtMa_nx = new AsTextBox();
		lblMa_nx = new Label();
		lblTen_tk_du = new Label();
		txtTK_du = new AsTextBox();
		lblTK_du = new Label();
		lblLoai_pn = new Label();
		lblDVT = new Label();
		cboDVT = new ComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(844, 583);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 1;
		((Control)tabFilter).Controls.Add((Control)(object)lblDVT);
		((Control)tabFilter).Controls.Add((Control)(object)cboDVT);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoai_pn);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tk_du);
		((Control)tabFilter).Controls.Add((Control)(object)txtTK_du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTK_du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nx);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nx);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nx);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai_pn);
		((Control)tabFilter).Controls.Add((Control)(object)lblNh_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)chkPS_dc);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tk_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtTK_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTK_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nh_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nh_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nh_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_ncc);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_CT2);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_ct2);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_CT1);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_ct1);
		TabPage obj = tabFilter;
		size = new Size(836, 554);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_CT1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_CT2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nh_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nh_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nh_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tk_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)chkPS_dc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNh_ncc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai_pn, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nx, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nx, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nx, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK_du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK_du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tk_du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoai_pn, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboDVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDVT, 0);
		Label obj2 = lbl2;
		Point location = new Point(301, 82);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 702);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 26;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(320, 78);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 702);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 25;
		Button obj5 = cmdModifyReport;
		location = new Point(475, 23);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 22;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(230, 78);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(130, 78);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(33, 82);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(130, 25);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 21;
		Label obj9 = lblMau_bc;
		location = new Point(33, 28);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(130, 474);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 18;
		Label obj10 = lblMauBC;
		location = new Point(170, 474);
		((Control)obj10).Location = location;
		RadioButton obj11 = optVND;
		location = new Point(257, 474);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 29;
		RadioButton obj12 = optNt;
		location = new Point(311, 474);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 19;
		Label obj13 = lblMa_nt;
		location = new Point(33, 479);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(33, 514);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 20;
		Label obj15 = lblTieu_de;
		location = new Point(33, 56);
		((Control)obj15).Location = location;
		((Control)lblTieu_de).TabIndex = 23;
		TextBox obj16 = txtTieu_De;
		location = new Point(130, 52);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 24;
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
		lblNh_ncc.AutoSize = true;
		Label obj19 = lblNh_ncc;
		location = new Point(33, 450);
		((Control)obj19).Location = location;
		((Control)lblNh_ncc).Name = "lblNh_ncc";
		Label obj20 = lblNh_ncc;
		size = new Size(83, 13);
		((Control)obj20).Size = size;
		((Control)lblNh_ncc).TabIndex = 1306;
		lblNh_ncc.Text = "PS điều chuyển";
		((ButtonBase)chkPS_dc).AutoSize = true;
		chkPS_dc.Checked = true;
		((CheckBox)chkPS_dc).CheckState = (CheckState)1;
		AsCheckBox asCheckBox = chkPS_dc;
		location = new Point(130, 450);
		((Control)asCheckBox).Location = location;
		((Control)chkPS_dc).Name = "chkPS_dc";
		AsCheckBox asCheckBox2 = chkPS_dc;
		size = new Size(170, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkPS_dc).TabIndex = 17;
		((ButtonBase)chkPS_dc).Text = "Tính các PS điều chuyển kho";
		((ButtonBase)chkPS_dc).UseVisualStyleBackColor = true;
		lblTen_tk_vt.ImeMode = (ImeMode)0;
		Label obj21 = lblTen_tk_vt;
		location = new Point(226, 241);
		((Control)obj21).Location = location;
		((Control)lblTen_tk_vt).Name = "lblTen_tk_vt";
		Label obj22 = lblTen_tk_vt;
		size = new Size(314, 13);
		((Control)obj22).Size = size;
		((Control)lblTen_tk_vt).TabIndex = 1305;
		lblTen_tk_vt.TextAlign = (ContentAlignment)16;
		txtTK_vt.AutoLookup = true;
		txtTK_vt.AutoValid = false;
		((TextBoxBase)txtTK_vt).BackColor = SystemColors.Info;
		((TextBox)txtTK_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTK_vt;
		location = new Point(130, 238);
		((Control)asTextBox2).Location = location;
		txtTK_vt.LookupCodeName = "TK";
		((TextBoxBase)txtTK_vt).MaxLength = 20;
		((Control)txtTK_vt).Name = "txtTK_vt";
		txtTK_vt.NameControl = lblTen_tk_vt;
		AsTextBox asTextBox3 = txtTK_vt;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTK_vt).TabIndex = 9;
		txtTK_vt.UseAutoCompleteSource = true;
		lblTK_vt.AutoSize = true;
		Label obj23 = lblTK_vt;
		location = new Point(33, 241);
		((Control)obj23).Location = location;
		((Control)lblTK_vt).Name = "lblTK_vt";
		Label obj24 = lblTK_vt;
		size = new Size(51, 13);
		((Control)obj24).Size = size;
		((Control)lblTK_vt).TabIndex = 1304;
		lblTK_vt.Text = "TK vật tư";
		lblTen_kho.ImeMode = (ImeMode)0;
		Label obj25 = lblTen_kho;
		location = new Point(226, 267);
		((Control)obj25).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj26 = lblTen_kho;
		size = new Size(314, 13);
		((Control)obj26).Size = size;
		((Control)lblTen_kho).TabIndex = 1303;
		lblTen_kho.TextAlign = (ContentAlignment)16;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_kho;
		location = new Point(130, 264);
		((Control)asTextBox4).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((TextBoxBase)txtMa_kho).MaxLength = 20;
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox5 = txtMa_kho;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_kho).TabIndex = 10;
		txtMa_kho.UseAutoCompleteSource = true;
		lblMa_kho.AutoSize = true;
		Label obj27 = lblMa_kho;
		location = new Point(33, 267);
		((Control)obj27).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj28 = lblMa_kho;
		size = new Size(44, 13);
		((Control)obj28).Size = size;
		((Control)lblMa_kho).TabIndex = 1302;
		lblMa_kho.Text = "Mã Kho";
		lblTen_nh_vt.ImeMode = (ImeMode)0;
		Label obj29 = lblTen_nh_vt;
		location = new Point(226, 215);
		((Control)obj29).Location = location;
		((Control)lblTen_nh_vt).Name = "lblTen_nh_vt";
		Label obj30 = lblTen_nh_vt;
		size = new Size(314, 13);
		((Control)obj30).Size = size;
		((Control)lblTen_nh_vt).TabIndex = 1301;
		lblTen_nh_vt.TextAlign = (ContentAlignment)16;
		txtMa_nh_vt.AutoLookup = true;
		txtMa_nh_vt.AutoValid = false;
		((TextBoxBase)txtMa_nh_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nh_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_nh_vt;
		location = new Point(130, 212);
		((Control)asTextBox6).Location = location;
		txtMa_nh_vt.LookupCodeName = "MA_NHVT";
		((TextBoxBase)txtMa_nh_vt).MaxLength = 20;
		((Control)txtMa_nh_vt).Name = "txtMa_nh_vt";
		txtMa_nh_vt.NameControl = lblTen_nh_vt;
		AsTextBox asTextBox7 = txtMa_nh_vt;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_nh_vt).TabIndex = 8;
		txtMa_nh_vt.UseAutoCompleteSource = true;
		lblMa_nh_vt.AutoSize = true;
		Label obj31 = lblMa_nh_vt;
		location = new Point(33, 215);
		((Control)obj31).Location = location;
		((Control)lblMa_nh_vt).Name = "lblMa_nh_vt";
		Label obj32 = lblMa_nh_vt;
		size = new Size(81, 13);
		((Control)obj32).Size = size;
		((Control)lblMa_nh_vt).TabIndex = 1300;
		lblMa_nh_vt.Text = "Mã nhóm vật tư";
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj33 = lblTen_vt;
		location = new Point(226, 189);
		((Control)obj33).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj34 = lblTen_vt;
		size = new Size(314, 13);
		((Control)obj34).Size = size;
		((Control)lblTen_vt).TabIndex = 1299;
		lblTen_vt.TextAlign = (ContentAlignment)16;
		lblTen_ncc.ImeMode = (ImeMode)0;
		Label obj35 = lblTen_ncc;
		location = new Point(226, 163);
		((Control)obj35).Location = location;
		((Control)lblTen_ncc).Name = "lblTen_ncc";
		Label obj36 = lblTen_ncc;
		size = new Size(314, 13);
		((Control)obj36).Size = size;
		((Control)lblTen_ncc).TabIndex = 1293;
		lblTen_ncc.TextAlign = (ContentAlignment)16;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_vt;
		location = new Point(130, 186);
		((Control)asTextBox8).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((TextBoxBase)txtMa_vt).MaxLength = 20;
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox9 = txtMa_vt;
		size = new Size(90, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_vt).TabIndex = 7;
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_vt.AutoSize = true;
		Label obj37 = lblMa_vt;
		location = new Point(33, 189);
		((Control)obj37).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj38 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj38).Size = size;
		((Control)lblMa_vt).TabIndex = 1292;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_hd;
		location = new Point(130, 342);
		((Control)asTextBox10).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((TextBoxBase)txtMa_hd).MaxLength = 20;
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox11 = txtMa_hd;
		size = new Size(90, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_hd).TabIndex = 13;
		txtMa_hd.UseAutoCompleteSource = true;
		lblTen_hd.ImeMode = (ImeMode)0;
		Label obj39 = lblTen_hd;
		location = new Point(226, 345);
		((Control)obj39).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj40 = lblTen_hd;
		size = new Size(314, 13);
		((Control)obj40).Size = size;
		((Control)lblTen_hd).TabIndex = 1314;
		lblTen_hd.TextAlign = (ContentAlignment)16;
		lblMa_hd.AutoSize = true;
		Label obj41 = lblMa_hd;
		location = new Point(33, 345);
		((Control)obj41).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj42 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj42).Size = size;
		((Control)lblMa_hd).TabIndex = 1291;
		lblMa_hd.Text = "Mã hợp đồng";
		txtMa_ncc.AutoLookup = true;
		txtMa_ncc.AutoValid = false;
		((TextBoxBase)txtMa_ncc).BackColor = SystemColors.Info;
		((TextBox)txtMa_ncc).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_ncc;
		location = new Point(130, 160);
		((Control)asTextBox12).Location = location;
		txtMa_ncc.LookupCodeName = "MA_NCC";
		txtMa_ncc.LookupWhereCondition = "isNcc=1";
		((TextBoxBase)txtMa_ncc).MaxLength = 20;
		((Control)txtMa_ncc).Name = "txtMa_ncc";
		txtMa_ncc.NameControl = lblTen_ncc;
		AsTextBox asTextBox13 = txtMa_ncc;
		size = new Size(90, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_ncc).TabIndex = 6;
		txtMa_ncc.UseAutoCompleteSource = true;
		lblMa_ncc.AutoSize = true;
		Label obj43 = lblMa_ncc;
		location = new Point(33, 163);
		((Control)obj43).Location = location;
		((Control)lblMa_ncc).Name = "lblMa_ncc";
		Label obj44 = lblMa_ncc;
		size = new Size(47, 13);
		((Control)obj44).Size = size;
		((Control)lblMa_ncc).TabIndex = 1286;
		lblMa_ncc.Text = "Mã NCC";
		TextBox obj45 = txtSo_CT2;
		location = new Point(299, 133);
		((Control)obj45).Location = location;
		((Control)txtSo_CT2).Name = "txtSo_CT2";
		TextBox obj46 = txtSo_CT2;
		size = new Size(90, 20);
		((Control)obj46).Size = size;
		((Control)txtSo_CT2).TabIndex = 5;
		lblSo_ct2.AutoSize = true;
		Label obj47 = lblSo_ct2;
		location = new Point(238, 136);
		((Control)obj47).Location = location;
		((Control)lblSo_ct2).Name = "lblSo_ct2";
		Label obj48 = lblSo_ct2;
		size = new Size(41, 13);
		((Control)obj48).Size = size;
		((Control)lblSo_ct2).TabIndex = 1285;
		lblSo_ct2.Text = "Đến số";
		TextBox obj49 = txtSo_CT1;
		location = new Point(130, 133);
		((Control)obj49).Location = location;
		((Control)txtSo_CT1).Name = "txtSo_CT1";
		TextBox obj50 = txtSo_CT1;
		size = new Size(90, 20);
		((Control)obj50).Size = size;
		((Control)txtSo_CT1).TabIndex = 4;
		lblSo_ct1.AutoSize = true;
		Label obj51 = lblSo_ct1;
		location = new Point(33, 136);
		((Control)obj51).Location = location;
		((Control)lblSo_ct1).Name = "lblSo_ct1";
		Label obj52 = lblSo_ct1;
		size = new Size(64, 13);
		((Control)obj52).Size = size;
		((Control)lblSo_ct1).TabIndex = 1284;
		lblSo_ct1.Text = "Chứng từ số";
		cboLoai_pn.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_pn).FormattingEnabled = true;
		ComboBox obj53 = cboLoai_pn;
		location = new Point(130, 106);
		((Control)obj53).Location = location;
		((Control)cboLoai_pn).Name = "cboLoai_pn";
		ComboBox obj54 = cboLoai_pn;
		size = new Size(167, 21);
		((Control)obj54).Size = size;
		((Control)cboLoai_pn).TabIndex = 3;
		lblTen_vitri.ImeMode = (ImeMode)0;
		Label obj55 = lblTen_vitri;
		location = new Point(226, 293);
		((Control)obj55).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj56 = lblTen_vitri;
		size = new Size(314, 13);
		((Control)obj56).Size = size;
		((Control)lblTen_vitri).TabIndex = 1310;
		lblTen_vitri.TextAlign = (ContentAlignment)16;
		txtMa_vitri.AutoLookup = true;
		txtMa_vitri.AutoValid = false;
		((TextBoxBase)txtMa_vitri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vitri).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_vitri;
		location = new Point(130, 290);
		((Control)asTextBox14).Location = location;
		txtMa_vitri.LookupCodeName = "MA_VITRI";
		((TextBoxBase)txtMa_vitri).MaxLength = 20;
		((Control)txtMa_vitri).Name = "txtMa_vitri";
		txtMa_vitri.NameControl = lblTen_vitri;
		AsTextBox asTextBox15 = txtMa_vitri;
		size = new Size(90, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_vitri).TabIndex = 11;
		txtMa_vitri.UseAutoCompleteSource = true;
		lblMa_vitri.AutoSize = true;
		Label obj57 = lblMa_vitri;
		location = new Point(33, 293);
		((Control)obj57).Location = location;
		((Control)lblMa_vitri).Name = "lblMa_vitri";
		Label obj58 = lblMa_vitri;
		size = new Size(46, 13);
		((Control)obj58).Size = size;
		((Control)lblMa_vitri).TabIndex = 1309;
		lblMa_vitri.Text = "Mã vị trí";
		lblTen_bp.ImeMode = (ImeMode)0;
		Label obj59 = lblTen_bp;
		location = new Point(226, 319);
		((Control)obj59).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj60 = lblTen_bp;
		size = new Size(314, 13);
		((Control)obj60).Size = size;
		((Control)lblTen_bp).TabIndex = 1313;
		lblTen_bp.TextAlign = (ContentAlignment)16;
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox16 = txtMa_bp;
		location = new Point(130, 316);
		((Control)asTextBox16).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((TextBoxBase)txtMa_bp).MaxLength = 20;
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox17 = txtMa_bp;
		size = new Size(90, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtMa_bp).TabIndex = 12;
		txtMa_bp.UseAutoCompleteSource = true;
		lblMa_bp.AutoSize = true;
		Label obj61 = lblMa_bp;
		location = new Point(33, 319);
		((Control)obj61).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj62 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj62).Size = size;
		((Control)lblMa_bp).TabIndex = 1312;
		lblMa_bp.Text = "Mã bộ phận";
		lblTen_nx.ImeMode = (ImeMode)0;
		Label obj63 = lblTen_nx;
		location = new Point(226, 371);
		((Control)obj63).Location = location;
		((Control)lblTen_nx).Name = "lblTen_nx";
		Label obj64 = lblTen_nx;
		size = new Size(314, 13);
		((Control)obj64).Size = size;
		((Control)lblTen_nx).TabIndex = 1317;
		lblTen_nx.TextAlign = (ContentAlignment)16;
		txtMa_nx.AutoLookup = true;
		txtMa_nx.AutoValid = false;
		((TextBoxBase)txtMa_nx).BackColor = SystemColors.Info;
		((TextBox)txtMa_nx).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox18 = txtMa_nx;
		location = new Point(130, 368);
		((Control)asTextBox18).Location = location;
		txtMa_nx.LookupCodeName = "MA_NX";
		txtMa_nx.LookupWhereCondition = "moduleid = 'IN'";
		((TextBoxBase)txtMa_nx).MaxLength = 20;
		((Control)txtMa_nx).Name = "txtMa_nx";
		txtMa_nx.NameControl = lblTen_nx;
		AsTextBox asTextBox19 = txtMa_nx;
		size = new Size(90, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtMa_nx).TabIndex = 14;
		txtMa_nx.UseAutoCompleteSource = true;
		lblMa_nx.AutoSize = true;
		Label obj65 = lblMa_nx;
		location = new Point(33, 371);
		((Control)obj65).Location = location;
		((Control)lblMa_nx).Name = "lblMa_nx";
		Label obj66 = lblMa_nx;
		size = new Size(67, 13);
		((Control)obj66).Size = size;
		((Control)lblMa_nx).TabIndex = 1316;
		lblMa_nx.Text = "Mã dạng NX";
		lblTen_tk_du.ImeMode = (ImeMode)0;
		Label obj67 = lblTen_tk_du;
		location = new Point(226, 397);
		((Control)obj67).Location = location;
		((Control)lblTen_tk_du).Name = "lblTen_tk_du";
		Label obj68 = lblTen_tk_du;
		size = new Size(314, 13);
		((Control)obj68).Size = size;
		((Control)lblTen_tk_du).TabIndex = 1320;
		lblTen_tk_du.TextAlign = (ContentAlignment)16;
		txtTK_du.AutoLookup = true;
		txtTK_du.AutoValid = false;
		((TextBoxBase)txtTK_du).BackColor = SystemColors.Info;
		((TextBox)txtTK_du).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtTK_du;
		location = new Point(130, 394);
		((Control)asTextBox20).Location = location;
		txtTK_du.LookupCodeName = "TK";
		((TextBoxBase)txtTK_du).MaxLength = 20;
		((Control)txtTK_du).Name = "txtTK_du";
		txtTK_du.NameControl = lblTen_tk_du;
		AsTextBox asTextBox21 = txtTK_du;
		size = new Size(90, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtTK_du).TabIndex = 15;
		txtTK_du.UseAutoCompleteSource = true;
		lblTK_du.AutoSize = true;
		Label obj69 = lblTK_du;
		location = new Point(33, 397);
		((Control)obj69).Location = location;
		((Control)lblTK_du).Name = "lblTK_du";
		Label obj70 = lblTK_du;
		size = new Size(74, 13);
		((Control)obj70).Size = size;
		((Control)lblTK_du).TabIndex = 1319;
		lblTK_du.Text = "Tài khoản ĐƯ";
		lblLoai_pn.AutoSize = true;
		Label obj71 = lblLoai_pn;
		location = new Point(33, 107);
		((Control)obj71).Location = location;
		((Control)lblLoai_pn).Name = "lblLoai_pn";
		Label obj72 = lblLoai_pn;
		size = new Size(83, 13);
		((Control)obj72).Size = size;
		((Control)lblLoai_pn).TabIndex = 1321;
		lblLoai_pn.Text = "Loại phiếu nhập";
		lblDVT.AutoSize = true;
		Label obj73 = lblDVT;
		location = new Point(33, 423);
		((Control)obj73).Location = location;
		((Control)lblDVT).Name = "lblDVT";
		Label obj74 = lblDVT;
		size = new Size(57, 13);
		((Control)obj74).Size = size;
		((Control)lblDVT).TabIndex = 1323;
		lblDVT.Text = "Theo ĐVT";
		cboDVT.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboDVT).FormattingEnabled = true;
		cboDVT.Items.AddRange(new object[4] { "Chứng từ", "Kho", "Mua", "Bán" });
		ComboBox obj75 = cboDVT;
		location = new Point(130, 420);
		((Control)obj75).Location = location;
		((Control)cboDVT).Name = "cboDVT";
		ComboBox obj76 = cboDVT;
		size = new Size(94, 21);
		((Control)obj76).Size = size;
		((Control)cboDVT).TabIndex = 16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(844, 605);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmINRptTHN01";
		((Form)this).Text = "frmINRptTHN01";
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
		ComboBox val = cboDVT;
		ArrayList arrayList = new ArrayList();
		DictionaryEntry dictionaryEntry = new DictionaryEntry("0", RuntimeHelpers.GetObjectValue(val.Items[0]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("1", RuntimeHelpers.GetObjectValue(val.Items[1]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("2", RuntimeHelpers.GetObjectValue(val.Items[2]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("3", RuntimeHelpers.GetObjectValue(val.Items[3]));
		arrayList.Add(dictionaryEntry);
		val.Items.Clear();
		val.DataSource = arrayList;
		((ListControl)val).ValueMember = "Key";
		((ListControl)val).DisplayMember = "Value";
		val.SelectedIndex = 0;
		val = null;
		ComboBox val2 = cboLoai_pn;
		val2.DataSource = AsiaErp.Framework.Environment.GetDanhSachChungTuNhap();
		((ListControl)val2).ValueMember = "Key";
		((ListControl)val2).DisplayMember = "Value";
		val2.SelectedIndex = 0;
		val2 = null;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(txtSo_CT1.Text);
		arrayList.Add(txtSo_CT2.Text);
		arrayList.Add(((TextBox)txtMa_ncc).Text);
		arrayList.Add("");
		arrayList.Add("");
		arrayList.Add("");
		arrayList.Add("");
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_pn).SelectedValue));
		arrayList.Add("");
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_vitri).Text);
		arrayList.Add(((TextBox)txtMa_bp).Text);
		arrayList.Add("");
		arrayList.Add(((TextBox)txtTK_vt).Text);
		arrayList.Add(((TextBox)txtTK_du).Text);
		arrayList.Add(((TextBox)txtMa_nh_vt).Text);
		arrayList.Add(chkPS_dc.TextValue);
		arrayList.Add(((TextBox)txtMa_nx).Text);
		arrayList.Add("");
		arrayList.Add("");
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		DictionaryEntry dictionaryEntry = (DictionaryEntry)cboDVT.SelectedItem;
		arrayList.Add(RuntimeHelpers.GetObjectValue(dictionaryEntry.Key));
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
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add("");
		arrayList.Add(((TextBox)txtMa_vitri).Text);
		arrayList.Add(((TextBox)txtMa_ncc).Text);
		arrayList.Add(((TextBox)txtMa_bp).Text);
		arrayList.Add(((TextBox)txtMa_hd).Text);
		arrayList.Add(((TextBox)txtTK_du).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_pn).SelectedValue));
		arrayList.Add("1");
		arrayList.Add(chkPS_dc.TextValue);
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
		text = text + lblLoai_pn.Text + ":" + cboLoai_pn.Text + "; ";
		if (Operators.CompareString(txtSo_CT1.Text, "", false) != 0)
		{
			text = text + lblSo_ct1.Text + ": " + txtSo_CT1.Text + "; ";
		}
		if (Operators.CompareString(txtSo_CT2.Text, "", false) != 0)
		{
			text = text + lblSo_ct2.Text + ": " + txtSo_CT2.Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_ncc).Text, "", false) != 0)
		{
			text = text + lblMa_ncc.Text + ": " + ((TextBox)txtMa_ncc).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
		{
			text = text + lblMa_vt.Text + ": " + ((TextBox)txtMa_vt).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nh_vt).Text, "", false) != 0)
		{
			text = text + lblMa_nh_vt.Text + ": " + ((TextBox)txtMa_nh_vt).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtTK_vt).Text, "", false) != 0)
		{
			text = text + lblTK_vt.Text + ": " + ((TextBox)txtTK_vt).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text, "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": " + ((TextBox)txtMa_kho).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_vitri).Text, "", false) != 0)
		{
			text = text + lblMa_vitri.Text + ": " + ((TextBox)txtMa_vitri).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_bp).Text, "", false) != 0)
		{
			text = text + lblMa_bp.Text + ": " + ((TextBox)txtMa_bp).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_hd).Text, "", false) != 0)
		{
			text = text + lblMa_hd.Text + ": " + ((TextBox)txtMa_hd).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nx).Text, "", false) != 0)
		{
			text = text + lblMa_nx.Text + ": " + ((TextBox)txtMa_nx).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtTK_du).Text, "", false) != 0)
		{
			text = text + lblTK_du.Text + ": " + ((TextBox)txtTK_du).Text + "; ";
		}
		if (Operators.CompareString(cboDVT.Text, "", false) != 0)
		{
			text = text + lblDVT.Text + ": " + cboDVT.Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
		}
		return text;
	}
}
