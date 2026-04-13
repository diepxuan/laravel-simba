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
public class frmCARptTMNH07 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtMa_ku")]
	private AsTextBox _txtMa_ku;

	[AccessedThroughProperty("lblTen_ku")]
	private Label _lblTen_ku;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

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

	private virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

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

	public frmCARptTMNH07(string menuid)
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
		Label2 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(564, 370);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_ku);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_ku);
		((Control)tabFilter).Controls.Add((Control)(object)Label2);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		TabPage obj = tabFilter;
		size = new Size(556, 341);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_ku, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_ku, 0);
		Label obj2 = lbl2;
		Point location = new Point(278, 81);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 284);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(297, 77);
		((Control)asMaskedTextBox).Location = location;
		Button obj4 = cmdCancel;
		location = new Point(619, 284);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(456, 23);
		((Control)obj5).Location = location;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(207, 77);
		((Control)asMaskedTextBox2).Location = location;
		ComboBox obj6 = cboKyBc;
		location = new Point(111, 77);
		((Control)obj6).Location = location;
		Label obj7 = lblKyBc;
		location = new Point(25, 81);
		((Control)obj7).Location = location;
		myHelpProvider.SetHelpKeyword((Control)(object)cboMau_bc, "");
		myHelpProvider.SetHelpString((Control)(object)cboMau_bc, "");
		ComboBox obj8 = cboMau_bc;
		location = new Point(111, 24);
		((Control)obj8).Location = location;
		myHelpProvider.SetShowHelp((Control)(object)cboMau_bc, false);
		Label obj9 = lblMau_bc;
		location = new Point(25, 28);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(111, 156);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 7;
		Label obj10 = lblMauBC;
		location = new Point(156, 155);
		((Control)obj10).Location = location;
		RadioButton obj11 = optVND;
		location = new Point(243, 154);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 8;
		RadioButton obj12 = optNt;
		location = new Point(297, 155);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 9;
		Label obj13 = lblMa_nt;
		location = new Point(25, 158);
		((Control)obj13).Location = location;
		myHelpProvider.SetHelpKeyword((Control)(object)cmdOk, "");
		myHelpProvider.SetHelpString((Control)(object)cmdOk, "");
		Button obj14 = cmdOk;
		location = new Point(28, 191);
		((Control)obj14).Location = location;
		myHelpProvider.SetShowHelp((Control)(object)cmdOk, false);
		((Control)cmdOk).TabIndex = 10;
		Label obj15 = lblTieu_de;
		location = new Point(25, 55);
		((Control)obj15).Location = location;
		TextBox obj16 = txtTieu_De;
		location = new Point(111, 51);
		((Control)obj16).Location = location;
		TabPage obj17 = tabGrid;
		size = new Size(556, 341);
		((Control)obj17).Size = size;
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = true;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTk;
		location = new Point(111, 104);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk;
		AsTextBox asTextBox3 = txtTk;
		size = new Size(82, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 5;
		((Control)txtTk).Tag = "@pTk";
		txtTk.UseAutoCompleteSource = true;
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj18 = lblTen_Tk;
		location = new Point(199, 108);
		((Control)obj18).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj19 = lblTen_Tk;
		size = new Size(328, 13);
		((Control)obj19).Size = size;
		((Control)lblTen_Tk).TabIndex = 1020;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj20 = lblTk;
		location = new Point(25, 108);
		((Control)obj20).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj21 = lblTk;
		size = new Size(55, 13);
		((Control)obj21).Size = size;
		((Control)lblTk).TabIndex = 1019;
		lblTk.Text = "Tài khoản";
		((TextBox)txtMa_ku).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_ku.AutoLookup = true;
		txtMa_ku.AutoValid = false;
		((TextBoxBase)txtMa_ku).BackColor = SystemColors.Info;
		((TextBox)txtMa_ku).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_ku;
		location = new Point(111, 130);
		((Control)asTextBox4).Location = location;
		txtMa_ku.LookupCodeName = "MA_KU";
		((Control)txtMa_ku).Name = "txtMa_ku";
		txtMa_ku.NameControl = lblTen_ku;
		AsTextBox asTextBox5 = txtMa_ku;
		size = new Size(82, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_ku).TabIndex = 6;
		((Control)txtMa_ku).Tag = "@pMA_KU";
		txtMa_ku.UseAutoCompleteSource = true;
		lblTen_ku.ImeMode = (ImeMode)0;
		Label obj22 = lblTen_ku;
		location = new Point(199, 133);
		((Control)obj22).Location = location;
		((Control)lblTen_ku).Name = "lblTen_ku";
		Label obj23 = lblTen_ku;
		size = new Size(328, 13);
		((Control)obj23).Size = size;
		((Control)lblTen_ku).TabIndex = 1023;
		lblTen_ku.TextAlign = (ContentAlignment)16;
		Label2.AutoSize = true;
		Label2.ImeMode = (ImeMode)0;
		Label label = Label2;
		location = new Point(25, 133);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(64, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 1022;
		Label2.Text = "Mã khế ước";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(564, 395);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCARptTMNH07";
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
		arrayList.Add(((TextBox)txtTk).Text);
		arrayList.Add(((TextBox)txtMa_ku).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		return true;
	}

	protected override bool ValidData()
	{
		if (Operators.CompareString(((TextBox)txtTk).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtTk, Helper.GetMess(50002).Description);
			return false;
		}
		epNotice.SetError((Control)(object)txtTk, "");
		return base.ValidData();
	}
}
