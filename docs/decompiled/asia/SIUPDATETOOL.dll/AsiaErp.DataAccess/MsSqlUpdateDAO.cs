using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public class MsSqlUpdateDAO : MsSqlDAO, UpdateDAO
{
	[DebuggerNonUserCode]
	public MsSqlUpdateDAO()
	{
	}

	public int ExecuteTSQL(string tSQL)
	{
		_command.CommandType = CommandType.Text;
		_command.CommandText = tSQL;
		return _command.ExecuteNonQuery();
	}

	int UpdateDAO.ExecuteTSQL(string tSQL)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ExecuteTSQL
		return this.ExecuteTSQL(tSQL);
	}

	public int InsertLogUpdate(params object[] param)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSIInsLogUpdate";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)SystemInformations.UserName);
		_command.Parameters.AddWithValue("@pContent", RuntimeHelpers.GetObjectValue(param[0]));
		return _command.ExecuteNonQuery();
	}

	int UpdateDAO.InsertLogUpdate(params object[] param)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsertLogUpdate
		return this.InsertLogUpdate(param);
	}
}
