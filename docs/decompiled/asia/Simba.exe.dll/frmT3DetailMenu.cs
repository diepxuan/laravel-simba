using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework.Docking;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmT3DetailMenu : DockContent
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("panelLogo")]
	private asPanel _panelLogo;

	[AccessedThroughProperty("panelDetailMenus")]
	private asPanel _panelDetailMenus;

	[AccessedThroughProperty("lblCompanyName")]
	private Label _lblCompanyName;

	[AccessedThroughProperty("lblCurrentModule")]
	private Label _lblCurrentModule;

	internal virtual asPanel panelLogo
	{
		[DebuggerNonUserCode]
		get
		{
			return _panelLogo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_panelLogo = value;
		}
	}

	internal virtual asPanel panelDetailMenus
	{
		[DebuggerNonUserCode]
		get
		{
			return _panelDetailMenus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_panelDetailMenus = value;
		}
	}

	internal virtual Label lblCompanyName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCompanyName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCompanyName = value;
		}
	}

	internal virtual Label lblCurrentModule
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCurrentModule;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCurrentModule = value;
		}
	}

	[DebuggerNonUserCode]
	public frmT3DetailMenu()
	{
		__ENCAddToList(this);
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
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmT3DetailMenu));
		panelLogo = new asPanel();
		lblCompanyName = new Label();
		lblCurrentModule = new Label();
		panelDetailMenus = new asPanel();
		((Control)panelLogo).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panelLogo).Controls.Add((Control)(object)lblCompanyName);
		((Control)panelLogo).Controls.Add((Control)(object)lblCurrentModule);
		((Control)panelLogo).Dock = (DockStyle)1;
		asPanel obj = panelLogo;
		Point location = new Point(0, 0);
		((Control)obj).Location = location;
		((Control)panelLogo).Name = "panelLogo";
		asPanel obj2 = panelLogo;
		Size size = new Size(910, 33);
		((Control)obj2).Size = size;
		((Control)panelLogo).TabIndex = 0;
		((Control)lblCompanyName).Anchor = (AnchorStyles)9;
		lblCompanyName.AutoSize = true;
		((Control)lblCompanyName).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj3 = lblCompanyName;
		location = new Point(627, 6);
		((Control)obj3).Location = location;
		((Control)lblCompanyName).Name = "lblCompanyName";
		((Control)lblCompanyName).RightToLeft = (RightToLeft)1;
		Label obj4 = lblCompanyName;
		size = new Size(71, 18);
		((Control)obj4).Size = size;
		((Control)lblCompanyName).TabIndex = 0;
		lblCompanyName.Text = "AsiaSoft";
		lblCompanyName.TextAlign = (ContentAlignment)4;
		((Control)lblCompanyName).Visible = false;
		lblCurrentModule.AutoSize = true;
		((Control)lblCurrentModule).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblCurrentModule).ForeColor = Color.DarkBlue;
		Label obj5 = lblCurrentModule;
		location = new Point(12, 6);
		((Control)obj5).Location = location;
		((Control)lblCurrentModule).Name = "lblCurrentModule";
		Label obj6 = lblCurrentModule;
		size = new Size(33, 18);
		((Control)obj6).Size = size;
		((Control)lblCurrentModule).TabIndex = 0;
		lblCurrentModule.Text = "[...]";
		((ScrollableControl)panelDetailMenus).AutoScroll = true;
		asPanel obj7 = panelDetailMenus;
		size = new Size(20, 20);
		((ScrollableControl)obj7).AutoScrollMargin = size;
		((Control)panelDetailMenus).Dock = (DockStyle)5;
		asPanel obj8 = panelDetailMenus;
		location = new Point(0, 33);
		((Control)obj8).Location = location;
		((Control)panelDetailMenus).Name = "panelDetailMenus";
		asPanel obj9 = panelDetailMenus;
		size = new Size(910, 409);
		((Control)obj9).Size = size;
		((Control)panelDetailMenus).TabIndex = 1;
		AllowEndUserDocking = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = SystemColors.Window;
		size = new Size(910, 442);
		((Form)this).ClientSize = size;
		CloseButton = false;
		((Control)this).Controls.Add((Control)(object)panelDetailMenus);
		((Control)this).Controls.Add((Control)(object)panelLogo);
		DockAreas = DockAreas.Document;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "FrmDetailMenu";
		((Form)this).Text = "Menu";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)panelLogo).ResumeLayout(false);
		((Control)panelLogo).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
