using System;
using System.Collections.Generic;
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
public class frmCODMNHSPCTEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lbTen_Nhvt")]
	private Label _lbTen_Nhvt;

	[AccessedThroughProperty("lblMa_Nhvt")]
	private Label _lblMa_Nhvt;

	[AccessedThroughProperty("txtTen_NhSpct")]
	private TextBox _txtTen_NhSpct;

	[AccessedThroughProperty("txtMa_NhSpct")]
	private TextBox _txtMa_NhSpct;

	[AccessedThroughProperty("txtNhom_Me")]
	private AsTextBox _txtNhom_Me;

	[AccessedThroughProperty("lblTNhom_me")]
	private Label _lblTNhom_me;

	[AccessedThroughProperty("lblTen_Nhom_Me")]
	private Label _lblTen_Nhom_Me;

	[AccessedThroughProperty("txtCap")]
	private AsTextNumeric _txtCap;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	public static bool bSuccess = false;

	internal virtual Label lbTen_Nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbTen_Nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbTen_Nhvt = value;
		}
	}

	internal virtual Label lblMa_Nhvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nhvt = value;
		}
	}

	internal virtual TextBox txtTen_NhSpct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_NhSpct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_NhSpct = value;
		}
	}

	internal virtual TextBox txtMa_NhSpct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_NhSpct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_NhSpct = value;
		}
	}

	internal virtual AsTextBox txtNhom_Me
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNhom_Me;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtNhom_Me_AfterCodeValidating;
			if (_txtNhom_Me != null)
			{
				_txtNhom_Me.AfterCodeValidating -= obj;
			}
			_txtNhom_Me = value;
			if (_txtNhom_Me != null)
			{
				_txtNhom_Me.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual Label lblTNhom_me
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTNhom_me;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTNhom_me = value;
		}
	}

	internal virtual Label lblTen_Nhom_Me
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhom_Me;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhom_Me = value;
		}
	}

	internal virtual AsTextNumeric txtCap
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCap = value;
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
	public frmCODMNHSPCTEdit()
	{
		((Form)this).Load += frmCODMNHSPCTEdit_Load;
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		lbTen_Nhvt = new Label();
		lblMa_Nhvt = new Label();
		txtTen_NhSpct = new TextBox();
		txtMa_NhSpct = new TextBox();
		txtNhom_Me = new AsTextBox();
		lblTen_Nhom_Me = new Label();
		lblTNhom_me = new Label();
		txtCap = new AsTextNumeric();
		Label1 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(136, 97);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 10;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 132);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 132);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtCap);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Nhom_Me);
		((Control)gbLine).Controls.Add((Control)(object)txtNhom_Me);
		((Control)gbLine).Controls.Add((Control)(object)lblTNhom_me);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)lbTen_Nhvt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Nhvt);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_NhSpct);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_NhSpct);
		GroupBox obj3 = gbLine;
		Size size = new Size(490, 119);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_NhSpct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_NhSpct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Nhvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lbTen_Nhvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTNhom_me, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNhom_Me, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Nhom_Me, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtCap, 0);
		lbTen_Nhvt.AutoSize = true;
		lbTen_Nhvt.ImeMode = (ImeMode)0;
		Label obj4 = lbTen_Nhvt;
		location = new Point(14, 49);
		((Control)obj4).Location = location;
		((Control)lbTen_Nhvt).Name = "lbTen_Nhvt";
		Label obj5 = lbTen_Nhvt;
		size = new Size(55, 13);
		((Control)obj5).Size = size;
		((Control)lbTen_Nhvt).TabIndex = 152;
		lbTen_Nhvt.Text = "Tên nhóm";
		lblMa_Nhvt.AutoSize = true;
		lblMa_Nhvt.ImeMode = (ImeMode)0;
		Label obj6 = lblMa_Nhvt;
		location = new Point(360, 401);
		((Control)obj6).Location = location;
		((Control)lblMa_Nhvt).Name = "lblMa_Nhvt";
		Label obj7 = lblMa_Nhvt;
		size = new Size(26, 13);
		((Control)obj7).Size = size;
		((Control)lblMa_Nhvt).TabIndex = 151;
		lblMa_Nhvt.Text = "Cấp";
		TextBox obj8 = txtTen_NhSpct;
		location = new Point(136, 45);
		((Control)obj8).Location = location;
		((TextBoxBase)txtTen_NhSpct).MaxLength = 50;
		((Control)txtTen_NhSpct).Name = "txtTen_NhSpct";
		TextBox obj9 = txtTen_NhSpct;
		size = new Size(341, 20);
		((Control)obj9).Size = size;
		((Control)txtTen_NhSpct).TabIndex = 1;
		txtMa_NhSpct.CharacterCasing = (CharacterCasing)1;
		TextBox obj10 = txtMa_NhSpct;
		location = new Point(136, 19);
		((Control)obj10).Location = location;
		((TextBoxBase)txtMa_NhSpct).MaxLength = 20;
		((Control)txtMa_NhSpct).Name = "txtMa_NhSpct";
		TextBox obj11 = txtMa_NhSpct;
		size = new Size(100, 20);
		((Control)obj11).Size = size;
		((Control)txtMa_NhSpct).TabIndex = 0;
		txtNhom_Me.AutoLookup = true;
		txtNhom_Me.AutoValid = true;
		((TextBoxBase)txtNhom_Me).BackColor = SystemColors.Info;
		((TextBox)txtNhom_Me).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtNhom_Me;
		location = new Point(136, 71);
		((Control)asTextBox).Location = location;
		txtNhom_Me.LookupCodeName = "MA_NHSPCT";
		((Control)txtNhom_Me).Name = "txtNhom_Me";
		txtNhom_Me.NameControl = lblTen_Nhom_Me;
		txtNhom_Me.SD = true;
		AsTextBox asTextBox2 = txtNhom_Me;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtNhom_Me).TabIndex = 2;
		txtNhom_Me.UseAutoCompleteSource = true;
		txtNhom_Me.ValidReturnFieldList = "cap,ten_nhspct";
		lblTen_Nhom_Me.ImeMode = (ImeMode)0;
		Label obj12 = lblTen_Nhom_Me;
		location = new Point(242, 74);
		((Control)obj12).Location = location;
		((Control)lblTen_Nhom_Me).Name = "lblTen_Nhom_Me";
		Label obj13 = lblTen_Nhom_Me;
		size = new Size(235, 13);
		((Control)obj13).Size = size;
		((Control)lblTen_Nhom_Me).TabIndex = 217;
		lblTen_Nhom_Me.Text = "Tên nhóm mẹ";
		lblTen_Nhom_Me.TextAlign = (ContentAlignment)16;
		lblTNhom_me.AutoSize = true;
		lblTNhom_me.ImeMode = (ImeMode)0;
		Label obj14 = lblTNhom_me;
		location = new Point(14, 75);
		((Control)obj14).Location = location;
		((Control)lblTNhom_me).Name = "lblTNhom_me";
		Label obj15 = lblTNhom_me;
		size = new Size(52, 13);
		((Control)obj15).Size = size;
		((Control)lblTNhom_me).TabIndex = 154;
		lblTNhom_me.Text = "Nhóm mẹ";
		lblTNhom_me.TextAlign = (ContentAlignment)16;
		txtCap.DecimalSymbol = ".";
		((Control)txtCap).Enabled = false;
		txtCap.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtCap;
		location = new Point(390, 397);
		((Control)asTextNumeric).Location = location;
		txtCap.Mask = "### ### ### ###";
		((Control)txtCap).Name = "txtCap";
		AsTextNumeric asTextNumeric2 = txtCap;
		size = new Size(35, 20);
		((Control)asTextNumeric2).Size = size;
		txtCap.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtCap).TabIndex = 223;
		((TextBox)txtCap).Text = "0";
		((TextBox)txtCap).TextAlign = (HorizontalAlignment)1;
		txtCap.Value = 0;
		Label1.AutoSize = true;
		Label1.ImeMode = (ImeMode)0;
		Label label = Label1;
		location = new Point(14, 22);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(54, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 152;
		Label1.Text = "Mã  nhóm";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(512, 162);
		((Form)this).ClientSize = size;
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmCODMNHSPCTEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_NhSpct).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_NhSpct).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_NhSpct).Enabled = false;
		((Control)txtTen_NhSpct).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_NhSpct;
		CreateDataBinding(ref ojb, "Ma_NhSpct");
		txtMa_NhSpct = (TextBox)ojb;
		ojb = (Control)(object)txtTen_NhSpct;
		CreateDataBinding(ref ojb, "Ten_NhSpct");
		txtTen_NhSpct = (TextBox)ojb;
		ojb = (Control)(object)txtNhom_Me;
		CreateDataBinding(ref ojb, "Nhom_Me");
		txtNhom_Me = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Nhom_Me;
		CreateDataBinding(ref ojb, "ten_nhom_me");
		lblTen_Nhom_Me = (Label)ojb;
		ojb = (Control)(object)txtCap;
		CreateDataBinding(ref ojb, "cap", "value");
		txtCap = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox(txtMa_NhSpct) && ChkEmtyTextBox(txtTen_NhSpct) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_NhSpct).Select();
			bSuccess = false;
		}
		else
		{
			bSuccess = true;
		}
		return flag;
	}

	protected override bool SetToRow()
	{
		if (Operators.ConditionalCompareObjectGreaterEqual(txtCap.Value, (object)1, false))
		{
			RowToEdit["ten_nhspct_view"] = Strings.Space(Conversions.ToInteger(Operators.MultiplyObject(Operators.SubtractObject(txtCap.Value, (object)1), (object)3))) + txtTen_NhSpct.Text.Trim();
		}
		return base.SetToRow();
	}

	private void txtNhom_Me_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if ((e.ValidatedRow != null && !txtMa_NhSpct.Text.Trim().Equals(((TextBox)txtNhom_Me).Text.Trim())) ? true : false)
		{
			((TextBox)txtCap).Text = Conversions.ToString(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["cap"]), isNum: false), (object)1));
		}
		if (Operators.CompareString(((TextBox)txtNhom_Me).Text.Trim(), "", false) == 0)
		{
			((TextBox)txtCap).Text = Conversions.ToString(1);
		}
	}

	private void frmCODMNHSPCTEdit_Load(object sender, EventArgs e)
	{
		bSuccess = false;
	}
}
