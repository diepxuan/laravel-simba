using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AsiaErp.Framework.Docking;

internal class VS2005DockPaneStrip : DockPaneStripBase
{
	private class TabVS2005 : Tab
	{
		private int m_tabX;

		private int m_tabWidth;

		private int m_maxWidth;

		private bool m_flag;

		public int TabX
		{
			get
			{
				return m_tabX;
			}
			set
			{
				m_tabX = value;
			}
		}

		public int TabWidth
		{
			get
			{
				return m_tabWidth;
			}
			set
			{
				m_tabWidth = value;
			}
		}

		public int MaxWidth
		{
			get
			{
				return m_maxWidth;
			}
			set
			{
				m_maxWidth = value;
			}
		}

		protected internal bool Flag
		{
			get
			{
				return m_flag;
			}
			set
			{
				m_flag = value;
			}
		}

		public TabVS2005(IDockContent content)
			: base(content)
		{
		}
	}

	private sealed class InertButton : InertButtonBase
	{
		private Bitmap m_image0;

		private Bitmap m_image1;

		private int m_imageCategory;

		public int ImageCategory
		{
			get
			{
				return m_imageCategory;
			}
			set
			{
				if (m_imageCategory != value)
				{
					m_imageCategory = value;
					((Control)this).Invalidate();
				}
			}
		}

		public override Bitmap Image
		{
			get
			{
				if (ImageCategory != 0)
				{
					return m_image1;
				}
				return m_image0;
			}
		}

		public InertButton(Bitmap image0, Bitmap image1)
		{
			m_image0 = image0;
			m_image1 = image1;
		}
	}

	private const int _ToolWindowStripGapTop = 0;

	private const int _ToolWindowStripGapBottom = 1;

	private const int _ToolWindowStripGapLeft = 0;

	private const int _ToolWindowStripGapRight = 0;

	private const int _ToolWindowImageHeight = 16;

	private const int _ToolWindowImageWidth = 16;

	private const int _ToolWindowImageGapTop = 3;

	private const int _ToolWindowImageGapBottom = 1;

	private const int _ToolWindowImageGapLeft = 2;

	private const int _ToolWindowImageGapRight = 0;

	private const int _ToolWindowTextGapRight = 3;

	private const int _ToolWindowTabSeperatorGapTop = 3;

	private const int _ToolWindowTabSeperatorGapBottom = 3;

	private const int _DocumentStripGapTop = 0;

	private const int _DocumentStripGapBottom = 1;

	private const int _DocumentTabMaxWidth = 200;

	private const int _DocumentButtonGapTop = 4;

	private const int _DocumentButtonGapBottom = 4;

	private const int _DocumentButtonGapBetween = 0;

	private const int _DocumentButtonGapRight = 3;

	private const int _DocumentTabGapTop = 3;

	private const int _DocumentTabGapLeft = 3;

	private const int _DocumentTabGapRight = 3;

	private const int _DocumentIconGapBottom = 2;

	private const int _DocumentIconGapLeft = 8;

	private const int _DocumentIconGapRight = 0;

	private const int _DocumentIconHeight = 16;

	private const int _DocumentIconWidth = 16;

	private const int _DocumentTextGapRight = 3;

	private ContextMenuStrip m_selectMenu;

	private static Bitmap m_imageButtonClose;

	private InertButton m_buttonClose;

	private static Bitmap m_imageButtonWindowList;

	private static Bitmap m_imageButtonWindowListOverflow;

	private InertButton m_buttonWindowList;

	private IContainer m_components;

	private ToolTip m_toolTip;

	private Font m_font;

	private Font m_boldFont;

	private int m_startDisplayingTab;

	private int m_endDisplayingTab;

	private int m_firstDisplayingTab;

	private bool m_documentTabsOverflow;

	private static string m_toolTipSelect;

	private static string m_toolTipClose;

	private bool m_closeButtonVisible;

	private Rectangle TabStripRectangle
	{
		get
		{
			if (base.Appearance == DockPane.AppearanceStyle.Document)
			{
				return TabStripRectangle_Document;
			}
			return TabStripRectangle_ToolWindow;
		}
	}

	private Rectangle TabStripRectangle_ToolWindow
	{
		get
		{
			Rectangle clientRectangle = ((Control)this).ClientRectangle;
			return new Rectangle(clientRectangle.X, clientRectangle.Top + ToolWindowStripGapTop, clientRectangle.Width, clientRectangle.Height - ToolWindowStripGapTop - ToolWindowStripGapBottom);
		}
	}

	private Rectangle TabStripRectangle_Document
	{
		get
		{
			Rectangle clientRectangle = ((Control)this).ClientRectangle;
			return new Rectangle(clientRectangle.X, clientRectangle.Top + DocumentStripGapTop, clientRectangle.Width, clientRectangle.Height - DocumentStripGapTop - ToolWindowStripGapBottom);
		}
	}

	private Rectangle TabsRectangle
	{
		get
		{
			if (base.Appearance == DockPane.AppearanceStyle.ToolWindow)
			{
				return TabStripRectangle;
			}
			Rectangle tabStripRectangle = TabStripRectangle;
			int x = tabStripRectangle.X;
			int y = tabStripRectangle.Y;
			int width = tabStripRectangle.Width;
			int height = tabStripRectangle.Height;
			x += DocumentTabGapLeft;
			width -= DocumentTabGapLeft + DocumentTabGapRight + DocumentButtonGapRight + ((Control)ButtonClose).Width + ((Control)ButtonWindowList).Width + 2 * DocumentButtonGapBetween;
			return new Rectangle(x, y, width, height);
		}
	}

	private ContextMenuStrip SelectMenu => m_selectMenu;

	private static Bitmap ImageButtonClose
	{
		get
		{
			if (m_imageButtonClose == null)
			{
				m_imageButtonClose = Resources.DockPane_Close;
			}
			return m_imageButtonClose;
		}
	}

	private InertButton ButtonClose
	{
		get
		{
			if (m_buttonClose == null)
			{
				m_buttonClose = new InertButton(ImageButtonClose, ImageButtonClose);
				m_toolTip.SetToolTip((Control)(object)m_buttonClose, ToolTipClose);
				((Control)m_buttonClose).Click += Close_Click;
				((Control)this).Controls.Add((Control)(object)m_buttonClose);
			}
			return m_buttonClose;
		}
	}

