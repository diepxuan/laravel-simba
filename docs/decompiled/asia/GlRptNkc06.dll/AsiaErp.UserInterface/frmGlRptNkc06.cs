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
public class frmGlRptNkc06 : frmReport
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

	public frmGlRptNkc06(string menuid)
		: base(menuid)
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
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
		Size size = new Size(555, 234);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		TabPage obj = tabFilter;
		size = new Size(547, 205);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		Label obj2 = lbl2;
		Point location = new Point(268, 82);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 182);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(287, 78);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 182);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(446, 24);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 7;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(197, 78);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(101, 78);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(25, 82);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(101, 25);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 6;
		((Control)cboMau_bc).TabStop = false;
		Label obj9 = lblMau_bc;
		location = new Point(25, 29);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(101, 131);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 4;
		Label obj10 = lblMauBC;
		location = new Point(146, 130);
		((Control)obj10).Location = location;
		RadioButton obj11 = optVND;
		location = new Point(233, 129);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 5;
		RadioButton obj12 = optNt;
		location = new Point(287, 130);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 6;
		Label obj13 = lblMa_nt;
		location = new Point(25, 133);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(28, 166);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 7;
		Label obj15 = lblTieu_de;
		location = new Point(25, 56);
		((Control)obj15).Location = location;
		TextBox obj16 = txtTieu_De;
		location = new Point(101, 52);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 8;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj17 = tabGrid;
		size = new Size(547, 206);
		((Control)obj17).Size = size;
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = false;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTk;
		location = new Point(101, 105);
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
		Label obj18 = lblTen_Tk;
		location = new Point(189, 109);
		((Control)obj18).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj19 = lblTen_Tk;
		size = new Size(328, 13);
		((Control)obj19).Size = size;
		((Control)lblTen_Tk).TabIndex = 1017;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj20 = lblTk;
		location = new Point(25, 109);
		((Control)obj20).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj21 = lblTk;
		size = new Size(55, 13);
		((Control)obj21).Size = size;
		((Control)lblTk).TabIndex = 1016;
		lblTk.Text = "Tài khoản";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(555, 259);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlRptNkc06";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool LoadData()
	{
		if (ValidData())
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			arrayList.Add(((TextBox)txtTk).Text);
			arrayList.Add(((TextBox)txtMa_Nt).Text);
			set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
			base.MyFomularFields.Clear();
			base.MyFomularFields.Add("TK", ((TextBox)txtTk).Text);
			base.MyFomularFields.Add("TEN_TK", lblTen_Tk.Text);
			base.MyFomularFields.Add("Du_Co_Cky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[2]["ps_co"]));
			base.MyFomularFields.Add("Du_No_Cky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[2]["ps_no"]));
			base.MyFomularFields.Add("Du_Co_Dky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[0]["ps_co"]));
			base.MyFomularFields.Add("Du_No_Dky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[0]["ps_no"]));
			return true;
		}
		return false;
	}

	protected override bool ValidData()
	{
		((Control)txtTk).Select();
		((Control)cmdOk).Select();
		((TextBox)txtTk).Text = ((TextBox)txtTk).Text.Trim();
		return ChkEmtyTextBox((TextBox)(object)txtTk);
	}
}
