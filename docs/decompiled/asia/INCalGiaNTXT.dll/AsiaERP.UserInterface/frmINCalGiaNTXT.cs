using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmINCalGiaNTXT : frmCalc
{
	private IContainer components;

	[AccessedThroughProperty("lblThang")]
	private Label _lblThang;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("lblTen_nhvt")]
	private Label _lblTen_nhvt;

	[AccessedThroughProperty("lblNh_vt")]
	private Label _lblNh_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("txtMa_nhvt")]
	private AsTextBox _txtMa_nhvt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("bgWorker")]
	private BackgroundWorker _bgWorker;

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

	internal virtual AsTextBox txtMa_kho
	{
		get
		{
			return _txtMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_kho = value;
		}
	}

	internal virtual Label lblMa_kho
	{
		get
		{
			return _lblMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_kho = value;
		}
	}

	internal virtual Label lblTen_kho
	{
		get
		{
			return _lblTen_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_kho = value;
		}
	}

	internal virtual Label lblTen_nhvt
	{
		get
		{
			return _lblTen_nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_nhvt = value;
		}
	}

	internal virtual Label lblNh_vt
	{
		get
		{
			return _lblNh_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNh_vt = value;
		}
	}

	internal virtual Label lblTen_vt
	{
		get
		{
			return _lblTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_vt = value;
		}
	}

	internal virtual Label lblMa_vt
	{
		get
		{
			return _lblMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_vt = value;
		}
	}

	internal virtual AsTextBox txtMa_nhvt
	{
		get
		{
			return _txtMa_nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_nhvt = value;
		}
	}

	internal virtual AsTextBox txtMa_vt
	{
		get
		{
			return _txtMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_vt = value;
		}
	}

	internal virtual BackgroundWorker bgWorker
	{
		get
		{
			return _bgWorker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_bgWorker = value;
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

	public frmINCalGiaNTXT(string MenuID)
		: base(MenuID)
	{
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		lblThang = new Label();
		txtMa_kho = new AsTextBox();
		lblTen_kho = new Label();
		lblMa_kho = new Label();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		lblMa_vt = new Label();
		txtMa_nhvt = new AsTextBox();
		lblTen_nhvt = new Label();
		lblNh_vt = new Label();
		bgWorker = new BackgroundWorker();
		cboKyBc = new AsComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 142);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		((Control)gbInput).Controls.Add((Control)(object)cboKyBc);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_nhvt);
		((Control)gbInput).Controls.Add((Control)(object)lblNh_vt);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_vt);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_vt);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_nhvt);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_kho);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_kho);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_kho);
		((Control)gbInput).Controls.Add((Control)(object)lblThang);
		GroupBox obj2 = gbInput;
		Size size = new Size(456, 127);
		((Control)obj2).Size = size;
		((Control)gbInput).TabIndex = 0;
		Button obj3 = cmdOK;
		location = new Point(12, 142);
		((Control)obj3).Location = location;
		((Control)cmdOK).TabIndex = 1;
		lblThang.AutoSize = true;
		Label obj4 = lblThang;
		location = new Point(17, 22);
		((Control)obj4).Location = location;
		((Control)lblThang).Name = "lblThang";
		Label obj5 = lblThang;
		size = new Size(41, 13);
		((Control)obj5).Size = size;
		((Control)lblThang).TabIndex = 0;
		lblThang.Text = "Kỳ tính";
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_kho;
		location = new Point(93, 44);
		((Control)asTextBox).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		AsTextBox asTextBox2 = txtMa_kho;
		size = new Size(118, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_kho).TabIndex = 1;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		Label obj6 = lblTen_kho;
		location = new Point(223, 46);
		((Control)obj6).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj7 = lblTen_kho;
		size = new Size(227, 17);
		((Control)obj7).Size = size;
		((Control)lblTen_kho).TabIndex = 4;
		lblMa_kho.AutoSize = true;
		Label obj8 = lblMa_kho;
		location = new Point(17, 48);
		((Control)obj8).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj9 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj9).Size = size;
		((Control)lblMa_kho).TabIndex = 3;
		lblMa_kho.Text = "Mã kho";
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_vt;
		location = new Point(93, 96);
		((Control)asTextBox3).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox4 = txtMa_vt;
		size = new Size(118, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_vt).TabIndex = 3;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		Label obj10 = lblTen_vt;
		location = new Point(223, 98);
		((Control)obj10).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj11 = lblTen_vt;
		size = new Size(227, 17);
		((Control)obj11).Size = size;
		((Control)lblTen_vt).TabIndex = 4;
		lblMa_vt.AutoSize = true;
		Label obj12 = lblMa_vt;
		location = new Point(17, 100);
		((Control)obj12).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj13 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj13).Size = size;
		((Control)lblMa_vt).TabIndex = 3;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_nhvt.AutoLookup = true;
		txtMa_nhvt.AutoValid = false;
		((TextBoxBase)txtMa_nhvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_nhvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_nhvt;
		location = new Point(93, 70);
		((Control)asTextBox5).Location = location;
		txtMa_nhvt.LookupCodeName = "MA_NHVT";
		((Control)txtMa_nhvt).Name = "txtMa_nhvt";
		txtMa_nhvt.NameControl = lblTen_nhvt;
		AsTextBox asTextBox6 = txtMa_nhvt;
		size = new Size(118, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_nhvt).TabIndex = 2;
		((Control)txtMa_nhvt).Tag = "MA_NHVT";
		txtMa_nhvt.UseAutoCompleteSource = true;
		Label obj14 = lblTen_nhvt;
		location = new Point(223, 72);
		((Control)obj14).Location = location;
		((Control)lblTen_nhvt).Name = "lblTen_nhvt";
		Label obj15 = lblTen_nhvt;
		size = new Size(227, 17);
		((Control)obj15).Size = size;
		((Control)lblTen_nhvt).TabIndex = 4;
		lblNh_vt.AutoSize = true;
		Label obj16 = lblNh_vt;
		location = new Point(17, 74);
		((Control)obj16).Location = location;
		((Control)lblNh_vt).Name = "lblNh_vt";
		Label obj17 = lblNh_vt;
		size = new Size(65, 13);
		((Control)obj17).Size = size;
		((Control)lblNh_vt).TabIndex = 3;
		lblNh_vt.Text = "Nhóm vật tư";
		((ComboBox)cboKyBc).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyBc).FormattingEnabled = true;
		AsComboBox asComboBox = cboKyBc;
		location = new Point(93, 18);
		((Control)asComboBox).Location = location;
		((Control)cboKyBc).Name = "cboKyBc";
		AsComboBox asComboBox2 = cboKyBc;
		size = new Size(118, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(478, 174);
		((Form)this).ClientSize = size;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmINCalGiaNTXT";
		((Form)this).Text = "Tính giá nhập trước xuất trước";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
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
		return true;
	}

	protected override bool Execute()
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		((Control)cmdCancel).Enabled = false;
		((Control)cmdOK).Enabled = false;
		bool result = false;
		try
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(((ComboBox)cboKyBc).Text);
			arrayList.Add(SystemInformations.FinancialYear);
			arrayList.Add(((TextBox)txtMa_vt).Text.Trim());
			arrayList.Add(((TextBox)txtMa_nhvt).Text.Trim());
			arrayList.Add(((TextBox)txtMa_kho).Text.Trim());
			switch (AsiaErp.Framework.Environment.GetCalcInformation(MyMenuID).rettype)
			{
			case Commons.QueryReturnType.NONE_QUERY:
				result = Conversions.ToBoolean(base.MyController.Execute(arrayList.ToArray()));
				break;
			case Commons.QueryReturnType.DATATABLE:
				ResultSource = (DataTable)base.MyController.Execute(arrayList.ToArray());
				break;
			}
			CMessageBox.Show(50015);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			result = false;
			CMessageBox.Show(50010);
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
		return result;
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
	}

	private void InitKyBaoCao()
	{
		((ComboBox)cboKyBc).DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc, "10000");
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
	}
}
