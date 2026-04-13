using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlGLDKCTGSDAO : MsSqlDAO, GLDKCTGSDAO
{
	[DebuggerNonUserCode]
	public MsSqlGLDKCTGSDAO()
	{
	}

	public DataTable GetData()
	{
		_command.CommandText = "asGLGetDMCTGS";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		return GetDataTable();
	}

	DataTable GLDKCTGSDAO.GetData()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData();
	}

	public int DangKyCTGS(params object[] para)
	{
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		_command.CommandText = "asGLDKCTGS";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pThang", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pNam", (object)SystemInformations.FinancialYear);
		_command.Parameters.AddWithValue("@pMa_ct", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pTk", RuntimeHelpers.GetObjectValue(para[2]));
		_command.Parameters.AddWithValue("@pTen_ctgs", RuntimeHelpers.GetObjectValue(para[3]));
		_command.Parameters.AddWithValue("@pSo_hieu", RuntimeHelpers.GetObjectValue(para[4]));
		_command.Parameters.AddWithValue("@pNgay", RuntimeHelpers.GetObjectValue(para[5]));
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

	int GLDKCTGSDAO.DangKyCTGS(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DangKyCTGS
		return this.DangKyCTGS(para);
	}
}
