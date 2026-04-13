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
using Microsoft.VisualBasic.CompilerServices;

[DefaultEvent("Menu_Clicked")]
[DesignerGenerated]
public class dcCenterMenu : DockContent
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ImageListCenter")]
	private ImageList _ImageListCenter;

	[AccessedThroughProperty("FlowLayoutPanel1")]
	private asFlowPanel _FlowLayoutPanel1;

	private static readonly int BUTTON_MENU_WIDTH = 120;

	private static readonly int BUTTON_MENU_HEIGHT = 90;

	private static readonly Color MENU_FORCOLOR = Color.FromArgb(255, 100, 50, 0);

	private static readonly Font MENU_FONT = new Font(FontFamily.GenericSansSerif, 10f, (FontStyle)1);

	internal virtual ImageList ImageListCenter
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageListCenter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageListCenter = value;
		}
	}

	internal virtual asFlowPanel FlowLayoutPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _FlowLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(FlowLayoutPanel1_Paint);
			if (_FlowLayoutPanel1 != null)
			{
				((Control)_FlowLayoutPanel1).Paint -= val;
			}
			_FlowLayoutPanel1 = value;
			if (_FlowLayoutPanel1 != null)
			{
				((Control)_FlowLayoutPanel1).Paint += val;
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event Action<object, MouseEventArgs> Menu_Clicked;

	[DebuggerNonUserCode]
	public dcCenterMenu()
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
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(dcCenterMenu));
		ImageListCenter = new ImageList(components);
		FlowLayoutPanel1 = new asFlowPanel();
		((Control)this).SuspendLayout();
		ImageListCenter.ColorDepth = (ColorDepth)32;
		ImageList imageListCenter = ImageListCenter;
		Size imageSize = new Size(36, 36);
		imageListCenter.ImageSize = imageSize;
		ImageListCenter.TransparentColor = Color.Transparent;
		((Control)FlowLayoutPanel1).BackColor = SystemColors.Control;
		((Control)FlowLayoutPanel1).Dock = (DockStyle)5;
		asFlowPanel flowLayoutPanel = FlowLayoutPanel1;
		Point location = new Point(0, 0);
		((Control)flowLayoutPanel).Location = location;
		((Control)FlowLayoutPanel1).Name = "FlowLayoutPanel1";
		asFlowPanel flowLayoutPanel2 = FlowLayoutPanel1;
		imageSize = new Size(256, 112);
		((Control)flowLayoutPanel2).Size = imageSize;
		((Control)FlowLayoutPanel1).TabIndex = 0;
		AllowEndUserDocking = false;
		AutoHidePortion = 0.1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).AutoValidate = (AutoValidate)0;
		((Form)this).BackColor = SystemColors.Control;
		((Control)this).CausesValidation = false;
		imageSize = new Size(256, 112);
		((Form)this).ClientSize = imageSize;
		CloseButton = false;
		CloseButtonVisible = false;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)FlowLayoutPanel1);
		DockAreas = DockAreas.Document;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Form)this).Margin = margin;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "dcCenterMenu";
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).SizeGripStyle = (SizeGripStyle)2;
		((Form)this).StartPosition = (FormStartPosition)0;
		((Form)this).Text = "Menu";
		((Control)this).ResumeLayout(false);
	}

	internal void InitMenu(IOrderedEnumerable<MenuInformation> mnuEnum)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		string[] array = (from mnu in mnuEnum
			select (mnu) into mnu
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
				ImageListCenter.Images.Add(array[num2], Image.FromFile(SystemInformations.GraphicPath + array[num2]));
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
			array2[num6] = new Button();
			Button val = array2[num6];
			((ButtonBase)val).Text = mnuEnum.ElementAtOrDefault(num6).bar;
			((ButtonBase)val).FlatAppearance.BorderSize = 0;
			((ButtonBase)val).FlatStyle = (FlatStyle)0;
			((ButtonBase)val).BackColor = Color.Transparent;
			((Control)val).Tag = mnuEnum.ElementAtOrDefault(num6);
			((Control)val).Cursor = Cursors.Hand;
			((Control)val).ForeColor = MENU_FORCOLOR;
			((Control)val).Width = BUTTON_MENU_WIDTH;
			((Control)val).Height = BUTTON_MENU_HEIGHT;
			((ButtonBase)val).Image = ImageListCenter.Images[mnuEnum.ElementAtOrDefault(num6).picture1];
			((ButtonBase)val).ImageAlign = (ContentAlignment)32;
			((ButtonBase)val).TextImageRelation = (TextImageRelation)1;
			((ButtonBase)val).FlatAppearance.MouseOverBackColor = Color.Transparent;
			((ButtonBase)val).FlatAppearance.MouseDownBackColor = Color.Transparent;
			((ButtonBase)val).FlatAppearance.CheckedBackColor = Color.Transparent;
			((ButtonBase)val).FlatAppearance.BorderColor = Color.White;
			((Control)val).Font = MENU_FONT;
			val = null;
			((Control)array2[num6]).MouseEnter += CommandButtonCenter_MouseEnter;
			((Control)array2[num6]).MouseLeave += CommandButtonCenter_MouseLeave;
			((Control)array2[num6]).MouseUp += new MouseEventHandler(CommandButtonCenter_Click);
			num6++;
		}
		((Control)FlowLayoutPanel1).SuspendLayout();
		((Control)FlowLayoutPanel1).Controls.Clear();
		((Control)FlowLayoutPanel1).Controls.AddRange((Control[])(object)array2);
		((Control)FlowLayoutPanel1).ResumeLayout();
	}

	private void CommandButtonCenter_MouseEnter(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((ButtonBase)(Button)sender).FlatStyle = (FlatStyle)1;
	}

	private void CommandButtonCenter_MouseLeave(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((ButtonBase)(Button)sender).FlatStyle = (FlatStyle)0;
	}

	private void CommandButtonCenter_Click(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MenuInformation arg = (MenuInformation)((Control)(Button)sender).Tag;
		Menu_Clicked?.Invoke(arg, e);
	}

	private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		Color color = Color.FromArgb(250, 206, 162);
		Color color2 = Color.FromArgb(255, 255, 255, 255);
		Rectangle rectangle = new Rectangle(0, 0, ((Control)FlowLayoutPanel1).Width, ((Control)FlowLayoutPanel1).Height);
		LinearGradientBrush val = new LinearGradientBrush(rectangle, color, color2, (LinearGradientMode)0);
		try
		{
			e.Graphics.FillRectangle((Brush)(object)val, e.ClipRectangle);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
