using System;
using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface SOND51phhdDAO : DAO
{
	DataTable GetData(string ma_tb);

	int Insert(string ma_tb, string mau_so, string ma_loai, string so_seri, string so_hd, string tu_so, string den_so, string so_luong, DateTime ngay_sd, string donvi_in, string ma_thuedvi, DateTime ngay_in, string ten_loai);

	int Delete(string ma_tb);
}
