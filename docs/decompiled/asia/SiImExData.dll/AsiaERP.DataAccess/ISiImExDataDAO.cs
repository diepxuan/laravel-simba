using System;
using System.Data;
using AsiaErp.Framework;

namespace AsiaERP.DataAccess;

public interface ISiImExDataDAO : DAO
{
	DataSet GetDataToCombo(string pMa_cty, string pCodeName);

	DataTable GetDataToCopy(string pMa_cty, string pTable_name, string pWhere);

	int InsertData(string xmlData, string pTable_name, string pWs_id, DateTime pNgay1, DateTime pNgay2, string pProc, string pMa_cty, int pDel, string ma_ct);
}
