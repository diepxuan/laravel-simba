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
public class frmFADMLDTGEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cboTg")]
	private AsComboBox _cboTg;

	[AccessedThroughProperty("txtMa_lydo")]
	private TextBox _txtMa_lydo;

	[AccessedThroughProperty("txtTen_lydo")]
	private TextBox _txtTen_lydo;

	[AccessedThroughProperty("lblTen_ly_do")]
	private Label _lblTen_ly_do;

	[AccessedThroughProperty("lblMa_ly_do")]
	private Label _lblMa_ly_do;

	[AccessedThroughProperty("lblKieu_TG")]
	private Label _lblKieu_TG;

	internal virtual AsComboBox cboTg
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboTg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboTg = value;
		}
	}

	internal virtual TextBox txtMa_lydo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_lydo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_lydo = value;
		}
	}

	internal virtual TextBox txtTen_lydo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_lydo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_lydo = value;
		}
	}

	internal virtual Label lblTen_ly_do
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ly_do;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ly_do = value;
		}
	}

	internal virtual Label lblMa_ly_do
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_ly_do;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_ly_do = value;
		}
	}

	internal virtual Label lblKieu_TG
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblKieu_TG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblKieu_TG = value;
		}
	}

	[DebuggerNonUserCode]
	public frmFADMLDTGEdit()
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		lblMa_ly_do = new Label();
		txtMa_lydo = new TextBox();
		lblTen_ly_do = new Label();
		txtTen_lydo = new TextBox();
		cboTg = new AsComboBox();
		lblKieu_TG = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(106, 95);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 3;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 129);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 129);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblKieu_TG);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_lydo);
		((Control)gbLine).Controls.Add((Control)(object)cboTg);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_ly_do);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_lydo);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_ly_do);
		GroupBox obj3 = gbLine;
		Size size = new Size(407, 117);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_ly_do, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_lydo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_ly_do, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboTg, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_lydo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblKieu_TG, 0);
		lblMa_ly_do.AutoSize = true;
		Label obj4 = lblMa_ly_do;
		location = new Point(23, 20);
		((Control)obj4).Location = location;
		((Control)lblMa_ly_do).Name = "lblMa_ly_do";
		Label obj5 = lblMa_ly_do;
		size = new Size(47, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_ly_do).TabIndex = 100;
		lblMa_ly_do.Text = "Mã lý do";
		txtMa_lydo.CharacterCasing = (CharacterCasing)1;
		TextBox obj6 = txtMa_lydo;
		location = new Point(106, 16);
		((Control)obj6).Location = location;
		((Control)txtMa_lydo).Name = "txtMa_lydo";
		TextBox obj7 = txtMa_lydo;
		size = new Size(90, 20);
		((Control)obj7).Size = size;
		((Control)txtMa_lydo).TabIndex = 0;
		lblTen_ly_do.AutoSize = true;
		Label obj8 = lblTen_ly_do;
		location = new Point(23, 45);
		((Control)obj8).Location = location;
		((Control)lblTen_ly_do).Name = "lblTen_ly_do";
		Label obj9 = lblTen_ly_do;
		size = new Size(51, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_ly_do).TabIndex = 100;
		lblTen_ly_do.Text = "Tên lý do";
		TextBox obj10 = txtTen_lydo;
		location = new Point(106, 41);
		((Control)obj10).Location = location;
		((Control)txtTen_lydo).Name = "txtTen_lydo";
		TextBox obj11 = txtTen_lydo;
		size = new Size(288, 20);
		((Control)obj11).Size = size;
		((Control)txtTen_lydo).TabIndex = 1;
		((ComboBox)cboTg).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboTg).FormattingEnabled = true;
		((ComboBox)cboTg).Items.AddRange(new object[2] { "T - Tăng", "G - Giảm" });
		AsComboBox asComboBox = cboTg;
		location = new Point(106, 66);
		((Control)asComboBox).Location = location;
		((Control)cboTg).Name = "cboTg";
		AsComboBox asComboBox2 = cboTg;
		size = new Size(90, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboTg).TabIndex = 2;
		lblKieu_TG.AutoSize = true;
		Label obj12 = lblKieu_TG;
		location = new Point(23, 70);
		((Control)obj12).Location = location;
		((Control)lblKieu_TG).Name = "lblKieu_TG";
		Label obj13 = lblKieu_TG;
		size = new Size(77, 13);
		((Control)obj13).Size = size;
		((Control)lblKieu_TG).TabIndex = 103;
		lblKieu_TG.Text = "Kiểu tăng giảm";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(431, 164);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFADMLDTGEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_lydo).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_lydo).Select();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		AsComboBox asComboBox = cboTg;
		dictionary.Add("T", Conversions.ToString(((ComboBox)asComboBox).Items[0]));
		dictionary.Add("G", Conversions.ToString(((ComboBox)asComboBox).Items[1]));
		BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
		((ListControl)asComboBox).DisplayMember = "value";
		((ListControl)asComboBox).ValueMember = "key";
		((ComboBox)asComboBox).DataSource = dataSource;
		asComboBox = null;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			((ComboBox)cboTg).SelectedIndex = 0;
		}
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_lydo;
		CreateDataBinding(ref ojb, "ma_ldtg");
		txtMa_lydo = (TextBox)ojb;
		ojb = (Control)(object)txtTen_lydo;
		CreateDataBinding(ref ojb, "ten_ldtg");
		txtTen_lydo = (TextBox)ojb;
		ojb = (Control)(object)cboTg;
		CreateDataBinding(ref ojb, "tg", "SelectedValue");
		cboTg = (AsComboBox)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "ksd", "checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((TextBoxBase)txtMa_lydo).ReadOnly = true;
		((Control)txtTen_lydo).Select();
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox(txtMa_lydo) && ChkEmtyTextBox(txtTen_lydo) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_lydo).Select();
		}
		return flag;
	}
}
