using System;
using System.Data;
using AsiaErp.Framework;

namespace AsiaErp.DataAccess;

public class MsSqlCaVchCA5DAO : MsSqlBaseVoucherDAO, CaVchCA5DAO
{
	public DataTable Get_PhieuChi(string aMa_cty, string aMa_Kh, DateTime pNgay_ct)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asCaGetCA24CA5";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)aMa_cty);
		_command.Parameters.AddWithValue("@pMa_Kh", (object)aMa_Kh);
		_command.Parameters.AddWithValue("@pNgay_ct", (object)pNgay_ct);
		return GetDataTable();
	}

	DataTable CaVchCA5DAO.Get_PhieuChi(string aMa_cty, string aMa_Kh, DateTime pNgay_ct)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Get_PhieuChi
		return this.Get_PhieuChi(aMa_cty, aMa_Kh, pNgay_ct);
	}

	public DataTable Get_PhieuHU(string aMa_cty, string pstt_rec_pc, DateTime pNgay_ct)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asCaGetCA5ToPrint";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_Cty", (object)aMa_cty);
		_command.Parameters.AddWithValue("@pstt_rec_pc", (object)pstt_rec_pc);
		_command.Parameters.AddWithValue("@pNgay_ct", (object)pNgay_ct);
		return GetDataTable();
	}

	DataTable CaVchCA5DAO.Get_PhieuHU(string aMa_cty, string pstt_rec_pc, DateTime pNgay_ct)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Get_PhieuHU
		return this.Get_PhieuHU(aMa_cty, pstt_rec_pc, pNgay_ct);
	}

	public MsSqlCaVchCA5DAO(VoucherInformation oVInfo)
		: base(oVInfo)
	{
	}
}
