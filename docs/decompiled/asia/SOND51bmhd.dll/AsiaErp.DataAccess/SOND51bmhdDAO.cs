using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface SOND51bmhdDAO : DAO
{
	DataTable GetData();

	int Update(string gia_tri, bool ksd, bool isFirst);
}
