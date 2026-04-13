using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface iSiGroupInfo : DAO
{
	DataTable GetGroupInfo(string GroupName);

	int InsertGroupInfo(string GroupName, string fullName, bool KSD, bool Grand);

	int DeleteGroupInfo(string GroupName);

	int UpdateGroupInfo(string GroupName, string fullName, bool KSD, bool Grand);

	int InsertGroupRight(string GroupName, string MenuID, bool ViewRight = true, bool InsertRight = true, bool UpdateRight = true, bool DeleteRight = true);

	DataTable GetAllGroupRights(string GroupName);

	int UpdateGroupRight(string GroupName, string GroupName_Old);

	int DeleteGroupRight(string GroupName, string MenuID = "");

	DataTable GetMenuBar();

	DataTable GetSubMenuBar();

	bool CheckGroupGrand(string UserName);
}
