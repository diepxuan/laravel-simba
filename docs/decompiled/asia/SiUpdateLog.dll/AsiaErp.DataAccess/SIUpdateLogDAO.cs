using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface SIUpdateLogDAO : DAO
{
	DataTable GetUpdateLog();

	DataTable GetDataDetail(int pID = 0);

	DataTable GetModule(bool isModule, string Menuid = "");

	DataTable GetHistory(int ID);

	int InsHistory(int ID);

	int InsUpdateLogPH(object[] para, ref int ID);

	int InsUpdateLogCT(object[] para);

	int DelUpdateLogCT(int pID);

	DataTable GetLookup(int ID, string ProductID);
}
