using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public class MsSqlDynamicReportDAO : MsSqlDAO, DynamicReportDAO
{
	[DebuggerNonUserCode]
	public MsSqlDynamicReportDAO()
	{
	}

	public string GetFilterControl(string spName)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		_command.CommandText = "asDynGetControl4Form";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@sp_name", (object)spName);
		SqlParameter val = new SqlParameter();
		val.DbType = DbType.String;
		val.Direction = ParameterDirection.Output;
		val.ParameterName = "@str";
		val.Size = 500;
		_command.Parameters.Add(val);
		_command.ExecuteNonQuery();
		return _command.Parameters["@str"].Value.ToString();
	}

	string DynamicReportDAO.GetFilterControl(string spName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetFilterControl
		return this.GetFilterControl(spName);
	}

	public SqlParameterCollection GetStoreParameterInfo(string spName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = spName;
		SqlCommandBuilder.DeriveParameters(_command);
		return _command.Parameters;
	}

	SqlParameterCollection DynamicReportDAO.GetStoreParameterInfo(string spName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetStoreParameterInfo
		return this.GetStoreParameterInfo(spName);
	}
}
