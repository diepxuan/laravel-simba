using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface SOND51dmmhdDAO : DAO
{
	DataTable GetData(string ma_loai);

	int Insert(string mau_so, string mo_ta1, string mo_ta2, string mo_ta3 = "", string mo_ta4 = "", string mo_ta5 = "", string mo_ta6 = "", string mo_ta7 = "", string mo_ta8 = "", string mo_ta9 = "");

	int Delete(string mau_so);
}
