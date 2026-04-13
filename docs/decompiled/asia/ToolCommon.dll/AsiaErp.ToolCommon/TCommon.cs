using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.ToolCommon;

[StandardModule]
public sealed class TCommon
{
	private static Hashtable _hstbl;

	public static object Session
	{
		get
		{
			if (!_hstbl.ContainsKey(RuntimeHelpers.GetObjectValue(key)))
			{
				return null;
			}
			return _hstbl[RuntimeHelpers.GetObjectValue(key)];
		}
		set
		{
			if (_hstbl.ContainsKey(RuntimeHelpers.GetObjectValue(key)))
			{
				_hstbl[RuntimeHelpers.GetObjectValue(key)] = RuntimeHelpers.GetObjectValue(value);
			}
			else
			{
				_hstbl.Add(RuntimeHelpers.GetObjectValue(key), RuntimeHelpers.GetObjectValue(value));
			}
		}
	}

	static TCommon()
	{
		_hstbl = new Hashtable();
		LoadDefautConnect();
	}

	private static void LoadDefautConnect()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ExeConfigurationFileMap val = new ExeConfigurationFileMap();
		val.ExeConfigFilename = Application.StartupPath + "\\Startup.exe.config";
		if (File.Exists(val.ExeConfigFilename))
		{
			Configuration val2 = ConfigurationManager.OpenMappedExeConfiguration(val, (ConfigurationUserLevel)0);
			TCommon.set_Session((object)"SqlServerName", (object)Helper.Decrypted(val2.AppSettings.Settings["SqlServerName"].Value, 125));
			TCommon.set_Session((object)"DaoType", (object)val2.AppSettings.Settings["DaoType"].Value);
			TCommon.set_Session((object)"AuthenticationType", (object)val2.AppSettings.Settings["AuthenticationType"].Value);
			if (Operators.ConditionalCompareObjectEqual(TCommon.get_Session((object)"DaoType"), (object)"WIN", false))
			{
				TCommon.set_Session((object)"SqlUserName", (object)"");
				TCommon.set_Session((object)"SqlPassword", (object)"************");
			}
			else
			{
				TCommon.set_Session((object)"SqlUserName", (object)Helper.Decrypted(val2.AppSettings.Settings["SqlUserName"].Value, 126));
				TCommon.set_Session((object)"SqlPassword", (object)Helper.Decrypted(val2.AppSettings.Settings["SqlPassword"].Value, 127));
			}
			TCommon.set_Session((object)"SqlSysDBName", (object)Helper.Decrypted(val2.AppSettings.Settings["SqlSysDBName"].Value, 125));
			TCommon.set_Session((object)"SqlDataDBName", (object)Helper.Decrypted(val2.AppSettings.Settings["SqlDataDBName"].Value, 125));
			if (Operators.ConditionalCompareObjectEqual(TCommon.get_Session((object)"AuthenticationType"), (object)"SQL", false))
			{
				TCommon.set_Session((object)"sDataCnnString", (object)string.Format("Server={0};Uid={1};Pwd={2};Database={3};Integrated Security=no", RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlServerName")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlUserName")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlPassword")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlDataDBName"))));
				TCommon.set_Session((object)"sSysCnnString", (object)string.Format("Server={0};Uid={1};Pwd={2};Database={3};Integrated Security=no", RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlServerName")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlUserName")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlPassword")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlSysDBName"))));
			}
			else
			{
				TCommon.set_Session((object)"sDataCnnString", (object)string.Format("Server={0};Database={1};Integrated Security=Yes", RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlServerName")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlDataDBName"))));
				TCommon.set_Session((object)"sSysCnnString", (object)string.Format("Server={0};Database={1};Integrated Security=Yes", RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlServerName")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlSysDBName"))));
			}
		}
	}

	public static string GetConnection()
	{
		string text = Conversions.ToString(TCommon.get_Session((object)"AuthenticationType"));
		if (Operators.CompareString(text, "SQL", false) == 0)
		{
			return string.Format("Server={0};Uid={1};Pwd={2};Database={3};Integrated Security=no", RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlServerName")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlUserName")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlPassword")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlDataDBName")));
		}
		return string.Format("Server={0};Database={1};Integrated Security=Yes", RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlServerName")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlDataDBName")));
	}

	public static SqlConnection CreateConnection(bool isSys = false)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		SqlConnection val = ((!isSys) ? new SqlConnection(Conversions.ToString(TCommon.get_Session((object)"sDataCnnString"))) : new SqlConnection(Conversions.ToString(TCommon.get_Session((object)"sSysCnnString"))));
		val.Open();
		return val;
	}

	public static bool CheckConnection()
	{
		try
		{
			string text = Conversions.ToString(TCommon.get_Session((object)"AuthenticationType"));
			string sCnnString = ((Operators.CompareString(text, "SQL", false) != 0) ? string.Format("Server={0};Database={1};Integrated Security=Yes", RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlServerName")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlDataDBName"))) : string.Format("Server={0};Uid={1};Pwd={2};Database={3};Integrated Security=no", RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlServerName")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlUserName")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlPassword")), RuntimeHelpers.GetObjectValue(TCommon.get_Session((object)"SqlDataDBName"))));
			if (!TestConnection(sCnnString))
			{
				LoadDefautConnect();
				return true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return true;
	}

	private static bool TestConnection(string sCnnString)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		string text = Conversions.ToString(TCommon.get_Session((object)"DaoType"));
		SqlConnection val = null;
		bool result;
		try
		{
			string text2 = text;
			if (Operators.CompareString(text2, "Oracle", false) == 0)
			{
				throw new NotSupportedException("Oracle Object type not supported!");
			}
			if (Operators.CompareString(text2, "MsSql", false) != 0)
			{
				throw new NotSupportedException("Data Access Object type not supported!");
			}
			val = new SqlConnection(sCnnString);
			val.Open();
			val.Close();
			((Component)(object)val).Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
			goto IL_00a7;
		}
		result = true;
		goto IL_00a7;
		IL_00a7:
		return result;
	}

	public static DataTable TGetDataTable(bool isSys, string spName, params object[] ParamValues)
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00e0: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		SqlConnection val = CreateConnection(isSys);
		SqlCommand val2 = val.CreateCommand();
		val2.CommandTimeout = 9000;
		val2.CommandType = CommandType.StoredProcedure;
		val2.CommandText = spName;
		val2.Parameters.Clear();
		SqlCommandBuilder.DeriveParameters(val2);
		DataTable result;
		checked
		{
			int num = val2.Parameters.Count - 1;
			int num2 = ParamValues.Length;
			int num3 = num2 - 1;
			int num4 = 0;
			while (true)
			{
				int num5 = num4;
				int num6 = num3;
				if (num5 > num6)
				{
					break;
				}
				if (num4 <= num2)
				{
					val2.Parameters[num4 + 1].Value = RuntimeHelpers.GetObjectValue(ParamValues[num4]);
				}
				else
				{
					val2.Parameters[num4 + 1].Value = DBNull.Value;
				}
				num4++;
			}
			DataTable dataTable = new DataTable();
			SqlDataAdapter val3 = new SqlDataAdapter();
			val3.SelectCommand = val2;
			try
			{
				((DbDataAdapter)(object)val3).Fill(dataTable);
			}
			catch (SqlException ex)
			{
				ProjectData.SetProjectError((Exception)ex);
				SqlException ex2 = ex;
				result = null;
				ProjectData.ClearProjectError();
				goto IL_0116;
			}
			finally
			{
				((Component)(object)val3).Dispose();
			}
			((Component)(object)val2).Dispose();
			val.Close();
			((Component)(object)val).Dispose();
			result = dataTable;
			goto IL_0116;
		}
		IL_0116:
		return result;
	}

	public static DataTable TGetDataTableByQuerry(bool isSys, string stringQuerry, params object[] ParamValues)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0052: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		SqlConnection val = CreateConnection(isSys);
		SqlCommand val2 = val.CreateCommand();
		val2.CommandTimeout = 9000;
		val2.CommandType = CommandType.Text;
		val2.CommandText = stringQuerry;
		DataTable dataTable = new DataTable();
		SqlDataAdapter val3 = new SqlDataAdapter();
		val3.SelectCommand = val2;
		DataTable result;
		try
		{
			((DbDataAdapter)(object)val3).Fill(dataTable);
		}
		catch (SqlException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			SqlException ex2 = ex;
			CMessageBox.Show("Không thể kết nối đến server!");
			result = null;
			ProjectData.ClearProjectError();
			goto IL_0093;
		}
		finally
		{
			((Component)(object)val3).Dispose();
		}
		((Component)(object)val2).Dispose();
		val.Close();
		((Component)(object)val).Dispose();
		result = dataTable;
		goto IL_0093;
		IL_0093:
		return result;
	}
}
