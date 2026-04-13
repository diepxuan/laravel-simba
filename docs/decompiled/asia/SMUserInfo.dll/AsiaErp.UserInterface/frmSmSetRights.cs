using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using DTE.Bussiness;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSmSetRights : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("cboSubMenu")]
	private ComboBox _cboSubMenu;

	[AccessedThroughProperty("cboMainMenu")]
	private ComboBox _cboMainMenu;

	[AccessedThroughProperty("lblModule")]
	private Label _lblModule;

	[AccessedThroughProperty("chkAllDel")]
	private CheckBox _chkAllDel;

	[AccessedThroughProperty("chkAllEdit")]
	private CheckBox _chkAllEdit;

	[AccessedThroughProperty("chkAllAdd")]
	private CheckBox _chkAllAdd;

	[AccessedThroughProperty("chkAllView")]
	private CheckBox _chkAllView;

	[AccessedThroughProperty("cmdSave")]
	private Button _cmdSave;

	[AccessedThroughProperty("dgvDM")]
	private AsDataGridView _dgvDM;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("pnl_SetRightsUser")]
	private GroupBox _pnl_SetRightsUser;

	[AccessedThroughProperty("pnl_SetRightsCompany")]
	private GroupBox _pnl_SetRightsCompany;

	[AccessedThroughProperty("pnl_SetRightDash")]
	private GroupBox _pnl_SetRightDash;

	[AccessedThroughProperty("UcRightsDash")]
	private ucSmSetRightsDash _UcRightsDash;

	[AccessedThroughProperty("bsDashRight")]
	private BindingSource _bsDashRight;

	[AccessedThroughProperty("UcSmSetRightsCompany")]
	private ucSmSetRightsCompany _UcSmSetRightsCompany;

	[AccessedThroughProperty("UserName")]
	private DataGridViewTextBoxColumn _UserName;

	[AccessedThroughProperty("dgvcViewRight")]
	private DataGridViewCheckBoxColumn _dgvcViewRight;

	[AccessedThroughProperty("dgvcAddRight")]
	private DataGridViewCheckBoxColumn _dgvcAddRight;

	[AccessedThroughProperty("dgvcEditRight")]
	private DataGridViewCheckBoxColumn _dgvcEditRight;

	[AccessedThroughProperty("dgvcDeleteRight")]
	private DataGridViewCheckBoxColumn _dgvcDeleteRight;

	[AccessedThroughProperty("dgvcLimitedPrint")]
	private DataGridViewAsTextNumericColumn _dgvcLimitedPrint;

	private DataTable f_oTblUserRight;

	private DataTable f_oTblGrandRightUserName;

	private DataTable f_oTblMenu;

	private DataTable f_oTblSubMenu;

	private bool f_isLoading;

	private SMUserInfoController f_oController;

	internal string f_strUserName;

	internal string f_strGrandRightUserName;

	internal bool f_bIsAdmin;

	internal bool f_CurrentUserIsAdmin;

	internal virtual ComboBox cboSubMenu
	{
		get
		{
			return _cboSubMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboSubMenu_SelectedIndexChanged;
			if (_cboSubMenu != null)
			{
				_cboSubMenu.SelectedIndexChanged -= eventHandler;
			}
			_cboSubMenu = value;
			if (_cboSubMenu != null)
			{
				_cboSubMenu.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual ComboBox cboMainMenu
	{
		get
		{
			return _cboMainMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboMainMenu_SelectedValueChanged;
			if (_cboMainMenu != null)
			{
				((ListControl)_cboMainMenu).SelectedValueChanged -= eventHandler;
			}
			_cboMainMenu = value;
			if (_cboMainMenu != null)
			{
				((ListControl)_cboMainMenu).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblModule
	{
		get
		{
			return _lblModule;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblModule = value;
		}
	}

	internal virtual CheckBox chkAllDel
	{
		get
		{
			return _chkAllDel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = chkAllDel_CheckedChanged;
			if (_chkAllDel != null)
			{
				_chkAllDel.CheckedChanged -= eventHandler;
			}
			_chkAllDel = value;
			if (_chkAllDel != null)
			{
				_chkAllDel.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual CheckBox chkAllEdit
	{
		get
		{
			return _chkAllEdit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = chkAllEdit_CheckedChanged;
			if (_chkAllEdit != null)
			{
				_chkAllEdit.CheckedChanged -= eventHandler;
			}
			_chkAllEdit = value;
			if (_chkAllEdit != null)
			{
				_chkAllEdit.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual CheckBox chkAllAdd
	{
		get
		{
			return _chkAllAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = chkAllAdd_CheckedChanged;
			if (_chkAllAdd != null)
			{
				_chkAllAdd.CheckedChanged -= eventHandler;
			}
			_chkAllAdd = value;
			if (_chkAllAdd != null)
			{
				_chkAllAdd.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual CheckBox chkAllView
	{
		get
		{
			return _chkAllView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = chkAllView_CheckedChanged;
			if (_chkAllView != null)
			{
				_chkAllView.CheckedChanged -= eventHandler;
			}
			_chkAllView = value;
			if (_chkAllView != null)
			{
				_chkAllView.CheckedChanged += eventHandler;
			}
		}
	}

	protected virtual Button cmdSave
	{
		get
		{
			return _cmdSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdSave_Click;
			if (_cmdSave != null)
			{
				((Control)_cmdSave).Click -= eventHandler;
			}
			_cmdSave = value;
			if (_cmdSave != null)
			{
				((Control)_cmdSave).Click += eventHandler;
			}
		}
	}

	internal virtual AsDataGridView dgvDM
	{
		get
		{
			return _dgvDM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DataGridViewCellValidatingEventHandler val = new DataGridViewCellValidatingEventHandler(dgvDM_CellValidating);
			if (_dgvDM != null)
			{
				((DataGridView)_dgvDM).CellValidating -= val;
			}
			_dgvDM = value;
			if (_dgvDM != null)
			{
				((DataGridView)_dgvDM).CellValidating += val;
			}
		}
	}

	protected internal virtual Button cmdClose
	{
		get
		{
			return _cmdClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdClose_Click;
			if (_cmdClose != null)
			{
				((Control)_cmdClose).Click -= eventHandler;
			}
			_cmdClose = value;
			if (_cmdClose != null)
			{
				((Control)_cmdClose).Click += eventHandler;
			}
		}
	}

	internal virtual GroupBox pnl_SetRightsUser
	{
		get
		{
			return _pnl_SetRightsUser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pnl_SetRightsUser = value;
		}
	}

	internal virtual GroupBox pnl_SetRightsCompany
	{
		get
		{
			return _pnl_SetRightsCompany;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pnl_SetRightsCompany = value;
		}
	}

	internal virtual GroupBox pnl_SetRightDash
	{
		get
		{
			return _pnl_SetRightDash;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pnl_SetRightDash = value;
		}
	}

	internal virtual ucSmSetRightsDash UcRightsDash
	{
		get
		{
			return _UcRightsDash;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_UcRightsDash = value;
		}
	}

	internal virtual BindingSource bsDashRight
	{
		get
		{
			return _bsDashRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_bsDashRight = value;
		}
	}

	internal virtual ucSmSetRightsCompany UcSmSetRightsCompany
	{
		get
		{
			return _UcSmSetRightsCompany;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_UcSmSetRightsCompany = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn UserName
	{
		get
		{
			return _UserName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_UserName = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcViewRight
	{
		get
		{
			return _dgvcViewRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcViewRight = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcAddRight
	{
		get
		{
			return _dgvcAddRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcAddRight = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcEditRight
	{
		get
		{
			return _dgvcEditRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcEditRight = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcDeleteRight
	{
		get
		{
			return _dgvcDeleteRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcDeleteRight = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcLimitedPrint
	{
		get
		{
			return _dgvcLimitedPrint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcLimitedPrint = value;
		}
	}

	private SMUserInfoController MyController
	{
		get
		{
			if (f_oController == null)
			{
				f_oController = new SMUserInfoController();
			}
			return f_oController;
		}
	}

	public frmSmSetRights()
	{
		((Form)this).Load += frmSmSetRights_Load;
		f_isLoading = true;
		f_oController = null;
		f_strUserName = "";
		f_strGrandRightUserName = "";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected O, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		cboSubMenu = new ComboBox();
		cboMainMenu = new ComboBox();
		lblModule = new Label();
		chkAllDel = new CheckBox();
		chkAllEdit = new CheckBox();
		chkAllAdd = new CheckBox();
		chkAllView = new CheckBox();
		dgvDM = new AsDataGridView();
		cmdClose = new Button();
		cmdSave = new Button();
		pnl_SetRightsUser = new GroupBox();
		pnl_SetRightsCompany = new GroupBox();
		pnl_SetRightDash = new GroupBox();
		bsDashRight = new BindingSource(components);
		UserName = new DataGridViewTextBoxColumn();
		dgvcViewRight = new DataGridViewCheckBoxColumn();
		dgvcAddRight = new DataGridViewCheckBoxColumn();
		dgvcEditRight = new DataGridViewCheckBoxColumn();
		dgvcDeleteRight = new DataGridViewCheckBoxColumn();
		dgvcLimitedPrint = new DataGridViewAsTextNumericColumn();
		UcRightsDash = new ucSmSetRightsDash();
		UcSmSetRightsCompany = new ucSmSetRightsCompany();
		((ISupportInitialize)dgvDM).BeginInit();
		((Control)pnl_SetRightsUser).SuspendLayout();
		((Control)pnl_SetRightsCompany).SuspendLayout();
		((Control)pnl_SetRightDash).SuspendLayout();
		((ISupportInitialize)bsDashRight).BeginInit();
		((Control)this).SuspendLayout();
		cboSubMenu.DropDownStyle = (ComboBoxStyle)2;
		((Control)cboSubMenu).Font = new Font("Microsoft Sans Serif", 10f);
		((Control)cboSubMenu).ImeMode = (ImeMode)2;
		cboSubMenu.ItemHeight = 16;
		ComboBox obj = cboSubMenu;
		Point location = new Point(413, 19);
		((Control)obj).Location = location;
		((Control)cboSubMenu).Name = "cboSubMenu";
		ComboBox obj2 = cboSubMenu;
		Size size = new Size(415, 24);
		((Control)obj2).Size = size;
		((Control)cboSubMenu).TabIndex = 7;
		cboMainMenu.DropDownStyle = (ComboBoxStyle)2;
		((Control)cboMainMenu).Font = new Font("Microsoft Sans Serif", 10f);
		((Control)cboMainMenu).ImeMode = (ImeMode)2;
		cboMainMenu.ItemHeight = 16;
		ComboBox obj3 = cboMainMenu;
		location = new Point(99, 19);
		((Control)obj3).Location = location;
		((Control)cboMainMenu).Name = "cboMainMenu";
		ComboBox obj4 = cboMainMenu;
		size = new Size(308, 24);
		((Control)obj4).Size = size;
		((Control)cboMainMenu).TabIndex = 6;
		lblModule.ImeMode = (ImeMode)0;
		Label obj5 = lblModule;
		location = new Point(42, 25);
		((Control)obj5).Location = location;
		((Control)lblModule).Name = "lblModule";
		Label obj6 = lblModule;
		size = new Size(61, 19);
		((Control)obj6).Size = size;
		((Control)lblModule).TabIndex = 8;
		lblModule.Text = "Phân hệ";
		((Control)chkAllDel).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllDel).AutoSize = true;
		((ButtonBase)chkAllDel).ImeMode = (ImeMode)0;
		CheckBox obj7 = chkAllDel;
		location = new Point(706, 274);
		((Control)obj7).Location = location;
		((Control)chkAllDel).Name = "chkAllDel";
		CheckBox obj8 = chkAllDel;
		size = new Size(15, 14);
		((Control)obj8).Size = size;
		((Control)chkAllDel).TabIndex = 18;
		((Control)chkAllEdit).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllEdit).AutoSize = true;
		((ButtonBase)chkAllEdit).ImeMode = (ImeMode)0;
		CheckBox obj9 = chkAllEdit;
		location = new Point(666, 274);
		((Control)obj9).Location = location;
		((Control)chkAllEdit).Name = "chkAllEdit";
		CheckBox obj10 = chkAllEdit;
		size = new Size(15, 14);
		((Control)obj10).Size = size;
		((Control)chkAllEdit).TabIndex = 17;
		((Control)chkAllAdd).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllAdd).AutoSize = true;
		((ButtonBase)chkAllAdd).ImeMode = (ImeMode)0;
		CheckBox obj11 = chkAllAdd;
		location = new Point(626, 274);
		((Control)obj11).Location = location;
		((Control)chkAllAdd).Name = "chkAllAdd";
		CheckBox obj12 = chkAllAdd;
		size = new Size(15, 14);
		((Control)obj12).Size = size;
		((Control)chkAllAdd).TabIndex = 16;
		((Control)chkAllView).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllView).AutoSize = true;
		((ButtonBase)chkAllView).ImeMode = (ImeMode)0;
		CheckBox obj13 = chkAllView;
		location = new Point(586, 274);
		((Control)obj13).Location = location;
		((Control)chkAllView).Name = "chkAllView";
		CheckBox obj14 = chkAllView;
		size = new Size(15, 14);
		((Control)obj14).Size = size;
		((Control)chkAllView).TabIndex = 15;
		((DataGridView)dgvDM).AllowUserToAddRows = false;
		((DataGridView)dgvDM).AllowUserToDeleteRows = false;
		((DataGridView)dgvDM).AllowUserToResizeColumns = false;
		val.BackColor = Color.LightYellow;
		((DataGridView)dgvDM).AlternatingRowsDefaultCellStyle = val;
		((Control)dgvDM).Anchor = (AnchorStyles)15;
		((DataGridView)dgvDM).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvDM).BorderStyle = (BorderStyle)2;
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Control;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.WindowText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDM).ColumnHeadersDefaultCellStyle = val2;
		((DataGridView)dgvDM).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvDM).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)UserName,
			(DataGridViewColumn)dgvcViewRight,
			(DataGridViewColumn)dgvcAddRight,
			(DataGridViewColumn)dgvcEditRight,
			(DataGridViewColumn)dgvcDeleteRight,
			dgvcLimitedPrint
		});
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = SystemColors.Window;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.ControlText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvDM).DefaultCellStyle = val3;
		dgvDM.DoubleBuffered = false;
		((DataGridView)dgvDM).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvDM).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvDM;
		location = new Point(6, 49);
		((Control)asDataGridView).Location = location;
		((Control)dgvDM).Name = "dgvDM";
		val4.Alignment = (DataGridViewContentAlignment)32;
		val4.BackColor = SystemColors.Control;
		val4.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val4.ForeColor = SystemColors.WindowText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDM).RowHeadersDefaultCellStyle = val4;
		((DataGridView)dgvDM).RowHeadersWidth = 35;
		dgvDM.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvDM).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvDM;
		size = new Size(822, 219);
		((Control)asDataGridView2).Size = size;
		((Control)dgvDM).TabIndex = 40;
		((Control)cmdClose).Anchor = (AnchorStyles)6;
		cmdClose.DialogResult = (DialogResult)2;
		((ButtonBase)cmdClose).Image = (Image)(object)Resources.imgExit;
		((ButtonBase)cmdClose).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdClose).ImeMode = (ImeMode)0;
		Button obj15 = cmdClose;
		location = new Point(85, 537);
		((Control)obj15).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj16 = cmdClose;
		size = new Size(67, 23);
		((Control)obj16).Size = size;
		((Control)cmdClose).TabIndex = 41;
		((ButtonBase)cmdClose).Text = "T&hoát";
		((ButtonBase)cmdClose).TextAlign = (ContentAlignment)64;
		((Control)cmdSave).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdSave).Image = (Image)(object)Resources.save;
		((ButtonBase)cmdSave).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdSave).ImeMode = (ImeMode)0;
		Button obj17 = cmdSave;
		location = new Point(12, 537);
		((Control)obj17).Location = location;
		((Control)cmdSave).Name = "cmdSave";
		Button obj18 = cmdSave;
		size = new Size(67, 23);
		((Control)obj18).Size = size;
		((Control)cmdSave).TabIndex = 19;
		((ButtonBase)cmdSave).Text = "&Lưu";
		((ButtonBase)cmdSave).TextAlign = (ContentAlignment)64;
		((Control)pnl_SetRightsUser).Anchor = (AnchorStyles)15;
		((Control)pnl_SetRightsUser).Controls.Add((Control)(object)cboMainMenu);
		((Control)pnl_SetRightsUser).Controls.Add((Control)(object)lblModule);
		((Control)pnl_SetRightsUser).Controls.Add((Control)(object)dgvDM);
		((Control)pnl_SetRightsUser).Controls.Add((Control)(object)chkAllDel);
		((Control)pnl_SetRightsUser).Controls.Add((Control)(object)cboSubMenu);
		((Control)pnl_SetRightsUser).Controls.Add((Control)(object)chkAllEdit);
		((Control)pnl_SetRightsUser).Controls.Add((Control)(object)chkAllAdd);
		((Control)pnl_SetRightsUser).Controls.Add((Control)(object)chkAllView);
		GroupBox obj19 = pnl_SetRightsUser;
		location = new Point(15, 231);
		((Control)obj19).Location = location;
		((Control)pnl_SetRightsUser).Name = "pnl_SetRightsUser";
		GroupBox obj20 = pnl_SetRightsUser;
		size = new Size(834, 299);
		((Control)obj20).Size = size;
		((Control)pnl_SetRightsUser).TabIndex = 42;
		pnl_SetRightsUser.TabStop = false;
		pnl_SetRightsUser.Text = "Chức năng";
		((Control)pnl_SetRightsCompany).Anchor = (AnchorStyles)7;
		((Control)pnl_SetRightsCompany).Controls.Add((Control)(object)UcSmSetRightsCompany);
		GroupBox obj21 = pnl_SetRightsCompany;
		location = new Point(12, 12);
		((Control)obj21).Location = location;
		((Control)pnl_SetRightsCompany).Name = "pnl_SetRightsCompany";
		GroupBox obj22 = pnl_SetRightsCompany;
		size = new Size(415, 213);
		((Control)obj22).Size = size;
		((Control)pnl_SetRightsCompany).TabIndex = 43;
		pnl_SetRightsCompany.TabStop = false;
		pnl_SetRightsCompany.Text = "Công ty";
		((Control)pnl_SetRightDash).Anchor = (AnchorStyles)7;
		((Control)pnl_SetRightDash).Controls.Add((Control)(object)UcRightsDash);
		GroupBox obj23 = pnl_SetRightDash;
		location = new Point(435, 12);
		((Control)obj23).Location = location;
		((Control)pnl_SetRightDash).Name = "pnl_SetRightDash";
		GroupBox obj24 = pnl_SetRightDash;
		size = new Size(414, 213);
		((Control)obj24).Size = size;
		((Control)pnl_SetRightDash).TabIndex = 44;
		pnl_SetRightDash.TabStop = false;
		pnl_SetRightDash.Text = "Màn hình chủ";
		((DataGridViewColumn)UserName).DataPropertyName = "bar";
		((DataGridViewColumn)UserName).Frozen = true;
		((DataGridViewColumn)UserName).HeaderText = "Chức năng";
		((DataGridViewColumn)UserName).Name = "UserName";
		((DataGridViewColumn)UserName).ReadOnly = true;
		((DataGridViewColumn)UserName).Width = 530;
		((DataGridViewColumn)dgvcViewRight).DataPropertyName = "viewright";
		((DataGridViewColumn)dgvcViewRight).HeaderText = "Xem";
		((DataGridViewColumn)dgvcViewRight).Name = "dgvcViewRight";
		((DataGridViewColumn)dgvcViewRight).Width = 40;
		((DataGridViewColumn)dgvcAddRight).DataPropertyName = "InsertRight";
		((DataGridViewColumn)dgvcAddRight).HeaderText = "Thêm";
		((DataGridViewColumn)dgvcAddRight).Name = "dgvcAddRight";
		((DataGridViewColumn)dgvcAddRight).Width = 40;
		((DataGridViewColumn)dgvcEditRight).DataPropertyName = "UpdateRight";
		((DataGridViewColumn)dgvcEditRight).HeaderText = "Sửa";
		((DataGridViewColumn)dgvcEditRight).Name = "dgvcEditRight";
		((DataGridViewColumn)dgvcEditRight).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcEditRight).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcEditRight).Width = 40;
		((DataGridViewColumn)dgvcDeleteRight).DataPropertyName = "deleteright";
		((DataGridViewColumn)dgvcDeleteRight).HeaderText = "Xoá";
		((DataGridViewColumn)dgvcDeleteRight).Name = "dgvcDeleteRight";
		((DataGridViewColumn)dgvcDeleteRight).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcDeleteRight).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcDeleteRight).Width = 40;
		((DataGridViewColumn)dgvcLimitedPrint).DataPropertyName = "limitedPrint";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "0";
		((DataGridViewColumn)dgvcLimitedPrint).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcLimitedPrint).HeaderText = "Giới hạn in";
		dgvcLimitedPrint.Mask = "0";
		((DataGridViewColumn)dgvcLimitedPrint).Name = "dgvcLimitedPrint";
		((DataGridViewColumn)dgvcLimitedPrint).Resizable = (DataGridViewTriState)1;
		dgvcLimitedPrint.SortMode = (DataGridViewColumnSortMode)1;
		dgvcLimitedPrint.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)dgvcLimitedPrint).ToolTipText = "0 - Không giới hạn , 1 - In lần đầu tiên , 2 - In các lần tiếp theo";
		((DataGridViewColumn)dgvcLimitedPrint).Width = 70;
		((Control)UcRightsDash).Anchor = (AnchorStyles)15;
		UcRightsDash.GrandRightUserName = "";
		UcRightsDash.IsAdmin = false;
		ucSmSetRightsDash ucRightsDash = UcRightsDash;
		location = new Point(3, 16);
		((Control)ucRightsDash).Location = location;
		UcRightsDash.MySourceGrandRight = null;
		UcRightsDash.MySourceUserRight = null;
		((Control)UcRightsDash).Name = "UcRightsDash";
		ucSmSetRightsDash ucRightsDash2 = UcRightsDash;
		size = new Size(408, 194);
		((Control)ucRightsDash2).Size = size;
		((Control)UcRightsDash).TabIndex = 0;
		UcRightsDash.UserName = "";
		((Control)UcSmSetRightsCompany).Anchor = (AnchorStyles)15;
		UcSmSetRightsCompany.GrandRightUserName = "";
		UcSmSetRightsCompany.IsAdmin = false;
		ucSmSetRightsCompany ucSmSetRightsCompany = UcSmSetRightsCompany;
		location = new Point(3, 16);
		((Control)ucSmSetRightsCompany).Location = location;
		UcSmSetRightsCompany.MySourceCompanyRight = null;
		UcSmSetRightsCompany.MySourceGrandCompanyRight = null;
		((Control)UcSmSetRightsCompany).Name = "UcSmSetRightsCompany";
		ucSmSetRightsCompany ucSmSetRightsCompany2 = UcSmSetRightsCompany;
		size = new Size(409, 194);
		((Control)ucSmSetRightsCompany2).Size = size;
		((Control)UcSmSetRightsCompany).TabIndex = 0;
		UcSmSetRightsCompany.UserName = null;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(858, 566);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)pnl_SetRightDash);
		((Control)this).Controls.Add((Control)(object)pnl_SetRightsCompany);
		((Control)this).Controls.Add((Control)(object)pnl_SetRightsUser);
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Control)this).Controls.Add((Control)(object)cmdSave);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSmSetRights";
		((Form)this).Text = "Phân quyền";
		((ISupportInitialize)dgvDM).EndInit();
		((Control)pnl_SetRightsUser).ResumeLayout(false);
		((Control)pnl_SetRightsUser).PerformLayout();
		((Control)pnl_SetRightsCompany).ResumeLayout(false);
		((Control)pnl_SetRightDash).ResumeLayout(false);
		((ISupportInitialize)bsDashRight).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void cboMainMenu_SelectedValueChanged(object sender, EventArgs e)
	{
		string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Link = '", NewLateBinding.LateIndexGet(cboMainMenu.SelectedItem, new object[1] { "Link" }, (string[])null)), (object)"'"));
		f_oTblSubMenu.DefaultView.RowFilter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Link = '", NewLateBinding.LateIndexGet(cboMainMenu.SelectedItem, new object[1] { "Link" }, (string[])null)), (object)"'"));
		if (f_oTblSubMenu.DefaultView.Count > 0)
		{
			((ListControl)cboSubMenu).SelectedValue = RuntimeHelpers.GetObjectValue(f_oTblSubMenu.DefaultView[0]["MenuID"]);
			text = text + " and LinkDetail = '" + Conversions.ToString(f_oTblSubMenu.DefaultView[0]["MenuID"]).Substring(3, 2) + "'";
		}
		f_oTblUserRight.DefaultView.RowFilter = text;
		chkAllView.Checked = false;
		chkAllAdd.Checked = false;
		chkAllEdit.Checked = false;
		chkAllDel.Checked = false;
	}

	private void cboSubMenu_SelectedIndexChanged(object sender, EventArgs e)
	{
		((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvDM).DataSource)].EndCurrentEdit();
		string rowFilter = "SUBSTRING(MenuID,1,5) = '" + Conversions.ToString(NewLateBinding.LateIndexGet(cboSubMenu.SelectedItem, new object[1] { "MenuID" }, (string[])null)).Substring(0, 5) + "'";
		f_oTblUserRight.DefaultView.RowFilter = rowFilter;
		chkAllView.Checked = false;
		chkAllAdd.Checked = false;
		chkAllEdit.Checked = false;
		chkAllDel.Checked = false;
	}

	private void cmdSave_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (UcSmSetRightsCompany.ProcessDB() && ProcessUserRight() && UcRightsDash.ProcessDB())
			{
				CMessageBox.Show(50015);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
	}

	private void cmdClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void frmSmSetRights_Load(object sender, EventArgs e)
	{
		GetDataCompany();
		GetDataUserRight();
		GetDataDash();
		if (f_CurrentUserIsAdmin)
		{
			((Control)pnl_SetRightDash).Enabled = false;
			((Control)pnl_SetRightsUser).Enabled = false;
		}
	}

	private void dgvDM_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
	{
		if (!f_bIsAdmin && ((DataGridView)dgvDM).Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && !Conversions.ToBoolean(f_oTblGrandRightUserName.AsEnumerable().ElementAtOrDefault(e.RowIndex)[((DataGridView)dgvDM).Columns[e.ColumnIndex].DataPropertyName]))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(f_oTblUserRight.Rows[e.RowIndex][((DataGridView)dgvDM).Columns[e.ColumnIndex].DataPropertyName]);
			f_oTblUserRight.Rows[e.RowIndex][((DataGridView)dgvDM).Columns[e.ColumnIndex].DataPropertyName] = RuntimeHelpers.GetObjectValue(objectValue);
		}
	}

	protected override bool ProcessKeyPreview(ref Message m)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		Keys val = (Keys)(((Message)(ref m)).WParam.ToInt32() & 0xFFFF);
		if ((int)val == 27)
		{
			switch (((Message)(ref m)).Msg)
			{
			case 256:
				((Form)this).Close();
				return false;
			case 258:
				((Message)(ref m)).HWnd = IntPtr.Zero;
				return false;
			default:
				return false;
			}
		}
		return base.ProcessKeyPreview(ref m);
	}

	private void GetDataUserRight()
	{
		f_oTblUserRight = MyController.GetAllUserRights(f_strUserName);
		f_oTblGrandRightUserName = MyController.GetAllUserRights(f_strGrandRightUserName);
		((DataGridView)dgvDM).DataSource = f_oTblUserRight.DefaultView;
		f_oTblMenu = MyController.GetMenuBar();
		f_oTblSubMenu = MyController.GetSubMenuBar();
		cboSubMenu.DataSource = f_oTblSubMenu.DefaultView;
		((ListControl)cboSubMenu).DisplayMember = "Bar";
		((ListControl)cboSubMenu).ValueMember = "MenuID";
		cboMainMenu.DataSource = f_oTblMenu.DefaultView;
		((ListControl)cboMainMenu).DisplayMember = "Bar";
		((ListControl)cboMainMenu).ValueMember = "MenuID";
	}

	private void GetDataDash()
	{
		UcRightsDash.UserName = f_strUserName;
		UcRightsDash.GrandRightUserName = f_strGrandRightUserName;
		UcRightsDash.IsAdmin = f_bIsAdmin;
		UcRightsDash.MySourceUserRight = MyController.GetAllUserRightDash(f_strUserName);
		UcRightsDash.MySourceGrandRight = MyController.GetAllUserRightDash(f_strGrandRightUserName);
		UcRightsDash.GetData();
	}

	private void GetDataCompany()
	{
		UcSmSetRightsCompany.UserName = f_strUserName;
		UcSmSetRightsCompany.GrandRightUserName = f_strGrandRightUserName;
		UcSmSetRightsCompany.IsAdmin = f_bIsAdmin;
		UcSmSetRightsCompany.MySourceCompanyRight = MyController.GetAllRightCompany(f_strUserName);
		UcSmSetRightsCompany.MySourceGrandCompanyRight = MyController.GetAllRightCompany(f_strGrandRightUserName);
		UcSmSetRightsCompany.GetData();
	}

	private bool ProcessUserRight()
	{
		bool result;
		try
		{
			((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvDM).DataSource)].EndCurrentEdit();
			if (f_oTblUserRight.GetChanges(DataRowState.Modified) == null)
			{
				result = true;
				goto IL_01bd;
			}
			foreach (DataRow row in f_oTblUserRight.GetChanges(DataRowState.Modified).Rows)
			{
				MyController.DeleteUserRight(f_strUserName, Conversions.ToString(row["MenuID"]));
				if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(row["ViewRight"], (object)true, false), Operators.CompareObjectEqual(row["InsertRight"], (object)true, false)), Operators.CompareObjectEqual(row["UpdateRight"], (object)true, false)), Operators.CompareObjectEqual(row["DeleteRight"], (object)true, false))))
				{
					int num = MyController.InsertUserRight(f_strUserName, Conversions.ToString(row["MenuID"]), ViewRight: true, Conversions.ToBoolean(row["InsertRight"]), Conversions.ToBoolean(row["UpdateRight"]), Conversions.ToBoolean(row["DeleteRight"]), Conversions.ToInteger(row["LimitedPrint"]));
					row["ViewRight"] = true;
				}
			}
			MyController.MyDAO.Destroy();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			result = false;
			ProjectData.ClearProjectError();
			goto IL_01bd;
		}
		return true;
		IL_01bd:
		return result;
	}

	private void chkAllView_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = chkAllView.Checked;
		checked
		{
			int num = f_oTblUserRight.DefaultView.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Conversions.ToBoolean(f_oTblGrandRightUserName.AsEnumerable().ElementAtOrDefault(i)["ViewRight"]) | f_bIsAdmin)
				{
					f_oTblUserRight.DefaultView[i]["ViewRight"] = flag;
				}
			}
			if (((DataGridView)dgvDM).CurrentCell != null)
			{
				((DataGridView)dgvDM).InvalidateRow(((DataGridView)dgvDM).CurrentCell.RowIndex);
			}
		}
	}

	private void chkAllAdd_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = chkAllAdd.Checked;
		checked
		{
			int num = f_oTblUserRight.DefaultView.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Conversions.ToBoolean(f_oTblGrandRightUserName.AsEnumerable().ElementAtOrDefault(i)["InsertRight"]) | f_bIsAdmin)
				{
					f_oTblUserRight.DefaultView[i]["InsertRight"] = flag;
				}
			}
			if (((DataGridView)dgvDM).CurrentCell != null)
			{
				((DataGridView)dgvDM).InvalidateRow(((DataGridView)dgvDM).CurrentCell.RowIndex);
			}
		}
	}

	private void chkAllEdit_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = chkAllEdit.Checked;
		checked
		{
			int num = f_oTblUserRight.DefaultView.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Conversions.ToBoolean(f_oTblGrandRightUserName.AsEnumerable().ElementAtOrDefault(i)["UpdateRight"]) | f_bIsAdmin)
				{
					f_oTblUserRight.DefaultView[i]["UpdateRight"] = flag;
				}
			}
			if (((DataGridView)dgvDM).CurrentCell != null)
			{
				((DataGridView)dgvDM).InvalidateRow(((DataGridView)dgvDM).CurrentCell.RowIndex);
			}
		}
	}

	private void chkAllDel_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = chkAllDel.Checked;
		checked
		{
			int num = f_oTblUserRight.DefaultView.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Conversions.ToBoolean(f_oTblGrandRightUserName.AsEnumerable().ElementAtOrDefault(i)["DeleteRight"]) | f_bIsAdmin)
				{
					f_oTblUserRight.DefaultView[i]["DeleteRight"] = flag;
				}
			}
			if (((DataGridView)dgvDM).CurrentCell != null)
			{
				((DataGridView)dgvDM).InvalidateRow(((DataGridView)dgvDM).CurrentCell.RowIndex);
			}
		}
	}
}
