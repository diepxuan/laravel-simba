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
public class frmInVchIN3 : frmVoucher
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

	[AccessedThroughProperty("txtSo_pn")]
	private TextBox _txtSo_pn;

	[AccessedThroughProperty("lblSo_pn")]
	private Label _lblSo_pn;

	[AccessedThroughProperty("lblT_Tien")]
	private Label _lblT_Tien;

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

	[AccessedThroughProperty("dgvcMa_khox")]
	private DataGridViewAsTextBoxColumn _dgvcMa_khox;

	[AccessedThroughProperty("dgvcMa_khon")]
	private DataGridViewAsTextBoxColumn _dgvcMa_khon;

	[AccessedThroughProperty("dgvcSo_luong")]
	private DataGridViewAsTextNumericColumn _dgvcSo_luong;

	[AccessedThroughProperty("dgvcGia_nt")]
	private DataGridViewAsTextNumericColumn _dgvcGia_nt;

	[AccessedThroughProperty("dgvcTien_nt")]
	private DataGridViewAsTextNumericColumn _dgvcTien_nt;

	[AccessedThroughProperty("dgvcTk_no")]
	private DataGridViewAsTextBoxColumn _dgvcTk_no;

	[AccessedThroughProperty("dgvcTk_vt")]
	private DataGridViewAsTextBoxColumn _dgvcTk_vt;

	[AccessedThroughProperty("dgvcGia")]
	private DataGridViewAsTextNumericColumn _dgvcGia;

	[AccessedThroughProperty("dgvcTien")]
	private DataGridViewAsTextNumericColumn _dgvcTien;

	[AccessedThroughProperty("dgvcMa_spct")]
	private DataGridViewAsTextBoxColumn _dgvcMa_spct;

	[AccessedThroughProperty("dgvcMa_hd")]
	private DataGridViewAsTextBoxColumn _dgvcMa_hd;

	[AccessedThroughProperty("dgvcMa_phi")]
	private DataGridViewAsTextBoxColumn _dgvcMa_phi;

	[AccessedThroughProperty("dgvcMa_bp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_bp;

	[AccessedThroughProperty("dgvcMa_Lo")]
	private DataGridViewAsTextBoxColumn _dgvcMa_Lo;

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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvDetail_CellValueChanged);
			AsInputDGV.SetDependentFieldsWhenCellValueChangedHandler obj = adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged;
			DataGridViewCellValidatingEventHandler val2 = new DataGridViewCellValidatingEventHandler(adgvDetail_CellValidating);
			DataGridViewCellEventHandler val3 = new DataGridViewCellEventHandler(adgvDetail_CellEnter);
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellValueChanged -= val;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged -= obj;
				((DataGridView)_adgvDetail).CellValidating -= val2;
				((DataGridView)_adgvDetail).CellEnter -= val3;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellValueChanged += val;
				_adgvDetail.BeforeSetDependentFieldsWhenCellValueChanged += obj;
				((DataGridView)_adgvDetail).CellValidating += val2;
				((DataGridView)_adgvDetail).CellEnter += val3;
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

	internal virtual TextBox txtSo_pn
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_pn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_pn = value;
		}
	}

	internal virtual Label lblSo_pn
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_pn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_pn = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_khox
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_khox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_khox = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_khon
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_khon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_khon = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_Lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_Lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_Lo = value;
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

	public frmInVchIN3()
	{
		__ENCAddToList(this);
		f_sGia = "";
		f_sTien = "";
		InitializeComponent();
	}

	public frmInVchIN3(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_sGia = "";
		f_sTien = "";
		InitializeComponent();
	}

	public frmInVchIN3(string MenuID, string Stt_rec)
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
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0d9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Expected O, but got Unknown
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efc: Expected O, but got Unknown
		//IL_0fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbf: Expected O, but got Unknown
		//IL_2048: Unknown result type (might be due to invalid IL or missing references)
		//IL_2052: Expected O, but got Unknown
		//IL_213f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2149: Expected O, but got Unknown
		//IL_2203: Unknown result type (might be due to invalid IL or missing references)
		//IL_220d: Expected O, but got Unknown
		//IL_25b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c0: Expected O, but got Unknown
		//IL_26ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b7: Expected O, but got Unknown
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
		dgvcMa_khox = new DataGridViewAsTextBoxColumn();
		dgvcMa_khon = new DataGridViewAsTextBoxColumn();
		dgvcSo_luong = new DataGridViewAsTextNumericColumn();
		dgvcGia_nt = new DataGridViewAsTextNumericColumn();
		dgvcTien_nt = new DataGridViewAsTextNumericColumn();
		dgvcTk_no = new DataGridViewAsTextBoxColumn();
		dgvcTk_vt = new DataGridViewAsTextBoxColumn();
		dgvcGia = new DataGridViewAsTextNumericColumn();
		dgvcTien = new DataGridViewAsTextNumericColumn();
		dgvcMa_spct = new DataGridViewAsTextBoxColumn();
		dgvcMa_hd = new DataGridViewAsTextBoxColumn();
		dgvcMa_phi = new DataGridViewAsTextBoxColumn();
		dgvcMa_bp = new DataGridViewAsTextBoxColumn();
		dgvcMa_Lo = new DataGridViewAsTextBoxColumn();
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
		txtSo_pn = new TextBox();
		lblSo_pn = new Label();
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
		location = new Point(723, 428);
		((Control)obj3).Location = location;
		Button obj4 = cmdNext;
		location = new Point(698, 428);
		((Control)obj4).Location = location;
		Button obj5 = cmdPrevious;
		location = new Point(673, 428);
		((Control)obj5).Location = location;
		Button obj6 = cmdFirst;
		location = new Point(648, 428);
		((Control)obj6).Location = location;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(537, 43);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct;
		Size size = new Size(72, 13);
		((Control)obj8).Size = size;
		lblSo_Ct.Text = "Số phiếu xuất";
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		Label obj9 = lblNgay_Ct;
		location = new Point(537, 17);
		((Control)obj9).Location = location;
		Label obj10 = lblNgay_Ct;
		size = new Size(84, 13);
		((Control)obj10).Size = size;
		lblNgay_Ct.Text = "Ngày phiếu xuất";
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		TextBox obj11 = txtSo_Ct;
		location = new Point(653, 40);
		((Control)obj11).Location = location;
		((Control)txtSo_Ct).TabIndex = 6;
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)5;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(653, 14);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay_Ct).TabIndex = 5;
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbPH).Controls.Add((Control)(object)txtSo_pn);
		((Control)gbPH).Controls.Add((Control)(object)lblSo_pn);
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
		size = new Size(737, 150);
		((Control)obj12).Size = size;
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
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_pn, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_pn, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(567, 428);
		((Control)splitButton).Location = location;
		AsTabControl asTabControl = AsTabControl;
		location = new Point(7, 155);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(743, 247);
		((Control)asTabControl2).Size = size;
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj13 = tabDetail;
		size = new Size(735, 218);
		((Control)obj13).Size = size;
		TabPage obj14 = tabOptFields;
		size = new Size(735, 218);
		((Control)obj14).Size = size;
		Button obj15 = cmdCopy;
		location = new Point(289, 428);
		((Control)obj15).Location = location;
		Button obj16 = cmdDelete;
		location = new Point(219, 428);
		((Control)obj16).Location = location;
		Button obj17 = cmdEdit;
		location = new Point(149, 428);
		((Control)obj17).Location = location;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(109, 14);
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
		Label obj18 = lblTen_Kh;
		location = new Point(188, 18);
		((Control)obj18).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj19 = lblTen_Kh;
		size = new Size(319, 13);
		((Control)obj19).Size = size;
		((Control)lblTen_Kh).TabIndex = 258;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj20 = lblMa_Kh;
		location = new Point(6, 17);
		((Control)obj20).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj21 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj21).Size = size;
		((Control)lblMa_Kh).TabIndex = 139;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj22 = lblNguoi_Gd;
		location = new Point(6, 69);
		((Control)obj22).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj23 = lblNguoi_Gd;
		size = new Size(94, 14);
		((Control)obj23).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 143;
		lblNguoi_Gd.Text = "Người giao dịch";
		TextBox obj24 = txtDien_giai;
		location = new Point(109, 92);
		((Control)obj24).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj25 = txtDien_giai;
		size = new Size(398, 20);
		((Control)obj25).Size = size;
		((Control)txtDien_giai).TabIndex = 4;
		TextBox obj26 = txtNguoi_Gd;
		location = new Point(109, 66);
		((Control)obj26).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj27 = txtNguoi_Gd;
		size = new Size(145, 20);
		((Control)obj27).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 3;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj28 = lblDien_giai;
		location = new Point(6, 96);
		((Control)obj28).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj29 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj29).Size = size;
		((Control)lblDien_giai).TabIndex = 144;
		lblDien_giai.Text = "Diễn giải";
		lblDia_chi.AutoSize = true;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj30 = lblDia_chi;
		location = new Point(6, 44);
		((Control)obj30).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj31 = lblDia_chi;
		size = new Size(40, 13);
		((Control)obj31).Size = size;
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
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[17]
		{
			dgvcMa_vt,
			(DataGridViewColumn)dgvcTen_vt,
			(DataGridViewColumn)dgvcDvt,
			dgvcMa_khox,
			dgvcMa_khon,
			dgvcSo_luong,
			dgvcGia_nt,
			dgvcTien_nt,
			dgvcTk_no,
			dgvcTk_vt,
			dgvcGia,
			dgvcTien,
			dgvcMa_spct,
			dgvcMa_hd,
			dgvcMa_phi,
			dgvcMa_bp,
			dgvcMa_Lo
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
		size = new Size(729, 212);
		((Control)asInputDGV2).Size = size;
		((Control)adgvDetail).TabIndex = 1;
		dgvcMa_vt.AutoFill = true;
		dgvcMa_vt.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_vt).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_vt.AutoValid = true;
		((DataGridViewColumn)dgvcMa_vt).DataPropertyName = "ma_vt";
		val4.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_vt).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcMa_vt).HeaderText = "Mã hàng";
		dgvcMa_vt.LookupCodeName = "MA_VT";
		dgvcMa_vt.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_vt).Name = "dgvcMa_vt";
		dgvcMa_vt.ReceiverValidFieldList = "ten_vt,dvt,tk_vt,gia_ton";
		dgvcMa_vt.SD = true;
		dgvcMa_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_vt.ValidReturnFieldList = "ten_vt,dvt,tk_vt,gia_ton,ma_kho,ma_vitri";
		((DataGridViewColumn)dgvcMa_vt).Width = 55;
		((DataGridViewColumn)dgvcTen_vt).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vt).HeaderText = "Tên hàng";
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
		dgvcMa_khox.AutoFill = true;
		dgvcMa_khox.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_khox).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_khox.AutoValid = true;
		((DataGridViewColumn)dgvcMa_khox).DataPropertyName = "ma_khox";
		val5.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_khox).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcMa_khox).HeaderText = "Kho xuất";
		dgvcMa_khox.LookupCodeName = "MA_KHO";
		dgvcMa_khox.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_khox).Name = "dgvcMa_khox";
		dgvcMa_khox.ReceiverValidFieldList = "ten_khox";
		dgvcMa_khox.SD = true;
		dgvcMa_khox.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_khox.ValidReturnFieldList = "ten_kho";
		((DataGridViewColumn)dgvcMa_khox).Width = 55;
		dgvcMa_khon.AutoFill = true;
		dgvcMa_khon.AutoLookup = true;
		dgvcMa_khon.AutoValid = true;
		((DataGridViewColumn)dgvcMa_khon).DataPropertyName = "ma_khon";
		val6.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_khon).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcMa_khon).HeaderText = "Kho nhập";
		dgvcMa_khon.LookupCodeName = "MA_KHO";
		dgvcMa_khon.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_khon).Name = "dgvcMa_khon";
		dgvcMa_khon.ReceiverValidFieldList = "ten_khon";
		dgvcMa_khon.SD = true;
		dgvcMa_khon.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_khon.ValidReturnFieldList = "ten_kho";
		((DataGridViewColumn)dgvcMa_khon).Width = 60;
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
		dgvcTk_no.AutoFill = true;
		dgvcTk_no.AutoLookup = true;
		dgvcTk_no.AutoValid = true;
		((DataGridViewColumn)dgvcTk_no).DataPropertyName = "tk_no";
		val10.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_no).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcTk_no).HeaderText = "Tk nợ";
		dgvcTk_no.LookupCodeName = "TK";
		dgvcTk_no.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_no).Name = "dgvcTk_no";
		dgvcTk_no.ReceiverValidFieldList = "ten_tk_no";
		dgvcTk_no.SD = true;
		dgvcTk_no.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_no.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_no).Width = 70;
		dgvcTk_vt.AutoFill = true;
		dgvcTk_vt.AutoLookup = true;
		dgvcTk_vt.AutoValid = true;
		((DataGridViewColumn)dgvcTk_vt).DataPropertyName = "tk_vt";
		val11.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk_vt).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcTk_vt).HeaderText = "Tk có";
		dgvcTk_vt.LookupCodeName = "TK";
		dgvcTk_vt.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk_vt).Name = "dgvcTk_vt";
		dgvcTk_vt.ReceiverValidFieldList = "ten_tk_vt";
		dgvcTk_vt.SD = true;
		dgvcTk_vt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk_vt.ValidReturnFieldList = "ten_tk";
		((DataGridViewColumn)dgvcTk_vt).Width = 70;
		((DataGridViewColumn)dgvcGia).DataPropertyName = "gia";
		val12.Alignment = (DataGridViewContentAlignment)64;
		val12.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcGia).HeaderText = "Giá VND";
		dgvcGia.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcGia).Name = "dgvcGia";
		((DataGridViewColumn)dgvcGia).ReadOnly = true;
		dgvcGia.SortMode = (DataGridViewColumnSortMode)0;
		dgvcGia.SpecialType = Commons.NumericSpecialType.ACPrice;
		((DataGridViewColumn)dgvcGia).Width = 80;
		((DataGridViewColumn)dgvcTien).DataPropertyName = "tien";
		val13.Alignment = (DataGridViewContentAlignment)64;
		val13.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien).DefaultCellStyle = val13;
		((DataGridViewColumn)dgvcTien).HeaderText = "Tiền VND";
		dgvcTien.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien).Name = "dgvcTien";
		((DataGridViewColumn)dgvcTien).ReadOnly = true;
		dgvcTien.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcTien).Width = 80;
		dgvcMa_spct.AutoFill = true;
		dgvcMa_spct.AutoLookup = true;
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
		((DataGridViewColumn)dgvcMa_spct).Width = 70;
		dgvcMa_hd.AutoFill = true;
		dgvcMa_hd.AutoLookup = true;
		dgvcMa_hd.AutoValid = true;
		((DataGridViewColumn)dgvcMa_hd).DataPropertyName = "ma_hd";
		val15.BackColor = SystemColors.Info;
		val15.NullValue = null;
		((DataGridViewColumn)dgvcMa_hd).DefaultCellStyle = val15;
		((DataGridViewColumn)dgvcMa_hd).HeaderText = "Hợp đồng";
		dgvcMa_hd.LookupCodeName = "MA_HD";
		dgvcMa_hd.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_hd).Name = "dgvcMa_hd";
		dgvcMa_hd.ReceiverValidFieldList = "ten_hd";
		dgvcMa_hd.SD = true;
		dgvcMa_hd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_hd.ValidReturnFieldList = "ten_hd";
		((DataGridViewColumn)dgvcMa_hd).Width = 70;
		dgvcMa_phi.AutoFill = true;
		dgvcMa_phi.AutoLookup = true;
		dgvcMa_phi.AutoValid = true;
		((DataGridViewColumn)dgvcMa_phi).DataPropertyName = "ma_phi";
		val16.BackColor = SystemColors.Info;
		val16.NullValue = null;
		((DataGridViewColumn)dgvcMa_phi).DefaultCellStyle = val16;
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
		val17.BackColor = SystemColors.Info;
		val17.NullValue = null;
		((DataGridViewColumn)dgvcMa_bp).DefaultCellStyle = val17;
		((DataGridViewColumn)dgvcMa_bp).HeaderText = "Bộ phận";
		dgvcMa_bp.LookupCodeName = "MA_BP";
		dgvcMa_bp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_bp).Name = "dgvcMa_bp";
		dgvcMa_bp.ReceiverValidFieldList = "ten_bp";
		dgvcMa_bp.SD = true;
		dgvcMa_bp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_bp.ValidReturnFieldList = "ten_bp";
		((DataGridViewColumn)dgvcMa_bp).Width = 70;
		dgvcMa_Lo.AutoFill = true;
		dgvcMa_Lo.AutoLookup = true;
		dgvcMa_Lo.AutoValid = true;
		((DataGridViewColumn)dgvcMa_Lo).DataPropertyName = "ma_lo";
		val18.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_Lo).DefaultCellStyle = val18;
		((DataGridViewColumn)dgvcMa_Lo).HeaderText = "Lô";
		dgvcMa_Lo.LookupCodeName = "MA_LO";
		dgvcMa_Lo.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_Lo).Name = "dgvcMa_Lo";
		dgvcMa_Lo.ReceiverValidFieldList = "ten_lo";
		dgvcMa_Lo.SD = true;
		dgvcMa_Lo.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_Lo.ValidReturnFieldList = "ten_lo";
		((DataGridViewColumn)dgvcMa_Lo).Width = 70;
		txtNgay_lct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_lct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_lct;
		location = new Point(653, 92);
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
		Label obj32 = lblNgay_Lct;
		location = new Point(537, 95);
		((Control)obj32).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj33 = lblNgay_Lct;
		size = new Size(56, 15);
		((Control)obj33).Size = size;
		((Control)lblNgay_Lct).TabIndex = 234;
		lblNgay_Lct.Text = "Ngày lập";
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(662, 118);
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
		location = new Point(612, 118);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(47, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 9;
		lblMa_Nt.AutoSize = true;
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj34 = lblMa_Nt;
		location = new Point(537, 121);
		((Control)obj34).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj35 = lblMa_Nt;
		size = new Size(36, 13);
		((Control)obj35).Size = size;
		((Control)lblMa_Nt).TabIndex = 237;
		lblMa_Nt.Text = "Tỷ giá";
		((Control)txtT_Tien).Anchor = (AnchorStyles)6;
		txtT_Tien.DecimalSymbol = ".";
		((Control)txtT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtT_Tien;
		location = new Point(646, 402);
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
		Label obj36 = lblT_Tien;
		location = new Point(431, 405);
		((Control)obj36).Location = location;
		((Control)lblT_Tien).Name = "lblT_Tien";
		Label obj37 = lblT_Tien;
		size = new Size(103, 13);
		((Control)obj37).Size = size;
		((Control)lblT_Tien).TabIndex = 228;
		lblT_Tien.Text = "Tiền xuất";
		lblT_Tien.TextAlign = (ContentAlignment)16;
		((Control)txtT_Tien_nt).Anchor = (AnchorStyles)6;
		txtT_Tien_nt.DecimalSymbol = ".";
		((Control)txtT_Tien_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric5 = txtT_Tien_nt;
		location = new Point(540, 402);
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
		TextBox obj38 = txtDia_chi;
		location = new Point(109, 40);
		((Control)obj38).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj39 = txtDia_chi;
		size = new Size(398, 20);
		((Control)obj39).Size = size;
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
		TextBox obj40 = txtSo_pn;
		location = new Point(653, 66);
		((Control)obj40).Location = location;
		((TextBoxBase)txtSo_pn).MaxLength = 30;
		((Control)txtSo_pn).Name = "txtSo_pn";
		TextBox obj41 = txtSo_pn;
		size = new Size(78, 20);
		((Control)obj41).Size = size;
		((Control)txtSo_pn).TabIndex = 7;
		lblSo_pn.ImeMode = (ImeMode)0;
		Label obj42 = lblSo_pn;
		location = new Point(537, 69);
		((Control)obj42).Location = location;
		((Control)lblSo_pn).Name = "lblSo_pn";
		Label obj43 = lblSo_pn;
		size = new Size(94, 14);
		((Control)obj43).Size = size;
		((Control)lblSo_pn).TabIndex = 257;
		lblSo_pn.Text = "Số phiếu nhập";
		((Control)txtT_So_luong).Anchor = (AnchorStyles)6;
		txtT_So_luong.DecimalSymbol = ".";
		((Control)txtT_So_luong).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric7 = txtT_So_luong;
		location = new Point(325, 402);
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
		((Control)Label5).Anchor = (AnchorStyles)6;
		((Control)Label5).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label5.ImeMode = (ImeMode)0;
		Label label = Label5;
		location = new Point(213, 405);
		((Control)label).Location = location;
		((Control)Label5).Name = "Label5";
		Label label2 = Label5;
		size = new Size(106, 13);
		((Control)label2).Size = size;
		((Control)Label5).TabIndex = 259;
		Label5.Text = "Số lượng";
		Label5.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(755, 476);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtT_So_luong);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)chkGia_dd);
		((Control)this).Controls.Add((Control)(object)txtT_Tien);
		((Control)this).Controls.Add((Control)(object)lblT_Tien);
		((Control)this).Controls.Add((Control)(object)txtT_Tien_nt);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmInVchIN3";
		((Form)this).Text = "frmInVchIN3";
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
		((Control)this).Controls.SetChildIndex((Control)(object)chkGia_dd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_So_luong, 0);
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTien).Name, false) == 0)
			{
				V_tien(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcGia).Name, false) == 0)
			{
				V_Gia(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_vt).Name, false) == 0)
			{
				V_Ma_Vt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_khox).Name, false) == 0)
			{
				V_Ma_khox(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_khon).Name, false) == 0)
			{
				V_Ma_khon(oDv);
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_khox).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["ten_khox"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_khon).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["ten_khon"]);
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_vt).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_vt"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk_no).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk_no"]);
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
		if (Operators.CompareString(name, ((DataGridViewColumn)dgvcSo_luong).Name, false) == 0 && ((Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_khox"]), isNum: false), (object)"", false) && ActionMode == Commons.ApplicationMode.ADD_MODE) ? true : false))
		{
			double result = 0.0;
			if (double.TryParse(e.FormattedValue.ToString(), out result) && Operators.ConditionalCompareObjectGreater((object)result, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tonx"]), isNum: true), false))
			{
				((CancelEventArgs)(object)e).Cancel = !Commons.ProcessLackOfInventory2Issue();
			}
		}
	}

	private void adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged(object sender, SetDependentFieldsWhenCellValueChangedEventArgs e)
	{
		if ((!base.MyVoucherInfo.ct_carry_field_list.ToUpper().Contains("MA_KHOX") || ((DataGridViewCellEventArgs)e).RowIndex <= 0) && 0 == 0 && ((e.ValidatedRow != null && ((DataGridView)adgvDetail).Columns[((DataGridViewCellEventArgs)e).ColumnIndex].Name.Equals(((DataGridViewColumn)dgvcMa_vt).Name) && dgvcMa_vt.ValidReturnFieldList.Contains("ma_kho") && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_kho"]), isNum: false), (object)"", false)) ? true : false))
		{
			CurrentCTRowView["ma_khox"] = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_kho"]);
			CurrentCTRowView["ma_vitrix"] = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_vitri"]);
			((DataGridView)dgvDetail).AutoResizeColumn(((DataGridViewBand)dgvcMa_khox).Index);
			DataRow pDrw = null;
			if (Commons.ValidMa(ref pDrw, "MA_KHO", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentCTRowView["ma_khox"]), isNum: false)), "", "kho_dl,tk_dl", pSd: true) && ((Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)true, false) && Operators.ConditionalCompareObjectNotEqual(pDrw["tk_dl"], (object)"", false)) ? true : false))
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
		ReCalcTonKhoTucThoi_KhoXuat(oDv);
		ReCalcTonKhoTucThoi_KhoNhap(oDv);
	}

	private void V_Ma_khox(DataRowView oDv)
	{
		ReCalcTonKhoTucThoi_KhoXuat(oDv);
		DataRow pDrw = null;
		if (Commons.ValidMa(ref pDrw, "MA_KHO", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_khox"]), isNum: false)), "", "kho_dl,tk_dl", pSd: true) && ((Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)true, false) && Operators.ConditionalCompareObjectNotEqual(pDrw["tk_dl"], (object)"", false)) ? true : false))
		{
			oDv["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["tk_dl"]);
		}
		if ((pDrw != null && Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)false, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["MA_VT"]), isNum: false), (object)"", false)) ? true : false)
		{
			Commons.ValidMa(ref pDrw, "MA_VT", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["MA_VT"]), isNum: false)), "", "TK_VT", pSd: true);
			oDv["tk_vt"] = RuntimeHelpers.GetObjectValue(pDrw["TK_VT"]);
		}
	}

	private void V_Ma_khon(DataRowView oDv)
	{
		ReCalcTonKhoTucThoi_KhoNhap(oDv);
		DataRow pDrw = null;
		if (Commons.ValidMa(ref pDrw, "MA_KHO", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_khon"]), isNum: false)), "", "kho_dl,tk_dl", pSd: true) && ((Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)true, false) && Operators.ConditionalCompareObjectNotEqual(pDrw["tk_dl"], (object)"", false)) ? true : false))
		{
			oDv["tk_no"] = RuntimeHelpers.GetObjectValue(pDrw["tk_dl"]);
		}
		if ((pDrw != null && Operators.ConditionalCompareObjectEqual(pDrw["kho_dl"], (object)false, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["MA_VT"]), isNum: false), (object)"", false)) ? true : false)
		{
			Commons.ValidMa(ref pDrw, "MA_VT", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["MA_VT"]), isNum: false)), "", "TK_VT", pSd: true);
			oDv["tk_no"] = RuntimeHelpers.GetObjectValue(pDrw["TK_VT"]);
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

	private void ReCalcTonKhoTucThoi_KhoXuat(DataRowView odv)
	{
		double num = default(double);
		double num2 = default(double);
		double num3 = default(double);
		double num4 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_vt"]), isNum: false), (object)"", false) || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_khox"]), isNum: false), (object)"", false) ? true : false))
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
			string aMa_Kho = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_khox"]), isNum: false));
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
		odv["Tonx"] = num;
		odv["ton_All"] = num2;
		odv["Tonx_mua"] = num3;
		odv["ton_mua_All"] = num4;
		odv["Tonx_ban"] = num5;
		odv["ton_ban_All"] = num6;
	}

	private void ReCalcTonKhoTucThoi_KhoNhap(DataRowView odv)
	{
		if ((!Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_vt"]), isNum: false), (object)"", false) || !Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_khon"]), isNum: false), (object)"", false)) && 0 == 0)
		{
			string aMa_Kho = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_khon"]), isNum: false));
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
			odv["Tonn"] = value;
			odv["Tonn_mua"] = value3;
			odv["Tonn_ban"] = value5;
		}
	}

	private void V_Ty_Gia()
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			foreach (DataRowView item in CT1Voucher)
			{
				if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
				{
					Type? typeFromHandle = typeof(Math);
					object[] array = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt"]), isNum: true)),
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
					item["gia"] = RuntimeHelpers.GetObjectValue(obj);
					Type? typeFromHandle2 = typeof(Math);
					array3 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_Nt"]), isNum: true)),
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
					item["Tien"] = RuntimeHelpers.GetObjectValue(obj2);
					continue;
				}
				if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
				{
					Type? typeFromHandle3 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["gia_nt"]), isNum: true), txtTy_gia.Value),
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
					item["gia"] = RuntimeHelpers.GetObjectValue(obj3);
				}
				if (Operators.ConditionalCompareObjectNotEqual(Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia"]), isNum: true)), (object)0, false))
				{
					Type? typeFromHandle4 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["So_Luong"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Gia"]), isNum: true)),
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
					item["Tien"] = RuntimeHelpers.GetObjectValue(obj4);
				}
				else if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
				{
					Type? typeFromHandle5 = typeof(Math);
					object[] array3 = new object[3]
					{
						Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tien_nt"]), isNum: true), txtTy_gia.Value),
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
					item["Tien"] = RuntimeHelpers.GetObjectValue(obj5);
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
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Vt"]), isNum: false), (object)"", false))
				{
					return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_vt).Name, num2], 50062);
				}
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_khox"]), isNum: false), (object)"", false))
				{
					return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_khox).Name, num2], 50056);
				}
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_khon"]), isNum: false), (object)"", false))
				{
					return ValidGridCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_khon).Name, num2], 50056);
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
		CreateDataBinding((Control)(object)txtSo_pn, "so_pn");
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
		drwPh["so_pn"] = Commons.Get_SoCt(base.MyMenuInfo.par1, Conversions.ToDate(drwPh["ngay_ct"]));
		drwPh["ngay_lct"] = RuntimeHelpers.GetObjectValue(drwPh["ngay_ct"]);
		drwPh["ma_gd"] = "3";
	}

	protected override void Addnew()
	{
		base.Addnew();
		base.CurrentPHRow["so_pn"] = Commons.Get_SoCt("IN1", Conversions.ToDate(base.CurrentPHRow["ngay_ct"]));
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
