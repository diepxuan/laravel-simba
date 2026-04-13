using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface ICODMBOMDAO : DAO
{
	DataTable GetCoDmbomPH();

	int InsCoDmbomPH(DataRow oDrw);

	int UpdCoDmbomPH(DataRow oDrw);

	int DelCoDmbomPH(string pMa_spct);

	DataTable GetCoDmbomCT();

	int InsCoDmbomCT(DataRow oDrw);

	int DelCoDmbomCT(string pMa_spct, string pMa_vt);
}
