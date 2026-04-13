using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSIDMOpt9 : frmDMView
{
	private IContainer components;

	public frmSIDMOpt9(string menuid)
		: base(menuid)
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
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
		Point location = new Point(520, 283);
		((Control)obj).Location = location;
		((Control)cmdChgCode).Visible = false;
		TextBox obj2 = txtValue;
		location = new Point(120, 400);
		((Control)obj2).Location = location;
		Button obj3 = cmdDel;
		location = new Point(529, 399);
		((Control)obj3).Location = location;
		ComboBox obj4 = cboFilter;
		location = new Point(37, 399);
		((Control)obj4).Location = location;
		Button obj5 = cmdEdit;
		location = new Point(459, 399);
		((Control)obj5).Location = location;
		Button obj6 = cmdSearch;
		location = new Point(214, 399);
		((Control)obj6).Location = location;
		Button obj7 = cmdAdd;
		location = new Point(389, 399);
		((Control)obj7).Location = location;
		Label obj8 = lblTen;
		location = new Point(8, 404);
		((Control)obj8).Location = location;
		Button obj9 = cmdPrint;
		location = new Point(598, 399);
		((Control)obj9).Location = location;
		Button obj10 = cmdClose;
		location = new Point(667, 399);
		((Control)obj10).Location = location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		Size clientSize = new Size(741, 429);
		((Form)this).ClientSize = clientSize;
		((Control)this).Name = "frmSIDMOpt9";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
