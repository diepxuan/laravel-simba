using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.DataAccess;

public class MsSqlINCDFIFODAO : MsSqlDAO, INCDFIFODAO
{
	[DebuggerNonUserCode]
	public MsSqlINCDFIFODAO()
	{
	}

	public int ImportCdvtToCdTk(string pMa_cty, int pNam)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		_command.CommandText = "asInImport_cdvt_cdtk";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pNam", (object)pNam);
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

	int INCDFIFODAO.ImportCdvtToCdTk(string pMa_cty, int pNam)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ImportCdvtToCdTk
		return this.ImportCdvtToCdTk(pMa_cty, pNam);
	}

	public DataTable GetStt_rec04CDFIFO(string pMa_cty, DateTime pNgay_ct, string pSo_ct)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asINGetStt_rec04CDFIFO";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pNgay_ct", (object)pNgay_ct);
		_command.Parameters.AddWithValue("@pSo_ct", (object)pSo_ct);
		return GetDataTable();
	}

	DataTable INCDFIFODAO.GetStt_rec04CDFIFO(string pMa_cty, DateTime pNgay_ct, string pSo_ct)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetStt_rec04CDFIFO
		return this.GetStt_rec04CDFIFO(pMa_cty, pNgay_ct, pSo_ct);
	}
}
