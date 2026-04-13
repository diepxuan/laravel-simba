using System;
using System.Data;

namespace AsiaErp.DataAccess;

public interface CaVchCA5DAO : BaseVoucherDAO
{
	DataTable Get_PhieuChi(string aMa_cty, string aMa_Kh, DateTime pNgay_ct);

	DataTable Get_PhieuHU(string aMa_cty, string pstt_rec_pc, DateTime pNgay_ct);
}
