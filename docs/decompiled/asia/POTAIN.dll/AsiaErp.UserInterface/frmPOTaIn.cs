using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmPOTaIn : frmDMComplexView
{
	private IContainer components;

	public frmPOTaIn(string menuid)
		: base(menuid)
	{
		InitializeComponent();
		((Control)txtValue).Visible = false;
		((Control)cboFilter).Visible = false;
		((Control)lblTen).Visible = false;
		((Control)cmdSearch).Visible = false;
		((Control)cmdChgCode).Visible = false;
		((Control)cmdAdd).Location = ((Control)cmdEdit).Location;
		((Control)cmdEdit).Location = ((Control)cmdDel).Location;
		((Control)cmdDel).Location = ((Control)cmdChgCode).Location;
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Control)this).Name = "frmPOTaIn";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		base.SourceTable.Columns["ma_ct"].DefaultValue = base.MyMenuInfo.par1;
		base.SourceTable.Columns["stt_rec0"].DefaultValue = "";
	}

	protected override void InitOtherBeforeLoadData()
	{
		base.InitOtherBeforeLoadData();
	}

	protected override void Edit()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(SourceTable.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["ma_ct"].ToString(), "TAI", false) != 0)
		{
			CMessageBox.Show(50139);
		}
		else
		{
			base.Edit();
		}
	}

	protected override void Delete()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(SourceTable.DefaultView[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["ma_ct"].ToString(), "TAI", false) != 0)
		{
			CMessageBox.Show(50140);
		}
		else
		{
			base.Delete();
		}
	}
}
