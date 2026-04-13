using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmINRptCTVT01 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("txtMa_vitri")]
	private AsTextBox _txtMa_vitri;

	[AccessedThroughProperty("lblTen_vitri")]
	private Label _lblTen_vitri;

	[AccessedThroughProperty("lblMa_vitri")]
	private Label _lblMa_vitri;

	[AccessedThroughProperty("lblDVT")]
	private Label _lblDVT;

	[AccessedThroughProperty("cboDVT")]
	private ComboBox _cboDVT;

	[AccessedThroughProperty("txtTK_VT")]
	private AsTextBox _txtTK_VT;

	[AccessedThroughProperty("lblTK_VT")]
	private Label _lblTK_VT;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

	private string StrVatTu;

	private string StrDVT;

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

	internal virtual AsTextBox txtTK_VT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_VT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_VT = value;
		}
	}

	internal virtual Label lblTK_VT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_VT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_VT = value;
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

	public frmINRptCTVT01(string MenuID)
		: base(MenuID)
	{
		__ENCAddToList(this);
		StrVatTu = "";
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_1122: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		lblMa_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		lblTen_kho = new Label();
		lblMa_kho = new Label();
		txtMa_kho = new AsTextBox();
		txtMa_vitri = new AsTextBox();
		lblTen_vitri = new Label();
		lblMa_vitri = new Label();
		lblDVT = new Label();
		cboDVT = new ComboBox();
		txtTK_VT = new AsTextBox();
		lblTK_VT = new Label();
		Label2 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(667, 343);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)txtTK_VT);
		((Control)tabFilter).Controls.Add((Control)(object)Label2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTK_VT);
		((Control)tabFilter).Controls.Add((Control)(object)lblDVT);
		((Control)tabFilter).Controls.Add((Control)(object)cboDVT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vitri);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		TabPage obj = tabFilter;
		size = new Size(659, 314);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vitri, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboDVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDVT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK_VT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK_VT, 0);
		Label obj2 = lbl2;
		Point location = new Point(330, 83);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 13;
		Button obj3 = cmdExcel;
		location = new Point(544, 143);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 11;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(349, 79);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(463, 143);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 10;
		((Control)cmdModifyReport).TabIndex = 11;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(259, 79);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj5 = cboKyBc;
		location = new Point(163, 79);
		((Control)obj5).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj6 = lblKyBc;
		location = new Point(28, 82);
		((Control)obj6).Location = location;
		((Control)lblKyBc).TabIndex = 24;
		ComboBox obj7 = cboMau_bc;
		location = new Point(163, 25);
		((Control)obj7).Location = location;
		((Control)cboMau_bc).TabIndex = 10;
		Label obj8 = lblMau_bc;
		location = new Point(28, 28);
		((Control)obj8).Location = location;
		((Control)lblMau_bc).TabIndex = 26;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(197, 253);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 7;
		Label obj9 = lblMauBC;
		location = new Point(242, 252);
		((Control)obj9).Location = location;
		((Control)lblMauBC).TabIndex = 8;
		RadioButton obj10 = optVND;
		location = new Point(329, 251);
		((Control)obj10).Location = location;
		((Control)optVND).TabIndex = 9;
		optVND.TabStop = false;
		RadioButton obj11 = optNt;
		location = new Point(392, 252);
		((Control)obj11).Location = location;
		((Control)optNt).TabIndex = 10;
		Label obj12 = lblMa_nt;
		location = new Point(115, 255);
		((Control)obj12).Location = location;
		((Control)lblMa_nt).TabIndex = 9;
		Button obj13 = cmdOk;
		location = new Point(27, 253);
		((Control)obj13).Location = location;
		((Control)cmdOk).TabIndex = 8;
		Label obj14 = lblTieu_de;
		location = new Point(28, 56);
		((Control)obj14).Location = location;
		((Control)lblTieu_de).TabIndex = 25;
		TextBox obj15 = txtTieu_De;
		location = new Point(163, 53);
		((Control)obj15).Location = location;
		((Control)txtTieu_De).TabIndex = 12;
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
		lblMa_vt.AutoSize = true;
		Label obj18 = lblMa_vt;
		location = new Point(28, 135);
		((Control)obj18).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj19 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_vt).TabIndex = 23;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = true;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_vt;
		location = new Point(163, 132);
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
		txtMa_vt.ValidReturnFieldList = "TEN_VT=[TEN_VT],DVT=[DVT]";
		Label obj20 = lblTen_vt;
		location = new Point(259, 136);
		((Control)obj20).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj21 = lblTen_vt;
		size = new Size(360, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_vt).TabIndex = 14;
		Label obj22 = lblTen_kho;
		location = new Point(259, 110);
		((Control)obj22).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj23 = lblTen_kho;
		size = new Size(360, 13);
		((Control)obj23).Size = size;
		((Control)lblTen_kho).TabIndex = 15;
		lblMa_kho.AutoSize = true;
		Label obj24 = lblMa_kho;
		location = new Point(28, 109);
		((Control)obj24).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj25 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj25).Size = size;
		((Control)lblMa_kho).TabIndex = 22;
		lblMa_kho.Text = "Mã kho";
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = true;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_kho;
		location = new Point(163, 106);
		((Control)asTextBox4).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox5 = txtMa_kho;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_kho).TabIndex = 3;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		txtMa_vitri.AutoLookup = true;
		txtMa_vitri.AutoValid = false;
		((TextBoxBase)txtMa_vitri).BackColor = SystemColors.Info;
		((TextBox)txtMa_vitri).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vitri).Enabled = false;
		AsTextBox asTextBox6 = txtMa_vitri;
		location = new Point(423, 226);
		((Control)asTextBox6).Location = location;
		txtMa_vitri.LookupCodeName = "MA_VITRI";
		((Control)txtMa_vitri).Name = "txtMa_vitri";
		txtMa_vitri.NameControl = lblTen_vitri;
		AsTextBox asTextBox7 = txtMa_vitri;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_vitri).TabIndex = 5;
		((Control)txtMa_vitri).Tag = "MA_VITRI";
		txtMa_vitri.UseAutoCompleteSource = true;
		((Control)txtMa_vitri).Visible = false;
		((Control)lblTen_vitri).Enabled = false;
		Label obj26 = lblTen_vitri;
		location = new Point(519, 230);
		((Control)obj26).Location = location;
		((Control)lblTen_vitri).Name = "lblTen_vitri";
		Label obj27 = lblTen_vitri;
		size = new Size(324, 13);
		((Control)obj27).Size = size;
		((Control)lblTen_vitri).TabIndex = 16;
		((Control)lblTen_vitri).Visible = false;
		lblMa_vitri.AutoSize = true;
		((Control)lblMa_vitri).Enabled = false;
		Label obj28 = lblMa_vitri;
		location = new Point(288, 229);
		((Control)obj28).Location = location;
		((Control)lblMa_vitri).Name = "lblMa_vitri";
		Label obj29 = lblMa_vitri;
		size = new Size(46, 13);
		((Control)obj29).Size = size;
		((Control)lblMa_vitri).TabIndex = 21;
		lblMa_vitri.Text = "Mã vị trí";
		((Control)lblMa_vitri).Visible = false;
		lblDVT.AutoSize = true;
		Label obj30 = lblDVT;
		location = new Point(28, 186);
		((Control)obj30).Location = location;
		((Control)lblDVT).Name = "lblDVT";
		Label obj31 = lblDVT;
		size = new Size(60, 13);
		((Control)obj31).Size = size;
		((Control)lblDVT).TabIndex = 28;
		lblDVT.Text = "Đơn vị tính";
		cboDVT.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboDVT).FormattingEnabled = true;
		cboDVT.Items.AddRange(new object[3] { "Đơn vị  kho", "Đơn vị  mua", "Đơn vị  bán" });
		ComboBox obj32 = cboDVT;
		location = new Point(163, 184);
		((Control)obj32).Location = location;
		((Control)cboDVT).Name = "cboDVT";
		ComboBox obj33 = cboDVT;
		size = new Size(90, 21);
		((Control)obj33).Size = size;
		((Control)cboDVT).TabIndex = 7;
		txtTK_VT.AutoLookup = true;
		txtTK_VT.AutoValid = false;
		((TextBoxBase)txtTK_VT).BackColor = SystemColors.Info;
		((TextBox)txtTK_VT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtTK_VT;
		location = new Point(163, 158);
		((Control)asTextBox8).Location = location;
		txtTK_VT.LookupCodeName = "TK";
		((Control)txtTK_VT).Name = "txtTK_VT";
		txtTK_VT.NameControl = lblTK_VT;
		AsTextBox asTextBox9 = txtTK_VT;
		size = new Size(90, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtTK_VT).TabIndex = 6;
		((Control)txtTK_VT).Tag = "TK_VT";
		txtTK_VT.UseAutoCompleteSource = true;
		Label obj34 = lblTK_VT;
		location = new Point(259, 162);
		((Control)obj34).Location = location;
		((Control)lblTK_VT).Name = "lblTK_VT";
		Label obj35 = lblTK_VT;
		size = new Size(360, 13);
		((Control)obj35).Size = size;
		((Control)lblTK_VT).TabIndex = 30;
		Label2.AutoSize = true;
		Label label = Label2;
		location = new Point(28, 161);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(38, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 31;
		Label2.Text = "TK VT";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(667, 365);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmINRptCTVT01";
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
	}

	protected override bool ValidData()
	{
		if (Operators.CompareString(((TextBox)txtMa_vt).Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtMa_vt, Helper.GetMessContent(50002));
			return false;
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtMa_kho, Helper.GetMessContent(50002));
			return false;
		}
		return base.ValidData();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_vt).Text.Trim());
		arrayList.Add(((TextBox)txtMa_kho).Text.Trim());
		arrayList.Add(((TextBox)txtMa_vitri).Text.Trim());
		arrayList.Add(MyReportInfo.ma_mau);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboDVT).SelectedValue));
		arrayList.Add(((TextBox)txtTK_VT).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		base.MyFomularFields.Add("StrVatTu", ((TextBox)txtMa_vt).Text + " - " + lblTen_vt.Text + " - " + StrDVT);
		base.MyFomularFields.Add("StrKho", ((TextBox)txtMa_kho).Text + " - " + lblTen_kho.Text);
		base.MyFomularFields.Add("DVT", StrDVT);
		return true;
	}

	public string GetFilterTitle()
	{
		string text = string.Empty;
		if (Operators.CompareString(((TextBox)txtMa_vt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_vt.Text + ":" + ((TextBox)txtMa_vt).Text + ";";
		}
		if (Operators.CompareString(((TextBox)txtMa_kho).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_kho.Text + ":" + ((TextBox)txtMa_kho).Text + ";";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nt.Text + ":" + ((TextBox)txtMa_Nt).Text + ";";
		}
		if (Operators.CompareString(((TextBox)txtMa_vitri).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_vitri.Text + ":" + ((TextBox)txtMa_vitri).Text + ";";
		}
		return text;
	}

	private void txtMa_vt_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		try
		{
			if (((TextBox)txtMa_vt).Text.Trim().Length > 0)
			{
				StrVatTu = Conversions.ToString(e.ValidatedRow["Ten_VT", DataRowVersion.Current]);
				StrDVT = Conversions.ToString(e.ValidatedRow["DVT", DataRowVersion.Current]);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}
}
