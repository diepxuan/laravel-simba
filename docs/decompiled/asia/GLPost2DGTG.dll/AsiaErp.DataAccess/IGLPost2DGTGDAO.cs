using System;
using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface IGLPost2DGTGDAO : DAO
{
	DataTable GetData();

	int DelDgtg(string pMa_Cty, string pMa_ct, DateTime pNgay1, DateTime pNgay2, int pStt);

	int CreateDgtg(string pMa_cty, string pMa_ct, string pMa_nt, int pStt, DateTime pNgay1, DateTime pNgay2, string pUser);
}
