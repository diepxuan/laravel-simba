using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlSOND51mathdDAO : MsSqlDAO, SOND51mathdDAO
{
	[DebuggerNonUserCode]
	public MsSqlSOND51mathdDAO()
	{
	}

	public DataTable GetData(string ma_tb)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOGetND51xlhdct";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pKieu_xl", (object)"MAT");
		_command.Parameters.AddWithValue("@pMa_tb", (object)ma_tb);
		return GetDataTable();
	}

	DataTable SOND51mathdDAO.GetData(string ma_tb)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData(ma_tb);
	}

	public DataTable GetData(string ngay1, string ngay2)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOGetDSHD";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pNgay1", (object)ngay1);
		_command.Parameters.AddWithValue("@pNgay2", (object)ngay2);
		return GetDataTable();
	}

	DataTable SOND51mathdDAO.GetData(string ngay1, string ngay2)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData(ngay1, ngay2);
	}

	public int Insert(string ma_tb, string ma_chung, string ten_loai, string mau_so, string so_seri, string tu_so, string den_so, string so_luong, string lien_hd, string ghi_chu)
	{
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		_command.CommandText = "asSOInsND51xlhdct";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pKieu_xl", (object)"MAT");
		_command.Parameters.AddWithValue("@pMa_tb", (object)ma_tb);
		_command.Parameters.AddWithValue("@pMa_chung", (object)ma_chung);
		_command.Parameters.AddWithValue("@pTen_loai", (object)ten_loai);
		_command.Parameters.AddWithValue("@pMau_so", (object)mau_so);
		_command.Parameters.AddWithValue("@pSo_seri", (object)so_seri);
		_command.Parameters.AddWithValue("@pTu_so", (object)tu_so);
		_command.Parameters.AddWithValue("@pDen_so", (object)den_so);
		_command.Parameters.AddWithValue("@pSo_luong", (object)so_luong);
		_command.Parameters.AddWithValue("@pLien_hd", (object)lien_hd);
		_command.Parameters.AddWithValue("@pGhi_chu", (object)ghi_chu);
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

	int SOND51mathdDAO.Insert(string ma_tb, string ma_chung, string ten_loai, string mau_so, string so_seri, string tu_so, string den_so, string so_luong, string lien_hd, string ghi_chu)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Insert
		return this.Insert(ma_tb, ma_chung, ten_loai, mau_so, so_seri, tu_so, den_so, so_luong, lien_hd, ghi_chu);
	}

	public int Delete(string ma_tb)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		_command.CommandText = "asSODelND51xlhdct";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pKieu_xl", (object)"MAT");
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

	int SOND51mathdDAO.Delete(string ma_tb)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Delete
		return this.Delete(ma_tb);
	}
}
