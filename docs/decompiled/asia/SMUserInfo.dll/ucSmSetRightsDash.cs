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

[DesignerGenerated]
public class ucSmSetRightsDash : UserControl
{
	private IContainer components;

	[AccessedThroughProperty("dgvDM_Dash")]
	private AsDataGridView _dgvDM_Dash;

	[AccessedThroughProperty("chkAllDel")]
	private CheckBox _chkAllDel;

	[AccessedThroughProperty("chkAllEdit")]
	private CheckBox _chkAllEdit;

	[AccessedThroughProperty("chkAllAdd")]
	private CheckBox _chkAllAdd;

	[AccessedThroughProperty("chkAllView")]
	private CheckBox _chkAllView;

	[AccessedThroughProperty("bsDashRight")]
	private BindingSource _bsDashRight;

	[AccessedThroughProperty("Description")]
	private DataGridViewTextBoxColumn _Description;

	[AccessedThroughProperty("dgvcDBViewRight")]
	private DataGridViewCheckBoxColumn _dgvcDBViewRight;

	[AccessedThroughProperty("dgvcDBAddRight")]
	private DataGridViewCheckBoxColumn _dgvcDBAddRight;

	[AccessedThroughProperty("dgvcDBEditRight")]
	private DataGridViewCheckBoxColumn _dgvcDBEditRight;

	[AccessedThroughProperty("dgvcDBDeleteRight")]
	private DataGridViewCheckBoxColumn _dgvcDBDeleteRight;

	private DataTable f_oTblUserRight;

	private DataTable f_oTblGrandRightUserName;

	private DataTable f_oTblMenu;

	private DataTable f_oTblSubMenu;

	private bool f_isLoading;

	private SMUserInfoController f_oController;

	private string f_strUserName;

	private string f_strGrandRightUserName;

	private bool f_bIsAdmin;

