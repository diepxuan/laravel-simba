using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AsiaErp.Framework.Docking;

public class DockContent : Form, IDockContent
{
	private DockContentHandler m_dockHandler;

	[LocalizedCategory("Category_Docking")]
	[LocalizedDescription("DockContent_TabText_Description")]
	[Localizable(true)]
	[DefaultValue(null)]
	private string m_tabText;

	private static readonly object DockStateChangedEvent;

	[Browsable(false)]
	public DockContentHandler DockHandler => m_dockHandler;

	[LocalizedCategory("Category_Docking")]
	[LocalizedDescription("DockContent_AllowEndUserDocking_Description")]
	[DefaultValue(true)]
	public bool AllowEndUserDocking
	{
		get
		{
			return DockHandler.AllowEndUserDocking;
		}
		set
		{
			DockHandler.AllowEndUserDocking = value;
		}
	}

	[DefaultValue(DockAreas.Float | DockAreas.DockLeft | DockAreas.DockRight | DockAreas.DockTop | DockAreas.DockBottom | DockAreas.Document)]
	[LocalizedCategory("Category_Docking")]
	[LocalizedDescription("DockContent_DockAreas_Description")]
	public DockAreas DockAreas
	{
		get
		{
			return DockHandler.DockAreas;
		}
		set
		{
			DockHandler.DockAreas = value;
		}
	}

	[LocalizedCategory("Category_Docking")]
	[DefaultValue(0.25)]
	[LocalizedDescription("DockContent_AutoHidePortion_Description")]
	public double AutoHidePortion
	{
		get
		{
			return DockHandler.AutoHidePortion;
		}
		set
		{
			DockHandler.AutoHidePortion = value;
		}
	}

	public string TabText
	{
		get
		{
			return m_tabText;
		}
		set
		{
			DockHandler.TabText = (m_tabText = value);
		}
	}

	[LocalizedCategory("Category_Docking")]
	[LocalizedDescription("DockContent_CloseButton_Description")]
	[DefaultValue(true)]
	public bool CloseButton
	{
		get
		{
			return DockHandler.CloseButton;
		}
		set
		{
			DockHandler.CloseButton = value;
		}
	}

	[DefaultValue(true)]
	[LocalizedDescription("DockContent_CloseButtonVisible_Description")]
	[LocalizedCategory("Category_Docking")]
	public bool CloseButtonVisible
	{
		get
		{
			return DockHandler.CloseButtonVisible;
		}
		set
		{
			DockHandler.CloseButtonVisible = value;
		}
	}

	[Browsable(false)]
	public DockPanel DockPanel
	{
		get
		{
			return DockHandler.DockPanel;
		}
		set
		{
			DockHandler.DockPanel = value;
		}
	}

	[Browsable(false)]
	public DockState DockState
	{
		get
		{
			return DockHandler.DockState;
		}
		set
		{
			DockHandler.DockState = value;
		}
	}

	[Browsable(false)]
	public DockPane Pane
	{
		get
		{
			return DockHandler.Pane;
		}
		set
		{
			DockHandler.Pane = value;
		}
	}

	[Browsable(false)]
	public bool IsHidden
	{
		get
		{
			return DockHandler.IsHidden;
		}
		set
		{
			DockHandler.IsHidden = value;
		}
	}

	[Browsable(false)]
	public DockState VisibleState
	{
		get
		{
			return DockHandler.VisibleState;
		}
		set
		{
			DockHandler.VisibleState = value;
		}
	}

	[Browsable(false)]
	public bool IsFloat
	{
		get
		{
			return DockHandler.IsFloat;
		}
		set
		{
			DockHandler.IsFloat = value;
		}
	}

	[Browsable(false)]
	public DockPane PanelPane
	{
		get
		{
			return DockHandler.PanelPane;
		}
		set
		{
			DockHandler.PanelPane = value;
		}
	}

	[Browsable(false)]
	public DockPane FloatPane
	{
		get
		{
			return DockHandler.FloatPane;
		}
		set
		{
			DockHandler.FloatPane = value;
		}
	}

	[DefaultValue(false)]
	[LocalizedCategory("Category_Docking")]
	[LocalizedDescription("DockContent_HideOnClose_Description")]
	public bool HideOnClose
	{
		get
		{
			return DockHandler.HideOnClose;
		}
		set
		{
			DockHandler.HideOnClose = value;
		}
	}

