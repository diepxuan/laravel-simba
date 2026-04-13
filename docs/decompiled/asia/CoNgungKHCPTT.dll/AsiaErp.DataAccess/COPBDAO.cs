using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface COPBDAO : DAO
{
	int CoUpdNgungKH_CPTT(params object[] para);

	int CoDelNgungKH_CPTT(params object[] para);
}
