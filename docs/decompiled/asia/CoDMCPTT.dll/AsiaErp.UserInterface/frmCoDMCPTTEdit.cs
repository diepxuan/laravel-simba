using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCoDMCPTTEdit : frmDMComplexEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

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

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("txtDvt")]
	private TextBox _txtDvt;

	[AccessedThroughProperty("txtTen_cptt")]
	private TextBox _txtTen_cptt;

	[AccessedThroughProperty("txtMa_cptt")]
	private TextBox _txtMa_cptt;

	[AccessedThroughProperty("txtNgay_gtcl")]
	private AsMaskedTextBox _txtNgay_gtcl;

	[AccessedThroughProperty("txtNgay_bdau_bp")]
	private AsMaskedTextBox _txtNgay_bdau_bp;

	[AccessedThroughProperty("txtNgay_ct")]
	private AsMaskedTextBox _txtNgay_ct;

	[AccessedThroughProperty("txtGiatri_pb_1ky")]
	private AsTextNumeric _txtGiatri_pb_1ky;

	[AccessedThroughProperty("txtGiatri_pn_con_lai")]
	private AsTextNumeric _txtGiatri_pn_con_lai;

	[AccessedThroughProperty("txtGia_tri_da_pb")]
	private AsTextNumeric _txtGia_tri_da_pb;

	[AccessedThroughProperty("txtNguyen_gia")]
	private AsTextNumeric _txtNguyen_gia;

	[AccessedThroughProperty("txtSo_ky_BP")]
	private AsTextNumeric _txtSo_ky_BP;

	[AccessedThroughProperty("txtDon_gia")]
	private AsTextNumeric _txtDon_gia;

	[AccessedThroughProperty("txtSo_luong")]
	private AsTextNumeric _txtSo_luong;

	[AccessedThroughProperty("txtMa_phi")]
	private AsTextBox _txtMa_phi;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("txtMa_bpsd")]
	private AsTextBox _txtMa_bpsd;

	[AccessedThroughProperty("txtTK_chiphi")]
	private AsTextBox _txtTK_chiphi;

	[AccessedThroughProperty("txtTK_pb")]
	private AsTextBox _txtTK_pb;

	[AccessedThroughProperty("Chk_Giatri_pb1ky")]
	private CheckBox _Chk_Giatri_pb1ky;

	[AccessedThroughProperty("lblTK_cp")]
	private Label _lblTK_cp;

	[AccessedThroughProperty("lblTK_pb")]
	private Label _lblTK_pb;

	[AccessedThroughProperty("txtID")]
	private AsTextNumeric _txtID;

	public static int pID = 0;

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

	internal virtual Label Label20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label20 = value;
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

	internal virtual TextBox txtSo_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ct = value;
		}
	}

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

	internal virtual TextBox txtTen_cptt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_cptt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_cptt = value;
		}
	}

	internal virtual TextBox txtMa_cptt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_cptt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_cptt = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_gtcl
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_gtcl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_gtcl = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_bdau_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_bdau_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_bdau_bp = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_ct = value;
		}
	}

	internal virtual AsTextNumeric txtGiatri_pb_1ky
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGiatri_pb_1ky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGiatri_pb_1ky = value;
		}
	}

	internal virtual AsTextNumeric txtGiatri_pn_con_lai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGiatri_pn_con_lai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TxtGiatriPnConLaiTextChanged;
			if (_txtGiatri_pn_con_lai != null)
			{
				((Control)_txtGiatri_pn_con_lai).TextChanged -= eventHandler;
			}
			_txtGiatri_pn_con_lai = value;
			if (_txtGiatri_pn_con_lai != null)
			{
				((Control)_txtGiatri_pn_con_lai).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtGia_tri_da_pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGia_tri_da_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TxtGiaTriDaPbTextChanged;
			if (_txtGia_tri_da_pb != null)
			{
				((Control)_txtGia_tri_da_pb).Validated -= eventHandler;
			}
			_txtGia_tri_da_pb = value;
			if (_txtGia_tri_da_pb != null)
			{
				((Control)_txtGia_tri_da_pb).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtNguyen_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNguyen_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNguyen_gia = value;
		}
	}

	internal virtual AsTextNumeric txtSo_ky_BP
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ky_BP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TxtSoKyBpText_Changed;
			if (_txtSo_ky_BP != null)
			{
				((Control)_txtSo_ky_BP).Validated -= eventHandler;
			}
			_txtSo_ky_BP = value;
			if (_txtSo_ky_BP != null)
			{
				((Control)_txtSo_ky_BP).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtDon_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDon_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TxtDonGiaTextChanged;
			if (_txtDon_gia != null)
			{
				((Control)_txtDon_gia).Validated -= eventHandler;
			}
			_txtDon_gia = value;
			if (_txtDon_gia != null)
			{
				((Control)_txtDon_gia).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtSo_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TxtSoLuongTextChanged;
			if (_txtSo_luong != null)
			{
				((Control)_txtSo_luong).Validated -= eventHandler;
			}
			_txtSo_luong = value;
			if (_txtSo_luong != null)
			{
				((Control)_txtSo_luong).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextBox txtMa_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_phi = value;
		}
	}

	internal virtual AsTextBox txtMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_spct = value;
		}
	}

	internal virtual AsTextBox txtMa_bpsd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_bpsd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_bpsd = value;
		}
	}

	internal virtual AsTextBox txtTK_chiphi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_chiphi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_chiphi = value;
		}
	}

	internal virtual AsTextBox txtTK_pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_pb = value;
		}
	}

	internal virtual CheckBox Chk_Giatri_pb1ky
	{
		[DebuggerNonUserCode]
		get
		{
			return _Chk_Giatri_pb1ky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ChkGiatriPb1_KyCheckedChanged;
			if (_Chk_Giatri_pb1ky != null)
			{
				_Chk_Giatri_pb1ky.CheckedChanged -= eventHandler;
			}
			_Chk_Giatri_pb1ky = value;
			if (_Chk_Giatri_pb1ky != null)
			{
				_Chk_Giatri_pb1ky.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblTK_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_cp = value;
		}
	}

	internal virtual Label lblTK_pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_pb = value;
		}
	}

	internal virtual AsTextNumeric txtID
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtID = value;
		}
	}

	[DebuggerNonUserCode]
	public frmCoDMCPTTEdit()
	{
		((Form)this).Load += frmCoDMCPTTEdit_Load;
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
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Label11 = new Label();
		Label12 = new Label();
		Label13 = new Label();
		Label14 = new Label();
		Label15 = new Label();
		Label16 = new Label();
		Label17 = new Label();
		Label19 = new Label();
		Label20 = new Label();
		txtMa_cptt = new TextBox();
		txtTen_cptt = new TextBox();
		txtDvt = new TextBox();
		txtSo_ct = new TextBox();
		txtTK_pb = new AsTextBox();
		lblTK_pb = new Label();
		txtTK_chiphi = new AsTextBox();
		lblTK_cp = new Label();
		txtMa_bpsd = new AsTextBox();
		txtMa_spct = new AsTextBox();
		txtMa_phi = new AsTextBox();
		txtSo_luong = new AsTextNumeric();
		txtDon_gia = new AsTextNumeric();
		txtSo_ky_BP = new AsTextNumeric();
		txtNguyen_gia = new AsTextNumeric();
		txtGia_tri_da_pb = new AsTextNumeric();
		txtGiatri_pn_con_lai = new AsTextNumeric();
		txtGiatri_pb_1ky = new AsTextNumeric();
		txtNgay_ct = new AsMaskedTextBox();
		txtNgay_bdau_bp = new AsMaskedTextBox();
		txtNgay_gtcl = new AsMaskedTextBox();
		Chk_Giatri_pb1ky = new CheckBox();
		txtID = new AsTextNumeric();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Enabled = false;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(26, 221);
		((Control)asCheckBox).Location = location;
		AsCheckBox asCheckBox2 = chkKsd;
		Size size = new Size(33, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkKsd).TabIndex = 19;
		((ButtonBase)chkKsd).Text = "S";
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 310);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 310);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtID);
		((Control)gbLine).Controls.Add((Control)(object)lblTK_cp);
		((Control)gbLine).Controls.Add((Control)(object)Chk_Giatri_pb1ky);
		((Control)gbLine).Controls.Add((Control)(object)lblTK_pb);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_gtcl);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_bdau_bp);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtGiatri_pb_1ky);
		((Control)gbLine).Controls.Add((Control)(object)txtGiatri_pn_con_lai);
		((Control)gbLine).Controls.Add((Control)(object)txtGia_tri_da_pb);
		((Control)gbLine).Controls.Add((Control)(object)txtNguyen_gia);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_phi);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ky_BP);
		((Control)gbLine).Controls.Add((Control)(object)txtDon_gia);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_luong);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_spct);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_bpsd);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_chiphi);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_pb);
		((Control)gbLine).Controls.Add((Control)(object)txtDvt);
		((Control)gbLine).Controls.Add((Control)(object)Label20);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_cptt);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_cptt);
		((Control)gbLine).Controls.Add((Control)(object)Label19);
		((Control)gbLine).Controls.Add((Control)(object)Label17);
		((Control)gbLine).Controls.Add((Control)(object)Label16);
		((Control)gbLine).Controls.Add((Control)(object)Label15);
		((Control)gbLine).Controls.Add((Control)(object)Label14);
		((Control)gbLine).Controls.Add((Control)(object)Label13);
		((Control)gbLine).Controls.Add((Control)(object)Label12);
		((Control)gbLine).Controls.Add((Control)(object)Label11);
		((Control)gbLine).Controls.Add((Control)(object)Label10);
		((Control)gbLine).Controls.Add((Control)(object)Label9);
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		GroupBox obj3 = gbLine;
		size = new Size(591, 298);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label9, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label10, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label11, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label12, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label13, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label14, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label15, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label16, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label17, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label19, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_cptt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_cptt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label20, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_pb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_chiphi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_bpsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_luong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDon_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ky_BP, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_phi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNguyen_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGia_tri_da_pb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGiatri_pn_con_lai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGiatri_pb_1ky, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_bdau_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_gtcl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK_pb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Chk_Giatri_pb1ky, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK_cp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtID, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(23, 28);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(58, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 100;
		Label1.Text = "Mã chi phí";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(23, 126);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(44, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 101;
		Label2.Text = "Đơn giá";
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(23, 53);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(62, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 102;
		Label3.Text = "Tên chi phí";
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(23, 102);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(49, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 103;
		Label4.Text = "Số lượng";
		Label5.AutoSize = true;
		Label label9 = Label5;
		location = new Point(23, 241);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(61, 13);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 104;
		Label5.Text = "Nguyên giá";
		Label6.AutoSize = true;
		Label label11 = Label6;
		location = new Point(23, 77);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(24, 13);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 105;
		Label6.Text = "Đvt";
		Label7.AutoSize = true;
		Label label13 = Label7;
		location = new Point(23, 150);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(67, 13);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 106;
		Label7.Text = "Số tháng PB";
		Label8.AutoSize = true;
		Label label15 = Label8;
		location = new Point(166, 241);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(92, 13);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 107;
		Label8.Text = "Giá trị đã phân bổ";
		Label9.AutoSize = true;
		Label label17 = Label9;
		location = new Point(468, 241);
		((Control)label17).Location = location;
		((Control)Label9).Name = "Label9";
		Label label18 = Label9;
		size = new Size(99, 13);
		((Control)label18).Size = size;
		((Control)Label9).TabIndex = 108;
		Label9.Text = "Giá trị phân bổ 1 kỳ";
		Label10.AutoSize = true;
		Label label19 = Label10;
		location = new Point(23, 175);
		((Control)label19).Location = location;
		((Control)Label10).Name = "Label10";
		Label label20 = Label10;
		size = new Size(63, 13);
		((Control)label20).Size = size;
		((Control)Label10).TabIndex = 109;
		Label10.Text = "TK phân bổ";
		Label11.AutoSize = true;
		Label label21 = Label11;
		location = new Point(319, 241);
		((Control)label21).Location = location;
		((Control)Label11).Name = "Label11";
		Label label22 = Label11;
		size = new Size(110, 13);
		((Control)label22).Size = size;
		((Control)Label11).TabIndex = 110;
		Label11.Text = "Giá trị phân bổ còn lại";
		Label12.AutoSize = true;
		Label label23 = Label12;
		location = new Point(23, 199);
		((Control)label23).Location = location;
		((Control)Label12).Name = "Label12";
		Label label24 = Label12;
		size = new Size(57, 13);
		((Control)label24).Size = size;
		((Control)Label12).TabIndex = 111;
		Label12.Text = "TK chi phí";
		Label13.AutoSize = true;
		Label label25 = Label13;
		location = new Point(405, 102);
		((Control)label25).Location = location;
		((Control)Label13).Name = "Label13";
		Label label26 = Label13;
		size = new Size(52, 13);
		((Control)label26).Size = size;
		((Control)Label13).TabIndex = 112;
		Label13.Text = "Ngày gtcl";
		Label14.AutoSize = true;
		Label label27 = Label14;
		location = new Point(405, 126);
		((Control)label27).Location = location;
		((Control)Label14).Name = "Label14";
		Label label28 = Label14;
		size = new Size(41, 13);
		((Control)label28).Size = size;
		((Control)Label14).TabIndex = 113;
		Label14.Text = "Mã phí";
		Label15.AutoSize = true;
		Label label29 = Label15;
		location = new Point(405, 77);
		((Control)label29).Location = location;
		((Control)Label15).Name = "Label15";
		Label label30 = Label15;
		size = new Size(87, 13);
		((Control)label30).Size = size;
		((Control)Label15).TabIndex = 114;
		Label15.Text = "Ngày bắt đầu pb";
		Label16.AutoSize = true;
		Label label31 = Label16;
		location = new Point(405, 53);
		((Control)label31).Location = location;
		((Control)Label16).Name = "Label16";
		Label label32 = Label16;
		size = new Size(44, 13);
		((Control)label32).Size = size;
		((Control)Label16).TabIndex = 115;
		Label16.Text = "Ngày ct";
		Label17.AutoSize = true;
		Label label33 = Label17;
		location = new Point(405, 28);
		((Control)label33).Location = location;
		((Control)Label17).Name = "Label17";
		Label label34 = Label17;
		size = new Size(32, 13);
		((Control)label34).Size = size;
		((Control)Label17).TabIndex = 116;
		Label17.Text = "Số ct";
		Label19.AutoSize = true;
		Label label35 = Label19;
		location = new Point(405, 175);
		((Control)label35).Location = location;
		((Control)Label19).Name = "Label19";
		Label label36 = Label19;
		size = new Size(48, 13);
		((Control)label36).Size = size;
		((Control)Label19).TabIndex = 118;
		Label19.Text = "Mã bpsd";
		Label20.AutoSize = true;
		Label label37 = Label20;
		location = new Point(405, 150);
		((Control)label37).Location = location;
		((Control)Label20).Name = "Label20";
		Label label38 = Label20;
		size = new Size(45, 13);
		((Control)label38).Size = size;
		((Control)Label20).TabIndex = 119;
		Label20.Text = "Mã spct";
		txtMa_cptt.CharacterCasing = (CharacterCasing)1;
		TextBox obj4 = txtMa_cptt;
		location = new Point(103, 24);
		((Control)obj4).Location = location;
		((TextBoxBase)txtMa_cptt).MaxLength = 20;
		((Control)txtMa_cptt).Name = "txtMa_cptt";
		TextBox obj5 = txtMa_cptt;
		size = new Size(80, 20);
		((Control)obj5).Size = size;
		((Control)txtMa_cptt).TabIndex = 0;
		TextBox obj6 = txtTen_cptt;
		location = new Point(103, 49);
		((Control)obj6).Location = location;
		((TextBoxBase)txtTen_cptt).MaxLength = 50;
		((Control)txtTen_cptt).Name = "txtTen_cptt";
		TextBox obj7 = txtTen_cptt;
		size = new Size(285, 20);
		((Control)obj7).Size = size;
		((Control)txtTen_cptt).TabIndex = 1;
		TextBox obj8 = txtDvt;
		location = new Point(103, 73);
		((Control)obj8).Location = location;
		((TextBoxBase)txtDvt).MaxLength = 10;
		((Control)txtDvt).Name = "txtDvt";
		TextBox obj9 = txtDvt;
		size = new Size(80, 20);
		((Control)obj9).Size = size;
		((Control)txtDvt).TabIndex = 2;
		TextBox obj10 = txtSo_ct;
		location = new Point(497, 24);
		((Control)obj10).Location = location;
		((TextBoxBase)txtSo_ct).MaxLength = 12;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj11 = txtSo_ct;
		size = new Size(80, 20);
		((Control)obj11).Size = size;
		((Control)txtSo_ct).TabIndex = 8;
		txtTK_pb.AutoLookup = true;
		txtTK_pb.AutoValid = true;
		((TextBoxBase)txtTK_pb).BackColor = SystemColors.Info;
		((TextBox)txtTK_pb).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTK_pb;
		location = new Point(103, 171);
		((Control)asTextBox).Location = location;
		txtTK_pb.LookupCodeName = "TK";
		txtTK_pb.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTK_pb).Name = "txtTK_pb";
		txtTK_pb.NameControl = lblTK_pb;
		AsTextBox asTextBox2 = txtTK_pb;
		size = new Size(80, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTK_pb).TabIndex = 6;
		txtTK_pb.UseAutoCompleteSource = true;
		Label obj12 = lblTK_pb;
		location = new Point(195, 171);
		((Control)obj12).Location = location;
		((Control)lblTK_pb).Name = "lblTK_pb";
		Label obj13 = lblTK_pb;
		size = new Size(193, 20);
		((Control)obj13).Size = size;
		((Control)lblTK_pb).TabIndex = 121;
		lblTK_pb.TextAlign = (ContentAlignment)16;
		txtTK_chiphi.AutoLookup = true;
		txtTK_chiphi.AutoValid = true;
		((TextBoxBase)txtTK_chiphi).BackColor = SystemColors.Info;
		((TextBox)txtTK_chiphi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTK_chiphi;
		location = new Point(103, 195);
		((Control)asTextBox3).Location = location;
		txtTK_chiphi.LookupCodeName = "TK";
		txtTK_chiphi.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTK_chiphi).Name = "txtTK_chiphi";
		txtTK_chiphi.NameControl = lblTK_cp;
		AsTextBox asTextBox4 = txtTK_chiphi;
		size = new Size(80, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTK_chiphi).TabIndex = 7;
		txtTK_chiphi.UseAutoCompleteSource = true;
		Label obj14 = lblTK_cp;
		location = new Point(195, 195);
		((Control)obj14).Location = location;
		((Control)lblTK_cp).Name = "lblTK_cp";
		Label obj15 = lblTK_cp;
		size = new Size(193, 20);
		((Control)obj15).Size = size;
		((Control)lblTK_cp).TabIndex = 122;
		lblTK_cp.TextAlign = (ContentAlignment)16;
		txtMa_bpsd.AutoLookup = true;
		txtMa_bpsd.AutoValid = true;
		((TextBoxBase)txtMa_bpsd).BackColor = SystemColors.Info;
		((TextBox)txtMa_bpsd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_bpsd;
		location = new Point(497, 171);
		((Control)asTextBox5).Location = location;
		txtMa_bpsd.LookupCodeName = "MA_BPSD";
		((Control)txtMa_bpsd).Name = "txtMa_bpsd";
		txtMa_bpsd.NameControl = null;
		AsTextBox asTextBox6 = txtMa_bpsd;
		size = new Size(80, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_bpsd).TabIndex = 14;
		txtMa_bpsd.UseAutoCompleteSource = true;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = true;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_spct;
		location = new Point(497, 146);
		((Control)asTextBox7).Location = location;
		txtMa_spct.LookupCodeName = "Ma_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = null;
		AsTextBox asTextBox8 = txtMa_spct;
		size = new Size(80, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_spct).TabIndex = 13;
		txtMa_spct.UseAutoCompleteSource = true;
		txtMa_phi.AutoLookup = true;
		txtMa_phi.AutoValid = true;
		((TextBoxBase)txtMa_phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_phi;
		location = new Point(497, 122);
		((Control)asTextBox9).Location = location;
		txtMa_phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_phi).Name = "txtMa_phi";
		txtMa_phi.NameControl = null;
		AsTextBox asTextBox10 = txtMa_phi;
		size = new Size(80, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_phi).TabIndex = 12;
		txtMa_phi.UseAutoCompleteSource = true;
		txtSo_luong.DecimalSymbol = ".";
		txtSo_luong.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtSo_luong;
		location = new Point(103, 98);
		((Control)asTextNumeric).Location = location;
		txtSo_luong.Mask = "### ### ###";
		((Control)txtSo_luong).Name = "txtSo_luong";
		AsTextNumeric asTextNumeric2 = txtSo_luong;
		size = new Size(80, 20);
		((Control)asTextNumeric2).Size = size;
		txtSo_luong.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSo_luong).TabIndex = 3;
		((TextBox)txtSo_luong).Text = "0";
		((TextBox)txtSo_luong).TextAlign = (HorizontalAlignment)1;
		txtSo_luong.Type = Commons.NumericType.ORTHER_;
		txtSo_luong.Value = 0.0;
		txtDon_gia.DecimalSymbol = ".";
		txtDon_gia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtDon_gia;
		location = new Point(103, 122);
		((Control)asTextNumeric3).Location = location;
		txtDon_gia.Mask = "### ### ###";
		((Control)txtDon_gia).Name = "txtDon_gia";
		AsTextNumeric asTextNumeric4 = txtDon_gia;
		size = new Size(80, 20);
		((Control)asTextNumeric4).Size = size;
		txtDon_gia.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtDon_gia).TabIndex = 4;
		((TextBox)txtDon_gia).Text = "0";
		((TextBox)txtDon_gia).TextAlign = (HorizontalAlignment)1;
		txtDon_gia.Type = Commons.NumericType.ORTHER_;
		txtDon_gia.Value = 0.0;
		txtSo_ky_BP.DecimalSymbol = ".";
		txtSo_ky_BP.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtSo_ky_BP;
		location = new Point(103, 146);
		((Control)asTextNumeric5).Location = location;
		txtSo_ky_BP.Mask = "### ### ###";
		((Control)txtSo_ky_BP).Name = "txtSo_ky_BP";
		AsTextNumeric asTextNumeric6 = txtSo_ky_BP;
		size = new Size(80, 20);
		((Control)asTextNumeric6).Size = size;
		txtSo_ky_BP.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSo_ky_BP).TabIndex = 5;
		((TextBox)txtSo_ky_BP).Text = "0";
		((TextBox)txtSo_ky_BP).TextAlign = (HorizontalAlignment)1;
		txtSo_ky_BP.Type = Commons.NumericType.ORTHER_;
		txtSo_ky_BP.Value = 0.0;
		txtNguyen_gia.DecimalSymbol = ".";
		txtNguyen_gia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtNguyen_gia;
		location = new Point(23, 266);
		((Control)asTextNumeric7).Location = location;
		txtNguyen_gia.Mask = "### ### ### ###.##";
		((Control)txtNguyen_gia).Name = "txtNguyen_gia";
		AsTextNumeric asTextNumeric8 = txtNguyen_gia;
		size = new Size(109, 20);
		((Control)asTextNumeric8).Size = size;
		txtNguyen_gia.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNguyen_gia).TabIndex = 16;
		((TextBox)txtNguyen_gia).Text = "0.00";
		((TextBox)txtNguyen_gia).TextAlign = (HorizontalAlignment)1;
		txtNguyen_gia.Type = Commons.NumericType.ORTHER_;
		txtNguyen_gia.Value = 0.0;
		txtGia_tri_da_pb.DecimalSymbol = ".";
		txtGia_tri_da_pb.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric9 = txtGia_tri_da_pb;
		location = new Point(166, 266);
		((Control)asTextNumeric9).Location = location;
		txtGia_tri_da_pb.Mask = "### ### ### ###.##";
		((Control)txtGia_tri_da_pb).Name = "txtGia_tri_da_pb";
		AsTextNumeric asTextNumeric10 = txtGia_tri_da_pb;
		size = new Size(109, 20);
		((Control)asTextNumeric10).Size = size;
		txtGia_tri_da_pb.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGia_tri_da_pb).TabIndex = 17;
		((TextBox)txtGia_tri_da_pb).Text = "0.00";
		((TextBox)txtGia_tri_da_pb).TextAlign = (HorizontalAlignment)1;
		txtGia_tri_da_pb.Type = Commons.NumericType.ORTHER_;
		txtGia_tri_da_pb.Value = 0.0;
		txtGiatri_pn_con_lai.DecimalSymbol = ".";
		txtGiatri_pn_con_lai.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric11 = txtGiatri_pn_con_lai;
		location = new Point(319, 266);
		((Control)asTextNumeric11).Location = location;
		txtGiatri_pn_con_lai.Mask = "### ### ### ###.##";
		((Control)txtGiatri_pn_con_lai).Name = "txtGiatri_pn_con_lai";
		((TextBoxBase)txtGiatri_pn_con_lai).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtGiatri_pn_con_lai;
		size = new Size(109, 20);
		((Control)asTextNumeric12).Size = size;
		txtGiatri_pn_con_lai.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGiatri_pn_con_lai).TabIndex = 18;
		((TextBox)txtGiatri_pn_con_lai).Text = "0.00";
		((TextBox)txtGiatri_pn_con_lai).TextAlign = (HorizontalAlignment)1;
		txtGiatri_pn_con_lai.Type = Commons.NumericType.ORTHER_;
		txtGiatri_pn_con_lai.Value = 0.0;
		txtGiatri_pb_1ky.DecimalSymbol = ".";
		txtGiatri_pb_1ky.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric13 = txtGiatri_pb_1ky;
		location = new Point(468, 266);
		((Control)asTextNumeric13).Location = location;
		txtGiatri_pb_1ky.Mask = "### ### ### ###.##";
		((Control)txtGiatri_pb_1ky).Name = "txtGiatri_pb_1ky";
		((TextBoxBase)txtGiatri_pb_1ky).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtGiatri_pb_1ky;
		size = new Size(109, 20);
		((Control)asTextNumeric14).Size = size;
		txtGiatri_pb_1ky.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGiatri_pb_1ky).TabIndex = 19;
		((TextBox)txtGiatri_pb_1ky).Text = "0.00";
		((TextBox)txtGiatri_pb_1ky).TextAlign = (HorizontalAlignment)1;
		txtGiatri_pb_1ky.Type = Commons.NumericType.ORTHER_;
		txtGiatri_pb_1ky.Value = 0.0;
		txtNgay_ct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct;
		location = new Point(497, 49);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ct).Mask = "##/##/####";
		((Control)txtNgay_ct).Name = "txtNgay_ct";
		((MaskedTextBox)txtNgay_ct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ct;
		size = new Size(80, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ct).TabIndex = 9;
		((MaskedTextBox)txtNgay_ct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtNgay_bdau_bp.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_bdau_bp).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_bdau_bp;
		location = new Point(497, 73);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_bdau_bp).Mask = "##/##/####";
		((Control)txtNgay_bdau_bp).Name = "txtNgay_bdau_bp";
		((MaskedTextBox)txtNgay_bdau_bp).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_bdau_bp;
		size = new Size(80, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_bdau_bp).TabIndex = 10;
		((MaskedTextBox)txtNgay_bdau_bp).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_bdau_bp;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		txtNgay_gtcl.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_gtcl).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox7 = txtNgay_gtcl;
		location = new Point(497, 98);
		((Control)asMaskedTextBox7).Location = location;
		((MaskedTextBox)txtNgay_gtcl).Mask = "##/##/####";
		((Control)txtNgay_gtcl).Name = "txtNgay_gtcl";
		((MaskedTextBox)txtNgay_gtcl).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox8 = txtNgay_gtcl;
		size = new Size(80, 20);
		((Control)asMaskedTextBox8).Size = size;
		((Control)txtNgay_gtcl).TabIndex = 11;
		((MaskedTextBox)txtNgay_gtcl).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox9 = txtNgay_gtcl;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox9.Value = dateTime;
		((ButtonBase)Chk_Giatri_pb1ky).AutoSize = true;
		CheckBox chk_Giatri_pb1ky = Chk_Giatri_pb1ky;
		location = new Point(497, 197);
		((Control)chk_Giatri_pb1ky).Location = location;
		((Control)Chk_Giatri_pb1ky).Name = "Chk_Giatri_pb1ky";
		CheckBox chk_Giatri_pb1ky2 = Chk_Giatri_pb1ky;
		size = new Size(87, 17);
		((Control)chk_Giatri_pb1ky2).Size = size;
		((Control)Chk_Giatri_pb1ky).TabIndex = 15;
		((ButtonBase)Chk_Giatri_pb1ky).Text = "Sửa phân bổ";
		((ButtonBase)Chk_Giatri_pb1ky).UseVisualStyleBackColor = true;
		txtID.DecimalSymbol = ".";
		txtID.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric15 = txtID;
		location = new Point(286, 432);
		((Control)asTextNumeric15).Location = location;
		txtID.Mask = "############";
		((Control)txtID).Name = "txtID";
		AsTextNumeric asTextNumeric16 = txtID;
		size = new Size(100, 20);
		((Control)asTextNumeric16).Size = size;
		txtID.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtID).TabIndex = 123;
		((Control)txtID).TabStop = false;
		((TextBox)txtID).Text = "0";
		((TextBox)txtID).TextAlign = (HorizontalAlignment)1;
		txtID.Type = Commons.NumericType.ORTHER_;
		txtID.Value = 0.0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(615, 345);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCoDMCPTTEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_cptt).MaxLength = MyDictComplexInfo.code_length;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct;
		DateTime dateTime = new DateTime(DateAndTime.Now.Year, DateAndTime.Now.Month, DateAndTime.Now.Day, 0, 0, 0, 0);
		asMaskedTextBox.Value = dateTime;
		((Control)txtMa_cptt).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_cptt).Enabled = false;
		((Control)txtTen_cptt).Select();
	}

	protected override void DataBinding()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtID;
		CreateDataBinding(ref ojb, "ID", "Value");
		txtID = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMa_cptt;
		CreateDataBinding(ref ojb, "ma_cptt");
		txtMa_cptt = (TextBox)ojb;
		ojb = (Control)(object)txtTen_cptt;
		CreateDataBinding(ref ojb, "ten_cptt");
		txtTen_cptt = (TextBox)ojb;
		ojb = (Control)(object)txtDvt;
		CreateDataBinding(ref ojb, "dvt");
		txtDvt = (TextBox)ojb;
		ojb = (Control)(object)txtSo_luong;
		CreateDataBinding(ref ojb, "so_luong", "Value");
		txtSo_luong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDon_gia;
		CreateDataBinding(ref ojb, "don_gia", "Value");
		txtDon_gia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSo_ky_BP;
		CreateDataBinding(ref ojb, "so_ky", "Value");
		txtSo_ky_BP = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTK_pb;
		CreateDataBinding(ref ojb, "tk_cptt");
		txtTK_pb = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTK_chiphi;
		CreateDataBinding(ref ojb, "tk_cp");
		txtTK_chiphi = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "so_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)txtNgay_ct;
		CreateDataBinding(ref ojb, "ngay_ct", "Value");
		txtNgay_ct = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_bdau_bp;
		CreateDataBinding(ref ojb, "ngay_bdkh", "Value");
		txtNgay_bdau_bp = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_gtcl;
		CreateDataBinding(ref ojb, "ngay_gt_cl", "Value");
		txtNgay_gtcl = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_phi;
		CreateDataBinding(ref ojb, "MA_PHI");
		txtMa_phi = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_bpsd;
		CreateDataBinding(ref ojb, "ma_bpsd");
		txtMa_bpsd = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_spct;
		CreateDataBinding(ref ojb, "ma_spct");
		txtMa_spct = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtNguyen_gia;
		CreateDataBinding(ref ojb, "ng_gia", "Value");
		txtNguyen_gia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGia_tri_da_pb;
		CreateDataBinding(ref ojb, "gt_da_kh", "Value");
		txtGia_tri_da_pb = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGiatri_pn_con_lai;
		CreateDataBinding(ref ojb, "gt_cl", "Value");
		txtGiatri_pn_con_lai = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGiatri_pb_1ky;
		CreateDataBinding(ref ojb, "kh_ky", "Value");
		txtGiatri_pb_1ky = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)Chk_Giatri_pb1ky;
		CreateDataBinding(ref ojb, "sua_kh", "Checked");
		Chk_Giatri_pb1ky = (CheckBox)ojb;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (txtNgay_ct.Value == null)
		{
			AsMaskedTextBox asMaskedTextBox = txtNgay_ct;
			DateTime dateTime = new DateTime(DateAndTime.Now.Year, DateAndTime.Now.Month, DateAndTime.Now.Day, 0, 0, 0);
			asMaskedTextBox.Value = dateTime;
		}
		((Control)txtTK_pb).Select();
		((Control)txtTK_chiphi).Select();
		((Control)txtMa_cptt).Select();
	}

	protected override bool ValidData()
	{
		if (Operators.CompareString(txtMa_cptt.Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtMa_cptt, Helper.GetMessContent(50002));
			((Control)txtMa_cptt).Focus();
			return false;
		}
		SetControlError((Control)(object)txtMa_cptt, "");
		if (Operators.CompareString(txtTen_cptt.Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtTen_cptt, Helper.GetMessContent(50002));
			((Control)txtTen_cptt).Focus();
			return false;
		}
		SetControlError((Control)(object)txtTen_cptt, "");
		if (Operators.ConditionalCompareObjectLessEqual(txtSo_luong.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtSo_luong, Helper.GetMessContent(50034));
			((Control)txtSo_luong).Focus();
			return false;
		}
		SetControlError((Control)(object)txtSo_luong, "");
		if (Operators.ConditionalCompareObjectLessEqual(txtSo_ky_BP.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtSo_ky_BP, Helper.GetMessContent(50034));
			((Control)txtSo_ky_BP).Focus();
			return false;
		}
		SetControlError((Control)(object)txtSo_ky_BP, "");
		if (Operators.CompareString(((TextBox)txtTK_pb).Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtTK_pb, Helper.GetMessContent(50002));
			((Control)txtTK_pb).Focus();
			return false;
		}
		SetControlError((Control)(object)txtTK_pb, "");
		if (Operators.CompareString(((TextBox)txtTK_chiphi).Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtTK_chiphi, Helper.GetMessContent(50002));
			((Control)txtTK_chiphi).Focus();
			return false;
		}
		SetControlError((Control)(object)txtTK_chiphi, "");
		object value = txtNgay_ct.Value;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0);
		if (Operators.ConditionalCompareObjectEqual(value, (object)dateTime, false))
		{
			SetControlError((Control)(object)txtNgay_ct, Helper.GetMessContent(50034));
			((Control)txtNgay_ct).Focus();
			return false;
		}
		SetControlError((Control)(object)txtNgay_ct, "");
		object value2 = txtNgay_bdau_bp.Value;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0);
		if (Operators.ConditionalCompareObjectEqual(value2, (object)dateTime, false))
		{
			SetControlError((Control)(object)txtNgay_bdau_bp, Helper.GetMessContent(50034));
			((Control)txtNgay_bdau_bp).Focus();
			return false;
		}
		SetControlError((Control)(object)txtNgay_bdau_bp, "");
		object value3 = txtNgay_gtcl.Value;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0);
		if (Operators.ConditionalCompareObjectEqual(value3, (object)dateTime, false))
		{
			SetControlError((Control)(object)txtNgay_gtcl, Helper.GetMessContent(50034));
			((Control)txtNgay_gtcl).Focus();
			return false;
		}
		SetControlError((Control)(object)txtNgay_gtcl, "");
		if (Operators.ConditionalCompareObjectLess(txtNgay_gtcl.Value, txtNgay_bdau_bp.Value, false))
		{
			epNotice.SetError((Control)(object)txtNgay_gtcl, Helper.GetMess(50144).Description);
			((Control)txtNgay_gtcl).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectLessEqual(txtNguyen_gia.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtNguyen_gia, Helper.GetMessContent(50034));
			((Control)txtNguyen_gia).Focus();
			return false;
		}
		SetControlError((Control)(object)txtNguyen_gia, "");
		return base.ValidData();
	}

	protected override bool InsertToDB()
	{
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		try
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(txtMa_cptt.Text);
			arrayList.Add(txtSo_ct.Text);
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay_ct.Value));
			arrayList.Add(txtTen_cptt.Text);
			arrayList.Add(txtDvt.Text);
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtSo_luong.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtDon_gia.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNguyen_gia.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtGia_tri_da_pb.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtGiatri_pn_con_lai.Value));
			arrayList.Add("");
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtSo_ky_BP.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtGiatri_pb_1ky.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay_bdau_bp.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay_gtcl.Value));
			arrayList.Add(((TextBox)txtTK_pb).Text);
			arrayList.Add(((TextBox)txtTK_chiphi).Text);
			arrayList.Add(((TextBox)txtMa_bpsd).Text);
			arrayList.Add(((TextBox)txtMa_spct).Text);
			arrayList.Add(((TextBox)txtMa_phi).Text);
			arrayList.Add(true);
			arrayList.Add(Chk_Giatri_pb1ky.Checked);
			CODMCPTTDAO cODMCPTTDAO = (CODMCPTTDAO)DAOFactory.CreateDAOInstance("CODMCPTTDAO", "CODMCPTT");
			int num = cODMCPTTDAO.InsCPTT(arrayList.ToArray());
			if (num == 0)
			{
				RowToEdit["ID"] = pID;
				result = true;
				return result;
			}
			CMessageBox.Show(num);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.Message);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected override bool UpdateDB()
	{
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		try
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(MyMenuInfo.moduleid);
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtID.Value));
			arrayList.Add(txtMa_cptt.Text);
			arrayList.Add(txtSo_ct.Text);
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay_ct.Value));
			arrayList.Add(txtTen_cptt.Text);
			arrayList.Add(txtDvt.Text);
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtSo_luong.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtDon_gia.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNguyen_gia.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtGia_tri_da_pb.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtGiatri_pn_con_lai.Value));
			arrayList.Add("");
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtSo_ky_BP.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtGiatri_pb_1ky.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay_bdau_bp.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay_gtcl.Value));
			arrayList.Add(((TextBox)txtTK_pb).Text);
			arrayList.Add(((TextBox)txtTK_chiphi).Text);
			arrayList.Add(((TextBox)txtMa_bpsd).Text);
			arrayList.Add(((TextBox)txtMa_spct).Text);
			arrayList.Add(((TextBox)txtMa_phi).Text);
			arrayList.Add(true);
			arrayList.Add(Chk_Giatri_pb1ky.Checked);
			CODMCPTTDAO cODMCPTTDAO = (CODMCPTTDAO)DAOFactory.CreateDAOInstance("CODMCPTTDAO", "CODMCPTT");
			int num = cODMCPTTDAO.UpdCPTT(arrayList.ToArray());
			if (num == 0)
			{
				result = true;
				return result;
			}
			CMessageBox.Show(num);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.Message);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void frmCoDMCPTTEdit_Load(object sender, EventArgs e)
	{
		txtNguyen_gia.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtGia_tri_da_pb.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtGiatri_pn_con_lai.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		txtGiatri_pb_1ky.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
	}

	private void ChkGiatriPb1_KyCheckedChanged(object sender, EventArgs e)
	{
		if (Chk_Giatri_pb1ky.Checked)
		{
			((TextBoxBase)txtGiatri_pb_1ky).ReadOnly = false;
			return;
		}
		ReCalc();
		((TextBoxBase)txtGiatri_pb_1ky).ReadOnly = true;
	}

	private void TxtSoLuongTextChanged(object sender, EventArgs e)
	{
		if (!Chk_Giatri_pb1ky.Checked)
		{
			txtNguyen_gia.Value = Operators.MultiplyObject(txtSo_luong.Value, txtDon_gia.Value);
			txtGiatri_pn_con_lai.Value = Operators.SubtractObject(txtNguyen_gia.Value, txtGia_tri_da_pb.Value);
		}
	}

	private void TxtDonGiaTextChanged(object sender, EventArgs e)
	{
		if (!Chk_Giatri_pb1ky.Checked)
		{
			txtNguyen_gia.Value = Operators.MultiplyObject(txtSo_luong.Value, txtDon_gia.Value);
			txtGiatri_pn_con_lai.Value = Operators.SubtractObject(txtNguyen_gia.Value, txtGia_tri_da_pb.Value);
		}
	}

	private void TxtGiaTriDaPbTextChanged(object sender, EventArgs e)
	{
		if (!Chk_Giatri_pb1ky.Checked)
		{
			txtGiatri_pn_con_lai.Value = Operators.SubtractObject(txtNguyen_gia.Value, txtGia_tri_da_pb.Value);
		}
	}

	private void TxtGiatriPnConLaiTextChanged(object sender, EventArgs e)
	{
		if (!Chk_Giatri_pb1ky.Checked && Operators.ConditionalCompareObjectNotEqual(txtSo_ky_BP.Value, (object)0, false))
		{
			ReCalc();
		}
	}

	private void TxtSoKyBpText_Changed(object sender, EventArgs e)
	{
		if (!Chk_Giatri_pb1ky.Checked)
		{
			ReCalc();
		}
	}

	private void ReCalc()
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtSo_ky_BP.Value, (object)0, false))
		{
			txtGiatri_pb_1ky.Value = Operators.DivideObject(txtNguyen_gia.Value, txtSo_ky_BP.Value);
		}
	}
}
