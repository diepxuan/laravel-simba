using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public class MsSqlSISysvarsDAO : MsSqlDAO, SISysvarsDAO
{
	public DataTable GetSISSysvars(params object[] pArr)
	{
		return GetDataTable("asGetSysVar", pArr);
	}

	DataTable SISysvarsDAO.GetSISSysvars(params object[] pArr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetSISSysvars
		return this.GetSISSysvars(pArr);
	}

	public int UpdSISysvars(params object[] pArr)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		_command.CommandText = "asUpdSysVar";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		SqlParameter val = new SqlParameter("@pMa_cty", SqlDbType.NVarChar, 3);
		val.Value = RuntimeHelpers.GetObjectValue(pArr[0]);
		SqlParameter val2 = new SqlParameter("@pPhan_he", SqlDbType.NVarChar, 2);
		val2.Value = RuntimeHelpers.GetObjectValue(pArr[1]);
		SqlParameter val3 = new SqlParameter("@pFieldName", SqlDbType.NVarChar, 100);
		val3.Value = RuntimeHelpers.GetObjectValue(pArr[2]);
		SqlParameter val4 = new SqlParameter("@pValue", SqlDbType.Variant);
		val4.Value = RuntimeHelpers.GetObjectValue(pArr[3]);
		_command.Parameters.Add(val);
		_command.Parameters.Add(val2);
		_command.Parameters.Add(val3);
		_command.Parameters.Add(val4);
		return _command.ExecuteNonQuery();
	}

	int SISysvarsDAO.UpdSISysvars(params object[] pArr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdSISysvars
		return this.UpdSISysvars(pArr);
	}
}
