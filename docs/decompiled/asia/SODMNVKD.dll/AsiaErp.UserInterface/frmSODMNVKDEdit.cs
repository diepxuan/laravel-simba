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
public class frmSODMNVKDEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtTen_Nvkd")]
	private TextBox _txtTen_Nvkd;

	[AccessedThroughProperty("lblTen_NvKd")]
	private Label _lblTen_NvKd;

	[AccessedThroughProperty("txtMa_NvKd")]
	private TextBox _txtMa_NvKd;

	[AccessedThroughProperty("lblMa_NvKd")]
	private Label _lblMa_NvKd;

	internal virtual TextBox txtTen_Nvkd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Nvkd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Nvkd = value;
		}
	}

	internal virtual Label lblTen_NvKd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_NvKd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_NvKd = value;
		}
	}

	internal virtual TextBox txtMa_NvKd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_NvKd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_NvKd = value;
		}
	}

	internal virtual Label lblMa_NvKd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_NvKd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_NvKd = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSODMNVKDEdit()
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
		txtTen_Nvkd = new TextBox();
		lblTen_NvKd = new Label();
		txtMa_NvKd = new TextBox();
		lblMa_NvKd = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Anchor = (AnchorStyles)5;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(117, 71);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 118);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 118);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Nvkd);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_NvKd);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_NvKd);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_NvKd);
		GroupBox obj3 = gbLine;
		Size size = new Size(400, 105);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_NvKd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_NvKd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_NvKd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Nvkd, 0);
		TextBox obj4 = txtTen_Nvkd;
		location = new Point(117, 45);
		((Control)obj4).Location = location;
		((TextBoxBase)txtTen_Nvkd).MaxLength = 128;
		((Control)txtTen_Nvkd).Name = "txtTen_Nvkd";
		TextBox obj5 = txtTen_Nvkd;
		size = new Size(265, 20);
		((Control)obj5).Size = size;
		((Control)txtTen_Nvkd).TabIndex = 1;
		lblTen_NvKd.AutoSize = true;
		Label obj6 = lblTen_NvKd;
		location = new Point(13, 49);
		((Control)obj6).Location = location;
		((Control)lblTen_NvKd).Name = "lblTen_NvKd";
		Label obj7 = lblTen_NvKd;
		size = new Size(94, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_NvKd).TabIndex = 103;
		lblTen_NvKd.Text = "Tên nhân viên KD";
		txtMa_NvKd.CharacterCasing = (CharacterCasing)1;
		TextBox obj8 = txtMa_NvKd;
		location = new Point(117, 19);
		((Control)obj8).Location = location;
		((Control)txtMa_NvKd).Name = "txtMa_NvKd";
		TextBox obj9 = txtMa_NvKd;
		size = new Size(98, 20);
		((Control)obj9).Size = size;
		((Control)txtMa_NvKd).TabIndex = 0;
		lblMa_NvKd.AutoSize = true;
		Label obj10 = lblMa_NvKd;
		location = new Point(13, 23);
		((Control)obj10).Location = location;
		((Control)lblMa_NvKd).Name = "lblMa_NvKd";
		Label obj11 = lblMa_NvKd;
		size = new Size(90, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_NvKd).TabIndex = 102;
		lblMa_NvKd.Text = "Mã nhân viên KD";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(422, 148);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSODMNVKDEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_NvKd).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_NvKd).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_NvKd).Enabled = false;
		((Control)txtTen_Nvkd).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_NvKd;
		CreateDataBinding(ref ojb, "Ma_NvKd");
		txtMa_NvKd = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Nvkd;
		CreateDataBinding(ref ojb, "Ten_NvKd");
		txtTen_Nvkd = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox(txtMa_NvKd) && ChkEmtyTextBox(txtTen_Nvkd) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_NvKd).Select();
		}
		return flag;
	}
}
