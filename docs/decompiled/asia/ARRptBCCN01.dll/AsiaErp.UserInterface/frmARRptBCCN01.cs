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
public class frmARRptBCCN01 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblMa_tk")]
	private Label _lblMa_tk;

	internal virtual Label lblTen_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Kh = value;
		}
	}

	internal virtual AsTextBox txtMa_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Kh = value;
		}
	}

	internal virtual Label lblMa_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Kh = value;
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

	internal virtual Label lblMa_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_tk = value;
		}
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

	public frmARRptBCCN01(string MenuId)
		: base(MenuId)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
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
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblTen_Tk = new Label();
		txtTk = new AsTextBox();
		lblMa_tk = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(759, 402);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Kh);
		TabPage obj = tabFilter;
		size = new Size(751, 373);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		Label obj2 = lbl2;
		Point location = new Point(277, 81);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 2;
		Button obj3 = cmdExcel;
		location = new Point(700, 333);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(296, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 333);
		((Control)obj4).Location = location;
		((Control)cmdModifyReport).TabIndex = 10;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(206, 77);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj5 = cboKyBc;
		location = new Point(110, 77);
		((Control)obj5).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj6 = lblKyBc;
		location = new Point(24, 81);
		((Control)obj6).Location = location;
		ComboBox obj7 = cboMau_bc;
		location = new Point(110, 24);
		((Control)obj7).Location = location;
		((Control)cboMau_bc).TabIndex = 9;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 156);
		((Control)asTextBox).Location = location;
		Label obj8 = lblMauBC;
		location = new Point(155, 155);
		((Control)obj8).Location = location;
		RadioButton obj9 = optVND;
		location = new Point(242, 154);
		((Control)obj9).Location = location;
		((Control)optVND).TabIndex = 6;
		RadioButton obj10 = optNt;
		location = new Point(296, 155);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 7;
		Label obj11 = lblMa_nt;
		location = new Point(24, 158);
		((Control)obj11).Location = location;
		Button obj12 = cmdOk;
		location = new Point(27, 189);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 8;
		Label obj13 = lblTieu_de;
		location = new Point(24, 55);
		((Control)obj13).Location = location;
		TextBox obj14 = txtTieu_De;
		location = new Point(110, 51);
		((Control)obj14).Location = location;
		((Control)txtTieu_De).TabIndex = 11;
		TabPage obj15 = tabGrid;
		size = new Size(556, 228);
		((Control)obj15).Size = size;
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj16 = lblTen_Kh;
		location = new Point(206, 134);
		((Control)obj16).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj17 = lblTen_Kh;
		size = new Size(344, 13);
		((Control)obj17).Size = size;
		((Control)lblTen_Kh).TabIndex = 1036;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_Kh;
		location = new Point(110, 130);
		((Control)asTextBox2).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		txtMa_Kh.LookupWhereCondition = "  1=1 ";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		AsTextBox asTextBox3 = txtMa_Kh;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_Kh).TabIndex = 4;
		txtMa_Kh.UseAutoCompleteSource = true;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj18 = lblMa_Kh;
		location = new Point(24, 134);
		((Control)obj18).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj19 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_Kh).TabIndex = 1035;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj20 = lblTen_Tk;
		location = new Point(206, 108);
		((Control)obj20).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj21 = lblTen_Tk;
		size = new Size(344, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_Tk).TabIndex = 1099;
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = true;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtTk;
		location = new Point(110, 104);
		((Control)asTextBox4).Location = location;
		txtTk.LookupCodeName = "TK";
		txtTk.LookupWhereCondition = "tk_cn=1";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk;
		txtTk.SD = true;
		AsTextBox asTextBox5 = txtTk;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtTk).TabIndex = 3;
		txtTk.UseAutoCompleteSource = true;
		lblMa_tk.AutoSize = true;
		lblMa_tk.ImeMode = (ImeMode)0;
		Label obj22 = lblMa_tk;
		location = new Point(24, 108);
		((Control)obj22).Location = location;
		((Control)lblMa_tk).Name = "lblMa_tk";
		Label obj23 = lblMa_tk;
		size = new Size(55, 13);
		((Control)obj23).Size = size;
		((Control)lblMa_tk).TabIndex = 1098;
		lblMa_tk.Text = "Tài khoản";
		lblMa_tk.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(759, 427);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmARRptBCCN01";
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
		arrayList.Add(((TextBox)txtMa_Kh).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		base.MyFomularFields.Add("ma_kh", ((TextBox)txtMa_Kh).Text);
		base.MyFomularFields.Add("ten_kh", lblTen_Kh.Text);
		base.MyFomularFields.Add("tk", ((TextBox)txtTk).Text);
		base.MyFomularFields.Add("ten_tk", lblTen_Tk.Text);
		return true;
	}

	private string GetFilterTitle()
	{
		return "";
	}

	protected override bool ValidData()
	{
		((TextBox)txtTk).Text = ((TextBox)txtTk).Text.Trim();
		((TextBox)txtMa_Kh).Text = ((TextBox)txtMa_Kh).Text.Trim();
		return (byte)((uint)((ChkEmtyTextBox((TextBox)(object)txtTk) && ChkEmtyTextBox((TextBox)(object)txtMa_Kh)) ? 1 : 0) & (((Form)this).ValidateChildren() ? 1u : 0u)) != 0;
	}
}
