using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlDashBoardDAO : MsSqlDAO, DashBoardDAO
{
	public DataTable GetParameter(string spName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDashGetParameter";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pSp_name", (object)spName);
		return GetDataTable();
	}

	DataTable DashBoardDAO.GetParameter(string spName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetParameter
		return this.GetParameter(spName);
	}

	public DataTable GetValueParameter(int DashID)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetDashParameter";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pDashID", (object)DashID);
		_command.Parameters.AddWithValue("@pUsername", (object)SystemInformations.UserName);
		return GetDataTable();
	}

	DataTable DashBoardDAO.GetValueParameter(int DashID)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetValueParameter
		return this.GetValueParameter(DashID);
	}

	public int InsValueParameter(int DashID, int Stt, string ParaName, string ParaValue)
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		_command.CommandText = "asInsDashParameter";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pDashID", (object)DashID);
		_command.Parameters.AddWithValue("@pUsername", (object)SystemInformations.UserName);
		_command.Parameters.AddWithValue("@pStt", (object)Stt);
		_command.Parameters.AddWithValue("@pParaname", (object)ParaName);
		_command.Parameters.AddWithValue("@pParavalue", (object)ParaValue);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int DashBoardDAO.InsValueParameter(int DashID, int Stt, string ParaName, string ParaValue)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsValueParameter
		return this.InsValueParameter(DashID, Stt, ParaName, ParaValue);
	}

	public int DelValueParameter(int DashID)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		_command.CommandText = "asDelDashParameter";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pDashID", (object)DashID);
		_command.Parameters.AddWithValue("@pUsername", (object)SystemInformations.UserName);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int DashBoardDAO.DelValueParameter(int DashID)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DelValueParameter
		return this.DelValueParameter(DashID);
	}

	public int GetMaxDashID()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetMaxDashID";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUsername", (object)SystemInformations.UserName);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pDashID";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int DashBoardDAO.GetMaxDashID()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetMaxDashID
		return this.GetMaxDashID();
	}

	public DataTable GetDashletType()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetDashletType";
		return GetDataTable();
	}

	DataTable DashBoardDAO.GetDashletType()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDashletType
		return this.GetDashletType();
	}

	public DataTable GetDashMenu(int DashID)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetDashMenu";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)SystemInformations.UserName);
		_command.Parameters.AddWithValue("@pDashId", (object)DashID);
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		return GetDataTable();
	}

	DataTable DashBoardDAO.GetDashMenu(int DashID)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDashMenu
		return this.GetDashMenu(DashID);
	}

	public DataTable GetDashFunction(string FunctionID)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetDashFunction";
		_command.Parameters.AddWithValue("@pFunctionID", (object)FunctionID);
		return GetDataTable();
	}

	DataTable DashBoardDAO.GetDashFunction(string FunctionID)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDashFunction
		return this.GetDashFunction(FunctionID);
	}

	public DataTable GetDashRight()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetDashRight";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)SystemInformations.UserName);
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		return GetDataTable();
	}

	DataTable DashBoardDAO.GetDashRight()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDashRight
		return this.GetDashRight();
	}

	public int SortMenuFrequence(string MenuIdSource, int SttTarget, int DashID)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSortDashFrequentlyFunction";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMenuIdSource", (object)MenuIdSource);
		_command.Parameters.AddWithValue("@pSttTarget", (object)SttTarget);
		_command.Parameters.AddWithValue("@pDashID", (object)DashID);
		_command.Parameters.AddWithValue("@pUserName", (object)SystemInformations.UserName);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int DashBoardDAO.SortMenuFrequence(string MenuIdSource, int SttTarget, int DashID)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SortMenuFrequence
		return this.SortMenuFrequence(MenuIdSource, SttTarget, DashID);
	}

	public DataTable GetMenuFrequence(int DashId, bool Space = false)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetDashFrequentlyFunction";
		_command.Parameters.AddWithValue("@pUserName", (object)SystemInformations.UserName);
		_command.Parameters.AddWithValue("@pDashID", (object)DashId);
		_command.Parameters.AddWithValue("@pSpace", (object)Space);
		_command.Parameters.AddWithValue("@pLanguage", (object)SystemInformations.CurrentCultureName);
		return GetDataTable();
	}

	DataTable DashBoardDAO.GetMenuFrequence(int DashId, bool Space = false)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetMenuFrequence
		return this.GetMenuFrequence(DashId, Space);
	}

	public int InsMenuFrequence(string MenuId, int DashId)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsDashFrequentlyFunction";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMenuId", (object)MenuId);
		_command.Parameters.AddWithValue("@pDashId", (object)DashId);
		_command.Parameters.AddWithValue("@pUserName", (object)SystemInformations.UserName);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int DashBoardDAO.InsMenuFrequence(string MenuId, int DashId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsMenuFrequence
		return this.InsMenuFrequence(MenuId, DashId);
	}

	public int UpdMenuFrequence(string MenuId, int DashId, bool Space)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpdDashFrequentlyFunction";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)SystemInformations.UserName);
		_command.Parameters.AddWithValue("@pMenuId", (object)MenuId);
		_command.Parameters.AddWithValue("@pDashId", (object)DashId);
		_command.Parameters.AddWithValue("@pSpace", (object)Space);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int DashBoardDAO.UpdMenuFrequence(string MenuId, int DashId, bool Space)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdMenuFrequence
		return this.UpdMenuFrequence(MenuId, DashId, Space);
	}

	public int DelMenuFrequence(string MenuId, int DashId)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDelDashFrequentlyFunction";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMenuId", (object)MenuId);
		_command.Parameters.AddWithValue("@pDashId", (object)DashId);
		_command.Parameters.AddWithValue("@pUserName", (object)SystemInformations.UserName);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int DashBoardDAO.DelMenuFrequence(string MenuId, int DashId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DelMenuFrequence
		return this.DelMenuFrequence(MenuId, DashId);
	}

	public DataTable GetMaxDashPoint(int Location)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetMaxDashPoint";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)SystemInformations.UserName);
		_command.Parameters.AddWithValue("@pLocation", (object)Location);
		return GetDataTable();
	}

	DataTable DashBoardDAO.GetMaxDashPoint(int Location)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetMaxDashPoint
		return this.GetMaxDashPoint(Location);
	}

	public DataTable ProcessSPDashBoard(params object[] para)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = Conversions.ToString(para[0]);
		_command.Parameters.Clear();
		int num = Information.UBound((Array)para, 1);
		int num2 = num;
		checked
		{
			for (int i = 1; i <= num2; i += 2)
			{
				_command.Parameters.AddWithValue(Conversions.ToString(para[i]), RuntimeHelpers.GetObjectValue(para[i + 1]));
			}
			return GetDataTable();
		}
	}

	DataTable DashBoardDAO.ProcessSPDashBoard(params object[] para)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ProcessSPDashBoard
		return this.ProcessSPDashBoard(para);
	}

	public DataTable GetDashForm(string DashID = "")
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asGetDashForm";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)SystemInformations.UserName);
		_command.Parameters.AddWithValue("@pDashID", (object)DashID);
		return GetDataTable();
	}

	DataTable DashBoardDAO.GetDashForm(string DashID = "")
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDashForm
		return this.GetDashForm(DashID);
	}

	public int InsDashForm(string Title, int Location, string Format, string FunctionId, int X, int Y, int H, int W, string Type, ref int DashID)
	{
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asInsDashForm";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUsername", (object)SystemInformations.UserName);
		_command.Parameters.AddWithValue("@pTitle", (object)Title);
		_command.Parameters.AddWithValue("@pFunctionId", (object)FunctionId);
		_command.Parameters.AddWithValue("@pFormat", (object)Format);
		_command.Parameters.AddWithValue("@pLocation", (object)Location);
		_command.Parameters.AddWithValue("@pX", (object)X);
		_command.Parameters.AddWithValue("@pY", (object)Y);
		_command.Parameters.AddWithValue("@pH", (object)H);
		_command.Parameters.AddWithValue("@pW", (object)W);
		_command.Parameters.AddWithValue("@pType", (object)Type);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pDashID";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		SqlParameter val3 = new SqlParameter();
		SqlParameter val4 = val3;
		val4.ParameterName = "@pRet";
		val4.DbType = DbType.Int32;
		val4.Direction = ParameterDirection.Output;
		val4 = null;
		_command.Parameters.Add(val);
		_command.Parameters.Add(val3);
		ExecuteNonQuery();
		DashID = Conversions.ToInteger(val.Value);
		return Conversions.ToInteger(val3.Value);
	}

	int DashBoardDAO.InsDashForm(string Title, int Location, string Format, string FunctionId, int X, int Y, int H, int W, string Type, ref int DashID)
	{
		//ILSpy generated this explicit interface implementation from .override directive in InsDashForm
		return this.InsDashForm(Title, Location, Format, FunctionId, X, Y, H, W, Type, ref DashID);
	}

	public int UpdDashForm(int Location, string Format, string Title, string DashId, int X, int Y, int H, int W, bool IsMenu = false)
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpdDashForm";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pDashId", (object)DashId);
		_command.Parameters.AddWithValue("@pUserName", (object)SystemInformations.UserName);
		_command.Parameters.AddWithValue("@pTitle", (object)Title);
		_command.Parameters.AddWithValue("@pFormat", (object)Format);
		_command.Parameters.AddWithValue("@pLocation", (object)Location);
		_command.Parameters.AddWithValue("@pX", (object)X);
		_command.Parameters.AddWithValue("@pY", (object)Y);
		_command.Parameters.AddWithValue("@pH", (object)H);
		_command.Parameters.AddWithValue("@pW", (object)W);
		_command.Parameters.AddWithValue("@pIsMenu", (object)IsMenu);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int DashBoardDAO.UpdDashForm(int Location, string Format, string Title, string DashId, int X, int Y, int H, int W, bool IsMenu = false)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdDashForm
		return this.UpdDashForm(Location, Format, Title, DashId, X, Y, H, W, IsMenu);
	}

	public int DelDashForm(string DashId)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asDelDashForm";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pDashid", (object)DashId);
		_command.Parameters.AddWithValue("@pUserName", (object)SystemInformations.UserName);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int DashBoardDAO.DelDashForm(string DashId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DelDashForm
		return this.DelDashForm(DashId);
	}

	public int UpdDashLocation(int DashIdSrc, int LocationTar, int xTar, int YTar, int HSrc, int WSrc)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asUpdDashLocation";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pUserName", (object)SystemInformations.UserName);
		_command.Parameters.AddWithValue("@pDashIdSrc", (object)DashIdSrc);
		_command.Parameters.AddWithValue("@pLocationTar", (object)LocationTar);
		_command.Parameters.AddWithValue("@pXTar", (object)xTar);
		_command.Parameters.AddWithValue("@pYTar", (object)YTar);
		_command.Parameters.AddWithValue("@pHSrc", (object)HSrc);
		_command.Parameters.AddWithValue("@pWSrc", (object)WSrc);
		SqlParameter val = new SqlParameter();
		SqlParameter val2 = val;
		val2.ParameterName = "@pRet";
		val2.DbType = DbType.Int32;
		val2.Direction = ParameterDirection.Output;
		val2 = null;
		_command.Parameters.Add(val);
		ExecuteNonQuery();
		return Conversions.ToInteger(val.Value);
	}

	int DashBoardDAO.UpdDashLocation(int DashIdSrc, int LocationTar, int xTar, int YTar, int HSrc, int WSrc)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdDashLocation
		return this.UpdDashLocation(DashIdSrc, LocationTar, xTar, YTar, HSrc, WSrc);
	}
}
