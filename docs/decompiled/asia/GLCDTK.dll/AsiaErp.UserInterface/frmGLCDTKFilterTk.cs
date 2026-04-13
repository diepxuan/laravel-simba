using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLCDTKFilterTk : frmOBFilter
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_tk")]
	private AsTextBox _txtMa_tk;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("lblMa_tk")]
	private Label _lblMa_tk;

	[AccessedThroughProperty("txtYear")]
	private AsTextNumeric _txtYear;

	[AccessedThroughProperty("lblYear")]
	private Label _lblYear;

	[AccessedThroughProperty("lblMa_nt")]
	private Label _lblMa_nt;

	[AccessedThroughProperty("txtMa_nt")]
	private AsTextBox _txtMa_nt;

	[AccessedThroughProperty("lblTen_nt")]
	private Label _lblTen_nt;

	internal virtual AsTextBox txtMa_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_tk = value;
		}
	}

	internal virtual Label lblTen_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk = value;
		}
	}

	internal virtual Label lblMa_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_tk = value;
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

	internal virtual Label lblMa_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nt = value;
		}
	}

	internal virtual AsTextBox txtMa_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nt = value;
		}
	}

	internal virtual Label lblTen_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nt = value;
		}
	}

	[DebuggerNonUserCode]
	public frmGLCDTKFilterTk()
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
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		txtMa_tk = new AsTextBox();
		lblTen_tk = new Label();
		lblMa_tk = new Label();
		lblYear = new Label();
		txtYear = new AsTextNumeric();
		lblMa_nt = new Label();
		lblTen_nt = new Label();
		txtMa_nt = new AsTextBox();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		Point location = new Point(93, 120);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdOk;
		location = new Point(12, 120);
		((Control)obj2).Location = location;
		((Control)cmdOk).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtYear);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblYear);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_tk);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_tk);
		GroupBox obj3 = gbLine;
		Size size = new Size(365, 110);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		txtMa_tk.AutoLookup = true;
		txtMa_tk.AutoValid = false;
		((TextBoxBase)txtMa_tk).BackColor = SystemColors.Info;
		((TextBox)txtMa_tk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_tk;
		location = new Point(81, 49);
		((Control)asTextBox).Location = location;
		txtMa_tk.LookupCodeName = "TK";
		((Control)txtMa_tk).Name = "txtMa_tk";
		txtMa_tk.NameControl = lblTen_tk;
		AsTextBox asTextBox2 = txtMa_tk;
		size = new Size(83, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_tk).TabIndex = 0;
		Label obj4 = lblTen_tk;
		location = new Point(170, 51);
		((Control)obj4).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj5 = lblTen_tk;
		size = new Size(189, 16);
		((Control)obj5).Size = size;
		((Control)lblTen_tk).TabIndex = 102;
		lblMa_tk.AutoSize = true;
		Label obj6 = lblMa_tk;
		location = new Point(29, 53);
		((Control)obj6).Location = location;
		((Control)lblMa_tk).Name = "lblMa_tk";
		Label obj7 = lblMa_tk;
		size = new Size(39, 13);
		((Control)obj7).Size = size;
		((Control)lblMa_tk).TabIndex = 101;
		lblMa_tk.Text = "Mã TK";
		lblYear.AutoSize = true;
		Label obj8 = lblYear;
		location = new Point(29, 27);
		((Control)obj8).Location = location;
		((Control)lblYear).Name = "lblYear";
		Label obj9 = lblYear;
		size = new Size(29, 13);
		((Control)obj9).Size = size;
		((Control)lblYear).TabIndex = 103;
		lblYear.Text = "Năm";
		txtYear.DecimalSymbol = ".";
		((Control)txtYear).Enabled = false;
		txtYear.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtYear;
		location = new Point(81, 23);
		((Control)asTextNumeric).Location = location;
		txtYear.Mask = "####";
		((Control)txtYear).Name = "txtYear";
		AsTextNumeric asTextNumeric2 = txtYear;
		size = new Size(52, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtYear).TabIndex = 104;
		((TextBox)txtYear).Text = "0";
		((TextBox)txtYear).TextAlign = (HorizontalAlignment)1;
		txtYear.Value = 0;
		lblMa_nt.AutoSize = true;
		Label obj10 = lblMa_nt;
		location = new Point(29, 79);
		((Control)obj10).Location = location;
		((Control)lblMa_nt).Name = "lblMa_nt";
		Label obj11 = lblMa_nt;
		size = new Size(40, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_nt).TabIndex = 105;
		lblMa_nt.Text = "Mã NT";
		Label obj12 = lblTen_nt;
		location = new Point(170, 77);
		((Control)obj12).Location = location;
		((Control)lblTen_nt).Name = "lblTen_nt";
		Label obj13 = lblTen_nt;
		size = new Size(189, 16);
		((Control)obj13).Size = size;
		((Control)lblTen_nt).TabIndex = 102;
		txtMa_nt.AutoLookup = true;
		txtMa_nt.AutoValid = false;
		((TextBoxBase)txtMa_nt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_nt;
		location = new Point(81, 75);
		((Control)asTextBox3).Location = location;
		txtMa_nt.LookupCodeName = "MA_NT";
		((Control)txtMa_nt).Name = "txtMa_nt";
		txtMa_nt.NameControl = lblTen_nt;
		AsTextBox asTextBox4 = txtMa_nt;
		size = new Size(83, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_nt).TabIndex = 1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(389, 146);
		((Form)this).ClientSize = size;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmGLCDTKFilterTk";
		((Form)this).Text = "Tính tổng số dư TK";
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ValidData()
	{
		return base.ValidData();
	}
}
