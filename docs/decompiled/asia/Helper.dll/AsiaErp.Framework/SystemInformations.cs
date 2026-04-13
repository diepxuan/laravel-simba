using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.Framework;

public class SystemInformations
{
	private const string SBProductName = "Simba Accounting";

	private const string ASProductName = "Asia Standard";

	public const string DEFAULT_CULTURE_NAME = "vi-VN";

	public const string DEFAULT_DAO_TYPE = "MsSql";

	public const uint SYSTEM_CACHE_INTERVAL = 600u;

	public const uint SYSTEM_REPORT_CACHE_INTERVAL = 120u;

	private const string _productVersion = "14.2";

	private const string _productCreateDate = "28/03/2015";

	private static string _username = null;

	private static string _fullname = null;

	private static string _cultureName = null;

	private static int _financialYear = 0;

	private static string _rootPath = null;

	private static string _reportPath = null;

	private static string _FReportPath = null;

	private static string _graphicPath = null;

	private static bool _isAdmin = false;

	private static string _resourcesPath = "";

	private static string _XMLPath = "";

	private static bool _isLoaded = false;

	private static bool _assb = false;

	public static bool ASSB
	{
		get
		{
			if (_isLoaded)
			{
				return _assb;
			}
			_isLoaded = true;
			object appSettings = ConfigurationManager.AppSettings;
			string[] source = (string[])NewLateBinding.LateGet(appSettings, (Type)null, "AllKeys", new object[0], (string[])null, (Type[])null, (bool[])null);
			if (source.Contains("ASSB"))
			{
				try
				{
					_assb = Conversions.ToBoolean(NewLateBinding.LateIndexGet(appSettings, new object[1] { "ASSB" }, (string[])null));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					_assb = false;
					ProjectData.ClearProjectError();
				}
			}
			return _assb;
		}
	}

	public static string RootPath
	{
		get
		{
			return _rootPath;
		}
		set
		{
			_rootPath = value;
		}
	}

	public static string XMLPath
	{
		get
		{
			_XMLPath = RootPath + "\\XML\\";
			return _XMLPath;
		}
		set
		{
			_XMLPath = value;
		}
	}

	public static string ResourcesPath
	{
		get
		{
			return _resourcesPath;
		}
		set
		{
			_resourcesPath = value;
		}
	}

	public static string FReportPath
	{
		get
		{
			return _FReportPath;
		}
		set
		{
			_FReportPath = value;
		}
	}

	public static string ReportPath
	{
		get
		{
			return _reportPath;
		}
		set
		{
			_reportPath = value;
		}
	}

	public static string GraphicPath
	{
		get
		{
			return _graphicPath;
		}
		set
		{
			_graphicPath = value;
		}
	}

	public static string HelpPath
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public static string VideoHelpPath
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public static string UserName
	{
		get
		{
			return _username;
		}
		set
		{
			_username = value;
		}
	}

	public static string FullName
	{
		get
		{
			return _fullname;
		}
		set
		{
			_fullname = value;
		}
	}

	public static int FinancialYear
	{
		get
		{
			return _financialYear;
		}
		set
		{
			_financialYear = value;
		}
	}

	public static bool IsAdmin
	{
		get
		{
			return _isAdmin;
		}
		set
		{
			_isAdmin = value;
		}
	}

	public static string CurrentCultureName
	{
		get
		{
			return _cultureName;
		}
		set
		{
			_cultureName = value;
		}
	}

	public static string ProductName => Conversions.ToString(Interaction.IIf(ASSB, (object)"Asia Standard", (object)"Simba Accounting"));

	public static string ProductFullName => ProductName + " " + ProductVersion;

	public static string ProductCreateDate => "28/03/2015";

	public static string ProductVersion => "14.2";

	static SystemInformations()
	{
		string helpPath = Application.StartupPath + "\\Helps\\";
		HelpPath = helpPath;
		helpPath = HelpPath + "Videos\\";
		VideoHelpPath = helpPath;
	}

	[DebuggerNonUserCode]
	public SystemInformations()
	{
	}

	public static void LoadConfig()
	{
	}
}
