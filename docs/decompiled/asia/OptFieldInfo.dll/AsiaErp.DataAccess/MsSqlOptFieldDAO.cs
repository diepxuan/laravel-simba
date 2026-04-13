using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlOptFieldDAO : MsSqlDAO, OptFieldDAO
{
	[DebuggerNonUserCode]
	public MsSqlOptFieldDAO()
	{
	}

	public DataTable GetOptField()
	{
		_command.CommandText = "asGetOptFieldInfo";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.ExecuteNonQuery();
		return GetDataTable();
	}

	DataTable OptFieldDAO.GetOptField()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetOptField
		return this.GetOptField();
	}

	public int UpdOptField(int pStt, string pField, string pCaption, string pUser)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		_command.CommandText = "asUpdOptFieldInfo";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pStt", (object)pStt);
		_command.Parameters.AddWithValue("@pField", (object)pField);
		_command.Parameters.AddWithValue("@pCaption", (object)pCaption);
		_command.Parameters.AddWithValue("@pLUser", (object)pUser);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.DbType = DbType.Int32;
		val2.ParameterName = "pRet";
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int OptFieldDAO.UpdOptField(int pStt, string pField, string pCaption, string pUser)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdOptField
		return this.UpdOptField(pStt, pField, pCaption, pUser);
	}
}
