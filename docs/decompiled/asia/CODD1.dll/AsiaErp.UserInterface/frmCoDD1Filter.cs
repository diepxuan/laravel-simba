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
public class frmCoDD1Filter : frmDMComplexFilter
{
	private IContainer components;

	[AccessedThroughProperty("txtThang")]
	private AsTextNumeric _txtThang;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtNam")]
	private AsTextNumeric _txtNam;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	internal virtual AsTextNumeric txtThang
	{
		get
		{
			return _txtThang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			CancelEventHandler cancelEventHandler = txtThang_Validating;
			if (_txtThang != null)
			{
				((Control)_txtThang).Validating -= cancelEventHandler;
			}
			_txtThang = value;
			if (_txtThang != null)
			{
				((Control)_txtThang).Validating += cancelEventHandler;
			}
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual AsTextNumeric txtNam
	{
		get
		{
			return _txtNam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNam = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	public frmCoDD1Filter()
	{
		((Form)this).Load += frmCOHsPb1Filter_Load;
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		txtThang = new AsTextNumeric();
		Label1 = new Label();
		Label2 = new Label();
		txtNam = new AsTextNumeric();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		Point location = new Point(93, 117);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdOk;
		location = new Point(12, 117);
		((Control)obj2).Location = location;
		((Control)cmdOk).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)txtNam);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtThang);
		GroupBox obj3 = gbLine;
		Size size = new Size(408, 107);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtThang, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNam, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		txtThang.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtThang;
		location = new Point(81, 28);
		((Control)asTextNumeric).Location = location;
		txtThang.Mask = "##";
		((Control)txtThang).Name = "txtThang";
		AsTextNumeric asTextNumeric2 = txtThang;
		size = new Size(58, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtThang).TabIndex = 0;
		((TextBox)txtThang).Text = "0";
		((TextBox)txtThang).TextAlign = (HorizontalAlignment)1;
		txtThang.Value = 0.0;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(32, 28);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(38, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 101;
		Label1.Text = "Tháng";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(32, 54);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(29, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 103;
		Label2.Text = "Năm";
		txtNam.DecimalSymbol = ".";
		((Control)txtNam).Enabled = false;
		AsTextNumeric asTextNumeric3 = txtNam;
		location = new Point(81, 54);
		((Control)asTextNumeric3).Location = location;
		txtNam.Mask = "####";
		((Control)txtNam).Name = "txtNam";
		AsTextNumeric asTextNumeric4 = txtNam;
		size = new Size(58, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtNam).TabIndex = 1;
		((TextBox)txtNam).Text = "0";
		((TextBox)txtNam).TextAlign = (HorizontalAlignment)1;
		txtNam.Value = 0.0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(432, 152);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCoDD1Filter";
		((Form)this).Text = "Sản phẩm dở dang";
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmCOHsPb1Filter_Load(object sender, EventArgs e)
	{
		txtThang.Value = DateTime.Now.Month;
		txtNam.Value = SystemInformations.FinancialYear;
	}

	private void txtThang_Validating(object sender, CancelEventArgs e)
	{
		if (Operators.ConditionalCompareObjectLess(txtThang.Value, (object)1, false) || Operators.ConditionalCompareObjectGreater(txtThang.Value, (object)12, false))
		{
			e.Cancel = true;
		}
	}
}
