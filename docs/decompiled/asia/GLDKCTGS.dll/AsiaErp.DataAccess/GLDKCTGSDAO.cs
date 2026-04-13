using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface GLDKCTGSDAO : DAO
{
	DataTable GetData();

	int DangKyCTGS(params object[] para);
}
