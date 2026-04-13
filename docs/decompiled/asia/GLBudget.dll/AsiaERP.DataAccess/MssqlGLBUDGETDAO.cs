using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.DataAccess;

public class MssqlGLBUDGETDAO : MsSqlDAO, GLBUDGETDAO
{
	[DebuggerNonUserCode]
	public MssqlGLBUDGETDAO()
	{
	}

	public DataTable GetGLBUDGET(string pMa_cty, int pNam, string pStt_rec = null, string pMa_tk = null, string pMa_tk_du = null, string pMa_bp = null, string pMa_phi = null, string pMa_spct = null, string pTtps_no_co = null)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(pMa_cty);
		arrayList.Add(pNam);
		arrayList.Add(pStt_rec);
		arrayList.Add(pMa_tk);
		arrayList.Add(pMa_tk_du);
		arrayList.Add(pMa_bp);
		arrayList.Add(pMa_phi);
		arrayList.Add(pMa_spct);
		arrayList.Add(pTtps_no_co);
		return GetDataTable("[dbo].[asGLGetBudget]", arrayList.ToArray());
	}

	DataTable GLBUDGETDAO.GetGLBUDGET(string pMa_cty, int pNam, string pStt_rec = null, string pMa_tk = null, string pMa_tk_du = null, string pMa_bp = null, string pMa_phi = null, string pMa_spct = null, string pTtps_no_co = null)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetGLBUDGET
		return this.GetGLBUDGET(pMa_cty, pNam, pStt_rec, pMa_tk, pMa_tk_du, pMa_bp, pMa_phi, pMa_spct, pTtps_no_co);
	}

	public DataTable GetSample0Budget(string pMa_cty, string pTK, string pLoai_ps, string pMa_bp, string pMa_phi, string pTK_du, int pNam, string ma_spct)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(pMa_cty);
		arrayList.Add(pTK);
		arrayList.Add(pLoai_ps);
		arrayList.Add(pMa_bp);
		arrayList.Add(pMa_phi);
		arrayList.Add(pTK_du);
		arrayList.Add(pNam);
		arrayList.Add(ma_spct);
		return GetDataTable("[dbo].[asGLGetSample0Budget]", arrayList.ToArray());
	}

	DataTable GLBUDGETDAO.GetSample0Budget(string pMa_cty, string pTK, string pLoai_ps, string pMa_bp, string pMa_phi, string pTK_du, int pNam, string ma_spct)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetSample0Budget
		return this.GetSample0Budget(pMa_cty, pTK, pLoai_ps, pMa_bp, pMa_phi, pTK_du, pNam, ma_spct);
	}

	public DataTable GetSample1Budget(string pMa_cty, int pNam, string pTK, string pMa_bp, string pMa_phi, string pMa_spct)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGLGetSample1Budget";
		_command.Parameters.Clear();
		ArrayList arrayList = new ArrayList();
		arrayList.Add(pMa_cty);
		arrayList.Add(pNam);
		arrayList.Add(pTK);
		arrayList.Add(pMa_bp);
		arrayList.Add(pMa_phi);
		arrayList.Add(pMa_spct);
		DataTable result = default(DataTable);
		return result;
	}

	DataTable GLBUDGETDAO.GetSample1Budget(string pMa_cty, int pNam, string pTK, string pMa_bp, string pMa_phi, string pMa_spct)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetSample1Budget
		return this.GetSample1Budget(pMa_cty, pNam, pTK, pMa_bp, pMa_phi, pMa_spct);
	}

	public string asGetSttRec()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetSttRec";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_ct", (object)"GL1");
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pStt_Rec";
		val2.DbType = DbType.String;
		val2.Size = 20;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToString(val.Value);
	}

	public string asUpdBudget(DataRow dr, string spName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = spName;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pStt_rec", RuntimeHelpers.GetObjectValue(dr["stt_rec"]));
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pNam", RuntimeHelpers.GetObjectValue(dr["nam"]));
		_command.Parameters.AddWithValue("@ptk", RuntimeHelpers.GetObjectValue(dr["tk"]));
		_command.Parameters.AddWithValue("@ptk_du", RuntimeHelpers.GetObjectValue(dr["tk_du"]));
		_command.Parameters.AddWithValue("@pttps_no_co", RuntimeHelpers.GetObjectValue(dr["ttps_no_co"]));
		_command.Parameters.AddWithValue("@pma_bp", RuntimeHelpers.GetObjectValue(dr["ma_bp"]));
		_command.Parameters.AddWithValue("@pma_phi", RuntimeHelpers.GetObjectValue(dr["ma_phi"]));
		_command.Parameters.AddWithValue("@pMa_spct", RuntimeHelpers.GetObjectValue(dr["ma_spct"]));
		_command.Parameters.AddWithValue("@pUser", (object)SystemInformations.UserName);
		int num = 1;
		do
		{
			_command.Parameters.AddWithValue("@pT" + Conversions.ToString(num), RuntimeHelpers.GetObjectValue(dr["t" + Conversions.ToString(num)]));
			num = checked(num + 1);
		}
		while (num <= 12);
		_command.Parameters.AddWithValue("@pRet", (object)0).Direction = ParameterDirection.Output;
		_command.ExecuteNonQuery();
		if (Operators.ConditionalCompareObjectEqual(_command.Parameters["@pRet"].Value, (object)0, false))
		{
			return Conversions.ToString(dr["stt_rec"]);
		}
		return "";
	}

	string GLBUDGETDAO.asUpdBudget(DataRow dr, string spName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in asUpdBudget
		return this.asUpdBudget(dr, spName);
	}

	public string asInsBudget(DataRow dr, string spName)
	{
		string text = asGetSttRec();
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = spName;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pStt_rec", (object)text);
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pNam", RuntimeHelpers.GetObjectValue(dr["nam"]));
		_command.Parameters.AddWithValue("@ptk", RuntimeHelpers.GetObjectValue(dr["tk"]));
		_command.Parameters.AddWithValue("@ptk_du", RuntimeHelpers.GetObjectValue(dr["tk_du"]));
		_command.Parameters.AddWithValue("@pttps_no_co", RuntimeHelpers.GetObjectValue(dr["ttps_no_co"]));
		_command.Parameters.AddWithValue("@pma_bp", RuntimeHelpers.GetObjectValue(dr["ma_bp"]));
		_command.Parameters.AddWithValue("@pma_phi", RuntimeHelpers.GetObjectValue(dr["ma_phi"]));
		_command.Parameters.AddWithValue("@pMa_spct", RuntimeHelpers.GetObjectValue(dr["ma_spct"]));
		_command.Parameters.AddWithValue("@pUser", (object)SystemInformations.UserName);
		int num = 1;
		do
		{
			_command.Parameters.AddWithValue("@pT" + Conversions.ToString(num), RuntimeHelpers.GetObjectValue(dr["t" + Conversions.ToString(num)]));
			num = checked(num + 1);
		}
		while (num <= 12);
		_command.Parameters.AddWithValue("@pRet", (object)0).Direction = ParameterDirection.Output;
		_command.ExecuteNonQuery();
		if (Operators.ConditionalCompareObjectEqual(_command.Parameters["@pRet"].Value, (object)0, false))
		{
			return text;
		}
		return "";
	}

	string GLBUDGETDAO.asInsBudget(DataRow dr, string spName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in asInsBudget
		return this.asInsBudget(dr, spName);
	}

	public bool asDelBudget(DataRow dr, string spName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = spName;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pStt_rec", RuntimeHelpers.GetObjectValue(dr["stt_rec"]));
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.ExecuteNonQuery();
		return true;
	}

	bool GLBUDGETDAO.asDelBudget(DataRow dr, string spName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in asDelBudget
		return this.asDelBudget(dr, spName);
	}
}
