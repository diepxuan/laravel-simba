using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class FrmSync : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblFromPath")]
	private Label _lblFromPath;

	[AccessedThroughProperty("lblToPath")]
	private Label _lblToPath;

	[AccessedThroughProperty("txtSource")]
	private TextBox _txtSource;

	[AccessedThroughProperty("txtLocal")]
	private TextBox _txtLocal;

	[AccessedThroughProperty("btnOk")]
	private Button _btnOk;

	[AccessedThroughProperty("btnExit")]
	private Button _btnExit;

	[AccessedThroughProperty("lblNote")]
	private Label _lblNote;

	[AccessedThroughProperty("dlgFolderBrowser")]
	private FolderBrowserDialog _dlgFolderBrowser;

	[AccessedThroughProperty("btnPath")]
	private Button _btnPath;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("dlgOpenFile")]
	private OpenFileDialog _dlgOpenFile;

	[AccessedThroughProperty("radServer")]
	private RadioButton _radServer;

	[AccessedThroughProperty("radZipFile")]
	private RadioButton _radZipFile;

	private static string UPDATE_PATH;

	private Thread threadShowSplash;

	internal virtual Label lblFromPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFromPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFromPath = value;
		}
	}

	internal virtual Label lblToPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblToPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblToPath = value;
		}
	}

	internal virtual TextBox txtSource
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSource;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtSource_DoubleClick;
			if (_txtSource != null)
			{
				((Control)_txtSource).DoubleClick -= eventHandler;
			}
			_txtSource = value;
			if (_txtSource != null)
			{
				((Control)_txtSource).DoubleClick += eventHandler;
			}
		}
	}

	internal virtual TextBox txtLocal
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLocal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtLocal = value;
		}
	}

	internal virtual Button btnOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnOk_Click;
			if (_btnOk != null)
			{
				((Control)_btnOk).Click -= eventHandler;
			}
			_btnOk = value;
			if (_btnOk != null)
			{
				((Control)_btnOk).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnExit_Click;
			if (_btnExit != null)
			{
				((Control)_btnExit).Click -= eventHandler;
			}
			_btnExit = value;
			if (_btnExit != null)
			{
				((Control)_btnExit).Click += eventHandler;
			}
		}
	}

	internal virtual Label lblNote
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNote;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNote = value;
		}
	}

	internal virtual FolderBrowserDialog dlgFolderBrowser
	{
		[DebuggerNonUserCode]
		get
		{
			return _dlgFolderBrowser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dlgFolderBrowser = value;
		}
	}

	internal virtual Button btnPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnPath_Click;
			if (_btnPath != null)
			{
				((Control)_btnPath).Click -= eventHandler;
			}
			_btnPath = value;
			if (_btnPath != null)
			{
				((Control)_btnPath).Click += eventHandler;
			}
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer1 = value;
		}
	}

	internal virtual OpenFileDialog dlgOpenFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _dlgOpenFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dlgOpenFile = value;
		}
	}

	internal virtual RadioButton radServer
	{
		[DebuggerNonUserCode]
		get
		{
			return _radServer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_radServer = value;
		}
	}

	internal virtual RadioButton radZipFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _radZipFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_radZipFile = value;
		}
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

	public FrmSync(string menuid)
		: base(menuid)
	{
		((Form)this).Load += FrmSync_Load;
		__ENCAddToList(this);
		threadShowSplash = new Thread(ShowSplash);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FrmSync));
		lblFromPath = new Label();
		lblToPath = new Label();
		txtSource = new TextBox();
		txtLocal = new TextBox();
		btnOk = new Button();
		btnExit = new Button();
		lblNote = new Label();
		dlgFolderBrowser = new FolderBrowserDialog();
		btnPath = new Button();
		GroupBox1 = new GroupBox();
		radServer = new RadioButton();
		radZipFile = new RadioButton();
		Timer1 = new Timer(components);
		dlgOpenFile = new OpenFileDialog();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		lblFromPath.AutoSize = true;
		Label obj = lblFromPath;
		Point location = new Point(11, 42);
		((Control)obj).Location = location;
		((Control)lblFromPath).Name = "lblFromPath";
		Label obj2 = lblFromPath;
		Size size = new Size(61, 13);
		((Control)obj2).Size = size;
		((Control)lblFromPath).TabIndex = 4;
		lblFromPath.Text = "Từ thư mục";
		lblToPath.AutoSize = true;
		Label obj3 = lblToPath;
		location = new Point(11, 65);
		((Control)obj3).Location = location;
		((Control)lblToPath).Name = "lblToPath";
		Label obj4 = lblToPath;
		size = new Size(68, 13);
		((Control)obj4).Size = size;
		((Control)lblToPath).TabIndex = 5;
		lblToPath.Text = "Đến thư mục";
		TextBox obj5 = txtSource;
		location = new Point(85, 39);
		((Control)obj5).Location = location;
		((Control)txtSource).Name = "txtSource";
		TextBox obj6 = txtSource;
		size = new Size(313, 20);
		((Control)obj6).Size = size;
		((Control)txtSource).TabIndex = 1;
		((Control)txtLocal).Enabled = false;
		TextBox obj7 = txtLocal;
		location = new Point(85, 65);
		((Control)obj7).Location = location;
		((Control)txtLocal).Name = "txtLocal";
		((TextBoxBase)txtLocal).ReadOnly = true;
		TextBox obj8 = txtLocal;
		size = new Size(313, 20);
		((Control)obj8).Size = size;
		((Control)txtLocal).TabIndex = 7;
		Button obj9 = btnOk;
		location = new Point(22, 116);
		((Control)obj9).Location = location;
		((Control)btnOk).Name = "btnOk";
		Button obj10 = btnOk;
		size = new Size(75, 23);
		((Control)obj10).Size = size;
		((Control)btnOk).TabIndex = 0;
		((ButtonBase)btnOk).Text = "Cập nhật";
		((ButtonBase)btnOk).UseVisualStyleBackColor = true;
		Button obj11 = btnExit;
		location = new Point(103, 116);
		((Control)obj11).Location = location;
		((Control)btnExit).Name = "btnExit";
		Button obj12 = btnExit;
		size = new Size(75, 23);
		((Control)obj12).Size = size;
		((Control)btnExit).TabIndex = 1;
		((ButtonBase)btnExit).Text = "Hủy";
		((ButtonBase)btnExit).UseVisualStyleBackColor = true;
		lblNote.AutoSize = true;
		((Control)lblNote).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		Label obj13 = lblNote;
		location = new Point(193, 121);
		((Control)obj13).Location = location;
		((Control)lblNote).Name = "lblNote";
		Label obj14 = lblNote;
		size = new Size(182, 13);
		((Control)obj14).Size = size;
		((Control)lblNote).TabIndex = 10;
		lblNote.Text = "Chương trình sẽ tự thoát khi cập nhật";
		dlgFolderBrowser.Description = "Cập nhật phiên bản mới từ thư mục :";
		Button obj15 = btnPath;
		location = new Point(404, 37);
		((Control)obj15).Location = location;
		((Control)btnPath).Name = "btnPath";
		Button obj16 = btnPath;
		size = new Size(33, 23);
		((Control)obj16).Size = size;
		((Control)btnPath).TabIndex = 2;
		((ButtonBase)btnPath).Text = "...";
		((ButtonBase)btnPath).UseVisualStyleBackColor = true;
		((Control)GroupBox1).Anchor = (AnchorStyles)13;
		((Control)GroupBox1).Controls.Add((Control)(object)radServer);
		((Control)GroupBox1).Controls.Add((Control)(object)radZipFile);
		((Control)GroupBox1).Controls.Add((Control)(object)txtSource);
		((Control)GroupBox1).Controls.Add((Control)(object)lblFromPath);
		((Control)GroupBox1).Controls.Add((Control)(object)btnPath);
		((Control)GroupBox1).Controls.Add((Control)(object)lblToPath);
		((Control)GroupBox1).Controls.Add((Control)(object)txtLocal);
		GroupBox groupBox = GroupBox1;
		location = new Point(12, 12);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(456, 98);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 13;
		GroupBox1.TabStop = false;
		((ButtonBase)radServer).AutoSize = true;
		radServer.Checked = true;
		RadioButton obj17 = radServer;
		location = new Point(228, 16);
		((Control)obj17).Location = location;
		((Control)radServer).Name = "radServer";
		RadioButton obj18 = radServer;
		size = new Size(126, 17);
		((Control)obj18).Size = size;
		((Control)radServer).TabIndex = 0;
		radServer.TabStop = true;
		((ButtonBase)radServer).Text = "Đồng bộ với máy chủ";
		((ButtonBase)radServer).UseVisualStyleBackColor = true;
		((ButtonBase)radZipFile).AutoSize = true;
		RadioButton obj19 = radZipFile;
		location = new Point(85, 16);
		((Control)obj19).Location = location;
		((Control)radZipFile).Name = "radZipFile";
		RadioButton obj20 = radZipFile;
		size = new Size(125, 17);
		((Control)obj20).Size = size;
		((Control)radZipFile).TabIndex = 12;
		((ButtonBase)radZipFile).Text = "Cập nhật từ file (*.zip)";
		((ButtonBase)radZipFile).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(483, 148);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)btnExit);
		((Control)this).Controls.Add((Control)(object)lblNote);
		((Control)this).Controls.Add((Control)(object)btnOk);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FrmSync";
		((Form)this).Text = "Cập nhật chương trình";
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void FrmSync_Load(object sender, EventArgs e)
	{
		ReadConfig();
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		UPDATE_PATH = txtSource.Text;
		if (radServer.Checked)
		{
			if (!Directory.Exists(UPDATE_PATH))
			{
				CMessageBox.Show(50999);
				return;
			}
		}
		else if (!File.Exists(UPDATE_PATH))
		{
			CMessageBox.Show(50999);
			return;
		}
		((TextBoxBase)txtSource).ReadOnly = true;
		((Control)btnOk).Enabled = false;
		((Control)btnExit).Enabled = false;
		WriteConfig();
		Process.Start(Application.StartupPath + "\\AsiaErpSync.exe");
		KillApplication();
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void txtSource_DoubleClick(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)dlgFolderBrowser).ShowDialog();
		txtSource.Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(dlgFolderBrowser.SelectedPath, string.Empty, false) == 0, (object)txtSource.Text, (object)dlgFolderBrowser.SelectedPath));
	}

	private void btnPath_Click(object sender, EventArgs e)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		((FileDialog)dlgOpenFile).Filter = "Asia compress file|*.zip";
		dlgFolderBrowser.SelectedPath = txtSource.Text.Trim();
		if (radZipFile.Checked)
		{
			if ((int)((CommonDialog)dlgOpenFile).ShowDialog() == 1)
			{
				txtSource.Text = ((FileDialog)dlgOpenFile).FileName;
			}
		}
		else if ((int)((CommonDialog)dlgFolderBrowser).ShowDialog() == 1)
		{
			txtSource.Text = dlgFolderBrowser.SelectedPath;
		}
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void ReadConfig()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		ExeConfigurationFileMap val = new ExeConfigurationFileMap();
		val.ExeConfigFilename = Application.StartupPath + "\\AsiaErpSync.exe.config";
		if (!File.Exists(val.ExeConfigFilename))
		{
			CMessageBox.ShowWithFormat(50110, new object[1] { val.ExeConfigFilename });
		}
		else
		{
			Configuration val2 = ConfigurationManager.OpenMappedExeConfiguration(val, (ConfigurationUserLevel)0);
			txtSource.Text = val2.AppSettings.Settings["UPDATE_PATH"].Value;
			txtLocal.Text = Application.StartupPath;
		}
	}

	private void WriteConfig()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		ExeConfigurationFileMap val = new ExeConfigurationFileMap();
		val.ExeConfigFilename = Application.StartupPath + "\\AsiaErpSync.exe.config";
		if (!File.Exists(val.ExeConfigFilename))
		{
			CMessageBox.ShowWithFormat(50110, new object[1] { val.ExeConfigFilename });
			return;
		}
		Configuration val2 = ConfigurationManager.OpenMappedExeConfiguration(val, (ConfigurationUserLevel)0);
		val2.AppSettings.Settings.Remove("UPDATE_PATH");
		val2.AppSettings.Settings.Add("UPDATE_PATH", UPDATE_PATH);
		try
		{
			val2.Save((ConfigurationSaveMode)0);
		}
		catch (ConfigurationErrorsException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			ConfigurationErrorsException ex2 = ex;
			CMessageBox.ShowWithFormat(50998, new object[1] { val.ExeConfigFilename });
			ProjectData.ClearProjectError();
			return;
		}
		ConfigurationManager.RefreshSection("appSettings");
	}

	private void ShowSplash()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Timer1.Interval = 1;
		Timer1.Start();
		frmSplash frmSplash = new frmSplash();
		((Form)frmSplash).ShowDialog();
	}

	private void InsertLogUpdate()
	{
		try
		{
			string path = UPDATE_PATH + "\\Log.txt";
			if (File.Exists(path))
			{
				string text = File.ReadAllText(path);
				UpdateDAO updateDAO = (UpdateDAO)DAOFactory.CreateDAOInstance("UpdateDAO", "SIUPDATETOOL");
				ArrayList arrayList = new ArrayList();
				arrayList.Add(text.Trim());
				updateDAO.InsertLogUpdate(arrayList.ToArray());
				updateDAO.Destroy();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void KillApplication()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process[] processesByName = Process.GetProcessesByName("Startup");
			if (Process.GetProcessesByName("Startup").Length > 0)
			{
				Process[] array = processesByName;
				foreach (Process process in array)
				{
					process.Kill();
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(50010);
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}
}
