using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLRptTMBCTC : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cboFilter")]
	private ComboBox _cboFilter;

	[AccessedThroughProperty("splMain")]
	private SplitContainer _splMain;

	[AccessedThroughProperty("cmdDMCT")]
	private Button _cmdDMCT;

	[AccessedThroughProperty("cmdLuu")]
	private Button _cmdLuu;

	[AccessedThroughProperty("txtGhi_chu")]
	private TextBox _txtGhi_chu;

	[AccessedThroughProperty("btnTinh_lai")]
	private Button _btnTinh_lai;

	private string sTabName;

	private string sMenuID;

	private string sMenuIDB;

	private bool DataLoading;

	protected override ComboBox cboMau_bc
	{
		[DebuggerNonUserCode]
		get
		{
			return base.cboMau_bc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboMauBC_SelectedIndexChanged;
			if (base.cboMau_bc != null)
			{
				base.cboMau_bc.SelectedIndexChanged -= eventHandler;
			}
			base.cboMau_bc = value;
			if (base.cboMau_bc != null)
			{
				base.cboMau_bc.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual ComboBox cboFilter
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboFilter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboFilter = value;
		}
	}

	internal virtual SplitContainer splMain
	{
		[DebuggerNonUserCode]
		get
		{
			return _splMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_splMain = value;
		}
	}

	internal virtual Button cmdDMCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdDMCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdDMCT_Click;
			if (_cmdDMCT != null)
			{
				((Control)_cmdDMCT).Click -= eventHandler;
			}
			_cmdDMCT = value;
			if (_cmdDMCT != null)
			{
				((Control)_cmdDMCT).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdLuu
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdLuu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdLuu_Click;
			if (_cmdLuu != null)
			{
				((Control)_cmdLuu).Click -= eventHandler;
			}
			_cmdLuu = value;
			if (_cmdLuu != null)
			{
				((Control)_cmdLuu).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox txtGhi_chu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGhi_chu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGhi_chu = value;
		}
	}

	internal virtual Button btnTinh_lai
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnTinh_lai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnTinh_lai_Click;
			if (_btnTinh_lai != null)
			{
				((Control)_btnTinh_lai).Click -= eventHandler;
			}
			_btnTinh_lai = value;
			if (_btnTinh_lai != null)
			{
				((Control)_btnTinh_lai).Click += eventHandler;
			}
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

	public frmGLRptTMBCTC(string MenuID)
		: base(MenuID)
	{
		__ENCAddToList(this);
		DataLoading = true;
		InitializeComponent();
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		cboFilter = new ComboBox();
		splMain = new SplitContainer();
		txtGhi_chu = new TextBox();
		cmdDMCT = new Button();
		cmdLuu = new Button();
		btnTinh_lai = new Button();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)tabGrid).SuspendLayout();
		((Control)splMain.Panel2).SuspendLayout();
		((Control)splMain).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Point location = new Point(0, 1);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		Size size = new Size(821, 553);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl).TabIndex = 2;
		((Control)tabFilter).Controls.Add((Control)(object)btnTinh_lai);
		((Control)tabFilter).Controls.Add((Control)(object)cmdDMCT);
		TabPage obj = tabFilter;
		size = new Size(813, 524);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdDMCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)btnTinh_lai, 0);
		Label obj2 = lbl2;
		location = new Point(277, 378);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(609, 357);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 11;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(296, 82);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 5;
		Button obj4 = cmdCancel;
		location = new Point(528, 357);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 10;
		Button obj5 = cmdModifyReport;
		location = new Point(455, 27);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 1;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(206, 82);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 4;
		ComboBox obj6 = cboKyBc;
		location = new Point(110, 82);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 3;
		Label obj7 = lblKyBc;
		location = new Point(18, 86);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(110, 29);
		((Control)obj8).Location = location;
		Label obj9 = lblMau_bc;
		location = new Point(18, 33);
		((Control)obj9).Location = location;
		Label obj10 = lblMau_bc;
		size = new Size(47, 13);
		((Control)obj10).Size = size;
		lblMau_bc.Text = "Báo cáo";
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 348);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 8;
		((Control)txtMa_Nt).Visible = false;
		Label obj11 = lblMauBC;
		location = new Point(158, 347);
		((Control)obj11).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj12 = optVND;
		location = new Point(233, 346);
		((Control)obj12).Location = location;
		((Control)optVND).TabIndex = 14;
		optVND.TabStop = false;
		((Control)optVND).Visible = false;
		RadioButton obj13 = optNt;
		location = new Point(286, 347);
		((Control)obj13).Location = location;
		((Control)optNt).TabIndex = 15;
		((Control)optNt).Visible = false;
		Label obj14 = lblMa_nt;
		location = new Point(23, 350);
		((Control)obj14).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj15 = cmdOk;
		location = new Point(23, 118);
		((Control)obj15).Location = location;
		Label obj16 = lblTieu_de;
		location = new Point(18, 60);
		((Control)obj16).Location = location;
		TextBox obj17 = txtTieu_De;
		location = new Point(110, 56);
		((Control)obj17).Location = location;
		((Control)txtTieu_De).TabIndex = 2;
		((Control)tabGrid).Controls.Add((Control)(object)splMain);
		TabPage obj18 = tabGrid;
		size = new Size(813, 524);
		((Control)obj18).Size = size;
		((Control)tabGrid).Controls.SetChildIndex((Control)(object)splMain, 0);
		((Control)cboFilter).Anchor = (AnchorStyles)9;
		cboFilter.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboFilter).FormattingEnabled = true;
		ComboBox obj19 = cboFilter;
		location = new Point(532, 3);
		((Control)obj19).Location = location;
		((Control)cboFilter).Name = "cboFilter";
		ComboBox obj20 = cboFilter;
		size = new Size(285, 21);
		((Control)obj20).Size = size;
		((Control)cboFilter).TabIndex = 0;
		splMain.Dock = (DockStyle)5;
		splMain.FixedPanel = (FixedPanel)2;
		SplitContainer obj21 = splMain;
		location = new Point(3, 3);
		((Control)obj21).Location = location;
		((Control)splMain).Name = "splMain";
		splMain.Orientation = (Orientation)0;
		((Control)splMain.Panel2).Controls.Add((Control)(object)txtGhi_chu);
		SplitContainer obj22 = splMain;
		size = new Size(807, 518);
		((Control)obj22).Size = size;
		splMain.SplitterDistance = 395;
		((Control)splMain).TabIndex = 2;
		((Control)txtGhi_chu).Dock = (DockStyle)5;
		TextBox obj23 = txtGhi_chu;
		location = new Point(0, 0);
		((Control)obj23).Location = location;
		txtGhi_chu.Multiline = true;
		((Control)txtGhi_chu).Name = "txtGhi_chu";
		TextBox obj24 = txtGhi_chu;
		size = new Size(807, 119);
		((Control)obj24).Size = size;
		((Control)txtGhi_chu).TabIndex = 2;
		Button obj25 = cmdDMCT;
		location = new Point(197, 118);
		((Control)obj25).Location = location;
		((Control)cmdDMCT).Name = "cmdDMCT";
		Button obj26 = cmdDMCT;
		size = new Size(81, 23);
		((Control)obj26).Size = size;
		((Control)cmdDMCT).TabIndex = 8;
		((ButtonBase)cmdDMCT).Text = "Khai báo &CT";
		((ButtonBase)cmdDMCT).UseVisualStyleBackColor = true;
		((Control)cmdLuu).Anchor = (AnchorStyles)9;
		Button obj27 = cmdLuu;
		location = new Point(445, 2);
		((Control)obj27).Location = location;
		((Control)cmdLuu).Name = "cmdLuu";
		Button obj28 = cmdLuu;
		size = new Size(81, 23);
		((Control)obj28).Size = size;
		((Control)cmdLuu).TabIndex = 1;
		((ButtonBase)cmdLuu).Text = "&Lưu số liệu";
		((ButtonBase)cmdLuu).UseVisualStyleBackColor = true;
		Button obj29 = btnTinh_lai;
		location = new Point(110, 118);
		((Control)obj29).Location = location;
		((Control)btnTinh_lai).Name = "btnTinh_lai";
		Button obj30 = btnTinh_lai;
		size = new Size(81, 23);
		((Control)obj30).Size = size;
		((Control)btnTinh_lai).TabIndex = 7;
		((ButtonBase)btnTinh_lai).Text = "Tính &Lại";
		((ButtonBase)btnTinh_lai).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(821, 579);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdLuu);
		((Control)this).Controls.Add((Control)(object)cboFilter);
		((Control)this).Name = "frmGLRptTMBCTC";
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cboFilter, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLuu, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)tabGrid).ResumeLayout(false);
		((Control)splMain.Panel2).ResumeLayout(false);
		((Control)splMain.Panel2).PerformLayout();
		((Control)splMain).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		((Control)splMain.Panel1).Controls.Add((Control)(object)dgvBC);
		((Control)base.tabGrid).SendToBack();
		cboFilter.DataSource = RuntimeHelpers.GetObjectValue(cboMau_bc.DataSource);
		((ListControl)cboFilter).ValueMember = "ma_mau";
		((ListControl)cboFilter).DisplayMember = "ten_mau";
		((Control)cboFilter).Update();
		cboKyBc.DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc);
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
		((DataGridView)dgvBC).EditMode = (DataGridViewEditMode)0;
		dgvBC.ReadOnly = false;
	}

	protected override bool LoadData()
	{
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(CompanyInformations.Qd_cdkt);
			arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay1.Value)));
			arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay2.Value)));
			arrayList.Add(Conversions.ToString(DateAndTime.DateValue(Conversions.ToString(txtNgay1.Value))) + "-" + Conversions.ToString(DateAndTime.DateValue(Conversions.ToString(txtNgay2.Value))));
			if (cboMau_bc.SelectedIndex != 0)
			{
				Send2CrystalByConnection = false;
				set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
				dgvBC.ReadOnly = false;
				((DataGridView)dgvBC).EditMode = (DataGridViewEditMode)0;
			}
			else
			{
				Send2CrystalByConnection = true;
				set_MyDGVSource(isSet2Print: false, base.MyController.GetData(arrayList.ToArray()));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.ShowWithFormat(50177, new object[1] { ex2.Message });
			ProjectData.ClearProjectError();
		}
		return true;
	}

	protected override void FormatGridView()
	{
		if ((((DataGridView)dgvBC).RowCount > 0 && Operators.CompareString(sTabName, "X", false) != 0) ? true : false)
		{
			txtGhi_chu.Text = Conversions.ToString(get_MyDGVSource(isSet2Print: true).Rows[0]["ghi_chu"]);
		}
		base.FormatGridView();
		checked
		{
			int num = ((DataGridView)dgvBC).ColumnCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					((DataGridView)dgvBC).Columns[num2].ReadOnly = false;
					num2++;
					continue;
				}
				break;
			}
		}
	}

	protected override void ViewCrystalByConnection()
	{
		base.Parameters4StoredProcedure.Clear();
		base.Parameters4StoredProcedure.Add("@pMa_cty", CompanyInformations.CompanyID);
		base.Parameters4StoredProcedure.Add("@pMau", CompanyInformations.Qd_cdkt);
		base.Parameters4StoredProcedure.Add("@pNgay1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		base.Parameters4StoredProcedure.Add("@pNgay2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		base.ViewCrystalByConnection();
	}

	private string GetFilterTitle()
	{
		return "";
	}

	private void cboMauBC_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboMau_bc.SelectedIndex >= 0)
		{
			DataLoading = true;
			if (((TabControl)AsTabControl).SelectedTab == tabGrid)
			{
				base.Execute();
				FormatGridView();
			}
			DataLoading = false;
			sMenuID = MyReportInfo.par0;
			sTabName = MyReportInfo.ma_mau;
			if (Operators.CompareString(sTabName, "X", false) != 0)
			{
				((Control)cmdDMCT).Visible = true;
			}
			else
			{
				((Control)cmdDMCT).Visible = false;
			}
		}
	}

	private void cmdDMCT_Click(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		Form val = Application.OpenForms["frmDMChiTieu"];
		foreach (Form item in (ReadOnlyCollectionBase)(object)Application.OpenForms)
		{
			Form val2 = item;
			if (val2 is frmDMChiTieu)
			{
				if (Operators.CompareString(sMenuID, sMenuIDB, false) == 0)
				{
					return;
				}
				val2.Close();
				break;
			}
		}
		sMenuIDB = sMenuID;
		((Control)this).Refresh();
		((Control)cboMau_bc).Refresh();
		frmDMChiTieu frmDMChiTieu2 = new frmDMChiTieu(MyMenuID);
		frmDMChiTieu2 = new frmDMChiTieu(sMenuID);
		((Form)frmDMChiTieu2).WindowState = (FormWindowState)0;
		frmDMChiTieu2.Show();
	}

	private void cmdLuu_Click(object sender, EventArgs e)
	{
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		if (dgvBC.DataSource == null || !((object)((TabControl)AsTabControl).SelectedTab).Equals((object?)tabGrid) || Operators.CompareString(sTabName, "X", false) == 0 || (int)CMessageBox.ShowWithFormat(50168, (MessageBoxButtons)4) == 7)
		{
			return;
		}
		checked
		{
			try
			{
				COPBDAO cOPBDAO = (COPBDAO)DAOFactory.CreateDAOInstance("COPBDAO", "GLRptTMBCTC");
				ArrayList arrayList = new ArrayList();
				arrayList.Add(CompanyInformations.CompanyID);
				arrayList.Add(CompanyInformations.Qd_cdkt);
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
				arrayList.Add(sTabName);
				cOPBDAO.Delete_BCTCTM(arrayList.ToArray());
				((Control)dgvBC).Update();
				foreach (DataRow row in get_MyDGVSource(isSet2Print: true).Rows)
				{
					arrayList.Clear();
					arrayList.Add(sTabName);
					int num = get_MyDGVSource(isSet2Print: true).Columns.Count - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						arrayList.Add("@p" + get_MyDGVSource(isSet2Print: true).Columns[num2].ColumnName);
						if (Operators.CompareString(get_MyDGVSource(isSet2Print: true).Columns[num2].ColumnName, "ghi_chu", false) == 0)
						{
							arrayList.Add(txtGhi_chu.Text);
						}
						else
						{
							arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(row[get_MyDGVSource(isSet2Print: true).Columns[num2].ColumnName]), isNum: false)));
						}
						num2++;
					}
					arrayList.Add("@pUserData");
					arrayList.Add(1);
					cOPBDAO.Insert_BCTCTM(arrayList.ToArray());
				}
				cOPBDAO.Destroy();
				CMessageBox.Show(50175);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				CMessageBox.ShowWithFormat(50174, new object[1] { Conversions.ToString(Information.Err().Number) + "-" + Information.Err().Description });
				ProjectData.ClearProjectError();
			}
		}
	}

	private void btnTinh_lai_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		frmDialog frmDialog = new frmDialog();
		((Form)frmDialog).ShowDialog();
		if (Operators.CompareString(frmDialog.oAction, "2", false) == 0)
		{
			return;
		}
		((Control)this).Cursor = Cursors.WaitCursor;
		ArrayList arrayList = new ArrayList();
		COPBDAO cOPBDAO = (COPBDAO)DAOFactory.CreateDAOInstance("COPBDAO", "GLRptTMBCTC");
		checked
		{
			if (Operators.CompareString(frmDialog.oAction, "1", false) == 0)
			{
				if (Operators.CompareString(sTabName, "X", false) == 0)
				{
					((Control)this).Cursor = Cursors.Default;
					CMessageBox.ShowWithFormat(50189, new object[1] { cboMau_bc.Text });
					return;
				}
				arrayList.Add(CompanyInformations.CompanyID);
				arrayList.Add(CompanyInformations.Qd_cdkt);
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
				arrayList.Add(sTabName);
				if (cOPBDAO.Cal_BCTCTM(arrayList.ToArray()) == 0)
				{
					CMessageBox.Show(50015);
				}
				else
				{
					CMessageBox.ShowWithFormat(50172, new object[1] { cboMau_bc.Text });
				}
			}
			else if (Operators.CompareString(frmDialog.oAction, "0", false) == 0)
			{
				ArrayList reportInformation = AsiaErp.Framework.Environment.GetReportInformation(MyMenuID);
				int num = reportInformation.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					ReportInformation reportInformation2 = (ReportInformation)reportInformation[num2];
					string ma_mau = reportInformation2.ma_mau;
					if (Operators.CompareString(ma_mau, "X", false) != 0)
					{
						arrayList.Clear();
						arrayList.Add(CompanyInformations.CompanyID);
						arrayList.Add(CompanyInformations.Qd_cdkt);
						arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
						arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
						arrayList.Add(ma_mau);
						if (cOPBDAO.Cal_BCTCTM(arrayList.ToArray()) != 0)
						{
							CMessageBox.ShowWithFormat(50172, new object[1] { reportInformation2.ten_mau });
							((Control)this).Cursor = Cursors.Default;
							return;
						}
					}
					num2++;
				}
				CMessageBox.Show(50015);
			}
			cOPBDAO.Destroy();
			((Control)this).Cursor = Cursors.Default;
		}
	}
}
