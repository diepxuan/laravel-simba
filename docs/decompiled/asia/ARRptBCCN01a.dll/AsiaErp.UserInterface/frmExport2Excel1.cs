using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmExport2Excel1 : frmAsiaRoot
{
	private enum ExcelColor : ushort
	{
		black = 1,
		white = 2,
		red = 3,
		green = 4,
		blue = 5,
		yellow = 6,
		pink = 7,
		darkblue = 25,
		coban = 20
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("dgvFilter")]
	private AsInputDGV _dgvFilter;

	[AccessedThroughProperty("sfdExcel")]
	private SaveFileDialog _sfdExcel;

	[AccessedThroughProperty("txtFileName")]
	private TextBox _txtFileName;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("cmdBrowse")]
	private Button _cmdBrowse;

	[AccessedThroughProperty("colName")]
	private DataGridViewTextBoxColumn _colName;

	[AccessedThroughProperty("colSelect")]
	private DataGridViewCheckBoxColumn _colSelect;

	[AccessedThroughProperty("colSum")]
	private DataGridViewCheckBoxColumn _colSum;

	[AccessedThroughProperty("tmExec")]
	private Timer _tmExec;

	[AccessedThroughProperty("cmdSumCond")]
	private Button _cmdSumCond;

	[AccessedThroughProperty("chkSumAll")]
	private CheckBox _chkSumAll;

	[AccessedThroughProperty("chkSelAll")]
	private CheckBox _chkSelAll;

	public ReportInformation f_rptInfo;

	public string f_sNhan_In;

	[AccessedThroughProperty("f_dgvBC")]
	private AsDataGridView _f_dgvBC;

	public DataTable f_oTblPrint;

	public AsDictionary f_RptFormularFields;

	public string f_sFilterTitle;

	public DataTable f_oTblFilter;

	public const string DEFAULT_NUMERIC_FORMAT = "### ### ### ### ###";

	public object f_is;

	private Thread thex;

	private Thread thex1;

	protected virtual Button cmdCancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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

	protected virtual Button cmdOK
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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

	internal virtual AsInputDGV dgvFilter
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			DataGridViewDataErrorEventHandler val = new DataGridViewDataErrorEventHandler(dgvFilter_DataError);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(dgvFilter_CellEnter);
			if (_dgvFilter != null)
			{
				((DataGridView)_dgvFilter).DataError -= val;
				((DataGridView)_dgvFilter).CellEnter -= val2;
			}
			_dgvFilter = value;
			if (_dgvFilter != null)
			{
				((DataGridView)_dgvFilter).DataError += val;
				((DataGridView)_dgvFilter).CellEnter += val2;
			}
		}
	}

	internal virtual SaveFileDialog sfdExcel
	{
		[DebuggerNonUserCode]
		get
		{
			return _sfdExcel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_sfdExcel = value;
		}
	}

	internal virtual TextBox txtFileName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFileName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtFileName = value;
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

	internal virtual Button cmdBrowse
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdBrowse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdBrowse_Click;
			if (_cmdBrowse != null)
			{
				((Control)_cmdBrowse).Click -= eventHandler;
			}
			_cmdBrowse = value;
			if (_cmdBrowse != null)
			{
				((Control)_cmdBrowse).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn colName
	{
		[DebuggerNonUserCode]
		get
		{
			return _colName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_colName = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colSelect
	{
		[DebuggerNonUserCode]
		get
		{
			return _colSelect;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_colSelect = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colSum
	{
		[DebuggerNonUserCode]
		get
		{
			return _colSum;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_colSum = value;
		}
	}

	internal virtual Timer tmExec
	{
		[DebuggerNonUserCode]
		get
		{
			return _tmExec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tmExec_Tick;
			if (_tmExec != null)
			{
				_tmExec.Tick -= eventHandler;
			}
			_tmExec = value;
			if (_tmExec != null)
			{
				_tmExec.Tick += eventHandler;
			}
		}
	}

	internal virtual Button cmdSumCond
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSumCond;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmdSumCond = value;
		}
	}

	internal virtual CheckBox chkSumAll
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkSumAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkSumAll_CheckedChanged;
			if (_chkSumAll != null)
			{
				_chkSumAll.CheckedChanged -= eventHandler;
			}
			_chkSumAll = value;
			if (_chkSumAll != null)
			{
				_chkSumAll.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual CheckBox chkSelAll
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkSelAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkSelAll_CheckedChanged;
			if (_chkSelAll != null)
			{
				_chkSelAll.CheckedChanged -= eventHandler;
			}
			_chkSelAll = value;
			if (_chkSelAll != null)
			{
				_chkSelAll.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual AsDataGridView f_dgvBC
	{
		[DebuggerNonUserCode]
		get
		{
			return _f_dgvBC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_f_dgvBC = value;
		}
	}

	public frmExport2Excel1()
	{
		((Form)this).Load += frmExport2Excel_Load;
		__ENCAddToList(this);
		f_sFilterTitle = "";
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
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmExport2Excel1));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		cmdCancel = new Button();
		cmdOK = new Button();
		dgvFilter = new AsInputDGV();
		colName = new DataGridViewTextBoxColumn();
		colSelect = new DataGridViewCheckBoxColumn();
		colSum = new DataGridViewCheckBoxColumn();
		sfdExcel = new SaveFileDialog();
		txtFileName = new TextBox();
		Label1 = new Label();
		cmdBrowse = new Button();
		tmExec = new Timer(components);
		cmdSumCond = new Button();
		chkSumAll = new CheckBox();
		chkSelAll = new CheckBox();
		((ISupportInitialize)dgvFilter).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		((ButtonBase)cmdCancel).Image = (Image)componentResourceManager.GetObject("cmdCancel.Image");
		((ButtonBase)cmdCancel).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdCancel).ImeMode = (ImeMode)0;
		Button obj = cmdCancel;
		Point location = new Point(93, 306);
		((Control)obj).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj2 = cmdCancel;
		Size size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)cmdCancel).TabIndex = 4;
		((ButtonBase)cmdCancel).Text = "&Huỷ";
		((ButtonBase)cmdCancel).TextAlign = (ContentAlignment)64;
		((Control)cmdOK).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdOK).Image = (Image)(object)Resources.imgExecute;
		((ButtonBase)cmdOK).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdOK).ImeMode = (ImeMode)0;
		Button obj3 = cmdOK;
		location = new Point(12, 306);
		((Control)obj3).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		Button obj4 = cmdOK;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)cmdOK).TabIndex = 3;
		((ButtonBase)cmdOK).Text = "&Thực hiện";
		((ButtonBase)cmdOK).TextAlign = (ContentAlignment)64;
		((DataGridView)dgvFilter).AllowUserToAddRows = false;
		((DataGridView)dgvFilter).AllowUserToDeleteRows = false;
		((Control)dgvFilter).Anchor = (AnchorStyles)15;
		((DataGridView)dgvFilter).BackgroundColor = Color.White;
		((DataGridView)dgvFilter).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvFilter).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvFilter).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)colName,
			(DataGridViewColumn)colSelect,
			(DataGridViewColumn)colSum
		});
		((DataGridView)dgvFilter).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = dgvFilter;
		location = new Point(12, 12);
		((Control)asInputDGV).Location = location;
		((Control)dgvFilter).Name = "dgvFilter";
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvFilter).RowHeadersDefaultCellStyle = val;
		((DataGridView)dgvFilter).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = dgvFilter;
		size = new Size(521, 288);
		((Control)asInputDGV2).Size = size;
		((Control)dgvFilter).TabIndex = 2;
		((DataGridViewColumn)colName).DataPropertyName = "HeaderText";
		((DataGridViewColumn)colName).Frozen = true;
		((DataGridViewColumn)colName).HeaderText = "Tên trường";
		((DataGridViewColumn)colName).Name = "colName";
		((DataGridViewColumn)colName).ReadOnly = true;
		((DataGridViewColumn)colName).Width = 320;
		((DataGridViewColumn)colSelect).DataPropertyName = "sel";
		((DataGridViewColumn)colSelect).HeaderText = "Chọn";
		((DataGridViewColumn)colSelect).Name = "colSelect";
		((DataGridViewColumn)colSelect).Width = 70;
		((DataGridViewColumn)colSum).DataPropertyName = "sum";
		((DataGridViewColumn)colSum).HeaderText = "Cộng tổng";
		((DataGridViewColumn)colSum).Name = "colSum";
		((DataGridViewColumn)colSum).Width = 70;
		((Control)txtFileName).Enabled = false;
		TextBox obj5 = txtFileName;
		location = new Point(67, 49);
		((Control)obj5).Location = location;
		((Control)txtFileName).Name = "txtFileName";
		TextBox obj6 = txtFileName;
		size = new Size(411, 20);
		((Control)obj6).Size = size;
		((Control)txtFileName).TabIndex = 0;
		((Control)txtFileName).Visible = false;
		Label1.AutoSize = true;
		((Control)Label1).Enabled = false;
		Label label = Label1;
		location = new Point(10, 52);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(46, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 11;
		Label1.Text = "Save as";
		((Control)Label1).Visible = false;
		((Control)cmdBrowse).Enabled = false;
		Button obj7 = cmdBrowse;
		location = new Point(484, 47);
		((Control)obj7).Location = location;
		((Control)cmdBrowse).Name = "cmdBrowse";
		Button obj8 = cmdBrowse;
		size = new Size(32, 23);
		((Control)obj8).Size = size;
		((Control)cmdBrowse).TabIndex = 1;
		((ButtonBase)cmdBrowse).Text = "...";
		((ButtonBase)cmdBrowse).UseVisualStyleBackColor = true;
		((Control)cmdBrowse).Visible = false;
		((Control)cmdSumCond).Anchor = (AnchorStyles)10;
		((Control)cmdSumCond).Enabled = false;
		Button obj9 = cmdSumCond;
		location = new Point(205, 306);
		((Control)obj9).Location = location;
		((Control)cmdSumCond).Name = "cmdSumCond";
		Button obj10 = cmdSumCond;
		size = new Size(89, 23);
		((Control)obj10).Size = size;
		((Control)cmdSumCond).TabIndex = 5;
		((ButtonBase)cmdSumCond).Text = "Điều kiện tổng";
		((ButtonBase)cmdSumCond).UseVisualStyleBackColor = true;
		((Control)cmdSumCond).Visible = false;
		((Control)chkSumAll).Anchor = (AnchorStyles)6;
		((ButtonBase)chkSumAll).AutoSize = true;
		CheckBox obj11 = chkSumAll;
		location = new Point(473, 311);
		((Control)obj11).Location = location;
		((Control)chkSumAll).Name = "chkSumAll";
		CheckBox obj12 = chkSumAll;
		size = new Size(15, 14);
		((Control)obj12).Size = size;
		((Control)chkSumAll).TabIndex = 12;
		((ButtonBase)chkSumAll).UseVisualStyleBackColor = true;
		((Control)chkSelAll).Anchor = (AnchorStyles)6;
		((ButtonBase)chkSelAll).AutoSize = true;
		CheckBox obj13 = chkSelAll;
		location = new Point(402, 311);
		((Control)obj13).Location = location;
		((Control)chkSelAll).Name = "chkSelAll";
		CheckBox obj14 = chkSelAll;
		size = new Size(15, 14);
		((Control)obj14).Size = size;
		((Control)chkSelAll).TabIndex = 13;
		((ButtonBase)chkSelAll).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(545, 341);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)chkSelAll);
		((Control)this).Controls.Add((Control)(object)chkSumAll);
		((Control)this).Controls.Add((Control)(object)cmdSumCond);
		((Control)this).Controls.Add((Control)(object)cmdBrowse);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)txtFileName);
		((Control)this).Controls.Add((Control)(object)dgvFilter);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Name = "frmExport2Excel";
		((Form)this).Text = "Export 2 Excel";
		((ISupportInitialize)dgvFilter).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		((Form)this).DialogResult = (DialogResult)1;
		((Form)this).Close();
	}

	private void cmdBrowse_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)sfdExcel).ShowDialog();
		txtFileName.Text = ((FileDialog)sfdExcel).FileName;
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void frmExport2Excel_Load(object sender, EventArgs e)
	{
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		f_oTblFilter = new DataTable("Filter");
		f_oTblFilter.Columns.Add("DataPropertyName", typeof(string));
		f_oTblFilter.Columns.Add("HeaderText", typeof(string));
		f_oTblFilter.Columns.Add("Format", typeof(string));
		f_oTblFilter.Columns.Add("Numeric", typeof(bool));
		f_oTblFilter.Columns.Add("sel", typeof(bool));
		f_oTblFilter.Columns.Add("sum", typeof(bool));
		DataColumn[] primaryKey = new DataColumn[1] { f_oTblFilter.Columns["DataPropertyName"] };
		f_oTblFilter.PrimaryKey = primaryKey;
		foreach (DataGridViewColumn item in (BaseCollection)((DataGridView)f_dgvBC).Columns)
		{
			DataGridViewColumn val = item;
			if (!val.Visible)
			{
				continue;
			}
			DataRow dataRow = f_oTblFilter.NewRow();
			dataRow["DataPropertyName"] = val.DataPropertyName;
			dataRow["HeaderText"] = val.HeaderText;
			dataRow["Format"] = val.DefaultCellStyle.Format;
			dataRow["sel"] = true;
			DataColumn dataColumn = f_oTblPrint.Columns[val.DataPropertyName];
			if (Commons.isNumericType(dataColumn.DataType))
			{
				dataRow["Numeric"] = true;
				dataRow["sum"] = true;
			}
			else
			{
				dataRow["Numeric"] = false;
				dataRow["sum"] = false;
				if ((object)dataColumn.DataType == typeof(string))
				{
					dataRow["Format"] = "@";
				}
			}
			f_oTblFilter.Rows.Add(dataRow);
		}
		foreach (DataColumn column in f_oTblPrint.Columns)
		{
			if (!f_oTblFilter.Rows.Contains(column.ColumnName))
			{
				DataRow dataRow = f_oTblFilter.NewRow();
				dataRow["DataPropertyName"] = column.ColumnName;
				dataRow["HeaderText"] = column.ColumnName;
				dataRow["Format"] = "";
				dataRow["sel"] = false;
				if (Commons.isNumericType(column.DataType))
				{
					dataRow["Numeric"] = true;
					dataRow["Format"] = "### ### ###";
					dataRow["sum"] = true;
				}
				else
				{
					dataRow["Numeric"] = false;
					dataRow["sum"] = false;
				}
				f_oTblFilter.Rows.Add(dataRow);
			}
		}
		f_oTblFilter.AcceptChanges();
		((DataGridView)dgvFilter).DataSource = f_oTblFilter;
		txtFileName.Text = SystemInformations.RootPath + "\\Excel\\AsiaData.xls";
		((FileDialog)sfdExcel).DefaultExt = "*.xls";
		((FileDialog)sfdExcel).Filter = "Excel (*.xls)|*.xls";
	}

	protected virtual void Export2Excel()
	{
		//Discarded unreachable code: IL_00b0, IL_071a, IL_0728, IL_073f, IL_07cd, IL_07d8, IL_07dc, IL_07f5, IL_07f8, IL_07f9, IL_0803, IL_0807, IL_080f, IL_0812, IL_0813, IL_081a, IL_0837, IL_0886, IL_0892, IL_08b2, IL_08c3, IL_08e3, IL_08eb, IL_08ec, IL_08f1, IL_0915, IL_0918, IL_0919, IL_0920, IL_0921, IL_0953, IL_0954, IL_0956, IL_0966, IL_098b, IL_0996, IL_099f, IL_09ab, IL_09c6, IL_0a71, IL_0a72, IL_0bba, IL_0bc6, IL_0ca3, IL_0caf, IL_0cd0, IL_0d12, IL_0deb, IL_0df2, IL_0e03
		((Form)this).Close();
	}

	private string Convert2ExcelFormula(string sFormula, int myIndex, AsDictionary oDic)
	{
		int num = -1;
		bool flag = false;
		string text = "=";
		checked
		{
			short num2 = (short)(sFormula.Length - 1);
			short num3 = 0;
			while (true)
			{
				short num4 = num3;
				short num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				char c = sFormula[num3];
				switch (c)
				{
				case '+':
				case '-':
					if (num3 == 0)
					{
						text += Conversions.ToString(c);
						flag = true;
					}
					else
					{
						string key = sFormula.Substring(num + 1, num3 - num - 1);
						key = key.Trim();
						if (oDic.Contains(key))
						{
							text = text + "R[" + Operators.SubtractObject(oDic[key], (object)myIndex).ToString() + "]C";
						}
						else if (flag)
						{
							text = text.Substring(0, text.Length - 1);
						}
						text += Conversions.ToString(c);
					}
					num = num3;
					break;
				default:
					if (num3 == sFormula.Length - 1)
					{
						string key = sFormula.Substring(num + 1);
						text = ((!oDic.Contains(key)) ? text.Substring(0, text.Length - 1) : (text + "R[" + Operators.SubtractObject(oDic[key], (object)myIndex).ToString() + "]C"));
					}
					break;
				}
				num3 = (short)unchecked(num3 + 1);
			}
			text = text.Trim();
			if (Operators.CompareString(text, "=", false) == 0)
			{
				text = "";
			}
			return text;
		}
	}

	private string ConvertNumericFormat(string dgvFormat)
	{
		string[] array = dgvFormat.Split(new char[1] { '.' });
		if (array.Length == 0)
		{
			return "";
		}
		if (array.Length == 1)
		{
			return dgvFormat;
		}
		string text = array[1].Replace("#", "0");
		return "_(* " + array[0] + "." + text + "_);_(* (" + array[0] + "." + text + ");_(* \"-\"??_);_(@_)";
	}

	protected override bool ProcessKeyPreview(ref Message m)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		Keys val = (Keys)(((Message)(ref m)).WParam.ToInt32() & 0xFFFF);
		if (((Message)(ref m)).Msg == 256 && (int)val == 27)
		{
			((Form)this).Close();
			return false;
		}
		return base.ProcessKeyPreview(ref m);
	}

	private void tmExec_Tick(object sender, EventArgs e)
	{
		if (thex.IsAlive)
		{
		}
	}

	private void dgvFilter_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		DataGridViewCell currentCell = ((DataGridView)dgvFilter).CurrentCell;
		string name = ((DataGridView)dgvFilter).Columns[e.ColumnIndex].Name;
		if (Operators.CompareString(name, ((DataGridViewColumn)colSum).Name, false) == 0 && ((e.RowIndex >= 0 && Operators.ConditionalCompareObjectEqual(f_oTblFilter.DefaultView[e.RowIndex]["Numeric"], (object)false, false)) ? true : false))
		{
			currentCell.ReadOnly = true;
		}
	}

	private void dgvFilter_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
		e.ThrowException = false;
	}

	private void chkSelAll_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = chkSelAll.Checked;
		foreach (DataRowView item in f_oTblFilter.DefaultView)
		{
			item["sel"] = flag;
		}
		if (((DataGridView)dgvFilter).CurrentCell != null)
		{
			((DataGridView)dgvFilter).InvalidateRow(((DataGridView)dgvFilter).CurrentCell.RowIndex);
		}
	}

	private void chkSumAll_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = chkSumAll.Checked;
		foreach (DataRowView item in f_oTblFilter.DefaultView)
		{
			item["sum"] = flag;
		}
		if (((DataGridView)dgvFilter).CurrentCell != null)
		{
			((DataGridView)dgvFilter).InvalidateRow(((DataGridView)dgvFilter).CurrentCell.RowIndex);
		}
	}
}
