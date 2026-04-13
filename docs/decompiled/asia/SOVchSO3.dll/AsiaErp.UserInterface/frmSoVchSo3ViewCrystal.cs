using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.SOUtilities;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSoVchSo3ViewCrystal : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ctrVoucher")]
	private CrystalReportViewer _ctrVoucher;

	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	internal ReportDocument rp;

	internal DataRow CurrentPHRow;

	internal string MyMenuID;

	internal string Ma_mau;

	internal bool is_oke;

	internal virtual CrystalReportViewer ctrVoucher
	{
		[DebuggerNonUserCode]
		get
		{
			return _ctrVoucher;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ctrVoucher = value;
		}
	}

	internal virtual PrintDocument PrintDocument1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintDocument1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintDocument1 = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSoVchSo3ViewCrystal()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		((Form)this).Load += frmViewCrystal_Load;
		((Control)this).KeyDown += new KeyEventHandler(frmSoViewCrystal_KeyDown);
		__ENCAddToList(this);
		InitializeComponent();
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		ctrVoucher = new CrystalReportViewer();
		PrintDocument1 = new PrintDocument();
		((Control)this).SuspendLayout();
		ctrVoucher.ActiveViewIndex = -1;
		((UserControl)ctrVoucher).BorderStyle = (BorderStyle)2;
		ctrVoucher.DisplayGroupTree = false;
		((Control)ctrVoucher).Dock = (DockStyle)5;
		CrystalReportViewer obj = ctrVoucher;
		Point location = new Point(0, 0);
		((Control)obj).Location = location;
		((Control)ctrVoucher).Name = "ctrVoucher";
		ctrVoucher.SelectionFormula = "";
		CrystalReportViewer obj2 = ctrVoucher;
		Size size = new Size(836, 557);
		((Control)obj2).Size = size;
		((Control)ctrVoucher).TabIndex = 0;
		ctrVoucher.ViewTimeSelectionFormula = "";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(836, 557);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)ctrVoucher);
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmSoVchSo3ViewCrystal";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Form1";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)this).ResumeLayout(false);
	}

	private void frmViewCrystal_Load(object sender, EventArgs e)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		ctrVoucher.ReportSource = rp;
		foreach (object control in ((Control)ctrVoucher).Controls)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(control);
			if (!(objectValue is ToolStrip))
			{
				continue;
			}
			foreach (object item in (IEnumerable)NewLateBinding.LateGet(objectValue, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null))
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(item);
				if (objectValue2 is ToolStripButton && ((ToolStripItem)(ToolStripButton)objectValue2).ToolTipText.ToLower().Contains("print"))
				{
					RemoveAllHandlers((ToolStripButton)objectValue2);
					((ToolStripItem)(ToolStripButton)objectValue2).Click += printButton_Clicked;
				}
			}
		}
	}

	private void frmSoViewCrystal_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}

	private void printButton_Clicked(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		PrintDialog val = new PrintDialog();
		val.UseEXDialog = true;
		val.AllowSomePages = false;
		PrintDialog val2 = val;
		if (!is_oke)
		{
			CMessageBox.Show(50150);
			return;
		}
		DialogResult val3 = ((CommonDialog)val2).ShowDialog();
		if ((int)val3 != 1)
		{
			return;
		}
		int copies = val2.PrinterSettings.Copies;
		int fromPage = val2.PrinterSettings.FromPage;
		int toPage = val2.PrinterSettings.ToPage;
		string printerName = val2.PrinterSettings.PrinterName;
		ReportDocument val4 = (ReportDocument)ctrVoucher.ReportSource;
		try
		{
			val4.PrintOptions.PrinterName = val2.PrinterSettings.PrinterName;
			val4.PrintToPrinter(copies, false, fromPage, toPage);
			ArrayList arrayList = new ArrayList();
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(SystemInformations.UserName);
			arrayList.Add(MyMenuID);
			arrayList.Add(RuntimeHelpers.GetObjectValue(CurrentPHRow["stt_rec"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(CurrentPHRow["ma_ct"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(CurrentPHRow["so_ct"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(CurrentPHRow["so_seri"]));
			arrayList.Add(RuntimeHelpers.GetObjectValue(CurrentPHRow["ngay_ct"]));
			arrayList.Add(Ma_mau);
			arrayList.Add(DateTime.Now);
			SOCommon.SoInsLogPrint(arrayList.ToArray());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public void RemoveAllHandlers(ToolStripButton ctrl)
	{
		if (ctrl == null)
		{
			return;
		}
		Type type = ((object)ctrl).GetType();
		PropertyInfo property = type.GetProperty("Events", BindingFlags.Instance | BindingFlags.NonPublic);
		EventHandlerList eventHandlerList = (EventHandlerList)property.GetValue(ctrl, null);
		FieldInfo field = eventHandlerList.GetType().GetField("head", BindingFlags.Instance | BindingFlags.NonPublic);
		Dictionary<object, Delegate[]> dictionary = new Dictionary<object, Delegate[]>();
		object objectValue = RuntimeHelpers.GetObjectValue(field.GetValue(eventHandlerList));
		if (objectValue == null)
		{
			return;
		}
		Type type2 = objectValue.GetType();
		FieldInfo field2 = type2.GetField("handler", BindingFlags.Instance | BindingFlags.NonPublic);
		FieldInfo field3 = type2.GetField("key", BindingFlags.Instance | BindingFlags.NonPublic);
		FieldInfo field4 = type2.GetField("next", BindingFlags.Instance | BindingFlags.NonPublic);
		HelpAddEntry(dictionary, RuntimeHelpers.GetObjectValue(objectValue), field2, field3, field4);
		checked
		{
			foreach (KeyValuePair<object, Delegate[]> item in dictionary)
			{
				int num = item.Value.Length - 1;
				while (true)
				{
					int num2 = num;
					int num3 = 0;
					if (num2 < num3)
					{
						break;
					}
					eventHandlerList.RemoveHandler(RuntimeHelpers.GetObjectValue(item.Key), item.Value[num]);
					num += -1;
				}
			}
		}
	}

	private void HelpAddEntry(Dictionary<object, Delegate[]> dict, object entry, FieldInfo handlerFI, FieldInfo keyFI, FieldInfo nextFI)
	{
		Delegate obj = (Delegate)handlerFI.GetValue(RuntimeHelpers.GetObjectValue(entry));
		object objectValue = RuntimeHelpers.GetObjectValue(keyFI.GetValue(RuntimeHelpers.GetObjectValue(entry)));
		object objectValue2 = RuntimeHelpers.GetObjectValue(nextFI.GetValue(RuntimeHelpers.GetObjectValue(entry)));
		Delegate[] invocationList = obj.GetInvocationList();
		if ((invocationList != null && invocationList.Length > 0) ? true : false)
		{
			dict.Add(RuntimeHelpers.GetObjectValue(objectValue), invocationList);
		}
		if (objectValue2 != null)
		{
			HelpAddEntry(dict, RuntimeHelpers.GetObjectValue(objectValue2), handlerFI, keyFI, nextFI);
		}
	}
}
