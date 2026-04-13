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
public class frmFARptBCTS06 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTen_Spct")]
	private Label _lblTen_Spct;

	[AccessedThroughProperty("txtMa_Spct")]
	private AsTextBox _txtMa_Spct;

	[AccessedThroughProperty("lblMa_Spct")]
	private Label _lblMa_Spct;

	[AccessedThroughProperty("lblTen_Phi")]
	private Label _lblTen_Phi;

	[AccessedThroughProperty("txtMa_Phi")]
	private AsTextBox _txtMa_Phi;

	[AccessedThroughProperty("lblMa_Phi")]
	private Label _lblMa_Phi;

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

	[AccessedThroughProperty("txtMa_Bp")]
	private AsTextBox _txtMa_Bp;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	internal virtual Label lblTen_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Spct = value;
		}
	}

	internal virtual AsTextBox txtMa_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Spct = value;
		}
	}

	internal virtual Label lblMa_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Spct = value;
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

	internal virtual Label lblTen_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Bp = value;
		}
	}

	internal virtual AsTextBox txtMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Bp = value;
		}
	}

	internal virtual Label lblMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Bp = value;
		}
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
		lblTen_Spct = new Label();
		txtMa_Spct = new AsTextBox();
		lblMa_Spct = new Label();
		lblTen_Phi = new Label();
		txtMa_Phi = new AsTextBox();
		lblMa_Phi = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_Bp = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(595, 263);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Bp);
		TabPage obj = tabFilter;
		size = new Size(587, 234);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Spct, 0);
		Button obj2 = cmdExcel;
		Point location = new Point(503, 935);
		((Control)obj2).Location = location;
		((Control)cmdExcel).TabIndex = 26;
		((Control)txtNgay2).TabIndex = 2;
		Button obj3 = cmdCancel;
		location = new Point(422, 935);
		((Control)obj3).Location = location;
		((Control)cmdCancel).TabIndex = 31;
		Button obj4 = cmdModifyReport;
		location = new Point(455, 24);
		((Control)obj4).Location = location;
		((Control)cmdModifyReport).TabIndex = 27;
		((Control)txtNgay1).TabIndex = 1;
		((Control)cboKyBc).TabIndex = 0;
		((Control)cboMau_bc).TabIndex = 29;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 575);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 22;
		((Control)txtMa_Nt).Visible = false;
		Label obj5 = lblMauBC;
		location = new Point(155, 575);
		((Control)obj5).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj6 = optVND;
		location = new Point(245, 575);
		((Control)obj6).Location = location;
		((Control)optVND).TabIndex = 23;
		((Control)optVND).Visible = false;
		RadioButton obj7 = optNt;
		location = new Point(309, 575);
		((Control)obj7).Location = location;
		((Control)optNt).TabIndex = 24;
		((Control)optNt).Visible = false;
		Label obj8 = lblMa_nt;
		location = new Point(24, 578);
		((Control)obj8).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj9 = cmdOk;
		location = new Point(27, 190);
		((Control)obj9).Location = location;
		((Control)cmdOk).TabIndex = 25;
		((Control)lblTieu_de).TabIndex = 28;
		((Control)txtTieu_De).TabIndex = 30;
		TabPage obj10 = tabGrid;
		size = new Size(587, 234);
		((Control)obj10).Size = size;
		lblTen_Spct.ImeMode = (ImeMode)0;
		Label obj11 = lblTen_Spct;
		location = new Point(212, 159);
		((Control)obj11).Location = location;
		((Control)lblTen_Spct).Name = "lblTen_Spct";
		Label obj12 = lblTen_Spct;
		size = new Size(366, 13);
		((Control)obj12).Size = size;
		((Control)lblTen_Spct).TabIndex = 1091;
		lblTen_Spct.TextAlign = (ContentAlignment)16;
		txtMa_Spct.AutoLookup = true;
		txtMa_Spct.AutoValid = false;
		((TextBoxBase)txtMa_Spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_Spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_Spct;
		location = new Point(110, 157);
		((Control)asTextBox2).Location = location;
		txtMa_Spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_Spct).Name = "txtMa_Spct";
		txtMa_Spct.NameControl = lblTen_Spct;
		AsTextBox asTextBox3 = txtMa_Spct;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_Spct).TabIndex = 19;
		txtMa_Spct.UseAutoCompleteSource = true;
		lblMa_Spct.AutoSize = true;
		lblMa_Spct.ImeMode = (ImeMode)0;
		Label obj13 = lblMa_Spct;
		location = new Point(24, 161);
		((Control)obj13).Location = location;
		((Control)lblMa_Spct).Name = "lblMa_Spct";
		Label obj14 = lblMa_Spct;
		size = new Size(53, 13);
		((Control)obj14).Size = size;
		((Control)lblMa_Spct).TabIndex = 1090;
		lblMa_Spct.Text = "Mã SPCT";
		lblTen_Phi.ImeMode = (ImeMode)0;
		Label obj15 = lblTen_Phi;
		location = new Point(212, 134);
		((Control)obj15).Location = location;
		((Control)lblTen_Phi).Name = "lblTen_Phi";
		Label obj16 = lblTen_Phi;
		size = new Size(366, 13);
		((Control)obj16).Size = size;
		((Control)lblTen_Phi).TabIndex = 1085;
		lblTen_Phi.TextAlign = (ContentAlignment)16;
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_Phi;
		location = new Point(110, 131);
		((Control)asTextBox4).Location = location;
		txtMa_Phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		txtMa_Phi.NameControl = lblTen_Phi;
		AsTextBox asTextBox5 = txtMa_Phi;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_Phi).TabIndex = 17;
		txtMa_Phi.UseAutoCompleteSource = true;
		lblMa_Phi.AutoSize = true;
		lblMa_Phi.ImeMode = (ImeMode)0;
		Label obj17 = lblMa_Phi;
		location = new Point(24, 134);
		((Control)obj17).Location = location;
		((Control)lblMa_Phi).Name = "lblMa_Phi";
		Label obj18 = lblMa_Phi;
		size = new Size(41, 13);
		((Control)obj18).Size = size;
		((Control)lblMa_Phi).TabIndex = 1084;
		lblMa_Phi.Text = "Mã phí";
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj19 = lblTen_Bp;
		location = new Point(212, 108);
		((Control)obj19).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj20 = lblTen_Bp;
		size = new Size(366, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_Bp).TabIndex = 1083;
		lblTen_Bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_Bp;
		location = new Point(110, 105);
		((Control)asTextBox6).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BPSD";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox7 = txtMa_Bp;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_Bp).TabIndex = 16;
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_Bp.AutoSize = true;
		lblMa_Bp.ImeMode = (ImeMode)0;
		Label obj21 = lblMa_Bp;
		location = new Point(24, 109);
		((Control)obj21).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj22 = lblMa_Bp;
		size = new Size(54, 13);
		((Control)obj22).Size = size;
		((Control)lblMa_Bp).TabIndex = 1082;
		lblMa_Bp.Text = "Mã BPSD";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(595, 288);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFARptBCTS06";
		((Form)this).Text = "frmFARptBCTS06";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public frmFARptBCTS06(string Menuid)
		: base(Menuid)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
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
		arrayList.Add(((TextBox)txtMa_Bp).Text);
		arrayList.Add(((TextBox)txtMa_Phi).Text);
		arrayList.Add(((TextBox)txtMa_Spct).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.ViewCrystalBySource();
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(((TextBox)txtMa_Bp).Text, "", false) != 0)
		{
			text = text + lblMa_Bp.Text + ": " + ((TextBox)txtMa_Bp).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Phi).Text, "", false) != 0)
		{
			text = text + lblMa_Phi.Text + ": " + ((TextBox)txtMa_Phi).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Spct).Text, "", false) != 0)
		{
			text = text + lblMa_Spct.Text + ": " + ((TextBox)txtMa_Spct).Text + " ";
		}
		return text;
	}
}
