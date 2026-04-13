using System.Data;

namespace AsiaErp.DataAccess;

public interface INVchIN6DAO : BaseVoucherDAO
{
	DataTable ReadCTD(params object[] ParamValues);

	int InsertCTD(DataRow oDr);

	int DeleteCTD(DataRow odr);

	DataTable GetBoMByMa_vt(string aMa_cty, string aMa_Vt);

	bool SearchBOM(string aKeyPh, string aKeyCtM, string aKeyCtD, ref DataTable oTblPh, ref DataTable oTblCtM, ref DataTable oTblCtD);

	DataTable GetPrintDataSource(string aMa_Cty, string aStt_Rec);
}
