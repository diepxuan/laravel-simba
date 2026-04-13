using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AsiaErp.Framework.Docking;

internal class VS2005DockPaneCaption : DockPaneCaptionBase
{
	private sealed class InertButton : InertButtonBase
	{
		private Bitmap m_image;

		private Bitmap m_imageAutoHide;

		private VS2005DockPaneCaption m_dockPaneCaption;

		private VS2005DockPaneCaption DockPaneCaption => m_dockPaneCaption;

		public bool IsAutoHide => DockPaneCaption.DockPane.IsAutoHide;

		public override Bitmap Image
		{
			get
			{
				if (!IsAutoHide)
				{
					return m_image;
				}
				return m_imageAutoHide;
			}
		}

		public InertButton(VS2005DockPaneCaption dockPaneCaption, Bitmap image, Bitmap imageAutoHide)
		{
			m_dockPaneCaption = dockPaneCaption;
			m_image = image;
			m_imageAutoHide = imageAutoHide;
			RefreshChanges();
		}

		protected override void OnRefreshChanges()
		{
			if (DockPaneCaption.DockPane.DockPanel != null && DockPaneCaption.TextColor != ((Control)this).ForeColor)
			{
				((Control)this).ForeColor = DockPaneCaption.TextColor;
				((Control)this).Invalidate();
			}
		}
	}

	private const int _TextGapTop = 2;

	private const int _TextGapBottom = 0;

	private const int _TextGapLeft = 3;

	private const int _TextGapRight = 3;

	private const int _ButtonGapTop = 2;

	private const int _ButtonGapBottom = 1;

	private const int _ButtonGapBetween = 1;

	private const int _ButtonGapLeft = 1;

	private const int _ButtonGapRight = 2;

	private static Bitmap _imageButtonClose;

	private InertButton m_buttonClose;

	private static Bitmap _imageButtonAutoHide;

	private static Bitmap _imageButtonDock;

	private InertButton m_buttonAutoHide;

	private static Bitmap _imageButtonOptions;

	private InertButton m_buttonOptions;

	private IContainer m_components;

	private ToolTip m_toolTip;

	private static string _toolTipClose;

	private static string _toolTipOptions;

	private static string _toolTipAutoHide;

	private static Blend _activeBackColorGradientBlend;

	private static TextFormatFlags _textFormat = (TextFormatFlags)32804;

	private static Bitmap ImageButtonClose
	{
		get
		{
			if (_imageButtonClose == null)
			{
				_imageButtonClose = Resources.DockPane_Close;
			}
			return _imageButtonClose;
		}
	}

	private InertButton ButtonClose
	{
		get
		{
			if (m_buttonClose == null)
			{
				m_buttonClose = new InertButton(this, ImageButtonClose, ImageButtonClose);
				m_toolTip.SetToolTip((Control)(object)m_buttonClose, ToolTipClose);
				((Control)m_buttonClose).Click += Close_Click;
				((Control)this).Controls.Add((Control)(object)m_buttonClose);
			}
			return m_buttonClose;
		}
	}

	private static Bitmap ImageButtonAutoHide
	{
		get
		{
			if (_imageButtonAutoHide == null)
			{
				_imageButtonAutoHide = Resources.DockPane_AutoHide;
			}
			return _imageButtonAutoHide;
		}
	}

	private static Bitmap ImageButtonDock
	{
		get
		{
			if (_imageButtonDock == null)
			{
				_imageButtonDock = Resources.DockPane_Dock;
			}
			return _imageButtonDock;
		}
	}

	private InertButton ButtonAutoHide
	{
		get
		{
			if (m_buttonAutoHide == null)
			{
				m_buttonAutoHide = new InertButton(this, ImageButtonDock, ImageButtonAutoHide);
				m_toolTip.SetToolTip((Control)(object)m_buttonAutoHide, ToolTipAutoHide);
				((Control)m_buttonAutoHide).Click += AutoHide_Click;
				((Control)this).Controls.Add((Control)(object)m_buttonAutoHide);
			}
			return m_buttonAutoHide;
		}
	}

	private static Bitmap ImageButtonOptions
	{
		get
		{
			if (_imageButtonOptions == null)
			{
				_imageButtonOptions = Resources.DockPane_Option;
			}
			return _imageButtonOptions;
		}
	}