	[LocalizedCategory("Category_Docking")]
	[DefaultValue(DockState.Unknown)]
	[LocalizedDescription("DockContent_ShowHint_Description")]
	public DockState ShowHint
	{
		get
		{
			return DockHandler.ShowHint;
		}
		set
		{
			DockHandler.ShowHint = value;
		}
	}

	[Browsable(false)]
	public bool IsActivated => DockHandler.IsActivated;

	[DefaultValue(null)]
	[LocalizedCategory("Category_Docking")]
	[LocalizedDescription("DockContent_TabPageContextMenu_Description")]
	public ContextMenu TabPageContextMenu
	{
		get
		{
			return DockHandler.TabPageContextMenu;
		}
		set
		{
			DockHandler.TabPageContextMenu = value;
		}
	}

	[LocalizedDescription("DockContent_TabPageContextMenuStrip_Description")]
	[DefaultValue(null)]
	[LocalizedCategory("Category_Docking")]
	public ContextMenuStrip TabPageContextMenuStrip
	{
		get
		{
			return DockHandler.TabPageContextMenuStrip;
		}
		set
		{
			DockHandler.TabPageContextMenuStrip = value;
		}
	}

	[Localizable(true)]
	[LocalizedDescription("DockContent_ToolTipText_Description")]
	[Category("Appearance")]
	[DefaultValue(null)]
	public string ToolTipText
	{
		get
		{
			return DockHandler.ToolTipText;
		}
		set
		{
			DockHandler.ToolTipText = value;
		}
	}

	[LocalizedDescription("Pane_DockStateChanged_Description")]
	[LocalizedCategory("Category_PropertyChanged")]
	public event EventHandler DockStateChanged
	{
		add
		{
			((Component)this).Events.AddHandler(DockStateChangedEvent, value);
		}
		remove
		{
			((Component)this).Events.RemoveHandler(DockStateChangedEvent, value);
		}
	}

	public DockContent()
	{
		m_dockHandler = new DockContentHandler((Form)(object)this, GetPersistString);
		m_dockHandler.DockStateChanged += DockHandler_DockStateChanged;
		((Control)this).ParentChanged += DockContent_ParentChanged;
	}

	private void DockContent_ParentChanged(object Sender, EventArgs e)
	{
		if (((Control)this).Parent != null)
		{
			((Control)this).Font = ((Control)this).Parent.Font;
		}
	}

	private bool ShouldSerializeTabText()
	{
		return m_tabText != null;
	}

	protected virtual string GetPersistString()
	{
		return ((object)this).GetType().ToString();
	}

	public bool IsDockStateValid(DockState dockState)
	{
		return DockHandler.IsDockStateValid(dockState);
	}

	public void Activate()
	{
		DockHandler.Activate();
	}

	public void Hide()
	{
		DockHandler.Hide();
	}

	public void Show()
	{
		DockHandler.Show();
	}

	public void Show(DockPanel dockPanel)
	{
		DockHandler.Show(dockPanel);
	}

	public void Show(DockPanel dockPanel, DockState dockState)
	{
		DockHandler.Show(dockPanel, dockState);
	}

	public void Show(DockPanel dockPanel, Rectangle floatWindowBounds)
	{
		DockHandler.Show(dockPanel, floatWindowBounds);
	}

	public void Show(DockPane pane, IDockContent beforeContent)
	{
		DockHandler.Show(pane, beforeContent);
	}

	public void Show(DockPane previousPane, DockAlignment alignment, double proportion)
	{
		DockHandler.Show(previousPane, alignment, proportion);
	}

	public void FloatAt(Rectangle floatWindowBounds)
	{
		DockHandler.FloatAt(floatWindowBounds);
	}

	public void DockTo(DockPane paneTo, DockStyle dockStyle, int contentIndex)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		DockHandler.DockTo(paneTo, dockStyle, contentIndex);
	}

	public void DockTo(DockPanel panel, DockStyle dockStyle)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		DockHandler.DockTo(panel, dockStyle);
	}

	void IDockContent.OnActivated(EventArgs e)
	{
		((Form)this).OnActivated(e);
	}

	void IDockContent.OnDeactivate(EventArgs e)
	{
		((Form)this).OnDeactivate(e);
	}

	private void DockHandler_DockStateChanged(object sender, EventArgs e)
	{
		OnDockStateChanged(e);
	}

	protected virtual void OnDockStateChanged(EventArgs e)
	{
		((EventHandler)((Component)this).Events[DockStateChanged])?.Invoke(this, e);
	}

	static DockContent()
	{
		DockStateChanged = new object();
	}
}
