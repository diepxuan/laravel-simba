using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.DataAccess;

public class MsSqlVOUCHERDAO : MsSqlDAO, VOUCHERDAO
{
	[DebuggerNonUserCode]
	public MsSqlVOUCHERDAO()
	{
	}

	public int UpdateToDB(DataRow odr)
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
				_command.CommandText = "asUpdVoucherInfo";
				_command.Parameters.Clear();
				SqlCommandBuilder.DeriveParameters(_command);
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
						goto IL_01b7;
					}
					if (_command.Parameters.Contains("@pRet"))
					{
						result = Conversions.ToInteger(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(_command.Parameters["@pRet"].Value), isNum: true));
						goto IL_01b7;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Helper.ProcessError(ex2);
					result = 50010;
					ProjectData.ClearProjectError();
					goto IL_01b7;
				}
				result = 0;
			}
			goto IL_01b7;
		}
		IL_01b7:
		return result;
	}

	int VOUCHERDAO.UpdateToDB(DataRow odr)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdateToDB
		return this.UpdateToDB(odr);
	}

	public DataTable GetFieldDescription(string tableName)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSIGetTableColumnDefine";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pTableName", (object)tableName);
		return GetDataTable();
	}

	DataTable VOUCHERDAO.GetFieldDescription(string tableName)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetFieldDescription
		return this.GetFieldDescription(tableName);
	}
}
