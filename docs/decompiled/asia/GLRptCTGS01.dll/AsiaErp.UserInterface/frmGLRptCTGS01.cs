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
public class frmGLRptCTGS01 : frmReport
{
	private IContainer components;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	public frmGLRptCTGS01(string MenuId)
		: base(MenuId)
	{
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(775, 632);
		((Control)asTabControl).Size = size;
		((ScrollableControl)tabFilter).AutoScroll = false;
		TabPage obj = tabFilter;
		size = new Size(767, 603);
		((Control)obj).Size = size;
		Label obj2 = lbl2;
		Point location = new Point(280, 81);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 804);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(299, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 804);
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
		location = new Point(113, 104);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 3;
		Label obj10 = lblMauBC;
		location = new Point(158, 103);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 21;
		RadioButton obj11 = optVND;
		location = new Point(245, 102);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 4;
		RadioButton obj12 = optNt;
		location = new Point(299, 103);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 5;
		Label obj13 = lblMa_nt;
		location = new Point(27, 106);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(30, 149);
		((Control)obj14).Location = location;
		Label obj15 = lblTieu_de;
		location = new Point(27, 55);
		((Control)obj15).Location = location;
		TextBox obj16 = txtTieu_De;
		location = new Point(113, 51);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 26;
		TabPage obj17 = tabGrid;
		size = new Size(767, 603);
		((Control)obj17).Size = size;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(775, 657);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmGLRptCTGS01";
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
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
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
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ngay_lo"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["so_lo"]));
			arrayList.Add("");
			arrayList.Add("");
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			filterCondition4title = dataRowView["so_lo"].ToString() + " - " + dataRowView["dien_giai"].ToString();
			return arrayList;
		}
		base.CancelDrilldown = true;
		return null;
	}
}