	private static Bitmap ImageButtonWindowList
	{
		get
		{
			if (m_imageButtonWindowList == null)
			{
				m_imageButtonWindowList = Resources.DockPane_Option;
			}
			return m_imageButtonWindowList;
		}
	}

	private static Bitmap ImageButtonWindowListOverflow
	{
		get
		{
			if (m_imageButtonWindowListOverflow == null)
			{
				m_imageButtonWindowListOverflow = Resources.DockPane_OptionOverflow;
			}
			return m_imageButtonWindowListOverflow;
		}
	}

	private InertButton ButtonWindowList
	{
		get
		{
			if (m_buttonWindowList == null)
			{
				m_buttonWindowList = new InertButton(ImageButtonWindowList, ImageButtonWindowListOverflow);
				m_toolTip.SetToolTip((Control)(object)m_buttonWindowList, ToolTipSelect);
				((Control)m_buttonWindowList).Click += WindowList_Click;
				((Control)this).Controls.Add((Control)(object)m_buttonWindowList);
			}
			return m_buttonWindowList;
		}
	}

	private static GraphicsPath GraphicsPath => VS2005AutoHideStrip.GraphicsPath;

	private IContainer Components => m_components;

	public Font TextFont => base.DockPane.DockPanel.Skin.DockPaneStripSkin.TextFont;

