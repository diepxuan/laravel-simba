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
public class frmGlRptNkc04 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblDs_Tk_Dt_Hh")]
	private Label _lblDs_Tk_Dt_Hh;

	[AccessedThroughProperty("lblDs_Tk_Pt")]
	private Label _lblDs_Tk_Pt;

	[AccessedThroughProperty("lblDs_Tk_Dt_Dv")]
	private Label _lblDs_Tk_Dt_Dv;

	[AccessedThroughProperty("lblDs_Tk_Dt_Tp")]
	private Label _lblDs_Tk_Dt_Tp;

	[AccessedThroughProperty("txtDs_Tk_Dt_dv")]
	private AsTextBox _txtDs_Tk_Dt_dv;

	[AccessedThroughProperty("txtDs_Tk_Dt_tp")]
	private AsTextBox _txtDs_Tk_Dt_tp;

	[AccessedThroughProperty("txtDs_Tk_Dt_hh")]
	private AsTextBox _txtDs_Tk_Dt_hh;

	[AccessedThroughProperty("txtDs_Tk_pt")]
	private AsTextBox _txtDs_Tk_pt;

	private virtual Label lblDs_Tk_Dt_Hh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDs_Tk_Dt_Hh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDs_Tk_Dt_Hh = value;
		}
	}

	private virtual Label lblDs_Tk_Pt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDs_Tk_Pt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDs_Tk_Pt = value;
		}
	}

	private virtual Label lblDs_Tk_Dt_Dv
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDs_Tk_Dt_Dv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDs_Tk_Dt_Dv = value;
		}
	}

	private virtual Label lblDs_Tk_Dt_Tp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDs_Tk_Dt_Tp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDs_Tk_Dt_Tp = value;
		}
	}

	internal virtual AsTextBox txtDs_Tk_Dt_dv
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDs_Tk_Dt_dv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDs_Tk_Dt_dv = value;
		}
	}

	internal virtual AsTextBox txtDs_Tk_Dt_tp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDs_Tk_Dt_tp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDs_Tk_Dt_tp = value;
		}
	}

	internal virtual AsTextBox txtDs_Tk_Dt_hh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDs_Tk_Dt_hh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDs_Tk_Dt_hh = value;
		}
	}

	internal virtual AsTextBox txtDs_Tk_pt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDs_Tk_pt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDs_Tk_pt = value;
		}
	}

	public frmGlRptNkc04(string menuid)
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		lblDs_Tk_Dt_Hh = new Label();
		lblDs_Tk_Pt = new Label();
		lblDs_Tk_Dt_Dv = new Label();
		lblDs_Tk_Dt_Tp = new Label();
		txtDs_Tk_pt = new AsTextBox();
		txtDs_Tk_Dt_hh = new AsTextBox();
		txtDs_Tk_Dt_tp = new AsTextBox();
		txtDs_Tk_Dt_dv = new AsTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(572, 312);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)txtDs_Tk_Dt_dv);
		((Control)tabFilter).Controls.Add((Control)(object)txtDs_Tk_Dt_tp);
		((Control)tabFilter).Controls.Add((Control)(object)txtDs_Tk_Dt_hh);
		((Control)tabFilter).Controls.Add((Control)(object)txtDs_Tk_pt);
		((Control)tabFilter).Controls.Add((Control)(object)lblDs_Tk_Dt_Dv);
		((Control)tabFilter).Controls.Add((Control)(object)lblDs_Tk_Dt_Tp);
		((Control)tabFilter).Controls.Add((Control)(object)lblDs_Tk_Dt_Hh);
		((Control)tabFilter).Controls.Add((Control)(object)lblDs_Tk_Pt);
		TabPage obj = tabFilter;
		size = new Size(564, 283);
		((Control)obj).Size = size;
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDs_Tk_Pt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDs_Tk_Dt_Hh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDs_Tk_Dt_Tp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDs_Tk_Dt_Dv, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtDs_Tk_pt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtDs_Tk_Dt_hh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtDs_Tk_Dt_tp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtDs_Tk_Dt_dv, 0);
		Label obj2 = lbl2;
		Point location = new Point(290, 83);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 260);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(309, 79);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 260);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(468, 25);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 9;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(219, 79);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(123, 79);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(22, 83);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(123, 26);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 8;
		((Control)cboMau_bc).TabStop = false;
		Label obj9 = lblMau_bc;
		location = new Point(22, 30);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(123, 210);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 7;
		Label obj10 = lblMauBC;
		location = new Point(168, 209);
		((Control)obj10).Location = location;
		RadioButton obj11 = optVND;
		location = new Point(255, 208);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 8;
		RadioButton obj12 = optNt;
		location = new Point(309, 209);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 9;
		Label obj13 = lblMa_nt;
		location = new Point(22, 212);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(25, 243);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 10;
		Label obj15 = lblTieu_de;
		location = new Point(22, 57);
		((Control)obj15).Location = location;
		TextBox obj16 = txtTieu_De;
		location = new Point(123, 53);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 10;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj17 = tabGrid;
		size = new Size(564, 283);
		((Control)obj17).Size = size;
		lblDs_Tk_Dt_Hh.AutoSize = true;
		lblDs_Tk_Dt_Hh.ImeMode = (ImeMode)0;
		Label obj18 = lblDs_Tk_Dt_Hh;
		location = new Point(22, 110);
		((Control)obj18).Location = location;
		((Control)lblDs_Tk_Dt_Hh).Name = "lblDs_Tk_Dt_Hh";
		Label obj19 = lblDs_Tk_Dt_Hh;
		size = new Size(84, 13);
		((Control)obj19).Size = size;
		((Control)lblDs_Tk_Dt_Hh).TabIndex = 1051;
		lblDs_Tk_Dt_Hh.Text = "TKDT hàng hoá";
		lblDs_Tk_Pt.AutoSize = true;
		lblDs_Tk_Pt.ImeMode = (ImeMode)0;
		Label obj20 = lblDs_Tk_Pt;
		location = new Point(22, 188);
		((Control)obj20).Location = location;
		((Control)lblDs_Tk_Pt).Name = "lblDs_Tk_Pt";
		Label obj21 = lblDs_Tk_Pt;
		size = new Size(62, 13);
		((Control)obj21).Size = size;
		((Control)lblDs_Tk_Pt).TabIndex = 1050;
		lblDs_Tk_Pt.Text = "TK phải thu";
		lblDs_Tk_Dt_Dv.AutoSize = true;
		lblDs_Tk_Dt_Dv.ImeMode = (ImeMode)0;
		Label obj22 = lblDs_Tk_Dt_Dv;
		location = new Point(22, 162);
		((Control)obj22).Location = location;
		((Control)lblDs_Tk_Dt_Dv).Name = "lblDs_Tk_Dt_Dv";
		Label obj23 = lblDs_Tk_Dt_Dv;
		size = new Size(74, 13);
		((Control)obj23).Size = size;
		((Control)lblDs_Tk_Dt_Dv).TabIndex = 1055;
		lblDs_Tk_Dt_Dv.Text = "TKDT dịch vụ";
		lblDs_Tk_Dt_Tp.AutoSize = true;
		lblDs_Tk_Dt_Tp.ImeMode = (ImeMode)0;
		Label obj24 = lblDs_Tk_Dt_Tp;
		location = new Point(22, 136);
		((Control)obj24).Location = location;
		((Control)lblDs_Tk_Dt_Tp).Name = "lblDs_Tk_Dt_Tp";
		Label obj25 = lblDs_Tk_Dt_Tp;
		size = new Size(95, 13);
		((Control)obj25).Size = size;
		((Control)lblDs_Tk_Dt_Tp).TabIndex = 1054;
		lblDs_Tk_Dt_Tp.Text = "TKDT thành phẩm";
		txtDs_Tk_pt.AutoLookup = true;
		txtDs_Tk_pt.AutoValid = false;
		((TextBoxBase)txtDs_Tk_pt).BackColor = SystemColors.Window;
		((TextBox)txtDs_Tk_pt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtDs_Tk_pt;
		location = new Point(123, 184);
		((Control)asTextBox2).Location = location;
		txtDs_Tk_pt.LookupCodeName = "TK";
		((Control)txtDs_Tk_pt).Name = "txtDs_Tk_pt";
		txtDs_Tk_pt.NameControl = null;
		AsTextBox asTextBox3 = txtDs_Tk_pt;
		size = new Size(163, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtDs_Tk_pt).TabIndex = 6;
		((Control)txtDs_Tk_pt).Tag = "@pTK";
		txtDs_Tk_Dt_hh.AutoLookup = true;
		txtDs_Tk_Dt_hh.AutoValid = false;
		((TextBoxBase)txtDs_Tk_Dt_hh).BackColor = SystemColors.Window;
		((TextBox)txtDs_Tk_Dt_hh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtDs_Tk_Dt_hh;
		location = new Point(123, 106);
		((Control)asTextBox4).Location = location;
		txtDs_Tk_Dt_hh.LookupCodeName = "TK";
		((Control)txtDs_Tk_Dt_hh).Name = "txtDs_Tk_Dt_hh";
		txtDs_Tk_Dt_hh.NameControl = null;
		AsTextBox asTextBox5 = txtDs_Tk_Dt_hh;
		size = new Size(163, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtDs_Tk_Dt_hh).TabIndex = 3;
		((Control)txtDs_Tk_Dt_hh).Tag = "@pTK";
		txtDs_Tk_Dt_tp.AutoLookup = true;
		txtDs_Tk_Dt_tp.AutoValid = false;
		((TextBoxBase)txtDs_Tk_Dt_tp).BackColor = SystemColors.Window;
		((TextBox)txtDs_Tk_Dt_tp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtDs_Tk_Dt_tp;
		location = new Point(123, 132);
		((Control)asTextBox6).Location = location;
		txtDs_Tk_Dt_tp.LookupCodeName = "TK";
		((Control)txtDs_Tk_Dt_tp).Name = "txtDs_Tk_Dt_tp";
		txtDs_Tk_Dt_tp.NameControl = null;
		AsTextBox asTextBox7 = txtDs_Tk_Dt_tp;
		size = new Size(163, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtDs_Tk_Dt_tp).TabIndex = 4;
		((Control)txtDs_Tk_Dt_tp).Tag = "@pTK";
		txtDs_Tk_Dt_dv.AutoLookup = true;
		txtDs_Tk_Dt_dv.AutoValid = false;
		((TextBoxBase)txtDs_Tk_Dt_dv).BackColor = SystemColors.Window;
		((TextBox)txtDs_Tk_Dt_dv).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtDs_Tk_Dt_dv;
		location = new Point(123, 158);
		((Control)asTextBox8).Location = location;
		txtDs_Tk_Dt_dv.LookupCodeName = "TK";
		((Control)txtDs_Tk_Dt_dv).Name = "txtDs_Tk_Dt_dv";
		txtDs_Tk_Dt_dv.NameControl = null;
		AsTextBox asTextBox9 = txtDs_Tk_Dt_dv;
		size = new Size(163, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtDs_Tk_Dt_dv).TabIndex = 5;
		((Control)txtDs_Tk_Dt_dv).Tag = "@pTK";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(572, 337);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlRptNkc04";
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
		((TextBox)txtDs_Tk_pt).Text = base.MyMenuInfo.par2;
		((TextBox)txtDs_Tk_Dt_hh).Text = base.MyMenuInfo.par3;
		((TextBox)txtDs_Tk_Dt_tp).Text = base.MyMenuInfo.par4;
		((TextBox)txtDs_Tk_Dt_dv).Text = base.MyMenuInfo.par5;
	}

	protected override bool ValidData()
	{
		return (Commons.ChkEmtyTextBoxAndShowMessageBox((TextBox)(object)txtDs_Tk_Dt_dv) && Commons.ChkEmtyTextBoxAndShowMessageBox((TextBox)(object)txtDs_Tk_Dt_hh) && Commons.ChkEmtyTextBoxAndShowMessageBox((TextBox)(object)txtDs_Tk_Dt_tp) && Commons.ChkEmtyTextBoxAndShowMessageBox((TextBox)(object)txtDs_Tk_pt) && base.ValidData()) ? true : false;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtDs_Tk_pt).Text);
		arrayList.Add(((TextBox)txtDs_Tk_Dt_hh).Text);
		arrayList.Add(((TextBox)txtDs_Tk_Dt_tp).Text);
		arrayList.Add(((TextBox)txtDs_Tk_Dt_dv).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		return true;
	}
}
