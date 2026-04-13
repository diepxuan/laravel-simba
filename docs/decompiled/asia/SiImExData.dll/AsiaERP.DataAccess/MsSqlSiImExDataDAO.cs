using System;
using System.Data;
using System.Diagnostics;
using AsiaErp.Framework;

namespace AsiaERP.DataAccess;

public class MsSqlSiImExDataDAO : MsSqlDAO, ISiImExDataDAO
{
	[DebuggerNonUserCode]
	public MsSqlSiImExDataDAO()
	{
	}

	public DataSet GetDataToCombo(string pMa_cty, string pCodeName)
	{
		_command.Parameters.Clear();
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSiGetImExDataInfo";
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pCodeName", (object)pCodeName);
		return GetDataSet();
	}

	DataSet ISiImExDataDAO.GetDataToCombo(string pMa_cty, string pCodeName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDataToCombo
		return this.GetDataToCombo(pMa_cty, pCodeName);
	}

	public DataTable GetDataToCopy(string pMa_cty, string pTable_name, string pWhere)
	{
		_command.Parameters.Clear();
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSiGetDataToCopy";
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pTable_name", (object)pTable_name);
		_command.Parameters.AddWithValue("@pWhere", (object)pWhere);
		return GetDataTable();
	}

	DataTable ISiImExDataDAO.GetDataToCopy(string pMa_cty, string pTable_name, string pWhere)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDataToCopy
		return this.GetDataToCopy(pMa_cty, pTable_name, pWhere);
	}

	public int InsertData(string pxmlData, string pTable_name, string pWs_id, DateTime pNgay1, DateTime pNgay2, string pProc, string pMa_cty, int pDel, string pMa_ct)
	{
		_command.Parameters.Clear();
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSiInsertImExData";
		_command.Parameters.AddWithValue("@pXmlData", (object)pxmlData);
		_command.Parameters.AddWithValue("@pTable_name", (object)pTable_name);
		_command.Parameters.AddWithValue("@pWs_id", (object)pWs_id);
		_command.Parameters.AddWithValue("@pNgay1", (object)pNgay1);
		_command.Parameters.AddWithValue("@pNgay2", (object)pNgay2);
		_command.Parameters.AddWithValue("@pProc", (object)pProc);
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pDel", (object)pDel);
		_command.Parameters.AddWithValue("@pMa_ct", (object)pMa_ct);
		return ExecuteNonQuery();
	}

	int ISiImExDataDAO.InsertData(string pxmlData, string pTable_name, string pWs_id, DateTime pNgay1, DateTime pNgay2, string pProc, string pMa_cty, int pDel, string pMa_ct)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsertData
		return this.InsertData(pxmlData, pTable_name, pWs_id, pNgay1, pNgay2, pProc, pMa_cty, pDel, pMa_ct);
	}
}
