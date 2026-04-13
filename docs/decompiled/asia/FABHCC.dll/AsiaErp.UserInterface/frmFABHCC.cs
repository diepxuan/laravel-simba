using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmFABHCC : frmDMView
{
	private IContainer components;

	public frmFABHCC(string MenuID)
		: base(MenuID)
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdChgCode).Visible = false;
		((Control)cmdPrint).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdDel).Location;
		((Control)cmdEdit).Location = ((Control)cmdChgCode).Location;
		((Control)cmdDel).Location = ((Control)cmdPrint).Location;
		((Control)this).Name = "frmFABHCC";
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void GetData(params object[] @params)
	{
		IFABHCCDAO iFABHCCDAO = (IFABHCCDAO)DAOFactory.CreateDAOInstance("FABHCCDAO", "FABHCC");
		SourceTable = iFABHCCDAO.GetData(CompanyInformations.CompanyID);
		iFABHCCDAO.Destroy();
	}

	protected override void Delete()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		if ((int)CMessageBox.Show(Helper.GetMessContent(50003), SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256) != 7)
		{
			IFABHCCDAO iFABHCCDAO = (IFABHCCDAO)DAOFactory.CreateDAOInstance("FABHCCDAO", "FABHCC");
			if (iFABHCCDAO.Delete(CompanyInformations.CompanyID, Conversions.ToString(SourceTable.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["ma_cc"]), Conversions.ToInteger(SourceTable.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["id"])) == 0)
			{
				SourceTable.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index].Delete();
				SourceTable.AcceptChanges();
			}
		}
	}
}
