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
public class frmGLRptBCTCCR03 : frmReport
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

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

	[AccessedThroughProperty("txtMa_Bp")]
	private AsTextBox _txtMa_Bp;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	[AccessedThroughProperty("cmdPL")]
	private Button _cmdPL;

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

	internal virtual Label lblTen_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Bp = value;
		}
	}

	internal virtual AsTextBox txtMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Bp = value;
		}
	}

	internal virtual Label lblMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Bp = value;
		}
	}

	internal virtual Button cmdPL
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdPL_Click;
			if (_cmdPL != null)
			{
				((Control)_cmdPL).Click -= eventHandler;
			}
			_cmdPL = value;
			if (_cmdPL != null)
			{
				((Control)_cmdPL).Click += eventHandler;
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

	public frmGLRptBCTCCR03(string menuid)
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
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		Label1 = new Label();
		txtNgay02 = new AsMaskedTextBox();
		txtNgay01 = new AsMaskedTextBox();
		cboKyTruoc = new ComboBox();
		lblKy_Truoc = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_Bp = new Label();
		cmdPL = new Button();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(564, 259);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)cmdPL);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)txtNgay02);
		((Control)tabFilter).Controls.Add((Control)(object)txtNgay01);
		((Control)tabFilter).Controls.Add((Control)(object)cboKyTruoc);
		((Control)tabFilter).Controls.Add((Control)(object)lblKy_Truoc);
		TabPage obj = tabFilter;
		size = new Size(556, 230);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdPL, 0);
		Button obj2 = cmdExcel;
		Point location = new Point(700, 194);
		((Control)obj2).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj3 = cmdCancel;
		location = new Point(619, 194);
		((Control)obj3).Location = location;
		Button obj4 = cmdModifyReport;
		location = new Point(455, 24);
		((Control)obj4).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		((Control)cboKyBc).TabIndex = 0;
		((Control)cboMau_bc).TabStop = false;
		Label obj5 = lblMau_bc;
		location = new Point(24, 29);
		((Control)obj5).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 158);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 7;
		Label obj6 = lblMauBC;
		location = new Point(155, 157);
		((Control)obj6).Location = location;
		((Control)lblMauBC).TabIndex = 8;
		RadioButton obj7 = optVND;
		location = new Point(242, 156);
		((Control)obj7).Location = location;
		((Control)optVND).TabIndex = 9;
		RadioButton obj8 = optNt;
		location = new Point(296, 157);
		((Control)obj8).Location = location;
		((Control)optNt).TabIndex = 10;
		Label obj9 = lblMa_nt;
		location = new Point(24, 160);
		((Control)obj9).Location = location;
		Button obj10 = cmdOk;
		location = new Point(27, 194);
		((Control)obj10).Location = location;
		((Control)cmdOk).TabIndex = 11;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj11 = tabGrid;
		size = new Size(556, 230);
		((Control)obj11).Size = size;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(277, 109);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(16, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1020;
		Label1.Text = " - ";
		txtNgay02.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay02).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay02;
		location = new Point(296, 105);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay02).Mask = "##/##/####";
		((Control)txtNgay02).Name = "txtNgay02";
		((MaskedTextBox)txtNgay02).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay02;
		size = new Size(67, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay02).TabIndex = 5;
		((MaskedTextBox)txtNgay02).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay02;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtNgay01.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay01).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay01;
		location = new Point(206, 105);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay01).Mask = "##/##/####";
		((Control)txtNgay01).Name = "txtNgay01";
		((MaskedTextBox)txtNgay01).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay01;
		size = new Size(67, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay01).TabIndex = 4;
		((MaskedTextBox)txtNgay01).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay01;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		cboKyTruoc.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyTruoc).FormattingEnabled = true;
		ComboBox obj12 = cboKyTruoc;
		location = new Point(110, 105);
		((Control)obj12).Location = location;
		((Control)cboKyTruoc).Name = "cboKyTruoc";
		ComboBox obj13 = cboKyTruoc;
		size = new Size(90, 21);
		((Control)obj13).Size = size;
		((Control)cboKyTruoc).TabIndex = 3;
		lblKy_Truoc.AutoSize = true;
		Label obj14 = lblKy_Truoc;
		location = new Point(24, 109);
		((Control)obj14).Location = location;
		((Control)lblKy_Truoc).Name = "lblKy_Truoc";
		Label obj15 = lblKy_Truoc;
		size = new Size(46, 13);
		((Control)obj15).Size = size;
		((Control)lblKy_Truoc).TabIndex = 1019;
		lblKy_Truoc.Text = "Kỳ trước";
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj16 = lblTen_Bp;
		location = new Point(198, 136);
		((Control)obj16).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj17 = lblTen_Bp;
		size = new Size(332, 13);
		((Control)obj17).Size = size;
		((Control)lblTen_Bp).TabIndex = 1043;
		lblTen_Bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_Bp;
		location = new Point(110, 132);
		((Control)asTextBox2).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox3 = txtMa_Bp;
		size = new Size(82, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_Bp).TabIndex = 6;
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_Bp.AutoSize = true;
		lblMa_Bp.ImeMode = (ImeMode)0;
		Label obj18 = lblMa_Bp;
		location = new Point(24, 136);
		((Control)obj18).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj19 = lblMa_Bp;
		size = new Size(64, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_Bp).TabIndex = 1042;
		lblMa_Bp.Text = "Mã bộ phận";
		Button obj20 = cmdPL;
		location = new Point(114, 194);
		((Control)obj20).Location = location;
		((Control)cmdPL).Name = "cmdPL";
		Button obj21 = cmdPL;
		size = new Size(86, 23);
		((Control)obj21).Size = size;
		((Control)cmdPL).TabIndex = 1044;
		((ButtonBase)cmdPL).Text = "KB Công thức";
		((ButtonBase)cmdPL).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(564, 284);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlRptBctc03";
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
		cboKyBc.SelectedIndex = 0;
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
		arrayList.Add(((TextBox)txtMa_Bp).Text);
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
		if (Operators.CompareString(((TextBox)txtMa_Bp).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Bp.Text + ": " + ((TextBox)txtMa_Bp).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
		}
		return text.Substring(0, checked(text.Length - 2));
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

	private void cmdPL_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		frmGLMauPL01 frmGLMauPL2 = new frmGLMauPL01(base.MyMenuID, MyMenuInfo.code_name, MyReportInfo.ma_mau);
		((Form)frmGLMauPL2).ShowDialog();
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
}
