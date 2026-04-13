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
public class frmCaVchCA3 : frmVoucher
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("adgvDetail")]
	private AsInputDGV _adgvDetail;

	[AccessedThroughProperty("txtDia_chi")]
	private TextBox _txtDia_chi;

	[AccessedThroughProperty("lblDia_chi")]
	private Label _lblDia_chi;

	[AccessedThroughProperty("lblTk_No")]
	private Label _lblTk_No;

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

	[AccessedThroughProperty("lblTen_Tk_No")]
	private Label _lblTen_Tk_No;

	[AccessedThroughProperty("txtTk_No")]
	private AsTextBox _txtTk_No;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("txtNgay_lct")]
	private AsMaskedTextBox _txtNgay_lct;

	[AccessedThroughProperty("txtTy_gia")]
	private AsTextNumeric _txtTy_gia;

	[AccessedThroughProperty("cboMa_NT")]
	private AsComboBoxNT _cboMa_NT;

	[AccessedThroughProperty("lblMa_Nt")]
	private Label _lblMa_Nt;

	[AccessedThroughProperty("txtT_Tien")]
	private AsTextNumeric _txtT_Tien;

	[AccessedThroughProperty("txtT_tien_Nt")]
	private AsTextNumeric _txtT_tien_Nt;

	[AccessedThroughProperty("lblT_Tien")]
	private Label _lblT_Tien;

	[AccessedThroughProperty("chkTg_gs_dd")]
	private CheckBox _chkTg_gs_dd;

	[AccessedThroughProperty("dgvcTk")]
	private DataGridViewAsTextBoxColumn _dgvcTk;

	[AccessedThroughProperty("dgvcTen_tk")]
	private DataGridViewTextBoxColumn _dgvcTen_tk;

	[AccessedThroughProperty("dgvcPs_co_nt")]
	private DataGridViewAsTextNumericColumn _dgvcPs_co_nt;

	[AccessedThroughProperty("dgvcPs_co")]
	private DataGridViewAsTextNumericColumn _dgvcPs_co;

	[AccessedThroughProperty("dgvcMa_kh")]
	private DataGridViewAsTextBoxColumn _dgvcMa_kh;

	[AccessedThroughProperty("dgvcTen_kh")]
	private DataGridViewTextBoxColumn _dgvcTen_kh;

	[AccessedThroughProperty("dgvcDu13")]
	private DataGridViewTextBoxColumn _dgvcDu13;

	[AccessedThroughProperty("dgvcDien_giai")]
	private DataGridViewTextBoxColumn _dgvcDien_giai;

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

	private string f_sPs_co_header;

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
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvDetail_CellValueChanged);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvDetail_CellEnter);
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellValueChanged -= val;
				((DataGridView)_adgvDetail).CellEnter -= val2;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellValueChanged += val;
				((DataGridView)_adgvDetail).CellEnter += val2;
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

	internal virtual Label lblTk_No
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_No;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_No = value;
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

	internal virtual Label lblTen_Tk_No
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_No;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_No = value;
		}
	}

	internal virtual AsTextBox txtTk_No
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_No;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_No = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvcPs_co_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPs_co_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPs_co_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcPs_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPs_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPs_co = value;
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

	public frmCaVchCA3(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_sPs_co_header = "Ps_co";
		InitializeComponent();
	}

	public frmCaVchCA3(string MenuID, string Stt_rec)
		: base(MenuID, Stt_rec)
	{
		__ENCAddToList(this);
		f_sPs_co_header = "Ps_co";
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
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Expected O, but got Unknown
		//IL_1d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d89: Expected O, but got Unknown
		//IL_1e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e91: Expected O, but got Unknown
		//IL_1f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f88: Expected O, but got Unknown
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
		adgvDetail = new AsInputDGV();
		dgvcTk = new DataGridViewAsTextBoxColumn();
		dgvcTen_tk = new DataGridViewTextBoxColumn();
		dgvcPs_co_nt = new DataGridViewAsTextNumericColumn();
		dgvcPs_co = new DataGridViewAsTextNumericColumn();
		dgvcMa_kh = new DataGridViewAsTextBoxColumn();
		dgvcTen_kh = new DataGridViewTextBoxColumn();
		dgvcDu13 = new DataGridViewTextBoxColumn();
		dgvcDien_giai = new DataGridViewTextBoxColumn();
		dgvcMa_bp = new DataGridViewAsTextBoxColumn();
		dgvcMa_phi = new DataGridViewAsTextBoxColumn();
		dgvcMa_hd = new DataGridViewAsTextBoxColumn();
		dgvcMa_ku = new DataGridViewAsTextBoxColumn();
		dgvcMa_spct = new DataGridViewAsTextBoxColumn();
		txtDia_chi = new TextBox();
		lblDia_chi = new Label();
		lblTk_No = new Label();
		txtDien_giai = new TextBox();
		txtNguoi_Gd = new TextBox();
		lblDien_giai = new Label();
		lblNgay_Lct = new Label();
		lblNguoi_Gd = new Label();
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblTen_Tk_No = new Label();
		txtTk_No = new AsTextBox();
		txtNgay_lct = new AsMaskedTextBox();
		txtTy_gia = new AsTextNumeric();
		cboMa_NT = new AsComboBoxNT();
		lblMa_Nt = new Label();
		txtT_Tien = new AsTextNumeric();
		txtT_tien_Nt = new AsTextNumeric();
		lblT_Tien = new Label();
		chkTg_gs_dd = new CheckBox();
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
		Point location = new Point(9, 412);
		((Control)obj).Location = location;
		Button obj2 = cmdPrint;
		location = new Point(79, 412);
		((Control)obj2).Location = location;
		Button obj3 = cmdLast;
		location = new Point(678, 412);
		((Control)obj3).Location = location;
		Button obj4 = cmdNext;
		location = new Point(655, 412);
		((Control)obj4).Location = location;
		Button obj5 = cmdPrevious;
		location = new Point(632, 412);
		((Control)obj5).Location = location;
		Button obj6 = cmdFirst;
		location = new Point(609, 412);
		((Control)obj6).Location = location;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)5;
		((MaskedTextBox)txtNgay_Ct).ReadOnly = true;
		((Control)txtNgay_Ct).TabIndex = 5;
		((Control)gbPH).BackColor = Color.Transparent;
		((Control)gbPH).Controls.Add((Control)(object)txtTy_gia);
		((Control)gbPH).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Nt);
		((Control)gbPH).Controls.Add((Control)(object)txtNgay_lct);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Tk_No);
		((Control)gbPH).Controls.Add((Control)(object)txtTk_No);
		((Control)gbPH).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbPH).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)lblMa_Kh);
		((Control)gbPH).Controls.Add((Control)(object)txtDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)lblDia_chi);
		((Control)gbPH).Controls.Add((Control)(object)lblTk_No);
		((Control)gbPH).Controls.Add((Control)(object)lblNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbPH).Controls.Add((Control)(object)lblNgay_Lct);
		((Control)gbPH).Controls.Add((Control)(object)txtNguoi_Gd);
		((Control)gbPH).Controls.Add((Control)(object)lblDien_giai);
		GroupBox obj7 = gbPH;
		Size size = new Size(694, 150);
		((Control)obj7).Size = size;
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDien_giai, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNguoi_Gd, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTk_No, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtDia_chi, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTk_No, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblTen_Tk_No, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTy_gia, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(527, 412);
		((Control)splitButton).Location = location;
		AsTabControl asTabControl = AsTabControl;
		location = new Point(7, 155);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(700, 228);
		((Control)asTabControl2).Size = size;
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj8 = tabDetail;
		size = new Size(692, 199);
		((Control)obj8).Size = size;
		TabPage obj9 = tabOptFields;
		size = new Size(692, 199);
		((Control)obj9).Size = size;
		Button obj10 = cmdCopy;
		location = new Point(289, 412);
		((Control)obj10).Location = location;
		Button obj11 = cmdDelete;
		location = new Point(219, 412);
		((Control)obj11).Location = location;
		Button obj12 = cmdEdit;
		location = new Point(149, 412);
		((Control)obj12).Location = location;
		((Control)txtSo_Ct).Anchor = (AnchorStyles)5;
		((TextBoxBase)txtSo_Ct).ReadOnly = true;
		((Control)txtSo_Ct).TabIndex = 6;
		((DataGridView)adgvDetail).AllowUserToAddRows = false;
		((DataGridView)adgvDetail).AllowUserToDeleteRows = false;
		((DataGridView)adgvDetail).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvDetail).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvDetail).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[13]
		{
			dgvcTk,
			(DataGridViewColumn)dgvcTen_tk,
			dgvcPs_co_nt,
			dgvcPs_co,
			dgvcMa_kh,
			(DataGridViewColumn)dgvcTen_kh,
			(DataGridViewColumn)dgvcDu13,
			(DataGridViewColumn)dgvcDien_giai,
			dgvcMa_bp,
			dgvcMa_phi,
			dgvcMa_hd,
			dgvcMa_ku,
			dgvcMa_spct
		});
		((Control)adgvDetail).Dock = (DockStyle)5;
		((DataGridView)adgvDetail).GridColor = SystemColors.Control;
		adgvDetail.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV = adgvDetail;
		location = new Point(3, 3);
		((Control)asInputDGV).Location = location;
		((Control)adgvDetail).Name = "adgvDetail";
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail).RowHeadersDefaultCellStyle = val;
		((DataGridView)adgvDetail).RowTemplate.Height = 20;
		((DataGridView)adgvDetail).ShowEditingIcon = false;
		((DataGridView)adgvDetail).ShowRowErrors = false;
		AsInputDGV asInputDGV2 = adgvDetail;
		size = new Size(686, 193);
		((Control)asInputDGV2).Size = size;
		((Control)adgvDetail).TabIndex = 1;
		dgvcTk.AutoFill = true;
		dgvcTk.AutoLookup = true;
		dgvcTk.AutoValid = true;
		((DataGridViewColumn)dgvcTk).DataPropertyName = "tk";
		val2.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk).DefaultCellStyle = val2;
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
		((DataGridViewColumn)dgvcPs_co_nt).DataPropertyName = "ps_co_nt";
		val3.Alignment = (DataGridViewContentAlignment)64;
		val3.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_co_nt).DefaultCellStyle = val3;
		((DataGridViewColumn)dgvcPs_co_nt).HeaderText = "Ps có";
		dgvcPs_co_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_co_nt).Name = "dgvcPs_co_nt";
		dgvcPs_co_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcPs_co_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcPs_co).DataPropertyName = "ps_co";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_co).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcPs_co).HeaderText = "Ps có VNĐ";
		dgvcPs_co.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_co).Name = "dgvcPs_co";
		dgvcPs_co.SortMode = (DataGridViewColumnSortMode)0;
		dgvcPs_co.SpecialType = Commons.NumericSpecialType.ACAmount;
		dgvcMa_kh.AutoFill = true;
		dgvcMa_kh.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_kh).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_kh.AutoValid = true;
		((DataGridViewColumn)dgvcMa_kh).DataPropertyName = "ma_kh";
		val5.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_kh).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcMa_kh).HeaderText = "Mã KH";
		dgvcMa_kh.LookupCodeName = "MA_KH";
		dgvcMa_kh.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_kh).Name = "dgvcMa_kh";
		dgvcMa_kh.ReceiverValidFieldList = "ten_kh";
		dgvcMa_kh.SD = true;
		dgvcMa_kh.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_kh.ValidReturnFieldList = "ten_kh";
		((DataGridViewColumn)dgvcMa_kh).Width = 46;
		((DataGridViewColumn)dgvcTen_kh).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcTen_kh).DataPropertyName = "ten_kh";
		((DataGridViewColumn)dgvcTen_kh).HeaderText = "Tên khách";
		((DataGridViewColumn)dgvcTen_kh).Name = "dgvcTen_kh";
		((DataGridViewColumn)dgvcTen_kh).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_kh).Width = 84;
		((DataGridViewColumn)dgvcDu13).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcDu13).DataPropertyName = "du13";
		val6.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcDu13).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcDu13).HeaderText = "Dư";
		((DataGridViewColumn)dgvcDu13).Name = "dgvcDu13";
		((DataGridViewColumn)dgvcDu13).ReadOnly = true;
		((DataGridViewColumn)dgvcDu13).Width = 46;
		((DataGridViewColumn)dgvcDien_giai).DataPropertyName = "dien_giai";
		((DataGridViewColumn)dgvcDien_giai).HeaderText = "Diễn giải";
		dgvcDien_giai.MaxInputLength = 128;
		((DataGridViewColumn)dgvcDien_giai).Name = "dgvcDien_giai";
		((DataGridViewColumn)dgvcDien_giai).Resizable = (DataGridViewTriState)1;
		dgvcDien_giai.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcDien_giai).Width = 150;
		dgvcMa_bp.AutoFill = true;
		dgvcMa_bp.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_bp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_bp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_bp).DataPropertyName = "ma_bp";
		val7.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_bp).DefaultCellStyle = val7;
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
		val8.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_phi).DefaultCellStyle = val8;
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
		val9.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_hd).DefaultCellStyle = val9;
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
		val10.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_ku).DefaultCellStyle = val10;
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
		val11.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_spct).DefaultCellStyle = val11;
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
		TextBox obj13 = txtDia_chi;
		location = new Point(110, 39);
		((Control)obj13).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		((TextBoxBase)txtDia_chi).ReadOnly = true;
		TextBox obj14 = txtDia_chi;
		size = new Size(330, 20);
		((Control)obj14).Size = size;
		((Control)txtDia_chi).TabIndex = 1;
		((Control)lblDia_chi).Anchor = (AnchorStyles)7;
		lblDia_chi.ImeMode = (ImeMode)0;
		Label obj15 = lblDia_chi;
		location = new Point(6, 42);
		((Control)obj15).Location = location;
		((Control)lblDia_chi).Name = "lblDia_chi";
		Label obj16 = lblDia_chi;
		size = new Size(98, 15);
		((Control)obj16).Size = size;
		((Control)lblDia_chi).TabIndex = 108;
		lblDia_chi.Text = "Địa chỉ";
		((Control)lblTk_No).Anchor = (AnchorStyles)7;
		lblTk_No.ImeMode = (ImeMode)0;
		Label obj17 = lblTk_No;
		location = new Point(6, 120);
		((Control)obj17).Location = location;
		((Control)lblTk_No).Name = "lblTk_No";
		Label obj18 = lblTk_No;
		size = new Size(98, 14);
		((Control)obj18).Size = size;
		((Control)lblTk_No).TabIndex = 114;
		lblTk_No.Text = "Tài khoản nợ";
		((Control)txtDien_giai).Anchor = (AnchorStyles)7;
		TextBox obj19 = txtDien_giai;
		location = new Point(110, 91);
		((Control)obj19).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		((TextBoxBase)txtDien_giai).ReadOnly = true;
		TextBox obj20 = txtDien_giai;
		size = new Size(330, 20);
		((Control)obj20).Size = size;
		((Control)txtDien_giai).TabIndex = 3;
		((Control)txtNguoi_Gd).Anchor = (AnchorStyles)7;
		TextBox obj21 = txtNguoi_Gd;
		location = new Point(110, 65);
		((Control)obj21).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		((TextBoxBase)txtNguoi_Gd).ReadOnly = true;
		TextBox obj22 = txtNguoi_Gd;
		size = new Size(112, 20);
		((Control)obj22).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 2;
		((Control)lblDien_giai).Anchor = (AnchorStyles)7;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj23 = lblDien_giai;
		location = new Point(6, 94);
		((Control)obj23).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj24 = lblDien_giai;
		size = new Size(98, 15);
		((Control)obj24).Size = size;
		((Control)lblDien_giai).TabIndex = 112;
		lblDien_giai.Text = "Diễn giải";
		lblNgay_Lct.ImeMode = (ImeMode)0;
		Label obj25 = lblNgay_Lct;
		location = new Point(496, 69);
		((Control)obj25).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj26 = lblNgay_Lct;
		size = new Size(56, 15);
		((Control)obj26).Size = size;
		((Control)lblNgay_Lct).TabIndex = 115;
		lblNgay_Lct.Text = "Ngày lập";
		((Control)lblNguoi_Gd).Anchor = (AnchorStyles)7;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj27 = lblNguoi_Gd;
		location = new Point(6, 68);
		((Control)obj27).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj28 = lblNguoi_Gd;
		size = new Size(98, 14);
		((Control)obj28).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 110;
		lblNguoi_Gd.Text = "Người giao dịch";
		((Control)lblTen_Kh).Anchor = (AnchorStyles)7;
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj29 = lblTen_Kh;
		location = new Point(191, 17);
		((Control)obj29).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj30 = lblTen_Kh;
		size = new Size(258, 13);
		((Control)obj30).Size = size;
		((Control)lblTen_Kh).TabIndex = 137;
		((Control)txtMa_Kh).Anchor = (AnchorStyles)7;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Control;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(110, 13);
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
		txtMa_Kh.ValidReturnFieldList = "ten_kh,dia_chi,nguoi_gd,ma_httt";
		((Control)lblMa_Kh).Anchor = (AnchorStyles)7;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj31 = lblMa_Kh;
		location = new Point(6, 17);
		((Control)obj31).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj32 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj32).Size = size;
		((Control)lblMa_Kh).TabIndex = 136;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		((Control)lblTen_Tk_No).Anchor = (AnchorStyles)7;
		lblTen_Tk_No.ImeMode = (ImeMode)0;
		Label obj33 = lblTen_Tk_No;
		location = new Point(194, 121);
		((Control)obj33).Location = location;
		((Control)lblTen_Tk_No).Name = "lblTen_Tk_No";
		Label obj34 = lblTen_Tk_No;
		size = new Size(258, 13);
		((Control)obj34).Size = size;
		((Control)lblTen_Tk_No).TabIndex = 217;
		lblTen_Tk_No.TextAlign = (ContentAlignment)16;
		((Control)txtTk_No).Anchor = (AnchorStyles)7;
		txtTk_No.AutoLookup = true;
		txtTk_No.AutoValid = true;
		((TextBoxBase)txtTk_No).BackColor = SystemColors.Control;
		((TextBox)txtTk_No).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk_No;
		location = new Point(110, 117);
		((Control)asTextBox3).Location = location;
		txtTk_No.LookupCodeName = "TK";
		txtTk_No.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_No).Name = "txtTk_No";
		txtTk_No.NameControl = lblTen_Tk_No;
		((TextBoxBase)txtTk_No).ReadOnly = true;
		txtTk_No.SD = true;
		AsTextBox asTextBox4 = txtTk_No;
		size = new Size(75, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk_No).TabIndex = 4;
		txtTk_No.UseAutoCompleteSource = true;
		txtNgay_lct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_lct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_lct;
		location = new Point(604, 66);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_lct).Mask = "##/##/####";
		((Control)txtNgay_lct).Name = "txtNgay_lct";
		((MaskedTextBox)txtNgay_lct).PromptChar = ' ';
		((MaskedTextBox)txtNgay_lct).ReadOnly = true;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_lct;
		size = new Size(78, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_lct).TabIndex = 7;
		((MaskedTextBox)txtNgay_lct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_lct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTy_gia;
		location = new Point(613, 92);
		((Control)asTextNumeric).Location = location;
		txtTy_gia.Mask = "### ###.##";
		((Control)txtTy_gia).Name = "txtTy_gia";
		((TextBoxBase)txtTy_gia).ReadOnly = true;
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
		location = new Point(563, 92);
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
		location = new Point(496, 96);
		((Control)obj35).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj36 = lblMa_Nt;
		size = new Size(36, 13);
		((Control)obj36).Size = size;
		((Control)lblMa_Nt).TabIndex = 226;
		lblMa_Nt.Text = "Tỷ giá";
		((Control)txtT_Tien).Anchor = (AnchorStyles)6;
		txtT_Tien.DecimalSymbol = ".";
		((Control)txtT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtT_Tien;
		location = new Point(608, 383);
		((Control)asTextNumeric3).Location = location;
		txtT_Tien.Mask = "### ### ### ###";
		((Control)txtT_Tien).Name = "txtT_Tien";
		((TextBoxBase)txtT_Tien).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtT_Tien;
		size = new Size(95, 20);
		((Control)asTextNumeric4).Size = size;
		txtT_Tien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tien).TabIndex = 227;
		((Control)txtT_Tien).TabStop = false;
		((TextBox)txtT_Tien).Text = "0";
		((TextBox)txtT_Tien).TextAlign = (HorizontalAlignment)1;
		txtT_Tien.Value = 0.0;
		((Control)txtT_tien_Nt).Anchor = (AnchorStyles)6;
		txtT_tien_Nt.DecimalSymbol = ".";
		((Control)txtT_tien_Nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric5 = txtT_tien_Nt;
		location = new Point(507, 383);
		((Control)asTextNumeric5).Location = location;
		txtT_tien_Nt.Mask = "### ### ### ###.##";
		((Control)txtT_tien_Nt).Name = "txtT_tien_Nt";
		((TextBoxBase)txtT_tien_Nt).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtT_tien_Nt;
		size = new Size(95, 20);
		((Control)asTextNumeric6).Size = size;
		txtT_tien_Nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tien_Nt).TabIndex = 225;
		((Control)txtT_tien_Nt).TabStop = false;
		((TextBox)txtT_tien_Nt).Text = "0.00";
		((TextBox)txtT_tien_Nt).TextAlign = (HorizontalAlignment)1;
		txtT_tien_Nt.Value = 0.0;
		((Control)lblT_Tien).Anchor = (AnchorStyles)6;
		((Control)lblT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblT_Tien.ImeMode = (ImeMode)0;
		Label obj37 = lblT_Tien;
		location = new Point(387, 386);
		((Control)obj37).Location = location;
		((Control)lblT_Tien).Name = "lblT_Tien";
		Label obj38 = lblT_Tien;
		size = new Size(117, 15);
		((Control)obj38).Size = size;
		((Control)lblT_Tien).TabIndex = 226;
		lblT_Tien.Text = "Tổng tiền";
		((Control)chkTg_gs_dd).Anchor = (AnchorStyles)6;
		((ButtonBase)chkTg_gs_dd).AutoSize = true;
		((Control)chkTg_gs_dd).Enabled = false;
		CheckBox obj39 = chkTg_gs_dd;
		location = new Point(9, 385);
		((Control)obj39).Location = location;
		((Control)chkTg_gs_dd).Name = "chkTg_gs_dd";
		CheckBox obj40 = chkTg_gs_dd;
		size = new Size(139, 17);
		((Control)obj40).Size = size;
		((Control)chkTg_gs_dd).TabIndex = 228;
		((ButtonBase)chkTg_gs_dd).Text = "Tỷ giá ghi sổ đích danh";
		((Control)chkTg_gs_dd).Visible = false;
		size = new Size(712, 461);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtT_Tien);
		((Control)this).Controls.Add((Control)(object)txtT_tien_Nt);
		((Control)this).Controls.Add((Control)(object)lblT_Tien);
		((Control)this).Controls.Add((Control)(object)chkTg_gs_dd);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmCaVchCA3";
		((Form)this).Text = "frmCA3Input";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)chkTg_gs_dd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tien_Nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien, 0);
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
			}
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
			if ((base.ActionMode == Commons.ApplicationMode.ADD_MODE && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_httt"]), isNum: false), (object)"", false) && Commons.ValidMa(ref pDrw, "MA_HTTT", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_httt"]), isNum: false)), "moduleid='SO'", "tk", pSd: true) && pDrw != null && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(pDrw["tk"]), isNum: false), (object)"", false) && Commons.ValidMa(ref pDrw2, "TK", Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(pDrw["tk"]), isNum: false)), "chi_tiet=1", "ten_tk,tk_cn", pSd: true)) ? true : false)
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
			foreach (DataRowView item in CT1Voucher)
			{
				Type? typeFromHandle = typeof(Math);
				object[] array = new object[3]
				{
					Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["ps_co_nt"]), isNum: true), txtTy_gia.Value),
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
				item["ps_co"] = RuntimeHelpers.GetObjectValue(obj);
			}
		}
		UpdateList();
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
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcPs_co_nt).Name, false) == 0)
			{
				V_Ps_Co_Nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcPs_co).Name, false) == 0)
			{
				V_Ps_Co(oDv);
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
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["ps_co_nt"]), isNum: true)),
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
			dataRowView2["ps_co_nt"] = RuntimeHelpers.GetObjectValue(obj);
		}
	}

	private void V_Ps_Co_Nt(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(txtTy_gia.Value, (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ps_co_nt"]), isNum: true), txtTy_gia.Value),
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
			oDv["ps_co"] = RuntimeHelpers.GetObjectValue(obj);
		}
		UpdateList();
	}

	private void V_Ps_Co(DataRowView oDv)
	{
		UpdateList();
	}

	private void V_Ma_KhI(DataRowView oDv)
	{
		if ((Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_kh"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["tk"]), isNum: false), (object)"", false) && oDv["Tk_Cn"] != DBNull.Value && Operators.ConditionalCompareObjectEqual(oDv["Tk_Cn"], (object)true, false)) ? true : false)
		{
			oDv["Du13"] = Commons.GetDuArkh(Conversions.ToString(oDv["ma_kh"]), Conversions.ToString(oDv["tk"]), Conversions.ToDate(txtNgay_Ct.Value));
		}
		else
		{
			oDv["Du13"] = 0;
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
		((DataGridViewColumn)dgvcPs_co).Visible = visible;
		((Control)txtT_Tien).Visible = visible;
		((DataGridViewColumn)dgvcPs_co_nt).HeaderText = f_sPs_co_header + " " + cboMa_NT.MA_NT;
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
			txtT_tien_Nt.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(ps_co_nt)", filter));
			txtT_Tien.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(ps_co)", filter));
		}
	}

	protected override bool ValidData()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		bool flag2 = false;
		checked
		{
			if ((ChkEmtyTextBox((TextBox)(object)txtMa_Kh) && ChkEmtyTextBox((TextBox)(object)txtTk_No) && base.ValidData()) ? true : false)
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
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_Co_Nt"]), isNum: true), (object)0, false))
					{
						CMessageBox.Show(50018);
						((Control)adgvDetail).Select();
						((DataGridView)adgvDetail).CurrentCell = ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcPs_co_nt).Name, num2];
						return false;
					}
					if ((Operators.ConditionalCompareObjectEqual(txtTy_gia.Value, (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_co"]), isNum: true), (object)0, false)) ? true : false)
					{
						CMessageBox.Show(50018);
						((Control)adgvDetail).Select();
						((DataGridView)adgvDetail).CurrentCell = ((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcPs_co).Name, num2];
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
								Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["PS_CO_nt"]), isNum: true), txtTy_gia.Value),
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
							if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["PS_CO"]), isNum: true), (object)num7) }, (string[])null, (Type[])null, (bool[])null), (object)num5, false))
							{
								((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcPs_co).Name, num2].ErrorText = Helper.GetMessContent(50047);
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
		CreateDataBinding((Control)(object)txtTk_No, "tk_no");
		CreateDataBinding((Control)(object)lblTen_Tk_No, "ten_tk_no");
		CreateDataBinding((Control)(object)txtNgay_Ct, "ngay_ct", "Value");
		CreateDataBinding((Control)(object)txtSo_Ct, "so_ct");
		CreateDataBinding((Control)(object)txtNgay_lct, "ngay_lct", "Value");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtT_tien_Nt, "t_tien_nt", "Value");
		CreateDataBinding((Control)(object)txtT_Tien, "t_tien", "Value");
	}

	protected override void SetReportDataSource(DataRow odrPrintPHRow)
	{
		base.SetReportDataSource(odrPrintPHRow);
		int num = 0;
		string filterExpression = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", odrPrintPHRow["Stt_Rec"]), (object)"'"));
		AsDictionary asDictionary = new AsDictionary();
		num = 0;
		DataRow[] array = base.CTTable.Select(filterExpression);
		checked
		{
			foreach (DataRow dataRow in array)
			{
				if (asDictionary.Contains(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Tk"]), isNum: false))))
				{
					AsDictionary myFomularFields = base.MyFomularFields;
					object obj = asDictionary[RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Tk"]), isNum: false))];
					myFomularFields[RuntimeHelpers.GetObjectValue(obj)] = Operators.AddObject(myFomularFields[RuntimeHelpers.GetObjectValue(obj)], (object)Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Ps_Co_Nt"]), isNum: true)));
				}
				else if (num < 6)
				{
					num++;
					asDictionary.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Tk"]), isNum: false)), "Ps_Co" + num.ToString().Trim());
					base.MyFomularFields.Add("Tk_Co" + num.ToString().Trim(), RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Tk"]), isNum: false)));
					base.MyFomularFields.Add("Ps_Co" + num.ToString().Trim(), Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Ps_Co_Nt"]), isNum: true)));
				}
			}
			int num2 = num + 1;
			while (true)
			{
				int num3 = num2;
				int num4 = 6;
				if (num3 <= num4)
				{
					base.MyFomularFields.Add("Tk_co" + num2.ToString().Trim(), "");
					base.MyFomularFields.Add("Ps_co" + num2.ToString().Trim(), "");
					num2++;
					continue;
				}
				break;
			}
		}
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		f_sPs_co_header = ((DataGridViewColumn)dgvcPs_co_nt).HeaderText;
		((DataGridViewColumn)dgvcPs_co).HeaderText = f_sPs_co_header + " " + AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tien_Nt);
	}

	protected override void SetPHDefaultValues(DataRow drwPh)
	{
		base.SetPHDefaultValues(drwPh);
		drwPh["tk_no"] = AsiaErp.Framework.Environment.GetSiDMCTByMa_Ct(base.MyVoucherInfo.voucher_code).tk_no;
	}
}
