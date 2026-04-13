using System.Data;
using AsiaErp.Framework;

public interface GLBUDGETDAO : DAO
{
	DataTable GetGLBUDGET(string pMa_cty, int pNam, string pStt_rec = null, string pMa_tk = null, string pMa_tk_du = null, string pMa_bp = null, string pMa_phi = null, string pMa_spct = null, string pTtps_no_co = null);

	DataTable GetSample0Budget(string pMa_cty, string pTK, string pLoai_ps, string pMa_bp, string pMa_phi, string pTK_du, int pNam, string pMa_spct);

	DataTable GetSample1Budget(string pMa_cty, int pNam, string pTK, string pMa_bp, string pMa_phi, string pMa_spct);

	string asInsBudget(DataRow dt, string spName);

	string asUpdBudget(DataRow dt, string spName);

	bool asDelBudget(DataRow dt, string spName);
}
