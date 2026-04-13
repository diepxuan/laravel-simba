using System.Data;
using AsiaErp.Framework;
using DTE.Bussiness;

namespace AsiaErp.DataAccess;

public interface SMUserInfoDAO : DAO
{
	int InsertUserRight(string UserName, string MenuID, bool ViewRight = true, bool InsertRight = true, bool UpdateRight = true, bool DeleteRight = true, int LimitedPrint = 0);

	DataTable GetAllUserRights(string UserName);

	DataTable GetAllUserRightDash(string UserName);

	DataSet GetUserGroup(string UserName);

	int InsertUserGroup(string GroupName, string UserName, int pDel);

	int DeleteUserGroup(string UserName);

	DataTable GetUserInfo();

	UserInfo GetUserInfoByUserName(string aUserName);

	bool ChangePassword(string aUserName, string aNew_pass);

	int InsertUserInfo(string UserName, string FullName, string Password, string IsAdmin, string Grand, string Disabled, string User);

	int UpdateUserRight(string UserName, string UserName_Old);

	int UpdateUserInfo(string UserName, string FullName, string IsAdmin, string Grand, string Disabled, string User);

	int DeleteUserInfo(string UserName);

	int DeleteUserRight(string UserName, string MenuID = "");

	DataSet GetGroupInfo();

	DataTable GetMenuForm();

	DataTable GetMenuBar();

	DataTable GetSubMenuBar();

	int ResetPassword(string UserName, string Password, string User);

	DataTable GetAllRightCompany(string UserName);

	int InsRightCompany(string Ma_cty, string UserName, string active);

	int DynInsertUpdateDeleteData(string pXmlData, string pTableName, string pMode, string pKeyColumns = "");
}
