using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLRptCTGS03 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

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

	internal virtual Label lblTk
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

	internal virtual Label lblTen_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk = value;
		}
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

	public frmGLRptCTGS03(string MenuId)
		: base(MenuId)
	{
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected O, but got Unknown
		txtTk = new AsTextBox();
		lblTen_tk = new Label();
		lblTk = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(696, 582);
		((Control)asTabControl).Size = size;
		((ScrollableControl)tabFilter).AutoScroll = false;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tk);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		TabPage obj = tabFilter;
		size = new Size(688, 553);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		Label obj2 = lbl2;
		Point location = new Point(280, 81);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 754);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(299, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 754);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(458, 23);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 25;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(209, 77);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(113, 77);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(27, 81);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(113, 24);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 24;
		Label obj9 = lblMau_bc;
		location = new Point(27, 28);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(113, 130);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 4;
		Label obj10 = lblMauBC;
		location = new Point(158, 129);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 21;
		RadioButton obj11 = optVND;
		location = new Point(245, 128);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 5;
		RadioButton obj12 = optNt;
		location = new Point(299, 129);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 6;
		Label obj13 = lblMa_nt;
		location = new Point(27, 132);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(30, 163);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 7;
		Label obj15 = lblTieu_de;
		location = new Point(27, 55);
		((Control)obj15).Location = location;
		TextBox obj16 = txtTieu_De;
		location = new Point(113, 51);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 26;
		TabPage obj17 = tabGrid;
		size = new Size(688, 553);
		((Control)obj17).Size = size;
		txtTk.AutoLookup = false;
		txtTk.AutoValid = false;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTk;
		location = new Point(113, 104);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_tk;
		AsTextBox asTextBox3 = txtTk;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 3;
		txtTk.UseAutoCompleteSource = true;
		Label obj18 = lblTen_tk;
		location = new Point(209, 103);
		((Control)obj18).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj19 = lblTen_tk;
		size = new Size(324, 20);
		((Control)obj19).Size = size;
		((Control)lblTen_tk).TabIndex = 1018;
		lblTen_tk.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		Label obj20 = lblTk;
		location = new Point(27, 108);
		((Control)obj20).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj21 = lblTk;
		size = new Size(55, 13);
		((Control)obj21).Size = size;
		((Control)lblTk).TabIndex = 1017;
		lblTk.Text = "Tài khoản";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(696, 607);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmGLRptCTGS03";
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
		((Control)cboKyBc).Select();
	}

	protected override bool LoadData()
	{
		if (cboMau_bc.SelectedIndex == -1)
		{
			return false;
		}
		if (Operators.CompareString(((TextBox)txtTk).Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtTk, Helper.GetMessContent(50002));
			((Control)txtTk).Select();
			return false;
		}
		SetControlError((Control)(object)txtTk, "");
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(((TextBox)txtTk).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		return true;
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		DataRowView dataRowView = get_MyDGVSource(isSet2Print: true).DefaultView[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
		if ((int)keycode != 116)
		{
			base.CancelDrilldown = true;
			return null;
		}
		ArrayList arrayList = new ArrayList();
		if ((int)modifierKeys == 0)
		{
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ngay_lo"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["so_lo"]));
			arrayList.Add(((TextBox)txtTk).Text.Trim());
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["tk_du"]));
			filterCondition4title = dataRowView["so_lo"].ToString() + " - " + dataRowView["dien_giai"].ToString();
			return arrayList;
		}
		base.CancelDrilldown = true;
		return null;
	}
}
