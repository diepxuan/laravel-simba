using System;
using System.Collections;
using System.Collections.Generic;
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
public class frmGlRptNKC01All : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("chkTK_sc")]
	private CheckBox _chkTK_sc;

	[AccessedThroughProperty("txtBac")]
	private AsTextNumeric _txtBac;

	[AccessedThroughProperty("lblbac")]
	private Label _lblbac;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("lblten_tk")]
	private Label _lblten_tk;

	[AccessedThroughProperty("chkSTT_NKC")]
	private CheckBox _chkSTT_NKC;

	protected internal override AsTabControl AsTabControl
	{
		[DebuggerNonUserCode]
		get
		{
			return base.AsTabControl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AsTabControl_SelectedIndexChanged;
			if (base.AsTabControl != null)
			{
				((TabControl)base.AsTabControl).SelectedIndexChanged -= eventHandler;
			}
			base.AsTabControl = value;
			if (base.AsTabControl != null)
			{
				((TabControl)base.AsTabControl).SelectedIndexChanged += eventHandler;
			}
		}
	}

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
			EventHandler eventHandler = cboMau_bc_SelectedIndexChanged;
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

	internal virtual CheckBox chkTK_sc
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkTK_sc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkTK_sc = value;
		}
	}

	internal virtual AsTextNumeric txtBac
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtBac;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtBac = value;
		}
	}

	private virtual Label lblbac
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblbac;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblbac = value;
		}
	}

	private virtual AsTextBox txtTk
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

	private virtual Label lblTk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk = value;
		}
	}

	private virtual Label lblten_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblten_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblten_tk = value;
		}
	}

	internal virtual CheckBox chkSTT_NKC
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkSTT_NKC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkSTT_NKC = value;
		}
	}

	public frmGlRptNKC01All(string menuid)
		: base(menuid)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
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
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		chkTK_sc = new CheckBox();
		txtBac = new AsTextNumeric();
		lblbac = new Label();
		txtTk = new AsTextBox();
		lblten_tk = new Label();
		lblTk = new Label();
		chkSTT_NKC = new CheckBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(762, 421);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)chkSTT_NKC);
		((Control)tabFilter).Controls.Add((Control)(object)lblten_tk);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		((Control)tabFilter).Controls.Add((Control)(object)chkTK_sc);
		((Control)tabFilter).Controls.Add((Control)(object)txtBac);
		((Control)tabFilter).Controls.Add((Control)(object)lblbac);
		TabPage obj = tabFilter;
		size = new Size(754, 392);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblbac, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtBac, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)chkTK_sc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblten_tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)chkSTT_NKC, 0);
		Label obj2 = lbl2;
		Point location = new Point(286, 82);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 3;
		Button obj3 = cmdExcel;
		location = new Point(700, -438);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(305, 78);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, -438);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(464, 24);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 13;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(215, 78);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(119, 78);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(26, 81);
		((Control)obj7).Location = location;
		((Control)lblKyBc).TabIndex = 0;
		myHelpProvider.SetHelpKeyword((Control)(object)cboMau_bc, "");
		myHelpProvider.SetHelpString((Control)(object)cboMau_bc, "");
		ComboBox obj8 = cboMau_bc;
		location = new Point(119, 25);
		((Control)obj8).Location = location;
		myHelpProvider.SetShowHelp((Control)(object)cboMau_bc, false);
		((Control)cboMau_bc).TabIndex = 11;
		Label obj9 = lblMau_bc;
		location = new Point(26, 28);
		((Control)obj9).Location = location;
		((Control)lblMau_bc).TabIndex = 11;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(119, 179);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 7;
		Label obj10 = lblMauBC;
		location = new Point(164, 178);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 4;
		RadioButton obj11 = optVND;
		location = new Point(251, 177);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 8;
		RadioButton obj12 = optNt;
		location = new Point(305, 178);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 9;
		Label obj13 = lblMa_nt;
		location = new Point(26, 182);
		((Control)obj13).Location = location;
		((Control)lblMa_nt).TabIndex = 5;
		myHelpProvider.SetHelpKeyword((Control)(object)cmdOk, "");
		myHelpProvider.SetHelpString((Control)(object)cmdOk, "");
		Button obj14 = cmdOk;
		location = new Point(29, 212);
		((Control)obj14).Location = location;
		myHelpProvider.SetShowHelp((Control)(object)cmdOk, false);
		((Control)cmdOk).TabIndex = 10;
		Label obj15 = lblTieu_de;
		location = new Point(26, 55);
		((Control)obj15).Location = location;
		((Control)lblTieu_de).TabIndex = 14;
		TextBox obj16 = txtTieu_De;
		location = new Point(119, 52);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 12;
		TabPage obj17 = tabGrid;
		size = new Size(754, 392);
		((Control)obj17).Size = size;
		((ButtonBase)chkTK_sc).AutoSize = true;
		chkTK_sc.CheckAlign = (ContentAlignment)64;
		CheckBox obj18 = chkTK_sc;
		location = new Point(25, 156);
		((Control)obj18).Location = location;
		((Control)chkTK_sc).Name = "chkTK_sc";
		CheckBox obj19 = chkTK_sc;
		size = new Size(108, 17);
		((Control)obj19).Size = size;
		((Control)chkTK_sc).TabIndex = 5;
		((ButtonBase)chkTK_sc).Text = "Lên cho tk sổ cái";
		((ButtonBase)chkTK_sc).UseVisualStyleBackColor = true;
		txtBac.DecimalSymbol = ".";
		txtBac.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtBac;
		location = new Point(119, 131);
		((Control)asTextNumeric).Location = location;
		txtBac.Mask = "#";
		((Control)txtBac).Name = "txtBac";
		AsTextNumeric asTextNumeric2 = txtBac;
		size = new Size(39, 20);
		((Control)asTextNumeric2).Size = size;
		txtBac.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtBac).TabIndex = 4;
		((TextBox)txtBac).Text = "9";
		((TextBox)txtBac).TextAlign = (HorizontalAlignment)1;
		txtBac.Value = 9;
		lblbac.AutoSize = true;
		lblbac.ImeMode = (ImeMode)0;
		Label obj20 = lblbac;
		location = new Point(26, 133);
		((Control)obj20).Location = location;
		((Control)lblbac).Name = "lblbac";
		Label obj21 = lblbac;
		size = new Size(59, 13);
		((Control)obj21).Size = size;
		((Control)lblbac).TabIndex = 1081;
		lblbac.Text = "In đến bậc";
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = false;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTk;
		location = new Point(119, 105);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblten_tk;
		AsTextBox asTextBox3 = txtTk;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 3;
		((Control)txtTk).Tag = "@pTk";
		txtTk.UseAutoCompleteSource = true;
		lblten_tk.AutoSize = true;
		lblten_tk.ImeMode = (ImeMode)0;
		Label obj22 = lblten_tk;
		location = new Point(215, 108);
		((Control)obj22).Location = location;
		((Control)lblten_tk).Name = "lblten_tk";
		Label obj23 = lblten_tk;
		size = new Size(0, 13);
		((Control)obj23).Size = size;
		((Control)lblten_tk).TabIndex = 1084;
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj24 = lblTk;
		location = new Point(26, 108);
		((Control)obj24).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj25 = lblTk;
		size = new Size(55, 13);
		((Control)obj25).Size = size;
		((Control)lblTk).TabIndex = 1083;
		lblTk.Text = "Tài khoản";
		((ButtonBase)chkSTT_NKC).AutoSize = true;
		chkSTT_NKC.CheckAlign = (ContentAlignment)64;
		CheckBox obj26 = chkSTT_NKC;
		location = new Point(143, 156);
		((Control)obj26).Location = location;
		((Control)chkSTT_NKC).Name = "chkSTT_NKC";
		CheckBox obj27 = chkSTT_NKC;
		size = new Size(139, 17);
		((Control)obj27).Size = size;
		((Control)chkSTT_NKC).TabIndex = 6;
		((ButtonBase)chkSTT_NKC).Text = "Đánh STT theo sổ NKC";
		((ButtonBase)chkSTT_NKC).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(762, 446);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlRptNKC01All";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void AsTabControl_SelectedIndexChanged(object sender, EventArgs e)
	{
		if ((((TabControl)AsTabControl).SelectedTab == tabGrid && Operators.CompareString(base.MyReportInfo.ma_mau, "02", false) == 0) ? true : false)
		{
			((Form)this).Text = base.MyMenuInfo.bar.Trim() + ". F5 - So chu T, Ctrl+F5 - So chi tiet, Shift+F5 - Can doi PS cong no,  F7 - Xem, F9 - In";
		}
	}

	private void cboMau_bc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboMau_bc.SelectedIndex == 0)
		{
			((Control)txtBac).Enabled = false;
			((Control)chkTK_sc).Enabled = false;
			((Control)chkSTT_NKC).Enabled = true;
		}
		else
		{
			((Control)txtBac).Enabled = true;
			((Control)chkTK_sc).Enabled = true;
			((Control)chkSTT_NKC).Enabled = false;
		}
	}

	protected override bool LoadData()
	{
		List<object> list = new List<object>();
		ArrayList arrayList = new ArrayList();
		if (cboMau_bc.SelectedIndex == 1)
		{
			list.Add(CompanyInformations.CompanyID);
			list.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			list.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			list.Add(((TextBox)txtTk).Text);
			list.Add(RuntimeHelpers.GetObjectValue(txtBac.Value));
			list.Add(chkTK_sc.Checked);
			list.Add(((TextBox)txtMa_Nt).Text);
			set_MyDGVSource(isSet2Print: false, base.MyController.GetData(list.ToArray()));
			base.Parameters4DrillDown.Clear();
			base.MyFomularFields.Clear();
			base.Parameters4DrillDown.Add("ngay_ct1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			base.Parameters4DrillDown.Add("ngay_ct2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			base.Parameters4DrillDown.Add("ma_nt", ((TextBox)txtMa_Nt).Text);
		}
		else
		{
			list.Add(CompanyInformations.CompanyID);
			list.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			list.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			list.Add(((TextBox)txtTk).Text);
			list.Add(((TextBox)txtMa_Nt).Text);
			list.Add(chkSTT_NKC.Checked);
			set_MyDGVSource(isSet2Print: true, base.MyController.GetData(list.ToArray()));
			base.Parameters4DrillDown.Clear();
			base.MyFomularFields.Clear();
			base.MyFomularFields.Add("TK", ((TextBox)txtTk).Text);
			base.MyFomularFields.Add("TEN_TK", lblten_tk.Text);
			base.MyFomularFields.Add("Du_Co_Cky", string.Format(AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format, RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[2]["ps_co"])));
			base.MyFomularFields.Add("Du_No_Cky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[2]["ps_no"]));
			base.MyFomularFields.Add("Du_Co_Dky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[0]["ps_co"]));
			base.MyFomularFields.Add("Du_No_Dky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[0]["ps_no"]));
		}
		return true;
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Invalid comparison between Unknown and I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Invalid comparison between Unknown and I4
		DataRowView dataRowView = get_MyDGVSource(isSet2Print: true).DefaultView[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
		if ((int)keycode != 116 || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk"]), isNum: false), (object)"", false) ? true : false))
		{
			base.CancelDrilldown = true;
			return null;
		}
		ArrayList arrayList = new ArrayList();
		if ((int)modifierKeys == 0)
		{
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(dataRowView["tk"].ToString());
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			arrayList.Add(((TextBox)txtMa_Nt).Text);
			filterCondition4title = dataRowView["tk"].ToString();
			if (base.Parameters4DrillDown.Contains("tk"))
			{
				base.Parameters4DrillDown["tk"] = RuntimeHelpers.GetObjectValue(dataRowView["tk"]);
			}
			else
			{
				base.Parameters4DrillDown.Add("tk", RuntimeHelpers.GetObjectValue(dataRowView["tk"]));
			}
		}
		else if ((int)modifierKeys == 131072)
		{
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(dataRowView["tk"].ToString());
			arrayList.Add("");
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			arrayList.Add(((TextBox)txtMa_Nt).Text);
			filterCondition4title = dataRowView["tk"].ToString();
		}
		else
		{
			if ((int)modifierKeys != 65536)
			{
				base.CancelDrilldown = true;
				return null;
			}
			if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk"]), isNum: false), (object)"1", false))
			{
				base.CancelDrilldown = true;
				return null;
			}
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(dataRowView["tk"].ToString());
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			if (base.Parameters4DrillDown.Contains("tk"))
			{
				base.Parameters4DrillDown["tk"] = RuntimeHelpers.GetObjectValue(dataRowView["tk"]);
			}
			else
			{
				base.Parameters4DrillDown.Add("tk", RuntimeHelpers.GetObjectValue(dataRowView["tk"]));
			}
			filterCondition4title = dataRowView["tk"].ToString();
		}
		return arrayList;
	}

	protected override void InitOtherComponents()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		base.InitOtherComponents();
		((Control)dgvBC).KeyDown += new KeyEventHandler(dgvBC_KeyDown);
		((DataGridView)dgvBC).CellContentClick += new DataGridViewCellEventHandler(dgvBC_CellContentClick);
	}

	private void dgvBC_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		Keys keyData = e.KeyData;
		if ((int)keyData != 262209)
		{
			return;
		}
		foreach (DataRow row in get_MyDGVSource(isSet2Print: true).Rows)
		{
			row["TAG"] = Operators.NotObject(row["TAG"]);
		}
	}

	private void dgvBC_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (cboMau_bc.SelectedIndex != 1 || ((DataGridView)dgvBC).CurrentCell.ColumnIndex != ((DataGridViewBand)((DataGridView)dgvBC).Columns["TAG"]).Index)
		{
			return;
		}
		string text = "";
		string text2 = "";
		bool flag = false;
		get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["TAG"] = Operators.NotObject(get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["TAG"]);
		text = Conversions.ToString(get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["TK"]);
		text2 = Conversions.ToString(get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["bold"]);
		flag = Conversions.ToBoolean(get_MyDGVSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index]["TAG"]);
		if (Operators.CompareString(text2, "1", false) == 0)
		{
			DataRow[] array = get_MyDGVSource(isSet2Print: true).Select("TK = '" + text + "' ");
			foreach (DataRow dataRow in array)
			{
				dataRow["TAG"] = flag;
			}
		}
	}

	private DataTable LoadDataToCrystal()
	{
		string text = "";
		if (get_MyDGVSource(isSet2Print: true) != null)
		{
			DataRow[] array = get_MyDGVSource(isSet2Print: true).Select("TAG=1");
			foreach (DataRow dataRow in array)
			{
				text = Conversions.ToString(Operators.AddObject(Operators.AddObject((object)text, dataRow["tk"]), (object)","));
			}
			text = text.Substring(0, checked(text.Length - 1));
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		return Commons.GetDataTable(MyMenuInfo.par1, arrayList.ToArray());
	}

	protected override void ViewCrystalBySource()
	{
		try
		{
			if (cboMau_bc.SelectedIndex == 1)
			{
				base.MyCrystalSource = LoadDataToCrystal();
			}
			base.ViewCrystalBySource();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	protected override bool ValidData()
	{
		if (cboMau_bc.SelectedIndex == 0)
		{
			return (base.ValidData() && ChkEmtyTextBox((TextBox)(object)txtTk)) ? true : false;
		}
		return base.ValidData();
	}
}
