using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmARDMPLKHEdit : frmDMEdit
{
	private IContainer components;

	[AccessedThroughProperty("lblLoai")]
	private Label _lblLoai;

	[AccessedThroughProperty("txtTen_PlKh")]
	private TextBox _txtTen_PlKh;

	[AccessedThroughProperty("lblTen_PlKh")]
	private Label _lblTen_PlKh;

	[AccessedThroughProperty("txtMa_PlKh")]
	private TextBox _txtMa_PlKh;

	[AccessedThroughProperty("lblMa_PlKh")]
	private Label _lblMa_PlKh;

	[AccessedThroughProperty("cboLoai")]
	private ComboBox _cboLoai;

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

	internal virtual TextBox txtTen_PlKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_PlKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_PlKh = value;
		}
	}

	internal virtual Label lblTen_PlKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_PlKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_PlKh = value;
		}
	}

	internal virtual TextBox txtMa_PlKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_PlKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_PlKh = value;
		}
	}

	internal virtual Label lblMa_PlKh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_PlKh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_PlKh = value;
		}
	}

	internal virtual ComboBox cboLoai
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai = value;
		}
	}

	[DebuggerNonUserCode]
	public frmARDMPLKHEdit()
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
		lblLoai = new Label();
		txtTen_PlKh = new TextBox();
		lblTen_PlKh = new Label();
		txtMa_PlKh = new TextBox();
		lblMa_PlKh = new Label();
		cboLoai = new ComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Anchor = (AnchorStyles)5;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(118, 97);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 3;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 139);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 139);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)cboLoai);
		((Control)gbLine).Controls.Add((Control)(object)lblLoai);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_PlKh);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_PlKh);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_PlKh);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_PlKh);
		GroupBox obj3 = gbLine;
		Size size = new Size(477, 126);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_PlKh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_PlKh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_PlKh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_PlKh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblLoai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai, 0);
		lblLoai.AutoSize = true;
		Label obj4 = lblLoai;
		location = new Point(14, 75);
		((Control)obj4).Location = location;
		((Control)lblLoai).Name = "lblLoai";
		Label obj5 = lblLoai;
		size = new Size(28, 13);
		((Control)obj5).Size = size;
		((Control)lblLoai).TabIndex = 110;
		lblLoai.Text = "Kiểu";
		TextBox obj6 = txtTen_PlKh;
		location = new Point(118, 45);
		((Control)obj6).Location = location;
		((TextBoxBase)txtTen_PlKh).MaxLength = 128;
		((Control)txtTen_PlKh).Name = "txtTen_PlKh";
		TextBox obj7 = txtTen_PlKh;
		size = new Size(337, 20);
		((Control)obj7).Size = size;
		((Control)txtTen_PlKh).TabIndex = 1;
		lblTen_PlKh.AutoSize = true;
		Label obj8 = lblTen_PlKh;
		location = new Point(14, 49);
		((Control)obj8).Location = location;
		((Control)lblTen_PlKh).Name = "lblTen_PlKh";
		Label obj9 = lblTen_PlKh;
		size = new Size(72, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_PlKh).TabIndex = 109;
		lblTen_PlKh.Text = "Tên phân loại";
		txtMa_PlKh.CharacterCasing = (CharacterCasing)1;
		TextBox obj10 = txtMa_PlKh;
		location = new Point(118, 19);
		((Control)obj10).Location = location;
		((Control)txtMa_PlKh).Name = "txtMa_PlKh";
		TextBox obj11 = txtMa_PlKh;
		size = new Size(85, 20);
		((Control)obj11).Size = size;
		((Control)txtMa_PlKh).TabIndex = 0;
		lblMa_PlKh.AutoSize = true;
		Label obj12 = lblMa_PlKh;
		location = new Point(14, 23);
		((Control)obj12).Location = location;
		((Control)lblMa_PlKh).Name = "lblMa_PlKh";
		Label obj13 = lblMa_PlKh;
		size = new Size(68, 13);
		((Control)obj13).Size = size;
		((Control)lblMa_PlKh).TabIndex = 108;
		lblMa_PlKh.Text = "Mã phân loại";
		cboLoai.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai).FormattingEnabled = true;
		cboLoai.Items.AddRange(new object[3] { "1", "2", "3" });
		ComboBox obj14 = cboLoai;
		location = new Point(118, 70);
		((Control)obj14).Location = location;
		((Control)cboLoai).Name = "cboLoai";
		ComboBox obj15 = cboLoai;
		size = new Size(51, 21);
		((Control)obj15).Size = size;
		((Control)cboLoai).TabIndex = 2;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(499, 169);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmARDMPLKHEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		cboLoai.SelectedIndex = 0;
		((TextBoxBase)txtMa_PlKh).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_PlKh).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_PlKh).Enabled = false;
		((Control)cboLoai).Enabled = false;
		((Control)txtTen_PlKh).Select();
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_PlKh;
		CreateDataBinding(ref ojb, "Ma_PlKh");
		txtMa_PlKh = (TextBox)ojb;
		ojb = (Control)(object)txtTen_PlKh;
		CreateDataBinding(ref ojb, "Ten_PlKh");
		txtTen_PlKh = (TextBox)ojb;
		ojb = (Control)(object)cboLoai;
		CreateDataBinding(ref ojb, "Loai", "SelectedItem");
		cboLoai = (ComboBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox(txtMa_PlKh) || !ChkEmtyTextBox(txtTen_PlKh) || !base.ValidData())
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
			((Control)txtMa_PlKh).Select();
		}
		return flag;
	}
}
