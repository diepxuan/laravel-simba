using System.Data;
using AsiaErp.Framework;

namespace AsiaERP.DataAccess;

public interface ICalcSumTKDAO : DAO
{
	DataTable CalcSumCdTk(string pMa_cty, string pMa_tk, int pNam, string pMa_nt);
}
