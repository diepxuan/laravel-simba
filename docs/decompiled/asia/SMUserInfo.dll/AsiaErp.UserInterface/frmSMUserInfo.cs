using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using DTE.Bussiness;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSMUserInfo : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("cmdDel")]
	private Button _cmdDel;

	[AccessedThroughProperty("cmdEdit")]
	private Button _cmdEdit;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("bsDanhMuc")]
	private BindingSource _bsDanhMuc;

	[AccessedThroughProperty("dgvDM")]
	private AsDataGridView _dgvDM;

	[AccessedThroughProperty("cmdSetRight")]
	private SplitButton _cmdSetRight;

	[AccessedThroughProperty("UserName")]
	private DataGridViewTextBoxColumn _UserName;

	[AccessedThroughProperty("FullName")]
	private DataGridViewTextBoxColumn _FullName;

	[AccessedThroughProperty("isAdmin")]
	private DataGridViewCheckBoxColumn _isAdmin;

	[AccessedThroughProperty("notactive")]
	private DataGridViewCheckBoxColumn _notactive;

	[AccessedThroughProperty("btnResetPass")]
	private Button _btnResetPass;

	public string EDIT_MODE_NAME;

	public string ADD_MODE_NAME;

	private CurrencyManager f_oCurrencyManager;

	private MenuInformation f_oMenuInfo;

	private SMUserInfoController f_oController;

	private DataTable f_oTblDM;

	private int f_intStart;

	private bool f_blnFound;

	private bool f_blnViewRight;

	private bool f_blnInsertRight;

	private bool f_blnUpdateRight;

	private bool f_blnDeleteRight;

	protected bool f_blnIsLoading;

	private string f_strExcInstanceResxFileName;

	private bool f_blnIsUserSizing;

	protected internal virtual Button cmdDel
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

	protected internal virtual Button cmdEdit
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

	protected internal virtual Button cmdAdd
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

	internal virtual AsDataGridView dgvDM
	{
		get
		{
			return _dgvDM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvDM = value;
		}
	}

	internal virtual SplitButton cmdSetRight
	{
		get
		{
			return _cmdSetRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdSetRight_Click;
			if (_cmdSetRight != null)
			{
				((Control)_cmdSetRight).Click -= eventHandler;
			}
			_cmdSetRight = value;
			if (_cmdSetRight != null)
			{
				((Control)_cmdSetRight).Click += eventHandler;
			}
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

	internal virtual DataGridViewTextBoxColumn FullName
	{
		get
		{
			return _FullName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_FullName = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn isAdmin
	{
		get
		{
			return _isAdmin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_isAdmin = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn notactive
	{
		get
		{
			return _notactive;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_notactive = value;
		}
	}

	internal virtual Button btnResetPass
	{
		get
		{
			return _btnResetPass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnResetPass_Click;
			if (_btnResetPass != null)
			{
				((Control)_btnResetPass).Click -= eventHandler;
			}
			_btnResetPass = value;
			if (_btnResetPass != null)
			{
				((Control)_btnResetPass).Click += eventHandler;
			}
		}
	}

	[Browsable(false)]
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

	public frmSMUserInfo()
	{
		((Form)this).Shown += frmSMUserInfo_Shown;
		((Form)this).Load += frmDMView_Load;
		((Control)this).Resize += frmDMView_Resize;
		EDIT_MODE_NAME = " - Sửa";
		ADD_MODE_NAME = " - Thêm mới";
		f_oController = null;
		f_intStart = 0;
		f_blnFound = false;
		f_blnViewRight = false;
		f_blnInsertRight = false;
		f_blnUpdateRight = false;
		f_blnDeleteRight = false;
		f_strExcInstanceResxFileName = "";
		f_blnIsUserSizing = false;
		InitializeComponent();
	}

	public frmSMUserInfo(string menuid)
		: base(menuid)
	{
		((Form)this).Shown += frmSMUserInfo_Shown;
		((Form)this).Load += frmDMView_Load;
		((Control)this).Resize += frmDMView_Resize;
		EDIT_MODE_NAME = " - Sửa";
		ADD_MODE_NAME = " - Thêm mới";
		f_oController = null;
		f_intStart = 0;
		f_blnFound = false;
		f_blnViewRight = false;
		f_blnInsertRight = false;
		f_blnUpdateRight = false;
		f_blnDeleteRight = false;
		f_strExcInstanceResxFileName = "";
		f_blnIsUserSizing = false;
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
		//IL_0023: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSMUserInfo));
		dgvDM = new AsDataGridView();
		UserName = new DataGridViewTextBoxColumn();
		FullName = new DataGridViewTextBoxColumn();
		isAdmin = new DataGridViewCheckBoxColumn();
		notactive = new DataGridViewCheckBoxColumn();
		cmdSetRight = new SplitButton();
		btnResetPass = new Button();
		cmdDel = new Button();
		cmdEdit = new Button();
		cmdAdd = new Button();
		cmdClose = new Button();
		bsDanhMuc = new BindingSource(components);
		((ISupportInitialize)dgvDM).BeginInit();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((DataGridView)dgvDM).AllowUserToAddRows = false;
		((DataGridView)dgvDM).AllowUserToDeleteRows = false;
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
		((DataGridView)dgvDM).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)UserName,
			(DataGridViewColumn)FullName,
			(DataGridViewColumn)isAdmin,
			(DataGridViewColumn)notactive
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
		Point location = new Point(4, 4);
		((Control)asDataGridView).Location = location;
		((Control)dgvDM).Name = "dgvDM";
		dgvDM.ReadOnly = true;
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
		Size size = new Size(712, 384);
		((Control)asDataGridView2).Size = size;
		((Control)dgvDM).TabIndex = 39;
		((DataGridViewColumn)UserName).DataPropertyName = "username";
		((DataGridViewColumn)UserName).HeaderText = "Tên đăng nhập";
		((DataGridViewColumn)UserName).Name = "UserName";
		((DataGridViewColumn)UserName).ReadOnly = true;
		((DataGridViewColumn)UserName).Width = 150;
		((DataGridViewColumn)FullName).DataPropertyName = "fullname";
		((DataGridViewColumn)FullName).HeaderText = "Tên đầy đủ";
		((DataGridViewColumn)FullName).Name = "FullName";
		((DataGridViewColumn)FullName).ReadOnly = true;
		((DataGridViewColumn)FullName).Width = 300;
		((DataGridViewColumn)isAdmin).DataPropertyName = "isAdmin";
		((DataGridViewColumn)isAdmin).HeaderText = "Là quản trị";
		((DataGridViewColumn)isAdmin).Name = "isAdmin";
		((DataGridViewColumn)notactive).DataPropertyName = "disabled";
		((DataGridViewColumn)notactive).HeaderText = "Không sử dụng";
		((DataGridViewColumn)notactive).Name = "notactive";
		((Control)cmdSetRight).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdSetRight).BackColor = SystemColors.Window;
		cmdSetRight.EnableSplit = false;
		((ButtonBase)cmdSetRight).Image = (Image)(object)Resources.imgLogedUser;
		((ButtonBase)cmdSetRight).ImageAlign = (ContentAlignment)16;
		cmdSetRight.ImageHeight = 4;
		cmdSetRight.ImageWidth = 7;
		SplitButton splitButton = cmdSetRight;
		location = new Point(4, 396);
		((Control)splitButton).Location = location;
		((Control)cmdSetRight).Name = "cmdSetRight";
		SplitButton splitButton2 = cmdSetRight;
		size = new Size(90, 24);
		((Control)splitButton2).Size = size;
		cmdSetRight.SplitWidth = 15;
		((Control)cmdSetRight).TabIndex = 40;
		((ButtonBase)cmdSetRight).Text = "&Phân quyền";
		((ButtonBase)cmdSetRight).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdSetRight).UseVisualStyleBackColor = false;
		((Control)btnResetPass).Anchor = (AnchorStyles)6;
		((ButtonBase)btnResetPass).BackColor = SystemColors.Window;
		((ButtonBase)btnResetPass).FlatAppearance.BorderColor = SystemColors.ActiveBorder;
		((ButtonBase)btnResetPass).FlatAppearance.MouseDownBackColor = SystemColors.Control;
		((ButtonBase)btnResetPass).FlatAppearance.MouseOverBackColor = SystemColors.Window;
		((ButtonBase)btnResetPass).Image = (Image)componentResourceManager.GetObject("btnResetPass.Image");
		((ButtonBase)btnResetPass).ImageAlign = (ContentAlignment)16;
		Button obj = btnResetPass;
		location = new Point(100, 396);
		((Control)obj).Location = location;
		((Control)btnResetPass).Name = "btnResetPass";
		Button obj2 = btnResetPass;
		size = new Size(109, 24);
		((Control)obj2).Size = size;
		((Control)btnResetPass).TabIndex = 41;
		((ButtonBase)btnResetPass).Text = "Đặt &lại mật khẩu";
		((ButtonBase)btnResetPass).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnResetPass).UseCompatibleTextRendering = true;
		((ButtonBase)btnResetPass).UseVisualStyleBackColor = false;
		((Control)cmdDel).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdDel).Image = (Image)(object)Resources.imgDelete;
		((ButtonBase)cmdDel).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdDel).ImeMode = (ImeMode)0;
		Button obj3 = cmdDel;
		location = new Point(578, 396);
		((Control)obj3).Location = location;
		((Control)cmdDel).Name = "cmdDel";
		((Control)cmdDel).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdDel;
		size = new Size(64, 23);
		((Control)obj4).Size = size;
		((Control)cmdDel).TabIndex = 31;
		((ButtonBase)cmdDel).Text = "&Xoá";
		((ButtonBase)cmdDel).TextAlign = (ContentAlignment)64;
		((Control)cmdEdit).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdEdit).Image = (Image)(object)Resources.imgEdit;
		((ButtonBase)cmdEdit).ImageAlign = (ContentAlignment)256;
		((ButtonBase)cmdEdit).ImeMode = (ImeMode)0;
		Button obj5 = cmdEdit;
		location = new Point(508, 396);
		((Control)obj5).Location = location;
		((Control)cmdEdit).Name = "cmdEdit";
		((Control)cmdEdit).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdEdit;
		size = new Size(64, 23);
		((Control)obj6).Size = size;
		((Control)cmdEdit).TabIndex = 30;
		((ButtonBase)cmdEdit).Text = "&Sửa";
		((ButtonBase)cmdEdit).TextAlign = (ContentAlignment)64;
		((Control)cmdAdd).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdAdd).Image = (Image)(object)Resources.imgAdd;
		((ButtonBase)cmdAdd).ImageAlign = (ContentAlignment)256;
		((ButtonBase)cmdAdd).ImeMode = (ImeMode)0;
		Button obj7 = cmdAdd;
		location = new Point(438, 396);
		((Control)obj7).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		((Control)cmdAdd).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdAdd;
		size = new Size(64, 23);
		((Control)obj8).Size = size;
		((Control)cmdAdd).TabIndex = 29;
		((ButtonBase)cmdAdd).Text = "&Mới";
		((ButtonBase)cmdAdd).TextAlign = (ContentAlignment)64;
		((Control)cmdClose).Anchor = (AnchorStyles)10;
		cmdClose.DialogResult = (DialogResult)2;
		((ButtonBase)cmdClose).Image = (Image)componentResourceManager.GetObject("cmdClose.Image");
		((ButtonBase)cmdClose).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdClose).ImeMode = (ImeMode)0;
		Button obj9 = cmdClose;
		location = new Point(646, 396);
		((Control)obj9).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdClose;
		size = new Size(65, 23);
		((Control)obj10).Size = size;
		((Control)cmdClose).TabIndex = 34;
		((ButtonBase)cmdClose).Text = "T&hoát";
		((ButtonBase)cmdClose).TextAlign = (ContentAlignment)64;
		bsDanhMuc.AllowNew = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(720, 429);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdSetRight);
		((Control)this).Controls.Add((Control)(object)dgvDM);
		((Control)this).Controls.Add((Control)(object)btnResetPass);
		((Control)this).Controls.Add((Control)(object)cmdDel);
		((Control)this).Controls.Add((Control)(object)cmdEdit);
		((Control)this).Controls.Add((Control)(object)cmdAdd);
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Control)this).Name = "frmSMUserInfo";
		((Form)this).Text = "frmDMView";
		((ISupportInitialize)dgvDM).EndInit();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void DataBinding()
	{
		try
		{
			bsDanhMuc.DataSource = f_oTblDM.DefaultView;
			((DataGridView)dgvDM).DataSource = bsDanhMuc;
			((Control)this).DataBindings.Add("Tag", (object)bsDanhMuc, "UserName");
			f_oCurrencyManager = bsDanhMuc.CurrencyManager;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void GetData()
	{
		f_oTblDM = MyController.GetUserInfo();
		DataColumn[] primaryKey = new DataColumn[1] { f_oTblDM.Columns["UserName"] };
		f_oTblDM.PrimaryKey = primaryKey;
		f_oTblDM.Columns["UserName"].DefaultValue = "";
		f_oTblDM.Columns["ldate"].DefaultValue = DateAndTime.Now;
		f_oTblDM.Columns["cdate"].DefaultValue = DateAndTime.Now;
		f_oTblDM.Columns["cuser"].DefaultValue = SystemInformations.UserName;
		f_oTblDM.Columns["luser"].DefaultValue = SystemInformations.UserName;
	}

	private void AddNew()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		frmSMUserInfoEdit frmSMUserInfoEdit2 = new frmSMUserInfoEdit();
		frmSMUserInfoEdit frmSMUserInfoEdit3 = frmSMUserInfoEdit2;
		frmSMUserInfoEdit3.EditMode = false;
		frmSMUserInfoEdit3.MyMenuInfo = MyMenuInfo;
		((Form)frmSMUserInfoEdit3).Text = ((Form)this).Text.Trim() + " - " + ADD_MODE_NAME;
		frmSMUserInfoEdit3.MyMenuID = MyMenuID;
		DataRow dataRow = f_oTblDM.NewRow();
		f_oTblDM.Rows.Add(dataRow);
		f_oCurrencyManager.Position = checked(((DataGridView)dgvDM).RowCount - 1);
		frmSMUserInfoEdit3.f_intBindingPosition = f_oCurrencyManager.Position;
		frmSMUserInfoEdit3.RowToEdit = dataRow;
		((Form)frmSMUserInfoEdit3).ShowDialog();
		if (frmSMUserInfoEdit2.Success)
		{
			f_oTblDM.AcceptChanges();
		}
		else
		{
			f_oTblDM.RejectChanges();
		}
		frmSMUserInfoEdit3 = null;
		((Component)(object)frmSMUserInfoEdit2).Dispose();
	}

	private void Edit()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		frmSMUserInfoEdit frmSMUserInfoEdit2 = new frmSMUserInfoEdit();
		frmSMUserInfoEdit frmSMUserInfoEdit3 = frmSMUserInfoEdit2;
		frmSMUserInfoEdit3.EditMode = true;
		frmSMUserInfoEdit3.RowToEdit = f_oTblDM.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index].Row;
		frmSMUserInfoEdit3.MyMenuInfo = MyMenuInfo;
		((Form)frmSMUserInfoEdit3).Text = ((Form)this).Text.Trim() + " - " + EDIT_MODE_NAME;
		frmSMUserInfoEdit3.MyMenuID = MyMenuID;
		frmSMUserInfoEdit3.f_intBindingPosition = f_oCurrencyManager.Position;
		((Form)frmSMUserInfoEdit3).ShowDialog();
		if (frmSMUserInfoEdit3.Success)
		{
			f_oTblDM.AcceptChanges();
		}
		else
		{
			f_oTblDM.RejectChanges();
		}
		frmSMUserInfoEdit3 = null;
		((Component)(object)frmSMUserInfoEdit2).Dispose();
	}

	private void Delete()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index != -1 && (int)CMessageBox.Show(50003, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)256) != 7)
		{
			DataRowView dataRowView = f_oTblDM.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index];
			if (MyController.DeleteUserInfo(Conversions.ToString(dataRowView["UserName"])))
			{
				dataRowView.Delete();
				f_oTblDM.AcceptChanges();
			}
		}
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		Keys val = (Keys)(((Message)(ref msg)).WParam.ToInt32() & 0xFFFF);
		if (((Message)(ref msg)).Msg == 256)
		{
			if ((int)val == 115)
			{
				cmdAdd_Click(cmdAdd, new EventArgs());
				return false;
			}
			if (f_oTblDM != null && f_oTblDM.Rows.Count < 1)
			{
				return ((Form)this).ProcessCmdKey(ref msg, keyData);
			}
			if ((int)val == 114)
			{
				cmdEdit_Click(cmdEdit, new EventArgs());
				return false;
			}
			if ((int)val == 119)
			{
				cmdDel_Click(cmdDel, new EventArgs());
				return false;
			}
		}
		bool result = default(bool);
		return result;
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

	public override void Refresh()
	{
		((Control)this).Refresh();
		if (((DataGridView)dgvDM).RowCount == 0)
		{
			((Control)cmdEdit).Enabled = false;
			((Control)cmdDel).Enabled = false;
		}
		else
		{
			((Control)cmdEdit).Enabled = true;
			((Control)cmdDel).Enabled = true;
		}
	}

	private void frmDMView_Load(object sender, EventArgs e)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)(object)this).DesignMode)
		{
			try
			{
				f_blnIsLoading = true;
				((Form)this).Text = MyMenuInfo.bar;
				string myMenuID = base.MyMenuID;
				ref bool blnViewRight = ref f_blnViewRight;
				ref bool blnInsertRight = ref f_blnInsertRight;
				ref bool blnUpdateRight = ref f_blnUpdateRight;
				ref bool blnDeleteRight = ref f_blnDeleteRight;
				int iLimitedPrint = 0;
				Commons.GetRights(myMenuID, ref blnViewRight, ref blnInsertRight, ref blnUpdateRight, ref blnDeleteRight, ref iLimitedPrint);
				GetData();
				DataBinding();
				f_blnIsLoading = false;
				((Control)cmdAdd).Select();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				CMessageBox.Show(ex2.Message);
				Helper.ProcessError(ex2);
				ProjectData.ClearProjectError();
			}
			((DataGridView)dgvDM).BackgroundColor = ClientConfiguration.DM_BakgroundColor;
			((DataGridView)dgvDM).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
			Refresh();
		}
	}

	private void cmdAdd_Click(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!f_blnInsertRight)
		{
			CMessageBox.Show(50005, SystemInformations.ProductFullName, (MessageBoxButtons)0);
			return;
		}
		AddNew();
		Refresh();
	}

	private void cmdEdit_Click(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!f_blnUpdateRight)
		{
			CMessageBox.Show(50005, SystemInformations.ProductFullName, (MessageBoxButtons)0);
		}
		else
		{
			Edit();
		}
	}

	private void cmdDel_Click(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!f_blnDeleteRight)
		{
			CMessageBox.Show(50005, SystemInformations.ProductFullName, (MessageBoxButtons)0);
			return;
		}
		Delete();
		Refresh();
	}

	private void cmdClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void frmDMView_Resize(object sender, EventArgs e)
	{
		f_blnIsUserSizing = true;
	}

	private void cmdSetRight_Click(object sender, EventArgs e)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		if (((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index >= 0)
		{
			if (Operators.ConditionalCompareObjectEqual(f_oTblDM.Rows.Find(SystemInformations.UserName)["grand"], (object)false, false))
			{
				CMessageBox.Show(50005);
				return;
			}
			frmSmSetRights frmSmSetRights2 = new frmSmSetRights();
			((Form)frmSmSetRights2).Text = ((ButtonBase)cmdSetRight).Text.Replace("&", "");
			frmSmSetRights2.f_strUserName = f_oTblDM.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["UserName"].ToString().Trim();
			frmSmSetRights2.f_strGrandRightUserName = SystemInformations.UserName;
			frmSmSetRights2.f_bIsAdmin = Conversions.ToBoolean(f_oTblDM.Rows.Find(SystemInformations.UserName)["isAdmin"]);
			frmSmSetRights2.f_CurrentUserIsAdmin = Conversions.ToBoolean(f_oTblDM.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["isAdmin"]);
			((Form)frmSmSetRights2).ShowDialog();
		}
	}

	private void btnResetPass_Click(object sender, EventArgs e)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!f_blnUpdateRight)
			{
				CMessageBox.Show(50005, SystemInformations.ProductFullName, (MessageBoxButtons)0);
				return;
			}
			frmSMUserResetPassword frmSMUserResetPassword2 = new frmSMUserResetPassword();
			frmSMUserResetPassword2.sUserName = f_oTblDM.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["UserName"].ToString().Trim();
			((Form)frmSMUserResetPassword2).Text = ((ButtonBase)btnResetPass).Text.Replace("&", "");
			((Form)frmSMUserResetPassword2).ShowDialog();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void PhanQuyenCtyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(f_oTblDM.Rows.Find(SystemInformations.UserName)["grand"], (object)false, false))
		{
			CMessageBox.Show(50005);
			return;
		}
		frmSmSetRightsCompany frmSmSetRightsCompany2 = new frmSmSetRightsCompany();
		frmSmSetRightsCompany2.f_strUserName = f_oTblDM.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["UserName"].ToString().Trim();
		frmSmSetRightsCompany2.f_strFullUserName = f_oTblDM.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["FullName"].ToString().Trim();
		frmSmSetRightsCompany2.f_strGrandCompanyRight = SystemInformations.UserName;
		frmSmSetRightsCompany2.f_bIsAdmin = Conversions.ToBoolean(f_oTblDM.Rows.Find(SystemInformations.UserName)["isAdmin"]);
		((Form)frmSmSetRightsCompany2).ShowDialog();
	}

	private void frmSMUserInfo_Shown(object sender, EventArgs e)
	{
		EDIT_MODE_NAME = Strings.Replace(((ButtonBase)cmdEdit).Text.Trim(), "&", "", 1, -1, (CompareMethod)0);
		ADD_MODE_NAME = Strings.Replace(((ButtonBase)cmdAdd).Text.Trim(), "&", "", 1, -1, (CompareMethod)0);
	}
}
