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
public class frmFAPostTS2GLFilter : frmDMFilter
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblThang")]
	private Label _lblThang;

	[AccessedThroughProperty("lblNam")]
	private Label _lblNam;

	[AccessedThroughProperty("txtNam")]
	private AsTextNumeric _txtNam;

	[AccessedThroughProperty("cboKyBc")]
	private AsComboBox _cboKyBc;

	internal virtual Label lblThang
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblThang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblThang = value;
		}
	}

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

	internal virtual AsTextNumeric txtNam
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

	internal virtual AsComboBox cboKyBc
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboKyBc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboKyBc = value;
		}
	}

	[DebuggerNonUserCode]
	public frmFAPostTS2GLFilter()
	{
		((Form)this).Load += frmFAPostTS2GLFilter_Load;
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		lblThang = new Label();
		txtNam = new AsTextNumeric();
		lblNam = new Label();
		cboKyBc = new AsComboBox();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		Point location = new Point(93, 102);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdOk;
		location = new Point(12, 102);
		((Control)obj2).Location = location;
		((Control)cmdOk).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)cboKyBc);
		((Control)gbLine).Controls.Add((Control)(object)lblNam);
		((Control)gbLine).Controls.Add((Control)(object)txtNam);
		((Control)gbLine).Controls.Add((Control)(object)lblThang);
		GroupBox obj3 = gbLine;
		Size size = new Size(480, 87);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblThang, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNam, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNam, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)chkKsd).Enabled = false;
		AsCheckBox asCheckBox = chkKsd;
		location = new Point(376, 22);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		lblThang.AutoSize = true;
		Label obj4 = lblThang;
		location = new Point(6, 23);
		((Control)obj4).Location = location;
		((Control)lblThang).Name = "lblThang";
		Label obj5 = lblThang;
		size = new Size(38, 13);
		((Control)obj5).Size = size;
		((Control)lblThang).TabIndex = 1;
		lblThang.Text = "Tháng";
		txtNam.DecimalSymbol = ".";
		((Control)txtNam).Enabled = false;
		txtNam.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtNam;
		location = new Point(68, 45);
		((Control)asTextNumeric).Location = location;
		txtNam.Mask = "####";
		((Control)txtNam).Name = "txtNam";
		AsTextNumeric asTextNumeric2 = txtNam;
		size = new Size(82, 20);
		((Control)asTextNumeric2).Size = size;
		txtNam.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNam).TabIndex = 1;
		((TextBox)txtNam).Text = "0";
		((TextBox)txtNam).TextAlign = (HorizontalAlignment)1;
		txtNam.Value = 0;
		lblNam.AutoSize = true;
		Label obj6 = lblNam;
		location = new Point(6, 48);
		((Control)obj6).Location = location;
		((Control)lblNam).Name = "lblNam";
		Label obj7 = lblNam;
		size = new Size(29, 13);
		((Control)obj7).Size = size;
		((Control)lblNam).TabIndex = 101;
		lblNam.Text = "Năm";
		((ComboBox)cboKyBc).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyBc).FormattingEnabled = true;
		AsComboBox asComboBox = cboKyBc;
		location = new Point(68, 18);
		((Control)asComboBox).Location = location;
		((Control)cboKyBc).Name = "cboKyBc";
		AsComboBox asComboBox2 = cboKyBc;
		size = new Size(82, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(502, 134);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFAPostTS2GLFilter";
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ValidData()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ngay2, AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks) <= 0)
		{
			CMessageBox.Show(50136);
			return false;
		}
		AsiaErp.Framework.Environment.set_PublicVariables("Thang1", (object)((ComboBox)cboKyBc).Text);
		return base.ValidData();
	}

	private void frmFAPostTS2GLFilter_Load(object sender, EventArgs e)
	{
		txtNam.Value = SystemInformations.FinancialYear;
		((ComboBox)cboKyBc).Text = Conversions.ToString(AsiaErp.Framework.Environment.get_PublicVariables("Thang1"));
		InitKyBaoCao();
		((Control)cboKyBc).Select();
	}

	private void InitKyBaoCao()
	{
		((ComboBox)cboKyBc).DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc, "10000");
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
	}
}
