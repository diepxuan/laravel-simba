using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.DataAccess;

public class MsSqlSMKSDAO : MsSqlDAO, SMKSDAO
{
	[DebuggerNonUserCode]
	public MsSqlSMKSDAO()
	{
	}

	public int Update(string ma_cty, DateTime ngay_ks)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		_command.CommandText = "assiUpd_ks";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)ma_cty);
		_command.Parameters.AddWithValue("@pNgay_ks", (object)ngay_ks);
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

	int SMKSDAO.Update(string ma_cty, DateTime ngay_ks)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Update
		return this.Update(ma_cty, ngay_ks);
	}
}
