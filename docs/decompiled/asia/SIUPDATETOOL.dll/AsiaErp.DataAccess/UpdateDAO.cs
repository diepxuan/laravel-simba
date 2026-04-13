using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface UpdateDAO : DAO
{
	int ExecuteTSQL(string tsql);

	int InsertLogUpdate(params object[] param);
}
