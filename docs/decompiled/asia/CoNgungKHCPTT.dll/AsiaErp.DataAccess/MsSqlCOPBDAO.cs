using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlCOPBDAO : MsSqlDAO, COPBDAO
{
	[DebuggerNonUserCode]
	public MsSqlCOPBDAO()
	{
	}

	public int CoUpdNgungKH_CPTT(params object[] Para)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		_command.CommandText = "asCoUpdNgungKH_CPTT";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(Para[0]));
		_command.Parameters.AddWithValue("@pMa_cptt", RuntimeHelpers.GetObjectValue(Para[1]));
		_command.Parameters.AddWithValue("@pNgay_tkh", RuntimeHelpers.GetObjectValue(Para[2]));
		_command.Parameters.AddWithValue("@pKh_so_du", RuntimeHelpers.GetObjectValue(Para[3]));
		_command.Parameters.AddWithValue("@pIsUpd", RuntimeHelpers.GetObjectValue(Para[4]));
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

	int COPBDAO.CoUpdNgungKH_CPTT(params object[] Para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CoUpdNgungKH_CPTT
		return this.CoUpdNgungKH_CPTT(Para);
	}

	public int CoDelNgungKH_CPTT(params object[] para)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		_command.CommandText = "asCoDelNgungKH_CPTT";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pMa_cptt", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pId", RuntimeHelpers.GetObjectValue(para[2]));
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

	int COPBDAO.CoDelNgungKH_CPTT(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CoDelNgungKH_CPTT
		return this.CoDelNgungKH_CPTT(para);
	}
}
