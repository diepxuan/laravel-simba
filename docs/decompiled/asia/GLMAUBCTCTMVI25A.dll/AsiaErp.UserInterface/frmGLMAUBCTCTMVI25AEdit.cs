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
public class frmGLMAUBCTCTMVI25AEdit : frmDMComplexEdit
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

	[AccessedThroughProperty("lblTK9")]
	private Label _lblTK9;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("txtTk9")]
	private AsTextBox _txtTk9;

	[AccessedThroughProperty("lblTK8")]
	private Label _lblTK8;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("txtTk8")]
	private AsTextBox _txtTk8;

	[AccessedThroughProperty("lblTK7")]
	private Label _lblTK7;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("txtTk7")]
	private AsTextBox _txtTk7;

	[AccessedThroughProperty("lblTK6")]
	private Label _lblTK6;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("txtTk6")]
	private AsTextBox _txtTk6;

	[AccessedThroughProperty("txtMauQD")]
	private TextBox _txtMauQD;

	[AccessedThroughProperty("ChkIs_italic")]
	private CheckBox _ChkIs_italic;

	[AccessedThroughProperty("ChkIs_print")]
	private CheckBox _ChkIs_print;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txtTk12")]
	private AsTextBox _txtTk12;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("txtTk11")]
	private AsTextBox _txtTk11;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("txtTk10")]
	private AsTextBox _txtTk10;

	[AccessedThroughProperty("cboLoai_ps")]
	private AsComboBox _cboLoai_ps;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("cboNam_ps")]
	private AsComboBox _cboNam_ps;

	private static ArrayList oLoaiPS;

	private static ArrayList oNamPS;

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

	internal virtual Label lblTK9
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK9 = value;
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual AsTextBox txtTk9
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk9 = value;
		}
	}

	internal virtual Label lblTK8
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK8 = value;
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	internal virtual AsTextBox txtTk8
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk8 = value;
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

	internal virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
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

	internal virtual Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label21 = value;
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

	internal virtual TextBox txtMauQD
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

	internal virtual AsTextBox txtTk12
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk12 = value;
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

	internal virtual AsTextBox txtTk11
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk11 = value;
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
		}
	}

	internal virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label18 = value;
		}
	}

	internal virtual AsTextBox txtTk10
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk10 = value;
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

	internal virtual AsComboBox cboNam_ps
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNam_ps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboNam_ps = value;
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

	private static ArrayList NamPS
	{
		get
		{
			if (oNamPS == null)
			{
				oNamPS = new ArrayList();
				ArrayList arrayList = oNamPS;
				DictionaryEntry dictionaryEntry = new DictionaryEntry("NT", "Năm trước");
				arrayList.Add(dictionaryEntry);
				ArrayList arrayList2 = oNamPS;
				dictionaryEntry = new DictionaryEntry("NN", "Năm nay");
				arrayList2.Add(dictionaryEntry);
			}
			return oNamPS;
		}
	}

	[DebuggerNonUserCode]
	public frmGLMAUBCTCTMVI25AEdit()
	{
		((Form)this).Load += frmGLMAUBCTCTMVI25AEdit_Load;
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
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
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
		lblTK9 = new Label();
		Label13 = new Label();
		txtTk9 = new AsTextBox();
		lblTK8 = new Label();
		Label17 = new Label();
		txtTk8 = new AsTextBox();
		lblTK7 = new Label();
		Label19 = new Label();
		txtTk7 = new AsTextBox();
		lblTK6 = new Label();
		Label21 = new Label();
		txtTk6 = new AsTextBox();
		txtMauQD = new TextBox();
		ChkIs_italic = new CheckBox();
		ChkIs_print = new CheckBox();
		Label3 = new Label();
		Label5 = new Label();
		txtTk12 = new AsTextBox();
		Label9 = new Label();
		Label11 = new Label();
		txtTk11 = new AsTextBox();
		Label15 = new Label();
		Label18 = new Label();
		txtTk10 = new AsTextBox();
		cboLoai_ps = new AsComboBox();
		Label7 = new Label();
		cboNam_ps = new AsComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(256, 350);
		((Control)asCheckBox).Location = location;
		AsCheckBox asCheckBox2 = chkKsd;
		Size size = new Size(59, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkKsd).TabIndex = 20;
		((Control)chkKsd).TabStop = true;
		((ButtonBase)chkKsd).Text = "In đậm";
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 389);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 389);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)cboNam_ps);
		((Control)gbLine).Controls.Add((Control)(object)cboLoai_ps);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)txtTk12);
		((Control)gbLine).Controls.Add((Control)(object)Label9);
		((Control)gbLine).Controls.Add((Control)(object)Label11);
		((Control)gbLine).Controls.Add((Control)(object)txtTk11);
		((Control)gbLine).Controls.Add((Control)(object)Label15);
		((Control)gbLine).Controls.Add((Control)(object)Label18);
		((Control)gbLine).Controls.Add((Control)(object)txtTk10);
		((Control)gbLine).Controls.Add((Control)(object)ChkIs_italic);
		((Control)gbLine).Controls.Add((Control)(object)ChkIs_print);
		((Control)gbLine).Controls.Add((Control)(object)lblTK9);
		((Control)gbLine).Controls.Add((Control)(object)Label13);
		((Control)gbLine).Controls.Add((Control)(object)txtTk9);
		((Control)gbLine).Controls.Add((Control)(object)lblTK8);
		((Control)gbLine).Controls.Add((Control)(object)Label17);
		((Control)gbLine).Controls.Add((Control)(object)txtTk8);
		((Control)gbLine).Controls.Add((Control)(object)lblTK7);
		((Control)gbLine).Controls.Add((Control)(object)Label19);
		((Control)gbLine).Controls.Add((Control)(object)txtTk7);
		((Control)gbLine).Controls.Add((Control)(object)lblTK6);
		((Control)gbLine).Controls.Add((Control)(object)Label21);
		((Control)gbLine).Controls.Add((Control)(object)txtTk6);
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
		size = new Size(841, 377);
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
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label21, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label19, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label17, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk9, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label13, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK9, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)ChkIs_print, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)ChkIs_italic, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk10, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label18, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label15, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk11, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label11, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label9, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk12, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai_ps, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboNam_ps, 0);
		TextBox obj4 = txtCach_tinh;
		location = new Point(117, 140);
		((Control)obj4).Location = location;
		((TextBoxBase)txtCach_tinh).MaxLength = 50;
		((Control)txtCach_tinh).Name = "txtCach_tinh";
		TextBox obj5 = txtCach_tinh;
		size = new Size(705, 20);
		((Control)obj5).Size = size;
		((Control)txtCach_tinh).TabIndex = 3;
		TextBox obj6 = txtNd_chtieu;
		location = new Point(117, 73);
		((Control)obj6).Location = location;
		txtNd_chtieu.Multiline = true;
		((Control)txtNd_chtieu).Name = "txtNd_chtieu";
		txtNd_chtieu.ScrollBars = (ScrollBars)2;
		TextBox obj7 = txtNd_chtieu;
		size = new Size(705, 61);
		((Control)obj7).Size = size;
		((Control)txtNd_chtieu).TabIndex = 2;
		TextBox obj8 = txtChi_tieu;
		location = new Point(117, 46);
		((Control)obj8).Location = location;
		((Control)txtChi_tieu).Name = "txtChi_tieu";
		TextBox obj9 = txtChi_tieu;
		size = new Size(705, 20);
		((Control)obj9).Size = size;
		((Control)txtChi_tieu).TabIndex = 1;
		Label6.AutoSize = true;
		Label label = Label6;
		location = new Point(12, 144);
		((Control)label).Location = location;
		((Control)Label6).Name = "Label6";
		Label label2 = Label6;
		size = new Size(56, 13);
		((Control)label2).Size = size;
		((Control)Label6).TabIndex = 256;
		Label6.Text = "Công thức";
		Label4.AutoSize = true;
		Label label3 = Label4;
		location = new Point(12, 73);
		((Control)label3).Location = location;
		((Control)Label4).Name = "Label4";
		Label label4 = Label4;
		size = new Size(87, 13);
		((Control)label4).Size = size;
		((Control)Label4).TabIndex = 254;
		Label4.Text = "Nội dung chỉ tiêu";
		Label2.AutoSize = true;
		Label label5 = Label2;
		location = new Point(12, 50);
		((Control)label5).Location = location;
		((Control)Label2).Name = "Label2";
		Label label6 = Label2;
		size = new Size(42, 13);
		((Control)label6).Size = size;
		((Control)Label2).TabIndex = 252;
		Label2.Text = "Chỉ tiêu";
		Label obj10 = lblTK5;
		location = new Point(206, 268);
		((Control)obj10).Location = location;
		((Control)lblTK5).Name = "lblTK5";
		Label obj11 = lblTK5;
		size = new Size(200, 20);
		((Control)obj11).Size = size;
		((Control)lblTK5).TabIndex = 251;
		lblTK5.TextAlign = (ContentAlignment)16;
		Label16.AutoSize = true;
		Label label7 = Label16;
		location = new Point(12, 272);
		((Control)label7).Location = location;
		((Control)Label16).Name = "Label16";
		Label label8 = Label16;
		size = new Size(64, 13);
		((Control)label8).Size = size;
		((Control)Label16).TabIndex = 250;
		Label16.Text = "Tài khoản 5";
		txtTk5.AutoLookup = true;
		txtTk5.AutoValid = true;
		((TextBoxBase)txtTk5).BackColor = SystemColors.Info;
		((TextBox)txtTk5).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTk5;
		location = new Point(117, 268);
		((Control)asTextBox).Location = location;
		txtTk5.LookupCodeName = "TK";
		((Control)txtTk5).Name = "txtTk5";
		txtTk5.NameControl = lblTK5;
		AsTextBox asTextBox2 = txtTk5;
		size = new Size(73, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTk5).TabIndex = 8;
		txtTk5.UseAutoCompleteSource = true;
		Label obj12 = lblTK4;
		location = new Point(206, 242);
		((Control)obj12).Location = location;
		((Control)lblTK4).Name = "lblTK4";
		Label obj13 = lblTK4;
		size = new Size(200, 20);
		((Control)obj13).Size = size;
		((Control)lblTK4).TabIndex = 248;
		lblTK4.TextAlign = (ContentAlignment)16;
		Label14.AutoSize = true;
		Label label9 = Label14;
		location = new Point(12, 246);
		((Control)label9).Location = location;
		((Control)Label14).Name = "Label14";
		Label label10 = Label14;
		size = new Size(64, 13);
		((Control)label10).Size = size;
		((Control)Label14).TabIndex = 247;
		Label14.Text = "Tài khoản 4";
		txtTk4.AutoLookup = true;
		txtTk4.AutoValid = true;
		((TextBoxBase)txtTk4).BackColor = SystemColors.Info;
		((TextBox)txtTk4).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk4;
		location = new Point(117, 242);
		((Control)asTextBox3).Location = location;
		txtTk4.LookupCodeName = "TK";
		((Control)txtTk4).Name = "txtTk4";
		txtTk4.NameControl = lblTK4;
		AsTextBox asTextBox4 = txtTk4;
		size = new Size(73, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk4).TabIndex = 7;
		txtTk4.UseAutoCompleteSource = true;
		Label obj14 = lblTK3;
		location = new Point(206, 216);
		((Control)obj14).Location = location;
		((Control)lblTK3).Name = "lblTK3";
		Label obj15 = lblTK3;
		size = new Size(200, 20);
		((Control)obj15).Size = size;
		((Control)lblTK3).TabIndex = 245;
		lblTK3.TextAlign = (ContentAlignment)16;
		Label12.AutoSize = true;
		Label label11 = Label12;
		location = new Point(12, 220);
		((Control)label11).Location = location;
		((Control)Label12).Name = "Label12";
		Label label12 = Label12;
		size = new Size(64, 13);
		((Control)label12).Size = size;
		((Control)Label12).TabIndex = 244;
		Label12.Text = "Tài khoản 3";
		txtTk3.AutoLookup = true;
		txtTk3.AutoValid = true;
		((TextBoxBase)txtTk3).BackColor = SystemColors.Info;
		((TextBox)txtTk3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTk3;
		location = new Point(117, 216);
		((Control)asTextBox5).Location = location;
		txtTk3.LookupCodeName = "TK";
		((Control)txtTk3).Name = "txtTk3";
		txtTk3.NameControl = lblTK3;
		AsTextBox asTextBox6 = txtTk3;
		size = new Size(73, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTk3).TabIndex = 6;
		txtTk3.UseAutoCompleteSource = true;
		Label obj16 = lblTK2;
		location = new Point(206, 191);
		((Control)obj16).Location = location;
		((Control)lblTK2).Name = "lblTK2";
		Label obj17 = lblTK2;
		size = new Size(200, 20);
		((Control)obj17).Size = size;
		((Control)lblTK2).TabIndex = 242;
		lblTK2.TextAlign = (ContentAlignment)16;
		Label10.AutoSize = true;
		Label label13 = Label10;
		location = new Point(12, 195);
		((Control)label13).Location = location;
		((Control)Label10).Name = "Label10";
		Label label14 = Label10;
		size = new Size(64, 13);
		((Control)label14).Size = size;
		((Control)Label10).TabIndex = 241;
		Label10.Text = "Tài khoản 2";
		txtTk2.AutoLookup = true;
		txtTk2.AutoValid = true;
		((TextBoxBase)txtTk2).BackColor = SystemColors.Info;
		((TextBox)txtTk2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtTk2;
		location = new Point(117, 191);
		((Control)asTextBox7).Location = location;
		txtTk2.LookupCodeName = "TK";
		((Control)txtTk2).Name = "txtTk2";
		txtTk2.NameControl = lblTK2;
		AsTextBox asTextBox8 = txtTk2;
		size = new Size(73, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtTk2).TabIndex = 5;
		txtTk2.UseAutoCompleteSource = true;
		Label obj18 = lblTK1;
		location = new Point(206, 166);
		((Control)obj18).Location = location;
		((Control)lblTK1).Name = "lblTK1";
		Label obj19 = lblTK1;
		size = new Size(200, 20);
		((Control)obj19).Size = size;
		((Control)lblTK1).TabIndex = 239;
		lblTK1.TextAlign = (ContentAlignment)16;
		Label8.AutoSize = true;
		Label label15 = Label8;
		location = new Point(12, 170);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(64, 13);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 238;
		Label8.Text = "Tài khoản 1";
		txtTk1.AutoLookup = true;
		txtTk1.AutoValid = true;
		((TextBoxBase)txtTk1).BackColor = SystemColors.Info;
		((TextBox)txtTk1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtTk1;
		location = new Point(117, 166);
		((Control)asTextBox9).Location = location;
		txtTk1.LookupCodeName = "TK";
		((Control)txtTk1).Name = "txtTk1";
		txtTk1.NameControl = lblTK1;
		AsTextBox asTextBox10 = txtTk1;
		size = new Size(73, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtTk1).TabIndex = 4;
		txtTk1.UseAutoCompleteSource = true;
		txtMa_chtieu.AutoLookup = false;
		txtMa_chtieu.AutoValid = false;
		((TextBoxBase)txtMa_chtieu).BackColor = SystemColors.Window;
		((TextBox)txtMa_chtieu).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtMa_chtieu;
		location = new Point(117, 19);
		((Control)asTextBox11).Location = location;
		txtMa_chtieu.LookupCodeName = "";
		((Control)txtMa_chtieu).Name = "txtMa_chtieu";
		txtMa_chtieu.NameControl = null;
		AsTextBox asTextBox12 = txtMa_chtieu;
		size = new Size(73, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtMa_chtieu).TabIndex = 0;
		txtMa_chtieu.UseAutoCompleteSource = true;
		Label1.AutoSize = true;
		Label label17 = Label1;
		location = new Point(12, 23);
		((Control)label17).Location = location;
		((Control)Label1).Name = "Label1";
		Label label18 = Label1;
		size = new Size(59, 13);
		((Control)label18).Size = size;
		((Control)Label1).TabIndex = 229;
		Label1.Text = "Mã chỉ tiêu";
		Label obj20 = lblTK9;
		location = new Point(624, 216);
		((Control)obj20).Location = location;
		((Control)lblTK9).Name = "lblTK9";
		Label obj21 = lblTK9;
		size = new Size(200, 20);
		((Control)obj21).Size = size;
		((Control)lblTK9).TabIndex = 271;
		lblTK9.TextAlign = (ContentAlignment)16;
		Label13.AutoSize = true;
		Label label19 = Label13;
		location = new Point(430, 220);
		((Control)label19).Location = location;
		((Control)Label13).Name = "Label13";
		Label label20 = Label13;
		size = new Size(64, 13);
		((Control)label20).Size = size;
		((Control)Label13).TabIndex = 270;
		Label13.Text = "Tài khoản 9";
		txtTk9.AutoLookup = true;
		txtTk9.AutoValid = true;
		((TextBoxBase)txtTk9).BackColor = SystemColors.Info;
		((TextBox)txtTk9).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox13 = txtTk9;
		location = new Point(535, 216);
		((Control)asTextBox13).Location = location;
		txtTk9.LookupCodeName = "TK";
		((Control)txtTk9).Name = "txtTk9";
		txtTk9.NameControl = lblTK9;
		AsTextBox asTextBox14 = txtTk9;
		size = new Size(73, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtTk9).TabIndex = 12;
		txtTk9.UseAutoCompleteSource = true;
		Label obj22 = lblTK8;
		location = new Point(624, 191);
		((Control)obj22).Location = location;
		((Control)lblTK8).Name = "lblTK8";
		Label obj23 = lblTK8;
		size = new Size(200, 20);
		((Control)obj23).Size = size;
		((Control)lblTK8).TabIndex = 268;
		lblTK8.TextAlign = (ContentAlignment)16;
		Label17.AutoSize = true;
		Label label21 = Label17;
		location = new Point(430, 195);
		((Control)label21).Location = location;
		((Control)Label17).Name = "Label17";
		Label label22 = Label17;
		size = new Size(64, 13);
		((Control)label22).Size = size;
		((Control)Label17).TabIndex = 267;
		Label17.Text = "Tài khoản 8";
		txtTk8.AutoLookup = true;
		txtTk8.AutoValid = true;
		((TextBoxBase)txtTk8).BackColor = SystemColors.Info;
		((TextBox)txtTk8).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox15 = txtTk8;
		location = new Point(535, 191);
		((Control)asTextBox15).Location = location;
		txtTk8.LookupCodeName = "TK";
		((Control)txtTk8).Name = "txtTk8";
		txtTk8.NameControl = lblTK8;
		AsTextBox asTextBox16 = txtTk8;
		size = new Size(73, 20);
		((Control)asTextBox16).Size = size;
		((Control)txtTk8).TabIndex = 11;
		txtTk8.UseAutoCompleteSource = true;
		Label obj24 = lblTK7;
		location = new Point(624, 166);
		((Control)obj24).Location = location;
		((Control)lblTK7).Name = "lblTK7";
		Label obj25 = lblTK7;
		size = new Size(200, 20);
		((Control)obj25).Size = size;
		((Control)lblTK7).TabIndex = 265;
		lblTK7.TextAlign = (ContentAlignment)16;
		Label19.AutoSize = true;
		Label label23 = Label19;
		location = new Point(430, 170);
		((Control)label23).Location = location;
		((Control)Label19).Name = "Label19";
		Label label24 = Label19;
		size = new Size(64, 13);
		((Control)label24).Size = size;
		((Control)Label19).TabIndex = 264;
		Label19.Text = "Tài khoản 7";
		txtTk7.AutoLookup = true;
		txtTk7.AutoValid = true;
		((TextBoxBase)txtTk7).BackColor = SystemColors.Info;
		((TextBox)txtTk7).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox17 = txtTk7;
		location = new Point(535, 166);
		((Control)asTextBox17).Location = location;
		txtTk7.LookupCodeName = "TK";
		((Control)txtTk7).Name = "txtTk7";
		txtTk7.NameControl = lblTK7;
		AsTextBox asTextBox18 = txtTk7;
		size = new Size(73, 20);
		((Control)asTextBox18).Size = size;
		((Control)txtTk7).TabIndex = 10;
		txtTk7.UseAutoCompleteSource = true;
		Label obj26 = lblTK6;
		location = new Point(206, 293);
		((Control)obj26).Location = location;
		((Control)lblTK6).Name = "lblTK6";
		Label obj27 = lblTK6;
		size = new Size(200, 20);
		((Control)obj27).Size = size;
		((Control)lblTK6).TabIndex = 262;
		lblTK6.TextAlign = (ContentAlignment)16;
		Label21.AutoSize = true;
		Label label25 = Label21;
		location = new Point(12, 297);
		((Control)label25).Location = location;
		((Control)Label21).Name = "Label21";
		Label label26 = Label21;
		size = new Size(64, 13);
		((Control)label26).Size = size;
		((Control)Label21).TabIndex = 261;
		Label21.Text = "Tài khoản 6";
		txtTk6.AutoLookup = true;
		txtTk6.AutoValid = true;
		((TextBoxBase)txtTk6).BackColor = SystemColors.Info;
		((TextBox)txtTk6).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox19 = txtTk6;
		location = new Point(117, 293);
		((Control)asTextBox19).Location = location;
		txtTk6.LookupCodeName = "TK";
		((Control)txtTk6).Name = "txtTk6";
		txtTk6.NameControl = lblTK6;
		AsTextBox asTextBox20 = txtTk6;
		size = new Size(73, 20);
		((Control)asTextBox20).Size = size;
		((Control)txtTk6).TabIndex = 9;
		txtTk6.UseAutoCompleteSource = true;
		TextBox obj28 = txtMauQD;
		location = new Point(547, 25);
		((Control)obj28).Location = location;
		((Control)txtMauQD).Name = "txtMauQD";
		TextBox obj29 = txtMauQD;
		size = new Size(73, 20);
		((Control)obj29).Size = size;
		((Control)txtMauQD).TabIndex = 237;
		((Control)txtMauQD).TabStop = false;
		((ButtonBase)ChkIs_italic).AutoSize = true;
		CheckBox chkIs_italic = ChkIs_italic;
		location = new Point(174, 350);
		((Control)chkIs_italic).Location = location;
		((Control)ChkIs_italic).Name = "ChkIs_italic";
		CheckBox chkIs_italic2 = ChkIs_italic;
		size = new Size(76, 17);
		((Control)chkIs_italic2).Size = size;
		((Control)ChkIs_italic).TabIndex = 19;
		((ButtonBase)ChkIs_italic).Text = "In nghiêng";
		((ButtonBase)ChkIs_italic).UseVisualStyleBackColor = true;
		((ButtonBase)ChkIs_print).AutoSize = true;
		CheckBox chkIs_print = ChkIs_print;
		location = new Point(117, 350);
		((Control)chkIs_print).Location = location;
		((Control)ChkIs_print).Name = "ChkIs_print";
		CheckBox chkIs_print2 = ChkIs_print;
		size = new Size(50, 17);
		((Control)chkIs_print2).Size = size;
		((Control)ChkIs_print).TabIndex = 18;
		((ButtonBase)ChkIs_print).Text = "Có in";
		((ButtonBase)ChkIs_print).UseVisualStyleBackColor = true;
		Label label27 = Label3;
		location = new Point(624, 293);
		((Control)label27).Location = location;
		((Control)Label3).Name = "Label3";
		Label label28 = Label3;
		size = new Size(200, 20);
		((Control)label28).Size = size;
		((Control)Label3).TabIndex = 283;
		Label3.TextAlign = (ContentAlignment)16;
		Label5.AutoSize = true;
		Label label29 = Label5;
		location = new Point(430, 297);
		((Control)label29).Location = location;
		((Control)Label5).Name = "Label5";
		Label label30 = Label5;
		size = new Size(70, 13);
		((Control)label30).Size = size;
		((Control)Label5).TabIndex = 282;
		Label5.Text = "Tài khoản 12";
		txtTk12.AutoLookup = true;
		txtTk12.AutoValid = true;
		((TextBoxBase)txtTk12).BackColor = SystemColors.Info;
		((TextBox)txtTk12).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox21 = txtTk12;
		location = new Point(535, 293);
		((Control)asTextBox21).Location = location;
		txtTk12.LookupCodeName = "TK";
		((Control)txtTk12).Name = "txtTk12";
		txtTk12.NameControl = Label3;
		AsTextBox asTextBox22 = txtTk12;
		size = new Size(73, 20);
		((Control)asTextBox22).Size = size;
		((Control)txtTk12).TabIndex = 15;
		txtTk12.UseAutoCompleteSource = true;
		Label label31 = Label9;
		location = new Point(624, 268);
		((Control)label31).Location = location;
		((Control)Label9).Name = "Label9";
		Label label32 = Label9;
		size = new Size(200, 20);
		((Control)label32).Size = size;
		((Control)Label9).TabIndex = 281;
		Label9.TextAlign = (ContentAlignment)16;
		Label11.AutoSize = true;
		Label label33 = Label11;
		location = new Point(430, 272);
		((Control)label33).Location = location;
		((Control)Label11).Name = "Label11";
		Label label34 = Label11;
		size = new Size(70, 13);
		((Control)label34).Size = size;
		((Control)Label11).TabIndex = 280;
		Label11.Text = "Tài khoản 11";
		txtTk11.AutoLookup = true;
		txtTk11.AutoValid = true;
		((TextBoxBase)txtTk11).BackColor = SystemColors.Info;
		((TextBox)txtTk11).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox23 = txtTk11;
		location = new Point(535, 268);
		((Control)asTextBox23).Location = location;
		txtTk11.LookupCodeName = "TK";
		((Control)txtTk11).Name = "txtTk11";
		txtTk11.NameControl = Label9;
		AsTextBox asTextBox24 = txtTk11;
		size = new Size(73, 20);
		((Control)asTextBox24).Size = size;
		((Control)txtTk11).TabIndex = 14;
		txtTk11.UseAutoCompleteSource = true;
		Label label35 = Label15;
		location = new Point(624, 242);
		((Control)label35).Location = location;
		((Control)Label15).Name = "Label15";
		Label label36 = Label15;
		size = new Size(200, 20);
		((Control)label36).Size = size;
		((Control)Label15).TabIndex = 279;
		Label15.TextAlign = (ContentAlignment)16;
		Label18.AutoSize = true;
		Label label37 = Label18;
		location = new Point(430, 246);
		((Control)label37).Location = location;
		((Control)Label18).Name = "Label18";
		Label label38 = Label18;
		size = new Size(70, 13);
		((Control)label38).Size = size;
		((Control)Label18).TabIndex = 278;
		Label18.Text = "Tài khoản 10";
		txtTk10.AutoLookup = true;
		txtTk10.AutoValid = true;
		((TextBoxBase)txtTk10).BackColor = SystemColors.Info;
		((TextBox)txtTk10).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox25 = txtTk10;
		location = new Point(535, 242);
		((Control)asTextBox25).Location = location;
		txtTk10.LookupCodeName = "TK";
		((Control)txtTk10).Name = "txtTk10";
		txtTk10.NameControl = Label15;
		AsTextBox asTextBox26 = txtTk10;
		size = new Size(73, 20);
		((Control)asTextBox26).Size = size;
		((Control)txtTk10).TabIndex = 13;
		txtTk10.UseAutoCompleteSource = true;
		((ComboBox)cboLoai_ps).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_ps).FormattingEnabled = true;
		AsComboBox asComboBox = cboLoai_ps;
		location = new Point(117, 319);
		((Control)asComboBox).Location = location;
		((Control)cboLoai_ps).Name = "cboLoai_ps";
		AsComboBox asComboBox2 = cboLoai_ps;
		size = new Size(197, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboLoai_ps).TabIndex = 16;
		Label7.AutoSize = true;
		Label label39 = Label7;
		location = new Point(12, 323);
		((Control)label39).Location = location;
		((Control)Label7).Name = "Label7";
		Label label40 = Label7;
		size = new Size(73, 13);
		((Control)label40).Size = size;
		((Control)Label7).TabIndex = 285;
		Label7.Text = "Loại phát sinh";
		((ComboBox)cboNam_ps).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNam_ps).FormattingEnabled = true;
		AsComboBox asComboBox3 = cboNam_ps;
		location = new Point(320, 319);
		((Control)asComboBox3).Location = location;
		((Control)cboNam_ps).Name = "cboNam_ps";
		AsComboBox asComboBox4 = cboNam_ps;
		size = new Size(121, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboNam_ps).TabIndex = 17;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(865, 424);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtMauQD);
		((Control)this).Name = "frmGLMAUBCTCTMV22AEdit";
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
		((ComboBox)cboNam_ps).DataSource = NamPS;
		((ListControl)cboNam_ps).ValueMember = "Key";
		((ListControl)cboNam_ps).DisplayMember = "Value";
		((ComboBox)cboNam_ps).SelectedIndex = 0;
		((TextBoxBase)txtMa_chtieu).MaxLength = base.MyDictComplexInfo.code_length;
		((Control)txtMa_chtieu).Select();
	}

	protected override bool ValidData()
	{
		txtNd_chtieu.Text = txtNd_chtieu.Text.Trim();
		if (Operators.CompareString(txtMauQD.Text.Trim(), "", false) == 0)
		{
			txtMauQD.Text = CompanyInformations.Qd_cdkt;
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
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMauQD;
		CreateDataBinding(ref ojb, "mau");
		txtMauQD = (TextBox)ojb;
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
		ojb = (Control)(object)cboNam_ps;
		CreateDataBinding(ref ojb, "nam_ps", "SelectedValue");
		cboNam_ps = (AsComboBox)(object)ojb;
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
		ojb = (Control)(object)txtTk8;
		CreateDataBinding(ref ojb, "tk_08");
		txtTk8 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk9;
		CreateDataBinding(ref ojb, "tk_09");
		txtTk9 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk10;
		CreateDataBinding(ref ojb, "tk_10");
		txtTk10 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk11;
		CreateDataBinding(ref ojb, "tk_11");
		txtTk11 = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk12;
		CreateDataBinding(ref ojb, "tk_12");
		txtTk12 = (AsTextBox)(object)ojb;
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

	private void frmGLMAUBCTCTMVI25AEdit_Load(object sender, EventArgs e)
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
