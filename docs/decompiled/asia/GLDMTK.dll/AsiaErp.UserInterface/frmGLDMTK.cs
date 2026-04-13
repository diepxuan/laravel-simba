using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLDMTK : frmDMView
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

	public frmGLDMTK(string menuid)
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
		((Control)this).SuspendLayout();
		((Control)this).Name = "frmGLDMTK";
		((Form)this).Text = ".";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void AddNew()
	{
		base.AddNew();
		UpdateGridview();
	}

	protected override void Delete()
	{
		base.Delete();
		UpdateGridview();
	}

	private object UpdateGridview()
	{
		checked
		{
			object result;
			try
			{
				string text = "";
				foreach (DataRow row in SourceTable.Rows)
				{
					text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(row["tk"]), isNum: false));
					DataRow[] array = SourceTable.Select("tk like '" + text + "%'");
					if (array.Length > 1)
					{
						row["bold"] = 1;
					}
					else
					{
						row["bold"] = 0;
					}
					DataRow[] array2 = SourceTable.Select("tk = '" + text.Substring(0, text.Length - 1) + "'");
					if ((array2.Length == 1 && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(row["tk_me"]), isNum: false), (object)text.Substring(0, text.Length - 1), false)) ? true : false)
					{
						row["tk_me"] = text.Substring(0, text.Length - 1);
						if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(row["tk_me"]), isNum: false), (object)"", false))
						{
							DataRow[] array3 = SourceTable.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"tk = '", Helper.Repl_Null(RuntimeHelpers.GetObjectValue(row["tk_me"]), isNum: false)), (object)"'")));
							row["bac_tk"] = Operators.AddObject(array[0]["bac_tk"], (object)1);
						}
						row["ten_tk"] = new string(' ', Conversions.ToInteger(Operators.MultiplyObject(Operators.SubtractObject(row["bac_tk"], (object)1), (object)3))) + Strings.Trim(Conversions.ToString(row["ten_tk"]));
					}
				}
				result = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				ProjectData.ClearProjectError();
				InitOtherBeforeLoadData();
				GetData();
				SetPrimaryKeyAndDefaultValue();
				DataBinding();
				InitOtherAfterLoadData();
				FormatGridView();
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}
}
