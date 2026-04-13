using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmSODMDGVTEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("lblMa_td")]
	private Label _lblMa_td;

	[AccessedThroughProperty("lblMa_pt")]
	private Label _lblMa_pt;

	[AccessedThroughProperty("lblTen_td")]
	private Label _lblTen_td;

	[AccessedThroughProperty("lblTen_pt")]
	private Label _lblTen_pt;

	[AccessedThroughProperty("cboNt")]
	private AsComboBoxNT _cboNt;

	[AccessedThroughProperty("lblGia_nt")]
	private Label _lblGia_nt;

	[AccessedThroughProperty("txtGia_nt")]
	private AsTextNumeric _txtGia_nt;

	[AccessedThroughProperty("lblMa_nt")]
	private Label _lblMa_nt;

	[AccessedThroughProperty("lblGia_Vnd")]
	private Label _lblGia_Vnd;

	[AccessedThroughProperty("txtGia_vnd")]
	private AsTextNumeric _txtGia_vnd;

	[AccessedThroughProperty("txtTygia")]
	private AsTextNumeric _txtTygia;

	[AccessedThroughProperty("txtMa_pt")]
	private AsTextBox _txtMa_pt;

	[AccessedThroughProperty("txtMa_td")]
	private AsTextBox _txtMa_td;

	internal virtual Label lblMa_td
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_td;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_td = value;
		}
	}

	internal virtual Label lblMa_pt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_pt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_pt = value;
		}
	}

	internal virtual Label lblTen_td
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_td;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_td = value;
		}
	}

	internal virtual Label lblTen_pt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_pt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_pt = value;
		}
	}

	internal virtual AsComboBoxNT cboNt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboNt_SelectedValueChanged;
			if (_cboNt != null)
			{
				((ListControl)_cboNt).SelectedValueChanged -= eventHandler;
			}
			_cboNt = value;
			if (_cboNt != null)
			{
				((ListControl)_cboNt).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblGia_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGia_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGia_nt = value;
		}
	}

	internal virtual AsTextNumeric txtGia_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGia_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtGia_nt_Validated;
			if (_txtGia_nt != null)
			{
				((Control)_txtGia_nt).Validated -= eventHandler;
			}
			_txtGia_nt = value;
			if (_txtGia_nt != null)
			{
				((Control)_txtGia_nt).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblMa_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nt = value;
		}
	}

	internal virtual Label lblGia_Vnd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGia_Vnd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGia_Vnd = value;
		}
	}

	internal virtual AsTextNumeric txtGia_vnd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGia_vnd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGia_vnd = value;
		}
	}

	internal virtual AsTextNumeric txtTygia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTygia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTygia = value;
		}
	}

	internal virtual AsTextBox txtMa_pt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_pt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_pt = value;
		}
	}

	internal virtual AsTextBox txtMa_td
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_td;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_td = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSODMDGVTEdit()
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		lblMa_td = new Label();
		lblTen_td = new Label();
		lblTen_pt = new Label();
		lblMa_pt = new Label();
		cboNt = new AsComboBoxNT();
		lblMa_nt = new Label();
		txtGia_nt = new AsTextNumeric();
		lblGia_nt = new Label();
		txtGia_vnd = new AsTextNumeric();
		lblGia_Vnd = new Label();
		txtTygia = new AsTextNumeric();
		txtMa_td = new AsTextBox();
		txtMa_pt = new AsTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(230, 203);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 13;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 167);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 167);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtMa_pt);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_td);
		((Control)gbLine).Controls.Add((Control)(object)txtTygia);
		((Control)gbLine).Controls.Add((Control)(object)lblGia_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblGia_Vnd);
		((Control)gbLine).Controls.Add((Control)(object)txtGia_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtGia_vnd);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_nt);
		((Control)gbLine).Controls.Add((Control)(object)cboNt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_td);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_pt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_td);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_pt);
		GroupBox obj3 = gbLine;
		Size size = new Size(460, 155);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_pt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_td, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_pt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_td, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboNt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGia_vnd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGia_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGia_Vnd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGia_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTygia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_td, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_pt, 0);
		lblMa_td.AutoSize = true;
		Label obj4 = lblMa_td;
		location = new Point(20, 23);
		((Control)obj4).Location = location;
		((Control)lblMa_td).Name = "lblMa_td";
		Label obj5 = lblMa_td;
		size = new Size(85, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_td).TabIndex = 8;
		lblMa_td.Text = "Mã tuyến đường";
		Label obj6 = lblTen_td;
		location = new Point(186, 23);
		((Control)obj6).Location = location;
		((Control)lblTen_td).Name = "lblTen_td";
		Label obj7 = lblTen_td;
		size = new Size(232, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_td).TabIndex = 7;
		Label obj8 = lblTen_pt;
		location = new Point(186, 48);
		((Control)obj8).Location = location;
		((Control)lblTen_pt).Name = "lblTen_pt";
		Label obj9 = lblTen_pt;
		size = new Size(232, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_pt).TabIndex = 6;
		lblMa_pt.AutoSize = true;
		Label obj10 = lblMa_pt;
		location = new Point(20, 48);
		((Control)obj10).Location = location;
		((Control)lblMa_pt).Name = "lblMa_pt";
		Label obj11 = lblMa_pt;
		size = new Size(81, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_pt).TabIndex = 9;
		lblMa_pt.Text = "Mã phương tiện";
		((ComboBox)cboNt).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNt).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboNt;
		location = new Point(121, 69);
		((Control)asComboBoxNT).Location = location;
		cboNt.MA_NT = "";
		((Control)cboNt).Name = "cboNt";
		AsComboBoxNT asComboBoxNT2 = cboNt;
		size = new Size(59, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboNt).TabIndex = 2;
		lblMa_nt.AutoSize = true;
		Label obj12 = lblMa_nt;
		location = new Point(20, 75);
		((Control)obj12).Location = location;
		((Control)lblMa_nt).Name = "lblMa_nt";
		Label obj13 = lblMa_nt;
		size = new Size(43, 13);
		((Control)obj13).Size = size;
		((Control)lblMa_nt).TabIndex = 10;
		lblMa_nt.Text = "Mã  NT";
		txtGia_nt.DecimalSymbol = ".";
		txtGia_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtGia_nt;
		location = new Point(121, 95);
		((Control)asTextNumeric).Location = location;
		txtGia_nt.Mask = "### ### ### ###.##";
		((Control)txtGia_nt).Name = "txtGia_nt";
		AsTextNumeric asTextNumeric2 = txtGia_nt;
		size = new Size(131, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtGia_nt).TabIndex = 4;
		((TextBox)txtGia_nt).Text = "0.00";
		((TextBox)txtGia_nt).TextAlign = (HorizontalAlignment)1;
		txtGia_nt.Value = 0;
		lblGia_nt.AutoSize = true;
		Label obj14 = lblGia_nt;
		location = new Point(20, 101);
		((Control)obj14).Location = location;
		((Control)lblGia_nt).Name = "lblGia_nt";
		Label obj15 = lblGia_nt;
		size = new Size(41, 13);
		((Control)obj15).Size = size;
		((Control)lblGia_nt).TabIndex = 11;
		lblGia_nt.Text = "Giá NT";
		txtGia_vnd.DecimalSymbol = ".";
		txtGia_vnd.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtGia_vnd;
		location = new Point(121, 120);
		((Control)asTextNumeric3).Location = location;
		txtGia_vnd.Mask = "### ### ### ###.##";
		((Control)txtGia_vnd).Name = "txtGia_vnd";
		AsTextNumeric asTextNumeric4 = txtGia_vnd;
		size = new Size(131, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtGia_vnd).TabIndex = 5;
		((TextBox)txtGia_vnd).Text = "0.00";
		((TextBox)txtGia_vnd).TextAlign = (HorizontalAlignment)1;
		txtGia_vnd.Value = 0;
		lblGia_Vnd.AutoSize = true;
		Label obj16 = lblGia_Vnd;
		location = new Point(20, 124);
		((Control)obj16).Location = location;
		((Control)lblGia_Vnd).Name = "lblGia_Vnd";
		Label obj17 = lblGia_Vnd;
		size = new Size(49, 13);
		((Control)obj17).Size = size;
		((Control)lblGia_Vnd).TabIndex = 12;
		lblGia_Vnd.Text = "Giá VND";
		txtTygia.DecimalSymbol = ".";
		txtTygia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtTygia;
		location = new Point(184, 69);
		((Control)asTextNumeric5).Location = location;
		txtTygia.Mask = "### ### ### ###.##";
		((Control)txtTygia).Name = "txtTygia";
		AsTextNumeric asTextNumeric6 = txtTygia;
		size = new Size(68, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtTygia).TabIndex = 3;
		((TextBox)txtTygia).Text = "0.00";
		((TextBox)txtTygia).TextAlign = (HorizontalAlignment)1;
		txtTygia.Value = 0;
		txtMa_td.AutoLookup = true;
		txtMa_td.AutoValid = true;
		((TextBoxBase)txtMa_td).BackColor = SystemColors.Info;
		((TextBox)txtMa_td).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_td;
		location = new Point(121, 19);
		((Control)asTextBox).Location = location;
		txtMa_td.LookupCodeName = "MA_TD";
		((Control)txtMa_td).Name = "txtMa_td";
		txtMa_td.NameControl = lblTen_td;
		AsTextBox asTextBox2 = txtMa_td;
		size = new Size(59, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_td).TabIndex = 0;
		txtMa_pt.AutoLookup = true;
		txtMa_pt.AutoValid = true;
		((TextBoxBase)txtMa_pt).BackColor = SystemColors.Info;
		((TextBox)txtMa_pt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_pt;
		location = new Point(121, 44);
		((Control)asTextBox3).Location = location;
		txtMa_pt.LookupCodeName = "MA_PT";
		((Control)txtMa_pt).Name = "txtMa_pt";
		txtMa_pt.NameControl = lblTen_pt;
		AsTextBox asTextBox4 = txtMa_pt;
		size = new Size(59, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_pt).TabIndex = 1;
		((Control)txtMa_pt).Tag = "MA_PT";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(484, 202);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSODMDGVTEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_pt).Enabled = false;
		((Control)txtMa_td).Enabled = false;
	}

	protected override void InitAfterGetData()
	{
		if (!EditMode)
		{
			((ListControl)cboNt).SelectedValue = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		}
		else
		{
			GetTyGia();
		}
	}

	protected override void DataBinding()
	{
		base.DataBinding();
		Control ojb = (Control)(object)txtGia_nt;
		CreateDataBinding(ref ojb, "gia_nt", "value");
		txtGia_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGia_vnd;
		CreateDataBinding(ref ojb, "gia", "value");
		txtGia_vnd = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMa_pt;
		CreateDataBinding(ref ojb, "ma_pt");
		txtMa_pt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_td;
		CreateDataBinding(ref ojb, "ma_td");
		txtMa_td = (AsTextBox)(object)ojb;
		ojb = (Control)(object)cboNt;
		CreateDataBinding(ref ojb, "ma_nt", "SelectedValue");
		cboNt = (AsComboBoxNT)(object)ojb;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_td) || !ChkEmtyTextBox((TextBox)(object)txtMa_pt) || !base.ValidData())
		{
			return false;
		}
		return true;
	}

	private void cboNt_SelectedValueChanged(object sender, EventArgs e)
	{
		((Control)txtTygia).Enabled = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(((ComboBox)cboNt).Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)false, (object)true));
		GetTyGia();
	}

	private void GetTyGia()
	{
		txtTygia.Value = Commons.Get_TyGia(((ComboBox)cboNt).Text, DateAndTime.Now);
	}

	private void txtGia_nt_Validated(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtGia_nt.Value, (object)0, false))
		{
			txtGia_vnd.Value = Operators.MultiplyObject(txtGia_nt.Value, txtTygia.Value);
		}
	}
}
