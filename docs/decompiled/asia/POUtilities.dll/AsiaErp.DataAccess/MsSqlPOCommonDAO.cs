using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlPOCommonDAO : MsSqlDAO, POCommonDAO
{
	[DebuggerNonUserCode]
	public MsSqlPOCommonDAO()
	{
	}

	public bool POLookupSO14PO0(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOLookupSO14PO0";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)aMa_Cty);
		_command.Parameters.AddWithValue("@pKey", (object)aKey);
		DataSet dataSet = GetDataSet();
		if (dataSet != null)
		{
			oTblPh = dataSet.Tables[0];
			oTblCt = dataSet.Tables[1];
			dataSet.Dispose();
		}
		if ((oTblPh == null || oTblCt == null || oTblPh.Rows.Count == 0 || oTblCt.Rows.Count == 0) ? true : false)
		{
			return false;
		}
		return true;
	}

	bool POCommonDAO.POLookupSO14PO0(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in POLookupSO14PO0
		return this.POLookupSO14PO0(aMa_Cty, aKey, ref oTblPh, ref oTblCt);
	}

	public bool POLookupDN4DH(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOLookupDn4Dh";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)aMa_Cty);
		_command.Parameters.AddWithValue("@pKey", (object)aKey);
		DataSet dataSet = GetDataSet();
		if (dataSet != null)
		{
			oTblPh = dataSet.Tables[0];
			oTblCt = dataSet.Tables[1];
			dataSet.Dispose();
		}
		if ((oTblPh == null || oTblCt == null || oTblPh.Rows.Count == 0 || oTblCt.Rows.Count == 0) ? true : false)
		{
			return false;
		}
		return true;
	}

	bool POCommonDAO.POLookupDN4DH(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in POLookupDN4DH
		return this.POLookupDN4DH(aMa_Cty, aKey, ref oTblPh, ref oTblCt);
	}

	public bool POLookupDH4PN(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOLookupDhPn";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)aMa_Cty);
		_command.Parameters.AddWithValue("@pKey", (object)aKey);
		DataSet dataSet = GetDataSet();
		if (dataSet != null)
		{
			oTblPh = dataSet.Tables[0];
			oTblCt = dataSet.Tables[1];
			dataSet.Dispose();
		}
		if ((oTblPh == null || oTblCt == null || oTblPh.Rows.Count == 0 || oTblCt.Rows.Count == 0) ? true : false)
		{
			return false;
		}
		return true;
	}

	bool POCommonDAO.POLookupDH4PN(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in POLookupDH4PN
		return this.POLookupDH4PN(aMa_Cty, aKey, ref oTblPh, ref oTblCt);
	}

	public bool POLookupPN4HD(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOLookupPnHd";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)aMa_Cty);
		_command.Parameters.AddWithValue("@pKey", (object)aKey);
		DataSet dataSet = GetDataSet();
		if (dataSet != null)
		{
			oTblPh = dataSet.Tables[0];
			oTblCt = dataSet.Tables[1];
			dataSet.Dispose();
		}
		if ((oTblPh == null || oTblCt == null || oTblPh.Rows.Count == 0 || oTblCt.Rows.Count == 0) ? true : false)
		{
			return false;
		}
		return true;
	}

	bool POCommonDAO.POLookupPN4HD(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in POLookupPN4HD
		return this.POLookupPN4HD(aMa_Cty, aKey, ref oTblPh, ref oTblCt);
	}

	public bool POLookupPNHD4CP(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOLookupPnHd4PO4";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)aMa_Cty);
		_command.Parameters.AddWithValue("@pKey", (object)aKey);
		DataSet dataSet = GetDataSet();
		if (dataSet != null)
		{
			oTblPh = dataSet.Tables[0];
			oTblCt = dataSet.Tables[1];
			dataSet.Dispose();
		}
		if ((oTblPh == null || oTblCt == null || oTblPh.Rows.Count == 0 || oTblCt.Rows.Count == 0) ? true : false)
		{
			return false;
		}
		return true;
	}

	bool POCommonDAO.POLookupPNHD4CP(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in POLookupPNHD4CP
		return this.POLookupPNHD4CP(aMa_Cty, aKey, ref oTblPh, ref oTblCt);
	}

	public bool POLookupPN4PX(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOLookupPN4PX";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)aMa_Cty);
		_command.Parameters.AddWithValue("@pKey", (object)aKey);
		DataSet dataSet = GetDataSet();
		if (dataSet != null)
		{
			oTblPh = dataSet.Tables[0];
			oTblCt = dataSet.Tables[1];
			dataSet.Dispose();
		}
		if ((oTblPh == null || oTblCt == null || oTblPh.Rows.Count == 0 || oTblCt.Rows.Count == 0) ? true : false)
		{
			return false;
		}
		return true;
	}

	bool POCommonDAO.POLookupPN4PX(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in POLookupPN4PX
		return this.POLookupPN4PX(aMa_Cty, aKey, ref oTblPh, ref oTblCt);
	}

	public bool POLookupHD4PX(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOLookupHD4PX";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)aMa_Cty);
		_command.Parameters.AddWithValue("@pKey", (object)aKey);
		DataSet dataSet = GetDataSet();
		if (dataSet != null)
		{
			oTblPh = dataSet.Tables[0];
			oTblCt = dataSet.Tables[1];
			dataSet.Dispose();
		}
		if ((oTblPh == null || oTblCt == null || oTblPh.Rows.Count == 0 || oTblCt.Rows.Count == 0) ? true : false)
		{
			return false;
		}
		return true;
	}

	bool POCommonDAO.POLookupHD4PX(string aMa_Cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in POLookupHD4PX
		return this.POLookupHD4PX(aMa_Cty, aKey, ref oTblPh, ref oTblCt);
	}

	public decimal Get_GiaNhap(string pMa_Cty, string pMa_Vt, string pMa_Nt, DateTime pNgay_ct)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOGetGiaNhap";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)pMa_Cty);
		_command.Parameters.AddWithValue("@pKieu_lay_gia", (object)AsiaErp.Framework.Environment.GetPOConfiguration().lay_gia_nhap);
		_command.Parameters.AddWithValue("@pMa_vt", (object)pMa_Vt);
		_command.Parameters.AddWithValue("@pMa_Nt", (object)pMa_Nt);
		_command.Parameters.AddWithValue("@pNgay_ct", (object)pNgay_ct);
		return Conversions.ToDecimal(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(ExecuteScalar()), isNum: true));
	}

	decimal POCommonDAO.Get_GiaNhap(string pMa_Cty, string pMa_Vt, string pMa_Nt, DateTime pNgay_ct)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Get_GiaNhap
		return this.Get_GiaNhap(pMa_Cty, pMa_Vt, pMa_Nt, pNgay_ct);
	}

	public bool POChkStatusRightPO0(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOChkRightStatusPO0";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_cty);
		_command.Parameters.AddWithValue("@pStt_rec", (object)aStt_Rec);
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		aMessContent = Conversions.ToString(ExecuteScalar());
		if ((object)aMessContent == DBNull.Value)
		{
			return true;
		}
		return Operators.CompareString(aMessContent, "", false) == 0;
	}

	bool POCommonDAO.POChkStatusRightPO0(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		//ILSpy generated this explicit interface implementation from .override directive in POChkStatusRightPO0
		return this.POChkStatusRightPO0(aMa_cty, aStt_Rec, ref aMessContent);
	}

	public bool POChkStatusRightPO1(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOChkRightStatusPO1";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_cty);
		_command.Parameters.AddWithValue("@pStt_rec", (object)aStt_Rec);
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		aMessContent = Conversions.ToString(ExecuteScalar());
		if ((object)aMessContent == DBNull.Value)
		{
			return true;
		}
		return Operators.CompareString(aMessContent, "", false) == 0;
	}

	bool POCommonDAO.POChkStatusRightPO1(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		//ILSpy generated this explicit interface implementation from .override directive in POChkStatusRightPO1
		return this.POChkStatusRightPO1(aMa_cty, aStt_Rec, ref aMessContent);
	}

	public bool POChkStatusRightPO2(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOChkRightStatusPO2";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_cty);
		_command.Parameters.AddWithValue("@pStt_rec", (object)aStt_Rec);
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		aMessContent = Conversions.ToString(ExecuteScalar());
		if ((object)aMessContent == DBNull.Value)
		{
			return true;
		}
		return Operators.CompareString(aMessContent, "", false) == 0;
	}

	bool POCommonDAO.POChkStatusRightPO2(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		//ILSpy generated this explicit interface implementation from .override directive in POChkStatusRightPO2
		return this.POChkStatusRightPO2(aMa_cty, aStt_Rec, ref aMessContent);
	}

	public bool POChkStatusRightPO3(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOChkRightStatusPO3";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_cty);
		_command.Parameters.AddWithValue("@pStt_rec", (object)aStt_Rec);
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		aMessContent = Conversions.ToString(ExecuteScalar());
		if ((object)aMessContent == DBNull.Value)
		{
			return true;
		}
		return Operators.CompareString(aMessContent, "", false) == 0;
	}

	bool POCommonDAO.POChkStatusRightPO3(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		//ILSpy generated this explicit interface implementation from .override directive in POChkStatusRightPO3
		return this.POChkStatusRightPO3(aMa_cty, aStt_Rec, ref aMessContent);
	}

	public bool POChkStatusRightPO4(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOChkRightStatusPO4";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_cty);
		_command.Parameters.AddWithValue("@pStt_rec", (object)aStt_Rec);
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		aMessContent = Conversions.ToString(ExecuteScalar());
		if ((object)aMessContent == DBNull.Value)
		{
			return true;
		}
		return Operators.CompareString(aMessContent, "", false) == 0;
	}

	bool POCommonDAO.POChkStatusRightPO4(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		//ILSpy generated this explicit interface implementation from .override directive in POChkStatusRightPO4
		return this.POChkStatusRightPO4(aMa_cty, aStt_Rec, ref aMessContent);
	}

	public bool POChkStatusRightPO6(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOChkRightStatusPO3";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_cty);
		_command.Parameters.AddWithValue("@pStt_rec", (object)aStt_Rec);
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		aMessContent = Conversions.ToString(ExecuteScalar());
		if ((object)aMessContent == DBNull.Value)
		{
			return true;
		}
		return Operators.CompareString(aMessContent, "", false) == 0;
	}

	bool POCommonDAO.POChkStatusRightPO6(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		//ILSpy generated this explicit interface implementation from .override directive in POChkStatusRightPO6
		return this.POChkStatusRightPO6(aMa_cty, aStt_Rec, ref aMessContent);
	}
}
