using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface COPBDAO : DAO
{
	int Insert_BCTCTM(params object[] para);

	int Delete_BCTCTM(params object[] para);

	int Cal_BCTCTM(params object[] para);

	DataTable Get_BCTCTM();
}
