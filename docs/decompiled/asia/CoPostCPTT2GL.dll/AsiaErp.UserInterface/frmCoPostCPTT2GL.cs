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
public class frmCoPostCPTT2GL : frmCalc
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("cboKyBc")]
	private AsComboBox _cboKyBc;

	[AccessedThroughProperty("txtNam")]
	private AsTextNumeric _txtNam;

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
		Label1 = new Label();
		Label2 = new Label();
		cboKyBc = new AsComboBox();
		txtNam = new AsTextNumeric();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 93);
		((Control)obj).Location = location;
		((Control)gbInput).Controls.Add((Control)(object)txtNam);
		((Control)gbInput).Controls.Add((Control)(object)cboKyBc);
		((Control)gbInput).Controls.Add((Control)(object)Label2);
		((Control)gbInput).Controls.Add((Control)(object)Label1);
		GroupBox obj2 = gbInput;
		Size size = new Size(480, 78);
		((Control)obj2).Size = size;
		Button obj3 = cmdOK;
		location = new Point(12, 93);
		((Control)obj3).Location = location;
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
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(6, 49);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(29, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 3;
		Label2.Text = "Năm";
		((ComboBox)cboKyBc).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyBc).FormattingEnabled = true;
		AsComboBox asComboBox = cboKyBc;
		location = new Point(68, 19);
		((Control)asComboBox).Location = location;
		((Control)cboKyBc).Name = "cboKyBc";
		AsComboBox asComboBox2 = cboKyBc;
		size = new Size(88, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		((TextBoxBase)txtNam).BackColor = Color.White;
		txtNam.DecimalSymbol = ".";
		((Control)txtNam).Enabled = false;
		txtNam.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtNam;
		location = new Point(68, 45);
		((Control)asTextNumeric).Location = location;
		txtNam.Mask = "####";
		((Control)txtNam).Name = "txtNam";
		((TextBoxBase)txtNam).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtNam;
		size = new Size(88, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtNam).TabIndex = 1;
		((TextBox)txtNam).Text = "0";
		((TextBox)txtNam).TextAlign = (HorizontalAlignment)1;
		txtNam.Value = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(502, 125);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFAPostCC2GL";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public frmCoPostCPTT2GL(string MenuId)
		: base(MenuId)
	{
		InitializeComponent();
	}

	protected override bool Execute()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(((TextBox)txtNam).Text);
		arrayList.Add(((ComboBox)cboKyBc).Text);
		arrayList.Add(MyMenuInfo.par1);
		bool flag = true;
		try
		{
			flag = Conversions.ToBoolean(MyController.Execute(arrayList.ToArray()));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			MessageBox.Show(ex2.Message);
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
		((ComboBox)cboKyBc).Text = Conversions.ToString(AsiaErp.Framework.Environment.get_PublicVariables("thang1"));
		((TextBox)txtNam).Text = Conversions.ToString(SystemInformations.FinancialYear);
		if (((ListControl)cboKyBc).SelectedValue == null)
		{
			((ListControl)cboKyBc).SelectedValue = DateAndTime.Now.Month;
		}
	}

	private void InitKyBaoCao()
	{
		((ComboBox)cboKyBc).DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc, "10000");
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
	}
}
