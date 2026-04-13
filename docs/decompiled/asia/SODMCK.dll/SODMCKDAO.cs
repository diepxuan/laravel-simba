using System.Data;
using AsiaErp.Framework;

public interface SODMCKDAO : DAO
{
	DataTable GetSODMCK(string pMa_cty, string pMa_VT, string pMa_NHVT, string pMa_KH, string pMa_NHKH);
}
