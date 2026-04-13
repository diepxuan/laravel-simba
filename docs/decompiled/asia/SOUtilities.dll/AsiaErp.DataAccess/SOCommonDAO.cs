using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface SOCommonDAO : DAO
{
	double Get_GiaBan(string aMa_Cty, string aMa_Vt, string aMa_Nt, [Optional][DateTimeConstant(0L)] DateTime aNgay_ct);

	void Get_GiamGia(string aMa_Cty, string aMa_Kh, string aMa_Vt, string aMa_Nt, double aSo_Luong, ref string arTl, ref double arGiamGia, [Optional][DateTimeConstant(0L)] DateTime angay_ct);

	bool SOLookupDH4PX(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);

	bool SOLookupDH4HD(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);

	bool SOLookupPX4HD(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);

	bool SOLookupPX4PN(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);

	bool SOLookupHD4PN(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);

	bool Get_RightPrint(string pMa_cty, string pSo_ct, string pSo_seri, int pLimitedPrint, bool pIs_oke);

	bool SoInsLogPrint(params object[] pArray);

	bool SOChkStatusRightSO1(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent);

	bool SOChkStatusRightSO2(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent);

	bool SOChkStatusRightSO3(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent);

	bool SOChkStatusRightSO5(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent);
}
