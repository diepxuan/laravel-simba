using System.Collections;
using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public class MssqlSODMCKDAO : MsSqlDAO, SODMCKDAO
{
	public DataTable GetSODMCK(string pMa_cty, string pMa_VT, string pMa_NHVT, string pMa_KH, string pMa_NHKH)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(pMa_cty);
		arrayList.Add("");
		arrayList.Add("");
		arrayList.Add("");
		arrayList.Add("");
		arrayList.Add("");
		arrayList.Add("");
		arrayList.Add(pMa_VT);
		arrayList.Add(pMa_NHVT);
		arrayList.Add(pMa_KH);
		arrayList.Add(pMa_NHKH);
		return GetDataTable("[dbo].[asSOGetCk]", arrayList.ToArray());
	}

	DataTable SODMCKDAO.GetSODMCK(string pMa_cty, string pMa_VT, string pMa_NHVT, string pMa_KH, string pMa_NHKH)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetSODMCK
		return this.GetSODMCK(pMa_cty, pMa_VT, pMa_NHVT, pMa_KH, pMa_NHKH);
	}
}
