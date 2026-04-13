using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLRptBCPT02 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	private virtual AsTextBox txtTk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk = value;
		}
	}

	private virtual Label lblTen_Tk
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

	private virtual Label lblTk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk = value;
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		txtTk = new AsTextBox();
		lblTen_Tk = new Label();
		lblTk = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(596, 228);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		TabPage obj = tabFilter;
		size = new Size(588, 199);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		Label obj2 = lbl2;
		Point location = new Point(279, 85);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(505, 170);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 8;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(424, 170);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 18;
		Button obj5 = cmdModifyReport;
		location = new Point(455, 24);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 9;
		((Control)txtNgay1).TabIndex = 1;
		((Control)cboKyBc).TabIndex = 0;
		Label obj6 = lblKyBc;
		location = new Point(25, 80);
		((Control)obj6).Location = location;
		((Control)cboMau_bc).TabIndex = 13;
		Label obj7 = lblMau_bc;
		location = new Point(25, 28);
		((Control)obj7).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 132);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 4;
		Label obj8 = lblMauBC;
		location = new Point(155, 131);
		((Control)obj8).Location = location;
		RadioButton obj9 = optVND;
		location = new Point(242, 131);
		((Control)obj9).Location = location;
		((Control)optVND).TabIndex = 5;
		RadioButton obj10 = optNt;
		location = new Point(296, 131);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 6;
		Label obj11 = lblMa_nt;
		location = new Point(25, 133);
		((Control)obj11).Location = location;
		Button obj12 = cmdOk;
		location = new Point(24, 162);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 7;
		Label obj13 = lblTieu_de;
		location = new Point(25, 54);
		((Control)obj13).Location = location;
		((Control)lblTieu_de).TabIndex = 12;
		((Control)txtTieu_De).TabIndex = 14;
		TabPage obj14 = tabGrid;
		size = new Size(588, 199);
		((Control)obj14).Size = size;
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = true;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTk;
		location = new Point(110, 106);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk;
		AsTextBox asTextBox3 = txtTk;
		size = new Size(82, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 3;
		((Control)txtTk).Tag = "@pTk";
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj15 = lblTen_Tk;
		location = new Point(198, 107);
		((Control)obj15).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj16 = lblTen_Tk;
		size = new Size(366, 13);
		((Control)obj16).Size = size;
		((Control)lblTen_Tk).TabIndex = 1080;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj17 = lblTk;
		location = new Point(25, 105);
		((Control)obj17).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj18 = lblTk;
		size = new Size(55, 13);
		((Control)obj18).Size = size;
		((Control)lblTk).TabIndex = 1079;
		lblTk.Text = "Tài khoản";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(596, 253);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGLRptBCPT02";
		((Form)this).Text = "frmGLRptBCPT02";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public frmGLRptBCPT02(string Menuid)
		: base(Menuid)
	{
		InitializeComponent();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(((TextBox)txtTk).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.ViewCrystalBySource();
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strTK", "Tài khoản :" + ((TextBox)txtTk).Text);
		return true;
	}

	protected override bool ValidData()
	{
		((TextBox)txtTk).Text = ((TextBox)txtTk).Text.Trim();
		return ChkEmtyTextBox((TextBox)(object)txtTk);
	}
}
