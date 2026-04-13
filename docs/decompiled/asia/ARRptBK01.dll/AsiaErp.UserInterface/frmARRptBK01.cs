using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmARRptBK01 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

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

	[AccessedThroughProperty("lblTen_Nvkd")]
	private Label _lblTen_Nvkd;

	[AccessedThroughProperty("txtMa_Nvkd")]
	private AsTextBox _txtMa_Nvkd;

	[AccessedThroughProperty("lblMa_nvkd")]
	private Label _lblMa_nvkd;

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

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("txtMa_lo")]
	private AsTextBox _txtMa_lo;

	[AccessedThroughProperty("lblMa_lo")]
	private Label _lblMa_lo;

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

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("lblTen_phi")]
	private Label _lblTen_phi;

	[AccessedThroughProperty("txtMa_phi")]
	private AsTextBox _txtMa_phi;

	[AccessedThroughProperty("lblMa_phi")]
	private Label _lblMa_phi;

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

	internal virtual Label lblTen_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_phi = value;
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

	public frmARRptBK01(string MenuId)
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
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
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
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
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
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_2818: Unknown result type (might be due to invalid IL or missing references)
		//IL_2822: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblMa_nhvt = new Label();
		txtMa_nhvt = new AsTextBox();
		lblTen_nhvt = new Label();
		lblTen_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		lblTen_kho = new Label();
		txtMa_kho = new AsTextBox();
		lblMa_kho = new Label();
		lblTen_lo = new Label();
		txtMa_lo = new AsTextBox();
		lblMa_lo = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_Bp = new Label();
		lblTen_Hd = new Label();
		txtMa_Hd = new AsTextBox();
		lblMa_Hd = new Label();
		lblTen_Nvkd = new Label();
		txtMa_Nvkd = new AsTextBox();
		lblMa_nvkd = new Label();
		txtSo_Ct2 = new TextBox();
		txtSo_Ct1 = new TextBox();
		lblSo_Ct2 = new Label();
		lblSo_Ct1 = new Label();
		lblPLKh3 = new Label();
		txtMa_plkh3 = new AsTextBox();
		lblTen_plkh3 = new Label();
		lblPLKh2 = new Label();
		txtMa_plkh2 = new AsTextBox();
		lblTen_plkh2 = new Label();
		lblPLKh1 = new Label();
		txtMa_plkh1 = new AsTextBox();
		lblTen_plkh1 = new Label();
		lblTen_spct = new Label();
		txtMa_spct = new AsTextBox();
		lblMa_spct = new Label();
		lblTen_phi = new Label();
		txtMa_phi = new AsTextBox();
		lblMa_phi = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(797, 627);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_phi);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLKh3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLKh2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLKh1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_Ct2);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_Ct1);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct2);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nvkd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Hd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Hd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_lo);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_lo);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_lo);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Kh);
		TabPage obj = tabFilter;
		size = new Size(789, 598);
		((Control)obj).Size = size;
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Hd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nvkd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_Ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_Ct2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLKh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLKh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLKh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		Label obj2 = lbl2;
		Point location = new Point(277, 81);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 981);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(296, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 981);
		((Control)obj4).Location = location;
		((Control)cmdModifyReport).TabIndex = 23;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(206, 77);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj5 = cboKyBc;
		location = new Point(110, 77);
		((Control)obj5).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj6 = lblKyBc;
		location = new Point(24, 81);
		((Control)obj6).Location = location;
		ComboBox obj7 = cboMau_bc;
		location = new Point(110, 24);
		((Control)obj7).Location = location;
		((Control)cboMau_bc).TabIndex = 22;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 468);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 20;
		Label obj8 = lblMauBC;
		location = new Point(155, 467);
		((Control)obj8).Location = location;
		RadioButton obj9 = optVND;
		location = new Point(242, 466);
		((Control)obj9).Location = location;
		((Control)optVND).TabIndex = 21;
		RadioButton obj10 = optNt;
		location = new Point(296, 465);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 22;
		Label obj11 = lblMa_nt;
		location = new Point(24, 470);
		((Control)obj11).Location = location;
		Button obj12 = cmdOk;
		location = new Point(27, 535);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 23;
		Label obj13 = lblTieu_de;
		location = new Point(24, 55);
		((Control)obj13).Location = location;
		TextBox obj14 = txtTieu_De;
		location = new Point(110, 51);
		((Control)obj14).Location = location;
		((Control)txtTieu_De).TabIndex = 24;
		crvReportViewer.ActiveViewIndex = -1;
		((UserControl)crvReportViewer).BorderStyle = (BorderStyle)1;
		crvReportViewer.DisplayGroupTree = false;
		((Control)crvReportViewer).Dock = (DockStyle)5;
		CrystalReportViewer obj15 = crvReportViewer;
		location = new Point(0, 0);
		((Control)obj15).Location = location;
		((Control)crvReportViewer).Name = "crvReportViewer";
		crvReportViewer.SelectionFormula = "";
		crvReportViewer.ShowRefreshButton = false;
		CrystalReportViewer obj16 = crvReportViewer;
		size = new Size(782, 459);
		((Control)obj16).Size = size;
		((Control)crvReportViewer).TabIndex = 0;
		crvReportViewer.ViewTimeSelectionFormula = "";
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj17 = lblTen_Kh;
		location = new Point(206, 134);
		((Control)obj17).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj18 = lblTen_Kh;
		size = new Size(361, 13);
		((Control)obj18).Size = size;
		((Control)lblTen_Kh).TabIndex = 1036;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = false;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_Kh;
		location = new Point(110, 130);
		((Control)asTextBox2).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		txtMa_Kh.LookupWhereCondition = " 1=1 ";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		AsTextBox asTextBox3 = txtMa_Kh;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_Kh).TabIndex = 6;
		txtMa_Kh.UseAutoCompleteSource = true;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj19 = lblMa_Kh;
		location = new Point(24, 134);
		((Control)obj19).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj20 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj20).Size = size;
		((Control)lblMa_Kh).TabIndex = 1035;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblMa_nhvt.AutoSize = true;
		lblMa_nhvt.ImeMode = (ImeMode)0;
		Label obj21 = lblMa_nhvt;
		location = new Point(24, 264);
		((Control)obj21).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj22 = lblMa_nhvt;
		size = new Size(65, 13);
		((Control)obj22).Size = size;
		((Control)lblMa_nhvt).TabIndex = 1044;
		lblMa_nhvt.Text = "Nhóm vật tư";
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_nhvt;
		location = new Point(110, 260);
		((Control)asTextBox4).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((TextBoxBase)txtMa_nhvt).MaxLength = 8;
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_nhvt;
		AsTextBox asTextBox5 = txtMa_nhvt;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_nhvt).TabIndex = 12;
		((Control)txtMa_nhvt).Tag = "MA_NHVT";
		txtMa_nhvt.UseAutoCompleteSource = true;
		lblTen_nhvt.ImeMode = (ImeMode)0;
		Label obj23 = lblTen_nhvt;
		location = new Point(206, 264);
		((Control)obj23).Location = location;
		((Control)lblTen_nhvt).Name = "lblTen_nhvt";
		Label obj24 = lblTen_nhvt;
		size = new Size(361, 13);
		((Control)obj24).Size = size;
		((Control)lblTen_nhvt).TabIndex = 1045;
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj25 = lblTen_vt;
		location = new Point(206, 238);
		((Control)obj25).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj26 = lblTen_vt;
		size = new Size(361, 13);
		((Control)obj26).Size = size;
		((Control)lblTen_vt).TabIndex = 1043;
		((TextBox)txtMa_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_vt;
		location = new Point(110, 234);
		((Control)asTextBox6).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox7 = txtMa_vt;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_vt).TabIndex = 11;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_vt.AutoSize = true;
		lblMa_vt.ImeMode = (ImeMode)0;
		Label obj27 = lblMa_vt;
		location = new Point(24, 238);
		((Control)obj27).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj28 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj28).Size = size;
		((Control)lblMa_vt).TabIndex = 1042;
		lblMa_vt.Text = "Mã vật tư";
		lblMa_vt.TextAlign = (ContentAlignment)16;
		lblTen_kho.ImeMode = (ImeMode)0;
		Label obj29 = lblTen_kho;
		location = new Point(206, 290);
		((Control)obj29).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj30 = lblTen_kho;
		size = new Size(361, 13);
		((Control)obj30).Size = size;
		((Control)lblTen_kho).TabIndex = 1065;
		lblTen_kho.TextAlign = (ContentAlignment)16;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_kho;
		location = new Point(110, 286);
		((Control)asTextBox8).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox9 = txtMa_kho;
		size = new Size(90, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_kho).TabIndex = 13;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		lblMa_kho.AutoSize = true;
		lblMa_kho.ImeMode = (ImeMode)0;
		Label obj31 = lblMa_kho;
		location = new Point(24, 290);
		((Control)obj31).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj32 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj32).Size = size;
		((Control)lblMa_kho).TabIndex = 1064;
		lblMa_kho.Text = "Mã kho";
		lblTen_lo.ImeMode = (ImeMode)0;
		Label obj33 = lblTen_lo;
		location = new Point(206, 316);
		((Control)obj33).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj34 = lblTen_lo;
		size = new Size(361, 13);
		((Control)obj34).Size = size;
		((Control)lblTen_lo).TabIndex = 1071;
		lblTen_lo.TextAlign = (ContentAlignment)16;
		txtMa_lo.AutoLookup = true;
		txtMa_lo.AutoValid = false;
		((TextBoxBase)txtMa_lo).BackColor = SystemColors.Info;
		((TextBox)txtMa_lo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_lo;
		location = new Point(110, 312);
		((Control)asTextBox10).Location = location;
		txtMa_lo.LookupCodeName = "MA_LO";
		((Control)txtMa_lo).Name = "txtMa_lo";
		txtMa_lo.NameControl = lblTen_lo;
		AsTextBox asTextBox11 = txtMa_lo;
		size = new Size(90, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_lo).TabIndex = 14;
		((Control)txtMa_lo).Tag = "";
		txtMa_lo.UseAutoCompleteSource = true;
		lblMa_lo.AutoSize = true;
		lblMa_lo.ImeMode = (ImeMode)0;
		Label obj35 = lblMa_lo;
		location = new Point(24, 316);
		((Control)obj35).Location = location;
		((Control)lblMa_lo).Name = "lblMa_lo";
		Label obj36 = lblMa_lo;
		size = new Size(33, 13);
		((Control)obj36).Size = size;
		((Control)lblMa_lo).TabIndex = 1070;
		lblMa_lo.Text = "Mã lô";
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj37 = lblTen_Bp;
		location = new Point(206, 342);
		((Control)obj37).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj38 = lblTen_Bp;
		size = new Size(361, 13);
		((Control)obj38).Size = size;
		((Control)lblTen_Bp).TabIndex = 1074;
		lblTen_Bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_Bp;
		location = new Point(110, 338);
		((Control)asTextBox12).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox13 = txtMa_Bp;
		size = new Size(90, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_Bp).TabIndex = 15;
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_Bp.AutoSize = true;
		lblMa_Bp.ImeMode = (ImeMode)0;
		Label obj39 = lblMa_Bp;
		location = new Point(24, 342);
		((Control)obj39).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj40 = lblMa_Bp;
		size = new Size(64, 13);
		((Control)obj40).Size = size;
		((Control)lblMa_Bp).TabIndex = 1073;
		lblMa_Bp.Text = "Mã bộ phận";
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj41 = lblTen_Hd;
		location = new Point(206, 368);
		((Control)obj41).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj42 = lblTen_Hd;
		size = new Size(361, 13);
		((Control)obj42).Size = size;
		((Control)lblTen_Hd).TabIndex = 1077;
		lblTen_Hd.TextAlign = (ContentAlignment)16;
		txtMa_Hd.AutoLookup = true;
		txtMa_Hd.AutoValid = false;
		((TextBoxBase)txtMa_Hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_Hd;
		location = new Point(110, 364);
		((Control)asTextBox14).Location = location;
		txtMa_Hd.LookupCodeName = "MA_HD";
		((Control)txtMa_Hd).Name = "txtMa_Hd";
		txtMa_Hd.NameControl = lblTen_Hd;
		AsTextBox asTextBox15 = txtMa_Hd;
		size = new Size(90, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_Hd).TabIndex = 16;
		txtMa_Hd.UseAutoCompleteSource = true;
		lblMa_Hd.AutoSize = true;
		lblMa_Hd.ImeMode = (ImeMode)0;
		Label obj43 = lblMa_Hd;
		location = new Point(24, 368);
		((Control)obj43).Location = location;
		((Control)lblMa_Hd).Name = "lblMa_Hd";
		Label obj44 = lblMa_Hd;
		size = new Size(71, 13);
		((Control)obj44).Size = size;
		((Control)lblMa_Hd).TabIndex = 1076;
		lblMa_Hd.Text = "Mã hợp đồng";
		lblTen_Nvkd.ImeMode = (ImeMode)0;
		Label obj45 = lblTen_Nvkd;
		location = new Point(206, 446);
		((Control)obj45).Location = location;
		((Control)lblTen_Nvkd).Name = "lblTen_Nvkd";
		Label obj46 = lblTen_Nvkd;
		size = new Size(361, 13);
		((Control)obj46).Size = size;
		((Control)lblTen_Nvkd).TabIndex = 1080;
		lblTen_Nvkd.TextAlign = (ContentAlignment)16;
		txtMa_Nvkd.AutoLookup = true;
		txtMa_Nvkd.AutoValid = false;
		((TextBoxBase)txtMa_Nvkd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nvkd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox16 = txtMa_Nvkd;
		location = new Point(110, 442);
		((Control)asTextBox16).Location = location;
		txtMa_Nvkd.LookupCodeName = "MA_NVKD";
		((Control)txtMa_Nvkd).Name = "txtMa_Nvkd";
		txtMa_Nvkd.NameControl = lblTen_Nvkd;
		AsTextBox asTextBox17 = txtMa_Nvkd;
		size = new Size(90, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtMa_Nvkd).TabIndex = 18;
		((Control)txtMa_Nvkd).Tag = "MA_NVKD";
		txtMa_Nvkd.UseAutoCompleteSource = true;
		lblMa_nvkd.AutoSize = true;
		lblMa_nvkd.ImeMode = (ImeMode)0;
		Label obj47 = lblMa_nvkd;
		location = new Point(24, 446);
		((Control)obj47).Location = location;
		((Control)lblMa_nvkd).Name = "lblMa_nvkd";
		Label obj48 = lblMa_nvkd;
		size = new Size(55, 13);
		((Control)obj48).Size = size;
		((Control)lblMa_nvkd).TabIndex = 1079;
		lblMa_nvkd.Text = "Mã NVKD";
		TextBox obj49 = txtSo_Ct2;
		location = new Point(273, 103);
		((Control)obj49).Location = location;
		((Control)txtSo_Ct2).Name = "txtSo_Ct2";
		TextBox obj50 = txtSo_Ct2;
		size = new Size(90, 20);
		((Control)obj50).Size = size;
		((Control)txtSo_Ct2).TabIndex = 4;
		TextBox obj51 = txtSo_Ct1;
		location = new Point(110, 104);
		((Control)obj51).Location = location;
		((Control)txtSo_Ct1).Name = "txtSo_Ct1";
		TextBox obj52 = txtSo_Ct1;
		size = new Size(90, 20);
		((Control)obj52).Size = size;
		((Control)txtSo_Ct1).TabIndex = 3;
		lblSo_Ct2.AutoSize = true;
		Label obj53 = lblSo_Ct2;
		location = new Point(216, 108);
		((Control)obj53).Location = location;
		((Control)lblSo_Ct2).Name = "lblSo_Ct2";
		Label obj54 = lblSo_Ct2;
		size = new Size(40, 13);
		((Control)obj54).Size = size;
		((Control)lblSo_Ct2).TabIndex = 1084;
		lblSo_Ct2.Text = "đến số";
		lblSo_Ct1.AutoSize = true;
		Label obj55 = lblSo_Ct1;
		location = new Point(24, 108);
		((Control)obj55).Location = location;
		((Control)lblSo_Ct1).Name = "lblSo_Ct1";
		Label obj56 = lblSo_Ct1;
		size = new Size(64, 13);
		((Control)obj56).Size = size;
		((Control)lblSo_Ct1).TabIndex = 1083;
		lblSo_Ct1.Text = "Chứng từ số";
		lblPLKh3.AutoSize = true;
		lblPLKh3.ImeMode = (ImeMode)0;
		Label obj57 = lblPLKh3;
		location = new Point(24, 212);
		((Control)obj57).Location = location;
		((Control)lblPLKh3).Name = "lblPLKh3";
		Label obj58 = lblPLKh3;
		size = new Size(61, 13);
		((Control)obj58).Size = size;
		((Control)lblPLKh3).TabIndex = 1095;
		lblPLKh3.Text = "P.Loại KH3";
		txtMa_plkh3.AutoLookup = true;
		txtMa_plkh3.AutoValid = false;
		((TextBoxBase)txtMa_plkh3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox18 = txtMa_plkh3;
		location = new Point(110, 208);
		((Control)asTextBox18).Location = location;
		txtMa_plkh3.LookupCodeName = "MA_PLKH";
		txtMa_plkh3.LookupWhereCondition = "loai=3";
		((TextBoxBase)txtMa_plkh3).MaxLength = 8;
		((Control)txtMa_plkh3).Name = "txtMa_plkh3";
		txtMa_plkh3.NameControl = lblTen_plkh3;
		AsTextBox asTextBox19 = txtMa_plkh3;
		size = new Size(90, 20);
		((Control)asTextBox19).Size = size;
		((Control)txtMa_plkh3).TabIndex = 10;
		((Control)txtMa_plkh3).Tag = "MA_PLKH3";
		txtMa_plkh3.UseAutoCompleteSource = true;
		lblTen_plkh3.ImeMode = (ImeMode)0;
		Label obj59 = lblTen_plkh3;
		location = new Point(206, 212);
		((Control)obj59).Location = location;
		((Control)lblTen_plkh3).Name = "lblTen_plkh3";
		Label obj60 = lblTen_plkh3;
		size = new Size(361, 13);
		((Control)obj60).Size = size;
		((Control)lblTen_plkh3).TabIndex = 1096;
		lblPLKh2.AutoSize = true;
		lblPLKh2.ImeMode = (ImeMode)0;
		Label obj61 = lblPLKh2;
		location = new Point(24, 186);
		((Control)obj61).Location = location;
		((Control)lblPLKh2).Name = "lblPLKh2";
		Label obj62 = lblPLKh2;
		size = new Size(61, 13);
		((Control)obj62).Size = size;
		((Control)lblPLKh2).TabIndex = 1093;
		lblPLKh2.Text = "P.Loại KH2";
		txtMa_plkh2.AutoLookup = true;
		txtMa_plkh2.AutoValid = false;
		((TextBoxBase)txtMa_plkh2).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox20 = txtMa_plkh2;
		location = new Point(110, 182);
		((Control)asTextBox20).Location = location;
		txtMa_plkh2.LookupCodeName = "MA_PLKH";
		txtMa_plkh2.LookupWhereCondition = "loai=2";
		((TextBoxBase)txtMa_plkh2).MaxLength = 8;
		((Control)txtMa_plkh2).Name = "txtMa_plkh2";
		txtMa_plkh2.NameControl = lblTen_plkh2;
		AsTextBox asTextBox21 = txtMa_plkh2;
		size = new Size(90, 20);
		((Control)asTextBox21).Size = size;
		((Control)txtMa_plkh2).TabIndex = 9;
		((Control)txtMa_plkh2).Tag = "MA_PLKH2";
		txtMa_plkh2.UseAutoCompleteSource = true;
		lblTen_plkh2.ImeMode = (ImeMode)0;
		Label obj63 = lblTen_plkh2;
		location = new Point(206, 186);
		((Control)obj63).Location = location;
		((Control)lblTen_plkh2).Name = "lblTen_plkh2";
		Label obj64 = lblTen_plkh2;
		size = new Size(361, 13);
		((Control)obj64).Size = size;
		((Control)lblTen_plkh2).TabIndex = 1094;
		lblPLKh1.AutoSize = true;
		lblPLKh1.ImeMode = (ImeMode)0;
		Label obj65 = lblPLKh1;
		location = new Point(24, 160);
		((Control)obj65).Location = location;
		((Control)lblPLKh1).Name = "lblPLKh1";
		Label obj66 = lblPLKh1;
		size = new Size(61, 13);
		((Control)obj66).Size = size;
		((Control)lblPLKh1).TabIndex = 1091;
		lblPLKh1.Text = "P.Loại KH1";
		txtMa_plkh1.AutoLookup = true;
		txtMa_plkh1.AutoValid = false;
		((TextBoxBase)txtMa_plkh1).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox22 = txtMa_plkh1;
		location = new Point(110, 156);
		((Control)asTextBox22).Location = location;
		txtMa_plkh1.LookupCodeName = "MA_PLKH";
		txtMa_plkh1.LookupWhereCondition = "loai=1";
		((TextBoxBase)txtMa_plkh1).MaxLength = 8;
		((Control)txtMa_plkh1).Name = "txtMa_plkh1";
		txtMa_plkh1.NameControl = lblTen_plkh1;
		AsTextBox asTextBox23 = txtMa_plkh1;
		size = new Size(90, 20);
		((Control)asTextBox23).Size = size;
		((Control)txtMa_plkh1).TabIndex = 8;
		((Control)txtMa_plkh1).Tag = "MA_PLKH1";
		txtMa_plkh1.UseAutoCompleteSource = true;
		lblTen_plkh1.ImeMode = (ImeMode)0;
		Label obj67 = lblTen_plkh1;
		location = new Point(206, 160);
		((Control)obj67).Location = location;
		((Control)lblTen_plkh1).Name = "lblTen_plkh1";
		Label obj68 = lblTen_plkh1;
		size = new Size(361, 13);
		((Control)obj68).Size = size;
		((Control)lblTen_plkh1).TabIndex = 1092;
		lblTen_spct.ImeMode = (ImeMode)0;
		Label obj69 = lblTen_spct;
		location = new Point(206, 420);
		((Control)obj69).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj70 = lblTen_spct;
		size = new Size(361, 13);
		((Control)obj70).Size = size;
		((Control)lblTen_spct).TabIndex = 1104;
		lblTen_spct.TextAlign = (ContentAlignment)16;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox24 = txtMa_spct;
		location = new Point(110, 416);
		((Control)asTextBox24).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox25 = txtMa_spct;
		size = new Size(90, 20);
		((Control)asTextBox25).Size = size;
		((Control)txtMa_spct).TabIndex = 18;
		txtMa_spct.UseAutoCompleteSource = true;
		lblMa_spct.AutoSize = true;
		lblMa_spct.ImeMode = (ImeMode)0;
		Label obj71 = lblMa_spct;
		location = new Point(24, 420);
		((Control)obj71).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj72 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj72).Size = size;
		((Control)lblMa_spct).TabIndex = 1103;
		lblMa_spct.Text = "Mã SPCT";
		lblTen_phi.ImeMode = (ImeMode)0;
		Label obj73 = lblTen_phi;
		location = new Point(206, 394);
		((Control)obj73).Location = location;
		((Control)lblTen_phi).Name = "lblTen_phi";
		Label obj74 = lblTen_phi;
		size = new Size(361, 13);
		((Control)obj74).Size = size;
		((Control)lblTen_phi).TabIndex = 1102;
		lblTen_phi.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_phi).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_phi.AutoLookup = true;
		txtMa_phi.AutoValid = false;
		((TextBoxBase)txtMa_phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox26 = txtMa_phi;
		location = new Point(110, 390);
		((Control)asTextBox26).Location = location;
		txtMa_phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_phi).Name = "txtMa_phi";
		txtMa_phi.NameControl = lblTen_phi;
		AsTextBox asTextBox27 = txtMa_phi;
		size = new Size(90, 20);
		((Control)asTextBox27).Size = size;
		((Control)txtMa_phi).TabIndex = 17;
		txtMa_phi.UseAutoCompleteSource = true;
		lblMa_phi.AutoSize = true;
		lblMa_phi.ImeMode = (ImeMode)0;
		Label obj75 = lblMa_phi;
		location = new Point(24, 394);
		((Control)obj75).Location = location;
		((Control)lblMa_phi).Name = "lblMa_phi";
		Label obj76 = lblMa_phi;
		size = new Size(41, 13);
		((Control)obj76).Size = size;
		((Control)lblMa_phi).TabIndex = 1101;
		lblMa_phi.Text = "Mã phí";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(797, 649);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmARRptBK01";
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
		((TextBoxBase)txtSo_Ct1).MaxLength = 12;
		((TextBoxBase)txtSo_Ct2).MaxLength = 12;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_Kh).Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_lo).Text);
		arrayList.Add(((TextBox)txtMa_Bp).Text);
		arrayList.Add(((TextBox)txtMa_Hd).Text);
		arrayList.Add(((TextBox)txtMa_phi).Text);
		arrayList.Add(((TextBox)txtMa_spct).Text);
		arrayList.Add(((TextBox)txtMa_Nvkd).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(txtSo_Ct1.Text);
		arrayList.Add(txtSo_Ct2.Text);
		arrayList.Add(((TextBox)txtMa_plkh1).Text);
		arrayList.Add(((TextBox)txtMa_plkh2).Text);
		arrayList.Add(((TextBox)txtMa_plkh3).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if ((Operators.CompareString(txtSo_Ct1.Text.Trim(), "", false) != 0) & (Operators.CompareString(txtSo_Ct2.Text.Trim(), "", false) != 0))
		{
			text = text + lblSo_Ct1.Text + ": [" + txtSo_Ct1.Text.Trim() + "] " + lblSo_Ct2.Text + ": [" + txtSo_Ct2.Text.Trim() + "];";
		}
		else
		{
			if (Operators.CompareString(txtSo_Ct1.Text.Trim(), "", false) != 0)
			{
				text = text + lblSo_Ct1.Text + ": [" + txtSo_Ct1.Text.Trim() + "];";
			}
			if (Operators.CompareString(txtSo_Ct2.Text.Trim(), "", false) != 0)
			{
				text = text + lblSo_Ct2.Text + ": [" + txtSo_Ct2.Text.Trim() + "];";
			}
		}
		if (Operators.CompareString(((TextBox)txtMa_Kh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Kh.Text + ": [" + ((TextBox)txtMa_Kh).Text + " - " + lblTen_Kh.Text + "]; ";
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
		if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
		{
			text = text + lblMa_vt.Text + ": [" + ((TextBox)txtMa_vt).Text + " - " + lblTen_vt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhvt).Text, "", false) != 0)
		{
			text = text + lblMa_nhvt.Text + ": [" + ((TextBox)txtMa_nhvt).Text + " - " + lblTen_nhvt.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": [" + ((TextBox)txtMa_kho).Text + " - " + lblTen_kho.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_lo).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_lo.Text + ": [" + ((TextBox)txtMa_lo).Text + " - " + lblTen_lo.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Bp).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Bp.Text + ": [" + ((TextBox)txtMa_Bp).Text + " - " + lblTen_Bp.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Hd).Text, "", false) != 0)
		{
			text = text + lblMa_Hd.Text + ": [" + ((TextBox)txtMa_Hd).Text + " - " + lblTen_Hd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_phi).Text, "", false) != 0)
		{
			text = text + lblMa_nvkd.Text + ": [" + ((TextBox)txtMa_phi).Text + " - " + lblTen_phi.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_spct).Text, "", false) != 0)
		{
			text = text + lblMa_nvkd.Text + ": [" + ((TextBox)txtMa_spct).Text + " - " + lblTen_spct.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nvkd).Text, "", false) != 0)
		{
			text = text + lblMa_nvkd.Text + ": [" + ((TextBox)txtMa_Nvkd).Text + " - " + lblTen_Nvkd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": [" + ((TextBox)txtMa_Nt).Text + "]; ";
		}
		return text;
	}
}
