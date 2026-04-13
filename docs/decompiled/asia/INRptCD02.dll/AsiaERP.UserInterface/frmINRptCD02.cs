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

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmINRptCD02 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("txtNh_vt")]
	private AsTextBox _txtNh_vt;

	[AccessedThroughProperty("lblTen_nhvt")]
	private Label _lblTen_nhvt;

	[AccessedThroughProperty("lblNhom_vt")]
	private Label _lblNhom_vt;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("txtMa_vitri")]
	private AsTextBox _txtMa_vitri;

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("lblMa_vitri")]
	private Label _lblMa_vitri;

	[AccessedThroughProperty("cboDVT")]
	private ComboBox _cboDVT;

	[AccessedThroughProperty("lblMa_dvt")]
	private Label _lblMa_dvt;

	[AccessedThroughProperty("txtMa_tkvt")]
	private AsTextBox _txtMa_tkvt;

	[AccessedThroughProperty("lblTen_tkvt")]
	private Label _lblTen_tkvt;

	[AccessedThroughProperty("lblMa_tkvt")]
	private Label _lblMa_tkvt;

	[AccessedThroughProperty("txtNgay")]
	private AsMaskedTextBox _txtNgay;

	[AccessedThroughProperty("lblDate")]
	private Label _lblDate;

	[AccessedThroughProperty("txtMa_lo")]
	private AsTextBox _txtMa_lo;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("rbCk")]
	private RadioButton _rbCk;

	[AccessedThroughProperty("rbDK")]
	private RadioButton _rbDK;

	[AccessedThroughProperty("ChkQuaToiDa")]
	private CheckBox _ChkQuaToiDa;

	[AccessedThroughProperty("ChkQuaToiThieu")]
	private CheckBox _ChkQuaToiThieu;

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

	protected override ComboBox cboMau_bc
	{
		[DebuggerNonUserCode]
		get
		{
			return base.cboMau_bc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboMau_bc_SelectedIndexChanged;
			if (base.cboMau_bc != null)
			{
				base.cboMau_bc.SelectedIndexChanged -= eventHandler;
			}
			base.cboMau_bc = value;
			if (base.cboMau_bc != null)
			{
				base.cboMau_bc.SelectedIndexChanged += eventHandler;
			}
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

	internal virtual AsTextBox txtNh_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNh_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNh_vt = value;
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

	internal virtual Label lblNhom_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNhom_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNhom_vt = value;
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

	internal virtual Label lblMa_dvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_dvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_dvt = value;
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

	internal virtual AsMaskedTextBox txtNgay
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay = value;
		}
	}

	internal virtual Label lblDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDate = value;
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

	internal virtual RadioButton rbCk
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbCk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rbCk = value;
		}
	}

	internal virtual RadioButton rbDK
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbDK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbDK_CheckedChanged;
			if (_rbDK != null)
			{
				_rbDK.CheckedChanged -= eventHandler;
			}
			_rbDK = value;
			if (_rbDK != null)
			{
				_rbDK.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual CheckBox ChkQuaToiDa
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkQuaToiDa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkQuaToiDa = value;
		}
	}

	internal virtual CheckBox ChkQuaToiThieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkQuaToiThieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkQuaToiThieu = value;
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

	public frmINRptCD02(string MenuID)
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
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
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
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_1b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9c: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		lblMa_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		lblTen_nhvt = new Label();
		lblNhom_vt = new Label();
		txtNh_vt = new AsTextBox();
		lblMa_kho = new Label();
		lblTen_kho = new Label();
		txtMa_kho = new AsTextBox();
		lblTen_vitri = new Label();
		lblMa_vitri = new Label();
		txtMa_vitri = new AsTextBox();
		lblMa_tkvt = new Label();
		lblTen_tkvt = new Label();
		txtMa_tkvt = new AsTextBox();
		lblMa_dvt = new Label();
		cboDVT = new ComboBox();
		lblDate = new Label();
		txtNgay = new AsMaskedTextBox();
		txtMa_lo = new AsTextBox();
		Label1 = new Label();
		Label2 = new Label();
		Panel1 = new Panel();
		rbCk = new RadioButton();
		rbDK = new RadioButton();
		Label3 = new Label();
		ChkQuaToiThieu = new CheckBox();
		ChkQuaToiDa = new CheckBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(816, 573);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)ChkQuaToiDa);
		((Control)tabFilter).Controls.Add((Control)(object)ChkQuaToiThieu);
		((Control)tabFilter).Controls.Add((Control)(object)Label3);
		((Control)tabFilter).Controls.Add((Control)(object)Panel1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_lo);
		((Control)tabFilter).Controls.Add((Control)(object)Label2);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)txtNgay);
		((Control)tabFilter).Controls.Add((Control)(object)lblDate);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtNh_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_tkvt);
		((Control)tabFilter).Controls.Add((Control)(object)cboDVT);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_tkvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_dvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tkvt);
		TabPage obj = tabFilter;
		size = new Size(808, 544);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tkvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_dvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_tkvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboDVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_tkvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNh_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDate, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_lo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Panel1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkQuaToiThieu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)ChkQuaToiDa, 0);
		Label obj2 = lbl2;
		Point location = new Point(696, 518);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(567, 705);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 11;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(715, 514);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).Visible = false;
		Button obj4 = cmdCancel;
		location = new Point(486, 702);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 10;
		((Control)cmdModifyReport).TabIndex = 1;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(625, 514);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).Visible = false;
		ComboBox obj5 = cboKyBc;
		location = new Point(529, 514);
		((Control)obj5).Location = location;
		((Control)cboKyBc).Visible = false;
		Label obj6 = lblKyBc;
		location = new Point(443, 518);
		((Control)obj6).Location = location;
		((Control)lblKyBc).Visible = false;
		ComboBox obj7 = cboMau_bc;
		location = new Point(165, 25);
		((Control)obj7).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(526, 554);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 8;
		((Control)txtMa_Nt).Visible = false;
		Label obj8 = lblMauBC;
		location = new Point(579, 553);
		((Control)obj8).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj9 = optVND;
		location = new Point(654, 552);
		((Control)obj9).Location = location;
		((Control)optVND).TabIndex = 14;
		optVND.TabStop = false;
		((Control)optVND).Visible = false;
		RadioButton obj10 = optNt;
		location = new Point(715, 553);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 15;
		((Control)optNt).Visible = false;
		Label obj11 = lblMa_nt;
		location = new Point(439, 556);
		((Control)obj11).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj12 = cmdOk;
		location = new Point(27, 362);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 13;
		TextBox obj13 = txtTieu_De;
		location = new Point(165, 53);
		((Control)obj13).Location = location;
		((Control)txtTieu_De).TabIndex = 2;
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
		lblMa_vt.AutoSize = true;
		Label obj16 = lblMa_vt;
		location = new Point(24, 161);
		((Control)obj16).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj17 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj17).Size = size;
		((Control)lblMa_vt).TabIndex = 1016;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_vt;
		location = new Point(165, 158);
		((Control)asTextBox2).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox3 = txtMa_vt;
		size = new Size(100, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_vt).TabIndex = 5;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		Label obj18 = lblTen_vt;
		location = new Point(271, 162);
		((Control)obj18).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj19 = lblTen_vt;
		size = new Size(477, 13);
		((Control)obj19).Size = size;
		((Control)lblTen_vt).TabIndex = 1016;
		Label obj20 = lblTen_nhvt;
		location = new Point(271, 188);
		((Control)obj20).Location = location;
		((Control)lblTen_nhvt).Name = "lblTen_nhvt";
		Label obj21 = lblTen_nhvt;
		size = new Size(477, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_nhvt).TabIndex = 1016;
		lblNhom_vt.AutoSize = true;
		Label obj22 = lblNhom_vt;
		location = new Point(24, 187);
		((Control)obj22).Location = location;
		((Control)lblNhom_vt).Name = "lblNhom_vt";
		Label obj23 = lblNhom_vt;
		size = new Size(65, 13);
		((Control)obj23).Size = size;
		((Control)lblNhom_vt).TabIndex = 1016;
		lblNhom_vt.Text = "Nhóm vật tư";
		txtNh_vt.AutoLookup = true;
		txtNh_vt.AutoValid = false;
		((TextBoxBase)txtNh_vt).BackColor = SystemColors.Info;
		((TextBox)txtNh_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtNh_vt;
		location = new Point(165, 184);
		((Control)asTextBox4).Location = location;
		txtNh_vt.LookupCodeName = "MA_NHVT";
		((Control)txtNh_vt).Name = "txtNh_vt";
		txtNh_vt.NameControl = lblTen_nhvt;
		AsTextBox asTextBox5 = txtNh_vt;
		size = new Size(100, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtNh_vt).TabIndex = 6;
		((Control)txtNh_vt).Tag = "MA_NHVT";
		txtNh_vt.UseAutoCompleteSource = true;
		lblMa_kho.AutoSize = true;
		Label obj24 = lblMa_kho;
		location = new Point(24, 135);
		((Control)obj24).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj25 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj25).Size = size;
		((Control)lblMa_kho).TabIndex = 1016;
		lblMa_kho.Text = "Mã kho";
		Label obj26 = lblTen_kho;
		location = new Point(271, 136);
		((Control)obj26).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj27 = lblTen_kho;
		size = new Size(477, 13);
		((Control)obj27).Size = size;
		((Control)lblTen_kho).TabIndex = 1016;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_kho;
		location = new Point(165, 132);
		((Control)asTextBox6).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox7 = txtMa_kho;
		size = new Size(100, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_kho).TabIndex = 4;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		((Control)lblTen_vitri).Enabled = false;
		Label obj28 = lblTen_vitri;
		location = new Point(207, 417);
		((Control)obj28).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj29 = lblTen_vitri;
		size = new Size(314, 13);
		((Control)obj29).Size = size;
		((Control)lblTen_vitri).TabIndex = 1016;
		((Control)lblTen_vitri).Visible = false;
		lblMa_vitri.AutoSize = true;
		((Control)lblMa_vitri).Enabled = false;
		Label obj30 = lblMa_vitri;
		location = new Point(15, 417);
		((Control)obj30).Location = location;
		((Control)lblMa_vitri).Name = "lblMa_vitri";
		Label obj31 = lblMa_vitri;
		size = new Size(46, 13);
		((Control)obj31).Size = size;
		((Control)lblMa_vitri).TabIndex = 1016;
		lblMa_vitri.Text = "Mã vị trí";
		((Control)lblMa_vitri).Visible = false;
		txtMa_vitri.AutoLookup = true;
		txtMa_vitri.AutoValid = false;
		((TextBoxBase)txtMa_vitri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vitri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vitri).Enabled = false;
		AsTextBox asTextBox8 = txtMa_vitri;
		location = new Point(101, 413);
		((Control)asTextBox8).Location = location;
		txtMa_vitri.LookupCodeName = "MA_VITRI";
		((Control)txtMa_vitri).Name = "txtMa_vitri";
		txtMa_vitri.NameControl = lblTen_vitri;
		AsTextBox asTextBox9 = txtMa_vitri;
		size = new Size(100, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_vitri).TabIndex = 7;
		((Control)txtMa_vitri).Tag = "MA_VITRI";
		txtMa_vitri.UseAutoCompleteSource = true;
		((Control)txtMa_vitri).Visible = false;
		lblMa_tkvt.AutoSize = true;
		Label obj32 = lblMa_tkvt;
		location = new Point(24, 213);
		((Control)obj32).Location = location;
		((Control)lblMa_tkvt).Name = "lblMa_tkvt";
		Label obj33 = lblMa_tkvt;
		size = new Size(53, 13);
		((Control)obj33).Size = size;
		((Control)lblMa_tkvt).TabIndex = 1016;
		lblMa_tkvt.Text = "Mã TKVT";
		Label obj34 = lblTen_tkvt;
		location = new Point(271, 214);
		((Control)obj34).Location = location;
		((Control)lblTen_tkvt).Name = "lblTen_tkvt";
		Label obj35 = lblTen_tkvt;
		size = new Size(477, 13);
		((Control)obj35).Size = size;
		((Control)lblTen_tkvt).TabIndex = 1016;
		txtMa_tkvt.AutoLookup = true;
		txtMa_tkvt.AutoValid = false;
		((TextBoxBase)txtMa_tkvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_tkvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_tkvt;
		location = new Point(165, 210);
		((Control)asTextBox10).Location = location;
		txtMa_tkvt.LookupCodeName = "TK";
		((Control)txtMa_tkvt).Name = "txtMa_tkvt";
		txtMa_tkvt.NameControl = lblTen_tkvt;
		AsTextBox asTextBox11 = txtMa_tkvt;
		size = new Size(100, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_tkvt).TabIndex = 7;
		((Control)txtMa_tkvt).Tag = "TK";
		txtMa_tkvt.UseAutoCompleteSource = true;
		lblMa_dvt.AutoSize = true;
		Label obj36 = lblMa_dvt;
		location = new Point(24, 265);
		((Control)obj36).Location = location;
		((Control)lblMa_dvt).Name = "lblMa_dvt";
		Label obj37 = lblMa_dvt;
		size = new Size(60, 13);
		((Control)obj37).Size = size;
		((Control)lblMa_dvt).TabIndex = 1018;
		lblMa_dvt.Text = "Đơn vị tính";
		cboDVT.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboDVT).FormattingEnabled = true;
		cboDVT.Items.AddRange(new object[3] { "Đơn vị tính kho", "Đơn vị tính mua", "Đơn vị tính bán" });
		ComboBox obj38 = cboDVT;
		location = new Point(165, 262);
		((Control)obj38).Location = location;
		((Control)cboDVT).Name = "cboDVT";
		ComboBox obj39 = cboDVT;
		size = new Size(100, 21);
		((Control)obj39).Size = size;
		((Control)cboDVT).TabIndex = 10;
		lblDate.AutoSize = true;
		Label obj40 = lblDate;
		location = new Point(24, 108);
		((Control)obj40).Location = location;
		((Control)lblDate).Name = "lblDate";
		Label obj41 = lblDate;
		size = new Size(32, 13);
		((Control)obj41).Size = size;
		((Control)lblDate).TabIndex = 1020;
		lblDate.Text = "Ngày";
		txtNgay.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox3 = txtNgay;
		location = new Point(165, 106);
		((Control)asMaskedTextBox3).Location = location;
		((MaskedTextBox)txtNgay).Mask = "##/##/####";
		((Control)txtNgay).Name = "txtNgay";
		((MaskedTextBox)txtNgay).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox4 = txtNgay;
		size = new Size(100, 20);
		((Control)asMaskedTextBox4).Size = size;
		((Control)txtNgay).TabIndex = 3;
		((MaskedTextBox)txtNgay).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox5 = txtNgay;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox5.Value = dateTime;
		txtMa_lo.AutoLookup = true;
		txtMa_lo.AutoValid = false;
		((TextBoxBase)txtMa_lo).BackColor = SystemColors.Info;
		((TextBox)txtMa_lo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_lo;
		location = new Point(165, 236);
		((Control)asTextBox12).Location = location;
		txtMa_lo.LookupCodeName = "MA_LO";
		((Control)txtMa_lo).Name = "txtMa_lo";
		txtMa_lo.NameControl = Label1;
		AsTextBox asTextBox13 = txtMa_lo;
		size = new Size(100, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_lo).TabIndex = 8;
		((Control)txtMa_lo).Tag = "MA_LO";
		txtMa_lo.UseAutoCompleteSource = true;
		Label label = Label1;
		location = new Point(271, 240);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(477, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1025;
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(24, 239);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(33, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 1026;
		Label2.Text = "Mã lô";
		((Control)Panel1).Controls.Add((Control)(object)rbCk);
		((Control)Panel1).Controls.Add((Control)(object)rbDK);
		Panel panel = Panel1;
		location = new Point(165, 79);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(134, 23);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 1027;
		((ButtonBase)rbCk).AutoSize = true;
		RadioButton obj42 = rbCk;
		location = new Point(68, 3);
		((Control)obj42).Location = location;
		((Control)rbCk).Name = "rbCk";
		RadioButton obj43 = rbCk;
		size = new Size(60, 17);
		((Control)obj43).Size = size;
		((Control)rbCk).TabIndex = 1;
		rbCk.TabStop = true;
		((ButtonBase)rbCk).Text = "Cuối kỳ";
		((ButtonBase)rbCk).UseVisualStyleBackColor = true;
		((ButtonBase)rbDK).AutoSize = true;
		rbDK.Checked = true;
		RadioButton obj44 = rbDK;
		location = new Point(3, 3);
		((Control)obj44).Location = location;
		((Control)rbDK).Name = "rbDK";
		RadioButton obj45 = rbDK;
		size = new Size(59, 17);
		((Control)obj45).Size = size;
		((Control)rbDK).TabIndex = 0;
		rbDK.TabStop = true;
		((ButtonBase)rbDK).Text = "Đầu kỳ";
		((ButtonBase)rbDK).UseVisualStyleBackColor = true;
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(24, 83);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(29, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 1028;
		Label3.Text = "Tồn ";
		((ButtonBase)ChkQuaToiThieu).AutoSize = true;
		CheckBox chkQuaToiThieu = ChkQuaToiThieu;
		location = new Point(165, 289);
		((Control)chkQuaToiThieu).Location = location;
		((Control)ChkQuaToiThieu).Name = "ChkQuaToiThieu";
		CheckBox chkQuaToiThieu2 = ChkQuaToiThieu;
		size = new Size(150, 17);
		((Control)chkQuaToiThieu2).Size = size;
		((Control)ChkQuaToiThieu).TabIndex = 11;
		((ButtonBase)ChkQuaToiThieu).Text = "Tồn nhỏ hơn mức tối thiểu";
		((ButtonBase)ChkQuaToiThieu).UseVisualStyleBackColor = true;
		((ButtonBase)ChkQuaToiDa).AutoSize = true;
		CheckBox chkQuaToiDa = ChkQuaToiDa;
		location = new Point(165, 312);
		((Control)chkQuaToiDa).Location = location;
		((Control)ChkQuaToiDa).Name = "ChkQuaToiDa";
		CheckBox chkQuaToiDa2 = ChkQuaToiDa;
		size = new Size(136, 17);
		((Control)chkQuaToiDa2).Size = size;
		((Control)ChkQuaToiDa).TabIndex = 12;
		((ButtonBase)ChkQuaToiDa).Text = "Tồn lớn hơn mức tối đa";
		((ButtonBase)ChkQuaToiDa).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(816, 595);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmINRptCD02";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		base.InitOtherComponents();
		txtNgay.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("den_ngay"));
		if (AsiaErp.Framework.Environment.get_PublicVariables("den_ngay") == null)
		{
			txtNgay.Value = DateTime.Now;
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		ComboBox val = cboDVT;
		dictionary.Add("0", Conversions.ToString(val.Items[0]));
		dictionary.Add("1", Conversions.ToString(val.Items[1]));
		dictionary.Add("2", Conversions.ToString(val.Items[2]));
		BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
		((ListControl)val).DisplayMember = "value";
		((ListControl)val).ValueMember = "key";
		val.DataSource = dataSource;
		val.SelectedIndex = 0;
		val = null;
		txtTieu_De.Text = Conversions.ToString(Operators.AddObject((object)(base.MyReportInfo.title + " "), Interaction.IIf(rbDK.Checked, (object)((ButtonBase)rbDK).Text.ToUpper(), (object)((ButtonBase)rbCk).Text.ToUpper())));
	}

	protected override bool LoadData()
	{
		AsiaErp.Framework.Environment.set_PublicVariables("den_ngay", RuntimeHelpers.GetObjectValue(txtNgay.Value));
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(((TextBox)txtMa_vt).Text.Trim());
		arrayList.Add(((TextBox)txtMa_kho).Text.Trim());
		arrayList.Add(((TextBox)txtMa_vitri).Text.Trim());
		arrayList.Add(((TextBox)txtMa_tkvt).Text.Trim());
		arrayList.Add(((TextBox)txtNh_vt).Text.Trim());
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboDVT).SelectedValue));
		if (optNt.Checked)
		{
			arrayList.Add("1");
		}
		else
		{
			arrayList.Add("0");
		}
		arrayList.Add(rbCk.Checked);
		arrayList.Add(((TextBox)txtMa_lo).Text.Trim());
		arrayList.Add(ChkQuaToiThieu.Checked);
		arrayList.Add(ChkQuaToiDa.Checked);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strSubTitle", GetFilterTitle());
		base.MyFomularFields.Add("KIEU_DU", rbCk.Checked);
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
			goto IL_0439;
		}
		if ((int)keycode != 116 || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false), (object)"", false) ? true : false))
		{
			base.CancelDrilldown = true;
			result = null;
		}
		else
		{
			ArrayList arrayList = new ArrayList();
			switch (base.MyReportInfo.ma_mau)
			{
			case "03":
				arrayList.Add(CompanyInformations.CompanyID);
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false)));
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_kho"]), isNum: false)));
				arrayList.Add(((TextBox)txtMa_vitri).Text.Trim());
				arrayList.Add(((TextBox)txtMa_tkvt).Text.Trim());
				arrayList.Add(((TextBox)txtNh_vt).Text.Trim());
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay.Value));
				arrayList.Add(((TextBox)txtMa_Nt).Text.Trim());
				arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboDVT).SelectedValue));
				arrayList.Add(((TextBox)txtMa_lo).Text.Trim());
				break;
			case "04":
				arrayList.Add(CompanyInformations.CompanyID);
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false)));
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_kho"]), isNum: false)));
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vitri"]), isNum: false)));
				arrayList.Add(((TextBox)txtMa_tkvt).Text.Trim());
				arrayList.Add(((TextBox)txtNh_vt).Text.Trim());
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay.Value));
				arrayList.Add(((TextBox)txtMa_Nt).Text.Trim());
				arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboDVT).SelectedValue));
				arrayList.Add(((TextBox)txtMa_lo).Text.Trim());
				break;
			case "05":
				arrayList.Add(CompanyInformations.CompanyID);
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false)));
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_kho"]), isNum: false)));
				arrayList.Add(((TextBox)txtMa_vitri).Text.Trim());
				arrayList.Add(((TextBox)txtMa_tkvt).Text.Trim());
				arrayList.Add(((TextBox)txtNh_vt).Text.Trim());
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay.Value));
				arrayList.Add(((TextBox)txtMa_Nt).Text.Trim());
				arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboDVT).SelectedValue));
				arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_lo"]), isNum: false)));
				break;
			}
			if (Information.IsDBNull((object)arrayList))
			{
				base.CancelDrilldown = true;
				result = null;
			}
			else
			{
				filterCondition4title = dataRowView["ma_vt"].ToString() + ": " + dataRowView["ten_vt"].ToString();
				result = arrayList;
			}
		}
		goto IL_0439;
		IL_0439:
		return result;
	}

	public string GetFilterTitle()
	{
		string text = string.Empty;
		if (Operators.CompareString(((TextBox)txtMa_kho).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_kho.Text + ":" + ((TextBox)txtMa_kho).Text + ";";
		}
		if (Operators.CompareString(((TextBox)txtMa_tkvt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_tkvt.Text + ":" + ((TextBox)txtMa_tkvt).Text + ";";
		}
		if (Operators.CompareString(((TextBox)txtMa_vitri).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_vitri.Text + ":" + ((TextBox)txtMa_vitri).Text + ";";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_vt.Text + ":" + ((TextBox)txtMa_vt).Text + ";";
		}
		if (Operators.CompareString(((TextBox)txtNh_vt).Text.Trim(), "", false) != 0)
		{
			text = text + lblNhom_vt.Text + ":" + ((TextBox)txtNh_vt).Text + ";";
		}
		return text;
	}

	private void rbDK_CheckedChanged(object sender, EventArgs e)
	{
		if (MyReportInfo != null)
		{
			txtTieu_De.Text = Conversions.ToString(Operators.AddObject((object)(base.MyReportInfo.title + " "), Interaction.IIf(rbDK.Checked, (object)((ButtonBase)rbDK).Text.ToUpper(), (object)((ButtonBase)rbCk).Text.ToUpper())));
		}
	}

	private void cboMau_bc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboMau_bc.DataSource != null)
		{
			txtTieu_De.Text = Conversions.ToString(Operators.AddObject((object)(base.MyReportInfo.title + " "), Interaction.IIf(rbDK.Checked, (object)((ButtonBase)rbDK).Text.ToUpper(), (object)((ButtonBase)rbCk).Text.ToUpper())));
		}
	}
}
