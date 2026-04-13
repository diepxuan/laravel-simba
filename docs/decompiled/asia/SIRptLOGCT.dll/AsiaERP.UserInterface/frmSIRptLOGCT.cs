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
public class frmSIRptLOGCT : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("cboAction")]
	private AsComboBox _cboAction;

	[AccessedThroughProperty("txtUser")]
	private TextBox _txtUser;

	[AccessedThroughProperty("lblNguoi_sd")]
	private Label _lblNguoi_sd;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblThu_tuc")]
	private Label _lblThu_tuc;

	[AccessedThroughProperty("lblTen_ct")]
	private Label _lblTen_ct;

	[AccessedThroughProperty("txtMa_ct")]
	private AsTextBox _txtMa_ct;

	internal virtual AsComboBox cboAction
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboAction;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboAction = value;
		}
	}

	internal virtual TextBox txtUser
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtUser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtUser = value;
		}
	}

	internal virtual Label lblNguoi_sd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguoi_sd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguoi_sd = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label lblThu_tuc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblThu_tuc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblThu_tuc = value;
		}
	}

	internal virtual Label lblTen_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ct = value;
		}
	}

	internal virtual AsTextBox txtMa_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_ct = value;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		txtUser = new TextBox();
		lblNguoi_sd = new Label();
		cboAction = new AsComboBox();
		lblThu_tuc = new Label();
		Label1 = new Label();
		txtMa_ct = new AsTextBox();
		lblTen_ct = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(609, 314);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_ct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_ct);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)lblThu_tuc);
		((Control)tabFilter).Controls.Add((Control)(object)txtUser);
		((Control)tabFilter).Controls.Add((Control)(object)lblNguoi_sd);
		((Control)tabFilter).Controls.Add((Control)(object)cboAction);
		TabPage obj = tabFilter;
		size = new Size(601, 285);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboAction, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNguoi_sd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtUser, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblThu_tuc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_ct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_ct, 0);
		((Control)lbl2).TabIndex = 5;
		Button obj2 = cmdExcel;
		Point location = new Point(496, 495);
		((Control)obj2).Location = location;
		((Control)cmdExcel).TabIndex = 6;
		((Control)txtNgay2).TabIndex = 2;
		Button obj3 = cmdCancel;
		location = new Point(415, 495);
		((Control)obj3).Location = location;
		((Control)cmdCancel).TabIndex = 10;
		((Control)cmdModifyReport).TabIndex = 1;
		((Control)txtNgay1).TabIndex = 4;
		((Control)cboKyBc).TabIndex = 3;
		Label obj4 = lblKyBc;
		location = new Point(25, 81);
		((Control)obj4).Location = location;
		Label obj5 = lblMau_bc;
		location = new Point(25, 28);
		((Control)obj5).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(125, 314);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).Visible = false;
		Label obj6 = lblMauBC;
		location = new Point(170, 313);
		((Control)obj6).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj7 = optVND;
		location = new Point(257, 312);
		((Control)obj7).Location = location;
		((Control)optVND).Visible = false;
		RadioButton obj8 = optNt;
		location = new Point(311, 312);
		((Control)obj8).Location = location;
		((Control)optNt).Visible = false;
		Label obj9 = lblMa_nt;
		location = new Point(39, 316);
		((Control)obj9).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj10 = cmdOk;
		location = new Point(25, 195);
		((Control)obj10).Location = location;
		((Control)cmdOk).TabIndex = 10;
		Label obj11 = lblTieu_de;
		location = new Point(25, 55);
		((Control)obj11).Location = location;
		((Control)lblTieu_de).TabIndex = 11;
		((Control)txtTieu_De).TabIndex = 2;
		TabPage obj12 = tabGrid;
		size = new Size(601, 285);
		((Control)obj12).Size = size;
		TextBox obj13 = txtUser;
		location = new Point(110, 106);
		((Control)obj13).Location = location;
		((Control)txtUser).Name = "txtUser";
		TextBox obj14 = txtUser;
		size = new Size(163, 20);
		((Control)obj14).Size = size;
		((Control)txtUser).TabIndex = 6;
		lblNguoi_sd.AutoSize = true;
		Label obj15 = lblNguoi_sd;
		location = new Point(25, 110);
		((Control)obj15).Location = location;
		((Control)lblNguoi_sd).Name = "lblNguoi_sd";
		Label obj16 = lblNguoi_sd;
		size = new Size(76, 13);
		((Control)obj16).Size = size;
		((Control)lblNguoi_sd).TabIndex = 1017;
		lblNguoi_sd.Text = "Người sử dụng";
		((ComboBox)cboAction).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboAction).FormattingEnabled = true;
		((ComboBox)cboAction).Items.AddRange(new object[2] { "Sửa", "Xóa" });
		AsComboBox asComboBox = cboAction;
		location = new Point(110, 134);
		((Control)asComboBox).Location = location;
		((Control)cboAction).Name = "cboAction";
		AsComboBox asComboBox2 = cboAction;
		size = new Size(163, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboAction).TabIndex = 7;
		lblThu_tuc.AutoSize = true;
		Label obj17 = lblThu_tuc;
		location = new Point(25, 138);
		((Control)obj17).Location = location;
		((Control)lblThu_tuc).Name = "lblThu_tuc";
		Label obj18 = lblThu_tuc;
		size = new Size(59, 13);
		((Control)obj18).Size = size;
		((Control)lblThu_tuc).TabIndex = 1019;
		lblThu_tuc.Text = "Chức năng";
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(25, 170);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(67, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1020;
		Label1.Text = "Mã chứng từ";
		txtMa_ct.AutoLookup = true;
		txtMa_ct.AutoValid = true;
		((TextBoxBase)txtMa_ct).BackColor = SystemColors.Info;
		((TextBox)txtMa_ct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_ct;
		location = new Point(110, 166);
		((Control)asTextBox2).Location = location;
		txtMa_ct.LookupCodeName = "MA_CT";
		((Control)txtMa_ct).Name = "txtMa_ct";
		txtMa_ct.NameControl = lblTen_ct;
		AsTextBox asTextBox3 = txtMa_ct;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_ct).TabIndex = 8;
		txtMa_ct.UseAutoCompleteSource = true;
		Label obj19 = lblTen_ct;
		location = new Point(206, 166);
		((Control)obj19).Location = location;
		((Control)lblTen_ct).Name = "lblTen_ct";
		Label obj20 = lblTen_ct;
		size = new Size(324, 20);
		((Control)obj20).Size = size;
		((Control)lblTen_ct).TabIndex = 9;
		lblTen_ct.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(609, 339);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSIRptLOGCT";
		((Form)this).Text = "frmSIRptLOGCT";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public frmSIRptLOGCT(string menuid)
		: base(menuid)
	{
		InitializeComponent();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		((ComboBox)cboAction).SelectedIndex = 0;
	}

	protected override bool ValidData()
	{
		if (Operators.CompareString(((ComboBox)cboAction).Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)cboAction, Helper.GetMess(50002).Description);
			((Control)cboAction).Select();
			return false;
		}
		if (Operators.CompareString(((TextBox)txtMa_ct).Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtMa_ct, Helper.GetMess(50002).Description);
			((Control)txtMa_ct).Select();
			return false;
		}
		return base.ValidData();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		switch (((ComboBox)cboAction).SelectedIndex)
		{
		case 0:
			arrayList.Add("UPDATE");
			break;
		case 1:
			arrayList.Add("DELETE");
			break;
		}
		arrayList.Add(((TextBox)txtMa_ct).Text);
		arrayList.Add(txtUser.Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFiltertitle());
		return true;
	}

	private string GetFiltertitle()
	{
		string text = "";
		if (Operators.CompareString(txtUser.Text, "", false) != 0)
		{
			text = text + lblNguoi_sd.Text + ": [" + txtUser.Text + "]";
		}
		return text + ", " + lblThu_tuc.Text + ": [" + ((ComboBox)cboAction).Text + "]";
	}
}
