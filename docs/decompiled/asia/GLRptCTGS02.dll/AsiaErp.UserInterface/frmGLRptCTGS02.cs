using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLRptCTGS02 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtDen_so")]
	private AsTextBox _txtDen_so;

	[AccessedThroughProperty("lblDen_so")]
	private Label _lblDen_so;

	[AccessedThroughProperty("txtTu_so")]
	private AsTextBox _txtTu_so;

	[AccessedThroughProperty("lblTu_so")]
	private Label _lblTu_so;

	internal virtual AsTextBox txtDen_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDen_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDen_so = value;
		}
	}

	internal virtual Label lblDen_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDen_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDen_so = value;
		}
	}

	internal virtual AsTextBox txtTu_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTu_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTu_so = value;
		}
	}

	internal virtual Label lblTu_so
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTu_so;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTu_so = value;
		}
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

	public frmGLRptCTGS02(string MenuId)
		: base(MenuId)
	{
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected O, but got Unknown
		txtTu_so = new AsTextBox();
		lblTu_so = new Label();
		lblDen_so = new Label();
		txtDen_so = new AsTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(743, 613);
		((Control)asTabControl).Size = size;
		((ScrollableControl)tabFilter).AutoScroll = false;
		((Control)tabFilter).Controls.Add((Control)(object)txtDen_so);
		((Control)tabFilter).Controls.Add((Control)(object)lblDen_so);
		((Control)tabFilter).Controls.Add((Control)(object)txtTu_so);
		((Control)tabFilter).Controls.Add((Control)(object)lblTu_so);
		TabPage obj = tabFilter;
		size = new Size(735, 584);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTu_so, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTu_so, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDen_so, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtDen_so, 0);
		Label obj2 = lbl2;
		Point location = new Point(280, 81);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 785);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(299, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 785);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(458, 23);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 25;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(209, 77);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(113, 77);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(27, 81);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(113, 24);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 24;
		Label obj9 = lblMau_bc;
		location = new Point(27, 28);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(113, 130);
		((Control)asTextBox).Location = location;
		Label obj10 = lblMauBC;
		location = new Point(158, 129);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 21;
		RadioButton obj11 = optVND;
		location = new Point(245, 128);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 6;
		RadioButton obj12 = optNt;
		location = new Point(299, 129);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 7;
		Label obj13 = lblMa_nt;
		location = new Point(27, 132);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(30, 166);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 8;
		Label obj15 = lblTieu_de;
		location = new Point(27, 55);
		((Control)obj15).Location = location;
		TextBox obj16 = txtTieu_De;
		location = new Point(113, 51);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 26;
		TabPage obj17 = tabGrid;
		size = new Size(735, 584);
		((Control)obj17).Size = size;
		txtTu_so.AutoLookup = false;
		txtTu_so.AutoValid = false;
		((TextBoxBase)txtTu_so).BackColor = SystemColors.Window;
		((TextBox)txtTu_so).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTu_so;
		location = new Point(113, 104);
		((Control)asTextBox2).Location = location;
		txtTu_so.LookupCodeName = "";
		((Control)txtTu_so).Name = "txtTu_so";
		txtTu_so.NameControl = null;
		AsTextBox asTextBox3 = txtTu_so;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTu_so).TabIndex = 3;
		txtTu_so.UseAutoCompleteSource = true;
		lblTu_so.AutoSize = true;
		Label obj18 = lblTu_so;
		location = new Point(27, 108);
		((Control)obj18).Location = location;
		((Control)lblTu_so).Name = "lblTu_so";
		Label obj19 = lblTu_so;
		size = new Size(76, 13);
		((Control)obj19).Size = size;
		((Control)lblTu_so).TabIndex = 1017;
		lblTu_so.Text = "Chứng từ từ số";
		lblDen_so.AutoSize = true;
		Label obj20 = lblDen_so;
		location = new Point(219, 108);
		((Control)obj20).Location = location;
		((Control)lblDen_so).Name = "lblDen_so";
		Label obj21 = lblDen_so;
		size = new Size(40, 13);
		((Control)obj21).Size = size;
		((Control)lblDen_so).TabIndex = 1018;
		lblDen_so.Text = "đến số";
		txtDen_so.AutoLookup = false;
		txtDen_so.AutoValid = false;
		((TextBoxBase)txtDen_so).BackColor = SystemColors.Window;
		((TextBox)txtDen_so).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtDen_so;
		location = new Point(276, 104);
		((Control)asTextBox4).Location = location;
		txtDen_so.LookupCodeName = "";
		((Control)txtDen_so).Name = "txtDen_so";
		txtDen_so.NameControl = null;
		AsTextBox asTextBox5 = txtDen_so;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtDen_so).TabIndex = 4;
		txtDen_so.UseAutoCompleteSource = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(743, 638);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmGLRptCTGS02";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		base.InitOtherComponents();
		((Control)cboKyBc).Select();
		((DataGridView)dgvBC).CellEnter += new DataGridViewCellEventHandler(dgvBC_CellEnter);
	}

	protected override bool LoadData()
	{
		if (cboMau_bc.SelectedIndex == -1)
		{
			return false;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtTu_so).Text);
		arrayList.Add(((TextBox)txtDen_so).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
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
	}

	private void dgvBC_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			DataGridViewColumn val = ((DataGridView)dgvBC).Columns[((DataGridView)dgvBC).CurrentCell.ColumnIndex];
			DataRow dataRow = (DataRow)NewLateBinding.LateGet(((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvBC).DataSource)].Current, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null);
			DataGridViewCell currentCell = ((DataGridView)dgvBC).CurrentCell;
			if (Operators.CompareString(val.Name, "tag", false) == 0)
			{
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

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		DataRowView dataRowView = get_MyDGVSource(isSet2Print: true).DefaultView[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
		if ((int)keycode != 116)
		{
			base.CancelDrilldown = true;
			return null;
		}
		ArrayList arrayList = new ArrayList();
		if ((int)modifierKeys == 0)
		{
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ngay_lo"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["so_lo"]));
			filterCondition4title = dataRowView["so_lo"].ToString() + " - " + dataRowView["dien_giai"].ToString();
			return arrayList;
		}
		base.CancelDrilldown = true;
		return null;
	}

	private DataTable LoadDataToCrystal()
	{
		DataTable dataTable = new DataTable();
		DataTable dataTable2 = new DataTable();
		bool flag = true;
		ArrayList arrayList = new ArrayList();
		if (get_MyDGVSource(isSet2Print: true) != null)
		{
			get_MyDGVSource(isSet2Print: true).AcceptChanges();
			DataRow[] array = get_MyDGVSource(isSet2Print: true).Select("TAG=1");
			foreach (DataRow dataRow in array)
			{
				arrayList.Clear();
				arrayList.Add(CompanyInformations.CompanyID);
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
				arrayList.Add(RuntimeHelpers.GetObjectValue(dataRow["ngay_lo"]));
				arrayList.Add(RuntimeHelpers.GetObjectValue(dataRow["so_lo"]));
				dataTable2 = Commons.GetDataTable(MyMenuInfo.par1, arrayList.ToArray());
				if (flag)
				{
					dataTable = dataTable2.Clone();
					flag = false;
				}
				dataTable.Merge(dataTable2);
			}
		}
		return dataTable;
	}

	protected override void ViewCrystalBySource()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			base.MyCrystalSource = LoadDataToCrystal();
			if (base.MyCrystalSource.Rows.Count == 0)
			{
				CMessageBox.Show(50101);
			}
			else
			{
				base.ViewCrystalBySource();
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
}
