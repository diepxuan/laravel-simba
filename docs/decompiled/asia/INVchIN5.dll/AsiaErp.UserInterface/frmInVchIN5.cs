using System;
using System.Collections;
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
public class frmInVchIN5 : frmVoucher
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

	[AccessedThroughProperty("txtDia_chi")]
	private TextBox _txtDia_chi;

	[AccessedThroughProperty("chkGia_dd")]
	private AsCheckBox _chkGia_dd;

	[AccessedThroughProperty("txtT_So_luong")]
	private AsTextNumeric _txtT_So_luong;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("dgvcMa_vt")]
	private DataGridViewAsTextBoxColumn _dgvcMa_vt;

	[AccessedThroughProperty("dgvcTen_vt")]
	private DataGridViewTextBoxColumn _dgvcTen_vt;

	[AccessedThroughProperty("dgvcDvt")]
	private DataGridViewTextBoxColumn _dgvcDvt;

	[AccessedThroughProperty("dgvcMa_kho")]
	private DataGridViewAsTextBoxColumn _dgvcMa_kho;

	[AccessedThroughProperty("dgvcTon")]
	private DataGridViewAsTextNumericColumn _dgvcTon;

	[AccessedThroughProperty("dgvcSo_luong")]
	private DataGridViewAsTextNumericColumn _dgvcSo_luong;

	[AccessedThroughProperty("dgvcGia_nt")]
	private DataGridViewAsTextNumericColumn _dgvcGia_nt;

	[AccessedThroughProperty("dgvcTien_nt")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt;

	[AccessedThroughProperty("dgvcSo_ky")]
	private DataGridViewAsTextNumericColumn _dgvcSo_ky;

	[AccessedThroughProperty("dgvcTk_no")]
	private DataGridViewAsTextBoxColumn _dgvcTk_no;

	[AccessedThroughProperty("dgvcTk_cp")]
	private DataGridViewAsTextBoxColumn _dgvcTk_cp;

	[AccessedThroughProperty("dgvcTk_vt")]
	private DataGridViewAsTextBoxColumn _dgvcTk_vt;

	[AccessedThroughProperty("dgvcGia")]
	private DataGridViewAsTextNumericColumn _dgvcGia;

	[AccessedThroughProperty("dgvcTien")]
	private DataGridViewAsTextNumericColumn _dgvcTien;

	[AccessedThroughProperty("dgvcMa_bpsd")]
	private DataGridViewAsTextBoxColumn _dgvcMa_bpsd;

	[AccessedThroughProperty("dgvcMa_spct")]
	private DataGridViewAsTextBoxColumn _dgvcMa_spct;

	[AccessedThroughProperty("dgvcMa_phi")]
	private DataGridViewAsTextBoxColumn _dgvcMa_phi;

	[AccessedThroughProperty("dgvcMa_bp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_bp;

	[AccessedThroughProperty("dgvcMa_lo")]
	private DataGridViewAsTextBoxColumn _dgvcMa_lo;

	private string f_sGia;

	private string f_sTien;

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
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			DataGridViewCellValidatingEventHandler val = new DataGridViewCellValidatingEventHandler(adgvDetail_CellValidating);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvDetail_CellEnter);
			AsInputDGV.SetDependentFieldsWhenCellValueChangedHandler obj = adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged;
			DataGridViewCellEventHandler val3 = new DataGridViewCellEventHandler(adgvDetail_CellValueChanged);
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellValidating -= val;
				((DataGridView)_adgvDetail).CellEnter -= val2;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged -= obj;
				((DataGridView)_adgvDetail).CellValueChanged -= val3;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellValidating += val;
				((DataGridView)_adgvDetail).CellEnter += val2;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged += obj;
				((DataGridView)_adgvDetail).CellValueChanged += val3;
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

	internal virtual AsCheckBox chkGia_dd
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkGia_dd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkGia_dd = value;
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

	internal virtual Label lblTen_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Kh = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_vt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_vt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDvt = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_kho = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTon
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTon = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcSo_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_luong = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcGia_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcGia_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcGia_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcSo_ky
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_ky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_ky = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_no = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_cp = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk_vt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcGia
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcGia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcGia = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_bpsd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_bpsd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_bpsd = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_lo = value;
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

	public frmInVchIN5()
	{
		__ENCAddToList(this);
		f_sGia = "";
		f_sTien = "";
		InitializeComponent();
	}

	public frmInVchIN5(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_sGia = "";
		f_sTien = "";
		InitializeComponent();
	}

	public frmInVchIN5(string MenuID, string Stt_rec)
		: base(MenuID, Stt_rec)
	{
		__ENCAddToList(this);
		f_sGia = "";
		f_sTien = "";
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
		//IL_001c: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected O, but got Unknown
		//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee1: Expected O, but got Unknown
		//IL_0f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa4: Expected O, but got Unknown
		//IL_218f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2199: Expected O, but got Unknown
		//IL_2286: Unknown result type (might be due to invalid IL or missing references)
		//IL_2290: Expected O, but got Unknown
		//IL_234a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2354: Expected O, but got Unknown
		//IL_2623: Unknown result type (might be due to invalid IL or missing references)
		//IL_262d: Expected O, but got Unknown
		//IL_271a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2724: Expected O, but got Unknown
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
		txtMa_Kh = new AsTextBox();
		lblTen_Kh = new Label();
		lblMa_Kh = new Label();
		lblNguoi_Gd = new Label();
		txtDien_giai = new TextBox();
		txtNguoi_Gd = new TextBox();
		lblDien_giai = new Label();
		lblDia_chi = new Label();
		adgvDetail = new AsInputDGV();
		dgvcMa_vt = new DataGridViewAsTextBoxColumn();
		dgvcTen_vt = new DataGridViewTextBoxColumn();
		dgvcDvt = new DataGridViewTextBoxColumn();
		dgvcMa_kho = new DataGridViewAsTextBoxColumn();
		dgvcTon = new DataGridViewAsTextNumericColumn();
		dgvcSo_luong = new DataGridViewAsTextNumericColumn();
		dgvcGia_nt = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt = new DataGridViewAsTextNumericColumn();
		dgvcSo_ky = new DataGridViewAsTextNumericColumn();
		dgvcTk_no = new DataGridViewAsTextBoxColumn();
		dgvcTk_cp = new DataGridViewAsTextBoxColumn();
		dgvcTk_vt = new DataGridViewAsTextBoxColumn();
		dgvcGia = new DataGridViewAsTextNumericColumn();
		dgvcTien = new DataGridViewAsTextNumericColumn();
		dgvcMa_bpsd = new DataGridViewAsTextBoxColumn();
		dgvcMa_spct = new DataGridViewAsTextBoxColumn();
		dgvcMa_phi = new DataGridViewAsTextBoxColumn();
		dgvcMa_bp = new DataGridViewAsTextBoxColumn();
		dgvcMa_lo = new DataGridViewAsTextBoxColumn();
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
		chkGia_dd = new AsCheckBox();
		txtT_So_luong = new AsTextNumeric();
		Label5 = new Label();
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
		((Control)this).SuspendLayout();
		Button obj = cmdAdd;
		Point location = new Point(9, 428);
		((Control)obj).Location = location;
		Button obj2 = cmdPrint;
		location = new Point(79, 428);
		((Control)obj2).Location = location;
		Button obj3 = cmdLast;
		location = new Point(719, 428);
		((Control)obj3).Location = location;
		Button obj4 = cmdNext;
		location = new Point(694, 428);
		((Control)obj4).Location = location;
		Button obj5 = cmdPrevious;
		location = new Point(669, 428);
		((Control)obj5).Location = location;
		Button obj6 = cmdFirst;
		location = new Point(644, 428);
		((Control)obj6).Location = location;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(544, 43);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct;
		Size size = new Size(72, 13);
		((Control)obj8).Size = size;
		lblSo_Ct.Text = "Số phiếu xuất";
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		Label obj9 = lblNgay_Ct;
		location = new Point(544, 17);
		((Control)obj9).Location = location;
		Label obj10 = lblNgay_Ct;
		size = new Size(84, 13);
		((Control)obj10).Size = size;
		lblNgay_Ct.Text = "Ngày phiếu xuất";
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		TextBox obj11 = txtSo_Ct;
		location = new Point(649, 39);
		((Control)obj11).Location = location;
		((Control)txtSo_Ct).TabIndex = 6;
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)5;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(649, 13);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay_Ct).TabIndex = 5;
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Kh);
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
		GroupBox obj12 = gbPH;
		location = new Point(9, 4);
		((Control)obj12).Location = location;
		GroupBox obj13 = gbPH;
		size = new Size(733, 135);
		((Control)obj13).Size = size;
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
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(563, 428);
		((Control)splitButton).Location = location;
		AsTabControl asTabControl = AsTabControl;
		location = new Point(7, 142);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(739, 260);
		((Control)asTabControl2).Size = size;
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj14 = tabDetail;
		size = new Size(731, 231);
		((Control)obj14).Size = size;
		TabPage obj15 = tabOptFields;
		size = new Size(731, 231);
		((Control)obj15).Size = size;
		Button obj16 = cmdCopy;
		location = new Point(289, 428);
		((Control)obj16).Location = location;
		Button obj17 = cmdDelete;
		location = new Point(219, 428);
		((Control)obj17).Location = location;
		Button obj18 = cmdEdit;
		location = new Point(149, 428);
		((Control)obj18).Location = location;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(109, 13);
		((Control)asTextBox).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		txtMa_Kh.SD = true;
		AsTextBox asTextBox2 = txtMa_Kh;
		size = new Size(75, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Kh).TabIndex = 0;
		txtMa_Kh.UseAutoCompleteSource = true;
		txtMa_Kh.ValidReturnFieldList = "ten_kh,dia_chi,ma_so_thue,nguoi_gd,tel";
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj19 = lblTen_Kh;
		location = new Point(188, 17);
		((Control)obj19).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj20 = lblTen_Kh;
		size = new Size(333, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_Kh).TabIndex = 253;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj21 = lblMa_Kh;
		location = new Point(9, 17);
		((Control)obj21).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj22 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj22).Size = size;
		((Control)lblMa_Kh).TabIndex = 139;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj23 = lblNguoi_Gd;
		location = new Point(9, 68);
		((Control)obj23).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj24 = lblNguoi_Gd;
		size = new Size(94, 14);
		((Control)obj24).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 143;
		lblNguoi_Gd.Text = "Người giao dịch";
		TextBox obj25 = txtDien_giai;
		location = new Point(109, 91);
		((Control)obj25).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj26 = txtDien_giai;
		size = new Size(412, 20);
		((Control)obj26).Size = size;
		((Control)txtDien_giai).TabIndex = 4;
		TextBox obj27 = txtNguoi_Gd;
		location = new Point(109, 65);
		((Control)obj27).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj28 = txtNguoi_Gd;
		size = new Size(145, 20);
		((Control)obj28).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 3;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj29 = lblDien_giai;
		location = new Point(9, 94);
		((Control)obj29).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj30 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj30).Size = size;
		((Control)lblDien_giai).TabIndex = 144;
		lblDien_giai.Text = "Diễn giải";
		lblDia_chi.AutoSize = true;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj31 = lblDia_chi;
		location = new Point(9, 42);
		((Control)obj31).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj32 = lblDia_chi;
		size = new Size(40, 13);
		((Control)obj32).Size = size;
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
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[19]
		{
			dgvcMa_vt,
			(DataGridViewColumn)dgvcTen_vt,
			(DataGridViewColumn)dgvcDvt,
			dgvcMa_kho,
			dgvcTon,
			dgvcSo_luong,
			dgvcGia_nt,
			dgvcTien_nt,
			dgvcSo_ky,
			dgvcTk_no,
			dgvcTk_cp,
			dgvcTk_vt,
			dgvcGia,
			dgvcTien,
			dgvcMa_bpsd,
			dgvcMa_spct,
			dgvcMa_phi,
			dgvcMa_bp,
			dgvcMa_lo
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
		((DataGridView)adgvDetail).GridColor = SystemColors.Control;
		adgvDetail.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV = adgvDetail;
		location = new Point(3, 3);
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
		size = new Size(725, 225);
		((Control)asInputDGV2).Size = size;
		((Control)adgvDetail).TabIndex = 1;
		dgvcMa_vt.AutoFill = true;
		dgvcMa_vt.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_vt).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_vt.AutoValid = true;
		((DataGridViewColumn)dgvcMa_vt).DataPropertyName = "ma_vt";
		val4.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_vt).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcMa_vt).HeaderText = "Mã cc";
		dgvcMa_vt.LookupCodeName = "MA_VT";
		dgvcMa_vt.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_vt).Name = "dgvcMa_vt";
		dgvcMa_vt.ReceiverValidFieldList = "ten_vt,dvt,tk_vt,gia_ton";
		dgvcMa_vt.SD = true;
		dgvcMa_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_vt.ValidReturnFieldList = "ten_vt,dvt,tk_vt,gia_ton,ma_kho,ma_vitri";
		((DataGridViewColumn)dgvcMa_vt).Width = 43;
		((DataGridViewColumn)dgvcTen_vt).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vt).HeaderText = "Tên công cụ";
		dgvcTen_vt.MaxInputLength = 128;
		((DataGridViewColumn)dgvcTen_vt).Name = "dgvcTen_vt";
		((DataGridViewColumn)dgvcTen_vt).Resizable = (DataGridViewTriState)1;
		dgvcTen_vt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_vt).Width = 160;
		((DataGridViewColumn)dgvcDvt).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcDvt).DataPropertyName = "dvt";
		((DataGridViewColumn)dgvcDvt).HeaderText = "Đvt";
		((DataGridViewColumn)dgvcDvt).Name = "dgvcDvt";
		((DataGridViewColumn)dgvcDvt).ReadOnly = true;
		((DataGridViewColumn)dgvcDvt).Width = 49;
		dgvcMa_kho.AutoFill = true;
		dgvcMa_kho.AutoLookup = true;
		dgvcMa_kho.AutoValid = true;
		((DataGridViewColumn)dgvcMa_kho).DataPropertyName = "ma_kho";
		val5.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_kho).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcMa_kho).HeaderText = "Kho";
		dgvcMa_kho.LookupCodeName = "MA_KHO";
		dgvcMa_kho.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_kho).Name = "dgvcMa_kho";
		dgvcMa_kho.ReceiverValidFieldList = "ten_kho";
		dgvcMa_kho.SD = true;
		dgvcMa_kho.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_kho.ValidReturnFieldList = "ten_kho";
		((DataGridViewColumn)dgvcMa_kho).Width = 65;
		((DataGridViewColumn)dgvcTon).DataPropertyName = "ton";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ###";
		((DataGridViewColumn)dgvcTon).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcTon).HeaderText = "Tồn";
		dgvcTon.Mask = "### ### ###";
		((DataGridViewColumn)dgvcTon).Name = "dgvcTon";
		((DataGridViewColumn)dgvcTon).ReadOnly = true;
		dgvcTon.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTon.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcTon).Width = 50;
		((DataGridViewColumn)dgvcSo_luong).DataPropertyName = "so_luong";
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcSo_luong).HeaderText = "Số lượng";
		dgvcSo_luong.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).Name = "dgvcSo_luong";
		dgvcSo_luong.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSo_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcSo_luong).Width = 70;
		((DataGridViewColumn)dgvcGia_nt).DataPropertyName = "gia_nt";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcGia_nt).HeaderText = "Giá";
		dgvcGia_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia_nt).Name = "dgvcGia_nt";
		((DataGridViewColumn)dgvcGia_nt).ReadOnly = true;
		dgvcGia_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia_nt.SpecialType = Commons.NumericSpecialType.FCPrice;
		((DataGridViewColumn)dgvcGia_nt).Width = 80;
		((DataGridViewColumn)dgvcTien_nt).DataPropertyName = "tien_nt";
		val9.Alignment = (DataGridViewContentAlignment)64;
		val9.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcTien_nt).HeaderText = "Thành tiền";
		dgvcTien_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_nt).Name = "dgvcTien_nt";
		((DataGridViewColumn)dgvcTien_nt).ReadOnly = true;
		dgvcTien_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcSo_ky).DataPropertyName = "so_ky";
		val10.Alignment = (DataGridViewContentAlignment)64;
		val10.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcSo_ky).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcSo_ky).HeaderText = "Số kỳ PB";
		dgvcSo_ky.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcSo_ky).Name = "dgvcSo_ky";
		dgvcSo_ky.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcSo_ky).Width = 75;
		dgvcTk_no.AutoFill = true;
		dgvcTk_no.AutoLookup = true;
		dgvcTk_no.AutoValid = true;
		((DataGridViewColumn)dgvcTk_no).DataPropertyName = "tk_no";
		val11.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_no).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcTk_no).HeaderText = "Tk pb";
		dgvcTk_no.LookupCodeName = "TK";
		dgvcTk_no.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_no).Name = "dgvcTk_no";
		dgvcTk_no.ReceiverValidFieldList = "ten_tk_no";
		dgvcTk_no.SD = true;
		dgvcTk_no.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTk_no).ToolTipText = "Tài khoản chờ phân bổ (tk nợ)";
		dgvcTk_no.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_no).Width = 70;
		dgvcTk_cp.AutoFill = true;
		dgvcTk_cp.AutoLookup = true;
		dgvcTk_cp.AutoValid = true;
		((DataGridViewColumn)dgvcTk_cp).DataPropertyName = "tk_cp";
		val12.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_cp).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcTk_cp).HeaderText = "Tk cp";
		dgvcTk_cp.LookupCodeName = "TK";
		dgvcTk_cp.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_cp).Name = "dgvcTk_cp";
		dgvcTk_cp.ReceiverValidFieldList = "";
		dgvcTk_cp.SD = true;
		dgvcTk_cp.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTk_cp).ToolTipText = "Tài khoản chi phí ";
		dgvcTk_cp.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcTk_cp).Width = 70;
		dgvcTk_vt.AutoFill = true;
		dgvcTk_vt.AutoLookup = true;
		dgvcTk_vt.AutoValid = true;
		((DataGridViewColumn)dgvcTk_vt).DataPropertyName = "tk_vt";
		val13.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_vt).DefaultCellStyle = val13;
		((DataGridViewColumn)dgvcTk_vt).HeaderText = "Tk Cc";
		dgvcTk_vt.LookupCodeName = "TK";
		dgvcTk_vt.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_vt).Name = "dgvcTk_vt";
		dgvcTk_vt.ReceiverValidFieldList = "ten_tk_vt";
		dgvcTk_vt.SD = true;
		dgvcTk_vt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTk_vt).ToolTipText = "Tài khoản công cụ";
		dgvcTk_vt.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_vt).Width = 70;
		((DataGridViewColumn)dgvcGia).DataPropertyName = "gia";
		val14.Alignment = (DataGridViewContentAlignment)64;
		val14.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia).DefaultCellStyle = val14;
		((DataGridViewColumn)dgvcGia).HeaderText = "Giá VND";
		dgvcGia.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia).Name = "dgvcGia";
		((DataGridViewColumn)dgvcGia).ReadOnly = true;
		dgvcGia.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia.SpecialType = Commons.NumericSpecialType.ACPrice;
		((DataGridViewColumn)dgvcGia).Width = 80;
		((DataGridViewColumn)dgvcTien).DataPropertyName = "tien";
		val15.Alignment = (DataGridViewContentAlignment)64;
		val15.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien).DefaultCellStyle = val15;
		((DataGridViewColumn)dgvcTien).HeaderText = "Tiền VND";
		dgvcTien.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien).Name = "dgvcTien";
		((DataGridViewColumn)dgvcTien).ReadOnly = true;
		dgvcTien.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien).Width = 80;
		dgvcMa_bpsd.AutoFill = true;
		dgvcMa_bpsd.AutoLookup = true;
		dgvcMa_bpsd.AutoValid = true;
		((DataGridViewColumn)dgvcMa_bpsd).DataPropertyName = "ma_bpsd";
		val16.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_bpsd).DefaultCellStyle = val16;
		((DataGridViewColumn)dgvcMa_bpsd).HeaderText = "Bpsd";
		dgvcMa_bpsd.LookupCodeName = "MA_BPSD";
		dgvcMa_bpsd.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_bpsd).Name = "dgvcMa_bpsd";
		dgvcMa_bpsd.ReceiverValidFieldList = "ten_bpsd";
		dgvcMa_bpsd.SD = true;
		dgvcMa_bpsd.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_bpsd).ToolTipText = "Bộ phận sử dụng công cụ";
		dgvcMa_bpsd.ValidReturnFieldList = "ten_bpsd";
		((DataGridViewColumn)dgvcMa_bpsd).Width = 70;
		dgvcMa_spct.AutoFill = true;
		dgvcMa_spct.AutoLookup = true;
		dgvcMa_spct.AutoValid = true;
		((DataGridViewColumn)dgvcMa_spct).DataPropertyName = "ma_spct";
		val17.BackColor = SystemColors.Info;
		val17.NullValue = null;
		((DataGridViewColumn)dgvcMa_spct).DefaultCellStyle = val17;
		((DataGridViewColumn)dgvcMa_spct).HeaderText = "SPCT";
		dgvcMa_spct.LookupCodeName = "MA_SPCT";
		dgvcMa_spct.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_spct).Name = "dgvcMa_spct";
		dgvcMa_spct.ReceiverValidFieldList = "ten_spct";
		dgvcMa_spct.SD = true;
		dgvcMa_spct.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_spct.ValidReturnFieldList = "ten_spct";
		((DataGridViewColumn)dgvcMa_spct).Width = 70;
		dgvcMa_phi.AutoFill = true;
		dgvcMa_phi.AutoLookup = true;
		dgvcMa_phi.AutoValid = true;
		((DataGridViewColumn)dgvcMa_phi).DataPropertyName = "ma_phi";
		val18.BackColor = SystemColors.Info;
		val18.NullValue = null;
		((DataGridViewColumn)dgvcMa_phi).DefaultCellStyle = val18;
		((DataGridViewColumn)dgvcMa_phi).HeaderText = "Phí";
		dgvcMa_phi.LookupCodeName = "MA_PHI";
		dgvcMa_phi.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_phi).Name = "dgvcMa_phi";
		dgvcMa_phi.ReceiverValidFieldList = "ten_phi";
		dgvcMa_phi.SD = true;
		dgvcMa_phi.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_phi.ValidReturnFieldList = "ten_phi";
		((DataGridViewColumn)dgvcMa_phi).Width = 70;
		dgvcMa_bp.AutoFill = true;
		dgvcMa_bp.AutoLookup = true;
		dgvcMa_bp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_bp).DataPropertyName = "ma_bp";
		val19.BackColor = SystemColors.Info;
		val19.NullValue = null;
		((DataGridViewColumn)dgvcMa_bp).DefaultCellStyle = val19;
		((DataGridViewColumn)dgvcMa_bp).HeaderText = "Bộ phận";
		dgvcMa_bp.LookupCodeName = "MA_BP";
		dgvcMa_bp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_bp).Name = "dgvcMa_bp";
		dgvcMa_bp.ReceiverValidFieldList = "ten_bp";
		dgvcMa_bp.SD = true;
		dgvcMa_bp.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_bp).ToolTipText = "Mã bộ phận hạch toán";
		dgvcMa_bp.ValidReturnFieldList = "ten_bp";
		((DataGridViewColumn)dgvcMa_bp).Width = 70;
		dgvcMa_lo.AutoFill = true;
		dgvcMa_lo.AutoLookup = true;
		dgvcMa_lo.AutoValid = true;
		((DataGridViewColumn)dgvcMa_lo).DataPropertyName = "ma_lo";
		val20.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_lo).DefaultCellStyle = val20;
		((DataGridViewColumn)dgvcMa_lo).HeaderText = "Lô";
		dgvcMa_lo.LookupCodeName = "MA_LO";
		dgvcMa_lo.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_lo).Name = "dgvcMa_lo";
		dgvcMa_lo.ReceiverValidFieldList = "ten_lo";
		dgvcMa_lo.SD = true;
		dgvcMa_lo.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_lo.ValidReturnFieldList = "ten_lo";
		((DataGridViewColumn)dgvcMa_lo).Width = 70;
		txtNgay_lct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_lct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_lct;
		location = new Point(649, 65);
		((Control)asMaskedTextBox2).Location = location;
		((MaskedTextBox)txtNgay_lct).Mask = "##/##/####";
		((Control)txtNgay_lct).Name = "txtNgay_lct";
		((MaskedTextBox)txtNgay_lct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_lct;
		size = new Size(78, 20);
		((Control)asMaskedTextBox3).Size = size;
		((Control)txtNgay_lct).TabIndex = 7;
		((MaskedTextBox)txtNgay_lct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_lct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox4.Value = dateTime;
		lblNgay_Lct.ImeMode = (ImeMode)0;
		Label obj33 = lblNgay_Lct;
		location = new Point(544, 68);
		((Control)obj33).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj34 = lblNgay_Lct;
		size = new Size(56, 15);
		((Control)obj34).Size = size;
		((Control)lblNgay_Lct).TabIndex = 234;
		lblNgay_Lct.Text = "Ngày lập";
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(658, 91);
		((Control)asTextNumeric).Location = location;
		txtTy_gia.Mask = "### ###.##";
		((Control)txtTy_gia).Name = "txtTy_gia";
		AsTextNumeric asTextNumeric2 = txtTy_gia;
		size = new Size(69, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTy_gia).TabIndex = 9;
		((TextBox)txtTy_gia).Text = "0.00";
		((TextBox)txtTy_gia).TextAlign = (HorizontalAlignment)1;
		txtTy_gia.Value = 0.0;
		((ComboBox)cboMa_NT).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboMa_NT).Enabled = false;
		((ListControl)cboMa_NT).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_NT;
		location = new Point(608, 91);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(47, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 8;
		lblMa_Nt.AutoSize = true;
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj35 = lblMa_Nt;
		location = new Point(544, 95);
		((Control)obj35).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj36 = lblMa_Nt;
		size = new Size(36, 13);
		((Control)obj36).Size = size;
		((Control)lblMa_Nt).TabIndex = 237;
		lblMa_Nt.Text = "Tỷ giá";
		((Control)txtT_Tien).Anchor = (AnchorStyles)6;
		txtT_Tien.DecimalSymbol = ".";
		((Control)txtT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtT_Tien;
		location = new Point(642, 402);
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
		((Control)lblT_Tien).Anchor = (AnchorStyles)6;
		((Control)lblT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Tien.ImeMode = (ImeMode)0;
		Label obj37 = lblT_Tien;
		location = new Point(425, 405);
		((Control)obj37).Location = location;
		((Control)lblT_Tien).Name = "lblT_Tien";
		Label obj38 = lblT_Tien;
		size = new Size(105, 13);
		((Control)obj38).Size = size;
		((Control)lblT_Tien).TabIndex = 228;
		lblT_Tien.Text = "Tiền xuất";
		lblT_Tien.TextAlign = (ContentAlignment)16;
		((Control)txtT_Tien_nt).Anchor = (AnchorStyles)6;
		txtT_Tien_nt.DecimalSymbol = ".";
		((Control)txtT_Tien_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric5 = txtT_Tien_nt;
		location = new Point(536, 402);
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
		TextBox obj39 = txtDia_chi;
		location = new Point(109, 39);
		((Control)obj39).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj40 = txtDia_chi;
		size = new Size(412, 20);
		((Control)obj40).Size = size;
		((Control)txtDia_chi).TabIndex = 2;
		((Control)chkGia_dd).Anchor = (AnchorStyles)6;
		chkGia_dd.Checked = false;
		AsCheckBox asCheckBox = chkGia_dd;
		location = new Point(9, 404);
		((Control)asCheckBox).Location = location;
		((Control)chkGia_dd).Name = "chkGia_dd";
		AsCheckBox asCheckBox2 = chkGia_dd;
		size = new Size(162, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkGia_dd).TabIndex = 255;
		((Control)chkGia_dd).TabStop = false;
		((ButtonBase)chkGia_dd).Text = "Phiếu xuất giá đích danh";
		chkGia_dd.TextValue = "0";
		((ButtonBase)chkGia_dd).UseVisualStyleBackColor = true;
		((Control)txtT_So_luong).Anchor = (AnchorStyles)6;
		txtT_So_luong.DecimalSymbol = ".";
		((Control)txtT_So_luong).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric7 = txtT_So_luong;
		location = new Point(302, 402);
		((Control)asTextNumeric7).Location = location;
		txtT_So_luong.Mask = "### ### ### ###";
		((Control)txtT_So_luong).Name = "txtT_So_luong";
		((TextBoxBase)txtT_So_luong).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_So_luong;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_So_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((Control)txtT_So_luong).TabIndex = 262;
		((Control)txtT_So_luong).TabStop = false;
		((TextBox)txtT_So_luong).Text = "0";
		((TextBox)txtT_So_luong).TextAlign = (HorizontalAlignment)1;
		txtT_So_luong.Value = 0.0;
		((Control)Label5).Anchor = (AnchorStyles)6;
		((Control)Label5).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label5.ImeMode = (ImeMode)0;
		Label label = Label5;
		location = new Point(210, 405);
		((Control)label).Location = location;
		((Control)Label5).Name = "Label5";
		Label label2 = Label5;
		size = new Size(86, 13);
		((Control)label2).Size = size;
		((Control)Label5).TabIndex = 261;
		Label5.Text = "Số lượng";
		Label5.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(751, 476);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)chkGia_dd);
		((Control)this).Controls.Add((Control)(object)txtT_So_luong);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)txtT_Tien);
		((Control)this).Controls.Add((Control)(object)lblT_Tien);
		((Control)this).Controls.Add((Control)(object)txtT_Tien_nt);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmInVchIN5";
		((Form)this).Text = "frmInVchIN5";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_So_luong, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkGia_dd, 0);
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
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
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
			txtDia_chi.Text = Conversions.ToString(e.ValidatedRow["dia_chi"]);
			txtNguoi_Gd.Text = Conversions.ToString(e.ValidatedRow["nguoi_gd"]);
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
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcSo_luong).Name, false) == 0)
			{
				V_So_Luong(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_nt).Name, false) == 0)
			{
				V_Gia_Nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt).Name, false) == 0)
			{
				V_Tien_nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia).Name, false) == 0)
			{
				V_Gia(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien).Name, false) == 0)
			{
				V_tien(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_vt).Name, false) == 0)
			{
				V_Ma_Vt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kho).Name, false) == 0)
			{
				V_Ma_Kho(oDv);
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
		if (CTTable != null && !base.IsLoading && 0 == 0)
		{
			DataRowView dataRowView = CT1Voucher[e.RowIndex];
			object obj = null;
			DataGridViewCell currentCell = ((DataGridView)adgvDetail).CurrentCell;
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien_Nt(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Tien(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia_nt).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Gia_Nt(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia).Name, false) == 0)
			{
				currentCell.ReadOnly = !W_Gia(dataRowView);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kho).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["ten_kho"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_bp).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Bp"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_bpsd).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_BpSd"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_phi).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Phi"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_spct).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Spct"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_vt).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_vt"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_no).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_no"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_cp).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_cp"]);
			}
			obj = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(obj), isNum: false));
			((ToolStripItem)tsslInfo).Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(obj, (object)"", false), (object)frmVoucher.BASEVOUCHER_INPUTGRID_TIP_TEXT, RuntimeHelpers.GetObjectValue(obj)));
		}
	}

	private void adgvDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
	{
		if ((ActionMode == Commons.ApplicationMode.VIEW_MODE || CTTable == null || e.RowIndex < 0 || base.IsLoading) ? true : false)
		{
			return;
		}
		DataRowView dataRowView = CT1Voucher[e.RowIndex];
		string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
		if (Operators.CompareString(name, ((DataGridViewColumn)dgvcSo_luong).Name, false) == 0 && ((Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_kho"]), isNum: false), (object)"", false) && ActionMode == Commons.ApplicationMode.ADD_MODE) ? true : false))
		{
			double result = 0.0;
			if (double.TryParse(e.FormattedValue.ToString(), out result) && Operators.ConditionalCompareObjectGreater((object)result, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ton"]), isNum: true), false))
			{
				((CancelEventArgs)(object)e).Cancel = !Commons.ProcessLackOfInventory2Issue();
			}
		}
	}

	private void adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged(object sender, SetDependentFieldsWhenCellValueChangedEventArgs e)
	{
		if ((!base.MyVoucherInfo.ct_carry_field_list.ToUpper().Contains("MA_KHO") || ((DataGridViewCellEventArgs)e).RowIndex <= 0) && 0 == 0 && ((e.ValidatedRow != null && ((DataGridView)adgvDetail).Columns[((DataGridViewCellEventArgs)e).ColumnIndex].Name.Equals(((DataGridViewColumn)dgvcMa_vt).Name) && dgvcMa_vt.ValidReturnFieldList.Contains("ma_kho") && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_kho"]), isNum: false), (object)"", false)) ? true : false))
		{
			CurrentCTRowView["ma_kho"] = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_kho"]);
			CurrentCTRowView["ma_vitri"] = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_vitri"]);
			((DataGridView)dgvDetail).AutoResizeColumn(((DataGridViewBand)dgvcMa_kho).Index);
			DataRow pDrw = null;
			if (Commons.ValidMa(ref pDrw, "MA_KHO", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentCTRowView["ma_kho"]), isNum: false)), "", "kho_dl,tk_dl", pSd: true) && ((Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)true, false) && Operators.ConditionalCompareObjectNotEqual(pDrw["tk_dl"], (object)"", false)) ? true : false))
			{
				CurrentCTRowView["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["tk_dl"]);
			}
		}
	}

	private bool W_Tien_Nt(DataRowView oDv)
	{
		return Conversions.ToBoolean((Conversions.ToBoolean(chkGia_dd.Checked) || Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia_ton"]), isNum: false), (object)"4", false))) ? ((object)true) : ((object)false));
	}

	private bool W_Gia_Nt(DataRowView oDv)
	{
		return Conversions.ToBoolean((Conversions.ToBoolean(chkGia_dd.Checked) || Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia_ton"]), isNum: false), (object)"4", false))) ? ((object)true) : ((object)false));
	}

	private bool W_Tien(DataRowView oDv)
	{
		return Conversions.ToBoolean((Conversions.ToBoolean(chkGia_dd.Checked) || Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia_ton"]), isNum: false), (object)"4", false))) ? ((object)true) : ((object)false));
	}

	private bool W_Gia(DataRowView oDv)
	{
		return Conversions.ToBoolean((Conversions.ToBoolean(chkGia_dd.Checked) || Conversions.ToBoolean(Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["gia_ton"]), isNum: false), (object)"4", false))) ? ((object)true) : ((object)false));
	}

	private void V_Ma_Vt(DataRowView oDv)
	{
		ReCalcTonKhoTucThoi(oDv);
	}

	private void V_Ma_Kho(DataRowView oDv)
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

	private void V_So_Luong(DataRowView oDv)
	{
		Calc_TienVon(oDv);
		Calc_So_luong_qd(oDv);
		UpdateList();
	}

	private void V_Gia_Nt(DataRowView oDv)
	{
		Calc_GiaVon(oDv);
		Calc_TienVon(oDv);
		UpdateList();
	}

	private void V_Gia(DataRowView oDv)
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
		UpdateList();
	}

	private void V_Tien_nt(DataRowView oDv)
	{
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true)),
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
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle2 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)),
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
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			object[] array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true), (object)0, false)) ? true : false)
		{
			int num = AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia_Nt;
			if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				num = AsiaErp.Framework.Environment.GetSIConfiguration().Round_Gia;
			}
			Type? typeFromHandle4 = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
				num,
				MidpointRounding.AwayFromZero
			};
			object[] array10 = array;
			bool[] array5 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["Gia_Nt"] = RuntimeHelpers.GetObjectValue(obj4);
			if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
			{
				Type? typeFromHandle5 = typeof(Math);
				object[] array3 = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), txtTy_gia.Value),
					null,
					null
				};
				object[] array11 = array3;
				SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array11[1] = sIConfiguration.Round_Gia;
				array3[2] = MidpointRounding.AwayFromZero;
				array = array3;
				object[] array12 = array;
				array5 = new bool[3] { false, true, false };
				object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle5, "Round", array12, (string[])null, (Type[])null, array5);
				if (array5[1])
				{
					sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				oDv["Gia"] = RuntimeHelpers.GetObjectValue(obj5);
			}
			else
			{
				Type? typeFromHandle6 = typeof(Math);
				array = new object[3]
				{
					Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_luong"]), isNum: true)),
					num,
					MidpointRounding.AwayFromZero
				};
				object[] array13 = array;
				array5 = new bool[3] { false, true, false };
				object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle6, "Round", array13, (string[])null, (Type[])null, array5);
				if (array5[1])
				{
					num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				oDv["Gia_"] = RuntimeHelpers.GetObjectValue(obj6);
			}
		}
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

	private void Calc_GiaVon(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTy_gia.Value), isNum: true)),
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

	private void Calc_TienVon(DataRowView oDv)
	{
		if (!Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true)), (object)0, false))
		{
			return;
		}
		int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		Type? typeFromHandle = typeof(Math);
		object[] array = new object[3]
		{
			Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia_Nt"]), isNum: true)),
			num,
			MidpointRounding.AwayFromZero
		};
		object[] array2 = array;
		bool[] array3 = new bool[3] { false, true, false };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
		if (array3[1])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		oDv["Tien_Nt"] = RuntimeHelpers.GetObjectValue(obj);
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			Type? typeFromHandle2 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array4 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array4[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array6 = array5;
			array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array6, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)), (object)0, false))
		{
			Type? typeFromHandle3 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Gia"]), isNum: true)),
				null,
				null
			};
			object[] array7 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array7[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array8 = array5;
			array3 = new bool[3] { false, true, false };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "Round", array8, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj3);
		}
		else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle4 = typeof(Math);
			array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["Tien_Nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			object[] array9 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array9[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array5 = array;
			object[] array10 = array5;
			array3 = new bool[3] { false, true, false };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "Round", array10, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(int));
			}
			oDv["Tien"] = RuntimeHelpers.GetObjectValue(obj4);
		}
	}

	private void Calc_So_luong_qd(DataRowView oDv)
	{
		oDv["so_luong_qd"] = RuntimeHelpers.GetObjectValue(oDv["so_luong"]);
	}

	private void ReCalcTonKhoTucThoi(DataRowView odv)
	{
		double num = default(double);
		double num2 = default(double);
		double num3 = default(double);
		double num4 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_vt"]), isNum: false), (object)"", false) || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_kho"]), isNum: false), (object)"", false) ? true : false))
		{
			num = 0.0;
			num2 = 0.0;
			num3 = 0.0;
			num4 = 0.0;
			num5 = 0.0;
			num6 = 0.0;
		}
		else
		{
			string aMa_Kho = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_kho"]), isNum: false));
			string aMa_Vt = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_vt"]), isNum: false));
			DateTime aNgay_Ct = Conversions.ToDate(txtNgay_Ct.Value);
			decimal aTon = new decimal(num);
			decimal aTon_all = new decimal(num2);
			decimal aTon_Mua = new decimal(num3);
			decimal aTon_Mua_all = new decimal(num4);
			decimal aTon_Ban = new decimal(num5);
			decimal aTon_Ban_all = new decimal(num6);
			Commons.Get_TonKhoAll(aMa_Kho, aMa_Vt, aNgay_Ct, ref aTon, ref aTon_all, ref aTon_Mua, ref aTon_Mua_all, ref aTon_Ban, ref aTon_Ban_all);
			num6 = Convert.ToDouble(aTon_Ban_all);
			num5 = Convert.ToDouble(aTon_Ban);
			num4 = Convert.ToDouble(aTon_Mua_all);
			num3 = Convert.ToDouble(aTon_Mua);
			num2 = Convert.ToDouble(aTon_all);
			num = Convert.ToDouble(aTon);
		}
		odv["Ton"] = num;
		odv["ton_All"] = num2;
		odv["Ton_mua"] = num3;
		odv["ton_mua_All"] = num4;
		odv["Ton_ban"] = num5;
		odv["ton_ban_All"] = num6;
	}

	private void V_Ty_Gia()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			foreach (DataGridViewRow item in (IEnumerable)((DataGridView)adgvDetail).Rows)
			{
				DataGridViewRow val = item;
				DataRowView dataRowView = base.CT1Voucher[((DataGridViewBand)val).Index];
				if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
				{
					Type? typeFromHandle = typeof(Math);
					object[] array = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["gia_nt"]), isNum: true)),
						null,
						null
					};
					object[] array2 = array;
					SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
					array2[1] = sIConfiguration.Round_Gia;
					array[2] = MidpointRounding.AwayFromZero;
					object[] array3 = array;
					object[] array4 = array3;
					bool[] array5 = new bool[3] { false, true, false };
					object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
					if (array5[1])
					{
						sIConfiguration.Round_Gia = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
					}
					dataRowView["gia"] = RuntimeHelpers.GetObjectValue(obj);
					Type? typeFromHandle2 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Nt"]), isNum: true)),
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
					dataRowView["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
					continue;
				}
				if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
				{
					Type? typeFromHandle3 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["gia_nt"]), isNum: true), txtTy_gia.Value),
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
					dataRowView["gia"] = RuntimeHelpers.GetObjectValue(obj3);
				}
				if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Gia"]), isNum: true)), (object)0, false))
				{
					Type? typeFromHandle4 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Gia"]), isNum: true)),
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
					dataRowView["Tien"] = RuntimeHelpers.GetObjectValue(obj4);
				}
				else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
				{
					Type? typeFromHandle5 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_nt"]), isNum: true), txtTy_gia.Value),
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
					dataRowView["Tien"] = RuntimeHelpers.GetObjectValue(obj5);
				}
			}
		}
		UpdateList();
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
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		AddControl2ListOfDrivedControls((Control)(object)chkGia_dd);
		f_sGia = ((DataGridViewColumn)dgvcGia_nt).HeaderText;
		f_sTien = ((DataGridViewColumn)dgvcTien_nt).HeaderText;
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_Tien_nt);
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
			((DataGridViewColumn)dgvcGia).Visible = false;
			((DataGridViewColumn)dgvcTien).Visible = false;
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
			((DataGridViewColumn)dgvcGia).Visible = true;
			((DataGridViewColumn)dgvcTien).Visible = true;
			((Control)txtT_Tien).Visible = true;
		}
		string mA_NT = cboMa_NT.MA_NT;
		((DataGridViewColumn)dgvcGia_nt).HeaderText = f_sGia + " " + mA_NT;
		((DataGridViewColumn)dgvcTien_nt).HeaderText = f_sTien + " " + mA_NT;
	}

	protected override void SetFocus4FirstEditControl()
	{
		((Control)txtMa_Kh).Focus();
	}

	protected override void UpdateList()
	{
		if (base.CurrentPHRow != null)
		{
			string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", base.CurrentPHRow["Stt_Rec"]), (object)"'"));
			txtT_Tien_nt.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien_nt)", filter));
			txtT_Tien.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(tien)", filter));
			txtT_So_luong.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(so_luong)", filter));
		}
	}

	protected override bool ValidData()
	{
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Invalid comparison between Unknown and I4
		//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Invalid comparison between Unknown and I4
		bool flag = true;
		bool flag2 = false;
		if ((ChkEmtyTextBox((TextBox)(object)txtMa_Kh) && base.ValidData()) ? true : false)
		{
			bool flag3 = true;
			bool flag4 = true;
			int num = checked(CT1Voucher.Count - 1);
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
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_no"]), isNum: false), (object)"", false))
				{
					return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTk_no).Name, num2], 50023);
				}
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_vt"]), isNum: false), (object)"", false))
				{
					return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTk_vt).Name, num2], 50023);
				}
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_cp"]), isNum: false), (object)"", false))
				{
					return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTk_cp).Name, num2], 50023);
				}
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Vt"]), isNum: false), (object)"", false))
				{
					return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_vt).Name, num2], 50062);
				}
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Kho"]), isNum: false), (object)"", false))
				{
					return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_kho).Name, num2], 50056);
				}
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["So_Luong"]), isNum: true), (object)0, false))
				{
					((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcSo_luong).Name, num2].ErrorText = Helper.GetMessContent(50037);
					flag3 = false;
				}
				if ((((int)((CheckBox)chkGia_dd).CheckState == 1 || Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["gia_ton"]), isNum: false), (object)"4", false)) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Nt"]), isNum: true), (object)0, false)) ? true : false)
				{
					((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcSo_luong).Name, num2].ErrorText = Helper.GetMessContent(50037);
					flag4 = false;
				}
				if ((((int)((CheckBox)chkGia_dd).CheckState == 1 || Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["gia_ton"]), isNum: false), (object)"4", false)) && Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tien"]), isNum: true), (object)0, false)) ? true : false)
				{
					return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien).Name, num2], 50037);
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
							dataRowView["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
						}
						if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tien"]), isNum: true), (object)num7) }, (string[])null, (Type[])null, (bool[])null), (object)num5, false))
						{
							((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien).Name, num2].ErrorText = Helper.GetMessContent(50047);
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
							((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_nt).Name, num2].ErrorText = Helper.GetMessContent(50047);
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
						double num9 = Conversions.ToDouble(obj4);
						if ((num9 != 0.0 && Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject((object)num9, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tien_Nt"]), isNum: true)) }, (string[])null, (Type[])null, (bool[])null), (object)num5, false)) ? true : false)
						{
							((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTien_nt).Name, num2].ErrorText = Helper.GetMessContent(50047);
							flag = flag5;
							flag2 = true;
						}
					}
				}
				num2 = checked(num2 + 1);
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
		CreateDataBinding((Control)(object)lblTen_Kh, "Ten_Kh");
		CreateDataBinding((Control)(object)txtDia_chi, "Dia_chi");
		CreateDataBinding((Control)(object)txtNguoi_Gd, "Nguoi_Gd");
		CreateDataBinding((Control)(object)txtDien_giai, "Dien_Giai");
		CreateDataBinding((Control)(object)txtNgay_Ct, "ngay_ct", "Value");
		CreateDataBinding((Control)(object)txtSo_Ct, "so_ct");
		CreateDataBinding((Control)(object)txtNgay_lct, "ngay_lct", "Value");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)chkGia_dd, "Px_gdd", "Checked");
		CreateDataBinding((Control)(object)txtT_Tien, "t_tien", "Value");
		CreateDataBinding((Control)(object)txtT_Tien_nt, "t_tien_nt", "Value");
		CreateDataBinding((Control)(object)txtT_So_luong, "t_so_luong", "Value");
	}

	protected override void SetPHDefaultValues(DataRow drwPh)
	{
		base.SetPHDefaultValues(drwPh);
		drwPh["ngay_lct"] = RuntimeHelpers.GetObjectValue(drwPh["ngay_ct"]);
		drwPh["ma_gd"] = "9";
	}

	protected override void SetReportFomularFields(DataRow odrPrintPHRow)
	{
		base.SetReportFomularFields(odrPrintPHRow);
		string text = "";
		string text2 = "";
		foreach (DataRowView item in CT1Voucher)
		{
			if (!text.Contains(Conversions.ToString(item["tk_no"])))
			{
				text = Conversions.ToString(Operators.AddObject((object)text, Interaction.IIf(Operators.CompareString(text, string.Empty, false) == 0, RuntimeHelpers.GetObjectValue(item["tk_no"]), Operators.AddObject((object)",", item["tk_no"]))));
			}
			if (!text2.Contains(Conversions.ToString(item["tk_vt"])))
			{
				text2 = Conversions.ToString(Operators.AddObject((object)text2, Interaction.IIf(Operators.CompareString(text2, string.Empty, false) == 0, RuntimeHelpers.GetObjectValue(item["tk_vt"]), Operators.AddObject((object)",", item["tk_vt"]))));
			}
		}
		base.MyFomularFields.Add("tk_no", text);
		base.MyFomularFields.Add("tk_co", text2);
	}
}
