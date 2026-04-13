using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLMauCF01 : frmDMComplexView
{
	private string ma_mau;

	private IContainer components;

	protected internal override Button cmdChgCode
	{
		[DebuggerNonUserCode]
		get
		{
			return base.cmdChgCode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdChgCode_Click;
			if (base.cmdChgCode != null)
			{
				((Control)base.cmdChgCode).Click -= eventHandler;
			}
			base.cmdChgCode = value;
			if (base.cmdChgCode != null)
			{
				((Control)base.cmdChgCode).Click += eventHandler;
			}
		}
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

	public frmGLMauCF01(string menuid, string code_name, string Mau)
		: base(menuid, code_name)
	{
		InitializeComponent();
		ma_mau = Mau;
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = cmdChgCode;
		Point location = new Point(541, 396);
		((Control)obj).Location = location;
		Button obj2 = cmdDel;
		location = new Point(471, 396);
		((Control)obj2).Location = location;
		Button obj3 = cmdEdit;
		location = new Point(401, 396);
		((Control)obj3).Location = location;
		Button obj4 = cmdAdd;
		location = new Point(331, 396);
		((Control)obj4).Location = location;
		Button obj5 = cmdPrint;
		location = new Point(611, 396);
		((Control)obj5).Location = location;
		Button obj6 = cmdClose;
		location = new Point(681, 396);
		((Control)obj6).Location = location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		Size clientSize = new Size(754, 429);
		((Form)this).ClientSize = clientSize;
		((Control)this).Name = "frmGLMauCF01";
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherBeforeLoadData();
		base.SourceTable.Columns["mau"].DefaultValue = ma_mau;
		base.SourceTable.Columns["modify"].DefaultValue = true;
	}

	protected override void InitOtherBeforeLoadData()
	{
		base.InitOtherBeforeLoadData();
		((Control)base.cmdChgCode).Visible = false;
		((Control)base.lblTen).Visible = false;
		((Control)base.cboFilter).Visible = false;
		((Control)base.txtValue).Visible = false;
		((Control)base.cmdSearch).Visible = false;
		((Control)base.cmdAdd).Location = ((Control)base.cmdEdit).Location;
		((Control)base.cmdEdit).Location = ((Control)base.cmdDel).Location;
		((Control)base.cmdDel).Location = ((Control)base.cmdChgCode).Location;
	}

	protected override void GetData(params object[] @params)
	{
		base.GetData(CompanyInformations.CompanyID, ma_mau);
	}

	private void cmdChgCode_Click(object sender, EventArgs e)
	{
	}
}
