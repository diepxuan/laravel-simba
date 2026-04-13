using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

[DesignerGenerated]
public class FrmSimbaMenu : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("MenuStrip1")]
	private MenuStrip _MenuStrip1;

	[AccessedThroughProperty("mnuHelp")]
	private ToolStripMenuItem _mnuHelp;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("panelTop")]
	private Panel _panelTop;

	[AccessedThroughProperty("SplitContainer1")]
	private SplitContainer _SplitContainer1;

	[AccessedThroughProperty("lblCurrentDate")]
	private ToolStripStatusLabel _lblCurrentDate;

	[AccessedThroughProperty("lblCapIsOn")]
	private ToolStripStatusLabel _lblCapIsOn;

	[AccessedThroughProperty("lblNumsIsOn")]
	private ToolStripStatusLabel _lblNumsIsOn;

	[AccessedThroughProperty("lbl_InsertKey")]
	private ToolStripStatusLabel _lbl_InsertKey;

	[AccessedThroughProperty("HướngDẫnSửDụngToolStripMenuItem")]
	private ToolStripMenuItem _HướngDẫnSửDụngToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator1")]
	private ToolStripSeparator _ToolStripSeparator1;

	[AccessedThroughProperty("XemVideoHDSDToolStripMenuItem")]
	private ToolStripMenuItem _XemVideoHDSDToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator2")]
	private ToolStripSeparator _ToolStripSeparator2;

	[AccessedThroughProperty("GiớiThiệuChươngTrìnhToolStripMenuItem")]
	private ToolStripMenuItem _GiớiThiệuChươngTrìnhToolStripMenuItem;

	[AccessedThroughProperty("Timer4StatusBar")]
	private Timer _Timer4StatusBar;

	[AccessedThroughProperty("UcModuleMenu1")]
	private ucModuleMenu _UcModuleMenu1;

	[AccessedThroughProperty("SplitContainer2")]
	private SplitContainer _SplitContainer2;

	[AccessedThroughProperty("SplitContainer3")]
	private SplitContainer _SplitContainer3;

	[AccessedThroughProperty("UcCenterMenu1")]
	private ucCenterMenu _UcCenterMenu1;

	[AccessedThroughProperty("UcReportItem1")]
	private ucReportMenu _UcReportItem1;

	[AccessedThroughProperty("UcBottomMenu1")]
	private ucBottomMenu _UcBottomMenu1;

	[AccessedThroughProperty("btnHelp")]
	private Button _btnHelp;

	[AccessedThroughProperty("btnExit")]
	private Button _btnExit;

	[AccessedThroughProperty("panelCommandTop")]
	private Panel _panelCommandTop;

	[AccessedThroughProperty("btnPlayVideo")]
	private Button _btnPlayVideo;

	[AccessedThroughProperty("btnTeamViewer")]
	private Button _btnTeamViewer;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("imgListTopMenu")]
	private ImageList _imgListTopMenu;

	[AccessedThroughProperty("lblFinanceYear")]
	private Label _lblFinanceYear;

	[AccessedThroughProperty("lblProductName")]
	private Label _lblProductName;

	[AccessedThroughProperty("lblSEPA1")]
	private Label _lblSEPA1;

	[AccessedThroughProperty("lblSEPA2")]
	private Label _lblSEPA2;

	[AccessedThroughProperty("lblCompanyName")]
	private Label _lblCompanyName;

	private ArrayList MenuInfo;

	private IOrderedEnumerable<MenuInformation> arrModules;

	private static readonly string SPACE_STR = Strings.Space(5);

	internal virtual MenuStrip MenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem mnuHelp
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuHelp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuHelp = value;
		}
	}

	internal virtual StatusStrip StatusStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal virtual Panel panelTop
	{
		[DebuggerNonUserCode]
		get
		{
			return _panelTop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_panelTop = value;
		}
	}

	internal virtual SplitContainer SplitContainer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SplitContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SplitContainer1 = value;
		}
	}

	internal virtual ToolStripStatusLabel lblCurrentDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCurrentDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCurrentDate = value;
		}
	}

	internal virtual ToolStripStatusLabel lblCapIsOn
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCapIsOn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCapIsOn = value;
		}
	}

	internal virtual ToolStripStatusLabel lblNumsIsOn
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNumsIsOn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNumsIsOn = value;
		}
	}

	internal virtual ToolStripStatusLabel lbl_InsertKey
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_InsertKey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_InsertKey = value;
		}
	}

	internal virtual ToolStripMenuItem HướngDẫnSửDụngToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _HướngDẫnSửDụngToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_HướngDẫnSửDụngToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator1 = value;
		}
	}

	internal virtual ToolStripMenuItem XemVideoHDSDToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _XemVideoHDSDToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XemVideoHDSDToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator2 = value;
		}
	}

	internal virtual ToolStripMenuItem GiớiThiệuChươngTrìnhToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _GiớiThiệuChươngTrìnhToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GiớiThiệuChươngTrìnhToolStripMenuItem = value;
		}
	}

	internal virtual Timer Timer4StatusBar
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer4StatusBar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer4StatusBar != null)
			{
				_Timer4StatusBar.Tick -= eventHandler;
			}
			_Timer4StatusBar = value;
			if (_Timer4StatusBar != null)
			{
				_Timer4StatusBar.Tick += eventHandler;
			}
		}
	}

	internal virtual ucModuleMenu UcModuleMenu1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcModuleMenu1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = UcModuleMenu1_Module_Clicked;
			if (_UcModuleMenu1 != null)
			{
				_UcModuleMenu1.Module_Clicked -= obj;
			}
			_UcModuleMenu1 = value;
			if (_UcModuleMenu1 != null)
			{
				_UcModuleMenu1.Module_Clicked += obj;
			}
		}
	}

	internal virtual SplitContainer SplitContainer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _SplitContainer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SplitContainer2 = value;
		}
	}

	internal virtual SplitContainer SplitContainer3
	{
		[DebuggerNonUserCode]
		get
		{
			return _SplitContainer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(SplitContainer3_Paint);
			if (_SplitContainer3 != null)
			{
				((Control)_SplitContainer3).Paint -= val;
			}
			_SplitContainer3 = value;
			if (_SplitContainer3 != null)
			{
				((Control)_SplitContainer3).Paint += val;
			}
		}
	}

	internal virtual ucCenterMenu UcCenterMenu1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCenterMenu1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler obj = UcCenterMenu1_Menu_Clicked;
			if (_UcCenterMenu1 != null)
			{
				_UcCenterMenu1.Menu_Clicked -= obj;
			}
			_UcCenterMenu1 = value;
			if (_UcCenterMenu1 != null)
			{
				_UcCenterMenu1.Menu_Clicked += obj;
			}
		}
	}

	internal virtual ucReportMenu UcReportItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcReportItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			Action<object, LinkLabelLinkClickedEventArgs> obj = UcCenterMenu1_Menu_Clicked;
			if (_UcReportItem1 != null)
			{
				_UcReportItem1.Menu_Clicked -= obj;
			}
			_UcReportItem1 = value;
			if (_UcReportItem1 != null)
			{
				_UcReportItem1.Menu_Clicked += obj;
			}
		}
	}

	internal virtual ucBottomMenu UcBottomMenu1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcBottomMenu1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			Action<object, MouseEventArgs> obj = UcCenterMenu1_Menu_Clicked;
			if (_UcBottomMenu1 != null)
			{
				_UcBottomMenu1.Menu_Clicked -= obj;
			}
			_UcBottomMenu1 = value;
			if (_UcBottomMenu1 != null)
			{
				_UcBottomMenu1.Menu_Clicked += obj;
			}
		}
	}

	internal virtual Button btnHelp
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnHelp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_btnHelp = value;
		}
	}

	internal virtual Button btnExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnExit_Click;
			if (_btnExit != null)
			{
				((Control)_btnExit).Click -= eventHandler;
			}
			_btnExit = value;
			if (_btnExit != null)
			{
				((Control)_btnExit).Click += eventHandler;
			}
		}
	}

	internal virtual Panel panelCommandTop
	{
		[DebuggerNonUserCode]
		get
		{
			return _panelCommandTop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_panelCommandTop = value;
		}
	}

	internal virtual Button btnPlayVideo
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnPlayVideo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_btnPlayVideo = value;
		}
	}

	internal virtual Button btnTeamViewer
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnTeamViewer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnTeamViewer_Click;
			if (_btnTeamViewer != null)
			{
				((Control)_btnTeamViewer).Click -= eventHandler;
			}
			_btnTeamViewer = value;
			if (_btnTeamViewer != null)
			{
				((Control)_btnTeamViewer).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual ImageList imgListTopMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _imgListTopMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_imgListTopMenu = value;
		}
	}

	internal virtual Label lblFinanceYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFinanceYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFinanceYear = value;
		}
	}

	internal virtual Label lblProductName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblProductName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblProductName = value;
		}
	}

	internal virtual Label lblSEPA1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSEPA1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSEPA1 = value;
		}
	}

	internal virtual Label lblSEPA2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSEPA2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSEPA2 = value;
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

	[DebuggerNonUserCode]
	public FrmSimbaMenu()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		((Form)this).Load += FrmSimbaMenu_Load;
		((Form)this).FormClosing += new FormClosingEventHandler(FrmSimbaMenu_FormClosing);
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected O, but got Unknown
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected O, but got Unknown
		//IL_0cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc7: Expected O, but got Unknown
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf4: Expected O, but got Unknown
		//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Expected O, but got Unknown
		//IL_0f6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f78: Expected O, but got Unknown
		//IL_1112: Unknown result type (might be due to invalid IL or missing references)
		//IL_111c: Expected O, but got Unknown
		//IL_11c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ca: Expected O, but got Unknown
		//IL_12fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1307: Expected O, but got Unknown
		//IL_13ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b5: Expected O, but got Unknown
		//IL_1467: Unknown result type (might be due to invalid IL or missing references)
		//IL_1471: Expected O, but got Unknown
		//IL_14cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_174f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1759: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FrmSimbaMenu));
		StatusStrip1 = new StatusStrip();
		lblCurrentDate = new ToolStripStatusLabel();
		lblCapIsOn = new ToolStripStatusLabel();
		lblNumsIsOn = new ToolStripStatusLabel();
		lbl_InsertKey = new ToolStripStatusLabel();
		SplitContainer1 = new SplitContainer();
		UcModuleMenu1 = new ucModuleMenu();
		SplitContainer2 = new SplitContainer();
		SplitContainer3 = new SplitContainer();
		UcCenterMenu1 = new ucCenterMenu();
		UcBottomMenu1 = new ucBottomMenu();
		UcReportItem1 = new ucReportMenu();
		Timer4StatusBar = new Timer(components);
		imgListTopMenu = new ImageList(components);
		panelTop = new Panel();
		btnHelp = new Button();
		btnExit = new Button();
		panelCommandTop = new Panel();
		btnPlayVideo = new Button();
		btnTeamViewer = new Button();
		Panel1 = new Panel();
		lblFinanceYear = new Label();
		lblProductName = new Label();
		lblSEPA1 = new Label();
		lblSEPA2 = new Label();
		lblCompanyName = new Label();
		MenuStrip1 = new MenuStrip();
		mnuHelp = new ToolStripMenuItem();
		HướngDẫnSửDụngToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator1 = new ToolStripSeparator();
		XemVideoHDSDToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator2 = new ToolStripSeparator();
		GiớiThiệuChươngTrìnhToolStripMenuItem = new ToolStripMenuItem();
		((Control)StatusStrip1).SuspendLayout();
		((Control)SplitContainer1.Panel1).SuspendLayout();
		((Control)SplitContainer1.Panel2).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((Control)SplitContainer2.Panel1).SuspendLayout();
		((Control)SplitContainer2.Panel2).SuspendLayout();
		((Control)SplitContainer2).SuspendLayout();
		((Control)SplitContainer3.Panel1).SuspendLayout();
		((Control)SplitContainer3.Panel2).SuspendLayout();
		((Control)SplitContainer3).SuspendLayout();
		((Control)panelTop).SuspendLayout();
		((Control)panelCommandTop).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)MenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)StatusStrip1).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)lblCurrentDate,
			(ToolStripItem)lblCapIsOn,
			(ToolStripItem)lblNumsIsOn,
			(ToolStripItem)lbl_InsertKey
		});
		StatusStrip statusStrip = StatusStrip1;
		Point location = new Point(0, 626);
		((Control)statusStrip).Location = location;
		((Control)StatusStrip1).Name = "StatusStrip1";
		((Control)StatusStrip1).RightToLeft = (RightToLeft)1;
		StatusStrip statusStrip2 = StatusStrip1;
		Size size = new Size(1128, 24);
		((Control)statusStrip2).Size = size;
		((Control)StatusStrip1).TabIndex = 1;
		((Control)StatusStrip1).Text = "StatusStrip1";
		lblCurrentDate.BorderSides = (ToolStripStatusLabelBorderSides)15;
		lblCurrentDate.BorderStyle = (Border3DStyle)8;
		((ToolStripItem)lblCurrentDate).Name = "lblCurrentDate";
		ToolStripStatusLabel obj = lblCurrentDate;
		size = new Size(38, 19);
		((ToolStripItem)obj).Size = size;
		((ToolStripItem)lblCurrentDate).Text = "00:00";
		lblCapIsOn.BorderSides = (ToolStripStatusLabelBorderSides)15;
		lblCapIsOn.BorderStyle = (Border3DStyle)8;
		((ToolStripItem)lblCapIsOn).Name = "lblCapIsOn";
		ToolStripStatusLabel obj2 = lblCapIsOn;
		size = new Size(40, 19);
		((ToolStripItem)obj2).Size = size;
		((ToolStripItem)lblCapIsOn).Text = "CAPS";
		lblNumsIsOn.BorderSides = (ToolStripStatusLabelBorderSides)15;
		lblNumsIsOn.BorderStyle = (Border3DStyle)8;
		((ToolStripItem)lblNumsIsOn).Name = "lblNumsIsOn";
		ToolStripStatusLabel obj3 = lblNumsIsOn;
		size = new Size(39, 19);
		((ToolStripItem)obj3).Size = size;
		((ToolStripItem)lblNumsIsOn).Text = "NUM";
		lbl_InsertKey.BorderSides = (ToolStripStatusLabelBorderSides)15;
		lbl_InsertKey.BorderStyle = (Border3DStyle)8;
		((ToolStripItem)lbl_InsertKey).DisplayStyle = (ToolStripItemDisplayStyle)1;
		((ToolStripItem)lbl_InsertKey).Name = "lbl_InsertKey";
		ToolStripStatusLabel obj4 = lbl_InsertKey;
		size = new Size(29, 19);
		((ToolStripItem)obj4).Size = size;
		((ToolStripItem)lbl_InsertKey).Text = "INS";
		SplitContainer1.Dock = (DockStyle)5;
		SplitContainer1.FixedPanel = (FixedPanel)1;
		SplitContainer1.IsSplitterFixed = true;
		SplitContainer splitContainer = SplitContainer1;
		location = new Point(0, 153);
		((Control)splitContainer).Location = location;
		SplitContainer splitContainer2 = SplitContainer1;
		Padding val = default(Padding);
		((Padding)(ref val))._002Ector(0, 20, 0, 0);
		((Control)splitContainer2).Margin = val;
		((Control)SplitContainer1).Name = "SplitContainer1";
		((Control)SplitContainer1.Panel1).Controls.Add((Control)(object)UcModuleMenu1);
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)SplitContainer2);
		SplitContainer splitContainer3 = SplitContainer1;
		size = new Size(1128, 473);
		((Control)splitContainer3).Size = size;
		SplitContainer1.SplitterDistance = 217;
		SplitContainer1.SplitterWidth = 1;
		((Control)SplitContainer1).TabIndex = 3;
		((Control)UcModuleMenu1).Dock = (DockStyle)5;
		((Control)UcModuleMenu1).ForeColor = Color.FromArgb(228, 191, 93);
		ucModuleMenu ucModuleMenu2 = UcModuleMenu1;
		location = new Point(0, 0);
		((Control)ucModuleMenu2).Location = location;
		ucModuleMenu ucModuleMenu3 = UcModuleMenu1;
		((Padding)(ref val))._002Ector(0);
		((Control)ucModuleMenu3).Margin = val;
		((Control)UcModuleMenu1).Name = "UcModuleMenu1";
		ucModuleMenu ucModuleMenu4 = UcModuleMenu1;
		size = new Size(217, 473);
		((Control)ucModuleMenu4).Size = size;
		((Control)UcModuleMenu1).TabIndex = 0;
		SplitContainer2.Dock = (DockStyle)5;
		SplitContainer2.FixedPanel = (FixedPanel)2;
		SplitContainer splitContainer4 = SplitContainer2;
		location = new Point(0, 0);
		((Control)splitContainer4).Location = location;
		SplitContainer splitContainer5 = SplitContainer2;
		((Padding)(ref val))._002Ector(0);
		((Control)splitContainer5).Margin = val;
		((Control)SplitContainer2).Name = "SplitContainer2";
		((Control)SplitContainer2.Panel1).Controls.Add((Control)(object)SplitContainer3);
		((Control)SplitContainer2.Panel2).Controls.Add((Control)(object)UcReportItem1);
		SplitContainer splitContainer6 = SplitContainer2;
		size = new Size(910, 473);
		((Control)splitContainer6).Size = size;
		SplitContainer2.SplitterDistance = 635;
		SplitContainer2.SplitterWidth = 1;
		((Control)SplitContainer2).TabIndex = 2;
		SplitContainer3.Dock = (DockStyle)5;
		SplitContainer3.FixedPanel = (FixedPanel)2;
		SplitContainer splitContainer7 = SplitContainer3;
		location = new Point(0, 0);
		((Control)splitContainer7).Location = location;
		SplitContainer splitContainer8 = SplitContainer3;
		((Padding)(ref val))._002Ector(0);
		((Control)splitContainer8).Margin = val;
		((Control)SplitContainer3).Name = "SplitContainer3";
		SplitContainer3.Orientation = (Orientation)0;
		((Control)SplitContainer3.Panel1).Controls.Add((Control)(object)UcCenterMenu1);
		((Control)SplitContainer3.Panel2).Controls.Add((Control)(object)UcBottomMenu1);
		SplitContainer splitContainer9 = SplitContainer3;
		size = new Size(635, 473);
		((Control)splitContainer9).Size = size;
		SplitContainer3.SplitterDistance = 351;
		SplitContainer3.SplitterWidth = 1;
		((Control)SplitContainer3).TabIndex = 0;
		((Control)UcCenterMenu1).BackColor = Color.FromArgb(252, 202, 152);
		((Control)UcCenterMenu1).Dock = (DockStyle)5;
		ucCenterMenu ucCenterMenu2 = UcCenterMenu1;
		location = new Point(0, 0);
		((Control)ucCenterMenu2).Location = location;
		ucCenterMenu ucCenterMenu3 = UcCenterMenu1;
		((Padding)(ref val))._002Ector(0);
		((Control)ucCenterMenu3).Margin = val;
		((Control)UcCenterMenu1).Name = "UcCenterMenu1";
		ucCenterMenu ucCenterMenu4 = UcCenterMenu1;
		size = new Size(635, 351);
		((Control)ucCenterMenu4).Size = size;
		((Control)UcCenterMenu1).TabIndex = 0;
		((Control)UcBottomMenu1).Dock = (DockStyle)5;
		ucBottomMenu ucBottomMenu2 = UcBottomMenu1;
		location = new Point(0, 0);
		((Control)ucBottomMenu2).Location = location;
		ucBottomMenu ucBottomMenu3 = UcBottomMenu1;
		((Padding)(ref val))._002Ector(0);
		((Control)ucBottomMenu3).Margin = val;
		((Control)UcBottomMenu1).Name = "UcBottomMenu1";
		ucBottomMenu ucBottomMenu4 = UcBottomMenu1;
		size = new Size(635, 121);
		((Control)ucBottomMenu4).Size = size;
		((Control)UcBottomMenu1).TabIndex = 0;
		((Control)UcReportItem1).BackColor = Color.FromArgb(255, 230, 210);
		((Control)UcReportItem1).Dock = (DockStyle)5;
		ucReportMenu ucReportItem = UcReportItem1;
		location = new Point(0, 0);
		((Control)ucReportItem).Location = location;
		ucReportMenu ucReportItem2 = UcReportItem1;
		((Padding)(ref val))._002Ector(0);
		((Control)ucReportItem2).Margin = val;
		((Control)UcReportItem1).Name = "UcReportItem1";
		ucReportMenu ucReportItem3 = UcReportItem1;
		size = new Size(274, 473);
		((Control)ucReportItem3).Size = size;
		((Control)UcReportItem1).TabIndex = 0;
		Timer4StatusBar.Enabled = true;
		Timer4StatusBar.Interval = 1000;
		imgListTopMenu.ColorDepth = (ColorDepth)32;
		ImageList obj5 = imgListTopMenu;
		size = new Size(32, 32);
		obj5.ImageSize = size;
		imgListTopMenu.TransparentColor = Color.Transparent;
		((Control)panelTop).BackColor = Color.FromArgb(252, 156, 85);
		((Control)panelTop).BackgroundImage = (Image)componentResourceManager.GetObject("panelTop.BackgroundImage");
		((Control)panelTop).BackgroundImageLayout = (ImageLayout)3;
		((Control)panelTop).Controls.Add((Control)(object)btnHelp);
		((Control)panelTop).Controls.Add((Control)(object)btnExit);
		((Control)panelTop).Controls.Add((Control)(object)panelCommandTop);
		((Control)panelTop).Controls.Add((Control)(object)Panel1);
		((Control)panelTop).Dock = (DockStyle)1;
		Panel obj6 = panelTop;
		location = new Point(0, 19);
		((Control)obj6).Location = location;
		((Control)panelTop).Name = "panelTop";
		Panel obj7 = panelTop;
		size = new Size(1128, 134);
		((Control)obj7).Size = size;
		((Control)panelTop).TabIndex = 2;
		((Control)btnHelp).Anchor = (AnchorStyles)9;
		((ButtonBase)btnHelp).BackColor = Color.Transparent;
		((Control)btnHelp).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)btnHelp).FlatAppearance.BorderSize = 0;
		((ButtonBase)btnHelp).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)btnHelp).FlatAppearance.MouseOverBackColor = Color.Transparent;
		((ButtonBase)btnHelp).FlatStyle = (FlatStyle)0;
		((Control)btnHelp).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)btnHelp).ForeColor = Color.White;
		((ButtonBase)btnHelp).Image = (Image)(object)Resources.Help;
		((ButtonBase)btnHelp).ImageAlign = (ContentAlignment)16;
		Button obj8 = btnHelp;
		location = new Point(925, 7);
		((Control)obj8).Location = location;
		((Control)btnHelp).Name = "btnHelp";
		Button obj9 = btnHelp;
		size = new Size(86, 23);
		((Control)obj9).Size = size;
		((Control)btnHelp).TabIndex = 16;
		((ButtonBase)btnHelp).Text = "HDSD";
		((ButtonBase)btnHelp).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)btnHelp).UseVisualStyleBackColor = false;
		((Control)btnExit).Anchor = (AnchorStyles)9;
		((ButtonBase)btnExit).BackColor = Color.Transparent;
		((Control)btnExit).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)btnExit).FlatAppearance.BorderSize = 0;
		((ButtonBase)btnExit).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)btnExit).FlatAppearance.MouseOverBackColor = Color.Transparent;
		((ButtonBase)btnExit).FlatStyle = (FlatStyle)0;
		((Control)btnExit).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)btnExit).ForeColor = Color.White;
		((ButtonBase)btnExit).Image = (Image)componentResourceManager.GetObject("btnExit.Image");
		((ButtonBase)btnExit).ImageAlign = (ContentAlignment)16;
		Button obj10 = btnExit;
		location = new Point(1042, 7);
		((Control)obj10).Location = location;
		((Control)btnExit).Name = "btnExit";
		Button obj11 = btnExit;
		size = new Size(73, 23);
		((Control)obj11).Size = size;
		((Control)btnExit).TabIndex = 17;
		((ButtonBase)btnExit).Text = "Thoát";
		((ButtonBase)btnExit).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)btnExit).UseVisualStyleBackColor = false;
		((Control)panelCommandTop).Anchor = (AnchorStyles)13;
		((Control)panelCommandTop).BackColor = Color.Transparent;
		((Control)panelCommandTop).Controls.Add((Control)(object)btnPlayVideo);
		((Control)panelCommandTop).Controls.Add((Control)(object)btnTeamViewer);
		Panel obj12 = panelCommandTop;
		location = new Point(218, 34);
		((Control)obj12).Location = location;
		((Control)panelCommandTop).Name = "panelCommandTop";
		Panel obj13 = panelCommandTop;
		size = new Size(905, 58);
		((Control)obj13).Size = size;
		((Control)panelCommandTop).TabIndex = 15;
		((Control)btnPlayVideo).BackgroundImage = (Image)(object)Resources.ShowVideo;
		((Control)btnPlayVideo).BackgroundImageLayout = (ImageLayout)3;
		((Control)btnPlayVideo).Dock = (DockStyle)4;
		((ButtonBase)btnPlayVideo).FlatAppearance.BorderSize = 0;
		((ButtonBase)btnPlayVideo).FlatStyle = (FlatStyle)0;
		((Control)btnPlayVideo).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)btnPlayVideo).ForeColor = Color.White;
		Button obj14 = btnPlayVideo;
		location = new Point(685, 0);
		((Control)obj14).Location = location;
		((Control)btnPlayVideo).Name = "btnPlayVideo";
		Button obj15 = btnPlayVideo;
		size = new Size(95, 58);
		((Control)obj15).Size = size;
		((Control)btnPlayVideo).TabIndex = 4;
		((ButtonBase)btnPlayVideo).Text = "VIDEO";
		((ButtonBase)btnPlayVideo).UseVisualStyleBackColor = true;
		((Control)btnTeamViewer).BackgroundImage = (Image)(object)Resources.SIMBAQS;
		((Control)btnTeamViewer).BackgroundImageLayout = (ImageLayout)3;
		((Control)btnTeamViewer).Dock = (DockStyle)4;
		((ButtonBase)btnTeamViewer).FlatAppearance.BorderSize = 0;
		((ButtonBase)btnTeamViewer).FlatStyle = (FlatStyle)0;
		((Control)btnTeamViewer).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)btnTeamViewer).ForeColor = Color.White;
		Button obj16 = btnTeamViewer;
		location = new Point(780, 0);
		((Control)obj16).Location = location;
		((Control)btnTeamViewer).Name = "btnTeamViewer";
		Button obj17 = btnTeamViewer;
		size = new Size(125, 58);
		((Control)obj17).Size = size;
		((Control)btnTeamViewer).TabIndex = 5;
		((ButtonBase)btnTeamViewer).Text = "Simba QS";
		((ButtonBase)btnTeamViewer).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnTeamViewer).UseVisualStyleBackColor = true;
		((Control)Panel1).BackColor = Color.Transparent;
		((Control)Panel1).Controls.Add((Control)(object)lblFinanceYear);
		((Control)Panel1).Controls.Add((Control)(object)lblProductName);
		((Control)Panel1).Controls.Add((Control)(object)lblSEPA1);
		((Control)Panel1).Controls.Add((Control)(object)lblSEPA2);
		((Control)Panel1).Controls.Add((Control)(object)lblCompanyName);
		Panel panel = Panel1;
		location = new Point(217, 101);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(908, 22);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 14;
		((Control)lblFinanceYear).Anchor = (AnchorStyles)0;
		lblFinanceYear.AutoSize = true;
		((Control)lblFinanceYear).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblFinanceYear).ForeColor = Color.FromArgb(64, 0, 0);
		Label obj18 = lblFinanceYear;
		location = new Point(59, 6);
		((Control)obj18).Location = location;
		((Control)lblFinanceYear).Name = "lblFinanceYear";
		Label obj19 = lblFinanceYear;
		size = new Size(35, 13);
		((Control)obj19).Size = size;
		((Control)lblFinanceYear).TabIndex = 3;
		lblFinanceYear.Text = "2014";
		((Control)lblProductName).Anchor = (AnchorStyles)0;
		lblProductName.AutoSize = true;
		((Control)lblProductName).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblProductName).ForeColor = Color.FromArgb(64, 0, 0);
		Label obj20 = lblProductName;
		location = new Point(3, 6);
		((Control)obj20).Location = location;
		((Control)lblProductName).Name = "lblProductName";
		Label obj21 = lblProductName;
		size = new Size(45, 13);
		((Control)obj21).Size = size;
		((Control)lblProductName).TabIndex = 4;
		lblProductName.Text = "SIMBA";
		((Control)lblSEPA1).Anchor = (AnchorStyles)0;
		lblSEPA1.AutoSize = true;
		((Control)lblSEPA1).ForeColor = Color.FromArgb(64, 0, 0);
		Label obj22 = lblSEPA1;
		location = new Point(50, 6);
		((Control)obj22).Location = location;
		((Control)lblSEPA1).Name = "lblSEPA1";
		Label obj23 = lblSEPA1;
		size = new Size(9, 13);
		((Control)obj23).Size = size;
		((Control)lblSEPA1).TabIndex = 5;
		lblSEPA1.Text = "|";
		((Control)lblSEPA2).Anchor = (AnchorStyles)0;
		lblSEPA2.AutoSize = true;
		((Control)lblSEPA2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSEPA2).ForeColor = Color.FromArgb(64, 0, 0);
		Label obj24 = lblSEPA2;
		location = new Point(95, 6);
		((Control)obj24).Location = location;
		((Control)lblSEPA2).Name = "lblSEPA2";
		Label obj25 = lblSEPA2;
		size = new Size(9, 13);
		((Control)obj25).Size = size;
		((Control)lblSEPA2).TabIndex = 6;
		lblSEPA2.Text = "|";
		((Control)lblCompanyName).Anchor = (AnchorStyles)0;
		lblCompanyName.AutoSize = true;
		((Control)lblCompanyName).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblCompanyName).ForeColor = Color.FromArgb(64, 0, 0);
		Label obj26 = lblCompanyName;
		location = new Point(105, 6);
		((Control)obj26).Location = location;
		((Control)lblCompanyName).Name = "lblCompanyName";
		Label obj27 = lblCompanyName;
		size = new Size(59, 13);
		((Control)obj27).Size = size;
		((Control)lblCompanyName).TabIndex = 7;
		lblCompanyName.Text = "Nhập thử";
		((ToolStrip)MenuStrip1).AutoSize = false;
		((Control)MenuStrip1).BackgroundImage = (Image)(object)Resources.Untitled;
		((Control)MenuStrip1).BackgroundImageLayout = (ImageLayout)3;
		((ToolStrip)MenuStrip1).Font = new Font("Microsoft Sans Serif", 8f);
		((ToolStrip)MenuStrip1).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)mnuHelp });
		MenuStrip menuStrip = MenuStrip1;
		location = new Point(0, 0);
		((Control)menuStrip).Location = location;
		((Control)MenuStrip1).Name = "MenuStrip1";
		MenuStrip menuStrip2 = MenuStrip1;
		((Padding)(ref val))._002Ector(0);
		((Control)menuStrip2).Padding = val;
		MenuStrip menuStrip3 = MenuStrip1;
		size = new Size(1128, 19);
		((Control)menuStrip3).Size = size;
		((Control)MenuStrip1).TabIndex = 0;
		((Control)MenuStrip1).Text = "MenuStrip1";
		((ToolStripDropDownItem)mnuHelp).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)HướngDẫnSửDụngToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator1,
			(ToolStripItem)XemVideoHDSDToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator2,
			(ToolStripItem)GiớiThiệuChươngTrìnhToolStripMenuItem
		});
		((ToolStripItem)mnuHelp).Name = "mnuHelp";
		ToolStripMenuItem obj28 = mnuHelp;
		size = new Size(58, 19);
		((ToolStripItem)obj28).Size = size;
		((ToolStripItem)mnuHelp).Text = "Trợ giúp";
		((ToolStripItem)HướngDẫnSửDụngToolStripMenuItem).Name = "HướngDẫnSửDụngToolStripMenuItem";
		ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem = HướngDẫnSửDụngToolStripMenuItem;
		size = new Size(180, 22);
		((ToolStripItem)hướngDẫnSửDụngToolStripMenuItem).Size = size;
		((ToolStripItem)HướngDẫnSửDụngToolStripMenuItem).Text = "&Hướng dẫn sử dụng";
		((ToolStripItem)ToolStripSeparator1).Name = "ToolStripSeparator1";
		ToolStripSeparator toolStripSeparator = ToolStripSeparator1;
		size = new Size(177, 6);
		((ToolStripItem)toolStripSeparator).Size = size;
		((ToolStripItem)XemVideoHDSDToolStripMenuItem).Name = "XemVideoHDSDToolStripMenuItem";
		ToolStripMenuItem xemVideoHDSDToolStripMenuItem = XemVideoHDSDToolStripMenuItem;
		size = new Size(180, 22);
		((ToolStripItem)xemVideoHDSDToolStripMenuItem).Size = size;
		((ToolStripItem)XemVideoHDSDToolStripMenuItem).Text = "&Xem Video HDSD";
		((ToolStripItem)ToolStripSeparator2).Name = "ToolStripSeparator2";
		ToolStripSeparator toolStripSeparator2 = ToolStripSeparator2;
		size = new Size(177, 6);
		((ToolStripItem)toolStripSeparator2).Size = size;
		((ToolStripItem)GiớiThiệuChươngTrìnhToolStripMenuItem).Name = "GiớiThiệuChươngTrìnhToolStripMenuItem";
		ToolStripMenuItem giớiThiệuChươngTrìnhToolStripMenuItem = GiớiThiệuChươngTrìnhToolStripMenuItem;
		size = new Size(180, 22);
		((ToolStripItem)giớiThiệuChươngTrìnhToolStripMenuItem).Size = size;
		((ToolStripItem)GiớiThiệuChươngTrìnhToolStripMenuItem).Text = "&Giới thiệu chương trình";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackgroundImageLayout = (ImageLayout)4;
		size = new Size(1128, 650);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)SplitContainer1);
		((Control)this).Controls.Add((Control)(object)panelTop);
		((Control)this).Controls.Add((Control)(object)StatusStrip1);
		((Control)this).Controls.Add((Control)(object)MenuStrip1);
		((Control)this).DoubleBuffered = true;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MainMenuStrip = MenuStrip1;
		((Control)this).Name = "FrmSimbaMenu";
		((Form)this).Text = "Simba.NET 2014";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)SplitContainer1.Panel1).ResumeLayout(false);
		((Control)SplitContainer1.Panel2).ResumeLayout(false);
		((Control)SplitContainer1).ResumeLayout(false);
		((Control)SplitContainer2.Panel1).ResumeLayout(false);
		((Control)SplitContainer2.Panel2).ResumeLayout(false);
		((Control)SplitContainer2).ResumeLayout(false);
		((Control)SplitContainer3.Panel1).ResumeLayout(false);
		((Control)SplitContainer3.Panel2).ResumeLayout(false);
		((Control)SplitContainer3).ResumeLayout(false);
		((Control)panelTop).ResumeLayout(false);
		((Control)panelCommandTop).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void GetMenuByUserID(string userID)
	{
		MainDAO mainDAO = (MainDAO)DAOFactory.CreateDAOInstance("MainDAO", "Simba", a_blnIsSysDB: true);
		MenuInfo = mainDAO.GetMainMenuInfo(SystemInformations.UserName);
		mainDAO.Destroy();
	}

	private void FrmSimbaMenu_Load(object sender, EventArgs e)
	{
		GetMenuByUserID(SystemInformation.UserName);
		InitLeftMenus();
		InitTopMenus();
		SplitContainer2.SplitterWidth = 1;
		SplitContainer3.SplitterWidth = 1;
		InitOther();
	}

	private void InitOther()
	{
		lblCompanyName.Text = CompanyInformations.CompanyName;
		lblFinanceYear.Text = Conversions.ToString(SystemInformations.FinancialYear);
	}

	private void InitLeftMenus()
	{
		arrModules = from object mnu in MenuInfo
			select (MenuInformation)mnu into mnu
			where mnu.Type.Equals("5", StringComparison.OrdinalIgnoreCase)
			select (mnu) into mnu
			orderby mnu.stt
			select mnu;
		UcModuleMenu1.InitMenu(arrModules);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((ToolStripItem)lblCurrentDate).Text = DateTime.Now.ToLongTimeString();
		((ToolStripItem)lblNumsIsOn).Text = Conversions.ToString(Interaction.IIf(Console.NumberLock, (object)"NUM", (object)SPACE_STR));
		((ToolStripItem)lblCapIsOn).Text = Conversions.ToString(Interaction.IIf(Console.CapsLock, (object)"CAPS", (object)SPACE_STR));
		((ToolStripItem)lbl_InsertKey).Text = Conversions.ToString(Interaction.IIf(Control.IsKeyLocked((Keys)45), (object)"INS", (object)SPACE_STR));
	}

	private void InitTopMenus()
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		IOrderedEnumerable<MenuInformation> source = from object mnu in MenuInfo
			select (MenuInformation)mnu into mnu
			where (mnu.Type.Equals("3", StringComparison.OrdinalIgnoreCase) && !mnu.menuid.EndsWith(".00")) ? true : false
			select (mnu) into mnu
			orderby mnu.stt descending
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
				imgListTopMenu.Images.Add(array[num2], Image.FromFile(SystemInformations.GraphicPath + array[num2]));
			}
			num2++;
		}
		int num5 = source.Count() - 1;
		int num6 = 0;
		while (true)
		{
			int num7 = num6;
			int num8 = num5;
			if (num7 <= num8)
			{
				Button val = new Button();
				Button val2 = val;
				((ButtonBase)val2).Text = source.ElementAtOrDefault(num6).bar;
				((ButtonBase)val2).FlatAppearance.BorderSize = 0;
				((ButtonBase)val2).FlatStyle = (FlatStyle)0;
				((Control)val2).Tag = source.ElementAtOrDefault(num6);
				((ButtonBase)val2).AutoSize = true;
				((ButtonBase)val2).BackColor = Color.Transparent;
				((Control)val2).Dock = (DockStyle)3;
				((ButtonBase)val2).Image = imgListTopMenu.Images[source.ElementAtOrDefault(num6).picture1];
				((ButtonBase)val2).ImageAlign = (ContentAlignment)32;
				((ButtonBase)val2).TextImageRelation = (TextImageRelation)1;
				((ButtonBase)val2).FlatAppearance.MouseOverBackColor = Color.Transparent;
				((ButtonBase)val2).FlatAppearance.MouseDownBackColor = Color.Transparent;
				((ButtonBase)val2).FlatAppearance.CheckedBackColor = Color.Transparent;
				((ButtonBase)val2).FlatAppearance.BorderColor = Color.White;
				((Control)val2).ForeColor = Color.White;
				((Control)val2).Font = new Font(FontFamily.GenericSansSerif, 10f, (FontStyle)1);
				val2 = null;
				((Control)val).MouseEnter += CommandButtonTop_MouseEnter;
				((Control)val).MouseLeave += CommandButtonTop_MouseLeave;
				((Control)val).Click += CommandButtonTop_Click;
				((Control)panelCommandTop).Controls.Add((Control)(object)val);
				num6++;
				continue;
			}
			break;
		}
	}

	private void UcModuleMenu1_Module_Clicked(object sender, EventArgs e)
	{
		MenuInformation menuInformation = (MenuInformation)sender;
		IOrderedEnumerable<MenuInformation> source = from object mnu in MenuInfo
			select (MenuInformation)mnu into mnu
			where (Operators.CompareString(mnu.stt.Substring(0, 2), menuInformation.stt.Substring(0, 2), false) == 0 && Operators.CompareString(mnu.stt, menuInformation.stt, false) != 0 && Operators.CompareString(mnu.bar.ToString().Trim(), string.Empty, false) != 0) ? true : false
			select (mnu) into mnu
			orderby mnu.stt
			select mnu;
		IOrderedEnumerable<MenuInformation> mnuEnum = from mnu in source
			where (mnu.Type.Equals("1", StringComparison.OrdinalIgnoreCase) && !mnu.menuid.EndsWith(".00")) ? true : false
			select (mnu) into mnu
			orderby mnu.stt
			select mnu;
		UcCenterMenu1.InitMenu(mnuEnum);
		IOrderedEnumerable<MenuInformation> orderedEnumerable = from mnu in source
			where mnu.Type.Equals("4", StringComparison.OrdinalIgnoreCase)
			select (mnu) into mnu
			orderby mnu.stt
			select mnu;
		SplitContainer2.Panel2Collapsed = orderedEnumerable.Count() == 0;
		UcReportItem1.InitMenu(orderedEnumerable);
		IOrderedEnumerable<MenuInformation> orderedEnumerable2 = from mnu in source
			where (mnu.Type.Equals("2", StringComparison.OrdinalIgnoreCase) && !mnu.menuid.EndsWith(".00")) ? true : false
			select (mnu) into mnu
			orderby mnu.stt
			select mnu;
		SplitContainer3.Panel2Collapsed = orderedEnumerable2.Count() == 0;
		UcBottomMenu1.InitMenu(orderedEnumerable2);
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void UcCenterMenu1_Menu_Clicked(object sender, EventArgs e)
	{
		startup.ExecuteCommand((MenuInformation)sender, null);
	}

	private void SplitContainer3_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.DrawLine(Pens.DarkGray, ((Control)SplitContainer3).Width - 1, 0, ((Control)SplitContainer3).Width - 1, ((Control)SplitContainer3).Height - 2);
	}

	private void CommandButtonTop_MouseEnter(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((ButtonBase)(Button)sender).FlatStyle = (FlatStyle)1;
	}

	private void CommandButtonTop_MouseLeave(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((ButtonBase)(Button)sender).FlatStyle = (FlatStyle)0;
	}

	private void CommandButtonTop_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MenuInformation mnu = (MenuInformation)((Control)(Button)sender).Tag;
		startup.ExecuteCommand(mnu, null);
	}

	private void btnTeamViewer_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			using (Process.Start("SimbaQS.exe"))
			{
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void FrmSimbaMenu_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		if ((int)CMessageBox.Show("Bạn có muốn thoát khỏi chương trình?", SystemInformations.ProductName, (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256) == 7)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}
}
