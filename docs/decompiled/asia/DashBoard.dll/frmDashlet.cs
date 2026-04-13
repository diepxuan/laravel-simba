using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using AsiaErp.Framework.Docking;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmDashlet : UserControl
{
	public delegate void AddNewMenu_ClickEventHandler(object sender, EventArgs e);

	public delegate void DeleteMenu_ClickEventHandler(object sender, EventArgs e);

	public delegate void UpdateDash_ClickEventHandler(object sender, EventArgs e);

	public delegate void MoveDashletEventHandler(object sender, ResizeableControl rcT);

	public delegate void ResizeDashletEventHandler(object sender, ResizeableControl rcT);

	public delegate void FinishMoveDashletEventHandler(object sender, ResizeableControl rcT);

	public delegate void FinishResizeDashletEventHandler(object sender, ResizeableControl rcT);

	private IContainer components;

	[AccessedThroughProperty("lblTitle")]
	private Label _lblTitle;

	[AccessedThroughProperty("mnsPopup")]
	private ContextMenuStrip _mnsPopup;

	[AccessedThroughProperty("mnDinh_dang")]
	private ToolStripMenuItem _mnDinh_dang;

	[AccessedThroughProperty("mnTableType")]
	private ToolStripMenuItem _mnTableType;

	[AccessedThroughProperty("mnChartType")]
	private ToolStripMenuItem _mnChartType;

	[AccessedThroughProperty("mnXoa_Dashlet")]
	private ToolStripMenuItem _mnXoa_Dashlet;

	[AccessedThroughProperty("mnGach1")]
	private ToolStripSeparator _mnGach1;

	[AccessedThroughProperty("mnThem_Menu")]
	private ToolStripMenuItem _mnThem_Menu;

	[AccessedThroughProperty("mnXoa_Menu")]
	private ToolStripMenuItem _mnXoa_Menu;

	[AccessedThroughProperty("mnSap_xep")]
	private ToolStripMenuItem _mnSap_xep;

	[AccessedThroughProperty("aPanel")]
	private Panel _aPanel;

	[AccessedThroughProperty("myChart")]
	private Chart _myChart;

	[AccessedThroughProperty("adgvTable")]
	private AsDataGridView _adgvTable;

	[AccessedThroughProperty("mnSua_Dashlet")]
	private ToolStripMenuItem _mnSua_Dashlet;

	[AccessedThroughProperty("mnGach")]
	private ToolStripSeparator _mnGach;

	[AccessedThroughProperty("mnGian_dong")]
	private ToolStripMenuItem _mnGian_dong;

	[AccessedThroughProperty("mnThem_giandong")]
	private ToolStripMenuItem _mnThem_giandong;

	[AccessedThroughProperty("mnXoa_giandong")]
	private ToolStripMenuItem _mnXoa_giandong;

	private DataTable oDtData;

	private ImageList ImgListDetail;

	internal DataRow f_Row;

	private LinkLabel lblMenu;

	private int spacing;

	private int mHeight;

	private ResizeableControl rcT;

	private ResizeableControl rcF;

	private const short PADDING_LEFT = 30;

	private const short ITEM_HEIGHT = 25;

	private const string DEFAULT_IMAGE = "detail_icon.gif";

	private Font MODULE_MENU_FONT;

	private Font SUB_MENU_FONT;

	private Font DETAIL_MENU_FONT;

	private Color MODULE_MENU_BACK_COLOR;

	private Color MODULE_MENU_FORE_COLOR;

	private Color MODULE_MENU_SELECTED_FORE_COLOR;

	private Color SUB_MENU_FORE_COLOR;

	private Color DETAIL_MENU_FORE_COLOR;

	private Color GRADIENT_COLOR;

	private readonly short X_COLUMN2;

	[AccessedThroughProperty("frmCreateDashlet")]
	private frmCreateDashlet _frmCreateDashlet;

	[AccessedThroughProperty("frmListFunction")]
	private frmListFunction _frmListFunction;

	internal virtual Label lblTitle
	{
		get
		{
			return _lblTitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(lblTitle_MouseUp);
			EventHandler eventHandler = frmDashElement_MouseLeave;
			EventHandler eventHandler2 = frmDashElement_MouseEnter;
			if (_lblTitle != null)
			{
				((Control)_lblTitle).MouseUp -= val;
				((Control)_lblTitle).MouseLeave -= eventHandler;
				((Control)_lblTitle).MouseEnter -= eventHandler2;
			}
			_lblTitle = value;
			if (_lblTitle != null)
			{
				((Control)_lblTitle).MouseUp += val;
				((Control)_lblTitle).MouseLeave += eventHandler;
				((Control)_lblTitle).MouseEnter += eventHandler2;
			}
		}
	}

	internal virtual ContextMenuStrip mnsPopup
	{
		get
		{
			return _mnsPopup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnsPopup = value;
		}
	}

	internal virtual ToolStripMenuItem mnDinh_dang
	{
		get
		{
			return _mnDinh_dang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnDinh_dang = value;
		}
	}

	internal virtual ToolStripMenuItem mnTableType
	{
		get
		{
			return _mnTableType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Table_Click;
			if (_mnTableType != null)
			{
				((ToolStripItem)_mnTableType).Click -= eventHandler;
			}
			_mnTableType = value;
			if (_mnTableType != null)
			{
				((ToolStripItem)_mnTableType).Click += eventHandler;
			}
		}
	}

	internal virtual ToolStripMenuItem mnChartType
	{
		get
		{
			return _mnChartType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = CHART_Click;
			if (_mnChartType != null)
			{
				((ToolStripItem)_mnChartType).Click -= eventHandler;
			}
			_mnChartType = value;
			if (_mnChartType != null)
			{
				((ToolStripItem)_mnChartType).Click += eventHandler;
			}
		}
	}

	internal virtual ToolStripMenuItem mnXoa_Dashlet
	{
		get
		{
			return _mnXoa_Dashlet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = mnXoa_Dashlet_Click;
			if (_mnXoa_Dashlet != null)
			{
				((ToolStripItem)_mnXoa_Dashlet).Click -= eventHandler;
			}
			_mnXoa_Dashlet = value;
			if (_mnXoa_Dashlet != null)
			{
				((ToolStripItem)_mnXoa_Dashlet).Click += eventHandler;
			}
		}
	}

	internal virtual ToolStripSeparator mnGach1
	{
		get
		{
			return _mnGach1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnGach1 = value;
		}
	}

	internal virtual ToolStripMenuItem mnThem_Menu
	{
		get
		{
			return _mnThem_Menu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = mnThem_Menu_Click;
			if (_mnThem_Menu != null)
			{
				((ToolStripItem)_mnThem_Menu).Click -= eventHandler;
			}
			_mnThem_Menu = value;
			if (_mnThem_Menu != null)
			{
				((ToolStripItem)_mnThem_Menu).Click += eventHandler;
			}
		}
	}

	internal virtual ToolStripMenuItem mnXoa_Menu
	{
		get
		{
			return _mnXoa_Menu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = mnXoa_Menu_Click;
			if (_mnXoa_Menu != null)
			{
				((ToolStripItem)_mnXoa_Menu).Click -= eventHandler;
			}
			_mnXoa_Menu = value;
			if (_mnXoa_Menu != null)
			{
				((ToolStripItem)_mnXoa_Menu).Click += eventHandler;
			}
		}
	}

	internal virtual ToolStripMenuItem mnSap_xep
	{
		get
		{
			return _mnSap_xep;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = mnSap_xep_Click;
			if (_mnSap_xep != null)
			{
				((ToolStripItem)_mnSap_xep).Click -= eventHandler;
			}
			_mnSap_xep = value;
			if (_mnSap_xep != null)
			{
				((ToolStripItem)_mnSap_xep).Click += eventHandler;
			}
		}
	}

	internal virtual Panel aPanel
	{
		get
		{
			return _aPanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = frmDashElement_MouseLeave;
			EventHandler eventHandler2 = frmDashElement_MouseEnter;
			if (_aPanel != null)
			{
				((Control)_aPanel).MouseLeave -= eventHandler;
				((Control)_aPanel).MouseEnter -= eventHandler2;
			}
			_aPanel = value;
			if (_aPanel != null)
			{
				((Control)_aPanel).MouseLeave += eventHandler;
				((Control)_aPanel).MouseEnter += eventHandler2;
			}
		}
	}

	internal virtual Chart myChart
	{
		get
		{
			return _myChart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = frmDashElement_MouseLeave;
			EventHandler eventHandler2 = frmDashElement_MouseEnter;
			if (_myChart != null)
			{
				((Control)_myChart).MouseLeave -= eventHandler;
				((Control)_myChart).MouseEnter -= eventHandler2;
			}
			_myChart = value;
			if (_myChart != null)
			{
				((Control)_myChart).MouseLeave += eventHandler;
				((Control)_myChart).MouseEnter += eventHandler2;
			}
		}
	}

	internal virtual AsDataGridView adgvTable
	{
		get
		{
			return _adgvTable;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = frmDashElement_MouseLeave;
			EventHandler eventHandler2 = frmDashElement_MouseEnter;
			if (_adgvTable != null)
			{
				((Control)_adgvTable).MouseLeave -= eventHandler;
				((Control)_adgvTable).MouseEnter -= eventHandler2;
			}
			_adgvTable = value;
			if (_adgvTable != null)
			{
				((Control)_adgvTable).MouseLeave += eventHandler;
				((Control)_adgvTable).MouseEnter += eventHandler2;
			}
		}
	}

	internal virtual ToolStripMenuItem mnSua_Dashlet
	{
		get
		{
			return _mnSua_Dashlet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = mnSuaDashlet_Click;
			if (_mnSua_Dashlet != null)
			{
				((ToolStripItem)_mnSua_Dashlet).Click -= eventHandler;
			}
			_mnSua_Dashlet = value;
			if (_mnSua_Dashlet != null)
			{
				((ToolStripItem)_mnSua_Dashlet).Click += eventHandler;
			}
		}
	}

	internal virtual ToolStripSeparator mnGach
	{
		get
		{
			return _mnGach;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnGach = value;
		}
	}

	internal virtual ToolStripMenuItem mnGian_dong
	{
		get
		{
			return _mnGian_dong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mnGian_dong = value;
		}
	}

	internal virtual ToolStripMenuItem mnThem_giandong
	{
		get
		{
			return _mnThem_giandong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = mnThem_giandong_Click;
			if (_mnThem_giandong != null)
			{
				((ToolStripItem)_mnThem_giandong).Click -= eventHandler;
			}
			_mnThem_giandong = value;
			if (_mnThem_giandong != null)
			{
				((ToolStripItem)_mnThem_giandong).Click += eventHandler;
			}
		}
	}

	internal virtual ToolStripMenuItem mnXoa_giandong
	{
		get
		{
			return _mnXoa_giandong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = mnXoa_giandong_Click;
			if (_mnXoa_giandong != null)
			{
				((ToolStripItem)_mnXoa_giandong).Click -= eventHandler;
			}
			_mnXoa_giandong = value;
			if (_mnXoa_giandong != null)
			{
				((ToolStripItem)_mnXoa_giandong).Click += eventHandler;
			}
		}
	}

	internal virtual frmCreateDashlet frmCreateDashlet
	{
		get
		{
			return _frmCreateDashlet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_frmCreateDashlet = value;
		}
	}

	internal virtual frmListFunction frmListFunction
	{
		get
		{
			return _frmListFunction;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			frmListFunction.LabelRemove_ClickEventHandler obj = LabelRemove_Click;
			frmListFunction.LabelAdd_ClickEventHandler obj2 = LabelAdd_Click;
			frmListFunction.LabelSort_ClickEventHandler obj3 = LabelSort_Click;
			if (_frmListFunction != null)
			{
				_frmListFunction.LabelRemove_Click -= obj;
				_frmListFunction.LabelAdd_Click -= obj2;
				_frmListFunction.LabelSort_Click -= obj3;
			}
			_frmListFunction = value;
			if (_frmListFunction != null)
			{
				_frmListFunction.LabelRemove_Click += obj;
				_frmListFunction.LabelAdd_Click += obj2;
				_frmListFunction.LabelSort_Click += obj3;
			}
		}
	}

	public event AddNewMenu_ClickEventHandler AddNewMenu_Click;

	public event DeleteMenu_ClickEventHandler DeleteMenu_Click;

	public event UpdateDash_ClickEventHandler UpdateDash_Click;

	public event MoveDashletEventHandler MoveDashlet;

	public event ResizeDashletEventHandler ResizeDashlet;

	public event FinishMoveDashletEventHandler FinishMoveDashlet;

	public event FinishResizeDashletEventHandler FinishResizeDashlet;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(disposing);
		}
	}

	public frmDashlet(ImageList imageLisDetail, DataRow row)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		((Control)this).Resize += frmDashlet_Resize;
		((Control)this).MouseUp += new MouseEventHandler(frmDashlet_MouseUp);
		((Control)this).MouseEnter += frmDashElement_MouseEnter;
		((Control)this).MouseLeave += frmDashElement_MouseLeave;
		((UserControl)this).Load += frmDashBoardElement_Load;
		((Control)this).Move += frmDashlet_LocationChanged;
		spacing = 15;
		mHeight = 0;
		MODULE_MENU_FONT = new Font(FontFamily.GenericSansSerif, 12f, (FontStyle)1);
		SUB_MENU_FONT = new Font(FontFamily.GenericSansSerif, 11f, (FontStyle)1);
		DETAIL_MENU_FONT = new Font(FontFamily.GenericSansSerif, 10f, (FontStyle)0);
		MODULE_MENU_BACK_COLOR = Color.Cornsilk;
		MODULE_MENU_FORE_COLOR = Color.Black;
		MODULE_MENU_SELECTED_FORE_COLOR = Color.DarkBlue;
		SUB_MENU_FORE_COLOR = Color.DarkGreen;
		DETAIL_MENU_FORE_COLOR = Color.Black;
		GRADIENT_COLOR = Color.FromArgb(175, 196, 224);
		X_COLUMN2 = Conversions.ToShort(ConfigurationManager.AppSettings["X_COLUMN2"]);
		InitializeComponent();
		ImgListDetail = imageLisDetail;
		f_Row = row;
		LoadData();
		frmListFunction = new frmListFunction(ImgListDetail);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		ChartArea chartArea = new ChartArea();
		Legend legend = new Legend();
		lblTitle = new Label();
		mnsPopup = new ContextMenuStrip(components);
		mnSua_Dashlet = new ToolStripMenuItem();
		mnXoa_Dashlet = new ToolStripMenuItem();
		mnGach1 = new ToolStripSeparator();
		mnSap_xep = new ToolStripMenuItem();
		mnThem_Menu = new ToolStripMenuItem();
		mnXoa_Menu = new ToolStripMenuItem();
		mnGach = new ToolStripSeparator();
		mnGian_dong = new ToolStripMenuItem();
		mnThem_giandong = new ToolStripMenuItem();
		mnXoa_giandong = new ToolStripMenuItem();
		mnDinh_dang = new ToolStripMenuItem();
		mnTableType = new ToolStripMenuItem();
		mnChartType = new ToolStripMenuItem();
		aPanel = new Panel();
		adgvTable = new AsDataGridView();
		myChart = new Chart();
		((Control)mnsPopup).SuspendLayout();
		((Control)aPanel).SuspendLayout();
		((ISupportInitialize)adgvTable).BeginInit();
		((ISupportInitialize)myChart).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lblTitle).Anchor = (AnchorStyles)13;
		((Control)lblTitle).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj = lblTitle;
		Point location = new Point(3, 3);
		((Control)obj).Location = location;
		Label obj2 = lblTitle;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Control)obj2).Margin = margin;
		((Control)lblTitle).Name = "lblTitle";
		Label obj3 = lblTitle;
		Size size = new Size(454, 24);
		((Control)obj3).Size = size;
		((Control)lblTitle).TabIndex = 2;
		lblTitle.Text = "Title";
		lblTitle.TextAlign = (ContentAlignment)16;
		((ToolStrip)mnsPopup).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[9]
		{
			(ToolStripItem)mnSua_Dashlet,
			(ToolStripItem)mnXoa_Dashlet,
			(ToolStripItem)mnGach1,
			(ToolStripItem)mnSap_xep,
			(ToolStripItem)mnThem_Menu,
			(ToolStripItem)mnXoa_Menu,
			(ToolStripItem)mnGach,
			(ToolStripItem)mnGian_dong,
			(ToolStripItem)mnDinh_dang
		});
		((Control)mnsPopup).Name = "ContextMenuStrip1";
		ContextMenuStrip obj4 = mnsPopup;
		size = new Size(207, 192);
		((Control)obj4).Size = size;
		((ToolStripItem)mnSua_Dashlet).Name = "mnSua_Dashlet";
		ToolStripMenuItem obj5 = mnSua_Dashlet;
		size = new Size(206, 22);
		((ToolStripItem)obj5).Size = size;
		((ToolStripItem)mnSua_Dashlet).Text = "Sửa màn hình con";
		((ToolStripItem)mnXoa_Dashlet).Name = "mnXoa_Dashlet";
		ToolStripMenuItem obj6 = mnXoa_Dashlet;
		size = new Size(206, 22);
		((ToolStripItem)obj6).Size = size;
		((ToolStripItem)mnXoa_Dashlet).Text = "Xóa màn hình con";
		((ToolStripItem)mnGach1).Name = "mnGach1";
		ToolStripSeparator obj7 = mnGach1;
		size = new Size(203, 6);
		((ToolStripItem)obj7).Size = size;
		((ToolStripItem)mnSap_xep).Name = "mnSap_xep";
		ToolStripMenuItem obj8 = mnSap_xep;
		size = new Size(206, 22);
		((ToolStripItem)obj8).Size = size;
		((ToolStripItem)mnSap_xep).Text = "Sắp xếp chức năng";
		((ToolStripItem)mnThem_Menu).Name = "mnThem_Menu";
		ToolStripMenuItem obj9 = mnThem_Menu;
		size = new Size(206, 22);
		((ToolStripItem)obj9).Size = size;
		((ToolStripItem)mnThem_Menu).Text = "Thêm chức năng";
		((ToolStripItem)mnXoa_Menu).Name = "mnXoa_Menu";
		ToolStripMenuItem obj10 = mnXoa_Menu;
		size = new Size(206, 22);
		((ToolStripItem)obj10).Size = size;
		((ToolStripItem)mnXoa_Menu).Text = "Xóa chức năng";
		((ToolStripItem)mnGach).Name = "mnGach";
		ToolStripSeparator obj11 = mnGach;
		size = new Size(203, 6);
		((ToolStripItem)obj11).Size = size;
		((ToolStripDropDownItem)mnGian_dong).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)mnThem_giandong,
			(ToolStripItem)mnXoa_giandong
		});
		((ToolStripItem)mnGian_dong).Name = "mnGian_dong";
		ToolStripMenuItem obj12 = mnGian_dong;
		size = new Size(206, 22);
		((ToolStripItem)obj12).Size = size;
		((ToolStripItem)mnGian_dong).Text = "Giãn dòng";
		((ToolStripItem)mnThem_giandong).Name = "mnThem_giandong";
		ToolStripMenuItem obj13 = mnThem_giandong;
		size = new Size(162, 22);
		((ToolStripItem)obj13).Size = size;
		((ToolStripItem)mnThem_giandong).Text = "Thêm giãn dòng";
		((ToolStripItem)mnXoa_giandong).Name = "mnXoa_giandong";
		ToolStripMenuItem obj14 = mnXoa_giandong;
		size = new Size(162, 22);
		((ToolStripItem)obj14).Size = size;
		((ToolStripItem)mnXoa_giandong).Text = "Xoá dãn dòng";
		((ToolStripDropDownItem)mnDinh_dang).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)mnTableType,
			(ToolStripItem)mnChartType
		});
		((ToolStripItem)mnDinh_dang).Name = "mnDinh_dang";
		ToolStripMenuItem obj15 = mnDinh_dang;
		size = new Size(206, 22);
		((ToolStripItem)obj15).Size = size;
		((ToolStripItem)mnDinh_dang).Text = "Định dạng màn hình con";
		((ToolStripItem)mnTableType).Name = "mnTableType";
		ToolStripMenuItem obj16 = mnTableType;
		size = new Size(152, 22);
		((ToolStripItem)obj16).Size = size;
		((ToolStripItem)mnTableType).Text = "Bảng";
		((ToolStripItem)mnChartType).Name = "mnChartType";
		ToolStripMenuItem obj17 = mnChartType;
		size = new Size(152, 22);
		((ToolStripItem)obj17).Size = size;
		((ToolStripItem)mnChartType).Text = "Đồ thị";
		((Control)aPanel).Anchor = (AnchorStyles)15;
		((ScrollableControl)aPanel).AutoScroll = true;
		((Control)aPanel).BackColor = SystemColors.ControlLightLight;
		((Control)aPanel).ContextMenuStrip = mnsPopup;
		((Control)aPanel).Controls.Add((Control)(object)adgvTable);
		((Control)aPanel).Controls.Add((Control)(object)myChart);
		Panel obj18 = aPanel;
		location = new Point(3, 30);
		((Control)obj18).Location = location;
		((Control)aPanel).Name = "aPanel";
		Panel obj19 = aPanel;
		size = new Size(454, 337);
		((Control)obj19).Size = size;
		((Control)aPanel).TabIndex = 3;
		((DataGridView)adgvTable).AllowUserToAddRows = false;
		((DataGridView)adgvTable).AllowUserToDeleteRows = false;
		((DataGridView)adgvTable).BorderStyle = (BorderStyle)0;
		((DataGridView)adgvTable).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((Control)adgvTable).Dock = (DockStyle)5;
		adgvTable.DoubleBuffered = false;
		((DataGridView)adgvTable).EditMode = (DataGridViewEditMode)0;
		((DataGridView)adgvTable).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = adgvTable;
		location = new Point(0, 0);
		((Control)asDataGridView).Location = location;
		((Control)adgvTable).Name = "adgvTable";
		adgvTable.ReadOnly = true;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvTable).RowHeadersDefaultCellStyle = val;
		adgvTable.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)adgvTable).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = adgvTable;
		size = new Size(454, 337);
		((Control)asDataGridView2).Size = size;
		((Control)adgvTable).TabIndex = 1;
		((Control)adgvTable).Visible = false;
		chartArea.Name = "ChartArea1";
		myChart.ChartAreas.Add(chartArea);
		((Control)myChart).ContextMenuStrip = mnsPopup;
		((Control)myChart).Dock = (DockStyle)5;
		legend.Name = "Legend1";
		myChart.Legends.Add(legend);
		Chart chart = myChart;
		location = new Point(0, 0);
		((Control)chart).Location = location;
		((Control)myChart).Name = "myChart";
		Chart chart2 = myChart;
		size = new Size(454, 337);
		chart2.Size = size;
		((Control)myChart).TabIndex = 0;
		((Control)myChart).Text = "Chart";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.WhiteSmoke;
		((Control)this).Controls.Add((Control)(object)lblTitle);
		((Control)this).Controls.Add((Control)(object)aPanel);
		((Control)this).Name = "frmDashlet";
		size = new Size(460, 370);
		((Control)this).Size = size;
		((Control)mnsPopup).ResumeLayout(false);
		((Control)aPanel).ResumeLayout(false);
		((ISupportInitialize)adgvTable).EndInit();
		((ISupportInitialize)myChart).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void mnSuaDashlet_Click(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		frmCreateDashlet = new frmCreateDashlet(EditMode: true, Conversions.ToInteger(f_Row["DashID"]));
		((Form)frmCreateDashlet).ShowDialog((IWin32Window)(object)this);
		if (frmCreateDashlet.f_IsEdit)
		{
			UpdateDash_Click?.Invoke(RuntimeHelpers.GetObjectValue(f_Row["DashID"]), e);
		}
	}

	private void mnXoa_Dashlet_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		if ((int)CMessageBox.ShowWithFormat(50003, (MessageBoxButtons)4) != 7)
		{
			DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
			if (dashBoardDAO.DelDashForm(Conversions.ToString(f_Row["DashID"])) == 0)
			{
				((Control)this).Parent.Controls.Remove((Control)(object)this);
				UpdateDash_Click?.Invoke(RuntimeHelpers.GetObjectValue(f_Row["DashID"]), e);
			}
		}
	}

	private void Table_Click(object sender, EventArgs e)
	{
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		int num = dashBoardDAO.UpdDashForm(Conversions.ToInteger(f_Row["location"]), ((ToolStripItem)mnTableType).Name, Conversions.ToString(f_Row["Title"]), Conversions.ToString(f_Row["DashID"]), Conversions.ToInteger(f_Row["X"]), Conversions.ToInteger(f_Row["Y"]), Conversions.ToInteger(f_Row["H"]), Conversions.ToInteger(f_Row["W"]));
		dashBoardDAO.Destroy();
		if (num != 0)
		{
			CMessageBox.Show(num);
		}
		else
		{
			UpdateDash_Click?.Invoke(RuntimeHelpers.GetObjectValue(f_Row["DashID"]), e);
		}
	}

	private void CHART_Click(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		frmUpdRptChartResX frmUpdRptChartResX = new frmUpdRptChartResX();
		frmUpdRptChartResX.f_oTblData = oDtData;
		ReportChartInfo reportChartInfo = new ReportChartInfo();
		reportChartInfo = AsiaErp.Framework.Environment.GetReportChartInformation(f_Row["DashID"].ToString());
		frmUpdRptChartResX.f_oReportChartInfo = reportChartInfo;
		((Form)frmUpdRptChartResX).ShowDialog((IWin32Window)(object)this);
		if (frmUpdRptChartResX.f_isOK)
		{
			DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
			int num = dashBoardDAO.UpdDashForm(Conversions.ToInteger(f_Row["location"]), ((ToolStripItem)mnChartType).Name, Conversions.ToString(f_Row["Title"]), Conversions.ToString(f_Row["DashID"]), Conversions.ToInteger(f_Row["X"]), Conversions.ToInteger(f_Row["Y"]), Conversions.ToInteger(f_Row["H"]), Conversions.ToInteger(f_Row["W"]));
			dashBoardDAO.Destroy();
			if (num != 0)
			{
				CMessageBox.Show(num);
				return;
			}
			frmUpdRptChartResX.f_sMenuID = Conversions.ToString(f_Row["DashID"]);
			frmUpdRptChartResX.UpdRptChartResX();
			UpdateDash_Click?.Invoke(RuntimeHelpers.GetObjectValue(f_Row["DashID"]), e);
		}
	}

	private void mnThem_Menu_Click(object sender, EventArgs e)
	{
		mnClick(" - Thêm chức năng", 1);
	}

	private void mnXoa_Menu_Click(object sender, EventArgs e)
	{
		mnClick(" - Xoá chức năng", 2);
	}

	private void mnSap_xep_Click(object sender, EventArgs e)
	{
		mnClick(" - Sắp xếp chức năng", 3);
	}

	private void mnThem_giandong_Click(object sender, EventArgs e)
	{
		if (lblMenu != null)
		{
			AddSpacing_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void mnXoa_giandong_Click(object sender, EventArgs e)
	{
		if (lblMenu != null)
		{
			RemoveSpacing_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void LabelSort_Click(object sender, EventArgs e)
	{
		LoadData();
		UpdateDash_Click?.Invoke(RuntimeHelpers.GetObjectValue(f_Row["DashID"]), e);
	}

	private void LabelAdd_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		LinkLabel val = (LinkLabel)sender;
		DataRow dataRow = (DataRow)((Control)val).Tag;
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		if (dashBoardDAO.InsMenuFrequence(Conversions.ToString(dataRow["menuid"]), Conversions.ToInteger(f_Row["DashID"])) == 0)
		{
			UpdateSize(25);
			UpdateDash_Click?.Invoke(RuntimeHelpers.GetObjectValue(f_Row["DashID"]), e);
		}
		dashBoardDAO.Destroy();
	}

	private void LabelRemove_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		LinkLabel val = (LinkLabel)sender;
		DataRow dataRow = (DataRow)((Control)val).Tag;
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		if (dashBoardDAO.DelMenuFrequence(Conversions.ToString(dataRow["menuid"]), Conversions.ToInteger(f_Row["DashID"])) == 0)
		{
			UpdateSize(-25);
			UpdateDash_Click?.Invoke(RuntimeHelpers.GetObjectValue(f_Row["DashID"]), e);
		}
		dashBoardDAO.Destroy();
	}

	private void AddSpacing_Click(object sender, EventArgs e)
	{
		DataRow dataRow = (DataRow)((Control)lblMenu).Tag;
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		if (dashBoardDAO.UpdMenuFrequence(Conversions.ToString(dataRow["menuid"]), Conversions.ToInteger(f_Row["DashID"]), Space: true) == 0)
		{
			UpdateSize(spacing);
			UpdateDash_Click?.Invoke(RuntimeHelpers.GetObjectValue(f_Row["DashID"]), e);
		}
		dashBoardDAO.Destroy();
	}

	private void RemoveSpacing_Click(object sender, EventArgs e)
	{
		DataRow dataRow = (DataRow)((Control)lblMenu).Tag;
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		if (dashBoardDAO.UpdMenuFrequence(Conversions.ToString(dataRow["menuid"]), Conversions.ToInteger(f_Row["DashID"]), Space: false) == 0)
		{
			UpdateSize(checked(-spacing));
			UpdateDash_Click?.Invoke(RuntimeHelpers.GetObjectValue(f_Row["DashID"]), e);
		}
		dashBoardDAO.Destroy();
	}

	private void frmDashElement_MouseEnter(object sender, EventArgs e)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		Point pt = ((Control)this).PointToClient(Cursor.Position);
		if (((Control)this).ClientRectangle.Contains(pt))
		{
			((Control)this).BackColor = Color.LightGray;
		}
		if (Operators.CompareString(sender.GetType().Name, "LinkLabel", false) == 0)
		{
			lblMenu = (LinkLabel)sender;
		}
	}

	private void frmDashElement_MouseLeave(object sender, EventArgs e)
	{
		Point pt = ((Control)this).PointToClient(Cursor.Position);
		if (!((Control)this).ClientRectangle.Contains(pt))
		{
			((Control)this).BackColor = Color.WhiteSmoke;
		}
	}

	protected override void OnCreateControl()
	{
		((UserControl)this).OnCreateControl();
		if (!((Component)(object)this).DesignMode)
		{
			((ToolStripItem)mnSua_Dashlet).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_DASHLET_CONTEXTMENU_EDIT_TEXT");
			((ToolStripItem)mnXoa_Dashlet).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_DASHLET_CONTEXTMENU_DELETE_TEXT");
			((ToolStripItem)mnSap_xep).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_DASHLET_CONTEXTMENU_SORTITEM_TEXT");
			((ToolStripItem)mnThem_Menu).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_DASHLET_CONTEXTMENU_ADDITEM_TEXT");
			((ToolStripItem)mnXoa_Menu).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_DASHLET_CONTEXTMENU_DELETEITEM_TEXT");
			((ToolStripItem)mnGian_dong).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_DASHLET_CONTEXTMENU_ROWSTRETCH_TEXT");
			((ToolStripItem)mnThem_giandong).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_DASHLET_CONTEXTMENU_ROWSTRETCHMORE_TEXT");
			((ToolStripItem)mnXoa_giandong).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_DASHLET_CONTEXTMENU_ROWSTRETCHLESS_TEXT");
			((ToolStripItem)mnDinh_dang).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_DASHLET_CONTEXTMENU_FORMAT_TEXT");
			((ToolStripItem)mnDinh_dang).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_DASHLET_CONTEXTMENU_FORMAT_TEXT");
			((ToolStripItem)mnTableType).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_DASHLET_CONTEXTMENU_FORMAT_TABLE_TEXT");
			((ToolStripItem)mnChartType).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_DASHLET_CONTEXTMENU_FORMAT_CHART_TEXT");
		}
	}

	private void frmDashBoardElement_Load(object sender, EventArgs e)
	{
		rcT = new ResizeableControl((Control)(object)lblTitle, OnlyMove: true);
		rcF = new ResizeableControl((Control)(object)this);
		if (!((Component)(object)this).DesignMode)
		{
			GetResource();
		}
	}

	private void frmDashlet_LocationChanged(object sender, EventArgs e)
	{
		if (!frmDashBoard.bLoading && rcT != null && rcT.GetCursorStatusEnum() == 5)
		{
			MoveDashlet?.Invoke(RuntimeHelpers.GetObjectValue(sender), rcT);
		}
	}

	private void lblTitle_MouseUp(object sender, MouseEventArgs e)
	{
		if (rcT.GetMouseStyle())
		{
			FinishMoveDashlet?.Invoke(this, rcT);
		}
	}

	private void frmDashlet_Resize(object sender, EventArgs e)
	{
		mHeight = ((Control)this).Height;
		if (!frmDashBoard.bLoading && rcT != null)
		{
			ResizeDashlet?.Invoke(this, rcF);
		}
	}

	private void frmDashlet_MouseUp(object sender, MouseEventArgs e)
	{
		FinishResizeDashlet?.Invoke(this, rcF);
	}

	private DataTable GetDataBySp(string SpName, int DashID, bool IsSys = false)
	{
		DataTable dataTable = new DataTable();
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		DataTable valueParameter = dashBoardDAO.GetValueParameter(DashID);
		dashBoardDAO.Destroy();
		dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", IsSys);
		checked
		{
			if (valueParameter.Rows.Count == 0)
			{
				dataTable = dashBoardDAO.ProcessSPDashBoard(SpName);
			}
			else
			{
				ArrayList arrayList = new ArrayList();
				arrayList.Add(SpName);
				int num = valueParameter.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(valueParameter.Rows[i]["paraname"].ToString().ToUpper(), "@PMA_CTY", false) == 0)
					{
						arrayList.Add(valueParameter.Rows[i]["paraname"].ToString());
						arrayList.Add(CompanyInformations.CompanyID);
					}
					else
					{
						arrayList.Add(valueParameter.Rows[i]["paraname"].ToString());
						arrayList.Add(valueParameter.Rows[i]["paravalue"].ToString());
					}
				}
				dataTable = dashBoardDAO.ProcessSPDashBoard(arrayList.ToArray());
			}
			dashBoardDAO.Destroy();
			return dataTable;
		}
	}

	public void LoadData()
	{
		lblTitle.Text = Conversions.ToString(f_Row["Title"]);
		if (Operators.ConditionalCompareObjectEqual(f_Row["spName"], (object)"", false))
		{
			oDtData = Commons.GetSYSDataTable("asGetDashFrequentlyFunction", SystemInformations.UserName, RuntimeHelpers.GetObjectValue(f_Row["dashid"]), false, SystemInformations.CurrentCultureName);
		}
		else
		{
			oDtData = GetDataBySp(Conversions.ToString(f_Row["spName"]), Conversions.ToInteger(f_Row["dashid"]));
		}
		if (oDtData != null)
		{
			object obj = f_Row["format"];
			if (Operators.ConditionalCompareObjectEqual(obj, (object)"MENU", false))
			{
				((Control)myChart).Visible = false;
				CreateLinkData(oDtData.Rows);
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, (object)"CHART", false))
			{
				CreateChartData();
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, (object)"TABLE", false))
			{
				mnTableType.Enabled = false;
				((Control)adgvTable).Visible = true;
				CreateTableData();
			}
			EnablePopupMenu();
		}
	}

	private void CreateTableData()
	{
		ReportGridviewBrowseDynamic(adgvTable, oDtData);
	}

	private void CreateChartData()
	{
		((Control)myChart).Visible = false;
		ctlReportChart ctlReportChart = new ctlReportChart();
		((Control)aPanel).Controls.Add((Control)(object)ctlReportChart);
		((Control)ctlReportChart).Dock = (DockStyle)5;
		ctlReportChart.MyData = oDtData.DefaultView;
		ReportChartInfo reportChartInformation = AsiaErp.Framework.Environment.GetReportChartInformation(Conversions.ToString(f_Row["dashid"]));
		if (reportChartInformation != null)
		{
			ctlReportChart.MyReportChartInfo = reportChartInformation;
			Commons.FormatChartControl(ctlReportChart, ctlReportChart.MyReportChartInfo);
			if (ctlReportChart.Valid())
			{
				ctlReportChart.DoGraph();
				((Control)ctlReportChart).Refresh();
			}
		}
	}

	private void EnablePopupMenu()
	{
		object obj = f_Row["format"];
		if (Operators.ConditionalCompareObjectEqual(obj, (object)"MENU", false))
		{
			((ToolStripItem)mnDinh_dang).Visible = false;
			((ToolStripItem)mnGach).Visible = true;
		}
		else if (Operators.ConditionalCompareObjectEqual(obj, (object)"CHART", false))
		{
			((ToolStripItem)mnSap_xep).Visible = false;
			((ToolStripItem)mnThem_Menu).Visible = false;
			((ToolStripItem)mnXoa_Menu).Visible = false;
			((ToolStripItem)mnGach).Visible = false;
			((ToolStripItem)mnGian_dong).Visible = false;
		}
		else if (Operators.ConditionalCompareObjectEqual(obj, (object)"TABLE", false))
		{
			((ToolStripItem)mnSap_xep).Visible = false;
			((ToolStripItem)mnThem_Menu).Visible = false;
			((ToolStripItem)mnXoa_Menu).Visible = false;
			((ToolStripItem)mnGach).Visible = false;
			((ToolStripItem)mnGian_dong).Visible = false;
		}
	}

	private void UpdateSize(int size)
	{
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		int num = dashBoardDAO.UpdDashForm(Conversions.ToInteger(f_Row["location"]), Conversions.ToString(f_Row["format"]), Conversions.ToString(f_Row["title"]), Conversions.ToString(f_Row["dashid"]), Conversions.ToInteger(f_Row["X"]), Conversions.ToInteger(f_Row["Y"]), size, Conversions.ToInteger(f_Row["W"]), IsMenu: true);
	}

	private void CreateLinkData(DataRowCollection rows)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		int count = rows.Count;
		Point location = new Point(10, 10);
		((Control)aPanel).Controls.Clear();
		checked
		{
			int num = count - 1;
			Padding padding = default(Padding);
			for (int i = 0; i <= num; i++)
			{
				LinkLabel val = new LinkLabel();
				((Label)val).AutoSize = true;
				val.Text = Conversions.ToString(rows[i]["bar"]);
				((Control)val).Tag = rows[i];
				((Label)val).Image = (Image)NewLateBinding.LateGet((object)ImgListDetail.Images, (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(rows[i]["picture1"]) }, (string[])null, (Type[])null, (bool[])null);
				((Label)val).ImageAlign = (ContentAlignment)16;
				((Label)val).TextAlign = (ContentAlignment)16;
				val.LinkBehavior = (LinkBehavior)2;
				val.LinkColor = DETAIL_MENU_FORE_COLOR;
				((Control)val).Font = DETAIL_MENU_FONT;
				((Padding)(ref padding))._002Ector(30, 0, 0, 0);
				val.Padding = padding;
				((Control)val).Location = location;
				((Control)val).MouseClick += new MouseEventHandler(DetailLink_MouseCLick);
				((Control)val).MouseEnter += frmDashElement_MouseEnter;
				((Control)val).MouseLeave += frmDashElement_MouseLeave;
				((Control)aPanel).Controls.Add((Control)(object)val);
				if (Conversions.ToBoolean(rows[i]["space"]))
				{
					location.Y += 25 + spacing;
				}
				else
				{
					location.Y += 25;
				}
			}
		}
	}

	private void DetailLink_MouseCLick(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			ExecuteCommand((DataRow)NewLateBinding.LateGet(sender, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	private void mnClick(string Title, int Type)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		frmListFunction = new frmListFunction(ImgListDetail);
		((Form)frmListFunction).Text = ((Form)frmListFunction).Text + Title;
		frmListFunction.f_DashID = Conversions.ToInteger(f_Row["DashID"]);
		frmListFunction.f_StoreProcedure = Conversions.ToString(f_Row["spName"]);
		frmListFunction.f_Type = Type;
		((Form)frmListFunction).ShowDialog((IWin32Window)(object)this);
	}

	private void GetResource()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		string[] array = ConfigurationManager.AppSettings["MODULE_MENU_FONT"].Split(new char[1] { ',' });
		MODULE_MENU_FONT = new Font(array[0], Conversions.ToSingle(array[1]), (FontStyle)Conversions.ToInteger(array[2]));
		array = ConfigurationManager.AppSettings["SUB_MENU_FONT"].Split(new char[1] { ',' });
		SUB_MENU_FONT = new Font(array[0], Conversions.ToSingle(array[1]), (FontStyle)Conversions.ToInteger(array[2]));
		array = ConfigurationManager.AppSettings["DETAIL_MENU_FONT"].Split(new char[1] { ',' });
		DETAIL_MENU_FONT = new Font(array[0], Conversions.ToSingle(array[1]), (FontStyle)Conversions.ToInteger(array[2]));
		MODULE_MENU_BACK_COLOR = ColorFromConfig(ConfigurationManager.AppSettings["MODULE_MENU_BACK_COLOR"]);
		SUB_MENU_FORE_COLOR = ColorFromConfig(ConfigurationManager.AppSettings["SUB_MENU_FORE_COLOR"]);
		DETAIL_MENU_FORE_COLOR = ColorFromConfig(ConfigurationManager.AppSettings["DETAIL_MENU_FORE_COLOR"]);
		MODULE_MENU_FORE_COLOR = ColorFromConfig(ConfigurationManager.AppSettings["MODULE_MENU_FORE_COLOR"]);
		MODULE_MENU_SELECTED_FORE_COLOR = ColorFromConfig(ConfigurationManager.AppSettings["MODULE_MENU_SELECTED_FORE_COLOR"]);
		((Control)lblTitle).ForeColor = ColorFromConfig(ConfigurationManager.AppSettings["CURRENT_MODULE_LABEL_FORE_COLOR"]);
		int num = 280;
		try
		{
			num = Conversions.ToInteger(ConfigurationManager.AppSettings["MODULE_PANEL_MAX_WIDTH"]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void ExecuteCommand(DataRow row)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(row["command"], (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			return;
		}
		if (!Commons.ChkExecRight(Conversions.ToString(row["MenuId"])))
		{
			CMessageBox.Show(50005);
			return;
		}
		((Control)this).Parent.Cursor = Cursors.WaitCursor;
		try
		{
			if (Operators.ConditionalCompareObjectEqual(row["form"], (object)"1", false))
			{
				CallMyForm(Conversions.ToString(row["menuid"]), Conversions.ToString(row["command"]), Conversions.ToString(row["dllName"]));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)(ex2.Message + "\r\n" + ex2.StackTrace), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		((Control)this).Parent.Cursor = Cursors.Default;
	}

	private void CallMyForm(string MenuID, string oType, string dllName)
	{
		frmAsiaRoot frmAsiaRoot = null;
		string text = "";
		string[] array = oType.Trim().Split(new char[1] { '.' });
		text = array[checked(array.Count() - 1)];
		frmAsiaRoot = (frmAsiaRoot)(object)Application.OpenForms[text];
		if (frmAsiaRoot == null || ((Control)frmAsiaRoot).IsDisposed || DateTime.Compare(frmAsiaRoot.LastModifiedDate, DateAndTime.DateAdd((DateInterval)8, -15.0, DateAndTime.Now)) < 0)
		{
			if (frmAsiaRoot != null && !((Control)frmAsiaRoot).IsDisposed)
			{
				((Component)(object)frmAsiaRoot).Dispose();
			}
			string name = "vi-VN";
			if (SystemInformations.CurrentCultureName != null && Operators.CompareString(SystemInformations.CurrentCultureName, "", false) != 0)
			{
				name = SystemInformations.CurrentCultureName;
			}
			CultureInfo culture = new CultureInfo(name);
			oType = oType.Trim();
			Assembly assembly;
			try
			{
				assembly = Assembly.Load(dllName);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Helper.ProcessError(ex2);
				ProjectData.ClearProjectError();
				return;
			}
			if ((object)assembly != null)
			{
				object[] args = new object[1] { MenuID };
				Type type = assembly.GetType(oType, throwOnError: true, ignoreCase: true);
				try
				{
					frmAsiaRoot = (frmAsiaRoot)type.InvokeMember(null, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, null, args, culture);
					frmAsiaRoot.LastModifiedDate = DateAndTime.Now;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Helper.ProcessError(ex4);
					ProjectData.ClearProjectError();
				}
			}
			if (frmAsiaRoot != null)
			{
				frmDashBoard frmDashBoard2 = (frmDashBoard)(object)((Control)this).Parent.Parent;
				frmAsiaRoot.Show(frmDashBoard2.MyDockPanel, DockState.Document);
				((Control)frmAsiaRoot).BringToFront();
			}
		}
		else
		{
			((Control)frmAsiaRoot).BringToFront();
		}
	}

	private Color ColorFromConfig(string sValue)
	{
		sValue = sValue.Trim();
		Color result = Color.Black;
		if (sValue.ToLower().Contains("rgb"))
		{
			int num = sValue.IndexOf("(");
			int num2 = sValue.IndexOf(")");
			string[] array = checked(sValue.Substring(num + 1, num2 - num - 1)).Split(new char[1] { ',' });
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

	public void ReportGridviewBrowseDynamic(AsDataGridView adgv, DataTable datasource, string hideFieldList = "")
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		if (datasource == null)
		{
			return;
		}
		((DataGridView)adgv).Columns.Clear();
		((DataGridView)adgv).AutoGenerateColumns = false;
		((DataGridView)adgv).DataSource = datasource;
		checked
		{
			int num = datasource.Columns.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataColumn dataColumn = datasource.Columns[i];
				DataGridViewColumn val;
				if ((object)dataColumn.DataType == typeof(DateTime))
				{
					val = (DataGridViewColumn)(object)new DataGridViewAsMaskedTextBoxColumn();
					val.DefaultCellStyle.Alignment = (DataGridViewContentAlignment)32;
					val.MinimumWidth = 75;
				}
				else if ((object)dataColumn.DataType == typeof(bool))
				{
					val = (DataGridViewColumn)new DataGridViewCheckBoxColumn();
					val.DefaultCellStyle.Alignment = (DataGridViewContentAlignment)32;
				}
				else if ((object)dataColumn.DataType == typeof(decimal))
				{
					val = (DataGridViewColumn)new DataGridViewTextBoxColumn();
					val.DefaultCellStyle.Alignment = (DataGridViewContentAlignment)64;
					if (dataColumn.ColumnName.Contains("nt"))
					{
						val.DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
					}
					else
					{
						val.DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
					}
				}
				else if (((object)dataColumn.DataType == typeof(long)) | ((object)dataColumn.DataType == typeof(int)))
				{
					val = (DataGridViewColumn)new DataGridViewTextBoxColumn();
					val.DefaultCellStyle.Alignment = (DataGridViewContentAlignment)64;
					val.DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
				}
				else
				{
					val = (DataGridViewColumn)new DataGridViewTextBoxColumn();
				}
				val.HeaderText = dataColumn.ColumnName;
				val.Name = dataColumn.ColumnName;
				val.DataPropertyName = dataColumn.ColumnName;
				((DataGridView)adgv).Columns.Add(val);
			}
			if (Operators.CompareString(ClientConfiguration.BC_BakgroundColor.Name, "", false) != 0)
			{
				((DataGridView)adgv).BackgroundColor = ClientConfiguration.BC_BakgroundColor;
			}
			if (Operators.CompareString(ClientConfiguration.BC_AlternatingBackColor.Name, "", false) != 0)
			{
				((DataGridView)adgv).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.BC_AlternatingBackColor;
			}
			DataGridViewCellStyle val2 = ((DataGridView)adgv).DefaultCellStyle.Clone();
			val2.ForeColor = Color.Blue;
			adgv.SetAllRowStyle("bold='1'", val2);
			((DataGridView)adgv).AutoResizeColumns((DataGridViewAutoSizeColumnsMode)6);
			if (unchecked((long)ClientConfiguration.Max_Width_Of_Column_Report) <= 75L)
			{
				return;
			}
			foreach (DataGridViewColumn item in (BaseCollection)((DataGridView)adgv).Columns)
			{
				DataGridViewColumn val3 = item;
				try
				{
					if (val3.Width > ClientConfiguration.Max_Width_Of_Column_Report)
					{
						val3.AutoSizeMode = (DataGridViewAutoSizeColumnMode)0;
						val3.Width = (int)ClientConfiguration.Max_Width_Of_Column_Report;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					throw ex2;
				}
			}
		}
	}
}
