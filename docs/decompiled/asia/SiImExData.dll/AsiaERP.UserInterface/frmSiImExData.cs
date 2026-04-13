using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using AsiaERP.DataAccess;
using AsiaErp.Framework;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmSiImExData : frmCalc
{
	private delegate void ProgressInsert(DataSet ds, string ws_id, DateTime ngay1, DateTime ngay2);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("rbExport")]
	private RadioButton _rbExport;

	[AccessedThroughProperty("rbImport")]
	private RadioButton _rbImport;

	[AccessedThroughProperty("OpenFile")]
	private OpenFileDialog _OpenFile;

	[AccessedThroughProperty("SaveFile")]
	private SaveFileDialog _SaveFile;

	[AccessedThroughProperty("btnAdd")]
	private Button _btnAdd;

	[AccessedThroughProperty("txtVersion")]
	private TextBox _txtVersion;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtWsId")]
	private TextBox _txtWsId;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtFilter1")]
	private TextBox _txtFilter1;

	[AccessedThroughProperty("btnOpen")]
	private Button _btnOpen;

	[AccessedThroughProperty("txtPath")]
	private TextBox _txtPath;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("dgvSoLieu")]
	private AsDataGridView _dgvSoLieu;

	[AccessedThroughProperty("dgvDanhMuc")]
	private AsDataGridView _dgvDanhMuc;

	[AccessedThroughProperty("txtFilter2")]
	private TextBox _txtFilter2;

	[AccessedThroughProperty("lbl2")]
	private Label _lbl2;

	[AccessedThroughProperty("txtNgay2")]
	private AsMaskedTextBox _txtNgay2;

	[AccessedThroughProperty("txtNgay1")]
	private AsMaskedTextBox _txtNgay1;

	[AccessedThroughProperty("cboKyBc")]
	private ComboBox _cboKyBc;

	[AccessedThroughProperty("lblKyBc")]
	private Label _lblKyBc;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("txtNgay4")]
	private AsMaskedTextBox _txtNgay4;

	[AccessedThroughProperty("txtNgay3")]
	private AsMaskedTextBox _txtNgay3;

	[AccessedThroughProperty("cboCreateDate")]
	private ComboBox _cboCreateDate;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("chkDmAll")]
	private CheckBox _chkDmAll;

	[AccessedThroughProperty("chkCheckCTAll")]
	private CheckBox _chkCheckCTAll;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("gbCt")]
	private GroupBox _gbCt;

	[AccessedThroughProperty("gbDanhMuc")]
	private GroupBox _gbDanhMuc;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("OpenFolder")]
	private FolderBrowserDialog _OpenFolder;

	[AccessedThroughProperty("dgvcTag")]
	private DataGridViewCheckBoxColumn _dgvcTag;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	[AccessedThroughProperty("dgvcTable1")]
	private DataGridViewTextBoxColumn _dgvcTable1;

	[AccessedThroughProperty("dgvcTable2")]
	private DataGridViewTextBoxColumn _dgvcTable2;

	[AccessedThroughProperty("DataGridViewCheckBoxColumn1")]
	private DataGridViewCheckBoxColumn _DataGridViewCheckBoxColumn1;

	[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	[AccessedThroughProperty("DataGridViewTextBoxColumn5")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

	[AccessedThroughProperty("DataGridViewTextBoxColumn6")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

	internal string f_strMa_ph;

	internal string f_strMa_ct;

	private System.Data.DataTable f_tblsl;

	private System.Data.DataTable f_tbldm;

	private System.Data.DataTable f_tblCopy;

	private DataSet dsAllData;

	private Thread worker_thread;

	private ProgressInsert Progress;

	private AutoResetEvent autoEvent;

	private ArrayList array;

	protected override Button cmdCancel
	{
		[DebuggerNonUserCode]
		get
		{
			return base.cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCancel_Click;
			if (base.cmdCancel != null)
			{
				((Control)base.cmdCancel).Click -= eventHandler;
			}
			base.cmdCancel = value;
			if (base.cmdCancel != null)
			{
				((Control)base.cmdCancel).Click += eventHandler;
			}
		}
	}

	protected override Button cmdOK
	{
		[DebuggerNonUserCode]
		get
		{
			return base.cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOK_Click;
			if (base.cmdOK != null)
			{
				((Control)base.cmdOK).Click -= eventHandler;
			}
			base.cmdOK = value;
			if (base.cmdOK != null)
			{
				((Control)base.cmdOK).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label1
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

	internal virtual RadioButton rbExport
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbExport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rbExport = value;
		}
	}

	internal virtual RadioButton rbImport
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbImport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbImport_CheckedChanged;
			if (_rbImport != null)
			{
				_rbImport.CheckedChanged -= eventHandler;
			}
			_rbImport = value;
			if (_rbImport != null)
			{
				_rbImport.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual OpenFileDialog OpenFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OpenFile = value;
		}
	}

	internal virtual SaveFileDialog SaveFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaveFile = value;
		}
	}

	internal virtual Button btnAdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_btnAdd = value;
		}
	}

	internal virtual TextBox txtVersion
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVersion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtVersion = value;
		}
	}

	internal virtual Label Label3
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

	internal virtual TextBox txtWsId
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtWsId;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtWsId = value;
		}
	}

	internal virtual Label Label4
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

	internal virtual TextBox txtFilter1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFilter1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtFilter1_TextChanged;
			if (_txtFilter1 != null)
			{
				((Control)_txtFilter1).TextChanged -= eventHandler;
			}
			_txtFilter1 = value;
			if (_txtFilter1 != null)
			{
				((Control)_txtFilter1).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Button btnOpen
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnOpen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnOpen_Click;
			if (_btnOpen != null)
			{
				((Control)_btnOpen).Click -= eventHandler;
			}
			_btnOpen = value;
			if (_btnOpen != null)
			{
				((Control)_btnOpen).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox txtPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPath = value;
		}
	}

	protected virtual Label Label2
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

	internal virtual AsDataGridView dgvSoLieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvSoLieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvSoLieu = value;
		}
	}

	internal virtual AsDataGridView dgvDanhMuc
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvDanhMuc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvDanhMuc = value;
		}
	}

	internal virtual TextBox txtFilter2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFilter2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtFilter2_TextChanged;
			if (_txtFilter2 != null)
			{
				((Control)_txtFilter2).TextChanged -= eventHandler;
			}
			_txtFilter2 = value;
			if (_txtFilter2 != null)
			{
				((Control)_txtFilter2).TextChanged += eventHandler;
			}
		}
	}

	protected virtual Label lbl2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl2 = value;
		}
	}

	protected internal virtual AsMaskedTextBox txtNgay2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNgay2_TextChanged;
			if (_txtNgay2 != null)
			{
				((Control)_txtNgay2).TextChanged -= eventHandler;
			}
			_txtNgay2 = value;
			if (_txtNgay2 != null)
			{
				((Control)_txtNgay2).TextChanged += eventHandler;
			}
		}
	}

	protected internal virtual AsMaskedTextBox txtNgay1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNgay1_TextChanged;
			if (_txtNgay1 != null)
			{
				((Control)_txtNgay1).TextChanged -= eventHandler;
			}
			_txtNgay1 = value;
			if (_txtNgay1 != null)
			{
				((Control)_txtNgay1).TextChanged += eventHandler;
			}
		}
	}

	protected virtual ComboBox cboKyBc
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboKyBc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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

	protected virtual Label lblKyBc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblKyBc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblKyBc = value;
		}
	}

	protected virtual Label Label6
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

	protected internal virtual AsMaskedTextBox txtNgay4
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay4 = value;
		}
	}

	protected internal virtual AsMaskedTextBox txtNgay3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay3 = value;
		}
	}

	protected virtual ComboBox cboCreateDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboCreateDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboCreateDate_SelectedValueChanged;
			if (_cboCreateDate != null)
			{
				((ListControl)_cboCreateDate).SelectedValueChanged -= eventHandler;
			}
			_cboCreateDate = value;
			if (_cboCreateDate != null)
			{
				((ListControl)_cboCreateDate).SelectedValueChanged += eventHandler;
			}
		}
	}

	protected virtual Label Label7
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

	internal virtual ProgressBar ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual CheckBox chkDmAll
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkDmAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkDmAll_CheckedChanged;
			if (_chkDmAll != null)
			{
				_chkDmAll.CheckedChanged -= eventHandler;
			}
			_chkDmAll = value;
			if (_chkDmAll != null)
			{
				_chkDmAll.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual CheckBox chkCheckCTAll
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkCheckCTAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkCheckCTAll_CheckedChanged;
			if (_chkCheckCTAll != null)
			{
				_chkCheckCTAll.CheckedChanged -= eventHandler;
			}
			_chkCheckCTAll = value;
			if (_chkCheckCTAll != null)
			{
				_chkCheckCTAll.CheckedChanged += eventHandler;
			}
		}
	}

	protected virtual Label Label8
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

	protected virtual Label Label9
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

	internal virtual GroupBox gbCt
	{
		[DebuggerNonUserCode]
		get
		{
			return _gbCt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_gbCt = value;
		}
	}

	internal virtual GroupBox gbDanhMuc
	{
		[DebuggerNonUserCode]
		get
		{
			return _gbDanhMuc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_gbDanhMuc = value;
		}
	}

	protected virtual Label Label5
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

	internal virtual Label Label10
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

	internal virtual FolderBrowserDialog OpenFolder
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenFolder;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OpenFolder = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcTag
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTag;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTag = value;
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn3 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTable1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTable1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTable1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTable2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTable2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTable2 = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewCheckBoxColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewCheckBoxColumn1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn4 = value;
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn5 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn6 = value;
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

	public frmSiImExData(string MenuID)
		: base(MenuID)
	{
		((Form)this).Load += frmSiImExData_Load;
		__ENCAddToList(this);
		f_tblCopy = new System.Data.DataTable();
		dsAllData = new DataSet();
		Progress = null;
		autoEvent = new AutoResetEvent(initialState: false);
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected O, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected O, but got Unknown
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Expected O, but got Unknown
		//IL_0bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdd: Expected O, but got Unknown
		//IL_0eca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed4: Expected O, but got Unknown
		//IL_0f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9d: Expected O, but got Unknown
		//IL_1057: Unknown result type (might be due to invalid IL or missing references)
		//IL_1061: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSiImExData));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		Label1 = new Label();
		rbImport = new RadioButton();
		rbExport = new RadioButton();
		OpenFile = new OpenFileDialog();
		SaveFile = new SaveFileDialog();
		btnAdd = new Button();
		Label3 = new Label();
		txtVersion = new TextBox();
		txtWsId = new TextBox();
		Label4 = new Label();
		txtFilter1 = new TextBox();
		btnOpen = new Button();
		txtPath = new TextBox();
		Label2 = new Label();
		dgvSoLieu = new AsDataGridView();
		dgvcTag = new DataGridViewCheckBoxColumn();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		dgvcTable1 = new DataGridViewTextBoxColumn();
		dgvcTable2 = new DataGridViewTextBoxColumn();
		dgvDanhMuc = new AsDataGridView();
		DataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
		DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
		txtFilter2 = new TextBox();
		lbl2 = new Label();
		txtNgay2 = new AsMaskedTextBox();
		txtNgay1 = new AsMaskedTextBox();
		cboKyBc = new ComboBox();
		lblKyBc = new Label();
		Label6 = new Label();
		txtNgay4 = new AsMaskedTextBox();
		txtNgay3 = new AsMaskedTextBox();
		cboCreateDate = new ComboBox();
		Label7 = new Label();
		ProgressBar1 = new ProgressBar();
		chkCheckCTAll = new CheckBox();
		chkDmAll = new CheckBox();
		Label8 = new Label();
		Label9 = new Label();
		gbCt = new GroupBox();
		Label5 = new Label();
		gbDanhMuc = new GroupBox();
		Label10 = new Label();
		OpenFolder = new FolderBrowserDialog();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((ISupportInitialize)dgvSoLieu).BeginInit();
		((ISupportInitialize)dgvDanhMuc).BeginInit();
		((Control)gbCt).SuspendLayout();
		((Control)gbDanhMuc).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		Button obj = cmdCancel;
		System.Drawing.Point location = new System.Drawing.Point(93, 704);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		((Control)gbInput).Controls.Add((Control)(object)btnOpen);
		((Control)gbInput).Controls.Add((Control)(object)txtPath);
		((Control)gbInput).Controls.Add((Control)(object)Label2);
		((Control)gbInput).Controls.Add((Control)(object)txtWsId);
		((Control)gbInput).Controls.Add((Control)(object)Label4);
		((Control)gbInput).Controls.Add((Control)(object)txtVersion);
		((Control)gbInput).Controls.Add((Control)(object)Label3);
		((Control)gbInput).Controls.Add((Control)(object)btnAdd);
		((Control)gbInput).Controls.Add((Control)(object)rbExport);
		((Control)gbInput).Controls.Add((Control)(object)rbImport);
		((Control)gbInput).Controls.Add((Control)(object)Label1);
		GroupBox obj2 = gbInput;
		location = new System.Drawing.Point(6, 0);
		((Control)obj2).Location = location;
		GroupBox obj3 = gbInput;
		Size size = new Size(764, 104);
		((Control)obj3).Size = size;
		((Control)gbInput).TabIndex = 0;
		((Control)cmdOK).Anchor = (AnchorStyles)6;
		Button obj4 = cmdOK;
		location = new System.Drawing.Point(12, 704);
		((Control)obj4).Location = location;
		((Control)cmdOK).TabIndex = 1;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new System.Drawing.Point(16, 28);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(59, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 0;
		Label1.Text = "Chức năng";
		((ButtonBase)rbImport).AutoSize = true;
		rbImport.Checked = true;
		RadioButton obj5 = rbImport;
		location = new System.Drawing.Point(95, 26);
		((Control)obj5).Location = location;
		((Control)rbImport).Name = "rbImport";
		RadioButton obj6 = rbImport;
		size = new Size(85, 17);
		((Control)obj6).Size = size;
		((Control)rbImport).TabIndex = 0;
		rbImport.TabStop = true;
		((ButtonBase)rbImport).Text = "Nhập dữ liệu";
		((ButtonBase)rbImport).UseVisualStyleBackColor = true;
		((ButtonBase)rbExport).AutoSize = true;
		RadioButton obj7 = rbExport;
		location = new System.Drawing.Point(191, 26);
		((Control)obj7).Location = location;
		((Control)rbExport).Name = "rbExport";
		RadioButton obj8 = rbExport;
		size = new Size(81, 17);
		((Control)obj8).Size = size;
		((Control)rbExport).TabIndex = 1;
		((ButtonBase)rbExport).Text = "Xuất dữ liệu";
		((ButtonBase)rbExport).UseVisualStyleBackColor = true;
		((FileDialog)OpenFile).FileName = "OpenFile";
		Button obj9 = btnAdd;
		location = new System.Drawing.Point(649, 105);
		((Control)obj9).Location = location;
		((Control)btnAdd).Name = "btnAdd";
		Button obj10 = btnAdd;
		size = new Size(75, 23);
		((Control)obj10).Size = size;
		((Control)btnAdd).TabIndex = 11;
		((ButtonBase)btnAdd).Text = "Nhập";
		((ButtonBase)btnAdd).UseVisualStyleBackColor = true;
		((Control)btnAdd).Visible = false;
		Label3.AutoSize = true;
		Label label3 = Label3;
		location = new System.Drawing.Point(16, 78);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		Label label4 = Label3;
		size = new Size(55, 13);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 1033;
		Label3.Text = "Phiên bản";
		((Control)txtVersion).Enabled = false;
		TextBox obj11 = txtVersion;
		location = new System.Drawing.Point(95, 75);
		((Control)obj11).Location = location;
		((Control)txtVersion).Name = "txtVersion";
		TextBox obj12 = txtVersion;
		size = new Size(177, 20);
		((Control)obj12).Size = size;
		((Control)txtVersion).TabIndex = 3;
		((Control)txtWsId).Enabled = false;
		TextBox obj13 = txtWsId;
		location = new System.Drawing.Point(358, 75);
		((Control)obj13).Location = location;
		((Control)txtWsId).Name = "txtWsId";
		TextBox obj14 = txtWsId;
		size = new Size(27, 20);
		((Control)obj14).Size = size;
		((Control)txtWsId).TabIndex = 5;
		txtWsId.TextAlign = (HorizontalAlignment)2;
		Label4.AutoSize = true;
		Label label5 = Label4;
		location = new System.Drawing.Point(296, 78);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		Label label6 = Label4;
		size = new Size(45, 13);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 4;
		Label4.Text = "Mã trạm";
		((Control)txtFilter1).Anchor = (AnchorStyles)13;
		TextBox obj15 = txtFilter1;
		location = new System.Drawing.Point(220, 44);
		((Control)obj15).Location = location;
		((Control)txtFilter1).Name = "txtFilter1";
		TextBox obj16 = txtFilter1;
		size = new Size(538, 20);
		((Control)obj16).Size = size;
		((Control)txtFilter1).TabIndex = 9;
		((ButtonBase)btnOpen).Image = (Image)componentResourceManager.GetObject("btnOpen.Image");
		Button obj17 = btnOpen;
		location = new System.Drawing.Point(472, 47);
		((Control)obj17).Location = location;
		((Control)btnOpen).Name = "btnOpen";
		Button obj18 = btnOpen;
		size = new Size(34, 23);
		((Control)obj18).Size = size;
		((Control)btnOpen).TabIndex = 3;
		((ButtonBase)btnOpen).UseVisualStyleBackColor = true;
		TextBox obj19 = txtPath;
		location = new System.Drawing.Point(95, 49);
		((Control)obj19).Location = location;
		((Control)txtPath).Name = "txtPath";
		TextBox obj20 = txtPath;
		size = new Size(371, 20);
		((Control)obj20).Size = size;
		((Control)txtPath).TabIndex = 2;
		Label2.AutoSize = true;
		Label label7 = Label2;
		location = new System.Drawing.Point(16, 52);
		((Control)label7).Location = location;
		((Control)Label2).Name = "Label2";
		Label label8 = Label2;
		size = new Size(60, 13);
		((Control)label8).Size = size;
		((Control)Label2).TabIndex = 1038;
		Label2.Text = "Đường dẫn";
		((DataGridView)dgvSoLieu).AllowUserToAddRows = false;
		((DataGridView)dgvSoLieu).AllowUserToDeleteRows = false;
		((Control)dgvSoLieu).Anchor = (AnchorStyles)15;
		((DataGridView)dgvSoLieu).BackgroundColor = SystemColors.ActiveCaptionText;
		((DataGridView)dgvSoLieu).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvSoLieu).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)dgvSoLieu).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvSoLieu).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)dgvcTag,
			(DataGridViewColumn)DataGridViewTextBoxColumn1,
			(DataGridViewColumn)DataGridViewTextBoxColumn3,
			(DataGridViewColumn)dgvcTable1,
			(DataGridViewColumn)dgvcTable2
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvSoLieu).DefaultCellStyle = val2;
		dgvSoLieu.DoubleBuffered = false;
		((DataGridView)dgvSoLieu).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvSoLieu).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvSoLieu;
		location = new System.Drawing.Point(4, 70);
		((Control)asDataGridView).Location = location;
		((Control)dgvSoLieu).Name = "dgvSoLieu";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvSoLieu).RowHeadersDefaultCellStyle = val3;
		dgvSoLieu.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvSoLieu).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvSoLieu;
		size = new Size(754, 208);
		((Control)asDataGridView2).Size = size;
		((Control)dgvSoLieu).TabIndex = 10;
		((DataGridViewColumn)dgvcTag).DataPropertyName = "Tag";
		((DataGridViewColumn)dgvcTag).FillWeight = 17.68338f;
		((DataGridViewColumn)dgvcTag).HeaderText = "Chọn";
		((DataGridViewColumn)dgvcTag).Name = "dgvcTag";
		((DataGridViewColumn)dgvcTag).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcTag).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcTag).Width = 37;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).DataPropertyName = "Code_Name";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).FillWeight = 42.64563f;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).HeaderText = "Mã CT";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).ReadOnly = true;
		DataGridViewTextBoxColumn1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Width = 50;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).DataPropertyName = "description";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).FillWeight = 296.8218f;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).HeaderText = "Diễn giải";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Name = "DataGridViewTextBoxColumn3";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).ReadOnly = true;
		DataGridViewTextBoxColumn3.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTable1).DataPropertyName = "table1";
		((DataGridViewColumn)dgvcTable1).FillWeight = 51.6375f;
		((DataGridViewColumn)dgvcTable1).HeaderText = "Bảng dữ liệu 1";
		((DataGridViewColumn)dgvcTable1).Name = "dgvcTable1";
		((DataGridViewColumn)dgvcTable1).ReadOnly = true;
		dgvcTable1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTable1).Visible = false;
		((DataGridViewColumn)dgvcTable2).DataPropertyName = "table2";
		((DataGridViewColumn)dgvcTable2).HeaderText = "Bảng dữ liệu 2";
		((DataGridViewColumn)dgvcTable2).Name = "dgvcTable2";
		((DataGridViewColumn)dgvcTable2).ReadOnly = true;
		((DataGridViewColumn)dgvcTable2).Visible = false;
		((DataGridView)dgvDanhMuc).AllowUserToAddRows = false;
		((DataGridView)dgvDanhMuc).AllowUserToDeleteRows = false;
		((Control)dgvDanhMuc).Anchor = (AnchorStyles)15;
		((DataGridView)dgvDanhMuc).BackgroundColor = SystemColors.ActiveCaptionText;
		((DataGridView)dgvDanhMuc).BorderStyle = (BorderStyle)2;
		val4.Alignment = (DataGridViewContentAlignment)16;
		val4.BackColor = SystemColors.Control;
		val4.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val4.ForeColor = SystemColors.WindowText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDanhMuc).ColumnHeadersDefaultCellStyle = val4;
		((DataGridView)dgvDanhMuc).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvDanhMuc).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)DataGridViewCheckBoxColumn1,
			(DataGridViewColumn)DataGridViewTextBoxColumn4,
			(DataGridViewColumn)DataGridViewTextBoxColumn2,
			(DataGridViewColumn)DataGridViewTextBoxColumn5,
			(DataGridViewColumn)DataGridViewTextBoxColumn6
		});
		val5.Alignment = (DataGridViewContentAlignment)16;
		val5.BackColor = SystemColors.Window;
		val5.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val5.ForeColor = SystemColors.ControlText;
		val5.SelectionBackColor = SystemColors.Highlight;
		val5.SelectionForeColor = SystemColors.HighlightText;
		val5.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvDanhMuc).DefaultCellStyle = val5;
		dgvDanhMuc.DoubleBuffered = false;
		((DataGridView)dgvDanhMuc).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvDanhMuc).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView3 = dgvDanhMuc;
		location = new System.Drawing.Point(6, 71);
		((Control)asDataGridView3).Location = location;
		((Control)dgvDanhMuc).Name = "dgvDanhMuc";
		val6.Alignment = (DataGridViewContentAlignment)32;
		val6.BackColor = SystemColors.Control;
		val6.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val6.ForeColor = SystemColors.WindowText;
		val6.SelectionBackColor = SystemColors.Highlight;
		val6.SelectionForeColor = SystemColors.HighlightText;
		val6.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDanhMuc).RowHeadersDefaultCellStyle = val6;
		dgvDanhMuc.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvDanhMuc).RowTemplate.Height = 20;
		AsDataGridView asDataGridView4 = dgvDanhMuc;
		size = new Size(749, 221);
		((Control)asDataGridView4).Size = size;
		((Control)dgvDanhMuc).TabIndex = 16;
		((DataGridViewColumn)DataGridViewCheckBoxColumn1).DataPropertyName = "Tag";
		((DataGridViewColumn)DataGridViewCheckBoxColumn1).FillWeight = 15.98661f;
		((DataGridViewColumn)DataGridViewCheckBoxColumn1).HeaderText = "Chọn";
		((DataGridViewColumn)DataGridViewCheckBoxColumn1).Name = "DataGridViewCheckBoxColumn1";
		((DataGridViewColumn)DataGridViewCheckBoxColumn1).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)DataGridViewCheckBoxColumn1).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)DataGridViewCheckBoxColumn1).Width = 37;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).DataPropertyName = "description";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).FillWeight = 243.959f;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).HeaderText = "Diễn giải";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Name = "DataGridViewTextBoxColumn4";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).ReadOnly = true;
		DataGridViewTextBoxColumn4.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).DataPropertyName = "Code_Name";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).FillWeight = 88.41688f;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).HeaderText = "Mã";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Name = "DataGridViewTextBoxColumn2";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).ReadOnly = true;
		DataGridViewTextBoxColumn2.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Visible = false;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Width = 50;
		((DataGridViewColumn)DataGridViewTextBoxColumn5).DataPropertyName = "table1";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).FillWeight = 51.6375f;
		((DataGridViewColumn)DataGridViewTextBoxColumn5).HeaderText = "Bảng dữ liệu 1";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).Name = "DataGridViewTextBoxColumn5";
		((DataGridViewColumn)DataGridViewTextBoxColumn5).ReadOnly = true;
		DataGridViewTextBoxColumn5.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewTextBoxColumn5).Visible = false;
		((DataGridViewColumn)DataGridViewTextBoxColumn6).DataPropertyName = "table2";
		((DataGridViewColumn)DataGridViewTextBoxColumn6).HeaderText = "Bảng dữ liệu 2";
		((DataGridViewColumn)DataGridViewTextBoxColumn6).Name = "DataGridViewTextBoxColumn6";
		((DataGridViewColumn)DataGridViewTextBoxColumn6).ReadOnly = true;
		((DataGridViewColumn)DataGridViewTextBoxColumn6).Visible = false;
		((Control)txtFilter2).Anchor = (AnchorStyles)13;
		TextBox obj21 = txtFilter2;
		location = new System.Drawing.Point(220, 45);
		((Control)obj21).Location = location;
		((Control)txtFilter2).Name = "txtFilter2";
		TextBox obj22 = txtFilter2;
		size = new Size(535, 20);
		((Control)obj22).Size = size;
		((Control)txtFilter2).TabIndex = 15;
		lbl2.AutoSize = true;
		Label obj23 = lbl2;
		location = new System.Drawing.Point(293, 21);
		((Control)obj23).Location = location;
		((Control)lbl2).Name = "lbl2";
		Label obj24 = lbl2;
		size = new Size(10, 13);
		((Control)obj24).Size = size;
		((Control)lbl2).TabIndex = 1047;
		lbl2.Text = "-";
		txtNgay2.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay2).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new System.Drawing.Point(309, 19);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay2).Mask = "##/##/####";
		((Control)txtNgay2).Name = "txtNgay2";
		((MaskedTextBox)txtNgay2).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay2;
		size = new Size(67, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay2).TabIndex = 8;
		((MaskedTextBox)txtNgay2).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay2;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtNgay1.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay1).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay1;
		location = new System.Drawing.Point(220, 18);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay1).Mask = "##/##/####";
		((Control)txtNgay1).Name = "txtNgay1";
		((MaskedTextBox)txtNgay1).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay1;
		size = new Size(67, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay1).TabIndex = 7;
		((MaskedTextBox)txtNgay1).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay1;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		cboKyBc.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyBc).FormattingEnabled = true;
		ComboBox obj25 = cboKyBc;
		location = new System.Drawing.Point(95, 19);
		((Control)obj25).Location = location;
		((Control)cboKyBc).Name = "cboKyBc";
		ComboBox obj26 = cboKyBc;
		size = new Size(85, 21);
		((Control)obj26).Size = size;
		((Control)cboKyBc).TabIndex = 6;
		lblKyBc.AutoSize = true;
		Label obj27 = lblKyBc;
		location = new System.Drawing.Point(16, 22);
		((Control)obj27).Location = location;
		((Control)lblKyBc).Name = "lblKyBc";
		Label obj28 = lblKyBc;
		size = new Size(44, 13);
		((Control)obj28).Size = size;
		((Control)lblKyBc).TabIndex = 1046;
		lblKyBc.Text = "Ngày ct";
		Label6.AutoSize = true;
		Label label9 = Label6;
		location = new System.Drawing.Point(293, 23);
		((Control)label9).Location = location;
		((Control)Label6).Name = "Label6";
		Label label10 = Label6;
		size = new Size(10, 13);
		((Control)label10).Size = size;
		((Control)Label6).TabIndex = 1052;
		Label6.Text = "-";
		txtNgay4.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay4).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox7 = txtNgay4;
		location = new System.Drawing.Point(309, 19);
		((Control)asMaskedTextBox7).Location = location;
		((MaskedTextBox)txtNgay4).Mask = "##/##/####";
		((Control)txtNgay4).Name = "txtNgay4";
		((MaskedTextBox)txtNgay4).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox8 = txtNgay4;
		size = new Size(67, 20);
		((Control)asMaskedTextBox8).Size = size;
		((Control)txtNgay4).TabIndex = 14;
		((MaskedTextBox)txtNgay4).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox9 = txtNgay4;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox9.Value = dateTime;
		txtNgay3.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay3).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox10 = txtNgay3;
		location = new System.Drawing.Point(220, 19);
		((Control)asMaskedTextBox10).Location = location;
		((MaskedTextBox)txtNgay3).Mask = "##/##/####";
		((Control)txtNgay3).Name = "txtNgay3";
		((MaskedTextBox)txtNgay3).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox11 = txtNgay3;
		size = new Size(67, 20);
		((Control)asMaskedTextBox11).Size = size;
		((Control)txtNgay3).TabIndex = 13;
		((MaskedTextBox)txtNgay3).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox12 = txtNgay3;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox12.Value = dateTime;
		cboCreateDate.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboCreateDate).FormattingEnabled = true;
		ComboBox obj29 = cboCreateDate;
		location = new System.Drawing.Point(89, 19);
		((Control)obj29).Location = location;
		((Control)cboCreateDate).Name = "cboCreateDate";
		ComboBox obj30 = cboCreateDate;
		size = new Size(85, 21);
		((Control)obj30).Size = size;
		((Control)cboCreateDate).TabIndex = 12;
		Label7.AutoSize = true;
		Label label11 = Label7;
		location = new System.Drawing.Point(10, 23);
		((Control)label11).Location = location;
		((Control)Label7).Name = "Label7";
		Label label12 = Label7;
		size = new Size(50, 13);
		((Control)label12).Size = size;
		((Control)Label7).TabIndex = 1051;
		Label7.Text = "Ngày tạo";
		((Control)ProgressBar1).Anchor = (AnchorStyles)14;
		ProgressBar progressBar = ProgressBar1;
		location = new System.Drawing.Point(309, 704);
		((Control)progressBar).Location = location;
		((Control)ProgressBar1).Name = "ProgressBar1";
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(455, 23);
		((Control)progressBar2).Size = size;
		((Control)ProgressBar1).TabIndex = 1054;
		((Control)ProgressBar1).Visible = false;
		((ButtonBase)chkCheckCTAll).AutoSize = true;
		CheckBox obj31 = chkCheckCTAll;
		location = new System.Drawing.Point(57, 46);
		((Control)obj31).Location = location;
		((Control)chkCheckCTAll).Name = "chkCheckCTAll";
		CheckBox obj32 = chkCheckCTAll;
		size = new Size(66, 17);
		((Control)obj32).Size = size;
		((Control)chkCheckCTAll).TabIndex = 11;
		((ButtonBase)chkCheckCTAll).Text = "Chọn tất";
		((ButtonBase)chkCheckCTAll).UseVisualStyleBackColor = true;
		((Control)chkDmAll).Anchor = (AnchorStyles)13;
		((ButtonBase)chkDmAll).AutoSize = true;
		CheckBox obj33 = chkDmAll;
		location = new System.Drawing.Point(57, 48);
		((Control)obj33).Location = location;
		((Control)chkDmAll).Name = "chkDmAll";
		CheckBox obj34 = chkDmAll;
		size = new Size(66, 17);
		((Control)obj34).Size = size;
		((Control)chkDmAll).TabIndex = 17;
		((ButtonBase)chkDmAll).Text = "Chọn tất";
		((ButtonBase)chkDmAll).UseVisualStyleBackColor = true;
		Label8.AutoSize = true;
		Label label13 = Label8;
		location = new System.Drawing.Point(163, -35);
		((Control)label13).Location = location;
		((Control)Label8).Name = "Label8";
		Label label14 = Label8;
		size = new Size(49, 13);
		((Control)label14).Size = size;
		((Control)Label8).TabIndex = 1055;
		Label8.Text = "Tìm kiếm";
		Label9.AutoSize = true;
		Label label15 = Label9;
		location = new System.Drawing.Point(163, 48);
		((Control)label15).Location = location;
		((Control)Label9).Name = "Label9";
		Label label16 = Label9;
		size = new Size(49, 13);
		((Control)label16).Size = size;
		((Control)Label9).TabIndex = 1056;
		Label9.Text = "Tìm kiếm";
		((Control)gbCt).Anchor = (AnchorStyles)15;
		((Control)gbCt).Controls.Add((Control)(object)Label5);
		((Control)gbCt).Controls.Add((Control)(object)dgvSoLieu);
		((Control)gbCt).Controls.Add((Control)(object)txtFilter1);
		((Control)gbCt).Controls.Add((Control)(object)Label8);
		((Control)gbCt).Controls.Add((Control)(object)chkCheckCTAll);
		((Control)gbCt).Controls.Add((Control)(object)cboKyBc);
		((Control)gbCt).Controls.Add((Control)(object)lbl2);
		((Control)gbCt).Controls.Add((Control)(object)lblKyBc);
		((Control)gbCt).Controls.Add((Control)(object)txtNgay2);
		((Control)gbCt).Controls.Add((Control)(object)txtNgay1);
		((Control)gbCt).Enabled = false;
		GroupBox obj35 = gbCt;
		location = new System.Drawing.Point(6, 110);
		((Control)obj35).Location = location;
		((Control)gbCt).Name = "gbCt";
		GroupBox obj36 = gbCt;
		size = new Size(764, 284);
		((Control)obj36).Size = size;
		((Control)gbCt).TabIndex = 1;
		gbCt.TabStop = false;
		gbCt.Text = "Chứng từ";
		Label5.AutoSize = true;
		Label label17 = Label5;
		location = new System.Drawing.Point(168, 47);
		((Control)label17).Location = location;
		((Control)Label5).Name = "Label5";
		Label label18 = Label5;
		size = new Size(49, 13);
		((Control)label18).Size = size;
		((Control)Label5).TabIndex = 1057;
		Label5.Text = "Tìm kiếm";
		((Control)gbDanhMuc).Anchor = (AnchorStyles)14;
		((Control)gbDanhMuc).Controls.Add((Control)(object)txtNgay4);
		((Control)gbDanhMuc).Controls.Add((Control)(object)chkDmAll);
		((Control)gbDanhMuc).Controls.Add((Control)(object)Label9);
		((Control)gbDanhMuc).Controls.Add((Control)(object)dgvDanhMuc);
		((Control)gbDanhMuc).Controls.Add((Control)(object)Label7);
		((Control)gbDanhMuc).Controls.Add((Control)(object)Label6);
		((Control)gbDanhMuc).Controls.Add((Control)(object)cboCreateDate);
		((Control)gbDanhMuc).Controls.Add((Control)(object)txtFilter2);
		((Control)gbDanhMuc).Controls.Add((Control)(object)txtNgay3);
		((Control)gbDanhMuc).Enabled = false;
		GroupBox obj37 = gbDanhMuc;
		location = new System.Drawing.Point(6, 400);
		((Control)obj37).Location = location;
		((Control)gbDanhMuc).Name = "gbDanhMuc";
		GroupBox obj38 = gbDanhMuc;
		size = new Size(761, 298);
		((Control)obj38).Size = size;
		((Control)gbDanhMuc).TabIndex = 2;
		gbDanhMuc.TabStop = false;
		gbDanhMuc.Text = "Danh mục";
		((Control)Label10).Anchor = (AnchorStyles)6;
		Label label19 = Label10;
		location = new System.Drawing.Point(174, 704);
		((Control)label19).Location = location;
		((Control)Label10).Name = "Label10";
		Label label20 = Label10;
		size = new Size(129, 23);
		((Control)label20).Size = size;
		((Control)Label10).TabIndex = 1055;
		Label10.Text = "Xin chờ một tí ...";
		Label10.TextAlign = (ContentAlignment)64;
		((Control)Label10).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(773, 739);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)gbCt);
		((Control)this).Controls.Add((Control)(object)ProgressBar1);
		((Control)this).Controls.Add((Control)(object)Label10);
		((Control)this).Controls.Add((Control)(object)gbDanhMuc);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSiImExData";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbDanhMuc, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)Label10, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdOK, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)ProgressBar1, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbCt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbInput, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((ISupportInitialize)dgvSoLieu).EndInit();
		((ISupportInitialize)dgvDanhMuc).EndInit();
		((Control)gbCt).ResumeLayout(false);
		((Control)gbCt).PerformLayout();
		((Control)gbDanhMuc).ResumeLayout(false);
		((Control)gbDanhMuc).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (rbExport.Checked)
		{
			if ((f_tblsl.Select("tag=1").Count() == 0) & (f_tbldm.Select("tag=1").Count() == 0))
			{
				CMessageBox.Show(50087);
				return;
			}
			ImportAllDataToTable();
			ProgressBar1.Maximum = f_tblCopy.Select().Count();
			ProgressBar1.Value = 0;
			((Control)ProgressBar1).Visible = true;
			((Control)ProgressBar1).Show();
			((Control)lbl2).Visible = true;
			worker_thread = new Thread(Load_Excel_Details);
			worker_thread.CurrentCulture = new CultureInfo("en-US");
			worker_thread.Start();
		}
		else if (rbImport.Checked)
		{
			worker_thread = new Thread(ImportFromExcel);
			worker_thread.CurrentCulture = new CultureInfo("en-US");
			worker_thread.Start();
		}
	}

	private void ImportFromExcel()
	{
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (File.Exists(txtPath.Text))
		{
			try
			{
				string fileName = Path.GetFileName(txtPath.Text);
				string[] array = fileName.Substring(0, checked(fileName.Length - 4)).Split(new char[1] { '_' });
				if (Operators.CompareString(array[1].ToString(), CompanyInformations.CompanyID.ToString(), false) != 0)
				{
					CMessageBox.Show("Mã cty không đúng", "Thông báo", (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
				else
				{
					string format = "Phiên bản: {0} \rTừ công ty: {1} đến công ty " + CompanyInformations.CompanyID.ToString() + "\rws_id: {2} \rNgày ct bắt đầu: {3}\rNgày ct kết thúc: {4}\rCần sao lưu dữ liệu khi thực hiện, bạn có muốn tiếp tục không ?";
					if ((int)CMessageBox.Show(string.Format(format, array[0], array[1], array[2], DateTime.Parse(array[3]).ToString("dd/MM/yyyy"), DateTime.Parse(array[4]).ToString("dd/MM/yyyy")), "Thông báo", (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
					{
						Workbook workbook = null;
						Application application = new ApplicationClass();
						try
						{
							workbook = application.Workbooks.Open(txtPath.Text, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
						ProgressBar1.Maximum = workbook.Worksheets.Count;
						((Control)ProgressBar1).Visible = true;
						ProgressBar1.Value = 0;
						((Control)ProgressBar1).Show();
						worker_thread = new Thread([SpecialName] [DebuggerStepThrough] (object a0) =>
						{
							GetDataFromExcel(Conversions.ToString(a0));
						});
						worker_thread.Start(txtPath.Text);
						worker_thread.Join();
						((Control)this).Invoke((Delegate)new Action<string>(UpdateStatus), new object[1] { "Xin chờ trong giây lát " });
						Progress.BeginInvoke(dsAllData, Conversions.ToString(Helper.Repl_Null(array[2], isNum: false)), DateTime.Parse(array[3]), DateTime.Parse(array[4]), null, null);
					}
				}
				return;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Helper.ProcessError(ex4.ToString());
				CMessageBox.Show(99999);
				ProjectData.ClearProjectError();
				return;
			}
		}
		CMessageBox.Show(50109);
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		Thread.CurrentThread.Abort();
		((Form)this).Close();
	}

	private void frmSiImExData_Load(object sender, EventArgs e)
	{
		Progress = LoadDataFromExcelToXml;
		initbeforeLoadData();
		LoadDataGrid();
		initTableCopy();
		InitKyBaoCao();
	}

	private void txtFilter1_TextChanged(object sender, EventArgs e)
	{
		string rowFilter = "description like '%" + txtFilter1.Text.Trim() + "%'";
		f_tblsl.DefaultView.RowFilter = rowFilter;
	}

	private void txtFilter2_TextChanged(object sender, EventArgs e)
	{
		string rowFilter = "description like '%" + txtFilter2.Text.Trim() + "%'";
		f_tbldm.DefaultView.RowFilter = rowFilter;
	}

	private void btnOpen_Click(object sender, EventArgs e)
	{
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (rbExport.Checked)
			{
				OpenFolder.SelectedPath = Application.StartupPath + "\\Excel";
				((CommonDialog)OpenFolder).ShowDialog();
				txtPath.Text = OpenFolder.SelectedPath;
				TextBox val = txtPath;
				val.Text = val.Text + "\\v" + txtVersion.Text + "_" + CompanyInformations.CompanyID + "_" + txtWsId.Text + "_" + DateTime.Parse(Conversions.ToString(txtNgay1.Value)).ToString("MM-dd-yyyy") + "_" + DateTime.Parse(Conversions.ToString(txtNgay2.Value)).ToString("MM-dd-yyyy") + ".xls";
			}
			else
			{
				((FileDialog)OpenFile).InitialDirectory = Application.StartupPath + "\\Excel";
				((FileDialog)OpenFile).Filter = "All Excel Files |*.xls;*.xlsl ";
				((CommonDialog)OpenFile).ShowDialog();
				txtPath.Text = ((FileDialog)OpenFile).FileName.ToString();
			}
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

	private void rbImport_CheckedChanged(object sender, EventArgs e)
	{
		if (rbImport.Checked)
		{
			((Control)txtPath).Enabled = true;
			((Control)btnOpen).Enabled = true;
			((Control)gbCt).Enabled = false;
			((Control)gbDanhMuc).Enabled = false;
		}
		else
		{
			((Control)txtPath).Enabled = false;
			initbeforeLoadData();
			((Control)gbCt).Enabled = true;
			((Control)gbDanhMuc).Enabled = true;
		}
	}

	private void chkCheckCTAll_CheckedChanged(object sender, EventArgs e)
	{
		DataRow[] array = f_tblsl.Select();
		foreach (DataRow dataRow in array)
		{
			dataRow["tag"] = chkCheckCTAll.Checked;
		}
		((ContainerControl)this).BindingContext[(object)f_tblsl].EndCurrentEdit();
	}

	private void chkDmAll_CheckedChanged(object sender, EventArgs e)
	{
		DataRow[] array = f_tbldm.Select();
		foreach (DataRow dataRow in array)
		{
			dataRow["tag"] = chkDmAll.Checked;
		}
		((ContainerControl)this).BindingContext[(object)f_tbldm].EndCurrentEdit();
	}

	private void txtNgay1_TextChanged(object sender, EventArgs e)
	{
		initbeforeLoadData();
	}

	private void txtNgay2_TextChanged(object sender, EventArgs e)
	{
		initbeforeLoadData();
	}

	private void UpdateStatus(string st)
	{
		((Control)Label10).Visible = true;
		Label10.Text = st;
	}

	private void UpdateData()
	{
		if (ProgressBar1.Value != ProgressBar1.Maximum)
		{
			ProgressBar progressBar = ProgressBar1;
			progressBar.Value = checked(progressBar.Value + 1);
		}
	}

	private void ProcessCompled()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (ProgressBar1.Value == ProgressBar1.Maximum)
		{
			Thread.Sleep(100);
			CMessageBox.Show(50015);
			((Control)ProgressBar1).Visible = false;
		}
	}

	private void ImportAllDataToTable()
	{
		f_tblCopy.Clear();
		f_tblsl.EndInit();
		f_tbldm.EndInit();
		DataRow[] array = f_tblsl.Select("Tag = 1");
		foreach (DataRow dataRow in array)
		{
			bool flag = f_tblCopy.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"table_name like'", Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["table1"]), isNum: false)), (object)"'"))).Any();
			bool flag2 = f_tblCopy.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"table_name like'", Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["table4"]), isNum: false)), (object)"'"))).Any();
			bool flag3 = f_tblCopy.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"table_name like'", Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["table5"]), isNum: false)), (object)"'"))).Any();
			if (flag)
			{
				DataRow[] array2 = f_tblCopy.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"table_name like'", Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["table1"]), isNum: false)), (object)"'")));
				foreach (DataRow dataRow2 in array2)
				{
					dataRow2["code_name"] = Operators.AddObject(Operators.AddObject(dataRow2["code_name"], dataRow["code_name"]), (object)",");
				}
				DataRow[] array3 = f_tblCopy.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"table_name like'", Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["table2"]), isNum: false)), (object)"'")));
				foreach (DataRow dataRow3 in array3)
				{
					dataRow3["code_name"] = Operators.AddObject(Operators.AddObject(dataRow3["code_name"], dataRow["code_name"]), (object)",");
				}
				DataRow[] array4 = f_tblCopy.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"table_name like'", Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["table3"]), isNum: false)), (object)"'")));
				foreach (DataRow dataRow4 in array4)
				{
					dataRow4["code_name"] = Operators.AddObject(Operators.AddObject(dataRow4["code_name"], dataRow["code_name"]), (object)",");
				}
			}
			else
			{
				DataRow dataRow5 = f_tblCopy.NewRow();
				dataRow5["code_name"] = Operators.AddObject(Operators.AddObject((object)",", dataRow["code_name"]), (object)",");
				dataRow5["description"] = RuntimeHelpers.GetObjectValue(dataRow["description"]);
				dataRow5["table_name"] = RuntimeHelpers.GetObjectValue(dataRow["table1"]);
				dataRow5["type"] = RuntimeHelpers.GetObjectValue(dataRow["type"]);
				if (Operators.ConditionalCompareObjectEqual(dataRow["type"], (object)"CTU", false))
				{
					dataRow5["type"] = "PH";
				}
				f_tblCopy.Rows.Add(dataRow5);
				if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["table2"]), isNum: false), (object)"", false))
				{
					DataRow dataRow6 = f_tblCopy.NewRow();
					dataRow6["code_name"] = Operators.AddObject(Operators.AddObject((object)",", dataRow["code_name"]), (object)",");
					dataRow6["description"] = RuntimeHelpers.GetObjectValue(dataRow["description"]);
					dataRow6["table_name"] = RuntimeHelpers.GetObjectValue(dataRow["table2"]);
					dataRow6["type"] = RuntimeHelpers.GetObjectValue(dataRow["type"]);
					if (Operators.ConditionalCompareObjectEqual(dataRow["type"], (object)"CTU", false))
					{
						dataRow6["type"] = "CT";
					}
					f_tblCopy.Rows.Add(dataRow6);
				}
				if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["table3"]), isNum: false), (object)"", false))
				{
					DataRow dataRow7 = f_tblCopy.NewRow();
					dataRow7["code_name"] = Operators.AddObject(Operators.AddObject((object)",", dataRow["code_name"]), (object)",");
					dataRow7["description"] = RuntimeHelpers.GetObjectValue(dataRow["description"]);
					dataRow7["table_name"] = RuntimeHelpers.GetObjectValue(dataRow["table3"]);
					dataRow7["type"] = RuntimeHelpers.GetObjectValue(dataRow["type"]);
					if (Operators.ConditionalCompareObjectEqual(dataRow["type"], (object)"CTU", false))
					{
						dataRow7["type"] = "CP";
					}
					f_tblCopy.Rows.Add(dataRow7);
				}
			}
			if (flag2)
			{
				DataRow[] array5 = f_tblCopy.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"table_name like'", Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["table4"]), isNum: false)), (object)"'")));
				foreach (DataRow dataRow8 in array5)
				{
					dataRow8["code_name"] = Operators.AddObject(Operators.AddObject(dataRow8["code_name"], dataRow["code_name"]), (object)",");
				}
			}
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["table4"]), isNum: false), (object)"", false), (object)(!flag2))))
			{
				DataRow dataRow9 = f_tblCopy.NewRow();
				dataRow9["code_name"] = Operators.AddObject(Operators.AddObject((object)",", dataRow["code_name"]), (object)",");
				dataRow9["description"] = RuntimeHelpers.GetObjectValue(dataRow["description"]);
				dataRow9["table_name"] = RuntimeHelpers.GetObjectValue(dataRow["table4"]);
				dataRow9["type"] = RuntimeHelpers.GetObjectValue(dataRow["type"]);
				if (Operators.ConditionalCompareObjectEqual(dataRow["type"], (object)"CTU", false))
				{
					dataRow9["type"] = "TAIN";
				}
				f_tblCopy.Rows.Add(dataRow9);
			}
			if (flag3)
			{
				DataRow[] array6 = f_tblCopy.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"table_name like'", Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["table5"]), isNum: false)), (object)"'")));
				foreach (DataRow dataRow10 in array6)
				{
					dataRow10["code_name"] = Operators.AddObject(Operators.AddObject(dataRow10["code_name"], dataRow["code_name"]), (object)",");
				}
			}
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["table5"]), isNum: false), (object)"", false), (object)(!flag3))))
			{
				DataRow dataRow11 = f_tblCopy.NewRow();
				dataRow11["code_name"] = Operators.AddObject(Operators.AddObject((object)",", dataRow["code_name"]), (object)",");
				dataRow11["description"] = RuntimeHelpers.GetObjectValue(dataRow["description"]);
				dataRow11["table_name"] = RuntimeHelpers.GetObjectValue(dataRow["table5"]);
				dataRow11["type"] = RuntimeHelpers.GetObjectValue(dataRow["type"]);
				if (Operators.ConditionalCompareObjectEqual(dataRow["type"], (object)"CTU", false))
				{
					dataRow11["type"] = "TAOUT";
				}
				f_tblCopy.Rows.Add(dataRow11);
			}
		}
		DataRow[] array7 = f_tbldm.Select("Tag = 1");
		foreach (DataRow dataRow12 in array7)
		{
			DataRow dataRow13 = f_tblCopy.NewRow();
			dataRow13["code_name"] = RuntimeHelpers.GetObjectValue(dataRow12["code_name"]);
			dataRow13["description"] = RuntimeHelpers.GetObjectValue(dataRow12["description"]);
			dataRow13["table_name"] = RuntimeHelpers.GetObjectValue(dataRow12["table1"]);
			dataRow13["type"] = RuntimeHelpers.GetObjectValue(dataRow12["type"]);
			f_tblCopy.Rows.Add(dataRow13);
		}
	}

	private void LoadDataGrid()
	{
		ISiImExDataDAO siImExDataDAO = (ISiImExDataDAO)DAOFactory.CreateDAOInstance("SiImExDataDAO", "SiImExData", a_blnIsSysDB: true);
		DataSet dataToCombo = siImExDataDAO.GetDataToCombo(CompanyInformations.CompanyID, "");
		f_tblsl = dataToCombo.Tables[0];
		f_tbldm = dataToCombo.Tables[1];
		dgvSoLieu.DataSource = f_tblsl.DefaultView;
		dgvDanhMuc.DataSource = f_tbldm.DefaultView;
	}

	private void initTableCopy()
	{
		DataColumn column = new DataColumn("code_name", Type.GetType("System.String"));
		f_tblCopy.Columns.Add(column);
		DataColumn column2 = new DataColumn("description", Type.GetType("System.String"));
		f_tblCopy.Columns.Add(column2);
		DataColumn column3 = new DataColumn("table_name", Type.GetType("System.String"));
		f_tblCopy.Columns.Add(column3);
		DataColumn column4 = new DataColumn("Type", Type.GetType("System.String"));
		f_tblCopy.Columns.Add(column4);
	}

	private void initbeforeLoadData()
	{
		txtWsId.Text = AsiaErp.Framework.Environment.GetSIConfiguration().ws_id;
		txtVersion.Text = SystemInformations.ProductVersion;
		txtPath.Text = Application.StartupPath + "\\Excel\\v" + txtVersion.Text + "_" + CompanyInformations.CompanyID + "_" + txtWsId.Text + "_" + DateTime.Parse(Conversions.ToString(txtNgay1.Value)).ToString("MM-dd-yyyy") + "_" + DateTime.Parse(Conversions.ToString(txtNgay2.Value)).ToString("MM-dd-yyyy") + ".xls";
		((FileDialog)OpenFile).FileName = txtPath.Text;
	}

	private void Load_Excel_Details()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (f_tblCopy == null)
				{
					Interaction.MsgBox((object)"Dữ liệu không hợp lệ", (MsgBoxStyle)16, (object)null);
					return;
				}
				Application application = new ApplicationClass();
				if (application == null)
				{
					Interaction.MsgBox((object)"It appears that Excel is not installed on this machine. This operation requires MS Excel to be installed on this machine.", (MsgBoxStyle)16, (object)null);
					return;
				}
				((Control)this).Invoke((Delegate)new Action<string>(UpdateStatus), new object[1] { "Xin chờ trong giây lát" });
				application.SheetsInNewWorkbook = f_tblCopy.Rows.Count;
				application.Workbooks.Add(Missing.Value);
				int num = 0;
				int num2 = 0;
				DataRow[] array = f_tblCopy.Select();
				foreach (DataRow dataRow in array)
				{
					num++;
					object[] parameter = new object[4] { application, dataRow, num, null };
					worker_thread = new Thread([SpecialName] [DebuggerStepThrough] (object a0) =>
					{
						ExportDataToExcel((object[])a0);
					});
					worker_thread.Start(parameter);
					worker_thread.Join();
					num2++;
				}
				Thread.Sleep(50);
				application.ActiveCell.Worksheet.SaveAs(txtPath.Text, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				Marshal.ReleaseComObject(application);
				application = null;
				Process[] processesByName = Process.GetProcessesByName("EXCEL");
				Process[] array2 = processesByName;
				foreach (Process process in array2)
				{
					process.Kill();
				}
				Interaction.MsgBox((object)("Dữ liệu được xuất sang excel thành công tại thư mục '" + txtPath.Text + "'"), (MsgBoxStyle)64, (object)null);
				((Control)this).Invoke((Delegate)new Action(ProcessCompled));
				((Control)this).Invoke((Delegate)new Action<string>(UpdateStatus), new object[1] { "" });
				GC.Collect();
				GC.WaitForPendingFinalizers();
				GC.Collect();
				GC.WaitForPendingFinalizers();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Process[] processesByName2 = Process.GetProcessesByName("EXCEL");
				Process[] array3 = processesByName2;
				foreach (Process process2 in array3)
				{
					process2.Kill();
				}
				Helper.ProcessError(ex2.ToString());
				CMessageBox.Show(99999);
				ProjectData.ClearProjectError();
			}
		}
	}

	private string ConvertDateMMddyyy(AsMaskedTextBox txtDate)
	{
		return DateTime.Parse(Conversions.ToString(txtDate.Value)).ToString("MM/dd/yyyy");
	}

	private string CollectConditions(DataRow dr)
	{
		if (dr == null)
		{
			return string.Empty;
		}
		string text = ConvertDateMMddyyy(txtNgay1);
		string text2 = ConvertDateMMddyyy(txtNgay2);
		string text3 = ConvertDateMMddyyy(txtNgay3);
		string text4 = ConvertDateMMddyyy(txtNgay4);
		string text5 = "where 1=1";
		if (Operators.CompareString(dr["type"].ToString().ToUpper(), "PH", false) == 0)
		{
			text5 = text5 + " and ngay_ct between '" + text + "' and '" + text2 + "'";
			text5 = Conversions.ToString(Operators.AddObject((object)text5, Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)" and '", dr["code_name"]), (object)"'"), (object)" like "), (object)"'%,' "), (object)"+ ma_ct +"), (object)" ',%'")));
		}
		else if ((Operators.CompareString(dr["type"].ToString().ToUpper(), "CT", false) == 0) | (Operators.CompareString(dr["type"].ToString().ToUpper(), "CP", false) == 0) | (Operators.CompareString(dr["type"].ToString().ToUpper(), "TAIN", false) == 0) | (Operators.CompareString(dr["type"].ToString().ToUpper(), "TAOUT", false) == 0))
		{
			string text6 = "";
			DataRow[] array = f_tblCopy.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)" code_name = '", dr["code_name"]), (object)"' and type='PH'")));
			foreach (DataRow dataRow in array)
			{
				text6 = Conversions.ToString(dataRow["table_Name"]);
			}
			if (Operators.CompareString(text6, "", false) == 0)
			{
				DataRow[] array2 = f_tblCopy.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)" code_name = '", dr["code_name"]), (object)"' and type='TAIN'")));
				foreach (DataRow dataRow2 in array2)
				{
					text6 = Conversions.ToString(dataRow2["table_Name"]);
				}
			}
			if (Operators.CompareString(text6, "", false) == 0)
			{
				DataRow[] array3 = f_tblCopy.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)" code_name = '", dr["code_name"]), (object)"' and type='TAOUT'")));
				foreach (DataRow dataRow3 in array3)
				{
					text6 = Conversions.ToString(dataRow3["table_Name"]);
				}
			}
			text5 = "where 1=1";
			text5 = Conversions.ToString(Operators.AddObject((object)text5, Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(" and stt_rec in (select stt_rec from " + text6, " where ngay_ct between "), "'"), text), "'"), " and "), "'"), text2), "'"), " and "), "'"), dr["code_name"]), (object)"'"), (object)" like "), (object)"'%,' "), (object)"+ ma_ct +"), (object)" ',%'"), (object)")")));
		}
		else if (Operators.CompareString(dr["type"].ToString().ToUpper(), "DM", false) == 0)
		{
			text5 = text5 + " and cdate between '" + text3 + "' and '" + text4 + "'";
		}
		return text5;
	}

	private void ExportDataToExcel(object[] Para)
	{
		if ((Para == null && Para.Length != 3) ? true : false)
		{
			return;
		}
		Application application = (Application)Para[0];
		DataRow dataRow = (DataRow)Para[1];
		int num = Conversions.ToInteger(Para[2]);
		string pWhere = CollectConditions(dataRow);
		ISiImExDataDAO siImExDataDAO = (ISiImExDataDAO)DAOFactory.CreateDAOInstance("SiImExDataDAO", "SiImExData");
		System.Data.DataTable dataTable = null;
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["table_name"]), isNum: false), (object)"", false))
		{
			dataTable = siImExDataDAO.GetDataToCopy(CompanyInformations.CompanyID, Conversions.ToString(dataRow["table_name"]), pWhere);
		}
		Application application2 = application;
		NewLateBinding.LateCall(application2.Worksheets[num], (Type)null, "Select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSetComplex(application2.Worksheets[num], (Type)null, "Name", new object[1] { RuntimeHelpers.GetObjectValue(dataRow["table_name"]) }, (string[])null, (Type[])null, false, true);
		application2.Cells.NumberFormat = "@";
		int num2 = 1;
		checked
		{
			int num3 = dataTable.Columns.Count - 1;
			int num4 = 0;
			while (true)
			{
				int num5 = num4;
				int num6 = num3;
				if (num5 > num6)
				{
					break;
				}
				NewLateBinding.LateSetComplex(application2.Cells[1, num2], (Type)null, "value", new object[1] { dataTable.Columns[num4].ColumnName }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(application2.Cells[1, num2], (Type)null, "EntireRow", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bold", new object[1] { true }, (string[])null, (Type[])null, false, true);
				num2++;
				num4++;
			}
			int num7 = dataTable.Rows.Count - 1;
			int num8 = dataTable.Columns.Count - 1;
			object[,] array = new object[num7 + 1, num8 + 1];
			int num9 = dataTable.Rows.Count - 1;
			int num10 = 0;
			while (true)
			{
				int num11 = num10;
				int num6 = num9;
				if (num11 > num6)
				{
					break;
				}
				DataRow dataRow2 = dataTable.Rows[num10];
				int num12 = dataTable.Columns.Count - 1;
				int num13 = 0;
				while (true)
				{
					int num14 = num13;
					num6 = num12;
					if (num14 > num6)
					{
						break;
					}
					array[num10, num13] = dataRow2[num13].ToString();
					num13++;
				}
				num10++;
			}
			if (dataTable.Rows.Count > 0)
			{
				Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)NewLateBinding.LateGet(application.Worksheets[num], (Type)null, "Cells", new object[2] { 2, 1 }, (string[])null, (Type[])null, (bool[])null);
				Microsoft.Office.Interop.Excel.Range range2 = (Microsoft.Office.Interop.Excel.Range)NewLateBinding.LateGet(application.Worksheets[num], (Type)null, "Cells", new object[2]
				{
					1 + dataTable.Rows.Count,
					dataTable.Columns.Count
				}, (string[])null, (Type[])null, (bool[])null);
				object obj = application.Worksheets[num];
				object[] array2 = new object[2] { range, range2 };
				bool[] array3 = new bool[2] { true, true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Range", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					range = (Microsoft.Office.Interop.Excel.Range)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(Microsoft.Office.Interop.Excel.Range));
				}
				if (array3[1])
				{
					range2 = (Microsoft.Office.Interop.Excel.Range)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(Microsoft.Office.Interop.Excel.Range));
				}
				Microsoft.Office.Interop.Excel.Range range3 = (Microsoft.Office.Interop.Excel.Range)obj2;
				range3.NumberFormat = "@";
				range3.Value2 = array;
			}
			application2 = null;
			((Control)this).Invoke((Delegate)new Action(UpdateData));
		}
	}

	private void GetDataFromExcel(string a_sFilepath)
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		checked
		{
			if (dsAllData != null)
			{
				int num = dsAllData.Tables.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					dsAllData.Tables.RemoveAt(0);
					num2++;
				}
			}
			try
			{
				if (a_sFilepath.Equals(""))
				{
					MessageBox.Show("Chưa chọn file !", "Lỗi !", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				Workbook workbook = null;
				ApplicationClass applicationClass = new ApplicationClass();
				try
				{
					workbook = applicationClass.Workbooks.Open(txtPath.Text, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					MessageBox.Show("Không thể mở file Excel", "Lỗi mở file !", (MessageBoxButtons)0, (MessageBoxIcon)16);
					ProjectData.ClearProjectError();
				}
				int count = workbook.Worksheets.Count;
				int num5 = 1;
				while (true)
				{
					int num6 = num5;
					int num4 = count;
					if (num6 > num4)
					{
						break;
					}
					Worksheet worksheet = (Worksheet)workbook.Worksheets[num5];
					OleDbConnection val = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0; data source=" + a_sFilepath + "; Extended Properties=Excel 8.0");
					OleDbDataAdapter val2 = new OleDbDataAdapter("select * from [" + worksheet.Name + "$]", val);
					((DbDataAdapter)(object)val2).Fill(dsAllData, worksheet.Name);
					num5++;
				}
				workbook.Close(Missing.Value, Missing.Value, Missing.Value);
				workbook = null;
				applicationClass.Quit();
				applicationClass = null;
				Marshal.ReleaseComObject(applicationClass);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Helper.ProcessError(ex4.ToString());
				CMessageBox.Show(99999);
				ProjectData.ClearProjectError();
			}
			finally
			{
				GC.Collect();
				GC.WaitForPendingFinalizers();
			}
		}
	}

	private void LoadDataFromExcelToXml(DataSet ds, string ws_id, DateTime ngay1, DateTime ngay2)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object[] array = new object[6] { null, ws_id, ngay1, ngay2, null, null };
			foreach (System.Data.DataTable table in ds.Tables)
			{
				DAOInformation dAOInformation = AsiaErp.Framework.Environment.GetDAOInformation(table.TableName);
				array[0] = table;
				array[4] = dAOInformation.del_sp;
				worker_thread = new Thread([SpecialName] [DebuggerStepThrough] (object a0) =>
				{
					InsertDataFromXml((object[])a0);
				});
				worker_thread.Start(array);
				worker_thread.Join();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			CMessageBox.Show(99999);
			ProjectData.ClearProjectError();
		}
		finally
		{
			((Control)this).Invoke((Delegate)new Action(ProcessCompled));
			((Control)this).Invoke((Delegate)new Action<string>(UpdateStatus), new object[1] { "" });
		}
	}

	private void InsertDataFromXml(object[] para)
	{
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		System.Data.DataTable dataTable = (System.Data.DataTable)para[0];
		string pWs_id = Conversions.ToString(para[1]);
		DateTime dateTime = Conversions.ToDate(para[2]);
		DateTime dateTime2 = Conversions.ToDate(para[3]);
		string pProc = Conversions.ToString(para[4]);
		string text = ",";
		try
		{
			foreach (DataColumn column in dataTable.Columns)
			{
				if (column.ColumnName.Contains("_x"))
				{
					column.ColumnName = column.ColumnName.Replace("_x", "_X");
				}
			}
			if ((dataTable.Columns.Contains("ma_ct") && dataTable.TableName.Contains("PH")) ? true : false)
			{
				DataRow[] array = dataTable.Select();
				foreach (DataRow dataRow in array)
				{
					if (!text.Contains(Conversions.ToString(dataRow["ma_ct"])))
					{
						text = Conversions.ToString(Operators.AddObject(Operators.AddObject((object)text, dataRow["ma_ct"]), (object)","));
					}
				}
			}
			StringWriter stringWriter = new StringWriter();
			dataTable.WriteXml((TextWriter?)stringWriter);
			ISiImExDataDAO siImExDataDAO = (ISiImExDataDAO)DAOFactory.CreateDAOInstance("SiImExDataDAO", "SiImExData");
			int num = 0;
			num = siImExDataDAO.InsertData(stringWriter.ToString(), dataTable.TableName, pWs_id, Conversions.ToDate(dateTime.ToString("MM/dd/yyyy")), Conversions.ToDate(dateTime2.ToString("MM/dd/yyyy")), pProc, CompanyInformations.CompanyID, 1, text);
			siImExDataDAO.Destroy();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			CMessageBox.Show(99999);
			ProjectData.ClearProjectError();
		}
		finally
		{
			((Control)this).Invoke((Delegate)new Action(UpdateData));
		}
	}

	private void cboKyBc_SelectedValueChanged(object sender, EventArgs e)
	{
		if (cboKyBc.DataSource != null)
		{
			if (Operators.CompareString(((KyBaoCao)cboKyBc.SelectedItem).ma, "NGAY", false) != 0)
			{
				AsMaskedTextBox asMaskedTextBox = txtNgay1;
				DateTime dateTime = new DateTime(SystemInformations.FinancialYear, ((KyBaoCao)cboKyBc.SelectedItem).thang1, 1);
				asMaskedTextBox.Value = dateTime;
				AsMaskedTextBox asMaskedTextBox2 = txtNgay2;
				dateTime = new DateTime(SystemInformations.FinancialYear, ((KyBaoCao)cboKyBc.SelectedItem).thang2, 1);
				DateTime dateTime2 = dateTime;
				asMaskedTextBox2.Value = dateTime2.AddMonths(1).AddDays(-1.0);
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
		}
	}

	private void cboCreateDate_SelectedValueChanged(object sender, EventArgs e)
	{
		if (cboCreateDate.DataSource != null)
		{
			if (Operators.CompareString(((KyBaoCao)cboCreateDate.SelectedItem).ma, "NGAY", false) != 0)
			{
				AsMaskedTextBox asMaskedTextBox = txtNgay3;
				DateTime dateTime = new DateTime(SystemInformations.FinancialYear, ((KyBaoCao)cboCreateDate.SelectedItem).thang1, 1);
				asMaskedTextBox.Value = dateTime;
				AsMaskedTextBox asMaskedTextBox2 = txtNgay4;
				dateTime = new DateTime(SystemInformations.FinancialYear, ((KyBaoCao)cboCreateDate.SelectedItem).thang2, 1);
				DateTime dateTime2 = dateTime;
				asMaskedTextBox2.Value = dateTime2.AddMonths(1).AddDays(-1.0);
				((MaskedTextBox)txtNgay3).ReadOnly = true;
				((Control)txtNgay3).TabStop = false;
				((MaskedTextBox)txtNgay4).ReadOnly = true;
				((Control)txtNgay4).TabStop = false;
			}
			else
			{
				((MaskedTextBox)txtNgay3).ReadOnly = false;
				((Control)txtNgay3).TabStop = true;
				((MaskedTextBox)txtNgay4).ReadOnly = false;
				((Control)txtNgay4).TabStop = true;
			}
		}
	}

	private void InitKyBaoCao()
	{
		cboKyBc.DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc);
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"", false))
		{
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"NGAY", false))
			{
				try
				{
					txtNgay1.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct1"));
					txtNgay2.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct2"));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			((ListControl)cboKyBc).SelectedValue = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao"));
		}
		else
		{
			cboKyBc.SelectedIndex = 0;
		}
		cboCreateDate.DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc);
		((ListControl)cboCreateDate).ValueMember = "ma";
		((ListControl)cboCreateDate).DisplayMember = "ten_ky";
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"", false))
		{
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"NGAY", false))
			{
				try
				{
					txtNgay3.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct1"));
					txtNgay4.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct2"));
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
			}
			((ListControl)cboCreateDate).SelectedValue = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao"));
		}
		else
		{
			cboCreateDate.SelectedIndex = 0;
		}
	}

	private void SaveKyBaoCao()
	{
		AsiaErp.Framework.Environment.set_PublicVariables("KyBaoCao", (object)((KyBaoCao)cboKyBc.SelectedItem).ma);
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
	}
}
