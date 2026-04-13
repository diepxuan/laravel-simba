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
public class frmSoVchSo5Print : frmVoucherPrint
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmbHTTT")]
	private ComboBox _cmbHTTT;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	internal virtual ComboBox cmbHTTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbHTTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbHTTT = value;
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

	[DebuggerNonUserCode]
	public frmSoVchSo5Print()
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		cmbHTTT = new ComboBox();
		Label1 = new Label();
		((Control)gbPrint).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)gbPrint).Controls.Add((Control)(object)cmbHTTT);
		((Control)gbPrint).Controls.Add((Control)(object)Label1);
		GroupBox obj = gbPrint;
		Size size = new Size(441, 159);
		((Control)obj).Size = size;
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)lblSo_Ct_kem, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)lblSo_lien, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtSo_lien, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtSo_Ct_Kem, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)cmbHTTT, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)gbPrint).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)cmdModifyReport).Anchor = (AnchorStyles)5;
		Button obj2 = cmdModifyReport;
		Point location = new Point(353, 19);
		((Control)obj2).Location = location;
		((Control)cmdModifyReport).TabIndex = 5;
		Label obj3 = lblSo_lien;
		location = new Point(9, 129);
		((Control)obj3).Location = location;
		Label obj4 = lblSo_Ct_kem;
		location = new Point(9, 103);
		((Control)obj4).Location = location;
		Button obj5 = cmdCancel;
		location = new Point(152, 172);
		((Control)obj5).Location = location;
		Button obj6 = cmPreview;
		location = new Point(82, 172);
		((Control)obj6).Location = location;
		Button obj7 = cmdPrint;
		location = new Point(12, 172);
		((Control)obj7).Location = location;
		TextBox obj8 = txtSo_Ct_Kem;
		location = new Point(128, 99);
		((Control)obj8).Location = location;
		((Control)txtSo_Ct_Kem).TabIndex = 3;
		AsTextNumeric asTextNumeric = txtSo_lien;
		location = new Point(128, 125);
		((Control)asTextNumeric).Location = location;
		((Control)txtSo_lien).TabIndex = 4;
		cmbHTTT.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cmbHTTT).FormattingEnabled = true;
		cmbHTTT.Items.AddRange(new object[3] { "TM/CK", "TM", "CK" });
		ComboBox obj9 = cmbHTTT;
		location = new Point(128, 72);
		((Control)obj9).Location = location;
		((Control)cmbHTTT).Name = "cmbHTTT";
		ComboBox obj10 = cmbHTTT;
		size = new Size(121, 21);
		((Control)obj10).Size = size;
		((Control)cmbHTTT).TabIndex = 2;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(9, 75);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(107, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 135;
		Label1.Text = "Hình thức thanh toán";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(465, 207);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSoVchSo3Print";
		((Form)this).Text = "frmSoVchSo3Print";
		((Control)gbPrint).ResumeLayout(false);
		((Control)gbPrint).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitOtherComponent()
	{
		base.InitOtherComponent();
		cmbHTTT.SelectedIndex = 0;
	}

	protected override void SetExtensionFormulaField()
	{
		base.SetExtensionFormulaField();
		base.MyFomularFields.Add("HTTT", cmbHTTT.Text);
	}
}
