using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmFAPostTS2GL : frmDMView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdPhan_bo")]
	private Button _cmdPhan_bo;

	private int iThang;

	private bool check;

	internal virtual Button cmdPhan_bo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPhan_bo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdPhan_bo_Click;
			if (_cmdPhan_bo != null)
			{
				((Control)_cmdPhan_bo).Click -= eventHandler;
			}
			_cmdPhan_bo = value;
			if (_cmdPhan_bo != null)
			{
				((Control)_cmdPhan_bo).Click += eventHandler;
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

	public frmFAPostTS2GL(string MenuID)
		: base(MenuID)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		((Form)this).Shown += frmFAPostTS2GL_Shown;
		((Control)this).KeyDown += new KeyEventHandler(frmFAPostTS2GL_KeyDown);
		__ENCAddToList(this);
		iThang = 1;
		check = false;
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		cmdPhan_bo = new Button();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = cmdChgCode;
		Point location = new Point(375, 434);
		((Control)obj).Location = location;
		((Control)cmdChgCode).Visible = false;
		TextBox obj2 = txtValue;
		location = new Point(140, 435);
		((Control)obj2).Location = location;
		((Control)txtValue).Visible = false;
		((Control)cmdDel).Enabled = false;
		Button obj3 = cmdDel;
		location = new Point(356, 396);
		((Control)obj3).Location = location;
		((Control)cmdDel).TabIndex = 3;
		((Control)cmdDel).Visible = false;
		ComboBox obj4 = cboFilter;
		location = new Point(57, 435);
		((Control)obj4).Location = location;
		((Control)cboFilter).Visible = false;
		((Control)cmdEdit).Enabled = false;
		Button obj5 = cmdEdit;
		location = new Point(286, 396);
		((Control)obj5).Location = location;
		((Control)cmdEdit).TabIndex = 2;
		((Control)cmdEdit).Visible = false;
		Button obj6 = cmdSearch;
		location = new Point(234, 434);
		((Control)obj6).Location = location;
		((Control)cmdSearch).Visible = false;
		((Control)cmdAdd).Enabled = false;
		Button obj7 = cmdAdd;
		location = new Point(216, 396);
		((Control)obj7).Location = location;
		((Control)cmdAdd).TabIndex = 1;
		((Control)cmdAdd).Visible = false;
		Label obj8 = lblTen;
		location = new Point(6, 437);
		((Control)obj8).Location = location;
		((Control)lblTen).Visible = false;
		((Control)cmdPrint).Enabled = false;
		Button obj9 = cmdPrint;
		location = new Point(426, 396);
		((Control)obj9).Location = location;
		((Control)cmdPrint).TabIndex = 4;
		((Control)cmdPrint).Visible = false;
		Button obj10 = cmdClose;
		location = new Point(681, 396);
		((Control)obj10).Location = location;
		((Control)cmdClose).TabIndex = 6;
		((Control)cmdPhan_bo).Anchor = (AnchorStyles)10;
		Button obj11 = cmdPhan_bo;
		location = new Point(600, 396);
		((Control)obj11).Location = location;
		((Control)cmdPhan_bo).Name = "cmdPhan_bo";
		Button obj12 = cmdPhan_bo;
		Size size = new Size(75, 23);
		((Control)obj12).Size = size;
		((Control)cmdPhan_bo).TabIndex = 5;
		((ButtonBase)cmdPhan_bo).Text = "&Phân bổ";
		((ButtonBase)cmdPhan_bo).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(755, 429);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdPhan_bo);
		((Control)this).Name = "frmFAPostTS2GL";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPhan_bo, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdClose, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cboFilter, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtValue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdChgCode, 0);
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool Login()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		frmFAPostTS2GLFilter frmFAPostTS2GLFilter2 = new frmFAPostTS2GLFilter();
		((Form)frmFAPostTS2GLFilter2).Text = MyMenuInfo.bar;
		((Form)frmFAPostTS2GLFilter2).ShowDialog();
		DialogResult dialogResult = ((Form)frmFAPostTS2GLFilter2).DialogResult;
		if ((int)dialogResult == 1)
		{
			iThang = Conversions.ToInteger(((ComboBox)frmFAPostTS2GLFilter2.cboKyBc).Text);
			check = true;
			return true;
		}
		check = false;
		return true;
	}

	protected override void GetData(params object[] @params)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(SystemInformations.FinancialYear);
		arrayList.Add(iThang);
		base.SourceTable = MyController.GetData(arrayList.ToArray());
	}

	private bool Execute()
	{
		DateTime dateTime = new DateTime(SystemInformations.FinancialYear, iThang, 1);
		DateTime dateTime2 = dateTime;
		DateTime dateTime3 = dateTime2.AddMonths(1).AddDays(-1.0);
		bool result;
		try
		{
			((Control)this).Cursor = Cursors.WaitCursor;
			Commons.ExecuteStoredProcedure("asFADelPostGlCt", CompanyInformations.CompanyID, base.MyMenuInfo.par1, dateTime3.Year, dateTime3.Month);
			foreach (DataRow row in base.SourceTable.Rows)
			{
				Commons.ExecuteStoredProcedure("asFAPost2GlCt", CompanyInformations.CompanyID, base.MyMenuInfo.par1, dateTime3, RuntimeHelpers.GetObjectValue(row["Tk_cp"]), RuntimeHelpers.GetObjectValue(row["tk_kh"]), RuntimeHelpers.GetObjectValue(row["khau_hao"]), RuntimeHelpers.GetObjectValue(row["ma_phi"]), RuntimeHelpers.GetObjectValue(row["ma_spct"]), SystemInformations.UserName);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = false;
			ProjectData.ClearProjectError();
			goto IL_01d0;
		}
		finally
		{
			((Control)this).Cursor = Cursors.Default;
		}
		result = true;
		goto IL_01d0;
		IL_01d0:
		return result;
	}

	private void cmdPhan_bo_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (Execute())
		{
			CMessageBox.Show(50015);
		}
	}

	private void frmFAPostTS2GL_Shown(object sender, EventArgs e)
	{
		if (!check)
		{
			((Form)this).Close();
		}
	}

	private void frmFAPostTS2GL_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}
}
