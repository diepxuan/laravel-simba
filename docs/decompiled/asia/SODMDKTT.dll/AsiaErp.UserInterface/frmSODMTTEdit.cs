using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSODMTTEdit : frmDMEdit
{
	private IContainer components;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtTyle_CK")]
	private AsTextNumeric _txtTyle_CK;

	[AccessedThroughProperty("txtLai_QH")]
	private AsTextNumeric _txtLai_QH;

	[AccessedThroughProperty("txtHan_CK")]
	private AsTextNumeric _txtHan_CK;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("txtHan_TT")]
	private AsTextNumeric _txtHan_TT;

	[AccessedThroughProperty("txtMo_Ta")]
	private AsTextBox _txtMo_Ta;

	[AccessedThroughProperty("txtMa_TT")]
	private TextBox _txtMa_TT;

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
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

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
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

	internal virtual AsTextNumeric txtTyle_CK
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTyle_CK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtTyle_CK_TextChanged;
			if (_txtTyle_CK != null)
			{
				((Control)_txtTyle_CK).TextChanged -= eventHandler;
			}
			_txtTyle_CK = value;
			if (_txtTyle_CK != null)
			{
				((Control)_txtTyle_CK).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtLai_QH
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLai_QH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtLai_QH_TextChanged;
			if (_txtLai_QH != null)
			{
				((Control)_txtLai_QH).TextChanged -= eventHandler;
			}
			_txtLai_QH = value;
			if (_txtLai_QH != null)
			{
				((Control)_txtLai_QH).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtHan_CK
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHan_CK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtHan_CK_TextChanged;
			if (_txtHan_CK != null)
			{
				((Control)_txtHan_CK).TextChanged -= eventHandler;
			}
			_txtHan_CK = value;
			if (_txtHan_CK != null)
			{
				((Control)_txtHan_CK).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual AsTextNumeric txtHan_TT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHan_TT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtHan_TT_TextChanged;
			if (_txtHan_TT != null)
			{
				((Control)_txtHan_TT).TextChanged -= eventHandler;
			}
			_txtHan_TT = value;
			if (_txtHan_TT != null)
			{
				((Control)_txtHan_TT).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextBox txtMo_Ta
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMo_Ta;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMo_Ta = value;
		}
	}

	internal virtual TextBox txtMa_TT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_TT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_TT = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSODMTTEdit()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		txtHan_CK = new AsTextNumeric();
		txtLai_QH = new AsTextNumeric();
		txtTyle_CK = new AsTextNumeric();
		txtHan_TT = new AsTextNumeric();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		txtMo_Ta = new AsTextBox();
		txtMa_TT = new TextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		chkKsd.Checked = true;
		((CheckBox)chkKsd).CheckState = (CheckState)1;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(116, 156);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 5;
		chkKsd.TextValue = "1";
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 193);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 193);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtMa_TT);
		((Control)gbLine).Controls.Add((Control)(object)txtMo_Ta);
		((Control)gbLine).Controls.Add((Control)(object)Label10);
		((Control)gbLine).Controls.Add((Control)(object)Label9);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)txtHan_TT);
		((Control)gbLine).Controls.Add((Control)(object)txtTyle_CK);
		((Control)gbLine).Controls.Add((Control)(object)txtLai_QH);
		((Control)gbLine).Controls.Add((Control)(object)txtHan_CK);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		GroupBox obj3 = gbLine;
		Size size = new Size(438, 181);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtHan_CK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtLai_QH, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTyle_CK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtHan_TT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label9, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label10, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMo_Ta, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_TT, 0);
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(13, 21);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(76, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 100;
		Label1.Text = "Mã thanh toán";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(13, 44);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(80, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 101;
		Label2.Text = "Hạn chiết khấu";
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(13, 67);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(83, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 102;
		Label3.Text = "Tỷ lệ chiết khấu";
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(13, 90);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(81, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 103;
		Label4.Text = "Hạn thanh toán";
		Label5.AutoSize = true;
		Label label9 = Label5;
		location = new Point(13, 113);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(63, 13);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 104;
		Label5.Text = "Lãi quá hạn";
		Label6.AutoSize = true;
		Label label11 = Label6;
		location = new Point(13, 136);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(34, 13);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 105;
		Label6.Text = "Mô tả";
		txtHan_CK.DecimalSymbol = ".";
		txtHan_CK.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtHan_CK;
		location = new Point(116, 40);
		((Control)asTextNumeric).Location = location;
		txtHan_CK.Mask = "### ### ### ###";
		((Control)txtHan_CK).Name = "txtHan_CK";
		AsTextNumeric asTextNumeric2 = txtHan_CK;
		size = new Size(91, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtHan_CK).TabIndex = 1;
		((TextBox)txtHan_CK).Text = "0";
		((TextBox)txtHan_CK).TextAlign = (HorizontalAlignment)1;
		txtHan_CK.Value = 0;
		txtLai_QH.DecimalSymbol = ".";
		txtLai_QH.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtLai_QH;
		location = new Point(116, 109);
		((Control)asTextNumeric3).Location = location;
		txtLai_QH.Mask = "### ### ### ###.##";
		((Control)txtLai_QH).Name = "txtLai_QH";
		AsTextNumeric asTextNumeric4 = txtLai_QH;
		size = new Size(91, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtLai_QH).TabIndex = 4;
		((TextBox)txtLai_QH).Text = "0.00";
		((TextBox)txtLai_QH).TextAlign = (HorizontalAlignment)1;
		txtLai_QH.Value = 0;
		txtTyle_CK.DecimalSymbol = ".";
		txtTyle_CK.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtTyle_CK;
		location = new Point(116, 63);
		((Control)asTextNumeric5).Location = location;
		txtTyle_CK.Mask = "### ### ### ###.##";
		((Control)txtTyle_CK).Name = "txtTyle_CK";
		AsTextNumeric asTextNumeric6 = txtTyle_CK;
		size = new Size(91, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtTyle_CK).TabIndex = 2;
		((TextBox)txtTyle_CK).Text = "0.00";
		((TextBox)txtTyle_CK).TextAlign = (HorizontalAlignment)1;
		txtTyle_CK.Value = 0;
		txtHan_TT.DecimalSymbol = ".";
		txtHan_TT.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtHan_TT;
		location = new Point(116, 86);
		((Control)asTextNumeric7).Location = location;
		txtHan_TT.Mask = "### ### ### ###";
		((Control)txtHan_TT).Name = "txtHan_TT";
		AsTextNumeric asTextNumeric8 = txtHan_TT;
		size = new Size(91, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtHan_TT).TabIndex = 3;
		((TextBox)txtHan_TT).Text = "0";
		((TextBox)txtHan_TT).TextAlign = (HorizontalAlignment)1;
		txtHan_TT.Value = 0;
		Label7.AutoSize = true;
		Label label13 = Label7;
		location = new Point(213, 67);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(21, 13);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 112;
		Label7.Text = "(%)";
		Label8.AutoSize = true;
		Label label15 = Label8;
		location = new Point(213, 44);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(38, 13);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 113;
		Label8.Text = "(Ngày)";
		Label9.AutoSize = true;
		Label label17 = Label9;
		location = new Point(213, 90);
		((Control)label17).Location = location;
		((Control)Label9).Name = "Label9";
		Label label18 = Label9;
		size = new Size(38, 13);
		((Control)label18).Size = size;
		((Control)Label9).TabIndex = 114;
		Label9.Text = "(Ngày)";
		Label10.AutoSize = true;
		Label label19 = Label10;
		location = new Point(213, 113);
		((Control)label19).Location = location;
		((Control)Label10).Name = "Label10";
		Label label20 = Label10;
		size = new Size(21, 13);
		((Control)label20).Size = size;
		((Control)Label10).TabIndex = 115;
		Label10.Text = "(%)";
		txtMo_Ta.AutoLookup = false;
		txtMo_Ta.AutoValid = false;
		((TextBoxBase)txtMo_Ta).BackColor = SystemColors.Control;
		((TextBox)txtMo_Ta).CharacterCasing = (CharacterCasing)1;
		((Control)txtMo_Ta).Enabled = false;
		AsTextBox asTextBox = txtMo_Ta;
		location = new Point(116, 132);
		((Control)asTextBox).Location = location;
		txtMo_Ta.LookupCodeName = "";
		((Control)txtMo_Ta).Name = "txtMo_Ta";
		txtMo_Ta.NameControl = null;
		((TextBoxBase)txtMo_Ta).ReadOnly = true;
		AsTextBox asTextBox2 = txtMo_Ta;
		size = new Size(313, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMo_Ta).TabIndex = 5;
		txtMa_TT.CharacterCasing = (CharacterCasing)1;
		TextBox obj4 = txtMa_TT;
		location = new Point(116, 17);
		((Control)obj4).Location = location;
		((TextBoxBase)txtMa_TT).MaxLength = 8;
		((Control)txtMa_TT).Name = "txtMa_TT";
		TextBox obj5 = txtMa_TT;
		size = new Size(91, 20);
		((Control)obj5).Size = size;
		((Control)txtMa_TT).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(462, 228);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSODMTTEdit";
		((Form)this).Text = "Danh mục điều khoản thanh toán";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_TT).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_TT).Select();
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_TT;
		CreateDataBinding(ref ojb, "Ma_TT");
		txtMa_TT = (TextBox)ojb;
		ojb = (Control)(object)txtHan_TT;
		CreateDataBinding(ref ojb, "han_tt", "Value");
		txtHan_TT = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtHan_CK;
		CreateDataBinding(ref ojb, "han_ck", "Value");
		txtHan_CK = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTyle_CK;
		CreateDataBinding(ref ojb, "tl_ck", "Value");
		txtTyle_CK = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtLai_QH;
		CreateDataBinding(ref ojb, "ls_qh", "Value");
		txtLai_QH = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMo_Ta;
		CreateDataBinding(ref ojb, "mo_ta");
		txtMo_Ta = (AsTextBox)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_TT).Enabled = false;
		((Control)txtHan_CK).Select();
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox(txtMa_TT) || !base.ValidData())
		{
			return false;
		}
		return true;
	}

	private void txtHan_CK_TextChanged(object sender, EventArgs e)
	{
		((TextBox)txtMo_Ta).Text = ((TextBox)txtHan_CK).Text + " - " + ((TextBox)txtTyle_CK).Text + "%, " + ((TextBox)txtHan_TT).Text + " - " + ((TextBox)txtLai_QH).Text + "%";
	}

	private void txtTyle_CK_TextChanged(object sender, EventArgs e)
	{
		((TextBox)txtMo_Ta).Text = ((TextBox)txtHan_CK).Text + " - " + ((TextBox)txtTyle_CK).Text + "%, " + ((TextBox)txtHan_TT).Text + " - " + ((TextBox)txtLai_QH).Text + "%";
	}

	private void txtHan_TT_TextChanged(object sender, EventArgs e)
	{
		((TextBox)txtMo_Ta).Text = ((TextBox)txtHan_CK).Text + " - " + ((TextBox)txtTyle_CK).Text + "%, " + ((TextBox)txtHan_TT).Text + " - " + ((TextBox)txtLai_QH).Text + "%";
	}

	private void txtLai_QH_TextChanged(object sender, EventArgs e)
	{
		((TextBox)txtMo_Ta).Text = ((TextBox)txtHan_CK).Text + " - " + ((TextBox)txtTyle_CK).Text + "%, " + ((TextBox)txtHan_TT).Text + " - " + ((TextBox)txtLai_QH).Text + "%";
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_TT).Select();
		}
		return flag;
	}
}
