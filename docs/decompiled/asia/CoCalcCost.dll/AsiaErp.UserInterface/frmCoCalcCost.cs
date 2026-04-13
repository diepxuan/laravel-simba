using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCoCalcCost : frmReport2DGV
{
	private IContainer components;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("lblTK")]
	private Label _lblTK;

	[AccessedThroughProperty("txtTK")]
	private AsTextBox _txtTK;

	[AccessedThroughProperty("btnUpdate")]
	private Button _btnUpdate;

	[AccessedThroughProperty("btnDelUpdate")]
	private Button _btnDelUpdate;

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

	protected internal override AsDataGridView dgvBCPh
	{
		get
		{
			return base.dgvBCPh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = dgv_CurrentCellChanged;
			if (base.dgvBCPh != null)
			{
				((DataGridView)base.dgvBCPh).CurrentCellChanged -= eventHandler;
			}
			base.dgvBCPh = value;
			if (base.dgvBCPh != null)
			{
				((DataGridView)base.dgvBCPh).CurrentCellChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	protected virtual Label lblTK
	{
		get
		{
			return _lblTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTK = value;
		}
	}

	internal virtual AsTextBox txtTK
	{
		get
		{
			return _txtTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTK = value;
		}
	}

	internal virtual Button btnUpdate
	{
		get
		{
			return _btnUpdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnUpdate_Click;
			if (_btnUpdate != null)
			{
				((Control)_btnUpdate).Click -= eventHandler;
			}
			_btnUpdate = value;
			if (_btnUpdate != null)
			{
				((Control)_btnUpdate).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnDelUpdate
	{
		get
		{
			return _btnDelUpdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnDelUpdate_Click;
			if (_btnDelUpdate != null)
			{
				((Control)_btnDelUpdate).Click -= eventHandler;
			}
			_btnDelUpdate = value;
			if (_btnDelUpdate != null)
			{
				((Control)_btnDelUpdate).Click += eventHandler;
			}
		}
	}

	private virtual CrystalReportViewer crvReportViewer
	{
		get
		{
			return _crvReportViewer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_crvReportViewer = value;
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

	public frmCoCalcCost(string menuid)
		: base(menuid)
	{
		((Form)this).Load += frmCOGDBGT_Load;
		InitializeComponent();
		((TabControl)AsTabControl).TabPages.RemoveAt(2);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		Label3 = new Label();
		lblTK = new Label();
		txtTK = new AsTextBox();
		btnUpdate = new Button();
		btnDelUpdate = new Button();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)tabGrid).SuspendLayout();
		((Control)scGrid).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(440, 163);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)btnDelUpdate);
		((Control)tabFilter).Controls.Add((Control)(object)btnUpdate);
		((Control)tabFilter).Controls.Add((Control)(object)Label3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTK);
		((Control)tabFilter).Controls.Add((Control)(object)txtTK);
		TabPage obj = tabFilter;
		size = new Size(432, 134);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)btnUpdate, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)btnDelUpdate, 0);
		Label obj2 = lbl2;
		Point location = new Point(290, 26);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 645);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(309, 22);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(690, 300);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(690, 375);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).Visible = false;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(219, 22);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(123, 22);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(37, 26);
		((Control)obj7).Location = location;
		Label obj8 = lblKyBc;
		size = new Size(65, 13);
		((Control)obj8).Size = size;
		lblKyBc.Text = "Kỳ tính toán";
		ComboBox obj9 = cboMau_bc;
		location = new Point(345, 377);
		((Control)obj9).Location = location;
		((Control)cboMau_bc).Visible = false;
		Label obj10 = lblMau_bc;
		location = new Point(259, 380);
		((Control)obj10).Location = location;
		((Control)lblMau_bc).Visible = false;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(427, 341);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).Visible = false;
		Label obj11 = lblMauBC;
		location = new Point(472, 340);
		((Control)obj11).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj12 = optVND;
		location = new Point(559, 339);
		((Control)obj12).Location = location;
		((Control)optVND).Visible = false;
		RadioButton obj13 = optNt;
		location = new Point(613, 340);
		((Control)obj13).Location = location;
		((Control)optNt).Visible = false;
		Label obj14 = lblMa_nt;
		location = new Point(341, 343);
		((Control)obj14).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj15 = cmdOk;
		location = new Point(40, 90);
		((Control)obj15).Location = location;
		((Control)cmdOk).TabIndex = 4;
		Label obj16 = lblTieu_de;
		location = new Point(259, 408);
		((Control)obj16).Location = location;
		((Control)lblTieu_de).Visible = false;
		TextBox obj17 = txtTieu_De;
		location = new Point(345, 404);
		((Control)obj17).Location = location;
		((Control)txtTieu_De).Visible = false;
		TabPage obj18 = tabGrid;
		size = new Size(501, 180);
		((Control)obj18).Size = size;
		SplitContainer obj19 = scGrid;
		size = new Size(495, 174);
		((Control)obj19).Size = size;
		scGrid.SplitterDistance = 81;
		crvReportViewer.ActiveViewIndex = -1;
		((UserControl)crvReportViewer).BorderStyle = (BorderStyle)1;
		crvReportViewer.DisplayGroupTree = false;
		((Control)crvReportViewer).Dock = (DockStyle)5;
		CrystalReportViewer obj20 = crvReportViewer;
		location = new Point(0, 0);
		((Control)obj20).Location = location;
		((Control)crvReportViewer).Name = "crvReportViewer";
		crvReportViewer.SelectionFormula = "";
		crvReportViewer.ShowRefreshButton = false;
		CrystalReportViewer obj21 = crvReportViewer;
		size = new Size(784, 458);
		((Control)obj21).Size = size;
		((Control)crvReportViewer).TabIndex = 0;
		crvReportViewer.ViewTimeSelectionFormula = "";
		Label3.AutoSize = true;
		Label label = Label3;
		location = new Point(35, 57);
		((Control)label).Location = location;
		((Control)Label3).Name = "Label3";
		Label label2 = Label3;
		size = new Size(63, 13);
		((Control)label2).Size = size;
		((Control)Label3).TabIndex = 1018;
		Label3.Text = "TK dở dang";
		lblTK.AutoSize = true;
		Label obj22 = lblTK;
		location = new Point(229, 57);
		((Control)obj22).Location = location;
		((Control)lblTK).Name = "lblTK";
		Label obj23 = lblTK;
		size = new Size(157, 13);
		((Control)obj23).Size = size;
		((Control)lblTK).TabIndex = 1017;
		lblTK.Text = "                                                  ";
		txtTK.AutoLookup = true;
		txtTK.AutoValid = false;
		((TextBoxBase)txtTK).BackColor = SystemColors.Info;
		((TextBox)txtTK).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTK;
		location = new Point(123, 54);
		((Control)asTextBox2).Location = location;
		txtTK.LookupCodeName = "TK";
		txtTK.LookupWhereCondition = " ksd=0";
		((Control)txtTK).Name = "txtTK";
		txtTK.NameControl = lblTK;
		AsTextBox asTextBox3 = txtTK;
		size = new Size(100, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTK).TabIndex = 3;
		txtTK.UseAutoCompleteSource = true;
		Button obj24 = btnUpdate;
		location = new Point(127, 90);
		((Control)obj24).Location = location;
		((Control)btnUpdate).Name = "btnUpdate";
		Button obj25 = btnUpdate;
		size = new Size(86, 23);
		((Control)obj25).Size = size;
		((Control)btnUpdate).TabIndex = 5;
		((ButtonBase)btnUpdate).Text = "Cập nhật GT";
		((ButtonBase)btnUpdate).UseVisualStyleBackColor = true;
		Button obj26 = btnDelUpdate;
		location = new Point(219, 90);
		((Control)obj26).Location = location;
		((Control)btnDelUpdate).Name = "btnDelUpdate";
		Button obj27 = btnDelUpdate;
		size = new Size(86, 23);
		((Control)obj27).Size = size;
		((Control)btnDelUpdate).TabIndex = 6;
		((ButtonBase)btnDelUpdate).Text = "Xóa cập nhật";
		((ButtonBase)btnDelUpdate).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(440, 188);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCoCalcCost";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)tabGrid).ResumeLayout(false);
		((Control)scGrid).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool LoadData()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(Conversions.ToDate(txtNgay2.Value), AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks) <= 0)
		{
			CMessageBox.Show(50136);
			return false;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtTK).Text);
		set_MyDGVPhSource(isSet2Print: true, base.MyController.GetDataSet(arrayList.ToArray()).Tables[0]);
		set_MyDGVCtSource(isSet2Print: true, base.MyController.GetDataSet(arrayList.ToArray()).Tables[1]);
		return true;
	}

	protected override bool ValidData()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(Conversions.ToDate(txtNgay2.Value), AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks) <= 0)
		{
			CMessageBox.Show(50136);
			return false;
		}
		if (!base.ValidData() || !ChkEmtyTextBox((TextBox)(object)txtTK))
		{
			return false;
		}
		return true;
	}

	private void frmCOGDBGT_Load(object sender, EventArgs e)
	{
		((TextBox)txtTK).Text = MyMenuInfo.par1;
		cboKyBc.DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc, "11100");
	}

	private void btnUpdate_Click(object sender, EventArgs e)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(Conversions.ToDate(txtNgay2.Value), AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks) <= 0)
		{
			CMessageBox.Show(50136);
			return;
		}
		try
		{
			Commons.ExecuteStoredProcedure(MyMenuInfo.par2, CompanyInformations.CompanyID, RuntimeHelpers.GetObjectValue(txtNgay1.Value), RuntimeHelpers.GetObjectValue(txtNgay2.Value), ((TextBox)txtTK).Text);
			CMessageBox.Show(50015);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(99999);
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void dgv_CurrentCellChanged(object sender, EventArgs e)
	{
		if (((DataGridView)dgvBCPh).CurrentRow != null && ((DataGridViewBand)((DataGridView)dgvBCPh).CurrentRow).Index >= 0)
		{
			get_MyDGVCtSource(isSet2Print: true).DefaultView.RowFilter = Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"ma_spct= '", ((DataGridView)dgvBCPh).Rows[((DataGridViewBand)((DataGridView)dgvBCPh).CurrentRow).Index].Cells[0].Value), (object)"'"));
		}
	}

	private void btnDelUpdate_Click(object sender, EventArgs e)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(Conversions.ToDate(txtNgay2.Value), AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks) <= 0)
		{
			CMessageBox.Show(50136);
			return;
		}
		try
		{
			Commons.ExecuteStoredProcedure(MyMenuInfo.par3, CompanyInformations.CompanyID, RuntimeHelpers.GetObjectValue(txtNgay1.Value), RuntimeHelpers.GetObjectValue(txtNgay2.Value), ((TextBox)txtTK).Text);
			CMessageBox.Show(50015);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(99999);
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}
}
