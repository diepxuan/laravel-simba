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
public class frmGLRptBCTCCDTB02 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	internal virtual AsTextBox txtTk
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

	internal virtual Label lblTk
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

	public frmGLRptBCTCCDTB02(string menuid)
		: base(menuid)
	{
		InitializeComponent();
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
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected O, but got Unknown
		txtTk = new AsTextBox();
		lblTen_Tk = new Label();
		lblTk = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		Label obj = lbl2;
		Point location = new Point(281, 82);
		((Control)obj).Location = location;
		((Control)lbl2).TabIndex = 6;
		((Control)cmdExcel).TabIndex = 10;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(300, 78);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 6;
		((Control)cmdCancel).TabIndex = 9;
		Button obj2 = cmdModifyReport;
		location = new Point(459, 23);
		((Control)obj2).Location = location;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(210, 78);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 5;
		ComboBox obj3 = cboKyBc;
		location = new Point(114, 78);
		((Control)obj3).Location = location;
		((Control)cboKyBc).TabIndex = 4;
		Label obj4 = lblKyBc;
		location = new Point(26, 82);
		((Control)obj4).Location = location;
		ComboBox obj5 = cboMau_bc;
		location = new Point(114, 25);
		((Control)obj5).Location = location;
		((Control)cboMau_bc).TabIndex = 1;
		Label obj6 = lblMau_bc;
		location = new Point(26, 28);
		((Control)obj6).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(114, 131);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 7;
		((Control)txtMa_Nt).Visible = false;
		Label obj7 = lblMauBC;
		location = new Point(159, 130);
		((Control)obj7).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj8 = optVND;
		location = new Point(246, 129);
		((Control)obj8).Location = location;
		((Control)optVND).Visible = false;
		RadioButton obj9 = optNt;
		location = new Point(300, 130);
		((Control)obj9).Location = location;
		((Control)optNt).Visible = false;
		Label obj10 = lblMa_nt;
		location = new Point(26, 135);
		((Control)obj10).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj11 = cmdOk;
		location = new Point(26, 163);
		((Control)obj11).Location = location;
		((Control)cmdOk).TabIndex = 8;
		Label obj12 = lblTieu_de;
		location = new Point(26, 56);
		((Control)obj12).Location = location;
		TextBox obj13 = txtTieu_De;
		location = new Point(114, 52);
		((Control)obj13).Location = location;
		((Control)txtTieu_De).TabIndex = 3;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = false;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTk;
		location = new Point(114, 105);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk;
		AsTextBox asTextBox3 = txtTk;
		Size size = new Size(100, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 7;
		txtTk.UseAutoCompleteSource = true;
		Label obj14 = lblTen_Tk;
		location = new Point(232, 105);
		((Control)obj14).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj15 = lblTen_Tk;
		size = new Size(300, 20);
		((Control)obj15).Size = size;
		((Control)lblTen_Tk).TabIndex = 1105;
		lblTk.AutoSize = true;
		Label obj16 = lblTk;
		location = new Point(26, 108);
		((Control)obj16).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj17 = lblTk;
		size = new Size(55, 13);
		((Control)obj17).Size = size;
		((Control)lblTk).TabIndex = 1104;
		lblTk.Text = "Tài khoản";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(790, 510);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmGLRptBCTCCDTB02";
		((Form)this).Text = "frmGLRptBCTCCDTB02";
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
		((TextBox)txtTk).Text = MyMenuInfo.par1;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtTk).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFiltertitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string result = "";
		if (Operators.CompareString(((TextBox)txtTk).Text, "", false) != 0)
		{
			result = lblTk.Text + ": [" + ((TextBox)txtTk).Text + " - " + lblTen_Tk.Text + "]; ";
		}
		return result;
	}
}
