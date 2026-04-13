using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmINDMNHVTEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lbTen_Nhvt")]
	private Label _lbTen_Nhvt;

	[AccessedThroughProperty("lblMa_Nhvt")]
	private Label _lblMa_Nhvt;

	[AccessedThroughProperty("txtTen_NhVt")]
	private TextBox _txtTen_NhVt;

	[AccessedThroughProperty("txtMa_NhVt")]
	private TextBox _txtMa_NhVt;

	[AccessedThroughProperty("txtNhom_Me")]
	private AsTextBox _txtNhom_Me;

	[AccessedThroughProperty("lblTNhom_me")]
	private Label _lblTNhom_me;

	[AccessedThroughProperty("txtTk_Ck")]
	private AsTextBox _txtTk_Ck;

	[AccessedThroughProperty("lblTk_Ck")]
	private Label _lblTk_Ck;

	[AccessedThroughProperty("txtTk_Tl")]
	private AsTextBox _txtTk_Tl;

	[AccessedThroughProperty("lblTk_Tl")]
	private Label _lblTk_Tl;

	[AccessedThroughProperty("txtTk_Gv")]
	private AsTextBox _txtTk_Gv;

	[AccessedThroughProperty("lblTk_Gv")]
	private Label _lblTk_Gv;

	[AccessedThroughProperty("txtTk_DtNb")]
	private AsTextBox _txtTk_DtNb;

	[AccessedThroughProperty("lblTk_DtNb")]
	private Label _lblTk_DtNb;

	[AccessedThroughProperty("txtTk_Dt")]
	private AsTextBox _txtTk_Dt;

	[AccessedThroughProperty("lblTk_Dt")]
	private Label _lblTk_Dt;

	[AccessedThroughProperty("txtTk_Vt")]
	private AsTextBox _txtTk_Vt;

	[AccessedThroughProperty("lblTk_Vt")]
	private Label _lblTk_Vt;

	[AccessedThroughProperty("chkCong_Sl")]
	private AsCheckBox _chkCong_Sl;

	[AccessedThroughProperty("txtTen_Tk_Ck")]
	private Label _txtTen_Tk_Ck;

	[AccessedThroughProperty("txtTen_Tk_tl")]
	private Label _txtTen_Tk_tl;

	[AccessedThroughProperty("txtTen_Tk_gv")]
	private Label _txtTen_Tk_gv;

	[AccessedThroughProperty("txtTen_Tk_Dtnb")]
	private Label _txtTen_Tk_Dtnb;

	[AccessedThroughProperty("txtTen_Tk_Dt")]
	private Label _txtTen_Tk_Dt;

	[AccessedThroughProperty("txtTen_Tk_Vt")]
	private Label _txtTen_Tk_Vt;

	[AccessedThroughProperty("lblTen_Nhom_Me")]
	private Label _lblTen_Nhom_Me;

	[AccessedThroughProperty("txtCap")]
	private AsTextNumeric _txtCap;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	public static DataRow rowAdd;

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

	internal virtual TextBox txtTen_NhVt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_NhVt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_NhVt = value;
		}
	}

	internal virtual TextBox txtMa_NhVt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_NhVt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_NhVt = value;
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

	internal virtual AsTextBox txtTk_Ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Ck = value;
		}
	}

	internal virtual Label lblTk_Ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Ck = value;
		}
	}

	internal virtual AsTextBox txtTk_Tl
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Tl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Tl = value;
		}
	}

	internal virtual Label lblTk_Tl
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Tl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Tl = value;
		}
	}

	internal virtual AsTextBox txtTk_Gv
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Gv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Gv = value;
		}
	}

	internal virtual Label lblTk_Gv
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Gv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Gv = value;
		}
	}

	internal virtual AsTextBox txtTk_DtNb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_DtNb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_DtNb = value;
		}
	}

	internal virtual Label lblTk_DtNb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_DtNb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_DtNb = value;
		}
	}

	internal virtual AsTextBox txtTk_Dt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Dt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Dt = value;
		}
	}

	internal virtual Label lblTk_Dt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Dt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Dt = value;
		}
	}

	internal virtual AsTextBox txtTk_Vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Vt = value;
		}
	}

	internal virtual Label lblTk_Vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Vt = value;
		}
	}

	internal virtual AsCheckBox chkCong_Sl
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkCong_Sl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkCong_Sl = value;
		}
	}

	internal virtual Label txtTen_Tk_Ck
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Tk_Ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Tk_Ck = value;
		}
	}

	internal virtual Label txtTen_Tk_tl
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Tk_tl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Tk_tl = value;
		}
	}

	internal virtual Label txtTen_Tk_gv
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Tk_gv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Tk_gv = value;
		}
	}

	internal virtual Label txtTen_Tk_Dtnb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Tk_Dtnb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Tk_Dtnb = value;
		}
	}

	internal virtual Label txtTen_Tk_Dt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Tk_Dt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Tk_Dt = value;
		}
	}

	internal virtual Label txtTen_Tk_Vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Tk_Vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Tk_Vt = value;
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
	public frmINDMNHVTEdit()
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
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
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		lbTen_Nhvt = new Label();
		lblMa_Nhvt = new Label();
		txtTen_NhVt = new TextBox();
		txtMa_NhVt = new TextBox();
		txtNhom_Me = new AsTextBox();
		lblTNhom_me = new Label();
		chkCong_Sl = new AsCheckBox();
		txtTk_Vt = new AsTextBox();
		txtTen_Tk_Vt = new Label();
		lblTk_Vt = new Label();
		txtTk_Dt = new AsTextBox();
		txtTen_Tk_Dt = new Label();
		lblTk_Dt = new Label();
		txtTk_DtNb = new AsTextBox();
		txtTen_Tk_Dtnb = new Label();
		lblTk_DtNb = new Label();
		txtTk_Gv = new AsTextBox();
		txtTen_Tk_gv = new Label();
		lblTk_Gv = new Label();
		txtTk_Tl = new AsTextBox();
		txtTen_Tk_tl = new Label();
		lblTk_Tl = new Label();
		txtTk_Ck = new AsTextBox();
		txtTen_Tk_Ck = new Label();
		lblTk_Ck = new Label();
		lblTen_Nhom_Me = new Label();
		txtCap = new AsTextNumeric();
		Label1 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Anchor = (AnchorStyles)5;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(136, 276);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 10;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 315);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 315);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtCap);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Tk_Ck);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Tk_tl);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Tk_gv);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Tk_Dtnb);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Tk_Dt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Nhom_Me);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Tk_Vt);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Ck);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Ck);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Tl);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Tl);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Gv);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Gv);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_DtNb);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_DtNb);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Dt);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Dt);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Vt);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Vt);
		((Control)gbLine).Controls.Add((Control)(object)chkCong_Sl);
		((Control)gbLine).Controls.Add((Control)(object)txtNhom_Me);
		((Control)gbLine).Controls.Add((Control)(object)lblTNhom_me);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)lbTen_Nhvt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Nhvt);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_NhVt);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_NhVt);
		GroupBox obj3 = gbLine;
		Size size = new Size(507, 302);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_NhVt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_NhVt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Nhvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lbTen_Nhvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTNhom_me, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNhom_Me, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkCong_Sl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Dt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Dt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_DtNb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_DtNb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Gv, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Gv, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Tl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Tl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Tk_Vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Nhom_Me, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Tk_Dt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Tk_Dtnb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Tk_gv, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Tk_tl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Tk_Ck, 0);
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
		location = new Point(246, 257);
		((Control)obj6).Location = location;
		((Control)lblMa_Nhvt).Name = "lblMa_Nhvt";
		Label obj7 = lblMa_Nhvt;
		size = new Size(26, 13);
		((Control)obj7).Size = size;
		((Control)lblMa_Nhvt).TabIndex = 151;
		lblMa_Nhvt.Text = "Cấp";
		TextBox obj8 = txtTen_NhVt;
		location = new Point(136, 45);
		((Control)obj8).Location = location;
		((TextBoxBase)txtTen_NhVt).MaxLength = 50;
		((Control)txtTen_NhVt).Name = "txtTen_NhVt";
		TextBox obj9 = txtTen_NhVt;
		size = new Size(341, 20);
		((Control)obj9).Size = size;
		((Control)txtTen_NhVt).TabIndex = 1;
		txtMa_NhVt.CharacterCasing = (CharacterCasing)1;
		TextBox obj10 = txtMa_NhVt;
		location = new Point(136, 19);
		((Control)obj10).Location = location;
		((TextBoxBase)txtMa_NhVt).MaxLength = 20;
		((Control)txtMa_NhVt).Name = "txtMa_NhVt";
		TextBox obj11 = txtMa_NhVt;
		size = new Size(100, 20);
		((Control)obj11).Size = size;
		((Control)txtMa_NhVt).TabIndex = 0;
		txtNhom_Me.AutoLookup = true;
		txtNhom_Me.AutoValid = true;
		((TextBoxBase)txtNhom_Me).BackColor = SystemColors.Info;
		((TextBox)txtNhom_Me).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtNhom_Me;
		location = new Point(136, 71);
		((Control)asTextBox).Location = location;
		txtNhom_Me.LookupCodeName = "MA_NHVT";
		((Control)txtNhom_Me).Name = "txtNhom_Me";
		txtNhom_Me.NameControl = lblTen_Nhom_Me;
		txtNhom_Me.SD = true;
		AsTextBox asTextBox2 = txtNhom_Me;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtNhom_Me).TabIndex = 2;
		txtNhom_Me.UseAutoCompleteSource = true;
		txtNhom_Me.ValidReturnFieldList = "cap,ten_nhvt";
		lblTNhom_me.AutoSize = true;
		lblTNhom_me.ImeMode = (ImeMode)0;
		Label obj12 = lblTNhom_me;
		location = new Point(14, 75);
		((Control)obj12).Location = location;
		((Control)lblTNhom_me).Name = "lblTNhom_me";
		Label obj13 = lblTNhom_me;
		size = new Size(52, 13);
		((Control)obj13).Size = size;
		((Control)lblTNhom_me).TabIndex = 154;
		lblTNhom_me.Text = "Nhóm mẹ";
		lblTNhom_me.TextAlign = (ContentAlignment)16;
		((ButtonBase)chkCong_Sl).AutoSize = true;
		chkCong_Sl.Checked = false;
		AsCheckBox asCheckBox2 = chkCong_Sl;
		location = new Point(136, 253);
		((Control)asCheckBox2).Location = location;
		((Control)chkCong_Sl).Name = "chkCong_Sl";
		AsCheckBox asCheckBox3 = chkCong_Sl;
		size = new Size(94, 17);
		((Control)asCheckBox3).Size = size;
		((Control)chkCong_Sl).TabIndex = 9;
		((ButtonBase)chkCong_Sl).Text = "Cộng số lượng";
		chkCong_Sl.TextValue = "0";
		((ButtonBase)chkCong_Sl).UseVisualStyleBackColor = true;
		txtTk_Vt.AutoLookup = true;
		txtTk_Vt.AutoValid = true;
		((TextBoxBase)txtTk_Vt).BackColor = SystemColors.Info;
		((TextBox)txtTk_Vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk_Vt;
		location = new Point(136, 97);
		((Control)asTextBox3).Location = location;
		txtTk_Vt.LookupCodeName = "TK";
		txtTk_Vt.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Vt).Name = "txtTk_Vt";
		txtTk_Vt.NameControl = txtTen_Tk_Vt;
		txtTk_Vt.SD = true;
		AsTextBox asTextBox4 = txtTk_Vt;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk_Vt).TabIndex = 3;
		txtTk_Vt.UseAutoCompleteSource = true;
		txtTen_Tk_Vt.ImeMode = (ImeMode)0;
		Label obj14 = txtTen_Tk_Vt;
		location = new Point(242, 101);
		((Control)obj14).Location = location;
		((Control)txtTen_Tk_Vt).Name = "txtTen_Tk_Vt";
		Label obj15 = txtTen_Tk_Vt;
		size = new Size(305, 13);
		((Control)obj15).Size = size;
		((Control)txtTen_Tk_Vt).TabIndex = 217;
		txtTen_Tk_Vt.Text = "Tên TK vật tư";
		txtTen_Tk_Vt.TextAlign = (ContentAlignment)16;
		lblTk_Vt.AutoSize = true;
		lblTk_Vt.ImeMode = (ImeMode)0;
		Label obj16 = lblTk_Vt;
		location = new Point(14, 101);
		((Control)obj16).Location = location;
		((Control)lblTk_Vt).Name = "lblTk_Vt";
		Label obj17 = lblTk_Vt;
		size = new Size(85, 13);
		((Control)obj17).Size = size;
		((Control)lblTk_Vt).TabIndex = 157;
		lblTk_Vt.Text = "Tài khoản vật tư";
		lblTk_Vt.TextAlign = (ContentAlignment)16;
		txtTk_Dt.AutoLookup = true;
		txtTk_Dt.AutoValid = true;
		((TextBoxBase)txtTk_Dt).BackColor = SystemColors.Info;
		((TextBox)txtTk_Dt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTk_Dt;
		location = new Point(136, 123);
		((Control)asTextBox5).Location = location;
		txtTk_Dt.LookupCodeName = "TK";
		txtTk_Dt.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Dt).Name = "txtTk_Dt";
		txtTk_Dt.NameControl = txtTen_Tk_Dt;
		txtTk_Dt.SD = true;
		AsTextBox asTextBox6 = txtTk_Dt;
		size = new Size(100, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTk_Dt).TabIndex = 4;
		txtTk_Dt.UseAutoCompleteSource = true;
		txtTen_Tk_Dt.ImeMode = (ImeMode)0;
		Label obj18 = txtTen_Tk_Dt;
		location = new Point(242, 126);
		((Control)obj18).Location = location;
		((Control)txtTen_Tk_Dt).Name = "txtTen_Tk_Dt";
		Label obj19 = txtTen_Tk_Dt;
		size = new Size(325, 13);
		((Control)obj19).Size = size;
		((Control)txtTen_Tk_Dt).TabIndex = 218;
		txtTen_Tk_Dt.Text = "Tên TK doanh thu";
		txtTen_Tk_Dt.TextAlign = (ContentAlignment)16;
		lblTk_Dt.AutoSize = true;
		lblTk_Dt.ImeMode = (ImeMode)0;
		Label obj20 = lblTk_Dt;
		location = new Point(14, 127);
		((Control)obj20).Location = location;
		((Control)lblTk_Dt).Name = "lblTk_Dt";
		Label obj21 = lblTk_Dt;
		size = new Size(106, 13);
		((Control)obj21).Size = size;
		((Control)lblTk_Dt).TabIndex = 159;
		lblTk_Dt.Text = "Tài khoản doanh thu";
		lblTk_Dt.TextAlign = (ContentAlignment)16;
		txtTk_DtNb.AutoLookup = true;
		txtTk_DtNb.AutoValid = true;
		((TextBoxBase)txtTk_DtNb).BackColor = SystemColors.Info;
		((TextBox)txtTk_DtNb).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtTk_DtNb;
		location = new Point(136, 149);
		((Control)asTextBox7).Location = location;
		txtTk_DtNb.LookupCodeName = "TK";
		txtTk_DtNb.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_DtNb).Name = "txtTk_DtNb";
		txtTk_DtNb.NameControl = txtTen_Tk_Dtnb;
		txtTk_DtNb.SD = true;
		AsTextBox asTextBox8 = txtTk_DtNb;
		size = new Size(100, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtTk_DtNb).TabIndex = 5;
		txtTk_DtNb.UseAutoCompleteSource = true;
		txtTen_Tk_Dtnb.ImeMode = (ImeMode)0;
		Label obj22 = txtTen_Tk_Dtnb;
		location = new Point(242, 152);
		((Control)obj22).Location = location;
		((Control)txtTen_Tk_Dtnb).Name = "txtTen_Tk_Dtnb";
		Label obj23 = txtTen_Tk_Dtnb;
		size = new Size(325, 13);
		((Control)obj23).Size = size;
		((Control)txtTen_Tk_Dtnb).TabIndex = 219;
		txtTen_Tk_Dtnb.Text = "Tên TK DT nội bộ";
		txtTen_Tk_Dtnb.TextAlign = (ContentAlignment)16;
		lblTk_DtNb.AutoSize = true;
		lblTk_DtNb.ImeMode = (ImeMode)0;
		Label obj24 = lblTk_DtNb;
		location = new Point(14, 153);
		((Control)obj24).Location = location;
		((Control)lblTk_DtNb).Name = "lblTk_DtNb";
		Label obj25 = lblTk_DtNb;
		size = new Size(105, 13);
		((Control)obj25).Size = size;
		((Control)lblTk_DtNb).TabIndex = 161;
		lblTk_DtNb.Text = "Tài khoản DT nội bộ";
		lblTk_DtNb.TextAlign = (ContentAlignment)16;
		txtTk_Gv.AutoLookup = true;
		txtTk_Gv.AutoValid = true;
		((TextBoxBase)txtTk_Gv).BackColor = SystemColors.Info;
		((TextBox)txtTk_Gv).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtTk_Gv;
		location = new Point(136, 175);
		((Control)asTextBox9).Location = location;
		txtTk_Gv.LookupCodeName = "TK";
		txtTk_Gv.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Gv).Name = "txtTk_Gv";
		txtTk_Gv.NameControl = txtTen_Tk_gv;
		txtTk_Gv.SD = true;
		AsTextBox asTextBox10 = txtTk_Gv;
		size = new Size(100, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtTk_Gv).TabIndex = 6;
		txtTk_Gv.UseAutoCompleteSource = true;
		txtTen_Tk_gv.ImeMode = (ImeMode)0;
		Label obj26 = txtTen_Tk_gv;
		location = new Point(242, 178);
		((Control)obj26).Location = location;
		((Control)txtTen_Tk_gv).Name = "txtTen_Tk_gv";
		Label obj27 = txtTen_Tk_gv;
		size = new Size(325, 13);
		((Control)obj27).Size = size;
		((Control)txtTen_Tk_gv).TabIndex = 220;
		txtTen_Tk_gv.Text = "Tên TK giá vốn";
		txtTen_Tk_gv.TextAlign = (ContentAlignment)16;
		lblTk_Gv.AutoSize = true;
		lblTk_Gv.ImeMode = (ImeMode)0;
		Label obj28 = lblTk_Gv;
		location = new Point(14, 179);
		((Control)obj28).Location = location;
		((Control)lblTk_Gv).Name = "lblTk_Gv";
		Label obj29 = lblTk_Gv;
		size = new Size(93, 13);
		((Control)obj29).Size = size;
		((Control)lblTk_Gv).TabIndex = 163;
		lblTk_Gv.Text = "Tài khoản giá vốn";
		lblTk_Gv.TextAlign = (ContentAlignment)16;
		txtTk_Tl.AutoLookup = true;
		txtTk_Tl.AutoValid = true;
		((TextBoxBase)txtTk_Tl).BackColor = SystemColors.Info;
		((TextBox)txtTk_Tl).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtTk_Tl;
		location = new Point(136, 201);
		((Control)asTextBox11).Location = location;
		txtTk_Tl.LookupCodeName = "TK";
		txtTk_Tl.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Tl).Name = "txtTk_Tl";
		txtTk_Tl.NameControl = txtTen_Tk_tl;
		txtTk_Tl.SD = true;
		AsTextBox asTextBox12 = txtTk_Tl;
		size = new Size(100, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtTk_Tl).TabIndex = 7;
		txtTk_Tl.UseAutoCompleteSource = true;
		txtTen_Tk_tl.ImeMode = (ImeMode)0;
		Label obj30 = txtTen_Tk_tl;
		location = new Point(242, 204);
		((Control)obj30).Location = location;
		((Control)txtTen_Tk_tl).Name = "txtTen_Tk_tl";
		Label obj31 = txtTen_Tk_tl;
		size = new Size(325, 13);
		((Control)obj31).Size = size;
		((Control)txtTen_Tk_tl).TabIndex = 221;
		txtTen_Tk_tl.Text = "Tên TK trả lại";
		txtTen_Tk_tl.TextAlign = (ContentAlignment)16;
		lblTk_Tl.AutoSize = true;
		lblTk_Tl.ImeMode = (ImeMode)0;
		Label obj32 = lblTk_Tl;
		location = new Point(14, 205);
		((Control)obj32).Location = location;
		((Control)lblTk_Tl).Name = "lblTk_Tl";
		Label obj33 = lblTk_Tl;
		size = new Size(83, 13);
		((Control)obj33).Size = size;
		((Control)lblTk_Tl).TabIndex = 165;
		lblTk_Tl.Text = "Tài khoản trả lại";
		lblTk_Tl.TextAlign = (ContentAlignment)16;
		txtTk_Ck.AutoLookup = true;
		txtTk_Ck.AutoValid = true;
		((TextBoxBase)txtTk_Ck).BackColor = SystemColors.Info;
		((TextBox)txtTk_Ck).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox13 = txtTk_Ck;
		location = new Point(136, 227);
		((Control)asTextBox13).Location = location;
		txtTk_Ck.LookupCodeName = "TK";
		txtTk_Ck.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Ck).Name = "txtTk_Ck";
		txtTk_Ck.NameControl = txtTen_Tk_Ck;
		txtTk_Ck.SD = true;
		AsTextBox asTextBox14 = txtTk_Ck;
		size = new Size(100, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtTk_Ck).TabIndex = 8;
		txtTk_Ck.UseAutoCompleteSource = true;
		txtTen_Tk_Ck.ImeMode = (ImeMode)0;
		Label obj34 = txtTen_Tk_Ck;
		location = new Point(242, 230);
		((Control)obj34).Location = location;
		((Control)txtTen_Tk_Ck).Name = "txtTen_Tk_Ck";
		Label obj35 = txtTen_Tk_Ck;
		size = new Size(325, 13);
		((Control)obj35).Size = size;
		((Control)txtTen_Tk_Ck).TabIndex = 222;
		txtTen_Tk_Ck.Text = "Tên TK chiết khấu";
		txtTen_Tk_Ck.TextAlign = (ContentAlignment)16;
		lblTk_Ck.AutoSize = true;
		lblTk_Ck.ImeMode = (ImeMode)0;
		Label obj36 = lblTk_Ck;
		location = new Point(14, 231);
		((Control)obj36).Location = location;
		((Control)lblTk_Ck).Name = "lblTk_Ck";
		Label obj37 = lblTk_Ck;
		size = new Size(108, 13);
		((Control)obj37).Size = size;
		((Control)lblTk_Ck).TabIndex = 167;
		lblTk_Ck.Text = "Tài khoản chiết khấu";
		lblTk_Ck.TextAlign = (ContentAlignment)16;
		lblTen_Nhom_Me.ImeMode = (ImeMode)0;
		Label obj38 = lblTen_Nhom_Me;
		location = new Point(242, 74);
		((Control)obj38).Location = location;
		((Control)lblTen_Nhom_Me).Name = "lblTen_Nhom_Me";
		Label obj39 = lblTen_Nhom_Me;
		size = new Size(305, 13);
		((Control)obj39).Size = size;
		((Control)lblTen_Nhom_Me).TabIndex = 217;
		lblTen_Nhom_Me.TextAlign = (ContentAlignment)16;
		txtCap.DecimalSymbol = ".";
		((Control)txtCap).Enabled = false;
		txtCap.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtCap;
		location = new Point(276, 253);
		((Control)asTextNumeric).Location = location;
		txtCap.Mask = "### ### ### ###";
		((Control)txtCap).Name = "txtCap";
		AsTextNumeric asTextNumeric2 = txtCap;
		size = new Size(35, 20);
		((Control)asTextNumeric2).Size = size;
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
		size = new Size(529, 345);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmINDMNHVTEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_NhVt).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_NhVt).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_NhVt).Enabled = false;
		((Control)txtTen_NhVt).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_NhVt;
		CreateDataBinding(ref ojb, "Ma_NhVt");
		txtMa_NhVt = (TextBox)ojb;
		ojb = (Control)(object)txtTen_NhVt;
		CreateDataBinding(ref ojb, "Ten_NhVt");
		txtTen_NhVt = (TextBox)ojb;
		ojb = (Control)(object)txtNhom_Me;
		CreateDataBinding(ref ojb, "Nhom_Me");
		txtNhom_Me = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk_Ck;
		CreateDataBinding(ref ojb, "Tk_Ck");
		txtTk_Ck = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTen_Tk_Ck;
		CreateDataBinding(ref ojb, "Ten_Tk_Ck");
		txtTen_Tk_Ck = (Label)ojb;
		ojb = (Control)(object)txtTk_Dt;
		CreateDataBinding(ref ojb, "Tk_Dt");
		txtTk_Dt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTen_Tk_Dt;
		CreateDataBinding(ref ojb, "Ten_Tk_Dt");
		txtTen_Tk_Dt = (Label)ojb;
		ojb = (Control)(object)txtTk_DtNb;
		CreateDataBinding(ref ojb, "Tk_DtNb");
		txtTk_DtNb = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTen_Tk_Dtnb;
		CreateDataBinding(ref ojb, "Ten_Tk_DtNb");
		txtTen_Tk_Dtnb = (Label)ojb;
		ojb = (Control)(object)txtTk_Gv;
		CreateDataBinding(ref ojb, "Tk_Gv");
		txtTk_Gv = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTen_Tk_gv;
		CreateDataBinding(ref ojb, "Ten_Tk_Gv");
		txtTen_Tk_gv = (Label)ojb;
		ojb = (Control)(object)txtTk_Tl;
		CreateDataBinding(ref ojb, "Tk_Tl");
		txtTk_Tl = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTen_Tk_tl;
		CreateDataBinding(ref ojb, "Ten_Tk_tl");
		txtTen_Tk_tl = (Label)ojb;
		ojb = (Control)(object)txtTk_Vt;
		CreateDataBinding(ref ojb, "Tk_Vt");
		txtTk_Vt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTen_Tk_Vt;
		CreateDataBinding(ref ojb, "Ten_tk_vt");
		txtTen_Tk_Vt = (Label)ojb;
		ojb = (Control)(object)chkCong_Sl;
		CreateDataBinding(ref ojb, "Cong_Sl", "Checked");
		chkCong_Sl = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)txtCap;
		CreateDataBinding(ref ojb, "cap", "value");
		txtCap = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(txtMa_NhVt.Text, ((TextBox)txtNhom_Me).Text, false) == 0 && EditMode) ? true : false)
		{
			CMessageBox.Show(50034);
			((Control)txtNhom_Me).Focus();
			((Control)txtNhom_Me).Select();
			return false;
		}
		return (ChkEmtyTextBox(txtMa_NhVt) && ChkEmtyTextBox(txtTen_NhVt) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_NhVt).Select();
		}
		else
		{
			rowAdd = RowToEdit;
		}
		return flag;
	}

	protected override bool UpdateDB()
	{
		bool flag = base.UpdateDB();
		if (!flag)
		{
			((Control)txtMa_NhVt).Select();
		}
		else
		{
			rowAdd = RowToEdit;
		}
		return flag;
	}

	protected override bool SetToRow()
	{
		bool result = base.SetToRow();
		if (Operators.ConditionalCompareObjectGreater(txtCap.Value, (object)0, false))
		{
			RowToEdit["ten_nhvt_view"] = Strings.Space(Conversions.ToInteger(Operators.MultiplyObject(Operators.SubtractObject(txtCap.Value, (object)1), (object)3))) + txtTen_NhVt.Text.Trim();
		}
		return result;
	}

	private void txtNhom_Me_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (lblTen_Nhom_Me.Text.Length > 0)
		{
			lblTen_Nhom_Me.Text = Conversions.ToString(e.ValidatedRow["ten_nhvt"]);
			txtCap.Value = Operators.AddObject(e.ValidatedRow["cap"], (object)1);
		}
	}
}
