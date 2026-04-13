using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.Framework.Docking;
using AsiaLicenseCommon;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class startup
{
	private static string strPath = Conversions.ToString(Operators.CompareString(Application.StartupPath, "\\SB.rpt", false) == 0);

	[STAThread]
	public static void Main()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		ExeConfigurationFileMap val = new ExeConfigurationFileMap();
		val.ExeConfigFilename = Application.StartupPath + "\\Simba.exe.config";
		if (!File.Exists(val.ExeConfigFilename))
		{
			CMessageBox.Show("Configuration file required: \"" + val.ExeConfigFilename + "\"");
		}
		else
		{
			Configuration val2 = ConfigurationManager.OpenMappedExeConfiguration(val, (ConfigurationUserLevel)0);
			try
			{
				if ((val2.AppSettings.Settings.AllKeys.Contains("FirstRun") && Operators.CompareString(val2.AppSettings.Settings["FirstRun"].Value, "1", false) == 0) ? true : false)
				{
					Process.Start("AttachData.exe");
					val2.AppSettings.Settings.Remove("FirstRun");
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
		frmProductAuthentication frmProductAuthentication2 = new frmProductAuthentication();
		if (!frmProductAuthentication2.ProductValid())
		{
			((Form)frmProductAuthentication2).ShowDialog();
		}
		bool f_isExit = frmProductAuthentication2.f_isExit;
		((Component)(object)frmProductAuthentication2).Dispose();
		if (f_isExit)
		{
			Application.Exit();
			return;
		}
		frmLogin frmLogin2 = new frmLogin();
		((Form)frmLogin2).ShowDialog();
		bool f_isOk = frmLogin2.f_isOk;
		((Component)(object)frmLogin2).Dispose();
		if (!f_isOk)
		{
			Application.Exit();
			return;
		}
		if (File.Exists(strPath))
		{
			Thread thread = new Thread(LoadCR);
			thread.Priority = ThreadPriority.Normal;
			thread.IsBackground = true;
			thread.Start();
		}
		LoadMenu();
	}

	public static bool LoadDataEnvironment(string companyName)
	{
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (RSA.LicenseTerm != null)
		{
			string[] array = RSA.LicenseTerm.CustomerName.Split(new char[1] { ';' });
			string[] array2 = array;
			foreach (string text in array2)
			{
				if ((!text.Replace(" ", string.Empty).Equals(string.Empty) && text.Replace(" ", string.Empty).Equals(companyName.Replace(" ", string.Empty), StringComparison.OrdinalIgnoreCase)) ? true : false)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				CMessageBox.ShowWithFormat(50205, new object[1] { companyName });
				return false;
			}
		}
		else if (!flag)
		{
			CMessageBox.ShowWithFormat(50205, new object[1] { companyName });
			return false;
		}
		AsiaErp.Framework.Environment.GetSIConfiguration();
		AsiaErp.Framework.Environment.GetSOConfiguration();
		AsiaErp.Framework.Environment.GetPOConfiguration();
		AsiaErp.Framework.Environment.GetINConfiguration();
		AsiaErp.Framework.Environment.GetFAConfiguration();
		return true;
	}

	public static void LoadMenu()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		Form val;
		switch (ConfigurationManager.AppSettings["MENU_TYPE"])
		{
		case "1":
			val = (Form)(object)new frmT1TreeMenu();
			break;
		case "2":
			val = (Form)(object)new frmT2Startup();
			break;
		case "3":
			val = (Form)(object)new FrmT3Startup();
			break;
		case "4":
			val = (Form)(object)new frmSimbaStartup();
			((frmSimbaStartup)(object)val).InitMenu();
			break;
		default:
			val = (Form)(object)new frmSimbaStartup();
			((frmSimbaStartup)(object)val).InitMenu();
			break;
		}
		val.ShowDialog();
	}

	private static void LoadCR()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ReportDocument val = new ReportDocument();
		val.Load(strPath, (OpenReportMethod)0);
		val.SetDataSource(Commons.GetDataTable("asCAGetCT2", CompanyInformations.CompanyID, ""));
	}

	public static void ExecuteCommand(MenuInformation mnu, DockPanel dockPanel)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(mnu.command.Trim(), "", false) == 0)
		{
			return;
		}
		if (!Commons.ChkExecRight(mnu.menuid))
		{
			CMessageBox.Show(50005);
			return;
		}
		try
		{
			if (Operators.ConditionalCompareObjectEqual(mnu.form, (object)"1", false))
			{
				CallMyForm(mnu.menuid, mnu.command, mnu.dllName, dockPanel);
			}
			else if (!Operators.ConditionalCompareObjectEqual(mnu.form, (object)"9", false))
			{
				Process.Start(mnu.command);
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

	private static void CallMyForm(string MenuID, string oType, string dllName, DockPanel dockPanel)
	{
		frmAsiaRoot frmAsiaRoot = null;
		string text = "";
		string[] array = oType.Trim().Split(new char[1] { '.' });
		text = array[array.Count() - 1];
		frmAsiaRoot = (frmAsiaRoot)(object)Application.OpenForms[text];
		if ((frmAsiaRoot != null && frmAsiaRoot.MyMenuID != null && !frmAsiaRoot.MyMenuID.Equals(MenuID)) ? true : false)
		{
			frmAsiaRoot = null;
		}
		if ((frmAsiaRoot == null || ((Control)frmAsiaRoot).IsDisposed || DateTime.Compare(frmAsiaRoot.LastModifiedDate, DateAndTime.DateAdd((DateInterval)8, -15.0, DateAndTime.Now)) < 0) ? true : false)
		{
			if (frmAsiaRoot != null && !((Control)frmAsiaRoot).IsDisposed)
			{
				((Component)(object)frmAsiaRoot).Dispose();
			}
			string name = "vi-VN";
			if ((SystemInformations.CurrentCultureName != null && Operators.CompareString(SystemInformations.CurrentCultureName, "", false) != 0) ? true : false)
			{
				name = SystemInformations.CurrentCultureName;
			}
			CultureInfo culture = new CultureInfo(name);
			oType = oType.Trim();
			Assembly assembly;
			try
			{
				assembly = Assembly.Load(dllName);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
			if ((object)assembly != null)
			{
				object[] args = new object[1] { MenuID };
				Type type = assembly.GetType(oType, throwOnError: true, ignoreCase: true);
				try
				{
					frmAsiaRoot = (frmAsiaRoot)type.InvokeMember(null, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, null, args, culture);
					frmAsiaRoot.LastModifiedDate = DateAndTime.Now;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Helper.ProcessError(ex4.InnerException);
					ProjectData.ClearProjectError();
				}
			}
			if (frmAsiaRoot != null)
			{
				frmAsiaRoot.Show(dockPanel);
				((Control)frmAsiaRoot).BringToFront();
			}
		}
		else
		{
			((Control)frmAsiaRoot).BringToFront();
		}
	}
}
