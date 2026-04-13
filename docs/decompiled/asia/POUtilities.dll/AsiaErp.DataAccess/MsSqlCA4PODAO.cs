using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlCA4PODAO : MsSqlDAO
{
	[DebuggerNonUserCode]
	public MsSqlCA4PODAO()
	{
	}

	public bool SOSaveCAPH4PO(ref string aStt_rec, string pMa_ct, string pStt_rec_hd, DateTime pNgay_ct, string pSo_ct, string pMa_kh, string pDia_chi, string pNguoi_gd, string pDien_giai, string pMa_nt, decimal pTy_gia, decimal pT_tien_nt, decimal pT_tien, string pTk_co, string pUser)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOSaveCAPH4PO";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pStt_rec", (object)aStt_rec).Direction = ParameterDirection.Output;
		_command.Parameters.AddWithValue("@pMa_ct", (object)pMa_ct);
		_command.Parameters.AddWithValue("@pStt_rec_hd", (object)pStt_rec_hd);
		_command.Parameters.AddWithValue("@pNgay_ct", (object)pNgay_ct);
		_command.Parameters.AddWithValue("@pSo_ct", (object)pSo_ct);
		_command.Parameters.AddWithValue("@pMa_kh", (object)pMa_kh);
		_command.Parameters.AddWithValue("@pDia_chi", (object)pDia_chi);
		_command.Parameters.AddWithValue("@pNguoi_gd", (object)pNguoi_gd);
		_command.Parameters.AddWithValue("@pDien_giai", (object)pDien_giai);
		_command.Parameters.AddWithValue("@pMa_nt", (object)pMa_nt);
		_command.Parameters.AddWithValue("@pTy_gia", (object)pTy_gia);
		_command.Parameters.AddWithValue("@pT_tien_nt", (object)pT_tien_nt);
		_command.Parameters.AddWithValue("@pT_tien", (object)pT_tien);
		_command.Parameters.AddWithValue("@pTk_co", (object)pTk_co);
		_command.Parameters.AddWithValue("@pUser", (object)pUser);
		object objectValue = RuntimeHelpers.GetObjectValue(ExecuteScalar());
		if (objectValue == null || (Operators.ConditionalCompareObjectEqual(objectValue, (object)"", false) ? true : false))
		{
			return false;
		}
		aStt_rec = Conversions.ToString(objectValue);
		return true;
	}

	public object SOSaveCACT4PO(DataRow oDr)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asPOSaveCACT4PO";
		_command.Parameters.Clear();
		SqlCommandDerivedParameters();
		object result;
		checked
		{
			int num = _command.Parameters.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				string text = _command.Parameters[num2].ParameterName.Remove(0, 2);
				if ((oDr.Table.Columns.Contains(text) && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(oDr[text]))) ? true : false)
				{
					_command.Parameters[num2].Value = RuntimeHelpers.GetObjectValue(oDr[text]);
				}
				else
				{
					_command.Parameters[num2].Value = RuntimeHelpers.GetObjectValue(Helper.DefaulValueOfType(_command.Parameters[num2].SqlDbType));
				}
				num2++;
			}
			try
			{
				if (ExecuteNonQuery(showMessage: false) != 0)
				{
					result = false;
					goto IL_01b6;
				}
				if (_command.Parameters.Contains("@pRet"))
				{
					result = Operators.CompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true), (object)0, false);
					goto IL_01b6;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Helper.ProcessError(ex2);
				result = false;
				ProjectData.ClearProjectError();
				goto IL_01b6;
			}
			result = true;
			goto IL_01b6;
		}
		IL_01b6:
		return result;
	}

	public bool DBProcess(string aMa_Cty, string aMa_Ct, string aStt_Rec, string aMode)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asProcessCt";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_Cty);
		_command.Parameters.AddWithValue("@pMa_Ct", (object)aMa_Ct);
		_command.Parameters.AddWithValue("@pStt_rec", (object)aStt_Rec);
		_command.Parameters.AddWithValue("@pMode", (object)aMode);
		return ExecuteNonQuery() == 0;
	}
}
