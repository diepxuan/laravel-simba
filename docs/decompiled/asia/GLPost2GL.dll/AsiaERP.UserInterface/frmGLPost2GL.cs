using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using AsiaERP.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmGLPost2GL : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("cboCT")]
	private AsComboBox _cboCT;

	[AccessedThroughProperty("lblCT")]
	private Label _lblCT;

	[AccessedThroughProperty("lblFrom_To")]
	private Label _lblFrom_To;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("chkSelectAll")]
	private AsCheckBox _chkSelectAll;

	[AccessedThroughProperty("bgWork")]
	private BackgroundWorker _bgWork;

	[AccessedThroughProperty("prbExecute")]
	private ProgressBar _prbExecute;

	[AccessedThroughProperty("dgvCT")]
	private AsDataGridView _dgvCT;

	[AccessedThroughProperty("colChuyen")]
	private DataGridViewCheckBoxColumn _colChuyen;

	[AccessedThroughProperty("colMa_ct")]
	private DataGridViewTextBoxColumn _colMa_ct;

	[AccessedThroughProperty("colSo_ct")]
	private DataGridViewTextBoxColumn _colSo_ct;

	[AccessedThroughProperty("colNgay_ct")]
	private DataGridViewAsMaskedTextBoxColumn _colNgay_ct;

	[AccessedThroughProperty("colMa_kh")]
	private DataGridViewTextBoxColumn _colMa_kh;

	[AccessedThroughProperty("colTen_kh")]
	private DataGridViewTextBoxColumn _colTen_kh;

	[AccessedThroughProperty("colMa_nt")]
	private DataGridViewTextBoxColumn _colMa_nt;

	[AccessedThroughProperty("colSum_money")]
	private DataGridViewAsTextNumericColumn _colSum_money;

	[AccessedThroughProperty("colSum_money_nt")]
	private DataGridViewAsTextNumericColumn _colSum_money_nt;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	private DataTable f_tblCT;

	private DateTime dtmNgay1;

	private DateTime dtmNgay2;

	private string strSo_ct1;

	private string strSo_ct2;

	private string strPost;

	private string strMa_ct;

	private int iRet;

	private int intCount;

	private int intMax;

	private ManualResetEvent _waitEvent;

	private bool check;

	private List<VoucherInfoDatasource> f_voucherList;

	internal virtual AsComboBox cboCT
	{
		get
		{
			return _cboCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboCT_SelectedValueChanged;
			if (_cboCT != null)
			{
				((ListControl)_cboCT).SelectedValueChanged -= eventHandler;
			}
			_cboCT = value;
			if (_cboCT != null)
			{
				((ListControl)_cboCT).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblCT
	{
		get
		{
			return _lblCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblCT = value;
		}
	}

	internal virtual Label lblFrom_To
	{
		get
		{
			return _lblFrom_To;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblFrom_To = value;
		}
	}

	internal virtual Button cmdOK
	{
		get
		{
			return _cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdOK_Click;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click -= eventHandler;
			}
			_cmdOK = value;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click += eventHandler;
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

	internal virtual BackgroundWorker bgWork
	{
		get
		{
			return _bgWork;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = bgWork_DoWork;
			RunWorkerCompletedEventHandler value3 = bgWork_RunWorkerCompleted;
			ProgressChangedEventHandler value4 = bgWork_ProgressChanged;
			if (_bgWork != null)
			{
				_bgWork.DoWork -= value2;
				_bgWork.RunWorkerCompleted -= value3;
				_bgWork.ProgressChanged -= value4;
			}
			_bgWork = value;
			if (_bgWork != null)
			{
				_bgWork.DoWork += value2;
				_bgWork.RunWorkerCompleted += value3;
				_bgWork.ProgressChanged += value4;
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

	internal virtual AsDataGridView dgvCT
	{
		get
		{
			return _dgvCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvCT = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colChuyen
	{
		get
		{
			return _colChuyen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colChuyen = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colMa_ct
	{
		get
		{
			return _colMa_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colMa_ct = value;
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

	internal virtual DataGridViewAsMaskedTextBoxColumn colNgay_ct
	{
		get
		{
			return _colNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colNgay_ct = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colMa_kh
	{
		get
		{
			return _colMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colMa_kh = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colTen_kh
	{
		get
		{
			return _colTen_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colTen_kh = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colMa_nt
	{
		get
		{
			return _colMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colMa_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn colSum_money
	{
		get
		{
			return _colSum_money;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colSum_money = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn colSum_money_nt
	{
		get
		{
			return _colSum_money_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colSum_money_nt = value;
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

	public frmGLPost2GL(string MenuID)
		: base(MenuID)
	{
		((Form)this).Load += frmGLPost2GL_Load;
		((Form)this).Shown += frmGLPost2GL_Shown;
		check = false;
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
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		cboCT = new AsComboBox();
		lblCT = new Label();
		lblFrom_To = new Label();
		cmdOK = new Button();
		cmdCancel = new Button();
		chkSelectAll = new AsCheckBox();
		bgWork = new BackgroundWorker();
		prbExecute = new ProgressBar();
		dgvCT = new AsDataGridView();
		colChuyen = new DataGridViewCheckBoxColumn();
		colMa_ct = new DataGridViewTextBoxColumn();
		colSo_ct = new DataGridViewTextBoxColumn();
		colNgay_ct = new DataGridViewAsMaskedTextBoxColumn();
		colMa_kh = new DataGridViewTextBoxColumn();
		colTen_kh = new DataGridViewTextBoxColumn();
		colMa_nt = new DataGridViewTextBoxColumn();
		colSum_money = new DataGridViewAsTextNumericColumn();
		colSum_money_nt = new DataGridViewAsTextNumericColumn();
		GroupBox1 = new GroupBox();
		((ISupportInitialize)dgvCT).BeginInit();
		((Control)this).SuspendLayout();
		((ComboBox)cboCT).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboCT).FormattingEnabled = true;
		((ComboBox)cboCT).Items.AddRange(new object[1] { "Tất cả các chứng từ" });
		AsComboBox asComboBox = cboCT;
		Point location = new Point(72, 12);
		((Control)asComboBox).Location = location;
		((Control)cboCT).Name = "cboCT";
		AsComboBox asComboBox2 = cboCT;
		Size size = new Size(221, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboCT).TabIndex = 0;
		lblCT.AutoSize = true;
		Label obj = lblCT;
		location = new Point(7, 16);
		((Control)obj).Location = location;
		((Control)lblCT).Name = "lblCT";
		Label obj2 = lblCT;
		size = new Size(50, 13);
		((Control)obj2).Size = size;
		((Control)lblCT).TabIndex = 1;
		lblCT.Text = "Chứng từ";
		Label obj3 = lblFrom_To;
		location = new Point(299, 16);
		((Control)obj3).Location = location;
		((Control)lblFrom_To).Name = "lblFrom_To";
		Label obj4 = lblFrom_To;
		size = new Size(552, 13);
		((Control)obj4).Size = size;
		((Control)lblFrom_To).TabIndex = 1;
		lblFrom_To.Text = "Từ ngày-đến ngày";
		((Control)cmdOK).Anchor = (AnchorStyles)6;
		Button obj5 = cmdOK;
		location = new Point(7, 454);
		((Control)obj5).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		Button obj6 = cmdOK;
		size = new Size(75, 23);
		((Control)obj6).Size = size;
		((Control)cmdOK).TabIndex = 2;
		((ButtonBase)cmdOK).Text = "&Thực hiện";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = true;
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		Button obj7 = cmdCancel;
		location = new Point(93, 454);
		((Control)obj7).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj8 = cmdCancel;
		size = new Size(75, 23);
		((Control)obj8).Size = size;
		((Control)cmdCancel).TabIndex = 3;
		((ButtonBase)cmdCancel).Text = "&Quay ra";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = true;
		((ButtonBase)chkSelectAll).AutoSize = true;
		chkSelectAll.Checked = false;
		AsCheckBox asCheckBox = chkSelectAll;
		location = new Point(7, 47);
		((Control)asCheckBox).Location = location;
		((Control)chkSelectAll).Name = "chkSelectAll";
		AsCheckBox asCheckBox2 = chkSelectAll;
		size = new Size(126, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkSelectAll).TabIndex = 1;
		((ButtonBase)chkSelectAll).Text = "Chọn/Bỏ chọn tất cả";
		chkSelectAll.TextValue = "0";
		((ButtonBase)chkSelectAll).UseVisualStyleBackColor = true;
		bgWork.WorkerReportsProgress = true;
		((Control)prbExecute).Anchor = (AnchorStyles)14;
		ProgressBar obj9 = prbExecute;
		location = new Point(186, 454);
		((Control)obj9).Location = location;
		((Control)prbExecute).Name = "prbExecute";
		ProgressBar obj10 = prbExecute;
		size = new Size(665, 23);
		((Control)obj10).Size = size;
		((Control)prbExecute).TabIndex = 6;
		((Control)prbExecute).Visible = false;
		((DataGridView)dgvCT).AllowUserToAddRows = false;
		((DataGridView)dgvCT).AllowUserToDeleteRows = false;
		((Control)dgvCT).Anchor = (AnchorStyles)15;
		((DataGridView)dgvCT).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvCT).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvCT).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		((DataGridView)dgvCT).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvCT).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[9]
		{
			(DataGridViewColumn)colChuyen,
			(DataGridViewColumn)colMa_ct,
			(DataGridViewColumn)colSo_ct,
			colNgay_ct,
			(DataGridViewColumn)colMa_kh,
			(DataGridViewColumn)colTen_kh,
			(DataGridViewColumn)colMa_nt,
			colSum_money,
			colSum_money_nt
		});
		dgvCT.DoubleBuffered = false;
		((DataGridView)dgvCT).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvCT).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvCT;
		location = new Point(7, 70);
		((Control)asDataGridView).Location = location;
		((Control)dgvCT).Name = "dgvCT";
		((DataGridView)dgvCT).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvCT).RowHeadersDefaultCellStyle = val;
		dgvCT.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvCT).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvCT;
		size = new Size(844, 356);
		((Control)asDataGridView2).Size = size;
		((Control)dgvCT).TabIndex = 3;
		((DataGridViewColumn)colChuyen).DataPropertyName = "post2gl";
		colChuyen.FalseValue = "0";
		((DataGridViewColumn)colChuyen).HeaderText = "Chuyển";
		((DataGridViewColumn)colChuyen).Name = "colChuyen";
		colChuyen.TrueValue = "1";
		((DataGridViewColumn)colChuyen).Width = 50;
		((DataGridViewColumn)colMa_ct).DataPropertyName = "ma_ct";
		((DataGridViewColumn)colMa_ct).HeaderText = "Mã ct";
		((DataGridViewColumn)colMa_ct).Name = "colMa_ct";
		((DataGridViewColumn)colMa_ct).ReadOnly = true;
		((DataGridViewColumn)colSo_ct).DataPropertyName = "so_ct";
		((DataGridViewColumn)colSo_ct).HeaderText = "Số ct";
		((DataGridViewColumn)colSo_ct).Name = "colSo_ct";
		((DataGridViewColumn)colSo_ct).ReadOnly = true;
		((DataGridViewColumn)colNgay_ct).DataPropertyName = "ngay_ct";
		val2.Alignment = (DataGridViewContentAlignment)64;
		val2.Format = "dd/MM/yyyy";
		((DataGridViewColumn)colNgay_ct).DefaultCellStyle = val2;
		colNgay_ct.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)colNgay_ct).HeaderText = "Ngày Ct";
		colNgay_ct.Mask = "##/##/####";
		((DataGridViewColumn)colNgay_ct).Name = "colNgay_ct";
		((DataGridViewColumn)colNgay_ct).ReadOnly = true;
		colNgay_ct.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)colNgay_ct).Width = 80;
		((DataGridViewColumn)colMa_kh).DataPropertyName = "ma_kh";
		((DataGridViewColumn)colMa_kh).HeaderText = "Mã kh";
		((DataGridViewColumn)colMa_kh).Name = "colMa_kh";
		((DataGridViewColumn)colMa_kh).ReadOnly = true;
		((DataGridViewColumn)colMa_kh).Width = 80;
		((DataGridViewColumn)colTen_kh).DataPropertyName = "ten_kh";
		((DataGridViewColumn)colTen_kh).HeaderText = "Tên kh";
		((DataGridViewColumn)colTen_kh).Name = "colTen_kh";
		((DataGridViewColumn)colTen_kh).ReadOnly = true;
		((DataGridViewColumn)colMa_nt).DataPropertyName = "ma_nt";
		((DataGridViewColumn)colMa_nt).HeaderText = "Mã NT";
		((DataGridViewColumn)colMa_nt).Name = "colMa_nt";
		((DataGridViewColumn)colMa_nt).ReadOnly = true;
		((DataGridViewColumn)colMa_nt).Width = 65;
		((DataGridViewColumn)colSum_money).DataPropertyName = "t_tien";
		val3.Alignment = (DataGridViewContentAlignment)64;
		val3.Format = "### ### ### ###.##";
		((DataGridViewColumn)colSum_money).DefaultCellStyle = val3;
		((DataGridViewColumn)colSum_money).HeaderText = "Tổng tiền";
		colSum_money.Mask = "### ### ### ###.##";
		((DataGridViewColumn)colSum_money).Name = "colSum_money";
		((DataGridViewColumn)colSum_money).ReadOnly = true;
		colSum_money.SortMode = (DataGridViewColumnSortMode)0;
		colSum_money.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)colSum_money_nt).DataPropertyName = "t_tien_nt";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "### ### ### ###.##";
		((DataGridViewColumn)colSum_money_nt).DefaultCellStyle = val4;
		((DataGridViewColumn)colSum_money_nt).HeaderText = "Tổng tiền NT";
		colSum_money_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)colSum_money_nt).Name = "colSum_money_nt";
		((DataGridViewColumn)colSum_money_nt).ReadOnly = true;
		colSum_money_nt.SortMode = (DataGridViewColumnSortMode)0;
		colSum_money_nt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)GroupBox1).Anchor = (AnchorStyles)14;
		GroupBox groupBox = GroupBox1;
		location = new Point(-2, 432);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(862, 10);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 7;
		GroupBox1.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(859, 489);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)dgvCT);
		((Control)this).Controls.Add((Control)(object)prbExecute);
		((Control)this).Controls.Add((Control)(object)chkSelectAll);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Controls.Add((Control)(object)lblFrom_To);
		((Control)this).Controls.Add((Control)(object)lblCT);
		((Control)this).Controls.Add((Control)(object)cboCT);
		((Control)this).Name = "frmGLPost2GL";
		((Form)this).Text = "Chuyển số liệu vào sổ cái";
		((ISupportInitialize)dgvCT).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmGLPost2GL_Load(object sender, EventArgs e)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Invalid comparison between Unknown and I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		((DataGridView)dgvCT).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
		((CheckBox)chkSelectAll).CheckedChanged -= chkSelectAll_CheckedChanged;
		((Form)this).Text = MyMenuInfo.bar.Trim();
		frmGLPost2GLFilter frmGLPost2GLFilter2 = new frmGLPost2GLFilter();
		frmGLPost2GLFilter frmGLPost2GLFilter3 = frmGLPost2GLFilter2;
		frmGLPost2GLFilter3.f_strMa_ph = base.MyMenuInfo.par1;
		frmGLPost2GLFilter3.f_strMa_ct = base.MyMenuInfo.par2;
		((Form)frmGLPost2GLFilter3).Text = MyMenuInfo.bar.Trim();
		frmGLPost2GLFilter3 = null;
		if ((int)((Form)frmGLPost2GLFilter2).ShowDialog((IWin32Window)(object)this) == 1)
		{
			dtmNgay1 = Conversions.ToDate(frmGLPost2GLFilter2.txtNgay1.Value);
			dtmNgay2 = Conversions.ToDate(frmGLPost2GLFilter2.txtNgay2.Value);
			strSo_ct1 = frmGLPost2GLFilter2.txtSo_ct1.Text.Trim();
			strSo_ct2 = frmGLPost2GLFilter2.txtSo_ct2.Text.Trim();
			strPost = Conversions.ToString(((ComboBox)frmGLPost2GLFilter2.cboStatus).SelectedIndex);
			strMa_ct = Conversions.ToString(((ListControl)frmGLPost2GLFilter2.cboMa_ct).SelectedValue);
			lblFrom_To.Text = frmGLPost2GLFilter2.f_strNhan_in;
			IGLPost2GLDAO iGLPost2GLDAO = (IGLPost2GLDAO)DAOFactory.CreateDAOInstance("GLPost2GLDAO", "GLPost2GL");
			DataSet dataSet = new DataSet();
			dataSet = iGLPost2GLDAO.GetVoucher2Post(CompanyInformations.CompanyID, dtmNgay1, dtmNgay2, strSo_ct1, strSo_ct2, strMa_ct, strPost);
			if (dataSet.Tables[0].Rows.Count == 0)
			{
				CMessageBox.Show(50016);
				check = false;
			}
			else
			{
				f_tblCT = dataSet.Tables[0];
				f_tblCT.AcceptChanges();
				((DataGridView)dgvCT).DataSource = f_tblCT.DefaultView;
				DataRow dataRow = dataSet.Tables[1].NewRow();
				dataRow["ma_ct"] = base.MyMenuInfo.par1;
				dataRow["ten_ct"] = RuntimeHelpers.GetObjectValue(((ComboBox)cboCT).Items[0]);
				dataSet.Tables[1].Rows.Add(dataRow);
				List<VoucherInfoDatasource> dataSource = (from v1 in dataSet.Tables[1].AsEnumerable()
					join v in frmGLPost2GLFilter2.f_voucherList on v1["ma_ct"] equals v.ma_ct
					select v).ToList();
				((ListControl)cboCT).DisplayMember = "ten_ct";
				((ListControl)cboCT).ValueMember = "ma_ct";
				((ComboBox)cboCT).DataSource = dataSource;
				((ListControl)cboCT).SelectedValue = strMa_ct;
				check = true;
			}
			chkSelectAll.Checked = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(strPost, "1", false) == 0, (object)true, (object)false));
			((CheckBox)chkSelectAll).CheckedChanged += chkSelectAll_CheckedChanged;
			iGLPost2GLDAO.Destroy();
		}
		else
		{
			check = false;
		}
		((Form)frmGLPost2GLFilter2).Close();
		((Component)(object)frmGLPost2GLFilter2).Dispose();
	}

	private void frmGLPost2GL_Shown(object sender, EventArgs e)
	{
		if (!check)
		{
			((Form)this).Close();
		}
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		DataRow[] array = f_tblCT.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ma_ct like '", ((ListControl)cboCT).SelectedValue), (object)"%'")), "", DataViewRowState.ModifiedCurrent);
		if (array.Count() == 0)
		{
			CMessageBox.Show(50055);
			return;
		}
		iRet = 0;
		disableButtons();
		((Control)prbExecute).Visible = true;
		intMax = array.Count();
		intCount = 0;
		bgWork.RunWorkerAsync(array);
	}

	private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
	{
		if (f_tblCT != null)
		{
			int num = Conversions.ToInteger(Interaction.IIf(Conversions.ToBoolean(chkSelectAll.Checked), (object)1, (object)0));
			DataRow[] array = f_tblCT.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ma_ct like '", ((ListControl)cboCT).SelectedValue), (object)"%'")));
			foreach (DataRow dataRow in array)
			{
				dataRow["post2gl"] = num;
			}
		}
	}

	private void bgWork_DoWork(object sender, DoWorkEventArgs e)
	{
		DataRow[] array = (DataRow[])e.Argument;
		_waitEvent = new ManualResetEvent(initialState: false);
		DataRow[] array2 = array;
		foreach (DataRow state in array2)
		{
			ThreadPool.QueueUserWorkItem([SpecialName] [DebuggerStepThrough] (object a0) =>
			{
				Post2Gl(RuntimeHelpers.GetObjectValue(a0));
			}, state);
		}
		_waitEvent.WaitOne();
	}

	private void bgWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		prbExecute.Value = e.ProgressPercentage;
	}

	private void bgWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)prbExecute).InvokeRequired)
		{
			Action<int> action = SetPrbValue;
			((Control)prbExecute).Invoke((Delegate)action, new object[1] { 0 });
		}
		else
		{
			prbExecute.Value = 0;
		}
		if (((Control)prbExecute).InvokeRequired)
		{
			Action action2 = SetPrbVisible;
			((Control)prbExecute).Invoke((Delegate)action2);
		}
		else
		{
			((Control)prbExecute).Visible = false;
		}
		if (iRet == 0)
		{
			CMessageBox.Show(50015);
		}
		else
		{
			CMessageBox.Show(50020);
		}
		f_tblCT.AcceptChanges();
		Action action3 = disableButtons;
		((Control)cmdCancel).Invoke((Delegate)action3);
	}

	private void cboCT_SelectedValueChanged(object sender, EventArgs e)
	{
		if (f_tblCT != null)
		{
			f_tblCT.DefaultView.RowFilter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ma_ct like '", ((ListControl)cboCT).SelectedValue), (object)"%'"));
		}
	}

	private void SetPrbVisible()
	{
		((Control)prbExecute).Visible = !((Control)prbExecute).Visible;
	}

	private void SetPrbValue(int intVal)
	{
		prbExecute.Value = intVal;
	}

	private void disableButtons()
	{
		((Control)cmdCancel).Enabled = !((Control)cmdCancel).Enabled;
		((Control)cmdOK).Enabled = !((Control)cmdOK).Enabled;
	}

	private int Post2Gl(object oDrw)
	{
		DataRow dataRow = (DataRow)oDrw;
		IGLPost2GLDAO iGLPost2GLDAO = (IGLPost2GLDAO)DAOFactory.CreateDAOInstance("GLPost2GLDAO", "GLPost2GL");
		int num = iGLPost2GLDAO.Post2GL(CompanyInformations.CompanyID, Conversions.ToString(dataRow["stt_Rec"]), Conversions.ToString(dataRow["ma_ct"]), Conversions.ToString(dataRow["post2gl"]));
		Thread.Sleep(10);
		iGLPost2GLDAO.Destroy();
		if (num != 0)
		{
			Interlocked.Exchange(ref iRet, 1);
		}
		int num2 = Interlocked.Increment(ref intCount);
		bgWork.ReportProgress(GetPercent(num2));
		long num3 = num2;
		long location = intMax;
		long num4 = Interlocked.Read(in location);
		intMax = checked((int)location);
		if (num3 == num4)
		{
			_waitEvent.Set();
		}
		return num;
	}

	private int GetPercent(int i)
	{
		return checked((int)Math.Round((double)i / (double)intMax * 100.0));
	}
}
