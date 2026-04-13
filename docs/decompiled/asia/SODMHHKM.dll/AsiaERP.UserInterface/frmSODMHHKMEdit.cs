using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmSODMHHKMEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblMa_km")]
	private Label _lblMa_km;

	[AccessedThroughProperty("txtSo_luong")]
	private AsTextNumeric _txtSo_luong;

	[AccessedThroughProperty("txtMuc_km")]
	private AsTextNumeric _txtMuc_km;

	[AccessedThroughProperty("cboLoai_km")]
	private AsComboBox _cboLoai_km;

	[AccessedThroughProperty("lblLoai")]
	private Label _lblLoai;

	[AccessedThroughProperty("lblMuc_km")]
	private Label _lblMuc_km;

	[AccessedThroughProperty("lblSoLuong")]
	private Label _lblSoLuong;

	[AccessedThroughProperty("txtMa_km")]
	private AsTextBox _txtMa_km;

	[AccessedThroughProperty("lblTen_km")]
	private Label _lblTen_km;

	internal virtual AsTextBox txtMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_vt = value;
		}
	}

	internal virtual Label lblMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_vt = value;
		}
	}

	internal virtual Label lblTen_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_vt = value;
		}
	}

	internal virtual Label lblMa_km
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_km;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_km = value;
		}
	}

	internal virtual AsTextNumeric txtSo_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_luong = value;
		}
	}

	internal virtual AsTextNumeric txtMuc_km
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMuc_km;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMuc_km = value;
		}
	}

	internal virtual AsComboBox cboLoai_km
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_km;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboLoai_km_SelectedValueChanged;
			if (_cboLoai_km != null)
			{
				((ListControl)_cboLoai_km).SelectedValueChanged -= eventHandler;
			}
			_cboLoai_km = value;
			if (_cboLoai_km != null)
			{
				((ListControl)_cboLoai_km).SelectedValueChanged += eventHandler;
			}
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

	internal virtual Label lblMuc_km
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMuc_km;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMuc_km = value;
		}
	}

	internal virtual Label lblSoLuong
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSoLuong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSoLuong = value;
		}
	}

	internal virtual AsTextBox txtMa_km
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_km;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_km = value;
		}
	}

	internal virtual Label lblTen_km
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_km;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_km = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSODMHHKMEdit()
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		lblMa_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		lblMa_km = new Label();
		cboLoai_km = new AsComboBox();
		lblLoai = new Label();
		txtSo_luong = new AsTextNumeric();
		lblSoLuong = new Label();
		lblMuc_km = new Label();
		txtMuc_km = new AsTextNumeric();
		lblTen_km = new Label();
		txtMa_km = new AsTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(81, 153);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 5;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 197);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 197);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtSo_luong);
		((Control)gbLine).Controls.Add((Control)(object)txtMuc_km);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_km);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_vt);
		((Control)gbLine).Controls.Add((Control)(object)cboLoai_km);
		((Control)gbLine).Controls.Add((Control)(object)lblMuc_km);
		((Control)gbLine).Controls.Add((Control)(object)lblSoLuong);
		((Control)gbLine).Controls.Add((Control)(object)lblLoai);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_km);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_km);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_vt);
		GroupBox obj3 = gbLine;
		Size size = new Size(444, 185);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_km, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_km, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblLoai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSoLuong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMuc_km, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai_km, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_km, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMuc_km, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_luong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		lblMa_vt.AutoSize = true;
		Label obj4 = lblMa_vt;
		location = new Point(17, 78);
		((Control)obj4).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj5 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_vt).TabIndex = 100;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = true;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_vt;
		location = new Point(81, 74);
		((Control)asTextBox).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox2 = txtMa_vt;
		size = new Size(117, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_vt).TabIndex = 2;
		Label obj6 = lblTen_vt;
		location = new Point(204, 78);
		((Control)obj6).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj7 = lblTen_vt;
		size = new Size(226, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_vt).TabIndex = 100;
		lblMa_km.AutoSize = true;
		Label obj8 = lblMa_km;
		location = new Point(17, 25);
		((Control)obj8).Location = location;
		((Control)lblMa_km).Name = "lblMa_km";
		Label obj9 = lblMa_km;
		size = new Size(41, 13);
		((Control)obj9).Size = size;
		((Control)lblMa_km).TabIndex = 100;
		lblMa_km.Text = "Mã KM";
		((ComboBox)cboLoai_km).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_km).FormattingEnabled = true;
		((ComboBox)cboLoai_km).Items.AddRange(new object[2] { "Theo hóa đơn", "Theo mặt hàng" });
		AsComboBox asComboBox = cboLoai_km;
		location = new Point(81, 47);
		((Control)asComboBox).Location = location;
		((Control)cboLoai_km).Name = "cboLoai_km";
		AsComboBox asComboBox2 = cboLoai_km;
		size = new Size(117, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboLoai_km).TabIndex = 1;
		lblLoai.AutoSize = true;
		Label obj10 = lblLoai;
		location = new Point(17, 51);
		((Control)obj10).Location = location;
		((Control)lblLoai).Name = "lblLoai";
		Label obj11 = lblLoai;
		size = new Size(27, 13);
		((Control)obj11).Size = size;
		((Control)lblLoai).TabIndex = 100;
		lblLoai.Text = "Loại";
		txtSo_luong.DecimalSymbol = ".";
		txtSo_luong.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtSo_luong;
		location = new Point(81, 100);
		((Control)asTextNumeric).Location = location;
		txtSo_luong.Mask = "### ### ### ###.##";
		((Control)txtSo_luong).Name = "txtSo_luong";
		AsTextNumeric asTextNumeric2 = txtSo_luong;
		size = new Size(117, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtSo_luong).TabIndex = 3;
		((TextBox)txtSo_luong).Text = "0.00";
		((TextBox)txtSo_luong).TextAlign = (HorizontalAlignment)1;
		txtSo_luong.Value = 0;
		lblSoLuong.AutoSize = true;
		Label obj12 = lblSoLuong;
		location = new Point(17, 104);
		((Control)obj12).Location = location;
		((Control)lblSoLuong).Name = "lblSoLuong";
		Label obj13 = lblSoLuong;
		size = new Size(49, 13);
		((Control)obj13).Size = size;
		((Control)lblSoLuong).TabIndex = 100;
		lblSoLuong.Text = "Số lượng";
		lblMuc_km.AutoSize = true;
		Label obj14 = lblMuc_km;
		location = new Point(17, 130);
		((Control)obj14).Location = location;
		((Control)lblMuc_km).Name = "lblMuc_km";
		Label obj15 = lblMuc_km;
		size = new Size(47, 13);
		((Control)obj15).Size = size;
		((Control)lblMuc_km).TabIndex = 100;
		lblMuc_km.Text = "Mức KM";
		txtMuc_km.DecimalSymbol = ".";
		txtMuc_km.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtMuc_km;
		location = new Point(81, 126);
		((Control)asTextNumeric3).Location = location;
		txtMuc_km.Mask = "### ### ### ###.##";
		((Control)txtMuc_km).Name = "txtMuc_km";
		AsTextNumeric asTextNumeric4 = txtMuc_km;
		size = new Size(117, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtMuc_km).TabIndex = 4;
		((TextBox)txtMuc_km).Text = "0.00";
		((TextBox)txtMuc_km).TextAlign = (HorizontalAlignment)1;
		txtMuc_km.Value = 0;
		Label obj16 = lblTen_km;
		location = new Point(204, 25);
		((Control)obj16).Location = location;
		((Control)lblTen_km).Name = "lblTen_km";
		Label obj17 = lblTen_km;
		size = new Size(226, 13);
		((Control)obj17).Size = size;
		((Control)lblTen_km).TabIndex = 100;
		txtMa_km.AutoLookup = true;
		txtMa_km.AutoValid = true;
		((TextBoxBase)txtMa_km).BackColor = SystemColors.Info;
		((TextBox)txtMa_km).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_km;
		location = new Point(81, 21);
		((Control)asTextBox3).Location = location;
		txtMa_km.LookupCodeName = "MA_KM";
		((Control)txtMa_km).Name = "txtMa_km";
		txtMa_km.NameControl = lblTen_km;
		AsTextBox asTextBox4 = txtMa_km;
		size = new Size(117, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_km).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(468, 232);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSODMHHKMEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_km) || !ChkEmtyTextBox((TextBox)(object)txtMa_vt) || !base.ValidData())
		{
			return false;
		}
		return true;
	}

	protected override void InitBeforeGetData()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		base.InitBeforeGetData();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		AsComboBox asComboBox = cboLoai_km;
		dictionary.Add("1", Conversions.ToString(((ComboBox)asComboBox).Items[0]));
		dictionary.Add("2", Conversions.ToString(((ComboBox)asComboBox).Items[1]));
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
			((ComboBox)cboLoai_km).SelectedIndex = 1;
		}
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_km).Enabled = false;
		((Control)txtMa_vt).Enabled = false;
		((Control)cboLoai_km).Select();
	}

	protected override void DataBinding()
	{
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_km;
		CreateDataBinding(ref ojb, "ma_km");
		txtMa_km = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_vt;
		CreateDataBinding(ref ojb, "ma_vt");
		txtMa_vt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_luong;
		CreateDataBinding(ref ojb, "sl_km", "value");
		txtSo_luong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMuc_km;
		CreateDataBinding(ref ojb, "muc_km", "value");
		txtMuc_km = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)cboLoai_km;
		CreateDataBinding(ref ojb, "loai_km", "SelectedValue");
		cboLoai_km = (AsComboBox)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "ksd", "checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	private void cboLoai_km_SelectedValueChanged(object sender, EventArgs e)
	{
		if (!EditMode)
		{
			if (Operators.ConditionalCompareObjectEqual(((ListControl)cboLoai_km).SelectedValue, (object)1, false))
			{
				((TextBoxBase)txtMa_vt).ReadOnly = true;
			}
			else
			{
				((TextBoxBase)txtMa_vt).ReadOnly = false;
			}
		}
	}
}
