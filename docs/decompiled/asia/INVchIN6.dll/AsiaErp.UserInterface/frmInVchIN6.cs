using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Business;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmInVchIN6 : frmVoucher
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("lblNguoi_Gd")]
	private Label _lblNguoi_Gd;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("txtNguoi_Gd")]
	private TextBox _txtNguoi_Gd;

	[AccessedThroughProperty("lblDien_giai")]
	private Label _lblDien_giai;

	[AccessedThroughProperty("lblDia_chi")]
	private Label _lblDia_chi;

	[AccessedThroughProperty("adgvDetail")]
	private AsInputDGV _adgvDetail;

	[AccessedThroughProperty("txtNgay_lct")]
	private AsMaskedTextBox _txtNgay_lct;

	[AccessedThroughProperty("lblNgay_Lct")]
	private Label _lblNgay_Lct;

	[AccessedThroughProperty("txtTy_gia")]
	private AsTextNumeric _txtTy_gia;

	[AccessedThroughProperty("cboMa_NT")]
	private AsComboBoxNT _cboMa_NT;

	[AccessedThroughProperty("lblMa_Nt")]
	private Label _lblMa_Nt;

	[AccessedThroughProperty("txtT_Tien")]
	private AsTextNumeric _txtT_Tien;

	[AccessedThroughProperty("lblT_Tien")]
	private Label _lblT_Tien;

	[AccessedThroughProperty("txtT_Tien_nt")]
	private AsTextNumeric _txtT_Tien_nt;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	[AccessedThroughProperty("txtTen_kh")]
	private TextBox _txtTen_kh;

	[AccessedThroughProperty("txtDia_chi")]
	private TextBox _txtDia_chi;

	[AccessedThroughProperty("lblMa_gd")]
	private Label _lblMa_gd;

	[AccessedThroughProperty("cboMa_gd")]
	private ComboBox _cboMa_gd;

	[AccessedThroughProperty("chkGia_tb")]
	private AsCheckBox _chkGia_tb;

	[AccessedThroughProperty("txtT_So_luong")]
	private AsTextNumeric _txtT_So_luong;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("SplitContainer1")]
	private SplitContainer _SplitContainer1;

	[AccessedThroughProperty("adgvDetail4detail")]
	private AsInputDGV _adgvDetail4detail;

	[AccessedThroughProperty("chkXembo")]
	private CheckBox _chkXembo;

	[AccessedThroughProperty("dgvcMa_vtm")]
	private DataGridViewAsTextBoxColumn _dgvcMa_vtm;

	[AccessedThroughProperty("dgvcTen_vtm")]
	private DataGridViewTextBoxColumn _dgvcTen_vtm;

	[AccessedThroughProperty("dgvcDvtm")]
	private DataGridViewTextBoxColumn _dgvcDvtm;

	[AccessedThroughProperty("dgvcMa_khom")]
	private DataGridViewAsTextBoxColumn _dgvcMa_khom;

	[AccessedThroughProperty("dgvcSo_luongm")]
	private DataGridViewAsTextNumericColumn _dgvcSo_luongm;

	[AccessedThroughProperty("dgvcGia_ntm")]
	private DataGridViewAsTextNumericColumn _dgvcGia_ntm;

	[AccessedThroughProperty("dgvcTien_ntm")]
	private DataGridViewAsTextNumericColumn _dgvcTien_ntm;

	[AccessedThroughProperty("dgvcTk_vtm")]
	private DataGridViewAsTextBoxColumn _dgvcTk_vtm;

	[AccessedThroughProperty("dgvcTk_Dum")]
	private DataGridViewAsTextBoxColumn _dgvcTk_Dum;

	[AccessedThroughProperty("dgvcGiam")]
	private DataGridViewAsTextNumericColumn _dgvcGiam;

	[AccessedThroughProperty("dgvcTienm")]
	private DataGridViewAsTextNumericColumn _dgvcTienm;

	[AccessedThroughProperty("dgvcMa_hd")]
	private DataGridViewAsTextBoxColumn _dgvcMa_hd;

	[AccessedThroughProperty("dgvcMa_spct")]
	private DataGridViewAsTextBoxColumn _dgvcMa_spct;

	[AccessedThroughProperty("dgvcMa_phi")]
	private DataGridViewAsTextBoxColumn _dgvcMa_phi;

	[AccessedThroughProperty("dgvcMa_bp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_bp;

	[AccessedThroughProperty("dgvcMa_vtd")]
	private DataGridViewAsTextBoxColumn _dgvcMa_vtd;

	[AccessedThroughProperty("dgvcTen_vtd")]
	private DataGridViewTextBoxColumn _dgvcTen_vtd;

	[AccessedThroughProperty("dgvcDvtd")]
	private DataGridViewTextBoxColumn _dgvcDvtd;

	[AccessedThroughProperty("dgvcMa_khod")]
	private DataGridViewAsTextBoxColumn _dgvcMa_khod;

	[AccessedThroughProperty("dgvcSo_luongd")]
	private DataGridViewAsTextNumericColumn _dgvcSo_luongd;

	[AccessedThroughProperty("dgvcGia_ntd")]
	private DataGridViewAsTextNumericColumn _dgvcGia_ntd;

	[AccessedThroughProperty("dgvcTien_ntd")]
	private DataGridViewAsTextNumericColumn _dgvcTien_ntd;

	[AccessedThroughProperty("dgvcTk_vtd")]
	private DataGridViewAsTextBoxColumn _dgvcTk_vtd;

	[AccessedThroughProperty("dgvcTk_dud")]
	private DataGridViewAsTextBoxColumn _dgvcTk_dud;

	[AccessedThroughProperty("dgvcGiad")]
	private DataGridViewAsTextNumericColumn _dgvcGiad;

	[AccessedThroughProperty("dgvcTiend")]
	private DataGridViewAsTextNumericColumn _dgvcTiend;

	[AccessedThroughProperty("dgvcMa_hdd")]
	private DataGridViewAsTextBoxColumn _dgvcMa_hdd;

	[AccessedThroughProperty("dgvcMa_spctd")]
	private DataGridViewAsTextBoxColumn _dgvcMa_spctd;

	[AccessedThroughProperty("dgvcMa_phid")]
	private DataGridViewAsTextBoxColumn _dgvcMa_phid;

	[AccessedThroughProperty("dgvcMa_bpd")]
	private DataGridViewAsTextBoxColumn _dgvcMa_bpd;

	[AccessedThroughProperty("dgvcMa_bo")]
	private DataGridViewTextBoxColumn _dgvcMa_bo;

	private INVchIN6Controller f_controller;

	private string f_sMa_Gd_Default;

	private DataTable f_oTblCtD;

	private const string LAP_RAP = "1";

	private const string THAO_DO = "2";

	private string f_sGiaM;

	private string f_sTienM;

	private string f_sGiaD;

	private string f_sTienD;

	internal virtual AsTextBox txtMa_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_Kh_AfterCodeValidating;
			if (_txtMa_Kh != null)
			{
				_txtMa_Kh.AfterCodeValidating -= obj;
			}
			_txtMa_Kh = value;
			if (_txtMa_Kh != null)
			{
				_txtMa_Kh.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual Label lblMa_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Kh = value;
		}
	}

	internal virtual Label lblNguoi_Gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguoi_Gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguoi_Gd = value;
		}
	}

	internal virtual TextBox txtDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDien_giai = value;
		}
	}

	internal virtual TextBox txtNguoi_Gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNguoi_Gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNguoi_Gd = value;
		}
	}

	internal virtual Label lblDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDien_giai = value;
		}
	}

	internal virtual Label lblDia_chi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDia_chi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDia_chi = value;
		}
	}

	internal virtual AsInputDGV adgvDetail
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvDetail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvDetail_CellEnter);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvDetail_CellValueChanged);
			EventHandler eventHandler = adgvDetail_SelectionChanged;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellEnter -= val;
				((DataGridView)_adgvDetail).CellValueChanged -= val2;
				((DataGridView)_adgvDetail).SelectionChanged -= eventHandler;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellEnter += val;
				((DataGridView)_adgvDetail).CellValueChanged += val2;
				((DataGridView)_adgvDetail).SelectionChanged += eventHandler;
			}
		}
	}

	internal virtual AsMaskedTextBox txtNgay_lct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_lct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_lct = value;
		}
	}

	internal virtual Label lblNgay_Lct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_Lct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_Lct = value;
		}
	}

	private virtual AsTextNumeric txtTy_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTy_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtTy_gia_Validated;
			if (_txtTy_gia != null)
			{
				((Control)_txtTy_gia).Validated -= eventHandler;
			}
			_txtTy_gia = value;
			if (_txtTy_gia != null)
			{
				((Control)_txtTy_gia).Validated += eventHandler;
			}
		}
	}

	private virtual AsComboBoxNT cboMa_NT
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboMa_NT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboMa_NT_SelectedValueChanged;
			if (_cboMa_NT != null)
			{
				((ListControl)_cboMa_NT).SelectedValueChanged -= eventHandler;
			}
			_cboMa_NT = value;
			if (_cboMa_NT != null)
			{
				((ListControl)_cboMa_NT).SelectedValueChanged += eventHandler;
			}
		}
	}

	private virtual Label lblMa_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nt = value;
		}
	}

	internal virtual AsTextNumeric txtT_Tien
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Tien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Tien = value;
		}
	}

	internal virtual Label lblT_Tien
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_Tien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_Tien = value;
		}
	}

	internal virtual AsTextNumeric txtT_Tien_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Tien_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Tien_nt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn2 = value;
		}
	}

	internal virtual TextBox txtTen_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_kh = value;
		}
	}

	internal virtual TextBox txtDia_chi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDia_chi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDia_chi = value;
		}
	}

	internal virtual Label lblMa_gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_gd = value;
		}
	}

	internal virtual ComboBox cboMa_gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboMa_gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboMa_gd = value;
		}
	}

	internal virtual AsCheckBox chkGia_tb
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkGia_tb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkGia_tb = value;
		}
	}

	internal virtual AsTextNumeric txtT_So_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_So_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_So_luong = value;
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

	internal virtual SplitContainer SplitContainer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SplitContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SplitContainer1 = value;
		}
	}

	internal virtual AsInputDGV adgvDetail4detail
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvDetail4detail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(adgvDetail4detail_KeyDown);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvDetail4detail_CellEnter);
			DataGridViewCellEventHandler val3 = new DataGridViewCellEventHandler(adgvDetail4detail_CellValueChanged);
			if (_adgvDetail4detail != null)
			{
				((Control)_adgvDetail4detail).KeyDown -= val;
				((DataGridView)_adgvDetail4detail).CellEnter -= val2;
				((DataGridView)_adgvDetail4detail).CellValueChanged -= val3;
			}
			_adgvDetail4detail = value;
			if (_adgvDetail4detail != null)
			{
				((Control)_adgvDetail4detail).KeyDown += val;
				((DataGridView)_adgvDetail4detail).CellEnter += val2;
				((DataGridView)_adgvDetail4detail).CellValueChanged += val3;
			}
		}
	}

	internal virtual CheckBox chkXembo
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkXembo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkXembo_CheckedChanged;
			if (_chkXembo != null)
			{
				_chkXembo.CheckedChanged -= eventHandler;
			}
			_chkXembo = value;
			if (_chkXembo != null)
			{
				_chkXembo.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_vtm
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_vtm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_vtm = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_vtm
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_vtm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_vtm = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDvtm
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDvtm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDvtm = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_khom
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_khom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_khom = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcSo_luongm
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_luongm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_luongm = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcGia_ntm
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcGia_ntm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcGia_ntm = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_ntm
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_ntm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_ntm = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_vtm
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_vtm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_vtm = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_Dum
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_Dum;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_Dum = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcGiam
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcGiam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcGiam = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTienm
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTienm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTienm = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_hd = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_spct = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_phi = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_bp = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_vtd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_vtd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_vtd = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_vtd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_vtd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_vtd = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDvtd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDvtd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDvtd = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_khod
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_khod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_khod = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcSo_luongd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_luongd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_luongd = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcGia_ntd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcGia_ntd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcGia_ntd = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_ntd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_ntd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_ntd = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_vtd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_vtd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_vtd = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_dud
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_dud;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_dud = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcGiad
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcGiad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcGiad = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTiend
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTiend;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTiend = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_hdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_hdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_hdd = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_spctd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_spctd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_spctd = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_phid
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_phid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_phid = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_bpd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_bpd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_bpd = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_bo
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_bo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_bo = value;
		}
	}

	protected new INVchIN6Controller MyController
	{
		get
		{
			if (((Component)(object)this).DesignMode)
			{
				return null;
			}
			if (f_controller == null)
			{
				f_controller = new INVchIN6Controller(MyVoucherInfo);
			}
			return f_controller;
		}
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

	public frmInVchIN6()
	{
		__ENCAddToList(this);
		f_controller = null;
		f_sMa_Gd_Default = "9";
		f_sGiaM = "";
		f_sTienM = "";
		f_sGiaD = "";
		f_sTienD = "";
		InitializeComponent();
	}

	public frmInVchIN6(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_controller = null;
		f_sMa_Gd_Default = "9";
		f_sGiaM = "";
		f_sTienM = "";
		f_sGiaD = "";
		f_sTienD = "";
		InitializeComponent();
	}

	public frmInVchIN6(string MenuID, string Stt_rec)
		: base(MenuID, Stt_rec)
	{
		__ENCAddToList(this);
		f_controller = null;
		f_sMa_Gd_Default = "9";
		f_sGiaM = "";
		f_sTienM = "";
		f_sGiaD = "";
		f_sTienD = "";
		InitializeComponent();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e66: Expected O, but got Unknown
		//IL_0f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa4: Expected O, but got Unknown
		//IL_106a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1074: Expected O, but got Unknown
		//IL_1f62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f6c: Expected O, but got Unknown
		//IL_205a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2064: Expected O, but got Unknown
		//IL_211f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2129: Expected O, but got Unknown
		//IL_254b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2555: Expected O, but got Unknown
		//IL_2650: Unknown result type (might be due to invalid IL or missing references)
		//IL_265a: Expected O, but got Unknown
		//IL_2811: Unknown result type (might be due to invalid IL or missing references)
		//IL_281b: Expected O, but got Unknown
		//IL_2960: Unknown result type (might be due to invalid IL or missing references)
		//IL_296a: Expected O, but got Unknown
		//IL_2a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a47: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		DataGridViewCellStyle val9 = new DataGridViewCellStyle();
		DataGridViewCellStyle val10 = new DataGridViewCellStyle();
		DataGridViewCellStyle val11 = new DataGridViewCellStyle();
		DataGridViewCellStyle val12 = new DataGridViewCellStyle();
		DataGridViewCellStyle val13 = new DataGridViewCellStyle();
		DataGridViewCellStyle val14 = new DataGridViewCellStyle();
		DataGridViewCellStyle val15 = new DataGridViewCellStyle();
		DataGridViewCellStyle val16 = new DataGridViewCellStyle();
		DataGridViewCellStyle val17 = new DataGridViewCellStyle();
		DataGridViewCellStyle val18 = new DataGridViewCellStyle();
		DataGridViewCellStyle val19 = new DataGridViewCellStyle();
		DataGridViewCellStyle val20 = new DataGridViewCellStyle();
		DataGridViewCellStyle val21 = new DataGridViewCellStyle();
		DataGridViewCellStyle val22 = new DataGridViewCellStyle();
		DataGridViewCellStyle val23 = new DataGridViewCellStyle();
		DataGridViewCellStyle val24 = new DataGridViewCellStyle();
		DataGridViewCellStyle val25 = new DataGridViewCellStyle();
		DataGridViewCellStyle val26 = new DataGridViewCellStyle();
		DataGridViewCellStyle val27 = new DataGridViewCellStyle();
		DataGridViewCellStyle val28 = new DataGridViewCellStyle();
		DataGridViewCellStyle val29 = new DataGridViewCellStyle();
		DataGridViewCellStyle val30 = new DataGridViewCellStyle();
		DataGridViewCellStyle val31 = new DataGridViewCellStyle();
		DataGridViewCellStyle val32 = new DataGridViewCellStyle();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblNguoi_Gd = new Label();
		txtDien_giai = new TextBox();
		txtNguoi_Gd = new TextBox();
		lblDien_giai = new Label();
		lblDia_chi = new Label();
		adgvDetail = new AsInputDGV();
		dgvcMa_vtm = new DataGridViewAsTextBoxColumn();
		dgvcTen_vtm = new DataGridViewTextBoxColumn();
		dgvcDvtm = new DataGridViewTextBoxColumn();
		dgvcMa_khom = new DataGridViewAsTextBoxColumn();
		dgvcSo_luongm = new DataGridViewAsTextNumericColumn();
		dgvcGia_ntm = new DataGridViewAsTextNumericColumn();
		dgvcTien_ntm = new DataGridViewAsTextNumericColumn();
		dgvcTk_vtm = new DataGridViewAsTextBoxColumn();
		dgvcTk_Dum = new DataGridViewAsTextBoxColumn();
		dgvcGiam = new DataGridViewAsTextNumericColumn();
		dgvcTienm = new DataGridViewAsTextNumericColumn();
		dgvcMa_hd = new DataGridViewAsTextBoxColumn();
		dgvcMa_spct = new DataGridViewAsTextBoxColumn();
		dgvcMa_phi = new DataGridViewAsTextBoxColumn();
		dgvcMa_bp = new DataGridViewAsTextBoxColumn();
		txtNgay_lct = new AsMaskedTextBox();
		lblNgay_Lct = new Label();
		txtTy_gia = new AsTextNumeric();
		cboMa_NT = new AsComboBoxNT();
		lblMa_Nt = new Label();
		txtT_Tien = new AsTextNumeric();
		lblT_Tien = new Label();
		txtT_Tien_nt = new AsTextNumeric();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		txtDia_chi = new TextBox();
		txtTen_kh = new TextBox();
		cboMa_gd = new ComboBox();
		lblMa_gd = new Label();
		chkGia_tb = new AsCheckBox();
		txtT_So_luong = new AsTextNumeric();
		Label5 = new Label();
		SplitContainer1 = new SplitContainer();
		adgvDetail4detail = new AsInputDGV();
		dgvcMa_vtd = new DataGridViewAsTextBoxColumn();
		dgvcTen_vtd = new DataGridViewTextBoxColumn();
		dgvcDvtd = new DataGridViewTextBoxColumn();
		dgvcMa_khod = new DataGridViewAsTextBoxColumn();
		dgvcSo_luongd = new DataGridViewAsTextNumericColumn();
		dgvcGia_ntd = new DataGridViewAsTextNumericColumn();
		dgvcTien_ntd = new DataGridViewAsTextNumericColumn();
		dgvcTk_vtd = new DataGridViewAsTextBoxColumn();
		dgvcTk_dud = new DataGridViewAsTextBoxColumn();
		dgvcGiad = new DataGridViewAsTextNumericColumn();
		dgvcTiend = new DataGridViewAsTextNumericColumn();
		dgvcMa_hdd = new DataGridViewAsTextBoxColumn();
		dgvcMa_spctd = new DataGridViewAsTextBoxColumn();
		dgvcMa_phid = new DataGridViewAsTextBoxColumn();
		dgvcMa_bpd = new DataGridViewAsTextBoxColumn();
		dgvcMa_bo = new DataGridViewTextBoxColumn();
		chkXembo = new CheckBox();
		((Control)gbPH).SuspendLayout();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabDetail).SuspendLayout();
		((ISupportInitialize)bsPH).BeginInit();
		((ISupportInitialize)bsCT).BeginInit();
		((ISupportInitialize)bsCP).BeginInit();
		((ISupportInitialize)bsTain).BeginInit();
		((ISupportInitialize)bsTaout).BeginInit();
		((ISupportInitialize)adgvDetail).BeginInit();
		((Control)SplitContainer1.Panel1).SuspendLayout();
		((Control)SplitContainer1.Panel2).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((ISupportInitialize)adgvDetail4detail).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = cmdAdd;
		Point location = new Point(3, 424);
		((Control)obj).Location = location;
		Button obj2 = cmdPrint;
		location = new Point(73, 424);
		((Control)obj2).Location = location;
		Button obj3 = cmdLast;
		location = new Point(674, 424);
		((Control)obj3).Location = location;
		Button obj4 = cmdNext;
		location = new Point(649, 424);
		((Control)obj4).Location = location;
		Button obj5 = cmdPrevious;
		location = new Point(624, 424);
		((Control)obj5).Location = location;
		Button obj6 = cmdFirst;
		location = new Point(599, 424);
		((Control)obj6).Location = location;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(511, 44);
		((Control)obj7).Location = location;
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		Label obj8 = lblNgay_Ct;
		location = new Point(511, 18);
		((Control)obj8).Location = location;
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)5;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(616, 14);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay_Ct).TabIndex = 6;
		((Control)gbPH).Controls.Add((Control)(object)lblMa_gd);
		((Control)gbPH).Controls.Add((Control)(object)cboMa_gd);
		((Control)gbPH).Controls.Add((Control)(object)txtTen_kh);
		((Control)gbPH).Controls.Add((Control)(object)txtDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)lblDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)txtTy_gia);
		((Control)gbPH).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Nt);
		((Control)gbPH).Controls.Add((Control)(object)txtNgay_lct);
		((Control)gbPH).Controls.Add((Control)(object)lblNgay_Lct);
		((Control)gbPH).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbPH).Controls.Add((Control)(object)lblDien_giai);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)txtNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)lblNguoi_Gd);
		GroupBox obj9 = gbPH;
		location = new Point(3, -3);
		((Control)obj9).Location = location;
		GroupBox obj10 = gbPH;
		Size size = new Size(699, 145);
		((Control)obj10).Size = size;
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTy_gia, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTen_kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboMa_gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_gd, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(518, 424);
		((Control)splitButton).Location = location;
		AsTabControl asTabControl = AsTabControl;
		location = new Point(0, 145);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(705, 253);
		((Control)asTabControl2).Size = size;
		((Control)tabDetail).Controls.Add((Control)(object)SplitContainer1);
		TabPage obj11 = tabDetail;
		size = new Size(697, 224);
		((Control)obj11).Size = size;
		TabPage obj12 = tabOptFields;
		size = new Size(697, 224);
		((Control)obj12).Size = size;
		Button obj13 = cmdCopy;
		location = new Point(283, 424);
		((Control)obj13).Location = location;
		Button obj14 = cmdDelete;
		location = new Point(213, 424);
		((Control)obj14).Location = location;
		Button obj15 = cmdEdit;
		location = new Point(143, 424);
		((Control)obj15).Location = location;
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		TextBox obj16 = txtSo_Ct;
		location = new Point(616, 40);
		((Control)obj16).Location = location;
		((Control)txtSo_Ct).TabIndex = 7;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(109, 41);
		((Control)asTextBox).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = null;
		txtMa_Kh.SD = true;
		AsTextBox asTextBox2 = txtMa_Kh;
		size = new Size(75, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Kh).TabIndex = 1;
		txtMa_Kh.UseAutoCompleteSource = true;
		txtMa_Kh.ValidReturnFieldList = "ten_kh,dia_chi,ma_so_thue,nguoi_gd,tel";
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj17 = lblMa_Kh;
		location = new Point(9, 45);
		((Control)obj17).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj18 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj18).Size = size;
		((Control)lblMa_Kh).TabIndex = 139;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj19 = lblNguoi_Gd;
		location = new Point(9, 96);
		((Control)obj19).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj20 = lblNguoi_Gd;
		size = new Size(94, 14);
		((Control)obj20).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 143;
		lblNguoi_Gd.Text = "Người giao dịch";
		TextBox obj21 = txtDien_giai;
		location = new Point(109, 119);
		((Control)obj21).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj22 = txtDien_giai;
		size = new Size(348, 20);
		((Control)obj22).Size = size;
		((Control)txtDien_giai).TabIndex = 5;
		TextBox obj23 = txtNguoi_Gd;
		location = new Point(109, 93);
		((Control)obj23).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj24 = txtNguoi_Gd;
		size = new Size(145, 20);
		((Control)obj24).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 4;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj25 = lblDien_giai;
		location = new Point(9, 122);
		((Control)obj25).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj26 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj26).Size = size;
		((Control)lblDien_giai).TabIndex = 144;
		lblDien_giai.Text = "Diễn giải";
		lblDia_chi.AutoSize = true;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj27 = lblDia_chi;
		location = new Point(9, 71);
		((Control)obj27).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj28 = lblDia_chi;
		size = new Size(40, 13);
		((Control)obj28).Size = size;
		((Control)lblDia_chi).TabIndex = 146;
		lblDia_chi.Text = "Địa chỉ";
		((DataGridView)adgvDetail).AllowUserToAddRows = false;
		((DataGridView)adgvDetail).AllowUserToDeleteRows = false;
		((DataGridView)adgvDetail).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvDetail).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)adgvDetail).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[15]
		{
			dgvcMa_vtm,
			(DataGridViewColumn)dgvcTen_vtm,
			(DataGridViewColumn)dgvcDvtm,
			dgvcMa_khom,
			dgvcSo_luongm,
			dgvcGia_ntm,
			dgvcTien_ntm,
			dgvcTk_vtm,
			dgvcTk_Dum,
			dgvcGiam,
			dgvcTienm,
			dgvcMa_hd,
			dgvcMa_spct,
			dgvcMa_phi,
			dgvcMa_bp
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvDetail).DefaultCellStyle = val2;
		((Control)adgvDetail).Dock = (DockStyle)5;
		((DataGridView)adgvDetail).EditMode = (DataGridViewEditMode)1;
		((DataGridView)adgvDetail).GridColor = SystemColors.Control;
		adgvDetail.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV = adgvDetail;
		location = new Point(0, 0);
		((Control)asInputDGV).Location = location;
		((Control)adgvDetail).Name = "adgvDetail";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail).RowHeadersDefaultCellStyle = val3;
		((DataGridView)adgvDetail).RowHeadersWidth = 35;
		((DataGridView)adgvDetail).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = adgvDetail;
		size = new Size(691, 93);
		((Control)asInputDGV2).Size = size;
		((Control)adgvDetail).TabIndex = 0;
		dgvcMa_vtm.AutoFill = true;
		dgvcMa_vtm.AutoLookup = true;
		dgvcMa_vtm.AutoValid = true;
		((DataGridViewColumn)dgvcMa_vtm).DataPropertyName = "ma_vt";
		val4.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_vtm).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcMa_vtm).HeaderText = "Mã bộ";
		dgvcMa_vtm.LookupCodeName = "MA_VT";
		dgvcMa_vtm.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_vtm).Name = "dgvcMa_vtm";
		dgvcMa_vtm.ReceiverValidFieldList = "ten_vt,dvt,tk_vt,ma_kho";
		dgvcMa_vtm.SD = true;
		dgvcMa_vtm.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_vtm.ValidReturnFieldList = "ten_vt,dvt,tk_vt,ma_kho";
		((DataGridViewColumn)dgvcMa_vtm).Width = 70;
		((DataGridViewColumn)dgvcTen_vtm).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vtm).HeaderText = "Tên bộ";
		dgvcTen_vtm.MaxInputLength = 128;
		((DataGridViewColumn)dgvcTen_vtm).Name = "dgvcTen_vtm";
		((DataGridViewColumn)dgvcTen_vtm).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_vtm).Resizable = (DataGridViewTriState)1;
		dgvcTen_vtm.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_vtm).Width = 160;
		((DataGridViewColumn)dgvcDvtm).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcDvtm).DataPropertyName = "dvt";
		((DataGridViewColumn)dgvcDvtm).HeaderText = "Đvt";
		((DataGridViewColumn)dgvcDvtm).Name = "dgvcDvtm";
		((DataGridViewColumn)dgvcDvtm).ReadOnly = true;
		((DataGridViewColumn)dgvcDvtm).Width = 49;
		dgvcMa_khom.AutoFill = true;
		dgvcMa_khom.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_khom).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_khom.AutoValid = true;
		((DataGridViewColumn)dgvcMa_khom).DataPropertyName = "ma_kho";
		val5.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_khom).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcMa_khom).HeaderText = "Kho";
		dgvcMa_khom.LookupCodeName = "MA_KHO";
		dgvcMa_khom.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_khom).Name = "dgvcMa_khom";
		dgvcMa_khom.ReceiverValidFieldList = "ten_kho";
		dgvcMa_khom.SD = true;
		dgvcMa_khom.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_khom.ValidReturnFieldList = "ten_kho";
		((DataGridViewColumn)dgvcMa_khom).Width = 32;
		((DataGridViewColumn)dgvcSo_luongm).DataPropertyName = "so_luong";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luongm).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcSo_luongm).HeaderText = "Số lượng";
		dgvcSo_luongm.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luongm).Name = "dgvcSo_luongm";
		dgvcSo_luongm.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSo_luongm.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcSo_luongm).Width = 70;
		((DataGridViewColumn)dgvcGia_ntm).DataPropertyName = "gia_nt";
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_ntm).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcGia_ntm).HeaderText = "Giá";
		dgvcGia_ntm.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_ntm).Name = "dgvcGia_ntm";
		dgvcGia_ntm.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia_ntm.SpecialType = Commons.NumericSpecialType.FCPrice;
		((DataGridViewColumn)dgvcGia_ntm).Width = 80;
		((DataGridViewColumn)dgvcTien_ntm).DataPropertyName = "tien_nt";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ntm).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcTien_ntm).HeaderText = "Thành tiền";
		dgvcTien_ntm.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ntm).Name = "dgvcTien_ntm";
		((DataGridViewColumn)dgvcTien_ntm).ReadOnly = true;
		dgvcTien_ntm.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ntm.SpecialType = Commons.NumericSpecialType.FCAmount;
		dgvcTk_vtm.AutoFill = true;
		dgvcTk_vtm.AutoLookup = true;
		dgvcTk_vtm.AutoValid = true;
		((DataGridViewColumn)dgvcTk_vtm).DataPropertyName = "tk_vt";
		val9.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_vtm).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcTk_vtm).HeaderText = "TK kho";
		dgvcTk_vtm.LookupCodeName = "TK";
		dgvcTk_vtm.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_vtm).Name = "dgvcTk_vtm";
		dgvcTk_vtm.ReceiverValidFieldList = "ten_tk_vt";
		dgvcTk_vtm.SD = true;
		dgvcTk_vtm.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_vtm.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_vtm).Width = 70;
		dgvcTk_Dum.AutoFill = true;
		dgvcTk_Dum.AutoLookup = true;
		dgvcTk_Dum.AutoValid = true;
		((DataGridViewColumn)dgvcTk_Dum).DataPropertyName = "tk_du";
		val10.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_Dum).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcTk_Dum).HeaderText = "Mã NX";
		dgvcTk_Dum.LookupCodeName = "TK";
		dgvcTk_Dum.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_Dum).Name = "dgvcTk_Dum";
		dgvcTk_Dum.ReceiverValidFieldList = "ten_tk_du";
		dgvcTk_Dum.SD = true;
		dgvcTk_Dum.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_Dum.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_Dum).Width = 70;
		((DataGridViewColumn)dgvcGiam).DataPropertyName = "gia";
		val11.Alignment = (DataGridViewContentAlignment)64;
		val11.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGiam).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcGiam).HeaderText = "Giá VND";
		dgvcGiam.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGiam).Name = "dgvcGiam";
		((DataGridViewColumn)dgvcGiam).ReadOnly = true;
		dgvcGiam.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGiam.SpecialType = Commons.NumericSpecialType.ACPrice;
		((DataGridViewColumn)dgvcGiam).Width = 80;
		((DataGridViewColumn)dgvcTienm).DataPropertyName = "tien";
		val12.Alignment = (DataGridViewContentAlignment)64;
		val12.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTienm).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcTienm).HeaderText = "Tiền VND";
		dgvcTienm.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTienm).Name = "dgvcTienm";
		((DataGridViewColumn)dgvcTienm).ReadOnly = true;
		dgvcTienm.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTienm.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTienm).Width = 80;
		dgvcMa_hd.AutoFill = true;
		dgvcMa_hd.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_hd).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_hd.AutoValid = true;
		((DataGridViewColumn)dgvcMa_hd).DataPropertyName = "ma_hd";
		val13.BackColor = SystemColors.Info;
		val13.NullValue = null;
		((DataGridViewColumn)dgvcMa_hd).DefaultCellStyle = val13;
		((DataGridViewColumn)dgvcMa_hd).HeaderText = "H. đồng";
		dgvcMa_hd.LookupCodeName = "MA_HD";
		dgvcMa_hd.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_hd).Name = "dgvcMa_hd";
		dgvcMa_hd.ReceiverValidFieldList = "ten_hd";
		dgvcMa_hd.SD = true;
		dgvcMa_hd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_hd.ValidReturnFieldList = "ten_hd";
		((DataGridViewColumn)dgvcMa_hd).Width = 52;
		dgvcMa_spct.AutoFill = true;
		dgvcMa_spct.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_spct).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_spct.AutoValid = true;
		((DataGridViewColumn)dgvcMa_spct).DataPropertyName = "ma_spct";
		val14.BackColor = SystemColors.Info;
		val14.NullValue = null;
		((DataGridViewColumn)dgvcMa_spct).DefaultCellStyle = val14;
		((DataGridViewColumn)dgvcMa_spct).HeaderText = "SPCT";
		dgvcMa_spct.LookupCodeName = "MA_SPCT";
		dgvcMa_spct.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_spct).Name = "dgvcMa_spct";
		dgvcMa_spct.ReceiverValidFieldList = "ten_spct";
		dgvcMa_spct.SD = true;
		dgvcMa_spct.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_spct.ValidReturnFieldList = "ten_spct";
		((DataGridViewColumn)dgvcMa_spct).Width = 41;
		dgvcMa_phi.AutoFill = true;
		dgvcMa_phi.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_phi).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_phi.AutoValid = true;
		((DataGridViewColumn)dgvcMa_phi).DataPropertyName = "ma_phi";
		val15.BackColor = SystemColors.Info;
		val15.NullValue = null;
		((DataGridViewColumn)dgvcMa_phi).DefaultCellStyle = val15;
		((DataGridViewColumn)dgvcMa_phi).HeaderText = "Phí";
		dgvcMa_phi.LookupCodeName = "MA_PHI";
		dgvcMa_phi.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_phi).Name = "dgvcMa_phi";
		dgvcMa_phi.ReceiverValidFieldList = "ten_phi";
		dgvcMa_phi.SD = true;
		dgvcMa_phi.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_phi.ValidReturnFieldList = "ten_phi";
		((DataGridViewColumn)dgvcMa_phi).Width = 30;
		dgvcMa_bp.AutoFill = true;
		dgvcMa_bp.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_bp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_bp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_bp).DataPropertyName = "ma_bp";
		val16.BackColor = SystemColors.Info;
		val16.NullValue = null;
		((DataGridViewColumn)dgvcMa_bp).DefaultCellStyle = val16;
		((DataGridViewColumn)dgvcMa_bp).HeaderText = "B. phận";
		dgvcMa_bp.LookupCodeName = "MA_BP";
		dgvcMa_bp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_bp).Name = "dgvcMa_bp";
		dgvcMa_bp.ReceiverValidFieldList = "ten_bp";
		dgvcMa_bp.SD = true;
		dgvcMa_bp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_bp.ValidReturnFieldList = "ten_bp";
		((DataGridViewColumn)dgvcMa_bp).Width = 50;
		txtNgay_lct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_lct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_lct;
		location = new Point(616, 66);
		((Control)asMaskedTextBox2).Location = location;
		((MaskedTextBox)txtNgay_lct).Mask = "##/##/####";
		((Control)txtNgay_lct).Name = "txtNgay_lct";
		((MaskedTextBox)txtNgay_lct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_lct;
		size = new Size(78, 20);
		((Control)asMaskedTextBox3).Size = size;
		((Control)txtNgay_lct).TabIndex = 8;
		((MaskedTextBox)txtNgay_lct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_lct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox4.Value = dateTime;
		lblNgay_Lct.ImeMode = (ImeMode)0;
		Label obj29 = lblNgay_Lct;
		location = new Point(511, 69);
		((Control)obj29).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj30 = lblNgay_Lct;
		size = new Size(56, 15);
		((Control)obj30).Size = size;
		((Control)lblNgay_Lct).TabIndex = 234;
		lblNgay_Lct.Text = "Ngày lập";
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(625, 92);
		((Control)asTextNumeric).Location = location;
		txtTy_gia.Mask = "### ###.##";
		((Control)txtTy_gia).Name = "txtTy_gia";
		AsTextNumeric asTextNumeric2 = txtTy_gia;
		size = new Size(69, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTy_gia).TabIndex = 10;
		((TextBox)txtTy_gia).Text = "0.00";
		((TextBox)txtTy_gia).TextAlign = (HorizontalAlignment)1;
		txtTy_gia.Value = 0.0;
		((ComboBox)cboMa_NT).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboMa_NT).Enabled = false;
		((ListControl)cboMa_NT).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_NT;
		location = new Point(575, 92);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(47, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 9;
		lblMa_Nt.AutoSize = true;
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj31 = lblMa_Nt;
		location = new Point(511, 96);
		((Control)obj31).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj32 = lblMa_Nt;
		size = new Size(36, 13);
		((Control)obj32).Size = size;
		((Control)lblMa_Nt).TabIndex = 237;
		lblMa_Nt.Text = "Tỷ giá";
		((Control)txtT_Tien).Anchor = (AnchorStyles)10;
		txtT_Tien.DecimalSymbol = ".";
		((Control)txtT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtT_Tien;
		location = new Point(602, 398);
		((Control)asTextNumeric3).Location = location;
		txtT_Tien.Mask = "### ### ### ###";
		((Control)txtT_Tien).Name = "txtT_Tien";
		((TextBoxBase)txtT_Tien).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtT_Tien;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		txtT_Tien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tien).TabIndex = 229;
		((Control)txtT_Tien).TabStop = false;
		((TextBox)txtT_Tien).Text = "0";
		((TextBox)txtT_Tien).TextAlign = (HorizontalAlignment)1;
		txtT_Tien.Value = 0.0;
		((Control)lblT_Tien).Anchor = (AnchorStyles)10;
		((Control)lblT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Tien.ImeMode = (ImeMode)0;
		Label obj33 = lblT_Tien;
		location = new Point(401, 401);
		((Control)obj33).Location = location;
		((Control)lblT_Tien).Name = "lblT_Tien";
		Label obj34 = lblT_Tien;
		size = new Size(89, 13);
		((Control)obj34).Size = size;
		((Control)lblT_Tien).TabIndex = 228;
		lblT_Tien.Text = "Tiền xuất";
		lblT_Tien.TextAlign = (ContentAlignment)16;
		((Control)txtT_Tien_nt).Anchor = (AnchorStyles)10;
		txtT_Tien_nt.DecimalSymbol = ".";
		((Control)txtT_Tien_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric5 = txtT_Tien_nt;
		location = new Point(496, 398);
		((Control)asTextNumeric5).Location = location;
		txtT_Tien_nt.Mask = "### ### ### ###";
		((Control)txtT_Tien_nt).Name = "txtT_Tien_nt";
		((TextBoxBase)txtT_Tien_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtT_Tien_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		txtT_Tien_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_Tien_nt).TabIndex = 236;
		((Control)txtT_Tien_nt).TabStop = false;
		((TextBox)txtT_Tien_nt).Text = "0";
		((TextBox)txtT_Tien_nt).TextAlign = (HorizontalAlignment)1;
		txtT_Tien_nt.Value = 0.0;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).DataPropertyName = "ten_vt";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).HeaderText = "Tên hàng";
		DataGridViewTextBoxColumn1.MaxInputLength = 128;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).ReadOnly = true;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Resizable = (DataGridViewTriState)1;
		DataGridViewTextBoxColumn1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).DataPropertyName = "dvt";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).HeaderText = "Đvt";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Name = "DataGridViewTextBoxColumn2";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).ReadOnly = true;
		TextBox obj35 = txtDia_chi;
		location = new Point(109, 67);
		((Control)obj35).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj36 = txtDia_chi;
		size = new Size(348, 20);
		((Control)obj36).Size = size;
		((Control)txtDia_chi).TabIndex = 3;
		TextBox obj37 = txtTen_kh;
		location = new Point(189, 41);
		((Control)obj37).Location = location;
		((Control)txtTen_kh).Name = "txtTen_kh";
		TextBox obj38 = txtTen_kh;
		size = new Size(268, 20);
		((Control)obj38).Size = size;
		((Control)txtTen_kh).TabIndex = 2;
		cboMa_gd.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMa_gd).FormattingEnabled = true;
		ComboBox obj39 = cboMa_gd;
		location = new Point(109, 14);
		((Control)obj39).Location = location;
		((Control)cboMa_gd).Name = "cboMa_gd";
		ComboBox obj40 = cboMa_gd;
		size = new Size(121, 21);
		((Control)obj40).Size = size;
		((Control)cboMa_gd).TabIndex = 0;
		lblMa_gd.AutoSize = true;
		lblMa_gd.ImeMode = (ImeMode)0;
		Label obj41 = lblMa_gd;
		location = new Point(9, 17);
		((Control)obj41).Location = location;
		((Control)lblMa_gd).Name = "lblMa_gd";
		Label obj42 = lblMa_gd;
		size = new Size(68, 13);
		((Control)obj42).Size = size;
		((Control)lblMa_gd).TabIndex = 239;
		lblMa_gd.Text = "Mã giao dịch";
		lblMa_gd.TextAlign = (ContentAlignment)16;
		((Control)chkGia_tb).Anchor = (AnchorStyles)6;
		chkGia_tb.Checked = false;
		AsCheckBox asCheckBox = chkGia_tb;
		location = new Point(3, 400);
		((Control)asCheckBox).Location = location;
		((Control)chkGia_tb).Name = "chkGia_tb";
		AsCheckBox asCheckBox2 = chkGia_tb;
		size = new Size(162, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkGia_tb).TabIndex = 255;
		((Control)chkGia_tb).TabStop = false;
		((ButtonBase)chkGia_tb).Text = "Tính giá trung bình";
		chkGia_tb.TextValue = "0";
		((ButtonBase)chkGia_tb).UseVisualStyleBackColor = true;
		((Control)txtT_So_luong).Anchor = (AnchorStyles)10;
		txtT_So_luong.DecimalSymbol = ".";
		((Control)txtT_So_luong).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric7 = txtT_So_luong;
		location = new Point(250, 398);
		((Control)asTextNumeric7).Location = location;
		txtT_So_luong.Mask = "### ### ### ###";
		((Control)txtT_So_luong).Name = "txtT_So_luong";
		((TextBoxBase)txtT_So_luong).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_So_luong;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_So_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((Control)txtT_So_luong).TabIndex = 260;
		((Control)txtT_So_luong).TabStop = false;
		((TextBox)txtT_So_luong).Text = "0";
		((TextBox)txtT_So_luong).TextAlign = (HorizontalAlignment)1;
		txtT_So_luong.Value = 0.0;
		((Control)txtT_So_luong).Visible = false;
		((Control)Label5).Anchor = (AnchorStyles)10;
		((Control)Label5).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label5.ImeMode = (ImeMode)0;
		Label label = Label5;
		location = new Point(162, 401);
		((Control)label).Location = location;
		((Control)Label5).Name = "Label5";
		Label label2 = Label5;
		size = new Size(82, 13);
		((Control)label2).Size = size;
		((Control)Label5).TabIndex = 259;
		Label5.Text = "Số lượng";
		Label5.TextAlign = (ContentAlignment)16;
		((Control)Label5).Visible = false;
		SplitContainer1.Dock = (DockStyle)5;
		SplitContainer splitContainer = SplitContainer1;
		location = new Point(3, 3);
		((Control)splitContainer).Location = location;
		((Control)SplitContainer1).Name = "SplitContainer1";
		SplitContainer1.Orientation = (Orientation)0;
		((Control)SplitContainer1.Panel1).Controls.Add((Control)(object)adgvDetail);
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)adgvDetail4detail);
		SplitContainer splitContainer2 = SplitContainer1;
		size = new Size(691, 218);
		((Control)splitContainer2).Size = size;
		SplitContainer1.SplitterDistance = 93;
		((Control)SplitContainer1).TabIndex = 2;
		((DataGridView)adgvDetail4detail).AllowUserToAddRows = false;
		((DataGridView)adgvDetail4detail).AllowUserToDeleteRows = false;
		((DataGridView)adgvDetail4detail).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvDetail4detail).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvDetail4detail).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val17.Alignment = (DataGridViewContentAlignment)16;
		val17.BackColor = SystemColors.Control;
		val17.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val17.ForeColor = SystemColors.WindowText;
		val17.SelectionBackColor = SystemColors.Highlight;
		val17.SelectionForeColor = SystemColors.HighlightText;
		val17.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail4detail).ColumnHeadersDefaultCellStyle = val17;
		((DataGridView)adgvDetail4detail).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvDetail4detail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[16]
		{
			dgvcMa_vtd,
			(DataGridViewColumn)dgvcTen_vtd,
			(DataGridViewColumn)dgvcDvtd,
			dgvcMa_khod,
			dgvcSo_luongd,
			dgvcGia_ntd,
			dgvcTien_ntd,
			dgvcTk_vtd,
			dgvcTk_dud,
			dgvcGiad,
			dgvcTiend,
			dgvcMa_hdd,
			dgvcMa_spctd,
			dgvcMa_phid,
			dgvcMa_bpd,
			(DataGridViewColumn)dgvcMa_bo
		});
		val18.Alignment = (DataGridViewContentAlignment)16;
		val18.BackColor = SystemColors.Window;
		val18.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val18.ForeColor = SystemColors.ControlText;
		val18.SelectionBackColor = SystemColors.Highlight;
		val18.SelectionForeColor = SystemColors.HighlightText;
		val18.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvDetail4detail).DefaultCellStyle = val18;
		((Control)adgvDetail4detail).Dock = (DockStyle)5;
		((DataGridView)adgvDetail4detail).EditMode = (DataGridViewEditMode)1;
		((DataGridView)adgvDetail4detail).GridColor = SystemColors.Control;
		adgvDetail4detail.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV3 = adgvDetail4detail;
		location = new Point(0, 0);
		((Control)asInputDGV3).Location = location;
		((Control)adgvDetail4detail).Name = "adgvDetail4detail";
		((DataGridView)adgvDetail4detail).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val19.Alignment = (DataGridViewContentAlignment)32;
		val19.BackColor = SystemColors.Control;
		val19.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val19.ForeColor = SystemColors.WindowText;
		val19.SelectionBackColor = SystemColors.Highlight;
		val19.SelectionForeColor = SystemColors.HighlightText;
		val19.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail4detail).RowHeadersDefaultCellStyle = val19;
		((DataGridView)adgvDetail4detail).RowHeadersWidth = 35;
		((DataGridView)adgvDetail4detail).RowTemplate.Height = 20;
		AsInputDGV asInputDGV4 = adgvDetail4detail;
		size = new Size(691, 121);
		((Control)asInputDGV4).Size = size;
		((Control)adgvDetail4detail).TabIndex = 0;
		dgvcMa_vtd.AutoFill = true;
		dgvcMa_vtd.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_vtd).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_vtd.AutoValid = true;
		((DataGridViewColumn)dgvcMa_vtd).DataPropertyName = "ma_vt";
		val20.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_vtd).DefaultCellStyle = val20;
		((DataGridViewColumn)dgvcMa_vtd).HeaderText = "Mã chi tiết";
		dgvcMa_vtd.LookupCodeName = "MA_VT";
		dgvcMa_vtd.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_vtd).Name = "dgvcMa_vtd";
		dgvcMa_vtd.ReceiverValidFieldList = "ten_vt,dvt,tk_vt,ma_kho";
		dgvcMa_vtd.SD = true;
		dgvcMa_vtd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_vtd.ValidReturnFieldList = "ten_vt,dvt,tk_vt,ma_kho";
		((DataGridViewColumn)dgvcMa_vtd).Width = 62;
		((DataGridViewColumn)dgvcTen_vtd).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vtd).HeaderText = "Tên chi tiết";
		dgvcTen_vtd.MaxInputLength = 128;
		((DataGridViewColumn)dgvcTen_vtd).Name = "dgvcTen_vtd";
		((DataGridViewColumn)dgvcTen_vtd).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_vtd).Resizable = (DataGridViewTriState)1;
		dgvcTen_vtd.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_vtd).Width = 160;
		((DataGridViewColumn)dgvcDvtd).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcDvtd).DataPropertyName = "dvt";
		((DataGridViewColumn)dgvcDvtd).HeaderText = "Đvt";
		((DataGridViewColumn)dgvcDvtd).Name = "dgvcDvtd";
		((DataGridViewColumn)dgvcDvtd).ReadOnly = true;
		((DataGridViewColumn)dgvcDvtd).Width = 49;
		dgvcMa_khod.AutoFill = true;
		dgvcMa_khod.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_khod).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_khod.AutoValid = true;
		((DataGridViewColumn)dgvcMa_khod).DataPropertyName = "ma_kho";
		val21.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_khod).DefaultCellStyle = val21;
		((DataGridViewColumn)dgvcMa_khod).HeaderText = "Kho";
		dgvcMa_khod.LookupCodeName = "MA_KHO";
		dgvcMa_khod.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_khod).Name = "dgvcMa_khod";
		dgvcMa_khod.ReceiverValidFieldList = "ten_kho";
		dgvcMa_khod.SD = true;
		dgvcMa_khod.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_khod.ValidReturnFieldList = "ten_kho";
		((DataGridViewColumn)dgvcMa_khod).Width = 32;
		((DataGridViewColumn)dgvcSo_luongd).DataPropertyName = "so_luong";
		val22.Alignment = (DataGridViewContentAlignment)64;
		val22.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luongd).DefaultCellStyle = val22;
		((DataGridViewColumn)dgvcSo_luongd).HeaderText = "Số lượng";
		dgvcSo_luongd.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luongd).Name = "dgvcSo_luongd";
		dgvcSo_luongd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSo_luongd.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcSo_luongd).Width = 70;
		((DataGridViewColumn)dgvcGia_ntd).DataPropertyName = "gia_nt";
		val23.Alignment = (DataGridViewContentAlignment)64;
		val23.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_ntd).DefaultCellStyle = val23;
		((DataGridViewColumn)dgvcGia_ntd).HeaderText = "Giá";
		dgvcGia_ntd.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_ntd).Name = "dgvcGia_ntd";
		dgvcGia_ntd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia_ntd.SpecialType = Commons.NumericSpecialType.FCPrice;
		((DataGridViewColumn)dgvcGia_ntd).Width = 80;
		((DataGridViewColumn)dgvcTien_ntd).DataPropertyName = "tien_nt";
		val24.Alignment = (DataGridViewContentAlignment)64;
		val24.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ntd).DefaultCellStyle = val24;
		((DataGridViewColumn)dgvcTien_ntd).HeaderText = "Thành tiền";
		dgvcTien_ntd.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_ntd).Name = "dgvcTien_ntd";
		((DataGridViewColumn)dgvcTien_ntd).ReadOnly = true;
		dgvcTien_ntd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_ntd.SpecialType = Commons.NumericSpecialType.FCAmount;
		dgvcTk_vtd.AutoFill = true;
		dgvcTk_vtd.AutoLookup = true;
		dgvcTk_vtd.AutoValid = true;
		((DataGridViewColumn)dgvcTk_vtd).DataPropertyName = "tk_vt";
		val25.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_vtd).DefaultCellStyle = val25;
		((DataGridViewColumn)dgvcTk_vtd).HeaderText = "TK kho";
		dgvcTk_vtd.LookupCodeName = "TK";
		dgvcTk_vtd.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_vtd).Name = "dgvcTk_vtd";
		dgvcTk_vtd.ReceiverValidFieldList = "ten_tk_vt";
		dgvcTk_vtd.SD = true;
		dgvcTk_vtd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_vtd.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_vtd).Width = 70;
		dgvcTk_dud.AutoFill = true;
		dgvcTk_dud.AutoLookup = true;
		dgvcTk_dud.AutoValid = true;
		((DataGridViewColumn)dgvcTk_dud).DataPropertyName = "tk_du";
		val26.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_dud).DefaultCellStyle = val26;
		((DataGridViewColumn)dgvcTk_dud).HeaderText = "Mã NX";
		dgvcTk_dud.LookupCodeName = "TK";
		dgvcTk_dud.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_dud).Name = "dgvcTk_dud";
		dgvcTk_dud.ReceiverValidFieldList = "ten_tk_co";
		dgvcTk_dud.SD = true;
		dgvcTk_dud.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_dud.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_dud).Width = 70;
		((DataGridViewColumn)dgvcGiad).DataPropertyName = "gia";
		val27.Alignment = (DataGridViewContentAlignment)64;
		val27.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcGiad).DefaultCellStyle = val27;
		((DataGridViewColumn)dgvcGiad).HeaderText = "Giá VND";
		dgvcGiad.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcGiad).Name = "dgvcGiad";
		((DataGridViewColumn)dgvcGiad).ReadOnly = true;
		dgvcGiad.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGiad.SpecialType = Commons.NumericSpecialType.ACPrice;
		((DataGridViewColumn)dgvcGiad).Width = 80;
		((DataGridViewColumn)dgvcTiend).DataPropertyName = "tien";
		val28.Alignment = (DataGridViewContentAlignment)64;
		val28.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcTiend).DefaultCellStyle = val28;
		((DataGridViewColumn)dgvcTiend).HeaderText = "Tiền VND";
		dgvcTiend.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcTiend).Name = "dgvcTiend";
		((DataGridViewColumn)dgvcTiend).ReadOnly = true;
		dgvcTiend.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTiend.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTiend).Width = 80;
		dgvcMa_hdd.AutoFill = true;
		dgvcMa_hdd.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_hdd).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_hdd.AutoValid = true;
		((DataGridViewColumn)dgvcMa_hdd).DataPropertyName = "ma_hd";
		val29.BackColor = SystemColors.Info;
		val29.NullValue = null;
		((DataGridViewColumn)dgvcMa_hdd).DefaultCellStyle = val29;
		((DataGridViewColumn)dgvcMa_hdd).HeaderText = "H. đồng";
		dgvcMa_hdd.LookupCodeName = "MA_HD";
		dgvcMa_hdd.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_hdd).Name = "dgvcMa_hdd";
		dgvcMa_hdd.ReceiverValidFieldList = "ten_hd";
		dgvcMa_hdd.SD = true;
		dgvcMa_hdd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_hdd.ValidReturnFieldList = "ten_hd";
		((DataGridViewColumn)dgvcMa_hdd).Width = 52;
		dgvcMa_spctd.AutoFill = true;
		dgvcMa_spctd.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_spctd).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_spctd.AutoValid = true;
		((DataGridViewColumn)dgvcMa_spctd).DataPropertyName = "ma_spct";
		val30.BackColor = SystemColors.Info;
		val30.NullValue = null;
		((DataGridViewColumn)dgvcMa_spctd).DefaultCellStyle = val30;
		((DataGridViewColumn)dgvcMa_spctd).HeaderText = "SPCT";
		dgvcMa_spctd.LookupCodeName = "MA_SPCT";
		dgvcMa_spctd.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_spctd).Name = "dgvcMa_spctd";
		dgvcMa_spctd.ReceiverValidFieldList = "ten_spct";
		dgvcMa_spctd.SD = true;
		dgvcMa_spctd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_spctd.ValidReturnFieldList = "ten_spct";
		((DataGridViewColumn)dgvcMa_spctd).Width = 41;
		dgvcMa_phid.AutoFill = true;
		dgvcMa_phid.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_phid).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_phid.AutoValid = true;
		((DataGridViewColumn)dgvcMa_phid).DataPropertyName = "ma_phi";
		val31.BackColor = SystemColors.Info;
		val31.NullValue = null;
		((DataGridViewColumn)dgvcMa_phid).DefaultCellStyle = val31;
		((DataGridViewColumn)dgvcMa_phid).HeaderText = "Phí";
		dgvcMa_phid.LookupCodeName = "MA_PHI";
		dgvcMa_phid.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_phid).Name = "dgvcMa_phid";
		dgvcMa_phid.ReceiverValidFieldList = "ten_phi";
		dgvcMa_phid.SD = true;
		dgvcMa_phid.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_phid.ValidReturnFieldList = "ten_phi";
		((DataGridViewColumn)dgvcMa_phid).Width = 30;
		dgvcMa_bpd.AutoFill = true;
		dgvcMa_bpd.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_bpd).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_bpd.AutoValid = true;
		((DataGridViewColumn)dgvcMa_bpd).DataPropertyName = "ma_bp";
		val32.BackColor = SystemColors.Info;
		val32.NullValue = null;
		((DataGridViewColumn)dgvcMa_bpd).DefaultCellStyle = val32;
		((DataGridViewColumn)dgvcMa_bpd).HeaderText = "B. phận";
		dgvcMa_bpd.LookupCodeName = "MA_BP";
		dgvcMa_bpd.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_bpd).Name = "dgvcMa_bpd";
		dgvcMa_bpd.ReceiverValidFieldList = "ten_bp";
		dgvcMa_bpd.SD = true;
		dgvcMa_bpd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_bpd.ValidReturnFieldList = "ten_bp";
		((DataGridViewColumn)dgvcMa_bpd).Width = 50;
		((DataGridViewColumn)dgvcMa_bo).DataPropertyName = "ma_bo";
		((DataGridViewColumn)dgvcMa_bo).HeaderText = "Mã bộ";
		((DataGridViewColumn)dgvcMa_bo).Name = "dgvcMa_bo";
		((DataGridViewColumn)dgvcMa_bo).ReadOnly = true;
		((ButtonBase)chkXembo).AutoSize = true;
		CheckBox obj43 = chkXembo;
		location = new Point(569, 150);
		((Control)obj43).Location = location;
		((Control)chkXembo).Name = "chkXembo";
		CheckBox obj44 = chkXembo;
		size = new Size(136, 17);
		((Control)obj44).Size = size;
		((Control)chkXembo).TabIndex = 240;
		((ButtonBase)chkXembo).Text = "Chỉ xem chi tiết từng bộ";
		((ButtonBase)chkXembo).UseVisualStyleBackColor = true;
		size = new Size(706, 472);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)chkXembo);
		((Control)this).Controls.Add((Control)(object)txtT_So_luong);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)chkGia_tb);
		((Control)this).Controls.Add((Control)(object)txtT_Tien);
		((Control)this).Controls.Add((Control)(object)txtT_Tien_nt);
		((Control)this).Controls.Add((Control)(object)lblT_Tien);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmInVchIN6";
		((Form)this).Text = "frmInVchIN6";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkGia_tb, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_So_luong, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkXembo, 0);
		((Control)gbPH).ResumeLayout(false);
		((Control)gbPH).PerformLayout();
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabDetail).ResumeLayout(false);
		((ISupportInitialize)bsPH).EndInit();
		((ISupportInitialize)bsCT).EndInit();
		((ISupportInitialize)bsCP).EndInit();
		((ISupportInitialize)bsTain).EndInit();
		((ISupportInitialize)bsTaout).EndInit();
		((ISupportInitialize)adgvDetail).EndInit();
		((Control)SplitContainer1.Panel1).ResumeLayout(false);
		((Control)SplitContainer1.Panel2).ResumeLayout(false);
		((Control)SplitContainer1).ResumeLayout(false);
		((ISupportInitialize)adgvDetail4detail).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void chkXembo_CheckedChanged(object sender, EventArgs e)
	{
		MasterDetailRelationRefresh();
	}

	private void cboMa_NT_SelectedValueChanged(object sender, EventArgs e)
	{
		if (!IsLoading)
		{
			RefreshDGVInput();
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				RefreshValueByMa_Nt();
				txtTy_gia_Validated(null, null);
			}
		}
	}

	private void txtMa_Kh_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if ((base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !((TextBoxBase)txtMa_Kh).ReadOnly && ((Control)txtMa_Kh).Enabled && ((Control)txtMa_Kh).Visible && e.ValidatedRow != null) || 1 == 0)
		{
			if (Helper.Repl_Null(txtMa_Kh.ValidReturnFieldList, isNum: false).ToString().ToUpper()
				.Contains("DIA_CHI"))
			{
				txtDia_chi.Text = Conversions.ToString(e.ValidatedRow["dia_chi"]);
			}
			if (Helper.Repl_Null(txtMa_Kh.ValidReturnFieldList, isNum: false).ToString().ToUpper()
				.Contains("NGUOI_GD"))
			{
				txtNguoi_Gd.Text = Conversions.ToString(e.ValidatedRow["nguoi_gd"]);
			}
			if (Helper.Repl_Null(txtMa_Kh.ValidReturnFieldList, isNum: false).ToString().ToUpper()
				.Contains("TEN_KH"))
			{
				txtTen_kh.Text = Conversions.ToString(e.ValidatedRow["ten_kh"]);
			}
		}
	}

	private void txtTy_gia_Validated(object sender, EventArgs e)
	{
		if ((!base.IsLoading && base.ActionMode != Commons.ApplicationMode.VIEW_MODE && !IsValidateCalledFromValidData) || 1 == 0)
		{
			V_Ty_Gia();
		}
	}

	private void adgvDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if ((CTTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			bool flag = true;
			DataRowView oDv = CT1Voucher[e.RowIndex];
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcSo_luongm).Name, false) == 0)
			{
				V_So_LuongM(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_ntm).Name, false) == 0)
			{
				V_Gia_NtM(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_ntm).Name, false) == 0)
			{
				V_Tien_ntM(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTienm).Name, false) == 0)
			{
				V_tien(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGiam).Name, false) == 0)
			{
				V_GiaM(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_vtm).Name, false) == 0)
			{
				V_Ma_VtM(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_khom).Name, false) == 0)
			{
				V_Ma_KhoM(oDv);
			}
			else
			{
				flag = false;
			}
			if (flag)
			{
				((DataGridView)adgvDetail).InvalidateRow(e.RowIndex);
			}
		}
	}

	private void adgvDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if ((CTTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			DataRowView dataRowView = CT1Voucher[e.RowIndex];
			object obj = null;
			DataGridViewCell currentCell = ((DataGridView)adgvDetail).CurrentCell;
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_ntm).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_NtM(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTienm).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_TienM(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGiam).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_GiaM(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_khom).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["ten_kho"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_bp).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Bp"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_hd).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Hd"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_phi).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Phi"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_spct).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Spct"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_vtm).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_vt"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_Dum).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_du"]);
			}
			obj = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(obj), isNum: false));
			((ToolStripItem)tsslInfo).Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(obj, (object)"", false), (object)frmVoucher.BASEVOUCHER_INPUTGRID_TIP_TEXT, RuntimeHelpers.GetObjectValue(obj)));
		}
	}

	private void adgvDetail_SelectionChanged(object sender, EventArgs e)
	{
		if ((CT1Voucher.Count > 0 && ((DataGridView)adgvDetail).CurrentRow != null && ((DataGridViewBand)((DataGridView)adgvDetail).CurrentRow).Index >= 0) ? true : false)
		{
			f_oTblCtD.DefaultView.RowFilter = Conversions.ToString(Operators.ConcatenateObject((object)("Stt_rec = '" + ((Control)cmdAdd).Tag.ToString()), Interaction.IIf(chkXembo.Checked, Operators.ConcatenateObject(Operators.ConcatenateObject((object)"' and ma_bo='", CT1Voucher[((DataGridViewBand)((DataGridView)adgvDetail).CurrentRow).Index]["ma_Vt"]), (object)"'"), (object)"'")));
		}
	}

	private void adgvDetail4detail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if ((f_oTblCtD != null && !base.IsLoading && e.RowIndex >= 0) || 1 == 0)
		{
			bool flag = true;
			DataRowView oDv = f_oTblCtD.DefaultView[e.RowIndex];
			string name = ((DataGridView)adgvDetail4detail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcSo_luongd).Name, false) == 0)
			{
				V_So_LuongD(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_ntd).Name, false) == 0)
			{
				V_Gia_NtD(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_ntd).Name, false) == 0)
			{
				V_Tien_ntD(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTiend).Name, false) == 0)
			{
				V_tien(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGiad).Name, false) == 0)
			{
				V_GiaD(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_vtd).Name, false) == 0)
			{
				V_Ma_VtD(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_khod).Name, false) == 0)
			{
				V_Ma_KhoD(oDv);
			}
			else
			{
				flag = false;
			}
			if (flag)
			{
				((DataGridView)adgvDetail4detail).InvalidateRow(e.RowIndex);
			}
		}
	}

	private void adgvDetail4detail_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (f_oTblCtD != null && !base.IsLoading && 0 == 0)
		{
			DataRowView dataRowView = f_oTblCtD.DefaultView[e.RowIndex];
			object obj = null;
			DataGridViewCell currentCell = ((DataGridView)adgvDetail4detail).CurrentCell;
			string name = ((DataGridView)adgvDetail4detail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_ntd).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_NtD(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTiend).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_TienD(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGiad).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_GiaD(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_khod).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["ten_kho"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_bpd).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Bp"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_hdd).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Hd"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_phid).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Phi"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_spctd).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Spct"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_vtd).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_vt"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_dud).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_du"]);
			}
			obj = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(obj), isNum: false));
			((ToolStripItem)tsslInfo).Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(obj, (object)"", false), (object)frmVoucher.BASEVOUCHER_INPUTGRID_TIP_TEXT, RuntimeHelpers.GetObjectValue(obj)));
		}
	}

	private void adgvDetail4detail_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		if (ActionMode != Commons.ApplicationMode.VIEW_MODE && (((int)e.KeyCode == 119 && (int)CMessageBox.Show(50003, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)256) == 6) ? true : false))
		{
			((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)adgvDetail4detail).DataSource)].Current).Delete();
		}
	}

	private bool W_Tien_NtM(DataRowView oDv)
	{
		return true;
	}

	private bool W_TienM(DataRowView oDv)
	{
		return true;
	}

	private bool W_GiaM(DataRowView oDv)
	{
		return true;
	}

	private void V_Ma_VtM(DataRowView oDv)
	{
		if (!Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_vt"]), isNum: false), (object)"", false))
		{
			InsertDetailFromBom(Conversions.ToString(oDv["ma_vt"]));
			ReCalcTonKhoTucThoi(oDv);
			DataRow pDrw = null;
			if (Commons.ValidMa(ref pDrw, "MA_KHO", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_kho"]), isNum: false)), "", "kho_dl,tk_dl", pSd: true) && ((Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)true, false) && Operators.ConditionalCompareObjectNotEqual(pDrw["tk_dl"], (object)"", false)) ? true : false))
			{
				oDv["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["tk_dl"]);
			}
		}
	}

	private void V_Ma_KhoM(DataRowView oDv)
	{
		ReCalcTonKhoTucThoi(oDv);
		DataRow pDrw = null;
		if (Commons.ValidMa(ref pDrw, "MA_KHO", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_kho"]), isNum: false)), "", "kho_dl,tk_dl", pSd: true) && ((Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)true, false) && Operators.ConditionalCompareObjectNotEqual(pDrw["tk_dl"], (object)"", false)) ? true : false))
		{
			oDv["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["tk_dl"]);
		}
		if ((pDrw != null && Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)false, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["MA_VT"]), isNum: false), (object)"", false)) ? true : false)
		{
			Commons.ValidMa(ref pDrw, "MA_VT", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["MA_VT"]), isNum: false)), "", "TK_VT", pSd: true);
			oDv["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["TK_VT"]);
		}
	}

	private void V_So_LuongM(DataRowView oDv)
	{
		Calc_TienVonM(oDv);
		Calc_So_luong_qd(oDv);
		UpdateSoLuong4Detail(oDv);
		PhanBoTienVon();
		UpdateList();
	}

	private void V_Gia_NtM(DataRowView oDv)
	{
		Calc_TienVonM(oDv);
		PhanBoTienVon();
		UpdateList();
	}

	private void V_GiaM(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array6 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array7 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		PhanBoTienVon();
		UpdateList();
	}

	private void V_Tien_ntM(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array6 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array7 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true), (object)0, false)) ? true : false)
		{
			int num = AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia_Nt;
			if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				num = AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia;
			}
			Type? typeFromHandle3 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array8 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Gia_Nt"] = RuntimeHelpers.GetObjectValue(obj3);
			if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
			{
				Type? typeFromHandle4 = typeof(Math);
				object[] array3 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), txtTy_gia.Value),
					null,
					null
				};
				object[] array9 = array3;
				SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array9[1] = sIConfiguration.Round_Gia;
				array3[2] = MidpointRounding.AwayFromZero;
				array = array3;
				object[] array10 = array;
				array5 = new bool[3] { false, true, false };
				object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array5);
				if (array5[1])
				{
					sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj4);
			}
			else
			{
				Type? typeFromHandle5 = typeof(Math);
				array = new object[3]
				{
					Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
					num,
					MidpointRounding.AwayFromZero
				};
				object[] array11 = array;
				array5 = new bool[3] { false, true, false };
				object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array11, (string[])null, (Type[])null, array5);
				if (array5[1])
				{
					num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				oDv["Gia_"] = RuntimeHelpers.GetObjectValue(obj5);
			}
		}
		PhanBoTienVon();
		UpdateList();
	}

	private void V_tien(DataRowView oDv)
	{
		if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true), (object)0, false)) ? true : false)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
				null,
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round_Gia;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array2 = array;
			bool[] array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj);
		}
	}

	private void Calc_TienVonM(DataRowView oDv)
	{
		object[] array;
		bool[] array5;
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round_Gia;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj);
		}
		if (!Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true)), (object)0, false))
		{
			return;
		}
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		Type? typeFromHandle2 = typeof(Math);
		array = new object[3]
		{
			Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true)),
			num,
			MidpointRounding.AwayFromZero
		};
		object[] array6 = array;
		array5 = new bool[3] { false, true, false };
		object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array5);
		if (array5[1])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		oDv["Tien_Nt"] = RuntimeHelpers.GetObjectValue(obj2);
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)),
				null,
				null
			};
			object[] array7 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array7[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			array = array3;
			object[] array8 = array;
			array5 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array9 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			array = array3;
			object[] array10 = array;
			array5 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	private void UpdateSoLuong4Detail(DataRowView oDrvCtM)
	{
		if (!Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrvCtM["ma_Vt"]), isNum: false), (object)"", false))
		{
			string filterExpression = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" Stt_Rec= '", ((Control)cmdAdd).Tag), (object)"' and ma_bo ='"), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrvCtM["ma_Vt"]), isNum: false)), (object)"'"));
			DataRow[] array = f_oTblCtD.Select(filterExpression);
			foreach (DataRow dataRow in array)
			{
				dataRow["so_luong"] = Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrvCtM["so_luong_qd"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["sl_bom"]), isNum: true));
				Calc_So_luong_qd(dataRow);
			}
		}
	}

	private bool W_Tien_NtD(DataRowView oDv)
	{
		return true;
	}

	private bool W_TienD(DataRowView oDv)
	{
		return true;
	}

	private bool W_GiaD(DataRowView oDv)
	{
		return true;
	}

	private void V_Ma_VtD(DataRowView oDv)
	{
		ReCalcTonKhoTucThoi(oDv);
		DataRow pDrw = null;
		if (Commons.ValidMa(ref pDrw, "MA_KHO", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_kho"]), isNum: false)), "", "kho_dl,tk_dl", pSd: true) && ((Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)true, false) && Operators.ConditionalCompareObjectNotEqual(pDrw["tk_dl"], (object)"", false)) ? true : false))
		{
			oDv["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["tk_dl"]);
		}
	}

	private void V_Ma_KhoD(DataRowView oDv)
	{
		ReCalcTonKhoTucThoi(oDv);
		DataRow pDrw = null;
		if (Commons.ValidMa(ref pDrw, "MA_KHO", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_kho"]), isNum: false)), "", "kho_dl,tk_dl", pSd: true) && ((Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)true, false) && Operators.ConditionalCompareObjectNotEqual(pDrw["tk_dl"], (object)"", false)) ? true : false))
		{
			oDv["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["tk_dl"]);
		}
		if (Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)false, false))
		{
			Commons.ValidMa(ref pDrw, "MA_VT", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["MA_VT"]), isNum: false)), "", "TK_VT", pSd: true);
			oDv["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["TK_VT"]);
		}
	}

	private void V_So_LuongD(DataRowView oDv)
	{
		Calc_TienVonD(oDv);
		Calc_So_luong_qd(oDv);
		PhanBoTienVon();
		UpdateList();
	}

	private void V_Gia_NtD(DataRowView oDv)
	{
		Calc_TienVonD(oDv);
		PhanBoTienVon();
		UpdateList();
	}

	private void V_GiaD(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array6 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array7 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		PhanBoTienVon();
		UpdateList();
	}

	private void V_Tien_ntD(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array6 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array7 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true), (object)0, false)) ? true : false)
		{
			int num = AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia_Nt;
			if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				num = AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia;
			}
			Type? typeFromHandle3 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array8 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Gia_Nt"] = RuntimeHelpers.GetObjectValue(obj3);
			if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
			{
				Type? typeFromHandle4 = typeof(Math);
				object[] array3 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), txtTy_gia.Value),
					null,
					null
				};
				object[] array9 = array3;
				SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array9[1] = sIConfiguration.Round_Gia;
				array3[2] = MidpointRounding.AwayFromZero;
				array = array3;
				object[] array10 = array;
				array5 = new bool[3] { false, true, false };
				object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array5);
				if (array5[1])
				{
					sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj4);
			}
			else
			{
				Type? typeFromHandle5 = typeof(Math);
				array = new object[3]
				{
					Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
					num,
					MidpointRounding.AwayFromZero
				};
				object[] array11 = array;
				array5 = new bool[3] { false, true, false };
				object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array11, (string[])null, (Type[])null, array5);
				if (array5[1])
				{
					num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				oDv["Gia_"] = RuntimeHelpers.GetObjectValue(obj5);
			}
		}
		PhanBoTienVon();
		UpdateList();
	}

	private void V_Ma_VtDFromBoM(DataRow oDv)
	{
		DataRow pDrw = null;
		Commons.ValidMa(ref pDrw, "MA_VT", Conversions.ToString(oDv["Ma_Vt"]), "", "ten_vt,dvt,tk_vt", pSd: true);
		PhanBoTienVon();
		if (pDrw != null)
		{
			oDv["ten_vt"] = RuntimeHelpers.GetObjectValue(pDrw["ten_vt"]);
			oDv["dvt"] = RuntimeHelpers.GetObjectValue(pDrw["dvt"]);
			oDv["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["tk_vt"]);
		}
	}

	private void Calc_TienVonD(DataRowView oDv)
	{
		object[] array;
		bool[] array5;
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round_Gia;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj);
		}
		if (!Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true)), (object)0, false))
		{
			return;
		}
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		Type? typeFromHandle2 = typeof(Math);
		array = new object[3]
		{
			Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true)),
			num,
			MidpointRounding.AwayFromZero
		};
		object[] array6 = array;
		array5 = new bool[3] { false, true, false };
		object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array5);
		if (array5[1])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		oDv["Tien_Nt"] = RuntimeHelpers.GetObjectValue(obj2);
		if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)),
				null,
				null
			};
			object[] array7 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array7[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			array = array3;
			object[] array8 = array;
			array5 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array9 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			array = array3;
			object[] array10 = array;
			array5 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	private void Calc_So_luong_qd(DataRowView oDv)
	{
		oDv["so_luong_qd"] = RuntimeHelpers.GetObjectValue(oDv["so_luong"]);
	}

	private void Calc_So_luong_qd(DataRow oDv)
	{
		oDv["so_luong_qd"] = RuntimeHelpers.GetObjectValue(oDv["so_luong"]);
	}

	private void ReCalcTonKhoTucThoi(DataRowView odv)
	{
		if ((!Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_vt"]), isNum: false), (object)"", false) || !Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_kho"]), isNum: false), (object)"", false)) && 0 == 0)
		{
			string aMa_Kho = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_kho"]), isNum: false));
			string aMa_Vt = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_vt"]), isNum: false));
			DateTime aNgay_Ct = Conversions.ToDate(txtNgay_Ct.Value);
			double value = default(double);
			decimal aTon = new decimal(value);
			double value2 = default(double);
			decimal aTon_all = new decimal(value2);
			double value3 = default(double);
			decimal aTon_Mua = new decimal(value3);
			double value4 = default(double);
			decimal aTon_Mua_all = new decimal(value4);
			double value5 = default(double);
			decimal aTon_Ban = new decimal(value5);
			double value6 = default(double);
			decimal aTon_Ban_all = new decimal(value6);
			Commons.Get_TonKhoAll(aMa_Kho, aMa_Vt, aNgay_Ct, ref aTon, ref aTon_all, ref aTon_Mua, ref aTon_Mua_all, ref aTon_Ban, ref aTon_Ban_all);
			value6 = Convert.ToDouble(aTon_Ban_all);
			value5 = Convert.ToDouble(aTon_Ban);
			value4 = Convert.ToDouble(aTon_Mua_all);
			value3 = Convert.ToDouble(aTon_Mua);
			value2 = Convert.ToDouble(aTon_all);
			value = Convert.ToDouble(aTon);
			odv["Ton"] = value;
			odv["ton_All"] = value2;
			odv["Ton_mua"] = value3;
			odv["ton_mua_All"] = value4;
			odv["Ton_ban"] = value5;
			odv["ton_ban_All"] = value6;
		}
	}

	private void V_Ty_Gia()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		if ((Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false) && CT1Voucher != null && CT1Voucher.Count > 0) ? true : false)
		{
			foreach (DataGridViewRow item in (IEnumerable)((DataGridView)adgvDetail).Rows)
			{
				DataGridViewRow val = item;
				DataRowView dataRowView = base.CT1Voucher[((DataGridViewBand)val).Index];
				if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Gia"]), isNum: true)), (object)0, false))
				{
					DataRowView dataRowView2 = dataRowView;
					Type? typeFromHandle = typeof(Math);
					object[] array = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Gia"]), isNum: true)),
						null,
						null
					};
					object[] array2 = array;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array2[1] = sIConfiguration.Round;
					array[2] = MidpointRounding.AwayFromZero;
					object[] array3 = array;
					object[] array4 = array3;
					bool[] array5 = new bool[3] { false, true, false };
					object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
					}
					dataRowView2["Tien"] = RuntimeHelpers.GetObjectValue(obj);
				}
				else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
				{
					DataRowView dataRowView3 = dataRowView;
					Type? typeFromHandle2 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_nt"]), isNum: true), txtTy_gia.Value),
						null,
						null
					};
					object[] array6 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array6[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array7 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					dataRowView3["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
				}
			}
			foreach (DataGridViewRow item2 in (IEnumerable)((DataGridView)adgvDetail4detail).Rows)
			{
				DataGridViewRow val2 = item2;
				DataRowView dataRowView = f_oTblCtD.DefaultView[((DataGridViewBand)val2).Index];
				if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Gia"]), isNum: true)), (object)0, false))
				{
					DataRowView dataRowView4 = dataRowView;
					Type? typeFromHandle3 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Gia"]), isNum: true)),
						null,
						null
					};
					object[] array8 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array8[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array9 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array9, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					dataRowView4["Tien"] = RuntimeHelpers.GetObjectValue(obj3);
				}
				else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
				{
					DataRowView dataRowView5 = dataRowView;
					Type? typeFromHandle4 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_nt"]), isNum: true), txtTy_gia.Value),
						null,
						null
					};
					object[] array10 = array3;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array10[1] = sIConfiguration.Round;
					array3[2] = MidpointRounding.AwayFromZero;
					object[] array = array3;
					object[] array11 = array;
					bool[] array5 = new bool[3] { false, true, false };
					object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array11, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
					}
					dataRowView5["Tien"] = RuntimeHelpers.GetObjectValue(obj4);
				}
			}
		}
		UpdateList();
	}

	private void InsertDetailFromBom(string aMa_vt)
	{
		string filterExpression = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", CurrentPHRow["stt_rec"]), (object)"' and Ma_Bo = '"), (object)aMa_vt), (object)"'"));
		if (f_oTblCtD.Select(filterExpression).Length > 0)
		{
			return;
		}
		DataTable boMByMa_vt = MyController.GetBoMByMa_vt(CompanyInformations.CompanyID, aMa_vt);
		foreach (DataRow row in boMByMa_vt.Rows)
		{
			InsertOneDetailFromBom(row);
		}
		MasterDetailRelationRefresh();
		if (boMByMa_vt.Rows.Count > 0)
		{
			DataRow[] array = f_oTblCtD.Select(filterExpression);
			foreach (DataRow oDv in array)
			{
				Calc_So_luong_qd(oDv);
			}
		}
	}

	private void InsertOneDetailFromBom(DataRow oDrwBom)
	{
		DataRow dataRow = f_oTblCtD.NewRow();
		dataRow["Ma_Cty"] = CompanyInformations.CompanyID;
		dataRow["Stt_Rec"] = RuntimeHelpers.GetObjectValue(CurrentPHRow["Stt_Rec"]);
		dataRow["Stt_Rec0"] = Commons.Get_SttRec0(Conversions.ToString(CurrentPHRow["Stt_rec"]), f_oTblCtD);
		dataRow["Ma_Bo"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrwBom["Ma_Bo"]), isNum: false));
		dataRow["Ma_vt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrwBom["ma_lk"]), isNum: false));
		dataRow["Ten_vt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrwBom["ten_lk"]), isNum: false));
		dataRow["Ma_kho"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrwBom["Ma_kho"]), isNum: false));
		dataRow["dvt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrwBom["dvt"]), isNum: false));
		dataRow["so_luong"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrwBom["so_luong"]), isNum: true));
		dataRow["sl_bom"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrwBom["so_luong"]), isNum: true));
		V_Ma_VtDFromBoM(dataRow);
		f_oTblCtD.Rows.Add(dataRow);
	}

	private void Update_CPGC(DataRowView oDrvCt)
	{
	}

	private void PhanBoTienVon()
	{
		if (Operators.ConditionalCompareObjectEqual(chkGia_tb.Checked, (object)true, false))
		{
			return;
		}
		string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" Stt_Rec= '", ((Control)cmdAdd).Tag), (object)"'"));
		if (Operators.ConditionalCompareObjectEqual(((ListControl)cboMa_gd).SelectedValue, (object)"1", false))
		{
			DataRow[] array = CTTable.Select(text);
			foreach (DataRow dataRow in array)
			{
				dataRow["Tien"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(Commons.ColumnSum(f_oTblCtD, "Tien", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + " and ma_bo='"), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Ma_Vt"]), isNum: false)), (object)"'"))), isNum: true));
				dataRow["Tien_nt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(Commons.ColumnSum(f_oTblCtD, "Tien_nt", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + " and ma_bo='"), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Ma_Vt"]), isNum: false)), (object)"'"))), isNum: true));
				if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["so_luong"]), isNum: true), (object)0, false))
				{
					Type? typeFromHandle = typeof(Math);
					object[] array2 = new object[3]
					{
						Operators.DivideObject(dataRow["Tien_nt"], Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["so_luong"]), isNum: true)),
						null,
						null
					};
					object[] array3 = array2;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array3[1] = sIConfiguration.Round_Gia_Nt;
					array2[2] = MidpointRounding.AwayFromZero;
					object[] array4 = array2;
					object[] array5 = array4;
					bool[] array6 = new bool[3] { false, true, false };
					object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array5, (string[])null, (Type[])null, array6);
					if (array6[1])
					{
						sIConfiguration.Round_Gia_Nt = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
					}
					dataRow["Gia_Nt"] = RuntimeHelpers.GetObjectValue(obj);
					Type? typeFromHandle2 = typeof(Math);
					array4 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Gia_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
						null,
						null
					};
					object[] array7 = array4;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array7[1] = sIConfiguration.Round_Gia;
					array4[2] = MidpointRounding.AwayFromZero;
					array2 = array4;
					object[] array8 = array2;
					array6 = new bool[3] { false, true, false };
					object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array8, (string[])null, (Type[])null, array6);
					if (array6[1])
					{
						sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
					}
					dataRow["Gia"] = RuntimeHelpers.GetObjectValue(obj2);
				}
			}
			return;
		}
		DataRow[] array9 = CTTable.Select(text);
		checked
		{
			foreach (DataRow dataRow2 in array9)
			{
				double num = Conversions.ToDouble(Helper.Repl_Null(Commons.ColumnSum(f_oTblCtD, "he_so", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + " and ma_bo='"), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow2["Ma_Vt"]), isNum: false)), (object)"'"))), isNum: true));
				if (num == 0.0)
				{
					continue;
				}
				DataRow[] array10 = f_oTblCtD.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + " and ma_bo='"), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow2["Ma_Vt"]), isNum: false)), (object)"'")));
				int num2 = array10.Length - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					DataRow obj3 = array10[num3];
					Type? typeFromHandle3 = typeof(Math);
					object[] array4 = new object[3]
					{
						Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow2["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(array10[num3]["he_so"]), isNum: true)), (object)num),
						null,
						null
					};
					object[] array11 = array4;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array11[1] = sIConfiguration.Round;
					array4[2] = MidpointRounding.AwayFromZero;
					object[] array2 = array4;
					object[] array12 = array2;
					bool[] array6 = new bool[3] { false, true, false };
					object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array12, (string[])null, (Type[])null, array6);
					if (array6[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
					}
					obj3["Tien"] = RuntimeHelpers.GetObjectValue(obj4);
					DataRow obj5 = array10[num3];
					Type? typeFromHandle4 = typeof(Math);
					array4 = new object[3]
					{
						Operators.DivideObject(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow2["Tien_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(array10[num3]["he_so"]), isNum: true)), (object)num),
						null,
						null
					};
					object[] array13 = array4;
					sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array13[1] = sIConfiguration.Round;
					array4[2] = MidpointRounding.AwayFromZero;
					array2 = array4;
					object[] array14 = array2;
					array6 = new bool[3] { false, true, false };
					object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array14, (string[])null, (Type[])null, array6);
					if (array6[1])
					{
						sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
					}
					obj5["Tien_nt"] = RuntimeHelpers.GetObjectValue(obj6);
					if (num3 == array10.Length - 1)
					{
						double num6 = Conversions.ToDouble(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow2["Tien"]), isNum: true), Helper.Repl_Null(Commons.ColumnSum(f_oTblCtD, "Tien", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + " and ma_bo='"), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow2["Ma_Vt"]), isNum: false)), (object)"'"))), isNum: true)));
						double num7 = Conversions.ToDouble(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow2["Tien_nt"]), isNum: true), Helper.Repl_Null(Commons.ColumnSum(f_oTblCtD, "Tien_nt", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + " and ma_bo='"), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow2["Ma_Vt"]), isNum: false)), (object)"'"))), isNum: true)));
						array10[num3]["Tien"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(array10[num3]["Tien"]), isNum: false), (object)num6);
						array10[num3]["Tien_nt"] = Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(array10[num3]["Tien_nt"]), isNum: false), (object)num7);
					}
					if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(array10[num3]["so_luong"]), isNum: true), (object)0, false))
					{
						DataRow obj7 = array10[num3];
						Type? typeFromHandle5 = typeof(Math);
						array4 = new object[3]
						{
							Operators.DivideObject(array10[num3]["Tien_nt"], Helper.Repl_Null(RuntimeHelpers.GetObjectValue(array10[num3]["so_luong"]), isNum: true)),
							null,
							null
						};
						object[] array15 = array4;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array15[1] = sIConfiguration.Round_Gia_Nt;
						array4[2] = MidpointRounding.AwayFromZero;
						array2 = array4;
						object[] array16 = array2;
						array6 = new bool[3] { false, true, false };
						object obj8 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array16, (string[])null, (Type[])null, array6);
						if (array6[1])
						{
							sIConfiguration.Round_Gia_Nt = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
						}
						obj7["Gia_Nt"] = RuntimeHelpers.GetObjectValue(obj8);
						DataRow obj9 = array10[num3];
						Type? typeFromHandle6 = typeof(Math);
						array4 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(array10[num3]["Gia_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
							null,
							null
						};
						object[] array17 = array4;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array17[1] = sIConfiguration.Round_Gia;
						array4[2] = MidpointRounding.AwayFromZero;
						array2 = array4;
						object[] array18 = array2;
						array6 = new bool[3] { false, true, false };
						object obj10 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array18, (string[])null, (Type[])null, array6);
						if (array6[1])
						{
							sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
						}
						obj9["Gia"] = RuntimeHelpers.GetObjectValue(obj10);
					}
					num3++;
				}
			}
		}
	}

	private bool ValidGridCell(DataGridViewCell Cell, int Cmess)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Cell.ErrorText = Helper.GetMessContent(Cmess);
		((TabControl)AsTabControl).SelectedTab = tabDetail;
		((Control)adgvDetail).Select();
		((DataGridView)adgvDetail).CurrentCell = Cell;
		CMessageBox.Show(Cmess);
		return false;
	}

	private bool ValidGridCell4detail(DataGridViewCell Cell, int Cmess)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Cell.ErrorText = Helper.GetMessContent(Cmess);
		((TabControl)AsTabControl).SelectedTab = tabDetail;
		((Control)adgvDetail4detail).Select();
		((DataGridView)adgvDetail4detail).CurrentCell = Cell;
		CMessageBox.Show(Cmess);
		return false;
	}

	private void RefreshValueByMa_Nt()
	{
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) != 0)
		{
			return;
		}
		foreach (DataRowView item in base.CT1Voucher)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["tien_nt"]), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			item["tien_nt"] = RuntimeHelpers.GetObjectValue(obj);
			Type? typeFromHandle2 = typeof(Math);
			array3 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt"]), isNum: true)),
				null,
				null
			};
			object[] array6 = array3;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round_Gia;
			array3[2] = MidpointRounding.AwayFromZero;
			array = array3;
			object[] array7 = array;
			array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			item["gia_nt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		string filterExpression = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", CurrentPHRow["stt_rec"]), (object)"'"));
		DataRow[] array8 = f_oTblCtD.Select(filterExpression);
		foreach (DataRow dataRow in array8)
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["tien_nt"]), isNum: true)),
				null,
				null
			};
			object[] array9 = array3;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			object[] array = array3;
			object[] array10 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array10, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			dataRow["tien_nt"] = RuntimeHelpers.GetObjectValue(obj3);
			Type? typeFromHandle4 = typeof(Math);
			array3 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["gia_nt"]), isNum: true)),
				null,
				null
			};
			object[] array11 = array3;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array11[1] = sIConfiguration.Round_Gia;
			array3[2] = MidpointRounding.AwayFromZero;
			array = array3;
			object[] array12 = array;
			array5 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array12, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			dataRow["gia_nt"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	protected override void InitOtherBeforeLoadData()
	{
		base.InitOtherBeforeLoadData();
		ArrayList dmMagd = AsiaErp.Framework.Environment.GetDmMagd(base.MyVoucherInfo.voucher_code);
		if (dmMagd == null || dmMagd.Count == 0)
		{
			return;
		}
		cboMa_gd.DataSource = dmMagd;
		((ListControl)cboMa_gd).ValueMember = "ma_gd";
		((ListControl)cboMa_gd).DisplayMember = "mo_ta";
		cboMa_gd.SelectedIndex = 0;
		foreach (DmMaGd item in dmMagd)
		{
			if (item.ngam_dinh)
			{
				f_sMa_Gd_Default = item.ma_gd;
				break;
			}
		}
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		base.PHTable.Columns["ma_gd"].DefaultValue = "1";
		((DataGridView)adgvDetail4detail).DataSource = f_oTblCtD.DefaultView;
		AddControl2ListOfDrivedControls((Control)(object)chkGia_tb);
		AddControl2ListOfDrivedControls((Control)(object)adgvDetail4detail);
		f_sGiaM = ((DataGridViewColumn)dgvcGia_ntm).HeaderText;
		f_sTienM = ((DataGridViewColumn)dgvcTien_ntm).HeaderText;
		f_sGiaD = ((DataGridViewColumn)dgvcGia_ntd).HeaderText;
		f_sTienD = ((DataGridViewColumn)dgvcTien_ntd).HeaderText;
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Tien_nt);
		AddDGV(adgvDetail4detail);
	}

	protected override void RefreshDGVInput()
	{
		base.RefreshDGVInput();
		if (CTTable == null)
		{
			return;
		}
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			txtTy_gia.Value = 1;
			((TextBoxBase)txtTy_gia).ReadOnly = true;
			((Control)txtTy_gia).TabStop = false;
			((DataGridViewColumn)dgvcGiam).Visible = false;
			((DataGridViewColumn)dgvcTienm).Visible = false;
			((DataGridViewColumn)dgvcGiad).Visible = false;
			((DataGridViewColumn)dgvcTiend).Visible = false;
			((Control)txtT_Tien).Visible = false;
		}
		else
		{
			((TextBoxBase)txtTy_gia).ReadOnly = ActionMode == Commons.ApplicationMode.VIEW_MODE;
			((Control)txtTy_gia).TabStop = true;
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				txtTy_gia.Value = Commons.Get_TyGia(cboMa_NT.MA_NT, Conversions.ToDate(txtNgay_Ct.Value));
			}
			((DataGridViewColumn)dgvcGiam).Visible = true;
			((DataGridViewColumn)dgvcTienm).Visible = true;
			((DataGridViewColumn)dgvcGiad).Visible = true;
			((DataGridViewColumn)dgvcTiend).Visible = true;
			((Control)txtT_Tien).Visible = true;
		}
		string mA_NT = cboMa_NT.MA_NT;
		((DataGridViewColumn)dgvcGia_ntm).HeaderText = f_sGiaM + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_ntm).HeaderText = f_sTienM + " " + mA_NT;
		((DataGridViewColumn)dgvcGia_ntd).HeaderText = f_sGiaD + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_ntd).HeaderText = f_sTienD + " " + mA_NT;
	}

	protected override void SetFocus4FirstEditControl()
	{
		((Control)cboMa_gd).Focus();
	}

	protected override void UpdateList()
	{
		if (base.CurrentPHRow != null)
		{
			string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", base.CurrentPHRow["Stt_Rec"]), (object)"'"));
			txtT_Tien_nt.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_nt)", filter));
			txtT_Tien.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien)", filter));
		}
	}

	protected override bool ValidData()
	{
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Invalid comparison between Unknown and I4
		//IL_1192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Invalid comparison between Unknown and I4
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Invalid comparison between Unknown and I4
		//IL_11b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Invalid comparison between Unknown and I4
		bool flag = true;
		bool flag2 = false;
		if ((ChkEmtyTextBox((TextBox)(object)txtMa_Kh) && base.ValidData()) ? true : false)
		{
			bool flag3 = true;
			bool flag4 = true;
			int num10;
			int num11;
			checked
			{
				int num = CT1Voucher.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					DataRowView dataRowView = CT1Voucher[num2];
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_du"]), isNum: false), (object)"", false))
					{
						return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTk_Dum).Name, num2], 50023);
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_vt"]), isNum: false), (object)"", false))
					{
						return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTk_vtm).Name, num2], 50023);
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Vt"]), isNum: false), (object)"", false))
					{
						return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_vtm).Name, num2], 50062);
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Kho"]), isNum: false), (object)"", false))
					{
						return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_khom).Name, num2], 50056);
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), (object)0, false))
					{
						flag3 = false;
					}
					unchecked
					{
						if (((int)((CheckBox)chkGia_tb).CheckState == 0 && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Nt"]), isNum: true), (object)0, false)) ? true : false)
						{
							flag4 = false;
						}
						if (((int)((CheckBox)chkGia_tb).CheckState == 0 && Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tien"]), isNum: true), (object)0, false)) ? true : false)
						{
							return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTienm).Name, num2], 50037);
						}
						if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh, isNum: false), (object)"0", false))
						{
							bool flag5 = (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh, isNum: false), (object)"1", false) ? true : false);
							double num5 = Conversions.ToDouble(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_toi_da, isNum: true));
							double num6 = Conversions.ToDouble(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_tien_nt_toi_da, isNum: true));
							if ((Operators.ConditionalCompareObjectNotEqual(((ListControl)cboMa_NT).SelectedValue, (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) && Operators.ConditionalCompareObjectGreater(txtTy_gia.Value, (object)0, false)) ? true : false)
							{
								Type? typeFromHandle = typeof(Math);
								object[] array = new object[3]
								{
									Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Gia"]), isNum: true)),
									null,
									null
								};
								object[] array2 = array;
								SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
								array2[1] = sIConfiguration.Round;
								array[2] = MidpointRounding.AwayFromZero;
								object[] array3 = array;
								object[] array4 = array3;
								bool[] array5 = new bool[3] { false, true, false };
								object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
								if (array5[1])
								{
									sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
								}
								double num7 = Conversions.ToDouble(obj);
								if ((num7 == 0.0 && Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false)) ? true : false)
								{
									DataRowView dataRowView2 = dataRowView;
									Type? typeFromHandle2 = typeof(Math);
									array3 = new object[3]
									{
										Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_nt"]), isNum: true), txtTy_gia.Value),
										null,
										null
									};
									object[] array6 = array3;
									sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
									array6[1] = sIConfiguration.Round;
									array3[2] = MidpointRounding.AwayFromZero;
									array = array3;
									object[] array7 = array;
									array5 = new bool[3] { false, true, false };
									object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
									if (array5[1])
									{
										sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
									}
									dataRowView2["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
								}
								if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tien"]), isNum: true), (object)num7) }, (string[])null, (Type[])null, (bool[])null), (object)num5, false))
								{
									((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTienm).Name, num2].ErrorText = Helper.GetMessContent(50047);
									flag = flag5;
									flag2 = true;
								}
								Type? typeFromHandle3 = typeof(Math);
								array3 = new object[3]
								{
									Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Gia_Nt"]), isNum: true)),
									null,
									null
								};
								object[] array8 = array3;
								sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
								array8[1] = sIConfiguration.Round_Nt;
								array3[2] = MidpointRounding.AwayFromZero;
								array = array3;
								object[] array9 = array;
								array5 = new bool[3] { false, true, false };
								object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array9, (string[])null, (Type[])null, array5);
								if (array5[1])
								{
									sIConfiguration.Round_Nt = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
								}
								double num8 = Conversions.ToDouble(obj3);
								if ((num8 != 0.0 && Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject((object)num8, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Nt"]), isNum: true)) }, (string[])null, (Type[])null, (bool[])null), (object)num6, false)) ? true : false)
								{
									((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_ntm).Name, num2].ErrorText = Helper.GetMessContent(50047);
									flag = flag5;
									flag2 = true;
								}
							}
							else
							{
								Type? typeFromHandle4 = typeof(Math);
								object[] array3 = new object[3]
								{
									Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Gia_Nt"]), isNum: true)),
									null,
									null
								};
								object[] array10 = array3;
								SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
								array10[1] = sIConfiguration.Round_Nt;
								array3[2] = MidpointRounding.AwayFromZero;
								object[] array = array3;
								object[] array11 = array;
								bool[] array5 = new bool[3] { false, true, false };
								object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array11, (string[])null, (Type[])null, array5);
								if (array5[1])
								{
									sIConfiguration.Round_Nt = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
								}
								double num9 = Conversions.ToDouble(obj4);
								if ((num9 != 0.0 && Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject((object)num9, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Nt"]), isNum: true)) }, (string[])null, (Type[])null, (bool[])null), (object)num5, false)) ? true : false)
								{
									((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_ntm).Name, num2].ErrorText = Helper.GetMessContent(50047);
									flag = flag5;
									flag2 = true;
								}
							}
						}
					}
					num2++;
				}
				if (!flag3)
				{
					CMessageBox.Show(50037);
				}
				if (!flag4)
				{
					CMessageBox.Show(50037);
				}
				num10 = f_oTblCtD.DefaultView.Count - 1;
				num11 = 0;
			}
			while (true)
			{
				int num12 = num11;
				int num4 = num10;
				if (num12 > num4)
				{
					break;
				}
				DataRowView dataRowView = f_oTblCtD.DefaultView[num11];
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_du"]), isNum: false), (object)"", false))
				{
					return ValidGridCell4detail(((DataGridView)adgvDetail4detail)[((DataGridViewColumn)dgvcTk_dud).Name, num11], 50023);
				}
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_vt"]), isNum: false), (object)"", false))
				{
					return ValidGridCell4detail(((DataGridView)adgvDetail4detail)[((DataGridViewColumn)dgvcTk_vtd).Name, num11], 50023);
				}
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Vt"]), isNum: false), (object)"", false))
				{
					return ValidGridCell4detail(((DataGridView)adgvDetail4detail)[((DataGridViewColumn)dgvcMa_vtd).Name, num11], 50062);
				}
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Kho"]), isNum: false), (object)"", false))
				{
					return ValidGridCell4detail(((DataGridView)adgvDetail4detail)[((DataGridViewColumn)dgvcMa_khod).Name, num11], 50056);
				}
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), (object)0, false))
				{
					flag3 = false;
				}
				if (((int)((CheckBox)chkGia_tb).CheckState == 0 && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Nt"]), isNum: true), (object)0, false)) ? true : false)
				{
					flag4 = false;
				}
				if (((int)((CheckBox)chkGia_tb).CheckState == 0 && Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tien"]), isNum: true), (object)0, false)) ? true : false)
				{
					return ValidGridCell4detail(((DataGridView)adgvDetail4detail)[((DataGridViewColumn)dgvcTiend).Name, num11], 50037);
				}
				if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh, isNum: false), (object)"0", false))
				{
					bool flag6 = (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh, isNum: false), (object)"1", false) ? true : false);
					double num13 = Conversions.ToDouble(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_toi_da, isNum: true));
					double num14 = Conversions.ToDouble(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_tien_nt_toi_da, isNum: true));
					if ((Operators.ConditionalCompareObjectNotEqual(((ListControl)cboMa_NT).SelectedValue, (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) && Operators.ConditionalCompareObjectGreater(txtTy_gia.Value, (object)0, false)) ? true : false)
					{
						Type? typeFromHandle5 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Gia"]), isNum: true)),
							null,
							null
						};
						object[] array12 = array3;
						SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array12[1] = sIConfiguration.Round;
						array3[2] = MidpointRounding.AwayFromZero;
						object[] array = array3;
						object[] array13 = array;
						bool[] array5 = new bool[3] { false, true, false };
						object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array13, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						double num15 = Conversions.ToDouble(obj5);
						if ((num15 == 0.0 && Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false)) ? true : false)
						{
							DataRowView dataRowView3 = dataRowView;
							Type? typeFromHandle6 = typeof(Math);
							array3 = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_nt"]), isNum: true), txtTy_gia.Value),
								null,
								null
							};
							object[] array14 = array3;
							sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
							array14[1] = sIConfiguration.Round;
							array3[2] = MidpointRounding.AwayFromZero;
							array = array3;
							object[] array15 = array;
							array5 = new bool[3] { false, true, false };
							object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array15, (string[])null, (Type[])null, array5);
							if (array5[1])
							{
								sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
							}
							dataRowView3["Tien"] = RuntimeHelpers.GetObjectValue(obj6);
						}
						if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tien"]), isNum: true), (object)num15) }, (string[])null, (Type[])null, (bool[])null), (object)num13, false))
						{
							((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTiend).Name, num11].ErrorText = Helper.GetMessContent(50047);
							flag = flag6;
							flag2 = true;
						}
						Type? typeFromHandle7 = typeof(Math);
						array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Gia_Nt"]), isNum: true)),
							null,
							null
						};
						object[] array16 = array3;
						sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array16[1] = sIConfiguration.Round_Nt;
						array3[2] = MidpointRounding.AwayFromZero;
						array = array3;
						object[] array17 = array;
						array5 = new bool[3] { false, true, false };
						object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle7, "Round", array17, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round_Nt = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						double num16 = Conversions.ToDouble(obj7);
						if ((num16 != 0.0 && Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject((object)num16, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Nt"]), isNum: true)) }, (string[])null, (Type[])null, (bool[])null), (object)num14, false)) ? true : false)
						{
							((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_ntd).Name, num11].ErrorText = Helper.GetMessContent(50047);
							flag = flag6;
							flag2 = true;
						}
					}
					else
					{
						Type? typeFromHandle8 = typeof(Math);
						object[] array3 = new object[3]
						{
							Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Gia_Nt"]), isNum: true)),
							null,
							null
						};
						object[] array18 = array3;
						SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
						array18[1] = sIConfiguration.Round_Nt;
						array3[2] = MidpointRounding.AwayFromZero;
						object[] array = array3;
						object[] array19 = array;
						bool[] array5 = new bool[3] { false, true, false };
						object obj8 = NewLateBinding.LateGet((object)null, typeFromHandle8, "Round", array19, (string[])null, (Type[])null, array5);
						if (array5[1])
						{
							sIConfiguration.Round_Nt = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
						}
						double num17 = Conversions.ToDouble(obj8);
						if ((num17 != 0.0 && Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject((object)num17, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Nt"]), isNum: true)) }, (string[])null, (Type[])null, (bool[])null), (object)num13, false)) ? true : false)
						{
							((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_ntd).Name, num11].ErrorText = Helper.GetMessContent(50047);
							flag = flag6;
							flag2 = true;
						}
					}
				}
				num11 = checked(num11 + 1);
			}
			if ((flag2 && Operators.CompareString(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh, "0", false) != 0) ? true : false)
			{
				CMessageBox.Show(50047);
			}
			if (!flag)
			{
				return false;
			}
			if (!flag3)
			{
				CMessageBox.Show(50037);
			}
			if (!flag4)
			{
				CMessageBox.Show(50037);
			}
			return true;
		}
		return false;
	}

	protected override void Refresh_controls()
	{
		base.Refresh_controls();
		if (base.ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				txtTy_gia.Value = 1;
				((TextBoxBase)txtTy_gia).ReadOnly = true;
				((Control)txtTy_gia).TabStop = false;
			}
			else
			{
				((TextBoxBase)txtTy_gia).ReadOnly = false;
				((Control)txtTy_gia).TabStop = true;
			}
		}
	}

	protected override void PHDataBinding()
	{
		base.PHDataBinding();
		CreateDataBinding((Control)(object)txtMa_Kh, "Ma_Kh");
		CreateDataBinding((Control)(object)txtTen_kh, "Ten_Kh");
		CreateDataBinding((Control)(object)txtDia_chi, "Dia_chi");
		CreateDataBinding((Control)(object)txtNguoi_Gd, "Nguoi_Gd");
		CreateDataBinding((Control)(object)txtDien_giai, "Dien_Giai");
		CreateDataBinding((Control)(object)txtNgay_Ct, "ngay_ct", "Value");
		CreateDataBinding((Control)(object)txtNgay_lct, "ngay_lct", "Value");
		CreateDataBinding((Control)(object)txtSo_Ct, "so_ct");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)cboMa_gd, "ma_gd", "SelectedValue");
		CreateDataBinding((Control)(object)chkGia_tb, "PN_GTB", "Checked");
		CreateDataBinding((Control)(object)txtT_Tien, "t_tien", "Value");
		CreateDataBinding((Control)(object)txtT_Tien_nt, "t_tien_nt", "Value");
	}

	protected override void SetPHDefaultValues(DataRow drwPh)
	{
		base.SetPHDefaultValues(drwPh);
		drwPh["ma_gd"] = f_sMa_Gd_Default;
	}

	protected override void GetData()
	{
		base.GetData();
		if ((PHTable != null && PHTable.Rows.Count > 0) ? true : false)
		{
			f_oTblCtD = MyController.GetDataCTD(CompanyInformations.CompanyID, RuntimeHelpers.GetObjectValue(PHTable.Rows[0]["stt_rec"]));
		}
		else
		{
			f_oTblCtD = MyController.GetDataCTD(CompanyInformations.CompanyID, base.Stt_Rec_Bc);
		}
		f_oTblCtD.Columns["Ma_Cty"].DefaultValue = CompanyInformations.CompanyID;
		f_oTblCtD.Columns["Stt_Rec"].DefaultValue = "0";
		f_oTblCtD.Columns["Stt_Rec0"].DefaultValue = "0";
	}

	protected override object Insert2DB()
	{
		return MyController.Insert(CurrentPHRow, CTTable, f_oTblCtD, null, null);
	}

	protected override object Update2DB()
	{
		return MyController.Update(CurrentPHRow, CTTable, f_oTblCtD, null, null);
	}

	protected override bool DeleteDB()
	{
		bool flag = false;
		flag = MyController.Delete(CurrentPHRow);
		if (flag)
		{
			DataRow[] array = f_oTblCtD.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec = '", CurrentPHRow["Stt_Rec"]), (object)"'")));
			foreach (DataRow row in array)
			{
				f_oTblCtD.Rows.Remove(row);
			}
			f_oTblCtD.AcceptChanges();
			return true;
		}
		return flag;
	}

	protected override void Cancel()
	{
		f_oTblCtD.RejectChanges();
		base.Cancel();
	}

	protected override void MasterDetailRelationRefresh()
	{
		if (PHTable != null && PHTable.DefaultView.Count > 0 && ((CT1Voucher.Count > 0 && ((DataGridView)adgvDetail).CurrentRow != null && ((DataGridViewBand)((DataGridView)adgvDetail).CurrentRow).Index >= 0) ? true : false))
		{
			f_oTblCtD.DefaultView.RowFilter = Conversions.ToString(Operators.ConcatenateObject((object)("Stt_rec = '" + ((Control)cmdAdd).Tag.ToString()), Interaction.IIf(chkXembo.Checked, Operators.ConcatenateObject(Operators.ConcatenateObject((object)"' and ma_bo='", CT1Voucher[((DataGridViewBand)((DataGridView)adgvDetail).CurrentRow).Index]["ma_Vt"]), (object)"'"), (object)"'")));
		}
		base.MasterDetailRelationRefresh();
	}

	protected override void SetReportDataSource(DataRow odrPrintPHRow)
	{
		if ((CTTable != null && odrPrintPHRow != null && f_oTblCtD != null) || 1 == 0)
		{
			DataTable printDataSource = MyController.GetPrintDataSource(CompanyInformations.CompanyID, Conversions.ToString(odrPrintPHRow["stt_Rec"]));
			MyReportDocument.SetDataSource(printDataSource);
		}
	}

	protected override void Find()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		frmInVchIN6Find frmInVchIN6Find2 = new frmInVchIN6Find();
		frmInVchIN6Find2.voucher_code = base.MyVoucherInfo.voucher_code;
		frmInVchIN6Find2.MyVoucherInfo = MyVoucherInfo;
		((Form)frmInVchIN6Find2).ShowDialog();
		checked
		{
			if (Operators.ConditionalCompareObjectEqual(frmInVchIN6Find2.is_ok, (object)true, false))
			{
				base.CTTable.Clear();
				base.PHTable.Clear();
				f_oTblCtD.Clear();
				int num = frmInVchIN6Find2.f_oTblPh_.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					PHTable.ImportRow(frmInVchIN6Find2.f_oTblPh_.Rows[i]);
				}
				int num2 = frmInVchIN6Find2.f_oTblCtM.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					CTTable.ImportRow(frmInVchIN6Find2.f_oTblCtM.Rows[j]);
				}
				int num3 = frmInVchIN6Find2.f_oTblCtD.Rows.Count - 1;
				for (int k = 0; k <= num3; k++)
				{
					f_oTblCtD.ImportRow(frmInVchIN6Find2.f_oTblCtD.Rows[k]);
				}
				bsPH.Position = 0;
				((Component)(object)frmInVchIN6Find2).Dispose();
				View();
			}
			else
			{
				CMessageBox.Show(50035);
			}
		}
	}

	protected override void F8_KeyPress()
	{
		if ((CT1Voucher == null && CT1Voucher.Count <= 0) ? true : false)
		{
			return;
		}
		string text = "";
		string text2 = Conversions.ToString(CurrentCTRowView["ma_vt"]);
		text = "ma_bo = '" + text2 + "'";
		text2 = "ma_vt = '" + text2 + "'";
		base.F8_KeyPress();
		if (!CT1Voucher.Table.Select(text2).Any())
		{
			DataRow[] array = f_oTblCtD.Select(text);
			foreach (DataRow dataRow in array)
			{
				dataRow.Delete();
			}
		}
	}
}
