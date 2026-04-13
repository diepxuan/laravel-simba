using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using AsiaLicenseCommon;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

[DesignerGenerated]
public class frmLogin : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cboFinanceYear")]
	private ComboBox _cboFinanceYear;

	[AccessedThroughProperty("lblFinanceYear")]
	private Label _lblFinanceYear;

	[AccessedThroughProperty("cboComanyName")]
	private ComboBox _cboComanyName;

	[AccessedThroughProperty("lblCompanyName")]
	private Label _lblCompanyName;

	[AccessedThroughProperty("lblPassword")]
	private Label _lblPassword;

	[AccessedThroughProperty("lblUserName")]
	private Label _lblUserName;

	[AccessedThroughProperty("txtPassword")]
	private TextBox _txtPassword;

	[AccessedThroughProperty("txtUserName")]
	private TextBox _txtUserName;

	[AccessedThroughProperty("cmdLogin")]
	private Button _cmdLogin;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("panelLogo")]
	private Panel _panelLogo;

	[AccessedThroughProperty("cmdQuit")]
	private Button _cmdQuit;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("btnTeamviewer")]
	private Button _btnTeamviewer;

	[AccessedThroughProperty("cmdOption")]
	private Button _cmdOption;

	[AccessedThroughProperty("gbOption")]
	private GroupBox _gbOption;

	[AccessedThroughProperty("cboLanguage")]
	private ComboBox _cboLanguage;

	[AccessedThroughProperty("lblLanguage")]
	private Label _lblLanguage;

	internal bool f_isOk;

	private string strUserName;

	private string strFullName;

	private string strCompanyID;

	private string strCompanyName;

	private string strHeadCompanyName;

	private string strAddress;

	private string strTel;

	private string strEmail;

	private string strFax;

	private int intFinanceYear;

	private string strPassword;

	private DataTable oTblCompany;

	private string strTen_qd_cdkt;

	private string strQd_cdkt;

	private string strDirector_Name;

	private string strChief_Accountant_Name;

	private string strMa_thue;

	private DataTable oTblLanguage;

	private string f_oldUserName;

	private const string LOGIN_TITLE_EN_US = "Login";

	private bool isLoading;

	internal virtual ComboBox cboFinanceYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboFinanceYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboFinanceYear = value;
		}
	}

	internal virtual Label lblFinanceYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFinanceYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFinanceYear = value;
		}
	}

	internal virtual ComboBox cboComanyName
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboComanyName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboComanyName = value;
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

	internal virtual Label lblPassword
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPassword = value;
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

	internal virtual TextBox txtPassword
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtUserName_Validated;
			if (_txtPassword != null)
			{
				((Control)_txtPassword).Validated -= eventHandler;
			}
			_txtPassword = value;
			if (_txtPassword != null)
			{
				((Control)_txtPassword).Validated += eventHandler;
			}
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
			EventHandler eventHandler = txtUserName_Validated;
			if (_txtUserName != null)
			{
				((Control)_txtUserName).Validated -= eventHandler;
			}
			_txtUserName = value;
			if (_txtUserName != null)
			{
				((Control)_txtUserName).Validated += eventHandler;
			}
		}
	}

	internal virtual Button cmdLogin
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdLogin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdLogin_Click;
			if (_cmdLogin != null)
			{
				((Control)_cmdLogin).Click -= eventHandler;
			}
			_cmdLogin = value;
			if (_cmdLogin != null)
			{
				((Control)_cmdLogin).Click += eventHandler;
			}
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Panel panelLogo
	{
		[DebuggerNonUserCode]
		get
		{
			return _panelLogo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_panelLogo = value;
		}
	}

	protected internal virtual Button cmdQuit
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdQuit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdQuit_Click;
			if (_cmdQuit != null)
			{
				((Control)_cmdQuit).Click -= eventHandler;
			}
			_cmdQuit = value;
			if (_cmdQuit != null)
			{
				((Control)_cmdQuit).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual Button btnTeamviewer
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnTeamviewer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnTeamviewer_Click;
			if (_btnTeamviewer != null)
			{
				((Control)_btnTeamviewer).Click -= eventHandler;
			}
			_btnTeamviewer = value;
			if (_btnTeamviewer != null)
			{
				((Control)_btnTeamviewer).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdOption
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOption_Click;
			if (_cmdOption != null)
			{
				((Control)_cmdOption).Click -= eventHandler;
			}
			_cmdOption = value;
			if (_cmdOption != null)
			{
				((Control)_cmdOption).Click += eventHandler;
			}
		}
	}

	internal virtual GroupBox gbOption
	{
		[DebuggerNonUserCode]
		get
		{
			return _gbOption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_gbOption = value;
		}
	}

	internal virtual ComboBox cboLanguage
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLanguage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboLanguage_SelectedIndexChanged;
			if (_cboLanguage != null)
			{
				_cboLanguage.SelectedIndexChanged -= eventHandler;
			}
			_cboLanguage = value;
			if (_cboLanguage != null)
			{
				_cboLanguage.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblLanguage
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLanguage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLanguage = value;
		}
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
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

	public frmLogin()
	{
		__ENCAddToList(this);
		f_isOk = false;
		strUserName = "";
		strFullName = "";
		strCompanyID = "";
		strCompanyName = "";
		strHeadCompanyName = "";
		strAddress = "";
		strTel = "";
		strEmail = "";
		strFax = "";
		intFinanceYear = 0;
		strPassword = "";
		strTen_qd_cdkt = "";
		strQd_cdkt = "";
		strDirector_Name = "";
		strChief_Accountant_Name = "";
		strMa_thue = "";
		f_oldUserName = "";
		isLoading = true;
		Application.EnableVisualStyles();
		InitializeComponent();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected O, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected O, but got Unknown
		//IL_0b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmLogin));
		cboFinanceYear = new ComboBox();
		lblFinanceYear = new Label();
		cboComanyName = new ComboBox();
		lblCompanyName = new Label();
		lblPassword = new Label();
		lblUserName = new Label();
		txtPassword = new TextBox();
		txtUserName = new TextBox();
		GroupBox1 = new GroupBox();
		PictureBox1 = new PictureBox();
		cmdQuit = new Button();
		panelLogo = new Panel();
		cmdLogin = new Button();
		btnTeamviewer = new Button();
		cmdOption = new Button();
		gbOption = new GroupBox();
		cboLanguage = new ComboBox();
		lblLanguage = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)gbOption).SuspendLayout();
		((Control)this).SuspendLayout();
		cboFinanceYear.DropDownStyle = (ComboBoxStyle)2;
		ComboBox obj = cboFinanceYear;
		Point location = new Point(243, 138);
		((Control)obj).Location = location;
		((Control)cboFinanceYear).Name = "cboFinanceYear";
		ComboBox obj2 = cboFinanceYear;
		Size size = new Size(192, 21);
		((Control)obj2).Size = size;
		((Control)cboFinanceYear).TabIndex = 2;
		lblFinanceYear.AutoSize = true;
		Label obj3 = lblFinanceYear;
		location = new Point(124, 141);
		((Control)obj3).Location = location;
		((Control)lblFinanceYear).Name = "lblFinanceYear";
		Label obj4 = lblFinanceYear;
		size = new Size(74, 13);
		((Control)obj4).Size = size;
		((Control)lblFinanceYear).TabIndex = 29;
		lblFinanceYear.Text = "Năm tài chính";
		cboComanyName.DropDownStyle = (ComboBoxStyle)2;
		ComboBox obj5 = cboComanyName;
		location = new Point(243, 160);
		((Control)obj5).Location = location;
		((Control)cboComanyName).Name = "cboComanyName";
		ComboBox obj6 = cboComanyName;
		size = new Size(192, 21);
		((Control)obj6).Size = size;
		((Control)cboComanyName).TabIndex = 3;
		lblCompanyName.AutoSize = true;
		Label obj7 = lblCompanyName;
		location = new Point(124, 163);
		((Control)obj7).Location = location;
		((Control)lblCompanyName).Name = "lblCompanyName";
		Label obj8 = lblCompanyName;
		size = new Size(43, 13);
		((Control)obj8).Size = size;
		((Control)lblCompanyName).TabIndex = 28;
		lblCompanyName.Text = "Công ty";
		lblPassword.AutoSize = true;
		Label obj9 = lblPassword;
		location = new Point(124, 114);
		((Control)obj9).Location = location;
		((Control)lblPassword).Name = "lblPassword";
		Label obj10 = lblPassword;
		size = new Size(52, 13);
		((Control)obj10).Size = size;
		((Control)lblPassword).TabIndex = 27;
		lblPassword.Text = "Mật khẩu";
		lblUserName.AutoSize = true;
		Label obj11 = lblUserName;
		location = new Point(124, 93);
		((Control)obj11).Location = location;
		((Control)lblUserName).Name = "lblUserName";
		Label obj12 = lblUserName;
		size = new Size(26, 13);
		((Control)obj12).Size = size;
		((Control)lblUserName).TabIndex = 26;
		lblUserName.Text = "Tên";
		TextBox obj13 = txtPassword;
		location = new Point(243, 111);
		((Control)obj13).Location = location;
		((Control)txtPassword).Name = "txtPassword";
		txtPassword.PasswordChar = '*';
		TextBox obj14 = txtPassword;
		size = new Size(192, 20);
		((Control)obj14).Size = size;
		((Control)txtPassword).TabIndex = 1;
		txtUserName.CharacterCasing = (CharacterCasing)1;
		TextBox obj15 = txtUserName;
		location = new Point(243, 90);
		((Control)obj15).Location = location;
		((Control)txtUserName).Name = "txtUserName";
		TextBox obj16 = txtUserName;
		size = new Size(192, 20);
		((Control)obj16).Size = size;
		((Control)txtUserName).TabIndex = 0;
		((Control)GroupBox1).BackColor = SystemColors.Control;
		GroupBox groupBox = GroupBox1;
		location = new Point(0, 188);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(437, 2);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 0;
		GroupBox1.TabStop = false;
		PictureBox1.Image = (Image)(object)Resources.LoginIcon;
		PictureBox pictureBox = PictureBox1;
		location = new Point(0, 89);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(108, 93);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)1;
		PictureBox1.TabIndex = 36;
		PictureBox1.TabStop = false;
		cmdQuit.DialogResult = (DialogResult)2;
		((ButtonBase)cmdQuit).Image = (Image)componentResourceManager.GetObject("cmdQuit.Image");
		((ButtonBase)cmdQuit).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdQuit).ImeMode = (ImeMode)0;
		Button obj17 = cmdQuit;
		location = new Point(218, 202);
		((Control)obj17).Location = location;
		((Control)cmdQuit).Name = "cmdQuit";
		((Control)cmdQuit).RightToLeft = (RightToLeft)0;
		Button obj18 = cmdQuit;
		size = new Size(85, 25);
		((Control)obj18).Size = size;
		((Control)cmdQuit).TabIndex = 35;
		((ButtonBase)cmdQuit).Text = "T&hoát";
		((ButtonBase)cmdQuit).TextAlign = (ContentAlignment)64;
		((Control)panelLogo).BackColor = SystemColors.Window;
		((Control)panelLogo).BackgroundImage = (Image)(object)Resources.about;
		((Control)panelLogo).BackgroundImageLayout = (ImageLayout)3;
		((Control)panelLogo).Dock = (DockStyle)1;
		Panel obj19 = panelLogo;
		location = new Point(0, 0);
		((Control)obj19).Location = location;
		((Control)panelLogo).Name = "panelLogo";
		Panel obj20 = panelLogo;
		size = new Size(449, 83);
		((Control)obj20).Size = size;
		((Control)panelLogo).TabIndex = 30;
		((ButtonBase)cmdLogin).Image = (Image)componentResourceManager.GetObject("cmdLogin.Image");
		((ButtonBase)cmdLogin).ImageAlign = (ContentAlignment)256;
		Button obj21 = cmdLogin;
		location = new Point(127, 202);
		((Control)obj21).Location = location;
		((Control)cmdLogin).Name = "cmdLogin";
		Button obj22 = cmdLogin;
		size = new Size(85, 25);
		((Control)obj22).Size = size;
		((Control)cmdLogin).TabIndex = 4;
		((ButtonBase)cmdLogin).Text = "Đăng &nhập";
		((ButtonBase)cmdLogin).TextAlign = (ContentAlignment)64;
		((Control)btnTeamviewer).BackgroundImage = (Image)(object)Resources.SIMBAQS;
		((Control)btnTeamviewer).BackgroundImageLayout = (ImageLayout)3;
		((Control)btnTeamviewer).ForeColor = Color.White;
		Button obj23 = btnTeamviewer;
		location = new Point(0, 193);
		((Control)obj23).Location = location;
		((Control)btnTeamviewer).Name = "btnTeamviewer";
		Button obj24 = btnTeamviewer;
		size = new Size(108, 43);
		((Control)obj24).Size = size;
		((Control)btnTeamviewer).TabIndex = 37;
		((ButtonBase)btnTeamviewer).Text = "Teamview";
		((ButtonBase)btnTeamviewer).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnTeamviewer).UseVisualStyleBackColor = true;
		((Control)cmdOption).Anchor = (AnchorStyles)9;
		Button obj25 = cmdOption;
		location = new Point(398, 203);
		((Control)obj25).Location = location;
		((Control)cmdOption).Name = "cmdOption";
		Button obj26 = cmdOption;
		size = new Size(37, 23);
		((Control)obj26).Size = size;
		((Control)cmdOption).TabIndex = 42;
		((ButtonBase)cmdOption).Text = ">>>";
		((ButtonBase)cmdOption).UseVisualStyleBackColor = false;
		((Control)gbOption).Controls.Add((Control)(object)cboLanguage);
		((Control)gbOption).Controls.Add((Control)(object)lblLanguage);
		GroupBox obj27 = gbOption;
		location = new Point(1, 251);
		((Control)obj27).Location = location;
		((Control)gbOption).Name = "gbOption";
		GroupBox obj28 = gbOption;
		size = new Size(447, 53);
		((Control)obj28).Size = size;
		((Control)gbOption).TabIndex = 41;
		gbOption.TabStop = false;
		cboLanguage.DropDownStyle = (ComboBoxStyle)2;
		ComboBox obj29 = cboLanguage;
		location = new Point(275, 19);
		((Control)obj29).Location = location;
		((Control)cboLanguage).Name = "cboLanguage";
		ComboBox obj30 = cboLanguage;
		size = new Size(160, 21);
		((Control)obj30).Size = size;
		((Control)cboLanguage).TabIndex = 2;
		Label obj31 = lblLanguage;
		location = new Point(195, 20);
		((Control)obj31).Location = location;
		((Control)lblLanguage).Name = "lblLanguage";
		Label obj32 = lblLanguage;
		size = new Size(75, 18);
		((Control)obj32).Size = size;
		((Control)lblLanguage).TabIndex = 38;
		lblLanguage.Text = "Ngôn ngữ";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).BackColor = Color.FromArgb(254, 236, 217);
		size = new Size(449, 304);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdOption);
		((Control)this).Controls.Add((Control)(object)gbOption);
		((Control)this).Controls.Add((Control)(object)btnTeamviewer);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Control)this).Controls.Add((Control)(object)cmdQuit);
		((Control)this).Controls.Add((Control)(object)panelLogo);
		((Control)this).Controls.Add((Control)(object)cboFinanceYear);
		((Control)this).Controls.Add((Control)(object)lblUserName);
		((Control)this).Controls.Add((Control)(object)cmdLogin);
		((Control)this).Controls.Add((Control)(object)lblFinanceYear);
		((Control)this).Controls.Add((Control)(object)txtUserName);
		((Control)this).Controls.Add((Control)(object)cboComanyName);
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)txtPassword);
		((Control)this).Controls.Add((Control)(object)lblPassword);
		((Control)this).Controls.Add((Control)(object)lblCompanyName);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmLogin";
		((Form)this).Text = "Đăng nhập";
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)gbOption).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void OnLoad(EventArgs e)
	{
		int year = DateAndTime.Now.Year;
		string text = (SystemInformations.RootPath = Application.StartupPath);
		SystemInformations.GraphicPath = text + "\\Graphics\\";
		SystemInformations.ReportPath = text + "\\Reports\\";
		SystemInformations.FReportPath = text + "\\Reports\\Nt\\";
		SystemInformations.ResourcesPath = text + "\\Resx\\";
		SystemInformations.HelpPath = text + "\\Helps\\";
		SystemInformations.VideoHelpPath = SystemInformations.HelpPath + "Videos\\";
		if (Operators.CompareString(ClientConfiguration.Multi_lang_enabled, "1", false) == 0)
		{
			SystemInformations.CurrentCultureName = ConfigurationManager.AppSettings["CURRENT_LANG"];
			if (SystemInformations.CurrentCultureName == null || Operators.CompareString(SystemInformations.CurrentCultureName, string.Empty, false) == 0)
			{
				SystemInformations.CurrentCultureName = "vi-VN";
			}
			else
			{
				((Form)this).Text = "Login";
			}
			Valid4GetLanguage();
			base.Translate();
		}
		else
		{
			((Control)cmdOption).Enabled = false;
			((Control)cmdOption).Visible = false;
			SystemInformations.CurrentCultureName = "vi-VN";
		}
		Helper.LoadMessage();
		HideOption();
		ShowOption();
		int num = year - 5;
		int num2 = year + 15;
		int num3 = num;
		while (true)
		{
			int num4 = num3;
			int num5 = num2;
			if (num4 > num5)
			{
				break;
			}
			cboFinanceYear.Items.Add((object)num3);
			num3++;
		}
		cboFinanceYear.SelectedItem = DateAndTime.Year(DateAndTime.Now);
		cboFinanceYear.DropDownStyle = (ComboBoxStyle)2;
		if ((RSA.LicenseTerm != null && RSA.LicenseTerm.TrialMode) ? true : false)
		{
			txtUserName.Text = "ASIA";
			txtPassword.Text = "admin";
			((Control)cmdLogin).Focus();
		}
		isLoading = false;
	}

	private void cmdLogin_Click(object sender, EventArgs e)
	{
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected O, but got Unknown
		//IL_05f4: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(txtPassword.Text, "", false) == 0) | (Operators.CompareString(txtUserName.Text, "", false) == 0))
		{
			CMessageBox.Show(50206);
			return;
		}
		bool aIsAdmin = false;
		bool aIsGrand = false;
		if (CheckUser(ref aIsAdmin, ref aIsGrand))
		{
			intFinanceYear = Conversions.ToInteger(cboFinanceYear.SelectedItem);
			object obj = RuntimeHelpers.GetObjectValue(cboComanyName.SelectedItem);
			strFullName = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "fullname" }, (string[])null));
			strCompanyID = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "MA_CTY" }, (string[])null));
			MainDAO mainDAO = (MainDAO)DAOFactory.CreateDAOInstance("MainDAO", "Simba", a_blnIsSysDB: true);
			DataTable companyInfo = mainDAO.GetCompanyInfo(strCompanyID);
			mainDAO.Destroy();
			if (companyInfo.Rows.Count > 0)
			{
				obj = companyInfo.Rows[0];
			}
			strCompanyName = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "TEN_CTY" }, (string[])null));
			strHeadCompanyName = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "TEN_TCTY" }, (string[])null));
			strAddress = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "Dia_Chi" }, (string[])null));
			strTel = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "Tel" }, (string[])null));
			strFax = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "Fax" }, (string[])null));
			strTen_qd_cdkt = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "ten_qd_cdkt" }, (string[])null));
			strQd_cdkt = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "qd_cdkt" }, (string[])null));
			strDirector_Name = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "giam_doc" }, (string[])null));
			strChief_Accountant_Name = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "ktt" }, (string[])null));
			strMa_thue = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "ma_thue" }, (string[])null));
			strEmail = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "email" }, (string[])null));
			CompanyInformations.BankName = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "ten_nh" }, (string[])null));
			CompanyInformations.BankAccount = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "so_tk_nh" }, (string[])null));
			CompanyInformations.BankLocation = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { "tinh_tp_nh" }, (string[])null));
			SystemInformations.FinancialYear = intFinanceYear;
			SystemInformations.UserName = strUserName;
			SystemInformations.FullName = strFullName;
			SystemInformations.IsAdmin = aIsAdmin;
			CompanyInformations.CompanyID = strCompanyID;
			CompanyInformations.CompanyName = strCompanyName;
			CompanyInformations.ParentCompanyName = strHeadCompanyName;
			CompanyInformations.CompanyAddress = strAddress;
			CompanyInformations.CompanyTel = strTel;
			CompanyInformations.CompanyFax = strFax;
			CompanyInformations.Ten_qd_cdkt = strTen_qd_cdkt;
			CompanyInformations.Qd_cdkt = strQd_cdkt;
			CompanyInformations.Director_Name = strDirector_Name;
			CompanyInformations.Chief_Accountant_Name = strChief_Accountant_Name;
			CompanyInformations.Ma_thue = strMa_thue;
			CompanyInformations.Email = strEmail;
			companyInfo.Dispose();
			f_isOk = startup.LoadDataEnvironment(strCompanyName);
			if (!f_isOk)
			{
				((Form)this).Close();
				return;
			}
			AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct1", (object)DateAndTime.Now);
			AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct2", (object)DateAndTime.Now);
			AsiaErp.Framework.Environment.set_PublicVariables("Thang1", (object)DateAndTime.Now.Month);
			AsiaErp.Framework.Environment.set_PublicVariables("Thang2", (object)DateAndTime.Now.Month);
			AsiaErp.Framework.Environment.set_PublicVariables("KyBaoCao", (object)null);
			if (Operators.CompareString(ClientConfiguration.Multi_lang_enabled, "1", false) == 0)
			{
				string text = SystemInformations.CurrentCultureName;
				if ((((ListControl)cboLanguage).SelectedValue != null && Operators.ConditionalCompareObjectNotEqual(((ListControl)cboLanguage).SelectedValue, (object)string.Empty, false)) ? true : false)
				{
					text = Conversions.ToString(((ListControl)cboLanguage).SelectedValue);
				}
				SystemInformations.CurrentCultureName = text;
				ExeConfigurationFileMap val = new ExeConfigurationFileMap();
				val.ExeConfigFilename = SystemInformations.RootPath + "\\Simba.exe.config";
				if (!File.Exists(val.ExeConfigFilename))
				{
					CMessageBox.Show("Configuration file required: \"" + val.ExeConfigFilename + "\"");
				}
				else
				{
					Configuration val2 = ConfigurationManager.OpenMappedExeConfiguration(val, (ConfigurationUserLevel)0);
					if (Operators.CompareString(val2.AppSettings.Settings["CURRENT_LANG"].Value, text, false) != 0)
					{
						val2.AppSettings.Settings.Remove("CURRENT_LANG");
						val2.AppSettings.Settings.Add("CURRENT_LANG", SystemInformations.CurrentCultureName);
						try
						{
							val2.Save((ConfigurationSaveMode)0);
						}
						catch (ConfigurationErrorsException ex)
						{
							ProjectData.SetProjectError((Exception)ex);
							ConfigurationErrorsException ex2 = ex;
							Helper.ProcessError("File [" + val.ExeConfigFilename + "] could not be written!", Helper.ErrorType.Warning);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			string currentCultureName = SystemInformations.CurrentCultureName;
			CultureInfo cultureInfo = new CultureInfo(currentCultureName);
			cultureInfo.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";
			cultureInfo.DateTimeFormat.DateSeparator = "/";
			if (Operators.CompareString(Thread.CurrentThread.CurrentCulture.Name, currentCultureName, false) != 0)
			{
				Thread.CurrentThread.CurrentUICulture = cultureInfo;
				Thread.CurrentThread.CurrentCulture = cultureInfo;
			}
			Hide();
			AsiaErp.Framework.Environment.GetAllMenuInformations();
			Theme.GetThemeConfiguration();
			SystemInformations.ReportPath = SystemInformations.RootPath + "\\Reports\\" + SystemInformations.CurrentCultureName + "\\";
			SystemInformations.FReportPath = SystemInformations.RootPath + "\\Reports\\" + SystemInformations.CurrentCultureName + "\\Nt\\";
			f_isOk = true;
			Helper.LoadMessage();
			((Form)this).Close();
		}
		else
		{
			CMessageBox.Show(50206);
			((Control)txtUserName).Focus();
		}
	}

	private void cmdQuit_Click(object sender, EventArgs e)
	{
		f_isOk = false;
		((Form)this).Close();
	}

	private bool CheckUser(ref bool aIsAdmin, ref bool aIsGrand)
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		if (oTblCompany == null || oTblCompany.Rows.Count == 0)
		{
			return false;
		}
		bool result = false;
		strUserName = Helper.Repl_Str(txtUserName.Text.Trim());
		strUserName = Strings.Replace(strUserName, "'", "", 1, -1, (CompareMethod)0);
		strPassword = Helper.Encrypted(Helper.Repl_Str(txtPassword.Text), 100);
		MainDAO mainDAO = (MainDAO)DAOFactory.CreateDAOInstance("MainDAO", "Simba", a_blnIsSysDB: true);
		try
		{
			result = mainDAO.Logon(Conversions.ToString(NewLateBinding.LateIndexGet(cboComanyName.SelectedItem, new object[1] { "MA_CTY" }, (string[])null)), strUserName, strPassword, ref aIsAdmin, ref aIsGrand);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			CMessageBox.Show(50010);
			result = false;
			ProjectData.ClearProjectError();
		}
		finally
		{
			mainDAO.Destroy();
		}
		return result;
	}

	private void txtUserName_Validated(object sender, EventArgs e)
	{
		Valid4GetCompany();
	}

	private void Valid4GetCompany()
	{
		try
		{
			if (Operators.CompareString(txtUserName.Text, f_oldUserName, false) != 0)
			{
				MainDAO mainDAO = (MainDAO)DAOFactory.CreateDAOInstance("MainDAO", "Simba", a_blnIsSysDB: true);
				if (mainDAO == null)
				{
					((Form)this).Close();
				}
				strUserName = Helper.Repl_Str(txtUserName.Text.Trim());
				if (strUserName.Contains("'"))
				{
					strUserName = Strings.Replace(strUserName, "'", "", 1, -1, (CompareMethod)0);
				}
				if (strPassword.Contains("'"))
				{
					strPassword = Strings.Replace(strPassword, "'", "", 1, -1, (CompareMethod)0);
				}
				strPassword = Helper.Encrypted(Helper.Repl_Str(txtPassword.Text), 100);
				if (mainDAO.PreLogon(strUserName, strPassword))
				{
					oTblCompany = mainDAO.GetCompanyInfoByUserName(txtUserName.Text);
					cboComanyName.DataSource = oTblCompany;
					((ListControl)cboComanyName).DisplayMember = "Ten_Cty1";
					((ListControl)cboComanyName).ValueMember = "Ma_Cty";
					cboComanyName.DropDownStyle = (ComboBoxStyle)2;
					f_oldUserName = txtUserName.Text;
				}
				mainDAO.Destroy();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void btnTeamviewer_Click(object sender, EventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			using (Process.Start("SimbaQS.exe"))
			{
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void cboLanguage_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (isLoading)
		{
			return;
		}
		if (Operators.CompareString(ClientConfiguration.Multi_lang_enabled, "1", false) == 0)
		{
			string text = SystemInformations.CurrentCultureName;
			if ((((ListControl)cboLanguage).SelectedValue != null && Operators.ConditionalCompareObjectNotEqual(((ListControl)cboLanguage).SelectedValue, (object)string.Empty, false)) ? true : false)
			{
				text = Conversions.ToString(((ListControl)cboLanguage).SelectedValue);
			}
			if (Operators.CompareString(text, SystemInformations.CurrentCultureName, false) != 0)
			{
				SystemInformations.CurrentCultureName = text;
			}
		}
		AsiaErp.Framework.Environment.RemoveLangTranslationInfo(((object)this).GetType().FullName);
		base.Translate(forced: true);
		MainDAO mainDAO = (MainDAO)DAOFactory.CreateDAOInstance("MainDAO", "Simba", a_blnIsSysDB: true);
		if (mainDAO.PreLogon(strUserName, strPassword))
		{
			GetCompany();
		}
		mainDAO.Destroy();
	}

	private void GetCompany()
	{
		try
		{
			MainDAO mainDAO = (MainDAO)DAOFactory.CreateDAOInstance("MainDAO", "Simba", a_blnIsSysDB: true);
			if (mainDAO == null)
			{
				((Form)this).Close();
			}
			oTblCompany = mainDAO.GetCompanyInfoByUserName(txtUserName.Text);
			cboComanyName.DataSource = oTblCompany;
			((ListControl)cboComanyName).DisplayMember = "Ten_Cty1";
			((ListControl)cboComanyName).ValueMember = "Ma_Cty";
			cboComanyName.DropDownStyle = (ComboBoxStyle)2;
			f_oldUserName = txtUserName.Text;
			mainDAO.Destroy();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void Valid4GetLanguage()
	{
		try
		{
			MainDAO mainDAO = (MainDAO)DAOFactory.CreateDAOInstance("MainDAO", "Simba", a_blnIsSysDB: true);
			if (mainDAO == null)
			{
				((Form)this).Close();
			}
			DataTable allLanguage = mainDAO.GetAllLanguage();
			cboLanguage.DataSource = allLanguage;
			((ListControl)cboLanguage).DisplayMember = "Description";
			((ListControl)cboLanguage).ValueMember = "name";
			cboLanguage.DropDownStyle = (ComboBoxStyle)2;
			mainDAO.Destroy();
			((ListControl)cboLanguage).SelectedValue = SystemInformations.CurrentCultureName;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void cmdOption_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ButtonBase)cmdOption).Text, "<<<", false) == 0)
		{
			HideOption();
		}
		else
		{
			ShowOption();
		}
	}

	private void HideOption()
	{
		((ButtonBase)cmdOption).Text = ">>>";
		((Control)gbOption).Enabled = false;
		((Control)gbOption).Visible = false;
		((Control)this).Height = ((Control)this).Height - ((Control)gbOption).Height - 10;
	}

	private void ShowOption()
	{
		((ButtonBase)cmdOption).Text = "<<<";
		((Control)gbOption).Enabled = true;
		((Control)gbOption).Visible = true;
		((Control)this).Height = ((Control)this).Height + ((Control)gbOption).Height + 10;
	}
}
