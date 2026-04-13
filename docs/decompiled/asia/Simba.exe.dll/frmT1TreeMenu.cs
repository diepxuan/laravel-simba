using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmT1TreeMenu : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("trvMenu")]
	private TreeView _trvMenu;

	[AccessedThroughProperty("pnMain")]
	private Panel _pnMain;

	[AccessedThroughProperty("lsvChiTiet")]
	private ListView _lsvChiTiet;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("lblMenu")]
	private Label _lblMenu;

	[AccessedThroughProperty("Splitter1")]
	private Splitter _Splitter1;

	[AccessedThroughProperty("stbMenu")]
	private StatusBar _stbMenu;

	[AccessedThroughProperty("MenuItem9")]
	private MenuItem _MenuItem9;

	[AccessedThroughProperty("imgList")]
	private ImageList _imgList;

	[AccessedThroughProperty("imgTree")]
	private ImageList _imgTree;

	[AccessedThroughProperty("MnuAbout")]
	private MenuItem _MnuAbout;

	[AccessedThroughProperty("MnuMain")]
	private MainMenu _MnuMain;

	[AccessedThroughProperty("MnuSystem")]
	private MenuItem _MnuSystem;

	[AccessedThroughProperty("MnuExit")]
	private MenuItem _MnuExit;

	[AccessedThroughProperty("MenuItem4")]
	private MenuItem _MenuItem4;

	[AccessedThroughProperty("mniLanguege")]
	private MenuItem _mniLanguege;

	[AccessedThroughProperty("MnuHelp")]
	private MenuItem _MnuHelp;

	[AccessedThroughProperty("ImgNothing")]
	private ImageList _ImgNothing;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	private DataTable f_oTblMenu;

	private string f_strIDCap2;

	private int f_intImgCountCap1;

	private int f_intImgCountCap2;

	private bool f_blnLogOff;

	private DataTable f_oTblLanguage;

	private const string DEFAULT_IMAGE = "Folder.bmp";

	private const string SELECTED_IMAGE = "FolderO.bmp";

	private const string BACKGROUND_IMAGE = "anhmn.bmp";

	private Hashtable f_FormCollection;

	internal virtual TreeView trvMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _trvMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			TreeViewEventHandler val = new TreeViewEventHandler(trvMenu_AfterSelect);
			if (_trvMenu != null)
			{
				_trvMenu.AfterSelect -= val;
			}
			_trvMenu = value;
			if (_trvMenu != null)
			{
				_trvMenu.AfterSelect += val;
			}
		}
	}

	internal virtual Panel pnMain
	{
		[DebuggerNonUserCode]
		get
		{
			return _pnMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_pnMain = value;
		}
	}

	internal virtual ListView lsvChiTiet
	{
		[DebuggerNonUserCode]
		get
		{
			return _lsvChiTiet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lsvChiTiet_DoubleClick;
			if (_lsvChiTiet != null)
			{
				((Control)_lsvChiTiet).DoubleClick -= eventHandler;
			}
			_lsvChiTiet = value;
			if (_lsvChiTiet != null)
			{
				((Control)_lsvChiTiet).DoubleClick += eventHandler;
			}
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Panel Panel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel3 = value;
		}
	}

	internal virtual Label lblMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMenu = value;
		}
	}

	internal virtual Splitter Splitter1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Splitter1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Splitter1 = value;
		}
	}

	internal virtual StatusBar stbMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _stbMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_stbMenu = value;
		}
	}

	internal virtual MenuItem MenuItem9
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuItem9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MenuItem9 = value;
		}
	}

	internal virtual ImageList imgList
	{
		[DebuggerNonUserCode]
		get
		{
			return _imgList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_imgList = value;
		}
	}

	internal virtual ImageList imgTree
	{
		[DebuggerNonUserCode]
		get
		{
			return _imgTree;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_imgTree = value;
		}
	}

	internal virtual MenuItem MnuAbout
	{
		[DebuggerNonUserCode]
		get
		{
			return _MnuAbout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MnuAbout = value;
		}
	}

	internal virtual MainMenu MnuMain
	{
		[DebuggerNonUserCode]
		get
		{
			return _MnuMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MnuMain = value;
		}
	}

	internal virtual MenuItem MnuSystem
	{
		[DebuggerNonUserCode]
		get
		{
			return _MnuSystem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MnuSystem = value;
		}
	}

	internal virtual MenuItem MnuExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _MnuExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = MnuExit_Click;
			if (_MnuExit != null)
			{
				_MnuExit.Click -= eventHandler;
			}
			_MnuExit = value;
			if (_MnuExit != null)
			{
				_MnuExit.Click += eventHandler;
			}
		}
	}

	internal virtual MenuItem MenuItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MenuItem4 = value;
		}
	}

	internal virtual MenuItem mniLanguege
	{
		[DebuggerNonUserCode]
		get
		{
			return _mniLanguege;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mniLanguege = value;
		}
	}

	internal virtual MenuItem MnuHelp
	{
		[DebuggerNonUserCode]
		get
		{
			return _MnuHelp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MnuHelp = value;
		}
	}

	internal virtual ImageList ImgNothing
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImgNothing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImgNothing = value;
		}
	}

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
	}

	private Form GetMyForm
	{
		get
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected O, but got Unknown
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Expected O, but got Unknown
			if (f_FormCollection == null)
			{
				f_FormCollection = new Hashtable();
			}
			Form result;
			if ((!f_FormCollection.Contains(MenuID) || ((Control)(Form)f_FormCollection[MenuID]).IsDisposed || DateTime.Compare(((frmAsiaRoot)f_FormCollection[MenuID]).LastModifiedDate, DateAndTime.DateAdd((DateInterval)8, -15.0, DateAndTime.Now)) < 0) ? true : false)
			{
				if (f_FormCollection.Contains(MenuID))
				{
					if (!((Control)(Form)f_FormCollection[MenuID]).IsDisposed)
					{
						((Component)(Form)f_FormCollection[MenuID]).Dispose();
					}
					f_FormCollection.Remove(MenuID);
				}
				string name = "vi-VN";
				if ((SystemInformations.CurrentCultureName != null && Operators.CompareString(SystemInformations.CurrentCultureName, "", false) != 0) ? true : false)
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
					result = null;
					ProjectData.ClearProjectError();
					goto IL_01d6;
				}
				object[] args = new object[1] { MenuID };
				Type type = assembly.GetType(oType, throwOnError: true, ignoreCase: true);
				try
				{
					Form val = (Form)type.InvokeMember(null, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, null, args, culture);
					((frmAsiaRoot)(object)val).LastModifiedDate = DateAndTime.Now;
					f_FormCollection.Add(MenuID, val);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Helper.ProcessError(ex4.InnerException);
					ProjectData.ClearProjectError();
				}
			}
			result = (Form)f_FormCollection[MenuID];
			goto IL_01d6;
			IL_01d6:
			return result;
		}
	}

	public frmT1TreeMenu()
	{
		((Control)this).Resize += frmMenuTest_Resize;
		((Form)this).Load += frmTreeMenu_Load;
		__ENCAddToList(this);
		f_blnLogOff = false;
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
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected O, but got Unknown
		components = new Container();
		trvMenu = new TreeView();
		pnMain = new Panel();
		Panel2 = new Panel();
		lsvChiTiet = new ListView();
		GroupBox1 = new GroupBox();
		Panel3 = new Panel();
		lblMenu = new Label();
		Splitter1 = new Splitter();
		stbMenu = new StatusBar();
		MenuItem9 = new MenuItem();
		imgList = new ImageList(components);
		imgTree = new ImageList(components);
		MnuAbout = new MenuItem();
		MnuMain = new MainMenu(components);
		MnuSystem = new MenuItem();
		MnuExit = new MenuItem();
		MenuItem4 = new MenuItem();
		mniLanguege = new MenuItem();
		MnuHelp = new MenuItem();
		ImgNothing = new ImageList(components);
		((Control)pnMain).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)trvMenu).Dock = (DockStyle)3;
		((Control)trvMenu).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		trvMenu.Indent = 18;
		trvMenu.ItemHeight = 20;
		TreeView obj = trvMenu;
		Point location = new Point(0, 0);
		((Control)obj).Location = location;
		((Control)trvMenu).Name = "trvMenu";
		TreeView obj2 = trvMenu;
		Size size = new Size(299, 456);
		((Control)obj2).Size = size;
		((Control)trvMenu).TabIndex = 0;
		((Control)pnMain).Controls.Add((Control)(object)Panel2);
		((Control)pnMain).Controls.Add((Control)(object)Splitter1);
		((Control)pnMain).Controls.Add((Control)(object)trvMenu);
		((Control)pnMain).Dock = (DockStyle)5;
		Panel obj3 = pnMain;
		location = new Point(0, 0);
		((Control)obj3).Location = location;
		((Control)pnMain).Name = "pnMain";
		Panel obj4 = pnMain;
		size = new Size(847, 456);
		((Control)obj4).Size = size;
		((Control)pnMain).TabIndex = 3;
		((Control)Panel2).BackColor = Color.White;
		Panel2.BorderStyle = (BorderStyle)2;
		((Control)Panel2).Controls.Add((Control)(object)lsvChiTiet);
		((Control)Panel2).Controls.Add((Control)(object)GroupBox1);
		((Control)Panel2).Controls.Add((Control)(object)Panel3);
		((Control)Panel2).Dock = (DockStyle)5;
		Panel panel = Panel2;
		location = new Point(301, 0);
		((Control)panel).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel2 = Panel2;
		size = new Size(546, 456);
		((Control)panel2).Size = size;
		((Control)Panel2).TabIndex = 2;
		lsvChiTiet.BorderStyle = (BorderStyle)0;
		((Control)lsvChiTiet).Dock = (DockStyle)5;
		((Control)lsvChiTiet).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lsvChiTiet.HeaderStyle = (ColumnHeaderStyle)0;
		ListView obj5 = lsvChiTiet;
		location = new Point(0, 90);
		((Control)obj5).Location = location;
		lsvChiTiet.MultiSelect = false;
		((Control)lsvChiTiet).Name = "lsvChiTiet";
		((Control)lsvChiTiet).RightToLeft = (RightToLeft)0;
		ListView obj6 = lsvChiTiet;
		size = new Size(542, 362);
		((Control)obj6).Size = size;
		((Control)lsvChiTiet).TabIndex = 3;
		lsvChiTiet.UseCompatibleStateImageBehavior = false;
		lsvChiTiet.View = (View)1;
		((Control)GroupBox1).Dock = (DockStyle)1;
		GroupBox groupBox = GroupBox1;
		location = new Point(0, 88);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(542, 2);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 2;
		GroupBox1.TabStop = false;
		GroupBox1.Text = "GroupBox1";
		((Control)Panel3).Controls.Add((Control)(object)lblMenu);
		((Control)Panel3).Dock = (DockStyle)1;
		Panel panel3 = Panel3;
		location = new Point(0, 0);
		((Control)panel3).Location = location;
		((Control)Panel3).Name = "Panel3";
		Panel panel4 = Panel3;
		size = new Size(542, 88);
		((Control)panel4).Size = size;
		((Control)Panel3).TabIndex = 0;
		((Control)lblMenu).BackColor = SystemColors.Window;
		((Control)lblMenu).Dock = (DockStyle)5;
		((Control)lblMenu).Font = new Font("Arial", 9.75f, (FontStyle)1);
		((Control)lblMenu).ForeColor = Color.Navy;
		Label obj7 = lblMenu;
		location = new Point(0, 0);
		((Control)obj7).Location = location;
		((Control)lblMenu).Name = "lblMenu";
		Label obj8 = lblMenu;
		size = new Size(542, 88);
		((Control)obj8).Size = size;
		((Control)lblMenu).TabIndex = 2;
		lblMenu.TextAlign = (ContentAlignment)16;
		Splitter splitter = Splitter1;
		location = new Point(299, 0);
		((Control)splitter).Location = location;
		((Control)Splitter1).Name = "Splitter1";
		Splitter splitter2 = Splitter1;
		size = new Size(2, 456);
		((Control)splitter2).Size = size;
		((Control)Splitter1).TabIndex = 1;
		Splitter1.TabStop = false;
		StatusBar obj9 = stbMenu;
		location = new Point(0, 456);
		((Control)obj9).Location = location;
		((Control)stbMenu).Name = "stbMenu";
		stbMenu.ShowPanels = true;
		StatusBar obj10 = stbMenu;
		size = new Size(847, 22);
		((Control)obj10).Size = size;
		((Control)stbMenu).TabIndex = 2;
		MenuItem9.Index = 1;
		MenuItem9.Text = "-";
		imgList.ColorDepth = (ColorDepth)8;
		ImageList obj11 = imgList;
		size = new Size(22, 18);
		obj11.ImageSize = size;
		imgList.TransparentColor = Color.Transparent;
		imgTree.ColorDepth = (ColorDepth)8;
		ImageList obj12 = imgTree;
		size = new Size(22, 18);
		obj12.ImageSize = size;
		imgTree.TransparentColor = Color.Transparent;
		MnuAbout.Index = 0;
		MnuAbout.Text = "Giới thiệu";
		((Menu)MnuMain).MenuItems.AddRange((MenuItem[])(object)new MenuItem[3] { MnuSystem, mniLanguege, MnuHelp });
		MnuSystem.Index = 0;
		((Menu)MnuSystem).MenuItems.AddRange((MenuItem[])(object)new MenuItem[2] { MnuExit, MenuItem4 });
		MnuSystem.Text = "&Hệ thống";
		MnuExit.Index = 0;
		MnuExit.Text = "&Thoát";
		MenuItem4.Index = 1;
		MenuItem4.Text = "-";
		mniLanguege.Index = 1;
		mniLanguege.Text = "&Ngôn ngữ";
		MnuHelp.Index = 2;
		((Menu)MnuHelp).MenuItems.AddRange((MenuItem[])(object)new MenuItem[2] { MnuAbout, MenuItem9 });
		MnuHelp.Text = "Trợ &giúp";
		ImgNothing.ColorDepth = (ColorDepth)8;
		ImageList imgNothing = ImgNothing;
		size = new Size(1, 1);
		imgNothing.ImageSize = size;
		ImgNothing.TransparentColor = Color.Transparent;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(847, 478);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)pnMain);
		((Control)this).Controls.Add((Control)(object)stbMenu);
		((Form)this).Menu = MnuMain;
		((Control)this).Name = "frmTreeMenu";
		((Form)this).Text = "frmTreeMenu";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)pnMain).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void frmTreeMenu_Load(object sender, EventArgs e)
	{
		Getdata();
		Init_Components();
		GetData_TreeView();
		CreateLangueMenu();
	}

	private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e)
	{
		Highlight_TreeView();
		GetData_ListView();
	}

	private void lsvChiTiet_DoubleClick(object sender, EventArgs e)
	{
		Expand_TreeView();
		if (lsvChiTiet.SelectedItems.Count > 0)
		{
			if (Operators.CompareString(Strings.Mid(Conversions.ToString(lsvChiTiet.SelectedItems[0].Tag), 4, 2), "00", false) != 0)
			{
				ExecuteCommand();
			}
		}
		else
		{
			SendKeys.Send("{DOWN}");
		}
	}

	private void MnuExit_Click(object sender, EventArgs e)
	{
		Quit();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Invalid comparison between Unknown and I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Invalid comparison between Unknown and I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Invalid comparison between Unknown and I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Invalid comparison between Unknown and I4
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Invalid comparison between Unknown and I4
		if ((Operators.CompareString(((ContainerControl)this).ActiveControl.Name.ToUpper(), "LSVCHITIET", false) == 0) & (lsvChiTiet.SelectedItems.Count > 0))
		{
			if ((int)keyData == 114)
			{
				DataRow[] array = f_oTblMenu.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"menuid = '", lsvChiTiet.SelectedItems[0].Tag), (object)"'")));
				CMessageBox.Show("Menu Id: " + array[0]["menuid"].ToString().Trim() + "\r\nBar: " + array[0]["bar"].ToString().Trim() + "\r\nCode: " + array[0]["Code_Name"].ToString().Trim() + "\r\nDll: " + array[0]["dllName"].ToString().Trim() + "\r\nCommand: " + array[0]["command"].ToString().Trim() + "\r\nDeveloper: " + array[0]["Developer"].ToString().Trim(), SystemInformations.ProductFullName, (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			if ((int)keyData == 37)
			{
				SendKeys.Send("{TAB}");
				return true;
			}
			if ((int)keyData == 8)
			{
				BackSpace_Press();
				GetData_ListView();
				SendKeys.Send("{DOWN}");
				return true;
			}
			if ((int)keyData == 13)
			{
				if (Operators.ConditionalCompareObjectEqual(lsvChiTiet.SelectedItems[0].Tag, (object)"zz.zz.z1", false))
				{
					DataRow[] array2 = f_oTblMenu.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"menuid = '", lsvChiTiet.SelectedItems[0].Tag), (object)"'")));
					if (array2.Length > 0 && Operators.CompareString(Strings.Trim(Conversions.ToString(array2[0]["command"])), "", false) != 0)
					{
					}
					goto IL_048b;
				}
				Expand_TreeView();
				if (lsvChiTiet.SelectedItems.Count > 0)
				{
					if (Operators.CompareString(Strings.Mid(Conversions.ToString(lsvChiTiet.SelectedItems[0].Tag), 4, 2), "00", false) != 0)
					{
						ExecuteCommand();
					}
				}
				else
				{
					SendKeys.Send("{DOWN}");
				}
				return true;
			}
			if ((int)keyData == 123 && lsvChiTiet.SelectedItems.Count > 0)
			{
				DataRow[] array3 = f_oTblMenu.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"menuid = '", lsvChiTiet.SelectedItems[0].Tag), (object)"'")));
				if (array3.Length <= 0 || Operators.CompareString(Strings.Trim(Conversions.ToString(array3[0]["command"])), "", false) == 0)
				{
					goto IL_048b;
				}
			}
		}
		if (Operators.CompareString(((ContainerControl)this).ActiveControl.Name.ToUpper(), "TRVMENU", false) == 0 && (int)keyData == 13)
		{
			if (lsvChiTiet.Items.Count > 0)
			{
				SendKeys.Send("{TAB}");
				if (lsvChiTiet.SelectedItems.Count > 0)
				{
					lsvChiTiet.Items[lsvChiTiet.SelectedItems[0].Index].Selected = true;
				}
				else
				{
					lsvChiTiet.Items[0].Selected = true;
				}
			}
			return true;
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
		IL_048b:
		bool result = default(bool);
		return result;
	}

	private void frmMenuTest_Resize(object sender, EventArgs e)
	{
		StatusBar();
	}

	private void Init_Components()
	{
		((Form)this).Text = SystemInformations.ProductFullName;
		lsvChiTiet.Columns.Clear();
		lsvChiTiet.Columns.Add("TEN", 500, (HorizontalAlignment)0);
		LoadImage();
		trvMenu.ImageList = imgTree;
		lsvChiTiet.SmallImageList = imgList;
		StatusBar();
	}

	private void Getdata()
	{
		MainDAO mainDAO = (MainDAO)DAOFactory.CreateDAOInstance("MainDAO", "Simba", a_blnIsSysDB: true);
		f_oTblMenu = mainDAO.GetMainMenu(SystemInformations.UserName);
		mainDAO.Destroy();
		f_oTblMenu.PrimaryKey = new DataColumn[1] { f_oTblMenu.Columns["menuid"] };
	}

	private void GetData_TreeView()
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		string text = "";
		if ((SystemInformations.CurrentCultureName != null) & (Operators.CompareString(SystemInformations.CurrentCultureName, "", false) != 0))
		{
			text = SystemInformations.CurrentCultureName;
		}
		if (Operators.CompareString(text.Trim().ToLower(), "vi-vn", false) == 0)
		{
			text = "";
		}
		string columnName = "Bar" + text.Trim();
		int num = 0;
		trvMenu.Nodes.Clear();
		int num2 = f_oTblMenu.Rows.Count - 1;
		int num3 = 0;
		while (true)
		{
			int num4 = num3;
			int num5 = num2;
			if (num4 > num5)
			{
				break;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(f_oTblMenu.Rows[num3]["menuid"], (Type)null, "Substring", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (object)".00.00", false))
			{
				TreeNode val = new TreeNode();
				val.Text = Conversions.ToString(NewLateBinding.LateGet(f_oTblMenu.Rows[num3][columnName], (Type)null, "trim", new object[0], (string[])null, (Type[])null, (bool[])null));
				val.Tag = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(f_oTblMenu.Rows[num3]["menuid"], (Type)null, "trim", new object[0], (string[])null, (Type[])null, (bool[])null));
				val.ImageIndex = num;
				val.SelectedImageIndex = num + 1;
				DataRow[] array = f_oTblMenu.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"menuid like '", NewLateBinding.LateGet(f_oTblMenu.Rows[num3]["menuid"], (Type)null, "Substring", new object[2] { 0, 2 }, (string[])null, (Type[])null, (bool[])null)), (object)"%' and SubString(menuid,4,2) not like '00' "), (object)" and menuid like '%.00'")), "stt");
				if (array.Length > 0)
				{
					int num6 = array.Length - 1;
					int num7 = 0;
					while (true)
					{
						int num8 = num7;
						num5 = num6;
						if (num8 > num5)
						{
							break;
						}
						TreeNode val2 = new TreeNode();
						val2.Text = Conversions.ToString(NewLateBinding.LateGet(array[num7][columnName], (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null));
						val2.Tag = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array[num7]["menuid"], (Type)null, "trim", new object[0], (string[])null, (Type[])null, (bool[])null));
						val2.ImageIndex = f_intImgCountCap1;
						val2.SelectedImageIndex = f_intImgCountCap1 + 1;
						val.Nodes.Add(val2);
						f_intImgCountCap1 += 2;
						num7++;
					}
				}
				trvMenu.Nodes.Add(val);
				num += 2;
			}
			num3++;
		}
	}

	private void GetData_ListView()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		string text = trvMenu.SelectedNode.Text;
		foreach (TreeNode node in trvMenu.Nodes)
		{
			TreeNode val = node;
			foreach (TreeNode node2 in val.Nodes)
			{
				TreeNode val2 = node2;
				if (Operators.ConditionalCompareObjectEqual(val2.Tag, trvMenu.SelectedNode.Tag, false))
				{
					text = val.Text + " | " + text;
					break;
				}
			}
		}
		lblMenu.Text = "  " + text;
		bool flag = false;
		string text2 = Conversions.ToString(trvMenu.SelectedNode.Tag);
		DataRow[] array;
		if (Operators.CompareString(text2.Substring(2), ".00.00", false) == 0)
		{
			array = f_oTblMenu.Select("menuid like '" + text2.Substring(0, 2) + "%' and SubString(menuid,4,2) not like '00'  and menuid like '%.00'", "stt");
			flag = true;
			if (array.Length <= 0)
			{
				array = f_oTblMenu.Select("menuid like '" + text2.Substring(0, 2) + "%' and menuid not like '%00'", "stt");
				flag = false;
			}
		}
		else
		{
			array = f_oTblMenu.Select("menuid like '" + text2.Substring(0, 6) + "%' and menuid not like '%00'", "stt");
		}
		lsvChiTiet.Items.Clear();
		string text3 = "";
		if ((SystemInformations.CurrentCultureName != null) & (Operators.CompareString(SystemInformations.CurrentCultureName, "", false) != 0))
		{
			text3 = SystemInformations.CurrentCultureName;
		}
		if (Operators.CompareString(text3.Trim().ToLower(), "vi-vn", false) == 0)
		{
			text3 = "";
		}
		string text4 = "Bar" + text3.Trim();
		if (array.Length <= 0)
		{
			return;
		}
		ListViewItem val3 = new ListViewItem();
		DataRow[] array2 = f_oTblMenu.Select("menuid like '%.00' and substring(menuid,4,2) not like '00'", "stt");
		int num = array.Length - 1;
		int num2 = 0;
		while (true)
		{
			int num3 = num2;
			int num4 = num;
			if (num3 > num4)
			{
				break;
			}
			ListViewItemCollection items = lsvChiTiet.Items;
			object[] array3 = new object[1];
			DataRow[] array4 = array;
			int num5 = num2;
			DataRow obj = array4[num5];
			string columnName = text4;
			array3[0] = RuntimeHelpers.GetObjectValue(obj[columnName]);
			object[] array5 = array3;
			bool[] array6 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)items, (Type)null, "Add", array5, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				array4[num5][columnName] = RuntimeHelpers.GetObjectValue(array5[0]);
			}
			val3 = (ListViewItem)obj2;
			val3.Tag = RuntimeHelpers.GetObjectValue(array[num2]["menuid"]);
			string text5 = Conversions.ToString(array[num2]["menuid"]);
			if (flag)
			{
				lsvChiTiet.SmallImageList = imgList;
				int num6 = array2.Length - 1;
				int num7 = 0;
				while (true)
				{
					int num8 = num7;
					num4 = num6;
					if (num8 <= num4)
					{
						string text6 = Conversions.ToString(array2[num7]["menuid"]);
						if (Operators.CompareString(text6.Trim(), text5.Trim(), false) == 0)
						{
							val3.ImageIndex = num7;
							break;
						}
						num7++;
						continue;
					}
					break;
				}
			}
			else
			{
				lsvChiTiet.SmallImageList = ImgNothing;
			}
			num2++;
		}
	}

	protected virtual void StatusBar()
	{
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			stbMenu.Panels.Clear();
			stbMenu.Panels.Add(CompanyInformations.CompanyName.Trim());
			stbMenu.Panels.Add(CompanyInformations.CompanyID.Trim().ToUpper());
			stbMenu.Panels.Add(Conversions.ToString(SystemInformations.FinancialYear));
			stbMenu.Panels.Add(SystemInformations.UserName.Trim().ToUpper());
			if (((Control)this).Width > 200)
			{
				((Control)stbMenu).Width = ((Control)this).Width;
				stbMenu.Panels[0].Width = ((Control)this).Width - 200;
				stbMenu.Panels[1].Width = 50;
				stbMenu.Panels[2].Width = 50;
				stbMenu.Panels[3].Width = 100;
			}
			stbMenu.Panels[0].BorderStyle = (StatusBarPanelBorderStyle)3;
			stbMenu.Panels[1].BorderStyle = (StatusBarPanelBorderStyle)3;
			stbMenu.Panels[2].BorderStyle = (StatusBarPanelBorderStyle)3;
			stbMenu.Panels[3].BorderStyle = (StatusBarPanelBorderStyle)3;
			stbMenu.Panels[0].Alignment = (HorizontalAlignment)0;
			stbMenu.Panels[1].Alignment = (HorizontalAlignment)2;
			stbMenu.Panels[2].Alignment = (HorizontalAlignment)2;
			stbMenu.Panels[3].Alignment = (HorizontalAlignment)2;
			stbMenu.ShowPanels = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(ex2.Message, SystemInformations.ProductFullName, (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void LoadImage()
	{
		imgTree.Images.Clear();
		imgList.Images.Clear();
		DataRow[] array = f_oTblMenu.Select("menuid like '%.00.00'");
		DataRow[] array2 = array;
		foreach (DataRow dataRow in array2)
		{
			imgTree.Images.Add(Image.FromFile(SystemInformations.GraphicPath + Repl_NullPic(Conversions.ToString(dataRow["picture1"]), 0)));
			imgTree.Images.Add(Image.FromFile(SystemInformations.GraphicPath + Repl_NullPic(Conversions.ToString(dataRow["picture2"]), 1)));
		}
		f_intImgCountCap1 = imgTree.Images.Count;
		DataRow[] array3 = f_oTblMenu.Select("menuid like '%.00' and substring(menuid,4,2) not like '00'");
		DataRow[] array4 = array3;
		foreach (DataRow dataRow in array4)
		{
			imgTree.Images.Add(Image.FromFile(SystemInformations.GraphicPath + Repl_NullPic(Conversions.ToString(dataRow["picture1"]), 0)));
			imgTree.Images.Add(Image.FromFile(SystemInformations.GraphicPath + Repl_NullPic(Conversions.ToString(dataRow["picture2"]), 1)));
			imgList.Images.Add(Image.FromFile(SystemInformations.GraphicPath + Repl_NullPic(Conversions.ToString(dataRow["picture1"]), 0)));
		}
		f_intImgCountCap2 = imgTree.Images.Count;
	}

	private void LanguageMenuItem(object sender, EventArgs e)
	{
		MainDAO mainDAO = (MainDAO)DAOFactory.CreateDAOInstance("MainDAO", "Simba", a_blnIsSysDB: true);
		string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null));
		text = Strings.Right(text, 6);
		text = text.Substring(0, 5);
		mainDAO.UpdateCurrentCultureInfo(text);
		mainDAO.Destroy();
	}

	private void CreateLangueMenu()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		MainDAO mainDAO = (MainDAO)DAOFactory.CreateDAOInstance("MainDAO", "Simba", a_blnIsSysDB: true);
		DataTable cultureInfo = mainDAO.getCultureInfo();
		mainDAO.Destroy();
		((Menu)mniLanguege).MenuItems.Clear();
		foreach (DataRow row in cultureInfo.Rows)
		{
			MenuItem val = new MenuItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(row["Description"], (object)" ("), row["Name"]), (object)")")), (EventHandler)LanguageMenuItem);
			if (Operators.ConditionalCompareObjectEqual((object)SystemInformations.CurrentCultureName, row["Name"], false))
			{
				val.Checked = true;
			}
			((Menu)mniLanguege).MenuItems.Add(val);
		}
		cultureInfo.Dispose();
	}

	private void BackSpace_Press()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		if (lsvChiTiet.SelectedItems.Count <= 0)
		{
			return;
		}
		f_strIDCap2 = Strings.Left(Conversions.ToString(lsvChiTiet.SelectedItems[0].Tag), 6) + "00";
		TreeNode val = new TreeNode();
		foreach (TreeNode node in trvMenu.Nodes)
		{
			val = node;
			TreeNode val2 = new TreeNode();
			foreach (TreeNode node2 in val.Nodes)
			{
				val2 = node2;
				if (Operators.ConditionalCompareObjectEqual(val2.Tag, (object)f_strIDCap2, false))
				{
					val.Collapse();
					trvMenu.SelectedNode = val;
					break;
				}
			}
		}
	}

	private void Expand_TreeView()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (lsvChiTiet.SelectedItems.Count <= 0)
		{
			return;
		}
		string text = Conversions.ToString(lsvChiTiet.SelectedItems[0].Tag);
		TreeNode val = new TreeNode();
		foreach (TreeNode node in trvMenu.Nodes)
		{
			val = node;
			TreeNode val2 = new TreeNode();
			foreach (TreeNode node2 in val.Nodes)
			{
				val2 = node2;
				if (Operators.ConditionalCompareObjectEqual(val2.Tag, (object)text, false))
				{
					val.Expand();
					trvMenu.SelectedNode = val2;
					break;
				}
			}
		}
	}

	private void Highlight_TreeView()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		TreeNode val = new TreeNode();
		Color backColor = default(Color);
		foreach (TreeNode node in trvMenu.Nodes)
		{
			val = node;
			val.BackColor = backColor;
			TreeNode val2 = new TreeNode();
			foreach (TreeNode node2 in val.Nodes)
			{
				val2 = node2;
				val2.BackColor = backColor;
			}
		}
		trvMenu.SelectedNode.BackColor = Color.LightGray;
	}

	private void ExecuteCommand()
	{
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		DataRow dataRow = f_oTblMenu.Rows.Find(RuntimeHelpers.GetObjectValue(lsvChiTiet.SelectedItems[0].Tag));
		string text = dataRow["Command"].ToString().Trim();
		if (Operators.CompareString(text.Trim(), "", false) == 0)
		{
			return;
		}
		if (!Commons.ChkExecRight(Conversions.ToString(dataRow["MenuID"])))
		{
			CMessageBox.Show(50005);
			return;
		}
		try
		{
			if (Operators.ConditionalCompareObjectEqual(dataRow["FORM"], (object)"1", false))
			{
				Form val = get_GetMyForm(Conversions.ToString(dataRow["MenuID"]), text, Conversions.ToString(dataRow["DllName"]));
				if (val != null)
				{
					((Control)val).Show();
					((Control)val).BringToFront();
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(dataRow["FORM"], (object)"9", false))
			{
				Quit();
			}
			else
			{
				Process.Start(text);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)(ex2.Message + "\r\n" + ex2.StackTrace), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private string Repl_NullPic(string strPic, int PicType)
	{
		if (Operators.CompareString(strPic, "", false) == 0)
		{
			return PicType switch
			{
				0 => "Folder.bmp", 
				1 => "FolderO.bmp", 
				_ => "", 
			};
		}
		return strPic.Trim();
	}

	private void Quit()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		if ((int)CMessageBox.Show("Bạn có muốn thoát khỏi chương trình?", SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256) == 6)
		{
			((Form)this).Close();
		}
	}
}
