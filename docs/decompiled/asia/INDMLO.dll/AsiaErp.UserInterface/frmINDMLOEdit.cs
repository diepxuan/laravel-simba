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
public class frmINDMLOEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtTen_Lo")]
	private TextBox _txtTen_Lo;

	[AccessedThroughProperty("lblTen_Lo")]
	private Label _lblTen_Lo;

	[AccessedThroughProperty("txtMa_Lo")]
	private TextBox _txtMa_Lo;

	[AccessedThroughProperty("lblMa_Lo")]
	private Label _lblMa_Lo;

	[AccessedThroughProperty("txtTrang_thai")]
	private TextBox _txtTrang_thai;

	[AccessedThroughProperty("txtHan_dung")]
	private AsMaskedTextBox _txtHan_dung;

	[AccessedThroughProperty("lblTrang_thai")]
	private Label _lblTrang_thai;

	[AccessedThroughProperty("lblHan_dung")]
	private Label _lblHan_dung;

	internal virtual TextBox txtTen_Lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Lo = value;
		}
	}

	internal virtual Label lblTen_Lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Lo = value;
		}
	}

	internal virtual TextBox txtMa_Lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Lo = value;
		}
	}

	internal virtual Label lblMa_Lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Lo = value;
		}
	}

	internal virtual TextBox txtTrang_thai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTrang_thai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTrang_thai = value;
		}
	}

	internal virtual AsMaskedTextBox txtHan_dung
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHan_dung;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtHan_dung = value;
		}
	}

	internal virtual Label lblTrang_thai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTrang_thai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTrang_thai = value;
		}
	}

	internal virtual Label lblHan_dung
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblHan_dung;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblHan_dung = value;
		}
	}

	[DebuggerNonUserCode]
	public frmINDMLOEdit()
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
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		txtTen_Lo = new TextBox();
		lblTen_Lo = new Label();
		txtMa_Lo = new TextBox();
		lblMa_Lo = new Label();
		lblHan_dung = new Label();
		txtHan_dung = new AsMaskedTextBox();
		txtTrang_thai = new TextBox();
		lblTrang_thai = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(104, 126);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 4;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 161);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 161);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtTrang_thai);
		((Control)gbLine).Controls.Add((Control)(object)txtHan_dung);
		((Control)gbLine).Controls.Add((Control)(object)lblTrang_thai);
		((Control)gbLine).Controls.Add((Control)(object)lblHan_dung);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Lo);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Lo);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Lo);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Lo);
		GroupBox obj3 = gbLine;
		Size size = new Size(433, 149);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Lo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Lo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Lo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Lo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblHan_dung, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTrang_thai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtHan_dung, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTrang_thai, 0);
		TextBox obj4 = txtTen_Lo;
		location = new Point(104, 45);
		((Control)obj4).Location = location;
		((TextBoxBase)txtTen_Lo).MaxLength = 50;
		((Control)txtTen_Lo).Name = "txtTen_Lo";
		TextBox obj5 = txtTen_Lo;
		size = new Size(313, 20);
		((Control)obj5).Size = size;
		((Control)txtTen_Lo).TabIndex = 1;
		lblTen_Lo.AutoSize = true;
		Label obj6 = lblTen_Lo;
		location = new Point(12, 49);
		((Control)obj6).Location = location;
		((Control)lblTen_Lo).Name = "lblTen_Lo";
		Label obj7 = lblTen_Lo;
		size = new Size(37, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_Lo).TabIndex = 8;
		lblTen_Lo.Text = "Tên lô";
		txtMa_Lo.CharacterCasing = (CharacterCasing)1;
		TextBox obj8 = txtMa_Lo;
		location = new Point(104, 19);
		((Control)obj8).Location = location;
		((TextBoxBase)txtMa_Lo).MaxLength = 20;
		((Control)txtMa_Lo).Name = "txtMa_Lo";
		TextBox obj9 = txtMa_Lo;
		size = new Size(98, 20);
		((Control)obj9).Size = size;
		((Control)txtMa_Lo).TabIndex = 0;
		lblMa_Lo.AutoSize = true;
		Label obj10 = lblMa_Lo;
		location = new Point(12, 22);
		((Control)obj10).Location = location;
		((Control)lblMa_Lo).Name = "lblMa_Lo";
		Label obj11 = lblMa_Lo;
		size = new Size(33, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_Lo).TabIndex = 7;
		lblMa_Lo.Text = "Mã lô";
		lblHan_dung.AutoSize = true;
		Label obj12 = lblHan_dung;
		location = new Point(12, 77);
		((Control)obj12).Location = location;
		((Control)lblHan_dung).Name = "lblHan_dung";
		Label obj13 = lblHan_dung;
		size = new Size(54, 13);
		((Control)obj13).Size = size;
		((Control)lblHan_dung).TabIndex = 9;
		lblHan_dung.Text = "Hạn dùng";
		txtHan_dung.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtHan_dung).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtHan_dung;
		location = new Point(104, 73);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtHan_dung).Mask = "##/##/####";
		((Control)txtHan_dung).Name = "txtHan_dung";
		((MaskedTextBox)txtHan_dung).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtHan_dung;
		size = new Size(98, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtHan_dung).TabIndex = 2;
		AsMaskedTextBox asMaskedTextBox3 = txtHan_dung;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		TextBox obj14 = txtTrang_thai;
		location = new Point(104, 101);
		((Control)obj14).Location = location;
		((Control)txtTrang_thai).Name = "txtTrang_thai";
		TextBox obj15 = txtTrang_thai;
		size = new Size(98, 20);
		((Control)obj15).Size = size;
		((Control)txtTrang_thai).TabIndex = 3;
		lblTrang_thai.AutoSize = true;
		Label obj16 = lblTrang_thai;
		location = new Point(12, 105);
		((Control)obj16).Location = location;
		((Control)lblTrang_thai).Name = "lblTrang_thai";
		Label obj17 = lblTrang_thai;
		size = new Size(55, 13);
		((Control)obj17).Size = size;
		((Control)lblTrang_thai).TabIndex = 9;
		lblTrang_thai.Text = "Trạng thái";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(455, 191);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmINDMLOEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_Lo).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_Lo).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_Lo).Enabled = false;
		((Control)txtTen_Lo).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_Lo;
		CreateDataBinding(ref ojb, "Ma_Lo");
		txtMa_Lo = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Lo;
		CreateDataBinding(ref ojb, "Ten_Lo");
		txtTen_Lo = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)txtHan_dung;
		CreateDataBinding(ref ojb, "han_dung", "Value");
		txtHan_dung = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtTrang_thai;
		CreateDataBinding(ref ojb, "trang_thai");
		txtTrang_thai = (TextBox)ojb;
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox(txtMa_Lo) && ChkEmtyTextBox(txtTen_Lo) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_Lo).Select();
		}
		return flag;
	}
}
