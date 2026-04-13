using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmDmdvcsEdit : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblQd_cdkt")]
	private Label _lblQd_cdkt;

	[AccessedThroughProperty("txtQd_cdkt")]
	private TextBox _txtQd_cdkt;

	[AccessedThroughProperty("lblKtt")]
	private Label _lblKtt;

	[AccessedThroughProperty("txtKtt")]
	private TextBox _txtKtt;

	[AccessedThroughProperty("lblGiam_doc")]
	private Label _lblGiam_doc;

	[AccessedThroughProperty("txtGiam_doc")]
	private TextBox _txtGiam_doc;

	[AccessedThroughProperty("lblTen_qd_cdkt")]
	private Label _lblTen_qd_cdkt;

	[AccessedThroughProperty("txtTen_qd_cdkt")]
	private TextBox _txtTen_qd_cdkt;

	[AccessedThroughProperty("lblDia_Chi")]
	private Label _lblDia_Chi;

	[AccessedThroughProperty("txtTel")]
	private TextBox _txtTel;

	[AccessedThroughProperty("txtFax")]
	private TextBox _txtFax;

	[AccessedThroughProperty("txtMa_so_thue")]
	private TextBox _txtMa_so_thue;

	[AccessedThroughProperty("lblMa_So_Thue")]
	private Label _lblMa_So_Thue;

	[AccessedThroughProperty("txtEmail")]
	private TextBox _txtEmail;

	[AccessedThroughProperty("lblMa_cty")]
	private Label _lblMa_cty;

	[AccessedThroughProperty("txtMa_cty")]
	private TextBox _txtMa_cty;

	[AccessedThroughProperty("txtTen_cty")]
	private TextBox _txtTen_cty;

	[AccessedThroughProperty("lblTen_cty")]
	private Label _lblTen_cty;

	[AccessedThroughProperty("lblEmail")]
	private Label _lblEmail;

	[AccessedThroughProperty("lblTel")]
	private Label _lblTel;

	[AccessedThroughProperty("lblFax")]
	private Label _lblFax;

	[AccessedThroughProperty("txtDia_chi")]
	private TextBox _txtDia_chi;

	[AccessedThroughProperty("txtTen_tcty")]
	private TextBox _txtTen_tcty;

	[AccessedThroughProperty("lblTen_tcty")]
	private Label _lblTen_tcty;

	[AccessedThroughProperty("gbLine")]
	private GroupBox _gbLine;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdSave")]
	private Button _cmdSave;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	internal DataRow f_oDrwEdit;

	internal bool isOK;

	internal virtual Label lblQd_cdkt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblQd_cdkt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblQd_cdkt = value;
		}
	}

	internal virtual TextBox txtQd_cdkt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtQd_cdkt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtQd_cdkt = value;
		}
	}

	internal virtual Label lblKtt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblKtt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblKtt = value;
		}
	}

	internal virtual TextBox txtKtt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtKtt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtKtt = value;
		}
	}

	internal virtual Label lblGiam_doc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGiam_doc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGiam_doc = value;
		}
	}

	internal virtual TextBox txtGiam_doc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGiam_doc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGiam_doc = value;
		}
	}

	internal virtual Label lblTen_qd_cdkt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_qd_cdkt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_qd_cdkt = value;
		}
	}

	internal virtual TextBox txtTen_qd_cdkt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_qd_cdkt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_qd_cdkt = value;
		}
	}

	internal virtual Label lblDia_Chi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDia_Chi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDia_Chi = value;
		}
	}

	internal virtual TextBox txtTel
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTel = value;
		}
	}

	internal virtual TextBox txtFax
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFax;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtFax = value;
		}
	}

	internal virtual TextBox txtMa_so_thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_so_thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_so_thue = value;
		}
	}

	internal virtual Label lblMa_So_Thue
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_So_Thue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_So_Thue = value;
		}
	}

	internal virtual TextBox txtEmail
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtEmail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtEmail = value;
		}
	}

	internal virtual Label lblMa_cty
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_cty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_cty = value;
		}
	}

	internal virtual TextBox txtMa_cty
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_cty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_cty = value;
		}
	}

	internal virtual TextBox txtTen_cty
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_cty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_cty = value;
		}
	}

	internal virtual Label lblTen_cty
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_cty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_cty = value;
		}
	}

	internal virtual Label lblEmail
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblEmail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblEmail = value;
		}
	}

	internal virtual Label lblTel
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTel = value;
		}
	}

	internal virtual Label lblFax
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFax;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFax = value;
		}
	}

	internal virtual TextBox txtDia_chi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDia_chi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDia_chi = value;
		}
	}

	internal virtual TextBox txtTen_tcty
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_tcty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_tcty = value;
		}
	}

	internal virtual Label lblTen_tcty
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tcty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tcty = value;
		}
	}

	internal virtual GroupBox gbLine
	{
		[DebuggerNonUserCode]
		get
		{
			return _gbLine;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_gbLine = value;
		}
	}

	protected virtual Button cmdCancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmdCancel = value;
		}
	}

	protected virtual Button cmdSave
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdSave_Click;
			if (_cmdSave != null)
			{
				((Control)_cmdSave).Click -= eventHandler;
			}
			_cmdSave = value;
			if (_cmdSave != null)
			{
				((Control)_cmdSave).Click += eventHandler;
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

	public frmDmdvcsEdit()
	{
		((Form)this).Load += frmDmdvcsEdit_Load;
		__ENCAddToList(this);
		isOK = false;
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
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_1001: Unknown result type (might be due to invalid IL or missing references)
		//IL_100b: Expected O, but got Unknown
		//IL_10b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c2: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmDmdvcsEdit));
		gbLine = new GroupBox();
		Label1 = new Label();
		txtTen_tcty = new TextBox();
		lblTen_tcty = new Label();
		lblTen_qd_cdkt = new Label();
		txtTen_qd_cdkt = new TextBox();
		lblDia_Chi = new Label();
		txtTel = new TextBox();
		txtFax = new TextBox();
		txtMa_so_thue = new TextBox();
		lblMa_So_Thue = new Label();
		txtEmail = new TextBox();
		lblMa_cty = new Label();
		txtMa_cty = new TextBox();
		txtTen_cty = new TextBox();
		lblTen_cty = new Label();
		lblEmail = new Label();
		lblTel = new Label();
		lblFax = new Label();
		lblQd_cdkt = new Label();
		txtQd_cdkt = new TextBox();
		lblKtt = new Label();
		txtKtt = new TextBox();
		lblGiam_doc = new Label();
		txtGiam_doc = new TextBox();
		txtDia_chi = new TextBox();
		cmdCancel = new Button();
		cmdSave = new Button();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)gbLine).Anchor = (AnchorStyles)15;
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_tcty);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tcty);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_qd_cdkt);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_qd_cdkt);
		((Control)gbLine).Controls.Add((Control)(object)lblDia_Chi);
		((Control)gbLine).Controls.Add((Control)(object)txtTel);
		((Control)gbLine).Controls.Add((Control)(object)txtFax);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_so_thue);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_So_Thue);
		((Control)gbLine).Controls.Add((Control)(object)txtEmail);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_cty);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_cty);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_cty);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_cty);
		((Control)gbLine).Controls.Add((Control)(object)lblEmail);
		((Control)gbLine).Controls.Add((Control)(object)lblTel);
		((Control)gbLine).Controls.Add((Control)(object)lblFax);
		((Control)gbLine).Controls.Add((Control)(object)lblQd_cdkt);
		((Control)gbLine).Controls.Add((Control)(object)txtQd_cdkt);
		((Control)gbLine).Controls.Add((Control)(object)lblKtt);
		((Control)gbLine).Controls.Add((Control)(object)txtKtt);
		((Control)gbLine).Controls.Add((Control)(object)lblGiam_doc);
		((Control)gbLine).Controls.Add((Control)(object)txtGiam_doc);
		((Control)gbLine).Controls.Add((Control)(object)txtDia_chi);
		GroupBox obj = gbLine;
		Point location = new Point(12, 12);
		((Control)obj).Location = location;
		((Control)gbLine).Name = "gbLine";
		GroupBox obj2 = gbLine;
		Size size = new Size(638, 348);
		((Control)obj2).Size = size;
		((Control)gbLine).TabIndex = 0;
		gbLine.TabStop = false;
		Label1.AutoSize = true;
		Label1.ImeMode = (ImeMode)0;
		Label label = Label1;
		location = new Point(246, 289);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(42, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 252;
		Label1.Text = "15 / 48";
		Label1.TextAlign = (ContentAlignment)16;
		TextBox obj3 = txtTen_tcty;
		location = new Point(176, 64);
		((Control)obj3).Location = location;
		((Control)txtTen_tcty).Name = "txtTen_tcty";
		TextBox obj4 = txtTen_tcty;
		size = new Size(443, 20);
		((Control)obj4).Size = size;
		((Control)txtTen_tcty).TabIndex = 2;
		lblTen_tcty.AutoSize = true;
		lblTen_tcty.ImeMode = (ImeMode)0;
		Label obj5 = lblTen_tcty;
		location = new Point(6, 68);
		((Control)obj5).Location = location;
		((Control)lblTen_tcty).Name = "lblTen_tcty";
		Label obj6 = lblTen_tcty;
		size = new Size(81, 13);
		((Control)obj6).Size = size;
		((Control)lblTen_tcty).TabIndex = 251;
		lblTen_tcty.Text = "Tên công ty mẹ";
		lblTen_tcty.TextAlign = (ContentAlignment)16;
		lblTen_qd_cdkt.AutoSize = true;
		lblTen_qd_cdkt.ImeMode = (ImeMode)0;
		Label obj7 = lblTen_qd_cdkt;
		location = new Point(6, 316);
		((Control)obj7).Location = location;
		((Control)lblTen_qd_cdkt).Name = "lblTen_qd_cdkt";
		Label obj8 = lblTen_qd_cdkt;
		size = new Size(111, 13);
		((Control)obj8).Size = size;
		((Control)lblTen_qd_cdkt).TabIndex = 249;
		lblTen_qd_cdkt.Text = "Tên quyết định CĐKT";
		lblTen_qd_cdkt.TextAlign = (ContentAlignment)16;
		TextBox obj9 = txtTen_qd_cdkt;
		location = new Point(176, 312);
		((Control)obj9).Location = location;
		((Control)txtTen_qd_cdkt).Name = "txtTen_qd_cdkt";
		TextBox obj10 = txtTen_qd_cdkt;
		size = new Size(443, 20);
		((Control)obj10).Size = size;
		((Control)txtTen_qd_cdkt).TabIndex = 11;
		lblDia_Chi.AutoSize = true;
		lblDia_Chi.ImeMode = (ImeMode)0;
		Label obj11 = lblDia_Chi;
		location = new Point(6, 94);
		((Control)obj11).Location = location;
		((Control)lblDia_Chi).Name = "lblDia_Chi";
		Label obj12 = lblDia_Chi;
		size = new Size(40, 13);
		((Control)obj12).Size = size;
		((Control)lblDia_Chi).TabIndex = 234;
		lblDia_Chi.Text = "Địa chỉ";
		lblDia_Chi.TextAlign = (ContentAlignment)16;
		TextBox obj13 = txtTel;
		location = new Point(176, 142);
		((Control)obj13).Location = location;
		((Control)txtTel).Name = "txtTel";
		TextBox obj14 = txtTel;
		size = new Size(134, 20);
		((Control)obj14).Size = size;
		((Control)txtTel).TabIndex = 5;
		TextBox obj15 = txtFax;
		location = new Point(176, 168);
		((Control)obj15).Location = location;
		((Control)txtFax).Name = "txtFax";
		TextBox obj16 = txtFax;
		size = new Size(134, 20);
		((Control)obj16).Size = size;
		((Control)txtFax).TabIndex = 6;
		TextBox obj17 = txtMa_so_thue;
		location = new Point(176, 116);
		((Control)obj17).Location = location;
		((Control)txtMa_so_thue).Name = "txtMa_so_thue";
		TextBox obj18 = txtMa_so_thue;
		size = new Size(134, 20);
		((Control)obj18).Size = size;
		((Control)txtMa_so_thue).TabIndex = 4;
		lblMa_So_Thue.AutoSize = true;
		lblMa_So_Thue.ImeMode = (ImeMode)0;
		Label obj19 = lblMa_So_Thue;
		location = new Point(6, 120);
		((Control)obj19).Location = location;
		((Control)lblMa_So_Thue).Name = "lblMa_So_Thue";
		Label obj20 = lblMa_So_Thue;
		size = new Size(84, 13);
		((Control)obj20).Size = size;
		((Control)lblMa_So_Thue).TabIndex = 245;
		lblMa_So_Thue.Text = "Mã số thuế VAT";
		lblMa_So_Thue.TextAlign = (ContentAlignment)16;
		TextBox obj21 = txtEmail;
		location = new Point(176, 194);
		((Control)obj21).Location = location;
		((Control)txtEmail).Name = "txtEmail";
		TextBox obj22 = txtEmail;
		size = new Size(443, 20);
		((Control)obj22).Size = size;
		((Control)txtEmail).TabIndex = 7;
		lblMa_cty.AutoSize = true;
		lblMa_cty.ImeMode = (ImeMode)0;
		Label obj23 = lblMa_cty;
		location = new Point(6, 16);
		((Control)obj23).Location = location;
		((Control)lblMa_cty).Name = "lblMa_cty";
		Label obj24 = lblMa_cty;
		size = new Size(60, 13);
		((Control)obj24).Size = size;
		((Control)lblMa_cty).TabIndex = 243;
		lblMa_cty.Text = "Mã công ty";
		lblMa_cty.TextAlign = (ContentAlignment)16;
		TextBox obj25 = txtMa_cty;
		location = new Point(176, 12);
		((Control)obj25).Location = location;
		((Control)txtMa_cty).Name = "txtMa_cty";
		((TextBoxBase)txtMa_cty).ReadOnly = true;
		TextBox obj26 = txtMa_cty;
		size = new Size(64, 20);
		((Control)obj26).Size = size;
		((Control)txtMa_cty).TabIndex = 0;
		((Control)txtMa_cty).TabStop = false;
		TextBox obj27 = txtTen_cty;
		location = new Point(176, 38);
		((Control)obj27).Location = location;
		((Control)txtTen_cty).Name = "txtTen_cty";
		((TextBoxBase)txtTen_cty).ReadOnly = true;
		TextBox obj28 = txtTen_cty;
		size = new Size(443, 20);
		((Control)obj28).Size = size;
		((Control)txtTen_cty).TabIndex = 1;
		((Control)txtTen_cty).TabStop = false;
		lblTen_cty.AutoSize = true;
		lblTen_cty.ImeMode = (ImeMode)0;
		Label obj29 = lblTen_cty;
		location = new Point(6, 42);
		((Control)obj29).Location = location;
		((Control)lblTen_cty).Name = "lblTen_cty";
		Label obj30 = lblTen_cty;
		size = new Size(64, 13);
		((Control)obj30).Size = size;
		((Control)lblTen_cty).TabIndex = 247;
		lblTen_cty.Text = "Tên công ty";
		lblTen_cty.TextAlign = (ContentAlignment)16;
		lblEmail.AutoSize = true;
		lblEmail.ImeMode = (ImeMode)0;
		Label obj31 = lblEmail;
		location = new Point(6, 198);
		((Control)obj31).Location = location;
		((Control)lblEmail).Name = "lblEmail";
		Label obj32 = lblEmail;
		size = new Size(32, 13);
		((Control)obj32).Size = size;
		((Control)lblEmail).TabIndex = 246;
		lblEmail.Text = "Email";
		lblEmail.TextAlign = (ContentAlignment)16;
		lblTel.AutoSize = true;
		lblTel.ImeMode = (ImeMode)0;
		Label obj33 = lblTel;
		location = new Point(6, 146);
		((Control)obj33).Location = location;
		((Control)lblTel).Name = "lblTel";
		Label obj34 = lblTel;
		size = new Size(55, 13);
		((Control)obj34).Size = size;
		((Control)lblTel).TabIndex = 242;
		lblTel.Text = "Điện thoại";
		lblTel.TextAlign = (ContentAlignment)16;
		lblFax.AutoSize = true;
		lblFax.ImeMode = (ImeMode)0;
		Label obj35 = lblFax;
		location = new Point(6, 172);
		((Control)obj35).Location = location;
		((Control)lblFax).Name = "lblFax";
		Label obj36 = lblFax;
		size = new Size(24, 13);
		((Control)obj36).Size = size;
		((Control)lblFax).TabIndex = 244;
		lblFax.Text = "Fax";
		lblFax.TextAlign = (ContentAlignment)16;
		lblQd_cdkt.AutoSize = true;
		lblQd_cdkt.ImeMode = (ImeMode)0;
		Label obj37 = lblQd_cdkt;
		location = new Point(6, 290);
		((Control)obj37).Location = location;
		((Control)lblQd_cdkt).Name = "lblQd_cdkt";
		Label obj38 = lblQd_cdkt;
		size = new Size(105, 13);
		((Control)obj38).Size = size;
		((Control)lblQd_cdkt).TabIndex = 233;
		lblQd_cdkt.Text = "Số quyết định CĐKT";
		lblQd_cdkt.TextAlign = (ContentAlignment)16;
		TextBox obj39 = txtQd_cdkt;
		location = new Point(176, 286);
		((Control)obj39).Location = location;
		((Control)txtQd_cdkt).Name = "txtQd_cdkt";
		TextBox obj40 = txtQd_cdkt;
		size = new Size(64, 20);
		((Control)obj40).Size = size;
		((Control)txtQd_cdkt).TabIndex = 10;
		lblKtt.AutoSize = true;
		lblKtt.ImeMode = (ImeMode)0;
		Label obj41 = lblKtt;
		location = new Point(6, 264);
		((Control)obj41).Location = location;
		((Control)lblKtt).Name = "lblKtt";
		Label obj42 = lblKtt;
		size = new Size(77, 13);
		((Control)obj42).Size = size;
		((Control)lblKtt).TabIndex = 232;
		lblKtt.Text = "Kế toán trưởng";
		lblKtt.TextAlign = (ContentAlignment)16;
		TextBox obj43 = txtKtt;
		location = new Point(176, 260);
		((Control)obj43).Location = location;
		((Control)txtKtt).Name = "txtKtt";
		TextBox obj44 = txtKtt;
		size = new Size(278, 20);
		((Control)obj44).Size = size;
		((Control)txtKtt).TabIndex = 9;
		lblGiam_doc.AutoSize = true;
		lblGiam_doc.ImeMode = (ImeMode)0;
		Label obj45 = lblGiam_doc;
		location = new Point(6, 238);
		((Control)obj45).Location = location;
		((Control)lblGiam_doc).Name = "lblGiam_doc";
		Label obj46 = lblGiam_doc;
		size = new Size(53, 13);
		((Control)obj46).Size = size;
		((Control)lblGiam_doc).TabIndex = 231;
		lblGiam_doc.Text = "Giám đốc";
		lblGiam_doc.TextAlign = (ContentAlignment)16;
		TextBox obj47 = txtGiam_doc;
		location = new Point(176, 234);
		((Control)obj47).Location = location;
		((Control)txtGiam_doc).Name = "txtGiam_doc";
		TextBox obj48 = txtGiam_doc;
		size = new Size(162, 20);
		((Control)obj48).Size = size;
		((Control)txtGiam_doc).TabIndex = 8;
		TextBox obj49 = txtDia_chi;
		location = new Point(176, 90);
		((Control)obj49).Location = location;
		((Control)txtDia_chi).Name = "txtDia_chi";
		TextBox obj50 = txtDia_chi;
		size = new Size(443, 20);
		((Control)obj50).Size = size;
		((Control)txtDia_chi).TabIndex = 3;
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		((ButtonBase)cmdCancel).Image = (Image)componentResourceManager.GetObject("cmdCancel.Image");
		((ButtonBase)cmdCancel).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdCancel).ImeMode = (ImeMode)0;
		Button obj51 = cmdCancel;
		location = new Point(93, 366);
		((Control)obj51).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj52 = cmdCancel;
		size = new Size(75, 23);
		((Control)obj52).Size = size;
		((Control)cmdCancel).TabIndex = 2;
		((ButtonBase)cmdCancel).Text = "&Huỷ bỏ";
		((ButtonBase)cmdCancel).TextAlign = (ContentAlignment)64;
		((Control)cmdSave).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdSave).Image = (Image)componentResourceManager.GetObject("cmdSave.Image");
		((ButtonBase)cmdSave).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdSave).ImeMode = (ImeMode)0;
		Button obj53 = cmdSave;
		location = new Point(12, 366);
		((Control)obj53).Location = location;
		((Control)cmdSave).Name = "cmdSave";
		Button obj54 = cmdSave;
		size = new Size(75, 23);
		((Control)obj54).Size = size;
		((Control)cmdSave).TabIndex = 1;
		((ButtonBase)cmdSave).Text = "&Nhận";
		((ButtonBase)cmdSave).TextAlign = (ContentAlignment)64;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(662, 401);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdSave);
		((Control)this).Controls.Add((Control)(object)gbLine);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmDmdvcsEdit";
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void cmdSave_Click(object sender, EventArgs e)
	{
		Save2Row();
		Commons.ExecuteSYSDBStoredProcedure("asSIUpdcompany", txtMa_cty.Text, txtTen_tcty.Text, txtTen_cty.Text, txtDia_chi.Text, txtGiam_doc.Text, txtKtt.Text, txtMa_so_thue.Text, txtTel.Text, txtFax.Text, txtEmail.Text, txtQd_cdkt.Text, txtTen_qd_cdkt.Text, SystemInformations.CurrentCultureName);
		((Form)this).Close();
	}

	private void frmDmdvcsEdit_Load(object sender, EventArgs e)
	{
		DataBinding();
	}

	private void DataBinding()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		Control ojb = (Control)(object)txtMa_cty;
		CreateDataBinding(ref ojb, "ma_cty");
		txtMa_cty = (TextBox)ojb;
		ojb = (Control)(object)txtTen_cty;
		CreateDataBinding(ref ojb, "ten_cty");
		txtTen_cty = (TextBox)ojb;
		ojb = (Control)(object)txtTen_tcty;
		CreateDataBinding(ref ojb, "ten_tcty");
		txtTen_tcty = (TextBox)ojb;
		ojb = (Control)(object)txtDia_chi;
		CreateDataBinding(ref ojb, "dia_chi");
		txtDia_chi = (TextBox)ojb;
		ojb = (Control)(object)txtMa_so_thue;
		CreateDataBinding(ref ojb, "ma_thue");
		txtMa_so_thue = (TextBox)ojb;
		ojb = (Control)(object)txtTel;
		CreateDataBinding(ref ojb, "tel");
		txtTel = (TextBox)ojb;
		ojb = (Control)(object)txtFax;
		CreateDataBinding(ref ojb, "fax");
		txtFax = (TextBox)ojb;
		ojb = (Control)(object)txtEmail;
		CreateDataBinding(ref ojb, "email");
		txtEmail = (TextBox)ojb;
		ojb = (Control)(object)txtGiam_doc;
		CreateDataBinding(ref ojb, "giam_doc");
		txtGiam_doc = (TextBox)ojb;
		ojb = (Control)(object)txtKtt;
		CreateDataBinding(ref ojb, "ktt");
		txtKtt = (TextBox)ojb;
		ojb = (Control)(object)txtQd_cdkt;
		CreateDataBinding(ref ojb, "qd_cdkt");
		txtQd_cdkt = (TextBox)ojb;
		ojb = (Control)(object)txtTen_qd_cdkt;
		CreateDataBinding(ref ojb, "ten_qd_cdkt");
		txtTen_qd_cdkt = (TextBox)ojb;
	}

	private void CreateDataBinding(ref Control ojb, string dbFieldName, string propertyName = "Text")
	{
		ojb.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(f_oDrwEdit[dbFieldName]), isNum: false));
	}

	private void Save2Row()
	{
		writeValue((Control)(object)txtMa_cty, "ma_cty");
		writeValue((Control)(object)txtTen_cty, "ten_cty");
		writeValue((Control)(object)txtTen_tcty, "ten_tcty");
		writeValue((Control)(object)txtDia_chi, "dia_chi");
		writeValue((Control)(object)txtMa_so_thue, "ma_thue");
		writeValue((Control)(object)txtTel, "tel");
		writeValue((Control)(object)txtFax, "fax");
		writeValue((Control)(object)txtEmail, "email");
		writeValue((Control)(object)txtGiam_doc, "giam_doc");
		writeValue((Control)(object)txtKtt, "ktt");
		writeValue((Control)(object)txtQd_cdkt, "qd_cdkt");
		writeValue((Control)(object)txtTen_qd_cdkt, "ten_qd_cdkt");
	}

	private void writeValue(Control ojb, string dbFieldName)
	{
		f_oDrwEdit[dbFieldName] = ojb.Text;
	}
}
