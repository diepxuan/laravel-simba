using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlFADGTSDAO : MsSqlDAO, IFADGTSDAO
{
	[DebuggerNonUserCode]
	public MsSqlFADGTSDAO()
	{
	}

	public int CheckDgtsSauGiamTS(params object[] Array)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asFaCheckDgtsSauGiamTS";
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
				_command.Parameters[num2].Value = RuntimeHelpers.GetObjectValue(Array[num2 - 1]);
				num2++;
			}
			_command.Parameters["@pRet"].Direction = ParameterDirection.Output;
			ExecuteNonQuery();
			return Conversions.ToInteger(_command.Parameters["@pRet"].Value);
		}
	}

	int IFADGTSDAO.CheckDgtsSauGiamTS(params object[] Array)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CheckDgtsSauGiamTS
		return this.CheckDgtsSauGiamTS(Array);
	}
}
