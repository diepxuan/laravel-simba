using System.Data;
using System.Data.SqlClient;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlSIMaintainDAO : MsSqlDAO, ISIMaintainDAO
{
	public DataTable GetDSMa()
	{
		return GetDataTable("asSIMaintain021", null);
	}

	DataTable ISIMaintainDAO.GetDSMa()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDSMa
		return this.GetDSMa();
	}

	public int ExecuteDelSpace(string pMa_cty, string pLst_Ma)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSIMaintain022";
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pstr_Ma", (object)pLst_Ma);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.ReturnValue;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int ISIMaintainDAO.ExecuteDelSpace(string pMa_cty, string pLst_Ma)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ExecuteDelSpace
		return this.ExecuteDelSpace(pMa_cty, pLst_Ma);
	}

	public int BackupDB(string pStr_Path)
	{
		return ExecuteNonQuery("asSIMaintain05", pStr_Path);
	}

	int ISIMaintainDAO.BackupDB(string pStr_Path)
	{
		//ILSpy generated this explicit interface implementation from .override directive in BackupDB
		return this.BackupDB(pStr_Path);
	}

	public int CreateAutoBackupDB(params object[] para)
	{
		_command.CommandText = "asSiScheduleAutoBackupData";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pLocalDB", (object)para[0].ToString());
		_command.Parameters.AddWithValue("@pDbName", (object)para[1].ToString());
		_command.Parameters.AddWithValue("@pSysName", (object)para[2].ToString());
		_command.Parameters.AddWithValue("@pFreq_interval", (object)Conversions.ToInteger(para[3]));
		_command.Parameters.AddWithValue("@pActive_start_time", (object)Conversions.ToInteger(para[4]));
		return ExecuteNonQuery();
	}

	int ISIMaintainDAO.CreateAutoBackupDB(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CreateAutoBackupDB
		return this.CreateAutoBackupDB(para);
	}

	public int ExecuteReIndex()
	{
		_command.CommandText = "asSIMaintain01_ReIndex";
		_command.CommandType = CommandType.StoredProcedure;
		return ExecuteNonQuery();
	}

	int ISIMaintainDAO.ExecuteReIndex()
	{
		//ILSpy generated this explicit interface implementation from .override directive in ExecuteReIndex
		return this.ExecuteReIndex();
	}
}
