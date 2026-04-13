using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSIDMPHIEdit : frmDMEdit
{
	private IContainer components;

	[AccessedThroughProperty("txtTen_Phi")]
	private TextBox _txtTen_Phi;

	[AccessedThroughProperty("lblTen_Phi")]
	private Label _lblTen_Phi;

	[AccessedThroughProperty("txtMa_Phi")]
	private TextBox _txtMa_Phi;

	[AccessedThroughProperty("lblMa_Phi")]
	private Label _lblMa_Phi;

	internal virtual TextBox txtTen_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Phi = value;
		}
	}

	internal virtual Label lblTen_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Phi = value;
		}
	}

	internal virtual TextBox txtMa_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Phi = value;
		}
	}

	internal virtual Label lblMa_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Phi = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSIDMPHIEdit()
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
		txtTen_Phi = new TextBox();
		lblTen_Phi = new Label();
		txtMa_Phi = new TextBox();
		lblMa_Phi = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Anchor = (AnchorStyles)5;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(69, 72);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 114);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 114);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Phi);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Phi);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Phi);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Phi);
		GroupBox obj3 = gbLine;
		Size size = new Size(459, 101);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Phi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Phi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Phi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Phi, 0);
		TextBox obj4 = txtTen_Phi;
		location = new Point(69, 46);
		((Control)obj4).Location = location;
		((TextBoxBase)txtTen_Phi).MaxLength = 128;
		((Control)txtTen_Phi).Name = "txtTen_Phi";
		TextBox obj5 = txtTen_Phi;
		size = new Size(352, 20);
		((Control)obj5).Size = size;
		((Control)txtTen_Phi).TabIndex = 1;
		lblTen_Phi.AutoSize = true;
		Label obj6 = lblTen_Phi;
		location = new Point(10, 49);
		((Control)obj6).Location = location;
		((Control)lblTen_Phi).Name = "lblTen_Phi";
		Label obj7 = lblTen_Phi;
		size = new Size(45, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_Phi).TabIndex = 8;
		lblTen_Phi.Text = "Tên phí";
		txtMa_Phi.CharacterCasing = (CharacterCasing)1;
		TextBox obj8 = txtMa_Phi;
		location = new Point(69, 20);
		((Control)obj8).Location = location;
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		TextBox obj9 = txtMa_Phi;
		size = new Size(98, 20);
		((Control)obj9).Size = size;
		((Control)txtMa_Phi).TabIndex = 0;
		lblMa_Phi.AutoSize = true;
		Label obj10 = lblMa_Phi;
		location = new Point(10, 23);
		((Control)obj10).Location = location;
		((Control)lblMa_Phi).Name = "lblMa_Phi";
		Label obj11 = lblMa_Phi;
		size = new Size(41, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_Phi).TabIndex = 7;
		lblMa_Phi.Text = "Mã phí";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(481, 144);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSIDMPHIEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_Phi).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_Phi).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_Phi).Enabled = false;
		((Control)txtTen_Phi).Select();
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_Phi;
		CreateDataBinding(ref ojb, "Ma_Phi");
		txtMa_Phi = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Phi;
		CreateDataBinding(ref ojb, "Ten_Phi");
		txtTen_Phi = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		txtMa_Phi.Text = txtMa_Phi.Text.Trim();
		txtTen_Phi.Text = txtTen_Phi.Text.Trim();
		if (!ChkEmtyTextBox(txtMa_Phi) || !ChkEmtyTextBox(txtTen_Phi) || !base.ValidData())
		{
			return false;
		}
		return true;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_Phi).Select();
		}
		return flag;
	}
}
