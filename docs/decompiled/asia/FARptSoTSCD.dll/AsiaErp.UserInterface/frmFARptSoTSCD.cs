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
public class frmFARptSoTSCD : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtMa_ts")]
	private AsTextBox _txtMa_ts;

	[AccessedThroughProperty("lblTen_ts")]
	private Label _lblTen_ts;

	[AccessedThroughProperty("lblMa_bpsd")]
	private Label _lblMa_bpsd;

	[AccessedThroughProperty("txtMa_bpsd")]
	private AsTextBox _txtMa_bpsd;

	[AccessedThroughProperty("lblTen_bpsd")]
	private Label _lblTen_bpsd;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtMa_nhts")]
	private AsTextBox _txtMa_nhts;

	[AccessedThroughProperty("lblTen_nhts")]
	private Label _lblTen_nhts;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	private string sTabName;

	private string sMenuID;

	private bool DataLoading;

	internal virtual AsTextBox txtMa_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_ts = value;
		}
	}

	internal virtual Label lblTen_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ts = value;
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

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual AsTextBox txtMa_nhts
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhts = value;
		}
	}

	internal virtual Label lblTen_nhts
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nhts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nhts = value;
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

	public frmFARptSoTSCD(string MenuID)
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		txtMa_ts = new AsTextBox();
		lblTen_ts = new Label();
		lblMa_bpsd = new Label();
		txtMa_nhts = new AsTextBox();
		lblTen_nhts = new Label();
		Label2 = new Label();
		txtMa_bpsd = new AsTextBox();
		lblTen_bpsd = new Label();
		Label4 = new Label();
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
		((Control)tabFilter).Controls.Add((Control)(object)Label4);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_nhts);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nhts);
		((Control)tabFilter).Controls.Add((Control)(object)Label2);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_ts);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_ts);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bpsd);
		TabPage obj = tabFilter;
		size = new Size(813, 524);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bpsd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_ts, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_ts, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nhts, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_nhts, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bpsd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bpsd, 0);
		Label obj2 = lbl2;
		location = new Point(277, 378);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(609, 357);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 11;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(315, 82);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 6;
		Button obj4 = cmdCancel;
		location = new Point(528, 357);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 10;
		Button obj5 = cmdModifyReport;
		location = new Point(474, 27);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 51;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(225, 82);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 5;
		ComboBox obj6 = cboKyBc;
		location = new Point(129, 82);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 4;
		Label obj7 = lblKyBc;
		location = new Point(18, 86);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(129, 29);
		((Control)obj8).Location = location;
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
		location = new Point(21, 207);
		((Control)obj15).Location = location;
		((Control)cmdOk).TabIndex = 50;
		Label obj16 = lblTieu_de;
		location = new Point(18, 60);
		((Control)obj16).Location = location;
		TextBox obj17 = txtTieu_De;
		location = new Point(129, 56);
		((Control)obj17).Location = location;
		((Control)txtTieu_De).TabIndex = 2;
		TabPage obj18 = tabGrid;
		size = new Size(813, 524);
		((Control)obj18).Size = size;
		txtMa_ts.AutoLookup = true;
		txtMa_ts.AutoValid = true;
		((TextBoxBase)txtMa_ts).BackColor = SystemColors.Info;
		((TextBox)txtMa_ts).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_ts;
		location = new Point(129, 109);
		((Control)asTextBox2).Location = location;
		txtMa_ts.LookupCodeName = "MA_TS";
		((Control)txtMa_ts).Name = "txtMa_ts";
		txtMa_ts.NameControl = lblTen_ts;
		AsTextBox asTextBox3 = txtMa_ts;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_ts).TabIndex = 8;
		txtMa_ts.UseAutoCompleteSource = true;
		Label obj19 = lblTen_ts;
		location = new Point(225, 111);
		((Control)obj19).Location = location;
		((Control)lblTen_ts).Name = "lblTen_ts";
		Label obj20 = lblTen_ts;
		size = new Size(324, 17);
		((Control)obj20).Size = size;
		((Control)lblTen_ts).TabIndex = 1017;
		lblMa_bpsd.AutoSize = true;
		Label obj21 = lblMa_bpsd;
		location = new Point(18, 112);
		((Control)obj21).Location = location;
		((Control)lblMa_bpsd).Name = "lblMa_bpsd";
		Label obj22 = lblMa_bpsd;
		size = new Size(56, 13);
		((Control)obj22).Size = size;
		((Control)lblMa_bpsd).TabIndex = 1018;
		lblMa_bpsd.Text = "Mã tài sản";
		txtMa_nhts.AutoLookup = true;
		txtMa_nhts.AutoValid = true;
		((TextBoxBase)txtMa_nhts).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhts).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_nhts;
		location = new Point(129, 135);
		((Control)asTextBox4).Location = location;
		txtMa_nhts.LookupCodeName = "MA_NHTS";
		((Control)txtMa_nhts).Name = "txtMa_nhts";
		txtMa_nhts.NameControl = lblTen_nhts;
		AsTextBox asTextBox5 = txtMa_nhts;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_nhts).TabIndex = 10;
		txtMa_nhts.UseAutoCompleteSource = true;
		Label obj23 = lblTen_nhts;
		location = new Point(225, 137);
		((Control)obj23).Location = location;
		((Control)lblTen_nhts).Name = "lblTen_nhts";
		Label obj24 = lblTen_nhts;
		size = new Size(324, 17);
		((Control)obj24).Size = size;
		((Control)lblTen_nhts).TabIndex = 1020;
		Label2.AutoSize = true;
		Label label = Label2;
		location = new Point(16, 138);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(85, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 1021;
		Label2.Text = "Mã nhóm tài sản";
		txtMa_bpsd.AutoLookup = true;
		txtMa_bpsd.AutoValid = true;
		((TextBoxBase)txtMa_bpsd).BackColor = SystemColors.Info;
		((TextBox)txtMa_bpsd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_bpsd;
		location = new Point(129, 161);
		((Control)asTextBox6).Location = location;
		txtMa_bpsd.LookupCodeName = "MA_BPSD";
		((Control)txtMa_bpsd).Name = "txtMa_bpsd";
		txtMa_bpsd.NameControl = lblTen_bpsd;
		AsTextBox asTextBox7 = txtMa_bpsd;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_bpsd).TabIndex = 12;
		txtMa_bpsd.UseAutoCompleteSource = true;
		Label obj25 = lblTen_bpsd;
		location = new Point(225, 163);
		((Control)obj25).Location = location;
		((Control)lblTen_bpsd).Name = "lblTen_bpsd";
		Label obj26 = lblTen_bpsd;
		size = new Size(324, 17);
		((Control)obj26).Size = size;
		((Control)lblTen_bpsd).TabIndex = 1023;
		Label4.AutoSize = true;
		Label label3 = Label4;
		location = new Point(16, 164);
		((Control)label3).Location = location;
		((Control)Label4).Name = "Label4";
		Label label4 = Label4;
		size = new Size(105, 13);
		((Control)label4).Size = size;
		((Control)Label4).TabIndex = 1024;
		Label4.Text = "Mã bộ phận sử dụng";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(821, 579);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFARptSoTSCD";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool LoadData()
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay1.Value)));
			arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay2.Value)));
			arrayList.Add(((TextBox)txtMa_ts).Text);
			arrayList.Add(((TextBox)txtMa_nhts).Text);
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
		if (Operators.CompareString(((TextBox)txtMa_ts).Text.Trim(), "", false) != 0)
		{
			text = text + "Bộ phận sử dụng:" + lblTen_ts.Text + ";";
		}
		return text;
	}
}
