using System.Data;

namespace AsiaErp.DataAccess;

public interface SISysvarsDAO
{
	int UpdSISysvars(params object[] obj);

	DataTable GetSISSysvars(params object[] obj);
}
