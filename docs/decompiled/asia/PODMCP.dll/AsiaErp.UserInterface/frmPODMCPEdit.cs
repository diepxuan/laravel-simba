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
public class frmPODMCPEdit : frmDMEdit
{
	private IContainer components;

	[AccessedThroughProperty("lblTen_cp")]
	private Label _lblTen_cp;

	[AccessedThroughProperty("txtTen_cp")]
	private TextBox _txtTen_cp;

	[AccessedThroughProperty("lblMa_cp")]
	private Label _lblMa_cp;

	[AccessedThroughProperty("txtMa_cp")]
	private TextBox _txtMa_cp;

	[AccessedThroughProperty("cbott_pb")]
	private ComboBox _cbott_pb;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	internal virtual Label lblTen_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_cp = value;
		}
	}

	internal virtual TextBox txtTen_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_cp = value;
		}
	}

	internal virtual Label lblMa_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_cp = value;
		}
	}

	internal virtual TextBox txtMa_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_cp = value;
		}
	}

	internal virtual ComboBox cbott_pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _cbott_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cbott_pb = value;
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

	[DebuggerNonUserCode]
	public frmPODMCPEdit()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
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
		lblMa_cp = new Label();
		txtMa_cp = new TextBox();
		lblTen_cp = new Label();
		txtTen_cp = new TextBox();
		Label1 = new Label();
		cbott_pb = new ComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(113, 96);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 133);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 133);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)cbott_pb);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_cp);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_cp);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_cp);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_cp);
		GroupBox obj3 = gbLine;
		Size size = new Size(468, 121);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_cp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_cp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_cp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_cp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cbott_pb, 0);
		lblMa_cp.AutoSize = true;
		Label obj4 = lblMa_cp;
		location = new Point(13, 20);
		((Control)obj4).Location = location;
		((Control)lblMa_cp).Name = "lblMa_cp";
		Label obj5 = lblMa_cp;
		size = new Size(58, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_cp).TabIndex = 100;
		lblMa_cp.Text = "Mã chi phí";
		txtMa_cp.CharacterCasing = (CharacterCasing)1;
		TextBox obj6 = txtMa_cp;
		location = new Point(113, 17);
		((Control)obj6).Location = location;
		((TextBoxBase)txtMa_cp).MaxLength = 20;
		((Control)txtMa_cp).Name = "txtMa_cp";
		TextBox obj7 = txtMa_cp;
		size = new Size(98, 20);
		((Control)obj7).Size = size;
		((Control)txtMa_cp).TabIndex = 0;
		lblTen_cp.AutoSize = true;
		Label obj8 = lblTen_cp;
		location = new Point(13, 46);
		((Control)obj8).Location = location;
		((Control)lblTen_cp).Name = "lblTen_cp";
		Label obj9 = lblTen_cp;
		size = new Size(62, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_cp).TabIndex = 102;
		lblTen_cp.Text = "Tên chi phí";
		TextBox obj10 = txtTen_cp;
		location = new Point(113, 43);
		((Control)obj10).Location = location;
		((TextBoxBase)txtTen_cp).MaxLength = 128;
		((Control)txtTen_cp).Name = "txtTen_cp";
		TextBox obj11 = txtTen_cp;
		size = new Size(335, 20);
		((Control)obj11).Size = size;
		((Control)txtTen_cp).TabIndex = 1;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(13, 72);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(94, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 103;
		Label1.Text = "Tiêu thức phân bổ";
		cbott_pb.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cbott_pb).FormattingEnabled = true;
		cbott_pb.Items.AddRange(new object[2] { "1 - Theo số lượng", "2 - Theo tiền mua" });
		ComboBox obj12 = cbott_pb;
		location = new Point(113, 69);
		((Control)obj12).Location = location;
		((Control)cbott_pb).Name = "cbott_pb";
		ComboBox obj13 = cbott_pb;
		size = new Size(122, 21);
		((Control)obj13).Size = size;
		((Control)cbott_pb).TabIndex = 104;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(492, 168);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmPODMCPEdit";
		((Form)this).Text = "frmPODMCPEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		base.InitBeforeGetData();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		ComboBox val = cbott_pb;
		dictionary.Add("1", Conversions.ToString(val.Items[0]));
		dictionary.Add("2", Conversions.ToString(val.Items[1]));
		BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
		val.DataSource = dataSource;
		((ListControl)val).DisplayMember = "value";
		((ListControl)val).ValueMember = "key";
		val = null;
		((TextBoxBase)txtMa_cp).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_cp).Select();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			cbott_pb.SelectedIndex = 0;
		}
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_cp).Enabled = false;
		((Control)txtTen_cp).Select();
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_cp;
		CreateDataBinding(ref ojb, "Ma_cp");
		txtMa_cp = (TextBox)ojb;
		ojb = (Control)(object)txtTen_cp;
		CreateDataBinding(ref ojb, "Ten_cp");
		txtTen_cp = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)cbott_pb;
		CreateDataBinding(ref ojb, "tt_pb", "SelectedValue");
		cbott_pb = (ComboBox)ojb;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox(txtMa_cp) || !ChkEmtyTextBox(txtTen_cp) || !base.ValidData())
		{
			return false;
		}
		return true;
	}
}
