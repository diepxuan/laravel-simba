using System;
using System.Data;
using System.Runtime.InteropServices;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public interface POCommonDAO : DAO
{
	bool POLookupSO14PO0(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);

	bool POLookupDN4DH(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);

	bool POLookupDH4PN(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);

	bool POLookupPN4HD(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);

	bool POLookupPNHD4CP(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);

	bool POLookupPN4PX(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);

	bool POLookupHD4PX(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);

	decimal Get_GiaNhap(string aMa_Cty, string aMa_Vt, string aMa_Nt, DateTime aNgay_ct);

	bool POChkStatusRightPO0(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent);

	bool POChkStatusRightPO1(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent);

	bool POChkStatusRightPO2(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent);

	bool POChkStatusRightPO3(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent);

	bool POChkStatusRightPO4(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent);

	bool POChkStatusRightPO6(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent);
}
