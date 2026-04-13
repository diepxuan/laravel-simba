using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSODMTDEDIT : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtKm")]
	private AsTextNumeric _txtKm;

	[AccessedThroughProperty("txtTen_TD")]
	private TextBox _txtTen_TD;

	[AccessedThroughProperty("txtMa_TD")]
	private TextBox _txtMa_TD;

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

	internal virtual AsTextNumeric txtKm
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtKm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtKm = value;
		}
	}

	internal virtual TextBox txtTen_TD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_TD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_TD = value;
		}
	}

	internal virtual TextBox txtMa_TD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_TD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_TD = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSODMTDEDIT()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		txtKm = new AsTextNumeric();
		txtMa_TD = new TextBox();
		txtTen_TD = new TextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(127, 84);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 3;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 127);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 127);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtTen_TD);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_TD);
		((Control)gbLine).Controls.Add((Control)(object)txtKm);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		GroupBox obj3 = gbLine;
		Size size = new Size(432, 115);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtKm, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_TD, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_TD, 0);
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(15, 20);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(85, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 101;
		Label1.Text = "Mã tuyến đường";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(15, 39);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(89, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 102;
		Label2.Text = "Tên tuyến đường";
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(15, 62);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(22, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 103;
		Label3.Text = "Km";
		txtKm.DecimalSymbol = ".";
		txtKm.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtKm;
		location = new Point(127, 58);
		((Control)asTextNumeric).Location = location;
		txtKm.Mask = "### ### ### ###";
		((Control)txtKm).Name = "txtKm";
		AsTextNumeric asTextNumeric2 = txtKm;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtKm).TabIndex = 2;
		((TextBox)txtKm).Text = "0.00";
		((TextBox)txtKm).TextAlign = (HorizontalAlignment)1;
		txtKm.Value = 0;
		txtMa_TD.CharacterCasing = (CharacterCasing)1;
		TextBox obj4 = txtMa_TD;
		location = new Point(127, 12);
		((Control)obj4).Location = location;
		((TextBoxBase)txtMa_TD).MaxLength = 8;
		((Control)txtMa_TD).Name = "txtMa_TD";
		TextBox obj5 = txtMa_TD;
		size = new Size(100, 20);
		((Control)obj5).Size = size;
		((Control)txtMa_TD).TabIndex = 0;
		TextBox obj6 = txtTen_TD;
		location = new Point(127, 35);
		((Control)obj6).Location = location;
		((TextBoxBase)txtTen_TD).MaxLength = 50;
		((Control)txtTen_TD).Name = "txtTen_TD";
		TextBox obj7 = txtTen_TD;
		size = new Size(283, 20);
		((Control)obj7).Size = size;
		((Control)txtTen_TD).TabIndex = 1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(456, 162);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSODMTDEDIT";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_TD).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_TD).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_TD;
		CreateDataBinding(ref ojb, "Ma_TD");
		txtMa_TD = (TextBox)ojb;
		ojb = (Control)(object)txtTen_TD;
		CreateDataBinding(ref ojb, "Ten_TD");
		txtTen_TD = (TextBox)ojb;
		ojb = (Control)(object)txtKm;
		CreateDataBinding(ref ojb, "Km", "Value");
		txtKm = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_TD).Enabled = false;
		((Control)txtTen_TD).Select();
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox(txtMa_TD) && ChkEmtyTextBox(txtTen_TD) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_TD).Select();
		}
		return flag;
	}
}
