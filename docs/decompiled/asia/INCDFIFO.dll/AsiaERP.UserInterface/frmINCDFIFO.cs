using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmINCDFIFO : frmOBView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	private bool check;

	private string strMa_vt;

	private string strMa_kho;

	public string STR_TKVT;

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

	public frmINCDFIFO(string MenuID)
		: base(MenuID)
	{
		((Form)this).Shown += frmINCDVT_Shown;
		__ENCAddToList(this);
		check = false;
		strMa_vt = "";
		strMa_kho = "";
		STR_TKVT = "";
		InitializeComponent();
		AsDataGridView asDataGridView = dgvDM;
		Size size = checked(new Size(((Control)cmdClose).Right - 10, ((Control)cmdClose).Top - 15));
		((Control)asDataGridView).Size = size;
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
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = cmdChgCode;
		Point location = new Point(375, 434);
		((Control)obj).Location = location;
		TextBox obj2 = txtValue;
		location = new Point(140, 435);
		((Control)obj2).Location = location;
		((Control)txtValue).Visible = false;
		Button obj3 = cmdDel;
		location = new Point(610, 396);
		((Control)obj3).Location = location;
		ComboBox obj4 = cboFilter;
		location = new Point(57, 435);
		((Control)obj4).Location = location;
		((Control)cboFilter).Visible = false;
		Button obj5 = cmdEdit;
		location = new Point(540, 396);
		((Control)obj5).Location = location;
		Button obj6 = cmdSearch;
		location = new Point(234, 434);
		((Control)obj6).Location = location;
		((Control)cmdSearch).Visible = false;
		Button obj7 = cmdAdd;
		location = new Point(470, 396);
		((Control)obj7).Location = location;
		Label obj8 = lblTen;
		location = new Point(6, 437);
		((Control)obj8).Location = location;
		((Control)lblTen).Visible = false;
		Button obj9 = cmdPrint;
		location = new Point(611, 500);
		((Control)obj9).Location = location;
		((Control)cmdPrint).Visible = false;
		Button obj10 = cmdClose;
		location = new Point(680, 396);
		((Control)obj10).Location = location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		Size clientSize = new Size(754, 429);
		((Form)this).ClientSize = clientSize;
		((Control)this).Name = "frmINCDVT";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdClose, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cboFilter, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtValue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdChgCode, 0);
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool Login()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		frmINCDFIFOFilter frmINCDFIFOFilter2 = new frmINCDFIFOFilter();
		frmINCDFIFOFilter2.txtYear.Value = SystemInformations.FinancialYear;
		((Form)frmINCDFIFOFilter2).Text = MyMenuInfo.bar.Trim();
		((Form)frmINCDFIFOFilter2).ShowDialog((IWin32Window)(object)this);
		DialogResult dialogResult = ((Form)frmINCDFIFOFilter2).DialogResult;
		if ((int)dialogResult == 1)
		{
			strMa_vt = ((TextBox)frmINCDFIFOFilter2.txtMa_vt).Text.Trim();
			strMa_kho = ((TextBox)frmINCDFIFOFilter2.txtMa_kho).Text.Trim();
			check = true;
			return check;
		}
		check = false;
		return true;
	}

	protected override void GetData(params object[] @params)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(SystemInformations.FinancialYear);
		arrayList.Add(strMa_kho);
		arrayList.Add(strMa_vt);
		base.SourceTable = MyController.GetData(arrayList.ToArray());
		base.SourceTable.Columns["Nam"].DefaultValue = SystemInformations.FinancialYear;
	}

	private void frmINCDVT_Shown(object sender, EventArgs e)
	{
		if (!check)
		{
			((Form)this).Close();
		}
	}
}
