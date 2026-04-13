using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface FieldSetupDAO : DAO
{
	DataTable GetFieldSetup(string pVoucher_code);

	DataTable GetFieldInfo();

	DataTable GetCt(string pMa_cty, string pMa_ct);

	int UpdFieldSetup(string pVoucher_code, string pField, string pMaster, string pDetail);

	int InsFieldSetup(string pVoucher_code, string pField, string pMaster, string pDetail);

	int DelFieldSetup(string pVoucher_code, string pField);
}
