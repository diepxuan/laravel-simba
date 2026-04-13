using System;
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
public class frmFAAdjustKHTSFilter : frmDMFilter
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblTen_TS")]
	private Label _lblTen_TS;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("txtMa_Ts")]
	private AsTextBox _txtMa_Ts;

	[AccessedThroughProperty("cboKyBc")]
	private AsComboBox _cboKyBc;

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

	private virtual Label lblTen_TS
	{
		get
		{
			return _lblTen_TS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_TS = value;
		}
	}

	private virtual Label lblTk
	{
		get
		{
			return _lblTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTk = value;
		}
	}

	internal virtual AsTextBox txtMa_Ts
	{
		get
		{
			return _txtMa_Ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_Ts = value;
		}
	}

	internal virtual AsComboBox cboKyBc
	{
		get
		{
			return _cboKyBc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboKyBc = value;
		}
	}

	public frmFAAdjustKHTSFilter()
	{
		((Form)this).Load += frmFAAdjustKHTSFilter_Load;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		Label1 = new Label();
		txtMa_Ts = new AsTextBox();
		lblTen_TS = new Label();
		lblTk = new Label();
		cboKyBc = new AsComboBox();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		Point location = new Point(93, 103);
		((Control)obj).Location = location;
		Button obj2 = cmdOk;
		location = new Point(12, 103);
		((Control)obj2).Location = location;
		((Control)gbLine).Controls.Add((Control)(object)cboKyBc);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Ts);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_TS);
		((Control)gbLine).Controls.Add((Control)(object)lblTk);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		GroupBox obj3 = gbLine;
		Size size = new Size(480, 88);
		((Control)obj3).Size = size;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_TS, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(6, 23);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(38, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1;
		Label1.Text = "Tháng";
		((TextBox)txtMa_Ts).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Ts.AutoLookup = true;
		txtMa_Ts.AutoValid = false;
		((TextBoxBase)txtMa_Ts).BackColor = SystemColors.Info;
		((TextBox)txtMa_Ts).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Ts;
		location = new Point(68, 45);
		((Control)asTextBox).Location = location;
		txtMa_Ts.LookupCodeName = "MA_TS";
		((Control)txtMa_Ts).Name = "txtMa_Ts";
		txtMa_Ts.NameControl = lblTen_TS;
		AsTextBox asTextBox2 = txtMa_Ts;
		size = new Size(82, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Ts).TabIndex = 1;
		((Control)txtMa_Ts).Tag = "@pMa_Ts";
		txtMa_Ts.UseAutoCompleteSource = true;
		lblTen_TS.ImeMode = (ImeMode)0;
		Label obj4 = lblTen_TS;
		location = new Point(156, 49);
		((Control)obj4).Location = location;
		((Control)lblTen_TS).Name = "lblTen_TS";
		Label obj5 = lblTen_TS;
		size = new Size(318, 13);
		((Control)obj5).Size = size;
		((Control)lblTen_TS).TabIndex = 1025;
		lblTen_TS.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj6 = lblTk;
		location = new Point(6, 49);
		((Control)obj6).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj7 = lblTk;
		size = new Size(56, 13);
		((Control)obj7).Size = size;
		((Control)lblTk).TabIndex = 1024;
		lblTk.Text = "Mã tài sản";
		((ComboBox)cboKyBc).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyBc).FormattingEnabled = true;
		AsComboBox asComboBox = cboKyBc;
		location = new Point(68, 19);
		((Control)asComboBox).Location = location;
		((Control)cboKyBc).Name = "cboKyBc";
		AsComboBox asComboBox2 = cboKyBc;
		size = new Size(82, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(502, 135);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFAAdjustKHTSFilter";
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ValidData()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ngay2, AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks) <= 0)
		{
			CMessageBox.Show(50136);
			return false;
		}
		return base.ValidData();
	}

	private void frmFAAdjustKHTSFilter_Load(object sender, EventArgs e)
	{
		InitKyBaoCao();
		((ComboBox)cboKyBc).Text = Conversions.ToString(AsiaErp.Framework.Environment.get_PublicVariables("thang1"));
		if (((ListControl)cboKyBc).SelectedValue == null)
		{
			((ListControl)cboKyBc).SelectedValue = DateAndTime.Now.Month;
		}
		((Control)cboKyBc).Select();
	}

	private void InitKyBaoCao()
	{
		((ComboBox)cboKyBc).DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc, "10000");
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
	}
}
