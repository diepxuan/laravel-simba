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
public class frmGLRptNKC08 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

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

	protected frmGLRptNKC08(string menuid)
		: base(menuid)
	{
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Label1 = new Label();
		txtTk = new AsTextBox();
		lblTk = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk, 0);
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
		((Control)lbl2).TabIndex = 5;
		Button obj = cmdExcel;
		Point location = new Point(700, 320);
		((Control)obj).Location = location;
		Button obj2 = cmdCancel;
		location = new Point(619, 320);
		((Control)obj2).Location = location;
		((Control)cmdModifyReport).TabIndex = 1;
		((Control)txtNgay1).TabIndex = 4;
		((Control)cboKyBc).TabIndex = 3;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(514, 280);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).Visible = false;
		Label obj3 = lblMauBC;
		location = new Point(559, 279);
		((Control)obj3).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj4 = optVND;
		location = new Point(646, 278);
		((Control)obj4).Location = location;
		((Control)optVND).Visible = false;
		RadioButton obj5 = optNt;
		location = new Point(700, 279);
		((Control)obj5).Location = location;
		((Control)optNt).Visible = false;
		Label obj6 = lblMa_nt;
		location = new Point(428, 282);
		((Control)obj6).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj7 = cmdOk;
		location = new Point(27, 145);
		((Control)obj7).Location = location;
		((Control)cmdOk).TabIndex = 8;
		((Control)txtTieu_De).TabIndex = 2;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(24, 111);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(55, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1016;
		Label1.Text = "Tài khoản";
		txtTk.AutoLookup = true;
		txtTk.AutoValid = true;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTk;
		location = new Point(110, 107);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTk;
		AsTextBox asTextBox3 = txtTk;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 6;
		txtTk.UseAutoCompleteSource = true;
		Label obj8 = lblTk;
		location = new Point(209, 107);
		((Control)obj8).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj9 = lblTk;
		size = new Size(321, 20);
		((Control)obj9).Size = size;
		((Control)lblTk).TabIndex = 7;
		lblTk.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(790, 510);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGLRptNKC08";
		((Form)this).Text = "frmGLRptNKC08";
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
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		return true;
	}

	protected override bool ValidData()
	{
		if (Operators.CompareString(((TextBox)txtTk).Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtTk, Helper.GetMess(50002).Description);
			((Control)txtTk).Select();
			return false;
		}
		return base.ValidData();
	}
}
