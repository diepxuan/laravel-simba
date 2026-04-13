using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmFakkts : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("dgvKK")]
	private AsDataGridView _dgvKK;

	[AccessedThroughProperty("btnImportExcel")]
	private Button _btnImportExcel;

	[AccessedThroughProperty("oFDialog")]
	private OpenFileDialog _oFDialog;

	[AccessedThroughProperty("dgvcFA_CODE")]
	private DataGridViewTextBoxColumn _dgvcFA_CODE;

	[AccessedThroughProperty("dgvcQuanlity")]
	private DataGridViewAsTextNumericColumn _dgvcQuanlity;

	[AccessedThroughProperty("dgvcDate")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcDate;

	private System.Data.DataTable SourceTable;

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual AsDataGridView dgvKK
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvKK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvKK = value;
		}
	}

	internal virtual Button btnImportExcel
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnImportExcel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnImportExcel_Click;
			if (_btnImportExcel != null)
			{
				((Control)_btnImportExcel).Click -= eventHandler;
			}
			_btnImportExcel = value;
			if (_btnImportExcel != null)
			{
				((Control)_btnImportExcel).Click += eventHandler;
			}
		}
	}

	internal virtual OpenFileDialog oFDialog
	{
		[DebuggerNonUserCode]
		get
		{
			return _oFDialog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_oFDialog = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcFA_CODE
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcFA_CODE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcFA_CODE = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcQuanlity
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcQuanlity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcQuanlity = value;
		}
	}

	internal virtual DataGridViewAsMaskedTextBoxColumn dgvcDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDate = value;
		}
	}

	private DictionaryComplexController FAKKController => ControllerFactory.GetDictionaryComplexControllerByCodeName("FA_KK");

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

	public frmFakkts(string menuid)
		: base(menuid)
	{
		((Form)this).Load += Fakkts_Load;
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmFakkts));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		Panel1 = new Panel();
		btnImportExcel = new Button();
		dgvKK = new AsDataGridView();
		oFDialog = new OpenFileDialog();
		dgvcFA_CODE = new DataGridViewTextBoxColumn();
		dgvcQuanlity = new DataGridViewAsTextNumericColumn();
		dgvcDate = new DataGridViewAsMaskedTextBoxColumn();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)dgvKK).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).Controls.Add((Control)(object)btnImportExcel);
		((Control)Panel1).Dock = (DockStyle)2;
		Panel panel = Panel1;
		System.Drawing.Point location = new System.Drawing.Point(0, 429);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		Size size = new Size(686, 37);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 0;
		((Control)btnImportExcel).Anchor = (AnchorStyles)10;
		((ButtonBase)btnImportExcel).Image = (Image)componentResourceManager.GetObject("btnImportExcel.Image");
		((ButtonBase)btnImportExcel).ImageAlign = (ContentAlignment)16;
		Button obj = btnImportExcel;
		location = new System.Drawing.Point(577, 6);
		((Control)obj).Location = location;
		((Control)btnImportExcel).Name = "btnImportExcel";
		Button obj2 = btnImportExcel;
		size = new Size(97, 23);
		((Control)obj2).Size = size;
		((Control)btnImportExcel).TabIndex = 42;
		((ButtonBase)btnImportExcel).Text = "&Import Excel";
		((ButtonBase)btnImportExcel).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnImportExcel).UseVisualStyleBackColor = true;
		((DataGridView)dgvKK).AllowUserToAddRows = false;
		((DataGridView)dgvKK).AllowUserToDeleteRows = false;
		((DataGridView)dgvKK).BackgroundColor = SystemColors.ActiveCaptionText;
		((DataGridView)dgvKK).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvKK).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)dgvKK).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvKK).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)dgvcFA_CODE,
			dgvcQuanlity,
			dgvcDate
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvKK).DefaultCellStyle = val2;
		((Control)dgvKK).Dock = (DockStyle)5;
		dgvKK.DoubleBuffered = false;
		((DataGridView)dgvKK).EditMode = (DataGridViewEditMode)0;
		dgvKK.EnabledExport2Excel = true;
		((DataGridView)dgvKK).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvKK;
		location = new System.Drawing.Point(0, 0);
		((Control)asDataGridView).Location = location;
		((Control)dgvKK).Name = "dgvKK";
		dgvKK.ReadOnly = true;
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvKK).RowHeadersDefaultCellStyle = val3;
		dgvKK.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvKK).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvKK;
		size = new Size(686, 429);
		((Control)asDataGridView2).Size = size;
		((Control)dgvKK).TabIndex = 1;
		((FileDialog)oFDialog).Filter = "Microsoft Excel  2007-2010 (*.xlsx)|*.xlsx|Microsoft Excel  2003 (*.xls)|*.xls ";
		((DataGridViewColumn)dgvcFA_CODE).DataPropertyName = "MA_TS";
		((DataGridViewColumn)dgvcFA_CODE).HeaderText = "Fa Code";
		((DataGridViewColumn)dgvcFA_CODE).Name = "dgvcFA_CODE";
		((DataGridViewColumn)dgvcFA_CODE).Width = 200;
		((DataGridViewColumn)dgvcQuanlity).DataPropertyName = "so_luong";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcQuanlity).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcQuanlity).HeaderText = "Quanlity";
		dgvcQuanlity.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcQuanlity).Name = "dgvcQuanlity";
		((DataGridViewColumn)dgvcQuanlity).Resizable = (DataGridViewTriState)1;
		dgvcQuanlity.SortMode = (DataGridViewColumnSortMode)1;
		dgvcQuanlity.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcQuanlity).Width = 300;
		((DataGridViewColumn)dgvcDate).DataPropertyName = "NGAY_KK";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcDate).DefaultCellStyle = val5;
		dgvcDate.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcDate).HeaderText = "Date";
		dgvcDate.Mask = "##/##/####";
		((DataGridViewColumn)dgvcDate).Name = "dgvcDate";
		((DataGridViewColumn)dgvcDate).Resizable = (DataGridViewTriState)1;
		dgvcDate.SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcDate).Width = 80;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(686, 466);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)dgvKK);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Name = "frmFakkts";
		((Form)this).Text = "frmFakkts";
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)dgvKK).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void btnImportExcel_Click(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		((FileDialog)oFDialog).InitialDirectory = Application.StartupPath;
		if ((int)((CommonDialog)oFDialog).ShowDialog() == 1 && ImportExcel(((FileDialog)oFDialog).FileName))
		{
			CMessageBox.Show(50015);
		}
	}

	private void Fakkts_Load(object sender, EventArgs e)
	{
		InitLoadData();
	}

	private bool ImportExcel(string PathExcel)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Invalid comparison between Unknown and I4
		DataSet dataSet = new DataSet();
		bool result;
		try
		{
			if (PathExcel.Equals(""))
			{
				CMessageBox.ShowWithFormat(50109, new object[1] { PathExcel });
				result = false;
			}
			else
			{
				Workbook workbook = null;
				Application application = new ApplicationClass();
				try
				{
					workbook = application.Workbooks.Open(PathExcel, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					CMessageBox.ShowWithFormat(50109, new object[1] { PathExcel });
					result = false;
					ProjectData.ClearProjectError();
					goto end_IL_0008;
				}
				int count = workbook.Worksheets.Count;
				int num = 1;
				while (true)
				{
					int num2 = num;
					int num3 = count;
					if (num2 > num3)
					{
						break;
					}
					Worksheet worksheet = (Worksheet)workbook.Worksheets[num];
					if (Operators.CompareString(worksheet.Name.ToString().ToUpper(), "FAKKTS", false) == 0)
					{
						OleDbConnection val = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0; data source=" + PathExcel + "; Extended Properties=Excel 8.0");
						OleDbDataAdapter val2 = new OleDbDataAdapter("select * from [" + worksheet.Name + "$]", val);
						((DbDataAdapter)(object)val2).Fill(dataSet, worksheet.Name);
					}
					num = checked(num + 1);
				}
				application.Quit();
				if (dataSet.Tables.Count == 0)
				{
					CMessageBox.ShowWithFormat(50109, new object[1] { PathExcel });
					result = false;
				}
				else
				{
					Process[] processesByName = Process.GetProcessesByName("EXCEL");
					Process[] array = processesByName;
					foreach (Process process in array)
					{
						process.Kill();
					}
					DataColumn dataColumn = new DataColumn();
					dataColumn.DataType = typeof(string);
					dataColumn.ColumnName = "Ma_cty";
					dataColumn.DefaultValue = CompanyInformations.CompanyID;
					DataColumn column = dataColumn;
					dataSet.Tables[0].Columns.Add(column);
					dataSet.Tables[0].Columns[0].ColumnName = "MA_TS";
					dataSet.Tables[0].Columns[1].ColumnName = "SO_LUONG";
					dataSet.Tables[0].Columns[2].ColumnName = "NGAY_KK";
					foreach (DataColumn column2 in SourceTable.Columns)
					{
						dataSet.Tables[0].Columns[column2.ColumnName].SetOrdinal(column2.Ordinal);
					}
					EnumerableRowCollection<DataRow> enumerableRowCollection = from dr in dataSet.Tables[0].AsEnumerable()
						where Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["MA_TS"]), isNum: false), (object)"", false)
						select (dr);
					if (!CheckMaExist(enumerableRowCollection))
					{
						foreach (DataRow item in enumerableRowCollection)
						{
							FAKKController.MyDAO.RequireTrans = true;
							if (FAKKController.Insert(item))
							{
								DateTimeFormatInfo dateTimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
								DateTime dateTime = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(item["Ngay_kk"]), dateTimeFormat);
								DataRow dataRow = SourceTable.NewRow();
								dataRow["ma_cty"] = RuntimeHelpers.GetObjectValue(item["ma_cty"]);
								dataRow["ma_ts"] = RuntimeHelpers.GetObjectValue(item["ma_ts"]);
								dataRow["so_luong"] = RuntimeHelpers.GetObjectValue(item["so_luong"]);
								dataRow["Ngay_kk"] = dateTime;
								SourceTable.Rows.Add(dataRow);
							}
							else
							{
								FAKKController.MyDAO.RollBackTrans();
							}
						}
						goto IL_070e;
					}
					if ((int)CMessageBox.Show(50196, SystemInformations.ProductFullName, (MessageBoxButtons)4) == 6)
					{
						foreach (DataRow item2 in enumerableRowCollection)
						{
							FAKKController.MyDAO.RequireTrans = true;
							if ((Operators.ConditionalCompareObjectEqual(Delete(item2), (object)0, false) && FAKKController.Insert(item2)) ? true : false)
							{
								DateTimeFormatInfo dateTimeFormat2 = CultureInfo.CurrentCulture.DateTimeFormat;
								DateTime dateTime2 = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(item2["Ngay_kk"]), dateTimeFormat2);
								DataRow dataRow2 = SourceTable.Rows.Find(new object[3]
								{
									CompanyInformations.CompanyID,
									RuntimeHelpers.GetObjectValue(item2["MA_TS"]),
									dateTime2
								});
								if (dataRow2 != null)
								{
									SourceTable.Rows.Remove(dataRow2);
								}
								DataRow dataRow3 = SourceTable.NewRow();
								dataRow3["ma_cty"] = RuntimeHelpers.GetObjectValue(item2["ma_cty"]);
								dataRow3["ma_ts"] = RuntimeHelpers.GetObjectValue(item2["ma_ts"]);
								dataRow3["so_luong"] = RuntimeHelpers.GetObjectValue(item2["so_luong"]);
								dataRow3["Ngay_kk"] = dateTime2;
								SourceTable.Rows.Add(dataRow3);
								SourceTable.AcceptChanges();
							}
							else
							{
								FAKKController.MyDAO.RollBackTrans();
							}
						}
						goto IL_070e;
					}
					result = false;
				}
			}
			end_IL_0008:;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Helper.ProcessError(ex4.ToString());
			CMessageBox.ShowWithFormat(50109, new object[1] { PathExcel });
			result = false;
			ProjectData.ClearProjectError();
		}
		finally
		{
			FAKKController.MyDAO.CommitTrans();
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
		goto IL_0713;
		IL_070e:
		result = true;
		goto IL_0713;
		IL_0713:
		return result;
	}

	private bool CheckMaExist(EnumerableRowCollection pRows)
	{
		foreach (object item in (IEnumerable)pRows)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(item);
			DateTimeFormatInfo dateTimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
			DateTime dateTime = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { "Ngay_kk" }, (string[])null)), dateTimeFormat);
			DataRow dataRow = SourceTable.Rows.Find(new object[3]
			{
				CompanyInformations.CompanyID,
				RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { "MA_TS" }, (string[])null)),
				dateTime
			});
			if (dataRow != null)
			{
				return true;
			}
		}
		return false;
	}

	private object Delete(DataRow dr)
	{
		List<object> list = new List<object>();
		list.Add(CompanyInformations.CompanyID);
		list.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["ma_ts"]), isNum: false)));
		list.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["ngay_kk"]), isNum: false)));
		list.Add(0);
		return Commons.ExecuteStoredProcedure(AsiaErp.Framework.Environment.GetDAOInformation("FAKKTS").del_sp, list.ToArray());
	}

	private void InitLoadData()
	{
		SourceTable = FAKKController.GetData(CompanyInformations.CompanyID);
		DataColumn[] primaryKey = new DataColumn[4]
		{
			SourceTable.Columns["ma_cty"],
			SourceTable.Columns["ma_ts"],
			SourceTable.Columns["ngay_kk"],
			null
		};
		SourceTable.PrimaryKey = primaryKey;
		((DataGridView)dgvKK).DataSource = SourceTable;
		((Form)this).Text = MyMenuInfo.bar;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (((Message)(ref msg)).WParam == (IntPtr)27)
		{
			((Form)this).Close();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}
}
