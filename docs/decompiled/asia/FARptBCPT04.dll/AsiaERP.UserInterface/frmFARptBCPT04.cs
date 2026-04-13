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

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmFARptBCPT04 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTen_bpsd")]
	private Label _lblTen_bpsd;

	[AccessedThroughProperty("txtMa_bpsd")]
	private AsTextBox _txtMa_bpsd;

	[AccessedThroughProperty("lblMa_bpsd")]
	private Label _lblMa_bpsd;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("txtma_spct")]
	private AsTextBox _txtma_spct;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("lblTen_phi")]
	private Label _lblTen_phi;

	[AccessedThroughProperty("txtMa_phi")]
	private AsTextBox _txtMa_phi;

	[AccessedThroughProperty("lblMa_phi")]
	private Label _lblMa_phi;

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

	internal virtual Label lblTen_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_spct = value;
		}
	}

	internal virtual AsTextBox txtma_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtma_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtma_spct = value;
		}
	}

	internal virtual Label lblMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_spct = value;
		}
	}

	internal virtual Label lblTen_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_phi = value;
		}
	}

	internal virtual AsTextBox txtMa_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_phi = value;
		}
	}

	internal virtual Label lblMa_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_phi = value;
		}
	}

	public frmFARptBCPT04(string menuid)
		: base(menuid)
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
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		lblTen_bpsd = new Label();
		txtMa_bpsd = new AsTextBox();
		lblMa_bpsd = new Label();
		lblTen_phi = new Label();
		txtMa_phi = new AsTextBox();
		lblMa_phi = new Label();
		lblTen_spct = new Label();
		txtma_spct = new AsTextBox();
		lblMa_spct = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(565, 262);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtma_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_phi);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bpsd);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_bpsd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bpsd);
		TabPage obj = tabFilter;
		size = new Size(557, 233);
		((Control)obj).Size = size;
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bpsd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bpsd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bpsd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtma_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		Button obj2 = cmdExcel;
		Point location = new Point(700, 417);
		((Control)obj2).Location = location;
		((Control)cmdExcel).TabIndex = 10;
		Button obj3 = cmdCancel;
		location = new Point(619, 417);
		((Control)obj3).Location = location;
		((Control)cmdCancel).TabIndex = 9;
		((Control)cmdModifyReport).TabIndex = 6;
		((Control)cboKyBc).TabIndex = 0;
		((Control)cboMau_bc).TabIndex = 5;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(295, 418);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).Visible = false;
		Label obj4 = lblMauBC;
		location = new Point(340, 417);
		((Control)obj4).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj5 = optVND;
		location = new Point(427, 416);
		((Control)obj5).Location = location;
		((Control)optVND).Visible = false;
		RadioButton obj6 = optNt;
		location = new Point(481, 417);
		((Control)obj6).Location = location;
		((Control)optNt).Visible = false;
		Label obj7 = lblMa_nt;
		location = new Point(209, 420);
		((Control)obj7).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj8 = cmdOk;
		location = new Point(23, 192);
		((Control)obj8).Location = location;
		((Control)cmdOk).TabIndex = 4;
		((Control)lblTieu_de).TabIndex = 8;
		((Control)txtTieu_De).TabIndex = 7;
		TabPage obj9 = tabGrid;
		size = new Size(557, 233);
		((Control)obj9).Size = size;
		lblTen_bpsd.ImeMode = (ImeMode)0;
		Label obj10 = lblTen_bpsd;
		location = new Point(206, 108);
		((Control)obj10).Location = location;
		((Control)lblTen_bpsd).Name = "lblTen_bpsd";
		Label obj11 = lblTen_bpsd;
		size = new Size(314, 13);
		((Control)obj11).Size = size;
		((Control)lblTen_bpsd).TabIndex = 1118;
		lblTen_bpsd.TextAlign = (ContentAlignment)16;
		txtMa_bpsd.AutoLookup = true;
		txtMa_bpsd.AutoValid = false;
		((TextBoxBase)txtMa_bpsd).BackColor = SystemColors.Info;
		((TextBox)txtMa_bpsd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_bpsd;
		location = new Point(110, 105);
		((Control)asTextBox2).Location = location;
		txtMa_bpsd.LookupCodeName = "MA_BPSD";
		((Control)txtMa_bpsd).Name = "txtMa_bpsd";
		txtMa_bpsd.NameControl = lblTen_bpsd;
		AsTextBox asTextBox3 = txtMa_bpsd;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_bpsd).TabIndex = 1;
		txtMa_bpsd.UseAutoCompleteSource = true;
		lblMa_bpsd.AutoSize = true;
		Label obj12 = lblMa_bpsd;
		location = new Point(20, 108);
		((Control)obj12).Location = location;
		((Control)lblMa_bpsd).Name = "lblMa_bpsd";
		Label obj13 = lblMa_bpsd;
		size = new Size(54, 13);
		((Control)obj13).Size = size;
		((Control)lblMa_bpsd).TabIndex = 1117;
		lblMa_bpsd.Text = "Mã BPSD";
		lblTen_phi.ImeMode = (ImeMode)0;
		Label obj14 = lblTen_phi;
		location = new Point(206, 134);
		((Control)obj14).Location = location;
		((Control)lblTen_phi).Name = "lblTen_phi";
		Label obj15 = lblTen_phi;
		size = new Size(314, 13);
		((Control)obj15).Size = size;
		((Control)lblTen_phi).TabIndex = 1121;
		lblTen_phi.TextAlign = (ContentAlignment)16;
		txtMa_phi.AutoLookup = true;
		txtMa_phi.AutoValid = false;
		((TextBoxBase)txtMa_phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_phi;
		location = new Point(110, 131);
		((Control)asTextBox4).Location = location;
		txtMa_phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_phi).Name = "txtMa_phi";
		txtMa_phi.NameControl = lblTen_phi;
		AsTextBox asTextBox5 = txtMa_phi;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_phi).TabIndex = 2;
		txtMa_phi.UseAutoCompleteSource = true;
		lblMa_phi.AutoSize = true;
		Label obj16 = lblMa_phi;
		location = new Point(20, 134);
		((Control)obj16).Location = location;
		((Control)lblMa_phi).Name = "lblMa_phi";
		Label obj17 = lblMa_phi;
		size = new Size(41, 13);
		((Control)obj17).Size = size;
		((Control)lblMa_phi).TabIndex = 1120;
		lblMa_phi.Text = "Mã phí";
		lblTen_spct.ImeMode = (ImeMode)0;
		Label obj18 = lblTen_spct;
		location = new Point(206, 160);
		((Control)obj18).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj19 = lblTen_spct;
		size = new Size(314, 13);
		((Control)obj19).Size = size;
		((Control)lblTen_spct).TabIndex = 1124;
		lblTen_spct.TextAlign = (ContentAlignment)16;
		txtma_spct.AutoLookup = true;
		txtma_spct.AutoValid = false;
		((TextBoxBase)txtma_spct).BackColor = SystemColors.Info;
		((TextBox)txtma_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtma_spct;
		location = new Point(110, 157);
		((Control)asTextBox6).Location = location;
		txtma_spct.LookupCodeName = "MA_SPCT";
		((Control)txtma_spct).Name = "txtma_spct";
		txtma_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox7 = txtma_spct;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtma_spct).TabIndex = 3;
		txtma_spct.UseAutoCompleteSource = true;
		lblMa_spct.AutoSize = true;
		Label obj20 = lblMa_spct;
		location = new Point(20, 160);
		((Control)obj20).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj21 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj21).Size = size;
		((Control)lblMa_spct).TabIndex = 1123;
		lblMa_spct.Text = "Mã SPCT";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(565, 287);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFARptBCPT04";
		((Form)this).Text = "frmFARptBCPT04";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_bpsd).Text);
		arrayList.Add(((TextBox)txtMa_phi).Text);
		arrayList.Add(((TextBox)txtma_spct).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(((TextBox)txtMa_bpsd).Text, "", false) != 0)
		{
			text = text + lblMa_bpsd.Text + ": " + ((TextBox)txtMa_bpsd).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_phi).Text, "", false) != 0)
		{
			text = text + lblMa_phi.Text + ": " + ((TextBox)txtMa_phi).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtma_spct).Text, "", false) != 0)
		{
			text = text + lblTen_spct.Text + ": " + ((TextBox)txtma_spct).Text + "; ";
		}
		return text;
	}
}
