using System;
using System.Data;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlINVchIN6DAO : MsSqlBaseVoucherDAO, INVchIN6DAO
{
	public DataTable ReadCTD(params object[] ParamValues)
	{
		return GetDataTable("asINGetCt6D", ParamValues);
	}

	DataTable INVchIN6DAO.ReadCTD(params object[] ParamValues)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ReadCTD
		return this.ReadCTD(ParamValues);
	}

	public int InsertCTD(DataRow oDr)
	{
		int result;
		checked
		{
			if (oDr == null)
			{
				result = 0;
			}
			else
			{
				_command.CommandType = CommandType.StoredProcedure;
				_command.CommandText = "asINInsCt6D";
				_command.Parameters.Clear();
				SqlCommandDerivedParameters();
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
					int num5 = ExecuteNonQuery(showMessage: false);
					if (num5 != 0)
					{
						result = num5;
						goto IL_01b2;
					}
					if (_command.Parameters.Contains("@pRet"))
					{
						result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
						goto IL_01b2;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Helper.ProcessError(ex2);
					result = 50010;
					ProjectData.ClearProjectError();
					goto IL_01b2;
				}
				result = 0;
			}
			goto IL_01b2;
		}
		IL_01b2:
		return result;
	}

	int INVchIN6DAO.InsertCTD(DataRow oDr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsertCTD
		return this.InsertCTD(oDr);
	}

	public int DeleteCTD(DataRow odr)
	{
		int result;
		checked
		{
			if (odr == null)
			{
				result = 0;
			}
			else
			{
				_command.CommandType = CommandType.StoredProcedure;
				_command.CommandText = "asINDelCt6D";
				_command.Parameters.Clear();
				SqlCommandDerivedParameters();
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
					if ((odr.Table.Columns.Contains(text) && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(odr[text]))) ? true : false)
					{
						_command.Parameters[num2].Value = RuntimeHelpers.GetObjectValue(odr[text]);
					}
					else
					{
						_command.Parameters[num2].Value = RuntimeHelpers.GetObjectValue(Helper.DefaulValueOfType(_command.Parameters[num2].SqlDbType));
					}
					num2++;
				}
				try
				{
					int num5 = ExecuteNonQuery(showMessage: false);
					if (num5 != 0)
					{
						result = num5;
						goto IL_01b2;
					}
					if (_command.Parameters.Contains("@pRet"))
					{
						result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
						goto IL_01b2;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Helper.ProcessError(ex2);
					result = 50010;
					ProjectData.ClearProjectError();
					goto IL_01b2;
				}
				result = 0;
			}
			goto IL_01b2;
		}
		IL_01b2:
		return result;
	}

	int INVchIN6DAO.DeleteCTD(DataRow odr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DeleteCTD
		return this.DeleteCTD(odr);
	}

	public DataTable GetBoMByMa_vt(string aMa_cty, string aMa_Vt)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asINGetBom4Ph6";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_cty);
		_command.Parameters.AddWithValue("@pMa_vt", (object)aMa_Vt);
		return GetDataTable();
	}

	DataTable INVchIN6DAO.GetBoMByMa_vt(string aMa_cty, string aMa_Vt)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetBoMByMa_vt
		return this.GetBoMByMa_vt(aMa_cty, aMa_Vt);
	}

	public DataTable GetPrintDataSource(string aMa_Cty, string aStt_Rec)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInGetct64Print";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)aMa_Cty);
		_command.Parameters.AddWithValue("@pStt_Rec", (object)aStt_Rec);
		return GetDataTable();
	}

	DataTable INVchIN6DAO.GetPrintDataSource(string aMa_Cty, string aStt_Rec)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetPrintDataSource
		return this.GetPrintDataSource(aMa_Cty, aStt_Rec);
	}

	public bool SearchBOM(string aKeyPh, string aKeyCtM, string aKeyCtD, ref DataTable oTblPh, ref DataTable oTblCtM, ref DataTable oTblCtD)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asINFilt6";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pKeyPh", (object)aKeyPh);
		_command.Parameters.AddWithValue("@pKeyCtM", (object)aKeyCtM);
		_command.Parameters.AddWithValue("@pKeyCtD", (object)aKeyCtD);
		DataSet dataSet = GetDataSet();
		if (dataSet != null)
		{
			oTblPh = dataSet.Tables[0];
			oTblCtM = dataSet.Tables[1];
			oTblCtD = dataSet.Tables[2];
			dataSet.Dispose();
		}
		return (oTblPh != null && oTblCtM != null && oTblCtD != null && oTblPh.Rows.Count > 0 && oTblCtM.Rows.Count > 0 && oTblCtD.Rows.Count > 0) ? true : false;
	}

	bool INVchIN6DAO.SearchBOM(string aKeyPh, string aKeyCtM, string aKeyCtD, ref DataTable oTblPh, ref DataTable oTblCtM, ref DataTable oTblCtD)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SearchBOM
		return this.SearchBOM(aKeyPh, aKeyCtM, aKeyCtD, ref oTblPh, ref oTblCtM, ref oTblCtD);
	}

	public MsSqlINVchIN6DAO(VoucherInformation oVInfo)
		: base(oVInfo)
	{
	}
}
