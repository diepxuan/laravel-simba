using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSIDMOpt10Edit : frmDMEdit
{
	private IContainer components;

	[AccessedThroughProperty("txtOpt10")]
	private TextBox _txtOpt10;

	[AccessedThroughProperty("txtTen_opt10")]
	private TextBox _txtTen_opt10;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	internal virtual TextBox txtOpt10
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOpt10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOpt10 = value;
		}
	}

	internal virtual TextBox txtTen_opt10
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_opt10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_opt10 = value;
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
	public frmSIDMOpt10Edit()
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
		txtOpt10 = new TextBox();
		Label2 = new Label();
		txtTen_opt10 = new TextBox();
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
		((Control)gbLine).Controls.Add((Control)(object)txtOpt10);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_opt10);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		GroupBox obj3 = gbLine;
		Size size = new Size(404, 103);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_opt10, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtOpt10, 0);
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(19, 23);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(54, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 100;
		Label1.Text = "Mã Opt10";
		txtOpt10.CharacterCasing = (CharacterCasing)1;
		TextBox obj4 = txtOpt10;
		location = new Point(81, 19);
		((Control)obj4).Location = location;
		((TextBoxBase)txtOpt10).MaxLength = 8;
		((Control)txtOpt10).Name = "txtOpt10";
		TextBox obj5 = txtOpt10;
		size = new Size(86, 20);
		((Control)obj5).Size = size;
		((Control)txtOpt10).TabIndex = 0;
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(19, 49);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(58, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 100;
		Label2.Text = "Tên Opt10";
		TextBox obj6 = txtTen_opt10;
		location = new Point(81, 45);
		((Control)obj6).Location = location;
		((TextBoxBase)txtTen_opt10).MaxLength = 50;
		((Control)txtTen_opt10).Name = "txtTen_opt10";
		TextBox obj7 = txtTen_opt10;
		size = new Size(303, 20);
		((Control)obj7).Size = size;
		((Control)txtTen_opt10).TabIndex = 1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(428, 150);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSIDMOpt10Edit";
		((Form)this).Text = "frmSIDMOpt9Edit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtOpt10).MaxLength = base.MyDictInfo.code_length;
		((Control)txtOpt10).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtOpt10).Enabled = false;
		((Control)txtTen_opt10).Select();
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtOpt10;
		CreateDataBinding(ref ojb, "opt10");
		txtOpt10 = (TextBox)ojb;
		ojb = (Control)(object)txtTen_opt10;
		CreateDataBinding(ref ojb, "Ten_opt10");
		txtTen_opt10 = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox(txtOpt10) || !ChkEmtyTextBox(txtTen_opt10) || !base.ValidData())
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
			((Control)txtOpt10).Select();
		}
		return flag;
	}
}
