using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface IFADGTSDAO : DAO
{
	int CheckDgtsSauGiamTS(params object[] Array);
}
