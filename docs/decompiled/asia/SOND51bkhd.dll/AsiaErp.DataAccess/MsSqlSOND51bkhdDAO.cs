using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlSOND51bkhdDAO : MsSqlDAO, SOND51bkhdDAO
{
	[DebuggerNonUserCode]
	public MsSqlSOND51bkhdDAO()
	{
	}

	public int Delete(string ma_tb)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		_command.CommandText = "asSODelND51bkhdct";
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

	int SOND51bkhdDAO.Delete(string ma_tb)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Delete
		return this.Delete(ma_tb);
	}

	public DataTable GetData()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOGetND51phhdct";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pChap_nhan", (object)"1");
		return GetDataTable();
	}

	DataTable SOND51bkhdDAO.GetData()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData();
	}

	public DataTable GetData(string ma_tb, bool loai)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOGetND51bkhdct";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_tb", (object)ma_tb);
		_command.Parameters.AddWithValue("@pLoai", (object)loai);
		return GetDataTable();
	}

	DataTable SOND51bkhdDAO.GetData(string ma_tb, bool loai)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData(ma_tb, loai);
	}

	public int Insert(string ma_tb, string ma_ph, string mau_so, bool loai, string so_seri, string ten_loai, string tu_so, string den_so, string so_luong, string so_dhin, string so_hdph)
	{
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		_command.CommandText = "asSOInsND51bkhdct";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_tb", (object)ma_tb);
		_command.Parameters.AddWithValue("@pMa_ph", (object)ma_ph);
		_command.Parameters.AddWithValue("@pMau_so", (object)mau_so);
		_command.Parameters.AddWithValue("@pLoai", (object)loai);
		_command.Parameters.AddWithValue("@pSo_seri", (object)so_seri);
		_command.Parameters.AddWithValue("@pTen_loai", (object)ten_loai);
		_command.Parameters.AddWithValue("@pTu_so", (object)tu_so);
		_command.Parameters.AddWithValue("@pDen_so", (object)den_so);
		_command.Parameters.AddWithValue("@pSo_luong", (object)so_luong);
		_command.Parameters.AddWithValue("@pSo_hdin", (object)so_dhin);
		_command.Parameters.AddWithValue("@pSo_hdph", (object)so_hdph);
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

	int SOND51bkhdDAO.Insert(string ma_tb, string ma_ph, string mau_so, bool loai, string so_seri, string ten_loai, string tu_so, string den_so, string so_luong, string so_dhin, string so_hdph)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Insert
		return this.Insert(ma_tb, ma_ph, mau_so, loai, so_seri, ten_loai, tu_so, den_so, so_luong, so_dhin, so_hdph);
	}
}
