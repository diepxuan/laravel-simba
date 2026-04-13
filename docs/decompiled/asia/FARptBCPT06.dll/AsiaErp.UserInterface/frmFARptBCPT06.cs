using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmFARptBCPT06 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_BPSD")]
	private AsTextBox _txtMa_BPSD;

	[AccessedThroughProperty("lblTen_BPSD")]
	private Label _lblTen_BPSD;

	[AccessedThroughProperty("lblMa_BPSD")]
	private Label _lblMa_BPSD;

	[AccessedThroughProperty("txtMa_Phi")]
	private AsTextBox _txtMa_Phi;

	[AccessedThroughProperty("lblTen_Phi")]
	private Label _lblTen_Phi;

	[AccessedThroughProperty("lblMa_Phi")]
	private Label _lblMa_Phi;

	[AccessedThroughProperty("lblMa_SPCT")]
	private Label _lblMa_SPCT;

	[AccessedThroughProperty("txtMa_SPCT")]
	private AsTextBox _txtMa_SPCT;

	[AccessedThroughProperty("lblTen_SPCT")]
	private Label _lblTen_SPCT;

	internal virtual AsTextBox txtMa_BPSD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_BPSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_BPSD = value;
		}
	}

	internal virtual Label lblTen_BPSD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_BPSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_BPSD = value;
		}
	}

	internal virtual Label lblMa_BPSD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_BPSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_BPSD = value;
		}
	}

	internal virtual AsTextBox txtMa_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Phi = value;
		}
	}

	internal virtual Label lblTen_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Phi = value;
		}
	}

	internal virtual Label lblMa_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Phi = value;
		}
	}

	internal virtual Label lblMa_SPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_SPCT = value;
		}
	}

	internal virtual AsTextBox txtMa_SPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_SPCT = value;
		}
	}

	internal virtual Label lblTen_SPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_SPCT = value;
		}
	}

	public frmFARptBCPT06(ref string MenuId)
		: base(MenuId)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		txtMa_BPSD = new AsTextBox();
		lblTen_BPSD = new Label();
		lblMa_BPSD = new Label();
		txtMa_Phi = new AsTextBox();
		lblTen_Phi = new Label();
		lblMa_Phi = new Label();
		lblMa_SPCT = new Label();
		txtMa_SPCT = new AsTextBox();
		lblTen_SPCT = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(571, 259);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_BPSD);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_BPSD);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_BPSD);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_SPCT);
		TabPage obj = tabFilter;
		size = new Size(563, 230);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_BPSD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_BPSD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_BPSD, 0);
		Label obj2 = lbl2;
		Point location = new Point(290, 82);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 10;
		((Control)cmdExcel).Anchor = (AnchorStyles)10;
		Button obj3 = cmdExcel;
		location = new Point(481, 207);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 17;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(309, 78);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		((Control)cmdCancel).Anchor = (AnchorStyles)10;
		Button obj4 = cmdCancel;
		location = new Point(400, 207);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 16;
		Button obj5 = cmdModifyReport;
		location = new Point(466, 24);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 7;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(221, 78);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(121, 78);
		((Control)obj6).Location = location;
		ComboBox obj7 = cboKyBc;
		size = new Size(87, 21);
		((Control)obj7).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		ComboBox obj8 = cboMau_bc;
		location = new Point(121, 25);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 8;
		Label obj9 = lblMau_bc;
		location = new Point(24, 29);
		((Control)obj9).Location = location;
		((Control)txtMa_Nt).Enabled = false;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(326, 273);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 13;
		((Control)txtMa_Nt).Visible = false;
		((Control)lblMauBC).Enabled = false;
		Label obj10 = lblMauBC;
		location = new Point(371, 272);
		((Control)obj10).Location = location;
		((Control)lblMauBC).Visible = false;
		((Control)optVND).Enabled = false;
		RadioButton obj11 = optVND;
		location = new Point(458, 271);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 14;
		((Control)optVND).Visible = false;
		((Control)optNt).Enabled = false;
		RadioButton obj12 = optNt;
		location = new Point(512, 272);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 15;
		((Control)optNt).Visible = false;
		((Control)lblMa_nt).Enabled = false;
		Label obj13 = lblMa_nt;
		location = new Point(240, 275);
		((Control)obj13).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj14 = cmdOk;
		location = new Point(27, 185);
		((Control)obj14).Location = location;
		((Control)lblTieu_de).TabIndex = 18;
		TextBox obj15 = txtTieu_De;
		location = new Point(121, 52);
		((Control)obj15).Location = location;
		((Control)txtTieu_De).TabIndex = 9;
		TabPage obj16 = tabGrid;
		size = new Size(603, 255);
		((Control)obj16).Size = size;
		txtMa_BPSD.AutoLookup = true;
		txtMa_BPSD.AutoValid = false;
		((TextBoxBase)txtMa_BPSD).BackColor = SystemColors.Info;
		((TextBox)txtMa_BPSD).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_BPSD;
		location = new Point(121, 107);
		((Control)asTextBox2).Location = location;
		txtMa_BPSD.LookupCodeName = "MA_BPSD";
		((TextBoxBase)txtMa_BPSD).MaxLength = 8;
		((Control)txtMa_BPSD).Name = "txtMa_BPSD";
		txtMa_BPSD.NameControl = lblTen_BPSD;
		AsTextBox asTextBox3 = txtMa_BPSD;
		size = new Size(87, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_BPSD).TabIndex = 3;
		((Control)lblTen_BPSD).BackColor = Color.Transparent;
		Label obj17 = lblTen_BPSD;
		location = new Point(221, 111);
		((Control)obj17).Location = location;
		((Control)lblTen_BPSD).Name = "lblTen_BPSD";
		Label obj18 = lblTen_BPSD;
		size = new Size(319, 13);
		((Control)obj18).Size = size;
		((Control)lblTen_BPSD).TabIndex = 11;
		lblMa_BPSD.AutoSize = true;
		Label obj19 = lblMa_BPSD;
		location = new Point(24, 111);
		((Control)obj19).Location = location;
		((Control)lblMa_BPSD).Name = "lblMa_BPSD";
		Label obj20 = lblMa_BPSD;
		size = new Size(54, 13);
		((Control)obj20).Size = size;
		((Control)lblMa_BPSD).TabIndex = 1348;
		lblMa_BPSD.Text = "Mã BPSD";
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_Phi;
		location = new Point(121, 131);
		((Control)asTextBox4).Location = location;
		txtMa_Phi.LookupCodeName = "MA_PHI";
		((TextBoxBase)txtMa_Phi).MaxLength = 8;
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		txtMa_Phi.NameControl = lblTen_Phi;
		AsTextBox asTextBox5 = txtMa_Phi;
		size = new Size(87, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_Phi).TabIndex = 4;
		((Control)lblTen_Phi).BackColor = Color.Transparent;
		Label obj21 = lblTen_Phi;
		location = new Point(221, 135);
		((Control)obj21).Location = location;
		((Control)lblTen_Phi).Name = "lblTen_Phi";
		Label obj22 = lblTen_Phi;
		size = new Size(319, 13);
		((Control)obj22).Size = size;
		((Control)lblTen_Phi).TabIndex = 12;
		lblMa_Phi.AutoSize = true;
		Label obj23 = lblMa_Phi;
		location = new Point(24, 135);
		((Control)obj23).Location = location;
		((Control)lblMa_Phi).Name = "lblMa_Phi";
		Label obj24 = lblMa_Phi;
		size = new Size(41, 13);
		((Control)obj24).Size = size;
		((Control)lblMa_Phi).TabIndex = 1346;
		lblMa_Phi.Text = "Mã phí";
		lblMa_SPCT.AutoSize = true;
		Label obj25 = lblMa_SPCT;
		location = new Point(24, 159);
		((Control)obj25).Location = location;
		((Control)lblMa_SPCT).Name = "lblMa_SPCT";
		Label obj26 = lblMa_SPCT;
		size = new Size(53, 13);
		((Control)obj26).Size = size;
		((Control)lblMa_SPCT).TabIndex = 1344;
		lblMa_SPCT.Text = "Mã SPCT";
		txtMa_SPCT.AutoLookup = true;
		txtMa_SPCT.AutoValid = false;
		((TextBoxBase)txtMa_SPCT).BackColor = SystemColors.Info;
		((TextBox)txtMa_SPCT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_SPCT;
		location = new Point(121, 155);
		((Control)asTextBox6).Location = location;
		txtMa_SPCT.LookupCodeName = "MA_SPCT";
		((TextBoxBase)txtMa_SPCT).MaxLength = 8;
		((Control)txtMa_SPCT).Name = "txtMa_SPCT";
		txtMa_SPCT.NameControl = lblTen_SPCT;
		AsTextBox asTextBox7 = txtMa_SPCT;
		size = new Size(87, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_SPCT).TabIndex = 5;
		((Control)lblTen_SPCT).BackColor = Color.Transparent;
		Label obj27 = lblTen_SPCT;
		location = new Point(221, 159);
		((Control)obj27).Location = location;
		((Control)lblTen_SPCT).Name = "lblTen_SPCT";
		Label obj28 = lblTen_SPCT;
		size = new Size(319, 13);
		((Control)obj28).Size = size;
		((Control)lblTen_SPCT).TabIndex = 1345;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(571, 284);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFARptBCPT06";
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
		((Control)cboKyBc).Select();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_BPSD).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Phi).Text.Trim());
		arrayList.Add(((TextBox)txtMa_SPCT).Text.Trim());
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strSubTitle1", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = string.Empty;
		if (Operators.CompareString(((TextBox)txtMa_BPSD).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_BPSD.Text + ": " + ((TextBox)txtMa_BPSD).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Phi).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Phi.Text + ": " + ((TextBox)txtMa_Phi).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_SPCT).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_SPCT.Text + ": " + ((TextBox)txtMa_SPCT).Text + "; ";
		}
		return text;
	}
}
