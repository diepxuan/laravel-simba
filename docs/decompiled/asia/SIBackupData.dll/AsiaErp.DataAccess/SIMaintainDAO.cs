using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface SIMaintainDAO : DAO
{
	DataTable GetDSMa();

	int ExecuteDelSpace(string pMa_cty, string pLst_Ma);

	int BackupDB(string pStr_Path);

	int CreateAutoBackupDB(params object[] para);

	int ExecuteReIndex();
}
