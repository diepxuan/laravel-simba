using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLRptBCPT04 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("lblFrom")]
	private Label _lblFrom;

	[AccessedThroughProperty("cboThang1")]
	private ComboBox _cboThang1;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("cboQuy_Thang")]
	private ComboBox _cboQuy_Thang;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("cboThang2")]
	private ComboBox _cboThang2;

	[AccessedThroughProperty("lblTo")]
	private Label _lblTo;

	internal virtual Label lblFrom
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFrom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFrom = value;
		}
	}

	internal virtual ComboBox cboThang1
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboThang1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboThang1 = value;
		}
	}

	internal virtual Label lblMa_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_bp = value;
		}
	}

	internal virtual AsTextBox txtMa_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_bp = value;
		}
	}

	internal virtual Label lblTen_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_bp = value;
		}
	}

	internal virtual ComboBox cboQuy_Thang
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboQuy_Thang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboQuy_Thang = value;
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

	internal virtual ComboBox cboThang2
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboThang2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboThang2 = value;
		}
	}

	internal virtual Label lblTo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTo = value;
		}
	}

	public frmGLRptBCPT04(string MenuId)
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		lblFrom = new Label();
		cboThang1 = new ComboBox();
		Label1 = new Label();
		cboQuy_Thang = new ComboBox();
		txtMa_bp = new AsTextBox();
		lblTen_bp = new Label();
		lblMa_bp = new Label();
		lblTo = new Label();
		cboThang2 = new ComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(638, 277);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)cboThang1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblFrom);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)cboQuy_Thang);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTo);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bp);
		((Control)tabFilter).Controls.Add((Control)(object)cboThang2);
		TabPage obj = tabFilter;
		size = new Size(630, 248);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboThang2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTo, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboQuy_Thang, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblFrom, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboThang1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		Label obj2 = lbl2;
		Point location = new Point(259, 360);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(547, 225);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 7;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(279, 357);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).Visible = false;
		Button obj4 = cmdCancel;
		location = new Point(466, 225);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 6;
		((Control)cmdModifyReport).TabIndex = 9;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(189, 357);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).Visible = false;
		ComboBox obj5 = cboKyBc;
		location = new Point(93, 356);
		((Control)obj5).Location = location;
		((Control)cboKyBc).Visible = false;
		Label obj6 = lblKyBc;
		location = new Point(7, 360);
		((Control)obj6).Location = location;
		Label obj7 = lblKyBc;
		size = new Size(39, 13);
		((Control)obj7).Size = size;
		lblKyBc.Text = "Kỳ này";
		((Control)lblKyBc).Visible = false;
		ComboBox obj8 = cboMau_bc;
		location = new Point(110, 24);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 6;
		Label obj9 = lblMau_bc;
		location = new Point(27, 28);
		((Control)obj9).Location = location;
		((Control)lblMau_bc).TabIndex = 21;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 158);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 4;
		Label obj10 = lblMauBC;
		location = new Point(155, 157);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 11;
		RadioButton obj11 = optVND;
		location = new Point(242, 156);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 12;
		optVND.TabStop = false;
		RadioButton obj12 = optNt;
		location = new Point(296, 157);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 13;
		Label obj13 = lblMa_nt;
		location = new Point(27, 160);
		((Control)obj13).Location = location;
		((Control)lblMa_nt).TabIndex = 16;
		Button obj14 = cmdOk;
		location = new Point(27, 206);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 5;
		Label obj15 = lblTieu_de;
		location = new Point(27, 56);
		((Control)obj15).Location = location;
		((Control)lblTieu_de).TabIndex = 20;
		((Control)txtTieu_De).TabIndex = 7;
		TabPage obj16 = tabGrid;
		size = new Size(630, 248);
		((Control)obj16).Size = size;
		lblFrom.AutoSize = true;
		Label obj17 = lblFrom;
		location = new Point(27, 82);
		((Control)obj17).Location = location;
		((Control)lblFrom).Name = "lblFrom";
		Label obj18 = lblFrom;
		size = new Size(50, 13);
		((Control)obj18).Size = size;
		((Control)lblFrom).TabIndex = 19;
		lblFrom.Text = "Từ tháng";
		cboThang1.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboThang1).FormattingEnabled = true;
		cboThang1.Items.AddRange(new object[12]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12"
		});
		ComboBox obj19 = cboThang1;
		location = new Point(110, 78);
		((Control)obj19).Location = location;
		((Control)cboThang1).Name = "cboThang1";
		ComboBox obj20 = cboThang1;
		size = new Size(58, 21);
		((Control)obj20).Size = size;
		((Control)cboThang1).TabIndex = 0;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(27, 109);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(68, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 18;
		Label1.Text = "Quý / Tháng";
		cboQuy_Thang.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboQuy_Thang).FormattingEnabled = true;
		cboQuy_Thang.Items.AddRange(new object[2] { "Theo quý", "Theo tháng" });
		ComboBox obj21 = cboQuy_Thang;
		location = new Point(110, 105);
		((Control)obj21).Location = location;
		((Control)cboQuy_Thang).Name = "cboQuy_Thang";
		ComboBox obj22 = cboQuy_Thang;
		size = new Size(117, 21);
		((Control)obj22).Size = size;
		((Control)cboQuy_Thang).TabIndex = 2;
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_bp;
		location = new Point(110, 132);
		((Control)asTextBox2).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox3 = txtMa_bp;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_bp).TabIndex = 3;
		Label obj23 = lblTen_bp;
		location = new Point(206, 135);
		((Control)obj23).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj24 = lblTen_bp;
		size = new Size(147, 13);
		((Control)obj24).Size = size;
		((Control)lblTen_bp).TabIndex = 14;
		lblMa_bp.AutoSize = true;
		Label obj25 = lblMa_bp;
		location = new Point(27, 136);
		((Control)obj25).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj26 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj26).Size = size;
		((Control)lblMa_bp).TabIndex = 17;
		lblMa_bp.Text = "Mã bộ phận";
		lblTo.AutoSize = true;
		Label obj27 = lblTo;
		location = new Point(174, 82);
		((Control)obj27).Location = location;
		((Control)lblTo).Name = "lblTo";
		Label obj28 = lblTo;
		size = new Size(56, 13);
		((Control)obj28).Size = size;
		((Control)lblTo).TabIndex = 15;
		lblTo.Text = "đến tháng";
		cboThang2.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboThang2).FormattingEnabled = true;
		cboThang2.Items.AddRange(new object[12]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12"
		});
		ComboBox obj29 = cboThang2;
		location = new Point(236, 79);
		((Control)obj29).Location = location;
		((Control)cboThang2).Name = "cboThang2";
		ComboBox obj30 = cboThang2;
		size = new Size(58, 21);
		((Control)obj30).Size = size;
		((Control)cboThang2).TabIndex = 1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(638, 302);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGLRptBCPT04";
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
		cboThang1.SelectedIndex = 0;
		cboThang2.SelectedIndex = 0;
		cboQuy_Thang.SelectedIndex = 0;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(SystemInformations.FinancialYear);
		arrayList.Add(Conversions.ToInteger(cboThang1.Text));
		arrayList.Add(Conversions.ToInteger(cboThang2.Text));
		arrayList.Add(checked(cboQuy_Thang.SelectedIndex + 1));
		arrayList.Add(base.MyReportInfo.ma_mau);
		arrayList.Add(((TextBox)txtMa_bp).Text);
		DataSet dataSet = new DataSet();
		dataSet = base.MyController.GetDataSet(arrayList.ToArray());
		set_MyDGVSource(isSet2Print: false, dataSet.Tables[1]);
		base.MyCrystalSource = dataSet.Tables[0];
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strSubTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (cboQuy_Thang.SelectedIndex >= 0 && cboThang1.SelectedIndex >= 0 && cboThang2.SelectedIndex >= 0)
		{
			stringBuilder.Append(cboQuy_Thang.Text + ": " + lblFrom.Text + " " + cboThang1.Text + " " + lblTo.Text + " " + cboThang2.Text);
		}
		if (Operators.CompareString(((TextBox)txtMa_bp).Text.Trim(), "", false) != 0)
		{
			stringBuilder.Append(lblMa_bp.Text + ":" + ((TextBox)txtMa_bp).Text + ";");
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text.Trim(), "", false) != 0)
		{
			stringBuilder.Append(lblMa_nt.Text + ":" + ((TextBox)txtMa_Nt).Text + ";");
		}
		return stringBuilder.ToString();
	}
}
