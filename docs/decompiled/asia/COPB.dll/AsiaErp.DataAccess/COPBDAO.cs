using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface COPBDAO : DAO
{
	DataTable GetDataPbPh(params object[] para);

	DataTable GetDataPbCt(params object[] para);

	DataTable GetDataTypePB(params object[] para);

	int CalPBHS(params object[] para);

	int CalPB(params object[] para);

	int DelcalPB(params object[] para);

	int UPdatePBHS(params object[] para);
}
