using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlSOCommonDAO : MsSqlDAO, SOCommonDAO
{
	[DebuggerNonUserCode]
	public MsSqlSOCommonDAO()
	{
	}

	public double Get_GiaBan(string aMa_Cty, string aMa_Vt, string aMa_Nt, [Optional][DateTimeConstant(0L)] DateTime aNgay_ct)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOGetGiaban";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)aMa_Cty);
		_command.Parameters.AddWithValue("@pKieu_lay_gia", (object)AsiaErp.Framework.Environment.GetSOConfiguration().lay_gia_ban);
		_command.Parameters.AddWithValue("@pMa_vt", (object)aMa_Vt);
		_command.Parameters.AddWithValue("@pMa_Nt", (object)aMa_Nt);
		if (DateTime.Compare(aNgay_ct, DateTime.MinValue) == 0)
		{
			aNgay_ct = DateTime.Now;
		}
		_command.Parameters.AddWithValue("@pNgay_ct", (object)aNgay_ct);
		return Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(ExecuteScalar()), isNum: true));
	}

	double SOCommonDAO.Get_GiaBan(string aMa_Cty, string aMa_Vt, string aMa_Nt, [Optional][DateTimeConstant(0L)] DateTime aNgay_ct)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Get_GiaBan
		return this.Get_GiaBan(aMa_Cty, aMa_Vt, aMa_Nt, aNgay_ct);
	}

	public void Get_GiamGia(string aMa_Cty, string aMa_Kh, string aMa_Vt, string aMa_Nt, double aSo_Luong, ref string arTl, ref double arGiamGia, [Optional][DateTimeConstant(0L)] DateTime angay_ct)
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetGiabanGiamGia";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)aMa_Cty);
		_command.Parameters.AddWithValue("@pMa_vt", (object)aMa_Vt);
		_command.Parameters.AddWithValue("@pMa_kh", (object)aMa_Kh);
		_command.Parameters.AddWithValue("@pSo_Luong", (object)aSo_Luong);
		_command.Parameters.AddWithValue("@pMa_Nt", (object)aMa_Nt);
		if (DateTime.Compare(angay_ct, DateTime.MinValue) == 0)
		{
			angay_ct = DateTime.Now;
		}
		_command.Parameters.AddWithValue("@pNgay_ct", (object)angay_ct);
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pTl_gt";
		val.SqlDbType = SqlDbType.NVarChar;
		val.Size = 1;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		val = new SqlParameter();
		val.ParameterName = "@pGg";
		val.SqlDbType = SqlDbType.Money;
		val.Size = 19;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		if (ExecuteNonQuery() == 0)
		{
			arTl = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pTl_gt"].Value), isNum: false));
			arGiamGia = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pGg"].Value), isNum: true));
		}
	}

	void SOCommonDAO.Get_GiamGia(string aMa_Cty, string aMa_Kh, string aMa_Vt, string aMa_Nt, double aSo_Luong, ref string arTl, ref double arGiamGia, [Optional][DateTimeConstant(0L)] DateTime angay_ct)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Get_GiamGia
		this.Get_GiamGia(aMa_Cty, aMa_Kh, aMa_Vt, aMa_Nt, aSo_Luong, ref arTl, ref arGiamGia, angay_ct);
	}

	public bool SOLookupDH4PX(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOLookupDhPx";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_cty);
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

	bool SOCommonDAO.SOLookupDH4PX(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SOLookupDH4PX
		return this.SOLookupDH4PX(aMa_cty, aKey, ref oTblPh, ref oTblCt);
	}

	public bool SOLookupDH4HD(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOLookupDhHd";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_cty);
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

	bool SOCommonDAO.SOLookupDH4HD(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SOLookupDH4HD
		return this.SOLookupDH4HD(aMa_cty, aKey, ref oTblPh, ref oTblCt);
	}

	public bool SOLookupPX4HD(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOLookupPxHd";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_cty);
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

	bool SOCommonDAO.SOLookupPX4HD(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SOLookupPX4HD
		return this.SOLookupPX4HD(aMa_cty, aKey, ref oTblPh, ref oTblCt);
	}

	public bool SOLookupPX4PN(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOLookupPxPn";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_cty);
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

	bool SOCommonDAO.SOLookupPX4PN(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SOLookupPX4PN
		return this.SOLookupPX4PN(aMa_cty, aKey, ref oTblPh, ref oTblCt);
	}

	public bool SOLookupHD4PN(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOLookupHdPn";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_cty);
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

	bool SOCommonDAO.SOLookupHD4PN(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SOLookupHD4PN
		return this.SOLookupHD4PN(aMa_cty, aKey, ref oTblPh, ref oTblCt);
	}

	public bool Get_RightPrint(string pMa_cty, string pSo_ct, string pSo_seri, int pLimitedPrint, bool pIs_oke)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asCheckRightPrint";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pSo_ct", (object)pSo_ct);
		_command.Parameters.AddWithValue("@pSo_seri", (object)pSo_seri);
		_command.Parameters.AddWithValue("@pLimitedPrint", (object)pLimitedPrint);
		_command.Parameters.AddWithValue("@pIs_oke", (object)pIs_oke);
		_command.Parameters["@pIs_oke"].Direction = ParameterDirection.Output;
		ExecuteNonQuery();
		return Conversions.ToBoolean(_command.Parameters["@pIs_oke"].Value);
	}

	bool SOCommonDAO.Get_RightPrint(string pMa_cty, string pSo_ct, string pSo_seri, int pLimitedPrint, bool pIs_oke)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Get_RightPrint
		return this.Get_RightPrint(pMa_cty, pSo_ct, pSo_seri, pLimitedPrint, pIs_oke);
	}

	public bool SoInsLogPrint(params object[] pArray)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsLogPrint";
		_command.Parameters.Clear();
		SqlCommandBuilder.DeriveParameters(_command);
		checked
		{
			int num = _command.Parameters.Count - 1;
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				_command.Parameters[num2].Value = RuntimeHelpers.GetObjectValue(pArray[num2 - 1]);
				num2++;
			}
			return ExecuteNonQuery() != 0;
		}
	}

	bool SOCommonDAO.SoInsLogPrint(params object[] pArray)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SoInsLogPrint
		return this.SoInsLogPrint(pArray);
	}

	public bool SOChkStatusRightSO1(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOChkRightStatusSO1";
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

	bool SOCommonDAO.SOChkStatusRightSO1(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SOChkStatusRightSO1
		return this.SOChkStatusRightSO1(aMa_cty, aStt_Rec, ref aMessContent);
	}

	public bool SOChkStatusRightSO2(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOChkRightStatusSO2";
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

	bool SOCommonDAO.SOChkStatusRightSO2(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SOChkStatusRightSO2
		return this.SOChkStatusRightSO2(aMa_cty, aStt_Rec, ref aMessContent);
	}

	public bool SOChkStatusRightSO3(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOChkRightStatusSO3";
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

	bool SOCommonDAO.SOChkStatusRightSO3(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SOChkStatusRightSO3
		return this.SOChkStatusRightSO3(aMa_cty, aStt_Rec, ref aMessContent);
	}

	public bool SOChkStatusRightSO5(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOChkRightStatusSO5";
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

	bool SOCommonDAO.SOChkStatusRightSO5(string aMa_cty, string aStt_Rec, [Optional][DefaultParameterValue("")] ref string aMessContent)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SOChkStatusRightSO5
		return this.SOChkStatusRightSO5(aMa_cty, aStt_Rec, ref aMessContent);
	}
}
