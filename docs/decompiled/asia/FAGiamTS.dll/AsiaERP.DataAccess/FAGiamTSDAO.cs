using System;
using System.Data;
using AsiaErp.Framework;

namespace AsiaERP.DataAccess;

public interface FAGiamTSDAO : DAO
{
	DataTable GetData(string Ma_Cty, string Ma_ts = "");

	int Update(string ma_cty, string ma_ts, string ma_giam_ts, DateTime ngay_giam, int so_luong, string so_ct_giam, DateTime ngay_ct_giam, string User);

	int Delete(string Ma_Cty, string Ma_Ts, string User);

	bool ChkGiamTs(string Ma_Cty, string Ma_Ts, DateTime Ngay_Giam, string Moi_Sua);
}
