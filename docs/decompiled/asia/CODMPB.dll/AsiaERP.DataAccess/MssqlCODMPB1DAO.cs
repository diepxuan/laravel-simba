using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.DataAccess;

public class MssqlCODMPB1DAO : MsSqlDAO, ICODMPB1DAO
{
	[DebuggerNonUserCode]
	public MssqlCODMPB1DAO()
	{
	}

	public int Delete(string pMa_cty, int pId, string pTk_nhan_pb, string pMa_spct, string pMa_ct)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		_command.CommandText = "[dbo].[asCODelDMPB1]";
		_command.CommandType = CommandType.StoredProcedure;
		SqlParameter[] array = (SqlParameter[])(object)new SqlParameter[5]
		{
			new SqlParameter("@pMa_cty", SqlDbType.NVarChar),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter)
		};
		array[0].Value = pMa_cty;
		array[1] = new SqlParameter("@pId", SqlDbType.Int);
		array[1].Value = pId;
		array[2] = new SqlParameter("@pTk_nhan_pb", SqlDbType.NVarChar);
		array[2].Value = pTk_nhan_pb;
		array[3] = new SqlParameter("@pMa_ct", SqlDbType.NVarChar);
		array[3].Value = pMa_ct;
		array[4] = new SqlParameter("@pRet", SqlDbType.Int);
		array[4].Direction = ParameterDirection.Output;
		_command.Parameters.Clear();
		_command.Parameters.AddRange(array);
		ExecuteNonQuery();
		return Conversions.ToInteger(array[4].Value);
	}

	int ICODMPB1DAO.Delete(string pMa_cty, int pId, string pTk_nhan_pb, string pMa_spct, string pMa_ct)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Delete
		return this.Delete(pMa_cty, pId, pTk_nhan_pb, pMa_spct, pMa_ct);
	}

	public DataTable GetData(string pMa_Cty, int pId)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(pMa_Cty);
		arrayList.Add(pId);
		return GetDataTable("[dbo].[asCOGetDMPB1]", arrayList.ToArray());
	}

	DataTable ICODMPB1DAO.GetData(string pMa_Cty, int pId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData(pMa_Cty, pId);
	}

	public DataTable GetData(string pMa_Cty, string pModuleId)
	{
		_command.CommandText = "asCOGetDMPB1";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)pMa_Cty);
		_command.Parameters.AddWithValue("@pModuleId", (object)pModuleId);
		return GetDataTable();
	}

	DataTable ICODMPB1DAO.GetData(string pMa_Cty, string pModuleId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData(pMa_Cty, pModuleId);
	}

	public int Insert(string pMa_Cty, int pId, string pTk_nhan_pb, string pModuleId)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		_command.CommandText = "[dbo].[asCOInsDMPB1]";
		_command.CommandType = CommandType.StoredProcedure;
		SqlParameter[] array = (SqlParameter[])(object)new SqlParameter[5]
		{
			new SqlParameter("@pMa_cty", SqlDbType.NVarChar),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter)
		};
		array[0].Value = pMa_Cty;
		array[1] = new SqlParameter("@pId", SqlDbType.Int);
		array[1].Value = pId;
		array[2] = new SqlParameter("@pTk_nhan_pb", SqlDbType.NVarChar);
		array[2].Value = pTk_nhan_pb;
		array[3] = new SqlParameter("@pModuleId", SqlDbType.NVarChar);
		array[3].Value = pModuleId;
		array[4] = new SqlParameter("@pRet", SqlDbType.Int);
		array[4].Direction = ParameterDirection.Output;
		_command.Parameters.Clear();
		_command.Parameters.AddRange(array);
		ExecuteNonQuery();
		return Conversions.ToInteger(_command.Parameters["@pRet"].Value);
	}

	int ICODMPB1DAO.Insert(string pMa_Cty, int pId, string pTk_nhan_pb, string pModuleId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Insert
		return this.Insert(pMa_Cty, pId, pTk_nhan_pb, pModuleId);
	}

	public int InsertAll(string pMa_cty, int pId, string pTk, string pMa_spct)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		SqlParameter[] array = (SqlParameter[])(object)new SqlParameter[4]
		{
			new SqlParameter("@pMa_cty", SqlDbType.NVarChar),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter)
		};
		array[0].Value = pMa_cty;
		array[1] = new SqlParameter("@pId", SqlDbType.Int);
		array[1].Value = pId;
		array[2] = new SqlParameter("@pTk", SqlDbType.NVarChar);
		array[2].Value = pTk;
		array[3] = new SqlParameter("@pRet", SqlDbType.Int);
		array[3].Direction = ParameterDirection.Output;
		_command.Parameters.Clear();
		_command.Parameters.AddRange(array);
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "[dbo].[asCOInsAllDMPB1]";
		ExecuteNonQuery();
		return Conversions.ToInteger(_command.Parameters["@pRet"].Value);
	}

	int ICODMPB1DAO.InsertAll(string pMa_cty, int pId, string pTk, string pMa_spct)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsertAll
		return this.InsertAll(pMa_cty, pId, pTk, pMa_spct);
	}
}
