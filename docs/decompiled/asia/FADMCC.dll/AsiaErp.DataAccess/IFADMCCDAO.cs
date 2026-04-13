using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface IFADMCCDAO : DAO
{
	int CheckMaCcExists(params object[] array);

	int DeleteCC(params object[] array);
}
