using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlCODMBOMDAO : MsSqlDAO, ICODMBOMDAO
{
	[DebuggerNonUserCode]
	public MsSqlCODMBOMDAO()
	{
	}

	public DataTable GetCoDmbomPH()
	{
		_command.CommandText = "asCOGetDMCobomPH";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		return GetDataTable();
	}

	DataTable ICODMBOMDAO.GetCoDmbomPH()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetCoDmbomPH
		return this.GetCoDmbomPH();
	}

	public int InsCoDmbomM(DataRow oDrw)
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		_command.CommandText = "asCOInsDMCoBomPH";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_spct", RuntimeHelpers.GetObjectValue(oDrw["ma_spct"]));
		_command.Parameters.AddWithValue("@pNgay1", RuntimeHelpers.GetObjectValue(oDrw["ngay1"]));
		_command.Parameters.AddWithValue("@pNgay2", RuntimeHelpers.GetObjectValue(oDrw["ngay2"]));
		_command.Parameters.AddWithValue("@pdon_gia_luong", RuntimeHelpers.GetObjectValue(oDrw["don_gia_luong"]));
		_command.Parameters.AddWithValue("@pghi_chu", RuntimeHelpers.GetObjectValue(oDrw["ghi_chu"]));
		_command.Parameters.AddWithValue("@pUser", (object)SystemInformations.UserName);
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

	int ICODMBOMDAO.InsCoDmbomPH(DataRow oDrw)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsCoDmbomM
		return this.InsCoDmbomM(oDrw);
	}

	public int UpdCoDmbomPH(DataRow oDrw)
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		_command.CommandText = "asCOUpdDMCoBomPH";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_spct", RuntimeHelpers.GetObjectValue(oDrw["ma_spct"]));
		_command.Parameters.AddWithValue("@pNgay1", RuntimeHelpers.GetObjectValue(oDrw["ngay1"]));
		_command.Parameters.AddWithValue("@pNgay2", RuntimeHelpers.GetObjectValue(oDrw["ngay2"]));
		_command.Parameters.AddWithValue("@pdon_gia_luong", RuntimeHelpers.GetObjectValue(oDrw["don_gia_luong"]));
		_command.Parameters.AddWithValue("@pghi_chu", RuntimeHelpers.GetObjectValue(oDrw["ghi_chu"]));
		_command.Parameters.AddWithValue("@pUser", (object)SystemInformations.UserName);
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

	int ICODMBOMDAO.UpdCoDmbomPH(DataRow oDrw)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdCoDmbomPH
		return this.UpdCoDmbomPH(oDrw);
	}

	public int DelCoDmbomPH(string pMa_spct)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		_command.CommandText = "asCODelDMCobomPH";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_spct", (object)pMa_spct);
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

	int ICODMBOMDAO.DelCoDmbomPH(string pMa_spct)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DelCoDmbomPH
		return this.DelCoDmbomPH(pMa_spct);
	}

	public DataTable GetCoDmbomCT()
	{
		_command.CommandText = "asCOGetDMCobomCT";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		return GetDataTable();
	}

	DataTable ICODMBOMDAO.GetCoDmbomCT()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetCoDmbomCT
		return this.GetCoDmbomCT();
	}

	public int InsCoDmbomCT(DataRow oDrw)
	{
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		_command.CommandText = "asCOInsDMCobomCT";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_spct", RuntimeHelpers.GetObjectValue(oDrw["ma_spct"]));
		_command.Parameters.AddWithValue("@pMa_vt", RuntimeHelpers.GetObjectValue(oDrw["ma_vt"]));
		_command.Parameters.AddWithValue("@pvt_chinh", RuntimeHelpers.GetObjectValue(oDrw["vt_chinh"]));
		_command.Parameters.AddWithValue("@pSo_luong", RuntimeHelpers.GetObjectValue(oDrw["so_luong"]));
		_command.Parameters.AddWithValue("@pUser", (object)SystemInformations.UserName);
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

	int ICODMBOMDAO.InsCoDmbomCT(DataRow oDrw)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsCoDmbomCT
		return this.InsCoDmbomCT(oDrw);
	}

	public int DelCoDmbomCT(string pMa_spct, string pMa_vt)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		_command.CommandText = "asCODelDMCobomCT";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_spct", (object)pMa_spct);
		_command.Parameters.AddWithValue("@pMa_vt", (object)pMa_vt);
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

	int ICODMBOMDAO.DelCoDmbomCT(string pMa_spct, string pMa_vt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DelCoDmbomCT
		return this.DelCoDmbomCT(pMa_spct, pMa_vt);
	}
}
