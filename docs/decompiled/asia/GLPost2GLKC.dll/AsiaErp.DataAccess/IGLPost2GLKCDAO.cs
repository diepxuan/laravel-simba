using System;
using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface IGLPost2GLKCDAO : DAO
{
	DataTable GetDmKC(string moduleid);

	int CreateKc(DataRow oDrw, string pMa_ct, DateTime dtmNgay1, DateTime dtmNgay2);

	int DelKc(DataRow oDrw, string pMa_ct, DateTime dtmNgay1, DateTime dtmNgay2);
}
