using System;
using System.Collections;
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
public class frmFADelCC2GL : frmCalc
{
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
		get
		{
			return _lblThang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblThang = value;
		}
	}

	internal virtual Label lblNam
	{
		get
		{
			return _lblNam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNam = value;
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		lblThang = new Label();
		lblNam = new Label();
		txtNam = new AsTextNumeric();
		cboKyBc = new AsComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 103);
		((Control)obj).Location = location;
		((Control)gbInput).Controls.Add((Control)(object)cboKyBc);
		((Control)gbInput).Controls.Add((Control)(object)lblNam);
		((Control)gbInput).Controls.Add((Control)(object)txtNam);
		((Control)gbInput).Controls.Add((Control)(object)lblThang);
		GroupBox obj2 = gbInput;
		Size size = new Size(480, 88);
		((Control)obj2).Size = size;
		Button obj3 = cmdOK;
		location = new Point(12, 103);
		((Control)obj3).Location = location;
		lblThang.AutoSize = true;
		Label obj4 = lblThang;
		location = new Point(6, 22);
		((Control)obj4).Location = location;
		((Control)lblThang).Name = "lblThang";
		Label obj5 = lblThang;
		size = new Size(38, 13);
		((Control)obj5).Size = size;
		((Control)lblThang).TabIndex = 1;
		lblThang.Text = "Tháng";
		lblNam.AutoSize = true;
		Label obj6 = lblNam;
		location = new Point(6, 51);
		((Control)obj6).Location = location;
		((Control)lblNam).Name = "lblNam";
		Label obj7 = lblNam;
		size = new Size(29, 13);
		((Control)obj7).Size = size;
		((Control)lblNam).TabIndex = 3;
		lblNam.Text = "Năm";
		((TextBoxBase)txtNam).BackColor = Color.White;
		txtNam.DecimalSymbol = ".";
		((Control)txtNam).Enabled = false;
		txtNam.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtNam;
		location = new Point(68, 48);
		((Control)asTextNumeric).Location = location;
		txtNam.Mask = "####";
		((Control)txtNam).Name = "txtNam";
		((TextBoxBase)txtNam).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtNam;
		size = new Size(82, 20);
		((Control)asTextNumeric2).Size = size;
		txtNam.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNam).TabIndex = 1;
		((TextBox)txtNam).Text = "0";
		((TextBox)txtNam).TextAlign = (HorizontalAlignment)1;
		txtNam.Value = 0;
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
		((Control)this).Name = "frmFADelCC2GL";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public frmFADelCC2GL(string MenuId)
		: base(MenuId)
	{
		InitializeComponent();
	}

	protected override bool Execute()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(MyMenuInfo.par1);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNam.Value));
		arrayList.Add(((ComboBox)cboKyBc).Text);
		arrayList.Add(0);
		bool flag = false;
		try
		{
			flag = Conversions.ToBoolean(MyController.Execute(arrayList.ToArray()));
			AsiaErp.Framework.Environment.set_PublicVariables("Thang1", (object)((ComboBox)cboKyBc).Text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			CMessageBox.Show(50010);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		if (flag)
		{
			CMessageBox.Show(50015);
		}
		else
		{
			CMessageBox.Show(50010);
		}
		((Form)this).Close();
		return flag;
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

	protected override void InitComponents()
	{
		base.InitComponents();
		InitKyBaoCao();
		txtNam.Value = SystemInformations.FinancialYear;
		((ComboBox)cboKyBc).Text = Conversions.ToString(AsiaErp.Framework.Environment.get_PublicVariables("Thang1"));
		if (((ComboBox)cboKyBc).Text == null)
		{
			((ComboBox)cboKyBc).Text = Conversions.ToString(DateAndTime.Now.Month);
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
