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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSMUserInfoEdit : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdSave")]
	private Button _cmdSave;

	[AccessedThroughProperty("epNotice")]
	private ErrorProvider _epNotice;

	[AccessedThroughProperty("bsDanhMuc")]
	private BindingSource _bsDanhMuc;

	[AccessedThroughProperty("txtFullName")]
	private TextBox _txtFullName;

	[AccessedThroughProperty("lblPassword")]
	private Label _lblPassword;

	[AccessedThroughProperty("lblFullName")]
	private Label _lblFullName;

	[AccessedThroughProperty("txtRePassword")]
	private TextBox _txtRePassword;

	[AccessedThroughProperty("lblRePassword")]
	private Label _lblRePassword;

	[AccessedThroughProperty("chkGrand")]
	private AsCheckBox _chkGrand;

	[AccessedThroughProperty("chkIsAdmin")]
	private AsCheckBox _chkIsAdmin;

	[AccessedThroughProperty("txtUserName")]
	private TextBox _txtUserName;

	[AccessedThroughProperty("lblUserName")]
	private Label _lblUserName;

	[AccessedThroughProperty("txtPassword")]
	private TextBox _txtPassword;

	[AccessedThroughProperty("AsTabControl")]
	private AsTabControl _AsTabControl;

	[AccessedThroughProperty("tabInfo")]
	private TabPage _tabInfo;

	[AccessedThroughProperty("chkKSD")]
	private AsCheckBox _chkKSD;

	[AccessedThroughProperty("grbPhan_nhom")]
	private GroupBox _grbPhan_nhom;

	[AccessedThroughProperty("cmdRemove")]
	private Button _cmdRemove;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("asDGV_Selected")]
	private AsDataGridView _asDGV_Selected;

	[AccessedThroughProperty("asDGV_Available")]
	private AsDataGridView _asDGV_Available;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	[AccessedThroughProperty("groupname")]
	private DataGridViewTextBoxColumn _groupname;

	[AccessedThroughProperty("fullname")]
	private DataGridViewTextBoxColumn _fullname;

	private SMUserInfoController f_oDmController;

	internal int f_intBindingPosition;

	private DataRow f_oDrwEdit;

	private bool f_blnOk;

	private bool f_blnIsEditMode;

	private DataSet ds;

	protected virtual Button cmdCancel
	{
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	protected virtual ErrorProvider epNotice
	{
		get
		{
			return _epNotice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_epNotice = value;
		}
	}

	internal virtual BindingSource bsDanhMuc
	{
		get
		{
			return _bsDanhMuc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_bsDanhMuc = value;
		}
	}

	internal virtual TextBox txtFullName
	{
		get
		{
			return _txtFullName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtFullName = value;
		}
	}

	internal virtual Label lblPassword
	{
		get
		{
			return _lblPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblPassword = value;
		}
	}

	internal virtual Label lblFullName
	{
		get
		{
			return _lblFullName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblFullName = value;
		}
	}

	internal virtual TextBox txtRePassword
	{
		get
		{
			return _txtRePassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtRePassword = value;
		}
	}

	internal virtual Label lblRePassword
	{
		get
		{
			return _lblRePassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblRePassword = value;
		}
	}

	internal virtual AsCheckBox chkGrand
	{
		get
		{
			return _chkGrand;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkGrand = value;
		}
	}

	internal virtual AsCheckBox chkIsAdmin
	{
		get
		{
			return _chkIsAdmin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkIsAdmin = value;
		}
	}

	internal virtual TextBox txtUserName
	{
		get
		{
			return _txtUserName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtUserName = value;
		}
	}

	internal virtual Label lblUserName
	{
		get
		{
			return _lblUserName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblUserName = value;
		}
	}

	internal virtual TextBox txtPassword
	{
		get
		{
			return _txtPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtPassword = value;
		}
	}

	protected virtual AsTabControl AsTabControl
	{
		get
		{
			return _AsTabControl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_AsTabControl = value;
		}
	}

	protected virtual TabPage tabInfo
	{
		get
		{
			return _tabInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tabInfo = value;
		}
	}

	internal virtual AsCheckBox chkKSD
	{
		get
		{
			return _chkKSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkKSD = value;
		}
	}

	internal virtual GroupBox grbPhan_nhom
	{
		get
		{
			return _grbPhan_nhom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_grbPhan_nhom = value;
		}
	}

	internal virtual Button cmdRemove
	{
		get
		{
			return _cmdRemove;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdRemove_Click;
			if (_cmdRemove != null)
			{
				((Control)_cmdRemove).Click -= eventHandler;
			}
			_cmdRemove = value;
			if (_cmdRemove != null)
			{
				((Control)_cmdRemove).Click += eventHandler;
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

	internal virtual AsDataGridView asDGV_Selected
	{
		get
		{
			return _asDGV_Selected;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_asDGV_Selected = value;
		}
	}

	internal virtual AsDataGridView asDGV_Available
	{
		get
		{
			return _asDGV_Available;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_asDGV_Available = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
	{
		get
		{
			return _DataGridViewTextBoxColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DataGridViewTextBoxColumn1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
	{
		get
		{
			return _DataGridViewTextBoxColumn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DataGridViewTextBoxColumn2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn groupname
	{
		get
		{
			return _groupname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_groupname = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn fullname
	{
		get
		{
			return _fullname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_fullname = value;
		}
	}

	[Browsable(false)]
	private SMUserInfoController MyController
	{
		get
		{
			if (f_oDmController == null)
			{
				f_oDmController = new SMUserInfoController();
			}
			return f_oDmController;
		}
	}

	[Browsable(false)]
	public bool EditMode
	{
		get
		{
			return f_blnIsEditMode;
		}
		set
		{
			f_blnIsEditMode = value;
		}
	}

	[Browsable(false)]
	public bool Success => f_blnOk;

	[Browsable(false)]
	public DataRow RowToEdit
	{
		get
		{
			return f_oDrwEdit;
		}
		set
		{
			f_oDrwEdit = value;
		}
	}

	public frmSMUserInfoEdit()
	{
		((Form)this).Load += frmDM_Edit_Load;
		f_oDmController = null;
		f_intBindingPosition = 0;
		f_blnOk = false;
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
		//IL_0028: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected O, but got Unknown
		//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd3: Expected O, but got Unknown
		//IL_0c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Expected O, but got Unknown
		//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e62: Expected O, but got Unknown
		//IL_0ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f03: Expected O, but got Unknown
		//IL_0fc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd1: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSMUserInfoEdit));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		cmdCancel = new Button();
		cmdSave = new Button();
		epNotice = new ErrorProvider(components);
		bsDanhMuc = new BindingSource(components);
		txtFullName = new TextBox();
		lblPassword = new Label();
		lblFullName = new Label();
		txtRePassword = new TextBox();
		lblRePassword = new Label();
		chkGrand = new AsCheckBox();
		chkIsAdmin = new AsCheckBox();
		txtUserName = new TextBox();
		lblUserName = new Label();
		txtPassword = new TextBox();
		AsTabControl = new AsTabControl();
		tabInfo = new TabPage();
		grbPhan_nhom = new GroupBox();
		asDGV_Available = new AsDataGridView();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		asDGV_Selected = new AsDataGridView();
		groupname = new DataGridViewTextBoxColumn();
		fullname = new DataGridViewTextBoxColumn();
		cmdRemove = new Button();
		cmdAdd = new Button();
		chkKSD = new AsCheckBox();
		((ISupportInitialize)epNotice).BeginInit();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabInfo).SuspendLayout();
		((Control)grbPhan_nhom).SuspendLayout();
		((ISupportInitialize)asDGV_Available).BeginInit();
		((ISupportInitialize)asDGV_Selected).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		((ButtonBase)cmdCancel).Image = (Image)componentResourceManager.GetObject("cmdCancel.Image");
		((ButtonBase)cmdCancel).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdCancel).ImeMode = (ImeMode)0;
		Button obj = cmdCancel;
		Point location = new Point(85, 374);
		((Control)obj).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj2 = cmdCancel;
		Size size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)cmdCancel).TabIndex = 2;
		((ButtonBase)cmdCancel).Text = "&Huỷ bỏ";
		((ButtonBase)cmdCancel).TextAlign = (ContentAlignment)64;
		((Control)cmdSave).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdSave).Image = (Image)componentResourceManager.GetObject("cmdSave.Image");
		((ButtonBase)cmdSave).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdSave).ImeMode = (ImeMode)0;
		Button obj3 = cmdSave;
		location = new Point(4, 374);
		((Control)obj3).Location = location;
		((Control)cmdSave).Name = "cmdSave";
		Button obj4 = cmdSave;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)cmdSave).TabIndex = 1;
		((ButtonBase)cmdSave).Text = "Lưu";
		((ButtonBase)cmdSave).TextAlign = (ContentAlignment)64;
		epNotice.ContainerControl = (ContainerControl)(object)this;
		TextBox obj5 = txtFullName;
		location = new Point(120, 40);
		((Control)obj5).Location = location;
		((TextBoxBase)txtFullName).MaxLength = 50;
		((Control)txtFullName).Name = "txtFullName";
		TextBox obj6 = txtFullName;
		size = new Size(431, 20);
		((Control)obj6).Size = size;
		((Control)txtFullName).TabIndex = 1;
		lblPassword.ImeMode = (ImeMode)0;
		Label obj7 = lblPassword;
		location = new Point(12, 68);
		((Control)obj7).Location = location;
		((Control)lblPassword).Name = "lblPassword";
		Label obj8 = lblPassword;
		size = new Size(72, 16);
		((Control)obj8).Size = size;
		((Control)lblPassword).TabIndex = 15;
		lblPassword.Text = "Mật khẩu";
		lblFullName.ImeMode = (ImeMode)0;
		Label obj9 = lblFullName;
		location = new Point(12, 42);
		((Control)obj9).Location = location;
		((Control)lblFullName).Name = "lblFullName";
		Label obj10 = lblFullName;
		size = new Size(72, 16);
		((Control)obj10).Size = size;
		((Control)lblFullName).TabIndex = 14;
		lblFullName.Text = "Tên đầy đủ";
		((Control)txtRePassword).ImeMode = (ImeMode)0;
		TextBox obj11 = txtRePassword;
		location = new Point(120, 92);
		((Control)obj11).Location = location;
		((TextBoxBase)txtRePassword).MaxLength = 30;
		((Control)txtRePassword).Name = "txtRePassword";
		txtRePassword.PasswordChar = '*';
		TextBox obj12 = txtRePassword;
		size = new Size(191, 20);
		((Control)obj12).Size = size;
		((Control)txtRePassword).TabIndex = 3;
		lblRePassword.ImeMode = (ImeMode)0;
		Label obj13 = lblRePassword;
		location = new Point(12, 94);
		((Control)obj13).Location = location;
		((Control)lblRePassword).Name = "lblRePassword";
		Label obj14 = lblRePassword;
		size = new Size(97, 16);
		((Control)obj14).Size = size;
		((Control)lblRePassword).TabIndex = 16;
		lblRePassword.Text = "Nhập lại mật khẩu";
		((CheckBox)chkGrand).CheckAlign = (ContentAlignment)64;
		chkGrand.Checked = false;
		((ButtonBase)chkGrand).ImeMode = (ImeMode)0;
		AsCheckBox asCheckBox = chkGrand;
		location = new Point(334, 83);
		((Control)asCheckBox).Location = location;
		((Control)chkGrand).Name = "chkGrand";
		AsCheckBox asCheckBox2 = chkGrand;
		size = new Size(108, 24);
		((Control)asCheckBox2).Size = size;
		((Control)chkGrand).TabIndex = 5;
		((ButtonBase)chkGrand).Text = "Cấp lại quyền";
		chkGrand.TextValue = "0";
		((CheckBox)chkIsAdmin).CheckAlign = (ContentAlignment)64;
		chkIsAdmin.Checked = false;
		((ButtonBase)chkIsAdmin).ImeMode = (ImeMode)0;
		AsCheckBox asCheckBox3 = chkIsAdmin;
		location = new Point(334, 62);
		((Control)asCheckBox3).Location = location;
		((Control)chkIsAdmin).Name = "chkIsAdmin";
		AsCheckBox asCheckBox4 = chkIsAdmin;
		size = new Size(108, 24);
		((Control)asCheckBox4).Size = size;
		((Control)chkIsAdmin).TabIndex = 4;
		((ButtonBase)chkIsAdmin).Text = "Là người quản trị";
		chkIsAdmin.TextValue = "0";
		txtUserName.CharacterCasing = (CharacterCasing)1;
		TextBox obj15 = txtUserName;
		location = new Point(120, 14);
		((Control)obj15).Location = location;
		((TextBoxBase)txtUserName).MaxLength = 20;
		((Control)txtUserName).Name = "txtUserName";
		TextBox obj16 = txtUserName;
		size = new Size(290, 20);
		((Control)obj16).Size = size;
		((Control)txtUserName).TabIndex = 0;
		lblUserName.ImeMode = (ImeMode)0;
		Label obj17 = lblUserName;
		location = new Point(12, 16);
		((Control)obj17).Location = location;
		((Control)lblUserName).Name = "lblUserName";
		Label obj18 = lblUserName;
		size = new Size(93, 16);
		((Control)obj18).Size = size;
		((Control)lblUserName).TabIndex = 13;
		lblUserName.Text = "Tên đăng nhập";
		((Control)txtPassword).ImeMode = (ImeMode)0;
		TextBox obj19 = txtPassword;
		location = new Point(120, 66);
		((Control)obj19).Location = location;
		((TextBoxBase)txtPassword).MaxLength = 30;
		((Control)txtPassword).Name = "txtPassword";
		txtPassword.PasswordChar = '*';
		TextBox obj20 = txtPassword;
		size = new Size(191, 20);
		((Control)obj20).Size = size;
		((Control)txtPassword).TabIndex = 2;
		((Control)AsTabControl).Controls.Add((Control)(object)tabInfo);
		((TabControl)AsTabControl).DrawMode = (TabDrawMode)1;
		AsTabControl asTabControl = AsTabControl;
		location = new Point(4, 4);
		((Control)asTabControl).Location = location;
		((Control)AsTabControl).Name = "AsTabControl";
		((TabControl)AsTabControl).SelectedIndex = 0;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(609, 366);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabInfo).Controls.Add((Control)(object)grbPhan_nhom);
		((Control)tabInfo).Controls.Add((Control)(object)chkKSD);
		((Control)tabInfo).Controls.Add((Control)(object)txtFullName);
		((Control)tabInfo).Controls.Add((Control)(object)lblPassword);
		((Control)tabInfo).Controls.Add((Control)(object)txtUserName);
		((Control)tabInfo).Controls.Add((Control)(object)lblFullName);
		((Control)tabInfo).Controls.Add((Control)(object)txtPassword);
		((Control)tabInfo).Controls.Add((Control)(object)lblUserName);
		((Control)tabInfo).Controls.Add((Control)(object)txtRePassword);
		((Control)tabInfo).Controls.Add((Control)(object)chkIsAdmin);
		((Control)tabInfo).Controls.Add((Control)(object)lblRePassword);
		((Control)tabInfo).Controls.Add((Control)(object)chkGrand);
		TabPage obj21 = tabInfo;
		location = new Point(4, 25);
		obj21.Location = location;
		((Control)tabInfo).Name = "tabInfo";
		TabPage obj22 = tabInfo;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)obj22).Padding = padding;
		TabPage obj23 = tabInfo;
		size = new Size(601, 337);
		((Control)obj23).Size = size;
		tabInfo.TabIndex = 0;
		tabInfo.Text = "&Thông tin";
		tabInfo.UseVisualStyleBackColor = true;
		((Control)grbPhan_nhom).Controls.Add((Control)(object)asDGV_Available);
		((Control)grbPhan_nhom).Controls.Add((Control)(object)asDGV_Selected);
		((Control)grbPhan_nhom).Controls.Add((Control)(object)cmdRemove);
		((Control)grbPhan_nhom).Controls.Add((Control)(object)cmdAdd);
		((Control)grbPhan_nhom).Dock = (DockStyle)2;
		GroupBox obj24 = grbPhan_nhom;
		location = new Point(3, 126);
		((Control)obj24).Location = location;
		((Control)grbPhan_nhom).Name = "grbPhan_nhom";
		GroupBox obj25 = grbPhan_nhom;
		size = new Size(595, 208);
		((Control)obj25).Size = size;
		((Control)grbPhan_nhom).TabIndex = 7;
		grbPhan_nhom.TabStop = false;
		grbPhan_nhom.Text = "Phân nhóm";
		((DataGridView)asDGV_Available).AllowUserToAddRows = false;
		((DataGridView)asDGV_Available).AllowUserToDeleteRows = false;
		((DataGridView)asDGV_Available).AllowUserToResizeColumns = false;
		((DataGridView)asDGV_Available).AllowUserToResizeRows = false;
		val.BackColor = Color.LightYellow;
		((DataGridView)asDGV_Available).AlternatingRowsDefaultCellStyle = val;
		((DataGridView)asDGV_Available).BackgroundColor = SystemColors.Window;
		((DataGridView)asDGV_Available).BorderStyle = (BorderStyle)2;
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Control;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.WindowText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDGV_Available).ColumnHeadersDefaultCellStyle = val2;
		((DataGridView)asDGV_Available).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)asDGV_Available).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn1,
			(DataGridViewColumn)DataGridViewTextBoxColumn2
		});
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = SystemColors.Window;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.ControlText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDGV_Available).DefaultCellStyle = val3;
		((Control)asDGV_Available).Dock = (DockStyle)4;
		asDGV_Available.DoubleBuffered = false;
		((DataGridView)asDGV_Available).EditMode = (DataGridViewEditMode)0;
		asDGV_Available.EnabledExport2Excel = true;
		((DataGridView)asDGV_Available).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = asDGV_Available;
		location = new Point(331, 16);
		((Control)asDataGridView).Location = location;
		((Control)asDGV_Available).Name = "asDGV_Available";
		asDGV_Available.ReadOnly = true;
		val4.Alignment = (DataGridViewContentAlignment)32;
		val4.BackColor = SystemColors.Control;
		val4.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val4.ForeColor = SystemColors.WindowText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDGV_Available).RowHeadersDefaultCellStyle = val4;
		((DataGridView)asDGV_Available).RowHeadersVisible = false;
		asDGV_Available.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDGV_Available).RowTemplate.Height = 20;
		((DataGridView)asDGV_Available).SelectionMode = (DataGridViewSelectionMode)1;
		AsDataGridView asDataGridView2 = asDGV_Available;
		size = new Size(261, 189);
		((Control)asDataGridView2).Size = size;
		((Control)asDGV_Available).TabIndex = 3;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).DataPropertyName = "groupname";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).HeaderText = "Nhóm còn lại";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).ReadOnly = true;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Width = 101;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).DataPropertyName = "fullname";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).HeaderText = "Tên đầy đủ";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Name = "DataGridViewTextBoxColumn2";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).ReadOnly = true;
		((DataGridView)asDGV_Selected).AllowUserToAddRows = false;
		((DataGridView)asDGV_Selected).AllowUserToDeleteRows = false;
		((DataGridView)asDGV_Selected).AllowUserToResizeColumns = false;
		((DataGridView)asDGV_Selected).AllowUserToResizeRows = false;
		val5.BackColor = Color.LightYellow;
		((DataGridView)asDGV_Selected).AlternatingRowsDefaultCellStyle = val5;
		((DataGridView)asDGV_Selected).BackgroundColor = SystemColors.Window;
		((DataGridView)asDGV_Selected).BorderStyle = (BorderStyle)2;
		val6.Alignment = (DataGridViewContentAlignment)16;
		val6.BackColor = SystemColors.Control;
		val6.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val6.ForeColor = SystemColors.WindowText;
		val6.SelectionBackColor = SystemColors.Highlight;
		val6.SelectionForeColor = SystemColors.HighlightText;
		val6.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDGV_Selected).ColumnHeadersDefaultCellStyle = val6;
		((DataGridView)asDGV_Selected).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)asDGV_Selected).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)groupname,
			(DataGridViewColumn)fullname
		});
		val7.Alignment = (DataGridViewContentAlignment)16;
		val7.BackColor = SystemColors.Window;
		val7.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val7.ForeColor = SystemColors.ControlText;
		val7.SelectionBackColor = SystemColors.Highlight;
		val7.SelectionForeColor = SystemColors.HighlightText;
		val7.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDGV_Selected).DefaultCellStyle = val7;
		((Control)asDGV_Selected).Dock = (DockStyle)3;
		asDGV_Selected.DoubleBuffered = false;
		((DataGridView)asDGV_Selected).EditMode = (DataGridViewEditMode)0;
		((DataGridView)asDGV_Selected).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView3 = asDGV_Selected;
		location = new Point(3, 16);
		((Control)asDataGridView3).Location = location;
		((Control)asDGV_Selected).Name = "asDGV_Selected";
		asDGV_Selected.ReadOnly = true;
		val8.Alignment = (DataGridViewContentAlignment)32;
		val8.BackColor = SystemColors.Control;
		val8.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val8.ForeColor = SystemColors.WindowText;
		val8.SelectionBackColor = SystemColors.Highlight;
		val8.SelectionForeColor = SystemColors.HighlightText;
		val8.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDGV_Selected).RowHeadersDefaultCellStyle = val8;
		((DataGridView)asDGV_Selected).RowHeadersVisible = false;
		asDGV_Selected.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)asDGV_Selected).RowTemplate.Height = 20;
		((DataGridView)asDGV_Selected).SelectionMode = (DataGridViewSelectionMode)1;
		AsDataGridView asDataGridView4 = asDGV_Selected;
		size = new Size(260, 189);
		((Control)asDataGridView4).Size = size;
		((Control)asDGV_Selected).TabIndex = 2;
		((DataGridViewColumn)groupname).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)groupname).DataPropertyName = "groupname";
		((DataGridViewColumn)groupname).HeaderText = "Nhóm đã chọn";
		((DataGridViewColumn)groupname).Name = "groupname";
		((DataGridViewColumn)groupname).ReadOnly = true;
		((DataGridViewColumn)groupname).Width = 101;
		((DataGridViewColumn)fullname).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)fullname).DataPropertyName = "fullname";
		((DataGridViewColumn)fullname).HeaderText = "Tên đầy đủ";
		((DataGridViewColumn)fullname).Name = "fullname";
		((DataGridViewColumn)fullname).ReadOnly = true;
		Button obj26 = cmdRemove;
		location = new Point(269, 79);
		((Control)obj26).Location = location;
		((Control)cmdRemove).Name = "cmdRemove";
		Button obj27 = cmdRemove;
		size = new Size(56, 23);
		((Control)obj27).Size = size;
		((Control)cmdRemove).TabIndex = 1;
		((ButtonBase)cmdRemove).Text = ">";
		((ButtonBase)cmdRemove).UseVisualStyleBackColor = true;
		Button obj28 = cmdAdd;
		location = new Point(269, 51);
		((Control)obj28).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		Button obj29 = cmdAdd;
		size = new Size(56, 23);
		((Control)obj29).Size = size;
		((Control)cmdAdd).TabIndex = 0;
		((ButtonBase)cmdAdd).Text = "<";
		((ButtonBase)cmdAdd).UseVisualStyleBackColor = true;
		((CheckBox)chkKSD).CheckAlign = (ContentAlignment)64;
		chkKSD.Checked = false;
		((ButtonBase)chkKSD).ImeMode = (ImeMode)0;
		AsCheckBox asCheckBox5 = chkKSD;
		location = new Point(334, 104);
		((Control)asCheckBox5).Location = location;
		((Control)chkKSD).Name = "chkKSD";
		AsCheckBox asCheckBox6 = chkKSD;
		size = new Size(108, 24);
		((Control)asCheckBox6).Size = size;
		((Control)chkKSD).TabIndex = 6;
		((ButtonBase)chkKSD).Text = "Không sử dụng";
		chkKSD.TextValue = "0";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(616, 408);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)AsTabControl);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdSave);
		((Control)this).Cursor = Cursors.Default;
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSMUserInfoEdit";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).Text = "frmSMUserInfoEdit";
		((ISupportInitialize)epNotice).EndInit();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabInfo).ResumeLayout(false);
		((Control)tabInfo).PerformLayout();
		((Control)grbPhan_nhom).ResumeLayout(false);
		((ISupportInitialize)asDGV_Available).EndInit();
		((ISupportInitialize)asDGV_Selected).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmDM_Edit_Load(object sender, EventArgs e)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		if (((Component)(object)this).DesignMode)
		{
			return;
		}
		if (Application.RenderWithVisualStyles)
		{
			((TabControl)AsTabControl).DrawMode = (TabDrawMode)1;
		}
		else
		{
			((TabControl)AsTabControl).DrawMode = (TabDrawMode)0;
			foreach (TabPage tabPage in ((TabControl)AsTabControl).TabPages)
			{
				TabPage val = tabPage;
				val.Text = Strings.Replace(val.Text, "&", "", 1, -1, (CompareMethod)0);
			}
		}
		CoreDataBinding();
		DataBinding();
		ds = MyController.GetUserGroup(Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(f_oDrwEdit["username"]), isNum: false)));
		((DataGridView)asDGV_Selected).DataSource = ds.Tables[0];
		((DataGridView)asDGV_Available).DataSource = ds.Tables[1];
		if (f_blnIsEditMode)
		{
			DisableFields();
			((Control)txtFullName).Select();
		}
		else
		{
			((Control)txtUserName).Select();
		}
	}

	private void cmdSave_Click(object sender, EventArgs e)
	{
		SetToRow();
		epNotice.Clear();
		if (!ValidData())
		{
			return;
		}
		if (f_blnIsEditMode)
		{
			if (UpdateDB())
			{
				f_blnOk = true;
				((Form)this).Close();
			}
		}
		else if (InsertToDB())
		{
			f_blnOk = true;
			((Form)this).Close();
		}
		if (ds.Tables[0].Rows.Count == 0)
		{
			MyController.InsertUserGroup("", Conversions.ToString(f_oDrwEdit["UserName"]), 0);
		}
		int num = 1;
		foreach (DataRow row in ds.Tables[0].Rows)
		{
			MyController.InsertUserGroup(Conversions.ToString(row["groupname"]), Conversions.ToString(f_oDrwEdit["UserName"]), num);
			num = checked(num + 1);
		}
		MyController.InsRightCompany(CompanyInformations.CompanyID, Conversions.ToString(f_oDrwEdit["UserName"]), Conversions.ToString(1));
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		quit();
	}

	private void cmdAdd_Click(object sender, EventArgs e)
	{
		if (ds.Tables[1].Rows.Count > 0)
		{
			DataRow dataRow = ds.Tables[0].NewRow();
			dataRow["groupname"] = ds.Tables[1].Rows[((ContainerControl)this).BindingContext[(object)ds.Tables[1]].Position][0].ToString();
			dataRow["fullname"] = ds.Tables[1].Rows[((ContainerControl)this).BindingContext[(object)ds.Tables[1]].Position][1].ToString();
			if (!ds.Tables[0].Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"groupname = '", dataRow["groupname"]), (object)"'"))).Any())
			{
				ds.Tables[0].Rows.Add(dataRow);
				ds.Tables[1].Rows.RemoveAt(((ContainerControl)this).BindingContext[(object)ds.Tables[1]].Position);
				ds.Tables[0].AcceptChanges();
				ds.Tables[1].AcceptChanges();
			}
		}
	}

	private void cmdRemove_Click(object sender, EventArgs e)
	{
		if (ds.Tables[0].Rows.Count > 0)
		{
			DataRow dataRow = ds.Tables[1].NewRow();
			dataRow["groupname"] = ds.Tables[0].Rows[((ContainerControl)this).BindingContext[(object)ds.Tables[0]].Position][0].ToString();
			dataRow["fullname"] = ds.Tables[0].Rows[((ContainerControl)this).BindingContext[(object)ds.Tables[0]].Position][1].ToString();
			if (!ds.Tables[1].Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"groupname = '", dataRow["groupname"]), (object)"'"))).Any())
			{
				ds.Tables[1].Rows.Add(dataRow);
				ds.Tables[0].Rows.RemoveAt(((ContainerControl)this).BindingContext[(object)ds.Tables[0]].Position);
				ds.Tables[1].AcceptChanges();
				ds.Tables[0].AcceptChanges();
			}
		}
	}

	private void DataBinding()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		Control ojb = (Control)(object)txtUserName;
		CreateDataBinding(ref ojb, "username");
		txtUserName = (TextBox)ojb;
		ojb = (Control)(object)txtFullName;
		CreateDataBinding(ref ojb, "fullname");
		txtFullName = (TextBox)ojb;
		ojb = (Control)(object)chkIsAdmin;
		CreateDataBinding(ref ojb, "isadmin", "Checked");
		chkIsAdmin = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkGrand;
		CreateDataBinding(ref ojb, "grand", "Checked");
		chkGrand = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkKSD;
		CreateDataBinding(ref ojb, "disabled", "Checked");
		chkKSD = (AsCheckBox)(object)ojb;
	}

	private void CoreDataBinding()
	{
		bsDanhMuc.DataSource = f_oDrwEdit.Table.DefaultView;
		((Control)this).DataBindings.Add("Tag", (object)bsDanhMuc, "username");
		bsDanhMuc.CurrencyManager.Position = f_intBindingPosition;
	}

	private bool SetToRow()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		foreach (Binding item in (BaseCollection)((ContainerControl)this).BindingContext[(object)bsDanhMuc].Bindings)
		{
			Binding val = item;
			val.WriteValue();
		}
		return true;
	}

	private bool InsertToDB()
	{
		string password = Helper.Encrypted(txtPassword.Text.Trim(), 100);
		f_oDrwEdit["password"] = txtPassword.Text;
		return MyController.InsertUserInfo(Conversions.ToString(f_oDrwEdit["UserName"]), Conversions.ToString(f_oDrwEdit["FullName"]), password, Conversions.ToString(f_oDrwEdit["isAdmin"]), Conversions.ToString(f_oDrwEdit["Grand"]), Conversions.ToString(f_oDrwEdit["Disabled"]), Conversions.ToString(f_oDrwEdit["Luser"])) != 0;
	}

	private bool UpdateDB()
	{
		return MyController.UpdateUserInfo(Conversions.ToString(f_oDrwEdit["UserName"]), Conversions.ToString(f_oDrwEdit["FullName"]), Conversions.ToString(f_oDrwEdit["isAdmin"]), Conversions.ToString(f_oDrwEdit["Grand"]), Conversions.ToString(f_oDrwEdit["Disabled"]), Conversions.ToString(f_oDrwEdit["Luser"]));
	}

	private void DisableFields()
	{
		txtPassword.Text = "khongdung";
		txtRePassword.Text = "khongdung";
		((Control)txtPassword).Enabled = false;
		((Control)txtRePassword).Enabled = false;
		((Control)txtUserName).Enabled = false;
	}

	private void quit()
	{
		((Form)this).Close();
	}

	protected void SetControlError(Control errControl, string errMessage, bool additive = true)
	{
		if (!additive)
		{
			epNotice.Clear();
		}
		epNotice.SetError(errControl, errMessage);
		errControl.Focus();
		errControl.Select();
	}

	private bool ValidData()
	{
		if (Operators.CompareString(txtUserName.Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtUserName, Helper.GetMessContent(50002));
			return false;
		}
		if (Operators.CompareString(txtFullName.Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtFullName, Helper.GetMessContent(50002));
			return false;
		}
		if (txtPassword.Text.Trim().Length == 0)
		{
			SetControlError((Control)(object)txtPassword, Helper.GetMessContent(50002));
			return false;
		}
		if (!f_blnIsEditMode && Operators.CompareString(txtPassword.Text.Trim(), txtRePassword.Text.Trim(), false) != 0)
		{
			SetControlError((Control)(object)txtPassword, Helper.GetMessContent(50084));
			return false;
		}
		return true;
	}

	protected void CreateDataBinding(ref Control ojb, string dbFieldName, string propertyName = "Text")
	{
		try
		{
			if (f_oDrwEdit != null && f_oDrwEdit.Table != null && f_oDrwEdit.Table.Columns.Contains(dbFieldName))
			{
				ojb.DataBindings.Add(propertyName, (object)bsDanhMuc, dbFieldName);
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

	protected override bool ProcessKeyPreview(ref Message m)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		Keys val = (Keys)(((Message)(ref m)).WParam.ToInt32() & 0xFFFF);
		if (((Message)(ref m)).Msg == 256 && (int)val == 27)
		{
			quit();
			return false;
		}
		return base.ProcessKeyPreview(ref m);
	}
}
