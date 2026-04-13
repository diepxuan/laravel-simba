using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmARRptBCCN05 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("txtMa_Tk")]
	private AsTextBox _txtMa_Tk;

	[AccessedThroughProperty("lblMa_tk")]
	private Label _lblMa_tk;

	[AccessedThroughProperty("lblTenKH")]
	private Label _lblTenKH;

	[AccessedThroughProperty("txtMa_khs")]
	private TextBox _txtMa_khs;

	[AccessedThroughProperty("txtNgay_lp")]
	private AsMaskedTextBox _txtNgay_lp;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	internal virtual AsTextBox txtMa_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_Kh_AfterCodeValidating;
			if (_txtMa_Kh != null)
			{
				_txtMa_Kh.AfterCodeValidating -= obj;
			}
			_txtMa_Kh = value;
			if (_txtMa_Kh != null)
			{
				_txtMa_Kh.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual Label lblMa_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Kh = value;
		}
	}

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

	internal virtual AsTextBox txtMa_Tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Tk = value;
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

	internal virtual Label lblTenKH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTenKH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTenKH = value;
		}
	}

	internal virtual TextBox txtMa_khs
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_khs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_khs = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_lp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_lp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_lp = value;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	public frmARRptBCCN05(string MenuId)
		: base(MenuId)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmARRptBCCN05_KeyDown);
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		txtMa_Kh = new AsTextBox();
		lblTenKH = new Label();
		lblMa_Kh = new Label();
		lblTen_Tk = new Label();
		txtMa_Tk = new AsTextBox();
		lblMa_tk = new Label();
		txtMa_khs = new TextBox();
		txtNgay_lp = new AsMaskedTextBox();
		Label1 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(730, 316);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)txtNgay_lp);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_khs);
		((Control)tabFilter).Controls.Add((Control)(object)lblTenKH);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_tk);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Kh);
		TabPage obj = tabFilter;
		size = new Size(722, 287);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTenKH, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_khs, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay_lp, 0);
		Label obj2 = lbl2;
		Point location = new Point(277, 81);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 2;
		Button obj3 = cmdExcel;
		location = new Point(700, 1121);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(296, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 1121);
		((Control)obj4).Location = location;
		((Control)cmdModifyReport).TabIndex = 12;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(206, 77);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj5 = cboKyBc;
		location = new Point(110, 77);
		((Control)obj5).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj6 = lblKyBc;
		location = new Point(24, 81);
		((Control)obj6).Location = location;
		ComboBox obj7 = cboMau_bc;
		location = new Point(110, 24);
		((Control)obj7).Location = location;
		((Control)cboMau_bc).TabIndex = 11;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 182);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 6;
		Label obj8 = lblMauBC;
		location = new Point(155, 181);
		((Control)obj8).Location = location;
		((Control)lblMauBC).TabIndex = 7;
		RadioButton obj9 = optVND;
		location = new Point(242, 180);
		((Control)obj9).Location = location;
		((Control)optVND).TabIndex = 8;
		RadioButton obj10 = optNt;
		location = new Point(296, 181);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 9;
		Label obj11 = lblMa_nt;
		location = new Point(24, 184);
		((Control)obj11).Location = location;
		Button obj12 = cmdOk;
		location = new Point(26, 221);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 10;
		Label obj13 = lblTieu_de;
		location = new Point(24, 55);
		((Control)obj13).Location = location;
		TextBox obj14 = txtTieu_De;
		location = new Point(110, 51);
		((Control)obj14).Location = location;
		((Control)txtTieu_De).TabIndex = 13;
		TabPage obj15 = tabGrid;
		size = new Size(722, 287);
		((Control)obj15).Size = size;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_Kh;
		location = new Point(110, 156);
		((Control)asTextBox2).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		txtMa_Kh.LookupWhereCondition = "ksd=0";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTenKH;
		AsTextBox asTextBox3 = txtMa_Kh;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_Kh).TabIndex = 5;
		txtMa_Kh.UseAutoCompleteSource = true;
		txtMa_Kh.ValidReturnFieldList = "MA_KH,ten_kh,Dia_chi,tel,nguoi_gd";
		lblTenKH.ImeMode = (ImeMode)0;
		Label obj16 = lblTenKH;
		location = new Point(207, 159);
		((Control)obj16).Location = location;
		((Control)lblTenKH).Name = "lblTenKH";
		Label obj17 = lblTenKH;
		size = new Size(344, 13);
		((Control)obj17).Size = size;
		((Control)lblTenKH).TabIndex = 1102;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj18 = lblMa_Kh;
		location = new Point(24, 159);
		((Control)obj18).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj19 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_Kh).TabIndex = 1035;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj20 = lblTen_Tk;
		location = new Point(206, 134);
		((Control)obj20).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj21 = lblTen_Tk;
		size = new Size(344, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_Tk).TabIndex = 1099;
		((TextBox)txtMa_Tk).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Tk.AutoLookup = true;
		txtMa_Tk.AutoValid = true;
		((TextBoxBase)txtMa_Tk).BackColor = SystemColors.Info;
		((TextBox)txtMa_Tk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_Tk;
		location = new Point(110, 130);
		((Control)asTextBox4).Location = location;
		txtMa_Tk.LookupCodeName = "TK";
		txtMa_Tk.LookupWhereCondition = "tk_cn=1";
		((Control)txtMa_Tk).Name = "txtMa_Tk";
		txtMa_Tk.NameControl = lblTen_Tk;
		txtMa_Tk.SD = true;
		AsTextBox asTextBox5 = txtMa_Tk;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_Tk).TabIndex = 4;
		txtMa_Tk.UseAutoCompleteSource = true;
		lblMa_tk.AutoSize = true;
		lblMa_tk.ImeMode = (ImeMode)0;
		Label obj22 = lblMa_tk;
		location = new Point(24, 133);
		((Control)obj22).Location = location;
		((Control)lblMa_tk).Name = "lblMa_tk";
		Label obj23 = lblMa_tk;
		size = new Size(55, 13);
		((Control)obj23).Size = size;
		((Control)lblMa_tk).TabIndex = 1098;
		lblMa_tk.Text = "Tài khoản";
		lblMa_tk.TextAlign = (ContentAlignment)16;
		TextBox obj24 = txtMa_khs;
		location = new Point(210, 492);
		((Control)obj24).Location = location;
		((Control)txtMa_khs).Name = "txtMa_khs";
		((TextBoxBase)txtMa_khs).ReadOnly = true;
		TextBox obj25 = txtMa_khs;
		size = new Size(240, 20);
		((Control)obj25).Size = size;
		((Control)txtMa_khs).TabIndex = 1103;
		((Control)txtMa_khs).Visible = false;
		txtNgay_lp.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_lp).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_lp;
		location = new Point(110, 104);
		((Control)asMaskedTextBox3).Location = location;
		((MaskedTextBox)txtNgay_lp).Mask = "##/##/####";
		((Control)txtNgay_lp).Name = "txtNgay_lp";
		((MaskedTextBox)txtNgay_lp).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_lp;
		size = new Size(90, 20);
		((Control)asMaskedTextBox4).Size = size;
		((Control)txtNgay_lp).TabIndex = 3;
		((MaskedTextBox)txtNgay_lp).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_lp;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox5.Value = dateTime;
		Label1.AutoSize = true;
		Label1.ImeMode = (ImeMode)0;
		Label label = Label1;
		location = new Point(24, 107);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(79, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1104;
		Label1.Text = "Ngày đối chiếu";
		Label1.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(730, 341);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmARRptBCCN05";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		base.InitOtherComponents();
		txtNgay_lp.Value = DateTime.Now;
		((DataGridView)dgvBC).CellContentClick += new DataGridViewCellEventHandler(dgvBC_CellContentClick);
	}

	protected override bool LoadData()
	{
		if (((TextBox)txtMa_Tk).Text.Trim().Length == 0)
		{
			return false;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_Tk).Text);
		arrayList.Add(((TextBox)txtMa_Kh).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: false, MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		base.MyFomularFields.Add("tk", ((TextBox)txtMa_Tk).Text);
		base.MyFomularFields.Add("ten_tk", lblTen_Tk.Text);
		return true;
	}

	protected override bool ValidData()
	{
		((TextBox)txtMa_Tk).Text = ((TextBox)txtMa_Tk).Text.Trim();
		((TextBox)txtMa_Kh).Text = ((TextBox)txtMa_Kh).Text.Trim();
		return ChkEmtyTextBox((TextBox)(object)txtMa_Tk);
	}

	protected override void ViewCrystalBySource()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (((TextBox)txtMa_Tk).Text.Trim().Length != 0)
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		DataRowView dataRowView = get_MyDGVSource(isSet2Print: true).DefaultView[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
		if ((int)keycode != 116 || Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_kh"]), isNum: false), (object)"", false))
		{
			base.CancelDrilldown = true;
			return null;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_Tk).Text);
		arrayList.Add(dataRowView["ma_kh"].ToString());
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

	private void txtMa_Kh_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (txtMa_khs.Text.Trim().Length == 0)
		{
			txtMa_khs.Text = Conversions.ToString(e.ValidatedRow["MA_KH"]);
		}
		else
		{
			txtMa_khs.Text = Conversions.ToString(Operators.AddObject((object)(txtMa_khs.Text + ","), e.ValidatedRow["MA_KH"]));
		}
	}

	private void dgvBC_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
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
	}

	private DataTable LoadDataToCry()
	{
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Invalid comparison between Unknown and I4
		frmInputInfo frmInputInfo2 = new frmInputInfo();
		string text = "";
		foreach (DataRow item in get_MyDGVSource(isSet2Print: true).Select("TAG=1 and ma_kh<>'' ").Take(1))
		{
			text = Conversions.ToString(item["ma_kh"]);
			frmInputInfo2.txtTenKh.Text = Conversions.ToString(item["ten_kh"]);
			frmInputInfo2.txtDiaChiKh.Text = Conversions.ToString(item["dia_chi"]);
			frmInputInfo2.txtDienThoaiKh.Text = Conversions.ToString(item["tel"]);
			frmInputInfo2.txtKh1.Text = Conversions.ToString(item["nguoi_gd"]);
		}
		frmInputInfo2.txtTenCty.Text = CompanyInformations.CompanyName;
		frmInputInfo2.txtDiaChiCty.Text = CompanyInformations.CompanyAddress;
		frmInputInfo2.txtDienThoaiCty.Text = CompanyInformations.CompanyTel;
		if (text.Length == 0)
		{
			return null;
		}
		DialogResult val = ((Form)frmInputInfo2).ShowDialog((IWin32Window)(object)this);
		if ((int)val != 1)
		{
			return null;
		}
		double num = 0.0;
		double num2 = 0.0;
		num = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Compute("sum(dn_ck)", "Tag=1  and ma_kh= '" + text + "'")), isNum: true));
		num2 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Compute("sum(dc_ck)", "Tag=1  and ma_kh= '" + text + "'")), isNum: true));
		double num3 = double.Parse(Conversions.ToString(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Helper.Repl_Null(num, isNum: true), Helper.Repl_Null(num2, isNum: true)) }, (string[])null, (Type[])null, (bool[])null)));
		DataRow[] array = get_MyDGVSource(isSet2Print: true).Select("Tag=1 and ma_kh= '" + text + "'");
		foreach (DataRow dataRow in array)
		{
			dataRow["tag"] = 0;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_Tk).Text);
		arrayList.Add(text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		base.MyFomularFields.Add("tk", ((TextBox)txtMa_Tk).Text);
		base.MyFomularFields.Add("ten_tk", lblTen_Tk.Text);
		base.MyFomularFields.Add("ngay_lp", DateTime.Parse(Conversions.ToString(txtNgay_lp.Value)).ToString("dd/MM/yyyy"));
		base.MyFomularFields.Add("Bang_chu", Commons.DOI_SO_CHU(num3, "đồng"));
		base.MyFomularFields.Add("ngay1", DateTime.Parse(Conversions.ToString(txtNgay1.Value)).ToString("dd/MM/yyyy"));
		base.MyFomularFields.Add("ngay2", DateTime.Parse(Conversions.ToString(txtNgay2.Value)).ToString("dd/MM/yyyy"));
		base.MyFomularFields.Add("ten_kh_", frmInputInfo2.txtTenKh.Text);
		base.MyFomularFields.Add("dia_chi_kh", frmInputInfo2.txtDiaChiKh.Text);
		base.MyFomularFields.Add("tel_kh", frmInputInfo2.txtDienThoaiKh.Text);
		base.MyFomularFields.Add("kh1", frmInputInfo2.txtKh1.Text);
		base.MyFomularFields.Add("kh2", frmInputInfo2.txtkh2.Text);
		base.MyFomularFields.Add("cvkh1", frmInputInfo2.txtCvKh1.Text);
		base.MyFomularFields.Add("cvkh2", frmInputInfo2.txtCvKh2.Text);
		base.MyFomularFields.Add("ten_cty", frmInputInfo2.txtTenCty.Text);
		base.MyFomularFields.Add("dia_chi_cty", frmInputInfo2.txtDiaChiCty.Text);
		base.MyFomularFields.Add("tel_cty", frmInputInfo2.txtDienThoaiCty.Text);
		base.MyFomularFields.Add("cty1", frmInputInfo2.txtCty1.Text);
		base.MyFomularFields.Add("cty2", frmInputInfo2.txtCty2.Text);
		base.MyFomularFields.Add("cvcty1", frmInputInfo2.txtCvCty1.Text);
		base.MyFomularFields.Add("cvcty2", frmInputInfo2.txtCvCty2.Text);
		return Commons.GetDataSet("asARRptBCCN05_Crys", arrayList.ToArray()).Tables[0];
	}

	private bool ValidateData()
	{
		return get_MyDGVSource(isSet2Print: true).Select("TAG=1").Any();
	}

	private void frmARRptBCCN05_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 115)
		{
			ViewCrystalBySource();
		}
	}
}
