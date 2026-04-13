using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSICheckHT2TKTH : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtTK")]
	private AsTextBox _txtTK;

	[AccessedThroughProperty("lblTK")]
	private Label _lblTK;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("lblTK_du")]
	private Label _lblTK_du;

	[AccessedThroughProperty("lblTen_tkdu")]
	private Label _lblTen_tkdu;

	[AccessedThroughProperty("txtTk_du")]
	private AsTextBox _txtTk_du;

	internal virtual AsTextBox txtTK
	{
		get
		{
			return _txtTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTK = value;
		}
	}

	internal virtual Label lblTK
	{
		get
		{
			return _lblTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTK = value;
		}
	}

	internal virtual Label lblTen_tk
	{
		get
		{
			return _lblTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_tk = value;
		}
	}

	internal virtual Label lblTK_du
	{
		get
		{
			return _lblTK_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTK_du = value;
		}
	}

	internal virtual Label lblTen_tkdu
	{
		get
		{
			return _lblTen_tkdu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_tkdu = value;
		}
	}

	internal virtual AsTextBox txtTk_du
	{
		get
		{
			return _txtTk_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTk_du = value;
		}
	}

	public frmSICheckHT2TKTH(string MenuID)
		: base(MenuID)
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		lblTK = new Label();
		txtTK = new AsTextBox();
		lblTen_tk = new Label();
		lblTen_tkdu = new Label();
		lblTK_du = new Label();
		txtTk_du = new AsTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(688, 261);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)lblTK);
		((Control)tabFilter).Controls.Add((Control)(object)lblTK_du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tkdu);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk_du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tk);
		((Control)tabFilter).Controls.Add((Control)(object)txtTK);
		TabPage obj = tabFilter;
		size = new Size(680, 232);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk_du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tkdu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK_du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		Label obj2 = lbl2;
		Point location = new Point(293, 81);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(594, 203);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 7;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(312, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(513, 203);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 6;
		Button obj5 = cmdModifyReport;
		location = new Point(471, 23);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 9;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(222, 77);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(126, 77);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(24, 81);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(126, 24);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 8;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(248, 411);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).Visible = false;
		Label obj9 = lblMauBC;
		location = new Point(293, 410);
		((Control)obj9).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj10 = optVND;
		location = new Point(380, 409);
		((Control)obj10).Location = location;
		((Control)optVND).Visible = false;
		RadioButton obj11 = optNt;
		location = new Point(434, 410);
		((Control)obj11).Location = location;
		((Control)optNt).Visible = false;
		Label obj12 = lblMa_nt;
		location = new Point(162, 413);
		((Control)obj12).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj13 = cmdOk;
		location = new Point(24, 203);
		((Control)obj13).Location = location;
		((Control)cmdOk).TabIndex = 5;
		Label obj14 = lblTieu_de;
		location = new Point(24, 55);
		((Control)obj14).Location = location;
		TextBox obj15 = txtTieu_De;
		location = new Point(126, 51);
		((Control)obj15).Location = location;
		((Control)txtTieu_De).TabIndex = 10;
		TabPage obj16 = tabGrid;
		size = new Size(680, 232);
		((Control)obj16).Size = size;
		lblTK.AutoSize = true;
		Label obj17 = lblTK;
		location = new Point(24, 108);
		((Control)obj17).Location = location;
		((Control)lblTK).Name = "lblTK";
		Label obj18 = lblTK;
		size = new Size(55, 13);
		((Control)obj18).Size = size;
		((Control)lblTK).TabIndex = 1016;
		lblTK.Text = "Tài khoản";
		txtTK.AutoLookup = true;
		txtTK.AutoValid = false;
		((TextBoxBase)txtTK).BackColor = SystemColors.Info;
		((TextBox)txtTK).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTK;
		location = new Point(126, 104);
		((Control)asTextBox2).Location = location;
		txtTK.LookupCodeName = "TK";
		((Control)txtTK).Name = "txtTK";
		txtTK.NameControl = lblTen_tk;
		AsTextBox asTextBox3 = txtTK;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTK).TabIndex = 3;
		Label obj19 = lblTen_tk;
		location = new Point(222, 108);
		((Control)obj19).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj20 = lblTen_tk;
		size = new Size(324, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_tk).TabIndex = 1016;
		Label obj21 = lblTen_tkdu;
		location = new Point(222, 134);
		((Control)obj21).Location = location;
		((Control)lblTen_tkdu).Name = "lblTen_tkdu";
		Label obj22 = lblTen_tkdu;
		size = new Size(324, 13);
		((Control)obj22).Size = size;
		((Control)lblTen_tkdu).TabIndex = 1016;
		lblTK_du.AutoSize = true;
		Label obj23 = lblTK_du;
		location = new Point(24, 134);
		((Control)obj23).Location = location;
		((Control)lblTK_du).Name = "lblTK_du";
		Label obj24 = lblTK_du;
		size = new Size(94, 13);
		((Control)obj24).Size = size;
		((Control)lblTK_du).TabIndex = 1016;
		lblTK_du.Text = "Tài khoản đối ứng";
		txtTk_du.AutoLookup = true;
		txtTk_du.AutoValid = false;
		((TextBoxBase)txtTk_du).BackColor = SystemColors.Info;
		((TextBox)txtTk_du).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtTk_du;
		location = new Point(126, 130);
		((Control)asTextBox4).Location = location;
		txtTk_du.LookupCodeName = "TK";
		((Control)txtTk_du).Name = "txtTk_du";
		txtTk_du.NameControl = lblTen_tkdu;
		AsTextBox asTextBox5 = txtTk_du;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtTk_du).TabIndex = 4;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(688, 286);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSICheckHT2TKTH";
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
		arrayList.Add(((TextBox)txtTK).Text);
		arrayList.Add(((TextBox)txtTk_du).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("ConditionList", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (Operators.CompareString(((TextBox)txtTK).Text.Trim(), "", false) != 0)
		{
			stringBuilder.Append(lblTK.Text);
			stringBuilder.Append(":");
			stringBuilder.Append(((TextBox)txtTK).Text);
			stringBuilder.Append(";");
		}
		if (Operators.CompareString(((TextBox)txtTk_du).Text.Trim(), "", false) != 0)
		{
			stringBuilder.Append(lblTK_du.Text);
			stringBuilder.Append(":");
			stringBuilder.Append(((TextBox)txtTk_du).Text);
			stringBuilder.Append(";");
		}
		return stringBuilder.ToString();
	}
}
