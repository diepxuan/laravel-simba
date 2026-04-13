using System;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface IGlRptBCT05 : DAO
{
	object UpdateDataCell(string ma_cty, DateTime ngay1, DateTime ngay2, string mau, string maSo, double tien, string stt);
}
