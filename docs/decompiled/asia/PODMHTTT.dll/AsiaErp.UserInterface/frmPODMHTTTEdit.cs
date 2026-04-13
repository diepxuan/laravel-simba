using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmPODMHTTTEdit : frmDMComplexEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblNK_co")]
	private Label _lblNK_co;

	[AccessedThroughProperty("lblNK_no")]
	private Label _lblNK_no;

	[AccessedThroughProperty("lblTK_NK")]
	private Label _lblTK_NK;

	[AccessedThroughProperty("lblTK_thue_mua")]
	private Label _lblTK_thue_mua;

	[AccessedThroughProperty("lblTK")]
	private Label _lblTK;

	[AccessedThroughProperty("lblTen_httt")]
	private Label _lblTen_httt;

	[AccessedThroughProperty("lblMa_httt")]
	private Label _lblMa_httt;

	[AccessedThroughProperty("txtTK")]
	private AsTextBox _txtTK;

	[AccessedThroughProperty("txtTen_httt")]
	private TextBox _txtTen_httt;

	[AccessedThroughProperty("txtMa_httt")]
	private TextBox _txtMa_httt;

	[AccessedThroughProperty("txtTK_NK_co")]
	private AsTextBox _txtTK_NK_co;

	[AccessedThroughProperty("txtTK_NK_no")]
	private AsTextBox _txtTK_NK_no;

	[AccessedThroughProperty("txtThue_NK")]
	private AsTextBox _txtThue_NK;

	[AccessedThroughProperty("txtThue_mua")]
	private AsTextBox _txtThue_mua;

	[AccessedThroughProperty("lblTen_TK_NK_co")]
	private Label _lblTen_TK_NK_co;

	[AccessedThroughProperty("lblTen_TK_NK_no")]
	private Label _lblTen_TK_NK_no;

	[AccessedThroughProperty("lblTen_TK_thue_NK")]
	private Label _lblTen_TK_thue_NK;

	[AccessedThroughProperty("lblTen_Tk_thue_mua")]
	private Label _lblTen_Tk_thue_mua;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("lblTen_tk_thue_ttdb")]
	private Label _lblTen_tk_thue_ttdb;

	[AccessedThroughProperty("txtTk_thue_ttdb")]
	private AsTextBox _txtTk_thue_ttdb;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblTk_ck")]
	private Label _lblTk_ck;

	[AccessedThroughProperty("txtTk_ck")]
	private AsTextBox _txtTk_ck;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("lblThue_GTGT_Tralai")]
	private Label _lblThue_GTGT_Tralai;

	[AccessedThroughProperty("txtThue_gtgt_tralai")]
	private AsTextBox _txtThue_gtgt_tralai;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	internal virtual Label lblNK_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNK_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNK_co = value;
		}
	}

	internal virtual Label lblNK_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNK_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNK_no = value;
		}
	}

	internal virtual Label lblTK_NK
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_NK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_NK = value;
		}
	}

	internal virtual Label lblTK_thue_mua
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_thue_mua;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_thue_mua = value;
		}
	}

	internal virtual Label lblTK
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK = value;
		}
	}

	internal virtual Label lblTen_httt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_httt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_httt = value;
		}
	}

	internal virtual Label lblMa_httt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_httt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_httt = value;
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
			_txtTK = value;
		}
	}

	internal virtual TextBox txtTen_httt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_httt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_httt = value;
		}
	}

	internal virtual TextBox txtMa_httt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_httt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_httt = value;
		}
	}

	internal virtual AsTextBox txtTK_NK_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_NK_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_NK_co = value;
		}
	}

	internal virtual AsTextBox txtTK_NK_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_NK_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_NK_no = value;
		}
	}

	internal virtual AsTextBox txtThue_NK
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtThue_NK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtThue_NK = value;
		}
	}

	internal virtual AsTextBox txtThue_mua
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtThue_mua;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtThue_mua = value;
		}
	}

	private virtual Label lblTen_TK_NK_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TK_NK_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TK_NK_co = value;
		}
	}

	private virtual Label lblTen_TK_NK_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TK_NK_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TK_NK_no = value;
		}
	}

	private virtual Label lblTen_TK_thue_NK
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TK_thue_NK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TK_thue_NK = value;
		}
	}

	private virtual Label lblTen_Tk_thue_mua
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_thue_mua;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_thue_mua = value;
		}
	}

	private virtual Label lblTen_Tk
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

	private virtual Label lblTen_tk_thue_ttdb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk_thue_ttdb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk_thue_ttdb = value;
		}
	}

	internal virtual AsTextBox txtTk_thue_ttdb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_thue_ttdb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_thue_ttdb = value;
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

	private virtual Label lblTk_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_ck = value;
		}
	}

	internal virtual AsTextBox txtTk_ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_ck = value;
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

	internal virtual Label lblThue_GTGT_Tralai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblThue_GTGT_Tralai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblThue_GTGT_Tralai = value;
		}
	}

	internal virtual AsTextBox txtThue_gtgt_tralai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtThue_gtgt_tralai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtThue_gtgt_tralai = value;
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

	[DebuggerNonUserCode]
	public frmPODMHTTTEdit()
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
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		lblMa_httt = new Label();
		lblTen_httt = new Label();
		lblTK = new Label();
		lblTK_thue_mua = new Label();
		lblTK_NK = new Label();
		lblNK_no = new Label();
		lblNK_co = new Label();
		txtMa_httt = new TextBox();
		txtTen_httt = new TextBox();
		txtTK = new AsTextBox();
		lblTen_Tk = new Label();
		txtThue_mua = new AsTextBox();
		lblTen_Tk_thue_mua = new Label();
		txtThue_NK = new AsTextBox();
		lblTen_TK_thue_NK = new Label();
		txtTK_NK_no = new AsTextBox();
		lblTen_TK_NK_no = new Label();
		txtTK_NK_co = new AsTextBox();
		lblTen_TK_NK_co = new Label();
		Label1 = new Label();
		txtTk_thue_ttdb = new AsTextBox();
		lblTen_tk_thue_ttdb = new Label();
		lblTk_ck = new Label();
		txtTk_ck = new AsTextBox();
		Label3 = new Label();
		lblThue_GTGT_Tralai = new Label();
		txtThue_gtgt_tralai = new AsTextBox();
		Label5 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(159, 282);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 10;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 321);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 321);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblThue_GTGT_Tralai);
		((Control)gbLine).Controls.Add((Control)(object)txtThue_gtgt_tralai);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_ck);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_ck);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk_thue_ttdb);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_TK_NK_co);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_TK_NK_no);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_TK_thue_NK);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_thue_mua);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_thue_ttdb);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_NK_co);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_NK_no);
		((Control)gbLine).Controls.Add((Control)(object)txtThue_NK);
		((Control)gbLine).Controls.Add((Control)(object)txtThue_mua);
		((Control)gbLine).Controls.Add((Control)(object)txtTK);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_httt);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_httt);
		((Control)gbLine).Controls.Add((Control)(object)lblNK_co);
		((Control)gbLine).Controls.Add((Control)(object)lblNK_no);
		((Control)gbLine).Controls.Add((Control)(object)lblTK_NK);
		((Control)gbLine).Controls.Add((Control)(object)lblTK_thue_mua);
		((Control)gbLine).Controls.Add((Control)(object)lblTK);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_httt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_httt);
		GroupBox obj3 = gbLine;
		Size size = new Size(549, 309);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_httt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_httt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK_thue_mua, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK_NK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNK_no, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNK_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_httt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_httt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtThue_mua, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtThue_NK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_NK_no, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_NK_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_thue_ttdb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_thue_mua, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_TK_thue_NK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_TK_NK_no, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_TK_NK_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk_thue_ttdb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtThue_gtgt_tralai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblThue_GTGT_Tralai, 0);
		lblMa_httt.AutoSize = true;
		Label obj4 = lblMa_httt;
		location = new Point(20, 26);
		((Control)obj4).Location = location;
		((Control)lblMa_httt).Name = "lblMa_httt";
		Label obj5 = lblMa_httt;
		size = new Size(123, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_httt).TabIndex = 100;
		lblMa_httt.Text = "Mã hình thức thanh toán";
		lblTen_httt.AutoSize = true;
		Label obj6 = lblTen_httt;
		location = new Point(20, 52);
		((Control)obj6).Location = location;
		((Control)lblTen_httt).Name = "lblTen_httt";
		Label obj7 = lblTen_httt;
		size = new Size(130, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_httt).TabIndex = 101;
		lblTen_httt.Text = "Tên  hình thức thanh toán";
		lblTK.AutoSize = true;
		Label obj8 = lblTK;
		location = new Point(20, 78);
		((Control)obj8).Location = location;
		((Control)lblTK).Name = "lblTK";
		Label obj9 = lblTK;
		size = new Size(55, 13);
		((Control)obj9).Size = size;
		((Control)lblTK).TabIndex = 102;
		lblTK.Text = "Tài khoản";
		lblTK_thue_mua.AutoSize = true;
		Label obj10 = lblTK_thue_mua;
		location = new Point(20, 104);
		((Control)obj10).Location = location;
		((Control)lblTK_thue_mua).Name = "lblTK_thue_mua";
		Label obj11 = lblTK_thue_mua;
		size = new Size(101, 13);
		((Control)obj11).Size = size;
		((Control)lblTK_thue_mua).TabIndex = 104;
		lblTK_thue_mua.Text = "TK thuế GTGT mua";
		lblTK_NK.AutoSize = true;
		Label obj12 = lblTK_NK;
		location = new Point(20, 156);
		((Control)obj12).Location = location;
		((Control)lblTK_NK).Name = "lblTK_NK";
		Label obj13 = lblTK_NK;
		size = new Size(99, 13);
		((Control)obj13).Size = size;
		((Control)lblTK_NK).TabIndex = 105;
		lblTK_NK.Text = "TK thuế nhập khẩu";
		lblNK_no.AutoSize = true;
		Label obj14 = lblNK_no;
		location = new Point(20, 182);
		((Control)obj14).Location = location;
		((Control)lblNK_no).Name = "lblNK_no";
		Label obj15 = lblNK_no;
		size = new Size(126, 13);
		((Control)obj15).Size = size;
		((Control)lblNK_no).TabIndex = 106;
		lblNK_no.Text = "TK  GTGT nhập khẩu nợ";
		lblNK_co.AutoSize = true;
		Label obj16 = lblNK_co;
		location = new Point(20, 208);
		((Control)obj16).Location = location;
		((Control)lblNK_co).Name = "lblNK_co";
		Label obj17 = lblNK_co;
		size = new Size(126, 13);
		((Control)obj17).Size = size;
		((Control)lblNK_co).TabIndex = 107;
		lblNK_co.Text = "TK  GTGT nhập khẩu có";
		txtMa_httt.CharacterCasing = (CharacterCasing)1;
		TextBox obj18 = txtMa_httt;
		location = new Point(159, 23);
		((Control)obj18).Location = location;
		((Control)txtMa_httt).Name = "txtMa_httt";
		TextBox obj19 = txtMa_httt;
		size = new Size(100, 20);
		((Control)obj19).Size = size;
		((Control)txtMa_httt).TabIndex = 0;
		TextBox obj20 = txtTen_httt;
		location = new Point(159, 49);
		((Control)obj20).Location = location;
		((Control)txtTen_httt).Name = "txtTen_httt";
		TextBox obj21 = txtTen_httt;
		size = new Size(369, 20);
		((Control)obj21).Size = size;
		((Control)txtTen_httt).TabIndex = 1;
		txtTK.AutoLookup = true;
		txtTK.AutoValid = true;
		((TextBoxBase)txtTK).BackColor = SystemColors.Info;
		((TextBox)txtTK).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTK;
		location = new Point(159, 75);
		((Control)asTextBox).Location = location;
		txtTK.LookupCodeName = "TK";
		txtTK.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTK).Name = "txtTK";
		txtTK.NameControl = lblTen_Tk;
		txtTK.SD = true;
		AsTextBox asTextBox2 = txtTK;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTK).TabIndex = 2;
		txtTK.UseAutoCompleteSource = true;
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj22 = lblTen_Tk;
		location = new Point(265, 78);
		((Control)obj22).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj23 = lblTen_Tk;
		size = new Size(278, 13);
		((Control)obj23).Size = size;
		((Control)lblTen_Tk).TabIndex = 1075;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		txtThue_mua.AutoLookup = true;
		txtThue_mua.AutoValid = true;
		((TextBoxBase)txtThue_mua).BackColor = SystemColors.Info;
		((TextBox)txtThue_mua).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtThue_mua;
		location = new Point(159, 101);
		((Control)asTextBox3).Location = location;
		txtThue_mua.LookupCodeName = "TK";
		txtThue_mua.LookupWhereCondition = "chi_tiet=1";
		((Control)txtThue_mua).Name = "txtThue_mua";
		txtThue_mua.NameControl = lblTen_Tk_thue_mua;
		txtThue_mua.SD = true;
		AsTextBox asTextBox4 = txtThue_mua;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtThue_mua).TabIndex = 3;
		txtThue_mua.UseAutoCompleteSource = true;
		lblTen_Tk_thue_mua.ImeMode = (ImeMode)0;
		Label obj24 = lblTen_Tk_thue_mua;
		location = new Point(265, 104);
		((Control)obj24).Location = location;
		((Control)lblTen_Tk_thue_mua).Name = "lblTen_Tk_thue_mua";
		Label obj25 = lblTen_Tk_thue_mua;
		size = new Size(278, 13);
		((Control)obj25).Size = size;
		((Control)lblTen_Tk_thue_mua).TabIndex = 1077;
		lblTen_Tk_thue_mua.TextAlign = (ContentAlignment)16;
		txtThue_NK.AutoLookup = true;
		txtThue_NK.AutoValid = true;
		((TextBoxBase)txtThue_NK).BackColor = SystemColors.Info;
		((TextBox)txtThue_NK).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtThue_NK;
		location = new Point(159, 153);
		((Control)asTextBox5).Location = location;
		txtThue_NK.LookupCodeName = "TK";
		txtThue_NK.LookupWhereCondition = "chi_tiet=1";
		((Control)txtThue_NK).Name = "txtThue_NK";
		txtThue_NK.NameControl = lblTen_TK_thue_NK;
		txtThue_NK.SD = true;
		AsTextBox asTextBox6 = txtThue_NK;
		size = new Size(100, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtThue_NK).TabIndex = 5;
		txtThue_NK.UseAutoCompleteSource = true;
		lblTen_TK_thue_NK.ImeMode = (ImeMode)0;
		Label obj26 = lblTen_TK_thue_NK;
		location = new Point(265, 156);
		((Control)obj26).Location = location;
		((Control)lblTen_TK_thue_NK).Name = "lblTen_TK_thue_NK";
		Label obj27 = lblTen_TK_thue_NK;
		size = new Size(278, 13);
		((Control)obj27).Size = size;
		((Control)lblTen_TK_thue_NK).TabIndex = 1078;
		lblTen_TK_thue_NK.TextAlign = (ContentAlignment)16;
		txtTK_NK_no.AutoLookup = true;
		txtTK_NK_no.AutoValid = true;
		((TextBoxBase)txtTK_NK_no).BackColor = SystemColors.Info;
		((TextBox)txtTK_NK_no).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtTK_NK_no;
		location = new Point(159, 179);
		((Control)asTextBox7).Location = location;
		txtTK_NK_no.LookupCodeName = "TK";
		txtTK_NK_no.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTK_NK_no).Name = "txtTK_NK_no";
		txtTK_NK_no.NameControl = lblTen_TK_NK_no;
		txtTK_NK_no.SD = true;
		AsTextBox asTextBox8 = txtTK_NK_no;
		size = new Size(100, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtTK_NK_no).TabIndex = 6;
		txtTK_NK_no.UseAutoCompleteSource = true;
		lblTen_TK_NK_no.ImeMode = (ImeMode)0;
		Label obj28 = lblTen_TK_NK_no;
		location = new Point(265, 182);
		((Control)obj28).Location = location;
		((Control)lblTen_TK_NK_no).Name = "lblTen_TK_NK_no";
		Label obj29 = lblTen_TK_NK_no;
		size = new Size(278, 13);
		((Control)obj29).Size = size;
		((Control)lblTen_TK_NK_no).TabIndex = 1079;
		lblTen_TK_NK_no.TextAlign = (ContentAlignment)16;
		txtTK_NK_co.AutoLookup = true;
		txtTK_NK_co.AutoValid = true;
		((TextBoxBase)txtTK_NK_co).BackColor = SystemColors.Info;
		((TextBox)txtTK_NK_co).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtTK_NK_co;
		location = new Point(159, 205);
		((Control)asTextBox9).Location = location;
		txtTK_NK_co.LookupCodeName = "TK";
		txtTK_NK_co.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTK_NK_co).Name = "txtTK_NK_co";
		txtTK_NK_co.NameControl = lblTen_TK_NK_co;
		txtTK_NK_co.SD = true;
		AsTextBox asTextBox10 = txtTK_NK_co;
		size = new Size(100, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtTK_NK_co).TabIndex = 7;
		txtTK_NK_co.UseAutoCompleteSource = true;
		lblTen_TK_NK_co.ImeMode = (ImeMode)0;
		Label obj30 = lblTen_TK_NK_co;
		location = new Point(265, 208);
		((Control)obj30).Location = location;
		((Control)lblTen_TK_NK_co).Name = "lblTen_TK_NK_co";
		Label obj31 = lblTen_TK_NK_co;
		size = new Size(278, 13);
		((Control)obj31).Size = size;
		((Control)lblTen_TK_NK_co).TabIndex = 1080;
		lblTen_TK_NK_co.TextAlign = (ContentAlignment)16;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(20, 234);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(125, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 107;
		Label1.Text = "TK thuế tiêu thụ đặc biệt";
		txtTk_thue_ttdb.AutoLookup = true;
		txtTk_thue_ttdb.AutoValid = true;
		((TextBoxBase)txtTk_thue_ttdb).BackColor = SystemColors.Info;
		((TextBox)txtTk_thue_ttdb).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtTk_thue_ttdb;
		location = new Point(159, 231);
		((Control)asTextBox11).Location = location;
		txtTk_thue_ttdb.LookupCodeName = "TK";
		txtTk_thue_ttdb.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_thue_ttdb).Name = "txtTk_thue_ttdb";
		txtTk_thue_ttdb.NameControl = lblTen_tk_thue_ttdb;
		txtTk_thue_ttdb.SD = true;
		AsTextBox asTextBox12 = txtTk_thue_ttdb;
		size = new Size(100, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtTk_thue_ttdb).TabIndex = 8;
		txtTk_thue_ttdb.UseAutoCompleteSource = true;
		lblTen_tk_thue_ttdb.ImeMode = (ImeMode)0;
		Label obj32 = lblTen_tk_thue_ttdb;
		location = new Point(265, 234);
		((Control)obj32).Location = location;
		((Control)lblTen_tk_thue_ttdb).Name = "lblTen_tk_thue_ttdb";
		Label obj33 = lblTen_tk_thue_ttdb;
		size = new Size(278, 13);
		((Control)obj33).Size = size;
		((Control)lblTen_tk_thue_ttdb).TabIndex = 1080;
		lblTen_tk_thue_ttdb.TextAlign = (ContentAlignment)16;
		lblTk_ck.ImeMode = (ImeMode)0;
		Label obj34 = lblTk_ck;
		location = new Point(265, 260);
		((Control)obj34).Location = location;
		((Control)lblTk_ck).Name = "lblTk_ck";
		Label obj35 = lblTk_ck;
		size = new Size(278, 13);
		((Control)obj35).Size = size;
		((Control)lblTk_ck).TabIndex = 1083;
		lblTk_ck.TextAlign = (ContentAlignment)16;
		txtTk_ck.AutoLookup = true;
		txtTk_ck.AutoValid = true;
		((TextBoxBase)txtTk_ck).BackColor = SystemColors.Info;
		((TextBox)txtTk_ck).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox13 = txtTk_ck;
		location = new Point(159, 257);
		((Control)asTextBox13).Location = location;
		txtTk_ck.LookupCodeName = "TK";
		txtTk_ck.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_ck).Name = "txtTk_ck";
		txtTk_ck.NameControl = lblTk_ck;
		txtTk_ck.SD = true;
		AsTextBox asTextBox14 = txtTk_ck;
		size = new Size(100, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtTk_ck).TabIndex = 9;
		txtTk_ck.UseAutoCompleteSource = true;
		Label3.AutoSize = true;
		Label label3 = Label3;
		location = new Point(20, 260);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		Label label4 = Label3;
		size = new Size(74, 13);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 1082;
		Label3.Text = "TK chiết khấu";
		((Control)lblThue_GTGT_Tralai).BackColor = Color.Transparent;
		((Control)lblThue_GTGT_Tralai).Cursor = Cursors.WaitCursor;
		Label obj36 = lblThue_GTGT_Tralai;
		location = new Point(265, 127);
		((Control)obj36).Location = location;
		((Control)lblThue_GTGT_Tralai).Name = "lblThue_GTGT_Tralai";
		Label obj37 = lblThue_GTGT_Tralai;
		size = new Size(278, 20);
		((Control)obj37).Size = size;
		((Control)lblThue_GTGT_Tralai).TabIndex = 1086;
		txtThue_gtgt_tralai.AutoLookup = true;
		txtThue_gtgt_tralai.AutoValid = true;
		((TextBoxBase)txtThue_gtgt_tralai).BackColor = SystemColors.Info;
		((TextBox)txtThue_gtgt_tralai).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox15 = txtThue_gtgt_tralai;
		location = new Point(159, 127);
		((Control)asTextBox15).Location = location;
		txtThue_gtgt_tralai.LookupCodeName = "TK";
		txtThue_gtgt_tralai.LookupWhereCondition = "chi_tiet=1";
		((TextBoxBase)txtThue_gtgt_tralai).MaxLength = 20;
		((Control)txtThue_gtgt_tralai).Name = "txtThue_gtgt_tralai";
		txtThue_gtgt_tralai.NameControl = lblThue_GTGT_Tralai;
		txtThue_gtgt_tralai.SD = true;
		AsTextBox asTextBox16 = txtThue_gtgt_tralai;
		size = new Size(100, 20);
		((Control)asTextBox16).Size = size;
		((Control)txtThue_gtgt_tralai).TabIndex = 4;
		txtThue_gtgt_tralai.UseAutoCompleteSource = true;
		Label5.AutoSize = true;
		Label label5 = Label5;
		location = new Point(20, 130);
		((Control)label5).Location = location;
		((Control)Label5).Name = "Label5";
		Label label6 = Label5;
		size = new Size(106, 13);
		((Control)label6).Size = size;
		((Control)Label5).TabIndex = 1085;
		Label5.Text = "TK thuế GTGT trả lại";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(573, 356);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmPODMHTTTEdit";
		((Form)this).Text = "frmPODMHTTTEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_httt).MaxLength = base.MyDictComplexInfo.code_length;
		((Control)txtMa_httt).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_httt).Enabled = false;
		((Control)txtTen_httt).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_httt;
		CreateDataBinding(ref ojb, "Ma_HTTT");
		txtMa_httt = (TextBox)ojb;
		ojb = (Control)(object)txtTen_httt;
		CreateDataBinding(ref ojb, "Ten_HTTT");
		txtTen_httt = (TextBox)ojb;
		ojb = (Control)(object)txtTK;
		CreateDataBinding(ref ojb, "TK");
		txtTK = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtThue_mua;
		CreateDataBinding(ref ojb, "tk_thue_gtgt_mua");
		txtThue_mua = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtThue_gtgt_tralai;
		CreateDataBinding(ref ojb, "TK_THUE_GTGT_BAN");
		txtThue_gtgt_tralai = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtThue_NK;
		CreateDataBinding(ref ojb, "tk_thue_nk");
		txtThue_NK = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTK_NK_no;
		CreateDataBinding(ref ojb, "tk_gtgt_nk_no");
		txtTK_NK_no = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTK_NK_co;
		CreateDataBinding(ref ojb, "tk_gtgt_nk_co");
		txtTK_NK_co = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk_thue_ttdb;
		CreateDataBinding(ref ojb, "tk_thue_ttdb");
		txtTk_thue_ttdb = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk_ck;
		CreateDataBinding(ref ojb, "tk_ck");
		txtTk_ck = (AsTextBox)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		if (!CheckExitsMaHTTT())
		{
			return false;
		}
		return (ChkEmtyTextBox(txtMa_httt) && ChkEmtyTextBox(txtTen_httt) && ChkEmtyTextBox((TextBox)(object)txtTK) && base.ValidData()) ? true : false;
	}

	protected override bool SetToRow()
	{
		bool result = base.SetToRow();
		RowToEdit["moduleid"] = MyMenuInfo.par1;
		return result;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_httt).Select();
		}
		return flag;
	}

	private bool CheckExitsMaHTTT()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		int num = 0;
		if (Conversions.ToInteger(Commons.ExecuteStoredProcedureScalar("afChkExistsCodeDict", new object[4]
		{
			CompanyInformations.CompanyID,
			"SIDMHTTT",
			"MA_HTTT",
			RuntimeHelpers.GetObjectValue(Helper.Repl_Null(txtMa_httt.Text, isNum: false))
		}.ToArray())) != 0)
		{
			result = false;
			CMessageBox.ShowWithFormat(50138, RuntimeHelpers.GetObjectValue(Helper.Repl_Null(txtMa_httt.Text, isNum: false)));
		}
		return result;
	}
}