	private InertButton ButtonOptions
	{
		get
		{
			if (m_buttonOptions == null)
			{
				m_buttonOptions = new InertButton(this, ImageButtonOptions, ImageButtonOptions);
				m_toolTip.SetToolTip((Control)(object)m_buttonOptions, ToolTipOptions);
				((Control)m_buttonOptions).Click += Options_Click;
				((Control)this).Controls.Add((Control)(object)m_buttonOptions);
			}
			return m_buttonOptions;
		}
	}

	private IContainer Components => m_components;

	private static int TextGapTop => 2;

	public Font TextFont => base.DockPane.DockPanel.Skin.DockPaneStripSkin.TextFont;

	private static int TextGapBottom => 0;

	private static int TextGapLeft => 3;

	private static int TextGapRight => 3;

	private static int ButtonGapTop => 2;

	private static int ButtonGapBottom => 1;

	private static int ButtonGapLeft => 1;

	private static int ButtonGapRight => 2;

	private static int ButtonGapBetween => 1;

	private static string ToolTipClose
	{
		get
		{
			if (_toolTipClose == null)
			{
				_toolTipClose = Strings.DockPaneCaption_ToolTipClose;
			}
			return _toolTipClose;
		}
	}

	private static string ToolTipOptions
	{
		get
		{
			if (_toolTipOptions == null)
			{
				_toolTipOptions = Strings.DockPaneCaption_ToolTipOptions;
			}
			return _toolTipOptions;
		}
	}

	private static string ToolTipAutoHide
	{
		get
		{
			if (_toolTipAutoHide == null)
			{
				_toolTipAutoHide = Strings.DockPaneCaption_ToolTipAutoHide;
			}
			return _toolTipAutoHide;
		}
	}

