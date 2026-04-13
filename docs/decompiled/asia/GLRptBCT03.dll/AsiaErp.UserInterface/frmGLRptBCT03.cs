using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLRptBCT03 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	private bool bLoading;

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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	public frmGLRptBCT03(string MenuId)
		: base(MenuId)
	{
		__ENCAddToList(this);
		bLoading = true;
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(648, 286);
		((Control)asTabControl).Size = size;
		TabPage obj = tabFilter;
		size = new Size(640, 257);
		((Control)obj).Size = size;
		Label obj2 = lbl2;
		Point location = new Point(276, 81);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 1509);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(295, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 1509);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(454, 23);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 25;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(205, 77);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(109, 77);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new Point(23, 81);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new Point(109, 24);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 24;
		((Control)cboMau_bc).TabStop = false;
		Label obj9 = lblMau_bc;
		location = new Point(23, 28);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(110, 495);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 20;
		((Control)txtMa_Nt).Visible = false;
		Label obj10 = lblMauBC;
		location = new Point(155, 494);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 21;
		((Control)lblMauBC).Visible = false;
		RadioButton obj11 = optVND;
		location = new Point(242, 493);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 22;
		((Control)optVND).Visible = false;
		RadioButton obj12 = optNt;
		location = new Point(296, 492);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 23;
		((Control)optNt).Visible = false;
		Label obj13 = lblMa_nt;
		location = new Point(24, 497);
		((Control)obj13).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj14 = cmdOk;
		location = new Point(26, 114);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 3;
		Label obj15 = lblTieu_de;
		location = new Point(23, 55);
		((Control)obj15).Location = location;
		TextBox obj16 = txtTieu_De;
		location = new Point(109, 51);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 26;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj17 = tabGrid;
		size = new Size(640, 257);
		((Control)obj17).Size = size;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(648, 311);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmGLRptBCT03";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		base.InitOtherComponents();
		((DataGridView)dgvBC).CellEnter += new DataGridViewCellEventHandler(dgvBC_CellEnter);
		((DataGridView)dgvBC).CellEndEdit += new DataGridViewCellEventHandler(dgvBC_CellEndEdit);
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		return true;
	}

	protected override void Execute()
	{
		base.Execute();
		bLoading = false;
	}

	protected override void FormatGridView()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		base.FormatGridView();
		((DataGridView)dgvBC).EditMode = (DataGridViewEditMode)0;
		dgvBC.ReadOnly = false;
		foreach (DataGridViewColumn item in (BaseCollection)((DataGridView)dgvBC).Columns)
		{
			DataGridViewColumn val = item;
			val.ReadOnly = true;
		}
	}

	private void dgvBC_CellEnter(object sender, EventArgs e)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		if (!get_MyDGVSource(isSet2Print: true).Columns.Contains("ma_so2"))
		{
			return;
		}
		try
		{
			DataGridViewColumn val = ((DataGridView)dgvBC).Columns[((DataGridView)dgvBC).CurrentCell.ColumnIndex];
			DataGridViewTextBoxCell val2 = (DataGridViewTextBoxCell)((DataGridView)dgvBC).CurrentCell;
			if ((Operators.CompareString(val.Name, "thue", false) == 0 && Operators.ConditionalCompareObjectEqual(((DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvBC).DataSource)].Current)["usertype"], (object)true, false)) ? true : false)
			{
				((DataGridViewAsTextNumericColumn)(object)val).Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
				val.ReadOnly = false;
			}
			else
			{
				val.ReadOnly = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void dgvBC_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if (bLoading)
		{
			return;
		}
		try
		{
			DataGridViewColumn val = ((DataGridView)dgvBC).Columns[((DataGridView)dgvBC).CurrentCell.ColumnIndex];
			DataRowView dataRowView = (DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvBC).DataSource)].Current;
			string text = dataRowView["ma_so2"].ToString().Replace("[", "").Replace("]", "");
			DataRow[] array = get_MyDGVSource(isSet2Print: true).Select("cong_thuc LIKE '%[[]" + text + "[]]%' AND cong_thuc <> ''", "stt_rec");
			ArrayList arrayList = new ArrayList();
			GLRptBCT03DAO gLRptBCT03DAO = (GLRptBCT03DAO)DAOFactory.CreateDAOInstance("GLRptBCT03DAO", "GLRptBCT03");
			int num = 0;
			DataRow[] array2 = array;
			foreach (DataRow oDr in array2)
			{
				MyCalc(oDr);
				arrayList.Clear();
				arrayList.Add(CompanyInformations.CompanyID);
				arrayList.Add(DateAndTime.Month(Conversions.ToDate(txtNgay1.Value)));
				arrayList.Add(DateAndTime.Month(Conversions.ToDate(txtNgay2.Value)));
				arrayList.Add(SystemInformations.FinancialYear);
				arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["stt_rec"]));
				arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["doanh_so"]));
				arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["thue"]));
				num = gLRptBCT03DAO.DieuChinhBCT03(arrayList.ToArray());
				gLRptBCT03DAO.Destroy();
				if (num != 0)
				{
					CMessageBox.Show(num);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void MyCalc(DataRow oDr)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		string text = oDr["cong_thuc"].ToString().Replace(" ", "");
		string strChitieu = "";
		double dSum = 0.0;
		if (text.Contains(">"))
		{
			text = text.Substring(0, text.IndexOf(">"));
			if (!ValidCongThuc(text, ref strChitieu, ref dSum))
			{
				CMessageBox.ShowWithFormat(50178, new object[1] { strChitieu });
				return;
			}
			if (dSum > 0.0)
			{
				oDr["thue"] = dSum;
			}
			else
			{
				oDr["thue"] = 0;
			}
		}
		else if (text.Contains("<"))
		{
			text = text.Substring(0, text.IndexOf("<"));
			if (!ValidCongThuc(text, ref strChitieu, ref dSum))
			{
				CMessageBox.ShowWithFormat(50178, new object[1] { strChitieu });
				return;
			}
			if (dSum < 0.0)
			{
				oDr["thue"] = 0.0 - dSum;
			}
			else
			{
				oDr["thue"] = 0;
			}
		}
		else
		{
			if (!ValidCongThuc(text, ref strChitieu, ref dSum))
			{
				CMessageBox.ShowWithFormat(50178, new object[1] { strChitieu });
				return;
			}
			oDr["thue"] = dSum;
		}
		string text2 = oDr["ma_so2"].ToString().Replace("[", "").Replace("]", "");
		DataRow[] array = get_MyDGVSource(isSet2Print: true).Select("cong_thuc LIKE '%[[]" + text2 + "[]]' + '%' AND cong_thuc <> ''");
		DataRow[] array2 = array;
		foreach (DataRow oDr2 in array2)
		{
			MyCalc(oDr2);
		}
	}

	private bool ValidCongThuc(string strCong_thuc, ref string strChitieu, ref double dSum)
	{
		int num = 0;
		int num2 = 0;
		string text = "";
		string text2 = "";
		dSum = 0.0;
		checked
		{
			int num3 = strCong_thuc.Length - 1;
			num = 0;
			while (true)
			{
				int num4 = num;
				int num5 = num3;
				if (num4 > num5)
				{
					break;
				}
				if ((Operators.CompareString(strCong_thuc[num].ToString(), "+", false) == 0) | (Operators.CompareString(strCong_thuc[num].ToString(), "-", false) == 0))
				{
					text2 = strCong_thuc.Substring(0, num);
					if (get_MyDGVSource(isSet2Print: true).Select("ma_so2 = '" + text2 + "'").Length == 0)
					{
						strChitieu = text2;
						return false;
					}
					dSum = Conversions.ToDouble(get_MyDGVSource(isSet2Print: true).Compute("SUM(thue)", "ma_so2 = '" + text2 + "'"));
					text = strCong_thuc[num].ToString();
					num2 = num + 1;
					break;
				}
				num++;
			}
			int num6 = num2;
			int num7 = strCong_thuc.Length - 1;
			num = num6;
			while (true)
			{
				int num8 = num;
				int num5 = num7;
				if (num8 > num5)
				{
					break;
				}
				if ((Operators.CompareString(strCong_thuc[num].ToString(), "+", false) == 0) | (Operators.CompareString(strCong_thuc[num].ToString(), "-", false) == 0))
				{
					text2 = strCong_thuc.Substring(num2, num - num2);
					if (get_MyDGVSource(isSet2Print: true).Select("ma_so2 = '" + text2 + "'").Length == 0)
					{
						strChitieu = text2;
						return false;
					}
					dSum = Conversions.ToDouble(Operators.AddObject((object)dSum, get_MyDGVSource(isSet2Print: true).Compute(text + "1 * SUM(thue)", "ma_so2 = '" + text2 + "'")));
					text = strCong_thuc[num].ToString();
					num2 = num + 1;
				}
				num++;
			}
			text2 = strCong_thuc.Substring(num2, num - num2);
			if (get_MyDGVSource(isSet2Print: true).Select("ma_so2 = '" + text2 + "'").Length == 0)
			{
				strChitieu = text2;
				return false;
			}
			dSum = Conversions.ToDouble(Operators.AddObject((object)dSum, get_MyDGVSource(isSet2Print: true).Compute(text + "1 * SUM(thue)", "ma_so2 = '" + text2 + "'")));
			return true;
		}
	}
}
