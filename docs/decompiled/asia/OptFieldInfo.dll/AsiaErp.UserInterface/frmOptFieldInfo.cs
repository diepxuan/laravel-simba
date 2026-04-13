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
public class frmOptFieldInfo : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("dtcSTT")]
	private DataGridTextBoxColumn _dtcSTT;

	[AccessedThroughProperty("dtcDescrpt")]
	private DataGridTextBoxColumn _dtcDescrpt;

	[AccessedThroughProperty("dtcLength")]
	private DataGridTextBoxColumn _dtcLength;

	[AccessedThroughProperty("dtcCaption")]
	private DataGridTextBoxColumn _dtcCaption;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdExit")]
	private Button _cmdExit;

	[AccessedThroughProperty("dgvOpt")]
	private AsDataGridView _dgvOpt;

	[AccessedThroughProperty("Column5")]
	private DataGridViewAsTextNumericColumn _Column5;

	[AccessedThroughProperty("Column1")]
	private DataGridViewTextBoxColumn _Column1;

	[AccessedThroughProperty("Column2")]
	private DataGridViewTextBoxColumn _Column2;

	[AccessedThroughProperty("Column3")]
	private DataGridViewAsTextNumericColumn _Column3;

	[AccessedThroughProperty("Column4")]
	private DataGridViewTextBoxColumn _Column4;

	[AccessedThroughProperty("Column6")]
	private DataGridViewTextBoxColumn _Column6;

	private DataTable f_dmopt;

	internal virtual DataGridTextBoxColumn dtcSTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _dtcSTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dtcSTT = value;
		}
	}

	internal virtual DataGridTextBoxColumn dtcDescrpt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dtcDescrpt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dtcDescrpt = value;
		}
	}

	internal virtual DataGridTextBoxColumn dtcLength
	{
		[DebuggerNonUserCode]
		get
		{
			return _dtcLength;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dtcLength = value;
		}
	}

	internal virtual DataGridTextBoxColumn dtcCaption
	{
		[DebuggerNonUserCode]
		get
		{
			return _dtcCaption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dtcCaption = value;
		}
	}

	internal virtual Button cmdOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOk_Click;
			if (_cmdOk != null)
			{
				((Control)_cmdOk).Click -= eventHandler;
			}
			_cmdOk = value;
			if (_cmdOk != null)
			{
				((Control)_cmdOk).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdExit_Click;
			if (_cmdExit != null)
			{
				((Control)_cmdExit).Click -= eventHandler;
			}
			_cmdExit = value;
			if (_cmdExit != null)
			{
				((Control)_cmdExit).Click += eventHandler;
			}
		}
	}

	internal virtual AsDataGridView dgvOpt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvOpt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvOpt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn Column5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column5 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column2 = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn Column3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column3 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column4 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column6 = value;
		}
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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		cmdOk = new Button();
		cmdExit = new Button();
		dgvOpt = new AsDataGridView();
		Column5 = new DataGridViewAsTextNumericColumn();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewAsTextNumericColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		((ISupportInitialize)dgvOpt).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdOk).Anchor = (AnchorStyles)6;
		Button obj = cmdOk;
		Point location = new Point(3, 259);
		((Control)obj).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		Button obj2 = cmdOk;
		Size size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)cmdOk).TabIndex = 1;
		((ButtonBase)cmdOk).Text = "&Lưu";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = true;
		((Control)cmdExit).Anchor = (AnchorStyles)6;
		cmdExit.DialogResult = (DialogResult)2;
		Button obj3 = cmdExit;
		location = new Point(84, 259);
		((Control)obj3).Location = location;
		((Control)cmdExit).Name = "cmdExit";
		Button obj4 = cmdExit;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)cmdExit).TabIndex = 2;
		((ButtonBase)cmdExit).Text = "&Quay ra";
		((ButtonBase)cmdExit).UseVisualStyleBackColor = true;
		((DataGridView)dgvOpt).AllowUserToAddRows = false;
		((DataGridView)dgvOpt).AllowUserToDeleteRows = false;
		((Control)dgvOpt).Anchor = (AnchorStyles)15;
		((DataGridView)dgvOpt).BackgroundColor = Color.White;
		((DataGridView)dgvOpt).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvOpt).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvOpt).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			Column5,
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column6
		});
		dgvOpt.DoubleBuffered = false;
		((DataGridView)dgvOpt).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvOpt).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvOpt;
		location = new Point(3, 3);
		((Control)asDataGridView).Location = location;
		((Control)dgvOpt).Name = "dgvOpt";
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvOpt).RowHeadersDefaultCellStyle = val;
		dgvOpt.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvOpt).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvOpt;
		size = new Size(548, 250);
		((Control)asDataGridView2).Size = size;
		((Control)dgvOpt).TabIndex = 3;
		((DataGridViewColumn)Column5).DataPropertyName = "Stt";
		val2.Alignment = (DataGridViewContentAlignment)64;
		val2.Format = "### ### ### ###.##";
		((DataGridViewColumn)Column5).DefaultCellStyle = val2;
		((DataGridViewColumn)Column5).HeaderText = "STT";
		Column5.Mask = "### ### ### ###.##";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewColumn)Column5).ReadOnly = true;
		Column5.SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)Column5).Visible = false;
		((DataGridViewColumn)Column5).Width = 50;
		((DataGridViewColumn)Column1).DataPropertyName = "Field";
		((DataGridViewColumn)Column1).HeaderText = "Tên trường";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewColumn)Column1).ReadOnly = true;
		((DataGridViewColumn)Column2).DataPropertyName = "descrpt";
		((DataGridViewColumn)Column2).HeaderText = "Diễn giải";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewColumn)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 120;
		((DataGridViewColumn)Column3).DataPropertyName = "length";
		val3.Alignment = (DataGridViewContentAlignment)64;
		val3.Format = "### ### ### ###.##";
		((DataGridViewColumn)Column3).DefaultCellStyle = val3;
		((DataGridViewColumn)Column3).HeaderText = "Độ dài";
		Column3.Mask = "### ### ### ###.##";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewColumn)Column3).ReadOnly = true;
		Column3.SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)Column4).DataPropertyName = "caption";
		((DataGridViewColumn)Column4).HeaderText = "Tiêu đề";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewColumn)Column4).Width = 120;
		((DataGridViewColumn)Column6).HeaderText = "Column6";
		((DataGridViewColumn)Column6).Name = "Column6";
		((DataGridViewColumn)Column6).Visible = false;
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOk;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)cmdExit;
		size = new Size(555, 287);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)dgvOpt);
		((Control)this).Controls.Add((Control)(object)cmdExit);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Name = "frmOptFieldInfo";
		((Form)this).Text = "Danh mục các trường tự do";
		((ISupportInitialize)dgvOpt).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public frmOptFieldInfo(string menuid)
		: base(menuid)
	{
		((Form)this).Load += frmOptFieldInfo_Load;
		f_dmopt = new DataTable();
		InitializeComponent();
	}

	private void cmdExit_Click(object sender, EventArgs e)
	{
		((Component)(object)this).Dispose();
	}

	private void cmdOk_Click(object sender, EventArgs e)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		DataRow[] array = f_dmopt.Select("Stt<>0", "", DataViewRowState.ModifiedCurrent);
		OptFieldDAO optFieldDAO = (OptFieldDAO)DAOFactory.CreateDAOInstance("OptFieldDAO", "OptFieldInfo", a_blnIsSysDB: true);
		bool flag = true;
		DataRow[] array2 = array;
		foreach (DataRow dataRow in array2)
		{
			if (flag)
			{
				optFieldDAO.UpdOptField(Conversions.ToInteger(dataRow["Stt"]), Conversions.ToString(dataRow["Field"]), Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["Caption"]), isNum: false)), Conversions.ToString(dataRow["LUser"]));
				continue;
			}
			flag = false;
			break;
		}
		CMessageBox.Show(50015);
		optFieldDAO.Destroy();
	}

	private void frmOptFieldInfo_Load(object sender, EventArgs e)
	{
		((DataGridView)dgvOpt).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
		OptFieldDAO optFieldDAO = (OptFieldDAO)DAOFactory.CreateDAOInstance("OptFieldDAO", "OptFieldInfo", a_blnIsSysDB: true);
		f_dmopt = optFieldDAO.GetOptField();
		((DataGridView)dgvOpt).DataSource = f_dmopt;
	}
}
