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
public class frmGLMauBS01Edit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("chkCach_tinh")]
	private AsCheckBox _chkCach_tinh;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txtTK")]
	private AsTextBox _txtTK;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtCach_tinh")]
	private TextBox _txtCach_tinh;

	[AccessedThroughProperty("chkCong_no")]
	private AsCheckBox _chkCong_no;

	[AccessedThroughProperty("chkSodu_duong")]
	private AsCheckBox _chkSodu_duong;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("chkTs_nv")]
	private AsCheckBox _chkTs_nv;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("chkNgoai_bang")]
	private AsCheckBox _chkNgoai_bang;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

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

	[AccessedThroughProperty("txtStt")]
	private TextBox _txtStt;

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

	internal virtual Label lblTen_Tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk = value;
		}
	}

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
			if (_chkCach_tinh != null)
			{
				((Control)_chkCach_tinh).Click -= eventHandler;
			}
			_chkCach_tinh = value;
			if (_chkCach_tinh != null)
			{
				((Control)_chkCach_tinh).Click += eventHandler;
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

	internal virtual AsTextBox txtTK
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtTK_AfterCodeValidating;
			if (_txtTK != null)
			{
				_txtTK.AfterCodeValidating -= obj;
			}
			_txtTK = value;
			if (_txtTK != null)
			{
				_txtTK.AfterCodeValidating += obj;
			}
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

	internal virtual AsCheckBox chkCong_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkCong_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkCong_no = value;
		}
	}

	internal virtual AsCheckBox chkSodu_duong
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkSodu_duong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkSodu_duong = value;
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

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual AsCheckBox chkTs_nv
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkTs_nv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkTs_nv = value;
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

	internal virtual AsCheckBox chkNgoai_bang
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkNgoai_bang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkNgoai_bang = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
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

	[DebuggerNonUserCode]
	public frmGLMauBS01Edit()
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		GroupBox5 = new GroupBox();
		Label11 = new Label();
		txtStt = new TextBox();
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
		chkTs_nv = new AsCheckBox();
		Label7 = new Label();
		chkNgoai_bang = new AsCheckBox();
		Label9 = new Label();
		GroupBox1 = new GroupBox();
		GroupBox2 = new GroupBox();
		lblTen_Tk = new Label();
		chkCach_tinh = new AsCheckBox();
		Label8 = new Label();
		Label5 = new Label();
		txtTK = new AsTextBox();
		Label4 = new Label();
		txtCach_tinh = new TextBox();
		chkCong_no = new AsCheckBox();
		chkSodu_duong = new AsCheckBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(639, 434);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 425);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 425);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk);
		((Control)gbLine).Controls.Add((Control)(object)chkCach_tinh);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)txtTK);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)txtCach_tinh);
		((Control)gbLine).Controls.Add((Control)(object)chkCong_no);
		((Control)gbLine).Controls.Add((Control)(object)chkSodu_duong);
		((Control)gbLine).Controls.Add((Control)(object)GroupBox2);
		((Control)gbLine).Controls.Add((Control)(object)GroupBox1);
		((Control)gbLine).Controls.Add((Control)(object)chkTs_nv);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)chkNgoai_bang);
		((Control)gbLine).Controls.Add((Control)(object)Label9);
		((Control)gbLine).Controls.Add((Control)(object)chkBold);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)chkIn_ck);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)GroupBox5);
		((Control)gbLine).Controls.Add((Control)(object)Label11);
		((Control)gbLine).Controls.Add((Control)(object)txtStt);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_so);
		((Control)gbLine).Controls.Add((Control)(object)txtChi_tieu);
		((Control)gbLine).Controls.Add((Control)(object)Label10);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)txtTm);
		GroupBox obj3 = gbLine;
		Size size = new Size(626, 413);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTm, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label10, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtChi_tieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_so, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtStt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label11, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)GroupBox5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkIn_ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkBold, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label9, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkNgoai_bang, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkTs_nv, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)GroupBox1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)GroupBox2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkSodu_duong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkCong_no, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtCach_tinh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkCach_tinh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)GroupBox5).BackColor = SystemColors.ButtonFace;
		GroupBox groupBox = GroupBox5;
		location = new Point(16, 128);
		((Control)groupBox).Location = location;
		((Control)GroupBox5).Name = "GroupBox5";
		GroupBox groupBox2 = GroupBox5;
		size = new Size(587, 5);
		((Control)groupBox2).Size = size;
		((Control)GroupBox5).TabIndex = 129;
		GroupBox5.TabStop = false;
		Label11.AutoSize = true;
		Label label = Label11;
		location = new Point(14, 22);
		((Control)label).Location = location;
		((Control)Label11).Name = "Label11";
		Label label2 = Label11;
		size = new Size(50, 13);
		((Control)label2).Size = size;
		((Control)Label11).TabIndex = 132;
		Label11.Text = "Số thứ tự";
		TextBox obj4 = txtStt;
		location = new Point(93, 19);
		((Control)obj4).Location = location;
		((Control)txtStt).Name = "txtStt";
		TextBox obj5 = txtStt;
		size = new Size(100, 20);
		((Control)obj5).Size = size;
		((Control)txtStt).TabIndex = 0;
		Label1.AutoSize = true;
		Label label3 = Label1;
		location = new Point(14, 49);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(36, 13);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 129;
		Label1.Text = "Mã số";
		TextBox obj6 = txtMa_so;
		location = new Point(93, 45);
		((Control)obj6).Location = location;
		((Control)txtMa_so).Name = "txtMa_so";
		TextBox obj7 = txtMa_so;
		size = new Size(100, 20);
		((Control)obj7).Size = size;
		((Control)txtMa_so).TabIndex = 1;
		TextBox obj8 = txtChi_tieu;
		location = new Point(93, 97);
		((Control)obj8).Location = location;
		((Control)txtChi_tieu).Name = "txtChi_tieu";
		TextBox obj9 = txtChi_tieu;
		size = new Size(313, 20);
		((Control)obj9).Size = size;
		((Control)txtChi_tieu).TabIndex = 3;
		Label10.AutoSize = true;
		Label label5 = Label10;
		location = new Point(14, 75);
		((Control)label5).Location = location;
		((Control)Label10).Name = "Label10";
		Label label6 = Label10;
		size = new Size(65, 13);
		((Control)label6).Size = size;
		((Control)Label10).TabIndex = 131;
		Label10.Text = "Thuyết minh";
		Label2.AutoSize = true;
		Label label7 = Label2;
		location = new Point(14, 101);
		((Control)label7).Location = location;
		((Control)Label2).Name = "Label2";
		Label label8 = Label2;
		size = new Size(42, 13);
		((Control)label8).Size = size;
		((Control)Label2).TabIndex = 130;
		Label2.Text = "Chỉ tiêu";
		TextBox obj10 = txtTm;
		location = new Point(93, 71);
		((Control)obj10).Location = location;
		((Control)txtTm).Name = "txtTm";
		TextBox obj11 = txtTm;
		size = new Size(100, 20);
		((Control)obj11).Size = size;
		((Control)txtTm).TabIndex = 2;
		((ButtonBase)chkBold).AutoSize = true;
		chkBold.Checked = false;
		((Control)chkBold).ForeColor = Color.Black;
		AsCheckBox asCheckBox2 = chkBold;
		location = new Point(93, 163);
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
		location = new Point(14, 165);
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
		location = new Point(93, 140);
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
		location = new Point(14, 141);
		((Control)label11).Location = location;
		((Control)Label3).Name = "Label3";
		Label label12 = Label3;
		size = new Size(16, 13);
		((Control)label12).Size = size;
		((Control)Label3).TabIndex = 135;
		Label3.Text = "In";
		((ButtonBase)chkTs_nv).AutoSize = true;
		chkTs_nv.Checked = false;
		((Control)chkTs_nv).ForeColor = Color.Black;
		AsCheckBox asCheckBox6 = chkTs_nv;
		location = new Point(93, 204);
		((Control)asCheckBox6).Location = location;
		((Control)chkTs_nv).Name = "chkTs_nv";
		AsCheckBox asCheckBox7 = chkTs_nv;
		size = new Size(123, 17);
		((Control)asCheckBox7).Size = size;
		((Control)chkTs_nv).TabIndex = 6;
		((ButtonBase)chkTs_nv).Text = "Tài sản / nguồn vốn";
		chkTs_nv.TextValue = "0";
		((ButtonBase)chkTs_nv).UseVisualStyleBackColor = true;
		Label7.AutoSize = true;
		Label label13 = Label7;
		location = new Point(14, 229);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(62, 13);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 140;
		Label7.Text = "Ngoại bảng";
		((ButtonBase)chkNgoai_bang).AutoSize = true;
		chkNgoai_bang.Checked = false;
		((Control)chkNgoai_bang).ForeColor = Color.Black;
		AsCheckBox asCheckBox8 = chkNgoai_bang;
		location = new Point(93, 228);
		((Control)asCheckBox8).Location = location;
		((Control)chkNgoai_bang).Name = "chkNgoai_bang";
		AsCheckBox asCheckBox9 = chkNgoai_bang;
		size = new Size(143, 17);
		((Control)asCheckBox9).Size = size;
		((Control)chkNgoai_bang).TabIndex = 7;
		((ButtonBase)chkNgoai_bang).Text = "Ngoại bảng / trong bảng";
		chkNgoai_bang.TextValue = "0";
		((ButtonBase)chkNgoai_bang).UseVisualStyleBackColor = true;
		Label9.AutoSize = true;
		Label label15 = Label9;
		location = new Point(14, 205);
		((Control)label15).Location = location;
		((Control)Label9).Name = "Label9";
		Label label16 = Label9;
		size = new Size(51, 13);
		((Control)label16).Size = size;
		((Control)Label9).TabIndex = 139;
		Label9.Text = "Phân loại";
		((Control)GroupBox1).BackColor = SystemColors.ButtonFace;
		GroupBox groupBox3 = GroupBox1;
		location = new Point(16, 194);
		((Control)groupBox3).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox4 = GroupBox1;
		size = new Size(587, 5);
		((Control)groupBox4).Size = size;
		((Control)GroupBox1).TabIndex = 141;
		GroupBox1.TabStop = false;
		((Control)GroupBox2).BackColor = SystemColors.ButtonFace;
		GroupBox groupBox5 = GroupBox2;
		location = new Point(16, 262);
		((Control)groupBox5).Location = location;
		((Control)GroupBox2).Name = "GroupBox2";
		GroupBox groupBox6 = GroupBox2;
		size = new Size(587, 5);
		((Control)groupBox6).Size = size;
		((Control)GroupBox2).TabIndex = 142;
		GroupBox2.TabStop = false;
		Label obj12 = lblTen_Tk;
		location = new Point(199, 299);
		((Control)obj12).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj13 = lblTen_Tk;
		size = new Size(404, 13);
		((Control)obj13).Size = size;
		((Control)lblTen_Tk).TabIndex = 151;
		((ButtonBase)chkCach_tinh).AutoSize = true;
		chkCach_tinh.Checked = false;
		AsCheckBox asCheckBox10 = chkCach_tinh;
		location = new Point(93, 272);
		((Control)asCheckBox10).Location = location;
		((Control)chkCach_tinh).Name = "chkCach_tinh";
		AsCheckBox asCheckBox11 = chkCach_tinh;
		size = new Size(254, 17);
		((Control)asCheckBox11).Size = size;
		((Control)chkCach_tinh).TabIndex = 8;
		((ButtonBase)chkCach_tinh).Text = "Tính theo số dư tài khoản / tính theo công thức";
		chkCach_tinh.TextValue = "0";
		((ButtonBase)chkCach_tinh).UseVisualStyleBackColor = true;
		Label8.AutoSize = true;
		Label label17 = Label8;
		location = new Point(26, 371);
		((Control)label17).Location = location;
		((Control)Label8).Name = "Label8";
		Label label18 = Label8;
		size = new Size(62, 13);
		((Control)label18).Size = size;
		((Control)Label8).TabIndex = 150;
		Label8.Text = "- Công thức";
		Label5.AutoSize = true;
		Label label19 = Label5;
		location = new Point(14, 274);
		((Control)label19).Location = location;
		((Control)Label5).Name = "Label5";
		Label label20 = Label5;
		size = new Size(54, 13);
		((Control)label20).Size = size;
		((Control)Label5).TabIndex = 149;
		Label5.Text = "Cách tính";
		txtTK.AutoLookup = true;
		txtTK.AutoValid = true;
		((TextBoxBase)txtTK).BackColor = SystemColors.Control;
		((TextBox)txtTK).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTK;
		location = new Point(93, 295);
		((Control)asTextBox).Location = location;
		txtTK.LookupCodeName = "TK";
		((Control)txtTK).Name = "txtTK";
		txtTK.NameControl = lblTen_Tk;
		((TextBoxBase)txtTK).ReadOnly = true;
		AsTextBox asTextBox2 = txtTK;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTK).TabIndex = 9;
		((Control)txtTK).Tag = "TK";
		txtTK.ValidReturnFieldList = "tk_cn";
		Label4.AutoSize = true;
		Label label21 = Label4;
		location = new Point(26, 299);
		((Control)label21).Location = location;
		((Control)Label4).Name = "Label4";
		Label label22 = Label4;
		size = new Size(61, 13);
		((Control)label22).Size = size;
		((Control)Label4).TabIndex = 148;
		Label4.Text = "- Tài khoản";
		TextBox obj14 = txtCach_tinh;
		location = new Point(93, 367);
		((Control)obj14).Location = location;
		((Control)txtCach_tinh).Name = "txtCach_tinh";
		TextBox obj15 = txtCach_tinh;
		size = new Size(510, 20);
		((Control)obj15).Size = size;
		((Control)txtCach_tinh).TabIndex = 12;
		((ButtonBase)chkCong_no).AutoSize = true;
		chkCong_no.Checked = false;
		((Control)chkCong_no).Enabled = false;
		((Control)chkCong_no).ForeColor = Color.Blue;
		AsCheckBox asCheckBox12 = chkCong_no;
		location = new Point(93, 321);
		((Control)asCheckBox12).Location = location;
		((Control)chkCong_no).Name = "chkCong_no";
		AsCheckBox asCheckBox13 = chkCong_no;
		size = new Size(244, 17);
		((Control)asCheckBox13).Size = size;
		((Control)chkCong_no).TabIndex = 10;
		((ButtonBase)chkCong_no).Text = "Lấy chi tiết một vế của các đối tượng công nợ";
		chkCong_no.TextValue = "0";
		((ButtonBase)chkCong_no).UseVisualStyleBackColor = true;
		((ButtonBase)chkSodu_duong).AutoSize = true;
		chkSodu_duong.Checked = false;
		((Control)chkSodu_duong).Enabled = false;
		((Control)chkSodu_duong).ForeColor = Color.Blue;
		AsCheckBox asCheckBox14 = chkSodu_duong;
		location = new Point(93, 344);
		((Control)asCheckBox14).Location = location;
		((Control)chkSodu_duong).Name = "chkSodu_duong";
		AsCheckBox asCheckBox15 = chkSodu_duong;
		size = new Size(133, 17);
		((Control)asCheckBox15).Size = size;
		((Control)chkSodu_duong).TabIndex = 11;
		((ButtonBase)chkSodu_duong).Text = "Chỉ lấy số dư lớn hơn 0";
		chkSodu_duong.TextValue = "0";
		((ButtonBase)chkSodu_duong).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(650, 460);
		((Form)this).ClientSize = size;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmGLMauBS01Edit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
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
		if ((Operators.CompareString(((TextBox)txtTK).Text.Trim(), "", false) == 0 && Operators.CompareString(txtCach_tinh.Text.Trim(), "", false) != 0) ? true : false)
		{
			((CheckBox)chkCach_tinh).CheckState = (CheckState)0;
		}
		if ((Operators.CompareString(txtCach_tinh.Text.Trim(), "", false) == 0 && Operators.CompareString(((TextBox)txtTK).Text.Trim(), "", false) != 0) ? true : false)
		{
			((CheckBox)chkCach_tinh).CheckState = (CheckState)1;
		}
		chkCach_tinh_Click(null, null);
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_so).Enabled = false;
		((Control)txtTm).Focus();
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
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
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
		ojb = (Control)(object)txtTK;
		CreateDataBinding(ref ojb, "tk");
		txtTK = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtCach_tinh;
		CreateDataBinding(ref ojb, "cach_tinh");
		txtCach_tinh = (TextBox)ojb;
		ojb = (Control)(object)txtTm;
		CreateDataBinding(ref ojb, "Tm");
		txtTm = (TextBox)ojb;
		ojb = (Control)(object)chkIn_ck;
		CreateDataBinding(ref ojb, "in_ck", "Checked");
		chkIn_ck = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkCong_no;
		CreateDataBinding(ref ojb, "cong_no", "Checked");
		chkCong_no = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkBold;
		CreateDataBinding(ref ojb, "bold", "Checked");
		chkBold = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkNgoai_bang;
		CreateDataBinding(ref ojb, "ngoai_bang", "Checked");
		chkNgoai_bang = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkSodu_duong;
		CreateDataBinding(ref ojb, "sodu_duong", "Checked");
		chkSodu_duong = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkTs_nv;
		CreateDataBinding(ref ojb, "ts_nv", "Checked");
		chkTs_nv = (AsCheckBox)(object)ojb;
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
			return (Commons.ChkEmtyTextBoxAndShowMessageBox((TextBox)(object)txtTK) && base.ValidData()) ? true : false;
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
			((Control)chkCong_no).Enabled = true;
			((Control)chkSodu_duong).Enabled = true;
			((TextBoxBase)txtCach_tinh).ReadOnly = true;
			((Control)txtCach_tinh).TabStop = false;
			((TextBoxBase)txtTK).ReadOnly = false;
			((Control)txtTK).TabStop = true;
			((TextBoxBase)txtCach_tinh).Clear();
			((Control)txtTK).Focus();
		}
		else
		{
			((Control)chkCong_no).Enabled = false;
			((Control)chkSodu_duong).Enabled = false;
			((TextBoxBase)txtCach_tinh).ReadOnly = false;
			((Control)txtCach_tinh).TabStop = true;
			((TextBoxBase)txtTK).ReadOnly = true;
			((Control)txtTK).TabStop = false;
			((TextBoxBase)txtTK).Clear();
			chkCong_no.TextValue = "0";
			((Control)txtCach_tinh).Focus();
		}
	}

	private void txtTK_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (Operators.CompareString(((TextBox)txtTK).Text.Trim(), "", false) != 0)
		{
		}
	}
}
