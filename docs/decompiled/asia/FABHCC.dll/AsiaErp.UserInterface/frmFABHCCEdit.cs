using System;
using System.ComponentModel;
using System.Data;
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
public class frmFABHCCEdit : frmDMEdit
{
	private IContainer components;

	[AccessedThroughProperty("txtSo_px")]
	private TextBox _txtSo_px;

	[AccessedThroughProperty("txtDVT")]
	private TextBox _txtDVT;

	[AccessedThroughProperty("txtDon_gia_hong")]
	private AsTextNumeric _txtDon_gia_hong;

	[AccessedThroughProperty("txtGia_goc")]
	private AsTextNumeric _txtGia_goc;

	[AccessedThroughProperty("lblMa_bpsd")]
	private Label _lblMa_bpsd;

	[AccessedThroughProperty("lblNgay_xuat")]
	private Label _lblNgay_xuat;

	[AccessedThroughProperty("lblDVT")]
	private Label _lblDVT;

	[AccessedThroughProperty("lblSo_px")]
	private Label _lblSo_px;

	[AccessedThroughProperty("lblGia_goc")]
	private Label _lblGia_goc;

	[AccessedThroughProperty("lblDg_hong")]
	private Label _lblDg_hong;

	[AccessedThroughProperty("txtNgay_xuat")]
	private AsMaskedTextBox _txtNgay_xuat;

	[AccessedThroughProperty("txtMa_bpsd")]
	private TextBox _txtMa_bpsd;

	[AccessedThroughProperty("lblCon_Lai")]
	private Label _lblCon_Lai;

	[AccessedThroughProperty("txtSl_hong")]
	private AsTextNumeric _txtSl_hong;

	[AccessedThroughProperty("txtMa_tkcc")]
	private TextBox _txtMa_tkcc;

	[AccessedThroughProperty("txtTien_hong")]
	private AsTextNumeric _txtTien_hong;

	[AccessedThroughProperty("txtMa_cc")]
	private AsTextBox _txtMa_cc;

	[AccessedThroughProperty("lblTen_cc")]
	private Label _lblTen_cc;

	[AccessedThroughProperty("txtMa_tkcp")]
	private AsTextBox _txtMa_tkcp;

	[AccessedThroughProperty("lblTen_tkcp")]
	private Label _lblTen_tkcp;

	[AccessedThroughProperty("lblNgay_bh")]
	private Label _lblNgay_bh;

	[AccessedThroughProperty("lblTk_Pb")]
	private Label _lblTk_Pb;

	[AccessedThroughProperty("lblTK_cp")]
	private Label _lblTK_cp;

	[AccessedThroughProperty("lblMa_cc")]
	private Label _lblMa_cc;

	[AccessedThroughProperty("lblTien_hong")]
	private Label _lblTien_hong;

	[AccessedThroughProperty("lblSl_hong")]
	private Label _lblSl_hong;

	[AccessedThroughProperty("txtNgay_bh")]
	private AsMaskedTextBox _txtNgay_bh;

	[AccessedThroughProperty("lblF5Info")]
	private Label _lblF5Info;

	[AccessedThroughProperty("txtSTT_REC_CC")]
	private AsTextBox _txtSTT_REC_CC;

	private DataTable f_tblCC;

