using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.Framework.Docking;
using Microsoft.VisualBasic.CompilerServices;

[DefaultEvent("Menu_Clicked")]
[DesignerGenerated]
public class dcBottomMenu : DockContent
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ImageListBottom")]
	private ImageList _ImageListBottom;

	[AccessedThroughProperty("FlowLayoutPanel1")]
	private FlowLayoutPanel _FlowLayoutPanel1;

	private static readonly int BUTTON_MENU_WIDTH = 120;

	private static readonly int BUTTON_MENU_HEIGHT = 90;

	private static readonly Color MENU_FORCOLOR = Color.FromArgb(255, 100, 50, 0);

	private static readonly Font MENU_FONT = new Font(FontFamily.GenericSansSerif, 10f, (FontStyle)1);

	internal virtual ImageList ImageListBottom
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageListBottom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageListBottom = value;
		}
	}

	internal virtual FlowLayoutPanel FlowLayoutPanel1
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
	public event EventHandler Menu_Clicked;

	[DebuggerNonUserCode]
	public dcBottomMenu()
	{
		((Form)this).Load += ucBottomMenu_Load;
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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ImageListBottom = new ImageList(components);
		FlowLayoutPanel1 = new FlowLayoutPanel();
		((Control)this).SuspendLayout();
		ImageListBottom.ColorDepth = (ColorDepth)32;
		ImageList imageListBottom = ImageListBottom;
		Size imageSize = new Size(36, 36);
		imageListBottom.ImageSize = imageSize;
		ImageListBottom.TransparentColor = Color.Transparent;
		((ScrollableControl)FlowLayoutPanel1).AutoScroll = true;
		((Control)FlowLayoutPanel1).BackColor = Color.FromArgb(255, 200, 150);
		((Control)FlowLayoutPanel1).Dock = (DockStyle)5;
		FlowLayoutPanel flowLayoutPanel = FlowLayoutPanel1;
		Point location = new Point(0, 0);
		((Control)flowLayoutPanel).Location = location;
		((Control)FlowLayoutPanel1).Name = "FlowLayoutPanel1";
		FlowLayoutPanel flowLayoutPanel2 = FlowLayoutPanel1;
		imageSize = new Size(371, 116);
		((Control)flowLayoutPanel2).Size = imageSize;
		((Control)FlowLayoutPanel1).TabIndex = 0;
		FlowLayoutPanel1.WrapContents = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)FlowLayoutPanel1);
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Form)this).Margin = margin;
		((Control)this).Name = "ucBottomMenu";
		imageSize = new Size(371, 116);
		((Form)this).Size = imageSize;
		((Control)this).ResumeLayout(false);
	}

	internal void InitMenu(IOrderedEnumerable<MenuInformation> mnuEnum)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
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
				ImageListBottom.Images.Add(array[num2], Image.FromFile(SystemInformations.GraphicPath + array[num2]));
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
			((Control)val).Tag = mnuEnum.ElementAtOrDefault(num6);
			((Control)val).Width = BUTTON_MENU_WIDTH;
			((Control)val).Height = BUTTON_MENU_HEIGHT;
			((Control)val).ForeColor = MENU_FORCOLOR;
			((ButtonBase)val).Image = ImageListBottom.Images[mnuEnum.ElementAtOrDefault(num6).picture1];
			((ButtonBase)val).ImageAlign = (ContentAlignment)32;
			((ButtonBase)val).TextImageRelation = (TextImageRelation)1;
			((ButtonBase)val).FlatAppearance.MouseOverBackColor = Color.Transparent;
			((ButtonBase)val).FlatAppearance.MouseDownBackColor = Color.Transparent;
			((ButtonBase)val).FlatAppearance.CheckedBackColor = Color.Transparent;
			((ButtonBase)val).FlatAppearance.BorderColor = Color.White;
			((ButtonBase)val).FlatAppearance.BorderColor = Color.White;
			((Control)val).Font = MENU_FONT;
			val = null;
			((Control)array2[num6]).MouseEnter += CommandButtonBottom_MouseEnter;
			((Control)array2[num6]).MouseLeave += CommandButtonBottom_MouseLeave;
			((Control)array2[num6]).Click += CommandButtonBottom_Click;
			num6++;
		}
		((Control)FlowLayoutPanel1).SuspendLayout();
		((Control)FlowLayoutPanel1).Controls.Clear();
		((Control)FlowLayoutPanel1).Controls.AddRange((Control[])(object)array2);
		((Control)FlowLayoutPanel1).ResumeLayout();
	}

	private void ucBottomMenu_Load(object sender, EventArgs e)
	{
		((ScrollProperties)((ScrollableControl)this).VerticalScroll).Enabled = false;
		((ScrollProperties)((ScrollableControl)FlowLayoutPanel1).VerticalScroll).Enabled = false;
	}

	private void CommandButtonBottom_MouseEnter(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((ButtonBase)(Button)sender).FlatStyle = (FlatStyle)1;
	}

	private void CommandButtonBottom_MouseLeave(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((ButtonBase)(Button)sender).FlatStyle = (FlatStyle)0;
	}

	private void CommandButtonBottom_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MenuInformation sender2 = (MenuInformation)((Control)(Button)sender).Tag;
		Menu_Clicked?.Invoke(sender2, e);
	}

	private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.DrawLine(Pens.DarkGray, 0, 0, ((Control)FlowLayoutPanel1).Width, 0);
	}
}
