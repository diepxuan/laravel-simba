using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSiReOrderVoucherNumber : frmAsiaRoot
{
	private delegate int ThreadComplete();

	private IContainer components;

	[AccessedThroughProperty("cboKyBc")]
	private AsComboBox _cboKyBc;

	[AccessedThroughProperty("txtNgay1")]
	private AsMaskedTextBox _txtNgay1;

	[AccessedThroughProperty("txtNgay2")]
	private AsMaskedTextBox _txtNgay2;

	[AccessedThroughProperty("lblKyKC")]
	private Label _lblKyKC;

	[AccessedThroughProperty("lblSeparate")]
	private Label _lblSeparate;

	[AccessedThroughProperty("chkSelectAll")]
	private AsCheckBox _chkSelectAll;

	[AccessedThroughProperty("dgvDmKC")]
	private AsDataGridView _dgvDmKC;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("cmdKc")]
	private Button _cmdKc;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("colSelect")]
	private DataGridViewCheckBoxColumn _colSelect;

	[AccessedThroughProperty("colTT_BT")]
	private DataGridViewTextBoxColumn _colTT_BT;

	[AccessedThroughProperty("dgvcMa_ct_me")]
	private DataGridViewTextBoxColumn _dgvcMa_ct_me;

	[AccessedThroughProperty("colTenBT")]
	private DataGridViewTextBoxColumn _colTenBT;

	[AccessedThroughProperty("dgvcVn_prefix")]
	private DataGridViewTextBoxColumn _dgvcVn_prefix;

	[AccessedThroughProperty("dgvcVn_pattern")]
	private DataGridViewTextBoxColumn _dgvcVn_pattern;

	[AccessedThroughProperty("dgvcVn_width")]
	private DataGridViewTextBoxColumn _dgvcVn_width;

	[AccessedThroughProperty("dgvcKieuTrung")]
	private DataGridViewTextBoxColumn _dgvcKieuTrung;

	[AccessedThroughProperty("dgvcSoctMax")]
	private DataGridViewTextBoxColumn _dgvcSoctMax;

	[AccessedThroughProperty("dgvcSo_ct")]
	private DataGridViewAsTextNumericColumn _dgvcSo_ct;

	[AccessedThroughProperty("bgwk")]
	private BackgroundWorker _bgwk;

	[AccessedThroughProperty("prbExecute")]
	private ProgressBar _prbExecute;

	private DataTable f_tblDmkc;

	private int MaxCount;

	private int CurrentPercent;

	private ThreadComplete ThreComple;

	private ManualResetEvent[] waitEvent;

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

	internal virtual Label lblKyKC
	{
		get
		{
			return _lblKyKC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblKyKC = value;
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

	internal virtual AsDataGridView dgvDmKC
	{
		get
		{
			return _dgvDmKC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvDmKC = value;
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

	internal virtual Button cmdKc
	{
		get
		{
			return _cmdKc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdKc_Click;
			if (_cmdKc != null)
			{
				((Control)_cmdKc).Click -= eventHandler;
			}
			_cmdKc = value;
			if (_cmdKc != null)
			{
				((Control)_cmdKc).Click += eventHandler;
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

	internal virtual DataGridViewCheckBoxColumn colSelect
	{
		get
		{
			return _colSelect;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colSelect = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colTT_BT
	{
		get
		{
			return _colTT_BT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTT_BT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_ct_me
	{
		get
		{
			return _dgvcMa_ct_me;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcMa_ct_me = value;
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

	internal virtual DataGridViewTextBoxColumn dgvcVn_prefix
	{
		get
		{
			return _dgvcVn_prefix;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcVn_prefix = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcVn_pattern
	{
		get
		{
			return _dgvcVn_pattern;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcVn_pattern = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcVn_width
	{
		get
		{
			return _dgvcVn_width;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcVn_width = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcKieuTrung
	{
		get
		{
			return _dgvcKieuTrung;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcKieuTrung = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSoctMax
	{
		get
		{
			return _dgvcSoctMax;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcSoctMax = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcSo_ct
	{
		get
		{
			return _dgvcSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcSo_ct = value;
		}
	}

	internal virtual BackgroundWorker bgwk
	{
		get
		{
			return _bgwk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			RunWorkerCompletedEventHandler value2 = BackgroundWorker_RunWorkerCompleted;
			ProgressChangedEventHandler value3 = BackgroundWorker_ProgressChanged;
			DoWorkEventHandler value4 = BackgroundWorker_DoWork;
			if (_bgwk != null)
			{
				_bgwk.RunWorkerCompleted -= value2;
				_bgwk.ProgressChanged -= value3;
				_bgwk.DoWork -= value4;
			}
			_bgwk = value;
			if (_bgwk != null)
			{
				_bgwk.RunWorkerCompleted += value2;
				_bgwk.ProgressChanged += value3;
				_bgwk.DoWork += value4;
			}
		}
	}

	internal virtual ProgressBar prbExecute
	{
		get
		{
			return _prbExecute;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_prbExecute = value;
		}
	}

	public frmSiReOrderVoucherNumber(string MenuId)
		: base(MenuId)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		((Form)this).Load += frmGLPost2GLKC_Load;
		((Form)this).FormClosing += new FormClosingEventHandler(frmSiReOrderVoucherNumber_FormClosing);
		MaxCount = 0;
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
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		cboKyBc = new AsComboBox();
		txtNgay1 = new AsMaskedTextBox();
		txtNgay2 = new AsMaskedTextBox();
		lblKyKC = new Label();
		lblSeparate = new Label();
		chkSelectAll = new AsCheckBox();
		dgvDmKC = new AsDataGridView();
		colSelect = new DataGridViewCheckBoxColumn();
		colTT_BT = new DataGridViewTextBoxColumn();
		dgvcMa_ct_me = new DataGridViewTextBoxColumn();
		colTenBT = new DataGridViewTextBoxColumn();
		dgvcVn_prefix = new DataGridViewTextBoxColumn();
		dgvcVn_pattern = new DataGridViewTextBoxColumn();
		dgvcVn_width = new DataGridViewTextBoxColumn();
		dgvcKieuTrung = new DataGridViewTextBoxColumn();
		dgvcSoctMax = new DataGridViewTextBoxColumn();
		dgvcSo_ct = new DataGridViewAsTextNumericColumn();
		GroupBox1 = new GroupBox();
		cmdKc = new Button();
		cmdCancel = new Button();
		bgwk = new BackgroundWorker();
		prbExecute = new ProgressBar();
		((ISupportInitialize)dgvDmKC).BeginInit();
		((Control)this).SuspendLayout();
		((ComboBox)cboKyBc).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyBc).FormattingEnabled = true;
		AsComboBox asComboBox = cboKyBc;
		Point location = new Point(93, 14);
		((Control)asComboBox).Location = location;
		((Control)cboKyBc).Name = "cboKyBc";
		AsComboBox asComboBox2 = cboKyBc;
		Size size = new Size(121, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		txtNgay1.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay1).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay1;
		location = new Point(229, 14);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay1).Mask = "##/##/####";
		((Control)txtNgay1).Name = "txtNgay1";
		((MaskedTextBox)txtNgay1).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		size = new Size(74, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay1).TabIndex = 1;
		((MaskedTextBox)txtNgay1).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay1;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtNgay2.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay2).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay2;
		location = new Point(320, 14);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay2).Mask = "##/##/####";
		((Control)txtNgay2).Name = "txtNgay2";
		((MaskedTextBox)txtNgay2).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay2;
		size = new Size(74, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay2).TabIndex = 2;
		((MaskedTextBox)txtNgay2).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay2;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		lblKyKC.AutoSize = true;
		Label obj = lblKyKC;
		location = new Point(12, 18);
		((Control)obj).Location = location;
		((Control)lblKyKC).Name = "lblKyKC";
		Label obj2 = lblKyKC;
		size = new Size(19, 13);
		((Control)obj2).Size = size;
		((Control)lblKyKC).TabIndex = 2;
		lblKyKC.Text = "Kỳ";
		lblSeparate.AutoSize = true;
		Label obj3 = lblSeparate;
		location = new Point(306, 18);
		((Control)obj3).Location = location;
		((Control)lblSeparate).Name = "lblSeparate";
		Label obj4 = lblSeparate;
		size = new Size(10, 13);
		((Control)obj4).Size = size;
		((Control)lblSeparate).TabIndex = 2;
		lblSeparate.Text = "-";
		((ButtonBase)chkSelectAll).AutoSize = true;
		chkSelectAll.Checked = false;
		AsCheckBox asCheckBox = chkSelectAll;
		location = new Point(12, 53);
		((Control)asCheckBox).Location = location;
		((Control)chkSelectAll).Name = "chkSelectAll";
		AsCheckBox asCheckBox2 = chkSelectAll;
		size = new Size(136, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkSelectAll).TabIndex = 3;
		((ButtonBase)chkSelectAll).Text = "Chọn / hủy chọn tất cả";
		chkSelectAll.TextValue = "0";
		((ButtonBase)chkSelectAll).UseVisualStyleBackColor = true;
		((DataGridView)dgvDmKC).AllowUserToAddRows = false;
		((DataGridView)dgvDmKC).AllowUserToDeleteRows = false;
		((Control)dgvDmKC).Anchor = (AnchorStyles)15;
		((DataGridView)dgvDmKC).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvDmKC).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvDmKC).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		((DataGridView)dgvDmKC).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvDmKC).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[10]
		{
			(DataGridViewColumn)colSelect,
			(DataGridViewColumn)colTT_BT,
			(DataGridViewColumn)dgvcMa_ct_me,
			(DataGridViewColumn)colTenBT,
			(DataGridViewColumn)dgvcVn_prefix,
			(DataGridViewColumn)dgvcVn_pattern,
			(DataGridViewColumn)dgvcVn_width,
			(DataGridViewColumn)dgvcKieuTrung,
			(DataGridViewColumn)dgvcSoctMax,
			dgvcSo_ct
		});
		dgvDmKC.DoubleBuffered = false;
		((DataGridView)dgvDmKC).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvDmKC).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvDmKC;
		location = new Point(12, 76);
		((Control)asDataGridView).Location = location;
		((Control)dgvDmKC).Name = "dgvDmKC";
		((DataGridView)dgvDmKC).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDmKC).RowHeadersDefaultCellStyle = val;
		dgvDmKC.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvDmKC).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvDmKC;
		size = new Size(829, 397);
		((Control)asDataGridView2).Size = size;
		((Control)dgvDmKC).TabIndex = 3;
		((DataGridViewColumn)colSelect).DataPropertyName = "chon";
		colSelect.FalseValue = "false";
		((DataGridViewColumn)colSelect).HeaderText = "Chọn";
		((DataGridViewColumn)colSelect).Name = "colSelect";
		colSelect.TrueValue = "true";
		((DataGridViewColumn)colSelect).Width = 40;
		((DataGridViewColumn)colTT_BT).DataPropertyName = "ma_ct";
		val2.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)colTT_BT).DefaultCellStyle = val2;
		((DataGridViewColumn)colTT_BT).HeaderText = "Mã CT";
		((DataGridViewColumn)colTT_BT).Name = "colTT_BT";
		((DataGridViewColumn)colTT_BT).ReadOnly = true;
		((DataGridViewColumn)colTT_BT).Width = 50;
		((DataGridViewColumn)dgvcMa_ct_me).DataPropertyName = "ma_ct_me";
		val3.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)dgvcMa_ct_me).DefaultCellStyle = val3;
		((DataGridViewColumn)dgvcMa_ct_me).HeaderText = "Mã CT mẹ";
		((DataGridViewColumn)dgvcMa_ct_me).Name = "dgvcMa_ct_me";
		((DataGridViewColumn)dgvcMa_ct_me).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_ct_me).Width = 50;
		((DataGridViewColumn)colTenBT).DataPropertyName = "ten_ct";
		val4.Alignment = (DataGridViewContentAlignment)16;
		((DataGridViewColumn)colTenBT).DefaultCellStyle = val4;
		((DataGridViewColumn)colTenBT).HeaderText = "Tên chứng từ";
		((DataGridViewColumn)colTenBT).Name = "colTenBT";
		((DataGridViewColumn)colTenBT).ReadOnly = true;
		((DataGridViewColumn)colTenBT).Width = 200;
		((DataGridViewColumn)dgvcVn_prefix).DataPropertyName = "Vn_prefix";
		((DataGridViewColumn)dgvcVn_prefix).HeaderText = "Phần đầu";
		((DataGridViewColumn)dgvcVn_prefix).Name = "dgvcVn_prefix";
		((DataGridViewColumn)dgvcVn_prefix).ReadOnly = true;
		((DataGridViewColumn)dgvcVn_prefix).Width = 50;
		((DataGridViewColumn)dgvcVn_pattern).DataPropertyName = "Vn_pattern";
		((DataGridViewColumn)dgvcVn_pattern).HeaderText = "Ký tự mẫu";
		((DataGridViewColumn)dgvcVn_pattern).Name = "dgvcVn_pattern";
		((DataGridViewColumn)dgvcVn_pattern).ReadOnly = true;
		((DataGridViewColumn)dgvcVn_pattern).Width = 50;
		((DataGridViewColumn)dgvcVn_width).DataPropertyName = "Vn_width";
		((DataGridViewColumn)dgvcVn_width).HeaderText = "Độ rộng";
		((DataGridViewColumn)dgvcVn_width).Name = "dgvcVn_width";
		((DataGridViewColumn)dgvcVn_width).ReadOnly = true;
		((DataGridViewColumn)dgvcVn_width).Width = 50;
		((DataGridViewColumn)dgvcKieuTrung).DataPropertyName = "kieu_trung";
		((DataGridViewColumn)dgvcKieuTrung).HeaderText = "Kiểu trùng";
		((DataGridViewColumn)dgvcKieuTrung).Name = "dgvcKieuTrung";
		((DataGridViewColumn)dgvcKieuTrung).ReadOnly = true;
		((DataGridViewColumn)dgvcKieuTrung).Width = 90;
		((DataGridViewColumn)dgvcSoctMax).DataPropertyName = "SoCtMax";
		((DataGridViewColumn)dgvcSoctMax).HeaderText = "Số ct lớn nhất";
		((DataGridViewColumn)dgvcSoctMax).Name = "dgvcSoctMax";
		((DataGridViewColumn)dgvcSoctMax).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_ct).DataPropertyName = "so_ct";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "########";
		((DataGridViewColumn)dgvcSo_ct).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcSo_ct).HeaderText = "Số ct bắt đầu";
		dgvcSo_ct.Mask = "########";
		((DataGridViewColumn)dgvcSo_ct).Name = "dgvcSo_ct";
		((DataGridViewColumn)dgvcSo_ct).Resizable = (DataGridViewTriState)1;
		dgvcSo_ct.SortMode = (DataGridViewColumnSortMode)1;
		dgvcSo_ct.SpecialType = Commons.NumericSpecialType.Other;
		((Control)GroupBox1).Anchor = (AnchorStyles)14;
		GroupBox groupBox = GroupBox1;
		location = new Point(0, 479);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(853, 10);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 4;
		GroupBox1.TabStop = false;
		((Control)cmdKc).Anchor = (AnchorStyles)6;
		Button obj5 = cmdKc;
		location = new Point(12, 495);
		((Control)obj5).Location = location;
		((Control)cmdKc).Name = "cmdKc";
		Button obj6 = cmdKc;
		size = new Size(121, 23);
		((Control)obj6).Size = size;
		((Control)cmdKc).TabIndex = 5;
		((ButtonBase)cmdKc).Text = "Đánh &lại số chứng từ";
		((ButtonBase)cmdKc).UseVisualStyleBackColor = true;
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		Button obj7 = cmdCancel;
		location = new Point(139, 495);
		((Control)obj7).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj8 = cmdCancel;
		size = new Size(75, 23);
		((Control)obj8).Size = size;
		((Control)cmdCancel).TabIndex = 7;
		((ButtonBase)cmdCancel).Text = "&Quay ra";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = true;
		bgwk.WorkerReportsProgress = true;
		bgwk.WorkerSupportsCancellation = true;
		((Control)prbExecute).Anchor = (AnchorStyles)14;
		ProgressBar obj9 = prbExecute;
		location = new Point(220, 495);
		((Control)obj9).Location = location;
		((Control)prbExecute).Name = "prbExecute";
		ProgressBar obj10 = prbExecute;
		size = new Size(621, 23);
		((Control)obj10).Size = size;
		((Control)prbExecute).TabIndex = 8;
		((Control)prbExecute).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(853, 526);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)prbExecute);
		((Control)this).Controls.Add((Control)(object)dgvDmKC);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdKc);
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)chkSelectAll);
		((Control)this).Controls.Add((Control)(object)lblSeparate);
		((Control)this).Controls.Add((Control)(object)lblKyKC);
		((Control)this).Controls.Add((Control)(object)txtNgay2);
		((Control)this).Controls.Add((Control)(object)txtNgay1);
		((Control)this).Controls.Add((Control)(object)cboKyBc);
		((Control)this).Name = "frmSiReOrderVoucherNumber";
		((Form)this).Text = "Đánh lại số chứng từ";
		((ISupportInitialize)dgvDmKC).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cboKyBc_SelectedValueChanged(object sender, EventArgs e)
	{
		if (((ComboBox)cboKyBc).DataSource != null)
		{
			KyBaoCao kyBaoCao = (KyBaoCao)((ComboBox)cboKyBc).SelectedItem;
			if (kyBaoCao.thang1 > 0)
			{
				txtNgay1.Value = kyBaoCao.ngay1;
				txtNgay2.Value = kyBaoCao.ngay2;
				((MaskedTextBox)txtNgay1).ReadOnly = true;
				((Control)txtNgay1).TabStop = false;
				((MaskedTextBox)txtNgay2).ReadOnly = true;
				((Control)txtNgay2).TabStop = false;
			}
			else
			{
				((MaskedTextBox)txtNgay1).ReadOnly = false;
				((Control)txtNgay1).TabStop = true;
				((MaskedTextBox)txtNgay2).ReadOnly = false;
				((Control)txtNgay2).TabStop = true;
			}
			GetData();
		}
	}

	private void InitKyBaoCao()
	{
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
		((ComboBox)cboKyBc).DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc, "11110");
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"", false))
		{
			try
			{
				if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"NGAY", false))
				{
					txtNgay1.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct1"));
					txtNgay2.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct2"));
				}
				((ListControl)cboKyBc).SelectedValue = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao"));
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		((ComboBox)cboKyBc).SelectedIndex = 0;
	}

	private void SaveKyBaoCao()
	{
		AsiaErp.Framework.Environment.set_PublicVariables("KyBaoCao", (object)((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ma);
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		if (bgwk.WorkerSupportsCancellation)
		{
			bgwk.CancelAsync();
			if (!bgwk.IsBusy)
			{
				((Component)(object)this).Dispose();
			}
		}
	}

	private void frmGLPost2GLKC_Load(object sender, EventArgs e)
	{
		((DataGridView)dgvDmKC).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
		InitKyBaoCao();
		GetData();
		ThreComple = GetPercent;
	}

	private void cmdKc_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		DataRow[] array = f_tblDmkc.Select("chon=True", "", DataViewRowState.ModifiedCurrent);
		if (array.Count() == 0)
		{
			CMessageBox.Show(50061);
			return;
		}
		((Control)prbExecute).Visible = true;
		MaxCount = array.Count();
		prbExecute.Maximum = MaxCount;
		prbExecute.Value = 0;
		CurrentPercent = 0;
		((Control)cmdKc).Enabled = false;
		waitEvent = new ManualResetEvent[checked(MaxCount - 1 + 1)];
		if (!bgwk.IsBusy)
		{
			bgwk.RunWorkerAsync(array);
		}
	}

	private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = Conversions.ToBoolean(Interaction.IIf(Conversions.ToBoolean(chkSelectAll.Checked), (object)true, (object)false));
		foreach (DataRow row in f_tblDmkc.Rows)
		{
			row["chon"] = flag;
		}
	}

	private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		DataRow[] array = (DataRow[])e.Argument;
		checked
		{
			int num = array.Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				BackgroundWorker backgroundWorker = (BackgroundWorker)sender;
				if (backgroundWorker.CancellationPending)
				{
					e.Cancel = true;
					Thread.CurrentThread.Abort();
					break;
				}
				waitEvent[i] = new ManualResetEvent(initialState: false);
				Thread thread = new Thread([SpecialName] [DebuggerStepThrough] (object a0) =>
				{
					ProcessReOrder((DataRow)a0);
				});
				thread.Start(array[i]);
			}
			WaitHandle.WaitAll(waitEvent);
		}
	}

	private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		prbExecute.Value = e.ProgressPercentage;
	}

	private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		((Control)cmdKc).Enabled = true;
		if (!e.Cancelled)
		{
			((CheckBox)chkSelectAll).CheckedChanged -= chkSelectAll_CheckedChanged;
			chkSelectAll.Checked = false;
			CMessageBox.Show(50015);
			((CheckBox)chkSelectAll).CheckedChanged += chkSelectAll_CheckedChanged;
			((Control)prbExecute).Visible = false;
		}
	}

	private void frmSiReOrderVoucherNumber_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (bgwk.IsBusy)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private int GetPercent()
	{
		checked
		{
			CurrentPercent++;
			return CurrentPercent;
		}
	}

	private void ProcessReOrder(DataRow arrRows)
	{
		SiReOrderVoucherNumberDAO siReOrderVoucherNumberDAO = (SiReOrderVoucherNumberDAO)DAOFactory.CreateDAOInstance("SiReOrderVoucherNumberDAO", "SiReOrderVoucherNumber");
		if (siReOrderVoucherNumberDAO.ReOrder(Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(arrRows["ma_ct"]), isNum: false)), Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(arrRows["so_ct"]), isNum: true)), Conversions.ToDate(txtNgay1.Value), Conversions.ToDate(txtNgay2.Value)) == 0)
		{
			ThreComple();
			arrRows["chon"] = false;
			bgwk.ReportProgress(CurrentPercent);
			siReOrderVoucherNumberDAO.Destroy();
			waitEvent[checked(CurrentPercent - 1)].Set();
		}
	}

	private void GetData()
	{
		SiReOrderVoucherNumberDAO siReOrderVoucherNumberDAO = (SiReOrderVoucherNumberDAO)DAOFactory.CreateDAOInstance("SiReOrderVoucherNumberDAO", "SiReOrderVoucherNumber");
		f_tblDmkc = siReOrderVoucherNumberDAO.GetDmCt(Conversions.ToDate(txtNgay1.Value), Conversions.ToDate(txtNgay2.Value));
		f_tblDmkc.Columns["so_ct"].DefaultValue = 0;
		((DataGridView)dgvDmKC).DataSource = f_tblDmkc;
		((Control)cmdKc).Enabled = f_tblDmkc.DefaultView.Count > 0;
	}
}
