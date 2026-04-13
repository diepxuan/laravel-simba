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
public class frmFADMNHTSEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("lblMa_Nhom")]
	private Label _lblMa_Nhom;

	[AccessedThroughProperty("txtMa_Nhom")]
	private TextBox _txtMa_Nhom;

	[AccessedThroughProperty("lblLoai_nhom")]
	private Label _lblLoai_nhom;

	[AccessedThroughProperty("txtTen_Nhom")]
	private TextBox _txtTen_Nhom;

	[AccessedThroughProperty("lblTen_Nhom")]
	private Label _lblTen_Nhom;

	[AccessedThroughProperty("cboLoai_Nhom")]
	private AsComboBox _cboLoai_Nhom;

	internal virtual Label lblMa_Nhom
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nhom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nhom = value;
		}
	}

	internal virtual TextBox txtMa_Nhom
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Nhom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyPressEventHandler val = new KeyPressEventHandler(txtMa_Nhom_KeyPress);
			if (_txtMa_Nhom != null)
			{
				((Control)_txtMa_Nhom).KeyPress -= val;
			}
			_txtMa_Nhom = value;
			if (_txtMa_Nhom != null)
			{
				((Control)_txtMa_Nhom).KeyPress += val;
			}
		}
	}

	internal virtual Label lblLoai_nhom
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai_nhom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai_nhom = value;
		}
	}

	internal virtual TextBox txtTen_Nhom
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Nhom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Nhom = value;
		}
	}

	internal virtual Label lblTen_Nhom
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhom = value;
		}
	}

	internal virtual AsComboBox cboLoai_Nhom
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_Nhom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_Nhom = value;
		}
	}

	[DebuggerNonUserCode]
	public frmFADMNHTSEdit()
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
		lblMa_Nhom = new Label();
		txtMa_Nhom = new TextBox();
		lblTen_Nhom = new Label();
		txtTen_Nhom = new TextBox();
		lblLoai_nhom = new Label();
		cboLoai_Nhom = new AsComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(77, 96);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 3;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 133);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 133);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)cboLoai_Nhom);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Nhom);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Nhom);
		((Control)gbLine).Controls.Add((Control)(object)lblLoai_nhom);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Nhom);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Nhom);
		GroupBox obj3 = gbLine;
		Size size = new Size(404, 121);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Nhom, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Nhom, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblLoai_nhom, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Nhom, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Nhom, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai_Nhom, 0);
		lblMa_Nhom.AutoSize = true;
		Label obj4 = lblMa_Nhom;
		location = new Point(14, 22);
		((Control)obj4).Location = location;
		((Control)lblMa_Nhom).Name = "lblMa_Nhom";
		Label obj5 = lblMa_Nhom;
		size = new Size(51, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_Nhom).TabIndex = 100;
		lblMa_Nhom.Text = "Mã nhóm";
		txtMa_Nhom.CharacterCasing = (CharacterCasing)1;
		TextBox obj6 = txtMa_Nhom;
		location = new Point(77, 18);
		((Control)obj6).Location = location;
		((Control)txtMa_Nhom).Name = "txtMa_Nhom";
		TextBox obj7 = txtMa_Nhom;
		size = new Size(90, 20);
		((Control)obj7).Size = size;
		((Control)txtMa_Nhom).TabIndex = 0;
		lblTen_Nhom.AutoSize = true;
		Label obj8 = lblTen_Nhom;
		location = new Point(14, 47);
		((Control)obj8).Location = location;
		((Control)lblTen_Nhom).Name = "lblTen_Nhom";
		Label obj9 = lblTen_Nhom;
		size = new Size(55, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_Nhom).TabIndex = 100;
		lblTen_Nhom.Text = "Tên nhóm";
		TextBox obj10 = txtTen_Nhom;
		location = new Point(77, 43);
		((Control)obj10).Location = location;
		((Control)txtTen_Nhom).Name = "txtTen_Nhom";
		TextBox obj11 = txtTen_Nhom;
		size = new Size(303, 20);
		((Control)obj11).Size = size;
		((Control)txtTen_Nhom).TabIndex = 1;
		lblLoai_nhom.AutoSize = true;
		Label obj12 = lblLoai_nhom;
		location = new Point(14, 72);
		((Control)obj12).Location = location;
		((Control)lblLoai_nhom).Name = "lblLoai_nhom";
		Label obj13 = lblLoai_nhom;
		size = new Size(56, 13);
		((Control)obj13).Size = size;
		((Control)lblLoai_nhom).TabIndex = 102;
		lblLoai_nhom.Text = "Loại nhóm";
		((ComboBox)cboLoai_Nhom).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_Nhom).FormattingEnabled = true;
		((ComboBox)cboLoai_Nhom).Items.AddRange(new object[3] { " Nhóm 1", " Nhóm 2", " Nhóm 3" });
		AsComboBox asComboBox = cboLoai_Nhom;
		location = new Point(77, 68);
		((Control)asComboBox).Location = location;
		((Control)cboLoai_Nhom).Name = "cboLoai_Nhom";
		AsComboBox asComboBox2 = cboLoai_Nhom;
		size = new Size(90, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboLoai_Nhom).TabIndex = 2;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(428, 168);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFADMNHTSEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_Nhom).MaxLength = base.MyDictComplexInfo.code_length;
		((Control)txtMa_Nhom).Select();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		AsComboBox asComboBox = cboLoai_Nhom;
		dictionary.Add("1", Conversions.ToString(((ComboBox)asComboBox).Items[0]));
		dictionary.Add("2", Conversions.ToString(((ComboBox)asComboBox).Items[1]));
		dictionary.Add("3", Conversions.ToString(((ComboBox)asComboBox).Items[2]));
		BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
		((ComboBox)asComboBox).DataSource = dataSource;
		((ListControl)asComboBox).DisplayMember = "value";
		((ListControl)asComboBox).ValueMember = "key";
		asComboBox = null;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			((ComboBox)cboLoai_Nhom).SelectedIndex = 0;
		}
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_Nhom;
		CreateDataBinding(ref ojb, "ma_nhts");
		txtMa_Nhom = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Nhom;
		CreateDataBinding(ref ojb, "ten_nhts");
		txtTen_Nhom = (TextBox)ojb;
		ojb = (Control)(object)cboLoai_Nhom;
		CreateDataBinding(ref ojb, "loai_nh", "SelectedValue");
		cboLoai_Nhom = (AsComboBox)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((TextBoxBase)txtMa_Nhom).ReadOnly = true;
		((Control)cboLoai_Nhom).Enabled = false;
		((Control)txtTen_Nhom).Select();
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox(txtMa_Nhom) || !ChkEmtyTextBox(txtTen_Nhom) || !base.ValidData())
		{
			return false;
		}
		return true;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_Nhom).Select();
		}
		return flag;
	}

	private void txtMa_Nhom_KeyPress(object sender, KeyPressEventArgs e)
	{
		e.KeyChar = char.ToUpper(e.KeyChar);
	}
}
