using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCODMBOM : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("gbTTChung")]
	private GroupBox _gbTTChung;

	[AccessedThroughProperty("gbChiTiet")]
	private GroupBox _gbChiTiet;

	[AccessedThroughProperty("txtMa_sp")]
	private AsTextBox _txtMa_sp;

	[AccessedThroughProperty("lblMa_sp")]
	private Label _lblMa_sp;

	[AccessedThroughProperty("lblTen_sp")]
	private Label _lblTen_sp;

	[AccessedThroughProperty("txtGhi_Chu")]
	private TextBox _txtGhi_Chu;

	[AccessedThroughProperty("txtDon_gia_luong")]
	private AsTextNumeric _txtDon_gia_luong;

	[AccessedThroughProperty("txtEDate")]
	private AsMaskedTextBox _txtEDate;

	[AccessedThroughProperty("txtSDate")]
	private AsMaskedTextBox _txtSDate;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("lblGhi_chu")]
	private Label _lblGhi_chu;

	[AccessedThroughProperty("lblDon_gia")]
	private Label _lblDon_gia;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtSo_luong")]
	private AsTextNumeric _txtSo_luong;

	[AccessedThroughProperty("lblQuantity")]
	private Label _lblQuantity;

	[AccessedThroughProperty("cmdDelCT")]
	private Button _cmdDelCT;

	[AccessedThroughProperty("cmdAddCT")]
	private Button _cmdAddCT;

	[AccessedThroughProperty("chkVt_chinh")]
	private AsCheckBox _chkVt_chinh;

	[AccessedThroughProperty("dgvCTVT")]
	private AsDataGridView _dgvCTVT;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("cmdDel")]
	private Button _cmdDel;

	[AccessedThroughProperty("cmdEdit")]
	private Button _cmdEdit;

	[AccessedThroughProperty("gbLine")]
	private GroupBox _gbLine;

	[AccessedThroughProperty("epError")]
	private ErrorProvider _epError;

	[AccessedThroughProperty("cmdExit")]
	private Button _cmdExit;

	[AccessedThroughProperty("mnuFilter")]
	private ContextMenuStrip _mnuFilter;

	[AccessedThroughProperty("cmdFilter")]
	private ToolStripMenuItem _cmdFilter;

	[AccessedThroughProperty("cmdSearch")]
	private ToolStripMenuItem _cmdSearch;

	[AccessedThroughProperty("txtSearch")]
	private TextBox _txtSearch;

	[AccessedThroughProperty("lblTen")]
	private Label _lblTen;

	[AccessedThroughProperty("cboFilter")]
	private ComboBox _cboFilter;

	[AccessedThroughProperty("lblMen")]
	private Label _lblMen;

	[AccessedThroughProperty("gbDmSp")]
	private GroupBox _gbDmSp;

	[AccessedThroughProperty("dgvListVt")]
	private AsDataGridView _dgvListVt;

	[AccessedThroughProperty("cmdFind")]
	private Button _cmdFind;

	[AccessedThroughProperty("colMa_vt")]
	private DataGridViewTextBoxColumn _colMa_vt;

	[AccessedThroughProperty("colTen_vt")]
	private DataGridViewTextBoxColumn _colTen_vt;

	[AccessedThroughProperty("colSo_luong")]
	private DataGridViewAsTextNumericColumn _colSo_luong;

	[AccessedThroughProperty("colVTC")]
	private DataGridViewCheckBoxColumn _colVTC;

	[AccessedThroughProperty("dgvcMa_SPCT")]
	private DataGridViewTextBoxColumn _dgvcMa_SPCT;

	[AccessedThroughProperty("dgvcTen_SPCT")]
	private DataGridViewTextBoxColumn _dgvcTen_SPCT;

	private DataTable f_tblBomPH;

	private DataTable f_tblBomCT;

	private bool f_Edit;

	private DataRow f_row;

	private bool f_isEditing;

	private int iCurrentRow;

	private int iCurrentCol;

	private bool bLoop;

	private string ADD_TEXT;

	private string CANCEL_TEXT;

	private string EDIT_TEXT;

	private string SAVE_TEXT;

	internal virtual GroupBox gbTTChung
	{
		get
		{
			return _gbTTChung;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_gbTTChung = value;
		}
	}

	internal virtual GroupBox gbChiTiet
	{
		get
		{
			return _gbChiTiet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_gbChiTiet = value;
		}
	}

	internal virtual AsTextBox txtMa_sp
	{
		get
		{
			return _txtMa_sp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_sp = value;
		}
	}

	internal virtual Label lblMa_sp
	{
		get
		{
			return _lblMa_sp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_sp = value;
		}
	}

	internal virtual Label lblTen_sp
	{
		get
		{
			return _lblTen_sp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_sp = value;
		}
	}

	internal virtual TextBox txtGhi_Chu
	{
		get
		{
			return _txtGhi_Chu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGhi_Chu = value;
		}
	}

	internal virtual AsTextNumeric txtDon_gia_luong
	{
		get
		{
			return _txtDon_gia_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtDon_gia_luong = value;
		}
	}

	internal virtual AsMaskedTextBox txtEDate
	{
		get
		{
			return _txtEDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtEDate = value;
		}
	}

	internal virtual AsMaskedTextBox txtSDate
	{
		get
		{
			return _txtSDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSDate = value;
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

	internal virtual Label lblGhi_chu
	{
		get
		{
			return _lblGhi_chu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblGhi_chu = value;
		}
	}

	internal virtual Label lblDon_gia
	{
		get
		{
			return _lblDon_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblDon_gia = value;
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

	internal virtual AsTextBox txtMa_vt
	{
		get
		{
			return _txtMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_vt = value;
		}
	}

	internal virtual Label lblTen_vt
	{
		get
		{
			return _lblTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_vt = value;
		}
	}

	internal virtual Label lblMa_vt
	{
		get
		{
			return _lblMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_vt = value;
		}
	}

	internal virtual AsTextNumeric txtSo_luong
	{
		get
		{
			return _txtSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_luong = value;
		}
	}

	internal virtual Label lblQuantity
	{
		get
		{
			return _lblQuantity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblQuantity = value;
		}
	}

	internal virtual Button cmdDelCT
	{
		get
		{
			return _cmdDelCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdDelCT_Click;
			if (_cmdDelCT != null)
			{
				((Control)_cmdDelCT).Click -= eventHandler;
			}
			_cmdDelCT = value;
			if (_cmdDelCT != null)
			{
				((Control)_cmdDelCT).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdAddCT
	{
		get
		{
			return _cmdAddCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdAddCT_Click;
			if (_cmdAddCT != null)
			{
				((Control)_cmdAddCT).Click -= eventHandler;
			}
			_cmdAddCT = value;
			if (_cmdAddCT != null)
			{
				((Control)_cmdAddCT).Click += eventHandler;
			}
		}
	}

	internal virtual AsCheckBox chkVt_chinh
	{
		get
		{
			return _chkVt_chinh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkVt_chinh = value;
		}
	}

	internal virtual AsDataGridView dgvCTVT
	{
		get
		{
			return _dgvCTVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(dgvCTVT_RowEnter);
			if (_dgvCTVT != null)
			{
				((DataGridView)_dgvCTVT).RowEnter -= val;
			}
			_dgvCTVT = value;
			if (_dgvCTVT != null)
			{
				((DataGridView)_dgvCTVT).RowEnter += val;
			}
		}
	}

	internal virtual Button cmdAdd
	{
		get
		{
			return _cmdAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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
		get
		{
			return _cmdDel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual Button cmdEdit
	{
		get
		{
			return _cmdEdit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdEdit_Click;
			if (_cmdEdit != null)
			{
				((Control)_cmdEdit).Click -= eventHandler;
			}
			_cmdEdit = value;
			if (_cmdEdit != null)
			{
				((Control)_cmdEdit).Click += eventHandler;
			}
		}
	}

	internal virtual GroupBox gbLine
	{
		get
		{
			return _gbLine;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_gbLine = value;
		}
	}

	internal virtual ErrorProvider epError
	{
		get
		{
			return _epError;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_epError = value;
		}
	}

	internal virtual Button cmdExit
	{
		get
		{
			return _cmdExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdExit_Click;
			if (_cmdExit != null)
			{
				((Control)_cmdExit).Click -= eventHandler;
			}
			_cmdExit = value;
			if (_cmdExit != null)
			{
				((Control)_cmdExit).Click += eventHandler;
			}
		}
	}

	internal virtual ContextMenuStrip mnuFilter
	{
		get
		{
			return _mnuFilter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnuFilter = value;
		}
	}

	internal virtual ToolStripMenuItem cmdFilter
	{
		get
		{
			return _cmdFilter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cmdFilter = value;
		}
	}

	internal virtual ToolStripMenuItem cmdSearch
	{
		get
		{
			return _cmdSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cmdSearch = value;
		}
	}

	internal virtual TextBox txtSearch
	{
		get
		{
			return _txtSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSearch = value;
		}
	}

	internal virtual Label lblTen
	{
		get
		{
			return _lblTen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen = value;
		}
	}

	internal virtual ComboBox cboFilter
	{
		get
		{
			return _cboFilter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboFilter = value;
		}
	}

	internal virtual Label lblMen
	{
		get
		{
			return _lblMen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMen = value;
		}
	}

	internal virtual GroupBox gbDmSp
	{
		get
		{
			return _gbDmSp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_gbDmSp = value;
		}
	}

	internal virtual AsDataGridView dgvListVt
	{
		get
		{
			return _dgvListVt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = dgvListVt_SelectionChanged;
			if (_dgvListVt != null)
			{
				((DataGridView)_dgvListVt).SelectionChanged -= eventHandler;
			}
			_dgvListVt = value;
			if (_dgvListVt != null)
			{
				((DataGridView)_dgvListVt).SelectionChanged += eventHandler;
			}
		}
	}

	internal virtual Button cmdFind
	{
		get
		{
			return _cmdFind;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdFind_Click;
			if (_cmdFind != null)
			{
				((Control)_cmdFind).Click -= eventHandler;
			}
			_cmdFind = value;
			if (_cmdFind != null)
			{
				((Control)_cmdFind).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn colMa_vt
	{
		get
		{
			return _colMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colMa_vt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colTen_vt
	{
		get
		{
			return _colTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTen_vt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn colSo_luong
	{
		get
		{
			return _colSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colSo_luong = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colVTC
	{
		get
		{
			return _colVTC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colVTC = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_SPCT
	{
		get
		{
			return _dgvcMa_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcMa_SPCT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_SPCT
	{
		get
		{
			return _dgvcTen_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcTen_SPCT = value;
		}
	}

	public frmCODMBOM(string MenuID)
		: base(MenuID)
	{
		((Form)this).Load += frmCODMBOM_Load;
		((Form)this).Shown += frmCODMBOM_Shown;
		f_tblBomPH = new DataTable();
		f_tblBomCT = new DataTable();
		f_Edit = false;
		f_isEditing = false;
		iCurrentRow = 9;
		iCurrentCol = 9;
		bLoop = false;
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Expected O, but got Unknown
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Expected O, but got Unknown
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Expected O, but got Unknown
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected O, but got Unknown
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected O, but got Unknown
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected O, but got Unknown
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected O, but got Unknown
		//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd3: Expected O, but got Unknown
		//IL_0c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6a: Expected O, but got Unknown
		//IL_0cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfb: Expected O, but got Unknown
		//IL_0d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Expected O, but got Unknown
		//IL_0dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Expected O, but got Unknown
		//IL_0de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dea: Expected O, but got Unknown
		//IL_0e9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea6: Expected O, but got Unknown
		//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6c: Expected O, but got Unknown
		//IL_0ff5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fff: Expected O, but got Unknown
		//IL_1071: Unknown result type (might be due to invalid IL or missing references)
		//IL_107b: Expected O, but got Unknown
		//IL_1139: Unknown result type (might be due to invalid IL or missing references)
		//IL_1143: Expected O, but got Unknown
		//IL_11bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c5: Expected O, but got Unknown
		//IL_12b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bf: Expected O, but got Unknown
		//IL_136a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1374: Expected O, but got Unknown
		//IL_1433: Unknown result type (might be due to invalid IL or missing references)
		//IL_143d: Expected O, but got Unknown
		//IL_1750: Unknown result type (might be due to invalid IL or missing references)
		//IL_175a: Expected O, but got Unknown
		//IL_1811: Unknown result type (might be due to invalid IL or missing references)
		//IL_181b: Expected O, but got Unknown
		//IL_18ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d8: Expected O, but got Unknown
		//IL_1a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0b: Expected O, but got Unknown
		//IL_1c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c53: Expected O, but got Unknown
		//IL_1c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d67: Expected O, but got Unknown
		//IL_1e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e60: Expected O, but got Unknown
		//IL_1fe4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fee: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmCODMBOM));
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
		gbTTChung = new GroupBox();
		txtGhi_Chu = new TextBox();
		txtDon_gia_luong = new AsTextNumeric();
		txtEDate = new AsMaskedTextBox();
		txtSDate = new AsMaskedTextBox();
		txtMa_sp = new AsTextBox();
		lblTen_sp = new Label();
		Label2 = new Label();
		lblGhi_chu = new Label();
		lblDon_gia = new Label();
		Label1 = new Label();
		lblMa_sp = new Label();
		gbChiTiet = new GroupBox();
		lblMen = new Label();
		cmdDelCT = new Button();
		cmdAddCT = new Button();
		chkVt_chinh = new AsCheckBox();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		txtSo_luong = new AsTextNumeric();
		lblMa_vt = new Label();
		lblQuantity = new Label();
		dgvCTVT = new AsDataGridView();
		colMa_vt = new DataGridViewTextBoxColumn();
		colTen_vt = new DataGridViewTextBoxColumn();
		colSo_luong = new DataGridViewAsTextNumericColumn();
		colVTC = new DataGridViewCheckBoxColumn();
		mnuFilter = new ContextMenuStrip(components);
		cmdFilter = new ToolStripMenuItem();
		cmdSearch = new ToolStripMenuItem();
		cmdAdd = new Button();
		cmdDel = new Button();
		cmdEdit = new Button();
		gbLine = new GroupBox();
		epError = new ErrorProvider(components);
		cmdExit = new Button();
		txtSearch = new TextBox();
		cboFilter = new ComboBox();
		lblTen = new Label();
		gbDmSp = new GroupBox();
		dgvListVt = new AsDataGridView();
		dgvcMa_SPCT = new DataGridViewTextBoxColumn();
		dgvcTen_SPCT = new DataGridViewTextBoxColumn();
		cmdFind = new Button();
		((Control)gbTTChung).SuspendLayout();
		((Control)gbChiTiet).SuspendLayout();
		((ISupportInitialize)dgvCTVT).BeginInit();
		((Control)mnuFilter).SuspendLayout();
		((ISupportInitialize)epError).BeginInit();
		((Control)gbDmSp).SuspendLayout();
		((ISupportInitialize)dgvListVt).BeginInit();
		((Control)this).SuspendLayout();
		((Control)gbTTChung).Anchor = (AnchorStyles)9;
		((Control)gbTTChung).Controls.Add((Control)(object)txtGhi_Chu);
		((Control)gbTTChung).Controls.Add((Control)(object)txtDon_gia_luong);
		((Control)gbTTChung).Controls.Add((Control)(object)txtEDate);
		((Control)gbTTChung).Controls.Add((Control)(object)txtSDate);
		((Control)gbTTChung).Controls.Add((Control)(object)txtMa_sp);
		((Control)gbTTChung).Controls.Add((Control)(object)lblTen_sp);
		((Control)gbTTChung).Controls.Add((Control)(object)Label2);
		((Control)gbTTChung).Controls.Add((Control)(object)lblGhi_chu);
		((Control)gbTTChung).Controls.Add((Control)(object)lblDon_gia);
		((Control)gbTTChung).Controls.Add((Control)(object)Label1);
		((Control)gbTTChung).Controls.Add((Control)(object)lblMa_sp);
		((Control)gbTTChung).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		GroupBox obj = gbTTChung;
		Point location = new Point(381, 2);
		((Control)obj).Location = location;
		((Control)gbTTChung).Name = "gbTTChung";
		GroupBox obj2 = gbTTChung;
		Size size = new Size(587, 128);
		((Control)obj2).Size = size;
		((Control)gbTTChung).TabIndex = 0;
		gbTTChung.TabStop = false;
		gbTTChung.Text = "Thông tin chung";
		((Control)txtGhi_Chu).Font = new Font("Microsoft Sans Serif", 8.25f);
		TextBox obj3 = txtGhi_Chu;
		location = new Point(108, 96);
		((Control)obj3).Location = location;
		((Control)txtGhi_Chu).Name = "txtGhi_Chu";
		TextBox obj4 = txtGhi_Chu;
		size = new Size(410, 20);
		((Control)obj4).Size = size;
		((Control)txtGhi_Chu).TabIndex = 5;
		txtDon_gia_luong.DecimalSymbol = ".";
		((Control)txtDon_gia_luong).Font = new Font("Microsoft Sans Serif", 8.25f);
		txtDon_gia_luong.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtDon_gia_luong;
		location = new Point(108, 70);
		((Control)asTextNumeric).Location = location;
		txtDon_gia_luong.Mask = "### ### ### ###.##";
		((Control)txtDon_gia_luong).Name = "txtDon_gia_luong";
		AsTextNumeric asTextNumeric2 = txtDon_gia_luong;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		txtDon_gia_luong.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtDon_gia_luong).TabIndex = 3;
		((TextBox)txtDon_gia_luong).Text = "0.00";
		((TextBox)txtDon_gia_luong).TextAlign = (HorizontalAlignment)1;
		txtDon_gia_luong.Value = 0;
		((Control)txtEDate).Font = new Font("Microsoft Sans Serif", 8.25f);
		txtEDate.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtEDate).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtEDate;
		location = new Point(330, 44);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtEDate).Mask = "##/##/####";
		((Control)txtEDate).Name = "txtEDate";
		((MaskedTextBox)txtEDate).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtEDate;
		size = new Size(100, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtEDate).TabIndex = 2;
		((MaskedTextBox)txtEDate).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtEDate;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		((Control)txtSDate).Font = new Font("Microsoft Sans Serif", 8.25f);
		txtSDate.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtSDate).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtSDate;
		location = new Point(108, 44);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtSDate).Mask = "##/##/####";
		((Control)txtSDate).Name = "txtSDate";
		((MaskedTextBox)txtSDate).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtSDate;
		size = new Size(100, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtSDate).TabIndex = 1;
		((MaskedTextBox)txtSDate).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtSDate;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		txtMa_sp.AutoLookup = true;
		txtMa_sp.AutoValid = true;
		((TextBoxBase)txtMa_sp).BackColor = SystemColors.Info;
		((TextBox)txtMa_sp).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_sp).Font = new Font("Microsoft Sans Serif", 8.25f);
		AsTextBox asTextBox = txtMa_sp;
		location = new Point(108, 18);
		((Control)asTextBox).Location = location;
		txtMa_sp.LookupCodeName = "MA_SPCT";
		((Control)txtMa_sp).Name = "txtMa_sp";
		txtMa_sp.NameControl = lblTen_sp;
		AsTextBox asTextBox2 = txtMa_sp;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_sp).TabIndex = 0;
		txtMa_sp.UseAutoCompleteSource = true;
		((Control)lblTen_sp).Font = new Font("Microsoft Sans Serif", 8.25f);
		Label obj5 = lblTen_sp;
		location = new Point(214, 22);
		((Control)obj5).Location = location;
		((Control)lblTen_sp).Name = "lblTen_sp";
		Label obj6 = lblTen_sp;
		size = new Size(246, 13);
		((Control)obj6).Size = size;
		((Control)lblTen_sp).TabIndex = 0;
		Label2.AutoSize = true;
		((Control)Label2).Font = new Font("Microsoft Sans Serif", 8.25f);
		Label label = Label2;
		location = new Point(237, 48);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(74, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 0;
		Label2.Text = "Ngày kết thúc";
		lblGhi_chu.AutoSize = true;
		((Control)lblGhi_chu).Font = new Font("Microsoft Sans Serif", 8.25f);
		Label obj7 = lblGhi_chu;
		location = new Point(18, 100);
		((Control)obj7).Location = location;
		((Control)lblGhi_chu).Name = "lblGhi_chu";
		Label obj8 = lblGhi_chu;
		size = new Size(44, 13);
		((Control)obj8).Size = size;
		((Control)lblGhi_chu).TabIndex = 0;
		lblGhi_chu.Text = "Ghi chú";
		lblDon_gia.AutoSize = true;
		((Control)lblDon_gia).Font = new Font("Microsoft Sans Serif", 8.25f);
		Label obj9 = lblDon_gia;
		location = new Point(18, 74);
		((Control)obj9).Location = location;
		((Control)lblDon_gia).Name = "lblDon_gia";
		Label obj10 = lblDon_gia;
		size = new Size(73, 13);
		((Control)obj10).Size = size;
		((Control)lblDon_gia).TabIndex = 0;
		lblDon_gia.Text = "Đơn giá lương";
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Microsoft Sans Serif", 8.25f);
		Label label3 = Label1;
		location = new Point(18, 48);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(72, 13);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 0;
		Label1.Text = "Ngày bắt đầu";
		lblMa_sp.AutoSize = true;
		((Control)lblMa_sp).Font = new Font("Microsoft Sans Serif", 8.25f);
		Label obj11 = lblMa_sp;
		location = new Point(18, 22);
		((Control)obj11).Location = location;
		((Control)lblMa_sp).Name = "lblMa_sp";
		Label obj12 = lblMa_sp;
		size = new Size(71, 13);
		((Control)obj12).Size = size;
		((Control)lblMa_sp).TabIndex = 0;
		lblMa_sp.Text = "Mã sản phẩm";
		((Control)gbChiTiet).Anchor = (AnchorStyles)9;
		((Control)gbChiTiet).Controls.Add((Control)(object)lblMen);
		((Control)gbChiTiet).Controls.Add((Control)(object)cmdDelCT);
		((Control)gbChiTiet).Controls.Add((Control)(object)cmdAddCT);
		((Control)gbChiTiet).Controls.Add((Control)(object)chkVt_chinh);
		((Control)gbChiTiet).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbChiTiet).Controls.Add((Control)(object)txtSo_luong);
		((Control)gbChiTiet).Controls.Add((Control)(object)lblMa_vt);
		((Control)gbChiTiet).Controls.Add((Control)(object)lblTen_vt);
		((Control)gbChiTiet).Controls.Add((Control)(object)lblQuantity);
		((Control)gbChiTiet).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		GroupBox obj13 = gbChiTiet;
		location = new Point(381, 136);
		((Control)obj13).Location = location;
		((Control)gbChiTiet).Name = "gbChiTiet";
		GroupBox obj14 = gbChiTiet;
		size = new Size(587, 100);
		((Control)obj14).Size = size;
		((Control)gbChiTiet).TabIndex = 1;
		gbChiTiet.TabStop = false;
		gbChiTiet.Text = "Chi tiết";
		lblMen.AutoSize = true;
		((Control)lblMen).Font = new Font("Microsoft Sans Serif", 8.25f);
		Label obj15 = lblMen;
		location = new Point(210, 49);
		((Control)obj15).Location = location;
		((Control)lblMen).Name = "lblMen";
		Label obj16 = lblMen;
		size = new Size(31, 13);
		((Control)obj16).Size = size;
		((Control)lblMen).TabIndex = 5;
		lblMen.Text = "/Bao";
		((Control)lblMen).Visible = false;
		((Control)cmdDelCT).Enabled = false;
		((Control)cmdDelCT).Font = new Font("Microsoft Sans Serif", 8.25f);
		((ButtonBase)cmdDelCT).Image = (Image)componentResourceManager.GetObject("cmdDelCT.Image");
		((ButtonBase)cmdDelCT).ImageAlign = (ContentAlignment)16;
		Button obj17 = cmdDelCT;
		location = new Point(320, 43);
		((Control)obj17).Location = location;
		((Control)cmdDelCT).Name = "cmdDelCT";
		Button obj18 = cmdDelCT;
		size = new Size(64, 23);
		((Control)obj18).Size = size;
		((Control)cmdDelCT).TabIndex = 4;
		((ButtonBase)cmdDelCT).Text = "&Xóa";
		((ButtonBase)cmdDelCT).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdDelCT).UseVisualStyleBackColor = true;
		cmdAddCT.DialogResult = (DialogResult)2;
		((Control)cmdAddCT).Enabled = false;
		((Control)cmdAddCT).Font = new Font("Microsoft Sans Serif", 8.25f);
		((ButtonBase)cmdAddCT).Image = (Image)componentResourceManager.GetObject("cmdAddCT.Image");
		((ButtonBase)cmdAddCT).ImageAlign = (ContentAlignment)16;
		Button obj19 = cmdAddCT;
		location = new Point(250, 43);
		((Control)obj19).Location = location;
		((Control)cmdAddCT).Name = "cmdAddCT";
		Button obj20 = cmdAddCT;
		size = new Size(64, 23);
		((Control)obj20).Size = size;
		((Control)cmdAddCT).TabIndex = 3;
		((ButtonBase)cmdAddCT).Text = "&Thêm";
		((ButtonBase)cmdAddCT).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdAddCT).UseVisualStyleBackColor = true;
		((ButtonBase)chkVt_chinh).AutoSize = true;
		chkVt_chinh.Checked = false;
		((Control)chkVt_chinh).Font = new Font("Microsoft Sans Serif", 8.25f);
		AsCheckBox asCheckBox = chkVt_chinh;
		location = new Point(108, 72);
		((Control)asCheckBox).Location = location;
		((Control)chkVt_chinh).Name = "chkVt_chinh";
		AsCheckBox asCheckBox2 = chkVt_chinh;
		size = new Size(85, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkVt_chinh).TabIndex = 2;
		((ButtonBase)chkVt_chinh).Text = "Vật tư chính";
		chkVt_chinh.TextValue = "0";
		((ButtonBase)chkVt_chinh).UseVisualStyleBackColor = true;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = true;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_vt).Font = new Font("Microsoft Sans Serif", 8.25f);
		AsTextBox asTextBox3 = txtMa_vt;
		location = new Point(108, 19);
		((Control)asTextBox3).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox4 = txtMa_vt;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_vt).TabIndex = 0;
		txtMa_vt.UseAutoCompleteSource = true;
		((Control)lblTen_vt).Font = new Font("Microsoft Sans Serif", 8.25f);
		Label obj21 = lblTen_vt;
		location = new Point(222, 23);
		((Control)obj21).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj22 = lblTen_vt;
		size = new Size(238, 13);
		((Control)obj22).Size = size;
		((Control)lblTen_vt).TabIndex = 0;
		txtSo_luong.DecimalSymbol = ".";
		((Control)txtSo_luong).Font = new Font("Microsoft Sans Serif", 8.25f);
		txtSo_luong.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtSo_luong;
		location = new Point(108, 45);
		((Control)asTextNumeric3).Location = location;
		txtSo_luong.Mask = "### ### ### ###.##";
		((Control)txtSo_luong).Name = "txtSo_luong";
		AsTextNumeric asTextNumeric4 = txtSo_luong;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		txtSo_luong.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSo_luong).TabIndex = 1;
		((TextBox)txtSo_luong).Text = "0.00";
		((TextBox)txtSo_luong).TextAlign = (HorizontalAlignment)1;
		txtSo_luong.Value = 0;
		lblMa_vt.AutoSize = true;
		((Control)lblMa_vt).Font = new Font("Microsoft Sans Serif", 8.25f);
		Label obj23 = lblMa_vt;
		location = new Point(18, 23);
		((Control)obj23).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj24 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj24).Size = size;
		((Control)lblMa_vt).TabIndex = 0;
		lblMa_vt.Text = "Mã vật tư";
		lblQuantity.AutoSize = true;
		((Control)lblQuantity).Font = new Font("Microsoft Sans Serif", 8.25f);
		Label obj25 = lblQuantity;
		location = new Point(18, 49);
		((Control)obj25).Location = location;
		((Control)lblQuantity).Name = "lblQuantity";
		Label obj26 = lblQuantity;
		size = new Size(49, 13);
		((Control)obj26).Size = size;
		((Control)lblQuantity).TabIndex = 0;
		lblQuantity.Text = "Số lượng";
		((DataGridView)dgvCTVT).AllowUserToAddRows = false;
		((DataGridView)dgvCTVT).AllowUserToDeleteRows = false;
		((DataGridView)dgvCTVT).AllowUserToResizeColumns = false;
		((DataGridView)dgvCTVT).AllowUserToResizeRows = false;
		val.BackColor = SystemColors.Info;
		((DataGridView)dgvCTVT).AlternatingRowsDefaultCellStyle = val;
		((Control)dgvCTVT).Anchor = (AnchorStyles)11;
		((DataGridView)dgvCTVT).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvCTVT).BorderStyle = (BorderStyle)2;
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.WindowText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvCTVT).ColumnHeadersDefaultCellStyle = val2;
		((DataGridView)dgvCTVT).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvCTVT).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)colMa_vt,
			(DataGridViewColumn)colTen_vt,
			colSo_luong,
			(DataGridViewColumn)colVTC
		});
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = SystemColors.Window;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.ControlText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvCTVT).DefaultCellStyle = val3;
		dgvCTVT.DoubleBuffered = false;
		((DataGridView)dgvCTVT).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvCTVT).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvCTVT;
		location = new Point(381, 241);
		((Control)asDataGridView).Location = location;
		((Control)dgvCTVT).Name = "dgvCTVT";
		((DataGridView)dgvCTVT).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val4.Alignment = (DataGridViewContentAlignment)32;
		val4.BackColor = SystemColors.Control;
		val4.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val4.ForeColor = SystemColors.WindowText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvCTVT).RowHeadersDefaultCellStyle = val4;
		((DataGridView)dgvCTVT).RowHeadersVisible = false;
		dgvCTVT.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvCTVT).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvCTVT;
		size = new Size(587, 391);
		((Control)asDataGridView2).Size = size;
		((Control)dgvCTVT).TabIndex = 6;
		((DataGridViewColumn)colMa_vt).DataPropertyName = "ma_vt";
		val5.Alignment = (DataGridViewContentAlignment)16;
		((DataGridViewColumn)colMa_vt).DefaultCellStyle = val5;
		((DataGridViewColumn)colMa_vt).HeaderText = "Mã vật tư";
		((DataGridViewColumn)colMa_vt).Name = "colMa_vt";
		((DataGridViewColumn)colMa_vt).ReadOnly = true;
		((DataGridViewColumn)colTen_vt).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)colTen_vt).DataPropertyName = "ten_vt";
		val6.Alignment = (DataGridViewContentAlignment)16;
		((DataGridViewColumn)colTen_vt).DefaultCellStyle = val6;
		((DataGridViewColumn)colTen_vt).HeaderText = "Tên vật tư";
		((DataGridViewColumn)colTen_vt).Name = "colTen_vt";
		((DataGridViewColumn)colTen_vt).ReadOnly = true;
		((DataGridViewColumn)colSo_luong).DataPropertyName = "so_luong";
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "### ### ### ###.00";
		((DataGridViewColumn)colSo_luong).DefaultCellStyle = val7;
		((DataGridViewColumn)colSo_luong).HeaderText = "Số lượng";
		colSo_luong.Mask = "### ### ### ###.00";
		((DataGridViewColumn)colSo_luong).Name = "colSo_luong";
		((DataGridViewColumn)colSo_luong).ReadOnly = true;
		((DataGridViewColumn)colSo_luong).Resizable = (DataGridViewTriState)1;
		colSo_luong.SortMode = (DataGridViewColumnSortMode)1;
		colSo_luong.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)colVTC).DataPropertyName = "vt_chinh";
		((DataGridViewColumn)colVTC).HeaderText = "VT chính";
		((DataGridViewColumn)colVTC).Name = "colVTC";
		((DataGridViewColumn)colVTC).ReadOnly = true;
		((DataGridViewColumn)colVTC).Width = 60;
		((ToolStrip)mnuFilter).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)cmdFilter,
			(ToolStripItem)cmdSearch
		});
		((Control)mnuFilter).Name = "mnuFilter";
		ContextMenuStrip obj27 = mnuFilter;
		size = new Size(163, 48);
		((Control)obj27).Size = size;
		((ToolStripItem)cmdFilter).Name = "cmdFilter";
		ToolStripMenuItem obj28 = cmdFilter;
		size = new Size(162, 22);
		((ToolStripItem)obj28).Size = size;
		((ToolStripItem)cmdFilter).Text = "Lọc theo cột này";
		((ToolStripItem)cmdSearch).Name = "cmdSearch";
		ToolStripMenuItem obj29 = cmdSearch;
		size = new Size(162, 22);
		((ToolStripItem)obj29).Size = size;
		((ToolStripItem)cmdSearch).Text = "Tìm kiếm";
		((Control)cmdAdd).Anchor = (AnchorStyles)10;
		cmdAdd.DialogResult = (DialogResult)2;
		((ButtonBase)cmdAdd).Image = (Image)componentResourceManager.GetObject("cmdAdd.Image");
		((ButtonBase)cmdAdd).ImageAlign = (ContentAlignment)16;
		Button obj30 = cmdAdd;
		location = new Point(690, 649);
		((Control)obj30).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		Button obj31 = cmdAdd;
		size = new Size(64, 23);
		((Control)obj31).Size = size;
		((Control)cmdAdd).TabIndex = 2;
		((Control)cmdAdd).Tag = "0";
		((ButtonBase)cmdAdd).Text = "&Mới";
		((ButtonBase)cmdAdd).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdAdd).UseVisualStyleBackColor = true;
		((Control)cmdDel).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdDel).Image = (Image)componentResourceManager.GetObject("cmdDel.Image");
		((ButtonBase)cmdDel).ImageAlign = (ContentAlignment)16;
		Button obj32 = cmdDel;
		location = new Point(830, 649);
		((Control)obj32).Location = location;
		((Control)cmdDel).Name = "cmdDel";
		Button obj33 = cmdDel;
		size = new Size(64, 23);
		((Control)obj33).Size = size;
		((Control)cmdDel).TabIndex = 3;
		((ButtonBase)cmdDel).Text = "&Xóa";
		((ButtonBase)cmdDel).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdDel).UseVisualStyleBackColor = true;
		((Control)cmdEdit).Anchor = (AnchorStyles)10;
		cmdEdit.DialogResult = (DialogResult)2;
		((ButtonBase)cmdEdit).Image = (Image)componentResourceManager.GetObject("cmdEdit.Image");
		((ButtonBase)cmdEdit).ImageAlign = (ContentAlignment)16;
		Button obj34 = cmdEdit;
		location = new Point(760, 649);
		((Control)obj34).Location = location;
		((Control)cmdEdit).Name = "cmdEdit";
		Button obj35 = cmdEdit;
		size = new Size(64, 23);
		((Control)obj35).Size = size;
		((Control)cmdEdit).TabIndex = 4;
		((ButtonBase)cmdEdit).Text = "&Sửa";
		((ButtonBase)cmdEdit).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdEdit).UseVisualStyleBackColor = true;
		((Control)gbLine).Anchor = (AnchorStyles)14;
		GroupBox obj36 = gbLine;
		location = new Point(-1, 634);
		((Control)obj36).Location = location;
		((Control)gbLine).Name = "gbLine";
		GroupBox obj37 = gbLine;
		size = new Size(978, 10);
		((Control)obj37).Size = size;
		((Control)gbLine).TabIndex = 3;
		gbLine.TabStop = false;
		epError.ContainerControl = (ContainerControl)(object)this;
		((Control)cmdExit).Anchor = (AnchorStyles)10;
		cmdExit.DialogResult = (DialogResult)2;
		((ButtonBase)cmdExit).Image = (Image)componentResourceManager.GetObject("cmdExit.Image");
		((ButtonBase)cmdExit).ImageAlign = (ContentAlignment)16;
		Button obj38 = cmdExit;
		location = new Point(900, 649);
		((Control)obj38).Location = location;
		((Control)cmdExit).Name = "cmdExit";
		Button obj39 = cmdExit;
		size = new Size(65, 23);
		((Control)obj39).Size = size;
		((Control)cmdExit).TabIndex = 5;
		((ButtonBase)cmdExit).Text = "&Thoát";
		((ButtonBase)cmdExit).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdExit).UseVisualStyleBackColor = true;
		((Control)txtSearch).Anchor = (AnchorStyles)6;
		TextBox obj40 = txtSearch;
		location = new Point(142, 650);
		((Control)obj40).Location = location;
		((Control)txtSearch).Name = "txtSearch";
		TextBox obj41 = txtSearch;
		size = new Size(88, 20);
		((Control)obj41).Size = size;
		((Control)txtSearch).TabIndex = 8;
		((Control)cboFilter).Anchor = (AnchorStyles)6;
		cboFilter.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboFilter).FormattingEnabled = true;
		cboFilter.Items.AddRange(new object[2] { "Chứa", "Bắt đầu" });
		ComboBox obj42 = cboFilter;
		location = new Point(59, 650);
		((Control)obj42).Location = location;
		((Control)cboFilter).Name = "cboFilter";
		ComboBox obj43 = cboFilter;
		size = new Size(70, 21);
		((Control)obj43).Size = size;
		((Control)cboFilter).TabIndex = 7;
		((Control)lblTen).Anchor = (AnchorStyles)6;
		lblTen.AutoSize = true;
		Label obj44 = lblTen;
		location = new Point(8, 654);
		((Control)obj44).Location = location;
		((Control)lblTen).Name = "lblTen";
		Label obj45 = lblTen;
		size = new Size(26, 13);
		((Control)obj45).Size = size;
		((Control)lblTen).TabIndex = 9;
		lblTen.Text = "Tên";
		((Control)gbDmSp).Anchor = (AnchorStyles)15;
		((Control)gbDmSp).Controls.Add((Control)(object)dgvListVt);
		gbDmSp.FlatStyle = (FlatStyle)0;
		((Control)gbDmSp).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		GroupBox obj46 = gbDmSp;
		location = new Point(0, 0);
		((Control)obj46).Location = location;
		((Control)gbDmSp).Name = "gbDmSp";
		GroupBox obj47 = gbDmSp;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(0);
		((Control)obj47).Padding = padding;
		GroupBox obj48 = gbDmSp;
		size = new Size(375, 632);
		((Control)obj48).Size = size;
		((Control)gbDmSp).TabIndex = 0;
		gbDmSp.TabStop = false;
		gbDmSp.Text = "Danh mục sản phẩm";
		((DataGridView)dgvListVt).AllowUserToAddRows = false;
		((DataGridView)dgvListVt).AllowUserToDeleteRows = false;
		((DataGridView)dgvListVt).AllowUserToResizeColumns = false;
		((DataGridView)dgvListVt).AllowUserToResizeRows = false;
		val8.BackColor = SystemColors.Info;
		((DataGridView)dgvListVt).AlternatingRowsDefaultCellStyle = val8;
		((DataGridView)dgvListVt).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvListVt).BorderStyle = (BorderStyle)2;
		val9.Alignment = (DataGridViewContentAlignment)16;
		val9.BackColor = SystemColors.Window;
		val9.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val9.ForeColor = SystemColors.WindowText;
		val9.SelectionBackColor = SystemColors.Highlight;
		val9.SelectionForeColor = SystemColors.HighlightText;
		val9.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvListVt).ColumnHeadersDefaultCellStyle = val9;
		((DataGridView)dgvListVt).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvListVt).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)dgvcMa_SPCT,
			(DataGridViewColumn)dgvcTen_SPCT
		});
		((Control)dgvListVt).Dock = (DockStyle)5;
		dgvListVt.DoubleBuffered = false;
		((DataGridView)dgvListVt).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvListVt).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView3 = dgvListVt;
		location = new Point(0, 13);
		((Control)asDataGridView3).Location = location;
		((Control)dgvListVt).Name = "dgvListVt";
		val10.Alignment = (DataGridViewContentAlignment)32;
		val10.BackColor = SystemColors.Control;
		val10.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val10.ForeColor = SystemColors.WindowText;
		val10.SelectionBackColor = SystemColors.Highlight;
		val10.SelectionForeColor = SystemColors.HighlightText;
		val10.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvListVt).RowHeadersDefaultCellStyle = val10;
		((DataGridView)dgvListVt).RowHeadersVisible = false;
		dgvListVt.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvListVt).RowTemplate.Height = 20;
		((DataGridView)dgvListVt).SelectionMode = (DataGridViewSelectionMode)0;
		AsDataGridView asDataGridView4 = dgvListVt;
		size = new Size(375, 619);
		((Control)asDataGridView4).Size = size;
		((Control)dgvListVt).TabIndex = 11;
		((DataGridViewColumn)dgvcMa_SPCT).DataPropertyName = "Ma_SPCT";
		val11.Alignment = (DataGridViewContentAlignment)16;
		((DataGridViewColumn)dgvcMa_SPCT).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcMa_SPCT).HeaderText = "Mã SP";
		((DataGridViewColumn)dgvcMa_SPCT).Name = "dgvcMa_SPCT";
		((DataGridViewColumn)dgvcMa_SPCT).ReadOnly = true;
		dgvcMa_SPCT.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_SPCT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)dgvcTen_SPCT).DataPropertyName = "Ten_SPCT";
		val12.Alignment = (DataGridViewContentAlignment)16;
		((DataGridViewColumn)dgvcTen_SPCT).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcTen_SPCT).HeaderText = "Tên sản phẩm";
		((DataGridViewColumn)dgvcTen_SPCT).Name = "dgvcTen_SPCT";
		((DataGridViewColumn)dgvcTen_SPCT).ReadOnly = true;
		dgvcTen_SPCT.SortMode = (DataGridViewColumnSortMode)0;
		((Control)cmdFind).Anchor = (AnchorStyles)6;
		cmdFind.DialogResult = (DialogResult)2;
		((ButtonBase)cmdFind).Image = (Image)componentResourceManager.GetObject("cmdFind.Image");
		((ButtonBase)cmdFind).ImageAlign = (ContentAlignment)16;
		Button obj49 = cmdFind;
		location = new Point(236, 649);
		((Control)obj49).Location = location;
		((Control)cmdFind).Name = "cmdFind";
		Button obj50 = cmdFind;
		size = new Size(64, 23);
		((Control)obj50).Size = size;
		((Control)cmdFind).TabIndex = 9;
		((Control)cmdFind).Tag = "0";
		((ButtonBase)cmdFind).Text = "&Tìm";
		((ButtonBase)cmdFind).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdFind).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(972, 682);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdFind);
		((Control)this).Controls.Add((Control)(object)lblTen);
		((Control)this).Controls.Add((Control)(object)txtSearch);
		((Control)this).Controls.Add((Control)(object)cboFilter);
		((Control)this).Controls.Add((Control)(object)gbLine);
		((Control)this).Controls.Add((Control)(object)cmdExit);
		((Control)this).Controls.Add((Control)(object)cmdDel);
		((Control)this).Controls.Add((Control)(object)cmdEdit);
		((Control)this).Controls.Add((Control)(object)cmdAdd);
		((Control)this).Controls.Add((Control)(object)dgvCTVT);
		((Control)this).Controls.Add((Control)(object)gbChiTiet);
		((Control)this).Controls.Add((Control)(object)gbTTChung);
		((Control)this).Controls.Add((Control)(object)gbDmSp);
		((Control)this).Name = "frmCODMBOM";
		((Form)this).Text = "Định mức nguyên vật liệu";
		((Control)gbTTChung).ResumeLayout(false);
		((Control)gbTTChung).PerformLayout();
		((Control)gbChiTiet).ResumeLayout(false);
		((Control)gbChiTiet).PerformLayout();
		((ISupportInitialize)dgvCTVT).EndInit();
		((Control)mnuFilter).ResumeLayout(false);
		((ISupportInitialize)epError).EndInit();
		((Control)gbDmSp).ResumeLayout(false);
		((ISupportInitialize)dgvListVt).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if ((int)keyData == 27)
		{
			if (f_isEditing)
			{
				if ((int)CMessageBox.Show(50032, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)256) == 6)
				{
					SetPHButtonsAfterEdit();
					dgvListVt_SelectionChanged(null, null);
					return true;
				}
				return false;
			}
			((Form)this).Close();
		}
		else
		{
			((Form)this).ProcessCmdKey(ref msg, keyData);
		}
		bool result = default(bool);
		return result;
	}

	private void frmCODMBOM_Load(object sender, EventArgs e)
	{
		((Form)this).Text = base.MyMenuInfo.bar.Trim();
		cboFilter.SelectedIndex = 0;
		GetCoDmBomCT();
		GetCoDmBomPH();
		DisableFieldsPH(disable: true, edit: true);
		DisableFieldsCT(true);
		txtDon_gia_luong.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
		txtSo_luong.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format;
	}

	private void dgvListVt_SelectionChanged(object sender, EventArgs e)
	{
		if (iCurrentRow != ((DataGridViewBand)((DataGridView)dgvListVt).CurrentRow).Index)
		{
			ChangCT(((DataGridView)dgvListVt).CurrentCell.RowIndex, ((DataGridView)dgvListVt).CurrentCell.ColumnIndex);
		}
	}

	private void dgvCTVT_RowEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (f_tblBomCT.DefaultView.Count != 0)
		{
			((TextBox)txtMa_vt).Text = Conversions.ToString(f_tblBomCT.DefaultView[e.RowIndex].Row["ma_vt"]);
			txtSo_luong.Value = RuntimeHelpers.GetObjectValue(f_tblBomCT.DefaultView[e.RowIndex].Row["so_luong"]);
			lblTen_vt.Text = Conversions.ToString(f_tblBomCT.DefaultView[e.RowIndex].Row["ten_vt"]);
			chkVt_chinh.Checked = RuntimeHelpers.GetObjectValue(f_tblBomCT.DefaultView[e.RowIndex].Row["vt_chinh"]);
		}
	}

	private void GetLangResX()
	{
		ADD_TEXT = AsiaErp.Framework.Environment.getLangFrameworkResX("#BASEVOUCHER_ADD_TEXT");
		CANCEL_TEXT = AsiaErp.Framework.Environment.getLangFrameworkResX("#BASEVOUCHER_CANCEL_TEXT");
		EDIT_TEXT = AsiaErp.Framework.Environment.getLangFrameworkResX("#BASEVOUCHER_EDIT_TEXT");
		SAVE_TEXT = AsiaErp.Framework.Environment.getLangFrameworkResX("#BASEVOUCHER_SAVE_TEXT");
	}

	private void frmCODMBOM_Shown(object sender, EventArgs e)
	{
		GetLangResX();
	}

	private void cmdFind_Click(object sender, EventArgs e)
	{
		int num = 0;
		string text = txtSearch.Text.ToLower();
		string text2 = "";
		checked
		{
			num = ((!((iCurrentRow >= ((DataGridView)dgvListVt).RowCount - 1) | bLoop)) ? iCurrentRow : 0);
			int num2 = num;
			int num3 = ((DataGridView)dgvListVt).RowCount - 1;
			int i;
			for (i = num2; i <= num3; i++)
			{
				text2 = ((DataGridView)dgvListVt)[1, i].Value.ToString().ToLower();
				if (cboFilter.SelectedIndex == 0)
				{
					if (text2.ToLower().Contains(text) && ((iCurrentRow != i) | (iCurrentCol != 1)))
					{
						((DataGridView)dgvListVt).ClearSelection();
						((DataGridView)dgvListVt)[1, i].Selected = true;
						ChangCT(i);
						break;
					}
				}
				else if (text2.Substring(0, text.Length).CompareTo(text) == 0 && text2.ToLower().Contains(text) && ((iCurrentRow != i) | (iCurrentCol != 1)))
				{
					((DataGridView)dgvListVt).ClearSelection();
					((DataGridView)dgvListVt)[1, i].Selected = true;
					ChangCT(i);
					break;
				}
			}
			if (i == ((DataGridView)dgvListVt).RowCount)
			{
				bLoop = true;
			}
			else
			{
				bLoop = false;
			}
		}
	}

	private void cmdAdd_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ButtonBase)cmdAdd).Text, ADD_TEXT, false) == 0)
		{
			DisableFieldsPH(disable: false, edit: false);
			DisableFieldsCT(false);
			SetPHButtonsForEdit();
			return;
		}
		bool flag = true;
		ICODMBOMDAO iCODMBOMDAO = (ICODMBOMDAO)DAOFactory.CreateDAOInstance("CODMBOMDAO", "CODMBOM");
		iCODMBOMDAO.RequireTrans = true;
		try
		{
			if (f_Edit)
			{
				if (!ValidDataPH())
				{
					return;
				}
				DataRow dataRow = f_tblBomPH.Select("ma_spct='" + ((TextBox)txtMa_sp).Text.Trim() + "'")[0];
				dataRow.BeginEdit();
				dataRow["ma_spct"] = ((TextBox)txtMa_sp).Text.Trim();
				dataRow["ngay1"] = RuntimeHelpers.GetObjectValue(txtSDate.Value);
				dataRow["ngay2"] = RuntimeHelpers.GetObjectValue(txtEDate.Value);
				dataRow["don_gia_luong"] = RuntimeHelpers.GetObjectValue(txtDon_gia_luong.Value);
				dataRow["ghi_chu"] = txtGhi_Chu.Text.Trim();
				dataRow.EndEdit();
				if (iCODMBOMDAO.UpdCoDmbomPH(dataRow) != 0)
				{
					flag = false;
				}
			}
			else
			{
				if (f_row == null && !AddNewCoBomPH())
				{
					flag = false;
				}
				if (iCODMBOMDAO.InsCoDmbomPH(f_row) != 0)
				{
					flag = false;
				}
			}
			if (flag)
			{
				DataTable changes = f_tblBomCT.GetChanges(DataRowState.Added);
				if (changes != null)
				{
					foreach (DataRow row in changes.Rows)
					{
						if (iCODMBOMDAO.InsCoDmbomCT(row) != 0)
						{
							flag = false;
							break;
						}
					}
				}
			}
			if (flag)
			{
				f_tblBomCT.AcceptChanges();
				f_tblBomPH.AcceptChanges();
				iCODMBOMDAO.CommitTrans();
			}
			else
			{
				f_tblBomCT.RejectChanges();
				f_tblBomPH.RejectChanges();
				iCODMBOMDAO.RollBackTrans();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			iCODMBOMDAO.RollBackTrans();
			f_tblBomCT.RejectChanges();
			f_tblBomPH.RejectChanges();
			ProjectData.ClearProjectError();
		}
		finally
		{
			iCODMBOMDAO.Destroy();
		}
		SetPHButtonsAfterEdit();
	}

	private void cmdAddCT_Click(object sender, EventArgs e)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		if (!ValidDataCT())
		{
			return;
		}
		DataRow dataRow = f_tblBomCT.NewRow();
		dataRow["ma_spct"] = ((TextBox)txtMa_sp).Text.Trim();
		dataRow["ma_vt"] = ((TextBox)txtMa_vt).Text.Trim();
		dataRow["ten_vt"] = lblTen_vt.Text.Trim();
		dataRow["vt_chinh"] = RuntimeHelpers.GetObjectValue(chkVt_chinh.Checked);
		dataRow["so_luong"] = RuntimeHelpers.GetObjectValue(txtSo_luong.Value);
		f_tblBomCT.Rows.Add(dataRow);
		ResetCT();
		if (!f_Edit && f_row == null)
		{
			if (!AddNewCoBomPH())
			{
				return;
			}
			CurrencyManager val = (CurrencyManager)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvListVt).DataSource)];
			val.Position = checked(val.Count - 1);
		}
		((Control)txtMa_vt).Select();
	}

	private void cmdEdit_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ButtonBase)cmdEdit).Text, CANCEL_TEXT, false) == 0)
		{
			SetPHButtonsAfterEdit();
			dgvListVt_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			return;
		}
		f_Edit = true;
		DisableFieldsPH(disable: false, f_Edit);
		DisableFieldsCT(false);
		SetPHButtonsForEdit();
		dgvListVt_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void cmdDel_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		if (((DataGridView)dgvListVt).RowCount <= 0 || (int)CMessageBox.Show(50003, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)256) != 6)
		{
			return;
		}
		ICODMBOMDAO iCODMBOMDAO = (ICODMBOMDAO)DAOFactory.CreateDAOInstance("CODMBOMDAO", "CODMBOM");
		DataRow dataRow = f_tblBomPH.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ma_spct='", ((DataGridView)dgvListVt).Rows[((DataGridViewBand)((DataGridView)dgvListVt).CurrentRow).Index].Cells["dgvcMa_spct"].Value), (object)"'")))[0];
		DataRow[] array = f_tblBomCT.Select("ma_spct='" + ((TextBox)txtMa_sp).Text + "'");
		DataRow[] array2 = array;
		foreach (DataRow row in array2)
		{
			f_tblBomCT.Rows.Remove(row);
		}
		if (iCODMBOMDAO.DelCoDmbomPH(Conversions.ToString(dataRow["ma_spct"])) == 0)
		{
			f_tblBomPH.Rows.Remove(dataRow);
			f_tblBomPH.AcceptChanges();
			f_tblBomCT.AcceptChanges();
			if (f_tblBomPH.DefaultView.Count == 0)
			{
				((Control)cmdDel).Enabled = false;
				((Control)cmdEdit).Enabled = false;
				ResetPH();
				ResetCT();
			}
		}
		else
		{
			f_tblBomPH.RejectChanges();
			f_tblBomCT.RejectChanges();
		}
	}

	private void cmdDelCT_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(((TextBox)txtMa_vt).Text.Trim(), "", false) == 0 || (int)CMessageBox.Show(50003, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)256) == 7)
		{
			return;
		}
		ICODMBOMDAO iCODMBOMDAO = (ICODMBOMDAO)DAOFactory.CreateDAOInstance("CODMBOMDAO", "CODMBOM");
		DataRow row = f_tblBomCT.DefaultView[((DataGridViewBand)((DataGridView)dgvCTVT).CurrentRow).Index].Row;
		if (iCODMBOMDAO.DelCoDmbomCT(((TextBox)txtMa_sp).Text.Trim(), ((TextBox)txtMa_vt).Text.Trim()) == 0)
		{
			f_tblBomCT.Rows.Remove(row);
			if (f_tblBomCT.DefaultView.Count == 0)
			{
				ResetCT();
			}
		}
		else
		{
			CMessageBox.Show(50010);
		}
		iCODMBOMDAO.Destroy();
	}

	private void cmdExit_Click(object sender, EventArgs e)
	{
		((Component)(object)this).Dispose();
	}

	private void ChangCT(int rowIndex, int colIndex = 1)
	{
		if (((DataGridView)dgvListVt).RowCount > 0)
		{
			DataRow dataRow = f_tblBomPH.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ma_spct='", ((DataGridView)dgvListVt).Rows[rowIndex].Cells["dgvcMa_spct"].Value), (object)"'")))[0];
			SetPHValues(dataRow);
			f_tblBomCT.DefaultView.RowFilter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ma_spct='", dataRow["ma_spct"]), (object)"'"));
			if (f_tblBomCT.DefaultView.Count == 0)
			{
				ResetCT();
			}
			iCurrentRow = rowIndex;
			iCurrentCol = colIndex;
		}
	}

	private void SetPHValues(DataRow dr)
	{
		if (dr != null)
		{
			((TextBox)txtMa_sp).Text = Conversions.ToString(dr["ma_spct"]);
			lblTen_sp.Text = Conversions.ToString(dr["ten_spct"]);
			txtSDate.Value = RuntimeHelpers.GetObjectValue(dr["ngay1"]);
			txtEDate.Value = RuntimeHelpers.GetObjectValue(dr["ngay2"]);
			txtDon_gia_luong.Value = RuntimeHelpers.GetObjectValue(dr["don_gia_luong"]);
			txtGhi_Chu.Text = Conversions.ToString(dr["ghi_chu"]);
		}
		else
		{
			((TextBox)txtMa_sp).Text = "";
			lblTen_sp.Text = "";
			txtSDate.Value = new DateTime(599266080000000000L);
			txtEDate.Value = new DateTime(599266080000000000L);
			txtDon_gia_luong.Value = 0;
			txtGhi_Chu.Text = "";
		}
	}

	private void SetPHButtonsForEdit()
	{
		f_isEditing = true;
		if (!f_Edit)
		{
			if (f_tblBomCT != null)
			{
				f_tblBomCT.DefaultView.RowFilter = "ma_spct=''";
			}
			ResetPH();
			ResetCT();
		}
		((ButtonBase)cmdAdd).Text = SAVE_TEXT;
		((ButtonBase)cmdAdd).Image = (Image)(object)Resources.imgSave;
		((ButtonBase)cmdEdit).Text = CANCEL_TEXT;
		((ButtonBase)cmdEdit).Image = (Image)(object)Resources.imgCancel;
		((Control)cmdDel).Enabled = false;
		((Control)cmdExit).Enabled = false;
	}

	private void SetPHButtonsAfterEdit()
	{
		f_isEditing = false;
		f_tblBomPH.RejectChanges();
		f_tblBomCT.RejectChanges();
		f_row = null;
		f_Edit = false;
		DisableFieldsPH(disable: true, edit: true);
		if (f_tblBomPH.Rows.Count == 0)
		{
			((Control)cmdDel).Enabled = false;
			((Control)cmdEdit).Enabled = false;
			ResetPH();
		}
		else
		{
			((Control)cmdDel).Enabled = true;
			((Control)cmdEdit).Enabled = true;
		}
		((Control)cmdExit).Enabled = true;
		((ButtonBase)cmdAdd).Text = ADD_TEXT;
		((ButtonBase)cmdAdd).Image = (Image)(object)Resources.imgAdd;
		((ButtonBase)cmdEdit).Text = EDIT_TEXT;
		((ButtonBase)cmdEdit).Image = (Image)(object)Resources.imgEdit;
		DisableFieldsCT(true);
		ResetCT();
	}

	private void GetCoDmBomPH()
	{
		ICODMBOMDAO iCODMBOMDAO = (ICODMBOMDAO)DAOFactory.CreateDAOInstance("CODMBOMDAO", "CODMBOM");
		f_tblBomPH = iCODMBOMDAO.GetCoDmbomPH();
		iCODMBOMDAO.Destroy();
		((DataGridView)dgvListVt).DataSource = f_tblBomPH.DefaultView;
		if (f_tblBomPH.Rows.Count == 0)
		{
			((Control)cmdDel).Enabled = false;
			((Control)cmdEdit).Enabled = false;
		}
		else
		{
			SetPHValues(f_tblBomPH.DefaultView[0].Row);
		}
	}

	private void GetCoDmBomCT()
	{
		ICODMBOMDAO iCODMBOMDAO = (ICODMBOMDAO)DAOFactory.CreateDAOInstance("CODMBOMDAO", "CODMBOM");
		f_tblBomCT = iCODMBOMDAO.GetCoDmbomCT();
		iCODMBOMDAO.Destroy();
		((DataGridView)dgvCTVT).DataSource = f_tblBomCT.DefaultView;
	}

	private bool AddNewCoBomPH()
	{
		if (!ValidDataPH())
		{
			return false;
		}
		if (f_tblBomPH.Select("ma_spct='" + ((TextBox)txtMa_sp).Text.Trim() + "'").Count() > 0)
		{
			epError.SetError((Control)(object)txtMa_sp, Helper.GetMessContent(50011));
			((Control)txtMa_sp).Select();
			return false;
		}
		epError.SetError((Control)(object)txtMa_sp, "");
		DataRow dataRow = f_tblBomPH.NewRow();
		dataRow["ma_spct"] = ((TextBox)txtMa_sp).Text.Trim();
		dataRow["ten_spct"] = lblTen_sp.Text;
		dataRow["ngay1"] = RuntimeHelpers.GetObjectValue(txtSDate.Value);
		dataRow["ngay2"] = RuntimeHelpers.GetObjectValue(txtEDate.Value);
		dataRow["don_gia_luong"] = RuntimeHelpers.GetObjectValue(txtDon_gia_luong.Value);
		dataRow["ghi_chu"] = txtGhi_Chu.Text.Trim();
		dataRow["ten"] = ((TextBox)txtMa_sp).Text.Trim() + " - " + lblTen_sp.Text;
		f_row = dataRow;
		f_tblBomPH.Rows.Add(dataRow);
		return true;
	}

	private void DisableFieldsPH(bool disable, bool edit)
	{
		((Control)cmdAddCT).Enabled = !disable;
		((Control)cmdDelCT).Enabled = !disable;
		((TextBoxBase)txtMa_sp).ReadOnly = edit;
		((Control)txtMa_sp).TabStop = !edit;
		((MaskedTextBox)txtSDate).ReadOnly = disable;
		((Control)txtSDate).TabStop = !disable;
		((MaskedTextBox)txtEDate).ReadOnly = disable;
		((Control)txtEDate).TabStop = !disable;
		((TextBoxBase)txtDon_gia_luong).ReadOnly = disable;
		((Control)txtDon_gia_luong).TabStop = !disable;
		((TextBoxBase)txtGhi_Chu).ReadOnly = disable;
		((Control)txtGhi_Chu).TabStop = !disable;
		((Control)dgvListVt).Enabled = disable;
		if (edit)
		{
			((Control)txtSDate).Select();
		}
		else
		{
			((Control)txtMa_sp).Select();
		}
	}

	private void DisableFieldsCT(object disable)
	{
		((TextBoxBase)txtMa_vt).ReadOnly = Conversions.ToBoolean(disable);
		((Control)txtMa_vt).TabStop = Conversions.ToBoolean(Operators.NotObject(disable));
		((TextBoxBase)txtSo_luong).ReadOnly = Conversions.ToBoolean(disable);
		((Control)txtSo_luong).TabStop = Conversions.ToBoolean(Operators.NotObject(disable));
		((Control)chkVt_chinh).Enabled = Conversions.ToBoolean(Operators.NotObject(disable));
	}

	private void ResetPH()
	{
		((TextBox)txtMa_sp).Text = "";
		lblTen_sp.Text = "";
		txtSDate.Value = new DateTime(599266080000000000L);
		txtEDate.Value = new DateTime(599266080000000000L);
		txtDon_gia_luong.Value = 0;
		txtGhi_Chu.Text = "";
	}

	private void ResetCT()
	{
		((TextBox)txtMa_vt).Text = "";
		lblTen_vt.Text = "";
		((TextBox)txtSo_luong).Text = "";
		chkVt_chinh.Checked = false;
	}

	private bool ValidDataPH()
	{
		if (Operators.CompareString(((TextBox)txtMa_sp).Text.Trim(), "", false) == 0)
		{
			epError.SetError((Control)(object)txtMa_sp, Helper.GetMessContent(50002));
			((Control)txtMa_sp).Select();
			return false;
		}
		epError.Clear();
		return true;
	}

	private bool ValidDataCT()
	{
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(((TextBox)txtMa_vt).Text.Trim(), "", false) == 0)
		{
			epError.SetError((Control)(object)txtMa_vt, Helper.GetMessContent(50002));
			((Control)txtMa_vt).Select();
			return false;
		}
		epError.SetError((Control)(object)txtMa_vt, "");
		if (Operators.ConditionalCompareObjectEqual(txtSo_luong.Value, (object)0, false))
		{
			epError.SetError((Control)(object)txtSo_luong, Helper.GetMessContent(50002));
			((Control)txtSo_luong).Select();
			return false;
		}
		epError.SetError((Control)(object)txtSo_luong, "");
		if (f_tblBomCT.Select("ma_spct='" + ((TextBox)txtMa_sp).Text.Trim() + "' and ma_vt='" + ((TextBox)txtMa_vt).Text.Trim() + "'").Count() > 0)
		{
			CMessageBox.Show(50011);
			((Control)txtMa_vt).Select();
			return false;
		}
		return true;
	}
}
