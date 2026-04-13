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
public class frmSIDMNTEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtTen_Nt")]
	private TextBox _txtTen_Nt;

	[AccessedThroughProperty("lblTen_Nt")]
	private Label _lblTen_Nt;

	[AccessedThroughProperty("txtMa_Nt")]
	private TextBox _txtMa_Nt;

	[AccessedThroughProperty("lblMa_Nt")]
	private Label _lblMa_Nt;

	internal virtual TextBox txtTen_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Nt = value;
		}
	}

	internal virtual Label lblTen_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nt = value;
		}
	}

	internal virtual TextBox txtMa_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Nt = value;
		}
	}

	internal virtual Label lblMa_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nt = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSIDMNTEdit()
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
		txtTen_Nt = new TextBox();
		lblTen_Nt = new Label();
		txtMa_Nt = new TextBox();
		lblMa_Nt = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Anchor = (AnchorStyles)5;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(118, 71);
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
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Nt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Nt);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Nt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Nt);
		GroupBox obj3 = gbLine;
		Size size = new Size(448, 102);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Nt, 0);
		TextBox obj4 = txtTen_Nt;
		location = new Point(118, 45);
		((Control)obj4).Location = location;
		((TextBoxBase)txtTen_Nt).MaxLength = 128;
		((Control)txtTen_Nt).Name = "txtTen_Nt";
		TextBox obj5 = txtTen_Nt;
		size = new Size(310, 20);
		((Control)obj5).Size = size;
		((Control)txtTen_Nt).TabIndex = 1;
		lblTen_Nt.AutoSize = true;
		Label obj6 = lblTen_Nt;
		location = new Point(14, 49);
		((Control)obj6).Location = location;
		((Control)lblTen_Nt).Name = "lblTen_Nt";
		Label obj7 = lblTen_Nt;
		size = new Size(67, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_Nt).TabIndex = 8;
		lblTen_Nt.Text = "Tên ngoại tệ";
		txtMa_Nt.CharacterCasing = (CharacterCasing)1;
		TextBox obj8 = txtMa_Nt;
		location = new Point(118, 19);
		((Control)obj8).Location = location;
		((TextBoxBase)txtMa_Nt).MaxLength = 3;
		((Control)txtMa_Nt).Name = "txtMa_Nt";
		TextBox obj9 = txtMa_Nt;
		size = new Size(38, 20);
		((Control)obj9).Size = size;
		((Control)txtMa_Nt).TabIndex = 0;
		lblMa_Nt.AutoSize = true;
		Label obj10 = lblMa_Nt;
		location = new Point(14, 23);
		((Control)obj10).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj11 = lblMa_Nt;
		size = new Size(63, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_Nt).TabIndex = 7;
		lblMa_Nt.Text = "Mã ngoại tệ";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(470, 145);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSIDMNTEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_Nt).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_Nt).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_Nt).Enabled = false;
		((Control)txtTen_Nt).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_Nt;
		CreateDataBinding(ref ojb, "Ma_Nt");
		txtMa_Nt = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Nt;
		CreateDataBinding(ref ojb, "Ten_Nt");
		txtTen_Nt = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		txtMa_Nt.Text = txtMa_Nt.Text.Trim();
		txtTen_Nt.Text = txtTen_Nt.Text.Trim();
		return (ChkEmtyTextBox(txtMa_Nt) && ChkEmtyTextBox(txtTen_Nt) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_Nt).Select();
		}
		else
		{
			AsiaErp.Framework.Environment.RefreshConfiguration("SIDMNT");
		}
		return flag;
	}

	protected override bool UpdateDB()
	{
		bool flag = base.UpdateDB();
		if (!flag)
		{
			((Control)txtMa_Nt).Select();
		}
		else
		{
			AsiaErp.Framework.Environment.RefreshConfiguration("SIDMNT");
		}
		return flag;
	}
}
