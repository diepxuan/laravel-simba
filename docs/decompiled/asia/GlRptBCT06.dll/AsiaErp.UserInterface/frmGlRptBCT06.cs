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
public class frmGlRptBCT06 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("cmdCF")]
	private Button _cmdCF;

	internal virtual Button cmdCF
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCF_Click;
			if (_cmdCF != null)
			{
				((Control)_cmdCF).Click -= eventHandler;
			}
			_cmdCF = value;
			if (_cmdCF != null)
			{
				((Control)_cmdCF).Click += eventHandler;
			}
		}
	}

	public frmGlRptBCT06(string menuid)
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
		cmdCF = new Button();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(564, 206);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((ScrollableControl)tabFilter).AutoScroll = false;
		((Control)tabFilter).Controls.Add((Control)(object)cmdCF);
		TabPage obj = tabFilter;
		size = new Size(556, 177);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCF, 0);
		Label obj2 = lbl2;
		Point location = new Point(278, 92);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 3;
		Button obj3 = cmdExcel;
		location = new Point(700, 154);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(297, 88);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 154);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(456, 34);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 11;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(207, 88);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(111, 88);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(17, 92);
		((Control)obj7).Location = location;
		((Control)lblKyBc).TabIndex = 0;
		ComboBox obj8 = cboMau_bc;
		location = new Point(111, 35);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 10;
		((Control)cboMau_bc).TabStop = false;
		Label obj9 = lblMau_bc;
		location = new Point(17, 39);
		((Control)obj9).Location = location;
		((Control)lblMau_bc).TabIndex = 16;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(296, 198);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 7;
		((Control)txtMa_Nt).Visible = false;
		Label obj10 = lblMauBC;
		location = new Point(341, 197);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 12;
		((Control)lblMauBC).Visible = false;
		RadioButton obj11 = optVND;
		location = new Point(428, 196);
		((Control)obj11).Location = location;
		((Control)optVND).Visible = false;
		RadioButton obj12 = optNt;
		location = new Point(482, 197);
		((Control)obj12).Location = location;
		((Control)optNt).Visible = false;
		Label obj13 = lblMa_nt;
		location = new Point(204, 200);
		((Control)obj13).Location = location;
		((Control)lblMa_nt).TabIndex = 10;
		((Control)lblMa_nt).Visible = false;
		Button obj14 = cmdOk;
		location = new Point(19, 130);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 8;
		Label obj15 = lblTieu_de;
		location = new Point(17, 66);
		((Control)obj15).Location = location;
		((Control)lblTieu_de).TabIndex = 19;
		TextBox obj16 = txtTieu_De;
		location = new Point(111, 62);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 12;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj17 = tabGrid;
		size = new Size(556, 177);
		((Control)obj17).Size = size;
		Button obj18 = cmdCF;
		location = new Point(111, 130);
		((Control)obj18).Location = location;
		((Control)cmdCF).Name = "cmdCF";
		Button obj19 = cmdCF;
		size = new Size(90, 23);
		((Control)obj19).Size = size;
		((Control)cmdCF).TabIndex = 9;
		((ButtonBase)cmdCF).Text = "KB &Công thức";
		((ButtonBase)cmdCF).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(564, 231);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlRptBCT06";
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
		arrayList.Add(base.MyReportInfo.ma_mau);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		MyFomularFields.Clear();
		return true;
	}

	private void cmdCF_Click(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		Form val = Application.OpenForms["frmTATNDN01A"];
		foreach (Form item in (ReadOnlyCollectionBase)(object)Application.OpenForms)
		{
			Form val2 = item;
			if (val2 is frmTATNDN031A)
			{
				return;
			}
		}
		val = (Form)(object)new frmTATNDN031A(base.MyMenuID, MyMenuInfo.code_name, MyReportInfo.ma_mau);
		val.Show((IWin32Window)(object)this);
	}
}
