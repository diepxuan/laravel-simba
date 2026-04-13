using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlFABHCCDAO : MsSqlDAO, IFABHCCDAO
{
	[DebuggerNonUserCode]
	public MsSqlFABHCCDAO()
	{
	}

	public int Delete(string pMa_cty, string pMa_cc, int pId)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		_command.CommandText = "asFaDelBHCC";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pMa_cc", (object)pMa_cc);
		_command.Parameters.AddWithValue("@pID", (object)pId);
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

	int IFABHCCDAO.Delete(string pMa_cty, string pMa_cc, int pId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Delete
		return this.Delete(pMa_cty, pMa_cc, pId);
	}

	public DataTable GetData(string pMa_cty)
	{
		return GetDataTable("asFaGetBHCC", pMa_cty);
	}

	DataTable IFABHCCDAO.GetData(string pMa_cty)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData(pMa_cty);
	}

	public int Insert(DataRow oDrw)
	{
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		_command.CommandText = "asFaInsBHCC";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(oDrw["ma_cty"]));
		_command.Parameters.AddWithValue("@pMa_cc", RuntimeHelpers.GetObjectValue(oDrw["ma_cc"]));
		_command.Parameters.AddWithValue("@pstt_rec", RuntimeHelpers.GetObjectValue(oDrw["stt_rec"]));
		_command.Parameters.AddWithValue("@pstt_rec0", RuntimeHelpers.GetObjectValue(oDrw["stt_rec0"]));
		_command.Parameters.AddWithValue("@pSo_ct", RuntimeHelpers.GetObjectValue(oDrw["so_ct"]));
		_command.Parameters.AddWithValue("@pNgay_ct", RuntimeHelpers.GetObjectValue(oDrw["Ngay_ct"]));
		_command.Parameters.AddWithValue("@pTen_cc", RuntimeHelpers.GetObjectValue(oDrw["ten_cc"]));
		_command.Parameters.AddWithValue("@pDvt", RuntimeHelpers.GetObjectValue(oDrw["Dvt"]));
		_command.Parameters.AddWithValue("@pSo_luong", RuntimeHelpers.GetObjectValue(oDrw["so_luong"]));
		_command.Parameters.AddWithValue("@pDon_gia", RuntimeHelpers.GetObjectValue(oDrw["don_gia"]));
		_command.Parameters.AddWithValue("@pNgay_giam", RuntimeHelpers.GetObjectValue(oDrw["Ngay_giam"]));
		_command.Parameters.AddWithValue("@pmoduleid", RuntimeHelpers.GetObjectValue(oDrw["moduleid"]));
		_command.Parameters.AddWithValue("@pUser", RuntimeHelpers.GetObjectValue(oDrw["LUser"]));
		_command.Parameters.AddWithValue("@pTk_cp", RuntimeHelpers.GetObjectValue(oDrw["Tk_cp"]));
		_command.Parameters.AddWithValue("@pTk_cc", RuntimeHelpers.GetObjectValue(oDrw["Tk_cc"]));
		_command.Parameters.AddWithValue("@pMa_bpsd", RuntimeHelpers.GetObjectValue(oDrw["Ma_bpsd"]));
		_command.Parameters.AddWithValue("@pGt_da_Kh", RuntimeHelpers.GetObjectValue(oDrw["Gt_da_Kh"]));
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

	int IFABHCCDAO.Insert(DataRow oDrw)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Insert
		return this.Insert(oDrw);
	}

	public int Update(DataRow oDrw)
	{
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		_command.CommandText = "asFaUpdBHCC";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(oDrw["ma_cty"]));
		_command.Parameters.AddWithValue("@pMa_cc", RuntimeHelpers.GetObjectValue(oDrw["ma_cc"]));
		_command.Parameters.AddWithValue("@pSo_luong", RuntimeHelpers.GetObjectValue(oDrw["so_luong"]));
		_command.Parameters.AddWithValue("@pNgay_giam", RuntimeHelpers.GetObjectValue(oDrw["Ngay_giam"]));
		_command.Parameters.AddWithValue("@pUser", RuntimeHelpers.GetObjectValue(oDrw["LUser"]));
		_command.Parameters.AddWithValue("@pID", RuntimeHelpers.GetObjectValue(oDrw["ID"]));
		_command.Parameters.AddWithValue("@pTk_cp", RuntimeHelpers.GetObjectValue(oDrw["Tk_cp"]));
		_command.Parameters.AddWithValue("@pMa_bpsd", RuntimeHelpers.GetObjectValue(oDrw["Ma_bpsd"]));
		_command.Parameters.AddWithValue("@pGt_da_Kh", RuntimeHelpers.GetObjectValue(oDrw["Gt_da_Kh"]));
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

	int IFABHCCDAO.Update(DataRow oDrw)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Update
		return this.Update(oDrw);
	}

	public DataTable GetBHCCInfor(string pMa_cty, string pMa_cc, int pId, bool pIsEdit, string stt_rec)
	{
		_command.CommandText = "asFaGetBHCCInfo";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pMa_cc", (object)pMa_cc);
		_command.Parameters.AddWithValue("@pId", (object)pId);
		_command.Parameters.AddWithValue("@pIsEdit", (object)pIsEdit);
		_command.Parameters.AddWithValue("@pStt_rec", (object)stt_rec);
		return GetDataTable();
	}

	DataTable IFABHCCDAO.GetBHCCInfor(string pMa_cty, string pMa_cc, int pId, bool pIsEdit, string stt_rec)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetBHCCInfor
		return this.GetBHCCInfor(pMa_cty, pMa_cc, pId, pIsEdit, stt_rec);
	}
}
