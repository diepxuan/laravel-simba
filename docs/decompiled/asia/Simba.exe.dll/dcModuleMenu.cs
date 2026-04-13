using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.Framework.Docking;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
[DefaultEvent("Module_Clicked")]
public class dcModuleMenu : DockContent
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("FlowPanelMenu")]
	private asFlowPanel _FlowPanelMenu;

	[AccessedThroughProperty("ImageListModule")]
	private ImageList _ImageListModule;

	private static readonly Color MODULE_BUTTON_DEFAULT_FORECOLOR = Color.FromArgb(255, 100, 50, 0);

	internal virtual asFlowPanel FlowPanelMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _FlowPanelMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(FlowPanelMenu_Paint);
			if (_FlowPanelMenu != null)
			{
				((Control)_FlowPanelMenu).Paint -= val;
			}
			_FlowPanelMenu = value;
			if (_FlowPanelMenu != null)
			{
				((Control)_FlowPanelMenu).Paint += val;
			}
		}
	}

	internal virtual ImageList ImageListModule
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageListModule;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageListModule = value;
		}
	}

	[method: DebuggerNonUserCode]
	public event EventHandler Module_Clicked;

	[DebuggerNonUserCode]
	public dcModuleMenu()
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
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(dcModuleMenu));
		ImageListModule = new ImageList(components);
		FlowPanelMenu = new asFlowPanel();
		((Control)this).SuspendLayout();
		ImageListModule.ColorDepth = (ColorDepth)32;
		ImageList imageListModule = ImageListModule;
		Size imageSize = new Size(32, 32);
		imageListModule.ImageSize = imageSize;
		ImageListModule.TransparentColor = Color.Transparent;
		((Control)FlowPanelMenu).BackColor = SystemColors.Control;
		((Control)FlowPanelMenu).Dock = (DockStyle)5;
		((FlowLayoutPanel)FlowPanelMenu).FlowDirection = (FlowDirection)1;
		((Control)FlowPanelMenu).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)FlowPanelMenu).ForeColor = Color.Black;
		asFlowPanel flowPanelMenu = FlowPanelMenu;
		Point location = new Point(0, 0);
		((Control)flowPanelMenu).Location = location;
		asFlowPanel flowPanelMenu2 = FlowPanelMenu;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Control)flowPanelMenu2).Margin = margin;
		((Control)FlowPanelMenu).Name = "FlowPanelMenu";
		asFlowPanel flowPanelMenu3 = FlowPanelMenu;
		imageSize = new Size(173, 175);
		((Control)flowPanelMenu3).Size = imageSize;
		((Control)FlowPanelMenu).TabIndex = 0;
		((FlowLayoutPanel)FlowPanelMenu).WrapContents = false;
		AllowEndUserDocking = false;
		AutoHidePortion = 0.1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).AutoSizeMode = (AutoSizeMode)0;
		((Form)this).AutoValidate = (AutoValidate)0;
		((Control)this).CausesValidation = false;
		imageSize = new Size(173, 175);
		((Form)this).ClientSize = imageSize;
		CloseButton = false;
		CloseButtonVisible = false;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)FlowPanelMenu);
		DockAreas = DockAreas.DockLeft;
		((Control)this).DoubleBuffered = true;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).ForeColor = Color.FromArgb(228, 191, 93);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "dcModuleMenu";
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).SizeGripStyle = (SizeGripStyle)2;
		((Form)this).Text = "PHÂN HỆ";
		((Control)this).ResumeLayout(false);
	}

	internal void InitMenu(IOrderedEnumerable<MenuInformation> mnuEnum)
	{
		string[] array = (from mnu in mnuEnum
			group mnu by mnu.picture1 into mnu
			select mnu.Key).ToArray();
		short num = (short)(array.Length - 1);
		short num2 = 0;
		while (true)
		{
			short num3 = num2;
			short num4 = num;
			if (num3 > num4)
			{
				break;
			}
			if (File.Exists(SystemInformations.GraphicPath + array[num2]))
			{
				ImageListModule.Images.Add(array[num2], Image.FromFile(SystemInformations.GraphicPath + array[num2]));
			}
			num2++;
		}
		Button[] array2 = (Button[])(object)new Button[mnuEnum.Count() - 1 + 1];
		int num5 = mnuEnum.Count() - 1;
		int num6 = 0;
		while (true)
		{
			int num7 = num6;
			int num8 = num5;
			if (num7 > num8)
			{
				break;
			}
			array2[num6] = CreateModuleButton(mnuEnum.ElementAtOrDefault(num6));
			num6++;
		}
		((Control)FlowPanelMenu).SuspendLayout();
		((Control)FlowPanelMenu).Controls.Clear();
		((Control)FlowPanelMenu).Controls.AddRange((Control[])(object)array2);
		if (array2.Count() > 0)
		{
			array2[0].PerformClick();
		}
		((Control)FlowPanelMenu).ResumeLayout();
	}

	private Button CreateModuleButton(MenuInformation mnu)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		Button val = new Button();
		Button val2 = val;
		((ButtonBase)val2).FlatStyle = (FlatStyle)0;
		((ButtonBase)val2).FlatAppearance.BorderSize = 0;
		((ButtonBase)val2).Text = Strings.Space(1) + mnu.bar;
		((Control)val2).ForeColor = MODULE_BUTTON_DEFAULT_FORECOLOR;
		((ButtonBase)val2).BackColor = Color.Transparent;
		((ButtonBase)val2).FlatAppearance.MouseOverBackColor = Color.Transparent;
		((Control)val2).Tag = mnu;
		((ButtonBase)val2).AutoSize = true;
		((Control)val2).Width = ((Control)FlowPanelMenu).Width - 2;
		((Control)val2).Dock = (DockStyle)5;
		((ButtonBase)val2).TextAlign = (ContentAlignment)16;
		((ButtonBase)val2).ImageAlign = (ContentAlignment)16;
		Button obj = val2;
		Padding val3 = default(Padding);
		((Padding)(ref val3))._002Ector(0, 0, 0, 0);
		((Control)obj).Padding = val3;
		Button obj2 = val2;
		((Padding)(ref val3))._002Ector(0, 0, 0, 0);
		((Control)obj2).Margin = val3;
		((ButtonBase)val2).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)val2).Image = ImageListModule.Images[mnu.picture1];
		((Control)val2).MouseEnter += ModuleButton_MouseEnter;
		((Control)val2).MouseLeave += ModuleButton_MouseLeave;
		((Control)val2).Click += ModuleButton_Clicked;
		((Control)val2).Paint += new PaintEventHandler(ModuleButton_PaintTopAndBottom);
		val2 = null;
		return val;
	}

	private void ModuleButton_Clicked(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		Button val = (Button)sender;
		if (((Control)FlowPanelMenu).Tag != null)
		{
			Button val2 = (Button)((Control)FlowPanelMenu).Tag;
			if (object.ReferenceEquals(val, val2))
			{
				return;
			}
			((ButtonBase)val2).BackColor = Color.Transparent;
			((Control)val2).ForeColor = MODULE_BUTTON_DEFAULT_FORECOLOR;
		}
		((Control)val).ForeColor = Color.White;
		((Control)FlowPanelMenu).Tag = val;
		Module_Clicked?.Invoke(RuntimeHelpers.GetObjectValue(((Control)val).Tag), e);
	}

	private void ModuleButton_PaintTopAndBottom(object sender, PaintEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		Button val = (Button)sender;
		e.Graphics.DrawLine(Pens.DarkGray, 0, ((Control)val).Height - 1, ((Control)val).Width, ((Control)val).Height - 1);
		val = null;
	}

	private void FlowPanelMenu_Paint(object sender, PaintEventArgs e)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		Color color = Color.FromArgb(255, 251, 184, 117);
		Color color2 = Color.FromArgb(255, 252, 208, 163);
		LinearGradientBrush val = new LinearGradientBrush(e.ClipRectangle, color, color2, (LinearGradientMode)0);
		try
		{
			e.Graphics.FillRectangle((Brush)(object)val, e.ClipRectangle);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		e.Graphics.DrawLine(Pens.DarkGray, 0, 0, ((Control)FlowPanelMenu).Width, 0);
		e.Graphics.DrawLine(Pens.DarkGray, ((Control)FlowPanelMenu).Width - 1, 0, ((Control)FlowPanelMenu).Width - 1, ((Control)FlowPanelMenu).Height - 2);
	}

	private void ModuleButton_MouseEnter(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		Font font = ((Control)(Button)sender).Font;
		font = new Font(font.FontFamily, font.Size, (FontStyle)(font.Style ^ 4));
		((Control)(Button)sender).Font = font;
	}

	private void ModuleButton_MouseLeave(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		Font font = ((Control)(Button)sender).Font;
		font = new Font(font.FontFamily, font.Size, (FontStyle)(font.Style ^ 0 ^ 4));
		((Control)(Button)sender).Font = font;
	}
}
