using System;
using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public class MsSqlSiReOrderVoucherNumberDAO : MsSqlDAO, SiReOrderVoucherNumberDAO
{
	public int ReOrder(string Ma_ct, string So_Ct, DateTime Ngay1, DateTime Ngay2)
	{
		_command.CommandText = "asSiReOrderVoucherNumber";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pMa_ct", (object)Ma_ct);
		_command.Parameters.AddWithValue("@pSo_Ct", (object)So_Ct);
		_command.Parameters.AddWithValue("@pngay1", (object)Ngay1);
		_command.Parameters.AddWithValue("@pngay2", (object)Ngay2);
		_command.Parameters.AddWithValue("@pUser", (object)SystemInformations.UserName);
		return ExecuteNonQuery();
	}

	int SiReOrderVoucherNumberDAO.ReOrder(string Ma_ct, string So_Ct, DateTime Ngay1, DateTime Ngay2)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ReOrder
		return this.ReOrder(Ma_ct, So_Ct, Ngay1, Ngay2);
	}

	public DataTable GetDmKC(DateTime Ngay1, DateTime Ngay2)
	{
		_command.CommandText = "asSiGetDmCt4ReOrderVN";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)CompanyInformations.CompanyID);
		_command.Parameters.AddWithValue("@pngay1", (object)Ngay1);
		_command.Parameters.AddWithValue("@pngay2", (object)Ngay2);
		return GetDataTable();
	}

	DataTable SiReOrderVoucherNumberDAO.GetDmCt(DateTime Ngay1, DateTime Ngay2)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDmKC
		return this.GetDmKC(Ngay1, Ngay2);
	}
}
