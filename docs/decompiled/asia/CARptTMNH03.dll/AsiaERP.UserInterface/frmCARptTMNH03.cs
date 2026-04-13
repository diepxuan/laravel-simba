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
public class frmCARptTMNH03 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("txtMa_ku")]
	private AsTextBox _txtMa_ku;

	[AccessedThroughProperty("lblTen_ku")]
	private Label _lblTen_ku;

	[AccessedThroughProperty("lblMa_ku")]
	private Label _lblMa_ku;

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

	private virtual AsTextBox txtMa_ku
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

	private virtual Label lblTen_ku
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

	private virtual Label lblMa_ku
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

	public frmCARptTMNH03(string menuid)
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		txtTk = new AsTextBox();
		lblTen_Tk = new Label();
		lblTk = new Label();
		txtMa_ku = new AsTextBox();
		lblTen_ku = new Label();
		lblMa_ku = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(686, 287);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_ku);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_ku);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_ku);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		TabPage obj = tabFilter;
		size = new Size(678, 258);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_ku, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_ku, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_ku, 0);
		Button obj2 = cmdExcel;
		Point location = new Point(700, 235);
		((Control)obj2).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj3 = cmdCancel;
		location = new Point(619, 235);
		((Control)obj3).Location = location;
		((Control)cmdCancel).TabIndex = 13;
		((Control)cmdModifyReport).TabIndex = 10;
		((Control)txtNgay1).TabIndex = 1;
		((Control)cboKyBc).TabIndex = 0;
		((Control)cboMau_bc).TabIndex = 9;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 158);
		((Control)asTextBox).Location = location;
		Label obj4 = lblMauBC;
		location = new Point(155, 157);
		((Control)obj4).Location = location;
		RadioButton obj5 = optVND;
		location = new Point(242, 156);
		((Control)obj5).Location = location;
		((Control)optVND).TabIndex = 6;
		RadioButton obj6 = optNt;
		location = new Point(296, 157);
		((Control)obj6).Location = location;
		((Control)optNt).TabIndex = 7;
		Label obj7 = lblMa_nt;
		location = new Point(24, 160);
		((Control)obj7).Location = location;
		Button obj8 = cmdOk;
		location = new Point(24, 209);
		((Control)obj8).Location = location;
		((Control)cmdOk).TabIndex = 8;
		((Control)lblTieu_de).TabIndex = 11;
		((Control)txtTieu_De).TabIndex = 12;
		TabPage obj9 = tabGrid;
		size = new Size(678, 258);
		((Control)obj9).Size = size;
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = true;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTk;
		location = new Point(110, 105);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		((TextBoxBase)txtTk).MaxLength = 20;
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk;
		AsTextBox asTextBox3 = txtTk;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 3;
		((Control)txtTk).Tag = "@pTk";
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj10 = lblTen_Tk;
		location = new Point(206, 108);
		((Control)obj10).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj11 = lblTen_Tk;
		size = new Size(324, 13);
		((Control)obj11).Size = size;
		((Control)lblTen_Tk).TabIndex = 1025;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj12 = lblTk;
		location = new Point(24, 108);
		((Control)obj12).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj13 = lblTk;
		size = new Size(75, 13);
		((Control)obj13).Size = size;
		((Control)lblTk).TabIndex = 1024;
		lblTk.Text = "Tài khoản vay";
		((TextBox)txtMa_ku).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_ku.AutoLookup = true;
		txtMa_ku.AutoValid = false;
		((TextBoxBase)txtMa_ku).BackColor = SystemColors.Info;
		((TextBox)txtMa_ku).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_ku;
		location = new Point(110, 131);
		((Control)asTextBox4).Location = location;
		txtMa_ku.LookupCodeName = "MA_KU";
		((TextBoxBase)txtMa_ku).MaxLength = 20;
		((Control)txtMa_ku).Name = "txtMa_ku";
		txtMa_ku.NameControl = lblTen_ku;
		AsTextBox asTextBox5 = txtMa_ku;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_ku).TabIndex = 4;
		((Control)txtMa_ku).Tag = "@pTk";
		lblTen_ku.ImeMode = (ImeMode)0;
		Label obj14 = lblTen_ku;
		location = new Point(206, 134);
		((Control)obj14).Location = location;
		((Control)lblTen_ku).Name = "lblTen_ku";
		Label obj15 = lblTen_ku;
		size = new Size(324, 13);
		((Control)obj15).Size = size;
		((Control)lblTen_ku).TabIndex = 1028;
		lblTen_ku.TextAlign = (ContentAlignment)16;
		lblMa_ku.AutoSize = true;
		lblMa_ku.ImeMode = (ImeMode)0;
		Label obj16 = lblMa_ku;
		location = new Point(24, 134);
		((Control)obj16).Location = location;
		((Control)lblMa_ku).Name = "lblMa_ku";
		Label obj17 = lblMa_ku;
		size = new Size(64, 13);
		((Control)obj17).Size = size;
		((Control)lblMa_ku).TabIndex = 1027;
		lblMa_ku.Text = "Mã khế ước";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(686, 312);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCARptTMNH03";
		((Form)this).Text = "frmCARptTMNH03";
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
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtTk).Text);
		arrayList.Add(((TextBox)txtMa_ku).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(((TextBox)txtTk).Text, "", false) != 0)
		{
			text = text + lblTk.Text + ": " + ((TextBox)txtTk).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_ku).Text, "", false) != 0)
		{
			text = text + lblMa_ku.Text + ": " + ((TextBox)txtMa_ku).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
		}
		return text;
	}
}
