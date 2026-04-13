using System;
using System.Collections.Generic;
using System.Data;
using AsiaERP.UserInterface;
using AsiaErp.Framework;

namespace AsiaERP.DataAccess;

public interface IGLPost2GLDAO : DAO
{
	List<VoucherInfoDatasource> GetSiCt4PostGl(string pMa_cty, string pMa_ph, string pMa_ct, string pLang);

	DataSet GetVoucher2Post(string pMa_cty, DateTime pNgay1, DateTime pNgay2, string pSo_ct1, string pSo_ct2, string pMa_Ct, string pPost2Gl);

	int Post2GL(string pMa_cty, string pStt_rec, string pMa_ct, string pPost);
}
