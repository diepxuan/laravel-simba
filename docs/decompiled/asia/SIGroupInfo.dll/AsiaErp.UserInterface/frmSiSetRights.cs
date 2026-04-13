using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSiSetRights : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("cboSubMenu")]
	private ComboBox _cboSubMenu;

	[AccessedThroughProperty("cboMainMenu")]
	private ComboBox _cboMainMenu;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("chkAllDel")]
	private CheckBox _chkAllDel;

	[AccessedThroughProperty("chkAllEdit")]
	private CheckBox _chkAllEdit;

	[AccessedThroughProperty("chkAllAdd")]
	private CheckBox _chkAllAdd;

	[AccessedThroughProperty("chkAllView")]
	private CheckBox _chkAllView;

	[AccessedThroughProperty("dgvDM")]
	private AsDataGridView _dgvDM;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

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

	[AccessedThroughProperty("cmdSave")]
	private Button _cmdSave;

	private DataTable f_oTblGroupRight;

	private DataTable f_oTblMenu;

	private DataTable f_oTblSubMenu;

	private bool f_isLoading;

	internal string f_strGroupName;

	private iSiGroupInfo dao;

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

	public frmSiSetRights()
	{
		((Form)this).Load += frmSmSetRights_Load;
		f_isLoading = true;
		f_strGroupName = "";
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected O, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSiSetRights));
		cboSubMenu = new ComboBox();
		cboMainMenu = new ComboBox();
		Label1 = new Label();
		chkAllDel = new CheckBox();
		chkAllEdit = new CheckBox();
		chkAllAdd = new CheckBox();
		chkAllView = new CheckBox();
		dgvDM = new AsDataGridView();
		UserName = new DataGridViewTextBoxColumn();
		dgvcViewRight = new DataGridViewCheckBoxColumn();
		dgvcAddRight = new DataGridViewCheckBoxColumn();
		dgvcEditRight = new DataGridViewCheckBoxColumn();
		dgvcDeleteRight = new DataGridViewCheckBoxColumn();
		cmdClose = new Button();
		cmdSave = new Button();
		((ISupportInitialize)dgvDM).BeginInit();
		((Control)this).SuspendLayout();
		cboSubMenu.DropDownStyle = (ComboBoxStyle)2;
		((Control)cboSubMenu).Font = new Font("Microsoft Sans Serif", 10f);
		((Control)cboSubMenu).ImeMode = (ImeMode)2;
		cboSubMenu.ItemHeight = 16;
		ComboBox obj = cboSubMenu;
		Point location = new Point(84, 40);
		((Control)obj).Location = location;
		((Control)cboSubMenu).Name = "cboSubMenu";
		ComboBox obj2 = cboSubMenu;
		Size size = new Size(440, 24);
		((Control)obj2).Size = size;
		((Control)cboSubMenu).TabIndex = 7;
		cboMainMenu.DropDownStyle = (ComboBoxStyle)2;
		((Control)cboMainMenu).Font = new Font("Microsoft Sans Serif", 10f);
		((Control)cboMainMenu).ImeMode = (ImeMode)2;
		cboMainMenu.ItemHeight = 16;
		ComboBox obj3 = cboMainMenu;
		location = new Point(84, 12);
		((Control)obj3).Location = location;
		((Control)cboMainMenu).Name = "cboMainMenu";
		ComboBox obj4 = cboMainMenu;
		size = new Size(440, 24);
		((Control)obj4).Size = size;
		((Control)cboMainMenu).TabIndex = 6;
		Label1.ImeMode = (ImeMode)0;
		Label label = Label1;
		location = new Point(22, 15);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(73, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 8;
		Label1.Text = "Phân hệ";
		((Control)chkAllDel).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllDel).AutoSize = true;
		((ButtonBase)chkAllDel).ImeMode = (ImeMode)0;
		CheckBox obj5 = chkAllDel;
		location = new Point(580, 447);
		((Control)obj5).Location = location;
		((Control)chkAllDel).Name = "chkAllDel";
		CheckBox obj6 = chkAllDel;
		size = new Size(15, 14);
		((Control)obj6).Size = size;
		((Control)chkAllDel).TabIndex = 18;
		((Control)chkAllEdit).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllEdit).AutoSize = true;
		((ButtonBase)chkAllEdit).ImeMode = (ImeMode)0;
		CheckBox obj7 = chkAllEdit;
		location = new Point(540, 447);
		((Control)obj7).Location = location;
		((Control)chkAllEdit).Name = "chkAllEdit";
		CheckBox obj8 = chkAllEdit;
		size = new Size(15, 14);
		((Control)obj8).Size = size;
		((Control)chkAllEdit).TabIndex = 17;
		((Control)chkAllAdd).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllAdd).AutoSize = true;
		((ButtonBase)chkAllAdd).ImeMode = (ImeMode)0;
		CheckBox obj9 = chkAllAdd;
		location = new Point(500, 447);
		((Control)obj9).Location = location;
		((Control)chkAllAdd).Name = "chkAllAdd";
		CheckBox obj10 = chkAllAdd;
		size = new Size(15, 14);
		((Control)obj10).Size = size;
		((Control)chkAllAdd).TabIndex = 16;
		((Control)chkAllView).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllView).AutoSize = true;
		((ButtonBase)chkAllView).ImeMode = (ImeMode)0;
		CheckBox obj11 = chkAllView;
		location = new Point(460, 447);
		((Control)obj11).Location = location;
		((Control)chkAllView).Name = "chkAllView";
		CheckBox obj12 = chkAllView;
		size = new Size(15, 14);
		((Control)obj12).Size = size;
		((Control)chkAllView).TabIndex = 15;
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
		((DataGridView)dgvDM).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)UserName,
			(DataGridViewColumn)dgvcViewRight,
			(DataGridViewColumn)dgvcAddRight,
			(DataGridViewColumn)dgvcEditRight,
			(DataGridViewColumn)dgvcDeleteRight
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
		location = new Point(12, 84);
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
		size = new Size(618, 355);
		((Control)asDataGridView2).Size = size;
		((Control)dgvDM).TabIndex = 40;
		((DataGridViewColumn)UserName).DataPropertyName = "bar";
		((DataGridViewColumn)UserName).Frozen = true;
		((DataGridViewColumn)UserName).HeaderText = "Chức năng";
		((DataGridViewColumn)UserName).Name = "UserName";
		((DataGridViewColumn)UserName).ReadOnly = true;
		((DataGridViewColumn)UserName).Width = 400;
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
		((Control)cmdClose).Anchor = (AnchorStyles)6;
		cmdClose.DialogResult = (DialogResult)2;
		((ButtonBase)cmdClose).Image = (Image)componentResourceManager.GetObject("cmdClose.Image");
		((ButtonBase)cmdClose).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdClose).ImeMode = (ImeMode)0;
		Button obj13 = cmdClose;
		location = new Point(92, 448);
		((Control)obj13).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj14 = cmdClose;
		size = new Size(65, 23);
		((Control)obj14).Size = size;
		((Control)cmdClose).TabIndex = 41;
		((ButtonBase)cmdClose).Text = "T&hoát";
		((ButtonBase)cmdClose).TextAlign = (ContentAlignment)64;
		((Control)cmdSave).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdSave).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdSave).ImeMode = (ImeMode)0;
		Button obj15 = cmdSave;
		location = new Point(11, 448);
		((Control)obj15).Location = location;
		((Control)cmdSave).Name = "cmdSave";
		Button obj16 = cmdSave;
		size = new Size(75, 23);
		((Control)obj16).Size = size;
		((Control)cmdSave).TabIndex = 42;
		((ButtonBase)cmdSave).Text = "&Lưu";
		((ButtonBase)cmdSave).TextAlign = (ContentAlignment)64;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(642, 479);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdSave);
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Control)this).Controls.Add((Control)(object)dgvDM);
		((Control)this).Controls.Add((Control)(object)chkAllDel);
		((Control)this).Controls.Add((Control)(object)chkAllEdit);
		((Control)this).Controls.Add((Control)(object)chkAllAdd);
		((Control)this).Controls.Add((Control)(object)chkAllView);
		((Control)this).Controls.Add((Control)(object)cboSubMenu);
		((Control)this).Controls.Add((Control)(object)cboMainMenu);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Name = "frmSiSetRights";
		((Form)this).Text = "Phân quyền";
		((ISupportInitialize)dgvDM).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmSmSetRights_Load(object sender, EventArgs e)
	{
		GetData();
	}

	private void GetData()
	{
		dao = (iSiGroupInfo)DAOFactory.CreateDAOInstance("SiGroupInfoDao", "SIGroupInfo", a_blnIsSysDB: true);
		f_oTblGroupRight = dao.GetAllGroupRights(f_strGroupName);
		((DataGridView)dgvDM).DataSource = f_oTblGroupRight;
		f_oTblMenu = dao.GetMenuBar();
		f_oTblSubMenu = dao.GetSubMenuBar();
		cboSubMenu.DataSource = f_oTblSubMenu.DefaultView;
		((ListControl)cboSubMenu).DisplayMember = "Bar";
		((ListControl)cboSubMenu).ValueMember = "MenuID";
		cboMainMenu.DataSource = f_oTblMenu.DefaultView;
		((ListControl)cboMainMenu).DisplayMember = "Bar";
		((ListControl)cboMainMenu).ValueMember = "MenuID";
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
		f_oTblGroupRight.DefaultView.RowFilter = text;
	}

	private void cboSubMenu_SelectedIndexChanged(object sender, EventArgs e)
	{
		((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvDM).DataSource)].EndCurrentEdit();
		string rowFilter = "SUBSTRING(MenuID,1,5) = '" + Conversions.ToString(NewLateBinding.LateIndexGet(cboSubMenu.SelectedItem, new object[1] { "MenuID" }, (string[])null)).Substring(0, 5) + "'";
		f_oTblGroupRight.DefaultView.RowFilter = rowFilter;
	}

	private void cmdSave_Click(object sender, EventArgs e)
	{
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvDM).DataSource)].EndCurrentEdit();
		if (f_oTblGroupRight.GetChanges(DataRowState.Modified) == null)
		{
			return;
		}
		try
		{
			foreach (DataRow row in f_oTblGroupRight.GetChanges(DataRowState.Modified).Rows)
			{
				dao = (iSiGroupInfo)DAOFactory.CreateDAOInstance("SiGroupInfoDao", "SIGroupInfo", a_blnIsSysDB: true);
				dao.DeleteGroupRight(f_strGroupName, Conversions.ToString(row["MenuID"]));
				if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(row["ViewRight"], (object)true, false), Operators.CompareObjectEqual(row["InsertRight"], (object)true, false)), Operators.CompareObjectEqual(row["UpdateRight"], (object)true, false)), Operators.CompareObjectEqual(row["DeleteRight"], (object)true, false))))
				{
					int num = dao.InsertGroupRight(f_strGroupName, Conversions.ToString(row["MenuID"]), ViewRight: true, Conversions.ToBoolean(row["InsertRight"]), Conversions.ToBoolean(row["UpdateRight"]), Conversions.ToBoolean(row["DeleteRight"]));
					row["ViewRight"] = true;
				}
				dao.Destroy();
			}
			CMessageBox.Show(50015);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
	}

	private void chkAllView_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = chkAllView.Checked;
		foreach (DataRowView item in ((DataTable)((DataGridView)dgvDM).DataSource).DefaultView)
		{
			item["ViewRight"] = flag;
		}
		if (((DataGridView)dgvDM).CurrentCell != null)
		{
			((DataGridView)dgvDM).InvalidateRow(((DataGridView)dgvDM).CurrentCell.RowIndex);
		}
	}

	private void chkAllAdd_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = chkAllAdd.Checked;
		foreach (DataRowView item in f_oTblGroupRight.DefaultView)
		{
			item["InsertRight"] = flag;
		}
		if (((DataGridView)dgvDM).CurrentCell != null)
		{
			((DataGridView)dgvDM).InvalidateRow(((DataGridView)dgvDM).CurrentCell.RowIndex);
		}
	}

	private void chkAllEdit_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = chkAllEdit.Checked;
		foreach (DataRowView item in f_oTblGroupRight.DefaultView)
		{
			item["UpdateRight"] = flag;
		}
		if (((DataGridView)dgvDM).CurrentCell != null)
		{
			((DataGridView)dgvDM).InvalidateRow(((DataGridView)dgvDM).CurrentCell.RowIndex);
		}
	}

	private void chkAllDel_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = chkAllDel.Checked;
		foreach (DataRowView item in f_oTblGroupRight.DefaultView)
		{
			item["DeleteRight"] = flag;
		}
		if (((DataGridView)dgvDM).CurrentCell != null)
		{
			((DataGridView)dgvDM).InvalidateRow(((DataGridView)dgvDM).CurrentCell.RowIndex);
		}
	}

	private void cmdClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
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
}
