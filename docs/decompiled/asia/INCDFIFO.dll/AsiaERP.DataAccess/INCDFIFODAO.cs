using System;
using System.Data;
using AsiaErp.Framework;

namespace AsiaERP.DataAccess;

public interface INCDFIFODAO : DAO
{
	int ImportCdvtToCdTk(string pMa_cty, int pNam);

	DataTable GetStt_rec04CDFIFO(string pMa_cty, DateTime pNgay_ct, string pSo_ct);
}
