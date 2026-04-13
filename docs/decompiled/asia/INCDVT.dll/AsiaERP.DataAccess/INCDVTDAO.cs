using AsiaErp.Framework;

namespace AsiaERP.DataAccess;

public interface INCDVTDAO : DAO
{
	int ImportCdvtToCdTk(string pMa_cty, int pNam);
}
