using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using AsiaErp.Framework;
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCARptTMNH06 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_TK")]
	private AsTextBox _txtMa_TK;

	[AccessedThroughProperty("lblMa_TK")]
	private Label _lblMa_TK;

	[AccessedThroughProperty("lblTen_TK")]
	private Label _lblTen_TK;

	[AccessedThroughProperty("txtMa_ku")]
	private AsTextBox _txtMa_ku;

	[AccessedThroughProperty("lblTen_ku")]
	private Label _lblTen_ku;

	[AccessedThroughProperty("lblMa_ku")]
	private Label _lblMa_ku;

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

	internal virtual AsTextBox txtMa_TK
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_TK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_TK = value;
		}
	}

	internal virtual Label lblMa_TK
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_TK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_TK = value;
		}
	}

	internal virtual Label lblTen_TK
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TK = value;
		}
	}

	internal virtual AsTextBox txtMa_ku
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_ku = value;
		}
	}

	internal virtual Label lblTen_ku
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ku = value;
		}
	}

	internal virtual Label lblMa_ku
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_ku = value;
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

	public frmCARptTMNH06(string MenuID)
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
		//IL_0a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a52: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		lblMa_TK = new Label();
		txtMa_TK = new AsTextBox();
		lblTen_TK = new Label();
		lblTen_ku = new Label();
		lblMa_ku = new Label();
		txtMa_ku = new AsTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(631, 274);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_TK);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_TK);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_ku);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_ku);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_ku);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_TK);
		TabPage obj = tabFilter;
		size = new Size(623, 245);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_TK, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_ku, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_ku, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_ku, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_TK, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_TK, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
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
		Label obj2 = lbl2;
		Point location = new Point(277, 81);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(544, 236);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 8;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(296, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(463, 236);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 7;
		((Control)cmdModifyReport).TabIndex = 10;
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
		((Control)cboMau_bc).TabIndex = 9;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 156);
		((Control)asTextBox).Location = location;
		Label obj8 = lblMauBC;
		location = new Point(155, 155);
		((Control)obj8).Location = location;
		RadioButton obj9 = optVND;
		location = new Point(242, 154);
		((Control)obj9).Location = location;
		optVND.TabStop = false;
		RadioButton obj10 = optNt;
		location = new Point(292, 155);
		((Control)obj10).Location = location;
		Label obj11 = lblMa_nt;
		location = new Point(24, 158);
		((Control)obj11).Location = location;
		Button obj12 = cmdOk;
		location = new Point(27, 218);
		((Control)obj12).Location = location;
		Label obj13 = lblTieu_de;
		location = new Point(24, 55);
		((Control)obj13).Location = location;
		TextBox obj14 = txtTieu_De;
		location = new Point(110, 51);
		((Control)obj14).Location = location;
		((Control)txtTieu_De).TabIndex = 11;
		TabPage obj15 = tabGrid;
		size = new Size(623, 245);
		((Control)obj15).Size = size;
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
		size = new Size(623, 245);
		((Control)obj17).Size = size;
		((Control)crvReportViewer).TabIndex = 0;
		crvReportViewer.ViewTimeSelectionFormula = "";
		lblMa_TK.AutoSize = true;
		Label obj18 = lblMa_TK;
		location = new Point(24, 108);
		((Control)obj18).Location = location;
		((Control)lblMa_TK).Name = "lblMa_TK";
		Label obj19 = lblMa_TK;
		size = new Size(55, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_TK).TabIndex = 1016;
		lblMa_TK.Text = "Tài khoản";
		txtMa_TK.AutoLookup = true;
		txtMa_TK.AutoValid = true;
		((TextBoxBase)txtMa_TK).BackColor = SystemColors.Info;
		((TextBox)txtMa_TK).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_TK;
		location = new Point(110, 104);
		((Control)asTextBox2).Location = location;
		txtMa_TK.LookupCodeName = "TK";
		((Control)txtMa_TK).Name = "txtMa_TK";
		txtMa_TK.NameControl = lblTen_TK;
		AsTextBox asTextBox3 = txtMa_TK;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_TK).TabIndex = 3;
		txtMa_TK.UseAutoCompleteSource = true;
		Label obj20 = lblTen_TK;
		location = new Point(206, 108);
		((Control)obj20).Location = location;
		((Control)lblTen_TK).Name = "lblTen_TK";
		Label obj21 = lblTen_TK;
		size = new Size(324, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_TK).TabIndex = 1016;
		((Control)lblTen_ku).Enabled = false;
		Label obj22 = lblTen_ku;
		location = new Point(254, 197);
		((Control)obj22).Location = location;
		((Control)lblTen_ku).Name = "lblTen_ku";
		Label obj23 = lblTen_ku;
		size = new Size(324, 13);
		((Control)obj23).Size = size;
		((Control)lblTen_ku).TabIndex = 1016;
		((Control)lblTen_ku).Visible = false;
		lblMa_ku.AutoSize = true;
		((Control)lblMa_ku).Enabled = false;
		Label obj24 = lblMa_ku;
		location = new Point(72, 197);
		((Control)obj24).Location = location;
		((Control)lblMa_ku).Name = "lblMa_ku";
		Label obj25 = lblMa_ku;
		size = new Size(64, 13);
		((Control)obj25).Size = size;
		((Control)lblMa_ku).TabIndex = 1016;
		lblMa_ku.Text = "Mã khế ước";
		((Control)lblMa_ku).Visible = false;
		txtMa_ku.AutoLookup = true;
		txtMa_ku.AutoValid = true;
		((TextBoxBase)txtMa_ku).BackColor = SystemColors.Info;
		((TextBox)txtMa_ku).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_ku).Enabled = false;
		AsTextBox asTextBox4 = txtMa_ku;
		location = new Point(158, 193);
		((Control)asTextBox4).Location = location;
		txtMa_ku.LookupCodeName = "MA_KU";
		((Control)txtMa_ku).Name = "txtMa_ku";
		txtMa_ku.NameControl = lblTen_ku;
		AsTextBox asTextBox5 = txtMa_ku;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_ku).TabIndex = 4;
		txtMa_ku.UseAutoCompleteSource = true;
		((Control)txtMa_ku).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(631, 299);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmCARptTMNH06";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox((TextBox)(object)txtMa_TK) && base.ValidData()) ? true : false;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_TK).Text);
		arrayList.Add(((TextBox)txtMa_ku).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(lblMa_TK.Text + ":" + ((TextBox)txtMa_TK).Text + ";");
		stringBuilder.Append(lblMa_ku.Text + ":" + ((TextBox)txtMa_ku).Text + ";");
		return stringBuilder.ToString();
	}
}
