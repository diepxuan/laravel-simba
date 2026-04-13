using System;
using AsiaErp.Framework;

namespace AsiaERP.DataAccess;

public interface IFAThoiKHTSDAO : DAO
{
	int Delete(string pMa_cty, string pMa_ts, DateTime pNgay_dung_kh);

	int Check(string pMa_cty, string pMa_ts, DateTime pNgay_dung_kh);
}
