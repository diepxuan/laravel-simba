using System;
using System.Collections;
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
public class frmCOPB : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("GrB_KBC")]
	private GroupBox _GrB_KBC;

	[AccessedThroughProperty("dgvDMPB")]
	private AsInputDGV _dgvDMPB;

	[AccessedThroughProperty("chk_CheckAll")]
	private CheckBox _chk_CheckAll;

	[AccessedThroughProperty("cboKyBc")]
	private AsComboBox _cboKyBc;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtNgay2")]
	private AsMaskedTextBox _txtNgay2;

	[AccessedThroughProperty("txtNgay1")]
	private AsMaskedTextBox _txtNgay1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("dgvDMPB2")]
	private AsInputDGV _dgvDMPB2;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("btn_exit")]
	private Button _btn_exit;

	[AccessedThroughProperty("btn_XPB")]
	private Button _btn_XPB;

	[AccessedThroughProperty("btn_PB")]
	private Button _btn_PB;

	[AccessedThroughProperty("sbtn_DHS")]
	private SplitButton _sbtn_DHS;

	[AccessedThroughProperty("lblDien_hs")]
	private Label _lblDien_hs;

	[AccessedThroughProperty("dgvcID_")]
	private DataGridViewTextBoxColumn _dgvcID_;

	[AccessedThroughProperty("dgvcTag")]
	private DataGridViewCheckBoxColumn _dgvcTag;

	[AccessedThroughProperty("dgvcTen_bt")]
	private DataGridViewAsTextBoxColumn _dgvcTen_bt;

	[AccessedThroughProperty("dgvcTheoSPCT")]
	private DataGridViewCheckBoxColumn _dgvcTheoSPCT;

	[AccessedThroughProperty("dgvcTheoBP")]
	private DataGridViewCheckBoxColumn _dgvcTheoBP;

	[AccessedThroughProperty("dgvcTheoTKDU")]
	private DataGridViewCheckBoxColumn _dgvcTheoTKDU;

	[AccessedThroughProperty("dgvcTk_pb")]
	private DataGridViewTextBoxColumn _dgvcTk_pb;

	[AccessedThroughProperty("dgvcTien_Pb")]
	private DataGridViewAsTextNumericColumn _dgvcTien_Pb;

	[AccessedThroughProperty("dgvcID")]
	private DataGridViewTextBoxColumn _dgvcID;

	[AccessedThroughProperty("dgvThang")]
	private DataGridViewTextBoxColumn _dgvThang;

	[AccessedThroughProperty("dgvcTk")]
	private DataGridViewTextBoxColumn _dgvcTk;

	[AccessedThroughProperty("dgvcTen_tk")]
	private DataGridViewTextBoxColumn _dgvcTen_tk;

	[AccessedThroughProperty("dgvcMa_spct")]
	private DataGridViewTextBoxColumn _dgvcMa_spct;

	[AccessedThroughProperty("dgvcTen_spct")]
	private DataGridViewTextBoxColumn _dgvcTen_spct;

	[AccessedThroughProperty("dgvcMa_bo")]
	private DataGridViewTextBoxColumn _dgvcMa_bo;

	[AccessedThroughProperty("dgvcTen_Bp")]
	private DataGridViewTextBoxColumn _dgvcTen_Bp;

	[AccessedThroughProperty("dgvcTk_du")]
	private DataGridViewTextBoxColumn _dgvcTk_du;

	[AccessedThroughProperty("dgvcTen_tk_du")]
	private DataGridViewTextBoxColumn _dgvcTen_tk_du;

	[AccessedThroughProperty("dgvcHe_so")]
	private DataGridViewAsTextNumericColumn _dgvcHe_so;

	[AccessedThroughProperty("dgvTien_nhan")]
	private DataGridViewAsTextNumericColumn _dgvTien_nhan;

	internal DataTable dtDMPB1;

	internal DataTable dtDMPB2;

	internal DataTable dtCBB;

	private COPBDAO odao;

	[AccessedThroughProperty("ctmenu")]
	private ContextMenuStrip _ctmenu;

	private bool isLoading;

	internal virtual GroupBox GrB_KBC
	{
		get
		{
			return _GrB_KBC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GrB_KBC = value;
		}
	}

	internal virtual AsInputDGV dgvDMPB
	{
		get
		{
			return _dgvDMPB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = dgvDMPB_SelectionChanged;
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(dgvDMPB_CellContentClick);
			if (_dgvDMPB != null)
			{
				((DataGridView)_dgvDMPB).SelectionChanged -= eventHandler;
				((DataGridView)_dgvDMPB).CellContentClick -= val;
			}
			_dgvDMPB = value;
			if (_dgvDMPB != null)
			{
				((DataGridView)_dgvDMPB).SelectionChanged += eventHandler;
				((DataGridView)_dgvDMPB).CellContentClick += val;
			}
		}
	}

	internal virtual CheckBox chk_CheckAll
	{
		get
		{
			return _chk_CheckAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = chk_CheckAll_CheckedChanged;
			if (_chk_CheckAll != null)
			{
				_chk_CheckAll.CheckedChanged -= eventHandler;
			}
			_chk_CheckAll = value;
			if (_chk_CheckAll != null)
			{
				_chk_CheckAll.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual AsComboBox cboKyBc
	{
		get
		{
			return _cboKyBc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboKyBc_SelectedValueChanged;
			if (_cboKyBc != null)
			{
				((ListControl)_cboKyBc).SelectedValueChanged -= eventHandler;
			}
			_cboKyBc = value;
			if (_cboKyBc != null)
			{
				((ListControl)_cboKyBc).SelectedValueChanged += eventHandler;
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

	internal virtual AsMaskedTextBox txtNgay2
	{
		get
		{
			return _txtNgay2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNgay2 = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay1
	{
		get
		{
			return _txtNgay1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNgay1 = value;
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

	internal virtual Panel Panel3
	{
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel3 = value;
		}
	}

	internal virtual AsInputDGV dgvDMPB2
	{
		get
		{
			return _dgvDMPB2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(dgvDMPB2_CellValueChanged);
			if (_dgvDMPB2 != null)
			{
				((DataGridView)_dgvDMPB2).CellValueChanged -= val;
			}
			_dgvDMPB2 = value;
			if (_dgvDMPB2 != null)
			{
				((DataGridView)_dgvDMPB2).CellValueChanged += val;
			}
		}
	}

	internal virtual Panel Panel1
	{
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual Button btn_exit
	{
		get
		{
			return _btn_exit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btn_exit_Click;
			if (_btn_exit != null)
			{
				((Control)_btn_exit).Click -= eventHandler;
			}
			_btn_exit = value;
			if (_btn_exit != null)
			{
				((Control)_btn_exit).Click += eventHandler;
			}
		}
	}

	internal virtual Button btn_XPB
	{
		get
		{
			return _btn_XPB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btn_XPB_Click;
			if (_btn_XPB != null)
			{
				((Control)_btn_XPB).Click -= eventHandler;
			}
			_btn_XPB = value;
			if (_btn_XPB != null)
			{
				((Control)_btn_XPB).Click += eventHandler;
			}
		}
	}

	internal virtual Button btn_PB
	{
		get
		{
			return _btn_PB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btn_PB_Click;
			if (_btn_PB != null)
			{
				((Control)_btn_PB).Click -= eventHandler;
			}
			_btn_PB = value;
			if (_btn_PB != null)
			{
				((Control)_btn_PB).Click += eventHandler;
			}
		}
	}

	internal virtual SplitButton sbtn_DHS
	{
		get
		{
			return _sbtn_DHS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = sbtn_DHS_Click;
			if (_sbtn_DHS != null)
			{
				((Control)_sbtn_DHS).Click -= eventHandler;
			}
			_sbtn_DHS = value;
			if (_sbtn_DHS != null)
			{
				((Control)_sbtn_DHS).Click += eventHandler;
			}
		}
	}

	internal virtual Label lblDien_hs
	{
		get
		{
			return _lblDien_hs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblDien_hs = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcID_
	{
		get
		{
			return _dgvcID_;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcID_ = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcTag
	{
		get
		{
			return _dgvcTag;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTag = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTen_bt
	{
		get
		{
			return _dgvcTen_bt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTen_bt = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcTheoSPCT
	{
		get
		{
			return _dgvcTheoSPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTheoSPCT = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcTheoBP
	{
		get
		{
			return _dgvcTheoBP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTheoBP = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcTheoTKDU
	{
		get
		{
			return _dgvcTheoTKDU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTheoTKDU = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTk_pb
	{
		get
		{
			return _dgvcTk_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTk_pb = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_Pb
	{
		get
		{
			return _dgvcTien_Pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTien_Pb = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcID
	{
		get
		{
			return _dgvcID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcID = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvThang
	{
		get
		{
			return _dgvThang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvThang = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTk
	{
		get
		{
			return _dgvcTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTk = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_tk
	{
		get
		{
			return _dgvcTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTen_tk = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_spct
	{
		get
		{
			return _dgvcMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcMa_spct = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_spct
	{
		get
		{
			return _dgvcTen_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTen_spct = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_bo
	{
		get
		{
			return _dgvcMa_bo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcMa_bo = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_Bp
	{
		get
		{
			return _dgvcTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTen_Bp = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTk_du
	{
		get
		{
			return _dgvcTk_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTk_du = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_tk_du
	{
		get
		{
			return _dgvcTen_tk_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTen_tk_du = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcHe_so
	{
		get
		{
			return _dgvcHe_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcHe_so = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvTien_nhan
	{
		get
		{
			return _dgvTien_nhan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvTien_nhan = value;
		}
	}

	internal virtual ContextMenuStrip ctmenu
	{
		get
		{
			return _ctmenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ToolStripItemClickedEventHandler val = new ToolStripItemClickedEventHandler(ctmenu_Click);
			if (_ctmenu != null)
			{
				((ToolStrip)_ctmenu).ItemClicked -= val;
			}
			_ctmenu = value;
			if (_ctmenu != null)
			{
				((ToolStrip)_ctmenu).ItemClicked += val;
			}
		}
	}

	public frmCOPB(string menuid)
		: base(menuid)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		((Form)this).Load += frmCOPB_Load;
		((Control)this).KeyDown += new KeyEventHandler(frmCOPB_KeyDown);
		((Form)this).FormClosing += new FormClosingEventHandler(frmCOPB_FormClosing);
		ctmenu = new ContextMenuStrip();
		isLoading = false;
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
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
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected O, but got Unknown
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected O, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected O, but got Unknown
		//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmCOPB));
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		GrB_KBC = new GroupBox();
		Label2 = new Label();
		Label1 = new Label();
		txtNgay2 = new AsMaskedTextBox();
		txtNgay1 = new AsMaskedTextBox();
		cboKyBc = new AsComboBox();
		chk_CheckAll = new CheckBox();
		dgvDMPB = new AsInputDGV();
		Panel3 = new Panel();
		dgvDMPB2 = new AsInputDGV();
		Panel1 = new Panel();
		lblDien_hs = new Label();
		sbtn_DHS = new SplitButton();
		btn_exit = new Button();
		btn_XPB = new Button();
		btn_PB = new Button();
		dgvcID = new DataGridViewTextBoxColumn();
		dgvThang = new DataGridViewTextBoxColumn();
		dgvcTk = new DataGridViewTextBoxColumn();
		dgvcTen_tk = new DataGridViewTextBoxColumn();
		dgvcMa_spct = new DataGridViewTextBoxColumn();
		dgvcTen_spct = new DataGridViewTextBoxColumn();
		dgvcMa_bo = new DataGridViewTextBoxColumn();
		dgvcTen_Bp = new DataGridViewTextBoxColumn();
		dgvcTk_du = new DataGridViewTextBoxColumn();
		dgvcTen_tk_du = new DataGridViewTextBoxColumn();
		dgvcHe_so = new DataGridViewAsTextNumericColumn();
		dgvTien_nhan = new DataGridViewAsTextNumericColumn();
		dgvcID_ = new DataGridViewTextBoxColumn();
		dgvcTag = new DataGridViewCheckBoxColumn();
		dgvcTen_bt = new DataGridViewAsTextBoxColumn();
		dgvcTheoSPCT = new DataGridViewCheckBoxColumn();
		dgvcTheoBP = new DataGridViewCheckBoxColumn();
		dgvcTheoTKDU = new DataGridViewCheckBoxColumn();
		dgvcTk_pb = new DataGridViewTextBoxColumn();
		dgvcTien_Pb = new DataGridViewAsTextNumericColumn();
		((Control)GrB_KBC).SuspendLayout();
		((ISupportInitialize)dgvDMPB).BeginInit();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)dgvDMPB2).BeginInit();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GrB_KBC).Controls.Add((Control)(object)Label2);
		((Control)GrB_KBC).Controls.Add((Control)(object)Label1);
		((Control)GrB_KBC).Controls.Add((Control)(object)txtNgay2);
		((Control)GrB_KBC).Controls.Add((Control)(object)txtNgay1);
		((Control)GrB_KBC).Controls.Add((Control)(object)cboKyBc);
		((Control)GrB_KBC).Controls.Add((Control)(object)chk_CheckAll);
		((Control)GrB_KBC).Dock = (DockStyle)1;
		((Control)GrB_KBC).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		GroupBox grB_KBC = GrB_KBC;
		Point location = new Point(0, 0);
		((Control)grB_KBC).Location = location;
		((Control)GrB_KBC).Name = "GrB_KBC";
		GroupBox grB_KBC2 = GrB_KBC;
		Size size = new Size(1216, 97);
		((Control)grB_KBC2).Size = size;
		((Control)GrB_KBC).TabIndex = 0;
		GrB_KBC.TabStop = false;
		Label2.AutoSize = true;
		Label label = Label2;
		location = new Point(7, 28);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(61, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 6;
		Label2.Text = "Kỳ phân bổ";
		Label1.AutoSize = true;
		Label label3 = Label1;
		location = new Point(245, 27);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(13, 13);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 5;
		Label1.Text = "_";
		txtNgay2.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay2).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(264, 25);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay2).Mask = "##/##/####";
		((Control)txtNgay2).Name = "txtNgay2";
		((MaskedTextBox)txtNgay2).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay2;
		size = new Size(67, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay2).TabIndex = 2;
		((MaskedTextBox)txtNgay2).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay2;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtNgay1.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay1).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay1;
		location = new Point(170, 25);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay1).Mask = "##/##/####";
		((Control)txtNgay1).Name = "txtNgay1";
		((MaskedTextBox)txtNgay1).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay1;
		size = new Size(67, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay1).TabIndex = 1;
		((MaskedTextBox)txtNgay1).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay1;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		((ComboBox)cboKyBc).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyBc).FormattingEnabled = true;
		AsComboBox asComboBox = cboKyBc;
		location = new Point(74, 25);
		((Control)asComboBox).Location = location;
		((Control)cboKyBc).Name = "cboKyBc";
		AsComboBox asComboBox2 = cboKyBc;
		size = new Size(90, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		((ButtonBase)chk_CheckAll).AutoSize = true;
		CheckBox obj = chk_CheckAll;
		location = new Point(74, 61);
		((Control)obj).Location = location;
		((Control)chk_CheckAll).Name = "chk_CheckAll";
		CheckBox obj2 = chk_CheckAll;
		size = new Size(132, 17);
		((Control)obj2).Size = size;
		((Control)chk_CheckAll).TabIndex = 3;
		((ButtonBase)chk_CheckAll).Text = "Chọn/Hủy chọn tất cả";
		((ButtonBase)chk_CheckAll).UseVisualStyleBackColor = true;
		((DataGridView)dgvDMPB).AllowUserToAddRows = false;
		((DataGridView)dgvDMPB).AllowUserToDeleteRows = false;
		((DataGridView)dgvDMPB).BackgroundColor = Color.White;
		((DataGridView)dgvDMPB).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvDMPB).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvDMPB).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)dgvcID_,
			(DataGridViewColumn)dgvcTag,
			dgvcTen_bt,
			(DataGridViewColumn)dgvcTheoSPCT,
			(DataGridViewColumn)dgvcTheoBP,
			(DataGridViewColumn)dgvcTheoTKDU,
			(DataGridViewColumn)dgvcTk_pb,
			dgvcTien_Pb
		});
		((Control)dgvDMPB).Dock = (DockStyle)1;
		((DataGridView)dgvDMPB).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = dgvDMPB;
		location = new Point(0, 97);
		((Control)asInputDGV).Location = location;
		((Control)dgvDMPB).Name = "dgvDMPB";
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDMPB).RowHeadersDefaultCellStyle = val;
		((DataGridView)dgvDMPB).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = dgvDMPB;
		size = new Size(1216, 172);
		((Control)asInputDGV2).Size = size;
		((Control)dgvDMPB).TabIndex = 0;
		((Control)Panel3).Controls.Add((Control)(object)dgvDMPB2);
		((Control)Panel3).Controls.Add((Control)(object)Panel1);
		((Control)Panel3).Dock = (DockStyle)5;
		Panel panel = Panel3;
		location = new Point(0, 269);
		((Control)panel).Location = location;
		((Control)Panel3).Name = "Panel3";
		Panel panel2 = Panel3;
		size = new Size(1216, 275);
		((Control)panel2).Size = size;
		((Control)Panel3).TabIndex = 3;
		((DataGridView)dgvDMPB2).AllowUserToAddRows = false;
		((DataGridView)dgvDMPB2).AllowUserToDeleteRows = false;
		((DataGridView)dgvDMPB2).BackgroundColor = Color.White;
		((DataGridView)dgvDMPB2).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvDMPB2).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvDMPB2).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[12]
		{
			(DataGridViewColumn)dgvcID,
			(DataGridViewColumn)dgvThang,
			(DataGridViewColumn)dgvcTk,
			(DataGridViewColumn)dgvcTen_tk,
			(DataGridViewColumn)dgvcMa_spct,
			(DataGridViewColumn)dgvcTen_spct,
			(DataGridViewColumn)dgvcMa_bo,
			(DataGridViewColumn)dgvcTen_Bp,
			(DataGridViewColumn)dgvcTk_du,
			(DataGridViewColumn)dgvcTen_tk_du,
			dgvcHe_so,
			dgvTien_nhan
		});
		((Control)dgvDMPB2).Dock = (DockStyle)5;
		((DataGridView)dgvDMPB2).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV3 = dgvDMPB2;
		location = new Point(0, 0);
		((Control)asInputDGV3).Location = location;
		((Control)dgvDMPB2).Name = "dgvDMPB2";
		val2.Alignment = (DataGridViewContentAlignment)32;
		val2.BackColor = SystemColors.Control;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.WindowText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDMPB2).RowHeadersDefaultCellStyle = val2;
		((DataGridView)dgvDMPB2).RowTemplate.Height = 20;
		AsInputDGV asInputDGV4 = dgvDMPB2;
		size = new Size(1216, 224);
		((Control)asInputDGV4).Size = size;
		((Control)dgvDMPB2).TabIndex = 0;
		((Control)Panel1).Controls.Add((Control)(object)lblDien_hs);
		((Control)Panel1).Controls.Add((Control)(object)sbtn_DHS);
		((Control)Panel1).Controls.Add((Control)(object)btn_exit);
		((Control)Panel1).Controls.Add((Control)(object)btn_XPB);
		((Control)Panel1).Controls.Add((Control)(object)btn_PB);
		((Control)Panel1).Dock = (DockStyle)2;
		Panel panel3 = Panel1;
		location = new Point(0, 224);
		((Control)panel3).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel4 = Panel1;
		size = new Size(1216, 51);
		((Control)panel4).Size = size;
		((Control)Panel1).TabIndex = 1;
		lblDien_hs.AutoSize = true;
		((Control)lblDien_hs).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj3 = lblDien_hs;
		location = new Point(226, 21);
		((Control)obj3).Location = location;
		((Control)lblDien_hs).Name = "lblDien_hs";
		Label obj4 = lblDien_hs;
		size = new Size(58, 13);
		((Control)obj4).Size = size;
		((Control)lblDien_hs).TabIndex = 7;
		lblDien_hs.Text = "Điền HS:";
		sbtn_DHS.EnableSplit = true;
		((ButtonBase)sbtn_DHS).Image = (Image)componentResourceManager.GetObject("sbtn_DHS.Image");
		sbtn_DHS.ImageHeight = 4;
		sbtn_DHS.ImageWidth = 7;
		SplitButton splitButton = sbtn_DHS;
		location = new Point(290, 16);
		((Control)splitButton).Location = location;
		((Control)sbtn_DHS).Name = "sbtn_DHS";
		SplitButton splitButton2 = sbtn_DHS;
		size = new Size(190, 23);
		((Control)splitButton2).Size = size;
		sbtn_DHS.SplitWidth = 15;
		((Control)sbtn_DHS).TabIndex = 5;
		((ButtonBase)sbtn_DHS).UseVisualStyleBackColor = true;
		((Control)btn_exit).Anchor = (AnchorStyles)10;
		Button obj5 = btn_exit;
		location = new Point(1129, 18);
		((Control)obj5).Location = location;
		((Control)btn_exit).Name = "btn_exit";
		Button obj6 = btn_exit;
		size = new Size(75, 23);
		((Control)obj6).Size = size;
		((Control)btn_exit).TabIndex = 4;
		((ButtonBase)btn_exit).Text = "Quay ra";
		((ButtonBase)btn_exit).UseVisualStyleBackColor = true;
		Button obj7 = btn_XPB;
		location = new Point(102, 16);
		((Control)obj7).Location = location;
		((Control)btn_XPB).Name = "btn_XPB";
		Button obj8 = btn_XPB;
		size = new Size(118, 23);
		((Control)obj8).Size = size;
		((Control)btn_XPB).TabIndex = 1;
		((ButtonBase)btn_XPB).Text = "&Xóa phân bổ";
		((ButtonBase)btn_XPB).UseVisualStyleBackColor = true;
		Button obj9 = btn_PB;
		location = new Point(21, 16);
		((Control)obj9).Location = location;
		((Control)btn_PB).Name = "btn_PB";
		Button obj10 = btn_PB;
		size = new Size(75, 23);
		((Control)obj10).Size = size;
		((Control)btn_PB).TabIndex = 0;
		((ButtonBase)btn_PB).Text = "&Phân bổ";
		((ButtonBase)btn_PB).UseVisualStyleBackColor = true;
		((DataGridViewColumn)dgvcID).DataPropertyName = "ID";
		((DataGridViewColumn)dgvcID).Frozen = true;
		((DataGridViewColumn)dgvcID).HeaderText = "ID";
		((DataGridViewColumn)dgvcID).Name = "dgvcID";
		((DataGridViewColumn)dgvcID).Visible = false;
		((DataGridViewColumn)dgvcID).Width = 120;
		((DataGridViewColumn)dgvThang).DataPropertyName = "thang";
		((DataGridViewColumn)dgvThang).Frozen = true;
		((DataGridViewColumn)dgvThang).HeaderText = "Thang";
		((DataGridViewColumn)dgvThang).Name = "dgvThang";
		((DataGridViewColumn)dgvThang).Visible = false;
		((DataGridViewColumn)dgvcTk).DataPropertyName = "tk_nhan_pb";
		((DataGridViewColumn)dgvcTk).HeaderText = "TK nhận";
		((DataGridViewColumn)dgvcTk).Name = "dgvcTk";
		((DataGridViewColumn)dgvcTk).ReadOnly = true;
		((DataGridViewColumn)dgvcTk).Width = 80;
		((DataGridViewColumn)dgvcTen_tk).DataPropertyName = "Ten_tk";
		((DataGridViewColumn)dgvcTen_tk).HeaderText = "Tên tk";
		((DataGridViewColumn)dgvcTen_tk).Name = "dgvcTen_tk";
		((DataGridViewColumn)dgvcTen_tk).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_tk).Width = 200;
		((DataGridViewColumn)dgvcMa_spct).DataPropertyName = "Ma_spct";
		((DataGridViewColumn)dgvcMa_spct).HeaderText = "Mã SPCT";
		((DataGridViewColumn)dgvcMa_spct).Name = "dgvcMa_spct";
		((DataGridViewColumn)dgvcMa_spct).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_spct).Width = 80;
		((DataGridViewColumn)dgvcTen_spct).DataPropertyName = "ten_spct";
		((DataGridViewColumn)dgvcTen_spct).HeaderText = "Tên SPCT";
		((DataGridViewColumn)dgvcTen_spct).Name = "dgvcTen_spct";
		((DataGridViewColumn)dgvcTen_spct).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_spct).Width = 200;
		((DataGridViewColumn)dgvcMa_bo).HeaderText = "Mã BP";
		((DataGridViewColumn)dgvcMa_bo).Name = "dgvcMa_bo";
		((DataGridViewColumn)dgvcMa_bo).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_bo).Width = 80;
		((DataGridViewColumn)dgvcTen_Bp).HeaderText = "Tên bộ phận";
		((DataGridViewColumn)dgvcTen_Bp).Name = "dgvcTen_Bp";
		((DataGridViewColumn)dgvcTen_Bp).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_Bp).Width = 200;
		((DataGridViewColumn)dgvcTk_du).HeaderText = "Tk đ/ư";
		((DataGridViewColumn)dgvcTk_du).Name = "dgvcTk_du";
		((DataGridViewColumn)dgvcTk_du).ReadOnly = true;
		((DataGridViewColumn)dgvcTk_du).Width = 80;
		((DataGridViewColumn)dgvcTen_tk_du).HeaderText = "Tên tài khoản đối ứng";
		((DataGridViewColumn)dgvcTen_tk_du).Name = "dgvcTen_tk_du";
		((DataGridViewColumn)dgvcTen_tk_du).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_tk_du).Width = 200;
		((DataGridViewColumn)dgvcHe_so).DataPropertyName = "He_so";
		val3.Alignment = (DataGridViewContentAlignment)64;
		val3.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcHe_so).DefaultCellStyle = val3;
		((DataGridViewColumn)dgvcHe_so).HeaderText = "Hệ số";
		dgvcHe_so.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcHe_so).Name = "dgvcHe_so";
		((DataGridViewColumn)dgvcHe_so).Resizable = (DataGridViewTriState)1;
		dgvcHe_so.SortMode = (DataGridViewColumnSortMode)1;
		dgvcHe_so.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)dgvcHe_so).Width = 80;
		((DataGridViewColumn)dgvTien_nhan).DataPropertyName = "tien_nhan";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "### ### ### ###";
		((DataGridViewColumn)dgvTien_nhan).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvTien_nhan).FillWeight = 120f;
		((DataGridViewColumn)dgvTien_nhan).HeaderText = "Tiền nhận PB";
		dgvTien_nhan.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvTien_nhan).Name = "dgvTien_nhan";
		dgvTien_nhan.SortMode = (DataGridViewColumnSortMode)0;
		dgvTien_nhan.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)dgvcID_).DataPropertyName = "ID";
		((DataGridViewColumn)dgvcID_).HeaderText = "ID";
		((DataGridViewColumn)dgvcID_).Name = "dgvcID_";
		((DataGridViewColumn)dgvcID_).Visible = false;
		((DataGridViewColumn)dgvcTag).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)dgvcTag).DataPropertyName = "Tag";
		((DataGridViewColumn)dgvcTag).HeaderText = "Chọn";
		((DataGridViewColumn)dgvcTag).Name = "dgvcTag";
		((DataGridViewColumn)dgvcTag).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)dgvcTag).Width = 80;
		dgvcTen_bt.AutoFill = false;
		dgvcTen_bt.AutoLookup = false;
		dgvcTen_bt.AutoValid = false;
		((DataGridViewColumn)dgvcTen_bt).DataPropertyName = "Ten_bt";
		val5.BackColor = SystemColors.Window;
		((DataGridViewColumn)dgvcTen_bt).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcTen_bt).HeaderText = "Tên bút toán";
		dgvcTen_bt.LookupCodeName = "";
		dgvcTen_bt.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcTen_bt).Name = "dgvcTen_bt";
		((DataGridViewColumn)dgvcTen_bt).ReadOnly = true;
		dgvcTen_bt.ReceiverValidFieldList = "";
		((DataGridViewColumn)dgvcTen_bt).Resizable = (DataGridViewTriState)1;
		dgvcTen_bt.SD = false;
		dgvcTen_bt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTen_bt.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcTen_bt).Width = 300;
		((DataGridViewColumn)dgvcTheoSPCT).DataPropertyName = "THEOSPCT";
		((DataGridViewColumn)dgvcTheoSPCT).HeaderText = "SPCT";
		((DataGridViewColumn)dgvcTheoSPCT).Name = "dgvcTheoSPCT";
		((DataGridViewColumn)dgvcTheoSPCT).ReadOnly = true;
		((DataGridViewColumn)dgvcTheoSPCT).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcTheoSPCT).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcTheoBP).DataPropertyName = "THEOBP";
		((DataGridViewColumn)dgvcTheoBP).HeaderText = "Bộ phận";
		((DataGridViewColumn)dgvcTheoBP).Name = "dgvcTheoBP";
		((DataGridViewColumn)dgvcTheoBP).ReadOnly = true;
		((DataGridViewColumn)dgvcTheoBP).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcTheoBP).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcTheoTKDU).DataPropertyName = "THEOTKDU";
		((DataGridViewColumn)dgvcTheoTKDU).HeaderText = "TK đối ứng";
		((DataGridViewColumn)dgvcTheoTKDU).Name = "dgvcTheoTKDU";
		((DataGridViewColumn)dgvcTheoTKDU).ReadOnly = true;
		((DataGridViewColumn)dgvcTheoTKDU).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcTheoTKDU).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcTk_pb).DataPropertyName = "tk_pb";
		((DataGridViewColumn)dgvcTk_pb).HeaderText = "Tài khoản";
		((DataGridViewColumn)dgvcTk_pb).Name = "dgvcTk_pb";
		((DataGridViewColumn)dgvcTk_pb).ReadOnly = true;
		((DataGridViewColumn)dgvcTien_Pb).DataPropertyName = "tien_pb";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcTien_Pb).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcTien_Pb).HeaderText = "Tiền phân bổ";
		dgvcTien_Pb.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcTien_Pb).Name = "dgvcTien_Pb";
		dgvcTien_Pb.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_Pb.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)dgvcTien_Pb).Width = 120;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(1216, 544);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel3);
		((Control)this).Controls.Add((Control)(object)dgvDMPB);
		((Control)this).Controls.Add((Control)(object)GrB_KBC);
		((Control)this).Name = "frmCOPB";
		((Form)this).Text = "Phím cách - Đánh dấu, F4 - Tạo bút toán phân bổ, F8 - Xóa bút toán phân bổ, F5 - Điền hệ số phân bổ, Ctr+Tab - Chuyển màn hình";
		((Control)GrB_KBC).ResumeLayout(false);
		((Control)GrB_KBC).PerformLayout();
		((ISupportInitialize)dgvDMPB).EndInit();
		((Control)Panel3).ResumeLayout(false);
		((ISupportInitialize)dgvDMPB2).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void InitKyBaoCao()
	{
		((ComboBox)cboKyBc).DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc, "11100");
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
		try
		{
			if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"", false))
			{
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"NGAY", false))
				{
					txtNgay1.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct1"));
					txtNgay2.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct2"));
				}
				((ListControl)cboKyBc).SelectedValue = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao"));
			}
			else
			{
				((ComboBox)cboKyBc).SelectedIndex = 0;
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

	private void InitData()
	{
		dtDMPB1 = odao.GetDataPbPh(CompanyInformations.CompanyID, MyMenuInfo.moduleid);
		dtDMPB1.DefaultView.RowFilter = "ksd = 0";
		((DataGridView)dgvDMPB).DataSource = dtDMPB1.DefaultView;
	}

	private void InitData2()
	{
		dtDMPB2 = odao.GetDataPbCt(CompanyInformations.CompanyID, SystemInformations.FinancialYear, MyMenuInfo.moduleid);
		((DataGridView)dgvDMPB2).DataSource = dtDMPB2.DefaultView;
		if (dtDMPB1.DefaultView.Count == 0)
		{
			dtDMPB2.DefaultView.RowFilter = "1=2";
		}
	}

	private void InitSplitBtn()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		dtCBB = odao.GetDataTypePB(CompanyInformations.CompanyID, 0, MyMenuInfo.moduleid, SystemInformations.CurrentCultureName);
		checked
		{
			ToolStripMenuItem[] array = (ToolStripMenuItem[])(object)new ToolStripMenuItem[dtCBB.Rows.Count + 1];
			int num = 0;
			int num2 = dtCBB.Rows.Count - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = new ToolStripMenuItem();
				((ToolStripItem)array[num]).Name = "menustripitem" + dtCBB.Rows[num]["id"].ToString();
				((ToolStripItem)array[num]).Text = dtCBB.Rows[num]["ten"].ToString();
				((ToolStripItem)array[num]).Tag = dtCBB.Rows[num]["id"].ToString();
				((ToolStrip)ctmenu).Items.Add((ToolStripItem)(object)array[num]);
			}
			((ButtonBase)sbtn_DHS).Text = dtCBB.Rows[0]["ten"].ToString();
			((Control)sbtn_DHS).Tag = dtCBB.Rows[0]["id"].ToString();
			((Control)sbtn_DHS).ContextMenuStrip = ctmenu;
		}
	}

	private void calPBHS(DataRow dr)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["id"]), isNum: true)));
		if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["TheoSpct"]), isNum: true), (object)true, false))
		{
			arrayList.Add("MA_SPCT");
		}
		else if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["TheoBP"]), isNum: true), (object)true, false))
		{
			arrayList.Add("MA_BP");
		}
		else if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["TheoTKDU"]), isNum: true), (object)true, false))
		{
			arrayList.Add("TK_DU");
		}
		arrayList.Add(RuntimeHelpers.GetObjectValue(((Control)sbtn_DHS).Tag));
		odao.CalPBHS(arrayList.ToArray());
	}

	private void calPB(int id)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(id);
		arrayList.Add(MyMenuInfo.par1);
		arrayList.Add(SystemInformations.UserName);
		odao.CalPB(arrayList.ToArray());
	}

	private void DelcalPB(int id)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(id);
		arrayList.Add(MyMenuInfo.par1);
		arrayList.Add(SystemInformations.UserName);
		odao.DelcalPB(arrayList.ToArray());
	}

	private void UpdatePBHS(int id, int thang, string tk, string ma_spct, string ma_bp, string tk_du, double hs, double tien_nhan)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		int messID = 0;
		try
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(id);
			arrayList.Add(thang);
			arrayList.Add(tk);
			arrayList.Add(ma_spct);
			arrayList.Add(ma_bp);
			arrayList.Add(tk_du);
			arrayList.Add(hs);
			arrayList.Add(tien_nhan);
			messID = odao.UPdatePBHS(arrayList.ToArray());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			CMessageBox.Show(messID);
			ProjectData.ClearProjectError();
		}
	}

	private void btn_exit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void sbtn_DHS_Click(object sender, EventArgs e)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (!ValidateData())
		{
			CMessageBox.Show(50061);
			return;
		}
		try
		{
			DataRow[] array = dtDMPB1.Select("tag=1");
			foreach (DataRow dr in array)
			{
				calPBHS(dr);
			}
			CMessageBox.Show(50015);
			InitData2();
			dgvDMPB_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(99999);
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void btn_XPB_Click(object sender, EventArgs e)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(Conversions.ToDate(txtNgay2.Value), AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks) <= 0)
		{
			CMessageBox.Show(50136);
		}
		else if (!ValidateData())
		{
			CMessageBox.Show(50061);
		}
		else
		{
			if ((int)CMessageBox.Show(50058, SystemInformations.ProductFullName, (MessageBoxButtons)4) != 6)
			{
				return;
			}
			try
			{
				DataRow[] array = dtDMPB1.Select("tag=1");
				foreach (DataRow dataRow in array)
				{
					DelcalPB(Conversions.ToInteger(dataRow["id"]));
				}
				CMessageBox.Show(50015);
				InitData();
				InitData2();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				CMessageBox.Show(99999);
				Helper.ProcessError(ex2.ToString());
				ProjectData.ClearProjectError();
				return;
			}
			dgvDMPB_SelectionChanged(null, null);
		}
	}

	private void btn_PB_Click(object sender, EventArgs e)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(Conversions.ToDate(txtNgay2.Value), AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks) <= 0)
		{
			CMessageBox.Show(50136);
			return;
		}
		if (!ValidateData())
		{
			CMessageBox.Show(50061);
			return;
		}
		try
		{
			DataRow[] array = dtDMPB1.Select("tag=1");
			foreach (DataRow dataRow in array)
			{
				calPB(Conversions.ToInteger(dataRow["id"]));
			}
			CMessageBox.Show(50015);
			InitData();
			InitData2();
			dgvDMPB_SelectionChanged(null, null);
			chk_CheckAll.Checked = false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(99999);
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void frmCOPB_Load(object sender, EventArgs e)
	{
		((Form)this).Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)(base.MyMenuInfo.bar + "."), Interaction.IIf((((Control)btn_PB).Enabled && ((Control)btn_PB).Visible) ? true : false, (object)(" F4 - " + Strings.Replace(((ButtonBase)btn_PB).Text, "&", "", 1, -1, (CompareMethod)0) + ","), (object)"")), Interaction.IIf((((Control)btn_XPB).Enabled && ((Control)btn_XPB).Visible) ? true : false, (object)(" F8 - " + Strings.Replace(((ButtonBase)btn_XPB).Text, "&", "", 1, -1, (CompareMethod)0) + ","), (object)"")), (object)" F5 - "), (object)lblDien_hs.Text));
		isLoading = true;
		odao = (COPBDAO)DAOFactory.CreateDAOInstance("COPBDAO", "COPB");
		InitKyBaoCao();
		InitData();
		InitData2();
		InitSplitBtn();
		dgvDMPB_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
		isLoading = false;
	}

	private void frmCOPB_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
		if ((int)e.KeyCode == 115)
		{
			btn_PB.PerformClick();
		}
		if ((int)e.KeyCode == 119)
		{
			btn_XPB.PerformClick();
		}
		if ((int)e.KeyCode == 116)
		{
			((Button)sbtn_DHS).PerformClick();
		}
	}

	private void cboKyBc_SelectedValueChanged(object sender, EventArgs e)
	{
		if (((ComboBox)cboKyBc).DataSource != null)
		{
			if (Operators.CompareString(((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ma, "NGAY", false) != 0)
			{
				txtNgay1.Value = ((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ngay1;
				txtNgay2.Value = ((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ngay2;
				((MaskedTextBox)txtNgay1).ReadOnly = true;
				((Control)txtNgay1).TabStop = false;
				((MaskedTextBox)txtNgay2).ReadOnly = true;
				((Control)txtNgay2).TabStop = false;
			}
			else
			{
				((MaskedTextBox)txtNgay1).ReadOnly = false;
				((Control)txtNgay1).TabStop = true;
				((MaskedTextBox)txtNgay2).ReadOnly = false;
				((Control)txtNgay2).TabStop = true;
			}
			dgvDMPB_SelectionChanged(null, null);
		}
	}

	private void chk_CheckAll_CheckedChanged(object sender, EventArgs e)
	{
		if (!chk_CheckAll.Checked)
		{
			{
				foreach (DataRow row in dtDMPB1.Rows)
				{
					row["Tag"] = false;
				}
				return;
			}
		}
		foreach (DataRow row2 in dtDMPB1.Rows)
		{
			row2["Tag"] = true;
		}
	}

	private void dgvDMPB_SelectionChanged(object sender, EventArgs e)
	{
		if (!isLoading && ((DataGridView)dgvDMPB).Rows.Count > 0 && dtDMPB2 != null && ((DataGridViewBand)((DataGridView)dgvDMPB).CurrentRow).Index >= 0)
		{
			string text = "";
			text = text + "id=" + ((DataGridView)dgvDMPB).Rows[((DataGridViewBand)((DataGridView)dgvDMPB).CurrentRow).Index].Cells["dgvcID_"].Value.ToString();
			text = text + " and thang >= " + DateAndTime.Month(Conversions.ToDate(txtNgay1.Value)) + " and thang <= " + DateAndTime.Month(Conversions.ToDate(txtNgay2.Value));
			dtDMPB2.DefaultView.RowFilter = text;
		}
	}

	private void dgvDMPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (((DataGridViewBand)((DataGridView)dgvDMPB).CurrentRow).Index > 0 && ((DataGridView)dgvDMPB).CurrentCell.ColumnIndex == ((DataGridViewBand)((DataGridView)dgvDMPB).Columns["dgvcTag"]).Index)
		{
			dtDMPB1.Rows[((DataGridViewBand)((DataGridView)dgvDMPB).CurrentRow).Index]["TAG"] = Operators.NotObject(dtDMPB1.Rows[((DataGridViewBand)((DataGridView)dgvDMPB).CurrentRow).Index]["TAG"]);
		}
	}

	private void ctmenu_Click(object sender, ToolStripItemClickedEventArgs e)
	{
		((ButtonBase)sbtn_DHS).Text = e.ClickedItem.Text;
		((Control)sbtn_DHS).Tag = RuntimeHelpers.GetObjectValue(e.ClickedItem.Tag);
	}

	private void dgvDMPB2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (dtDMPB2 == null)
		{
			return;
		}
		((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvDMPB2).DataSource)].EndCurrentEdit();
		if (dtDMPB2.GetChanges() == null)
		{
			return;
		}
		try
		{
			DataRowView dataRowView = dtDMPB2.DefaultView[e.RowIndex];
			UpdatePBHS(Conversions.ToInteger(dataRowView["id"]), Conversions.ToInteger(dataRowView["thang"]), Conversions.ToString(dataRowView["tk_nhan_pb"]), Conversions.ToString(dataRowView["ma_spct"]), Conversions.ToString(dataRowView["ma_bp"]), string.Empty, Conversions.ToDouble(dataRowView["he_so"]), Conversions.ToDouble(dataRowView["tien_nhan"]));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void frmCOPB_FormClosing(object sender, FormClosingEventArgs e)
	{
		odao.Destroy();
	}

	private bool ValidateData()
	{
		((DataGridView)dgvDMPB).EndEdit();
		((Control)dgvDMPB).Refresh();
		if (dtDMPB1.Select("tag=1").Length > 0)
		{
			return true;
		}
		return false;
	}
}
