using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmOptFieldSetup : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdExit")]
	private Button _cmdExit;

	[AccessedThroughProperty("dgvOpt")]
	private AsDataGridView _dgvOpt;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("cmdSua")]
	private Button _cmdSua;

	[AccessedThroughProperty("cmdHuy")]
	private Button _cmdHuy;

	[AccessedThroughProperty("cboChung_tu")]
	private AsComboBox _cboChung_tu;

	[AccessedThroughProperty("Column5")]
	private DataGridViewTextBoxColumn _Column5;

	[AccessedThroughProperty("Column8")]
	private DataGridViewTextBoxColumn _Column8;

	[AccessedThroughProperty("Column4")]
	private DataGridViewTextBoxColumn _Column4;

	[AccessedThroughProperty("Column6")]
	private DataGridViewTextBoxColumn _Column6;

	[AccessedThroughProperty("Column7")]
	private DataGridViewTextBoxColumn _Column7;

	[AccessedThroughProperty("Column9")]
	private DataGridViewTextBoxColumn _Column9;

	[AccessedThroughProperty("Column1")]
	private DataGridViewTextBoxColumn _Column1;

	[AccessedThroughProperty("Column2")]
	private DataGridViewCheckBoxColumn _Column2;

	[AccessedThroughProperty("Column3")]
	private DataGridViewCheckBoxColumn _Column3;

	private DataTable f_dmopt;

	private DataTable f_oTblCbo;

	internal virtual Button cmdOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOk_Click;
			if (_cmdOk != null)
			{
				((Control)_cmdOk).Click -= eventHandler;
			}
			_cmdOk = value;
			if (_cmdOk != null)
			{
				((Control)_cmdOk).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdExit_Click;
			if (_cmdExit != null)
			{
				((Control)_cmdExit).Click -= eventHandler;
			}
			_cmdExit = value;
			if (_cmdExit != null)
			{
				((Control)_cmdExit).Click += eventHandler;
			}
		}
	}

	internal virtual AsDataGridView dgvOpt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvOpt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvOpt = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Button cmdSua
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSua;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdSua_Click;
			if (_cmdSua != null)
			{
				((Control)_cmdSua).Click -= eventHandler;
			}
			_cmdSua = value;
			if (_cmdSua != null)
			{
				((Control)_cmdSua).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdHuy
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdHuy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdHuy_Click;
			if (_cmdHuy != null)
			{
				((Control)_cmdHuy).Click -= eventHandler;
			}
			_cmdHuy = value;
			if (_cmdHuy != null)
			{
				((Control)_cmdHuy).Click += eventHandler;
			}
		}
	}

	internal virtual AsComboBox cboChung_tu
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboChung_tu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboChung_tu_SelectedIndexChanged;
			if (_cboChung_tu != null)
			{
				((ComboBox)_cboChung_tu).SelectedIndexChanged -= eventHandler;
			}
			_cboChung_tu = value;
			if (_cboChung_tu != null)
			{
				((ComboBox)_cboChung_tu).SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn Column5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column5 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column8 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column4 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column6 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column7 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column9 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column1 = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn Column2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column2 = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn Column3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column3 = value;
		}
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
			base.Dispose(disposing);
		}
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
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		cmdOk = new Button();
		cmdExit = new Button();
		dgvOpt = new AsDataGridView();
		Label1 = new Label();
		cmdSua = new Button();
		cmdHuy = new Button();
		cboChung_tu = new AsComboBox();
		Column5 = new DataGridViewTextBoxColumn();
		Column8 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		Column9 = new DataGridViewTextBoxColumn();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewCheckBoxColumn();
		Column3 = new DataGridViewCheckBoxColumn();
		((ISupportInitialize)dgvOpt).BeginInit();
		((Control)this).SuspendLayout();
		((Control)cmdOk).Anchor = (AnchorStyles)6;
		Button obj = cmdOk;
		Point location = new Point(3, 291);
		((Control)obj).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		Button obj2 = cmdOk;
		Size size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)cmdOk).TabIndex = 1;
		((ButtonBase)cmdOk).Text = "&Lưu";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = true;
		((Control)cmdOk).Visible = false;
		((Control)cmdExit).Anchor = (AnchorStyles)6;
		cmdExit.DialogResult = (DialogResult)2;
		Button obj3 = cmdExit;
		location = new Point(84, 291);
		((Control)obj3).Location = location;
		((Control)cmdExit).Name = "cmdExit";
		Button obj4 = cmdExit;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)cmdExit).TabIndex = 2;
		((ButtonBase)cmdExit).Text = "&Quay ra";
		((ButtonBase)cmdExit).UseVisualStyleBackColor = true;
		((DataGridView)dgvOpt).AllowUserToAddRows = false;
		((DataGridView)dgvOpt).AllowUserToDeleteRows = false;
		((Control)dgvOpt).Anchor = (AnchorStyles)15;
		((DataGridView)dgvOpt).BackgroundColor = Color.White;
		((DataGridView)dgvOpt).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvOpt).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvOpt).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[9]
		{
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Column8,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column6,
			(DataGridViewColumn)Column7,
			(DataGridViewColumn)Column9,
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3
		});
		((DataGridView)dgvOpt).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvOpt).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvOpt;
		location = new Point(8, 44);
		((Control)asDataGridView).Location = location;
		((Control)dgvOpt).Name = "dgvOpt";
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvOpt).RowHeadersDefaultCellStyle = val;
		dgvOpt.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvOpt).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvOpt;
		size = new Size(651, 241);
		((Control)asDataGridView2).Size = size;
		((Control)dgvOpt).TabIndex = 3;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(5, 18);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(50, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 5;
		Label1.Text = "Chứng từ";
		((Control)cmdSua).Anchor = (AnchorStyles)6;
		Button obj5 = cmdSua;
		location = new Point(3, 291);
		((Control)obj5).Location = location;
		((Control)cmdSua).Name = "cmdSua";
		Button obj6 = cmdSua;
		size = new Size(75, 23);
		((Control)obj6).Size = size;
		((Control)cmdSua).TabIndex = 6;
		((ButtonBase)cmdSua).Text = "&Sửa";
		((ButtonBase)cmdSua).UseVisualStyleBackColor = true;
		((Control)cmdHuy).Anchor = (AnchorStyles)6;
		Button obj7 = cmdHuy;
		location = new Point(84, 291);
		((Control)obj7).Location = location;
		((Control)cmdHuy).Name = "cmdHuy";
		Button obj8 = cmdHuy;
		size = new Size(75, 23);
		((Control)obj8).Size = size;
		((Control)cmdHuy).TabIndex = 7;
		((ButtonBase)cmdHuy).Text = "&Hủy";
		((ButtonBase)cmdHuy).UseVisualStyleBackColor = true;
		((Control)cmdHuy).Visible = false;
		((ComboBox)cboChung_tu).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboChung_tu).FormattingEnabled = true;
		AsComboBox asComboBox = cboChung_tu;
		location = new Point(61, 15);
		((Control)asComboBox).Location = location;
		((Control)cboChung_tu).Name = "cboChung_tu";
		AsComboBox asComboBox2 = cboChung_tu;
		size = new Size(196, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboChung_tu).TabIndex = 8;
		((DataGridViewColumn)Column5).DataPropertyName = "Stt";
		((DataGridViewColumn)Column5).HeaderText = "Stt";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewColumn)Column5).Visible = false;
		((DataGridViewColumn)Column8).DataPropertyName = "Caption";
		((DataGridViewColumn)Column8).HeaderText = "Tiêu đề";
		((DataGridViewColumn)Column8).Name = "Column8";
		((DataGridViewColumn)Column8).ReadOnly = true;
		((DataGridViewColumn)Column8).Width = 200;
		((DataGridViewColumn)Column4).DataPropertyName = "Field";
		((DataGridViewColumn)Column4).HeaderText = "Tên trường";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewColumn)Column4).ReadOnly = true;
		((DataGridViewColumn)Column4).Width = 200;
		((DataGridViewColumn)Column6).DataPropertyName = "descrpt";
		((DataGridViewColumn)Column6).HeaderText = "Column6";
		((DataGridViewColumn)Column6).Name = "Column6";
		((DataGridViewColumn)Column6).Visible = false;
		((DataGridViewColumn)Column7).DataPropertyName = "length";
		((DataGridViewColumn)Column7).HeaderText = "Column7";
		((DataGridViewColumn)Column7).Name = "Column7";
		((DataGridViewColumn)Column7).Visible = false;
		((DataGridViewColumn)Column9).DataPropertyName = "LUser";
		((DataGridViewColumn)Column9).HeaderText = "Column9";
		((DataGridViewColumn)Column9).Name = "Column9";
		((DataGridViewColumn)Column9).Visible = false;
		((DataGridViewColumn)Column1).DataPropertyName = "Voucher_code";
		((DataGridViewColumn)Column1).HeaderText = "Column1";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewColumn)Column1).Visible = false;
		((DataGridViewColumn)Column2).DataPropertyName = "Master";
		Column2.FalseValue = "0";
		((DataGridViewColumn)Column2).HeaderText = "Thông tin chung";
		((DataGridViewColumn)Column2).Name = "Column2";
		Column2.TrueValue = "1";
		((DataGridViewColumn)Column3).DataPropertyName = "Detail";
		Column3.FalseValue = "0";
		((DataGridViewColumn)Column3).HeaderText = "Chi tiết";
		((DataGridViewColumn)Column3).Name = "Column3";
		Column3.TrueValue = "1";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOk;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)cmdExit;
		size = new Size(666, 321);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cboChung_tu);
		((Control)this).Controls.Add((Control)(object)cmdHuy);
		((Control)this).Controls.Add((Control)(object)cmdSua);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)dgvOpt);
		((Control)this).Controls.Add((Control)(object)cmdExit);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Name = "frmOptFieldSetup";
		((Form)this).Text = "Khai báo các trường tự do cho các ctừ";
		((ISupportInitialize)dgvOpt).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public frmOptFieldSetup(string menuid)
		: base(menuid)
	{
		((Form)this).Load += frmOptFieldSetup_Load;
		InitializeComponent();
	}

	private void cmdExit_Click(object sender, EventArgs e)
	{
		((Component)(object)this).Dispose();
	}

	private void InitCboChung_tu()
	{
		FieldSetupDAO fieldSetupDAO = (FieldSetupDAO)DAOFactory.CreateDAOInstance("FieldSetupDAO", "OptFieldSetup");
		f_oTblCbo = fieldSetupDAO.GetCt(CompanyInformations.CompanyID, "");
		f_oTblCbo.Columns.Add("Maten_ct", Type.GetType("System.String"), "[ma_ct] + ' - ' + [ten_ct]");
		((ListControl)cboChung_tu).DisplayMember = "Maten_ct";
		((ListControl)cboChung_tu).ValueMember = "ma_ct";
		((ComboBox)cboChung_tu).DataSource = f_oTblCbo;
		fieldSetupDAO.Destroy();
	}

	private void cmdOk_Click(object sender, EventArgs e)
	{
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		DataRow[] array = f_dmopt.Select("", "", DataViewRowState.ModifiedCurrent);
		FieldSetupDAO fieldSetupDAO = (FieldSetupDAO)DAOFactory.CreateDAOInstance("FieldSetupDAO", "OptFieldSetup", a_blnIsSysDB: true);
		bool flag = true;
		DataRow[] array2 = array;
		foreach (DataRow dataRow in array2)
		{
			if (flag)
			{
				fieldSetupDAO.DelFieldSetup(Conversions.ToString(((ListControl)cboChung_tu).SelectedValue), Conversions.ToString(dataRow["Field"]));
				continue;
			}
			flag = false;
			break;
		}
		DataRow[] array3 = array;
		foreach (DataRow dataRow2 in array3)
		{
			if (flag)
			{
				fieldSetupDAO.InsFieldSetup(Conversions.ToString(((ListControl)cboChung_tu).SelectedValue), Conversions.ToString(dataRow2["Field"]), Conversions.ToString(dataRow2["Master"]), Conversions.ToString(dataRow2["Detail"]));
				continue;
			}
			flag = false;
			break;
		}
		CMessageBox.Show(50015);
		((Control)cmdOk).Visible = false;
		((Control)cmdHuy).Visible = false;
		((Control)cmdSua).Visible = true;
		((Control)cmdExit).Visible = true;
		((Control)cboChung_tu).Enabled = true;
		dgvOpt.ReadOnly = true;
		fieldSetupDAO.Destroy();
	}

	private void cmdSua_Click(object sender, EventArgs e)
	{
		((Control)cmdSua).Visible = false;
		((Control)cmdOk).Visible = true;
		((Control)cmdHuy).Visible = true;
		((Control)cboChung_tu).Enabled = false;
		dgvOpt.ReadOnly = false;
	}

	private void frmOptFieldSetup_Load(object sender, EventArgs e)
	{
		((DataGridView)dgvOpt).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
		FieldSetupDAO fieldSetupDAO = (FieldSetupDAO)DAOFactory.CreateDAOInstance("FieldSetupDAO", "OptFieldSetup", a_blnIsSysDB: true);
		f_dmopt = fieldSetupDAO.GetFieldInfo();
		((DataGridView)dgvOpt).DataSource = f_dmopt;
		InitCboChung_tu();
		dgvOpt.ReadOnly = true;
	}

	private void cmdHuy_Click(object sender, EventArgs e)
	{
		((Control)cboChung_tu).Enabled = true;
		((Control)cmdHuy).Visible = false;
		((Control)cmdOk).Visible = false;
		((Control)cmdSua).Visible = true;
	}

	private void cboChung_tu_SelectedIndexChanged(object sender, EventArgs e)
	{
		FieldSetupDAO fieldSetupDAO = (FieldSetupDAO)DAOFactory.CreateDAOInstance("FieldSetupDAO", "OptFieldSetup", a_blnIsSysDB: true);
		if (f_dmopt != null)
		{
			f_dmopt.Dispose();
		}
		f_dmopt = fieldSetupDAO.GetFieldInfo();
		f_dmopt.Columns.Add("Voucher_code");
		f_dmopt.Columns.Add("Master");
		f_dmopt.Columns.Add("detail");
		f_dmopt.DefaultView.AllowDelete = false;
		f_dmopt.DefaultView.AllowNew = false;
		DataTable fieldSetup = fieldSetupDAO.GetFieldSetup(Conversions.ToString(((ListControl)cboChung_tu).SelectedValue));
		checked
		{
			int num = f_dmopt.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				f_dmopt.Rows[i]["detail"] = 0;
				f_dmopt.Rows[i]["Master"] = 0;
				f_dmopt.Rows[i]["Voucher_code"] = RuntimeHelpers.GetObjectValue(((ListControl)cboChung_tu).SelectedValue);
				int num2 = fieldSetup.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (Operators.ConditionalCompareObjectEqual(fieldSetup.Rows[j]["Field"], f_dmopt.Rows[i]["Field"], false))
					{
						f_dmopt.Rows[i]["detail"] = RuntimeHelpers.GetObjectValue(fieldSetup.Rows[j]["detail"]);
						f_dmopt.Rows[i]["Master"] = RuntimeHelpers.GetObjectValue(fieldSetup.Rows[j]["Master"]);
						break;
					}
				}
			}
			((DataGridView)dgvOpt).DataSource = f_dmopt;
			fieldSetupDAO.Destroy();
		}
	}
}
