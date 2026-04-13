using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using DTE.Bussiness;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlSMUserInfoDAO : MsSqlDAO, SMUserInfoDAO
{
	public int InsertUserRight(string UserName, string MenuID, bool ViewRight = true, bool InsertRight = true, bool UpdateRight = true, bool DeleteRight = true, int LimitedPrint = 0)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsUserRight";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
		_command.Parameters.AddWithValue("@pMenuID", (object)MenuID);
		_command.Parameters.AddWithValue("@pViewRight", (object)ViewRight);
		_command.Parameters.AddWithValue("@pInsertRight", (object)InsertRight);
		_command.Parameters.AddWithValue("@pUpdateRight", (object)UpdateRight);
		_command.Parameters.AddWithValue("@pDeleteRight", (object)DeleteRight);
		_command.Parameters.AddWithValue("@pLimitedPrint", (object)LimitedPrint);
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

	int SMUserInfoDAO.InsertUserRight(string UserName, string MenuID, bool ViewRight = true, bool InsertRight = true, bool UpdateRight = true, bool DeleteRight = true, int LimitedPrint = 0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsertUserRight
		return this.InsertUserRight(UserName, MenuID, ViewRight, InsertRight, UpdateRight, DeleteRight, LimitedPrint);
	}

	public DataTable GetAllUserRights(string UserName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetAllUserRights";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		return GetDataTable();
	}

	DataTable SMUserInfoDAO.GetAllUserRights(string UserName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetAllUserRights
		return this.GetAllUserRights(UserName);
	}

	public DataTable GetAllUserRightDash(string UserName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetAllRightDash";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		return GetDataTable();
	}

	DataTable SMUserInfoDAO.GetAllUserRightDash(string UserName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetAllUserRightDash
		return this.GetAllUserRightDash(UserName);
	}

	public DataSet GetUserGroup(string UserName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetUserGroup";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
		return GetDataSet();
	}

	DataSet SMUserInfoDAO.GetUserGroup(string UserName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetUserGroup
		return this.GetUserGroup(UserName);
	}

	public int InsertUserGroup(string GroupName, string UserName, int pDel)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsUserGroup";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pGroupName", (object)GroupName);
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
		_command.Parameters.AddWithValue("@pDel", (object)pDel);
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

	int SMUserInfoDAO.InsertUserGroup(string GroupName, string UserName, int pDel)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsertUserGroup
		return this.InsertUserGroup(GroupName, UserName, pDel);
	}

	public int DeleteUserGroup(string UserName)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDelUserGroup";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
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

	int SMUserInfoDAO.DeleteUserGroup(string UserName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DeleteUserGroup
		return this.DeleteUserGroup(UserName);
	}

	public DataTable GetUserInfo()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetUserInfo";
		_command.Parameters.Clear();
		return GetDataTable();
	}

	DataTable SMUserInfoDAO.GetUserInfo()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetUserInfo
		return this.GetUserInfo();
	}

	public UserInfo GetUserInfoByUserName(string aUserName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetUserInfoByUserName";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)aUserName);
		SqlDataReader dataReader = GetDataReader();
		return (UserInfo)CBO.FillObject((IDataReader)dataReader, typeof(UserInfo));
	}

	UserInfo SMUserInfoDAO.GetUserInfoByUserName(string aUserName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetUserInfoByUserName
		return this.GetUserInfoByUserName(aUserName);
	}

	public bool ChangePassword(string aUserName, string aNew_pass)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asChangePassword";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)aUserName);
		_command.Parameters.AddWithValue("@pPassword", (object)aNew_pass);
		return ExecuteNonQuery() == 0;
	}

	bool SMUserInfoDAO.ChangePassword(string aUserName, string aNew_pass)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ChangePassword
		return this.ChangePassword(aUserName, aNew_pass);
	}

	public int InsertUserInfo(string UserName, string FullName, string Password, string IsAdmin, string Grand, string Disabled, string User)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsUserInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
		_command.Parameters.AddWithValue("@pFullName", (object)FullName);
		_command.Parameters.AddWithValue("@pPassword", (object)Password);
		_command.Parameters.AddWithValue("@pIsAdmin", (object)IsAdmin);
		_command.Parameters.AddWithValue("@pGrand", (object)Grand);
		_command.Parameters.AddWithValue("@pDisabled", (object)Disabled);
		_command.Parameters.AddWithValue("@pUSER", (object)User);
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

	int SMUserInfoDAO.InsertUserInfo(string UserName, string FullName, string Password, string IsAdmin, string Grand, string Disabled, string User)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsertUserInfo
		return this.InsertUserInfo(UserName, FullName, Password, IsAdmin, Grand, Disabled, User);
	}

	public int UpdateUserRight(string UserName, string UserName_Old)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpdUserRight";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
		_command.Parameters.AddWithValue("@pUserName_Old", (object)UserName_Old);
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

	int SMUserInfoDAO.UpdateUserRight(string UserName, string UserName_Old)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdateUserRight
		return this.UpdateUserRight(UserName, UserName_Old);
	}

	public int UpdateUserInfo(string UserName, string FullName, string IsAdmin, string Grand, string Disabled, string User)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpdUserInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
		_command.Parameters.AddWithValue("@pFullName", (object)FullName);
		_command.Parameters.AddWithValue("@pIsAdmin", (object)IsAdmin);
		_command.Parameters.AddWithValue("@pGrand", (object)Grand);
		_command.Parameters.AddWithValue("@pDisabled", (object)Disabled);
		_command.Parameters.AddWithValue("@pUser", (object)User);
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

	int SMUserInfoDAO.UpdateUserInfo(string UserName, string FullName, string IsAdmin, string Grand, string Disabled, string User)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdateUserInfo
		return this.UpdateUserInfo(UserName, FullName, IsAdmin, Grand, Disabled, User);
	}

	public int DeleteUserInfo(string UserName)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDelUserInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
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

	int SMUserInfoDAO.DeleteUserInfo(string UserName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DeleteUserInfo
		return this.DeleteUserInfo(UserName);
	}

	public int DeleteUserRight(string UserName, string MenuID = "")
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDelUserRight";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
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

	int SMUserInfoDAO.DeleteUserRight(string UserName, string MenuID = "")
	{
		//ILSpy generated this explicit interface implementation from .override directive in DeleteUserRight
		return this.DeleteUserRight(UserName, MenuID);
	}

	public DataSet GetGroupInfo()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetGroupInfo";
		_command.Parameters.Clear();
		return GetDataSet();
	}

	DataSet SMUserInfoDAO.GetGroupInfo()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetGroupInfo
		return this.GetGroupInfo();
	}

	public DataTable GetMenuForm()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetMenuForm";
		_command.Parameters.Clear();
		return GetDataTable();
	}

	DataTable SMUserInfoDAO.GetMenuForm()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetMenuForm
		return this.GetMenuForm();
	}

	public DataTable GetMenuBar()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetMenuBar";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		return GetDataTable();
	}

	DataTable SMUserInfoDAO.GetMenuBar()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetMenuBar
		return this.GetMenuBar();
	}

	public DataTable GetSubMenuBar()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetMenuDetail";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		return GetDataTable();
	}

	DataTable SMUserInfoDAO.GetSubMenuBar()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetSubMenuBar
		return this.GetSubMenuBar();
	}

	public int ResetPassword(string UserName, string Password, string User)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asResetPassword";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
		_command.Parameters.AddWithValue("@pPassword", (object)Password);
		_command.Parameters.AddWithValue("@pUSER", (object)User);
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

	int SMUserInfoDAO.ResetPassword(string UserName, string Password, string User)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ResetPassword
		return this.ResetPassword(UserName, Password, User);
	}

	public DataTable GetAllRightCompany(string UserName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetAllRightCompany";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
		DataTable result;
		try
		{
			result = GetDataTable();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	DataTable SMUserInfoDAO.GetAllRightCompany(string UserName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetAllRightCompany
		return this.GetAllRightCompany(UserName);
	}

	public int InsRightCompany(string Ma_cty, string UserName, string active)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsRightCompany";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)Ma_cty);
		_command.Parameters.AddWithValue("@pActive", (object)active);
		_command.Parameters.AddWithValue("@pUserName", (object)UserName);
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
			int result = 1;
			ProjectData.ClearProjectError();
			return result;
		}
		return Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
	}

	int SMUserInfoDAO.InsRightCompany(string Ma_cty, string UserName, string active)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsRightCompany
		return this.InsRightCompany(Ma_cty, UserName, active);
	}

	public int DynInsertUpdateDeleteData(string pXmlData, string pTableName, string pMode, string pKeyColumns = "")
	{
		_command.CommandText = "asSiDynInsertUpdateDeleteData";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pXmlData", (object)pXmlData);
		_command.Parameters.AddWithValue("@pTable_name", (object)pTableName);
		_command.Parameters.AddWithValue("@pMode", (object)pMode);
		_command.Parameters.AddWithValue("@pKeyColumns", (object)pKeyColumns);
		return ExecuteNonQuery();
	}

	int SMUserInfoDAO.DynInsertUpdateDeleteData(string pXmlData, string pTableName, string pMode, string pKeyColumns = "")
	{
		//ILSpy generated this explicit interface implementation from .override directive in DynInsertUpdateDeleteData
		return this.DynInsertUpdateDeleteData(pXmlData, pTableName, pMode, pKeyColumns);
	}
}