	private Font BoldFont
	{
		get
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			if (((Control)this).IsDisposed)
			{
				return null;
			}
			if (m_boldFont == null)
			{
				m_font = TextFont;
				m_boldFont = new Font(TextFont, (FontStyle)1);
			}
			else if (m_font != TextFont)
			{
				m_boldFont.Dispose();
				m_font = TextFont;
				m_boldFont = new Font(TextFont, (FontStyle)1);
			}
			return m_boldFont;
		}
	}

	private int StartDisplayingTab
	{
		get
		{
			return m_startDisplayingTab;
		}
		set
		{
			m_startDisplayingTab = value;
			((Control)this).Invalidate();
		}
	}

	private int EndDisplayingTab
	{
		get
		{
			return m_endDisplayingTab;
		}
		set
		{
			m_endDisplayingTab = value;
		}
	}

	private int FirstDisplayingTab
	{
		get
		{
			return m_firstDisplayingTab;
		}
		set
		{
			m_firstDisplayingTab = value;
		}
	}

	private bool DocumentTabsOverflow
	{
		set
		{
			if (m_documentTabsOverflow != value)
			{
				m_documentTabsOverflow = value;
				if (value)
				{
					ButtonWindowList.ImageCategory = 1;
				}
				else
				{
					ButtonWindowList.ImageCategory = 0;
				}
			}
		}
	}

	private static int ToolWindowStripGapTop => 0;

	private static int ToolWindowStripGapBottom => 1;

	private static int ToolWindowStripGapLeft => 0;

	private static int ToolWindowStripGapRight => 0;

	private static int ToolWindowImageHeight => 16;

	private static int ToolWindowImageWidth => 16;

	private static int ToolWindowImageGapTop => 3;

	private static int ToolWindowImageGapBottom => 1;

	private static int ToolWindowImageGapLeft => 2;

	private static int ToolWindowImageGapRight => 0;

	private static int ToolWindowTextGapRight => 3;

	private static int ToolWindowTabSeperatorGapTop => 3;

	private static int ToolWindowTabSeperatorGapBottom => 3;

	private static string ToolTipClose
	{
		get
		{
			if (m_toolTipClose == null)
			{
				m_toolTipClose = Strings.DockPaneStrip_ToolTipClose;
			}
			return m_toolTipClose;
		}
	}

	private static string ToolTipSelect
	{
		get
		{
			if (m_toolTipSelect == null)
			{
				m_toolTipSelect = Strings.DockPaneStrip_ToolTipWindowList;
			}
			return m_toolTipSelect;
		}
	}

	private TextFormatFlags ToolWindowTextFormat
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Invalid comparison between Unknown and I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			TextFormatFlags val = (TextFormatFlags)32805;
			if ((int)((Control)this).RightToLeft == 1)
			{
				return (TextFormatFlags)(val | 0x20000 | 2);
			}
			return val;
		}
	}

	private static int DocumentStripGapTop => 0;

	private static int DocumentStripGapBottom => 1;

	private TextFormatFlags DocumentTextFormat
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Invalid comparison between Unknown and I4
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			TextFormatFlags val = (TextFormatFlags)32805;
			if ((int)((Control)this).RightToLeft == 1)
			{
				return (TextFormatFlags)(val | 0x20000);
			}
			return val;
		}
	}

	private static int DocumentTabMaxWidth => 200;

	private static int DocumentButtonGapTop => 4;

	private static int DocumentButtonGapBottom => 4;

	private static int DocumentButtonGapBetween => 0;

	private static int DocumentButtonGapRight => 3;

	private static int DocumentTabGapTop => 3;

	private static int DocumentTabGapLeft => 3;

	private static int DocumentTabGapRight => 3;

	private static int DocumentIconGapBottom => 2;

	private static int DocumentIconGapLeft => 8;

	private static int DocumentIconGapRight => 0;

	private static int DocumentIconWidth => 16;

	private static int DocumentIconHeight => 16;

	private static int DocumentTextGapRight => 3;

	private static Pen PenToolWindowTabBorder => SystemPens.GrayText;

	private static Pen PenDocumentTabActiveBorder => SystemPens.ControlDarkDark;

	private static Pen PenDocumentTabInactiveBorder => SystemPens.GrayText;

	protected internal override Tab CreateTab(IDockContent content)
	{
		return new TabVS2005(content);
	}

	public VS2005DockPaneStrip(DockPane pane)
		: base(pane)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)139282, true);
		((Control)this).SuspendLayout();
		m_components = new Container();
		m_toolTip = new ToolTip(Components);
		m_selectMenu = new ContextMenuStrip(Components);
		((Control)this).ResumeLayout();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			Components.Dispose();
			if (m_boldFont != null)
			{
				m_boldFont.Dispose();
				m_boldFont = null;
			}
		}
		((Control)this).Dispose(disposing);
	}

	protected internal override int MeasureHeight()
	{
		if (base.Appearance == DockPane.AppearanceStyle.ToolWindow)
		{
			return MeasureHeight_ToolWindow();
		}
		return MeasureHeight_Document();
	}

	private int MeasureHeight_ToolWindow()
	{
		if (base.DockPane.IsAutoHide || base.Tabs.Count <= 1)
		{
			return 0;
		}
		return Math.Max(TextFont.Height, ToolWindowImageHeight + ToolWindowImageGapTop + ToolWindowImageGapBottom) + ToolWindowStripGapTop + ToolWindowStripGapBottom;
	}

	private int MeasureHeight_Document()
	{
		return Math.Max(TextFont.Height + DocumentTabGapTop, ((Control)ButtonClose).Height + DocumentButtonGapTop + DocumentButtonGapBottom) + DocumentStripGapBottom + DocumentStripGapTop;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		Rectangle tabsRectangle = TabsRectangle;
		if (base.Appearance == DockPane.AppearanceStyle.Document)
		{
			tabsRectangle.X -= DocumentTabGapLeft;
			tabsRectangle.Width += DocumentTabGapLeft + DocumentTabGapRight + DocumentButtonGapRight + ((Control)ButtonClose).Width + ((Control)ButtonWindowList).Width;
			if (tabsRectangle.Width > 0 && tabsRectangle.Height > 0)
			{
				Color startColor = base.DockPane.DockPanel.Skin.DockPaneStripSkin.DocumentGradient.DockStripGradient.StartColor;
				Color endColor = base.DockPane.DockPanel.Skin.DockPaneStripSkin.DocumentGradient.DockStripGradient.EndColor;
				LinearGradientMode linearGradientMode = base.DockPane.DockPanel.Skin.DockPaneStripSkin.DocumentGradient.DockStripGradient.LinearGradientMode;
				LinearGradientBrush val = new LinearGradientBrush(tabsRectangle, startColor, endColor, linearGradientMode);
				try
				{
					e.Graphics.FillRectangle((Brush)(object)val, tabsRectangle);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
		}
		else
		{
			Color startColor2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.DockStripGradient.StartColor;
			Color endColor2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.DockStripGradient.EndColor;
			LinearGradientMode linearGradientMode2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.DockStripGradient.LinearGradientMode;
			LinearGradientBrush val2 = new LinearGradientBrush(tabsRectangle, startColor2, endColor2, linearGradientMode2);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val2, tabsRectangle);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		((Control)this).OnPaint(e);
		CalculateTabs();
		if (base.Appearance == DockPane.AppearanceStyle.Document && base.DockPane.ActiveContent != null && EnsureDocumentTabVisible(base.DockPane.ActiveContent, repaint: false))
		{
			CalculateTabs();
		}
		DrawTabStrip(e.Graphics);
	}

	protected override void OnRefreshChanges()
	{
		SetInertButtons();
		((Control)this).Invalidate();
	}

	protected internal override GraphicsPath GetOutline(int index)
	{
		if (base.Appearance == DockPane.AppearanceStyle.Document)
		{
			return GetOutline_Document(index);
		}
		return GetOutline_ToolWindow(index);
	}

	private GraphicsPath GetOutline_Document(int index)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		Rectangle tabRectangle = GetTabRectangle(index);
		tabRectangle.X -= tabRectangle.Height / 2;
		tabRectangle.Intersect(TabsRectangle);
		tabRectangle = ((Control)this).RectangleToScreen(DrawHelper.RtlTransform((Control)(object)this, tabRectangle));
		Rectangle rectangle = ((Control)base.DockPane).RectangleToScreen(((Control)base.DockPane).ClientRectangle);
		GraphicsPath val = new GraphicsPath();
		GraphicsPath tabOutline_Document = GetTabOutline_Document(base.Tabs[index], rtlTransform: true, toScreen: true, full: true);
		val.AddPath(tabOutline_Document, true);
		if (base.DockPane.DockPanel.DocumentTabStripLocation == DocumentTabStripLocation.Bottom)
		{
			val.AddLine(tabRectangle.Right, tabRectangle.Top, rectangle.Right, tabRectangle.Top);
			val.AddLine(rectangle.Right, tabRectangle.Top, rectangle.Right, rectangle.Top);
			val.AddLine(rectangle.Right, rectangle.Top, rectangle.Left, rectangle.Top);
			val.AddLine(rectangle.Left, rectangle.Top, rectangle.Left, tabRectangle.Top);
			val.AddLine(rectangle.Left, tabRectangle.Top, tabRectangle.Right, tabRectangle.Top);
		}
		else
		{
			val.AddLine(tabRectangle.Right, tabRectangle.Bottom, rectangle.Right, tabRectangle.Bottom);
			val.AddLine(rectangle.Right, tabRectangle.Bottom, rectangle.Right, rectangle.Bottom);
			val.AddLine(rectangle.Right, rectangle.Bottom, rectangle.Left, rectangle.Bottom);
			val.AddLine(rectangle.Left, rectangle.Bottom, rectangle.Left, tabRectangle.Bottom);
			val.AddLine(rectangle.Left, tabRectangle.Bottom, tabRectangle.Right, tabRectangle.Bottom);
		}
		return val;
	}

	private GraphicsPath GetOutline_ToolWindow(int index)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		Rectangle tabRectangle = GetTabRectangle(index);
		tabRectangle.Intersect(TabsRectangle);
		tabRectangle = ((Control)this).RectangleToScreen(DrawHelper.RtlTransform((Control)(object)this, tabRectangle));
		Rectangle rectangle = ((Control)base.DockPane).RectangleToScreen(((Control)base.DockPane).ClientRectangle);
		GraphicsPath val = new GraphicsPath();
		GraphicsPath tabOutline = GetTabOutline(base.Tabs[index], rtlTransform: true, toScreen: true);
		val.AddPath(tabOutline, true);
		val.AddLine(tabRectangle.Left, tabRectangle.Top, rectangle.Left, tabRectangle.Top);
		val.AddLine(rectangle.Left, tabRectangle.Top, rectangle.Left, rectangle.Top);
		val.AddLine(rectangle.Left, rectangle.Top, rectangle.Right, rectangle.Top);
		val.AddLine(rectangle.Right, rectangle.Top, rectangle.Right, tabRectangle.Top);
		val.AddLine(rectangle.Right, tabRectangle.Top, tabRectangle.Right, tabRectangle.Top);
		return val;
	}

	private void CalculateTabs()
	{
		if (base.Appearance == DockPane.AppearanceStyle.ToolWindow)
		{
			CalculateTabs_ToolWindow();
		}
		else
		{
			CalculateTabs_Document();
		}
	}

	private void CalculateTabs_ToolWindow()
	{
		if (base.Tabs.Count <= 1 || base.DockPane.IsAutoHide)
		{
			return;
		}
		Rectangle tabStripRectangle = TabStripRectangle;
		int count = base.Tabs.Count;
		foreach (TabVS2005 item in (IEnumerable<Tab>)base.Tabs)
		{
			item.MaxWidth = GetMaxTabWidth(base.Tabs.IndexOf(item));
			item.Flag = false;
		}
		bool flag = true;
		int num = tabStripRectangle.Width - ToolWindowStripGapLeft - ToolWindowStripGapRight;
		int num2 = 0;
		int num3 = num / count;
		int num4 = count;
		flag = true;
		while (flag && num4 > 0)
		{
			flag = false;
			foreach (TabVS2005 item2 in (IEnumerable<Tab>)base.Tabs)
			{
				if (!item2.Flag && item2.MaxWidth <= num3)
				{
					item2.Flag = true;
					item2.TabWidth = item2.MaxWidth;
					num2 += item2.TabWidth;
					flag = true;
					num4--;
				}
			}
			if (num4 != 0)
			{
				num3 = (num - num2) / num4;
			}
		}
		if (num4 > 0)
		{
			int num5 = num - num2 - num3 * num4;
			foreach (TabVS2005 item3 in (IEnumerable<Tab>)base.Tabs)
			{
				if (!item3.Flag)
				{
					item3.Flag = true;
					if (num5 > 0)
					{
						item3.TabWidth = num3 + 1;
						num5--;
					}
					else
					{
						item3.TabWidth = num3;
					}
				}
			}
		}
		int num6 = tabStripRectangle.X + ToolWindowStripGapLeft;
		foreach (TabVS2005 item4 in (IEnumerable<Tab>)base.Tabs)
		{
			item4.TabX = num6;
			num6 += item4.TabWidth;
		}
	}

	private bool CalculateDocumentTab(Rectangle rectTabStrip, ref int x, int index)
	{
		bool result = false;
		TabVS2005 tabVS = base.Tabs[index] as TabVS2005;
		tabVS.MaxWidth = GetMaxTabWidth(index);
		int num = Math.Min(tabVS.MaxWidth, DocumentTabMaxWidth);
		if (x + num < rectTabStrip.Right || index == StartDisplayingTab)
		{
			tabVS.TabX = x;
			tabVS.TabWidth = num;
			EndDisplayingTab = index;
		}
		else
		{
			tabVS.TabX = 0;
			tabVS.TabWidth = 0;
			result = true;
		}
		x += num;
		return result;
	}

	private void CalculateTabs_Document()
	{
		if (m_startDisplayingTab >= base.Tabs.Count)
		{
			m_startDisplayingTab = 0;
		}
		Rectangle tabsRectangle = TabsRectangle;
		int x = tabsRectangle.X + tabsRectangle.Height / 2;
		bool flag = false;
		if (m_startDisplayingTab > 0)
		{
			int x2 = x;
			TabVS2005 tabVS = base.Tabs[m_startDisplayingTab] as TabVS2005;
			tabVS.MaxWidth = GetMaxTabWidth(m_startDisplayingTab);
			for (int num = StartDisplayingTab; num >= 0; num--)
			{
				CalculateDocumentTab(tabsRectangle, ref x2, num);
			}
			FirstDisplayingTab = EndDisplayingTab;
			x2 = x;
			for (int i = EndDisplayingTab; i < base.Tabs.Count; i++)
			{
				flag = CalculateDocumentTab(tabsRectangle, ref x2, i);
			}
			if (FirstDisplayingTab != 0)
			{
				flag = true;
			}
		}
		else
		{
			for (int j = StartDisplayingTab; j < base.Tabs.Count; j++)
			{
				flag = CalculateDocumentTab(tabsRectangle, ref x, j);
			}
			for (int k = 0; k < StartDisplayingTab; k++)
			{
				flag = CalculateDocumentTab(tabsRectangle, ref x, k);
			}
			FirstDisplayingTab = StartDisplayingTab;
		}
		if (!flag)
		{
			m_startDisplayingTab = 0;
			FirstDisplayingTab = 0;
			x = tabsRectangle.X + tabsRectangle.Height / 2;
			foreach (TabVS2005 item in (IEnumerable<Tab>)base.Tabs)
			{
				item.TabX = x;
				x += item.TabWidth;
			}
		}
		DocumentTabsOverflow = flag;
	}

	protected internal override void EnsureTabVisible(IDockContent content)
	{
		if (base.Appearance == DockPane.AppearanceStyle.Document && base.Tabs.Contains(content))
		{
			CalculateTabs();
			EnsureDocumentTabVisible(content, repaint: true);
		}
	}

	private bool EnsureDocumentTabVisible(IDockContent content, bool repaint)
	{
		int num = base.Tabs.IndexOf(content);
		TabVS2005 tabVS = base.Tabs[num] as TabVS2005;
		if (tabVS.TabWidth != 0)
		{
			return false;
		}
		StartDisplayingTab = num;
		if (repaint)
		{
			((Control)this).Invalidate();
		}
		return true;
	}

	private int GetMaxTabWidth(int index)
	{
		if (base.Appearance == DockPane.AppearanceStyle.ToolWindow)
		{
			return GetMaxTabWidth_ToolWindow(index);
		}
		return GetMaxTabWidth_Document(index);
	}

	private int GetMaxTabWidth_ToolWindow(int index)
	{
		IDockContent content = base.Tabs[index].Content;
		Size size = TextRenderer.MeasureText(content.DockHandler.TabText, TextFont);
		return ToolWindowImageWidth + size.Width + ToolWindowImageGapLeft + ToolWindowImageGapRight + ToolWindowTextGapRight;
	}

	private int GetMaxTabWidth_Document(int index)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		IDockContent content = base.Tabs[index].Content;
		int height = GetTabRectangle_Document(index).Height;
		Size size = TextRenderer.MeasureText(content.DockHandler.TabText, BoldFont, new Size(DocumentTabMaxWidth, height), DocumentTextFormat);
		if (base.DockPane.DockPanel.ShowDocumentIcon)
		{
			return size.Width + DocumentIconWidth + DocumentIconGapLeft + DocumentIconGapRight + DocumentTextGapRight;
		}
		return size.Width + DocumentIconGapLeft + DocumentTextGapRight;
	}

	private void DrawTabStrip(Graphics g)
	{
		if (base.Appearance == DockPane.AppearanceStyle.Document)
		{
			DrawTabStrip_Document(g);
		}
		else
		{
			DrawTabStrip_ToolWindow(g);
		}
	}

	private void DrawTabStrip_Document(Graphics g)
	{
		int count = base.Tabs.Count;
		if (count == 0)
		{
			return;
		}
		Rectangle tabStripRectangle = TabStripRectangle;
		Rectangle tabsRectangle = TabsRectangle;
		Rectangle empty = Rectangle.Empty;
		TabVS2005 tabVS = null;
		g.SetClip(DrawHelper.RtlTransform((Control)(object)this, tabsRectangle));
		for (int i = 0; i < count; i++)
		{
			empty = GetTabRectangle(i);
			if (base.Tabs[i].Content == base.DockPane.ActiveContent)
			{
				tabVS = base.Tabs[i] as TabVS2005;
			}
			else if (empty.IntersectsWith(tabsRectangle))
			{
				DrawTab(g, base.Tabs[i] as TabVS2005, empty);
			}
		}
		g.SetClip(tabStripRectangle);
		if (base.DockPane.DockPanel.DocumentTabStripLocation == DocumentTabStripLocation.Bottom)
		{
			g.DrawLine(PenDocumentTabActiveBorder, tabStripRectangle.Left, tabStripRectangle.Top + 1, tabStripRectangle.Right, tabStripRectangle.Top + 1);
		}
		else
		{
			g.DrawLine(PenDocumentTabActiveBorder, tabStripRectangle.Left, tabStripRectangle.Bottom - 1, tabStripRectangle.Right, tabStripRectangle.Bottom - 1);
		}
		g.SetClip(DrawHelper.RtlTransform((Control)(object)this, tabsRectangle));
		if (tabVS != null)
		{
			empty = GetTabRectangle(base.Tabs.IndexOf(tabVS));
			if (empty.IntersectsWith(tabsRectangle))
			{
				DrawTab(g, tabVS, empty);
			}
		}
	}

	private void DrawTabStrip_ToolWindow(Graphics g)
	{
		Rectangle tabStripRectangle = TabStripRectangle;
		g.DrawLine(PenToolWindowTabBorder, tabStripRectangle.Left, tabStripRectangle.Top, tabStripRectangle.Right, tabStripRectangle.Top);
		for (int i = 0; i < base.Tabs.Count; i++)
		{
			DrawTab(g, base.Tabs[i] as TabVS2005, GetTabRectangle(i));
		}
	}

	private Rectangle GetTabRectangle(int index)
	{
		if (base.Appearance == DockPane.AppearanceStyle.ToolWindow)
		{
			return GetTabRectangle_ToolWindow(index);
		}
		return GetTabRectangle_Document(index);
	}

	private Rectangle GetTabRectangle_ToolWindow(int index)
	{
		Rectangle tabStripRectangle = TabStripRectangle;
		TabVS2005 tabVS = (TabVS2005)base.Tabs[index];
		return new Rectangle(tabVS.TabX, tabStripRectangle.Y, tabVS.TabWidth, tabStripRectangle.Height);
	}

	private Rectangle GetTabRectangle_Document(int index)
	{
		Rectangle tabStripRectangle = TabStripRectangle;
		TabVS2005 tabVS = (TabVS2005)base.Tabs[index];
		Rectangle result = new Rectangle
		{
			X = tabVS.TabX,
			Width = tabVS.TabWidth,
			Height = tabStripRectangle.Height - DocumentTabGapTop
		};
		if (base.DockPane.DockPanel.DocumentTabStripLocation == DocumentTabStripLocation.Bottom)
		{
			result.Y = tabStripRectangle.Y + DocumentStripGapBottom;
		}
		else
		{
			result.Y = tabStripRectangle.Y + DocumentTabGapTop;
		}
		return result;
	}

	private void DrawTab(Graphics g, TabVS2005 tab, Rectangle rect)
	{
		if (base.Appearance == DockPane.AppearanceStyle.ToolWindow)
		{
			DrawTab_ToolWindow(g, tab, rect);
		}
		else
		{
			DrawTab_Document(g, tab, rect);
		}
	}

	private GraphicsPath GetTabOutline(Tab tab, bool rtlTransform, bool toScreen)
	{
		if (base.Appearance == DockPane.AppearanceStyle.ToolWindow)
		{
			return GetTabOutline_ToolWindow(tab, rtlTransform, toScreen);
		}
		return GetTabOutline_Document(tab, rtlTransform, toScreen, full: false);
	}

	private GraphicsPath GetTabOutline_ToolWindow(Tab tab, bool rtlTransform, bool toScreen)
	{
		Rectangle rectangle = GetTabRectangle(base.Tabs.IndexOf(tab));
		if (rtlTransform)
		{
			rectangle = DrawHelper.RtlTransform((Control)(object)this, rectangle);
		}
		if (toScreen)
		{
			rectangle = ((Control)this).RectangleToScreen(rectangle);
		}
		DrawHelper.GetRoundedCornerTab(GraphicsPath, rectangle, upCorner: false);
		return GraphicsPath;
	}

	private GraphicsPath GetTabOutline_Document(Tab tab, bool rtlTransform, bool toScreen, bool full)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Invalid comparison between Unknown and I4
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Invalid comparison between Unknown and I4
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Invalid comparison between Unknown and I4
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Invalid comparison between Unknown and I4
		int num = 6;
		GraphicsPath.Reset();
		Rectangle rectangle = GetTabRectangle(base.Tabs.IndexOf(tab));
		if (rtlTransform)
		{
			rectangle = DrawHelper.RtlTransform((Control)(object)this, rectangle);
		}
		if (toScreen)
		{
			rectangle = ((Control)this).RectangleToScreen(rectangle);
		}
		if (tab.Content == base.DockPane.ActiveContent || full || base.Tabs.IndexOf(tab) == FirstDisplayingTab)
		{
			if ((int)((Control)this).RightToLeft == 1)
			{
				if (base.DockPane.DockPanel.DocumentTabStripLocation == DocumentTabStripLocation.Bottom)
				{
					GraphicsPath.AddLine(rectangle.Right + rectangle.Height / 2, rectangle.Top, rectangle.Right - rectangle.Height / 2 + num / 2, rectangle.Bottom - num / 2);
				}
				else
				{
					GraphicsPath.AddLine(rectangle.Right, rectangle.Bottom, rectangle.Right + rectangle.Height / 2, rectangle.Bottom);
					GraphicsPath.AddLine(rectangle.Right + rectangle.Height / 2, rectangle.Bottom, rectangle.Right - rectangle.Height / 2 + num / 2, rectangle.Top + num / 2);
				}
			}
			else if (base.DockPane.DockPanel.DocumentTabStripLocation == DocumentTabStripLocation.Bottom)
			{
				GraphicsPath.AddLine(rectangle.Left - rectangle.Height / 2, rectangle.Top, rectangle.Left + rectangle.Height / 2 - num / 2, rectangle.Bottom - num / 2);
			}
			else
			{
				GraphicsPath.AddLine(rectangle.Left, rectangle.Bottom, rectangle.Left - rectangle.Height / 2, rectangle.Bottom);
				GraphicsPath.AddLine(rectangle.Left - rectangle.Height / 2, rectangle.Bottom, rectangle.Left + rectangle.Height / 2 - num / 2, rectangle.Top + num / 2);
			}
		}
		else if ((int)((Control)this).RightToLeft == 1)
		{
			if (base.DockPane.DockPanel.DocumentTabStripLocation == DocumentTabStripLocation.Bottom)
			{
				GraphicsPath.AddLine(rectangle.Right, rectangle.Top, rectangle.Right, rectangle.Top + rectangle.Height / 2);
				GraphicsPath.AddLine(rectangle.Right, rectangle.Top + rectangle.Height / 2, rectangle.Right - rectangle.Height / 2 + num / 2, rectangle.Bottom - num / 2);
			}
			else
			{
				GraphicsPath.AddLine(rectangle.Right, rectangle.Bottom, rectangle.Right, rectangle.Bottom - rectangle.Height / 2);
				GraphicsPath.AddLine(rectangle.Right, rectangle.Bottom - rectangle.Height / 2, rectangle.Right - rectangle.Height / 2 + num / 2, rectangle.Top + num / 2);
			}
		}
		else if (base.DockPane.DockPanel.DocumentTabStripLocation == DocumentTabStripLocation.Bottom)
		{
			GraphicsPath.AddLine(rectangle.Left, rectangle.Top, rectangle.Left, rectangle.Top + rectangle.Height / 2);
			GraphicsPath.AddLine(rectangle.Left, rectangle.Top + rectangle.Height / 2, rectangle.Left + rectangle.Height / 2 - num / 2, rectangle.Bottom - num / 2);
		}
		else
		{
			GraphicsPath.AddLine(rectangle.Left, rectangle.Bottom, rectangle.Left, rectangle.Bottom - rectangle.Height / 2);
			GraphicsPath.AddLine(rectangle.Left, rectangle.Bottom - rectangle.Height / 2, rectangle.Left + rectangle.Height / 2 - num / 2, rectangle.Top + num / 2);
		}
		if ((int)((Control)this).RightToLeft == 1)
		{
			if (base.DockPane.DockPanel.DocumentTabStripLocation == DocumentTabStripLocation.Bottom)
			{
				GraphicsPath.AddLine(rectangle.Right - rectangle.Height / 2 - num / 2, rectangle.Bottom, rectangle.Left + num / 2, rectangle.Bottom);
			}
			else
			{
				GraphicsPath.AddLine(rectangle.Right - rectangle.Height / 2 - num / 2, rectangle.Top, rectangle.Left + num / 2, rectangle.Top);
				GraphicsPath.AddArc(new Rectangle(rectangle.Left, rectangle.Top, num, num), 180f, 90f);
			}
		}
		else if (base.DockPane.DockPanel.DocumentTabStripLocation == DocumentTabStripLocation.Bottom)
		{
			GraphicsPath.AddLine(rectangle.Left + rectangle.Height / 2 + num / 2, rectangle.Bottom, rectangle.Right - num / 2, rectangle.Bottom);
		}
		else
		{
			GraphicsPath.AddLine(rectangle.Left + rectangle.Height / 2 + num / 2, rectangle.Top, rectangle.Right - num / 2, rectangle.Top);
			GraphicsPath.AddArc(new Rectangle(rectangle.Right - num, rectangle.Top, num, num), -90f, 90f);
		}
		if (base.Tabs.IndexOf(tab) != EndDisplayingTab && base.Tabs.IndexOf(tab) != base.Tabs.Count - 1 && base.Tabs[base.Tabs.IndexOf(tab) + 1].Content == base.DockPane.ActiveContent && !full)
		{
			if ((int)((Control)this).RightToLeft == 1)
			{
				if (base.DockPane.DockPanel.DocumentTabStripLocation == DocumentTabStripLocation.Bottom)
				{
					GraphicsPath.AddLine(rectangle.Left, rectangle.Bottom - num / 2, rectangle.Left, rectangle.Bottom - rectangle.Height / 2);
					GraphicsPath.AddLine(rectangle.Left, rectangle.Bottom - rectangle.Height / 2, rectangle.Left + rectangle.Height / 2, rectangle.Top);
				}
				else
				{
					GraphicsPath.AddLine(rectangle.Left, rectangle.Top + num / 2, rectangle.Left, rectangle.Top + rectangle.Height / 2);
					GraphicsPath.AddLine(rectangle.Left, rectangle.Top + rectangle.Height / 2, rectangle.Left + rectangle.Height / 2, rectangle.Bottom);
				}
			}
			else if (base.DockPane.DockPanel.DocumentTabStripLocation == DocumentTabStripLocation.Bottom)
			{
				GraphicsPath.AddLine(rectangle.Right, rectangle.Bottom - num / 2, rectangle.Right, rectangle.Bottom - rectangle.Height / 2);
				GraphicsPath.AddLine(rectangle.Right, rectangle.Bottom - rectangle.Height / 2, rectangle.Right - rectangle.Height / 2, rectangle.Top);
			}
			else
			{
				GraphicsPath.AddLine(rectangle.Right, rectangle.Top + num / 2, rectangle.Right, rectangle.Top + rectangle.Height / 2);
				GraphicsPath.AddLine(rectangle.Right, rectangle.Top + rectangle.Height / 2, rectangle.Right - rectangle.Height / 2, rectangle.Bottom);
			}
		}
		else if ((int)((Control)this).RightToLeft == 1)
		{
			if (base.DockPane.DockPanel.DocumentTabStripLocation == DocumentTabStripLocation.Bottom)
			{
				GraphicsPath.AddLine(rectangle.Left, rectangle.Bottom - num / 2, rectangle.Left, rectangle.Top);
			}
			else
			{
				GraphicsPath.AddLine(rectangle.Left, rectangle.Top + num / 2, rectangle.Left, rectangle.Bottom);
			}
		}
		else if (base.DockPane.DockPanel.DocumentTabStripLocation == DocumentTabStripLocation.Bottom)
		{
			GraphicsPath.AddLine(rectangle.Right, rectangle.Bottom - num / 2, rectangle.Right, rectangle.Top);
		}
		else
		{
			GraphicsPath.AddLine(rectangle.Right, rectangle.Top + num / 2, rectangle.Right, rectangle.Bottom);
		}
		return GraphicsPath;
	}

	private void DrawTab_ToolWindow(Graphics g, TabVS2005 tab, Rectangle rect)
	{
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		Rectangle rectangle = new Rectangle(rect.X + ToolWindowImageGapLeft, rect.Y + rect.Height - 1 - ToolWindowImageGapBottom - ToolWindowImageHeight, ToolWindowImageWidth, ToolWindowImageHeight);
		Rectangle rectangle2 = rectangle;
		rectangle2.X += rectangle.Width + ToolWindowImageGapRight;
		rectangle2.Width = rect.Width - rectangle.Width - ToolWindowImageGapLeft - ToolWindowImageGapRight - ToolWindowTextGapRight;
		Rectangle rectangle3 = DrawHelper.RtlTransform((Control)(object)this, rect);
		rectangle2 = DrawHelper.RtlTransform((Control)(object)this, rectangle2);
		rectangle = DrawHelper.RtlTransform((Control)(object)this, rectangle);
		GraphicsPath tabOutline = GetTabOutline(tab, rtlTransform: true, toScreen: false);
		if (base.DockPane.ActiveContent == tab.Content)
		{
			Color startColor = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveTabGradient.StartColor;
			Color endColor = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveTabGradient.EndColor;
			LinearGradientMode linearGradientMode = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveTabGradient.LinearGradientMode;
			g.FillPath((Brush)new LinearGradientBrush(rectangle3, startColor, endColor, linearGradientMode), tabOutline);
			g.DrawPath(PenToolWindowTabBorder, tabOutline);
			Color textColor = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveTabGradient.TextColor;
			TextRenderer.DrawText((IDeviceContext)(object)g, tab.Content.DockHandler.TabText, TextFont, rectangle2, textColor, ToolWindowTextFormat);
		}
		else
		{
			Color startColor2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveTabGradient.StartColor;
			Color endColor2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveTabGradient.EndColor;
			LinearGradientMode linearGradientMode2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveTabGradient.LinearGradientMode;
			g.FillPath((Brush)new LinearGradientBrush(rectangle3, startColor2, endColor2, linearGradientMode2), tabOutline);
			if (base.Tabs.IndexOf(base.DockPane.ActiveContent) != base.Tabs.IndexOf(tab) + 1)
			{
				Point point = new Point(rect.Right, rect.Top + ToolWindowTabSeperatorGapTop);
				Point point2 = new Point(rect.Right, rect.Bottom - ToolWindowTabSeperatorGapBottom);
				g.DrawLine(PenToolWindowTabBorder, DrawHelper.RtlTransform((Control)(object)this, point), DrawHelper.RtlTransform((Control)(object)this, point2));
			}
			Color textColor2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveTabGradient.TextColor;
			TextRenderer.DrawText((IDeviceContext)(object)g, tab.Content.DockHandler.TabText, TextFont, rectangle2, textColor2, ToolWindowTextFormat);
		}
		if (rectangle3.Contains(rectangle))
		{
			g.DrawIcon(tab.Content.DockHandler.Icon, rectangle);
		}
	}

	private void DrawTab_Document(Graphics g, TabVS2005 tab, Rectangle rect)
	{
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		if (tab.TabWidth == 0)
		{
			return;
		}
		Rectangle rectangle = new Rectangle(rect.X + DocumentIconGapLeft, rect.Y + rect.Height - 1 - DocumentIconGapBottom - DocumentIconHeight, DocumentIconWidth, DocumentIconHeight);
		Rectangle rectangle2 = rectangle;
		if (base.DockPane.DockPanel.ShowDocumentIcon)
		{
			rectangle2.X += rectangle.Width + DocumentIconGapRight;
			rectangle2.Y = rect.Y;
			rectangle2.Width = rect.Width - rectangle.Width - DocumentIconGapLeft - DocumentIconGapRight - DocumentTextGapRight;
			rectangle2.Height = rect.Height;
		}
		else
		{
			rectangle2.Width = rect.Width - DocumentIconGapLeft - DocumentTextGapRight;
		}
		Rectangle rectangle3 = DrawHelper.RtlTransform((Control)(object)this, rect);
		Rectangle rectangle4 = DrawHelper.RtlTransform((Control)(object)this, rect);
		rectangle4.Width += rect.X;
		rectangle4.X = 0;
		rectangle2 = DrawHelper.RtlTransform((Control)(object)this, rectangle2);
		rectangle = DrawHelper.RtlTransform((Control)(object)this, rectangle);
		GraphicsPath tabOutline = GetTabOutline(tab, rtlTransform: true, toScreen: false);
		if (base.DockPane.ActiveContent == tab.Content)
		{
			Color startColor = base.DockPane.DockPanel.Skin.DockPaneStripSkin.DocumentGradient.ActiveTabGradient.StartColor;
			Color endColor = base.DockPane.DockPanel.Skin.DockPaneStripSkin.DocumentGradient.ActiveTabGradient.EndColor;
			LinearGradientMode linearGradientMode = base.DockPane.DockPanel.Skin.DockPaneStripSkin.DocumentGradient.ActiveTabGradient.LinearGradientMode;
			g.FillPath((Brush)new LinearGradientBrush(rectangle4, startColor, endColor, linearGradientMode), tabOutline);
			g.DrawPath(PenDocumentTabActiveBorder, tabOutline);
			Color textColor = base.DockPane.DockPanel.Skin.DockPaneStripSkin.DocumentGradient.ActiveTabGradient.TextColor;
			if (base.DockPane.IsActiveDocumentPane)
			{
				TextRenderer.DrawText((IDeviceContext)(object)g, tab.Content.DockHandler.TabText, BoldFont, rectangle2, textColor, DocumentTextFormat);
			}
			else
			{
				TextRenderer.DrawText((IDeviceContext)(object)g, tab.Content.DockHandler.TabText, TextFont, rectangle2, textColor, DocumentTextFormat);
			}
		}
		else
		{
			Color startColor2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.DocumentGradient.InactiveTabGradient.StartColor;
			Color endColor2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.DocumentGradient.InactiveTabGradient.EndColor;
			LinearGradientMode linearGradientMode2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.DocumentGradient.InactiveTabGradient.LinearGradientMode;
			g.FillPath((Brush)new LinearGradientBrush(rectangle4, startColor2, endColor2, linearGradientMode2), tabOutline);
			g.DrawPath(PenDocumentTabInactiveBorder, tabOutline);
			Color textColor2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.DocumentGradient.InactiveTabGradient.TextColor;
			TextRenderer.DrawText((IDeviceContext)(object)g, tab.Content.DockHandler.TabText, TextFont, rectangle2, textColor2, DocumentTextFormat);
		}
		if (rectangle3.Contains(rectangle) && base.DockPane.DockPanel.ShowDocumentIcon)
		{
			g.DrawIcon(tab.Content.DockHandler.Icon, rectangle);
		}
	}

	private void WindowList_Click(object sender, EventArgs e)
	{
		int num = 0;
		int num2 = ((Control)ButtonWindowList).Location.Y + ((Control)ButtonWindowList).Height;
		((ToolStrip)SelectMenu).Items.Clear();
		foreach (TabVS2005 item in (IEnumerable<Tab>)base.Tabs)
		{
			IDockContent content = item.Content;
			ToolStripItem val = ((ToolStrip)SelectMenu).Items.Add(content.DockHandler.TabText, (Image)(object)content.DockHandler.Icon.ToBitmap());
			val.Tag = item.Content;
			val.Click += ContextMenuItem_Click;
		}
		((ToolStripDropDown)SelectMenu).Show((Control)(object)ButtonWindowList, num, num2);
	}

	private void ContextMenuItem_Click(object sender, EventArgs e)
	{
		ToolStripMenuItem val = (ToolStripMenuItem)((sender is ToolStripMenuItem) ? sender : null);
		if (val != null)
		{
			IDockContent activeContent = (IDockContent)((ToolStripItem)val).Tag;
			base.DockPane.ActiveContent = activeContent;
		}
	}

	private void SetInertButtons()
	{
		if (base.Appearance == DockPane.AppearanceStyle.ToolWindow)
		{
			if (m_buttonClose != null)
			{
				((Control)m_buttonClose).Left = -((Control)m_buttonClose).Width;
			}
			if (m_buttonWindowList != null)
			{
				((Control)m_buttonWindowList).Left = -((Control)m_buttonWindowList).Width;
			}
		}
		else
		{
			((Control)ButtonClose).Enabled = base.DockPane.ActiveContent == null || base.DockPane.ActiveContent.DockHandler.CloseButton;
			m_closeButtonVisible = base.DockPane.ActiveContent == null || base.DockPane.ActiveContent.DockHandler.CloseButtonVisible;
			((Control)ButtonClose).Visible = m_closeButtonVisible;
			ButtonClose.RefreshChanges();
			ButtonWindowList.RefreshChanges();
		}
	}

	protected override void OnLayout(LayoutEventArgs levent)
	{
		if (base.Appearance == DockPane.AppearanceStyle.Document)
		{
			LayoutButtons();
			OnRefreshChanges();
		}
		((Control)this).OnLayout(levent);
	}

	private void LayoutButtons()
	{
		Rectangle tabStripRectangle = TabStripRectangle;
		int num = ((Image)ButtonClose.Image).Width;
		int num2 = ((Image)ButtonClose.Image).Height;
		int num3 = tabStripRectangle.Height - DocumentButtonGapTop - DocumentButtonGapBottom;
		if (num2 < num3)
		{
			num *= num3 / num2;
			num2 = num3;
		}
		Size size = new Size(num, num2);
		int x = tabStripRectangle.X + tabStripRectangle.Width - DocumentTabGapLeft - DocumentButtonGapRight - num;
		int y = tabStripRectangle.Y + DocumentButtonGapTop;
		Point location = new Point(x, y);
		((Control)ButtonClose).Bounds = DrawHelper.RtlTransform((Control)(object)this, new Rectangle(location, size));
		if (m_closeButtonVisible)
		{
			location.Offset(-(DocumentButtonGapBetween + num), 0);
		}
		((Control)ButtonWindowList).Bounds = DrawHelper.RtlTransform((Control)(object)this, new Rectangle(location, size));
	}

	private void Close_Click(object sender, EventArgs e)
	{
		base.DockPane.CloseActiveContent();
	}

	protected internal override int HitTest(Point ptMouse)
	{
		if (!TabsRectangle.Contains(ptMouse))
		{
			return -1;
		}
		foreach (Tab item in (IEnumerable<Tab>)base.Tabs)
		{
			GraphicsPath tabOutline = GetTabOutline(item, rtlTransform: true, toScreen: false);
			if (tabOutline.IsVisible(ptMouse))
			{
				return base.Tabs.IndexOf(item);
			}
		}
		return -1;
	}

	protected override void OnMouseHover(EventArgs e)
	{
		int num = HitTest(((Control)this).PointToClient(Control.MousePosition));
		string text = string.Empty;
		((Control)this).OnMouseHover(e);
		if (num != -1)
		{
			TabVS2005 tabVS = base.Tabs[num] as TabVS2005;
			if (!string.IsNullOrEmpty(tabVS.Content.DockHandler.ToolTipText))
			{
				text = tabVS.Content.DockHandler.ToolTipText;
			}
			else if (tabVS.MaxWidth > tabVS.TabWidth)
			{
				text = tabVS.Content.DockHandler.TabText;
			}
		}
		if (m_toolTip.GetToolTip((Control)(object)this) != text)
		{
			m_toolTip.Active = false;
			m_toolTip.SetToolTip((Control)(object)this, text);
			m_toolTip.Active = true;
		}
		((Control)this).ResetMouseEventArgs();
	}

	protected override void OnRightToLeftChanged(EventArgs e)
	{
		((Control)this).OnRightToLeftChanged(e);
		((Control)this).PerformLayout();
	}
}
