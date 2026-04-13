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
public class frmCARptTMNH05 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtMa_ku")]
	private AsTextBox _txtMa_ku;

	[AccessedThroughProperty("lblTen_ku")]
	private Label _lblTen_ku;

	[AccessedThroughProperty("lblMa_ku")]
	private Label _lblMa_ku;

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
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_ku_AfterCodeValidating;
			if (_txtMa_ku != null)
			{
				_txtMa_ku.AfterCodeValidating -= obj;
			}
			_txtMa_ku = value;
			if (_txtMa_ku != null)
			{
				_txtMa_ku.AfterCodeValidating += obj;
			}
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
		txtMa_ku = new AsTextBox();
		lblTen_ku = new Label();
		lblMa_ku = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(614, 260);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_ku);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_ku);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_ku);
		TabPage obj = tabFilter;
		size = new Size(606, 231);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_ku, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_ku, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_ku, 0);
		((Control)lbl2).TabIndex = 20;
		Button obj2 = cmdExcel;
		Point location = new Point(525, 205);
		((Control)obj2).Location = location;
		((Control)cmdExcel).TabIndex = 9;
		((Control)txtNgay2).TabIndex = 5;
		Button obj3 = cmdCancel;
		location = new Point(444, 205);
		((Control)obj3).Location = location;
		((Control)cmdCancel).TabIndex = 18;
		Button obj4 = cmdModifyReport;
		location = new Point(455, 24);
		((Control)obj4).Location = location;
		((Control)cmdModifyReport).TabIndex = 1;
		((Control)txtNgay1).TabIndex = 4;
		((Control)cboKyBc).TabIndex = 3;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 131);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 7;
		Label obj5 = lblMauBC;
		location = new Point(160, 129);
		((Control)obj5).Location = location;
		RadioButton obj6 = optVND;
		location = new Point(239, 129);
		((Control)obj6).Location = location;
		((Control)optVND).TabIndex = 8;
		RadioButton obj7 = optNt;
		location = new Point(296, 129);
		((Control)obj7).Location = location;
		((Control)optNt).TabIndex = 9;
		Label obj8 = lblMa_nt;
		location = new Point(24, 134);
		((Control)obj8).Location = location;
		Button obj9 = cmdOk;
		location = new Point(27, 169);
		((Control)obj9).Location = location;
		((Control)cmdOk).TabIndex = 10;
		Label obj10 = lblTieu_de;
		location = new Point(24, 55);
		((Control)obj10).Location = location;
		((Control)lblTieu_de).TabIndex = 13;
		((Control)txtTieu_De).TabIndex = 2;
		TabPage obj11 = tabGrid;
		size = new Size(606, 231);
		((Control)obj11).Size = size;
		((TextBox)txtMa_ku).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_ku.AutoLookup = true;
		txtMa_ku.AutoValid = true;
		((TextBoxBase)txtMa_ku).BackColor = SystemColors.Info;
		((TextBox)txtMa_ku).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_ku;
		location = new Point(110, 105);
		((Control)asTextBox2).Location = location;
		txtMa_ku.LookupCodeName = "Ma_ku";
		((Control)txtMa_ku).Name = "txtMa_ku";
		txtMa_ku.NameControl = lblTen_ku;
		AsTextBox asTextBox3 = txtMa_ku;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_ku).TabIndex = 6;
		((Control)txtMa_ku).Tag = "@pMa_ku";
		txtMa_ku.UseAutoCompleteSource = true;
		txtMa_ku.ValidReturnFieldList = "TEN_KU,MA_NT";
		lblTen_ku.ImeMode = (ImeMode)0;
		Label obj12 = lblTen_ku;
		location = new Point(206, 108);
		((Control)obj12).Location = location;
		((Control)lblTen_ku).Name = "lblTen_ku";
		Label obj13 = lblTen_ku;
		size = new Size(366, 13);
		((Control)obj13).Size = size;
		((Control)lblTen_ku).TabIndex = 1088;
		lblTen_ku.TextAlign = (ContentAlignment)16;
		lblMa_ku.AutoSize = true;
		lblMa_ku.ImeMode = (ImeMode)0;
		Label obj14 = lblMa_ku;
		location = new Point(24, 110);
		((Control)obj14).Location = location;
		((Control)lblMa_ku).Name = "lblMa_ku";
		Label obj15 = lblMa_ku;
		size = new Size(47, 13);
		((Control)obj15).Size = size;
		((Control)lblMa_ku).TabIndex = 1087;
		lblMa_ku.Text = "Khế ước";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(614, 285);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCARptTMNH05";
		((Form)this).Text = "frmCARptTMNH05";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public frmCARptTMNH05(string Menuid)
		: base(Menuid)
	{
		InitializeComponent();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
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
		if (Operators.CompareString(((TextBox)txtMa_ku).Text, "", false) != 0)
		{
			text = text + lblMa_ku.Text + ": [" + ((TextBox)txtMa_ku).Text + " - " + lblTen_ku.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": [" + ((TextBox)txtMa_Nt).Text + "]; ";
		}
		return text;
	}

	protected override bool ValidData()
	{
		if (Operators.CompareString(((TextBox)txtMa_ku).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtMa_ku, Helper.GetMess(50002).Description);
			((Control)txtMa_ku).Select();
			return false;
		}
		epNotice.SetError((Control)(object)txtMa_ku, "");
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtMa_Nt, Helper.GetMess(50002).Description);
			((Control)txtMa_Nt).Select();
			return false;
		}
		epNotice.SetError((Control)(object)txtMa_Nt, "");
		return base.ValidData();
	}

	private void txtMa_ku_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (Operators.CompareString(((TextBox)txtMa_ku).Text.Trim(), "", false) != 0)
		{
			lblTen_ku.Text = Conversions.ToString(e.ValidatedRow["ten_ku"]);
			((TextBox)txtMa_Nt).Text = Conversions.ToString(e.ValidatedRow["ma_nt"]);
		}
	}
}
