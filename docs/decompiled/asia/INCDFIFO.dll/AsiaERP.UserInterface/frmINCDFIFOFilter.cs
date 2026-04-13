using System;
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
public class frmINCDFIFOFilter : frmOBFilter
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblYear")]
	private Label _lblYear;

	[AccessedThroughProperty("txtYear")]
	private AsTextNumeric _txtYear;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	internal virtual Label lblYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblYear = value;
		}
	}

	internal virtual AsTextNumeric txtYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtYear = value;
		}
	}

	internal virtual AsTextBox txtMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_vt = value;
		}
	}

	internal virtual Label lblTen_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_vt = value;
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

	internal virtual AsTextBox txtMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kho = value;
		}
	}

	internal virtual Label lblTen_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kho = value;
		}
	}

	internal virtual Label lblMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kho = value;
		}
	}

	[DebuggerNonUserCode]
	public frmINCDFIFOFilter()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
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
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		lblYear = new Label();
		txtYear = new AsTextNumeric();
		Label1 = new Label();
		lblTen_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_kho = new Label();
		lblTen_kho = new Label();
		txtMa_kho = new AsTextBox();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		Point location = new Point(93, 116);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdOk;
		location = new Point(12, 116);
		((Control)obj2).Location = location;
		((Control)cmdOk).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtMa_kho);
		((Control)gbLine).Controls.Add((Control)(object)lblYear);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_kho);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_vt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_kho);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtYear);
		GroupBox obj3 = gbLine;
		Size size = new Size(471, 106);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		lblYear.AutoSize = true;
		Label obj4 = lblYear;
		location = new Point(22, 21);
		((Control)obj4).Location = location;
		((Control)lblYear).Name = "lblYear";
		Label obj5 = lblYear;
		size = new Size(29, 13);
		((Control)obj5).Size = size;
		((Control)lblYear).TabIndex = 100;
		lblYear.Text = "Năm";
		txtYear.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtYear;
		location = new Point(94, 17);
		((Control)asTextNumeric).Location = location;
		txtYear.Mask = "####";
		((Control)txtYear).Name = "txtYear";
		((TextBoxBase)txtYear).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtYear;
		size = new Size(44, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtYear).TabIndex = 0;
		((Control)txtYear).TabStop = false;
		((TextBox)txtYear).Text = "0";
		((TextBox)txtYear).TextAlign = (HorizontalAlignment)1;
		txtYear.Value = 0.0;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(22, 73);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(52, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 103;
		Label1.Text = "Mã vật tư";
		Label obj6 = lblTen_vt;
		location = new Point(236, 70);
		((Control)obj6).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj7 = lblTen_vt;
		size = new Size(212, 18);
		((Control)obj7).Size = size;
		((Control)lblTen_vt).TabIndex = 104;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_vt;
		location = new Point(94, 69);
		((Control)asTextBox).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		txtMa_vt.LookupWhereCondition = "ton_kho=1 and gia_ton='2'";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		txtMa_vt.SD = true;
		AsTextBox asTextBox2 = txtMa_vt;
		size = new Size(136, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_vt).TabIndex = 2;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_kho.AutoSize = true;
		Label obj8 = lblMa_kho;
		location = new Point(22, 47);
		((Control)obj8).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj9 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj9).Size = size;
		((Control)lblMa_kho).TabIndex = 103;
		lblMa_kho.Text = "Mã kho";
		Label obj10 = lblTen_kho;
		location = new Point(168, 43);
		((Control)obj10).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj11 = lblTen_kho;
		size = new Size(212, 18);
		((Control)obj11).Size = size;
		((Control)lblTen_kho).TabIndex = 104;
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_kho;
		location = new Point(94, 43);
		((Control)asTextBox3).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		txtMa_kho.SD = true;
		AsTextBox asTextBox4 = txtMa_kho;
		size = new Size(67, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_kho).TabIndex = 1;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(495, 151);
		((Form)this).ClientSize = size;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmINCDFIFOFilter";
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).Text = "Số dư đầu kỳ vật tư";
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
