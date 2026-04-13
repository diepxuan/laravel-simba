using System.Data.SqlClient;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface DynamicReportDAO : DAO
{
	string GetFilterControl(string spName);

	SqlParameterCollection GetStoreParameterInfo(string spName);
}
