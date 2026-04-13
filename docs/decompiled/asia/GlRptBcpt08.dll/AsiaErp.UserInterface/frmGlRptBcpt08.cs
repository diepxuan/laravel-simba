using System;
using System.Collections;
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
public class frmGlRptBcpt08 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("cmdPL")]
	private Button _cmdPL;

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

	public frmGlRptBcpt08(string menuid)
		: base(menuid)
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
		cmdPL = new Button();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(564, 205);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)cmdPL);
		TabPage obj = tabFilter;
		size = new Size(556, 176);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdPL, 0);
		Button obj2 = cmdExcel;
		Point location = new Point(700, 142);
		((Control)obj2).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj3 = cmdCancel;
		location = new Point(619, 142);
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
		location = new Point(110, 105);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 7;
		Label obj6 = lblMauBC;
		location = new Point(155, 104);
		((Control)obj6).Location = location;
		((Control)lblMauBC).TabIndex = 8;
		RadioButton obj7 = optVND;
		location = new Point(242, 103);
		((Control)obj7).Location = location;
		((Control)optVND).TabIndex = 9;
		RadioButton obj8 = optNt;
		location = new Point(296, 104);
		((Control)obj8).Location = location;
		((Control)optNt).TabIndex = 10;
		Label obj9 = lblMa_nt;
		location = new Point(24, 107);
		((Control)obj9).Location = location;
		Button obj10 = cmdOk;
		location = new Point(23, 142);
		((Control)obj10).Location = location;
		((Control)cmdOk).TabIndex = 11;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj11 = tabGrid;
		size = new Size(556, 176);
		((Control)obj11).Size = size;
		Button obj12 = cmdPL;
		location = new Point(110, 142);
		((Control)obj12).Location = location;
		((Control)cmdPL).Name = "cmdPL";
		Button obj13 = cmdPL;
		size = new Size(90, 23);
		((Control)obj13).Size = size;
		((Control)cmdPL).TabIndex = 1044;
		((ButtonBase)cmdPL).Text = "KB Công thức";
		((ButtonBase)cmdPL).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(564, 230);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlRptBcpt08";
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
		cboKyBc.SelectedIndex = 0;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
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
		return true;
	}

	private string GetFilterCondiction()
	{
		string text = "";
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
		}
		if (text.Length >= 2)
		{
			return text.Substring(0, checked(text.Length - 2));
		}
		return text;
	}

	private void cmdPL_Click(object sender, EventArgs e)
	{
		frmGLMauPL01 frmGLMauPL2 = new frmGLMauPL01(base.MyMenuID, MyMenuInfo.code_name, MyReportInfo.ma_mau);
		((Form)frmGLMauPL2).Show((IWin32Window)(object)this);
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Invalid comparison between Unknown and I4
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Invalid comparison between Unknown and I4
		if ((int)keycode != 116)
		{
			base.CancelDrilldown = true;
			return null;
		}
		DataRowView dataRowView = get_MyDGVSource(isSet2Print: true).DefaultView[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
		ArrayList arrayList = new ArrayList();
		if ((int)modifierKeys == 0)
		{
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["cach_tinh"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk"]), isNum: false), (object)"", false))
			{
				base.CancelDrilldown = true;
				return null;
			}
			if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["cach_tinh"]), isNum: false), (object)"", false))
			{
				sDrilldownMenuId = drilldownInfo.drilldown_menuid;
				string rowFilter = "ma_so in('" + dataRowView["cach_tinh"].ToString().Trim().Replace(" ", "")
					.Replace("/", "','")
					.Replace("-", "','") + "')";
				DataView dataView = new DataView(get_MyDGVSource(isSet2Print: true), rowFilter, "", DataViewRowState.CurrentRows);
				filterCondition4title = dataRowView["ma_so"].ToString() + " = " + dataRowView["cach_tinh"].ToString();
				datasource = dataView;
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(datasource)))
				{
					base.CancelDrilldown = true;
				}
				return null;
			}
			if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk"]), isNum: false), (object)"", false))
			{
				sDrilldownMenuId = drilldownInfo.drilldown_menuid1;
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
		}
		else if ((int)modifierKeys == 131072)
		{
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk"]), isNum: false), (object)"", false))
			{
				base.CancelDrilldown = true;
				return null;
			}
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
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk"]), isNum: false), (object)"", false) || Operators.ConditionalCompareObjectNotEqual(dataRowView["cong_no"], (object)"1", false))
			{
				base.CancelDrilldown = true;
				return null;
			}
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(dataRowView["tk"].ToString());
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
			arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
			filterCondition4title = dataRowView["tk"].ToString();
		}
		return arrayList;
	}
}
