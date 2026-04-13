using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSIDMNHHDEdit : frmDMEdit
{
	private IContainer components;

	[AccessedThroughProperty("txtTen_NhHd")]
	private TextBox _txtTen_NhHd;

	[AccessedThroughProperty("lblMa_NhHd")]
	private Label _lblMa_NhHd;

	[AccessedThroughProperty("lblTen_NhHd")]
	private Label _lblTen_NhHd;

	[AccessedThroughProperty("txtMa_NhHd")]
	private TextBox _txtMa_NhHd;

	internal virtual TextBox txtTen_NhHd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_NhHd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_NhHd = value;
		}
	}

	internal virtual Label lblMa_NhHd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_NhHd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_NhHd = value;
		}
	}

	internal virtual Label lblTen_NhHd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_NhHd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_NhHd = value;
		}
	}

	internal virtual TextBox txtMa_NhHd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_NhHd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_NhHd = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSIDMNHHDEdit()
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
		txtTen_NhHd = new TextBox();
		lblMa_NhHd = new Label();
		lblTen_NhHd = new Label();
		txtMa_NhHd = new TextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Anchor = (AnchorStyles)5;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(98, 71);
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
		((Control)gbLine).Controls.Add((Control)(object)txtTen_NhHd);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_NhHd);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_NhHd);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_NhHd);
		GroupBox obj3 = gbLine;
		Size size = new Size(443, 101);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_NhHd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_NhHd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_NhHd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_NhHd, 0);
		TextBox obj4 = txtTen_NhHd;
		location = new Point(98, 45);
		((Control)obj4).Location = location;
		((TextBoxBase)txtTen_NhHd).MaxLength = 128;
		((Control)txtTen_NhHd).Name = "txtTen_NhHd";
		TextBox obj5 = txtTen_NhHd;
		size = new Size(328, 20);
		((Control)obj5).Size = size;
		((Control)txtTen_NhHd).TabIndex = 1;
		lblMa_NhHd.AutoSize = true;
		Label obj6 = lblMa_NhHd;
		location = new Point(13, 23);
		((Control)obj6).Location = location;
		((Control)lblMa_NhHd).Name = "lblMa_NhHd";
		Label obj7 = lblMa_NhHd;
		size = new Size(51, 13);
		((Control)obj7).Size = size;
		((Control)lblMa_NhHd).TabIndex = 102;
		lblMa_NhHd.Text = "Mã nhóm";
		lblTen_NhHd.AutoSize = true;
		Label obj8 = lblTen_NhHd;
		location = new Point(13, 45);
		((Control)obj8).Location = location;
		((Control)lblTen_NhHd).Name = "lblTen_NhHd";
		Label obj9 = lblTen_NhHd;
		size = new Size(55, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_NhHd).TabIndex = 103;
		lblTen_NhHd.Text = "Tên nhóm";
		txtMa_NhHd.CharacterCasing = (CharacterCasing)1;
		TextBox obj10 = txtMa_NhHd;
		location = new Point(98, 19);
		((Control)obj10).Location = location;
		((Control)txtMa_NhHd).Name = "txtMa_NhHd";
		TextBox obj11 = txtMa_NhHd;
		size = new Size(98, 20);
		((Control)obj11).Size = size;
		((Control)txtMa_NhHd).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(465, 144);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSIDMNHHDEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_NhHd).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_NhHd).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_NhHd).Enabled = false;
		((Control)txtTen_NhHd).Select();
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_NhHd;
		CreateDataBinding(ref ojb, "Ma_NhHd");
		txtMa_NhHd = (TextBox)ojb;
		ojb = (Control)(object)txtTen_NhHd;
		CreateDataBinding(ref ojb, "Ten_NhHd");
		txtTen_NhHd = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox(txtMa_NhHd) || !ChkEmtyTextBox(txtTen_NhHd) || !base.ValidData())
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
			((Control)txtMa_NhHd).Select();
		}
		return flag;
	}
}
