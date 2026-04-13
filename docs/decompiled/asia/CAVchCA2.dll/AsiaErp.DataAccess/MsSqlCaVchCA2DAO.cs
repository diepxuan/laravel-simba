using System.Data;
using System.Runtime.CompilerServices;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.DataAccess;

public class MsSqlCaVchCA2DAO : MsSqlBaseVoucherDAO, CaVchCA2DAO
{
	public MsSqlCaVchCA2DAO(VoucherInformation oVInfo)
		: base(oVInfo)
	{
	}

	public DataTable GetDataToKeThueVATNK(string pMa_cty, string pStt_rec)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asCaVchCA2GetVATNK_TAIN";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pStt_rec", (object)pStt_rec);
		return GetDataTable();
	}

	DataTable CaVchCA2DAO.GetDataToKeThueVATNK(string pMa_cty, string pStt_rec)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDataToKeThueVATNK
		return this.GetDataToKeThueVATNK(pMa_cty, pStt_rec);
	}

	public int UpdateToKeThueVATNK(DataRow pDrv)
	{
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asCaVchCA2UpdateTAIN";
		_command.Parameters.Clear();
		_command.Parameters.AddWithValue("@pMa_cty", RuntimeHelpers.GetObjectValue(pDrv["Ma_cty"]));
		_command.Parameters.AddWithValue("@pStt_rec", RuntimeHelpers.GetObjectValue(pDrv["Stt_rec"]));
		_command.Parameters.AddWithValue("@pStt_rec0", RuntimeHelpers.GetObjectValue(pDrv["Stt_rec0"]));
		_command.Parameters.AddWithValue("@pNgay_pc", RuntimeHelpers.GetObjectValue(pDrv["Ngay_ct"]));
		_command.Parameters.AddWithValue("@pStt_rec_pc", RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(pDrv["tag"], (object)0, false), (object)"", RuntimeHelpers.GetObjectValue(pDrv["Stt_rec_pc"]))));
		_command.Parameters.AddWithValue("@pVAT_NK", RuntimeHelpers.GetObjectValue(pDrv["tag"]));
		return ExecuteNonQuery();
	}

	int CaVchCA2DAO.UpdateToKeThueVATNK(DataRow pDrv)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UpdateToKeThueVATNK
		return this.UpdateToKeThueVATNK(pDrv);
	}
}
