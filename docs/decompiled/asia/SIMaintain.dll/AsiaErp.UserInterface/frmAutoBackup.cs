using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmAutoBackup : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("btnClose")]
	private Button _btnClose;

	[AccessedThroughProperty("btnSubmit")]
	private Button _btnSubmit;

	[AccessedThroughProperty("lblData")]
	private Label _lblData;

	[AccessedThroughProperty("txtBackupPath")]
	private TextBox _txtBackupPath;

	[AccessedThroughProperty("lblBackupTo")]
	private Label _lblBackupTo;

	[AccessedThroughProperty("cmdBrowse")]
	private Button _cmdBrowse;

	[AccessedThroughProperty("txtDbName")]
	private TextBox _txtDbName;

	[AccessedThroughProperty("lblOnday")]
	private Label _lblOnday;

	[AccessedThroughProperty("chkListCheck")]
	private CheckedListBox _chkListCheck;

	[AccessedThroughProperty("lblOnTime")]
	private Label _lblOnTime;

	[AccessedThroughProperty("dtpTime")]
	private DateTimePicker _dtpTime;

	[AccessedThroughProperty("browseDlg")]
	private FolderBrowserDialog _browseDlg;

	[AccessedThroughProperty("txtSysName")]
	private TextBox _txtSysName;

	[AccessedThroughProperty("lblSys")]
	private Label _lblSys;

	[AccessedThroughProperty("grb")]
	private GroupBox _grb;

	[AccessedThroughProperty("chkBUSYS")]
	private CheckBox _chkBUSYS;

	private int Freq_interval;

	private Dictionary<string, string> dic;

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

	internal virtual Button btnClose
	{
		get
		{
			return _btnClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnClose_Click;
			if (_btnClose != null)
			{
				((Control)_btnClose).Click -= eventHandler;
			}
			_btnClose = value;
			if (_btnClose != null)
			{
				((Control)_btnClose).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnSubmit
	{
		get
		{
			return _btnSubmit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnSubmit_Click;
			if (_btnSubmit != null)
			{
				((Control)_btnSubmit).Click -= eventHandler;
			}
			_btnSubmit = value;
			if (_btnSubmit != null)
			{
				((Control)_btnSubmit).Click += eventHandler;
			}
		}
	}

	internal virtual Label lblData
	{
		get
		{
			return _lblData;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblData = value;
		}
	}

	internal virtual TextBox txtBackupPath
	{
		get
		{
			return _txtBackupPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtBackupPath = value;
		}
	}

	internal virtual Label lblBackupTo
	{
		get
		{
			return _lblBackupTo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblBackupTo = value;
		}
	}

	internal virtual Button cmdBrowse
	{
		get
		{
			return _cmdBrowse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdBrowse_Click;
			if (_cmdBrowse != null)
			{
				((Control)_cmdBrowse).Click -= eventHandler;
			}
			_cmdBrowse = value;
			if (_cmdBrowse != null)
			{
				((Control)_cmdBrowse).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox txtDbName
	{
		get
		{
			return _txtDbName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtDbName = value;
		}
	}

	internal virtual Label lblOnday
	{
		get
		{
			return _lblOnday;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblOnday = value;
		}
	}

	internal virtual CheckedListBox chkListCheck
	{
		get
		{
			return _chkListCheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkListCheck = value;
		}
	}

	internal virtual Label lblOnTime
	{
		get
		{
			return _lblOnTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblOnTime = value;
		}
	}

	internal virtual DateTimePicker dtpTime
	{
		get
		{
			return _dtpTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dtpTime = value;
		}
	}

	internal virtual FolderBrowserDialog browseDlg
	{
		get
		{
			return _browseDlg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_browseDlg = value;
		}
	}

	internal virtual TextBox txtSysName
	{
		get
		{
			return _txtSysName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSysName = value;
		}
	}

	internal virtual Label lblSys
	{
		get
		{
			return _lblSys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblSys = value;
		}
	}

	internal virtual GroupBox grb
	{
		get
		{
			return _grb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_grb = value;
		}
	}

	internal virtual CheckBox chkBUSYS
	{
		get
		{
			return _chkBUSYS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkBUSYS = value;
		}
	}

	public frmAutoBackup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmAutoBackup_KeyDown);
		((Form)this).Load += frmAutoBackup_Load;
		Freq_interval = 0;
		dic = new Dictionary<string, string>();
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected O, but got Unknown
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected O, but got Unknown
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected O, but got Unknown
		//IL_0abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Expected O, but got Unknown
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmAutoBackup));
		Panel1 = new Panel();
		btnClose = new Button();
		btnSubmit = new Button();
		txtSysName = new TextBox();
		lblSys = new Label();
		dtpTime = new DateTimePicker();
		lblOnTime = new Label();
		lblOnday = new Label();
		chkListCheck = new CheckedListBox();
		txtDbName = new TextBox();
		lblData = new Label();
		txtBackupPath = new TextBox();
		lblBackupTo = new Label();
		cmdBrowse = new Button();
		browseDlg = new FolderBrowserDialog();
		grb = new GroupBox();
		chkBUSYS = new CheckBox();
		((Control)Panel1).SuspendLayout();
		((Control)grb).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).Controls.Add((Control)(object)btnClose);
		((Control)Panel1).Controls.Add((Control)(object)btnSubmit);
		((Control)Panel1).Dock = (DockStyle)2;
		Panel panel = Panel1;
		Point location = new Point(1, 167);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		Size size = new Size(573, 34);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 1;
		((Control)btnClose).Anchor = (AnchorStyles)10;
		((ButtonBase)btnClose).Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		((ButtonBase)btnClose).ImageAlign = (ContentAlignment)16;
		Button obj = btnClose;
		location = new Point(502, 4);
		((Control)obj).Location = location;
		((Control)btnClose).Name = "btnClose";
		Button obj2 = btnClose;
		size = new Size(68, 23);
		((Control)obj2).Size = size;
		((Control)btnClose).TabIndex = 1;
		((ButtonBase)btnClose).Text = "Hủy";
		((ButtonBase)btnClose).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnClose).UseVisualStyleBackColor = true;
		((Control)btnSubmit).Anchor = (AnchorStyles)10;
		((ButtonBase)btnSubmit).BackColor = SystemColors.Window;
		((Control)btnSubmit).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)btnSubmit).Image = (Image)componentResourceManager.GetObject("btnSubmit.Image");
		((ButtonBase)btnSubmit).ImageAlign = (ContentAlignment)16;
		Button obj3 = btnSubmit;
		location = new Point(428, 4);
		((Control)obj3).Location = location;
		((Control)btnSubmit).Name = "btnSubmit";
		Button obj4 = btnSubmit;
		size = new Size(68, 23);
		((Control)obj4).Size = size;
		((Control)btnSubmit).TabIndex = 0;
		((ButtonBase)btnSubmit).Text = "&Nhận";
		((ButtonBase)btnSubmit).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnSubmit).UseCompatibleTextRendering = true;
		((ButtonBase)btnSubmit).UseVisualStyleBackColor = false;
		((Control)txtSysName).Enabled = false;
		TextBox obj5 = txtSysName;
		location = new Point(110, 39);
		((Control)obj5).Location = location;
		((Control)txtSysName).Name = "txtSysName";
		((TextBoxBase)txtSysName).ReadOnly = true;
		TextBox obj6 = txtSysName;
		size = new Size(186, 20);
		((Control)obj6).Size = size;
		((Control)txtSysName).TabIndex = 1;
		lblSys.AutoSize = true;
		Label obj7 = lblSys;
		location = new Point(18, 42);
		((Control)obj7).Location = location;
		((Control)lblSys).Name = "lblSys";
		Label obj8 = lblSys;
		size = new Size(24, 13);
		((Control)obj8).Size = size;
		((Control)lblSys).TabIndex = 20;
		lblSys.Text = "Sys";
		dtpTime.Format = (DateTimePickerFormat)4;
		DateTimePicker obj9 = dtpTime;
		location = new Point(110, 127);
		((Control)obj9).Location = location;
		((Control)dtpTime).Name = "dtpTime";
		dtpTime.ShowUpDown = true;
		DateTimePicker obj10 = dtpTime;
		size = new Size(88, 20);
		((Control)obj10).Size = size;
		((Control)dtpTime).TabIndex = 5;
		lblOnTime.AutoSize = true;
		Label obj11 = lblOnTime;
		location = new Point(18, 131);
		((Control)obj11).Location = location;
		((Control)lblOnTime).Name = "lblOnTime";
		Label obj12 = lblOnTime;
		size = new Size(43, 13);
		((Control)obj12).Size = size;
		((Control)lblOnTime).TabIndex = 12;
		lblOnTime.Text = "Vào lúc";
		lblOnday.AutoSize = true;
		Label obj13 = lblOnday;
		location = new Point(18, 91);
		((Control)obj13).Location = location;
		((Control)lblOnday).Name = "lblOnday";
		Label obj14 = lblOnday;
		size = new Size(69, 13);
		((Control)obj14).Size = size;
		((Control)lblOnday).TabIndex = 11;
		lblOnday.Text = "Ngày sao lưu";
		((ListBox)chkListCheck).BackColor = SystemColors.Control;
		((ListBox)chkListCheck).BorderStyle = (BorderStyle)0;
		chkListCheck.CheckOnClick = true;
		((ListBox)chkListCheck).ColumnWidth = 80;
		((ListBox)chkListCheck).Font = new Font("Microsoft Sans Serif", 8.25f);
		((ListControl)chkListCheck).FormattingEnabled = true;
		((ObjectCollection)chkListCheck.Items).AddRange(new object[7] { "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy", "Chủ nhật" });
		CheckedListBox obj15 = chkListCheck;
		location = new Point(110, 91);
		((Control)obj15).Location = location;
		((ListBox)chkListCheck).MultiColumn = true;
		((Control)chkListCheck).Name = "chkListCheck";
		CheckedListBox obj16 = chkListCheck;
		size = new Size(410, 30);
		((Control)obj16).Size = size;
		((Control)chkListCheck).TabIndex = 4;
		((Control)txtDbName).Enabled = false;
		TextBox obj17 = txtDbName;
		location = new Point(110, 13);
		((Control)obj17).Location = location;
		((Control)txtDbName).Name = "txtDbName";
		((TextBoxBase)txtDbName).ReadOnly = true;
		TextBox obj18 = txtDbName;
		size = new Size(186, 20);
		((Control)obj18).Size = size;
		((Control)txtDbName).TabIndex = 0;
		lblData.AutoSize = true;
		Label obj19 = lblData;
		location = new Point(18, 16);
		((Control)obj19).Location = location;
		((Control)lblData).Name = "lblData";
		Label obj20 = lblData;
		size = new Size(53, 13);
		((Control)obj20).Size = size;
		((Control)lblData).TabIndex = 8;
		lblData.Text = "Database";
		((TextBoxBase)txtBackupPath).BackColor = SystemColors.Control;
		TextBox obj21 = txtBackupPath;
		location = new Point(110, 65);
		((Control)obj21).Location = location;
		((Control)txtBackupPath).Name = "txtBackupPath";
		((TextBoxBase)txtBackupPath).ReadOnly = true;
		TextBox obj22 = txtBackupPath;
		size = new Size(358, 20);
		((Control)obj22).Size = size;
		((Control)txtBackupPath).TabIndex = 2;
		((Control)txtBackupPath).TabStop = false;
		lblBackupTo.AutoSize = true;
		Label obj23 = lblBackupTo;
		location = new Point(18, 69);
		((Control)obj23).Location = location;
		((Control)lblBackupTo).Name = "lblBackupTo";
		Label obj24 = lblBackupTo;
		size = new Size(86, 13);
		((Control)obj24).Size = size;
		((Control)lblBackupTo).TabIndex = 5;
		lblBackupTo.Text = "Thư mục sao lưu";
		((ButtonBase)cmdBrowse).BackColor = SystemColors.Window;
		((Control)cmdBrowse).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)cmdBrowse).Image = (Image)componentResourceManager.GetObject("cmdBrowse.Image");
		((ButtonBase)cmdBrowse).ImageAlign = (ContentAlignment)16;
		Button obj25 = cmdBrowse;
		location = new Point(474, 64);
		((Control)obj25).Location = location;
		((Control)cmdBrowse).Name = "cmdBrowse";
		Button obj26 = cmdBrowse;
		size = new Size(46, 23);
		((Control)obj26).Size = size;
		((Control)cmdBrowse).TabIndex = 3;
		((ButtonBase)cmdBrowse).Text = "    ...";
		((ButtonBase)cmdBrowse).UseVisualStyleBackColor = false;
		((Control)grb).Anchor = (AnchorStyles)15;
		((Control)grb).Controls.Add((Control)(object)chkBUSYS);
		((Control)grb).Controls.Add((Control)(object)txtSysName);
		((Control)grb).Controls.Add((Control)(object)txtDbName);
		((Control)grb).Controls.Add((Control)(object)lblSys);
		((Control)grb).Controls.Add((Control)(object)cmdBrowse);
		((Control)grb).Controls.Add((Control)(object)dtpTime);
		((Control)grb).Controls.Add((Control)(object)lblBackupTo);
		((Control)grb).Controls.Add((Control)(object)lblOnTime);
		((Control)grb).Controls.Add((Control)(object)txtBackupPath);
		((Control)grb).Controls.Add((Control)(object)lblOnday);
		((Control)grb).Controls.Add((Control)(object)lblData);
		((Control)grb).Controls.Add((Control)(object)chkListCheck);
		GroupBox obj27 = grb;
		location = new Point(4, 4);
		((Control)obj27).Location = location;
		((Control)grb).Name = "grb";
		GroupBox obj28 = grb;
		size = new Size(570, 159);
		((Control)obj28).Size = size;
		((Control)grb).TabIndex = 2;
		grb.TabStop = false;
		((ButtonBase)chkBUSYS).AutoSize = true;
		chkBUSYS.Checked = true;
		chkBUSYS.CheckState = (CheckState)1;
		CheckBox obj29 = chkBUSYS;
		location = new Point(302, 41);
		((Control)obj29).Location = location;
		((Control)chkBUSYS).Name = "chkBUSYS";
		CheckBox obj30 = chkBUSYS;
		size = new Size(15, 14);
		((Control)obj30).Size = size;
		((Control)chkBUSYS).TabIndex = 21;
		((ButtonBase)chkBUSYS).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(575, 202);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)grb);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmAutoBackup";
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(1);
		((Control)this).Padding = padding;
		((Form)this).Text = "Tự động sao lưu dữ liệu";
		((Control)Panel1).ResumeLayout(false);
		((Control)grb).ResumeLayout(false);
		((Control)grb).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void InitData()
	{
		try
		{
			CheckedListBox val = chkListCheck;
			dic.Add(Conversions.ToString(((ObjectCollection)val.Items)[0]), "2");
			dic.Add(Conversions.ToString(((ObjectCollection)val.Items)[1]), "4");
			dic.Add(Conversions.ToString(((ObjectCollection)val.Items)[2]), "8");
			dic.Add(Conversions.ToString(((ObjectCollection)val.Items)[3]), "16");
			dic.Add(Conversions.ToString(((ObjectCollection)val.Items)[4]), "32");
			dic.Add(Conversions.ToString(((ObjectCollection)val.Items)[5]), "64");
			dic.Add(Conversions.ToString(((ObjectCollection)val.Items)[6]), "1");
			val = null;
			txtDbName.Text = DatabaseConfigurations.DATADatabaseName;
			txtSysName.Text = DatabaseConfigurations.SYSDatabaseName;
			txtBackupPath.Text = Application.StartupPath + "\\BackupData";
			if (!Directory.Exists(txtBackupPath.Text))
			{
				Directory.CreateDirectory(txtBackupPath.Text);
			}
			TextBox val2 = txtBackupPath;
			val2.Text += "\\";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void frmAutoBackup_Load(object sender, EventArgs e)
	{
		InitData();
	}

	private int CreateAutoBackupDb()
	{
		Freq_interval = 0;
		int num = 0;
		foreach (object checkedItem in chkListCheck.CheckedItems)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
			Freq_interval = checked((int)Math.Round((double)Freq_interval + Conversions.ToDouble(dic[objectValue.ToString()])));
		}
		int num2 = 0;
		num2 = Conversions.ToInteger(dtpTime.Value.ToString("HH:mm:ss").Replace(":", ""));
		ArrayList arrayList = new ArrayList();
		arrayList.Add(txtBackupPath.Text);
		arrayList.Add(txtDbName.Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(Interaction.IIf(chkBUSYS.Checked, (object)txtSysName.Text, (object)string.Empty)));
		arrayList.Add(Freq_interval);
		arrayList.Add(num2);
		ISIMaintainDAO iSIMaintainDAO = (ISIMaintainDAO)DAOFactory.CreateDAOInstance("SIMaintainDAO", "SIMaintain");
		int result = iSIMaintainDAO.CreateAutoBackupDB(arrayList.ToArray());
		iSIMaintainDAO.Destroy();
		return result;
	}

	private void btnSubmit_Click(object sender, EventArgs e)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		try
		{
			if (chkListCheck.CheckedItems.Count > 0 && txtBackupPath.Text.Trim().Length > 0)
			{
				CMessageBox.Show(50187);
				if (CreateAutoBackupDb() == 0)
				{
					CMessageBox.Show(50015);
				}
			}
			else
			{
				CMessageBox.Show(50018);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void frmAutoBackup_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void cmdBrowse_Click(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		browseDlg.SelectedPath = txtBackupPath.Text;
		if ((int)((CommonDialog)browseDlg).ShowDialog((IWin32Window)(object)this) == 1)
		{
			txtBackupPath.Text = browseDlg.SelectedPath;
			if (Operators.CompareString(Conversions.ToString(txtBackupPath.Text.Last()), "\\", false) != 0)
			{
				TextBox val = txtBackupPath;
				val.Text += "\\";
			}
		}
		((Component)(object)browseDlg).Dispose();
	}
}
