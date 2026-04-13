using System;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.SOUtilities;

[StandardModule]
public sealed class SOCommon
{
	public static double Get_GiaBan(string aMa_Vt, string aMa_Nt, [Optional][DateTimeConstant(0L)] DateTime aNgay_ct)
	{
		SOCommonDAO sOCommonDAO = (SOCommonDAO)DAOFactory.CreateDAOInstance("SOCommonDAO", "SOUtilities");
		double result = sOCommonDAO.Get_GiaBan(CompanyInformations.CompanyID, aMa_Vt, aMa_Nt, aNgay_ct);
		sOCommonDAO.Destroy();
		return result;
	}

	public static void Get_GiaGiamGia(string aMa_Kh, string aMa_Vt, string aMa_Nt, double aSo_Luong, ref string arTl, ref double arGiamGia, [Optional][DateTimeConstant(0L)] DateTime angay_ct)
	{
		if (Operators.CompareString(Conversions.ToString(Helper.Repl_Null(aMa_Kh, isNum: false)).Trim(), "", false) != 0)
		{
			SOCommonDAO sOCommonDAO = (SOCommonDAO)DAOFactory.CreateDAOInstance("SOCommonDAO", "SOUtilities");
			sOCommonDAO.Get_GiamGia(CompanyInformations.CompanyID, aMa_Kh, aMa_Vt, aMa_Nt, aSo_Luong, ref arTl, ref arGiamGia, angay_ct);
			sOCommonDAO.Destroy();
		}
	}

	public static bool SOLookupDH4PX(string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		SOCommonDAO sOCommonDAO = (SOCommonDAO)DAOFactory.CreateDAOInstance("SOCommonDAO", "SOUtilities");
		bool result = sOCommonDAO.SOLookupDH4PX(CompanyInformations.CompanyID, aKey, ref oTblPh, ref oTblCt);
		sOCommonDAO.Destroy();
		return result;
	}

	public static bool SOLookupDH4HD(string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		SOCommonDAO sOCommonDAO = (SOCommonDAO)DAOFactory.CreateDAOInstance("SOCommonDAO", "SOUtilities");
		bool result = sOCommonDAO.SOLookupDH4HD(CompanyInformations.CompanyID, aKey, ref oTblPh, ref oTblCt);
		sOCommonDAO.Destroy();
		return result;
	}

	public static bool SOLookupPX4HD(string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		SOCommonDAO sOCommonDAO = (SOCommonDAO)DAOFactory.CreateDAOInstance("SOCommonDAO", "SOUtilities");
		bool result = sOCommonDAO.SOLookupPX4HD(CompanyInformations.CompanyID, aKey, ref oTblPh, ref oTblCt);
		sOCommonDAO.Destroy();
		return result;
	}

	public static bool SOLookupPX4PN(string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		SOCommonDAO sOCommonDAO = (SOCommonDAO)DAOFactory.CreateDAOInstance("SOCommonDAO", "SOUtilities");
		bool result = sOCommonDAO.SOLookupPX4PN(CompanyInformations.CompanyID, aKey, ref oTblPh, ref oTblCt);
		sOCommonDAO.Destroy();
		return result;
	}

	public static bool SOLookupHD4PN(string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		SOCommonDAO sOCommonDAO = (SOCommonDAO)DAOFactory.CreateDAOInstance("SOCommonDAO", "SOUtilities");
		bool result = sOCommonDAO.SOLookupHD4PN(CompanyInformations.CompanyID, aKey, ref oTblPh, ref oTblCt);
		sOCommonDAO.Destroy();
		return result;
	}

	public static bool Get_RightPrint(string pMa_cty, string pSo_ct, string pSo_seri, int pLimitedPrint, bool pIs_oke)
	{
		SOCommonDAO sOCommonDAO = (SOCommonDAO)DAOFactory.CreateDAOInstance("SOCommonDAO", "SOUtilities");
		bool result = sOCommonDAO.Get_RightPrint(pMa_cty, pSo_ct, pSo_seri, pLimitedPrint, pIs_oke);
		sOCommonDAO.Destroy();
		return result;
	}

	public static bool SoInsLogPrint(params object[] pArray)
	{
		SOCommonDAO sOCommonDAO = (SOCommonDAO)DAOFactory.CreateDAOInstance("SOCommonDAO", "SOUtilities");
		bool result = sOCommonDAO.SoInsLogPrint(pArray.ToArray());
		sOCommonDAO.Destroy();
		return result;
	}

	public static bool SOChkStatusRightSO1(string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		SOCommonDAO sOCommonDAO = (SOCommonDAO)DAOFactory.CreateDAOInstance("SOCommonDAO", "SOUtilities");
		bool result = sOCommonDAO.SOChkStatusRightSO1(CompanyInformations.CompanyID, aStt_Rec, ref aMessContent);
		sOCommonDAO.Destroy();
		return result;
	}

	public static bool SOChkStatusRightSO2(string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		SOCommonDAO sOCommonDAO = (SOCommonDAO)DAOFactory.CreateDAOInstance("SOCommonDAO", "SOUtilities");
		bool result = sOCommonDAO.SOChkStatusRightSO2(CompanyInformations.CompanyID, aStt_Rec, ref aMessContent);
		sOCommonDAO.Destroy();
		return result;
	}

	public static bool SOChkStatusRightSO3(string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		SOCommonDAO sOCommonDAO = (SOCommonDAO)DAOFactory.CreateDAOInstance("SOCommonDAO", "SOUtilities");
		bool result = sOCommonDAO.SOChkStatusRightSO3(CompanyInformations.CompanyID, aStt_Rec, ref aMessContent);
		sOCommonDAO.Destroy();
		return result;
	}

	public static bool SOChkStatusRightSO5(string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		SOCommonDAO sOCommonDAO = (SOCommonDAO)DAOFactory.CreateDAOInstance("SOCommonDAO", "SOUtilities");
		bool result = sOCommonDAO.SOChkStatusRightSO5(CompanyInformations.CompanyID, aStt_Rec, ref aMessContent);
		sOCommonDAO.Destroy();
		return result;
	}
}
