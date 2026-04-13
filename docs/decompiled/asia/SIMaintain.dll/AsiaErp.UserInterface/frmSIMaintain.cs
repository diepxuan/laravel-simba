using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSIMaintain : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("LinkLabel8")]
	private LinkLabel _LinkLabel8;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("lblKhai_bao_tu_dong_sao_luu")]
	private LinkLabel _lblKhai_bao_tu_dong_sao_luu;

	[AccessedThroughProperty("LinkLabel5")]
	private LinkLabel _LinkLabel5;

	[AccessedThroughProperty("lblSao_lu_du_lieu")]
	private LinkLabel _lblSao_lu_du_lieu;

	[AccessedThroughProperty("lblKiem_tra_chenh_lech")]
	private LinkLabel _lblKiem_tra_chenh_lech;

	[AccessedThroughProperty("lblKiem_tra_hoach_toan")]
	private LinkLabel _lblKiem_tra_hoach_toan;

	[AccessedThroughProperty("lblLoai_bo_dau_trang")]
	private LinkLabel _lblLoai_bo_dau_trang;

	[AccessedThroughProperty("lblDanh_lai_chi_muc")]
	private LinkLabel _lblDanh_lai_chi_muc;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("LinkLabel3")]
	private LinkLabel _LinkLabel3;

	[AccessedThroughProperty("LinkLabel4")]
	private LinkLabel _LinkLabel4;

	[AccessedThroughProperty("LinkLabel6")]
	private LinkLabel _LinkLabel6;

	[AccessedThroughProperty("LinkLabel2")]
	private LinkLabel _LinkLabel2;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	internal virtual Panel Panel2
	{
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual LinkLabel LinkLabel8
	{
		get
		{
			return _LinkLabel8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LinkLabel8 = value;
		}
	}

	internal virtual Panel Panel1
	{
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual LinkLabel lblKhai_bao_tu_dong_sao_luu
	{
		get
		{
			return _lblKhai_bao_tu_dong_sao_luu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(llblfun6_LinkClicked);
			if (_lblKhai_bao_tu_dong_sao_luu != null)
			{
				_lblKhai_bao_tu_dong_sao_luu.LinkClicked -= val;
			}
			_lblKhai_bao_tu_dong_sao_luu = value;
			if (_lblKhai_bao_tu_dong_sao_luu != null)
			{
				_lblKhai_bao_tu_dong_sao_luu.LinkClicked += val;
			}
		}
	}

	internal virtual LinkLabel LinkLabel5
	{
		get
		{
			return _LinkLabel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LinkLabel5 = value;
		}
	}

	internal virtual LinkLabel lblSao_lu_du_lieu
	{
		get
		{
			return _lblSao_lu_du_lieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(llblfun5_LinkClicked);
			if (_lblSao_lu_du_lieu != null)
			{
				_lblSao_lu_du_lieu.LinkClicked -= val;
			}
			_lblSao_lu_du_lieu = value;
			if (_lblSao_lu_du_lieu != null)
			{
				_lblSao_lu_du_lieu.LinkClicked += val;
			}
		}
	}

	internal virtual LinkLabel lblKiem_tra_chenh_lech
	{
		get
		{
			return _lblKiem_tra_chenh_lech;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(llblfun4_LinkClicked);
			if (_lblKiem_tra_chenh_lech != null)
			{
				_lblKiem_tra_chenh_lech.LinkClicked -= val;
			}
			_lblKiem_tra_chenh_lech = value;
			if (_lblKiem_tra_chenh_lech != null)
			{
				_lblKiem_tra_chenh_lech.LinkClicked += val;
			}
		}
	}

	internal virtual LinkLabel lblKiem_tra_hoach_toan
	{
		get
		{
			return _lblKiem_tra_hoach_toan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(llblfun3_LinkClicked);
			if (_lblKiem_tra_hoach_toan != null)
			{
				_lblKiem_tra_hoach_toan.LinkClicked -= val;
			}
			_lblKiem_tra_hoach_toan = value;
			if (_lblKiem_tra_hoach_toan != null)
			{
				_lblKiem_tra_hoach_toan.LinkClicked += val;
			}
		}
	}

	internal virtual LinkLabel lblLoai_bo_dau_trang
	{
		get
		{
			return _lblLoai_bo_dau_trang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(llblfun2_LinkClicked);
			if (_lblLoai_bo_dau_trang != null)
			{
				_lblLoai_bo_dau_trang.LinkClicked -= val;
			}
			_lblLoai_bo_dau_trang = value;
			if (_lblLoai_bo_dau_trang != null)
			{
				_lblLoai_bo_dau_trang.LinkClicked += val;
			}
		}
	}

	internal virtual LinkLabel lblDanh_lai_chi_muc
	{
		get
		{
			return _lblDanh_lai_chi_muc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(llblfun1_LinkClicked);
			if (_lblDanh_lai_chi_muc != null)
			{
				_lblDanh_lai_chi_muc.LinkClicked -= val;
			}
			_lblDanh_lai_chi_muc = value;
			if (_lblDanh_lai_chi_muc != null)
			{
				_lblDanh_lai_chi_muc.LinkClicked += val;
			}
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual LinkLabel LinkLabel3
	{
		get
		{
			return _LinkLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LinkLabel3 = value;
		}
	}

	internal virtual LinkLabel LinkLabel4
	{
		get
		{
			return _LinkLabel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LinkLabel4 = value;
		}
	}

	internal virtual LinkLabel LinkLabel6
	{
		get
		{
			return _LinkLabel6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LinkLabel6 = value;
		}
	}

	internal virtual LinkLabel LinkLabel2
	{
		get
		{
			return _LinkLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LinkLabel2 = value;
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LinkLabel1 = value;
		}
	}

	public frmSIMaintain(string MenuID)
		: base(MenuID)
	{
		((Form)this).Load += frmSIMaintain_Load;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected O, but got Unknown
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected O, but got Unknown
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected O, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected O, but got Unknown
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected O, but got Unknown
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected O, but got Unknown
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a39: Expected O, but got Unknown
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected O, but got Unknown
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected O, but got Unknown
		//IL_0ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb2: Expected O, but got Unknown
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d82: Expected O, but got Unknown
		//IL_0e94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9e: Expected O, but got Unknown
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebb: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSIMaintain));
		Panel2 = new Panel();
		Label1 = new Label();
		LinkLabel8 = new LinkLabel();
		Panel1 = new Panel();
		LinkLabel3 = new LinkLabel();
		LinkLabel4 = new LinkLabel();
		LinkLabel6 = new LinkLabel();
		LinkLabel2 = new LinkLabel();
		LinkLabel1 = new LinkLabel();
		lblKhai_bao_tu_dong_sao_luu = new LinkLabel();
		LinkLabel5 = new LinkLabel();
		lblSao_lu_du_lieu = new LinkLabel();
		lblKiem_tra_chenh_lech = new LinkLabel();
		lblKiem_tra_hoach_toan = new LinkLabel();
		lblLoai_bo_dau_trang = new LinkLabel();
		lblDanh_lai_chi_muc = new LinkLabel();
		((Control)Panel2).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel2).BackColor = SystemColors.Window;
		((Control)Panel2).Controls.Add((Control)(object)Label1);
		((Control)Panel2).Controls.Add((Control)(object)LinkLabel8);
		((Control)Panel2).Dock = (DockStyle)1;
		((Control)Panel2).ForeColor = Color.ForestGreen;
		Panel panel = Panel2;
		Point location = new Point(0, 0);
		((Control)panel).Location = location;
		Panel panel2 = Panel2;
		Padding val = default(Padding);
		((Padding)(ref val))._002Ector(1);
		((Control)panel2).Margin = val;
		((Control)Panel2).Name = "Panel2";
		Panel panel3 = Panel2;
		Size size = new Size(448, 32);
		((Control)panel3).Size = size;
		((Control)Panel2).TabIndex = 16;
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		location = new Point(63, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(160, 17);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 17;
		Label1.Text = "Danh mục chức năng";
		((Control)LinkLabel8).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel8).Image = (Image)componentResourceManager.GetObject("LinkLabel8.Image");
		((Label)LinkLabel8).ImageAlign = (ContentAlignment)16;
		LinkLabel8.LinkBehavior = (LinkBehavior)2;
		LinkLabel8.LinkColor = Color.Black;
		LinkLabel linkLabel = LinkLabel8;
		location = new Point(7, 0);
		((Control)linkLabel).Location = location;
		((Control)LinkLabel8).Name = "LinkLabel8";
		LinkLabel linkLabel2 = LinkLabel8;
		size = new Size(37, 29);
		((Control)linkLabel2).Size = size;
		((Control)LinkLabel8).TabIndex = 16;
		((Control)Panel1).BackColor = SystemColors.Window;
		Panel1.BorderStyle = (BorderStyle)2;
		((Control)Panel1).Controls.Add((Control)(object)LinkLabel3);
		((Control)Panel1).Controls.Add((Control)(object)LinkLabel4);
		((Control)Panel1).Controls.Add((Control)(object)LinkLabel6);
		((Control)Panel1).Controls.Add((Control)(object)LinkLabel2);
		((Control)Panel1).Controls.Add((Control)(object)LinkLabel1);
		((Control)Panel1).Controls.Add((Control)(object)lblKhai_bao_tu_dong_sao_luu);
		((Control)Panel1).Controls.Add((Control)(object)LinkLabel5);
		((Control)Panel1).Controls.Add((Control)(object)lblSao_lu_du_lieu);
		((Control)Panel1).Controls.Add((Control)(object)lblKiem_tra_chenh_lech);
		((Control)Panel1).Controls.Add((Control)(object)lblKiem_tra_hoach_toan);
		((Control)Panel1).Controls.Add((Control)(object)lblLoai_bo_dau_trang);
		((Control)Panel1).Controls.Add((Control)(object)lblDanh_lai_chi_muc);
		((Control)Panel1).Dock = (DockStyle)5;
		((Control)Panel1).ForeColor = SystemColors.ControlText;
		Panel panel4 = Panel1;
		location = new Point(0, 32);
		((Control)panel4).Location = location;
		Panel panel5 = Panel1;
		((Padding)(ref val))._002Ector(1);
		((Control)panel5).Margin = val;
		((Control)Panel1).Name = "Panel1";
		Panel panel6 = Panel1;
		size = new Size(448, 265);
		((Control)panel6).Size = size;
		((Control)Panel1).TabIndex = 17;
		((Control)LinkLabel3).BackColor = Color.Transparent;
		((Control)LinkLabel3).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel3).Image = (Image)componentResourceManager.GetObject("LinkLabel3.Image");
		((Label)LinkLabel3).ImageAlign = (ContentAlignment)16;
		LinkLabel3.LinkBehavior = (LinkBehavior)2;
		LinkLabel3.LinkColor = Color.Black;
		LinkLabel linkLabel3 = LinkLabel3;
		location = new Point(61, 151);
		((Control)linkLabel3).Location = location;
		((Control)LinkLabel3).Name = "LinkLabel3";
		LinkLabel linkLabel4 = LinkLabel3;
		size = new Size(33, 20);
		((Control)linkLabel4).Size = size;
		((Control)LinkLabel3).TabIndex = 40;
		((Control)LinkLabel3).Visible = false;
		((Control)LinkLabel4).BackColor = Color.Transparent;
		((Control)LinkLabel4).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel4).Image = (Image)componentResourceManager.GetObject("LinkLabel4.Image");
		((Label)LinkLabel4).ImageAlign = (ContentAlignment)16;
		LinkLabel4.LinkBehavior = (LinkBehavior)2;
		LinkLabel4.LinkColor = Color.Black;
		LinkLabel linkLabel5 = LinkLabel4;
		location = new Point(61, 124);
		((Control)linkLabel5).Location = location;
		((Control)LinkLabel4).Name = "LinkLabel4";
		LinkLabel linkLabel6 = LinkLabel4;
		size = new Size(33, 20);
		((Control)linkLabel6).Size = size;
		((Control)LinkLabel4).TabIndex = 39;
		((Control)LinkLabel4).Visible = false;
		((Control)LinkLabel6).BackColor = Color.Transparent;
		((Control)LinkLabel6).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel6).Image = (Image)componentResourceManager.GetObject("LinkLabel6.Image");
		((Label)LinkLabel6).ImageAlign = (ContentAlignment)16;
		LinkLabel6.LinkBehavior = (LinkBehavior)2;
		LinkLabel6.LinkColor = Color.Black;
		LinkLabel linkLabel7 = LinkLabel6;
		location = new Point(61, 97);
		((Control)linkLabel7).Location = location;
		((Control)LinkLabel6).Name = "LinkLabel6";
		LinkLabel linkLabel8 = LinkLabel6;
		size = new Size(33, 20);
		((Control)linkLabel8).Size = size;
		((Control)LinkLabel6).TabIndex = 38;
		((Control)LinkLabel2).BackColor = Color.Transparent;
		((Control)LinkLabel2).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel2).Image = (Image)componentResourceManager.GetObject("LinkLabel2.Image");
		((Label)LinkLabel2).ImageAlign = (ContentAlignment)16;
		LinkLabel2.LinkBehavior = (LinkBehavior)2;
		LinkLabel2.LinkColor = Color.Black;
		LinkLabel linkLabel9 = LinkLabel2;
		location = new Point(61, 70);
		((Control)linkLabel9).Location = location;
		((Control)LinkLabel2).Name = "LinkLabel2";
		LinkLabel linkLabel10 = LinkLabel2;
		size = new Size(33, 20);
		((Control)linkLabel10).Size = size;
		((Control)LinkLabel2).TabIndex = 37;
		((Control)LinkLabel1).BackColor = Color.Transparent;
		((Control)LinkLabel1).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel1).Image = (Image)componentResourceManager.GetObject("LinkLabel1.Image");
		((Label)LinkLabel1).ImageAlign = (ContentAlignment)16;
		LinkLabel1.LinkBehavior = (LinkBehavior)2;
		LinkLabel1.LinkColor = Color.Black;
		LinkLabel linkLabel11 = LinkLabel1;
		location = new Point(61, 43);
		((Control)linkLabel11).Location = location;
		((Control)LinkLabel1).Name = "LinkLabel1";
		LinkLabel linkLabel12 = LinkLabel1;
		size = new Size(33, 20);
		((Control)linkLabel12).Size = size;
		((Control)LinkLabel1).TabIndex = 36;
		((Label)lblKhai_bao_tu_dong_sao_luu).AutoSize = true;
		((Control)lblKhai_bao_tu_dong_sao_luu).BackColor = Color.Transparent;
		((Control)lblKhai_bao_tu_dong_sao_luu).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Label)lblKhai_bao_tu_dong_sao_luu).ImageAlign = (ContentAlignment)256;
		lblKhai_bao_tu_dong_sao_luu.LinkBehavior = (LinkBehavior)2;
		lblKhai_bao_tu_dong_sao_luu.LinkColor = Color.Black;
		LinkLabel obj = lblKhai_bao_tu_dong_sao_luu;
		location = new Point(99, 151);
		((Control)obj).Location = location;
		((Control)lblKhai_bao_tu_dong_sao_luu).Name = "lblKhai_bao_tu_dong_sao_luu";
		LinkLabel obj2 = lblKhai_bao_tu_dong_sao_luu;
		size = new Size(212, 17);
		((Control)obj2).Size = size;
		((Control)lblKhai_bao_tu_dong_sao_luu).TabIndex = 35;
		((Label)lblKhai_bao_tu_dong_sao_luu).TabStop = true;
		lblKhai_bao_tu_dong_sao_luu.Text = "Khai báo tự động sao lưu dữ liệu";
		((Control)lblKhai_bao_tu_dong_sao_luu).Visible = false;
		((Control)LinkLabel5).BackColor = Color.Transparent;
		((Control)LinkLabel5).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel5).Image = (Image)componentResourceManager.GetObject("LinkLabel5.Image");
		((Label)LinkLabel5).ImageAlign = (ContentAlignment)16;
		LinkLabel5.LinkBehavior = (LinkBehavior)2;
		LinkLabel5.LinkColor = Color.Black;
		LinkLabel linkLabel13 = LinkLabel5;
		location = new Point(61, 16);
		((Control)linkLabel13).Location = location;
		LinkLabel linkLabel14 = LinkLabel5;
		((Padding)(ref val))._002Ector(1);
		((Control)linkLabel14).Margin = val;
		((Control)LinkLabel5).Name = "LinkLabel5";
		LinkLabel linkLabel15 = LinkLabel5;
		((Padding)(ref val))._002Ector(3);
		linkLabel15.Padding = val;
		LinkLabel linkLabel16 = LinkLabel5;
		size = new Size(33, 20);
		((Control)linkLabel16).Size = size;
		((Control)LinkLabel5).TabIndex = 30;
		((Label)lblSao_lu_du_lieu).AutoSize = true;
		((Control)lblSao_lu_du_lieu).BackColor = Color.Transparent;
		((Control)lblSao_lu_du_lieu).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Label)lblSao_lu_du_lieu).ImageAlign = (ContentAlignment)256;
		lblSao_lu_du_lieu.LinkBehavior = (LinkBehavior)2;
		lblSao_lu_du_lieu.LinkColor = Color.Black;
		LinkLabel obj3 = lblSao_lu_du_lieu;
		location = new Point(99, 124);
		((Control)obj3).Location = location;
		((Control)lblSao_lu_du_lieu).Name = "lblSao_lu_du_lieu";
		LinkLabel obj4 = lblSao_lu_du_lieu;
		size = new Size(102, 17);
		((Control)obj4).Size = size;
		((Control)lblSao_lu_du_lieu).TabIndex = 29;
		((Label)lblSao_lu_du_lieu).TabStop = true;
		lblSao_lu_du_lieu.Text = "Sao lưu dữ liệu";
		((Control)lblSao_lu_du_lieu).Visible = false;
		((Label)lblKiem_tra_chenh_lech).AutoSize = true;
		((Control)lblKiem_tra_chenh_lech).BackColor = Color.Transparent;
		((Control)lblKiem_tra_chenh_lech).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Label)lblKiem_tra_chenh_lech).ImageAlign = (ContentAlignment)256;
		lblKiem_tra_chenh_lech.LinkBehavior = (LinkBehavior)2;
		lblKiem_tra_chenh_lech.LinkColor = Color.Black;
		LinkLabel obj5 = lblKiem_tra_chenh_lech;
		location = new Point(99, 97);
		((Control)obj5).Location = location;
		((Control)lblKiem_tra_chenh_lech).Name = "lblKiem_tra_chenh_lech";
		LinkLabel obj6 = lblKiem_tra_chenh_lech;
		size = new Size(267, 17);
		((Control)obj6).Size = size;
		((Control)lblKiem_tra_chenh_lech).TabIndex = 28;
		((Label)lblKiem_tra_chenh_lech).TabStop = true;
		lblKiem_tra_chenh_lech.Text = "Kiểm tra lệch giữa các sổ (Kế toán - Kho)";
		((Label)lblKiem_tra_hoach_toan).AutoSize = true;
		((Control)lblKiem_tra_hoach_toan).BackColor = Color.Transparent;
		((Control)lblKiem_tra_hoach_toan).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Label)lblKiem_tra_hoach_toan).ImageAlign = (ContentAlignment)256;
		lblKiem_tra_hoach_toan.LinkBehavior = (LinkBehavior)2;
		lblKiem_tra_hoach_toan.LinkColor = Color.Black;
		LinkLabel obj7 = lblKiem_tra_hoach_toan;
		location = new Point(99, 70);
		((Control)obj7).Location = location;
		((Control)lblKiem_tra_hoach_toan).Name = "lblKiem_tra_hoach_toan";
		LinkLabel obj8 = lblKiem_tra_hoach_toan;
		size = new Size(276, 17);
		((Control)obj8).Size = size;
		((Control)lblKiem_tra_hoach_toan).TabIndex = 27;
		((Label)lblKiem_tra_hoach_toan).TabStop = true;
		lblKiem_tra_hoach_toan.Text = "Kiểm tra hạch toán vào tài khoản tổng hợp";
		((Label)lblLoai_bo_dau_trang).AutoSize = true;
		((Control)lblLoai_bo_dau_trang).BackColor = Color.Transparent;
		((Control)lblLoai_bo_dau_trang).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Label)lblLoai_bo_dau_trang).ImageAlign = (ContentAlignment)256;
		lblLoai_bo_dau_trang.LinkBehavior = (LinkBehavior)2;
		lblLoai_bo_dau_trang.LinkColor = Color.Black;
		LinkLabel obj9 = lblLoai_bo_dau_trang;
		location = new Point(99, 43);
		((Control)obj9).Location = location;
		((Control)lblLoai_bo_dau_trang).Name = "lblLoai_bo_dau_trang";
		LinkLabel obj10 = lblLoai_bo_dau_trang;
		size = new Size(361, 17);
		((Control)obj10).Size = size;
		((Control)lblLoai_bo_dau_trang).TabIndex = 26;
		((Label)lblLoai_bo_dau_trang).TabStop = true;
		lblLoai_bo_dau_trang.Text = "Loại bỏ các dấu khoảng trắng ở đầu và cuối các loại mã";
		((Label)lblDanh_lai_chi_muc).AutoSize = true;
		((Control)lblDanh_lai_chi_muc).BackColor = Color.Transparent;
		((Control)lblDanh_lai_chi_muc).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Label)lblDanh_lai_chi_muc).ImageAlign = (ContentAlignment)256;
		lblDanh_lai_chi_muc.LinkBehavior = (LinkBehavior)2;
		lblDanh_lai_chi_muc.LinkColor = Color.Black;
		LinkLabel obj11 = lblDanh_lai_chi_muc;
		location = new Point(99, 16);
		((Control)obj11).Location = location;
		((Control)lblDanh_lai_chi_muc).Name = "lblDanh_lai_chi_muc";
		LinkLabel obj12 = lblDanh_lai_chi_muc;
		size = new Size(174, 17);
		((Control)obj12).Size = size;
		((Control)lblDanh_lai_chi_muc).TabIndex = 25;
		((Label)lblDanh_lai_chi_muc).TabStop = true;
		lblDanh_lai_chi_muc.Text = "Đánh lại chỉ mục các bảng";
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).BackColor = Color.White;
		((Control)this).BackgroundImageLayout = (ImageLayout)0;
		size = new Size(448, 297);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Control)this).DoubleBuffered = true;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)2;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSIMaintain";
		((Form)this).Text = "  Bảo trì hệ thống";
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmSIMaintain_Load(object sender, EventArgs e)
	{
		((Form)this).Text = base.MyMenuInfo.bar;
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

	private void llblfun1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		ISIMaintainDAO iSIMaintainDAO = (ISIMaintainDAO)DAOFactory.CreateDAOInstance("SIMaintainDAO", "SIMaintain");
		if ((int)CMessageBox.Show(50086, SystemInformations.ProductName, (MessageBoxButtons)4) == 6)
		{
			((Control)this).Cursor = Cursors.WaitCursor;
			if (iSIMaintainDAO.ExecuteReIndex() == 0)
			{
				((Control)this).Cursor = Cursors.Default;
				CMessageBox.Show(50015);
			}
			else
			{
				((Control)this).Cursor = Cursors.Default;
				CMessageBox.Show(50010);
			}
		}
	}

	private void llblfun2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Button == 1048576)
		{
			frmSITrim_Ma frmSITrim_Ma2 = new frmSITrim_Ma();
			((Form)frmSITrim_Ma2).Text = lblLoai_bo_dau_trang.Text;
			((Form)frmSITrim_Ma2).ShowDialog((IWin32Window)(object)this);
			((Component)(object)frmSITrim_Ma2).Dispose();
			Show();
		}
	}

	private void llblfun3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Button == 1048576)
		{
			frmSICheckHT2TKTH frmSICheckHT2TKTH2 = new frmSICheckHT2TKTH("90.10.72");
			((Form)frmSICheckHT2TKTH2).Text = lblKiem_tra_hoach_toan.Text;
			((Form)frmSICheckHT2TKTH2).ShowDialog((IWin32Window)(object)this);
			((Component)(object)frmSICheckHT2TKTH2).Dispose();
			Show();
		}
	}

	private void llblfun4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Button == 1048576)
		{
			frmSICheckLechSo frmSICheckLechSo2 = new frmSICheckLechSo("90.10.73");
			((Form)frmSICheckLechSo2).Text = lblKiem_tra_chenh_lech.Text;
			((Form)frmSICheckLechSo2).ShowDialog((IWin32Window)(object)this);
			((Component)(object)frmSICheckLechSo2).Dispose();
			Show();
		}
	}

	private void llblfun5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Button == 1048576)
		{
			frmSIBackupDB frmSIBackupDB2 = new frmSIBackupDB();
			((Form)frmSIBackupDB2).Text = lblSao_lu_du_lieu.Text;
			((Form)frmSIBackupDB2).ShowDialog((IWin32Window)(object)this);
			((Component)(object)frmSIBackupDB2).Dispose();
			Show();
		}
	}

	private void llblfun6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Button == 1048576)
		{
			frmAutoBackup frmAutoBackup2 = new frmAutoBackup();
			((Form)frmAutoBackup2).Text = lblKhai_bao_tu_dong_sao_luu.Text;
			((Form)frmAutoBackup2).ShowDialog((IWin32Window)(object)this);
			((Component)(object)frmAutoBackup2).Dispose();
			Show();
		}
	}
}
