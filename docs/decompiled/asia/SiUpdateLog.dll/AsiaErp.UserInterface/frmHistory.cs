using System;
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
using My.Resources;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmHistory : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("adgvDetail")]
	private AsInputDGV _adgvDetail;

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

	[AccessedThroughProperty("lblFunction")]
	private Label _lblFunction;

	[AccessedThroughProperty("adgvFunction")]
	private AsInputDGV _adgvFunction;

	[AccessedThroughProperty("lblModule")]
	private Label _lblModule;

	[AccessedThroughProperty("adgvModule")]
	private AsInputDGV _adgvModule;

	[AccessedThroughProperty("adgvcCheckedF")]
	private DataGridViewCheckBoxColumn _adgvcCheckedF;

	[AccessedThroughProperty("adgvcMenuidF")]
	private DataGridViewTextBoxColumn _adgvcMenuidF;

	[AccessedThroughProperty("adgvcBarF")]
	private DataGridViewTextBoxColumn _adgvcBarF;

	[AccessedThroughProperty("pnModule")]
	private Panel _pnModule;

	[AccessedThroughProperty("pnFunction")]
	private Panel _pnFunction;

	[AccessedThroughProperty("adgvcCheckedM")]
	private DataGridViewCheckBoxColumn _adgvcCheckedM;

	[AccessedThroughProperty("adgvcMenuidM")]
	private DataGridViewTextBoxColumn _adgvcMenuidM;

	[AccessedThroughProperty("adgvcBarM")]
	private DataGridViewTextBoxColumn _adgvcBarM;

	[AccessedThroughProperty("grbHistory")]
	private GroupBox _grbHistory;

	[AccessedThroughProperty("adgvHistory")]
	private AsInputDGV _adgvHistory;

	[AccessedThroughProperty("adgvcLUser")]
	private DataGridViewTextBoxColumn _adgvcLUser;

	[AccessedThroughProperty("adgvcLDate")]
	private DataGridViewAsMaskedTextBoxColumn _adgvcLDate;

	[AccessedThroughProperty("adgvcChangset")]
	private DataGridViewTextBoxColumn _adgvcChangset;

	[AccessedThroughProperty("grbShow")]
	private GroupBox _grbShow;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("txtLinkNumber")]
	private TextBox _txtLinkNumber;

	[AccessedThroughProperty("lblLinkNumber")]
	private Label _lblLinkNumber;

	[AccessedThroughProperty("bsHistory")]
	private BindingSource _bsHistory;

	[AccessedThroughProperty("dgvcName")]
	private DataGridViewTextBoxColumn _dgvcName;

	[AccessedThroughProperty("dgvcTypeName")]
	private DataGridViewTextBoxColumn _dgvcTypeName;

	[AccessedThroughProperty("dgvcLast_Modify")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcLast_Modify;

	[AccessedThroughProperty("dgvcFullPath")]
	private DataGridViewTextBoxColumn _dgvcFullPath;

	private int currentID;

	private DataTable oDtHistory;

	private DataTable oDtModule;

	private DataTable oDtFunction;

	private DataTable oDtDetail;

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
			_adgvFunction = value;
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
			_adgvModule = value;
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

	internal virtual GroupBox grbHistory
	{
		[DebuggerNonUserCode]
		get
		{
			return _grbHistory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grbHistory = value;
		}
	}

	internal virtual AsInputDGV adgvHistory
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvHistory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvHistory = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn adgvcLUser
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcLUser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcLUser = value;
		}
	}

	internal virtual DataGridViewAsMaskedTextBoxColumn adgvcLDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcLDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcLDate = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn adgvcChangset
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvcChangset;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_adgvcChangset = value;
		}
	}

	internal virtual GroupBox grbShow
	{
		[DebuggerNonUserCode]
		get
		{
			return _grbShow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grbShow = value;
		}
	}

	internal virtual Button cmdCancel
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

	internal virtual TextBox txtLinkNumber
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
			_txtLinkNumber = value;
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

	internal virtual BindingSource bsHistory
	{
		[DebuggerNonUserCode]
		get
		{
			return _bsHistory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bsHistory_PositionChanged;
			if (_bsHistory != null)
			{
				_bsHistory.PositionChanged -= eventHandler;
			}
			_bsHistory = value;
			if (_bsHistory != null)
			{
				_bsHistory.PositionChanged += eventHandler;
			}
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

	public frmHistory(int ID)
	{
		((Form)this).Load += frmHistory_Load;
		__ENCAddToList(this);
		InitializeComponent();
		currentID = ID;
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected O, but got Unknown
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected O, but got Unknown
		//IL_10fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1106: Expected O, but got Unknown
		//IL_18e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ed: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		adgvDetail = new AsInputDGV();
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
		adgvModule = new AsInputDGV();
		adgvcCheckedM = new DataGridViewCheckBoxColumn();
		adgvcMenuidM = new DataGridViewTextBoxColumn();
		adgvcBarM = new DataGridViewTextBoxColumn();
		lblModule = new Label();
		lblFunction = new Label();
		adgvFunction = new AsInputDGV();
		adgvcCheckedF = new DataGridViewCheckBoxColumn();
		adgvcMenuidF = new DataGridViewTextBoxColumn();
		adgvcBarF = new DataGridViewTextBoxColumn();
		pnModule = new Panel();
		pnFunction = new Panel();
		grbHistory = new GroupBox();
		adgvHistory = new AsInputDGV();
		adgvcLUser = new DataGridViewTextBoxColumn();
		adgvcLDate = new DataGridViewAsMaskedTextBoxColumn();
		adgvcChangset = new DataGridViewTextBoxColumn();
		grbShow = new GroupBox();
		txtLinkNumber = new TextBox();
		lblLinkNumber = new Label();
		cmdCancel = new Button();
		bsHistory = new BindingSource(components);
		dgvcName = new DataGridViewTextBoxColumn();
		dgvcTypeName = new DataGridViewTextBoxColumn();
		dgvcLast_Modify = new DataGridViewAsMaskedTextBoxColumn();
		dgvcFullPath = new DataGridViewTextBoxColumn();
		((ISupportInitialize)adgvDetail).BeginInit();
		((ISupportInitialize)bsType).BeginInit();
		((ISupportInitialize)adgvModule).BeginInit();
		((ISupportInitialize)adgvFunction).BeginInit();
		((Control)pnModule).SuspendLayout();
		((Control)pnFunction).SuspendLayout();
		((Control)grbHistory).SuspendLayout();
		((ISupportInitialize)adgvHistory).BeginInit();
		((Control)grbShow).SuspendLayout();
		((ISupportInitialize)bsHistory).BeginInit();
		((Control)this).SuspendLayout();
		((DataGridView)adgvDetail).AllowUserToAddRows = false;
		((DataGridView)adgvDetail).AllowUserToDeleteRows = false;
		((Control)adgvDetail).Anchor = (AnchorStyles)15;
		((DataGridView)adgvDetail).BackgroundColor = Color.White;
		((DataGridView)adgvDetail).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvDetail).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)dgvcName,
			(DataGridViewColumn)dgvcTypeName,
			dgvcLast_Modify,
			(DataGridViewColumn)dgvcFullPath
		});
		((DataGridView)adgvDetail).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = adgvDetail;
		Point location = new Point(3, 271);
		((Control)asInputDGV).Location = location;
		((Control)adgvDetail).Name = "adgvDetail";
		adgvDetail.ReadOnly = true;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail).RowHeadersDefaultCellStyle = val;
		((DataGridView)adgvDetail).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = adgvDetail;
		Size size = new Size(596, 295);
		((Control)asInputDGV2).Size = size;
		((Control)adgvDetail).TabIndex = 12;
		TextBox obj = txtBugNumber;
		location = new Point(290, 34);
		((Control)obj).Location = location;
		((Control)txtBugNumber).Name = "txtBugNumber";
		((TextBoxBase)txtBugNumber).ReadOnly = true;
		TextBox obj2 = txtBugNumber;
		size = new Size(115, 20);
		((Control)obj2).Size = size;
		((Control)txtBugNumber).TabIndex = 4;
		TextBox obj3 = txtDescription;
		location = new Point(12, 219);
		((Control)obj3).Location = location;
		txtDescription.Multiline = true;
		((Control)txtDescription).Name = "txtDescription";
		((TextBoxBase)txtDescription).ReadOnly = true;
		TextBox obj4 = txtDescription;
		size = new Size(253, 45);
		((Control)obj4).Size = size;
		((Control)txtDescription).TabIndex = 10;
		cboProductId.DropDownStyle = (ComboBoxStyle)2;
		((Control)cboProductId).Enabled = false;
		((ListControl)cboProductId).FormattingEnabled = true;
		ComboBox obj5 = cboProductId;
		location = new Point(12, 33);
		((Control)obj5).Location = location;
		((Control)cboProductId).Name = "cboProductId";
		ComboBox obj6 = cboProductId;
		size = new Size(253, 22);
		((Control)obj6).Size = size;
		((Control)cboProductId).TabIndex = 3;
		lblProductName.AutoSize = true;
		Label obj7 = lblProductName;
		location = new Point(9, 16);
		((Control)obj7).Location = location;
		((Control)lblProductName).Name = "lblProductName";
		Label obj8 = lblProductName;
		size = new Size(74, 14);
		((Control)obj8).Size = size;
		((Control)lblProductName).TabIndex = 0;
		lblProductName.Text = "Product Name";
		lblBugNumber.AutoSize = true;
		Label obj9 = lblBugNumber;
		location = new Point(287, 16);
		((Control)obj9).Location = location;
		((Control)lblBugNumber).Name = "lblBugNumber";
		Label obj10 = lblBugNumber;
		size = new Size(65, 14);
		((Control)obj10).Size = size;
		((Control)lblBugNumber).TabIndex = 1;
		lblBugNumber.Text = "Bug number";
		lblDescription.AutoSize = true;
		Label obj11 = lblDescription;
		location = new Point(9, 202);
		((Control)obj11).Location = location;
		((Control)lblDescription).Name = "lblDescription";
		Label obj12 = lblDescription;
		size = new Size(61, 14);
		((Control)obj12).Size = size;
		((Control)lblDescription).TabIndex = 8;
		lblDescription.Text = "Description";
		TextBox obj13 = txtNote;
		location = new Point(290, 219);
		((Control)obj13).Location = location;
		txtNote.Multiline = true;
		((Control)txtNote).Name = "txtNote";
		((TextBoxBase)txtNote).ReadOnly = true;
		TextBox obj14 = txtNote;
		size = new Size(302, 45);
		((Control)obj14).Size = size;
		((Control)txtNote).TabIndex = 11;
		lblNote.AutoSize = true;
		Label obj15 = lblNote;
		location = new Point(287, 202);
		((Control)obj15).Location = location;
		((Control)lblNote).Name = "lblNote";
		Label obj16 = lblNote;
		size = new Size(29, 14);
		((Control)obj16).Size = size;
		((Control)lblNote).TabIndex = 9;
		lblNote.Text = "Note";
		opF.Multiselect = true;
		((DataGridView)adgvModule).AllowUserToAddRows = false;
		((DataGridView)adgvModule).AllowUserToDeleteRows = false;
		((DataGridView)adgvModule).AllowUserToResizeColumns = false;
		((DataGridView)adgvModule).AllowUserToResizeRows = false;
		((DataGridView)adgvModule).BackgroundColor = Color.White;
		((DataGridView)adgvModule).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvModule).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvModule).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)adgvcCheckedM,
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
		adgvModule.ReadOnly = true;
		val2.Alignment = (DataGridViewContentAlignment)32;
		val2.BackColor = SystemColors.Control;
		val2.Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		val2.ForeColor = SystemColors.WindowText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvModule).RowHeadersDefaultCellStyle = val2;
		((DataGridView)adgvModule).RowHeadersVisible = false;
		((DataGridView)adgvModule).RowTemplate.Height = 20;
		((DataGridView)adgvModule).SelectionMode = (DataGridViewSelectionMode)1;
		AsInputDGV asInputDGV4 = adgvModule;
		size = new Size(253, 124);
		((Control)asInputDGV4).Size = size;
		((Control)adgvModule).TabIndex = 0;
		((DataGridViewColumn)adgvcCheckedM).DataPropertyName = "CHECKED";
		((DataGridViewColumn)adgvcCheckedM).HeaderText = "";
		((DataGridViewColumn)adgvcCheckedM).Name = "adgvcCheckedM";
		((DataGridViewColumn)adgvcCheckedM).Width = 20;
		((DataGridViewColumn)adgvcMenuidM).DataPropertyName = "MENUID";
		val3.Alignment = (DataGridViewContentAlignment)32;
		((DataGridViewColumn)adgvcMenuidM).DefaultCellStyle = val3;
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
		Label obj17 = lblModule;
		location = new Point(9, 58);
		((Control)obj17).Location = location;
		((Control)lblModule).Name = "lblModule";
		Label obj18 = lblModule;
		size = new Size(41, 14);
		((Control)obj18).Size = size;
		((Control)lblModule).TabIndex = 6;
		lblModule.Text = "Module";
		lblFunction.AutoSize = true;
		Label obj19 = lblFunction;
		location = new Point(287, 58);
		((Control)obj19).Location = location;
		((Control)lblFunction).Name = "lblFunction";
		Label obj20 = lblFunction;
		size = new Size(48, 14);
		((Control)obj20).Size = size;
		((Control)lblFunction).TabIndex = 7;
		lblFunction.Text = "Function";
		((DataGridView)adgvFunction).AllowUserToAddRows = false;
		((DataGridView)adgvFunction).AllowUserToDeleteRows = false;
		((DataGridView)adgvFunction).AllowUserToResizeColumns = false;
		((DataGridView)adgvFunction).AllowUserToResizeRows = false;
		((DataGridView)adgvFunction).BackgroundColor = Color.White;
		((DataGridView)adgvFunction).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvFunction).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvFunction).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)adgvcCheckedF,
			(DataGridViewColumn)adgvcMenuidF,
			(DataGridViewColumn)adgvcBarF
		});
		((Control)adgvFunction).Dock = (DockStyle)5;
		((DataGridView)adgvFunction).EditMode = (DataGridViewEditMode)0;
		((DataGridView)adgvFunction).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV5 = adgvFunction;
		location = new Point(0, 0);
		((Control)asInputDGV5).Location = location;
		((Control)adgvFunction).Name = "adgvFunction";
		adgvFunction.ReadOnly = true;
		val4.Alignment = (DataGridViewContentAlignment)32;
		val4.BackColor = SystemColors.Control;
		val4.Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		val4.ForeColor = SystemColors.WindowText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvFunction).RowHeadersDefaultCellStyle = val4;
		((DataGridView)adgvFunction).RowHeadersVisible = false;
		((DataGridView)adgvFunction).RowTemplate.Height = 20;
		((DataGridView)adgvFunction).SelectionMode = (DataGridViewSelectionMode)1;
		AsInputDGV asInputDGV6 = adgvFunction;
		size = new Size(302, 124);
		((Control)asInputDGV6).Size = size;
		((Control)adgvFunction).TabIndex = 0;
		((DataGridViewColumn)adgvcCheckedF).DataPropertyName = "CHECKED";
		((DataGridViewColumn)adgvcCheckedF).HeaderText = "";
		((DataGridViewColumn)adgvcCheckedF).Name = "adgvcCheckedF";
		((DataGridViewColumn)adgvcCheckedF).Width = 20;
		((DataGridViewColumn)adgvcMenuidF).DataPropertyName = "MENUID";
		val5.Alignment = (DataGridViewContentAlignment)32;
		((DataGridViewColumn)adgvcMenuidF).DefaultCellStyle = val5;
		((DataGridViewColumn)adgvcMenuidF).HeaderText = "Menud ID";
		((DataGridViewColumn)adgvcMenuidF).Name = "adgvcMenuidF";
		((DataGridViewColumn)adgvcMenuidF).ReadOnly = true;
		((DataGridViewColumn)adgvcMenuidF).Resizable = (DataGridViewTriState)2;
		adgvcMenuidF.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)adgvcMenuidF).Width = 60;
		((DataGridViewColumn)adgvcBarF).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)adgvcBarF).DataPropertyName = "BAR";
		((DataGridViewColumn)adgvcBarF).HeaderText = "Tên chức năng";
		((DataGridViewColumn)adgvcBarF).Name = "adgvcBarF";
		((DataGridViewColumn)adgvcBarF).ReadOnly = true;
		adgvcBarF.SortMode = (DataGridViewColumnSortMode)0;
		((Control)pnModule).Controls.Add((Control)(object)adgvModule);
		Panel obj21 = pnModule;
		location = new Point(12, 75);
		((Control)obj21).Location = location;
		((Control)pnModule).Name = "pnModule";
		Panel obj22 = pnModule;
		size = new Size(253, 124);
		((Control)obj22).Size = size;
		((Control)pnModule).TabIndex = 2;
		((Control)pnFunction).Anchor = (AnchorStyles)13;
		((Control)pnFunction).Controls.Add((Control)(object)adgvFunction);
		Panel obj23 = pnFunction;
		location = new Point(290, 75);
		((Control)obj23).Location = location;
		((Control)pnFunction).Name = "pnFunction";
		Panel obj24 = pnFunction;
		size = new Size(302, 124);
		((Control)obj24).Size = size;
		((Control)pnFunction).TabIndex = 3;
		((Control)grbHistory).Anchor = (AnchorStyles)15;
		((Control)grbHistory).Controls.Add((Control)(object)adgvHistory);
		GroupBox obj25 = grbHistory;
		location = new Point(12, 6);
		((Control)obj25).Location = location;
		((Control)grbHistory).Name = "grbHistory";
		GroupBox obj26 = grbHistory;
		size = new Size(309, 569);
		((Control)obj26).Size = size;
		((Control)grbHistory).TabIndex = 0;
		grbHistory.TabStop = false;
		((DataGridView)adgvHistory).AllowUserToAddRows = false;
		((DataGridView)adgvHistory).AllowUserToDeleteRows = false;
		((DataGridView)adgvHistory).AllowUserToResizeColumns = false;
		((DataGridView)adgvHistory).AllowUserToResizeRows = false;
		((DataGridView)adgvHistory).BackgroundColor = Color.White;
		((DataGridView)adgvHistory).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvHistory).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvHistory).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)adgvcLUser,
			adgvcLDate,
			(DataGridViewColumn)adgvcChangset
		});
		((Control)adgvHistory).Dock = (DockStyle)5;
		((DataGridView)adgvHistory).EditMode = (DataGridViewEditMode)0;
		((DataGridView)adgvHistory).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV7 = adgvHistory;
		location = new Point(3, 16);
		((Control)asInputDGV7).Location = location;
		((Control)adgvHistory).Name = "adgvHistory";
		val6.Alignment = (DataGridViewContentAlignment)32;
		val6.BackColor = SystemColors.Control;
		val6.Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		val6.ForeColor = SystemColors.WindowText;
		val6.SelectionBackColor = SystemColors.Highlight;
		val6.SelectionForeColor = SystemColors.HighlightText;
		val6.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvHistory).RowHeadersDefaultCellStyle = val6;
		((DataGridView)adgvHistory).RowHeadersVisible = false;
		((DataGridView)adgvHistory).RowTemplate.Height = 20;
		((DataGridView)adgvHistory).SelectionMode = (DataGridViewSelectionMode)1;
		AsInputDGV asInputDGV8 = adgvHistory;
		size = new Size(303, 550);
		((Control)asInputDGV8).Size = size;
		((Control)adgvHistory).TabIndex = 0;
		((DataGridViewColumn)adgvcLUser).DataPropertyName = "LUSER";
		((DataGridViewColumn)adgvcLUser).HeaderText = "User";
		((DataGridViewColumn)adgvcLUser).Name = "adgvcLUser";
		((DataGridViewColumn)adgvcLUser).ReadOnly = true;
		((DataGridViewColumn)adgvcLUser).Resizable = (DataGridViewTriState)2;
		adgvcLUser.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)adgvcLDate).DataPropertyName = "LDATE";
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "dd/MM/yyyy hh:mm:ss tt";
		((DataGridViewColumn)adgvcLDate).DefaultCellStyle = val7;
		adgvcLDate.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)adgvcLDate).HeaderText = "Date";
		adgvcLDate.Mask = "##/##/####";
		((DataGridViewColumn)adgvcLDate).Name = "adgvcLDate";
		((DataGridViewColumn)adgvcLDate).ReadOnly = true;
		((DataGridViewColumn)adgvcLDate).Resizable = (DataGridViewTriState)2;
		adgvcLDate.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)adgvcLDate).Width = 130;
		((DataGridViewColumn)adgvcChangset).DataPropertyName = "CHANGESET";
		((DataGridViewColumn)adgvcChangset).HeaderText = "Changeset";
		((DataGridViewColumn)adgvcChangset).Name = "adgvcChangset";
		((DataGridViewColumn)adgvcChangset).ReadOnly = true;
		((DataGridViewColumn)adgvcChangset).Resizable = (DataGridViewTriState)2;
		adgvcChangset.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)adgvcChangset).Width = 70;
		((Control)grbShow).Anchor = (AnchorStyles)11;
		((Control)grbShow).Controls.Add((Control)(object)txtLinkNumber);
		((Control)grbShow).Controls.Add((Control)(object)lblLinkNumber);
		((Control)grbShow).Controls.Add((Control)(object)pnFunction);
		((Control)grbShow).Controls.Add((Control)(object)pnModule);
		((Control)grbShow).Controls.Add((Control)(object)txtNote);
		((Control)grbShow).Controls.Add((Control)(object)lblNote);
		((Control)grbShow).Controls.Add((Control)(object)adgvDetail);
		((Control)grbShow).Controls.Add((Control)(object)txtBugNumber);
		((Control)grbShow).Controls.Add((Control)(object)txtDescription);
		((Control)grbShow).Controls.Add((Control)(object)cboProductId);
		((Control)grbShow).Controls.Add((Control)(object)lblProductName);
		((Control)grbShow).Controls.Add((Control)(object)lblBugNumber);
		((Control)grbShow).Controls.Add((Control)(object)lblDescription);
		((Control)grbShow).Controls.Add((Control)(object)lblModule);
		((Control)grbShow).Controls.Add((Control)(object)lblFunction);
		GroupBox obj27 = grbShow;
		location = new Point(327, 6);
		((Control)obj27).Location = location;
		((Control)grbShow).Name = "grbShow";
		GroupBox obj28 = grbShow;
		size = new Size(602, 569);
		((Control)obj28).Size = size;
		((Control)grbShow).TabIndex = 1;
		grbShow.TabStop = false;
		((Control)txtLinkNumber).Anchor = (AnchorStyles)9;
		TextBox obj29 = txtLinkNumber;
		location = new Point(477, 34);
		((Control)obj29).Location = location;
		((Control)txtLinkNumber).Name = "txtLinkNumber";
		((TextBoxBase)txtLinkNumber).ReadOnly = true;
		TextBox obj30 = txtLinkNumber;
		size = new Size(115, 20);
		((Control)obj30).Size = size;
		((Control)txtLinkNumber).TabIndex = 5;
		((Control)lblLinkNumber).Anchor = (AnchorStyles)9;
		lblLinkNumber.AutoSize = true;
		Label obj31 = lblLinkNumber;
		location = new Point(474, 16);
		((Control)obj31).Location = location;
		((Control)lblLinkNumber).Name = "lblLinkNumber";
		Label obj32 = lblLinkNumber;
		size = new Size(65, 14);
		((Control)obj32).Size = size;
		((Control)lblLinkNumber).TabIndex = 2;
		lblLinkNumber.Text = "Link number";
		((Control)cmdCancel).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdCancel).Image = (Image)(object)Resources.imgCancel;
		((ButtonBase)cmdCancel).ImageAlign = (ContentAlignment)16;
		Button obj33 = cmdCancel;
		location = new Point(854, 580);
		((Control)obj33).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj34 = cmdCancel;
		size = new Size(75, 25);
		((Control)obj34).Size = size;
		((Control)cmdCancel).TabIndex = 2;
		((ButtonBase)cmdCancel).Text = "&Huỷ bỏ";
		((ButtonBase)cmdCancel).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = true;
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
		val8.Alignment = (DataGridViewContentAlignment)16;
		val8.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcLast_Modify).DefaultCellStyle = val8;
		dgvcLast_Modify.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcLast_Modify).HeaderText = "Last Edit";
		dgvcLast_Modify.Mask = "##/##/####";
		((DataGridViewColumn)dgvcLast_Modify).Name = "dgvcLast_Modify";
		((DataGridViewColumn)dgvcLast_Modify).ReadOnly = true;
		((DataGridViewColumn)dgvcLast_Modify).Resizable = (DataGridViewTriState)1;
		dgvcLast_Modify.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcLast_Modify).Width = 80;
		((DataGridViewColumn)dgvcFullPath).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcFullPath).DataPropertyName = "FullPath";
		((DataGridViewColumn)dgvcFullPath).HeaderText = "Path ";
		((DataGridViewColumn)dgvcFullPath).Name = "dgvcFullPath";
		((DataGridViewColumn)dgvcFullPath).ReadOnly = true;
		dgvcFullPath.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcFullPath).Width = 37;
		SizeF autoScaleDimensions = new SizeF(6f, 14f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(941, 612);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)grbShow);
		((Control)this).Controls.Add((Control)(object)grbHistory);
		((Control)this).Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmHistory";
		((Form)this).ShowInTaskbar = false;
		((Form)this).Text = "History";
		((ISupportInitialize)adgvDetail).EndInit();
		((ISupportInitialize)bsType).EndInit();
		((ISupportInitialize)adgvModule).EndInit();
		((ISupportInitialize)adgvFunction).EndInit();
		((Control)pnModule).ResumeLayout(false);
		((Control)pnFunction).ResumeLayout(false);
		((Control)grbHistory).ResumeLayout(false);
		((ISupportInitialize)adgvHistory).EndInit();
		((Control)grbShow).ResumeLayout(false);
		((Control)grbShow).PerformLayout();
		((ISupportInitialize)bsHistory).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void CreateDetailTable()
	{
		DataColumn dataColumn = new DataColumn();
		DataColumn dataColumn2 = dataColumn;
		dataColumn2.DataType = Type.GetType("System.String");
		dataColumn2.ColumnName = "Name";
		dataColumn2 = null;
		DataColumn dataColumn3 = new DataColumn();
		DataColumn dataColumn4 = dataColumn3;
		dataColumn4.DataType = Type.GetType("System.String");
		dataColumn4.ColumnName = "TypeName";
		dataColumn4 = null;
		DataColumn dataColumn5 = new DataColumn();
		DataColumn dataColumn6 = dataColumn5;
		dataColumn6.DataType = Type.GetType("System.DateTime");
		dataColumn6.ColumnName = "Last_modify";
		dataColumn6 = null;
		DataColumn dataColumn7 = new DataColumn();
		DataColumn dataColumn8 = dataColumn7;
		dataColumn8.DataType = Type.GetType("System.String");
		dataColumn8.ColumnName = "Fullpath";
		dataColumn8 = null;
		oDtDetail = new DataTable();
		oDtDetail.Columns.Add(dataColumn);
		oDtDetail.Columns.Add(dataColumn3);
		oDtDetail.Columns.Add(dataColumn5);
		oDtDetail.Columns.Add(dataColumn7);
	}

	private object GetStrFilter(string[] str)
	{
		string text = "";
		checked
		{
			int num = str.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				text = text + "'" + str[num2] + "',";
				num2++;
			}
			if (text.Length > 0)
			{
				text = "(" + text.Substring(0, text.Length - 1) + ")";
			}
			return text;
		}
	}

	private DataTable GetModule(bool isModule, string menuid)
	{
		SIUpdateLogDAO sIUpdateLogDAO = (SIUpdateLogDAO)DAOFactory.CreateDAOInstance("SIUpdateLogDAO", "SIUpdateLog", a_blnIsSysDB: true);
		DataTable module = sIUpdateLogDAO.GetModule(isModule, menuid);
		sIUpdateLogDAO.Destroy();
		return module;
	}

	private void GetHistory()
	{
		SIUpdateLogDAO sIUpdateLogDAO = (SIUpdateLogDAO)DAOFactory.CreateDAOInstance("SIUpdateLogDAO", "SIUpdateLog");
		oDtHistory = sIUpdateLogDAO.GetHistory(currentID);
		sIUpdateLogDAO.Destroy();
		bsHistory.DataSource = oDtHistory;
		((DataGridView)adgvHistory).DataSource = bsHistory;
	}

	public void ViewHistory(DataRowView dr)
	{
		string[] array = dr["FunctionMenuid"].ToString().Replace(" ", "").Split(new char[1] { ',' });
		oDtFunction = GetModule(isModule: false, Conversions.ToString(GetStrFilter(array)));
		((DataGridView)adgvFunction).DataSource = oDtFunction;
		checked
		{
			int num = array.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				array[num2] = Strings.Left(array[num2], 2);
				num2++;
			}
			oDtModule = GetModule(isModule: true, Conversions.ToString(GetStrFilter(array)));
			((DataGridView)adgvModule).DataSource = oDtModule;
			((ListControl)cboProductId).SelectedValue = RuntimeHelpers.GetObjectValue(dr["ProductId"]);
			txtBugNumber.Text = Conversions.ToString(dr["BugNumber"]);
			txtNote.Text = Conversions.ToString(dr["Note"]);
			txtDescription.Text = Conversions.ToString(dr["Description"]);
			string[] array2 = dr["Name"].ToString().Split(new char[1] { ':' });
			string[] array3 = dr["Type"].ToString().Split(new char[1] { ':' });
			string[] array4 = dr["Last_Modify"].ToString().Split(new char[1] { ':' });
			string[] array5 = dr["FullPath"].ToString().Split(new char[1] { ':' });
			oDtDetail.Clear();
			int num5 = array2.Length - 1;
			int num6 = 0;
			while (true)
			{
				int num7 = num6;
				int num4 = num5;
				if (num7 > num4)
				{
					break;
				}
				DataRow dataRow = oDtDetail.NewRow();
				dataRow["Name"] = array2[num6];
				dataRow["TypeName"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(array3[num6], "0", false) == 0, (object)"File", (object)"DBOject"));
				dataRow["Last_modify"] = array4[num6];
				dataRow["FullPath"] = array5[num6];
				oDtDetail.Rows.Add(dataRow);
				num6++;
			}
			oDtDetail.AcceptChanges();
		}
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void frmHistory_Load(object sender, EventArgs e)
	{
		cboProductId.DataSource = Commons.GetDataTable("SiGetDmProduct");
		((ListControl)cboProductId).ValueMember = "ProductId";
		((ListControl)cboProductId).DisplayMember = "ProductName";
		CreateDetailTable();
		GetHistory();
		((DataGridView)adgvDetail).DataSource = oDtDetail;
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void bsHistory_PositionChanged(object sender, EventArgs e)
	{
		if ((oDtHistory != null && oDtHistory.Rows.Count != 0 && bsHistory != null && bsHistory.List.Count != 0) || 1 == 0)
		{
			ViewHistory((DataRowView)bsHistory.Current);
		}
	}
}
