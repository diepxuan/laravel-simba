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
public class frmSIDMNT : frmDMView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	public frmSIDMNT(string MenuID)
		: base(MenuID)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Control)cmdChgCode).Visible = false;
		Button obj = cmdDel;
		Point location = new Point(541, 395);
		((Control)obj).Location = location;
		Button obj2 = cmdEdit;
		location = new Point(471, 395);
		((Control)obj2).Location = location;
		Button obj3 = cmdAdd;
		location = new Point(401, 395);
		((Control)obj3).Location = location;
		Button obj4 = cmdPrint;
		location = new Point(611, 395);
		((Control)obj4).Location = location;
		Button obj5 = cmdClose;
		location = new Point(680, 395);
		((Control)obj5).Location = location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		Size clientSize = new Size(754, 429);
		((Form)this).ClientSize = clientSize;
		((Control)this).Name = "frmSIDMNT";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
