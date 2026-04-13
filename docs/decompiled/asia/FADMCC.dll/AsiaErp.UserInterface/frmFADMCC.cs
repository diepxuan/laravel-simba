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
public class frmFADMCC : frmDMComplexView
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

	public frmFADMCC(string MenuID)
		: base(MenuID)
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
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdChgCode).Visible = false;
		((Control)cmdPrint).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdDel).Location;
		((Control)cmdEdit).Location = ((Control)cmdChgCode).Location;
		((Control)cmdDel).Location = ((Control)cmdPrint).Location;
		((Control)this).Name = "frmFADMCC";
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void Delete()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if ((int)CMessageBox.Show(50003, SystemInformations.ProductFullName, (MessageBoxButtons)4) == 6)
		{
			DataRowView dataRowView = (DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(dgvDM.DataSource)].Current;
			IFADMCCDAO iFADMCCDAO = (IFADMCCDAO)DAOFactory.CreateDAOInstance("FADMCCDAO", "FADMCC");
			int num = iFADMCCDAO.CheckMaCcExists(RuntimeHelpers.GetObjectValue(dataRowView["stt_rec"]), RuntimeHelpers.GetObjectValue(dataRowView["ma_cc"]), 1);
			if (num != 0)
			{
				CMessageBox.ShowWithFormat(num, RuntimeHelpers.GetObjectValue(dataRowView["ma_cc"]));
			}
			else if (iFADMCCDAO.DeleteCC(CompanyInformations.CompanyID, RuntimeHelpers.GetObjectValue(dataRowView["ma_cc"]), RuntimeHelpers.GetObjectValue(dataRowView["stt_rec"]), 1) == 0)
			{
				dataRowView.Delete();
				SourceTable.AcceptChanges();
			}
			else
			{
				iFADMCCDAO.Destroy();
			}
		}
	}

	protected override void Edit()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		DataRowView dataRowView = (DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(dgvDM.DataSource)].Current;
		IFADMCCDAO iFADMCCDAO = (IFADMCCDAO)DAOFactory.CreateDAOInstance("FADMCCDAO", "FADMCC");
		int num = iFADMCCDAO.CheckMaCcExists(RuntimeHelpers.GetObjectValue(dataRowView["stt_rec"]), RuntimeHelpers.GetObjectValue(dataRowView["ma_cc"]), 1);
		iFADMCCDAO.Destroy();
		if (num == 0 || (int)CMessageBox.Show(50161, SystemInformations.ProductName, (MessageBoxButtons)4) != 7)
		{
			base.Edit();
		}
	}
}
