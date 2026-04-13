using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlGLRptBCT03DAO : MsSqlDAO, GLRptBCT03DAO
{
	[DebuggerNonUserCode]
	public MsSqlGLRptBCT03DAO()
	{
	}

	public int DieuChinhBCT03(params object[] para)
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		_command.CommandText = "asGLRptBCT03_dieuchinh";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pThang1", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pThang2", RuntimeHelpers.GetObjectValue(para[2]));
		_command.Parameters.AddWithValue("@pNam", RuntimeHelpers.GetObjectValue(para[3]));
		_command.Parameters.AddWithValue("@pStt_rec", RuntimeHelpers.GetObjectValue(para[4]));
		_command.Parameters.AddWithValue("@pDoanh_so", RuntimeHelpers.GetObjectValue(para[5]));
		_command.Parameters.AddWithValue("@pThue", RuntimeHelpers.GetObjectValue(para[6]));
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int GLRptBCT03DAO.DieuChinhBCT03(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DieuChinhBCT03
		return this.DieuChinhBCT03(para);
	}
}
