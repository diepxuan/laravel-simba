using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCADelLaiKu : frmCalc
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtMa_ku")]
	private AsTextBox _txtMa_ku;

	[AccessedThroughProperty("lblTen_TS")]
	private Label _lblTen_TS;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("txtThang")]
	private AsTextNumeric _txtThang;

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

	private virtual AsTextBox txtMa_ku
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_ku = value;
		}
	}

	private virtual Label lblTen_TS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TS = value;
		}
	}

	private virtual Label lblTk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk = value;
		}
	}

	internal virtual AsTextNumeric txtThang
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtThang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtThang = value;
		}
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		Label1 = new Label();
		txtMa_ku = new AsTextBox();
		lblTen_TS = new Label();
		lblTk = new Label();
		txtThang = new AsTextNumeric();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 103);
		((Control)obj).Location = location;
		((Control)gbInput).Controls.Add((Control)(object)txtThang);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_ku);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_TS);
		((Control)gbInput).Controls.Add((Control)(object)lblTk);
		((Control)gbInput).Controls.Add((Control)(object)Label1);
		GroupBox obj2 = gbInput;
		Size size = new Size(480, 88);
		((Control)obj2).Size = size;
		Button obj3 = cmdOK;
		location = new Point(12, 103);
		((Control)obj3).Location = location;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(6, 24);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(38, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1;
		Label1.Text = "Tháng";
		((TextBox)txtMa_ku).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_ku.AutoLookup = true;
		txtMa_ku.AutoValid = false;
		((TextBoxBase)txtMa_ku).BackColor = SystemColors.Info;
		((TextBox)txtMa_ku).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_ku;
		location = new Point(76, 46);
		((Control)asTextBox).Location = location;
		txtMa_ku.LookupCodeName = "MA_KU";
		((Control)txtMa_ku).Name = "txtMa_ku";
		txtMa_ku.NameControl = lblTen_TS;
		AsTextBox asTextBox2 = txtMa_ku;
		size = new Size(82, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_ku).TabIndex = 1;
		((Control)txtMa_ku).Tag = "@pMa_KU";
		txtMa_ku.UseAutoCompleteSource = true;
		lblTen_TS.ImeMode = (ImeMode)0;
		Label obj4 = lblTen_TS;
		location = new Point(164, 50);
		((Control)obj4).Location = location;
		((Control)lblTen_TS).Name = "lblTen_TS";
		Label obj5 = lblTen_TS;
		size = new Size(298, 13);
		((Control)obj5).Size = size;
		((Control)lblTen_TS).TabIndex = 1025;
		lblTen_TS.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj6 = lblTk;
		location = new Point(6, 50);
		((Control)obj6).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj7 = lblTk;
		size = new Size(64, 13);
		((Control)obj7).Size = size;
		((Control)lblTk).TabIndex = 1024;
		lblTk.Text = "Mã khế ước";
		txtThang.DecimalSymbol = ".";
		txtThang.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtThang;
		location = new Point(76, 20);
		((Control)asTextNumeric).Location = location;
		txtThang.Mask = "##";
		((Control)txtThang).Name = "txtThang";
		AsTextNumeric asTextNumeric2 = txtThang;
		size = new Size(82, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtThang).TabIndex = 0;
		((TextBox)txtThang).Text = "0";
		((TextBox)txtThang).TextAlign = (HorizontalAlignment)1;
		txtThang.Value = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(502, 135);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCADelLaiKu";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public frmCADelLaiKu(string MenuId)
		: base(MenuId)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
		((Form)this).Text = MyMenuInfo.bar;
	}

	protected override bool Execute()
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtThang.Value));
		arrayList.Add(SystemInformations.FinancialYear);
		arrayList.Add(((TextBox)txtMa_ku).Text);
		bool flag = false;
		bool result;
		try
		{
			flag = Conversions.ToBoolean(MyController.Execute(arrayList.ToArray()));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = flag;
			ProjectData.ClearProjectError();
			goto IL_0099;
		}
		CMessageBox.Show(50015);
		result = flag;
		goto IL_0099;
		IL_0099:
		return result;
	}

	protected override bool ValidData()
	{
		if (Operators.ConditionalCompareObjectLessEqual(txtThang.Value, (object)0, false) || (Operators.ConditionalCompareObjectGreater(txtThang.Value, (object)12, false) ? true : false))
		{
			SetControlError((Control)(object)txtThang, Helper.GetMessContent(50034));
			((Control)txtThang).Select();
			return false;
		}
		return base.ValidData();
	}

	protected override void InitComponents()
	{
		base.InitComponents();
		txtThang.Value = DateAndTime.Now.Month;
		((Control)txtMa_ku).Focus();
		((Control)txtMa_ku).Select();
	}
}
