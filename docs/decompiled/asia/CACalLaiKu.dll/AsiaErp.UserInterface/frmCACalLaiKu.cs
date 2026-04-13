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
public class frmCACalLaiKu : frmCalc
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtMa_ku")]
	private AsTextBox _txtMa_ku;

	[AccessedThroughProperty("lblTen_TS")]
	private Label _lblTen_TS;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("cmbFunction")]
	private AsComboBox _cmbFunction;

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

	private virtual AsTextBox txtMa_ku
	{
		get
		{
			return _txtMa_ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_ku = value;
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

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual AsComboBox cmbFunction
	{
		get
		{
			return _cmbFunction;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cmbFunction = value;
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		Label1 = new Label();
		txtMa_ku = new AsTextBox();
		lblTen_TS = new Label();
		lblTk = new Label();
		cmbFunction = new AsComboBox();
		Label2 = new Label();
		cboKyBc = new AsComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 230);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		((Control)gbInput).Controls.Add((Control)(object)cboKyBc);
		((Control)gbInput).Controls.Add((Control)(object)Label2);
		((Control)gbInput).Controls.Add((Control)(object)cmbFunction);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_ku);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_TS);
		((Control)gbInput).Controls.Add((Control)(object)lblTk);
		((Control)gbInput).Controls.Add((Control)(object)Label1);
		GroupBox obj2 = gbInput;
		Size size = new Size(480, 215);
		((Control)obj2).Size = size;
		((Control)gbInput).TabIndex = 0;
		Button obj3 = cmdOK;
		location = new Point(12, 230);
		((Control)obj3).Location = location;
		((Control)cmdOK).TabIndex = 1;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(11, 50);
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
		location = new Point(81, 72);
		((Control)asTextBox).Location = location;
		txtMa_ku.LookupCodeName = "MA_KU";
		((Control)txtMa_ku).Name = "txtMa_ku";
		txtMa_ku.NameControl = lblTen_TS;
		AsTextBox asTextBox2 = txtMa_ku;
		size = new Size(82, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_ku).TabIndex = 2;
		((Control)txtMa_ku).Tag = "@pMa_KU";
		txtMa_ku.UseAutoCompleteSource = true;
		lblTen_TS.ImeMode = (ImeMode)0;
		Label obj4 = lblTen_TS;
		location = new Point(169, 76);
		((Control)obj4).Location = location;
		((Control)lblTen_TS).Name = "lblTen_TS";
		Label obj5 = lblTen_TS;
		size = new Size(306, 13);
		((Control)obj5).Size = size;
		((Control)lblTen_TS).TabIndex = 1025;
		lblTen_TS.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj6 = lblTk;
		location = new Point(11, 76);
		((Control)obj6).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj7 = lblTk;
		size = new Size(64, 13);
		((Control)obj7).Size = size;
		((Control)lblTk).TabIndex = 1024;
		lblTk.Text = "Mã khế ước";
		((ComboBox)cmbFunction).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cmbFunction).FormattingEnabled = true;
		((ComboBox)cmbFunction).Items.AddRange(new object[3] { "1 - Tính lãi khế ước - chuyển sang sổ cái", "2 - Tính lãi khế ước - không chuyển sổ cái", "3 - Xóa lãi khế ước" });
		AsComboBox asComboBox = cmbFunction;
		location = new Point(81, 19);
		((Control)asComboBox).Location = location;
		((Control)cmbFunction).Name = "cmbFunction";
		AsComboBox asComboBox2 = cmbFunction;
		size = new Size(259, 21);
		((Control)asComboBox2).Size = size;
		((Control)cmbFunction).TabIndex = 0;
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(11, 22);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(59, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 1027;
		Label2.Text = "Chức năng";
		((ComboBox)cboKyBc).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyBc).FormattingEnabled = true;
		AsComboBox asComboBox3 = cboKyBc;
		location = new Point(81, 46);
		((Control)asComboBox3).Location = location;
		((Control)cboKyBc).Name = "cboKyBc";
		AsComboBox asComboBox4 = cboKyBc;
		size = new Size(82, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboKyBc).TabIndex = 1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(502, 262);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCACalLaiKu";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public frmCACalLaiKu(string MenuId)
		: base(MenuId)
	{
		InitializeComponent();
		((Form)this).Text = MyMenuInfo.bar;
		((ComboBox)cmbFunction).SelectedIndex = 0;
		CalcController calcControllerByMenuID = ControllerFactory.GetCalcControllerByMenuID(MenuId);
	}

	protected override bool Execute()
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(((ComboBox)cmbFunction).Text.Trim().Substring(0, 1));
		arrayList.Add(((ComboBox)cboKyBc).Text);
		arrayList.Add(SystemInformations.FinancialYear);
		arrayList.Add(MyMenuInfo.par1);
		arrayList.Add(((TextBox)txtMa_ku).Text);
		arrayList.Add(SystemInformations.UserName);
		int num;
		try
		{
			num = Conversions.ToInteger(base.MyController.Execute(arrayList.ToArray()));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		if (num != 0)
		{
			CMessageBox.Show(num);
			return false;
		}
		CMessageBox.Show(50015);
		return true;
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
		((Control)cmbFunction).Focus();
	}

	private void InitKyBaoCao()
	{
		((ComboBox)cboKyBc).DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc, "10000");
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
	}
}
