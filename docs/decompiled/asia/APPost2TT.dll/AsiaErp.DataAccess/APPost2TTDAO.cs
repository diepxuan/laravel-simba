using System;
using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface APPost2TTDAO : DAO
{
	DataTable GetData();

	DataTable GetData(string Tk, string ma_kh, DateTime ngay_ct, string loai, string stt_rec = null);

	DataTable GetDataCT(params object[] array);

	int Insert(params object[] array);

	int Delete(params object[] array);
}
