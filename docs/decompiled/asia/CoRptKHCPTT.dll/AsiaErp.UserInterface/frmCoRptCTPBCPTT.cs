using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCoRptCTPBCPTT : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtMa_bpsd")]
	private AsTextBox _txtMa_bpsd;

	[AccessedThroughProperty("lblTen_bpsd")]
	private Label _lblTen_bpsd;

	[AccessedThroughProperty("lblMa_bpsd")]
	private Label _lblMa_bpsd;

	private string sTabName;

	private string sMenuID;

	private bool DataLoading;

	internal virtual AsTextBox txtMa_bpsd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_bpsd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_bpsd = value;
		}
	}

	internal virtual Label lblTen_bpsd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_bpsd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_bpsd = value;
		}
	}

	internal virtual Label lblMa_bpsd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_bpsd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_bpsd = value;
		}
	}

	public frmCoRptCTPBCPTT(string MenuID)
		: base(MenuID)
	{
		DataLoading = true;
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
		txtMa_bpsd = new AsTextBox();
		lblTen_bpsd = new Label();
		lblMa_bpsd = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Point location = new Point(0, 1);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		Size size = new Size(821, 553);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_bpsd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bpsd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bpsd);
		TabPage obj = tabFilter;
		size = new Size(813, 524);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bpsd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bpsd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bpsd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		Label obj2 = lbl2;
		location = new Point(277, 378);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(609, 357);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 11;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(296, 82);
		((Control)asMaskedTextBox).Location = location;
		Button obj4 = cmdCancel;
		location = new Point(528, 357);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 10;
		Button obj5 = cmdModifyReport;
		location = new Point(455, 27);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 13;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(206, 82);
		((Control)asMaskedTextBox2).Location = location;
		ComboBox obj6 = cboKyBc;
		location = new Point(110, 82);
		((Control)obj6).Location = location;
		Label obj7 = lblKyBc;
		location = new Point(18, 86);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(110, 29);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 16;
		Label obj9 = lblMau_bc;
		location = new Point(18, 33);
		((Control)obj9).Location = location;
		Label obj10 = lblMau_bc;
		size = new Size(47, 13);
		((Control)obj10).Size = size;
		lblMau_bc.Text = "Báo cáo";
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 348);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 8;
		((Control)txtMa_Nt).Visible = false;
		Label obj11 = lblMauBC;
		location = new Point(158, 347);
		((Control)obj11).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj12 = optVND;
		location = new Point(233, 346);
		((Control)obj12).Location = location;
		((Control)optVND).TabIndex = 14;
		optVND.TabStop = false;
		((Control)optVND).Visible = false;
		RadioButton obj13 = optNt;
		location = new Point(286, 347);
		((Control)obj13).Location = location;
		((Control)optNt).TabIndex = 15;
		((Control)optNt).Visible = false;
		Label obj14 = lblMa_nt;
		location = new Point(23, 350);
		((Control)obj14).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj15 = cmdOk;
		location = new Point(21, 152);
		((Control)obj15).Location = location;
		((Control)cmdOk).TabIndex = 12;
		Label obj16 = lblTieu_de;
		location = new Point(18, 60);
		((Control)obj16).Location = location;
		TextBox obj17 = txtTieu_De;
		location = new Point(110, 56);
		((Control)obj17).Location = location;
		((Control)txtTieu_De).TabIndex = 0;
		TabPage obj18 = tabGrid;
		size = new Size(813, 524);
		((Control)obj18).Size = size;
		txtMa_bpsd.AutoLookup = true;
		txtMa_bpsd.AutoValid = true;
		((TextBoxBase)txtMa_bpsd).BackColor = SystemColors.Info;
		((TextBox)txtMa_bpsd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_bpsd;
		location = new Point(110, 109);
		((Control)asTextBox2).Location = location;
		txtMa_bpsd.LookupCodeName = "MA_BPSD";
		((Control)txtMa_bpsd).Name = "txtMa_bpsd";
		txtMa_bpsd.NameControl = lblTen_bpsd;
		AsTextBox asTextBox3 = txtMa_bpsd;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_bpsd).TabIndex = 1016;
		txtMa_bpsd.UseAutoCompleteSource = true;
		Label obj19 = lblTen_bpsd;
		location = new Point(206, 111);
		((Control)obj19).Location = location;
		((Control)lblTen_bpsd).Name = "lblTen_bpsd";
		Label obj20 = lblTen_bpsd;
		size = new Size(324, 17);
		((Control)obj20).Size = size;
		((Control)lblTen_bpsd).TabIndex = 1017;
		lblMa_bpsd.AutoSize = true;
		Label obj21 = lblMa_bpsd;
		location = new Point(18, 112);
		((Control)obj21).Location = location;
		((Control)lblMa_bpsd).Name = "lblMa_bpsd";
		Label obj22 = lblMa_bpsd;
		size = new Size(54, 13);
		((Control)obj22).Size = size;
		((Control)lblMa_bpsd).TabIndex = 1018;
		lblMa_bpsd.Text = "Mã BPSD";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(821, 579);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCoRptCTPBCPTT";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool LoadData()
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay1.Value)));
			arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay2.Value)));
			arrayList.Add(((TextBox)txtMa_bpsd).Text);
			set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)("Lỗi lọc  dữ liệu: " + ex2.Message), (MsgBoxStyle)48, (object)"Thông báo");
			ProjectData.ClearProjectError();
		}
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(((TextBox)txtMa_bpsd).Text.Trim(), "", false) != 0)
		{
			text = text + "Bộ phận sử dụng:" + lblTen_bpsd.Text + ";";
		}
		return text;
	}
}
