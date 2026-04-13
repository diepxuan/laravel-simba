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
public class frmSODMGIABANEdit : frmDMComplexEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblGia_nt2")]
	private Label _lblGia_nt2;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtGia_nt2")]
	private AsTextNumeric _txtGia_nt2;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblNgay_ad")]
	private Label _lblNgay_ad;

	[AccessedThroughProperty("txtNgay_ad")]
	private AsMaskedTextBox _txtNgay_ad;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("cboMa_NT")]
	private AsComboBoxNT _cboMa_NT;

	internal virtual Label lblGia_nt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGia_nt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGia_nt2 = value;
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

	internal virtual AsTextNumeric txtGia_nt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGia_nt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGia_nt2 = value;
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

	internal virtual Label lblNgay_ad
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_ad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_ad = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_ad
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_ad = value;
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

	private virtual AsComboBoxNT cboMa_NT
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

	[DebuggerNonUserCode]
	public frmSODMGIABANEdit()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		lblNgay_ad = new Label();
		txtNgay_ad = new AsMaskedTextBox();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		lblGia_nt2 = new Label();
		lblMa_vt = new Label();
		txtGia_nt2 = new AsTextNumeric();
		cboMa_NT = new AsComboBoxNT();
		Label1 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Enabled = false;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(154, 172);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 153);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 153);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_ad);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ad);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbLine).Controls.Add((Control)(object)lblGia_nt2);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_vt);
		((Control)gbLine).Controls.Add((Control)(object)txtGia_nt2);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_vt);
		GroupBox obj3 = gbLine;
		Size size = new Size(515, 141);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGia_nt2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGia_nt2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ad, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_ad, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		lblNgay_ad.AutoSize = true;
		Label obj4 = lblNgay_ad;
		location = new Point(6, 53);
		((Control)obj4).Location = location;
		((Control)lblNgay_ad).Name = "lblNgay_ad";
		Label obj5 = lblNgay_ad;
		size = new Size(74, 13);
		((Control)obj5).Size = size;
		((Control)lblNgay_ad).TabIndex = 10;
		lblNgay_ad.Text = "Ngày áp dụng";
		txtNgay_ad.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ad).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ad;
		location = new Point(119, 50);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ad).Mask = "##/##/####";
		((Control)txtNgay_ad).Name = "txtNgay_ad";
		((MaskedTextBox)txtNgay_ad).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ad;
		size = new Size(79, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ad).TabIndex = 1;
		((MaskedTextBox)txtNgay_ad).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ad;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = true;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_vt;
		location = new Point(119, 24);
		((Control)asTextBox).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox2 = txtMa_vt;
		size = new Size(79, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_vt).TabIndex = 0;
		txtMa_vt.UseAutoCompleteSource = true;
		Label obj6 = lblTen_vt;
		location = new Point(204, 25);
		((Control)obj6).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj7 = lblTen_vt;
		size = new Size(305, 17);
		((Control)obj7).Size = size;
		((Control)lblTen_vt).TabIndex = 16;
		lblTen_vt.TextAlign = (ContentAlignment)16;
		lblGia_nt2.AutoSize = true;
		Label obj8 = lblGia_nt2;
		location = new Point(6, 106);
		((Control)obj8).Location = location;
		((Control)lblGia_nt2).Name = "lblGia_nt2";
		Label obj9 = lblGia_nt2;
		size = new Size(23, 13);
		((Control)obj9).Size = size;
		((Control)lblGia_nt2).TabIndex = 15;
		lblGia_nt2.Text = "Giá";
		lblMa_vt.AutoSize = true;
		Label obj10 = lblMa_vt;
		location = new Point(6, 27);
		((Control)obj10).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj11 = lblMa_vt;
		size = new Size(49, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_vt).TabIndex = 9;
		lblMa_vt.Text = "Mã hàng";
		txtGia_nt2.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtGia_nt2;
		location = new Point(119, 103);
		((Control)asTextNumeric).Location = location;
		txtGia_nt2.Mask = "### ### ### ###.##";
		((Control)txtGia_nt2).Name = "txtGia_nt2";
		AsTextNumeric asTextNumeric2 = txtGia_nt2;
		size = new Size(133, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtGia_nt2).TabIndex = 3;
		((TextBox)txtGia_nt2).Text = "0.00";
		((TextBox)txtGia_nt2).TextAlign = (HorizontalAlignment)1;
		txtGia_nt2.Value = 0.0;
		((ComboBox)cboMa_NT).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMa_NT).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_NT;
		location = new Point(119, 76);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(79, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 2;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(6, 79);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(36, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 101;
		Label1.Text = "Mã Nt";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(539, 188);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSODMGIABANEdit";
		((Form)this).Text = "frmSODMGBEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)cboMa_NT).Enabled = false;
		((Control)txtMa_vt).Enabled = false;
		((Control)txtNgay_ad).Enabled = false;
	}

	protected override void DataBinding()
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)cboMa_NT;
		CreateDataBinding(ref ojb, "ma_nt", "MA_NT");
		cboMa_NT = (AsComboBoxNT)(object)ojb;
		ojb = (Control)(object)txtNgay_ad;
		CreateDataBinding(ref ojb, "ngay_ad", "Value");
		txtNgay_ad = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtGia_nt2;
		CreateDataBinding(ref ojb, "gia_nt2", "Value");
		txtGia_nt2 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMa_vt;
		CreateDataBinding(ref ojb, "ma_vt");
		txtMa_vt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_vt;
		CreateDataBinding(ref ojb, "ten_vt");
		lblTen_vt = (Label)ojb;
	}
}
