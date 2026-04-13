using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using AsiaErp.Bussiness;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSITheme : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("btnExit")]
	private Button _btnExit;

	[AccessedThroughProperty("label1")]
	private Label _label1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("fontDialog")]
	private FontDialog _fontDialog;

	[AccessedThroughProperty("ctMenuTool")]
	private ContextMenuStrip _ctMenuTool;

	[AccessedThroughProperty("RestartToolStripMenuItem")]
	private ToolStripMenuItem _RestartToolStripMenuItem;

	[AccessedThroughProperty("TT_Grid")]
	private ToolTip _TT_Grid;

	[AccessedThroughProperty("grbProperty")]
	private GroupBox _grbProperty;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("tbxLeftColor")]
	private TextBox _tbxLeftColor;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("txtField2CarryInReport")]
	private TextBox _txtField2CarryInReport;

	[AccessedThroughProperty("txtAsTextBox_BakgroundColorName")]
	private TextBox _txtAsTextBox_BakgroundColorName;

	[AccessedThroughProperty("txtEscapeCharacters")]
	private TextBox _txtEscapeCharacters;

	[AccessedThroughProperty("txtServiceUri")]
	private TextBox _txtServiceUri;

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

	[AccessedThroughProperty("txtCT_BakgroundColorName")]
	private TextBox _txtCT_BakgroundColorName;

	[AccessedThroughProperty("tbxWPanel")]
	private TextBox _tbxWPanel;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

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

	[AccessedThroughProperty("lbDetailMnFont")]
	private Label _lbDetailMnFont;

	[AccessedThroughProperty("tbxForeColor")]
	private TextBox _tbxForeColor;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("tbDetailMnFont")]
	private TextBox _tbDetailMnFont;

	[AccessedThroughProperty("lbDetailMnForeColor")]
	private Label _lbDetailMnForeColor;

	[AccessedThroughProperty("tbxDetailMnForeColor")]
	private TextBox _tbxDetailMnForeColor;

	[AccessedThroughProperty("lblSubMnForeColor")]
	private Label _lblSubMnForeColor;

	[AccessedThroughProperty("tbxSubMnForeColor")]
	private TextBox _tbxSubMnForeColor;

	[AccessedThroughProperty("lblWPanel")]
	private Label _lblWPanel;

	[AccessedThroughProperty("tbxMnSelectedColor")]
	private TextBox _tbxMnSelectedColor;

	[AccessedThroughProperty("lbMnSlFColor")]
	private Label _lbMnSlFColor;

	[AccessedThroughProperty("lblForeColor")]
	private Label _lblForeColor;

	[AccessedThroughProperty("lblFont")]
	private Label _lblFont;

	[AccessedThroughProperty("tbxBgColor")]
	private TextBox _tbxBgColor;

	[AccessedThroughProperty("tbxFont")]
	private TextBox _tbxFont;

	[AccessedThroughProperty("lblMnBckClr")]
	private Label _lblMnBckClr;

	[AccessedThroughProperty("cbxMnType")]
	private ComboBox _cbxMnType;

	[AccessedThroughProperty("tbxWColumn")]
	private TextBox _tbxWColumn;

	[AccessedThroughProperty("lblMenuType")]
	private Label _lblMenuType;

	[AccessedThroughProperty("lblColumn")]
	private Label _lblColumn;

	[AccessedThroughProperty("lblSubMnFont")]
	private Label _lblSubMnFont;

	[AccessedThroughProperty("lblLabelForeColor")]
	private Label _lblLabelForeColor;

	[AccessedThroughProperty("tbxSubMnFont")]
	private TextBox _tbxSubMnFont;

	[AccessedThroughProperty("tbxLbForeColor")]
	private TextBox _tbxLbForeColor;

	[AccessedThroughProperty("cboThemes")]
	private ComboBox _cboThemes;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("cmdUse")]
	private Button _cmdUse;

	[AccessedThroughProperty("cmdReset")]
	private Button _cmdReset;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("cmdDel")]
	private Button _cmdDel;

	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	private const string DEFAULT_THEME = "Default";

	private XmlDocument xmldoc;

	private DataSet dsTheme;

	private Hashtable _hstThemeConfig;

	private string currentTheme;

	private string EditTheme;

	private bool isLoading;

	private string newTheme;

	private bool isLoadOk;

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

	internal virtual GroupBox grbProperty
	{
		[DebuggerNonUserCode]
		get
		{
			return _grbProperty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grbProperty = value;
		}
	}

	private virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	private virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
		}
	}

	private virtual Label Label13
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

	private virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	private virtual TextBox tbxLeftColor
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbxLeftColor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbxLeftColor = value;
		}
	}

	private virtual Label Label12
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

	private virtual ComboBox cboThemes
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboThemes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboThemes_SelectedIndexChanged;
			if (_cboThemes != null)
			{
				_cboThemes.SelectedIndexChanged -= eventHandler;
			}
			_cboThemes = value;
			if (_cboThemes != null)
			{
				_cboThemes.SelectedIndexChanged += eventHandler;
			}
		}
	}

	private virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	internal virtual Button cmdUse
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUse_Click;
			if (_cmdUse != null)
			{
				((Control)_cmdUse).Click -= eventHandler;
			}
			_cmdUse = value;
			if (_cmdUse != null)
			{
				((Control)_cmdUse).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdReset
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdReset;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdReset_Click;
			if (_cmdReset != null)
			{
				((Control)_cmdReset).Click -= eventHandler;
			}
			_cmdReset = value;
			if (_cmdReset != null)
			{
				((Control)_cmdReset).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdAdd
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

	internal virtual Button cmdDel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdDel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdDel_Click;
			if (_cmdDel != null)
			{
				((Control)_cmdDel).Click -= eventHandler;
			}
			_cmdDel = value;
			if (_cmdDel != null)
			{
				((Control)_cmdDel).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnSave
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
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	public frmSITheme(string menuid)
		: base(menuid)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmSITheme_KeyDown);
		((Form)this).Shown += frmSITheme_Shown;
		((Form)this).Load += frmSITheme_Load;
		__ENCAddToList(this);
		currentTheme = "";
		EditTheme = "";
		isLoading = true;
		newTheme = "";
		isLoadOk = false;
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected O, but got Unknown
		//IL_0e70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7a: Expected O, but got Unknown
		//IL_0f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected O, but got Unknown
		//IL_0fbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc7: Expected O, but got Unknown
		//IL_105f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Expected O, but got Unknown
		//IL_24c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d0: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSITheme));
		label1 = new Label();
		Panel1 = new Panel();
		btnSave = new Button();
		cmdDel = new Button();
		cmdAdd = new Button();
		btnExit = new Button();
		cmdReset = new Button();
		fontDialog = new FontDialog();
		ctMenuTool = new ContextMenuStrip(components);
		RestartToolStripMenuItem = new ToolStripMenuItem();
		TT_Grid = new ToolTip(components);
		grbProperty = new GroupBox();
		Label16 = new Label();
		Label15 = new Label();
		Label13 = new Label();
		Label14 = new Label();
		tbxLeftColor = new TextBox();
		Label12 = new Label();
		txtField2CarryInReport = new TextBox();
		txtAsTextBox_BakgroundColorName = new TextBox();
		txtEscapeCharacters = new TextBox();
		txtServiceUri = new TextBox();
		txtBC_AlternatingBackColorName = new TextBox();
		txtBC_BakgroundColorName = new TextBox();
		txtDM_AlternatingBackColorName = new TextBox();
		txtDM_BakgroundColorName = new TextBox();
		txtCT_AlternatingBackColorName = new TextBox();
		txtCT_BakgroundColorName = new TextBox();
		tbxWPanel = new TextBox();
		Label6 = new Label();
		Label10 = new Label();
		Label7 = new Label();
		Label11 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label3 = new Label();
		lbDetailMnFont = new Label();
		tbxForeColor = new TextBox();
		Label2 = new Label();
		tbDetailMnFont = new TextBox();
		lbDetailMnForeColor = new Label();
		tbxDetailMnForeColor = new TextBox();
		lblSubMnForeColor = new Label();
		tbxSubMnForeColor = new TextBox();
		lblWPanel = new Label();
		tbxMnSelectedColor = new TextBox();
		lbMnSlFColor = new Label();
		lblForeColor = new Label();
		lblFont = new Label();
		tbxBgColor = new TextBox();
		tbxFont = new TextBox();
		lblMnBckClr = new Label();
		cbxMnType = new ComboBox();
		tbxWColumn = new TextBox();
		lblMenuType = new Label();
		lblColumn = new Label();
		lblSubMnFont = new Label();
		lblLabelForeColor = new Label();
		tbxSubMnFont = new TextBox();
		tbxLbForeColor = new TextBox();
		cboThemes = new ComboBox();
		Label17 = new Label();
		cmdUse = new Button();
		((Control)Panel1).SuspendLayout();
		((Control)ctMenuTool).SuspendLayout();
		((Control)grbProperty).SuspendLayout();
		((Control)this).SuspendLayout();
		label1.AutoSize = true;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		Label obj = label1;
		Point location = new Point(12, 0);
		((Control)obj).Location = location;
		((Control)label1).Name = "label1";
		Label obj2 = label1;
		Size size = new Size(178, 16);
		((Control)obj2).Size = size;
		((Control)label1).TabIndex = 5;
		label1.Text = "Click vào ô để thay đổi giá trị";
		((Control)Panel1).Controls.Add((Control)(object)btnSave);
		((Control)Panel1).Controls.Add((Control)(object)cmdDel);
		((Control)Panel1).Controls.Add((Control)(object)cmdAdd);
		((Control)Panel1).Controls.Add((Control)(object)btnExit);
		((Control)Panel1).Controls.Add((Control)(object)cmdReset);
		((Control)Panel1).Controls.Add((Control)(object)label1);
		((Control)Panel1).Dock = (DockStyle)2;
		Panel panel = Panel1;
		location = new Point(0, 559);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(870, 39);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 114;
		((Control)btnSave).Anchor = (AnchorStyles)10;
		((ButtonBase)btnSave).Image = (Image)(object)Resources.save;
		((ButtonBase)btnSave).ImageAlign = (ContentAlignment)16;
		Button obj3 = btnSave;
		location = new Point(710, 6);
		((Control)obj3).Location = location;
		((Control)btnSave).Name = "btnSave";
		Button obj4 = btnSave;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)btnSave).TabIndex = 3;
		((ButtonBase)btnSave).Text = "Lưu";
		((ButtonBase)btnSave).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnSave).UseVisualStyleBackColor = true;
		((Control)cmdDel).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdDel).Image = (Image)(object)Resources.imgDelete;
		((ButtonBase)cmdDel).ImageAlign = (ContentAlignment)16;
		Button obj5 = cmdDel;
		location = new Point(629, 6);
		((Control)obj5).Location = location;
		((Control)cmdDel).Name = "cmdDel";
		Button obj6 = cmdDel;
		size = new Size(75, 23);
		((Control)obj6).Size = size;
		((Control)cmdDel).TabIndex = 2;
		((ButtonBase)cmdDel).Text = "Xóa";
		((ButtonBase)cmdDel).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdDel).UseVisualStyleBackColor = true;
		((Control)cmdAdd).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdAdd).Image = (Image)(object)Resources.imgAdd;
		((ButtonBase)cmdAdd).ImageAlign = (ContentAlignment)16;
		Button obj7 = cmdAdd;
		location = new Point(467, 6);
		((Control)obj7).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		Button obj8 = cmdAdd;
		size = new Size(75, 23);
		((Control)obj8).Size = size;
		((Control)cmdAdd).TabIndex = 0;
		((ButtonBase)cmdAdd).Text = "Mới";
		((ButtonBase)cmdAdd).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdAdd).UseVisualStyleBackColor = true;
		((Control)btnExit).Anchor = (AnchorStyles)10;
		((ButtonBase)btnExit).Image = (Image)componentResourceManager.GetObject("btnExit.Image");
		((ButtonBase)btnExit).ImageAlign = (ContentAlignment)16;
		Button obj9 = btnExit;
		location = new Point(788, 6);
		((Control)obj9).Location = location;
		((Control)btnExit).Name = "btnExit";
		Button obj10 = btnExit;
		size = new Size(75, 23);
		((Control)obj10).Size = size;
		((Control)btnExit).TabIndex = 4;
		((ButtonBase)btnExit).Text = "&Thoát";
		((ButtonBase)btnExit).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnExit).UseVisualStyleBackColor = true;
		((Control)cmdReset).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdReset).Image = (Image)(object)Resources.refresh;
		((ButtonBase)cmdReset).ImageAlign = (ContentAlignment)256;
		Button obj11 = cmdReset;
		location = new Point(548, 6);
		((Control)obj11).Location = location;
		((Control)cmdReset).Name = "cmdReset";
		Button obj12 = cmdReset;
		size = new Size(75, 23);
		((Control)obj12).Size = size;
		((Control)cmdReset).TabIndex = 1;
		((ButtonBase)cmdReset).Text = "Mặc định";
		((ButtonBase)cmdReset).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdReset).UseVisualStyleBackColor = true;
		((ToolStrip)ctMenuTool).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)RestartToolStripMenuItem });
		((Control)ctMenuTool).Name = "ctMenuTool";
		((ToolStrip)ctMenuTool).RenderMode = (ToolStripRenderMode)2;
		ContextMenuStrip obj13 = ctMenuTool;
		size = new Size(152, 26);
		((Control)obj13).Size = size;
		((ToolStripItem)RestartToolStripMenuItem).Name = "RestartToolStripMenuItem";
		RestartToolStripMenuItem.ShortcutKeys = (Keys)131154;
		ToolStripMenuItem restartToolStripMenuItem = RestartToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)restartToolStripMenuItem).Size = size;
		((ToolStripItem)RestartToolStripMenuItem).Text = "Restart";
		TT_Grid.AutomaticDelay = 100;
		TT_Grid.AutoPopDelay = 1000;
		TT_Grid.InitialDelay = 200;
		TT_Grid.IsBalloon = true;
		TT_Grid.ReshowDelay = 10;
		TT_Grid.ToolTipIcon = (ToolTipIcon)1;
		((Control)grbProperty).Anchor = (AnchorStyles)15;
		((Control)grbProperty).Controls.Add((Control)(object)Label16);
		((Control)grbProperty).Controls.Add((Control)(object)Label15);
		((Control)grbProperty).Controls.Add((Control)(object)Label13);
		((Control)grbProperty).Controls.Add((Control)(object)Label14);
		((Control)grbProperty).Controls.Add((Control)(object)tbxLeftColor);
		((Control)grbProperty).Controls.Add((Control)(object)Label12);
		((Control)grbProperty).Controls.Add((Control)(object)txtField2CarryInReport);
		((Control)grbProperty).Controls.Add((Control)(object)txtAsTextBox_BakgroundColorName);
		((Control)grbProperty).Controls.Add((Control)(object)txtEscapeCharacters);
		((Control)grbProperty).Controls.Add((Control)(object)txtServiceUri);
		((Control)grbProperty).Controls.Add((Control)(object)txtBC_AlternatingBackColorName);
		((Control)grbProperty).Controls.Add((Control)(object)txtBC_BakgroundColorName);
		((Control)grbProperty).Controls.Add((Control)(object)txtDM_AlternatingBackColorName);
		((Control)grbProperty).Controls.Add((Control)(object)txtDM_BakgroundColorName);
		((Control)grbProperty).Controls.Add((Control)(object)txtCT_AlternatingBackColorName);
		((Control)grbProperty).Controls.Add((Control)(object)txtCT_BakgroundColorName);
		((Control)grbProperty).Controls.Add((Control)(object)tbxWPanel);
		((Control)grbProperty).Controls.Add((Control)(object)Label6);
		((Control)grbProperty).Controls.Add((Control)(object)Label10);
		((Control)grbProperty).Controls.Add((Control)(object)Label7);
		((Control)grbProperty).Controls.Add((Control)(object)Label11);
		((Control)grbProperty).Controls.Add((Control)(object)Label8);
		((Control)grbProperty).Controls.Add((Control)(object)Label9);
		((Control)grbProperty).Controls.Add((Control)(object)Label4);
		((Control)grbProperty).Controls.Add((Control)(object)Label5);
		((Control)grbProperty).Controls.Add((Control)(object)Label3);
		((Control)grbProperty).Controls.Add((Control)(object)lbDetailMnFont);
		((Control)grbProperty).Controls.Add((Control)(object)tbxForeColor);
		((Control)grbProperty).Controls.Add((Control)(object)Label2);
		((Control)grbProperty).Controls.Add((Control)(object)tbDetailMnFont);
		((Control)grbProperty).Controls.Add((Control)(object)lbDetailMnForeColor);
		((Control)grbProperty).Controls.Add((Control)(object)tbxDetailMnForeColor);
		((Control)grbProperty).Controls.Add((Control)(object)lblSubMnForeColor);
		((Control)grbProperty).Controls.Add((Control)(object)tbxSubMnForeColor);
		((Control)grbProperty).Controls.Add((Control)(object)lblWPanel);
		((Control)grbProperty).Controls.Add((Control)(object)tbxMnSelectedColor);
		((Control)grbProperty).Controls.Add((Control)(object)lbMnSlFColor);
		((Control)grbProperty).Controls.Add((Control)(object)lblForeColor);
		((Control)grbProperty).Controls.Add((Control)(object)lblFont);
		((Control)grbProperty).Controls.Add((Control)(object)tbxBgColor);
		((Control)grbProperty).Controls.Add((Control)(object)tbxFont);
		((Control)grbProperty).Controls.Add((Control)(object)lblMnBckClr);
		((Control)grbProperty).Controls.Add((Control)(object)cbxMnType);
		((Control)grbProperty).Controls.Add((Control)(object)tbxWColumn);
		((Control)grbProperty).Controls.Add((Control)(object)lblMenuType);
		((Control)grbProperty).Controls.Add((Control)(object)lblColumn);
		((Control)grbProperty).Controls.Add((Control)(object)lblSubMnFont);
		((Control)grbProperty).Controls.Add((Control)(object)lblLabelForeColor);
		((Control)grbProperty).Controls.Add((Control)(object)tbxSubMnFont);
		((Control)grbProperty).Controls.Add((Control)(object)tbxLbForeColor);
		GroupBox obj14 = grbProperty;
		location = new Point(13, 50);
		((Control)obj14).Location = location;
		((Control)grbProperty).Name = "grbProperty";
		GroupBox obj15 = grbProperty;
		size = new Size(845, 503);
		((Control)obj15).Size = size;
		((Control)grbProperty).TabIndex = 3;
		grbProperty.TabStop = false;
		grbProperty.Text = "Thuộc tính";
		Label16.AutoSize = true;
		((Control)Label16).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label16).ForeColor = Color.Black;
		Label label = Label16;
		location = new Point(462, 60);
		((Control)label).Location = location;
		((Control)Label16).Name = "Label16";
		Label label2 = Label16;
		size = new Size(198, 13);
		((Control)label2).Size = size;
		((Control)Label16).TabIndex = 215;
		Label16.Text = "Màu chứng từ/danh mục/báo cáo";
		Label15.AutoSize = true;
		((Control)Label15).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label15).ForeColor = Color.Black;
		Label label3 = Label15;
		location = new Point(32, 60);
		((Control)label3).Location = location;
		((Control)Label15).Name = "Label15";
		Label label4 = Label15;
		size = new Size(360, 13);
		((Control)label4).Size = size;
		((Control)Label15).TabIndex = 214;
		Label15.Text = "Màu và thuộc tính cho menu (chỉ tác dụng với Docking menu)";
		Label13.AutoSize = true;
		((Control)Label13).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label13).ForeColor = Color.Black;
		Label label5 = Label13;
		location = new Point(32, 82);
		((Control)label5).Location = location;
		((Control)Label13).Name = "Label13";
		Label label6 = Label13;
		size = new Size(54, 13);
		((Control)label6).Size = size;
		((Control)Label13).TabIndex = 212;
		Label13.Text = "Phân hệ";
		Label14.AutoSize = true;
		((Control)Label14).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label14).ForeColor = Color.Black;
		Label label7 = Label14;
		location = new Point(32, 295);
		((Control)label7).Location = location;
		((Control)Label14).Name = "Label14";
		Label label8 = Label14;
		size = new Size(151, 13);
		((Control)label8).Size = size;
		((Control)Label14).TabIndex = 213;
		Label14.Text = "Chức năng trong phân hệ";
		TextBox obj16 = tbxLeftColor;
		location = new Point(185, 136);
		((Control)obj16).Location = location;
		((Control)tbxLeftColor).Name = "tbxLeftColor";
		((TextBoxBase)tbxLeftColor).ReadOnly = true;
		TextBox obj17 = tbxLeftColor;
		size = new Size(103, 20);
		((Control)obj17).Size = size;
		((Control)tbxLeftColor).TabIndex = 2;
		((Control)tbxLeftColor).Tag = "0";
		Label12.AutoSize = true;
		Label label9 = Label12;
		location = new Point(32, 139);
		((Control)label9).Location = location;
		((Control)Label12).Name = "Label12";
		Label label10 = Label12;
		size = new Size(118, 13);
		((Control)label10).Size = size;
		((Control)Label12).TabIndex = 211;
		Label12.Text = "Màu nền bảng phân hệ";
		TextBox obj18 = txtField2CarryInReport;
		location = new Point(634, 425);
		((Control)obj18).Location = location;
		((Control)txtField2CarryInReport).Name = "txtField2CarryInReport";
		((TextBoxBase)txtField2CarryInReport).ReadOnly = true;
		TextBox obj19 = txtField2CarryInReport;
		size = new Size(179, 20);
		((Control)obj19).Size = size;
		((Control)txtField2CarryInReport).TabIndex = 187;
		((Control)txtField2CarryInReport).Visible = false;
		TextBox obj20 = txtAsTextBox_BakgroundColorName;
		location = new Point(634, 243);
		((Control)obj20).Location = location;
		((Control)txtAsTextBox_BakgroundColorName).Name = "txtAsTextBox_BakgroundColorName";
		((TextBoxBase)txtAsTextBox_BakgroundColorName).ReadOnly = true;
		TextBox obj21 = txtAsTextBox_BakgroundColorName;
		size = new Size(103, 20);
		((Control)obj21).Size = size;
		((Control)txtAsTextBox_BakgroundColorName).TabIndex = 13;
		((Control)txtAsTextBox_BakgroundColorName).Tag = "0";
		TextBox obj22 = txtEscapeCharacters;
		location = new Point(634, 399);
		((Control)obj22).Location = location;
		((Control)txtEscapeCharacters).Name = "txtEscapeCharacters";
		((TextBoxBase)txtEscapeCharacters).ReadOnly = true;
		TextBox obj23 = txtEscapeCharacters;
		size = new Size(45, 20);
		((Control)obj23).Size = size;
		((Control)txtEscapeCharacters).TabIndex = 186;
		((Control)txtEscapeCharacters).Visible = false;
		TextBox obj24 = txtServiceUri;
		location = new Point(634, 451);
		((Control)obj24).Location = location;
		((Control)txtServiceUri).Name = "txtServiceUri";
		TextBox obj25 = txtServiceUri;
		size = new Size(179, 20);
		((Control)obj25).Size = size;
		((Control)txtServiceUri).TabIndex = 178;
		((Control)txtServiceUri).Visible = false;
		TextBox obj26 = txtBC_AlternatingBackColorName;
		location = new Point(634, 213);
		((Control)obj26).Location = location;
		((Control)txtBC_AlternatingBackColorName).Name = "txtBC_AlternatingBackColorName";
		((TextBoxBase)txtBC_AlternatingBackColorName).ReadOnly = true;
		TextBox obj27 = txtBC_AlternatingBackColorName;
		size = new Size(103, 20);
		((Control)obj27).Size = size;
		((Control)txtBC_AlternatingBackColorName).TabIndex = 12;
		((Control)txtBC_AlternatingBackColorName).Tag = "0";
		TextBox obj28 = txtBC_BakgroundColorName;
		location = new Point(634, 187);
		((Control)obj28).Location = location;
		((Control)txtBC_BakgroundColorName).Name = "txtBC_BakgroundColorName";
		((TextBoxBase)txtBC_BakgroundColorName).ReadOnly = true;
		TextBox obj29 = txtBC_BakgroundColorName;
		size = new Size(103, 20);
		((Control)obj29).Size = size;
		((Control)txtBC_BakgroundColorName).TabIndex = 11;
		((Control)txtBC_BakgroundColorName).Tag = "0";
		TextBox obj30 = txtDM_AlternatingBackColorName;
		location = new Point(634, 161);
		((Control)obj30).Location = location;
		((Control)txtDM_AlternatingBackColorName).Name = "txtDM_AlternatingBackColorName";
		((TextBoxBase)txtDM_AlternatingBackColorName).ReadOnly = true;
		TextBox obj31 = txtDM_AlternatingBackColorName;
		size = new Size(103, 20);
		((Control)obj31).Size = size;
		((Control)txtDM_AlternatingBackColorName).TabIndex = 10;
		((Control)txtDM_AlternatingBackColorName).Tag = "0";
		TextBox obj32 = txtDM_BakgroundColorName;
		location = new Point(634, 135);
		((Control)obj32).Location = location;
		((Control)txtDM_BakgroundColorName).Name = "txtDM_BakgroundColorName";
		((TextBoxBase)txtDM_BakgroundColorName).ReadOnly = true;
		TextBox obj33 = txtDM_BakgroundColorName;
		size = new Size(103, 20);
		((Control)obj33).Size = size;
		((Control)txtDM_BakgroundColorName).TabIndex = 9;
		((Control)txtDM_BakgroundColorName).Tag = "0";
		TextBox obj34 = txtCT_AlternatingBackColorName;
		location = new Point(634, 108);
		((Control)obj34).Location = location;
		((Control)txtCT_AlternatingBackColorName).Name = "txtCT_AlternatingBackColorName";
		((TextBoxBase)txtCT_AlternatingBackColorName).ReadOnly = true;
		TextBox obj35 = txtCT_AlternatingBackColorName;
		size = new Size(103, 20);
		((Control)obj35).Size = size;
		((Control)txtCT_AlternatingBackColorName).TabIndex = 8;
		((Control)txtCT_AlternatingBackColorName).Tag = "0";
		TextBox obj36 = txtCT_BakgroundColorName;
		location = new Point(634, 82);
		((Control)obj36).Location = location;
		((Control)txtCT_BakgroundColorName).Name = "txtCT_BakgroundColorName";
		((TextBoxBase)txtCT_BakgroundColorName).ReadOnly = true;
		TextBox obj37 = txtCT_BakgroundColorName;
		size = new Size(103, 20);
		((Control)obj37).Size = size;
		((Control)txtCT_BakgroundColorName).TabIndex = 7;
		((Control)txtCT_BakgroundColorName).Tag = "0";
		TextBox obj38 = tbxWPanel;
		location = new Point(185, 107);
		((Control)obj38).Location = location;
		((Control)tbxWPanel).Name = "tbxWPanel";
		TextBox obj39 = tbxWPanel;
		size = new Size(103, 20);
		((Control)obj39).Size = size;
		((Control)tbxWPanel).TabIndex = 1;
		Label6.AutoSize = true;
		((Control)Label6).ForeColor = Color.Black;
		Label label11 = Label6;
		location = new Point(462, 246);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(113, 13);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 207;
		Label6.Text = "Màu nền texbox có F5";
		Label10.AutoSize = true;
		((Control)Label10).ForeColor = Color.Black;
		Label label13 = Label10;
		location = new Point(462, 428);
		((Control)label13).Location = location;
		((Control)Label10).Name = "Label10";
		Label label14 = Label10;
		size = new Size(100, 13);
		((Control)label14).Size = size;
		((Control)Label10).TabIndex = 209;
		Label10.Text = "Field2CarryInReport";
		((Control)Label10).Visible = false;
		Label7.AutoSize = true;
		((Control)Label7).ForeColor = Color.Black;
		Label label15 = Label7;
		location = new Point(462, 216);
		((Control)label15).Location = location;
		((Control)Label7).Name = "Label7";
		Label label16 = Label7;
		size = new Size(159, 13);
		((Control)label16).Size = size;
		((Control)Label7).TabIndex = 206;
		Label7.Text = "Màu dòng xen kẽ trong báo cáo";
		Label11.AutoSize = true;
		((Control)Label11).ForeColor = Color.Black;
		Label label17 = Label11;
		location = new Point(462, 402);
		((Control)label17).Location = location;
		((Control)Label11).Name = "Label11";
		Label label18 = Label11;
		size = new Size(94, 13);
		((Control)label18).Size = size;
		((Control)Label11).TabIndex = 208;
		Label11.Text = "EscapeCharacters";
		((Control)Label11).Visible = false;
		Label8.AutoSize = true;
		((Control)Label8).ForeColor = Color.Black;
		Label label19 = Label8;
		location = new Point(462, 190);
		((Control)label19).Location = location;
		((Control)Label8).Name = "Label8";
		Label label20 = Label8;
		size = new Size(91, 13);
		((Control)label20).Size = size;
		((Control)Label8).TabIndex = 205;
		Label8.Text = "Màu nền báo cáo";
		Label9.AutoSize = true;
		((Control)Label9).ForeColor = Color.Black;
		Label label21 = Label9;
		location = new Point(462, 164);
		((Control)label21).Location = location;
		((Control)Label9).Name = "Label9";
		Label label22 = Label9;
		size = new Size(167, 13);
		((Control)label22).Size = size;
		((Control)Label9).TabIndex = 204;
		Label9.Text = "Màu dòng xen kẽ trong danh mục";
		Label4.AutoSize = true;
		((Control)Label4).ForeColor = Color.Black;
		Label label23 = Label4;
		location = new Point(462, 138);
		((Control)label23).Location = location;
		((Control)Label4).Name = "Label4";
		Label label24 = Label4;
		size = new Size(99, 13);
		((Control)label24).Size = size;
		((Control)Label4).TabIndex = 203;
		Label4.Text = "Màu nền danh mục";
		Label5.AutoSize = true;
		((Control)Label5).ForeColor = Color.Black;
		Label label25 = Label5;
		location = new Point(462, 112);
		((Control)label25).Location = location;
		((Control)Label5).Name = "Label5";
		Label label26 = Label5;
		size = new Size(165, 13);
		((Control)label26).Size = size;
		((Control)Label5).TabIndex = 202;
		Label5.Text = "Màu dòng xen kẽ  trong chứng từ";
		Label3.AutoSize = true;
		((Control)Label3).ForeColor = Color.Black;
		Label label27 = Label3;
		location = new Point(462, 85);
		((Control)label27).Location = location;
		((Control)Label3).Name = "Label3";
		Label label28 = Label3;
		size = new Size(94, 13);
		((Control)label28).Size = size;
		((Control)Label3).TabIndex = 201;
		Label3.Text = "Màu nền chứng từ";
		lbDetailMnFont.AutoSize = true;
		Label obj40 = lbDetailMnFont;
		location = new Point(32, 432);
		((Control)obj40).Location = location;
		((Control)lbDetailMnFont).Name = "lbDetailMnFont";
		Label obj41 = lbDetailMnFont;
		size = new Size(103, 13);
		((Control)obj41).Size = size;
		((Control)lbDetailMnFont).TabIndex = 199;
		lbDetailMnFont.Text = "Kiểu chữ chức năng";
		TextBox obj42 = tbxForeColor;
		location = new Point(185, 161);
		((Control)obj42).Location = location;
		((Control)tbxForeColor).Name = "tbxForeColor";
		((TextBoxBase)tbxForeColor).ReadOnly = true;
		TextBox obj43 = tbxForeColor;
		size = new Size(103, 20);
		((Control)obj43).Size = size;
		((Control)tbxForeColor).TabIndex = 3;
		((Control)tbxForeColor).Tag = "0";
		Label2.AutoSize = true;
		((Control)Label2).ForeColor = Color.Black;
		Label label29 = Label2;
		location = new Point(462, 454);
		((Control)label29).Location = location;
		((Control)Label2).Name = "Label2";
		Label label30 = Label2;
		size = new Size(56, 13);
		((Control)label30).Size = size;
		((Control)Label2).TabIndex = 200;
		Label2.Text = "ServiceUri";
		((Control)Label2).Visible = false;
		TextBox obj44 = tbDetailMnFont;
		location = new Point(185, 429);
		((Control)obj44).Location = location;
		((Control)tbDetailMnFont).Name = "tbDetailMnFont";
		((TextBoxBase)tbDetailMnFont).ReadOnly = true;
		TextBox obj45 = tbDetailMnFont;
		size = new Size(201, 20);
		((Control)obj45).Size = size;
		((Control)tbDetailMnFont).TabIndex = 18;
		((Control)tbDetailMnFont).Tag = "1";
		lbDetailMnForeColor.AutoSize = true;
		Label obj46 = lbDetailMnForeColor;
		location = new Point(32, 406);
		((Control)obj46).Location = location;
		((Control)lbDetailMnForeColor).Name = "lbDetailMnForeColor";
		Label obj47 = lbDetailMnForeColor;
		size = new Size(103, 13);
		((Control)obj47).Size = size;
		((Control)lbDetailMnForeColor).TabIndex = 198;
		lbDetailMnForeColor.Text = "Màu chữ chức năng";
		TextBox obj48 = tbxDetailMnForeColor;
		location = new Point(185, 403);
		((Control)obj48).Location = location;
		((Control)tbxDetailMnForeColor).Name = "tbxDetailMnForeColor";
		((TextBoxBase)tbxDetailMnForeColor).ReadOnly = true;
		TextBox obj49 = tbxDetailMnForeColor;
		size = new Size(103, 20);
		((Control)obj49).Size = size;
		((Control)tbxDetailMnForeColor).TabIndex = 17;
		((Control)tbxDetailMnForeColor).Tag = "0";
		lblSubMnForeColor.AutoSize = true;
		Label obj50 = lblSubMnForeColor;
		location = new Point(32, 376);
		((Control)obj50).Location = location;
		((Control)lblSubMnForeColor).Name = "lblSubMnForeColor";
		Label obj51 = lblSubMnForeColor;
		size = new Size(112, 13);
		((Control)obj51).Size = size;
		((Control)lblSubMnForeColor).TabIndex = 197;
		lblSubMnForeColor.Text = "Màu chữ phân hệ con";
		TextBox obj52 = tbxSubMnForeColor;
		location = new Point(185, 373);
		((Control)obj52).Location = location;
		((Control)tbxSubMnForeColor).Name = "tbxSubMnForeColor";
		((TextBoxBase)tbxSubMnForeColor).ReadOnly = true;
		TextBox obj53 = tbxSubMnForeColor;
		size = new Size(103, 20);
		((Control)obj53).Size = size;
		((Control)tbxSubMnForeColor).TabIndex = 16;
		((Control)tbxSubMnForeColor).Tag = "0";
		lblWPanel.AutoSize = true;
		Label obj54 = lblWPanel;
		location = new Point(32, 110);
		((Control)obj54).Location = location;
		((Control)lblWPanel).Name = "lblWPanel";
		Label obj55 = lblWPanel;
		size = new Size(114, 13);
		((Control)obj55).Size = size;
		((Control)lblWPanel).TabIndex = 192;
		lblWPanel.Text = "Độ rộng bảng phân hệ";
		TextBox obj56 = tbxMnSelectedColor;
		location = new Point(185, 213);
		((Control)obj56).Location = location;
		((Control)tbxMnSelectedColor).Name = "tbxMnSelectedColor";
		((TextBoxBase)tbxMnSelectedColor).ReadOnly = true;
		TextBox obj57 = tbxMnSelectedColor;
		size = new Size(103, 20);
		((Control)obj57).Size = size;
		((Control)tbxMnSelectedColor).TabIndex = 5;
		((Control)tbxMnSelectedColor).Tag = "0";
		lbMnSlFColor.AutoSize = true;
		Label obj58 = lbMnSlFColor;
		location = new Point(32, 216);
		((Control)obj58).Location = location;
		((Control)lbMnSlFColor).Name = "lbMnSlFColor";
		Label obj59 = lbMnSlFColor;
		size = new Size(146, 13);
		((Control)obj59).Size = size;
		((Control)lbMnSlFColor).TabIndex = 196;
		lbMnSlFColor.Text = "Màu chữ phân hệ đang chọn";
		lblForeColor.AutoSize = true;
		Label obj60 = lblForeColor;
		location = new Point(32, 164);
		((Control)obj60).Location = location;
		((Control)lblForeColor).Name = "lblForeColor";
		Label obj61 = lblForeColor;
		size = new Size(91, 13);
		((Control)obj61).Size = size;
		((Control)lblForeColor).TabIndex = 195;
		lblForeColor.Text = "Màu chữ phân hệ";
		lblFont.AutoSize = true;
		Label obj62 = lblFont;
		location = new Point(32, 241);
		((Control)obj62).Location = location;
		((Control)lblFont).Name = "lblFont";
		Label obj63 = lblFont;
		size = new Size(91, 13);
		((Control)obj63).Size = size;
		((Control)lblFont).TabIndex = 191;
		lblFont.Text = "Kiểu chữ phân hệ";
		TextBox obj64 = tbxBgColor;
		location = new Point(185, 186);
		((Control)obj64).Location = location;
		((Control)tbxBgColor).Name = "tbxBgColor";
		((TextBoxBase)tbxBgColor).ReadOnly = true;
		TextBox obj65 = tbxBgColor;
		size = new Size(103, 20);
		((Control)obj65).Size = size;
		((Control)tbxBgColor).TabIndex = 4;
		((Control)tbxBgColor).Tag = "0";
		TextBox obj66 = tbxFont;
		location = new Point(185, 238);
		((Control)obj66).Location = location;
		((Control)tbxFont).Name = "tbxFont";
		((TextBoxBase)tbxFont).ReadOnly = true;
		TextBox obj67 = tbxFont;
		size = new Size(243, 20);
		((Control)obj67).Size = size;
		((Control)tbxFont).TabIndex = 6;
		((Control)tbxFont).Tag = "1";
		lblMnBckClr.AutoSize = true;
		Label obj68 = lblMnBckClr;
		location = new Point(32, 189);
		((Control)obj68).Location = location;
		((Control)lblMnBckClr).Name = "lblMnBckClr";
		Label obj69 = lblMnBckClr;
		size = new Size(134, 13);
		((Control)obj69).Size = size;
		((Control)lblMnBckClr).TabIndex = 190;
		lblMnBckClr.Text = "Màu nền phân hệ hiện thời";
		cbxMnType.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cbxMnType).FormattingEnabled = true;
		cbxMnType.Items.AddRange(new object[2] { "Tree", "Docking Menu" });
		ComboBox obj70 = cbxMnType;
		location = new Point(185, 27);
		((Control)obj70).Location = location;
		((Control)cbxMnType).Name = "cbxMnType";
		ComboBox obj71 = cbxMnType;
		size = new Size(103, 21);
		((Control)obj71).Size = size;
		((Control)cbxMnType).TabIndex = 0;
		TextBox obj72 = tbxWColumn;
		location = new Point(185, 455);
		((Control)obj72).Location = location;
		((Control)tbxWColumn).Name = "tbxWColumn";
		TextBox obj73 = tbxWColumn;
		size = new Size(103, 20);
		((Control)obj73).Size = size;
		((Control)tbxWColumn).TabIndex = 19;
		lblMenuType.AutoSize = true;
		((Control)lblMenuType).ForeColor = Color.Black;
		Label obj74 = lblMenuType;
		location = new Point(32, 27);
		((Control)obj74).Location = location;
		((Control)lblMenuType).Name = "lblMenuType";
		Label obj75 = lblMenuType;
		size = new Size(57, 13);
		((Control)obj75).Size = size;
		((Control)lblMenuType).TabIndex = 188;
		lblMenuType.Text = "Kiểu menu";
		lblColumn.AutoSize = true;
		((Control)lblColumn).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj76 = lblColumn;
		location = new Point(32, 458);
		((Control)obj76).Location = location;
		((Control)lblColumn).Name = "lblColumn";
		Label obj77 = lblColumn;
		size = new Size(63, 13);
		((Control)obj77).Size = size;
		((Control)lblColumn).TabIndex = 189;
		lblColumn.Text = "Độ rộng cột";
		lblSubMnFont.AutoSize = true;
		Label obj78 = lblSubMnFont;
		location = new Point(32, 350);
		((Control)obj78).Location = location;
		((Control)lblSubMnFont).Name = "lblSubMnFont";
		Label obj79 = lblSubMnFont;
		size = new Size(112, 13);
		((Control)obj79).Size = size;
		((Control)lblSubMnFont).TabIndex = 194;
		lblSubMnFont.Text = "Kiểu chữ phân hệ con";
		lblLabelForeColor.AutoSize = true;
		Label obj80 = lblLabelForeColor;
		location = new Point(32, 321);
		((Control)obj80).Location = location;
		((Control)lblLabelForeColor).Name = "lblLabelForeColor";
		Label obj81 = lblLabelForeColor;
		size = new Size(131, 13);
		((Control)obj81).Size = size;
		((Control)lblLabelForeColor).TabIndex = 193;
		lblLabelForeColor.Text = "Màu tên phân hệ hiện thời";
		TextBox obj82 = tbxSubMnFont;
		location = new Point(185, 347);
		((Control)obj82).Location = location;
		((Control)tbxSubMnFont).Name = "tbxSubMnFont";
		((TextBoxBase)tbxSubMnFont).ReadOnly = true;
		TextBox obj83 = tbxSubMnFont;
		size = new Size(243, 20);
		((Control)obj83).Size = size;
		((Control)tbxSubMnFont).TabIndex = 15;
		((Control)tbxSubMnFont).Tag = "1";
		TextBox obj84 = tbxLbForeColor;
		location = new Point(185, 318);
		((Control)obj84).Location = location;
		((Control)tbxLbForeColor).Name = "tbxLbForeColor";
		((TextBoxBase)tbxLbForeColor).ReadOnly = true;
		TextBox obj85 = tbxLbForeColor;
		size = new Size(103, 20);
		((Control)obj85).Size = size;
		((Control)tbxLbForeColor).TabIndex = 14;
		((Control)tbxLbForeColor).Tag = "0";
		cboThemes.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboThemes).FormattingEnabled = true;
		cboThemes.Items.AddRange(new object[2] { "Tree", "Docking Menu" });
		ComboBox obj86 = cboThemes;
		location = new Point(198, 23);
		((Control)obj86).Location = location;
		((Control)cboThemes).Name = "cboThemes";
		ComboBox obj87 = cboThemes;
		size = new Size(103, 21);
		((Control)obj87).Size = size;
		((Control)cboThemes).TabIndex = 1;
		Label17.AutoSize = true;
		((Control)Label17).ForeColor = Color.Black;
		Label label31 = Label17;
		location = new Point(45, 23);
		((Control)label31).Location = location;
		((Control)Label17).Name = "Label17";
		Label label32 = Label17;
		size = new Size(91, 13);
		((Control)label32).Size = size;
		((Control)Label17).TabIndex = 0;
		Label17.Text = "Danh sách theme";
		((Control)cmdUse).Enabled = false;
		Button obj88 = cmdUse;
		location = new Point(307, 21);
		((Control)obj88).Location = location;
		((Control)cmdUse).Name = "cmdUse";
		Button obj89 = cmdUse;
		size = new Size(75, 23);
		((Control)obj89).Size = size;
		((Control)cmdUse).TabIndex = 2;
		((ButtonBase)cmdUse).Text = "Áp dụng";
		((ButtonBase)cmdUse).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(870, 598);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)grbProperty);
		((Control)this).Controls.Add((Control)(object)cboThemes);
		((Control)this).Controls.Add((Control)(object)cmdUse);
		((Control)this).Controls.Add((Control)(object)Label17);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Name = "frmSITheme";
		((Form)this).Text = "Thiết lập thuộc tính menu";
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)ctMenuTool).ResumeLayout(false);
		((Control)grbProperty).ResumeLayout(false);
		((Control)grbProperty).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmSITheme_Shown(object sender, EventArgs e)
	{
		if (!isLoadOk)
		{
			((Form)this).Close();
		}
		isLoading = false;
	}

	private void frmSITheme_Load(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		xmldoc = new XmlDocument();
		string text = SystemInformations.XMLPath + "/Theme.xml";
		if (File.Exists(text))
		{
			xmldoc.Load(text);
			XmlNodeReader reader = new XmlNodeReader((XmlNode)(object)xmldoc);
			dsTheme = new DataSet();
			_hstThemeConfig = new Hashtable();
			dsTheme.ReadXml((XmlReader?)(object)reader);
			currentTheme = ClientConfiguration.Theme;
			bool flag = true;
			foreach (DataTable table in dsTheme.Tables)
			{
				if (Operators.CompareString(table.TableName, currentTheme, false) == 0)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				currentTheme = "Default";
			}
			EditTheme = currentTheme;
			GetThemeConfigByName(currentTheme);
			LoadStartupConfig();
			LoadThemeList();
			((ListControl)cboThemes).SelectedValue = currentTheme;
			ProcessAddEvent();
			isLoadOk = true;
		}
		else
		{
			isLoadOk = false;
			CMessageBox.ShowWithFormat(50110, new object[1] { text });
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		try
		{
			SaveStartUpConfig();
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

	private void frmSITheme_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Component)(object)this).Dispose();
		}
		if ((e.Control && (int)e.KeyCode == 82) ? true : false)
		{
			((ToolStripItem)RestartToolStripMenuItem).PerformClick();
		}
	}

	private void cmdReset_Click(object sender, EventArgs e)
	{
		GetThemeConfigByName("Default");
		LoadStartupConfig();
	}

	private void cmdUse_Click(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(newTheme, "", false) != 0)
		{
			CMessageBox.Show("Theme mới chưa lưu, không thể sử dụng !");
			return;
		}
		Configuration val = ConfigurationManager.OpenExeConfiguration((ConfigurationUserLevel)0);
		val.AppSettings.Settings.Remove("Theme");
		val.AppSettings.Settings.Add("Theme", ((ListControl)cboThemes).SelectedValue.ToString());
		((ConfigurationSection)val.AppSettings).SectionInformation.ForceSave = true;
		val.Save((ConfigurationSaveMode)0);
		ConfigurationManager.RefreshSection("appSettings");
		CMessageBox.Show(50015);
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

	private void cboThemes_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!isLoading)
		{
			EditTheme = ((ListControl)cboThemes).SelectedValue.ToString();
			GetThemeConfigByName(EditTheme);
			LoadStartupConfig();
			if (Operators.CompareString(currentTheme, ((ListControl)cboThemes).SelectedValue.ToString(), false) == 0)
			{
				((Control)cmdUse).Enabled = false;
			}
			else
			{
				((Control)cmdUse).Enabled = true;
			}
		}
	}

	private void cmdAdd_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		frmSIThemeInputName frmSIThemeInputName = new frmSIThemeInputName();
		((Form)frmSIThemeInputName).ShowDialog();
		if (frmSIThemeInputName.isOk)
		{
			string f_sName = frmSIThemeInputName.f_sName;
			DataTable dataTable = new DataTable();
			dataTable = dsTheme.Tables["Default"].Clone();
			dataTable.ImportRow(dsTheme.Tables["Default"].Rows[0]);
			dataTable.TableName = f_sName;
			dsTheme.Tables.Add(dataTable);
			LoadThemeList();
			((ListControl)cboThemes).SelectedValue = f_sName;
			GetThemeConfigByName(f_sName);
			LoadStartupConfig();
			EditTheme = f_sName;
			newTheme = f_sName;
		}
	}

	private void cmdDel_Click(object sender, EventArgs e)
	{
		dsTheme.Tables.Remove(EditTheme);
		LoadThemeList();
		EditTheme = Conversions.ToString(((ListControl)cboThemes).SelectedValue);
		GetThemeConfigByName(EditTheme);
		LoadStartupConfig();
	}

	private void SaveStartUpConfig()
	{
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected I4, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected I4, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected I4, but got Unknown
		try
		{
			DataRow dataRow = dsTheme.Tables[EditTheme].Rows[0];
			dataRow["MENU_TYPE"] = checked(cbxMnType.SelectedIndex + 1).ToString();
			dataRow["X_COLUMN2"] = tbxWColumn.Text;
			dataRow["MODULE_PANEL_MAX_WIDTH"] = tbxWPanel.Text;
			Color backColor = ((TextBoxBase)tbxBgColor).BackColor;
			dataRow["MODULE_MENU_BACK_COLOR"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			backColor = ((TextBoxBase)tbxLeftColor).BackColor;
			dataRow["LEFT_MENU_BACK_COLOR"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			backColor = ((TextBoxBase)tbxForeColor).BackColor;
			dataRow["MODULE_MENU_FORE_COLOR"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			backColor = ((TextBoxBase)tbxMnSelectedColor).BackColor;
			dataRow["MODULE_MENU_SELECTED_FORE_COLOR"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			backColor = ((TextBoxBase)tbxLbForeColor).BackColor;
			dataRow["CURRENT_MODULE_LABEL_FORE_COLOR"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			backColor = ((TextBoxBase)tbxSubMnForeColor).BackColor;
			dataRow["SUB_MENU_FORE_COLOR"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			backColor = ((TextBoxBase)tbxDetailMnForeColor).BackColor;
			dataRow["DETAIL_MENU_FORE_COLOR"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			dataRow["MODULE_MENU_FONT"] = ((Control)tbxFont).Font.Name + "," + ((Control)tbxFont).Font.Size + "," + int.Parse(Conversions.ToString((int)((Control)tbxFont).Font.Style));
			dataRow["SUB_MENU_FONT"] = ((Control)tbxSubMnFont).Font.Name + "," + ((Control)tbxSubMnFont).Font.Size + "," + int.Parse(Conversions.ToString((int)((Control)tbxSubMnFont).Font.Style));
			dataRow["DETAIL_MENU_FONT"] = ((Control)tbDetailMnFont).Font.Name + "," + ((Control)tbDetailMnFont).Font.Size + "," + int.Parse(Conversions.ToString((int)((Control)tbDetailMnFont).Font.Style));
			backColor = ((TextBoxBase)txtCT_BakgroundColorName).BackColor;
			dataRow["CT_BakgroundColorName"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			backColor = ((TextBoxBase)txtCT_AlternatingBackColorName).BackColor;
			dataRow["CT_AlternatingBackColorName"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			backColor = ((TextBoxBase)txtDM_BakgroundColorName).BackColor;
			dataRow["DM_BakgroundColorName"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			backColor = ((TextBoxBase)txtDM_AlternatingBackColorName).BackColor;
			dataRow["DM_AlternatingBackColorName"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			backColor = ((TextBoxBase)txtBC_BakgroundColorName).BackColor;
			dataRow["BC_BakgroundColorName"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			backColor = ((TextBoxBase)txtBC_AlternatingBackColorName).BackColor;
			dataRow["BC_AlternatingBackColorName"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			backColor = ((TextBoxBase)txtAsTextBox_BakgroundColorName).BackColor;
			dataRow["AsTextBox_BakgroundColorName"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(backColor.IsKnownColor, (object)backColor.Name, (object)("#" + backColor.Name)));
			FileStream fileStream = new FileStream(SystemInformations.XMLPath + "/Theme.xml", FileMode.Create);
			dsTheme.WriteXml((Stream?)fileStream);
			fileStream.Flush();
			fileStream.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			CMessageBox.Show(99999);
			ProjectData.ClearProjectError();
		}
		newTheme = "";
	}

	private void LoadThemeList()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		BindingSource val = new BindingSource();
		Hashtable hashtable = new Hashtable();
		foreach (DataTable table in dsTheme.Tables)
		{
			hashtable.Add(table.TableName, table.TableName);
		}
		val.DataSource = hashtable;
		cboThemes.DataSource = val;
		((ListControl)cboThemes).ValueMember = "Key";
		((ListControl)cboThemes).DisplayMember = "Value";
	}

	private void GetThemeConfigByName(string name)
	{
		_hstThemeConfig.Clear();
		DataTable dataTable = dsTheme.Tables[name];
		foreach (DataColumn column in dataTable.Columns)
		{
			_hstThemeConfig.Add(column.ColumnName, RuntimeHelpers.GetObjectValue(dataTable.Rows[0][column.ColumnName]));
		}
	}

	private void LoadStartupConfig()
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected I4, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected I4, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected I4, but got Unknown
		KeyValue keyValue = new KeyValue(_hstThemeConfig);
		cbxMnType.Text = keyValue.MENU_TYPE;
		tbxWColumn.Text = keyValue.X_COLUMN2.ToString();
		tbxWPanel.Text = keyValue.MODULE_PANEL_MAX_WIDTH.ToString();
		((TextBoxBase)tbxBgColor).BackColor = keyValue.MODULE_MENU_BACK_COLOR;
		((TextBoxBase)tbxLeftColor).BackColor = keyValue.LEFT_MENU_BACK_COLOR;
		((TextBoxBase)tbxForeColor).BackColor = keyValue.MODULE_MENU_FORE_COLOR;
		((TextBoxBase)tbxMnSelectedColor).BackColor = keyValue.MODULE_MENU_SELECTED_FORE_COLOR;
		((TextBoxBase)tbxLbForeColor).BackColor = keyValue.CURRENT_MODULE_LABEL_FORE_COLOR;
		((TextBoxBase)tbxSubMnForeColor).BackColor = keyValue.SUB_MENU_FORE_COLOR;
		((TextBoxBase)tbxDetailMnForeColor).BackColor = keyValue.DETAIL_MENU_FORE_COLOR;
		tbxFont.Text = keyValue.MODULE_MENU_FONT.Name + "," + keyValue.MODULE_MENU_FONT.Size + "," + int.Parse(Conversions.ToString((int)keyValue.MODULE_MENU_FONT.Style));
		((Control)tbxFont).Font = keyValue.MODULE_MENU_FONT;
		tbxSubMnFont.Text = keyValue.SUB_MENU_FONT.Name + "," + keyValue.SUB_MENU_FONT.Size + "," + int.Parse(Conversions.ToString((int)keyValue.SUB_MENU_FONT.Style));
		((Control)tbxSubMnFont).Font = keyValue.SUB_MENU_FONT;
		tbDetailMnFont.Text = keyValue.DETAIL_MENU_FONT.Name + "," + keyValue.DETAIL_MENU_FONT.Size + "," + int.Parse(Conversions.ToString((int)keyValue.DETAIL_MENU_FONT.Style));
		((Control)tbDetailMnFont).Font = keyValue.DETAIL_MENU_FONT;
		txtServiceUri.Text = keyValue.ServiceUri;
		((TextBoxBase)txtCT_BakgroundColorName).BackColor = keyValue.CT_BakgroundColorName;
		((TextBoxBase)txtCT_AlternatingBackColorName).BackColor = keyValue.CT_AlternatingBackColorName;
		((TextBoxBase)txtDM_BakgroundColorName).BackColor = keyValue.DM_BakgroundColorName;
		((TextBoxBase)txtDM_AlternatingBackColorName).BackColor = keyValue.DM_AlternatingBackColorName;
		((TextBoxBase)txtBC_BakgroundColorName).BackColor = keyValue.BC_BakgroundColorName;
		((TextBoxBase)txtBC_AlternatingBackColorName).BackColor = keyValue.BC_AlternatingBackColorName;
		((TextBoxBase)txtAsTextBox_BakgroundColorName).BackColor = keyValue.AsTextBox_BakgroundColorName;
		txtEscapeCharacters.Text = keyValue.EscapeCharacters;
		txtField2CarryInReport.Text = keyValue.Field2CarryInReport;
	}

	private void ProcessAddEvent()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		IEnumerable<Control> enumerable = from ctl in ((IEnumerable)((Control)grbProperty).Controls).Cast<object>().Select((Func<object, Control>)([SpecialName] (object ctl) => (Control)ctl))
			where Conversions.ToBoolean((!Conversions.ToBoolean((object)((object)((object)ctl).GetType() == typeof(TextBox))) || !Conversions.ToBoolean(Operators.CompareObjectNotEqual(ctl.Tag, (object)string.Empty, false))) ? ((object)false) : ((object)true))
			select (ctl);
		if (enumerable == null)
		{
			return;
		}
		foreach (TextBox item in enumerable)
		{
			TextBox val = item;
			string text = ((Control)val).Tag.ToString();
			if (Operators.CompareString(text, Conversions.ToString(0), false) == 0)
			{
				((TextBoxBase)val).MouseClick += new MouseEventHandler(TextBoxColor_Click);
			}
			else if (Operators.CompareString(text, Conversions.ToString(1), false) == 0)
			{
				((TextBoxBase)val).MouseClick += new MouseEventHandler(TextBoxFont_Click);
			}
		}
	}

	private void ProcessColorBoxClick(TextBox _TextBox)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		OpenListBoxColors openListBoxColors = new OpenListBoxColors();
		((Form)openListBoxColors).Location = Cursor.Position;
		((Form)openListBoxColors).ShowDialog();
		if (openListBoxColors.isOke)
		{
			((TextBoxBase)_TextBox).BackColor = openListBoxColors.color_;
		}
	}

	private void ProcessFontBoxClick(TextBox _TextBox)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected I4, but got Unknown
		if ((int)((CommonDialog)fontDialog).ShowDialog((IWin32Window)(object)this) == 1)
		{
			_TextBox.Text = fontDialog.Font.Name + "," + fontDialog.Font.Size + "," + int.Parse(Conversions.ToString((int)fontDialog.Font.Style));
			((Control)_TextBox).Font = fontDialog.Font;
		}
	}

	private void TextBoxColor_Click(object sender, MouseEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		ProcessColorBoxClick((TextBox)sender);
	}

	private void TextBoxFont_Click(object sender, MouseEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		ProcessFontBoxClick((TextBox)sender);
	}
}
