using System.Data;
using AsiaErp.Framework;

namespace AsiaERP.DataAccess;

public interface ICODMPBDAO : DAO
{
	int Insert(DataRow dr, string pModuleId);

	int Update(DataRow dr, string pModuleId);
}
