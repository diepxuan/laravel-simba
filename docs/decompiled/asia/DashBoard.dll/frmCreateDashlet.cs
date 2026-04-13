using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

[DesignerGenerated]
public class frmCreateDashlet : frmAsiaRoot
{
	public delegate void AddDash_ClickEventHandler(object sender, EventArgs e);

	private IContainer components;

	[AccessedThroughProperty("cboChuc_nang")]
	private AsComboBox _cboChuc_nang;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtTitle")]
	private TextBox _txtTitle;

	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[AccessedThroughProperty("btnExit")]
	private Button _btnExit;

	[AccessedThroughProperty("cboLoai")]
	private ComboBox _cboLoai;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("cboVi_tri")]
	private ComboBox _cboVi_tri;

	[AccessedThroughProperty("adgvParameter")]
	private AsInputDGV _adgvParameter;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("dgvcDescription")]
	private DataGridViewTextBoxColumn _dgvcDescription;

	[AccessedThroughProperty("dgvcParaname")]
	private DataGridViewTextBoxColumn _dgvcParaname;

	[AccessedThroughProperty("dgvcParavalue")]
	private DataGridViewTextBoxColumn _dgvcParavalue;

	[AccessedThroughProperty("dgvcMaxLength")]
	private DataGridViewTextBoxColumn _dgvcMaxLength;

	[AccessedThroughProperty("dgvcDataType")]
	private DataGridViewTextBoxColumn _dgvcDataType;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("rdbChart")]
	private RadioButton _rdbChart;

	[AccessedThroughProperty("rdbTable")]
	private RadioButton _rdbTable;

	private bool bLoading;

	private bool bOk;

	private DataTable oData;

	private DataTable oDtPara;

	private DataTable oDtResult;

	private DataTable oDtChucNang;

	private DataTable oDtDash;

	internal int DashID;

	private bool EditMode;

	internal bool f_IsEdit;

	private frmUpdRptChartResX frmUpdChart;

	private string sDashletType;

	private bool isShown;

	private const string INT = "###################";

	private const string DEC = "###################.####";

	private const string MENU_TYPE = "MENU";

	private const string TABLE_TYPE = "TABLE";

	private const string CHART_TYPE = "CHART";

	internal virtual AsComboBox cboChuc_nang
	{
		get
		{
			return _cboChuc_nang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboChuc_nang_SelectedIndexChanged;
			if (_cboChuc_nang != null)
			{
				((ComboBox)_cboChuc_nang).SelectedIndexChanged -= eventHandler;
			}
			_cboChuc_nang = value;
			if (_cboChuc_nang != null)
			{
				((ComboBox)_cboChuc_nang).SelectedIndexChanged += eventHandler;
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

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual TextBox txtTitle
	{
		get
		{
			return _txtTitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTitle = value;
		}
	}

	internal virtual Button btnSave
	{
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnLuu_Click;
			if (_btnSave != null)
			{
				((Control)_btnSave).Click -= eventHandler;
			}
			_btnSave = value;
			if (_btnSave != null)
			{
				((Control)_btnSave).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnExit
	{
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnExit_Click;
			if (_btnExit != null)
			{
				((Control)_btnExit).Click -= eventHandler;
			}
			_btnExit = value;
			if (_btnExit != null)
			{
				((Control)_btnExit).Click += eventHandler;
			}
		}
	}

	internal virtual ComboBox cboLoai
	{
		get
		{
			return _cboLoai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cbbLoai_SelectedValueChanged;
			if (_cboLoai != null)
			{
				((ListControl)_cboLoai).SelectedValueChanged -= eventHandler;
			}
			_cboLoai = value;
			if (_cboLoai != null)
			{
				((ListControl)_cboLoai).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label5
	{
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual ComboBox cboVi_tri
	{
		get
		{
			return _cboVi_tri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboVi_tri = value;
		}
	}

	internal virtual AsInputDGV adgvParameter
	{
		get
		{
			return _adgvParameter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_adgvParameter = value;
		}
	}

	internal virtual Label Label6
	{
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDescription
	{
		get
		{
			return _dgvcDescription;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcDescription = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcParaname
	{
		get
		{
			return _dgvcParaname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcParaname = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcParavalue
	{
		get
		{
			return _dgvcParavalue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcParavalue = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMaxLength
	{
		get
		{
			return _dgvcMaxLength;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcMaxLength = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDataType
	{
		get
		{
			return _dgvcDataType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcDataType = value;
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual RadioButton rdbChart
	{
		get
		{
			return _rdbChart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = rdbChart_Click;
			EventHandler eventHandler2 = rdbChart_CheckedChanged;
			if (_rdbChart != null)
			{
				((Control)_rdbChart).Click -= eventHandler;
				_rdbChart.CheckedChanged -= eventHandler2;
			}
			_rdbChart = value;
			if (_rdbChart != null)
			{
				((Control)_rdbChart).Click += eventHandler;
				_rdbChart.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton rdbTable
	{
		get
		{
			return _rdbTable;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_rdbTable = value;
		}
	}

	public event AddDash_ClickEventHandler AddDash_Click;

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

	public frmCreateDashlet(bool EditMode, int f_DashID = 0)
	{
		((Form)this).Load += frmCreateDashBoard_Load;
		((Form)this).Shown += frmCreateDashlet_Shown;
		bLoading = false;
		bOk = false;
		oData = new DataTable();
		oDtPara = new DataTable();
		oDtResult = new DataTable();
		oDtChucNang = new DataTable();
		f_IsEdit = false;
		sDashletType = "";
		isShown = false;
		InitializeComponent();
		this.EditMode = EditMode;
		DashID = f_DashID;
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
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected O, but got Unknown
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected O, but got Unknown
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		cboChuc_nang = new AsComboBox();
		Label1 = new Label();
		Label2 = new Label();
		Label4 = new Label();
		txtTitle = new TextBox();
		cboLoai = new ComboBox();
		Label5 = new Label();
		GroupBox1 = new GroupBox();
		rdbChart = new RadioButton();
		rdbTable = new RadioButton();
		Label3 = new Label();
		Label6 = new Label();
		adgvParameter = new AsInputDGV();
		dgvcDescription = new DataGridViewTextBoxColumn();
		dgvcParaname = new DataGridViewTextBoxColumn();
		dgvcParavalue = new DataGridViewTextBoxColumn();
		dgvcMaxLength = new DataGridViewTextBoxColumn();
		dgvcDataType = new DataGridViewTextBoxColumn();
		cboVi_tri = new ComboBox();
		btnExit = new Button();
		btnSave = new Button();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)adgvParameter).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cboChuc_nang).Anchor = (AnchorStyles)13;
		((ComboBox)cboChuc_nang).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboChuc_nang).FormattingEnabled = true;
		AsComboBox asComboBox = cboChuc_nang;
		Point location = new Point(103, 46);
		((Control)asComboBox).Location = location;
		((Control)cboChuc_nang).Name = "cboChuc_nang";
		AsComboBox asComboBox2 = cboChuc_nang;
		Size size = new Size(263, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboChuc_nang).TabIndex = 1;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(16, 76);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(56, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 9;
		Label1.Text = "Định dạng";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(247, 80);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(29, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 10;
		Label2.Text = "Vị trí";
		((Control)Label2).Visible = false;
		Label4.AutoSize = true;
		Label label5 = Label4;
		location = new Point(16, 130);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		Label label6 = Label4;
		size = new Size(44, 13);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 11;
		Label4.Text = "Tiêu đề";
		((Control)txtTitle).Anchor = (AnchorStyles)13;
		TextBox obj = txtTitle;
		location = new Point(103, 127);
		((Control)obj).Location = location;
		((Control)txtTitle).Name = "txtTitle";
		TextBox obj2 = txtTitle;
		size = new Size(408, 20);
		((Control)obj2).Size = size;
		((Control)txtTitle).TabIndex = 5;
		cboLoai.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai).FormattingEnabled = true;
		cboLoai.Items.AddRange(new object[2] { "Dữ liệu tổng hợp", "Chức năng thường dùng" });
		ComboBox obj3 = cboLoai;
		location = new Point(103, 19);
		((Control)obj3).Location = location;
		((Control)cboLoai).Name = "cboLoai";
		ComboBox obj4 = cboLoai;
		size = new Size(263, 21);
		((Control)obj4).Size = size;
		((Control)cboLoai).TabIndex = 0;
		Label5.AutoSize = true;
		Label label7 = Label5;
		location = new Point(16, 22);
		((Control)label7).Location = location;
		((Control)Label5).Name = "Label5";
		Label label8 = Label5;
		size = new Size(27, 13);
		((Control)label8).Size = size;
		((Control)Label5).TabIndex = 7;
		Label5.Text = "Loại";
		((Control)GroupBox1).Anchor = (AnchorStyles)15;
		((Control)GroupBox1).Controls.Add((Control)(object)rdbChart);
		((Control)GroupBox1).Controls.Add((Control)(object)rdbTable);
		((Control)GroupBox1).Controls.Add((Control)(object)Label3);
		((Control)GroupBox1).Controls.Add((Control)(object)Label6);
		((Control)GroupBox1).Controls.Add((Control)(object)adgvParameter);
		((Control)GroupBox1).Controls.Add((Control)(object)cboVi_tri);
		((Control)GroupBox1).Controls.Add((Control)(object)cboLoai);
		((Control)GroupBox1).Controls.Add((Control)(object)cboChuc_nang);
		((Control)GroupBox1).Controls.Add((Control)(object)Label1);
		((Control)GroupBox1).Controls.Add((Control)(object)Label5);
		((Control)GroupBox1).Controls.Add((Control)(object)Label2);
		((Control)GroupBox1).Controls.Add((Control)(object)Label4);
		((Control)GroupBox1).Controls.Add((Control)(object)txtTitle);
		GroupBox groupBox = GroupBox1;
		location = new Point(12, 12);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(527, 353);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 0;
		GroupBox1.TabStop = false;
		((ButtonBase)rdbChart).AutoSize = true;
		RadioButton obj5 = rdbChart;
		location = new Point(159, 74);
		((Control)obj5).Location = location;
		((Control)rdbChart).Name = "rdbChart";
		RadioButton obj6 = rdbChart;
		size = new Size(53, 17);
		((Control)obj6).Size = size;
		((Control)rdbChart).TabIndex = 3;
		((ButtonBase)rdbChart).Text = "Đồ thị";
		((ButtonBase)rdbChart).UseVisualStyleBackColor = true;
		((ButtonBase)rdbTable).AutoSize = true;
		rdbTable.Checked = true;
		RadioButton obj7 = rdbTable;
		location = new Point(103, 74);
		((Control)obj7).Location = location;
		((Control)rdbTable).Name = "rdbTable";
		RadioButton obj8 = rdbTable;
		size = new Size(50, 17);
		((Control)obj8).Size = size;
		((Control)rdbTable).TabIndex = 2;
		rdbTable.TabStop = true;
		((ButtonBase)rdbTable).Text = "Bảng";
		((ButtonBase)rdbTable).UseVisualStyleBackColor = true;
		Label3.AutoSize = true;
		Label label9 = Label3;
		location = new Point(16, 49);
		((Control)label9).Location = location;
		((Control)Label3).Name = "Label3";
		Label label10 = Label3;
		size = new Size(59, 13);
		((Control)label10).Size = size;
		((Control)Label3).TabIndex = 8;
		Label3.Text = "Chức năng";
		Label6.AutoSize = true;
		Label label11 = Label6;
		location = new Point(16, 156);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(99, 13);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 12;
		Label6.Text = "Danh sách tham số";
		((DataGridView)adgvParameter).AllowUserToAddRows = false;
		((DataGridView)adgvParameter).AllowUserToDeleteRows = false;
		((DataGridView)adgvParameter).AllowUserToResizeRows = false;
		((Control)adgvParameter).Anchor = (AnchorStyles)15;
		((DataGridView)adgvParameter).BackgroundColor = Color.White;
		((DataGridView)adgvParameter).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvParameter).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)adgvParameter).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)1;
		((DataGridView)adgvParameter).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)dgvcDescription,
			(DataGridViewColumn)dgvcParaname,
			(DataGridViewColumn)dgvcParavalue,
			(DataGridViewColumn)dgvcMaxLength,
			(DataGridViewColumn)dgvcDataType
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvParameter).DefaultCellStyle = val2;
		((DataGridView)adgvParameter).EditMode = (DataGridViewEditMode)0;
		((DataGridView)adgvParameter).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = adgvParameter;
		location = new Point(19, 173);
		((Control)asInputDGV).Location = location;
		((Control)adgvParameter).Name = "adgvParameter";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvParameter).RowHeadersDefaultCellStyle = val3;
		((DataGridView)adgvParameter).RowHeadersVisible = false;
		((DataGridView)adgvParameter).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = adgvParameter;
		size = new Size(492, 174);
		((Control)asInputDGV2).Size = size;
		((Control)adgvParameter).TabIndex = 6;
		((DataGridViewColumn)dgvcDescription).DataPropertyName = "Description";
		((DataGridViewColumn)dgvcDescription).HeaderText = "Mô tả";
		((DataGridViewColumn)dgvcDescription).Name = "dgvcDescription";
		((DataGridViewColumn)dgvcDescription).ReadOnly = true;
		dgvcDescription.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcDescription).Width = 350;
		((DataGridViewColumn)dgvcParaname).DataPropertyName = "PARAMETER_NAME";
		((DataGridViewColumn)dgvcParaname).HeaderText = "Tham số";
		((DataGridViewColumn)dgvcParaname).Name = "dgvcParaname";
		((DataGridViewColumn)dgvcParaname).Visible = false;
		((DataGridViewColumn)dgvcParavalue).DataPropertyName = "paravalue";
		((DataGridViewColumn)dgvcParavalue).HeaderText = "Giá trị";
		((DataGridViewColumn)dgvcParavalue).Name = "dgvcParavalue";
		dgvcParavalue.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcParavalue).Width = 139;
		((DataGridViewColumn)dgvcMaxLength).DataPropertyName = "CHARACTER_MAXIMUM_LENGTH";
		((DataGridViewColumn)dgvcMaxLength).HeaderText = "Column1";
		((DataGridViewColumn)dgvcMaxLength).Name = "dgvcMaxLength";
		((DataGridViewColumn)dgvcMaxLength).Visible = false;
		((DataGridViewColumn)dgvcDataType).DataPropertyName = "DATA_TYPE";
		((DataGridViewColumn)dgvcDataType).HeaderText = "Column1";
		((DataGridViewColumn)dgvcDataType).Name = "dgvcDataType";
		((DataGridViewColumn)dgvcDataType).Visible = false;
		cboVi_tri.DropDownStyle = (ComboBoxStyle)2;
		((Control)cboVi_tri).Enabled = false;
		((ListControl)cboVi_tri).FormattingEnabled = true;
		cboVi_tri.Items.AddRange(new object[2] { "Bên trái", "Bên phải" });
		ComboBox obj9 = cboVi_tri;
		location = new Point(334, 76);
		((Control)obj9).Location = location;
		((Control)cboVi_tri).Name = "cboVi_tri";
		ComboBox obj10 = cboVi_tri;
		size = new Size(137, 21);
		((Control)obj10).Size = size;
		((Control)cboVi_tri).TabIndex = 4;
		((Control)cboVi_tri).Visible = false;
		((Control)btnExit).Anchor = (AnchorStyles)6;
		((ButtonBase)btnExit).Image = (Image)(object)Resources.imgCancel;
		((ButtonBase)btnExit).ImageAlign = (ContentAlignment)16;
		Button obj11 = btnExit;
		location = new Point(86, 371);
		((Control)obj11).Location = location;
		((Control)btnExit).Name = "btnExit";
		Button obj12 = btnExit;
		size = new Size(68, 25);
		((Control)obj12).Size = size;
		((Control)btnExit).TabIndex = 2;
		((ButtonBase)btnExit).Text = "&Huỷ";
		((ButtonBase)btnExit).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnExit).UseVisualStyleBackColor = true;
		((Control)btnSave).Anchor = (AnchorStyles)6;
		((ButtonBase)btnSave).Image = (Image)(object)Resources.save;
		((ButtonBase)btnSave).ImageAlign = (ContentAlignment)16;
		Button obj13 = btnSave;
		location = new Point(12, 371);
		((Control)obj13).Location = location;
		((Control)btnSave).Name = "btnSave";
		Button obj14 = btnSave;
		size = new Size(68, 25);
		((Control)obj14).Size = size;
		((Control)btnSave).TabIndex = 1;
		((ButtonBase)btnSave).Text = "&Nhận";
		((ButtonBase)btnSave).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnSave).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(551, 406);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)btnExit);
		((Control)this).Controls.Add((Control)(object)btnSave);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmCreateDashlet";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).Text = "Add new Dashlet";
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)adgvParameter).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void InitComboSource()
	{
		bLoading = false;
		string[] array = new string[3] { "Key", "Value", "Type" };
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		oData = dashBoardDAO.GetDashRight();
		string[] array2 = array;
		foreach (string columnName in array2)
		{
			DataColumn column = new DataColumn(columnName, typeof(string));
			oDtChucNang.Columns.Add(column);
		}
		foreach (DataRow row in oData.Rows)
		{
			DataRow dataRow2 = oDtChucNang.NewRow();
			dataRow2["Key"] = RuntimeHelpers.GetObjectValue(row["functionId"]);
			dataRow2["Value"] = RuntimeHelpers.GetObjectValue(row["description"]);
			dataRow2["Type"] = "2";
			oDtChucNang.Rows.Add(dataRow2);
		}
		((ListControl)cboChuc_nang).ValueMember = "Key";
		((ListControl)cboChuc_nang).DisplayMember = "Value";
		((ComboBox)cboChuc_nang).DataSource = oDtChucNang;
		ArrayList arrayList = new ArrayList();
		DictionaryEntry dictionaryEntry = new DictionaryEntry(1, RuntimeHelpers.GetObjectValue(cboVi_tri.Items[0]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry(2, RuntimeHelpers.GetObjectValue(cboVi_tri.Items[1]));
		arrayList.Add(dictionaryEntry);
		((ListControl)cboVi_tri).ValueMember = "Key";
		((ListControl)cboVi_tri).DisplayMember = "Value";
		cboVi_tri.DataSource = arrayList;
		cboVi_tri.SelectedIndex = 0;
		DataColumn column2 = new DataColumn("PARAMETER_NAME");
		DataColumn column3 = new DataColumn("DATA_TYPE");
		DataColumn column4 = new DataColumn("CHARACTER_MAXIMUM_LENGTH");
		DataColumn column5 = new DataColumn("DESCRIPTION");
		DataColumn column6 = new DataColumn("DEFAULT_VALUE");
		DataColumn column7 = new DataColumn("PARAVALUE");
		oDtPara.Columns.Add(column2);
		oDtPara.Columns.Add(column3);
		oDtPara.Columns.Add(column4);
		oDtPara.Columns.Add(column5);
		oDtPara.Columns.Add(column6);
		oDtPara.Columns.Add(column7);
		bLoading = true;
		List<DictionaryEntry> list = new List<DictionaryEntry>();
		dictionaryEntry = new DictionaryEntry("2", RuntimeHelpers.GetObjectValue(cboLoai.Items[0]));
		list.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("1", RuntimeHelpers.GetObjectValue(cboLoai.Items[1]));
		list.Add(dictionaryEntry);
		((ListControl)cboLoai).ValueMember = "Key";
		((ListControl)cboLoai).DisplayMember = "Value";
		cboLoai.DataSource = list;
		cboLoai.SelectedIndex = 0;
	}

	private void LoadCombo(string sType)
	{
		if (Conversions.ToDouble(sType) == 1.0)
		{
			oDtChucNang.DefaultView.RowFilter = "Type = 1";
			((Control)cboChuc_nang).Enabled = false;
			txtTitle.Text = Conversions.ToString(NewLateBinding.LateGet(cboLoai.SelectedItem, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
			rdbTable.Checked = false;
			rdbChart.Checked = false;
			((Control)rdbTable).Enabled = false;
			((Control)rdbChart).Enabled = false;
		}
		else
		{
			oDtChucNang.DefaultView.RowFilter = "Type = 2";
			((Control)cboChuc_nang).Enabled = true;
			((ComboBox)cboChuc_nang).SelectedIndex = 0;
			txtTitle.Text = ((ComboBox)cboChuc_nang).Text;
			rdbTable.Checked = true;
			rdbChart.Checked = false;
			((Control)rdbTable).Enabled = true;
			((Control)rdbChart).Enabled = true;
		}
	}

	private string GetSpName(string FunctionID)
	{
		string result = "";
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		DataTable dashFunction = dashBoardDAO.GetDashFunction(FunctionID);
		dashBoardDAO.Destroy();
		if (dashFunction == null || dashFunction.Rows.Count <= 0)
		{
			return result;
		}
		return Conversions.ToString(dashFunction.Rows[0]["spName"]);
	}

	private void GetDataBySp(string SpName, bool IsSys = false)
	{
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", IsSys);
		ArrayList arrayList = new ArrayList();
		arrayList.Add(SpName);
		checked
		{
			int num = oDtPara.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string strA = Conversions.ToString(oDtPara.AsEnumerable().ElementAtOrDefault(i)["DATA_TYPE"]);
				if (Operators.CompareString(oDtPara.AsEnumerable().ElementAtOrDefault(i)["PARAMETER_NAME"].ToString().ToUpper(), "@PMA_CTY", false) == 0)
				{
					arrayList.Add(oDtPara.AsEnumerable().ElementAtOrDefault(i)["PARAMETER_NAME"].ToString());
					arrayList.Add(CompanyInformations.CompanyID);
					continue;
				}
				arrayList.Add(oDtPara.AsEnumerable().ElementAtOrDefault(i)["PARAMETER_NAME"].ToString());
				if ((string.Compare(strA, "int") == 0) | (string.Compare(strA, "decimal") == 0))
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDtPara.AsEnumerable().ElementAtOrDefault(i)["paravalue"]), isNum: true)));
				}
				else
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDtPara.AsEnumerable().ElementAtOrDefault(i)["paravalue"]), isNum: false)));
				}
			}
			oDtResult = dashBoardDAO.ProcessSPDashBoard(arrayList.ToArray());
			dashBoardDAO.Destroy();
		}
	}

	private void GetParameter(bool Exist)
	{
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard");
		if (Operators.ConditionalCompareObjectEqual(((ListControl)cboLoai).SelectedValue, (object)1, false))
		{
			oDtPara.Clear();
			DataRow dataRow = oDtPara.NewRow();
			dataRow["PARAMETER_NAME"] = "@pUserName";
			dataRow["DATA_TYPE"] = "nvarchar";
			dataRow["CHARACTER_MAXIMUM_LENGTH"] = "20";
			dataRow["DESCRIPTION"] = "";
			dataRow["DEFAULT_VALUE"] = "";
			dataRow["PARAVALUE"] = SystemInformations.UserName;
			oDtPara.Rows.Add(dataRow);
			dataRow = oDtPara.NewRow();
			dataRow["PARAMETER_NAME"] = "@pDashID";
			dataRow["DATA_TYPE"] = "int";
			dataRow["CHARACTER_MAXIMUM_LENGTH"] = DBNull.Value;
			dataRow["DESCRIPTION"] = "";
			dataRow["DEFAULT_VALUE"] = "";
			dataRow["PARAVALUE"] = "";
			oDtPara.Rows.Add(dataRow);
		}
		else
		{
			oDtPara = dashBoardDAO.GetParameter(GetSpName(Conversions.ToString(((ListControl)cboChuc_nang).SelectedValue)));
			dashBoardDAO.Destroy();
			if (oDtPara == null || oDtPara.Rows.Count <= 0)
			{
				return;
			}
			((DataGridView)adgvParameter).DataSource = oDtPara.DefaultView;
			DataColumn dataColumn = new DataColumn();
			dataColumn.ColumnName = "paravalue";
			dataColumn.DefaultValue = DBNull.Value;
			oDtPara.Columns.Add(dataColumn);
		}
		string rowFilter = "PARAMETER_NAME not in ('@pMa_cty', '@pUsername', '@pNam', '@pDashID')";
		oDtPara.DefaultView.RowFilter = rowFilter;
		checked
		{
			if (Exist)
			{
				dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
				DataTable valueParameter = dashBoardDAO.GetValueParameter(DashID);
				dashBoardDAO.Destroy();
				if (valueParameter == null || valueParameter.Rows.Count <= 0)
				{
					return;
				}
				int num = oDtPara.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					oDtPara.Rows[i]["paravalue"] = RuntimeHelpers.GetObjectValue(valueParameter.Rows[i]["paravalue"]);
				}
			}
			else
			{
				int num2 = oDtPara.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					switch (oDtPara.Rows[j]["PARAMETER_NAME"].ToString().ToUpper())
					{
					case "@PMA_CTY":
						oDtPara.Rows[j]["paravalue"] = "";
						break;
					case "@PUSERNAME":
						oDtPara.Rows[j]["paravalue"] = SystemInformations.UserName;
						break;
					case "@PNAM":
						oDtPara.Rows[j]["paravalue"] = SystemInformations.FinancialYear;
						break;
					case "@PDASHID":
						oDtPara.Rows[j]["paravalue"] = "";
						break;
					}
				}
			}
			int num3 = ((DataGridView)adgvParameter).RowCount - 1;
			for (int k = 0; k <= num3; k++)
			{
				string text = ((DataGridView)adgvParameter).Rows[k].Cells["dgvcDataType"].Value.ToString().ToLower();
				object obj = null;
				switch (text)
				{
				case "nvarchar":
					obj = new DataGridViewAsTextBoxCell();
					break;
				case "smalldatetime":
					obj = new DataGridViewAsMaskedTextBoxCell();
					break;
				case "int":
				{
					DataGridViewAsTextNumericCell dataGridViewAsTextNumericCell = new DataGridViewAsTextNumericCell();
					dataGridViewAsTextNumericCell.Mask = "###################";
					obj = dataGridViewAsTextNumericCell;
					break;
				}
				case "decimal":
				{
					DataGridViewAsTextNumericCell dataGridViewAsTextNumericCell = new DataGridViewAsTextNumericCell();
					dataGridViewAsTextNumericCell.Mask = "###################.####";
					obj = dataGridViewAsTextNumericCell;
					break;
				}
				}
				((DataGridView)adgvParameter).Rows[k].Cells["dgvcParavalue"] = (DataGridViewCell)obj;
			}
			if (Operators.ConditionalCompareObjectNotEqual(((ListControl)cboLoai).SelectedValue, (object)1, false))
			{
				GetDataBySp(GetSpName(Conversions.ToString(((ListControl)cboChuc_nang).SelectedValue)));
			}
		}
	}

	private void InsParameter()
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = new ArrayList();
		checked
		{
			int num = oDtPara.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string strA = Conversions.ToString(oDtPara.AsEnumerable().ElementAtOrDefault(i)["DATA_TYPE"]);
				arrayList.Add(RuntimeHelpers.GetObjectValue(oDtPara.AsEnumerable().ElementAtOrDefault(i)["PARAMETER_NAME"]));
				if ((string.Compare(strA, "int") == 0) | (string.Compare(strA, "decimal") == 0))
				{
					arrayList2.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDtPara.AsEnumerable().ElementAtOrDefault(i)["paravalue"]), isNum: true)));
				}
				else
				{
					arrayList2.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDtPara.AsEnumerable().ElementAtOrDefault(i)["paravalue"]), isNum: false)));
				}
			}
			DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
			int num2 = dashBoardDAO.DelValueParameter(DashID);
			if (num2 != 0)
			{
				CMessageBox.Show(num2);
				dashBoardDAO.Destroy();
				return;
			}
			int num3 = arrayList2.Count - 1;
			for (int j = 0; j <= num3; j++)
			{
				num2 = dashBoardDAO.InsValueParameter(DashID, j, Conversions.ToString(arrayList[j]), Conversions.ToString(arrayList2[j]));
			}
			dashBoardDAO.Destroy();
		}
	}

	private void UpdateChartDashlet()
	{
		if (bOk && Operators.CompareString(sDashletType, "CHART", false) == 0 && frmUpdChart != null)
		{
			frmUpdChart.f_sMenuID = Conversions.ToString(DashID);
			frmUpdChart.UpdRptChartResX();
		}
	}

	private void InsDashlet(object sender, EventArgs e)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		string functionId;
		int h;
		if (((ListControl)cboChuc_nang).SelectedValue == null)
		{
			functionId = "00.00.00";
			h = 50;
		}
		else
		{
			functionId = Conversions.ToString(((ListControl)cboChuc_nang).SelectedValue);
			h = frmDashBoard.dHeight;
		}
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		DataTable maxDashPoint = dashBoardDAO.GetMaxDashPoint(1);
		int y = Conversions.ToInteger(Operators.AddObject(maxDashPoint.Rows[0][0], (object)frmDashBoard.lSpace));
		int width = frmDashBoard.GetWidth(1);
		int iMdX = frmDashBoard.iMdX;
		int num = dashBoardDAO.InsDashForm(txtTitle.Text, Conversions.ToInteger(((ListControl)cboVi_tri).SelectedValue), sDashletType, functionId, iMdX, y, h, width, Conversions.ToString(((ListControl)cboLoai).SelectedValue), ref DashID);
		dashBoardDAO.Destroy();
		if (num != 0)
		{
			CMessageBox.Show(num);
		}
		else
		{
			InsParameter();
		}
	}

	private void UpdDashlet(object sender, EventArgs e)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		int num = dashBoardDAO.UpdDashForm(Conversions.ToInteger(((ListControl)cboVi_tri).SelectedValue), sDashletType, txtTitle.Text, Conversions.ToString(DashID), Conversions.ToInteger(oDtDash.AsEnumerable().ElementAtOrDefault(0)["X"]), Conversions.ToInteger(oDtDash.AsEnumerable().ElementAtOrDefault(0)["Y"]), Conversions.ToInteger(oDtDash.AsEnumerable().ElementAtOrDefault(0)["H"]), Conversions.ToInteger(oDtDash.AsEnumerable().ElementAtOrDefault(0)["W"]));
		if (num != 0)
		{
			CMessageBox.Show(num);
		}
		else
		{
			InsParameter();
		}
	}

	private void frmCreateDashBoard_Load(object sender, EventArgs e)
	{
		InitComboSource();
		if (EditMode)
		{
			DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
			oDtDash = dashBoardDAO.GetDashForm(Conversions.ToString(DashID));
			dashBoardDAO.Destroy();
			((ListControl)cboChuc_nang).SelectedValue = RuntimeHelpers.GetObjectValue(oDtDash.Rows[0]["functionId"]);
			((ListControl)cboLoai).SelectedValue = RuntimeHelpers.GetObjectValue(oDtDash.Rows[0]["Type"]);
			((ListControl)cboVi_tri).SelectedValue = RuntimeHelpers.GetObjectValue(oDtDash.Rows[0]["location"]);
			if (Operators.ConditionalCompareObjectEqual(oDtDash.Rows[0]["format"], (object)"TABLE", false))
			{
				rdbTable.Checked = true;
			}
			if (Operators.ConditionalCompareObjectEqual(oDtDash.Rows[0]["format"], (object)"CHART", false))
			{
				rdbChart.Checked = true;
			}
			txtTitle.Text = Conversions.ToString(oDtDash.Rows[0]["title"]);
			((Control)cboLoai).Enabled = false;
			((Control)cboChuc_nang).Enabled = false;
		}
	}

	private void cbbLoai_SelectedValueChanged(object sender, EventArgs e)
	{
		if (bLoading && cboLoai.DataSource != null)
		{
			LoadCombo(Conversions.ToString(((ListControl)cboLoai).SelectedValue));
			GetParameter(EditMode);
		}
	}

	private void cboChuc_nang_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bLoading && ((ComboBox)cboChuc_nang).DataSource != null)
		{
			if (((ListControl)cboChuc_nang).SelectedValue == null)
			{
				sDashletType = "MENU";
			}
			else if (rdbTable.Checked)
			{
				sDashletType = "TABLE";
			}
			else
			{
				sDashletType = "CHART";
			}
			txtTitle.Text = ((ComboBox)cboChuc_nang).Text;
			GetParameter(EditMode);
		}
	}

	private void rdbChart_CheckedChanged(object sender, EventArgs e)
	{
		if (((ListControl)cboChuc_nang).SelectedValue == null)
		{
			sDashletType = "MENU";
		}
		else if (rdbTable.Checked)
		{
			sDashletType = "TABLE";
		}
		else
		{
			sDashletType = "CHART";
		}
	}

	private void btnLuu_Click(object sender, EventArgs e)
	{
		if (EditMode)
		{
			UpdDashlet(RuntimeHelpers.GetObjectValue(sender), e);
		}
		else
		{
			InsDashlet(RuntimeHelpers.GetObjectValue(sender), e);
		}
		UpdateChartDashlet();
		f_IsEdit = true;
		((Form)this).Close();
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void rdbChart_Click(object sender, EventArgs e)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		if (!isShown)
		{
			return;
		}
		bOk = false;
		if (rdbChart.Checked)
		{
			frmUpdChart = new frmUpdRptChartResX();
			frmUpdChart.f_oTblData = oDtResult;
			ReportChartInfo f_oReportChartInfo = new ReportChartInfo();
			if (EditMode)
			{
				f_oReportChartInfo = AsiaErp.Framework.Environment.GetReportChartInformation(DashID.ToString());
			}
			frmUpdChart.f_oReportChartInfo = f_oReportChartInfo;
			((Form)frmUpdChart).ShowDialog((IWin32Window)(object)this);
			if (frmUpdChart.f_isOK)
			{
				bOk = true;
			}
		}
	}

	private void frmCreateDashlet_Shown(object sender, EventArgs e)
	{
		isShown = true;
	}
}
