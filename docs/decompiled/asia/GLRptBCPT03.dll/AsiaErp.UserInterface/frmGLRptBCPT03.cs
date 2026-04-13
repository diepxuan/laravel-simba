using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLRptBCPT03 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("lblMonth")]
	private Label _lblMonth;

	[AccessedThroughProperty("txtMonth")]
	private AsTextNumeric _txtMonth;

	[AccessedThroughProperty("txtSo_ky")]
	private AsTextNumeric _txtSo_ky;

	[AccessedThroughProperty("lblSo_ky")]
	private Label _lblSo_ky;

	[AccessedThroughProperty("cboLoai_bc")]
	private ComboBox _cboLoai_bc;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	internal virtual Label lblMonth
	{
		get
		{
			return _lblMonth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMonth = value;
		}
	}

	internal virtual AsTextNumeric txtMonth
	{
		get
		{
			return _txtMonth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMonth = value;
		}
	}

	internal virtual AsTextNumeric txtSo_ky
	{
		get
		{
			return _txtSo_ky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_ky = value;
		}
	}

	internal virtual Label lblSo_ky
	{
		get
		{
			return _lblSo_ky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblSo_ky = value;
		}
	}

	internal virtual ComboBox cboLoai_bc
	{
		get
		{
			return _cboLoai_bc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboLoai_bc_SelectedIndexChanged;
			if (_cboLoai_bc != null)
			{
				_cboLoai_bc.SelectedIndexChanged -= eventHandler;
			}
			_cboLoai_bc = value;
			if (_cboLoai_bc != null)
			{
				_cboLoai_bc.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	public frmGLRptBCPT03(string MenuId)
		: base(MenuId)
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		txtMonth = new AsTextNumeric();
		lblMonth = new Label();
		txtSo_ky = new AsTextNumeric();
		lblSo_ky = new Label();
		Label1 = new Label();
		cboLoai_bc = new ComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(651, 278);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 1;
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai_bc);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMonth);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_ky);
		((Control)tabFilter).Controls.Add((Control)(object)lblMonth);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_ky);
		TabPage obj = tabFilter;
		size = new Size(643, 249);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_ky, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMonth, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_ky, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMonth, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		Label obj2 = lbl2;
		Point location = new Point(444, 416);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(529, 223);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 9;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(463, 412);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).Visible = false;
		Button obj4 = cmdCancel;
		location = new Point(448, 223);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 8;
		((Control)cmdModifyReport).TabIndex = 7;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(373, 412);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).Visible = false;
		ComboBox obj5 = cboKyBc;
		location = new Point(277, 412);
		((Control)obj5).Location = location;
		((Control)cboKyBc).Visible = false;
		Label obj6 = lblKyBc;
		location = new Point(191, 416);
		((Control)obj6).Location = location;
		((Control)lblKyBc).Visible = false;
		ComboBox obj7 = cboMau_bc;
		location = new Point(110, 24);
		((Control)obj7).Location = location;
		((Control)cboMau_bc).TabIndex = 5;
		((Control)lblMau_bc).TabIndex = 13;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 161);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 3;
		Label obj8 = lblMauBC;
		location = new Point(164, 160);
		((Control)obj8).Location = location;
		((Control)lblMauBC).TabIndex = 10;
		RadioButton obj9 = optVND;
		location = new Point(251, 159);
		((Control)obj9).Location = location;
		((Control)optVND).TabIndex = 11;
		optVND.TabStop = false;
		RadioButton obj10 = optNt;
		location = new Point(305, 160);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 12;
		Label obj11 = lblMa_nt;
		location = new Point(24, 163);
		((Control)obj11).Location = location;
		((Control)lblMa_nt).TabIndex = 18;
		Button obj12 = cmdOk;
		location = new Point(27, 215);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 4;
		((Control)lblTieu_de).TabIndex = 14;
		((Control)txtTieu_De).TabIndex = 6;
		TabPage obj13 = tabGrid;
		size = new Size(612, 257);
		((Control)obj13).Size = size;
		txtMonth.DecimalSymbol = ".";
		txtMonth.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtMonth;
		location = new Point(110, 107);
		((Control)asTextNumeric).Location = location;
		txtMonth.Mask = "##";
		((Control)txtMonth).Name = "txtMonth";
		AsTextNumeric asTextNumeric2 = txtMonth;
		size = new Size(39, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtMonth).TabIndex = 1;
		((TextBox)txtMonth).Text = "1";
		((TextBox)txtMonth).TextAlign = (HorizontalAlignment)1;
		txtMonth.Value = 1;
		lblMonth.AutoSize = true;
		Label obj14 = lblMonth;
		location = new Point(24, 111);
		((Control)obj14).Location = location;
		((Control)lblMonth).Name = "lblMonth";
		Label obj15 = lblMonth;
		size = new Size(50, 13);
		((Control)obj15).Size = size;
		((Control)lblMonth).TabIndex = 16;
		lblMonth.Text = "Từ tháng";
		txtSo_ky.DecimalSymbol = ".";
		txtSo_ky.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtSo_ky;
		location = new Point(110, 134);
		((Control)asTextNumeric3).Location = location;
		txtSo_ky.Mask = "##";
		((Control)txtSo_ky).Name = "txtSo_ky";
		AsTextNumeric asTextNumeric4 = txtSo_ky;
		size = new Size(39, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtSo_ky).TabIndex = 2;
		((TextBox)txtSo_ky).Text = "1";
		((TextBox)txtSo_ky).TextAlign = (HorizontalAlignment)1;
		txtSo_ky.Value = 1;
		lblSo_ky.AutoSize = true;
		Label obj16 = lblSo_ky;
		location = new Point(24, 138);
		((Control)obj16).Location = location;
		((Control)lblSo_ky).Name = "lblSo_ky";
		Label obj17 = lblSo_ky;
		size = new Size(34, 13);
		((Control)obj17).Size = size;
		((Control)lblSo_ky).TabIndex = 17;
		lblSo_ky.Text = "Số kỳ";
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(24, 83);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(27, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 15;
		Label1.Text = "Loại";
		cboLoai_bc.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_bc).FormattingEnabled = true;
		cboLoai_bc.Items.AddRange(new object[3] { "Theo tháng", "Theo quý", "Theo năm" });
		ComboBox obj18 = cboLoai_bc;
		location = new Point(110, 79);
		((Control)obj18).Location = location;
		((Control)cboLoai_bc).Name = "cboLoai_bc";
		ComboBox obj19 = cboLoai_bc;
		size = new Size(90, 21);
		((Control)obj19).Size = size;
		((Control)cboLoai_bc).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(651, 303);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGLRptBCPT03";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		ArrayList arrayList = new ArrayList();
		ComboBox val = cboLoai_bc;
		DictionaryEntry dictionaryEntry = new DictionaryEntry("THANG", RuntimeHelpers.GetObjectValue(val.Items[0]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("QUY", RuntimeHelpers.GetObjectValue(val.Items[1]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("NAM", RuntimeHelpers.GetObjectValue(val.Items[2]));
		arrayList.Add(dictionaryEntry);
		((ListControl)val).DisplayMember = "value";
		((ListControl)val).ValueMember = "key";
		val.DataSource = arrayList;
		val.SelectedIndex = 0;
		val = null;
	}

	protected override bool ValidData()
	{
		if ((Conversions.ToInteger(((TextBox)txtMonth).Text) > 12) | (Conversions.ToInteger(((TextBox)txtMonth).Text) < 1))
		{
			SetControlError((Control)(object)txtMonth, Helper.GetMessContent(50034));
			return false;
		}
		return base.ValidData();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(base.MyReportInfo.ma_mau);
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(Conversions.ToInteger(((TextBox)txtMonth).Text));
		arrayList.Add(SystemInformations.FinancialYear);
		arrayList.Add(Conversions.ToInteger(((TextBox)txtSo_ky).Text));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_bc).SelectedValue));
		DataSet dataSet = base.MyController.GetDataSet(arrayList.ToArray());
		set_MyDGVSource(isSet2Print: false, dataSet.Tables[1]);
		base.MyCrystalSource = dataSet.Tables[0];
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		ShowNtColumns();
		return true;
	}

	protected override void FormatGridView()
	{
		base.FormatGridView();
		HideColumns();
		ShowNtColumns();
	}

	private string GetFilterTitle()
	{
		StringBuilder stringBuilder = new StringBuilder();
		return stringBuilder.ToString();
	}

	private void HideColumns()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		foreach (DataGridViewColumn item in (BaseCollection)((DataGridView)dgvBC).Columns)
		{
			DataGridViewColumn val = item;
			DataGridViewColumn val2 = val;
			if (string.Compare(val2.DataPropertyName, "stt", ignoreCase: true) == 0)
			{
				val2.Visible = false;
			}
			else if (string.Compare(val2.DataPropertyName, "bold", ignoreCase: true) == 0)
			{
				val2.Visible = false;
			}
			else if (string.Compare(val2.DataPropertyName, "tong", ignoreCase: true) == 0)
			{
				val2.Visible = false;
			}
			else if (string.Compare(val2.DataPropertyName, "id", ignoreCase: true) == 0)
			{
				val2.Visible = false;
			}
			else if (string.Compare(val2.DataPropertyName, "cong_no", ignoreCase: true) == 0)
			{
				val2.Visible = false;
			}
			else if (string.Compare(val2.DataPropertyName, "ts_nv", ignoreCase: true) == 0)
			{
				val2.Visible = false;
			}
			else if (string.Compare(val2.DataPropertyName, "in_ck", ignoreCase: true) == 0)
			{
				val2.Visible = false;
			}
			val2 = null;
		}
	}

	private void cboLoai_bc_SelectedIndexChanged(object sender, EventArgs e)
	{
		txtTieu_De.Text = base.MyMenuInfo.par1 + " ";
		object selectedValue = ((ListControl)cboLoai_bc).SelectedValue;
		if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"THANG", false))
		{
			TextBox val = txtTieu_De;
			val.Text += base.MyMenuInfo.par2;
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"QUY", false))
		{
			TextBox val = txtTieu_De;
			val.Text += base.MyMenuInfo.par3;
		}
		else
		{
			TextBox val = txtTieu_De;
			val.Text += base.MyMenuInfo.par4;
		}
	}

	private void ShowNtColumns()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		bool visible = Conversions.ToBoolean(Interaction.IIf(optNt.Checked, (object)true, (object)false));
		foreach (DataGridViewColumn item in (BaseCollection)((DataGridView)dgvBC).Columns)
		{
			DataGridViewColumn val = item;
			if (val.HeaderText.Contains("_nt"))
			{
				val.Visible = visible;
			}
		}
	}
}
