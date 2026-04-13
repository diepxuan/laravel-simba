using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmFADMTS : frmDMView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

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

	public frmFADMTS(string MenuId)
		: base(MenuId)
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdChgCode).Visible = false;
		((Control)cmdPrint).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdDel).Location;
		((Control)cmdEdit).Location = ((Control)cmdChgCode).Location;
		((Control)cmdDel).Location = ((Control)cmdPrint).Location;
		((Control)this).Name = "frmFADMTS";
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void Edit()
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		DataRowView dataRowView = (DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(dgvDM.DataSource)].Current;
		IFADMTSDAO iFADMTSDAO = (IFADMTSDAO)DAOFactory.CreateDAOInstance("FADMTSDAO", "FADMTS");
		int num = iFADMTSDAO.CheckMaTSExists(RuntimeHelpers.GetObjectValue(dataRowView["ma_cty"]), RuntimeHelpers.GetObjectValue(dataRowView["ma_ts"]), 0);
		if (num != 0)
		{
			CMessageBox.ShowWithFormat(num, RuntimeHelpers.GetObjectValue(dataRowView["ma_ts"]));
		}
		else
		{
			base.Edit();
		}
	}

	protected override void Delete()
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		DataRowView dataRowView = (DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(dgvDM.DataSource)].Current;
		IFADMTSDAO iFADMTSDAO = (IFADMTSDAO)DAOFactory.CreateDAOInstance("FADMTSDAO", "FADMTS");
		int num = iFADMTSDAO.CheckMaTSExists(RuntimeHelpers.GetObjectValue(dataRowView["ma_cty"]), RuntimeHelpers.GetObjectValue(dataRowView["ma_ts"]), 0);
		if (num != 0)
		{
			CMessageBox.ShowWithFormat(num, RuntimeHelpers.GetObjectValue(dataRowView["ma_ts"]));
		}
		else
		{
			base.Delete();
		}
	}
}
