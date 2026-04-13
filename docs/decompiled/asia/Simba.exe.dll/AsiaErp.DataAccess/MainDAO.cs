using System.Collections;
using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface MainDAO : DAO
{
	DataTable GetCompanyInfo(string aMa_cty);

	DataTable GetCompanyInfoByUserName(string aUserName);

	DataTable GetMainMenu(string aUserName);

	ArrayList GetMainMenuInfo(string aUserName, string pLanguage = "vi-VN");

	bool Logon(string aMa_Cty, string aUserName, string aPassword, ref bool aIsAdmin, ref bool aIsGrand);

	bool PreLogon(string aUserName, string aPassword);

	DataTable getCultureInfo();

	string getCurrentCultureInfo();

	bool UpdateCurrentCultureInfo(string aName);

	DataTable GetAllLanguage();
}
