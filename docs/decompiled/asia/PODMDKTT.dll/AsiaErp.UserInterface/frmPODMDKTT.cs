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
public class frmPODMDKTT : frmDMView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public frmPODMDKTT(string menuid)
		: base(menuid)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
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
		Button obj = cmdChgCode;
		Point location = new Point(530, 399);
		((Control)obj).Location = location;
		TextBox obj2 = txtValue;
		location = new Point(142, 400);
		((Control)obj2).Location = location;
		Button obj3 = cmdDel;
		location = new Point(460, 399);
		((Control)obj3).Location = location;
		ComboBox obj4 = cboFilter;
		location = new Point(59, 400);
		((Control)obj4).Location = location;
		Button obj5 = cmdEdit;
		location = new Point(390, 399);
		((Control)obj5).Location = location;
		Button obj6 = cmdSearch;
		location = new Point(236, 399);
		((Control)obj6).Location = location;
		Button obj7 = cmdAdd;
		location = new Point(320, 399);
		((Control)obj7).Location = location;
		Label obj8 = lblTen;
		location = new Point(8, 402);
		((Control)obj8).Location = location;
		Button obj9 = cmdPrint;
		location = new Point(600, 399);
		((Control)obj9).Location = location;
		Button obj10 = cmdClose;
		location = new Point(669, 399);
		((Control)obj10).Location = location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		Size clientSize = new Size(743, 429);
		((Form)this).ClientSize = clientSize;
		((Control)this).Name = "frmPODMDKTT";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