	internal virtual TextBox txtSo_px
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_px;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_px = value;
		}
	}

	internal virtual TextBox txtDVT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDVT = value;
		}
	}

	internal virtual AsTextNumeric txtDon_gia_hong
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDon_gia_hong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDon_gia_hong = value;
		}
	}

	internal virtual AsTextNumeric txtGia_goc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGia_goc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGia_goc = value;
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

	internal virtual Label lblNgay_xuat
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_xuat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_xuat = value;
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

	internal virtual Label lblSo_px
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_px;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_px = value;
		}
	}

	internal virtual Label lblGia_goc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGia_goc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGia_goc = value;
		}
	}

	internal virtual Label lblDg_hong
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDg_hong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDg_hong = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_xuat
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_xuat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_xuat = value;
		}
	}

	internal virtual TextBox txtMa_bpsd
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

	internal virtual Label lblCon_Lai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCon_Lai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCon_Lai = value;
		}
	}

	internal virtual AsTextNumeric txtSl_hong
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSl_hong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CancelEventHandler cancelEventHandler = txtSl_hong_Validating;
			if (_txtSl_hong != null)
			{
				((Control)_txtSl_hong).Validating -= cancelEventHandler;
			}
			_txtSl_hong = value;
			if (_txtSl_hong != null)
			{
				((Control)_txtSl_hong).Validating += cancelEventHandler;
			}
		}
	}

	internal virtual TextBox txtMa_tkcc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_tkcc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_tkcc = value;
		}
	}

	internal virtual AsTextNumeric txtTien_hong
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_hong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTien_hong = value;
		}
	}

	internal virtual AsTextBox txtMa_cc
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(txtMa_cc_KeyDown);
			KeyPressEventHandler val2 = new KeyPressEventHandler(txtMa_cc_KeyPress);
			EventHandler eventHandler = txtMa_cc_Validated;
			if (_txtMa_cc != null)
			{
				((Control)_txtMa_cc).KeyDown -= val;
				((Control)_txtMa_cc).KeyPress -= val2;
				((Control)_txtMa_cc).Validated -= eventHandler;
			}
			_txtMa_cc = value;
			if (_txtMa_cc != null)
			{
				((Control)_txtMa_cc).KeyDown += val;
				((Control)_txtMa_cc).KeyPress += val2;
				((Control)_txtMa_cc).Validated += eventHandler;
			}
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

	internal virtual AsTextBox txtMa_tkcp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_tkcp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_tkcp = value;
		}
	}

	internal virtual Label lblTen_tkcp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tkcp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tkcp = value;
		}
	}

	internal virtual Label lblNgay_bh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_bh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_bh = value;
		}
	}

	internal virtual Label lblTk_Pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Pb = value;
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

	internal virtual Label lblTien_hong
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTien_hong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTien_hong = value;
		}
	}

	internal virtual Label lblSl_hong
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSl_hong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSl_hong = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_bh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_bh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_bh = value;
		}
	}

	internal virtual Label lblF5Info
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblF5Info;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblF5Info = value;
		}
	}

	internal virtual AsTextBox txtSTT_REC_CC
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSTT_REC_CC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSTT_REC_CC = value;
		}
	}

	[DebuggerNonUserCode]
	public frmFABHCCEdit()
	{
		((Form)this).Load += frmFABHCCEdit_Load;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_1499: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a3: Expected O, but got Unknown
		txtSo_px = new TextBox();
		lblSo_px = new Label();
		txtNgay_xuat = new AsMaskedTextBox();
		lblNgay_xuat = new Label();
		lblMa_bpsd = new Label();
		lblDg_hong = new Label();
		txtDon_gia_hong = new AsTextNumeric();
		lblGia_goc = new Label();
		txtGia_goc = new AsTextNumeric();
		lblDVT = new Label();
		txtDVT = new TextBox();
		txtMa_bpsd = new TextBox();
		lblCon_Lai = new Label();
		txtSl_hong = new AsTextNumeric();
		txtMa_tkcc = new TextBox();
		txtTien_hong = new AsTextNumeric();
		txtMa_cc = new AsTextBox();
		lblTen_cc = new Label();
		txtMa_tkcp = new AsTextBox();
		lblTen_tkcp = new Label();
		lblNgay_bh = new Label();
		lblTk_Pb = new Label();
		lblTK_cp = new Label();
		lblMa_cc = new Label();
		lblTien_hong = new Label();
		lblSl_hong = new Label();
		txtNgay_bh = new AsMaskedTextBox();
		lblF5Info = new Label();
		txtSTT_REC_CC = new AsTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(549, 344);
		((Control)asCheckBox).Location = location;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 274);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 274);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtSTT_REC_CC);
		((Control)gbLine).Controls.Add((Control)(object)lblCon_Lai);
		((Control)gbLine).Controls.Add((Control)(object)txtSl_hong);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_tkcc);
		((Control)gbLine).Controls.Add((Control)(object)txtTien_hong);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_cc);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_tkcp);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_bh);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Pb);
		((Control)gbLine).Controls.Add((Control)(object)lblTK_cp);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_cc);
		((Control)gbLine).Controls.Add((Control)(object)lblTien_hong);
		((Control)gbLine).Controls.Add((Control)(object)lblSl_hong);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tkcp);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_cc);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_bh);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_px);
		((Control)gbLine).Controls.Add((Control)(object)txtDVT);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_px);
		((Control)gbLine).Controls.Add((Control)(object)txtDon_gia_hong);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_bpsd);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_xuat);
		((Control)gbLine).Controls.Add((Control)(object)txtGia_goc);
		((Control)gbLine).Controls.Add((Control)(object)lblDVT);
		((Control)gbLine).Controls.Add((Control)(object)lblGia_goc);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_bpsd);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_xuat);
		((Control)gbLine).Controls.Add((Control)(object)lblDg_hong);
		GroupBox obj3 = gbLine;
		Size size = new Size(556, 262);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDg_hong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_xuat, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_bpsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGia_goc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDVT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGia_goc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_xuat, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_bpsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDon_gia_hong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_px, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDVT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_px, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_bh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_cc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tkcp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSl_hong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTien_hong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_cc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK_cp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Pb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_bh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_tkcp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_cc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTien_hong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_tkcc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSl_hong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblCon_Lai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSTT_REC_CC, 0);
		((Control)txtSo_px).Enabled = false;
		TextBox obj4 = txtSo_px;
		location = new Point(96, 175);
		((Control)obj4).Location = location;
		((Control)txtSo_px).Name = "txtSo_px";
		TextBox obj5 = txtSo_px;
		size = new Size(100, 20);
		((Control)obj5).Size = size;
		((Control)txtSo_px).TabIndex = 6;
		lblSo_px.AutoSize = true;
		Label obj6 = lblSo_px;
		location = new Point(9, 179);
		((Control)obj6).Location = location;
		((Control)lblSo_px).Name = "lblSo_px";
		Label obj7 = lblSo_px;
		size = new Size(72, 13);
		((Control)obj7).Size = size;
		((Control)lblSo_px).TabIndex = 100;
		lblSo_px.Text = "Số phiếu xuất";
		((Control)txtNgay_xuat).Enabled = false;
		txtNgay_xuat.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_xuat).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_xuat;
		location = new Point(96, 202);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_xuat).Mask = "##/##/####";
		((Control)txtNgay_xuat).Name = "txtNgay_xuat";
		((MaskedTextBox)txtNgay_xuat).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_xuat;
		size = new Size(100, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_xuat).TabIndex = 7;
		((MaskedTextBox)txtNgay_xuat).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_xuat;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		lblNgay_xuat.AutoSize = true;
		Label obj8 = lblNgay_xuat;
		location = new Point(9, 206);
		((Control)obj8).Location = location;
		((Control)lblNgay_xuat).Name = "lblNgay_xuat";
		Label obj9 = lblNgay_xuat;
		size = new Size(55, 13);
		((Control)obj9).Size = size;
		((Control)lblNgay_xuat).TabIndex = 100;
		lblNgay_xuat.Text = "Ngày xuất";
		lblMa_bpsd.AutoSize = true;
		Label obj10 = lblMa_bpsd;
		location = new Point(9, 232);
		((Control)obj10).Location = location;
		((Control)lblMa_bpsd).Name = "lblMa_bpsd";
		Label obj11 = lblMa_bpsd;
		size = new Size(48, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_bpsd).TabIndex = 100;
		lblMa_bpsd.Text = "Mã bpsd";
		lblDg_hong.AutoSize = true;
		Label obj12 = lblDg_hong;
		location = new Point(356, 179);
		((Control)obj12).Location = location;
		((Control)lblDg_hong).Name = "lblDg_hong";
		Label obj13 = lblDg_hong;
		size = new Size(71, 13);
		((Control)obj13).Size = size;
		((Control)lblDg_hong).TabIndex = 100;
		lblDg_hong.Text = "Đơn giá hỏng";
		txtDon_gia_hong.DecimalSymbol = ".";
		((Control)txtDon_gia_hong).Enabled = false;
		txtDon_gia_hong.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtDon_gia_hong;
		location = new Point(442, 175);
		((Control)asTextNumeric).Location = location;
		txtDon_gia_hong.Mask = "### ### ### ###.##";
		((Control)txtDon_gia_hong).Name = "txtDon_gia_hong";
		AsTextNumeric asTextNumeric2 = txtDon_gia_hong;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		txtDon_gia_hong.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtDon_gia_hong).TabIndex = 9;
		((Control)txtDon_gia_hong).Tag = "OA";
		((TextBox)txtDon_gia_hong).Text = "0.00";
		((TextBox)txtDon_gia_hong).TextAlign = (HorizontalAlignment)1;
		txtDon_gia_hong.Value = 0;
		lblGia_goc.AutoSize = true;
		Label obj14 = lblGia_goc;
		location = new Point(356, 206);
		((Control)obj14).Location = location;
		((Control)lblGia_goc).Name = "lblGia_goc";
		Label obj15 = lblGia_goc;
		size = new Size(44, 13);
		((Control)obj15).Size = size;
		((Control)lblGia_goc).TabIndex = 100;
		lblGia_goc.Text = "Giá gốc";
		txtGia_goc.DecimalSymbol = ".";
		((Control)txtGia_goc).Enabled = false;
		txtGia_goc.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtGia_goc;
		location = new Point(442, 202);
		((Control)asTextNumeric3).Location = location;
		txtGia_goc.Mask = "### ### ### ###.##";
		((Control)txtGia_goc).Name = "txtGia_goc";
		AsTextNumeric asTextNumeric4 = txtGia_goc;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		txtGia_goc.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGia_goc).TabIndex = 10;
		((Control)txtGia_goc).Tag = "OA";
		((TextBox)txtGia_goc).Text = "0.00";
		((TextBox)txtGia_goc).TextAlign = (HorizontalAlignment)1;
		txtGia_goc.Value = 0;
		lblDVT.AutoSize = true;
		Label obj16 = lblDVT;
		location = new Point(356, 232);
		((Control)obj16).Location = location;
		((Control)lblDVT).Name = "lblDVT";
		Label obj17 = lblDVT;
		size = new Size(60, 13);
		((Control)obj17).Size = size;
		((Control)lblDVT).TabIndex = 100;
		lblDVT.Text = "Đơn vị tính";
		((Control)txtDVT).Enabled = false;
		TextBox obj18 = txtDVT;
		location = new Point(442, 228);
		((Control)obj18).Location = location;
		((Control)txtDVT).Name = "txtDVT";
		TextBox obj19 = txtDVT;
		size = new Size(100, 20);
		((Control)obj19).Size = size;
		((Control)txtDVT).TabIndex = 11;
		((Control)txtMa_bpsd).Enabled = false;
		TextBox obj20 = txtMa_bpsd;
		location = new Point(96, 228);
		((Control)obj20).Location = location;
		((Control)txtMa_bpsd).Name = "txtMa_bpsd";
		TextBox obj21 = txtMa_bpsd;
		size = new Size(100, 20);
		((Control)obj21).Size = size;
		((Control)txtMa_bpsd).TabIndex = 8;
		lblCon_Lai.AutoSize = true;
		Label obj22 = lblCon_Lai;
		location = new Point(202, 75);
		((Control)obj22).Location = location;
		((Control)lblCon_Lai).Name = "lblCon_Lai";
		Label obj23 = lblCon_Lai;
		size = new Size(54, 13);
		((Control)obj23).Size = size;
		((Control)lblCon_Lai).TabIndex = 131;
		lblCon_Lai.Text = "Còn lại : 0";
		txtSl_hong.DecimalSymbol = ".";
		txtSl_hong.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtSl_hong;
		location = new Point(96, 71);
		((Control)asTextNumeric5).Location = location;
		txtSl_hong.Mask = "### ### ### ###";
		((Control)txtSl_hong).Name = "txtSl_hong";
		AsTextNumeric asTextNumeric6 = txtSl_hong;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		txtSl_hong.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSl_hong).TabIndex = 2;
		((TextBox)txtSl_hong).Text = "0";
		((TextBox)txtSl_hong).TextAlign = (HorizontalAlignment)1;
		txtSl_hong.Value = 0;
		((Control)txtMa_tkcc).Enabled = false;
		TextBox obj24 = txtMa_tkcc;
		location = new Point(96, 149);
		((Control)obj24).Location = location;
		((Control)txtMa_tkcc).Name = "txtMa_tkcc";
		TextBox obj25 = txtMa_tkcc;
		size = new Size(100, 20);
		((Control)obj25).Size = size;
		((Control)txtMa_tkcc).TabIndex = 5;
		txtTien_hong.DecimalSymbol = ".";
		txtTien_hong.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtTien_hong;
		location = new Point(96, 97);
		((Control)asTextNumeric7).Location = location;
		txtTien_hong.Mask = "### ### ### ###.##";
		((Control)txtTien_hong).Name = "txtTien_hong";
		AsTextNumeric asTextNumeric8 = txtTien_hong;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		txtTien_hong.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTien_hong).TabIndex = 3;
		((Control)txtTien_hong).Tag = "OA";
		((TextBox)txtTien_hong).Text = "0.00";
		((TextBox)txtTien_hong).TextAlign = (HorizontalAlignment)1;
		txtTien_hong.Value = 0;
		txtMa_cc.AutoLookup = false;
		txtMa_cc.AutoValid = false;
		((TextBoxBase)txtMa_cc).BackColor = SystemColors.Info;
		((TextBox)txtMa_cc).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_cc;
		location = new Point(96, 45);
		((Control)asTextBox).Location = location;
		txtMa_cc.LookupCodeName = "";
		((Control)txtMa_cc).Name = "txtMa_cc";
		txtMa_cc.NameControl = null;
		AsTextBox asTextBox2 = txtMa_cc;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_cc).TabIndex = 1;
		txtMa_cc.UseAutoCompleteSource = true;
		Label obj26 = lblTen_cc;
		location = new Point(202, 49);
		((Control)obj26).Location = location;
		((Control)lblTen_cc).Name = "lblTen_cc";
		Label obj27 = lblTen_cc;
		size = new Size(235, 13);
		((Control)obj27).Size = size;
		((Control)lblTen_cc).TabIndex = 125;
		txtMa_tkcp.AutoLookup = true;
		txtMa_tkcp.AutoValid = true;
		((TextBoxBase)txtMa_tkcp).BackColor = SystemColors.Info;
		((TextBox)txtMa_tkcp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_tkcp;
		location = new Point(96, 123);
		((Control)asTextBox3).Location = location;
		txtMa_tkcp.LookupCodeName = "TK";
		txtMa_tkcp.LookupWhereCondition = "CHI_TIET='1'";
		((Control)txtMa_tkcp).Name = "txtMa_tkcp";
		txtMa_tkcp.NameControl = lblTen_tkcp;
		AsTextBox asTextBox4 = txtMa_tkcp;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_tkcp).TabIndex = 4;
		txtMa_tkcp.UseAutoCompleteSource = true;
		Label obj28 = lblTen_tkcp;
		location = new Point(202, 127);
		((Control)obj28).Location = location;
		((Control)lblTen_tkcp).Name = "lblTen_tkcp";
		Label obj29 = lblTen_tkcp;
		size = new Size(235, 13);
		((Control)obj29).Size = size;
		((Control)lblTen_tkcp).TabIndex = 126;
		lblNgay_bh.AutoSize = true;
		Label obj30 = lblNgay_bh;
		location = new Point(9, 23);
		((Control)obj30).Location = location;
		((Control)lblNgay_bh).Name = "lblNgay_bh";
		Label obj31 = lblNgay_bh;
		size = new Size(80, 13);
		((Control)obj31).Size = size;
		((Control)lblNgay_bh).TabIndex = 128;
		lblNgay_bh.Text = "Ngày báo hỏng";
		lblTk_Pb.AutoSize = true;
		Label obj32 = lblTk_Pb;
		location = new Point(9, 153);
		((Control)obj32).Location = location;
		((Control)lblTk_Pb).Name = "lblTk_Pb";
		Label obj33 = lblTk_Pb;
		size = new Size(63, 13);
		((Control)obj33).Size = size;
		((Control)lblTk_Pb).TabIndex = 127;
		lblTk_Pb.Text = "TK phân bổ";
		lblTK_cp.AutoSize = true;
		Label obj34 = lblTK_cp;
		location = new Point(9, 127);
		((Control)obj34).Location = location;
		((Control)lblTK_cp).Name = "lblTK_cp";
		Label obj35 = lblTK_cp;
		size = new Size(57, 13);
		((Control)obj35).Size = size;
		((Control)lblTK_cp).TabIndex = 130;
		lblTK_cp.Text = "TK chi phí";
		lblMa_cc.AutoSize = true;
		Label obj36 = lblMa_cc;
		location = new Point(9, 49);
		((Control)obj36).Location = location;
		((Control)lblMa_cc).Name = "lblMa_cc";
		Label obj37 = lblMa_cc;
		size = new Size(64, 13);
		((Control)obj37).Size = size;
		((Control)lblMa_cc).TabIndex = 129;
		lblMa_cc.Text = "Mã công cụ";
		lblTien_hong.AutoSize = true;
		Label obj38 = lblTien_hong;
		location = new Point(9, 101);
		((Control)obj38).Location = location;
		((Control)lblTien_hong).Name = "lblTien_hong";
		Label obj39 = lblTien_hong;
		size = new Size(55, 13);
		((Control)obj39).Size = size;
		((Control)lblTien_hong).TabIndex = 124;
		lblTien_hong.Text = "Tiền hỏng";
		lblSl_hong.AutoSize = true;
		Label obj40 = lblSl_hong;
		location = new Point(9, 75);
		((Control)obj40).Location = location;
		((Control)lblSl_hong).Name = "lblSl_hong";
		Label obj41 = lblSl_hong;
		size = new Size(76, 13);
		((Control)obj41).Size = size;
		((Control)lblSl_hong).TabIndex = 123;
		lblSl_hong.Text = "Số lượng hỏng";
		txtNgay_bh.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_bh).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_bh;
		location = new Point(96, 19);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_bh).Mask = "##/##/####";
		((Control)txtNgay_bh).Name = "txtNgay_bh";
		((MaskedTextBox)txtNgay_bh).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_bh;
		size = new Size(100, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_bh).TabIndex = 0;
		((MaskedTextBox)txtNgay_bh).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_bh;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		lblF5Info.AutoSize = true;
		((Control)lblF5Info).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj42 = lblF5Info;
		location = new Point(341, 282);
		((Control)obj42).Location = location;
		((Control)lblF5Info).Name = "lblF5Info";
		Label obj43 = lblF5Info;
		size = new Size(227, 15);
		((Control)obj43).Size = size;
		((Control)lblF5Info).TabIndex = 132;
		lblF5Info.Text = "* F5 - Tra cứu mã công cụ dụng cụ";
		txtSTT_REC_CC.AutoLookup = true;
		txtSTT_REC_CC.AutoValid = true;
		((TextBoxBase)txtSTT_REC_CC).BackColor = SystemColors.Info;
		((TextBox)txtSTT_REC_CC).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtSTT_REC_CC;
		location = new Point(359, 46);
		((Control)asTextBox5).Location = location;
		txtSTT_REC_CC.LookupCodeName = "stt_rec_cc";
		txtSTT_REC_CC.LookupWhereCondition = "tg=1";
		((Control)txtSTT_REC_CC).Name = "txtSTT_REC_CC";
		txtSTT_REC_CC.NameControl = lblTen_cc;
		AsTextBox asTextBox6 = txtSTT_REC_CC;
		size = new Size(183, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtSTT_REC_CC).TabIndex = 132;
		txtSTT_REC_CC.UseAutoCompleteSource = true;
		txtSTT_REC_CC.ValidReturnFieldList = "MA_CC,ID,STT_REC";
		((Control)txtSTT_REC_CC).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(580, 309);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)lblF5Info);
		((Control)this).Name = "frmFABHCCEdit";
		((Control)this).Controls.SetChildIndex((Control)(object)lblF5Info, 0);
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

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_cc).Enabled = false;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_cc))
		{
			return false;
		}
		if (string.IsNullOrEmpty(Conversions.ToString(RowToEdit["stt_rec"])))
		{
			((Control)txtMa_cc).Focus();
			return false;
		}
		if (Operators.ConditionalCompareObjectLess(txtSl_hong.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtSl_hong, Helper.GetMessContent(50034));
			return false;
		}
		if (Operators.ConditionalCompareObjectEqual(txtSl_hong.Value, (object)0, false))
		{
			SetControlError((Control)(object)txtSl_hong, Helper.GetMessContent(50002));
			return false;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_tkcp) || !base.ValidData())
		{
			return false;
		}
		return true;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			txtNgay_bh.Value = DateAndTime.Now;
			((TextBox)txtMa_cc).Text = string.Empty;
		}
		else
		{
			GetBHCCInfo(((TextBox)txtSTT_REC_CC).Text);
		}
	}

	protected override void DataBinding()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtDon_gia_hong;
		CreateDataBinding(ref ojb, "don_gia", "value");
		txtDon_gia_hong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDVT;
		CreateDataBinding(ref ojb, "dvt");
		txtDVT = (TextBox)ojb;
		ojb = (Control)(object)txtMa_bpsd;
		CreateDataBinding(ref ojb, "ma_bpsd");
		txtMa_bpsd = (TextBox)ojb;
		ojb = (Control)(object)txtMa_cc;
		CreateDataBinding(ref ojb, "ma_cc");
		txtMa_cc = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_cc;
		CreateDataBinding(ref ojb, "ten_cc");
		lblTen_cc = (Label)ojb;
		ojb = (Control)(object)txtMa_tkcc;
		CreateDataBinding(ref ojb, "tk_cc");
		txtMa_tkcc = (TextBox)ojb;
		ojb = (Control)(object)txtMa_tkcp;
		CreateDataBinding(ref ojb, "tk_cp");
		txtMa_tkcp = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_bh;
		CreateDataBinding(ref ojb, "ngay_giam", "value");
		txtNgay_bh = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_xuat;
		CreateDataBinding(ref ojb, "ngay_ct", "value");
		txtNgay_xuat = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtSl_hong;
		CreateDataBinding(ref ojb, "so_luong", "value");
		txtSl_hong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSo_px;
		CreateDataBinding(ref ojb, "so_ct");
		txtSo_px = (TextBox)ojb;
		ojb = (Control)(object)txtTien_hong;
		CreateDataBinding(ref ojb, "gt_da_kh", "value");
		txtTien_hong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSTT_REC_CC;
		CreateDataBinding(ref ojb, "stt_rec");
		txtSTT_REC_CC = (AsTextBox)(object)ojb;
	}

	protected override bool SetToRow()
	{
		if (f_tblCC == null)
		{
			return false;
		}
		base.SetToRow();
		if (f_tblCC != null && f_tblCC.Rows.Count > 0)
		{
			RowToEdit["moduleid"] = RuntimeHelpers.GetObjectValue(f_tblCC.Rows[0]["moduleid"]);
			RowToEdit["stt_rec"] = RuntimeHelpers.GetObjectValue(f_tblCC.Rows[0]["stt_rec"]);
			RowToEdit["stt_rec0"] = RuntimeHelpers.GetObjectValue(f_tblCC.Rows[0]["stt_rec0"]);
			RowToEdit["LUser"] = SystemInformations.UserName;
		}
		return true;
	}

	protected override bool InsertToDB()
	{
		IFABHCCDAO iFABHCCDAO = (IFABHCCDAO)DAOFactory.CreateDAOInstance("FABHCCDAO", "FABHCC");
		int num = iFABHCCDAO.Insert(RowToEdit);
		iFABHCCDAO.Destroy();
		if (num > 0)
		{
			RowToEdit["id"] = num;
			return true;
		}
		return false;
	}

	protected override bool UpdateDB()
	{
		IFABHCCDAO iFABHCCDAO = (IFABHCCDAO)DAOFactory.CreateDAOInstance("FABHCCDAO", "FABHCC");
		int num = iFABHCCDAO.Update(RowToEdit);
		iFABHCCDAO.Destroy();
		return num == 0;
	}

	private void txtSl_hong_Validating(object sender, CancelEventArgs e)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(((Control)lblCon_Lai).Tag)) && Operators.ConditionalCompareObjectGreater(txtSl_hong.Value, (object)Conversions.ToInteger(((Control)lblCon_Lai).Tag), false))
		{
			e.Cancel = true;
			CMessageBox.Show(50073);
		}
		else
		{
			e.Cancel = false;
		}
	}

	private void GetBHCCInfo(string stt_Rec)
	{
		try
		{
			IFABHCCDAO iFABHCCDAO = (IFABHCCDAO)DAOFactory.CreateDAOInstance("FABHCCDAO", "FABHCC");
			f_tblCC = iFABHCCDAO.GetBHCCInfor(CompanyInformations.CompanyID, ((TextBox)txtMa_cc).Text.Trim(), Conversions.ToInteger(RowToEdit["id"]), EditMode, stt_Rec);
			iFABHCCDAO.Destroy();
			if (f_tblCC.Rows.Count > 0)
			{
				DataRow dataRow = f_tblCC.Rows[0];
				((TextBox)txtMa_tkcp).Text = Conversions.ToString(dataRow["tk_cp"]);
				txtMa_tkcc.Text = Conversions.ToString(dataRow["tk_cc"]);
				txtSo_px.Text = Conversions.ToString(dataRow["so_ct"]);
				txtNgay_xuat.Value = RuntimeHelpers.GetObjectValue(dataRow["ngay_ct"]);
				txtMa_bpsd.Text = Conversions.ToString(dataRow["ma_bpsd"]);
				txtDon_gia_hong.Value = RuntimeHelpers.GetObjectValue(dataRow["don_gia"]);
				txtGia_goc.Value = RuntimeHelpers.GetObjectValue(dataRow["ng_gia"]);
				txtDVT.Text = Conversions.ToString(dataRow["dvt"]);
				lblCon_Lai.Text = Conversions.ToString(Operators.ConcatenateObject((object)lblCon_Lai.Text.Remove(checked(lblCon_Lai.Text.IndexOf(":") + 1)), dataRow["sl_cl"]));
				((Control)lblCon_Lai).Tag = RuntimeHelpers.GetObjectValue(dataRow["sl_cl"]);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void txtMa_cc_Validated(object sender, EventArgs e)
	{
		if (((TextBox)txtMa_cc).Text != null)
		{
			GetBHCCInfo(((TextBox)txtSTT_REC_CC).Text);
		}
	}

	private void txtMa_cc_KeyPress(object sender, KeyPressEventArgs e)
	{
		e.Handled = true;
	}

	private void frmFABHCCEdit_Load(object sender, EventArgs e)
	{
		MaskTextBoxAll(((Control)gbLine).Controls);
	}

	private void MaskTextBoxAll(ControlCollection ctl)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
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

	private void txtMa_cc_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode != 116)
		{
			return;
		}
		txtSTT_REC_CC.MyLookup();
		if (txtSTT_REC_CC.MyValid())
		{
			DataRow pDrw = null;
			if (Commons.ValidMa(ref pDrw, txtSTT_REC_CC.LookupCodeName, ((TextBox)txtSTT_REC_CC).Text, txtSTT_REC_CC.LookupWhereCondition, "MA_CC,TEN_CC"))
			{
				((TextBox)txtMa_cc).Text = Conversions.ToString(pDrw["MA_CC"]);
				lblTen_cc.Text = Conversions.ToString(pDrw["TEN_CC"]);
			}
		}
	}
}
