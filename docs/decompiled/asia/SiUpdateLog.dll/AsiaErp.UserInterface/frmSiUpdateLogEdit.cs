using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using AsiaErp.ToolCommon;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSiUpdateLogEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("dgvDetail")]
	private AsInputDGV _dgvDetail;

	[AccessedThroughProperty("txtBugNumber")]
	private TextBox _txtBugNumber;

	[AccessedThroughProperty("txtDescription")]
	private TextBox _txtDescription;

	[AccessedThroughProperty("cboProductId")]
	private ComboBox _cboProductId;

	[AccessedThroughProperty("lblProductName")]
	private Label _lblProductName;

	[AccessedThroughProperty("lblBugNumber")]
	private Label _lblBugNumber;

	[AccessedThroughProperty("lblDescription")]
	private Label _lblDescription;

	[AccessedThroughProperty("txtNote")]
	private TextBox _txtNote;

	[AccessedThroughProperty("lblNote")]
	private Label _lblNote;

	[AccessedThroughProperty("bsType")]
	private BindingSource _bsType;

	[AccessedThroughProperty("opF")]
	private OpenFileDialog _opF;

	[AccessedThroughProperty("rdbDB")]
	private RadioButton _rdbDB;

	[AccessedThroughProperty("rdbFile")]
	private RadioButton _rdbFile;

	[AccessedThroughProperty("dgvcName")]
	private DataGridViewTextBoxColumn _dgvcName;

	[AccessedThroughProperty("dgvcTypeName")]
	private DataGridViewTextBoxColumn _dgvcTypeName;

	[AccessedThroughProperty("dgvcLast_Modify")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcLast_Modify;

	[AccessedThroughProperty("dgvcFullPath")]
	private DataGridViewTextBoxColumn _dgvcFullPath;

	[AccessedThroughProperty("lblFunction")]
	private Label _lblFunction;

	[AccessedThroughProperty("adgvFunction")]
	private AsInputDGV _adgvFunction;

	[AccessedThroughProperty("lblModule")]
	private Label _lblModule;

	[AccessedThroughProperty("adgvModule")]
	private AsInputDGV _adgvModule;

	[AccessedThroughProperty("lblCaption")]
	private Label _lblCaption;

	[AccessedThroughProperty("txtFunctionName")]
	private TextBox _txtFunctionName;

	[AccessedThroughProperty("txtFunctionMenuid")]
	private TextBox _txtFunctionMenuid;

	[AccessedThroughProperty("pnModule")]
	private Panel _pnModule;

	[AccessedThroughProperty("chkAllModule")]
	private CheckBox _chkAllModule;

	[AccessedThroughProperty("pnFunction")]
	private Panel _pnFunction;

	[AccessedThroughProperty("chkAllFunction")]
	private CheckBox _chkAllFunction;

	[AccessedThroughProperty("lblLinkNumber")]
	private Label _lblLinkNumber;

	[AccessedThroughProperty("adgvcCheckedM")]
	private DataGridViewCheckBoxColumn _adgvcCheckedM;

	[AccessedThroughProperty("adgvcModuleIDM")]
	private DataGridViewTextBoxColumn _adgvcModuleIDM;

	[AccessedThroughProperty("adgvcMenuidM")]
	private DataGridViewTextBoxColumn _adgvcMenuidM;

	[AccessedThroughProperty("adgvcBarM")]
	private DataGridViewTextBoxColumn _adgvcBarM;

	[AccessedThroughProperty("adgvcCheckedF")]
	private DataGridViewCheckBoxColumn _adgvcCheckedF;

	[AccessedThroughProperty("adgvcModuleIDF")]
	private DataGridViewTextBoxColumn _adgvcModuleIDF;

	[AccessedThroughProperty("adgvcBarF")]
	private DataGridViewTextBoxColumn _adgvcBarF;

	[AccessedThroughProperty("adgvcMenuidF")]
	private DataGridViewTextBoxColumn _adgvcMenuidF;

	[AccessedThroughProperty("txtLinkNumber")]
	private AsTextBox _txtLinkNumber;

	[AccessedThroughProperty("lblLookupName")]
	private Label _lblLookupName;

	public static DataTable f_dtDetail;

	private DataTable f_dtFilter;

	private DataTable oDtModule;

	private DataTable oDtFunction;

	private DataTable oTblDM;

	internal virtual AsInputDGV dgvDetail
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvDetail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvDetail = value;
		}
	}

	internal virtual TextBox txtBugNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtBugNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtBugNumber = value;
		}
	}

	internal virtual TextBox txtDescription
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDescription;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDescription = value;
		}
	}

	internal virtual ComboBox cboProductId
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboProductId;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboProductId = value;
		}
	}

	internal virtual Label lblProductName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblProductName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblProductName = value;
		}
	}

	internal virtual Label lblBugNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblBugNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblBugNumber = value;
		}
	}

	internal virtual Label lblDescription
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDescription;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDescription = value;
		}
	}

	internal virtual TextBox txtNote
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNote;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNote = value;
		}
	}

	internal virtual Label lblNote
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNote;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNote = value;
		}
	}

	internal virtual BindingSource bsType
	{
		[DebuggerNonUserCode]
		get
		{
			return _bsType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_bsType = value;
		}
	}

	internal virtual OpenFileDialog opF
	{
		[DebuggerNonUserCode]
		get
		{
			return _opF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_opF = value;
		}
	}

	internal virtual RadioButton rdbDB
	{
		[DebuggerNonUserCode]
		get
		{
			return _rdbDB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rdbDB = value;
		}
	}

	internal virtual RadioButton rdbFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _rdbFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rdbFile = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcName
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcName = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTypeName
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTypeName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTypeName = value;
		}
	}

	internal virtual DataGridViewAsMaskedTextBoxColumn dgvcLast_Modify
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcLast_Modify;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcLast_Modify = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcFullPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcFullPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcFullPath = value;
		}
	}

	internal virtual Label lblFunction
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFunction;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFunction = value;
		}
	}

	internal virtual AsInputDGV adgvFunction
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvFunction;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvFunction_CellContentClick);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvFunction_CellContentClick);
			if (_adgvFunction != null)
			{
				((DataGridView)_adgvFunction).CellContentDoubleClick -= val;
				((DataGridView)_adgvFunction).CellContentClick -= val2;
			}
			_adgvFunction = value;
			if (_adgvFunction != null)
			{
				((DataGridView)_adgvFunction).CellContentDoubleClick += val;
				((DataGridView)_adgvFunction).CellContentClick += val2;
			}
		}
	}

	internal virtual Label lblModule
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblModule;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblModule = value;
		}
	}

	internal virtual AsInputDGV adgvModule
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvModule;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvModule_CellContentClick);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvModule_CellContentClick);
			if (_adgvModule != null)
			{
				((DataGridView)_adgvModule).CellContentDoubleClick -= val;
				((DataGridView)_adgvModule).CellContentClick -= val2;
			}
			_adgvModule = value;
			if (_adgvModule != null)
			{
				((DataGridView)_adgvModule).CellContentDoubleClick += val;
				((DataGridView)_adgvModule).CellContentClick += val2;
			}
		}
	}

	internal virtual Label lblCaption
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCaption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCaption = value;
		}
	}

	internal virtual TextBox txtFunctionName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFunctionName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtFunctionName = value;
		}
	}

	internal virtual TextBox txtFunctionMenuid
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFunctionMenuid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtFunctionMenuid = value;
		}
	}

	internal virtual Panel pnModule
	{
		[DebuggerNonUserCode]
		get
		{
			return _pnModule;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_pnModule = value;
		}
	}

	internal virtual CheckBox chkAllModule
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkAllModule;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkAllModule_CheckedChanged;
			if (_chkAllModule != null)
			{
				_chkAllModule.CheckedChanged -= eventHandler;
			}
			_chkAllModule = value;
			if (_chkAllModule != null)
			{
				_chkAllModule.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual Panel pnFunction
	{
		[DebuggerNonUserCode]
		get
		{
			return _pnFunction;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_pnFunction = value;
		}
	}

	internal virtual CheckBox chkAllFunction
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkAllFunction;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkAllFunction_CheckedChanged;
			if (_chkAllFunction != null)
			{
				_chkAllFunction.CheckedChanged -= eventHandler;
			}
			_chkAllFunction = value;
			if (_chkAllFunction != null)
			{
				_chkAllFunction.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblLinkNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLinkNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLinkNumber = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn adgvcCheckedM
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcCheckedM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcCheckedM = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn adgvcModuleIDM
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcModuleIDM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcModuleIDM = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn adgvcMenuidM
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcMenuidM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcMenuidM = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn adgvcBarM
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcBarM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcBarM = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn adgvcCheckedF
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcCheckedF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcCheckedF = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn adgvcModuleIDF
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcModuleIDF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcModuleIDF = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn adgvcBarF
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcBarF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcBarF = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn adgvcMenuidF
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcMenuidF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcMenuidF = value;
		}
	}

	internal virtual AsTextBox txtLinkNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLinkNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = txtLinkNumber_Validated;
			KeyEventHandler val = new KeyEventHandler(txtLinkNumber_KeyDown);
			if (_txtLinkNumber != null)
			{
				((Control)_txtLinkNumber).Validated -= eventHandler;
				((Control)_txtLinkNumber).KeyDown -= val;
			}
			_txtLinkNumber = value;
			if (_txtLinkNumber != null)
			{
				((Control)_txtLinkNumber).Validated += eventHandler;
				((Control)_txtLinkNumber).KeyDown += val;
			}
		}
	}

	internal virtual Label lblLookupName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLookupName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLookupName = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSiUpdateLogEdit()
	{
		__ENCAddToList(this);
		InitializeComponent();
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Expected O, but got Unknown
		//IL_10a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Expected O, but got Unknown
		//IL_14e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f2: Expected O, but got Unknown
		//IL_1c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6b: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		dgvDetail = new AsInputDGV();
		dgvcName = new DataGridViewTextBoxColumn();
		dgvcTypeName = new DataGridViewTextBoxColumn();
		dgvcLast_Modify = new DataGridViewAsMaskedTextBoxColumn();
		dgvcFullPath = new DataGridViewTextBoxColumn();
		txtBugNumber = new TextBox();
		txtDescription = new TextBox();
		cboProductId = new ComboBox();
		lblProductName = new Label();
		lblBugNumber = new Label();
		lblDescription = new Label();
		txtNote = new TextBox();
		lblNote = new Label();
		bsType = new BindingSource(components);
		opF = new OpenFileDialog();
		rdbFile = new RadioButton();
		rdbDB = new RadioButton();
		adgvModule = new AsInputDGV();
		adgvcCheckedM = new DataGridViewCheckBoxColumn();
		adgvcModuleIDM = new DataGridViewTextBoxColumn();
		adgvcMenuidM = new DataGridViewTextBoxColumn();
		adgvcBarM = new DataGridViewTextBoxColumn();
		lblModule = new Label();
		lblFunction = new Label();
		adgvFunction = new AsInputDGV();
		adgvcCheckedF = new DataGridViewCheckBoxColumn();
		adgvcModuleIDF = new DataGridViewTextBoxColumn();
		adgvcBarF = new DataGridViewTextBoxColumn();
		adgvcMenuidF = new DataGridViewTextBoxColumn();
		lblCaption = new Label();
		txtFunctionMenuid = new TextBox();
		txtFunctionName = new TextBox();
		pnModule = new Panel();
		chkAllModule = new CheckBox();
		pnFunction = new Panel();
		chkAllFunction = new CheckBox();
		lblLinkNumber = new Label();
		txtLinkNumber = new AsTextBox();
		lblLookupName = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((ISupportInitialize)dgvDetail).BeginInit();
		((ISupportInitialize)bsType).BeginInit();
		((ISupportInitialize)adgvModule).BeginInit();
		((ISupportInitialize)adgvFunction).BeginInit();
		((Control)pnModule).SuspendLayout();
		((Control)pnFunction).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(-50, -50);
		((Control)asCheckBox).Location = location;
		AsCheckBox asCheckBox2 = chkKsd;
		Size size = new Size(100, 18);
		((Control)asCheckBox2).Size = size;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 650);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 650);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblLookupName);
		((Control)gbLine).Controls.Add((Control)(object)txtLinkNumber);
		((Control)gbLine).Controls.Add((Control)(object)lblLinkNumber);
		((Control)gbLine).Controls.Add((Control)(object)pnFunction);
		((Control)gbLine).Controls.Add((Control)(object)pnModule);
		((Control)gbLine).Controls.Add((Control)(object)txtFunctionName);
		((Control)gbLine).Controls.Add((Control)(object)txtFunctionMenuid);
		((Control)gbLine).Controls.Add((Control)(object)lblCaption);
		((Control)gbLine).Controls.Add((Control)(object)rdbDB);
		((Control)gbLine).Controls.Add((Control)(object)rdbFile);
		((Control)gbLine).Controls.Add((Control)(object)txtNote);
		((Control)gbLine).Controls.Add((Control)(object)lblNote);
		((Control)gbLine).Controls.Add((Control)(object)dgvDetail);
		((Control)gbLine).Controls.Add((Control)(object)txtBugNumber);
		((Control)gbLine).Controls.Add((Control)(object)txtDescription);
		((Control)gbLine).Controls.Add((Control)(object)cboProductId);
		((Control)gbLine).Controls.Add((Control)(object)lblProductName);
		((Control)gbLine).Controls.Add((Control)(object)lblBugNumber);
		((Control)gbLine).Controls.Add((Control)(object)lblDescription);
		((Control)gbLine).Controls.Add((Control)(object)lblModule);
		((Control)gbLine).Controls.Add((Control)(object)lblFunction);
		GroupBox obj3 = gbLine;
		size = new Size(863, 638);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblFunction, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblModule, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDescription, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblBugNumber, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblProductName, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboProductId, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDescription, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtBugNumber, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)dgvDetail, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNote, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNote, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)rdbFile, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)rdbDB, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblCaption, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtFunctionMenuid, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtFunctionName, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)pnModule, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)pnFunction, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblLinkNumber, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtLinkNumber, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblLookupName, 0);
		((DataGridView)dgvDetail).AllowUserToAddRows = false;
		((DataGridView)dgvDetail).AllowUserToDeleteRows = false;
		((Control)dgvDetail).Anchor = (AnchorStyles)14;
		((DataGridView)dgvDetail).BackgroundColor = Color.White;
		((DataGridView)dgvDetail).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvDetail).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)dgvcName,
			(DataGridViewColumn)dgvcTypeName,
			dgvcLast_Modify,
			(DataGridViewColumn)dgvcFullPath
		});
		((DataGridView)dgvDetail).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = dgvDetail;
		location = new Point(10, 474);
		((Control)asInputDGV).Location = location;
		((Control)dgvDetail).Name = "dgvDetail";
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDetail).RowHeadersDefaultCellStyle = val;
		((DataGridView)dgvDetail).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = dgvDetail;
		size = new Size(843, 158);
		((Control)asInputDGV2).Size = size;
		((Control)dgvDetail).TabIndex = 9;
		((DataGridViewColumn)dgvcName).DataPropertyName = "Name";
		((DataGridViewColumn)dgvcName).HeaderText = "Name";
		((DataGridViewColumn)dgvcName).Name = "dgvcName";
		((DataGridViewColumn)dgvcName).ReadOnly = true;
		dgvcName.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcName).Width = 150;
		((DataGridViewColumn)dgvcTypeName).DataPropertyName = "TypeName";
		((DataGridViewColumn)dgvcTypeName).HeaderText = "Type";
		((DataGridViewColumn)dgvcTypeName).Name = "dgvcTypeName";
		((DataGridViewColumn)dgvcTypeName).ReadOnly = true;
		((DataGridViewColumn)dgvcTypeName).Resizable = (DataGridViewTriState)1;
		dgvcTypeName.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTypeName).Width = 80;
		((DataGridViewColumn)dgvcLast_Modify).DataPropertyName = "Last_Modify";
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcLast_Modify).DefaultCellStyle = val2;
		dgvcLast_Modify.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcLast_Modify).HeaderText = "Last Edit";
		dgvcLast_Modify.Mask = "##/##/####";
		((DataGridViewColumn)dgvcLast_Modify).Name = "dgvcLast_Modify";
		((DataGridViewColumn)dgvcLast_Modify).ReadOnly = true;
		((DataGridViewColumn)dgvcLast_Modify).Resizable = (DataGridViewTriState)1;
		dgvcLast_Modify.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcLast_Modify).Width = 80;
		((DataGridViewColumn)dgvcFullPath).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)dgvcFullPath).DataPropertyName = "FullPath";
		((DataGridViewColumn)dgvcFullPath).HeaderText = "Path ";
		((DataGridViewColumn)dgvcFullPath).Name = "dgvcFullPath";
		((DataGridViewColumn)dgvcFullPath).ReadOnly = true;
		dgvcFullPath.SortMode = (DataGridViewColumnSortMode)0;
		TextBox obj4 = txtBugNumber;
		location = new Point(436, 14);
		((Control)obj4).Location = location;
		((Control)txtBugNumber).Name = "txtBugNumber";
		TextBox obj5 = txtBugNumber;
		size = new Size(53, 20);
		((Control)obj5).Size = size;
		((Control)txtBugNumber).TabIndex = 1;
		((Control)txtDescription).Anchor = (AnchorStyles)6;
		TextBox obj6 = txtDescription;
		location = new Point(90, 330);
		((Control)obj6).Location = location;
		txtDescription.Multiline = true;
		((Control)txtDescription).Name = "txtDescription";
		TextBox obj7 = txtDescription;
		size = new Size(253, 114);
		((Control)obj7).Size = size;
		((Control)txtDescription).TabIndex = 5;
		cboProductId.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboProductId).FormattingEnabled = true;
		ComboBox obj8 = cboProductId;
		location = new Point(90, 13);
		((Control)obj8).Location = location;
		((Control)cboProductId).Name = "cboProductId";
		ComboBox obj9 = cboProductId;
		size = new Size(253, 22);
		((Control)obj9).Size = size;
		((Control)cboProductId).TabIndex = 0;
		lblProductName.AutoSize = true;
		Label obj10 = lblProductName;
		location = new Point(9, 16);
		((Control)obj10).Location = location;
		((Control)lblProductName).Name = "lblProductName";
		Label obj11 = lblProductName;
		size = new Size(74, 14);
		((Control)obj11).Size = size;
		((Control)lblProductName).TabIndex = 10;
		lblProductName.Text = "Product Name";
		lblBugNumber.AutoSize = true;
		Label obj12 = lblBugNumber;
		location = new Point(360, 16);
		((Control)obj12).Location = location;
		((Control)lblBugNumber).Name = "lblBugNumber";
		Label obj13 = lblBugNumber;
		size = new Size(65, 14);
		((Control)obj13).Size = size;
		((Control)lblBugNumber).TabIndex = 11;
		lblBugNumber.Text = "Bug number";
		((Control)lblDescription).Anchor = (AnchorStyles)6;
		lblDescription.AutoSize = true;
		Label obj14 = lblDescription;
		location = new Point(9, 330);
		((Control)obj14).Location = location;
		((Control)lblDescription).Name = "lblDescription";
		Label obj15 = lblDescription;
		size = new Size(61, 14);
		((Control)obj15).Size = size;
		((Control)lblDescription).TabIndex = 15;
		lblDescription.Text = "Description";
		((Control)txtNote).Anchor = (AnchorStyles)14;
		TextBox obj16 = txtNote;
		location = new Point(436, 330);
		((Control)obj16).Location = location;
		txtNote.Multiline = true;
		((Control)txtNote).Name = "txtNote";
		TextBox obj17 = txtNote;
		size = new Size(417, 114);
		((Control)obj17).Size = size;
		((Control)txtNote).TabIndex = 6;
		((Control)lblNote).Anchor = (AnchorStyles)6;
		lblNote.AutoSize = true;
		Label obj18 = lblNote;
		location = new Point(360, 330);
		((Control)obj18).Location = location;
		((Control)lblNote).Name = "lblNote";
		Label obj19 = lblNote;
		size = new Size(29, 14);
		((Control)obj19).Size = size;
		((Control)lblNote).TabIndex = 14;
		lblNote.Text = "Note";
		opF.Multiselect = true;
		((Control)rdbFile).Anchor = (AnchorStyles)6;
		((ButtonBase)rdbFile).AutoSize = true;
		rdbFile.Checked = true;
		RadioButton obj20 = rdbFile;
		location = new Point(10, 450);
		((Control)obj20).Location = location;
		((Control)rdbFile).Name = "rdbFile";
		RadioButton obj21 = rdbFile;
		size = new Size(41, 18);
		((Control)obj21).Size = size;
		((Control)rdbFile).TabIndex = 7;
		rdbFile.TabStop = true;
		((ButtonBase)rdbFile).Text = "File";
		((ButtonBase)rdbFile).UseVisualStyleBackColor = true;
		((Control)rdbDB).Anchor = (AnchorStyles)6;
		((ButtonBase)rdbDB).AutoSize = true;
		RadioButton obj22 = rdbDB;
		location = new Point(57, 450);
		((Control)obj22).Location = location;
		((Control)rdbDB).Name = "rdbDB";
		RadioButton obj23 = rdbDB;
		size = new Size(71, 18);
		((Control)obj23).Size = size;
		((Control)rdbDB).TabIndex = 8;
		rdbDB.TabStop = true;
		((ButtonBase)rdbDB).Text = "Database";
		((ButtonBase)rdbDB).UseVisualStyleBackColor = true;
		((DataGridView)adgvModule).AllowUserToAddRows = false;
		((DataGridView)adgvModule).AllowUserToDeleteRows = false;
		((DataGridView)adgvModule).AllowUserToResizeColumns = false;
		((DataGridView)adgvModule).AllowUserToResizeRows = false;
		((DataGridView)adgvModule).BackgroundColor = Color.White;
		((DataGridView)adgvModule).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvModule).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvModule).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)adgvcCheckedM,
			(DataGridViewColumn)adgvcModuleIDM,
			(DataGridViewColumn)adgvcMenuidM,
			(DataGridViewColumn)adgvcBarM
		});
		((Control)adgvModule).Dock = (DockStyle)5;
		((DataGridView)adgvModule).EditMode = (DataGridViewEditMode)0;
		((DataGridView)adgvModule).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV3 = adgvModule;
		location = new Point(0, 0);
		((Control)asInputDGV3).Location = location;
		((Control)adgvModule).Name = "adgvModule";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvModule).RowHeadersDefaultCellStyle = val3;
		((DataGridView)adgvModule).RowHeadersVisible = false;
		((DataGridView)adgvModule).RowTemplate.Height = 20;
		((DataGridView)adgvModule).SelectionMode = (DataGridViewSelectionMode)1;
		AsInputDGV asInputDGV4 = adgvModule;
		size = new Size(253, 284);
		((Control)asInputDGV4).Size = size;
		((Control)adgvModule).TabIndex = 1;
		((DataGridViewColumn)adgvcCheckedM).DataPropertyName = "CHECKED";
		((DataGridViewColumn)adgvcCheckedM).HeaderText = "";
		((DataGridViewColumn)adgvcCheckedM).Name = "adgvcCheckedM";
		((DataGridViewColumn)adgvcCheckedM).Width = 20;
		((DataGridViewColumn)adgvcModuleIDM).DataPropertyName = "MODULEID";
		((DataGridViewColumn)adgvcModuleIDM).HeaderText = "ID";
		((DataGridViewColumn)adgvcModuleIDM).Name = "adgvcModuleIDM";
		((DataGridViewColumn)adgvcModuleIDM).ReadOnly = true;
		((DataGridViewColumn)adgvcModuleIDM).Resizable = (DataGridViewTriState)2;
		adgvcModuleIDM.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)adgvcModuleIDM).Width = 30;
		((DataGridViewColumn)adgvcMenuidM).DataPropertyName = "MENUID";
		val4.Alignment = (DataGridViewContentAlignment)32;
		((DataGridViewColumn)adgvcMenuidM).DefaultCellStyle = val4;
		((DataGridViewColumn)adgvcMenuidM).HeaderText = "Menud ID";
		((DataGridViewColumn)adgvcMenuidM).Name = "adgvcMenuidM";
		((DataGridViewColumn)adgvcMenuidM).ReadOnly = true;
		((DataGridViewColumn)adgvcMenuidM).Resizable = (DataGridViewTriState)2;
		adgvcMenuidM.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)adgvcMenuidM).Visible = false;
		((DataGridViewColumn)adgvcMenuidM).Width = 60;
		((DataGridViewColumn)adgvcBarM).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)adgvcBarM).DataPropertyName = "BAR";
		((DataGridViewColumn)adgvcBarM).HeaderText = "Phân hệ";
		((DataGridViewColumn)adgvcBarM).Name = "adgvcBarM";
		((DataGridViewColumn)adgvcBarM).ReadOnly = true;
		((DataGridViewColumn)adgvcBarM).Resizable = (DataGridViewTriState)2;
		adgvcBarM.SortMode = (DataGridViewColumnSortMode)0;
		lblModule.AutoSize = true;
		Label obj24 = lblModule;
		location = new Point(9, 45);
		((Control)obj24).Location = location;
		((Control)lblModule).Name = "lblModule";
		Label obj25 = lblModule;
		size = new Size(41, 14);
		((Control)obj25).Size = size;
		((Control)lblModule).TabIndex = 12;
		lblModule.Text = "Module";
		lblFunction.AutoSize = true;
		Label obj26 = lblFunction;
		location = new Point(360, 45);
		((Control)obj26).Location = location;
		((Control)lblFunction).Name = "lblFunction";
		Label obj27 = lblFunction;
		size = new Size(48, 14);
		((Control)obj27).Size = size;
		((Control)lblFunction).TabIndex = 13;
		lblFunction.Text = "Function";
		((DataGridView)adgvFunction).AllowUserToAddRows = false;
		((DataGridView)adgvFunction).AllowUserToDeleteRows = false;
		((DataGridView)adgvFunction).AllowUserToResizeColumns = false;
		((DataGridView)adgvFunction).AllowUserToResizeRows = false;
		((DataGridView)adgvFunction).BackgroundColor = Color.White;
		((DataGridView)adgvFunction).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvFunction).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvFunction).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)adgvcCheckedF,
			(DataGridViewColumn)adgvcModuleIDF,
			(DataGridViewColumn)adgvcBarF,
			(DataGridViewColumn)adgvcMenuidF
		});
		((Control)adgvFunction).Dock = (DockStyle)5;
		((DataGridView)adgvFunction).EditMode = (DataGridViewEditMode)0;
		((DataGridView)adgvFunction).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV5 = adgvFunction;
		location = new Point(0, 0);
		((Control)asInputDGV5).Location = location;
		((Control)adgvFunction).Name = "adgvFunction";
		val5.Alignment = (DataGridViewContentAlignment)32;
		val5.BackColor = SystemColors.Control;
		val5.Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		val5.ForeColor = SystemColors.WindowText;
		val5.SelectionBackColor = SystemColors.Highlight;
		val5.SelectionForeColor = SystemColors.HighlightText;
		val5.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvFunction).RowHeadersDefaultCellStyle = val5;
		((DataGridView)adgvFunction).RowHeadersVisible = false;
		((DataGridView)adgvFunction).RowTemplate.Height = 20;
		((DataGridView)adgvFunction).SelectionMode = (DataGridViewSelectionMode)1;
		AsInputDGV asInputDGV6 = adgvFunction;
		size = new Size(417, 284);
		((Control)asInputDGV6).Size = size;
		((Control)adgvFunction).TabIndex = 1;
		((DataGridViewColumn)adgvcCheckedF).DataPropertyName = "CHECKED";
		((DataGridViewColumn)adgvcCheckedF).HeaderText = "";
		((DataGridViewColumn)adgvcCheckedF).Name = "adgvcCheckedF";
		((DataGridViewColumn)adgvcCheckedF).Width = 20;
		((DataGridViewColumn)adgvcModuleIDF).DataPropertyName = "MODULEID";
		((DataGridViewColumn)adgvcModuleIDF).HeaderText = "ID";
		((DataGridViewColumn)adgvcModuleIDF).Name = "adgvcModuleIDF";
		((DataGridViewColumn)adgvcModuleIDF).ReadOnly = true;
		((DataGridViewColumn)adgvcModuleIDF).Resizable = (DataGridViewTriState)2;
		adgvcModuleIDF.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)adgvcModuleIDF).Width = 30;
		((DataGridViewColumn)adgvcBarF).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)adgvcBarF).DataPropertyName = "BAR";
		((DataGridViewColumn)adgvcBarF).HeaderText = "Tên chức năng";
		((DataGridViewColumn)adgvcBarF).Name = "adgvcBarF";
		((DataGridViewColumn)adgvcBarF).ReadOnly = true;
		adgvcBarF.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)adgvcMenuidF).DataPropertyName = "MENUID";
		val6.Alignment = (DataGridViewContentAlignment)32;
		((DataGridViewColumn)adgvcMenuidF).DefaultCellStyle = val6;
		((DataGridViewColumn)adgvcMenuidF).HeaderText = "Menud ID";
		((DataGridViewColumn)adgvcMenuidF).Name = "adgvcMenuidF";
		((DataGridViewColumn)adgvcMenuidF).ReadOnly = true;
		((DataGridViewColumn)adgvcMenuidF).Resizable = (DataGridViewTriState)2;
		adgvcMenuidF.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)adgvcMenuidF).Visible = false;
		((DataGridViewColumn)adgvcMenuidF).Width = 60;
		((Control)lblCaption).Anchor = (AnchorStyles)10;
		Label obj28 = lblCaption;
		location = new Point(687, 451);
		((Control)obj28).Location = location;
		((Control)lblCaption).Name = "lblCaption";
		Label obj29 = lblCaption;
		size = new Size(166, 17);
		((Control)obj29).Size = size;
		((Control)lblCaption).TabIndex = 16;
		lblCaption.Text = "F4 - AddRow; F8 - DelateRow";
		lblCaption.TextAlign = (ContentAlignment)64;
		TextBox obj30 = txtFunctionMenuid;
		location = new Point(400, -30);
		((Control)obj30).Location = location;
		((Control)txtFunctionMenuid).Name = "txtFunctionMenuid";
		TextBox obj31 = txtFunctionMenuid;
		size = new Size(100, 20);
		((Control)obj31).Size = size;
		((Control)txtFunctionMenuid).TabIndex = 101;
		((Control)txtFunctionMenuid).TabStop = false;
		TextBox obj32 = txtFunctionName;
		location = new Point(300, -30);
		((Control)obj32).Location = location;
		((Control)txtFunctionName).Name = "txtFunctionName";
		TextBox obj33 = txtFunctionName;
		size = new Size(100, 20);
		((Control)obj33).Size = size;
		((Control)txtFunctionName).TabIndex = 102;
		((Control)txtFunctionName).TabStop = false;
		((Control)pnModule).Anchor = (AnchorStyles)7;
		((Control)pnModule).Controls.Add((Control)(object)chkAllModule);
		((Control)pnModule).Controls.Add((Control)(object)adgvModule);
		Panel obj34 = pnModule;
		location = new Point(90, 40);
		((Control)obj34).Location = location;
		((Control)pnModule).Name = "pnModule";
		Panel obj35 = pnModule;
		size = new Size(253, 284);
		((Control)obj35).Size = size;
		((Control)pnModule).TabIndex = 3;
		((ButtonBase)chkAllModule).AutoSize = true;
		CheckBox obj36 = chkAllModule;
		location = new Point(5, 4);
		((Control)obj36).Location = location;
		((Control)chkAllModule).Name = "chkAllModule";
		CheckBox obj37 = chkAllModule;
		size = new Size(15, 14);
		((Control)obj37).Size = size;
		((Control)chkAllModule).TabIndex = 0;
		((ButtonBase)chkAllModule).UseVisualStyleBackColor = true;
		((Control)pnFunction).Anchor = (AnchorStyles)15;
		((Control)pnFunction).Controls.Add((Control)(object)chkAllFunction);
		((Control)pnFunction).Controls.Add((Control)(object)adgvFunction);
		Panel obj38 = pnFunction;
		location = new Point(436, 40);
		((Control)obj38).Location = location;
		((Control)pnFunction).Name = "pnFunction";
		Panel obj39 = pnFunction;
		size = new Size(417, 284);
		((Control)obj39).Size = size;
		((Control)pnFunction).TabIndex = 4;
		((ButtonBase)chkAllFunction).AutoSize = true;
		CheckBox obj40 = chkAllFunction;
		location = new Point(5, 4);
		((Control)obj40).Location = location;
		((Control)chkAllFunction).Name = "chkAllFunction";
		CheckBox obj41 = chkAllFunction;
		size = new Size(15, 14);
		((Control)obj41).Size = size;
		((Control)chkAllFunction).TabIndex = 0;
		((ButtonBase)chkAllFunction).UseVisualStyleBackColor = true;
		((Control)lblLinkNumber).Anchor = (AnchorStyles)9;
		lblLinkNumber.AutoSize = true;
		Label obj42 = lblLinkNumber;
		location = new Point(500, 17);
		((Control)obj42).Location = location;
		((Control)lblLinkNumber).Name = "lblLinkNumber";
		Label obj43 = lblLinkNumber;
		size = new Size(65, 14);
		((Control)obj43).Size = size;
		((Control)lblLinkNumber).TabIndex = 103;
		lblLinkNumber.Text = "Link number";
		txtLinkNumber.AutoLookup = false;
		txtLinkNumber.AutoValid = false;
		((TextBoxBase)txtLinkNumber).BackColor = SystemColors.Info;
		((TextBox)txtLinkNumber).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtLinkNumber;
		location = new Point(571, 14);
		((Control)asTextBox).Location = location;
		txtLinkNumber.LookupCodeName = "";
		((Control)txtLinkNumber).Name = "txtLinkNumber";
		txtLinkNumber.NameControl = null;
		AsTextBox asTextBox2 = txtLinkNumber;
		size = new Size(53, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtLinkNumber).TabIndex = 2;
		txtLinkNumber.UseAutoCompleteSource = true;
		((Control)lblLookupName).Anchor = (AnchorStyles)13;
		Label obj44 = lblLookupName;
		location = new Point(630, 14);
		((Control)obj44).Location = location;
		((Control)lblLookupName).Name = "lblLookupName";
		Label obj45 = lblLookupName;
		size = new Size(223, 20);
		((Control)obj45).Size = size;
		((Control)lblLookupName).TabIndex = 104;
		lblLookupName.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 14f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(887, 681);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmSiUpdateLogEdit";
		((Form)this).Text = "frmSiUpdateLogEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((ISupportInitialize)dgvDetail).EndInit();
		((ISupportInitialize)bsType).EndInit();
		((ISupportInitialize)adgvModule).EndInit();
		((ISupportInitialize)adgvFunction).EndInit();
		((Control)pnModule).ResumeLayout(false);
		((Control)pnModule).PerformLayout();
		((Control)pnFunction).ResumeLayout(false);
		((Control)pnFunction).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private bool InsertDetail()
	{
		int num = 0;
		int num2 = 1;
		SIUpdateLogDAO sIUpdateLogDAO = (SIUpdateLogDAO)DAOFactory.CreateDAOInstance("SIUpdateLogDAO", "SIUpdateLog");
		num = sIUpdateLogDAO.DelUpdateLogCT(Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["Id"]), isNum: true)));
		sIUpdateLogDAO.Destroy();
		foreach (DataRowView item in f_dtDetail.DefaultView)
		{
			item["Item_ID"] = Strings.Right("000" + num2, 3);
			item["ID"] = RuntimeHelpers.GetObjectValue(RowToEdit["Id"]);
			ArrayList arrayList = new ArrayList();
			arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Item_ID"]), isNum: false)));
			arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["ID"]), isNum: false)));
			arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Name"]), isNum: false)));
			arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Type"]), isNum: false)));
			arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["Last_Modify"]), isNum: false)));
			arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["FullPath"]), isNum: false)));
			SIUpdateLogDAO sIUpdateLogDAO2 = (SIUpdateLogDAO)DAOFactory.CreateDAOInstance("SIUpdateLogDAO", "SIUpdateLog");
			num = sIUpdateLogDAO2.InsUpdateLogCT(arrayList.ToArray());
			sIUpdateLogDAO2.Destroy();
			num2 = checked(num2 + 1);
			if (num != 0)
			{
				break;
			}
		}
		f_dtDetail.AcceptChanges();
		SIUpdateLogDAO sIUpdateLogDAO3 = (SIUpdateLogDAO)DAOFactory.CreateDAOInstance("SIUpdateLogDAO", "SIUpdateLog");
		int num3 = sIUpdateLogDAO3.InsHistory(Conversions.ToInteger(RowToEdit["ID"]));
		sIUpdateLogDAO3.Destroy();
		if ((num == 0 && num3 == 0) ? true : false)
		{
			return true;
		}
		return false;
	}

	private object CheckExitFiles()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		foreach (DataGridViewRow item in (IEnumerable)((DataGridView)dgvDetail).Rows)
		{
			DataGridViewRow val = item;
			DataRowView dataRowView = f_dtDetail.DefaultView[((DataGridViewBand)val).Index];
			if (Operators.ConditionalCompareObjectEqual(dataRowView["Type"], (object)1, false) || File.Exists(Conversions.ToString(dataRowView["FullPath"])))
			{
				continue;
			}
			((DataGridView)dgvDetail)["dgvcFullPath", ((DataGridViewBand)val).Index].ErrorText = "File không tồn tại!";
			return false;
		}
		return true;
	}

	private void InsertObjectUpdateToDetail()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		frmFilterOjectToUpdate frmFilterOjectToUpdate2 = new frmFilterOjectToUpdate();
		((Form)frmFilterOjectToUpdate2).ShowDialog();
		DataRow[] array = frmFilterOjectToUpdate2.f_dtFilter.Select("chon = 1");
		foreach (DataRow dataRow in array)
		{
			DataRow dataRow2 = f_dtDetail.NewRow();
			dataRow2["ID"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["ID"]), isNum: true));
			dataRow2["Name"] = RuntimeHelpers.GetObjectValue(dataRow["Name"]);
			dataRow2["Type"] = RuntimeHelpers.GetObjectValue(dataRow["Type"]);
			dataRow2["Last_modify"] = RuntimeHelpers.GetObjectValue(dataRow["Last_modify"]);
			dataRow2["FullPath"] = RuntimeHelpers.GetObjectValue(dataRow["FullPath"]);
			f_dtDetail.Rows.Add(dataRow2);
		}
		((Component)(object)frmFilterOjectToUpdate2).Dispose();
	}

	private void GetModule()
	{
		SIUpdateLogDAO sIUpdateLogDAO = (SIUpdateLogDAO)DAOFactory.CreateDAOInstance("SIUpdateLogDAO", "SIUpdateLog", a_blnIsSysDB: true);
		oDtModule = sIUpdateLogDAO.GetModule(isModule: true);
		sIUpdateLogDAO.Destroy();
		((DataGridView)adgvModule).DataSource = oDtModule;
	}

	private void GetFunction()
	{
		SIUpdateLogDAO sIUpdateLogDAO = (SIUpdateLogDAO)DAOFactory.CreateDAOInstance("SIUpdateLogDAO", "SIUpdateLog", a_blnIsSysDB: true);
		oDtFunction = sIUpdateLogDAO.GetModule(isModule: false);
		sIUpdateLogDAO.Destroy();
		((DataGridView)adgvFunction).DataSource = oDtFunction.DefaultView;
		FunctionFilter();
	}

	private void FunctionFilter()
	{
		string text = "";
		string text2 = "";
		int num = 0;
		checked
		{
			foreach (DataRow row in oDtModule.Rows)
			{
				if (!Operators.ConditionalCompareObjectEqual(row["checked"], (object)false, false))
				{
					text = text + "'" + Strings.Left(Conversions.ToString(row["menuid"]), 2) + "',";
					num++;
				}
			}
			lblModule.Text = "Module (" + Conversions.ToString(num) + ")";
			if (Operators.CompareString(text, "", false) == 0)
			{
				text2 = "menuid = '00.00.00'";
			}
			else
			{
				text = "(" + Strings.Left(text, text.Length - 1) + ")";
				text2 = "SUBSTRING(menuid, 1, 2) IN " + text;
			}
			oDtFunction.DefaultView.RowFilter = text2;
		}
	}

	private void FunctionSelect()
	{
		string text = "";
		string text2 = "";
		int num = 0;
		checked
		{
			foreach (DataRowView item in oDtFunction.DefaultView)
			{
				if (!Operators.ConditionalCompareObjectEqual(item["checked"], (object)false, false))
				{
					text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(item["menuid"], (object)", ")));
					text2 = Conversions.ToString(Operators.ConcatenateObject((object)text2, Operators.ConcatenateObject(item["bar"], (object)", ")));
					num++;
				}
			}
			lblFunction.Text = "Function (" + Conversions.ToString(num) + ")";
			if (Operators.CompareString(text, "", false) != 0)
			{
				text = text.Substring(0, text.Length - 2);
				text2 = text2.Substring(0, text2.Length - 2);
			}
			txtFunctionMenuid.Text = text;
			txtFunctionName.Text = text2;
		}
	}

	private void FunctionSet()
	{
		if (Operators.CompareString(txtFunctionMenuid.Text, "", false) == 0 || Operators.CompareString(txtFunctionName.Text, "", false) == 0 || 1 == 0)
		{
			return;
		}
		int num = 0;
		string[] array = txtFunctionMenuid.Text.Replace(" ", "").Split(new char[1] { ',' });
		checked
		{
			foreach (DataRow row in oDtFunction.Rows)
			{
				if (array.Contains(Conversions.ToString(row["menuid"])))
				{
					row["checked"] = true;
					num++;
				}
			}
			lblFunction.Text = "Function (" + Conversions.ToString(num) + ")";
			int num2 = array.Length - 1;
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				array[num3] = Strings.Left(array[num3], 2);
				num3++;
			}
			foreach (DataRow row2 in oDtModule.Rows)
			{
				if (array.Contains(Strings.Left(Conversions.ToString(row2["menuid"]), 2)))
				{
					row2["checked"] = true;
				}
			}
			FunctionFilter();
		}
	}

	private void Lookup()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		frmLookup frmLookup2 = new frmLookup(oTblDM, ((TextBox)txtLinkNumber).Text);
		((Form)frmLookup2).ShowDialog((IWin32Window)(object)this);
		DataRow f_oDrwReturn = frmLookup2.f_oDrwReturn;
		if (f_oDrwReturn != null)
		{
			((TextBox)txtLinkNumber).Text = Conversions.ToString(f_oDrwReturn["ID"]);
			lblLookupName.Text = Conversions.ToString(f_oDrwReturn["Description"]);
		}
		else
		{
			((TextBox)txtLinkNumber).Text = "";
			lblLookupName.Text = "";
		}
		SendKeys.Send("{TAB}");
	}

	protected override void InitAfterGetData()
	{
		if (f_dtDetail != null)
		{
			if (!EditMode)
			{
				f_dtDetail.DefaultView.RowFilter = "ID=0";
			}
			((DataGridView)dgvDetail).DataSource = f_dtDetail.DefaultView;
			cboProductId.DataSource = Commons.GetDataTable("SiGetDmProduct");
			((ListControl)cboProductId).ValueMember = "ProductId";
			((ListControl)cboProductId).DisplayMember = "ProductName";
			GetModule();
			GetFunction();
			FunctionSet();
			SIUpdateLogDAO sIUpdateLogDAO = (SIUpdateLogDAO)DAOFactory.CreateDAOInstance("SIUpdateLogDAO", "SIUpdateLog");
			oTblDM = sIUpdateLogDAO.GetLookup(Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["ID"]), isNum: true)), Conversions.ToString(((ListControl)cboProductId).SelectedValue));
			sIUpdateLogDAO.Destroy();
			txtBugNumber.Text = txtBugNumber.Text.Trim();
		}
	}

	protected override void DataBinding()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		Control ojb = (Control)(object)txtDescription;
		CreateDataBinding(ref ojb, "Description");
		txtDescription = (TextBox)ojb;
		ojb = (Control)(object)txtNote;
		CreateDataBinding(ref ojb, "Note");
		txtNote = (TextBox)ojb;
		ojb = (Control)(object)cboProductId;
		CreateDataBinding(ref ojb, "ProductId", "SelectedValue");
		cboProductId = (ComboBox)ojb;
		ojb = (Control)(object)txtFunctionMenuid;
		CreateDataBinding(ref ojb, "FunctionMenuid");
		txtFunctionMenuid = (TextBox)ojb;
		ojb = (Control)(object)txtFunctionName;
		CreateDataBinding(ref ojb, "FunctionName");
		txtFunctionName = (TextBox)ojb;
		ojb = (Control)(object)txtBugNumber;
		CreateDataBinding(ref ojb, "BugNumber");
		txtBugNumber = (TextBox)ojb;
		ojb = (Control)(object)txtLinkNumber;
		CreateDataBinding(ref ojb, "LinkNumber");
		txtLinkNumber = (AsTextBox)(object)ojb;
	}

	protected override bool InsertToDB()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["Description"]), isNum: false)));
		arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["Note"]), isNum: false)));
		arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["Productid"]), isNum: false)));
		arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["FunctionMenuid"]), isNum: false)));
		arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["FunctionName"]), isNum: false)));
		arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["Bugnumber"]), isNum: false)));
		arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["Linknumber"]), isNum: false)));
		arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["Connection"]), isNum: false)));
		arrayList.Add("");
		arrayList.Add("");
		arrayList.Add(SystemInformations.UserName);
		SIUpdateLogDAO sIUpdateLogDAO = (SIUpdateLogDAO)DAOFactory.CreateDAOInstance("SIUpdateLogDAO", "SIUpdateLog");
		int ID = default(int);
		int num = sIUpdateLogDAO.InsUpdateLogPH(arrayList.ToArray(), ref ID);
		sIUpdateLogDAO.Destroy();
		if (num == 0)
		{
			RowToEdit["id"] = ID;
			return InsertDetail();
		}
		return false;
	}

	protected override bool UpdateDB()
	{
		return (base.UpdateDB() && InsertDetail()) ? true : false;
	}

	protected override void quit()
	{
		f_dtDetail.RejectChanges();
		base.quit();
	}

	protected override bool ValidData()
	{
		return Conversions.ToBoolean(CheckExitFiles());
	}

	protected override bool SetToRow()
	{
		base.SetToRow();
		RowToEdit["ProductName"] = cboProductId.Text;
		RowToEdit["Connection"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(TCommon.get_Session((object)"sDataCnnString"), (object)"", false), RuntimeHelpers.GetObjectValue(RowToEdit["Connection"]), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"sDataCnnString"))));
		bool result = default(bool);
		return result;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 115)
		{
			checked
			{
				if (rdbFile.Checked)
				{
					((FileDialog)opF).InitialDirectory = Application.StartupPath;
					((FileDialog)opF).Filter = "Tệp thư viện chức năng|*.dll|Tệp báo cáo|*.rpt";
					((CommonDialog)opF).ShowDialog();
					FileInfo fileInfo = null;
					int num = ((FileDialog)opF).FileNames.Count();
					string[] fileNames = ((FileDialog)opF).FileNames;
					int num2 = num - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 <= num5)
						{
							fileInfo = new FileInfo(fileNames[num3]);
							DataRow dataRow = f_dtDetail.NewRow();
							dataRow["ID"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["ID"]), isNum: true));
							dataRow["Name"] = fileInfo.Name;
							dataRow["Type"] = 0;
							dataRow["Last_modify"] = fileInfo.LastWriteTime;
							dataRow["FullPath"] = fileInfo.FullName;
							f_dtDetail.Rows.Add(dataRow);
							num3++;
							continue;
						}
						break;
					}
				}
				else
				{
					TCommon.CheckConnection();
					InsertObjectUpdateToDetail();
				}
			}
		}
		if ((object)((ContainerControl)this).ActiveControl == dgvDetail && (int)keyData == 119 && ((DataGridView)dgvDetail).RowCount > 0)
		{
			((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvDetail).DataSource)].Current).Delete();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void adgvModule_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == ((DataGridViewBand)adgvcCheckedM).Index)
		{
			((DataGridView)adgvModule).EndEdit();
			FunctionFilter();
		}
	}

	private void adgvFunction_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == ((DataGridViewBand)adgvcCheckedF).Index)
		{
			((DataGridView)adgvFunction).EndEdit();
			FunctionSelect();
		}
	}

	private void chkAllModule_CheckedChanged(object sender, EventArgs e)
	{
		foreach (DataRow row in oDtModule.Rows)
		{
			row["checked"] = chkAllModule.Checked;
		}
		FunctionFilter();
		FunctionSelect();
	}

	private void chkAllFunction_CheckedChanged(object sender, EventArgs e)
	{
		foreach (DataRow row in oDtFunction.Rows)
		{
			row["checked"] = chkAllFunction.Checked;
		}
		FunctionSelect();
	}

	private void txtLinkNumber_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyData == 116)
		{
			Lookup();
		}
	}

	private void txtLinkNumber_Validated(object sender, EventArgs e)
	{
		if (Operators.CompareString(((TextBox)txtLinkNumber).Text.Trim(), "", false) == 0)
		{
			((TextBox)txtLinkNumber).Text = "";
			lblLookupName.Text = "";
			return;
		}
		string rowFilter = "Convert(ID, 'System.String') LIKE '" + ((TextBox)txtLinkNumber).Text.Trim() + "%'";
		oTblDM.DefaultView.RowFilter = rowFilter;
		if (oTblDM.DefaultView.Count == 1)
		{
			lblLookupName.Text = Conversions.ToString(oTblDM.DefaultView[0]["Description"]);
		}
		else
		{
			Lookup();
		}
	}
}
