using System.Data;

namespace AsiaErp.DataAccess;

public interface CaVchCA2DAO : BaseVoucherDAO
{
	DataTable GetDataToKeThueVATNK(string pMa_cty, string pStt_rec);

	int UpdateToKeThueVATNK(DataRow pDrv);
}
