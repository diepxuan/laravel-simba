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
public class frmARDMNHKHEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtTen_Nhkh")]
	private TextBox _txtTen_Nhkh;

	[AccessedThroughProperty("lblTen_Nhkh")]
	private Label _lblTen_Nhkh;

	[AccessedThroughProperty("txtMa_Nhkh")]
	private TextBox _txtMa_Nhkh;

	[AccessedThroughProperty("lblMa_Nhkh")]
	private Label _lblMa_Nhkh;

	internal virtual TextBox txtTen_Nhkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Nhkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Nhkh = value;
		}
	}

	internal virtual Label lblTen_Nhkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhkh = value;
		}
	}

	internal virtual TextBox txtMa_Nhkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Nhkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Nhkh = value;
		}
	}

	internal virtual Label lblMa_Nhkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nhkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nhkh = value;
		}
	}

	[DebuggerNonUserCode]
	public frmARDMNHKHEdit()
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
		txtTen_Nhkh = new TextBox();
		lblTen_Nhkh = new Label();
		txtMa_Nhkh = new TextBox();
		lblMa_Nhkh = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Anchor = (AnchorStyles)5;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(94, 71);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 115);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 115);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Nhkh);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Nhkh);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Nhkh);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Nhkh);
		GroupBox obj3 = gbLine;
		Size size = new Size(447, 102);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Nhkh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Nhkh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Nhkh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Nhkh, 0);
		TextBox obj4 = txtTen_Nhkh;
		location = new Point(94, 45);
		((Control)obj4).Location = location;
		((TextBoxBase)txtTen_Nhkh).MaxLength = 128;
		((Control)txtTen_Nhkh).Name = "txtTen_Nhkh";
		TextBox obj5 = txtTen_Nhkh;
		size = new Size(336, 20);
		((Control)obj5).Size = size;
		((Control)txtTen_Nhkh).TabIndex = 1;
		lblTen_Nhkh.AutoSize = true;
		Label obj6 = lblTen_Nhkh;
		location = new Point(10, 45);
		((Control)obj6).Location = location;
		((Control)lblTen_Nhkh).Name = "lblTen_Nhkh";
		Label obj7 = lblTen_Nhkh;
		size = new Size(55, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_Nhkh).TabIndex = 18;
		lblTen_Nhkh.Text = "Tên nhóm";
		txtMa_Nhkh.CharacterCasing = (CharacterCasing)1;
		TextBox obj8 = txtMa_Nhkh;
		location = new Point(94, 19);
		((Control)obj8).Location = location;
		((Control)txtMa_Nhkh).Name = "txtMa_Nhkh";
		TextBox obj9 = txtMa_Nhkh;
		size = new Size(98, 20);
		((Control)obj9).Size = size;
		((Control)txtMa_Nhkh).TabIndex = 0;
		lblMa_Nhkh.AutoSize = true;
		Label obj10 = lblMa_Nhkh;
		location = new Point(10, 23);
		((Control)obj10).Location = location;
		((Control)lblMa_Nhkh).Name = "lblMa_Nhkh";
		Label obj11 = lblMa_Nhkh;
		size = new Size(51, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_Nhkh).TabIndex = 17;
		lblMa_Nhkh.Text = "Mã nhóm";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(469, 145);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmARDMNHKHEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_Nhkh).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_Nhkh).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_Nhkh).Enabled = false;
		((Control)txtTen_Nhkh).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_Nhkh;
		CreateDataBinding(ref ojb, "Ma_NhKh");
		txtMa_Nhkh = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Nhkh;
		CreateDataBinding(ref ojb, "Ten_NhKh");
		txtTen_Nhkh = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		return (Commons.ChkEmtyTextBoxAndShowMessageBox(txtMa_Nhkh) && Commons.ChkEmtyTextBoxAndShowMessageBox(txtTen_Nhkh) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_Nhkh).Select();
		}
		return flag;
	}
}
