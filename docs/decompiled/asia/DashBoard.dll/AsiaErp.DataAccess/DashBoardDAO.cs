using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface DashBoardDAO : DAO
{
	DataTable GetParameter(string spName);

	DataTable GetValueParameter(int DashID);

	int InsValueParameter(int DashID, int Stt, string ParaName, string ParaValue);

	int DelValueParameter(int DashID);

	int GetMaxDashID();

	DataTable GetDashletType();

	DataTable GetDashMenu(int DashID);

	DataTable GetDashFunction(string FunctionID);

	DataTable GetDashRight();

	int SortMenuFrequence(string MenuIdSource, int SttTarget, int DashID);

	DataTable GetMenuFrequence(int DashId, bool Space = false);

	int InsMenuFrequence(string MenuId, int DashId);

	int UpdMenuFrequence(string MenuId, int DashId, bool Space);

	int DelMenuFrequence(string MenuId, int DashId);

	DataTable GetMaxDashPoint(int Location);

	DataTable ProcessSPDashBoard(params object[] para);

	DataTable GetDashForm(string DashID = "");

	int InsDashForm(string Title, int Location, string Format, string FunctionId, int X, int Y, int H, int W, string Type, ref int DashID);

	int UpdDashForm(int Location, string Format, string Title, string DashId, int X, int Y, int H, int W, bool IsMenu = false);

	int DelDashForm(string DashId);

	int UpdDashLocation(int DashIdSrc, int LocationTar, int XTar, int YTar, int HSrc, int WSrc);
}
