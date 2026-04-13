using System;
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

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLPost2DGTG : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("lblKDG")]
	private Label _lblKDG;

	[AccessedThroughProperty("txtNgay1")]
	private AsMaskedTextBox _txtNgay1;

	[AccessedThroughProperty("txtNgay2")]
	private AsMaskedTextBox _txtNgay2;

	[AccessedThroughProperty("cboKyBc")]
	private AsComboBox _cboKyBc;

	[AccessedThroughProperty("lblSeparate")]
	private Label _lblSeparate;

	[AccessedThroughProperty("lblMa_nt")]
	private Label _lblMa_nt;

	[AccessedThroughProperty("dgvDGTG")]
	private AsDataGridView _dgvDGTG;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("cmdDG")]
	private Button _cmdDG;

	[AccessedThroughProperty("cmdDeleteDG")]
	private Button _cmdDeleteDG;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("chkSelectAll")]
	private AsCheckBox _chkSelectAll;

	[AccessedThroughProperty("cboMa_nt")]
	private AsComboBox _cboMa_nt;

	[AccessedThroughProperty("lblTen_nt")]
	private Label _lblTen_nt;

	[AccessedThroughProperty("colChon")]
	private DataGridViewCheckBoxColumn _colChon;

	[AccessedThroughProperty("colLoai_DG")]
	private DataGridViewTextBoxColumn _colLoai_DG;

	[AccessedThroughProperty("colTenBT")]
	private DataGridViewTextBoxColumn _colTenBT;

	[AccessedThroughProperty("colSo_ct")]
	private DataGridViewTextBoxColumn _colSo_ct;

	[AccessedThroughProperty("colTK_dgtg")]
	private DataGridViewTextBoxColumn _colTK_dgtg;

	[AccessedThroughProperty("dgvcMa_nt")]
	private DataGridViewAsTextBoxColumn _dgvcMa_nt;

	[AccessedThroughProperty("colTKLaiCLTG")]
	private DataGridViewTextBoxColumn _colTKLaiCLTG;

	[AccessedThroughProperty("colTKLoCLTG")]
	private DataGridViewTextBoxColumn _colTKLoCLTG;

	[AccessedThroughProperty("colTKCLTGCN")]
	private DataGridViewTextBoxColumn _colTKCLTGCN;

	[AccessedThroughProperty("colDGKH")]
	private DataGridViewCheckBoxColumn _colDGKH;

	[AccessedThroughProperty("colDGBP")]
	private DataGridViewCheckBoxColumn _colDGBP;

	[AccessedThroughProperty("colDGHD")]
	private DataGridViewCheckBoxColumn _colDGHD;

	[AccessedThroughProperty("colDGSPCT")]
	private DataGridViewCheckBoxColumn _colDGSPCT;

	[AccessedThroughProperty("colDGPhi")]
	private DataGridViewCheckBoxColumn _colDGPhi;

	[AccessedThroughProperty("colKSD")]
	private DataGridViewCheckBoxColumn _colKSD;

	private DataTable f_tblDG;

	internal virtual Label lblKDG
	{
		get
		{
			return _lblKDG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblKDG = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay1
	{
		get
		{
			return _txtNgay1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNgay1 = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay2
	{
		get
		{
			return _txtNgay2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNgay2 = value;
		}
	}

	internal virtual AsComboBox cboKyBc
	{
		get
		{
			return _cboKyBc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboKyBc_SelectedValueChanged;
			if (_cboKyBc != null)
			{
				((ListControl)_cboKyBc).SelectedValueChanged -= eventHandler;
			}
			_cboKyBc = value;
			if (_cboKyBc != null)
			{
				((ListControl)_cboKyBc).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblSeparate
	{
		get
		{
			return _lblSeparate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblSeparate = value;
		}
	}

	internal virtual Label lblMa_nt
	{
		get
		{
			return _lblMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_nt = value;
		}
	}

	internal virtual AsDataGridView dgvDGTG
	{
		get
		{
			return _dgvDGTG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvDGTG = value;
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

	internal virtual Button cmdDG
	{
		get
		{
			return _cmdDG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdDG_Click;
			if (_cmdDG != null)
			{
				((Control)_cmdDG).Click -= eventHandler;
			}
			_cmdDG = value;
			if (_cmdDG != null)
			{
				((Control)_cmdDG).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdDeleteDG
	{
		get
		{
			return _cmdDeleteDG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdDeleteDG_Click;
			if (_cmdDeleteDG != null)
			{
				((Control)_cmdDeleteDG).Click -= eventHandler;
			}
			_cmdDeleteDG = value;
			if (_cmdDeleteDG != null)
			{
				((Control)_cmdDeleteDG).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdCancel
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

	internal virtual AsCheckBox chkSelectAll
	{
		get
		{
			return _chkSelectAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = chkSelectAll_CheckedChanged;
			if (_chkSelectAll != null)
			{
				((CheckBox)_chkSelectAll).CheckedChanged -= eventHandler;
			}
			_chkSelectAll = value;
			if (_chkSelectAll != null)
			{
				((CheckBox)_chkSelectAll).CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual AsComboBox cboMa_nt
	{
		get
		{
			return _cboMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboMa_nt_SelectedIndexChanged;
			if (_cboMa_nt != null)
			{
				((ComboBox)_cboMa_nt).SelectedIndexChanged -= eventHandler;
			}
			_cboMa_nt = value;
			if (_cboMa_nt != null)
			{
				((ComboBox)_cboMa_nt).SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblTen_nt
	{
		get
		{
			return _lblTen_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_nt = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colChon
	{
		get
		{
			return _colChon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colChon = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colLoai_DG
	{
		get
		{
			return _colLoai_DG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colLoai_DG = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colTenBT
	{
		get
		{
			return _colTenBT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTenBT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colSo_ct
	{
		get
		{
			return _colSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colSo_ct = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colTK_dgtg
	{
		get
		{
			return _colTK_dgtg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTK_dgtg = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_nt
	{
		get
		{
			return _dgvcMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcMa_nt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colTKLaiCLTG
	{
		get
		{
			return _colTKLaiCLTG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTKLaiCLTG = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colTKLoCLTG
	{
		get
		{
			return _colTKLoCLTG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTKLoCLTG = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colTKCLTGCN
	{
		get
		{
			return _colTKCLTGCN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTKCLTGCN = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colDGKH
	{
		get
		{
			return _colDGKH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colDGKH = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colDGBP
	{
		get
		{
			return _colDGBP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colDGBP = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colDGHD
	{
		get
		{
			return _colDGHD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colDGHD = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colDGSPCT
	{
		get
		{
			return _colDGSPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colDGSPCT = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colDGPhi
	{
		get
		{
			return _colDGPhi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colDGPhi = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colKSD
	{
		get
		{
			return _colKSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colKSD = value;
		}
	}

	public frmGLPost2DGTG(string MenuID)
		: base(MenuID)
	{
		((Form)this).Load += frmGLPost2DGTG_Load;
		f_tblDG = new DataTable();
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		lblKDG = new Label();
		txtNgay1 = new AsMaskedTextBox();
		txtNgay2 = new AsMaskedTextBox();
		cboKyBc = new AsComboBox();
		lblSeparate = new Label();
		lblMa_nt = new Label();
		dgvDGTG = new AsDataGridView();
		GroupBox1 = new GroupBox();
		cmdDG = new Button();
		cmdDeleteDG = new Button();
		cmdCancel = new Button();
		chkSelectAll = new AsCheckBox();
		cboMa_nt = new AsComboBox();
		lblTen_nt = new Label();
		colChon = new DataGridViewCheckBoxColumn();
		colLoai_DG = new DataGridViewTextBoxColumn();
		colTenBT = new DataGridViewTextBoxColumn();
		colSo_ct = new DataGridViewTextBoxColumn();
		colTK_dgtg = new DataGridViewTextBoxColumn();
		dgvcMa_nt = new DataGridViewAsTextBoxColumn();
		colTKLaiCLTG = new DataGridViewTextBoxColumn();
		colTKLoCLTG = new DataGridViewTextBoxColumn();
		colTKCLTGCN = new DataGridViewTextBoxColumn();
		colDGKH = new DataGridViewCheckBoxColumn();
		colDGBP = new DataGridViewCheckBoxColumn();
		colDGHD = new DataGridViewCheckBoxColumn();
		colDGSPCT = new DataGridViewCheckBoxColumn();
		colDGPhi = new DataGridViewCheckBoxColumn();
		colKSD = new DataGridViewCheckBoxColumn();
		((ISupportInitialize)dgvDGTG).BeginInit();
		((Control)this).SuspendLayout();
		lblKDG.AutoSize = true;
		Label obj = lblKDG;
		Point location = new Point(10, 16);
		((Control)obj).Location = location;
		((Control)lblKDG).Name = "lblKDG";
		Label obj2 = lblKDG;
		Size size = new Size(64, 13);
		((Control)obj2).Size = size;
		((Control)lblKDG).TabIndex = 0;
		lblKDG.Text = "Kỳ đánh giá";
		txtNgay1.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay1).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay1;
		location = new Point(219, 12);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay1).Mask = "##/##/####";
		((Control)txtNgay1).Name = "txtNgay1";
		((MaskedTextBox)txtNgay1).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		size = new Size(85, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay1).TabIndex = 1;
		((MaskedTextBox)txtNgay1).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay1;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtNgay2.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay2).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay2;
		location = new Point(321, 12);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay2).Mask = "##/##/####";
		((Control)txtNgay2).Name = "txtNgay2";
		((MaskedTextBox)txtNgay2).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay2;
		size = new Size(85, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay2).TabIndex = 1;
		((MaskedTextBox)txtNgay2).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay2;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		((ComboBox)cboKyBc).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyBc).FormattingEnabled = true;
		AsComboBox asComboBox = cboKyBc;
		location = new Point(80, 12);
		((Control)asComboBox).Location = location;
		((Control)cboKyBc).Name = "cboKyBc";
		AsComboBox asComboBox2 = cboKyBc;
		size = new Size(121, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboKyBc).TabIndex = 2;
		lblSeparate.AutoSize = true;
		Label obj3 = lblSeparate;
		location = new Point(308, 16);
		((Control)obj3).Location = location;
		((Control)lblSeparate).Name = "lblSeparate";
		Label obj4 = lblSeparate;
		size = new Size(10, 13);
		((Control)obj4).Size = size;
		((Control)lblSeparate).TabIndex = 3;
		lblSeparate.Text = "-";
		lblMa_nt.AutoSize = true;
		Label obj5 = lblMa_nt;
		location = new Point(456, 16);
		((Control)obj5).Location = location;
		((Control)lblMa_nt).Name = "lblMa_nt";
		Label obj6 = lblMa_nt;
		size = new Size(40, 13);
		((Control)obj6).Size = size;
		((Control)lblMa_nt).TabIndex = 0;
		lblMa_nt.Text = "Mã NT";
		((Control)lblMa_nt).Visible = false;
		((DataGridView)dgvDGTG).AllowUserToAddRows = false;
		((DataGridView)dgvDGTG).AllowUserToDeleteRows = false;
		((Control)dgvDGTG).Anchor = (AnchorStyles)15;
		((DataGridView)dgvDGTG).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvDGTG).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvDGTG).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		((DataGridView)dgvDGTG).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvDGTG).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[15]
		{
			(DataGridViewColumn)colChon,
			(DataGridViewColumn)colLoai_DG,
			(DataGridViewColumn)colTenBT,
			(DataGridViewColumn)colSo_ct,
			(DataGridViewColumn)colTK_dgtg,
			dgvcMa_nt,
			(DataGridViewColumn)colTKLaiCLTG,
			(DataGridViewColumn)colTKLoCLTG,
			(DataGridViewColumn)colTKCLTGCN,
			(DataGridViewColumn)colDGKH,
			(DataGridViewColumn)colDGBP,
			(DataGridViewColumn)colDGHD,
			(DataGridViewColumn)colDGSPCT,
			(DataGridViewColumn)colDGPhi,
			(DataGridViewColumn)colKSD
		});
		dgvDGTG.DoubleBuffered = false;
		((DataGridView)dgvDGTG).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvDGTG).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvDGTG;
		location = new Point(10, 72);
		((Control)asDataGridView).Location = location;
		((Control)dgvDGTG).Name = "dgvDGTG";
		((DataGridView)dgvDGTG).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDGTG).RowHeadersDefaultCellStyle = val;
		dgvDGTG.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvDGTG).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvDGTG;
		size = new Size(847, 349);
		((Control)asDataGridView2).Size = size;
		((Control)dgvDGTG).TabIndex = 5;
		((Control)GroupBox1).Anchor = (AnchorStyles)14;
		GroupBox groupBox = GroupBox1;
		location = new Point(-3, 427);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(871, 10);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 6;
		GroupBox1.TabStop = false;
		((Control)cmdDG).Anchor = (AnchorStyles)6;
		Button obj7 = cmdDG;
		location = new Point(10, 446);
		((Control)obj7).Location = location;
		((Control)cmdDG).Name = "cmdDG";
		Button obj8 = cmdDG;
		size = new Size(75, 23);
		((Control)obj8).Size = size;
		((Control)cmdDG).TabIndex = 1;
		((ButtonBase)cmdDG).Text = "&Đánh giá";
		((ButtonBase)cmdDG).UseVisualStyleBackColor = true;
		((Control)cmdDeleteDG).Anchor = (AnchorStyles)6;
		Button obj9 = cmdDeleteDG;
		location = new Point(93, 446);
		((Control)obj9).Location = location;
		((Control)cmdDeleteDG).Name = "cmdDeleteDG";
		Button obj10 = cmdDeleteDG;
		size = new Size(75, 23);
		((Control)obj10).Size = size;
		((Control)cmdDeleteDG).TabIndex = 2;
		((ButtonBase)cmdDeleteDG).Text = "&Xóa ĐG";
		((ButtonBase)cmdDeleteDG).UseVisualStyleBackColor = true;
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		Button obj11 = cmdCancel;
		location = new Point(174, 446);
		((Control)obj11).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj12 = cmdCancel;
		size = new Size(75, 23);
		((Control)obj12).Size = size;
		((Control)cmdCancel).TabIndex = 3;
		((ButtonBase)cmdCancel).Text = "&Quay ra";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = true;
		((ButtonBase)chkSelectAll).AutoSize = true;
		chkSelectAll.Checked = false;
		AsCheckBox asCheckBox = chkSelectAll;
		location = new Point(10, 49);
		((Control)asCheckBox).Location = location;
		((Control)chkSelectAll).Name = "chkSelectAll";
		AsCheckBox asCheckBox2 = chkSelectAll;
		size = new Size(136, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkSelectAll).TabIndex = 8;
		((ButtonBase)chkSelectAll).Text = "Chọn / hủy chọn tất cả";
		chkSelectAll.TextValue = "0";
		((ButtonBase)chkSelectAll).UseVisualStyleBackColor = true;
		((ComboBox)cboMa_nt).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMa_nt).FormattingEnabled = true;
		AsComboBox asComboBox3 = cboMa_nt;
		location = new Point(502, 12);
		((Control)asComboBox3).Location = location;
		((Control)cboMa_nt).Name = "cboMa_nt";
		AsComboBox asComboBox4 = cboMa_nt;
		size = new Size(78, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboMa_nt).TabIndex = 0;
		((Control)cboMa_nt).Visible = false;
		Label obj13 = lblTen_nt;
		location = new Point(601, 15);
		((Control)obj13).Location = location;
		((Control)lblTen_nt).Name = "lblTen_nt";
		Label obj14 = lblTen_nt;
		size = new Size(197, 15);
		((Control)obj14).Size = size;
		((Control)lblTen_nt).TabIndex = 9;
		((Control)lblTen_nt).Visible = false;
		((DataGridViewColumn)colChon).DataPropertyName = "chon";
		((DataGridViewColumn)colChon).HeaderText = "Chọn";
		((DataGridViewColumn)colChon).Name = "colChon";
		((DataGridViewColumn)colChon).Width = 60;
		((DataGridViewColumn)colLoai_DG).DataPropertyName = "loai_dg";
		((DataGridViewColumn)colLoai_DG).HeaderText = "Loại ĐG";
		((DataGridViewColumn)colLoai_DG).Name = "colLoai_DG";
		((DataGridViewColumn)colLoai_DG).ReadOnly = true;
		((DataGridViewColumn)colLoai_DG).Width = 80;
		((DataGridViewColumn)colTenBT).DataPropertyName = "ten_bt";
		((DataGridViewColumn)colTenBT).HeaderText = "Tên BT";
		((DataGridViewColumn)colTenBT).Name = "colTenBT";
		((DataGridViewColumn)colTenBT).ReadOnly = true;
		((DataGridViewColumn)colTenBT).Width = 120;
		((DataGridViewColumn)colSo_ct).DataPropertyName = "so_ct";
		((DataGridViewColumn)colSo_ct).HeaderText = "Số CT";
		((DataGridViewColumn)colSo_ct).Name = "colSo_ct";
		((DataGridViewColumn)colSo_ct).ReadOnly = true;
		((DataGridViewColumn)colTK_dgtg).DataPropertyName = "tk_dgtg";
		((DataGridViewColumn)colTK_dgtg).HeaderText = "TK ĐGTG";
		((DataGridViewColumn)colTK_dgtg).Name = "colTK_dgtg";
		((DataGridViewColumn)colTK_dgtg).ReadOnly = true;
		((DataGridViewColumn)colTK_dgtg).Width = 120;
		dgvcMa_nt.AutoFill = false;
		dgvcMa_nt.AutoLookup = false;
		dgvcMa_nt.AutoValid = false;
		((DataGridViewColumn)dgvcMa_nt).DataPropertyName = "Ma_nt";
		val2.BackColor = SystemColors.Window;
		((DataGridViewColumn)dgvcMa_nt).DefaultCellStyle = val2;
		((DataGridViewColumn)dgvcMa_nt).HeaderText = "Mã NT";
		dgvcMa_nt.LookupCodeName = "";
		dgvcMa_nt.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_nt).Name = "dgvcMa_nt";
		((DataGridViewColumn)dgvcMa_nt).ReadOnly = true;
		dgvcMa_nt.ReceiverValidFieldList = "";
		dgvcMa_nt.SD = false;
		dgvcMa_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_nt.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcMa_nt).Width = 50;
		((DataGridViewColumn)colTKLaiCLTG).DataPropertyName = "tk_lai_cltg";
		((DataGridViewColumn)colTKLaiCLTG).HeaderText = "TK Lãi CLTG cuối kỳ";
		((DataGridViewColumn)colTKLaiCLTG).Name = "colTKLaiCLTG";
		((DataGridViewColumn)colTKLaiCLTG).ReadOnly = true;
		((DataGridViewColumn)colTKLaiCLTG).Width = 160;
		((DataGridViewColumn)colTKLoCLTG).DataPropertyName = "tk_lo_cltg";
		((DataGridViewColumn)colTKLoCLTG).HeaderText = "TK Lỗ CLTG cuối kỳ";
		((DataGridViewColumn)colTKLoCLTG).Name = "colTKLoCLTG";
		((DataGridViewColumn)colTKLoCLTG).ReadOnly = true;
		((DataGridViewColumn)colTKLoCLTG).Width = 160;
		((DataGridViewColumn)colTKCLTGCN).DataPropertyName = "tk_cltg_cn";
		((DataGridViewColumn)colTKCLTGCN).HeaderText = "TK CLTG cuối năm";
		((DataGridViewColumn)colTKCLTGCN).Name = "colTKCLTGCN";
		((DataGridViewColumn)colTKCLTGCN).ReadOnly = true;
		((DataGridViewColumn)colTKCLTGCN).Width = 160;
		((DataGridViewColumn)colDGKH).DataPropertyName = "dg_kh";
		((DataGridViewColumn)colDGKH).HeaderText = "ĐG khách hàng";
		((DataGridViewColumn)colDGKH).Name = "colDGKH";
		((DataGridViewColumn)colDGKH).ReadOnly = true;
		((DataGridViewColumn)colDGKH).Width = 120;
		((DataGridViewColumn)colDGBP).DataPropertyName = "dg_bp";
		((DataGridViewColumn)colDGBP).HeaderText = "Đánh giá bộ phận";
		((DataGridViewColumn)colDGBP).Name = "colDGBP";
		((DataGridViewColumn)colDGBP).ReadOnly = true;
		((DataGridViewColumn)colDGBP).Width = 120;
		((DataGridViewColumn)colDGHD).DataPropertyName = "dg_hd";
		((DataGridViewColumn)colDGHD).HeaderText = "Đánh giá hợp đồng";
		((DataGridViewColumn)colDGHD).Name = "colDGHD";
		((DataGridViewColumn)colDGHD).ReadOnly = true;
		((DataGridViewColumn)colDGHD).Width = 120;
		((DataGridViewColumn)colDGSPCT).DataPropertyName = "dg_spct";
		((DataGridViewColumn)colDGSPCT).HeaderText = "Đánh giá SPCT";
		((DataGridViewColumn)colDGSPCT).Name = "colDGSPCT";
		((DataGridViewColumn)colDGSPCT).ReadOnly = true;
		((DataGridViewColumn)colDGSPCT).Width = 120;
		((DataGridViewColumn)colDGPhi).DataPropertyName = "dg_phi";
		((DataGridViewColumn)colDGPhi).HeaderText = "Đánh giá phí";
		((DataGridViewColumn)colDGPhi).Name = "colDGPhi";
		((DataGridViewColumn)colDGPhi).ReadOnly = true;
		((DataGridViewColumn)colDGPhi).Width = 120;
		((DataGridViewColumn)colKSD).DataPropertyName = "ksd";
		((DataGridViewColumn)colKSD).HeaderText = "KSD";
		((DataGridViewColumn)colKSD).Name = "colKSD";
		((DataGridViewColumn)colKSD).ReadOnly = true;
		((DataGridViewColumn)colKSD).Visible = false;
		((DataGridViewColumn)colKSD).Width = 80;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(867, 479);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)lblTen_nt);
		((Control)this).Controls.Add((Control)(object)cboMa_nt);
		((Control)this).Controls.Add((Control)(object)chkSelectAll);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdDeleteDG);
		((Control)this).Controls.Add((Control)(object)cmdDG);
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)dgvDGTG);
		((Control)this).Controls.Add((Control)(object)lblSeparate);
		((Control)this).Controls.Add((Control)(object)cboKyBc);
		((Control)this).Controls.Add((Control)(object)txtNgay2);
		((Control)this).Controls.Add((Control)(object)txtNgay1);
		((Control)this).Controls.Add((Control)(object)lblMa_nt);
		((Control)this).Controls.Add((Control)(object)lblKDG);
		((Control)this).Name = "frmGLPost2DGTG";
		((Form)this).Text = "Đánh giá tỷ giá cuối kỳ";
		((ISupportInitialize)dgvDGTG).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void InitCboNt()
	{
		((ListControl)cboMa_nt).DisplayMember = "ma_nt";
		((ListControl)cboMa_nt).ValueMember = "ma_nt";
		((ComboBox)cboMa_nt).DataSource = (from object nt in AsiaErp.Framework.Environment.GetDMNT()
			select (DMNTInformation)nt into nt
			where Operators.CompareString(nt.ma_nt, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) != 0
			select (nt)).ToList();
	}

	private void GetData()
	{
		IGLPost2DGTGDAO iGLPost2DGTGDAO = (IGLPost2DGTGDAO)DAOFactory.CreateDAOInstance("GLPost2DGTGDAO", "GLPost2DGTG");
		f_tblDG = iGLPost2DGTGDAO.GetData();
		f_tblDG.Columns.Add(new DataColumn("chon", typeof(bool)));
		f_tblDG.DefaultView.RowFilter = "ksd = 0";
		((DataGridView)dgvDGTG).DataSource = f_tblDG.DefaultView;
		iGLPost2DGTGDAO.Destroy();
	}

	private void cboKyBc_SelectedValueChanged(object sender, EventArgs e)
	{
		if (((ComboBox)cboKyBc).DataSource != null)
		{
			if (((ComboBox)cboKyBc).SelectedItem == null)
			{
				((ComboBox)cboKyBc).SelectedIndex = 0;
			}
			txtNgay1.Value = ((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ngay1;
			txtNgay2.Value = ((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ngay2;
			((MaskedTextBox)txtNgay1).ReadOnly = true;
			((Control)txtNgay1).TabStop = false;
			((MaskedTextBox)txtNgay2).ReadOnly = true;
			((Control)txtNgay2).TabStop = false;
		}
	}

	private void InitKyBaoCao()
	{
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
		((ComboBox)cboKyBc).DataSource = (from object kbc in AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc)
			select (KyBaoCao)kbc into kbc
			where Operators.CompareString(kbc.ma, "NGAY", false) != 0
			select (kbc)).ToList();
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"", false))
		{
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"NGAY", false))
			{
				try
				{
					txtNgay1.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct1"));
					txtNgay2.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct2"));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			((ListControl)cboKyBc).SelectedValue = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao"));
		}
		else
		{
			((ComboBox)cboKyBc).SelectedIndex = 0;
		}
	}

	private void SaveKyBaoCao()
	{
		AsiaErp.Framework.Environment.set_PublicVariables("KyBaoCao", (object)((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ma);
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
	}

	private void frmGLPost2DGTG_Load(object sender, EventArgs e)
	{
		((DataGridView)dgvDGTG).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
		InitKyBaoCao();
		GetData();
		InitCboNt();
	}

	private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
	{
		foreach (DataRow row in f_tblDG.Rows)
		{
			row["chon"] = RuntimeHelpers.GetObjectValue(chkSelectAll.Checked);
		}
	}

	private void cboMa_nt_SelectedIndexChanged(object sender, EventArgs e)
	{
		lblTen_nt.Text = ((DMNTInformation)((ComboBox)cboMa_nt).SelectedItem).ten_nt;
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Component)(object)this).Dispose();
	}

	private void cmdDeleteDG_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		DataRow[] array = f_tblDG.Select("chon=1", "", DataViewRowState.ModifiedCurrent);
		if (array.Count() == 0)
		{
			CMessageBox.Show(50061);
			return;
		}
		bool flag = true;
		IGLPost2DGTGDAO iGLPost2DGTGDAO = (IGLPost2DGTGDAO)DAOFactory.CreateDAOInstance("GLPost2DGTGDAO", "GLPost2DGTG");
		DataRow[] array2 = array;
		foreach (DataRow dataRow in array2)
		{
			if (iGLPost2DGTGDAO.DelDgtg(Conversions.ToString(dataRow["ma_cty"]), MyMenuInfo.par1, Conversions.ToDate(txtNgay1.Value), Conversions.ToDate(txtNgay2.Value), Conversions.ToInteger(dataRow["stt"])) == 0)
			{
				dataRow["chon"] = false;
				continue;
			}
			flag = false;
			break;
		}
		if (flag)
		{
			((CheckBox)chkSelectAll).CheckedChanged -= chkSelectAll_CheckedChanged;
			chkSelectAll.Checked = false;
			((CheckBox)chkSelectAll).CheckedChanged += chkSelectAll_CheckedChanged;
			CMessageBox.Show(50015);
		}
	}

	private void cmdDG_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		DataRow[] array = f_tblDG.Select("chon=1", "", DataViewRowState.ModifiedCurrent);
		if (array.Count() == 0)
		{
			CMessageBox.Show(50061);
			return;
		}
		bool flag = true;
		IGLPost2DGTGDAO iGLPost2DGTGDAO = (IGLPost2DGTGDAO)DAOFactory.CreateDAOInstance("GLPost2DGTGDAO", "GLPost2DGTG");
		DataRow[] array2 = array;
		foreach (DataRow dataRow in array2)
		{
			if (iGLPost2DGTGDAO.CreateDgtg(Conversions.ToString(dataRow["ma_cty"]), MyMenuInfo.par1, Conversions.ToString(dataRow["ma_nt"]), Conversions.ToInteger(dataRow["stt"]), Conversions.ToDate(txtNgay1.Value), Conversions.ToDate(txtNgay2.Value), SystemInformations.UserName) == 0)
			{
				dataRow["chon"] = false;
				continue;
			}
			flag = false;
			break;
		}
		if (flag)
		{
			((CheckBox)chkSelectAll).CheckedChanged -= chkSelectAll_CheckedChanged;
			chkSelectAll.Checked = false;
			((CheckBox)chkSelectAll).CheckedChanged += chkSelectAll_CheckedChanged;
			CMessageBox.Show(50015);
		}
	}
}
