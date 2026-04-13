using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface ISiToolsDao : DAO
{
	DataTable SiGetCompanyInfo();

	int UpdateCompanyInfo(DataRow dr);

	int CreateNewCompanyData(string CompanyOld, string companyNew);

	int CreateNewCompanySys(string CompanyOld, string companyNew);

	DataSet SiGetAllMenu();

	int SiUpdateMenu(DataRow dr);

	int SiInsertMenu(DataRow dr);

	int SiDelMenu(DataRow dr);

	DataSet SiGetAllSys();

	int SiInsertDic(DataRow dr);

	int SiUpdateDic(DataRow dr);

	int SiDelDic(DataRow dr);

	int SiInsertDicRex(DataRow dr);

	int SiUpdateDicRex(DataRow dr);

	int SiDelDicRex(DataRow dr);

	int SiInsertReport(DataRow dr);

	int SiUpdateReport(DataRow dr);

	int SiDelReport(DataRow dr);

	int SiInsertReportRex(DataRow dr);

	int SiUpdateReportRex(DataRow dr);

	int SiDelReportRex(DataRow dr);

	int SiInsertReportDrillDown(DataRow dr);

	int SiUpdateReportDrillDown(DataRow dr);

	int SiDelReportDrillDown(DataRow dr);

	int SiInsertDAO(DataRow dr);

	int SiUpdateDAO(DataRow dr);

	int SiDelDAO(DataRow dr);

	int SiInsertVoucher(DataRow dr);

	int SiUpdateVoucher(DataRow dr);

	int SiDelVoucher(DataRow dr);

	int SiInsertVoucherRex(DataRow dr);

	int SiUpdateVoucherRex(DataRow dr);

	int SiDelVoucherRex(DataRow dr);

	string Gen_FielListDynReport(string SPName);

	int DynInsertUpdateDeleteData(string pXmlData, string pTableName, string pMode);

	DataSet SiGetAllProcPara();

	DataTable SiExcSP_IsReSult(string StrCmd);

	DataTable SiExcSP_NoReSult(string StrCmd);
}
