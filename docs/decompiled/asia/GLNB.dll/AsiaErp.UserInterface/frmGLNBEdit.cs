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
public class frmGLNBEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("cboNgoai_te")]
	private AsComboBoxNT _cboNgoai_te;

	[AccessedThroughProperty("txtty_gia")]
	private AsTextNumeric _txtty_gia;

	[AccessedThroughProperty("txtdien_giai")]
	private TextBox _txtdien_giai;

	[AccessedThroughProperty("txtPs_co")]
	private AsTextNumeric _txtPs_co;

	[AccessedThroughProperty("txtPs_co_nt")]
	private AsTextNumeric _txtPs_co_nt;

	[AccessedThroughProperty("txtPs_no")]
	private AsTextNumeric _txtPs_no;

	[AccessedThroughProperty("txtPs_no_nt")]
	private AsTextNumeric _txtPs_no_nt;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("txtTK")]
	private AsTextBox _txtTK;

	[AccessedThroughProperty("txtNgay_ct")]
	private AsMaskedTextBox _txtNgay_ct;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	private bool bfag;

	internal virtual Label lblTen_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk = value;
		}
	}

	internal virtual AsComboBoxNT cboNgoai_te
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNgoai_te;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboNgoai_te_SelectedIndexChanged;
			if (_cboNgoai_te != null)
			{
				((ComboBox)_cboNgoai_te).SelectedIndexChanged -= eventHandler;
			}
			_cboNgoai_te = value;
			if (_cboNgoai_te != null)
			{
				((ComboBox)_cboNgoai_te).SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtty_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtty_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtty_gia_Validated;
			if (_txtty_gia != null)
			{
				((Control)_txtty_gia).TextChanged -= eventHandler;
			}
			_txtty_gia = value;
			if (_txtty_gia != null)
			{
				((Control)_txtty_gia).TextChanged += eventHandler;
			}
		}
	}

	internal virtual TextBox txtdien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtdien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtdien_giai = value;
		}
	}

	internal virtual AsTextNumeric txtPs_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPs_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtPs_co_Validated;
			if (_txtPs_co != null)
			{
				((Control)_txtPs_co).TextChanged -= eventHandler;
			}
			_txtPs_co = value;
			if (_txtPs_co != null)
			{
				((Control)_txtPs_co).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtPs_co_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPs_co_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtPs_co_nt_Validated;
			if (_txtPs_co_nt != null)
			{
				((Control)_txtPs_co_nt).TextChanged -= eventHandler;
			}
			_txtPs_co_nt = value;
			if (_txtPs_co_nt != null)
			{
				((Control)_txtPs_co_nt).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtPs_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPs_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtPs_no_Validated;
			if (_txtPs_no != null)
			{
				((Control)_txtPs_no).TextChanged -= eventHandler;
			}
			_txtPs_no = value;
			if (_txtPs_no != null)
			{
				((Control)_txtPs_no).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtPs_no_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPs_no_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtPs_no_nt_Validated;
			if (_txtPs_no_nt != null)
			{
				((Control)_txtPs_no_nt).TextChanged -= eventHandler;
			}
			_txtPs_no_nt = value;
			if (_txtPs_no_nt != null)
			{
				((Control)_txtPs_no_nt).TextChanged += eventHandler;
			}
		}
	}

	internal virtual TextBox txtSo_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ct = value;
		}
	}

	internal virtual AsTextBox txtTK
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNgay_ct_Validated;
			if (_txtNgay_ct != null)
			{
				((Control)_txtNgay_ct).Validated -= eventHandler;
			}
			_txtNgay_ct = value;
			if (_txtNgay_ct != null)
			{
				((Control)_txtNgay_ct).Validated += eventHandler;
			}
		}
	}

	internal virtual Label Label23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label23 = value;
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
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

	public frmGLNBEdit()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		bfag = false;
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
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		cboNgoai_te = new AsComboBoxNT();
		txtty_gia = new AsTextNumeric();
		txtdien_giai = new TextBox();
		txtPs_co = new AsTextNumeric();
		txtPs_co_nt = new AsTextNumeric();
		txtPs_no = new AsTextNumeric();
		txtPs_no_nt = new AsTextNumeric();
		txtSo_ct = new TextBox();
		txtTK = new AsTextBox();
		lblTen_tk = new Label();
		txtNgay_ct = new AsMaskedTextBox();
		Label23 = new Label();
		Label12 = new Label();
		Label8 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label1 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(527, 409);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 2;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 301);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 301);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk);
		((Control)gbLine).Controls.Add((Control)(object)cboNgoai_te);
		((Control)gbLine).Controls.Add((Control)(object)txtty_gia);
		((Control)gbLine).Controls.Add((Control)(object)txtdien_giai);
		((Control)gbLine).Controls.Add((Control)(object)txtPs_co);
		((Control)gbLine).Controls.Add((Control)(object)txtPs_co_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtPs_no);
		((Control)gbLine).Controls.Add((Control)(object)txtPs_no_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtTK);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct);
		((Control)gbLine).Controls.Add((Control)(object)Label23);
		((Control)gbLine).Controls.Add((Control)(object)Label12);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		GroupBox obj3 = gbLine;
		location = new Point(11, 6);
		((Control)obj3).Location = location;
		GroupBox obj4 = gbLine;
		Size size = new Size(517, 288);
		((Control)obj4).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label12, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label23, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtPs_no_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtPs_no, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtPs_co_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtPs_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtdien_giai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtty_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboNgoai_te, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		((ComboBox)cboNgoai_te).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNgoai_te).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboNgoai_te;
		location = new Point(127, 92);
		((Control)asComboBoxNT).Location = location;
		cboNgoai_te.MA_NT = "";
		((Control)cboNgoai_te).Name = "cboNgoai_te";
		AsComboBoxNT asComboBoxNT2 = cboNgoai_te;
		size = new Size(46, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboNgoai_te).TabIndex = 3;
		txtty_gia.DecimalSymbol = ".";
		txtty_gia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtty_gia;
		location = new Point(179, 92);
		((Control)asTextNumeric).Location = location;
		txtty_gia.Mask = "### ### ### ###.##";
		((Control)txtty_gia).Name = "txtty_gia";
		AsTextNumeric asTextNumeric2 = txtty_gia;
		size = new Size(71, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtty_gia).TabIndex = 4;
		((TextBox)txtty_gia).Text = "0.00";
		((TextBox)txtty_gia).TextAlign = (HorizontalAlignment)1;
		txtty_gia.Value = 0;
		TextBox obj5 = txtdien_giai;
		location = new Point(127, 222);
		((Control)obj5).Location = location;
		txtdien_giai.Multiline = true;
		((Control)txtdien_giai).Name = "txtdien_giai";
		TextBox obj6 = txtdien_giai;
		size = new Size(354, 57);
		((Control)obj6).Size = size;
		((Control)txtdien_giai).TabIndex = 9;
		txtPs_co.DecimalSymbol = ".";
		txtPs_co.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtPs_co;
		location = new Point(127, 196);
		((Control)asTextNumeric3).Location = location;
		txtPs_co.Mask = "### ### ### ###";
		((Control)txtPs_co).Name = "txtPs_co";
		AsTextNumeric asTextNumeric4 = txtPs_co;
		size = new Size(123, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtPs_co).TabIndex = 8;
		((TextBox)txtPs_co).Text = "0";
		((TextBox)txtPs_co).TextAlign = (HorizontalAlignment)1;
		txtPs_co.Value = 0;
		txtPs_co_nt.DecimalSymbol = ".";
		txtPs_co_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtPs_co_nt;
		location = new Point(127, 170);
		((Control)asTextNumeric5).Location = location;
		txtPs_co_nt.Mask = "### ### ### ###.##";
		((Control)txtPs_co_nt).Name = "txtPs_co_nt";
		AsTextNumeric asTextNumeric6 = txtPs_co_nt;
		size = new Size(123, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtPs_co_nt).TabIndex = 7;
		((TextBox)txtPs_co_nt).Text = "0.00";
		((TextBox)txtPs_co_nt).TextAlign = (HorizontalAlignment)1;
		txtPs_co_nt.Value = 0;
		txtPs_no.DecimalSymbol = ".";
		txtPs_no.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtPs_no;
		location = new Point(127, 144);
		((Control)asTextNumeric7).Location = location;
		txtPs_no.Mask = "### ### ### ###";
		((Control)txtPs_no).Name = "txtPs_no";
		AsTextNumeric asTextNumeric8 = txtPs_no;
		size = new Size(123, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtPs_no).TabIndex = 6;
		((TextBox)txtPs_no).Text = "0";
		((TextBox)txtPs_no).TextAlign = (HorizontalAlignment)1;
		txtPs_no.Value = 0;
		txtPs_no_nt.DecimalSymbol = ".";
		txtPs_no_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric9 = txtPs_no_nt;
		location = new Point(127, 118);
		((Control)asTextNumeric9).Location = location;
		txtPs_no_nt.Mask = "### ### ### ###.##";
		((Control)txtPs_no_nt).Name = "txtPs_no_nt";
		AsTextNumeric asTextNumeric10 = txtPs_no_nt;
		size = new Size(123, 20);
		((Control)asTextNumeric10).Size = size;
		((Control)txtPs_no_nt).TabIndex = 5;
		((TextBox)txtPs_no_nt).Text = "0.00";
		((TextBox)txtPs_no_nt).TextAlign = (HorizontalAlignment)1;
		txtPs_no_nt.Value = 0;
		TextBox obj7 = txtSo_ct;
		location = new Point(127, 14);
		((Control)obj7).Location = location;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj8 = txtSo_ct;
		size = new Size(123, 20);
		((Control)obj8).Size = size;
		((Control)txtSo_ct).TabIndex = 0;
		txtTK.AutoLookup = true;
		txtTK.AutoValid = true;
		((TextBoxBase)txtTK).BackColor = SystemColors.Info;
		((TextBox)txtTK).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTK;
		location = new Point(127, 66);
		((Control)asTextBox).Location = location;
		txtTK.LookupCodeName = "TK";
		txtTK.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTK).Name = "txtTK";
		txtTK.NameControl = lblTen_tk;
		AsTextBox asTextBox2 = txtTK;
		size = new Size(123, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTK).TabIndex = 2;
		txtTK.UseAutoCompleteSource = true;
		Label obj9 = lblTen_tk;
		location = new Point(256, 68);
		((Control)obj9).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj10 = lblTen_tk;
		size = new Size(248, 18);
		((Control)obj10).Size = size;
		((Control)lblTen_tk).TabIndex = 149;
		txtNgay_ct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct;
		location = new Point(127, 40);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ct).Mask = "##/##/####";
		((Control)txtNgay_ct).Name = "txtNgay_ct";
		((MaskedTextBox)txtNgay_ct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ct;
		size = new Size(123, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ct).TabIndex = 1;
		((MaskedTextBox)txtNgay_ct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		Label23.AutoSize = true;
		Label label = Label23;
		location = new Point(21, 225);
		((Control)label).Location = location;
		((Control)Label23).Name = "Label23";
		Label label2 = Label23;
		size = new Size(48, 13);
		((Control)label2).Size = size;
		((Control)Label23).TabIndex = 143;
		Label23.Text = "Diễn giải";
		Label12.AutoSize = true;
		Label label3 = Label12;
		location = new Point(21, 17);
		((Control)label3).Location = location;
		((Control)Label12).Name = "Label12";
		Label label4 = Label12;
		size = new Size(65, 13);
		((Control)label4).Size = size;
		((Control)Label12).TabIndex = 142;
		Label12.Text = "Số chứng từ";
		Label8.AutoSize = true;
		Label label5 = Label8;
		location = new Point(21, 199);
		((Control)label5).Location = location;
		((Control)Label8).Name = "Label8";
		Label label6 = Label8;
		size = new Size(66, 13);
		((Control)label6).Size = size;
		((Control)Label8).TabIndex = 140;
		Label8.Text = "Phát sinh có";
		Label7.AutoSize = true;
		Label label7 = Label7;
		location = new Point(21, 173);
		((Control)label7).Location = location;
		((Control)Label7).Name = "Label7";
		Label label8 = Label7;
		size = new Size(84, 13);
		((Control)label8).Size = size;
		((Control)Label7).TabIndex = 139;
		Label7.Text = "Phát sinh có NT";
		Label6.AutoSize = true;
		Label label9 = Label6;
		location = new Point(21, 147);
		((Control)label9).Location = location;
		((Control)Label6).Name = "Label6";
		Label label10 = Label6;
		size = new Size(66, 13);
		((Control)label10).Size = size;
		((Control)Label6).TabIndex = 138;
		Label6.Text = "Phát sinh nợ";
		Label5.AutoSize = true;
		Label label11 = Label5;
		location = new Point(21, 121);
		((Control)label11).Location = location;
		((Control)Label5).Name = "Label5";
		Label label12 = Label5;
		size = new Size(84, 13);
		((Control)label12).Size = size;
		((Control)Label5).TabIndex = 137;
		Label5.Text = "Phát sinh nợ NT";
		Label4.AutoSize = true;
		Label label13 = Label4;
		location = new Point(21, 96);
		((Control)label13).Location = location;
		((Control)Label4).Name = "Label4";
		Label label14 = Label4;
		size = new Size(47, 13);
		((Control)label14).Size = size;
		((Control)Label4).TabIndex = 136;
		Label4.Text = "Ngoại tệ";
		Label3.AutoSize = true;
		Label label15 = Label3;
		location = new Point(21, 69);
		((Control)label15).Location = location;
		((Control)Label3).Name = "Label3";
		Label label16 = Label3;
		size = new Size(55, 13);
		((Control)label16).Size = size;
		((Control)Label3).TabIndex = 135;
		Label3.Text = "Tài khoản";
		Label1.AutoSize = true;
		Label label17 = Label1;
		location = new Point(21, 43);
		((Control)label17).Location = location;
		((Control)Label1).Name = "Label1";
		Label label18 = Label1;
		size = new Size(77, 13);
		((Control)label18).Size = size;
		((Control)Label1).TabIndex = 134;
		Label1.Text = "Ngày chứng từ";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(540, 331);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGLNBEdit";
		((Form)this).Text = "frmGLNBEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		if (!EditMode)
		{
			RowToEdit["Ma_ct"] = MyMenuInfo.par1;
			RowToEdit["Stt_Rec"] = Commons.Get_SttRec(MyMenuInfo.par1);
			((Control)txtSo_ct).Select();
		}
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		bfag = true;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtSo_ct).Select();
	}

	protected override void DataBinding()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtNgay_ct;
		CreateDataBinding(ref ojb, "ngay_ct", "Value");
		txtNgay_ct = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "so_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)txtTK;
		CreateDataBinding(ref ojb, "Tk");
		txtTK = (AsTextBox)(object)ojb;
		ojb = (Control)(object)cboNgoai_te;
		CreateDataBinding(ref ojb, "ma_nt");
		cboNgoai_te = (AsComboBoxNT)(object)ojb;
		ojb = (Control)(object)txtty_gia;
		CreateDataBinding(ref ojb, "ty_gia", "Value");
		txtty_gia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtPs_co;
		CreateDataBinding(ref ojb, "ps_co", "Value");
		txtPs_co = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtPs_co_nt;
		CreateDataBinding(ref ojb, "ps_co_nt", "Value");
		txtPs_co_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtPs_no;
		CreateDataBinding(ref ojb, "ps_no", "Value");
		txtPs_no = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtPs_no_nt;
		CreateDataBinding(ref ojb, "ps_no_nt", "Value");
		txtPs_no_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtdien_giai;
		CreateDataBinding(ref ojb, "dien_giai");
		txtdien_giai = (TextBox)ojb;
	}

	protected override bool ValidData()
	{
		if (Operators.ConditionalCompareObjectEqual(txtNgay_ct.Value, (object)new DateTime(599266080000000000L), false))
		{
			epNotice.SetError((Control)(object)txtNgay_ct, Conversions.ToString(txtNgay_ct.Value));
			((Control)txtNgay_ct).Select();
			bool result = default(bool);
			return result;
		}
		bool flag = true;
		double gia_tri_dieu_chinh_gia_toi_da = AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_gia_toi_da;
		if ((Operators.ConditionalCompareObjectNotEqual(txtty_gia.Value, (object)0, false) && Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(txtPs_no.Value, Operators.MultiplyObject(txtPs_no_nt.Value, txtty_gia.Value)) }, (string[])null, (Type[])null, (bool[])null), (object)gia_tri_dieu_chinh_gia_toi_da, false)) ? true : false)
		{
			flag = Commons.ProcessAdjustOver();
		}
		if ((Operators.ConditionalCompareObjectNotEqual(txtty_gia.Value, (object)0, false) && Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(txtPs_co.Value, Operators.MultiplyObject(txtPs_co_nt.Value, txtty_gia.Value)) }, (string[])null, (Type[])null, (bool[])null), (object)gia_tri_dieu_chinh_gia_toi_da, false)) ? true : false)
		{
			flag = Commons.ProcessAdjustOver();
		}
		return (ChkEmtyTextBox(txtSo_ct) && ChkEmtyTextBox((TextBox)(object)txtTK) && flag && base.ValidData()) ? true : false;
	}

	private bool V_NT()
	{
		if (!bfag)
		{
			return bfag;
		}
		txtPs_co.Value = Operators.MultiplyObject(txtPs_co_nt.Value, txtty_gia.Value);
		txtPs_no.Value = Operators.MultiplyObject(txtPs_no_nt.Value, txtty_gia.Value);
		return bfag;
	}

	private void cboNgoai_te_SelectedIndexChanged(object sender, EventArgs e)
	{
		V_CBO_NT();
	}

	private void V_CBO_NT()
	{
		if ((!EditMode && ((ComboBox)cboNgoai_te).DataSource != null) ? true : false)
		{
			if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNgoai_te).SelectedValue, (object)"VND", false))
			{
				txtty_gia.Value = "1.00";
				((Control)txtty_gia).Enabled = false;
				((Control)txtPs_no_nt).Enabled = false;
				((Control)txtPs_co_nt).Enabled = false;
			}
			else
			{
				((Control)txtty_gia).Enabled = true;
				txtty_gia.Value = Commons.Get_TyGia(((ComboBox)cboNgoai_te).Text, Conversions.ToDate(txtNgay_ct.Value));
				((Control)txtPs_no_nt).Enabled = true;
				((Control)txtPs_co_nt).Enabled = true;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(((ListControl)cboNgoai_te).SelectedValue, (object)"VND", false))
		{
			txtty_gia.Value = "1.00";
			((Control)txtty_gia).Enabled = false;
			((Control)txtPs_no_nt).Enabled = false;
			((Control)txtPs_co_nt).Enabled = false;
		}
		else
		{
			((Control)txtty_gia).Enabled = true;
			txtty_gia.Value = Commons.Get_TyGia(((ComboBox)cboNgoai_te).Text, Conversions.ToDate(txtNgay_ct.Value));
			((Control)txtPs_no_nt).Enabled = true;
			((Control)txtPs_co_nt).Enabled = true;
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(txtPs_co_nt.Value, (object)0, false), Operators.CompareObjectNotEqual(txtPs_no_nt.Value, (object)0, false))))
		{
			V_NT();
		}
	}

	private void txtPs_co_nt_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtPs_co_nt.Value, (object)0, false))
		{
			V_NT();
		}
		CheckPS(No: false);
	}

	private void txtPs_no_nt_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtPs_no_nt.Value, (object)0, false))
		{
			V_NT();
		}
		CheckPS(No: true);
	}

	private void txtty_gia_Validated(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(txtPs_co_nt.Value, (object)0, false), Operators.CompareObjectNotEqual(txtPs_no_nt.Value, (object)0, false))))
		{
			V_NT();
		}
	}

	private void txtNgay_ct_Validated(object sender, EventArgs e)
	{
		try
		{
			if (!EditMode)
			{
				if (Operators.CompareString(((ComboBox)cboNgoai_te).Text, "VND", false) == 0)
				{
					txtty_gia.Value = "1.00";
				}
				else
				{
					txtty_gia.Value = Commons.Get_TyGia(((ComboBox)cboNgoai_te).Text, Conversions.ToDate(txtNgay_ct.Value));
				}
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(txtPs_co_nt.Value, (object)0, false), Operators.CompareObjectNotEqual(txtPs_no_nt.Value, (object)0, false))))
				{
					V_NT();
				}
			}
			epNotice.Clear();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void txtPs_co_Validated(object sender, EventArgs e)
	{
		CheckPS(No: false);
	}

	private void txtPs_no_Validated(object sender, EventArgs e)
	{
		CheckPS(No: true);
	}

	private void CheckPS(bool No)
	{
		double num = 0.0;
		double num2 = 0.0;
		num = Conversions.ToDouble(Operators.AddObject(txtPs_no_nt.Value, txtPs_no.Value));
		num2 = Conversions.ToDouble(Operators.AddObject(txtPs_co_nt.Value, txtPs_co.Value));
		if (!(num == 0.0 || num2 == 0.0))
		{
			if (((uint)((No && num > 0.0) ? 1 : 0) & ((num2 > 0.0) ? 1u : 0u)) != 0)
			{
				txtPs_co_nt.Value = 0;
				txtPs_co.Value = 0;
			}
			else if (((uint)((!No && num > 0.0) ? 1 : 0) & ((num2 > 0.0) ? 1u : 0u)) != 0)
			{
				txtPs_no_nt.Value = 0;
				txtPs_no.Value = 0;
			}
		}
	}
}
