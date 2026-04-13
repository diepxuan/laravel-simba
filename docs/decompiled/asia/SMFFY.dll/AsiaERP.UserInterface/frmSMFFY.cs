using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmSMFFY : frmCalc
{
	private IContainer components;

	[AccessedThroughProperty("txtNgay_dntc")]
	private AsMaskedTextBox _txtNgay_dntc;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	protected override Button cmdOK
	{
		get
		{
			return base.cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdOK_Click;
			if (base.cmdOK != null)
			{
				((Control)base.cmdOK).Click -= eventHandler;
			}
			base.cmdOK = value;
			if (base.cmdOK != null)
			{
				((Control)base.cmdOK).Click += eventHandler;
			}
		}
	}

	internal virtual AsMaskedTextBox txtNgay_dntc
	{
		get
		{
			return _txtNgay_dntc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNgay_dntc = value;
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

	public frmSMFFY(string menuID)
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		txtNgay_dntc = new AsMaskedTextBox();
		Label2 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 107);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		((Control)gbInput).Controls.Add((Control)(object)txtNgay_dntc);
		((Control)gbInput).Controls.Add((Control)(object)Label2);
		GroupBox obj2 = gbInput;
		Size size = new Size(348, 92);
		((Control)obj2).Size = size;
		((Control)gbInput).TabIndex = 0;
		Button obj3 = cmdOK;
		location = new Point(12, 107);
		((Control)obj3).Location = location;
		((Control)cmdOK).TabIndex = 1;
		txtNgay_dntc.Format = "@Ddd/MM";
		((MaskedTextBox)txtNgay_dntc).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_dntc;
		location = new Point(137, 19);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_dntc).Mask = "##/##";
		((Control)txtNgay_dntc).Name = "txtNgay_dntc";
		((MaskedTextBox)txtNgay_dntc).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_dntc;
		size = new Size(37, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_dntc).TabIndex = 1;
		((MaskedTextBox)txtNgay_dntc).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_dntc;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		Label2.AutoSize = true;
		Label label = Label2;
		location = new Point(9, 23);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(122, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 7;
		Label2.Text = "Ngày đầu năm tài chính";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(370, 139);
		((Form)this).ClientSize = size;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSMFFY";
		((Form)this).Text = "Khóa số liệu";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitComponents()
	{
		base.InitComponents();
		txtNgay_dntc.Value = AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc;
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay_dntc.Value));
		try
		{
			Commons.ExecuteStoredProcedure("asSiUpd_Ngay_dntc", arrayList.ToArray());
			CMessageBox.Show(50015);
			AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc = Conversions.ToDate(txtNgay_dntc.Value);
			((Form)this).Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(50010);
			ProjectData.ClearProjectError();
		}
	}
}
