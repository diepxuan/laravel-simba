using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlCOPBDAO : MsSqlDAO, COPBDAO
{
	[DebuggerNonUserCode]
	public MsSqlCOPBDAO()
	{
	}

	public int Insert_BCTCTM(params object[] para)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		DAOInformation dAOInformation = AsiaErp.Framework.Environment.GetDAOInformation(Conversions.ToString(Operators.ConcatenateObject((object)"glmaubctctm", para[0])));
		_command.CommandText = dAOInformation.ins_sp;
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		int num = Information.UBound((Array)para, 1);
		int num2 = num;
		int num3 = 1;
		checked
		{
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				_command.Parameters.AddWithValue(Conversions.ToString(para[num3]), RuntimeHelpers.GetObjectValue(para[num3 + 1]));
				num3 += 2;
			}
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
	}

	int COPBDAO.Insert_BCTCTM(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Insert_BCTCTM
		return this.Insert_BCTCTM(para);
	}

	public int Delete_BCTCTM(params object[] para)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		_command.CommandText = "asGLRptBCTCTMDel";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pMau", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pNgay1", RuntimeHelpers.GetObjectValue(para[2]));
		_command.Parameters.AddWithValue("@pNgay2", RuntimeHelpers.GetObjectValue(para[3]));
		_command.Parameters.AddWithValue("@pTab_Name", RuntimeHelpers.GetObjectValue(para[4]));
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

	int COPBDAO.Delete_BCTCTM(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Delete_BCTCTM
		return this.Delete_BCTCTM(para);
	}

	public int Cal_BCTCTM(params object[] para)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		_command.CommandText = "asGLRptBCTCTMCal";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(para[0]));
		_command.Parameters.AddWithValue("@pMau", RuntimeHelpers.GetObjectValue(para[1]));
		_command.Parameters.AddWithValue("@pNgay1", RuntimeHelpers.GetObjectValue(para[2]));
		_command.Parameters.AddWithValue("@pNgay2", RuntimeHelpers.GetObjectValue(para[3]));
		_command.Parameters.AddWithValue("@pTab_Name", RuntimeHelpers.GetObjectValue(para[4]));
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

	int COPBDAO.Cal_BCTCTM(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Cal_BCTCTM
		return this.Cal_BCTCTM(para);
	}

	public DataTable Get_BCTCTM()
	{
		_command.CommandText = "asGetReportInfo";
		_command.CommandType = CommandType.StoredProcedure;
		return GetDataTable();
	}

	DataTable COPBDAO.Get_BCTCTM()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Get_BCTCTM
		return this.Get_BCTCTM();
	}
}
