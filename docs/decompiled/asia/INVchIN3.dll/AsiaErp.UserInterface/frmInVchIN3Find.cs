using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmInVchIN3Find : frmVoucherFind
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("lblNguoi_Gd")]
	private Label _lblNguoi_Gd;

	[AccessedThroughProperty("txtNguoi_Gd")]
	private TextBox _txtNguoi_Gd;

	[AccessedThroughProperty("lblTen_khoX")]
	private Label _lblTen_khoX;

	[AccessedThroughProperty("txtMa_KhoX")]
	private AsTextBox _txtMa_KhoX;

	[AccessedThroughProperty("lblMa_khoX")]
	private Label _lblMa_khoX;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("lblDien_giai")]
	private Label _lblDien_giai;

	[AccessedThroughProperty("lblMa_gd")]
	private Label _lblMa_gd;

	[AccessedThroughProperty("cboMa_gd")]
	private ComboBox _cboMa_gd;

	[AccessedThroughProperty("lblTen_khoN")]
	private Label _lblTen_khoN;

	[AccessedThroughProperty("txtMa_KhoN")]
	private AsTextBox _txtMa_KhoN;

	[AccessedThroughProperty("lblMa_khoN")]
	private Label _lblMa_khoN;

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("txtMaLo")]
	private AsTextBox _txtMaLo;

	[AccessedThroughProperty("lblMaLo")]
	private Label _lblMaLo;

	[AccessedThroughProperty("lblTen_Spct")]
	private Label _lblTen_Spct;

	[AccessedThroughProperty("txtMa_Spct")]
	private AsTextBox _txtMa_Spct;

	[AccessedThroughProperty("lblMa_Spct")]
	private Label _lblMa_Spct;

	[AccessedThroughProperty("lblTen_Hd")]
	private Label _lblTen_Hd;

	[AccessedThroughProperty("txtMa_Hd")]
	private AsTextBox _txtMa_Hd;

	[AccessedThroughProperty("lblMa_Hd")]
	private Label _lblMa_Hd;

	[AccessedThroughProperty("lblTen_Phi")]
	private Label _lblTen_Phi;

	[AccessedThroughProperty("txtMa_Phi")]
	private AsTextBox _txtMa_Phi;

	[AccessedThroughProperty("lblMa_Phi")]
	private Label _lblMa_Phi;

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

	[AccessedThroughProperty("txtMa_Bp")]
	private AsTextBox _txtMa_Bp;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	[AccessedThroughProperty("lblTen_tk_co")]
	private Label _lblTen_tk_co;

	[AccessedThroughProperty("txtTk_co")]
	private AsTextBox _txtTk_co;

	[AccessedThroughProperty("lblTk_no")]
	private Label _lblTk_no;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("lblTen_Tk_vt")]
	private Label _lblTen_Tk_vt;

	[AccessedThroughProperty("txtTk_vt")]
	private AsTextBox _txtTk_vt;

	[AccessedThroughProperty("lblTk_vt")]
	private Label _lblTk_vt;

	private DmMaGd oAll;

	private ArrayList _datasource;

	internal virtual Label lblTen_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Kh = value;
		}
	}

	internal virtual AsTextBox txtMa_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Kh = value;
		}
	}

	internal virtual Label lblMa_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Kh = value;
		}
	}

	internal virtual Label lblNguoi_Gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguoi_Gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguoi_Gd = value;
		}
	}

	internal virtual TextBox txtNguoi_Gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNguoi_Gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNguoi_Gd = value;
		}
	}

	internal virtual Label lblTen_khoX
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_khoX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_khoX = value;
		}
	}

	internal virtual AsTextBox txtMa_KhoX
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_KhoX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_KhoX = value;
		}
	}

	internal virtual Label lblMa_khoX
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_khoX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_khoX = value;
		}
	}

	internal virtual TextBox txtDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDien_giai = value;
		}
	}

	internal virtual Label lblDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDien_giai = value;
		}
	}

	internal virtual Label lblMa_gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_gd = value;
		}
	}

	internal virtual ComboBox cboMa_gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboMa_gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboMa_gd = value;
		}
	}

	internal virtual Label lblTen_khoN
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_khoN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_khoN = value;
		}
	}

	internal virtual AsTextBox txtMa_KhoN
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_KhoN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_KhoN = value;
		}
	}

	internal virtual Label lblMa_khoN
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_khoN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_khoN = value;
		}
	}

	internal virtual Label lblTen_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_lo = value;
		}
	}

	internal virtual AsTextBox txtMaLo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMaLo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMaLo = value;
		}
	}

	internal virtual Label lblMaLo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMaLo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMaLo = value;
		}
	}

	internal virtual Label lblTen_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Spct = value;
		}
	}

	internal virtual AsTextBox txtMa_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Spct = value;
		}
	}

	internal virtual Label lblMa_Spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Spct = value;
		}
	}

	internal virtual Label lblTen_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Hd = value;
		}
	}

	internal virtual AsTextBox txtMa_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Hd = value;
		}
	}

	internal virtual Label lblMa_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Hd = value;
		}
	}

	internal virtual Label lblTen_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Phi = value;
		}
	}

	internal virtual AsTextBox txtMa_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Phi = value;
		}
	}

	internal virtual Label lblMa_Phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Phi = value;
		}
	}

	internal virtual Label lblTen_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Bp = value;
		}
	}

	internal virtual AsTextBox txtMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Bp = value;
		}
	}

	internal virtual Label lblMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Bp = value;
		}
	}

	internal virtual Label lblTen_tk_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk_co = value;
		}
	}

	internal virtual AsTextBox txtTk_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_co = value;
		}
	}

	internal virtual Label lblTk_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_no = value;
		}
	}

	internal virtual Label lblTen_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_vt = value;
		}
	}

	internal virtual AsTextBox txtMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_vt = value;
		}
	}

	internal virtual Label lblMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_vt = value;
		}
	}

	internal virtual Label lblTen_Tk_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_vt = value;
		}
	}

	internal virtual AsTextBox txtTk_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_vt = value;
		}
	}

	internal virtual Label lblTk_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_vt = value;
		}
	}

	public frmInVchIN3Find()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		((Form)this).Load += frmInVchIN2Find_Load;
		((Form)this).FormClosing += new FormClosingEventHandler(frmInVchIN2Find_FormClosing);
		__ENCAddToList(this);
		oAll = new DmMaGd();
		InitializeComponent();
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblNguoi_Gd = new Label();
		txtNguoi_Gd = new TextBox();
		lblTen_khoX = new Label();
		txtMa_KhoX = new AsTextBox();
		lblMa_khoX = new Label();
		txtDien_giai = new TextBox();
		lblDien_giai = new Label();
		lblMa_gd = new Label();
		cboMa_gd = new ComboBox();
		lblTen_khoN = new Label();
		txtMa_KhoN = new AsTextBox();
		lblMa_khoN = new Label();
		lblTen_lo = new Label();
		txtMaLo = new AsTextBox();
		lblMaLo = new Label();
		lblTen_Spct = new Label();
		txtMa_Spct = new AsTextBox();
		lblMa_Spct = new Label();
		lblTen_Hd = new Label();
		txtMa_Hd = new AsTextBox();
		lblMa_Hd = new Label();
		lblTen_Phi = new Label();
		txtMa_Phi = new AsTextBox();
		lblMa_Phi = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_Bp = new Label();
		lblTen_tk_co = new Label();
		txtTk_co = new AsTextBox();
		lblTk_no = new Label();
		lblTen_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		lblTen_Tk_vt = new Label();
		txtTk_vt = new AsTextBox();
		lblTk_vt = new Label();
		((Control)gbPh).SuspendLayout();
		((Control)gbCt).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 508);
		((Control)obj).Location = location;
		Button obj2 = cmdOk;
		location = new Point(12, 508);
		((Control)obj2).Location = location;
		((Control)gbPh).Controls.Add((Control)(object)lblMa_gd);
		((Control)gbPh).Controls.Add((Control)(object)cboMa_gd);
		((Control)gbPh).Controls.Add((Control)(object)lblNguoi_Gd);
		((Control)gbPh).Controls.Add((Control)(object)txtNguoi_Gd);
		((Control)gbPh).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbPh).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbPh).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbPh).Controls.Add((Control)(object)lblDien_giai);
		((Control)gbPh).Controls.Add((Control)(object)lblMa_Kh);
		GroupBox obj3 = gbPh;
		Size size = new Size(665, 210);
		((Control)obj3).Size = size;
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblSo_tien1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtSo_tien1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblSo_tien2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtSo_tien2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblNgay_Ct1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtNgay_Ct1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblNgay_Ct2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtNgay_Ct2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblSo_Ct1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblSo_Ct2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtSo_Ct1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtSo_Ct2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblDien_giai, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtDien_giai, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtNguoi_Gd, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblNguoi_Gd, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)cboMa_gd, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblMa_gd, 0);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_lo);
		((Control)gbCt).Controls.Add((Control)(object)txtMaLo);
		((Control)gbCt).Controls.Add((Control)(object)lblMaLo);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Spct);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Spct);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_Spct);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Hd);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Hd);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_Hd);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Phi);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Phi);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_Phi);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Bp);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Bp);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_Bp);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_tk_co);
		((Control)gbCt).Controls.Add((Control)(object)txtTk_co);
		((Control)gbCt).Controls.Add((Control)(object)lblTk_no);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_vt);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_vt);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Tk_vt);
		((Control)gbCt).Controls.Add((Control)(object)txtTk_vt);
		((Control)gbCt).Controls.Add((Control)(object)lblTk_vt);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_khoN);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_KhoN);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_khoN);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_khoX);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_KhoX);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_khoX);
		GroupBox obj4 = gbCt;
		location = new Point(12, 220);
		((Control)obj4).Location = location;
		GroupBox obj5 = gbCt;
		size = new Size(665, 282);
		((Control)obj5).Size = size;
		TextBox obj6 = txtSo_Ct1;
		location = new Point(153, 45);
		((Control)obj6).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct2;
		location = new Point(333, 20);
		((Control)asMaskedTextBox).Location = location;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_Ct1;
		location = new Point(153, 19);
		((Control)asMaskedTextBox2).Location = location;
		TextBox obj7 = txtSo_Ct2;
		location = new Point(333, 45);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct2;
		location = new Point(264, 49);
		((Control)obj8).Location = location;
		Label obj9 = lblNgay_Ct2;
		location = new Point(264, 22);
		((Control)obj9).Location = location;
		Label obj10 = lblSo_tien2;
		location = new Point(266, 74);
		((Control)obj10).Location = location;
		txtSo_tien1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtSo_tien1;
		location = new Point(153, 71);
		((Control)asTextNumeric).Location = location;
		txtSo_tien1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSo_tien1).Tag = "t_tien_nt";
		txtSo_tien1.Type = Commons.NumericType.ORTHER_;
		txtSo_tien2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric2 = txtSo_tien2;
		location = new Point(333, 71);
		((Control)asTextNumeric2).Location = location;
		txtSo_tien2.SpecialType = Commons.NumericSpecialType.Other;
		txtSo_tien2.Type = Commons.NumericType.ORTHER_;
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj11 = lblTen_Kh;
		location = new Point(257, 127);
		((Control)obj11).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj12 = lblTen_Kh;
		size = new Size(384, 13);
		((Control)obj12).Size = size;
		((Control)lblTen_Kh).TabIndex = 137;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = false;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(153, 124);
		((Control)asTextBox).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		AsTextBox asTextBox2 = txtMa_Kh;
		size = new Size(95, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Kh).TabIndex = 7;
		txtMa_Kh.UseAutoCompleteSource = true;
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj13 = lblMa_Kh;
		location = new Point(6, 128);
		((Control)obj13).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj14 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj14).Size = size;
		((Control)lblMa_Kh).TabIndex = 136;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj15 = lblNguoi_Gd;
		location = new Point(6, 153);
		((Control)obj15).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj16 = lblNguoi_Gd;
		size = new Size(98, 14);
		((Control)obj16).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 222;
		lblNguoi_Gd.Text = "Người giao dịch";
		TextBox obj17 = txtNguoi_Gd;
		location = new Point(153, 150);
		((Control)obj17).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj18 = txtNguoi_Gd;
		size = new Size(163, 20);
		((Control)obj18).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 8;
		lblTen_khoX.ImeMode = (ImeMode)0;
		Label obj19 = lblTen_khoX;
		location = new Point(254, 23);
		((Control)obj19).Location = location;
		((Control)lblTen_khoX).Name = "lblTen_khoX";
		Label obj20 = lblTen_khoX;
		size = new Size(387, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_khoX).TabIndex = 224;
		lblTen_khoX.TextAlign = (ContentAlignment)16;
		txtMa_KhoX.AutoLookup = true;
		txtMa_KhoX.AutoValid = false;
		((TextBoxBase)txtMa_KhoX).BackColor = SystemColors.Info;
		((TextBox)txtMa_KhoX).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_KhoX;
		location = new Point(153, 20);
		((Control)asTextBox3).Location = location;
		txtMa_KhoX.LookupCodeName = "MA_KHO";
		((Control)txtMa_KhoX).Name = "txtMa_KhoX";
		txtMa_KhoX.NameControl = lblTen_khoX;
		AsTextBox asTextBox4 = txtMa_KhoX;
		size = new Size(95, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_KhoX).TabIndex = 0;
		txtMa_KhoX.UseAutoCompleteSource = true;
		lblMa_khoX.AutoSize = true;
		lblMa_khoX.ImeMode = (ImeMode)0;
		Label obj21 = lblMa_khoX;
		location = new Point(6, 23);
		((Control)obj21).Location = location;
		((Control)lblMa_khoX).Name = "lblMa_khoX";
		Label obj22 = lblMa_khoX;
		size = new Size(66, 13);
		((Control)obj22).Size = size;
		((Control)lblMa_khoX).TabIndex = 223;
		lblMa_khoX.Text = "Mã kho xuất";
		txtDien_giai.AutoCompleteMode = (AutoCompleteMode)1;
		txtDien_giai.AutoCompleteSource = (AutoCompleteSource)7;
		TextBox obj23 = txtDien_giai;
		location = new Point(153, 176);
		((Control)obj23).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj24 = txtDien_giai;
		size = new Size(488, 20);
		((Control)obj24).Size = size;
		((Control)txtDien_giai).TabIndex = 9;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj25 = lblDien_giai;
		location = new Point(6, 180);
		((Control)obj25).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj26 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj26).Size = size;
		((Control)lblDien_giai).TabIndex = 235;
		lblDien_giai.Text = "Diễn giải";
		lblMa_gd.AutoSize = true;
		lblMa_gd.ImeMode = (ImeMode)0;
		Label obj27 = lblMa_gd;
		location = new Point(5, 100);
		((Control)obj27).Location = location;
		((Control)lblMa_gd).Name = "lblMa_gd";
		Label obj28 = lblMa_gd;
		size = new Size(79, 13);
		((Control)obj28).Size = size;
		((Control)lblMa_gd).TabIndex = 241;
		lblMa_gd.Text = "Loại phiếu xuất";
		lblMa_gd.TextAlign = (ContentAlignment)16;
		cboMa_gd.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMa_gd).FormattingEnabled = true;
		ComboBox obj29 = cboMa_gd;
		location = new Point(153, 97);
		((Control)obj29).Location = location;
		((Control)cboMa_gd).Name = "cboMa_gd";
		ComboBox obj30 = cboMa_gd;
		size = new Size(163, 21);
		((Control)obj30).Size = size;
		((Control)cboMa_gd).TabIndex = 6;
		lblTen_khoN.ImeMode = (ImeMode)0;
		Label obj31 = lblTen_khoN;
		location = new Point(254, 49);
		((Control)obj31).Location = location;
		((Control)lblTen_khoN).Name = "lblTen_khoN";
		Label obj32 = lblTen_khoN;
		size = new Size(387, 13);
		((Control)obj32).Size = size;
		((Control)lblTen_khoN).TabIndex = 248;
		lblTen_khoN.TextAlign = (ContentAlignment)16;
		txtMa_KhoN.AutoLookup = true;
		txtMa_KhoN.AutoValid = false;
		((TextBoxBase)txtMa_KhoN).BackColor = SystemColors.Info;
		((TextBox)txtMa_KhoN).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_KhoN;
		location = new Point(153, 46);
		((Control)asTextBox5).Location = location;
		txtMa_KhoN.LookupCodeName = "MA_KHO";
		((Control)txtMa_KhoN).Name = "txtMa_KhoN";
		txtMa_KhoN.NameControl = lblTen_khoN;
		AsTextBox asTextBox6 = txtMa_KhoN;
		size = new Size(95, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_KhoN).TabIndex = 1;
		txtMa_KhoN.UseAutoCompleteSource = true;
		lblMa_khoN.AutoSize = true;
		lblMa_khoN.ImeMode = (ImeMode)0;
		Label obj33 = lblMa_khoN;
		location = new Point(6, 49);
		((Control)obj33).Location = location;
		((Control)lblMa_khoN).Name = "lblMa_khoN";
		Label obj34 = lblMa_khoN;
		size = new Size(70, 13);
		((Control)obj34).Size = size;
		((Control)lblMa_khoN).TabIndex = 247;
		lblMa_khoN.Text = "Mã kho nhập";
		Label obj35 = lblTen_lo;
		location = new Point(254, 76);
		((Control)obj35).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj36 = lblTen_lo;
		size = new Size(387, 13);
		((Control)obj36).Size = size;
		((Control)lblTen_lo).TabIndex = 1326;
		txtMaLo.AutoLookup = true;
		txtMaLo.AutoValid = false;
		((TextBoxBase)txtMaLo).BackColor = SystemColors.Info;
		((TextBox)txtMaLo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMaLo;
		location = new Point(153, 72);
		((Control)asTextBox7).Location = location;
		txtMaLo.LookupCodeName = "MA_LO";
		((Control)txtMaLo).Name = "txtMaLo";
		txtMaLo.NameControl = lblTen_lo;
		AsTextBox asTextBox8 = txtMaLo;
		size = new Size(95, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMaLo).TabIndex = 2;
		((Control)txtMaLo).Tag = "MA_LO";
		txtMaLo.UseAutoCompleteSource = true;
		lblMaLo.AutoSize = true;
		Label obj37 = lblMaLo;
		location = new Point(6, 76);
		((Control)obj37).Location = location;
		((Control)lblMaLo).Name = "lblMaLo";
		Label obj38 = lblMaLo;
		size = new Size(33, 13);
		((Control)obj38).Size = size;
		((Control)lblMaLo).TabIndex = 1327;
		lblMaLo.Text = "Mã lô";
		lblTen_Spct.ImeMode = (ImeMode)0;
		Label obj39 = lblTen_Spct;
		location = new Point(254, 257);
		((Control)obj39).Location = location;
		((Control)lblTen_Spct).Name = "lblTen_Spct";
		Label obj40 = lblTen_Spct;
		size = new Size(387, 13);
		((Control)obj40).Size = size;
		((Control)lblTen_Spct).TabIndex = 1325;
		lblTen_Spct.TextAlign = (ContentAlignment)16;
		txtMa_Spct.AutoLookup = true;
		txtMa_Spct.AutoValid = false;
		((TextBoxBase)txtMa_Spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_Spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_Spct;
		location = new Point(153, 254);
		((Control)asTextBox9).Location = location;
		txtMa_Spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_Spct).Name = "txtMa_Spct";
		txtMa_Spct.NameControl = lblTen_Spct;
		AsTextBox asTextBox10 = txtMa_Spct;
		size = new Size(95, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_Spct).TabIndex = 9;
		txtMa_Spct.UseAutoCompleteSource = true;
		lblMa_Spct.AutoSize = true;
		lblMa_Spct.ImeMode = (ImeMode)0;
		Label obj41 = lblMa_Spct;
		location = new Point(6, 258);
		((Control)obj41).Location = location;
		((Control)lblMa_Spct).Name = "lblMa_Spct";
		Label obj42 = lblMa_Spct;
		size = new Size(53, 13);
		((Control)obj42).Size = size;
		((Control)lblMa_Spct).TabIndex = 1324;
		lblMa_Spct.Text = "Mã SPCT";
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj43 = lblTen_Hd;
		location = new Point(254, 179);
		((Control)obj43).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj44 = lblTen_Hd;
		size = new Size(387, 13);
		((Control)obj44).Size = size;
		((Control)lblTen_Hd).TabIndex = 1323;
		lblTen_Hd.TextAlign = (ContentAlignment)16;
		txtMa_Hd.AutoLookup = true;
		txtMa_Hd.AutoValid = false;
		((TextBoxBase)txtMa_Hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtMa_Hd;
		location = new Point(153, 176);
		((Control)asTextBox11).Location = location;
		txtMa_Hd.LookupCodeName = "MA_HD";
		((Control)txtMa_Hd).Name = "txtMa_Hd";
		txtMa_Hd.NameControl = lblTen_Hd;
		AsTextBox asTextBox12 = txtMa_Hd;
		size = new Size(95, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtMa_Hd).TabIndex = 6;
		txtMa_Hd.UseAutoCompleteSource = true;
		lblMa_Hd.AutoSize = true;
		lblMa_Hd.ImeMode = (ImeMode)0;
		Label obj45 = lblMa_Hd;
		location = new Point(6, 180);
		((Control)obj45).Location = location;
		((Control)lblMa_Hd).Name = "lblMa_Hd";
		Label obj46 = lblMa_Hd;
		size = new Size(71, 13);
		((Control)obj46).Size = size;
		((Control)lblMa_Hd).TabIndex = 1322;
		lblMa_Hd.Text = "Mã hợp đồng";
		lblTen_Phi.ImeMode = (ImeMode)0;
		Label obj47 = lblTen_Phi;
		location = new Point(254, 232);
		((Control)obj47).Location = location;
		((Control)lblTen_Phi).Name = "lblTen_Phi";
		Label obj48 = lblTen_Phi;
		size = new Size(387, 13);
		((Control)obj48).Size = size;
		((Control)lblTen_Phi).TabIndex = 1321;
		lblTen_Phi.TextAlign = (ContentAlignment)16;
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox13 = txtMa_Phi;
		location = new Point(153, 228);
		((Control)asTextBox13).Location = location;
		txtMa_Phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		txtMa_Phi.NameControl = lblTen_Phi;
		AsTextBox asTextBox14 = txtMa_Phi;
		size = new Size(95, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtMa_Phi).TabIndex = 8;
		txtMa_Phi.UseAutoCompleteSource = true;
		lblMa_Phi.AutoSize = true;
		lblMa_Phi.ImeMode = (ImeMode)0;
		Label obj49 = lblMa_Phi;
		location = new Point(6, 232);
		((Control)obj49).Location = location;
		((Control)lblMa_Phi).Name = "lblMa_Phi";
		Label obj50 = lblMa_Phi;
		size = new Size(41, 13);
		((Control)obj50).Size = size;
		((Control)lblMa_Phi).TabIndex = 1320;
		lblMa_Phi.Text = "Mã phí";
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj51 = lblTen_Bp;
		location = new Point(254, 205);
		((Control)obj51).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj52 = lblTen_Bp;
		size = new Size(387, 13);
		((Control)obj52).Size = size;
		((Control)lblTen_Bp).TabIndex = 1319;
		lblTen_Bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox15 = txtMa_Bp;
		location = new Point(153, 202);
		((Control)asTextBox15).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox16 = txtMa_Bp;
		size = new Size(95, 20);
		((Control)asTextBox16).Size = size;
		((Control)txtMa_Bp).TabIndex = 7;
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_Bp.AutoSize = true;
		lblMa_Bp.ImeMode = (ImeMode)0;
		Label obj53 = lblMa_Bp;
		location = new Point(6, 206);
		((Control)obj53).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj54 = lblMa_Bp;
		size = new Size(64, 13);
		((Control)obj54).Size = size;
		((Control)lblMa_Bp).TabIndex = 1318;
		lblMa_Bp.Text = "Mã bộ phận";
		lblTen_tk_co.ImeMode = (ImeMode)0;
		Label obj55 = lblTen_tk_co;
		location = new Point(254, 153);
		((Control)obj55).Location = location;
		((Control)lblTen_tk_co).Name = "lblTen_tk_co";
		Label obj56 = lblTen_tk_co;
		size = new Size(387, 13);
		((Control)obj56).Size = size;
		((Control)lblTen_tk_co).TabIndex = 1317;
		lblTen_tk_co.TextAlign = (ContentAlignment)16;
		((TextBox)txtTk_co).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk_co.AutoLookup = true;
		txtTk_co.AutoValid = false;
		((TextBoxBase)txtTk_co).BackColor = SystemColors.Info;
		((TextBox)txtTk_co).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox17 = txtTk_co;
		location = new Point(153, 150);
		((Control)asTextBox17).Location = location;
		txtTk_co.LookupCodeName = "TK";
		((Control)txtTk_co).Name = "txtTk_co";
		txtTk_co.NameControl = lblTen_tk_co;
		AsTextBox asTextBox18 = txtTk_co;
		size = new Size(95, 20);
		((Control)asTextBox18).Size = size;
		((Control)txtTk_co).TabIndex = 5;
		txtTk_co.UseAutoCompleteSource = true;
		lblTk_no.AutoSize = true;
		lblTk_no.ImeMode = (ImeMode)0;
		Label obj57 = lblTk_no;
		location = new Point(6, 154);
		((Control)obj57).Location = location;
		((Control)lblTk_no).Name = "lblTk_no";
		Label obj58 = lblTk_no;
		size = new Size(36, 13);
		((Control)obj58).Size = size;
		((Control)lblTk_no).TabIndex = 1316;
		lblTk_no.Text = "TK có";
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj59 = lblTen_vt;
		location = new Point(254, 101);
		((Control)obj59).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj60 = lblTen_vt;
		size = new Size(387, 13);
		((Control)obj60).Size = size;
		((Control)lblTen_vt).TabIndex = 1315;
		lblTen_vt.TextAlign = (ContentAlignment)16;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox19 = txtMa_vt;
		location = new Point(153, 98);
		((Control)asTextBox19).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox20 = txtMa_vt;
		size = new Size(95, 20);
		((Control)asTextBox20).Size = size;
		((Control)txtMa_vt).TabIndex = 3;
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_vt.AutoSize = true;
		lblMa_vt.ImeMode = (ImeMode)0;
		Label obj61 = lblMa_vt;
		location = new Point(6, 102);
		((Control)obj61).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj62 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj62).Size = size;
		((Control)lblMa_vt).TabIndex = 1314;
		lblMa_vt.Text = "Mã vật tư";
		lblTen_Tk_vt.ImeMode = (ImeMode)0;
		Label obj63 = lblTen_Tk_vt;
		location = new Point(254, 127);
		((Control)obj63).Location = location;
		((Control)lblTen_Tk_vt).Name = "lblTen_Tk_vt";
		Label obj64 = lblTen_Tk_vt;
		size = new Size(387, 13);
		((Control)obj64).Size = size;
		((Control)lblTen_Tk_vt).TabIndex = 1313;
		lblTen_Tk_vt.TextAlign = (ContentAlignment)16;
		((TextBox)txtTk_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk_vt.AutoLookup = true;
		txtTk_vt.AutoValid = false;
		((TextBoxBase)txtTk_vt).BackColor = SystemColors.Info;
		((TextBox)txtTk_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox21 = txtTk_vt;
		location = new Point(153, 124);
		((Control)asTextBox21).Location = location;
		txtTk_vt.LookupCodeName = "TK";
		((Control)txtTk_vt).Name = "txtTk_vt";
		txtTk_vt.NameControl = lblTen_Tk_vt;
		AsTextBox asTextBox22 = txtTk_vt;
		size = new Size(95, 20);
		((Control)asTextBox22).Size = size;
		((Control)txtTk_vt).TabIndex = 4;
		txtTk_vt.UseAutoCompleteSource = true;
		lblTk_vt.AutoSize = true;
		lblTk_vt.ImeMode = (ImeMode)0;
		Label obj65 = lblTk_vt;
		location = new Point(6, 128);
		((Control)obj65).Location = location;
		((Control)lblTk_vt).Name = "lblTk_vt";
		Label obj66 = lblTk_vt;
		size = new Size(36, 13);
		((Control)obj66).Size = size;
		((Control)lblTk_vt).TabIndex = 1312;
		lblTk_vt.Text = "TK nợ";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(689, 543);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmInVchIN3Find";
		((Form)this).Text = "Tìm kiếm";
		((Control)gbPh).ResumeLayout(false);
		((Control)gbPh).PerformLayout();
		((Control)gbCt).ResumeLayout(false);
		((Control)gbCt).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmInVchIN2Find_Load(object sender, EventArgs e)
	{
		_datasource = AsiaErp.Framework.Environment.GetDmMagd(base.MyVoucherInfo.voucher_code);
		if (_datasource != null && _datasource.Count != 0 && 0 == 0)
		{
			oAll.ma_ct = base.MyVoucherInfo.voucher_code;
			oAll.ma_gd = "";
			oAll.mo_ta = AsiaErp.Framework.Environment.getLangFrameworkResX("#BASEVOUCHER_ALL_TEXT");
			if (!_datasource.Contains(oAll))
			{
				_datasource.Insert(0, oAll);
			}
			cboMa_gd.DataSource = _datasource;
			((ListControl)cboMa_gd).ValueMember = "ma_gd";
			((ListControl)cboMa_gd).DisplayMember = "mo_ta";
			cboMa_gd.SelectedIndex = 0;
		}
	}

	private void frmInVchIN2Find_FormClosing(object sender, FormClosingEventArgs e)
	{
		if ((_datasource != null && _datasource.Contains(oAll)) ? true : false)
		{
			_datasource.Remove(oAll);
		}
	}
}
