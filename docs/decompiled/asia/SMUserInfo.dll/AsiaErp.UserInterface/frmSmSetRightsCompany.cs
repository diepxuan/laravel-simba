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
using My.Resources;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSmSetRightsCompany : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("cmdSave")]
	private Button _cmdSave;

	[AccessedThroughProperty("chkAllActive")]
	private CheckBox _chkAllActive;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("lblTen")]
	private Label _lblTen;

	[AccessedThroughProperty("dgvDM")]
	private AsDataGridView _dgvDM;

	[AccessedThroughProperty("ma_cty")]
	private DataGridViewTextBoxColumn _ma_cty;

	[AccessedThroughProperty("Ten_cty")]
	private DataGridViewTextBoxColumn _Ten_cty;

	[AccessedThroughProperty("dgvcViewRight")]
	private DataGridViewCheckBoxColumn _dgvcViewRight;

	private DataTable f_oTblCompanyRight;

	private DataTable f_oTblGrandCompanyRight;

	internal string f_strUserName;

	internal string f_strFullUserName;

	private SMUserInfoController f_oController;

	internal string f_strGrandCompanyRight;

	internal bool f_bIsAdmin;

	internal virtual Panel Panel1
	{
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel1 = value;
		}
	}

	protected internal virtual Button cmdClose
	{
		get
		{
			return _cmdClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdClose_Click;
			if (_cmdClose != null)
			{
				((Control)_cmdClose).Click -= eventHandler;
			}
			_cmdClose = value;
			if (_cmdClose != null)
			{
				((Control)_cmdClose).Click += eventHandler;
			}
		}
	}

	protected virtual Button cmdSave
	{
		get
		{
			return _cmdSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdSave_Click;
			if (_cmdSave != null)
			{
				((Control)_cmdSave).Click -= eventHandler;
			}
			_cmdSave = value;
			if (_cmdSave != null)
			{
				((Control)_cmdSave).Click += eventHandler;
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

	internal virtual Panel Panel2
	{
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual Label lblTen
	{
		get
		{
			return _lblTen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen = value;
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

	internal virtual DataGridViewCheckBoxColumn dgvcViewRight
	{
		get
		{
			return _dgvcViewRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dgvcViewRight = value;
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

	public frmSmSetRightsCompany()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).Load += frmSmSetRightsCompany_Load;
		((Control)this).KeyDown += new KeyEventHandler(frmSmSetRightsCompany_KeyDown);
		f_oController = null;
		f_strGrandCompanyRight = "";
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		Panel1 = new Panel();
		lblTen = new Label();
		cmdClose = new Button();
		cmdSave = new Button();
		chkAllActive = new CheckBox();
		Panel2 = new Panel();
		dgvDM = new AsDataGridView();
		ma_cty = new DataGridViewTextBoxColumn();
		Ten_cty = new DataGridViewTextBoxColumn();
		dgvcViewRight = new DataGridViewCheckBoxColumn();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)dgvDM).BeginInit();
		((Control)this).SuspendLayout();
		Panel1.BorderStyle = (BorderStyle)2;
		((Control)Panel1).Controls.Add((Control)(object)lblTen);
		((Control)Panel1).Controls.Add((Control)(object)cmdClose);
		((Control)Panel1).Controls.Add((Control)(object)cmdSave);
		((Control)Panel1).Controls.Add((Control)(object)chkAllActive);
		((Control)Panel1).Dock = (DockStyle)2;
		Panel panel = Panel1;
		Point location = new Point(0, 295);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		Size size = new Size(599, 34);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 46;
		((Control)lblTen).Anchor = (AnchorStyles)6;
		((Control)lblTen).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj = lblTen;
		location = new Point(163, 5);
		((Control)obj).Location = location;
		((Control)lblTen).Name = "lblTen";
		Label obj2 = lblTen;
		size = new Size(380, 23);
		((Control)obj2).Size = size;
		((Control)lblTen).TabIndex = 49;
		lblTen.Text = "lbl";
		lblTen.TextAlign = (ContentAlignment)64;
		((Control)cmdClose).Anchor = (AnchorStyles)6;
		cmdClose.DialogResult = (DialogResult)2;
		((ButtonBase)cmdClose).Image = (Image)(object)Resources.imgExit;
		((ButtonBase)cmdClose).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdClose).ImeMode = (ImeMode)0;
		Button obj3 = cmdClose;
		location = new Point(91, 5);
		((Control)obj3).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdClose;
		size = new Size(65, 23);
		((Control)obj4).Size = size;
		((Control)cmdClose).TabIndex = 48;
		((ButtonBase)cmdClose).Text = "T&hoát";
		((ButtonBase)cmdClose).TextAlign = (ContentAlignment)64;
		((Control)cmdSave).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdSave).Image = (Image)(object)Resources.save;
		((ButtonBase)cmdSave).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdSave).ImeMode = (ImeMode)0;
		Button obj5 = cmdSave;
		location = new Point(10, 5);
		((Control)obj5).Location = location;
		((Control)cmdSave).Name = "cmdSave";
		Button obj6 = cmdSave;
		size = new Size(75, 23);
		((Control)obj6).Size = size;
		((Control)cmdSave).TabIndex = 47;
		((ButtonBase)cmdSave).Text = "&Lưu";
		((ButtonBase)cmdSave).TextAlign = (ContentAlignment)64;
		((Control)chkAllActive).Anchor = (AnchorStyles)6;
		((ButtonBase)chkAllActive).AutoSize = true;
		((ButtonBase)chkAllActive).ImeMode = (ImeMode)0;
		CheckBox obj7 = chkAllActive;
		location = new Point(549, 10);
		((Control)obj7).Location = location;
		((Control)chkAllActive).Name = "chkAllActive";
		CheckBox obj8 = chkAllActive;
		size = new Size(15, 14);
		((Control)obj8).Size = size;
		((Control)chkAllActive).TabIndex = 46;
		Panel2.BorderStyle = (BorderStyle)2;
		((Control)Panel2).Controls.Add((Control)(object)dgvDM);
		((Control)Panel2).Dock = (DockStyle)5;
		Panel panel3 = Panel2;
		location = new Point(0, 0);
		((Control)panel3).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel4 = Panel2;
		size = new Size(599, 295);
		((Control)panel4).Size = size;
		((Control)Panel2).TabIndex = 47;
		((DataGridView)dgvDM).AllowUserToAddRows = false;
		((DataGridView)dgvDM).AllowUserToDeleteRows = false;
		val.BackColor = Color.LightYellow;
		((DataGridView)dgvDM).AlternatingRowsDefaultCellStyle = val;
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
			(DataGridViewColumn)dgvcViewRight
		});
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = SystemColors.Window;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.ControlText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvDM).DefaultCellStyle = val3;
		((Control)dgvDM).Dock = (DockStyle)5;
		dgvDM.DoubleBuffered = false;
		((DataGridView)dgvDM).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvDM).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvDM;
		location = new Point(0, 0);
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
		size = new Size(595, 291);
		((Control)asDataGridView2).Size = size;
		((Control)dgvDM).TabIndex = 46;
		((DataGridViewColumn)ma_cty).DataPropertyName = "ma_cty";
		((DataGridViewColumn)ma_cty).Frozen = true;
		((DataGridViewColumn)ma_cty).HeaderText = "Mã cty";
		((DataGridViewColumn)ma_cty).Name = "ma_cty";
		((DataGridViewColumn)ma_cty).ReadOnly = true;
		((DataGridViewColumn)ma_cty).Width = 64;
		((DataGridViewColumn)Ten_cty).DataPropertyName = "ten_cty";
		((DataGridViewColumn)Ten_cty).FillWeight = 184.9624f;
		((DataGridViewColumn)Ten_cty).Frozen = true;
		((DataGridViewColumn)Ten_cty).HeaderText = "Tên công ty";
		((DataGridViewColumn)Ten_cty).Name = "Ten_cty";
		((DataGridViewColumn)Ten_cty).ReadOnly = true;
		((DataGridViewColumn)Ten_cty).Width = 436;
		((DataGridViewColumn)dgvcViewRight).DataPropertyName = "Active";
		((DataGridViewColumn)dgvcViewRight).FillWeight = 15.03759f;
		((DataGridViewColumn)dgvcViewRight).HeaderText = "Chọn";
		((DataGridViewColumn)dgvcViewRight).Name = "dgvcViewRight";
		((DataGridViewColumn)dgvcViewRight).Width = 38;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(599, 329);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSmSetRightsCompany";
		((Form)this).Text = "Phân quyền công ty";
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((ISupportInitialize)dgvDM).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void GetData()
	{
		f_oTblCompanyRight = MyController.GetAllRightCompany(f_strUserName);
		((DataGridView)dgvDM).DataSource = f_oTblCompanyRight.DefaultView;
		f_oTblGrandCompanyRight = MyController.GetAllRightCompany(f_strGrandCompanyRight);
	}

	private void cmdSave_Click(object sender, EventArgs e)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		f_oTblCompanyRight.Rows[((DataGridViewBand)((DataGridView)dgvDM).CurrentRow).Index].EndEdit();
		if (f_oTblCompanyRight.GetChanges(DataRowState.Modified) == null)
		{
			((Form)this).Close();
		}
		try
		{
			foreach (DataRow row in f_oTblCompanyRight.GetChanges(DataRowState.Modified).Rows)
			{
				int num = MyController.InsRightCompany(Conversions.ToString(row["Ma_cty"]), f_strUserName, Conversions.ToString(row["Active"]));
			}
			CMessageBox.Show(50015);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
	}

	private void cmdClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void frmSmSetRightsCompany_Load(object sender, EventArgs e)
	{
		lblTen.Text = "Tên đăng nhập: " + f_strUserName + " || Tên đầy đủ: " + f_strFullUserName;
		GetData();
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

	private void frmSmSetRightsCompany_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
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
