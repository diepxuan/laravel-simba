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
public class frmFADMBPSDEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_Bp")]
	private TextBox _txtMa_Bp;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

	[AccessedThroughProperty("txtTen_Bp")]
	private TextBox _txtTen_Bp;

	internal virtual TextBox txtMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Bp = value;
		}
	}

	internal virtual Label lblMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Bp = value;
		}
	}

	internal virtual Label lblTen_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Bp = value;
		}
	}

	internal virtual TextBox txtTen_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Bp = value;
		}
	}

	[DebuggerNonUserCode]
	public frmFADMBPSDEdit()
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
		lblMa_Bp = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new TextBox();
		txtTen_Bp = new TextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(84, 81);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 123);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 123);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Bp);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Bp);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Bp);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Bp);
		GroupBox obj3 = gbLine;
		Size size = new Size(418, 111);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Bp, 0);
		lblMa_Bp.AutoSize = true;
		Label obj4 = lblMa_Bp;
		location = new Point(14, 32);
		((Control)obj4).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj5 = lblMa_Bp;
		size = new Size(64, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_Bp).TabIndex = 100;
		lblMa_Bp.Text = "Mã bộ phận";
		lblTen_Bp.AutoSize = true;
		Label obj6 = lblTen_Bp;
		location = new Point(14, 59);
		((Control)obj6).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj7 = lblTen_Bp;
		size = new Size(68, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_Bp).TabIndex = 101;
		lblTen_Bp.Text = "Tên bộ phận";
		txtMa_Bp.CharacterCasing = (CharacterCasing)1;
		TextBox obj8 = txtMa_Bp;
		location = new Point(84, 29);
		((Control)obj8).Location = location;
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		TextBox obj9 = txtMa_Bp;
		size = new Size(117, 20);
		((Control)obj9).Size = size;
		((Control)txtMa_Bp).TabIndex = 0;
		TextBox obj10 = txtTen_Bp;
		location = new Point(84, 55);
		((Control)obj10).Location = location;
		((TextBoxBase)txtTen_Bp).MaxLength = 50;
		((Control)txtTen_Bp).Name = "txtTen_Bp";
		TextBox obj11 = txtTen_Bp;
		size = new Size(320, 20);
		((Control)obj11).Size = size;
		((Control)txtTen_Bp).TabIndex = 1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(442, 158);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFADMBPSDEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_Bp).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_Bp).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_Bp;
		CreateDataBinding(ref ojb, "ma_bpsd");
		txtMa_Bp = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Bp;
		CreateDataBinding(ref ojb, "ten_bpsd");
		txtTen_Bp = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "ksd", "checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((TextBoxBase)txtMa_Bp).ReadOnly = true;
		((Control)txtTen_Bp).Select();
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox(txtMa_Bp) && ChkEmtyTextBox(txtTen_Bp) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_Bp).Select();
		}
		return flag;
	}
}
