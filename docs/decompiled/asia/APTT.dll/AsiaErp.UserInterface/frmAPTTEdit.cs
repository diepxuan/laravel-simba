using System;
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
public class frmAPTTEdit : frmOBEdit
{
	private IContainer components;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("txtNgay_ct")]
	private AsMaskedTextBox _txtNgay_ct;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("txtTK_pt")]
	private AsTextBox _txtTK_pt;

	[AccessedThroughProperty("txtMa_NCC")]
	private AsTextBox _txtMa_NCC;

	[AccessedThroughProperty("txtdien_giai")]
	private TextBox _txtdien_giai;

	[AccessedThroughProperty("txtls_qh")]
	private AsTextNumeric _txtls_qh;

	[AccessedThroughProperty("txttl_ck")]
	private AsTextNumeric _txttl_ck;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("txtHan_tt")]
	private AsTextNumeric _txtHan_tt;

	[AccessedThroughProperty("txtHan_ck")]
	private AsTextNumeric _txtHan_ck;

	[AccessedThroughProperty("txtMa_tt_po")]
	private AsTextBox _txtMa_tt_po;

	[AccessedThroughProperty("lblTen_kh")]
	private Label _lblTen_kh;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("lblTen_TT")]
	private Label _lblTen_TT;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("txtty_gia")]
	private AsTextNumeric _txtty_gia;

	[AccessedThroughProperty("cboNgoai_te")]
	private AsComboBoxNT _cboNgoai_te;

	[AccessedThroughProperty("txtNgay_ct_tt")]
	private AsMaskedTextBox _txtNgay_ct_tt;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("txtSo_ct_tt")]
	private TextBox _txtSo_ct_tt;

	[AccessedThroughProperty("Label25")]
	private Label _Label25;

	[AccessedThroughProperty("gbCT")]
	private GroupBox _gbCT;

	[AccessedThroughProperty("txtTien_hang")]
	private AsTextNumeric _txtTien_hang;

	[AccessedThroughProperty("txtTien_tt")]
	private AsTextNumeric _txtTien_tt;

	[AccessedThroughProperty("txtTong_tt")]
	private AsTextNumeric _txtTong_tt;

	[AccessedThroughProperty("txtDu_hd")]
	private AsTextNumeric _txtDu_hd;

	[AccessedThroughProperty("txtTien_thue")]
	private AsTextNumeric _txtTien_thue;

	[AccessedThroughProperty("txtTien_hang_nt")]
	private AsTextNumeric _txtTien_hang_nt;

	[AccessedThroughProperty("txtTien_thue_nt")]
	private AsTextNumeric _txtTien_thue_nt;

	[AccessedThroughProperty("txtTong_tt_nt")]
	private AsTextNumeric _txtTong_tt_nt;

	[AccessedThroughProperty("txtTien_tt_nt")]
	private AsTextNumeric _txtTien_tt_nt;

	[AccessedThroughProperty("txtDu_hd_nt")]
	private AsTextNumeric _txtDu_hd_nt;

	[AccessedThroughProperty("lblT_Tien0")]
	private Label _lblT_Tien0;

	[AccessedThroughProperty("lblTien_da_tt")]
	private Label _lblTien_da_tt;

	[AccessedThroughProperty("lblDu_tt")]
	private Label _lblDu_tt;

	[AccessedThroughProperty("lblT_tt")]
	private Label _lblT_tt;

	[AccessedThroughProperty("lblT_thue")]
	private Label _lblT_thue;

	[AccessedThroughProperty("lblTien_nt0")]
	private Label _lblTien_nt0;

	[AccessedThroughProperty("lblT_thue_nt")]
	private Label _lblT_thue_nt;

	[AccessedThroughProperty("lblT_tt_nt")]
	private Label _lblT_tt_nt;

	[AccessedThroughProperty("lblTien_da_tt_nt")]
	private Label _lblTien_da_tt_nt;

	[AccessedThroughProperty("lblDu_tt_nt")]
	private Label _lblDu_tt_nt;

	private bool bLoading;

	private string f_sTienHang;

	private string f_sTienThue;

	private string f_sTongThanhToan;

	private string f_sDaThanhToan;

	private string f_sConPhaiThanhToan;

	internal virtual Label Label12
	{
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual Label Label11
	{
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label11 = value;
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

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
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

	internal virtual Label Label13
	{
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual Label Label14
	{
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual Label Label20
	{
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label20 = value;
		}
	}

	internal virtual Label Label23
	{
		get
		{
			return _Label23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label23 = value;
		}
	}

	internal virtual Label Label22
	{
		get
		{
			return _Label22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label22 = value;
		}
	}

	internal virtual Label Label21
	{
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label21 = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_ct
	{
		get
		{
			return _txtNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtNgay_ct_Validated;
			if (_txtNgay_ct != null)
			{
				((Control)_txtNgay_ct).Validated -= eventHandler;
			}
			_txtNgay_ct = value;
			if (_txtNgay_ct != null)
			{
				((Control)_txtNgay_ct).Validated += eventHandler;
			}
		}
	}

	internal virtual TextBox txtSo_ct
	{
		get
		{
			return _txtSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_ct = value;
		}
	}

	internal virtual AsTextBox txtTK_pt
	{
		get
		{
			return _txtTK_pt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTK_pt = value;
		}
	}

	internal virtual AsTextBox txtMa_NCC
	{
		get
		{
			return _txtMa_NCC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_NCC = value;
		}
	}

	internal virtual TextBox txtdien_giai
	{
		get
		{
			return _txtdien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtdien_giai = value;
		}
	}

	internal virtual AsTextNumeric txtls_qh
	{
		get
		{
			return _txtls_qh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtls_qh = value;
		}
	}

	internal virtual AsTextNumeric txttl_ck
	{
		get
		{
			return _txttl_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txttl_ck = value;
		}
	}

	internal virtual AsTextBox txtMa_hd
	{
		get
		{
			return _txtMa_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_hd = value;
		}
	}

	internal virtual AsTextNumeric txtHan_tt
	{
		get
		{
			return _txtHan_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtHan_tt = value;
		}
	}

	internal virtual AsTextNumeric txtHan_ck
	{
		get
		{
			return _txtHan_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtHan_ck = value;
		}
	}

	internal virtual AsTextBox txtMa_tt_po
	{
		get
		{
			return _txtMa_tt_po;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_tt_po_AfterCodeValidating;
			if (_txtMa_tt_po != null)
			{
				_txtMa_tt_po.AfterCodeValidating -= obj;
			}
			_txtMa_tt_po = value;
			if (_txtMa_tt_po != null)
			{
				_txtMa_tt_po.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual Label lblTen_kh
	{
		get
		{
			return _lblTen_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_kh = value;
		}
	}

	internal virtual Label lblTen_tk
	{
		get
		{
			return _lblTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_tk = value;
		}
	}

	internal virtual Label lblTen_TT
	{
		get
		{
			return _lblTen_TT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_TT = value;
		}
	}

	internal virtual Label lblTen_hd
	{
		get
		{
			return _lblTen_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_hd = value;
		}
	}

	internal virtual AsTextNumeric txtty_gia
	{
		get
		{
			return _txtty_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TongVND_TextChanged;
			if (_txtty_gia != null)
			{
				((Control)_txtty_gia).TextChanged -= eventHandler;
			}
			_txtty_gia = value;
			if (_txtty_gia != null)
			{
				((Control)_txtty_gia).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsComboBoxNT cboNgoai_te
	{
		get
		{
			return _cboNgoai_te;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboNgoai_te_SelectedIndexChanged;
			if (_cboNgoai_te != null)
			{
				((ComboBox)_cboNgoai_te).SelectedIndexChanged -= eventHandler;
			}
			_cboNgoai_te = value;
			if (_cboNgoai_te != null)
			{
				((ComboBox)_cboNgoai_te).SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual AsMaskedTextBox txtNgay_ct_tt
	{
		get
		{
			return _txtNgay_ct_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNgay_ct_tt = value;
		}
	}

	internal virtual Label Label24
	{
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label24 = value;
		}
	}

	internal virtual TextBox txtSo_ct_tt
	{
		get
		{
			return _txtSo_ct_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_ct_tt = value;
		}
	}

	internal virtual Label Label25
	{
		get
		{
			return _Label25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label25 = value;
		}
	}

	internal virtual GroupBox gbCT
	{
		get
		{
			return _gbCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_gbCT = value;
		}
	}

	internal virtual AsTextNumeric txtTien_hang
	{
		get
		{
			return _txtTien_hang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TongNT_TextChanged;
			if (_txtTien_hang != null)
			{
				((Control)_txtTien_hang).TextChanged -= eventHandler;
			}
			_txtTien_hang = value;
			if (_txtTien_hang != null)
			{
				((Control)_txtTien_hang).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtTien_tt
	{
		get
		{
			return _txtTien_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = DuNT_TextChanged;
			if (_txtTien_tt != null)
			{
				((Control)_txtTien_tt).TextChanged -= eventHandler;
			}
			_txtTien_tt = value;
			if (_txtTien_tt != null)
			{
				((Control)_txtTien_tt).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtTong_tt
	{
		get
		{
			return _txtTong_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = DuNT_TextChanged;
			if (_txtTong_tt != null)
			{
				((Control)_txtTong_tt).TextChanged -= eventHandler;
			}
			_txtTong_tt = value;
			if (_txtTong_tt != null)
			{
				((Control)_txtTong_tt).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtDu_hd
	{
		get
		{
			return _txtDu_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtDu_hd = value;
		}
	}

	internal virtual AsTextNumeric txtTien_thue
	{
		get
		{
			return _txtTien_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TongNT_TextChanged;
			if (_txtTien_thue != null)
			{
				((Control)_txtTien_thue).TextChanged -= eventHandler;
			}
			_txtTien_thue = value;
			if (_txtTien_thue != null)
			{
				((Control)_txtTien_thue).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtTien_hang_nt
	{
		get
		{
			return _txtTien_hang_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TongVND_TextChanged;
			if (_txtTien_hang_nt != null)
			{
				((Control)_txtTien_hang_nt).TextChanged -= eventHandler;
			}
			_txtTien_hang_nt = value;
			if (_txtTien_hang_nt != null)
			{
				((Control)_txtTien_hang_nt).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtTien_thue_nt
	{
		get
		{
			return _txtTien_thue_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TongVND_TextChanged;
			if (_txtTien_thue_nt != null)
			{
				((Control)_txtTien_thue_nt).TextChanged -= eventHandler;
			}
			_txtTien_thue_nt = value;
			if (_txtTien_thue_nt != null)
			{
				((Control)_txtTien_thue_nt).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtTong_tt_nt
	{
		get
		{
			return _txtTong_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = DuVND_TextChanged;
			if (_txtTong_tt_nt != null)
			{
				((Control)_txtTong_tt_nt).TextChanged -= eventHandler;
			}
			_txtTong_tt_nt = value;
			if (_txtTong_tt_nt != null)
			{
				((Control)_txtTong_tt_nt).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtTien_tt_nt
	{
		get
		{
			return _txtTien_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = DuVND_TextChanged;
			if (_txtTien_tt_nt != null)
			{
				((Control)_txtTien_tt_nt).TextChanged -= eventHandler;
			}
			_txtTien_tt_nt = value;
			if (_txtTien_tt_nt != null)
			{
				((Control)_txtTien_tt_nt).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtDu_hd_nt
	{
		get
		{
			return _txtDu_hd_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtDu_hd_nt = value;
		}
	}

	internal virtual Label lblT_Tien0
	{
		get
		{
			return _lblT_Tien0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblT_Tien0 = value;
		}
	}

	internal virtual Label lblTien_da_tt
	{
		get
		{
			return _lblTien_da_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTien_da_tt = value;
		}
	}

	internal virtual Label lblDu_tt
	{
		get
		{
			return _lblDu_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblDu_tt = value;
		}
	}

	internal virtual Label lblT_tt
	{
		get
		{
			return _lblT_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblT_tt = value;
		}
	}

	internal virtual Label lblT_thue
	{
		get
		{
			return _lblT_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblT_thue = value;
		}
	}

	internal virtual Label lblTien_nt0
	{
		get
		{
			return _lblTien_nt0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTien_nt0 = value;
		}
	}

	internal virtual Label lblT_thue_nt
	{
		get
		{
			return _lblT_thue_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblT_thue_nt = value;
		}
	}

	internal virtual Label lblT_tt_nt
	{
		get
		{
			return _lblT_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblT_tt_nt = value;
		}
	}

	internal virtual Label lblTien_da_tt_nt
	{
		get
		{
			return _lblTien_da_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTien_da_tt_nt = value;
		}
	}

	internal virtual Label lblDu_tt_nt
	{
		get
		{
			return _lblDu_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblDu_tt_nt = value;
		}
	}

	public frmAPTTEdit()
	{
		((Form)this).Load += frmAPTTEdit_Load;
		((Form)this).Activated += frmAPTTEdit_Activated;
		bLoading = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label11 = new Label();
		Label12 = new Label();
		Label13 = new Label();
		Label14 = new Label();
		Label20 = new Label();
		Label21 = new Label();
		Label22 = new Label();
		Label23 = new Label();
		txtNgay_ct = new AsMaskedTextBox();
		txtMa_NCC = new AsTextBox();
		lblTen_kh = new Label();
		txtTK_pt = new AsTextBox();
		lblTen_tk = new Label();
		txtSo_ct = new TextBox();
		lblTen_TT = new Label();
		txtMa_tt_po = new AsTextBox();
		txtHan_ck = new AsTextNumeric();
		txtHan_tt = new AsTextNumeric();
		txtMa_hd = new AsTextBox();
		lblTen_hd = new Label();
		txttl_ck = new AsTextNumeric();
		txtls_qh = new AsTextNumeric();
		txtdien_giai = new TextBox();
		txtty_gia = new AsTextNumeric();
		cboNgoai_te = new AsComboBoxNT();
		txtNgay_ct_tt = new AsMaskedTextBox();
		Label24 = new Label();
		txtSo_ct_tt = new TextBox();
		Label25 = new Label();
		gbCT = new GroupBox();
		txtTien_hang = new AsTextNumeric();
		txtTien_tt = new AsTextNumeric();
		txtTong_tt = new AsTextNumeric();
		txtDu_hd = new AsTextNumeric();
		txtTien_thue = new AsTextNumeric();
		txtTien_hang_nt = new AsTextNumeric();
		txtTien_thue_nt = new AsTextNumeric();
		txtTong_tt_nt = new AsTextNumeric();
		txtTien_tt_nt = new AsTextNumeric();
		txtDu_hd_nt = new AsTextNumeric();
		lblT_Tien0 = new Label();
		lblTien_da_tt = new Label();
		lblDu_tt = new Label();
		lblT_tt = new Label();
		lblT_thue = new Label();
		lblTien_nt0 = new Label();
		lblT_thue_nt = new Label();
		lblT_tt_nt = new Label();
		lblTien_da_tt_nt = new Label();
		lblDu_tt_nt = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)gbCT).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(722, 430);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 27;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 380);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 380);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)gbCT);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct_tt);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct_tt);
		((Control)gbLine).Controls.Add((Control)(object)Label25);
		((Control)gbLine).Controls.Add((Control)(object)cboNgoai_te);
		((Control)gbLine).Controls.Add((Control)(object)txtty_gia);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_TT);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_hd);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_kh);
		((Control)gbLine).Controls.Add((Control)(object)txtls_qh);
		((Control)gbLine).Controls.Add((Control)(object)txttl_ck);
		((Control)gbLine).Controls.Add((Control)(object)txtdien_giai);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_hd);
		((Control)gbLine).Controls.Add((Control)(object)txtHan_tt);
		((Control)gbLine).Controls.Add((Control)(object)txtHan_ck);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_tt_po);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_pt);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_NCC);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct);
		((Control)gbLine).Controls.Add((Control)(object)Label22);
		((Control)gbLine).Controls.Add((Control)(object)Label21);
		((Control)gbLine).Controls.Add((Control)(object)Label20);
		((Control)gbLine).Controls.Add((Control)(object)Label23);
		((Control)gbLine).Controls.Add((Control)(object)Label14);
		((Control)gbLine).Controls.Add((Control)(object)Label13);
		((Control)gbLine).Controls.Add((Control)(object)Label24);
		((Control)gbLine).Controls.Add((Control)(object)Label11);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)Label12);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		GroupBox obj3 = gbLine;
		Size size = new Size(660, 365);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		gbLine.Text = "Thông tin chung";
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label12, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label11, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label24, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label13, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label14, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label23, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label20, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label21, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label22, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_NCC, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_pt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_tt_po, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtHan_ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtHan_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtdien_giai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txttl_ck, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtls_qh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_TT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtty_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboNgoai_te, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label25, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)gbCT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)Label1).Anchor = (AnchorStyles)9;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(476, 25);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(77, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 100;
		Label1.Text = "Ngày chứng từ";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(19, 25);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(47, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 101;
		Label2.Text = "Mã NCC";
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(19, 77);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(59, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 102;
		Label3.Text = "TK phải trả";
		((Control)Label4).Anchor = (AnchorStyles)9;
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(476, 130);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(47, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 103;
		Label4.Text = "Ngoại tệ";
		Label11.AutoSize = true;
		Label label9 = Label11;
		location = new Point(19, 103);
		((Control)label9).Location = location;
		((Control)Label11).Name = "Label11";
		Label label10 = Label11;
		size = new Size(39, 13);
		((Control)label10).Size = size;
		((Control)Label11).TabIndex = 110;
		Label11.Text = "Mã TT";
		((Control)Label12).Anchor = (AnchorStyles)9;
		Label12.AutoSize = true;
		Label label11 = Label12;
		location = new Point(476, 51);
		((Control)label11).Location = location;
		((Control)Label12).Name = "Label12";
		Label label12 = Label12;
		size = new Size(65, 13);
		((Control)label12).Size = size;
		((Control)Label12).TabIndex = 111;
		Label12.Text = "Số chứng từ";
		Label13.AutoSize = true;
		Label label13 = Label13;
		location = new Point(19, 130);
		((Control)label13).Location = location;
		((Control)Label13).Name = "Label13";
		Label label14 = Label13;
		size = new Size(80, 13);
		((Control)label14).Size = size;
		((Control)Label13).TabIndex = 112;
		Label13.Text = "Hạn chiết khấu";
		Label14.AutoSize = true;
		Label label15 = Label14;
		location = new Point(19, 51);
		((Control)label15).Location = location;
		((Control)Label14).Name = "Label14";
		Label label16 = Label14;
		size = new Size(71, 13);
		((Control)label16).Size = size;
		((Control)Label14).TabIndex = 113;
		Label14.Text = "Mã hợp đồng";
		Label20.AutoSize = true;
		Label label17 = Label20;
		location = new Point(231, 130);
		((Control)label17).Location = location;
		((Control)Label20).Name = "Label20";
		Label label18 = Label20;
		size = new Size(81, 13);
		((Control)label18).Size = size;
		((Control)Label20).TabIndex = 119;
		Label20.Text = "Hạn thanh toán";
		Label21.AutoSize = true;
		Label label19 = Label21;
		location = new Point(19, 155);
		((Control)label19).Location = location;
		((Control)Label21).Name = "Label21";
		Label label20 = Label21;
		size = new Size(37, 13);
		((Control)label20).Size = size;
		((Control)Label21).TabIndex = 120;
		Label21.Text = "TL CK";
		Label22.AutoSize = true;
		Label label21 = Label22;
		location = new Point(231, 155);
		((Control)label21).Location = location;
		((Control)Label22).Name = "Label22";
		Label label22 = Label22;
		size = new Size(39, 13);
		((Control)label22).Size = size;
		((Control)Label22).TabIndex = 121;
		Label22.Text = "LS QH";
		Label23.AutoSize = true;
		Label label23 = Label23;
		location = new Point(19, 180);
		((Control)label23).Location = location;
		((Control)Label23).Name = "Label23";
		Label label24 = Label23;
		size = new Size(48, 13);
		((Control)label24).Size = size;
		((Control)Label23).TabIndex = 122;
		Label23.Text = "Diễn giải";
		((Control)txtNgay_ct).Anchor = (AnchorStyles)9;
		txtNgay_ct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct;
		location = new Point(573, 21);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ct).Mask = "##/##/####";
		((Control)txtNgay_ct).Name = "txtNgay_ct";
		((MaskedTextBox)txtNgay_ct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ct;
		size = new Size(74, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ct).TabIndex = 4;
		((MaskedTextBox)txtNgay_ct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtMa_NCC.AutoLookup = true;
		txtMa_NCC.AutoValid = true;
		((TextBoxBase)txtMa_NCC).BackColor = SystemColors.Info;
		((TextBox)txtMa_NCC).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_NCC;
		location = new Point(125, 21);
		((Control)asTextBox).Location = location;
		txtMa_NCC.LookupCodeName = "Ma_kh";
		((Control)txtMa_NCC).Name = "txtMa_NCC";
		txtMa_NCC.NameControl = lblTen_kh;
		AsTextBox asTextBox2 = txtMa_NCC;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_NCC).TabIndex = 0;
		txtMa_NCC.UseAutoCompleteSource = true;
		((Control)lblTen_kh).Anchor = (AnchorStyles)13;
		Label obj4 = lblTen_kh;
		location = new Point(231, 23);
		((Control)obj4).Location = location;
		((Control)lblTen_kh).Name = "lblTen_kh";
		Label obj5 = lblTen_kh;
		size = new Size(239, 17);
		((Control)obj5).Size = size;
		((Control)lblTen_kh).TabIndex = 147;
		txtTK_pt.AutoLookup = true;
		txtTK_pt.AutoValid = true;
		((TextBoxBase)txtTK_pt).BackColor = SystemColors.Info;
		((TextBox)txtTK_pt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTK_pt;
		location = new Point(125, 73);
		((Control)asTextBox3).Location = location;
		txtTK_pt.LookupCodeName = "TK";
		txtTK_pt.LookupWhereCondition = "chi_tiet=1 and tk_cn=1";
		((Control)txtTK_pt).Name = "txtTK_pt";
		txtTK_pt.NameControl = lblTen_tk;
		txtTK_pt.SD = true;
		AsTextBox asTextBox4 = txtTK_pt;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTK_pt).TabIndex = 2;
		txtTK_pt.UseAutoCompleteSource = true;
		((Control)lblTen_tk).Anchor = (AnchorStyles)13;
		Label obj6 = lblTen_tk;
		location = new Point(231, 74);
		((Control)obj6).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj7 = lblTen_tk;
		size = new Size(239, 18);
		((Control)obj7).Size = size;
		((Control)lblTen_tk).TabIndex = 148;
		((Control)txtSo_ct).Anchor = (AnchorStyles)9;
		TextBox obj8 = txtSo_ct;
		location = new Point(573, 47);
		((Control)obj8).Location = location;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj9 = txtSo_ct;
		size = new Size(74, 20);
		((Control)obj9).Size = size;
		((Control)txtSo_ct).TabIndex = 5;
		((Control)lblTen_TT).Anchor = (AnchorStyles)13;
		Label obj10 = lblTen_TT;
		location = new Point(231, 101);
		((Control)obj10).Location = location;
		((Control)lblTen_TT).Name = "lblTen_TT";
		Label obj11 = lblTen_TT;
		size = new Size(239, 16);
		((Control)obj11).Size = size;
		((Control)lblTen_TT).TabIndex = 149;
		txtMa_tt_po.AutoLookup = true;
		txtMa_tt_po.AutoValid = true;
		((TextBoxBase)txtMa_tt_po).BackColor = SystemColors.Info;
		((TextBox)txtMa_tt_po).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_tt_po;
		location = new Point(125, 99);
		((Control)asTextBox5).Location = location;
		txtMa_tt_po.LookupCodeName = "Ma_tt_po";
		((Control)txtMa_tt_po).Name = "txtMa_tt_po";
		txtMa_tt_po.NameControl = lblTen_TT;
		AsTextBox asTextBox6 = txtMa_tt_po;
		size = new Size(100, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_tt_po).TabIndex = 3;
		txtMa_tt_po.UseAutoCompleteSource = true;
		txtMa_tt_po.ValidReturnFieldList = "han_ck,han_tt,tl_ck,ls_qh";
		txtHan_ck.DecimalSymbol = ".";
		txtHan_ck.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtHan_ck;
		location = new Point(125, 126);
		((Control)asTextNumeric).Location = location;
		txtHan_ck.Mask = "### ### ### ###";
		((Control)txtHan_ck).Name = "txtHan_ck";
		((TextBoxBase)txtHan_ck).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtHan_ck;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		txtHan_ck.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtHan_ck).TabIndex = 10;
		((Control)txtHan_ck).TabStop = false;
		((Control)txtHan_ck).Tag = "OA";
		((TextBox)txtHan_ck).Text = "0";
		((TextBox)txtHan_ck).TextAlign = (HorizontalAlignment)1;
		txtHan_ck.Value = 0;
		txtHan_tt.DecimalSymbol = ".";
		txtHan_tt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtHan_tt;
		location = new Point(341, 126);
		((Control)asTextNumeric3).Location = location;
		txtHan_tt.Mask = "### ### ### ###";
		((Control)txtHan_tt).Name = "txtHan_tt";
		((TextBoxBase)txtHan_tt).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtHan_tt;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		txtHan_tt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtHan_tt).TabIndex = 11;
		((Control)txtHan_tt).TabStop = false;
		((Control)txtHan_tt).Tag = "OA";
		((TextBox)txtHan_tt).Text = "0";
		((TextBox)txtHan_tt).TextAlign = (HorizontalAlignment)1;
		txtHan_tt.Value = 0;
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = true;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_hd;
		location = new Point(125, 47);
		((Control)asTextBox7).Location = location;
		txtMa_hd.LookupCodeName = "Ma_hd";
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox8 = txtMa_hd;
		size = new Size(100, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_hd).TabIndex = 1;
		txtMa_hd.UseAutoCompleteSource = true;
		((Control)lblTen_hd).Anchor = (AnchorStyles)13;
		Label obj12 = lblTen_hd;
		location = new Point(231, 50);
		((Control)obj12).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj13 = lblTen_hd;
		size = new Size(239, 15);
		((Control)obj13).Size = size;
		((Control)lblTen_hd).TabIndex = 150;
		txttl_ck.DecimalSymbol = ".";
		txttl_ck.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txttl_ck;
		location = new Point(125, 151);
		((Control)asTextNumeric5).Location = location;
		txttl_ck.Mask = "### ### ### ###.##";
		((Control)txttl_ck).Name = "txttl_ck";
		((TextBoxBase)txttl_ck).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txttl_ck;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		txttl_ck.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txttl_ck).TabIndex = 12;
		((Control)txttl_ck).TabStop = false;
		((Control)txttl_ck).Tag = "";
		((TextBox)txttl_ck).Text = "0.00";
		((TextBox)txttl_ck).TextAlign = (HorizontalAlignment)1;
		txttl_ck.Value = 0;
		txtls_qh.DecimalSymbol = ".";
		txtls_qh.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtls_qh;
		location = new Point(341, 151);
		((Control)asTextNumeric7).Location = location;
		txtls_qh.Mask = "### ### ### ###.##";
		((Control)txtls_qh).Name = "txtls_qh";
		((TextBoxBase)txtls_qh).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtls_qh;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		txtls_qh.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtls_qh).TabIndex = 13;
		((Control)txtls_qh).TabStop = false;
		((Control)txtls_qh).Tag = "";
		((TextBox)txtls_qh).Text = "0.00";
		((TextBox)txtls_qh).TextAlign = (HorizontalAlignment)1;
		txtls_qh.Value = 0;
		((Control)txtdien_giai).Anchor = (AnchorStyles)13;
		TextBox obj14 = txtdien_giai;
		location = new Point(125, 176);
		((Control)obj14).Location = location;
		((Control)txtdien_giai).Name = "txtdien_giai";
		TextBox obj15 = txtdien_giai;
		size = new Size(521, 20);
		((Control)obj15).Size = size;
		((Control)txtdien_giai).TabIndex = 10;
		((Control)txtty_gia).Anchor = (AnchorStyles)9;
		txtty_gia.DecimalSymbol = ".";
		txtty_gia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric9 = txtty_gia;
		location = new Point(589, 126);
		((Control)asTextNumeric9).Location = location;
		txtty_gia.Mask = "### ### ### ###.##";
		((Control)txtty_gia).Name = "txtty_gia";
		((TextBoxBase)txtty_gia).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtty_gia;
		size = new Size(58, 20);
		((Control)asTextNumeric10).Size = size;
		txtty_gia.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtty_gia).TabIndex = 9;
		((Control)txtty_gia).Tag = "FP";
		((TextBox)txtty_gia).Text = "0.00";
		((TextBox)txtty_gia).TextAlign = (HorizontalAlignment)1;
		txtty_gia.Value = 0;
		((Control)cboNgoai_te).Anchor = (AnchorStyles)9;
		((ComboBox)cboNgoai_te).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNgoai_te).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboNgoai_te;
		location = new Point(524, 126);
		((Control)asComboBoxNT).Location = location;
		cboNgoai_te.MA_NT = "";
		((Control)cboNgoai_te).Name = "cboNgoai_te";
		AsComboBoxNT asComboBoxNT2 = cboNgoai_te;
		size = new Size(59, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboNgoai_te).TabIndex = 8;
		((Control)txtNgay_ct_tt).Anchor = (AnchorStyles)9;
		txtNgay_ct_tt.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct_tt).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_ct_tt;
		location = new Point(573, 73);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_ct_tt).Mask = "##/##/####";
		((Control)txtNgay_ct_tt).Name = "txtNgay_ct_tt";
		((MaskedTextBox)txtNgay_ct_tt).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_ct_tt;
		size = new Size(74, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_ct_tt).TabIndex = 6;
		((MaskedTextBox)txtNgay_ct_tt).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_ct_tt;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		((Control)Label24).Anchor = (AnchorStyles)9;
		Label24.AutoSize = true;
		Label label25 = Label24;
		location = new Point(476, 77);
		((Control)label25).Location = location;
		((Control)Label24).Name = "Label24";
		Label label26 = Label24;
		size = new Size(86, 13);
		((Control)label26).Size = size;
		((Control)Label24).TabIndex = 117;
		Label24.Text = "Ngày thanh toán";
		((Control)txtSo_ct_tt).Anchor = (AnchorStyles)9;
		TextBox obj16 = txtSo_ct_tt;
		location = new Point(573, 99);
		((Control)obj16).Location = location;
		((Control)txtSo_ct_tt).Name = "txtSo_ct_tt";
		TextBox obj17 = txtSo_ct_tt;
		size = new Size(74, 20);
		((Control)obj17).Size = size;
		((Control)txtSo_ct_tt).TabIndex = 7;
		((Control)Label25).Anchor = (AnchorStyles)9;
		Label25.AutoSize = true;
		Label label27 = Label25;
		location = new Point(476, 103);
		((Control)label27).Location = location;
		((Control)Label25).Name = "Label25";
		Label label28 = Label25;
		size = new Size(91, 13);
		((Control)label28).Size = size;
		((Control)Label25).TabIndex = 152;
		Label25.Text = "Số CT thanh toán";
		((Control)gbCT).Anchor = (AnchorStyles)13;
		((Control)gbCT).Controls.Add((Control)(object)txtTien_hang);
		((Control)gbCT).Controls.Add((Control)(object)txtTien_tt);
		((Control)gbCT).Controls.Add((Control)(object)txtTong_tt);
		((Control)gbCT).Controls.Add((Control)(object)txtDu_hd);
		((Control)gbCT).Controls.Add((Control)(object)txtTien_thue);
		((Control)gbCT).Controls.Add((Control)(object)txtTien_hang_nt);
		((Control)gbCT).Controls.Add((Control)(object)txtTien_thue_nt);
		((Control)gbCT).Controls.Add((Control)(object)txtTong_tt_nt);
		((Control)gbCT).Controls.Add((Control)(object)txtTien_tt_nt);
		((Control)gbCT).Controls.Add((Control)(object)txtDu_hd_nt);
		((Control)gbCT).Controls.Add((Control)(object)lblT_Tien0);
		((Control)gbCT).Controls.Add((Control)(object)lblTien_da_tt);
		((Control)gbCT).Controls.Add((Control)(object)lblDu_tt);
		((Control)gbCT).Controls.Add((Control)(object)lblT_tt);
		((Control)gbCT).Controls.Add((Control)(object)lblT_thue);
		((Control)gbCT).Controls.Add((Control)(object)lblTien_nt0);
		((Control)gbCT).Controls.Add((Control)(object)lblT_thue_nt);
		((Control)gbCT).Controls.Add((Control)(object)lblT_tt_nt);
		((Control)gbCT).Controls.Add((Control)(object)lblTien_da_tt_nt);
		((Control)gbCT).Controls.Add((Control)(object)lblDu_tt_nt);
		GroupBox obj18 = gbCT;
		location = new Point(6, 201);
		((Control)obj18).Location = location;
		((Control)gbCT).Name = "gbCT";
		GroupBox obj19 = gbCT;
		size = new Size(648, 158);
		((Control)obj19).Size = size;
		((Control)gbCT).TabIndex = 100;
		gbCT.TabStop = false;
		gbCT.Text = "Chi tiết";
		txtTien_hang.DecimalSymbol = ".";
		txtTien_hang.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric11 = txtTien_hang;
		location = new Point(512, 21);
		((Control)asTextNumeric11).Location = location;
		txtTien_hang.Mask = "### ### ### ###.##";
		((Control)txtTien_hang).Name = "txtTien_hang";
		AsTextNumeric asTextNumeric12 = txtTien_hang;
		size = new Size(107, 20);
		((Control)asTextNumeric12).Size = size;
		txtTien_hang.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTien_hang).TabIndex = 5;
		((Control)txtTien_hang).Tag = "OA";
		((TextBox)txtTien_hang).Text = "0.00";
		((TextBox)txtTien_hang).TextAlign = (HorizontalAlignment)1;
		txtTien_hang.Value = 0;
		txtTien_tt.DecimalSymbol = ".";
		txtTien_tt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric13 = txtTien_tt;
		location = new Point(512, 99);
		((Control)asTextNumeric13).Location = location;
		txtTien_tt.Mask = "### ### ### ###.##";
		((Control)txtTien_tt).Name = "txtTien_tt";
		AsTextNumeric asTextNumeric14 = txtTien_tt;
		size = new Size(107, 20);
		((Control)asTextNumeric14).Size = size;
		txtTien_tt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTien_tt).TabIndex = 8;
		((Control)txtTien_tt).Tag = "OA";
		((TextBox)txtTien_tt).Text = "0.00";
		((TextBox)txtTien_tt).TextAlign = (HorizontalAlignment)1;
		txtTien_tt.Value = 0;
		txtTong_tt.DecimalSymbol = ".";
		txtTong_tt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric15 = txtTong_tt;
		location = new Point(512, 73);
		((Control)asTextNumeric15).Location = location;
		txtTong_tt.Mask = "### ### ### ###.##";
		((Control)txtTong_tt).Name = "txtTong_tt";
		AsTextNumeric asTextNumeric16 = txtTong_tt;
		size = new Size(107, 20);
		((Control)asTextNumeric16).Size = size;
		txtTong_tt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTong_tt).TabIndex = 7;
		((Control)txtTong_tt).Tag = "OA";
		((TextBox)txtTong_tt).Text = "0.00";
		((TextBox)txtTong_tt).TextAlign = (HorizontalAlignment)1;
		txtTong_tt.Value = 0;
		txtDu_hd.DecimalSymbol = ".";
		txtDu_hd.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric17 = txtDu_hd;
		location = new Point(512, 125);
		((Control)asTextNumeric17).Location = location;
		txtDu_hd.Mask = "### ### ### ###.##";
		((Control)txtDu_hd).Name = "txtDu_hd";
		AsTextNumeric asTextNumeric18 = txtDu_hd;
		size = new Size(107, 20);
		((Control)asTextNumeric18).Size = size;
		txtDu_hd.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtDu_hd).TabIndex = 9;
		((Control)txtDu_hd).Tag = "OA";
		((TextBox)txtDu_hd).Text = "0.00";
		((TextBox)txtDu_hd).TextAlign = (HorizontalAlignment)1;
		txtDu_hd.Value = 0;
		txtTien_thue.DecimalSymbol = ".";
		txtTien_thue.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric19 = txtTien_thue;
		location = new Point(512, 47);
		((Control)asTextNumeric19).Location = location;
		txtTien_thue.Mask = "### ### ### ###.##";
		((Control)txtTien_thue).Name = "txtTien_thue";
		AsTextNumeric asTextNumeric20 = txtTien_thue;
		size = new Size(107, 20);
		((Control)asTextNumeric20).Size = size;
		txtTien_thue.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTien_thue).TabIndex = 6;
		((Control)txtTien_thue).Tag = "OA";
		((TextBox)txtTien_thue).Text = "0.00";
		((TextBox)txtTien_thue).TextAlign = (HorizontalAlignment)1;
		txtTien_thue.Value = 0;
		txtTien_hang_nt.DecimalSymbol = ".";
		txtTien_hang_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric21 = txtTien_hang_nt;
		location = new Point(150, 21);
		((Control)asTextNumeric21).Location = location;
		txtTien_hang_nt.Mask = "### ### ### ###.##";
		((Control)txtTien_hang_nt).Name = "txtTien_hang_nt";
		AsTextNumeric asTextNumeric22 = txtTien_hang_nt;
		size = new Size(107, 20);
		((Control)asTextNumeric22).Size = size;
		txtTien_hang_nt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTien_hang_nt).TabIndex = 0;
		((Control)txtTien_hang_nt).Tag = "FA";
		((TextBox)txtTien_hang_nt).Text = "0.00";
		((TextBox)txtTien_hang_nt).TextAlign = (HorizontalAlignment)1;
		txtTien_hang_nt.Value = 0;
		txtTien_thue_nt.DecimalSymbol = ".";
		txtTien_thue_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric23 = txtTien_thue_nt;
		location = new Point(150, 47);
		((Control)asTextNumeric23).Location = location;
		txtTien_thue_nt.Mask = "### ### ### ###.##";
		((Control)txtTien_thue_nt).Name = "txtTien_thue_nt";
		AsTextNumeric asTextNumeric24 = txtTien_thue_nt;
		size = new Size(107, 20);
		((Control)asTextNumeric24).Size = size;
		txtTien_thue_nt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTien_thue_nt).TabIndex = 1;
		((Control)txtTien_thue_nt).Tag = "FA";
		((TextBox)txtTien_thue_nt).Text = "0.00";
		((TextBox)txtTien_thue_nt).TextAlign = (HorizontalAlignment)1;
		txtTien_thue_nt.Value = 0;
		txtTong_tt_nt.DecimalSymbol = ".";
		txtTong_tt_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric25 = txtTong_tt_nt;
		location = new Point(150, 73);
		((Control)asTextNumeric25).Location = location;
		txtTong_tt_nt.Mask = "### ### ### ###.##";
		((Control)txtTong_tt_nt).Name = "txtTong_tt_nt";
		AsTextNumeric asTextNumeric26 = txtTong_tt_nt;
		size = new Size(107, 20);
		((Control)asTextNumeric26).Size = size;
		txtTong_tt_nt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTong_tt_nt).TabIndex = 2;
		((Control)txtTong_tt_nt).Tag = "FA";
		((TextBox)txtTong_tt_nt).Text = "0.00";
		((TextBox)txtTong_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtTong_tt_nt.Value = 0;
		txtTien_tt_nt.DecimalSymbol = ".";
		txtTien_tt_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric27 = txtTien_tt_nt;
		location = new Point(150, 99);
		((Control)asTextNumeric27).Location = location;
		txtTien_tt_nt.Mask = "### ### ### ###.##";
		((Control)txtTien_tt_nt).Name = "txtTien_tt_nt";
		AsTextNumeric asTextNumeric28 = txtTien_tt_nt;
		size = new Size(107, 20);
		((Control)asTextNumeric28).Size = size;
		txtTien_tt_nt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTien_tt_nt).TabIndex = 3;
		((Control)txtTien_tt_nt).Tag = "FA";
		((TextBox)txtTien_tt_nt).Text = "0.00";
		((TextBox)txtTien_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtTien_tt_nt.Value = 0;
		txtDu_hd_nt.DecimalSymbol = ".";
		txtDu_hd_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric29 = txtDu_hd_nt;
		location = new Point(150, 125);
		((Control)asTextNumeric29).Location = location;
		txtDu_hd_nt.Mask = "### ### ### ###.##";
		((Control)txtDu_hd_nt).Name = "txtDu_hd_nt";
		AsTextNumeric asTextNumeric30 = txtDu_hd_nt;
		size = new Size(107, 20);
		((Control)asTextNumeric30).Size = size;
		txtDu_hd_nt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtDu_hd_nt).TabIndex = 4;
		((Control)txtDu_hd_nt).Tag = "FA";
		((TextBox)txtDu_hd_nt).Text = "0.00";
		((TextBox)txtDu_hd_nt).TextAlign = (HorizontalAlignment)1;
		txtDu_hd_nt.Value = 0;
		lblT_Tien0.AutoSize = true;
		Label obj20 = lblT_Tien0;
		location = new Point(377, 25);
		((Control)obj20).Location = location;
		((Control)lblT_Tien0).Name = "lblT_Tien0";
		Label obj21 = lblT_Tien0;
		size = new Size(55, 13);
		((Control)obj21).Size = size;
		((Control)lblT_Tien0).TabIndex = 134;
		lblT_Tien0.Text = "Tiền hàng";
		lblTien_da_tt.AutoSize = true;
		Label obj22 = lblTien_da_tt;
		location = new Point(377, 103);
		((Control)obj22).Location = location;
		((Control)lblTien_da_tt).Name = "lblTien_da_tt";
		Label obj23 = lblTien_da_tt;
		size = new Size(75, 13);
		((Control)obj23).Size = size;
		((Control)lblTien_da_tt).TabIndex = 137;
		lblTien_da_tt.Text = "Đã thanh toán";
		lblDu_tt.AutoSize = true;
		Label obj24 = lblDu_tt;
		location = new Point(377, 129);
		((Control)obj24).Location = location;
		((Control)lblDu_tt).Name = "lblDu_tt";
		Label obj25 = lblDu_tt;
		size = new Size(103, 13);
		((Control)obj25).Size = size;
		((Control)lblDu_tt).TabIndex = 138;
		lblDu_tt.Text = "Còn phải thanh toán";
		lblT_tt.AutoSize = true;
		Label obj26 = lblT_tt;
		location = new Point(377, 77);
		((Control)obj26).Location = location;
		((Control)lblT_tt).Name = "lblT_tt";
		Label obj27 = lblT_tt;
		size = new Size(86, 13);
		((Control)obj27).Size = size;
		((Control)lblT_tt).TabIndex = 136;
		lblT_tt.Text = "Tổng thanh toán";
		lblT_thue.AutoSize = true;
		Label obj28 = lblT_thue;
		location = new Point(377, 51);
		((Control)obj28).Location = location;
		((Control)lblT_thue).Name = "lblT_thue";
		Label obj29 = lblT_thue;
		size = new Size(52, 13);
		((Control)obj29).Size = size;
		((Control)lblT_thue).TabIndex = 135;
		lblT_thue.Text = "Tiền thuế";
		lblTien_nt0.AutoSize = true;
		Label obj30 = lblTien_nt0;
		location = new Point(13, 25);
		((Control)obj30).Location = location;
		((Control)lblTien_nt0).Name = "lblTien_nt0";
		Label obj31 = lblTien_nt0;
		size = new Size(73, 13);
		((Control)obj31).Size = size;
		((Control)lblTien_nt0).TabIndex = 129;
		lblTien_nt0.Text = "Tiền hàng NT";
		lblT_thue_nt.AutoSize = true;
		Label obj32 = lblT_thue_nt;
		location = new Point(13, 51);
		((Control)obj32).Location = location;
		((Control)lblT_thue_nt).Name = "lblT_thue_nt";
		Label obj33 = lblT_thue_nt;
		size = new Size(70, 13);
		((Control)obj33).Size = size;
		((Control)lblT_thue_nt).TabIndex = 130;
		lblT_thue_nt.Text = "Tiền thuế NT";
		lblT_tt_nt.AutoSize = true;
		Label obj34 = lblT_tt_nt;
		location = new Point(13, 77);
		((Control)obj34).Location = location;
		((Control)lblT_tt_nt).Name = "lblT_tt_nt";
		Label obj35 = lblT_tt_nt;
		size = new Size(104, 13);
		((Control)obj35).Size = size;
		((Control)lblT_tt_nt).TabIndex = 131;
		lblT_tt_nt.Text = "Tổng thanh toán NT";
		lblTien_da_tt_nt.AutoSize = true;
		Label obj36 = lblTien_da_tt_nt;
		location = new Point(13, 103);
		((Control)obj36).Location = location;
		((Control)lblTien_da_tt_nt).Name = "lblTien_da_tt_nt";
		Label obj37 = lblTien_da_tt_nt;
		size = new Size(93, 13);
		((Control)obj37).Size = size;
		((Control)lblTien_da_tt_nt).TabIndex = 132;
		lblTien_da_tt_nt.Text = "Đã thanh toán NT";
		lblDu_tt_nt.AutoSize = true;
		Label obj38 = lblDu_tt_nt;
		location = new Point(13, 129);
		((Control)obj38).Location = location;
		((Control)lblDu_tt_nt).Name = "lblDu_tt_nt";
		Label obj39 = lblDu_tt_nt;
		size = new Size(121, 13);
		((Control)obj39).Size = size;
		((Control)lblDu_tt_nt).TabIndex = 133;
		lblDu_tt_nt.Text = "Còn phải thanh toán NT";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(684, 412);
		((Form)this).ClientSize = size;
		((Form)this).FormBorderStyle = (FormBorderStyle)4;
		((Control)this).Name = "frmAPTTEdit";
		((Form)this).Text = "frmAPTTEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)gbCT).ResumeLayout(false);
		((Control)gbCT).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((Control)txtMa_NCC).Select();
		f_sTienHang = lblT_Tien0.Text;
		f_sTienThue = lblT_thue.Text;
		f_sTongThanhToan = lblT_tt.Text;
		f_sDaThanhToan = lblTien_da_tt.Text;
		f_sConPhaiThanhToan = lblDu_tt.Text;
		string ma_nt = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		lblT_Tien0.Text = f_sTienHang + " " + ma_nt;
		lblT_thue.Text = f_sTienThue + " " + ma_nt;
		lblT_tt.Text = f_sTongThanhToan + " " + ma_nt;
		lblTien_da_tt.Text = f_sDaThanhToan + " " + ma_nt;
		lblDu_tt.Text = f_sConPhaiThanhToan + " " + ma_nt;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		MaskTextBoxAll(((Control)gbLine).Controls);
		MaskTextBoxAll(((Control)gbCT).Controls);
	}

	protected override void DataBinding()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		bLoading = true;
		base.DataBinding();
		Control ojb = (Control)(object)txtNgay_ct;
		CreateDataBinding(ref ojb, "ngay_ct", "Value");
		txtNgay_ct = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "so_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)txtMa_NCC;
		CreateDataBinding(ref ojb, "ma_kh");
		txtMa_NCC = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_kh;
		CreateDataBinding(ref ojb, "ten_kh");
		lblTen_kh = (Label)ojb;
		ojb = (Control)(object)txtMa_tt_po;
		CreateDataBinding(ref ojb, "Ma_tt_po");
		txtMa_tt_po = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtHan_tt;
		CreateDataBinding(ref ojb, "han_tt", "Value");
		txtHan_tt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtHan_ck;
		CreateDataBinding(ref ojb, "han_ck", "Value");
		txtHan_ck = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txttl_ck;
		CreateDataBinding(ref ojb, "tl_ck");
		txttl_ck = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtls_qh;
		CreateDataBinding(ref ojb, "ls_qh");
		txtls_qh = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMa_hd;
		CreateDataBinding(ref ojb, "Ma_hd");
		txtMa_hd = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_ct_tt;
		CreateDataBinding(ref ojb, "ngay_ct_tt", "Value");
		txtNgay_ct_tt = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_ct_tt;
		CreateDataBinding(ref ojb, "so_ct_tt");
		txtSo_ct_tt = (TextBox)ojb;
		ojb = (Control)(object)cboNgoai_te;
		CreateDataBinding(ref ojb, "ma_nt");
		cboNgoai_te = (AsComboBoxNT)(object)ojb;
		ojb = (Control)(object)txtTien_hang;
		CreateDataBinding(ref ojb, "t_tien0", "Value");
		txtTien_hang = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_thue;
		CreateDataBinding(ref ojb, "t_thue", "Value");
		txtTien_thue = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTong_tt;
		CreateDataBinding(ref ojb, "t_tt", "Value");
		txtTong_tt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_tt;
		CreateDataBinding(ref ojb, "tien_da_tt", "Value");
		txtTien_tt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDu_hd;
		CreateDataBinding(ref ojb, "du_hd", "Value");
		txtDu_hd = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_hang_nt;
		CreateDataBinding(ref ojb, "t_tien_nt0", "Value");
		txtTien_hang_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_thue_nt;
		CreateDataBinding(ref ojb, "t_thue_nt", "Value");
		txtTien_thue_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTong_tt_nt;
		CreateDataBinding(ref ojb, "t_tt_nt", "Value");
		txtTong_tt_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_tt_nt;
		CreateDataBinding(ref ojb, "tien_da_tt_nt", "Value");
		txtTien_tt_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDu_hd_nt;
		CreateDataBinding(ref ojb, "du_hd_nt", "Value");
		txtDu_hd_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTK_pt;
		CreateDataBinding(ref ojb, "TK_pt");
		txtTK_pt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtty_gia;
		CreateDataBinding(ref ojb, "ty_gia", "Value");
		txtty_gia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtdien_giai;
		CreateDataBinding(ref ojb, "dien_giai");
		txtdien_giai = (TextBox)ojb;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (flag)
		{
			RowToEdit.AcceptChanges();
			AutoIns();
		}
		return flag;
	}

	protected override bool UpdateDB()
	{
		bool flag = base.UpdateDB();
		if (flag)
		{
			RowToEdit.AcceptChanges();
			AutoIns();
		}
		return flag;
	}

	protected override bool ValidData()
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		bLoading = true;
		if (Operators.CompareString(((TextBox)txtMa_NCC).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtMa_NCC, Helper.GetMess(50002).Description);
			return false;
		}
		epNotice.SetError((Control)(object)txtMa_NCC, "");
		if (Operators.CompareString(((TextBox)txtTK_pt).Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtTK_pt, Helper.GetMess(50002).Description);
			return false;
		}
		epNotice.SetError((Control)(object)txtTK_pt, "");
		if (Operators.ConditionalCompareObjectEqual(txtNgay_ct.Value, (object)new DateTime(599266080000000000L), false))
		{
			epNotice.SetError((Control)(object)txtNgay_ct, Conversions.ToString(txtNgay_ct.Value));
			((Control)txtNgay_ct).Select();
			bool result = default(bool);
			return result;
		}
		if (Operators.ConditionalCompareObjectLessEqual(txtNgay_ct.Value, (object)AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks, false))
		{
			CMessageBox.Show(50136);
			return false;
		}
		if (Operators.CompareString(txtSo_ct_tt.Text.Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtSo_ct_tt, Helper.GetMess(50002).Description);
			return false;
		}
		epNotice.SetError((Control)(object)txtSo_ct_tt, "");
		if (!Commons.ChkVoucherNumber(Conversions.ToString(RowToEdit["Ma_ct"]), Conversions.ToString(RowToEdit["Stt_Rec"]), txtSo_ct.Text, Conversions.ToDate(txtNgay_ct.Value)))
		{
			CMessageBox.Show(50014);
			((Control)txtSo_ct).Select();
			return false;
		}
		if (!CanhBaoDieuChinh())
		{
			return false;
		}
		return base.ValidData();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_NCC).Select();
	}

	protected override bool SetToRow()
	{
		base.SetToRow();
		if (!EditMode)
		{
			RowToEdit["Stt_Rec"] = Commons.Get_SttRec(MyMenuInfo.par1);
			RowToEdit["Ma_ct"] = MyMenuInfo.par1;
			RowToEdit["Stt_Rec_tt"] = Commons.Get_SttRec(MyMenuInfo.par2);
			RowToEdit["Ma_ct_tt"] = MyMenuInfo.par2;
		}
		RowToEdit["ten_kh"] = lblTen_kh.Text;
		bool result = default(bool);
		return result;
	}

	private void frmAPTTEdit_Load(object sender, EventArgs e)
	{
		if (!EditMode)
		{
			txtNgay_ct.Value = DateAndTime.Now.Date;
			txtNgay_ct_tt.Value = DateAndTime.Now.Date;
		}
		if (Operators.CompareString(((ComboBox)cboNgoai_te).Text, "VND", false) == 0)
		{
			txtty_gia.Value = "1.00";
			((TextBoxBase)txtty_gia).ReadOnly = true;
		}
		else if (!EditMode)
		{
			txtty_gia.Value = Commons.Get_TyGia(((ComboBox)cboNgoai_te).Text, Conversions.ToDate(txtNgay_ct.Value));
			((TextBoxBase)txtty_gia).ReadOnly = false;
		}
	}

	private void txtMa_tt_po_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		try
		{
			if (e.ValidatedRow != null)
			{
				txtHan_ck.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["han_ck"]);
				txtHan_tt.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["han_tt"]);
				txttl_ck.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["tl_ck"]);
				txtls_qh.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ls_qh"]);
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

	private void cboNgoai_te_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ComboBox)cboNgoai_te).Text, "VND", false) == 0)
		{
			txtty_gia.Value = "1.00";
			((TextBoxBase)txtty_gia).ReadOnly = true;
			InitControl(bShow: false);
			((Control)txtTien_hang_nt).Tag = "OA";
			((Control)txtTien_thue_nt).Tag = "OA";
			((Control)txtTong_tt_nt).Tag = "OA";
			((Control)txtTien_tt_nt).Tag = "OA";
			((Control)txtDu_hd_nt).Tag = "OA";
		}
		else
		{
			if (!bLoading)
			{
				txtty_gia.Value = Commons.Get_TyGia(((ComboBox)cboNgoai_te).Text, Conversions.ToDate(txtNgay_ct.Value));
			}
			((TextBoxBase)txtty_gia).ReadOnly = false;
			InitControl(bShow: true);
			((Control)txtTien_hang_nt).Tag = "FA";
			((Control)txtTien_thue_nt).Tag = "FA";
			((Control)txtTong_tt_nt).Tag = "FA";
			((Control)txtTien_tt_nt).Tag = "FA";
			((Control)txtDu_hd_nt).Tag = "FA";
			((Control)txtTien_hang).Tag = "OA";
			((Control)txtTien_thue).Tag = "OA";
			((Control)txtTong_tt).Tag = "OA";
			((Control)txtTien_tt).Tag = "OA";
			((Control)txtDu_hd).Tag = "OA";
		}
		CalVND();
		MaskTextBoxAll(((Control)gbCT).Controls);
	}

	private void frmAPTTEdit_Activated(object sender, EventArgs e)
	{
		if (bLoading)
		{
			cboNgoai_te_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			bLoading = false;
		}
	}

	private void TongNT_TextChanged(object sender, EventArgs e)
	{
		if (!bLoading)
		{
			txtTong_tt.Value = Operators.AddObject(txtTien_hang.Value, txtTien_thue.Value);
			txtDu_hd.Value = Operators.SubtractObject(txtTong_tt.Value, txtTien_tt.Value);
		}
	}

	private void DuNT_TextChanged(object sender, EventArgs e)
	{
		if (!bLoading)
		{
			txtDu_hd.Value = Operators.SubtractObject(txtTong_tt.Value, txtTien_tt.Value);
		}
	}

	private void TongVND_TextChanged(object sender, EventArgs e)
	{
		if (!bLoading)
		{
			txtTong_tt_nt.Value = Operators.AddObject(txtTien_hang_nt.Value, txtTien_thue_nt.Value);
			txtDu_hd_nt.Value = Operators.SubtractObject(txtTong_tt_nt.Value, txtTien_tt_nt.Value);
			CalVND();
		}
	}

	private void DuVND_TextChanged(object sender, EventArgs e)
	{
		if (!bLoading)
		{
			txtDu_hd_nt.Value = Operators.SubtractObject(txtTong_tt_nt.Value, txtTien_tt_nt.Value);
			CalVND();
		}
	}

	private void txtNgay_ct_Validated(object sender, EventArgs e)
	{
		if (!EditMode)
		{
			if (Operators.CompareString(((ComboBox)cboNgoai_te).Text, "VND", false) == 0)
			{
				txtty_gia.Value = "1.00";
				((TextBoxBase)txtty_gia).ReadOnly = true;
			}
			else
			{
				txtty_gia.Value = Commons.Get_TyGia(((ComboBox)cboNgoai_te).Text, Conversions.ToDate(txtNgay_ct.Value));
				((TextBoxBase)txtty_gia).ReadOnly = false;
			}
			epNotice.Clear();
		}
	}

	private void CalVND()
	{
		if (!bLoading)
		{
			txtTien_hang.Value = Operators.MultiplyObject(txtTien_hang_nt.Value, txtty_gia.Value);
			txtTien_thue.Value = Operators.MultiplyObject(txtTien_thue_nt.Value, txtty_gia.Value);
			txtTien_tt.Value = Operators.MultiplyObject(txtTien_tt_nt.Value, txtty_gia.Value);
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

	protected void InitControl(bool bShow)
	{
		string text = ((ComboBox)cboNgoai_te).Text;
		lblTien_nt0.Text = f_sTienHang + " " + text;
		lblT_thue_nt.Text = f_sTienThue + " " + text;
		lblT_tt_nt.Text = f_sTongThanhToan + " " + text;
		lblTien_da_tt_nt.Text = f_sDaThanhToan + " " + text;
		lblDu_tt_nt.Text = f_sConPhaiThanhToan + " " + text;
		((Control)txtTien_hang).Visible = bShow;
		((Control)txtTien_thue).Visible = bShow;
		((Control)txtTong_tt).Visible = bShow;
		((Control)txtTien_tt).Visible = bShow;
		((Control)txtDu_hd).Visible = bShow;
		((Control)lblT_Tien0).Visible = bShow;
		((Control)lblT_thue).Visible = bShow;
		((Control)lblT_tt).Visible = bShow;
		((Control)lblTien_da_tt).Visible = bShow;
		((Control)lblDu_tt).Visible = bShow;
	}

	protected void AutoIns()
	{
		if (Operators.CompareString(((ComboBox)cboNgoai_te).Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			RowToEdit["t_tien0"] = RuntimeHelpers.GetObjectValue(txtTien_hang_nt.Value);
			RowToEdit["t_thue"] = RuntimeHelpers.GetObjectValue(txtTien_thue_nt.Value);
			RowToEdit["t_tt"] = RuntimeHelpers.GetObjectValue(txtTong_tt_nt.Value);
			RowToEdit["tien_da_tt"] = RuntimeHelpers.GetObjectValue(txtTien_tt_nt.Value);
			RowToEdit["du_hd"] = RuntimeHelpers.GetObjectValue(txtDu_hd.Value);
		}
	}

	private bool CanhBaoDieuChinh()
	{
		if (Conversions.ToDouble(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh) == 0.0)
		{
			return true;
		}
		checked
		{
			int num = (int)Math.Round(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_gia_toi_da);
			int num2 = (int)Math.Round(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_tien_nt_toi_da);
			bool flag = false;
			if (Operators.CompareString(((ComboBox)cboNgoai_te).Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.SubtractObject(txtTong_tt_nt.Value, txtTien_hang_nt.Value), txtTien_thue_nt.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTong_tt_nt, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTong_tt_nt, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.AddObject(Operators.SubtractObject(txtDu_hd_nt.Value, txtTong_tt_nt.Value), txtTien_tt_nt.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtDu_hd_nt, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtDu_hd_nt, "");
				}
			}
			else
			{
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.SubtractObject(txtTong_tt_nt.Value, txtTien_hang_nt.Value), txtTien_thue_nt.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num2, false))
				{
					epNotice.SetError((Control)(object)txtTong_tt_nt, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTong_tt_nt, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.AddObject(Operators.SubtractObject(txtDu_hd_nt.Value, txtTong_tt_nt.Value), txtTien_tt_nt.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num2, false))
				{
					epNotice.SetError((Control)(object)txtDu_hd_nt, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtDu_hd_nt, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(txtTien_hang.Value, Operators.MultiplyObject(txtTien_hang_nt.Value, txtty_gia.Value)) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTien_hang, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTien_hang, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(txtTien_thue.Value, Operators.MultiplyObject(txtTien_thue_nt.Value, txtty_gia.Value)) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTien_thue, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTien_thue, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Operators.SubtractObject(txtTong_tt.Value, txtTien_hang.Value), txtTien_thue.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTong_tt, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTong_tt, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(txtTien_tt.Value, Operators.MultiplyObject(txtTien_tt_nt.Value, txtty_gia.Value)) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtTien_tt, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtTien_tt, "");
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.AddObject(Operators.SubtractObject(txtDu_hd.Value, txtTong_tt.Value), txtTien_tt.Value) }, (string[])null, (Type[])null, (bool[])null), (object)num, false))
				{
					epNotice.SetError((Control)(object)txtDu_hd, Helper.GetMess(50047).Description);
					flag = true;
				}
				else
				{
					epNotice.SetError((Control)(object)txtDu_hd, "");
				}
			}
			if (flag)
			{
				return Commons.ProcessAdjustOver();
			}
			return true;
		}
	}
}
