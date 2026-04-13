using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using AsiaErp.Framework.Docking;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmT3ModuleMenu : DockContent
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("imgListModule")]
	private ImageList _imgListModule;

	[AccessedThroughProperty("imgListDetail")]
	private ImageList _imgListDetail;

	[AccessedThroughProperty("mnuSpliter")]
	private SplitContainer _mnuSpliter;

	[AccessedThroughProperty("tvwMenu")]
	private TreeView _tvwMenu;

	[AccessedThroughProperty("imgListTreeMenu")]
	private ImageList _imgListTreeMenu;

	[AccessedThroughProperty("flowPanelOptions")]
	private asFlowPanel _flowPanelOptions;

	[AccessedThroughProperty("FlowPanelMenu")]
	private asFlowPanel _FlowPanelMenu;

	[AccessedThroughProperty("mnuContextOptions")]
	private ContextMenuStrip _mnuContextOptions;

	[AccessedThroughProperty("mnuShowMoreModule")]
	private ToolStripMenuItem _mnuShowMoreModule;

	[AccessedThroughProperty("mnuShowFewerModule")]
	private ToolStripMenuItem _mnuShowFewerModule;

	[AccessedThroughProperty("btnOptions")]
	private asModuleButtonAtBottom _btnOptions;

	[AccessedThroughProperty("mnuShowOptionsForm")]
	private ToolStripMenuItem _mnuShowOptionsForm;

	[AccessedThroughProperty("ToolTip1")]
	private ToolTip _ToolTip1;

	[AccessedThroughProperty("imgListModuleButton")]
	private ImageList _imgListModuleButton;

	private ArrayList MenuInfo;

	private IOrderedEnumerable<MenuInformation> arrModules;

	private IOrderedEnumerable<MenuInformation> arrModulesDisplay;

	internal Panel panelDetailMenus;

	internal Label lblCurrentModule;

	private Hashtable f_FormCollection;

	private bool isLoading;

	private int heightOneItem;

	private Font TREE_PARENT_MENU_FONT;

	private Font TREE_CHILD_MENU_FONT;

	private Font DETAIL_MENU_FONT;

	private Font SUB_MENU_FONT;

	private Font MODULE_MENU_FONT;

	private const short PADDING_LEFT = 30;

	private const short ITEM_HEIGHT = 30;

	private Color MODULE_MENU_BACK_COLOR;

	private Color MODULE_MENU_FORE_COLOR;

	private Color MODULE_MENU_SELECTED_FORE_COLOR;

	private Color LEFT_MENU_BACK_COLOR;

	private Color SUB_MENU_FORE_COLOR;

	private Color DETAIL_MENU_FORE_COLOR;

	private Color GRADIENT_COLOR;

	private const string DEFAULT_IMAGE = "detail_icon.gif";

	private readonly short X_COLUMN2;

	private static string T3MENU_SHOW_MORE_MODULE = "Hiện thêm phân hệ";

	private static string T3MENU_HIDE_MORE_MODULE = "Ẩn bớt phân hệ";

	private static string T3MENU_SELECT_MODULE = "Chọn lựa phân hệ";

	internal virtual ImageList imgListModule
	{
		[DebuggerNonUserCode]
		get
		{
			return _imgListModule;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_imgListModule = value;
		}
	}

	internal virtual ImageList imgListDetail
	{
		[DebuggerNonUserCode]
		get
		{
			return _imgListDetail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_imgListDetail = value;
		}
	}

	internal virtual SplitContainer mnuSpliter
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuSpliter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuSpliter = value;
		}
	}

	internal virtual TreeView tvwMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _tvwMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			TreeViewEventHandler val = new TreeViewEventHandler(tvwMenu_AfterCollapse);
			TreeViewEventHandler val2 = new TreeViewEventHandler(tvwMenu_AfterExpand);
			TreeNodeMouseClickEventHandler val3 = new TreeNodeMouseClickEventHandler(tvwMenu_NodeMouseClick);
			KeyEventHandler val4 = new KeyEventHandler(tvwMenu_KeyDown);
			TreeNodeMouseClickEventHandler val5 = new TreeNodeMouseClickEventHandler(tvwMenu_NodeMouseDoubleClick);
			if (_tvwMenu != null)
			{
				_tvwMenu.AfterCollapse -= val;
				_tvwMenu.AfterExpand -= val2;
				_tvwMenu.NodeMouseClick -= val3;
				((Control)_tvwMenu).KeyDown -= val4;
				_tvwMenu.NodeMouseDoubleClick -= val5;
			}
			_tvwMenu = value;
			if (_tvwMenu != null)
			{
				_tvwMenu.AfterCollapse += val;
				_tvwMenu.AfterExpand += val2;
				_tvwMenu.NodeMouseClick += val3;
				((Control)_tvwMenu).KeyDown += val4;
				_tvwMenu.NodeMouseDoubleClick += val5;
			}
		}
	}

	internal virtual ImageList imgListTreeMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _imgListTreeMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_imgListTreeMenu = value;
		}
	}

	internal virtual asFlowPanel flowPanelOptions
	{
		[DebuggerNonUserCode]
		get
		{
			return _flowPanelOptions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_flowPanelOptions = value;
		}
	}

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
			EventHandler eventHandler = FlowPanelMenu_Resize;
			if (_FlowPanelMenu != null)
			{
				((Control)_FlowPanelMenu).Resize -= eventHandler;
			}
			_FlowPanelMenu = value;
			if (_FlowPanelMenu != null)
			{
				((Control)_FlowPanelMenu).Resize += eventHandler;
			}
		}
	}

	internal virtual ContextMenuStrip mnuContextOptions
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuContextOptions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CancelEventHandler cancelEventHandler = mnuContextOptions_Opening;
			if (_mnuContextOptions != null)
			{
				((ToolStripDropDown)_mnuContextOptions).Opening -= cancelEventHandler;
			}
			_mnuContextOptions = value;
			if (_mnuContextOptions != null)
			{
				((ToolStripDropDown)_mnuContextOptions).Opening += cancelEventHandler;
			}
		}
	}

	internal virtual ToolStripMenuItem mnuShowMoreModule
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuShowMoreModule;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuShowMoreModule_Click;
			if (_mnuShowMoreModule != null)
			{
				((ToolStripItem)_mnuShowMoreModule).Click -= eventHandler;
			}
			_mnuShowMoreModule = value;
			if (_mnuShowMoreModule != null)
			{
				((ToolStripItem)_mnuShowMoreModule).Click += eventHandler;
			}
		}
	}

	internal virtual ToolStripMenuItem mnuShowFewerModule
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuShowFewerModule;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuShowFewerModule_Click;
			if (_mnuShowFewerModule != null)
			{
				((ToolStripItem)_mnuShowFewerModule).Click -= eventHandler;
			}
			_mnuShowFewerModule = value;
			if (_mnuShowFewerModule != null)
			{
				((ToolStripItem)_mnuShowFewerModule).Click += eventHandler;
			}
		}
	}

	internal virtual asModuleButtonAtBottom btnOptions
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnOptions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(btnOptions_MouseClick);
			if (_btnOptions != null)
			{
				((Control)_btnOptions).MouseClick -= val;
			}
			_btnOptions = value;
			if (_btnOptions != null)
			{
				((Control)_btnOptions).MouseClick += val;
			}
		}
	}

	internal virtual ToolStripMenuItem mnuShowOptionsForm
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuShowOptionsForm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuShowOptionsForm_Click;
			if (_mnuShowOptionsForm != null)
			{
				((ToolStripItem)_mnuShowOptionsForm).Click -= eventHandler;
			}
			_mnuShowOptionsForm = value;
			if (_mnuShowOptionsForm != null)
			{
				((ToolStripItem)_mnuShowOptionsForm).Click += eventHandler;
			}
		}
	}

	internal virtual ToolTip ToolTip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolTip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolTip1 = value;
		}
	}

	internal virtual ImageList imgListModuleButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _imgListModuleButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_imgListModuleButton = value;
		}
	}

	public frmT3ModuleMenu()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		((Form)this).Load += FrmModuleMenu_Load;
		__ENCAddToList(this);
		isLoading = true;
		TREE_PARENT_MENU_FONT = new Font(FontFamily.GenericSansSerif, 10f, (FontStyle)0);
		TREE_CHILD_MENU_FONT = new Font(FontFamily.GenericSansSerif, 9f, (FontStyle)0);
		DETAIL_MENU_FONT = new Font(FontFamily.GenericSansSerif, 10f, (FontStyle)0);
		SUB_MENU_FONT = new Font(FontFamily.GenericSansSerif, 11f, (FontStyle)1);
		MODULE_MENU_BACK_COLOR = Color.FromArgb(230, 237, 245);
		MODULE_MENU_FORE_COLOR = Color.Black;
		MODULE_MENU_SELECTED_FORE_COLOR = Color.DarkBlue;
		LEFT_MENU_BACK_COLOR = Color.FromArgb(241, 245, 250);
		SUB_MENU_FORE_COLOR = Color.DarkGreen;
		DETAIL_MENU_FORE_COLOR = Color.Black;
		GRADIENT_COLOR = Color.FromArgb(175, 196, 224);
		X_COLUMN2 = Conversions.ToShort(Theme.GetThemeConfiguration()["X_COLUMN2"]);
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
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected O, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected O, but got Unknown
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected O, but got Unknown
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected O, but got Unknown
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmT3ModuleMenu));
		imgListModule = new ImageList(components);
		imgListDetail = new ImageList(components);
		mnuSpliter = new SplitContainer();
		tvwMenu = new TreeView();
		imgListTreeMenu = new ImageList(components);
		flowPanelOptions = new asFlowPanel();
		btnOptions = new asModuleButtonAtBottom();
		mnuContextOptions = new ContextMenuStrip(components);
		mnuShowMoreModule = new ToolStripMenuItem();
		mnuShowFewerModule = new ToolStripMenuItem();
		mnuShowOptionsForm = new ToolStripMenuItem();
		FlowPanelMenu = new asFlowPanel();
		ToolTip1 = new ToolTip(components);
		imgListModuleButton = new ImageList(components);
		((Control)mnuSpliter.Panel1).SuspendLayout();
		((Control)mnuSpliter.Panel2).SuspendLayout();
		((Control)mnuSpliter).SuspendLayout();
		((Control)flowPanelOptions).SuspendLayout();
		((Control)mnuContextOptions).SuspendLayout();
		((Control)this).SuspendLayout();
		imgListModule.ColorDepth = (ColorDepth)32;
		ImageList obj = imgListModule;
		Size imageSize = new Size(32, 32);
		obj.ImageSize = imageSize;
		imgListModule.TransparentColor = Color.Transparent;
		imgListDetail.ColorDepth = (ColorDepth)32;
		ImageList obj2 = imgListDetail;
		imageSize = new Size(32, 32);
		obj2.ImageSize = imageSize;
		imgListDetail.TransparentColor = Color.Transparent;
		((Control)mnuSpliter).BackColor = SystemColors.Control;
		mnuSpliter.Dock = (DockStyle)5;
		SplitContainer obj3 = mnuSpliter;
		Point location = new Point(0, 0);
		((Control)obj3).Location = location;
		((Control)mnuSpliter).Name = "mnuSpliter";
		mnuSpliter.Orientation = (Orientation)0;
		((Control)mnuSpliter.Panel1).Controls.Add((Control)(object)tvwMenu);
		((Control)mnuSpliter.Panel2).Controls.Add((Control)(object)flowPanelOptions);
		((Control)mnuSpliter.Panel2).Controls.Add((Control)(object)FlowPanelMenu);
		SplitContainer obj4 = mnuSpliter;
		imageSize = new Size(250, 708);
		((Control)obj4).Size = imageSize;
		mnuSpliter.SplitterDistance = 370;
		mnuSpliter.SplitterWidth = 5;
		((Control)mnuSpliter).TabIndex = 2;
		tvwMenu.BackColor = SystemColors.Window;
		tvwMenu.BorderStyle = (BorderStyle)0;
		((Control)tvwMenu).Dock = (DockStyle)5;
		tvwMenu.FullRowSelect = true;
		tvwMenu.HideSelection = false;
		tvwMenu.ImageIndex = 0;
		tvwMenu.ImageList = imgListTreeMenu;
		tvwMenu.ItemHeight = 20;
		TreeView obj5 = tvwMenu;
		location = new Point(0, 0);
		((Control)obj5).Location = location;
		((Control)tvwMenu).Name = "tvwMenu";
		tvwMenu.SelectedImageIndex = 0;
		tvwMenu.ShowLines = false;
		tvwMenu.ShowNodeToolTips = true;
		tvwMenu.ShowPlusMinus = false;
		TreeView obj6 = tvwMenu;
		imageSize = new Size(250, 370);
		((Control)obj6).Size = imageSize;
		((Control)tvwMenu).TabIndex = 0;
		imgListTreeMenu.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imgListTreeMenu.ImageStream");
		imgListTreeMenu.TransparentColor = Color.Transparent;
		imgListTreeMenu.Images.SetKeyName(0, "collapse.png");
		imgListTreeMenu.Images.SetKeyName(1, "expand.png");
		((Control)flowPanelOptions).Anchor = (AnchorStyles)14;
		((Control)flowPanelOptions).BackColor = Color.FromArgb(241, 245, 250);
		((Control)flowPanelOptions).Controls.Add((Control)(object)btnOptions);
		flowPanelOptions.DoubleBuffered = false;
		((FlowLayoutPanel)flowPanelOptions).FlowDirection = (FlowDirection)2;
		asFlowPanel obj7 = flowPanelOptions;
		location = new Point(0, 295);
		((Control)obj7).Location = location;
		((Control)flowPanelOptions).Name = "flowPanelOptions";
		asFlowPanel obj8 = flowPanelOptions;
		imageSize = new Size(250, 36);
		((Control)obj8).Size = imageSize;
		((Control)flowPanelOptions).TabIndex = 2;
		((ButtonBase)btnOptions).BackColor = Color.Transparent;
		((Control)btnOptions).ContextMenuStrip = mnuContextOptions;
		((ButtonBase)btnOptions).FlatAppearance.BorderColor = Color.Gray;
		((ButtonBase)btnOptions).FlatAppearance.BorderSize = 0;
		((ButtonBase)btnOptions).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)btnOptions).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)btnOptions).FlatAppearance.MouseOverBackColor = Color.Transparent;
		((ButtonBase)btnOptions).FlatStyle = (FlatStyle)0;
		((Control)btnOptions).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)btnOptions).Image = (Image)componentResourceManager.GetObject("btnOptions.Image");
		asModuleButtonAtBottom obj9 = btnOptions;
		location = new Point(217, 0);
		((Control)obj9).Location = location;
		asModuleButtonAtBottom obj10 = btnOptions;
		Padding val = default(Padding);
		((Padding)(ref val))._002Ector(0);
		((Control)obj10).Margin = val;
		((Control)btnOptions).Name = "btnOptions";
		asModuleButtonAtBottom obj11 = btnOptions;
		imageSize = new Size(33, 33);
		((Control)obj11).Size = imageSize;
		((Control)btnOptions).TabIndex = 0;
		ToolTip1.SetToolTip((Control)(object)btnOptions, "Tùy chỉnh phân hệ");
		((ButtonBase)btnOptions).UseVisualStyleBackColor = true;
		((ToolStripDropDown)mnuContextOptions).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ToolStrip)mnuContextOptions).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)mnuShowMoreModule,
			(ToolStripItem)mnuShowFewerModule,
			(ToolStripItem)mnuShowOptionsForm
		});
		((Control)mnuContextOptions).Name = "ContextMenuStrip1";
		ContextMenuStrip obj12 = mnuContextOptions;
		imageSize = new Size(180, 70);
		((Control)obj12).Size = imageSize;
		((ToolStripItem)mnuShowMoreModule).Name = "mnuShowMoreModule";
		ToolStripMenuItem obj13 = mnuShowMoreModule;
		imageSize = new Size(179, 22);
		((ToolStripItem)obj13).Size = imageSize;
		((ToolStripItem)mnuShowMoreModule).Text = "Hiện thêm phân hệ";
		((ToolStripItem)mnuShowFewerModule).Name = "mnuShowFewerModule";
		ToolStripMenuItem obj14 = mnuShowFewerModule;
		imageSize = new Size(179, 22);
		((ToolStripItem)obj14).Size = imageSize;
		((ToolStripItem)mnuShowFewerModule).Text = "Ẩn bớt phân hệ";
		((ToolStripItem)mnuShowOptionsForm).Name = "mnuShowOptionsForm";
		ToolStripMenuItem obj15 = mnuShowOptionsForm;
		imageSize = new Size(179, 22);
		((ToolStripItem)obj15).Size = imageSize;
		((ToolStripItem)mnuShowOptionsForm).Text = "Chọn lựa phân hệ";
		((Control)FlowPanelMenu).Anchor = (AnchorStyles)15;
		((Control)FlowPanelMenu).BackColor = Color.FromArgb(241, 245, 250);
		FlowPanelMenu.DoubleBuffered = false;
		((FlowLayoutPanel)FlowPanelMenu).FlowDirection = (FlowDirection)1;
		((Control)FlowPanelMenu).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		asFlowPanel flowPanelMenu = FlowPanelMenu;
		location = new Point(0, 0);
		((Control)flowPanelMenu).Location = location;
		asFlowPanel flowPanelMenu2 = FlowPanelMenu;
		((Padding)(ref val))._002Ector(0);
		((Control)flowPanelMenu2).Margin = val;
		((Control)FlowPanelMenu).Name = "FlowPanelMenu";
		asFlowPanel flowPanelMenu3 = FlowPanelMenu;
		((Padding)(ref val))._002Ector(1);
		((Control)flowPanelMenu3).Padding = val;
		asFlowPanel flowPanelMenu4 = FlowPanelMenu;
		imageSize = new Size(250, 295);
		((Control)flowPanelMenu4).Size = imageSize;
		((Control)FlowPanelMenu).TabIndex = 1;
		((FlowLayoutPanel)FlowPanelMenu).WrapContents = false;
		imgListModuleButton.ColorDepth = (ColorDepth)32;
		ImageList obj16 = imgListModuleButton;
		imageSize = new Size(16, 16);
		obj16.ImageSize = imageSize;
		imgListModuleButton.TransparentColor = Color.Transparent;
		AllowEndUserDocking = false;
		AutoHidePortion = 0.1;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)0;
		((Form)this).AutoScroll = true;
		((Form)this).BackColor = Color.FromArgb(241, 245, 250);
		((Control)this).CausesValidation = false;
		imageSize = new Size(250, 708);
		((Form)this).ClientSize = imageSize;
		CloseButton = false;
		CloseButtonVisible = false;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)mnuSpliter);
		DockAreas = DockAreas.DockLeft;
		((Control)this).DoubleBuffered = true;
		((Control)this).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Padding)(ref val))._002Ector(5, 4, 5, 4);
		((Form)this).Margin = val;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmT3ModuleMenu";
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).SizeGripStyle = (SizeGripStyle)2;
		((Form)this).StartPosition = (FormStartPosition)0;
		TabText = "";
		((Form)this).Text = "PHÂN HỆ";
		((Control)mnuSpliter.Panel1).ResumeLayout(false);
		((Control)mnuSpliter.Panel2).ResumeLayout(false);
		((Control)mnuSpliter).ResumeLayout(false);
		((Control)flowPanelOptions).ResumeLayout(false);
		((Control)mnuContextOptions).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void FrmModuleMenu_Load(object sender, EventArgs e)
	{
		((Control)FlowPanelMenu).Resize -= FlowPanelMenu_Resize;
		GetMenuByUserID(SystemInformation.UserName);
		getResource();
		CreateModulesPanel();
		isLoading = false;
		((Control)FlowPanelMenu).Resize += FlowPanelMenu_Resize;
	}

	private void getResource()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		string[] array = (string[])NewLateBinding.LateGet(Theme.GetThemeConfiguration()["MODULE_MENU_FONT"], (Type)null, "Split", new object[1] { "," }, (string[])null, (Type[])null, (bool[])null);
		MODULE_MENU_FONT = new Font(array[0], Conversions.ToSingle(array[1]), (FontStyle)Conversions.ToInteger(array[2]));
		array = (string[])NewLateBinding.LateGet(Theme.GetThemeConfiguration()["SUB_MENU_FONT"], (Type)null, "Split", new object[1] { "," }, (string[])null, (Type[])null, (bool[])null);
		SUB_MENU_FONT = new Font(array[0], Conversions.ToSingle(array[1]), (FontStyle)Conversions.ToInteger(array[2]));
		array = (string[])NewLateBinding.LateGet(Theme.GetThemeConfiguration()["DETAIL_MENU_FONT"], (Type)null, "Split", new object[1] { "," }, (string[])null, (Type[])null, (bool[])null);
		DETAIL_MENU_FONT = new Font(array[0], Conversions.ToSingle(array[1]), (FontStyle)Conversions.ToInteger(array[2]));
		LEFT_MENU_BACK_COLOR = ColorFromConfig(Conversions.ToString(Theme.GetThemeConfiguration()["LEFT_MENU_BACK_COLOR"]));
		MODULE_MENU_BACK_COLOR = ColorFromConfig(Conversions.ToString(Theme.GetThemeConfiguration()["MODULE_MENU_BACK_COLOR"]));
		SUB_MENU_FORE_COLOR = ColorFromConfig(Conversions.ToString(Theme.GetThemeConfiguration()["SUB_MENU_FORE_COLOR"]));
		DETAIL_MENU_FORE_COLOR = ColorFromConfig(Conversions.ToString(Theme.GetThemeConfiguration()["DETAIL_MENU_FORE_COLOR"]));
		MODULE_MENU_FORE_COLOR = ColorFromConfig(Conversions.ToString(Theme.GetThemeConfiguration()["MODULE_MENU_FORE_COLOR"]));
		MODULE_MENU_SELECTED_FORE_COLOR = ColorFromConfig(Conversions.ToString(Theme.GetThemeConfiguration()["MODULE_MENU_SELECTED_FORE_COLOR"]));
		((Control)lblCurrentModule).ForeColor = ColorFromConfig(Conversions.ToString(Theme.GetThemeConfiguration()["CURRENT_MODULE_LABEL_FORE_COLOR"]));
		int num = 280;
		try
		{
			num = Conversions.ToInteger(Theme.GetThemeConfiguration()["MODULE_PANEL_MAX_WIDTH"]);
			AutoHidePortion = num;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			T3MENU_SHOW_MORE_MODULE = AsiaErp.Framework.Environment.getLangFrameworkResX("#STARTUP_T3MENU_SHOW_MORE_MODULE");
			T3MENU_HIDE_MORE_MODULE = AsiaErp.Framework.Environment.getLangFrameworkResX("#STARTUP_T3MENU_HIDE_MORE_MODULE");
			T3MENU_SELECT_MODULE = AsiaErp.Framework.Environment.getLangFrameworkResX("#STARTUP_T3MENU_SELECT_MODULE");
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		((ToolStripItem)mnuShowMoreModule).Text = T3MENU_SHOW_MORE_MODULE;
		((ToolStripItem)mnuShowFewerModule).Text = T3MENU_HIDE_MORE_MODULE;
		((ToolStripItem)mnuShowOptionsForm).Text = T3MENU_SELECT_MODULE;
	}

	private Color ColorFromConfig(string sValue)
	{
		sValue = sValue.Trim();
		Color result = Color.Black;
		if (sValue.ToLower().Contains("rgb"))
		{
			int num = sValue.IndexOf("(");
			int num2 = sValue.IndexOf(")");
			string[] array = sValue.Substring(num + 1, num2 - num - 1).Split(new char[1] { ',' });
			try
			{
				result = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			try
			{
				result = Color.FromName(sValue);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
		return result;
	}

	private void GetMenuByUserID(string userID)
	{
		MainDAO mainDAO = (MainDAO)DAOFactory.CreateDAOInstance("MainDAO", "Simba", a_blnIsSysDB: true);
		MenuInfo = mainDAO.GetMainMenuInfo(SystemInformations.UserName, SystemInformations.CurrentCultureName);
		mainDAO.Destroy();
	}

	private void CreateModulesPanel()
	{
		((Control)this).SuspendLayout();
		((Control)FlowPanelMenu).SuspendLayout();
		arrModules = from object mnu in MenuInfo
			select (MenuInformation)mnu into mnu
			where mnu.stt.EndsWith("00.00")
			select (mnu) into mnu
			orderby mnu.stt
			select mnu;
		List<ModuleInformation> list = ModuleInformation.ReadModuleConfig();
		if (list != null)
		{
			arrModulesDisplay = (IOrderedEnumerable<MenuInformation>)(from mnu in arrModules
				join _module in list on mnu.menuid equals _module.MenuID
				select new VB_0024AnonymousType_0<MenuInformation, ModuleInformation>(mnu, _module) into _0024VB_0024It
				where _0024VB_0024It._module.Checked
				select _0024VB_0024It.mnu into mnu
				orderby mnu.stt
				select mnu).AsEnumerable();
		}
		else
		{
			arrModulesDisplay = arrModules;
		}
		string[] array = (from mnu in arrModules
			group mnu by mnu.picture1 into mnu
			select mnu.Key).ToArray();
		string[] array2 = (from object mnu in MenuInfo
			select (MenuInformation)mnu into mnu
			where !mnu.stt.EndsWith("00.00")
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
				imgListModule.Images.Add(array[num2], Image.FromFile(SystemInformations.GraphicPath + array[num2]));
				imgListModuleButton.Images.Add(array[num2], Image.FromFile(SystemInformations.GraphicPath + array[num2]));
			}
			else
			{
				imgListModule.Images.Add(array[num2], Image.FromFile(SystemInformations.GraphicPath + "detail_icon.gif"));
				imgListModuleButton.Images.Add(array[num2], Image.FromFile(SystemInformations.GraphicPath + "detail_icon.gif"));
			}
			num2++;
		}
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
				imgListDetail.Images.Add(array2[num6], Image.FromFile(SystemInformations.GraphicPath + array2[num6]));
			}
			else
			{
				imgListDetail.Images.Add(array2[num6], Image.FromFile(SystemInformations.GraphicPath + "detail_icon.gif"));
			}
			num6++;
		}
		int num8 = 23;
		Button[] array3 = (Button[])(object)new Button[arrModulesDisplay.Count() - 1 + 1];
		int num9 = arrModulesDisplay.Count() - 1;
		int num10 = 0;
		while (true)
		{
			int num11 = num10;
			int num12 = num9;
			if (num11 > num12)
			{
				break;
			}
			array3[num10] = CreateModuleButton(arrModulesDisplay.ElementAtOrDefault(num10));
			num10++;
		}
		((Control)FlowPanelMenu).BackColor = LEFT_MENU_BACK_COLOR;
		((Control)flowPanelOptions).BackColor = LEFT_MENU_BACK_COLOR;
		tvwMenu.BackColor = LEFT_MENU_BACK_COLOR;
		((Control)FlowPanelMenu).Controls.AddRange((Control[])(object)array3);
		if (array3.Count() > 0)
		{
			array3[0].PerformClick();
		}
		((Control)FlowPanelMenu).ResumeLayout();
		((Control)this).ResumeLayout();
		if (((ArrangedElementCollection)((Control)FlowPanelMenu).Controls).Count > 0)
		{
			heightOneItem = ((Control)FlowPanelMenu).Controls[0].Height;
		}
	}

	private Button CreateModuleButton(MenuInformation mnu)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		Button val = new Button();
		Button val2 = val;
		((Control)val2).Font = MODULE_MENU_FONT;
		((ButtonBase)val2).FlatStyle = (FlatStyle)0;
		((ButtonBase)val2).FlatAppearance.BorderSize = 0;
		((ButtonBase)val2).FlatAppearance.MouseDownBackColor = MODULE_MENU_BACK_COLOR;
		((ButtonBase)val2).FlatAppearance.MouseOverBackColor = MODULE_MENU_BACK_COLOR;
		((Control)val2).ForeColor = MODULE_MENU_FORE_COLOR;
		((ButtonBase)val2).Text = Strings.Space(1) + mnu.bar;
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
		((ButtonBase)val2).Image = imgListModule.Images[mnu.picture1];
		((Control)val2).Click += ModuleButton_Clicked;
		((Control)val2).Paint += new PaintEventHandler(ModuleButton_PaintTopAndBottom);
		((Control)val2).KeyDown += new KeyEventHandler(ModuleButton_KeyDown);
		val2 = null;
		return val;
	}

	private asModuleButtonAtBottom CreateModuleButtonAtBottom(MenuInformation mnu)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		Button val = (Button)(object)new asModuleButtonAtBottom();
		Button val2 = val;
		((Control)val2).Font = MODULE_MENU_FONT;
		((Control)val2).Tag = mnu;
		((ButtonBase)val2).Image = imgListModuleButton.Images[mnu.picture1];
		((Control)val2).Click += ModuleButton_Clicked;
		((Control)val2).MouseEnter += ShowToolTipForModuleAtBottom;
		((Control)val2).KeyDown += new KeyEventHandler(ModuleButton_KeyDown);
		val2 = null;
		return (asModuleButtonAtBottom)(object)val;
	}

	private void ModuleButton_PaintTopAndBottom(object sender, PaintEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		Button val = (Button)sender;
		e.Graphics.DrawLine(Pens.White, 0, 0, ((Control)val).Width, 0);
		e.Graphics.DrawLine(Pens.DarkGray, 0, ((Control)val).Height - 1, ((Control)val).Width, ((Control)val).Height - 1);
		val = null;
	}

	private void ShowToolTipForModuleAtBottom(object sender, EventArgs e)
	{
		asModuleButtonAtBottom asModuleButtonAtBottom2 = (asModuleButtonAtBottom)sender;
		ToolTip1.SetToolTip((Control)(object)asModuleButtonAtBottom2, ((MenuInformation)((Control)asModuleButtonAtBottom2).Tag).bar);
	}

	private void ModuleButton_Clicked(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected O, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected O, but got Unknown
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Expected O, but got Unknown
		Button val = (Button)sender;
		if (DockPanel.Contents.Count > 2)
		{
			DockPanel.Contents[0].DockHandler.Activate();
			((Form)this).ProcessTabKey(true);
		}
		if (((Control)panelDetailMenus).Tag != null)
		{
			Button val2 = (Button)((Control)panelDetailMenus).Tag;
			if (object.ReferenceEquals(val, val2))
			{
				return;
			}
			((ButtonBase)val2).BackColor = Color.Transparent;
			((Control)val2).ForeColor = MODULE_MENU_FORE_COLOR;
		}
		lblCurrentModule.Text = ((MenuInformation)((Control)val).Tag).bar;
		TabText = ((MenuInformation)((Control)val).Tag).bar;
		((ScrollProperties)((ScrollableControl)panelDetailMenus).VerticalScroll).Value = 0;
		((Control)this).SuspendLayout();
		((Control)panelDetailMenus).SuspendLayout();
		((Control)panelDetailMenus).Controls.Clear();
		if (!(val is asModuleButtonAtBottom))
		{
			((ButtonBase)val).BackColor = MODULE_MENU_BACK_COLOR;
			((Control)val).ForeColor = MODULE_MENU_SELECTED_FORE_COLOR;
		}
		((Control)panelDetailMenus).Tag = val;
		IOrderedEnumerable<MenuInformation> source = from object mnu in MenuInfo
			select (MenuInformation)mnu into mnu
			where (Operators.CompareString(mnu.stt.Substring(0, 2), ((MenuInformation)((Control)val).Tag).stt.Substring(0, 2), false) == 0 && mnu.stt.EndsWith("00") && Operators.CompareString(mnu.stt.Substring(3, 2), "00", false) != 0) ? true : false
			select (mnu) into mnu
			orderby mnu.stt
			select mnu;
		if (source.Count() == 0)
		{
			frmDashBoard frmDashBoard2 = new frmDashBoard();
			((Form)frmDashBoard2).TopLevel = false;
			((Control)frmDashBoard2).Dock = (DockStyle)5;
			frmDashBoard2.imgListDetail = imgListDetail;
			frmDashBoard2.MyDockPanel = DockPanel;
			((Control)panelDetailMenus).Controls.Add((Control)(object)frmDashBoard2);
			frmDashBoard2.Show();
			((Control)panelDetailMenus).ResumeLayout();
			((Control)this).ResumeLayout();
			mnuSpliter.Panel1Collapsed = true;
			return;
		}
		mnuSpliter.Panel1Collapsed = false;
		IOrderedEnumerable<MenuInformation> source2 = from object mnu in MenuInfo
			select (MenuInformation)mnu into mnu
			where (Operators.CompareString(mnu.stt.Substring(0, 2), ((MenuInformation)((Control)val).Tag).stt.Substring(0, 2), false) == 0 && Operators.CompareString(mnu.stt, ((MenuInformation)((Control)val).Tag).stt, false) != 0 && source.Count() == 0 && Operators.CompareString(mnu.bar.ToString().Trim(), string.Empty, false) != 0) ? true : false
			select (mnu) into mnu
			orderby mnu.stt
			select mnu;
		int num = 10;
		int num2 = 10;
		tvwMenu.BeginUpdate();
		tvwMenu.Nodes.Clear();
		LinkArea linkArea = default(LinkArea);
		Padding padding = default(Padding);
		if (source2.Count() > 0)
		{
			LinkLabel[] array = (LinkLabel[])(object)new LinkLabel[source2.Count() - 1 + 1];
			byte b = (byte)Math.Round(Math.Ceiling((double)source2.Count() / 2.0));
			byte b2 = (byte)(source2.Count() - 1);
			byte b3 = 0;
			while (true)
			{
				byte num3 = b3;
				byte b4 = b2;
				if ((uint)num3 > (uint)b4)
				{
					break;
				}
				TreeNode val3 = tvwMenu.Nodes.Add(source2.ElementAtOrDefault(b3).bar);
				val3.Tag = source2.ElementAtOrDefault(b3);
				val3.ImageIndex = 111;
				val3.SelectedImageIndex = 111;
				val3.NodeFont = TREE_CHILD_MENU_FONT;
				if (b3 == b)
				{
					num = X_COLUMN2;
					num2 = 10;
				}
				array[b3] = new LinkLabel();
				((Label)array[b3]).AutoSize = true;
				array[b3].Text = source2.ElementAtOrDefault(b3).bar;
				((Control)array[b3]).Tag = source2.ElementAtOrDefault(b3);
				LinkLabel obj = array[b3];
				((LinkArea)(ref linkArea))._002Ector(0, ((Control)array[b3]).Width);
				obj.LinkArea = linkArea;
				((Label)array[b3]).Image = imgListDetail.Images[source2.ElementAtOrDefault(b3).picture1];
				((Label)array[b3]).ImageAlign = (ContentAlignment)16;
				((Label)array[b3]).TextAlign = (ContentAlignment)16;
				array[b3].LinkBehavior = (LinkBehavior)2;
				array[b3].LinkColor = DETAIL_MENU_FORE_COLOR;
				((Control)array[b3]).Font = DETAIL_MENU_FONT;
				LinkLabel obj2 = array[b3];
				((Padding)(ref padding))._002Ector(30, 0, 0, 0);
				obj2.Padding = padding;
				LinkLabel obj3 = array[b3];
				Point location = new Point(num, num2);
				((Control)obj3).Location = location;
				((Control)array[b3]).MouseClick += new MouseEventHandler(DetailLink_MouseCLick);
				num2 += 30;
				b3++;
			}
			((Control)panelDetailMenus).Controls.AddRange((Control[])(object)array);
		}
		else
		{
			byte b5 = (byte)(source.Count() - 1);
			byte b6 = 0;
			_Closure_0024__7._Closure_0024__8 closure_0024__ = default(_Closure_0024__7._Closure_0024__8);
			while (true)
			{
				byte num4 = b6;
				byte b4 = b5;
				if ((uint)num4 > (uint)b4)
				{
					break;
				}
				closure_0024__ = new _Closure_0024__7._Closure_0024__8(closure_0024__);
				TreeNode val4 = tvwMenu.Nodes.Add(source.ElementAtOrDefault(b6).bar);
				val4.NodeFont = TREE_PARENT_MENU_FONT;
				num2 += 5;
				PictureBox val5 = new PictureBox();
				val5.Image = imgListDetail.Images[source.ElementAtOrDefault(b6).picture1];
				((Control)val5).Size = imgListDetail.Images[source.ElementAtOrDefault(b6).picture1].Size;
				Point location = new Point(num, num2 - 5);
				((Control)val5).Location = location;
				((Control)panelDetailMenus).Controls.Add((Control)(object)val5);
				closure_0024__._0024VB_0024Local_subMenu = new LinkLabel();
				((Label)closure_0024__._0024VB_0024Local_subMenu).AutoSize = true;
				closure_0024__._0024VB_0024Local_subMenu.Text = source.ElementAtOrDefault(b6).bar;
				((Control)closure_0024__._0024VB_0024Local_subMenu).Tag = source.ElementAtOrDefault(b6);
				((Control)closure_0024__._0024VB_0024Local_subMenu).Font = SUB_MENU_FONT;
				closure_0024__._0024VB_0024Local_subMenu.LinkBehavior = (LinkBehavior)2;
				closure_0024__._0024VB_0024Local_subMenu.LinkColor = SUB_MENU_FORE_COLOR;
				LinkLabel obj4 = closure_0024__._0024VB_0024Local_subMenu;
				location = new Point(num + ((Control)val5).Width + 10, num2);
				((Control)obj4).Location = location;
				((Label)closure_0024__._0024VB_0024Local_subMenu).ImageAlign = (ContentAlignment)16;
				((Label)closure_0024__._0024VB_0024Local_subMenu).TextAlign = (ContentAlignment)16;
				((Control)panelDetailMenus).Controls.Add((Control)(object)closure_0024__._0024VB_0024Local_subMenu);
				source2 = from mnu in (from object mnu in MenuInfo
						select (MenuInformation)mnu).Where(closure_0024__._Lambda_0024__174)
					select (mnu) into mnu
					orderby mnu.stt
					select mnu;
				LinkLabel[] array2 = (LinkLabel[])(object)new LinkLabel[source2.Count() - 1 + 1];
				byte b7 = (byte)Math.Round(Math.Ceiling((double)source2.Count() / 2.0));
				num = ((Control)closure_0024__._0024VB_0024Local_subMenu).Location.X;
				num2 = ((Control)closure_0024__._0024VB_0024Local_subMenu).Location.Y + 30 + 5;
				byte b8 = (byte)(source2.Count() - 1);
				byte b9 = 0;
				while (true)
				{
					byte num5 = b9;
					b4 = b8;
					if ((uint)num5 > (uint)b4)
					{
						break;
					}
					TreeNode val6 = val4.Nodes.Add(source2.ElementAtOrDefault(b9).bar);
					val6.Tag = source2.ElementAtOrDefault(b9);
					val6.ImageIndex = 111;
					val6.SelectedImageIndex = 111;
					val6.NodeFont = TREE_CHILD_MENU_FONT;
					if (b9 == b7)
					{
						num = X_COLUMN2;
						num2 = ((Control)closure_0024__._0024VB_0024Local_subMenu).Location.Y + 30 + 5;
					}
					array2[b9] = new LinkLabel();
					((Label)array2[b9]).AutoSize = true;
					array2[b9].Text = source2.ElementAtOrDefault(b9).bar;
					((Control)array2[b9]).Tag = source2.ElementAtOrDefault(b9);
					LinkLabel obj5 = array2[b9];
					((LinkArea)(ref linkArea))._002Ector(0, ((Control)array2[b9]).Width);
					obj5.LinkArea = linkArea;
					((Label)array2[b9]).Image = imgListDetail.Images[source2.ElementAtOrDefault(b9).picture1];
					((Label)array2[b9]).ImageAlign = (ContentAlignment)16;
					((Label)array2[b9]).TextAlign = (ContentAlignment)16;
					array2[b9].LinkBehavior = (LinkBehavior)2;
					array2[b9].LinkColor = DETAIL_MENU_FORE_COLOR;
					((Control)array2[b9]).Font = DETAIL_MENU_FONT;
					LinkLabel obj6 = array2[b9];
					((Padding)(ref padding))._002Ector(30, 0, 0, 0);
					obj6.Padding = padding;
					LinkLabel obj7 = array2[b9];
					location = new Point(num, num2);
					((Control)obj7).Location = location;
					((Control)array2[b9]).MouseClick += new MouseEventHandler(DetailLink_MouseCLick);
					num2 += 25;
					b9++;
				}
				((Control)panelDetailMenus).Controls.AddRange((Control[])(object)array2);
				num = 10;
				num2 = ((Control)array2[b7 - 1]).Location.Y + 30;
				b6++;
			}
		}
		tvwMenu.Nodes[0].Expand();
		if (tvwMenu.Nodes[0].FirstNode != null)
		{
			tvwMenu.SelectedNode = tvwMenu.Nodes[0].FirstNode;
		}
		tvwMenu.Nodes[0].EnsureVisible();
		tvwMenu.EndUpdate();
		((Control)panelDetailMenus).ResumeLayout();
		((Control)this).ResumeLayout();
	}

	private void DetailLink_MouseCLick(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			startup.ExecuteCommand((MenuInformation)NewLateBinding.LateGet(sender, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null), DockPanel);
		}
		else
		{
			ShowMenuInfo((MenuInformation)NewLateBinding.LateGet(sender, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	private void ShowMenuInfo(MenuInformation mnu)
	{
		object obj = new MenuInformations();
		NewLateBinding.LateSet(obj, (Type)null, "MenuInformation", new object[1] { mnu }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "MenuDrillDownInformation", new object[1] { AsiaErp.Framework.Environment.GetMenuDrillDownInformation(mnu.menuid) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "CalcInfo", new object[1] { AsiaErp.Framework.Environment.GetCalcInformation(mnu.menuid) }, (string[])null, (Type[])null);
		ArrayList reportInformation = AsiaErp.Framework.Environment.GetReportInformation(mnu.menuid);
		if (reportInformation != null)
		{
			ReportCollection reportCollection = new ReportCollection();
			foreach (ReportInformation item in reportInformation)
			{
				reportCollection.Add(item);
			}
			NewLateBinding.LateSet(obj, (Type)null, "ReportInformation", new object[1] { reportCollection }, (string[])null, (Type[])null);
		}
		DictionaryInformation dictionaryInformation = AsiaErp.Framework.Environment.GetDictionaryInformation(mnu.code_name);
		if (dictionaryInformation != null)
		{
			NewLateBinding.LateSet(obj, (Type)null, "DictionaryInformation", new object[1] { dictionaryInformation }, (string[])null, (Type[])null);
			DAOInformation dAOInformation = AsiaErp.Framework.Environment.GetDAOInformation(dictionaryInformation.table_name);
			NewLateBinding.LateSet(obj, (Type)null, "DAOInformation", new object[1] { dAOInformation }, (string[])null, (Type[])null);
		}
		NewLateBinding.LateSet(obj, (Type)null, "VoucherInformation", new object[1] { AsiaErp.Framework.Environment.GetVoucherInformation(mnu.code_name) }, (string[])null, (Type[])null);
		MenuInformations menuInformations;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, RuntimeHelpers.GetObjectValue(obj));
			memoryStream.Position = 0L;
			menuInformations = (MenuInformations)binaryFormatter.Deserialize(memoryStream);
		}
		object obj2 = new frmObjectProperty();
		try
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "pgColumnInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedObject", new object[1] { menuInformations }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(obj2, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		finally
		{
			if (obj2 != null)
			{
				((IDisposable)obj2).Dispose();
			}
		}
	}

	private void ModuleButton_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			ModuleButton_Clicked(RuntimeHelpers.GetObjectValue(sender), null);
		}
		if ((int)e.KeyCode == 112)
		{
			ShowHelp();
		}
	}

	private void ShowHelp()
	{
		Help.ShowHelp(((Control)this).Parent, "Simba Accounting 12.1.chm", (HelpNavigator)(-2147483642), (object)"");
	}

	private void tvwMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if (((int)((MouseEventArgs)e).Button == 1048576 && e.Node.Tag != null && e.Node.Tag is MenuInformation) ? true : false)
		{
			((Control)this).Cursor = Cursors.WaitCursor;
			startup.ExecuteCommand((MenuInformation)e.Node.Tag, DockPanel);
			((Control)this).Cursor = Cursors.Default;
		}
	}

	private void tvwMenu_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if (((int)e.KeyCode == 13 && tvwMenu.SelectedNode.Tag != null && tvwMenu.SelectedNode.Tag is MenuInformation) ? true : false)
		{
			((Control)this).Cursor = Cursors.WaitCursor;
			startup.ExecuteCommand((MenuInformation)tvwMenu.SelectedNode.Tag, DockPanel);
			((Control)this).Cursor = Cursors.Default;
		}
	}

	private void btnOptions_MouseClick(object sender, MouseEventArgs e)
	{
		((ToolStripDropDown)mnuContextOptions).Show((Control)(object)btnOptions, e.X, e.Y);
	}

	private void mnuShowOptionsForm_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		FrmT3ModuleOptions frmT3ModuleOptions = new FrmT3ModuleOptions(arrModules);
		try
		{
			if ((int)((Form)frmT3ModuleOptions).ShowDialog() != 1)
			{
				return;
			}
			while (((ArrangedElementCollection)((Control)flowPanelOptions).Controls).Count > 1)
			{
				((Control)flowPanelOptions).Controls.RemoveAt(((ArrangedElementCollection)((Control)flowPanelOptions).Controls).Count - 1);
			}
			((Control)FlowPanelMenu).Controls.Clear();
			int num = frmT3ModuleOptions._config.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (frmT3ModuleOptions._config[num2].Checked)
				{
					int index = num2;
					MenuInformation mnu = (from m in arrModules
						where Operators.CompareString(m.menuid, frmT3ModuleOptions._config[index].MenuID, false) == 0
						select (m)).Single();
					((Control)FlowPanelMenu).Controls.Add((Control)(object)CreateModuleButton(mnu));
				}
				num2++;
			}
			if (((ArrangedElementCollection)((Control)FlowPanelMenu).Controls).Count > 0)
			{
				((Button)((Control)FlowPanelMenu).Controls[0]).PerformClick();
			}
		}
		finally
		{
			if (frmT3ModuleOptions != null)
			{
				((IDisposable)frmT3ModuleOptions).Dispose();
			}
		}
	}

	private void mnuShowMoreModule_Click(object sender, EventArgs e)
	{
		if (((ArrangedElementCollection)((Control)FlowPanelMenu).Controls).Count != arrModules.Count() && ((ArrangedElementCollection)((Control)flowPanelOptions).Controls).Count > 1)
		{
			asModuleButtonAtBottom asModuleButtonAtBottom2 = (asModuleButtonAtBottom)(object)((Control)flowPanelOptions).Controls[((ArrangedElementCollection)((Control)flowPanelOptions).Controls).Count - 1];
			Button val = CreateModuleButton((MenuInformation)((Control)asModuleButtonAtBottom2).Tag);
			((Control)FlowPanelMenu).Controls.Add((Control)(object)val);
			((Control)flowPanelOptions).Controls.Remove((Control)(object)asModuleButtonAtBottom2);
			val.PerformClick();
		}
	}

	private void mnuShowFewerModule_Click(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		int num = ((ArrangedElementCollection)((Control)FlowPanelMenu).Controls).Count - 1;
		if (num >= 0)
		{
			if (num > 0)
			{
				((Button)((Control)FlowPanelMenu).Controls[num - 1]).PerformClick();
			}
			else
			{
				((Control)this).SuspendLayout();
				((Control)panelDetailMenus).Controls.Clear();
				tvwMenu.Nodes.Clear();
				((Control)this).ResumeLayout();
			}
			asModuleButtonAtBottom asModuleButtonAtBottom2 = CreateModuleButtonAtBottom((MenuInformation)((Control)FlowPanelMenu).Controls[((ArrangedElementCollection)((Control)FlowPanelMenu).Controls).Count - 1].Tag);
			((Control)flowPanelOptions).Controls.Add((Control)(object)asModuleButtonAtBottom2);
			((Control)FlowPanelMenu).Controls.RemoveAt(((ArrangedElementCollection)((Control)FlowPanelMenu).Controls).Count - 1);
		}
	}

	private void mnuContextOptions_Opening(object sender, CancelEventArgs e)
	{
		mnuShowMoreModule.Enabled = ((ArrangedElementCollection)((Control)FlowPanelMenu).Controls).Count < arrModules.Count();
		mnuShowFewerModule.Enabled = ((ArrangedElementCollection)((Control)FlowPanelMenu).Controls).Count > 0;
	}

	private void FlowPanelMenu_Resize(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		if (!isLoading)
		{
			while ((((ArrangedElementCollection)((Control)FlowPanelMenu).Controls).Count > 0 && ((Control)FlowPanelMenu).Height <= heightOneItem * ((ArrangedElementCollection)((Control)FlowPanelMenu).Controls).Count) ? true : false)
			{
				Button val = (Button)((Control)FlowPanelMenu).Controls[((ArrangedElementCollection)((Control)FlowPanelMenu).Controls).Count - 1];
				asModuleButtonAtBottom asModuleButtonAtBottom2 = CreateModuleButtonAtBottom((MenuInformation)((Control)val).Tag);
				((Control)FlowPanelMenu).Controls.Remove((Control)(object)val);
				((Control)flowPanelOptions).Controls.Add((Control)(object)asModuleButtonAtBottom2);
			}
			while ((((ArrangedElementCollection)((Control)flowPanelOptions).Controls).Count > 1 && ((Control)FlowPanelMenu).Height > heightOneItem * (((ArrangedElementCollection)((Control)FlowPanelMenu).Controls).Count + 1)) ? true : false)
			{
				asModuleButtonAtBottom asModuleButtonAtBottom3 = (asModuleButtonAtBottom)(object)((Control)flowPanelOptions).Controls[((ArrangedElementCollection)((Control)flowPanelOptions).Controls).Count - 1];
				Button val2 = CreateModuleButton((MenuInformation)((Control)asModuleButtonAtBottom3).Tag);
				((Control)flowPanelOptions).Controls.Remove((Control)(object)asModuleButtonAtBottom3);
				((Control)FlowPanelMenu).Controls.Add((Control)(object)val2);
			}
		}
	}

	private void tvwMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		if ((((MouseEventArgs)e).Clicks == 1 && e.Node.FirstNode != null) ? true : false)
		{
			e.Node.Toggle();
		}
	}

	private void tvwMenu_AfterExpand(object sender, TreeViewEventArgs e)
	{
		e.Node.ImageIndex = 1;
		e.Node.SelectedImageIndex = 1;
	}

	private void tvwMenu_AfterCollapse(object sender, TreeViewEventArgs e)
	{
		e.Node.ImageIndex = 0;
		e.Node.SelectedImageIndex = 0;
	}
}
