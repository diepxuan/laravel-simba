using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmMainTools : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("btnExit")]
	private Button _btnExit;

	[AccessedThroughProperty("tabTools")]
	private TabControl _tabTools;

	[AccessedThroughProperty("tabMenu")]
	private TabPage _tabMenu;

	[AccessedThroughProperty("fontDialog")]
	private FontDialog _fontDialog;

	[AccessedThroughProperty("btnSave")]
	private SplitButton _btnSave;

	[AccessedThroughProperty("ctMenuTool")]
	private ContextMenuStrip _ctMenuTool;

	[AccessedThroughProperty("RestartToolStripMenuItem")]
	private ToolStripMenuItem _RestartToolStripMenuItem;

	[AccessedThroughProperty("btnGen_FieldList")]
	private Button _btnGen_FieldList;

	[AccessedThroughProperty("tabMenuAll")]
	private TabControl _tabMenuAll;

	[AccessedThroughProperty("tabListMenu")]
	private TabPage _tabListMenu;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("splReports")]
	private SplitContainer _splReports;

	[AccessedThroughProperty("asDgvReport")]
	private AsDataGridView _asDgvReport;

	[AccessedThroughProperty("asDgvReportRex")]
	private AsDataGridView _asDgvReportRex;

	[AccessedThroughProperty("cmbMenu")]
	private ComboBox _cmbMenu;

	[AccessedThroughProperty("btnCreate")]
	private Button _btnCreate;

	[AccessedThroughProperty("cmbModuleFunc")]
	private ComboBox _cmbModuleFunc;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("cmbModule")]
	private ComboBox _cmbModule;

	[AccessedThroughProperty("cmbTranfer")]
	private ComboBox _cmbTranfer;

	[AccessedThroughProperty("tabRepDrillDown")]
	private TabPage _tabRepDrillDown;

	[AccessedThroughProperty("asdgvReportDrillDown")]
	private AsDataGridView _asdgvReportDrillDown;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	private DataTable f_dtCompany;

	private DataTable f_dtModule;

	private DataTable f_dtModuleFunc;

	private DataTable f_dtAllMenu;

	private DataTable f_dtDmStore;

	private DataTable f_dtPara;

	private DataTable f_dtDic;

	private DataTable f_dtDicRex;

	private DataTable f_dtReport;

	private DataTable f_dtReportRex;

	private DataTable f_dtVoucher;

	private DataTable f_dtVoucherRex;

	private DataTable f_dtDaoInfo;

	private DataTable f_dtReportDrillDown;

	private DataTable f_dtTemp;

	private XmlDocument xmldoc;

	private string strFilterModule;

	private string strFilterModuleFunc;

	private string PassRight;

	private bool checkRight;

	private DataRow rowToCopy;

	internal virtual Button btnExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnExit_Click;
			if (_btnExit != null)
			{
				((Control)_btnExit).Click -= eventHandler;
			}
			_btnExit = value;
			if (_btnExit != null)
			{
				((Control)_btnExit).Click += eventHandler;
			}
		}
	}

	internal virtual TabControl tabTools
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabTools;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			TabControlCancelEventHandler val = new TabControlCancelEventHandler(tabTools_Selecting);
			if (_tabTools != null)
			{
				_tabTools.Selecting -= val;
			}
			_tabTools = value;
			if (_tabTools != null)
			{
				_tabTools.Selecting += val;
			}
		}
	}

	internal virtual TabPage tabMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabMenu = value;
		}
	}

	private virtual FontDialog fontDialog
	{
		[DebuggerNonUserCode]
		get
		{
			return _fontDialog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fontDialog = value;
		}
	}

	internal virtual SplitButton btnSave
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnSave_Click;
			if (_btnSave != null)
			{
				((Control)_btnSave).Click -= eventHandler;
			}
			_btnSave = value;
			if (_btnSave != null)
			{
				((Control)_btnSave).Click += eventHandler;
			}
		}
	}

	internal virtual ContextMenuStrip ctMenuTool
	{
		[DebuggerNonUserCode]
		get
		{
			return _ctMenuTool;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ctMenuTool = value;
		}
	}

	internal virtual ToolStripMenuItem RestartToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RestartToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RestartToolStripMenuItem_Click;
			if (_RestartToolStripMenuItem != null)
			{
				((ToolStripItem)_RestartToolStripMenuItem).Click -= eventHandler;
			}
			_RestartToolStripMenuItem = value;
			if (_RestartToolStripMenuItem != null)
			{
				((ToolStripItem)_RestartToolStripMenuItem).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnGen_FieldList
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnGen_FieldList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnGen_FieldList_Click;
			if (_btnGen_FieldList != null)
			{
				((Control)_btnGen_FieldList).Click -= eventHandler;
			}
			_btnGen_FieldList = value;
			if (_btnGen_FieldList != null)
			{
				((Control)_btnGen_FieldList).Click += eventHandler;
			}
		}
	}

	internal virtual TabControl tabMenuAll
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabMenuAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tabMenuAll_SelectedIndexChanged;
			if (_tabMenuAll != null)
			{
				_tabMenuAll.SelectedIndexChanged -= eventHandler;
			}
			_tabMenuAll = value;
			if (_tabMenuAll != null)
			{
				_tabMenuAll.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual TabPage tabListMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabListMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabListMenu = value;
		}
	}

	internal virtual Panel Panel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel4 = value;
		}
	}

	internal virtual SplitContainer splReports
	{
		[DebuggerNonUserCode]
		get
		{
			return _splReports;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_splReports = value;
		}
	}

	internal virtual AsDataGridView asDgvReport
	{
		[DebuggerNonUserCode]
		get
		{
			return _asDgvReport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(asDgvReport_KeyDown);
			EventHandler eventHandler = asDgvReport_SelectionChanged;
			DataGridViewDataErrorEventHandler val2 = new DataGridViewDataErrorEventHandler(asDgvReport_DataError);
			if (_asDgvReport != null)
			{
				((Control)_asDgvReport).KeyDown -= val;
				((DataGridView)_asDgvReport).SelectionChanged -= eventHandler;
				((DataGridView)_asDgvReport).DataError -= val2;
			}
			_asDgvReport = value;
			if (_asDgvReport != null)
			{
				((Control)_asDgvReport).KeyDown += val;
				((DataGridView)_asDgvReport).SelectionChanged += eventHandler;
				((DataGridView)_asDgvReport).DataError += val2;
			}
		}
	}

	internal virtual AsDataGridView asDgvReportRex
	{
		[DebuggerNonUserCode]
		get
		{
			return _asDgvReportRex;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_asDgvReportRex = value;
		}
	}

	internal virtual ComboBox cmbMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbMenu_SelectedValueChanged;
			if (_cmbMenu != null)
			{
				((ListControl)_cmbMenu).SelectedValueChanged -= eventHandler;
			}
			_cmbMenu = value;
			if (_cmbMenu != null)
			{
				((ListControl)_cmbMenu).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Button btnCreate
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnCreate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnCreate_Click;
			if (_btnCreate != null)
			{
				((Control)_btnCreate).Click -= eventHandler;
			}
			_btnCreate = value;
			if (_btnCreate != null)
			{
				((Control)_btnCreate).Click += eventHandler;
			}
		}
	}

	internal virtual ComboBox cmbModuleFunc
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbModuleFunc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbModuleFunc_SelectedValueChanged;
			if (_cmbModuleFunc != null)
			{
				((ListControl)_cmbModuleFunc).SelectedValueChanged -= eventHandler;
			}
			_cmbModuleFunc = value;
			if (_cmbModuleFunc != null)
			{
				((ListControl)_cmbModuleFunc).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual ComboBox cmbModule
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbModule;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbModule_SelectedValueChanged;
			if (_cmbModule != null)
			{
				((ListControl)_cmbModule).SelectedValueChanged -= eventHandler;
			}
			_cmbModule = value;
			if (_cmbModule != null)
			{
				((ListControl)_cmbModule).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual ComboBox cmbTranfer
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbTranfer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbTranfer = value;
		}
	}

	internal virtual TabPage tabRepDrillDown
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabRepDrillDown;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabRepDrillDown = value;
		}
	}

	internal virtual AsDataGridView asdgvReportDrillDown
	{
		[DebuggerNonUserCode]
		get
		{
			return _asdgvReportDrillDown;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			DataGridViewDataErrorEventHandler val = new DataGridViewDataErrorEventHandler(asdgvReportDrillDown_DataError);
			KeyEventHandler val2 = new KeyEventHandler(asdgvReportDrillDown_KeyDown);
			if (_asdgvReportDrillDown != null)
			{
				((DataGridView)_asdgvReportDrillDown).DataError -= val;
				((Control)_asdgvReportDrillDown).KeyDown -= val2;
			}
			_asdgvReportDrillDown = value;
			if (_asdgvReportDrillDown != null)
			{
				((DataGridView)_asdgvReportDrillDown).DataError += val;
				((Control)_asdgvReportDrillDown).KeyDown += val2;
			}
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
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

	public frmMainTools(string menuid)
		: base(menuid)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmMainTools_KeyDown);
		((Form)this).Load += frmMainTools_Load;
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		f_dtCompany = new DataTable();
		f_dtModule = new DataTable();
		f_dtModuleFunc = new DataTable();
		f_dtAllMenu = new DataTable();
		f_dtDmStore = new DataTable();
		f_dtPara = new DataTable();
		f_dtDic = new DataTable();
		f_dtDicRex = new DataTable();
		f_dtReport = new DataTable();
		f_dtReportRex = new DataTable();
		f_dtVoucher = new DataTable();
		f_dtVoucherRex = new DataTable();
		f_dtDaoInfo = new DataTable();
		f_dtReportDrillDown = new DataTable();
		f_dtTemp = new DataTable();
		strFilterModule = " ";
		strFilterModuleFunc = " ";
		PassRight = "";
		checkRight = false;
		rowToCopy = null;
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0054: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a12: Expected O, but got Unknown
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8e: Expected O, but got Unknown
		//IL_0b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6b: Expected O, but got Unknown
		//IL_0c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7a: Expected O, but got Unknown
		//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf6: Expected O, but got Unknown
		//IL_0dbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc6: Expected O, but got Unknown
		//IL_1308: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13db: Expected O, but got Unknown
		//IL_1445: Unknown result type (might be due to invalid IL or missing references)
		//IL_144f: Expected O, but got Unknown
		//IL_151a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1524: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMainTools));
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
		Panel1 = new Panel();
		btnGen_FieldList = new Button();
		btnSave = new SplitButton();
		ctMenuTool = new ContextMenuStrip(components);
		RestartToolStripMenuItem = new ToolStripMenuItem();
		btnExit = new Button();
		tabTools = new TabControl();
		tabMenu = new TabPage();
		tabMenuAll = new TabControl();
		tabListMenu = new TabPage();
		Panel4 = new Panel();
		splReports = new SplitContainer();
		asDgvReport = new AsDataGridView();
		asDgvReportRex = new AsDataGridView();
		Panel2 = new Panel();
		cmbMenu = new ComboBox();
		btnCreate = new Button();
		cmbModuleFunc = new ComboBox();
		Label12 = new Label();
		Label13 = new Label();
		cmbModule = new ComboBox();
		cmbTranfer = new ComboBox();
		tabRepDrillDown = new TabPage();
		asdgvReportDrillDown = new AsDataGridView();
		fontDialog = new FontDialog();
		((Control)Panel1).SuspendLayout();
		((Control)ctMenuTool).SuspendLayout();
		((Control)tabTools).SuspendLayout();
		((Control)tabMenu).SuspendLayout();
		((Control)tabMenuAll).SuspendLayout();
		((Control)tabListMenu).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((Control)splReports.Panel1).SuspendLayout();
		((Control)splReports.Panel2).SuspendLayout();
		((Control)splReports).SuspendLayout();
		((ISupportInitialize)asDgvReport).BeginInit();
		((ISupportInitialize)asDgvReportRex).BeginInit();
		((Control)Panel2).SuspendLayout();
		((Control)tabRepDrillDown).SuspendLayout();
		((ISupportInitialize)asdgvReportDrillDown).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).Controls.Add((Control)(object)btnGen_FieldList);
		((Control)Panel1).Controls.Add((Control)(object)btnSave);
		((Control)Panel1).Controls.Add((Control)(object)btnExit);
		((Control)Panel1).Dock = (DockStyle)2;
		Panel panel = Panel1;
		Point location = new Point(0, 413);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		Size size = new Size(823, 39);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 1;
		((Control)btnGen_FieldList).Anchor = (AnchorStyles)10;
		Button obj = btnGen_FieldList;
		location = new Point(582, 6);
		((Control)obj).Location = location;
		((Control)btnGen_FieldList).Name = "btnGen_FieldList";
		Button obj2 = btnGen_FieldList;
		size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)btnGen_FieldList).TabIndex = 2;
		((ButtonBase)btnGen_FieldList).Text = "&Gen Field";
		((ButtonBase)btnGen_FieldList).UseVisualStyleBackColor = true;
		((Control)btnSave).Anchor = (AnchorStyles)10;
		((Control)btnSave).ContextMenuStrip = ctMenuTool;
		btnSave.EnableSplit = true;
		((ButtonBase)btnSave).Image = (Image)componentResourceManager.GetObject("btnSave.Image");
		btnSave.ImageHeight = 4;
		btnSave.ImageWidth = 7;
		SplitButton splitButton = btnSave;
		location = new Point(663, 6);
		((Control)splitButton).Location = location;
		((Control)btnSave).Name = "btnSave";
		SplitButton splitButton2 = btnSave;
		size = new Size(72, 23);
		((Control)splitButton2).Size = size;
		btnSave.SplitWidth = 15;
		((Control)btnSave).TabIndex = 0;
		((ButtonBase)btnSave).Text = "&Lưu";
		((ButtonBase)btnSave).UseVisualStyleBackColor = true;
		((ToolStrip)ctMenuTool).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)RestartToolStripMenuItem });
		((Control)ctMenuTool).Name = "ctMenuTool";
		((ToolStrip)ctMenuTool).RenderMode = (ToolStripRenderMode)2;
		ContextMenuStrip obj3 = ctMenuTool;
		size = new Size(161, 26);
		((Control)obj3).Size = size;
		((ToolStripItem)RestartToolStripMenuItem).Name = "RestartToolStripMenuItem";
		RestartToolStripMenuItem.ShortcutKeys = (Keys)131154;
		ToolStripMenuItem restartToolStripMenuItem = RestartToolStripMenuItem;
		size = new Size(160, 22);
		((ToolStripItem)restartToolStripMenuItem).Size = size;
		((ToolStripItem)RestartToolStripMenuItem).Text = "Restart";
		((Control)btnExit).Anchor = (AnchorStyles)10;
		((ButtonBase)btnExit).Image = (Image)componentResourceManager.GetObject("btnExit.Image");
		((ButtonBase)btnExit).ImageAlign = (ContentAlignment)16;
		Button obj4 = btnExit;
		location = new Point(741, 6);
		((Control)obj4).Location = location;
		((Control)btnExit).Name = "btnExit";
		Button obj5 = btnExit;
		size = new Size(75, 23);
		((Control)obj5).Size = size;
		((Control)btnExit).TabIndex = 1;
		((ButtonBase)btnExit).Text = "&Thoát";
		((ButtonBase)btnExit).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnExit).UseVisualStyleBackColor = true;
		((Control)tabTools).Controls.Add((Control)(object)tabMenu);
		((Control)tabTools).Dock = (DockStyle)5;
		TabControl obj6 = tabTools;
		location = new Point(0, 0);
		((Control)obj6).Location = location;
		((Control)tabTools).Name = "tabTools";
		tabTools.SelectedIndex = 0;
		TabControl obj7 = tabTools;
		size = new Size(823, 413);
		((Control)obj7).Size = size;
		((Control)tabTools).TabIndex = 0;
		((Control)tabMenu).Controls.Add((Control)(object)tabMenuAll);
		TabPage obj8 = tabMenu;
		location = new Point(4, 22);
		obj8.Location = location;
		((Control)tabMenu).Name = "tabMenu";
		TabPage obj9 = tabMenu;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)obj9).Padding = padding;
		TabPage obj10 = tabMenu;
		size = new Size(815, 387);
		((Control)obj10).Size = size;
		tabMenu.TabIndex = 2;
		tabMenu.Text = "Khai báo menu ";
		tabMenu.UseVisualStyleBackColor = true;
		((Control)tabMenuAll).Controls.Add((Control)(object)tabListMenu);
		((Control)tabMenuAll).Controls.Add((Control)(object)tabRepDrillDown);
		((Control)tabMenuAll).Dock = (DockStyle)5;
		TabControl obj11 = tabMenuAll;
		location = new Point(3, 3);
		((Control)obj11).Location = location;
		((Control)tabMenuAll).Name = "tabMenuAll";
		tabMenuAll.SelectedIndex = 0;
		TabControl obj12 = tabMenuAll;
		size = new Size(809, 381);
		((Control)obj12).Size = size;
		((Control)tabMenuAll).TabIndex = 0;
		((Control)tabListMenu).Controls.Add((Control)(object)Panel4);
		((Control)tabListMenu).Controls.Add((Control)(object)Panel2);
		TabPage obj13 = tabListMenu;
		location = new Point(4, 22);
		obj13.Location = location;
		((Control)tabListMenu).Name = "tabListMenu";
		TabPage obj14 = tabListMenu;
		((Padding)(ref padding))._002Ector(3);
		((Control)obj14).Padding = padding;
		TabPage obj15 = tabListMenu;
		size = new Size(801, 355);
		((Control)obj15).Size = size;
		tabListMenu.TabIndex = 0;
		tabListMenu.Text = "Menu";
		tabListMenu.UseVisualStyleBackColor = true;
		((Control)Panel4).Controls.Add((Control)(object)splReports);
		((Control)Panel4).Dock = (DockStyle)5;
		Panel panel3 = Panel4;
		location = new Point(3, 79);
		((Control)panel3).Location = location;
		((Control)Panel4).Name = "Panel4";
		Panel panel4 = Panel4;
		size = new Size(795, 273);
		((Control)panel4).Size = size;
		((Control)Panel4).TabIndex = 3;
		splReports.Dock = (DockStyle)5;
		SplitContainer obj16 = splReports;
		location = new Point(0, 0);
		((Control)obj16).Location = location;
		((Control)splReports).Name = "splReports";
		splReports.Orientation = (Orientation)0;
		((Control)splReports.Panel1).Controls.Add((Control)(object)asDgvReport);
		((Control)splReports.Panel2).Controls.Add((Control)(object)asDgvReportRex);
		SplitContainer obj17 = splReports;
		size = new Size(795, 273);
		((Control)obj17).Size = size;
		splReports.SplitterDistance = 139;
		((Control)splReports).TabIndex = 3;
		((DataGridView)asDgvReport).AllowUserToAddRows = false;
		((DataGridView)asDgvReport).AllowUserToDeleteRows = false;
		val.BackColor = Color.AliceBlue;
		((DataGridView)asDgvReport).AlternatingRowsDefaultCellStyle = val;
		((DataGridView)asDgvReport).BackgroundColor = Color.White;
		((DataGridView)asDgvReport).BorderStyle = (BorderStyle)2;
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Control;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.WindowText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvReport).ColumnHeadersDefaultCellStyle = val2;
		((DataGridView)asDgvReport).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = SystemColors.Window;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.ControlText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDgvReport).DefaultCellStyle = val3;
		((Control)asDgvReport).Dock = (DockStyle)5;
		asDgvReport.DoubleBuffered = false;
		((DataGridView)asDgvReport).EditMode = (DataGridViewEditMode)1;
		((DataGridView)asDgvReport).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = asDgvReport;
		location = new Point(0, 0);
		((Control)asDataGridView).Location = location;
		((DataGridView)asDgvReport).MultiSelect = false;
		((Control)asDgvReport).Name = "asDgvReport";
		val4.Alignment = (DataGridViewContentAlignment)32;
		val4.BackColor = SystemColors.Control;
		val4.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val4.ForeColor = SystemColors.WindowText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvReport).RowHeadersDefaultCellStyle = val4;
		asDgvReport.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDgvReport).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = asDgvReport;
		size = new Size(795, 139);
		((Control)asDataGridView2).Size = size;
		((Control)asDgvReport).TabIndex = 0;
		((DataGridView)asDgvReportRex).AllowUserToAddRows = false;
		((DataGridView)asDgvReportRex).AllowUserToDeleteRows = false;
		val5.BackColor = Color.AliceBlue;
		((DataGridView)asDgvReportRex).AlternatingRowsDefaultCellStyle = val5;
		((DataGridView)asDgvReportRex).BackgroundColor = Color.White;
		((DataGridView)asDgvReportRex).BorderStyle = (BorderStyle)2;
		val6.Alignment = (DataGridViewContentAlignment)16;
		val6.BackColor = SystemColors.Control;
		val6.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val6.ForeColor = SystemColors.WindowText;
		val6.SelectionBackColor = SystemColors.Highlight;
		val6.SelectionForeColor = SystemColors.HighlightText;
		val6.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvReportRex).ColumnHeadersDefaultCellStyle = val6;
		((DataGridView)asDgvReportRex).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val7.Alignment = (DataGridViewContentAlignment)16;
		val7.BackColor = SystemColors.Window;
		val7.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val7.ForeColor = SystemColors.ControlText;
		val7.SelectionBackColor = SystemColors.Highlight;
		val7.SelectionForeColor = SystemColors.HighlightText;
		val7.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDgvReportRex).DefaultCellStyle = val7;
		((Control)asDgvReportRex).Dock = (DockStyle)5;
		asDgvReportRex.DoubleBuffered = false;
		((DataGridView)asDgvReportRex).EditMode = (DataGridViewEditMode)1;
		((DataGridView)asDgvReportRex).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView3 = asDgvReportRex;
		location = new Point(0, 0);
		((Control)asDataGridView3).Location = location;
		((Control)asDgvReportRex).Name = "asDgvReportRex";
		val8.Alignment = (DataGridViewContentAlignment)32;
		val8.BackColor = SystemColors.Control;
		val8.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val8.ForeColor = SystemColors.WindowText;
		val8.SelectionBackColor = SystemColors.Highlight;
		val8.SelectionForeColor = SystemColors.HighlightText;
		val8.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvReportRex).RowHeadersDefaultCellStyle = val8;
		asDgvReportRex.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDgvReportRex).RowTemplate.Height = 20;
		AsDataGridView asDataGridView4 = asDgvReportRex;
		size = new Size(795, 130);
		((Control)asDataGridView4).Size = size;
		((Control)asDgvReportRex).TabIndex = 1;
		((Control)Panel2).Controls.Add((Control)(object)cmbMenu);
		((Control)Panel2).Controls.Add((Control)(object)btnCreate);
		((Control)Panel2).Controls.Add((Control)(object)cmbModuleFunc);
		((Control)Panel2).Controls.Add((Control)(object)Label12);
		((Control)Panel2).Controls.Add((Control)(object)Label13);
		((Control)Panel2).Controls.Add((Control)(object)cmbModule);
		((Control)Panel2).Controls.Add((Control)(object)cmbTranfer);
		((Control)Panel2).Dock = (DockStyle)1;
		Panel panel5 = Panel2;
		location = new Point(3, 3);
		((Control)panel5).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel6 = Panel2;
		size = new Size(795, 76);
		((Control)panel6).Size = size;
		((Control)Panel2).TabIndex = 2;
		cmbMenu.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cmbMenu).FormattingEnabled = true;
		ComboBox obj18 = cmbMenu;
		location = new Point(323, 41);
		((Control)obj18).Location = location;
		((Control)cmbMenu).Name = "cmbMenu";
		ComboBox obj19 = cmbMenu;
		size = new Size(293, 21);
		((Control)obj19).Size = size;
		((Control)cmbMenu).TabIndex = 5;
		Button obj20 = btnCreate;
		location = new Point(717, 39);
		((Control)obj20).Location = location;
		((Control)btnCreate).Name = "btnCreate";
		Button obj21 = btnCreate;
		size = new Size(75, 23);
		((Control)obj21).Size = size;
		((Control)btnCreate).TabIndex = 4;
		((ButtonBase)btnCreate).Text = "Thêm mới";
		((ButtonBase)btnCreate).UseVisualStyleBackColor = true;
		((Control)btnCreate).Visible = false;
		cmbModuleFunc.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cmbModuleFunc).FormattingEnabled = true;
		ComboBox obj22 = cmbModuleFunc;
		location = new Point(124, 41);
		((Control)obj22).Location = location;
		((Control)cmbModuleFunc).Name = "cmbModuleFunc";
		ComboBox obj23 = cmbModuleFunc;
		size = new Size(193, 21);
		((Control)obj23).Size = size;
		((Control)cmbModuleFunc).TabIndex = 1;
		Label12.AutoSize = true;
		Label label = Label12;
		location = new Point(10, 17);
		((Control)label).Location = location;
		((Control)Label12).Name = "Label12";
		Label label2 = Label12;
		size = new Size(42, 13);
		((Control)label2).Size = size;
		((Control)Label12).TabIndex = 0;
		Label12.Text = "Module";
		Label13.AutoSize = true;
		Label label3 = Label13;
		location = new Point(10, 44);
		((Control)label3).Location = location;
		((Control)Label13).Name = "Label13";
		Label label4 = Label13;
		size = new Size(83, 13);
		((Control)label4).Size = size;
		((Control)Label13).TabIndex = 2;
		Label13.Text = "Module function";
		cmbModule.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cmbModule).FormattingEnabled = true;
		ComboBox obj24 = cmbModule;
		location = new Point(124, 14);
		((Control)obj24).Location = location;
		((Control)cmbModule).Name = "cmbModule";
		ComboBox obj25 = cmbModule;
		size = new Size(193, 21);
		((Control)obj25).Size = size;
		((Control)cmbModule).TabIndex = 0;
		cmbTranfer.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cmbTranfer).FormattingEnabled = true;
		cmbTranfer.Items.AddRange(new object[3] { "0 - DictionaryInfo", "1 - ReportInfo", "2 - VoucherInfo" });
		ComboBox obj26 = cmbTranfer;
		location = new Point(622, 41);
		((Control)obj26).Location = location;
		((Control)cmbTranfer).Name = "cmbTranfer";
		ComboBox obj27 = cmbTranfer;
		size = new Size(93, 21);
		((Control)obj27).Size = size;
		((Control)cmbTranfer).TabIndex = 2;
		((Control)cmbTranfer).Visible = false;
		((Control)tabRepDrillDown).Controls.Add((Control)(object)asdgvReportDrillDown);
		TabPage obj28 = tabRepDrillDown;
		location = new Point(4, 22);
		obj28.Location = location;
		((Control)tabRepDrillDown).Name = "tabRepDrillDown";
		TabPage obj29 = tabRepDrillDown;
		((Padding)(ref padding))._002Ector(3);
		((Control)obj29).Padding = padding;
		TabPage obj30 = tabRepDrillDown;
		size = new Size(801, 355);
		((Control)obj30).Size = size;
		tabRepDrillDown.TabIndex = 5;
		tabRepDrillDown.Text = "RepDrillDown";
		tabRepDrillDown.UseVisualStyleBackColor = true;
		((DataGridView)asdgvReportDrillDown).AllowUserToAddRows = false;
		((DataGridView)asdgvReportDrillDown).AllowUserToDeleteRows = false;
		val9.BackColor = Color.AliceBlue;
		((DataGridView)asdgvReportDrillDown).AlternatingRowsDefaultCellStyle = val9;
		((DataGridView)asdgvReportDrillDown).BackgroundColor = Color.White;
		((DataGridView)asdgvReportDrillDown).BorderStyle = (BorderStyle)2;
		val10.Alignment = (DataGridViewContentAlignment)16;
		val10.BackColor = SystemColors.Control;
		val10.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val10.ForeColor = SystemColors.WindowText;
		val10.SelectionBackColor = SystemColors.Highlight;
		val10.SelectionForeColor = SystemColors.HighlightText;
		val10.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asdgvReportDrillDown).ColumnHeadersDefaultCellStyle = val10;
		((DataGridView)asdgvReportDrillDown).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val11.Alignment = (DataGridViewContentAlignment)16;
		val11.BackColor = SystemColors.Window;
		val11.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val11.ForeColor = SystemColors.ControlText;
		val11.SelectionBackColor = SystemColors.Highlight;
		val11.SelectionForeColor = SystemColors.HighlightText;
		val11.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asdgvReportDrillDown).DefaultCellStyle = val11;
		((Control)asdgvReportDrillDown).Dock = (DockStyle)5;
		asdgvReportDrillDown.DoubleBuffered = false;
		((DataGridView)asdgvReportDrillDown).EditMode = (DataGridViewEditMode)1;
		asdgvReportDrillDown.EnabledExport2Excel = true;
		((DataGridView)asdgvReportDrillDown).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView5 = asdgvReportDrillDown;
		location = new Point(3, 3);
		((Control)asDataGridView5).Location = location;
		((Control)asdgvReportDrillDown).Name = "asdgvReportDrillDown";
		val12.Alignment = (DataGridViewContentAlignment)32;
		val12.BackColor = SystemColors.Control;
		val12.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val12.ForeColor = SystemColors.WindowText;
		val12.SelectionBackColor = SystemColors.Highlight;
		val12.SelectionForeColor = SystemColors.HighlightText;
		val12.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asdgvReportDrillDown).RowHeadersDefaultCellStyle = val12;
		asdgvReportDrillDown.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asdgvReportDrillDown).RowTemplate.Height = 20;
		AsDataGridView asDataGridView6 = asdgvReportDrillDown;
		size = new Size(795, 349);
		((Control)asDataGridView6).Size = size;
		((Control)asdgvReportDrillDown).TabIndex = 1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(823, 452);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)tabTools);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Name = "frmMainTools";
		((Control)this).Tag = "0";
		((Form)this).Text = "AsiaTools - Can sao luu du lieu truoc khi thuc hien ";
		((Control)Panel1).ResumeLayout(false);
		((Control)ctMenuTool).ResumeLayout(false);
		((Control)tabTools).ResumeLayout(false);
		((Control)tabMenu).ResumeLayout(false);
		((Control)tabMenuAll).ResumeLayout(false);
		((Control)tabListMenu).ResumeLayout(false);
		((Control)Panel4).ResumeLayout(false);
		((Control)splReports.Panel1).ResumeLayout(false);
		((Control)splReports.Panel2).ResumeLayout(false);
		((Control)splReports).ResumeLayout(false);
		((ISupportInitialize)asDgvReport).EndInit();
		((ISupportInitialize)asDgvReportRex).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)tabRepDrillDown).ResumeLayout(false);
		((ISupportInitialize)asdgvReportDrillDown).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmMainTools_Load(object sender, EventArgs e)
	{
		if ((tabTools.SelectedIndex == 0) | (tabTools.SelectedIndex == 1))
		{
			((Control)btnSave).Enabled = true;
		}
		else
		{
			((Control)btnSave).Enabled = false;
		}
		GetAllMenuInfo();
		GetAllSys();
		cmbTranfer.SelectedIndex = 2;
		cmbMenu_SelectedValueChanged(null, null);
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		try
		{
			UpdateDBReport();
			UpdateDBReportRex();
			UpdateReportDrillDown();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			flag = true;
			Helper.ProcessError(ex2);
			CMessageBox.Show(99999);
			ProjectData.ClearProjectError();
		}
		if (!flag)
		{
			CMessageBox.Show(50015);
		}
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void frmMainTools_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
		if ((int)e.KeyCode == 13)
		{
			SendKeys.Send("{TAB}");
		}
		if ((e.Control && (int)e.KeyCode == 82) ? true : false)
		{
			RestartToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
		}
	}

	private void tabTools_Selecting(object sender, TabControlCancelEventArgs e)
	{
	}

	private void btnCreateCompany_Click(object sender, EventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		int selectedIndex = tabTools.SelectedIndex;
		if (selectedIndex == 1)
		{
			frmCreateCompany frmCreateCompany2 = new frmCreateCompany();
			frmCreateCompany2.cmbListCompany.DataSource = f_dtCompany.DefaultView;
			((ListControl)frmCreateCompany2.cmbListCompany).ValueMember = "ma_cty";
			((ListControl)frmCreateCompany2.cmbListCompany).DisplayMember = "ten_cty1";
			frmCreateCompany2.MyMenuInfo = MyMenuInfo;
			((Form)frmCreateCompany2).ShowDialog();
		}
	}

	private void F5asDgvReport(bool is_F5)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		string filterExpression = "menuid= '" + ((DataGridView)asDgvReport).CurrentRow.Cells["menuid"].Value.ToString() + "'";
		int num = 0;
		DataRow[] array = ((DataView)((DataGridView)asdgvReportDrillDown).DataSource).Table.Select(filterExpression);
		foreach (DataRow row in array)
		{
			num = ((DataView)((DataGridView)asdgvReportDrillDown).DataSource).Table.Rows.IndexOf(row);
		}
		if (is_F5)
		{
			if (f_dtReportDrillDown.Select(filterExpression).Any())
			{
				tabMenuAll.SelectTab(tabRepDrillDown);
				((Control)asdgvReportDrillDown).Focus();
				((DataGridView)asdgvReportDrillDown).CurrentCell = ((DataGridView)asdgvReportDrillDown)[0, num];
				((DataGridView)asdgvReportDrillDown).CurrentRow.Selected = true;
			}
			else
			{
				CMessageBox.Show(50016);
			}
		}
	}

	private void Gen_FielListDynReport()
	{
	}

	private void FormatGridView(DataTable dt, AsDataGridView asDgv)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		((DataGridView)asDgv).DataSource = null;
		int count = ((BaseCollection)((DataGridView)asDgv).Columns).Count;
		checked
		{
			int num = count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				((DataGridView)asDgv).Columns.RemoveAt(0);
				num2++;
			}
			DataColumn[] array = new DataColumn[6];
			int num5 = 0;
			string text = "";
			foreach (DataColumn column in dt.Columns)
			{
				if (column.ColumnName.Length >= 4)
				{
					if (Operators.CompareString(column.ColumnName.Substring(0, 4).ToUpper(), "KEY_", false) == 0)
					{
						text = column.ColumnName.Replace(column.ColumnName.Substring(0, 4), "");
						continue;
					}
					if (Operators.CompareString(column.ColumnName.ToUpper(), text.ToUpper(), false) == 0)
					{
						array[num5] = column;
						num5++;
					}
				}
				if (Operators.CompareString(column.DataType.ToString(), "System.String", false) == 0)
				{
					DataGridViewTextBoxColumn val = new DataGridViewTextBoxColumn();
					((DataGridViewColumn)val).Name = column.ColumnName;
					((DataGridViewColumn)val).DataPropertyName = column.ColumnName;
					((DataGridViewColumn)val).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
					if (column.ColumnName.Contains("formated") | column.ColumnName.Contains("Dyn"))
					{
						((DataGridViewColumn)val).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
						((DataGridViewColumn)val).Width = 200;
					}
					val.SortMode = (DataGridViewColumnSortMode)0;
					if (Operators.CompareString(column.ColumnName.ToString().ToUpper(), "MA_CTY", false) == 0)
					{
						((DataGridViewColumn)val).ReadOnly = true;
					}
					((DataGridView)asDgv).Columns.Add((DataGridViewColumn)(object)val);
				}
				else if (Operators.CompareString(column.DataType.ToString(), "System.DateTime", false) == 0)
				{
					DataGridViewTextBoxColumn val2 = new DataGridViewTextBoxColumn();
					((DataGridViewColumn)val2).Name = column.ColumnName;
					((DataGridViewColumn)val2).DataPropertyName = column.ColumnName;
					((DataGridViewColumn)val2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
					val2.SortMode = (DataGridViewColumnSortMode)0;
					if (Operators.CompareString(column.ColumnName.ToString().ToUpper(), "MA_CTY", false) == 0)
					{
						((DataGridViewColumn)val2).ReadOnly = true;
					}
					DataGridViewCellStyle val3 = new DataGridViewCellStyle();
					val3.Format = "dd/MM/yyyy";
					((DataGridViewColumn)val2).DefaultCellStyle = val3;
					((DataGridView)asDgv).Columns.Add((DataGridViewColumn)(object)val2);
				}
				else if (Operators.CompareString(column.DataType.ToString(), "System.Boolean", false) == 0)
				{
					DataGridViewCheckBoxColumn val4 = new DataGridViewCheckBoxColumn();
					((DataGridViewColumn)val4).Name = column.ColumnName;
					((DataGridViewColumn)val4).DataPropertyName = column.ColumnName;
					((DataGridViewColumn)val4).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
					((DataGridViewColumn)val4).SortMode = (DataGridViewColumnSortMode)0;
					if (Operators.CompareString(column.ColumnName.ToString().ToUpper(), "MA_CTY", false) == 0)
					{
						((DataGridViewColumn)val4).ReadOnly = true;
					}
					((DataGridView)asDgv).Columns.Add((DataGridViewColumn)(object)val4);
				}
				else if ((Operators.CompareString(column.DataType.ToString(), "System.Numeric", false) == 0) | (Operators.CompareString(column.DataType.ToString(), "System.Decimal", false) == 0) | (Operators.CompareString(column.DataType.ToString(), "System.Int32", false) == 0))
				{
					DataGridViewAsTextNumericColumn dataGridViewAsTextNumericColumn = new DataGridViewAsTextNumericColumn();
					((DataGridViewColumn)dataGridViewAsTextNumericColumn).Name = column.ColumnName;
					((DataGridViewColumn)dataGridViewAsTextNumericColumn).DataPropertyName = column.ColumnName;
					((DataGridViewColumn)dataGridViewAsTextNumericColumn).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
					dataGridViewAsTextNumericColumn.SortMode = (DataGridViewColumnSortMode)0;
					if (Operators.CompareString(column.ColumnName.ToString().ToUpper(), "MA_CTY", false) == 0)
					{
						((DataGridViewColumn)dataGridViewAsTextNumericColumn).ReadOnly = true;
					}
					((DataGridView)asDgv).Columns.Add((DataGridViewColumn)(object)dataGridViewAsTextNumericColumn);
				}
			}
			if (array != null)
			{
				dt.PrimaryKey = array;
			}
			((DataGridView)asDgv).DataSource = dt.DefaultView;
		}
	}

	private void cmbModule_SelectedValueChanged(object sender, EventArgs e)
	{
		if (cmbModule.DataSource != null)
		{
			strFilterModule = Conversions.ToString(Operators.AddObject(Operators.AddObject((object)" moduleid = '", ((ListControl)cmbModule).SelectedValue), (object)"'"));
			f_dtModuleFunc.DefaultView.RowFilter = strFilterModule;
		}
		cmbModuleFunc_SelectedValueChanged(RuntimeHelpers.GetObjectValue(sender), e);
		cmbMenu_SelectedValueChanged(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void cmbModuleFunc_SelectedValueChanged(object sender, EventArgs e)
	{
		if (cmbModuleFunc.DataSource != null)
		{
			strFilterModuleFunc = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)" moduleid ='", ((ListControl)cmbModule).SelectedValue), (object)"'"), (object)" and menuid like  "), (object)"'"), (object)((ListControl)cmbModuleFunc).SelectedValue.ToString().Substring(0, 5)), (object)"%' "));
			f_dtAllMenu.DefaultView.RowFilter = strFilterModuleFunc;
			string text = ((ListControl)cmbModuleFunc).SelectedValue.ToString().Substring(3, 2);
			if (Operators.CompareString(text, "90", false) == 0)
			{
				cmbTranfer.SelectedIndex = 0;
			}
			else if (Operators.CompareString(text, "10", false) == 0)
			{
				cmbTranfer.SelectedIndex = 2;
			}
			else
			{
				cmbTranfer.SelectedIndex = 1;
			}
			cmbMenu_SelectedValueChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void asDgvReport_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Invalid comparison between Unknown and I4
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 116)
		{
			F5asDgvReport(is_F5: true);
		}
		if ((int)e.KeyCode == 115)
		{
			int position = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)asDgvReport).DataSource)].Position;
			int position2 = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)asDgvReportRex).DataSource)].Position;
			string text = "";
			DataRow dataRow = f_dtReport.NewRow();
			DataRow row = ((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)asDgvReport).DataSource)].Current).Row;
			dataRow["menuid"] = RuntimeHelpers.GetObjectValue(row["menuid"]);
			checked
			{
				text = "0" + (int.Parse(Conversions.ToString(row["ma_mau"])) + 1);
				dataRow["ma_mau"] = text.Substring(text.Length - 2);
				dataRow["Spname"] = RuntimeHelpers.GetObjectValue(row["Spname"]);
				dataRow["rptname"] = RuntimeHelpers.GetObjectValue(row["rptname"]);
				f_dtReport.Rows.InsertAt(dataRow, position + 1);
				DataRow dataRow2 = f_dtReportRex.NewRow();
				DataRow row2 = ((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)asDgvReportRex).DataSource)].Current).Row;
				dataRow2["menuid"] = RuntimeHelpers.GetObjectValue(row2["menuid"]);
				dataRow2["ma_mau"] = text.Substring(text.Length - 2);
				dataRow2["language"] = RuntimeHelpers.GetObjectValue(row2["language"]);
				f_dtReportRex.Rows.InsertAt(dataRow2, position2 + 1);
				((DataGridView)asDgvReport).CurrentCell = ((DataGridView)asDgvReport)[1, position + 1];
				((DataGridView)asDgvReportRex).CurrentCell = ((DataGridView)asDgvReportRex)[1, position2 + 1];
			}
		}
		if ((int)e.KeyCode == 119 && (int)CMessageBox.Show(50003, SystemInformations.ProductName, (MessageBoxButtons)4) == 6)
		{
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools_2", a_blnIsSysDB: true);
			int position3 = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)asDgvReport).DataSource)].Position;
			DataRowView dataRowView = f_dtReport.DefaultView[position3];
			siToolsDao.SiDelReport(dataRowView.Row);
			DataRow[] array = f_dtReportRex.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"menuid='", dataRowView["menuid"]), (object)"' and ma_mau="), (object)"'"), dataRowView["ma_mau"]), (object)"'")));
			foreach (DataRow dataRow3 in array)
			{
				siToolsDao.SiDelReportRex(dataRow3);
				dataRow3.Delete();
			}
			siToolsDao.Destroy();
			dataRowView.Delete();
			f_dtReport.AcceptChanges();
			f_dtReportRex.AcceptChanges();
		}
	}

	private void asdgvReportDrillDown_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Invalid comparison between Unknown and I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 115)
		{
			int position = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)asdgvReportDrillDown).DataSource)].Position;
			string text = "";
			DataRow dataRow = f_dtReportDrillDown.NewRow();
			DataRow row = ((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)asdgvReportDrillDown).DataSource)].Current).Row;
			dataRow["menuid"] = RuntimeHelpers.GetObjectValue(row["menuid"]);
			checked
			{
				text = "0" + (int.Parse(Conversions.ToString(row["ma_mau"])) + 1);
				dataRow["ma_mau"] = text.Substring(text.Length - 2);
				dataRow["press_key_name"] = RuntimeHelpers.GetObjectValue(row["press_key_name"]);
				dataRow["dllname"] = RuntimeHelpers.GetObjectValue(row["dllname"]);
				dataRow["Command"] = RuntimeHelpers.GetObjectValue(row["Command"]);
				f_dtReportDrillDown.Rows.InsertAt(dataRow, position + 1);
				((DataGridView)asdgvReportDrillDown).CurrentCell = ((DataGridView)asdgvReportDrillDown)[0, position + 1];
			}
		}
		if ((int)e.KeyCode == 119 && (int)CMessageBox.Show(50003, SystemInformations.ProductName, (MessageBoxButtons)4) == 6)
		{
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools_2", a_blnIsSysDB: true);
			int position2 = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)asdgvReportDrillDown).DataSource)].Position;
			DataRowView dataRowView = f_dtReportDrillDown.DefaultView[position2];
			siToolsDao.SiDelReportDrillDown(dataRowView.Row);
			dataRowView.Delete();
			f_dtReportDrillDown.AcceptChanges();
		}
	}

	private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			Process.Start(Application.StartupPath + "\\Startup.exe");
			currentProcess.Kill();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void asDgvReport_SelectionChanged(object sender, EventArgs e)
	{
	}

	private void tabMenuAll_SelectedIndexChanged(object sender, EventArgs e)
	{
		SendKeys.Send("{TAB}");
	}

	private void btnCreate_Click(object sender, EventArgs e)
	{
		switch (cmbTranfer.Text.Substring(0, 1))
		{
		case "1":
			break;
		case "2":
			break;
		}
	}

	private void btnGen_FieldList_Click(object sender, EventArgs e)
	{
		if ((f_dtReport != null || ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)asDgvReport).DataSource)].Current != null) && 0 == 0)
		{
			((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)asDgvReport).DataSource)].EndCurrentEdit();
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools_2");
			DataRow dataRow = (DataRow)NewLateBinding.LateGet(((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)asDgvReport).DataSource)].Current, (Type)null, "row", new object[0], (string[])null, (Type[])null, (bool[])null);
			dataRow["DynReportFields"] = siToolsDao.Gen_FielListDynReport(Conversions.ToString(dataRow["Spname"]));
			((DataGridView)asDgvReport).InvalidateRow(((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)asDgvReport).DataSource)].Position);
		}
	}

	private void UpdateDBCompany()
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((ContainerControl)this).BindingContext[(object)f_dtCompany].EndCurrentEdit();
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools_2", a_blnIsSysDB: true);
			if (f_dtCompany.GetChanges() != null)
			{
				foreach (DataRow row in f_dtCompany.GetChanges().Rows)
				{
					siToolsDao.UpdateCompanyInfo(row);
				}
			}
			siToolsDao.Destroy();
			f_dtCompany.AcceptChanges();
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

	private void GetAllMenuInfo()
	{
		ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools_2", a_blnIsSysDB: true);
		DataSet dataSet = siToolsDao.SiGetAllMenu();
		siToolsDao.Destroy();
		f_dtModule = dataSet.Tables[0];
		f_dtModuleFunc = dataSet.Tables[1];
		f_dtAllMenu = dataSet.Tables[2];
		f_dtAllMenu.TableName = "Menu";
		dataSet.Dispose();
		((ListControl)cmbModule).ValueMember = "moduleid";
		((ListControl)cmbModule).DisplayMember = "bar";
		cmbModule.DataSource = f_dtModule.DefaultView;
		((ListControl)cmbModuleFunc).ValueMember = "menuid";
		((ListControl)cmbModuleFunc).DisplayMember = "bar";
		cmbModuleFunc.DataSource = f_dtModuleFunc.DefaultView;
		((ListControl)cmbMenu).ValueMember = "menuid";
		((ListControl)cmbMenu).DisplayMember = "bar";
		cmbMenu.DataSource = f_dtAllMenu.DefaultView;
	}

	private void UpdateDBReport()
	{
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((ContainerControl)this).BindingContext[(object)f_dtReport].EndCurrentEdit();
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools_2", a_blnIsSysDB: true);
			if (f_dtReport.GetChanges(DataRowState.Modified) != null)
			{
				foreach (DataRow row in f_dtReport.GetChanges(DataRowState.Modified).Rows)
				{
					siToolsDao.SiUpdateReport(row);
				}
			}
			if (f_dtReport.GetChanges(DataRowState.Added) != null)
			{
				foreach (DataRow row2 in f_dtReport.GetChanges(DataRowState.Added).Rows)
				{
					siToolsDao.SiInsertReport(row2);
				}
			}
			siToolsDao.Destroy();
			((DataGridView)asDgvReport).EndEdit();
			f_dtReport.AcceptChanges();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			CMessageBox.Show(99999);
			ProjectData.ClearProjectError();
		}
	}

	private void UpdateDBReportRex()
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((ContainerControl)this).BindingContext[(object)f_dtReportRex].EndCurrentEdit();
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools_2", a_blnIsSysDB: true);
			if (f_dtReportRex.GetChanges(DataRowState.Modified) != null)
			{
				foreach (DataRow row in f_dtReportRex.GetChanges(DataRowState.Modified).Rows)
				{
					siToolsDao.SiUpdateReportRex(row);
				}
			}
			if (f_dtReportRex.GetChanges(DataRowState.Added) != null)
			{
				foreach (DataRow row2 in f_dtReportRex.GetChanges(DataRowState.Added).Rows)
				{
					siToolsDao.SiInsertReportRex(row2);
				}
			}
			siToolsDao.Destroy();
			f_dtReportRex.AcceptChanges();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			CMessageBox.Show(99999);
			ProjectData.ClearProjectError();
		}
	}

	private void UpdateReportDrillDown()
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((ContainerControl)this).BindingContext[(object)f_dtReportDrillDown].EndCurrentEdit();
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools_2", a_blnIsSysDB: true);
			if (f_dtReportDrillDown.GetChanges(DataRowState.Modified) != null)
			{
				foreach (DataRow row in f_dtReportDrillDown.GetChanges(DataRowState.Modified).Rows)
				{
					siToolsDao.SiUpdateReportDrillDown(row);
				}
			}
			if (f_dtReportDrillDown.GetChanges(DataRowState.Added) != null)
			{
				foreach (DataRow row2 in f_dtReportDrillDown.GetChanges(DataRowState.Added).Rows)
				{
					siToolsDao.SiInsertReportDrillDown(row2);
				}
			}
			siToolsDao.Destroy();
			f_dtDaoInfo.AcceptChanges();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			CMessageBox.Show(99999);
			ProjectData.ClearProjectError();
		}
	}

	private void GetAllSys()
	{
		ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools_2", a_blnIsSysDB: true);
		DataSet dataSet = siToolsDao.SiGetAllSys();
		siToolsDao.Destroy();
		f_dtReport = dataSet.Tables[2];
		f_dtReportRex = dataSet.Tables[3];
		f_dtReportDrillDown = dataSet.Tables[7];
		FormatGridView(f_dtReport, asDgvReport);
		FormatGridView(f_dtReportRex, asDgvReportRex);
		FormatGridView(f_dtReportDrillDown, asdgvReportDrillDown);
		dataSet.Dispose();
	}

	private void asDgvMenu_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Context == 512)
		{
			CMessageBox.Show(50011);
		}
		if (e.Exception is ConstraintException)
		{
			e.ThrowException = false;
		}
	}

	private void asDgvDic_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Context == 512)
		{
			CMessageBox.Show(50011);
		}
		if (e.Exception is ConstraintException)
		{
			e.ThrowException = false;
		}
	}

	private void asDgvDicRex_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Context == 512)
		{
			CMessageBox.Show(50011);
		}
		if (e.Exception is ConstraintException)
		{
			e.ThrowException = false;
		}
	}

	private void asDgvReport_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Context == 512)
		{
			CMessageBox.Show(50011);
		}
		if (e.Exception is ConstraintException)
		{
			e.ThrowException = false;
		}
	}

	private void asDgvReportRex_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Context == 512)
		{
			CMessageBox.Show(50011);
		}
		if (e.Exception is ConstraintException)
		{
			e.ThrowException = false;
		}
	}

	private void asdgvReportDrillDown_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Context == 512)
		{
			CMessageBox.Show(50011);
		}
		if (e.Exception is ConstraintException)
		{
			e.ThrowException = false;
		}
	}

	private void asDgvVoucher_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Context == 512)
		{
			CMessageBox.Show(50011);
		}
		if (e.Exception is ConstraintException)
		{
			e.ThrowException = false;
		}
	}

	private void asDgvVoucherRex_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Context == 512)
		{
			CMessageBox.Show(50011);
		}
		if (e.Exception is ConstraintException)
		{
			e.ThrowException = false;
		}
	}

	private void asDgvDaoInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Context == 512)
		{
			CMessageBox.Show(50011);
		}
		if (e.Exception is ConstraintException)
		{
			e.ThrowException = false;
		}
	}

	private void cmbMenu_SelectedValueChanged(object sender, EventArgs e)
	{
		if (cmbMenu.DataSource != null && ((DataGridView)asDgvReport).DataSource != null && 0 == 0)
		{
			int num = 0;
			string rowFilter = Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"menuid= '", ((ListControl)cmbMenu).SelectedValue), (object)"'"));
			f_dtReport.DefaultView.RowFilter = rowFilter;
			f_dtReportRex.DefaultView.RowFilter = rowFilter;
		}
	}
}
