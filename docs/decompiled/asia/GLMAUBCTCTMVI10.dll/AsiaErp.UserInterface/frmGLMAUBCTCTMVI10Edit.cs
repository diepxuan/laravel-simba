using System;
using System.Collections;
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
public class frmGLMAUBCTCTMVI10Edit : frmDMComplexEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtCach_tinh")]
	private TextBox _txtCach_tinh;

	[AccessedThroughProperty("txtNd_chtieu")]
	private TextBox _txtNd_chtieu;

	[AccessedThroughProperty("txtChi_tieu")]
	private TextBox _txtChi_tieu;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("lblTK5")]
	private Label _lblTK5;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("txtTk5")]
	private AsTextBox _txtTk5;

	[AccessedThroughProperty("lblTK4")]
	private Label _lblTK4;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("txtTk4")]
	private AsTextBox _txtTk4;

	[AccessedThroughProperty("lblTK3")]
	private Label _lblTK3;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("txtTk3")]
	private AsTextBox _txtTk3;

	[AccessedThroughProperty("lblTK2")]
	private Label _lblTK2;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("txtTk2")]
	private AsTextBox _txtTk2;

	[AccessedThroughProperty("lblTK1")]
	private Label _lblTK1;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtTk1")]
	private AsTextBox _txtTk1;

	[AccessedThroughProperty("txtMa_chtieu")]
	private AsTextBox _txtMa_chtieu;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtMauQD")]
	private AsTextBox _txtMauQD;

	[AccessedThroughProperty("lblTK7")]
	private Label _lblTK7;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txtTk7")]
	private AsTextBox _txtTk7;

	[AccessedThroughProperty("lblTK6")]
	private Label _lblTK6;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("txtTk6")]
	private AsTextBox _txtTk6;

	[AccessedThroughProperty("ChkIs_italic")]
	private CheckBox _ChkIs_italic;

	[AccessedThroughProperty("ChkIs_print")]
	private CheckBox _ChkIs_print;

	[AccessedThroughProperty("cboLoai_ps")]
	private AsComboBox _cboLoai_ps;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	private static ArrayList oLoaiPS;

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

	internal virtual TextBox txtNd_chtieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNd_chtieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNd_chtieu = value;
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

	internal virtual Label lblTK5
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK5 = value;
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	internal virtual AsTextBox txtTk5
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk5 = value;
		}
	}

	internal virtual Label lblTK4
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK4 = value;
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual AsTextBox txtTk4
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk4 = value;
		}
	}

	internal virtual Label lblTK3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK3 = value;
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

	internal virtual AsTextBox txtTk3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk3 = value;
		}
	}

	internal virtual Label lblTK2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK2 = value;
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

	internal virtual AsTextBox txtTk2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk2 = value;
		}
	}

	internal virtual Label lblTK1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK1 = value;
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

	internal virtual AsTextBox txtTk1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk1 = value;
		}
	}

	internal virtual AsTextBox txtMa_chtieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_chtieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_chtieu = value;
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

	internal virtual AsTextBox txtMauQD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMauQD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMauQD = value;
		}
	}

	internal virtual Label lblTK7
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK7 = value;
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

	internal virtual AsTextBox txtTk7
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk7 = value;
		}
	}

	internal virtual Label lblTK6
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK6 = value;
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

	internal virtual AsTextBox txtTk6
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk6 = value;
		}
	}

	internal virtual CheckBox ChkIs_italic
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkIs_italic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkIs_italic = value;
		}
	}

	internal virtual CheckBox ChkIs_print
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkIs_print;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChkIs_print = value;
		}
	}

	internal virtual AsComboBox cboLoai_ps
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_ps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_ps = value;
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

	private static ArrayList LoaiPS
	{
		get
		{
			if (oLoaiPS == null)
			{
				oLoaiPS = new ArrayList();
				ArrayList arrayList = oLoaiPS;
				DictionaryEntry dictionaryEntry = new DictionaryEntry("", "");
				arrayList.Add(dictionaryEntry);
				ArrayList arrayList2 = oLoaiPS;
				dictionaryEntry = new DictionaryEntry("NODK", "Dư nợ đầu kỳ");
				arrayList2.Add(dictionaryEntry);
				ArrayList arrayList3 = oLoaiPS;
				dictionaryEntry = new DictionaryEntry("CODK", "Dư có đầu kỳ");
				arrayList3.Add(dictionaryEntry);
				ArrayList arrayList4 = oLoaiPS;
				dictionaryEntry = new DictionaryEntry("NOCK", "Dư nợ cuối kỳ");
				arrayList4.Add(dictionaryEntry);
				ArrayList arrayList5 = oLoaiPS;
				dictionaryEntry = new DictionaryEntry("COCK", "Dư có cuối kỳ");
				arrayList5.Add(dictionaryEntry);
				ArrayList arrayList6 = oLoaiPS;
				dictionaryEntry = new DictionaryEntry("PSNO", "Phát sinh nợ");
				arrayList6.Add(dictionaryEntry);
				ArrayList arrayList7 = oLoaiPS;
				dictionaryEntry = new DictionaryEntry("PSCO", "Phát sinh có");
				arrayList7.Add(dictionaryEntry);
			}
			return oLoaiPS;
		}
	}

	[DebuggerNonUserCode]
	public frmGLMAUBCTCTMVI10Edit()
	{
		((Form)this).Load += frmGLMAUBCTCTMVI10Edit_Load;
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		txtCach_tinh = new TextBox();
		txtNd_chtieu = new TextBox();
		txtChi_tieu = new TextBox();
		Label6 = new Label();
		Label4 = new Label();
		Label2 = new Label();
		lblTK5 = new Label();
		Label16 = new Label();
		txtTk5 = new AsTextBox();
		lblTK4 = new Label();
		Label14 = new Label();
		txtTk4 = new AsTextBox();
		lblTK3 = new Label();
		Label12 = new Label();
		txtTk3 = new AsTextBox();
		lblTK2 = new Label();
		Label10 = new Label();
		txtTk2 = new AsTextBox();
		lblTK1 = new Label();
		Label8 = new Label();
		txtTk1 = new AsTextBox();
		txtMa_chtieu = new AsTextBox();
		Label1 = new Label();
		txtMauQD = new AsTextBox();
		ChkIs_italic = new CheckBox();
		ChkIs_print = new CheckBox();
		lblTK7 = new Label();
		Label5 = new Label();
		txtTk7 = new AsTextBox();
		lblTK6 = new Label();
		Label11 = new Label();
		txtTk6 = new AsTextBox();
		cboLoai_ps = new AsComboBox();
		Label7 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(258, 376);
		((Control)asCheckBox).Location = location;
		AsCheckBox asCheckBox2 = chkKsd;
		Size size = new Size(59, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkKsd).TabIndex = 14;
		((Control)chkKsd).TabStop = true;
		((ButtonBase)chkKsd).Text = "In đậm";
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 413);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 413);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)cboLoai_ps);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)lblTK7);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)txtTk7);
		((Control)gbLine).Controls.Add((Control)(object)lblTK6);
		((Control)gbLine).Controls.Add((Control)(object)Label11);
		((Control)gbLine).Controls.Add((Control)(object)txtTk6);
		((Control)gbLine).Controls.Add((Control)(object)ChkIs_italic);
		((Control)gbLine).Controls.Add((Control)(object)ChkIs_print);
		((Control)gbLine).Controls.Add((Control)(object)txtCach_tinh);
		((Control)gbLine).Controls.Add((Control)(object)txtNd_chtieu);
		((Control)gbLine).Controls.Add((Control)(object)txtChi_tieu);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)lblTK5);
		((Control)gbLine).Controls.Add((Control)(object)Label16);
		((Control)gbLine).Controls.Add((Control)(object)txtTk5);
		((Control)gbLine).Controls.Add((Control)(object)lblTK4);
		((Control)gbLine).Controls.Add((Control)(object)Label14);
		((Control)gbLine).Controls.Add((Control)(object)txtTk4);
		((Control)gbLine).Controls.Add((Control)(object)lblTK3);
		((Control)gbLine).Controls.Add((Control)(object)Label12);
		((Control)gbLine).Controls.Add((Control)(object)txtTk3);
		((Control)gbLine).Controls.Add((Control)(object)lblTK2);
		((Control)gbLine).Controls.Add((Control)(object)Label10);
		((Control)gbLine).Controls.Add((Control)(object)txtTk2);
		((Control)gbLine).Controls.Add((Control)(object)lblTK1);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)txtTk1);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_chtieu);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		GroupBox obj3 = gbLine;
		size = new Size(623, 401);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_chtieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label10, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label12, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label14, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label16, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtChi_tieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNd_chtieu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtCach_tinh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)ChkIs_print, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)ChkIs_italic, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label11, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai_ps, 0);
		TextBox obj4 = txtCach_tinh;
		location = new Point(120, 142);
		((Control)obj4).Location = location;
		((TextBoxBase)txtCach_tinh).MaxLength = 50;
		((Control)txtCach_tinh).Name = "txtCach_tinh";
		TextBox obj5 = txtCach_tinh;
		size = new Size(484, 20);
		((Control)obj5).Size = size;
		((Control)txtCach_tinh).TabIndex = 3;
		TextBox obj6 = txtNd_chtieu;
		location = new Point(120, 70);
		((Control)obj6).Location = location;
		txtNd_chtieu.Multiline = true;
		((Control)txtNd_chtieu).Name = "txtNd_chtieu";
		txtNd_chtieu.ScrollBars = (ScrollBars)2;
		TextBox obj7 = txtNd_chtieu;
		size = new Size(484, 66);
		((Control)obj7).Size = size;
		((Control)txtNd_chtieu).TabIndex = 2;
		TextBox obj8 = txtChi_tieu;
		location = new Point(120, 43);
		((Control)obj8).Location = location;
		((Control)txtChi_tieu).Name = "txtChi_tieu";
		TextBox obj9 = txtChi_tieu;
		size = new Size(484, 20);
		((Control)obj9).Size = size;
		((Control)txtChi_tieu).TabIndex = 1;
		Label6.AutoSize = true;
		Label label = Label6;
		location = new Point(15, 146);
		((Control)label).Location = location;
		((Control)Label6).Name = "Label6";
		Label label2 = Label6;
		size = new Size(56, 13);
		((Control)label2).Size = size;
		((Control)Label6).TabIndex = 227;
		Label6.Text = "Công thức";
		Label4.AutoSize = true;
		Label label3 = Label4;
		location = new Point(15, 70);
		((Control)label3).Location = location;
		((Control)Label4).Name = "Label4";
		Label label4 = Label4;
		size = new Size(87, 13);
		((Control)label4).Size = size;
		((Control)Label4).TabIndex = 225;
		Label4.Text = "Nội dung chỉ tiêu";
		Label2.AutoSize = true;
		Label label5 = Label2;
		location = new Point(15, 47);
		((Control)label5).Location = location;
		((Control)Label2).Name = "Label2";
		Label label6 = Label2;
		size = new Size(42, 13);
		((Control)label6).Size = size;
		((Control)Label2).TabIndex = 223;
		Label2.Text = "Chỉ tiêu";
		Label obj10 = lblTK5;
		location = new Point(185, 271);
		((Control)obj10).Location = location;
		((Control)lblTK5).Name = "lblTK5";
		Label obj11 = lblTK5;
		size = new Size(419, 20);
		((Control)obj11).Size = size;
		((Control)lblTK5).TabIndex = 222;
		lblTK5.TextAlign = (ContentAlignment)16;
		Label16.AutoSize = true;
		Label label7 = Label16;
		location = new Point(15, 275);
		((Control)label7).Location = location;
		((Control)Label16).Name = "Label16";
		Label label8 = Label16;
		size = new Size(64, 13);
		((Control)label8).Size = size;
		((Control)Label16).TabIndex = 221;
		Label16.Text = "Tài khoản 5";
		txtTk5.AutoLookup = true;
		txtTk5.AutoValid = true;
		((TextBoxBase)txtTk5).BackColor = SystemColors.Info;
		((TextBox)txtTk5).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTk5;
		location = new Point(120, 271);
		((Control)asTextBox).Location = location;
		txtTk5.LookupCodeName = "TK";
		((Control)txtTk5).Name = "txtTk5";
		txtTk5.NameControl = lblTK5;
		AsTextBox asTextBox2 = txtTk5;
		size = new Size(59, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTk5).TabIndex = 8;
		txtTk5.UseAutoCompleteSource = true;
		Label obj12 = lblTK4;
		location = new Point(185, 246);
		((Control)obj12).Location = location;
		((Control)lblTK4).Name = "lblTK4";
		Label obj13 = lblTK4;
		size = new Size(419, 20);
		((Control)obj13).Size = size;
		((Control)lblTK4).TabIndex = 219;
		lblTK4.TextAlign = (ContentAlignment)16;
		Label14.AutoSize = true;
		Label label9 = Label14;
		location = new Point(15, 250);
		((Control)label9).Location = location;
		((Control)Label14).Name = "Label14";
		Label label10 = Label14;
		size = new Size(64, 13);
		((Control)label10).Size = size;
		((Control)Label14).TabIndex = 218;
		Label14.Text = "Tài khoản 4";
		txtTk4.AutoLookup = true;
		txtTk4.AutoValid = true;
		((TextBoxBase)txtTk4).BackColor = SystemColors.Info;
		((TextBox)txtTk4).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk4;
		location = new Point(120, 246);
		((Control)asTextBox3).Location = location;
		txtTk4.LookupCodeName = "TK";
		((Control)txtTk4).Name = "txtTk4";
		txtTk4.NameControl = lblTK4;
		AsTextBox asTextBox4 = txtTk4;
		size = new Size(59, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk4).TabIndex = 7;
		txtTk4.UseAutoCompleteSource = true;
		Label obj14 = lblTK3;
		location = new Point(185, 220);
		((Control)obj14).Location = location;
		((Control)lblTK3).Name = "lblTK3";
		Label obj15 = lblTK3;
		size = new Size(419, 20);
		((Control)obj15).Size = size;
		((Control)lblTK3).TabIndex = 216;
		lblTK3.TextAlign = (ContentAlignment)16;
		Label12.AutoSize = true;
		Label label11 = Label12;
		location = new Point(15, 224);
		((Control)label11).Location = location;
		((Control)Label12).Name = "Label12";
		Label label12 = Label12;
		size = new Size(64, 13);
		((Control)label12).Size = size;
		((Control)Label12).TabIndex = 215;
		Label12.Text = "Tài khoản 3";
		txtTk3.AutoLookup = true;
		txtTk3.AutoValid = true;
		((TextBoxBase)txtTk3).BackColor = SystemColors.Info;
		((TextBox)txtTk3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTk3;
		location = new Point(120, 220);
		((Control)asTextBox5).Location = location;
		txtTk3.LookupCodeName = "TK";
		((Control)txtTk3).Name = "txtTk3";
		txtTk3.NameControl = lblTK3;
		AsTextBox asTextBox6 = txtTk3;
		size = new Size(59, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTk3).TabIndex = 6;
		txtTk3.UseAutoCompleteSource = true;
		Label obj16 = lblTK2;
		location = new Point(185, 194);
		((Control)obj16).Location = location;
		((Control)lblTK2).Name = "lblTK2";
		Label obj17 = lblTK2;
		size = new Size(419, 20);
		((Control)obj17).Size = size;
		((Control)lblTK2).TabIndex = 213;
		lblTK2.TextAlign = (ContentAlignment)16;
		Label10.AutoSize = true;
		Label label13 = Label10;
		location = new Point(15, 198);
		((Control)label13).Location = location;
		((Control)Label10).Name = "Label10";
		Label label14 = Label10;
		size = new Size(64, 13);
		((Control)label14).Size = size;
		((Control)Label10).TabIndex = 212;
		Label10.Text = "Tài khoản 2";
		txtTk2.AutoLookup = true;
		txtTk2.AutoValid = true;
		((TextBoxBase)txtTk2).BackColor = SystemColors.Info;
		((TextBox)txtTk2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtTk2;
		location = new Point(120, 194);
		((Control)asTextBox7).Location = location;
		txtTk2.LookupCodeName = "TK";
		((Control)txtTk2).Name = "txtTk2";
		txtTk2.NameControl = lblTK2;
		AsTextBox asTextBox8 = txtTk2;
		size = new Size(59, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtTk2).TabIndex = 5;
		txtTk2.UseAutoCompleteSource = true;
		Label obj18 = lblTK1;
		location = new Point(185, 168);
		((Control)obj18).Location = location;
		((Control)lblTK1).Name = "lblTK1";
		Label obj19 = lblTK1;
		size = new Size(419, 20);
		((Control)obj19).Size = size;
		((Control)lblTK1).TabIndex = 210;
		lblTK1.TextAlign = (ContentAlignment)16;
		Label8.AutoSize = true;
		Label label15 = Label8;
		location = new Point(15, 172);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(64, 13);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 209;
		Label8.Text = "Tài khoản 1";
		txtTk1.AutoLookup = true;
		txtTk1.AutoValid = true;
		((TextBoxBase)txtTk1).BackColor = SystemColors.Info;
		((TextBox)txtTk1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtTk1;
		location = new Point(120, 168);
		((Control)asTextBox9).Location = location;
		txtTk1.LookupCodeName = "TK";
		((Control)txtTk1).Name = "txtTk1";
		txtTk1.NameControl = lblTK1;
		AsTextBox asTextBox10 = txtTk1;
		size = new Size(59, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtTk1).TabIndex = 4;
		txtTk1.UseAutoCompleteSource = true;
		txtMa_chtieu.AutoLookup = false;
		txtMa_chtieu.AutoValid = false;
		((TextBoxBase)txtMa_chtieu).BackColor = SystemColors.Window;
		((TextBox)txtMa_chtieu).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtMa_chtieu;
		location = new Point(120, 16);
		((Control)asTextBox11).Location = location;
		txtMa_chtieu.LookupCodeName = "";
		((Control)txtMa_chtieu).Name = "txtMa_chtieu";
		txtMa_chtieu.NameControl = null;
		AsTextBox asTextBox12 = txtMa_chtieu;
		size = new Size(59, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtMa_chtieu).TabIndex = 0;
		txtMa_chtieu.UseAutoCompleteSource = true;
		Label1.AutoSize = true;
		Label label17 = Label1;
		location = new Point(15, 20);
		((Control)label17).Location = location;
		((Control)Label1).Name = "Label1";
		Label label18 = Label1;
		size = new Size(59, 13);
		((Control)label18).Size = size;
		((Control)Label1).TabIndex = 200;
		Label1.Text = "Mã chỉ tiêu";
		txtMauQD.AutoLookup = false;
		txtMauQD.AutoValid = false;
		((TextBoxBase)txtMauQD).BackColor = SystemColors.Window;
		((TextBox)txtMauQD).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox13 = txtMauQD;
		location = new Point(557, 25);
		((Control)asTextBox13).Location = location;
		txtMauQD.LookupCodeName = "";
		((Control)txtMauQD).Name = "txtMauQD";
		txtMauQD.NameControl = null;
		AsTextBox asTextBox14 = txtMauQD;
		size = new Size(59, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtMauQD).TabIndex = 202;
		txtMauQD.UseAutoCompleteSource = true;
		((ButtonBase)ChkIs_italic).AutoSize = true;
		CheckBox chkIs_italic = ChkIs_italic;
		location = new Point(176, 376);
		((Control)chkIs_italic).Location = location;
		((Control)ChkIs_italic).Name = "ChkIs_italic";
		CheckBox chkIs_italic2 = ChkIs_italic;
		size = new Size(76, 17);
		((Control)chkIs_italic2).Size = size;
		((Control)ChkIs_italic).TabIndex = 13;
		((ButtonBase)ChkIs_italic).Text = "In nghiêng";
		((ButtonBase)ChkIs_italic).UseVisualStyleBackColor = true;
		((ButtonBase)ChkIs_print).AutoSize = true;
		CheckBox chkIs_print = ChkIs_print;
		location = new Point(120, 376);
		((Control)chkIs_print).Location = location;
		((Control)ChkIs_print).Name = "ChkIs_print";
		CheckBox chkIs_print2 = ChkIs_print;
		size = new Size(50, 17);
		((Control)chkIs_print2).Size = size;
		((Control)ChkIs_print).TabIndex = 12;
		((ButtonBase)ChkIs_print).Text = "Có in";
		((ButtonBase)ChkIs_print).UseVisualStyleBackColor = true;
		Label obj20 = lblTK7;
		location = new Point(185, 322);
		((Control)obj20).Location = location;
		((Control)lblTK7).Name = "lblTK7";
		Label obj21 = lblTK7;
		size = new Size(419, 20);
		((Control)obj21).Size = size;
		((Control)lblTK7).TabIndex = 237;
		lblTK7.TextAlign = (ContentAlignment)16;
		Label5.AutoSize = true;
		Label label19 = Label5;
		location = new Point(15, 326);
		((Control)label19).Location = location;
		((Control)Label5).Name = "Label5";
		Label label20 = Label5;
		size = new Size(64, 13);
		((Control)label20).Size = size;
		((Control)Label5).TabIndex = 236;
		Label5.Text = "Tài khoản 7";
		txtTk7.AutoLookup = true;
		txtTk7.AutoValid = true;
		((TextBoxBase)txtTk7).BackColor = SystemColors.Info;
		((TextBox)txtTk7).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox15 = txtTk7;
		location = new Point(120, 322);
		((Control)asTextBox15).Location = location;
		txtTk7.LookupCodeName = "TK";
		((Control)txtTk7).Name = "txtTk7";
		txtTk7.NameControl = lblTK7;
		AsTextBox asTextBox16 = txtTk7;
		size = new Size(59, 20);
		((Control)asTextBox16).Size = size;
		((Control)txtTk7).TabIndex = 10;
		txtTk7.UseAutoCompleteSource = true;
		Label obj22 = lblTK6;
		location = new Point(185, 297);
		((Control)obj22).Location = location;
		((Control)lblTK6).Name = "lblTK6";
		Label obj23 = lblTK6;
		size = new Size(419, 20);
		((Control)obj23).Size = size;
		((Control)lblTK6).TabIndex = 235;
		lblTK6.TextAlign = (ContentAlignment)16;
		Label11.AutoSize = true;
		Label label21 = Label11;
		location = new Point(15, 301);
		((Control)label21).Location = location;
		((Control)Label11).Name = "Label11";
		Label label22 = Label11;
		size = new Size(64, 13);
		((Control)label22).Size = size;
		((Control)Label11).TabIndex = 234;
		Label11.Text = "Tài khoản 6\r\n";
		txtTk6.AutoLookup = true;
		txtTk6.AutoValid = true;
		((TextBoxBase)txtTk6).BackColor = SystemColors.Info;
		((TextBox)txtTk6).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox17 = txtTk6;
		location = new Point(120, 297);
		((Control)asTextBox17).Location = location;
		txtTk6.LookupCodeName = "TK";
		((Control)txtTk6).Name = "txtTk6";
		txtTk6.NameControl = lblTK6;
		AsTextBox asTextBox18 = txtTk6;
		size = new Size(59, 20);
		((Control)asTextBox18).Size = size;
		((Control)txtTk6).TabIndex = 9;
		txtTk6.UseAutoCompleteSource = true;
		((ComboBox)cboLoai_ps).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_ps).FormattingEnabled = true;
		AsComboBox asComboBox = cboLoai_ps;
		location = new Point(120, 348);
		((Control)asComboBox).Location = location;
		((Control)cboLoai_ps).Name = "cboLoai_ps";
		AsComboBox asComboBox2 = cboLoai_ps;
		size = new Size(197, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboLoai_ps).TabIndex = 11;
		Label7.AutoSize = true;
		Label label23 = Label7;
		location = new Point(15, 352);
		((Control)label23).Location = location;
		((Control)Label7).Name = "Label7";
		Label label24 = Label7;
		size = new Size(73, 13);
		((Control)label24).Size = size;
		((Control)Label7).TabIndex = 239;
		Label7.Text = "Loại phát sinh";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(647, 448);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtMauQD);
		((Control)this).Name = "frmGLMAUBCTCTMV10Edit";
		((Control)this).Controls.SetChildIndex((Control)(object)txtMauQD, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbLine, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSave, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((ComboBox)cboLoai_ps).DataSource = LoaiPS;
		((ListControl)cboLoai_ps).ValueMember = "Key";
		((ListControl)cboLoai_ps).DisplayMember = "Value";
		((ComboBox)cboLoai_ps).SelectedIndex = -1;
		((TextBoxBase)txtMa_chtieu).MaxLength = base.MyDictComplexInfo.code_length;
		((Control)txtMa_chtieu).Select();
	}

	protected override bool ValidData()
	{
		txtNd_chtieu.Text = txtNd_chtieu.Text.Trim();
		if (Operators.CompareString(((TextBox)txtMauQD).Text.Trim(), "", false) == 0)
		{
			((TextBox)txtMauQD).Text = CompanyInformations.Qd_cdkt;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_chtieu))
		{
			epNotice.SetError((Control)(object)txtMa_chtieu, Helper.GetMess(50002).Description);
			((Control)txtMa_chtieu).Select();
			return false;
		}
		if (!ChkEmtyTextBox(txtChi_tieu))
		{
			epNotice.SetError((Control)(object)txtChi_tieu, Helper.GetMess(50002).Description);
			((Control)txtChi_tieu).Select();
			return false;
		}
		return base.ValidData();
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_chtieu).Select();
		}
		return flag;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMauQD).Enabled = false;
		((Control)txtMa_chtieu).Enabled = false;
		((Control)txtChi_tieu).Select();
	}

	protected override void DataBinding()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMauQD;
		CreateDataBinding(ref ojb, "mau");
		txtMauQD = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_chtieu;
		CreateDataBinding(ref ojb, "ma_so");
		txtMa_chtieu = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtChi_tieu;
		CreateDataBinding(ref ojb, "chi_tieu");
		txtChi_tieu = (TextBox)ojb;
		ojb = (Control)(object)txtNd_chtieu;
		CreateDataBinding(ref ojb, "nd_chtieu");
		txtNd_chtieu = (TextBox)ojb;
		ojb = (Control)(object)txtCach_tinh;
		CreateDataBinding(ref ojb, "cach_tinh");
		txtCach_tinh = (TextBox)ojb;
		ojb = (Control)(object)cboLoai_ps;
		CreateDataBinding(ref ojb, "loai_ps", "SelectedValue");
		cboLoai_ps = (AsComboBox)(object)ojb;
		ojb = (Control)(object)txtTk1;
		CreateDataBinding(ref ojb, "tk_01");
		txtTk1 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk2;
		CreateDataBinding(ref ojb, "tk_02");
		txtTk2 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk3;
		CreateDataBinding(ref ojb, "tk_03");
		txtTk3 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk4;
		CreateDataBinding(ref ojb, "tk_04");
		txtTk4 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk5;
		CreateDataBinding(ref ojb, "tk_05");
		txtTk5 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk6;
		CreateDataBinding(ref ojb, "tk_06");
		txtTk6 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk7;
		CreateDataBinding(ref ojb, "tk_07");
		txtTk7 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)ChkIs_italic;
		CreateDataBinding(ref ojb, "IsItalic", "Checked");
		ChkIs_italic = (CheckBox)ojb;
		ojb = (Control)(object)ChkIs_print;
		CreateDataBinding(ref ojb, "IsPrint", "Checked");
		ChkIs_print = (CheckBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "bold", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	private void frmGLMAUBCTCTMVI10Edit_Load(object sender, EventArgs e)
	{
		if (!EditMode)
		{
			ChkIs_print.Checked = true;
		}
	}

	protected override bool ProcessKeyPreview(ref Message m)
	{
		if (!((Control)txtNd_chtieu).Focused)
		{
			return base.ProcessKeyPreview(ref m);
		}
		bool result = default(bool);
		return result;
	}
}
