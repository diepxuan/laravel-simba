using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmINRptBK01 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("lblMonth")]
	private Label _lblMonth;

	[AccessedThroughProperty("txtMonth")]
	private AsTextNumeric _txtMonth;

	[AccessedThroughProperty("txtYear")]
	private AsTextNumeric _txtYear;

	[AccessedThroughProperty("lblYear")]
	private Label _lblYear;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	internal virtual Label lblMonth
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMonth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMonth = value;
		}
	}

	internal virtual AsTextNumeric txtMonth
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMonth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMonth = value;
		}
	}

	internal virtual AsTextNumeric txtYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtYear = value;
		}
	}

	internal virtual Label lblYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblYear = value;
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

	public frmINRptBK01(string MenuID)
		: base(MenuID)
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		lblMonth = new Label();
		txtMonth = new AsTextNumeric();
		txtYear = new AsTextNumeric();
		lblYear = new Label();
		lblMa_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		lblTen_kho = new Label();
		txtMa_kho = new AsTextBox();
		lblMa_kho = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(618, 282);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblMonth);
		((Control)tabFilter).Controls.Add((Control)(object)txtMonth);
		((Control)tabFilter).Controls.Add((Control)(object)txtYear);
		((Control)tabFilter).Controls.Add((Control)(object)lblYear);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_kho);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_vt);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_kho);
		TabPage obj = tabFilter;
		size = new Size(610, 253);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblYear, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtYear, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMonth, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMonth, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		Label obj2 = lbl2;
		Point location = new Point(388, 435);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(512, 224);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 9;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(407, 431);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).Visible = false;
		Button obj4 = cmdCancel;
		location = new Point(431, 224);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 8;
		((Control)cmdModifyReport).TabIndex = 7;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(317, 431);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).Visible = false;
		ComboBox obj5 = cboKyBc;
		location = new Point(221, 431);
		((Control)obj5).Location = location;
		((Control)cboKyBc).Visible = false;
		Label obj6 = lblKyBc;
		location = new Point(135, 435);
		((Control)obj6).Location = location;
		((Control)lblKyBc).Visible = false;
		ComboBox obj7 = cboMau_bc;
		location = new Point(110, 24);
		((Control)obj7).Location = location;
		((Control)cboMau_bc).TabIndex = 5;
		((Control)lblMau_bc).TabIndex = 19;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(566, 432);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).Visible = false;
		Label obj8 = lblMauBC;
		location = new Point(24, 183);
		((Control)obj8).Location = location;
		((Control)lblMauBC).TabIndex = 13;
		RadioButton obj9 = optVND;
		location = new Point(110, 182);
		((Control)obj9).Location = location;
		((Control)optVND).TabIndex = 10;
		optVND.TabStop = false;
		RadioButton obj10 = optNt;
		location = new Point(177, 183);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 11;
		Label obj11 = lblMa_nt;
		location = new Point(480, 434);
		((Control)obj11).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj12 = cmdOk;
		location = new Point(27, 225);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 4;
		((Control)lblTieu_de).TabIndex = 18;
		((Control)txtTieu_De).TabIndex = 6;
		TabPage obj13 = tabGrid;
		size = new Size(610, 253);
		((Control)obj13).Size = size;
		lblMonth.AutoSize = true;
		Label obj14 = lblMonth;
		location = new Point(24, 82);
		((Control)obj14).Location = location;
		((Control)lblMonth).Name = "lblMonth";
		Label obj15 = lblMonth;
		size = new Size(38, 13);
		((Control)obj15).Size = size;
		((Control)lblMonth).TabIndex = 17;
		lblMonth.Text = "Tháng";
		txtMonth.DecimalSymbol = ".";
		txtMonth.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtMonth;
		location = new Point(110, 78);
		((Control)asTextNumeric).Location = location;
		txtMonth.Mask = "##";
		((Control)txtMonth).Name = "txtMonth";
		AsTextNumeric asTextNumeric2 = txtMonth;
		size = new Size(61, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtMonth).TabIndex = 0;
		((TextBox)txtMonth).Text = "0";
		((TextBox)txtMonth).TextAlign = (HorizontalAlignment)1;
		txtMonth.Value = 0;
		txtYear.DecimalSymbol = ".";
		txtYear.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtYear;
		location = new Point(110, 104);
		((Control)asTextNumeric3).Location = location;
		txtYear.Mask = "####";
		((Control)txtYear).Name = "txtYear";
		AsTextNumeric asTextNumeric4 = txtYear;
		size = new Size(61, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtYear).TabIndex = 1;
		((TextBox)txtYear).Text = "0";
		((TextBox)txtYear).TextAlign = (HorizontalAlignment)1;
		txtYear.Value = 0;
		lblYear.AutoSize = true;
		Label obj16 = lblYear;
		location = new Point(24, 108);
		((Control)obj16).Location = location;
		((Control)lblYear).Name = "lblYear";
		Label obj17 = lblYear;
		size = new Size(29, 13);
		((Control)obj17).Size = size;
		((Control)lblYear).TabIndex = 16;
		lblYear.Text = "Năm";
		lblMa_vt.AutoSize = true;
		Label obj18 = lblMa_vt;
		location = new Point(24, 134);
		((Control)obj18).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj19 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_vt).TabIndex = 15;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = true;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_vt;
		location = new Point(110, 130);
		((Control)asTextBox2).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox3 = txtMa_vt;
		size = new Size(61, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_vt).TabIndex = 2;
		((Control)txtMa_vt).Tag = "MA_VT";
		Label obj20 = lblTen_vt;
		location = new Point(177, 133);
		((Control)obj20).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj21 = lblTen_vt;
		size = new Size(274, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_vt).TabIndex = 10;
		Label obj22 = lblTen_kho;
		location = new Point(177, 159);
		((Control)obj22).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj23 = lblTen_kho;
		size = new Size(274, 13);
		((Control)obj23).Size = size;
		((Control)lblTen_kho).TabIndex = 11;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_kho;
		location = new Point(110, 156);
		((Control)asTextBox4).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox5 = txtMa_kho;
		size = new Size(61, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_kho).TabIndex = 3;
		((Control)txtMa_kho).Tag = "MA_KHO";
		lblMa_kho.AutoSize = true;
		Label obj24 = lblMa_kho;
		location = new Point(24, 160);
		((Control)obj24).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj25 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj25).Size = size;
		((Control)lblMa_kho).TabIndex = 14;
		lblMa_kho.Text = "Mã kho";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(618, 307);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmINRptBK01";
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
		((TextBox)txtMonth).Text = Conversions.ToString(DateTime.Today.Month);
		((TextBox)txtYear).Text = Conversions.ToString(DateTime.Today.Year);
	}

	protected override bool ValidData()
	{
		if ((Conversions.ToInteger(((TextBox)txtMonth).Text) < 1) | (Conversions.ToInteger(((TextBox)txtMonth).Text) > 12))
		{
			SetControlError((Control)(object)txtMonth, Helper.GetMessContent(50034));
			return false;
		}
		if (Conversions.ToInteger(((TextBox)txtYear).Text) < 0)
		{
			SetControlError((Control)(object)txtYear, Helper.GetMessContent(50034));
			return false;
		}
		return true;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(Conversions.ToInteger(((TextBox)txtYear).Text));
		arrayList.Add(Conversions.ToInteger(((TextBox)txtMonth).Text));
		arrayList.Add(((TextBox)txtMa_vt).Text);
		arrayList.Add(((TextBox)txtMa_kho).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("ConditionList", GetFilterTitle());
		return true;
	}

	public string GetFilterTitle()
	{
		string empty = string.Empty;
		empty = empty + lblMa_kho.Text + ":" + ((TextBox)txtMa_kho).Text + ";";
		return empty + lblMa_vt.Text + ":" + ((TextBox)txtMa_vt).Text + ";";
	}
}
