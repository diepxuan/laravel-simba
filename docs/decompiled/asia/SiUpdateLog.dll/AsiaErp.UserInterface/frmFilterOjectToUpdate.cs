using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.ToolCommon;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmFilterOjectToUpdate : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("btnOk")]
	private Button _btnOk;

	[AccessedThroughProperty("dgvFilter")]
	private AsDataGridView _dgvFilter;

	[AccessedThroughProperty("txtFilter")]
	private TextBox _txtFilter;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("cboFilterType")]
	private ComboBox _cboFilterType;

	[AccessedThroughProperty("dgvcChon")]
	private DataGridViewCheckBoxColumn _dgvcChon;

	[AccessedThroughProperty("dgvcName")]
	private DataGridViewTextBoxColumn _dgvcName;

	[AccessedThroughProperty("dgvcTypeOfObject")]
	private DataGridViewTextBoxColumn _dgvcTypeOfObject;

	[AccessedThroughProperty("dgvcCreate_date")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcCreate_date;

	[AccessedThroughProperty("dgvcLast_modify")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcLast_modify;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("cboTenDataBase")]
	private ComboBox _cboTenDataBase;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("btnCNewConnection")]
	private Button _btnCNewConnection;

	public DataTable f_dtFilter;

	private bool bLoading;

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual Button btnOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnOk_Click;
			if (_btnOk != null)
			{
				((Control)_btnOk).Click -= eventHandler;
			}
			_btnOk = value;
			if (_btnOk != null)
			{
				((Control)_btnOk).Click += eventHandler;
			}
		}
	}

	internal virtual AsDataGridView dgvFilter
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvFilter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(dgvFilter_CellClick);
			if (_dgvFilter != null)
			{
				((DataGridView)_dgvFilter).CellClick -= val;
			}
			_dgvFilter = value;
			if (_dgvFilter != null)
			{
				((DataGridView)_dgvFilter).CellClick += val;
			}
		}
	}

	internal virtual TextBox txtFilter
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFilter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtFilter_TextChanged;
			if (_txtFilter != null)
			{
				((Control)_txtFilter).TextChanged -= eventHandler;
			}
			_txtFilter = value;
			if (_txtFilter != null)
			{
				((Control)_txtFilter).TextChanged += eventHandler;
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

	internal virtual ComboBox cboFilterType
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboFilterType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboFilterType_SelectedIndexChanged;
			if (_cboFilterType != null)
			{
				_cboFilterType.SelectedIndexChanged -= eventHandler;
			}
			_cboFilterType = value;
			if (_cboFilterType != null)
			{
				_cboFilterType.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcChon
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcChon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcChon = value;
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

	internal virtual DataGridViewTextBoxColumn dgvcTypeOfObject
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTypeOfObject;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTypeOfObject = value;
		}
	}

	internal virtual DataGridViewAsMaskedTextBoxColumn dgvcCreate_date
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCreate_date;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCreate_date = value;
		}
	}

	internal virtual DataGridViewAsMaskedTextBoxColumn dgvcLast_modify
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcLast_modify;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcLast_modify = value;
		}
	}

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual ComboBox cboTenDataBase
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboTenDataBase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboTenDataBase_SelectedIndexChanged;
			if (_cboTenDataBase != null)
			{
				_cboTenDataBase.SelectedIndexChanged -= eventHandler;
			}
			_cboTenDataBase = value;
			if (_cboTenDataBase != null)
			{
				_cboTenDataBase.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label2
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

	internal virtual Button btnCNewConnection
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnCNewConnection;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnCNewConnection_Click;
			if (_btnCNewConnection != null)
			{
				((Control)_btnCNewConnection).Click -= eventHandler;
			}
			_btnCNewConnection = value;
			if (_btnCNewConnection != null)
			{
				((Control)_btnCNewConnection).Click += eventHandler;
			}
		}
	}

	public frmFilterOjectToUpdate()
	{
		((Form)this).Load += frmFilterOjectToUpdate_Load;
		__ENCAddToList(this);
		bLoading = true;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected O, but got Unknown
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		Panel1 = new Panel();
		cboFilterType = new ComboBox();
		Label1 = new Label();
		txtFilter = new TextBox();
		btnOk = new Button();
		dgvFilter = new AsDataGridView();
		dgvcChon = new DataGridViewCheckBoxColumn();
		dgvcName = new DataGridViewTextBoxColumn();
		dgvcTypeOfObject = new DataGridViewTextBoxColumn();
		dgvcCreate_date = new DataGridViewAsMaskedTextBoxColumn();
		dgvcLast_modify = new DataGridViewAsMaskedTextBoxColumn();
		Panel2 = new Panel();
		btnCNewConnection = new Button();
		Label2 = new Label();
		cboTenDataBase = new ComboBox();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)dgvFilter).BeginInit();
		((Control)Panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).Controls.Add((Control)(object)cboFilterType);
		((Control)Panel1).Controls.Add((Control)(object)Label1);
		((Control)Panel1).Controls.Add((Control)(object)txtFilter);
		((Control)Panel1).Controls.Add((Control)(object)btnOk);
		((Control)Panel1).Dock = (DockStyle)2;
		Panel panel = Panel1;
		Point location = new Point(0, 453);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		Size size = new Size(736, 31);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 1;
		cboFilterType.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboFilterType).FormattingEnabled = true;
		cboFilterType.Items.AddRange(new object[3] { "Function", "Stored Procedure", "View" });
		ComboBox obj = cboFilterType;
		location = new Point(324, 5);
		((Control)obj).Location = location;
		ComboBox obj2 = cboFilterType;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Control)obj2).Margin = margin;
		((Control)cboFilterType).Name = "cboFilterType";
		ComboBox obj3 = cboFilterType;
		size = new Size(110, 21);
		((Control)obj3).Size = size;
		((Control)cboFilterType).TabIndex = 3;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(12, 8);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(29, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 2;
		Label1.Text = "Filter";
		TextBox obj4 = txtFilter;
		location = new Point(71, 5);
		((Control)obj4).Location = location;
		((Control)txtFilter).Name = "txtFilter";
		TextBox obj5 = txtFilter;
		size = new Size(250, 20);
		((Control)obj5).Size = size;
		((Control)txtFilter).TabIndex = 1;
		((Control)btnOk).Anchor = (AnchorStyles)10;
		Button obj6 = btnOk;
		location = new Point(649, 3);
		((Control)obj6).Location = location;
		((Control)btnOk).Name = "btnOk";
		Button obj7 = btnOk;
		size = new Size(75, 23);
		((Control)obj7).Size = size;
		((Control)btnOk).TabIndex = 0;
		((ButtonBase)btnOk).Text = "Ok";
		((ButtonBase)btnOk).UseVisualStyleBackColor = true;
		((DataGridView)dgvFilter).AllowUserToAddRows = false;
		((DataGridView)dgvFilter).AllowUserToDeleteRows = false;
		((Control)dgvFilter).Anchor = (AnchorStyles)15;
		((DataGridView)dgvFilter).BackgroundColor = Color.White;
		((DataGridView)dgvFilter).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvFilter).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)dgvFilter).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvFilter).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)dgvcChon,
			(DataGridViewColumn)dgvcName,
			(DataGridViewColumn)dgvcTypeOfObject,
			dgvcCreate_date,
			dgvcLast_modify
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvFilter).DefaultCellStyle = val2;
		dgvFilter.DoubleBuffered = false;
		((DataGridView)dgvFilter).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvFilter).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvFilter;
		location = new Point(12, 37);
		((Control)asDataGridView).Location = location;
		((Control)dgvFilter).Name = "dgvFilter";
		dgvFilter.ReadOnly = true;
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvFilter).RowHeadersDefaultCellStyle = val3;
		dgvFilter.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvFilter).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvFilter;
		size = new Size(712, 410);
		((Control)asDataGridView2).Size = size;
		((Control)dgvFilter).TabIndex = 0;
		((DataGridViewColumn)dgvcChon).DataPropertyName = "Chon";
		((DataGridViewColumn)dgvcChon).HeaderText = "Choice";
		((DataGridViewColumn)dgvcChon).Name = "dgvcChon";
		((DataGridViewColumn)dgvcChon).ReadOnly = true;
		((DataGridViewColumn)dgvcChon).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcChon).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcChon).Width = 50;
		((DataGridViewColumn)dgvcName).DataPropertyName = "name";
		((DataGridViewColumn)dgvcName).HeaderText = "Name";
		((DataGridViewColumn)dgvcName).Name = "dgvcName";
		((DataGridViewColumn)dgvcName).ReadOnly = true;
		((DataGridViewColumn)dgvcName).Width = 300;
		((DataGridViewColumn)dgvcTypeOfObject).DataPropertyName = "TypeOfObject";
		((DataGridViewColumn)dgvcTypeOfObject).HeaderText = "Ọbject Type";
		((DataGridViewColumn)dgvcTypeOfObject).Name = "dgvcTypeOfObject";
		((DataGridViewColumn)dgvcCreate_date).DataPropertyName = "Create_date";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcCreate_date).DefaultCellStyle = val4;
		dgvcCreate_date.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcCreate_date).HeaderText = "Create_date";
		dgvcCreate_date.Mask = "##/##/####";
		((DataGridViewColumn)dgvcCreate_date).Name = "dgvcCreate_date";
		((DataGridViewColumn)dgvcCreate_date).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcLast_modify).DataPropertyName = "Last_modify";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcLast_modify).DefaultCellStyle = val5;
		dgvcLast_modify.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcLast_modify).HeaderText = "Last Modify";
		dgvcLast_modify.Mask = "##/##/####";
		((DataGridViewColumn)dgvcLast_modify).Name = "dgvcLast_modify";
		((DataGridViewColumn)dgvcLast_modify).Resizable = (DataGridViewTriState)1;
		((Control)Panel2).Controls.Add((Control)(object)btnCNewConnection);
		((Control)Panel2).Controls.Add((Control)(object)Label2);
		((Control)Panel2).Controls.Add((Control)(object)cboTenDataBase);
		((Control)Panel2).Dock = (DockStyle)1;
		Panel panel3 = Panel2;
		location = new Point(0, 0);
		((Control)panel3).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel4 = Panel2;
		size = new Size(736, 31);
		((Control)panel4).Size = size;
		((Control)Panel2).TabIndex = 2;
		((ButtonBase)btnCNewConnection).FlatStyle = (FlatStyle)1;
		Button obj8 = btnCNewConnection;
		location = new Point(301, 5);
		((Control)obj8).Location = location;
		((Control)btnCNewConnection).Name = "btnCNewConnection";
		Button obj9 = btnCNewConnection;
		size = new Size(133, 23);
		((Control)obj9).Size = size;
		((Control)btnCNewConnection).TabIndex = 113;
		((ButtonBase)btnCNewConnection).Text = "Create New Connection";
		((ButtonBase)btnCNewConnection).UseVisualStyleBackColor = true;
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(12, 10);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(53, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 54;
		Label2.Text = "Database";
		cboTenDataBase.DropDownWidth = 248;
		ComboBox obj10 = cboTenDataBase;
		location = new Point(71, 7);
		((Control)obj10).Location = location;
		((Control)cboTenDataBase).Name = "cboTenDataBase";
		ComboBox obj11 = cboTenDataBase;
		size = new Size(224, 21);
		((Control)obj11).Size = size;
		((Control)cboTenDataBase).TabIndex = 53;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(736, 484);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Control)this).Controls.Add((Control)(object)dgvFilter);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmFilterOjectToUpdate";
		((Form)this).Text = "Filter";
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)dgvFilter).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmFilterOjectToUpdate_Load(object sender, EventArgs e)
	{
		bLoading = true;
		cboFilterType.SelectedIndex = 0;
		GetAllDatabaseNameToCombo();
		GetData();
		bLoading = false;
	}

	private void dgvFilter_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if ((((DataGridView)dgvFilter).DataSource != null && e.ColumnIndex == 0) ? true : false)
		{
			((DataGridView)dgvFilter).CurrentCell.Value = Operators.NotObject(((DataGridView)dgvFilter).CurrentCell.Value);
		}
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		((DataTable)((DataGridView)dgvFilter).DataSource).AcceptChanges();
		((Form)this).Close();
	}

	private void txtFilter_TextChanged(object sender, EventArgs e)
	{
		RefreshData();
	}

	private void cboFilterType_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((DataGridView)dgvFilter).DataSource != null)
		{
			RefreshData();
		}
	}

	private void cboTenDataBase_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboTenDataBase.DataSource != null && !bLoading && 0 == 0)
		{
			if (cboTenDataBase.DataSource != null)
			{
				TCommon.set_Session((object)"SqlDataDBName", (object)cboTenDataBase.Text);
			}
			TCommon.set_Session((object)"sDataCnnString", (object)TCommon.GetConnection());
			GetData();
		}
	}

	private void btnCNewConnection_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		frmCreateConnection frmCreateConnection2 = new frmCreateConnection();
		((Form)frmCreateConnection2).ShowDialog();
		GetAllDatabaseNameToCombo();
		GetData();
	}

	private void RefreshData()
	{
		DataTable dataTable = (DataTable)((DataGridView)dgvFilter).DataSource;
		if (dataTable != null)
		{
			dataTable.DefaultView.RowFilter = "name LIKE '%" + txtFilter.Text + "%' AND TypeOfObject = '" + cboFilterType.Text + "'";
		}
	}

	private void GetData()
	{
		f_dtFilter = TCommon.TGetDataTableByQuerry(false, Resources.TSQL_AllObj);
		if (f_dtFilter != null)
		{
			((DataGridView)dgvFilter).DataSource = f_dtFilter;
			RefreshData();
		}
	}

	private void GetAllDatabaseNameToCombo()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006b: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		bLoading = true;
		SqlDataAdapter val = new SqlDataAdapter();
		DataTable dataTable = new DataTable();
		try
		{
			IDbConnection dbConnection = (IDbConnection)new SqlConnection(Conversions.ToString(TCommon.get_Session((object)"sDataCnnString")));
			dbConnection.Open();
			SqlCommand val2 = (SqlCommand)dbConnection.CreateCommand();
			val2.CommandType = CommandType.Text;
			val2.CommandText = "SELECT name, database_id FROM sys.databases ORDER BY name";
			val.SelectCommand = val2;
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		catch (SqlException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			SqlException ex2 = ex;
			string text = string.Format("Không thể kết nối đến server {0}", "");
			CMessageBox.Show(text);
			Helper.ProcessError(((Exception)(object)ex2).ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			((Component)(object)val).Dispose();
		}
		try
		{
			cboTenDataBase.DataSource = null;
			cboTenDataBase.DataSource = dataTable;
			((ListControl)cboTenDataBase).DisplayMember = "name";
			((ListControl)cboTenDataBase).ValueMember = "database_id";
			cboTenDataBase.Text = Conversions.ToString(TCommon.get_Session((object)"SqlDataDBName"));
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			throw ex4;
		}
		bLoading = false;
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
}
