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
public class frmSODMTSEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_Thue")]
	private TextBox _txtMa_Thue;

	[AccessedThroughProperty("txtTen_thue")]
	private TextBox _txtTen_thue;

	[AccessedThroughProperty("lbTen_Thue")]
	private Label _lbTen_Thue;

	[AccessedThroughProperty("lblTk_Thue_co")]
	private Label _lblTk_Thue_co;

	[AccessedThroughProperty("lbMa_thue")]
	private Label _lbMa_thue;

	[AccessedThroughProperty("txtTk_Thue_Co")]
	private AsTextBox _txtTk_Thue_Co;

	[AccessedThroughProperty("lblTen_Tk_thue_co")]
	private Label _lblTen_Tk_thue_co;

	[AccessedThroughProperty("lblTS_GTGT")]
	private Label _lblTS_GTGT;

	[AccessedThroughProperty("txtTS_GTGT")]
	private AsTextNumeric _txtTS_GTGT;

	[AccessedThroughProperty("chk_KCT")]
	private CheckBox _chk_KCT;

	internal virtual TextBox txtMa_Thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Thue = value;
		}
	}

	internal virtual TextBox txtTen_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_thue = value;
		}
	}

	internal virtual Label lbTen_Thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbTen_Thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbTen_Thue = value;
		}
	}

	internal virtual Label lblTk_Thue_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Thue_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Thue_co = value;
		}
	}

	internal virtual Label lbMa_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbMa_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbMa_thue = value;
		}
	}

	internal virtual AsTextBox txtTk_Thue_Co
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Thue_Co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Thue_Co = value;
		}
	}

	internal virtual Label lblTen_Tk_thue_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_thue_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_thue_co = value;
		}
	}

	internal virtual Label lblTS_GTGT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTS_GTGT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTS_GTGT = value;
		}
	}

	internal virtual AsTextNumeric txtTS_GTGT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTS_GTGT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTS_GTGT = value;
		}
	}

	internal virtual CheckBox chk_KCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _chk_KCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chk_KCT = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSODMTSEdit()
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
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		txtMa_Thue = new TextBox();
		lbTen_Thue = new Label();
		lblTk_Thue_co = new Label();
		lbMa_thue = new Label();
		txtTen_thue = new TextBox();
		txtTk_Thue_Co = new AsTextBox();
		lblTen_Tk_thue_co = new Label();
		lblTS_GTGT = new Label();
		txtTS_GTGT = new AsTextNumeric();
		chk_KCT = new CheckBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(309, 126);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 5;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 168);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 168);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)chk_KCT);
		((Control)gbLine).Controls.Add((Control)(object)txtTS_GTGT);
		((Control)gbLine).Controls.Add((Control)(object)lblTS_GTGT);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Thue_Co);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_thue_co);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_thue);
		((Control)gbLine).Controls.Add((Control)(object)lbTen_Thue);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Thue_co);
		((Control)gbLine).Controls.Add((Control)(object)lbMa_thue);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Thue);
		GroupBox obj3 = gbLine;
		Size size = new Size(449, 155);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lbMa_thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Thue_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lbTen_Thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_thue, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_thue_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Thue_Co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTS_GTGT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTS_GTGT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chk_KCT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		TextBox obj4 = txtMa_Thue;
		location = new Point(120, 19);
		((Control)obj4).Location = location;
		((Control)txtMa_Thue).Name = "txtMa_Thue";
		TextBox obj5 = txtMa_Thue;
		size = new Size(68, 20);
		((Control)obj5).Size = size;
		((Control)txtMa_Thue).TabIndex = 0;
		lbTen_Thue.AutoSize = true;
		lbTen_Thue.ImeMode = (ImeMode)0;
		Label obj6 = lbTen_Thue;
		location = new Point(6, 49);
		((Control)obj6).Location = location;
		((Control)lbTen_Thue).Name = "lbTen_Thue";
		Label obj7 = lbTen_Thue;
		size = new Size(50, 13);
		((Control)obj7).Size = size;
		((Control)lbTen_Thue).TabIndex = 103;
		lbTen_Thue.Text = "Tên thuế";
		lblTk_Thue_co.AutoSize = true;
		lblTk_Thue_co.ImeMode = (ImeMode)0;
		Label obj8 = lblTk_Thue_co;
		location = new Point(6, 104);
		((Control)obj8).Location = location;
		((Control)lblTk_Thue_co).Name = "lblTk_Thue_co";
		Label obj9 = lblTk_Thue_co;
		size = new Size(83, 13);
		((Control)obj9).Size = size;
		((Control)lblTk_Thue_co).TabIndex = 104;
		lblTk_Thue_co.Text = "TK Thuế đầu ra";
		lbMa_thue.AutoSize = true;
		lbMa_thue.ImeMode = (ImeMode)0;
		Label obj10 = lbMa_thue;
		location = new Point(6, 23);
		((Control)obj10).Location = location;
		((Control)lbMa_thue).Name = "lbMa_thue";
		Label obj11 = lbMa_thue;
		size = new Size(46, 13);
		((Control)obj11).Size = size;
		((Control)lbMa_thue).TabIndex = 102;
		lbMa_thue.Text = "Mã thuế";
		TextBox obj12 = txtTen_thue;
		location = new Point(120, 45);
		((Control)obj12).Location = location;
		((Control)txtTen_thue).Name = "txtTen_thue";
		TextBox obj13 = txtTen_thue;
		size = new Size(287, 20);
		((Control)obj13).Size = size;
		((Control)txtTen_thue).TabIndex = 1;
		txtTk_Thue_Co.AutoLookup = true;
		txtTk_Thue_Co.AutoValid = true;
		((TextBoxBase)txtTk_Thue_Co).BackColor = SystemColors.Info;
		((TextBox)txtTk_Thue_Co).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTk_Thue_Co;
		location = new Point(120, 100);
		((Control)asTextBox).Location = location;
		txtTk_Thue_Co.LookupCodeName = "TK";
		txtTk_Thue_Co.LookupWhereCondition = "chi_tiet=1";
		((TextBoxBase)txtTk_Thue_Co).MaxLength = 20;
		((Control)txtTk_Thue_Co).Name = "txtTk_Thue_Co";
		txtTk_Thue_Co.NameControl = lblTen_Tk_thue_co;
		txtTk_Thue_Co.SD = true;
		AsTextBox asTextBox2 = txtTk_Thue_Co;
		size = new Size(68, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTk_Thue_Co).TabIndex = 3;
		((Control)txtTk_Thue_Co).Tag = "";
		txtTk_Thue_Co.UseAutoCompleteSource = true;
		lblTen_Tk_thue_co.ImeMode = (ImeMode)0;
		Label obj14 = lblTen_Tk_thue_co;
		location = new Point(187, 104);
		((Control)obj14).Location = location;
		((Control)lblTen_Tk_thue_co).Name = "lblTen_Tk_thue_co";
		Label obj15 = lblTen_Tk_thue_co;
		size = new Size(220, 13);
		((Control)obj15).Size = size;
		((Control)lblTen_Tk_thue_co).TabIndex = 210;
		lblTen_Tk_thue_co.Text = "Tên Tk thuế";
		lblTS_GTGT.AutoSize = true;
		lblTS_GTGT.ImeMode = (ImeMode)0;
		Label obj16 = lblTS_GTGT;
		location = new Point(6, 74);
		((Control)obj16).Location = location;
		((Control)lblTS_GTGT).Name = "lblTS_GTGT";
		Label obj17 = lblTS_GTGT;
		size = new Size(88, 13);
		((Control)obj17).Size = size;
		((Control)lblTS_GTGT).TabIndex = 211;
		lblTS_GTGT.Text = "Thuế suất GTGT";
		txtTS_GTGT.DecimalSymbol = ".";
		txtTS_GTGT.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtTS_GTGT;
		location = new Point(120, 71);
		((Control)asTextNumeric).Location = location;
		txtTS_GTGT.Mask = "### ### ### ###.##";
		((Control)txtTS_GTGT).Name = "txtTS_GTGT";
		AsTextNumeric asTextNumeric2 = txtTS_GTGT;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTS_GTGT).TabIndex = 2;
		((TextBox)txtTS_GTGT).Text = "0.00";
		((TextBox)txtTS_GTGT).TextAlign = (HorizontalAlignment)1;
		txtTS_GTGT.Value = 0;
		((ButtonBase)chk_KCT).AutoSize = true;
		CheckBox obj18 = chk_KCT;
		location = new Point(120, 126);
		((Control)obj18).Location = location;
		((Control)chk_KCT).Name = "chk_KCT";
		CheckBox obj19 = chk_KCT;
		size = new Size(104, 17);
		((Control)obj19).Size = size;
		((Control)chk_KCT).TabIndex = 4;
		((ButtonBase)chk_KCT).Text = "Không chịu thuế";
		((ButtonBase)chk_KCT).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(471, 198);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSODMTSEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_Thue).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_Thue).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_Thue).Enabled = false;
		((Control)txtTen_thue).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_Thue;
		CreateDataBinding(ref ojb, "Ma_Thue");
		txtMa_Thue = (TextBox)ojb;
		ojb = (Control)(object)txtTen_thue;
		CreateDataBinding(ref ojb, "Ten_Thue");
		txtTen_thue = (TextBox)ojb;
		ojb = (Control)(object)txtTS_GTGT;
		CreateDataBinding(ref ojb, "TS_GTGT", "Value");
		txtTS_GTGT = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTk_Thue_Co;
		CreateDataBinding(ref ojb, "Tk_Thue_Co");
		txtTk_Thue_Co = (AsTextBox)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chk_KCT;
		CreateDataBinding(ref ojb, "KCT", "Checked");
		chk_KCT = (CheckBox)ojb;
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox(txtMa_Thue) && ChkEmtyTextBox(txtTen_thue) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_Thue).Select();
		}
		return flag;
	}
}
