using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Caching;
using System.Windows.Forms;
using System.Xml;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using DTE.Bussiness;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmMainTools : frmAsiaRoot
{
	public enum fMenu
	{
		Insert = 1,
		Update
	}

	public enum fDictionaryInfo
	{
		Insert = 3,
		Update
	}

	public enum fDictionaryResx
	{
		Insert = 5,
		Update
	}

	public enum fReportInfo
	{
		Insert = 7,
		Update
	}

	public enum fReportResx
	{
		Insert = 9,
		Update
	}

	public enum fVoucherInfo
	{
		Insert = 11,
		Update
	}

	public enum fVoucherResx
	{
		Insert = 13,
		Update
	}

	public enum fDaoInfo
	{
		Insert = 15,
		Update
	}

	public enum fReportDrillDownInfo
	{
		Insert = 17,
		Update
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("btnExit")]
	private Button _btnExit;

	[AccessedThroughProperty("tabTools")]
	private TabControl _tabTools;

	[AccessedThroughProperty("tabComanyInfo")]
	private TabPage _tabComanyInfo;

	[AccessedThroughProperty("asDgvCompanyInfo")]
	private AsDataGridView _asDgvCompanyInfo;

	[AccessedThroughProperty("tabInterface")]
	private TabPage _tabInterface;

	[AccessedThroughProperty("tabMenu")]
	private TabPage _tabMenu;

	[AccessedThroughProperty("tbDetailMnFont")]
	private TextBox _tbDetailMnFont;

	[AccessedThroughProperty("lbDetailMnFont")]
	private Label _lbDetailMnFont;

	[AccessedThroughProperty("tbxDetailMnForeColor")]
	private TextBox _tbxDetailMnForeColor;

	[AccessedThroughProperty("lbDetailMnForeColor")]
	private Label _lbDetailMnForeColor;

	[AccessedThroughProperty("tbxSubMnForeColor")]
	private TextBox _tbxSubMnForeColor;

	[AccessedThroughProperty("lblSubMnForeColor")]
	private Label _lblSubMnForeColor;

	[AccessedThroughProperty("tbxMnSelectedColor")]
	private TextBox _tbxMnSelectedColor;

	[AccessedThroughProperty("lbMnSlFColor")]
	private Label _lbMnSlFColor;

	[AccessedThroughProperty("tbxForeColor")]
	private TextBox _tbxForeColor;

	[AccessedThroughProperty("lblForeColor")]
	private Label _lblForeColor;

	[AccessedThroughProperty("tbxWPanel")]
	private TextBox _tbxWPanel;

	[AccessedThroughProperty("lblWPanel")]
	private Label _lblWPanel;

	[AccessedThroughProperty("tbxFont")]
	private TextBox _tbxFont;

	[AccessedThroughProperty("lblFont")]
	private Label _lblFont;

	[AccessedThroughProperty("tbxBgColor")]
	private TextBox _tbxBgColor;

	[AccessedThroughProperty("lblMnBckClr")]
	private Label _lblMnBckClr;

	[AccessedThroughProperty("tbxWColumn")]
	private TextBox _tbxWColumn;

	[AccessedThroughProperty("lblColumn")]
	private Label _lblColumn;

	[AccessedThroughProperty("cbxMnType")]
	private ComboBox _cbxMnType;

	[AccessedThroughProperty("lblMenuType")]
	private Label _lblMenuType;

	[AccessedThroughProperty("lblSubMnFont")]
	private Label _lblSubMnFont;

	[AccessedThroughProperty("label1")]
	private Label _label1;

	[AccessedThroughProperty("tbxSubMnFont")]
	private TextBox _tbxSubMnFont;

	[AccessedThroughProperty("tbxLbForeColor")]
	private TextBox _tbxLbForeColor;

	[AccessedThroughProperty("lblLabelForeColor")]
	private Label _lblLabelForeColor;

	[AccessedThroughProperty("btnExcute")]
	private Button _btnExcute;

	[AccessedThroughProperty("fontDialog")]
	private FontDialog _fontDialog;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtField2CarryInReport")]
	private TextBox _txtField2CarryInReport;

	[AccessedThroughProperty("txtEscapeCharacters")]
	private TextBox _txtEscapeCharacters;

	[AccessedThroughProperty("txtAsTextBox_BakgroundColorName")]
	private TextBox _txtAsTextBox_BakgroundColorName;

	[AccessedThroughProperty("txtBC_AlternatingBackColorName")]
	private TextBox _txtBC_AlternatingBackColorName;

	[AccessedThroughProperty("txtBC_BakgroundColorName")]
	private TextBox _txtBC_BakgroundColorName;

	[AccessedThroughProperty("txtDM_AlternatingBackColorName")]
	private TextBox _txtDM_AlternatingBackColorName;

	[AccessedThroughProperty("txtDM_BakgroundColorName")]
	private TextBox _txtDM_BakgroundColorName;

	[AccessedThroughProperty("txtCT_AlternatingBackColorName")]
	private TextBox _txtCT_AlternatingBackColorName;

	[AccessedThroughProperty("txtServiceUri")]
	private TextBox _txtServiceUri;

	[AccessedThroughProperty("txtCT_BakgroundColorName")]
	private TextBox _txtCT_BakgroundColorName;

	[AccessedThroughProperty("cmbModule")]
	private ComboBox _cmbModule;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("cmbModuleFunc")]
	private ComboBox _cmbModuleFunc;

	[AccessedThroughProperty("cmbTranfer")]
	private ComboBox _cmbTranfer;

	[AccessedThroughProperty("tabExcProc")]
	private TabPage _tabExcProc;

	[AccessedThroughProperty("splExeSP")]
	private SplitContainer _splExeSP;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("asDgvResult")]
	private AsDataGridView _asDgvResult;

	[AccessedThroughProperty("btnSave")]
	private SplitButton _btnSave;

	[AccessedThroughProperty("ctMenuTool")]
	private ContextMenuStrip _ctMenuTool;

	[AccessedThroughProperty("RestartToolStripMenuItem")]
	private ToolStripMenuItem _RestartToolStripMenuItem;

	[AccessedThroughProperty("splInfo")]
	private SplitContainer _splInfo;

	[AccessedThroughProperty("asdgvStoreProc")]
	private AsDataGridView _asdgvStoreProc;

	[AccessedThroughProperty("asdgvParameter")]
	private AsDataGridView _asdgvParameter;

	[AccessedThroughProperty("btnCreate")]
	private Button _btnCreate;

	[AccessedThroughProperty("tabMenuAll")]
	private TabControl _tabMenuAll;

	[AccessedThroughProperty("tabListMenu")]
	private TabPage _tabListMenu;

	[AccessedThroughProperty("tabDicRex")]
	private TabPage _tabDicRex;

	[AccessedThroughProperty("asDgvMenu")]
	private AsDataGridView _asDgvMenu;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("splDicRec")]
	private SplitContainer _splDicRec;

	[AccessedThroughProperty("asDgvDic")]
	private AsDataGridView _asDgvDic;

	[AccessedThroughProperty("asDgvDicRex")]
	private AsDataGridView _asDgvDicRex;

	[AccessedThroughProperty("tabRepRex")]
	private TabPage _tabRepRex;

	[AccessedThroughProperty("splReports")]
	private SplitContainer _splReports;

	[AccessedThroughProperty("asDgvReport")]
	private AsDataGridView _asDgvReport;

	[AccessedThroughProperty("asDgvReportRex")]
	private AsDataGridView _asDgvReportRex;

	[AccessedThroughProperty("tabDaoInfo")]
	private TabPage _tabDaoInfo;

	[AccessedThroughProperty("asDgvDaoInfo")]
	private AsDataGridView _asDgvDaoInfo;

	[AccessedThroughProperty("tabVoucher")]
	private TabPage _tabVoucher;

	[AccessedThroughProperty("SplVoucher")]
	private SplitContainer _SplVoucher;

	[AccessedThroughProperty("asDgvVoucher")]
	private AsDataGridView _asDgvVoucher;

	[AccessedThroughProperty("asDgvVoucherRex")]
	private AsDataGridView _asDgvVoucherRex;

	[AccessedThroughProperty("tabRepDrillDown")]
	private TabPage _tabRepDrillDown;

	[AccessedThroughProperty("asdgvReportDrillDown")]
	private AsDataGridView _asdgvReportDrillDown;

	[AccessedThroughProperty("btnGen_FieldList")]
	private Button _btnGen_FieldList;

	[AccessedThroughProperty("TT_Grid")]
	private ToolTip _TT_Grid;

	[AccessedThroughProperty("btnOpendialog")]
	private Button _btnOpendialog;

	[AccessedThroughProperty("txtUpdatePatch")]
	private TextBox _txtUpdatePatch;

	[AccessedThroughProperty("lblPathUpdate")]
	private Label _lblPathUpdate;

	[AccessedThroughProperty("asdgvClientConfig")]
	private AsInputDGV _asdgvClientConfig;

	[AccessedThroughProperty("fbdPath")]
	private FolderBrowserDialog _fbdPath;

	[AccessedThroughProperty("dgvcFields")]
	private DataGridViewTextBoxColumn _dgvcFields;

	[AccessedThroughProperty("dgvcValue")]
	private DataGridViewTextBoxColumn _dgvcValue;

	[AccessedThroughProperty("dgvcDescription")]
	private DataGridViewTextBoxColumn _dgvcDescription;

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

	private DataTable f_dtClientSetting;

	private Configuration ClientConfig;

	private Configuration UpdateConfig;

	private XmlDocument xmldoc;

	private string strFilterModule;

	private string strFilterModuleFunc;

	private string PassRight;

	private bool checkRight;

	private DataRow rowToCopy;

	private bool _isLoading;

	private bool _isClose;

	private CacheSample fCache;

	private const string CACHE_COMPANY = "COMPANY";

	private const string CACHE_DMSTORE = "DMSTORE";

	private const string CACHE_PARAOFSTORE = "PARAOFSTORE";

	private const string CACHE_DICINFO = "DICINFO";

	private const string CACHE_DICRESX = "DICRESX";

	private const string CACHE_REINFO = "REINFO";

	private const string CACHE_RERESX = "RERESX";

	private const string CACHE_VOUINFO = "VOUINFO";

	private const string CACHE_VOURESX = "VOURESX";

	private const string CACHE_DAOINFO = "DAOINFO";

	private const string CACHE_DRIINFO = "DRIINFO";

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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = tabTools_SelectedIndexChanged;
			TabControlCancelEventHandler val = new TabControlCancelEventHandler(tabTools_Selecting);
			if (_tabTools != null)
			{
				_tabTools.SelectedIndexChanged -= eventHandler;
				_tabTools.Selecting -= val;
			}
			_tabTools = value;
			if (_tabTools != null)
			{
				_tabTools.SelectedIndexChanged += eventHandler;
				_tabTools.Selecting += val;
			}
		}
	}

	internal virtual TabPage tabComanyInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabComanyInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabComanyInfo = value;
		}
	}

	internal virtual AsDataGridView asDgvCompanyInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _asDgvCompanyInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_asDgvCompanyInfo = value;
		}
	}

	internal virtual TabPage tabInterface
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabInterface;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabInterface = value;
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

	private virtual TextBox tbDetailMnFont
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbDetailMnFont;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbDetailMnFont = value;
		}
	}

	private virtual Label lbDetailMnFont
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbDetailMnFont;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbDetailMnFont = value;
		}
	}

	private virtual TextBox tbxDetailMnForeColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbxDetailMnForeColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbxDetailMnForeColor = value;
		}
	}

	private virtual Label lbDetailMnForeColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbDetailMnForeColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbDetailMnForeColor = value;
		}
	}

	private virtual TextBox tbxSubMnForeColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbxSubMnForeColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbxSubMnForeColor = value;
		}
	}

	private virtual Label lblSubMnForeColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSubMnForeColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSubMnForeColor = value;
		}
	}

	private virtual TextBox tbxMnSelectedColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbxMnSelectedColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbxMnSelectedColor = value;
		}
	}

	private virtual Label lbMnSlFColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbMnSlFColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbMnSlFColor = value;
		}
	}

	private virtual TextBox tbxForeColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbxForeColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbxForeColor = value;
		}
	}

	private virtual Label lblForeColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblForeColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblForeColor = value;
		}
	}

	private virtual TextBox tbxWPanel
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbxWPanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbxWPanel = value;
		}
	}

	private virtual Label lblWPanel
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblWPanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblWPanel = value;
		}
	}

	private virtual TextBox tbxFont
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbxFont;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbxFont = value;
		}
	}

	private virtual Label lblFont
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFont;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFont = value;
		}
	}

	private virtual TextBox tbxBgColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbxBgColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbxBgColor = value;
		}
	}

	private virtual Label lblMnBckClr
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMnBckClr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMnBckClr = value;
		}
	}

	private virtual TextBox tbxWColumn
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbxWColumn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbxWColumn = value;
		}
	}

	private virtual Label lblColumn
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblColumn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblColumn = value;
		}
	}

	private virtual ComboBox cbxMnType
	{
		[DebuggerNonUserCode]
		get
		{
			return _cbxMnType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cbxMnType = value;
		}
	}

	private virtual Label lblMenuType
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMenuType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMenuType = value;
		}
	}

	private virtual Label lblSubMnFont
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSubMnFont;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSubMnFont = value;
		}
	}

	private virtual Label label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_label1 = value;
		}
	}

	private virtual TextBox tbxSubMnFont
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbxSubMnFont;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbxSubMnFont = value;
		}
	}

	private virtual TextBox tbxLbForeColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbxLbForeColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbxLbForeColor = value;
		}
	}

	private virtual Label lblLabelForeColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLabelForeColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLabelForeColor = value;
		}
	}

	internal virtual Button btnExcute
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnExcute;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnCreateCompany_Click;
			if (_btnExcute != null)
			{
				((Control)_btnExcute).Click -= eventHandler;
			}
			_btnExcute = value;
			if (_btnExcute != null)
			{
				((Control)_btnExcute).Click += eventHandler;
			}
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

	private virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	private virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	private virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	private virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	private virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	private virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	private virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	private virtual Label Label5
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

	private virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	private virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	private virtual TextBox txtField2CarryInReport
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtField2CarryInReport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtField2CarryInReport = value;
		}
	}

	private virtual TextBox txtEscapeCharacters
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtEscapeCharacters;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtEscapeCharacters = value;
		}
	}

	private virtual TextBox txtAsTextBox_BakgroundColorName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAsTextBox_BakgroundColorName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtAsTextBox_BakgroundColorName = value;
		}
	}

	private virtual TextBox txtBC_AlternatingBackColorName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtBC_AlternatingBackColorName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtBC_AlternatingBackColorName = value;
		}
	}

	private virtual TextBox txtBC_BakgroundColorName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtBC_BakgroundColorName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtBC_BakgroundColorName = value;
		}
	}

	private virtual TextBox txtDM_AlternatingBackColorName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDM_AlternatingBackColorName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDM_AlternatingBackColorName = value;
		}
	}

	private virtual TextBox txtDM_BakgroundColorName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDM_BakgroundColorName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDM_BakgroundColorName = value;
		}
	}

	private virtual TextBox txtCT_AlternatingBackColorName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCT_AlternatingBackColorName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCT_AlternatingBackColorName = value;
		}
	}

	private virtual TextBox txtServiceUri
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtServiceUri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtServiceUri = value;
		}
	}

	private virtual TextBox txtCT_BakgroundColorName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCT_BakgroundColorName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCT_BakgroundColorName = value;
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

	internal virtual TabPage tabExcProc
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabExcProc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabExcProc = value;
		}
	}

	internal virtual SplitContainer splExeSP
	{
		[DebuggerNonUserCode]
		get
		{
			return _splExeSP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_splExeSP = value;
		}
	}

	internal virtual Panel Panel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel3 = value;
		}
	}

	internal virtual AsDataGridView asDgvResult
	{
		[DebuggerNonUserCode]
		get
		{
			return _asDgvResult;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_asDgvResult = value;
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

	internal virtual SplitContainer splInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _splInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_splInfo = value;
		}
	}

	internal virtual AsDataGridView asdgvStoreProc
	{
		[DebuggerNonUserCode]
		get
		{
			return _asdgvStoreProc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = asdgvStoreProc_SelectionChanged;
			if (_asdgvStoreProc != null)
			{
				((DataGridView)_asdgvStoreProc).SelectionChanged -= eventHandler;
			}
			_asdgvStoreProc = value;
			if (_asdgvStoreProc != null)
			{
				((DataGridView)_asdgvStoreProc).SelectionChanged += eventHandler;
			}
		}
	}

	internal virtual AsDataGridView asdgvParameter
	{
		[DebuggerNonUserCode]
		get
		{
			return _asdgvParameter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(asdgvParameter_CellValueChanged);
			if (_asdgvParameter != null)
			{
				((DataGridView)_asdgvParameter).CellValueChanged -= val;
			}
			_asdgvParameter = value;
			if (_asdgvParameter != null)
			{
				((DataGridView)_asdgvParameter).CellValueChanged += val;
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

	internal virtual TabPage tabDicRex
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabDicRex;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabDicRex = value;
		}
	}

	internal virtual AsDataGridView asDgvMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _asDgvMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(asDgvMenu_KeyDown);
			if (_asDgvMenu != null)
			{
				((Control)_asDgvMenu).KeyDown -= val;
			}
			_asDgvMenu = value;
			if (_asDgvMenu != null)
			{
				((Control)_asDgvMenu).KeyDown += val;
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

	internal virtual SplitContainer splDicRec
	{
		[DebuggerNonUserCode]
		get
		{
			return _splDicRec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_splDicRec = value;
		}
	}

	internal virtual AsDataGridView asDgvDic
	{
		[DebuggerNonUserCode]
		get
		{
			return _asDgvDic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = asDgvDic_SelectionChanged;
			KeyEventHandler val = new KeyEventHandler(asDgvDic_KeyDown);
			if (_asDgvDic != null)
			{
				((DataGridView)_asDgvDic).SelectionChanged -= eventHandler;
				((Control)_asDgvDic).KeyDown -= val;
			}
			_asDgvDic = value;
			if (_asDgvDic != null)
			{
				((DataGridView)_asDgvDic).SelectionChanged += eventHandler;
				((Control)_asDgvDic).KeyDown += val;
			}
		}
	}

	internal virtual AsDataGridView asDgvDicRex
	{
		[DebuggerNonUserCode]
		get
		{
			return _asDgvDicRex;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_asDgvDicRex = value;
		}
	}

	internal virtual TabPage tabRepRex
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabRepRex;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabRepRex = value;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = asDgvReport_SelectionChanged;
			KeyEventHandler val = new KeyEventHandler(asDgvReport_KeyDown);
			if (_asDgvReport != null)
			{
				((DataGridView)_asDgvReport).SelectionChanged -= eventHandler;
				((Control)_asDgvReport).KeyDown -= val;
			}
			_asDgvReport = value;
			if (_asDgvReport != null)
			{
				((DataGridView)_asDgvReport).SelectionChanged += eventHandler;
				((Control)_asDgvReport).KeyDown += val;
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

	internal virtual TabPage tabDaoInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabDaoInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabDaoInfo = value;
		}
	}

	internal virtual AsDataGridView asDgvDaoInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _asDgvDaoInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(asDgvDaoInfo_KeyDown);
			if (_asDgvDaoInfo != null)
			{
				((Control)_asDgvDaoInfo).KeyDown -= val;
			}
			_asDgvDaoInfo = value;
			if (_asDgvDaoInfo != null)
			{
				((Control)_asDgvDaoInfo).KeyDown += val;
			}
		}
	}

	internal virtual TabPage tabVoucher
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabVoucher;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabVoucher = value;
		}
	}

	internal virtual SplitContainer SplVoucher
	{
		[DebuggerNonUserCode]
		get
		{
			return _SplVoucher;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SplVoucher = value;
		}
	}

	internal virtual AsDataGridView asDgvVoucher
	{
		[DebuggerNonUserCode]
		get
		{
			return _asDgvVoucher;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = asDgvVoucher_SelectionChanged;
			KeyEventHandler val = new KeyEventHandler(asDgvVoucher_KeyDown);
			if (_asDgvVoucher != null)
			{
				((DataGridView)_asDgvVoucher).SelectionChanged -= eventHandler;
				((Control)_asDgvVoucher).KeyDown -= val;
			}
			_asDgvVoucher = value;
			if (_asDgvVoucher != null)
			{
				((DataGridView)_asDgvVoucher).SelectionChanged += eventHandler;
				((Control)_asDgvVoucher).KeyDown += val;
			}
		}
	}

	internal virtual AsDataGridView asDgvVoucherRex
	{
		[DebuggerNonUserCode]
		get
		{
			return _asDgvVoucherRex;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_asDgvVoucherRex = value;
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
			KeyEventHandler val = new KeyEventHandler(asdgvReportDrillDown_KeyDown);
			if (_asdgvReportDrillDown != null)
			{
				((Control)_asdgvReportDrillDown).KeyDown -= val;
			}
			_asdgvReportDrillDown = value;
			if (_asdgvReportDrillDown != null)
			{
				((Control)_asdgvReportDrillDown).KeyDown += val;
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

	internal virtual ToolTip TT_Grid
	{
		[DebuggerNonUserCode]
		get
		{
			return _TT_Grid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TT_Grid = value;
		}
	}

	internal virtual Button btnOpendialog
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnOpendialog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnOpendialog_Click;
			if (_btnOpendialog != null)
			{
				((Control)_btnOpendialog).Click -= eventHandler;
			}
			_btnOpendialog = value;
			if (_btnOpendialog != null)
			{
				((Control)_btnOpendialog).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox txtUpdatePatch
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtUpdatePatch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtUpdatePatch = value;
		}
	}

	internal virtual Label lblPathUpdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPathUpdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPathUpdate = value;
		}
	}

	internal virtual AsInputDGV asdgvClientConfig
	{
		[DebuggerNonUserCode]
		get
		{
			return _asdgvClientConfig;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_asdgvClientConfig = value;
		}
	}

	internal virtual FolderBrowserDialog fbdPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _fbdPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fbdPath = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcFields
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcFields;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcFields = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcValue
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcValue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcValue = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDescription
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDescription;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDescription = value;
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
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		((Form)this).Shown += frmMainTools_Shown;
		((Form)this).Load += frmMainTools_Load;
		((Control)this).KeyDown += new KeyEventHandler(frmMainTools_KeyDown);
		__ENCAddToList(this);
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
		f_dtClientSetting = new DataTable();
		strFilterModule = " ";
		strFilterModuleFunc = " ";
		PassRight = "";
		checkRight = false;
		rowToCopy = null;
		_isLoading = false;
		_isClose = false;
		fCache = new CacheSample();
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
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected O, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected O, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected O, but got Unknown
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f07: Expected O, but got Unknown
		//IL_11c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d0: Expected O, but got Unknown
		//IL_12eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f5: Expected O, but got Unknown
		//IL_19c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19cc: Expected O, but got Unknown
		//IL_26e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ee: Expected O, but got Unknown
		//IL_2801: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a35: Expected O, but got Unknown
		//IL_2ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae8: Expected O, but got Unknown
		//IL_2b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b91: Expected O, but got Unknown
		//IL_2d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e24: Expected O, but got Unknown
		//IL_2e96: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ea0: Expected O, but got Unknown
		//IL_2f66: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f70: Expected O, but got Unknown
		//IL_304c: Unknown result type (might be due to invalid IL or missing references)
		//IL_333e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3348: Expected O, but got Unknown
		//IL_33ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_33c4: Expected O, but got Unknown
		//IL_34a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_34ab: Expected O, but got Unknown
		//IL_35b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_35bf: Expected O, but got Unknown
		//IL_3629: Unknown result type (might be due to invalid IL or missing references)
		//IL_3633: Expected O, but got Unknown
		//IL_3701: Unknown result type (might be due to invalid IL or missing references)
		//IL_370b: Expected O, but got Unknown
		//IL_3870: Unknown result type (might be due to invalid IL or missing references)
		//IL_387a: Expected O, but got Unknown
		//IL_3954: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c16: Expected O, but got Unknown
		//IL_3c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c92: Expected O, but got Unknown
		//IL_3d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d63: Expected O, but got Unknown
		//IL_4236: Unknown result type (might be due to invalid IL or missing references)
		//IL_43df: Unknown result type (might be due to invalid IL or missing references)
		//IL_43e9: Expected O, but got Unknown
		//IL_445b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4465: Expected O, but got Unknown
		//IL_4545: Unknown result type (might be due to invalid IL or missing references)
		//IL_454f: Expected O, but got Unknown
		//IL_4654: Unknown result type (might be due to invalid IL or missing references)
		//IL_465e: Expected O, but got Unknown
		//IL_46d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_46da: Expected O, but got Unknown
		//IL_47a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_47aa: Expected O, but got Unknown
		//IL_4a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a22: Expected O, but got Unknown
		//IL_4a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a9e: Expected O, but got Unknown
		//IL_4b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b7b: Expected O, but got Unknown
		//IL_4c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c8a: Expected O, but got Unknown
		//IL_4cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d06: Expected O, but got Unknown
		//IL_4dcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dd6: Expected O, but got Unknown
		//IL_4eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f88: Expected O, but got Unknown
		//IL_4ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_5004: Expected O, but got Unknown
		//IL_50d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_50e1: Expected O, but got Unknown
		//IL_534f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5359: Expected O, but got Unknown
		//IL_53cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_53d5: Expected O, but got Unknown
		//IL_54a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_54b2: Expected O, but got Unknown
		//IL_55b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_55c1: Expected O, but got Unknown
		//IL_5633: Unknown result type (might be due to invalid IL or missing references)
		//IL_563d: Expected O, but got Unknown
		//IL_5703: Unknown result type (might be due to invalid IL or missing references)
		//IL_570d: Expected O, but got Unknown
		//IL_57e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_58b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_58bf: Expected O, but got Unknown
		//IL_5931: Unknown result type (might be due to invalid IL or missing references)
		//IL_593b: Expected O, but got Unknown
		//IL_5a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a18: Expected O, but got Unknown
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
		DataGridViewCellStyle val33 = new DataGridViewCellStyle();
		DataGridViewCellStyle val34 = new DataGridViewCellStyle();
		DataGridViewCellStyle val35 = new DataGridViewCellStyle();
		DataGridViewCellStyle val36 = new DataGridViewCellStyle();
		DataGridViewCellStyle val37 = new DataGridViewCellStyle();
		DataGridViewCellStyle val38 = new DataGridViewCellStyle();
		DataGridViewCellStyle val39 = new DataGridViewCellStyle();
		DataGridViewCellStyle val40 = new DataGridViewCellStyle();
		DataGridViewCellStyle val41 = new DataGridViewCellStyle();
		DataGridViewCellStyle val42 = new DataGridViewCellStyle();
		DataGridViewCellStyle val43 = new DataGridViewCellStyle();
		DataGridViewCellStyle val44 = new DataGridViewCellStyle();
		DataGridViewCellStyle val45 = new DataGridViewCellStyle();
		DataGridViewCellStyle val46 = new DataGridViewCellStyle();
		DataGridViewCellStyle val47 = new DataGridViewCellStyle();
		DataGridViewCellStyle val48 = new DataGridViewCellStyle();
		DataGridViewCellStyle val49 = new DataGridViewCellStyle();
		DataGridViewCellStyle val50 = new DataGridViewCellStyle();
		Panel1 = new Panel();
		txtField2CarryInReport = new TextBox();
		btnGen_FieldList = new Button();
		txtEscapeCharacters = new TextBox();
		btnSave = new SplitButton();
		ctMenuTool = new ContextMenuStrip(components);
		RestartToolStripMenuItem = new ToolStripMenuItem();
		txtAsTextBox_BakgroundColorName = new TextBox();
		btnExcute = new Button();
		txtBC_AlternatingBackColorName = new TextBox();
		btnExit = new Button();
		txtBC_BakgroundColorName = new TextBox();
		label1 = new Label();
		txtDM_AlternatingBackColorName = new TextBox();
		lblLabelForeColor = new Label();
		txtDM_BakgroundColorName = new TextBox();
		tbxLbForeColor = new TextBox();
		txtCT_AlternatingBackColorName = new TextBox();
		tbxSubMnFont = new TextBox();
		txtServiceUri = new TextBox();
		lblSubMnFont = new Label();
		txtCT_BakgroundColorName = new TextBox();
		lblMenuType = new Label();
		Label10 = new Label();
		cbxMnType = new ComboBox();
		Label11 = new Label();
		lblColumn = new Label();
		Label6 = new Label();
		tbxWColumn = new TextBox();
		Label7 = new Label();
		lblMnBckClr = new Label();
		Label8 = new Label();
		tbxBgColor = new TextBox();
		Label9 = new Label();
		lblFont = new Label();
		Label4 = new Label();
		tbxFont = new TextBox();
		Label5 = new Label();
		lblWPanel = new Label();
		Label3 = new Label();
		tbxWPanel = new TextBox();
		Label2 = new Label();
		lblForeColor = new Label();
		tbDetailMnFont = new TextBox();
		tbxForeColor = new TextBox();
		lbDetailMnFont = new Label();
		lbMnSlFColor = new Label();
		tbxDetailMnForeColor = new TextBox();
		tbxMnSelectedColor = new TextBox();
		lbDetailMnForeColor = new Label();
		lblSubMnForeColor = new Label();
		tbxSubMnForeColor = new TextBox();
		tabTools = new TabControl();
		tabInterface = new TabPage();
		btnOpendialog = new Button();
		txtUpdatePatch = new TextBox();
		lblPathUpdate = new Label();
		asdgvClientConfig = new AsInputDGV();
		dgvcFields = new DataGridViewTextBoxColumn();
		dgvcValue = new DataGridViewTextBoxColumn();
		dgvcDescription = new DataGridViewTextBoxColumn();
		tabComanyInfo = new TabPage();
		asDgvCompanyInfo = new AsDataGridView();
		tabExcProc = new TabPage();
		splExeSP = new SplitContainer();
		Panel3 = new Panel();
		splInfo = new SplitContainer();
		asdgvStoreProc = new AsDataGridView();
		asdgvParameter = new AsDataGridView();
		asDgvResult = new AsDataGridView();
		tabMenu = new TabPage();
		tabMenuAll = new TabControl();
		tabListMenu = new TabPage();
		asDgvMenu = new AsDataGridView();
		Panel2 = new Panel();
		btnCreate = new Button();
		cmbModuleFunc = new ComboBox();
		Label12 = new Label();
		Label13 = new Label();
		cmbModule = new ComboBox();
		cmbTranfer = new ComboBox();
		tabDicRex = new TabPage();
		splDicRec = new SplitContainer();
		asDgvDic = new AsDataGridView();
		asDgvDicRex = new AsDataGridView();
		tabRepRex = new TabPage();
		splReports = new SplitContainer();
		asDgvReport = new AsDataGridView();
		asDgvReportRex = new AsDataGridView();
		tabRepDrillDown = new TabPage();
		asdgvReportDrillDown = new AsDataGridView();
		tabVoucher = new TabPage();
		SplVoucher = new SplitContainer();
		asDgvVoucher = new AsDataGridView();
		asDgvVoucherRex = new AsDataGridView();
		tabDaoInfo = new TabPage();
		asDgvDaoInfo = new AsDataGridView();
		fontDialog = new FontDialog();
		TT_Grid = new ToolTip(components);
		fbdPath = new FolderBrowserDialog();
		((Control)Panel1).SuspendLayout();
		((Control)ctMenuTool).SuspendLayout();
		((Control)tabTools).SuspendLayout();
		((Control)tabInterface).SuspendLayout();
		((ISupportInitialize)asdgvClientConfig).BeginInit();
		((Control)tabComanyInfo).SuspendLayout();
		((ISupportInitialize)asDgvCompanyInfo).BeginInit();
		((Control)tabExcProc).SuspendLayout();
		((Control)splExeSP.Panel1).SuspendLayout();
		((Control)splExeSP.Panel2).SuspendLayout();
		((Control)splExeSP).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)splInfo.Panel1).SuspendLayout();
		((Control)splInfo.Panel2).SuspendLayout();
		((Control)splInfo).SuspendLayout();
		((ISupportInitialize)asdgvStoreProc).BeginInit();
		((ISupportInitialize)asdgvParameter).BeginInit();
		((ISupportInitialize)asDgvResult).BeginInit();
		((Control)tabMenu).SuspendLayout();
		((Control)tabMenuAll).SuspendLayout();
		((Control)tabListMenu).SuspendLayout();
		((ISupportInitialize)asDgvMenu).BeginInit();
		((Control)Panel2).SuspendLayout();
		((Control)tabDicRex).SuspendLayout();
		((Control)splDicRec.Panel1).SuspendLayout();
		((Control)splDicRec.Panel2).SuspendLayout();
		((Control)splDicRec).SuspendLayout();
		((ISupportInitialize)asDgvDic).BeginInit();
		((ISupportInitialize)asDgvDicRex).BeginInit();
		((Control)tabRepRex).SuspendLayout();
		((Control)splReports.Panel1).SuspendLayout();
		((Control)splReports.Panel2).SuspendLayout();
		((Control)splReports).SuspendLayout();
		((ISupportInitialize)asDgvReport).BeginInit();
		((ISupportInitialize)asDgvReportRex).BeginInit();
		((Control)tabRepDrillDown).SuspendLayout();
		((ISupportInitialize)asdgvReportDrillDown).BeginInit();
		((Control)tabVoucher).SuspendLayout();
		((Control)SplVoucher.Panel1).SuspendLayout();
		((Control)SplVoucher.Panel2).SuspendLayout();
		((Control)SplVoucher).SuspendLayout();
		((ISupportInitialize)asDgvVoucher).BeginInit();
		((ISupportInitialize)asDgvVoucherRex).BeginInit();
		((Control)tabDaoInfo).SuspendLayout();
		((ISupportInitialize)asDgvDaoInfo).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).Controls.Add((Control)(object)txtField2CarryInReport);
		((Control)Panel1).Controls.Add((Control)(object)btnGen_FieldList);
		((Control)Panel1).Controls.Add((Control)(object)txtEscapeCharacters);
		((Control)Panel1).Controls.Add((Control)(object)btnSave);
		((Control)Panel1).Controls.Add((Control)(object)txtAsTextBox_BakgroundColorName);
		((Control)Panel1).Controls.Add((Control)(object)btnExcute);
		((Control)Panel1).Controls.Add((Control)(object)txtBC_AlternatingBackColorName);
		((Control)Panel1).Controls.Add((Control)(object)btnExit);
		((Control)Panel1).Controls.Add((Control)(object)txtBC_BakgroundColorName);
		((Control)Panel1).Controls.Add((Control)(object)label1);
		((Control)Panel1).Controls.Add((Control)(object)txtDM_AlternatingBackColorName);
		((Control)Panel1).Controls.Add((Control)(object)lblLabelForeColor);
		((Control)Panel1).Controls.Add((Control)(object)txtDM_BakgroundColorName);
		((Control)Panel1).Controls.Add((Control)(object)tbxLbForeColor);
		((Control)Panel1).Controls.Add((Control)(object)txtCT_AlternatingBackColorName);
		((Control)Panel1).Controls.Add((Control)(object)tbxSubMnFont);
		((Control)Panel1).Controls.Add((Control)(object)txtServiceUri);
		((Control)Panel1).Controls.Add((Control)(object)lblSubMnFont);
		((Control)Panel1).Controls.Add((Control)(object)txtCT_BakgroundColorName);
		((Control)Panel1).Controls.Add((Control)(object)lblMenuType);
		((Control)Panel1).Controls.Add((Control)(object)Label10);
		((Control)Panel1).Controls.Add((Control)(object)cbxMnType);
		((Control)Panel1).Controls.Add((Control)(object)Label11);
		((Control)Panel1).Controls.Add((Control)(object)lblColumn);
		((Control)Panel1).Controls.Add((Control)(object)Label6);
		((Control)Panel1).Controls.Add((Control)(object)tbxWColumn);
		((Control)Panel1).Controls.Add((Control)(object)Label7);
		((Control)Panel1).Controls.Add((Control)(object)lblMnBckClr);
		((Control)Panel1).Controls.Add((Control)(object)Label8);
		((Control)Panel1).Controls.Add((Control)(object)tbxBgColor);
		((Control)Panel1).Controls.Add((Control)(object)Label9);
		((Control)Panel1).Controls.Add((Control)(object)lblFont);
		((Control)Panel1).Controls.Add((Control)(object)Label4);
		((Control)Panel1).Controls.Add((Control)(object)tbxFont);
		((Control)Panel1).Controls.Add((Control)(object)Label5);
		((Control)Panel1).Controls.Add((Control)(object)lblWPanel);
		((Control)Panel1).Controls.Add((Control)(object)Label3);
		((Control)Panel1).Controls.Add((Control)(object)tbxWPanel);
		((Control)Panel1).Controls.Add((Control)(object)Label2);
		((Control)Panel1).Controls.Add((Control)(object)lblForeColor);
		((Control)Panel1).Controls.Add((Control)(object)tbDetailMnFont);
		((Control)Panel1).Controls.Add((Control)(object)tbxForeColor);
		((Control)Panel1).Controls.Add((Control)(object)lbDetailMnFont);
		((Control)Panel1).Controls.Add((Control)(object)lbMnSlFColor);
		((Control)Panel1).Controls.Add((Control)(object)tbxDetailMnForeColor);
		((Control)Panel1).Controls.Add((Control)(object)tbxMnSelectedColor);
		((Control)Panel1).Controls.Add((Control)(object)lbDetailMnForeColor);
		((Control)Panel1).Controls.Add((Control)(object)lblSubMnForeColor);
		((Control)Panel1).Controls.Add((Control)(object)tbxSubMnForeColor);
		((Control)Panel1).Dock = (DockStyle)2;
		Panel panel = Panel1;
		Point location = new Point(0, 413);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		Size size = new Size(823, 39);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 1;
		TextBox obj = txtField2CarryInReport;
		location = new Point(157, 7);
		((Control)obj).Location = location;
		((Control)txtField2CarryInReport).Name = "txtField2CarryInReport";
		((TextBoxBase)txtField2CarryInReport).ReadOnly = true;
		TextBox obj2 = txtField2CarryInReport;
		size = new Size(179, 20);
		((Control)obj2).Size = size;
		((Control)txtField2CarryInReport).TabIndex = 21;
		((Control)txtField2CarryInReport).Visible = false;
		((Control)btnGen_FieldList).Anchor = (AnchorStyles)10;
		((Control)btnGen_FieldList).Enabled = false;
		Button obj3 = btnGen_FieldList;
		location = new Point(582, 6);
		((Control)obj3).Location = location;
		((Control)btnGen_FieldList).Name = "btnGen_FieldList";
		Button obj4 = btnGen_FieldList;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)btnGen_FieldList).TabIndex = 2;
		((ButtonBase)btnGen_FieldList).Text = "&Gen Field";
		((ButtonBase)btnGen_FieldList).UseVisualStyleBackColor = true;
		TextBox obj5 = txtEscapeCharacters;
		location = new Point(88, 6);
		((Control)obj5).Location = location;
		((Control)txtEscapeCharacters).Name = "txtEscapeCharacters";
		((TextBoxBase)txtEscapeCharacters).ReadOnly = true;
		TextBox obj6 = txtEscapeCharacters;
		size = new Size(45, 20);
		((Control)obj6).Size = size;
		((Control)txtEscapeCharacters).TabIndex = 20;
		((Control)txtEscapeCharacters).Visible = false;
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
		ContextMenuStrip obj7 = ctMenuTool;
		size = new Size(161, 26);
		((Control)obj7).Size = size;
		((ToolStripItem)RestartToolStripMenuItem).Name = "RestartToolStripMenuItem";
		RestartToolStripMenuItem.ShortcutKeys = (Keys)131154;
		ToolStripMenuItem restartToolStripMenuItem = RestartToolStripMenuItem;
		size = new Size(160, 22);
		((ToolStripItem)restartToolStripMenuItem).Size = size;
		((ToolStripItem)RestartToolStripMenuItem).Text = "Restart";
		TextBox obj8 = txtAsTextBox_BakgroundColorName;
		location = new Point(88, 6);
		((Control)obj8).Location = location;
		((Control)txtAsTextBox_BakgroundColorName).Name = "txtAsTextBox_BakgroundColorName";
		((TextBoxBase)txtAsTextBox_BakgroundColorName).ReadOnly = true;
		TextBox obj9 = txtAsTextBox_BakgroundColorName;
		size = new Size(103, 20);
		((Control)obj9).Size = size;
		((Control)txtAsTextBox_BakgroundColorName).TabIndex = 19;
		((Control)txtAsTextBox_BakgroundColorName).Visible = false;
		Button obj10 = btnExcute;
		location = new Point(7, 6);
		((Control)obj10).Location = location;
		((Control)btnExcute).Name = "btnExcute";
		Button obj11 = btnExcute;
		size = new Size(75, 23);
		((Control)obj11).Size = size;
		((Control)btnExcute).TabIndex = 0;
		((ButtonBase)btnExcute).Text = "Tạo mới cty";
		((ButtonBase)btnExcute).UseVisualStyleBackColor = true;
		((Control)btnExcute).Visible = false;
		TextBox obj12 = txtBC_AlternatingBackColorName;
		location = new Point(88, 6);
		((Control)obj12).Location = location;
		((Control)txtBC_AlternatingBackColorName).Name = "txtBC_AlternatingBackColorName";
		((TextBoxBase)txtBC_AlternatingBackColorName).ReadOnly = true;
		TextBox obj13 = txtBC_AlternatingBackColorName;
		size = new Size(103, 20);
		((Control)obj13).Size = size;
		((Control)txtBC_AlternatingBackColorName).TabIndex = 18;
		((Control)txtBC_AlternatingBackColorName).Visible = false;
		((Control)btnExit).Anchor = (AnchorStyles)10;
		((ButtonBase)btnExit).Image = (Image)componentResourceManager.GetObject("btnExit.Image");
		((ButtonBase)btnExit).ImageAlign = (ContentAlignment)16;
		Button obj14 = btnExit;
		location = new Point(741, 6);
		((Control)obj14).Location = location;
		((Control)btnExit).Name = "btnExit";
		Button obj15 = btnExit;
		size = new Size(75, 23);
		((Control)obj15).Size = size;
		((Control)btnExit).TabIndex = 1;
		((ButtonBase)btnExit).Text = "&Thoát";
		((ButtonBase)btnExit).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnExit).UseVisualStyleBackColor = true;
		TextBox obj16 = txtBC_BakgroundColorName;
		location = new Point(88, 6);
		((Control)obj16).Location = location;
		((Control)txtBC_BakgroundColorName).Name = "txtBC_BakgroundColorName";
		((TextBoxBase)txtBC_BakgroundColorName).ReadOnly = true;
		TextBox obj17 = txtBC_BakgroundColorName;
		size = new Size(103, 20);
		((Control)obj17).Size = size;
		((Control)txtBC_BakgroundColorName).TabIndex = 17;
		((Control)txtBC_BakgroundColorName).Visible = false;
		label1.AutoSize = true;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj18 = label1;
		location = new Point(88, 6);
		((Control)obj18).Location = location;
		((Control)label1).Name = "label1";
		Label obj19 = label1;
		size = new Size(280, 24);
		((Control)obj19).Size = size;
		((Control)label1).TabIndex = 26;
		label1.Text = "Click vào ô để thay đổi giá trị";
		((Control)label1).Visible = false;
		TextBox obj20 = txtDM_AlternatingBackColorName;
		location = new Point(88, 6);
		((Control)obj20).Location = location;
		((Control)txtDM_AlternatingBackColorName).Name = "txtDM_AlternatingBackColorName";
		((TextBoxBase)txtDM_AlternatingBackColorName).ReadOnly = true;
		TextBox obj21 = txtDM_AlternatingBackColorName;
		size = new Size(103, 20);
		((Control)obj21).Size = size;
		((Control)txtDM_AlternatingBackColorName).TabIndex = 16;
		((Control)txtDM_AlternatingBackColorName).Visible = false;
		lblLabelForeColor.AutoSize = true;
		Label obj22 = lblLabelForeColor;
		location = new Point(88, 6);
		((Control)obj22).Location = location;
		((Control)lblLabelForeColor).Name = "lblLabelForeColor";
		Label obj23 = lblLabelForeColor;
		size = new Size(128, 13);
		((Control)obj23).Size = size;
		((Control)lblLabelForeColor).TabIndex = 45;
		lblLabelForeColor.Text = "Màu chữ phân hệ hiện tại";
		((Control)lblLabelForeColor).Visible = false;
		TextBox obj24 = txtDM_BakgroundColorName;
		location = new Point(88, 6);
		((Control)obj24).Location = location;
		((Control)txtDM_BakgroundColorName).Name = "txtDM_BakgroundColorName";
		((TextBoxBase)txtDM_BakgroundColorName).ReadOnly = true;
		TextBox obj25 = txtDM_BakgroundColorName;
		size = new Size(103, 20);
		((Control)obj25).Size = size;
		((Control)txtDM_BakgroundColorName).TabIndex = 15;
		((Control)txtDM_BakgroundColorName).Visible = false;
		TextBox obj26 = tbxLbForeColor;
		location = new Point(88, 6);
		((Control)obj26).Location = location;
		((Control)tbxLbForeColor).Name = "tbxLbForeColor";
		((TextBoxBase)tbxLbForeColor).ReadOnly = true;
		TextBox obj27 = tbxLbForeColor;
		size = new Size(103, 20);
		((Control)obj27).Size = size;
		((Control)tbxLbForeColor).TabIndex = 3;
		((Control)tbxLbForeColor).Visible = false;
		TextBox obj28 = txtCT_AlternatingBackColorName;
		location = new Point(88, 6);
		((Control)obj28).Location = location;
		((Control)txtCT_AlternatingBackColorName).Name = "txtCT_AlternatingBackColorName";
		((TextBoxBase)txtCT_AlternatingBackColorName).ReadOnly = true;
		TextBox obj29 = txtCT_AlternatingBackColorName;
		size = new Size(103, 20);
		((Control)obj29).Size = size;
		((Control)txtCT_AlternatingBackColorName).TabIndex = 14;
		((Control)txtCT_AlternatingBackColorName).Visible = false;
		TextBox obj30 = tbxSubMnFont;
		location = new Point(88, 6);
		((Control)obj30).Location = location;
		((Control)tbxSubMnFont).Name = "tbxSubMnFont";
		((TextBoxBase)tbxSubMnFont).ReadOnly = true;
		TextBox obj31 = tbxSubMnFont;
		size = new Size(243, 20);
		((Control)obj31).Size = size;
		((Control)tbxSubMnFont).TabIndex = 5;
		((Control)tbxSubMnFont).Visible = false;
		TextBox obj32 = txtServiceUri;
		location = new Point(88, 6);
		((Control)obj32).Location = location;
		((Control)txtServiceUri).Name = "txtServiceUri";
		TextBox obj33 = txtServiceUri;
		size = new Size(179, 20);
		((Control)obj33).Size = size;
		((Control)txtServiceUri).TabIndex = 12;
		((Control)txtServiceUri).Visible = false;
		lblSubMnFont.AutoSize = true;
		Label obj34 = lblSubMnFont;
		location = new Point(88, 6);
		((Control)obj34).Location = location;
		((Control)lblSubMnFont).Name = "lblSubMnFont";
		Label obj35 = lblSubMnFont;
		size = new Size(112, 13);
		((Control)obj35).Size = size;
		((Control)lblSubMnFont).TabIndex = 48;
		lblSubMnFont.Text = "Kiểu chữ phân hệ con";
		((Control)lblSubMnFont).Visible = false;
		TextBox obj36 = txtCT_BakgroundColorName;
		location = new Point(88, 6);
		((Control)obj36).Location = location;
		((Control)txtCT_BakgroundColorName).Name = "txtCT_BakgroundColorName";
		((TextBoxBase)txtCT_BakgroundColorName).ReadOnly = true;
		TextBox obj37 = txtCT_BakgroundColorName;
		size = new Size(103, 20);
		((Control)obj37).Size = size;
		((Control)txtCT_BakgroundColorName).TabIndex = 13;
		((Control)txtCT_BakgroundColorName).Visible = false;
		lblMenuType.AutoSize = true;
		((Control)lblMenuType).ForeColor = Color.Black;
		Label obj38 = lblMenuType;
		location = new Point(88, 6);
		((Control)obj38).Location = location;
		((Control)lblMenuType).Name = "lblMenuType";
		Label obj39 = lblMenuType;
		size = new Size(57, 13);
		((Control)obj39).Size = size;
		((Control)lblMenuType).TabIndex = 27;
		lblMenuType.Text = "Kiểu menu";
		((Control)lblMenuType).Visible = false;
		Label10.AutoSize = true;
		((Control)Label10).ForeColor = Color.Black;
		Label label = Label10;
		location = new Point(88, 6);
		((Control)label).Location = location;
		((Control)Label10).Name = "Label10";
		Label label2 = Label10;
		size = new Size(100, 13);
		((Control)label2).Size = size;
		((Control)Label10).TabIndex = 68;
		Label10.Text = "Field2CarryInReport";
		((Control)Label10).Visible = false;
		cbxMnType.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cbxMnType).FormattingEnabled = true;
		cbxMnType.Items.AddRange(new object[2] { "Tree", "Docking Menu" });
		ComboBox obj40 = cbxMnType;
		location = new Point(88, 6);
		((Control)obj40).Location = location;
		((Control)cbxMnType).Name = "cbxMnType";
		ComboBox obj41 = cbxMnType;
		size = new Size(103, 21);
		((Control)obj41).Size = size;
		((Control)cbxMnType).TabIndex = 0;
		((Control)cbxMnType).Visible = false;
		Label11.AutoSize = true;
		((Control)Label11).ForeColor = Color.Black;
		Label label3 = Label11;
		location = new Point(88, 6);
		((Control)label3).Location = location;
		((Control)Label11).Name = "Label11";
		Label label4 = Label11;
		size = new Size(94, 13);
		((Control)label4).Size = size;
		((Control)Label11).TabIndex = 67;
		Label11.Text = "EscapeCharacters";
		((Control)Label11).Visible = false;
		lblColumn.AutoSize = true;
		((Control)lblColumn).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj42 = lblColumn;
		location = new Point(88, 6);
		((Control)obj42).Location = location;
		((Control)lblColumn).Name = "lblColumn";
		Label obj43 = lblColumn;
		size = new Size(63, 13);
		((Control)obj43).Size = size;
		((Control)lblColumn).TabIndex = 30;
		lblColumn.Text = "Độ rộng cột";
		((Control)lblColumn).Visible = false;
		Label6.AutoSize = true;
		((Control)Label6).ForeColor = Color.Black;
		Label label5 = Label6;
		location = new Point(88, 6);
		((Control)label5).Location = location;
		((Control)Label6).Name = "Label6";
		Label label6 = Label6;
		size = new Size(86, 13);
		((Control)label6).Size = size;
		((Control)Label6).TabIndex = 66;
		Label6.Text = "Màu nền tex box";
		((Control)Label6).Visible = false;
		TextBox obj44 = tbxWColumn;
		location = new Point(88, 6);
		((Control)obj44).Location = location;
		((Control)tbxWColumn).Name = "tbxWColumn";
		TextBox obj45 = tbxWColumn;
		size = new Size(89, 20);
		((Control)obj45).Size = size;
		((Control)tbxWColumn).TabIndex = 6;
		((Control)tbxWColumn).Visible = false;
		Label7.AutoSize = true;
		((Control)Label7).ForeColor = Color.Black;
		Label label7 = Label7;
		location = new Point(88, 6);
		((Control)label7).Location = location;
		((Control)Label7).Name = "Label7";
		Label label8 = Label7;
		size = new Size(107, 13);
		((Control)label8).Size = size;
		((Control)Label7).TabIndex = 65;
		Label7.Text = "Màu dòng xen kẽ BC";
		((Control)Label7).Visible = false;
		lblMnBckClr.AutoSize = true;
		Label obj46 = lblMnBckClr;
		location = new Point(88, 6);
		((Control)obj46).Location = location;
		((Control)lblMnBckClr).Name = "lblMnBckClr";
		Label obj47 = lblMnBckClr;
		size = new Size(118, 13);
		((Control)obj47).Size = size;
		((Control)lblMnBckClr).TabIndex = 32;
		lblMnBckClr.Text = "Màu nền bảng phân hệ";
		((Control)lblMnBckClr).Visible = false;
		Label8.AutoSize = true;
		((Control)Label8).ForeColor = Color.Black;
		Label label9 = Label8;
		location = new Point(88, 6);
		((Control)label9).Location = location;
		((Control)Label8).Name = "Label8";
		Label label10 = Label8;
		size = new Size(66, 13);
		((Control)label10).Size = size;
		((Control)Label8).TabIndex = 64;
		Label8.Text = "Màu nền BC";
		((Control)Label8).Visible = false;
		TextBox obj48 = tbxBgColor;
		location = new Point(88, 6);
		((Control)obj48).Location = location;
		((Control)tbxBgColor).Name = "tbxBgColor";
		((TextBoxBase)tbxBgColor).ReadOnly = true;
		TextBox obj49 = tbxBgColor;
		size = new Size(103, 20);
		((Control)obj49).Size = size;
		((Control)tbxBgColor).TabIndex = 2;
		((Control)tbxBgColor).Visible = false;
		Label9.AutoSize = true;
		((Control)Label9).ForeColor = Color.Black;
		Label label11 = Label9;
		location = new Point(88, 6);
		((Control)label11).Location = location;
		((Control)Label9).Name = "Label9";
		Label label12 = Label9;
		size = new Size(110, 13);
		((Control)label12).Size = size;
		((Control)Label9).TabIndex = 63;
		Label9.Text = "Màu dòng xen kẽ DM";
		((Control)Label9).Visible = false;
		lblFont.AutoSize = true;
		Label obj50 = lblFont;
		location = new Point(88, 6);
		((Control)obj50).Location = location;
		((Control)lblFont).Name = "lblFont";
		Label obj51 = lblFont;
		size = new Size(91, 13);
		((Control)obj51).Size = size;
		((Control)lblFont).TabIndex = 35;
		lblFont.Text = "Kiểu chữ phân hệ";
		((Control)lblFont).Visible = false;
		Label4.AutoSize = true;
		((Control)Label4).ForeColor = Color.Black;
		Label label13 = Label4;
		location = new Point(88, 6);
		((Control)label13).Location = location;
		((Control)Label4).Name = "Label4";
		Label label14 = Label4;
		size = new Size(69, 13);
		((Control)label14).Size = size;
		((Control)Label4).TabIndex = 62;
		Label4.Text = "Màu nền DM";
		((Control)Label4).Visible = false;
		TextBox obj52 = tbxFont;
		location = new Point(88, 6);
		((Control)obj52).Location = location;
		((Control)tbxFont).Name = "tbxFont";
		((TextBoxBase)tbxFont).ReadOnly = true;
		TextBox obj53 = tbxFont;
		size = new Size(243, 20);
		((Control)obj53).Size = size;
		((Control)tbxFont).TabIndex = 4;
		((Control)tbxFont).Visible = false;
		Label5.AutoSize = true;
		((Control)Label5).ForeColor = Color.Black;
		Label label15 = Label5;
		location = new Point(88, 6);
		((Control)label15).Location = location;
		((Control)Label5).Name = "Label5";
		Label label16 = Label5;
		size = new Size(110, 13);
		((Control)label16).Size = size;
		((Control)Label5).TabIndex = 61;
		Label5.Text = "Màu dòng xen kẽ  CT";
		((Control)Label5).Visible = false;
		lblWPanel.AutoSize = true;
		Label obj54 = lblWPanel;
		location = new Point(88, 6);
		((Control)obj54).Location = location;
		((Control)lblWPanel).Name = "lblWPanel";
		Label obj55 = lblWPanel;
		size = new Size(114, 13);
		((Control)obj55).Size = size;
		((Control)lblWPanel).TabIndex = 39;
		lblWPanel.Text = "Độ rộng bảng phân hệ";
		((Control)lblWPanel).Visible = false;
		Label3.AutoSize = true;
		((Control)Label3).ForeColor = Color.Black;
		Label label17 = Label3;
		location = new Point(88, 6);
		((Control)label17).Location = location;
		((Control)Label3).Name = "Label3";
		Label label18 = Label3;
		size = new Size(66, 13);
		((Control)label18).Size = size;
		((Control)Label3).TabIndex = 60;
		Label3.Text = "Màu nền CT";
		((Control)Label3).Visible = false;
		TextBox obj56 = tbxWPanel;
		location = new Point(88, 6);
		((Control)obj56).Location = location;
		((Control)tbxWPanel).Name = "tbxWPanel";
		TextBox obj57 = tbxWPanel;
		size = new Size(103, 20);
		((Control)obj57).Size = size;
		((Control)tbxWPanel).TabIndex = 1;
		((Control)tbxWPanel).Visible = false;
		Label2.AutoSize = true;
		((Control)Label2).ForeColor = Color.Black;
		Label label19 = Label2;
		location = new Point(88, 6);
		((Control)label19).Location = location;
		((Control)Label2).Name = "Label2";
		Label label20 = Label2;
		size = new Size(56, 13);
		((Control)label20).Size = size;
		((Control)Label2).TabIndex = 59;
		Label2.Text = "ServiceUri";
		((Control)Label2).Visible = false;
		lblForeColor.AutoSize = true;
		Label obj58 = lblForeColor;
		location = new Point(88, 6);
		((Control)obj58).Location = location;
		((Control)lblForeColor).Name = "lblForeColor";
		Label obj59 = lblForeColor;
		size = new Size(91, 13);
		((Control)obj59).Size = size;
		((Control)lblForeColor).TabIndex = 53;
		lblForeColor.Text = "Màu chữ phân hệ";
		((Control)lblForeColor).Visible = false;
		TextBox obj60 = tbDetailMnFont;
		location = new Point(88, 6);
		((Control)obj60).Location = location;
		((Control)tbDetailMnFont).Name = "tbDetailMnFont";
		((TextBoxBase)tbDetailMnFont).ReadOnly = true;
		TextBox obj61 = tbDetailMnFont;
		size = new Size(201, 20);
		((Control)obj61).Size = size;
		((Control)tbDetailMnFont).TabIndex = 11;
		((Control)tbDetailMnFont).Visible = false;
		TextBox obj62 = tbxForeColor;
		location = new Point(88, 6);
		((Control)obj62).Location = location;
		((Control)tbxForeColor).Name = "tbxForeColor";
		((TextBoxBase)tbxForeColor).ReadOnly = true;
		TextBox obj63 = tbxForeColor;
		size = new Size(89, 20);
		((Control)obj63).Size = size;
		((Control)tbxForeColor).TabIndex = 7;
		((Control)tbxForeColor).Visible = false;
		lbDetailMnFont.AutoSize = true;
		Label obj64 = lbDetailMnFont;
		location = new Point(88, 6);
		((Control)obj64).Location = location;
		((Control)lbDetailMnFont).Name = "lbDetailMnFont";
		Label obj65 = lbDetailMnFont;
		size = new Size(103, 13);
		((Control)obj65).Size = size;
		((Control)lbDetailMnFont).TabIndex = 58;
		lbDetailMnFont.Text = "Kiểu chữ chức năng";
		((Control)lbDetailMnFont).Visible = false;
		lbMnSlFColor.AutoSize = true;
		Label obj66 = lbMnSlFColor;
		location = new Point(88, 6);
		((Control)obj66).Location = location;
		((Control)lbMnSlFColor).Name = "lbMnSlFColor";
		Label obj67 = lbMnSlFColor;
		size = new Size(146, 13);
		((Control)obj67).Size = size;
		((Control)lbMnSlFColor).TabIndex = 55;
		lbMnSlFColor.Text = "Màu chữ phân hệ đang chọn";
		((Control)lbMnSlFColor).Visible = false;
		TextBox obj68 = tbxDetailMnForeColor;
		location = new Point(88, 6);
		((Control)obj68).Location = location;
		((Control)tbxDetailMnForeColor).Name = "tbxDetailMnForeColor";
		((TextBoxBase)tbxDetailMnForeColor).ReadOnly = true;
		TextBox obj69 = tbxDetailMnForeColor;
		size = new Size(89, 20);
		((Control)obj69).Size = size;
		((Control)tbxDetailMnForeColor).TabIndex = 10;
		((Control)tbxDetailMnForeColor).Visible = false;
		TextBox obj70 = tbxMnSelectedColor;
		location = new Point(88, 6);
		((Control)obj70).Location = location;
		((Control)tbxMnSelectedColor).Name = "tbxMnSelectedColor";
		((TextBoxBase)tbxMnSelectedColor).ReadOnly = true;
		TextBox obj71 = tbxMnSelectedColor;
		size = new Size(89, 20);
		((Control)obj71).Size = size;
		((Control)tbxMnSelectedColor).TabIndex = 8;
		((Control)tbxMnSelectedColor).Visible = false;
		lbDetailMnForeColor.AutoSize = true;
		Label obj72 = lbDetailMnForeColor;
		location = new Point(88, 6);
		((Control)obj72).Location = location;
		((Control)lbDetailMnForeColor).Name = "lbDetailMnForeColor";
		Label obj73 = lbDetailMnForeColor;
		size = new Size(103, 13);
		((Control)obj73).Size = size;
		((Control)lbDetailMnForeColor).TabIndex = 57;
		lbDetailMnForeColor.Text = "Màu chữ chức năng";
		((Control)lbDetailMnForeColor).Visible = false;
		lblSubMnForeColor.AutoSize = true;
		Label obj74 = lblSubMnForeColor;
		location = new Point(88, 6);
		((Control)obj74).Location = location;
		((Control)lblSubMnForeColor).Name = "lblSubMnForeColor";
		Label obj75 = lblSubMnForeColor;
		size = new Size(112, 13);
		((Control)obj75).Size = size;
		((Control)lblSubMnForeColor).TabIndex = 56;
		lblSubMnForeColor.Text = "Màu chữ phân hệ con";
		((Control)lblSubMnForeColor).Visible = false;
		TextBox obj76 = tbxSubMnForeColor;
		location = new Point(88, 6);
		((Control)obj76).Location = location;
		((Control)tbxSubMnForeColor).Name = "tbxSubMnForeColor";
		((TextBoxBase)tbxSubMnForeColor).ReadOnly = true;
		TextBox obj77 = tbxSubMnForeColor;
		size = new Size(89, 20);
		((Control)obj77).Size = size;
		((Control)tbxSubMnForeColor).TabIndex = 9;
		((Control)tbxSubMnForeColor).Visible = false;
		tabTools.Appearance = (TabAppearance)2;
		((Control)tabTools).Controls.Add((Control)(object)tabInterface);
		((Control)tabTools).Controls.Add((Control)(object)tabComanyInfo);
		((Control)tabTools).Controls.Add((Control)(object)tabExcProc);
		((Control)tabTools).Controls.Add((Control)(object)tabMenu);
		((Control)tabTools).Cursor = Cursors.Arrow;
		((Control)tabTools).Dock = (DockStyle)5;
		((Control)tabTools).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		TabControl obj78 = tabTools;
		location = new Point(0, 0);
		((Control)obj78).Location = location;
		tabTools.Multiline = true;
		((Control)tabTools).Name = "tabTools";
		tabTools.SelectedIndex = 0;
		TabControl obj79 = tabTools;
		size = new Size(823, 413);
		((Control)obj79).Size = size;
		tabTools.SizeMode = (TabSizeMode)2;
		((Control)tabTools).TabIndex = 0;
		((Control)tabInterface).Controls.Add((Control)(object)btnOpendialog);
		((Control)tabInterface).Controls.Add((Control)(object)txtUpdatePatch);
		((Control)tabInterface).Controls.Add((Control)(object)lblPathUpdate);
		((Control)tabInterface).Controls.Add((Control)(object)asdgvClientConfig);
		TabPage obj80 = tabInterface;
		location = new Point(4, 25);
		obj80.Location = location;
		((Control)tabInterface).Name = "tabInterface";
		TabPage obj81 = tabInterface;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)obj81).Padding = padding;
		TabPage obj82 = tabInterface;
		size = new Size(815, 384);
		((Control)obj82).Size = size;
		tabInterface.TabIndex = 1;
		tabInterface.Text = "Client config";
		tabInterface.UseVisualStyleBackColor = true;
		((Control)btnOpendialog).Anchor = (AnchorStyles)6;
		Button obj83 = btnOpendialog;
		location = new Point(666, 354);
		((Control)obj83).Location = location;
		((Control)btnOpendialog).Name = "btnOpendialog";
		Button obj84 = btnOpendialog;
		size = new Size(45, 23);
		((Control)obj84).Size = size;
		((Control)btnOpendialog).TabIndex = 3;
		((ButtonBase)btnOpendialog).Text = "...";
		((ButtonBase)btnOpendialog).UseVisualStyleBackColor = true;
		((Control)txtUpdatePatch).Anchor = (AnchorStyles)6;
		TextBox obj85 = txtUpdatePatch;
		location = new Point(194, 356);
		((Control)obj85).Location = location;
		((Control)txtUpdatePatch).Name = "txtUpdatePatch";
		TextBox obj86 = txtUpdatePatch;
		size = new Size(469, 20);
		((Control)obj86).Size = size;
		((Control)txtUpdatePatch).TabIndex = 2;
		((Control)lblPathUpdate).Anchor = (AnchorStyles)6;
		lblPathUpdate.AutoSize = true;
		Label obj87 = lblPathUpdate;
		location = new Point(12, 359);
		((Control)obj87).Location = location;
		((Control)lblPathUpdate).Name = "lblPathUpdate";
		Label obj88 = lblPathUpdate;
		size = new Size(175, 13);
		((Control)obj88).Size = size;
		((Control)lblPathUpdate).TabIndex = 1;
		lblPathUpdate.Text = "Cập nhật phiên bản mới từ thư mục:";
		((DataGridView)asdgvClientConfig).AllowUserToAddRows = false;
		((DataGridView)asdgvClientConfig).AllowUserToDeleteRows = false;
		((Control)asdgvClientConfig).Anchor = (AnchorStyles)15;
		((DataGridView)asdgvClientConfig).BackgroundColor = Color.White;
		((DataGridView)asdgvClientConfig).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asdgvClientConfig).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)asdgvClientConfig).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)asdgvClientConfig).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)dgvcFields,
			(DataGridViewColumn)dgvcValue,
			(DataGridViewColumn)dgvcDescription
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asdgvClientConfig).DefaultCellStyle = val2;
		((DataGridView)asdgvClientConfig).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = asdgvClientConfig;
		location = new Point(8, 6);
		((Control)asInputDGV).Location = location;
		((Control)asdgvClientConfig).Name = "asdgvClientConfig";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asdgvClientConfig).RowHeadersDefaultCellStyle = val3;
		((DataGridView)asdgvClientConfig).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = asdgvClientConfig;
		size = new Size(799, 343);
		((Control)asInputDGV2).Size = size;
		((Control)asdgvClientConfig).TabIndex = 0;
		((DataGridViewColumn)dgvcFields).AutoSizeMode = (DataGridViewAutoSizeColumnMode)10;
		((DataGridViewColumn)dgvcFields).DataPropertyName = "Key";
		((DataGridViewColumn)dgvcFields).HeaderText = "Tên trường";
		((DataGridViewColumn)dgvcFields).Name = "dgvcFields";
		((DataGridViewColumn)dgvcFields).ReadOnly = true;
		((DataGridViewColumn)dgvcFields).Width = 84;
		((DataGridViewColumn)dgvcValue).DataPropertyName = "Value";
		((DataGridViewColumn)dgvcValue).HeaderText = "Giá trị";
		((DataGridViewColumn)dgvcValue).Name = "dgvcValue";
		((DataGridViewColumn)dgvcValue).Width = 150;
		((DataGridViewColumn)dgvcDescription).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)dgvcDescription).DataPropertyName = "Description";
		((DataGridViewColumn)dgvcDescription).HeaderText = "Mô tả";
		((DataGridViewColumn)dgvcDescription).Name = "dgvcDescription";
		((DataGridViewColumn)dgvcDescription).ReadOnly = true;
		((Control)tabComanyInfo).Controls.Add((Control)(object)asDgvCompanyInfo);
		TabPage obj89 = tabComanyInfo;
		location = new Point(4, 25);
		obj89.Location = location;
		((Control)tabComanyInfo).Name = "tabComanyInfo";
		TabPage obj90 = tabComanyInfo;
		((Padding)(ref padding))._002Ector(3);
		((Control)obj90).Padding = padding;
		TabPage obj91 = tabComanyInfo;
		size = new Size(815, 384);
		((Control)obj91).Size = size;
		tabComanyInfo.TabIndex = 0;
		tabComanyInfo.Text = "Thông tin công ty";
		tabComanyInfo.UseVisualStyleBackColor = true;
		((DataGridView)asDgvCompanyInfo).AllowUserToAddRows = false;
		((DataGridView)asDgvCompanyInfo).AllowUserToDeleteRows = false;
		val4.BackColor = SystemColors.Info;
		((DataGridView)asDgvCompanyInfo).AlternatingRowsDefaultCellStyle = val4;
		((DataGridView)asDgvCompanyInfo).BackgroundColor = Color.White;
		((DataGridView)asDgvCompanyInfo).BorderStyle = (BorderStyle)2;
		val5.Alignment = (DataGridViewContentAlignment)16;
		val5.BackColor = SystemColors.Control;
		val5.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val5.ForeColor = SystemColors.WindowText;
		val5.SelectionBackColor = SystemColors.Highlight;
		val5.SelectionForeColor = SystemColors.HighlightText;
		val5.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvCompanyInfo).ColumnHeadersDefaultCellStyle = val5;
		((DataGridView)asDgvCompanyInfo).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val6.Alignment = (DataGridViewContentAlignment)16;
		val6.BackColor = SystemColors.Window;
		val6.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val6.ForeColor = SystemColors.ControlText;
		val6.SelectionBackColor = SystemColors.Highlight;
		val6.SelectionForeColor = SystemColors.HighlightText;
		val6.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDgvCompanyInfo).DefaultCellStyle = val6;
		((Control)asDgvCompanyInfo).Dock = (DockStyle)5;
		asDgvCompanyInfo.DoubleBuffered = false;
		((DataGridView)asDgvCompanyInfo).EditMode = (DataGridViewEditMode)0;
		((DataGridView)asDgvCompanyInfo).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = asDgvCompanyInfo;
		location = new Point(3, 3);
		((Control)asDataGridView).Location = location;
		((Control)asDgvCompanyInfo).Name = "asDgvCompanyInfo";
		val7.Alignment = (DataGridViewContentAlignment)32;
		val7.BackColor = SystemColors.Control;
		val7.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val7.ForeColor = SystemColors.WindowText;
		val7.SelectionBackColor = SystemColors.Highlight;
		val7.SelectionForeColor = SystemColors.HighlightText;
		val7.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvCompanyInfo).RowHeadersDefaultCellStyle = val7;
		asDgvCompanyInfo.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDgvCompanyInfo).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = asDgvCompanyInfo;
		size = new Size(809, 378);
		((Control)asDataGridView2).Size = size;
		((Control)asDgvCompanyInfo).TabIndex = 0;
		((Control)tabExcProc).Controls.Add((Control)(object)splExeSP);
		TabPage obj92 = tabExcProc;
		location = new Point(4, 25);
		obj92.Location = location;
		((Control)tabExcProc).Name = "tabExcProc";
		TabPage obj93 = tabExcProc;
		((Padding)(ref padding))._002Ector(3);
		((Control)obj93).Padding = padding;
		TabPage obj94 = tabExcProc;
		size = new Size(815, 384);
		((Control)obj94).Size = size;
		tabExcProc.TabIndex = 3;
		tabExcProc.Text = "Execute SP";
		tabExcProc.UseVisualStyleBackColor = true;
		splExeSP.Dock = (DockStyle)5;
		SplitContainer obj95 = splExeSP;
		location = new Point(3, 3);
		((Control)obj95).Location = location;
		((Control)splExeSP).Name = "splExeSP";
		splExeSP.Orientation = (Orientation)0;
		((Control)splExeSP.Panel1).Controls.Add((Control)(object)Panel3);
		((Control)splExeSP.Panel1).RightToLeft = (RightToLeft)0;
		((Control)splExeSP.Panel2).Controls.Add((Control)(object)asDgvResult);
		((Control)splExeSP.Panel2).RightToLeft = (RightToLeft)0;
		splExeSP.Panel2Collapsed = true;
		SplitContainer obj96 = splExeSP;
		size = new Size(809, 378);
		((Control)obj96).Size = size;
		splExeSP.SplitterDistance = 158;
		((Control)splExeSP).TabIndex = 0;
		((Control)Panel3).Controls.Add((Control)(object)splInfo);
		((Control)Panel3).Dock = (DockStyle)5;
		Panel panel3 = Panel3;
		location = new Point(0, 0);
		((Control)panel3).Location = location;
		((Control)Panel3).Name = "Panel3";
		Panel panel4 = Panel3;
		size = new Size(809, 378);
		((Control)panel4).Size = size;
		((Control)Panel3).TabIndex = 3;
		splInfo.Dock = (DockStyle)5;
		SplitContainer obj97 = splInfo;
		location = new Point(0, 0);
		((Control)obj97).Location = location;
		((Control)splInfo).Name = "splInfo";
		((Control)splInfo.Panel1).Controls.Add((Control)(object)asdgvStoreProc);
		((Control)splInfo.Panel1).RightToLeft = (RightToLeft)0;
		((Control)splInfo.Panel2).Controls.Add((Control)(object)asdgvParameter);
		((Control)splInfo.Panel2).RightToLeft = (RightToLeft)0;
		SplitContainer obj98 = splInfo;
		size = new Size(809, 378);
		((Control)obj98).Size = size;
		splInfo.SplitterDistance = 301;
		((Control)splInfo).TabIndex = 0;
		((DataGridView)asdgvStoreProc).AllowUserToAddRows = false;
		((DataGridView)asdgvStoreProc).AllowUserToDeleteRows = false;
		((DataGridView)asdgvStoreProc).AllowUserToResizeRows = false;
		((DataGridView)asdgvStoreProc).BackgroundColor = Color.White;
		((DataGridView)asdgvStoreProc).BorderStyle = (BorderStyle)2;
		val8.Alignment = (DataGridViewContentAlignment)16;
		val8.BackColor = SystemColors.Control;
		val8.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val8.ForeColor = SystemColors.WindowText;
		val8.SelectionBackColor = SystemColors.Highlight;
		val8.SelectionForeColor = SystemColors.HighlightText;
		val8.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asdgvStoreProc).ColumnHeadersDefaultCellStyle = val8;
		((DataGridView)asdgvStoreProc).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val9.Alignment = (DataGridViewContentAlignment)16;
		val9.BackColor = SystemColors.Window;
		val9.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val9.ForeColor = SystemColors.ControlText;
		val9.SelectionBackColor = SystemColors.Highlight;
		val9.SelectionForeColor = SystemColors.HighlightText;
		val9.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asdgvStoreProc).DefaultCellStyle = val9;
		((Control)asdgvStoreProc).Dock = (DockStyle)5;
		asdgvStoreProc.DoubleBuffered = false;
		((DataGridView)asdgvStoreProc).EditMode = (DataGridViewEditMode)3;
		((DataGridView)asdgvStoreProc).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView3 = asdgvStoreProc;
		location = new Point(0, 0);
		((Control)asDataGridView3).Location = location;
		((DataGridView)asdgvStoreProc).MultiSelect = false;
		((Control)asdgvStoreProc).Name = "asdgvStoreProc";
		asdgvStoreProc.ReadOnly = true;
		val10.Alignment = (DataGridViewContentAlignment)32;
		val10.BackColor = SystemColors.Control;
		val10.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val10.ForeColor = SystemColors.WindowText;
		val10.SelectionBackColor = SystemColors.Highlight;
		val10.SelectionForeColor = SystemColors.HighlightText;
		val10.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asdgvStoreProc).RowHeadersDefaultCellStyle = val10;
		asdgvStoreProc.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asdgvStoreProc).RowTemplate.Height = 20;
		AsDataGridView asDataGridView4 = asdgvStoreProc;
		size = new Size(301, 378);
		((Control)asDataGridView4).Size = size;
		((Control)asdgvStoreProc).TabIndex = 3;
		((DataGridView)asdgvParameter).AllowUserToAddRows = false;
		((DataGridView)asdgvParameter).AllowUserToDeleteRows = false;
		((DataGridView)asdgvParameter).AllowUserToResizeRows = false;
		((DataGridView)asdgvParameter).AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		((DataGridView)asdgvParameter).AutoSizeRowsMode = (DataGridViewAutoSizeRowsMode)7;
		((DataGridView)asdgvParameter).BackgroundColor = Color.White;
		((DataGridView)asdgvParameter).BorderStyle = (BorderStyle)2;
		val11.Alignment = (DataGridViewContentAlignment)16;
		val11.BackColor = SystemColors.Control;
		val11.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val11.ForeColor = SystemColors.WindowText;
		val11.SelectionBackColor = SystemColors.Highlight;
		val11.SelectionForeColor = SystemColors.HighlightText;
		val11.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asdgvParameter).ColumnHeadersDefaultCellStyle = val11;
		((DataGridView)asdgvParameter).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val12.Alignment = (DataGridViewContentAlignment)16;
		val12.BackColor = SystemColors.Window;
		val12.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val12.ForeColor = SystemColors.ControlText;
		val12.SelectionBackColor = SystemColors.Highlight;
		val12.SelectionForeColor = SystemColors.HighlightText;
		val12.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asdgvParameter).DefaultCellStyle = val12;
		((Control)asdgvParameter).Dock = (DockStyle)5;
		asdgvParameter.DoubleBuffered = false;
		((DataGridView)asdgvParameter).EditMode = (DataGridViewEditMode)0;
		((DataGridView)asdgvParameter).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView5 = asdgvParameter;
		location = new Point(0, 0);
		((Control)asDataGridView5).Location = location;
		((DataGridView)asdgvParameter).MultiSelect = false;
		((Control)asdgvParameter).Name = "asdgvParameter";
		val13.Alignment = (DataGridViewContentAlignment)32;
		val13.BackColor = SystemColors.Control;
		val13.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val13.ForeColor = SystemColors.WindowText;
		val13.SelectionBackColor = SystemColors.Highlight;
		val13.SelectionForeColor = SystemColors.HighlightText;
		val13.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asdgvParameter).RowHeadersDefaultCellStyle = val13;
		asdgvParameter.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asdgvParameter).RowTemplate.Height = 20;
		AsDataGridView asDataGridView6 = asdgvParameter;
		size = new Size(504, 378);
		((Control)asDataGridView6).Size = size;
		((Control)asdgvParameter).TabIndex = 3;
		((DataGridView)asDgvResult).AllowUserToAddRows = false;
		((DataGridView)asDgvResult).AllowUserToDeleteRows = false;
		((DataGridView)asDgvResult).BackgroundColor = Color.White;
		((DataGridView)asDgvResult).BorderStyle = (BorderStyle)2;
		((DataGridView)asDgvResult).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((Control)asDgvResult).Dock = (DockStyle)5;
		asDgvResult.DoubleBuffered = false;
		((DataGridView)asDgvResult).EditMode = (DataGridViewEditMode)3;
		((DataGridView)asDgvResult).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView7 = asDgvResult;
		location = new Point(0, 0);
		((Control)asDataGridView7).Location = location;
		((Control)asDgvResult).Name = "asDgvResult";
		asDgvResult.ReadOnly = true;
		val14.Alignment = (DataGridViewContentAlignment)32;
		val14.BackColor = SystemColors.Control;
		val14.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val14.ForeColor = SystemColors.WindowText;
		val14.SelectionBackColor = SystemColors.Highlight;
		val14.SelectionForeColor = SystemColors.HighlightText;
		val14.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvResult).RowHeadersDefaultCellStyle = val14;
		asDgvResult.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDgvResult).RowTemplate.Height = 20;
		AsDataGridView asDataGridView8 = asDgvResult;
		size = new Size(150, 46);
		((Control)asDataGridView8).Size = size;
		((Control)asDgvResult).TabIndex = 101;
		((Control)tabMenu).Controls.Add((Control)(object)tabMenuAll);
		TabPage obj99 = tabMenu;
		location = new Point(4, 25);
		obj99.Location = location;
		((Control)tabMenu).Name = "tabMenu";
		TabPage obj100 = tabMenu;
		((Padding)(ref padding))._002Ector(3);
		((Control)obj100).Padding = padding;
		TabPage obj101 = tabMenu;
		size = new Size(815, 384);
		((Control)obj101).Size = size;
		tabMenu.TabIndex = 2;
		tabMenu.Text = "Khai báo menu ";
		tabMenu.UseVisualStyleBackColor = true;
		tabMenuAll.Appearance = (TabAppearance)1;
		((Control)tabMenuAll).Controls.Add((Control)(object)tabListMenu);
		((Control)tabMenuAll).Controls.Add((Control)(object)tabDicRex);
		((Control)tabMenuAll).Controls.Add((Control)(object)tabRepRex);
		((Control)tabMenuAll).Controls.Add((Control)(object)tabRepDrillDown);
		((Control)tabMenuAll).Controls.Add((Control)(object)tabVoucher);
		((Control)tabMenuAll).Controls.Add((Control)(object)tabDaoInfo);
		((Control)tabMenuAll).Cursor = Cursors.Arrow;
		((Control)tabMenuAll).Dock = (DockStyle)5;
		TabControl obj102 = tabMenuAll;
		location = new Point(3, 3);
		((Control)obj102).Location = location;
		tabMenuAll.Multiline = true;
		((Control)tabMenuAll).Name = "tabMenuAll";
		tabMenuAll.SelectedIndex = 0;
		TabControl obj103 = tabMenuAll;
		size = new Size(809, 378);
		((Control)obj103).Size = size;
		tabMenuAll.SizeMode = (TabSizeMode)2;
		((Control)tabMenuAll).TabIndex = 0;
		((Control)tabListMenu).Controls.Add((Control)(object)asDgvMenu);
		((Control)tabListMenu).Controls.Add((Control)(object)Panel2);
		TabPage obj104 = tabListMenu;
		location = new Point(4, 25);
		obj104.Location = location;
		((Control)tabListMenu).Name = "tabListMenu";
		TabPage obj105 = tabListMenu;
		((Padding)(ref padding))._002Ector(3);
		((Control)obj105).Padding = padding;
		TabPage obj106 = tabListMenu;
		size = new Size(801, 349);
		((Control)obj106).Size = size;
		tabListMenu.TabIndex = 0;
		tabListMenu.Text = "Menu";
		tabListMenu.UseVisualStyleBackColor = true;
		((DataGridView)asDgvMenu).AllowUserToAddRows = false;
		((DataGridView)asDgvMenu).AllowUserToDeleteRows = false;
		val15.BackColor = Color.AliceBlue;
		((DataGridView)asDgvMenu).AlternatingRowsDefaultCellStyle = val15;
		((DataGridView)asDgvMenu).BackgroundColor = Color.White;
		((DataGridView)asDgvMenu).BorderStyle = (BorderStyle)2;
		val16.Alignment = (DataGridViewContentAlignment)16;
		val16.BackColor = SystemColors.Control;
		val16.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val16.ForeColor = SystemColors.WindowText;
		val16.SelectionBackColor = SystemColors.Highlight;
		val16.SelectionForeColor = SystemColors.HighlightText;
		val16.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvMenu).ColumnHeadersDefaultCellStyle = val16;
		((DataGridView)asDgvMenu).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val17.Alignment = (DataGridViewContentAlignment)16;
		val17.BackColor = SystemColors.Window;
		val17.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val17.ForeColor = SystemColors.ControlText;
		val17.SelectionBackColor = SystemColors.Highlight;
		val17.SelectionForeColor = SystemColors.HighlightText;
		val17.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDgvMenu).DefaultCellStyle = val17;
		((Control)asDgvMenu).Dock = (DockStyle)5;
		asDgvMenu.DoubleBuffered = false;
		((DataGridView)asDgvMenu).EditMode = (DataGridViewEditMode)1;
		((DataGridView)asDgvMenu).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView9 = asDgvMenu;
		location = new Point(3, 79);
		((Control)asDataGridView9).Location = location;
		((Control)asDgvMenu).Name = "asDgvMenu";
		val18.Alignment = (DataGridViewContentAlignment)32;
		val18.BackColor = SystemColors.Control;
		val18.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val18.ForeColor = SystemColors.WindowText;
		val18.SelectionBackColor = SystemColors.Highlight;
		val18.SelectionForeColor = SystemColors.HighlightText;
		val18.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvMenu).RowHeadersDefaultCellStyle = val18;
		asDgvMenu.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDgvMenu).RowTemplate.Height = 20;
		AsDataGridView asDataGridView10 = asDgvMenu;
		size = new Size(795, 267);
		((Control)asDataGridView10).Size = size;
		((Control)asDgvMenu).TabIndex = 3;
		Panel2.BorderStyle = (BorderStyle)2;
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
		((ButtonBase)btnCreate).FlatStyle = (FlatStyle)1;
		Button obj107 = btnCreate;
		location = new Point(708, 39);
		((Control)obj107).Location = location;
		((Control)btnCreate).Name = "btnCreate";
		Button obj108 = btnCreate;
		size = new Size(75, 23);
		((Control)obj108).Size = size;
		((Control)btnCreate).TabIndex = 4;
		((ButtonBase)btnCreate).Text = "Thêm mới";
		((ButtonBase)btnCreate).UseVisualStyleBackColor = true;
		cmbModuleFunc.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cmbModuleFunc).FormattingEnabled = true;
		ComboBox obj109 = cmbModuleFunc;
		location = new Point(124, 41);
		((Control)obj109).Location = location;
		((Control)cmbModuleFunc).Name = "cmbModuleFunc";
		ComboBox obj110 = cmbModuleFunc;
		size = new Size(193, 21);
		((Control)obj110).Size = size;
		((Control)cmbModuleFunc).TabIndex = 1;
		Label12.AutoSize = true;
		Label label21 = Label12;
		location = new Point(10, 17);
		((Control)label21).Location = location;
		((Control)Label12).Name = "Label12";
		Label label22 = Label12;
		size = new Size(42, 13);
		((Control)label22).Size = size;
		((Control)Label12).TabIndex = 0;
		Label12.Text = "Module";
		Label13.AutoSize = true;
		Label label23 = Label13;
		location = new Point(10, 44);
		((Control)label23).Location = location;
		((Control)Label13).Name = "Label13";
		Label label24 = Label13;
		size = new Size(83, 13);
		((Control)label24).Size = size;
		((Control)Label13).TabIndex = 2;
		Label13.Text = "Module function";
		cmbModule.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cmbModule).FormattingEnabled = true;
		ComboBox obj111 = cmbModule;
		location = new Point(124, 14);
		((Control)obj111).Location = location;
		((Control)cmbModule).Name = "cmbModule";
		ComboBox obj112 = cmbModule;
		size = new Size(193, 21);
		((Control)obj112).Size = size;
		((Control)cmbModule).TabIndex = 0;
		cmbTranfer.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cmbTranfer).FormattingEnabled = true;
		cmbTranfer.Items.AddRange(new object[3] { "0 - DictionaryInfo", "1 - ReportInfo", "2 - VoucherInfo" });
		ComboBox obj113 = cmbTranfer;
		location = new Point(509, 41);
		((Control)obj113).Location = location;
		((Control)cmbTranfer).Name = "cmbTranfer";
		ComboBox obj114 = cmbTranfer;
		size = new Size(193, 21);
		((Control)obj114).Size = size;
		((Control)cmbTranfer).TabIndex = 2;
		TT_Grid.SetToolTip((Control)(object)cmbTranfer, "F4 - Thêm ; F5 -  tìm kiếm ; F8 - Xóa");
		((Control)tabDicRex).Controls.Add((Control)(object)splDicRec);
		TabPage obj115 = tabDicRex;
		location = new Point(4, 25);
		obj115.Location = location;
		((Control)tabDicRex).Name = "tabDicRex";
		TabPage obj116 = tabDicRex;
		((Padding)(ref padding))._002Ector(3);
		((Control)obj116).Padding = padding;
		TabPage obj117 = tabDicRex;
		size = new Size(801, 349);
		((Control)obj117).Size = size;
		tabDicRex.TabIndex = 1;
		tabDicRex.Text = "Dic/Rex";
		tabDicRex.UseVisualStyleBackColor = true;
		splDicRec.Dock = (DockStyle)5;
		SplitContainer obj118 = splDicRec;
		location = new Point(3, 3);
		((Control)obj118).Location = location;
		((Control)splDicRec).Name = "splDicRec";
		splDicRec.Orientation = (Orientation)0;
		((Control)splDicRec.Panel1).Controls.Add((Control)(object)asDgvDic);
		((Control)splDicRec.Panel1).RightToLeft = (RightToLeft)0;
		((Control)splDicRec.Panel2).Controls.Add((Control)(object)asDgvDicRex);
		((Control)splDicRec.Panel2).RightToLeft = (RightToLeft)0;
		SplitContainer obj119 = splDicRec;
		size = new Size(795, 343);
		((Control)obj119).Size = size;
		splDicRec.SplitterDistance = 175;
		((Control)splDicRec).TabIndex = 1;
		((DataGridView)asDgvDic).AllowUserToAddRows = false;
		((DataGridView)asDgvDic).AllowUserToDeleteRows = false;
		val19.BackColor = Color.AliceBlue;
		((DataGridView)asDgvDic).AlternatingRowsDefaultCellStyle = val19;
		((DataGridView)asDgvDic).BackgroundColor = Color.White;
		((DataGridView)asDgvDic).BorderStyle = (BorderStyle)2;
		val20.Alignment = (DataGridViewContentAlignment)16;
		val20.BackColor = SystemColors.Control;
		val20.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val20.ForeColor = SystemColors.WindowText;
		val20.SelectionBackColor = SystemColors.Highlight;
		val20.SelectionForeColor = SystemColors.HighlightText;
		val20.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvDic).ColumnHeadersDefaultCellStyle = val20;
		((DataGridView)asDgvDic).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val21.Alignment = (DataGridViewContentAlignment)16;
		val21.BackColor = SystemColors.Window;
		val21.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val21.ForeColor = SystemColors.ControlText;
		val21.SelectionBackColor = SystemColors.Highlight;
		val21.SelectionForeColor = SystemColors.HighlightText;
		val21.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDgvDic).DefaultCellStyle = val21;
		((Control)asDgvDic).Dock = (DockStyle)5;
		asDgvDic.DoubleBuffered = false;
		((DataGridView)asDgvDic).EditMode = (DataGridViewEditMode)1;
		asDgvDic.EnabledExport2Excel = true;
		((DataGridView)asDgvDic).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView11 = asDgvDic;
		location = new Point(0, 0);
		((Control)asDataGridView11).Location = location;
		((DataGridView)asDgvDic).MultiSelect = false;
		((Control)asDgvDic).Name = "asDgvDic";
		val22.Alignment = (DataGridViewContentAlignment)32;
		val22.BackColor = SystemColors.Control;
		val22.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val22.ForeColor = SystemColors.WindowText;
		val22.SelectionBackColor = SystemColors.Highlight;
		val22.SelectionForeColor = SystemColors.HighlightText;
		val22.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvDic).RowHeadersDefaultCellStyle = val22;
		asDgvDic.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDgvDic).RowTemplate.Height = 20;
		AsDataGridView asDataGridView12 = asDgvDic;
		size = new Size(795, 175);
		((Control)asDataGridView12).Size = size;
		((Control)asDgvDic).TabIndex = 0;
		((DataGridView)asDgvDicRex).AllowUserToAddRows = false;
		((DataGridView)asDgvDicRex).AllowUserToDeleteRows = false;
		val23.BackColor = Color.AliceBlue;
		((DataGridView)asDgvDicRex).AlternatingRowsDefaultCellStyle = val23;
		((DataGridView)asDgvDicRex).BackgroundColor = Color.White;
		((DataGridView)asDgvDicRex).BorderStyle = (BorderStyle)2;
		val24.Alignment = (DataGridViewContentAlignment)16;
		val24.BackColor = SystemColors.Control;
		val24.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val24.ForeColor = SystemColors.WindowText;
		val24.SelectionBackColor = SystemColors.Highlight;
		val24.SelectionForeColor = SystemColors.HighlightText;
		val24.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvDicRex).ColumnHeadersDefaultCellStyle = val24;
		((DataGridView)asDgvDicRex).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val25.Alignment = (DataGridViewContentAlignment)16;
		val25.BackColor = SystemColors.Window;
		val25.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val25.ForeColor = SystemColors.ControlText;
		val25.SelectionBackColor = SystemColors.Highlight;
		val25.SelectionForeColor = SystemColors.HighlightText;
		val25.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDgvDicRex).DefaultCellStyle = val25;
		((Control)asDgvDicRex).Dock = (DockStyle)5;
		asDgvDicRex.DoubleBuffered = false;
		((DataGridView)asDgvDicRex).EditMode = (DataGridViewEditMode)1;
		((DataGridView)asDgvDicRex).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView13 = asDgvDicRex;
		location = new Point(0, 0);
		((Control)asDataGridView13).Location = location;
		((Control)asDgvDicRex).Name = "asDgvDicRex";
		val26.Alignment = (DataGridViewContentAlignment)32;
		val26.BackColor = SystemColors.Control;
		val26.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val26.ForeColor = SystemColors.WindowText;
		val26.SelectionBackColor = SystemColors.Highlight;
		val26.SelectionForeColor = SystemColors.HighlightText;
		val26.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvDicRex).RowHeadersDefaultCellStyle = val26;
		asDgvDicRex.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDgvDicRex).RowTemplate.Height = 20;
		AsDataGridView asDataGridView14 = asDgvDicRex;
		size = new Size(795, 164);
		((Control)asDataGridView14).Size = size;
		((Control)asDgvDicRex).TabIndex = 0;
		((Control)tabRepRex).Controls.Add((Control)(object)splReports);
		TabPage obj120 = tabRepRex;
		location = new Point(4, 25);
		obj120.Location = location;
		((Control)tabRepRex).Name = "tabRepRex";
		TabPage obj121 = tabRepRex;
		size = new Size(801, 349);
		((Control)obj121).Size = size;
		tabRepRex.TabIndex = 2;
		tabRepRex.Text = "Rep/Rex";
		tabRepRex.UseVisualStyleBackColor = true;
		splReports.Dock = (DockStyle)5;
		SplitContainer obj122 = splReports;
		location = new Point(0, 0);
		((Control)obj122).Location = location;
		((Control)splReports).Name = "splReports";
		splReports.Orientation = (Orientation)0;
		((Control)splReports.Panel1).Controls.Add((Control)(object)asDgvReport);
		((Control)splReports.Panel1).RightToLeft = (RightToLeft)0;
		((Control)splReports.Panel2).Controls.Add((Control)(object)asDgvReportRex);
		((Control)splReports.Panel2).RightToLeft = (RightToLeft)0;
		SplitContainer obj123 = splReports;
		size = new Size(801, 349);
		((Control)obj123).Size = size;
		splReports.SplitterDistance = 168;
		((Control)splReports).TabIndex = 2;
		((DataGridView)asDgvReport).AllowUserToAddRows = false;
		((DataGridView)asDgvReport).AllowUserToDeleteRows = false;
		val27.BackColor = Color.AliceBlue;
		((DataGridView)asDgvReport).AlternatingRowsDefaultCellStyle = val27;
		((DataGridView)asDgvReport).BackgroundColor = Color.White;
		((DataGridView)asDgvReport).BorderStyle = (BorderStyle)2;
		val28.Alignment = (DataGridViewContentAlignment)16;
		val28.BackColor = SystemColors.Control;
		val28.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val28.ForeColor = SystemColors.WindowText;
		val28.SelectionBackColor = SystemColors.Highlight;
		val28.SelectionForeColor = SystemColors.HighlightText;
		val28.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvReport).ColumnHeadersDefaultCellStyle = val28;
		((DataGridView)asDgvReport).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val29.Alignment = (DataGridViewContentAlignment)16;
		val29.BackColor = SystemColors.Window;
		val29.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val29.ForeColor = SystemColors.ControlText;
		val29.SelectionBackColor = SystemColors.Highlight;
		val29.SelectionForeColor = SystemColors.HighlightText;
		val29.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDgvReport).DefaultCellStyle = val29;
		((Control)asDgvReport).Dock = (DockStyle)5;
		asDgvReport.DoubleBuffered = false;
		((DataGridView)asDgvReport).EditMode = (DataGridViewEditMode)1;
		((DataGridView)asDgvReport).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView15 = asDgvReport;
		location = new Point(0, 0);
		((Control)asDataGridView15).Location = location;
		((DataGridView)asDgvReport).MultiSelect = false;
		((Control)asDgvReport).Name = "asDgvReport";
		val30.Alignment = (DataGridViewContentAlignment)32;
		val30.BackColor = SystemColors.Control;
		val30.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val30.ForeColor = SystemColors.WindowText;
		val30.SelectionBackColor = SystemColors.Highlight;
		val30.SelectionForeColor = SystemColors.HighlightText;
		val30.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvReport).RowHeadersDefaultCellStyle = val30;
		asDgvReport.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDgvReport).RowTemplate.Height = 20;
		AsDataGridView asDataGridView16 = asDgvReport;
		size = new Size(801, 168);
		((Control)asDataGridView16).Size = size;
		((Control)asDgvReport).TabIndex = 0;
		((DataGridView)asDgvReportRex).AllowUserToAddRows = false;
		((DataGridView)asDgvReportRex).AllowUserToDeleteRows = false;
		val31.BackColor = Color.AliceBlue;
		((DataGridView)asDgvReportRex).AlternatingRowsDefaultCellStyle = val31;
		((DataGridView)asDgvReportRex).BackgroundColor = Color.White;
		((DataGridView)asDgvReportRex).BorderStyle = (BorderStyle)2;
		val32.Alignment = (DataGridViewContentAlignment)16;
		val32.BackColor = SystemColors.Control;
		val32.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val32.ForeColor = SystemColors.WindowText;
		val32.SelectionBackColor = SystemColors.Highlight;
		val32.SelectionForeColor = SystemColors.HighlightText;
		val32.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvReportRex).ColumnHeadersDefaultCellStyle = val32;
		((DataGridView)asDgvReportRex).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val33.Alignment = (DataGridViewContentAlignment)16;
		val33.BackColor = SystemColors.Window;
		val33.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val33.ForeColor = SystemColors.ControlText;
		val33.SelectionBackColor = SystemColors.Highlight;
		val33.SelectionForeColor = SystemColors.HighlightText;
		val33.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDgvReportRex).DefaultCellStyle = val33;
		((Control)asDgvReportRex).Dock = (DockStyle)5;
		asDgvReportRex.DoubleBuffered = false;
		((DataGridView)asDgvReportRex).EditMode = (DataGridViewEditMode)1;
		((DataGridView)asDgvReportRex).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView17 = asDgvReportRex;
		location = new Point(0, 0);
		((Control)asDataGridView17).Location = location;
		((Control)asDgvReportRex).Name = "asDgvReportRex";
		val34.Alignment = (DataGridViewContentAlignment)32;
		val34.BackColor = SystemColors.Control;
		val34.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val34.ForeColor = SystemColors.WindowText;
		val34.SelectionBackColor = SystemColors.Highlight;
		val34.SelectionForeColor = SystemColors.HighlightText;
		val34.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvReportRex).RowHeadersDefaultCellStyle = val34;
		asDgvReportRex.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDgvReportRex).RowTemplate.Height = 20;
		AsDataGridView asDataGridView18 = asDgvReportRex;
		size = new Size(801, 177);
		((Control)asDataGridView18).Size = size;
		((Control)asDgvReportRex).TabIndex = 1;
		((Control)tabRepDrillDown).Controls.Add((Control)(object)asdgvReportDrillDown);
		TabPage obj124 = tabRepDrillDown;
		location = new Point(4, 25);
		obj124.Location = location;
		((Control)tabRepDrillDown).Name = "tabRepDrillDown";
		TabPage obj125 = tabRepDrillDown;
		((Padding)(ref padding))._002Ector(3);
		((Control)obj125).Padding = padding;
		TabPage obj126 = tabRepDrillDown;
		size = new Size(801, 349);
		((Control)obj126).Size = size;
		tabRepDrillDown.TabIndex = 5;
		tabRepDrillDown.Text = "RepDrillDown";
		tabRepDrillDown.UseVisualStyleBackColor = true;
		((DataGridView)asdgvReportDrillDown).AllowUserToAddRows = false;
		((DataGridView)asdgvReportDrillDown).AllowUserToDeleteRows = false;
		val35.BackColor = Color.AliceBlue;
		((DataGridView)asdgvReportDrillDown).AlternatingRowsDefaultCellStyle = val35;
		((DataGridView)asdgvReportDrillDown).BackgroundColor = Color.White;
		((DataGridView)asdgvReportDrillDown).BorderStyle = (BorderStyle)2;
		val36.Alignment = (DataGridViewContentAlignment)16;
		val36.BackColor = SystemColors.Control;
		val36.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val36.ForeColor = SystemColors.WindowText;
		val36.SelectionBackColor = SystemColors.Highlight;
		val36.SelectionForeColor = SystemColors.HighlightText;
		val36.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asdgvReportDrillDown).ColumnHeadersDefaultCellStyle = val36;
		((DataGridView)asdgvReportDrillDown).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val37.Alignment = (DataGridViewContentAlignment)16;
		val37.BackColor = SystemColors.Window;
		val37.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val37.ForeColor = SystemColors.ControlText;
		val37.SelectionBackColor = SystemColors.Highlight;
		val37.SelectionForeColor = SystemColors.HighlightText;
		val37.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asdgvReportDrillDown).DefaultCellStyle = val37;
		((Control)asdgvReportDrillDown).Dock = (DockStyle)5;
		asdgvReportDrillDown.DoubleBuffered = false;
		((DataGridView)asdgvReportDrillDown).EditMode = (DataGridViewEditMode)1;
		asdgvReportDrillDown.EnabledExport2Excel = true;
		((DataGridView)asdgvReportDrillDown).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView19 = asdgvReportDrillDown;
		location = new Point(3, 3);
		((Control)asDataGridView19).Location = location;
		((Control)asdgvReportDrillDown).Name = "asdgvReportDrillDown";
		val38.Alignment = (DataGridViewContentAlignment)32;
		val38.BackColor = SystemColors.Control;
		val38.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val38.ForeColor = SystemColors.WindowText;
		val38.SelectionBackColor = SystemColors.Highlight;
		val38.SelectionForeColor = SystemColors.HighlightText;
		val38.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asdgvReportDrillDown).RowHeadersDefaultCellStyle = val38;
		asdgvReportDrillDown.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asdgvReportDrillDown).RowTemplate.Height = 20;
		AsDataGridView asDataGridView20 = asdgvReportDrillDown;
		size = new Size(795, 343);
		((Control)asDataGridView20).Size = size;
		((Control)asdgvReportDrillDown).TabIndex = 1;
		((Control)tabVoucher).Controls.Add((Control)(object)SplVoucher);
		TabPage obj127 = tabVoucher;
		location = new Point(4, 25);
		obj127.Location = location;
		((Control)tabVoucher).Name = "tabVoucher";
		TabPage obj128 = tabVoucher;
		size = new Size(801, 349);
		((Control)obj128).Size = size;
		tabVoucher.TabIndex = 4;
		tabVoucher.Text = "Vou/Rex";
		tabVoucher.UseVisualStyleBackColor = true;
		SplVoucher.Dock = (DockStyle)5;
		SplitContainer splVoucher = SplVoucher;
		location = new Point(0, 0);
		((Control)splVoucher).Location = location;
		((Control)SplVoucher).Name = "SplVoucher";
		SplVoucher.Orientation = (Orientation)0;
		((Control)SplVoucher.Panel1).Controls.Add((Control)(object)asDgvVoucher);
		((Control)SplVoucher.Panel1).RightToLeft = (RightToLeft)0;
		((Control)SplVoucher.Panel2).Controls.Add((Control)(object)asDgvVoucherRex);
		((Control)SplVoucher.Panel2).RightToLeft = (RightToLeft)0;
		SplitContainer splVoucher2 = SplVoucher;
		size = new Size(801, 349);
		((Control)splVoucher2).Size = size;
		SplVoucher.SplitterDistance = 178;
		((Control)SplVoucher).TabIndex = 2;
		((DataGridView)asDgvVoucher).AllowUserToAddRows = false;
		((DataGridView)asDgvVoucher).AllowUserToDeleteRows = false;
		val39.BackColor = Color.AliceBlue;
		((DataGridView)asDgvVoucher).AlternatingRowsDefaultCellStyle = val39;
		((DataGridView)asDgvVoucher).BackgroundColor = Color.White;
		((DataGridView)asDgvVoucher).BorderStyle = (BorderStyle)2;
		val40.Alignment = (DataGridViewContentAlignment)16;
		val40.BackColor = SystemColors.Control;
		val40.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val40.ForeColor = SystemColors.WindowText;
		val40.SelectionBackColor = SystemColors.Highlight;
		val40.SelectionForeColor = SystemColors.HighlightText;
		val40.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvVoucher).ColumnHeadersDefaultCellStyle = val40;
		((DataGridView)asDgvVoucher).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val41.Alignment = (DataGridViewContentAlignment)16;
		val41.BackColor = SystemColors.Window;
		val41.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val41.ForeColor = SystemColors.ControlText;
		val41.SelectionBackColor = SystemColors.Highlight;
		val41.SelectionForeColor = SystemColors.HighlightText;
		val41.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDgvVoucher).DefaultCellStyle = val41;
		((Control)asDgvVoucher).Dock = (DockStyle)5;
		asDgvVoucher.DoubleBuffered = false;
		((DataGridView)asDgvVoucher).EditMode = (DataGridViewEditMode)1;
		((DataGridView)asDgvVoucher).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView21 = asDgvVoucher;
		location = new Point(0, 0);
		((Control)asDataGridView21).Location = location;
		((DataGridView)asDgvVoucher).MultiSelect = false;
		((Control)asDgvVoucher).Name = "asDgvVoucher";
		val42.Alignment = (DataGridViewContentAlignment)32;
		val42.BackColor = SystemColors.Control;
		val42.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val42.ForeColor = SystemColors.WindowText;
		val42.SelectionBackColor = SystemColors.Highlight;
		val42.SelectionForeColor = SystemColors.HighlightText;
		val42.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvVoucher).RowHeadersDefaultCellStyle = val42;
		asDgvVoucher.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDgvVoucher).RowTemplate.Height = 20;
		AsDataGridView asDataGridView22 = asDgvVoucher;
		size = new Size(801, 178);
		((Control)asDataGridView22).Size = size;
		((Control)asDgvVoucher).TabIndex = 0;
		((DataGridView)asDgvVoucherRex).AllowUserToAddRows = false;
		((DataGridView)asDgvVoucherRex).AllowUserToDeleteRows = false;
		val43.BackColor = Color.AliceBlue;
		((DataGridView)asDgvVoucherRex).AlternatingRowsDefaultCellStyle = val43;
		((DataGridView)asDgvVoucherRex).BackgroundColor = Color.White;
		((DataGridView)asDgvVoucherRex).BorderStyle = (BorderStyle)2;
		val44.Alignment = (DataGridViewContentAlignment)16;
		val44.BackColor = SystemColors.Control;
		val44.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val44.ForeColor = SystemColors.WindowText;
		val44.SelectionBackColor = SystemColors.Highlight;
		val44.SelectionForeColor = SystemColors.HighlightText;
		val44.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvVoucherRex).ColumnHeadersDefaultCellStyle = val44;
		((DataGridView)asDgvVoucherRex).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val45.Alignment = (DataGridViewContentAlignment)16;
		val45.BackColor = SystemColors.Window;
		val45.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val45.ForeColor = SystemColors.ControlText;
		val45.SelectionBackColor = SystemColors.Highlight;
		val45.SelectionForeColor = SystemColors.HighlightText;
		val45.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDgvVoucherRex).DefaultCellStyle = val45;
		((Control)asDgvVoucherRex).Dock = (DockStyle)5;
		asDgvVoucherRex.DoubleBuffered = false;
		((DataGridView)asDgvVoucherRex).EditMode = (DataGridViewEditMode)3;
		((DataGridView)asDgvVoucherRex).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView23 = asDgvVoucherRex;
		location = new Point(0, 0);
		((Control)asDataGridView23).Location = location;
		((Control)asDgvVoucherRex).Name = "asDgvVoucherRex";
		val46.Alignment = (DataGridViewContentAlignment)32;
		val46.BackColor = SystemColors.Control;
		val46.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val46.ForeColor = SystemColors.WindowText;
		val46.SelectionBackColor = SystemColors.Highlight;
		val46.SelectionForeColor = SystemColors.HighlightText;
		val46.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvVoucherRex).RowHeadersDefaultCellStyle = val46;
		asDgvVoucherRex.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDgvVoucherRex).RowTemplate.Height = 20;
		AsDataGridView asDataGridView24 = asDgvVoucherRex;
		size = new Size(801, 167);
		((Control)asDataGridView24).Size = size;
		((Control)asDgvVoucherRex).TabIndex = 1;
		((Control)tabDaoInfo).Controls.Add((Control)(object)asDgvDaoInfo);
		TabPage obj129 = tabDaoInfo;
		location = new Point(4, 25);
		obj129.Location = location;
		((Control)tabDaoInfo).Name = "tabDaoInfo";
		TabPage obj130 = tabDaoInfo;
		((Padding)(ref padding))._002Ector(3);
		((Control)obj130).Padding = padding;
		TabPage obj131 = tabDaoInfo;
		size = new Size(801, 349);
		((Control)obj131).Size = size;
		tabDaoInfo.TabIndex = 3;
		tabDaoInfo.Text = "DAOINFO";
		tabDaoInfo.UseVisualStyleBackColor = true;
		((DataGridView)asDgvDaoInfo).AllowUserToAddRows = false;
		((DataGridView)asDgvDaoInfo).AllowUserToDeleteRows = false;
		val47.BackColor = Color.AliceBlue;
		((DataGridView)asDgvDaoInfo).AlternatingRowsDefaultCellStyle = val47;
		((DataGridView)asDgvDaoInfo).BackgroundColor = Color.White;
		((DataGridView)asDgvDaoInfo).BorderStyle = (BorderStyle)2;
		val48.Alignment = (DataGridViewContentAlignment)16;
		val48.BackColor = SystemColors.Control;
		val48.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val48.ForeColor = SystemColors.WindowText;
		val48.SelectionBackColor = SystemColors.Highlight;
		val48.SelectionForeColor = SystemColors.HighlightText;
		val48.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvDaoInfo).ColumnHeadersDefaultCellStyle = val48;
		((DataGridView)asDgvDaoInfo).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		val49.Alignment = (DataGridViewContentAlignment)16;
		val49.BackColor = SystemColors.Window;
		val49.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val49.ForeColor = SystemColors.ControlText;
		val49.SelectionBackColor = SystemColors.Highlight;
		val49.SelectionForeColor = SystemColors.HighlightText;
		val49.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDgvDaoInfo).DefaultCellStyle = val49;
		((Control)asDgvDaoInfo).Dock = (DockStyle)5;
		asDgvDaoInfo.DoubleBuffered = false;
		((DataGridView)asDgvDaoInfo).EditMode = (DataGridViewEditMode)1;
		asDgvDaoInfo.EnabledExport2Excel = true;
		((DataGridView)asDgvDaoInfo).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView25 = asDgvDaoInfo;
		location = new Point(3, 3);
		((Control)asDataGridView25).Location = location;
		((Control)asDgvDaoInfo).Name = "asDgvDaoInfo";
		val50.Alignment = (DataGridViewContentAlignment)32;
		val50.BackColor = SystemColors.Control;
		val50.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val50.ForeColor = SystemColors.WindowText;
		val50.SelectionBackColor = SystemColors.Highlight;
		val50.SelectionForeColor = SystemColors.HighlightText;
		val50.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDgvDaoInfo).RowHeadersDefaultCellStyle = val50;
		asDgvDaoInfo.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDgvDaoInfo).RowTemplate.Height = 20;
		AsDataGridView asDataGridView26 = asDgvDaoInfo;
		size = new Size(795, 343);
		((Control)asDataGridView26).Size = size;
		((Control)asDgvDaoInfo).TabIndex = 0;
		TT_Grid.AutomaticDelay = 100;
		TT_Grid.AutoPopDelay = 1000;
		TT_Grid.InitialDelay = 200;
		TT_Grid.IsBalloon = true;
		TT_Grid.ReshowDelay = 10;
		TT_Grid.ToolTipIcon = (ToolTipIcon)1;
		fbdPath.Description = "Cập nhật phiên bản mới từ thư mục :";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(823, 452);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)tabTools);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Control)this).Name = "frmMainTools";
		((Control)this).Tag = "0";
		((Form)this).Text = "AsiaTools - Can sao luu du lieu truoc khi thuc hien ";
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)ctMenuTool).ResumeLayout(false);
		((Control)tabTools).ResumeLayout(false);
		((Control)tabInterface).ResumeLayout(false);
		((Control)tabInterface).PerformLayout();
		((ISupportInitialize)asdgvClientConfig).EndInit();
		((Control)tabComanyInfo).ResumeLayout(false);
		((ISupportInitialize)asDgvCompanyInfo).EndInit();
		((Control)tabExcProc).ResumeLayout(false);
		((Control)splExeSP.Panel1).ResumeLayout(false);
		((Control)splExeSP.Panel2).ResumeLayout(false);
		((Control)splExeSP).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)splInfo.Panel1).ResumeLayout(false);
		((Control)splInfo.Panel2).ResumeLayout(false);
		((Control)splInfo).ResumeLayout(false);
		((ISupportInitialize)asdgvStoreProc).EndInit();
		((ISupportInitialize)asdgvParameter).EndInit();
		((ISupportInitialize)asDgvResult).EndInit();
		((Control)tabMenu).ResumeLayout(false);
		((Control)tabMenuAll).ResumeLayout(false);
		((Control)tabListMenu).ResumeLayout(false);
		((ISupportInitialize)asDgvMenu).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)tabDicRex).ResumeLayout(false);
		((Control)splDicRec.Panel1).ResumeLayout(false);
		((Control)splDicRec.Panel2).ResumeLayout(false);
		((Control)splDicRec).ResumeLayout(false);
		((ISupportInitialize)asDgvDic).EndInit();
		((ISupportInitialize)asDgvDicRex).EndInit();
		((Control)tabRepRex).ResumeLayout(false);
		((Control)splReports.Panel1).ResumeLayout(false);
		((Control)splReports.Panel2).ResumeLayout(false);
		((Control)splReports).ResumeLayout(false);
		((ISupportInitialize)asDgvReport).EndInit();
		((ISupportInitialize)asDgvReportRex).EndInit();
		((Control)tabRepDrillDown).ResumeLayout(false);
		((ISupportInitialize)asdgvReportDrillDown).EndInit();
		((Control)tabVoucher).ResumeLayout(false);
		((Control)SplVoucher.Panel1).ResumeLayout(false);
		((Control)SplVoucher.Panel2).ResumeLayout(false);
		((Control)SplVoucher).ResumeLayout(false);
		((ISupportInitialize)asDgvVoucher).EndInit();
		((ISupportInitialize)asDgvVoucherRex).EndInit();
		((Control)tabDaoInfo).ResumeLayout(false);
		((ISupportInitialize)asDgvDaoInfo).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmMainTools_Shown(object sender, EventArgs e)
	{
		if (_isClose)
		{
			((Form)this).Close();
		}
	}

	private void frmMainTools_Load(object sender, EventArgs e)
	{
		_isLoading = true;
		if ((tabTools.SelectedIndex == 0) | (tabTools.SelectedIndex == 1))
		{
			((Control)btnSave).Enabled = true;
		}
		else
		{
			((Control)btnSave).Enabled = false;
		}
		InitData();
		InitClientConfig();
		cmbTranfer.SelectedIndex = 2;
		AddEvent();
		_isLoading = false;
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		try
		{
			int selectedIndex = tabTools.SelectedIndex;
			if (Operators.ConditionalCompareObjectEqual((object)selectedIndex, Operators.SubtractObject((object)0, Interaction.IIf(((Control)tabTools).Contains((Control)(object)tabInterface), (object)0, (object)1)), false))
			{
				ProcessClientConfig();
			}
			else if (Operators.ConditionalCompareObjectEqual((object)selectedIndex, Operators.SubtractObject((object)1, Interaction.IIf(((Control)tabTools).Contains((Control)(object)tabInterface), (object)0, (object)1)), false))
			{
				UpdateDBCompany();
			}
			else if (Operators.ConditionalCompareObjectEqual((object)selectedIndex, Operators.SubtractObject((object)2, Interaction.IIf(((Control)tabTools).Contains((Control)(object)tabInterface), (object)0, (object)1)), false))
			{
				splExeSP.Panel2Collapsed = false;
				ExcSP();
			}
			else if (Operators.ConditionalCompareObjectEqual((object)selectedIndex, Operators.SubtractObject((object)3, Interaction.IIf(((Control)tabTools).Contains((Control)(object)tabInterface), (object)0, (object)1)), false))
			{
				UpdateDB(ref f_dtAllMenu, 1, 2);
				UpdateDB(ref f_dtDic, 3, 4);
				UpdateDB(ref f_dtDicRex, 5, 6);
				UpdateDB(ref f_dtReport, 7, 8);
				UpdateDB(ref f_dtReportRex, 9, 10);
				UpdateDB(ref f_dtReportRex, 9, 10);
				UpdateDB(ref f_dtVoucher, 11, 12);
				UpdateDB(ref f_dtVoucherRex, 13, 14);
				UpdateDB(ref f_dtDaoInfo, 15, 16);
				UpdateDB(ref f_dtReportDrillDown, 17, 18);
			}
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
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
		if ((int)e.KeyCode == 13)
		{
			((Form)this).ProcessTabKey(true);
		}
		if (((e.Shift && (int)e.KeyCode == 82) ? true : false) && tabTools.SelectedTab == tabExcProc)
		{
			if (((Control)asdgvStoreProc).Focused | ((Control)asdgvParameter).Focused)
			{
				splExeSP.Panel2Collapsed = !splExeSP.Panel2Collapsed;
			}
			else
			{
				splExeSP.Panel1Collapsed = !splExeSP.Panel1Collapsed;
			}
		}
		if ((e.Control && (int)e.KeyCode == 82) ? true : false)
		{
			((ToolStripItem)RestartToolStripMenuItem).PerformClick();
		}
	}

	private void tabTools_Selecting(object sender, TabControlCancelEventArgs e)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (tabTools.SelectedIndex != 0 && !checkRight)
		{
			frmPassword frmPassword = new frmPassword();
			frmPassword.CompanyId = CompanyInformations.CompanyID;
			frmPassword.UserName = SystemInformations.UserName;
			((Form)frmPassword).ShowDialog();
			if (!frmPassword.is_ok)
			{
				checkRight = frmPassword.is_ok;
				((CancelEventArgs)(object)e).Cancel = true;
			}
			else
			{
				checkRight = frmPassword.is_ok;
			}
		}
	}

	private void tabTools_SelectedIndexChanged(object sender, EventArgs e)
	{
		switch (tabTools.SelectedIndex)
		{
		case 0:
			((ButtonBase)btnSave).Text = "&Lưu";
			((Control)btnSave).Enabled = true;
			((Control)btnExcute).Visible = false;
			break;
		case 1:
			((ButtonBase)btnSave).Text = "&Lưu";
			((Control)btnSave).Enabled = true;
			((Control)btnExcute).Visible = true;
			((ButtonBase)btnExcute).Text = "Tạo mới cty";
			break;
		case 2:
			((ButtonBase)btnSave).Text = "&Exec";
			((Control)btnSave).Enabled = true;
			((Control)btnExcute).Visible = false;
			break;
		case 3:
			((ButtonBase)btnSave).Text = "&Lưu";
			((Control)btnSave).Enabled = true;
			((Control)btnExcute).Visible = false;
			break;
		default:
			((ButtonBase)btnSave).Text = "&Lưu";
			((Control)btnExcute).Visible = false;
			break;
		}
	}

	private void btnCreateCompany_Click(object sender, EventArgs e)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		int selectedIndex = tabTools.SelectedIndex;
		if (selectedIndex == 1)
		{
			frmCreateCompany frmCreateCompany2 = new frmCreateCompany();
			frmCreateCompany2.f_dt = f_dtCompany;
			frmCreateCompany2.cmbListCompany.DataSource = f_dtCompany.DefaultView;
			((ListControl)frmCreateCompany2.cmbListCompany).ValueMember = "ma_cty";
			((ListControl)frmCreateCompany2.cmbListCompany).DisplayMember = "ten_cty1";
			frmCreateCompany2.MyMenuInfo = MyMenuInfo;
			((Form)frmCreateCompany2).ShowDialog();
		}
	}

	private void InitData()
	{
		GetCompanyInfo();
		getDmExcProc();
		GetAllMenuInfo();
		GetAllSys();
	}

	private void AddEvent()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		((DataGridView)asDgvMenu).DataError += new DataGridViewDataErrorEventHandler(asDgv_DataError);
		((DataGridView)asDgvDic).DataError += new DataGridViewDataErrorEventHandler(asDgv_DataError);
		((DataGridView)asDgvDicRex).DataError += new DataGridViewDataErrorEventHandler(asDgv_DataError);
		((DataGridView)asDgvReport).DataError += new DataGridViewDataErrorEventHandler(asDgv_DataError);
		((DataGridView)asDgvReportRex).DataError += new DataGridViewDataErrorEventHandler(asDgv_DataError);
		((DataGridView)asdgvReportDrillDown).DataError += new DataGridViewDataErrorEventHandler(asDgv_DataError);
		((DataGridView)asDgvVoucher).DataError += new DataGridViewDataErrorEventHandler(asDgv_DataError);
		((DataGridView)asDgvVoucherRex).DataError += new DataGridViewDataErrorEventHandler(asDgv_DataError);
		((DataGridView)asDgvDaoInfo).DataError += new DataGridViewDataErrorEventHandler(asDgv_DataError);
	}

	private void F5asDgvMenu(bool is_F5)
	{
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		string filterExpression = "menuid= '" + ((DataGridView)asDgvMenu).CurrentRow.Cells["menuid"].Value.ToString() + "'";
		switch (cmbTranfer.Text.Substring(0, 1))
		{
		case "0":
		{
			int num2 = 0;
			DataRow[] array2 = ((DataView)asDgvDic.DataSource).Table.Select(filterExpression);
			foreach (DataRow row2 in array2)
			{
				num2 = ((DataView)asDgvDic.DataSource).Table.Rows.IndexOf(row2);
			}
			if (is_F5)
			{
				if (f_dtDic.Select(filterExpression).Any())
				{
					tabMenuAll.SelectTab(tabDicRex);
					((Control)asDgvDic).Focus();
					((DataGridView)asDgvDic).CurrentCell = ((DataGridView)asDgvDic)[0, num2];
					((DataGridView)asDgvDic).CurrentRow.Selected = true;
				}
				else
				{
					CMessageBox.Show(50016);
				}
			}
			break;
		}
		case "1":
		{
			int num3 = 0;
			DataRow[] array3 = ((DataView)asDgvReport.DataSource).Table.Select(filterExpression);
			foreach (DataRow row3 in array3)
			{
				num3 = ((DataView)asDgvReport.DataSource).Table.Rows.IndexOf(row3);
			}
			if (is_F5)
			{
				if (f_dtReport.Select(filterExpression).Any())
				{
					tabMenuAll.SelectTab(tabRepRex);
					((Control)asDgvReport).Focus();
					((DataGridView)asDgvReport).CurrentCell = ((DataGridView)asDgvReport)[0, num3];
					((DataGridView)asDgvReport).CurrentRow.Selected = true;
				}
				else
				{
					CMessageBox.Show(50016);
				}
			}
			break;
		}
		case "2":
		{
			int num = 0;
			DataRow[] array = ((DataView)asDgvVoucher.DataSource).Table.Select(filterExpression);
			foreach (DataRow row in array)
			{
				num = ((DataView)asDgvVoucher.DataSource).Table.Rows.IndexOf(row);
			}
			if (is_F5)
			{
				if (f_dtVoucher.Select(filterExpression).Any())
				{
					tabMenuAll.SelectTab(tabVoucher);
					((Control)asDgvVoucher).Focus();
					((DataGridView)asDgvVoucher).CurrentCell = ((DataGridView)asDgvVoucher)[0, num];
					((DataGridView)asDgvVoucher).CurrentRow.Selected = true;
				}
				else
				{
					CMessageBox.Show(50016);
				}
			}
			break;
		}
		}
	}

	private void F5asDgvDic(bool is_F5)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		string filterExpression = "table_name= '" + ((DataGridView)asDgvDic).CurrentRow.Cells["table_name"].Value.ToString() + "'";
		int num = 0;
		DataRow[] array = ((DataView)asDgvDaoInfo.DataSource).Table.Select(filterExpression);
		foreach (DataRow row in array)
		{
			num = ((DataView)asDgvDaoInfo.DataSource).Table.Rows.IndexOf(row);
		}
		if (is_F5)
		{
			if (f_dtDaoInfo.Select(filterExpression).Any())
			{
				tabMenuAll.SelectTab(tabDaoInfo);
				((Control)asDgvDaoInfo).Focus();
				((DataGridView)asDgvDaoInfo).CurrentCell = ((DataGridView)asDgvDaoInfo)[0, num];
				((DataGridView)asDgvDaoInfo).CurrentRow.Selected = true;
			}
			else
			{
				CMessageBox.Show(50016);
			}
		}
	}

	private void F5asDgvReport(bool is_F5)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		string filterExpression = "menuid= '" + ((DataGridView)asDgvReport).CurrentRow.Cells["menuid"].Value.ToString() + "'";
		int num = 0;
		DataRow[] array = ((DataView)asdgvReportDrillDown.DataSource).Table.Select(filterExpression);
		foreach (DataRow row in array)
		{
			num = ((DataView)asdgvReportDrillDown.DataSource).Table.Rows.IndexOf(row);
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

	private void F5asDgvVoucher(bool is_F5)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		string filterExpression = "table_name= '" + ((DataGridView)asDgvVoucher).CurrentRow.Cells["ph_table_name"].Value.ToString() + "'";
		int num = 0;
		DataRow[] array = ((DataView)asDgvDaoInfo.DataSource).Table.Select(filterExpression);
		foreach (DataRow row in array)
		{
			num = ((DataView)asDgvDaoInfo.DataSource).Table.Rows.IndexOf(row);
		}
		if (is_F5)
		{
			if (f_dtDaoInfo.Select(filterExpression).Any())
			{
				tabMenuAll.SelectTab(tabDaoInfo);
				((Control)asDgvDaoInfo).Focus();
				((DataGridView)asDgvDaoInfo).CurrentCell = ((DataGridView)asDgvDaoInfo)[0, num];
				((DataGridView)asDgvDaoInfo).CurrentRow.Selected = true;
			}
			else
			{
				CMessageBox.Show(50016);
			}
		}
	}

	private void Gen_FielListDynReport()
	{
		if ((f_dtReport != null || ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvReport.DataSource)].Current != null) && 0 == 0)
		{
			((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvReport.DataSource)].EndCurrentEdit();
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools");
			DataRow dataRow = (DataRow)NewLateBinding.LateGet(((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvReport.DataSource)].Current, (Type)null, "row", new object[0], (string[])null, (Type[])null, (bool[])null);
			dataRow["DynReportFields"] = siToolsDao.Gen_FielListDynReport(Conversions.ToString(dataRow["Spname"]));
			((DataGridView)asDgvReport).InvalidateRow(((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvReport.DataSource)].Position);
		}
	}

	private void FormatGridView(DataTable dt, AsDataGridView asDgv)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		asDgv.DataSource = null;
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
						((DataGridViewColumn)val).Width = 250;
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
					((DataGridView)asDgv).Columns.Add((DataGridViewColumn)(object)val4);
				}
				else if ((Operators.CompareString(column.DataType.ToString(), "System.Numeric", false) == 0) | (Operators.CompareString(column.DataType.ToString(), "System.Decimal", false) == 0) | (Operators.CompareString(column.DataType.ToString(), "System.Int32", false) == 0))
				{
					DataGridViewAsTextNumericColumn dataGridViewAsTextNumericColumn = new DataGridViewAsTextNumericColumn();
					((DataGridViewColumn)dataGridViewAsTextNumericColumn).Name = column.ColumnName;
					((DataGridViewColumn)dataGridViewAsTextNumericColumn).DataPropertyName = column.ColumnName;
					((DataGridViewColumn)dataGridViewAsTextNumericColumn).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
					dataGridViewAsTextNumericColumn.SortMode = (DataGridViewColumnSortMode)0;
					((DataGridView)asDgv).Columns.Add((DataGridViewColumn)(object)dataGridViewAsTextNumericColumn);
				}
			}
			if (array != null)
			{
				dt.PrimaryKey = array;
			}
			asDgv.DataSource = dt.DefaultView;
		}
	}

	public bool GetCacheKey(string strKey, ref DataTable dt, AsDataGridView dgv)
	{
		dt = (DataTable)fCache.Cache.Get(strKey);
		if ((dt != null && dt.Rows.Count > 0) ? true : false)
		{
			FormatGridView(dt, dgv);
			return true;
		}
		return false;
	}

	private void InitClientConfig()
	{
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		DataColumn dataColumn = new DataColumn("Key", typeof(string));
		dataColumn.DefaultValue = "";
		DataColumn column = dataColumn;
		dataColumn = new DataColumn("Value", typeof(string));
		dataColumn.DefaultValue = "";
		DataColumn column2 = dataColumn;
		dataColumn = new DataColumn("Description", typeof(string));
		dataColumn.DefaultValue = "";
		DataColumn column3 = dataColumn;
		f_dtClientSetting.Columns.Add(column);
		f_dtClientSetting.Columns.Add(column2);
		f_dtClientSetting.Columns.Add(column3);
		string[] source = new string[4] { "Field2CarryInReport", "AUTO_INSERT_DETAIL_OF_VOUCHER_WARNING_LEVEL", "LOGTYPE", "Name_Help" };
		string[] array = new string[4] { "Lưu lại thông tin điều kiện lọc", "Tự động hỏi thêm mới khi hết dòng", "Kiểu ghi Log", "Tên file help" };
		int num = 0;
		ClientConfig = ConfigurationManager.OpenExeConfiguration((ConfigurationUserLevel)0);
		foreach (KeyValueConfigurationElement item in (ConfigurationElementCollection)ClientConfig.AppSettings.Settings)
		{
			KeyValueConfigurationElement val = item;
			if (source.Contains(val.Key))
			{
				DataRow dataRow = f_dtClientSetting.NewRow();
				dataRow["Key"] = val.Key;
				dataRow["Value"] = val.Value;
				dataRow["Description"] = array[num];
				f_dtClientSetting.Rows.Add(dataRow);
				num = checked(num + 1);
			}
		}
		((DataGridView)asdgvClientConfig).DataSource = f_dtClientSetting.DefaultView;
		if (File.Exists(Application.StartupPath + "\\AsiaErpSync.exe"))
		{
			UpdateConfig = ConfigurationManager.OpenExeConfiguration(Application.StartupPath + "\\AsiaErpSync.exe");
			txtUpdatePatch.Text = UpdateConfig.AppSettings.Settings["UPDATE_PATH"].Value;
		}
	}

	private void ProcessClientConfig()
	{
		if (f_dtClientSetting == null)
		{
			return;
		}
		try
		{
			foreach (object row in f_dtClientSetting.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				ClientConfig.AppSettings.Settings[Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { "Key" }, (string[])null))].Value = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { "Value" }, (string[])null));
			}
			File.SetAttributes(ClientConfig.FilePath, FileAttributes.Archive);
			ClientConfig.Save((ConfigurationSaveMode)2);
			ConfigurationManager.RefreshSection("appSettings");
			File.SetAttributes(UpdateConfig.FilePath, FileAttributes.Archive);
			UpdateConfig.AppSettings.Settings["UPDATE_PATH"].Value = txtUpdatePatch.Text;
			UpdateConfig.Save((ConfigurationSaveMode)2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
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
		}
	}

	private void asDgvMenu_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Invalid comparison between Unknown and I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Invalid comparison between Unknown and I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Invalid comparison between Unknown and I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Invalid comparison between Unknown and I4
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Invalid comparison between Unknown and I4
		try
		{
			int num = Conversions.ToInteger(Helper.Repl_Null(((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvMenu.DataSource)].Position, isNum: true));
			if ((int)e.KeyCode == 115)
			{
				DataRow dataRow = f_dtAllMenu.NewRow();
				checked
				{
					if (num > 0)
					{
						DataRow row = f_dtAllMenu.DefaultView[num].Row;
						int num2 = row.Table.Columns.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							dataRow[num3] = RuntimeHelpers.GetObjectValue(row[num3]);
							num3++;
						}
					}
					dataRow["moduleid"] = RuntimeHelpers.GetObjectValue(((ListControl)cmbModule).SelectedValue);
					dataRow["stt"] = ((ListControl)cmbModuleFunc).SelectedValue.ToString().Substring(0, 5);
					dataRow["menuid"] = ((ListControl)cmbModuleFunc).SelectedValue.ToString().Substring(0, 5);
					f_dtAllMenu.Rows.InsertAt(dataRow, num + 1);
					((DataGridView)asDgvMenu).CurrentCell = ((DataGridView)asDgvMenu)[0, num + 1];
				}
			}
			if ((int)e.KeyCode == 119 && (int)CMessageBox.Show(50003, SystemInformations.ProductName, (MessageBoxButtons)4) == 6)
			{
				if (asDgvMenu.DataSource == null)
				{
					return;
				}
				ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools", a_blnIsSysDB: true);
				int position = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvMenu.DataSource)].Position;
				DataRowView dataRowView = f_dtAllMenu.DefaultView[position];
				DataTable dataTable = f_dtAllMenu.Clone();
				dataTable.ImportRow(dataRowView.Row);
				dataRowView.Delete();
				DataSet dataSet = new DataSet();
				dataSet.Tables.Add(dataTable);
				siToolsDao.DynInsertUpdateDeleteData(dataSet.GetXml(), f_dtAllMenu.TableName, "3", "menuid");
				siToolsDao.Destroy();
				dataSet.Dispose();
			}
			if ((int)e.KeyCode == 116)
			{
				F5asDgvMenu(is_F5: true);
			}
			if ((e.Control && (int)e.KeyCode == 67) ? true : false)
			{
				rowToCopy = (DataRow)NewLateBinding.LateGet(((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvMenu.DataSource)].Current, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null);
			}
			if (!e.Control || (int)e.KeyCode != 86 || 1 == 0)
			{
				return;
			}
			DataRow dataRow2 = (DataRow)NewLateBinding.LateGet(((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvMenu.DataSource)].Current, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null);
			foreach (DataColumn column in dataRow2.Table.Columns)
			{
				if (rowToCopy.Table.Columns.Contains(column.ColumnName))
				{
					dataRow2[column.ColumnName] = RuntimeHelpers.GetObjectValue(Interaction.IIf(f_dtAllMenu.PrimaryKey.Contains(column), RuntimeHelpers.GetObjectValue(dataRow2[column.ColumnName]), RuntimeHelpers.GetObjectValue(rowToCopy[column.ColumnName])));
					if (Operators.CompareString(column.ColumnName.ToUpper(), "MODULEID", false) == 0)
					{
						dataRow2[column.ColumnName] = RuntimeHelpers.GetObjectValue(((ListControl)cmbModule).SelectedValue);
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void asDgvDic_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Invalid comparison between Unknown and I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.KeyCode == 116)
		{
			F5asDgvDic(is_F5: true);
		}
		if ((int)e.KeyCode == 117)
		{
			string filterExpression = "menuid= '" + ((DataGridView)asDgvDic).CurrentRow.Cells["menuid"].Value.ToString() + "'";
			if (!f_dtAllMenu.Select(filterExpression).Any())
			{
				CMessageBox.Show(50016);
				return;
			}
			tabMenuAll.SelectTab(tabListMenu);
			int num = 0;
			DataRow[] array = ((DataView)asDgvMenu.DataSource).Table.Select(filterExpression);
			foreach (DataRow row in array)
			{
				num = ((DataView)asDgvMenu.DataSource).Table.Rows.IndexOf(row);
			}
			f_dtAllMenu.DefaultView.RowFilter = "";
			((Control)asDgvMenu).Focus();
			((DataGridView)asDgvMenu).CurrentCell = ((DataGridView)asDgvMenu)["STT", num];
			((DataGridView)asDgvMenu).CurrentRow.Selected = true;
		}
		if ((int)e.KeyCode == 119 && (int)CMessageBox.Show(50003, SystemInformations.ProductName, (MessageBoxButtons)4) == 6)
		{
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools", a_blnIsSysDB: true);
			int position = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvDic.DataSource)].Position;
			DataRowView dataRowView = f_dtDic.DefaultView[position];
			siToolsDao.SiDelDic(dataRowView.Row);
			DataRow[] array2 = f_dtDicRex.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"code_name='", dataRowView["code_name"]), (object)"'")));
			foreach (DataRow dataRow in array2)
			{
				siToolsDao.SiDelDicRex(dataRow);
				dataRow.Delete();
			}
			siToolsDao.Destroy();
			dataRowView.Delete();
			f_dtDic.AcceptChanges();
			f_dtDicRex.AcceptChanges();
		}
	}

	private void asDgvReport_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Invalid comparison between Unknown and I4
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Invalid comparison between Unknown and I4
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.KeyCode == 116)
		{
			F5asDgvReport(is_F5: true);
		}
		if ((int)e.KeyCode == 117)
		{
			string filterExpression = "menuid= '" + ((DataGridView)asDgvReport).CurrentRow.Cells["menuid"].Value.ToString() + "'";
			if (!f_dtAllMenu.Select(filterExpression).Any())
			{
				CMessageBox.Show(50016);
				return;
			}
			tabMenuAll.SelectTab(tabListMenu);
			int num = 0;
			DataRow[] array = ((DataView)asDgvMenu.DataSource).Table.Select(filterExpression);
			foreach (DataRow row in array)
			{
				num = ((DataView)asDgvMenu.DataSource).Table.Rows.IndexOf(row);
			}
			f_dtAllMenu.DefaultView.RowFilter = "";
			((Control)asDgvMenu).Focus();
			((DataGridView)asDgvMenu).CurrentCell = ((DataGridView)asDgvMenu)["STT", num];
			((DataGridView)asDgvMenu).CurrentRow.Selected = true;
		}
		if ((int)e.KeyCode == 115)
		{
			int position = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvReport.DataSource)].Position;
			int position2 = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvReportRex.DataSource)].Position;
			string text = "";
			DataRow dataRow = f_dtReport.NewRow();
			DataRow row2 = ((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvReport.DataSource)].Current).Row;
			dataRow["menuid"] = RuntimeHelpers.GetObjectValue(row2["menuid"]);
			checked
			{
				text = "0" + (int.Parse(Conversions.ToString(row2["ma_mau"])) + 1);
				dataRow["ma_mau"] = text.Substring(text.Length - 2);
				dataRow["Spname"] = RuntimeHelpers.GetObjectValue(row2["Spname"]);
				dataRow["rptname"] = RuntimeHelpers.GetObjectValue(row2["rptname"]);
				if (f_dtReport.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"menuid='", dataRow["menuid"]), (object)"' and ma_mau='"), dataRow["ma_mau"]), (object)"'"))).Any())
				{
					CMessageBox.Show(50011);
					return;
				}
				f_dtReport.Rows.InsertAt(dataRow, position + 1);
				DataRow dataRow2 = f_dtReportRex.NewRow();
				DataRow row3 = ((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvReportRex.DataSource)].Current).Row;
				dataRow2["menuid"] = RuntimeHelpers.GetObjectValue(row3["menuid"]);
				dataRow2["ma_mau"] = text.Substring(text.Length - 2);
				dataRow2["language"] = RuntimeHelpers.GetObjectValue(row3["language"]);
				f_dtReportRex.Rows.InsertAt(dataRow2, position2 + 1);
				((DataGridView)asDgvReport).CurrentCell = ((DataGridView)asDgvReport)[1, position + 1];
				((DataGridView)asDgvReportRex).CurrentCell = ((DataGridView)asDgvReportRex)[1, position2 + 1];
			}
		}
		if ((int)e.KeyCode == 119 && (int)CMessageBox.Show(50003, SystemInformations.ProductName, (MessageBoxButtons)4) == 6)
		{
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools", a_blnIsSysDB: true);
			int position3 = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvReport.DataSource)].Position;
			DataRowView dataRowView = f_dtReport.DefaultView[position3];
			siToolsDao.SiDelReport(dataRowView.Row);
			DataRow[] array2 = f_dtReportRex.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"menuid='", dataRowView["menuid"]), (object)"' and ma_mau="), (object)"'"), dataRowView["ma_mau"]), (object)"'")));
			foreach (DataRow dataRow3 in array2)
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

	private void asDgvVoucher_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Invalid comparison between Unknown and I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Invalid comparison between Unknown and I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.KeyCode == 116)
		{
			F5asDgvVoucher(is_F5: true);
		}
		if ((int)e.KeyCode == 117)
		{
			string filterExpression = "menuid= '" + ((DataGridView)asDgvVoucher).CurrentRow.Cells["menuid"].Value.ToString() + "'";
			if (!f_dtAllMenu.Select(filterExpression).Any())
			{
				CMessageBox.Show(50016);
				return;
			}
			tabMenuAll.SelectTab(tabListMenu);
			int num = 0;
			DataRow[] array = ((DataView)asDgvMenu.DataSource).Table.Select(filterExpression);
			foreach (DataRow row in array)
			{
				num = ((DataView)asDgvMenu.DataSource).Table.Rows.IndexOf(row);
			}
			f_dtAllMenu.DefaultView.RowFilter = "";
			((Control)asDgvMenu).Focus();
			((DataGridView)asDgvMenu).CurrentCell = ((DataGridView)asDgvMenu)["STT", num];
			((DataGridView)asDgvMenu).CurrentRow.Selected = true;
		}
		if ((e.Control && (int)e.KeyCode == 116) ? true : false)
		{
			string filterExpression2 = "table_name= '" + ((DataGridView)asDgvVoucher).CurrentRow.Cells["ct_table_name"].Value.ToString() + "'";
			if (!f_dtDaoInfo.Select(filterExpression2).Any())
			{
				CMessageBox.Show(50016);
				return;
			}
			tabMenuAll.SelectTab(tabDaoInfo);
			int num2 = 0;
			DataRow[] array2 = ((DataView)asDgvDaoInfo.DataSource).Table.Select(filterExpression2);
			foreach (DataRow row2 in array2)
			{
				num2 = ((DataView)asDgvDaoInfo.DataSource).Table.Rows.IndexOf(row2);
			}
			((Control)asDgvDaoInfo).Focus();
			((DataGridView)asDgvDaoInfo).CurrentCell = ((DataGridView)asDgvDaoInfo)[0, num2];
			((DataGridView)asDgvDaoInfo).CurrentRow.Selected = true;
		}
		if ((int)e.KeyCode == 119 && (int)CMessageBox.Show(50003, SystemInformations.ProductName, (MessageBoxButtons)4) == 6)
		{
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools", a_blnIsSysDB: true);
			int position = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvVoucher.DataSource)].Position;
			DataRowView dataRowView = f_dtVoucher.DefaultView[position];
			siToolsDao.SiDelVoucher(dataRowView.Row);
			DataRow[] array3 = f_dtVoucherRex.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"Voucher_code='", dataRowView["Voucher_code"]), (object)"'")));
			foreach (DataRow dataRow in array3)
			{
				siToolsDao.SiDelVoucherRex(dataRow);
				dataRow.Delete();
			}
			siToolsDao.Destroy();
			dataRowView.Delete();
			f_dtVoucher.AcceptChanges();
			f_dtVoucherRex.AcceptChanges();
		}
	}

	private void asDgvDaoInfo_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Invalid comparison between Unknown and I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 115)
		{
			int position = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvDaoInfo.DataSource)].Position;
			string text = "";
			DataRow dataRow = f_dtDaoInfo.NewRow();
			DataRow row = ((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvDaoInfo.DataSource)].Current).Row;
			dataRow["Table_name"] = "";
			dataRow["Get_sp"] = RuntimeHelpers.GetObjectValue(row["Get_sp"]);
			dataRow["Ins_sp"] = RuntimeHelpers.GetObjectValue(row["Ins_sp"]);
			dataRow["Upd_sp"] = RuntimeHelpers.GetObjectValue(row["Upd_sp"]);
			dataRow["Del_sp"] = RuntimeHelpers.GetObjectValue(row["Del_sp"]);
			checked
			{
				f_dtDaoInfo.Rows.InsertAt(dataRow, position + 1);
				((DataGridView)asDgvDaoInfo).CurrentCell = ((DataGridView)asDgvDaoInfo)[0, position + 1];
			}
		}
		if ((int)e.KeyCode == 119 && (int)CMessageBox.Show(50003, SystemInformations.ProductName, (MessageBoxButtons)4) == 6)
		{
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools", a_blnIsSysDB: true);
			int position2 = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvDaoInfo.DataSource)].Position;
			DataRowView dataRowView = f_dtDaoInfo.DefaultView[position2];
			siToolsDao.SiDelDAO(dataRowView.Row);
			dataRowView.Delete();
			f_dtDaoInfo.AcceptChanges();
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
			int position = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asdgvReportDrillDown.DataSource)].Position;
			string text = "";
			DataRow dataRow = f_dtReportDrillDown.NewRow();
			DataRow row = ((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asdgvReportDrillDown.DataSource)].Current).Row;
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
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools", a_blnIsSysDB: true);
			int position2 = ((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asdgvReportDrillDown.DataSource)].Position;
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

	private void asDgvDic_SelectionChanged(object sender, EventArgs e)
	{
		if (asDgvDic.DataSource == null || asDgvDicRex == null || _isLoading || 1 == 0)
		{
			return;
		}
		string filterExpression = "code_name= '" + ((DataGridView)asDgvDic).CurrentRow.Cells["code_name"].Value.ToString() + "'";
		if (f_dtDicRex.Select(filterExpression).Any())
		{
			int num = 0;
			DataRow[] array = ((DataView)asDgvDicRex.DataSource).Table.Select(filterExpression);
			foreach (DataRow row in array)
			{
				num = ((DataView)asDgvDicRex.DataSource).Table.Rows.IndexOf(row);
			}
			((DataGridView)asDgvDicRex).CurrentCell = ((DataGridView)asDgvDicRex)[0, num];
			((DataGridView)asDgvDicRex).CurrentRow.Selected = true;
		}
	}

	private void asDgvReport_SelectionChanged(object sender, EventArgs e)
	{
		if (asDgvReport.DataSource == null || asDgvReportRex.DataSource == null || _isLoading || 1 == 0)
		{
			return;
		}
		string text = "menuid= '" + ((DataGridView)asDgvReport).CurrentRow.Cells["menuid"].Value.ToString() + "'";
		text = text + " and ma_mau= '" + ((DataGridView)asDgvReport).CurrentRow.Cells["ma_mau"].Value.ToString() + "'";
		if (f_dtReportRex.Select(text).Any())
		{
			int num = 0;
			DataRow[] array = ((DataView)asDgvReportRex.DataSource).Table.Select(text);
			foreach (DataRow row in array)
			{
				num = ((DataView)asDgvReportRex.DataSource).Table.Rows.IndexOf(row);
			}
			((DataGridView)asDgvReportRex).CurrentCell = ((DataGridView)asDgvReportRex)[0, num];
			((DataGridView)asDgvReportRex).CurrentRow.Selected = true;
		}
	}

	private void asDgvVoucher_SelectionChanged(object sender, EventArgs e)
	{
		if (asDgvVoucher.DataSource == null || asDgvVoucherRex == null || 1 == 0)
		{
			return;
		}
		string filterExpression = "voucher_code= '" + ((DataGridView)asDgvVoucher).CurrentRow.Cells["voucher_code"].Value.ToString() + "'";
		if (f_dtVoucherRex.Select(filterExpression).Any())
		{
			int num = 0;
			DataRow[] array = ((DataView)asDgvVoucherRex.DataSource).Table.Select(filterExpression);
			foreach (DataRow row in array)
			{
				num = ((DataView)asDgvVoucherRex.DataSource).Table.Rows.IndexOf(row);
			}
			((DataGridView)asDgvVoucherRex).CurrentCell = ((DataGridView)asDgvVoucherRex)[0, num];
			((DataGridView)asDgvVoucherRex).CurrentRow.Selected = true;
		}
	}

	private void tabMenuAll_SelectedIndexChanged(object sender, EventArgs e)
	{
		SendKeys.Send("{TAB}");
		if (tabMenuAll.SelectedTab == tabRepRex)
		{
			((Control)btnGen_FieldList).Enabled = true;
		}
		else
		{
			((Control)btnGen_FieldList).Enabled = false;
		}
	}

	private void btnCreate_Click(object sender, EventArgs e)
	{
		checked
		{
			switch (cmbTranfer.Text.Substring(0, 1))
			{
			case "0":
			{
				if (tabMenuAll.SelectedTab != tabDicRex)
				{
					tabMenuAll.SelectTab(tabDicRex);
				}
				DataRow dataRow5 = f_dtDic.NewRow();
				DataRow row4 = ((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvMenu.DataSource)].Current).Row;
				string filterExpression2 = Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"code_name = '", dataRow5["code_name"]), (object)"'"));
				if (!f_dtDic.Select(filterExpression2).Any())
				{
					dataRow5["code_name"] = RuntimeHelpers.GetObjectValue(row4["code_name"]);
					dataRow5["code_Fname"] = RuntimeHelpers.GetObjectValue(row4["code_name"]);
					dataRow5["menuid"] = RuntimeHelpers.GetObjectValue(row4["menuid"]);
					dataRow5["dllname"] = RuntimeHelpers.GetObjectValue(row4["dllname"]);
					f_dtDic.Rows.Add(dataRow5);
					((DataGridView)asDgvDic).Rows[f_dtDic.DefaultView.Count - 1].Cells[0].Selected = true;
					DataRow dataRow6 = f_dtDicRex.NewRow();
					dataRow6["code_name"] = RuntimeHelpers.GetObjectValue(row4["code_name"]);
					dataRow6["language"] = "vi-VN";
					dataRow6["viewform_size"] = "760,450";
					f_dtDicRex.Rows.Add(dataRow6);
					((DataGridView)asDgvDicRex).Rows[f_dtDicRex.DefaultView.Count - 1].Cells[0].Selected = true;
				}
				break;
			}
			case "1":
			{
				if (tabMenuAll.SelectedTab != tabRepRex)
				{
					tabMenuAll.SelectTab(tabRepRex);
				}
				string text = "";
				DataRow dataRow3 = f_dtReport.NewRow();
				DataRow row2 = ((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvReport.DataSource)].Current).Row;
				dataRow3["menuid"] = RuntimeHelpers.GetObjectValue(row2["menuid"]);
				text = "0" + (int.Parse(Conversions.ToString(row2["ma_mau"])) + 1);
				dataRow3["ma_mau"] = text.Substring(text.Length - 2);
				dataRow3["Spname"] = RuntimeHelpers.GetObjectValue(row2["Spname"]);
				dataRow3["rptname"] = RuntimeHelpers.GetObjectValue(row2["rptname"]);
				f_dtReport.Rows.Add(dataRow3);
				DataRow dataRow4 = f_dtReportRex.NewRow();
				DataRow row3 = ((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvReportRex.DataSource)].Current).Row;
				dataRow4["menuid"] = RuntimeHelpers.GetObjectValue(row3["menuid"]);
				dataRow4["ma_mau"] = text.Substring(text.Length - 2);
				dataRow4["language"] = RuntimeHelpers.GetObjectValue(row3["language"]);
				f_dtReportRex.Rows.Add(dataRow4);
				((DataGridView)asDgvReport).CurrentCell = ((DataGridView)asDgvReport)[1, f_dtReport.DefaultView.Count - 1];
				break;
			}
			case "2":
			{
				if (tabMenuAll.SelectedTab != tabVoucher)
				{
					tabMenuAll.SelectTab(tabVoucher);
				}
				DataRow dataRow = f_dtVoucher.NewRow();
				DataRow row = ((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asDgvMenu.DataSource)].Current).Row;
				string filterExpression = Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"code_name = '", dataRow["code_name"]), (object)"'"));
				if (!f_dtVoucher.Select(filterExpression).Any())
				{
					dataRow["Voucher_code"] = RuntimeHelpers.GetObjectValue(row["code_name"]);
					f_dtVoucher.Rows.Add(dataRow);
					((DataGridView)asDgvVoucher).Rows[f_dtVoucher.DefaultView.Count - 1].Cells[0].Selected = true;
					DataRow dataRow2 = f_dtVoucherRex.NewRow();
					dataRow2["Voucher_code"] = RuntimeHelpers.GetObjectValue(row["code_name"]);
					dataRow2["language"] = "vi-VN";
					f_dtVoucherRex.Rows.Add(dataRow2);
					((DataGridView)asDgvVoucherRex).Rows[f_dtVoucherRex.DefaultView.Count - 1].Cells[0].Selected = true;
				}
				break;
			}
			}
		}
	}

	private void btnGen_FieldList_Click(object sender, EventArgs e)
	{
		Gen_FielListDynReport();
	}

	private void asdgvStoreProc_SelectionChanged(object sender, EventArgs e)
	{
		if ((f_dtDmStore != null && f_dtPara != null && !_isLoading) ? true : false)
		{
			string text = Conversions.ToString(((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asdgvStoreProc.DataSource)].Current)["stored_procedure"]);
			string rowFilter = "stored_procedure = '" + text + "'";
			f_dtPara.DefaultView.RowFilter = rowFilter;
		}
	}

	private void asdgvParameter_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if ((f_dtPara == null && f_dtPara.Rows.Count <= 0 && !_isLoading) ? true : false)
		{
			return;
		}
		DataRowView dataRowView = (DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asdgvParameter.DataSource)].Current;
		if (Operators.CompareString(((DataGridView)asdgvParameter).Columns[e.ColumnIndex].Name.ToUpper(), "DF_Value".ToUpper(), false) != 0)
		{
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(dataRowView["DF_Value"], (object)true, false))
		{
			switch (dataRowView["type"].ToString().ToUpper())
			{
			case "NVARCHAR":
				dataRowView["Value"] = "";
				break;
			case "NUMERIC":
				dataRowView["Value"] = 0;
				break;
			case "SMALLDATETIME":
				dataRowView["Value"] = DateTime.Now.ToShortDateString();
				break;
			case "INT":
				dataRowView["Value"] = 0;
				break;
			}
		}
		else
		{
			dataRowView["Value"] = "";
		}
		((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asdgvParameter.DataSource)].EndCurrentEdit();
	}

	private void GetCompanyInfo()
	{
		if (!GetCacheKey("COMPANY", ref f_dtCompany, asDgvCompanyInfo))
		{
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools", a_blnIsSysDB: true);
			f_dtCompany = siToolsDao.SiGetCompanyInfo();
			fCache.Cache.Insert("COMPANY", (object)f_dtCompany, (CacheDependency)null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(2.0));
			FormatGridView(f_dtCompany, asDgvCompanyInfo);
			siToolsDao.Destroy();
		}
	}

	private void UpdateDBCompany()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((ContainerControl)this).BindingContext[(object)f_dtCompany].EndCurrentEdit();
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools", a_blnIsSysDB: true);
			if (f_dtCompany.GetChanges() != null)
			{
				foreach (DataRow row in f_dtCompany.GetChanges().Rows)
				{
					siToolsDao.UpdateCompanyInfo(row);
				}
			}
			siToolsDao.Destroy();
			f_dtCompany.AcceptChanges();
			fCache.Cache["COMPANY"] = f_dtCompany;
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
		ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools", a_blnIsSysDB: true);
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
		FormatGridView(f_dtAllMenu, asDgvMenu);
	}

	private void UpdateDB(ref DataTable pDt, int pInsert, int pUpdate)
	{
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (pDt == null)
			{
				return;
			}
			((ContainerControl)this).BindingContext[(object)pDt].EndCurrentEdit();
			ISiToolsDao dao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools", a_blnIsSysDB: true);
			if (pDt.GetChanges(DataRowState.Modified) != null)
			{
				foreach (DataRow row in pDt.GetChanges(DataRowState.Modified).Rows)
				{
					CaseFunction(ref dao, pUpdate, row);
				}
			}
			if (pDt.GetChanges(DataRowState.Added) == null)
			{
				return;
			}
			foreach (DataRow row2 in pDt.GetChanges(DataRowState.Added).Rows)
			{
				CaseFunction(ref dao, pInsert, row2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			CMessageBox.Show(50011);
			ProjectData.ClearProjectError();
		}
	}

	private void CaseFunction(ref ISiToolsDao dao, int pFun, DataRow dr)
	{
		switch (pFun)
		{
		case 1:
			dao.SiInsertMenu(dr);
			break;
		case 2:
			dao.SiUpdateMenu(dr);
			break;
		case 3:
			dao.SiInsertDic(dr);
			break;
		case 4:
			dao.SiUpdateDic(dr);
			break;
		case 5:
			dao.SiInsertDicRex(dr);
			break;
		case 6:
			dao.SiUpdateDicRex(dr);
			break;
		case 7:
			dao.SiInsertReport(dr);
			break;
		case 8:
			dao.SiUpdateReport(dr);
			break;
		case 9:
			dao.SiInsertReportRex(dr);
			break;
		case 10:
			dao.SiUpdateReportRex(dr);
			break;
		case 11:
			dao.SiInsertVoucher(dr);
			break;
		case 12:
			dao.SiUpdateVoucher(dr);
			break;
		case 13:
			dao.SiInsertVoucherRex(dr);
			break;
		case 14:
			dao.SiUpdateVoucherRex(dr);
			break;
		case 15:
			dao.SiInsertDAO(dr);
			break;
		case 16:
			dao.SiUpdateDAO(dr);
			break;
		case 17:
			dao.SiInsertReportDrillDown(dr);
			break;
		case 18:
			dao.SiUpdateReportDrillDown(dr);
			break;
		}
	}

	private void GetAllSys()
	{
		if ((!GetCacheKey("DICINFO", ref f_dtDic, asDgvDic) || !GetCacheKey("DICRESX", ref f_dtDicRex, asDgvDicRex) || !GetCacheKey("REINFO", ref f_dtReport, asDgvReport) || !GetCacheKey("RERESX", ref f_dtReportRex, asDgvReportRex) || !GetCacheKey("VOUINFO", ref f_dtVoucher, asDgvVoucher) || !GetCacheKey("VOURESX", ref f_dtVoucherRex, asDgvVoucherRex) || !GetCacheKey("DAOINFO", ref f_dtDaoInfo, asDgvDaoInfo) || !GetCacheKey("DRIINFO", ref f_dtReportDrillDown, asdgvReportDrillDown)) && 0 == 0)
		{
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools", a_blnIsSysDB: true);
			DataSet dataSet = siToolsDao.SiGetAllSys();
			siToolsDao.Destroy();
			f_dtDic = dataSet.Tables[0];
			f_dtDicRex = dataSet.Tables[1];
			f_dtReport = dataSet.Tables[2];
			f_dtReportRex = dataSet.Tables[3];
			f_dtVoucher = dataSet.Tables[4];
			f_dtVoucherRex = dataSet.Tables[5];
			f_dtDaoInfo = dataSet.Tables[6];
			f_dtReportDrillDown = dataSet.Tables[7];
			dataSet.Dispose();
			fCache.Cache.Insert("DICINFO", (object)f_dtDic, (CacheDependency)null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(2.0));
			fCache.Cache.Insert("DICRESX", (object)f_dtDicRex, (CacheDependency)null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(2.0));
			fCache.Cache.Insert("REINFO", (object)f_dtReport, (CacheDependency)null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(2.0));
			fCache.Cache.Insert("RERESX", (object)f_dtReportRex, (CacheDependency)null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(2.0));
			fCache.Cache.Insert("VOUINFO", (object)f_dtVoucher, (CacheDependency)null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(2.0));
			fCache.Cache.Insert("VOURESX", (object)f_dtVoucherRex, (CacheDependency)null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(2.0));
			fCache.Cache.Insert("DAOINFO", (object)f_dtDaoInfo, (CacheDependency)null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(2.0));
			fCache.Cache.Insert("DRIINFO", (object)f_dtReportDrillDown, (CacheDependency)null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(2.0));
			FormatGridView(f_dtDic, asDgvDic);
			FormatGridView(f_dtDicRex, asDgvDicRex);
			FormatGridView(f_dtReport, asDgvReport);
			FormatGridView(f_dtReportRex, asDgvReportRex);
			FormatGridView(f_dtVoucher, asDgvVoucher);
			FormatGridView(f_dtVoucherRex, asDgvVoucherRex);
			FormatGridView(f_dtDaoInfo, asDgvDaoInfo);
			FormatGridView(f_dtReportDrillDown, asdgvReportDrillDown);
		}
	}

	private void getDmExcProc()
	{
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		if ((GetCacheKey("DMSTORE", ref f_dtDmStore, asdgvStoreProc) && GetCacheKey("PARAOFSTORE", ref f_dtPara, asdgvParameter)) ? true : false)
		{
			return;
		}
		ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools");
		DataSet dataSet = siToolsDao.SiGetAllProcPara();
		siToolsDao.Destroy();
		f_dtDmStore = dataSet.Tables[0];
		f_dtPara = dataSet.Tables[1];
		dataSet.Dispose();
		fCache.Cache.Insert("DMSTORE", (object)f_dtDmStore, (CacheDependency)null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(2.0));
		fCache.Cache.Insert("PARAOFSTORE", (object)f_dtPara, (CacheDependency)null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(2.0));
		FormatGridView(f_dtDmStore, asdgvStoreProc);
		FormatGridView(f_dtPara, asdgvParameter);
		foreach (DataGridViewColumn item in (BaseCollection)((DataGridView)asdgvParameter).Columns)
		{
			DataGridViewColumn val = item;
			val.AutoSizeMode = (DataGridViewAutoSizeColumnMode)10;
			if (Operators.CompareString(val.Name, "Value", false) == 0)
			{
				val.ReadOnly = false;
				val.AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
			}
			else if (Operators.CompareString(val.Name, "DF_Value", false) == 0)
			{
				val.Visible = false;
				val.ReadOnly = false;
			}
			else if (Operators.CompareString(val.Name.ToUpper(), "STORED_PROCEDURE", false) == 0)
			{
				val.Visible = false;
			}
			else if (Operators.CompareString(val.Name.ToUpper(), "TYPE", false) == 0)
			{
				val.Visible = false;
			}
			else
			{
				val.ReadOnly = true;
			}
		}
		foreach (DataGridViewColumn item2 in (BaseCollection)((DataGridView)asdgvStoreProc).Columns)
		{
			DataGridViewColumn val2 = item2;
			val2.AutoSizeMode = (DataGridViewAutoSizeColumnMode)10;
		}
	}

	private void ExcSP()
	{
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DataRowView dataRowView = (DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(asdgvStoreProc.DataSource)].Current;
			string text = Conversions.ToString(dataRowView["stored_procedure"]);
			string text2 = "EXECUTE " + text;
			DataRow[] array = f_dtPara.Select("Stored_procedure='" + text + "'");
			foreach (DataRow dataRow in array)
			{
				string text3 = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["value"]), isNum: false));
				text2 = text2 + " '" + text3 + "',";
			}
			text2 = text2.Substring(0, checked(text2.Length - 1));
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools");
			if (Operators.CompareString(dataRowView["IS_RESULT"].ToString(), "True", false) == 0)
			{
				FormatGridView(siToolsDao.SiExcSP_IsReSult(text2), asDgvResult);
				siToolsDao.Destroy();
			}
			else
			{
				FormatGridView(siToolsDao.SiExcSP_NoReSult(text2), asDgvResult);
				siToolsDao.Destroy();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			CMessageBox.Show(99999);
			ProjectData.ClearProjectError();
		}
	}

	private void asDgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
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

	private void btnOpendialog_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)fbdPath).ShowDialog();
		txtUpdatePatch.Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(fbdPath.SelectedPath, string.Empty, false) == 0, (object)txtUpdatePatch.Text, (object)fbdPath.SelectedPath));
	}
}
