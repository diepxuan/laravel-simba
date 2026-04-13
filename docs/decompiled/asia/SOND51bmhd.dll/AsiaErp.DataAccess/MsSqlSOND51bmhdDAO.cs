using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlSOND51bmhdDAO : MsSqlDAO, SOND51bmhdDAO
{
	[DebuggerNonUserCode]
	public MsSqlSOND51bmhdDAO()
	{
	}

	public DataTable GetData()
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSOGetND51opt";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_opt", (object)"KEY");
		return GetDataTable();
	}

	DataTable SOND51bmhdDAO.GetData()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetData
		return this.GetData();
	}

	public int Update(string gia_tri, bool ksd, bool isFirst)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		if (isFirst)
		{
			_command.CommandText = "asSOInsND51opt";
		}
		else
		{
			_command.CommandText = "asSOUpdND51opt";
		}
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_opt", (object)"KEY");
		_command.Parameters.AddWithValue("@pGia_tri", (object)gia_tri);
		_command.Parameters.AddWithValue("@pKsd", (object)ksd);
		if (isFirst)
		{
			_command.Parameters.AddWithValue("@pCuser", (object)SystemInformations.UserName);
			_command.Parameters.AddWithValue("@pLuser", (object)SystemInformations.UserName);
		}
		else
		{
			_command.Parameters.AddWithValue("@pLuser", (object)SystemInformations.UserName);
		}
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

	int SOND51bmhdDAO.Update(string gia_tri, bool ksd, bool isFirst)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Update
		return this.Update(gia_tri, ksd, isFirst);
	}
}
