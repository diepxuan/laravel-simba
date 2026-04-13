using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface ReportDynamicDAO : DAO
{
	string GetFilterControl(string spName);
}
