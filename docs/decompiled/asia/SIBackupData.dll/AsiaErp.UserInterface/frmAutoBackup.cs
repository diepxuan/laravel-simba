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
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmAutoBackup : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("btnClose")]
	private Button _btnClose;

	[AccessedThroughProperty("btnSubmit")]
	private Button _btnSubmit;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("lblData")]
	private Label _lblData;

	[AccessedThroughProperty("txtBackupPath")]
	private TextBox _txtBackupPath;

	[AccessedThroughProperty("lblBackupPath")]
	private Label _lblBackupPath;

	[AccessedThroughProperty("cmdBrowse")]
	private Button _cmdBrowse;

	[AccessedThroughProperty("txtDbName")]
	private TextBox _txtDbName;

	[AccessedThroughProperty("lblOnDay")]
	private Label _lblOnDay;

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

	private int Freq_interval;

	private Dictionary<string, string> dic;

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

	internal virtual Button btnClose
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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
		[DebuggerNonUserCode]
		get
		{
			return _btnSubmit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
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

	internal virtual TextBox txtDbName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDbName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDbName = value;
		}
	}

	internal virtual Label lblOnDay
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblOnDay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblOnDay = value;
		}
	}

	internal virtual CheckedListBox chkListCheck
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkListCheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkListCheck = value;
		}
	}

	internal virtual Label lblOnTime
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblOnTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblOnTime = value;
		}
	}

	internal virtual DateTimePicker dtpTime
	{
		[DebuggerNonUserCode]
		get
		{
			return _dtpTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dtpTime = value;
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

	internal virtual TextBox txtSysName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSysName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSysName = value;
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

	public frmAutoBackup()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmAutoBackup_KeyDown);
		((Form)this).Load += frmAutoBackup_Load;
		__ENCAddToList(this);
		Freq_interval = 0;
		dic = new Dictionary<string, string>();
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
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected O, but got Unknown
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Expected O, but got Unknown
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Expected O, but got Unknown
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmAutoBackup));
		Panel1 = new Panel();
		btnClose = new Button();
		btnSubmit = new Button();
		Panel2 = new Panel();
		txtSysName = new TextBox();
		lblSys = new Label();
		dtpTime = new DateTimePicker();
		lblOnTime = new Label();
		lblOnDay = new Label();
		chkListCheck = new CheckedListBox();
		txtDbName = new TextBox();
		lblData = new Label();
		txtBackupPath = new TextBox();
		lblBackupPath = new Label();
		cmdBrowse = new Button();
		browseDlg = new FolderBrowserDialog();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).Controls.Add((Control)(object)btnClose);
		((Control)Panel1).Controls.Add((Control)(object)btnSubmit);
		((Control)Panel1).Dock = (DockStyle)2;
		Panel panel = Panel1;
		Point location = new Point(1, 168);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		Size size = new Size(525, 34);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 1;
		((Control)btnClose).Anchor = (AnchorStyles)10;
		((ButtonBase)btnClose).Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		((ButtonBase)btnClose).ImageAlign = (ContentAlignment)16;
		Button obj = btnClose;
		location = new Point(454, 8);
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
		location = new Point(380, 8);
		((Control)obj3).Location = location;
		((Control)btnSubmit).Name = "btnSubmit";
		Button obj4 = btnSubmit;
		size = new Size(68, 23);
		((Control)obj4).Size = size;
		((Control)btnSubmit).TabIndex = 0;
		((ButtonBase)btnSubmit).Text = "&Lưu";
		((ButtonBase)btnSubmit).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnSubmit).UseCompatibleTextRendering = true;
		((ButtonBase)btnSubmit).UseVisualStyleBackColor = false;
		((Control)Panel2).Controls.Add((Control)(object)txtSysName);
		((Control)Panel2).Controls.Add((Control)(object)lblSys);
		((Control)Panel2).Controls.Add((Control)(object)dtpTime);
		((Control)Panel2).Controls.Add((Control)(object)lblOnTime);
		((Control)Panel2).Controls.Add((Control)(object)lblOnDay);
		((Control)Panel2).Controls.Add((Control)(object)chkListCheck);
		((Control)Panel2).Controls.Add((Control)(object)txtDbName);
		((Control)Panel2).Controls.Add((Control)(object)lblData);
		((Control)Panel2).Controls.Add((Control)(object)txtBackupPath);
		((Control)Panel2).Controls.Add((Control)(object)lblBackupPath);
		((Control)Panel2).Controls.Add((Control)(object)cmdBrowse);
		((Control)Panel2).Dock = (DockStyle)5;
		Panel panel3 = Panel2;
		location = new Point(1, 1);
		((Control)panel3).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel4 = Panel2;
		size = new Size(525, 167);
		((Control)panel4).Size = size;
		((Control)Panel2).TabIndex = 0;
		((Control)txtSysName).Enabled = false;
		TextBox obj5 = txtSysName;
		location = new Point(104, 36);
		((Control)obj5).Location = location;
		((Control)txtSysName).Name = "txtSysName";
		((TextBoxBase)txtSysName).ReadOnly = true;
		TextBox obj6 = txtSysName;
		size = new Size(186, 20);
		((Control)obj6).Size = size;
		((Control)txtSysName).TabIndex = 1;
		lblSys.AutoSize = true;
		Label obj7 = lblSys;
		location = new Point(12, 39);
		((Control)obj7).Location = location;
		((Control)lblSys).Name = "lblSys";
		Label obj8 = lblSys;
		size = new Size(24, 13);
		((Control)obj8).Size = size;
		((Control)lblSys).TabIndex = 20;
		lblSys.Text = "Sys";
		dtpTime.Format = (DateTimePickerFormat)4;
		DateTimePicker obj9 = dtpTime;
		location = new Point(104, 139);
		((Control)obj9).Location = location;
		((Control)dtpTime).Name = "dtpTime";
		dtpTime.ShowUpDown = true;
		DateTimePicker obj10 = dtpTime;
		size = new Size(88, 20);
		((Control)obj10).Size = size;
		((Control)dtpTime).TabIndex = 5;
		lblOnTime.AutoSize = true;
		Label obj11 = lblOnTime;
		location = new Point(12, 143);
		((Control)obj11).Location = location;
		((Control)lblOnTime).Name = "lblOnTime";
		Label obj12 = lblOnTime;
		size = new Size(43, 13);
		((Control)obj12).Size = size;
		((Control)lblOnTime).TabIndex = 12;
		lblOnTime.Text = "Vào lúc";
		lblOnDay.AutoSize = true;
		Label obj13 = lblOnDay;
		location = new Point(12, 88);
		((Control)obj13).Location = location;
		((Control)lblOnDay).Name = "lblOnDay";
		Label obj14 = lblOnDay;
		size = new Size(69, 13);
		((Control)obj14).Size = size;
		((Control)lblOnDay).TabIndex = 11;
		lblOnDay.Text = "Ngày sao lưu";
		((ListBox)chkListCheck).BackColor = SystemColors.Control;
		((ListBox)chkListCheck).BorderStyle = (BorderStyle)0;
		chkListCheck.CheckOnClick = true;
		((ListBox)chkListCheck).ColumnWidth = 140;
		((ListBox)chkListCheck).Font = new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ListControl)chkListCheck).FormattingEnabled = true;
		((ObjectCollection)chkListCheck.Items).AddRange(new object[7] { "Thứ hai-Monday", "Thứ ba -Tuesday", "Thứ tư -Wednesday", "Thứ năm-Thursday", "Thứ sáu-Friday", "Thứ bảy-Saturday", "Chủ nhật-Sunday" });
		CheckedListBox obj15 = chkListCheck;
		location = new Point(104, 88);
		((Control)obj15).Location = location;
		((ListBox)chkListCheck).MultiColumn = true;
		((Control)chkListCheck).Name = "chkListCheck";
		CheckedListBox obj16 = chkListCheck;
		size = new Size(440, 45);
		((Control)obj16).Size = size;
		((Control)chkListCheck).TabIndex = 4;
		((Control)txtDbName).Enabled = false;
		TextBox obj17 = txtDbName;
		location = new Point(104, 10);
		((Control)obj17).Location = location;
		((Control)txtDbName).Name = "txtDbName";
		((TextBoxBase)txtDbName).ReadOnly = true;
		TextBox obj18 = txtDbName;
		size = new Size(186, 20);
		((Control)obj18).Size = size;
		((Control)txtDbName).TabIndex = 0;
		lblData.AutoSize = true;
		Label obj19 = lblData;
		location = new Point(12, 13);
		((Control)obj19).Location = location;
		((Control)lblData).Name = "lblData";
		Label obj20 = lblData;
		size = new Size(53, 13);
		((Control)obj20).Size = size;
		((Control)lblData).TabIndex = 8;
		lblData.Text = "Database";
		((TextBoxBase)txtBackupPath).BackColor = SystemColors.Control;
		TextBox obj21 = txtBackupPath;
		location = new Point(104, 62);
		((Control)obj21).Location = location;
		((Control)txtBackupPath).Name = "txtBackupPath";
		TextBox obj22 = txtBackupPath;
		size = new Size(358, 20);
		((Control)obj22).Size = size;
		((Control)txtBackupPath).TabIndex = 2;
		((Control)txtBackupPath).TabStop = false;
		lblBackupPath.AutoSize = true;
		Label obj23 = lblBackupPath;
		location = new Point(12, 66);
		((Control)obj23).Location = location;
		((Control)lblBackupPath).Name = "lblBackupPath";
		Label obj24 = lblBackupPath;
		size = new Size(86, 13);
		((Control)obj24).Size = size;
		((Control)lblBackupPath).TabIndex = 5;
		lblBackupPath.Text = "Thư mục sao lưu";
		((ButtonBase)cmdBrowse).BackColor = SystemColors.Window;
		((Control)cmdBrowse).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)cmdBrowse).Image = (Image)componentResourceManager.GetObject("cmdBrowse.Image");
		((ButtonBase)cmdBrowse).ImageAlign = (ContentAlignment)16;
		Button obj25 = cmdBrowse;
		location = new Point(468, 61);
		((Control)obj25).Location = location;
		((Control)cmdBrowse).Name = "cmdBrowse";
		Button obj26 = cmdBrowse;
		size = new Size(46, 23);
		((Control)obj26).Size = size;
		((Control)cmdBrowse).TabIndex = 3;
		((ButtonBase)cmdBrowse).Text = "    ...";
		((ButtonBase)cmdBrowse).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(527, 203);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)2;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmAutoBackup";
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(1);
		((Control)this).Padding = padding;
		((Form)this).Text = "Tự động sao lưu dữ liệu";
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
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
			txtBackupPath.Text = "";
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
		arrayList.Add(txtSysName.Text);
		arrayList.Add(Freq_interval);
		arrayList.Add(num2);
		Commons.ExecuteStoredProcedure("asSiScheduleAutoBackupData", arrayList.ToArray());
		return 0;
	}

	private void btnSubmit_Click(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		try
		{
			if (chkListCheck.CheckedItems.Count > 0)
			{
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
		((Form)this).Close();
	}

	private void frmAutoBackup_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
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
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
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
