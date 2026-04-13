using System;
using System.Data;
using System.Runtime.CompilerServices;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.Business;

public class INVchIN6Controller : VoucherController
{
	public new INVchIN6DAO MyDAO
	{
		get
		{
			if (f_oDAO == null)
			{
				try
				{
					object[] arg = new object[1] { MyVoucherInfo };
					f_oDAO = (BaseVoucherDAO)DAOFactory.CreateDAOInstance("INVchIN6DAO", "INVchIN6", arg);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Helper.ProcessError(ex2);
					ProjectData.ClearProjectError();
				}
			}
			return (INVchIN6DAO)f_oDAO;
		}
	}

	public INVchIN6Controller(VoucherInformation vInfor)
		: base(vInfor)
	{
	}

	private void RollBackStt_Rec(DataTable oTbl, string sFilter)
	{
		string value = "0";
		DataRow[] array = oTbl.Select(sFilter);
		foreach (DataRow dataRow in array)
		{
			dataRow["stt_rec"] = value;
		}
	}

	public override bool Insert(DataRow oDrPh, DataTable oTblCt, DataTable oTblCtD, DataTable oTblTain, DataTable oTblTaOut)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		bool result;
		checked
		{
			if (MyDAO == null)
			{
				CMessageBox.ShowWithFormat(50106, new object[1] { MyVoucherInfo.ph_table_name });
				result = false;
			}
			else
			{
				string sFilter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", oDrPh["Stt_rec"]), (object)"'"));
				bool flag = false;
				try
				{
					MyDAO.RequireTrans = true;
					int num = MyDAO.InsertPH(oDrPh);
					if (num != 0)
					{
						MyDAO.RollBackTrans();
						CMessageBox.Show(num);
						result = false;
					}
					else
					{
						DataRow[] array = oTblCt.Select("Stt_Rec='0'");
						int num2 = 0;
						while (true)
						{
							if (num2 < array.Length)
							{
								DataRow dataRow = array[num2];
								dataRow["Stt_Rec"] = RuntimeHelpers.GetObjectValue(oDrPh["Stt_rec"]);
								dataRow.ClearErrors();
								dataRow.EndEdit();
								num = MyDAO.InsertCT(dataRow);
								if (num != 0)
								{
									RollBackStt_Rec(oTblCt, sFilter);
									MyDAO.RollBackTrans();
									CMessageBox.Show(num);
									result = false;
									break;
								}
								num2++;
								continue;
							}
							DataRow[] array2 = oTblCtD.Select("Stt_Rec='0'");
							int num3 = 0;
							while (true)
							{
								if (num3 < array2.Length)
								{
									DataRow dataRow2 = array2[num3];
									dataRow2["Stt_Rec"] = RuntimeHelpers.GetObjectValue(oDrPh["Stt_rec"]);
									dataRow2.ClearErrors();
									dataRow2.EndEdit();
									num = MyDAO.InsertCTD(dataRow2);
									if (num != 0)
									{
										RollBackStt_Rec(oTblCt, sFilter);
										RollBackStt_Rec(oTblCtD, sFilter);
										MyDAO.RollBackTrans();
										CMessageBox.Show(num);
										result = false;
										break;
									}
									num3++;
									continue;
								}
								if (!MyDAO.DBProcess(CompanyInformations.CompanyID, MyVoucherInfo.voucher_code, Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrPh["Stt_rec"]), isNum: false)), Conversions.ToString(1)))
								{
									RollBackStt_Rec(oTblCt, sFilter);
									RollBackStt_Rec(oTblCtD, sFilter);
									MyDAO.RollBackTrans();
									result = false;
									break;
								}
								MyDAO.CommitTrans();
								goto IL_0293;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					MyDAO.RollBackTrans();
					Helper.ProcessError(ex2);
					result = false;
					ProjectData.ClearProjectError();
				}
			}
			goto IL_0298;
		}
		IL_0298:
		return result;
		IL_0293:
		result = true;
		goto IL_0298;
	}

	public override bool Update(DataRow oDrPh, DataTable oTblCt, DataTable oTblCtD, DataTable oTblTain, DataTable oTblTaOut)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		bool result;
		checked
		{
			if (MyDAO == null)
			{
				CMessageBox.ShowWithFormat(50106, new object[1] { MyVoucherInfo.ph_table_name });
				result = false;
			}
			else
			{
				bool flag = false;
				MyDAO.RequireTrans = true;
				try
				{
					int num = 0;
					num = MyDAO.UpdatePH(oDrPh);
					if (num != 0)
					{
						MyDAO.RollBackTrans();
						CMessageBox.Show(num);
						result = false;
					}
					else
					{
						num = MyDAO.DeleteCT(oDrPh);
						if (num != 0)
						{
							MyDAO.RollBackTrans();
							CMessageBox.Show(num);
							result = false;
						}
						else
						{
							DataRow[] array = oTblCt.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", oDrPh["Stt_rec"]), (object)"'")));
							int num2 = 0;
							while (true)
							{
								if (num2 < array.Length)
								{
									DataRow dataRow = array[num2];
									dataRow.ClearErrors();
									dataRow.EndEdit();
									num = MyDAO.InsertCT(dataRow);
									if (num != 0)
									{
										MyDAO.RollBackTrans();
										CMessageBox.Show(num);
										result = false;
										break;
									}
									num2++;
									continue;
								}
								num = MyDAO.DeleteCTD(oDrPh);
								if (num != 0)
								{
									MyDAO.RollBackTrans();
									CMessageBox.Show(num);
									result = false;
									break;
								}
								DataRow[] array2 = oTblCtD.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", oDrPh["Stt_rec"]), (object)"'")));
								int num3 = 0;
								while (true)
								{
									if (num3 < array2.Length)
									{
										DataRow dataRow2 = array2[num3];
										dataRow2.ClearErrors();
										dataRow2.EndEdit();
										num = MyDAO.InsertCTD(dataRow2);
										if (num != 0)
										{
											MyDAO.RollBackTrans();
											CMessageBox.Show(num);
											result = false;
											break;
										}
										num3++;
										continue;
									}
									if (!MyDAO.DBProcess(CompanyInformations.CompanyID, MyVoucherInfo.voucher_code, Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDrPh["Stt_rec"]), isNum: false)), Conversions.ToString(2)))
									{
										MyDAO.RollBackTrans();
										result = false;
										break;
									}
									MyDAO.CommitTrans();
									goto IL_02a4;
								}
								break;
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					MyDAO.RollBackTrans();
					Helper.ProcessError(ex2);
					result = false;
					ProjectData.ClearProjectError();
				}
			}
			goto IL_02a9;
		}
		IL_02a9:
		return result;
		IL_02a4:
		result = true;
		goto IL_02a9;
	}

	public DataTable GetBoMByMa_vt(string aMa_cty, string aMa_Vt)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { MyVoucherInfo.ph_table_name });
			return null;
		}
		return MyDAO.GetBoMByMa_vt(aMa_cty, aMa_Vt);
	}

	public DataTable GetPrintDataSource(string aMa_Cty, string aStt_Rec)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { MyVoucherInfo.ph_table_name });
			return null;
		}
		return MyDAO.GetPrintDataSource(aMa_Cty, aStt_Rec);
	}

	public bool SearchBOM(string aKeyPh, string aKeyCtM, string aKeyCtD, ref DataTable oTblPh, ref DataTable oTblCtM, ref DataTable oTblCtD)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { MyVoucherInfo.ph_table_name });
			return false;
		}
		return MyDAO.SearchBOM(aKeyPh, aKeyCtM, aKeyCtD, ref oTblPh, ref oTblCtM, ref oTblCtD);
	}

	public virtual DataTable GetDataCTD(params object[] @params)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { MyVoucherInfo.ph_table_name });
			return null;
		}
		return MyDAO.ReadCTD(@params);
	}

	public virtual bool InsertCTD(DataRow oDr)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { MyVoucherInfo.ph_table_name });
			return false;
		}
		int num = MyDAO.InsertCTD(oDr);
		if (num != 0)
		{
			CMessageBox.Show(num);
		}
		return num == 0;
	}

	public virtual bool DeleteCTD(DataRow oDr)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.Show(50106, MyVoucherInfo.ph_table_name);
			return false;
		}
		return MyDAO.DeleteCTD(oDr) == 0;
	}
}
