using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface IFADMTSDAO : DAO
{
	int CheckMaTSExists(params object[] array);
}
