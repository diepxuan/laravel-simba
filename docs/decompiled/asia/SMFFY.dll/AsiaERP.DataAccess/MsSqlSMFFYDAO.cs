using System;
using System.Data;
using System.Data.SqlClient;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.DataAccess;

public class MsSqlSMFFYDAO : MsSqlDAO, SMFFYDAO
{
	public int Update(DateTime ngay_ks)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		_command.CommandText = "asSiUpdFirstFinancialYear";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pNgay1", (object)ngay_ks);
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

	int SMFFYDAO.Update(DateTime ngay_ks)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Update
		return this.Update(ngay_ks);
	}
}
