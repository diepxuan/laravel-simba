using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSIDMOpt9Edit : frmDMEdit
{
	private IContainer components;

	[AccessedThroughProperty("txtOpt9")]
	private TextBox _txtOpt9;

	[AccessedThroughProperty("txtTen_opt9")]
	private TextBox _txtTen_opt9;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	internal virtual TextBox txtOpt9
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOpt9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOpt9 = value;
		}
	}

	internal virtual TextBox txtTen_opt9
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_opt9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_opt9 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
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

	[DebuggerNonUserCode]
	public frmSIDMOpt9Edit()
	{
		InitializeComponent();
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		Label1 = new Label();
		txtOpt9 = new TextBox();
		Label2 = new Label();
		txtTen_opt9 = new TextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(81, 71);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 115);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 115);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtOpt9);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_opt9);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		GroupBox obj3 = gbLine;
		Size size = new Size(407, 103);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_opt9, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtOpt9, 0);
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(19, 23);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(48, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 100;
		Label1.Text = "Mã Opt9";
		txtOpt9.CharacterCasing = (CharacterCasing)1;
		TextBox obj4 = txtOpt9;
		location = new Point(81, 19);
		((Control)obj4).Location = location;
		((TextBoxBase)txtOpt9).MaxLength = 8;
		((Control)txtOpt9).Name = "txtOpt9";
		TextBox obj5 = txtOpt9;
		size = new Size(85, 20);
		((Control)obj5).Size = size;
		((Control)txtOpt9).TabIndex = 0;
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(19, 49);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(52, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 100;
		Label2.Text = "Tên Opt9";
		TextBox obj6 = txtTen_opt9;
		location = new Point(81, 45);
		((Control)obj6).Location = location;
		((TextBoxBase)txtTen_opt9).MaxLength = 50;
		((Control)txtTen_opt9).Name = "txtTen_opt9";
		TextBox obj7 = txtTen_opt9;
		size = new Size(303, 20);
		((Control)obj7).Size = size;
		((Control)txtTen_opt9).TabIndex = 1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(431, 150);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSIDMOpt9Edit";
		((Form)this).Text = "frmSIDMOpt9Edit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtOpt9).MaxLength = base.MyDictInfo.code_length;
		((Control)txtOpt9).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtOpt9).Enabled = false;
		((Control)txtTen_opt9).Select();
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtOpt9;
		CreateDataBinding(ref ojb, "opt9");
		txtOpt9 = (TextBox)ojb;
		ojb = (Control)(object)txtTen_opt9;
		CreateDataBinding(ref ojb, "Ten_opt9");
		txtTen_opt9 = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox(txtOpt9) || !ChkEmtyTextBox(txtTen_opt9) || !base.ValidData())
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
			((Control)txtOpt9).Select();
		}
		return flag;
	}
}
