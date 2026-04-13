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
public class frmCODMPB : frmDMComplexView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("SplitContainer1")]
	private SplitContainer _SplitContainer1;

	[AccessedThroughProperty("dgvCTPB")]
	private AsDataGridView _dgvCTPB;

	[AccessedThroughProperty("colTK")]
	private DataGridViewTextBoxColumn _colTK;

	[AccessedThroughProperty("colTenTk")]
	private DataGridViewTextBoxColumn _colTenTk;

	[AccessedThroughProperty("bsDanhMucCT")]
	private BindingSource _bsDanhMucCT;

	internal DataTable f_oTblPbCt;

	internal virtual SplitContainer SplitContainer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SplitContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SplitContainer1 = value;
		}
	}

	internal virtual AsDataGridView dgvCTPB
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvCTPB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvCTPB = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colTK
	{
		[DebuggerNonUserCode]
		get
		{
			return _colTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_colTK = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colTenTk
	{
		[DebuggerNonUserCode]
		get
		{
			return _colTenTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_colTenTk = value;
		}
	}

	internal virtual BindingSource bsDanhMucCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _bsDanhMucCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_bsDanhMucCT = value;
		}
	}

	public frmCODMPB(string MenuId)
		: base(MenuId)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		f_oTblPbCt = new DataTable();
		InitializeComponent();
		((Control)SplitContainer1.Panel1).Controls.Add((Control)(object)dgvDM);
		((Control)dgvDM).Dock = (DockStyle)5;
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		SplitContainer1 = new SplitContainer();
		dgvCTPB = new AsDataGridView();
		colTK = new DataGridViewTextBoxColumn();
		colTenTk = new DataGridViewTextBoxColumn();
		bsDanhMucCT = new BindingSource(components);
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)SplitContainer1.Panel2).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((ISupportInitialize)dgvCTPB).BeginInit();
		((ISupportInitialize)bsDanhMucCT).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = cmdChgCode;
		Point location = new Point(317, 541);
		((Control)obj).Location = location;
		Button obj2 = cmdChgCode;
		Size size = new Size(64, 20);
		((Control)obj2).Size = size;
		((Control)cmdChgCode).Visible = false;
		TextBox obj3 = txtValue;
		location = new Point(141, 539);
		((Control)obj3).Location = location;
		Button obj4 = cmdDel;
		location = new Point(607, 538);
		((Control)obj4).Location = location;
		ComboBox obj5 = cboFilter;
		location = new Point(58, 539);
		((Control)obj5).Location = location;
		Button obj6 = cmdEdit;
		location = new Point(537, 538);
		((Control)obj6).Location = location;
		Button obj7 = cmdSearch;
		location = new Point(235, 538);
		((Control)obj7).Location = location;
		Button obj8 = cmdAdd;
		location = new Point(467, 538);
		((Control)obj8).Location = location;
		Label obj9 = lblTen;
		location = new Point(7, 541);
		((Control)obj9).Location = location;
		Button obj10 = cmdPrint;
		location = new Point(397, 538);
		((Control)obj10).Location = location;
		((Control)cmdPrint).Visible = false;
		Button obj11 = cmdClose;
		location = new Point(676, 538);
		((Control)obj11).Location = location;
		((Control)SplitContainer1).Anchor = (AnchorStyles)15;
		SplitContainer splitContainer = SplitContainer1;
		location = new Point(9, 9);
		((Control)splitContainer).Location = location;
		((Control)SplitContainer1).Name = "SplitContainer1";
		SplitContainer1.Orientation = (Orientation)0;
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)dgvCTPB);
		SplitContainer splitContainer2 = SplitContainer1;
		size = new Size(736, 523);
		((Control)splitContainer2).Size = size;
		SplitContainer1.SplitterDistance = 320;
		((Control)SplitContainer1).TabIndex = 42;
		((DataGridView)dgvCTPB).AllowUserToAddRows = false;
		((DataGridView)dgvCTPB).AllowUserToDeleteRows = false;
		((DataGridView)dgvCTPB).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvCTPB).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvCTPB).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		((DataGridView)dgvCTPB).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvCTPB).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)colTK,
			(DataGridViewColumn)colTenTk
		});
		((Control)dgvCTPB).Dock = (DockStyle)5;
		dgvCTPB.DoubleBuffered = false;
		((DataGridView)dgvCTPB).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvCTPB).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvCTPB;
		location = new Point(0, 0);
		((Control)asDataGridView).Location = location;
		((Control)dgvCTPB).Name = "dgvCTPB";
		((DataGridView)dgvCTPB).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvCTPB).RowHeadersDefaultCellStyle = val;
		dgvCTPB.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvCTPB).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvCTPB;
		size = new Size(736, 199);
		((Control)asDataGridView2).Size = size;
		((Control)dgvCTPB).TabIndex = 43;
		((DataGridViewColumn)colTK).DataPropertyName = "tk_nhan_pb";
		((DataGridViewColumn)colTK).HeaderText = "TK nhận phân bổ";
		((DataGridViewColumn)colTK).Name = "colTK";
		((DataGridViewColumn)colTK).ReadOnly = true;
		((DataGridViewColumn)colTK).Width = 150;
		((DataGridViewColumn)colTenTk).DataPropertyName = "ten_tk";
		((DataGridViewColumn)colTenTk).HeaderText = "Tên TK nhận phân bổ";
		((DataGridViewColumn)colTenTk).Name = "colTenTk";
		((DataGridViewColumn)colTenTk).ReadOnly = true;
		((DataGridViewColumn)colTenTk).Width = 400;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(750, 570);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)SplitContainer1);
		((Control)this).Name = "frmCODMPB";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdChgCode, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)SplitContainer1, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdClose, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cboFilter, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtValue, 0);
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)SplitContainer1.Panel2).ResumeLayout(false);
		((Control)SplitContainer1).ResumeLayout(false);
		((ISupportInitialize)dgvCTPB).EndInit();
		((ISupportInitialize)bsDanhMucCT).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void GetDetailPB()
	{
		ICODMPB1DAO iCODMPB1DAO = (ICODMPB1DAO)DAOFactory.CreateDAOInstance("CODMPB1DAO", "CODMPB");
		f_oTblPbCt = iCODMPB1DAO.GetData(CompanyInformations.CompanyID, base.MyMenuInfo.moduleid);
		iCODMPB1DAO.Destroy();
		bsDanhMucCT.DataSource = f_oTblPbCt.DefaultView;
		((DataGridView)dgvCTPB).DataSource = bsDanhMucCT;
		MasterDetailRelationRefresh(-100);
	}

	protected override void GetData(params object[] @params)
	{
		base.GetData(CompanyInformations.CompanyID, base.MyMenuInfo.moduleid);
	}

	protected override void InitOtherAfterLoadData()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		base.InitOtherAfterLoadData();
		GetDetailPB();
		frmCODMPBEdit.f_oTblPbCt = f_oTblPbCt;
		((DataGridView)dgvDM).RowEnter += new DataGridViewCellEventHandler(dgvDM_RowEnter);
	}

	protected override void AddNew()
	{
		if ((SourceTable != null && SourceTable.Rows.Count > 0) ? true : false)
		{
			frmCODMPBEdit.stt = Conversions.ToInteger(Operators.AddObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(SourceTable.Compute("max(stt)", "")), isNum: true), (object)1));
		}
		else
		{
			frmCODMPBEdit.stt = 1;
		}
		base.AddNew();
	}

	protected override void Edit()
	{
		if (SourceTable != null && SourceTable.Rows.Count > 0 && 0 == 0)
		{
			frmCODMPBEdit.pID = Conversions.ToInteger(base.SourceTable.Rows[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index]["id"]);
			base.Edit();
		}
	}

	protected override void Delete()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		if (bsDanhMuc.Current == null || (int)CMessageBox.Show(50003, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)256) == 7 || 1 == 0)
		{
			return;
		}
		DataRowView dataRowView = (DataRowView)bsDanhMuc.Current;
		int num = Conversions.ToInteger(((DataRowView)bsDanhMuc.Current)["id"]);
		if (base.MyController.Delete(dataRowView.Row))
		{
			dataRowView.Delete();
			SourceTable.AcceptChanges();
			DataRow[] array = f_oTblPbCt.Select("id=" + num);
			foreach (DataRow dataRow in array)
			{
				dataRow.Delete();
				f_oTblPbCt.AcceptChanges();
			}
		}
	}

	private void dgvDM_RowEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			MasterDetailRelationRefresh(e.RowIndex);
		}
	}

	private void MasterDetailRelationRefresh(int idx)
	{
		if (idx == -100)
		{
			f_oTblPbCt.DefaultView.RowFilter = "id='-100'";
		}
		else if ((base.SourceTable != null && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(base.SourceTable.DefaultView[idx]["id"].ToString(), isNum: false), (object)"", false)) ? true : false)
		{
			f_oTblPbCt.DefaultView.RowFilter = Conversions.ToString(Operators.ConcatenateObject((object)"id=", Helper.Repl_Null(base.SourceTable.DefaultView[idx]["id"].ToString(), isNum: false)));
		}
	}
}
