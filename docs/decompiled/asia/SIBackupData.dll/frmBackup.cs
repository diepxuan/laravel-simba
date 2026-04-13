using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmBackup : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("prbExecute")]
	private ProgressBar _prbExecute;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("lblCompleted")]
	private Label _lblCompleted;

	private Backup oBak;

	internal string szPathName;

	private Action<int> setProgressVal;

	private Action<string> setStatus;

	private Action closeFormDel;

	internal virtual ProgressBar prbExecute
	{
		[DebuggerNonUserCode]
		get
		{
			return _prbExecute;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_prbExecute = value;
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

	internal virtual Label lblCompleted
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCompleted;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCompleted = value;
		}
	}

	public frmBackup()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		((Form)this).Load += frmBackup_Load;
		__ENCAddToList(this);
		oBak = new Backup();
		setProgressVal = SetProgressValue;
		setStatus = SetStatusText;
		closeFormDel = CloseForm;
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		prbExecute = new ProgressBar();
		GroupBox1 = new GroupBox();
		lblCompleted = new Label();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		ProgressBar obj = prbExecute;
		Point location = new Point(20, 47);
		((Control)obj).Location = location;
		((Control)prbExecute).Name = "prbExecute";
		ProgressBar obj2 = prbExecute;
		Size size = new Size(488, 23);
		((Control)obj2).Size = size;
		((Control)prbExecute).TabIndex = 0;
		((Control)GroupBox1).Controls.Add((Control)(object)lblCompleted);
		((Control)GroupBox1).Controls.Add((Control)(object)prbExecute);
		GroupBox groupBox = GroupBox1;
		location = new Point(12, 3);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(528, 111);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 1;
		GroupBox1.TabStop = false;
		lblCompleted.AutoSize = true;
		Label obj3 = lblCompleted;
		location = new Point(223, 31);
		((Control)obj3).Location = location;
		((Control)lblCompleted).Name = "lblCompleted";
		Label obj4 = lblCompleted;
		size = new Size(74, 13);
		((Control)obj4).Size = size;
		((Control)lblCompleted).TabIndex = 1;
		lblCompleted.Text = "% Hoàn thành";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(552, 122);
		((Form)this).ClientSize = size;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmBackup";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).Text = "Đang thực hiện sao lưu dữ liệu";
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmBackup_Load(object sender, EventArgs e)
	{
		DoBackup();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		if ((int)keyData == 27 && (int)CMessageBox.Show(Helper.GetMessContent(50032), SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256) == 6)
		{
			((BackupRestoreBase)oBak).Abort();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void DoBackup()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		SqlConnectionStringBuilder val = new SqlConnectionStringBuilder();
		((DbConnectionStringBuilder)(object)val).Add("Data source", (object)DatabaseConfigurations.ServerName);
		((DbConnectionStringBuilder)(object)val).Add("Initial catalog", (object)DatabaseConfigurations.DATADatabaseName);
		if (Operators.CompareString(DatabaseConfigurations.AuthenticationType, "WIN", false) == 0)
		{
			((DbConnectionStringBuilder)(object)val).Add("Integrated security", (object)true);
		}
		else
		{
			((DbConnectionStringBuilder)(object)val).Add("User ID", (object)DatabaseConfigurations.UserID);
			((DbConnectionStringBuilder)(object)val).Add("Password", (object)DatabaseConfigurations.Password);
		}
		ServerConnection val2 = new ServerConnection(new SqlConnection(((DbConnectionStringBuilder)(object)val).ConnectionString));
		Server val3 = new Server(val2);
		string text = szPathName + "\\" + DatabaseConfigurations.DATADatabaseName + "_" + DateTime.Now.ToString("dd_MM_yyyy") + ".bak";
		oBak.Action = (BackupActionType)0;
		((BackupRestoreBase)oBak).Devices.AddDevice(text, (DeviceType)2);
		((BackupRestoreBase)oBak).Database = DatabaseConfigurations.DATADatabaseName;
		oBak.Incremental = false;
		oBak.Initialize = true;
		((BackupRestoreBase)oBak).PercentCompleteNotification = 1;
		((BackupRestoreBase)oBak).ContinueAfterError = false;
		((BackupRestoreBase)oBak).Checksum = true;
		((BackupRestoreBase)oBak).Information += new ServerMessageEventHandler(OnInformation);
		((BackupRestoreBase)oBak).PercentComplete += new PercentCompleteEventHandler(OnPercentComplete);
		((BackupRestoreBase)oBak).Complete += new ServerMessageEventHandler(OnComplete);
		oBak.SqlBackupAsync(val3);
	}

	private void OnPercentComplete(object sender, PercentCompleteEventArgs e)
	{
		if (((Control)prbExecute).InvokeRequired)
		{
			((Control)prbExecute).Invoke((Delegate)setProgressVal, new object[1] { e.Percent });
		}
		else
		{
			prbExecute.Value = e.Percent;
		}
		if (((Control)lblCompleted).InvokeRequired)
		{
			((Control)lblCompleted).Invoke((Delegate)setStatus, new object[1] { lblCompleted.Text.Remove(0, lblCompleted.Text.IndexOf("%")).Insert(0, e.Percent.ToString()) });
		}
		else
		{
			lblCompleted.Text = lblCompleted.Text.Remove(0, lblCompleted.Text.IndexOf("%")).Insert(0, e.Percent.ToString());
		}
	}

	private void OnComplete(object sender, ServerMessageEventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (e.Error.Number == 3014)
		{
			CMessageBox.Show(50015);
		}
		else
		{
			CMessageBox.Show(e.Error.Message, SystemInformations.ProductFullName, (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		((Control)this).Invoke((Delegate)closeFormDel);
	}

	private void OnInformation(object sender, ServerMessageEventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		if (e.Error.Number != 4035)
		{
			((BackupRestoreBase)oBak).Information -= new ServerMessageEventHandler(OnInformation);
			OnComplete(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void SetProgressValue(int intVal)
	{
		prbExecute.Value = intVal;
	}

	private void SetStatusText(string szText)
	{
		lblCompleted.Text = szText;
	}

	private void CloseForm()
	{
		((Form)this).Close();
	}
}
