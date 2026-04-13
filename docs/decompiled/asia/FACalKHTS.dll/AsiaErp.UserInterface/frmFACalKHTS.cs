using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmFACalKHTS : frmCalc
{
	private IContainer components;

	[AccessedThroughProperty("lblThang")]
	private Label _lblThang;

	[AccessedThroughProperty("txtMa_Ts")]
	private AsTextBox _txtMa_Ts;

	[AccessedThroughProperty("lblTen_TS")]
	private Label _lblTen_TS;

	[AccessedThroughProperty("lblMa_TS")]
	private Label _lblMa_TS;

	[AccessedThroughProperty("cboKyBc")]
	private AsComboBox _cboKyBc;

	private ResourceManager rm;

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

	private virtual AsTextBox txtMa_Ts
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

	private virtual Label lblMa_TS
	{
		get
		{
			return _lblMa_TS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_TS = value;
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		lblThang = new Label();
		txtMa_Ts = new AsTextBox();
		lblTen_TS = new Label();
		lblMa_TS = new Label();
		cboKyBc = new AsComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 103);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 3;
		((Control)gbInput).Controls.Add((Control)(object)cboKyBc);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_Ts);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_TS);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_TS);
		((Control)gbInput).Controls.Add((Control)(object)lblThang);
		GroupBox obj2 = gbInput;
		Size size = new Size(480, 88);
		((Control)obj2).Size = size;
		((Control)gbInput).TabIndex = 0;
		Button obj3 = cmdOK;
		location = new Point(12, 103);
		((Control)obj3).Location = location;
		((Control)cmdOK).TabIndex = 2;
		((ButtonBase)cmdOK).Text = "&Nhận";
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
		Label obj6 = lblTen_TS;
		location = new Point(156, 49);
		((Control)obj6).Location = location;
		((Control)lblTen_TS).Name = "lblTen_TS";
		Label obj7 = lblTen_TS;
		size = new Size(318, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_TS).TabIndex = 1025;
		lblTen_TS.TextAlign = (ContentAlignment)16;
		lblMa_TS.AutoSize = true;
		lblMa_TS.ImeMode = (ImeMode)0;
		Label obj8 = lblMa_TS;
		location = new Point(6, 49);
		((Control)obj8).Location = location;
		((Control)lblMa_TS).Name = "lblMa_TS";
		Label obj9 = lblMa_TS;
		size = new Size(56, 13);
		((Control)obj9).Size = size;
		((Control)lblMa_TS).TabIndex = 1024;
		lblMa_TS.Text = "Mã tài sản";
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
		size = new Size(502, 135);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFACalKHTS";
		((Form)this).Text = "Tính khấu hao tài sản cố định";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public frmFACalKHTS(string MenuId)
		: base(MenuId)
	{
		InitializeComponent();
	}

	protected override bool Execute()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(SystemInformations.FinancialYear);
		arrayList.Add(Conversions.ToInteger(((ComboBox)cboKyBc).Text));
		arrayList.Add(((TextBox)txtMa_Ts).Text);
		bool flag = false;
		try
		{
			flag = Conversions.ToBoolean(MyController.Execute(arrayList.ToArray()));
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
		AsiaErp.Framework.Environment.set_PublicVariables("thang1", (object)((ComboBox)cboKyBc).Text);
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
