using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using AsiaERP.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmFAThoiKHTS : frmDMComplexView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public frmFAThoiKHTS(string MenuID)
		: base(MenuID)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Control)cmdChgCode).Visible = false;
		((Control)txtValue).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdDel).Location;
		((Control)cmdEdit).Location = ((Control)cmdChgCode).Location;
		((Control)cmdDel).Location = ((Control)cmdPrint).Location;
		((Control)cboFilter).Visible = false;
		((Control)cmdSearch).Visible = false;
		((Control)lblTen).Visible = false;
		((Control)cmdPrint).Visible = false;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void Delete()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		if ((SourceTable != null || SourceTable.Rows.Count <= 0) && 0 == 0 && (int)CMessageBox.Show(Helper.GetMessContent(50003), SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256) != 7)
		{
			IFAThoiKHTSDAO iFAThoiKHTSDAO = (IFAThoiKHTSDAO)DAOFactory.CreateDAOInstance("FAThoiKHTSDAO", "FAThoiKHTS");
			DataRow row = ((DataRowView)bsDanhMuc.Current).Row;
			if (iFAThoiKHTSDAO.Delete(CompanyInformations.CompanyID, Conversions.ToString(row["ma_ts"]), Conversions.ToDate(row["Ngay_dung_kh"])) == 0)
			{
				SourceTable.Rows.Remove(row);
				SourceTable.AcceptChanges();
			}
			iFAThoiKHTSDAO.Destroy();
		}
	}
}
