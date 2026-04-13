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
public class frmGlRptNkc01 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	private string Ten_tk;

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

	public frmGlRptNkc01(string menuid)
		: base(menuid)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		Ten_tk = "";
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
		txtTk = new AsTextBox();
		lblTen_Tk = new Label();
		lblTk = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(564, 233);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		TabPage obj = tabFilter;
		Point location = new Point(4, 22);
		obj.Location = location;
		TabPage obj2 = tabFilter;
		size = new Size(556, 207);
		((Control)obj2).Size = size;
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
		Button obj3 = cmdExcel;
		location = new Point(700, 181);
		((Control)obj3).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 181);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(455, 24);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 7;
		((Control)txtNgay1).TabIndex = 1;
		((Control)cboKyBc).TabIndex = 0;
		myHelpProvider.SetHelpKeyword((Control)(object)cboMau_bc, "");
		myHelpProvider.SetHelpString((Control)(object)cboMau_bc, "");
		myHelpProvider.SetShowHelp((Control)(object)cboMau_bc, false);
		((Control)cboMau_bc).TabIndex = 6;
		((Control)cboMau_bc).TabStop = false;
		Label obj6 = lblMau_bc;
		location = new Point(24, 29);
		((Control)obj6).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 131);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 4;
		Label obj7 = lblMauBC;
		location = new Point(155, 130);
		((Control)obj7).Location = location;
		RadioButton obj8 = optVND;
		location = new Point(242, 129);
		((Control)obj8).Location = location;
		((Control)optVND).TabIndex = 5;
		RadioButton obj9 = optNt;
		location = new Point(296, 130);
		((Control)obj9).Location = location;
		((Control)optNt).TabIndex = 6;
		Label obj10 = lblMa_nt;
		location = new Point(24, 133);
		((Control)obj10).Location = location;
		myHelpProvider.SetHelpKeyword((Control)(object)cmdOk, "");
		myHelpProvider.SetHelpString((Control)(object)cmdOk, "");
		Button obj11 = cmdOk;
		location = new Point(27, 164);
		((Control)obj11).Location = location;
		myHelpProvider.SetShowHelp((Control)(object)cmdOk, false);
		((Control)cmdOk).TabIndex = 7;
		((Control)txtTieu_De).TabIndex = 8;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj12 = tabGrid;
		location = new Point(4, 22);
		obj12.Location = location;
		TabPage obj13 = tabGrid;
		size = new Size(556, 207);
		((Control)obj13).Size = size;
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = true;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		myHelpProvider.SetHelpKeyword((Control)(object)txtTk, "Tài khoản lên báo cáo");
		myHelpProvider.SetHelpString((Control)(object)txtTk, "Tài khoản lên báo cáo");
		AsTextBox asTextBox2 = txtTk;
		location = new Point(110, 105);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk;
		myHelpProvider.SetShowHelp((Control)(object)txtTk, true);
		AsTextBox asTextBox3 = txtTk;
		size = new Size(82, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 3;
		((Control)txtTk).Tag = "@pTk";
		txtTk.UseAutoCompleteSource = true;
		txtTk.ValidReturnFieldList = "TEN_TK";
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj14 = lblTen_Tk;
		location = new Point(198, 109);
		((Control)obj14).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj15 = lblTen_Tk;
		size = new Size(328, 13);
		((Control)obj15).Size = size;
		((Control)lblTen_Tk).TabIndex = 1017;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj16 = lblTk;
		location = new Point(24, 109);
		((Control)obj16).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj17 = lblTk;
		size = new Size(55, 13);
		((Control)obj17).Size = size;
		((Control)lblTk).TabIndex = 1016;
		lblTk.Text = "Tài khoản";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(564, 258);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlRptNkc01";
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
		arrayList.Add(((TextBox)txtTk).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("TK", ((TextBox)txtTk).Text);
		base.MyFomularFields.Add("TEN_TK", lblTen_Tk.Text);
		base.MyFomularFields.Add("Du_Co_Cky", string.Format(AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format, RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[2]["ps_co"])));
		base.MyFomularFields.Add("Du_No_Cky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[2]["ps_no"]));
		base.MyFomularFields.Add("Du_Co_Dky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[0]["ps_co"]));
		base.MyFomularFields.Add("Du_No_Dky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[0]["ps_no"]));
		return true;
	}

	protected override bool ValidData()
	{
		return (base.ValidData() && ChkEmtyTextBox((TextBox)(object)txtTk)) ? true : false;
	}
}
