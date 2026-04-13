using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.DataAccess;

public class MssqlCODMPBDAO : MsSqlDAO, ICODMPBDAO
{
	[DebuggerNonUserCode]
	public MssqlCODMPBDAO()
	{
	}

	public int Insert(DataRow dr, string pModuleId)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		SqlParameter[] array = (SqlParameter[])(object)new SqlParameter[12]
		{
			new SqlParameter("@pMa_cty", SqlDbType.NVarChar),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter)
		};
		array[0].Value = CompanyInformations.CompanyID;
		array[1] = new SqlParameter("@pStt", SqlDbType.Int);
		array[1].Value = RuntimeHelpers.GetObjectValue(dr["stt"]);
		array[2] = new SqlParameter("@pTen_bt", SqlDbType.NVarChar);
		array[2].Value = RuntimeHelpers.GetObjectValue(dr["Ten_bt"]);
		array[3] = new SqlParameter("@pTk_pb", SqlDbType.NVarChar);
		array[3].Value = RuntimeHelpers.GetObjectValue(dr["Tk_pb"]);
		array[4] = new SqlParameter("@pSo_ct", SqlDbType.NVarChar);
		array[4].Value = RuntimeHelpers.GetObjectValue(dr["So_ct"]);
		array[5] = new SqlParameter("@pKsd", SqlDbType.Bit);
		array[5].Value = RuntimeHelpers.GetObjectValue(dr["Ksd"]);
		array[6] = new SqlParameter("@pUser", SqlDbType.NVarChar);
		array[6].Value = RuntimeHelpers.GetObjectValue(dr["cuser"]);
		array[7] = new SqlParameter("@pTheoSPCT", SqlDbType.Bit);
		array[7].Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["TheoSPCT"]), isNum: true));
		array[8] = new SqlParameter("@pTheoBP", SqlDbType.Bit);
		array[8].Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["TheoBP"]), isNum: true));
		array[9] = new SqlParameter("@pTheoTKDU", SqlDbType.Bit);
		array[9].Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["TheoTKDU"]), isNum: true));
		array[11] = new SqlParameter("@pModuleId", SqlDbType.NVarChar, 5);
		array[11].Value = pModuleId;
		array[10] = new SqlParameter("@pRet", SqlDbType.Int);
		array[10].Direction = ParameterDirection.Output;
		_command.Parameters.Clear();
		_command.Parameters.AddRange(array);
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "[dbo].[asCOInsDMPB]";
		ExecuteNonQuery();
		return Conversions.ToInteger(_command.Parameters["@pRet"].Value);
	}

	int ICODMPBDAO.Insert(DataRow dr, string pModuleId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Insert
		return this.Insert(dr, pModuleId);
	}

	public int Update(DataRow dr, string pModuleId)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		SqlParameter[] array = (SqlParameter[])(object)new SqlParameter[13]
		{
			new SqlParameter("@pMa_cty", SqlDbType.NVarChar),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter),
			default(SqlParameter)
		};
		array[0].Value = CompanyInformations.CompanyID;
		array[1] = new SqlParameter("@pStt", SqlDbType.Int);
		array[1].Value = RuntimeHelpers.GetObjectValue(dr["stt"]);
		array[2] = new SqlParameter("@pTen_bt", SqlDbType.NVarChar);
		array[2].Value = RuntimeHelpers.GetObjectValue(dr["Ten_bt"]);
		array[3] = new SqlParameter("@pTk_pb", SqlDbType.NVarChar);
		array[3].Value = RuntimeHelpers.GetObjectValue(dr["Tk_pb"]);
		array[4] = new SqlParameter("@pSo_ct", SqlDbType.NVarChar);
		array[4].Value = RuntimeHelpers.GetObjectValue(dr["So_ct"]);
		array[5] = new SqlParameter("@pKsd", SqlDbType.Bit);
		array[5].Value = RuntimeHelpers.GetObjectValue(dr["Ksd"]);
		array[6] = new SqlParameter("@pUser", SqlDbType.NVarChar);
		array[6].Value = RuntimeHelpers.GetObjectValue(dr["luser"]);
		array[7] = new SqlParameter("@pTheoSPCT", SqlDbType.Bit);
		array[7].Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["TheoSPCT"]), isNum: true));
		array[8] = new SqlParameter("@pTheoBP", SqlDbType.Bit);
		array[8].Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["TheoBP"]), isNum: true));
		array[9] = new SqlParameter("@pTheoTKDU", SqlDbType.Bit);
		array[9].Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["TheoTKDU"]), isNum: true));
		array[11] = new SqlParameter("@pID", SqlDbType.Int);
		array[11].Value = RuntimeHelpers.GetObjectValue(dr["ID"]);
		array[12] = new SqlParameter("@pModuleId", SqlDbType.NVarChar, 5);
		array[12].Value = pModuleId;
		array[10] = new SqlParameter("@pRet", SqlDbType.Int);
		array[10].Direction = ParameterDirection.Output;
		_command.Parameters.Clear();
		_command.Parameters.AddRange(array);
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "[dbo].[asCOUpdDMPB]";
		ExecuteNonQuery();
		return Conversions.ToInteger(_command.Parameters["@pRet"].Value);
	}

	int ICODMPBDAO.Update(DataRow dr, string pModuleId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Update
		return this.Update(dr, pModuleId);
	}
}
