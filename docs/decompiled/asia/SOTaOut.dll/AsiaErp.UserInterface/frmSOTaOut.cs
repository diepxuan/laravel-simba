using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSOTaOut : frmDMView
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

	public frmSOTaOut(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		InitializeComponent();
		((Control)base.lblTen).Visible = false;
		((Control)base.cboFilter).Visible = false;
		((Control)base.txtValue).Visible = false;
		((Control)base.cmdSearch).Visible = false;
		((Control)base.cmdChgCode).Visible = false;
		((Control)base.cmdAdd).Location = ((Control)base.cmdEdit).Location;
		((Control)base.cmdEdit).Location = ((Control)base.cmdDel).Location;
		((Control)base.cmdDel).Location = ((Control)base.cmdChgCode).Location;
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
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherBeforeLoadData()
	{
		base.InitOtherBeforeLoadData();
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		SourceTable.Columns["ma_ct"].DefaultValue = MyMenuInfo.par1;
		SourceTable.Columns["stt_rec"].DefaultValue = "";
		SourceTable.Columns["stt_rec0"].DefaultValue = "";
	}

	protected override void Edit()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(SourceTable.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["ma_ct"].ToString(), "TAO", false) != 0)
		{
			CMessageBox.Show(50139);
		}
		else
		{
			base.Edit();
		}
	}

	protected override void Delete()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(SourceTable.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["ma_ct"].ToString(), "TAO", false) != 0)
		{
			CMessageBox.Show(50140);
		}
		else
		{
			base.Delete();
		}
	}
}
