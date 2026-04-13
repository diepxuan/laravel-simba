using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmARRecalCustBalance : frmCalc
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblNam")]
	private Label _lblNam;

	[AccessedThroughProperty("txtMa_kh")]
	private AsTextBox _txtMa_kh;

	[AccessedThroughProperty("txtNam")]
	private TextBox _txtNam;

	[AccessedThroughProperty("lblMa_kh")]
	private Label _lblMa_kh;

	[AccessedThroughProperty("lblTen_kh")]
	private Label _lblTen_kh;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	internal virtual Label lblNam
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNam = value;
		}
	}

	internal virtual AsTextBox txtMa_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kh = value;
		}
	}

	internal virtual TextBox txtNam
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNam = value;
		}
	}

	internal virtual Label lblMa_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kh = value;
		}
	}

	internal virtual Label lblTen_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kh = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	public frmARRecalCustBalance(string menuID)
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		lblNam = new Label();
		lblMa_kh = new Label();
		txtNam = new TextBox();
		txtMa_kh = new AsTextBox();
		lblTen_kh = new Label();
		Label1 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 113);
		((Control)obj).Location = location;
		((Control)gbInput).Controls.Add((Control)(object)Label1);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_kh);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_kh);
		((Control)gbInput).Controls.Add((Control)(object)txtNam);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_kh);
		((Control)gbInput).Controls.Add((Control)(object)lblNam);
		GroupBox obj2 = gbInput;
		Size size = new Size(399, 98);
		((Control)obj2).Size = size;
		Button obj3 = cmdOK;
		location = new Point(12, 113);
		((Control)obj3).Location = location;
		lblNam.AutoSize = true;
		Label obj4 = lblNam;
		location = new Point(19, 22);
		((Control)obj4).Location = location;
		((Control)lblNam).Name = "lblNam";
		Label obj5 = lblNam;
		size = new Size(29, 13);
		((Control)obj5).Size = size;
		((Control)lblNam).TabIndex = 0;
		lblNam.Text = "Năm";
		lblMa_kh.AutoSize = true;
		Label obj6 = lblMa_kh;
		location = new Point(18, 58);
		((Control)obj6).Location = location;
		((Control)lblMa_kh).Name = "lblMa_kh";
		Label obj7 = lblMa_kh;
		size = new Size(0, 13);
		((Control)obj7).Size = size;
		((Control)lblMa_kh).TabIndex = 1;
		((Control)txtNam).Enabled = false;
		TextBox obj8 = txtNam;
		location = new Point(71, 19);
		((Control)obj8).Location = location;
		((Control)txtNam).Name = "txtNam";
		TextBox obj9 = txtNam;
		size = new Size(48, 20);
		((Control)obj9).Size = size;
		((Control)txtNam).TabIndex = 2;
		txtNam.TextAlign = (HorizontalAlignment)2;
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = true;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_kh;
		location = new Point(71, 48);
		((Control)asTextBox).Location = location;
		txtMa_kh.LookupCodeName = "MA_KH";
		((TextBoxBase)txtMa_kh).MaxLength = 20;
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = lblTen_kh;
		AsTextBox asTextBox2 = txtMa_kh;
		size = new Size(90, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_kh).TabIndex = 3;
		txtMa_kh.UseAutoCompleteSource = true;
		lblTen_kh.ImeMode = (ImeMode)0;
		Label obj10 = lblTen_kh;
		location = new Point(167, 48);
		((Control)obj10).Location = location;
		((Control)lblTen_kh).Name = "lblTen_kh";
		Label obj11 = lblTen_kh;
		size = new Size(197, 17);
		((Control)obj11).Size = size;
		((Control)lblTen_kh).TabIndex = 1136;
		lblTen_kh.TextAlign = (ContentAlignment)16;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(19, 52);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(40, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1137;
		Label1.Text = "Mã KH";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(421, 145);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmARRecalCustBalance";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override bool Execute()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		bool result = false;
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(((TextBox)txtMa_kh).Text);
		arrayList.Add(SystemInformations.FinancialYear);
		try
		{
			result = Conversions.ToBoolean(base.MyController.Execute(arrayList.ToArray()));
			CMessageBox.Show(50015);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected override void InitComponents()
	{
		base.InitComponents();
		txtNam.Text = Conversions.ToString(SystemInformations.FinancialYear);
	}
}
