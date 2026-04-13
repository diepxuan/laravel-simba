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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLPost2GLKC : frmAsiaRoot
{
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

	[AccessedThroughProperty("cmdDelKc")]
	private Button _cmdDelKc;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("colSelect")]
	private DataGridViewCheckBoxColumn _colSelect;

	[AccessedThroughProperty("colTT_BT")]
	private DataGridViewTextBoxColumn _colTT_BT;

	[AccessedThroughProperty("colTenBT")]
	private DataGridViewTextBoxColumn _colTenBT;

	[AccessedThroughProperty("colTkNo")]
	private DataGridViewTextBoxColumn _colTkNo;

	[AccessedThroughProperty("colLoaiKC")]
	private DataGridViewTextBoxColumn _colLoaiKC;

	[AccessedThroughProperty("colTkCo")]
	private DataGridViewTextBoxColumn _colTkCo;

	[AccessedThroughProperty("colSoCT")]
	private DataGridViewTextBoxColumn _colSoCT;

	[AccessedThroughProperty("colTheoHD")]
	private DataGridViewCheckBoxColumn _colTheoHD;

	[AccessedThroughProperty("colTheoBp")]
	private DataGridViewCheckBoxColumn _colTheoBp;

	[AccessedThroughProperty("colTheoSPCT")]
	private DataGridViewCheckBoxColumn _colTheoSPCT;

	[AccessedThroughProperty("colTheoPhi")]
	private DataGridViewCheckBoxColumn _colTheoPhi;

	private DataTable f_tblDmkc;

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

	internal virtual Button cmdDelKc
	{
		get
		{
			return _cmdDelKc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdDelKc_Click;
			if (_cmdDelKc != null)
			{
				((Control)_cmdDelKc).Click -= eventHandler;
			}
			_cmdDelKc = value;
			if (_cmdDelKc != null)
			{
				((Control)_cmdDelKc).Click += eventHandler;
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

	internal virtual DataGridViewTextBoxColumn colTkNo
	{
		get
		{
			return _colTkNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTkNo = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colLoaiKC
	{
		get
		{
			return _colLoaiKC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colLoaiKC = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colTkCo
	{
		get
		{
			return _colTkCo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTkCo = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colSoCT
	{
		get
		{
			return _colSoCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colSoCT = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colTheoHD
	{
		get
		{
			return _colTheoHD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTheoHD = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colTheoBp
	{
		get
		{
			return _colTheoBp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTheoBp = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colTheoSPCT
	{
		get
		{
			return _colTheoSPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTheoSPCT = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colTheoPhi
	{
		get
		{
			return _colTheoPhi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTheoPhi = value;
		}
	}

	public frmGLPost2GLKC(string MenuId)
		: base(MenuId)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		((Form)this).Load += frmGLPost2GLKC_Load;
		((Control)this).KeyDown += new KeyEventHandler(frmGLPost2GLKC_KeyDown);
		f_tblDmkc = new DataTable();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
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
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		cboKyBc = new AsComboBox();
		txtNgay1 = new AsMaskedTextBox();
		txtNgay2 = new AsMaskedTextBox();
		lblKyKC = new Label();
		lblSeparate = new Label();
		chkSelectAll = new AsCheckBox();
		dgvDmKC = new AsDataGridView();
		GroupBox1 = new GroupBox();
		cmdKc = new Button();
		cmdDelKc = new Button();
		cmdCancel = new Button();
		colSelect = new DataGridViewCheckBoxColumn();
		colTT_BT = new DataGridViewTextBoxColumn();
		colTenBT = new DataGridViewTextBoxColumn();
		colTkNo = new DataGridViewTextBoxColumn();
		colLoaiKC = new DataGridViewTextBoxColumn();
		colTkCo = new DataGridViewTextBoxColumn();
		colSoCT = new DataGridViewTextBoxColumn();
		colTheoHD = new DataGridViewCheckBoxColumn();
		colTheoBp = new DataGridViewCheckBoxColumn();
		colTheoSPCT = new DataGridViewCheckBoxColumn();
		colTheoPhi = new DataGridViewCheckBoxColumn();
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
		size = new Size(75, 13);
		((Control)obj2).Size = size;
		((Control)lblKyKC).TabIndex = 2;
		lblKyKC.Text = "Kỳ kết chuyển";
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
		((DataGridView)dgvDmKC).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[11]
		{
			(DataGridViewColumn)colSelect,
			(DataGridViewColumn)colTT_BT,
			(DataGridViewColumn)colTenBT,
			(DataGridViewColumn)colTkNo,
			(DataGridViewColumn)colLoaiKC,
			(DataGridViewColumn)colTkCo,
			(DataGridViewColumn)colSoCT,
			(DataGridViewColumn)colTheoHD,
			(DataGridViewColumn)colTheoBp,
			(DataGridViewColumn)colTheoSPCT,
			(DataGridViewColumn)colTheoPhi
		});
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
		size = new Size(829, 355);
		((Control)asDataGridView2).Size = size;
		((Control)dgvDmKC).TabIndex = 3;
		((Control)GroupBox1).Anchor = (AnchorStyles)14;
		GroupBox groupBox = GroupBox1;
		location = new Point(0, 437);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(853, 10);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 4;
		GroupBox1.TabStop = false;
		((Control)cmdKc).Anchor = (AnchorStyles)6;
		Button obj5 = cmdKc;
		location = new Point(12, 453);
		((Control)obj5).Location = location;
		((Control)cmdKc).Name = "cmdKc";
		Button obj6 = cmdKc;
		size = new Size(75, 23);
		((Control)obj6).Size = size;
		((Control)cmdKc).TabIndex = 5;
		((ButtonBase)cmdKc).Text = "&Kết chuyển";
		((ButtonBase)cmdKc).UseVisualStyleBackColor = true;
		((Control)cmdDelKc).Anchor = (AnchorStyles)6;
		Button obj7 = cmdDelKc;
		location = new Point(93, 453);
		((Control)obj7).Location = location;
		((Control)cmdDelKc).Name = "cmdDelKc";
		Button obj8 = cmdDelKc;
		size = new Size(75, 23);
		((Control)obj8).Size = size;
		((Control)cmdDelKc).TabIndex = 6;
		((ButtonBase)cmdDelKc).Text = "&Xóa KC";
		((ButtonBase)cmdDelKc).UseVisualStyleBackColor = true;
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		Button obj9 = cmdCancel;
		location = new Point(174, 453);
		((Control)obj9).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj10 = cmdCancel;
		size = new Size(75, 23);
		((Control)obj10).Size = size;
		((Control)cmdCancel).TabIndex = 7;
		((ButtonBase)cmdCancel).Text = "&Quay ra";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = true;
		((DataGridViewColumn)colSelect).DataPropertyName = "tag";
		colSelect.FalseValue = "0";
		((DataGridViewColumn)colSelect).HeaderText = "Chọn";
		((DataGridViewColumn)colSelect).Name = "colSelect";
		colSelect.TrueValue = "1";
		((DataGridViewColumn)colSelect).Width = 60;
		((DataGridViewColumn)colTT_BT).DataPropertyName = "stt";
		val2.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)colTT_BT).DefaultCellStyle = val2;
		((DataGridViewColumn)colTT_BT).HeaderText = "Stt";
		((DataGridViewColumn)colTT_BT).Name = "colTT_BT";
		((DataGridViewColumn)colTT_BT).ReadOnly = true;
		((DataGridViewColumn)colTT_BT).Width = 40;
		((DataGridViewColumn)colTenBT).DataPropertyName = "ten_bt";
		val3.Alignment = (DataGridViewContentAlignment)16;
		((DataGridViewColumn)colTenBT).DefaultCellStyle = val3;
		((DataGridViewColumn)colTenBT).HeaderText = "Tên bút toán";
		((DataGridViewColumn)colTenBT).Name = "colTenBT";
		((DataGridViewColumn)colTenBT).ReadOnly = true;
		((DataGridViewColumn)colTenBT).Width = 150;
		((DataGridViewColumn)colTkNo).DataPropertyName = "tk";
		((DataGridViewColumn)colTkNo).HeaderText = "TK";
		((DataGridViewColumn)colTkNo).Name = "colTkNo";
		((DataGridViewColumn)colTkNo).ReadOnly = true;
		((DataGridViewColumn)colTkNo).Width = 80;
		((DataGridViewColumn)colLoaiKC).DataPropertyName = "ten_loai";
		val4.Alignment = (DataGridViewContentAlignment)16;
		((DataGridViewColumn)colLoaiKC).DefaultCellStyle = val4;
		((DataGridViewColumn)colLoaiKC).HeaderText = "Loại kết chuyển";
		((DataGridViewColumn)colLoaiKC).Name = "colLoaiKC";
		((DataGridViewColumn)colLoaiKC).ReadOnly = true;
		((DataGridViewColumn)colLoaiKC).Width = 120;
		((DataGridViewColumn)colTkCo).DataPropertyName = "tk_du";
		((DataGridViewColumn)colTkCo).HeaderText = "TK đ/ư";
		((DataGridViewColumn)colTkCo).Name = "colTkCo";
		((DataGridViewColumn)colTkCo).ReadOnly = true;
		((DataGridViewColumn)colTkCo).Width = 80;
		((DataGridViewColumn)colSoCT).DataPropertyName = "so_ct";
		((DataGridViewColumn)colSoCT).HeaderText = "Số ctừ";
		((DataGridViewColumn)colSoCT).Name = "colSoCT";
		((DataGridViewColumn)colSoCT).ReadOnly = true;
		((DataGridViewColumn)colTheoHD).DataPropertyName = "kc_hd";
		colTheoHD.FalseValue = "0";
		((DataGridViewColumn)colTheoHD).HeaderText = "Theo hợp đồng";
		((DataGridViewColumn)colTheoHD).Name = "colTheoHD";
		((DataGridViewColumn)colTheoHD).ReadOnly = true;
		colTheoHD.TrueValue = "1";
		((DataGridViewColumn)colTheoHD).Width = 120;
		((DataGridViewColumn)colTheoBp).DataPropertyName = "kc_bp";
		colTheoBp.FalseValue = "0";
		((DataGridViewColumn)colTheoBp).HeaderText = "Theo bộ phận";
		((DataGridViewColumn)colTheoBp).Name = "colTheoBp";
		((DataGridViewColumn)colTheoBp).ReadOnly = true;
		colTheoBp.TrueValue = "1";
		((DataGridViewColumn)colTheoBp).Width = 120;
		((DataGridViewColumn)colTheoSPCT).DataPropertyName = "kc_spct";
		colTheoSPCT.FalseValue = "0";
		((DataGridViewColumn)colTheoSPCT).HeaderText = "Theo  SPCT";
		((DataGridViewColumn)colTheoSPCT).Name = "colTheoSPCT";
		((DataGridViewColumn)colTheoSPCT).ReadOnly = true;
		colTheoSPCT.TrueValue = "1";
		((DataGridViewColumn)colTheoSPCT).Width = 120;
		((DataGridViewColumn)colTheoPhi).DataPropertyName = "kc_phi";
		colTheoPhi.FalseValue = "0";
		((DataGridViewColumn)colTheoPhi).HeaderText = "Theo phí";
		((DataGridViewColumn)colTheoPhi).Name = "colTheoPhi";
		((DataGridViewColumn)colTheoPhi).ReadOnly = true;
		colTheoPhi.TrueValue = "1";
		((DataGridViewColumn)colTheoPhi).Width = 120;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(853, 484);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdDelKc);
		((Control)this).Controls.Add((Control)(object)cmdKc);
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)chkSelectAll);
		((Control)this).Controls.Add((Control)(object)lblSeparate);
		((Control)this).Controls.Add((Control)(object)lblKyKC);
		((Control)this).Controls.Add((Control)(object)txtNgay2);
		((Control)this).Controls.Add((Control)(object)txtNgay1);
		((Control)this).Controls.Add((Control)(object)cboKyBc);
		((Control)this).Controls.Add((Control)(object)dgvDmKC);
		((Control)this).Name = "frmGLPost2GLKC";
		((Form)this).Text = "Kết chuyển tự động";
		((ISupportInitialize)dgvDmKC).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cboKyBc_SelectedValueChanged(object sender, EventArgs e)
	{
		if (((ComboBox)cboKyBc).DataSource != null)
		{
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
			try
			{
				((ListControl)cboKyBc).SelectedValue = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao"));
				return;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				((ListControl)cboKyBc).SelectedValue = 0;
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
		((Form)this).Close();
	}

	private void frmGLPost2GLKC_Load(object sender, EventArgs e)
	{
		((Form)this).Text = Conversions.ToString(Operators.AddObject(Operators.AddObject((object)(base.MyMenuInfo.bar + "."), Interaction.IIf((((Control)cmdKc).Enabled && ((Control)cmdKc).Visible) ? true : false, (object)(" F4 - " + Strings.Replace(((ButtonBase)cmdKc).Text, "&", "", 1, -1, (CompareMethod)0) + ","), (object)"")), Interaction.IIf((((Control)cmdDelKc).Enabled && ((Control)cmdDelKc).Visible) ? true : false, (object)(" F8 - " + Strings.Replace(((ButtonBase)cmdDelKc).Text, "&", "", 1, -1, (CompareMethod)0)), (object)"")));
		((DataGridView)dgvDmKC).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
		InitKyBaoCao();
		GetData();
	}

	private void cmdDelKc_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectLessEqual(txtNgay2.Value, (object)AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks, false))
		{
			CMessageBox.Show(50136);
			return;
		}
		DataRow[] array = f_tblDmkc.Select("tag='1'", "", DataViewRowState.ModifiedCurrent);
		if (array.Count() == 0)
		{
			CMessageBox.Show(50061);
			return;
		}
		IGLPost2GLKCDAO iGLPost2GLKCDAO = (IGLPost2GLKCDAO)DAOFactory.CreateDAOInstance("GLPost2GLKCDAO", "GLPost2GLKC");
		bool flag = true;
		DataRow[] array2 = array;
		foreach (DataRow dataRow in array2)
		{
			if (iGLPost2GLKCDAO.DelKc(dataRow, MyMenuInfo.par1, Conversions.ToDate(txtNgay1.Value), Conversions.ToDate(txtNgay2.Value)) == 0)
			{
				dataRow["tag"] = "0";
				continue;
			}
			flag = false;
			break;
		}
		iGLPost2GLKCDAO.Destroy();
		if (flag)
		{
			((CheckBox)chkSelectAll).CheckedChanged -= chkSelectAll_CheckedChanged;
			chkSelectAll.Checked = false;
			CMessageBox.Show(50015);
			((CheckBox)chkSelectAll).CheckedChanged += chkSelectAll_CheckedChanged;
		}
	}

	private void cmdKc_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectLessEqual(txtNgay2.Value, (object)AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks, false))
		{
			CMessageBox.Show(50136);
			return;
		}
		DataRow[] array = f_tblDmkc.Select("tag='1'", "", DataViewRowState.ModifiedCurrent);
		if (array.Count() == 0)
		{
			CMessageBox.Show(50061);
			return;
		}
		IGLPost2GLKCDAO iGLPost2GLKCDAO = (IGLPost2GLKCDAO)DAOFactory.CreateDAOInstance("GLPost2GLKCDAO", "GLPost2GLKC");
		bool flag = true;
		DataRow[] array2 = array;
		foreach (DataRow dataRow in array2)
		{
			if (iGLPost2GLKCDAO.CreateKc(dataRow, MyMenuInfo.par1, Conversions.ToDate(txtNgay1.Value), Conversions.ToDate(txtNgay2.Value)) == 0)
			{
				dataRow["tag"] = "0";
				continue;
			}
			flag = false;
			break;
		}
		iGLPost2GLKCDAO.Destroy();
		if (flag)
		{
			((CheckBox)chkSelectAll).CheckedChanged -= chkSelectAll_CheckedChanged;
			chkSelectAll.Checked = false;
			CMessageBox.Show(50015);
			((CheckBox)chkSelectAll).CheckedChanged += chkSelectAll_CheckedChanged;
		}
	}

	private void GetData()
	{
		IGLPost2GLKCDAO iGLPost2GLKCDAO = (IGLPost2GLKCDAO)DAOFactory.CreateDAOInstance("GLPost2GLKCDAO", "GLPost2GLKC");
		f_tblDmkc = iGLPost2GLKCDAO.GetDmKC(MyMenuInfo.par2.ToString());
		((DataGridView)dgvDmKC).DataSource = f_tblDmkc;
		((Control)cmdDelKc).Enabled = f_tblDmkc.DefaultView.Count > 0;
		((Control)cmdKc).Enabled = ((Control)cmdDelKc).Enabled;
	}

	private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
	{
		string value = Conversions.ToString(Interaction.IIf(Conversions.ToBoolean(chkSelectAll.Checked), (object)"1", (object)"0"));
		foreach (DataRow row in f_tblDmkc.Rows)
		{
			row["tag"] = value;
		}
	}

	private void frmGLPost2GLKC_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
		if ((int)e.KeyCode == 115)
		{
			cmdKc.PerformClick();
		}
		if ((int)e.KeyCode == 119)
		{
			cmdDelKc.PerformClick();
		}
	}
}
