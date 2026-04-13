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
public class frmSISysvars : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("agdSysVar")]
	private AsDataGridView _agdSysVar;

	[AccessedThroughProperty("txtFieldName")]
	private TextBox _txtFieldName;

	[AccessedThroughProperty("Status")]
	private StatusStrip _Status;

	[AccessedThroughProperty("txtDescription")]
	private TextBox _txtDescription;

	[AccessedThroughProperty("Column1")]
	private DataGridViewTextBoxColumn _Column1;

	[AccessedThroughProperty("Column2")]
	private DataGridViewTextBoxColumn _Column2;

	[AccessedThroughProperty("Column3")]
	private DataGridViewTextBoxColumn _Column3;

	[AccessedThroughProperty("Column4")]
	private DataGridViewTextBoxColumn _Column4;

	[AccessedThroughProperty("Column5")]
	private DataGridViewTextBoxColumn _Column5;

	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[AccessedThroughProperty("txtValue")]
	private TextBox _txtValue;

	private DataTable MySource;

	private string EDIT_TEXT;

	private string SAVE_TEXT;

	internal virtual AsDataGridView agdSysVar
	{
		get
		{
			return _agdSysVar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			EventHandler eventHandler = agdSysVar_SelectionChanged;
			DataGridViewCellFormattingEventHandler val = new DataGridViewCellFormattingEventHandler(agdSysVar_CellFormatting);
			EventHandler eventHandler2 = agdSysVar_Click;
			KeyEventHandler val2 = new KeyEventHandler(agdSysVar_KeyUp);
			if (_agdSysVar != null)
			{
				((DataGridView)_agdSysVar).SelectionChanged -= eventHandler;
				((DataGridView)_agdSysVar).CellFormatting -= val;
				((Control)_agdSysVar).Click -= eventHandler2;
				((Control)_agdSysVar).KeyUp -= val2;
			}
			_agdSysVar = value;
			if (_agdSysVar != null)
			{
				((DataGridView)_agdSysVar).SelectionChanged += eventHandler;
				((DataGridView)_agdSysVar).CellFormatting += val;
				((Control)_agdSysVar).Click += eventHandler2;
				((Control)_agdSysVar).KeyUp += val2;
			}
		}
	}

	internal virtual TextBox txtFieldName
	{
		get
		{
			return _txtFieldName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtFieldName = value;
		}
	}

	internal virtual StatusStrip Status
	{
		get
		{
			return _Status;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Status = value;
		}
	}

	internal virtual TextBox txtDescription
	{
		get
		{
			return _txtDescription;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtDescription = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column1
	{
		get
		{
			return _Column1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Column1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column2
	{
		get
		{
			return _Column2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Column2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column3
	{
		get
		{
			return _Column3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Column3 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column4
	{
		get
		{
			return _Column4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Column4 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column5
	{
		get
		{
			return _Column5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Column5 = value;
		}
	}

	internal virtual Button btnSave
	{
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnSave_Click;
			if (_btnSave != null)
			{
				((Control)_btnSave).Click -= eventHandler;
			}
			_btnSave = value;
			if (_btnSave != null)
			{
				((Control)_btnSave).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox txtValue
	{
		get
		{
			return _txtValue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtValue = value;
		}
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

	public frmSISysvars(string MenuId)
		: base(MenuId)
	{
		((Form)this).Load += frmSISysvars_Load;
		EDIT_TEXT = "&Sửa";
		SAVE_TEXT = "&Lưu";
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		agdSysVar = new AsDataGridView();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		txtFieldName = new TextBox();
		Status = new StatusStrip();
		txtDescription = new TextBox();
		btnSave = new Button();
		txtValue = new TextBox();
		((ISupportInitialize)agdSysVar).BeginInit();
		((Control)this).SuspendLayout();
		((DataGridView)agdSysVar).AllowUserToAddRows = false;
		((DataGridView)agdSysVar).AllowUserToDeleteRows = false;
		((Control)agdSysVar).Anchor = (AnchorStyles)15;
		((DataGridView)agdSysVar).BackgroundColor = Color.White;
		((DataGridView)agdSysVar).BorderStyle = (BorderStyle)2;
		((DataGridView)agdSysVar).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)agdSysVar).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column5
		});
		agdSysVar.DoubleBuffered = false;
		((DataGridView)agdSysVar).EditMode = (DataGridViewEditMode)0;
		((DataGridView)agdSysVar).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = agdSysVar;
		Point location = new Point(4, 3);
		((Control)asDataGridView).Location = location;
		((Control)agdSysVar).Name = "agdSysVar";
		agdSysVar.ReadOnly = true;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)agdSysVar).RowHeadersDefaultCellStyle = val;
		agdSysVar.RowIndex2StartFillOrdinalNumber = 1u;
		val2.SelectionBackColor = Color.FromArgb(192, 192, 255);
		((DataGridView)agdSysVar).RowsDefaultCellStyle = val2;
		((DataGridView)agdSysVar).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = agdSysVar;
		Size size = new Size(638, 212);
		((Control)asDataGridView2).Size = size;
		((Control)agdSysVar).TabIndex = 0;
		((DataGridViewColumn)Column1).DataPropertyName = "varName";
		((DataGridViewColumn)Column1).HeaderText = "Column1";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewColumn)Column1).ReadOnly = true;
		((DataGridViewColumn)Column1).Visible = false;
		((DataGridViewColumn)Column2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)Column2).DataPropertyName = "varDescrpt";
		((DataGridViewColumn)Column2).HeaderText = "Tên tham số";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewColumn)Column2).ReadOnly = true;
		((DataGridViewColumn)Column3).DataPropertyName = "varValue";
		((DataGridViewColumn)Column3).HeaderText = "Giá trị";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewColumn)Column3).Width = 285;
		((DataGridViewColumn)Column4).DataPropertyName = "varType";
		((DataGridViewColumn)Column4).HeaderText = "Column4";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewColumn)Column4).ReadOnly = true;
		((DataGridViewColumn)Column4).Visible = false;
		((DataGridViewColumn)Column5).DataPropertyName = "maxlength";
		((DataGridViewColumn)Column5).HeaderText = "Column5";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewColumn)Column5).ReadOnly = true;
		((DataGridViewColumn)Column5).Visible = false;
		((Control)txtFieldName).Anchor = (AnchorStyles)14;
		TextBox obj = txtFieldName;
		location = new Point(4, 221);
		((Control)obj).Location = location;
		((Control)txtFieldName).Name = "txtFieldName";
		((TextBoxBase)txtFieldName).ReadOnly = true;
		TextBox obj2 = txtFieldName;
		size = new Size(416, 20);
		((Control)obj2).Size = size;
		((Control)txtFieldName).TabIndex = 1;
		((TextBoxBase)txtFieldName).WordWrap = false;
		StatusStrip status = Status;
		location = new Point(0, 364);
		((Control)status).Location = location;
		((Control)Status).Name = "Status";
		StatusStrip status2 = Status;
		size = new Size(647, 22);
		((Control)status2).Size = size;
		((Control)Status).TabIndex = 6;
		((Control)Status).Text = "StatusStrip1";
		((Control)txtDescription).Anchor = (AnchorStyles)14;
		TextBox obj3 = txtDescription;
		location = new Point(4, 247);
		((Control)obj3).Location = location;
		txtDescription.Multiline = true;
		((Control)txtDescription).Name = "txtDescription";
		((TextBoxBase)txtDescription).ReadOnly = true;
		txtDescription.ScrollBars = (ScrollBars)3;
		TextBox obj4 = txtDescription;
		size = new Size(638, 114);
		((Control)obj4).Size = size;
		((Control)txtDescription).TabIndex = 8;
		((Control)btnSave).Anchor = (AnchorStyles)10;
		Button obj5 = btnSave;
		location = new Point(584, 220);
		((Control)obj5).Location = location;
		((Control)btnSave).Name = "btnSave";
		Button obj6 = btnSave;
		size = new Size(59, 23);
		((Control)obj6).Size = size;
		((Control)btnSave).TabIndex = 9;
		((Control)btnSave).Tag = "0";
		((ButtonBase)btnSave).Text = "&Sửa";
		((ButtonBase)btnSave).UseVisualStyleBackColor = true;
		((Control)txtValue).Anchor = (AnchorStyles)10;
		TextBox obj7 = txtValue;
		location = new Point(421, 221);
		((Control)obj7).Location = location;
		((Control)txtValue).Name = "txtValue";
		((TextBoxBase)txtValue).ReadOnly = true;
		TextBox obj8 = txtValue;
		size = new Size(161, 20);
		((Control)obj8).Size = size;
		((Control)txtValue).TabIndex = 10;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(647, 386);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtValue);
		((Control)this).Controls.Add((Control)(object)btnSave);
		((Control)this).Controls.Add((Control)(object)txtDescription);
		((Control)this).Controls.Add((Control)(object)txtFieldName);
		((Control)this).Controls.Add((Control)(object)Status);
		((Control)this).Controls.Add((Control)(object)agdSysVar);
		((Control)this).Name = "frmSISysvars";
		((ISupportInitialize)agdSysVar).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void GetLangResx()
	{
		EDIT_TEXT = AsiaErp.Framework.Environment.getLangFrameworkResX("#SISYSVAR_EDIT_TEXT");
		SAVE_TEXT = AsiaErp.Framework.Environment.getLangFrameworkResX("#SISYSVAR_SAVE_TEXT");
	}

	private void get_data()
	{
		if (((DataGridView)agdSysVar).RowCount != 0)
		{
			txtFieldName.Text = ((DataGridView)agdSysVar).CurrentRow.Cells[1].Value.ToString();
			txtValue.Text = Conversions.ToString(NewLateBinding.LateIndexGet(((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)agdSysVar).DataSource)].Current, new object[1] { "varValue" }, (string[])null));
			txtDescription.Text = Conversions.ToString(NewLateBinding.LateIndexGet(((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)agdSysVar).DataSource)].Current, new object[1] { "Description" }, (string[])null));
		}
	}

	private void load_data()
	{
		SISysvarsDAO sISysvarsDAO = (SISysvarsDAO)DAOFactory.CreateDAOInstance("SISysvarsDAO", "SISysvars");
		MySource = sISysvarsDAO.GetSISSysvars(CompanyInformations.CompanyID, MyMenuInfo.moduleid, SystemInformations.CurrentCultureName);
		((DataGridView)agdSysVar).DataSource = MySource;
	}

	private void agdSysVar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(MySource.Rows[e.RowIndex]["isEdit"], (object)0, false) && ((ConvertEventArgs)e).Value != null)
		{
			((DataGridView)agdSysVar).Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Gray;
		}
	}

	private void Save_Click()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (((DataGridView)agdSysVar).DataSource != null)
			{
				SISysvarsDAO sISysvarsDAO = (SISysvarsDAO)DAOFactory.CreateDAOInstance("SISysvarsDAO", "SISysvars");
				DataTable dataTable = (DataTable)((DataGridView)agdSysVar).DataSource;
				DataRowView dataRowView = (DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)agdSysVar).DataSource)].Current;
				string text = Conversions.ToString(dataRowView["varName"]);
				string text2 = txtValue.Text;
				int num = sISysvarsDAO.UpdSISysvars(CompanyInformations.CompanyID, MyMenuInfo.par1, text, text2);
				if (num == 1)
				{
					dataRowView["varValue"] = txtValue.Text;
					dataTable.AcceptChanges();
				}
				AsiaErp.Framework.Environment.RefreshConfiguration(MyMenuInfo.moduleid);
				CMessageBox.Show(50015);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(50034);
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void agdSysVar_Click(object sender, EventArgs e)
	{
	}

	private void agdSysVar_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		if (((DataGridView)agdSysVar).RowCount != 0 && ((int)e.KeyCode == 38 || (int)e.KeyCode == 40))
		{
			agdSysVar_Click(null, null);
		}
	}

	private void agdSysVar_SelectionChanged(object sender, EventArgs e)
	{
		if (((DataGridView)agdSysVar).DataSource != null)
		{
			get_data();
		}
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		if (((Message)(ref msg)).WParam == (IntPtr)27 && Operators.ConditionalCompareObjectEqual(((Control)btnSave).Tag, (object)0, false))
		{
			((Form)this).Close();
		}
		else if (((Message)(ref msg)).WParam == (IntPtr)27 && Operators.ConditionalCompareObjectEqual(((Control)btnSave).Tag, (object)1, false))
		{
			((TextBoxBase)txtValue).ReadOnly = true;
			((Control)btnSave).Tag = 0;
			((ButtonBase)btnSave).Text = "&Sửa";
			((Control)agdSysVar).Enabled = true;
			get_data();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(((Control)btnSave).Tag, (object)0, false))
		{
			DataRowView dataRowView = (DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)agdSysVar).DataSource)].Current;
			if (Operators.ConditionalCompareObjectEqual(dataRowView["IsEdit"], (object)0, false))
			{
				CMessageBox.Show(50193);
				return;
			}
			((TextBoxBase)txtValue).ReadOnly = false;
			((Control)btnSave).Tag = 1;
			((ButtonBase)btnSave).Text = SAVE_TEXT;
			((Control)agdSysVar).Enabled = false;
		}
		else
		{
			Save_Click();
			((TextBoxBase)txtValue).ReadOnly = true;
			((Control)btnSave).Tag = 0;
			((ButtonBase)btnSave).Text = EDIT_TEXT;
			((Control)agdSysVar).Enabled = true;
		}
	}

	private void frmSISysvars_Load(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		if (!((Component)(object)this).DesignMode)
		{
			((Form)this).Text = MyMenuInfo.bar;
			ToolStripStatusLabel val = new ToolStripStatusLabel();
			val.Spring = true;
			((ToolStripItem)val).Text = CompanyInformations.CompanyName;
			((ToolStripItem)val).TextAlign = (ContentAlignment)16;
			((ToolStrip)Status).Items.Add((ToolStripItem)(object)val);
			((ToolStrip)Status).Items.Add("|");
			((ToolStrip)Status).Items[1].ForeColor = Color.Gray;
			((ToolStrip)Status).Items.Add(CompanyInformations.CompanyID);
			((ToolStrip)Status).Items.Add("|");
			((ToolStrip)Status).Items[3].ForeColor = Color.Gray;
			((ToolStrip)Status).Items.Add(Conversions.ToString(SystemInformations.FinancialYear));
			((ToolStrip)Status).Items.Add("|");
			((ToolStrip)Status).Items[5].ForeColor = Color.Gray;
			((ToolStrip)Status).Items.Add(SystemInformations.UserName);
			((ToolStrip)Status).Items.Add("|");
			((ToolStrip)Status).Items[7].ForeColor = Color.Gray;
			load_data();
			GetLangResx();
			((ButtonBase)btnSave).Text = EDIT_TEXT;
			agdSysVar_Click(null, null);
		}
	}
}
