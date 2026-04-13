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
public class frmGLMAUBCTCTMVI29BEdit : frmDMComplexEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtMa_chtieu")]
	private AsTextBox _txtMa_chtieu;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtChi_tieu")]
	private TextBox _txtChi_tieu;

	[AccessedThroughProperty("txtMauQD")]
	private AsTextBox _txtMauQD;

	[AccessedThroughProperty("txtNd_chtieu")]
	private TextBox _txtNd_chtieu;

	[AccessedThroughProperty("lblID")]
	private Label _lblID;

	[AccessedThroughProperty("ChkIs_italic")]
	private CheckBox _ChkIs_italic;

	[AccessedThroughProperty("ChkIs_print")]
	private CheckBox _ChkIs_print;

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

	internal virtual AsTextBox txtMa_chtieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_chtieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_chtieu = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
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

	internal virtual TextBox txtChi_tieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtChi_tieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtChi_tieu = value;
		}
	}

	internal virtual AsTextBox txtMauQD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMauQD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMauQD = value;
		}
	}

	internal virtual TextBox txtNd_chtieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNd_chtieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNd_chtieu = value;
		}
	}

	internal virtual Label lblID
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblID = value;
		}
	}

	internal virtual CheckBox ChkIs_italic
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkIs_italic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkIs_italic = value;
		}
	}

	internal virtual CheckBox ChkIs_print
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkIs_print;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkIs_print = value;
		}
	}

	[DebuggerNonUserCode]
	public frmGLMAUBCTCTMVI29BEdit()
	{
		((Form)this).Load += frmGLMAUBCTCTMVI29BEdit_Load;
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
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		Label4 = new Label();
		txtMa_chtieu = new AsTextBox();
		txtChi_tieu = new TextBox();
		txtMauQD = new AsTextBox();
		lblID = new Label();
		txtNd_chtieu = new TextBox();
		ChkIs_print = new CheckBox();
		ChkIs_italic = new CheckBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(263, 258);
		((Control)asCheckBox).Location = location;
		AsCheckBox asCheckBox2 = chkKsd;
		Size size = new Size(59, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkKsd).TabIndex = 5;
		((Control)chkKsd).TabStop = true;
		((ButtonBase)chkKsd).Text = "In đậm";
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(97, 303);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(16, 303);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)ChkIs_italic);
		((Control)gbLine).Controls.Add((Control)(object)ChkIs_print);
		((Control)gbLine).Controls.Add((Control)(object)txtNd_chtieu);
		((Control)gbLine).Controls.Add((Control)(object)txtChi_tieu);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_chtieu);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		GroupBox obj3 = gbLine;
		location = new Point(12, 12);
		((Control)obj3).Location = location;
		GroupBox obj4 = gbLine;
		size = new Size(630, 285);
		((Control)obj4).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_chtieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtChi_tieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNd_chtieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)ChkIs_print, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)ChkIs_italic, 0);
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(20, 23);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(59, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 100;
		Label1.Text = "Mã chỉ tiêu";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(20, 49);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(42, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 101;
		Label2.Text = "Chỉ tiêu";
		Label4.AutoSize = true;
		Label label5 = Label4;
		location = new Point(20, 72);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		Label label6 = Label4;
		size = new Size(87, 13);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 103;
		Label4.Text = "Nội dung chỉ tiêu";
		txtMa_chtieu.AutoLookup = false;
		txtMa_chtieu.AutoValid = false;
		((TextBoxBase)txtMa_chtieu).BackColor = SystemColors.Window;
		((TextBox)txtMa_chtieu).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_chtieu;
		location = new Point(125, 19);
		((Control)asTextBox).Location = location;
		txtMa_chtieu.LookupCodeName = "";
		((Control)txtMa_chtieu).Name = "txtMa_chtieu";
		txtMa_chtieu.NameControl = null;
		AsTextBox asTextBox2 = txtMa_chtieu;
		size = new Size(71, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_chtieu).TabIndex = 0;
		txtMa_chtieu.UseAutoCompleteSource = true;
		TextBox obj5 = txtChi_tieu;
		location = new Point(125, 45);
		((Control)obj5).Location = location;
		((Control)txtChi_tieu).Name = "txtChi_tieu";
		TextBox obj6 = txtChi_tieu;
		size = new Size(484, 20);
		((Control)obj6).Size = size;
		((Control)txtChi_tieu).TabIndex = 1;
		txtMauQD.AutoLookup = false;
		txtMauQD.AutoValid = false;
		((TextBoxBase)txtMauQD).BackColor = SystemColors.Window;
		((TextBox)txtMauQD).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMauQD;
		location = new Point(566, 22);
		((Control)asTextBox3).Location = location;
		txtMauQD.LookupCodeName = "";
		((Control)txtMauQD).Name = "txtMauQD";
		txtMauQD.NameControl = null;
		AsTextBox asTextBox4 = txtMauQD;
		size = new Size(70, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMauQD).TabIndex = 204;
		((Control)txtMauQD).TabStop = false;
		txtMauQD.UseAutoCompleteSource = true;
		Label obj7 = lblID;
		location = new Point(460, 22);
		((Control)obj7).Location = location;
		((Control)lblID).Name = "lblID";
		Label obj8 = lblID;
		size = new Size(100, 20);
		((Control)obj8).Size = size;
		((Control)lblID).TabIndex = 104;
		TextBox obj9 = txtNd_chtieu;
		location = new Point(125, 75);
		((Control)obj9).Location = location;
		txtNd_chtieu.Multiline = true;
		((Control)txtNd_chtieu).Name = "txtNd_chtieu";
		txtNd_chtieu.ScrollBars = (ScrollBars)2;
		TextBox obj10 = txtNd_chtieu;
		size = new Size(484, 177);
		((Control)obj10).Size = size;
		((Control)txtNd_chtieu).TabIndex = 2;
		((ButtonBase)ChkIs_print).AutoSize = true;
		CheckBox chkIs_print = ChkIs_print;
		location = new Point(125, 258);
		((Control)chkIs_print).Location = location;
		((Control)ChkIs_print).Name = "ChkIs_print";
		CheckBox chkIs_print2 = ChkIs_print;
		size = new Size(50, 17);
		((Control)chkIs_print2).Size = size;
		((Control)ChkIs_print).TabIndex = 3;
		((ButtonBase)ChkIs_print).Text = "Có in";
		((ButtonBase)ChkIs_print).UseVisualStyleBackColor = true;
		((ButtonBase)ChkIs_italic).AutoSize = true;
		CheckBox chkIs_italic = ChkIs_italic;
		location = new Point(181, 258);
		((Control)chkIs_italic).Location = location;
		((Control)ChkIs_italic).Name = "ChkIs_italic";
		CheckBox chkIs_italic2 = ChkIs_italic;
		size = new Size(76, 17);
		((Control)chkIs_italic2).Size = size;
		((Control)ChkIs_italic).TabIndex = 4;
		((ButtonBase)ChkIs_italic).Text = "In nghiêng";
		((ButtonBase)ChkIs_italic).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(654, 338);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtMauQD);
		((Control)this).Controls.Add((Control)(object)lblID);
		((Control)this).Name = "frmGLMAUBCTCTMIEdit";
		((Control)this).Controls.SetChildIndex((Control)(object)lblID, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtMauQD, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSave, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbLine, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_chtieu).MaxLength = base.MyDictComplexInfo.code_length;
		((Control)txtMa_chtieu).Select();
	}

	protected override bool ValidData()
	{
		txtNd_chtieu.Text = txtNd_chtieu.Text.Trim();
		if (Operators.CompareString(((TextBox)txtMauQD).Text.Trim(), "", false) == 0)
		{
			((TextBox)txtMauQD).Text = CompanyInformations.Qd_cdkt;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_chtieu))
		{
			epNotice.SetError((Control)(object)txtMa_chtieu, Helper.GetMess(50002).Description);
			return false;
		}
		if (!ChkEmtyTextBox(txtChi_tieu))
		{
			epNotice.SetError((Control)(object)txtChi_tieu, Helper.GetMess(50002).Description);
			return false;
		}
		return base.ValidData();
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_chtieu).Select();
		}
		return flag;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMauQD).Enabled = false;
		((Control)txtMa_chtieu).Enabled = false;
		((Control)txtChi_tieu).Select();
	}

	protected override void DataBinding()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMauQD;
		CreateDataBinding(ref ojb, "mau");
		txtMauQD = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_chtieu;
		CreateDataBinding(ref ojb, "ma_so");
		txtMa_chtieu = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtChi_tieu;
		CreateDataBinding(ref ojb, "chi_tieu");
		txtChi_tieu = (TextBox)ojb;
		ojb = (Control)(object)txtNd_chtieu;
		CreateDataBinding(ref ojb, "nd_chtieu");
		txtNd_chtieu = (TextBox)ojb;
		ojb = (Control)(object)ChkIs_italic;
		CreateDataBinding(ref ojb, "IsItalic", "Checked");
		ChkIs_italic = (CheckBox)ojb;
		ojb = (Control)(object)ChkIs_print;
		CreateDataBinding(ref ojb, "IsPrint", "Checked");
		ChkIs_print = (CheckBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "bold", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	private void frmGLMAUBCTCTMVI29BEdit_Load(object sender, EventArgs e)
	{
		if (!EditMode)
		{
			ChkIs_print.Checked = true;
		}
	}

	protected override bool ProcessKeyPreview(ref Message m)
	{
		if (!((Control)txtNd_chtieu).Focused)
		{
			return base.ProcessKeyPreview(ref m);
		}
		bool result = default(bool);
		return result;
	}
}
