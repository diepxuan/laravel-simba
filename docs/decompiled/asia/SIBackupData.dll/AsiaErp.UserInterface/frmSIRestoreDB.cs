using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
internal class frmSIRestoreDB : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("txtFilePath")]
	private TextBox _txtFilePath;

	[AccessedThroughProperty("lblBackupPath")]
	private Label _lblBackupPath;

	[AccessedThroughProperty("cmdBrowse")]
	private Button _cmdBrowse;

	[AccessedThroughProperty("ofdBackupFile")]
	private OpenFileDialog _ofdBackupFile;

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

	internal virtual TextBox txtFilePath
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFilePath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtFilePath = value;
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

	internal virtual OpenFileDialog ofdBackupFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _ofdBackupFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ofdBackupFile = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSIRestoreDB()
	{
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
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSIRestoreDB));
		cmdOK = new Button();
		cmdCancel = new Button();
		Panel1 = new Panel();
		txtFilePath = new TextBox();
		lblBackupPath = new Label();
		cmdBrowse = new Button();
		ofdBackupFile = new OpenFileDialog();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)cmdOK).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdOK).Image = (Image)componentResourceManager.GetObject("cmdOK.Image");
		((ButtonBase)cmdOK).ImageAlign = (ContentAlignment)16;
		Button obj = cmdOK;
		Point location = new Point(10, 83);
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
		location = new Point(91, 83);
		((Control)obj3).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj4 = cmdCancel;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)cmdCancel).TabIndex = 3;
		((ButtonBase)cmdCancel).Text = "&Thoát";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = true;
		((Control)Panel1).Controls.Add((Control)(object)txtFilePath);
		((Control)Panel1).Controls.Add((Control)(object)lblBackupPath);
		((Control)Panel1).Controls.Add((Control)(object)cmdBrowse);
		Panel panel = Panel1;
		location = new Point(5, 12);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(514, 56);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 4;
		((TextBoxBase)txtFilePath).BackColor = SystemColors.Control;
		TextBox obj5 = txtFilePath;
		location = new Point(99, 15);
		((Control)obj5).Location = location;
		((Control)txtFilePath).Name = "txtFilePath";
		TextBox obj6 = txtFilePath;
		size = new Size(358, 20);
		((Control)obj6).Size = size;
		((Control)txtFilePath).TabIndex = 10;
		lblBackupPath.AutoSize = true;
		Label obj7 = lblBackupPath;
		location = new Point(7, 19);
		((Control)obj7).Location = location;
		((Control)lblBackupPath).Name = "lblBackupPath";
		Label obj8 = lblBackupPath;
		size = new Size(77, 13);
		((Control)obj8).Size = size;
		((Control)lblBackupPath).TabIndex = 6;
		lblBackupPath.Text = "Tập tin sao lưu";
		((ButtonBase)cmdBrowse).BackColor = SystemColors.Window;
		((ButtonBase)cmdBrowse).Image = (Image)componentResourceManager.GetObject("cmdBrowse.Image");
		((ButtonBase)cmdBrowse).ImageAlign = (ContentAlignment)16;
		Button obj9 = cmdBrowse;
		location = new Point(463, 14);
		((Control)obj9).Location = location;
		((Control)cmdBrowse).Name = "cmdBrowse";
		Button obj10 = cmdBrowse;
		size = new Size(44, 23);
		((Control)obj10).Size = size;
		((Control)cmdBrowse).TabIndex = 11;
		((ButtonBase)cmdBrowse).Text = "...";
		((ButtonBase)cmdBrowse).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdBrowse).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(525, 118);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSIRestoreDB";
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).Text = "Khôi phục dữ liệu";
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void cmdBrowse_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)ofdBackupFile).ShowDialog((IWin32Window)(object)this) == 1)
		{
			txtFilePath.Text = ((FileDialog)ofdBackupFile).FileName;
		}
		((Component)(object)ofdBackupFile).Dispose();
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Operators.CompareString(txtFilePath.Text.Trim(), string.Empty, false) == 0 || !File.Exists(txtFilePath.Text.Trim()))
			{
				((Control)txtFilePath).Select();
				CMessageBox.Show(50002);
				return;
			}
			if (!File.Exists(txtFilePath.Text.Trim()))
			{
				((Control)txtFilePath).Select();
				CMessageBox.ShowWithFormat(50110, new object[1] { txtFilePath.Text.Trim() });
				return;
			}
			frmRestore frmRestore = new frmRestore();
			frmRestore.szPathName = txtFilePath.Text;
			Hide();
			((Form)frmRestore).ShowDialog((IWin32Window)(object)this);
			((Component)(object)frmRestore).Dispose();
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
}
