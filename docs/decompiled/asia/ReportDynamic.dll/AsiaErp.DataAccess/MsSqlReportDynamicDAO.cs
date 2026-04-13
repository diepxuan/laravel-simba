using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public class MsSqlReportDynamicDAO : MsSqlDAO, ReportDynamicDAO
{
	[DebuggerNonUserCode]
	public MsSqlReportDynamicDAO()
	{
	}

	public string GetFilterControl(string spName)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
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

	string ReportDynamicDAO.GetFilterControl(string spName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetFilterControl
		return this.GetFilterControl(spName);
	}
}
