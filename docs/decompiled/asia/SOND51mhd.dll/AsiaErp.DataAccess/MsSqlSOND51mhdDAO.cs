using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlSOND51mhdDAO : MsSqlDAO, SOND51mhdDAO
{
	[DebuggerNonUserCode]
	public MsSqlSOND51mhdDAO()
	{
	}

	public int Delete(string ma_loai, string so_hd)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		_command.CommandText = "asSODelND51mhdct";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_loai", (object)ma_loai);
		_command.Parameters.AddWithValue("@pSo_hd", (object)so_hd);
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

	int SOND51mhdDAO.Delete(string ma_loai, string so_hd)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Delete
		return this.Delete(ma_loai, so_hd);
	}

	public DataTable GetData(string ma_loai, string so_hd)
	{
		_command.CommandText = "asSOGetND51mhdct";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_loai", (object)ma_loai);
		_command.Parameters.AddWithValue("@pSo_hd", (object)so_hd);
		return GetDataTable();
	}

	DataTable SOND51mhdDAO.GetData(string ma_loai, string so_hd)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData(ma_loai, so_hd);
	}

	public int Insert(string ma_loai, string so_hd, string mo_ta1, string mo_ta2, string mo_ta3 = "", string mo_ta4 = "", string mo_ta5 = "", string mo_ta6 = "", string mo_ta7 = "", string mo_ta8 = "", string mo_ta9 = "")
	{
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		_command.CommandText = "asSOInsND51mhdct";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_loai", (object)ma_loai);
		_command.Parameters.AddWithValue("@pSo_hd", (object)so_hd);
		_command.Parameters.AddWithValue("@pMota1", (object)mo_ta1);
		_command.Parameters.AddWithValue("@pMota2", (object)mo_ta2);
		_command.Parameters.AddWithValue("@pMota3", (object)mo_ta3);
		_command.Parameters.AddWithValue("@pMota4", (object)mo_ta4);
		_command.Parameters.AddWithValue("@pMota5", (object)mo_ta5);
		_command.Parameters.AddWithValue("@pMota6", (object)mo_ta6);
		_command.Parameters.AddWithValue("@pMota7", (object)mo_ta7);
		_command.Parameters.AddWithValue("@pMota8", (object)mo_ta8);
		_command.Parameters.AddWithValue("@pMota9", (object)mo_ta9);
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

	int SOND51mhdDAO.Insert(string ma_loai, string so_hd, string mo_ta1, string mo_ta2, string mo_ta3 = "", string mo_ta4 = "", string mo_ta5 = "", string mo_ta6 = "", string mo_ta7 = "", string mo_ta8 = "", string mo_ta9 = "")
	{
		//ILSpy generated this explicit interface implementation from .override directive in Insert
		return this.Insert(ma_loai, so_hd, mo_ta1, mo_ta2, mo_ta3, mo_ta4, mo_ta5, mo_ta6, mo_ta7, mo_ta8, mo_ta9);
	}
}
