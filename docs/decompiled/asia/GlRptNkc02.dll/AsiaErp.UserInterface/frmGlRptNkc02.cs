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
public class frmGlRptNkc02 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public frmGlRptNkc02(string menuid)
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
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(564, 205);
		((Control)asTabControl).Size = size;
		TabPage obj = tabFilter;
		size = new Size(556, 176);
		((Control)obj).Size = size;
		Label obj2 = lbl2;
		Point location = new Point(278, 81);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 153);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(297, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 153);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(456, 23);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 6;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(207, 77);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(111, 77);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(25, 81);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(111, 24);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 5;
		((Control)cboMau_bc).TabStop = false;
		Label obj9 = lblMau_bc;
		location = new Point(25, 28);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(111, 104);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 3;
		Label obj10 = lblMauBC;
		location = new Point(156, 103);
		((Control)obj10).Location = location;
		RadioButton obj11 = optVND;
		location = new Point(243, 102);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 4;
		RadioButton obj12 = optNt;
		location = new Point(297, 103);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 5;
		Label obj13 = lblMa_nt;
		location = new Point(25, 106);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(28, 137);
		((Control)obj14).Location = location;
		Label obj15 = lblTieu_de;
		location = new Point(25, 55);
		((Control)obj15).Location = location;
		TextBox obj16 = txtTieu_De;
		location = new Point(111, 51);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 7;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj17 = tabGrid;
		size = new Size(556, 178);
		((Control)obj17).Size = size;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(564, 230);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlRptNkc02";
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
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		return true;
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
	}
}
