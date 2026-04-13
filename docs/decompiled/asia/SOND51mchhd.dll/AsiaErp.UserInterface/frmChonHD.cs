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
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmChonHD : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtNgay1")]
	private AsMaskedTextBox _txtNgay1;

	[AccessedThroughProperty("txtNgay2")]
	private AsMaskedTextBox _txtNgay2;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("btnChon")]
	private Button _btnChon;

	[AccessedThroughProperty("btnThoat")]
	private Button _btnThoat;

	[AccessedThroughProperty("dgvChon")]
	private AsDataGridView _dgvChon;

	[AccessedThroughProperty("chkChon")]
	private DataGridViewCheckBoxColumn _chkChon;

	[AccessedThroughProperty("loai_hd")]
	private DataGridViewTextBoxColumn _loai_hd;

	[AccessedThroughProperty("mau_so")]
	private DataGridViewTextBoxColumn _mau_so;

	[AccessedThroughProperty("so_seri")]
	private DataGridViewTextBoxColumn _so_seri;

	[AccessedThroughProperty("so_ct")]
	private DataGridViewTextBoxColumn _so_ct;

	[AccessedThroughProperty("ngay_ct")]
	private DataGridViewTextBoxColumn _ngay_ct;

	[AccessedThroughProperty("stt_rec")]
	private DataGridViewTextBoxColumn _stt_rec;

	internal DataTable f_oDthd;

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

	internal virtual AsMaskedTextBox txtNgay1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNgay1_Leave;
			if (_txtNgay1 != null)
			{
				((Control)_txtNgay1).Leave -= eventHandler;
			}
			_txtNgay1 = value;
			if (_txtNgay1 != null)
			{
				((Control)_txtNgay1).Leave += eventHandler;
			}
		}
	}

	internal virtual AsMaskedTextBox txtNgay2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNgay2_Leave;
			if (_txtNgay2 != null)
			{
				((Control)_txtNgay2).Leave -= eventHandler;
			}
			_txtNgay2 = value;
			if (_txtNgay2 != null)
			{
				((Control)_txtNgay2).Leave += eventHandler;
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

	internal virtual DataGridViewCheckBoxColumn chkChon
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkChon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkChon = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn loai_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _loai_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_loai_hd = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn mau_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _mau_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mau_so = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn so_seri
	{
		[DebuggerNonUserCode]
		get
		{
			return _so_seri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_so_seri = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn so_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _so_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_so_ct = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ngay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _ngay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ngay_ct = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn stt_rec
	{
		[DebuggerNonUserCode]
		get
		{
			return _stt_rec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_stt_rec = value;
		}
	}

	[DebuggerNonUserCode]
	public frmChonHD()
	{
		((Form)this).Load += frmChonHD_Load;
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
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
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		Label1 = new Label();
		txtNgay1 = new AsMaskedTextBox();
		txtNgay2 = new AsMaskedTextBox();
		Label2 = new Label();
		btnChon = new Button();
		btnThoat = new Button();
		dgvChon = new AsDataGridView();
		chkChon = new DataGridViewCheckBoxColumn();
		loai_hd = new DataGridViewTextBoxColumn();
		mau_so = new DataGridViewTextBoxColumn();
		so_seri = new DataGridViewTextBoxColumn();
		so_ct = new DataGridViewTextBoxColumn();
		ngay_ct = new DataGridViewTextBoxColumn();
		stt_rec = new DataGridViewTextBoxColumn();
		((ISupportInitialize)dgvChon).BeginInit();
		((Control)this).SuspendLayout();
		Label1.AutoSize = true;
		Label label = Label1;
		Point location = new Point(11, 16);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(63, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 0;
		Label1.Text = "Ngày HĐ từ";
		txtNgay1.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay1).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay1;
		location = new Point(78, 12);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay1).Mask = "##/##/####";
		((Control)txtNgay1).Name = "txtNgay1";
		((MaskedTextBox)txtNgay1).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		size = new Size(87, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay1).TabIndex = 1;
		((MaskedTextBox)txtNgay1).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay1;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtNgay2.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay2).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay2;
		location = new Point(221, 12);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay2).Mask = "##/##/####";
		((Control)txtNgay2).Name = "txtNgay2";
		((MaskedTextBox)txtNgay2).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay2;
		size = new Size(87, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay2).TabIndex = 2;
		((MaskedTextBox)txtNgay2).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay2;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(179, 16);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(26, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 3;
		Label2.Text = "đến";
		Button obj = btnChon;
		location = new Point(14, 299);
		((Control)obj).Location = location;
		((Control)btnChon).Name = "btnChon";
		Button obj2 = btnChon;
		size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)btnChon).TabIndex = 5;
		((ButtonBase)btnChon).Text = "&Chọn";
		((ButtonBase)btnChon).UseVisualStyleBackColor = true;
		Button obj3 = btnThoat;
		location = new Point(441, 299);
		((Control)obj3).Location = location;
		((Control)btnThoat).Name = "btnThoat";
		Button obj4 = btnThoat;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)btnThoat).TabIndex = 6;
		((ButtonBase)btnThoat).Text = "&Thoát";
		((ButtonBase)btnThoat).UseVisualStyleBackColor = true;
		((DataGridView)dgvChon).AllowUserToAddRows = false;
		((DataGridView)dgvChon).AllowUserToDeleteRows = false;
		((DataGridView)dgvChon).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvChon).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[7]
		{
			(DataGridViewColumn)chkChon,
			(DataGridViewColumn)loai_hd,
			(DataGridViewColumn)mau_so,
			(DataGridViewColumn)so_seri,
			(DataGridViewColumn)so_ct,
			(DataGridViewColumn)ngay_ct,
			(DataGridViewColumn)stt_rec
		});
		dgvChon.DoubleBuffered = false;
		((DataGridView)dgvChon).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvChon).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvChon;
		location = new Point(12, 38);
		((Control)asDataGridView).Location = location;
		((Control)dgvChon).Name = "dgvChon";
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvChon).RowHeadersDefaultCellStyle = val;
		((DataGridView)dgvChon).RowHeadersVisible = false;
		dgvChon.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvChon).RowTemplate.Height = 20;
		((DataGridView)dgvChon).ScrollBars = (ScrollBars)2;
		AsDataGridView asDataGridView2 = dgvChon;
		size = new Size(504, 255);
		((Control)asDataGridView2).Size = size;
		((Control)dgvChon).TabIndex = 4;
		((DataGridViewColumn)chkChon).HeaderText = "";
		((DataGridViewColumn)chkChon).Name = "chkChon";
		((DataGridViewColumn)chkChon).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)chkChon).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)chkChon).Width = 20;
		((DataGridViewColumn)loai_hd).DataPropertyName = "loai_hd";
		((DataGridViewColumn)loai_hd).HeaderText = "Loại Hoá Đơn";
		((DataGridViewColumn)loai_hd).Name = "loai_hd";
		((DataGridViewColumn)loai_hd).ReadOnly = true;
		((DataGridViewColumn)loai_hd).Width = 150;
		((DataGridViewColumn)mau_so).DataPropertyName = "mau_so";
		((DataGridViewColumn)mau_so).HeaderText = "Mẫu Số";
		((DataGridViewColumn)mau_so).Name = "mau_so";
		((DataGridViewColumn)mau_so).ReadOnly = true;
		((DataGridViewColumn)mau_so).Width = 80;
		((DataGridViewColumn)so_seri).DataPropertyName = "so_seri";
		((DataGridViewColumn)so_seri).HeaderText = "Ký Hiệu";
		((DataGridViewColumn)so_seri).Name = "so_seri";
		((DataGridViewColumn)so_seri).ReadOnly = true;
		((DataGridViewColumn)so_seri).Width = 80;
		((DataGridViewColumn)so_ct).DataPropertyName = "so_ct";
		((DataGridViewColumn)so_ct).HeaderText = "Số HĐ";
		((DataGridViewColumn)so_ct).Name = "so_ct";
		((DataGridViewColumn)so_ct).ReadOnly = true;
		((DataGridViewColumn)so_ct).Width = 80;
		((DataGridViewColumn)ngay_ct).DataPropertyName = "ngay_ct";
		((DataGridViewColumn)ngay_ct).HeaderText = "Ngày HĐ";
		((DataGridViewColumn)ngay_ct).Name = "ngay_ct";
		((DataGridViewColumn)ngay_ct).ReadOnly = true;
		((DataGridViewColumn)ngay_ct).Width = 90;
		((DataGridViewColumn)stt_rec).DataPropertyName = "stt_rec";
		((DataGridViewColumn)stt_rec).HeaderText = "STT_REC";
		((DataGridViewColumn)stt_rec).Name = "stt_rec";
		((DataGridViewColumn)stt_rec).Visible = false;
		((DataGridViewColumn)stt_rec).Width = 80;
		((Form)this).AcceptButton = (IButtonControl)(object)btnChon;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(529, 334);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)dgvChon);
		((Control)this).Controls.Add((Control)(object)btnThoat);
		((Control)this).Controls.Add((Control)(object)btnChon);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)txtNgay2);
		((Control)this).Controls.Add((Control)(object)txtNgay1);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Name = "frmChonHD";
		((Form)this).Text = "Chọn hoá đơn cần thông báo mất, cháy, hỏng";
		((ISupportInitialize)dgvChon).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmChonHD_Load(object sender, EventArgs e)
	{
		GetData(Conversions.ToString(txtNgay1.Value), Conversions.ToString(txtNgay2.Value));
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

	private void txtNgay1_Leave(object sender, EventArgs e)
	{
		GetData(Conversions.ToString(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(txtNgay1.Value))), Conversions.ToString(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(txtNgay2.Value))));
	}

	private void txtNgay2_Leave(object sender, EventArgs e)
	{
		GetData(Conversions.ToString(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(txtNgay1.Value))), Conversions.ToString(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(txtNgay2.Value))));
	}

	protected void GetData(string ngay1, string ngay2)
	{
		SOND51mchhdDAO sOND51mchhdDAO = (SOND51mchhdDAO)DAOFactory.CreateDAOInstance("SOMCHHDDAO", "SOMCHHD");
		DataTable data = sOND51mchhdDAO.GetData(ngay1, ngay2);
		((DataGridView)dgvChon).DataSource = data;
		sOND51mchhdDAO.Destroy();
	}

	protected void SetData()
	{
		frmSOND51mchhdEdit frmSOND51mchhdEdit2 = new frmSOND51mchhdEdit();
		checked
		{
			int num = ((DataGridView)dgvChon).RowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Conversions.ToBoolean(((DataGridView)dgvChon)["chkChon", num2].Value))
				{
					DataRow dataRow = f_oDthd.NewRow();
					dataRow["ma_chung"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)stt_rec).Name, num2].Value);
					dataRow["ma_loai"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)loai_hd).Name, num2].Value);
					dataRow["mau_so"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)mau_so).Name, num2].Value);
					dataRow["so_seri"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)so_seri).Name, num2].Value);
					dataRow["tu_so"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)so_ct).Name, num2].Value);
					dataRow["den_so"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)so_ct).Name, num2].Value);
					dataRow["so_luong"] = "1";
					dataRow["lien_hd"] = "0";
					dataRow["ghi_chu"] = "";
					f_oDthd.Rows.Add(dataRow);
				}
				num2++;
			}
			((DataGridView)frmSOND51mchhdEdit2.adgvHD).DataSource = f_oDthd;
		}
	}
}
