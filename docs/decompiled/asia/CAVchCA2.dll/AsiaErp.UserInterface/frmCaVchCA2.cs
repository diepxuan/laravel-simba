using System;
using System.Collections;
using System.Collections.Generic;
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
public class frmCaVchCA2 : frmVoucher
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("adgvDetail")]
	private AsInputDGV _adgvDetail;

	[AccessedThroughProperty("txtDia_chi")]
	private TextBox _txtDia_chi;

	[AccessedThroughProperty("lblDia_chi")]
	private Label _lblDia_chi;

	[AccessedThroughProperty("lblTk_Co")]
	private Label _lblTk_Co;

	[AccessedThroughProperty("lblNguoi_Gd")]
	private Label _lblNguoi_Gd;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("lblNgay_Lct")]
	private Label _lblNgay_Lct;

	[AccessedThroughProperty("txtNguoi_Gd")]
	private TextBox _txtNguoi_Gd;

	[AccessedThroughProperty("lblDien_giai")]
	private Label _lblDien_giai;

	[AccessedThroughProperty("lblTen_Tk_Co")]
	private Label _lblTen_Tk_Co;

	[AccessedThroughProperty("txtTk_Co")]
	private AsTextBox _txtTk_Co;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("txtNgay_lct")]
	private AsMaskedTextBox _txtNgay_lct;

	[AccessedThroughProperty("lblT_Tien")]
	private Label _lblT_Tien;

	[AccessedThroughProperty("txtT_Tien")]
	private AsTextNumeric _txtT_Tien;

	[AccessedThroughProperty("tabTax")]
	private TabPage _tabTax;

	[AccessedThroughProperty("txtTy_gia")]
	private AsTextNumeric _txtTy_gia;

	[AccessedThroughProperty("cboMa_NT")]
	private AsComboBoxNT _cboMa_NT;

	[AccessedThroughProperty("lblMa_Nt")]
	private Label _lblMa_Nt;

	[AccessedThroughProperty("ctlTaIn")]
	private ctlTaIn _ctlTaIn;

	[AccessedThroughProperty("txtT_Thue")]
	private AsTextNumeric _txtT_Thue;

	[AccessedThroughProperty("txtT_Tt")]
	private AsTextNumeric _txtT_Tt;

	[AccessedThroughProperty("txtT_tien_Nt")]
	private AsTextNumeric _txtT_tien_Nt;

	[AccessedThroughProperty("lblT_Thue")]
	private Label _lblT_Thue;

	[AccessedThroughProperty("lblT_Tt")]
	private Label _lblT_Tt;

	[AccessedThroughProperty("txtT_thue_Nt")]
	private AsTextNumeric _txtT_thue_Nt;

	[AccessedThroughProperty("txtT_tt_Nt")]
	private AsTextNumeric _txtT_tt_Nt;

	[AccessedThroughProperty("chkTg_gs_dd")]
	private CheckBox _chkTg_gs_dd;

	[AccessedThroughProperty("cmdGetTaInFromDetail")]
	private Button _cmdGetTaInFromDetail;

	[AccessedThroughProperty("btnVAT_NK")]
	private Button _btnVAT_NK;

	[AccessedThroughProperty("dgvcTk")]
	private DataGridViewAsTextBoxColumn _dgvcTk;

	[AccessedThroughProperty("dgvcTen_tk")]
	private DataGridViewTextBoxColumn _dgvcTen_tk;

	[AccessedThroughProperty("dgvcPs_no_nt")]
	private DataGridViewAsTextNumericColumn _dgvcPs_no_nt;

	[AccessedThroughProperty("dgvcPs_no")]
	private DataGridViewAsTextNumericColumn _dgvcPs_no;

	[AccessedThroughProperty("dgvcMa_kh")]
	private DataGridViewAsTextBoxColumn _dgvcMa_kh;

	[AccessedThroughProperty("dgvcTen_kh")]
	private DataGridViewTextBoxColumn _dgvcTen_kh;

	[AccessedThroughProperty("dgvcDu13")]
	private DataGridViewTextBoxColumn _dgvcDu13;

	[AccessedThroughProperty("dgvcDien_giai")]
	private DataGridViewTextBoxColumn _dgvcDien_giai;

	[AccessedThroughProperty("dgvcSn_hu")]
	private DataGridViewAsTextNumericColumn _dgvcSn_hu;

	[AccessedThroughProperty("dgvcMa_bp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_bp;

	[AccessedThroughProperty("dgvcMa_phi")]
	private DataGridViewAsTextBoxColumn _dgvcMa_phi;

	[AccessedThroughProperty("dgvcMa_hd")]
	private DataGridViewAsTextBoxColumn _dgvcMa_hd;

	[AccessedThroughProperty("dgvcMa_ku")]
	private DataGridViewAsTextBoxColumn _dgvcMa_ku;

	[AccessedThroughProperty("dgvcMa_spct")]
	private DataGridViewAsTextBoxColumn _dgvcMa_spct;

	private string f_sPs_no_header;

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
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellEnter -= val;
				((DataGridView)_adgvDetail).CellValueChanged -= val2;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellEnter += val;
				((DataGridView)_adgvDetail).CellValueChanged += val2;
			}
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

	internal virtual Label lblTk_Co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Co = value;
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
			EventHandler eventHandler = txtDien_giai_Validated;
			if (_txtDien_giai != null)
			{
				((Control)_txtDien_giai).Validated -= eventHandler;
			}
			_txtDien_giai = value;
			if (_txtDien_giai != null)
			{
				((Control)_txtDien_giai).Validated += eventHandler;
			}
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

	internal virtual Label lblTen_Tk_Co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_Co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_Co = value;
		}
	}

	internal virtual AsTextBox txtTk_Co
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtTk_Co_Validated;
			if (_txtTk_Co != null)
			{
				((Control)_txtTk_Co).Validated -= eventHandler;
			}
			_txtTk_Co = value;
			if (_txtTk_Co != null)
			{
				((Control)_txtTk_Co).Validated += eventHandler;
			}
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

	internal virtual TabPage tabTax
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabTax;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabTax = value;
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
			EventHandler obj = txtTy_gia_ValueChanged;
			if (_txtTy_gia != null)
			{
				_txtTy_gia.ValueChanged -= obj;
			}
			_txtTy_gia = value;
			if (_txtTy_gia != null)
			{
				_txtTy_gia.ValueChanged += obj;
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

	internal virtual ctlTaIn ctlTaIn
	{
		[DebuggerNonUserCode]
		get
		{
			return _ctlTaIn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			ctlTaIn.TAINValueChangedEventHandler obj = ctlTaIn_TAINValueChanged;
			if (_ctlTaIn != null)
			{
				_ctlTaIn.TAINValueChanged -= obj;
			}
			_ctlTaIn = value;
			if (_ctlTaIn != null)
			{
				_ctlTaIn.TAINValueChanged += obj;
			}
		}
	}

	internal virtual AsTextNumeric txtT_Thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Thue = value;
		}
	}

	internal virtual AsTextNumeric txtT_Tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Tt = value;
		}
	}

	internal virtual AsTextNumeric txtT_tien_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tien_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tien_Nt = value;
		}
	}

	internal virtual Label lblT_Thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_Thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_Thue = value;
		}
	}

	internal virtual Label lblT_Tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_Tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_Tt = value;
		}
	}

	internal virtual AsTextNumeric txtT_thue_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_thue_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_thue_Nt = value;
		}
	}

	internal virtual AsTextNumeric txtT_tt_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tt_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tt_Nt = value;
		}
	}

	internal virtual CheckBox chkTg_gs_dd
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkTg_gs_dd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkTg_gs_dd = value;
		}
	}

	internal virtual Button cmdGetTaInFromDetail
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdGetTaInFromDetail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdGetTaInFromDetail_Click;
			if (_cmdGetTaInFromDetail != null)
			{
				((Control)_cmdGetTaInFromDetail).Click -= eventHandler;
			}
			_cmdGetTaInFromDetail = value;
			if (_cmdGetTaInFromDetail != null)
			{
				((Control)_cmdGetTaInFromDetail).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnVAT_NK
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnVAT_NK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnVAT_NK_Click;
			if (_btnVAT_NK != null)
			{
				((Control)_btnVAT_NK).Click -= eventHandler;
			}
			_btnVAT_NK = value;
			if (_btnVAT_NK != null)
			{
				((Control)_btnVAT_NK).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_tk = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcPs_no_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPs_no_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPs_no_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcPs_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPs_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPs_no = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_kh = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_kh = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDu13
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDu13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDu13 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDien_giai = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcSn_hu
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSn_hu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSn_hu = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_ku
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_ku = value;
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

	public frmCaVchCA2(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_sPs_no_header = "Ps_no";
		InitializeComponent();
	}

	public frmCaVchCA2(string MenuID, string Stt_rec)
		: base(MenuID, Stt_rec)
	{
		__ENCAddToList(this);
		f_sPs_no_header = "Ps_no";
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
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected O, but got Unknown
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcd: Expected O, but got Unknown
		//IL_0c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c90: Expected O, but got Unknown
		//IL_1ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee2: Expected O, but got Unknown
		//IL_1f91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9b: Expected O, but got Unknown
		//IL_20e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2200: Unknown result type (might be due to invalid IL or missing references)
		//IL_2486: Unknown result type (might be due to invalid IL or missing references)
		//IL_2490: Expected O, but got Unknown
		//IL_258e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2598: Expected O, but got Unknown
		//IL_2696: Unknown result type (might be due to invalid IL or missing references)
		//IL_26a0: Expected O, but got Unknown
		//IL_278a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2794: Expected O, but got Unknown
		//IL_2832: Unknown result type (might be due to invalid IL or missing references)
		//IL_283c: Expected O, but got Unknown
		//IL_28eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f5: Expected O, but got Unknown
		//IL_29f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_29fd: Expected O, but got Unknown
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
		adgvDetail = new AsInputDGV();
		dgvcTk = new DataGridViewAsTextBoxColumn();
		dgvcTen_tk = new DataGridViewTextBoxColumn();
		dgvcPs_no_nt = new DataGridViewAsTextNumericColumn();
		dgvcPs_no = new DataGridViewAsTextNumericColumn();
		dgvcMa_kh = new DataGridViewAsTextBoxColumn();
		dgvcTen_kh = new DataGridViewTextBoxColumn();
		dgvcDu13 = new DataGridViewTextBoxColumn();
		dgvcDien_giai = new DataGridViewTextBoxColumn();
		dgvcSn_hu = new DataGridViewAsTextNumericColumn();
		dgvcMa_bp = new DataGridViewAsTextBoxColumn();
		dgvcMa_phi = new DataGridViewAsTextBoxColumn();
		dgvcMa_hd = new DataGridViewAsTextBoxColumn();
		dgvcMa_ku = new DataGridViewAsTextBoxColumn();
		dgvcMa_spct = new DataGridViewAsTextBoxColumn();
		txtDia_chi = new TextBox();
		lblDia_chi = new Label();
		lblTk_Co = new Label();
		txtDien_giai = new TextBox();
		txtNguoi_Gd = new TextBox();
		lblDien_giai = new Label();
		lblNgay_Lct = new Label();
		lblNguoi_Gd = new Label();
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblTen_Tk_Co = new Label();
		txtTk_Co = new AsTextBox();
		txtNgay_lct = new AsMaskedTextBox();
		lblT_Tien = new Label();
		txtT_Tien = new AsTextNumeric();
		tabTax = new TabPage();
		cmdGetTaInFromDetail = new Button();
		ctlTaIn = new ctlTaIn();
		txtTy_gia = new AsTextNumeric();
		cboMa_NT = new AsComboBoxNT();
		lblMa_Nt = new Label();
		txtT_Thue = new AsTextNumeric();
		txtT_Tt = new AsTextNumeric();
		txtT_tien_Nt = new AsTextNumeric();
		lblT_Thue = new Label();
		lblT_Tt = new Label();
		txtT_thue_Nt = new AsTextNumeric();
		txtT_tt_Nt = new AsTextNumeric();
		chkTg_gs_dd = new CheckBox();
		btnVAT_NK = new Button();
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
		((Control)tabTax).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdAdd;
		Point location = new Point(9, 434);
		((Control)obj).Location = location;
		Button obj2 = cmdPrint;
		location = new Point(79, 434);
		((Control)obj2).Location = location;
		Button obj3 = cmdLast;
		location = new Point(688, 434);
		((Control)obj3).Location = location;
		((Control)cmdLast).TabIndex = 12;
		Button obj4 = cmdNext;
		location = new Point(665, 434);
		((Control)obj4).Location = location;
		((Control)cmdNext).TabIndex = 11;
		Button obj5 = cmdPrevious;
		location = new Point(642, 434);
		((Control)obj5).Location = location;
		((Control)cmdPrevious).TabIndex = 10;
		Button obj6 = cmdFirst;
		location = new Point(619, 434);
		((Control)obj6).Location = location;
		((Control)cmdFirst).TabIndex = 9;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(510, 44);
		((Control)obj7).Location = location;
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		Label obj8 = lblNgay_Ct;
		location = new Point(510, 18);
		((Control)obj8).Location = location;
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		TextBox obj9 = txtSo_Ct;
		location = new Point(618, 40);
		((Control)obj9).Location = location;
		((TextBoxBase)txtSo_Ct).ReadOnly = true;
		((Control)txtSo_Ct).TabIndex = 6;
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)5;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(618, 14);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_Ct).ReadOnly = true;
		((Control)txtNgay_Ct).TabIndex = 5;
		((Control)gbPH).BackColor = Color.Transparent;
		((Control)gbPH).Controls.Add((Control)(object)txtTy_gia);
		((Control)gbPH).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Nt);
		((Control)gbPH).Controls.Add((Control)(object)txtNgay_lct);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Tk_Co);
		((Control)gbPH).Controls.Add((Control)(object)txtTk_Co);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)txtDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)lblDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)lblTk_Co);
		((Control)gbPH).Controls.Add((Control)(object)lblNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbPH).Controls.Add((Control)(object)lblNgay_Lct);
		((Control)gbPH).Controls.Add((Control)(object)txtNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)lblDien_giai);
		GroupBox obj10 = gbPH;
		Size size = new Size(702, 149);
		((Control)obj10).Size = size;
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTk_Co, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTk_Co, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Tk_Co, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTy_gia, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(537, 434);
		((Control)splitButton).Location = location;
		((Control)cmdSearch).TabIndex = 8;
		((Control)AsTabControl).Controls.Add((Control)(object)tabTax);
		AsTabControl asTabControl = AsTabControl;
		location = new Point(7, 154);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(709, 210);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabOptFields, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabTax, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabDetail, 0);
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj11 = tabDetail;
		size = new Size(701, 181);
		((Control)obj11).Size = size;
		TabPage obj12 = tabOptFields;
		size = new Size(701, 181);
		((Control)obj12).Size = size;
		Button obj13 = cmdCopy;
		location = new Point(359, 434);
		((Control)obj13).Location = location;
		((Control)cmdCopy).TabIndex = 7;
		Button obj14 = cmdDelete;
		location = new Point(289, 434);
		((Control)obj14).Location = location;
		((Control)cmdDelete).TabIndex = 6;
		Button obj15 = cmdEdit;
		location = new Point(219, 434);
		((Control)obj15).Location = location;
		((Control)cmdEdit).TabIndex = 5;
		((DataGridView)adgvDetail).AllowUserToAddRows = false;
		((DataGridView)adgvDetail).AllowUserToDeleteRows = false;
		((DataGridView)adgvDetail).BackgroundColor = Color.White;
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
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[14]
		{
			dgvcTk,
			(DataGridViewColumn)dgvcTen_tk,
			dgvcPs_no_nt,
			dgvcPs_no,
			dgvcMa_kh,
			(DataGridViewColumn)dgvcTen_kh,
			(DataGridViewColumn)dgvcDu13,
			(DataGridViewColumn)dgvcDien_giai,
			dgvcSn_hu,
			dgvcMa_bp,
			dgvcMa_phi,
			dgvcMa_hd,
			dgvcMa_ku,
			dgvcMa_spct
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
		((DataGridView)adgvDetail).RowTemplate.Height = 20;
		((DataGridView)adgvDetail).ShowEditingIcon = false;
		AsInputDGV asInputDGV2 = adgvDetail;
		size = new Size(695, 175);
		((Control)asInputDGV2).Size = size;
		((Control)adgvDetail).TabIndex = 1;
		dgvcTk.AutoFill = true;
		dgvcTk.AutoLookup = true;
		dgvcTk.AutoValid = true;
		((DataGridViewColumn)dgvcTk).DataPropertyName = "tk";
		val4.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcTk).HeaderText = "TK";
		dgvcTk.LookupCodeName = "TK";
		dgvcTk.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk).Name = "dgvcTk";
		dgvcTk.ReceiverValidFieldList = "ten_tk,tk_cn";
		dgvcTk.SD = true;
		dgvcTk.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk.ValidReturnFieldList = "ten_tk,tk_cn";
		((DataGridViewColumn)dgvcTk).Width = 70;
		((DataGridViewColumn)dgvcTen_tk).DataPropertyName = "ten_tk";
		((DataGridViewColumn)dgvcTen_tk).HeaderText = "Tên tài khoản";
		((DataGridViewColumn)dgvcTen_tk).Name = "dgvcTen_tk";
		((DataGridViewColumn)dgvcTen_tk).ReadOnly = true;
		dgvcTen_tk.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_tk).Width = 150;
		((DataGridViewColumn)dgvcPs_no_nt).DataPropertyName = "ps_no_nt";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_no_nt).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcPs_no_nt).HeaderText = "Ps nợ";
		dgvcPs_no_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_no_nt).Name = "dgvcPs_no_nt";
		dgvcPs_no_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcPs_no_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcPs_no).DataPropertyName = "ps_no";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_no).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcPs_no).HeaderText = "Ps nợ VNĐ";
		dgvcPs_no.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_no).Name = "dgvcPs_no";
		dgvcPs_no.SortMode = (DataGridViewColumnSortMode)0;
		dgvcPs_no.SpecialType = Commons.NumericSpecialType.ACAmount;
		dgvcMa_kh.AutoFill = true;
		dgvcMa_kh.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_kh).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_kh.AutoValid = true;
		((DataGridViewColumn)dgvcMa_kh).DataPropertyName = "ma_kh";
		val7.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_kh).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcMa_kh).HeaderText = "Mã KH";
		dgvcMa_kh.LookupCodeName = "MA_KH";
		dgvcMa_kh.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_kh).Name = "dgvcMa_kh";
		dgvcMa_kh.ReceiverValidFieldList = "ten_kh";
		dgvcMa_kh.SD = true;
		dgvcMa_kh.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_kh.ValidReturnFieldList = "ten_kh";
		((DataGridViewColumn)dgvcMa_kh).Width = 46;
		((DataGridViewColumn)dgvcTen_kh).DataPropertyName = "ten_kh";
		((DataGridViewColumn)dgvcTen_kh).HeaderText = "Tên khách";
		((DataGridViewColumn)dgvcTen_kh).Name = "dgvcTen_kh";
		((DataGridViewColumn)dgvcTen_kh).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_kh).Width = 180;
		((DataGridViewColumn)dgvcDu13).DataPropertyName = "du13";
		val8.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcDu13).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcDu13).HeaderText = "Dư";
		((DataGridViewColumn)dgvcDu13).Name = "dgvcDu13";
		((DataGridViewColumn)dgvcDu13).ReadOnly = true;
		((DataGridViewColumn)dgvcDu13).Width = 70;
		((DataGridViewColumn)dgvcDien_giai).DataPropertyName = "dien_giai";
		((DataGridViewColumn)dgvcDien_giai).HeaderText = "Diễn giải";
		dgvcDien_giai.MaxInputLength = 128;
		((DataGridViewColumn)dgvcDien_giai).Name = "dgvcDien_giai";
		((DataGridViewColumn)dgvcDien_giai).Resizable = (DataGridViewTriState)1;
		dgvcDien_giai.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcDien_giai).Width = 150;
		((DataGridViewColumn)dgvcSn_hu).DataPropertyName = "sn_hn";
		val9.Alignment = (DataGridViewContentAlignment)64;
		val9.Format = "### ###";
		((DataGridViewColumn)dgvcSn_hu).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcSn_hu).HeaderText = "Hạn HƯ";
		dgvcSn_hu.Mask = "### ###";
		((DataGridViewColumn)dgvcSn_hu).Name = "dgvcSn_hu";
		dgvcSn_hu.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcSn_hu).Visible = false;
		((DataGridViewColumn)dgvcSn_hu).Width = 60;
		dgvcMa_bp.AutoFill = true;
		dgvcMa_bp.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_bp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_bp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_bp).DataPropertyName = "ma_bp";
		val10.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_bp).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcMa_bp).HeaderText = "B. phận";
		dgvcMa_bp.LookupCodeName = "MA_BP";
		dgvcMa_bp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_bp).Name = "dgvcMa_bp";
		dgvcMa_bp.ReceiverValidFieldList = "ten_bp";
		dgvcMa_bp.SD = true;
		dgvcMa_bp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_bp.ValidReturnFieldList = "ten_bp";
		((DataGridViewColumn)dgvcMa_bp).Width = 50;
		dgvcMa_phi.AutoFill = true;
		dgvcMa_phi.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_phi).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_phi.AutoValid = true;
		((DataGridViewColumn)dgvcMa_phi).DataPropertyName = "ma_phi";
		val11.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_phi).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcMa_phi).HeaderText = "Phí";
		dgvcMa_phi.LookupCodeName = "MA_PHI";
		dgvcMa_phi.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_phi).Name = "dgvcMa_phi";
		dgvcMa_phi.ReceiverValidFieldList = "ten_phi";
		dgvcMa_phi.SD = true;
		dgvcMa_phi.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_phi.ValidReturnFieldList = "ten_phi";
		((DataGridViewColumn)dgvcMa_phi).Width = 30;
		dgvcMa_hd.AutoFill = true;
		dgvcMa_hd.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_hd).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_hd.AutoValid = true;
		((DataGridViewColumn)dgvcMa_hd).DataPropertyName = "ma_hd";
		val12.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_hd).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcMa_hd).HeaderText = "H. đồng";
		dgvcMa_hd.LookupCodeName = "MA_HD";
		dgvcMa_hd.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_hd).Name = "dgvcMa_hd";
		dgvcMa_hd.ReceiverValidFieldList = "ten_hd";
		dgvcMa_hd.SD = true;
		dgvcMa_hd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_hd.ValidReturnFieldList = "ten_hd";
		((DataGridViewColumn)dgvcMa_hd).Width = 52;
		dgvcMa_ku.AutoFill = true;
		dgvcMa_ku.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_ku).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_ku.AutoValid = true;
		((DataGridViewColumn)dgvcMa_ku).DataPropertyName = "ma_ku";
		val13.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_ku).DefaultCellStyle = val13;
		((DataGridViewColumn)dgvcMa_ku).HeaderText = "Khế ước";
		dgvcMa_ku.LookupCodeName = "MA_KU";
		dgvcMa_ku.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_ku).Name = "dgvcMa_ku";
		dgvcMa_ku.ReceiverValidFieldList = "ten_ku";
		dgvcMa_ku.SD = true;
		dgvcMa_ku.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_ku.ValidReturnFieldList = "ten_ku";
		((DataGridViewColumn)dgvcMa_ku).Visible = false;
		dgvcMa_spct.AutoFill = true;
		dgvcMa_spct.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_spct).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_spct.AutoValid = true;
		((DataGridViewColumn)dgvcMa_spct).DataPropertyName = "ma_spct";
		val14.BackColor = SystemColors.Info;
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
		((Control)txtDia_chi).Anchor = (AnchorStyles)7;
		TextBox obj16 = txtDia_chi;
		location = new Point(113, 40);
		((Control)obj16).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		((TextBoxBase)txtDia_chi).ReadOnly = true;
		TextBox obj17 = txtDia_chi;
		size = new Size(330, 20);
		((Control)obj17).Size = size;
		((Control)txtDia_chi).TabIndex = 1;
		((Control)lblDia_chi).Anchor = (AnchorStyles)7;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj18 = lblDia_chi;
		location = new Point(6, 42);
		((Control)obj18).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj19 = lblDia_chi;
		size = new Size(98, 16);
		((Control)obj19).Size = size;
		((Control)lblDia_chi).TabIndex = 108;
		lblDia_chi.Text = "Địa chỉ";
		((Control)lblTk_Co).Anchor = (AnchorStyles)7;
		lblTk_Co.ImeMode = (ImeMode)0;
		Label obj20 = lblTk_Co;
		location = new Point(6, 120);
		((Control)obj20).Location = location;
		((Control)lblTk_Co).Name = "lblTk_Co";
		Label obj21 = lblTk_Co;
		size = new Size(98, 15);
		((Control)obj21).Size = size;
		((Control)lblTk_Co).TabIndex = 114;
		lblTk_Co.Text = "Tài khoản có";
		((Control)txtDien_giai).Anchor = (AnchorStyles)7;
		TextBox obj22 = txtDien_giai;
		location = new Point(113, 92);
		((Control)obj22).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		((TextBoxBase)txtDien_giai).ReadOnly = true;
		TextBox obj23 = txtDien_giai;
		size = new Size(330, 20);
		((Control)obj23).Size = size;
		((Control)txtDien_giai).TabIndex = 3;
		((Control)txtNguoi_Gd).Anchor = (AnchorStyles)7;
		TextBox obj24 = txtNguoi_Gd;
		location = new Point(113, 66);
		((Control)obj24).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		((TextBoxBase)txtNguoi_Gd).ReadOnly = true;
		TextBox obj25 = txtNguoi_Gd;
		size = new Size(112, 20);
		((Control)obj25).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 2;
		((Control)lblDien_giai).Anchor = (AnchorStyles)7;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj26 = lblDien_giai;
		location = new Point(6, 94);
		((Control)obj26).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj27 = lblDien_giai;
		size = new Size(98, 16);
		((Control)obj27).Size = size;
		((Control)lblDien_giai).TabIndex = 112;
		lblDien_giai.Text = "Diễn giải";
		lblNgay_Lct.ImeMode = (ImeMode)0;
		Label obj28 = lblNgay_Lct;
		location = new Point(510, 69);
		((Control)obj28).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj29 = lblNgay_Lct;
		size = new Size(56, 16);
		((Control)obj29).Size = size;
		((Control)lblNgay_Lct).TabIndex = 115;
		lblNgay_Lct.Text = "Ngày lập";
		((Control)lblNguoi_Gd).Anchor = (AnchorStyles)7;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj30 = lblNguoi_Gd;
		location = new Point(6, 68);
		((Control)obj30).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj31 = lblNguoi_Gd;
		size = new Size(98, 15);
		((Control)obj31).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 110;
		lblNguoi_Gd.Text = "Người giao dịch";
		((Control)lblTen_Kh).Anchor = (AnchorStyles)7;
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj32 = lblTen_Kh;
		location = new Point(194, 18);
		((Control)obj32).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj33 = lblTen_Kh;
		size = new Size(258, 14);
		((Control)obj33).Size = size;
		((Control)lblTen_Kh).TabIndex = 137;
		((Control)txtMa_Kh).Anchor = (AnchorStyles)7;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Control;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(113, 14);
		((Control)asTextBox).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		((TextBoxBase)txtMa_Kh).ReadOnly = true;
		txtMa_Kh.SD = true;
		AsTextBox asTextBox2 = txtMa_Kh;
		size = new Size(75, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Kh).TabIndex = 0;
		txtMa_Kh.UseAutoCompleteSource = true;
		txtMa_Kh.ValidReturnFieldList = "ten_kh,dia_chi,nguoi_gd,ma_httt_po";
		((Control)lblMa_Kh).Anchor = (AnchorStyles)7;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj34 = lblMa_Kh;
		location = new Point(6, 17);
		((Control)obj34).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj35 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj35).Size = size;
		((Control)lblMa_Kh).TabIndex = 0;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Tk_Co).Anchor = (AnchorStyles)7;
		lblTen_Tk_Co.ImeMode = (ImeMode)0;
		Label obj36 = lblTen_Tk_Co;
		location = new Point(197, 122);
		((Control)obj36).Location = location;
		((Control)lblTen_Tk_Co).Name = "lblTen_Tk_Co";
		Label obj37 = lblTen_Tk_Co;
		size = new Size(258, 14);
		((Control)obj37).Size = size;
		((Control)lblTen_Tk_Co).TabIndex = 217;
		lblTen_Tk_Co.TextAlign = (ContentAlignment)16;
		((Control)txtTk_Co).Anchor = (AnchorStyles)7;
		txtTk_Co.AutoLookup = true;
		txtTk_Co.AutoValid = true;
		((TextBoxBase)txtTk_Co).BackColor = SystemColors.Control;
		((TextBox)txtTk_Co).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk_Co;
		location = new Point(113, 118);
		((Control)asTextBox3).Location = location;
		txtTk_Co.LookupCodeName = "TK";
		txtTk_Co.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Co).Name = "txtTk_Co";
		txtTk_Co.NameControl = lblTen_Tk_Co;
		((TextBoxBase)txtTk_Co).ReadOnly = true;
		txtTk_Co.SD = true;
		AsTextBox asTextBox4 = txtTk_Co;
		size = new Size(75, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk_Co).TabIndex = 4;
		txtTk_Co.UseAutoCompleteSource = true;
		txtNgay_lct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_lct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_lct;
		location = new Point(618, 66);
		((Control)asMaskedTextBox2).Location = location;
		((MaskedTextBox)txtNgay_lct).Mask = "##/##/####";
		((Control)txtNgay_lct).Name = "txtNgay_lct";
		((MaskedTextBox)txtNgay_lct).PromptChar = ' ';
		((MaskedTextBox)txtNgay_lct).ReadOnly = true;
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_lct;
		size = new Size(78, 20);
		((Control)asMaskedTextBox3).Size = size;
		((Control)txtNgay_lct).TabIndex = 7;
		((MaskedTextBox)txtNgay_lct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_lct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox4.Value = dateTime;
		((Control)lblT_Tien).Anchor = (AnchorStyles)6;
		((Control)lblT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Tien.ImeMode = (ImeMode)0;
		Label obj38 = lblT_Tien;
		location = new Point(342, 367);
		((Control)obj38).Location = location;
		((Control)lblT_Tien).Name = "lblT_Tien";
		Label obj39 = lblT_Tien;
		size = new Size(161, 13);
		((Control)obj39).Size = size;
		((Control)lblT_Tien).TabIndex = 222;
		lblT_Tien.Text = "Tổng tiền";
		((Control)txtT_Tien).Anchor = (AnchorStyles)6;
		txtT_Tien.DecimalSymbol = ".";
		((Control)txtT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric = txtT_Tien;
		location = new Point(611, 364);
		((Control)asTextNumeric).Location = location;
		txtT_Tien.Mask = "### ### ### ###";
		((Control)txtT_Tien).Name = "txtT_Tien";
		((TextBoxBase)txtT_Tien).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtT_Tien;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		txtT_Tien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tien).TabIndex = 223;
		((Control)txtT_Tien).TabStop = false;
		((TextBox)txtT_Tien).Text = "0";
		((TextBox)txtT_Tien).TextAlign = (HorizontalAlignment)1;
		txtT_Tien.Value = 0.0;
		tabTax.BackColor = SystemColors.Control;
		((Control)tabTax).Controls.Add((Control)(object)cmdGetTaInFromDetail);
		((Control)tabTax).Controls.Add((Control)(object)ctlTaIn);
		TabPage obj40 = tabTax;
		location = new Point(4, 25);
		obj40.Location = location;
		((Control)tabTax).Name = "tabTax";
		TabPage obj41 = tabTax;
		Padding val15 = default(Padding);
		((Padding)(ref val15))._002Ector(3);
		((Control)obj41).Padding = val15;
		TabPage obj42 = tabTax;
		size = new Size(687, 221);
		((Control)obj42).Size = size;
		tabTax.TabIndex = 1;
		tabTax.Text = "Th&uế";
		((Control)cmdGetTaInFromDetail).Anchor = (AnchorStyles)10;
		Button obj43 = cmdGetTaInFromDetail;
		location = new Point(522, 232);
		((Control)obj43).Location = location;
		((Control)cmdGetTaInFromDetail).Name = "cmdGetTaInFromDetail";
		Button obj44 = cmdGetTaInFromDetail;
		size = new Size(145, 23);
		((Control)obj44).Size = size;
		((Control)cmdGetTaInFromDetail).TabIndex = 5;
		((ButtonBase)cmdGetTaInFromDetail).Text = "Lấy từ chi tiết";
		ctlTaIn.DataSource = bsTain;
		((Control)ctlTaIn).Dock = (DockStyle)5;
		ctlTaIn.HasThueNK = false;
		ctlTaIn.HasThueTTDB = false;
		ctlTaIn obj45 = ctlTaIn;
		location = new Point(3, 3);
		((Control)obj45).Location = location;
		ctlTaIn obj46 = ctlTaIn;
		((Padding)(ref val15))._002Ector(0);
		((Control)obj46).Margin = val15;
		((Control)ctlTaIn).Name = "ctlTaIn";
		ctlTaIn.PHDataSource = bsPH;
		ctlTaIn obj47 = ctlTaIn;
		size = new Size(681, 215);
		((Control)obj47).Size = size;
		((Control)ctlTaIn).TabIndex = 0;
		ctlTaIn.TAINTable = null;
		ctlTaIn.Tk_Du = "";
		ctlTaIn.Tk_Thue = "";
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric3 = txtTy_gia;
		location = new Point(627, 92);
		((Control)asTextNumeric3).Location = location;
		txtTy_gia.Mask = "### ###.##";
		((Control)txtTy_gia).Name = "txtTy_gia";
		((TextBoxBase)txtTy_gia).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtTy_gia;
		size = new Size(69, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtTy_gia).TabIndex = 9;
		((TextBox)txtTy_gia).Text = "0.00";
		((TextBox)txtTy_gia).TextAlign = (HorizontalAlignment)1;
		txtTy_gia.Value = 0.0;
		((ComboBox)cboMa_NT).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboMa_NT).Enabled = false;
		((ListControl)cboMa_NT).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_NT;
		location = new Point(577, 92);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(47, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 8;
		lblMa_Nt.AutoSize = true;
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj48 = lblMa_Nt;
		location = new Point(510, 96);
		((Control)obj48).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj49 = lblMa_Nt;
		size = new Size(36, 13);
		((Control)obj49).Size = size;
		((Control)lblMa_Nt).TabIndex = 226;
		lblMa_Nt.Text = "Tỷ giá";
		((Control)txtT_Thue).Anchor = (AnchorStyles)6;
		txtT_Thue.DecimalSymbol = ".";
		((Control)txtT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric5 = txtT_Thue;
		location = new Point(611, 386);
		((Control)asTextNumeric5).Location = location;
		txtT_Thue.Mask = "### ### ### ###";
		((Control)txtT_Thue).Name = "txtT_Thue";
		((TextBoxBase)txtT_Thue).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtT_Thue;
		size = new Size(100, 20);
		((Control)asTextNumeric6).Size = size;
		txtT_Thue.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Thue).TabIndex = 224;
		((Control)txtT_Thue).TabStop = false;
		((TextBox)txtT_Thue).Text = "0";
		((TextBox)txtT_Thue).TextAlign = (HorizontalAlignment)1;
		txtT_Thue.Value = 0.0;
		((Control)txtT_Tt).Anchor = (AnchorStyles)6;
		txtT_Tt.DecimalSymbol = ".";
		((Control)txtT_Tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric7 = txtT_Tt;
		location = new Point(611, 408);
		((Control)asTextNumeric7).Location = location;
		txtT_Tt.Mask = "### ### ### ###";
		((Control)txtT_Tt).Name = "txtT_Tt";
		((TextBoxBase)txtT_Tt).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_Tt;
		size = new Size(100, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_Tt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tt).TabIndex = 225;
		((Control)txtT_Tt).TabStop = false;
		((TextBox)txtT_Tt).Text = "0";
		((TextBox)txtT_Tt).TextAlign = (HorizontalAlignment)1;
		txtT_Tt.Value = 0.0;
		((Control)txtT_tien_Nt).Anchor = (AnchorStyles)6;
		txtT_tien_Nt.DecimalSymbol = ".";
		((Control)txtT_tien_Nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric9 = txtT_tien_Nt;
		location = new Point(508, 364);
		((Control)asTextNumeric9).Location = location;
		txtT_tien_Nt.Mask = "### ### ### ###.##";
		((Control)txtT_tien_Nt).Name = "txtT_tien_Nt";
		((TextBoxBase)txtT_tien_Nt).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtT_tien_Nt;
		size = new Size(100, 20);
		((Control)asTextNumeric10).Size = size;
		txtT_tien_Nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tien_Nt).TabIndex = 107;
		((Control)txtT_tien_Nt).TabStop = false;
		((TextBox)txtT_tien_Nt).Text = "0.00";
		((TextBox)txtT_tien_Nt).TextAlign = (HorizontalAlignment)1;
		txtT_tien_Nt.Value = 0.0;
		((Control)lblT_Thue).Anchor = (AnchorStyles)6;
		((Control)lblT_Thue).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Thue.ImeMode = (ImeMode)0;
		Label obj50 = lblT_Thue;
		location = new Point(342, 389);
		((Control)obj50).Location = location;
		((Control)lblT_Thue).Name = "lblT_Thue";
		Label obj51 = lblT_Thue;
		size = new Size(161, 13);
		((Control)obj51).Size = size;
		((Control)lblT_Thue).TabIndex = 226;
		lblT_Thue.Text = "Thuế GTGT";
		((Control)lblT_Tt).Anchor = (AnchorStyles)6;
		((Control)lblT_Tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Tt.ImeMode = (ImeMode)0;
		Label obj52 = lblT_Tt;
		location = new Point(342, 411);
		((Control)obj52).Location = location;
		((Control)lblT_Tt).Name = "lblT_Tt";
		Label obj53 = lblT_Tt;
		size = new Size(161, 13);
		((Control)obj53).Size = size;
		((Control)lblT_Tt).TabIndex = 227;
		lblT_Tt.Text = "Thanh toán";
		((Control)txtT_thue_Nt).Anchor = (AnchorStyles)6;
		txtT_thue_Nt.DecimalSymbol = ".";
		((Control)txtT_thue_Nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric11 = txtT_thue_Nt;
		location = new Point(508, 386);
		((Control)asTextNumeric11).Location = location;
		txtT_thue_Nt.Mask = "### ### ### ###.##";
		((Control)txtT_thue_Nt).Name = "txtT_thue_Nt";
		((TextBoxBase)txtT_thue_Nt).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtT_thue_Nt;
		size = new Size(100, 20);
		((Control)asTextNumeric12).Size = size;
		txtT_thue_Nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_thue_Nt).TabIndex = 228;
		((Control)txtT_thue_Nt).TabStop = false;
		((TextBox)txtT_thue_Nt).Text = "0.00";
		((TextBox)txtT_thue_Nt).TextAlign = (HorizontalAlignment)1;
		txtT_thue_Nt.Value = 0.0;
		((Control)txtT_tt_Nt).Anchor = (AnchorStyles)6;
		txtT_tt_Nt.DecimalSymbol = ".";
		((Control)txtT_tt_Nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric13 = txtT_tt_Nt;
		location = new Point(508, 408);
		((Control)asTextNumeric13).Location = location;
		txtT_tt_Nt.Mask = "### ### ### ###.##";
		((Control)txtT_tt_Nt).Name = "txtT_tt_Nt";
		((TextBoxBase)txtT_tt_Nt).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtT_tt_Nt;
		size = new Size(100, 20);
		((Control)asTextNumeric14).Size = size;
		txtT_tt_Nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tt_Nt).TabIndex = 229;
		((Control)txtT_tt_Nt).TabStop = false;
		((TextBox)txtT_tt_Nt).Text = "0.00";
		((TextBox)txtT_tt_Nt).TextAlign = (HorizontalAlignment)1;
		txtT_tt_Nt.Value = 0.0;
		((Control)chkTg_gs_dd).Anchor = (AnchorStyles)6;
		((ButtonBase)chkTg_gs_dd).AutoSize = true;
		((Control)chkTg_gs_dd).Enabled = false;
		CheckBox obj54 = chkTg_gs_dd;
		location = new Point(9, 366);
		((Control)obj54).Location = location;
		((Control)chkTg_gs_dd).Name = "chkTg_gs_dd";
		CheckBox obj55 = chkTg_gs_dd;
		size = new Size(139, 17);
		((Control)obj55).Size = size;
		((Control)chkTg_gs_dd).TabIndex = 230;
		((ButtonBase)chkTg_gs_dd).Text = "Tỷ giá ghi sổ đích danh";
		((Control)chkTg_gs_dd).Visible = false;
		((Control)btnVAT_NK).Anchor = (AnchorStyles)6;
		Button obj56 = btnVAT_NK;
		location = new Point(149, 434);
		((Control)obj56).Location = location;
		((Control)btnVAT_NK).Name = "btnVAT_NK";
		Button obj57 = btnVAT_NK;
		size = new Size(64, 23);
		((Control)obj57).Size = size;
		((Control)btnVAT_NK).TabIndex = 4;
		((ButtonBase)btnVAT_NK).Text = "&VAT NK";
		size = new Size(720, 483);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)btnVAT_NK);
		((Control)this).Controls.Add((Control)(object)chkTg_gs_dd);
		((Control)this).Controls.Add((Control)(object)txtT_tt_Nt);
		((Control)this).Controls.Add((Control)(object)txtT_thue_Nt);
		((Control)this).Controls.Add((Control)(object)lblT_Tt);
		((Control)this).Controls.Add((Control)(object)lblT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_Tt);
		((Control)this).Controls.Add((Control)(object)txtT_Thue);
		((Control)this).Controls.Add((Control)(object)txtT_Tien);
		((Control)this).Controls.Add((Control)(object)lblT_Tien);
		((Control)this).Controls.Add((Control)(object)txtT_tien_Nt);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmCaVchCA2";
		((Form)this).Text = "frmCA2Input";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tien_Nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Thue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_thue_Nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt_Nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkTg_gs_dd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)btnVAT_NK, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
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
		((Control)tabTax).ResumeLayout(false);
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
			}
			ctlTaIn.Ma_Nt = cboMa_NT.MA_NT;
		}
	}

	private void txtMa_Kh_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if ((base.ActionMode == Commons.ApplicationMode.VIEW_MODE || ((TextBoxBase)txtMa_Kh).ReadOnly || !((Control)txtMa_Kh).Enabled || !((Control)txtMa_Kh).Visible || e.ValidatedRow == null) ? true : false)
		{
			return;
		}
		txtDia_chi.Text = Conversions.ToString(e.ValidatedRow["dia_chi"]);
		txtNguoi_Gd.Text = Conversions.ToString(e.ValidatedRow["nguoi_gd"]);
		if (((DataGridView)adgvDetail).RowCount == 1)
		{
			DataRow pDrw = default(DataRow);
			DataRow pDrw2 = default(DataRow);
			if ((base.ActionMode == Commons.ApplicationMode.ADD_MODE && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_httt_po"]), isNum: false), (object)"", false) && Commons.ValidMa(ref pDrw, "MA_HTTT", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_httt_po"]), isNum: false)), "moduleid='PO'", "tk", pSd: true) && pDrw != null && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(pDrw["tk"]), isNum: false), (object)"", false) && Commons.ValidMa(ref pDrw2, "TK", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(pDrw["tk"]), isNum: false)), "chi_tiet=1", "ten_tk,tk_cn", pSd: true)) ? true : false)
			{
				((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTk).Name, 0].Value = RuntimeHelpers.GetObjectValue(pDrw["Tk"]);
				((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTen_tk).Name, 0].Value = RuntimeHelpers.GetObjectValue(pDrw2["ten_tk"]);
				base.CT1Voucher[0]["tk_cn"] = RuntimeHelpers.GetObjectValue(pDrw2["tk_cn"]);
			}
			((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_kh).Name, 0].Value = ((TextBox)txtMa_Kh).Text;
			((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTen_kh).Name, 0].Value = lblTen_Kh.Text;
		}
	}

	private void txtTy_gia_ValueChanged(object sender, EventArgs e)
	{
		if ((base.IsLoading || IsValidateCalledFromValidData || CT1Voucher == null || CT1Voucher.Count == 0) ? true : false)
		{
			return;
		}
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			DataRowView dataRowView = null;
			foreach (DataRowView item in CT1Voucher)
			{
				DataRowView dataRowView2 = item;
				Type? typeFromHandle = typeof(Math);
				object[] array = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["ps_no_nt"]), isNum: true), txtTy_gia.Value),
					null,
					null
				};
				SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
				array[1] = sIConfiguration.Round;
				array[2] = MidpointRounding.AwayFromZero;
				object[] array2 = array;
				bool[] array3 = new bool[3] { false, true, false };
				object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
				if (array3[1])
				{
					sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
				}
				dataRowView2["ps_no"] = RuntimeHelpers.GetObjectValue(obj);
			}
			UpdateList();
		}
		ctlTaIn.Ty_Gia = Conversions.ToDouble(txtTy_gia.Value);
	}

	private void txtDien_giai_Validated(object sender, EventArgs e)
	{
		if ((((DataGridView)adgvDetail).RowCount == 1 && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcDien_giai).Name, 0].Value), isNum: false), (object)"", false)) ? true : false)
		{
			((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcDien_giai).Name, 0].Value = txtDien_giai.Text;
		}
	}

	private void adgvDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if ((CTTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			bool flag = true;
			DataRowView oDv = CT1Voucher[e.RowIndex];
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcPs_no_nt).Name, false) == 0)
			{
				V_Ps_No_Nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcPs_no).Name, false) == 0)
			{
				V_Ps_No(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kh).Name, false) == 0 || Operators.CompareString(name, ((DataGridViewColumn)dgvcTk).Name, false) == 0)
			{
				V_Ma_KhI(oDv);
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
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_bp).Name, false) == 0)
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
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_ku).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Ku"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_spct).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Spct"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kh).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_kh"]);
			}
			obj = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(obj), isNum: false));
			SetInfoStatusBar(Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(obj, (object)"", false), (object)frmVoucher.BASEVOUCHER_INPUTGRID_TIP_TEXT, RuntimeHelpers.GetObjectValue(obj))), SystemColors.ControlText);
		}
	}

	private void ctlTaIn_TAINValueChanged(object sender, EventArgs e)
	{
		UpdateList();
	}

	private void txtTk_Co_Validated(object sender, EventArgs e)
	{
		ctlTaIn.Tk_Du = ((TextBox)txtTk_Co).Text;
	}

	private void cmdGetTaInFromDetail_Click(object sender, EventArgs e)
	{
		GetTaInFromDetail();
		UpdateList();
	}

	private void btnVAT_NK_Click(object sender, EventArgs e)
	{
		if (base.CurrentPHRowView != null && ActionMode == Commons.ApplicationMode.VIEW_MODE)
		{
			GetDataToKeThueVATNK();
		}
	}

	private void RefreshValueByMa_Nt()
	{
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) != 0)
		{
			return;
		}
		DataRowView dataRowView = null;
		foreach (DataRowView item in CT1Voucher)
		{
			DataRowView dataRowView2 = item;
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["ps_no_nt"]), isNum: true)),
				null,
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array2 = array;
			bool[] array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			dataRowView2["ps_no_nt"] = RuntimeHelpers.GetObjectValue(obj);
		}
	}

	private void GetDataToKeThueVATNK()
	{
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object[] arg = new object[1] { base.MyVoucherInfo };
			CaVchCA2DAO caVchCA2DAO = (CaVchCA2DAO)DAOFactory.CreateDAOInstance("CaVchCA2DAO", "CAVchCA2", arg);
			DataTable dataToKeThueVATNK = caVchCA2DAO.GetDataToKeThueVATNK(CompanyInformations.CompanyID, Conversions.ToString(CurrentPHRowView["stt_rec"]));
			if (dataToKeThueVATNK == null || dataToKeThueVATNK.Rows.Count <= 0)
			{
				caVchCA2DAO.Destroy();
				CMessageBox.Show(50170);
				return;
			}
			frmCaVchCa2FindPO7TAIN frmCaVchCa2FindPO7TAIN2 = new frmCaVchCa2FindPO7TAIN();
			frmCaVchCa2FindPO7TAIN2.bsTain.DataSource = dataToKeThueVATNK;
			frmCaVchCa2FindPO7TAIN2.txtT_tt_Nt.Value = RuntimeHelpers.GetObjectValue(base.CurrentPHRowView["t_tt_nt"]);
			((Form)frmCaVchCa2FindPO7TAIN2).ShowDialog();
			if (!frmCaVchCa2FindPO7TAIN2.is_ok)
			{
				return;
			}
			if (dataToKeThueVATNK.GetChanges() != null)
			{
				foreach (DataRow row in dataToKeThueVATNK.GetChanges().Rows)
				{
					row["stt_rec_pc"] = RuntimeHelpers.GetObjectValue(CurrentPHRowView["stt_rec"]);
					row["ngay_ct"] = RuntimeHelpers.GetObjectValue(CurrentPHRowView["ngay_ct"]);
					caVchCA2DAO.UpdateToKeThueVATNK(row);
				}
			}
			caVchCA2DAO.Destroy();
			CMessageBox.Show(50015);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			CMessageBox.Show(50010);
			ProjectData.ClearProjectError();
		}
	}

	private void V_Ps_No_Nt(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ps_no_nt"]), isNum: true), txtTy_gia.Value),
				null,
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array2 = array;
			bool[] array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			oDv["ps_no"] = RuntimeHelpers.GetObjectValue(obj);
		}
		UpdateList();
	}

	private void V_Ps_No(DataRowView oDv)
	{
		UpdateList();
	}

	private void V_Ma_KhI(DataRowView oDv)
	{
		RefreshDu13(oDv);
	}

	private void GetTaInFromDetail()
	{
		if ((base.Tain1Voucher != null && base.Tain1Voucher.Count > 0) ? true : false)
		{
			if (1 == 0)
			{
				return;
			}
			foreach (DataRowView item in base.Tain1Voucher)
			{
				item.Delete();
			}
		}
		DataRow dataRow = base.TAINTable.NewRow();
		dataRow["ma_cty"] = CompanyInformations.CompanyID;
		dataRow["stt_rec"] = RuntimeHelpers.GetObjectValue(base.CurrentPHRow["stt_rec"]);
		dataRow["stt_rec0"] = Commons.Get_SttRec0(Conversions.ToString(base.CurrentPHRow["stt_rec"]), base.TAINTable);
		dataRow["ma_nt"] = cboMa_NT.MA_NT;
		dataRow["ty_gia"] = RuntimeHelpers.GetObjectValue(txtTy_gia.Value);
		dataRow["tk_thue_no"] = ctlTaIn.Tk_Thue;
		dataRow["Tk_Du"] = ctlTaIn.Tk_Du;
		dataRow["ma_kh"] = ((TextBox)txtMa_Kh).Text.Trim();
		DataRow pDrw = null;
		Commons.ValidMa(ref pDrw, "MA_KH", ((TextBox)txtMa_Kh).Text.Trim(), "", "ten_kh,dia_chi,ma_so_thue", pSd: true);
		if (pDrw != null)
		{
			dataRow["ten_kh"] = RuntimeHelpers.GetObjectValue(pDrw["ten_kh"]);
			dataRow["dia_chi"] = RuntimeHelpers.GetObjectValue(pDrw["dia_chi"]);
			dataRow["ma_so_thue"] = RuntimeHelpers.GetObjectValue(pDrw["ma_so_thue"]);
		}
		dataRow["ten_vt"] = txtDien_giai.Text.Trim();
		dataRow["tien_hang_nt"] = RuntimeHelpers.GetObjectValue(txtT_tien_Nt.Value);
		dataRow["tien_hang"] = RuntimeHelpers.GetObjectValue(txtT_Tien.Value);
		dataRow["t_tien_nt"] = RuntimeHelpers.GetObjectValue(txtT_tien_Nt.Value);
		dataRow["t_tien"] = RuntimeHelpers.GetObjectValue(txtT_Tien.Value);
		base.TAINTable.Rows.Add(dataRow);
	}

	private void RefreshDu13(DataRowView odv)
	{
		if ((Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["ma_kh"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["tk"]), isNum: false), (object)"", false) && odv["Tk_Cn"] != DBNull.Value && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(odv["Tk_Cn"]), isNum: true), (object)true, false)) ? true : false)
		{
			odv["Du13"] = Commons.GetDuArkh(Conversions.ToString(odv["ma_kh"]), Conversions.ToString(odv["tk"]), Conversions.ToDate(txtNgay_Ct.Value));
		}
		else
		{
			odv["Du13"] = 0;
		}
		((DataGridView)dgvDetail).AutoResizeColumn(((DataGridViewBand)dgvcDu13).Index);
	}

	protected override void RefreshDGVInput()
	{
		base.RefreshDGVInput();
		if (CTTable == null)
		{
			return;
		}
		bool visible = false;
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			txtTy_gia.Value = 1;
			((TextBoxBase)txtTy_gia).ReadOnly = true;
			((Control)txtTy_gia).TabStop = false;
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				txtTy_gia_ValueChanged(null, null);
			}
		}
		else
		{
			visible = true;
			((TextBoxBase)txtTy_gia).ReadOnly = ActionMode == Commons.ApplicationMode.VIEW_MODE;
			((Control)txtTy_gia).TabStop = true;
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				txtTy_gia.Value = Commons.Get_TyGia(cboMa_NT.MA_NT, Conversions.ToDate(txtNgay_Ct.Value));
				txtTy_gia_ValueChanged(null, null);
			}
		}
		((DataGridViewColumn)dgvcPs_no).Visible = visible;
		((Control)txtT_Tien).Visible = visible;
		((Control)txtT_Thue).Visible = visible;
		((Control)txtT_Tt).Visible = visible;
		((DataGridViewColumn)dgvcPs_no_nt).HeaderText = f_sPs_no_header + " " + cboMa_NT.MA_NT;
	}

	protected override void SetFocus4FirstEditControl()
	{
		((Control)txtMa_Kh).Focus();
	}

	protected override void UpdateList()
	{
		if (base.CurrentPHRow != null)
		{
			string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
			txtT_tien_Nt.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(ps_no_nt)", filter));
			txtT_thue_Nt.Value = ctlTaIn.get_T_Thue_Nt("");
			txtT_tt_Nt.Value = Operators.AddObject(txtT_tien_Nt.Value, txtT_thue_Nt.Value);
			txtT_Tien.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(ps_no)", filter));
			txtT_Thue.Value = ctlTaIn.get_T_Thue("");
			txtT_Tt.Value = Operators.AddObject(txtT_Tien.Value, txtT_Thue.Value);
		}
	}

	protected override bool ValidData()
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		bool flag2 = false;
		checked
		{
			if ((ChkEmtyTextBox((TextBox)(object)txtMa_Kh) && ChkEmtyTextBox((TextBox)(object)txtTk_Co) && base.ValidData() && ctlTaIn.ValidData()) ? true : false)
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
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk"]), isNum: false), (object)"", false))
					{
						CMessageBox.Show(50018);
						((Control)adgvDetail).Select();
						((DataGridView)adgvDetail).CurrentCell = ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTk).Name, num2];
						return false;
					}
					if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_Cn"]), isNum: false), (object)"1", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Kh"]), isNum: false), (object)"", false)) ? true : false)
					{
						CMessageBox.Show(50092);
						((Control)adgvDetail).Select();
						((DataGridView)adgvDetail).CurrentCell = ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_kh).Name, num2];
						return false;
					}
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_No_Nt"]), isNum: true), (object)0, false))
					{
						CMessageBox.Show(50018);
						((Control)adgvDetail).Select();
						((DataGridView)adgvDetail).CurrentCell = ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcPs_no_nt).Name, num2];
						return false;
					}
					if ((Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_No"]), isNum: true), (object)0, false)) ? true : false)
					{
						CMessageBox.Show(50018);
						((Control)adgvDetail).Select();
						((DataGridView)adgvDetail).CurrentCell = ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcPs_no).Name, num2];
						return false;
					}
					if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_Cn"]), isNum: false), (object)"1", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Kh"]), isNum: false), (object)"", false)) ? true : false)
					{
						CMessageBox.Show(50092);
						((Control)adgvDetail).Select();
						((DataGridView)adgvDetail).CurrentCell = ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_kh).Name, num2];
						return false;
					}
					if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh, isNum: false), (object)"0", false))
					{
						bool flag3 = (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh, isNum: false), (object)"1", false) ? true : false);
						double num5 = Conversions.ToDouble(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_toi_da, isNum: true));
						double num6 = Conversions.ToDouble(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_tien_nt_toi_da, isNum: true));
						if ((Operators.ConditionalCompareObjectNotEqual(((ListControl)cboMa_NT).SelectedValue, (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) && Operators.ConditionalCompareObjectGreater(txtTy_gia.Value, (object)0, false)) ? true : false)
						{
							double num7 = 0.0;
							Type? typeFromHandle = typeof(Math);
							object[] array = new object[3]
							{
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_No_nt"]), isNum: true), txtTy_gia.Value),
								null,
								null
							};
							SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
							array[1] = sIConfiguration.Round;
							array[2] = MidpointRounding.AwayFromZero;
							object[] array2 = array;
							object[] array3 = array2;
							bool[] array4 = new bool[3] { false, true, false };
							object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array3, (string[])null, (Type[])null, array4);
							if (array4[1])
							{
								sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
							}
							num7 = Conversions.ToDouble(obj);
							if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_No"]), isNum: true), (object)num7) }, (string[])null, (Type[])null, (bool[])null), (object)num5, false))
							{
								((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcPs_no).Name, num2].ErrorText = Helper.GetMessContent(50047);
								flag = flag3;
								flag2 = true;
							}
						}
					}
					num2++;
				}
				if ((flag2 && Operators.CompareString(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh, "0", false) != 0) ? true : false)
				{
					CMessageBox.Show(50047);
				}
				if (!flag)
				{
					return false;
				}
				return true;
			}
			return false;
		}
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
			ctlTaIn.adgvTaIn.ReadOnly = false;
		}
		else
		{
			ctlTaIn.adgvTaIn.ReadOnly = true;
		}
		ctlTaIn.UpdateList();
		((Control)btnVAT_NK).Enabled = Conversions.ToBoolean(Interaction.IIf(ActionMode == Commons.ApplicationMode.VIEW_MODE, (object)true, (object)false));
	}

	protected override void PHDataBinding()
	{
		base.PHDataBinding();
		CreateDataBinding((Control)(object)txtMa_Kh, "Ma_Kh");
		CreateDataBinding((Control)(object)lblTen_Kh, "Ten_Kh");
		CreateDataBinding((Control)(object)txtDia_chi, "Dia_chi");
		CreateDataBinding((Control)(object)txtNguoi_Gd, "Nguoi_Gd");
		CreateDataBinding((Control)(object)txtDien_giai, "Dien_Giai");
		CreateDataBinding((Control)(object)txtTk_Co, "tk_co");
		CreateDataBinding((Control)(object)lblTen_Tk_Co, "ten_tk_co");
		CreateDataBinding((Control)(object)txtNgay_Ct, "ngay_ct", "Value");
		CreateDataBinding((Control)(object)txtSo_Ct, "so_ct");
		CreateDataBinding((Control)(object)txtNgay_lct, "ngay_lct", "Value");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtT_tien_Nt, "t_tien_nt", "Value");
		CreateDataBinding((Control)(object)txtT_thue_Nt, "t_thue_nt", "Value");
		CreateDataBinding((Control)(object)txtT_tt_Nt, "t_tt_nt", "Value");
		CreateDataBinding((Control)(object)txtT_Tien, "t_tien", "Value");
		CreateDataBinding((Control)(object)txtT_Thue, "t_thue", "Value");
		CreateDataBinding((Control)(object)txtT_Tt, "t_tt", "Value");
		CreateDataBinding((Control)(object)ctlTaIn.chkKe_tain, "kht_tain", "Checked");
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		ctlTaIn.TAINTable = base.TAINTable;
		f_sPs_no_header = ((DataGridViewColumn)dgvcPs_no_nt).HeaderText;
		((DataGridViewColumn)dgvcPs_no).HeaderText = f_sPs_no_header + " " + AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tien_Nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_thue_Nt);
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tt_Nt);
		AddControl2ListOfDrivedControls((Control)(object)cmdGetTaInFromDetail);
		AddControl2ListOfDrivedControls((Control)(object)ctlTaIn.chkKe_tain);
	}

	protected override void SetReportDataSource(DataRow odrPrintPHRow)
	{
		base.SetReportDataSource(odrPrintPHRow);
		int num = 0;
		AsDictionary asDictionary = new AsDictionary();
		num = 0;
		string filterExpression = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", odrPrintPHRow["Stt_Rec"]), (object)"'"));
		DataRow[] array = base.CTTable.Select(filterExpression);
		checked
		{
			foreach (DataRow dataRow in array)
			{
				if (asDictionary.Contains(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Tk"]), isNum: false))))
				{
					AsDictionary myFomularFields = base.MyFomularFields;
					AsDictionary asDictionary2 = myFomularFields;
					object obj = asDictionary[RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Tk"]), isNum: false))];
					asDictionary2[RuntimeHelpers.GetObjectValue(obj)] = Operators.AddObject(myFomularFields[RuntimeHelpers.GetObjectValue(obj)], (object)Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Ps_no_Nt"]), isNum: true)));
				}
				else if (num < 6)
				{
					num++;
					asDictionary.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Tk"]), isNum: false)), "Ps_no" + num.ToString().Trim());
					base.MyFomularFields.Add("Tk_no" + num.ToString().Trim(), RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Tk"]), isNum: false)));
					base.MyFomularFields.Add("Ps_no" + num.ToString().Trim(), Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Ps_no_Nt"]), isNum: true)));
				}
			}
			DataRow[] array2 = base.TAINTable.Select(filterExpression);
			foreach (DataRow dataRow in array2)
			{
				if (asDictionary.Contains(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Tk_thue_no"]), isNum: false))))
				{
					AsDictionary myFomularFields = base.MyFomularFields;
					AsDictionary asDictionary3 = myFomularFields;
					object obj = asDictionary[RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Tk_thue_no"]), isNum: false))];
					asDictionary3[RuntimeHelpers.GetObjectValue(obj)] = Operators.AddObject(myFomularFields[RuntimeHelpers.GetObjectValue(obj)], (object)Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["t_thue_nt"]), isNum: true)));
				}
				else if (num < 6)
				{
					num++;
					asDictionary.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Tk_thue_no"]), isNum: false)), "Ps_no" + num.ToString().Trim());
					base.MyFomularFields.Add("Tk_no" + num.ToString().Trim(), RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Tk_thue_no"]), isNum: false)));
					base.MyFomularFields.Add("Ps_no" + num.ToString().Trim(), Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["t_thue_nt"]), isNum: true)));
				}
			}
			int num2 = num + 1;
			while (true)
			{
				int num3 = num2;
				int num4 = 6;
				if (num3 <= num4)
				{
					base.MyFomularFields.Add("Tk_no" + num2.ToString().Trim(), "");
					base.MyFomularFields.Add("Ps_no" + num2.ToString().Trim(), "");
					num2++;
					continue;
				}
				break;
			}
		}
	}

	protected void SetReportDataSource_(DataRow odrPrintPHRow)
	{
		int num = 0;
		AsDictionary asDictionary = new AsDictionary();
		num = 0;
		string amount_Input_Format = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		int num2 = 0;
		int num3 = 18;
		int num4 = 5;
		checked
		{
			foreach (DataRowView item in CT1Voucher)
			{
				if (num2 < Strings.Len(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tk"]), isNum: false))))
				{
					num2 = Strings.Len(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tk"]), isNum: false)));
				}
				if (asDictionary.Contains(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Me.f_oTblDM.Rows.CountTk"]), isNum: false))))
				{
					asDictionary[RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tk"]), isNum: false))] = Conversions.ToDouble(asDictionary[RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tk"]), isNum: false))]) + Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ps_no_Nt"]), isNum: true));
					continue;
				}
				num++;
				asDictionary.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Tk"]), isNum: false)), Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Ps_no_Nt"]), isNum: true)));
			}
			foreach (DataRowView item2 in Tain1Voucher)
			{
				if (num2 < Strings.Len(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tk_thue_no"]), isNum: false))))
				{
					num2 = Strings.Len(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tk_thue_no"]), isNum: false)));
				}
				if (asDictionary.Contains(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tk_thue_no"]), isNum: false))))
				{
					asDictionary[RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tk_thue_no"]), isNum: false))] = Conversions.ToDouble(asDictionary[RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tk_thue_no"]), isNum: false))]) + Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["t_thue_nt"]), isNum: true));
					continue;
				}
				num++;
				asDictionary.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["Tk_thue_no"]), isNum: false)), Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item2["t_thue_nt"]), isNum: true)));
			}
			if (num2 < Strings.Len(RuntimeHelpers.GetObjectValue(CurrentPHRow["Tk_co"])))
			{
				num2 = Strings.Len(RuntimeHelpers.GetObjectValue(CurrentPHRow["Tk_co"]));
			}
			num2 += 2;
			num3 = Conversions.ToDouble(CurrentPHRow["t_tt_nt"]).ToString(amount_Input_Format).Trim()
				.Length + 2;
			if (num3 < 10)
			{
				num3 = 10;
			}
			string text = "";
			string text2 = "Nợ:";
			string text3 = "";
			string text4 = "";
			IDictionaryEnumerator enumerator3 = asDictionary.GetEnumerator();
			DictionaryEntry dictionaryEntry2 = default(DictionaryEntry);
			while (enumerator3.MoveNext())
			{
				object current = enumerator3.Current;
				DictionaryEntry dictionaryEntry = ((current != null) ? ((DictionaryEntry)current) : dictionaryEntry2);
				text = Conversions.ToDouble(dictionaryEntry.Value).ToString(amount_Input_Format).Trim();
				text3 = text3 + dictionaryEntry.Key.ToString().Trim() + "\r\n";
				text4 = text4 + text + "\r\n";
				text2 += "\r\n";
			}
			text2 += "Có:";
			text = Conversions.ToDouble(CurrentPHRow["t_tt_nt"]).ToString(amount_Input_Format).Trim();
			text3 += CurrentPHRow["Tk_co"].ToString().Trim();
			text4 += text;
			base.MyFomularFields.Add("LstNoCo", text2.Replace("\r\n", "'Chr(13)'"));
			base.MyFomularFields.Add("LstTK", text3.Replace("\r\n", "'Chr(13)'"));
			base.MyFomularFields.Add("LstPS", text4.Replace("\r\n", "'Chr(13)'"));
		}
	}

	protected override void SetPHDefaultValues(DataRow drwPh)
	{
		base.SetPHDefaultValues(drwPh);
		drwPh["tk_co"] = AsiaErp.Framework.Environment.GetSiDMCTByMa_Ct(base.MyVoucherInfo.voucher_code).tk_co;
	}
}
