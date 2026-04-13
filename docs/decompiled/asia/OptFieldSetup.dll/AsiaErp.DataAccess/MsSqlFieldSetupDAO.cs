using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlFieldSetupDAO : MsSqlDAO, FieldSetupDAO
{
	[DebuggerNonUserCode]
	public MsSqlFieldSetupDAO()
	{
	}

	public DataTable GetFieldInfo()
	{
		_command.CommandText = "asGetOptFieldInfo";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.ExecuteNonQuery();
		return GetDataTable();
	}

	DataTable FieldSetupDAO.GetFieldInfo()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetFieldInfo
		return this.GetFieldInfo();
	}

	public DataTable GetCt(string pMa_cty, string pMa_ct)
	{
		_command.CommandText = "asSIGetDMCT";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pMa_ct", (object)pMa_ct);
		_command.ExecuteNonQuery();
		return GetDataTable();
	}

	DataTable FieldSetupDAO.GetCt(string pMa_cty, string pMa_ct)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetCt
		return this.GetCt(pMa_cty, pMa_ct);
	}

	public DataTable GetFieldSetup(string pVoucher_code)
	{
		_command.CommandText = "asGetOptFieldSetup";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pVoucher_code", (object)pVoucher_code);
		_command.ExecuteNonQuery();
		return GetDataTable();
	}

	DataTable FieldSetupDAO.GetFieldSetup(string pVoucher_code)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetFieldSetup
		return this.GetFieldSetup(pVoucher_code);
	}

	public int UpdFieldSetup(string pVoucher_code, string pField, string pMaster, string pDetail)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		_command.CommandText = "asUpdOptFieldSetup";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pField", (object)pField);
		_command.Parameters.AddWithValue("@pVoucher_code", (object)pVoucher_code);
		_command.Parameters.AddWithValue("@pMaster", (object)pMaster);
		_command.Parameters.AddWithValue("@pDetail", (object)pDetail);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.DbType = DbType.Int32;
		val2.ParameterName = "pRet";
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int FieldSetupDAO.UpdFieldSetup(string pVoucher_code, string pField, string pMaster, string pDetail)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdFieldSetup
		return this.UpdFieldSetup(pVoucher_code, pField, pMaster, pDetail);
	}

	public int InsFieldSetup(string pVoucher_code, string pField, string pMaster, string pDetail)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		_command.CommandText = "asInsOptFieldSetup";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pField", (object)pField);
		_command.Parameters.AddWithValue("@pVoucher_code", (object)pVoucher_code);
		_command.Parameters.AddWithValue("@pMaster", (object)pMaster);
		_command.Parameters.AddWithValue("@pDetail", (object)pDetail);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.DbType = DbType.Int32;
		val2.ParameterName = "pRet";
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int FieldSetupDAO.InsFieldSetup(string pVoucher_code, string pField, string pMaster, string pDetail)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsFieldSetup
		return this.InsFieldSetup(pVoucher_code, pField, pMaster, pDetail);
	}

	public int DelFieldSetup(string pVoucher_code, string pField)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		_command.CommandText = "asDelOptFieldSetup";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pField", (object)pField);
		_command.Parameters.AddWithValue("@pVoucher_code", (object)pVoucher_code);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.DbType = DbType.Int32;
		val2.ParameterName = "pRet";
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int FieldSetupDAO.DelFieldSetup(string pVoucher_code, string pField)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DelFieldSetup
		return this.DelFieldSetup(pVoucher_code, pField);
	}
}
