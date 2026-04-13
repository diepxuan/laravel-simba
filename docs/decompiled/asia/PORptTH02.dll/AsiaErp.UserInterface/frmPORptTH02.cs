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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmPORptTH02 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblSo_ky")]
	private Label _lblSo_ky;

	[AccessedThroughProperty("lblTu_thang")]
	private Label _lblTu_thang;

	[AccessedThroughProperty("cboLoai_ct")]
	private ComboBox _cboLoai_ct;

	[AccessedThroughProperty("cboLoai")]
	private ComboBox _cboLoai;

	[AccessedThroughProperty("lblLoai")]
	private Label _lblLoai;

	[AccessedThroughProperty("txtTu_thang")]
	private AsTextNumeric _txtTu_thang;

	[AccessedThroughProperty("txtSo_ky")]
	private AsTextNumeric _txtSo_ky;

	[AccessedThroughProperty("txtNam")]
	private AsTextNumeric _txtNam;

	[AccessedThroughProperty("lblNam")]
	private Label _lblNam;

	[AccessedThroughProperty("cboLoaiPhieu")]
	private AsComboBox _cboLoaiPhieu;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	private const string THANG = "THANG";

	private const string QUY = "QUY";

	private const string NAM = "NAM";

	internal virtual Label lblSo_ky
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_ky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_ky = value;
		}
	}

	internal virtual Label lblTu_thang
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTu_thang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTu_thang = value;
		}
	}

	internal virtual ComboBox cboLoai_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_ct = value;
		}
	}

	internal virtual ComboBox cboLoai
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai = value;
		}
	}

	internal virtual Label lblLoai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai = value;
		}
	}

	internal virtual AsTextNumeric txtTu_thang
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTu_thang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTu_thang = value;
		}
	}

	internal virtual AsTextNumeric txtSo_ky
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ky = value;
		}
	}

	internal virtual AsTextNumeric txtNam
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNam = value;
		}
	}

	internal virtual Label lblNam
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNam = value;
		}
	}

	internal virtual AsComboBox cboLoaiPhieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoaiPhieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoaiPhieu = value;
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

	public frmPORptTH02(string menuID)
		: base(menuID)
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

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
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edc: Expected O, but got Unknown
		lblLoai = new Label();
		cboLoai = new ComboBox();
		cboLoai_ct = new ComboBox();
		lblTu_thang = new Label();
		lblSo_ky = new Label();
		txtTu_thang = new AsTextNumeric();
		txtSo_ky = new AsTextNumeric();
		txtNam = new AsTextNumeric();
		lblNam = new Label();
		cboLoaiPhieu = new AsComboBox();
		Label1 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(860, 455);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)cboLoaiPhieu);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)txtNam);
		((Control)tabFilter).Controls.Add((Control)(object)lblNam);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_ky);
		((Control)tabFilter).Controls.Add((Control)(object)txtTu_thang);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_ky);
		((Control)tabFilter).Controls.Add((Control)(object)lblTu_thang);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai_ct);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoai);
		TabPage obj = tabFilter;
		size = new Size(852, 426);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai_ct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTu_thang, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_ky, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTu_thang, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_ky, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNam, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNam, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoaiPhieu, 0);
		((Control)lbl2).Enabled = false;
		Label obj2 = lbl2;
		Point location = new Point(576, 325);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(700, 407);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 14;
		((Control)txtNgay2).Enabled = false;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(595, 321);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).Visible = false;
		Button obj4 = cmdCancel;
		location = new Point(619, 404);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 13;
		Button obj5 = cmdModifyReport;
		location = new Point(505, 26);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 10;
		((Control)txtNgay1).Enabled = false;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(505, 321);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).Visible = false;
		((Control)cboKyBc).Enabled = false;
		ComboBox obj6 = cboKyBc;
		location = new Point(409, 321);
		((Control)obj6).Location = location;
		((Control)cboKyBc).Visible = false;
		((Control)lblKyBc).Enabled = false;
		Label obj7 = lblKyBc;
		location = new Point(331, 325);
		((Control)obj7).Location = location;
		((Control)lblKyBc).Visible = false;
		ComboBox obj8 = cboMau_bc;
		location = new Point(160, 28);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 9;
		Label obj9 = lblMau_bc;
		location = new Point(20, 28);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(160, 187);
		((Control)asTextBox).Location = location;
		Label obj10 = lblMauBC;
		location = new Point(205, 191);
		((Control)obj10).Location = location;
		RadioButton obj11 = optVND;
		location = new Point(282, 189);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 6;
		RadioButton obj12 = optNt;
		location = new Point(335, 189);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 7;
		Label obj13 = lblMa_nt;
		location = new Point(20, 186);
		((Control)obj13).Location = location;
		Button obj14 = cmdOk;
		location = new Point(23, 227);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 8;
		Label obj15 = lblTieu_de;
		location = new Point(20, 56);
		((Control)obj15).Location = location;
		((Control)lblTieu_de).TabIndex = 12;
		TextBox obj16 = txtTieu_De;
		location = new Point(160, 55);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 11;
		TabPage obj17 = tabGrid;
		size = new Size(852, 426);
		((Control)obj17).Size = size;
		lblLoai.AutoSize = true;
		Label obj18 = lblLoai;
		location = new Point(20, 81);
		((Control)obj18).Location = location;
		((Control)lblLoai).Name = "lblLoai";
		Label obj19 = lblLoai;
		size = new Size(27, 13);
		((Control)obj19).Size = size;
		((Control)lblLoai).TabIndex = 1016;
		lblLoai.Text = "Loại";
		cboLoai.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai).FormattingEnabled = true;
		cboLoai.Items.AddRange(new object[3] { "Theo tháng", "Theo quý", "Theo năm" });
		ComboBox obj20 = cboLoai;
		location = new Point(160, 81);
		((Control)obj20).Location = location;
		((Control)cboLoai).Name = "cboLoai";
		ComboBox obj21 = cboLoai;
		size = new Size(125, 21);
		((Control)obj21).Size = size;
		((Control)cboLoai).TabIndex = 0;
		cboLoai_ct.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_ct).FormattingEnabled = true;
		cboLoai_ct.Items.AddRange(new object[2] { "Phiếu nhập mua", "Hóa đơn mua hàng" });
		ComboBox obj22 = cboLoai_ct;
		location = new Point(281, 230);
		((Control)obj22).Location = location;
		((Control)cboLoai_ct).Name = "cboLoai_ct";
		ComboBox obj23 = cboLoai_ct;
		size = new Size(125, 21);
		((Control)obj23).Size = size;
		((Control)cboLoai_ct).TabIndex = 1;
		((Control)cboLoai_ct).Visible = false;
		lblTu_thang.AutoSize = true;
		Label obj24 = lblTu_thang;
		location = new Point(20, 135);
		((Control)obj24).Location = location;
		((Control)lblTu_thang).Name = "lblTu_thang";
		Label obj25 = lblTu_thang;
		size = new Size(50, 13);
		((Control)obj25).Size = size;
		((Control)lblTu_thang).TabIndex = 1022;
		lblTu_thang.Text = "Từ tháng";
		lblSo_ky.AutoSize = true;
		Label obj26 = lblSo_ky;
		location = new Point(20, 161);
		((Control)obj26).Location = location;
		((Control)lblSo_ky).Name = "lblSo_ky";
		Label obj27 = lblSo_ky;
		size = new Size(34, 13);
		((Control)obj27).Size = size;
		((Control)lblSo_ky).TabIndex = 1023;
		lblSo_ky.Text = "Số kỳ";
		txtTu_thang.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTu_thang;
		location = new Point(160, 135);
		((Control)asTextNumeric).Location = location;
		txtTu_thang.Mask = "##";
		((TextBoxBase)txtTu_thang).MaxLength = 2;
		((Control)txtTu_thang).Name = "txtTu_thang";
		AsTextNumeric asTextNumeric2 = txtTu_thang;
		size = new Size(39, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTu_thang).TabIndex = 2;
		((TextBox)txtTu_thang).Text = "1";
		((TextBox)txtTu_thang).TextAlign = (HorizontalAlignment)1;
		txtTu_thang.Value = 1.0;
		txtSo_ky.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric3 = txtSo_ky;
		location = new Point(160, 161);
		((Control)asTextNumeric3).Location = location;
		txtSo_ky.Mask = "##";
		((TextBoxBase)txtSo_ky).MaxLength = 2;
		((Control)txtSo_ky).Name = "txtSo_ky";
		AsTextNumeric asTextNumeric4 = txtSo_ky;
		size = new Size(39, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtSo_ky).TabIndex = 4;
		((TextBox)txtSo_ky).Text = "1";
		((TextBox)txtSo_ky).TextAlign = (HorizontalAlignment)1;
		txtSo_ky.Value = 1.0;
		txtNam.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric5 = txtNam;
		location = new Point(242, 135);
		((Control)asTextNumeric5).Location = location;
		txtNam.Mask = "####";
		((TextBoxBase)txtNam).MaxLength = 2;
		((Control)txtNam).Name = "txtNam";
		AsTextNumeric asTextNumeric6 = txtNam;
		size = new Size(43, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtNam).TabIndex = 3;
		((TextBox)txtNam).Text = "0";
		((TextBox)txtNam).TextAlign = (HorizontalAlignment)1;
		txtNam.Value = 0.0;
		lblNam.AutoSize = true;
		Label obj28 = lblNam;
		location = new Point(208, 138);
		((Control)obj28).Location = location;
		((Control)lblNam).Name = "lblNam";
		Label obj29 = lblNam;
		size = new Size(29, 13);
		((Control)obj29).Size = size;
		((Control)lblNam).TabIndex = 1025;
		lblNam.Text = "Năm";
		((ComboBox)cboLoaiPhieu).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoaiPhieu).FormattingEnabled = true;
		((ComboBox)cboLoaiPhieu).Items.AddRange(new object[9] { "Tất cả", "Phiếu đề nghị mua hàng", "Đơn hàng mua", "Phiếu nhập mua", "Hoá đơn mua hàng", "Phiếu chi phí mua hàng", "Phiếu xuất trả lại NCC", "Hoá đơn mua dịch vụ", "Hoá đơn mua hàng nhập khẩu" });
		AsComboBox asComboBox = cboLoaiPhieu;
		location = new Point(160, 108);
		((Control)asComboBox).Location = location;
		((Control)cboLoaiPhieu).Name = "cboLoaiPhieu";
		AsComboBox asComboBox2 = cboLoaiPhieu;
		size = new Size(183, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboLoaiPhieu).TabIndex = 1;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(19, 108);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(56, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1134;
		Label1.Text = "Loại phiếu";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(860, 480);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmPORptTH02";
		((Form)this).Text = "frmPORptTH08";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		base.InitOtherComponents();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		ComboBox val = cboLoai;
		dictionary.Add("THANG", Conversions.ToString(val.Items[0]));
		dictionary.Add("QUY", Conversions.ToString(val.Items[1]));
		dictionary.Add("NAM", Conversions.ToString(val.Items[2]));
		BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
		val.DataSource = dataSource;
		((ListControl)val).DisplayMember = "value";
		((ListControl)val).ValueMember = "key";
		val.SelectedIndex = 0;
		val = null;
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(MyMenuInfo.moduleid);
		arrayList.Add("0");
		arrayList.Add(SystemInformations.CurrentCultureName);
		ArrayList arrayList2 = CBO<lstVoucherInfo>.FillCollection(Commons.GetDataReader("asSIGetDmSo_ct", arrayList.ToArray()));
		arrayList2.Add(new lstVoucherInfo("", AsiaErp.Framework.Environment.getLangSysMessageResX("#SYS_ALL").value));
		((ComboBox)cboLoaiPhieu).DataSource = arrayList2;
		((ListControl)cboLoaiPhieu).DisplayMember = "TEN_CT";
		((ListControl)cboLoaiPhieu).ValueMember = "MA_CT";
		((ListControl)cboLoaiPhieu).SelectedValue = base.MyReportInfo.par0;
		((TextBox)txtNam).Text = Conversions.ToString(SystemInformations.FinancialYear);
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoaiPhieu).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtTu_thang.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNam.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtSo_ky.Value));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(optNt.Checked);
		DataSet dataSet = new DataSet();
		dataSet = base.MyController.GetDataSet(arrayList.ToArray());
		set_MyDGVSource(isSet2Print: true, dataSet.Tables[1]);
		base.MyCrystalSource = dataSet.Tables[0];
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	protected override bool ValidData()
	{
		if (Operators.ConditionalCompareObjectLess(txtTu_thang.Value, (object)1, false))
		{
			epNotice.SetError((Control)(object)txtTu_thang, Helper.GetMessContent(50034));
			((Control)txtTu_thang).Focus();
			return false;
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(txtNam.Value, (object)1900, false), Operators.CompareObjectGreater(txtNam.Value, (object)2079, false))))
		{
			epNotice.SetError((Control)(object)txtNam, Helper.GetMessContent(50034));
			((Control)txtNam).Focus();
			return false;
		}
		if (Operators.ConditionalCompareObjectLess(txtSo_ky.Value, (object)1, false))
		{
			epNotice.SetError((Control)(object)txtSo_ky, Helper.GetMessContent(50034));
			((Control)txtSo_ky).Focus();
			return false;
		}
		return base.ValidData();
	}

	private bool ValidateSoKy()
	{
		bool flag = false;
		object selectedValue = ((ListControl)cboLoai).SelectedValue;
		if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"THANG", false))
		{
			flag = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(txtSo_ky.Value, (object)1, false), Operators.CompareObjectLessEqual(txtSo_ky.Value, (object)12, false)));
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"QUY", false))
		{
			flag = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(txtSo_ky.Value, (object)1, false), Operators.CompareObjectLessEqual(txtSo_ky.Value, (object)4, false)));
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"NAM", false))
		{
			flag = Operators.ConditionalCompareObjectEqual(txtSo_ky.Value, (object)1, false);
		}
		if (!flag)
		{
			SetControlError((Control)(object)txtSo_ky, Helper.GetMessContent(50034));
		}
		return flag;
	}

	private string GetFilterTitle()
	{
		string text = "";
		text = text + lblLoai.Text + ": " + cboLoai.Text + "; ";
		if (Operators.CompareString(((ListControl)cboLoaiPhieu).SelectedValue.ToString(), "", false) != 0)
		{
			text = text + "Loại Phiếu:" + ((ListControl)cboLoaiPhieu).SelectedValue.ToString() + ": " + ((ComboBox)cboLoaiPhieu).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtTu_thang).Text, "", false) != 0)
		{
			text = text + lblTu_thang.Text + ": " + ((TextBox)txtTu_thang).Text + "; ";
		}
		text = text + lblNam.Text + ": " + ((TextBox)txtNam).Text + "; ";
		if (Operators.CompareString(((TextBox)txtSo_ky).Text, "", false) != 0)
		{
			text = text + lblSo_ky.Text + ": " + ((TextBox)txtSo_ky).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
		}
		if (text.Length > 2)
		{
			text = text.Substring(0, checked(text.Length - 2));
		}
		return text;
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		DataRowView dataRowView;
		ArrayList result;
		try
		{
			dataRowView = new DataView((DataTable)base.dgvBC.DataSource)[((DataGridViewBand)((DataGridView)dgvBC).CurrentRow).Index];
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			base.CancelDrilldown = true;
			result = null;
			ProjectData.ClearProjectError();
			goto IL_0199;
		}
		if ((int)keycode != 116 || (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false), (object)"", false) ? true : false))
		{
			base.CancelDrilldown = true;
			result = null;
		}
		else
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai).SelectedValue));
			arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoaiPhieu).SelectedValue));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtTu_thang.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNam.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtSo_ky.Value));
			arrayList.Add(((TextBox)txtMa_Nt).Text);
			arrayList.Add(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false)));
			if (Information.IsDBNull((object)arrayList))
			{
				base.CancelDrilldown = true;
				result = null;
			}
			else
			{
				filterCondition4title = dataRowView["ma_vt"].ToString() + ": " + dataRowView["ten_vt"].ToString();
				result = arrayList;
			}
		}
		goto IL_0199;
		IL_0199:
		return result;
	}
}
