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
public class frmFADMCCEdit : frmDMComplexEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblMa_cc")]
	private Label _lblMa_cc;

	[AccessedThroughProperty("lblTK_CP")]
	private Label _lblTK_CP;

	[AccessedThroughProperty("lblGT_PB_CL")]
	private Label _lblGT_PB_CL;

	[AccessedThroughProperty("lblTK_PB")]
	private Label _lblTK_PB;

	[AccessedThroughProperty("lblGT_PB_1Ky")]
	private Label _lblGT_PB_1Ky;

	[AccessedThroughProperty("lblGT_DA_PB")]
	private Label _lblGT_DA_PB;

	[AccessedThroughProperty("lblSo_ky_pb")]
	private Label _lblSo_ky_pb;

	[AccessedThroughProperty("lblDVT")]
	private Label _lblDVT;

	[AccessedThroughProperty("lblNguyen_gia")]
	private Label _lblNguyen_gia;

	[AccessedThroughProperty("lblSlg")]
	private Label _lblSlg;

	[AccessedThroughProperty("lblTen_cc")]
	private Label _lblTen_cc;

	[AccessedThroughProperty("lblDon_gia")]
	private Label _lblDon_gia;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("lblMa_bpsd")]
	private Label _lblMa_bpsd;

	[AccessedThroughProperty("lblSo_ct")]
	private Label _lblSo_ct;

	[AccessedThroughProperty("lblNgay_ct")]
	private Label _lblNgay_ct;

	[AccessedThroughProperty("lblNgay_BD_pb")]
	private Label _lblNgay_BD_pb;

	[AccessedThroughProperty("lblMa_phi")]
	private Label _lblMa_phi;

	[AccessedThroughProperty("lblNgay_GTCl")]
	private Label _lblNgay_GTCl;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("txtDvt")]
	private TextBox _txtDvt;

	[AccessedThroughProperty("txtTen_cc")]
	private TextBox _txtTen_cc;

	[AccessedThroughProperty("txtMa_cc")]
	private TextBox _txtMa_cc;

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

	internal virtual Label lblMa_cc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_cc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_cc = value;
		}
	}

	internal virtual Label lblTK_CP
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_CP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_CP = value;
		}
	}

	internal virtual Label lblGT_PB_CL
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGT_PB_CL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGT_PB_CL = value;
		}
	}

	internal virtual Label lblTK_PB
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_PB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_PB = value;
		}
	}

	internal virtual Label lblGT_PB_1Ky
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGT_PB_1Ky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGT_PB_1Ky = value;
		}
	}

	internal virtual Label lblGT_DA_PB
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGT_DA_PB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGT_DA_PB = value;
		}
	}

	internal virtual Label lblSo_ky_pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_ky_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_ky_pb = value;
		}
	}

	internal virtual Label lblDVT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDVT = value;
		}
	}

	internal virtual Label lblNguyen_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguyen_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguyen_gia = value;
		}
	}

	internal virtual Label lblSlg
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSlg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSlg = value;
		}
	}

	internal virtual Label lblTen_cc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_cc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_cc = value;
		}
	}

	internal virtual Label lblDon_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDon_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDon_gia = value;
		}
	}

	internal virtual Label lblMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_spct = value;
		}
	}

	internal virtual Label lblMa_bpsd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_bpsd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_bpsd = value;
		}
	}

	internal virtual Label lblSo_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_ct = value;
		}
	}

	internal virtual Label lblNgay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_ct = value;
		}
	}

	internal virtual Label lblNgay_BD_pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_BD_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_BD_pb = value;
		}
	}

	internal virtual Label lblMa_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_phi = value;
		}
	}

	internal virtual Label lblNgay_GTCl
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_GTCl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_GTCl = value;
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

	internal virtual TextBox txtTen_cc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_cc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_cc = value;
		}
	}

	internal virtual TextBox txtMa_cc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_cc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_cc = value;
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
				((Control)_txtGiatri_pn_con_lai).Validated -= eventHandler;
			}
			_txtGiatri_pn_con_lai = value;
			if (_txtGiatri_pn_con_lai != null)
			{
				((Control)_txtGiatri_pn_con_lai).Validated += eventHandler;
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
			EventHandler eventHandler = ChkGiatriPb1KyCheckedChanged;
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

	[DebuggerNonUserCode]
	public frmFADMCCEdit()
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
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		lblMa_cc = new Label();
		lblDon_gia = new Label();
		lblTen_cc = new Label();
		lblSlg = new Label();
		lblNguyen_gia = new Label();
		lblDVT = new Label();
		lblSo_ky_pb = new Label();
		lblGT_DA_PB = new Label();
		lblGT_PB_1Ky = new Label();
		lblTK_PB = new Label();
		lblGT_PB_CL = new Label();
		lblTK_CP = new Label();
		lblNgay_GTCl = new Label();
		lblMa_phi = new Label();
		lblNgay_BD_pb = new Label();
		lblNgay_ct = new Label();
		lblSo_ct = new Label();
		lblMa_bpsd = new Label();
		lblMa_spct = new Label();
		txtMa_cc = new TextBox();
		txtTen_cc = new TextBox();
		txtDvt = new TextBox();
		txtSo_ct = new TextBox();
		txtTK_pb = new AsTextBox();
		txtTK_chiphi = new AsTextBox();
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
		location = new Point(93, 320);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 320);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)Chk_Giatri_pb1ky);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_gtcl);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_bdau_bp);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtGiatri_pb_1ky);
		((Control)gbLine).Controls.Add((Control)(object)txtGiatri_pn_con_lai);
		((Control)gbLine).Controls.Add((Control)(object)txtGia_tri_da_pb);
		((Control)gbLine).Controls.Add((Control)(object)txtNguyen_gia);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ky_BP);
		((Control)gbLine).Controls.Add((Control)(object)txtDon_gia);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_luong);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_phi);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_spct);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_bpsd);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_chiphi);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_pb);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtDvt);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_cc);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_cc);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_spct);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_bpsd);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_ct);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_BD_pb);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_phi);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_GTCl);
		((Control)gbLine).Controls.Add((Control)(object)lblTK_CP);
		((Control)gbLine).Controls.Add((Control)(object)lblGT_PB_CL);
		((Control)gbLine).Controls.Add((Control)(object)lblTK_PB);
		((Control)gbLine).Controls.Add((Control)(object)lblGT_PB_1Ky);
		((Control)gbLine).Controls.Add((Control)(object)lblGT_DA_PB);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_ky_pb);
		((Control)gbLine).Controls.Add((Control)(object)lblDVT);
		((Control)gbLine).Controls.Add((Control)(object)lblNguyen_gia);
		((Control)gbLine).Controls.Add((Control)(object)lblSlg);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_cc);
		((Control)gbLine).Controls.Add((Control)(object)lblDon_gia);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_cc);
		GroupBox obj3 = gbLine;
		size = new Size(594, 308);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_cc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDon_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_cc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSlg, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNguyen_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDVT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_ky_pb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGT_DA_PB, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGT_PB_1Ky, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK_PB, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGT_PB_CL, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK_CP, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_GTCl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_phi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_BD_pb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_bpsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_cc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_cc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_pb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_chiphi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_bpsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_phi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_luong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDon_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ky_BP, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNguyen_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGia_tri_da_pb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGiatri_pn_con_lai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGiatri_pb_1ky, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_bdau_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_gtcl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Chk_Giatri_pb1ky, 0);
		lblMa_cc.AutoSize = true;
		Label obj4 = lblMa_cc;
		location = new Point(23, 28);
		((Control)obj4).Location = location;
		((Control)lblMa_cc).Name = "lblMa_cc";
		Label obj5 = lblMa_cc;
		size = new Size(64, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_cc).TabIndex = 100;
		lblMa_cc.Text = "Mã công cụ";
		lblDon_gia.AutoSize = true;
		Label obj6 = lblDon_gia;
		location = new Point(23, 126);
		((Control)obj6).Location = location;
		((Control)lblDon_gia).Name = "lblDon_gia";
		Label obj7 = lblDon_gia;
		size = new Size(44, 13);
		((Control)obj7).Size = size;
		((Control)lblDon_gia).TabIndex = 101;
		lblDon_gia.Text = "Đơn giá";
		lblTen_cc.AutoSize = true;
		Label obj8 = lblTen_cc;
		location = new Point(23, 53);
		((Control)obj8).Location = location;
		((Control)lblTen_cc).Name = "lblTen_cc";
		Label obj9 = lblTen_cc;
		size = new Size(68, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_cc).TabIndex = 102;
		lblTen_cc.Text = "Tên công cụ";
		lblSlg.AutoSize = true;
		Label obj10 = lblSlg;
		location = new Point(23, 102);
		((Control)obj10).Location = location;
		((Control)lblSlg).Name = "lblSlg";
		Label obj11 = lblSlg;
		size = new Size(49, 13);
		((Control)obj11).Size = size;
		((Control)lblSlg).TabIndex = 103;
		lblSlg.Text = "Số lượng";
		lblNguyen_gia.AutoSize = true;
		Label obj12 = lblNguyen_gia;
		location = new Point(23, 241);
		((Control)obj12).Location = location;
		((Control)lblNguyen_gia).Name = "lblNguyen_gia";
		Label obj13 = lblNguyen_gia;
		size = new Size(61, 13);
		((Control)obj13).Size = size;
		((Control)lblNguyen_gia).TabIndex = 104;
		lblNguyen_gia.Text = "Nguyên giá";
		lblDVT.AutoSize = true;
		Label obj14 = lblDVT;
		location = new Point(23, 77);
		((Control)obj14).Location = location;
		((Control)lblDVT).Name = "lblDVT";
		Label obj15 = lblDVT;
		size = new Size(24, 13);
		((Control)obj15).Size = size;
		((Control)lblDVT).TabIndex = 105;
		lblDVT.Text = "Đvt";
		lblSo_ky_pb.AutoSize = true;
		Label obj16 = lblSo_ky_pb;
		location = new Point(23, 150);
		((Control)obj16).Location = location;
		((Control)lblSo_ky_pb).Name = "lblSo_ky_pb";
		Label obj17 = lblSo_ky_pb;
		size = new Size(51, 13);
		((Control)obj17).Size = size;
		((Control)lblSo_ky_pb).TabIndex = 106;
		lblSo_ky_pb.Text = "Số kỳ PB";
		lblGT_DA_PB.AutoSize = true;
		Label obj18 = lblGT_DA_PB;
		location = new Point(166, 241);
		((Control)obj18).Location = location;
		((Control)lblGT_DA_PB).Name = "lblGT_DA_PB";
		Label obj19 = lblGT_DA_PB;
		size = new Size(92, 13);
		((Control)obj19).Size = size;
		((Control)lblGT_DA_PB).TabIndex = 107;
		lblGT_DA_PB.Text = "Giá trị đã phân bổ";
		lblGT_PB_1Ky.AutoSize = true;
		Label obj20 = lblGT_PB_1Ky;
		location = new Point(468, 241);
		((Control)obj20).Location = location;
		((Control)lblGT_PB_1Ky).Name = "lblGT_PB_1Ky";
		Label obj21 = lblGT_PB_1Ky;
		size = new Size(99, 13);
		((Control)obj21).Size = size;
		((Control)lblGT_PB_1Ky).TabIndex = 108;
		lblGT_PB_1Ky.Text = "Giá trị phân bổ 1 kỳ";
		lblTK_PB.AutoSize = true;
		Label obj22 = lblTK_PB;
		location = new Point(23, 175);
		((Control)obj22).Location = location;
		((Control)lblTK_PB).Name = "lblTK_PB";
		Label obj23 = lblTK_PB;
		size = new Size(63, 13);
		((Control)obj23).Size = size;
		((Control)lblTK_PB).TabIndex = 109;
		lblTK_PB.Text = "TK phân bổ";
		lblGT_PB_CL.AutoSize = true;
		Label obj24 = lblGT_PB_CL;
		location = new Point(319, 241);
		((Control)obj24).Location = location;
		((Control)lblGT_PB_CL).Name = "lblGT_PB_CL";
		Label obj25 = lblGT_PB_CL;
		size = new Size(110, 13);
		((Control)obj25).Size = size;
		((Control)lblGT_PB_CL).TabIndex = 110;
		lblGT_PB_CL.Text = "Giá trị phân bổ còn lại";
		lblTK_CP.AutoSize = true;
		Label obj26 = lblTK_CP;
		location = new Point(23, 199);
		((Control)obj26).Location = location;
		((Control)lblTK_CP).Name = "lblTK_CP";
		Label obj27 = lblTK_CP;
		size = new Size(57, 13);
		((Control)obj27).Size = size;
		((Control)lblTK_CP).TabIndex = 111;
		lblTK_CP.Text = "TK chi phí";
		lblNgay_GTCl.AutoSize = true;
		Label obj28 = lblNgay_GTCl;
		location = new Point(390, 102);
		((Control)obj28).Location = location;
		((Control)lblNgay_GTCl).Name = "lblNgay_GTCl";
		Label obj29 = lblNgay_GTCl;
		size = new Size(52, 13);
		((Control)obj29).Size = size;
		((Control)lblNgay_GTCl).TabIndex = 112;
		lblNgay_GTCl.Text = "Ngày gtcl";
		lblMa_phi.AutoSize = true;
		Label obj30 = lblMa_phi;
		location = new Point(390, 126);
		((Control)obj30).Location = location;
		((Control)lblMa_phi).Name = "lblMa_phi";
		Label obj31 = lblMa_phi;
		size = new Size(41, 13);
		((Control)obj31).Size = size;
		((Control)lblMa_phi).TabIndex = 113;
		lblMa_phi.Text = "Mã phí";
		lblNgay_BD_pb.AutoSize = true;
		Label obj32 = lblNgay_BD_pb;
		location = new Point(390, 77);
		((Control)obj32).Location = location;
		((Control)lblNgay_BD_pb).Name = "lblNgay_BD_pb";
		Label obj33 = lblNgay_BD_pb;
		size = new Size(87, 13);
		((Control)obj33).Size = size;
		((Control)lblNgay_BD_pb).TabIndex = 114;
		lblNgay_BD_pb.Text = "Ngày bắt đầu pb";
		lblNgay_ct.AutoSize = true;
		Label obj34 = lblNgay_ct;
		location = new Point(390, 53);
		((Control)obj34).Location = location;
		((Control)lblNgay_ct).Name = "lblNgay_ct";
		Label obj35 = lblNgay_ct;
		size = new Size(44, 13);
		((Control)obj35).Size = size;
		((Control)lblNgay_ct).TabIndex = 115;
		lblNgay_ct.Text = "Ngày ct";
		lblSo_ct.AutoSize = true;
		Label obj36 = lblSo_ct;
		location = new Point(390, 28);
		((Control)obj36).Location = location;
		((Control)lblSo_ct).Name = "lblSo_ct";
		Label obj37 = lblSo_ct;
		size = new Size(32, 13);
		((Control)obj37).Size = size;
		((Control)lblSo_ct).TabIndex = 116;
		lblSo_ct.Text = "Số ct";
		lblMa_bpsd.AutoSize = true;
		Label obj38 = lblMa_bpsd;
		location = new Point(390, 175);
		((Control)obj38).Location = location;
		((Control)lblMa_bpsd).Name = "lblMa_bpsd";
		Label obj39 = lblMa_bpsd;
		size = new Size(48, 13);
		((Control)obj39).Size = size;
		((Control)lblMa_bpsd).TabIndex = 118;
		lblMa_bpsd.Text = "Mã bpsd";
		lblMa_spct.AutoSize = true;
		Label obj40 = lblMa_spct;
		location = new Point(390, 150);
		((Control)obj40).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj41 = lblMa_spct;
		size = new Size(45, 13);
		((Control)obj41).Size = size;
		((Control)lblMa_spct).TabIndex = 119;
		lblMa_spct.Text = "Mã spct";
		txtMa_cc.CharacterCasing = (CharacterCasing)1;
		TextBox obj42 = txtMa_cc;
		location = new Point(114, 24);
		((Control)obj42).Location = location;
		((TextBoxBase)txtMa_cc).MaxLength = 20;
		((Control)txtMa_cc).Name = "txtMa_cc";
		TextBox obj43 = txtMa_cc;
		size = new Size(80, 20);
		((Control)obj43).Size = size;
		((Control)txtMa_cc).TabIndex = 0;
		TextBox obj44 = txtTen_cc;
		location = new Point(114, 49);
		((Control)obj44).Location = location;
		((Control)txtTen_cc).Name = "txtTen_cc";
		TextBox obj45 = txtTen_cc;
		size = new Size(259, 20);
		((Control)obj45).Size = size;
		((Control)txtTen_cc).TabIndex = 1;
		TextBox obj46 = txtDvt;
		location = new Point(114, 73);
		((Control)obj46).Location = location;
		((TextBoxBase)txtDvt).MaxLength = 10;
		((Control)txtDvt).Name = "txtDvt";
		TextBox obj47 = txtDvt;
		size = new Size(80, 20);
		((Control)obj47).Size = size;
		((Control)txtDvt).TabIndex = 2;
		TextBox obj48 = txtSo_ct;
		location = new Point(487, 24);
		((Control)obj48).Location = location;
		((TextBoxBase)txtSo_ct).MaxLength = 12;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj49 = txtSo_ct;
		size = new Size(80, 20);
		((Control)obj49).Size = size;
		((Control)txtSo_ct).TabIndex = 8;
		txtTK_pb.AutoLookup = true;
		txtTK_pb.AutoValid = true;
		((TextBoxBase)txtTK_pb).BackColor = SystemColors.Info;
		((TextBox)txtTK_pb).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTK_pb;
		location = new Point(114, 171);
		((Control)asTextBox).Location = location;
		txtTK_pb.LookupCodeName = "TK";
		txtTK_pb.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTK_pb).Name = "txtTK_pb";
		txtTK_pb.NameControl = null;
		AsTextBox asTextBox2 = txtTK_pb;
		size = new Size(80, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTK_pb).TabIndex = 6;
		txtTK_pb.UseAutoCompleteSource = true;
		txtTK_chiphi.AutoLookup = true;
		txtTK_chiphi.AutoValid = true;
		((TextBoxBase)txtTK_chiphi).BackColor = SystemColors.Info;
		((TextBox)txtTK_chiphi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTK_chiphi;
		location = new Point(114, 195);
		((Control)asTextBox3).Location = location;
		txtTK_chiphi.LookupCodeName = "TK";
		txtTK_chiphi.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTK_chiphi).Name = "txtTK_chiphi";
		txtTK_chiphi.NameControl = null;
		AsTextBox asTextBox4 = txtTK_chiphi;
		size = new Size(80, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTK_chiphi).TabIndex = 7;
		txtTK_chiphi.UseAutoCompleteSource = true;
		txtMa_bpsd.AutoLookup = true;
		txtMa_bpsd.AutoValid = true;
		((TextBoxBase)txtMa_bpsd).BackColor = SystemColors.Info;
		((TextBox)txtMa_bpsd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_bpsd;
		location = new Point(487, 171);
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
		location = new Point(487, 146);
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
		location = new Point(487, 122);
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
		location = new Point(114, 98);
		((Control)asTextNumeric).Location = location;
		txtSo_luong.Mask = "### ### ###";
		((Control)txtSo_luong).Name = "txtSo_luong";
		AsTextNumeric asTextNumeric2 = txtSo_luong;
		size = new Size(80, 20);
		((Control)asTextNumeric2).Size = size;
		txtSo_luong.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSo_luong).TabIndex = 3;
		((Control)txtSo_luong).Tag = "QT";
		((TextBox)txtSo_luong).Text = "0";
		((TextBox)txtSo_luong).TextAlign = (HorizontalAlignment)1;
		txtSo_luong.Value = 0;
		txtDon_gia.DecimalSymbol = ".";
		txtDon_gia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtDon_gia;
		location = new Point(114, 122);
		((Control)asTextNumeric3).Location = location;
		txtDon_gia.Mask = "### ### ###";
		((Control)txtDon_gia).Name = "txtDon_gia";
		AsTextNumeric asTextNumeric4 = txtDon_gia;
		size = new Size(80, 20);
		((Control)asTextNumeric4).Size = size;
		txtDon_gia.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtDon_gia).TabIndex = 4;
		((Control)txtDon_gia).Tag = "OP";
		((TextBox)txtDon_gia).Text = "0";
		((TextBox)txtDon_gia).TextAlign = (HorizontalAlignment)1;
		txtDon_gia.Value = 0;
		txtSo_ky_BP.DecimalSymbol = ".";
		txtSo_ky_BP.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtSo_ky_BP;
		location = new Point(114, 146);
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
		txtSo_ky_BP.Value = 0;
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
		((Control)txtNguyen_gia).TabIndex = 15;
		((Control)txtNguyen_gia).Tag = "OA";
		((TextBox)txtNguyen_gia).Text = "0.00";
		((TextBox)txtNguyen_gia).TextAlign = (HorizontalAlignment)1;
		txtNguyen_gia.Value = 0;
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
		((Control)txtGia_tri_da_pb).TabIndex = 16;
		((Control)txtGia_tri_da_pb).Tag = "OA";
		((TextBox)txtGia_tri_da_pb).Text = "0.00";
		((TextBox)txtGia_tri_da_pb).TextAlign = (HorizontalAlignment)1;
		txtGia_tri_da_pb.Value = 0;
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
		((Control)txtGiatri_pn_con_lai).TabIndex = 17;
		((Control)txtGiatri_pn_con_lai).Tag = "OA";
		((TextBox)txtGiatri_pn_con_lai).Text = "0.00";
		((TextBox)txtGiatri_pn_con_lai).TextAlign = (HorizontalAlignment)1;
		txtGiatri_pn_con_lai.Value = 0;
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
		((Control)txtGiatri_pb_1ky).TabIndex = 18;
		((Control)txtGiatri_pb_1ky).Tag = "OA";
		((TextBox)txtGiatri_pb_1ky).Text = "0.00";
		((TextBox)txtGiatri_pb_1ky).TextAlign = (HorizontalAlignment)1;
		txtGiatri_pb_1ky.Value = 0;
		txtNgay_ct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct;
		location = new Point(487, 49);
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
		location = new Point(487, 73);
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
		location = new Point(487, 98);
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
		location = new Point(468, 215);
		((Control)chk_Giatri_pb1ky).Location = location;
		((Control)Chk_Giatri_pb1ky).Name = "Chk_Giatri_pb1ky";
		CheckBox chk_Giatri_pb1ky2 = Chk_Giatri_pb1ky;
		size = new Size(87, 17);
		((Control)chk_Giatri_pb1ky2).Size = size;
		((Control)Chk_Giatri_pb1ky).TabIndex = 120;
		((ButtonBase)Chk_Giatri_pb1ky).Text = "Sửa phân bổ";
		((ButtonBase)Chk_Giatri_pb1ky).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(618, 355);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFADMCCEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		MaskTextBoxAll(((Control)gbLine).Controls);
		((TextBoxBase)txtMa_cc).MaxLength = MyDictComplexInfo.code_length;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct;
		DateTime dateTime = new DateTime(DateAndTime.Now.Year, DateAndTime.Now.Month, DateAndTime.Now.Day, 0, 0, 0, 0);
		asMaskedTextBox.Value = dateTime;
		((Control)txtMa_cc).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_cc).Enabled = false;
		((Control)txtTen_cc).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_cc;
		CreateDataBinding(ref ojb, "ma_cc");
		txtMa_cc = (TextBox)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "so_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)txtNgay_ct;
		CreateDataBinding(ref ojb, "ngay_ct", "Value");
		txtNgay_ct = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtTen_cc;
		CreateDataBinding(ref ojb, "ten_cc");
		txtTen_cc = (TextBox)ojb;
		ojb = (Control)(object)txtDvt;
		CreateDataBinding(ref ojb, "dvt");
		txtDvt = (TextBox)ojb;
		ojb = (Control)(object)txtSo_luong;
		CreateDataBinding(ref ojb, "so_luong", "Value");
		txtSo_luong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDon_gia;
		CreateDataBinding(ref ojb, "don_gia", "Value");
		txtDon_gia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtNguyen_gia;
		CreateDataBinding(ref ojb, "ng_gia", "Value");
		txtNguyen_gia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGia_tri_da_pb;
		CreateDataBinding(ref ojb, "gt_da_kh", "Value");
		txtGia_tri_da_pb = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGiatri_pn_con_lai;
		CreateDataBinding(ref ojb, "gt_cl", "Value");
		txtGiatri_pn_con_lai = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSo_ky_BP;
		CreateDataBinding(ref ojb, "so_ky", "Value");
		txtSo_ky_BP = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGiatri_pb_1ky;
		CreateDataBinding(ref ojb, "kh_ky", "Value");
		txtGiatri_pb_1ky = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtNgay_bdau_bp;
		CreateDataBinding(ref ojb, "ngay_bdkh", "Value");
		txtNgay_bdau_bp = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_gtcl;
		CreateDataBinding(ref ojb, "ngay_gt_cl", "Value");
		txtNgay_gtcl = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtTK_pb;
		CreateDataBinding(ref ojb, "tk_cc");
		txtTK_pb = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTK_chiphi;
		CreateDataBinding(ref ojb, "tk_cp");
		txtTK_chiphi = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_bpsd;
		CreateDataBinding(ref ojb, "ma_bpsd");
		txtMa_bpsd = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_spct;
		CreateDataBinding(ref ojb, "ma_spct");
		txtMa_spct = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_phi;
		CreateDataBinding(ref ojb, "ma_phi");
		txtMa_phi = (AsTextBox)(object)ojb;
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
	}

	protected override bool ValidData()
	{
		base.ValidData();
		if (Operators.CompareString(txtMa_cc.Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtMa_cc, Helper.GetMessContent(50002));
			((Control)txtMa_cc).Focus();
			return false;
		}
		if (Operators.CompareString(txtTen_cc.Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtTen_cc, Helper.GetMessContent(50002));
			((Control)txtTen_cc).Focus();
			return false;
		}
		if (Operators.ConditionalCompareObjectLessEqual(txtSo_luong.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtSo_luong, Helper.GetMessContent(50034));
			((Control)txtSo_luong).Focus();
			return false;
		}
		if (Operators.ConditionalCompareObjectLessEqual(txtSo_ky_BP.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtSo_ky_BP, Helper.GetMessContent(50034));
			((Control)txtSo_ky_BP).Focus();
			return false;
		}
		if (Operators.CompareString(((TextBox)txtTK_pb).Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtTK_pb, Helper.GetMessContent(50002));
			((Control)txtTK_pb).Focus();
			return false;
		}
		if (Operators.CompareString(((TextBox)txtTK_chiphi).Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtTK_chiphi, Helper.GetMessContent(50002));
			((Control)txtTK_chiphi).Focus();
			return false;
		}
		if (Operators.ConditionalCompareObjectLessEqual(txtNguyen_gia.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtNguyen_gia, Helper.GetMessContent(50034));
			((Control)txtNguyen_gia).Focus();
			return false;
		}
		object value = txtNgay_bdau_bp.Value;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0);
		if (Operators.ConditionalCompareObjectEqual(value, (object)dateTime, false))
		{
			SetControlError((Control)(object)txtNgay_bdau_bp, Helper.GetMessContent(50034));
			((Control)txtNgay_bdau_bp).Focus();
			return false;
		}
		object value2 = txtNgay_gtcl.Value;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0);
		if (Operators.ConditionalCompareObjectEqual(value2, (object)dateTime, false))
		{
			SetControlError((Control)(object)txtNgay_gtcl, Helper.GetMessContent(50034));
			((Control)txtNgay_gtcl).Focus();
			return false;
		}
		object value3 = txtNgay_ct.Value;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0);
		if (Operators.ConditionalCompareObjectEqual(value3, (object)dateTime, false))
		{
			SetControlError((Control)(object)txtNgay_ct, Helper.GetMessContent(50034));
			((Control)txtNgay_ct).Focus();
			return false;
		}
		return true;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_cc).Select();
		}
		return flag;
	}

	protected override bool SetToRow()
	{
		base.SetToRow();
		RowToEdit["stt_rec"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["stt_rec"]), isNum: true), (object)"", false), (object)Commons.Get_SttRec("FAC"), RuntimeHelpers.GetObjectValue(RowToEdit["stt_rec"])));
		bool result = default(bool);
		return result;
	}

	private void ReCalc()
	{
		if (Conversions.ToDouble(AsiaErp.Framework.Environment.GetFAConfiguration().kieu_tinh_kh) == 1.0)
		{
			if (Operators.ConditionalCompareObjectNotEqual(txtSo_ky_BP.Value, (object)0, false))
			{
				txtGiatri_pb_1ky.Value = Operators.DivideObject(txtGiatri_pn_con_lai.Value, txtSo_ky_BP.Value);
			}
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtSo_ky_BP.Value, (object)0, false))
		{
			txtGiatri_pb_1ky.Value = Operators.DivideObject(txtNguyen_gia.Value, txtSo_ky_BP.Value);
		}
	}

	private void MaskTextBoxAll(ControlCollection ctl)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (Control item in ctl)
		{
			Control val = item;
			if (val is AsTextNumeric)
			{
				AsTextNumeric asTextNumeric = (AsTextNumeric)(object)val;
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCPrice_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"QT", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format;
				}
			}
		}
	}

	private void ChkGiatriPb1KyCheckedChanged(object sender, EventArgs e)
	{
		if (Chk_Giatri_pb1ky.Checked)
		{
			((TextBoxBase)txtGiatri_pb_1ky).ReadOnly = false;
		}
		else
		{
			((TextBoxBase)txtGiatri_pb_1ky).ReadOnly = true;
		}
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
}
