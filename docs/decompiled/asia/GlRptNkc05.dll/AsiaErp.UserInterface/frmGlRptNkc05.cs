using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGlRptNkc05 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("lblDs_Tk_hh")]
	private Label _lblDs_Tk_hh;

	[AccessedThroughProperty("lblDs_Tk_Pt")]
	private Label _lblDs_Tk_Pt;

	[AccessedThroughProperty("lblDs_Tk_khac")]
	private Label _lblDs_Tk_khac;

	[AccessedThroughProperty("lblDs_Tk_nvl")]
	private Label _lblDs_Tk_nvl;

	[AccessedThroughProperty("txtDs_Tk_khac")]
	private AsTextBox _txtDs_Tk_khac;

	[AccessedThroughProperty("txtDs_Tk_nvl")]
	private AsTextBox _txtDs_Tk_nvl;

	[AccessedThroughProperty("txtDs_Tk_hh")]
	private AsTextBox _txtDs_Tk_hh;

	[AccessedThroughProperty("txtDs_Tk_pt")]
	private AsTextBox _txtDs_Tk_pt;

	private virtual Label lblDs_Tk_hh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDs_Tk_hh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDs_Tk_hh = value;
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

	private virtual Label lblDs_Tk_khac
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDs_Tk_khac;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDs_Tk_khac = value;
		}
	}

	private virtual Label lblDs_Tk_nvl
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDs_Tk_nvl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lblDs_Tk_nvl_Click;
			if (_lblDs_Tk_nvl != null)
			{
				((Control)_lblDs_Tk_nvl).Click -= eventHandler;
			}
			_lblDs_Tk_nvl = value;
			if (_lblDs_Tk_nvl != null)
			{
				((Control)_lblDs_Tk_nvl).Click += eventHandler;
			}
		}
	}

	internal virtual AsTextBox txtDs_Tk_khac
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDs_Tk_khac;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDs_Tk_khac = value;
		}
	}

	internal virtual AsTextBox txtDs_Tk_nvl
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDs_Tk_nvl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDs_Tk_nvl = value;
		}
	}

	internal virtual AsTextBox txtDs_Tk_hh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDs_Tk_hh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDs_Tk_hh = value;
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

	public frmGlRptNkc05(string menuid)
		: base(menuid)
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		lblDs_Tk_hh = new Label();
		lblDs_Tk_Pt = new Label();
		lblDs_Tk_khac = new Label();
		lblDs_Tk_nvl = new Label();
		txtDs_Tk_pt = new AsTextBox();
		txtDs_Tk_hh = new AsTextBox();
		txtDs_Tk_khac = new AsTextBox();
		txtDs_Tk_nvl = new AsTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(564, 309);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)txtDs_Tk_khac);
		((Control)tabFilter).Controls.Add((Control)(object)txtDs_Tk_nvl);
		((Control)tabFilter).Controls.Add((Control)(object)txtDs_Tk_hh);
		((Control)tabFilter).Controls.Add((Control)(object)txtDs_Tk_pt);
		((Control)tabFilter).Controls.Add((Control)(object)lblDs_Tk_khac);
		((Control)tabFilter).Controls.Add((Control)(object)lblDs_Tk_nvl);
		((Control)tabFilter).Controls.Add((Control)(object)lblDs_Tk_hh);
		((Control)tabFilter).Controls.Add((Control)(object)lblDs_Tk_Pt);
		TabPage obj = tabFilter;
		size = new Size(556, 280);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDs_Tk_hh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDs_Tk_nvl, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDs_Tk_khac, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtDs_Tk_pt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtDs_Tk_hh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtDs_Tk_nvl, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtDs_Tk_khac, 0);
		Label obj2 = lbl2;
		Point location = new Point(280, 82);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 5;
		Button obj3 = cmdExcel;
		location = new Point(700, 241);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(299, 78);
		((Control)asMaskedTextBox).Location = location;
		Button obj4 = cmdCancel;
		location = new Point(619, 241);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(458, 24);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 1;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(209, 78);
		((Control)asMaskedTextBox2).Location = location;
		ComboBox obj6 = cboKyBc;
		location = new Point(113, 78);
		((Control)obj6).Location = location;
		Label obj7 = lblKyBc;
		location = new Point(23, 82);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(113, 25);
		((Control)obj8).Location = location;
		Label obj9 = lblMau_bc;
		location = new Point(23, 29);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(113, 209);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 9;
		Label obj10 = lblMauBC;
		location = new Point(158, 208);
		((Control)obj10).Location = location;
		RadioButton obj11 = optVND;
		location = new Point(245, 207);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 10;
		RadioButton obj12 = optNt;
		location = new Point(299, 208);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 11;
		Label obj13 = lblMa_nt;
		location = new Point(23, 211);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(26, 241);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 12;
		Label obj15 = lblTieu_de;
		location = new Point(23, 56);
		((Control)obj15).Location = location;
		TextBox obj16 = txtTieu_De;
		location = new Point(113, 52);
		((Control)obj16).Location = location;
		TabPage obj17 = tabGrid;
		size = new Size(556, 280);
		((Control)obj17).Size = size;
		lblDs_Tk_hh.AutoSize = true;
		lblDs_Tk_hh.ImeMode = (ImeMode)0;
		Label obj18 = lblDs_Tk_hh;
		location = new Point(23, 110);
		((Control)obj18).Location = location;
		((Control)lblDs_Tk_hh).Name = "lblDs_Tk_hh";
		Label obj19 = lblDs_Tk_hh;
		size = new Size(69, 13);
		((Control)obj19).Size = size;
		((Control)lblDs_Tk_hh).TabIndex = 1051;
		lblDs_Tk_hh.Text = "TK hàng hoá";
		lblDs_Tk_Pt.AutoSize = true;
		lblDs_Tk_Pt.ImeMode = (ImeMode)0;
		Label obj20 = lblDs_Tk_Pt;
		location = new Point(23, 188);
		((Control)obj20).Location = location;
		((Control)lblDs_Tk_Pt).Name = "lblDs_Tk_Pt";
		Label obj21 = lblDs_Tk_Pt;
		size = new Size(59, 13);
		((Control)obj21).Size = size;
		((Control)lblDs_Tk_Pt).TabIndex = 1050;
		lblDs_Tk_Pt.Text = "TK phải trả";
		lblDs_Tk_khac.AutoSize = true;
		lblDs_Tk_khac.ImeMode = (ImeMode)0;
		Label obj22 = lblDs_Tk_khac;
		location = new Point(23, 162);
		((Control)obj22).Location = location;
		((Control)lblDs_Tk_khac).Name = "lblDs_Tk_khac";
		Label obj23 = lblDs_Tk_khac;
		size = new Size(69, 13);
		((Control)obj23).Size = size;
		((Control)lblDs_Tk_khac).TabIndex = 1055;
		lblDs_Tk_khac.Text = "TK kho khác";
		lblDs_Tk_nvl.AutoSize = true;
		lblDs_Tk_nvl.ImeMode = (ImeMode)0;
		Label obj24 = lblDs_Tk_nvl;
		location = new Point(23, 136);
		((Control)obj24).Location = location;
		((Control)lblDs_Tk_nvl).Name = "lblDs_Tk_nvl";
		Label obj25 = lblDs_Tk_nvl;
		size = new Size(45, 13);
		((Control)obj25).Size = size;
		((Control)lblDs_Tk_nvl).TabIndex = 1054;
		lblDs_Tk_nvl.Text = "TK NVL";
		txtDs_Tk_pt.AutoLookup = true;
		txtDs_Tk_pt.AutoValid = false;
		((TextBoxBase)txtDs_Tk_pt).BackColor = SystemColors.Window;
		((TextBox)txtDs_Tk_pt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtDs_Tk_pt;
		location = new Point(113, 183);
		((Control)asTextBox2).Location = location;
		txtDs_Tk_pt.LookupCodeName = "TK";
		((Control)txtDs_Tk_pt).Name = "txtDs_Tk_pt";
		txtDs_Tk_pt.NameControl = null;
		AsTextBox asTextBox3 = txtDs_Tk_pt;
		size = new Size(163, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtDs_Tk_pt).TabIndex = 8;
		((Control)txtDs_Tk_pt).Tag = "@pTK";
		txtDs_Tk_pt.UseAutoCompleteSource = true;
		txtDs_Tk_hh.AutoLookup = true;
		txtDs_Tk_hh.AutoValid = false;
		((TextBoxBase)txtDs_Tk_hh).BackColor = SystemColors.Window;
		((TextBox)txtDs_Tk_hh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtDs_Tk_hh;
		location = new Point(113, 105);
		((Control)asTextBox4).Location = location;
		txtDs_Tk_hh.LookupCodeName = "TK";
		((Control)txtDs_Tk_hh).Name = "txtDs_Tk_hh";
		txtDs_Tk_hh.NameControl = null;
		AsTextBox asTextBox5 = txtDs_Tk_hh;
		size = new Size(163, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtDs_Tk_hh).TabIndex = 5;
		((Control)txtDs_Tk_hh).Tag = "@pTK";
		txtDs_Tk_hh.UseAutoCompleteSource = true;
		txtDs_Tk_khac.AutoLookup = true;
		txtDs_Tk_khac.AutoValid = false;
		((TextBoxBase)txtDs_Tk_khac).BackColor = SystemColors.Window;
		((TextBox)txtDs_Tk_khac).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtDs_Tk_khac;
		location = new Point(113, 157);
		((Control)asTextBox6).Location = location;
		txtDs_Tk_khac.LookupCodeName = "TK";
		((Control)txtDs_Tk_khac).Name = "txtDs_Tk_khac";
		txtDs_Tk_khac.NameControl = null;
		AsTextBox asTextBox7 = txtDs_Tk_khac;
		size = new Size(163, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtDs_Tk_khac).TabIndex = 7;
		((Control)txtDs_Tk_khac).Tag = "@pTK";
		txtDs_Tk_khac.UseAutoCompleteSource = true;
		txtDs_Tk_nvl.AutoLookup = true;
		txtDs_Tk_nvl.AutoValid = false;
		((TextBoxBase)txtDs_Tk_nvl).BackColor = SystemColors.Window;
		((TextBox)txtDs_Tk_nvl).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtDs_Tk_nvl;
		location = new Point(113, 131);
		((Control)asTextBox8).Location = location;
		txtDs_Tk_nvl.LookupCodeName = "TK";
		((Control)txtDs_Tk_nvl).Name = "txtDs_Tk_nvl";
		txtDs_Tk_nvl.NameControl = null;
		AsTextBox asTextBox9 = txtDs_Tk_nvl;
		size = new Size(163, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtDs_Tk_nvl).TabIndex = 6;
		((Control)txtDs_Tk_nvl).Tag = "@pTK";
		txtDs_Tk_nvl.UseAutoCompleteSource = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(564, 334);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlRptNkc05";
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
		((TextBox)txtDs_Tk_hh).Text = base.MyMenuInfo.par3;
		((TextBox)txtDs_Tk_nvl).Text = base.MyMenuInfo.par4;
		((TextBox)txtDs_Tk_khac).Text = base.MyMenuInfo.par5;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtDs_Tk_pt).Text);
		arrayList.Add(((TextBox)txtDs_Tk_hh).Text);
		arrayList.Add(((TextBox)txtDs_Tk_nvl).Text);
		arrayList.Add(((TextBox)txtDs_Tk_khac).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		return true;
	}

	private void lblDs_Tk_nvl_Click(object sender, EventArgs e)
	{
	}
}
