using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlGLPost2GLKCDAO : MsSqlDAO, IGLPost2GLKCDAO
{
	public int DelKc(DataRow oDrw, string pMa_ct, DateTime dtmNgay1, DateTime dtmNgay2)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		_command.CommandText = "asGLDelKC";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(oDrw["ma_cty"]));
		_command.Parameters.AddWithValue("@pMa_ct", (object)pMa_ct);
		_command.Parameters.AddWithValue("@pngay1", (object)dtmNgay1);
		_command.Parameters.AddWithValue("@pngay2", (object)dtmNgay2);
		_command.Parameters.AddWithValue("@pTk", RuntimeHelpers.GetObjectValue(oDrw["Tk"]));
		_command.Parameters.AddWithValue("@pTk_du", RuntimeHelpers.GetObjectValue(oDrw["Tk_du"]));
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.DbType = DbType.Int32;
		val2.ParameterName = "@pRet";
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int IGLPost2GLKCDAO.DelKc(DataRow oDrw, string pMa_ct, DateTime dtmNgay1, DateTime dtmNgay2)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DelKc
		return this.DelKc(oDrw, pMa_ct, dtmNgay1, dtmNgay2);
	}

	public int CreateKc(DataRow oDrw, string pMa_ct, DateTime dtmNgay1, DateTime dtmNgay2)
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		_command.CommandText = "asGLCrtKC";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(oDrw["ma_cty"]));
		_command.Parameters.AddWithValue("@pMa_ct", (object)pMa_ct);
		_command.Parameters.AddWithValue("@pngay1", (object)dtmNgay1);
		_command.Parameters.AddWithValue("@pngay2", (object)dtmNgay2);
		_command.Parameters.AddWithValue("@pTk", RuntimeHelpers.GetObjectValue(oDrw["Tk"]));
		_command.Parameters.AddWithValue("@pTk_du", RuntimeHelpers.GetObjectValue(oDrw["Tk_du"]));
		_command.Parameters.AddWithValue("@pUser", (object)SystemInformations.UserName);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.DbType = DbType.Int32;
		val2.ParameterName = "@pRet";
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int IGLPost2GLKCDAO.CreateKc(DataRow oDrw, string pMa_ct, DateTime dtmNgay1, DateTime dtmNgay2)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CreateKc
		return this.CreateKc(oDrw, pMa_ct, dtmNgay1, dtmNgay2);
	}

	public DataTable GetDmKC(string moduleid)
	{
		_command.CommandText = "asGLGetDMKC4KC";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pModuleid", (object)moduleid);
		return GetDataTable();
	}

	DataTable IGLPost2GLKCDAO.GetDmKC(string moduleid)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDmKC
		return this.GetDmKC(moduleid);
	}
}
