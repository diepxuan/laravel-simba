using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public class MsSqlGlRptBCT05 : MsSqlDAO, IGlRptBCT05
{
	[DebuggerNonUserCode]
	public MsSqlGlRptBCT05()
	{
	}

	public object UpdateDataCell(string ma_cty, DateTime ngay1, DateTime ngay2, string mau, string maSo, double tien, string stt)
	{
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		_command.CommandText = "asRptUpdTatndn03_dc";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)ma_cty);
		_command.Parameters.AddWithValue("@pNgay1", (object)ngay1);
		_command.Parameters.AddWithValue("@pNgay2", (object)ngay2);
		_command.Parameters.AddWithValue("@pMau", (object)mau);
		_command.Parameters.AddWithValue("@pMa_So", (object)maSo);
		_command.Parameters.AddWithValue("@pTien", (object)tien);
		_command.Parameters.AddWithValue("@pStt", (object)stt);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.SqlDbType = SqlDbType.Int;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return val.Value;
	}

	object IGlRptBCT05.UpdateDataCell(string ma_cty, DateTime ngay1, DateTime ngay2, string mau, string maSo, double tien, string stt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdateDataCell
		return this.UpdateDataCell(ma_cty, ngay1, ngay2, mau, maSo, tien, stt);
	}
}
