using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmFAChuyenTS : frmDMComplexView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

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
			base.Dispose(disposing);
		}
	}

	protected frmFAChuyenTS(string menuid)
		: base(menuid)
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
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdChgCode).Visible = false;
		((Control)txtValue).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdDel).Location;
		((Control)cmdDel).Location = ((Control)cmdPrint).Location;
		((Control)cboFilter).Visible = false;
		((Control)cmdEdit).Location = ((Control)cmdChgCode).Location;
		((Control)cmdSearch).Visible = false;
		((Control)lblTen).Visible = false;
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
