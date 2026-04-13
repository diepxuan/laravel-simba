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
public class frmARRptBCCN03 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

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

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("txtMa_Tk")]
	private AsTextBox _txtMa_Tk;

	[AccessedThroughProperty("lblMa_tk")]
	private Label _lblMa_tk;

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

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

	internal virtual Label lblTen_Tk
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

	internal virtual AsTextBox txtMa_Tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Tk = value;
		}
	}

	internal virtual Label lblMa_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_tk = value;
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

	public frmARRptBCCN03(string MenuId)
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
		//IL_120c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1216: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		lblMa_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblTen_Kh = new Label();
		lblTen_plkh1 = new Label();
		txtMa_plkh1 = new AsTextBox();
		lblPLKh1 = new Label();
		lblTen_plkh2 = new Label();
		txtMa_plkh2 = new AsTextBox();
		lblPLKh2 = new Label();
		lblTen_plkh3 = new Label();
		txtMa_plkh3 = new AsTextBox();
		lblPLKh3 = new Label();
		lblTen_Tk = new Label();
		txtMa_Tk = new AsTextBox();
		lblMa_tk = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(564, 365);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLKh3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh3);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLKh2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh2);
		((Control)tabFilter).Controls.Add((Control)(object)lblPLKh1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_plkh1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Kh);
		TabPage obj = tabFilter;
		size = new Size(556, 336);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLKh1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLKh2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_plkh3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblPLKh3, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		Label obj2 = lbl2;
		Point location = new Point(277, 81);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 170);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(296, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 170);
		((Control)obj4).Location = location;
		((Control)cmdModifyReport).TabIndex = 17;
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
		((Control)cboMau_bc).TabIndex = 16;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 234);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 9;
		Label obj8 = lblMauBC;
		location = new Point(155, 233);
		((Control)obj8).Location = location;
		RadioButton obj9 = optVND;
		location = new Point(242, 232);
		((Control)obj9).Location = location;
		((Control)optVND).TabIndex = 10;
		RadioButton obj10 = optNt;
		location = new Point(296, 233);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 11;
		Label obj11 = lblMa_nt;
		location = new Point(24, 237);
		((Control)obj11).Location = location;
		Button obj12 = cmdOk;
		location = new Point(27, 281);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 12;
		Label obj13 = lblTieu_de;
		location = new Point(24, 55);
		((Control)obj13).Location = location;
		TextBox obj14 = txtTieu_De;
		location = new Point(110, 51);
		((Control)obj14).Location = location;
		((Control)txtTieu_De).TabIndex = 18;
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
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj17 = lblMa_Kh;
		location = new Point(24, 134);
		((Control)obj17).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj18 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj18).Size = size;
		((Control)lblMa_Kh).TabIndex = 1035;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
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
		((Control)txtMa_Kh).TabIndex = 4;
		txtMa_Kh.UseAutoCompleteSource = true;
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj19 = lblTen_Kh;
		location = new Point(206, 134);
		((Control)obj19).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj20 = lblTen_Kh;
		size = new Size(324, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_Kh).TabIndex = 1036;
		lblTen_plkh1.ImeMode = (ImeMode)0;
		Label obj21 = lblTen_plkh1;
		location = new Point(206, 160);
		((Control)obj21).Location = location;
		((Control)lblTen_plkh1).Name = "lblTen_plkh1";
		Label obj22 = lblTen_plkh1;
		size = new Size(324, 13);
		((Control)obj22).Size = size;
		((Control)lblTen_plkh1).TabIndex = 1092;
		txtMa_plkh1.AutoLookup = true;
		txtMa_plkh1.AutoValid = false;
		((TextBoxBase)txtMa_plkh1).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_plkh1;
		location = new Point(110, 156);
		((Control)asTextBox4).Location = location;
		txtMa_plkh1.LookupCodeName = "MA_PLKH";
		txtMa_plkh1.LookupWhereCondition = "loai='1'";
		((TextBoxBase)txtMa_plkh1).MaxLength = 8;
		((Control)txtMa_plkh1).Name = "txtMa_plkh1";
		txtMa_plkh1.NameControl = lblTen_plkh1;
		AsTextBox asTextBox5 = txtMa_plkh1;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_plkh1).TabIndex = 6;
		((Control)txtMa_plkh1).Tag = "MA_PLKH1";
		txtMa_plkh1.UseAutoCompleteSource = true;
		lblPLKh1.AutoSize = true;
		lblPLKh1.ImeMode = (ImeMode)0;
		Label obj23 = lblPLKh1;
		location = new Point(24, 160);
		((Control)obj23).Location = location;
		((Control)lblPLKh1).Name = "lblPLKh1";
		Label obj24 = lblPLKh1;
		size = new Size(61, 13);
		((Control)obj24).Size = size;
		((Control)lblPLKh1).TabIndex = 1091;
		lblPLKh1.Text = "P.Loại KH1";
		lblTen_plkh2.ImeMode = (ImeMode)0;
		Label obj25 = lblTen_plkh2;
		location = new Point(206, 186);
		((Control)obj25).Location = location;
		((Control)lblTen_plkh2).Name = "lblTen_plkh2";
		Label obj26 = lblTen_plkh2;
		size = new Size(324, 13);
		((Control)obj26).Size = size;
		((Control)lblTen_plkh2).TabIndex = 1094;
		txtMa_plkh2.AutoLookup = true;
		txtMa_plkh2.AutoValid = false;
		((TextBoxBase)txtMa_plkh2).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_plkh2;
		location = new Point(110, 182);
		((Control)asTextBox6).Location = location;
		txtMa_plkh2.LookupCodeName = "MA_PLKH";
		txtMa_plkh2.LookupWhereCondition = "loai='2'";
		((TextBoxBase)txtMa_plkh2).MaxLength = 8;
		((Control)txtMa_plkh2).Name = "txtMa_plkh2";
		txtMa_plkh2.NameControl = lblTen_plkh2;
		AsTextBox asTextBox7 = txtMa_plkh2;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_plkh2).TabIndex = 7;
		((Control)txtMa_plkh2).Tag = "MA_PLKH2";
		txtMa_plkh2.UseAutoCompleteSource = true;
		lblPLKh2.AutoSize = true;
		lblPLKh2.ImeMode = (ImeMode)0;
		Label obj27 = lblPLKh2;
		location = new Point(24, 186);
		((Control)obj27).Location = location;
		((Control)lblPLKh2).Name = "lblPLKh2";
		Label obj28 = lblPLKh2;
		size = new Size(61, 13);
		((Control)obj28).Size = size;
		((Control)lblPLKh2).TabIndex = 1093;
		lblPLKh2.Text = "P.Loại KH2";
		lblTen_plkh3.ImeMode = (ImeMode)0;
		Label obj29 = lblTen_plkh3;
		location = new Point(206, 212);
		((Control)obj29).Location = location;
		((Control)lblTen_plkh3).Name = "lblTen_plkh3";
		Label obj30 = lblTen_plkh3;
		size = new Size(324, 13);
		((Control)obj30).Size = size;
		((Control)lblTen_plkh3).TabIndex = 1096;
		txtMa_plkh3.AutoLookup = true;
		txtMa_plkh3.AutoValid = false;
		((TextBoxBase)txtMa_plkh3).BackColor = SystemColors.Info;
		((TextBox)txtMa_plkh3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_plkh3;
		location = new Point(110, 208);
		((Control)asTextBox8).Location = location;
		txtMa_plkh3.LookupCodeName = "MA_PLKH";
		txtMa_plkh3.LookupWhereCondition = "loai='3'";
		((TextBoxBase)txtMa_plkh3).MaxLength = 8;
		((Control)txtMa_plkh3).Name = "txtMa_plkh3";
		txtMa_plkh3.NameControl = lblTen_plkh3;
		AsTextBox asTextBox9 = txtMa_plkh3;
		size = new Size(90, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_plkh3).TabIndex = 8;
		((Control)txtMa_plkh3).Tag = "MA_PLKH3";
		txtMa_plkh3.UseAutoCompleteSource = true;
		lblPLKh3.AutoSize = true;
		lblPLKh3.ImeMode = (ImeMode)0;
		Label obj31 = lblPLKh3;
		location = new Point(24, 212);
		((Control)obj31).Location = location;
		((Control)lblPLKh3).Name = "lblPLKh3";
		Label obj32 = lblPLKh3;
		size = new Size(61, 13);
		((Control)obj32).Size = size;
		((Control)lblPLKh3).TabIndex = 1095;
		lblPLKh3.Text = "P.Loại KH3";
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj33 = lblTen_Tk;
		location = new Point(206, 108);
		((Control)obj33).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj34 = lblTen_Tk;
		size = new Size(324, 13);
		((Control)obj34).Size = size;
		((Control)lblTen_Tk).TabIndex = 1115;
		((TextBox)txtMa_Tk).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Tk.AutoLookup = true;
		txtMa_Tk.AutoValid = true;
		((TextBoxBase)txtMa_Tk).BackColor = SystemColors.Info;
		((TextBox)txtMa_Tk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_Tk;
		location = new Point(110, 104);
		((Control)asTextBox10).Location = location;
		txtMa_Tk.LookupCodeName = "TK";
		txtMa_Tk.LookupWhereCondition = "tk_cn=1";
		((Control)txtMa_Tk).Name = "txtMa_Tk";
		txtMa_Tk.NameControl = lblTen_Tk;
		txtMa_Tk.SD = true;
		AsTextBox asTextBox11 = txtMa_Tk;
		size = new Size(90, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_Tk).TabIndex = 3;
		txtMa_Tk.UseAutoCompleteSource = true;
		lblMa_tk.AutoSize = true;
		lblMa_tk.ImeMode = (ImeMode)0;
		Label obj35 = lblMa_tk;
		location = new Point(24, 108);
		((Control)obj35).Location = location;
		((Control)lblMa_tk).Name = "lblMa_tk";
		Label obj36 = lblMa_tk;
		size = new Size(55, 13);
		((Control)obj36).Size = size;
		((Control)lblMa_tk).TabIndex = 1114;
		lblMa_tk.Text = "Tài khoản";
		lblMa_tk.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(564, 387);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmARRptBCCN03";
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
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_Tk).Text);
		arrayList.Add(((TextBox)txtMa_Kh).Text);
		arrayList.Add(((TextBox)txtMa_plkh1).Text);
		arrayList.Add(((TextBox)txtMa_plkh2).Text);
		arrayList.Add(((TextBox)txtMa_plkh3).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		base.MyFomularFields.Add("tk", ((TextBox)txtMa_Tk).Text);
		base.MyFomularFields.Add("ten_tk", lblTen_Tk.Text);
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(((TextBox)txtMa_Kh).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Kh.Text + ": " + ((TextBox)txtMa_Kh).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plkh1).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLKh1.Text + ": " + ((TextBox)txtMa_plkh1).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plkh2).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLKh2.Text + ": " + ((TextBox)txtMa_plkh2).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_plkh3).Text.Trim(), "", false) != 0)
		{
			text = text + lblPLKh3.Text + ": " + ((TextBox)txtMa_plkh3).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
		}
		return text;
	}

	protected override bool ValidData()
	{
		((TextBox)txtMa_Tk).Text = ((TextBox)txtMa_Tk).Text.Trim();
		return ChkEmtyTextBox((TextBox)(object)txtMa_Tk);
	}
}
