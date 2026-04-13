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
public class frmSICheckLechSo : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTK")]
	private Label _lblTK;

	[AccessedThroughProperty("lblTk_du")]
	private Label _lblTk_du;

	[AccessedThroughProperty("txtTk_du")]
	private AsTextBox _txtTk_du;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("lblTen_tkdu")]
	private Label _lblTen_tkdu;

	internal virtual AsTextBox txtTk
	{
		get
		{
			return _txtTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTk = value;
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

	internal virtual Label lblTk_du
	{
		get
		{
			return _lblTk_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTk_du = value;
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

	public frmSICheckLechSo(string MenuID)
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		txtTk = new AsTextBox();
		lblTen_tk = new Label();
		lblTK = new Label();
		lblTk_du = new Label();
		txtTk_du = new AsTextBox();
		lblTen_tkdu = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(637, 253);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)lblTK);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk_du);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk_du);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tkdu);
		TabPage obj = tabFilter;
		size = new Size(629, 224);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tkdu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk_du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk_du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		Label obj2 = lbl2;
		Point location = new Point(290, 82);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(546, 198);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 7;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(309, 78);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(465, 198);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 6;
		Button obj5 = cmdModifyReport;
		location = new Point(468, 23);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 9;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(219, 78);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(123, 78);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		ComboBox obj7 = cboMau_bc;
		location = new Point(123, 25);
		((Control)obj7).Location = location;
		((Control)cboMau_bc).TabIndex = 8;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(245, 433);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).Visible = false;
		Label obj8 = lblMauBC;
		location = new Point(290, 432);
		((Control)obj8).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj9 = optVND;
		location = new Point(377, 431);
		((Control)obj9).Location = location;
		((Control)optVND).Visible = false;
		RadioButton obj10 = optNt;
		location = new Point(431, 432);
		((Control)obj10).Location = location;
		((Control)optNt).Visible = false;
		Label obj11 = lblMa_nt;
		location = new Point(146, 437);
		((Control)obj11).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj12 = cmdOk;
		location = new Point(27, 177);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 5;
		TextBox obj13 = txtTieu_De;
		location = new Point(123, 52);
		((Control)obj13).Location = location;
		((Control)txtTieu_De).TabIndex = 10;
		TabPage obj14 = tabGrid;
		size = new Size(629, 224);
		((Control)obj14).Size = size;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = false;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTk;
		location = new Point(123, 105);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_tk;
		AsTextBox asTextBox3 = txtTk;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 3;
		Label obj15 = lblTen_tk;
		location = new Point(219, 108);
		((Control)obj15).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj16 = lblTen_tk;
		size = new Size(324, 13);
		((Control)obj16).Size = size;
		((Control)lblTen_tk).TabIndex = 1017;
		lblTK.AutoSize = true;
		Label obj17 = lblTK;
		location = new Point(24, 108);
		((Control)obj17).Location = location;
		((Control)lblTK).Name = "lblTK";
		Label obj18 = lblTK;
		size = new Size(55, 13);
		((Control)obj18).Size = size;
		((Control)lblTK).TabIndex = 1017;
		lblTK.Text = "Tài khoản";
		lblTk_du.AutoSize = true;
		Label obj19 = lblTk_du;
		location = new Point(24, 134);
		((Control)obj19).Location = location;
		((Control)lblTk_du).Name = "lblTk_du";
		Label obj20 = lblTk_du;
		size = new Size(94, 13);
		((Control)obj20).Size = size;
		((Control)lblTk_du).TabIndex = 1017;
		lblTk_du.Text = "Tài khoản đối ứng";
		txtTk_du.AutoLookup = true;
		txtTk_du.AutoValid = false;
		((TextBoxBase)txtTk_du).BackColor = SystemColors.Info;
		((TextBox)txtTk_du).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtTk_du;
		location = new Point(123, 131);
		((Control)asTextBox4).Location = location;
		txtTk_du.LookupCodeName = "TK";
		((Control)txtTk_du).Name = "txtTk_du";
		txtTk_du.NameControl = lblTen_tkdu;
		AsTextBox asTextBox5 = txtTk_du;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtTk_du).TabIndex = 4;
		Label obj21 = lblTen_tkdu;
		location = new Point(219, 134);
		((Control)obj21).Location = location;
		((Control)lblTen_tkdu).Name = "lblTen_tkdu";
		Label obj22 = lblTen_tkdu;
		size = new Size(324, 13);
		((Control)obj22).Size = size;
		((Control)lblTen_tkdu).TabIndex = 1017;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(637, 278);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSICheckLechSo";
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
		arrayList.Add(((TextBox)txtTk_du).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("ConditionList", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (Operators.CompareString(((TextBox)txtTk).Text.Trim(), "", false) != 0)
		{
			stringBuilder.Append(lblTK.Text);
			stringBuilder.Append(":");
			stringBuilder.Append(((TextBox)txtTk).Text);
			stringBuilder.Append(";");
		}
		if (Operators.CompareString(((TextBox)txtTk_du).Text.Trim(), "", false) != 0)
		{
			stringBuilder.Append(lblTk_du.Text);
			stringBuilder.Append(":");
			stringBuilder.Append(((TextBox)txtTk_du).Text);
			stringBuilder.Append(";");
		}
		return stringBuilder.ToString();
	}
}
