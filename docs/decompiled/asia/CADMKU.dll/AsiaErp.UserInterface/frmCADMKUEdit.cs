using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.UserInterface.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCADMKUEdit : frmDMEdit
{
	private IContainer components;

	[AccessedThroughProperty("txtMa_KU")]
	private TextBox _txtMa_KU;

	[AccessedThroughProperty("txtTen_KU")]
	private TextBox _txtTen_KU;

	[AccessedThroughProperty("txtGhi_chu")]
	private TextBox _txtGhi_chu;

	[AccessedThroughProperty("cboKy_Tt_lai")]
	private ComboBox _cboKy_Tt_lai;

	[AccessedThroughProperty("cboKy_Tt_goc")]
	private ComboBox _cboKy_Tt_goc;

	[AccessedThroughProperty("txtSo_KU")]
	private TextBox _txtSo_KU;

	[AccessedThroughProperty("lblTen_Ku")]
	private Label _lblTen_Ku;

	[AccessedThroughProperty("lblGhi_Chu")]
	private Label _lblGhi_Chu;

	[AccessedThroughProperty("lblTk_Cp_phai_tra")]
	private Label _lblTk_Cp_phai_tra;

	[AccessedThroughProperty("lblTk_Chi_Phi")]
	private Label _lblTk_Chi_Phi;

	[AccessedThroughProperty("lblTk_Vay")]
	private Label _lblTk_Vay;

	[AccessedThroughProperty("lblLai_Suat")]
	private Label _lblLai_Suat;

	[AccessedThroughProperty("lblTien")]
	private Label _lblTien;

	[AccessedThroughProperty("lblTien_Nt")]
	private Label _lblTien_Nt;

	[AccessedThroughProperty("lblMa_Nt")]
	private Label _lblMa_Nt;

	[AccessedThroughProperty("lblKy_Tt_lai")]
	private Label _lblKy_Tt_lai;

	[AccessedThroughProperty("lblKy_Tt_goc")]
	private Label _lblKy_Tt_goc;

	[AccessedThroughProperty("lblThoi_Han")]
	private Label _lblThoi_Han;

	[AccessedThroughProperty("lblNgay_Tt")]
	private Label _lblNgay_Tt;

	[AccessedThroughProperty("lblNgay_Ky")]
	private Label _lblNgay_Ky;

	[AccessedThroughProperty("lblSo_Ku")]
	private Label _lblSo_Ku;

	[AccessedThroughProperty("lblMa_Ku")]
	private Label _lblMa_Ku;

	[AccessedThroughProperty("txtTk_Cp_Pt")]
	private AsTextBox _txtTk_Cp_Pt;

	[AccessedThroughProperty("txtTk_Cp")]
	private AsTextBox _txtTk_Cp;

	[AccessedThroughProperty("txtTk_Vay")]
	private AsTextBox _txtTk_Vay;

	[AccessedThroughProperty("txtLai_Suat")]
	private AsTextNumeric _txtLai_Suat;

	[AccessedThroughProperty("txtTien")]
	private AsTextNumeric _txtTien;

	[AccessedThroughProperty("txtTien_Nt")]
	private AsTextNumeric _txtTien_Nt;

	[AccessedThroughProperty("txtthoi_han")]
	private AsTextNumeric _txtthoi_han;

	[AccessedThroughProperty("txtNgay_Dh")]
	private AsMaskedTextBox _txtNgay_Dh;

	[AccessedThroughProperty("txtNgay_ky")]
	private AsMaskedTextBox _txtNgay_ky;

	[AccessedThroughProperty("txtLs_Qh")]
	private AsTextNumeric _txtLs_Qh;

	[AccessedThroughProperty("lblLs_Qh")]
	private Label _lblLs_Qh;

	[AccessedThroughProperty("cboMa_NT")]
	private AsComboBoxNT _cboMa_NT;

	[AccessedThroughProperty("lblTen_Tk_cp_pt")]
	private Label _lblTen_Tk_cp_pt;

	[AccessedThroughProperty("lblTen_Tk_cp")]
	private Label _lblTen_Tk_cp;

	[AccessedThroughProperty("lblTen_Tk_Vay")]
	private Label _lblTen_Tk_Vay;

	[AccessedThroughProperty("txtNgay_vay")]
	private AsMaskedTextBox _txtNgay_vay;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblTen_Hd")]
	private Label _lblTen_Hd;

	[AccessedThroughProperty("txtMa_Hd")]
	private AsTextBox _txtMa_Hd;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("cboPhuong_phap_tl")]
	private ComboBox _cboPhuong_phap_tl;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("cboTinh_theo")]
	private ComboBox _cboTinh_theo;

	internal virtual TextBox txtMa_KU
	{
		get
		{
			return _txtMa_KU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_KU = value;
		}
	}

	internal virtual TextBox txtTen_KU
	{
		get
		{
			return _txtTen_KU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTen_KU = value;
		}
	}

	internal virtual TextBox txtGhi_chu
	{
		get
		{
			return _txtGhi_chu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGhi_chu = value;
		}
	}

	internal virtual ComboBox cboKy_Tt_lai
	{
		get
		{
			return _cboKy_Tt_lai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboKy_Tt_lai = value;
		}
	}

	internal virtual ComboBox cboKy_Tt_goc
	{
		get
		{
			return _cboKy_Tt_goc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboKy_Tt_goc = value;
		}
	}

	internal virtual TextBox txtSo_KU
	{
		get
		{
			return _txtSo_KU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_KU = value;
		}
	}

	internal virtual Label lblTen_Ku
	{
		get
		{
			return _lblTen_Ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Ku = value;
		}
	}

	internal virtual Label lblGhi_Chu
	{
		get
		{
			return _lblGhi_Chu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblGhi_Chu = value;
		}
	}

	internal virtual Label lblTk_Cp_phai_tra
	{
		get
		{
			return _lblTk_Cp_phai_tra;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTk_Cp_phai_tra = value;
		}
	}

	internal virtual Label lblTk_Chi_Phi
	{
		get
		{
			return _lblTk_Chi_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTk_Chi_Phi = value;
		}
	}

	internal virtual Label lblTk_Vay
	{
		get
		{
			return _lblTk_Vay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTk_Vay = value;
		}
	}

	internal virtual Label lblLai_Suat
	{
		get
		{
			return _lblLai_Suat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblLai_Suat = value;
		}
	}

	internal virtual Label lblTien
	{
		get
		{
			return _lblTien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTien = value;
		}
	}

	internal virtual Label lblTien_Nt
	{
		get
		{
			return _lblTien_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTien_Nt = value;
		}
	}

	internal virtual Label lblMa_Nt
	{
		get
		{
			return _lblMa_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_Nt = value;
		}
	}

	internal virtual Label lblKy_Tt_lai
	{
		get
		{
			return _lblKy_Tt_lai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblKy_Tt_lai = value;
		}
	}

	internal virtual Label lblKy_Tt_goc
	{
		get
		{
			return _lblKy_Tt_goc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblKy_Tt_goc = value;
		}
	}

	internal virtual Label lblThoi_Han
	{
		get
		{
			return _lblThoi_Han;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblThoi_Han = value;
		}
	}

	internal virtual Label lblNgay_Tt
	{
		get
		{
			return _lblNgay_Tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNgay_Tt = value;
		}
	}

	internal virtual Label lblNgay_Ky
	{
		get
		{
			return _lblNgay_Ky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNgay_Ky = value;
		}
	}

	internal virtual Label lblSo_Ku
	{
		get
		{
			return _lblSo_Ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblSo_Ku = value;
		}
	}

	internal virtual Label lblMa_Ku
	{
		get
		{
			return _lblMa_Ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_Ku = value;
		}
	}

	internal virtual AsTextBox txtTk_Cp_Pt
	{
		get
		{
			return _txtTk_Cp_Pt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTk_Cp_Pt = value;
		}
	}

	internal virtual AsTextBox txtTk_Cp
	{
		get
		{
			return _txtTk_Cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTk_Cp = value;
		}
	}

	internal virtual AsTextBox txtTk_Vay
	{
		get
		{
			return _txtTk_Vay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTk_Vay = value;
		}
	}

	internal virtual AsTextNumeric txtLai_Suat
	{
		get
		{
			return _txtLai_Suat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtLai_Suat = value;
		}
	}

	internal virtual AsTextNumeric txtTien
	{
		get
		{
			return _txtTien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTien = value;
		}
	}

	internal virtual AsTextNumeric txtTien_Nt
	{
		get
		{
			return _txtTien_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTien_Nt = value;
		}
	}

	internal virtual AsTextNumeric txtthoi_han
	{
		get
		{
			return _txtthoi_han;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			CancelEventHandler cancelEventHandler = txtthoi_han_Validating;
			if (_txtthoi_han != null)
			{
				((Control)_txtthoi_han).Validating -= cancelEventHandler;
			}
			_txtthoi_han = value;
			if (_txtthoi_han != null)
			{
				((Control)_txtthoi_han).Validating += cancelEventHandler;
			}
		}
	}

	internal virtual AsMaskedTextBox txtNgay_Dh
	{
		get
		{
			return _txtNgay_Dh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNgay_Dh = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_ky
	{
		get
		{
			return _txtNgay_ky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtNgay_ky_Validated;
			if (_txtNgay_ky != null)
			{
				((Control)_txtNgay_ky).Validated -= eventHandler;
			}
			_txtNgay_ky = value;
			if (_txtNgay_ky != null)
			{
				((Control)_txtNgay_ky).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtLs_Qh
	{
		get
		{
			return _txtLs_Qh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtLs_Qh = value;
		}
	}

	internal virtual Label lblLs_Qh
	{
		get
		{
			return _lblLs_Qh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblLs_Qh = value;
		}
	}

	internal virtual AsComboBoxNT cboMa_NT
	{
		get
		{
			return _cboMa_NT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboMa_NT = value;
		}
	}

	internal virtual Label lblTen_Tk_cp_pt
	{
		get
		{
			return _lblTen_Tk_cp_pt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Tk_cp_pt = value;
		}
	}

	internal virtual Label lblTen_Tk_cp
	{
		get
		{
			return _lblTen_Tk_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Tk_cp = value;
		}
	}

	internal virtual Label lblTen_Tk_Vay
	{
		get
		{
			return _lblTen_Tk_Vay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Tk_Vay = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_vay
	{
		get
		{
			return _txtNgay_vay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtNgay_vay_Validated;
			if (_txtNgay_vay != null)
			{
				((Control)_txtNgay_vay).Validated -= eventHandler;
			}
			_txtNgay_vay = value;
			if (_txtNgay_vay != null)
			{
				((Control)_txtNgay_vay).Validated += eventHandler;
			}
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label lblTen_Hd
	{
		get
		{
			return _lblTen_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Hd = value;
		}
	}

	internal virtual AsTextBox txtMa_Hd
	{
		get
		{
			return _txtMa_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_Hd = value;
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual ComboBox cboPhuong_phap_tl
	{
		get
		{
			return _cboPhuong_phap_tl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboPhuong_phap_tl = value;
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual ComboBox cboTinh_theo
	{
		get
		{
			return _cboTinh_theo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboTinh_theo_SelectedIndexChanged;
			if (_cboTinh_theo != null)
			{
				_cboTinh_theo.SelectedIndexChanged -= eventHandler;
			}
			_cboTinh_theo = value;
			if (_cboTinh_theo != null)
			{
				_cboTinh_theo.SelectedIndexChanged += eventHandler;
			}
		}
	}

	public frmCADMKUEdit()
	{
		((Form)this).Load += frmCADMKUEdit_Load;
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		lblTen_Ku = new Label();
		lblGhi_Chu = new Label();
		lblTk_Cp_phai_tra = new Label();
		lblTk_Chi_Phi = new Label();
		lblTk_Vay = new Label();
		lblLai_Suat = new Label();
		lblTien = new Label();
		lblTien_Nt = new Label();
		lblMa_Nt = new Label();
		lblKy_Tt_lai = new Label();
		lblKy_Tt_goc = new Label();
		lblThoi_Han = new Label();
		lblNgay_Tt = new Label();
		lblNgay_Ky = new Label();
		lblSo_Ku = new Label();
		lblMa_Ku = new Label();
		txtTen_KU = new TextBox();
		txtGhi_chu = new TextBox();
		cboKy_Tt_lai = new ComboBox();
		cboKy_Tt_goc = new ComboBox();
		txtSo_KU = new TextBox();
		txtMa_KU = new TextBox();
		txtTk_Cp_Pt = new AsTextBox();
		lblTen_Tk_cp_pt = new Label();
		txtTk_Cp = new AsTextBox();
		lblTen_Tk_cp = new Label();
		txtTk_Vay = new AsTextBox();
		lblTen_Tk_Vay = new Label();
		txtTien = new AsTextNumeric();
		txtTien_Nt = new AsTextNumeric();
		txtLai_Suat = new AsTextNumeric();
		txtthoi_han = new AsTextNumeric();
		txtNgay_ky = new AsMaskedTextBox();
		txtNgay_Dh = new AsMaskedTextBox();
		txtLs_Qh = new AsTextNumeric();
		lblLs_Qh = new Label();
		cboMa_NT = new AsComboBoxNT();
		txtNgay_vay = new AsMaskedTextBox();
		Label1 = new Label();
		lblTen_Hd = new Label();
		txtMa_Hd = new AsTextBox();
		Label3 = new Label();
		Label4 = new Label();
		cboPhuong_phap_tl = new ComboBox();
		cboTinh_theo = new ComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(316, 546);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 19;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 537);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 537);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)cboTinh_theo);
		((Control)gbLine).Controls.Add((Control)(object)cboPhuong_phap_tl);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Hd);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Hd);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_vay);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_cp_pt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_cp);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_Vay);
		((Control)gbLine).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbLine).Controls.Add((Control)(object)txtLs_Qh);
		((Control)gbLine).Controls.Add((Control)(object)lblLs_Qh);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_Dh);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ky);
		((Control)gbLine).Controls.Add((Control)(object)txtthoi_han);
		((Control)gbLine).Controls.Add((Control)(object)txtLai_Suat);
		((Control)gbLine).Controls.Add((Control)(object)txtTien);
		((Control)gbLine).Controls.Add((Control)(object)txtTien_Nt);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Cp_Pt);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Cp);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Vay);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_KU);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_KU);
		((Control)gbLine).Controls.Add((Control)(object)txtGhi_chu);
		((Control)gbLine).Controls.Add((Control)(object)cboKy_Tt_lai);
		((Control)gbLine).Controls.Add((Control)(object)cboKy_Tt_goc);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_KU);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Ku);
		((Control)gbLine).Controls.Add((Control)(object)lblGhi_Chu);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Cp_phai_tra);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Chi_Phi);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Vay);
		((Control)gbLine).Controls.Add((Control)(object)lblLai_Suat);
		((Control)gbLine).Controls.Add((Control)(object)lblTien);
		((Control)gbLine).Controls.Add((Control)(object)lblTien_Nt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Nt);
		((Control)gbLine).Controls.Add((Control)(object)lblKy_Tt_lai);
		((Control)gbLine).Controls.Add((Control)(object)lblKy_Tt_goc);
		((Control)gbLine).Controls.Add((Control)(object)lblThoi_Han);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_Tt);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_Ky);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_Ku);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Ku);
		GroupBox obj3 = gbLine;
		Size size = new Size(632, 524);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Ku, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_Ku, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_Ky, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_Tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblThoi_Han, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblKy_Tt_goc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblKy_Tt_lai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTien_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblLai_Suat, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Vay, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Chi_Phi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Cp_phai_tra, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblGhi_Chu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Ku, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_KU, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboKy_Tt_goc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboKy_Tt_lai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtGhi_chu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_KU, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_KU, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Vay, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Cp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Cp_Pt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTien_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtLai_Suat, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtthoi_han, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ky, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_Dh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblLs_Qh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtLs_Qh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_Vay, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_cp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_cp_pt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_vay, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboPhuong_phap_tl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboTinh_theo, 0);
		lblTen_Ku.AutoSize = true;
		lblTen_Ku.ImeMode = (ImeMode)0;
		Label obj4 = lblTen_Ku;
		location = new Point(16, 49);
		((Control)obj4).Location = location;
		((Control)lblTen_Ku).Name = "lblTen_Ku";
		Label obj5 = lblTen_Ku;
		size = new Size(68, 13);
		((Control)obj5).Size = size;
		((Control)lblTen_Ku).TabIndex = 115;
		lblTen_Ku.Text = "Tên khế ước";
		lblGhi_Chu.AutoSize = true;
		lblGhi_Chu.ImeMode = (ImeMode)0;
		Label obj6 = lblGhi_Chu;
		location = new Point(16, 498);
		((Control)obj6).Location = location;
		((Control)lblGhi_Chu).Name = "lblGhi_Chu";
		Label obj7 = lblGhi_Chu;
		size = new Size(44, 13);
		((Control)obj7).Size = size;
		((Control)lblGhi_Chu).TabIndex = 114;
		lblGhi_Chu.Text = "Ghi chú";
		lblTk_Cp_phai_tra.AutoSize = true;
		lblTk_Cp_phai_tra.ImeMode = (ImeMode)0;
		Label obj8 = lblTk_Cp_phai_tra;
		location = new Point(16, 446);
		((Control)obj8).Location = location;
		((Control)lblTk_Cp_phai_tra).Name = "lblTk_Cp_phai_tra";
		Label obj9 = lblTk_Cp_phai_tra;
		size = new Size(95, 13);
		((Control)obj9).Size = size;
		((Control)lblTk_Cp_phai_tra).TabIndex = 113;
		lblTk_Cp_phai_tra.Text = "TK chi phí phải trả";
		lblTk_Chi_Phi.AutoSize = true;
		lblTk_Chi_Phi.ImeMode = (ImeMode)0;
		Label obj10 = lblTk_Chi_Phi;
		location = new Point(16, 420);
		((Control)obj10).Location = location;
		((Control)lblTk_Chi_Phi).Name = "lblTk_Chi_Phi";
		Label obj11 = lblTk_Chi_Phi;
		size = new Size(57, 13);
		((Control)obj11).Size = size;
		((Control)lblTk_Chi_Phi).TabIndex = 112;
		lblTk_Chi_Phi.Text = "TK chi phí";
		lblTk_Vay.AutoSize = true;
		lblTk_Vay.ImeMode = (ImeMode)0;
		Label obj12 = lblTk_Vay;
		location = new Point(16, 394);
		((Control)obj12).Location = location;
		((Control)lblTk_Vay).Name = "lblTk_Vay";
		Label obj13 = lblTk_Vay;
		size = new Size(41, 13);
		((Control)obj13).Size = size;
		((Control)lblTk_Vay).TabIndex = 111;
		lblTk_Vay.Text = "TK vay";
		lblLai_Suat.AutoSize = true;
		lblLai_Suat.ImeMode = (ImeMode)0;
		Label obj14 = lblLai_Suat;
		location = new Point(16, 205);
		((Control)obj14).Location = location;
		((Control)lblLai_Suat).Name = "lblLai_Suat";
		Label obj15 = lblLai_Suat;
		size = new Size(44, 13);
		((Control)obj15).Size = size;
		((Control)lblLai_Suat).TabIndex = 110;
		lblLai_Suat.Text = "Lãi suất";
		lblTien.AutoSize = true;
		lblTien.ImeMode = (ImeMode)0;
		Label obj16 = lblTien;
		location = new Point(16, 367);
		((Control)obj16).Location = location;
		((Control)lblTien).Name = "lblTien";
		Label obj17 = lblTien;
		size = new Size(70, 13);
		((Control)obj17).Size = size;
		((Control)lblTien).TabIndex = 109;
		lblTien.Text = "Tiền khế ước";
		lblTien_Nt.AutoSize = true;
		lblTien_Nt.ImeMode = (ImeMode)0;
		Label obj18 = lblTien_Nt;
		location = new Point(16, 341);
		((Control)obj18).Location = location;
		((Control)lblTien_Nt).Name = "lblTien_Nt";
		Label obj19 = lblTien_Nt;
		size = new Size(88, 13);
		((Control)obj19).Size = size;
		((Control)lblTien_Nt).TabIndex = 108;
		lblTien_Nt.Text = "Tiền khế ước NT";
		lblMa_Nt.AutoSize = true;
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj20 = lblMa_Nt;
		location = new Point(16, 313);
		((Control)obj20).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj21 = lblMa_Nt;
		size = new Size(40, 13);
		((Control)obj21).Size = size;
		((Control)lblMa_Nt).TabIndex = 107;
		lblMa_Nt.Text = "Mã NT";
		lblKy_Tt_lai.AutoSize = true;
		lblKy_Tt_lai.ImeMode = (ImeMode)0;
		Label obj22 = lblKy_Tt_lai;
		location = new Point(16, 286);
		((Control)obj22).Location = location;
		((Control)lblKy_Tt_lai).Name = "lblKy_Tt_lai";
		Label obj23 = lblKy_Tt_lai;
		size = new Size(86, 13);
		((Control)obj23).Size = size;
		((Control)lblKy_Tt_lai).TabIndex = 106;
		lblKy_Tt_lai.Text = "Kỳ thanh toán lãi";
		lblKy_Tt_goc.AutoSize = true;
		lblKy_Tt_goc.ImeMode = (ImeMode)0;
		Label obj24 = lblKy_Tt_goc;
		location = new Point(16, 259);
		((Control)obj24).Location = location;
		((Control)lblKy_Tt_goc).Name = "lblKy_Tt_goc";
		Label obj25 = lblKy_Tt_goc;
		size = new Size(94, 13);
		((Control)obj25).Size = size;
		((Control)lblKy_Tt_goc).TabIndex = 105;
		lblKy_Tt_goc.Text = "Kỳ thanh toán gốc";
		lblThoi_Han.AutoSize = true;
		lblThoi_Han.ImeMode = (ImeMode)0;
		Label obj26 = lblThoi_Han;
		location = new Point(16, 153);
		((Control)obj26).Location = location;
		((Control)lblThoi_Han).Name = "lblThoi_Han";
		Label obj27 = lblThoi_Han;
		size = new Size(71, 13);
		((Control)obj27).Size = size;
		((Control)lblThoi_Han).TabIndex = 104;
		lblThoi_Han.Text = "Thời gian vay";
		lblNgay_Tt.AutoSize = true;
		lblNgay_Tt.ImeMode = (ImeMode)0;
		Label obj28 = lblNgay_Tt;
		location = new Point(16, 179);
		((Control)obj28).Location = location;
		((Control)lblNgay_Tt).Name = "lblNgay_Tt";
		Label obj29 = lblNgay_Tt;
		size = new Size(75, 13);
		((Control)obj29).Size = size;
		((Control)lblNgay_Tt).TabIndex = 103;
		lblNgay_Tt.Text = "Ngày đáo hạn";
		lblNgay_Ky.AutoSize = true;
		lblNgay_Ky.ImeMode = (ImeMode)0;
		Label obj30 = lblNgay_Ky;
		location = new Point(16, 101);
		((Control)obj30).Location = location;
		((Control)lblNgay_Ky).Name = "lblNgay_Ky";
		Label obj31 = lblNgay_Ky;
		size = new Size(46, 13);
		((Control)obj31).Size = size;
		((Control)lblNgay_Ky).TabIndex = 102;
		lblNgay_Ky.Text = "Ngày ký";
		lblSo_Ku.AutoSize = true;
		lblSo_Ku.ImeMode = (ImeMode)0;
		Label obj32 = lblSo_Ku;
		location = new Point(16, 75);
		((Control)obj32).Location = location;
		((Control)lblSo_Ku).Name = "lblSo_Ku";
		Label obj33 = lblSo_Ku;
		size = new Size(62, 13);
		((Control)obj33).Size = size;
		((Control)lblSo_Ku).TabIndex = 101;
		lblSo_Ku.Text = "Số khế ước";
		lblMa_Ku.AutoSize = true;
		lblMa_Ku.ImeMode = (ImeMode)0;
		Label obj34 = lblMa_Ku;
		location = new Point(16, 23);
		((Control)obj34).Location = location;
		((Control)lblMa_Ku).Name = "lblMa_Ku";
		Label obj35 = lblMa_Ku;
		size = new Size(64, 13);
		((Control)obj35).Size = size;
		((Control)lblMa_Ku).TabIndex = 100;
		lblMa_Ku.Text = "Mã khế ước";
		TextBox obj36 = txtTen_KU;
		location = new Point(137, 45);
		((Control)obj36).Location = location;
		((TextBoxBase)txtTen_KU).MaxLength = 50;
		((Control)txtTen_KU).Name = "txtTen_KU";
		TextBox obj37 = txtTen_KU;
		size = new Size(460, 20);
		((Control)obj37).Size = size;
		((Control)txtTen_KU).TabIndex = 1;
		TextBox obj38 = txtGhi_chu;
		location = new Point(137, 494);
		((Control)obj38).Location = location;
		((TextBoxBase)txtGhi_chu).MaxLength = 100;
		((Control)txtGhi_chu).Name = "txtGhi_chu";
		TextBox obj39 = txtGhi_chu;
		size = new Size(460, 20);
		((Control)obj39).Size = size;
		((Control)txtGhi_chu).TabIndex = 19;
		cboKy_Tt_lai.DropDownStyle = (ComboBoxStyle)2;
		cboKy_Tt_lai.ItemHeight = 13;
		cboKy_Tt_lai.Items.AddRange(new object[4] { "Hàng tháng", "Hàng quý", "Hàng năm", "Thanh toán 1 lần cuối kỳ" });
		ComboBox obj40 = cboKy_Tt_lai;
		location = new Point(137, 282);
		((Control)obj40).Location = location;
		((Control)cboKy_Tt_lai).Name = "cboKy_Tt_lai";
		ComboBox obj41 = cboKy_Tt_lai;
		size = new Size(315, 21);
		((Control)obj41).Size = size;
		((Control)cboKy_Tt_lai).TabIndex = 11;
		cboKy_Tt_goc.DropDownStyle = (ComboBoxStyle)2;
		cboKy_Tt_goc.ItemHeight = 13;
		cboKy_Tt_goc.Items.AddRange(new object[4] { "Hàng tháng", "Hàng quý", "Hàng năm", "Thanh toán 1 lần cuối kỳ" });
		ComboBox obj42 = cboKy_Tt_goc;
		location = new Point(137, 255);
		((Control)obj42).Location = location;
		((Control)cboKy_Tt_goc).Name = "cboKy_Tt_goc";
		ComboBox obj43 = cboKy_Tt_goc;
		size = new Size(315, 21);
		((Control)obj43).Size = size;
		((Control)cboKy_Tt_goc).TabIndex = 10;
		TextBox obj44 = txtSo_KU;
		location = new Point(137, 71);
		((Control)obj44).Location = location;
		((TextBoxBase)txtSo_KU).MaxLength = 20;
		((Control)txtSo_KU).Name = "txtSo_KU";
		TextBox obj45 = txtSo_KU;
		size = new Size(100, 20);
		((Control)obj45).Size = size;
		((Control)txtSo_KU).TabIndex = 2;
		txtMa_KU.CharacterCasing = (CharacterCasing)1;
		TextBox obj46 = txtMa_KU;
		location = new Point(137, 19);
		((Control)obj46).Location = location;
		((TextBoxBase)txtMa_KU).MaxLength = 20;
		((Control)txtMa_KU).Name = "txtMa_KU";
		TextBox obj47 = txtMa_KU;
		size = new Size(100, 20);
		((Control)obj47).Size = size;
		((Control)txtMa_KU).TabIndex = 0;
		txtTk_Cp_Pt.AutoLookup = true;
		txtTk_Cp_Pt.AutoValid = true;
		((TextBoxBase)txtTk_Cp_Pt).BackColor = SystemColors.Info;
		((TextBox)txtTk_Cp_Pt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTk_Cp_Pt;
		location = new Point(137, 442);
		((Control)asTextBox).Location = location;
		txtTk_Cp_Pt.LookupCodeName = "TK";
		txtTk_Cp_Pt.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Cp_Pt).Name = "txtTk_Cp_Pt";
		txtTk_Cp_Pt.NameControl = lblTen_Tk_cp_pt;
		txtTk_Cp_Pt.SD = true;
		AsTextBox asTextBox2 = txtTk_Cp_Pt;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTk_Cp_Pt).TabIndex = 17;
		txtTk_Cp_Pt.UseAutoCompleteSource = true;
		lblTen_Tk_cp_pt.ImeMode = (ImeMode)0;
		Label obj48 = lblTen_Tk_cp_pt;
		location = new Point(243, 446);
		((Control)obj48).Location = location;
		((Control)lblTen_Tk_cp_pt).Name = "lblTen_Tk_cp_pt";
		Label obj49 = lblTen_Tk_cp_pt;
		size = new Size(354, 13);
		((Control)obj49).Size = size;
		((Control)lblTen_Tk_cp_pt).TabIndex = 217;
		lblTen_Tk_cp_pt.TextAlign = (ContentAlignment)16;
		txtTk_Cp.AutoLookup = true;
		txtTk_Cp.AutoValid = true;
		((TextBoxBase)txtTk_Cp).BackColor = SystemColors.Info;
		((TextBox)txtTk_Cp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk_Cp;
		location = new Point(137, 416);
		((Control)asTextBox3).Location = location;
		txtTk_Cp.LookupCodeName = "TK";
		txtTk_Cp.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Cp).Name = "txtTk_Cp";
		txtTk_Cp.NameControl = lblTen_Tk_cp;
		txtTk_Cp.SD = true;
		AsTextBox asTextBox4 = txtTk_Cp;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk_Cp).TabIndex = 16;
		txtTk_Cp.UseAutoCompleteSource = true;
		lblTen_Tk_cp.ImeMode = (ImeMode)0;
		Label obj50 = lblTen_Tk_cp;
		location = new Point(243, 420);
		((Control)obj50).Location = location;
		((Control)lblTen_Tk_cp).Name = "lblTen_Tk_cp";
		Label obj51 = lblTen_Tk_cp;
		size = new Size(354, 13);
		((Control)obj51).Size = size;
		((Control)lblTen_Tk_cp).TabIndex = 216;
		lblTen_Tk_cp.TextAlign = (ContentAlignment)16;
		txtTk_Vay.AutoLookup = true;
		txtTk_Vay.AutoValid = true;
		((TextBoxBase)txtTk_Vay).BackColor = SystemColors.Info;
		((TextBox)txtTk_Vay).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTk_Vay;
		location = new Point(137, 390);
		((Control)asTextBox5).Location = location;
		txtTk_Vay.LookupCodeName = "TK";
		txtTk_Vay.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Vay).Name = "txtTk_Vay";
		txtTk_Vay.NameControl = lblTen_Tk_Vay;
		txtTk_Vay.SD = true;
		AsTextBox asTextBox6 = txtTk_Vay;
		size = new Size(100, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTk_Vay).TabIndex = 15;
		txtTk_Vay.UseAutoCompleteSource = true;
		lblTen_Tk_Vay.ImeMode = (ImeMode)0;
		Label obj52 = lblTen_Tk_Vay;
		location = new Point(243, 394);
		((Control)obj52).Location = location;
		((Control)lblTen_Tk_Vay).Name = "lblTen_Tk_Vay";
		Label obj53 = lblTen_Tk_Vay;
		size = new Size(354, 13);
		((Control)obj53).Size = size;
		((Control)lblTen_Tk_Vay).TabIndex = 215;
		lblTen_Tk_Vay.TextAlign = (ContentAlignment)16;
		txtTien.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTien;
		location = new Point(137, 363);
		((Control)asTextNumeric).Location = location;
		txtTien.Mask = "### ### ### ###";
		((Control)txtTien).Name = "txtTien";
		AsTextNumeric asTextNumeric2 = txtTien;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTien).TabIndex = 14;
		((Control)txtTien).Tag = "OA";
		((TextBox)txtTien).Text = "0";
		((TextBox)txtTien).TextAlign = (HorizontalAlignment)1;
		txtTien.Value = 0.0;
		txtTien_Nt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric3 = txtTien_Nt;
		location = new Point(137, 337);
		((Control)asTextNumeric3).Location = location;
		txtTien_Nt.Mask = "### ### ### ###.##";
		((Control)txtTien_Nt).Name = "txtTien_Nt";
		AsTextNumeric asTextNumeric4 = txtTien_Nt;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtTien_Nt).TabIndex = 13;
		((Control)txtTien_Nt).Tag = "FA";
		((TextBox)txtTien_Nt).Text = "0.00";
		((TextBox)txtTien_Nt).TextAlign = (HorizontalAlignment)1;
		txtTien_Nt.Value = 0.0;
		txtLai_Suat.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric5 = txtLai_Suat;
		location = new Point(137, 201);
		((Control)asTextNumeric5).Location = location;
		txtLai_Suat.Mask = "### ### ### ###.##";
		((Control)txtLai_Suat).Name = "txtLai_Suat";
		AsTextNumeric asTextNumeric6 = txtLai_Suat;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtLai_Suat).TabIndex = 8;
		((TextBox)txtLai_Suat).Text = "0.00";
		((TextBox)txtLai_Suat).TextAlign = (HorizontalAlignment)1;
		txtLai_Suat.Value = 0.0;
		txtthoi_han.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric7 = txtthoi_han;
		location = new Point(137, 149);
		((Control)asTextNumeric7).Location = location;
		txtthoi_han.Mask = "### ### ### ###";
		((Control)txtthoi_han).Name = "txtthoi_han";
		AsTextNumeric asTextNumeric8 = txtthoi_han;
		size = new Size(34, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtthoi_han).TabIndex = 5;
		((TextBox)txtthoi_han).Text = "0";
		((TextBox)txtthoi_han).TextAlign = (HorizontalAlignment)1;
		txtthoi_han.Value = 0.0;
		txtNgay_ky.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ky).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ky;
		location = new Point(137, 97);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ky).Mask = "##/##/####";
		((Control)txtNgay_ky).Name = "txtNgay_ky";
		((MaskedTextBox)txtNgay_ky).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ky;
		size = new Size(100, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ky).TabIndex = 3;
		((MaskedTextBox)txtNgay_ky).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ky;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtNgay_Dh.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_Dh).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_Dh;
		location = new Point(137, 175);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_Dh).Mask = "##/##/####";
		((Control)txtNgay_Dh).Name = "txtNgay_Dh";
		((MaskedTextBox)txtNgay_Dh).PromptChar = ' ';
		((MaskedTextBox)txtNgay_Dh).ReadOnly = true;
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_Dh;
		size = new Size(100, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_Dh).TabIndex = 7;
		((Control)txtNgay_Dh).TabStop = false;
		((MaskedTextBox)txtNgay_Dh).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_Dh;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		txtLs_Qh.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric9 = txtLs_Qh;
		location = new Point(551, 543);
		((Control)asTextNumeric9).Location = location;
		txtLs_Qh.Mask = "### ### ### ###.##";
		((Control)txtLs_Qh).Name = "txtLs_Qh";
		AsTextNumeric asTextNumeric10 = txtLs_Qh;
		size = new Size(46, 20);
		((Control)asTextNumeric10).Size = size;
		((Control)txtLs_Qh).TabIndex = 13;
		((TextBox)txtLs_Qh).Text = "0.00";
		((TextBox)txtLs_Qh).TextAlign = (HorizontalAlignment)1;
		txtLs_Qh.Value = 0.0;
		((Control)txtLs_Qh).Visible = false;
		lblLs_Qh.AutoSize = true;
		lblLs_Qh.ImeMode = (ImeMode)0;
		Label obj54 = lblLs_Qh;
		location = new Point(446, 547);
		((Control)obj54).Location = location;
		((Control)lblLs_Qh).Name = "lblLs_Qh";
		Label obj55 = lblLs_Qh;
		size = new Size(103, 13);
		((Control)obj55).Size = size;
		((Control)lblLs_Qh).TabIndex = 178;
		lblLs_Qh.Text = "Lãi suất quá hạn (%)";
		((Control)lblLs_Qh).Visible = false;
		((ComboBox)cboMa_NT).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMa_NT).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_NT;
		location = new Point(137, 309);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(100, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 12;
		txtNgay_vay.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_vay).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox7 = txtNgay_vay;
		location = new Point(137, 123);
		((Control)asMaskedTextBox7).Location = location;
		((MaskedTextBox)txtNgay_vay).Mask = "##/##/####";
		((Control)txtNgay_vay).Name = "txtNgay_vay";
		((MaskedTextBox)txtNgay_vay).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox8 = txtNgay_vay;
		size = new Size(100, 20);
		((Control)asMaskedTextBox8).Size = size;
		((Control)txtNgay_vay).TabIndex = 4;
		((MaskedTextBox)txtNgay_vay).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox9 = txtNgay_vay;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox9.Value = dateTime;
		Label1.AutoSize = true;
		Label1.ImeMode = (ImeMode)0;
		Label label = Label1;
		location = new Point(16, 127);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(52, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 219;
		Label1.Text = "Ngày vay";
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj56 = lblTen_Hd;
		location = new Point(243, 472);
		((Control)obj56).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj57 = lblTen_Hd;
		size = new Size(354, 13);
		((Control)obj57).Size = size;
		((Control)lblTen_Hd).TabIndex = 222;
		lblTen_Hd.TextAlign = (ContentAlignment)16;
		txtMa_Hd.AutoLookup = true;
		txtMa_Hd.AutoValid = true;
		((TextBoxBase)txtMa_Hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_Hd;
		location = new Point(137, 468);
		((Control)asTextBox7).Location = location;
		txtMa_Hd.LookupCodeName = "MA_HD";
		((Control)txtMa_Hd).Name = "txtMa_Hd";
		txtMa_Hd.NameControl = lblTen_Hd;
		txtMa_Hd.SD = true;
		AsTextBox asTextBox8 = txtMa_Hd;
		size = new Size(100, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_Hd).TabIndex = 18;
		txtMa_Hd.UseAutoCompleteSource = true;
		Label3.AutoSize = true;
		Label3.ImeMode = (ImeMode)0;
		Label label3 = Label3;
		location = new Point(16, 472);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		Label label4 = Label3;
		size = new Size(71, 13);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 221;
		Label3.Text = "Mã hợp đồng";
		Label4.AutoSize = true;
		Label4.ImeMode = (ImeMode)0;
		Label label5 = Label4;
		location = new Point(16, 232);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		Label label6 = Label4;
		size = new Size(106, 13);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 224;
		Label4.Text = "Phương pháp tính lãi";
		cboPhuong_phap_tl.DropDownStyle = (ComboBoxStyle)2;
		cboPhuong_phap_tl.ItemHeight = 13;
		cboPhuong_phap_tl.Items.AddRange(new object[4] { "1. Trả gốc và lãi theo dư nợ giảm dần", "2. Trả góp đều hàng tháng theo lãi suất kép", "3. Trả góp đều theo lãi suất đơn", "4. Trả góp đều, lãi tính trên dư nợ giảm dần hàng tháng" });
		ComboBox obj58 = cboPhuong_phap_tl;
		location = new Point(137, 228);
		((Control)obj58).Location = location;
		((Control)cboPhuong_phap_tl).Name = "cboPhuong_phap_tl";
		ComboBox obj59 = cboPhuong_phap_tl;
		size = new Size(315, 21);
		((Control)obj59).Size = size;
		((Control)cboPhuong_phap_tl).TabIndex = 9;
		cboTinh_theo.DropDownStyle = (ComboBoxStyle)2;
		cboTinh_theo.ItemHeight = 13;
		cboTinh_theo.Items.AddRange(new object[2] { "Tháng", "Năm" });
		ComboBox obj60 = cboTinh_theo;
		location = new Point(177, 148);
		((Control)obj60).Location = location;
		((Control)cboTinh_theo).Name = "cboTinh_theo";
		ComboBox obj61 = cboTinh_theo;
		size = new Size(60, 21);
		((Control)obj61).Size = size;
		((Control)cboTinh_theo).TabIndex = 6;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(654, 567);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCADMKUEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		ArrayList arrayList = new ArrayList();
		DictionaryEntry dictionaryEntry = new DictionaryEntry("1", RuntimeHelpers.GetObjectValue(cboTinh_theo.Items[0]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("2", RuntimeHelpers.GetObjectValue(cboTinh_theo.Items[1]));
		arrayList.Add(dictionaryEntry);
		cboTinh_theo.DataSource = arrayList;
		((ListControl)cboTinh_theo).ValueMember = "Key";
		((ListControl)cboTinh_theo).DisplayMember = "Value";
		cboTinh_theo.SelectedIndex = 0;
		ArrayList arrayList2 = new ArrayList();
		dictionaryEntry = new DictionaryEntry("1", RuntimeHelpers.GetObjectValue(cboPhuong_phap_tl.Items[0]));
		arrayList2.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("2", RuntimeHelpers.GetObjectValue(cboPhuong_phap_tl.Items[1]));
		arrayList2.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("3", RuntimeHelpers.GetObjectValue(cboPhuong_phap_tl.Items[2]));
		arrayList2.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("4", RuntimeHelpers.GetObjectValue(cboPhuong_phap_tl.Items[3]));
		arrayList2.Add(dictionaryEntry);
		cboPhuong_phap_tl.DataSource = arrayList2;
		((ListControl)cboPhuong_phap_tl).ValueMember = "Key";
		((ListControl)cboPhuong_phap_tl).DisplayMember = "Value";
		cboPhuong_phap_tl.SelectedIndex = 0;
		ArrayList arrayList3 = new ArrayList();
		dictionaryEntry = new DictionaryEntry("1", RuntimeHelpers.GetObjectValue(cboKy_Tt_goc.Items[0]));
		arrayList3.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("2", RuntimeHelpers.GetObjectValue(cboKy_Tt_goc.Items[1]));
		arrayList3.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("3", RuntimeHelpers.GetObjectValue(cboKy_Tt_goc.Items[2]));
		arrayList3.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("4", RuntimeHelpers.GetObjectValue(cboKy_Tt_goc.Items[3]));
		arrayList3.Add(dictionaryEntry);
		cboKy_Tt_goc.DataSource = arrayList3;
		((ListControl)cboKy_Tt_goc).ValueMember = "Key";
		((ListControl)cboKy_Tt_goc).DisplayMember = "Value";
		cboKy_Tt_goc.SelectedIndex = 0;
		ArrayList arrayList4 = new ArrayList();
		dictionaryEntry = new DictionaryEntry("1", RuntimeHelpers.GetObjectValue(cboKy_Tt_lai.Items[0]));
		arrayList4.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("2", RuntimeHelpers.GetObjectValue(cboKy_Tt_lai.Items[1]));
		arrayList4.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("3", RuntimeHelpers.GetObjectValue(cboKy_Tt_lai.Items[2]));
		arrayList4.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("4", RuntimeHelpers.GetObjectValue(cboKy_Tt_lai.Items[3]));
		arrayList4.Add(dictionaryEntry);
		cboKy_Tt_lai.DataSource = arrayList4;
		((ListControl)cboKy_Tt_lai).ValueMember = "Key";
		((ListControl)cboKy_Tt_lai).DisplayMember = "Value";
		cboKy_Tt_lai.SelectedIndex = 0;
		((TextBoxBase)txtMa_KU).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_KU).Select();
		MaskTextBoxAll(((Control)gbLine).Controls);
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_KU).Enabled = false;
		((Control)txtTen_KU).Select();
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_KU;
		CreateDataBinding(ref ojb, "Ma_Ku");
		txtMa_KU = (TextBox)ojb;
		ojb = (Control)(object)txtTen_KU;
		CreateDataBinding(ref ojb, "Ten_Ku");
		txtTen_KU = (TextBox)ojb;
		ojb = (Control)(object)txtSo_KU;
		CreateDataBinding(ref ojb, "So_Ku");
		txtSo_KU = (TextBox)ojb;
		ojb = (Control)(object)txtNgay_vay;
		CreateDataBinding(ref ojb, "Ngay_vay", "Value");
		txtNgay_vay = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_ky;
		CreateDataBinding(ref ojb, "Ngay_Ky", "Value");
		txtNgay_ky = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_Dh;
		CreateDataBinding(ref ojb, "Ngay_Dh", "Value");
		txtNgay_Dh = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtthoi_han;
		CreateDataBinding(ref ojb, "Thoi_han", "Value");
		txtthoi_han = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)cboTinh_theo;
		CreateDataBinding(ref ojb, "Tinh_theo", "SelectedValue");
		cboTinh_theo = (ComboBox)ojb;
		ojb = (Control)(object)cboPhuong_phap_tl;
		CreateDataBinding(ref ojb, "Phuong_phap", "SelectedValue");
		cboPhuong_phap_tl = (ComboBox)ojb;
		ojb = (Control)(object)cboKy_Tt_goc;
		CreateDataBinding(ref ojb, "Ky_tt_goc", "SelectedValue");
		cboKy_Tt_goc = (ComboBox)ojb;
		ojb = (Control)(object)cboKy_Tt_lai;
		CreateDataBinding(ref ojb, "Ky_Tt_Lai", "SelectedValue");
		cboKy_Tt_lai = (ComboBox)ojb;
		ojb = (Control)(object)txtTien_Nt;
		CreateDataBinding(ref ojb, "Tien_Nt", "Value");
		txtTien_Nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)cboMa_NT;
		CreateDataBinding(ref ojb, "Ma_Nt", "MA_NT");
		cboMa_NT = (AsComboBoxNT)(object)ojb;
		ojb = (Control)(object)txtTien;
		CreateDataBinding(ref ojb, "Tien", "Value");
		txtTien = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtLai_Suat;
		CreateDataBinding(ref ojb, "Lai_Suat", "Value");
		txtLai_Suat = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtLs_Qh;
		CreateDataBinding(ref ojb, "Ls_Qh", "Value");
		txtLs_Qh = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTk_Vay;
		CreateDataBinding(ref ojb, "Tk_Vay");
		txtTk_Vay = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Tk_Vay;
		CreateDataBinding(ref ojb, "Ten_Tk_Vay");
		lblTen_Tk_Vay = (Label)ojb;
		ojb = (Control)(object)txtTk_Cp;
		CreateDataBinding(ref ojb, "Tk_Cp");
		txtTk_Cp = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Tk_cp;
		CreateDataBinding(ref ojb, "Ten_Tk_Cp");
		lblTen_Tk_cp = (Label)ojb;
		ojb = (Control)(object)txtTk_Cp_Pt;
		CreateDataBinding(ref ojb, "Tk_Cp_Pt");
		txtTk_Cp_Pt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Tk_cp_pt;
		CreateDataBinding(ref ojb, "Ten_Tk_Cp_Pt");
		lblTen_Tk_cp_pt = (Label)ojb;
		ojb = (Control)(object)txtMa_Hd;
		CreateDataBinding(ref ojb, "Ma_Hd");
		txtMa_Hd = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_Hd;
		CreateDataBinding(ref ojb, "Ten_Hd");
		lblTen_Hd = (Label)ojb;
		ojb = (Control)(object)txtGhi_chu;
		CreateDataBinding(ref ojb, "Ghi_Chu");
		txtGhi_chu = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(txtMa_KU.Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtMa_KU, Helper.GetMess(50002).Description);
			((Control)txtMa_KU).Select();
			return false;
		}
		if (Operators.CompareString(txtTen_KU.Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtTen_KU, Helper.GetMess(50002).Description);
			((Control)txtTen_KU).Select();
			return false;
		}
		if (Operators.CompareString(txtSo_KU.Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtSo_KU, Helper.GetMess(50002).Description);
			((Control)txtSo_KU).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectEqual(txtNgay_vay.Value, (object)"#1/1/1900#", false))
		{
			SetControlError((Control)(object)txtNgay_vay, Helper.GetMessContent(50013));
			((Control)txtNgay_vay).Select();
			return false;
		}
		if (Operators.ConditionalCompareObjectGreater(txtNgay_ky.Value, txtNgay_Dh.Value, false))
		{
			CMessageBox.Show(MySettingsProperty.Settings.NgayTT_NgayKy);
			((Control)txtNgay_ky).Select();
			return false;
		}
		return base.ValidData();
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_KU).Select();
		}
		return flag;
	}

	private void frmCADMKUEdit_Load(object sender, EventArgs e)
	{
		if (!EditMode)
		{
			txtNgay_ky.Value = DateAndTime.Now;
			txtNgay_vay.Value = DateAndTime.Now;
			txtNgay_Dh.Value = DateAndTime.Now;
		}
	}

	private void cboTinh_theo_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboTinh_theo.SelectedIndex == 0)
		{
			lblLai_Suat.Text = "Lãi suất/tháng";
		}
		else
		{
			lblLai_Suat.Text = "Lãi suất/năm";
		}
		DateRange();
	}

	private void txtNgay_ky_Validated(object sender, EventArgs e)
	{
		if ((DateTime.Compare(Conversions.ToDate(txtNgay_ky.Value), Conversions.ToDate("6/6/2079")) > 0) | (DateTime.Compare(Conversions.ToDate(txtNgay_ky.Value), Conversions.ToDate("1/1/1900")) < 0))
		{
			txtNgay_ky.Value = DateAndTime.Now;
		}
	}

	private void txtNgay_vay_Validated(object sender, EventArgs e)
	{
		if ((DateTime.Compare(Conversions.ToDate(txtNgay_vay.Value), Conversions.ToDate("6/6/2079")) > 0) | (DateTime.Compare(Conversions.ToDate(txtNgay_vay.Value), Conversions.ToDate("1/1/1900")) < 0))
		{
			txtNgay_vay.Value = DateAndTime.Now;
		}
		DateRange();
	}

	private void txtthoi_han_Validating(object sender, CancelEventArgs e)
	{
		AsTextNumeric asTextNumeric = txtthoi_han;
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[1];
		AsTextNumeric asTextNumeric2 = txtthoi_han;
		array[0] = RuntimeHelpers.GetObjectValue(asTextNumeric2.Value);
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Abs", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			asTextNumeric2.Value = RuntimeHelpers.GetObjectValue(array2[0]);
		}
		asTextNumeric.Value = RuntimeHelpers.GetObjectValue(obj);
		DateRange();
	}

	private void DateRange()
	{
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			short num2 = default(short);
			if (Operators.ConditionalCompareObjectEqual(txtthoi_han.Value, (object)0, false))
			{
				txtNgay_Dh.Value = RuntimeHelpers.GetObjectValue(txtNgay_vay.Value);
			}
			else
			{
				DateTime dateTime = default(DateTime);
				dateTime = Conversions.ToDate(txtNgay_vay.Value);
				double num = 0.0;
				num2 = 0;
				num = Conversions.ToDate("06/06/2079").ToOADate();
				while (Operators.ConditionalCompareObjectLessEqual((object)num2, Operators.SubtractObject(txtthoi_han.Value, (object)1), false))
				{
					dateTime = ((!Operators.ConditionalCompareObjectEqual(((ListControl)cboTinh_theo).SelectedValue, (object)"1", false)) ? dateTime.AddYears(1) : dateTime.AddMonths(1));
					txtNgay_Dh.Value = dateTime;
					num2 = checked((short)(num2 + 1));
					if (Operators.ConditionalCompareObjectGreaterEqual(NewLateBinding.LateGet(txtNgay_Dh.Value, (Type)null, "ToOADate", new object[0], (string[])null, (Type[])null, (bool[])null), (object)num, false))
					{
						txtNgay_Dh.Value = Conversions.ToDate("06/06/2079");
						break;
					}
				}
			}
			txtthoi_han.Value = num2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
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
}
