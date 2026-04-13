using System;
using System.Collections.Generic;
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
	private static List<WeakReference> __ENCList = new List<WeakReference>();

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

	[AccessedThroughProperty("llblfun4")]
	private LinkLabel _llblfun4;

	[AccessedThroughProperty("llblfun3")]
	private LinkLabel _llblfun3;

	[AccessedThroughProperty("llblfun2")]
	private LinkLabel _llblfun2;

	[AccessedThroughProperty("llblfun1")]
	private LinkLabel _llblfun1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("LinkLabel4")]
	private LinkLabel _LinkLabel4;

	[AccessedThroughProperty("LinkLabel6")]
	private LinkLabel _LinkLabel6;

	[AccessedThroughProperty("LinkLabel2")]
	private LinkLabel _LinkLabel2;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("LinkLabel7")]
	private LinkLabel _LinkLabel7;

	[AccessedThroughProperty("llbKhoi_phuc_du_lieu")]
	private LinkLabel _llbKhoi_phuc_du_lieu;

	[AccessedThroughProperty("LinkLabel3")]
	private LinkLabel _LinkLabel3;

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

	internal virtual LinkLabel LinkLabel8
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LinkLabel8 = value;
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

	internal virtual LinkLabel lblKhai_bao_tu_dong_sao_luu
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblKhai_bao_tu_dong_sao_luu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LinkLabel5 = value;
		}
	}

	internal virtual LinkLabel lblSao_lu_du_lieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSao_lu_du_lieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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

	internal virtual LinkLabel llblfun4
	{
		[DebuggerNonUserCode]
		get
		{
			return _llblfun4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_llblfun4 = value;
		}
	}

	internal virtual LinkLabel llblfun3
	{
		[DebuggerNonUserCode]
		get
		{
			return _llblfun3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_llblfun3 = value;
		}
	}

	internal virtual LinkLabel llblfun2
	{
		[DebuggerNonUserCode]
		get
		{
			return _llblfun2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_llblfun2 = value;
		}
	}

	internal virtual LinkLabel llblfun1
	{
		[DebuggerNonUserCode]
		get
		{
			return _llblfun1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(llblfun1_LinkClicked);
			if (_llblfun1 != null)
			{
				_llblfun1.LinkClicked -= val;
			}
			_llblfun1 = value;
			if (_llblfun1 != null)
			{
				_llblfun1.LinkClicked += val;
			}
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual LinkLabel LinkLabel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LinkLabel4 = value;
		}
	}

	internal virtual LinkLabel LinkLabel6
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LinkLabel6 = value;
		}
	}

	internal virtual LinkLabel LinkLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LinkLabel2 = value;
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LinkLabel1 = value;
		}
	}

	internal virtual LinkLabel LinkLabel7
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LinkLabel7 = value;
		}
	}

	internal virtual LinkLabel llbKhoi_phuc_du_lieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _llbKhoi_phuc_du_lieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(llbKhoi_phuc_du_lieu_LinkClicked);
			if (_llbKhoi_phuc_du_lieu != null)
			{
				_llbKhoi_phuc_du_lieu.LinkClicked -= val;
			}
			_llbKhoi_phuc_du_lieu = value;
			if (_llbKhoi_phuc_du_lieu != null)
			{
				_llbKhoi_phuc_du_lieu.LinkClicked += val;
			}
		}
	}

	internal virtual LinkLabel LinkLabel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LinkLabel3 = value;
		}
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
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
	}

	public frmSIMaintain(string MenuID)
		: base(MenuID)
	{
		((Form)this).Load += frmSIMaintain_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected O, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected O, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected O, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected O, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected O, but got Unknown
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected O, but got Unknown
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected O, but got Unknown
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected O, but got Unknown
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected O, but got Unknown
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_099b: Expected O, but got Unknown
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Expected O, but got Unknown
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Expected O, but got Unknown
		//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected O, but got Unknown
		//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Expected O, but got Unknown
		//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d90: Expected O, but got Unknown
		//IL_0e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8b: Expected O, but got Unknown
		//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6c: Expected O, but got Unknown
		//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f88: Expected O, but got Unknown
		//IL_102b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1035: Expected O, but got Unknown
		//IL_1047: Unknown result type (might be due to invalid IL or missing references)
		//IL_1051: Expected O, but got Unknown
		//IL_1101: Unknown result type (might be due to invalid IL or missing references)
		//IL_110b: Expected O, but got Unknown
		//IL_122f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1239: Expected O, but got Unknown
		//IL_124e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1258: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSIMaintain));
		Panel2 = new Panel();
		Label1 = new Label();
		LinkLabel8 = new LinkLabel();
		Panel1 = new Panel();
		LinkLabel4 = new LinkLabel();
		LinkLabel6 = new LinkLabel();
		LinkLabel2 = new LinkLabel();
		LinkLabel1 = new LinkLabel();
		lblKhai_bao_tu_dong_sao_luu = new LinkLabel();
		LinkLabel5 = new LinkLabel();
		lblSao_lu_du_lieu = new LinkLabel();
		llblfun4 = new LinkLabel();
		llblfun3 = new LinkLabel();
		llblfun2 = new LinkLabel();
		llblfun1 = new LinkLabel();
		LinkLabel3 = new LinkLabel();
		LinkLabel7 = new LinkLabel();
		llbKhoi_phuc_du_lieu = new LinkLabel();
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
		((Control)Panel1).Controls.Add((Control)(object)LinkLabel7);
		((Control)Panel1).Controls.Add((Control)(object)llbKhoi_phuc_du_lieu);
		((Control)Panel1).Controls.Add((Control)(object)LinkLabel3);
		((Control)Panel1).Controls.Add((Control)(object)LinkLabel4);
		((Control)Panel1).Controls.Add((Control)(object)LinkLabel6);
		((Control)Panel1).Controls.Add((Control)(object)LinkLabel2);
		((Control)Panel1).Controls.Add((Control)(object)LinkLabel1);
		((Control)Panel1).Controls.Add((Control)(object)lblKhai_bao_tu_dong_sao_luu);
		((Control)Panel1).Controls.Add((Control)(object)LinkLabel5);
		((Control)Panel1).Controls.Add((Control)(object)lblSao_lu_du_lieu);
		((Control)Panel1).Controls.Add((Control)(object)llblfun4);
		((Control)Panel1).Controls.Add((Control)(object)llblfun3);
		((Control)Panel1).Controls.Add((Control)(object)llblfun2);
		((Control)Panel1).Controls.Add((Control)(object)llblfun1);
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
		((Control)LinkLabel4).BackColor = Color.Transparent;
		((Control)LinkLabel4).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel4).Image = (Image)componentResourceManager.GetObject("LinkLabel4.Image");
		((Label)LinkLabel4).ImageAlign = (ContentAlignment)16;
		LinkLabel4.LinkBehavior = (LinkBehavior)2;
		LinkLabel4.LinkColor = Color.Black;
		LinkLabel linkLabel3 = LinkLabel4;
		location = new Point(56, 16);
		((Control)linkLabel3).Location = location;
		((Control)LinkLabel4).Name = "LinkLabel4";
		LinkLabel linkLabel4 = LinkLabel4;
		size = new Size(33, 20);
		((Control)linkLabel4).Size = size;
		((Control)LinkLabel4).TabIndex = 39;
		((Control)LinkLabel6).BackColor = Color.Transparent;
		((Control)LinkLabel6).Enabled = false;
		((Control)LinkLabel6).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel6).Image = (Image)componentResourceManager.GetObject("LinkLabel6.Image");
		((Label)LinkLabel6).ImageAlign = (ContentAlignment)16;
		LinkLabel6.LinkBehavior = (LinkBehavior)2;
		LinkLabel6.LinkColor = Color.Black;
		LinkLabel linkLabel5 = LinkLabel6;
		location = new Point(228, 232);
		((Control)linkLabel5).Location = location;
		((Control)LinkLabel6).Name = "LinkLabel6";
		LinkLabel linkLabel6 = LinkLabel6;
		size = new Size(33, 20);
		((Control)linkLabel6).Size = size;
		((Control)LinkLabel6).TabIndex = 38;
		((Control)LinkLabel6).Visible = false;
		((Control)LinkLabel2).BackColor = Color.Transparent;
		((Control)LinkLabel2).Enabled = false;
		((Control)LinkLabel2).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel2).Image = (Image)componentResourceManager.GetObject("LinkLabel2.Image");
		((Label)LinkLabel2).ImageAlign = (ContentAlignment)16;
		LinkLabel2.LinkBehavior = (LinkBehavior)2;
		LinkLabel2.LinkColor = Color.Black;
		LinkLabel linkLabel7 = LinkLabel2;
		location = new Point(228, 205);
		((Control)linkLabel7).Location = location;
		((Control)LinkLabel2).Name = "LinkLabel2";
		LinkLabel linkLabel8 = LinkLabel2;
		size = new Size(33, 20);
		((Control)linkLabel8).Size = size;
		((Control)LinkLabel2).TabIndex = 37;
		((Control)LinkLabel2).Visible = false;
		((Control)LinkLabel1).BackColor = Color.Transparent;
		((Control)LinkLabel1).Enabled = false;
		((Control)LinkLabel1).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel1).Image = (Image)componentResourceManager.GetObject("LinkLabel1.Image");
		((Label)LinkLabel1).ImageAlign = (ContentAlignment)16;
		LinkLabel1.LinkBehavior = (LinkBehavior)2;
		LinkLabel1.LinkColor = Color.Black;
		LinkLabel linkLabel9 = LinkLabel1;
		location = new Point(228, 178);
		((Control)linkLabel9).Location = location;
		((Control)LinkLabel1).Name = "LinkLabel1";
		LinkLabel linkLabel10 = LinkLabel1;
		size = new Size(33, 20);
		((Control)linkLabel10).Size = size;
		((Control)LinkLabel1).TabIndex = 36;
		((Control)LinkLabel1).Visible = false;
		((Label)lblKhai_bao_tu_dong_sao_luu).AutoSize = true;
		((Control)lblKhai_bao_tu_dong_sao_luu).BackColor = Color.Transparent;
		((Control)lblKhai_bao_tu_dong_sao_luu).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Label)lblKhai_bao_tu_dong_sao_luu).ImageAlign = (ContentAlignment)256;
		lblKhai_bao_tu_dong_sao_luu.LinkBehavior = (LinkBehavior)2;
		lblKhai_bao_tu_dong_sao_luu.LinkColor = Color.Black;
		LinkLabel obj = lblKhai_bao_tu_dong_sao_luu;
		location = new Point(94, 78);
		((Control)obj).Location = location;
		((Control)lblKhai_bao_tu_dong_sao_luu).Name = "lblKhai_bao_tu_dong_sao_luu";
		LinkLabel obj2 = lblKhai_bao_tu_dong_sao_luu;
		size = new Size(108, 17);
		((Control)obj2).Size = size;
		((Control)lblKhai_bao_tu_dong_sao_luu).TabIndex = 35;
		((Label)lblKhai_bao_tu_dong_sao_luu).TabStop = true;
		lblKhai_bao_tu_dong_sao_luu.Text = "Sao lưu tự động";
		((Control)LinkLabel5).BackColor = Color.Transparent;
		((Control)LinkLabel5).Enabled = false;
		((Control)LinkLabel5).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel5).Image = (Image)componentResourceManager.GetObject("LinkLabel5.Image");
		((Label)LinkLabel5).ImageAlign = (ContentAlignment)16;
		LinkLabel5.LinkBehavior = (LinkBehavior)2;
		LinkLabel5.LinkColor = Color.Black;
		LinkLabel linkLabel11 = LinkLabel5;
		location = new Point(228, 151);
		((Control)linkLabel11).Location = location;
		LinkLabel linkLabel12 = LinkLabel5;
		((Padding)(ref val))._002Ector(1);
		((Control)linkLabel12).Margin = val;
		((Control)LinkLabel5).Name = "LinkLabel5";
		LinkLabel linkLabel13 = LinkLabel5;
		((Padding)(ref val))._002Ector(3);
		linkLabel13.Padding = val;
		LinkLabel linkLabel14 = LinkLabel5;
		size = new Size(33, 20);
		((Control)linkLabel14).Size = size;
		((Control)LinkLabel5).TabIndex = 30;
		((Control)LinkLabel5).Visible = false;
		((Label)lblSao_lu_du_lieu).AutoSize = true;
		((Control)lblSao_lu_du_lieu).BackColor = Color.Transparent;
		((Control)lblSao_lu_du_lieu).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Label)lblSao_lu_du_lieu).ImageAlign = (ContentAlignment)256;
		lblSao_lu_du_lieu.LinkBehavior = (LinkBehavior)2;
		lblSao_lu_du_lieu.LinkColor = Color.Black;
		LinkLabel obj3 = lblSao_lu_du_lieu;
		location = new Point(94, 16);
		((Control)obj3).Location = location;
		((Control)lblSao_lu_du_lieu).Name = "lblSao_lu_du_lieu";
		LinkLabel obj4 = lblSao_lu_du_lieu;
		size = new Size(102, 17);
		((Control)obj4).Size = size;
		((Control)lblSao_lu_du_lieu).TabIndex = 29;
		((Label)lblSao_lu_du_lieu).TabStop = true;
		lblSao_lu_du_lieu.Text = "Sao lưu dữ liệu";
		((Label)llblfun4).AutoSize = true;
		((Control)llblfun4).BackColor = Color.Transparent;
		((Control)llblfun4).Enabled = false;
		((Control)llblfun4).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Label)llblfun4).ImageAlign = (ContentAlignment)256;
		llblfun4.LinkBehavior = (LinkBehavior)2;
		llblfun4.LinkColor = Color.Black;
		LinkLabel obj5 = llblfun4;
		location = new Point(266, 232);
		((Control)obj5).Location = location;
		((Control)llblfun4).Name = "llblfun4";
		LinkLabel obj6 = llblfun4;
		size = new Size(77, 17);
		((Control)obj6).Size = size;
		((Control)llblfun4).TabIndex = 28;
		((Label)llblfun4).TabStop = true;
		llblfun4.Text = "LinkLabel4";
		((Control)llblfun4).Visible = false;
		((Label)llblfun3).AutoSize = true;
		((Control)llblfun3).BackColor = Color.Transparent;
		((Control)llblfun3).Enabled = false;
		((Control)llblfun3).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Label)llblfun3).ImageAlign = (ContentAlignment)256;
		llblfun3.LinkBehavior = (LinkBehavior)2;
		llblfun3.LinkColor = Color.Black;
		LinkLabel obj7 = llblfun3;
		location = new Point(266, 205);
		((Control)obj7).Location = location;
		((Control)llblfun3).Name = "llblfun3";
		LinkLabel obj8 = llblfun3;
		size = new Size(77, 17);
		((Control)obj8).Size = size;
		((Control)llblfun3).TabIndex = 27;
		((Label)llblfun3).TabStop = true;
		llblfun3.Text = "LinkLabel3";
		((Control)llblfun3).Visible = false;
		((Label)llblfun2).AutoSize = true;
		((Control)llblfun2).BackColor = Color.Transparent;
		((Control)llblfun2).Enabled = false;
		((Control)llblfun2).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Label)llblfun2).ImageAlign = (ContentAlignment)256;
		llblfun2.LinkBehavior = (LinkBehavior)2;
		llblfun2.LinkColor = Color.Black;
		LinkLabel obj9 = llblfun2;
		location = new Point(266, 178);
		((Control)obj9).Location = location;
		((Control)llblfun2).Name = "llblfun2";
		LinkLabel obj10 = llblfun2;
		size = new Size(77, 17);
		((Control)obj10).Size = size;
		((Control)llblfun2).TabIndex = 26;
		((Label)llblfun2).TabStop = true;
		llblfun2.Text = "LinkLabel2";
		((Control)llblfun2).Visible = false;
		((Label)llblfun1).AutoSize = true;
		((Control)llblfun1).BackColor = Color.Transparent;
		((Control)llblfun1).Enabled = false;
		((Control)llblfun1).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Label)llblfun1).ImageAlign = (ContentAlignment)256;
		llblfun1.LinkBehavior = (LinkBehavior)2;
		llblfun1.LinkColor = Color.Black;
		LinkLabel obj11 = llblfun1;
		location = new Point(266, 151);
		((Control)obj11).Location = location;
		((Control)llblfun1).Name = "llblfun1";
		LinkLabel obj12 = llblfun1;
		size = new Size(77, 17);
		((Control)obj12).Size = size;
		((Control)llblfun1).TabIndex = 25;
		((Label)llblfun1).TabStop = true;
		llblfun1.Text = "LinkLabel1";
		((Control)llblfun1).Visible = false;
		((Control)LinkLabel3).BackColor = Color.Transparent;
		((Control)LinkLabel3).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel3).Image = (Image)componentResourceManager.GetObject("LinkLabel3.Image");
		((Label)LinkLabel3).ImageAlign = (ContentAlignment)16;
		LinkLabel3.LinkBehavior = (LinkBehavior)2;
		LinkLabel3.LinkColor = Color.Black;
		LinkLabel linkLabel15 = LinkLabel3;
		location = new Point(56, 78);
		((Control)linkLabel15).Location = location;
		((Control)LinkLabel3).Name = "LinkLabel3";
		LinkLabel linkLabel16 = LinkLabel3;
		size = new Size(33, 20);
		((Control)linkLabel16).Size = size;
		((Control)LinkLabel3).TabIndex = 40;
		((Control)LinkLabel7).BackColor = Color.Transparent;
		((Control)LinkLabel7).Font = new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Label)LinkLabel7).Image = (Image)componentResourceManager.GetObject("LinkLabel7.Image");
		((Label)LinkLabel7).ImageAlign = (ContentAlignment)16;
		LinkLabel7.LinkBehavior = (LinkBehavior)2;
		LinkLabel7.LinkColor = Color.Black;
		LinkLabel linkLabel17 = LinkLabel7;
		location = new Point(56, 46);
		((Control)linkLabel17).Location = location;
		((Control)LinkLabel7).Name = "LinkLabel7";
		LinkLabel linkLabel18 = LinkLabel7;
		size = new Size(33, 20);
		((Control)linkLabel18).Size = size;
		((Control)LinkLabel7).TabIndex = 42;
		((Label)llbKhoi_phuc_du_lieu).AutoSize = true;
		((Control)llbKhoi_phuc_du_lieu).BackColor = Color.Transparent;
		((Control)llbKhoi_phuc_du_lieu).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Label)llbKhoi_phuc_du_lieu).ImageAlign = (ContentAlignment)256;
		llbKhoi_phuc_du_lieu.LinkBehavior = (LinkBehavior)2;
		llbKhoi_phuc_du_lieu.LinkColor = Color.Black;
		LinkLabel obj13 = llbKhoi_phuc_du_lieu;
		location = new Point(94, 46);
		((Control)obj13).Location = location;
		((Control)llbKhoi_phuc_du_lieu).Name = "llbKhoi_phuc_du_lieu";
		LinkLabel obj14 = llbKhoi_phuc_du_lieu;
		size = new Size(117, 17);
		((Control)obj14).Size = size;
		((Control)llbKhoi_phuc_du_lieu).TabIndex = 41;
		((Label)llbKhoi_phuc_du_lieu).TabStop = true;
		llbKhoi_phuc_du_lieu.Text = "Khôi phục dữ liệu";
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
		((Form)this).Text = "Sao lưu dữ liệu";
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmSIMaintain_Load(object sender, EventArgs e)
	{
		llblfun1.Text = "Đánh lại chỉ mục các bảng";
		llblfun2.Text = "Loại bỏ các dấu khoảng trắng ở đầu và cuối các loại mã";
		llblfun3.Text = "Kiểm tra hạch toán vào tài khoản tổng hợp";
		llblfun4.Text = "Kiểm tra lệch giữa các sổ (Kế toán - Kho)";
		lblSao_lu_du_lieu.Text = "Sao lưu dữ liệu";
		llbKhoi_phuc_du_lieu.Text = "Khôi phục dữ liệu";
		lblKhai_bao_tu_dong_sao_luu.Text = "Khai báo tự động sao lưu dữ liệu";
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void llblfun1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		SIMaintainDAO sIMaintainDAO = (SIMaintainDAO)DAOFactory.CreateDAOInstance("SIMaintainDAO", "SIMaintain");
		if ((int)CMessageBox.Show(50086, SystemInformations.ProductName, (MessageBoxButtons)4) == 6)
		{
			((Control)this).Cursor = Cursors.WaitCursor;
			if (sIMaintainDAO.ExecuteReIndex() == 0)
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

	private void llblfun5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		frmSIBackupDB frmSIBackupDB2 = new frmSIBackupDB();
		((Form)frmSIBackupDB2).ShowDialog((IWin32Window)(object)this);
		((Component)(object)frmSIBackupDB2).Dispose();
		Show();
	}

	private void llblfun6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		frmAutoBackup frmAutoBackup2 = new frmAutoBackup();
		((Form)frmAutoBackup2).ShowDialog((IWin32Window)(object)this);
		((Component)(object)frmAutoBackup2).Dispose();
		Show();
	}

	private void llbKhoi_phuc_du_lieu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		frmSIRestoreDB frmSIRestoreDB2 = new frmSIRestoreDB();
		((Form)frmSIRestoreDB2).ShowDialog((IWin32Window)(object)this);
		((Component)(object)frmSIRestoreDB2).Dispose();
		Show();
	}
}
