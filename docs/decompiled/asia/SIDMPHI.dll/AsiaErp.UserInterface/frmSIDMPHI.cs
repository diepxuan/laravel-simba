using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSIDMPHI : frmDMView
{
	private IContainer components;

	public frmSIDMPHI(string menuid)
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
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = cmdDel;
		Point location = new Point(473, 394);
		((Control)obj).Location = location;
		Button obj2 = cmdEdit;
		location = new Point(403, 394);
		((Control)obj2).Location = location;
		Button obj3 = cmdAdd;
		location = new Point(333, 394);
		((Control)obj3).Location = location;
		((Control)cmdPrint).TabIndex = 40;
		((Control)cmdPrint).Visible = false;
		Button obj4 = cmdPrint;
		location = new Point(611, 394);
		((Control)obj4).Location = location;
		Button obj5 = cmdClose;
		location = new Point(680, 394);
		((Control)obj5).Location = location;
		Button obj6 = cmdChgCode;
		location = new Point(541, 394);
		((Control)obj6).Location = location;
		((Control)cmdAdd).Location = ((Control)cmdEdit).Location;
		((Control)cmdEdit).Location = ((Control)cmdDel).Location;
		((Control)cmdDel).Location = ((Control)cmdChgCode).Location;
		((Control)cmdChgCode).Location = ((Control)cmdPrint).Location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		Size clientSize = new Size(754, 429);
		((Form)this).ClientSize = clientSize;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		((Control)this).Name = "frmSIDMPHI";
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
