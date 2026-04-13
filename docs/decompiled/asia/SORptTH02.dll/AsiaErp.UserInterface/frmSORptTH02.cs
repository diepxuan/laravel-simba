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
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSORptTH02 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtSo_Ky")]
	private AsTextNumeric _txtSo_Ky;

	[AccessedThroughProperty("txtTu_Thang")]
	private AsTextNumeric _txtTu_Thang;

	[AccessedThroughProperty("lblLoai_CT")]
	private Label _lblLoai_CT;

	[AccessedThroughProperty("lblLoai")]
	private Label _lblLoai;

	[AccessedThroughProperty("cboLoai_CT")]
	private ComboBox _cboLoai_CT;

	[AccessedThroughProperty("cboLoai")]
	private ComboBox _cboLoai;

	[AccessedThroughProperty("lblTu_Thang")]
	private Label _lblTu_Thang;

	[AccessedThroughProperty("lblSo_Ky")]
	private Label _lblSo_Ky;

	[AccessedThroughProperty("lblNam")]
	private Label _lblNam;

	[AccessedThroughProperty("txtNam")]
	private AsTextNumeric _txtNam;

	[AccessedThroughProperty("crvReportViewer")]
	private CrystalReportViewer _crvReportViewer;

	private const string THANG = "THANG";

	private const string QUY = "QUY";

	private const string NAM = "NAM";

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

	internal virtual AsTextNumeric txtSo_Ky
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_Ky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_Ky = value;
		}
	}

	internal virtual AsTextNumeric txtTu_Thang
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTu_Thang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTu_Thang = value;
		}
	}

	internal virtual Label lblLoai_CT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai_CT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai_CT = value;
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

	internal virtual ComboBox cboLoai_CT
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_CT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_CT = value;
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

	internal virtual Label lblTu_Thang
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTu_Thang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTu_Thang = value;
		}
	}

	internal virtual Label lblSo_Ky
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_Ky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_Ky = value;
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

	private virtual CrystalReportViewer crvReportViewer
	{
		[DebuggerNonUserCode]
		get
		{
			return _crvReportViewer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_crvReportViewer = value;
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

	public frmSORptTH02(string MenuId)
		: base(MenuId)
	{
		__ENCAddToList(this);
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
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db9: Expected O, but got Unknown
		crvReportViewer = new CrystalReportViewer();
		cboLoai = new ComboBox();
		cboLoai_CT = new ComboBox();
		lblLoai = new Label();
		lblLoai_CT = new Label();
		txtTu_Thang = new AsTextNumeric();
		txtSo_Ky = new AsTextNumeric();
		lblSo_Ky = new Label();
		lblTu_Thang = new Label();
		txtNam = new AsTextNumeric();
		lblNam = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(591, 321);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)lblNam);
		((Control)tabFilter).Controls.Add((Control)(object)txtNam);
		((Control)tabFilter).Controls.Add((Control)(object)lblTu_Thang);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ky);
		((Control)tabFilter).Controls.Add((Control)(object)txtSo_Ky);
		((Control)tabFilter).Controls.Add((Control)(object)txtTu_Thang);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoai_CT);
		((Control)tabFilter).Controls.Add((Control)(object)lblLoai);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai_CT);
		((Control)tabFilter).Controls.Add((Control)(object)cboLoai);
		TabPage obj = tabFilter;
		size = new Size(583, 292);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboLoai_CT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoai, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblLoai_CT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTu_Thang, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtSo_Ky, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ky, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTu_Thang, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNam, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblNam, 0);
		((Control)lbl2).Anchor = (AnchorStyles)10;
		Label obj2 = lbl2;
		Point location = new Point(-511, 343);
		((Control)obj2).Location = location;
		((Control)cmdExcel).Anchor = (AnchorStyles)10;
		Button obj3 = cmdExcel;
		location = new Point(-329, 353);
		((Control)obj3).Location = location;
		((Control)txtNgay2).Anchor = (AnchorStyles)10;
		((Control)txtNgay2).Enabled = false;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(-168, 339);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).Visible = false;
		((Control)cmdCancel).Anchor = (AnchorStyles)10;
		Button obj4 = cmdCancel;
		location = new Point(-86, 353);
		((Control)obj4).Location = location;
		((Control)cmdModifyReport).TabIndex = 1;
		((Control)txtNgay1).Anchor = (AnchorStyles)10;
		((Control)txtNgay1).Enabled = false;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(212, 273);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).Visible = false;
		((Control)cboKyBc).Anchor = (AnchorStyles)10;
		((Control)cboKyBc).Enabled = false;
		ComboBox obj5 = cboKyBc;
		location = new Point(116, 273);
		((Control)obj5).Location = location;
		((Control)cboKyBc).Visible = false;
		((Control)lblKyBc).Enabled = false;
		Label obj6 = lblKyBc;
		location = new Point(155, 257);
		((Control)obj6).Location = location;
		((Control)lblKyBc).Visible = false;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 185);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 8;
		Label obj7 = lblMauBC;
		location = new Point(179, 184);
		((Control)obj7).Location = location;
		RadioButton obj8 = optVND;
		location = new Point(266, 183);
		((Control)obj8).Location = location;
		((Control)optVND).TabIndex = 9;
		RadioButton obj9 = optNt;
		location = new Point(320, 184);
		((Control)obj9).Location = location;
		((Control)optNt).TabIndex = 9;
		Label obj10 = lblMa_nt;
		location = new Point(24, 187);
		((Control)obj10).Location = location;
		Button obj11 = cmdOk;
		location = new Point(27, 232);
		((Control)obj11).Location = location;
		((Control)cmdOk).TabIndex = 10;
		((Control)txtTieu_De).TabIndex = 2;
		TabPage obj12 = tabGrid;
		size = new Size(583, 292);
		((Control)obj12).Size = size;
		crvReportViewer.ActiveViewIndex = -1;
		((UserControl)crvReportViewer).BorderStyle = (BorderStyle)1;
		crvReportViewer.DisplayGroupTree = false;
		((Control)crvReportViewer).Dock = (DockStyle)5;
		CrystalReportViewer obj13 = crvReportViewer;
		location = new Point(0, 0);
		((Control)obj13).Location = location;
		((Control)crvReportViewer).Name = "crvReportViewer";
		crvReportViewer.SelectionFormula = "";
		crvReportViewer.ShowRefreshButton = false;
		CrystalReportViewer obj14 = crvReportViewer;
		size = new Size(583, 292);
		((Control)obj14).Size = size;
		((Control)crvReportViewer).TabIndex = 0;
		crvReportViewer.ViewTimeSelectionFormula = "";
		((Control)cboLoai).AllowDrop = true;
		cboLoai.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai).FormattingEnabled = true;
		cboLoai.Items.AddRange(new object[3] { "Theo tháng", "Theo Quý", "Theo Năm" });
		ComboBox obj15 = cboLoai;
		location = new Point(110, 77);
		((Control)obj15).Location = location;
		((Control)cboLoai).Name = "cboLoai";
		ComboBox obj16 = cboLoai;
		size = new Size(126, 21);
		((Control)obj16).Size = size;
		((Control)cboLoai).TabIndex = 3;
		cboLoai_CT.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_CT).FormattingEnabled = true;
		ComboBox obj17 = cboLoai_CT;
		location = new Point(110, 103);
		((Control)obj17).Location = location;
		((Control)cboLoai_CT).Name = "cboLoai_CT";
		ComboBox obj18 = cboLoai_CT;
		size = new Size(126, 21);
		((Control)obj18).Size = size;
		((Control)cboLoai_CT).TabIndex = 4;
		lblLoai.AutoSize = true;
		Label obj19 = lblLoai;
		location = new Point(24, 81);
		((Control)obj19).Location = location;
		((Control)lblLoai).Name = "lblLoai";
		Label obj20 = lblLoai;
		size = new Size(27, 13);
		((Control)obj20).Size = size;
		((Control)lblLoai).TabIndex = 1018;
		lblLoai.Text = "Loại";
		lblLoai_CT.AutoSize = true;
		Label obj21 = lblLoai_CT;
		location = new Point(24, 107);
		((Control)obj21).Location = location;
		((Control)lblLoai_CT).Name = "lblLoai_CT";
		Label obj22 = lblLoai_CT;
		size = new Size(72, 13);
		((Control)obj22).Size = size;
		((Control)lblLoai_CT).TabIndex = 1019;
		lblLoai_CT.Text = "Loại chứng từ";
		txtTu_Thang.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtTu_Thang;
		location = new Point(110, 132);
		((Control)asTextNumeric).Location = location;
		txtTu_Thang.Mask = "##";
		((TextBoxBase)txtTu_Thang).MaxLength = 2;
		((Control)txtTu_Thang).Name = "txtTu_Thang";
		AsTextNumeric asTextNumeric2 = txtTu_Thang;
		size = new Size(39, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTu_Thang).TabIndex = 5;
		((TextBox)txtTu_Thang).Text = "0";
		((TextBox)txtTu_Thang).TextAlign = (HorizontalAlignment)1;
		txtTu_Thang.Value = 0.0;
		txtSo_Ky.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric3 = txtSo_Ky;
		location = new Point(110, 159);
		((Control)asTextNumeric3).Location = location;
		txtSo_Ky.Mask = "##";
		((TextBoxBase)txtSo_Ky).MaxLength = 2;
		((Control)txtSo_Ky).Name = "txtSo_Ky";
		AsTextNumeric asTextNumeric4 = txtSo_Ky;
		size = new Size(39, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtSo_Ky).TabIndex = 7;
		((TextBox)txtSo_Ky).Text = "0";
		((TextBox)txtSo_Ky).TextAlign = (HorizontalAlignment)1;
		txtSo_Ky.Value = 0.0;
		lblSo_Ky.AutoSize = true;
		Label obj23 = lblSo_Ky;
		location = new Point(24, 163);
		((Control)obj23).Location = location;
		((Control)lblSo_Ky).Name = "lblSo_Ky";
		Label obj24 = lblSo_Ky;
		size = new Size(34, 13);
		((Control)obj24).Size = size;
		((Control)lblSo_Ky).TabIndex = 1022;
		lblSo_Ky.Text = "Số kỳ";
		lblTu_Thang.AutoSize = true;
		Label obj25 = lblTu_Thang;
		location = new Point(24, 136);
		((Control)obj25).Location = location;
		((Control)lblTu_Thang).Name = "lblTu_Thang";
		Label obj26 = lblTu_Thang;
		size = new Size(50, 13);
		((Control)obj26).Size = size;
		((Control)lblTu_Thang).TabIndex = 1023;
		lblTu_Thang.Text = "Từ tháng";
		txtNam.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric5 = txtNam;
		location = new Point(193, 132);
		((Control)asTextNumeric5).Location = location;
		txtNam.Mask = "####";
		((TextBoxBase)txtNam).MaxLength = 4;
		((Control)txtNam).Name = "txtNam";
		AsTextNumeric asTextNumeric6 = txtNam;
		size = new Size(43, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtNam).TabIndex = 6;
		((TextBox)txtNam).Text = "0";
		((TextBox)txtNam).TextAlign = (HorizontalAlignment)1;
		txtNam.Value = 0.0;
		lblNam.AutoSize = true;
		Label obj27 = lblNam;
		location = new Point(158, 136);
		((Control)obj27).Location = location;
		((Control)lblNam).Name = "lblNam";
		Label obj28 = lblNam;
		size = new Size(29, 13);
		((Control)obj28).Size = size;
		((Control)lblNam).TabIndex = 1025;
		lblNam.Text = "Năm";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(591, 346);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmSORptTH02";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cboMau_bc_SelectedIndexChanged(object sender, EventArgs e)
	{
		((ListControl)cboLoai_CT).SelectedValue = base.MyReportInfo.par0;
	}

	protected override void InitOtherComponents()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		base.InitOtherComponents();
		((Control)cboLoai).Select();
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
		cboLoai_CT.DataSource = arrayList2;
		((ListControl)cboLoai_CT).DisplayMember = "TEN_CT";
		((ListControl)cboLoai_CT).ValueMember = "MA_CT";
		((ListControl)cboLoai_CT).SelectedValue = base.MyReportInfo.par0;
		txtNam.Value = SystemInformations.FinancialYear;
		txtTu_Thang.Value = 1;
		txtSo_Ky.Value = 1;
	}

	protected override bool ValidData()
	{
		if (Operators.ConditionalCompareObjectLess(txtTu_Thang.Value, (object)1, false))
		{
			SetControlError((Control)(object)txtTu_Thang, Helper.GetMessContent(50034));
			return false;
		}
		DateTime now = DateTime.Now;
		if (Operators.ConditionalCompareObjectLess(txtNam.Value, (object)1900, false))
		{
			SetControlError((Control)(object)txtNam, Helper.GetMessContent(50034));
			return false;
		}
		if (Operators.ConditionalCompareObjectLess(txtSo_Ky.Value, (object)1, false))
		{
			SetControlError((Control)(object)txtSo_Ky, Helper.GetMessContent(50034));
			return false;
		}
		return true;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtTu_Thang.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNam.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtSo_Ky.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai).SelectedValue));
		arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_CT).SelectedValue));
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		arrayList.Add(optNt.Checked);
		set_MyDGVSource(isSet2Print: false, base.MyController.GetDataSet(arrayList.ToArray()).Tables[1]);
		base.MyCrystalSource = base.MyController.GetDataSet(arrayList.ToArray()).Tables[0];
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string empty = string.Empty;
		empty = empty + lblLoai.Text + ": " + cboLoai.Text + ": ";
		empty = empty + lblLoai_CT.Text + ": " + cboLoai_CT.Text + ";";
		empty = empty + lblTu_Thang.Text + ": " + ((TextBox)txtTu_Thang).Text + ";";
		empty = empty + lblNam.Text + ": " + ((TextBox)txtNam).Text + ";";
		return empty + lblSo_Ky.Text + ": " + ((TextBox)txtSo_Ky).Text;
	}

	private bool ValidateSoKy()
	{
		bool flag = false;
		object selectedValue = ((ListControl)cboLoai).SelectedValue;
		if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"THANG", false))
		{
			flag = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(txtSo_Ky.Value, (object)1, false), Operators.CompareObjectLessEqual(txtSo_Ky.Value, (object)12, false)));
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"QUY", false))
		{
			flag = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(txtSo_Ky.Value, (object)1, false), Operators.CompareObjectLessEqual(txtSo_Ky.Value, (object)4, false)));
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"NAM", false))
		{
			flag = Operators.ConditionalCompareObjectEqual(txtSo_Ky.Value, (object)1, false);
		}
		if (!flag)
		{
			SetControlError((Control)(object)txtSo_Ky, Helper.GetMessContent(50034));
		}
		return flag;
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
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtTu_Thang.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNam.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtSo_Ky.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai).SelectedValue));
			arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai_CT).SelectedValue));
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
