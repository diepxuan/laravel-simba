using System.Data;
using AsiaErp.Framework;

namespace AsiaERP.DataAccess;

public interface ICODMPB1DAO : DAO
{
	DataTable GetData(string pMa_Cty, int pId);

	DataTable GetData(string pMa_Cty, string pModuleId);

	int Insert(string pMa_Cty, int pId, string pTk_nhan_pb, string pModuleId);

	int InsertAll(string pMa_cty, int pId, string pTk, string pMa_spct);

	int Delete(string pMa_cty, int pId, string pTk_nhan_pb, string pMa_spct, string pMa_ct);
}
