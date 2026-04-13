using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlGLDMTKDAO : MsSqlDAO, IGLDMTKDAO
{
	[DebuggerNonUserCode]
	public MsSqlGLDMTKDAO()
	{
	}

	public int CheckTkMe(string pTk)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		_command.CommandText = "asGlCheckTkMe";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pTk", (object)pTk);
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.SqlDbType = SqlDbType.Int;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int IGLDMTKDAO.CheckTkMe(string pTk)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CheckTkMe
		return this.CheckTkMe(pTk);
	}
}
