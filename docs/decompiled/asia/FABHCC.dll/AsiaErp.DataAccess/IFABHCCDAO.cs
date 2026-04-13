using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface IFABHCCDAO : DAO
{
	DataTable GetData(string pMa_cty);

	int Insert(DataRow oDrw);

	int Update(DataRow oDrw);

	int Delete(string pMa_cty, string pMa_cc, int pId);

	DataTable GetBHCCInfor(string pMa_cty, string pMa_cc, int pId, bool edit, string stt_rec);
}
