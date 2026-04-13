using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.DataAccess;

public class MsSqlFAGiamTSDAO : MsSqlDAO, FAGiamTSDAO
{
	[DebuggerNonUserCode]
	public MsSqlFAGiamTSDAO()
	{
	}

	public bool ChkGiamTs(string Ma_Cty, string Ma_Ts, DateTime Ngay_Giam, string Moi_Sua)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		_command.CommandText = "asFAChkGiamTs";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)Ma_Cty);
		_command.Parameters.AddWithValue("@pMa_ts", (object)Ma_Ts);
		_command.Parameters.AddWithValue("@pNgay_giam", (object)Ngay_Giam);
		_command.Parameters.AddWithValue("@pMoi_Sua", (object)Moi_Sua);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value) != 0;
	}

	bool FAGiamTSDAO.ChkGiamTs(string Ma_Cty, string Ma_Ts, DateTime Ngay_Giam, string Moi_Sua)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ChkGiamTs
		return this.ChkGiamTs(Ma_Cty, Ma_Ts, Ngay_Giam, Moi_Sua);
	}

	public int Delete(string Ma_Cty, string Ma_Ts, string User)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		_command.CommandText = "asFADelGiamTS";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)Ma_Cty);
		_command.Parameters.AddWithValue("@pMa_ts", (object)Ma_Ts);
		_command.Parameters.AddWithValue("@pUser", (object)User);
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

	int FAGiamTSDAO.Delete(string Ma_Cty, string Ma_Ts, string User)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Delete
		return this.Delete(Ma_Cty, Ma_Ts, User);
	}

	public DataTable GetData(string Ma_Cty, string Ma_ts = "")
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asFAGetGiamTS";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)Ma_Cty);
		if (Operators.CompareString(Ma_ts, "", false) != 0)
		{
			_command.Parameters.AddWithValue("@pMa_Ts", (object)Ma_ts);
		}
		return GetDataTable();
	}

	DataTable FAGiamTSDAO.GetData(string Ma_Cty, string Ma_ts = "")
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData(Ma_Cty, Ma_ts);
	}

	public int Update(string ma_cty, string ma_ts, string ma_giam_ts, DateTime ngay_giam, int so_luong, string so_ct_giam, DateTime ngay_ct_giam, string User)
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		_command.CommandText = "asFAUpdGiamTS";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)ma_cty);
		_command.Parameters.AddWithValue("@pMa_ts", (object)ma_ts);
		_command.Parameters.AddWithValue("@pMa_Giam_Ts", (object)ma_giam_ts);
		_command.Parameters.AddWithValue("@pNgay_Giam", (object)ngay_giam);
		_command.Parameters.AddWithValue("@pSo_luong", (object)so_luong);
		_command.Parameters.AddWithValue("@pSo_ct_giam", (object)so_ct_giam);
		_command.Parameters.AddWithValue("@pNgay_ct_giam", (object)ngay_ct_giam);
		_command.Parameters.AddWithValue("@pUser", (object)User);
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

	int FAGiamTSDAO.Update(string ma_cty, string ma_ts, string ma_giam_ts, DateTime ngay_giam, int so_luong, string so_ct_giam, DateTime ngay_ct_giam, string User)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Update
		return this.Update(ma_cty, ma_ts, ma_giam_ts, ngay_giam, so_luong, so_ct_giam, ngay_ct_giam, User);
	}
}
