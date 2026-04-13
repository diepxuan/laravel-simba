using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface SOND51mathdDAO : DAO
{
	DataTable GetData(string ma_tb);

	DataTable GetData(string ngay1, string ngay2);

	int Insert(string ma_tb, string ma_chung, string ten_loai, string mau_so, string so_seri, string tu_so, string den_so, string so_luong, string lien_hd, string ghi_chu);

	int Delete(string ma_tb);
}
