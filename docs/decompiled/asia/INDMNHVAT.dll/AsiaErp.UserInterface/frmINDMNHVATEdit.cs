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
public class frmINDMNHVATEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtTen_NhVat")]
	private TextBox _txtTen_NhVat;

	[AccessedThroughProperty("lblTen_NhVat")]
	private Label _lblTen_NhVat;

	[AccessedThroughProperty("txtMa_NhVat")]
	private TextBox _txtMa_NhVat;

	[AccessedThroughProperty("lblMa_NhVat")]
	private Label _lblMa_NhVat;

	internal virtual TextBox txtTen_NhVat
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_NhVat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_NhVat = value;
		}
	}

	internal virtual Label lblTen_NhVat
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_NhVat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_NhVat = value;
		}
	}

	internal virtual TextBox txtMa_NhVat
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_NhVat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_NhVat = value;
		}
	}

	internal virtual Label lblMa_NhVat
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_NhVat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_NhVat = value;
		}
	}

	[DebuggerNonUserCode]
	public frmINDMNHVATEdit()
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
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		txtTen_NhVat = new TextBox();
		lblTen_NhVat = new Label();
		txtMa_NhVat = new TextBox();
		lblMa_NhVat = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(115, 78);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 132);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 132);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtTen_NhVat);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_NhVat);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_NhVat);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_NhVat);
		GroupBox obj3 = gbLine;
		Size size = new Size(470, 119);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_NhVat, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_NhVat, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_NhVat, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_NhVat, 0);
		((Control)txtTen_NhVat).Anchor = (AnchorStyles)15;
		TextBox obj4 = txtTen_NhVat;
		location = new Point(115, 52);
		((Control)obj4).Location = location;
		((TextBoxBase)txtTen_NhVat).MaxLength = 128;
		((Control)txtTen_NhVat).Name = "txtTen_NhVat";
		TextBox obj5 = txtTen_NhVat;
		size = new Size(344, 20);
		((Control)obj5).Size = size;
		((Control)txtTen_NhVat).TabIndex = 1;
		((Control)lblTen_NhVat).Anchor = (AnchorStyles)15;
		lblTen_NhVat.AutoSize = true;
		Label obj6 = lblTen_NhVat;
		location = new Point(11, 56);
		((Control)obj6).Location = location;
		((Control)lblTen_NhVat).Name = "lblTen_NhVat";
		Label obj7 = lblTen_NhVat;
		size = new Size(79, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_NhVat).TabIndex = 103;
		lblTen_NhVat.Text = "Tên nhóm VAT";
		((Control)txtMa_NhVat).Anchor = (AnchorStyles)15;
		txtMa_NhVat.CharacterCasing = (CharacterCasing)1;
		TextBox obj8 = txtMa_NhVat;
		location = new Point(115, 26);
		((Control)obj8).Location = location;
		((Control)txtMa_NhVat).Name = "txtMa_NhVat";
		TextBox obj9 = txtMa_NhVat;
		size = new Size(98, 20);
		((Control)obj9).Size = size;
		((Control)txtMa_NhVat).TabIndex = 0;
		((Control)lblMa_NhVat).Anchor = (AnchorStyles)15;
		lblMa_NhVat.AutoSize = true;
		Label obj10 = lblMa_NhVat;
		location = new Point(11, 30);
		((Control)obj10).Location = location;
		((Control)lblMa_NhVat).Name = "lblMa_NhVat";
		Label obj11 = lblMa_NhVat;
		size = new Size(75, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_NhVat).TabIndex = 102;
		lblMa_NhVat.Text = "Mã nhóm VAT";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(492, 162);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmINDMNHVATEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_NhVat).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_NhVat).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_NhVat).Enabled = false;
		((Control)txtTen_NhVat).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_NhVat;
		CreateDataBinding(ref ojb, "Ma_NhVat");
		txtMa_NhVat = (TextBox)ojb;
		ojb = (Control)(object)txtTen_NhVat;
		CreateDataBinding(ref ojb, "Ten_NhVat");
		txtTen_NhVat = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox(txtMa_NhVat) && ChkEmtyTextBox(txtTen_NhVat) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_NhVat).Select();
		}
		return flag;
	}
}
