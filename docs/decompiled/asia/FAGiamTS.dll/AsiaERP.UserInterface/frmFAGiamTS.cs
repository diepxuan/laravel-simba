using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaERP.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmFAGiamTS : frmDMView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public frmFAGiamTS(string menuid)
		: base(menuid)
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
		Button obj = cmdChgCode;
		Point location = new Point(529, 314);
		((Control)obj).Location = location;
		TextBox obj2 = txtValue;
		location = new Point(120, 398);
		((Control)obj2).Location = location;
		Button obj3 = cmdDel;
		location = new Point(527, 397);
		((Control)obj3).Location = location;
		ComboBox obj4 = cboFilter;
		location = new Point(37, 397);
		((Control)obj4).Location = location;
		Button obj5 = cmdEdit;
		location = new Point(457, 397);
		((Control)obj5).Location = location;
		Button obj6 = cmdSearch;
		location = new Point(214, 397);
		((Control)obj6).Location = location;
		Button obj7 = cmdAdd;
		location = new Point(387, 397);
		((Control)obj7).Location = location;
		Label obj8 = lblTen;
		location = new Point(8, 399);
		((Control)obj8).Location = location;
		Label obj9 = lblTen;
		Size size = new Size(30, 17);
		((Control)obj9).Size = size;
		Button obj10 = cmdPrint;
		location = new Point(598, 397);
		((Control)obj10).Location = location;
		Button obj11 = cmdClose;
		location = new Point(667, 397);
		((Control)obj11).Location = location;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(741, 429);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFAGiamTS";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void GetData(params object[] @params)
	{
		FAGiamTSDAO fAGiamTSDAO = (FAGiamTSDAO)DAOFactory.CreateDAOInstance("FAGiamTSDAO", "FAGiamTS");
		SourceTable = fAGiamTSDAO.GetData(CompanyInformations.CompanyID);
		fAGiamTSDAO.Destroy();
	}

	protected override void Delete()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		if (((DataGridView)dgvDM).CurrentRow != null && (int)CMessageBox.Show(Helper.GetMessContent(50003), SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256) != 7)
		{
			FAGiamTSDAO fAGiamTSDAO = (FAGiamTSDAO)DAOFactory.CreateDAOInstance("FAGiamTSDAO", "FAGiamTS");
			if (fAGiamTSDAO.Delete(CompanyInformations.CompanyID, Conversions.ToString(NewLateBinding.LateIndexGet(((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvDM).DataSource)].Current, new object[1] { "ma_ts" }, (string[])null)), SystemInformations.UserName) == 0)
			{
				SourceTable.Rows.Remove((DataRow)NewLateBinding.LateGet(((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvDM).DataSource)].Current, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null));
				SourceTable.AcceptChanges();
			}
			fAGiamTSDAO.Destroy();
		}
	}
}
