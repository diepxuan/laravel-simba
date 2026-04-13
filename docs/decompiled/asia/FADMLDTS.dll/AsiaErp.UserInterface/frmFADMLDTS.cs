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
public class frmFADMLDTS : frmDMView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public frmFADMLDTS(string MenuID)
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
		Point location = new Point(557, 397);
		((Control)obj).Location = location;
		TextBox obj2 = txtValue;
		location = new Point(124, 398);
		((Control)obj2).Location = location;
		Button obj3 = cmdDel;
		location = new Point(487, 397);
		((Control)obj3).Location = location;
		ComboBox obj4 = cboFilter;
		location = new Point(41, 397);
		((Control)obj4).Location = location;
		Button obj5 = cmdEdit;
		location = new Point(417, 397);
		((Control)obj5).Location = location;
		Button obj6 = cmdSearch;
		location = new Point(218, 397);
		((Control)obj6).Location = location;
		Button obj7 = cmdAdd;
		location = new Point(347, 397);
		((Control)obj7).Location = location;
		Label obj8 = lblTen;
		location = new Point(8, 401);
		((Control)obj8).Location = location;
		Button obj9 = cmdPrint;
		location = new Point(627, 397);
		((Control)obj9).Location = location;
		Button obj10 = cmdClose;
		location = new Point(696, 397);
		((Control)obj10).Location = location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdClose;
		Size clientSize = new Size(770, 429);
		((Form)this).ClientSize = clientSize;
		((Control)this).Name = "frmFADMLDTS";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
