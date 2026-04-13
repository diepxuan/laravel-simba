using System;
using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface SiReOrderVoucherNumberDAO : DAO
{
	DataTable GetDmCt(DateTime Ngay1, DateTime Ngay2);

	int ReOrder(string Ma_ct, string So_ct, DateTime Ngay1, DateTime Ngay2);
}
