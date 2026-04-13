using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmFADMNV : frmDMView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public frmFADMNV(string MenuID)
		: base(MenuID)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
		AsDataGridView asDataGridView = dgvDM;
		Size size = checked(new Size(((Control)cmdClose).Right - 10, ((Control)this).Height - 80));
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
		((Control)this).SuspendLayout();
		Button obj = cmdChgCode;
		Point location = new Point(414, 397);
		((Control)obj).Location = location;
		((Control)cmdChgCode).Visible = false;
		TextBox obj2 = txtValue;
		location = new Point(119, 398);
		((Control)obj2).Location = location;
		Button obj3 = cmdDel;
		location = new Point(488, 397);
		((Control)obj3).Location = location;
		((Control)cmdDel).Visible = false;
		ComboBox obj4 = cboFilter;
		location = new Point(36, 397);
		((Control)obj4).Location = location;
		Button obj5 = cmdEdit;
		location = new Point(558, 397);
		((Control)obj5).Location = location;
		Button obj6 = cmdSearch;
		location = new Point(213, 397);
		((Control)obj6).Location = location;
		Button obj7 = cmdAdd;
		location = new Point(345, 397);
		((Control)obj7).Location = location;
		((Control)cmdAdd).Visible = false;
		Label obj8 = lblTen;
		location = new Point(8, 400);
		((Control)obj8).Location = location;
		Button obj9 = cmdPrint;
		location = new Point(625, 397);
		((Control)obj9).Location = location;
		Button obj10 = cmdClose;
		location = new Point(694, 397);
		((Control)obj10).Location = location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdClose;
		Size clientSize = new Size(768, 429);
		((Form)this).ClientSize = clientSize;
		((Control)this).Name = "frmFADMNV";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
