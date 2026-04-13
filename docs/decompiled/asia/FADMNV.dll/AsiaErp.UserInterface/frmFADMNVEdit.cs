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
public class frmFADMNVEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_nv")]
	private TextBox _txtMa_nv;

	[AccessedThroughProperty("txtTen_nv")]
	private TextBox _txtTen_nv;

	[AccessedThroughProperty("lblTen_nv")]
	private Label _lblTen_nv;

	[AccessedThroughProperty("lblMA_NV")]
	private Label _lblMA_NV;

	internal virtual TextBox txtMa_nv
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nv = value;
		}
	}

	internal virtual TextBox txtTen_nv
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_nv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_nv = value;
		}
	}

	internal virtual Label lblTen_nv
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nv = value;
		}
	}

	internal virtual Label lblMA_NV
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMA_NV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMA_NV = value;
		}
	}

	[DebuggerNonUserCode]
	public frmFADMNVEdit()
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
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		lblMA_NV = new Label();
		txtMa_nv = new TextBox();
		lblTen_nv = new Label();
		txtTen_nv = new TextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(88, 71);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 106);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 106);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblMA_NV);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_nv);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_nv);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_nv);
		GroupBox obj3 = gbLine;
		Size size = new Size(371, 94);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_nv, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_nv, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_nv, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMA_NV, 0);
		lblMA_NV.AutoSize = true;
		Label obj4 = lblMA_NV;
		location = new Point(6, 24);
		((Control)obj4).Location = location;
		((Control)lblMA_NV).Name = "lblMA_NV";
		Label obj5 = lblMA_NV;
		size = new Size(76, 13);
		((Control)obj5).Size = size;
		((Control)lblMA_NV).TabIndex = 100;
		lblMA_NV.Text = "Mã nguồn vốn";
		txtMa_nv.CharacterCasing = (CharacterCasing)1;
		TextBox obj6 = txtMa_nv;
		location = new Point(88, 20);
		((Control)obj6).Location = location;
		((Control)txtMa_nv).Name = "txtMa_nv";
		TextBox obj7 = txtMa_nv;
		size = new Size(85, 20);
		((Control)obj7).Size = size;
		((Control)txtMa_nv).TabIndex = 0;
		lblTen_nv.AutoSize = true;
		Label obj8 = lblTen_nv;
		location = new Point(6, 49);
		((Control)obj8).Location = location;
		((Control)lblTen_nv).Name = "lblTen_nv";
		Label obj9 = lblTen_nv;
		size = new Size(80, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_nv).TabIndex = 100;
		lblTen_nv.Text = "Tên nguồn vốn";
		TextBox obj10 = txtTen_nv;
		location = new Point(88, 45);
		((Control)obj10).Location = location;
		((Control)txtTen_nv).Name = "txtTen_nv";
		TextBox obj11 = txtTen_nv;
		size = new Size(262, 20);
		((Control)obj11).Size = size;
		((Control)txtTen_nv).TabIndex = 1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(395, 141);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFADMNVEdit";
		((Form)this).Text = "frmDADMNVEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_nv).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_nv).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_nv;
		CreateDataBinding(ref ojb, "ma_nv");
		txtMa_nv = (TextBox)ojb;
		ojb = (Control)(object)txtTen_nv;
		CreateDataBinding(ref ojb, "ten_nv");
		txtTen_nv = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "ksd", "checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_nv).Enabled = false;
		((Control)txtTen_nv).Select();
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox(txtMa_nv) && ChkEmtyTextBox(txtTen_nv) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_nv).Select();
		}
		return flag;
	}
}
