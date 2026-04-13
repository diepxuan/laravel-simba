using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlARPost2TTDAO : MsSqlDAO, ARPost2TTDAO
{
	[DebuggerNonUserCode]
	public MsSqlARPost2TTDAO()
	{
	}

	public DataTable GetData()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asARGetMaCT";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		return GetDataTable();
	}

	DataTable ARPost2TTDAO.GetData()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData();
	}

	public DataTable GetData(string Tk, string Ma_kh, DateTime Ngay_ct, string Loai, string stt_rec = null)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asARGetPost2TT_ARTT";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pStt_rec", (object)stt_rec);
		_command.Parameters.AddWithValue("@pTk_pt", (object)Tk);
		_command.Parameters.AddWithValue("@pMa_kh", (object)Ma_kh);
		_command.Parameters.AddWithValue("@pNgay_ct", (object)Ngay_ct);
		_command.Parameters.AddWithValue("@pLoai", (object)Loai);
		return GetDataTable();
	}

	DataTable ARPost2TTDAO.GetData(string Tk, string Ma_kh, DateTime Ngay_ct, string Loai, string stt_rec = null)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData(Tk, Ma_kh, Ngay_ct, Loai, stt_rec);
	}

	public DataTable GetDataCT(params object[] array)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asARGetPost2TT";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pLoai_ct", RuntimeHelpers.GetObjectValue(array[0]));
		_command.Parameters.AddWithValue("@pSo1", RuntimeHelpers.GetObjectValue(array[1]));
		_command.Parameters.AddWithValue("@pSo2", RuntimeHelpers.GetObjectValue(array[2]));
		_command.Parameters.AddWithValue("@pNgay1", RuntimeHelpers.GetObjectValue(array[3]));
		_command.Parameters.AddWithValue("@pNgay2", RuntimeHelpers.GetObjectValue(array[4]));
		_command.Parameters.AddWithValue("@pMa_kh", RuntimeHelpers.GetObjectValue(array[5]));
		_command.Parameters.AddWithValue("@pTk", RuntimeHelpers.GetObjectValue(array[6]));
		_command.Parameters.AddWithValue("@pDien_giai", RuntimeHelpers.GetObjectValue(array[7]));
		return GetDataTable();
	}

	DataTable ARPost2TTDAO.GetDataCT(params object[] array)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDataCT
		return this.GetDataCT(array);
	}

	public int Insert(params object[] array)
	{
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		_command.CommandText = "asARInsPost2TT_ARTT";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pStt_rec", RuntimeHelpers.GetObjectValue(array[0]));
		_command.Parameters.AddWithValue("@pStt_rec_hd", RuntimeHelpers.GetObjectValue(array[1]));
		_command.Parameters.AddWithValue("@pMa_ct", RuntimeHelpers.GetObjectValue(array[2]));
		_command.Parameters.AddWithValue("@pNguoi_gd", RuntimeHelpers.GetObjectValue(array[3]));
		_command.Parameters.AddWithValue("@pDien_giai", RuntimeHelpers.GetObjectValue(array[4]));
		_command.Parameters.AddWithValue("@pTk_pt", RuntimeHelpers.GetObjectValue(array[5]));
		_command.Parameters.AddWithValue("@pMa_kh", RuntimeHelpers.GetObjectValue(array[6]));
		_command.Parameters.AddWithValue("@pSo_ct", RuntimeHelpers.GetObjectValue(array[7]));
		_command.Parameters.AddWithValue("@pNgay_ct", RuntimeHelpers.GetObjectValue(array[8]));
		_command.Parameters.AddWithValue("@pMa_nt", RuntimeHelpers.GetObjectValue(array[9]));
		_command.Parameters.AddWithValue("@pTy_gia", RuntimeHelpers.GetObjectValue(array[10]));
		_command.Parameters.AddWithValue("@pT_tt", RuntimeHelpers.GetObjectValue(array[11]));
		_command.Parameters.AddWithValue("@pT_tt_nt", RuntimeHelpers.GetObjectValue(array[12]));
		_command.Parameters.AddWithValue("@pTien_tt", RuntimeHelpers.GetObjectValue(array[13]));
		_command.Parameters.AddWithValue("@pTien_tt_nt", RuntimeHelpers.GetObjectValue(array[14]));
		_command.Parameters.AddWithValue("@pTien_tt_qd", RuntimeHelpers.GetObjectValue(array[15]));
		_command.Parameters.AddWithValue("@pT_tien", RuntimeHelpers.GetObjectValue(array[16]));
		_command.Parameters.AddWithValue("@pT_tien_nt", RuntimeHelpers.GetObjectValue(array[17]));
		_command.Parameters.AddWithValue("@pUser", (object)SystemInformations.UserName);
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

	int ARPost2TTDAO.Insert(params object[] array)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Insert
		return this.Insert(array);
	}

	public int Delete(params object[] array)
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		_command.CommandText = "asARDelPost2TT_ARTT";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pStt_rec", RuntimeHelpers.GetObjectValue(array[0]));
		_command.Parameters.AddWithValue("@pStt_rec_hd", RuntimeHelpers.GetObjectValue(array[1]));
		_command.Parameters.AddWithValue("@pTien_tt", RuntimeHelpers.GetObjectValue(array[2]));
		_command.Parameters.AddWithValue("@pTien_tt_nt", RuntimeHelpers.GetObjectValue(array[3]));
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

	int ARPost2TTDAO.Delete(params object[] array)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Delete
		return this.Delete(array);
	}
}
