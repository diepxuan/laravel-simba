using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlMainDAO : MsSqlDAO, MainDAO
{
	[DebuggerNonUserCode]
	public MsSqlMainDAO()
	{
	}

	public DataTable GetCompanyInfo(string aMa_cty)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetCompanyInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_cty);
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		return GetDataTable();
	}

	DataTable MainDAO.GetCompanyInfo(string aMa_cty)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetCompanyInfo
		return this.GetCompanyInfo(aMa_cty);
	}

	public DataTable GetCompanyInfoByUserName(string aUserName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetCompanyInfoByUserName";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)aUserName);
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		return GetDataTable();
	}

	DataTable MainDAO.GetCompanyInfoByUserName(string aUserName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetCompanyInfoByUserName
		return this.GetCompanyInfoByUserName(aUserName);
	}

	public DataTable GetMainMenu(string aUserName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "dbo.asGetMainMenu";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)aUserName);
		return GetDataTable();
	}

	DataTable MainDAO.GetMainMenu(string aUserName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetMainMenu
		return this.GetMainMenu(aUserName);
	}

	public ArrayList GetMainMenuInfo(string aUserName, string pLanguage = "vi-VN")
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "dbo.asGetMainMenu";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)aUserName);
		_command.Parameters.AddWithValue("@pLanguage", (object)pLanguage);
		SqlDataReader dataReader = GetDataReader();
		if (dataReader == null)
		{
			return null;
		}
		return CBO.FillCollection((IDataReader)dataReader, typeof(MenuInformation));
	}

	ArrayList MainDAO.GetMainMenuInfo(string aUserName, string pLanguage = "vi-VN")
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetMainMenuInfo
		return this.GetMainMenuInfo(aUserName, pLanguage);
	}

	public bool Logon(string aMa_Cty, string aUserName, string aPassword, ref bool aIsAdmin, ref bool aIsGrand)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asChkUserLogin";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)aMa_Cty);
		_command.Parameters.AddWithValue("@pUserName", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(aUserName, isNum: false)));
		_command.Parameters.AddWithValue("@pPassword", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(aPassword, isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pOk";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		val = new SqlParameter();
		val.ParameterName = "@pIsAdmin";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		val = new SqlParameter();
		val.ParameterName = "@pIsGrand";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		aIsAdmin = Operators.ConditionalCompareObjectGreater(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pIsAdmin"].Value), isNum: true), (object)0, false);
		aIsGrand = Operators.ConditionalCompareObjectGreater(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pIsGrand"].Value), isNum: true), (object)0, false);
		return Operators.ConditionalCompareObjectGreater(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pOk"].Value), isNum: true), (object)0, false);
	}

	bool MainDAO.Logon(string aMa_Cty, string aUserName, string aPassword, ref bool aIsAdmin, ref bool aIsGrand)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Logon
		return this.Logon(aMa_Cty, aUserName, aPassword, ref aIsAdmin, ref aIsGrand);
	}

	public bool PreLogon(string aUserName, string aPassword)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPreChkUserLogin";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(aUserName, isNum: false)));
		_command.Parameters.AddWithValue("@pPassword", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(aPassword, isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pOk";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Operators.ConditionalCompareObjectGreater(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pOk"].Value), isNum: true), (object)0, false);
	}

	bool MainDAO.PreLogon(string aUserName, string aPassword)
	{
		//ILSpy generated this explicit interface implementation from .override directive in PreLogon
		return this.PreLogon(aUserName, aPassword);
	}

	public DataTable getCultureInfo()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetCultureInfo";
		_command.Parameters.Clear();
		return GetDataTable();
	}

	DataTable MainDAO.getCultureInfo()
	{
		//ILSpy generated this explicit interface implementation from .override directive in getCultureInfo
		return this.getCultureInfo();
	}

	public string getCurrentCultureInfo()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetCurrentCultureInfo";
		_command.Parameters.Clear();
		return Conversions.ToString(ExecuteScalar());
	}

	string MainDAO.getCurrentCultureInfo()
	{
		//ILSpy generated this explicit interface implementation from .override directive in getCurrentCultureInfo
		return this.getCurrentCultureInfo();
	}

	public bool UpdateCurrentCultureInfo(string aName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpdCurentCultureInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pName", (object)aName);
		return ExecuteNonQuery() != 0;
	}

	bool MainDAO.UpdateCurrentCultureInfo(string aName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdateCurrentCultureInfo
		return this.UpdateCurrentCultureInfo(aName);
	}

	public DataTable GetAllLanguage()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetAllLanguage";
		_command.Parameters.Clear();
		return GetDataTable();
	}

	DataTable MainDAO.GetAllLanguage()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetAllLanguage
		return this.GetAllLanguage();
	}
}
