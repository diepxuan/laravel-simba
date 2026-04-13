using System;
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
public class frmSIGroupInfo : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("cmdSetRight")]
	private SplitButton _cmdSetRight;

	[AccessedThroughProperty("cmbSetRight")]
	private SplitButton _cmbSetRight;

	[AccessedThroughProperty("dgvDM")]
	private AsDataGridView _dgvDM;

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

	[AccessedThroughProperty("GroupName")]
	private DataGridViewTextBoxColumn _GroupName;

	[AccessedThroughProperty("FullName")]
	private DataGridViewTextBoxColumn _FullName;

	[AccessedThroughProperty("isAdmin")]
	private DataGridViewCheckBoxColumn _isAdmin;

	[AccessedThroughProperty("ksd")]
	private DataGridViewCheckBoxColumn _ksd;

	private iSiGroupInfo dao;

	public string EDIT_MODE_NAME;

	public string ADD_MODE_NAME;

	private CurrencyManager f_oCurrencyManager;

	private MenuInformation f_oMenuInfo;

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

	internal virtual SplitButton cmdSetRight
	{
		get
		{
			return _cmdSetRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cmdSetRight = value;
		}
	}

	internal virtual SplitButton cmbSetRight
	{
		get
		{
			return _cmbSetRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmbSetRight_Click;
			if (_cmbSetRight != null)
			{
				((Control)_cmbSetRight).Click -= eventHandler;
			}
			_cmbSetRight = value;
			if (_cmbSetRight != null)
			{
				((Control)_cmbSetRight).Click += eventHandler;
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
			_dgvDM = value;
		}
	}

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

	internal virtual DataGridViewTextBoxColumn GroupName
	{
		get
		{
			return _GroupName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupName = value;
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

	internal virtual DataGridViewCheckBoxColumn ksd
	{
		get
		{
			return _ksd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ksd = value;
		}
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

	public frmSIGroupInfo(string menuid)
		: base(menuid)
	{
		((Form)this).Shown += frmSIGroupInfo_Shown;
		((Form)this).Load += frmSIGroupInfo_Load;
		EDIT_MODE_NAME = " - Sửa";
		ADD_MODE_NAME = " - Thêm mới";
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
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
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
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected O, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected O, but got Unknown
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSIGroupInfo));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		cmdSetRight = new SplitButton();
		cmbSetRight = new SplitButton();
		dgvDM = new AsDataGridView();
		GroupName = new DataGridViewTextBoxColumn();
		FullName = new DataGridViewTextBoxColumn();
		isAdmin = new DataGridViewCheckBoxColumn();
		ksd = new DataGridViewCheckBoxColumn();
		cmdDel = new Button();
		cmdEdit = new Button();
		cmdAdd = new Button();
		cmdClose = new Button();
		bsDanhMuc = new BindingSource(components);
		((ISupportInitialize)dgvDM).BeginInit();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		cmdSetRight.EnableSplit = true;
		((ButtonBase)cmdSetRight).Image = (Image)componentResourceManager.GetObject("cmdSetRight.Image");
		cmdSetRight.ImageHeight = 4;
		cmdSetRight.ImageWidth = 7;
		SplitButton splitButton = cmdSetRight;
		Point location = new Point(0, 0);
		((Control)splitButton).Location = location;
		((Control)cmdSetRight).Name = "cmdSetRight";
		SplitButton splitButton2 = cmdSetRight;
		Size size = new Size(75, 23);
		((Control)splitButton2).Size = size;
		cmdSetRight.SplitWidth = 15;
		((Control)cmdSetRight).TabIndex = 0;
		((Control)cmbSetRight).Anchor = (AnchorStyles)6;
		cmbSetRight.EnableSplit = false;
		((ButtonBase)cmbSetRight).Image = (Image)(object)Resources.imgLogedUser;
		((ButtonBase)cmbSetRight).ImageAlign = (ContentAlignment)16;
		cmbSetRight.ImageHeight = 4;
		cmbSetRight.ImageWidth = 7;
		SplitButton splitButton3 = cmbSetRight;
		location = new Point(12, 360);
		((Control)splitButton3).Location = location;
		((Control)cmbSetRight).Name = "cmbSetRight";
		SplitButton splitButton4 = cmbSetRight;
		size = new Size(86, 23);
		((Control)splitButton4).Size = size;
		cmbSetRight.SplitWidth = 15;
		((Control)cmbSetRight).TabIndex = 46;
		((ButtonBase)cmbSetRight).Text = "&Phân quyền";
		((ButtonBase)cmbSetRight).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmbSetRight).UseVisualStyleBackColor = true;
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
			(DataGridViewColumn)GroupName,
			(DataGridViewColumn)FullName,
			(DataGridViewColumn)isAdmin,
			(DataGridViewColumn)ksd
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
		location = new Point(2, 2);
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
		size = new Size(690, 352);
		((Control)asDataGridView2).Size = size;
		((Control)dgvDM).TabIndex = 45;
		((DataGridViewColumn)GroupName).DataPropertyName = "GroupName";
		((DataGridViewColumn)GroupName).HeaderText = "Tên nhóm";
		((DataGridViewColumn)GroupName).Name = "GroupName";
		((DataGridViewColumn)GroupName).ReadOnly = true;
		((DataGridViewColumn)GroupName).Width = 150;
		((DataGridViewColumn)FullName).DataPropertyName = "fullname";
		((DataGridViewColumn)FullName).HeaderText = "Tên đầy đủ";
		((DataGridViewColumn)FullName).Name = "FullName";
		((DataGridViewColumn)FullName).ReadOnly = true;
		((DataGridViewColumn)FullName).Width = 300;
		((DataGridViewColumn)isAdmin).DataPropertyName = "grand";
		((DataGridViewColumn)isAdmin).HeaderText = "Phân lại quyền";
		((DataGridViewColumn)isAdmin).Name = "isAdmin";
		((DataGridViewColumn)ksd).DataPropertyName = "ksd";
		((DataGridViewColumn)ksd).HeaderText = "KSD";
		((DataGridViewColumn)ksd).Name = "ksd";
		((Control)cmdDel).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdDel).Image = (Image)componentResourceManager.GetObject("cmdDel.Image");
		((ButtonBase)cmdDel).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdDel).ImeMode = (ImeMode)0;
		Button obj = cmdDel;
		location = new Point(548, 360);
		((Control)obj).Location = location;
		((Control)cmdDel).Name = "cmdDel";
		((Control)cmdDel).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdDel;
		size = new Size(64, 23);
		((Control)obj2).Size = size;
		((Control)cmdDel).TabIndex = 43;
		((ButtonBase)cmdDel).Text = "&Xoá";
		((ButtonBase)cmdDel).TextAlign = (ContentAlignment)64;
		((Control)cmdEdit).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdEdit).Image = (Image)componentResourceManager.GetObject("cmdEdit.Image");
		((ButtonBase)cmdEdit).ImageAlign = (ContentAlignment)256;
		((ButtonBase)cmdEdit).ImeMode = (ImeMode)0;
		Button obj3 = cmdEdit;
		location = new Point(478, 360);
		((Control)obj3).Location = location;
		((Control)cmdEdit).Name = "cmdEdit";
		((Control)cmdEdit).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdEdit;
		size = new Size(64, 23);
		((Control)obj4).Size = size;
		((Control)cmdEdit).TabIndex = 42;
		((ButtonBase)cmdEdit).Text = "&Sửa";
		((ButtonBase)cmdEdit).TextAlign = (ContentAlignment)64;
		((Control)cmdAdd).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdAdd).Image = (Image)componentResourceManager.GetObject("cmdAdd.Image");
		((ButtonBase)cmdAdd).ImageAlign = (ContentAlignment)256;
		((ButtonBase)cmdAdd).ImeMode = (ImeMode)0;
		Button obj5 = cmdAdd;
		location = new Point(408, 360);
		((Control)obj5).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		((Control)cmdAdd).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdAdd;
		size = new Size(64, 23);
		((Control)obj6).Size = size;
		((Control)cmdAdd).TabIndex = 41;
		((ButtonBase)cmdAdd).Text = "&Mới";
		((ButtonBase)cmdAdd).TextAlign = (ContentAlignment)64;
		((Control)cmdClose).Anchor = (AnchorStyles)10;
		cmdClose.DialogResult = (DialogResult)2;
		((ButtonBase)cmdClose).Image = (Image)componentResourceManager.GetObject("cmdClose.Image");
		((ButtonBase)cmdClose).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdClose).ImeMode = (ImeMode)0;
		Button obj7 = cmdClose;
		location = new Point(616, 360);
		((Control)obj7).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdClose;
		size = new Size(65, 23);
		((Control)obj8).Size = size;
		((Control)cmdClose).TabIndex = 44;
		((ButtonBase)cmdClose).Text = "T&hoát";
		((ButtonBase)cmdClose).TextAlign = (ContentAlignment)64;
		bsDanhMuc.AllowNew = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(693, 395);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmbSetRight);
		((Control)this).Controls.Add((Control)(object)dgvDM);
		((Control)this).Controls.Add((Control)(object)cmdDel);
		((Control)this).Controls.Add((Control)(object)cmdEdit);
		((Control)this).Controls.Add((Control)(object)cmdAdd);
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Control)this).Name = "frmSIGroupInfo";
		((ISupportInitialize)dgvDM).EndInit();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmSIGroupInfo_Load(object sender, EventArgs e)
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

	private void cmbSetRight_Click(object sender, EventArgs e)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index >= 0)
		{
			frmSiSetRights frmSiSetRights2 = new frmSiSetRights();
			frmSiSetRights2.f_strGroupName = f_oTblDM.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["GroupName"].ToString().Trim();
			((Form)frmSiSetRights2).ShowDialog();
		}
	}

	protected virtual void GetData()
	{
		dao = (iSiGroupInfo)DAOFactory.CreateDAOInstance("SiGroupInfoDao", "SIGroupInfo", a_blnIsSysDB: true);
		f_oTblDM = dao.GetGroupInfo("");
		dao.Destroy();
		f_oTblDM.Columns["ldate"].DefaultValue = DateAndTime.Now;
		f_oTblDM.Columns["cdate"].DefaultValue = DateAndTime.Now;
		f_oTblDM.Columns["cuser"].DefaultValue = SystemInformations.UserName;
		f_oTblDM.Columns["luser"].DefaultValue = SystemInformations.UserName;
	}

	protected virtual void AddNew()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		frmSIGroupInfoEdit frmSIGroupInfoEdit2 = new frmSIGroupInfoEdit();
		frmSIGroupInfoEdit frmSIGroupInfoEdit3 = frmSIGroupInfoEdit2;
		frmSIGroupInfoEdit3.EditMode = false;
		frmSIGroupInfoEdit3.MyMenuInfo = MyMenuInfo;
		((Form)frmSIGroupInfoEdit3).Text = ((Form)this).Text.Trim() + " - " + ADD_MODE_NAME;
		frmSIGroupInfoEdit3.MyMenuID = MyMenuID;
		DataRow dataRow = f_oTblDM.NewRow();
		f_oTblDM.Rows.Add(dataRow);
		f_oCurrencyManager.Position = checked(((DataGridView)dgvDM).RowCount - 1);
		frmSIGroupInfoEdit3.f_intBindingPosition = f_oCurrencyManager.Position;
		frmSIGroupInfoEdit3.RowToEdit = dataRow;
		((Form)frmSIGroupInfoEdit3).ShowDialog();
		if (frmSIGroupInfoEdit2.Success)
		{
			f_oTblDM.AcceptChanges();
		}
		else
		{
			f_oTblDM.RejectChanges();
		}
		frmSIGroupInfoEdit3 = null;
		((Component)(object)frmSIGroupInfoEdit2).Dispose();
	}

	protected virtual void Edit()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		frmSIGroupInfoEdit frmSIGroupInfoEdit2 = new frmSIGroupInfoEdit();
		frmSIGroupInfoEdit frmSIGroupInfoEdit3 = frmSIGroupInfoEdit2;
		frmSIGroupInfoEdit3.EditMode = true;
		frmSIGroupInfoEdit3.RowToEdit = f_oTblDM.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index].Row;
		frmSIGroupInfoEdit3.MyMenuInfo = MyMenuInfo;
		((Form)frmSIGroupInfoEdit3).Text = ((Form)this).Text.Trim() + " - " + EDIT_MODE_NAME;
		frmSIGroupInfoEdit3.MyMenuID = MyMenuID;
		frmSIGroupInfoEdit3.f_intBindingPosition = f_oCurrencyManager.Position;
		((Form)frmSIGroupInfoEdit3).ShowDialog();
		if (frmSIGroupInfoEdit3.Success)
		{
			f_oTblDM.AcceptChanges();
		}
		else
		{
			f_oTblDM.RejectChanges();
		}
		frmSIGroupInfoEdit3 = null;
		((Component)(object)frmSIGroupInfoEdit2).Dispose();
	}

	protected virtual void Delete()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index != -1 && (int)CMessageBox.Show(50003, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)256) != 7)
		{
			DataRowView dataRowView = f_oTblDM.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index];
			dao = (iSiGroupInfo)DAOFactory.CreateDAOInstance("SiGroupInfoDao", "SIGroupInfo", a_blnIsSysDB: true);
			if (dao.DeleteGroupInfo(Conversions.ToString(dataRowView["GroupName"])) == 0)
			{
				dataRowView.Delete();
				f_oTblDM.AcceptChanges();
			}
			dao.Destroy();
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

	private void DataBinding()
	{
		try
		{
			bsDanhMuc.DataSource = f_oTblDM.DefaultView;
			((DataGridView)dgvDM).DataSource = bsDanhMuc;
			((Control)this).DataBindings.Add("Tag", (object)bsDanhMuc, "GroupName");
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

	private void frmSIGroupInfo_Shown(object sender, EventArgs e)
	{
		EDIT_MODE_NAME = Strings.Replace(((ButtonBase)cmdEdit).Text.Trim(), "&", "", 1, -1, (CompareMethod)0);
		ADD_MODE_NAME = Strings.Replace(((ButtonBase)cmdAdd).Text.Trim(), "&", "", 1, -1, (CompareMethod)0);
	}
}
