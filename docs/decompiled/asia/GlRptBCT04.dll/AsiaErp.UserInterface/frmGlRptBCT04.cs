using System;
using System.Collections;
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
public class frmGlRptBCT04 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("cmdCF")]
	private Button _cmdCF;

	private DataTable _source;

	private DataTable _sourceCalc;

	internal virtual Button cmdCF
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCF_Click;
			if (_cmdCF != null)
			{
				((Control)_cmdCF).Click -= eventHandler;
			}
			_cmdCF = value;
			if (_cmdCF != null)
			{
				((Control)_cmdCF).Click += eventHandler;
			}
		}
	}

	public frmGlRptBCT04(string menuid)
		: base(menuid)
	{
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		cmdCF = new Button();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(673, 421);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)cmdCF);
		TabPage obj = tabFilter;
		size = new Size(665, 392);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCF, 0);
		Label obj2 = lbl2;
		Point location = new Point(278, 92);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 3;
		Button obj3 = cmdExcel;
		location = new Point(700, 335);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(297, 88);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 335);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(456, 34);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 11;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(207, 88);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(111, 88);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(17, 92);
		((Control)obj7).Location = location;
		((Control)lblKyBc).TabIndex = 0;
		ComboBox obj8 = cboMau_bc;
		location = new Point(111, 35);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 10;
		((Control)cboMau_bc).TabStop = false;
		Label obj9 = lblMau_bc;
		location = new Point(17, 39);
		((Control)obj9).Location = location;
		((Control)lblMau_bc).TabIndex = 16;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(296, 198);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 7;
		((Control)txtMa_Nt).Visible = false;
		Label obj10 = lblMauBC;
		location = new Point(341, 197);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 12;
		((Control)lblMauBC).Visible = false;
		RadioButton obj11 = optVND;
		location = new Point(428, 196);
		((Control)obj11).Location = location;
		((Control)optVND).Visible = false;
		RadioButton obj12 = optNt;
		location = new Point(482, 197);
		((Control)obj12).Location = location;
		((Control)optNt).Visible = false;
		Label obj13 = lblMa_nt;
		location = new Point(204, 200);
		((Control)obj13).Location = location;
		((Control)lblMa_nt).TabIndex = 10;
		((Control)lblMa_nt).Visible = false;
		Button obj14 = cmdOk;
		location = new Point(19, 130);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 8;
		Label obj15 = lblTieu_de;
		location = new Point(17, 66);
		((Control)obj15).Location = location;
		((Control)lblTieu_de).TabIndex = 19;
		TextBox obj16 = txtTieu_De;
		location = new Point(111, 62);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 12;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj17 = tabGrid;
		size = new Size(665, 392);
		((Control)obj17).Size = size;
		Button obj18 = cmdCF;
		location = new Point(111, 130);
		((Control)obj18).Location = location;
		((Control)cmdCF).Name = "cmdCF";
		Button obj19 = cmdCF;
		size = new Size(86, 23);
		((Control)obj19).Size = size;
		((Control)cmdCF).TabIndex = 9;
		((ButtonBase)cmdCF).Text = "KB &Công thức";
		((ButtonBase)cmdCF).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(673, 446);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlRptBCT04";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(base.MyReportInfo.ma_mau);
		DataSet dataSet = base.MyController.GetDataSet(arrayList.ToArray());
		_source = dataSet.Tables[0];
		_sourceCalc = dataSet.Tables[1];
		set_MyDGVSource(isSet2Print: true, _source);
		MyFomularFields.Clear();
		return true;
	}

	protected override void FormatGridView()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		base.FormatGridView();
		((DataGridView)dgvBC).EditMode = (DataGridViewEditMode)0;
		dgvBC.ReadOnly = false;
		foreach (DataGridViewColumn item in (BaseCollection)((DataGridView)dgvBC).Columns)
		{
			DataGridViewColumn val = item;
			val.ReadOnly = true;
		}
		UpdateList();
	}

	protected override void InitOtherComponents()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		base.InitOtherComponents();
		((DataGridView)dgvBC).CellEnter += new DataGridViewCellEventHandler(CellEnter);
		((DataGridView)dgvBC).CellValidated += new DataGridViewCellEventHandler(CellValidated);
	}

	private void cmdCF_Click(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		Form val = Application.OpenForms["frmTATNDN01A"];
		foreach (Form item in (ReadOnlyCollectionBase)(object)Application.OpenForms)
		{
			Form val2 = item;
			if (val2 is frmGLMauCF01)
			{
				return;
			}
		}
		val = (Form)(object)new frmGLMauCF01(base.MyMenuID, MyMenuInfo.code_name, MyReportInfo.ma_mau);
		val.Show((IWin32Window)(object)this);
	}

	private void CellEnter(object sender, EventArgs e)
	{
		try
		{
			DataGridViewColumn val = ((DataGridView)dgvBC).Columns[((DataGridView)dgvBC).CurrentCell.ColumnIndex];
			DataGridViewCell currentCell = ((DataGridView)dgvBC).CurrentCell;
			if (Operators.CompareString(val.Name, "tien", false) == 0 && Operators.ConditionalCompareObjectEqual(((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvBC).DataSource)].Current)["modify"], (object)true, false))
			{
				val.DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
				val.ReadOnly = false;
			}
			else
			{
				val.ReadOnly = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void CellValidated(object sender, EventArgs e)
	{
		try
		{
			int columnIndex = ((DataGridView)dgvBC).CurrentCell.ColumnIndex;
			DataGridViewColumn val = ((DataGridView)dgvBC).Columns[columnIndex];
			DataRowView dataRowView = (DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvBC).DataSource)].Current;
			DataRow[] array = ((DataTable)((DataGridView)dgvBC).DataSource).Select("ma_so='" + dataRowView["ma_so"].ToString() + "'");
			if (Operators.CompareString(val.Name, "tien", false) == 0 && Operators.CompareString(array[0][0].ToString(), "", false) != 0)
			{
				((DataTable)((DataGridView)dgvBC).DataSource).AcceptChanges();
				UpdateDataCell(Conversions.ToString(dataRowView["ma_so"]), Conversions.ToDouble(dataRowView["tien"]), Conversions.ToString(dataRowView["stt"]));
				UpdateList();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void UpdateList()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if (((TabControl)AsTabControl).SelectedTab != tabGrid)
		{
			return;
		}
		string text = "";
		try
		{
			DataTable dataTable = (DataTable)((DataGridView)dgvBC).DataSource;
			DataRow[] array = dataTable.Select("cach_tinh <> ''");
			foreach (DataRow dataRow in array)
			{
				string strChitieu = "";
				if (!ValidChiTieu(Conversions.ToString(dataRow["cach_tinh"]), ref strChitieu))
				{
					CMessageBox.ShowWithFormat(50178, new object[1] { strChitieu });
					break;
				}
				dataRow["tien"] = double.Parse(Conversions.ToString(_sourceCalc.Compute(strChitieu, "ma_cty='" + CompanyInformations.CompanyID + "'")));
				NewLateBinding.LateSet((object)_sourceCalc.Rows[0], (Type)null, "Item", new object[2]
				{
					RuntimeHelpers.GetObjectValue(dataRow["ma_so"]),
					RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRow["tien"]), isNum: true))
				}, (string[])null, (Type[])null);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private int UpdateDataCell(string maSo, double tien, string stt)
	{
		_sourceCalc.Rows[0][maSo] = tien;
		IGlRptBCT04 glRptBCT = (IGlRptBCT04)DAOFactory.CreateDAOInstance("GlRptBCT04", "GlRptBCT04");
		return Conversions.ToInteger(glRptBCT.UpdateDataCell(CompanyInformations.CompanyID, Conversions.ToDate(txtNgay1.Value), Conversions.ToDate(txtNgay2.Value), base.MyReportInfo.ma_mau, maSo, tien, stt));
	}

	private bool ValidChiTieu(string strList, ref string strChitieu)
	{
		Array array = strList.Split('+', '-', '*', '/');
		strChitieu = strList;
		foreach (object item in array)
		{
			string text = Conversions.ToString(item);
			if (!_sourceCalc.Columns.Contains(text))
			{
				strChitieu = text;
				return false;
			}
			strChitieu = strChitieu.ToString().Replace(text, "sum([" + text + "])");
		}
		return true;
	}
}
