using System;
using System.Data;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace DTE.Bussiness;

public class SMUserInfoController : RootController
{
	private SMUserInfoDAO f_oDAO;

	public const string TABLE_NAME = "USERINFO";

	public SMUserInfoDAO MyDAO
	{
		get
		{
			if (f_oDAO == null)
			{
				try
				{
					f_oDAO = (SMUserInfoDAO)DAOFactory.CreateDAOInstance("SMUserInfoDAO", "SMUserInfo", a_blnIsSysDB: true);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Helper.ProcessError(ex2);
					ProjectData.ClearProjectError();
				}
			}
			return f_oDAO;
		}
	}

	public DataTable GetUserInfo()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { "USERINFO" });
			return null;
		}
		return MyDAO.GetUserInfo();
	}

	public UserInfo GetUserInfoByUserName(string aUserName)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { "USERINFO" });
			return null;
		}
		return MyDAO.GetUserInfoByUserName(aUserName);
	}

	public bool ChangePassword(string aUserName, string aNew_pass)
	{
		return MyDAO.ChangePassword(aUserName, aNew_pass);
	}

	public int InsertUserInfo(string UserName, string FullName, string Password, string IsAdmin, string Grand, string Disabled, string User)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		int num = MyDAO.InsertUserInfo(UserName, FullName, Password, IsAdmin, Grand, Disabled, User);
		if (num == 0)
		{
			return -1;
		}
		CMessageBox.Show(num);
		return 0;
	}

	public bool UpdateUserInfo(string UserName, string FullName, string IsAdmin, string Grand, string Disabled, string User)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		int num = MyDAO.UpdateUserInfo(UserName, FullName, IsAdmin, Grand, Disabled, User);
		if (num == 0)
		{
			return true;
		}
		CMessageBox.Show(num);
		return false;
	}

	public bool DeleteUserInfo(string UserName)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		int num = MyDAO.DeleteUserInfo(UserName);
		if (num == 0)
		{
			return true;
		}
		CMessageBox.Show(num);
		return false;
	}

	public int ResetPassword(string UserName, string Password, string User)
	{
		return MyDAO.ResetPassword(UserName, Password, User);
	}

	public DataSet GetGroupInfo()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { "USERINFO" });
			return null;
		}
		return MyDAO.GetGroupInfo();
	}

	public DataSet GetUserGroup(string UserName)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { "USERINFO" });
			return null;
		}
		return MyDAO.GetUserGroup(UserName);
	}

	public int InsertUserGroup(string GroupName, string UserName, int pDel)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { "USERINFO" });
			return 0;
		}
		return MyDAO.InsertUserGroup(GroupName, UserName, pDel);
	}

	public int DeleteUserGroup(string UserName)
	{
		int result = default(int);
		return result;
	}

	public DataTable GetMenuForm()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { "USERINFO" });
			return null;
		}
		return MyDAO.GetMenuForm();
	}

	public DataTable GetMenuBar()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { "USERINFO" });
			return null;
		}
		return MyDAO.GetMenuBar();
	}

	public DataTable GetSubMenuBar()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { "USERINFO" });
			return null;
		}
		return MyDAO.GetSubMenuBar();
	}

	public DataTable GetAllUserRights(string UserName)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { "USERINFO" });
			return null;
		}
		return MyDAO.GetAllUserRights(UserName);
	}

	public int InsertUserRight(string UserName, string MenuID, bool ViewRight = true, bool InsertRight = true, bool UpdateRight = true, bool DeleteRight = true, int LimitedPrint = 0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { "USERINFO" });
			return 0;
		}
		return MyDAO.InsertUserRight(UserName, MenuID, ViewRight, InsertRight, UpdateRight, DeleteRight, LimitedPrint);
	}

	public int UpdateUserRight(string UserName, string UserName_Old)
	{
		int result = default(int);
		return result;
	}

	public int DeleteUserRight(string UserName, string MenuID = "")
	{
		return MyDAO.DeleteUserRight(UserName, MenuID);
	}

	public DataTable GetAllRightCompany(string UserName)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { "USERINFO" });
			return null;
		}
		return MyDAO.GetAllRightCompany(UserName);
	}

	public int InsRightCompany(string Ma_cty, string UserName, string active)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		int num = MyDAO.InsRightCompany(Ma_cty, UserName, active);
		if (num == 0)
		{
			return -1;
		}
		CMessageBox.Show(num);
		return 0;
	}

	public DataTable GetAllUserRightDash(string UserName)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { "USERINFO" });
			return null;
		}
		return MyDAO.GetAllUserRightDash(UserName);
	}

	public int DynInsertUpdateDeleteData(string pXmlData, string pTableName, string pMode, string pKeyColumns = "")
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MyDAO == null)
		{
			CMessageBox.ShowWithFormat(50106, new object[1] { "USERINFO" });
			return 0;
		}
		return MyDAO.DynInsertUpdateDeleteData(pXmlData, pTableName, pMode, pKeyColumns);
	}

	public SMUserInfoController()
	{
		f_oDAO = null;
	}
}
