using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using AsiaErp.Framework.Docking;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmT2ModuleMenu : DockContent
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("FlowPanelMenu")]
	private asFlowPanel _FlowPanelMenu;

	[AccessedThroughProperty("imgListModule")]
	private ImageList _imgListModule;

	[AccessedThroughProperty("imgListDetail")]
	private ImageList _imgListDetail;

	private ArrayList MenuInfo;

	internal Panel panelDetailMenus;

	internal Label lblCurrentModule;

	private Hashtable f_FormCollection;

	private Font DETAIL_MENU_FONT;

	private Font DETAIL_MENU_FONT_SELECTED;

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

	private const string DEFAULT_IMAGE = "detail.png";

	private readonly short X_COLUMN2;

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
			_FlowPanelMenu = value;
		}
	}

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

	public frmT2ModuleMenu()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		((Form)this).Load += FrmModuleMenu_Load;
		__ENCAddToList(this);
		DETAIL_MENU_FONT = new Font(FontFamily.GenericSansSerif, 10f, (FontStyle)0);
		DETAIL_MENU_FONT_SELECTED = new Font(FontFamily.GenericSansSerif, 10f, (FontStyle)1);
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
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmT2ModuleMenu));
		FlowPanelMenu = new asFlowPanel();
		imgListModule = new ImageList(components);
		imgListDetail = new ImageList(components);
		((Control)this).SuspendLayout();
		((Control)FlowPanelMenu).BackColor = Color.FromArgb(241, 245, 250);
		((Control)FlowPanelMenu).Dock = (DockStyle)5;
		FlowPanelMenu.DoubleBuffered = false;
		((FlowLayoutPanel)FlowPanelMenu).FlowDirection = (FlowDirection)1;
		((Control)FlowPanelMenu).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		asFlowPanel flowPanelMenu = FlowPanelMenu;
		Point location = new Point(0, 0);
		((Control)flowPanelMenu).Location = location;
		asFlowPanel flowPanelMenu2 = FlowPanelMenu;
		Padding val = default(Padding);
		((Padding)(ref val))._002Ector(0);
		((Control)flowPanelMenu2).Margin = val;
		((Control)FlowPanelMenu).Name = "FlowPanelMenu";
		asFlowPanel flowPanelMenu3 = FlowPanelMenu;
		((Padding)(ref val))._002Ector(1);
		((Control)flowPanelMenu3).Padding = val;
		asFlowPanel flowPanelMenu4 = FlowPanelMenu;
		Size size = new Size(250, 708);
		((Control)flowPanelMenu4).Size = size;
		((Control)FlowPanelMenu).TabIndex = 1;
		((FlowLayoutPanel)FlowPanelMenu).WrapContents = false;
		imgListModule.ColorDepth = (ColorDepth)32;
		ImageList obj = imgListModule;
		size = new Size(32, 32);
		obj.ImageSize = size;
		imgListModule.TransparentColor = Color.Transparent;
		imgListDetail.ColorDepth = (ColorDepth)32;
		ImageList obj2 = imgListDetail;
		size = new Size(32, 32);
		obj2.ImageSize = size;
		imgListDetail.TransparentColor = Color.Transparent;
		AllowEndUserDocking = false;
		AutoHidePortion = 0.1;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)0;
		((Form)this).AutoScroll = true;
		((Form)this).BackColor = Color.FromArgb(241, 245, 250);
		((Control)this).CausesValidation = false;
		size = new Size(250, 708);
		((Form)this).ClientSize = size;
		CloseButton = false;
		CloseButtonVisible = false;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)FlowPanelMenu);
		DockAreas = DockAreas.DockLeft;
		((Control)this).DoubleBuffered = true;
		((Control)this).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Padding)(ref val))._002Ector(5, 4, 5, 4);
		((Form)this).Margin = val;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FrmModuleMenu";
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).SizeGripStyle = (SizeGripStyle)2;
		((Form)this).StartPosition = (FormStartPosition)0;
		TabText = "";
		((Form)this).Text = "PHÂN HỆ";
		((Control)this).ResumeLayout(false);
	}

	private void FrmModuleMenu_Load(object sender, EventArgs e)
	{
		GetMenuByUserID(SystemInformation.UserName);
		getResource();
		CreateModulesPanel();
	}

	private void getResource()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
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
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		AutoHidePortion = num;
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
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((Control)FlowPanelMenu).SuspendLayout();
		IOrderedEnumerable<MenuInformation> source = from object mnu in MenuInfo
			select (MenuInformation)mnu into mnu
			where mnu.stt.EndsWith("00.00")
			select (mnu) into mnu
			orderby mnu.stt
			select mnu;
		string[] array = (from mnu in source
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
			}
			else
			{
				imgListModule.Images.Add(array[num2], Image.FromFile(SystemInformations.GraphicPath + "detail.png"));
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
				imgListDetail.Images.Add(array2[num6], Image.FromFile(SystemInformations.GraphicPath + "detail.png"));
			}
			num6++;
		}
		int num8 = 23;
		Button[] array3 = (Button[])(object)new Button[source.Count() - 1 + 1];
		int num9 = source.Count() - 1;
		int num10 = 0;
		Padding val2 = default(Padding);
		while (true)
		{
			int num11 = num10;
			int num12 = num9;
			if (num11 > num12)
			{
				break;
			}
			array3[num10] = new Button();
			Button val = array3[num10];
			((Control)val).Font = MODULE_MENU_FONT;
			((ButtonBase)val).FlatStyle = (FlatStyle)0;
			((ButtonBase)val).FlatAppearance.BorderSize = 0;
			((ButtonBase)val).FlatAppearance.MouseDownBackColor = MODULE_MENU_BACK_COLOR;
			((ButtonBase)val).FlatAppearance.MouseOverBackColor = MODULE_MENU_BACK_COLOR;
			((Control)val).ForeColor = MODULE_MENU_FORE_COLOR;
			((ButtonBase)val).Text = Strings.Space(1) + source.ElementAtOrDefault(num10).bar;
			((Control)val).Tag = source.ElementAtOrDefault(num10);
			((ButtonBase)val).AutoSize = true;
			((Control)val).Width = ((Control)FlowPanelMenu).Width - 2;
			((Control)val).Dock = (DockStyle)1;
			((ButtonBase)val).TextAlign = (ContentAlignment)16;
			((ButtonBase)val).ImageAlign = (ContentAlignment)16;
			Button obj = val;
			((Padding)(ref val2))._002Ector(0, 0, 0, 0);
			((Control)obj).Padding = val2;
			Button obj2 = val;
			((Padding)(ref val2))._002Ector(0, 0, 0, 0);
			((Control)obj2).Margin = val2;
			((ButtonBase)val).TextImageRelation = (TextImageRelation)4;
			((ButtonBase)val).Image = imgListModule.Images[source.ElementAtOrDefault(num10).picture1];
			((Control)val).Click += ModuleButton_Clicked;
			((Control)val).Paint += new PaintEventHandler(ModuleButton_PaintTopAndBottom);
			((Control)val).KeyDown += new KeyEventHandler(ModuleButton_KeyDown);
			val = null;
			num10++;
		}
		((Control)FlowPanelMenu).BackColor = LEFT_MENU_BACK_COLOR;
		((Control)FlowPanelMenu).Controls.AddRange((Control[])(object)array3);
		array3[0].PerformClick();
		((Control)FlowPanelMenu).ResumeLayout();
		((Control)this).ResumeLayout();
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

	private void ModuleButton_Clicked(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected O, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected O, but got Unknown
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
		lblCurrentModule.Text = ((ButtonBase)val).Text;
		((ScrollProperties)((ScrollableControl)panelDetailMenus).VerticalScroll).Value = 0;
		((Control)this).SuspendLayout();
		((Control)panelDetailMenus).SuspendLayout();
		((Control)panelDetailMenus).Controls.Clear();
		((ButtonBase)val).BackColor = MODULE_MENU_BACK_COLOR;
		((Control)val).ForeColor = MODULE_MENU_SELECTED_FORE_COLOR;
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
			return;
		}
		IOrderedEnumerable<MenuInformation> source2 = from object mnu in MenuInfo
			select (MenuInformation)mnu into mnu
			where (Operators.CompareString(mnu.stt.Substring(0, 2), ((MenuInformation)((Control)val).Tag).stt.Substring(0, 2), false) == 0 && Operators.CompareString(mnu.stt, ((MenuInformation)((Control)val).Tag).stt, false) != 0 && source.Count() == 0 && Operators.CompareString(mnu.bar.ToString().Trim(), string.Empty, false) != 0) ? true : false
			select (mnu) into mnu
			orderby mnu.stt
			select mnu;
		int num = 10;
		int num2 = 10;
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
			_Closure_0024__5._Closure_0024__6 closure_0024__ = default(_Closure_0024__5._Closure_0024__6);
			while (true)
			{
				byte num4 = b6;
				byte b4 = b5;
				if ((uint)num4 > (uint)b4)
				{
					break;
				}
				closure_0024__ = new _Closure_0024__5._Closure_0024__6(closure_0024__);
				num2 += 5;
				PictureBox val3 = new PictureBox();
				val3.Image = imgListDetail.Images[source.ElementAtOrDefault(b6).picture1];
				((Control)val3).Size = imgListDetail.Images[source.ElementAtOrDefault(b6).picture1].Size;
				Point location = new Point(num, num2 - 5);
				((Control)val3).Location = location;
				((Control)panelDetailMenus).Controls.Add((Control)(object)val3);
				closure_0024__._0024VB_0024Local_subMenu = new LinkLabel();
				((Label)closure_0024__._0024VB_0024Local_subMenu).AutoSize = true;
				closure_0024__._0024VB_0024Local_subMenu.Text = source.ElementAtOrDefault(b6).bar;
				((Control)closure_0024__._0024VB_0024Local_subMenu).Tag = source.ElementAtOrDefault(b6);
				((Control)closure_0024__._0024VB_0024Local_subMenu).Font = SUB_MENU_FONT;
				closure_0024__._0024VB_0024Local_subMenu.LinkBehavior = (LinkBehavior)2;
				closure_0024__._0024VB_0024Local_subMenu.LinkColor = SUB_MENU_FORE_COLOR;
				LinkLabel obj4 = closure_0024__._0024VB_0024Local_subMenu;
				location = new Point(num + ((Control)val3).Width + 10, num2);
				((Control)obj4).Location = location;
				((Label)closure_0024__._0024VB_0024Local_subMenu).ImageAlign = (ContentAlignment)16;
				((Label)closure_0024__._0024VB_0024Local_subMenu).TextAlign = (ContentAlignment)16;
				((Control)panelDetailMenus).Controls.Add((Control)(object)closure_0024__._0024VB_0024Local_subMenu);
				source2 = from mnu in (from object mnu in MenuInfo
						select (MenuInformation)mnu).Where(closure_0024__._Lambda_0024__146)
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

	private void ShowProperties(object sender, EventArgs e)
	{
	}

	private void ShowMenuInfo(MenuInformation mnu)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		frmObjectProperty frmObjectProperty = new frmObjectProperty();
		MenuInformation menuInformation = new MenuInformation();
		PropertyInfo[] properties = typeof(MenuInformation).GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			propertyInfo.SetValue(menuInformation, RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(mnu, null)), null);
		}
		frmObjectProperty.pgColumnInfo.SelectedObject = menuInformation;
		((Form)frmObjectProperty).ShowDialog();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
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
}
