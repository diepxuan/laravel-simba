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
public class frmChonHD : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("dgvChon")]
	private AsDataGridView _dgvChon;

	[AccessedThroughProperty("btnThoat")]
	private Button _btnThoat;

	[AccessedThroughProperty("btnChon")]
	private Button _btnChon;

	[AccessedThroughProperty("dgvcChkChon")]
	private DataGridViewCheckBoxColumn _dgvcChkChon;

	[AccessedThroughProperty("dgvcTen_loai")]
	private DataGridViewTextBoxColumn _dgvcTen_loai;

	[AccessedThroughProperty("dgvcMa_ph")]
	private DataGridViewTextBoxColumn _dgvcMa_ph;

	[AccessedThroughProperty("dgvcMau_so")]
	private DataGridViewTextBoxColumn _dgvcMau_so;

	[AccessedThroughProperty("dgvcSo_seri")]
	private DataGridViewTextBoxColumn _dgvcSo_seri;

	[AccessedThroughProperty("dgvcTu_so")]
	private DataGridViewTextBoxColumn _dgvcTu_so;

	[AccessedThroughProperty("dgvcDen_so")]
	private DataGridViewTextBoxColumn _dgvcDen_so;

	[AccessedThroughProperty("dgvcSo_luong")]
	private DataGridViewTextBoxColumn _dgvcSo_luong;

	internal DataTable f_oDthd;

	internal virtual AsDataGridView dgvChon
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvChon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvChon = value;
		}
	}

	internal virtual Button btnThoat
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnThoat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnThoat_Click;
			if (_btnThoat != null)
			{
				((Control)_btnThoat).Click -= eventHandler;
			}
			_btnThoat = value;
			if (_btnThoat != null)
			{
				((Control)_btnThoat).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnChon
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnChon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnChon_Click;
			if (_btnChon != null)
			{
				((Control)_btnChon).Click -= eventHandler;
			}
			_btnChon = value;
			if (_btnChon != null)
			{
				((Control)_btnChon).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcChkChon
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcChkChon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcChkChon = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_loai
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_loai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_loai = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_ph
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_ph;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_ph = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMau_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMau_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMau_so = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_seri
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_seri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_seri = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTu_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTu_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTu_so = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDen_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDen_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDen_so = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_luong = value;
		}
	}

	[DebuggerNonUserCode]
	public frmChonHD()
	{
		((Form)this).Load += frmChonHD_Load;
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
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		dgvChon = new AsDataGridView();
		btnThoat = new Button();
		btnChon = new Button();
		dgvcChkChon = new DataGridViewCheckBoxColumn();
		dgvcTen_loai = new DataGridViewTextBoxColumn();
		dgvcMa_ph = new DataGridViewTextBoxColumn();
		dgvcMau_so = new DataGridViewTextBoxColumn();
		dgvcSo_seri = new DataGridViewTextBoxColumn();
		dgvcTu_so = new DataGridViewTextBoxColumn();
		dgvcDen_so = new DataGridViewTextBoxColumn();
		dgvcSo_luong = new DataGridViewTextBoxColumn();
		((ISupportInitialize)dgvChon).BeginInit();
		((Control)this).SuspendLayout();
		((DataGridView)dgvChon).AllowUserToAddRows = false;
		((DataGridView)dgvChon).AllowUserToDeleteRows = false;
		((Control)dgvChon).Anchor = (AnchorStyles)15;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvChon).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)dgvChon).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvChon).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)dgvcChkChon,
			(DataGridViewColumn)dgvcTen_loai,
			(DataGridViewColumn)dgvcMa_ph,
			(DataGridViewColumn)dgvcMau_so,
			(DataGridViewColumn)dgvcSo_seri,
			(DataGridViewColumn)dgvcTu_so,
			(DataGridViewColumn)dgvcDen_so,
			(DataGridViewColumn)dgvcSo_luong
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvChon).DefaultCellStyle = val2;
		dgvChon.DoubleBuffered = false;
		((DataGridView)dgvChon).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvChon).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvChon;
		Point location = new Point(12, 12);
		((Control)asDataGridView).Location = location;
		((Control)dgvChon).Name = "dgvChon";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvChon).RowHeadersDefaultCellStyle = val3;
		((DataGridView)dgvChon).RowHeadersVisible = false;
		dgvChon.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvChon).RowTemplate.Height = 20;
		((DataGridView)dgvChon).ScrollBars = (ScrollBars)2;
		AsDataGridView asDataGridView2 = dgvChon;
		Size size = new Size(643, 287);
		((Control)asDataGridView2).Size = size;
		((Control)dgvChon).TabIndex = 7;
		((Control)btnThoat).Anchor = (AnchorStyles)10;
		Button obj = btnThoat;
		location = new Point(580, 305);
		((Control)obj).Location = location;
		((Control)btnThoat).Name = "btnThoat";
		Button obj2 = btnThoat;
		size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)btnThoat).TabIndex = 9;
		((ButtonBase)btnThoat).Text = "&Thoát";
		((ButtonBase)btnThoat).UseVisualStyleBackColor = true;
		((Control)btnChon).Anchor = (AnchorStyles)6;
		Button obj3 = btnChon;
		location = new Point(14, 305);
		((Control)obj3).Location = location;
		((Control)btnChon).Name = "btnChon";
		Button obj4 = btnChon;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)btnChon).TabIndex = 8;
		((ButtonBase)btnChon).Text = "&Chọn";
		((ButtonBase)btnChon).UseVisualStyleBackColor = true;
		((DataGridViewColumn)dgvcChkChon).HeaderText = "";
		((DataGridViewColumn)dgvcChkChon).Name = "dgvcChkChon";
		((DataGridViewColumn)dgvcChkChon).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcChkChon).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcChkChon).Width = 20;
		((DataGridViewColumn)dgvcTen_loai).DataPropertyName = "ten_loai";
		((DataGridViewColumn)dgvcTen_loai).HeaderText = "Tên loại hoá đơn";
		((DataGridViewColumn)dgvcTen_loai).Name = "dgvcTen_loai";
		((DataGridViewColumn)dgvcTen_loai).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_loai).Width = 250;
		((DataGridViewColumn)dgvcMa_ph).DataPropertyName = "ma_ph";
		((DataGridViewColumn)dgvcMa_ph).HeaderText = "Mã PH";
		((DataGridViewColumn)dgvcMa_ph).Name = "dgvcMa_ph";
		((DataGridViewColumn)dgvcMa_ph).Visible = false;
		((DataGridViewColumn)dgvcMau_so).DataPropertyName = "mau_so";
		((DataGridViewColumn)dgvcMau_so).HeaderText = "Mẫu Số";
		((DataGridViewColumn)dgvcMau_so).Name = "dgvcMau_so";
		((DataGridViewColumn)dgvcMau_so).ReadOnly = true;
		((DataGridViewColumn)dgvcMau_so).Width = 80;
		((DataGridViewColumn)dgvcSo_seri).DataPropertyName = "so_seri";
		((DataGridViewColumn)dgvcSo_seri).HeaderText = "Ký Hiệu";
		((DataGridViewColumn)dgvcSo_seri).Name = "dgvcSo_seri";
		((DataGridViewColumn)dgvcSo_seri).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_seri).Width = 70;
		((DataGridViewColumn)dgvcTu_so).DataPropertyName = "tu_so";
		((DataGridViewColumn)dgvcTu_so).HeaderText = "Từ Số";
		((DataGridViewColumn)dgvcTu_so).Name = "dgvcTu_so";
		((DataGridViewColumn)dgvcTu_so).ReadOnly = true;
		((DataGridViewColumn)dgvcTu_so).Width = 70;
		((DataGridViewColumn)dgvcDen_so).DataPropertyName = "den_so";
		((DataGridViewColumn)dgvcDen_so).HeaderText = "Đến Số";
		((DataGridViewColumn)dgvcDen_so).Name = "dgvcDen_so";
		((DataGridViewColumn)dgvcDen_so).ReadOnly = true;
		((DataGridViewColumn)dgvcDen_so).Width = 70;
		((DataGridViewColumn)dgvcSo_luong).DataPropertyName = "so_luong";
		((DataGridViewColumn)dgvcSo_luong).HeaderText = "Số Lượng";
		((DataGridViewColumn)dgvcSo_luong).Name = "dgvcSo_luong";
		((DataGridViewColumn)dgvcSo_luong).Width = 80;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(673, 339);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)dgvChon);
		((Control)this).Controls.Add((Control)(object)btnThoat);
		((Control)this).Controls.Add((Control)(object)btnChon);
		((Control)this).Name = "frmChonHD";
		((Form)this).Text = "Chọn hoá đơn cần huỷ";
		((ISupportInitialize)dgvChon).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmChonHD_Load(object sender, EventArgs e)
	{
		GetData();
	}

	private void btnThoat_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btnChon_Click(object sender, EventArgs e)
	{
		SetData();
		((Form)this).Close();
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

	protected void GetData()
	{
		SOND51HuyHDDAO sOND51HuyHDDAO = (SOND51HuyHDDAO)DAOFactory.CreateDAOInstance("SOND51HuyHDDAO", "SOND51HuyHD");
		DataTable data = sOND51HuyHDDAO.GetData();
		((DataGridView)dgvChon).DataSource = data;
		sOND51HuyHDDAO.Destroy();
	}

	protected void SetData()
	{
		frmSOND51HuyHDEdit frmSOND51HuyHDEdit2 = new frmSOND51HuyHDEdit();
		checked
		{
			int num = ((DataGridView)dgvChon).RowCount - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Conversions.ToBoolean(((DataGridView)dgvChon)["dgvcChkChon", i].Value))
				{
					DataRow dataRow = f_oDthd.NewRow();
					dataRow["ma_chung"] = Operators.ConcatenateObject(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcMau_so).Name, i].Value, ((DataGridView)dgvChon)[((DataGridViewColumn)dgvcMa_ph).Name, i].Value);
					dataRow["ten_loai"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcTen_loai).Name, i].Value);
					dataRow["mau_so"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcMau_so).Name, i].Value);
					dataRow["so_seri"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcSo_seri).Name, i].Value);
					dataRow["tu_so"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcTu_so).Name, i].Value);
					dataRow["den_so"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcDen_so).Name, i].Value);
					dataRow["so_luong"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcSo_luong).Name, i].Value);
					dataRow["lien_hd"] = "0";
					dataRow["ghi_chu"] = "";
					f_oDthd.Rows.Add(dataRow);
				}
			}
			((DataGridView)frmSOND51HuyHDEdit2.adgvHD).DataSource = f_oDthd;
		}
	}
}
