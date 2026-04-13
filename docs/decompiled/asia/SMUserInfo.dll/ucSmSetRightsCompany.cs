using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using DTE.Bussiness;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class ucSmSetRightsCompany : UserControl
{
	private IContainer components;

	[AccessedThroughProperty("dgvDM")]
	private AsDataGridView _dgvDM;

	[AccessedThroughProperty("chkAllActive")]
	private CheckBox _chkAllActive;

	[AccessedThroughProperty("bsCompanyRight")]
	private BindingSource _bsCompanyRight;

	[AccessedThroughProperty("ma_cty")]
	private DataGridViewTextBoxColumn _ma_cty;

	[AccessedThroughProperty("Ten_cty")]
	private DataGridViewTextBoxColumn _Ten_cty;

	[AccessedThroughProperty("dgvcCompanyViewRight")]
	private DataGridViewCheckBoxColumn _dgvcCompanyViewRight;

	private DataTable f_oTblCompanyRight;

	private DataTable f_oTblGrandCompanyRight;

	internal string f_strUserName;

	internal string f_strFullUserName;

	private SMUserInfoController f_oController;

	internal string f_strGrandCompanyRight;

	internal bool f_bIsAdmin;

	internal virtual AsDataGridView dgvDM
	{
		get
		{
			return _dgvDM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DataGridViewCellValidatingEventHandler val = new DataGridViewCellValidatingEventHandler(dgvDM_CellValidating);
			if (_dgvDM != null)
			{
				((DataGridView)_dgvDM).CellValidating -= val;
			}
			_dgvDM = value;
			if (_dgvDM != null)
			{
				((DataGridView)_dgvDM).CellValidating += val;
			}
		}
	}

	internal virtual CheckBox chkAllActive
	{
		get
		{
			return _chkAllActive;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = chkAllActive_CheckedChanged;
			if (_chkAllActive != null)
			{
				_chkAllActive.CheckedChanged -= eventHandler;
			}
			_chkAllActive = value;
			if (_chkAllActive != null)
			{
				_chkAllActive.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual BindingSource bsCompanyRight
	{
		get
		{
			return _bsCompanyRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_bsCompanyRight = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ma_cty
	{
		get
		{
			return _ma_cty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ma_cty = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Ten_cty
	{
		get
		{
			return _Ten_cty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Ten_cty = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcCompanyViewRight
	{
		get
		{
			return _dgvcCompanyViewRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcCompanyViewRight = value;
		}
	}

	private SMUserInfoController MyController
	{
		get
		{
			if (f_oController == null)
			{
				f_oController = new SMUserInfoController();
			}
			return f_oController;
		}
	}

	public string UserName
	{
		get
		{
			return f_strUserName;
		}
		set
		{
			f_strUserName = value;
		}
	}

	public string GrandRightUserName
	{
		get
		{
			return f_strGrandCompanyRight;
		}
		set
		{
			f_strGrandCompanyRight = value;
		}
	}

	public bool IsAdmin
	{
		get
		{
			return f_bIsAdmin;
		}
		set
		{
			f_bIsAdmin = value;
		}
	}

	public DataTable MySourceCompanyRight
	{
		get
		{
			return f_oTblCompanyRight;
		}
		set
		{
			f_oTblCompanyRight = value;
		}
	}

	public DataTable MySourceGrandCompanyRight
	{
		get
		{
			return f_oTblGrandCompanyRight;
		}
		set
		{
			f_oTblGrandCompanyRight = value;
		}
	}

	public BindingSource MyBsCompanyRight
	{
		get
		{
			return bsCompanyRight;
		}
		set
		{
			bsCompanyRight = value;
		}
	}

	public ucSmSetRightsCompany()
	{
		f_oController = null;
		f_strGrandCompanyRight = "";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		dgvDM = new AsDataGridView();
		chkAllActive = new CheckBox();
		bsCompanyRight = new BindingSource(components);
		ma_cty = new DataGridViewTextBoxColumn();
		Ten_cty = new DataGridViewTextBoxColumn();
		dgvcCompanyViewRight = new DataGridViewCheckBoxColumn();
		((ISupportInitialize)dgvDM).BeginInit();
		((ISupportInitialize)bsCompanyRight).BeginInit();
		((Control)this).SuspendLayout();
		((DataGridView)dgvDM).AllowUserToAddRows = false;
		((DataGridView)dgvDM).AllowUserToDeleteRows = false;
		val.BackColor = Color.LightYellow;
		((DataGridView)dgvDM).AlternatingRowsDefaultCellStyle = val;
		((Control)dgvDM).Anchor = (AnchorStyles)15;
		((DataGridView)dgvDM).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvDM).BorderStyle = (BorderStyle)2;
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Control;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.WindowText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDM).ColumnHeadersDefaultCellStyle = val2;
		((DataGridView)dgvDM).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvDM).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)ma_cty,
			(DataGridViewColumn)Ten_cty,
			(DataGridViewColumn)dgvcCompanyViewRight
		});
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = SystemColors.Window;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.ControlText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvDM).DefaultCellStyle = val3;
		dgvDM.DoubleBuffered = false;
		((DataGridView)dgvDM).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvDM).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvDM;
		Point location = new Point(3, 3);
		((Control)asDataGridView).Location = location;
		((Control)dgvDM).Name = "dgvDM";
		val4.Alignment = (DataGridViewContentAlignment)32;
		val4.BackColor = SystemColors.Control;
		val4.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val4.ForeColor = SystemColors.WindowText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDM).RowHeadersDefaultCellStyle = val4;
		((DataGridView)dgvDM).RowHeadersWidth = 35;
		dgvDM.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvDM).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvDM;
		Size size = new Size(411, 134);
		((Control)asDataGridView2).Size = size;
		((Control)dgvDM).TabIndex = 47;
		((Control)chkAllActive).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllActive).AutoSize = true;
		((ButtonBase)chkAllActive).ImeMode = (ImeMode)0;
		CheckBox obj = chkAllActive;
		location = new Point(353, 143);
		((Control)obj).Location = location;
		((Control)chkAllActive).Name = "chkAllActive";
		CheckBox obj2 = chkAllActive;
		size = new Size(15, 14);
		((Control)obj2).Size = size;
		((Control)chkAllActive).TabIndex = 48;
		((DataGridViewColumn)ma_cty).DataPropertyName = "ma_cty";
		((DataGridViewColumn)ma_cty).Frozen = true;
		((DataGridViewColumn)ma_cty).HeaderText = "Mã cty";
		((DataGridViewColumn)ma_cty).Name = "ma_cty";
		((DataGridViewColumn)ma_cty).ReadOnly = true;
		((DataGridViewColumn)ma_cty).Width = 70;
		((DataGridViewColumn)Ten_cty).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Ten_cty).DataPropertyName = "ten_cty";
		((DataGridViewColumn)Ten_cty).FillWeight = 200f;
		((DataGridViewColumn)Ten_cty).Frozen = true;
		((DataGridViewColumn)Ten_cty).HeaderText = "Tên công ty";
		((DataGridViewColumn)Ten_cty).Name = "Ten_cty";
		((DataGridViewColumn)Ten_cty).ReadOnly = true;
		((DataGridViewColumn)Ten_cty).Width = 230;
		((DataGridViewColumn)dgvcCompanyViewRight).DataPropertyName = "Active";
		((DataGridViewColumn)dgvcCompanyViewRight).FillWeight = 15.03759f;
		((DataGridViewColumn)dgvcCompanyViewRight).HeaderText = "Chọn";
		((DataGridViewColumn)dgvcCompanyViewRight).Name = "dgvcCompanyViewRight";
		((DataGridViewColumn)dgvcCompanyViewRight).Width = 40;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)chkAllActive);
		((Control)this).Controls.Add((Control)(object)dgvDM);
		((Control)this).Name = "ucSmSetRightsCompany";
		size = new Size(417, 163);
		((Control)this).Size = size;
		((ISupportInitialize)dgvDM).EndInit();
		((ISupportInitialize)bsCompanyRight).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void GetData()
	{
		if (bsCompanyRight.DataSource == null)
		{
			f_oTblCompanyRight.TableName = "CompanyRight";
			f_oTblGrandCompanyRight.TableName = "GrandCompanyRight";
			DataSet dataSet = new DataSet();
			dataSet.Tables.Add(f_oTblCompanyRight);
			dataSet.Tables.Add(f_oTblGrandCompanyRight);
			bsCompanyRight.DataSource = dataSet;
			((DataGridView)dgvDM).DataSource = bsCompanyRight;
			((DataGridView)dgvDM).DataMember = "CompanyRight";
		}
	}

	public bool ProcessDB()
	{
		f_oTblCompanyRight.Rows[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index].EndEdit();
		if (f_oTblCompanyRight.GetChanges(DataRowState.Modified) == null)
		{
			return true;
		}
		try
		{
			foreach (DataRow row in f_oTblCompanyRight.GetChanges(DataRowState.Modified).Rows)
			{
				int num = MyController.InsRightCompany(Conversions.ToString(row["Ma_cty"]), f_strUserName, Conversions.ToString(row["Active"]));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		return true;
	}

	private void chkAllActive_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = chkAllActive.Checked;
		checked
		{
			int num = f_oTblCompanyRight.DefaultView.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Conversions.ToBoolean(f_oTblGrandCompanyRight.AsEnumerable().ElementAtOrDefault(i)["Active"]) | f_bIsAdmin)
				{
					f_oTblCompanyRight.DefaultView[i]["Active"] = flag;
				}
			}
			if (((DataGridView)dgvDM).CurrentCell != null)
			{
				((DataGridView)dgvDM).InvalidateRow(((DataGridView)dgvDM).CurrentCell.RowIndex);
			}
		}
	}

	private void dgvDM_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
	{
		if (!f_bIsAdmin && ((DataGridView)dgvDM).Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && !Conversions.ToBoolean(f_oTblGrandCompanyRight.AsEnumerable().ElementAtOrDefault(e.RowIndex)[((DataGridView)dgvDM).Columns[e.ColumnIndex].DataPropertyName]))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(f_oTblCompanyRight.Rows[e.RowIndex][((DataGridView)dgvDM).Columns[e.ColumnIndex].DataPropertyName]);
			f_oTblCompanyRight.Rows[e.RowIndex][((DataGridView)dgvDM).Columns[e.ColumnIndex].DataPropertyName] = RuntimeHelpers.GetObjectValue(objectValue);
		}
	}
}
