using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface SOND51mhdDAO : DAO
{
	DataTable GetData(string ma_loai, string so_hd);

	int Insert(string ma_loai, string so_hd, string mo_ta1, string mo_ta2, string mo_ta3 = "", string mo_ta4 = "", string mo_ta5 = "", string mo_ta6 = "", string mo_ta7 = "", string mo_ta8 = "", string mo_ta9 = "");

	int Delete(string ma_loai, string so_hd);
}
