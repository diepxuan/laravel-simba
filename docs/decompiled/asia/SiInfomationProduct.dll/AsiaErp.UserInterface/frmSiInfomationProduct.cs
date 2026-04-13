using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.UserInterface.My.Resources;
using AsiaLicenseCommon;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSiInfomationProduct : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblProductVersion")]
	private Label _lblProductVersion;

	[AccessedThroughProperty("lblCompanyName")]
	private Label _lblCompanyName;

	[AccessedThroughProperty("llbWeb")]
	private LinkLabel _llbWeb;

	[AccessedThroughProperty("lblEmail")]
	private LinkLabel _lblEmail;

	[AccessedThroughProperty("lblProductName")]
	private Label _lblProductName;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("lblCap_phep")]
	private Label _lblCap_phep;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("lblBuild")]
	private Label _lblBuild;

	[AccessedThroughProperty("lblBuildCreateDate")]
	private Label _lblBuildCreateDate;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("lblData")]
	private Label _lblData;

	[AccessedThroughProperty("lblServer")]
	private Label _lblServer;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("lblActive")]
	private LinkLabel _lblActive;

	[AccessedThroughProperty("llbAsiaSoftWebsite")]
	private LinkLabel _llbAsiaSoftWebsite;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("llbAsiaSoftEmail")]
	private LinkLabel _llbAsiaSoftEmail;

	public string BuyNowURL;

	public string RegSubKeyName;

	public Helper.CryptographyData KEY;

	private const string MyWebsite = "http://www.simba.vn";

	private const string MyEmail = "info@simba.vn";

	private const string MyCompanyWebsite = "http://www.asiasoft.com.vn";

	private const string MyCompanyEmail = "info@asiasoft.com.vn";

	private DateTime f_dInstallDate;

	private string f_sProductKey;

	private string f_sUserName;

	public bool f_isRegisted;

	internal virtual Label lblProductVersion
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblProductVersion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblProductVersion = value;
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

	internal virtual LinkLabel llbWeb
	{
		[DebuggerNonUserCode]
		get
		{
			return _llbWeb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(llbWeb_LinkClicked);
			if (_llbWeb != null)
			{
				_llbWeb.LinkClicked -= val;
			}
			_llbWeb = value;
			if (_llbWeb != null)
			{
				_llbWeb.LinkClicked += val;
			}
		}
	}

	internal virtual LinkLabel lblEmail
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblEmail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(lblEmail_LinkClicked);
			if (_lblEmail != null)
			{
				_lblEmail.LinkClicked -= val;
			}
			_lblEmail = value;
			if (_lblEmail != null)
			{
				_lblEmail.LinkClicked += val;
			}
		}
	}

	internal virtual Label lblProductName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblProductName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblProductName = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label lblCap_phep
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCap_phep;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCap_phep = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	internal virtual Label lblBuild
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblBuild;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblBuild = value;
		}
	}

	internal virtual Label lblBuildCreateDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblBuildCreateDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblBuildCreateDate = value;
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

	internal virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
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

	internal virtual Label lblServer
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblServer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblServer = value;
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label18 = value;
		}
	}

	internal virtual LinkLabel lblActive
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblActive;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(lblActive_LinkClicked);
			if (_lblActive != null)
			{
				_lblActive.LinkClicked -= val;
			}
			_lblActive = value;
			if (_lblActive != null)
			{
				_lblActive.LinkClicked += val;
			}
		}
	}

	internal virtual LinkLabel llbAsiaSoftWebsite
	{
		[DebuggerNonUserCode]
		get
		{
			return _llbAsiaSoftWebsite;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(llbAsiaSoft_LinkClicked);
			if (_llbAsiaSoftWebsite != null)
			{
				_llbAsiaSoftWebsite.LinkClicked -= val;
			}
			_llbAsiaSoftWebsite = value;
			if (_llbAsiaSoftWebsite != null)
			{
				_llbAsiaSoftWebsite.LinkClicked += val;
			}
		}
	}

	internal virtual Button cmdOK
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOK_Click;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click -= eventHandler;
			}
			_cmdOK = value;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click += eventHandler;
			}
		}
	}

	internal virtual LinkLabel llbAsiaSoftEmail
	{
		[DebuggerNonUserCode]
		get
		{
			return _llbAsiaSoftEmail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(llbAsiaSoftEmail_LinkClicked);
			if (_llbAsiaSoftEmail != null)
			{
				_llbAsiaSoftEmail.LinkClicked -= val;
			}
			_llbAsiaSoftEmail = value;
			if (_llbAsiaSoftEmail != null)
			{
				_llbAsiaSoftEmail.LinkClicked += val;
			}
		}
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

	public frmSiInfomationProduct(string menuid)
		: base(menuid)
	{
		((Form)this).Load += frmSiInfomation_Load;
		__ENCAddToList(this);
		BuyNowURL = "http://www.Asiasoft.com.vn";
		RegSubKeyName = "Asiasoft\\\\Asia Enterprise\\\\12.1.3";
		KEY = new Helper.CryptographyData(SystemInformations.ProductName);
		f_dInstallDate = DateTime.Now;
		f_sProductKey = "";
		f_sUserName = "";
		f_isRegisted = false;
		InitializeComponent();
	}

	public frmSiInfomationProduct()
	{
		((Form)this).Load += frmSiInfomation_Load;
		__ENCAddToList(this);
		BuyNowURL = "http://www.Asiasoft.com.vn";
		RegSubKeyName = "Asiasoft\\\\Asia Enterprise\\\\12.1.3";
		KEY = new Helper.CryptographyData(SystemInformations.ProductName);
		f_dInstallDate = DateTime.Now;
		f_sProductKey = "";
		f_sUserName = "";
		f_isRegisted = false;
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
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
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected O, but got Unknown
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected O, but got Unknown
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected O, but got Unknown
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected O, but got Unknown
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected O, but got Unknown
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected O, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected O, but got Unknown
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Expected O, but got Unknown
		//IL_0b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Expected O, but got Unknown
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected O, but got Unknown
		//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc8: Expected O, but got Unknown
		//IL_0d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d59: Expected O, but got Unknown
		//IL_0de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dea: Expected O, but got Unknown
		//IL_0e71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7b: Expected O, but got Unknown
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1d: Expected O, but got Unknown
		//IL_0fc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd0: Expected O, but got Unknown
		//IL_10e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f0: Expected O, but got Unknown
		//IL_118b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1195: Expected O, but got Unknown
		//IL_1247: Unknown result type (might be due to invalid IL or missing references)
		//IL_1251: Expected O, but got Unknown
		//IL_1388: Unknown result type (might be due to invalid IL or missing references)
		//IL_1392: Expected O, but got Unknown
		//IL_16cc: Unknown result type (might be due to invalid IL or missing references)
		lblProductVersion = new Label();
		lblCompanyName = new Label();
		llbWeb = new LinkLabel();
		lblEmail = new LinkLabel();
		lblProductName = new Label();
		Label2 = new Label();
		lblCap_phep = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Label12 = new Label();
		Label13 = new Label();
		Label14 = new Label();
		Label15 = new Label();
		Label16 = new Label();
		Label17 = new Label();
		lblBuild = new Label();
		lblBuildCreateDate = new Label();
		Label1 = new Label();
		Label19 = new Label();
		lblData = new Label();
		lblServer = new Label();
		Panel1 = new Panel();
		Label18 = new Label();
		lblActive = new LinkLabel();
		llbAsiaSoftWebsite = new LinkLabel();
		cmdOK = new Button();
		llbAsiaSoftEmail = new LinkLabel();
		((Control)this).SuspendLayout();
		lblProductVersion.AutoSize = true;
		((Control)lblProductVersion).BackColor = Color.Transparent;
		((Control)lblProductVersion).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblProductVersion).ForeColor = Color.Black;
		Label obj = lblProductVersion;
		Point location = new Point(92, 167);
		((Control)obj).Location = location;
		((Control)lblProductVersion).Name = "lblProductVersion";
		Label obj2 = lblProductVersion;
		Size size = new Size(31, 15);
		((Control)obj2).Size = size;
		((Control)lblProductVersion).TabIndex = 4;
		lblProductVersion.Text = "14.1";
		lblCompanyName.AutoSize = true;
		((Control)lblCompanyName).BackColor = Color.Transparent;
		((Control)lblCompanyName).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCompanyName).ForeColor = Color.MidnightBlue;
		Label obj3 = lblCompanyName;
		location = new Point(15, 259);
		((Control)obj3).Location = location;
		((Control)lblCompanyName).Name = "lblCompanyName";
		Label obj4 = lblCompanyName;
		size = new Size(41, 15);
		((Control)obj4).Size = size;
		((Control)lblCompanyName).TabIndex = 8;
		lblCompanyName.Text = "Demo";
		((Label)llbWeb).AutoSize = true;
		((Control)llbWeb).BackColor = Color.Transparent;
		((Control)llbWeb).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		llbWeb.LinkBehavior = (LinkBehavior)2;
		LinkLabel obj5 = llbWeb;
		location = new Point(238, 389);
		((Control)obj5).Location = location;
		((Control)llbWeb).Name = "llbWeb";
		LinkLabel obj6 = llbWeb;
		size = new Size(92, 16);
		((Control)obj6).Size = size;
		((Control)llbWeb).TabIndex = 31;
		((Label)llbWeb).TabStop = true;
		llbWeb.Text = "www.simba.vn";
		((Label)lblEmail).AutoSize = true;
		((Control)lblEmail).BackColor = Color.Transparent;
		((Control)lblEmail).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblEmail.LinkBehavior = (LinkBehavior)2;
		LinkLabel obj7 = lblEmail;
		location = new Point(406, 223);
		((Control)obj7).Location = location;
		((Control)lblEmail).Name = "lblEmail";
		LinkLabel obj8 = lblEmail;
		size = new Size(88, 15);
		((Control)obj8).Size = size;
		((Control)lblEmail).TabIndex = 32;
		((Label)lblEmail).TabStop = true;
		lblEmail.Text = "info@simba.vn";
		lblProductName.AutoSize = true;
		((Control)lblProductName).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj9 = lblProductName;
		location = new Point(15, 141);
		((Control)obj9).Location = location;
		((Control)lblProductName).Name = "lblProductName";
		Label obj10 = lblProductName;
		size = new Size(149, 19);
		((Control)obj10).Size = size;
		((Control)lblProductName).TabIndex = 34;
		lblProductName.Text = "Simba Accounting";
		Label2.AutoSize = true;
		((Control)Label2).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label2;
		location = new Point(15, 167);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(66, 15);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 35;
		Label2.Text = "Phiên bản:";
		lblCap_phep.AutoSize = true;
		((Control)lblCap_phep).BackColor = Color.Transparent;
		((Control)lblCap_phep).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCap_phep).ForeColor = Color.Black;
		Label obj11 = lblCap_phep;
		location = new Point(15, 238);
		((Control)obj11).Location = location;
		((Control)lblCap_phep).Name = "lblCap_phep";
		Label obj12 = lblCap_phep;
		size = new Size(133, 15);
		((Control)obj12).Size = size;
		((Control)lblCap_phep).TabIndex = 36;
		lblCap_phep.Text = "Cấp phép sử dụng cho:";
		Label5.AutoSize = true;
		((Control)Label5).Font = new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label3 = Label5;
		location = new Point(368, 141);
		((Control)label3).Location = location;
		((Control)Label5).Name = "Label5";
		Label label4 = Label5;
		size = new Size(247, 16);
		((Control)label4).Size = size;
		((Control)Label5).TabIndex = 38;
		Label5.Text = "Công ty CP Phát triển phần mềm Asia";
		Label6.AutoSize = true;
		((Control)Label6).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label5 = Label6;
		location = new Point(368, 168);
		((Control)label5).Location = location;
		((Control)Label6).Name = "Label6";
		Label label6 = Label6;
		size = new Size(51, 15);
		((Control)label6).Size = size;
		((Control)Label6).TabIndex = 39;
		Label6.Text = "Hà Nội";
		Label8.AutoSize = true;
		((Control)Label8).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label7 = Label8;
		location = new Point(368, 187);
		((Control)label7).Location = location;
		((Control)Label8).Name = "Label8";
		Label label8 = Label8;
		size = new Size(175, 15);
		((Control)label8).Size = size;
		((Control)Label8).TabIndex = 40;
		Label8.Text = "06, Vũ Ngọc Phan, Q. Đống Đa";
		Label9.AutoSize = true;
		((Control)Label9).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label9 = Label9;
		location = new Point(368, 206);
		((Control)label9).Location = location;
		((Control)Label9).Name = "Label9";
		Label label10 = Label9;
		size = new Size(216, 15);
		((Control)label10).Size = size;
		((Control)Label9).TabIndex = 41;
		Label9.Text = "ĐT: 04.3776.1663   Fax: 04.3776.1823";
		Label10.AutoSize = true;
		((Control)Label10).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label11 = Label10;
		location = new Point(368, 223);
		((Control)label11).Location = location;
		((Control)Label10).Name = "Label10";
		Label label12 = Label10;
		size = new Size(42, 15);
		((Control)label12).Size = size;
		((Control)Label10).TabIndex = 42;
		Label10.Text = "Email:";
		Label12.AutoSize = true;
		((Control)Label12).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label13 = Label12;
		location = new Point(369, 259);
		((Control)label13).Location = location;
		((Control)Label12).Name = "Label12";
		Label label14 = Label12;
		size = new Size(63, 15);
		((Control)label14).Size = size;
		((Control)Label12).TabIndex = 44;
		Label12.Text = "Đà Nẵng";
		Label13.AutoSize = true;
		((Control)Label13).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label15 = Label13;
		location = new Point(369, 278);
		((Control)label15).Location = location;
		((Control)Label13).Name = "Label13";
		Label label16 = Label13;
		size = new Size(217, 15);
		((Control)label16).Size = size;
		((Control)Label13).TabIndex = 45;
		Label13.Text = "480-482 Trưng Nữ Vương, Q. Hải Châu";
		Label14.AutoSize = true;
		((Control)Label14).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label17 = Label14;
		location = new Point(369, 297);
		((Control)label17).Location = location;
		((Control)Label14).Name = "Label14";
		Label label18 = Label14;
		size = new Size(230, 15);
		((Control)label18).Size = size;
		((Control)Label14).TabIndex = 46;
		Label14.Text = "ĐT: 0511.222.9308   Fax: 0511.363.4897";
		Label15.AutoSize = true;
		((Control)Label15).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label19 = Label15;
		location = new Point(369, 362);
		((Control)label19).Location = location;
		((Control)Label15).Name = "Label15";
		Label label20 = Label15;
		size = new Size(219, 15);
		((Control)label20).Size = size;
		((Control)Label15).TabIndex = 49;
		Label15.Text = "ĐT: 08.3989.2737    Fax: 08.3989.4277";
		Label16.AutoSize = true;
		((Control)Label16).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label21 = Label16;
		location = new Point(369, 343);
		((Control)label21).Location = location;
		((Control)Label16).Name = "Label16";
		Label label22 = Label16;
		size = new Size(216, 15);
		((Control)label22).Size = size;
		((Control)Label16).TabIndex = 48;
		Label16.Text = "642/43/38 Lê Đức Thọ, F15, Q. Gò Vấp";
		Label17.AutoSize = true;
		((Control)Label17).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label23 = Label17;
		location = new Point(369, 324);
		((Control)label23).Location = location;
		((Control)Label17).Name = "Label17";
		Label label24 = Label17;
		size = new Size(107, 15);
		((Control)label24).Size = size;
		((Control)Label17).TabIndex = 47;
		Label17.Text = "TP Hồ Chí Minh";
		lblBuild.AutoSize = true;
		((Control)lblBuild).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj13 = lblBuild;
		location = new Point(15, 186);
		((Control)obj13).Location = location;
		((Control)lblBuild).Name = "lblBuild";
		Label obj14 = lblBuild;
		size = new Size(58, 15);
		((Control)obj14).Size = size;
		((Control)lblBuild).TabIndex = 50;
		lblBuild.Text = "Ngày tạo:";
		lblBuildCreateDate.AutoSize = true;
		((Control)lblBuildCreateDate).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj15 = lblBuildCreateDate;
		location = new Point(92, 186);
		((Control)obj15).Location = location;
		((Control)lblBuildCreateDate).Name = "lblBuildCreateDate";
		Label obj16 = lblBuildCreateDate;
		size = new Size(69, 15);
		((Control)obj16).Size = size;
		((Control)lblBuildCreateDate).TabIndex = 51;
		lblBuildCreateDate.Text = "28/03/2015";
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label25 = Label1;
		location = new Point(15, 329);
		((Control)label25).Location = location;
		((Control)Label1).Name = "Label1";
		Label label26 = Label1;
		size = new Size(49, 15);
		((Control)label26).Size = size;
		((Control)Label1).TabIndex = 54;
		Label1.Text = "Dữ liệu:";
		Label19.AutoSize = true;
		((Control)Label19).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label27 = Label19;
		location = new Point(15, 310);
		((Control)label27).Location = location;
		((Control)Label19).Name = "Label19";
		Label label28 = Label19;
		size = new Size(56, 15);
		((Control)label28).Size = size;
		((Control)Label19).TabIndex = 52;
		Label19.Text = "Máy chủ:";
		lblData.AutoSize = true;
		((Control)lblData).BackColor = Color.Transparent;
		((Control)lblData).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblData).ForeColor = Color.Black;
		Label obj17 = lblData;
		location = new Point(92, 329);
		((Control)obj17).Location = location;
		((Control)lblData).Name = "lblData";
		Label obj18 = lblData;
		size = new Size(33, 15);
		((Control)obj18).Size = size;
		((Control)lblData).TabIndex = 53;
		lblData.Text = "Data";
		lblServer.AutoSize = true;
		((Control)lblServer).BackColor = Color.Transparent;
		((Control)lblServer).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblServer).ForeColor = Color.Black;
		Label obj19 = lblServer;
		location = new Point(92, 310);
		((Control)obj19).Location = location;
		((Control)lblServer).Name = "lblServer";
		Label obj20 = lblServer;
		size = new Size(42, 15);
		((Control)obj20).Size = size;
		((Control)lblServer).TabIndex = 56;
		lblServer.Text = "Server";
		((Control)Panel1).BackgroundImage = (Image)(object)Resources.about;
		((Control)Panel1).BackgroundImageLayout = (ImageLayout)3;
		((Control)Panel1).Dock = (DockStyle)1;
		Panel panel = Panel1;
		location = new Point(1, 1);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(701, 104);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 33;
		Label18.AutoSize = true;
		((Control)Label18).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label29 = Label18;
		location = new Point(15, 207);
		((Control)label29).Location = location;
		((Control)Label18).Name = "Label18";
		Label label30 = Label18;
		size = new Size(166, 15);
		((Control)label30).Size = size;
		((Control)Label18).TabIndex = 57;
		Label18.Text = "Copy right © 2015 by AsiaSoft";
		((Label)lblActive).AutoSize = true;
		((Control)lblActive).BackColor = Color.Transparent;
		((Control)lblActive).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lblActive.LinkBehavior = (LinkBehavior)2;
		LinkLabel obj21 = lblActive;
		location = new Point(16, 259);
		((Control)obj21).Location = location;
		((Control)lblActive).Name = "lblActive";
		LinkLabel obj22 = lblActive;
		size = new Size(111, 15);
		((Control)obj22).Size = size;
		((Control)lblActive).TabIndex = 58;
		((Label)lblActive).TabStop = true;
		lblActive.Text = "Đăng ký bản quyền";
		((Label)llbAsiaSoftWebsite).AutoSize = true;
		((Control)llbAsiaSoftWebsite).BackColor = Color.Transparent;
		((Control)llbAsiaSoftWebsite).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		llbAsiaSoftWebsite.LinkBehavior = (LinkBehavior)2;
		LinkLabel obj23 = llbAsiaSoftWebsite;
		location = new Point(355, 389);
		((Control)obj23).Location = location;
		((Control)llbAsiaSoftWebsite).Name = "llbAsiaSoftWebsite";
		LinkLabel obj24 = llbAsiaSoftWebsite;
		size = new Size(131, 16);
		((Control)obj24).Size = size;
		((Control)llbAsiaSoftWebsite).TabIndex = 59;
		((Label)llbAsiaSoftWebsite).TabStop = true;
		llbAsiaSoftWebsite.Text = "www.asiasoft.com.vn";
		cmdOK.DialogResult = (DialogResult)2;
		Button obj25 = cmdOK;
		location = new Point(18, 417);
		((Control)obj25).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		Button obj26 = cmdOK;
		size = new Size(75, 23);
		((Control)obj26).Size = size;
		((Control)cmdOK).TabIndex = 0;
		((ButtonBase)cmdOK).Text = "&Nhận";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = true;
		((Label)llbAsiaSoftEmail).AutoSize = true;
		((Control)llbAsiaSoftEmail).BackColor = Color.Transparent;
		((Control)llbAsiaSoftEmail).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		llbAsiaSoftEmail.LinkBehavior = (LinkBehavior)2;
		LinkLabel obj27 = llbAsiaSoftEmail;
		location = new Point(500, 223);
		((Control)obj27).Location = location;
		((Control)llbAsiaSoftEmail).Name = "llbAsiaSoftEmail";
		LinkLabel obj28 = llbAsiaSoftEmail;
		size = new Size(123, 15);
		((Control)obj28).Size = size;
		((Control)llbAsiaSoftEmail).TabIndex = 61;
		((Label)llbAsiaSoftEmail).TabStop = true;
		llbAsiaSoftEmail.Text = "info@asiasoft.com.vn";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOK;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdOK;
		size = new Size(703, 456);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)llbAsiaSoftEmail);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Controls.Add((Control)(object)llbAsiaSoftWebsite);
		((Control)this).Controls.Add((Control)(object)lblActive);
		((Control)this).Controls.Add((Control)(object)Label18);
		((Control)this).Controls.Add((Control)(object)lblServer);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)lblData);
		((Control)this).Controls.Add((Control)(object)Label19);
		((Control)this).Controls.Add((Control)(object)lblBuildCreateDate);
		((Control)this).Controls.Add((Control)(object)lblBuild);
		((Control)this).Controls.Add((Control)(object)Label15);
		((Control)this).Controls.Add((Control)(object)Label16);
		((Control)this).Controls.Add((Control)(object)Label17);
		((Control)this).Controls.Add((Control)(object)Label14);
		((Control)this).Controls.Add((Control)(object)Label13);
		((Control)this).Controls.Add((Control)(object)Label12);
		((Control)this).Controls.Add((Control)(object)Label10);
		((Control)this).Controls.Add((Control)(object)Label9);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)Label6);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)lblCap_phep);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)lblProductName);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)lblEmail);
		((Control)this).Controls.Add((Control)(object)llbWeb);
		((Control)this).Controls.Add((Control)(object)lblCompanyName);
		((Control)this).Controls.Add((Control)(object)lblProductVersion);
		((Control)this).DoubleBuffered = true;
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSiInfomationProduct";
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(1);
		((Control)this).Padding = padding;
		((Form)this).Text = "Thông tin sản phẩm";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btnAccept_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void frmSiInfomation_Load(object sender, EventArgs e)
	{
		lblProductName.Text = SystemInformations.ProductName;
		lblProductVersion.Text = SystemInformations.ProductVersion;
		lblBuildCreateDate.Text = SystemInformations.ProductCreateDate;
		lblCompanyName.Text = CompanyInformations.CompanyName;
		lblServer.Text = DatabaseConfigurations.ServerName;
		lblData.Text = DatabaseConfigurations.DATADatabaseName;
		if (ValidProductKey())
		{
			((Control)lblActive).Visible = false;
			lblCompanyName.Text = RSA.LicenseTerm.CustomerName;
		}
		else
		{
			lblCap_phep.Text = "Bản dùng thử";
			((Control)lblCompanyName).Visible = false;
			((Control)lblActive).Visible = true;
		}
	}

	private void lblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("mailto:info@simba.vn");
		lblEmail.LinkVisited = true;
	}

	private void llbAsiaSoftEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("mailto:info@asiasoft.com.vn");
		llbAsiaSoftEmail.LinkVisited = true;
	}

	private void llbWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.simba.vn");
		llbWeb.LinkVisited = true;
	}

	private void llbAsiaSoft_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.asiasoft.com.vn");
		llbAsiaSoftWebsite.LinkVisited = true;
	}

	private void lblActive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).Visible = false;
		frmRegister frmRegister2 = new frmRegister();
		((Form)frmRegister2).ShowDialog();
		if (frmRegister2.ActivateSuccess)
		{
			((Form)this).Close();
		}
		else
		{
			((Control)this).Visible = true;
		}
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void LoadProductInfo()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software", writable: true);
		registryKey = registryKey.CreateSubKey(RegSubKeyName);
		registryKey = Registry.LocalMachine.OpenSubKey("Software\\\\" + RegSubKeyName);
		string text = registryKey.GetValue("InstallDate", "").ToString();
		f_sUserName = registryKey.GetValue("UserName", "").ToString();
		f_sProductKey = registryKey.GetValue("ProductKey", "").ToString();
		registryKey.Close();
	}

	private bool ValidProductKey()
	{
		string text = Conversions.ToString(Encrypt(f_sUserName));
		if (Operators.CompareString(f_sProductKey, text, false) == 0)
		{
			f_isRegisted = true;
		}
		else
		{
			f_isRegisted = false;
		}
		return f_isRegisted;
	}

	public string Decrypt(string hexstream)
	{
		string result;
		try
		{
			Helper.Symmetric symmetric = new Helper.Symmetric(Helper.Symmetric.Provider.Rijndael);
			Helper.CryptographyData cryptographyData = new Helper.CryptographyData();
			cryptographyData.Hex = hexstream;
			Helper.CryptographyData cryptographyData2 = symmetric.Decrypt(cryptographyData, KEY);
			result = cryptographyData2.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public object Encrypt(string text)
	{
		Helper.Symmetric symmetric = new Helper.Symmetric(Helper.Symmetric.Provider.Rijndael);
		Helper.CryptographyData cryptographyData = symmetric.Encrypt(new Helper.CryptographyData(text), KEY);
		return cryptographyData.ToHex();
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
