using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCoDD1Edit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("txtMa_Spct")]
	private AsTextBox _txtMa_Spct;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtTien")]
	private AsTextNumeric _txtTien;

	[AccessedThroughProperty("lblTien_nt")]
	private Label _lblTien_nt;

	[AccessedThroughProperty("txtSo_luong")]
	private AsTextNumeric _txtSo_luong;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("txtTK")]
	private AsTextBox _txtTK;

	[AccessedThroughProperty("lblTK")]
	private Label _lblTK;

	internal virtual AsTextBox txtMa_Spct
	{
		get
		{
			return _txtMa_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_Spct = value;
		}
	}

	internal virtual Label lblTen_vt
	{
		get
		{
			return _lblTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_vt = value;
		}
	}

	internal virtual Label lblMa_vt
	{
		get
		{
			return _lblMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_vt = value;
		}
	}

	internal virtual AsTextNumeric txtTien
	{
		get
		{
			return _txtTien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTien = value;
		}
	}

	internal virtual Label lblTien_nt
	{
		get
		{
			return _lblTien_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTien_nt = value;
		}
	}

	internal virtual AsTextNumeric txtSo_luong
	{
		get
		{
			return _txtSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_luong = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label lblTen_tk
	{
		get
		{
			return _lblTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_tk = value;
		}
	}

	internal virtual AsTextBox txtTK
	{
		get
		{
			return _txtTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTK = value;
		}
	}

	internal virtual Label lblTK
	{
		get
		{
			return _lblTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTK = value;
		}
	}

	public frmCoDD1Edit()
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		txtTien = new AsTextNumeric();
		lblTien_nt = new Label();
		txtMa_Spct = new AsTextBox();
		lblTen_vt = new Label();
		lblMa_vt = new Label();
		txtSo_luong = new AsTextNumeric();
		Label1 = new Label();
		txtTK = new AsTextBox();
		lblTen_tk = new Label();
		lblTK = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Anchor = (AnchorStyles)5;
		((Control)chkKsd).Enabled = false;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(394, 181);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 2;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 142);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 142);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk);
		((Control)gbLine).Controls.Add((Control)(object)txtTK);
		((Control)gbLine).Controls.Add((Control)(object)lblTK);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_luong);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Spct);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_vt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_vt);
		((Control)gbLine).Controls.Add((Control)(object)txtTien);
		((Control)gbLine).Controls.Add((Control)(object)lblTien_nt);
		GroupBox obj3 = gbLine;
		Size size = new Size(498, 130);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTien_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_luong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		txtTien.DecimalSymbol = ".";
		txtTien.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtTien;
		location = new Point(96, 97);
		((Control)asTextNumeric).Location = location;
		txtTien.Mask = "### ### ### ###";
		((Control)txtTien).Name = "txtTien";
		AsTextNumeric asTextNumeric2 = txtTien;
		size = new Size(98, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTien).TabIndex = 3;
		((TextBox)txtTien).Text = "0";
		((TextBox)txtTien).TextAlign = (HorizontalAlignment)1;
		txtTien.Value = 0;
		lblTien_nt.AutoSize = true;
		Label obj4 = lblTien_nt;
		location = new Point(13, 101);
		((Control)obj4).Location = location;
		((Control)lblTien_nt).Name = "lblTien_nt";
		Label obj5 = lblTien_nt;
		size = new Size(34, 13);
		((Control)obj5).Size = size;
		((Control)lblTien_nt).TabIndex = 18;
		lblTien_nt.Text = "Giá trị";
		txtMa_Spct.AutoLookup = true;
		txtMa_Spct.AutoValid = true;
		((TextBoxBase)txtMa_Spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_Spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Spct;
		location = new Point(96, 45);
		((Control)asTextBox).Location = location;
		txtMa_Spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_Spct).Name = "txtMa_Spct";
		txtMa_Spct.NameControl = lblTen_vt;
		txtMa_Spct.SD = true;
		AsTextBox asTextBox2 = txtMa_Spct;
		size = new Size(98, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Spct).TabIndex = 1;
		txtMa_Spct.UseAutoCompleteSource = true;
		Label obj6 = lblTen_vt;
		location = new Point(200, 48);
		((Control)obj6).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj7 = lblTen_vt;
		size = new Size(292, 17);
		((Control)obj7).Size = size;
		((Control)lblTen_vt).TabIndex = 25;
		lblMa_vt.AutoSize = true;
		Label obj8 = lblMa_vt;
		location = new Point(13, 49);
		((Control)obj8).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj9 = lblMa_vt;
		size = new Size(71, 13);
		((Control)obj9).Size = size;
		((Control)lblMa_vt).TabIndex = 26;
		lblMa_vt.Text = "Mã sản phẩm";
		txtSo_luong.DecimalSymbol = ".";
		txtSo_luong.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtSo_luong;
		location = new Point(96, 71);
		((Control)asTextNumeric3).Location = location;
		txtSo_luong.Mask = "### ### ### ###";
		((Control)txtSo_luong).Name = "txtSo_luong";
		AsTextNumeric asTextNumeric4 = txtSo_luong;
		size = new Size(98, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtSo_luong).TabIndex = 2;
		((TextBox)txtSo_luong).Text = "0";
		((TextBox)txtSo_luong).TextAlign = (HorizontalAlignment)1;
		txtSo_luong.Value = 0;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(13, 75);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(49, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 28;
		Label1.Text = "Số lượng";
		txtTK.AutoLookup = true;
		txtTK.AutoValid = true;
		((TextBoxBase)txtTK).BackColor = SystemColors.Info;
		((TextBox)txtTK).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTK;
		location = new Point(96, 19);
		((Control)asTextBox3).Location = location;
		txtTK.LookupCodeName = "TK";
		txtTK.LookupWhereCondition = "chi_tiet='1' and ksd='0'";
		((Control)txtTK).Name = "txtTK";
		txtTK.NameControl = lblTen_tk;
		txtTK.SD = true;
		AsTextBox asTextBox4 = txtTK;
		size = new Size(98, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTK).TabIndex = 0;
		txtTK.UseAutoCompleteSource = true;
		Label obj10 = lblTen_tk;
		location = new Point(200, 23);
		((Control)obj10).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj11 = lblTen_tk;
		size = new Size(292, 17);
		((Control)obj11).Size = size;
		((Control)lblTen_tk).TabIndex = 31;
		lblTK.AutoSize = true;
		Label obj12 = lblTK;
		location = new Point(13, 23);
		((Control)obj12).Location = location;
		((Control)lblTK).Name = "lblTK";
		Label obj13 = lblTK;
		size = new Size(55, 13);
		((Control)obj13).Size = size;
		((Control)lblTK).TabIndex = 30;
		lblTK.Text = "Tài khoản";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(520, 172);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCoDD1Edit";
		((Form)this).Text = "frmCoDD1Edit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		txtSo_luong.Mask = Environment.GetSIConfiguration().Qty_Input_Format;
		txtTien.Mask = Environment.GetSIConfiguration().Price_Input_Format;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_Spct).Enabled = false;
		((Control)txtTK).Enabled = false;
		((Control)txtSo_luong).Select();
	}

	protected override bool ValidData()
	{
		if (Operators.CompareString(((TextBox)txtTK).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtTK, Helper.GetMess(50002).Description);
			return false;
		}
		epNotice.SetError((Control)(object)txtTK, "");
		if (Operators.CompareString(((TextBox)txtMa_Spct).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtMa_Spct, Helper.GetMess(50002).Description);
			return false;
		}
		epNotice.SetError((Control)(object)txtMa_Spct, "");
		if (Operators.ConditionalCompareObjectEqual(txtSo_luong.Value, (object)0, false))
		{
			epNotice.SetError((Control)(object)txtSo_luong, Helper.GetMess(50044).Description);
			return false;
		}
		epNotice.SetError((Control)(object)txtSo_luong, "");
		return base.ValidData();
	}

	protected override void DataBinding()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtTK;
		CreateDataBinding(ref ojb, "TK");
		txtTK = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_Spct;
		CreateDataBinding(ref ojb, "Ma_spct");
		txtMa_Spct = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_luong;
		CreateDataBinding(ref ojb, "sl_dd_ck", "Value");
		txtSo_luong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien;
		CreateDataBinding(ref ojb, "gt_dd_ck", "Value");
		txtTien = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)lblTen_vt;
		CreateDataBinding(ref ojb, "ten_spct");
		lblTen_vt = (Label)ojb;
	}
}