	private static Blend ActiveBackColorGradientBlend
	{
		get
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			if (_activeBackColorGradientBlend == null)
			{
				Blend val = new Blend(2);
				val.Factors = new float[2] { 0.5f, 1f };
				val.Positions = new float[2] { 0f, 1f };
				_activeBackColorGradientBlend = val;
			}
			return _activeBackColorGradientBlend;
		}
	}

	private Color TextColor
	{
		get
		{
			if (base.DockPane.IsActivated)
			{
				return base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveCaptionGradient.TextColor;
			}
			return base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveCaptionGradient.TextColor;
		}
	}

	private TextFormatFlags TextFormat
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((Control)this).RightToLeft == 0)
			{
				return _textFormat;
			}
			return (TextFormatFlags)(_textFormat | 0x20000 | 2);
		}
	}

	private bool CloseButtonEnabled
	{
		get
		{
			if (base.DockPane.ActiveContent == null)
			{
				return false;
			}
			return base.DockPane.ActiveContent.DockHandler.CloseButton;
		}
	}

	private bool CloseButtonVisible
	{
		get
		{
			if (base.DockPane.ActiveContent == null)
			{
				return false;
			}
			return base.DockPane.ActiveContent.DockHandler.CloseButtonVisible;
		}
	}

	private bool ShouldShowAutoHideButton => !base.DockPane.IsFloat;

	public VS2005DockPaneCaption(DockPane pane)
		: base(pane)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		m_components = new Container();
		m_toolTip = new ToolTip(Components);
		((Control)this).ResumeLayout();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			Components.Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	protected internal override int MeasureHeight()
	{
		int num = TextFont.Height + TextGapTop + TextGapBottom;
		if (num < ((Image)ButtonClose.Image).Height + ButtonGapTop + ButtonGapBottom)
		{
			num = ((Image)ButtonClose.Image).Height + ButtonGapTop + ButtonGapBottom;
		}
		return num;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		DrawCaption(e.Graphics);
	}

	private void DrawCaption(Graphics g)
	{
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).ClientRectangle.Width == 0 || ((Control)this).ClientRectangle.Height == 0)
		{
			return;
		}
		if (base.DockPane.IsActivated)
		{
			Color startColor = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveCaptionGradient.StartColor;
			Color endColor = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveCaptionGradient.EndColor;
			LinearGradientMode linearGradientMode = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveCaptionGradient.LinearGradientMode;
			LinearGradientBrush val = new LinearGradientBrush(((Control)this).ClientRectangle, startColor, endColor, linearGradientMode);
			try
			{
				val.Blend = ActiveBackColorGradientBlend;
				g.FillRectangle((Brush)(object)val, ((Control)this).ClientRectangle);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		else
		{
			Color startColor2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveCaptionGradient.StartColor;
			Color endColor2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveCaptionGradient.EndColor;
			LinearGradientMode linearGradientMode2 = base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveCaptionGradient.LinearGradientMode;
			LinearGradientBrush val2 = new LinearGradientBrush(((Control)this).ClientRectangle, startColor2, endColor2, linearGradientMode2);
			try
			{
				g.FillRectangle((Brush)(object)val2, ((Control)this).ClientRectangle);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		Rectangle clientRectangle = ((Control)this).ClientRectangle;
		Rectangle rectangle = clientRectangle;
		rectangle.X += TextGapLeft;
		rectangle.Width -= TextGapLeft + TextGapRight;
		rectangle.Width -= ButtonGapLeft + ((Control)ButtonClose).Width + ButtonGapRight;
		if (ShouldShowAutoHideButton)
		{
			rectangle.Width -= ((Control)ButtonAutoHide).Width + ButtonGapBetween;
		}
		if (base.HasTabPageContextMenu)
		{
			rectangle.Width -= ((Control)ButtonOptions).Width + ButtonGapBetween;
		}
		rectangle.Y += TextGapTop;
		rectangle.Height -= TextGapTop + TextGapBottom;
		Color color = ((!base.DockPane.IsActivated) ? base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveCaptionGradient.TextColor : base.DockPane.DockPanel.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveCaptionGradient.TextColor);
		TextRenderer.DrawText((IDeviceContext)(object)g, base.DockPane.CaptionText, TextFont, DrawHelper.RtlTransform((Control)(object)this, rectangle), color, TextFormat);
	}

	protected override void OnLayout(LayoutEventArgs levent)
	{
		SetButtonsPosition();
		((Control)this).OnLayout(levent);
	}

	protected override void OnRefreshChanges()
	{
		SetButtons();
		((Control)this).Invalidate();
	}

	private void SetButtons()
	{
		((Control)ButtonClose).Enabled = CloseButtonEnabled;
		((Control)ButtonClose).Visible = CloseButtonVisible;
		((Control)ButtonAutoHide).Visible = ShouldShowAutoHideButton;
		((Control)ButtonOptions).Visible = base.HasTabPageContextMenu;
		ButtonClose.RefreshChanges();
		ButtonAutoHide.RefreshChanges();
		ButtonOptions.RefreshChanges();
		SetButtonsPosition();
	}

	private void SetButtonsPosition()
	{
		Rectangle clientRectangle = ((Control)this).ClientRectangle;
		int num = ((Image)ButtonClose.Image).Width;
		int num2 = ((Image)ButtonClose.Image).Height;
		int num3 = clientRectangle.Height - ButtonGapTop - ButtonGapBottom;
		if (num2 < num3)
		{
			num *= num3 / num2;
			num2 = num3;
		}
		Size size = new Size(num, num2);
		int x = clientRectangle.X + clientRectangle.Width - 1 - ButtonGapRight - ((Control)m_buttonClose).Width;
		int y = clientRectangle.Y + ButtonGapTop;
		Point location = new Point(x, y);
		((Control)ButtonClose).Bounds = DrawHelper.RtlTransform((Control)(object)this, new Rectangle(location, size));
		if (CloseButtonVisible)
		{
			location.Offset(-(num + ButtonGapBetween), 0);
		}
		((Control)ButtonAutoHide).Bounds = DrawHelper.RtlTransform((Control)(object)this, new Rectangle(location, size));
		if (ShouldShowAutoHideButton)
		{
			location.Offset(-(num + ButtonGapBetween), 0);
		}
		((Control)ButtonOptions).Bounds = DrawHelper.RtlTransform((Control)(object)this, new Rectangle(location, size));
	}

	private void Close_Click(object sender, EventArgs e)
	{
		base.DockPane.CloseActiveContent();
	}

	private void AutoHide_Click(object sender, EventArgs e)
	{
		base.DockPane.DockState = DockHelper.ToggleAutoHideState(base.DockPane.DockState);
		if (DockHelper.IsDockStateAutoHide(base.DockPane.DockState))
		{
			base.DockPane.DockPanel.ActiveAutoHideContent = null;
			base.DockPane.NestedDockingStatus.NestedPanes.SwitchPaneWithFirstChild(base.DockPane);
		}
	}

	private void Options_Click(object sender, EventArgs e)
	{
		ShowTabPageContextMenu(((Control)this).PointToClient(Control.MousePosition));
	}

	protected override void OnRightToLeftChanged(EventArgs e)
	{
		((Control)this).OnRightToLeftChanged(e);
		((Control)this).PerformLayout();
	}
}
