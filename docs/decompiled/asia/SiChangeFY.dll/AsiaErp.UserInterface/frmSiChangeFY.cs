using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSiChangeFY : frmCalc
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblFinancialYear")]
	private Label _lblFinancialYear;

	[AccessedThroughProperty("cboFinanceYear")]
	private AsComboBox _cboFinanceYear;

	private int intFinanceYear;

	protected override Button cmdOK
	{
		[DebuggerNonUserCode]
		get
		{
			return base.cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOK_Click;
			if (base.cmdOK != null)
			{
				((Control)base.cmdOK).Click -= eventHandler;
			}
			base.cmdOK = value;
			if (base.cmdOK != null)
			{
				((Control)base.cmdOK).Click += eventHandler;
			}
		}
	}

	internal virtual Label lblFinancialYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFinancialYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFinancialYear = value;
		}
	}

	internal virtual AsComboBox cboFinanceYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboFinanceYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboFinanceYear = value;
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

	public frmSiChangeFY(string menuID)
		: base(menuID)
	{
		__ENCAddToList(this);
		intFinanceYear = 0;
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		cboFinanceYear = new AsComboBox();
		lblFinancialYear = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 92);
		((Control)obj).Location = location;
		((Control)gbInput).Controls.Add((Control)(object)lblFinancialYear);
		((Control)gbInput).Controls.Add((Control)(object)cboFinanceYear);
		GroupBox obj2 = gbInput;
		Size size = new Size(397, 77);
		((Control)obj2).Size = size;
		Button obj3 = cmdOK;
		location = new Point(12, 92);
		((Control)obj3).Location = location;
		((ListControl)cboFinanceYear).FormattingEnabled = true;
		AsComboBox asComboBox = cboFinanceYear;
		location = new Point(104, 30);
		((Control)asComboBox).Location = location;
		((Control)cboFinanceYear).Name = "cboFinanceYear";
		AsComboBox asComboBox2 = cboFinanceYear;
		size = new Size(84, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboFinanceYear).TabIndex = 0;
		lblFinancialYear.AutoSize = true;
		Label obj4 = lblFinancialYear;
		location = new Point(16, 33);
		((Control)obj4).Location = location;
		((Control)lblFinancialYear).Name = "lblFinancialYear";
		Label obj5 = lblFinancialYear;
		size = new Size(74, 13);
		((Control)obj5).Size = size;
		((Control)lblFinancialYear).TabIndex = 1;
		lblFinancialYear.Text = "Năm tài chính";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(419, 124);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSiChangeFY";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitComponents()
	{
		int year = DateAndTime.Now.Year;
		checked
		{
			int num = year - 10;
			int num2 = year + 10;
			int num3 = num;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				((ComboBox)cboFinanceYear).Items.Add((object)num3);
				num3++;
			}
			((ComboBox)cboFinanceYear).SelectedItem = SystemInformations.FinancialYear;
			((ComboBox)cboFinanceYear).DropDownStyle = (ComboBoxStyle)2;
			base.InitComponents();
		}
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		intFinanceYear = int.Parse(Conversions.ToString(((ComboBox)cboFinanceYear).SelectedItem));
		SystemInformations.FinancialYear = intFinanceYear;
		((Form)this).Close();
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
