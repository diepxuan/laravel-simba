using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
internal class frmSIBackupDB : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("browseDlg")]
	private FolderBrowserDialog _browseDlg;

	[AccessedThroughProperty("txtDB_Sys")]
	private TextBox _txtDB_Sys;

	[AccessedThroughProperty("lblSys")]
	private Label _lblSys;

	[AccessedThroughProperty("txtDB_data")]
	private TextBox _txtDB_data;

	[AccessedThroughProperty("lblData")]
	private Label _lblData;

	[AccessedThroughProperty("txtBackupPath")]
	private TextBox _txtBackupPath;

	[AccessedThroughProperty("lblBackupPath")]
	private Label _lblBackupPath;

	[AccessedThroughProperty("cmdBrowse")]
	private Button _cmdBrowse;

	[AccessedThroughProperty("gb")]
	private GroupBox _gb;

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

	internal virtual TextBox txtDB_Sys
	{
		get
		{
			return _txtDB_Sys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtDB_Sys = value;
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

	internal virtual TextBox txtDB_data
	{
		get
		{
			return _txtDB_data;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtDB_data = value;
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

	internal virtual Label lblBackupPath
	{
		get
		{
			return _lblBackupPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblBackupPath = value;
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

	internal virtual GroupBox gb
	{
		get
		{
			return _gb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_gb = value;
		}
	}

	public frmSIBackupDB()
	{
		((Form)this).Load += frmSIBackupDB_Load;
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
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSIBackupDB));
		cmdOK = new Button();
		cmdCancel = new Button();
		browseDlg = new FolderBrowserDialog();
		txtDB_Sys = new TextBox();
		lblSys = new Label();
		txtDB_data = new TextBox();
		lblData = new Label();
		txtBackupPath = new TextBox();
		lblBackupPath = new Label();
		cmdBrowse = new Button();
		gb = new GroupBox();
		((Control)gb).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)cmdOK).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdOK).Image = (Image)componentResourceManager.GetObject("cmdOK.Image");
		((ButtonBase)cmdOK).ImageAlign = (ContentAlignment)16;
		Button obj = cmdOK;
		Point location = new Point(10, 119);
		((Control)obj).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		Button obj2 = cmdOK;
		Size size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)cmdOK).TabIndex = 2;
		((ButtonBase)cmdOK).Text = "&Thực hiện";
		((ButtonBase)cmdOK).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdOK).UseVisualStyleBackColor = true;
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		((ButtonBase)cmdCancel).Image = (Image)componentResourceManager.GetObject("cmdCancel.Image");
		((ButtonBase)cmdCancel).ImageAlign = (ContentAlignment)16;
		Button obj3 = cmdCancel;
		location = new Point(91, 119);
		((Control)obj3).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj4 = cmdCancel;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)cmdCancel).TabIndex = 3;
		((ButtonBase)cmdCancel).Text = "&Thoát";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = true;
		TextBox obj5 = txtDB_Sys;
		location = new Point(98, 71);
		((Control)obj5).Location = location;
		((Control)txtDB_Sys).Name = "txtDB_Sys";
		((TextBoxBase)txtDB_Sys).ReadOnly = true;
		TextBox obj6 = txtDB_Sys;
		size = new Size(155, 20);
		((Control)obj6).Size = size;
		((Control)txtDB_Sys).TabIndex = 8;
		lblSys.AutoSize = true;
		Label obj7 = lblSys;
		location = new Point(6, 75);
		((Control)obj7).Location = location;
		((Control)lblSys).Name = "lblSys";
		Label obj8 = lblSys;
		size = new Size(73, 13);
		((Control)obj8).Size = size;
		((Control)lblSys).TabIndex = 9;
		lblSys.Text = "Database Sys";
		TextBox obj9 = txtDB_data;
		location = new Point(98, 45);
		((Control)obj9).Location = location;
		((Control)txtDB_data).Name = "txtDB_data";
		((TextBoxBase)txtDB_data).ReadOnly = true;
		TextBox obj10 = txtDB_data;
		size = new Size(155, 20);
		((Control)obj10).Size = size;
		((Control)txtDB_data).TabIndex = 5;
		lblData.AutoSize = true;
		Label obj11 = lblData;
		location = new Point(6, 49);
		((Control)obj11).Location = location;
		((Control)lblData).Name = "lblData";
		Label obj12 = lblData;
		size = new Size(77, 13);
		((Control)obj12).Size = size;
		((Control)lblData).TabIndex = 7;
		lblData.Text = "Database data";
		((TextBoxBase)txtBackupPath).BackColor = SystemColors.Control;
		TextBox obj13 = txtBackupPath;
		location = new Point(98, 19);
		((Control)obj13).Location = location;
		((Control)txtBackupPath).Name = "txtBackupPath";
		((TextBoxBase)txtBackupPath).ReadOnly = true;
		TextBox obj14 = txtBackupPath;
		size = new Size(358, 20);
		((Control)obj14).Size = size;
		((Control)txtBackupPath).TabIndex = 10;
		((Control)txtBackupPath).TabStop = false;
		lblBackupPath.AutoSize = true;
		Label obj15 = lblBackupPath;
		location = new Point(6, 23);
		((Control)obj15).Location = location;
		((Control)lblBackupPath).Name = "lblBackupPath";
		Label obj16 = lblBackupPath;
		size = new Size(86, 13);
		((Control)obj16).Size = size;
		((Control)lblBackupPath).TabIndex = 6;
		lblBackupPath.Text = "Thư mục sao lưu";
		((ButtonBase)cmdBrowse).BackColor = SystemColors.Window;
		((ButtonBase)cmdBrowse).Image = (Image)componentResourceManager.GetObject("cmdBrowse.Image");
		((ButtonBase)cmdBrowse).ImageAlign = (ContentAlignment)16;
		Button obj17 = cmdBrowse;
		location = new Point(462, 18);
		((Control)obj17).Location = location;
		((Control)cmdBrowse).Name = "cmdBrowse";
		Button obj18 = cmdBrowse;
		size = new Size(44, 23);
		((Control)obj18).Size = size;
		((Control)cmdBrowse).TabIndex = 11;
		((ButtonBase)cmdBrowse).Text = "...";
		((ButtonBase)cmdBrowse).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdBrowse).UseVisualStyleBackColor = false;
		((Control)gb).Anchor = (AnchorStyles)15;
		((Control)gb).Controls.Add((Control)(object)txtDB_Sys);
		((Control)gb).Controls.Add((Control)(object)txtBackupPath);
		((Control)gb).Controls.Add((Control)(object)lblSys);
		((Control)gb).Controls.Add((Control)(object)cmdBrowse);
		((Control)gb).Controls.Add((Control)(object)txtDB_data);
		((Control)gb).Controls.Add((Control)(object)lblBackupPath);
		((Control)gb).Controls.Add((Control)(object)lblData);
		GroupBox obj19 = gb;
		location = new Point(10, 12);
		((Control)obj19).Location = location;
		((Control)gb).Name = "gb";
		GroupBox obj20 = gb;
		size = new Size(514, 98);
		((Control)obj20).Size = size;
		((Control)gb).TabIndex = 5;
		gb.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(539, 154);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)gb);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSIBackupDB";
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).Text = "Sao lưu dữ liệu";
		((Control)gb).ResumeLayout(false);
		((Control)gb).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void cmdBrowse_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)browseDlg).ShowDialog((IWin32Window)(object)this) == 1)
		{
			txtBackupPath.Text = browseDlg.SelectedPath;
		}
		((Component)(object)browseDlg).Dispose();
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			CMessageBox.Show(50187);
			frmBackup frmBackup = new frmBackup();
			frmBackup.szPathName = txtBackupPath.Text;
			Hide();
			((Form)frmBackup).ShowDialog((IWin32Window)(object)this);
			((Component)(object)frmBackup).Dispose();
			((Form)this).Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void frmSIBackupDB_Load(object sender, EventArgs e)
	{
		browseDlg.SelectedPath = SystemInformations.RootPath;
		txtBackupPath.Text = SystemInformations.RootPath;
		txtDB_data.Text = DatabaseConfigurations.DATADatabaseName;
		txtDB_Sys.Text = DatabaseConfigurations.SYSDatabaseName;
	}
}
