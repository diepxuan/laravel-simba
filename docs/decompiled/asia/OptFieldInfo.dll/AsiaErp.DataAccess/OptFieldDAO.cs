using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface OptFieldDAO : DAO
{
	DataTable GetOptField();

	int UpdOptField(int pStt, string pField, string pCaption, string pUser);
}
