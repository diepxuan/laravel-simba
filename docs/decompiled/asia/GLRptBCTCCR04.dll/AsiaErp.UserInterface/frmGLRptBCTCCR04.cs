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
public class frmGLRptBCTCCR04 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtNgay02")]
	private AsMaskedTextBox _txtNgay02;

	[AccessedThroughProperty("txtNgay01")]
	private AsMaskedTextBox _txtNgay01;

	[AccessedThroughProperty("cboKyTruoc")]
	private ComboBox _cboKyTruoc;

	[AccessedThroughProperty("lblKy_Truoc")]
	private Label _lblKy_Truoc;

	[AccessedThroughProperty("cmdCF")]
	private Button _cmdCF;

	protected virtual Label Label1
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

	protected virtual AsMaskedTextBox txtNgay02
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay02;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay02 = value;
		}
	}

	protected virtual AsMaskedTextBox txtNgay01
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay01;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay01 = value;
		}
	}

	protected virtual ComboBox cboKyTruoc
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboKyTruoc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboKyTruoc_SelectedValueChanged;
			if (_cboKyTruoc != null)
			{
				((ListControl)_cboKyTruoc).SelectedValueChanged -= eventHandler;
			}
			_cboKyTruoc = value;
			if (_cboKyTruoc != null)
			{
				((ListControl)_cboKyTruoc).SelectedValueChanged += eventHandler;
			}
		}
	}

	protected virtual Label lblKy_Truoc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblKy_Truoc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblKy_Truoc = value;
		}
	}

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

	public frmGLRptBCTCCR04(string menuid)
		: base(menuid)
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
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		Label1 = new Label();
		txtNgay02 = new AsMaskedTextBox();
		txtNgay01 = new AsMaskedTextBox();
		cboKyTruoc = new ComboBox();
		lblKy_Truoc = new Label();
		cmdCF = new Button();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(564, 235);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)cmdCF);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)txtNgay02);
		((Control)tabFilter).Controls.Add((Control)(object)txtNgay01);
		((Control)tabFilter).Controls.Add((Control)(object)cboKyTruoc);
		((Control)tabFilter).Controls.Add((Control)(object)lblKy_Truoc);
		TabPage obj = tabFilter;
		size = new Size(556, 206);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKy_Truoc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyTruoc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay01, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay02, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCF, 0);
		Label obj2 = lbl2;
		Point location = new Point(278, 82);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 3;
		Button obj3 = cmdExcel;
		location = new Point(700, 168);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(297, 78);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 168);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(456, 24);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 18;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(207, 78);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(111, 78);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(25, 82);
		((Control)obj7).Location = location;
		((Control)lblKyBc).TabIndex = 0;
		ComboBox obj8 = cboMau_bc;
		location = new Point(111, 25);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 17;
		((Control)cboMau_bc).TabStop = false;
		Label obj9 = lblMau_bc;
		location = new Point(25, 29);
		((Control)obj9).Location = location;
		((Control)lblMau_bc).TabIndex = 16;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(111, 132);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 6;
		Label obj10 = lblMauBC;
		location = new Point(156, 131);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 12;
		RadioButton obj11 = optVND;
		location = new Point(243, 130);
		((Control)obj11).Location = location;
		RadioButton obj12 = optNt;
		location = new Point(297, 131);
		((Control)obj12).Location = location;
		Label obj13 = lblMa_nt;
		location = new Point(25, 134);
		((Control)obj13).Location = location;
		((Control)lblMa_nt).TabIndex = 10;
		Button obj14 = cmdOk;
		location = new Point(28, 168);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 9;
		Label obj15 = lblTieu_de;
		location = new Point(25, 56);
		((Control)obj15).Location = location;
		((Control)lblTieu_de).TabIndex = 19;
		TextBox obj16 = txtTieu_De;
		location = new Point(111, 52);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 20;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj17 = tabGrid;
		size = new Size(556, 206);
		((Control)obj17).Size = size;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(278, 109);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(16, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 8;
		Label1.Text = " - ";
		txtNgay02.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay02).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox3 = txtNgay02;
		location = new Point(297, 105);
		((Control)asMaskedTextBox3).Location = location;
		((MaskedTextBox)txtNgay02).Mask = "##/##/####";
		((Control)txtNgay02).Name = "txtNgay02";
		((MaskedTextBox)txtNgay02).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox4 = txtNgay02;
		size = new Size(67, 20);
		((Control)asMaskedTextBox4).Size = size;
		((Control)txtNgay02).TabIndex = 5;
		((MaskedTextBox)txtNgay02).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox5 = txtNgay02;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox5.Value = dateTime;
		txtNgay01.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay01).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox6 = txtNgay01;
		location = new Point(207, 105);
		((Control)asMaskedTextBox6).Location = location;
		((MaskedTextBox)txtNgay01).Mask = "##/##/####";
		((Control)txtNgay01).Name = "txtNgay01";
		((MaskedTextBox)txtNgay01).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox7 = txtNgay01;
		size = new Size(67, 20);
		((Control)asMaskedTextBox7).Size = size;
		((Control)txtNgay01).TabIndex = 4;
		((MaskedTextBox)txtNgay01).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox8 = txtNgay01;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox8.Value = dateTime;
		cboKyTruoc.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyTruoc).FormattingEnabled = true;
		ComboBox obj18 = cboKyTruoc;
		location = new Point(111, 105);
		((Control)obj18).Location = location;
		((Control)cboKyTruoc).Name = "cboKyTruoc";
		ComboBox obj19 = cboKyTruoc;
		size = new Size(90, 21);
		((Control)obj19).Size = size;
		((Control)cboKyTruoc).TabIndex = 3;
		lblKy_Truoc.AutoSize = true;
		Label obj20 = lblKy_Truoc;
		location = new Point(25, 109);
		((Control)obj20).Location = location;
		((Control)lblKy_Truoc).Name = "lblKy_Truoc";
		Label obj21 = lblKy_Truoc;
		size = new Size(46, 13);
		((Control)obj21).Size = size;
		((Control)lblKy_Truoc).TabIndex = 5;
		lblKy_Truoc.Text = "Kỳ trước";
		Button obj22 = cmdCF;
		location = new Point(115, 168);
		((Control)obj22).Location = location;
		((Control)cmdCF).Name = "cmdCF";
		Button obj23 = cmdCF;
		size = new Size(98, 23);
		((Control)obj23).Size = size;
		((Control)cmdCF).TabIndex = 10;
		((ButtonBase)cmdCF).Text = "KB &Công thức";
		((ButtonBase)cmdCF).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(564, 260);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlRptBctc04";
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
		InitKyBaoCaoTruoc();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(SystemInformations.FinancialYear);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay01.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay02.Value));
		arrayList.Add(base.MyReportInfo.ma_mau);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		if (base.MyFomularFields.Contains("strFilterTitle"))
		{
			base.MyFomularFields["strFilterTitle"] = GetFilterCondiction();
		}
		else
		{
			base.MyFomularFields.Add("strFilterTitle", GetFilterCondiction());
		}
		base.MyFomularFields["strQuy"] = cboKyBc.Text;
		return true;
	}

	private string GetFilterCondiction()
	{
		string text = "";
		if ((Operators.ConditionalCompareObjectNotEqual(txtNgay1.Value, (object)"#1/1/1900#", false) && Operators.ConditionalCompareObjectNotEqual(txtNgay2.Value, (object)"#1/1/1900#", false)) ? true : false)
		{
			text = text + lblKyBc.Text + ": " + ((MaskedTextBox)txtNgay1).Text + lbl2.Text + ((MaskedTextBox)txtNgay2).Text + "; ";
		}
		if ((Operators.ConditionalCompareObjectNotEqual(txtNgay01.Value, (object)"#1/1/1900#", false) && Operators.ConditionalCompareObjectNotEqual(txtNgay02.Value, (object)"#1/1/1900#", false)) ? true : false)
		{
			text = text + lblKy_Truoc.Text + ": " + ((MaskedTextBox)txtNgay01).Text + lbl2.Text + ((MaskedTextBox)txtNgay02).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
		}
		return text.Substring(0, checked(text.Length - 2));
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		ArrayList result;
		if ((int)keycode != 116 || (((int)modifierKeys != 0) ? true : false))
		{
			base.CancelDrilldown = true;
			result = null;
		}
		else
		{
			DataRowView dataRowView;
			try
			{
				dataRowView = new DataView((DataTable)((DataGridView)base.dgvBC).DataSource)[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				base.CancelDrilldown = true;
				result = null;
				ProjectData.ClearProjectError();
				goto IL_03d5;
			}
			if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["cach_tinh"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_no"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_co"]), isNum: false), (object)"", false)) ? true : false)
			{
				base.CancelDrilldown = true;
				result = null;
			}
			else if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["cach_tinh"]), isNum: false), (object)"", false))
			{
				sDrilldownMenuId = drilldownInfo.drilldown_menuid;
				string rowFilter = "ma_so in('" + dataRowView["cach_tinh"].ToString().Trim().Replace(" ", "")
					.Replace("+", "','")
					.Replace("-", "','") + "')";
				DataView dataView = new DataView(get_MyDGVSource(isSet2Print: true), rowFilter, "", DataViewRowState.CurrentRows);
				filterCondition4title = dataRowView["ma_so"].ToString() + " = " + dataRowView["cach_tinh"].ToString();
				datasource = dataView;
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(datasource)))
				{
					base.CancelDrilldown = true;
				}
				if (!base.MyFomularFields.Contains("ngay_ct1"))
				{
					base.MyFomularFields.Add("ngay_ct1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
				}
				if (!base.MyFomularFields.Contains("ngay_ct2"))
				{
					base.MyFomularFields.Add("ngay_ct2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
				}
				result = null;
			}
			else if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_no"]), isNum: false), (object)"", false) || (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk_co"]), isNum: false), (object)"", false) ? true : false))
			{
				sDrilldownMenuId = drilldownInfo.drilldown_menuid1;
				ArrayList arrayList = new ArrayList();
				arrayList.Add(CompanyInformations.CompanyID);
				arrayList.Add(dataRowView["tk_no"].ToString());
				arrayList.Add(dataRowView["tk_co"].ToString());
				arrayList.Add(null);
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
				arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
				filterCondition4title = dataRowView["chi_tieu"].ToString();
				if (!base.MyFomularFields.Contains("ngay_ct1"))
				{
					base.MyFomularFields.Add("ngay_ct1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
				}
				if (!base.MyFomularFields.Contains("ngay_ct2"))
				{
					base.MyFomularFields.Add("ngay_ct2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
				}
				result = arrayList;
			}
			else
			{
				base.CancelDrilldown = true;
				result = null;
			}
		}
		goto IL_03d5;
		IL_03d5:
		return result;
	}

	private void InitKyBaoCaoTruoc()
	{
		cboKyTruoc.DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc);
		((ListControl)cboKyTruoc).ValueMember = "ma";
		((ListControl)cboKyTruoc).DisplayMember = "ten_ky";
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"", false))
		{
			((ListControl)cboKyTruoc).SelectedValue = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao"));
		}
		else
		{
			cboKyTruoc.SelectedIndex = 0;
		}
	}

	private void cboKyTruoc_SelectedValueChanged(object sender, EventArgs e)
	{
		checked
		{
			if (cboKyTruoc.DataSource != null)
			{
				if (Operators.CompareString(((KyBaoCao)cboKyTruoc.SelectedItem).ma, "NGAY", false) != 0)
				{
					AsMaskedTextBox asMaskedTextBox = txtNgay01;
					DateTime dateTime = new DateTime(SystemInformations.FinancialYear - 1, ((KyBaoCao)cboKyTruoc.SelectedItem).thang1, 1);
					asMaskedTextBox.Value = dateTime;
					AsMaskedTextBox asMaskedTextBox2 = txtNgay02;
					dateTime = new DateTime(SystemInformations.FinancialYear - 1, ((KyBaoCao)cboKyTruoc.SelectedItem).thang2, 1);
					DateTime dateTime2 = dateTime;
					asMaskedTextBox2.Value = dateTime2.AddMonths(1).AddDays(-1.0);
					((MaskedTextBox)txtNgay01).ReadOnly = true;
					((Control)txtNgay01).TabStop = false;
					((MaskedTextBox)txtNgay02).ReadOnly = true;
					((Control)txtNgay02).TabStop = false;
				}
				else
				{
					((MaskedTextBox)txtNgay01).ReadOnly = false;
					((Control)txtNgay01).TabStop = true;
					((MaskedTextBox)txtNgay02).ReadOnly = false;
					((Control)txtNgay02).TabStop = true;
				}
			}
		}
	}

	private void cmdCF_Click(object sender, EventArgs e)
	{
		frmGLMauCF01 frmGLMauCF2 = new frmGLMauCF01(base.MyMenuID, MyMenuInfo.code_name, MyReportInfo.ma_mau);
		((Form)frmGLMauCF2).Show((IWin32Window)(object)this);
	}
}
