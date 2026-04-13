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
public class frmCODMSPCTEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtDvt")]
	private TextBox _txtDvt;

	[AccessedThroughProperty("txtMa_Spct")]
	private TextBox _txtMa_Spct;

	[AccessedThroughProperty("lblDvt")]
	private Label _lblDvt;

	[AccessedThroughProperty("lblMa_Spct")]
	private Label _lblMa_Spct;

	[AccessedThroughProperty("txtTen_Spct")]
	private TextBox _txtTen_Spct;

	[AccessedThroughProperty("lblTen_Spct")]
	private Label _lblTen_Spct;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtDu_toan_nt")]
	private AsTextNumeric _txtDu_toan_nt;

	[AccessedThroughProperty("txtDu_toan")]
	private AsTextNumeric _txtDu_toan;

	[AccessedThroughProperty("txtNgay_kt")]
	private AsMaskedTextBox _txtNgay_kt;

	[AccessedThroughProperty("txtNgay_kc")]
	private AsMaskedTextBox _txtNgay_kc;

	[AccessedThroughProperty("txtGhi_chu")]
	private TextBox _txtGhi_chu;

	[AccessedThroughProperty("txtDv_tc")]
	private TextBox _txtDv_tc;

	[AccessedThroughProperty("lblTen_nhspct")]
	private Label _lblTen_nhspct;

	[AccessedThroughProperty("txtMa_nhspct")]
	private AsTextBox _txtMa_nhspct;

	[AccessedThroughProperty("lblMa_nhspct")]
	private Label _lblMa_nhspct;

	internal virtual TextBox txtDvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDvt = value;
		}
	}

	internal virtual TextBox txtMa_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Spct = value;
		}
	}

	internal virtual Label lblDvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDvt = value;
		}
	}

	internal virtual Label lblMa_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Spct = value;
		}
	}

	internal virtual TextBox txtTen_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Spct = value;
		}
	}

	internal virtual Label lblTen_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Spct = value;
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

	private virtual AsTextNumeric txtDu_toan_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_toan_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDu_toan_nt = value;
		}
	}

	private virtual AsTextNumeric txtDu_toan
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDu_toan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDu_toan = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_kt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_kt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_kt = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_kc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_kc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_kc = value;
		}
	}

	internal virtual TextBox txtGhi_chu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGhi_chu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGhi_chu = value;
		}
	}

	internal virtual TextBox txtDv_tc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDv_tc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDv_tc = value;
		}
	}

	internal virtual Label lblTen_nhspct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nhspct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nhspct = value;
		}
	}

	internal virtual AsTextBox txtMa_nhspct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nhspct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nhspct = value;
		}
	}

	internal virtual Label lblMa_nhspct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nhspct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nhspct = value;
		}
	}

	[DebuggerNonUserCode]
	public frmCODMSPCTEdit()
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
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		txtDvt = new TextBox();
		lblDvt = new Label();
		txtTen_Spct = new TextBox();
		lblTen_Spct = new Label();
		txtMa_Spct = new TextBox();
		lblMa_Spct = new Label();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		txtNgay_kc = new AsMaskedTextBox();
		txtNgay_kt = new AsMaskedTextBox();
		txtDu_toan = new AsTextNumeric();
		txtDu_toan_nt = new AsTextNumeric();
		txtDv_tc = new TextBox();
		txtGhi_chu = new TextBox();
		lblTen_nhspct = new Label();
		txtMa_nhspct = new AsTextBox();
		lblMa_nhspct = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(113, 305);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 10;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 340);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 340);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblTen_nhspct);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_nhspct);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_nhspct);
		((Control)gbLine).Controls.Add((Control)(object)txtGhi_chu);
		((Control)gbLine).Controls.Add((Control)(object)txtDv_tc);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_toan_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtDu_toan);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_kt);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_kc);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)txtDvt);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Spct);
		((Control)gbLine).Controls.Add((Control)(object)lblDvt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Spct);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Spct);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Spct);
		GroupBox obj3 = gbLine;
		Size size = new Size(535, 327);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_kc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_kt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDu_toan, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDu_toan_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDv_tc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGhi_chu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_nhspct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_nhspct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_nhspct, 0);
		((Control)txtDvt).Anchor = (AnchorStyles)15;
		TextBox obj4 = txtDvt;
		location = new Point(113, 71);
		((Control)obj4).Location = location;
		((Control)txtDvt).Name = "txtDvt";
		TextBox obj5 = txtDvt;
		size = new Size(115, 20);
		((Control)obj5).Size = size;
		((Control)txtDvt).TabIndex = 2;
		((Control)lblDvt).Anchor = (AnchorStyles)15;
		lblDvt.AutoSize = true;
		Label obj6 = lblDvt;
		location = new Point(18, 74);
		((Control)obj6).Location = location;
		((Control)lblDvt).Name = "lblDvt";
		Label obj7 = lblDvt;
		size = new Size(60, 13);
		((Control)obj7).Size = size;
		((Control)lblDvt).TabIndex = 126;
		lblDvt.Text = "Đơn vị tính";
		((Control)txtTen_Spct).Anchor = (AnchorStyles)15;
		TextBox obj8 = txtTen_Spct;
		location = new Point(113, 46);
		((Control)obj8).Location = location;
		((TextBoxBase)txtTen_Spct).MaxLength = 100;
		((Control)txtTen_Spct).Name = "txtTen_Spct";
		TextBox obj9 = txtTen_Spct;
		size = new Size(361, 20);
		((Control)obj9).Size = size;
		((Control)txtTen_Spct).TabIndex = 1;
		((Control)lblTen_Spct).Anchor = (AnchorStyles)15;
		lblTen_Spct.AutoSize = true;
		Label obj10 = lblTen_Spct;
		location = new Point(18, 49);
		((Control)obj10).Location = location;
		((Control)lblTen_Spct).Name = "lblTen_Spct";
		Label obj11 = lblTen_Spct;
		size = new Size(76, 13);
		((Control)obj11).Size = size;
		((Control)lblTen_Spct).TabIndex = 125;
		lblTen_Spct.Text = "Tên công trình";
		((Control)txtMa_Spct).Anchor = (AnchorStyles)15;
		txtMa_Spct.CharacterCasing = (CharacterCasing)1;
		TextBox obj12 = txtMa_Spct;
		location = new Point(113, 21);
		((Control)obj12).Location = location;
		((Control)txtMa_Spct).Name = "txtMa_Spct";
		TextBox obj13 = txtMa_Spct;
		size = new Size(115, 20);
		((Control)obj13).Size = size;
		((Control)txtMa_Spct).TabIndex = 0;
		((Control)lblMa_Spct).Anchor = (AnchorStyles)15;
		lblMa_Spct.AutoSize = true;
		Label obj14 = lblMa_Spct;
		location = new Point(18, 24);
		((Control)obj14).Location = location;
		((Control)lblMa_Spct).Name = "lblMa_Spct";
		Label obj15 = lblMa_Spct;
		size = new Size(72, 13);
		((Control)obj15).Size = size;
		((Control)lblMa_Spct).TabIndex = 124;
		lblMa_Spct.Text = "Mã công trình";
		((Control)Label1).Anchor = (AnchorStyles)15;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(18, 176);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(45, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 129;
		Label1.Text = "Dự toán";
		((Control)Label2).Anchor = (AnchorStyles)15;
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(18, 126);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(82, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 127;
		Label2.Text = "Ngày khởi công";
		((Control)Label3).Anchor = (AnchorStyles)15;
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(18, 151);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(74, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 128;
		Label3.Text = "Ngày kết thúc";
		((Control)Label4).Anchor = (AnchorStyles)15;
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(18, 201);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(63, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 130;
		Label4.Text = "Dự toán NT";
		((Control)Label5).Anchor = (AnchorStyles)15;
		Label5.AutoSize = true;
		Label label9 = Label5;
		location = new Point(18, 251);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(44, 13);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 132;
		Label5.Text = "Ghi chú";
		((Control)Label6).Anchor = (AnchorStyles)15;
		Label6.AutoSize = true;
		Label label11 = Label6;
		location = new Point(18, 226);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(79, 13);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 131;
		Label6.Text = "Đơn vị thi công";
		((Control)txtNgay_kc).Anchor = (AnchorStyles)11;
		txtNgay_kc.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_kc).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_kc;
		location = new Point(113, 123);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_kc).Mask = "##/##/####";
		((Control)txtNgay_kc).Name = "txtNgay_kc";
		((MaskedTextBox)txtNgay_kc).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_kc;
		size = new Size(78, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_kc).TabIndex = 4;
		((MaskedTextBox)txtNgay_kc).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_kc;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		((Control)txtNgay_kt).Anchor = (AnchorStyles)11;
		txtNgay_kt.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_kt).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_kt;
		location = new Point(113, 148);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_kt).Mask = "##/##/####";
		((Control)txtNgay_kt).Name = "txtNgay_kt";
		((MaskedTextBox)txtNgay_kt).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_kt;
		size = new Size(78, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_kt).TabIndex = 5;
		((MaskedTextBox)txtNgay_kt).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_kt;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		((Control)txtDu_toan).Anchor = (AnchorStyles)11;
		txtDu_toan.DecimalSymbol = ".";
		txtDu_toan.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtDu_toan;
		location = new Point(113, 173);
		((Control)asTextNumeric).Location = location;
		txtDu_toan.Mask = "### ### ### ###.##";
		((Control)txtDu_toan).Name = "txtDu_toan";
		AsTextNumeric asTextNumeric2 = txtDu_toan;
		size = new Size(153, 20);
		((Control)asTextNumeric2).Size = size;
		txtDu_toan.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtDu_toan).TabIndex = 6;
		((TextBox)txtDu_toan).Text = "0.00";
		((TextBox)txtDu_toan).TextAlign = (HorizontalAlignment)1;
		txtDu_toan.Type = Commons.NumericType.ORTHER_;
		txtDu_toan.Value = 0.0;
		((Control)txtDu_toan_nt).Anchor = (AnchorStyles)11;
		txtDu_toan_nt.DecimalSymbol = ".";
		txtDu_toan_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtDu_toan_nt;
		location = new Point(113, 198);
		((Control)asTextNumeric3).Location = location;
		txtDu_toan_nt.Mask = "### ### ### ###.##";
		((Control)txtDu_toan_nt).Name = "txtDu_toan_nt";
		AsTextNumeric asTextNumeric4 = txtDu_toan_nt;
		size = new Size(153, 20);
		((Control)asTextNumeric4).Size = size;
		txtDu_toan_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtDu_toan_nt).TabIndex = 7;
		((TextBox)txtDu_toan_nt).Text = "0.00";
		((TextBox)txtDu_toan_nt).TextAlign = (HorizontalAlignment)1;
		txtDu_toan_nt.Type = Commons.NumericType.ORTHER_;
		txtDu_toan_nt.Value = 0.0;
		((Control)txtDv_tc).Anchor = (AnchorStyles)15;
		TextBox obj16 = txtDv_tc;
		location = new Point(113, 224);
		((Control)obj16).Location = location;
		((Control)txtDv_tc).Name = "txtDv_tc";
		TextBox obj17 = txtDv_tc;
		size = new Size(361, 20);
		((Control)obj17).Size = size;
		((Control)txtDv_tc).TabIndex = 8;
		TextBox obj18 = txtGhi_chu;
		location = new Point(113, 248);
		((Control)obj18).Location = location;
		txtGhi_chu.Multiline = true;
		((Control)txtGhi_chu).Name = "txtGhi_chu";
		txtGhi_chu.ScrollBars = (ScrollBars)3;
		TextBox obj19 = txtGhi_chu;
		size = new Size(361, 53);
		((Control)obj19).Size = size;
		((Control)txtGhi_chu).TabIndex = 9;
		lblTen_nhspct.ImeMode = (ImeMode)0;
		Label obj20 = lblTen_nhspct;
		location = new Point(234, 100);
		((Control)obj20).Location = location;
		((Control)lblTen_nhspct).Name = "lblTen_nhspct";
		Label obj21 = lblTen_nhspct;
		size = new Size(288, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_nhspct).TabIndex = 220;
		lblTen_nhspct.TextAlign = (ContentAlignment)16;
		txtMa_nhspct.AutoLookup = true;
		txtMa_nhspct.AutoValid = true;
		((TextBoxBase)txtMa_nhspct).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhspct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_nhspct;
		location = new Point(113, 97);
		((Control)asTextBox).Location = location;
		txtMa_nhspct.LookupCodeName = "MA_NHSPCT";
		((Control)txtMa_nhspct).Name = "txtMa_nhspct";
		txtMa_nhspct.NameControl = lblTen_nhspct;
		txtMa_nhspct.SD = true;
		AsTextBox asTextBox2 = txtMa_nhspct;
		size = new Size(115, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_nhspct).TabIndex = 3;
		txtMa_nhspct.UseAutoCompleteSource = true;
		txtMa_nhspct.ValidReturnFieldList = "cap,ten_nhspct";
		lblMa_nhspct.AutoSize = true;
		lblMa_nhspct.ImeMode = (ImeMode)0;
		Label obj22 = lblMa_nhspct;
		location = new Point(18, 100);
		((Control)obj22).Location = location;
		((Control)lblMa_nhspct).Name = "lblMa_nhspct";
		Label obj23 = lblMa_nhspct;
		size = new Size(82, 13);
		((Control)obj23).Size = size;
		((Control)lblMa_nhspct).TabIndex = 219;
		lblMa_nhspct.Text = "Mã nhóm SPCT";
		lblMa_nhspct.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(557, 370);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCODMSPCTEdit";
		((Form)this).Text = "frm";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_Spct).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_Spct).Select();
		txtDu_toan.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
		txtDu_toan_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCPrice_Input_Format;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_Spct).Enabled = false;
		((Control)txtTen_Spct).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_Spct;
		CreateDataBinding(ref ojb, "Ma_SpCt");
		txtMa_Spct = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Spct;
		CreateDataBinding(ref ojb, "Ten_SpCt");
		txtTen_Spct = (TextBox)ojb;
		ojb = (Control)(object)txtDvt;
		CreateDataBinding(ref ojb, "Dvt");
		txtDvt = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)txtMa_nhspct;
		CreateDataBinding(ref ojb, "Ma_nhspct");
		txtMa_nhspct = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_nhspct;
		CreateDataBinding(ref ojb, "ten_nhspct");
		lblTen_nhspct = (Label)ojb;
		ojb = (Control)(object)txtNgay_kc;
		CreateDataBinding(ref ojb, "ngay_kc", "Value");
		txtNgay_kc = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_kt;
		CreateDataBinding(ref ojb, "ngay_kt", "Value");
		txtNgay_kt = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtDu_toan;
		CreateDataBinding(ref ojb, "Du_toan", "Value");
		txtDu_toan = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDu_toan_nt;
		CreateDataBinding(ref ojb, "Du_toan_nt", "Value");
		txtDu_toan_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDv_tc;
		CreateDataBinding(ref ojb, "Dv_tc");
		txtDv_tc = (TextBox)ojb;
		ojb = (Control)(object)txtGhi_chu;
		CreateDataBinding(ref ojb, "Ghi_chu");
		txtGhi_chu = (TextBox)ojb;
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox(txtMa_Spct) && ChkEmtyTextBox(txtTen_Spct) && base.ValidData()) ? true : false;
	}
}
