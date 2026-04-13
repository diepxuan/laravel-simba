using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSITrim_Ma : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("dgvDM")]
	private AsDataGridView _dgvDM;

	[AccessedThroughProperty("colSelect")]
	private DataGridViewCheckBoxColumn _colSelect;

	[AccessedThroughProperty("colMa")]
	private DataGridViewTextBoxColumn _colMa;

	private DataTable f_tblDmMa;

	internal virtual Button cmdOK
	{
		get
		{
			return _cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdOK_Click;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click -= eventHandler;
			}
			_cmdOK = value;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdCancel
	{
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdCancel_Click;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).Click -= eventHandler;
			}
			_cmdCancel = value;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).Click += eventHandler;
			}
		}
	}

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual AsDataGridView dgvDM
	{
		get
		{
			return _dgvDM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvDM = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn colSelect
	{
		get
		{
			return _colSelect;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colSelect = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn colMa
	{
		get
		{
			return _colMa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_colMa = value;
		}
	}

	public frmSITrim_Ma()
	{
		((Form)this).Load += frmTrim_Ma_Load;
		f_tblDmMa = new DataTable();
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		cmdOK = new Button();
		cmdCancel = new Button();
		GroupBox1 = new GroupBox();
		dgvDM = new AsDataGridView();
		colSelect = new DataGridViewCheckBoxColumn();
		colMa = new DataGridViewTextBoxColumn();
		((ISupportInitialize)dgvDM).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdOK).Anchor = (AnchorStyles)6;
		Button obj = cmdOK;
		Point location = new Point(5, 264);
		((Control)obj).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		Button obj2 = cmdOK;
		Size size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)cmdOK).TabIndex = 0;
		((ButtonBase)cmdOK).Text = "&Thực hiện";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = true;
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		Button obj3 = cmdCancel;
		location = new Point(86, 264);
		((Control)obj3).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj4 = cmdCancel;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)cmdCancel).TabIndex = 1;
		((ButtonBase)cmdCancel).Text = "&Hủy bỏ";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = true;
		((Control)GroupBox1).Anchor = (AnchorStyles)14;
		GroupBox groupBox = GroupBox1;
		location = new Point(-4, 249);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(620, 10);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 1;
		GroupBox1.TabStop = false;
		((DataGridView)dgvDM).AllowUserToAddRows = false;
		((DataGridView)dgvDM).AllowUserToDeleteRows = false;
		((DataGridView)dgvDM).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvDM).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvDM).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		((DataGridView)dgvDM).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvDM).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)colSelect,
			(DataGridViewColumn)colMa
		});
		((DataGridView)dgvDM).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvDM).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvDM;
		location = new Point(5, 3);
		((Control)asDataGridView).Location = location;
		((Control)dgvDM).Name = "dgvDM";
		((DataGridView)dgvDM).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvDM).RowHeadersDefaultCellStyle = val;
		dgvDM.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvDM).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvDM;
		size = new Size(604, 245);
		((Control)asDataGridView2).Size = size;
		((Control)dgvDM).TabIndex = 2;
		((DataGridViewColumn)colSelect).DataPropertyName = "chon";
		colSelect.FalseValue = "0";
		((DataGridViewColumn)colSelect).HeaderText = "Chọn";
		((DataGridViewColumn)colSelect).Name = "colSelect";
		colSelect.TrueValue = "1";
		((DataGridViewColumn)colMa).DataPropertyName = "ma";
		((DataGridViewColumn)colMa).HeaderText = "Tên mã";
		((DataGridViewColumn)colMa).Name = "colMa";
		((DataGridViewColumn)colMa).ReadOnly = true;
		((DataGridViewColumn)colMa).Width = 200;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(613, 296);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)dgvDM);
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSITrim_Ma";
		((Form)this).Text = "Trim các loại mã";
		((ISupportInitialize)dgvDM).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmTrim_Ma_Load(object sender, EventArgs e)
	{
		((DataGridView)dgvDM).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
		GetData();
	}

	private void GetData()
	{
		ISIMaintainDAO iSIMaintainDAO = (ISIMaintainDAO)DAOFactory.CreateDAOInstance("SIMaintainDAO", "SIMaintain");
		f_tblDmMa = iSIMaintainDAO.GetDSMa();
		iSIMaintainDAO.Destroy();
		((DataGridView)dgvDM).DataSource = f_tblDmMa;
		if (((DataGridView)dgvDM).RowCount == 0)
		{
			((Control)cmdOK).Enabled = false;
		}
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		DataRow[] array = f_tblDmMa.Select("chon='1'");
		if (array.Count() == 0)
		{
			CMessageBox.Show(50087);
			return;
		}
		((Control)cmdOK).Enabled = false;
		StringBuilder stringBuilder = new StringBuilder();
		DataRow[] array2 = array;
		foreach (DataRow dataRow in array2)
		{
			stringBuilder.Append(RuntimeHelpers.GetObjectValue(dataRow["ma"]));
			stringBuilder.Append(",");
		}
		stringBuilder.Append(",");
		ISIMaintainDAO iSIMaintainDAO = (ISIMaintainDAO)DAOFactory.CreateDAOInstance("SIMaintainDAO", "SIMaintain");
		if (iSIMaintainDAO.ExecuteDelSpace(CompanyInformations.CompanyID, stringBuilder.ToString()) == 0)
		{
			CMessageBox.Show(50015);
		}
		else
		{
			CMessageBox.Show(50010);
		}
		iSIMaintainDAO.Destroy();
		((Form)this).Close();
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
