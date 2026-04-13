using System;
using System.Data;
using System.Data.SqlClient;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlGLPost2DGTGDAO : MsSqlDAO, IGLPost2DGTGDAO
{
	public DataTable GetData()
	{
		return GetDataTable("asGLGetDMDGTG", CompanyInformations.CompanyID);
	}

	DataTable IGLPost2DGTGDAO.GetData()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData();
	}

	public int DelDgtg(string pMa_Cty, string pMa_ct, DateTime pNgay1, DateTime pNgay2, int pStt)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		_command.CommandText = "[dbo].[asGLDelDGTG]";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_Cty);
		_command.Parameters.AddWithValue("@pMa_ct", (object)pMa_ct);
		_command.Parameters.AddWithValue("@pNgay1", (object)pNgay1);
		_command.Parameters.AddWithValue("@pNgay2", (object)pNgay2);
		_command.Parameters.AddWithValue("@pStt", (object)pStt);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.SqlDbType = SqlDbType.Int;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int IGLPost2DGTGDAO.DelDgtg(string pMa_Cty, string pMa_ct, DateTime pNgay1, DateTime pNgay2, int pStt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DelDgtg
		return this.DelDgtg(pMa_Cty, pMa_ct, pNgay1, pNgay2, pStt);
	}

	public int CreateDgtg(string pMa_cty, string pMa_ct, string pMa_nt, int pStt, DateTime pNgay1, DateTime pNgay2, string pUser)
	{
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		_command.CommandText = "[dbo].[asGLCrtDGTG]";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pMa_ct", (object)pMa_ct);
		_command.Parameters.AddWithValue("@pMa_nt", (object)pMa_nt);
		_command.Parameters.AddWithValue("@pStt", (object)pStt);
		_command.Parameters.AddWithValue("@pNgay1", (object)pNgay1);
		_command.Parameters.AddWithValue("@pNgay2", (object)pNgay2);
		_command.Parameters.AddWithValue("@pUser", (object)pUser);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.SqlDbType = SqlDbType.Int;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int IGLPost2DGTGDAO.CreateDgtg(string pMa_cty, string pMa_ct, string pMa_nt, int pStt, DateTime pNgay1, DateTime pNgay2, string pUser)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CreateDgtg
		return this.CreateDgtg(pMa_cty, pMa_ct, pMa_nt, pStt, pNgay1, pNgay2, pUser);
	}
}
