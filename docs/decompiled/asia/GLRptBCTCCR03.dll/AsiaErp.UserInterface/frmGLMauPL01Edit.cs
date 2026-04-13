using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.UserInterface.My;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLMauPL01Edit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("chkCach_tinh")]
	private AsCheckBox _chkCach_tinh;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtCach_tinh")]
	private TextBox _txtCach_tinh;

	[AccessedThroughProperty("chkgiam_tru")]
	private AsCheckBox _chkgiam_tru;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("chkBold")]
	private AsCheckBox _chkBold;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("chkIn_ck")]
	private AsCheckBox _chkIn_ck;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("GroupBox5")]
	private GroupBox _GroupBox5;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtMa_so")]
	private TextBox _txtMa_so;

	[AccessedThroughProperty("txtChi_tieu")]
	private TextBox _txtChi_tieu;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtTm")]
	private TextBox _txtTm;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("txtDsTk_no")]
	private AsTextBox _txtDsTk_no;

	[AccessedThroughProperty("txtDsTK_co")]
	private AsTextBox _txtDsTK_co;

	[AccessedThroughProperty("txtStt")]
	private TextBox _txtStt;

	internal virtual AsCheckBox chkCach_tinh
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkCach_tinh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkCach_tinh_Click;
			EventHandler eventHandler2 = chkCach_tinh_Validated;
			if (_chkCach_tinh != null)
			{
				((Control)_chkCach_tinh).Click -= eventHandler;
				((Control)_chkCach_tinh).Validated -= eventHandler2;
			}
			_chkCach_tinh = value;
			if (_chkCach_tinh != null)
			{
				((Control)_chkCach_tinh).Click += eventHandler;
				((Control)_chkCach_tinh).Validated += eventHandler2;
			}
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

	internal virtual TextBox txtCach_tinh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCach_tinh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCach_tinh = value;
		}
	}

	internal virtual AsCheckBox chkgiam_tru
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkgiam_tru;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkgiam_tru = value;
		}
	}

	internal virtual GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal virtual AsCheckBox chkBold
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkBold;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkBold = value;
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

	internal virtual AsCheckBox chkIn_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkIn_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkIn_ck = value;
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

	internal virtual GroupBox GroupBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox5 = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
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

	internal virtual TextBox txtMa_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_so = value;
		}
	}

	internal virtual TextBox txtChi_tieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtChi_tieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtChi_tieu = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
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

	internal virtual TextBox txtTm
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTm = value;
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual AsTextBox txtDsTk_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDsTk_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDsTk_no = value;
		}
	}

	internal virtual AsTextBox txtDsTK_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDsTK_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDsTK_co = value;
		}
	}

	internal virtual TextBox txtStt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtStt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtStt = value;
		}
	}

	[DebuggerNonUserCode]
	public frmGLMauPL01Edit()
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
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		GroupBox5 = new GroupBox();
		Label11 = new Label();
		Label1 = new Label();
		txtMa_so = new TextBox();
		txtChi_tieu = new TextBox();
		Label10 = new Label();
		Label2 = new Label();
		txtTm = new TextBox();
		chkBold = new AsCheckBox();
		Label6 = new Label();
		chkIn_ck = new AsCheckBox();
		Label3 = new Label();
		GroupBox2 = new GroupBox();
		chkCach_tinh = new AsCheckBox();
		Label8 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		txtCach_tinh = new TextBox();
		chkgiam_tru = new AsCheckBox();
		Label12 = new Label();
		txtDsTK_co = new AsTextBox();
		txtDsTk_no = new AsTextBox();
		txtStt = new TextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(639, 434);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 362);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 362);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtStt);
		((Control)gbLine).Controls.Add((Control)(object)txtDsTk_no);
		((Control)gbLine).Controls.Add((Control)(object)txtDsTK_co);
		((Control)gbLine).Controls.Add((Control)(object)Label12);
		((Control)gbLine).Controls.Add((Control)(object)chkCach_tinh);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)txtCach_tinh);
		((Control)gbLine).Controls.Add((Control)(object)chkgiam_tru);
		((Control)gbLine).Controls.Add((Control)(object)GroupBox2);
		((Control)gbLine).Controls.Add((Control)(object)chkBold);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)chkIn_ck);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)GroupBox5);
		((Control)gbLine).Controls.Add((Control)(object)Label11);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_so);
		((Control)gbLine).Controls.Add((Control)(object)txtChi_tieu);
		((Control)gbLine).Controls.Add((Control)(object)Label10);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)txtTm);
		GroupBox obj3 = gbLine;
		Size size = new Size(542, 350);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTm, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label10, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtChi_tieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_so, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label11, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)GroupBox5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkIn_ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkBold, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)GroupBox2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkgiam_tru, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtCach_tinh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkCach_tinh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label12, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDsTK_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDsTk_no, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtStt, 0);
		((Control)GroupBox5).BackColor = SystemColors.ButtonFace;
		GroupBox groupBox = GroupBox5;
		location = new Point(15, 128);
		((Control)groupBox).Location = location;
		((Control)GroupBox5).Name = "GroupBox5";
		GroupBox groupBox2 = GroupBox5;
		size = new Size(509, 4);
		((Control)groupBox2).Size = size;
		((Control)GroupBox5).TabIndex = 129;
		GroupBox5.TabStop = false;
		Label11.AutoSize = true;
		Label label = Label11;
		location = new Point(12, 23);
		((Control)label).Location = location;
		((Control)Label11).Name = "Label11";
		Label label2 = Label11;
		size = new Size(50, 13);
		((Control)label2).Size = size;
		((Control)Label11).TabIndex = 132;
		Label11.Text = "Số thứ tự";
		Label1.AutoSize = true;
		Label label3 = Label1;
		location = new Point(12, 49);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(36, 13);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 129;
		Label1.Text = "Mã số";
		TextBox obj4 = txtMa_so;
		location = new Point(92, 45);
		((Control)obj4).Location = location;
		((Control)txtMa_so).Name = "txtMa_so";
		TextBox obj5 = txtMa_so;
		size = new Size(100, 20);
		((Control)obj5).Size = size;
		((Control)txtMa_so).TabIndex = 1;
		TextBox obj6 = txtChi_tieu;
		location = new Point(92, 97);
		((Control)obj6).Location = location;
		((Control)txtChi_tieu).Name = "txtChi_tieu";
		TextBox obj7 = txtChi_tieu;
		size = new Size(313, 20);
		((Control)obj7).Size = size;
		((Control)txtChi_tieu).TabIndex = 3;
		Label10.AutoSize = true;
		Label label5 = Label10;
		location = new Point(12, 75);
		((Control)label5).Location = location;
		((Control)Label10).Name = "Label10";
		Label label6 = Label10;
		size = new Size(65, 13);
		((Control)label6).Size = size;
		((Control)Label10).TabIndex = 131;
		Label10.Text = "Thuyết minh";
		Label2.AutoSize = true;
		Label label7 = Label2;
		location = new Point(12, 101);
		((Control)label7).Location = location;
		((Control)Label2).Name = "Label2";
		Label label8 = Label2;
		size = new Size(42, 13);
		((Control)label8).Size = size;
		((Control)Label2).TabIndex = 130;
		Label2.Text = "Chỉ tiêu";
		TextBox obj8 = txtTm;
		location = new Point(92, 71);
		((Control)obj8).Location = location;
		((Control)txtTm).Name = "txtTm";
		TextBox obj9 = txtTm;
		size = new Size(313, 20);
		((Control)obj9).Size = size;
		((Control)txtTm).TabIndex = 2;
		((ButtonBase)chkBold).AutoSize = true;
		chkBold.Checked = false;
		((Control)chkBold).ForeColor = Color.Black;
		AsCheckBox asCheckBox2 = chkBold;
		location = new Point(92, 161);
		((Control)asCheckBox2).Location = location;
		((Control)chkBold).Name = "chkBold";
		AsCheckBox asCheckBox3 = chkBold;
		size = new Size(113, 17);
		((Control)asCheckBox3).Size = size;
		((Control)chkBold).TabIndex = 5;
		((ButtonBase)chkBold).Text = "Đậm / không đậm";
		chkBold.TextValue = "0";
		((ButtonBase)chkBold).UseVisualStyleBackColor = true;
		Label6.AutoSize = true;
		Label label9 = Label6;
		location = new Point(12, 163);
		((Control)label9).Location = location;
		((Control)Label6).Name = "Label6";
		Label label10 = Label6;
		size = new Size(49, 13);
		((Control)label10).Size = size;
		((Control)Label6).TabIndex = 136;
		Label6.Text = "Kiểu chữ";
		((ButtonBase)chkIn_ck).AutoSize = true;
		chkIn_ck.Checked = false;
		((Control)chkIn_ck).ForeColor = Color.Black;
		AsCheckBox asCheckBox4 = chkIn_ck;
		location = new Point(92, 138);
		((Control)asCheckBox4).Location = location;
		((Control)chkIn_ck).Name = "chkIn_ck";
		AsCheckBox asCheckBox5 = chkIn_ck;
		size = new Size(87, 17);
		((Control)asCheckBox5).Size = size;
		((Control)chkIn_ck).TabIndex = 4;
		((ButtonBase)chkIn_ck).Text = "In / không in";
		chkIn_ck.TextValue = "0";
		((ButtonBase)chkIn_ck).UseVisualStyleBackColor = true;
		Label3.AutoSize = true;
		Label label11 = Label3;
		location = new Point(12, 140);
		((Control)label11).Location = location;
		((Control)Label3).Name = "Label3";
		Label label12 = Label3;
		size = new Size(16, 13);
		((Control)label12).Size = size;
		((Control)Label3).TabIndex = 135;
		Label3.Text = "In";
		((Control)GroupBox2).BackColor = SystemColors.ButtonFace;
		GroupBox groupBox3 = GroupBox2;
		location = new Point(15, 194);
		((Control)groupBox3).Location = location;
		((Control)GroupBox2).Name = "GroupBox2";
		GroupBox groupBox4 = GroupBox2;
		size = new Size(509, 4);
		((Control)groupBox4).Size = size;
		((Control)GroupBox2).TabIndex = 142;
		GroupBox2.TabStop = false;
		((ButtonBase)chkCach_tinh).AutoSize = true;
		chkCach_tinh.Checked = false;
		AsCheckBox asCheckBox6 = chkCach_tinh;
		location = new Point(92, 204);
		((Control)asCheckBox6).Location = location;
		((Control)chkCach_tinh).Name = "chkCach_tinh";
		AsCheckBox asCheckBox7 = chkCach_tinh;
		size = new Size(254, 17);
		((Control)asCheckBox7).Size = size;
		((Control)chkCach_tinh).TabIndex = 6;
		((ButtonBase)chkCach_tinh).Text = "Tính theo số dư tài khoản / tính theo công thức";
		chkCach_tinh.TextValue = "0";
		((ButtonBase)chkCach_tinh).UseVisualStyleBackColor = true;
		Label8.AutoSize = true;
		Label label13 = Label8;
		location = new Point(25, 306);
		((Control)label13).Location = location;
		((Control)Label8).Name = "Label8";
		Label label14 = Label8;
		size = new Size(62, 13);
		((Control)label14).Size = size;
		((Control)Label8).TabIndex = 150;
		Label8.Text = "- Công thức";
		Label5.AutoSize = true;
		Label label15 = Label5;
		location = new Point(12, 206);
		((Control)label15).Location = location;
		((Control)Label5).Name = "Label5";
		Label label16 = Label5;
		size = new Size(54, 13);
		((Control)label16).Size = size;
		((Control)Label5).TabIndex = 149;
		Label5.Text = "Cách tính";
		Label4.AutoSize = true;
		Label label17 = Label4;
		location = new Point(25, 257);
		((Control)label17).Location = location;
		((Control)Label4).Name = "Label4";
		Label label18 = Label4;
		size = new Size(57, 13);
		((Control)label18).Size = size;
		((Control)Label4).TabIndex = 148;
		Label4.Text = "- DSTK có";
		TextBox obj10 = txtCach_tinh;
		location = new Point(92, 302);
		((Control)obj10).Location = location;
		((Control)txtCach_tinh).Name = "txtCach_tinh";
		TextBox obj11 = txtCach_tinh;
		size = new Size(432, 20);
		((Control)obj11).Size = size;
		((Control)txtCach_tinh).TabIndex = 10;
		((ButtonBase)chkgiam_tru).AutoSize = true;
		chkgiam_tru.Checked = false;
		((Control)chkgiam_tru).Enabled = false;
		((Control)chkgiam_tru).ForeColor = Color.Blue;
		AsCheckBox asCheckBox8 = chkgiam_tru;
		location = new Point(92, 279);
		((Control)asCheckBox8).Location = location;
		((Control)chkgiam_tru).Name = "chkgiam_tru";
		AsCheckBox asCheckBox9 = chkgiam_tru;
		size = new Size(152, 17);
		((Control)asCheckBox9).Size = size;
		((Control)chkgiam_tru).TabIndex = 9;
		((ButtonBase)chkgiam_tru).Text = "Tính / không tính giảm trừ";
		chkgiam_tru.TextValue = "0";
		((ButtonBase)chkgiam_tru).UseVisualStyleBackColor = true;
		Label12.AutoSize = true;
		Label label19 = Label12;
		location = new Point(25, 231);
		((Control)label19).Location = location;
		((Control)Label12).Name = "Label12";
		Label label20 = Label12;
		size = new Size(57, 13);
		((Control)label20).Size = size;
		((Control)Label12).TabIndex = 151;
		Label12.Text = "- DSTK nợ";
		txtDsTK_co.AutoLookup = true;
		txtDsTK_co.AutoValid = false;
		((TextBoxBase)txtDsTK_co).BackColor = SystemColors.Control;
		((TextBox)txtDsTK_co).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtDsTK_co;
		location = new Point(92, 253);
		((Control)asTextBox).Location = location;
		txtDsTK_co.LookupCodeName = "TK";
		((Control)txtDsTK_co).Name = "txtDsTK_co";
		txtDsTK_co.NameControl = null;
		((TextBoxBase)txtDsTK_co).ReadOnly = true;
		AsTextBox asTextBox2 = txtDsTK_co;
		size = new Size(172, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtDsTK_co).TabIndex = 8;
		((Control)txtDsTK_co).Tag = "@pTK";
		txtDsTK_co.UseAutoCompleteSource = true;
		txtDsTk_no.AutoLookup = true;
		txtDsTk_no.AutoValid = false;
		((TextBoxBase)txtDsTk_no).BackColor = SystemColors.Control;
		((TextBox)txtDsTk_no).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtDsTk_no;
		location = new Point(92, 227);
		((Control)asTextBox3).Location = location;
		txtDsTk_no.LookupCodeName = "TK";
		((Control)txtDsTk_no).Name = "txtDsTk_no";
		txtDsTk_no.NameControl = null;
		((TextBoxBase)txtDsTk_no).ReadOnly = true;
		AsTextBox asTextBox4 = txtDsTk_no;
		size = new Size(172, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtDsTk_no).TabIndex = 7;
		((Control)txtDsTk_no).Tag = "@pTK";
		txtDsTk_no.UseAutoCompleteSource = true;
		TextBox obj12 = txtStt;
		location = new Point(92, 20);
		((Control)obj12).Location = location;
		((Control)txtStt).Name = "txtStt";
		TextBox obj13 = txtStt;
		size = new Size(100, 20);
		((Control)obj13).Size = size;
		((Control)txtStt).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(566, 397);
		((Form)this).ClientSize = size;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmGLMauPL01Edit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		if (!EditMode)
		{
			RowToEdit["stt"] = RuntimeHelpers.GetObjectValue(RowToEdit.Table.Compute("count(ma_cty)", ""));
		}
		((Control)txtMa_so).Focus();
		((Control)txtMa_so).Select();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			((CheckBox)chkCach_tinh).CheckState = (CheckState)1;
		}
		if ((Operators.CompareString(((TextBox)txtDsTK_co).Text.Trim(), "", false) == 0 && Operators.CompareString(((TextBox)txtDsTk_no).Text.Trim(), "", false) == 0 && Operators.CompareString(txtCach_tinh.Text.Trim(), "", false) != 0) ? true : false)
		{
			((CheckBox)chkCach_tinh).CheckState = (CheckState)0;
		}
		if ((Operators.CompareString(txtCach_tinh.Text.Trim(), "", false) == 0 && (Operators.CompareString(((TextBox)txtDsTK_co).Text.Trim(), "", false) != 0 || Operators.CompareString(((TextBox)txtDsTk_no).Text.Trim(), "", false) != 0)) ? true : false)
		{
			((CheckBox)chkCach_tinh).CheckState = (CheckState)1;
		}
		chkCach_tinh_Click(null, null);
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_so).Enabled = false;
		((Control)txtTm).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtStt;
		CreateDataBinding(ref ojb, "stt");
		txtStt = (TextBox)ojb;
		ojb = (Control)(object)txtMa_so;
		CreateDataBinding(ref ojb, "ma_so");
		txtMa_so = (TextBox)ojb;
		ojb = (Control)(object)txtChi_tieu;
		CreateDataBinding(ref ojb, "chi_tieu");
		txtChi_tieu = (TextBox)ojb;
		ojb = (Control)(object)txtDsTK_co;
		CreateDataBinding(ref ojb, "tk_co");
		txtDsTK_co = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtDsTk_no;
		CreateDataBinding(ref ojb, "tk_no");
		txtDsTk_no = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtCach_tinh;
		CreateDataBinding(ref ojb, "cach_tinh");
		txtCach_tinh = (TextBox)ojb;
		ojb = (Control)(object)txtTm;
		CreateDataBinding(ref ojb, "Tm");
		txtTm = (TextBox)ojb;
		ojb = (Control)(object)chkIn_ck;
		CreateDataBinding(ref ojb, "in_ck", "Checked");
		chkIn_ck = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkBold;
		CreateDataBinding(ref ojb, "bold", "Checked");
		chkBold = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkgiam_tru;
		CreateDataBinding(ref ojb, "sodu_duong", "Checked");
		chkgiam_tru = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		CheckState checkState = ((CheckBox)chkCach_tinh).CheckState;
		if ((int)checkState == 1)
		{
			int num = ((TextBox)txtDsTk_no).Text.Split(new char[1] { ',' }).Length;
			if (Operators.ConditionalCompareObjectNotEqual((object)num, Commons.GetDataTable("asGLGetDmTk", CompanyInformations.CompanyID).Compute("count(tk)", "tk in ('" + ((TextBox)txtDsTk_no).Text.Trim().Replace(",", "','") + "')"), false))
			{
				SetControlError((Control)(object)txtDsTk_no, MySettingsProperty.Settings.MSG_DS_TK);
				((Control)txtDsTk_no).Select();
				return false;
			}
			num = ((TextBox)txtDsTK_co).Text.Split(new char[1] { ',' }).Length;
			if (Conversions.ToBoolean((!Conversions.ToBoolean(chkCach_tinh.Checked) || !Conversions.ToBoolean((object)Operators.ConditionalCompareObjectNotEqual((object)num, Commons.GetDataTable("asGLGetDmTk", CompanyInformations.CompanyID).Compute("count(tk)", "tk in ('" + ((TextBox)txtDsTK_co).Text.Trim().Replace(",", "','") + "')"), false))) ? ((object)false) : ((object)true)))
			{
				SetControlError((Control)(object)txtDsTK_co, MySettingsProperty.Settings.MSG_DS_TK);
				((Control)txtDsTK_co).Select();
				return false;
			}
			return (Commons.ChkEmtyTextBoxAndShowMessageBox((TextBox)(object)txtDsTK_co) && Commons.ChkEmtyTextBoxAndShowMessageBox((TextBox)(object)txtDsTk_no) && base.ValidData()) ? true : false;
		}
		return (Commons.ChkEmtyTextBoxAndShowMessageBox(txtCach_tinh) && base.ValidData()) ? true : false;
	}

	private void chkCach_tinh_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		CheckState checkState = ((CheckBox)chkCach_tinh).CheckState;
		if ((int)checkState == 1)
		{
			((Control)chkgiam_tru).Enabled = true;
			((TextBoxBase)txtCach_tinh).ReadOnly = true;
			((Control)txtCach_tinh).TabStop = false;
			((TextBoxBase)txtDsTK_co).ReadOnly = false;
			((TextBoxBase)txtDsTk_no).ReadOnly = false;
			((Control)txtDsTK_co).TabStop = true;
			((Control)txtDsTk_no).TabStop = true;
			((TextBoxBase)txtCach_tinh).Clear();
			((Control)txtDsTk_no).Focus();
		}
		else
		{
			((Control)chkgiam_tru).Enabled = false;
			((TextBoxBase)txtCach_tinh).ReadOnly = false;
			((Control)txtCach_tinh).TabStop = true;
			((TextBoxBase)txtDsTK_co).ReadOnly = true;
			((TextBoxBase)txtDsTk_no).ReadOnly = true;
			((Control)txtDsTK_co).TabStop = false;
			((Control)txtDsTk_no).TabStop = false;
			((TextBoxBase)txtDsTK_co).Clear();
			((TextBoxBase)txtDsTk_no).Clear();
			chkgiam_tru.TextValue = "0";
			((Control)txtCach_tinh).Focus();
		}
	}

	private void chkCach_tinh_Validated(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(chkCach_tinh.Checked))
		{
			((Control)txtDsTk_no).Select();
		}
		else
		{
			((Control)txtCach_tinh).Select();
		}
	}
}
