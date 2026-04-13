using System;
using System.Collections.Generic;
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
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("browseDlg")]
	private FolderBrowserDialog _browseDlg;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

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

	internal virtual Button cmdOK
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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
		[DebuggerNonUserCode]
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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
		[DebuggerNonUserCode]
		get
		{
			return _browseDlg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_browseDlg = value;
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual TextBox txtDB_Sys
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDB_Sys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDB_Sys = value;
		}
	}

	internal virtual Label lblSys
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSys = value;
		}
	}

	internal virtual TextBox txtDB_data
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDB_data;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDB_data = value;
		}
	}

	internal virtual Label lblData
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblData;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblData = value;
		}
	}

	internal virtual TextBox txtBackupPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtBackupPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtBackupPath = value;
		}
	}

	internal virtual Label lblBackupPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblBackupPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblBackupPath = value;
		}
	}

	internal virtual Button cmdBrowse
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdBrowse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	public frmSIBackupDB()
	{
		((Form)this).Load += frmSIBackupDB_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSIBackupDB));
		cmdOK = new Button();
		cmdCancel = new Button();
		browseDlg = new FolderBrowserDialog();
		Panel1 = new Panel();
		txtDB_Sys = new TextBox();
		lblSys = new Label();
		txtDB_data = new TextBox();
		lblData = new Label();
		txtBackupPath = new TextBox();
		lblBackupPath = new Label();
		cmdBrowse = new Button();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)cmdOK).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdOK).Image = (Image)componentResourceManager.GetObject("cmdOK.Image");
		((ButtonBase)cmdOK).ImageAlign = (ContentAlignment)16;
		Button obj = cmdOK;
		Point location = new Point(10, 123);
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
		location = new Point(91, 123);
		((Control)obj3).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj4 = cmdCancel;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)cmdCancel).TabIndex = 3;
		((ButtonBase)cmdCancel).Text = "&Thoát";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = true;
		((Control)Panel1).Controls.Add((Control)(object)txtDB_Sys);
		((Control)Panel1).Controls.Add((Control)(object)lblSys);
		((Control)Panel1).Controls.Add((Control)(object)txtDB_data);
		((Control)Panel1).Controls.Add((Control)(object)lblData);
		((Control)Panel1).Controls.Add((Control)(object)txtBackupPath);
		((Control)Panel1).Controls.Add((Control)(object)lblBackupPath);
		((Control)Panel1).Controls.Add((Control)(object)cmdBrowse);
		Panel panel = Panel1;
		location = new Point(5, 12);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(514, 100);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 4;
		TextBox obj5 = txtDB_Sys;
		location = new Point(99, 67);
		((Control)obj5).Location = location;
		((Control)txtDB_Sys).Name = "txtDB_Sys";
		((TextBoxBase)txtDB_Sys).ReadOnly = true;
		TextBox obj6 = txtDB_Sys;
		size = new Size(155, 20);
		((Control)obj6).Size = size;
		((Control)txtDB_Sys).TabIndex = 8;
		lblSys.AutoSize = true;
		Label obj7 = lblSys;
		location = new Point(7, 71);
		((Control)obj7).Location = location;
		((Control)lblSys).Name = "lblSys";
		Label obj8 = lblSys;
		size = new Size(73, 13);
		((Control)obj8).Size = size;
		((Control)lblSys).TabIndex = 9;
		lblSys.Text = "Database Sys";
		TextBox obj9 = txtDB_data;
		location = new Point(99, 41);
		((Control)obj9).Location = location;
		((Control)txtDB_data).Name = "txtDB_data";
		((TextBoxBase)txtDB_data).ReadOnly = true;
		TextBox obj10 = txtDB_data;
		size = new Size(155, 20);
		((Control)obj10).Size = size;
		((Control)txtDB_data).TabIndex = 5;
		lblData.AutoSize = true;
		Label obj11 = lblData;
		location = new Point(7, 45);
		((Control)obj11).Location = location;
		((Control)lblData).Name = "lblData";
		Label obj12 = lblData;
		size = new Size(77, 13);
		((Control)obj12).Size = size;
		((Control)lblData).TabIndex = 7;
		lblData.Text = "Database data";
		((TextBoxBase)txtBackupPath).BackColor = SystemColors.Control;
		TextBox obj13 = txtBackupPath;
		location = new Point(99, 15);
		((Control)obj13).Location = location;
		((Control)txtBackupPath).Name = "txtBackupPath";
		TextBox obj14 = txtBackupPath;
		size = new Size(358, 20);
		((Control)obj14).Size = size;
		((Control)txtBackupPath).TabIndex = 10;
		lblBackupPath.AutoSize = true;
		Label obj15 = lblBackupPath;
		location = new Point(7, 19);
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
		location = new Point(463, 14);
		((Control)obj17).Location = location;
		((Control)cmdBrowse).Name = "cmdBrowse";
		Button obj18 = cmdBrowse;
		size = new Size(44, 23);
		((Control)obj18).Size = size;
		((Control)cmdBrowse).TabIndex = 11;
		((ButtonBase)cmdBrowse).Text = "...";
		((ButtonBase)cmdBrowse).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdBrowse).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(525, 158);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSIBackupDB";
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).Text = "Sao lưu dữ liệu";
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void cmdBrowse_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		try
		{
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
		txtBackupPath.Text = "";
		txtDB_data.Text = DatabaseConfigurations.DATADatabaseName;
		txtDB_Sys.Text = DatabaseConfigurations.SYSDatabaseName;
	}
}