	internal virtual AsDataGridView dgvDM_Dash
	{
		get
		{
			return _dgvDM_Dash;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvDM_Dash = value;
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

	internal virtual DataGridViewTextBoxColumn Description
	{
		get
		{
			return _Description;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Description = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcDBViewRight
	{
		get
		{
			return _dgvcDBViewRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcDBViewRight = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcDBAddRight
	{
		get
		{
			return _dgvcDBAddRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcDBAddRight = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcDBEditRight
	{
		get
		{
			return _dgvcDBEditRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcDBEditRight = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcDBDeleteRight
	{
		get
		{
			return _dgvcDBDeleteRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcDBDeleteRight = value;
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

	public string UserName
	{
		get
		{
			return f_strUserName;
		}
		set
		{
			f_strUserName = value;
		}
	}

	public string GrandRightUserName
	{
		get
		{
			return f_strGrandRightUserName;
		}
		set
		{
			f_strGrandRightUserName = value;
		}
	}

	public bool IsAdmin
	{
		get
		{
			return f_bIsAdmin;
		}
		set
		{
			f_bIsAdmin = value;
		}
	}

	public DataTable MySourceUserRight
	{
		get
		{
			return f_oTblUserRight;
		}
		set
		{
			f_oTblUserRight = value;
		}
	}

	public DataTable MySourceGrandRight
	{
		get
		{
			return f_oTblGrandRightUserName;
		}
		set
		{
			f_oTblGrandRightUserName = value;
		}
	}

	public BindingSource MyBsDashRight
	{
		get
		{
			return bsDashRight;
		}
		set
		{
			bsDashRight = value;
		}
	}

	public ucSmSetRightsDash()
	{
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
			((ContainerControl)this).Dispose(disposing);
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
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
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
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		dgvDM_Dash = new AsDataGridView();
		chkAllDel = new CheckBox();
		chkAllEdit = new CheckBox();
		chkAllAdd = new CheckBox();
		chkAllView = new CheckBox();
		bsDashRight = new BindingSource(components);
		Description = new DataGridViewTextBoxColumn();
		dgvcDBViewRight = new DataGridViewCheckBoxColumn();
		dgvcDBAddRight = new DataGridViewCheckBoxColumn();
		dgvcDBEditRight = new DataGridViewCheckBoxColumn();
		dgvcDBDeleteRight = new DataGridViewCheckBoxColumn();
		((ISupportInitialize)dgvDM_Dash).BeginInit();
		((ISupportInitialize)bsDashRight).BeginInit();
		((Control)this).SuspendLayout();
		((DataGridView)dgvDM_Dash).AllowUserToAddRows = false;
		((DataGridView)dgvDM_Dash).AllowUserToDeleteRows = false;
		((DataGridView)dgvDM_Dash).AllowUserToResizeColumns = false;
		val.BackColor = Color.LightYellow;
		((DataGridView)dgvDM_Dash).AlternatingRowsDefaultCellStyle = val;
		((Control)dgvDM_Dash).Anchor = (AnchorStyles)15;
		((DataGridView)dgvDM_Dash).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvDM_Dash).BorderStyle = (BorderStyle)2;
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Control;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.WindowText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDM_Dash).ColumnHeadersDefaultCellStyle = val2;
		((DataGridView)dgvDM_Dash).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvDM_Dash).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)Description,
			(DataGridViewColumn)dgvcDBViewRight,
			(DataGridViewColumn)dgvcDBAddRight,
			(DataGridViewColumn)dgvcDBEditRight,
			(DataGridViewColumn)dgvcDBDeleteRight
		});
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = SystemColors.Window;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.ControlText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvDM_Dash).DefaultCellStyle = val3;
		dgvDM_Dash.DoubleBuffered = false;
		((DataGridView)dgvDM_Dash).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvDM_Dash).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvDM_Dash;
		Point location = new Point(3, 3);
		((Control)asDataGridView).Location = location;
		((Control)dgvDM_Dash).Name = "dgvDM_Dash";
		val4.Alignment = (DataGridViewContentAlignment)32;
		val4.BackColor = SystemColors.Control;
		val4.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val4.ForeColor = SystemColors.WindowText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDM_Dash).RowHeadersDefaultCellStyle = val4;
		((DataGridView)dgvDM_Dash).RowHeadersWidth = 35;
		dgvDM_Dash.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvDM_Dash).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvDM_Dash;
		Size size = new Size(407, 103);
		((Control)asDataGridView2).Size = size;
		((Control)dgvDM_Dash).TabIndex = 45;
		((Control)chkAllDel).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllDel).AutoSize = true;
		((ButtonBase)chkAllDel).ImeMode = (ImeMode)0;
		CheckBox obj = chkAllDel;
		location = new Point(473, 112);
		((Control)obj).Location = location;
		((Control)chkAllDel).Name = "chkAllDel";
		CheckBox obj2 = chkAllDel;
		size = new Size(15, 14);
		((Control)obj2).Size = size;
		((Control)chkAllDel).TabIndex = 44;
		((Control)chkAllDel).Visible = false;
		((Control)chkAllEdit).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllEdit).AutoSize = true;
		((ButtonBase)chkAllEdit).ImeMode = (ImeMode)0;
		CheckBox obj3 = chkAllEdit;
		location = new Point(433, 112);
		((Control)obj3).Location = location;
		((Control)chkAllEdit).Name = "chkAllEdit";
		CheckBox obj4 = chkAllEdit;
		size = new Size(15, 14);
		((Control)obj4).Size = size;
		((Control)chkAllEdit).TabIndex = 43;
		((Control)chkAllEdit).Visible = false;
		((Control)chkAllAdd).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllAdd).AutoSize = true;
		((ButtonBase)chkAllAdd).ImeMode = (ImeMode)0;
		CheckBox obj5 = chkAllAdd;
		location = new Point(393, 112);
		((Control)obj5).Location = location;
		((Control)chkAllAdd).Name = "chkAllAdd";
		CheckBox obj6 = chkAllAdd;
		size = new Size(15, 14);
		((Control)obj6).Size = size;
		((Control)chkAllAdd).TabIndex = 42;
		((Control)chkAllAdd).Visible = false;
		((Control)chkAllView).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllView).AutoSize = true;
		((ButtonBase)chkAllView).ImeMode = (ImeMode)0;
		CheckBox obj7 = chkAllView;
		location = new Point(353, 112);
		((Control)obj7).Location = location;
		((Control)chkAllView).Name = "chkAllView";
		CheckBox obj8 = chkAllView;
		size = new Size(15, 14);
		((Control)obj8).Size = size;
		((Control)chkAllView).TabIndex = 41;
		((DataGridViewColumn)Description).DataPropertyName = "Description";
		((DataGridViewColumn)Description).Frozen = true;
		((DataGridViewColumn)Description).HeaderText = "Chức năng";
		((DataGridViewColumn)Description).Name = "Description";
		((DataGridViewColumn)Description).ReadOnly = true;
		((DataGridViewColumn)Description).Width = 300;
		((DataGridViewColumn)dgvcDBViewRight).DataPropertyName = "viewright";
		((DataGridViewColumn)dgvcDBViewRight).HeaderText = "Xem";
		((DataGridViewColumn)dgvcDBViewRight).Name = "dgvcDBViewRight";
		((DataGridViewColumn)dgvcDBViewRight).Width = 40;
		((DataGridViewColumn)dgvcDBAddRight).DataPropertyName = "InsertRight";
		((DataGridViewColumn)dgvcDBAddRight).HeaderText = "Thêm";
		((DataGridViewColumn)dgvcDBAddRight).Name = "dgvcDBAddRight";
		((DataGridViewColumn)dgvcDBAddRight).Visible = false;
		((DataGridViewColumn)dgvcDBAddRight).Width = 40;
		((DataGridViewColumn)dgvcDBEditRight).DataPropertyName = "UpdateRight";
		((DataGridViewColumn)dgvcDBEditRight).HeaderText = "Sửa";
		((DataGridViewColumn)dgvcDBEditRight).Name = "dgvcDBEditRight";
		((DataGridViewColumn)dgvcDBEditRight).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcDBEditRight).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcDBEditRight).Visible = false;
		((DataGridViewColumn)dgvcDBEditRight).Width = 40;
		((DataGridViewColumn)dgvcDBDeleteRight).DataPropertyName = "deleteright";
		((DataGridViewColumn)dgvcDBDeleteRight).HeaderText = "Xoá";
		((DataGridViewColumn)dgvcDBDeleteRight).Name = "dgvcDBDeleteRight";
		((DataGridViewColumn)dgvcDBDeleteRight).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcDBDeleteRight).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcDBDeleteRight).Visible = false;
		((DataGridViewColumn)dgvcDBDeleteRight).Width = 40;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)dgvDM_Dash);
		((Control)this).Controls.Add((Control)(object)chkAllDel);
		((Control)this).Controls.Add((Control)(object)chkAllEdit);
		((Control)this).Controls.Add((Control)(object)chkAllAdd);
		((Control)this).Controls.Add((Control)(object)chkAllView);
		((Control)this).Name = "ucSmSetRightsDash";
		size = new Size(413, 134);
		((Control)this).Size = size;
		((ISupportInitialize)dgvDM_Dash).EndInit();
		((ISupportInitialize)bsDashRight).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void GetData()
	{
		if (bsDashRight.DataSource == null)
		{
			f_oTblUserRight.TableName = "UserRight";
			f_oTblGrandRightUserName.TableName = "GrandRight";
			DataSet dataSet = new DataSet();
			dataSet.Tables.Add(f_oTblUserRight);
			dataSet.Tables.Add(f_oTblGrandRightUserName);
			bsDashRight.DataSource = dataSet;
			((DataGridView)dgvDM_Dash).DataSource = bsDashRight;
			((DataGridView)dgvDM_Dash).DataMember = "UserRight";
		}
	}

	public bool ProcessDB()
	{
		((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvDM_Dash).DataSource)].EndCurrentEdit();
		if (f_oTblUserRight.GetChanges(DataRowState.Modified) == null)
		{
			return true;
		}
		try
		{
			DataTable dataTable = f_oTblUserRight.GetChanges(DataRowState.Modified).Copy();
			dataTable.TableName = "userDashRight";
			dataTable.Columns["cuser"].Expression = "'" + SystemInformations.UserName + "'";
			dataTable.Columns["luser"].Expression = "'" + SystemInformations.UserName + "'";
			DateTime now = DateTime.Now;
			dataTable.Columns["cdate"].Expression = "'" + Conversions.ToString(now) + "'";
			dataTable.Columns["ldate"].Expression = "'" + Conversions.ToString(now) + "'";
			foreach (DataColumn column in dataTable.Columns)
			{
				column.ColumnName = column.ColumnName.ToUpper();
			}
			DataSet dataSet = new DataSet();
			dataSet.Tables.Add(dataTable);
			string xml = dataSet.GetXml();
			dataSet.Dispose();
			MyController.DynInsertUpdateDeleteData(xml, dataTable.TableName, "3");
			MyController.DynInsertUpdateDeleteData(xml, dataTable.TableName, "1");
			MyController.MyDAO.Destroy();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
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
			if (((DataGridView)dgvDM_Dash).CurrentCell != null)
			{
				((DataGridView)dgvDM_Dash).InvalidateRow(((DataGridView)dgvDM_Dash).CurrentCell.RowIndex);
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
			if (((DataGridView)dgvDM_Dash).CurrentCell != null)
			{
				((DataGridView)dgvDM_Dash).InvalidateRow(((DataGridView)dgvDM_Dash).CurrentCell.RowIndex);
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
			if (((DataGridView)dgvDM_Dash).CurrentCell != null)
			{
				((DataGridView)dgvDM_Dash).InvalidateRow(((DataGridView)dgvDM_Dash).CurrentCell.RowIndex);
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
			if (((DataGridView)dgvDM_Dash).CurrentCell != null)
			{
				((DataGridView)dgvDM_Dash).InvalidateRow(((DataGridView)dgvDM_Dash).CurrentCell.RowIndex);
			}
		}
	}
}
