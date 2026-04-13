using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using AsiaErp.Framework;
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmINRptCTVT02 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("txtMa_nhvt")]
	private AsTextBox _txtMa_nhvt;

	[AccessedThroughProperty("lblTen_nhvt")]
	private Label _lblTen_nhvt;

	[AccessedThroughProperty("lblNhom_vt")]
	private Label _lblNhom_vt;

	[AccessedThroughProperty("txtMa_tkvt")]
	private AsTextBox _txtMa_tkvt;

	[AccessedThroughProperty("lblTen_tkvt")]
	private Label _lblTen_tkvt;

	[AccessedThroughProperty("lblMa_tkvt")]
	private Label _lblMa_tkvt;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("txtMa_vitri")]
	private AsTextBox _txtMa_vitri;

	[AccessedThroughProperty("lblMa_vitri")]
	private Label _lblMa_vitri;

	[AccessedThroughProperty("lblDVT")]
	private Label _lblDVT;

	[AccessedThroughProperty("cboDVT")]
	private ComboBox _cboDVT;

	[AccessedThroughProperty("lblPsdc")]
	private Label _lblPsdc;

	[AccessedThroughProperty("chkPS_dc")]
	private AsCheckBox _chkPS_dc;

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

	private DataTable dt;

	private string StrDVT;

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
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_vt_AfterCodeValidating;
			if (_txtMa_vt != null)
			{
				_txtMa_vt.AfterCodeValidating -= obj;
			}
			_txtMa_vt = value;
			if (_txtMa_vt != null)
			{
				_txtMa_vt.AfterCodeValidating += obj;
			}
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

	internal virtual Label lblPsdc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPsdc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPsdc = value;
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

	public frmINRptCTVT02(string MenuID)
		: base(MenuID)
	{
		__ENCAddToList(this);
		StrDVT = "";
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
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_1425: Unknown result type (might be due to invalid IL or missing references)
		//IL_142f: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		lblMa_vt = new Label();
		lblTen_nhvt = new Label();
		txtMa_nhvt = new AsTextBox();
		lblNhom_vt = new Label();
		lblMa_tkvt = new Label();
		lblTen_tkvt = new Label();
		txtMa_tkvt = new AsTextBox();
		lblTen_kho = new Label();
		lblMa_kho = new Label();
		txtMa_kho = new AsTextBox();
		txtMa_vitri = new AsTextBox();
		lblTen_vitri = new Label();
		lblMa_vitri = new Label();
		lblDVT = new Label();
		cboDVT = new ComboBox();
		lblPsdc = new Label();
		chkPS_dc = new AsCheckBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)AsTabControl).Cursor = Cursors.Default;
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(742, 398);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)chkPS_dc);
		((Control)tabFilter).Controls.Add((Control)(object)lblDVT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)cboDVT);
		((Control)tabFilter).Controls.Add((Control)(object)lblPsdc);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_tkvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tkvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_tkvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhvt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblNhom_vt);
		TabPage obj = tabFilter;
		size = new Size(734, 369);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNhom_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_tkvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tkvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_tkvt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPsdc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboDVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)chkPS_dc, 0);
		((Control)lbl2).TabIndex = 17;
		Button obj2 = cmdExcel;
		Point location = new Point(651, 80);
		((Control)obj2).Location = location;
		((Control)cmdExcel).TabIndex = 15;
		((Control)txtNgay2).TabIndex = 2;
		Button obj3 = cmdCancel;
		location = new Point(570, 63);
		((Control)obj3).Location = location;
		((Control)cmdCancel).TabIndex = 14;
		((Control)cmdModifyReport).TabIndex = 16;
		((Control)txtNgay1).TabIndex = 1;
		((Control)cboKyBc).TabIndex = 0;
		((Control)lblKyBc).TabIndex = 31;
		ComboBox obj4 = cboMau_bc;
		location = new Point(110, 24);
		((Control)obj4).Location = location;
		((Control)cboMau_bc).TabIndex = 12;
		((Control)lblMau_bc).TabIndex = 33;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 263);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 10;
		Label obj5 = lblMauBC;
		location = new Point(155, 262);
		((Control)obj5).Location = location;
		((Control)lblMauBC).TabIndex = 34;
		RadioButton obj6 = optVND;
		location = new Point(242, 261);
		((Control)obj6).Location = location;
		((Control)optVND).TabIndex = 35;
		optVND.TabStop = false;
		RadioButton obj7 = optNt;
		location = new Point(296, 262);
		((Control)obj7).Location = location;
		((Control)optNt).TabIndex = 36;
		Label obj8 = lblMa_nt;
		location = new Point(24, 265);
		((Control)obj8).Location = location;
		((Control)lblMa_nt).TabIndex = 23;
		Button obj9 = cmdOk;
		location = new Point(27, 317);
		((Control)obj9).Location = location;
		((Control)cmdOk).TabIndex = 11;
		((Control)lblTieu_de).TabIndex = 32;
		((Control)txtTieu_De).TabIndex = 13;
		crvReportViewer.ActiveViewIndex = -1;
		((UserControl)crvReportViewer).BorderStyle = (BorderStyle)1;
		crvReportViewer.DisplayGroupTree = false;
		((Control)crvReportViewer).Dock = (DockStyle)5;
		CrystalReportViewer obj10 = crvReportViewer;
		location = new Point(0, 0);
		((Control)obj10).Location = location;
		((Control)crvReportViewer).Name = "crvReportViewer";
		crvReportViewer.SelectionFormula = "";
		crvReportViewer.ShowRefreshButton = false;
		CrystalReportViewer obj11 = crvReportViewer;
		size = new Size(782, 459);
		((Control)obj11).Size = size;
		((Control)crvReportViewer).TabIndex = 0;
		crvReportViewer.ViewTimeSelectionFormula = "";
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = true;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_vt;
		location = new Point(110, 131);
		((Control)asTextBox2).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox3 = txtMa_vt;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_vt).TabIndex = 4;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		txtMa_vt.ValidReturnFieldList = "DVT,TEN_VT";
		Label obj12 = lblTen_vt;
		location = new Point(206, 135);
		((Control)obj12).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj13 = lblTen_vt;
		size = new Size(439, 13);
		((Control)obj13).Size = size;
		((Control)lblTen_vt).TabIndex = 18;
		lblMa_vt.AutoSize = true;
		Label obj14 = lblMa_vt;
		location = new Point(24, 135);
		((Control)obj14).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj15 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj15).Size = size;
		((Control)lblMa_vt).TabIndex = 30;
		lblMa_vt.Text = "Mã vật tư";
		Label obj16 = lblTen_nhvt;
		location = new Point(206, 161);
		((Control)obj16).Location = location;
		((Control)lblTen_nhvt).Name = "lblTen_nhvt";
		Label obj17 = lblTen_nhvt;
		size = new Size(439, 13);
		((Control)obj17).Size = size;
		((Control)lblTen_nhvt).TabIndex = 19;
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = true;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_nhvt;
		location = new Point(110, 157);
		((Control)asTextBox4).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_nhvt;
		AsTextBox asTextBox5 = txtMa_nhvt;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_nhvt).TabIndex = 5;
		((Control)txtMa_nhvt).Tag = "MA_NHVT";
		txtMa_nhvt.UseAutoCompleteSource = true;
		lblNhom_vt.AutoSize = true;
		Label obj18 = lblNhom_vt;
		location = new Point(24, 161);
		((Control)obj18).Location = location;
		((Control)lblNhom_vt).Name = "lblNhom_vt";
		Label obj19 = lblNhom_vt;
		size = new Size(65, 13);
		((Control)obj19).Size = size;
		((Control)lblNhom_vt).TabIndex = 29;
		lblNhom_vt.Text = "Nhóm vật tư";
		lblMa_tkvt.AutoSize = true;
		Label obj20 = lblMa_tkvt;
		location = new Point(24, 187);
		((Control)obj20).Location = location;
		((Control)lblMa_tkvt).Name = "lblMa_tkvt";
		Label obj21 = lblMa_tkvt;
		size = new Size(53, 13);
		((Control)obj21).Size = size;
		((Control)lblMa_tkvt).TabIndex = 28;
		lblMa_tkvt.Text = "Mã TKVT";
		Label obj22 = lblTen_tkvt;
		location = new Point(206, 187);
		((Control)obj22).Location = location;
		((Control)lblTen_tkvt).Name = "lblTen_tkvt";
		Label obj23 = lblTen_tkvt;
		size = new Size(439, 13);
		((Control)obj23).Size = size;
		((Control)lblTen_tkvt).TabIndex = 20;
		txtMa_tkvt.AutoLookup = true;
		txtMa_tkvt.AutoValid = true;
		((TextBoxBase)txtMa_tkvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_tkvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_tkvt;
		location = new Point(110, 183);
		((Control)asTextBox6).Location = location;
		txtMa_tkvt.LookupCodeName = "TK";
		((Control)txtMa_tkvt).Name = "txtMa_tkvt";
		txtMa_tkvt.NameControl = lblTen_tkvt;
		AsTextBox asTextBox7 = txtMa_tkvt;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_tkvt).TabIndex = 6;
		((Control)txtMa_tkvt).Tag = "TK";
		txtMa_tkvt.UseAutoCompleteSource = true;
		Label obj24 = lblTen_kho;
		location = new Point(206, 109);
		((Control)obj24).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj25 = lblTen_kho;
		size = new Size(439, 13);
		((Control)obj25).Size = size;
		((Control)lblTen_kho).TabIndex = 21;
		lblMa_kho.AutoSize = true;
		Label obj26 = lblMa_kho;
		location = new Point(24, 109);
		((Control)obj26).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj27 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj27).Size = size;
		((Control)lblMa_kho).TabIndex = 27;
		lblMa_kho.Text = "Mã kho";
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = true;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_kho;
		location = new Point(110, 105);
		((Control)asTextBox8).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox9 = txtMa_kho;
		size = new Size(90, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_kho).TabIndex = 3;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		txtMa_vitri.AutoLookup = true;
		txtMa_vitri.AutoValid = true;
		((TextBoxBase)txtMa_vitri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vitri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vitri).Enabled = false;
		AsTextBox asTextBox10 = txtMa_vitri;
		location = new Point(233, 335);
		((Control)asTextBox10).Location = location;
		txtMa_vitri.LookupCodeName = "MA_VITRI";
		((Control)txtMa_vitri).Name = "txtMa_vitri";
		txtMa_vitri.NameControl = lblTen_vitri;
		AsTextBox asTextBox11 = txtMa_vitri;
		size = new Size(90, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_vitri).TabIndex = 7;
		((Control)txtMa_vitri).Tag = "MA_VITRI";
		txtMa_vitri.UseAutoCompleteSource = true;
		((Control)txtMa_vitri).Visible = false;
		((Control)lblTen_vitri).Enabled = false;
		Label obj28 = lblTen_vitri;
		location = new Point(329, 339);
		((Control)obj28).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj29 = lblTen_vitri;
		size = new Size(324, 13);
		((Control)obj29).Size = size;
		((Control)lblTen_vitri).TabIndex = 22;
		((Control)lblTen_vitri).Visible = false;
		lblMa_vitri.AutoSize = true;
		((Control)lblMa_vitri).Enabled = false;
		Label obj30 = lblMa_vitri;
		location = new Point(147, 339);
		((Control)obj30).Location = location;
		((Control)lblMa_vitri).Name = "lblMa_vitri";
		Label obj31 = lblMa_vitri;
		size = new Size(46, 13);
		((Control)obj31).Size = size;
		((Control)lblMa_vitri).TabIndex = 26;
		lblMa_vitri.Text = "Mã vị trí";
		((Control)lblMa_vitri).Visible = false;
		lblDVT.AutoSize = true;
		Label obj32 = lblDVT;
		location = new Point(24, 213);
		((Control)obj32).Location = location;
		((Control)lblDVT).Name = "lblDVT";
		Label obj33 = lblDVT;
		size = new Size(60, 13);
		((Control)obj33).Size = size;
		((Control)lblDVT).TabIndex = 25;
		lblDVT.Text = "Đơn vị tính";
		cboDVT.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboDVT).FormattingEnabled = true;
		cboDVT.Items.AddRange(new object[3] { "Đơn vị  kho", "Đơn vị  mua", "Đơn vị  bán" });
		ComboBox obj34 = cboDVT;
		location = new Point(110, 209);
		((Control)obj34).Location = location;
		((Control)cboDVT).Name = "cboDVT";
		ComboBox obj35 = cboDVT;
		size = new Size(90, 21);
		((Control)obj35).Size = size;
		((Control)cboDVT).TabIndex = 8;
		lblPsdc.AutoSize = true;
		Label obj36 = lblPsdc;
		location = new Point(24, 240);
		((Control)obj36).Location = location;
		((Control)lblPsdc).Name = "lblPsdc";
		Label obj37 = lblPsdc;
		size = new Size(62, 13);
		((Control)obj37).Size = size;
		((Control)lblPsdc).TabIndex = 24;
		lblPsdc.Text = "Tính PSDC";
		((ButtonBase)chkPS_dc).AutoSize = true;
		chkPS_dc.Checked = true;
		((CheckBox)chkPS_dc).CheckState = (CheckState)1;
		AsCheckBox asCheckBox = chkPS_dc;
		location = new Point(110, 236);
		((Control)asCheckBox).Location = location;
		((Control)chkPS_dc).Name = "chkPS_dc";
		AsCheckBox asCheckBox2 = chkPS_dc;
		size = new Size(170, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkPS_dc).TabIndex = 9;
		((ButtonBase)chkPS_dc).Text = "Tính các PS điều chuyển kho";
		((ButtonBase)chkPS_dc).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(742, 420);
		((Form)this).ClientSize = size;
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmINRptCTVT02";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		base.InitOtherComponents();
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = new ArrayList();
		ComboBox val = cboDVT;
		DictionaryEntry dictionaryEntry = new DictionaryEntry("0", RuntimeHelpers.GetObjectValue(val.Items[0]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("1", RuntimeHelpers.GetObjectValue(val.Items[1]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("2", RuntimeHelpers.GetObjectValue(val.Items[2]));
		arrayList.Add(dictionaryEntry);
		val.DataSource = arrayList;
		((ListControl)val).DisplayMember = "value";
		((ListControl)val).ValueMember = "key";
		val.SelectedIndex = 0;
		val = null;
		((DataGridView)dgvBC).CellContentClick += new DataGridViewCellEventHandler(dgvBC_CellContentClick);
	}

	protected override bool ValidData()
	{
		return (base.ValidData() && ChkEmtyTextBox((TextBox)(object)txtMa_kho)) ? true : false;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_vt).Text.Trim());
		arrayList.Add(((TextBox)txtMa_tkvt).Text.Trim());
		arrayList.Add(((TextBox)txtMa_nhvt).Text.Trim());
		arrayList.Add(((TextBox)txtMa_kho).Text.Trim());
		arrayList.Add(((TextBox)txtMa_vitri).Text.Trim());
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboDVT).SelectedValue));
		if (Conversions.ToBoolean(chkPS_dc.Checked))
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
		arrayList.Add(cboMau_bc.Text.Trim());
		arrayList.Add(((TextBox)txtMa_Nt).Text.Trim());
		set_MyDGVSource(isSet2Print: false, base.MyController.GetData(arrayList.ToArray()));
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
		arrayList.Add(dataRowView["ma_vt"].ToString());
		arrayList.Add(((TextBox)txtMa_kho).Text);
		arrayList.Add(((TextBox)txtMa_vitri).Text);
		arrayList.Add("");
		arrayList.Add("");
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add("%");
		if (Conversions.ToBoolean(chkPS_dc.Checked))
		{
			arrayList.Add("1");
		}
		else
		{
			arrayList.Add("0");
		}
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

	protected DataTable LoadDataToCrys()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(xmlData());
		arrayList.Add(((TextBox)txtMa_vt).Text.Trim());
		arrayList.Add(((TextBox)txtMa_kho).Text.Trim());
		arrayList.Add(((TextBox)txtMa_vitri).Text.Trim());
		arrayList.Add(cboMau_bc.Text.Trim());
		arrayList.Add(((TextBox)txtMa_Nt).Text.Trim());
		return Commons.GetDataTable("asINRptCTVT02_crys", arrayList.ToArray());
	}

	private string xmlData()
	{
		if (get_MyDGVSource(isSet2Print: true) == null)
		{
			return "";
		}
		DataSet dataSet = new DataSet();
		DataTable dataTable = new DataTable();
		DataColumn column = new DataColumn("Ma_vt", Type.GetType("System.String"));
		dataTable.Columns.Add(column);
		DataRow[] array = get_MyDGVSource(isSet2Print: true).Select("tag=1");
		foreach (DataRow dataRow in array)
		{
			if (Operators.ConditionalCompareObjectNotEqual(dataRow["bold"], (object)"1", false))
			{
				DataRow dataRow2 = dataTable.NewRow();
				dataRow2["Ma_vt"] = RuntimeHelpers.GetObjectValue(dataRow["Ma_vt"]);
				dataTable.Rows.Add(dataRow2);
			}
		}
		dataSet.Tables.Add(dataTable);
		XmlDataDocument xmlDataDocument = new XmlDataDocument(dataSet);
		return ((XmlDocument)xmlDataDocument).InnerXml;
	}

	private string GetFilterTitle()
	{
		string text = string.Empty;
		if (Operators.CompareString(((TextBox)txtMa_kho).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_kho.Text + ": [" + ((TextBox)txtMa_kho).Text + " - " + lblTen_kho.Text + "]";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text.Trim(), "", false) != 0)
		{
			text = text + ", " + lblMa_vt.Text + ": [" + ((TextBox)txtMa_vt).Text + " - " + lblTen_vt.Text + " - " + StrDVT + "]";
		}
		if (Operators.CompareString(((TextBox)txtMa_nhvt).Text.Trim(), "", false) != 0)
		{
			text = text + ", " + lblNhom_vt.Text + ": [" + ((TextBox)txtMa_nhvt).Text + " - " + lblTen_nhvt.Text + "]";
		}
		if (Operators.CompareString(((TextBox)txtMa_tkvt).Text.Trim(), "", false) != 0)
		{
			text = text + ", " + lblMa_tkvt.Text + ": [" + ((TextBox)txtMa_tkvt).Text + " - " + lblTen_tkvt.Text + "]";
		}
		if (Operators.CompareString(((TextBox)txtMa_vitri).Text.Trim(), "", false) != 0)
		{
			text = text + ", " + lblMa_vitri.Text + ": [" + ((TextBox)txtMa_vitri).Text + " - " + lblTen_vitri.Text + "]";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text.Trim(), "", false) != 0)
		{
			text = text + ", " + lblMa_nt.Text + ": [" + ((TextBox)txtMa_Nt).Text + "]";
		}
		return text;
	}

	protected override void ViewCrystalBySource()
	{
		if (get_MyDGVSource(isSet2Print: true) != null)
		{
			if (get_MyDGVSource(isSet2Print: true).Select("tag = 1").Length != 0)
			{
				base.MyCrystalSource = LoadDataToCrys();
			}
			else
			{
				MyCrystalSource = null;
			}
			base.ViewCrystalBySource();
		}
	}

	private void txtMa_vt_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (((TextBox)txtMa_vt).Text.Length > 0)
		{
			StrDVT = Conversions.ToString(e.ValidatedRow["DVT"]);
		}
	}

	private void dgvBC_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (((DataGridView)dgvBC).CurrentCell.ColumnIndex != ((DataGridViewBand)((DataGridView)dgvBC).Columns["TAG"]).Index)
		{
			return;
		}
		string text = "";
		string text2 = "";
		bool flag = false;
		get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["TAG"] = Operators.NotObject(get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["TAG"]);
		text = Conversions.ToString(get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["ma_nhvt"]);
		text2 = Conversions.ToString(get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["bold"]);
		flag = Conversions.ToBoolean(get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["TAG"]);
		if (Operators.CompareString(text2, "1", false) == 0)
		{
			DataRow[] array = get_MyDGVSource(isSet2Print: true).Select("ma_nhvt='" + text + "' and bold=''");
			foreach (DataRow dataRow in array)
			{
				dataRow["TAG"] = flag;
			}
			CheckForChild(text, flag);
		}
		if (!((Operators.CompareString(text, "", false) == 0) & (Operators.CompareString(text2, "1", false) == 0)))
		{
			return;
		}
		foreach (DataRow row in get_MyDGVSource(isSet2Print: true).Rows)
		{
			row["TAG"] = flag;
		}
	}

	private void CheckForChild(string ma_nhomcon, bool bl)
	{
		DataRow[] array = get_MyDGVSource(isSet2Print: true).Select("nhom_me ='" + ma_nhomcon + "'");
		string text = "";
		List<string> list = new List<string>();
		DataRow[] array2 = array;
		foreach (DataRow dataRow in array2)
		{
			if (Operators.ConditionalCompareObjectNotEqual(dataRow["ma_nhvt"], (object)text, false))
			{
				list.Add(Conversions.ToString(dataRow["ma_nhvt"]));
				text = Conversions.ToString(dataRow["ma_nhvt"]);
			}
		}
		DataRow[] array3 = get_MyDGVSource(isSet2Print: true).Select("nhom_me ='" + ma_nhomcon + "'");
		foreach (DataRow dataRow2 in array3)
		{
			dataRow2["TAG"] = bl;
		}
		foreach (string item in list)
		{
			if ((get_MyDGVSource(isSet2Print: true).Select("nhom_me ='" + item + "'").Count() > 0) & (Operators.CompareString(item, "", false) != 0))
			{
				CheckForChild(item, bl);
			}
		}
	}
}
