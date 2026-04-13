using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSIDMTGNTEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("cboMa_NT")]
	private AsComboBoxNT _cboMa_NT;

	[AccessedThroughProperty("lblMa_Nt")]
	private Label _lblMa_Nt;

	[AccessedThroughProperty("txtNgay_Tg")]
	private AsMaskedTextBox _txtNgay_Tg;

	[AccessedThroughProperty("lblNgay_Tg")]
	private Label _lblNgay_Tg;

	[AccessedThroughProperty("txtTy_Gia")]
	private AsTextNumeric _txtTy_Gia;

	[AccessedThroughProperty("lblTy_Gia")]
	private Label _lblTy_Gia;

	internal virtual AsComboBoxNT cboMa_NT
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboMa_NT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboMa_NT = value;
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

	internal virtual AsMaskedTextBox txtNgay_Tg
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_Tg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_Tg = value;
		}
	}

	internal virtual Label lblNgay_Tg
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_Tg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_Tg = value;
		}
	}

	internal virtual AsTextNumeric txtTy_Gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTy_Gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTy_Gia = value;
		}
	}

	internal virtual Label lblTy_Gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTy_Gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTy_Gia = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSIDMTGNTEdit()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmSIDMTGNTEdit_KeyDown);
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		cboMa_NT = new AsComboBoxNT();
		lblMa_Nt = new Label();
		txtNgay_Tg = new AsMaskedTextBox();
		lblNgay_Tg = new Label();
		txtTy_Gia = new AsTextNumeric();
		lblTy_Gia = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(195, 106);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 3;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 115);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 115);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtTy_Gia);
		((Control)gbLine).Controls.Add((Control)(object)lblTy_Gia);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_Tg);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_Tg);
		((Control)gbLine).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Nt);
		GroupBox obj3 = gbLine;
		Size size = new Size(414, 102);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_Tg, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_Tg, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTy_Gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTy_Gia, 0);
		((ComboBox)cboMa_NT).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMa_NT).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_NT;
		location = new Point(142, 19);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(98, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 0;
		lblMa_Nt.AutoSize = true;
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj4 = lblMa_Nt;
		location = new Point(20, 23);
		((Control)obj4).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj5 = lblMa_Nt;
		size = new Size(40, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_Nt).TabIndex = 109;
		lblMa_Nt.Text = "Mã NT";
		txtNgay_Tg.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_Tg).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Tg;
		location = new Point(142, 46);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_Tg).Mask = "##/##/####";
		((Control)txtNgay_Tg).Name = "txtNgay_Tg";
		((MaskedTextBox)txtNgay_Tg).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_Tg;
		size = new Size(71, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_Tg).TabIndex = 1;
		((MaskedTextBox)txtNgay_Tg).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_Tg;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		lblNgay_Tg.AutoSize = true;
		lblNgay_Tg.ImeMode = (ImeMode)0;
		Label obj6 = lblNgay_Tg;
		location = new Point(20, 50);
		((Control)obj6).Location = location;
		((Control)lblNgay_Tg).Name = "lblNgay_Tg";
		Label obj7 = lblNgay_Tg;
		size = new Size(60, 13);
		((Control)obj7).Size = size;
		((Control)lblNgay_Tg).TabIndex = 111;
		lblNgay_Tg.Text = "Ngày tỷ giá";
		txtTy_Gia.DecimalSymbol = ".";
		txtTy_Gia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtTy_Gia;
		location = new Point(142, 72);
		((Control)asTextNumeric).Location = location;
		txtTy_Gia.Mask = "### ###.##";
		((Control)txtTy_Gia).Name = "txtTy_Gia";
		AsTextNumeric asTextNumeric2 = txtTy_Gia;
		size = new Size(71, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTy_Gia).TabIndex = 2;
		((TextBox)txtTy_Gia).Text = "0.00";
		((TextBox)txtTy_Gia).TextAlign = (HorizontalAlignment)1;
		txtTy_Gia.Value = 0;
		lblTy_Gia.AutoSize = true;
		lblTy_Gia.ImeMode = (ImeMode)0;
		Label obj8 = lblTy_Gia;
		location = new Point(20, 76);
		((Control)obj8).Location = location;
		((Control)lblTy_Gia).Name = "lblTy_Gia";
		Label obj9 = lblTy_Gia;
		size = new Size(36, 13);
		((Control)obj9).Size = size;
		((Control)lblTy_Gia).TabIndex = 113;
		lblTy_Gia.Text = "Tỷ giá";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(436, 145);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSIDMTGNTEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			txtNgay_Tg.Value = DateAndTime.Now.Date;
		}
		((Control)cboMa_NT).Select();
	}

	protected override void DataBinding()
	{
		base.DataBinding();
		Control ojb = (Control)(object)cboMa_NT;
		CreateDataBinding(ref ojb, "Ma_Nt", "MA_NT");
		cboMa_NT = (AsComboBoxNT)(object)ojb;
		ojb = (Control)(object)txtNgay_Tg;
		CreateDataBinding(ref ojb, "Ngay_Tg", "Value");
		txtNgay_Tg = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtTy_Gia;
		CreateDataBinding(ref ojb, "Ty_Gia", "Value");
		txtTy_Gia = (AsTextNumeric)(object)ojb;
	}

	protected override bool SetToRow()
	{
		return base.SetToRow();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)cboMa_NT).Enabled = false;
		((Control)txtNgay_Tg).Enabled = false;
		((Control)txtTy_Gia).Select();
	}

	protected override bool ValidData()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(txtNgay_Tg.Value, (object)"#1/1/1900#", false))
		{
			CMessageBox.Show(50002);
			((Control)txtNgay_Tg).Select();
			return false;
		}
		return base.ValidData();
	}

	private void frmSIDMTGNTEdit_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}
}
