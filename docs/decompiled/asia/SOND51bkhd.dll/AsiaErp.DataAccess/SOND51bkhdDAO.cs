using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface SOND51bkhdDAO : DAO
{
	DataTable GetData();

	DataTable GetData(string ma_tb, bool loai);

	int Insert(string ma_tb, string ma_ph, string mau_so, bool loai, string so_seri, string ten_loai, string tu_so, string den_so, string so_luong, string so_hdin, string so_hdph);

	int Delete(string ma_tb);
}
