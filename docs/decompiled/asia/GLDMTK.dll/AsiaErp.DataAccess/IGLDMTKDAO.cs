using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface IGLDMTKDAO : DAO
{
	int CheckTkMe(string pTk);
}
