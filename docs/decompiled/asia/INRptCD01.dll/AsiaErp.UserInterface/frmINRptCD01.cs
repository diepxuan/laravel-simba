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
public class frmINRptCD01 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("txtMa_vitri")]
	private AsTextBox _txtMa_vitri;

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("lblMa_vitri")]
	private Label _lblMa_vitri;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtMa_tkvt")]
	private AsTextBox _txtMa_tkvt;

	[AccessedThroughProperty("lblTen_tkvt")]
	private Label _lblTen_tkvt;

	[AccessedThroughProperty("lblMa_tkvt")]
	private Label _lblMa_tkvt;

	[AccessedThroughProperty("txtMa_nhvt")]
	private AsTextBox _txtMa_nhvt;

	[AccessedThroughProperty("lblTen_nhvt")]
	private Label _lblTen_nhvt;

	[AccessedThroughProperty("lblMa_nhvt")]
	private Label _lblMa_nhvt;

	[AccessedThroughProperty("lblTen_plvt1")]
	private Label _lblTen_plvt1;

	[AccessedThroughProperty("lblMa_plvt1")]
	private Label _lblMa_plvt1;

	[AccessedThroughProperty("txtMa_plvt1")]
	private AsTextBox _txtMa_plvt1;

	[AccessedThroughProperty("txtMa_plvt2")]
	private AsTextBox _txtMa_plvt2;

	[AccessedThroughProperty("lblTen_plvt2")]
	private Label _lblTen_plvt2;

	[AccessedThroughProperty("lblMa_plvt2")]
	private Label _lblMa_plvt2;

	[AccessedThroughProperty("txtMa_plvt3")]
	private AsTextBox _txtMa_plvt3;

	[AccessedThroughProperty("lblTen_plvt3")]
	private Label _lblTen_plvt3;

	[AccessedThroughProperty("lblMa_plvt3")]
	private Label _lblMa_plvt3;

	[AccessedThroughProperty("txtOrder2")]
	private AsTextNumeric _txtOrder2;

	[AccessedThroughProperty("txtOrder1")]
	private AsTextNumeric _txtOrder1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("cboDVT")]
	private ComboBox _cboDVT;

	[AccessedThroughProperty("lblDVT")]
	private Label _lblDVT;

	[AccessedThroughProperty("lblOrder")]
	private Label _lblOrder;

	[AccessedThroughProperty("txtOrder3")]
	private AsTextNumeric _txtOrder3;

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

	[AccessedThroughProperty("ChkPsdc")]
	private AsCheckBox _ChkPsdc;

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

	internal virtual AsTextBox txtMa_tkvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_tkvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_tkvt = value;
		}
	}

	internal virtual Label lblTen_tkvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tkvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tkvt = value;
		}
	}

	internal virtual Label lblMa_tkvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_tkvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_tkvt = value;
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

	internal virtual Label lblMa_plvt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_plvt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_plvt1 = value;
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

	internal virtual Label lblMa_plvt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_plvt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_plvt2 = value;
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

	internal virtual Label lblMa_plvt3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_plvt3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_plvt3 = value;
		}
	}

	internal virtual AsTextNumeric txtOrder2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOrder2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOrder2 = value;
		}
	}

	internal virtual AsTextNumeric txtOrder1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOrder1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOrder1 = value;
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

	internal virtual Label lblOrder
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblOrder;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblOrder = value;
		}
	}

	internal virtual AsTextNumeric txtOrder3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOrder3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOrder3 = value;
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

	public frmINRptCD01(string MenuID)
		: base(MenuID)
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
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_20a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ab: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		lblMa_kho = new Label();
		txtMa_kho = new AsTextBox();
		lblTen_kho = new Label();
		lblTen_vitri = new Label();
		lblMa_vitri = new Label();
		txtMa_vitri = new AsTextBox();
		lblMa_vt = new Label();
		lblTen_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblTen_tkvt = new Label();
		lblMa_tkvt = new Label();
		txtMa_tkvt = new AsTextBox();
		lblMa_nhvt = new Label();
		lblTen_nhvt = new Label();
		txtMa_nhvt = new AsTextBox();
		lblTen_plvt1 = new Label();
		lblMa_plvt1 = new Label();
		txtMa_plvt1 = new AsTextBox();
		txtMa_plvt2 = new AsTextBox();
		lblTen_plvt2 = new Label();
		lblMa_plvt2 = new Label();
		lblTen_plvt3 = new Label();
		lblMa_plvt3 = new Label();
		txtMa_plvt3 = new AsTextBox();
		txtOrder2 = new AsTextNumeric();
		txtOrder1 = new AsTextNumeric();
		txtOrder3 = new AsTextNumeric();
		lblOrder = new Label();
		lblDVT = new Label();
		cboDVT = new ComboBox();
		Label1 = new Label();
		ChkPsdc = new AsCheckBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(819, 510);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)ChkPsdc);
		((Control)tabFilter).Controls.Add((Control)(object)lblDVT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_tkvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_tkvt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)txtOrder1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblOrder);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)cboDVT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tkvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plvt1);
		((Control)tabFilter).Controls.Add((Control)(object)txtOrder3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)txtOrder2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		TabPage obj = tabFilter;
		size = new Size(811, 481);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtOrder2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtOrder3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tkvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboDVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblOrder, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtOrder1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_plvt1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_tkvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_tkvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkPsdc, 0);
		Label obj2 = lbl2;
		Point location = new Point(354, 83);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 49;
		Button obj3 = cmdExcel;
		location = new Point(686, 445);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 19;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(371, 79);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(605, 445);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 18;
		((Control)cmdModifyReport).TabIndex = 21;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(283, 79);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj5 = cboKyBc;
		location = new Point(160, 79);
		((Control)obj5).Location = location;
		ComboBox obj6 = cboKyBc;
		size = new Size(100, 21);
		((Control)obj6).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		((Control)lblKyBc).TabIndex = 46;
		ComboBox obj7 = cboMau_bc;
		location = new Point(160, 25);
		((Control)obj7).Location = location;
		((Control)cboMau_bc).TabIndex = 20;
		((Control)lblMau_bc).TabIndex = 48;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(160, 264);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 9;
		Label obj8 = lblMauBC;
		location = new Point(205, 263);
		((Control)obj8).Location = location;
		((Control)lblMauBC).TabIndex = 23;
		RadioButton obj9 = optVND;
		location = new Point(283, 262);
		((Control)obj9).Location = location;
		((Control)optVND).TabIndex = 10;
		optVND.TabStop = false;
		RadioButton obj10 = optNt;
		location = new Point(346, 263);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 11;
		Label obj11 = lblMa_nt;
		location = new Point(24, 265);
		((Control)obj11).Location = location;
		((Control)lblMa_nt).TabIndex = 34;
		Button obj12 = cmdOk;
		location = new Point(24, 320);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 12;
		((Control)lblTieu_de).TabIndex = 47;
		TextBox obj13 = txtTieu_De;
		location = new Point(160, 53);
		((Control)obj13).Location = location;
		((Control)txtTieu_De).TabIndex = 22;
		crvReportViewer.ActiveViewIndex = -1;
		((UserControl)crvReportViewer).BorderStyle = (BorderStyle)1;
		crvReportViewer.DisplayGroupTree = false;
		((Control)crvReportViewer).Dock = (DockStyle)5;
		CrystalReportViewer obj14 = crvReportViewer;
		location = new Point(0, 0);
		((Control)obj14).Location = location;
		((Control)crvReportViewer).Name = "crvReportViewer";
		crvReportViewer.SelectionFormula = "";
		crvReportViewer.ShowRefreshButton = false;
		CrystalReportViewer obj15 = crvReportViewer;
		size = new Size(782, 459);
		((Control)obj15).Size = size;
		((Control)crvReportViewer).TabIndex = 0;
		crvReportViewer.ViewTimeSelectionFormula = "";
		lblMa_kho.AutoSize = true;
		Label obj16 = lblMa_kho;
		location = new Point(24, 109);
		((Control)obj16).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj17 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj17).Size = size;
		((Control)lblMa_kho).TabIndex = 45;
		lblMa_kho.Text = "Mã kho";
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_kho;
		location = new Point(160, 106);
		((Control)asTextBox2).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox3 = txtMa_kho;
		size = new Size(100, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_kho).TabIndex = 3;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		Label obj18 = lblTen_kho;
		location = new Point(266, 109);
		((Control)obj18).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj19 = lblTen_kho;
		size = new Size(464, 13);
		((Control)obj19).Size = size;
		((Control)lblTen_kho).TabIndex = 33;
		((Control)lblTen_vitri).Enabled = false;
		Label obj20 = lblTen_vitri;
		location = new Point(343, 441);
		((Control)obj20).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj21 = lblTen_vitri;
		size = new Size(297, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_vitri).TabIndex = 32;
		((Control)lblTen_vitri).Visible = false;
		lblMa_vitri.AutoSize = true;
		((Control)lblMa_vitri).Enabled = false;
		Label obj22 = lblMa_vitri;
		location = new Point(134, 441);
		((Control)obj22).Location = location;
		((Control)lblMa_vitri).Name = "lblMa_vitri";
		Label obj23 = lblMa_vitri;
		size = new Size(46, 13);
		((Control)obj23).Size = size;
		((Control)lblMa_vitri).TabIndex = 44;
		lblMa_vitri.Text = "Mã vị trí";
		((Control)lblMa_vitri).Visible = false;
		txtMa_vitri.AutoLookup = true;
		txtMa_vitri.AutoValid = false;
		((TextBoxBase)txtMa_vitri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vitri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vitri).Enabled = false;
		AsTextBox asTextBox4 = txtMa_vitri;
		location = new Point(220, 437);
		((Control)asTextBox4).Location = location;
		txtMa_vitri.LookupCodeName = "MA_VITRI";
		((Control)txtMa_vitri).Name = "txtMa_vitri";
		txtMa_vitri.NameControl = lblTen_vitri;
		AsTextBox asTextBox5 = txtMa_vitri;
		size = new Size(100, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_vitri).TabIndex = 4;
		((Control)txtMa_vitri).Tag = "MA_VITRI";
		txtMa_vitri.UseAutoCompleteSource = true;
		((Control)txtMa_vitri).Visible = false;
		lblMa_vt.AutoSize = true;
		Label obj24 = lblMa_vt;
		location = new Point(24, 135);
		((Control)obj24).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj25 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj25).Size = size;
		((Control)lblMa_vt).TabIndex = 43;
		lblMa_vt.Text = "Mã vật tư";
		Label obj26 = lblTen_vt;
		location = new Point(266, 135);
		((Control)obj26).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj27 = lblTen_vt;
		size = new Size(464, 13);
		((Control)obj27).Size = size;
		((Control)lblTen_vt).TabIndex = 31;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_vt;
		location = new Point(160, 132);
		((Control)asTextBox6).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox7 = txtMa_vt;
		size = new Size(100, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_vt).TabIndex = 4;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		Label obj28 = lblTen_tkvt;
		location = new Point(266, 187);
		((Control)obj28).Location = location;
		((Control)lblTen_tkvt).Name = "lblTen_tkvt";
		Label obj29 = lblTen_tkvt;
		size = new Size(464, 13);
		((Control)obj29).Size = size;
		((Control)lblTen_tkvt).TabIndex = 30;
		lblMa_tkvt.AutoSize = true;
		Label obj30 = lblMa_tkvt;
		location = new Point(24, 187);
		((Control)obj30).Location = location;
		((Control)lblMa_tkvt).Name = "lblMa_tkvt";
		Label obj31 = lblMa_tkvt;
		size = new Size(53, 13);
		((Control)obj31).Size = size;
		((Control)lblMa_tkvt).TabIndex = 42;
		lblMa_tkvt.Text = "Mã TKVT";
		txtMa_tkvt.AutoLookup = true;
		txtMa_tkvt.AutoValid = false;
		((TextBoxBase)txtMa_tkvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_tkvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_tkvt;
		location = new Point(160, 184);
		((Control)asTextBox8).Location = location;
		txtMa_tkvt.LookupCodeName = "TK";
		((Control)txtMa_tkvt).Name = "txtMa_tkvt";
		txtMa_tkvt.NameControl = lblTen_tkvt;
		AsTextBox asTextBox9 = txtMa_tkvt;
		size = new Size(100, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_tkvt).TabIndex = 6;
		((Control)txtMa_tkvt).Tag = "TK";
		txtMa_tkvt.UseAutoCompleteSource = true;
		lblMa_nhvt.AutoSize = true;
		Label obj32 = lblMa_nhvt;
		location = new Point(24, 161);
		((Control)obj32).Location = location;
		((Control)lblMa_nhvt).Name = "lblMa_nhvt";
		Label obj33 = lblMa_nhvt;
		size = new Size(65, 13);
		((Control)obj33).Size = size;
		((Control)lblMa_nhvt).TabIndex = 41;
		lblMa_nhvt.Text = "Nhóm vật tư";
		Label obj34 = lblTen_nhvt;
		location = new Point(266, 161);
		((Control)obj34).Location = location;
		((Control)lblTen_nhvt).Name = "lblTen_nhvt";
		Label obj35 = lblTen_nhvt;
		size = new Size(464, 13);
		((Control)obj35).Size = size;
		((Control)lblTen_nhvt).TabIndex = 29;
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_nhvt;
		location = new Point(160, 158);
		((Control)asTextBox10).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_nhvt;
		AsTextBox asTextBox11 = txtMa_nhvt;
		size = new Size(100, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_nhvt).TabIndex = 5;
		((Control)txtMa_nhvt).Tag = "MA_NHVT";
		txtMa_nhvt.UseAutoCompleteSource = true;
		((Control)lblTen_plvt1).Enabled = false;
		Label obj36 = lblTen_plvt1;
		location = new Point(609, 347);
		((Control)obj36).Location = location;
		((Control)lblTen_plvt1).Name = "lblTen_plvt1";
		Label obj37 = lblTen_plvt1;
		size = new Size(297, 13);
		((Control)obj37).Size = size;
		((Control)lblTen_plvt1).TabIndex = 28;
		((Control)lblTen_plvt1).Visible = false;
		lblMa_plvt1.AutoSize = true;
		((Control)lblMa_plvt1).Enabled = false;
		Label obj38 = lblMa_plvt1;
		location = new Point(400, 347);
		((Control)obj38).Location = location;
		((Control)lblMa_plvt1).Name = "lblMa_plvt1";
		Label obj39 = lblMa_plvt1;
		size = new Size(59, 13);
		((Control)obj39).Size = size;
		((Control)lblMa_plvt1).TabIndex = 40;
		lblMa_plvt1.Text = "P.loại VT 1";
		((Control)lblMa_plvt1).Visible = false;
		txtMa_plvt1.AutoLookup = true;
		txtMa_plvt1.AutoValid = false;
		((TextBoxBase)txtMa_plvt1).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt1).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt1).Enabled = false;
		AsTextBox asTextBox12 = txtMa_plvt1;
		location = new Point(486, 343);
		((Control)asTextBox12).Location = location;
		txtMa_plvt1.LookupCodeName = "MA_PLVT";
		txtMa_plvt1.LookupWhereCondition = "loai = '1'";
		((Control)txtMa_plvt1).Name = "txtMa_plvt1";
		txtMa_plvt1.NameControl = lblTen_plvt1;
		AsTextBox asTextBox13 = txtMa_plvt1;
		size = new Size(100, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_plvt1).TabIndex = 8;
		((Control)txtMa_plvt1).Tag = "MA_PLVT";
		txtMa_plvt1.UseAutoCompleteSource = true;
		((Control)txtMa_plvt1).Visible = false;
		txtMa_plvt2.AutoLookup = true;
		txtMa_plvt2.AutoValid = false;
		((TextBoxBase)txtMa_plvt2).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt2).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt2).Enabled = false;
		AsTextBox asTextBox14 = txtMa_plvt2;
		location = new Point(486, 369);
		((Control)asTextBox14).Location = location;
		txtMa_plvt2.LookupCodeName = "MA_PLVT";
		txtMa_plvt2.LookupWhereCondition = "loai = '2'";
		((Control)txtMa_plvt2).Name = "txtMa_plvt2";
		txtMa_plvt2.NameControl = lblTen_plvt2;
		AsTextBox asTextBox15 = txtMa_plvt2;
		size = new Size(100, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_plvt2).TabIndex = 9;
		((Control)txtMa_plvt2).Tag = "MA_PLVT";
		txtMa_plvt2.UseAutoCompleteSource = true;
		((Control)txtMa_plvt2).Visible = false;
		((Control)lblTen_plvt2).Enabled = false;
		Label obj40 = lblTen_plvt2;
		location = new Point(609, 373);
		((Control)obj40).Location = location;
		((Control)lblTen_plvt2).Name = "lblTen_plvt2";
		Label obj41 = lblTen_plvt2;
		size = new Size(297, 13);
		((Control)obj41).Size = size;
		((Control)lblTen_plvt2).TabIndex = 27;
		((Control)lblTen_plvt2).Visible = false;
		lblMa_plvt2.AutoSize = true;
		((Control)lblMa_plvt2).Enabled = false;
		Label obj42 = lblMa_plvt2;
		location = new Point(400, 373);
		((Control)obj42).Location = location;
		((Control)lblMa_plvt2).Name = "lblMa_plvt2";
		Label obj43 = lblMa_plvt2;
		size = new Size(59, 13);
		((Control)obj43).Size = size;
		((Control)lblMa_plvt2).TabIndex = 39;
		lblMa_plvt2.Text = "P.loại VT 2";
		((Control)lblMa_plvt2).Visible = false;
		((Control)lblTen_plvt3).Enabled = false;
		Label obj44 = lblTen_plvt3;
		location = new Point(609, 399);
		((Control)obj44).Location = location;
		((Control)lblTen_plvt3).Name = "lblTen_plvt3";
		Label obj45 = lblTen_plvt3;
		size = new Size(297, 13);
		((Control)obj45).Size = size;
		((Control)lblTen_plvt3).TabIndex = 26;
		((Control)lblTen_plvt3).Visible = false;
		lblMa_plvt3.AutoSize = true;
		((Control)lblMa_plvt3).Enabled = false;
		Label obj46 = lblMa_plvt3;
		location = new Point(400, 399);
		((Control)obj46).Location = location;
		((Control)lblMa_plvt3).Name = "lblMa_plvt3";
		Label obj47 = lblMa_plvt3;
		size = new Size(59, 13);
		((Control)obj47).Size = size;
		((Control)lblMa_plvt3).TabIndex = 38;
		lblMa_plvt3.Text = "P.loại VT 3";
		((Control)lblMa_plvt3).Visible = false;
		txtMa_plvt3.AutoLookup = true;
		txtMa_plvt3.AutoValid = false;
		((TextBoxBase)txtMa_plvt3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plvt3).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_plvt3).Enabled = false;
		AsTextBox asTextBox16 = txtMa_plvt3;
		location = new Point(486, 395);
		((Control)asTextBox16).Location = location;
		txtMa_plvt3.LookupCodeName = "MA_PLVT";
		txtMa_plvt3.LookupWhereCondition = "loai = '3'";
		((Control)txtMa_plvt3).Name = "txtMa_plvt3";
		txtMa_plvt3.NameControl = lblTen_plvt3;
		AsTextBox asTextBox17 = txtMa_plvt3;
		size = new Size(100, 20);
		((Control)asTextBox17).Size = size;
		((Control)txtMa_plvt3).TabIndex = 10;
		((Control)txtMa_plvt3).Tag = "MA_PLVT";
		txtMa_plvt3.UseAutoCompleteSource = true;
		((Control)txtMa_plvt3).Visible = false;
		txtOrder2.DecimalSymbol = ".";
		((Control)txtOrder2).Enabled = false;
		AsTextNumeric asTextNumeric = txtOrder2;
		location = new Point(536, 418);
		((Control)asTextNumeric).Location = location;
		txtOrder2.Mask = "#";
		((Control)txtOrder2).Name = "txtOrder2";
		AsTextNumeric asTextNumeric2 = txtOrder2;
		size = new Size(29, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtOrder2).TabIndex = 12;
		((TextBox)txtOrder2).Text = "0";
		((TextBox)txtOrder2).TextAlign = (HorizontalAlignment)1;
		txtOrder2.Value = 0.0;
		((Control)txtOrder2).Visible = false;
		txtOrder1.DecimalSymbol = ".";
		((Control)txtOrder1).Enabled = false;
		AsTextNumeric asTextNumeric3 = txtOrder1;
		location = new Point(501, 418);
		((Control)asTextNumeric3).Location = location;
		txtOrder1.Mask = "#";
		((Control)txtOrder1).Name = "txtOrder1";
		AsTextNumeric asTextNumeric4 = txtOrder1;
		size = new Size(29, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtOrder1).TabIndex = 11;
		((TextBox)txtOrder1).Text = "0";
		((TextBox)txtOrder1).TextAlign = (HorizontalAlignment)1;
		txtOrder1.Value = 0.0;
		((Control)txtOrder1).Visible = false;
		txtOrder3.DecimalSymbol = ".";
		((Control)txtOrder3).Enabled = false;
		AsTextNumeric asTextNumeric5 = txtOrder3;
		location = new Point(571, 418);
		((Control)asTextNumeric5).Location = location;
		txtOrder3.Mask = "#";
		((Control)txtOrder3).Name = "txtOrder3";
		AsTextNumeric asTextNumeric6 = txtOrder3;
		size = new Size(29, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtOrder3).TabIndex = 13;
		((TextBox)txtOrder3).Text = "0";
		((TextBox)txtOrder3).TextAlign = (HorizontalAlignment)1;
		txtOrder3.Value = 0.0;
		((Control)txtOrder3).Visible = false;
		lblOrder.AutoSize = true;
		((Control)lblOrder).Enabled = false;
		Label obj48 = lblOrder;
		location = new Point(415, 422);
		((Control)obj48).Location = location;
		((Control)lblOrder).Name = "lblOrder";
		Label obj49 = lblOrder;
		size = new Size(84, 13);
		((Control)obj49).Size = size;
		((Control)lblOrder).TabIndex = 37;
		lblOrder.Text = "Thứ tự phân loại";
		((Control)lblOrder).Visible = false;
		lblDVT.AutoSize = true;
		Label obj50 = lblDVT;
		location = new Point(24, 213);
		((Control)obj50).Location = location;
		((Control)lblDVT).Name = "lblDVT";
		Label obj51 = lblDVT;
		size = new Size(60, 13);
		((Control)obj51).Size = size;
		((Control)lblDVT).TabIndex = 36;
		lblDVT.Text = "Đơn vị tính";
		cboDVT.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboDVT).FormattingEnabled = true;
		cboDVT.Items.AddRange(new object[3] { "Đơn vị tính Kho", "Đơn vị tính Mua", "Đơn vị tính Bán" });
		ComboBox obj52 = cboDVT;
		location = new Point(160, 210);
		((Control)obj52).Location = location;
		((Control)cboDVT).Name = "cboDVT";
		ComboBox obj53 = cboDVT;
		size = new Size(100, 21);
		((Control)obj53).Size = size;
		((Control)cboDVT).TabIndex = 7;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(24, 240);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(83, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 35;
		Label1.Text = "PS điều chuyển";
		((ButtonBase)ChkPsdc).AutoSize = true;
		ChkPsdc.Checked = true;
		((CheckBox)ChkPsdc).CheckState = (CheckState)1;
		AsCheckBox chkPsdc = ChkPsdc;
		location = new Point(160, 239);
		((Control)chkPsdc).Location = location;
		((Control)ChkPsdc).Name = "ChkPsdc";
		AsCheckBox chkPsdc2 = ChkPsdc;
		size = new Size(157, 17);
		((Control)chkPsdc2).Size = size;
		((Control)ChkPsdc).TabIndex = 8;
		((ButtonBase)ChkPsdc).Text = "Tính phát sinh điều chuyển";
		((ButtonBase)ChkPsdc).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(819, 532);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmINRptCD01";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		base.InitOtherComponents();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		ComboBox val = cboDVT;
		dictionary.Add("0", Conversions.ToString(val.Items[0]));
		dictionary.Add("1", Conversions.ToString(val.Items[1]));
		dictionary.Add("2", Conversions.ToString(val.Items[2]));
		BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
		val.DataSource = dataSource;
		((ListControl)val).ValueMember = "key";
		((ListControl)val).DisplayMember = "value";
		val.SelectedIndex = 0;
		val = null;
	}

	protected override bool ValidData()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		if ((Conversions.ToInteger(((TextBox)txtOrder1).Text) < 0 || Conversions.ToInteger(((TextBox)txtOrder1).Text) > 3 || Conversions.ToInteger(((TextBox)txtOrder2).Text) < 0 || Conversions.ToInteger(((TextBox)txtOrder2).Text) > 3 || Conversions.ToInteger(((TextBox)txtOrder3).Text) < 0 || Conversions.ToInteger(((TextBox)txtOrder3).Text) > 3) && 0 == 0)
		{
			CMessageBox.Show(50034);
			return false;
		}
		if (Conversions.ToInteger(((TextBox)txtOrder1).Text) != 0)
		{
			if (((TextBox)txtOrder1).Text.CompareTo(((TextBox)txtOrder2).Text) == 0)
			{
				CMessageBox.Show(50034);
				return false;
			}
			if (((TextBox)txtOrder1).Text.CompareTo(((TextBox)txtOrder3).Text) == 0)
			{
				CMessageBox.Show(50034);
				return false;
			}
		}
		if (Conversions.ToInteger(((TextBox)txtOrder2).Text) != 0)
		{
			if (((TextBox)txtOrder2).Text.CompareTo(((TextBox)txtOrder1).Text) == 0)
			{
				CMessageBox.Show(50034);
				return false;
			}
			if (((TextBox)txtOrder2).Text.CompareTo(((TextBox)txtOrder3).Text) == 0)
			{
				CMessageBox.Show(50034);
				return false;
			}
		}
		if (Conversions.ToInteger(((TextBox)txtOrder3).Text) != 0)
		{
			if (((TextBox)txtOrder3).Text.CompareTo(((TextBox)txtOrder1).Text) == 0)
			{
				CMessageBox.Show(50034);
				return false;
			}
			if (((TextBox)txtOrder3).Text.CompareTo(((TextBox)txtOrder2).Text) == 0)
			{
				CMessageBox.Show(50034);
				return false;
			}
		}
		return base.ValidData();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(cboMau_bc.Text);
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_tkvt).Text);
		arrayList.Add(((TextBox)txtMa_nhvt).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_vitri).Text);
		arrayList.Add(((TextBox)txtMa_plvt1).Text);
		arrayList.Add(((TextBox)txtMa_plvt2).Text);
		arrayList.Add(((TextBox)txtMa_plvt3).Text);
		arrayList.Add(((TextBox)txtOrder1).Text);
		arrayList.Add(((TextBox)txtOrder2).Text);
		arrayList.Add(((TextBox)txtOrder3).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboDVT).SelectedValue));
		if (Conversions.ToBoolean(ChkPsdc.Checked))
		{
			arrayList.Add("1");
		}
		else
		{
			arrayList.Add("0");
		}
		if (optNt.Checked)
		{
			arrayList.Add("1");
		}
		else
		{
			arrayList.Add("0");
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
		if (((int)keycode != 116 || Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false), (object)"", false) || Operators.ConditionalCompareObjectEqual(dataRowView["bold"], (object)1, false)) ? true : false)
		{
			base.CancelDrilldown = true;
			return null;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(dataRowView["ma_vt"].ToString());
		if (get_MyDGVSource(isSet2Print: true).DefaultView.Table.Columns.Contains("ma_kho"))
		{
			arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_kho"]), isNum: false)));
			arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vitri"]), isNum: false)));
		}
		else
		{
			arrayList.Add(((TextBox)txtMa_kho).Text);
			arrayList.Add(((TextBox)txtMa_vitri).Text);
		}
		if (get_MyDGVSource(isSet2Print: true).DefaultView.Table.Columns.Contains("ma_lo"))
		{
			arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_lo"]), isNum: false)));
		}
		else
		{
			arrayList.Add("");
		}
		arrayList.Add("");
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add("%");
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

	public string GetFilterTitle()
	{
		string text = string.Empty;
		if (Operators.CompareString(((TextBox)txtMa_kho).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": [" + ((TextBox)txtMa_kho).Text + "]";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhvt).Text.Trim(), "", false) != 0)
		{
			text = text + ", " + lblMa_nhvt.Text + ": [" + ((TextBox)txtMa_nhvt).Text + "]";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text.Trim(), "", false) != 0)
		{
			text = text + ", " + lblMa_nt.Text + ": [" + ((TextBox)txtMa_Nt).Text + "]";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt1).Text.Trim(), "", false) != 0)
		{
			text = text + ", " + lblMa_plvt1.Text + ": [" + ((TextBox)txtMa_plvt1).Text + "]";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt2).Text.Trim(), "", false) != 0)
		{
			text = text + ", " + lblMa_plvt2.Text + ": [" + ((TextBox)txtMa_plvt2).Text + "]";
		}
		if (Operators.CompareString(((TextBox)txtMa_plvt3).Text.Trim(), "", false) != 0)
		{
			text = text + ", " + lblMa_plvt3.Text + ": [" + ((TextBox)txtMa_plvt3).Text + "]";
		}
		if (Operators.CompareString(((TextBox)txtMa_tkvt).Text.Trim(), "", false) != 0)
		{
			text = text + ", " + lblMa_tkvt.Text + ": [" + ((TextBox)txtMa_tkvt).Text + "]";
		}
		if (Operators.CompareString(((TextBox)txtMa_vitri).Text.Trim(), "", false) != 0)
		{
			text = text + ", " + lblMa_vitri.Text + ": [" + ((TextBox)txtMa_vitri).Text + "]";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text.Trim(), "", false) != 0)
		{
			text = text + ", " + lblMa_vt.Text + ": [" + ((TextBox)txtMa_vt).Text + "]";
		}
		return text;
	}
}
