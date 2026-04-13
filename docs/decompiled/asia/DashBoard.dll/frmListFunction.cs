using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmListFunction : frmAsiaRoot
{
	public delegate void LabelSort_ClickEventHandler(object sender, EventArgs e);

	public delegate void LabelAdd_ClickEventHandler(object sender, EventArgs e);

	public delegate void LabelRemove_ClickEventHandler(object sender, EventArgs e);

	private IContainer components;

	[AccessedThroughProperty("pnlChuc_nang")]
	private asFlowPanel _pnlChuc_nang;

	internal int f_Type;

	internal int f_DashID;

	internal string f_StoreProcedure;

	private DataTable Data;

	private ImageList ImgListDetail;

	private LinkLabel lblTarget;

	private const short PADDING_LEFT = 30;

	private const short ITEM_HEIGHT = 30;

	private const string DEFAULT_IMAGE = "detail_icon.gif";

	private Font MODULE_MENU_FONT;

	private Font SUB_MENU_FONT;

	private Font DETAIL_MENU_FONT;

	private Color MODULE_MENU_SELECTED_FORE_COLOR;

	private Color MODULE_MENU_BACK_COLOR;

	private Color MODULE_MENU_FORE_COLOR;

	private Color SUB_MENU_FORE_COLOR;

	private Color DETAIL_MENU_FORE_COLOR;

	private Color GRADIENT_COLOR;

	private readonly short X_COLUMN2;

	internal virtual asFlowPanel pnlChuc_nang
	{
		get
		{
			return _pnlChuc_nang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pnlChuc_nang = value;
		}
	}

	public event LabelSort_ClickEventHandler LabelSort_Click;

	public event LabelAdd_ClickEventHandler LabelAdd_Click;

	public event LabelRemove_ClickEventHandler LabelRemove_Click;

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
			base.Dispose(disposing);
		}
	}

	public frmListFunction(ImageList imageLisDetail)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		((Form)this).Load += frmListFunction_Load;
		Data = new DataTable();
		lblTarget = new LinkLabel();
		MODULE_MENU_FONT = new Font(FontFamily.GenericSansSerif, 13f, (FontStyle)1);
		SUB_MENU_FONT = new Font(FontFamily.GenericSansSerif, 12f, (FontStyle)1);
		DETAIL_MENU_FONT = new Font(FontFamily.GenericSansSerif, 10f, (FontStyle)0);
		MODULE_MENU_SELECTED_FORE_COLOR = Color.DarkBlue;
		MODULE_MENU_BACK_COLOR = Color.Cornsilk;
		MODULE_MENU_FORE_COLOR = Color.Blue;
		SUB_MENU_FORE_COLOR = Color.DarkGreen;
		DETAIL_MENU_FORE_COLOR = Color.Black;
		GRADIENT_COLOR = Color.FromArgb(175, 196, 224);
		X_COLUMN2 = Conversions.ToShort(ConfigurationManager.AppSettings["X_COLUMN2"]);
		InitializeComponent();
		ImgListDetail = imageLisDetail;
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		pnlChuc_nang = new asFlowPanel();
		((Control)this).SuspendLayout();
		((Control)pnlChuc_nang).Anchor = (AnchorStyles)15;
		((ScrollableControl)pnlChuc_nang).AutoScroll = true;
		((Control)pnlChuc_nang).BackColor = SystemColors.ControlLightLight;
		pnlChuc_nang.DoubleBuffered = false;
		asFlowPanel obj = pnlChuc_nang;
		Point location = new Point(12, 12);
		((Control)obj).Location = location;
		((Control)pnlChuc_nang).Name = "pnlChuc_nang";
		asFlowPanel obj2 = pnlChuc_nang;
		Size size = new Size(552, 440);
		((Control)obj2).Size = size;
		((Control)pnlChuc_nang).TabIndex = 1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(576, 464);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)pnlChuc_nang);
		((Control)this).Name = "frmListFunction";
		((Form)this).ShowInTaskbar = false;
		((Form)this).Text = "Danh sách chức năng";
		((Control)this).ResumeLayout(false);
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void frmListFunction_Load(object sender, EventArgs e)
	{
		((Control)Application.OpenForms["frmDetailMenu"]).Cursor = Cursors.WaitCursor;
		LoadData();
		((Control)Application.OpenForms["frmDetailMenu"]).Cursor = Cursors.Default;
	}

	private void Mouse_Down(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		LinkLabel val = (LinkLabel)sender;
		((Control)val).DoDragDrop((object)val, (DragDropEffects)1);
	}

	private void Drag_Enter(object sender, DragEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		LinkLabel val = (LinkLabel)sender;
		e.Effect = (DragDropEffects)1;
		lblTarget.LinkColor = DETAIL_MENU_FORE_COLOR;
		val.LinkColor = SUB_MENU_FORE_COLOR;
		lblTarget = val;
	}

	private void Drag_Drop(object sender, DragEventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		LinkLabel val = (LinkLabel)e.Data.GetData(typeof(LinkLabel));
		DataRow dataRow = (DataRow)((Control)val).Tag;
		DataRow dataRow2 = (DataRow)((Control)lblTarget).Tag;
		if (Operators.ConditionalCompareObjectEqual(dataRow["menuid"], dataRow2["menuid"], false))
		{
			return;
		}
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		int num = dashBoardDAO.SortMenuFrequence(Conversions.ToString(dataRow["menuid"]), Conversions.ToInteger(dataRow2["Stt"]), f_DashID);
		dashBoardDAO.Destroy();
		if (num != 0)
		{
			CMessageBox.Show(num);
			return;
		}
		if (Operators.CompareString(f_StoreProcedure, "", false) == 0)
		{
			Data = GetDataBySp("asGetDashFrequentlyFunction", f_DashID, IsSys: true);
		}
		else
		{
			Data = GetDataBySp(f_StoreProcedure, f_DashID);
		}
		CreateLabelSort();
		LabelSort_Click?.Invoke(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
	}

	private void DetailLink_MouseCLick(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		LinkLabel val = (LinkLabel)sender;
		DataRow dataRow = (DataRow)((Control)val).Tag;
		string text = Conversions.ToString(dataRow["menuid"]);
		string text2 = Conversions.ToString(dataRow["bar"]);
		if (!(text.EndsWith(".00") | (Operators.CompareString(text2.Trim(), "", false) == 0)))
		{
			if (f_Type == 1)
			{
				LabelAdd_Click?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (f_Type == 2)
			{
				LabelRemove_Click?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
			}
			Data.Rows.Remove(dataRow);
			((Control)pnlChuc_nang).Controls.Remove((Control)(object)val);
		}
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

	private void LoadData()
	{
		DashBoardDAO dashBoardDAO = (DashBoardDAO)DAOFactory.CreateDAOInstance("DashBoardDAO", "DashBoard", a_blnIsSysDB: true);
		switch (f_Type)
		{
		case 1:
			Data = dashBoardDAO.GetDashMenu(f_DashID);
			CreateLinkMenu();
			break;
		case 2:
			Data = dashBoardDAO.GetMenuFrequence(f_DashID);
			CreateLinkMenu();
			break;
		case 3:
			Data = dashBoardDAO.GetMenuFrequence(f_DashID);
			CreateLabelSort();
			break;
		}
		dashBoardDAO.Destroy();
	}

	private void CreateLinkMenu()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		Point location = new Point(10, 20);
		checked
		{
			Padding padding = default(Padding);
			foreach (DataRow row in Data.Rows)
			{
				LinkLabel val = new LinkLabel();
				((Control)val).Width = ((Control)pnlChuc_nang).Width - 100;
				val.Text = Conversions.ToString(row["bar"]);
				((Control)val).Tag = row;
				((Label)val).ImageAlign = (ContentAlignment)16;
				((Label)val).TextAlign = (ContentAlignment)16;
				val.LinkBehavior = (LinkBehavior)2;
				((Padding)(ref padding))._002Ector(30, 0, 0, 0);
				val.Padding = padding;
				object obj = row["level"];
				if (Operators.ConditionalCompareObjectEqual(obj, (object)1, false))
				{
					((Control)val).Height = 30;
					val.LinkColor = MODULE_MENU_FORE_COLOR;
					((Control)val).Font = MODULE_MENU_FONT;
				}
				else if (Operators.ConditionalCompareObjectEqual(obj, (object)2, false))
				{
					((Control)val).Height = 30;
					val.LinkColor = SUB_MENU_FORE_COLOR;
					((Control)val).Font = SUB_MENU_FONT;
					location.X += 30;
				}
				else if (Operators.ConditionalCompareObjectEqual(obj, (object)3, false))
				{
					((Label)val).Image = (Image)NewLateBinding.LateGet((object)ImgListDetail.Images, (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(row["picture1"]) }, (string[])null, (Type[])null, (bool[])null);
					((Control)val).Height = 30;
					val.LinkColor = DETAIL_MENU_FORE_COLOR;
					((Control)val).Font = DETAIL_MENU_FONT;
					location.X += 60;
				}
				((Control)val).Location = location;
				((Control)val).MouseClick += new MouseEventHandler(DetailLink_MouseCLick);
				((Control)pnlChuc_nang).Controls.Add((Control)(object)val);
				location.Y += 10;
				location.Y += 30;
			}
		}
	}

	private void CreateLabelSort()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		((Control)pnlChuc_nang).Controls.Clear();
		DataRowCollection rows = Data.Rows;
		int count = rows.Count;
		Point location = new Point(10, 10);
		checked
		{
			int num = count - 1;
			Padding padding = default(Padding);
			for (int i = 0; i <= num; i++)
			{
				LinkLabel val = new LinkLabel();
				((Control)val).Width = ((Control)pnlChuc_nang).Width - 100;
				((Control)val).AllowDrop = true;
				val.Text = Conversions.ToString(rows[i]["bar"]);
				((Control)val).Tag = rows[i];
				((Label)val).Image = (Image)NewLateBinding.LateGet((object)ImgListDetail.Images, (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(rows[i]["picture1"]) }, (string[])null, (Type[])null, (bool[])null);
				((Label)val).ImageAlign = (ContentAlignment)16;
				((Label)val).TextAlign = (ContentAlignment)16;
				val.LinkColor = Color.Black;
				val.LinkBehavior = (LinkBehavior)3;
				((Control)val).Font = DETAIL_MENU_FONT;
				((Padding)(ref padding))._002Ector(30, 0, 0, 0);
				val.Padding = padding;
				((Control)val).Location = location;
				((Control)val).MouseDown += new MouseEventHandler(Mouse_Down);
				((Control)val).DragEnter += new DragEventHandler(Drag_Enter);
				((Control)val).DragDrop += new DragEventHandler(Drag_Drop);
				((Control)pnlChuc_nang).Controls.Add((Control)(object)val);
				location.Y += 25;
			}
		}
	}

	protected override void OnClosed(EventArgs e)
	{
		Data = new DataTable();
		((Form)this).OnClosed(e);
	}
}
