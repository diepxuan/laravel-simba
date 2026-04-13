using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AsiaErp.Framework.Docking;

internal class VS2005AutoHideStrip : AutoHideStripBase
{
	private class TabVS2005 : Tab
	{
		private int m_tabX;

		private int m_tabWidth;

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

		internal TabVS2005(IDockContent content)
			: base(content)
		{
		}
	}

	private const int _ImageHeight = 16;

	private const int _ImageWidth = 16;

	private const int _ImageGapTop = 2;

	private const int _ImageGapLeft = 4;

	private const int _ImageGapRight = 2;

	private const int _ImageGapBottom = 2;

	private const int _TextGapLeft = 0;

	private const int _TextGapRight = 0;

	private const int _TabGapTop = 3;

	private const int _TabGapLeft = 4;

	private const int _TabGapBetween = 10;

	private static StringFormat _stringFormatTabHorizontal;

	private static StringFormat _stringFormatTabVertical;

	private static Matrix _matrixIdentity = new Matrix();

	private static DockState[] _dockStates;

	private static GraphicsPath _graphicsPath;

	public Font TextFont => base.DockPanel.Skin.AutoHideStripSkin.TextFont;

	private StringFormat StringFormatTabHorizontal
	{
		get
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Invalid comparison between Unknown and I4
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			if (_stringFormatTabHorizontal == null)
			{
				_stringFormatTabHorizontal = new StringFormat();
				_stringFormatTabHorizontal.Alignment = (StringAlignment)0;
				_stringFormatTabHorizontal.LineAlignment = (StringAlignment)1;
				_stringFormatTabHorizontal.FormatFlags = (StringFormatFlags)4096;
				_stringFormatTabHorizontal.Trimming = (StringTrimming)0;
			}
			if ((int)((Control)this).RightToLeft == 1)
			{
				StringFormat stringFormatTabHorizontal = _stringFormatTabHorizontal;
				stringFormatTabHorizontal.FormatFlags = (StringFormatFlags)(stringFormatTabHorizontal.FormatFlags | 1);
			}
			else
			{
				StringFormat stringFormatTabHorizontal2 = _stringFormatTabHorizontal;
				stringFormatTabHorizontal2.FormatFlags = (StringFormatFlags)(stringFormatTabHorizontal2.FormatFlags & -2);
			}
			return _stringFormatTabHorizontal;
		}
	}

	private StringFormat StringFormatTabVertical
	{
		get
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Invalid comparison between Unknown and I4
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			if (_stringFormatTabVertical == null)
			{
				_stringFormatTabVertical = new StringFormat();
				_stringFormatTabVertical.Alignment = (StringAlignment)0;
				_stringFormatTabVertical.LineAlignment = (StringAlignment)1;
				_stringFormatTabVertical.FormatFlags = (StringFormatFlags)4098;
				_stringFormatTabVertical.Trimming = (StringTrimming)0;
			}
			if ((int)((Control)this).RightToLeft == 1)
			{
				StringFormat stringFormatTabVertical = _stringFormatTabVertical;
				stringFormatTabVertical.FormatFlags = (StringFormatFlags)(stringFormatTabVertical.FormatFlags | 1);
			}
			else
			{
				StringFormat stringFormatTabVertical2 = _stringFormatTabVertical;
				stringFormatTabVertical2.FormatFlags = (StringFormatFlags)(stringFormatTabVertical2.FormatFlags & -2);
			}
			return _stringFormatTabVertical;
		}
	}

	private static int ImageHeight => 16;

	private static int ImageWidth => 16;

	private static int ImageGapTop => 2;

	private static int ImageGapLeft => 4;

	private static int ImageGapRight => 2;

	private static int ImageGapBottom => 2;

	private static int TextGapLeft => 0;

	private static int TextGapRight => 0;

	private static int TabGapTop => 3;

	private static int TabGapLeft => 4;

	private static int TabGapBetween => 10;

	private static Pen PenTabBorder => SystemPens.GrayText;

	private static Matrix MatrixIdentity => _matrixIdentity;

	private static DockState[] DockStates
	{
		get
		{
			if (_dockStates == null)
			{
				_dockStates = new DockState[4];
				_dockStates[0] = DockState.DockLeftAutoHide;
				_dockStates[1] = DockState.DockRightAutoHide;
				_dockStates[2] = DockState.DockTopAutoHide;
				_dockStates[3] = DockState.DockBottomAutoHide;
			}
			return _dockStates;
		}
	}

	internal static GraphicsPath GraphicsPath
	{
		get
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			if (_graphicsPath == null)
			{
				_graphicsPath = new GraphicsPath();
			}
			return _graphicsPath;
		}
	}

	public VS2005AutoHideStrip(DockPanel panel)
		: base(panel)
	{
		((Control)this).SetStyle((ControlStyles)139282, true);
		((Control)this).BackColor = SystemColors.ControlLight;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		Graphics graphics = e.Graphics;
		Color startColor = base.DockPanel.Skin.AutoHideStripSkin.DockStripGradient.StartColor;
		Color endColor = base.DockPanel.Skin.AutoHideStripSkin.DockStripGradient.EndColor;
		LinearGradientMode linearGradientMode = base.DockPanel.Skin.AutoHideStripSkin.DockStripGradient.LinearGradientMode;
		LinearGradientBrush val = new LinearGradientBrush(((Control)this).ClientRectangle, startColor, endColor, linearGradientMode);
		try
		{
			graphics.FillRectangle((Brush)(object)val, ((Control)this).ClientRectangle);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		DrawTabStrip(graphics);
	}

	protected override void OnLayout(LayoutEventArgs levent)
	{
		CalculateTabs();
		base.OnLayout(levent);
	}

	private void DrawTabStrip(Graphics g)
	{
		DrawTabStrip(g, DockState.DockTopAutoHide);
		DrawTabStrip(g, DockState.DockBottomAutoHide);
		DrawTabStrip(g, DockState.DockLeftAutoHide);
		DrawTabStrip(g, DockState.DockRightAutoHide);
	}

	private void DrawTabStrip(Graphics g, DockState dockState)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Rectangle logicalTabStripRectangle = GetLogicalTabStripRectangle(dockState);
		if (logicalTabStripRectangle.IsEmpty)
		{
			return;
		}
		Matrix transform = g.Transform;
		if (dockState == DockState.DockLeftAutoHide || dockState == DockState.DockRightAutoHide)
		{
			Matrix val = new Matrix();
			val.RotateAt(90f, new PointF((float)logicalTabStripRectangle.X + (float)logicalTabStripRectangle.Height / 2f, (float)logicalTabStripRectangle.Y + (float)logicalTabStripRectangle.Height / 2f));
			g.Transform = val;
		}
		foreach (Pane item in (IEnumerable<Pane>)GetPanes(dockState))
		{
			foreach (TabVS2005 item2 in (IEnumerable<Tab>)item.AutoHideTabs)
			{
				DrawTab(g, item2);
			}
		}
		g.Transform = transform;
	}

	private void CalculateTabs()
	{
		CalculateTabs(DockState.DockTopAutoHide);
		CalculateTabs(DockState.DockBottomAutoHide);
		CalculateTabs(DockState.DockLeftAutoHide);
		CalculateTabs(DockState.DockRightAutoHide);
	}

	private void CalculateTabs(DockState dockState)
	{
		Rectangle logicalTabStripRectangle = GetLogicalTabStripRectangle(dockState);
		int num = logicalTabStripRectangle.Height - ImageGapTop - ImageGapBottom;
		int num2 = ImageWidth;
		if (num > ImageHeight)
		{
			num2 = ImageWidth * (num / ImageHeight);
		}
		int num3 = TabGapLeft + logicalTabStripRectangle.X;
		foreach (Pane item in (IEnumerable<Pane>)GetPanes(dockState))
		{
			foreach (TabVS2005 item2 in (IEnumerable<Tab>)item.AutoHideTabs)
			{
				int num4 = num2 + ImageGapLeft + ImageGapRight + TextRenderer.MeasureText(item2.Content.DockHandler.TabText, TextFont).Width + TextGapLeft + TextGapRight;
				item2.TabX = num3;
				item2.TabWidth = num4;
				num3 += num4;
			}
			num3 += TabGapBetween;
		}
	}

	private Rectangle RtlTransform(Rectangle rect, DockState dockState)
	{
		if (dockState == DockState.DockLeftAutoHide || dockState == DockState.DockRightAutoHide)
		{
			return rect;
		}
		return DrawHelper.RtlTransform((Control)(object)this, rect);
	}

	private GraphicsPath GetTabOutline(TabVS2005 tab, bool transformed, bool rtlTransform)
	{
		DockState dockState = tab.Content.DockHandler.DockState;
		Rectangle rect = GetTabRectangle(tab, transformed);
		if (rtlTransform)
		{
			rect = RtlTransform(rect, dockState);
		}
		bool upCorner = dockState == DockState.DockLeftAutoHide || dockState == DockState.DockBottomAutoHide;
		DrawHelper.GetRoundedCornerTab(GraphicsPath, rect, upCorner);
		return GraphicsPath;
	}

	private void DrawTab(Graphics g, TabVS2005 tab)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		Rectangle tabRectangle = GetTabRectangle(tab);
		if (tabRectangle.IsEmpty)
		{
			return;
		}
		DockState dockState = tab.Content.DockHandler.DockState;
		IDockContent content = tab.Content;
		GraphicsPath tabOutline = GetTabOutline(tab, transformed: false, rtlTransform: true);
		Color startColor = base.DockPanel.Skin.AutoHideStripSkin.TabGradient.StartColor;
		Color endColor = base.DockPanel.Skin.AutoHideStripSkin.TabGradient.EndColor;
		LinearGradientMode linearGradientMode = base.DockPanel.Skin.AutoHideStripSkin.TabGradient.LinearGradientMode;
		g.FillPath((Brush)new LinearGradientBrush(tabRectangle, startColor, endColor, linearGradientMode), tabOutline);
		g.DrawPath(PenTabBorder, tabOutline);
		Matrix transform = g.Transform;
		g.Transform = MatrixIdentity;
		Rectangle rect = tabRectangle;
		rect.X += ImageGapLeft;
		rect.Y += ImageGapTop;
		int num = tabRectangle.Height - ImageGapTop - ImageGapBottom;
		int num2 = ImageWidth;
		if (num > ImageHeight)
		{
			num2 = ImageWidth * (num / ImageHeight);
		}
		rect.Height = num;
		rect.Width = num2;
		rect = GetTransformedRectangle(dockState, rect);
		if (dockState == DockState.DockLeftAutoHide || dockState == DockState.DockRightAutoHide)
		{
			Rectangle rectangle = RtlTransform(rect, dockState);
			Point[] array = new Point[3]
			{
				new Point(rectangle.X + rectangle.Width, rectangle.Y),
				new Point(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height),
				new Point(rectangle.X, rectangle.Y)
			};
			Icon val = new Icon(((Form)content).Icon, 16, 16);
			try
			{
				g.DrawImage((Image)(object)val.ToBitmap(), array);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		else
		{
			g.DrawIcon(((Form)content).Icon, RtlTransform(rect, dockState));
		}
		Rectangle rect2 = tabRectangle;
		rect2.X += ImageGapLeft + num2 + ImageGapRight + TextGapLeft;
		rect2.Width -= ImageGapLeft + num2 + ImageGapRight + TextGapLeft;
		rect2 = RtlTransform(GetTransformedRectangle(dockState, rect2), dockState);
		Color textColor = base.DockPanel.Skin.AutoHideStripSkin.TabGradient.TextColor;
		if (dockState == DockState.DockLeftAutoHide || dockState == DockState.DockRightAutoHide)
		{
			g.DrawString(content.DockHandler.TabText, TextFont, (Brush)new SolidBrush(textColor), (RectangleF)rect2, StringFormatTabVertical);
		}
		else
		{
			g.DrawString(content.DockHandler.TabText, TextFont, (Brush)new SolidBrush(textColor), (RectangleF)rect2, StringFormatTabHorizontal);
		}
		g.Transform = transform;
	}

	private Rectangle GetLogicalTabStripRectangle(DockState dockState)
	{
		return GetLogicalTabStripRectangle(dockState, transformed: false);
	}

	private Rectangle GetLogicalTabStripRectangle(DockState dockState, bool transformed)
	{
		if (!DockHelper.IsDockStateAutoHide(dockState))
		{
			return Rectangle.Empty;
		}
		int count = GetPanes(DockState.DockLeftAutoHide).Count;
		int count2 = GetPanes(DockState.DockRightAutoHide).Count;
		int count3 = GetPanes(DockState.DockTopAutoHide).Count;
		int count4 = GetPanes(DockState.DockBottomAutoHide).Count;
		int num = MeasureHeight();
		int num2;
		int num3;
		int width;
		if (dockState == DockState.DockLeftAutoHide && count > 0)
		{
			num2 = 0;
			num3 = ((count3 != 0) ? num : 0);
			width = ((Control)this).Height - ((count3 != 0) ? num : 0) - ((count4 != 0) ? num : 0);
		}
		else if (dockState == DockState.DockRightAutoHide && count2 > 0)
		{
			num2 = ((Control)this).Width - num;
			if (count != 0 && num2 < num)
			{
				num2 = num;
			}
			num3 = ((count3 != 0) ? num : 0);
			width = ((Control)this).Height - ((count3 != 0) ? num : 0) - ((count4 != 0) ? num : 0);
		}
		else if (dockState == DockState.DockTopAutoHide && count3 > 0)
		{
			num2 = ((count != 0) ? num : 0);
			num3 = 0;
			width = ((Control)this).Width - ((count != 0) ? num : 0) - ((count2 != 0) ? num : 0);
		}
		else
		{
			if (dockState != DockState.DockBottomAutoHide || count4 <= 0)
			{
				return Rectangle.Empty;
			}
			num2 = ((count != 0) ? num : 0);
			num3 = ((Control)this).Height - num;
			if (count3 != 0 && num3 < num)
			{
				num3 = num;
			}
			width = ((Control)this).Width - ((count != 0) ? num : 0) - ((count2 != 0) ? num : 0);
		}
		if (!transformed)
		{
			return new Rectangle(num2, num3, width, num);
		}
		return GetTransformedRectangle(dockState, new Rectangle(num2, num3, width, num));
	}

	private Rectangle GetTabRectangle(TabVS2005 tab)
	{
		return GetTabRectangle(tab, transformed: false);
	}

	private Rectangle GetTabRectangle(TabVS2005 tab, bool transformed)
	{
		DockState dockState = tab.Content.DockHandler.DockState;
		Rectangle logicalTabStripRectangle = GetLogicalTabStripRectangle(dockState);
		if (logicalTabStripRectangle.IsEmpty)
		{
			return Rectangle.Empty;
		}
		int tabX = tab.TabX;
		int y = logicalTabStripRectangle.Y + ((dockState != DockState.DockTopAutoHide && dockState != DockState.DockRightAutoHide) ? TabGapTop : 0);
		int tabWidth = tab.TabWidth;
		int height = logicalTabStripRectangle.Height - TabGapTop;
		if (!transformed)
		{
			return new Rectangle(tabX, y, tabWidth, height);
		}
		return GetTransformedRectangle(dockState, new Rectangle(tabX, y, tabWidth, height));
	}

	private Rectangle GetTransformedRectangle(DockState dockState, Rectangle rect)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		if (dockState != DockState.DockLeftAutoHide && dockState != DockState.DockRightAutoHide)
		{
			return rect;
		}
		PointF[] array = new PointF[1];
		array[0].X = (float)rect.X + (float)rect.Width / 2f;
		array[0].Y = (float)rect.Y + (float)rect.Height / 2f;
		Rectangle logicalTabStripRectangle = GetLogicalTabStripRectangle(dockState);
		Matrix val = new Matrix();
		val.RotateAt(90f, new PointF((float)logicalTabStripRectangle.X + (float)logicalTabStripRectangle.Height / 2f, (float)logicalTabStripRectangle.Y + (float)logicalTabStripRectangle.Height / 2f));
		val.TransformPoints(array);
		return new Rectangle((int)(array[0].X - (float)rect.Height / 2f + 0.5f), (int)(array[0].Y - (float)rect.Width / 2f + 0.5f), rect.Height, rect.Width);
	}

	protected override IDockContent HitTest(Point ptMouse)
	{
		DockState[] dockStates = DockStates;
		foreach (DockState dockState in dockStates)
		{
			if (!GetLogicalTabStripRectangle(dockState, transformed: true).Contains(ptMouse))
			{
				continue;
			}
			foreach (Pane item in (IEnumerable<Pane>)GetPanes(dockState))
			{
				foreach (TabVS2005 item2 in (IEnumerable<Tab>)item.AutoHideTabs)
				{
					GraphicsPath tabOutline = GetTabOutline(item2, transformed: true, rtlTransform: true);
					if (tabOutline.IsVisible(ptMouse))
					{
						return item2.Content;
					}
				}
			}
		}
		return null;
	}

	protected internal override int MeasureHeight()
	{
		return Math.Max(ImageGapBottom + ImageGapTop + ImageHeight, TextFont.Height) + TabGapTop;
	}

	protected override void OnRefreshChanges()
	{
		CalculateTabs();
		((Control)this).Invalidate();
	}

	protected override Tab CreateTab(IDockContent content)
	{
		return new TabVS2005(content);
	}
}
