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
public class frmINDMPLVTEdit : frmDMComplexEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtTen_PlVt")]
	private TextBox _txtTen_PlVt;

	[AccessedThroughProperty("lblTen_PlVt")]
	private Label _lblTen_PlVt;

	[AccessedThroughProperty("txtMa_PlVt")]
	private TextBox _txtMa_PlVt;

	[AccessedThroughProperty("lblMa_PlVt")]
	private Label _lblMa_PlVt;

	[AccessedThroughProperty("lblLoai")]
	private Label _lblLoai;

	[AccessedThroughProperty("cboLoai")]
	private ComboBox _cboLoai;

	internal virtual TextBox txtTen_PlVt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_PlVt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_PlVt = value;
		}
	}

	internal virtual Label lblTen_PlVt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_PlVt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_PlVt = value;
		}
	}

	internal virtual TextBox txtMa_PlVt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_PlVt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_PlVt = value;
		}
	}

	internal virtual Label lblMa_PlVt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_PlVt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_PlVt = value;
		}
	}

	internal virtual Label lblLoai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai = value;
		}
	}

	internal virtual ComboBox cboLoai
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai = value;
		}
	}

	[DebuggerNonUserCode]
	public frmINDMPLVTEdit()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
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
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		txtTen_PlVt = new TextBox();
		lblTen_PlVt = new Label();
		txtMa_PlVt = new TextBox();
		lblMa_PlVt = new Label();
		lblLoai = new Label();
		cboLoai = new ComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(97, 98);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 3;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 136);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 136);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)cboLoai);
		((Control)gbLine).Controls.Add((Control)(object)lblLoai);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_PlVt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_PlVt);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_PlVt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_PlVt);
		GroupBox obj3 = gbLine;
		Size size = new Size(399, 123);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_PlVt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_PlVt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_PlVt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_PlVt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblLoai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai, 0);
		TextBox obj4 = txtTen_PlVt;
		location = new Point(97, 45);
		((Control)obj4).Location = location;
		((TextBoxBase)txtTen_PlVt).MaxLength = 50;
		((Control)txtTen_PlVt).Name = "txtTen_PlVt";
		TextBox obj5 = txtTen_PlVt;
		size = new Size(271, 20);
		((Control)obj5).Size = size;
		((Control)txtTen_PlVt).TabIndex = 1;
		lblTen_PlVt.AutoSize = true;
		Label obj6 = lblTen_PlVt;
		location = new Point(19, 49);
		((Control)obj6).Location = location;
		((Control)lblTen_PlVt).Name = "lblTen_PlVt";
		Label obj7 = lblTen_PlVt;
		size = new Size(72, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_PlVt).TabIndex = 103;
		lblTen_PlVt.Text = "Tên phân loại";
		txtMa_PlVt.CharacterCasing = (CharacterCasing)1;
		TextBox obj8 = txtMa_PlVt;
		location = new Point(97, 19);
		((Control)obj8).Location = location;
		((Control)txtMa_PlVt).Name = "txtMa_PlVt";
		TextBox obj9 = txtMa_PlVt;
		size = new Size(80, 20);
		((Control)obj9).Size = size;
		((Control)txtMa_PlVt).TabIndex = 0;
		lblMa_PlVt.AutoSize = true;
		Label obj10 = lblMa_PlVt;
		location = new Point(19, 23);
		((Control)obj10).Location = location;
		((Control)lblMa_PlVt).Name = "lblMa_PlVt";
		Label obj11 = lblMa_PlVt;
		size = new Size(68, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_PlVt).TabIndex = 102;
		lblMa_PlVt.Text = "Mã phân loại";
		lblLoai.AutoSize = true;
		Label obj12 = lblLoai;
		location = new Point(19, 75);
		((Control)obj12).Location = location;
		((Control)lblLoai).Name = "lblLoai";
		Label obj13 = lblLoai;
		size = new Size(28, 13);
		((Control)obj13).Size = size;
		((Control)lblLoai).TabIndex = 104;
		lblLoai.Text = "Kiểu";
		cboLoai.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai).FormattingEnabled = true;
		cboLoai.Items.AddRange(new object[3] { "1", "2", "3" });
		ComboBox obj14 = cboLoai;
		location = new Point(97, 71);
		((Control)obj14).Location = location;
		((Control)cboLoai).Name = "cboLoai";
		ComboBox obj15 = cboLoai;
		size = new Size(51, 21);
		((Control)obj15).Size = size;
		((Control)cboLoai).TabIndex = 2;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(421, 166);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmINDMPLVTEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		cboLoai.SelectedIndex = 0;
		((TextBoxBase)txtMa_PlVt).MaxLength = base.MyDictComplexInfo.code_length;
		((Control)txtMa_PlVt).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_PlVt).Enabled = false;
		((Control)cboLoai).Enabled = false;
		((Control)txtTen_PlVt).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_PlVt;
		CreateDataBinding(ref ojb, "Ma_PlVt");
		txtMa_PlVt = (TextBox)ojb;
		ojb = (Control)(object)txtTen_PlVt;
		CreateDataBinding(ref ojb, "Ten_PlVt");
		txtTen_PlVt = (TextBox)ojb;
		ojb = (Control)(object)cboLoai;
		CreateDataBinding(ref ojb, "Loai");
		cboLoai = (ComboBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox(txtMa_PlVt) && ChkEmtyTextBox(txtTen_PlVt) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_PlVt).Select();
		}
		return flag;
	}
}
