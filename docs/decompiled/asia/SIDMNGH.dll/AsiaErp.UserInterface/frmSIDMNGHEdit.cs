using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSIDMNGHEdit : frmDMEdit
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtMa_ngh")]
	private TextBox _txtMa_ngh;

	[AccessedThroughProperty("txtTen_ngh")]
	private TextBox _txtTen_ngh;

	[AccessedThroughProperty("txtGhi_chu")]
	private TextBox _txtGhi_chu;

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

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual TextBox txtMa_ngh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ngh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_ngh = value;
		}
	}

	internal virtual TextBox txtTen_ngh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_ngh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_ngh = value;
		}
	}

	internal virtual TextBox txtGhi_chu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGhi_chu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGhi_chu = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSIDMNGHEdit()
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		txtMa_ngh = new TextBox();
		txtTen_ngh = new TextBox();
		txtGhi_chu = new TextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(102, 97);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 3;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 131);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 131);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_ngh);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_ngh);
		((Control)gbLine).Controls.Add((Control)(object)txtGhi_chu);
		GroupBox obj3 = gbLine;
		Size size = new Size(484, 119);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGhi_chu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_ngh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_ngh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(15, 23);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(76, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 104;
		Label1.Text = "Mã ngân hàng";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(15, 49);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(80, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 103;
		Label2.Text = "Tên ngân hàng";
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(15, 75);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(44, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 102;
		Label3.Text = "Ghi chú";
		txtMa_ngh.CharacterCasing = (CharacterCasing)1;
		TextBox obj4 = txtMa_ngh;
		location = new Point(102, 19);
		((Control)obj4).Location = location;
		((TextBoxBase)txtMa_ngh).MaxLength = 20;
		((Control)txtMa_ngh).Name = "txtMa_ngh";
		TextBox obj5 = txtMa_ngh;
		size = new Size(100, 20);
		((Control)obj5).Size = size;
		((Control)txtMa_ngh).TabIndex = 0;
		TextBox obj6 = txtTen_ngh;
		location = new Point(102, 45);
		((Control)obj6).Location = location;
		((TextBoxBase)txtTen_ngh).MaxLength = 50;
		((Control)txtTen_ngh).Name = "txtTen_ngh";
		TextBox obj7 = txtTen_ngh;
		size = new Size(366, 20);
		((Control)obj7).Size = size;
		((Control)txtTen_ngh).TabIndex = 1;
		TextBox obj8 = txtGhi_chu;
		location = new Point(102, 71);
		((Control)obj8).Location = location;
		((TextBoxBase)txtGhi_chu).MaxLength = 255;
		((Control)txtGhi_chu).Name = "txtGhi_chu";
		TextBox obj9 = txtGhi_chu;
		size = new Size(366, 20);
		((Control)obj9).Size = size;
		((Control)txtGhi_chu).TabIndex = 2;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(508, 166);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSIDMNGHEdit";
		((Form)this).Text = "frmSIDMNGHEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_ngh).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_ngh).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_ngh).Enabled = false;
		((Control)txtTen_ngh).Select();
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_ngh;
		CreateDataBinding(ref ojb, "ma_ngh");
		txtMa_ngh = (TextBox)ojb;
		ojb = (Control)(object)txtTen_ngh;
		CreateDataBinding(ref ojb, "ten_ngh");
		txtTen_ngh = (TextBox)ojb;
		ojb = (Control)(object)txtGhi_chu;
		CreateDataBinding(ref ojb, "ghi_chu");
		txtGhi_chu = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "sd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox(txtMa_ngh) || !ChkEmtyTextBox(txtTen_ngh) || !base.ValidData())
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
			((Control)txtMa_ngh).Select();
		}
		return flag;
	}
}
