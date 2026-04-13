using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using AsiaErp.Framework.Docking;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmDashBoard : DockContent
{
	private IContainer components;

	[AccessedThroughProperty("panel")]
	private asPanel _panel;

	[AccessedThroughProperty("RightMenu")]
	private ContextMenuStrip _RightMenu;

	[AccessedThroughProperty("mnuThem_moi")]
	private ToolStripMenuItem _mnuThem_moi;

	[AccessedThroughProperty("mnuLam_tuoi")]
	private ToolStripMenuItem _mnuLam_tuoi;

	public static int iMdX = 400;

	public static bool bLoading = true;

	private DataTable DashletInfo;

	public DockPanel MyDockPanel;

	public ImageList imgListDetail;

	[AccessedThroughProperty("frmCreateDashlet")]
	private frmCreateDashlet _frmCreateDashlet;

	public static int mWidth;

	public static int mHeight;

	public static int dWidth;

	public static int dHeight;

	public static int maxLWidth;

	public static int maxRWidth;

	public static int cSpace = 30;

	public static int lSpace = 15;

	private bool dlDown;

	private bool dlLock;

	private frmDashlet dlTarget;

	private int dlLocation;

	private int tmPoint;

	internal virtual asPanel panel
	{
		get
		{
			return _panel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_panel = value;
		}
	}

	internal virtual ContextMenuStrip RightMenu
	{
		get
		{
			return _RightMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RightMenu = value;
		}
	}

	internal virtual ToolStripMenuItem mnuThem_moi
	{
		get
		{
			return _mnuThem_moi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = InsertDash_Click;
			if (_mnuThem_moi != null)
			{
				((ToolStripItem)_mnuThem_moi).Click -= eventHandler;
			}
			_mnuThem_moi = value;
			if (_mnuThem_moi != null)
			{
				((ToolStripItem)_mnuThem_moi).Click += eventHandler;
			}
		}
	}

	internal virtual ToolStripMenuItem mnuLam_tuoi
	{
		get
		{
			return _mnuLam_tuoi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = RefreshDash_Click;
			if (_mnuLam_tuoi != null)
			{
				((ToolStripItem)_mnuLam_tuoi).Click -= eventHandler;
			}
			_mnuLam_tuoi = value;
			if (_mnuLam_tuoi != null)
			{
				((ToolStripItem)_mnuLam_tuoi).Click += eventHandler;
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

	public frmDashBoard()
	{
		((Form)this).Load += frmDashBoard_Load;
		((Control)this).Resize += frmDashBoard_Resize;
		((Form)this).Shown += frmDashBoard_Shown;
		dlDown = false;
		dlLock = false;
		InitializeComponent();
	}

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
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		components = new Container();
		RightMenu = new ContextMenuStrip(components);
		mnuThem_moi = new ToolStripMenuItem();
		mnuLam_tuoi = new ToolStripMenuItem();
		panel = new asPanel();
		((Control)RightMenu).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)RightMenu).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)mnuThem_moi,
			(ToolStripItem)mnuLam_tuoi
		});
		((Control)RightMenu).Name = "RightMenu";
		ContextMenuStrip rightMenu = RightMenu;
		Size size = new Size(207, 48);
		((Control)rightMenu).Size = size;
		((ToolStripItem)mnuThem_moi).Name = "mnuThem_moi";
		ToolStripMenuItem obj = mnuThem_moi;
		size = new Size(206, 22);
		((ToolStripItem)obj).Size = size;
		((ToolStripItem)mnuThem_moi).Text = "Thêm mới màn hình con";
		((ToolStripItem)mnuLam_tuoi).Name = "mnuLam_tuoi";
		ToolStripMenuItem obj2 = mnuLam_tuoi;
		size = new Size(206, 22);
		((ToolStripItem)obj2).Size = size;
		((ToolStripItem)mnuLam_tuoi).Text = "Làm tươi dữ liệu";
		((ScrollableControl)panel).AutoScroll = true;
		((Control)panel).BackColor = SystemColors.ButtonHighlight;
		((Control)panel).ContextMenuStrip = RightMenu;
		((Control)panel).Dock = (DockStyle)5;
		panel.DoubleBuffered = false;
		asPanel obj3 = panel;
		Point location = new Point(0, 0);
		((Control)obj3).Location = location;
		((Control)panel).Name = "panel";
		asPanel obj4 = panel;
		size = new Size(632, 490);
		((Control)obj4).Size = size;
		((Control)panel).TabIndex = 0;
		((Control)this).AllowDrop = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = SystemColors.ActiveBorder;
		size = new Size(632, 490);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)panel);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmDashBoard";
		((Control)RightMenu).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void LoadDashletForm()
	{
		GetMaxDashPoint();
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		DashletInfo = dashBoardDAO.GetDashForm();
		dashBoardDAO.Destroy();
		((Control)panel).Controls.Clear();
		checked
		{
			if (DashletInfo != null)
			{
				dlLock = true;
				int num = DashletInfo.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					AddDashletForm(Conversions.ToInteger(DashletInfo.Rows[i]["DashID"]));
				}
				dlLock = false;
			}
		}
	}

	private void MovDashletForm()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		GetMaxDashPoint();
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		DashletInfo = dashBoardDAO.GetDashForm();
		dashBoardDAO.Destroy();
		if (DashletInfo == null)
		{
			((Control)panel).Controls.Clear();
			return;
		}
		Point location = new Point(lSpace, lSpace);
		dlLock = true;
		checked
		{
			int num = DashletInfo.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				foreach (Control control in ((Control)panel).Controls)
				{
					Control val = control;
					frmDashlet frmDashlet2 = (frmDashlet)(object)val;
					if (Operators.ConditionalCompareObjectEqual(frmDashlet2.f_Row["DashID"], DashletInfo.Rows[i]["DashID"], false))
					{
						if (Operators.ConditionalCompareObjectEqual(DashletInfo.Rows[i]["location"], (object)2, false))
						{
							location.X = GetWidth(1) + lSpace + cSpace;
						}
						else
						{
							location.X = lSpace;
						}
						location.Y = Conversions.ToInteger(DashletInfo.Rows[i]["Y"]);
						((Control)frmDashlet2).Height = Conversions.ToInteger(DashletInfo.Rows[i]["H"]);
						((Control)frmDashlet2).Width = Conversions.ToInteger(DashletInfo.Rows[i]["W"]);
						((Control)frmDashlet2).Location = location;
						frmDashlet2.f_Row = DashletInfo.Rows[i];
						((Control)panel).Controls.SetChildIndex((Control)(object)frmDashlet2, i);
					}
				}
			}
			dlLock = false;
		}
	}

	private void AddDashletForm(int DashID)
	{
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		DataTable dashForm = dashBoardDAO.GetDashForm(Conversions.ToString(DashID));
		dashBoardDAO.Destroy();
		if (dashForm != null)
		{
			dlLock = true;
			Point location = new Point(lSpace, lSpace);
			frmDashlet frmDashlet2 = new frmDashlet(imgListDetail, dashForm.Rows[0]);
			((Control)frmDashlet2).Height = Conversions.ToInteger(dashForm.Rows[0]["H"]);
			((Control)frmDashlet2).Width = Conversions.ToInteger(dashForm.Rows[0]["W"]);
			location.X = Conversions.ToInteger(dashForm.Rows[0]["X"]);
			location.Y = Conversions.ToInteger(dashForm.Rows[0]["Y"]);
			((Control)frmDashlet2).Location = location;
			frmDashlet2.FinishMoveDashlet += FinishMoveDashlet;
			frmDashlet2.FinishResizeDashlet += FinishResizeDashlet;
			frmDashlet2.UpdateDash_Click += UpdateDash_Click;
			((Control)panel).Controls.Add((Control)(object)frmDashlet2);
			dlLock = false;
		}
	}

	private void UpdDashletForm(int DashID)
	{
	}

	private void GetMaxDashPoint()
	{
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		DataTable maxDashPoint = dashBoardDAO.GetMaxDashPoint(0);
		dashBoardDAO.Destroy();
		maxLWidth = Conversions.ToInteger(maxDashPoint.Rows[0][1]);
		maxRWidth = Conversions.ToInteger(maxDashPoint.Rows[0][2]);
	}

	public static int GetWidth(int location)
	{
		int result = 0;
		switch (location)
		{
		case 0:
			result = checked((!((maxLWidth == 0) & (maxRWidth == 0))) ? ((maxLWidth != 0) ? ((maxRWidth != 0) ? (maxLWidth + maxRWidth + cSpace) : (dWidth + maxLWidth + cSpace)) : (dWidth + maxRWidth + cSpace)) : (2 * (dWidth + lSpace)));
			break;
		case 1:
			result = ((maxLWidth != 0) ? maxLWidth : dWidth);
			break;
		case 2:
			result = ((maxRWidth != 0) ? maxRWidth : dWidth);
			break;
		}
		return result;
	}

	private void MoveInitDashlet(frmDashlet dlSrc, Point mPoint, ResizeableControl rcT)
	{
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a51: Expected O, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		if (dlLock)
		{
			return;
		}
		Point location = new Point(lSpace, lSpace);
		int num = lSpace;
		int num2 = lSpace;
		int num3 = lSpace;
		bool flag = false;
		bool flag2 = false;
		checked
		{
			if (mPoint.Y < lSpace + cSpace)
			{
				if (Operators.ConditionalCompareObjectEqual(dlSrc.f_Row["location"], (object)0, false))
				{
					num = ((Control)dlSrc).Height + lSpace + lSpace;
				}
				else
				{
					switch (dlLocation)
					{
					case 1:
						num2 = ((Control)dlSrc).Height + lSpace + lSpace;
						break;
					case 2:
						num3 = ((Control)dlSrc).Height + lSpace + lSpace;
						break;
					}
				}
				flag2 = true;
				dlDown = false;
			}
			else
			{
				location.Y = lSpace;
				flag2 = false;
				dlDown = true;
			}
			if (!Operators.ConditionalCompareObjectEqual(dlSrc.f_Row["location"], (object)0, false))
			{
				foreach (Control control in ((Control)panel).Controls)
				{
					Control val = control;
					frmDashlet frmDashlet2 = (frmDashlet)(object)val;
					if (Operators.ConditionalCompareObjectEqual(frmDashlet2.f_Row["DashID"], dlSrc.f_Row["DashID"], false))
					{
						continue;
					}
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(frmDashlet2.f_Row["location"], (object)0, false), Operators.CompareObjectEqual(frmDashlet2.f_Row["location"], (object)1, false))))
					{
						location.X = lSpace;
					}
					else
					{
						location.X = GetWidth(1) + lSpace + cSpace;
					}
					if (flag2)
					{
						num = ((Control)dlSrc).Height + lSpace + lSpace;
						flag2 = false;
					}
					object obj = frmDashlet2.f_Row["location"];
					if (Operators.ConditionalCompareObjectEqual(obj, (object)0, false))
					{
						int num4 = 0;
						num4 = Math.Max(num2, num3);
						num = (location.Y = Math.Max(num, num4));
						((Control)frmDashlet2).Location = location;
						num += ((Control)frmDashlet2).Height + lSpace;
						num2 = Math.Max(num, num2);
						num3 = Math.Max(num, num3);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)1, false))
					{
						location.Y = num2;
						((Control)frmDashlet2).Location = location;
						num2 += ((Control)frmDashlet2).Height + lSpace;
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)2, false))
					{
						location.Y = num3;
						((Control)frmDashlet2).Location = location;
						num3 += ((Control)frmDashlet2).Height + lSpace;
					}
					int num6 = ((Control)frmDashlet2).Location.X + GetWidth(Conversions.ToInteger(frmDashlet2.f_Row["location"])) + lSpace;
					int num7 = ((Control)frmDashlet2).Location.Y + ((Control)frmDashlet2).Height + ((Control)dlSrc).Height;
					if ((mPoint.X > ((Control)frmDashlet2).Location.X - lSpace) & (mPoint.X <= num6) & (mPoint.Y >= ((Control)frmDashlet2).Location.Y + cSpace) & (mPoint.Y < num7))
					{
						dlTarget = frmDashlet2;
						object obj2 = frmDashlet2.f_Row["location"];
						if (Operators.ConditionalCompareObjectEqual(obj2, (object)0, false))
						{
							num += ((Control)dlSrc).Height + lSpace;
							if (dlLocation == 1)
							{
								num2 = Math.Max(num, num2);
							}
							else
							{
								num3 = Math.Max(num, num3);
							}
						}
						else if (Operators.ConditionalCompareObjectEqual(obj2, (object)1, false))
						{
							num2 += ((Control)dlSrc).Height + lSpace;
						}
						else if (Operators.ConditionalCompareObjectEqual(obj2, (object)2, false))
						{
							num3 += ((Control)dlSrc).Height + lSpace;
						}
						flag = true;
					}
					else if (!flag)
					{
						dlTarget = frmDashlet2;
					}
				}
			}
			else
			{
				bool flag3 = true;
				int num8 = 0;
				if (mPoint.Y <= tmPoint)
				{
					foreach (Control control2 in ((Control)panel).Controls)
					{
						Control val2 = control2;
						frmDashlet frmDashlet2 = (frmDashlet)(object)val2;
						if (Operators.ConditionalCompareObjectEqual(frmDashlet2.f_Row["DashID"], dlSrc.f_Row["DashID"], false))
						{
							continue;
						}
						if (((Control)frmDashlet2).Location.Y <= ((Control)dlSrc).Location.Y)
						{
							object obj3 = frmDashlet2.f_Row["location"];
							if (Operators.ConditionalCompareObjectEqual(obj3, (object)1, false))
							{
								num2 = ((Control)frmDashlet2).Location.Y + ((Control)frmDashlet2).Height + lSpace;
								continue;
							}
							if (Operators.ConditionalCompareObjectEqual(obj3, (object)2, false))
							{
								num3 = ((Control)frmDashlet2).Location.Y + ((Control)frmDashlet2).Height + lSpace;
								continue;
							}
							num2 = ((Control)frmDashlet2).Location.Y + ((Control)frmDashlet2).Height + lSpace;
							num3 = ((Control)frmDashlet2).Location.Y + ((Control)frmDashlet2).Height + lSpace;
							continue;
						}
						if (flag3)
						{
							dlSrc.f_Row["Y"] = Math.Max(num2, num3);
							num2 = Conversions.ToInteger(Operators.AddObject(Operators.AddObject(dlSrc.f_Row["Y"], (object)((Control)dlSrc).Height), (object)lSpace));
							num3 = Conversions.ToInteger(Operators.AddObject(Operators.AddObject(dlSrc.f_Row["Y"], (object)((Control)dlSrc).Height), (object)lSpace));
							flag3 = false;
						}
						if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(frmDashlet2.f_Row["location"], (object)0, false), Operators.CompareObjectEqual(frmDashlet2.f_Row["location"], (object)1, false))))
						{
							location.X = lSpace;
						}
						else
						{
							location.X = GetWidth(1) + lSpace + cSpace;
						}
						object obj4 = frmDashlet2.f_Row["location"];
						if (Operators.ConditionalCompareObjectEqual(obj4, (object)0, false))
						{
							location.Y = Math.Max(num2, num3);
							((Control)frmDashlet2).Location = location;
							num2 += ((Control)frmDashlet2).Height + lSpace;
							num3 += ((Control)frmDashlet2).Height + lSpace;
						}
						else if (Operators.ConditionalCompareObjectEqual(obj4, (object)1, false))
						{
							location.Y = num2;
							((Control)frmDashlet2).Location = location;
							num2 += ((Control)frmDashlet2).Height + lSpace;
						}
						else if (Operators.ConditionalCompareObjectEqual(obj4, (object)2, false))
						{
							location.Y = num3;
							((Control)frmDashlet2).Location = location;
							num3 += ((Control)frmDashlet2).Height + lSpace;
						}
					}
				}
				else
				{
					ArrayList arrayList = new ArrayList();
					Rectangle rectangle = new Rectangle(((Control)dlSrc).Location.X, ((Control)dlSrc).Location.Y, ((Control)dlSrc).Width, cSpace);
					foreach (Control control3 in ((Control)panel).Controls)
					{
						Control val3 = control3;
						frmDashlet frmDashlet3 = (frmDashlet)(object)val3;
						if (!Operators.ConditionalCompareObjectEqual(frmDashlet3.f_Row["DashID"], dlSrc.f_Row["DashID"], false))
						{
							Rectangle rect = new Rectangle(((Control)frmDashlet3).Location.X, ((Control)frmDashlet3).Location.Y, ((Control)frmDashlet3).Width, cSpace);
							if (rectangle.IntersectsWith(rect))
							{
								arrayList.Add(RuntimeHelpers.GetObjectValue(frmDashlet3.f_Row["DashID"]));
							}
						}
					}
					if (arrayList.Count == 0)
					{
						return;
					}
					flag3 = false;
					foreach (Control control4 in ((Control)panel).Controls)
					{
						Control val4 = control4;
						frmDashlet frmDashlet2 = (frmDashlet)(object)val4;
						if (Operators.ConditionalCompareObjectEqual(frmDashlet2.f_Row["DashID"], dlSrc.f_Row["DashID"], false))
						{
							continue;
						}
						if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(frmDashlet2.f_Row["location"], (object)0, false), Operators.CompareObjectEqual(frmDashlet2.f_Row["location"], (object)1, false))))
						{
							location.X = lSpace;
						}
						else
						{
							location.X = GetWidth(1) + lSpace + cSpace;
						}
						if (arrayList.Contains(RuntimeHelpers.GetObjectValue(frmDashlet2.f_Row["DashID"])))
						{
							object obj5 = frmDashlet2.f_Row["location"];
							if (Operators.ConditionalCompareObjectEqual(obj5, (object)0, false))
							{
								location.Y = Conversions.ToInteger(dlSrc.f_Row["Y"]);
								((Control)frmDashlet2).Location = location;
								DataRow f_Row = dlSrc.f_Row;
								string columnName = "Y";
								f_Row[columnName] = Operators.AddObject(f_Row[columnName], (object)(((Control)frmDashlet2).Height + lSpace));
								num2 = Conversions.ToInteger(Operators.AddObject(Operators.AddObject(dlSrc.f_Row["Y"], (object)((Control)dlSrc).Height), (object)lSpace));
								num3 = Conversions.ToInteger(Operators.AddObject(Operators.AddObject(dlSrc.f_Row["Y"], (object)((Control)dlSrc).Height), (object)lSpace));
							}
							else if (Operators.ConditionalCompareObjectEqual(obj5, (object)1, false))
							{
								location.Y = Conversions.ToInteger(dlSrc.f_Row["Y"]);
								((Control)frmDashlet2).Location = location;
								num2 = Conversions.ToInteger(Operators.AddObject(Operators.AddObject(dlSrc.f_Row["Y"], (object)((Control)frmDashlet2).Height), (object)lSpace));
								flag3 = true;
							}
							else if (Operators.ConditionalCompareObjectEqual(obj5, (object)2, false))
							{
								location.Y = Conversions.ToInteger(dlSrc.f_Row["Y"]);
								((Control)frmDashlet2).Location = location;
								num3 = Conversions.ToInteger(Operators.AddObject(Operators.AddObject(dlSrc.f_Row["Y"], (object)((Control)frmDashlet2).Height), (object)lSpace));
								flag3 = true;
							}
							continue;
						}
						if (flag3)
						{
							dlSrc.f_Row["Y"] = Math.Max(num2, num3);
							num2 = Conversions.ToInteger(Operators.AddObject(Operators.AddObject(dlSrc.f_Row["Y"], (object)((Control)dlSrc).Height), (object)lSpace));
							num3 = Conversions.ToInteger(Operators.AddObject(Operators.AddObject(dlSrc.f_Row["Y"], (object)((Control)dlSrc).Height), (object)lSpace));
							flag3 = false;
						}
						object obj6 = frmDashlet2.f_Row["location"];
						if (Operators.ConditionalCompareObjectEqual(obj6, (object)0, false))
						{
							location.Y = Math.Max(num2, num3);
							((Control)frmDashlet2).Location = location;
							num2 += ((Control)frmDashlet2).Height + lSpace;
							num3 += ((Control)frmDashlet2).Height + lSpace;
						}
						else if (Operators.ConditionalCompareObjectEqual(obj6, (object)1, false))
						{
							location.Y = num2;
							((Control)frmDashlet2).Location = location;
							num2 += ((Control)frmDashlet2).Height + lSpace;
						}
						else if (Operators.ConditionalCompareObjectEqual(obj6, (object)2, false))
						{
							location.Y = num3;
							((Control)frmDashlet2).Location = location;
							num3 += ((Control)frmDashlet2).Height + lSpace;
						}
					}
					if (flag3)
					{
						dlSrc.f_Row["Y"] = Math.Max(num2, num3);
						num2 = Conversions.ToInteger(Operators.AddObject(Operators.AddObject(dlSrc.f_Row["Y"], (object)((Control)dlSrc).Height), (object)lSpace));
						num3 = Conversions.ToInteger(Operators.AddObject(Operators.AddObject(dlSrc.f_Row["Y"], (object)((Control)dlSrc).Height), (object)lSpace));
					}
				}
				tmPoint = mPoint.Y;
			}
			if (!flag)
			{
				dlTarget = dlSrc;
			}
		}
	}

	private void FinishMove(frmDashlet dlSrc, frmDashlet dlTar)
	{
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		int num = dashBoardDAO.UpdDashLocation(Conversions.ToInteger(dlSrc.f_Row["DashID"]), Conversions.ToInteger(dlSrc.f_Row["location"]), ((Control)dlSrc).Location.X, ((Control)dlSrc).Location.Y, ((Control)dlSrc).Height, ((Control)dlSrc).Width);
		dashBoardDAO.Destroy();
	}

	private void ResizeInitDashlet(frmDashlet dlSrc, ResizeableControl rcT)
	{
		switch (rcT.GetCursorStatusEnum())
		{
		case 1:
		case 2:
		case 5:
		case 6:
			return;
		}
		int val = lSpace;
		int num = lSpace;
		int val2 = lSpace;
		checked
		{
			switch (rcT.GetCursorStatusEnum())
			{
			case 2:
				if (((Control)dlSrc).Width > GetWidth(2) + cSpace)
				{
					dlSrc.f_Row["location"] = 0;
				}
				else if (Operators.ConditionalCompareObjectEqual(dlSrc.f_Row["location"], (object)0, false))
				{
					dlSrc.f_Row["location"] = 2;
				}
				break;
			case 1:
				if (((Control)dlSrc).Width > GetWidth(1) + cSpace)
				{
					dlSrc.f_Row["location"] = 0;
				}
				else if (Operators.ConditionalCompareObjectEqual(dlSrc.f_Row["location"], (object)0, false))
				{
					dlSrc.f_Row["location"] = 1;
				}
				break;
			case 6:
				if (((Control)dlSrc).Width > GetWidth(2) + cSpace)
				{
					dlSrc.f_Row["location"] = 0;
				}
				else if (Operators.ConditionalCompareObjectEqual(dlSrc.f_Row["location"], (object)0, false))
				{
					dlSrc.f_Row["location"] = 2;
				}
				break;
			case 7:
				if (((Control)dlSrc).Width > GetWidth(1) + cSpace)
				{
					dlSrc.f_Row["location"] = 0;
				}
				else if (Operators.ConditionalCompareObjectEqual(dlSrc.f_Row["location"], (object)0, false))
				{
					dlSrc.f_Row["location"] = 1;
				}
				break;
			}
			Point location = new Point(lSpace, lSpace);
			foreach (object control in ((Control)panel).Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				frmDashlet frmDashlet2 = (frmDashlet)objectValue;
				if (Operators.ConditionalCompareObjectEqual(frmDashlet2.f_Row["DashID"], dlSrc.f_Row["DashID"], false))
				{
					location.X = ((Control)dlSrc).Location.X;
					object obj = frmDashlet2.f_Row["location"];
					if (Operators.ConditionalCompareObjectEqual(obj, (object)0, false))
					{
						int num2 = 0;
						num2 = Math.Max(num, val2);
						val = (location.Y = Math.Max(val, num2));
						((Control)frmDashlet2).Location = location;
						val += ((Control)frmDashlet2).Height + lSpace;
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)1, false))
					{
						num = (location.Y = Math.Max(val, num));
						((Control)frmDashlet2).Location = location;
						num += ((Control)frmDashlet2).Height + lSpace;
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)2, false))
					{
						val2 = (location.Y = Math.Max(val, val2));
						((Control)frmDashlet2).Location = location;
						val2 += ((Control)frmDashlet2).Height + lSpace;
					}
					continue;
				}
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(frmDashlet2.f_Row["location"], (object)0, false), Operators.CompareObjectEqual(frmDashlet2.f_Row["location"], (object)1, false))))
				{
					location.X = lSpace;
				}
				else
				{
					location.X = maxLWidth + lSpace + cSpace;
				}
				object obj2 = frmDashlet2.f_Row["location"];
				if (Operators.ConditionalCompareObjectEqual(obj2, (object)0, false))
				{
					int num6 = 0;
					num6 = Math.Max(num, val2);
					val = (location.Y = Math.Max(val, num6));
					((Control)frmDashlet2).Location = location;
					val += ((Control)frmDashlet2).Height + lSpace;
				}
				else if (Operators.ConditionalCompareObjectEqual(obj2, (object)1, false))
				{
					num = (location.Y = Math.Max(val, num));
					((Control)frmDashlet2).Location = location;
					num += ((Control)frmDashlet2).Height + lSpace;
				}
				else if (Operators.ConditionalCompareObjectEqual(obj2, (object)2, false))
				{
					val2 = (location.Y = Math.Max(val, val2));
					((Control)frmDashlet2).Location = location;
					val2 += ((Control)frmDashlet2).Height + lSpace;
				}
			}
		}
	}

	private void FinishResize(frmDashlet dlSrc, ResizeableControl rcT)
	{
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		int num = dashBoardDAO.UpdDashLocation(Conversions.ToInteger(dlSrc.f_Row["DashID"]), Conversions.ToInteger(dlSrc.f_Row["location"]), ((Control)dlSrc).Location.X, ((Control)dlSrc).Location.Y, ((Control)dlSrc).Height, ((Control)dlSrc).Width);
		dashBoardDAO.Destroy();
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
					arrayList.Add(valueParameter.Rows[i]["paraname"].ToString());
					arrayList.Add(valueParameter.Rows[i]["paravalue"].ToString());
				}
				dataTable = dashBoardDAO.ProcessSPDashBoard(arrayList.ToArray());
			}
			dashBoardDAO.Destroy();
			return dataTable;
		}
	}

	private void MoveDashlet(object sender, ResizeableControl rcT)
	{
		checked
		{
			if (!(bLoading | (DashletInfo == null)))
			{
				GetMaxDashPoint();
				frmDashlet frmDashlet2 = (frmDashlet)sender;
				Point location = rcT.GetLocation(2);
				location.X += ((Control)frmDashlet2).Location.X;
				location.Y += ((Control)frmDashlet2).Location.Y;
				if ((location.X > 0) & (location.X <= GetWidth(1) + cSpace))
				{
					dlLocation = 1;
				}
				else
				{
					dlLocation = 2;
				}
				MoveInitDashlet(frmDashlet2, location, rcT);
			}
		}
	}

	private void FinishMoveDashlet(object sender, ResizeableControl rcT)
	{
		frmDashlet dlSrc = (frmDashlet)sender;
		FinishMove(dlSrc, dlTarget);
	}

	private void ResizeDashlet(object sender, ResizeableControl rcT)
	{
		if (!(bLoading | (DashletInfo == null)))
		{
			frmDashlet dlSrc = (frmDashlet)sender;
			GetMaxDashPoint();
			ResizeInitDashlet(dlSrc, rcT);
		}
	}

	private void FinishResizeDashlet(object sender, ResizeableControl rcT)
	{
		frmDashlet dlSrc = (frmDashlet)sender;
		FinishResize(dlSrc, rcT);
	}

	private void RefreshDash_Click(object sender, EventArgs e)
	{
		LoadDashletForm();
	}

	private void InsertDash_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		frmCreateDashlet = new frmCreateDashlet(EditMode: false);
		((Form)frmCreateDashlet).ShowDialog((IWin32Window)(object)this);
		if (frmCreateDashlet.f_IsEdit)
		{
			AddDashletForm(frmCreateDashlet.DashID);
		}
	}

	private void UpdateDash_Click(object sender, EventArgs e)
	{
		int dashID = Conversions.ToInteger(sender);
		UpdDashletForm(dashID);
	}

	protected override void OnCreateControl()
	{
		((Form)this).OnCreateControl();
		if (!((Component)(object)this).DesignMode)
		{
			((ToolStripItem)mnuThem_moi).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_CONTEXTMENU_ADD_TEXT");
			((ToolStripItem)mnuLam_tuoi).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#DASHBOARD_CONTEXTMENU_REFRESH_TEXT");
		}
	}

	private void frmDashBoard_Load(object sender, EventArgs e)
	{
		bLoading = false;
		iMdX = checked((int)Math.Round((double)((Control)this).Width / 2.0));
	}

	private void frmDashBoard_Resize(object sender, EventArgs e)
	{
		mWidth = ((Control)this).Width;
		mHeight = ((Control)this).Height;
		checked
		{
			dWidth = (int)Math.Round((double)(mWidth - 75) / 2.0);
			dHeight = (int)Math.Round((double)(mHeight - 20) / 2.0);
		}
	}

	private void frmDashBoard_Shown(object sender, EventArgs e)
	{
		if (imgListDetail != null)
		{
			LoadDashletForm();
		}
	}
}
