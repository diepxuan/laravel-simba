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
public class frmINDMNHVAT : frmDMView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public frmINDMNHVAT(string menuid)
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
		Point location = new Point(528, 398);
		((Control)obj).Location = location;
		TextBox obj2 = txtValue;
		location = new Point(121, 400);
		((Control)obj2).Location = location;
		Button obj3 = cmdDel;
		location = new Point(458, 398);
		((Control)obj3).Location = location;
		ComboBox obj4 = cboFilter;
		location = new Point(38, 399);
		((Control)obj4).Location = location;
		Button obj5 = cmdEdit;
		location = new Point(388, 398);
		((Control)obj5).Location = location;
		Button obj6 = cmdSearch;
		location = new Point(215, 398);
		((Control)obj6).Location = location;
		Button obj7 = cmdAdd;
		location = new Point(318, 398);
		((Control)obj7).Location = location;
		Label obj8 = lblTen;
		location = new Point(8, 403);
		((Control)obj8).Location = location;
		Button obj9 = cmdPrint;
		location = new Point(598, 398);
		((Control)obj9).Location = location;
		Button obj10 = cmdClose;
		location = new Point(667, 398);
		((Control)obj10).Location = location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		Size clientSize = new Size(741, 429);
		((Form)this).ClientSize = clientSize;
		((Control)this).Name = "frmINDMNHVAT";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
