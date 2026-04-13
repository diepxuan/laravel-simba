using System.Data;
using AsiaErp.Framework;

namespace AsiaERP.DataAccess;

public interface VOUCHERDAO : DAO
{
	int UpdateToDB(DataRow odr);

	DataTable GetFieldDescription(string tableName);
}
