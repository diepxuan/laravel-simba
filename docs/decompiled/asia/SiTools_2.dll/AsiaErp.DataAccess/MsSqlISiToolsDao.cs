using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlISiToolsDao : MsSqlDAO, ISiToolsDao
{
	[DebuggerNonUserCode]
	public MsSqlISiToolsDao()
	{
	}

	public DataTable SiGetCompanyInfo()
	{
		return GetDataTable("asGetCompanyInfo");
	}

	DataTable ISiToolsDao.SiGetCompanyInfo()
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiGetCompanyInfo
		return this.SiGetCompanyInfo();
	}

	public int UpdateCompanyInfo(DataRow dr)
	{
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSiUpdcompany";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ma_cty"]), isNum: false)));
		_command.Parameters.AddWithValue("@pTen_tcty", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ten_tcty"]), isNum: false)));
		_command.Parameters.AddWithValue("@pTen_cty", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ten_cty"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDia_chi", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Dia_chi"]), isNum: false)));
		_command.Parameters.AddWithValue("@pGiam_doc", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Giam_doc"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKtt", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ktt"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMa_thue", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ma_thue"]), isNum: false)));
		_command.Parameters.AddWithValue("@pTel", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Tel"]), isNum: false)));
		_command.Parameters.AddWithValue("@pFax", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Fax"]), isNum: false)));
		_command.Parameters.AddWithValue("@pEmail", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Email"]), isNum: false)));
		_command.Parameters.AddWithValue("@pTen_nh", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ten_nh"]), isNum: false)));
		_command.Parameters.AddWithValue("@pSo_tk_nh", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["So_tk_nh"]), isNum: false)));
		_command.Parameters.AddWithValue("@pTinh_tp_nh", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Tinh_tp_nh"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDbname", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Dbname"]), isNum: false)));
		_command.Parameters.AddWithValue("@pActive", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Active"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_039c;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_039c;
		IL_039c:
		return result;
	}

	int ISiToolsDao.UpdateCompanyInfo(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdateCompanyInfo
		return this.UpdateCompanyInfo(dr);
	}

	public int CreateNewCompanyData(string pMa_cty_cu, string pMa_cty_moi)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asCreateCompany";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty_cu", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(pMa_cty_cu, isNum: false)));
		_command.Parameters.AddWithValue("@pMa_cty_moi", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(pMa_cty_moi, isNum: false)));
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_00a4;
		}
		result = 0;
		goto IL_00a4;
		IL_00a4:
		return result;
	}

	int ISiToolsDao.CreateNewCompanyData(string pMa_cty_cu, string pMa_cty_moi)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CreateNewCompanyData
		return this.CreateNewCompanyData(pMa_cty_cu, pMa_cty_moi);
	}

	public int CreateNewCompanySys(string pMa_cty_cu, string pMa_cty_moi)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asCreateCompanySys";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty_cu", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(pMa_cty_cu, isNum: false)));
		_command.Parameters.AddWithValue("@pMa_cty_moi", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(pMa_cty_moi, isNum: false)));
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_00a4;
		}
		result = 0;
		goto IL_00a4;
		IL_00a4:
		return result;
	}

	int ISiToolsDao.CreateNewCompanySys(string pMa_cty_cu, string pMa_cty_moi)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CreateNewCompanySys
		return this.CreateNewCompanySys(pMa_cty_cu, pMa_cty_moi);
	}

	public DataSet SiGetAllMenu()
	{
		return GetDataSet("asSiGetAllMenuForTool");
	}

	DataSet ISiToolsDao.SiGetAllMenu()
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiGetAllMenu
		return this.SiGetAllMenu();
	}

	public int SiUpdateMenu(DataRow dr)
	{
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSiUpdmenu";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pStt", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Stt"]), isNum: false)));
		_command.Parameters.AddWithValue("@pModuleid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Moduleid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pBar", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Bar"]), isNum: false)));
		_command.Parameters.AddWithValue("@pBaren_us", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Baren-US"]), isNum: false)));
		_command.Parameters.AddWithValue("@pShort_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Short_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDllname", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Dllname"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCommand", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Command"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCode_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Code_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pReport", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Report"]), isNum: false)));
		_command.Parameters.AddWithValue("@pBasicright", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Basicright"]), isNum: false)));
		_command.Parameters.AddWithValue("@pForm", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Form"]), isNum: false)));
		_command.Parameters.AddWithValue("@pOpt", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Opt"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar1", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par1"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar2", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par2"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar3", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par3"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar4", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par4"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar5", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par5"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar6", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par6"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar7", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par7"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar8", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par8"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPicture1", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Picture1"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPicture2", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Picture2"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDeveloper", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Developer"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMaintainer", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Maintainer"]), isNum: false)));
		_command.Parameters.AddWithValue("@pUsed", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Used"]), isNum: false)));
		_command.Parameters.AddWithValue("@pActive", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Active"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Menuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_Menuid"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_0619;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_0619;
		IL_0619:
		return result;
	}

	int ISiToolsDao.SiUpdateMenu(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiUpdateMenu
		return this.SiUpdateMenu(dr);
	}

	public int SiInsertMenu(DataRow dr)
	{
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSiInsMenu";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pStt", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Stt"]), isNum: false)));
		_command.Parameters.AddWithValue("@pModuleid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Moduleid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pBar", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Bar"]), isNum: false)));
		_command.Parameters.AddWithValue("@pBaren_us", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Baren-us"]), isNum: false)));
		_command.Parameters.AddWithValue("@pShort_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Short_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDllname", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Dllname"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCommand", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Command"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCode_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Code_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pReport", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Report"]), isNum: false)));
		_command.Parameters.AddWithValue("@pBasicright", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Basicright"]), isNum: false)));
		_command.Parameters.AddWithValue("@pForm", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Form"]), isNum: false)));
		_command.Parameters.AddWithValue("@pOpt", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Opt"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar1", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par1"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar2", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par2"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar3", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par3"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar4", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par4"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar5", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par5"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar6", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par6"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar7", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par7"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPar8", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Par8"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPicture1", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Picture1"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPicture2", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Picture2"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDeveloper", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Developer"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMaintainer", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Maintainer"]), isNum: false)));
		_command.Parameters.AddWithValue("@pUsed", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Used"]), isNum: false)));
		_command.Parameters.AddWithValue("@pActive", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Active"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_05e8;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_05e8;
		IL_05e8:
		return result;
	}

	int ISiToolsDao.SiInsertMenu(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiInsertMenu
		return this.SiInsertMenu(dr);
	}

	public int SiDelMenu(DataRow dr)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSiDelMenu";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Menuid"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_00ee;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_00ee;
		IL_00ee:
		return result;
	}

	int ISiToolsDao.SiDelMenu(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiDelMenu
		return this.SiDelMenu(dr);
	}

	public DataSet SiGetAllSys()
	{
		return GetDataSet("asSiGetAllSys");
	}

	DataSet ISiToolsDao.SiGetAllSys()
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiGetAllSys
		return this.SiGetAllSys();
	}

	public int SiInsertDic(DataRow dr)
	{
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsDictionaryInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pCode_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Code_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPk", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Pk"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCode_fname", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Code_fname"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCode_length", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Code_length"]), isNum: false)));
		_command.Parameters.AddWithValue("@pName_fname", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Name_fname"]), isNum: false)));
		_command.Parameters.AddWithValue("@pTable_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Table_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pLookup_when_invalid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Lookup_when_invalid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pAllow_merge_code", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Allow_merge_code"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDllname", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Dllname"]), isNum: false)));
		_command.Parameters.AddWithValue("@pView_class_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["View_class_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pEdit_class_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Edit_class_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDescription", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Description"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCarry_field_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Carry_field_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDefault_sort", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Default_sort"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCopy_vaora", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Copy_vaora"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_03cd;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_03cd;
		IL_03cd:
		return result;
	}

	int ISiToolsDao.SiInsertDic(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiInsertDic
		return this.SiInsertDic(dr);
	}

	public int SiUpdateDic(DataRow dr)
	{
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpdDictionaryInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pCode_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Code_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPk", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Pk"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCode_fname", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Code_fname"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCode_length", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Code_length"]), isNum: false)));
		_command.Parameters.AddWithValue("@pName_fname", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Name_fname"]), isNum: false)));
		_command.Parameters.AddWithValue("@pTable_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Table_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pLookup_when_invalid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Lookup_when_invalid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pAllow_merge_code", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Allow_merge_code"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDllname", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Dllname"]), isNum: false)));
		_command.Parameters.AddWithValue("@pView_class_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["View_class_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pEdit_class_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Edit_class_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDescription", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Description"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCarry_field_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Carry_field_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDefault_sort", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Default_sort"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCopy_vaora", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Copy_vaora"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Code_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_Code_name"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_03fe;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_03fe;
		IL_03fe:
		return result;
	}

	int ISiToolsDao.SiUpdateDic(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiUpdateDic
		return this.SiUpdateDic(dr);
	}

	public int SiDelDic(DataRow dr)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDelDictionaryInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pCode_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Code_name"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_00ee;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_00ee;
		IL_00ee:
		return result;
	}

	int ISiToolsDao.SiDelDic(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiDelDic
		return this.SiDelDic(dr);
	}

	public int SiInsertDicRex(DataRow dr)
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsDictionaryResx";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pCode_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Code_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pLanguage", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Language"]), isNum: false)));
		_command.Parameters.AddWithValue("@pFormated_col_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Formated_col_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pViewform_size", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Viewform_size"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_0181;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_0181;
		IL_0181:
		return result;
	}

	int ISiToolsDao.SiInsertDicRex(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiInsertDicRex
		return this.SiInsertDicRex(dr);
	}

	public int SiUpdateDicRex(DataRow dr)
	{
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUdpDictionaryResx";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pCode_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Code_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pLanguage", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Language"]), isNum: false)));
		_command.Parameters.AddWithValue("@pFormated_col_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Formated_col_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pViewform_size", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Viewform_size"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Code_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_Code_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Language", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_Language"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_01e3;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_01e3;
		IL_01e3:
		return result;
	}

	int ISiToolsDao.SiUpdateDicRex(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiUpdateDicRex
		return this.SiUpdateDicRex(dr);
	}

	public int SiDelDicRex(DataRow dr)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDelDictionaryResx";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pCode_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Code_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pLanguage", RuntimeHelpers.GetObjectValue(dr["Language"]));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_0114;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_0114;
		IL_0114:
		return result;
	}

	int ISiToolsDao.SiDelDicRex(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiDelDicRex
		return this.SiDelDicRex(dr);
	}

	public int SiInsertReport(DataRow dr)
	{
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsreportinfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMa_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ma_mau"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCtlclass", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ctlclass"]), isNum: false)));
		_command.Parameters.AddWithValue("@pSpname", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Spname"]), isNum: false)));
		_command.Parameters.AddWithValue("@pRptname", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Rptname"]), isNum: false)));
		_command.Parameters.AddWithValue("@pIsdefault", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Isdefault"]), isNum: false)));
		_command.Parameters.AddWithValue("@pBang_chu", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Bang_chu"]), isNum: false)));
		_command.Parameters.AddWithValue("@pBang_chu0", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Bang_chu0"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDynReportFields", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["DynReportFields"]), isNum: false)));
		_command.Parameters.AddWithValue("@pHasNT", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["HasNT"]), isNum: true)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_02a7;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_02a7;
		IL_02a7:
		return result;
	}

	int ISiToolsDao.SiInsertReport(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiInsertReport
		return this.SiInsertReport(dr);
	}

	public int SiUpdateReport(DataRow dr)
	{
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpdreportInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMa_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ma_mau"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCtlclass", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ctlclass"]), isNum: false)));
		_command.Parameters.AddWithValue("@pSpname", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Spname"]), isNum: false)));
		_command.Parameters.AddWithValue("@pRptname", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Rptname"]), isNum: false)));
		_command.Parameters.AddWithValue("@pIsdefault", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Isdefault"]), isNum: false)));
		_command.Parameters.AddWithValue("@pBang_chu", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Bang_chu"]), isNum: false)));
		_command.Parameters.AddWithValue("@pBang_chu0", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Bang_chu0"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Menuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Ma_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_Ma_mau"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDynReportFields", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["DynReportFields"]), isNum: false)));
		_command.Parameters.AddWithValue("@pHasNT", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["HasNT"]), isNum: true)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_0309;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_0309;
		IL_0309:
		return result;
	}

	int ISiToolsDao.SiUpdateReport(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiUpdateReport
		return this.SiUpdateReport(dr);
	}

	public int SiDelReport(DataRow dr)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDelreportinfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMa_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ma_mau"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_011f;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_011f;
		IL_011f:
		return result;
	}

	int ISiToolsDao.SiDelReport(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiDelReport
		return this.SiDelReport(dr);
	}

	public int SiInsertReportDrillDown(DataRow dr)
	{
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsreportDrilldownInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pma_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["ma_mau"]), isNum: false)));
		_command.Parameters.AddWithValue("@pmenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPress_key_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["press_key_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDrilldown_menuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Drilldown_menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDrilldown_menuid1", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Drilldown_menuid1"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDrilldown_menuid2", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Drilldown_menuid2"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDrilldown_menuid3", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Drilldown_menuid3"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDrilldown_menuid4", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Drilldown_menuid4"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDllName", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["dllName"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCommand", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["command"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDescription", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["description"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_02d8;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_02d8;
		IL_02d8:
		return result;
	}

	int ISiToolsDao.SiInsertReportDrillDown(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiInsertReportDrillDown
		return this.SiInsertReportDrillDown(dr);
	}

	public int SiUpdateReportDrillDown(DataRow dr)
	{
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpdreportDrilldownInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pma_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["ma_mau"]), isNum: false)));
		_command.Parameters.AddWithValue("@pmenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPress_key_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["press_key_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDrilldown_menuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Drilldown_menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDrilldown_menuid1", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Drilldown_menuid1"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDrilldown_menuid2", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Drilldown_menuid2"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDrilldown_menuid3", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Drilldown_menuid3"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDrilldown_menuid4", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Drilldown_menuid4"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDllName", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["dllName"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCommand", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["command"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDescription", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["description"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_ma_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_ma_mau"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_menuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Press_key_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_press_key_name"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_036b;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_036b;
		IL_036b:
		return result;
	}

	int ISiToolsDao.SiUpdateReportDrillDown(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiUpdateReportDrillDown
		return this.SiUpdateReportDrillDown(dr);
	}

	public int SiDelReportDrillDown(DataRow dr)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDelreportDrilldownInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pma_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["ma_mau"]), isNum: false)));
		_command.Parameters.AddWithValue("@pmenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPress_key_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["press_key_name"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_0150;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_0150;
		IL_0150:
		return result;
	}

	int ISiToolsDao.SiDelReportDrillDown(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiDelReportDrillDown
		return this.SiDelReportDrillDown(dr);
	}

	public int SiInsertReportRex(DataRow dr)
	{
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsreportResx";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMa_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ma_mau"]), isNum: false)));
		_command.Parameters.AddWithValue("@pLanguage", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Language"]), isNum: false)));
		_command.Parameters.AddWithValue("@pTen_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ten_mau"]), isNum: false)));
		_command.Parameters.AddWithValue("@pTitle", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Title"]), isNum: false)));
		_command.Parameters.AddWithValue("@pFormated_col_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Formated_col_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCt_formated_col_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ct_formated_col_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pFormated_col_list_nt", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Formated_col_list_nt"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCt_formated_col_list_nt", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ct_formated_col_list_nt"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDescription", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Description"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMau_so_qd15", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Mau_so_qd15"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMau_so_qd48", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Mau_so_qd48"]), isNum: false)));
		_command.Parameters.AddWithValue("@pAuto_format", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Auto_format"]), isNum: false)));
		_command.Parameters.AddWithValue("@pHide_col_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Hide_col_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pHide_col_list_nt", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Hide_col_list_nt"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_039c;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_039c;
		IL_039c:
		return result;
	}

	int ISiToolsDao.SiInsertReportRex(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiInsertReportRex
		return this.SiInsertReportRex(dr);
	}

	public int SiUpdateReportRex(DataRow dr)
	{
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpdreportresx";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMa_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ma_mau"]), isNum: false)));
		_command.Parameters.AddWithValue("@pLanguage", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Language"]), isNum: false)));
		_command.Parameters.AddWithValue("@pTen_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ten_mau"]), isNum: false)));
		_command.Parameters.AddWithValue("@pTitle", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Title"]), isNum: false)));
		_command.Parameters.AddWithValue("@pFormated_col_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Formated_col_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCt_formated_col_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ct_formated_col_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pFormated_col_list_nt", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Formated_col_list_nt"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCt_formated_col_list_nt", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ct_formated_col_list_nt"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDescription", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Description"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMau_so_qd15", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Mau_so_qd15"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMau_so_qd48", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Mau_so_qd48"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Menuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Ma_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_Ma_mau"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Language", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_Language"]), isNum: false)));
		_command.Parameters.AddWithValue("@pAuto_format", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Auto_format"]), isNum: false)));
		_command.Parameters.AddWithValue("@pHide_col_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Hide_col_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pHide_col_list_nt", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Hide_col_list_nt"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_042f;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_042f;
		IL_042f:
		return result;
	}

	int ISiToolsDao.SiUpdateReportRex(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiUpdateReportRex
		return this.SiUpdateReportRex(dr);
	}

	public int SiDelReportRex(DataRow dr)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDelreportresx";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMa_mau", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ma_mau"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_011f;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_011f;
		IL_011f:
		return result;
	}

	int ISiToolsDao.SiDelReportRex(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiDelReportRex
		return this.SiDelReportRex(dr);
	}

	public int SiInsertDAO(DataRow dr)
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsdaoinfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pTable_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Table_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pGet_sp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Get_sp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pIns_sp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ins_sp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pUpd_sp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Upd_sp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDel_sp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Del_sp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pSch_sp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Sch_sp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pChg_sp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Chg_sp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDescription", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Description"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_0245;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_0245;
		IL_0245:
		return result;
	}

	int ISiToolsDao.SiInsertDAO(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiInsertDAO
		return this.SiInsertDAO(dr);
	}

	public int SiUpdateDAO(DataRow dr)
	{
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpddaoinfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pTable_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Table_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pGet_sp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Get_sp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pIns_sp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ins_sp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pUpd_sp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Upd_sp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDel_sp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Del_sp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pSch_sp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Sch_sp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pChg_sp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Chg_sp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDescription", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Description"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Table_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_Table_name"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_0276;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_0276;
		IL_0276:
		return result;
	}

	int ISiToolsDao.SiUpdateDAO(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiUpdateDAO
		return this.SiUpdateDAO(dr);
	}

	public int SiDelDAO(DataRow dr)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDeldaoinfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pTable_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Table_name"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_00ee;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_00ee;
		IL_00ee:
		return result;
	}

	int ISiToolsDao.SiDelDAO(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiDelDAO
		return this.SiDelDAO(dr);
	}

	public int SiInsertVoucher(DataRow dr)
	{
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsVoucherInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pVoucher_code", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Voucher_code"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPh_table_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ph_table_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCt_table_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ct_table_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCp_table_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Cp_table_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPh_extra_edit_cotrol_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ph_extra_edit_cotrol_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pSearch_class_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Search_class_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pView_class_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["View_class_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPrint_class_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Print_class_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMa_nt_default", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ma_nt_default"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPh_carry_field_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ph_carry_field_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCt_carry_field_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ct_carry_field_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPh_print_field_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ph_print_field_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pNumber_of_copy", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Number_of_copy"]), isNum: false)));
		_command.Parameters.AddWithValue("@pHas_cp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Has_cp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pHas_tain", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Has_tain"]), isNum: false)));
		_command.Parameters.AddWithValue("@pHas_taout", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Has_taout"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCopy_enabled", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Copy_enabled"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCopy_vaora", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Copy_vaora"]), isNum: false)));
		_command.Parameters.AddWithValue("@pNxt", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Nxt"]), isNum: false)));
		_command.Parameters.AddWithValue("@pRow_per_page", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Row_per_page"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDescription", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Description"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_04f3;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_04f3;
		IL_04f3:
		return result;
	}

	int ISiToolsDao.SiInsertVoucher(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiInsertVoucher
		return this.SiInsertVoucher(dr);
	}

	public int SiUpdateVoucher(DataRow dr)
	{
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpdVoucherInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pVoucher_code", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Voucher_code"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPh_table_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ph_table_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCt_table_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ct_table_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCp_table_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Cp_table_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMenuid", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Menuid"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPh_extra_edit_cotrol_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ph_extra_edit_cotrol_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pSearch_class_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Search_class_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pView_class_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["View_class_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPrint_class_name", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Print_class_name"]), isNum: false)));
		_command.Parameters.AddWithValue("@pMa_nt_default", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ma_nt_default"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPh_carry_field_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ph_carry_field_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCt_carry_field_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ct_carry_field_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPh_print_field_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ph_print_field_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pNumber_of_copy", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Number_of_copy"]), isNum: false)));
		_command.Parameters.AddWithValue("@pHas_cp", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Has_cp"]), isNum: false)));
		_command.Parameters.AddWithValue("@pHas_tain", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Has_tain"]), isNum: false)));
		_command.Parameters.AddWithValue("@pHas_taout", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Has_taout"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCopy_enabled", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Copy_enabled"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCopy_vaora", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Copy_vaora"]), isNum: false)));
		_command.Parameters.AddWithValue("@pNxt", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Nxt"]), isNum: false)));
		_command.Parameters.AddWithValue("@pRow_per_page", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Row_per_page"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDescription", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Description"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Voucher_code", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_Voucher_code"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_0524;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_0524;
		IL_0524:
		return result;
	}

	int ISiToolsDao.SiUpdateVoucher(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiUpdateVoucher
		return this.SiUpdateVoucher(dr);
	}

	public int SiDelVoucher(DataRow dr)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDelVoucherInfo";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pVoucher_code", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Voucher_code"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_00ee;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_00ee;
		IL_00ee:
		return result;
	}

	int ISiToolsDao.SiDelVoucher(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiDelVoucher
		return this.SiDelVoucher(dr);
	}

	public int SiInsertVoucherRex(DataRow dr)
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsVoucherResx";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pVoucher_code", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Voucher_code"]), isNum: false)));
		_command.Parameters.AddWithValue("@pLanguage", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Language"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPh_formated_col_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ph_formated_col_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCt_formated_col_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ct_formated_col_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDescription", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Description"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_01b2;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_01b2;
		IL_01b2:
		return result;
	}

	int ISiToolsDao.SiInsertVoucherRex(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiInsertVoucherRex
		return this.SiInsertVoucherRex(dr);
	}

	public int SiUpdateVoucherRex(DataRow dr)
	{
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUdpVoucherResx";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pVoucher_code", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Voucher_code"]), isNum: false)));
		_command.Parameters.AddWithValue("@pLanguage", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Language"]), isNum: false)));
		_command.Parameters.AddWithValue("@pPh_formated_col_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ph_formated_col_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pCt_formated_col_list", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Ct_formated_col_list"]), isNum: false)));
		_command.Parameters.AddWithValue("@pDescription", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Description"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Voucher_code", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_Voucher_code"]), isNum: false)));
		_command.Parameters.AddWithValue("@pKey_Language", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Key_Language"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_0214;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_0214;
		IL_0214:
		return result;
	}

	int ISiToolsDao.SiUpdateVoucherRex(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiUpdateVoucherRex
		return this.SiUpdateVoucherRex(dr);
	}

	public int SiDelVoucherRex(DataRow dr)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDelVoucherResx";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pVoucher_code", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Voucher_code"]), isNum: false)));
		_command.Parameters.AddWithValue("@pLanguage", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dr["Language"]), isNum: false)));
		SqlParameter val = new SqlParameter();
		val.ParameterName = "@pRet";
		val.DbType = DbType.Double;
		val.Direction = ParameterDirection.Output;
		_command.Parameters.Add(val);
		int result;
		try
		{
			ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = 1;
			ProjectData.ClearProjectError();
			goto IL_011f;
		}
		result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
		goto IL_011f;
		IL_011f:
		return result;
	}

	int ISiToolsDao.SiDelVoucherRex(DataRow dr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiDelVoucherRex
		return this.SiDelVoucherRex(dr);
	}

	public string Gen_FielListDynReport(string SP_Name)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		_command.CommandText = "asDynGetControl4Form";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@sp_name", (object)SP_Name);
		string value = "";
		SqlParameter val = new SqlParameter();
		val.Direction = ParameterDirection.Output;
		val.ParameterName = "@str";
		val.DbType = DbType.String;
		val.Size = 500;
		val.Value = value;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@str"].Value), isNum: false));
	}

	string ISiToolsDao.Gen_FielListDynReport(string SP_Name)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Gen_FielListDynReport
		return this.Gen_FielListDynReport(SP_Name);
	}

	public int DynInsertUpdateDeleteData(string pXmlData, string pTableName, string pMode)
	{
		_command.CommandText = "asSiDynInsertUpdateDeleteData";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pXmlData", (object)pXmlData);
		_command.Parameters.AddWithValue("@pTable_name", (object)pTableName);
		_command.Parameters.AddWithValue("@pMode", (object)pMode);
		return ExecuteNonQuery();
	}

	int ISiToolsDao.DynInsertUpdateDeleteData(string pXmlData, string pTableName, string pMode)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DynInsertUpdateDeleteData
		return this.DynInsertUpdateDeleteData(pXmlData, pTableName, pMode);
	}

	public DataSet SiGetAllProcPara()
	{
		return GetDataSet("asSiGetExcProc");
	}

	DataSet ISiToolsDao.SiGetAllProcPara()
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiGetAllProcPara
		return this.SiGetAllProcPara();
	}

	public DataTable SiExcSP_IsReSult(string pStrCmd)
	{
		return GetDataTable("asSiExcSP", pStrCmd);
	}

	DataTable ISiToolsDao.SiExcSP_IsReSult(string pStrCmd)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiExcSP_IsReSult
		return this.SiExcSP_IsReSult(pStrCmd);
	}

	public DataTable SiExcSP_NoReSult(string pStrCmd)
	{
		int num = 0;
		string value = "";
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSiExcSP";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pStrCmd", RuntimeHelpers.GetObjectValue(Helper.Repl_Null(pStrCmd, isNum: false)));
		try
		{
			ExecuteNonQuery();
			num = 0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			value = ex2.ToString();
			num = 1;
			ProjectData.ClearProjectError();
		}
		DataTable dataTable = new DataTable();
		DataColumn column = new DataColumn("Result", Type.GetType("System.String"));
		dataTable.Columns.Add(column);
		DataRow dataRow = dataTable.NewRow();
		if (num == 0)
		{
			dataRow["Result"] = "IS_OKE";
		}
		else
		{
			dataRow["Result"] = value;
		}
		dataTable.Rows.Add(dataRow);
		return dataTable;
	}

	DataTable ISiToolsDao.SiExcSP_NoReSult(string pStrCmd)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SiExcSP_NoReSult
		return this.SiExcSP_NoReSult(pStrCmd);
	}
}
