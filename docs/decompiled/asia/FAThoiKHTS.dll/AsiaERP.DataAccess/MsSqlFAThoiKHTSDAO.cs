using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.DataAccess;

public class MsSqlFAThoiKHTSDAO : MsSqlDAO, IFAThoiKHTSDAO
{
	[DebuggerNonUserCode]
	public MsSqlFAThoiKHTSDAO()
	{
	}

	public int Check(string pMa_cty, string pMa_ts, DateTime pNgay_dung_kh)
	{
		_command.CommandText = "asFAChkThoiKHTS";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pMa_ts", (object)pMa_ts);
		_command.Parameters.AddWithValue("@pNgay_dung_kh", (object)pNgay_dung_kh);
		return Conversions.ToInteger(ExecuteScalar());
	}

	int IFAThoiKHTSDAO.Check(string pMa_cty, string pMa_ts, DateTime pNgay_dung_kh)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Check
		return this.Check(pMa_cty, pMa_ts, pNgay_dung_kh);
	}

	public int Delete(string pMa_cty, string pMa_ts, DateTime pNgay_dung_kh)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		_command.CommandText = "asFaDelDungKH";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pMa_ts", (object)pMa_ts);
		_command.Parameters.AddWithValue("@pNgay_dung_kh", (object)pNgay_dung_kh);
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

	int IFAThoiKHTSDAO.Delete(string pMa_cty, string pMa_ts, DateTime pNgay_dung_kh)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Delete
		return this.Delete(pMa_cty, pMa_ts, pNgay_dung_kh);
	}
}
