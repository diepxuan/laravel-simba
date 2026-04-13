using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlSOND51phhdDAO : MsSqlDAO, SOND51phhdDAO
{
	[DebuggerNonUserCode]
	public MsSqlSOND51phhdDAO()
	{
	}

	public int Delete(string ma_tb)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		_command.CommandText = "asSODelND51phhdct";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_tb", (object)ma_tb);
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

	int SOND51phhdDAO.Delete(string ma_tb)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Delete
		return this.Delete(ma_tb);
	}

	public DataTable GetData(string ma_tb)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOGetND51phhdct";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_tb", (object)ma_tb);
		return GetDataTable();
	}

	DataTable SOND51phhdDAO.GetData(string ma_tb)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData(ma_tb);
	}

	public int Insert(string ma_tb, string mau_so, string ma_loai, string so_seri, string so_hd, string tu_so, string den_so, string so_luong, DateTime ngay_sd, string donvi_in, string ma_thuedvi, DateTime ngay_in, string ten_loai)
	{
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		_command.CommandText = "asSOInsND51phhdct";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_tb", (object)ma_tb);
		_command.Parameters.AddWithValue("@pMau_so", (object)mau_so);
		_command.Parameters.AddWithValue("@pMa_loai", (object)ma_loai);
		_command.Parameters.AddWithValue("@pSo_seri", (object)so_seri);
		_command.Parameters.AddWithValue("@pSo_hd", (object)so_hd);
		_command.Parameters.AddWithValue("@pTu_so", (object)tu_so);
		_command.Parameters.AddWithValue("@pDen_so", (object)den_so);
		_command.Parameters.AddWithValue("@pSo_luong", (object)so_luong);
		_command.Parameters.AddWithValue("@pNgay_sd", (object)ngay_sd);
		_command.Parameters.AddWithValue("@pDonvi_in", (object)donvi_in);
		_command.Parameters.AddWithValue("@pMa_thuedvi", (object)ma_thuedvi);
		_command.Parameters.AddWithValue("@pNgay_in", (object)ngay_in);
		_command.Parameters.AddWithValue("@pTen_loai", (object)ten_loai);
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

	int SOND51phhdDAO.Insert(string ma_tb, string mau_so, string ma_loai, string so_seri, string so_hd, string tu_so, string den_so, string so_luong, DateTime ngay_sd, string donvi_in, string ma_thuedvi, DateTime ngay_in, string ten_loai)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Insert
		return this.Insert(ma_tb, mau_so, ma_loai, so_seri, so_hd, tu_so, den_so, so_luong, ngay_sd, donvi_in, ma_thuedvi, ngay_in, ten_loai);
	}
}
