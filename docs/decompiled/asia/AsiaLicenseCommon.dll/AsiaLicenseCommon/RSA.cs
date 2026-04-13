using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using AsiaLicenseCommon.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaLicenseCommon;

public class RSA
{
	internal const string LICENSE_FILE_NAME = "\\Simba.asialic";

	public static LicenseTerms LicenseTerm;

	[DebuggerNonUserCode]
	public RSA()
	{
	}

	public static bool LicenseIsValid()
	{
		bool result;
		try
		{
			string text = Application.StartupPath + "\\Simba.asialic";
			File.SetAttributes(text, FileAttributes.Normal);
			AsiaSoftLicense asiaSoftLicense = AsiaSoftLicense.Load(text);
			using DSACryptoServiceProvider dSACryptoServiceProvider = new DSACryptoServiceProvider();
			dSACryptoServiceProvider.FromXmlString(Resources.publicKey);
			byte[] rgbData = Convert.FromBase64String(asiaSoftLicense.LicenseTerms);
			byte[] rgbSignature = Convert.FromBase64String(asiaSoftLicense.Signature);
			if (!dSACryptoServiceProvider.VerifyData(rgbData, rgbSignature))
			{
				goto IL_0122;
			}
			LicenseTerm = LicenseTerms.FromString(asiaSoftLicense.LicenseTerms);
			if (!LicenseTerm.TrialMode)
			{
				result = true;
			}
			else
			{
				FileInfo fileInfo = new FileInfo(Application.StartupPath);
				LicenseTerm.StartDate = DateAndTime.DateAdd((DateInterval)4, -1.0, fileInfo.CreationTime);
				LicenseTerm.EndDate = DateAndTime.DateAdd((DateInterval)4, (double)LicenseTerm.TRIAL_PERIOD, LicenseTerm.StartDate);
				if ((DateTime.Compare(LicenseTerm.StartDate, DateAndTime.Today) > 0 || DateTime.Compare(DateAndTime.Today, LicenseTerm.EndDate) > 0) && 0 == 0)
				{
					goto IL_0122;
				}
				result = true;
			}
			goto end_IL_002d;
			IL_0122:
			result = false;
			end_IL_002d:;
		}
		catch (FileNotFoundException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			FileNotFoundException ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void CopyLicenseFile(string filePath)
	{
		string text = Application.StartupPath + "\\Simba.asialic";
		File.Delete(text);
		File.Copy(filePath, text);
	}
}
