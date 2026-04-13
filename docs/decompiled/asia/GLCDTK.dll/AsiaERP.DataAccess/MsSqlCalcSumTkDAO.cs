using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;

namespace AsiaERP.DataAccess;

public class MsSqlCalcSumTkDAO : MsSqlDAO, ICalcSumTKDAO
{
	[DebuggerNonUserCode]
	public MsSqlCalcSumTkDAO()
	{
	}

	public DataTable CalcSumCdTk(string pMa_cty, string pMa_tk, int pNam, string pMa_nt)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		_command.Parameters.Clear();
		_command.CommandText = "[dbo].[asGLCalSumCdTk]";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pTk", (object)pMa_tk);
		_command.Parameters.AddWithValue("@pNam", (object)pNam);
		_command.Parameters.AddWithValue("@pMa_nt", (object)pMa_nt);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.Direction = ParameterDirection.Output;
		val2.DbType = DbType.Int32;
		val2 = null;
		_command.Parameters.Add(val);
		return GetDataTable();
	}

	DataTable ICalcSumTKDAO.CalcSumCdTk(string pMa_cty, string pMa_tk, int pNam, string pMa_nt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CalcSumCdTk
		return this.CalcSumCdTk(pMa_cty, pMa_tk, pNam, pMa_nt);
	}
}
