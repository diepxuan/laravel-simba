using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.Framework.Docking;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class FrmT3Startup : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DockPanelMain")]
	private DockPanel _DockPanelMain;

	private int MODULE_PANEL_MAX_WIDTH;

	internal virtual DockPanel DockPanelMain
	{
		[DebuggerNonUserCode]
		get
		{
			return _DockPanelMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DockPanelMain = value;
		}
	}

	public FrmT3Startup()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		((Form)this).Load += FrmStartup_Load;
		((Form)this).FormClosing += new FormClosingEventHandler(FrmStartup_FormClosing);
		__ENCAddToList(this);
		MODULE_PANEL_MAX_WIDTH = 280;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
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
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		DockPanelSkin dockPanelSkin = new DockPanelSkin();
		AutoHideStripSkin autoHideStripSkin = new AutoHideStripSkin();
		DockPanelGradient dockPanelGradient = new DockPanelGradient();
		TabGradient tabGradient = new TabGradient();
		DockPaneStripSkin dockPaneStripSkin = new DockPaneStripSkin();
		DockPaneStripGradient dockPaneStripGradient = new DockPaneStripGradient();
		TabGradient tabGradient2 = new TabGradient();
		DockPanelGradient dockPanelGradient2 = new DockPanelGradient();
		TabGradient tabGradient3 = new TabGradient();
		DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient = new DockPaneStripToolWindowGradient();
		TabGradient tabGradient4 = new TabGradient();
		TabGradient tabGradient5 = new TabGradient();
		DockPanelGradient dockPanelGradient3 = new DockPanelGradient();
		TabGradient tabGradient6 = new TabGradient();
		TabGradient tabGradient7 = new TabGradient();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FrmT3Startup));
		DockPanelMain = new DockPanel();
		((Control)this).SuspendLayout();
		DockPanelMain.ActiveAutoHideContent = null;
		((Control)DockPanelMain).Dock = (DockStyle)5;
		DockPanelMain.DockBackColor = SystemColors.Control;
		DockPanel dockPanelMain = DockPanelMain;
		Point location = new Point(0, 0);
		((Control)dockPanelMain).Location = location;
		((Control)DockPanelMain).Name = "DockPanelMain";
		DockPanel dockPanelMain2 = DockPanelMain;
		Size size = new Size(972, 488);
		((Control)dockPanelMain2).Size = size;
		dockPanelGradient.EndColor = SystemColors.ControlLight;
		dockPanelGradient.StartColor = SystemColors.ControlLight;
		autoHideStripSkin.DockStripGradient = dockPanelGradient;
		tabGradient.EndColor = SystemColors.Control;
		tabGradient.StartColor = SystemColors.Control;
		tabGradient.TextColor = SystemColors.ControlDarkDark;
		autoHideStripSkin.TabGradient = tabGradient;
		autoHideStripSkin.TextFont = new Font("Tahoma", 8.25f);
		dockPanelSkin.AutoHideStripSkin = autoHideStripSkin;
		tabGradient2.EndColor = SystemColors.ControlLightLight;
		tabGradient2.StartColor = SystemColors.ControlLightLight;
		tabGradient2.TextColor = SystemColors.ControlText;
		dockPaneStripGradient.ActiveTabGradient = tabGradient2;
		dockPanelGradient2.EndColor = SystemColors.Control;
		dockPanelGradient2.StartColor = SystemColors.Control;
		dockPaneStripGradient.DockStripGradient = dockPanelGradient2;
		tabGradient3.EndColor = SystemColors.ControlLight;
		tabGradient3.StartColor = SystemColors.ControlLight;
		tabGradient3.TextColor = SystemColors.ControlText;
		dockPaneStripGradient.InactiveTabGradient = tabGradient3;
		dockPaneStripSkin.DocumentGradient = dockPaneStripGradient;
		dockPaneStripSkin.TextFont = new Font("Tahoma", 8.25f);
		tabGradient4.EndColor = SystemColors.ActiveCaption;
		tabGradient4.LinearGradientMode = (LinearGradientMode)1;
		tabGradient4.StartColor = SystemColors.GradientActiveCaption;
		tabGradient4.TextColor = SystemColors.ActiveCaptionText;
		dockPaneStripToolWindowGradient.ActiveCaptionGradient = tabGradient4;
		tabGradient5.EndColor = SystemColors.Control;
		tabGradient5.StartColor = SystemColors.Control;
		tabGradient5.TextColor = SystemColors.ControlText;
		dockPaneStripToolWindowGradient.ActiveTabGradient = tabGradient5;
		dockPanelGradient3.EndColor = SystemColors.ControlLight;
		dockPanelGradient3.StartColor = SystemColors.ControlLight;
		dockPaneStripToolWindowGradient.DockStripGradient = dockPanelGradient3;
		tabGradient6.EndColor = SystemColors.InactiveCaption;
		tabGradient6.LinearGradientMode = (LinearGradientMode)1;
		tabGradient6.StartColor = SystemColors.GradientInactiveCaption;
		tabGradient6.TextColor = SystemColors.InactiveCaptionText;
		dockPaneStripToolWindowGradient.InactiveCaptionGradient = tabGradient6;
		tabGradient7.EndColor = Color.Transparent;
		tabGradient7.StartColor = Color.Transparent;
		tabGradient7.TextColor = SystemColors.ControlDarkDark;
		dockPaneStripToolWindowGradient.InactiveTabGradient = tabGradient7;
		dockPaneStripSkin.ToolWindowGradient = dockPaneStripToolWindowGradient;
		dockPanelSkin.DockPaneStripSkin = dockPaneStripSkin;
		DockPanelMain.Skin = dockPanelSkin;
		((Control)DockPanelMain).TabIndex = 5;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(972, 488);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)DockPanelMain);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).IsMdiContainer = true;
		((Control)this).Name = "FrmStartup";
		((Form)this).Text = "Simba Accounting 11.3";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)this).ResumeLayout(false);
	}

	private void InitMenu()
	{
		frmT3DetailMenu frmT3DetailMenu2 = new frmT3DetailMenu();
		frmT3ModuleMenu frmT3ModuleMenu2 = new frmT3ModuleMenu();
		frmT3ModuleMenu2.panelDetailMenus = (Panel)(object)frmT3DetailMenu2.panelDetailMenus;
		frmT3ModuleMenu2.lblCurrentModule = frmT3DetailMenu2.lblCurrentModule;
		frmT3DetailMenu2.Show(DockPanelMain, DockState.Document);
		frmT3ModuleMenu2.Show(DockPanelMain, DockState.DockLeft);
		try
		{
			MODULE_PANEL_MAX_WIDTH = Conversions.ToInteger(ConfigurationManager.AppSettings["MODULE_PANEL_MAX_WIDTH"]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		DockWindow dockWindow = DockPanelMain.DockWindows[1];
		Size maximumSize = new Size(MODULE_PANEL_MAX_WIDTH, ((Control)this).Height);
		((Control)dockWindow).MaximumSize = maximumSize;
	}

	private void FrmStartup_Load(object sender, EventArgs e)
	{
		((Form)this).Text = SystemInformations.ProductFullName + " - " + CompanyInformations.CompanyName;
		InitMenu();
	}

	private void exitToolStripMnu_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void FrmStartup_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		if ((int)CMessageBox.Show(50197, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)256) == 7)
		{
			((CancelEventArgs)(object)e).Cancel = true;
			return;
		}
		while (DockPanelMain.Contents.Count > 0)
		{
			DockPanelMain.Contents[0].DockHandler.Close();
		}
	}

	private void exitMnuItem_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void checkUpdMnu_Click(object sender, EventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "Client.exe";
		processStartInfo.Arguments = Application.StartupPath + " " + Process.GetCurrentProcess().Id;
		using (Process.Start(processStartInfo))
		{
		}
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Invalid comparison between Unknown and I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		if ((int)keyData == 131187)
		{
			((Message)(ref msg)).Result = IntPtr.Zero;
			return true;
		}
		Keys val = (Keys)(((Message)(ref msg)).WParam.ToInt32() & 0xFFFF);
		Keys val2 = (Keys)(((Message)(ref msg)).WParam.ToInt32() & -65536);
		if (((Message)(ref msg)).Msg == 256)
		{
			if (((int)val == 9 && (int)Control.ModifierKeys == 131072) ? true : false)
			{
				if (DockPanelMain.ActiveContent == DockPanelMain.Contents[0])
				{
					DockPanelMain.Contents[1].DockHandler.Activate();
				}
				else if (DockPanelMain.ActiveContent == DockPanelMain.Contents[1])
				{
					DockPanelMain.Contents[0].DockHandler.Activate();
					((Form)this).ProcessTabKey(true);
				}
				return false;
			}
			if (((int)val == 13 && DockPanelMain.ActiveContent == DockPanelMain.Contents[0]) ? true : false)
			{
				LinkLabel val3 = (LinkLabel)((ContainerControl)(frmT3DetailMenu)DockPanelMain.Contents[0].DockHandler.DockPanel.ActiveDocument).ActiveControl;
				startup.ExecuteCommand((MenuInformation)((Control)val3).Tag, DockPanelMain);
			}
			return ((Form)this).ProcessCmdKey(ref msg, keyData);
		}
		bool result = default(bool);
		return result;
	}
}
