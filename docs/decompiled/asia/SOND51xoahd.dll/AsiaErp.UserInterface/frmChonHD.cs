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

	[AccessedThroughProperty("dgvcChkChon")]
	private DataGridViewCheckBoxColumn _dgvcChkChon;

	[AccessedThroughProperty("dgvcTen_loai")]
	private DataGridViewTextBoxColumn _dgvcTen_loai;

	[AccessedThroughProperty("dgvcMau_so")]
	private DataGridViewTextBoxColumn _dgvcMau_so;

	[AccessedThroughProperty("dgvcSo_seri")]
	private DataGridViewTextBoxColumn _dgvcSo_seri;

	[AccessedThroughProperty("dgvcSo_ct")]
	private DataGridViewTextBoxColumn _dgvcSo_ct;

	[AccessedThroughProperty("dgvcNgay_ct")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcNgay_ct;

	[AccessedThroughProperty("dgvcStt_rec")]
	private DataGridViewTextBoxColumn _dgvcStt_rec;

	[AccessedThroughProperty("epNotice")]
	private ErrorProvider _epNotice;

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

	internal virtual DataGridViewTextBoxColumn dgvcSo_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_ct = value;
		}
	}

	internal virtual DataGridViewAsMaskedTextBoxColumn dgvcNgay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcNgay_ct = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcStt_rec
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcStt_rec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcStt_rec = value;
		}
	}

	internal virtual ErrorProvider epNotice
	{
		[DebuggerNonUserCode]
		get
		{
			return _epNotice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_epNotice = value;
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
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		Label1 = new Label();
		txtNgay1 = new AsMaskedTextBox();
		txtNgay2 = new AsMaskedTextBox();
		Label2 = new Label();
		btnChon = new Button();
		btnThoat = new Button();
		dgvChon = new AsDataGridView();
		dgvcChkChon = new DataGridViewCheckBoxColumn();
		dgvcTen_loai = new DataGridViewTextBoxColumn();
		dgvcMau_so = new DataGridViewTextBoxColumn();
		dgvcSo_seri = new DataGridViewTextBoxColumn();
		dgvcSo_ct = new DataGridViewTextBoxColumn();
		dgvcNgay_ct = new DataGridViewAsMaskedTextBoxColumn();
		dgvcStt_rec = new DataGridViewTextBoxColumn();
		epNotice = new ErrorProvider(components);
		((ISupportInitialize)dgvChon).BeginInit();
		((ISupportInitialize)epNotice).BeginInit();
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
		((Control)btnChon).Anchor = (AnchorStyles)6;
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
		((Control)btnThoat).Anchor = (AnchorStyles)10;
		Button obj3 = btnThoat;
		location = new Point(533, 299);
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
		((DataGridView)dgvChon).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[7]
		{
			(DataGridViewColumn)dgvcChkChon,
			(DataGridViewColumn)dgvcTen_loai,
			(DataGridViewColumn)dgvcMau_so,
			(DataGridViewColumn)dgvcSo_seri,
			(DataGridViewColumn)dgvcSo_ct,
			dgvcNgay_ct,
			(DataGridViewColumn)dgvcStt_rec
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
		location = new Point(14, 38);
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
		AsDataGridView asDataGridView2 = dgvChon;
		size = new Size(594, 255);
		((Control)asDataGridView2).Size = size;
		((Control)dgvChon).TabIndex = 7;
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
		((DataGridViewColumn)dgvcMau_so).DataPropertyName = "mau_so";
		((DataGridViewColumn)dgvcMau_so).HeaderText = "Mẫu số";
		((DataGridViewColumn)dgvcMau_so).Name = "dgvcMau_so";
		((DataGridViewColumn)dgvcMau_so).ReadOnly = true;
		((DataGridViewColumn)dgvcMau_so).Width = 80;
		((DataGridViewColumn)dgvcSo_seri).DataPropertyName = "so_seri";
		((DataGridViewColumn)dgvcSo_seri).HeaderText = "Ký hiệu";
		((DataGridViewColumn)dgvcSo_seri).Name = "dgvcSo_seri";
		((DataGridViewColumn)dgvcSo_seri).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_seri).Width = 80;
		((DataGridViewColumn)dgvcSo_ct).DataPropertyName = "so_ct";
		((DataGridViewColumn)dgvcSo_ct).HeaderText = "Số HĐ";
		((DataGridViewColumn)dgvcSo_ct).Name = "dgvcSo_ct";
		((DataGridViewColumn)dgvcSo_ct).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_ct).Width = 80;
		((DataGridViewColumn)dgvcNgay_ct).DataPropertyName = "ngay_ct";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct).DefaultCellStyle = val4;
		dgvcNgay_ct.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct).HeaderText = "Ngày HĐ";
		dgvcNgay_ct.Mask = "##/##/####";
		((DataGridViewColumn)dgvcNgay_ct).Name = "dgvcNgay_ct";
		((DataGridViewColumn)dgvcNgay_ct).ReadOnly = true;
		((DataGridViewColumn)dgvcNgay_ct).Resizable = (DataGridViewTriState)1;
		dgvcNgay_ct.SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcNgay_ct).Width = 80;
		((DataGridViewColumn)dgvcStt_rec).DataPropertyName = "stt_rec";
		((DataGridViewColumn)dgvcStt_rec).HeaderText = "STT_REC";
		((DataGridViewColumn)dgvcStt_rec).Name = "dgvcStt_rec";
		((DataGridViewColumn)dgvcStt_rec).Visible = false;
		((DataGridViewColumn)dgvcStt_rec).Width = 80;
		epNotice.ContainerControl = (ContainerControl)(object)this;
		((Form)this).AcceptButton = (IButtonControl)(object)btnChon;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(620, 334);
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
		((ISupportInitialize)epNotice).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmChonHD_Load(object sender, EventArgs e)
	{
		((MaskedTextBox)txtNgay1).Text = "01/01" + Conversions.ToString(SystemInformations.FinancialYear);
		txtNgay2.Value = DateTime.Now;
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
		if (ValidData())
		{
			GetData(Conversions.ToString(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(txtNgay1.Value))), Conversions.ToString(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(txtNgay2.Value))));
		}
	}

	private void txtNgay2_Leave(object sender, EventArgs e)
	{
		if (ValidData())
		{
			GetData(Conversions.ToString(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(txtNgay1.Value))), Conversions.ToString(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(txtNgay2.Value))));
		}
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

	protected bool ValidData()
	{
		if (Operators.CompareString(((MaskedTextBox)txtNgay1).Text, "", false) != 0 && ((Operators.CompareString(((MaskedTextBox)txtNgay1).Text, "01/01/1900", false) < 0) | (Operators.CompareString(((MaskedTextBox)txtNgay1).Text, "06/06/2079", false) > 0)))
		{
			epNotice.SetError((Control)(object)txtNgay1, Helper.GetMess(50013).Description);
			((Control)txtNgay1).Select();
			return false;
		}
		if (Operators.CompareString(((MaskedTextBox)txtNgay2).Text, "", false) != 0 && ((Operators.CompareString(((MaskedTextBox)txtNgay2).Text, "01/01/1900", false) < 0) | (Operators.CompareString(((MaskedTextBox)txtNgay1).Text, "06/06/2079", false) > 0)))
		{
			epNotice.SetError((Control)(object)txtNgay2, Helper.GetMess(50013).Description);
			((Control)txtNgay2).Select();
			return false;
		}
		return true;
	}

	protected void GetData(string ngay1, string ngay2)
	{
		SOND51xoahdDAO sOND51xoahdDAO = (SOND51xoahdDAO)DAOFactory.CreateDAOInstance("SOND51xoahdDAO", "SOND51xoahd");
		DataTable data = sOND51xoahdDAO.GetData(ngay1, ngay2);
		((DataGridView)dgvChon).DataSource = data;
		sOND51xoahdDAO.Destroy();
	}

	protected void SetData()
	{
		frmSOND51xoahdEdit frmSOND51xoahdEdit2 = new frmSOND51xoahdEdit();
		checked
		{
			int num = ((DataGridView)dgvChon).RowCount - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Conversions.ToBoolean(((DataGridView)dgvChon)["dgvcChkChon", i].Value) && ChkData(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcStt_rec).Name, i].Value.ToString(), f_oDthd))
				{
					DataRow dataRow = f_oDthd.NewRow();
					dataRow["ma_chung"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcStt_rec).Name, i].Value);
					dataRow["ten_loai"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcTen_loai).Name, i].Value);
					dataRow["mau_so"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcMau_so).Name, i].Value);
					dataRow["so_seri"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcSo_seri).Name, i].Value);
					dataRow["tu_so"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcSo_ct).Name, i].Value);
					dataRow["den_so"] = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChon)[((DataGridViewColumn)dgvcSo_ct).Name, i].Value);
					dataRow["so_luong"] = "1";
					dataRow["lien_hd"] = "0";
					dataRow["ghi_chu"] = "";
					f_oDthd.Rows.Add(dataRow);
				}
			}
			((DataGridView)frmSOND51xoahdEdit2.adgvHD).DataSource = f_oDthd;
		}
	}

	protected bool ChkData(string stt_rec, DataTable dt)
	{
		dt.AcceptChanges();
		foreach (DataRow row in dt.Rows)
		{
			if (Operators.ConditionalCompareObjectEqual(row["ma_chung"], (object)stt_rec, false))
			{
				return false;
			}
		}
		return true;
	}
}
