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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DefaultEvent("Menu_Clicked")]
[DesignerGenerated]
public class ucReportMenu : UserControl
{
	[CompilerGenerated]
	internal class _Closure_0024__3
	{
		public MenuInformation _0024VB_0024Local_parent;

		[DebuggerNonUserCode]
		public _Closure_0024__3(_Closure_0024__3 other)
		{
			if (other != null)
			{
				_0024VB_0024Local_parent = other._0024VB_0024Local_parent;
			}
		}

		[DebuggerNonUserCode]
		public _Closure_0024__3()
		{
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("FlowLayoutPanel1")]
	private asFlowPanel _FlowLayoutPanel1;

	[AccessedThroughProperty("ImageListHeader")]
	private ImageList _ImageListHeader;

	[AccessedThroughProperty("ImageListDetail")]
	private ImageList _ImageListDetail;

	private static readonly Color REPORT_LINK_FORECOLOR = Color.Black;

	private static readonly Color HEADER_REPORT_LINK_FORECOLOR = Color.FromArgb(255, 0, 64, 128);

	private static readonly Font HEADER_REPORT_FONT = new Font(FontFamily.GenericSansSerif, 10f, (FontStyle)0);

	private static readonly Font REPORT_LINK_FONT = new Font("Tahoma", 9f, (FontStyle)0);

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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = FlowLayoutPanel1_Resize;
			PaintEventHandler val = new PaintEventHandler(FlowLayoutPanel1_Paint);
			if (_FlowLayoutPanel1 != null)
			{
				((Control)_FlowLayoutPanel1).Resize -= eventHandler;
				((Control)_FlowLayoutPanel1).Paint -= val;
			}
			_FlowLayoutPanel1 = value;
			if (_FlowLayoutPanel1 != null)
			{
				((Control)_FlowLayoutPanel1).Resize += eventHandler;
				((Control)_FlowLayoutPanel1).Paint += val;
			}
		}
	}

	internal virtual ImageList ImageListHeader
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageListHeader;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageListHeader = value;
		}
	}

	internal virtual ImageList ImageListDetail
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageListDetail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageListDetail = value;
		}
	}

	[method: DebuggerNonUserCode]
	public event Action<object, LinkLabelLinkClickedEventArgs> Menu_Clicked;

	[DebuggerNonUserCode]
	public ucReportMenu()
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
			((ContainerControl)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ucReportMenu));
		FlowLayoutPanel1 = new asFlowPanel();
		ImageListHeader = new ImageList(components);
		ImageListDetail = new ImageList(components);
		((Control)this).SuspendLayout();
		((ScrollableControl)FlowLayoutPanel1).AutoScroll = true;
		((Control)FlowLayoutPanel1).BackColor = Color.FromArgb(255, 230, 210);
		((Control)FlowLayoutPanel1).Dock = (DockStyle)5;
		((FlowLayoutPanel)FlowLayoutPanel1).FlowDirection = (FlowDirection)1;
		asFlowPanel flowLayoutPanel = FlowLayoutPanel1;
		Point location = new Point(0, 0);
		((Control)flowLayoutPanel).Location = location;
		asFlowPanel flowLayoutPanel2 = FlowLayoutPanel1;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Control)flowLayoutPanel2).Margin = margin;
		((Control)FlowLayoutPanel1).Name = "FlowLayoutPanel1";
		asFlowPanel flowLayoutPanel3 = FlowLayoutPanel1;
		Size size = new Size(228, 319);
		((Control)flowLayoutPanel3).Size = size;
		((Control)FlowLayoutPanel1).TabIndex = 0;
		((FlowLayoutPanel)FlowLayoutPanel1).WrapContents = false;
		ImageListHeader.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageListHeader.ImageStream");
		ImageListHeader.TransparentColor = Color.Transparent;
		ImageListHeader.Images.SetKeyName(0, "REPORTS.png");
		ImageListHeader.Images.SetKeyName(1, "RptItem.png");
		ImageListDetail.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageListDetail.ImageStream");
		ImageListDetail.TransparentColor = Color.Transparent;
		ImageListDetail.Images.SetKeyName(0, "RptItem.png");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)FlowLayoutPanel1);
		((Padding)(ref margin))._002Ector(0);
		((Control)this).Margin = margin;
		((Control)this).Name = "ucReportMenu";
		size = new Size(228, 319);
		((Control)this).Size = size;
		((Control)this).ResumeLayout(false);
	}

	private void ReportButton_PaintTopAndBottom(object sender, PaintEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		Button val = (Button)sender;
		e.Graphics.DrawLine(Pens.White, 0, 0, ((Control)val).Width, 0);
		e.Graphics.DrawLine(Pens.DarkGray, 0, ((Control)val).Height - 1, ((Control)val).Width, ((Control)val).Height - 1);
		val = null;
	}

	private void ReportButton_Clicked(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		Button val = (Button)sender;
		Font val2 = (((Control)val).Font = new Font(((Control)val).Font.FontFamily, ((Control)val).Font.Size, (FontStyle)(((Control)val).Font.Style ^ 1)));
		if ((((Control)this).Tag != null && ((Control)this).Tag != val) ? true : false)
		{
			((Control)(Button)((Control)this).Tag).Font = new Font(val2.FontFamily, val2.Size, (FontStyle)0);
		}
		int childIndex = ((Control)FlowLayoutPanel1).Controls.GetChildIndex((Control)(object)val);
		((Control)FlowLayoutPanel1).Controls[childIndex + 1].Visible = !((Control)FlowLayoutPanel1).Controls[childIndex + 1].Visible;
		FlowLayoutPanel val4 = (FlowLayoutPanel)((Control)FlowLayoutPanel1).Tag;
		if ((val4 != null && (object)val4 != ((Control)FlowLayoutPanel1).Controls[childIndex + 1]) ? true : false)
		{
			((Control)val4).Visible = false;
		}
		((Control)FlowLayoutPanel1).Tag = ((Control)FlowLayoutPanel1).Controls[childIndex + 1];
		((Control)this).Tag = val;
	}

	private void ReportButton_MouseEnter(object sender, EventArgs e)
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

	private void ReportButton_MouseLeave(object sender, EventArgs e)
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

	internal void InitMenu(IOrderedEnumerable<MenuInformation> mnuEnum)
	{
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		((Control)FlowLayoutPanel1).SuspendLayout();
		((Control)FlowLayoutPanel1).Controls.Clear();
		IOrderedEnumerable<MenuInformation> source = from mnu in mnuEnum
			where mnu.menuid.EndsWith(".00")
			select (mnu) into mnu
			orderby mnu.stt
			select mnu;
		string[] array = (from mnu in source
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
				ImageListHeader.Images.Add(array[num2], Image.FromFile(SystemInformations.GraphicPath + array[num2]));
			}
			num2++;
		}
		IOrderedEnumerable<MenuInformation> source2 = from mnu in mnuEnum
			where !mnu.menuid.EndsWith(".00")
			select (mnu) into mnu
			orderby mnu.stt
			select mnu;
		string[] array2 = (from mnu in source2
			select (mnu) into mnu
			group mnu by mnu.picture1 into mnu
			select mnu.Key).ToArray();
		short num5 = (short)(array2.Length - 1);
		short num6 = 0;
		while (true)
		{
			short num7 = num6;
			short num4 = num5;
			if (num7 > num4)
			{
				break;
			}
			if (File.Exists(SystemInformations.GraphicPath + array2[num6]))
			{
				ImageListDetail.Images.Add(array2[num6], Image.FromFile(SystemInformations.GraphicPath + array2[num6]));
			}
			num6++;
		}
		int num8 = source.Count() - 1;
		int num9 = 0;
		_Closure_0024__3 closure_0024__ = default(_Closure_0024__3);
		Padding val3 = default(Padding);
		LinkArea linkArea = default(LinkArea);
		while (true)
		{
			int num10 = num9;
			int num11 = num8;
			if (num10 > num11)
			{
				break;
			}
			closure_0024__ = new _Closure_0024__3(closure_0024__);
			closure_0024__._0024VB_0024Local_parent = source.ElementAtOrDefault(num9);
			Button val = new Button();
			Button val2 = val;
			((ButtonBase)val2).FlatStyle = (FlatStyle)0;
			((ButtonBase)val2).FlatAppearance.BorderSize = 0;
			((ButtonBase)val2).Text = Strings.Space(1) + source.ElementAtOrDefault(num9).bar;
			((Control)val2).ForeColor = HEADER_REPORT_LINK_FORECOLOR;
			((Control)val2).Font = HEADER_REPORT_FONT;
			((Control)val2).Tag = source.ElementAtOrDefault(num9);
			((ButtonBase)val2).AutoSize = true;
			((Control)val2).Width = ((Control)FlowLayoutPanel1).Width - 2;
			((Control)val2).Dock = (DockStyle)5;
			((ButtonBase)val2).TextAlign = (ContentAlignment)16;
			((ButtonBase)val2).ImageAlign = (ContentAlignment)16;
			Button obj = val2;
			((Padding)(ref val3))._002Ector(0);
			((Control)obj).Padding = val3;
			Button obj2 = val2;
			((Padding)(ref val3))._002Ector(1, 0, 0, 0);
			((Control)obj2).Margin = val3;
			((ButtonBase)val2).TextImageRelation = (TextImageRelation)4;
			((ButtonBase)val2).Image = ImageListHeader.Images[source.ElementAtOrDefault(num9).picture1];
			((Control)val2).Cursor = Cursors.Hand;
			((Control)val2).MouseEnter += ReportButton_MouseEnter;
			((Control)val2).MouseLeave += ReportButton_MouseLeave;
			((Control)val2).Click += ReportButton_Clicked;
			((Control)val2).Paint += new PaintEventHandler(ReportButton_PaintTopAndBottom);
			val2 = null;
			((Control)FlowLayoutPanel1).Controls.Add((Control)(object)val);
			asFlowPanel asFlowPanel2 = new asFlowPanel();
			((Control)asFlowPanel2).Dock = (DockStyle)5;
			((FlowLayoutPanel)asFlowPanel2).FlowDirection = (FlowDirection)1;
			((Panel)asFlowPanel2).AutoSize = true;
			((FlowLayoutPanel)asFlowPanel2).WrapContents = false;
			IOrderedEnumerable<MenuInformation> source3 = from mnu in mnuEnum.Where(closure_0024__._Lambda_0024__101)
				select (mnu) into mnu
				orderby mnu.stt
				select mnu;
			int num12 = source3.Count() - 1;
			int num13 = 0;
			while (true)
			{
				int num14 = num13;
				num11 = num12;
				if (num14 > num11)
				{
					break;
				}
				LinkLabel val4 = new LinkLabel();
				val4.Text = source3.ElementAtOrDefault(num13).bar;
				LinkLabel val5 = val4;
				LinkLabel val6 = val5;
				((Control)val6).Tag = source3.ElementAtOrDefault(num13);
				((Control)val6).Dock = (DockStyle)5;
				((Label)val6).AutoSize = true;
				((Control)val6).Font = REPORT_LINK_FONT;
				val6.LinkColor = REPORT_LINK_FORECOLOR;
				((Label)val6).Image = ImageListDetail.Images[source3.ElementAtOrDefault(num13).picture1];
				((Label)val6).TextAlign = (ContentAlignment)16;
				((Label)val6).ImageAlign = (ContentAlignment)16;
				val6.LinkBehavior = (LinkBehavior)2;
				LinkLabel obj3 = val6;
				((Padding)(ref val3))._002Ector(10, 3, 0, 0);
				obj3.Padding = val3;
				LinkLabel obj4 = val6;
				((Padding)(ref val3))._002Ector(0);
				((Control)obj4).Margin = val3;
				LinkLabel obj5 = val6;
				((LinkArea)(ref linkArea))._002Ector(0, val5.Text.Length);
				obj5.LinkArea = linkArea;
				((Control)val6).Width = ((Control)asFlowPanel2).Width - 2;
				((Control)val6).Cursor = Cursors.Hand;
				val6.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkMenu_Clicked);
				val6 = null;
				((Control)asFlowPanel2).Controls.Add((Control)(object)val5);
				num13++;
			}
			((Control)FlowLayoutPanel1).Controls.Add((Control)(object)asFlowPanel2);
			((Control)asFlowPanel2).Visible = false;
			num9++;
		}
		if (source.Count() > 0)
		{
			((Button)((Control)FlowLayoutPanel1).Controls[0]).PerformClick();
		}
		((Control)FlowLayoutPanel1).ResumeLayout();
	}

	private void LinkMenu_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(((Control)(LinkLabel)sender).Tag);
		Menu_Clicked?.Invoke(RuntimeHelpers.GetObjectValue(objectValue), e);
	}

	private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.DrawLine(Pens.DarkGray, 0, 1, ((Control)FlowLayoutPanel1).Width, 1);
		e.Graphics.DrawLine(Pens.DarkGray, 0, 0, 0, ((Control)FlowLayoutPanel1).Height);
	}

	private void FlowLayoutPanel1_Resize(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		foreach (Control control in ((Control)FlowLayoutPanel1).Controls)
		{
			Control val = control;
			val.Width = ((Control)FlowLayoutPanel1).Width - 2;
		}
	}
}
