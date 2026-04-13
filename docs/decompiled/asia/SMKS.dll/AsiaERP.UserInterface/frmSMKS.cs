using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaERP.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmSMKS : frmCalc
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtNgay_ks")]
	private AsMaskedTextBox _txtNgay_ks;

	[AccessedThroughProperty("txtFinancialYear")]
	private TextBox _txtFinancialYear;

	[AccessedThroughProperty("lblNgay_ks")]
	private Label _lblNgay_ks;

	[AccessedThroughProperty("lblFinancialYear")]
	private Label _lblFinancialYear;

	protected override Button cmdOK
	{
		[DebuggerNonUserCode]
		get
		{
			return base.cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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

	internal virtual AsMaskedTextBox txtNgay_ks
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ks;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_ks = value;
		}
	}

	internal virtual TextBox txtFinancialYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFinancialYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtFinancialYear = value;
		}
	}

	internal virtual Label lblNgay_ks
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_ks;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_ks = value;
		}
	}

	internal virtual Label lblFinancialYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFinancialYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFinancialYear = value;
		}
	}

	public frmSMKS(string menuID)
		: base(menuID)
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		txtNgay_ks = new AsMaskedTextBox();
		txtFinancialYear = new TextBox();
		lblNgay_ks = new Label();
		lblFinancialYear = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 107);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		((Control)gbInput).Controls.Add((Control)(object)txtNgay_ks);
		((Control)gbInput).Controls.Add((Control)(object)txtFinancialYear);
		((Control)gbInput).Controls.Add((Control)(object)lblNgay_ks);
		((Control)gbInput).Controls.Add((Control)(object)lblFinancialYear);
		GroupBox obj2 = gbInput;
		Size size = new Size(427, 92);
		((Control)obj2).Size = size;
		((Control)gbInput).TabIndex = 0;
		Button obj3 = cmdOK;
		location = new Point(12, 107);
		((Control)obj3).Location = location;
		((Control)cmdOK).TabIndex = 1;
		txtNgay_ks.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ks).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ks;
		location = new Point(123, 53);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ks).Mask = "##/##/####";
		((Control)txtNgay_ks).Name = "txtNgay_ks";
		((MaskedTextBox)txtNgay_ks).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ks;
		size = new Size(87, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ks).TabIndex = 1;
		((MaskedTextBox)txtNgay_ks).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ks;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		TextBox obj4 = txtFinancialYear;
		location = new Point(123, 22);
		((Control)obj4).Location = location;
		((Control)txtFinancialYear).Name = "txtFinancialYear";
		TextBox obj5 = txtFinancialYear;
		size = new Size(54, 20);
		((Control)obj5).Size = size;
		((Control)txtFinancialYear).TabIndex = 0;
		txtFinancialYear.TextAlign = (HorizontalAlignment)2;
		lblNgay_ks.AutoSize = true;
		Label obj6 = lblNgay_ks;
		location = new Point(10, 57);
		((Control)obj6).Location = location;
		((Control)lblNgay_ks).Name = "lblNgay_ks";
		Label obj7 = lblNgay_ks;
		size = new Size(94, 13);
		((Control)obj7).Size = size;
		((Control)lblNgay_ks).TabIndex = 7;
		lblNgay_ks.Text = "Khóa sổ đến ngày";
		lblFinancialYear.AutoSize = true;
		Label obj8 = lblFinancialYear;
		location = new Point(10, 26);
		((Control)obj8).Location = location;
		((Control)lblFinancialYear).Name = "lblFinancialYear";
		Label obj9 = lblFinancialYear;
		size = new Size(74, 13);
		((Control)obj9).Size = size;
		((Control)lblFinancialYear).TabIndex = 8;
		lblFinancialYear.Text = "Năm tài chính";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(449, 139);
		((Form)this).ClientSize = size;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSMKS";
		((Form)this).Text = "Khóa số liệu";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitComponents()
	{
		base.InitComponents();
		AsiaErp.Framework.Environment.RefreshConfiguration(MyMenuInfo.moduleid);
		txtFinancialYear.Text = Conversions.ToString(SystemInformations.FinancialYear);
		((Control)txtFinancialYear).Enabled = false;
		txtNgay_ks.Value = AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks;
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		SMKSDAO sMKSDAO = (SMKSDAO)DAOFactory.CreateDAOInstance("SMKSDAO", "SMKS");
		if (sMKSDAO.Update(CompanyInformations.CompanyID, Conversions.ToDate(txtNgay_ks.Value)) == 0)
		{
			CMessageBox.Show(50015);
			AsiaErp.Framework.Environment.RefreshConfiguration(MyMenuInfo.moduleid);
			((Form)this).Close();
		}
		else
		{
			CMessageBox.Show(50010);
		}
	}
}
