using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AsiaERP.UserInterface;
using AsiaErp.Framework;

namespace AsiaERP.DataAccess;

public class MssqlGLPost2GLDAO : MsSqlDAO, IGLPost2GLDAO
{
	public DataSet GetVoucher2Post(string pMa_cty, DateTime pNgay1, DateTime pNgay2, string pSo_ct1, string pSo_ct2, string pMa_Ct, string pPost2Gl)
	{
		_command.Parameters.Clear();
		_command.CommandText = "asGetVoucher2Post";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pNgay1", (object)pNgay1);
		_command.Parameters.AddWithValue("@pNgay2", (object)pNgay2);
		_command.Parameters.AddWithValue("@pSo_ct1", (object)pSo_ct1);
		_command.Parameters.AddWithValue("@pSo_ct2", (object)pSo_ct2);
		_command.Parameters.AddWithValue("@pMa_CtLst", (object)pMa_Ct);
		_command.Parameters.AddWithValue("@pPost2gl", (object)pPost2Gl);
		return GetDataSet();
	}

	DataSet IGLPost2GLDAO.GetVoucher2Post(string pMa_cty, DateTime pNgay1, DateTime pNgay2, string pSo_ct1, string pSo_ct2, string pMa_Ct, string pPost2Gl)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetVoucher2Post
		return this.GetVoucher2Post(pMa_cty, pNgay1, pNgay2, pSo_ct1, pSo_ct2, pMa_Ct, pPost2Gl);
	}

	public int Post2GL(string pMa_cty, string pStt_rec, string pMa_ct, string pPost)
	{
		_command.Parameters.Clear();
		_command.CommandText = "asPost2Gl";
		_command.CommandType = CommandType.StoredProcedure;
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pStt_rec", (object)pStt_rec);
		_command.Parameters.AddWithValue("@pMa_ct", (object)pMa_ct);
		_command.Parameters.AddWithValue("@pPostUnpost", (object)pPost);
		return ExecuteNonQuery();
	}

	int IGLPost2GLDAO.Post2GL(string pMa_cty, string pStt_rec, string pMa_ct, string pPost)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Post2GL
		return this.Post2GL(pMa_cty, pStt_rec, pMa_ct, pPost);
	}

	public List<VoucherInfoDatasource> GetSiCt4PostGl(string pMa_cty, string pMa_ph, string pMa_ct, string pLang)
	{
		_command.Parameters.Clear();
		_command.CommandType = CommandType.StoredProcedure;
		_command.CommandText = "asSiGetCt4PostGL";
		_command.Parameters.AddWithValue("@pMa_cty", (object)pMa_cty);
		_command.Parameters.AddWithValue("@pMa_ph", (object)pMa_ph);
		_command.Parameters.AddWithValue("@pMa_ct", (object)pMa_ct);
		_command.Parameters.AddWithValue("@pLanguageId", (object)pLang);
		SqlDataReader dataReader = GetDataReader();
		if (dataReader == null || !dataReader.HasRows)
		{
			return null;
		}
		return CBO<VoucherInfoDatasource>.FillList((IDataReader)dataReader);
	}

	List<VoucherInfoDatasource> IGLPost2GLDAO.GetSiCt4PostGl(string pMa_cty, string pMa_ph, string pMa_ct, string pLang)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetSiCt4PostGl
		return this.GetSiCt4PostGl(pMa_cty, pMa_ph, pMa_ct, pLang);
	}
}
