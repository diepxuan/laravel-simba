using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlSiGroupInfoDao : MsSqlDAO, iSiGroupInfo
{
	public int DeleteGroupInfo(string pGroupName)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSiDelGroupInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pGroupName", (object)pGroupName);
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
		return Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
	}

	int iSiGroupInfo.DeleteGroupInfo(string pGroupName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DeleteGroupInfo
		return this.DeleteGroupInfo(pGroupName);
	}

	public DataTable GetGroupInfo(string pGroupName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetGroupInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pGroupName", (object)pGroupName);
		return GetDataTable();
	}

	DataTable iSiGroupInfo.GetGroupInfo(string pGroupName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetGroupInfo
		return this.GetGroupInfo(pGroupName);
	}

	public int InsertGroupInfo(string pGroupName, string pfullName, bool pKSD, bool pGrand)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsGroupInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pGroupName", (object)pGroupName);
		_command.Parameters.AddWithValue("@pfullName", (object)pfullName);
		_command.Parameters.AddWithValue("@pKSD", (object)pKSD);
		_command.Parameters.AddWithValue("@pGrand", (object)pGrand);
		_command.Parameters.AddWithValue("@pUser", (object)SystemInformations.UserName);
		if (ExecuteNonQuery() == 0)
		{
			return -1;
		}
		return 0;
	}

	int iSiGroupInfo.InsertGroupInfo(string pGroupName, string pfullName, bool pKSD, bool pGrand)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsertGroupInfo
		return this.InsertGroupInfo(pGroupName, pfullName, pKSD, pGrand);
	}

	public int UpdateGroupInfo(string pGroupName, string pfullName, bool pKSD, bool pGrand)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpdGroupInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pGroupName", (object)pGroupName);
		_command.Parameters.AddWithValue("@pfullName", (object)pfullName);
		_command.Parameters.AddWithValue("@pKSD", (object)pKSD);
		_command.Parameters.AddWithValue("@pGrand", (object)pGrand);
		_command.Parameters.AddWithValue("@pUser", (object)SystemInformations.UserName);
		if (ExecuteNonQuery() == 0)
		{
			return -1;
		}
		return 0;
	}

	int iSiGroupInfo.UpdateGroupInfo(string pGroupName, string pfullName, bool pKSD, bool pGrand)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdateGroupInfo
		return this.UpdateGroupInfo(pGroupName, pfullName, pKSD, pGrand);
	}

	public int InsertGroupRight(string GroupName, string MenuID, bool ViewRight = true, bool InsertRight = true, bool UpdateRight = true, bool DeleteRight = true)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsGroupRight";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pGroupName", (object)GroupName);
		_command.Parameters.AddWithValue("@pMenuID", (object)MenuID);
		_command.Parameters.AddWithValue("@pViewRight", (object)ViewRight);
		_command.Parameters.AddWithValue("@pInsertRight", (object)InsertRight);
		_command.Parameters.AddWithValue("@pUpdateRight", (object)UpdateRight);
		_command.Parameters.AddWithValue("@pDeleteRight", (object)DeleteRight);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = new SqlParameter();
		val2.ParameterName = "@pRet";
		val2.DbType = DbType.Double;
		val2.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val2);
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
		return Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
	}

	int iSiGroupInfo.InsertGroupRight(string GroupName, string MenuID, bool ViewRight = true, bool InsertRight = true, bool UpdateRight = true, bool DeleteRight = true)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsertGroupRight
		return this.InsertGroupRight(GroupName, MenuID, ViewRight, InsertRight, UpdateRight, DeleteRight);
	}

	public DataTable GetAllGroupRights(string GroupName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSiGetAllGroupRights";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pGroupName", (object)GroupName);
		return GetDataTable();
	}

	DataTable iSiGroupInfo.GetAllGroupRights(string GroupName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetAllGroupRights
		return this.GetAllGroupRights(GroupName);
	}

	public int UpdateGroupRight(string GroupName, string GroupName_Old)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpdGroupRight";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pGroupName", (object)GroupName);
		_command.Parameters.AddWithValue("@pGroupName_Old", (object)GroupName_Old);
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.StackTrace);
			ProjectData.ClearProjectError();
		}
		return Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
	}

	int iSiGroupInfo.UpdateGroupRight(string GroupName, string GroupName_Old)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdateGroupRight
		return this.UpdateGroupRight(GroupName, GroupName_Old);
	}

	public int DeleteGroupRight(string GroupName, string MenuID = "")
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDelGroupRight";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pGroupName", (object)GroupName);
		_command.Parameters.AddWithValue("@pMenuID", (object)MenuID);
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
		return Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
	}

	int iSiGroupInfo.DeleteGroupRight(string GroupName, string MenuID = "")
	{
		//ILSpy generated this explicit interface implementation from .override directive in DeleteGroupRight
		return this.DeleteGroupRight(GroupName, MenuID);
	}

	public DataTable GetMenuBar()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetMenuBar";
		_command.Parameters.Clear();
		return GetDataTable();
	}

	DataTable iSiGroupInfo.GetMenuBar()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetMenuBar
		return this.GetMenuBar();
	}

	public DataTable GetSubMenuBar()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetMenuDetail";
		_command.Parameters.Clear();
		return GetDataTable();
	}

	DataTable iSiGroupInfo.GetSubMenuBar()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetSubMenuBar
		return this.GetSubMenuBar();
	}

	public bool CheckGroupGrand(string pUserName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGroupCheckGrand";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)pUserName);
		return Conversions.ToBoolean(ExecuteScalar());
	}

	bool iSiGroupInfo.CheckGroupGrand(string pUserName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CheckGroupGrand
		return this.CheckGroupGrand(pUserName);
	}
}
