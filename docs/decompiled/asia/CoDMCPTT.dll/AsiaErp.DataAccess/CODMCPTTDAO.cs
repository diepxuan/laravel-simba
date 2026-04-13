using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface CODMCPTTDAO : DAO
{
	int InsCPTT(params object[] para);

	int UpdCPTT(params object[] para);

	int DelCPTT(params object[] para);
}
