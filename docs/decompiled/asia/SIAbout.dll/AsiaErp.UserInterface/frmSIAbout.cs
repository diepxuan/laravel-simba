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
public class frmSIAbout : frmCalc
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtNgay_ks")]
	private AsMaskedTextBox _txtNgay_ks;

	[AccessedThroughProperty("lblCompanyName")]
	private Label _lblCompanyName;

	[AccessedThroughProperty("txtServerName")]
	private TextBox _txtServerName;

	[AccessedThroughProperty("lblServerName")]
	private Label _lblServerName;

	[AccessedThroughProperty("txtDatabase")]
	private TextBox _txtDatabase;

	[AccessedThroughProperty("lblDatabase")]
	private Label _lblDatabase;

	[AccessedThroughProperty("txtProduct")]
	private TextBox _txtProduct;

	[AccessedThroughProperty("lblVersion")]
	private Label _lblVersion;

	[AccessedThroughProperty("txtCompanyID")]
	private TextBox _txtCompanyID;

	[AccessedThroughProperty("lblUnit")]
	private Label _lblUnit;

	[AccessedThroughProperty("lblNgay_ks")]
	private Label _lblNgay_ks;

	[AccessedThroughProperty("txtFinancialYear")]
	private TextBox _txtFinancialYear;

	[AccessedThroughProperty("FinancialYear")]
	private Label _FinancialYear;

	[AccessedThroughProperty("txtUserName")]
	private TextBox _txtUserName;

	[AccessedThroughProperty("lblUserName")]
	private Label _lblUserName;

	[AccessedThroughProperty("txtDBSys")]
	private TextBox _txtDBSys;

	[AccessedThroughProperty("lblSys")]
	private Label _lblSys;

	[AccessedThroughProperty("lblData")]
	private Label _lblData;

	[AccessedThroughProperty("lblFromTo")]
	private Label _lblFromTo;

	internal virtual AsMaskedTextBox txtNgay_ks
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ks;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_ks = value;
		}
	}

	internal virtual Label lblCompanyName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCompanyName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCompanyName = value;
		}
	}

	internal virtual TextBox txtServerName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtServerName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtServerName = value;
		}
	}

	internal virtual Label lblServerName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblServerName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblServerName = value;
		}
	}

	internal virtual TextBox txtDatabase
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDatabase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDatabase = value;
		}
	}

	internal virtual Label lblDatabase
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDatabase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDatabase = value;
		}
	}

	internal virtual TextBox txtProduct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtProduct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtProduct = value;
		}
	}

	internal virtual Label lblVersion
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblVersion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblVersion = value;
		}
	}

	internal virtual TextBox txtCompanyID
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCompanyID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCompanyID = value;
		}
	}

	internal virtual Label lblUnit
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblUnit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblUnit = value;
		}
	}

	internal virtual Label lblNgay_ks
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_ks;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_ks = value;
		}
	}

	internal virtual TextBox txtFinancialYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFinancialYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtFinancialYear = value;
		}
	}

	internal virtual Label FinancialYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _FinancialYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FinancialYear = value;
		}
	}

	internal virtual TextBox txtUserName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtUserName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtUserName = value;
		}
	}

	internal virtual Label lblUserName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblUserName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblUserName = value;
		}
	}

	internal virtual TextBox txtDBSys
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDBSys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDBSys = value;
		}
	}

	internal virtual Label lblSys
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSys = value;
		}
	}

	internal virtual Label lblData
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblData;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblData = value;
		}
	}

	internal virtual Label lblFromTo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFromTo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFromTo = value;
		}
	}

	public frmSIAbout(string menuid)
		: base(menuid)
	{
		((Form)this).Load += frmSIAbout_Load;
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		txtNgay_ks = new AsMaskedTextBox();
		lblCompanyName = new Label();
		txtServerName = new TextBox();
		lblServerName = new Label();
		txtDatabase = new TextBox();
		lblDatabase = new Label();
		txtProduct = new TextBox();
		lblVersion = new Label();
		txtCompanyID = new TextBox();
		lblUnit = new Label();
		lblNgay_ks = new Label();
		txtFinancialYear = new TextBox();
		FinancialYear = new Label();
		txtUserName = new TextBox();
		lblUserName = new Label();
		txtDBSys = new TextBox();
		lblData = new Label();
		lblSys = new Label();
		lblFromTo = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(12, 264);
		((Control)obj).Location = location;
		((ButtonBase)cmdCancel).Text = "&Thoát";
		((Control)gbInput).Controls.Add((Control)(object)lblFromTo);
		((Control)gbInput).Controls.Add((Control)(object)lblSys);
		((Control)gbInput).Controls.Add((Control)(object)lblData);
		((Control)gbInput).Controls.Add((Control)(object)txtDBSys);
		((Control)gbInput).Controls.Add((Control)(object)txtNgay_ks);
		((Control)gbInput).Controls.Add((Control)(object)lblCompanyName);
		((Control)gbInput).Controls.Add((Control)(object)txtServerName);
		((Control)gbInput).Controls.Add((Control)(object)lblServerName);
		((Control)gbInput).Controls.Add((Control)(object)txtDatabase);
		((Control)gbInput).Controls.Add((Control)(object)lblDatabase);
		((Control)gbInput).Controls.Add((Control)(object)txtProduct);
		((Control)gbInput).Controls.Add((Control)(object)lblVersion);
		((Control)gbInput).Controls.Add((Control)(object)txtCompanyID);
		((Control)gbInput).Controls.Add((Control)(object)lblUnit);
		((Control)gbInput).Controls.Add((Control)(object)lblNgay_ks);
		((Control)gbInput).Controls.Add((Control)(object)txtFinancialYear);
		((Control)gbInput).Controls.Add((Control)(object)FinancialYear);
		((Control)gbInput).Controls.Add((Control)(object)txtUserName);
		((Control)gbInput).Controls.Add((Control)(object)lblUserName);
		GroupBox obj2 = gbInput;
		location = new Point(12, 12);
		((Control)obj2).Location = location;
		GroupBox obj3 = gbInput;
		Size size = new Size(439, 243);
		((Control)obj3).Size = size;
		Button obj4 = cmdOK;
		location = new Point(195, 219);
		((Control)obj4).Location = location;
		((Control)cmdOK).Visible = false;
		((TextBoxBase)txtNgay_ks).BackColor = SystemColors.Control;
		txtNgay_ks.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ks).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ks;
		location = new Point(116, 71);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ks).Mask = "##/##/####";
		((Control)txtNgay_ks).Name = "txtNgay_ks";
		((MaskedTextBox)txtNgay_ks).PromptChar = ' ';
		((MaskedTextBox)txtNgay_ks).ReadOnly = true;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ks;
		size = new Size(83, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ks).TabIndex = 22;
		((MaskedTextBox)txtNgay_ks).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ks;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		Label obj5 = lblCompanyName;
		location = new Point(208, 101);
		((Control)obj5).Location = location;
		((Control)lblCompanyName).Name = "lblCompanyName";
		Label obj6 = lblCompanyName;
		size = new Size(224, 13);
		((Control)obj6).Size = size;
		((Control)lblCompanyName).TabIndex = 34;
		((TextBoxBase)txtServerName).BackColor = SystemColors.Control;
		TextBox obj7 = txtServerName;
		location = new Point(116, 149);
		((Control)obj7).Location = location;
		((Control)txtServerName).Name = "txtServerName";
		((TextBoxBase)txtServerName).ReadOnly = true;
		TextBox obj8 = txtServerName;
		size = new Size(150, 20);
		((Control)obj8).Size = size;
		((Control)txtServerName).TabIndex = 29;
		lblServerName.AutoSize = true;
		Label obj9 = lblServerName;
		location = new Point(11, 152);
		((Control)obj9).Location = location;
		((Control)lblServerName).Name = "lblServerName";
		Label obj10 = lblServerName;
		size = new Size(38, 13);
		((Control)obj10).Size = size;
		((Control)lblServerName).TabIndex = 33;
		lblServerName.Text = "Server";
		((TextBoxBase)txtDatabase).BackColor = SystemColors.Control;
		TextBox obj11 = txtDatabase;
		location = new Point(116, 175);
		((Control)obj11).Location = location;
		((Control)txtDatabase).Name = "txtDatabase";
		((TextBoxBase)txtDatabase).ReadOnly = true;
		TextBox obj12 = txtDatabase;
		size = new Size(150, 20);
		((Control)obj12).Size = size;
		((Control)txtDatabase).TabIndex = 26;
		lblDatabase.AutoSize = true;
		Label obj13 = lblDatabase;
		location = new Point(11, 178);
		((Control)obj13).Location = location;
		((Control)lblDatabase).Name = "lblDatabase";
		Label obj14 = lblDatabase;
		size = new Size(53, 13);
		((Control)obj14).Size = size;
		((Control)lblDatabase).TabIndex = 27;
		lblDatabase.Text = "Database";
		((TextBoxBase)txtProduct).BackColor = SystemColors.Control;
		TextBox obj15 = txtProduct;
		location = new Point(116, 123);
		((Control)obj15).Location = location;
		((Control)txtProduct).Name = "txtProduct";
		((TextBoxBase)txtProduct).ReadOnly = true;
		TextBox obj16 = txtProduct;
		size = new Size(150, 20);
		((Control)obj16).Size = size;
		((Control)txtProduct).TabIndex = 24;
		lblVersion.AutoSize = true;
		Label obj17 = lblVersion;
		location = new Point(11, 127);
		((Control)obj17).Location = location;
		((Control)lblVersion).Name = "lblVersion";
		Label obj18 = lblVersion;
		size = new Size(74, 13);
		((Control)obj18).Size = size;
		((Control)lblVersion).TabIndex = 32;
		lblVersion.Text = "Bản cập nhập";
		((TextBoxBase)txtCompanyID).BackColor = SystemColors.Control;
		TextBox obj19 = txtCompanyID;
		location = new Point(116, 97);
		((Control)obj19).Location = location;
		((Control)txtCompanyID).Name = "txtCompanyID";
		((TextBoxBase)txtCompanyID).ReadOnly = true;
		TextBox obj20 = txtCompanyID;
		size = new Size(83, 20);
		((Control)obj20).Size = size;
		((Control)txtCompanyID).TabIndex = 23;
		lblUnit.AutoSize = true;
		Label obj21 = lblUnit;
		location = new Point(11, 101);
		((Control)obj21).Location = location;
		((Control)lblUnit).Name = "lblUnit";
		Label obj22 = lblUnit;
		size = new Size(38, 13);
		((Control)obj22).Size = size;
		((Control)lblUnit).TabIndex = 28;
		lblUnit.Text = "Đơn vị";
		lblNgay_ks.AutoSize = true;
		Label obj23 = lblNgay_ks;
		location = new Point(11, 75);
		((Control)obj23).Location = location;
		((Control)lblNgay_ks).Name = "lblNgay_ks";
		Label obj24 = lblNgay_ks;
		size = new Size(73, 13);
		((Control)obj24).Size = size;
		((Control)lblNgay_ks).TabIndex = 31;
		lblNgay_ks.Text = "Ngày khóa sổ";
		((TextBoxBase)txtFinancialYear).BackColor = SystemColors.Control;
		TextBox obj25 = txtFinancialYear;
		location = new Point(116, 45);
		((Control)obj25).Location = location;
		((Control)txtFinancialYear).Name = "txtFinancialYear";
		((TextBoxBase)txtFinancialYear).ReadOnly = true;
		TextBox obj26 = txtFinancialYear;
		size = new Size(83, 20);
		((Control)obj26).Size = size;
		((Control)txtFinancialYear).TabIndex = 21;
		FinancialYear.AutoSize = true;
		Label financialYear = FinancialYear;
		location = new Point(11, 49);
		((Control)financialYear).Location = location;
		((Control)FinancialYear).Name = "FinancialYear";
		Label financialYear2 = FinancialYear;
		size = new Size(74, 13);
		((Control)financialYear2).Size = size;
		((Control)FinancialYear).TabIndex = 30;
		FinancialYear.Text = "Năm tài chính";
		((TextBoxBase)txtUserName).BackColor = SystemColors.Control;
		TextBox obj27 = txtUserName;
		location = new Point(116, 19);
		((Control)obj27).Location = location;
		((Control)txtUserName).Name = "txtUserName";
		((TextBoxBase)txtUserName).ReadOnly = true;
		TextBox obj28 = txtUserName;
		size = new Size(83, 20);
		((Control)obj28).Size = size;
		((Control)txtUserName).TabIndex = 20;
		lblUserName.AutoSize = true;
		Label obj29 = lblUserName;
		location = new Point(11, 22);
		((Control)obj29).Location = location;
		((Control)lblUserName).Name = "lblUserName";
		Label obj30 = lblUserName;
		size = new Size(76, 13);
		((Control)obj30).Size = size;
		((Control)lblUserName).TabIndex = 25;
		lblUserName.Text = "Người sử dụng";
		((TextBoxBase)txtDBSys).BackColor = SystemColors.Control;
		TextBox obj31 = txtDBSys;
		location = new Point(116, 201);
		((Control)obj31).Location = location;
		((Control)txtDBSys).Name = "txtDBSys";
		((TextBoxBase)txtDBSys).ReadOnly = true;
		TextBox obj32 = txtDBSys;
		size = new Size(150, 20);
		((Control)obj32).Size = size;
		((Control)txtDBSys).TabIndex = 36;
		lblData.AutoSize = true;
		Label obj33 = lblData;
		location = new Point(80, 178);
		((Control)obj33).Location = location;
		((Control)lblData).Name = "lblData";
		Label obj34 = lblData;
		size = new Size(30, 13);
		((Control)obj34).Size = size;
		((Control)lblData).TabIndex = 37;
		lblData.Text = "Data";
		lblSys.AutoSize = true;
		Label obj35 = lblSys;
		location = new Point(80, 203);
		((Control)obj35).Location = location;
		((Control)lblSys).Name = "lblSys";
		Label obj36 = lblSys;
		size = new Size(24, 13);
		((Control)obj36).Size = size;
		((Control)lblSys).TabIndex = 38;
		lblSys.Text = "Sys";
		Label obj37 = lblFromTo;
		location = new Point(205, 45);
		((Control)obj37).Location = location;
		((Control)lblFromTo).Name = "lblFromTo";
		Label obj38 = lblFromTo;
		size = new Size(227, 23);
		((Control)obj38).Size = size;
		((Control)lblFromTo).TabIndex = 39;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(463, 296);
		((Form)this).ClientSize = size;
		((Form)this).ControlBox = false;
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Control)this).Name = "frmSIAbout";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmSIAbout_Load(object sender, EventArgs e)
	{
		txtUserName.Text = SystemInformations.UserName;
		txtFinancialYear.Text = Conversions.ToString(SystemInformations.FinancialYear);
		lblFromTo.Text = "01/01/" + Convert.ToString(SystemInformations.FinancialYear) + " - 31/12/" + Convert.ToString(SystemInformations.FinancialYear);
		txtProduct.Text = SystemInformations.ProductName + " " + SystemInformations.ProductVersion;
		txtCompanyID.Text = CompanyInformations.CompanyID;
		lblCompanyName.Text = CompanyInformations.CompanyName;
		txtNgay_ks.Value = AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks;
		txtServerName.Text = DatabaseConfigurations.ServerName;
		txtDatabase.Text = DatabaseConfigurations.DATADatabaseName;
		txtDBSys.Text = DatabaseConfigurations.SYSDatabaseName;
	}
}
