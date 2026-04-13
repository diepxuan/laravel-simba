using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSQLSIUpdateLogDAO : MsSqlDAO, SIUpdateLogDAO
{
	[DebuggerNonUserCode]
	public MsSQLSIUpdateLogDAO()
	{
	}

	public DataTable GetUpdateLog()
	{
		_command.CommandText = "asSiGetUpdateLogPh";
		_command.CommandType = CommandType.StoredProcedure;
		return GetDataTable();
	}

	DataTable SIUpdateLogDAO.GetUpdateLog()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetUpdateLog
		return this.GetUpdateLog();
	}

	public DataTable GetDataDetail(int pID = 0)
	{
		_command.CommandText = "asSiGetUpdateLogCT";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pID", (object)pID);
		return GetDataTable();
	}

	DataTable SIUpdateLogDAO.GetDataDetail(int pID = 0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDataDetail
		return this.GetDataDetail(pID);
	}

	public DataTable GetModule(bool isModule, string Menuid = "")
	{
		_command.CommandText = "asGetUpdateLogModule";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pIsModule", (object)isModule);
		_command.Parameters.AddWithValue("@pMenuid", (object)Menuid);
		return GetDataTable();
	}

	DataTable SIUpdateLogDAO.GetModule(bool isModule, string Menuid = "")
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetModule
		return this.GetModule(isModule, Menuid);
	}

	public DataTable GetHistory(int ID)
	{
		_command.CommandText = "asSiGetUpdateLogBk";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pID", (object)ID);
		return GetDataTable();
	}

	DataTable SIUpdateLogDAO.GetHistory(int ID)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetHistory
		return this.GetHistory(ID);
	}

	public int InsHistory(int ID)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		_command.CommandText = "asSiInsUpdateLogBk";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pID", (object)ID);
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

	int SIUpdateLogDAO.InsHistory(int ID)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsHistory
		return this.InsHistory(ID);
	}

	public int InsUpdateLogPH(object[] para, ref int ID)
	{
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		_command.CommandText = "asSiInsUpdateLogPh";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pDescription", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pNote", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pProductid", RuntimeHelpers.GetObjectValue(para[2]));
		_command.Parameters.AddWithValue("@pFunctionMenuid", RuntimeHelpers.GetObjectValue(para[3]));
		_command.Parameters.AddWithValue("@pFunctionName", RuntimeHelpers.GetObjectValue(para[4]));
		_command.Parameters.AddWithValue("@pBugnumber", RuntimeHelpers.GetObjectValue(para[5]));
		_command.Parameters.AddWithValue("@pLinknumber", RuntimeHelpers.GetObjectValue(para[6]));
		_command.Parameters.AddWithValue("@pConnection", RuntimeHelpers.GetObjectValue(para[7]));
		_command.Parameters.AddWithValue("@pCuserbuild", RuntimeHelpers.GetObjectValue(para[8]));
		_command.Parameters.AddWithValue("@pLuserbuild", RuntimeHelpers.GetObjectValue(para[9]));
		_command.Parameters.AddWithValue("@pCUser", RuntimeHelpers.GetObjectValue(para[10]));
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pID";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		SqlParameter val3 = new SqlParameter();
		SqlParameter val4 = val3;
		val4.ParameterName = "@pRet";
		val4.DbType = DbType.Int32;
		val4.Direction = ParameterDirection.Output;
		val4 = null;
		_command.Parameters.Add(val3);
		ExecuteNonQuery();
		ID = Conversions.ToInteger(val.Value);
		return Conversions.ToInteger(val3.Value);
	}

	int SIUpdateLogDAO.InsUpdateLogPH(object[] para, ref int ID)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsUpdateLogPH
		return this.InsUpdateLogPH(para, ref ID);
	}

	public int InsUpdateLogCT(object[] para)
	{
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		_command.CommandText = "asSiInsUpdateLogCt";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pItem_ID", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pID", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pName", RuntimeHelpers.GetObjectValue(para[2]));
		_command.Parameters.AddWithValue("@pType", RuntimeHelpers.GetObjectValue(para[3]));
		_command.Parameters.AddWithValue("@pLast_Modify", RuntimeHelpers.GetObjectValue(para[4]));
		_command.Parameters.AddWithValue("@pFullPath", RuntimeHelpers.GetObjectValue(para[5]));
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

	int SIUpdateLogDAO.InsUpdateLogCT(object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsUpdateLogCT
		return this.InsUpdateLogCT(para);
	}

	public int DelUpdateLogCT(int pID)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		_command.CommandText = "asSiDelUpdateLogCT";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pId", (object)pID);
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

	int SIUpdateLogDAO.DelUpdateLogCT(int pID)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DelUpdateLogCT
		return this.DelUpdateLogCT(pID);
	}

	public DataTable GetLookup(int ID, string ProductID)
	{
		_command.CommandText = "asSiGetUpdateLogLookup";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pProductID", (object)ProductID);
		_command.Parameters.AddWithValue("@pID", (object)ID);
		return GetDataTable();
	}

	DataTable SIUpdateLogDAO.GetLookup(int ID, string ProductID)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetLookup
		return this.GetLookup(ID, ProductID);
	}
}
