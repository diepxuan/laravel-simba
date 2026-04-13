using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using AsiaErp.UserInterface;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlCODMCPTTDAO : MsSqlDAO, CODMCPTTDAO
{
	[DebuggerNonUserCode]
	public MsSqlCODMCPTTDAO()
	{
	}

	public int InsCPTT(params object[] para)
	{
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		_command.CommandText = "asCoInsDMCPTT";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_cptt", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pSo_ct", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pNgay_ct", RuntimeHelpers.GetObjectValue(para[2]));
		_command.Parameters.AddWithValue("@pTen_cptt", RuntimeHelpers.GetObjectValue(para[3]));
		_command.Parameters.AddWithValue("@pDvt", RuntimeHelpers.GetObjectValue(para[4]));
		_command.Parameters.AddWithValue("@pSo_luong", RuntimeHelpers.GetObjectValue(para[5]));
		_command.Parameters.AddWithValue("@pDon_gia", RuntimeHelpers.GetObjectValue(para[6]));
		_command.Parameters.AddWithValue("@pNg_gia", RuntimeHelpers.GetObjectValue(para[7]));
		_command.Parameters.AddWithValue("@pGt_da_kh", RuntimeHelpers.GetObjectValue(para[8]));
		_command.Parameters.AddWithValue("@pGt_cl", RuntimeHelpers.GetObjectValue(para[9]));
		_command.Parameters.AddWithValue("@pKy_pb", RuntimeHelpers.GetObjectValue(para[10]));
		_command.Parameters.AddWithValue("@pSo_ky", RuntimeHelpers.GetObjectValue(para[11]));
		_command.Parameters.AddWithValue("@pKh_ky", RuntimeHelpers.GetObjectValue(para[12]));
		_command.Parameters.AddWithValue("@pNgay_bdkh", RuntimeHelpers.GetObjectValue(para[13]));
		_command.Parameters.AddWithValue("@pNgay_gt_cl", RuntimeHelpers.GetObjectValue(para[14]));
		_command.Parameters.AddWithValue("@pTk_cptt", RuntimeHelpers.GetObjectValue(para[15]));
		_command.Parameters.AddWithValue("@pTk_cp", RuntimeHelpers.GetObjectValue(para[16]));
		_command.Parameters.AddWithValue("@pMa_bpsd", RuntimeHelpers.GetObjectValue(para[17]));
		_command.Parameters.AddWithValue("@pMa_spct", RuntimeHelpers.GetObjectValue(para[18]));
		_command.Parameters.AddWithValue("@pMa_phi", RuntimeHelpers.GetObjectValue(para[19]));
		_command.Parameters.AddWithValue("@pTinh_kh", RuntimeHelpers.GetObjectValue(para[20]));
		_command.Parameters.AddWithValue("@pSua_kh", RuntimeHelpers.GetObjectValue(para[21]));
		_command.Parameters.AddWithValue("@pCUser", (object)SystemInformations.UserName);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pID";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		SqlParameter val3 = new SqlParameter();
		SqlParameter val4 = val3;
		val4.ParameterName = "@pRet";
		val4.DbType = DbType.Int32;
		val4.Direction = ParameterDirection.Output;
		val4 = null;
		_command.Parameters.Add(val);
		_command.Parameters.Add(val3);
		ExecuteNonQuery();
		frmCoDMCPTTEdit.pID = Conversions.ToInteger(val.Value);
		return Conversions.ToInteger(val3.Value);
	}

	int CODMCPTTDAO.InsCPTT(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsCPTT
		return this.InsCPTT(para);
	}

	public int UpdCPTT(params object[] para)
	{
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		_command.CommandText = "asCoUpdDMCPTT";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pModuleid", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pID", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pMa_cptt", RuntimeHelpers.GetObjectValue(para[2]));
		_command.Parameters.AddWithValue("@pSo_ct", RuntimeHelpers.GetObjectValue(para[3]));
		_command.Parameters.AddWithValue("@pNgay_ct", RuntimeHelpers.GetObjectValue(para[4]));
		_command.Parameters.AddWithValue("@pTen_cptt", RuntimeHelpers.GetObjectValue(para[5]));
		_command.Parameters.AddWithValue("@pDvt", RuntimeHelpers.GetObjectValue(para[6]));
		_command.Parameters.AddWithValue("@pSo_luong", RuntimeHelpers.GetObjectValue(para[7]));
		_command.Parameters.AddWithValue("@pDon_gia", RuntimeHelpers.GetObjectValue(para[8]));
		_command.Parameters.AddWithValue("@pNg_gia", RuntimeHelpers.GetObjectValue(para[9]));
		_command.Parameters.AddWithValue("@pGt_da_kh", RuntimeHelpers.GetObjectValue(para[10]));
		_command.Parameters.AddWithValue("@pGt_cl", RuntimeHelpers.GetObjectValue(para[11]));
		_command.Parameters.AddWithValue("@pKy_pb", RuntimeHelpers.GetObjectValue(para[12]));
		_command.Parameters.AddWithValue("@pSo_ky", RuntimeHelpers.GetObjectValue(para[13]));
		_command.Parameters.AddWithValue("@pKh_ky", RuntimeHelpers.GetObjectValue(para[14]));
		_command.Parameters.AddWithValue("@pNgay_bdkh", RuntimeHelpers.GetObjectValue(para[15]));
		_command.Parameters.AddWithValue("@pNgay_gt_cl", RuntimeHelpers.GetObjectValue(para[16]));
		_command.Parameters.AddWithValue("@pTk_cptt", RuntimeHelpers.GetObjectValue(para[17]));
		_command.Parameters.AddWithValue("@pTk_cp", RuntimeHelpers.GetObjectValue(para[18]));
		_command.Parameters.AddWithValue("@pMa_bpsd", RuntimeHelpers.GetObjectValue(para[19]));
		_command.Parameters.AddWithValue("@pMa_spct", RuntimeHelpers.GetObjectValue(para[20]));
		_command.Parameters.AddWithValue("@pMa_phi", RuntimeHelpers.GetObjectValue(para[21]));
		_command.Parameters.AddWithValue("@pTinh_kh", RuntimeHelpers.GetObjectValue(para[22]));
		_command.Parameters.AddWithValue("@pSua_kh", RuntimeHelpers.GetObjectValue(para[23]));
		_command.Parameters.AddWithValue("@pCUser", (object)SystemInformations.UserName);
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

	int CODMCPTTDAO.UpdCPTT(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdCPTT
		return this.UpdCPTT(para);
	}

	public int DelCPTT(params object[] para)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		_command.CommandText = "asCoDelDMCPTT";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_cptt", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pID", RuntimeHelpers.GetObjectValue(para[1]));
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

	int CODMCPTTDAO.DelCPTT(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DelCPTT
		return this.DelCPTT(para);
	}
}
