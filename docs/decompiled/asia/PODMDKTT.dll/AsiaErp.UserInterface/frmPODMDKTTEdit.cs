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
public class frmPODMDKTTEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_tt_po")]
	private TextBox _txtMa_tt_po;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	[AccessedThroughProperty("txtMo_ta")]
	private TextBox _txtMo_ta;

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

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

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtls_qh")]
	private AsTextNumeric _txtls_qh;

	[AccessedThroughProperty("txtHan_tt")]
	private AsTextNumeric _txtHan_tt;

	[AccessedThroughProperty("txttl_ck")]
	private AsTextNumeric _txttl_ck;

	[AccessedThroughProperty("txtHan_ck")]
	private AsTextNumeric _txtHan_ck;

	internal virtual TextBox txtMa_tt_po
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_tt_po;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_tt_po = value;
		}
	}

	internal virtual Label lblMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Bp = value;
		}
	}

	internal virtual TextBox txtMo_ta
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMo_ta;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMo_ta = value;
		}
	}

	internal virtual Label lblTen_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Bp = value;
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

	internal virtual AsTextNumeric txtls_qh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtls_qh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtls_qh_Validated;
			if (_txtls_qh != null)
			{
				((Control)_txtls_qh).TextChanged -= eventHandler;
			}
			_txtls_qh = value;
			if (_txtls_qh != null)
			{
				((Control)_txtls_qh).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtHan_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHan_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtHan_tt_Validated;
			if (_txtHan_tt != null)
			{
				((Control)_txtHan_tt).TextChanged -= eventHandler;
			}
			_txtHan_tt = value;
			if (_txtHan_tt != null)
			{
				((Control)_txtHan_tt).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txttl_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _txttl_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txttl_ck_Validated;
			if (_txttl_ck != null)
			{
				((Control)_txttl_ck).TextChanged -= eventHandler;
			}
			_txttl_ck = value;
			if (_txttl_ck != null)
			{
				((Control)_txttl_ck).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtHan_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHan_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtHan_ck_Validated;
			if (_txtHan_ck != null)
			{
				((Control)_txtHan_ck).TextChanged -= eventHandler;
			}
			_txtHan_ck = value;
			if (_txtHan_ck != null)
			{
				((Control)_txtHan_ck).TextChanged += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public frmPODMDKTTEdit()
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
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
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
		txtMa_tt_po = new TextBox();
		lblMa_Bp = new Label();
		txtMo_ta = new TextBox();
		lblTen_Bp = new Label();
		txtHan_ck = new AsTextNumeric();
		txttl_ck = new AsTextNumeric();
		txtHan_tt = new AsTextNumeric();
		txtls_qh = new AsTextNumeric();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Anchor = (AnchorStyles)5;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(106, 173);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 6;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 207);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 207);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtls_qh);
		((Control)gbLine).Controls.Add((Control)(object)txtHan_tt);
		((Control)gbLine).Controls.Add((Control)(object)txttl_ck);
		((Control)gbLine).Controls.Add((Control)(object)txtHan_ck);
		((Control)gbLine).Controls.Add((Control)(object)txtMo_ta);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Bp);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_tt_po);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Bp);
		GroupBox obj3 = gbLine;
		Size size = new Size(426, 194);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_tt_po, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMo_ta, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtHan_ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txttl_ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtHan_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtls_qh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		txtMa_tt_po.CharacterCasing = (CharacterCasing)1;
		TextBox obj4 = txtMa_tt_po;
		location = new Point(106, 17);
		((Control)obj4).Location = location;
		((Control)txtMa_tt_po).Name = "txtMa_tt_po";
		TextBox obj5 = txtMa_tt_po;
		size = new Size(100, 20);
		((Control)obj5).Size = size;
		((Control)txtMa_tt_po).TabIndex = 0;
		lblMa_Bp.AutoSize = true;
		Label obj6 = lblMa_Bp;
		location = new Point(8, 20);
		((Control)obj6).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj7 = lblMa_Bp;
		size = new Size(76, 13);
		((Control)obj7).Size = size;
		((Control)lblMa_Bp).TabIndex = 8;
		lblMa_Bp.Text = "Mã thanh toán";
		TextBox obj8 = txtMo_ta;
		location = new Point(106, 147);
		((Control)obj8).Location = location;
		((TextBoxBase)txtMo_ta).MaxLength = 1000;
		((Control)txtMo_ta).Name = "txtMo_ta";
		TextBox obj9 = txtMo_ta;
		size = new Size(313, 20);
		((Control)obj9).Size = size;
		((Control)txtMo_ta).TabIndex = 5;
		lblTen_Bp.AutoSize = true;
		Label obj10 = lblTen_Bp;
		location = new Point(8, 150);
		((Control)obj10).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj11 = lblTen_Bp;
		size = new Size(34, 13);
		((Control)obj11).Size = size;
		((Control)lblTen_Bp).TabIndex = 9;
		lblTen_Bp.Text = "Mô tả";
		txtHan_ck.DecimalSymbol = ".";
		txtHan_ck.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtHan_ck;
		location = new Point(106, 43);
		((Control)asTextNumeric).Location = location;
		txtHan_ck.Mask = "### ### ### ###";
		((Control)txtHan_ck).Name = "txtHan_ck";
		AsTextNumeric asTextNumeric2 = txtHan_ck;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtHan_ck).TabIndex = 1;
		((TextBox)txtHan_ck).Text = "0";
		((TextBox)txtHan_ck).TextAlign = (HorizontalAlignment)1;
		txtHan_ck.Value = 0;
		txttl_ck.DecimalSymbol = ".";
		txttl_ck.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txttl_ck;
		location = new Point(106, 69);
		((Control)asTextNumeric3).Location = location;
		txttl_ck.Mask = "### ### ### ###.##";
		((Control)txttl_ck).Name = "txttl_ck";
		AsTextNumeric asTextNumeric4 = txttl_ck;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txttl_ck).TabIndex = 2;
		((TextBox)txttl_ck).Text = "0.00";
		((TextBox)txttl_ck).TextAlign = (HorizontalAlignment)1;
		txttl_ck.Value = 0;
		txtHan_tt.DecimalSymbol = ".";
		txtHan_tt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtHan_tt;
		location = new Point(106, 95);
		((Control)asTextNumeric5).Location = location;
		txtHan_tt.Mask = "### ### ### ###";
		((Control)txtHan_tt).Name = "txtHan_tt";
		AsTextNumeric asTextNumeric6 = txtHan_tt;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtHan_tt).TabIndex = 3;
		((TextBox)txtHan_tt).Text = "0";
		((TextBox)txtHan_tt).TextAlign = (HorizontalAlignment)1;
		txtHan_tt.Value = 0;
		txtls_qh.DecimalSymbol = ".";
		txtls_qh.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtls_qh;
		location = new Point(106, 121);
		((Control)asTextNumeric7).Location = location;
		txtls_qh.Mask = "### ### ### ###.##";
		((Control)txtls_qh).Name = "txtls_qh";
		AsTextNumeric asTextNumeric8 = txtls_qh;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtls_qh).TabIndex = 4;
		((TextBox)txtls_qh).Text = "0.00";
		((TextBox)txtls_qh).TextAlign = (HorizontalAlignment)1;
		txtls_qh.Value = 0;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(8, 46);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(80, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 10;
		Label1.Text = "Hạn chiết khấu";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(8, 72);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(83, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 11;
		Label2.Text = "Tỷ lệ chiết khấu";
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(8, 98);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(81, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 12;
		Label3.Text = "Hạn thanh toán";
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(8, 124);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(63, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 13;
		Label4.Text = "Lãi quá hạn";
		Label5.AutoSize = true;
		Label label9 = Label5;
		location = new Point(212, 46);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(38, 13);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 13;
		Label5.Text = "(Ngày)";
		Label6.AutoSize = true;
		Label label11 = Label6;
		location = new Point(212, 72);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(21, 13);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 14;
		Label6.Text = "(%)";
		Label7.AutoSize = true;
		Label label13 = Label7;
		location = new Point(212, 98);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(38, 13);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 15;
		Label7.Text = "(Ngày)";
		Label8.AutoSize = true;
		Label label15 = Label8;
		location = new Point(212, 124);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(21, 13);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 16;
		Label8.Text = "(%)";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(448, 237);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmPODMDKTTEdit";
		((Form)this).Text = "frmSiDMBpEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((Control)txtMa_tt_po).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_tt_po).Enabled = false;
		((Control)txtHan_ck).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_tt_po;
		CreateDataBinding(ref ojb, "Ma_tt_po");
		txtMa_tt_po = (TextBox)ojb;
		ojb = (Control)(object)txtHan_ck;
		CreateDataBinding(ref ojb, "Han_ck");
		txtHan_ck = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txttl_ck;
		CreateDataBinding(ref ojb, "tl_ck");
		txttl_ck = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtHan_tt;
		CreateDataBinding(ref ojb, "Han_tt");
		txtHan_tt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtls_qh;
		CreateDataBinding(ref ojb, "ls_qh");
		txtls_qh = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMo_ta;
		CreateDataBinding(ref ojb, "Mo_ta");
		txtMo_ta = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox(txtMa_tt_po) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_tt_po).Select();
		}
		return flag;
	}

	private string Mo_ta()
	{
		txtMo_ta.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(txtHan_ck.Value, (object)" - "), txttl_ck.Value), (object)"%"), (object)","), txtHan_tt.Value), (object)" - "), txtls_qh.Value), (object)"%"));
		return Conversions.ToString(true);
	}

	private void txtHan_ck_Validated(object sender, EventArgs e)
	{
		Mo_ta();
	}

	private void txtHan_tt_Validated(object sender, EventArgs e)
	{
		Mo_ta();
	}

	private void txtls_qh_Validated(object sender, EventArgs e)
	{
		Mo_ta();
	}

	private void txttl_ck_Validated(object sender, EventArgs e)
	{
		Mo_ta();
	}
}
