using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmINDMNHVT : frmDMView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	private DataRow rowAdd;

	private string nhom_me;

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

	public frmINDMNHVT(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		nhom_me = "";
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
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		INConfiguration iNConfiguration = AsiaErp.Framework.Environment.GetINConfiguration();
		base.SourceTable.Columns["Tk_vt"].DefaultValue = iNConfiguration.tk_vt;
		base.SourceTable.Columns["Tk_dt"].DefaultValue = iNConfiguration.tk_dt;
		base.SourceTable.Columns["Tk_dtnb"].DefaultValue = iNConfiguration.tk_dtnb;
		base.SourceTable.Columns["tk_gv"].DefaultValue = iNConfiguration.tk_gv;
		base.SourceTable.Columns["tk_tl"].DefaultValue = iNConfiguration.tk_tl;
		base.SourceTable.Columns["tk_ck"].DefaultValue = iNConfiguration.tk_ck;
		base.SourceTable.Columns["cap"].DefaultValue = 1;
	}

	protected override void AddNew()
	{
		base.AddNew();
		UpdateGridview(isAddNew: true);
	}

	protected override void Edit()
	{
		base.Edit();
		UpdateGridview(isAddNew: true);
	}

	protected override void Delete()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (bsDanhMuc.Current != null)
		{
			DataRowView dataRowView = (DataRowView)bsDanhMuc.Current;
			if (SourceTable.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"nhom_me = '", dataRowView["ma_nhvt"]), (object)"'")), "").Length > 0)
			{
				CMessageBox.Show(51212);
				return;
			}
			nhom_me = Conversions.ToString(dataRowView["nhom_me"]);
			base.Delete();
			UpdateGridview(isAddNew: false);
		}
	}

	private object UpdateGridview(bool isAddNew)
	{
		object result;
		try
		{
			string text = "";
			if (!isAddNew)
			{
				goto IL_009d;
			}
			rowAdd = frmINDMNHVTEdit.rowAdd;
			if (rowAdd != null)
			{
				nhom_me = Conversions.ToString(rowAdd["nhom_me"]);
				DataRow[] array = SourceTable.Select("ma_nhvt = '" + nhom_me + "'", "");
				if (array.Length > 0)
				{
					text = Conversions.ToString(array[0]["stt_nhom"]);
				}
				goto IL_009d;
			}
			result = false;
			goto end_IL_0002;
			IL_009d:
			int num = 0;
			DataRow[] array2 = SourceTable.Select("nhom_me = '" + nhom_me + "'", "ma_nhvt");
			foreach (DataRow row in SourceTable.Rows)
			{
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(row["ma_nhvt"], (object)nhom_me, false), (object)(array2.Length > 0))))
				{
					row["bold"] = 1;
				}
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(row["ma_nhvt"], (object)nhom_me, false), (object)(array2.Length == 0))))
				{
					row["bold"] = 0;
				}
			}
			if (isAddNew)
			{
				InitOtherBeforeLoadData();
				GetData();
				SetPrimaryKeyAndDefaultValue();
				DataBinding();
				InitOtherAfterLoadData();
				FormatGridView();
				bsDanhMuc.Position = bsDanhMuc.Find(MyDictInfo.code_fname, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(rowAdd[MyDictInfo.code_fname]))));
			}
			result = true;
			end_IL_0002:;
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
