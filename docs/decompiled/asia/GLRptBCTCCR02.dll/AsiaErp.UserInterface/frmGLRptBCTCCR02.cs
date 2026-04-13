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
using AsiaErp.UserInterface.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLRptBCTCCR02 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdBS")]
	private Button _cmdBS;

	[AccessedThroughProperty("chkChiTieuCoSoLieu")]
	private CheckBox _chkChiTieuCoSoLieu;

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

	internal virtual Button cmdBS
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdBS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdBS_Click;
			if (_cmdBS != null)
			{
				((Control)_cmdBS).Click -= eventHandler;
			}
			_cmdBS = value;
			if (_cmdBS != null)
			{
				((Control)_cmdBS).Click += eventHandler;
			}
		}
	}

	internal virtual CheckBox chkChiTieuCoSoLieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkChiTieuCoSoLieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkChiTieuCoSoLieu = value;
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

	public frmGLRptBCTCCR02(string menuid)
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		cmdBS = new Button();
		chkChiTieuCoSoLieu = new CheckBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(562, 218);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)cmdBS);
		((Control)tabFilter).Controls.Add((Control)(object)chkChiTieuCoSoLieu);
		TabPage obj = tabFilter;
		size = new Size(554, 189);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)chkChiTieuCoSoLieu, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdBS, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)lbl2).Enabled = false;
		Label obj2 = lbl2;
		Point location = new Point(506, 162);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(700, -89);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(110, 78);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, -89);
		((Control)obj4).Location = location;
		((Control)cmdModifyReport).TabIndex = 5;
		((Control)txtNgay1).Enabled = false;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(426, 82);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).Visible = false;
		((Control)cboKyBc).Enabled = false;
		ComboBox obj5 = cboKyBc;
		location = new Point(275, 79);
		((Control)obj5).Location = location;
		((Control)cboKyBc).Visible = false;
		((Control)lblKyBc).TabIndex = 0;
		ComboBox obj6 = cboMau_bc;
		location = new Point(110, 24);
		((Control)obj6).Location = location;
		((Control)lblMau_bc).TabIndex = 3;
		((Control)txtMa_Nt).Enabled = false;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(483, 139);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).Visible = false;
		((Control)lblMauBC).Enabled = false;
		Label obj7 = lblMauBC;
		location = new Point(528, 138);
		((Control)obj7).Location = location;
		((Control)lblMauBC).Visible = false;
		((Control)optVND).Enabled = false;
		RadioButton obj8 = optVND;
		location = new Point(615, 114);
		((Control)obj8).Location = location;
		((Control)optVND).Visible = false;
		((Control)optNt).Enabled = false;
		RadioButton obj9 = optNt;
		location = new Point(669, 115);
		((Control)obj9).Location = location;
		((Control)optNt).Visible = false;
		((Control)lblMa_nt).Enabled = false;
		Label obj10 = lblMa_nt;
		location = new Point(397, 141);
		((Control)obj10).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj11 = cmdOk;
		location = new Point(25, 155);
		((Control)obj11).Location = location;
		((Control)cmdOk).TabIndex = 4;
		((Control)lblTieu_de).TabIndex = 6;
		TabPage obj12 = tabGrid;
		size = new Size(554, 189);
		((Control)obj12).Size = size;
		Button obj13 = cmdBS;
		location = new Point(112, 155);
		((Control)obj13).Location = location;
		((Control)cmdBS).Name = "cmdBS";
		Button obj14 = cmdBS;
		size = new Size(85, 23);
		((Control)obj14).Size = size;
		((Control)cmdBS).TabIndex = 5;
		((ButtonBase)cmdBS).Text = "KB &Công thức";
		((ButtonBase)cmdBS).UseVisualStyleBackColor = true;
		((ButtonBase)chkChiTieuCoSoLieu).AutoSize = true;
		CheckBox obj15 = chkChiTieuCoSoLieu;
		location = new Point(110, 115);
		((Control)obj15).Location = location;
		((Control)chkChiTieuCoSoLieu).Name = "chkChiTieuCoSoLieu";
		CheckBox obj16 = chkChiTieuCoSoLieu;
		size = new Size(185, 17);
		((Control)obj16).Size = size;
		((Control)chkChiTieuCoSoLieu).TabIndex = 3;
		((ButtonBase)chkChiTieuCoSoLieu).Text = "Chỉ lên cho các chỉ tiêu có số liệu";
		((ButtonBase)chkChiTieuCoSoLieu).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(562, 243);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlRptBctc02";
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
		((MaskedTextBox)txtNgay2).ReadOnly = false;
		((Control)txtNgay2).TabStop = true;
		txtNgay2.Value = DateAndTime.Now.Date;
	}

	private void AsTabControl_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((TabControl)AsTabControl).SelectedTab == tabGrid)
		{
			((Form)this).Text = base.MyMenuInfo.bar.Trim() + ". F5 - Chi tiet cong thuc/So chu T, Ctrl+F5 - So chi tiet, Shift+F5 - Can doi PS cong no,  F7 - Xem, F9 - In";
		}
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(SystemInformations.FinancialYear);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(chkChiTieuCoSoLieu.Checked);
		arrayList.Add(base.MyReportInfo.ma_mau);
		DataTable data = base.MyController.GetData(arrayList.ToArray());
		set_MyDGVSource(isSet2Print: true, data);
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strSubTitle", MySettingsProperty.Settings.strLapTaiNgay + ": " + ((MaskedTextBox)txtNgay2).Text);
		base.Parameters4DrillDown.Clear();
		base.Parameters4DrillDown.Add("ngay_ct1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		base.Parameters4DrillDown.Add("ngay_ct2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		base.Parameters4DrillDown.Add("ma_nt", ((TextBox)txtMa_Nt).Text);
		return true;
	}

	private void cmdBS_Click(object sender, EventArgs e)
	{
		frmGLMauBS01 frmGLMauBS2 = new frmGLMauBS01(base.MyMenuID, MyMenuInfo.code_name, MyReportInfo.ma_mau);
		((Form)frmGLMauBS2).Show((IWin32Window)(object)this);
	}

	protected override ArrayList CreateDrilldownArgument(ReportDrillDownInfo drilldownInfo, ref string sDrilldownMenuId, Keys keycode, Keys modifierKeys, ref string filterCondition4title, [Optional][DefaultParameterValue(null)] ref object datasource)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Invalid comparison between Unknown and I4
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Invalid comparison between Unknown and I4
		if ((int)keycode != 116)
		{
			base.CancelDrilldown = true;
			return null;
		}
		DataRowView dataRowView = get_MyDGVSource(isSet2Print: true).DefaultView[((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index];
		ArrayList arrayList = new ArrayList();
		if ((int)modifierKeys == 0)
		{
			if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["cach_tinh"]), isNum: false), (object)"", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk"]), isNum: false), (object)"", false)) ? true : false)
			{
				base.CancelDrilldown = true;
				return null;
			}
			if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["cach_tinh"]), isNum: false), (object)"", false))
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
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["tk"]), isNum: false), (object)"", false) || (Operators.ConditionalCompareObjectNotEqual(dataRowView["cong_no"], (object)"1", false) ? true : false))
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
