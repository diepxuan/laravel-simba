using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.POUtilities;

[StandardModule]
public sealed class POCommon
{
	public static bool POLookupSO14PO0(string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		bool result = pOCommonDAO.POLookupSO14PO0(CompanyInformations.CompanyID, aKey, ref oTblPh, ref oTblCt);
		pOCommonDAO.Destroy();
		return result;
	}

	public static bool POLookupDN4DH(string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		bool result = pOCommonDAO.POLookupDN4DH(CompanyInformations.CompanyID, aKey, ref oTblPh, ref oTblCt);
		pOCommonDAO.Destroy();
		return result;
	}

	public static bool POLookupDH4PN(string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		bool result = pOCommonDAO.POLookupDH4PN(CompanyInformations.CompanyID, aKey, ref oTblPh, ref oTblCt);
		pOCommonDAO.Destroy();
		return result;
	}

	public static bool POLookupPN4HD(string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		bool result = pOCommonDAO.POLookupPN4HD(CompanyInformations.CompanyID, aKey, ref oTblPh, ref oTblCt);
		pOCommonDAO.Destroy();
		return result;
	}

	public static bool POLookupPNHD4CP(string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		bool result = pOCommonDAO.POLookupPNHD4CP(CompanyInformations.CompanyID, aKey, ref oTblPh, ref oTblCt);
		pOCommonDAO.Destroy();
		return result;
	}

	public static bool POLookupPN4PX(string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		bool result = pOCommonDAO.POLookupPN4PX(CompanyInformations.CompanyID, aKey, ref oTblPh, ref oTblCt);
		pOCommonDAO.Destroy();
		return result;
	}

	public static bool POLookupHD4PX(string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		bool result = pOCommonDAO.POLookupHD4PX(CompanyInformations.CompanyID, aKey, ref oTblPh, ref oTblCt);
		pOCommonDAO.Destroy();
		return result;
	}

	public static decimal Get_GiaNhap(string aMa_Cty, string aMa_Vt, string aMa_Nt, [Optional][DateTimeConstant(0L)] DateTime aNgay_ct)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		decimal result = pOCommonDAO.Get_GiaNhap(aMa_Cty, aMa_Vt, aMa_Nt, aNgay_ct);
		pOCommonDAO.Destroy();
		return result;
	}

	public static bool POChkStatusRightPO0(string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		bool result = pOCommonDAO.POChkStatusRightPO0(CompanyInformations.CompanyID, aStt_Rec, ref aMessContent);
		pOCommonDAO.Destroy();
		return result;
	}

	public static bool POChkStatusRightPO1(string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		bool result = pOCommonDAO.POChkStatusRightPO1(CompanyInformations.CompanyID, aStt_Rec, ref aMessContent);
		pOCommonDAO.Destroy();
		return result;
	}

	public static bool POChkStatusRightPO2(string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		bool result = pOCommonDAO.POChkStatusRightPO2(CompanyInformations.CompanyID, aStt_Rec, ref aMessContent);
		pOCommonDAO.Destroy();
		return result;
	}

	public static bool POChkStatusRightPO3(string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		bool result = pOCommonDAO.POChkStatusRightPO3(CompanyInformations.CompanyID, aStt_Rec, ref aMessContent);
		pOCommonDAO.Destroy();
		return result;
	}

	public static bool POChkStatusRightPO4(string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		bool result = pOCommonDAO.POChkStatusRightPO4(CompanyInformations.CompanyID, aStt_Rec, ref aMessContent);
		pOCommonDAO.Destroy();
		return result;
	}

	public static bool POChkStatusRightPO6(string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		POCommonDAO pOCommonDAO = (POCommonDAO)DAOFactory.CreateDAOInstance("POCommonDAO", "POUtilities");
		bool result = pOCommonDAO.POChkStatusRightPO6(CompanyInformations.CompanyID, aStt_Rec, ref aMessContent);
		pOCommonDAO.Destroy();
		return result;
	}
}
