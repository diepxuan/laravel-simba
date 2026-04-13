using System;
using System.Collections;
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
public class frmCoDMCPTT : frmDMComplexView
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

	public frmCoDMCPTT(string MenuID)
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
		((Control)this).SuspendLayout();
		((Control)cmdChgCode).Visible = false;
		((Control)txtValue).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdDel).Location;
		((Control)cmdDel).Location = ((Control)cmdPrint).Location;
		((Control)cboFilter).Visible = false;
		((Control)cmdEdit).Location = ((Control)cmdChgCode).Location;
		((Control)cmdSearch).Visible = false;
		((Control)lblTen).Visible = false;
		((Control)cmdPrint).Visible = false;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
		((Control)this).Name = "frmCoDMCPTT";
	}

	protected override void GetData(params object[] @params)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add("");
		arrayList.Add(0);
		base.GetData(arrayList.ToArray());
	}

	protected override void Delete()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if ((int)CMessageBox.ShowWithFormat(50003, (MessageBoxButtons)4) != 7)
		{
			DataRowView dataRowView = (DataRowView)bsDanhMuc.Current;
			ArrayList arrayList = new ArrayList();
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["Ma_cptt"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["ID"]));
			CODMCPTTDAO cODMCPTTDAO = (CODMCPTTDAO)DAOFactory.CreateDAOInstance("CODMCPTTDAO", "CODMCPTT");
			int num = cODMCPTTDAO.DelCPTT(arrayList.ToArray());
			cODMCPTTDAO.Destroy();
			if (num != 0)
			{
				CMessageBox.Show(num);
			}
			else
			{
				bsDanhMuc.RemoveAt(bsDanhMuc.Position);
			}
		}
	}
}
