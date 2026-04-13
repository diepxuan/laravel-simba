using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlCOPBDAO : MsSqlDAO, COPBDAO
{
	public int CalPB(params object[] para)
	{
		_command.CommandText = "asCOCalcPb";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pNgay1", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pNgay2", RuntimeHelpers.GetObjectValue(para[2]));
		_command.Parameters.AddWithValue("@pID", RuntimeHelpers.GetObjectValue(para[3]));
		_command.Parameters.AddWithValue("@pMa_ct", RuntimeHelpers.GetObjectValue(para[4]));
		_command.Parameters.AddWithValue("@pUser", (object)SystemInformations.UserName);
		return ExecuteNonQuery();
	}

	int COPBDAO.CalPB(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CalPB
		return this.CalPB(para);
	}

	public int CalPBHS(params object[] para)
	{
		_command.CommandText = "asCOCalcHsPb";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pNgay1", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pNgay2", RuntimeHelpers.GetObjectValue(para[2]));
		_command.Parameters.AddWithValue("@pID", RuntimeHelpers.GetObjectValue(para[3]));
		_command.Parameters.AddWithValue("@pPb_theo", RuntimeHelpers.GetObjectValue(para[4]));
		_command.Parameters.AddWithValue("@pHs_theo", RuntimeHelpers.GetObjectValue(para[5]));
		return ExecuteNonQuery();
	}

	int COPBDAO.CalPBHS(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CalPBHS
		return this.CalPBHS(para);
	}

	public int UPdatePBHS(params object[] para)
	{
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		_command.CommandText = "asCOUpdHsPb";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pId", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pNam", (object)SystemInformations.FinancialYear);
		_command.Parameters.AddWithValue("@pThang", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pTk", RuntimeHelpers.GetObjectValue(para[2]));
		_command.Parameters.AddWithValue("@pMa_spct", RuntimeHelpers.GetObjectValue(para[3]));
		_command.Parameters.AddWithValue("@pMa_bp", RuntimeHelpers.GetObjectValue(para[4]));
		_command.Parameters.AddWithValue("@pTK_DU", RuntimeHelpers.GetObjectValue(para[5]));
		_command.Parameters.AddWithValue("@pHs", RuntimeHelpers.GetObjectValue(para[6]));
		_command.Parameters.AddWithValue("@pTien_nhan", RuntimeHelpers.GetObjectValue(para[7]));
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

	int COPBDAO.UPdatePBHS(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UPdatePBHS
		return this.UPdatePBHS(para);
	}

	public int DelcalPB(params object[] para)
	{
		_command.CommandText = "asCODelCalcPb";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pNgay1", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pNgay2", RuntimeHelpers.GetObjectValue(para[2]));
		_command.Parameters.AddWithValue("@pID", RuntimeHelpers.GetObjectValue(para[3]));
		_command.Parameters.AddWithValue("@pMa_ct", RuntimeHelpers.GetObjectValue(para[4]));
		_command.Parameters.AddWithValue("@pUser", (object)SystemInformations.UserName);
		return ExecuteNonQuery();
	}

	int COPBDAO.DelcalPB(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DelcalPB
		return this.DelcalPB(para);
	}

	public DataTable GetDataPbCt(params object[] para)
	{
		_command.CommandText = "asCOGetDMPB12";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pNam", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pModuleId", RuntimeHelpers.GetObjectValue(para[2]));
		return GetDataTable();
	}

	DataTable COPBDAO.GetDataPbCt(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDataPbCt
		return this.GetDataPbCt(para);
	}

	public DataTable GetDataPbPh(params object[] para)
	{
		_command.CommandText = "asCOGetDMPB";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pModuleId", RuntimeHelpers.GetObjectValue(para[1]));
		return GetDataTable();
	}

	DataTable COPBDAO.GetDataPbPh(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDataPbPh
		return this.GetDataPbPh(para);
	}

	public DataTable GetDataTypePB(params object[] para)
	{
		_command.CommandText = "asGetCODMPBCachTinhHS";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pKsd", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pModuleId", RuntimeHelpers.GetObjectValue(para[2]));
		_command.Parameters.AddWithValue("@pLanguage", RuntimeHelpers.GetObjectValue(para[3]));
		return GetDataTable();
	}

	DataTable COPBDAO.GetDataTypePB(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDataTypePB
		return this.GetDataTypePB(para);
	}
}
