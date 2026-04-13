using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLDMDGTG : frmDMComplexView
{
	private IContainer components;

	public frmGLDMDGTG(string menuID)
		: base(menuID)
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Control)cmdChgCode).Enabled = false;
		Button obj = cmdChgCode;
		Point location = new Point(322, 398);
		((Control)obj).Location = location;
		((Control)cmdChgCode).Visible = false;
		TextBox obj2 = txtValue;
		location = new Point(124, 398);
		((Control)obj2).Location = location;
		Button obj3 = cmdDel;
		location = new Point(532, 397);
		((Control)obj3).Location = location;
		ComboBox obj4 = cboFilter;
		location = new Point(41, 397);
		((Control)obj4).Location = location;
		Button obj5 = cmdEdit;
		location = new Point(462, 397);
		((Control)obj5).Location = location;
		Button obj6 = cmdSearch;
		location = new Point(218, 397);
		((Control)obj6).Location = location;
		Button obj7 = cmdAdd;
		location = new Point(392, 397);
		((Control)obj7).Location = location;
		Label obj8 = lblTen;
		location = new Point(8, 402);
		((Control)obj8).Location = location;
		Label obj9 = lblTen;
		Size size = new Size(31, 20);
		((Control)obj9).Size = size;
		Button obj10 = cmdPrint;
		location = new Point(601, 397);
		((Control)obj10).Location = location;
		Button obj11 = cmdClose;
		location = new Point(670, 397);
		((Control)obj11).Location = location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(744, 429);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGLDMDGTG";
		((Form)this).Text = "frmGLDMDGTG";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void AddNew()
	{
		frmGLDMDGTGEdit.iSttMax = Conversions.ToInteger(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(SourceTable.Compute("max(stt)", "")), isNum: true), (object)1));
		base.AddNew();
	}
}
