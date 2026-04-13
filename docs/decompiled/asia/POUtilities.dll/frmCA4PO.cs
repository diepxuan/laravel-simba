using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

[DesignerGenerated]
public class frmCA4PO : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("lblSo_Ct")]
	private Label _lblSo_Ct;

	[AccessedThroughProperty("lblNgay_Ct")]
	private Label _lblNgay_Ct;

	[AccessedThroughProperty("lblTk_Co")]
	private Label _lblTk_Co;

	[AccessedThroughProperty("lblNguoi_Gd")]
	private Label _lblNguoi_Gd;

	[AccessedThroughProperty("lblDien_giai")]
	private Label _lblDien_giai;

	[AccessedThroughProperty("gbLine")]
	private GroupBox _gbLine;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("lblTen_tk_co")]
	private Label _lblTen_tk_co;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtNgay_Ct")]
	private AsMaskedTextBox _txtNgay_Ct;

	[AccessedThroughProperty("txtSo_Ct")]
	private TextBox _txtSo_Ct;

	[AccessedThroughProperty("txtTk_Co")]
	private AsTextBox _txtTk_Co;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("txtNguoi_Gd")]
	private TextBox _txtNguoi_Gd;

	[AccessedThroughProperty("rbCA4")]
	private RadioButton _rbCA4;

	[AccessedThroughProperty("rbCA2")]
	private RadioButton _rbCA2;

	[AccessedThroughProperty("cmdPrint")]
	private Button _cmdPrint;

	[AccessedThroughProperty("prDialog")]
	private PrintDialog _prDialog;

	[AccessedThroughProperty("rpDoc")]
	private ReportDocument _rpDoc;

	[AccessedThroughProperty("lblDa_chi")]
	private Label _lblDa_chi;

	[AccessedThroughProperty("lblT_Tt")]
	private Label _lblT_Tt;

	[AccessedThroughProperty("txtT_tt_nt")]
	private AsTextNumeric _txtT_tt_nt;

	[AccessedThroughProperty("adgvDetail")]
	private AsInputDGV _adgvDetail;

	[AccessedThroughProperty("dgvcTk")]
	private DataGridViewTextBoxColumn _dgvcTk;

	[AccessedThroughProperty("dgvcTen_tk")]
	private DataGridViewTextBoxColumn _dgvcTen_tk;

	[AccessedThroughProperty("dgvcPs_no_nt")]
	private DataGridViewAsTextNumericColumn _dgvcPs_no_nt;

	[AccessedThroughProperty("dgvcMa_bp")]
	private DataGridViewTextBoxColumn _dgvcMa_bp;

	[AccessedThroughProperty("dgvcMa_phi")]
	private DataGridViewTextBoxColumn _dgvcMa_phi;

	[AccessedThroughProperty("dgvcMa_hd")]
	private DataGridViewTextBoxColumn _dgvcMa_hd;

	[AccessedThroughProperty("dgvcMa_spct")]
	private DataGridViewTextBoxColumn _dgvcMa_spct;

	[AccessedThroughProperty("dgvcMa_lo")]
	private DataGridViewTextBoxColumn _dgvcMa_lo;

	public string f_mode;

	public bool isOK;

	private bool isLoading;

	public MenuInformation f_CA2_MenuInfo;

	public MenuInformation f_CA4_MenuInfo;

	public VoucherInformation f_CAVoucherInfo;

	public DataTable f_oTblCt;

	public string f_stt_rec;

	public string f_stt_rec_hd;

	public string f_Ma_nt;

	public decimal f_Ty_gia;

	public string f_Ma_kh;

	public string f_Ten_kh;

	public decimal f_T_tien_nt;

	public decimal f_t_tien;

	public string f_Dia_chi_kh;

	public ReportInformation f_oReportInfo;

	private AsDictionary f_oRptFomularFields;

	private Commons.PrintOption f_iPrintOption;

	private frmViewCrystal f_printVoucher;

	public MsSqlCA4PODAO f_oDAO;

	protected internal virtual Button cmdAdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdAdd_Click;
			if (_cmdAdd != null)
			{
				((Control)_cmdAdd).Click -= eventHandler;
			}
			_cmdAdd = value;
			if (_cmdAdd != null)
			{
				((Control)_cmdAdd).Click += eventHandler;
			}
		}
	}

	protected internal virtual Label lblSo_Ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_Ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_Ct = value;
		}
	}

	protected internal virtual Label lblNgay_Ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_Ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_Ct = value;
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

	protected internal virtual GroupBox gbLine
	{
		[DebuggerNonUserCode]
		get
		{
			return _gbLine;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_gbLine = value;
		}
	}

	protected virtual Button cmdCancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCancel_Click;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).Click -= eventHandler;
			}
			_cmdCancel = value;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).Click += eventHandler;
			}
		}
	}

	internal virtual Label lblTen_tk_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk_co = value;
		}
	}

	protected internal virtual Label Label1
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

	public virtual AsMaskedTextBox txtNgay_Ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_Ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_Ct = value;
		}
	}

	public virtual TextBox txtSo_Ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_Ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_Ct = value;
		}
	}

	public virtual AsTextBox txtTk_Co
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
			_txtTk_Co = value;
		}
	}

	public virtual TextBox txtDien_giai
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

	public virtual TextBox txtNguoi_Gd
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

	public virtual RadioButton rbCA4
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbCA4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbCA4_CheckedChanged;
			if (_rbCA4 != null)
			{
				_rbCA4.CheckedChanged -= eventHandler;
			}
			_rbCA4 = value;
			if (_rbCA4 != null)
			{
				_rbCA4.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton rbCA2
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbCA2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbCA4_CheckedChanged;
			if (_rbCA2 != null)
			{
				_rbCA2.CheckedChanged -= eventHandler;
			}
			_rbCA2 = value;
			if (_rbCA2 != null)
			{
				_rbCA2.CheckedChanged += eventHandler;
			}
		}
	}

	protected internal virtual Button cmdPrint
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPrint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdPrint_Click;
			if (_cmdPrint != null)
			{
				((Control)_cmdPrint).Click -= eventHandler;
			}
			_cmdPrint = value;
			if (_cmdPrint != null)
			{
				((Control)_cmdPrint).Click += eventHandler;
			}
		}
	}

	protected internal virtual PrintDialog prDialog
	{
		[DebuggerNonUserCode]
		get
		{
			return _prDialog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_prDialog = value;
		}
	}

	protected internal virtual ReportDocument rpDoc
	{
		[DebuggerNonUserCode]
		get
		{
			return _rpDoc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rpDoc = value;
		}
	}

	internal virtual Label lblDa_chi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDa_chi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDa_chi = value;
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

	internal virtual AsTextNumeric txtT_tt_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tt_nt = value;
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
			_adgvDetail = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTk
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

	internal virtual DataGridViewTextBoxColumn dgvcMa_bp
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

	internal virtual DataGridViewTextBoxColumn dgvcMa_phi
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

	internal virtual DataGridViewTextBoxColumn dgvcMa_hd
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

	internal virtual DataGridViewTextBoxColumn dgvcMa_spct
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

	internal virtual DataGridViewTextBoxColumn dgvcMa_lo
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

	public MsSqlCA4PODAO MyDAO
	{
		get
		{
			if (f_oDAO == null)
			{
				try
				{
					f_oDAO = (MsSqlCA4PODAO)DAOFactory.CreateDAOInstance("CA4PODAO", "POUtilities");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Helper.ProcessError(ex2);
					ProjectData.ClearProjectError();
				}
			}
			return f_oDAO;
		}
	}

	private ReportInformation MyReportInfo => f_oReportInfo;

	public VoucherInformation MyVoucherInfo => f_CAVoucherInfo;

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

	public frmCA4PO()
	{
		((Form)this).Load += frmCA4PO_Load;
		__ENCAddToList(this);
		f_mode = "M";
		isOK = false;
		isLoading = true;
		f_stt_rec = "ASIASOFT";
		f_stt_rec_hd = "ASIASOFT";
		f_oRptFomularFields = new AsDictionary();
		f_printVoucher = null;
		InitializeComponent();
	}

	public frmCA4PO(string menuid, string aStt_rec_hd)
		: base(menuid)
	{
		((Form)this).Load += frmCA4PO_Load;
		__ENCAddToList(this);
		f_mode = "M";
		isOK = false;
		isLoading = true;
		f_stt_rec = "ASIASOFT";
		f_stt_rec_hd = "ASIASOFT";
		f_oRptFomularFields = new AsDictionary();
		f_printVoucher = null;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected O, but got Unknown
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected O, but got Unknown
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de7: Expected O, but got Unknown
		//IL_0f6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f78: Expected O, but got Unknown
		//IL_106c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1076: Expected O, but got Unknown
		//IL_1149: Unknown result type (might be due to invalid IL or missing references)
		//IL_1153: Expected O, but got Unknown
		//IL_120e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1218: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmCA4PO));
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
		cmdAdd = new Button();
		txtNgay_Ct = new AsMaskedTextBox();
		lblSo_Ct = new Label();
		txtSo_Ct = new TextBox();
		lblNgay_Ct = new Label();
		txtTk_Co = new AsTextBox();
		lblTen_tk_co = new Label();
		lblTk_Co = new Label();
		lblNguoi_Gd = new Label();
		txtDien_giai = new TextBox();
		txtNguoi_Gd = new TextBox();
		lblDien_giai = new Label();
		gbLine = new GroupBox();
		lblT_Tt = new Label();
		txtT_tt_nt = new AsTextNumeric();
		Label1 = new Label();
		rbCA4 = new RadioButton();
		rbCA2 = new RadioButton();
		cmdCancel = new Button();
		cmdPrint = new Button();
		rpDoc = new ReportDocument();
		prDialog = new PrintDialog();
		lblDa_chi = new Label();
		adgvDetail = new AsInputDGV();
		dgvcTk = new DataGridViewTextBoxColumn();
		dgvcTen_tk = new DataGridViewTextBoxColumn();
		dgvcPs_no_nt = new DataGridViewAsTextNumericColumn();
		dgvcMa_bp = new DataGridViewTextBoxColumn();
		dgvcMa_phi = new DataGridViewTextBoxColumn();
		dgvcMa_hd = new DataGridViewTextBoxColumn();
		dgvcMa_spct = new DataGridViewTextBoxColumn();
		dgvcMa_lo = new DataGridViewTextBoxColumn();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)adgvDetail).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdAdd).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdAdd).Image = (Image)componentResourceManager.GetObject("cmdAdd.Image");
		((ButtonBase)cmdAdd).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdAdd).ImeMode = (ImeMode)0;
		Button obj = cmdAdd;
		Point location = new Point(12, 361);
		((Control)obj).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		((Control)cmdAdd).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdAdd;
		Size size = new Size(64, 23);
		((Control)obj2).Size = size;
		((Control)cmdAdd).TabIndex = 2;
		((ButtonBase)cmdAdd).Text = "&Lưu";
		((ButtonBase)cmdAdd).TextAlign = (ContentAlignment)64;
		txtNgay_Ct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_Ct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(135, 76);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_Ct).Mask = "##/##/####";
		((Control)txtNgay_Ct).Name = "txtNgay_Ct";
		((MaskedTextBox)txtNgay_Ct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_Ct;
		size = new Size(78, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_Ct).TabIndex = 2;
		((MaskedTextBox)txtNgay_Ct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_Ct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		lblSo_Ct.AutoSize = true;
		lblSo_Ct.ImeMode = (ImeMode)0;
		Label obj3 = lblSo_Ct;
		location = new Point(15, 53);
		((Control)obj3).Location = location;
		((Control)lblSo_Ct).Name = "lblSo_Ct";
		Label obj4 = lblSo_Ct;
		size = new Size(65, 13);
		((Control)obj4).Size = size;
		((Control)lblSo_Ct).TabIndex = 105;
		lblSo_Ct.Text = "Số chứng từ";
		TextBox obj5 = txtSo_Ct;
		location = new Point(135, 50);
		((Control)obj5).Location = location;
		((TextBoxBase)txtSo_Ct).MaxLength = 12;
		((Control)txtSo_Ct).Name = "txtSo_Ct";
		TextBox obj6 = txtSo_Ct;
		size = new Size(78, 20);
		((Control)obj6).Size = size;
		((Control)txtSo_Ct).TabIndex = 1;
		lblNgay_Ct.AutoSize = true;
		lblNgay_Ct.ImeMode = (ImeMode)0;
		Label obj7 = lblNgay_Ct;
		location = new Point(15, 79);
		((Control)obj7).Location = location;
		((Control)lblNgay_Ct).Name = "lblNgay_Ct";
		Label obj8 = lblNgay_Ct;
		size = new Size(77, 13);
		((Control)obj8).Size = size;
		((Control)lblNgay_Ct).TabIndex = 106;
		lblNgay_Ct.Text = "Ngày chứng từ";
		txtTk_Co.AutoLookup = true;
		txtTk_Co.AutoValid = true;
		((TextBoxBase)txtTk_Co).BackColor = SystemColors.Info;
		((TextBox)txtTk_Co).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTk_Co;
		location = new Point(135, 154);
		((Control)asTextBox).Location = location;
		txtTk_Co.LookupCodeName = "TK";
		txtTk_Co.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Co).Name = "txtTk_Co";
		txtTk_Co.NameControl = lblTen_tk_co;
		txtTk_Co.SD = true;
		AsTextBox asTextBox2 = txtTk_Co;
		size = new Size(78, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTk_Co).TabIndex = 5;
		txtTk_Co.UseAutoCompleteSource = true;
		lblTen_tk_co.ImeMode = (ImeMode)0;
		Label obj9 = lblTen_tk_co;
		location = new Point(219, 157);
		((Control)obj9).Location = location;
		((Control)lblTen_tk_co).Name = "lblTen_tk_co";
		Label obj10 = lblTen_tk_co;
		size = new Size(295, 13);
		((Control)obj10).Size = size;
		((Control)lblTen_tk_co).TabIndex = 1061;
		lblTen_tk_co.TextAlign = (ContentAlignment)16;
		lblTk_Co.AutoSize = true;
		lblTk_Co.ImeMode = (ImeMode)0;
		Label obj11 = lblTk_Co;
		location = new Point(15, 155);
		((Control)obj11).Location = location;
		((Control)lblTk_Co).Name = "lblTk_Co";
		Label obj12 = lblTk_Co;
		size = new Size(70, 13);
		((Control)obj12).Size = size;
		((Control)lblTk_Co).TabIndex = 226;
		lblTk_Co.Text = "Tài khoản có";
		lblNguoi_Gd.AutoSize = true;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj13 = lblNguoi_Gd;
		location = new Point(15, 103);
		((Control)obj13).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj14 = lblNguoi_Gd;
		size = new Size(81, 13);
		((Control)obj14).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 224;
		lblNguoi_Gd.Text = "Người giao dịch";
		TextBox obj15 = txtDien_giai;
		location = new Point(135, 128);
		((Control)obj15).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj16 = txtDien_giai;
		size = new Size(429, 20);
		((Control)obj16).Size = size;
		((Control)txtDien_giai).TabIndex = 4;
		TextBox obj17 = txtNguoi_Gd;
		location = new Point(135, 102);
		((Control)obj17).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj18 = txtNguoi_Gd;
		size = new Size(196, 20);
		((Control)obj18).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 3;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj19 = lblDien_giai;
		location = new Point(15, 129);
		((Control)obj19).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj20 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj20).Size = size;
		((Control)lblDien_giai).TabIndex = 225;
		lblDien_giai.Text = "Diễn giải";
		((Control)gbLine).Controls.Add((Control)(object)lblT_Tt);
		((Control)gbLine).Controls.Add((Control)(object)txtT_tt_nt);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)rbCA4);
		((Control)gbLine).Controls.Add((Control)(object)rbCA2);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk_co);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_Ct);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_Ct);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_Ct);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_Ct);
		((Control)gbLine).Controls.Add((Control)(object)lblDien_giai);
		((Control)gbLine).Controls.Add((Control)(object)txtNguoi_Gd);
		((Control)gbLine).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbLine).Controls.Add((Control)(object)lblNguoi_Gd);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Co);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Co);
		GroupBox obj21 = gbLine;
		location = new Point(12, 3);
		((Control)obj21).Location = location;
		((Control)gbLine).Name = "gbLine";
		GroupBox obj22 = gbLine;
		size = new Size(580, 212);
		((Control)obj22).Size = size;
		((Control)gbLine).TabIndex = 0;
		gbLine.TabStop = false;
		lblT_Tt.AutoSize = true;
		((Control)lblT_Tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		lblT_Tt.ImeMode = (ImeMode)0;
		Label obj23 = lblT_Tt;
		location = new Point(15, 183);
		((Control)obj23).Location = location;
		((Control)lblT_Tt).Name = "lblT_Tt";
		Label obj24 = lblT_Tt;
		size = new Size(72, 13);
		((Control)obj24).Size = size;
		((Control)lblT_Tt).TabIndex = 1068;
		lblT_Tt.Text = "Thanh toán";
		lblT_Tt.TextAlign = (ContentAlignment)16;
		txtT_tt_nt.DecimalSymbol = ".";
		((Control)txtT_tt_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric = txtT_tt_nt;
		location = new Point(135, 180);
		((Control)asTextNumeric).Location = location;
		txtT_tt_nt.Mask = "### ### ### ###";
		((Control)txtT_tt_nt).Name = "txtT_tt_nt";
		((TextBoxBase)txtT_tt_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtT_tt_nt;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		txtT_tt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tt_nt).TabIndex = 6;
		((Control)txtT_tt_nt).TabStop = false;
		((TextBox)txtT_tt_nt).Text = "0";
		((TextBox)txtT_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tt_nt.Value = 0.0;
		Label1.AutoSize = true;
		Label1.ImeMode = (ImeMode)0;
		Label label = Label1;
		location = new Point(15, 23);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(72, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1064;
		Label1.Text = "Loại chứng từ";
		((ButtonBase)rbCA4).AutoSize = true;
		RadioButton obj25 = rbCA4;
		location = new Point(231, 19);
		((Control)obj25).Location = location;
		((Control)rbCA4).Name = "rbCA4";
		RadioButton obj26 = rbCA4;
		size = new Size(59, 17);
		((Control)obj26).Size = size;
		((Control)rbCA4).TabIndex = 99;
		((ButtonBase)rbCA4).Text = "Báo nợ";
		((ButtonBase)rbCA4).UseVisualStyleBackColor = true;
		((ButtonBase)rbCA2).AutoSize = true;
		rbCA2.Checked = true;
		RadioButton obj27 = rbCA2;
		location = new Point(135, 19);
		((Control)obj27).Location = location;
		((Control)rbCA2).Name = "rbCA2";
		RadioButton obj28 = rbCA2;
		size = new Size(69, 17);
		((Control)obj28).Size = size;
		((Control)rbCA2).TabIndex = 0;
		rbCA2.TabStop = true;
		((ButtonBase)rbCA2).Text = "Phiếu chi";
		((ButtonBase)rbCA2).UseVisualStyleBackColor = true;
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		((ButtonBase)cmdCancel).Image = (Image)componentResourceManager.GetObject("cmdCancel.Image");
		((ButtonBase)cmdCancel).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdCancel).ImeMode = (ImeMode)0;
		Button obj29 = cmdCancel;
		location = new Point(82, 361);
		((Control)obj29).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj30 = cmdCancel;
		size = new Size(75, 23);
		((Control)obj30).Size = size;
		((Control)cmdCancel).TabIndex = 3;
		((ButtonBase)cmdCancel).Text = "&Thoát";
		((ButtonBase)cmdCancel).TextAlign = (ContentAlignment)64;
		((Control)cmdPrint).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdPrint).Image = (Image)(object)Resources.imgPrint;
		((ButtonBase)cmdPrint).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdPrint).ImeMode = (ImeMode)0;
		Button obj31 = cmdPrint;
		location = new Point(243, 361);
		((Control)obj31).Location = location;
		((Control)cmdPrint).Name = "cmdPrint";
		((Control)cmdPrint).RightToLeft = (RightToLeft)0;
		Button obj32 = cmdPrint;
		size = new Size(64, 23);
		((Control)obj32).Size = size;
		((Control)cmdPrint).TabIndex = 4;
		((ButtonBase)cmdPrint).Text = "&In";
		((ButtonBase)cmdPrint).TextAlign = (ContentAlignment)64;
		prDialog.UseEXDialog = true;
		((Control)lblDa_chi).Anchor = (AnchorStyles)6;
		lblDa_chi.AutoSize = true;
		((Control)lblDa_chi).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblDa_chi).ForeColor = Color.Red;
		lblDa_chi.ImeMode = (ImeMode)0;
		Label obj33 = lblDa_chi;
		location = new Point(526, 364);
		((Control)obj33).Location = location;
		((Control)lblDa_chi).Name = "lblDa_chi";
		Label obj34 = lblDa_chi;
		size = new Size(66, 17);
		((Control)obj34).Size = size;
		((Control)lblDa_chi).TabIndex = 1065;
		lblDa_chi.Text = "(Đã chi)";
		((Control)lblDa_chi).Visible = false;
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
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)dgvcTk,
			(DataGridViewColumn)dgvcTen_tk,
			dgvcPs_no_nt,
			(DataGridViewColumn)dgvcMa_bp,
			(DataGridViewColumn)dgvcMa_phi,
			(DataGridViewColumn)dgvcMa_hd,
			(DataGridViewColumn)dgvcMa_spct,
			(DataGridViewColumn)dgvcMa_lo
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvDetail).DefaultCellStyle = val2;
		((DataGridView)adgvDetail).GridColor = SystemColors.Control;
		adgvDetail.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV = adgvDetail;
		location = new Point(12, 221);
		((Control)asInputDGV).Location = location;
		((Control)adgvDetail).Name = "adgvDetail";
		adgvDetail.ReadOnly = true;
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
		size = new Size(580, 130);
		((Control)asInputDGV2).Size = size;
		((Control)adgvDetail).TabIndex = 99;
		((Control)adgvDetail).TabStop = false;
		((DataGridViewColumn)dgvcTk).DataPropertyName = "tk";
		val4.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcTk).HeaderText = "Tk nợ";
		((DataGridViewColumn)dgvcTk).Name = "dgvcTk";
		((DataGridViewColumn)dgvcTk).Resizable = (DataGridViewTriState)1;
		dgvcTk.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTk).ToolTipText = "Tài khoản nợ";
		((DataGridViewColumn)dgvcTk).Width = 70;
		((DataGridViewColumn)dgvcTen_tk).DataPropertyName = "ten_tk";
		((DataGridViewColumn)dgvcTen_tk).HeaderText = "Tên tài khoản nợ";
		((DataGridViewColumn)dgvcTen_tk).Name = "dgvcTen_tk";
		((DataGridViewColumn)dgvcTen_tk).ReadOnly = true;
		dgvcTen_tk.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_tk).Visible = false;
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
		((DataGridViewColumn)dgvcMa_bp).DataPropertyName = "ma_bp";
		val6.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_bp).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcMa_bp).HeaderText = "B. phận";
		((DataGridViewColumn)dgvcMa_bp).Name = "dgvcMa_bp";
		((DataGridViewColumn)dgvcMa_bp).Resizable = (DataGridViewTriState)1;
		dgvcMa_bp.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_bp).Width = 70;
		((DataGridViewColumn)dgvcMa_phi).DataPropertyName = "ma_phi";
		val7.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_phi).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcMa_phi).HeaderText = "Phí";
		((DataGridViewColumn)dgvcMa_phi).Name = "dgvcMa_phi";
		((DataGridViewColumn)dgvcMa_phi).Resizable = (DataGridViewTriState)1;
		dgvcMa_phi.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_phi).Width = 70;
		((DataGridViewColumn)dgvcMa_hd).DataPropertyName = "ma_hd";
		val8.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_hd).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcMa_hd).HeaderText = "H. đồng";
		((DataGridViewColumn)dgvcMa_hd).Name = "dgvcMa_hd";
		((DataGridViewColumn)dgvcMa_hd).Resizable = (DataGridViewTriState)1;
		dgvcMa_hd.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_hd).Width = 70;
		((DataGridViewColumn)dgvcMa_spct).DataPropertyName = "ma_spct";
		val9.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_spct).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcMa_spct).HeaderText = "SPCT";
		((DataGridViewColumn)dgvcMa_spct).Name = "dgvcMa_spct";
		((DataGridViewColumn)dgvcMa_spct).Resizable = (DataGridViewTriState)1;
		dgvcMa_spct.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_spct).Width = 70;
		((DataGridViewColumn)dgvcMa_lo).DataPropertyName = "ma_lo";
		val10.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_lo).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcMa_lo).HeaderText = "Lô";
		((DataGridViewColumn)dgvcMa_lo).Name = "dgvcMa_lo";
		((DataGridViewColumn)dgvcMa_lo).Resizable = (DataGridViewTriState)1;
		dgvcMa_lo.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_lo).Width = 70;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(608, 395);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)adgvDetail);
		((Control)this).Controls.Add((Control)(object)lblDa_chi);
		((Control)this).Controls.Add((Control)(object)cmdPrint);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)gbLine);
		((Control)this).Controls.Add((Control)(object)cmdAdd);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmCA4PO";
		((Form)this).Text = "frmCa14PO";
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)adgvDetail).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmCA4PO_Load(object sender, EventArgs e)
	{
		txtTk_Co.SeekDM();
		((DataGridView)adgvDetail).DataSource = f_oTblCt;
		f_T_tien_nt = Conversions.ToDecimal(f_oTblCt.Compute("sum(ps_no_nt)", ""));
		f_t_tien = Conversions.ToDecimal(f_oTblCt.Compute("sum(ps_no)", ""));
		txtT_tt_nt.Value = f_T_tien_nt;
		if (Operators.CompareString(f_mode, "X", false) == 0)
		{
			((Control)gbLine).Enabled = false;
			((Control)cmdAdd).Enabled = false;
			((Control)lblDa_chi).Visible = true;
			((Control)cmdPrint).Enabled = true;
			((Control)cmdPrint).Visible = true;
			((Control)cmdCancel).Focus();
		}
		else
		{
			((Control)cmdPrint).Enabled = false;
			((Control)cmdPrint).Visible = false;
		}
		isLoading = false;
		ValidLoaiChungTu();
	}

	private void cmdAdd_Click(object sender, EventArgs e)
	{
		if (!((Form)this).ValidateChildren((ValidationConstraints)13))
		{
			return;
		}
		Save2DB();
		if (isOK)
		{
			if (rbCA4.Checked)
			{
				((Form)this).Close();
			}
			f_mode = "X";
			((Control)gbLine).Enabled = false;
			((Control)cmdAdd).Enabled = false;
			((Control)cmdPrint).Enabled = true;
			((Control)cmdPrint).Visible = true;
			((Control)lblDa_chi).Visible = true;
			((Control)cmdPrint).Focus();
		}
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Save2DB()
	{
		MyDAO.RequireTrans = true;
		isOK = MyDAO.SOSaveCAPH4PO(ref f_stt_rec, f_CAVoucherInfo.voucher_code, f_stt_rec_hd, Conversions.ToDate(txtNgay_Ct.Value), txtSo_Ct.Text, f_Ma_kh, f_Dia_chi_kh, txtNguoi_Gd.Text, txtDien_giai.Text, f_Ma_nt, f_Ty_gia, f_T_tien_nt, f_t_tien, ((TextBox)txtTk_Co).Text, SystemInformations.UserName);
		if (!isOK)
		{
			MyDAO.RollBackTrans();
			return;
		}
		foreach (DataRow row in f_oTblCt.Rows)
		{
			row["stt_rec"] = f_stt_rec;
			row.EndEdit();
			isOK = Conversions.ToBoolean(MyDAO.SOSaveCACT4PO(row));
			if (!isOK)
			{
				MyDAO.RollBackTrans();
				return;
			}
		}
		isOK = MyDAO.DBProcess(CompanyInformations.CompanyID, MyVoucherInfo.voucher_code, f_stt_rec, Conversions.ToString(1));
		if (!isOK)
		{
			MyDAO.RollBackTrans();
		}
		else
		{
			MyDAO.CommitTrans();
		}
	}

	protected override bool ProcessKeyPreview(ref Message m)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		Keys val = (Keys)(((Message)(ref m)).WParam.ToInt32() & 0xFFFF);
		if (((Message)(ref m)).Msg == 256 && (int)val == 27)
		{
			((Form)this).Close();
			return false;
		}
		return base.ProcessKeyPreview(ref m);
	}

	private void rbCA4_CheckedChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(f_mode, "X", false) != 0)
		{
			ValidLoaiChungTu();
		}
	}

	private void ValidLoaiChungTu()
	{
		if (!isLoading)
		{
			if (rbCA2.Checked)
			{
				MyMenuInfo = f_CA2_MenuInfo;
			}
			else
			{
				MyMenuInfo = f_CA4_MenuInfo;
			}
			f_CAVoucherInfo = AsiaErp.Framework.Environment.GetVoucherInformation(MyMenuInfo.code_name);
			if (Operators.CompareString(f_mode, "M", false) == 0)
			{
				txtSo_Ct.Text = Commons.Get_SoCt(f_CAVoucherInfo.voucher_code, Conversions.ToDate(txtNgay_Ct.Value));
				((TextBox)txtTk_Co).Text = AsiaErp.Framework.Environment.GetSiDMCTByMa_Ct(f_CAVoucherInfo.voucher_code).tk_co;
				txtTk_Co.SeekDM();
				((Control)cmdPrint).Enabled = false;
				((Control)cmdPrint).Visible = false;
			}
			else
			{
				((Control)cmdPrint).Enabled = true;
				((Control)cmdPrint).Visible = true;
			}
			((Form)this).Text = MyMenuInfo.bar;
		}
	}

	private void cmdPrint_Click(object sender, EventArgs e)
	{
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		if (f_oRptFomularFields != null)
		{
			f_oRptFomularFields.Clear();
		}
		f_iPrintOption = Commons.PrintOption.Cancel;
		CollectReportInformations();
		if (f_iPrintOption == Commons.PrintOption.Cancel || !LoadReport())
		{
			return;
		}
		switch ((int)f_iPrintOption)
		{
		case 2:
			if (f_printVoucher == null)
			{
				f_printVoucher = new frmViewCrystal();
			}
			((Form)f_printVoucher).Text = MyVoucherInfo.description;
			f_printVoucher.MyReportSource = rpDoc;
			((Form)f_printVoucher).TopLevel = true;
			((Form)f_printVoucher).ShowDialog((IWin32Window)(object)this);
			break;
		case 1:
		{
			prDialog.PrinterSettings.Copies = checked((short)MyVoucherInfo.number_of_copy);
			prDialog.PrinterSettings.Collate = true;
			PrinterSettings printerSettings = prDialog.PrinterSettings;
			PageSettings val = new PageSettings();
			if ((int)((CommonDialog)prDialog).ShowDialog() == 1)
			{
				rpDoc.PrintOptions.PrinterName = prDialog.PrinterSettings.PrinterName;
				rpDoc.PrintOptions.PaperSource = (PaperSource)7;
				try
				{
					rpDoc.PrintToPrinter((int)prDialog.PrinterSettings.Copies, prDialog.PrinterSettings.Collate, prDialog.PrinterSettings.FromPage, prDialog.PrinterSettings.ToPage);
					break;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					CMessageBox.Show(ex2.Message);
					ProjectData.ClearProjectError();
					break;
				}
			}
			break;
		}
		}
	}

	protected virtual void CollectReportInformations()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		string myReportPath = ((Operators.CompareString(f_Ma_nt, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0) ? SystemInformations.ReportPath : SystemInformations.FReportPath);
		frmVoucherPrint frmVoucherPrint = new frmVoucherPrint();
		frmVoucherPrint.MyVoucherInfo = MyVoucherInfo;
		frmVoucherPrint.MyMenuInfo = MyMenuInfo;
		frmVoucherPrint.MyReportPath = myReportPath;
		((Form)frmVoucherPrint).ShowDialog();
		f_iPrintOption = frmVoucherPrint.MyPrintOption;
		f_oRptFomularFields = frmVoucherPrint.MyFomularFields;
		f_oReportInfo = frmVoucherPrint.MyReportInfo;
		((Component)(object)frmVoucherPrint).Dispose();
	}

	protected virtual void SetReportFomularFields()
	{
		FormulaFieldDefinitions formulaFields = rpDoc.DataDefinition.FormulaFields;
		formulaFields["so_ct"].Text = "\"" + txtSo_Ct.Text.Trim() + "\"";
		FormulaFieldDefinition obj = formulaFields["ngay_ct"];
		DateTime dateTime = (DateTime)txtNgay_Ct.Value;
		obj.Text = "\"" + dateTime.ToString("dd/MM/yyyy") + "\"";
		formulaFields["ma_kh"].Text = "\"" + f_Ma_kh + "\"";
		formulaFields["ten_kh"].Text = "\"" + f_Ten_kh + "\"";
		formulaFields["dia_chi"].Text = "\"" + f_Dia_chi_kh + "\"";
		formulaFields["nguoi_gd"].Text = "\"" + txtNguoi_Gd.Text + "\"";
		formulaFields["dien_giai"].Text = "\"" + txtDien_giai.Text.Trim() + "\"";
		formulaFields["ma_nt"].Text = "\"" + f_Ma_nt + "\"";
		formulaFields["ty_gia"].Text = "\"" + f_Ty_gia + "\"";
		formulaFields["t_tien_nt"].Text = "\"" + f_T_tien_nt + "\"";
		formulaFields["t_tien"].Text = "\"" + f_t_tien + "\"";
		formulaFields["tk_co"].Text = "\"" + ((TextBox)txtTk_Co).Text + "\"";
		formulaFields["t_tt"].Text = "\"" + f_t_tien + "\"";
		if (f_oRptFomularFields != null)
		{
			DictionaryEntry dictionaryEntry = default(DictionaryEntry);
			try
			{
				IDictionaryEnumerator enumerator = f_oRptFomularFields.GetEnumerator();
				DictionaryEntry dictionaryEntry2 = default(DictionaryEntry);
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					dictionaryEntry = ((current != null) ? ((DictionaryEntry)current) : dictionaryEntry2);
					try
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet((object)rpDoc.DataDefinition.FormulaFields, (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(dictionaryEntry.Key) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject((object)"\"", dictionaryEntry.Value), (object)"\"") }, (string[])null, (Type[])null, false, true);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Helper.ProcessError(ex2);
						Type? typeFromHandle = typeof(Helper);
						object[] array = new object[1] { RuntimeHelpers.GetObjectValue(dictionaryEntry.Key) };
						object[] array2 = array;
						bool[] array3 = new bool[1] { true };
						NewLateBinding.LateCall((object)null, typeFromHandle, "ProcessError", array2, (string[])null, (Type[])null, array3, true);
						if (array3[0])
						{
							dictionaryEntry.Key = RuntimeHelpers.GetObjectValue(array[0]);
						}
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Helper.ProcessError(ex4);
				Type? typeFromHandle2 = typeof(Helper);
				object[] array = new object[1] { RuntimeHelpers.GetObjectValue(dictionaryEntry.Key) };
				object[] array4 = array;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall((object)null, typeFromHandle2, "ProcessError", array4, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					dictionaryEntry.Key = RuntimeHelpers.GetObjectValue(array[0]);
				}
				ProjectData.ClearProjectError();
			}
		}
		string ma_nt = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		string text = ma_nt;
		text = f_Ma_nt;
		string text2 = text;
		string text3 = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		foreach (DMNTInformation item in AsiaErp.Framework.Environment.GetDMNT())
		{
			if (Operators.CompareString(item.ma_nt, text, false) == 0)
			{
				text2 = item.ten_nt;
			}
			if (Operators.CompareString(item.ma_nt, ma_nt, false) == 0)
			{
				text3 = item.ten_nt;
			}
		}
		string text4;
		string text5;
		switch (SystemInformations.CurrentCultureName)
		{
		default:
			if (0 == 0)
			{
				text4 = "\"" + text + " " + Commons.DOI_SO_CHU(Convert.ToDouble(f_T_tien_nt), "") + "\"";
				text5 = "\"" + ma_nt + " " + Commons.DOI_SO_CHU(Convert.ToDouble(f_t_tien), "") + "\"";
				break;
			}
			goto case "vi-VN";
		case "vi-VN":
		case null:
		case "":
			text4 = "\"" + Commons.DOI_SO_CHU(Convert.ToDouble(f_T_tien_nt), text2) + "\"";
			text5 = "\"" + Commons.DOI_SO_CHU(Convert.ToDouble(f_t_tien), text3) + "\"";
			break;
		}
		rpDoc.DataDefinition.FormulaFields["Bang_Chu"].Text = text4;
		rpDoc.DataDefinition.FormulaFields["Bang_Chu0"].Text = text5;
		DataTable dataTable = Commons.GetDataTable("asPOGetCA4PO", CompanyInformations.CompanyID, "CA", f_stt_rec_hd);
		AsDictionary asDictionary = new AsDictionary();
		int num = 0;
		checked
		{
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				if (num < 6)
				{
					num++;
					formulaFields["Tk_no" + num.ToString().Trim()].Text = Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"\"", Helper.Repl_Null(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { "Tk" }, (string[])null)), isNum: false)), (object)"\""));
					formulaFields["Ps_no" + num.ToString().Trim()].Text = "\"" + Helper.Repl_Null(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { "Ps_no_Nt" }, (string[])null)), isNum: true).ToString() + "\"";
				}
			}
			int num2 = num + 1;
			while (true)
			{
				int num3 = num2;
				int num4 = 6;
				if (num3 <= num4)
				{
					formulaFields["Tk_no" + num2.ToString().Trim()].Text = "\"\"";
					formulaFields["Ps_no" + num2.ToString().Trim()].Text = "\"\"";
					num2++;
					continue;
				}
				break;
			}
		}
	}

	protected virtual void SetReportDefaultFomularFields()
	{
		try
		{
			rpDoc.DataDefinition.FormulaFields["strCompanyName"].Text = "\"" + CompanyInformations.CompanyName + "\"";
			rpDoc.DataDefinition.FormulaFields["strHeadCompanyName"].Text = "\"" + CompanyInformations.ParentCompanyName + "\"";
			rpDoc.DataDefinition.FormulaFields["strAddress"].Text = "\"" + CompanyInformations.CompanyAddress + "\"";
			rpDoc.DataDefinition.FormulaFields["strTel"].Text = "\"" + CompanyInformations.CompanyTel + "\"";
			rpDoc.DataDefinition.FormulaFields["strFax"].Text = "\"" + CompanyInformations.CompanyFax + "\"";
			if (Commons.CheckFormulaExist("strEmail", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["strEmail"].Text = "\"" + CompanyInformations.Email + "\"";
			}
			if (Commons.CheckFormulaExist("strDirector_Name", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["strDirector_Name"].Text = "\"" + CompanyInformations.Director_Name + "\"";
			}
			if (Commons.CheckFormulaExist("strChief_Accountant_Name", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["strChief_Accountant_Name"].Text = "\"" + CompanyInformations.Chief_Accountant_Name + "\"";
			}
			if (Commons.CheckFormulaExist("strMa_thue", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["strMa_thue"].Text = "\"" + CompanyInformations.Ma_thue + "\"";
			}
			if (Commons.CheckFormulaExist("strMau_so", rpDoc.DataDefinition.FormulaFields))
			{
				if (CompanyInformations.Qd_cdkt.Trim().Equals("15"))
				{
					rpDoc.DataDefinition.FormulaFields["strMau_so"].Text = "\"" + MyReportInfo.Mau_so_qd15 + "\"";
				}
				else if (CompanyInformations.Qd_cdkt.Trim().Equals("48"))
				{
					rpDoc.DataDefinition.FormulaFields["strMau_so"].Text = "\"" + MyReportInfo.Mau_so_qd48 + "\"";
				}
			}
			if ((Operators.CompareString(MyReportInfo.Mau_so_qd15.Trim(), "", false) != 0 || Operators.CompareString(MyReportInfo.Mau_so_qd48.Trim(), "", false) != 0) && 0 == 0 && Commons.CheckFormulaExist("strSo_QD", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["strSo_QD"].Text = "\"" + CompanyInformations.Ten_qd_cdkt + "\"";
			}
			if (Commons.CheckFormulaExist("intFCPrice_Decimal", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["intFCPrice_Decimal"].Text = "\"" + AsiaErp.Framework.Environment.GetSIConfiguration().FCPrice_decimal + "\"";
			}
			if (Commons.CheckFormulaExist("intPrice_Decimal", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["intPrice_Decimal"].Text = "\"" + AsiaErp.Framework.Environment.GetSIConfiguration().Price_decimal + "\"";
			}
			if (Commons.CheckFormulaExist("intFCAmount_Decimal", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["intFCAmount_Decimal"].Text = "\"" + AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_decimal + "\"";
			}
			if (Commons.CheckFormulaExist("intQuantity_Decimal", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["intQuantity_Decimal"].Text = "\"" + AsiaErp.Framework.Environment.GetSIConfiguration().Quantity_decimal + "\"";
			}
			if (Commons.CheckFormulaExist("strDecimal_separator", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["strDecimal_separator"].Text = "\"" + AsiaErp.Framework.Environment.GetSIConfiguration().Decimal_Separator.ToString() + "\"";
			}
			if (Commons.CheckFormulaExist("strThousands_separator", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["strThousands_separator"].Text = "\"" + AsiaErp.Framework.Environment.GetSIConfiguration().Thousands_Separator.ToString() + "\"";
			}
			if (Commons.CheckFormulaExist("printDirector_Name", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["printDirector_Name"].Text = "\"" + AsiaErp.Framework.Environment.GetSIConfiguration().PrintDirector_Name + "\"";
			}
			if (Commons.CheckFormulaExist("printChief_Accountant_Name", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["printChief_Accountant_Name"].Text = "\"" + AsiaErp.Framework.Environment.GetSIConfiguration().PrintChief_Accountant_Name + "\"";
			}
			if (Commons.CheckFormulaExist("printCreator_Name", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["printCreator_Name"].Text = "\"" + AsiaErp.Framework.Environment.GetSIConfiguration().PrintCreator_Name + "\"";
			}
			if (Commons.CheckFormulaExist("printDate_time", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["printDate_time"].Text = "\"" + AsiaErp.Framework.Environment.GetSIConfiguration().PrintDate_time + "\"";
			}
			if (Commons.CheckFormulaExist("strCreator_Name", rpDoc.DataDefinition.FormulaFields))
			{
				rpDoc.DataDefinition.FormulaFields["strCreator_Name"].Text = "\"" + SystemInformations.FullName + "\"";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	protected virtual bool LoadReport()
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		bool result;
		if (f_oReportInfo != null)
		{
			string text = ((Operators.CompareString(f_Ma_nt, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0) ? (SystemInformations.ReportPath + f_oReportInfo.rptname.Trim()) : (SystemInformations.FReportPath + f_oReportInfo.rptname.Trim()));
			if (!File.Exists(text))
			{
				CMessageBox.ShowWithFormat(50110, new object[1] { text });
				result = false;
			}
			else
			{
				if (!rpDoc.FileName.Equals("rassdk://" + text))
				{
					try
					{
						((Control)this).Cursor = Cursors.WaitCursor;
						rpDoc.Load(text, (OpenReportMethod)0);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						CMessageBox.ShowWithFormat(50109, new object[1] { text });
						((Control)this).Cursor = Cursors.Default;
						result = false;
						ProjectData.ClearProjectError();
						goto IL_0146;
					}
					((Control)this).Cursor = Cursors.Default;
				}
				SetReportDefaultFomularFields();
				SetReportFomularFields();
				result = true;
			}
		}
		else
		{
			result = false;
		}
		goto IL_0146;
		IL_0146:
		return result;
	}
}
