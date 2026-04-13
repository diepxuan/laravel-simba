using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmARRptBCCN01a : frmReport
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
		coban = 20,
		purple = 24
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblMa_tk")]
	private Label _lblMa_tk;

	private bool _selectedAll;

	private int colIndex;

	private int rowIndex;

	private int maxColIndex;

	private int maxRowIndex;

	private bool hasSUM;

	private bool hasBoldColumn;

	private bool hasFormulaColumn;

	private bool hasCodeColumn;

	private DataView dvf;

	private Application excelapp;

	private Workbook wBook;

	private Worksheet wSheet;

	private Microsoft.Office.Interop.Excel.Range range;

	internal virtual Label lblTen_Tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk = value;
		}
	}

	internal virtual AsTextBox txtTk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk = value;
		}
	}

	internal virtual Label lblMa_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_tk = value;
		}
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

	public frmARRptBCCN01a(string MenuId)
		: base(MenuId)
	{
		__ENCAddToList(this);
		_selectedAll = false;
		colIndex = 0;
		rowIndex = 0;
		maxColIndex = 0;
		maxRowIndex = 0;
		hasSUM = false;
		hasBoldColumn = false;
		hasFormulaColumn = false;
		hasCodeColumn = false;
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected O, but got Unknown
		lblTen_Tk = new Label();
		txtTk = new AsTextBox();
		lblMa_tk = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(577, 274);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_tk);
		TabPage obj = tabFilter;
		size = new Size(569, 245);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		Label obj2 = lbl2;
		System.Drawing.Point location = new System.Drawing.Point(277, 81);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 2;
		Button obj3 = cmdExcel;
		location = new System.Drawing.Point(700, -49);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new System.Drawing.Point(296, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new System.Drawing.Point(619, -49);
		((Control)obj4).Location = location;
		((Control)cmdModifyReport).TabIndex = 10;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new System.Drawing.Point(206, 77);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj5 = cboKyBc;
		location = new System.Drawing.Point(110, 77);
		((Control)obj5).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj6 = lblKyBc;
		location = new System.Drawing.Point(24, 81);
		((Control)obj6).Location = location;
		ComboBox obj7 = cboMau_bc;
		location = new System.Drawing.Point(110, 24);
		((Control)obj7).Location = location;
		((Control)cboMau_bc).TabIndex = 9;
		AsTextBox asTextBox = txtMa_Nt;
		location = new System.Drawing.Point(110, 130);
		((Control)asTextBox).Location = location;
		Label obj8 = lblMauBC;
		location = new System.Drawing.Point(155, 129);
		((Control)obj8).Location = location;
		RadioButton obj9 = optVND;
		location = new System.Drawing.Point(242, 128);
		((Control)obj9).Location = location;
		((Control)optVND).TabIndex = 6;
		RadioButton obj10 = optNt;
		location = new System.Drawing.Point(296, 129);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 7;
		Label obj11 = lblMa_nt;
		location = new System.Drawing.Point(24, 132);
		((Control)obj11).Location = location;
		Button obj12 = cmdOk;
		location = new System.Drawing.Point(26, 195);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 8;
		Label obj13 = lblTieu_de;
		location = new System.Drawing.Point(24, 55);
		((Control)obj13).Location = location;
		TextBox obj14 = txtTieu_De;
		location = new System.Drawing.Point(110, 51);
		((Control)obj14).Location = location;
		((Control)txtTieu_De).TabIndex = 11;
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj15 = lblTen_Tk;
		location = new System.Drawing.Point(206, 108);
		((Control)obj15).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj16 = lblTen_Tk;
		size = new Size(344, 13);
		((Control)obj16).Size = size;
		((Control)lblTen_Tk).TabIndex = 1099;
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = true;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTk;
		location = new System.Drawing.Point(110, 104);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		txtTk.LookupWhereCondition = "tk_cn=1";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk;
		txtTk.SD = true;
		AsTextBox asTextBox3 = txtTk;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 3;
		txtTk.UseAutoCompleteSource = true;
		lblMa_tk.AutoSize = true;
		lblMa_tk.ImeMode = (ImeMode)0;
		Label obj17 = lblMa_tk;
		location = new System.Drawing.Point(24, 107);
		((Control)obj17).Location = location;
		((Control)lblMa_tk).Name = "lblMa_tk";
		Label obj18 = lblMa_tk;
		size = new Size(55, 13);
		((Control)obj18).Size = size;
		((Control)lblMa_tk).TabIndex = 1098;
		lblMa_tk.Text = "Tài khoản";
		lblMa_tk.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(577, 296);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmARRptBCCN01a";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		base.InitOtherComponents();
		((DataGridView)dgvBC).CellContentClick += new DataGridViewCellEventHandler(dgvBC_CellContentClick);
	}

	protected override bool LoadData()
	{
		if (((TextBox)txtTk).Text.Trim().Length == 0)
		{
			return false;
		}
		((Control)txtTk).Select();
		((Control)cmdOk).Select();
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtTk).Text);
		arrayList.Add("");
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: false, MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		base.MyFomularFields.Add("tk", ((TextBox)txtTk).Text);
		base.MyFomularFields.Add("ten_tk", lblTen_Tk.Text);
		return true;
	}

	protected override bool ValidData()
	{
		return ChkEmtyTextBox((TextBox)(object)txtTk);
	}

	protected override void ViewCrystalBySource()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (((TextBox)txtTk).Text.Trim().Length != 0)
		{
			if (!ValidateData())
			{
				CMessageBox.Show(50118);
				return;
			}
			base.MyCrystalSource = LoadDataToCry();
			base.ViewCrystalBySource();
		}
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		DataRowView dataRowView = get_MyDGVSource(isSet2Print: true).DefaultView[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
		if ((int)keycode != 116 || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_kh"]), isNum: false), (object)"", false) ? true : false))
		{
			base.CancelDrilldown = true;
			return null;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(((TextBox)txtTk).Text);
		arrayList.Add(dataRowView["ma_kh"].ToString());
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		filterCondition4title = dataRowView["ma_kh"].ToString().Trim() + " - " + dataRowView["ten_kh"].ToString().Trim();
		if (!base.MyFomularFields.Contains("ngay_ct2"))
		{
			base.MyFomularFields.Add("ngay_ct2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		}
		if (!base.MyFomularFields.Contains("ngay_ct1"))
		{
			base.MyFomularFields.Add("ngay_ct1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		}
		return arrayList;
	}

	private string GetFilterTitle()
	{
		return "";
	}

	private void dgvBC_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		string text = "";
		string text2 = "";
		if (Operators.ConditionalCompareObjectEqual(get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["ma_kh"], (object)"", false))
		{
			DataRow[] array = get_MyDGVSource(isSet2Print: true).Select("ma_kh<>''");
			foreach (DataRow dataRow in array)
			{
				dataRow["TAG"] = Operators.NotObject(dataRow["TAG"]);
			}
		}
		else if (((DataGridView)dgvBC).CurrentCell.ColumnIndex == ((DataGridViewBand)((DataGridView)dgvBC).Columns["TAG"]).Index)
		{
			get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["TAG"] = Operators.NotObject(get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["TAG"]);
		}
		text = Conversions.ToString(get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["ten_kh"]);
		text2 = Conversions.ToString(get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["bold"]);
		bool flag = Conversions.ToBoolean(get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["TAG"]);
		if (((DataGridView)dgvBC).CurrentCell.ColumnIndex != ((DataGridViewBand)((DataGridView)dgvBC).Columns["TAG"]).Index || !((Operators.CompareString(text, "Tổng cộng", false) == 0) & (Operators.CompareString(text2, "1", false) == 0)))
		{
			return;
		}
		foreach (DataRow row in get_MyDGVSource(isSet2Print: true).Rows)
		{
			row["TAG"] = flag;
		}
	}

	private System.Data.DataTable LoadDataToCry()
	{
		string text = get_MyDGVSource(isSet2Print: true).Select("TAG=1 and ma_kh<>'' ").Aggregate("", [SpecialName] (string current, DataRow rows) => Conversions.ToString(Operators.AddObject(Operators.AddObject((object)current, rows["ma_kh"]), (object)",")));
		if (text.Length > 0)
		{
			text = text.Substring(0, checked(text.Length - 1));
			ArrayList arrayList = new ArrayList();
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			arrayList.Add(((TextBox)txtTk).Text);
			arrayList.Add(text);
			arrayList.Add(((TextBox)txtMa_Nt).Text);
			return Commons.GetDataSet("asARRptBCCN01a_Crys", arrayList.ToArray()).Tables[0];
		}
		return null;
	}

	private bool ValidateData()
	{
		return get_MyDGVSource(isSet2Print: true).Select("TAG=1").Any();
	}

	protected override void Ex2Excel()
	{
		Thread thread = new Thread(ThreadProcessEx2Excel);
		thread.CurrentCulture = new CultureInfo("en-US");
		thread.Start();
	}

	private void ThreadProcessEx2Excel()
	{
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Invalid comparison between Unknown and I4
		string text = "";
		foreach (ReportDrillDownInfo item in MyDrillDown)
		{
			if (Operators.CompareString(item.press_key_name, "F5", false) == 0)
			{
				text = item.drilldown_menuid;
			}
		}
		if (Operators.CompareString(text, "", false) == 0)
		{
			return;
		}
		ReportInformation reportInformation = (ReportInformation)AsiaErp.Framework.Environment.GetReportInformation(text)[0];
		AsDataGridView asDataGridView = new AsDataGridView();
		string formatedFieldList = ((!optNt.Checked) ? reportInformation.formated_col_list : reportInformation.formated_col_list_nt);
		bool flag = false;
		DataRow[] array = get_MyDGVSource(isSet2Print: true).Select("TAG=1 and ma_kh<>'' ");
		if (array == null || array.Length == 0)
		{
			return;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtTk).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(array[0]["ma_kh"]));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		System.Data.DataTable dataTable = Commons.GetDataTable("asARRptBCCN01a_Crys", arrayList.ToArray());
		((DataGridView)asDataGridView).Columns.Clear();
		Commons.ReportGridviewBrowse(asDataGridView, dataTable, formatedFieldList);
		frmExport2Excel1 frmExport2Excel2 = new frmExport2Excel1();
		frmExport2Excel2.f_dgvBC = asDataGridView;
		frmExport2Excel2.f_oTblPrint = dataTable;
		frmExport2Excel2.f_rptInfo = reportInformation;
		string text2 = "";
		string text3 = "";
		text2 = ((Operators.CompareString(((KyBaoCao)cboKyBc.SelectedItem).ma, "NGAY", false) != 0) ? (((KyBaoCao)cboKyBc.SelectedItem).nhan_in + SystemInformations.FinancialYear) : (lblKyBc.Text + ":" + ((MaskedTextBox)txtNgay1).Text + lbl2.Text + ((MaskedTextBox)txtNgay2).Text));
		if (MyFomularFields.Contains("strSubTitle"))
		{
			text2 = Conversions.ToString(MyFomularFields["strSubTitle"]);
		}
		text3 = lblMa_tk.Text.Trim() + ": " + ((TextBox)txtTk).Text.Trim() + " - " + lblTen_Tk.Text.Trim();
		frmExport2Excel2.f_RptFormularFields = MyFomularFields;
		DialogResult val = ((Form)frmExport2Excel2).ShowDialog();
		if ((int)val == 2)
		{
			((Component)(object)frmExport2Excel2).Dispose();
			return;
		}
		dvf = frmExport2Excel2.f_oTblFilter.DefaultView;
		excelapp = new ApplicationClass();
		wBook = excelapp.Workbooks.Add(Missing.Value);
		wSheet = (Worksheet)wBook.ActiveSheet;
		rowIndex = 8;
		string sTieu_De_Khach_Hang = Conversions.ToString(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(array[0]["ma_kh"]), isNum: false), (object)" - "), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(array[0]["ten_kh"]), isNum: false)));
		InitHeader(frmExport2Excel2.f_rptInfo, text3, text2);
		InitDataHeader(asDataGridView, dataTable, frmExport2Excel2.f_oTblFilter, sTieu_De_Khach_Hang);
		checked
		{
			int num = rowIndex + 1;
			E2E(asDataGridView, dataTable);
			int num2 = array.Length - 1;
			int num3 = 1;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				arrayList.Clear();
				arrayList.Add(CompanyInformations.CompanyID);
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
				arrayList.Add(((TextBox)txtTk).Text);
				arrayList.Add(RuntimeHelpers.GetObjectValue(array[num3]["ma_kh"]));
				arrayList.Add(((TextBox)txtMa_Nt).Text);
				dataTable = Commons.GetDataTable("asARRptBCCN01a_Crys", arrayList.ToArray());
				if (dataTable != null)
				{
					rowIndex = maxRowIndex + 1;
					sTieu_De_Khach_Hang = Conversions.ToString(Operators.AddObject(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(array[num3]["ma_kh"]), isNum: false), (object)" - "), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(array[num3]["ten_kh"]), isNum: false)));
					InitDataHeader(asDataGridView, dataTable, frmExport2Excel2.f_oTblFilter, sTieu_De_Khach_Hang);
					E2E(asDataGridView, dataTable);
				}
				num3++;
			}
			NewLateBinding.LateCall(wSheet.Cells[1, 1], (Type)null, "select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			range.EntireColumn.AutoFit();
			excelapp.DisplayAlerts = false;
			excelapp.Visible = true;
			Marshal.ReleaseComObject(wSheet);
			wSheet = null;
			Marshal.ReleaseComObject(wBook);
			wBook = null;
			Marshal.ReleaseComObject(excelapp);
			excelapp = null;
			GC.Collect();
			GC.WaitForPendingFinalizers();
			((Component)(object)frmExport2Excel2).Dispose();
			colIndex = 0;
			rowIndex = 0;
			maxColIndex = 0;
			maxRowIndex = 0;
		}
	}

	private void InitHeader(ReportInformation f_rptInfo, string f_sFilterTitle, string f_sNhan_in)
	{
		rowIndex = 8;
		checked
		{
			foreach (DataRowView item in dvf)
			{
				if (Operators.ConditionalCompareObjectEqual(item["sel"], (object)true, false))
				{
					colIndex++;
					wSheet.Cells[rowIndex, colIndex] = RuntimeHelpers.GetObjectValue(item["HeaderText"]);
					range = (Microsoft.Office.Interop.Excel.Range)wSheet.Columns[colIndex, Missing.Value];
					if (Operators.ConditionalCompareObjectEqual(item["Numeric"], (object)true, false))
					{
						range.EntireColumn.NumberFormat = ConvertNumericFormat(Conversions.ToString(item["Format"]));
						if (Operators.ConditionalCompareObjectEqual(item["sum"], (object)true, false))
						{
							hasSUM = true;
						}
					}
					else
					{
						range.EntireColumn.NumberFormat = RuntimeHelpers.GetObjectValue(item["Format"]);
					}
				}
				if (Operators.CompareString(Conversions.ToString(item["DataPropertyName"]).ToUpper(), "BOLD", false) == 0)
				{
					hasBoldColumn = true;
				}
				if (Operators.CompareString(Conversions.ToString(item["DataPropertyName"]).ToUpper(), "CACH_TINH", false) == 0)
				{
					hasFormulaColumn = true;
				}
				if (Operators.CompareString(Conversions.ToString(item["DataPropertyName"]).ToUpper(), "MA_SO", false) == 0)
				{
					hasCodeColumn = true;
				}
			}
			if ((hasFormulaColumn && hasCodeColumn) ? true : false)
			{
				hasFormulaColumn = true;
			}
			else
			{
				hasFormulaColumn = false;
			}
			dvf.RowFilter = "sel=true";
			maxColIndex = colIndex;
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[rowIndex, 1]), RuntimeHelpers.GetObjectValue(wSheet.Cells[rowIndex, maxColIndex]));
			range.EntireRow.RowHeight = 25;
			range.Font.Bold = true;
			range.Font.ColorIndex = ExcelColor.darkblue;
			range.Interior.ColorIndex = ExcelColor.coban;
			range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
			range.VerticalAlignment = XlVAlign.xlVAlignCenter;
			range.Borders.LineStyle = XlLineStyle.xlContinuous;
			range = (Microsoft.Office.Interop.Excel.Range)wSheet.Rows[rowIndex + 1, Missing.Value];
			range.Select();
			wSheet.Application.ActiveWindow.FreezePanes = true;
			dvf.RowFilter = "sel=true";
			maxColIndex = colIndex;
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(wSheet.Cells[1, maxColIndex]));
			range.Merge(Missing.Value);
			range.Font.Bold = true;
			range.Value2 = CompanyInformations.ParentCompanyName.ToUpper();
			range.VerticalAlignment = XlVAlign.xlVAlignCenter;
			range.EntireRow.AutoFit();
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[2, 1]), RuntimeHelpers.GetObjectValue(wSheet.Cells[2, maxColIndex]));
			range.Merge(Missing.Value);
			range.Font.Bold = true;
			range.Value2 = CompanyInformations.CompanyName.ToUpper();
			range.VerticalAlignment = XlVAlign.xlVAlignCenter;
			range.EntireRow.AutoFit();
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[4, 1]), RuntimeHelpers.GetObjectValue(wSheet.Cells[4, maxColIndex]));
			range.Merge(Missing.Value);
			range.Font.Bold = true;
			range.Value2 = f_rptInfo.title;
			range.Font.Size = 16;
			range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
			range.VerticalAlignment = XlVAlign.xlVAlignCenter;
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[5, 1]), RuntimeHelpers.GetObjectValue(wSheet.Cells[5, maxColIndex]));
			range.Merge(Missing.Value);
			range.Value2 = f_sNhan_in;
			range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
			range.VerticalAlignment = XlVAlign.xlVAlignCenter;
			if (Operators.CompareString(f_sFilterTitle, "", false) != 0)
			{
				range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[6, 1]), RuntimeHelpers.GetObjectValue(wSheet.Cells[6, maxColIndex]));
				range.Merge(Missing.Value);
				range.Value2 = f_sFilterTitle;
				range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
				range.VerticalAlignment = XlVAlign.xlVAlignCenter;
			}
			rowIndex++;
		}
	}

	private void InitDataHeader(AsDataGridView f_dgvBC, System.Data.DataTable f_oTblPrint, System.Data.DataTable f_oTblFilter, string sTieu_De_Khach_Hang)
	{
		if ((f_dgvBC != null && ((BaseCollection)((DataGridView)f_dgvBC).Columns).Count != 0 && f_oTblPrint != null && f_oTblPrint.Rows.Count != 0) || 1 == 0)
		{
			int num = rowIndex;
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[num, 1]), RuntimeHelpers.GetObjectValue(wSheet.Cells[num, maxColIndex]));
			range.Merge(Missing.Value);
			range.Font.Bold = true;
			range.Value2 = sTieu_De_Khach_Hang;
			range.Font.Size = 16;
			range.HorizontalAlignment = XlHAlign.xlHAlignLeft;
			range.VerticalAlignment = XlVAlign.xlVAlignCenter;
			range.Font.ColorIndex = ExcelColor.darkblue;
			range.Interior.ColorIndex = ExcelColor.purple;
			range.Font.Bold = true;
			range.VerticalAlignment = XlVAlign.xlVAlignCenter;
			range.EntireRow.RowHeight = 25;
			range.Borders.LineStyle = XlLineStyle.xlContinuous;
			range.Borders.Weight = XlBorderWeight.xlThin;
		}
	}

	private void E2E(AsDataGridView f_dgvBC, System.Data.DataTable f_oTblPrint)
	{
		hasSUM = false;
		DataGridViewCellStyle defaultCellStyle = ((DataGridView)f_dgvBC).DefaultCellStyle;
		checked
		{
			int num = rowIndex + 1;
			DataView dataView = new DataView(f_oTblPrint);
			object[,] array = new object[dataView.Count + 1, maxColIndex + 1];
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			int num2 = 0;
			int count = dataView.Count;
			string text = "";
			AsDictionary asDictionary = null;
			if (hasFormulaColumn)
			{
				asDictionary = new AsDictionary();
			}
			rowIndex = -1;
			foreach (DataRowView item in dataView)
			{
				rowIndex++;
				colIndex = -1;
				foreach (DataRowView item2 in dvf)
				{
					colIndex++;
					array[rowIndex, colIndex] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)item, (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(item2["DataPropertyName"]) }, (string[])null, (Type[])null, (bool[])null));
				}
				if ((hasBoldColumn && Operators.ConditionalCompareObjectEqual(item["bold"], (object)"1", false)) ? true : false)
				{
					range = (Microsoft.Office.Interop.Excel.Range)wSheet.Rows[num + rowIndex, Missing.Value];
					range.Font.Bold = true;
					range.Font.ColorIndex = ExcelColor.darkblue;
				}
				if (hasSUM)
				{
					if ((hasBoldColumn && Operators.ConditionalCompareObjectEqual(item["bold"], (object)"1", false)) ? true : false)
					{
						if ((flag && num2 == rowIndex - 1) ? true : false)
						{
							text = text + (rowIndex - count - 1) + "]C";
						}
						range = (Microsoft.Office.Interop.Excel.Range)wSheet.Rows[num + rowIndex, Missing.Value];
						range.Font.Bold = true;
						range.Font.ColorIndex = ExcelColor.darkblue;
						flag2 = true;
					}
					else
					{
						if (!flag)
						{
							text = "=SUM(R[-" + (count - rowIndex) + "]C:R[";
						}
						else if (num2 != rowIndex - 1)
						{
							text = text + ",R[" + (rowIndex - count) + "]C:R[";
						}
						flag = true;
						num2 = rowIndex;
					}
				}
				if ((hasFormulaColumn && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["ma_so"]), isNum: false), (object)"", false)) ? true : false)
				{
					try
					{
						asDictionary.Add(RuntimeHelpers.GetObjectValue(item["ma_so"]), rowIndex);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
			}
			if (num2 == 0)
			{
				text = "";
			}
			else if (num2 == rowIndex)
			{
				text = text + (num2 - count) + "]C";
			}
			maxRowIndex = num + rowIndex;
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[num, 1]), RuntimeHelpers.GetObjectValue(wSheet.Cells[maxRowIndex, maxColIndex]));
			range.Value2 = array;
			range.Borders.LineStyle = XlLineStyle.xlContinuous;
			range.Borders.get_Item(XlBordersIndex.xlInsideHorizontal).LineStyle = XlLineStyle.xlContinuous;
			range.Borders.get_Item(XlBordersIndex.xlInsideHorizontal).Weight = XlBorderWeight.xlHairline;
			colIndex = 0;
			if (hasSUM)
			{
				foreach (DataRowView item3 in dvf)
				{
					colIndex++;
					if ((Operators.ConditionalCompareObjectEqual(item3["sum"], (object)true, false) && Operators.ConditionalCompareObjectEqual(item3["Numeric"], (object)true, false)) ? true : false)
					{
						range = (Microsoft.Office.Interop.Excel.Range)wSheet.Cells[maxRowIndex + 1, colIndex];
						try
						{
							range.FormulaR1C1 = text;
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							Helper.ProcessError(ex4);
							ProjectData.ClearProjectError();
						}
						range.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
						range.Borders[XlBordersIndex.xlEdgeLeft].Weight = XlBorderWeight.xlThin;
						range.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
						range.Borders[XlBordersIndex.xlEdgeRight].Weight = XlBorderWeight.xlThin;
					}
				}
			}
			if (hasSUM)
			{
				range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[maxRowIndex + 1, 1]), RuntimeHelpers.GetObjectValue(wSheet.Cells[maxRowIndex + 1, maxColIndex]));
				range.Font.ColorIndex = ExcelColor.darkblue;
				range.Interior.ColorIndex = ExcelColor.coban;
				range.Font.Bold = true;
				range.VerticalAlignment = XlVAlign.xlVAlignCenter;
				range.EntireRow.RowHeight = 25;
				range.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
				range.Borders[XlBordersIndex.xlEdgeTop].Weight = XlBorderWeight.xlThin;
			}
			if (!hasFormulaColumn)
			{
				return;
			}
			string text2 = "";
			DataRow[] array2 = f_oTblPrint.Select("cach_tinh<>''");
			foreach (DataRow dataRow in array2)
			{
				colIndex = 0;
				text2 = Convert2ExcelFormula(Conversions.ToString(dataRow["cach_tinh"]), Conversions.ToInteger(asDictionary[RuntimeHelpers.GetObjectValue(dataRow["ma_so"])]), asDictionary);
				foreach (DataRowView item4 in dvf)
				{
					colIndex++;
					if (Operators.ConditionalCompareObjectEqual(item4["Numeric"], (object)true, false))
					{
						range = (Microsoft.Office.Interop.Excel.Range)wSheet.Cells[Operators.AddObject(asDictionary[RuntimeHelpers.GetObjectValue(dataRow["ma_so"])], (object)num), colIndex];
						try
						{
							range.FormulaR1C1 = text2;
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception ex6 = ex5;
							Helper.ProcessError(ex6);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
		}
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
}
