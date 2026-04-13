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
public class frmInVchIN5Find : frmVoucherFind
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

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("lblDien_giai")]
	private Label _lblDien_giai;

	[AccessedThroughProperty("lblMa_gd")]
	private Label _lblMa_gd;

	[AccessedThroughProperty("cboMa_gd")]
	private ComboBox _cboMa_gd;

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("txtMa_Lo")]
	private AsTextBox _txtMa_Lo;

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

	[AccessedThroughProperty("txtTk_vt")]
	private AsTextBox _txtTk_vt;

	[AccessedThroughProperty("lblTk_no")]
	private Label _lblTk_no;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("txtMa_Kho")]
	private AsTextBox _txtMa_Kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("lblTen_Tk_vt")]
	private Label _lblTen_Tk_vt;

	[AccessedThroughProperty("txtTk_no")]
	private AsTextBox _txtTk_no;

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

	internal virtual AsTextBox txtMa_Lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Lo = value;
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

	internal virtual Label lblTen_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kho = value;
		}
	}

	internal virtual AsTextBox txtMa_Kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Kho = value;
		}
	}

	internal virtual Label lblMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kho = value;
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

	internal virtual AsTextBox txtTk_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_no = value;
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

	public frmInVchIN5Find()
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
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
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
		//IL_1d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3c: Expected O, but got Unknown
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		lblMa_Kh = new Label();
		lblNguoi_Gd = new Label();
		txtNguoi_Gd = new TextBox();
		txtDien_giai = new TextBox();
		lblDien_giai = new Label();
		lblMa_gd = new Label();
		cboMa_gd = new ComboBox();
		lblTen_lo = new Label();
		txtMa_Lo = new AsTextBox();
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
		txtTk_vt = new AsTextBox();
		lblTk_no = new Label();
		lblTen_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		lblTen_kho = new Label();
		txtMa_Kho = new AsTextBox();
		lblMa_kho = new Label();
		lblTen_Tk_vt = new Label();
		txtTk_no = new AsTextBox();
		lblTk_vt = new Label();
		((Control)gbPh).SuspendLayout();
		((Control)gbCt).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 475);
		((Control)obj).Location = location;
		Button obj2 = cmdOk;
		location = new Point(12, 475);
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
		Size size = new Size(666, 206);
		((Control)obj3).Size = size;
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblNgay_Ct1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtNgay_Ct1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblNgay_Ct2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtNgay_Ct2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblSo_Ct1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblSo_Ct2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtSo_Ct1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtSo_Ct2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblSo_tien1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtSo_tien1, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)lblSo_tien2, 0);
		((Control)gbPh).Controls.SetChildIndex((Control)(object)txtSo_tien2, 0);
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
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Lo);
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
		((Control)gbCt).Controls.Add((Control)(object)txtTk_vt);
		((Control)gbCt).Controls.Add((Control)(object)lblTk_no);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_vt);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_vt);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_kho);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Kho);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_kho);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Tk_vt);
		((Control)gbCt).Controls.Add((Control)(object)txtTk_no);
		((Control)gbCt).Controls.Add((Control)(object)lblTk_vt);
		GroupBox obj4 = gbCt;
		location = new Point(12, 216);
		((Control)obj4).Location = location;
		GroupBox obj5 = gbCt;
		size = new Size(666, 253);
		((Control)obj5).Size = size;
		TextBox obj6 = txtSo_Ct1;
		location = new Point(158, 45);
		((Control)obj6).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct2;
		location = new Point(338, 20);
		((Control)asMaskedTextBox).Location = location;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_Ct1;
		location = new Point(158, 19);
		((Control)asMaskedTextBox2).Location = location;
		TextBox obj7 = txtSo_Ct2;
		location = new Point(338, 45);
		((Control)obj7).Location = location;
		Label obj8 = lblSo_Ct2;
		location = new Point(269, 49);
		((Control)obj8).Location = location;
		Label obj9 = lblNgay_Ct2;
		location = new Point(269, 22);
		((Control)obj9).Location = location;
		Label obj10 = lblSo_tien2;
		location = new Point(271, 74);
		((Control)obj10).Location = location;
		txtSo_tien1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtSo_tien1;
		location = new Point(158, 71);
		((Control)asTextNumeric).Location = location;
		txtSo_tien1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSo_tien1).Tag = "t_tien_nt";
		txtSo_tien1.Type = Commons.NumericType.ORTHER_;
		txtSo_tien2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric2 = txtSo_tien2;
		location = new Point(338, 71);
		((Control)asTextNumeric2).Location = location;
		txtSo_tien2.SpecialType = Commons.NumericSpecialType.Other;
		txtSo_tien2.Type = Commons.NumericType.ORTHER_;
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj11 = lblTen_Kh;
		location = new Point(262, 127);
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
		location = new Point(158, 124);
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
		location = new Point(158, 150);
		((Control)obj17).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj18 = txtNguoi_Gd;
		size = new Size(163, 20);
		((Control)obj18).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 8;
		txtDien_giai.AutoCompleteMode = (AutoCompleteMode)1;
		txtDien_giai.AutoCompleteSource = (AutoCompleteSource)7;
		TextBox obj19 = txtDien_giai;
		location = new Point(158, 176);
		((Control)obj19).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj20 = txtDien_giai;
		size = new Size(488, 20);
		((Control)obj20).Size = size;
		((Control)txtDien_giai).TabIndex = 9;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj21 = lblDien_giai;
		location = new Point(6, 180);
		((Control)obj21).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj22 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj22).Size = size;
		((Control)lblDien_giai).TabIndex = 235;
		lblDien_giai.Text = "Diễn giải";
		lblMa_gd.AutoSize = true;
		lblMa_gd.ImeMode = (ImeMode)0;
		Label obj23 = lblMa_gd;
		location = new Point(5, 100);
		((Control)obj23).Location = location;
		((Control)lblMa_gd).Name = "lblMa_gd";
		Label obj24 = lblMa_gd;
		size = new Size(79, 13);
		((Control)obj24).Size = size;
		((Control)lblMa_gd).TabIndex = 241;
		lblMa_gd.Text = "Loại phiếu xuất";
		lblMa_gd.TextAlign = (ContentAlignment)16;
		cboMa_gd.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMa_gd).FormattingEnabled = true;
		ComboBox obj25 = cboMa_gd;
		location = new Point(158, 97);
		((Control)obj25).Location = location;
		((Control)cboMa_gd).Name = "cboMa_gd";
		ComboBox obj26 = cboMa_gd;
		size = new Size(163, 21);
		((Control)obj26).Size = size;
		((Control)cboMa_gd).TabIndex = 6;
		Label obj27 = lblTen_lo;
		location = new Point(259, 47);
		((Control)obj27).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj28 = lblTen_lo;
		size = new Size(387, 13);
		((Control)obj28).Size = size;
		((Control)lblTen_lo).TabIndex = 1302;
		txtMa_Lo.AutoLookup = true;
		txtMa_Lo.AutoValid = false;
		((TextBoxBase)txtMa_Lo).BackColor = SystemColors.Info;
		((TextBox)txtMa_Lo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_Lo;
		location = new Point(158, 43);
		((Control)asTextBox3).Location = location;
		txtMa_Lo.LookupCodeName = "MA_LO";
		((Control)txtMa_Lo).Name = "txtMa_Lo";
		txtMa_Lo.NameControl = lblTen_lo;
		AsTextBox asTextBox4 = txtMa_Lo;
		size = new Size(95, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_Lo).TabIndex = 1;
		((Control)txtMa_Lo).Tag = "MA_LO";
		txtMa_Lo.UseAutoCompleteSource = true;
		lblMaLo.AutoSize = true;
		Label obj29 = lblMaLo;
		location = new Point(11, 47);
		((Control)obj29).Location = location;
		((Control)lblMaLo).Name = "lblMaLo";
		Label obj30 = lblMaLo;
		size = new Size(33, 13);
		((Control)obj30).Size = size;
		((Control)lblMaLo).TabIndex = 1303;
		lblMaLo.Text = "Mã lô";
		lblTen_Spct.ImeMode = (ImeMode)0;
		Label obj31 = lblTen_Spct;
		location = new Point(259, 228);
		((Control)obj31).Location = location;
		((Control)lblTen_Spct).Name = "lblTen_Spct";
		Label obj32 = lblTen_Spct;
		size = new Size(387, 13);
		((Control)obj32).Size = size;
		((Control)lblTen_Spct).TabIndex = 1301;
		lblTen_Spct.TextAlign = (ContentAlignment)16;
		txtMa_Spct.AutoLookup = true;
		txtMa_Spct.AutoValid = false;
		((TextBoxBase)txtMa_Spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_Spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_Spct;
		location = new Point(158, 225);
		((Control)asTextBox5).Location = location;
		txtMa_Spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_Spct).Name = "txtMa_Spct";
		txtMa_Spct.NameControl = lblTen_Spct;
		AsTextBox asTextBox6 = txtMa_Spct;
		size = new Size(95, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_Spct).TabIndex = 8;
		txtMa_Spct.UseAutoCompleteSource = true;
		lblMa_Spct.AutoSize = true;
		lblMa_Spct.ImeMode = (ImeMode)0;
		Label obj33 = lblMa_Spct;
		location = new Point(11, 232);
		((Control)obj33).Location = location;
		((Control)lblMa_Spct).Name = "lblMa_Spct";
		Label obj34 = lblMa_Spct;
		size = new Size(53, 13);
		((Control)obj34).Size = size;
		((Control)lblMa_Spct).TabIndex = 1300;
		lblMa_Spct.Text = "Mã SPCT";
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj35 = lblTen_Hd;
		location = new Point(259, 150);
		((Control)obj35).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj36 = lblTen_Hd;
		size = new Size(387, 13);
		((Control)obj36).Size = size;
		((Control)lblTen_Hd).TabIndex = 1299;
		lblTen_Hd.TextAlign = (ContentAlignment)16;
		txtMa_Hd.AutoLookup = true;
		txtMa_Hd.AutoValid = false;
		((TextBoxBase)txtMa_Hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_Hd;
		location = new Point(158, 147);
		((Control)asTextBox7).Location = location;
		txtMa_Hd.LookupCodeName = "MA_HD";
		((Control)txtMa_Hd).Name = "txtMa_Hd";
		txtMa_Hd.NameControl = lblTen_Hd;
		AsTextBox asTextBox8 = txtMa_Hd;
		size = new Size(95, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_Hd).TabIndex = 5;
		txtMa_Hd.UseAutoCompleteSource = true;
		lblMa_Hd.AutoSize = true;
		lblMa_Hd.ImeMode = (ImeMode)0;
		Label obj37 = lblMa_Hd;
		location = new Point(11, 154);
		((Control)obj37).Location = location;
		((Control)lblMa_Hd).Name = "lblMa_Hd";
		Label obj38 = lblMa_Hd;
		size = new Size(71, 13);
		((Control)obj38).Size = size;
		((Control)lblMa_Hd).TabIndex = 1298;
		lblMa_Hd.Text = "Mã hợp đồng";
		lblTen_Phi.ImeMode = (ImeMode)0;
		Label obj39 = lblTen_Phi;
		location = new Point(259, 202);
		((Control)obj39).Location = location;
		((Control)lblTen_Phi).Name = "lblTen_Phi";
		Label obj40 = lblTen_Phi;
		size = new Size(387, 13);
		((Control)obj40).Size = size;
		((Control)lblTen_Phi).TabIndex = 1297;
		lblTen_Phi.TextAlign = (ContentAlignment)16;
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_Phi;
		location = new Point(158, 199);
		((Control)asTextBox9).Location = location;
		txtMa_Phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		txtMa_Phi.NameControl = lblTen_Phi;
		AsTextBox asTextBox10 = txtMa_Phi;
		size = new Size(95, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_Phi).TabIndex = 7;
		txtMa_Phi.UseAutoCompleteSource = true;
		lblMa_Phi.AutoSize = true;
		lblMa_Phi.ImeMode = (ImeMode)0;
		Label obj41 = lblMa_Phi;
		location = new Point(11, 206);
		((Control)obj41).Location = location;
		((Control)lblMa_Phi).Name = "lblMa_Phi";
		Label obj42 = lblMa_Phi;
		size = new Size(41, 13);
		((Control)obj42).Size = size;
		((Control)lblMa_Phi).TabIndex = 1296;
		lblMa_Phi.Text = "Mã phí";
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj43 = lblTen_Bp;
		location = new Point(259, 176);
		((Control)obj43).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj44 = lblTen_Bp;
		size = new Size(387, 13);
		((Control)obj44).Size = size;
		((Control)lblTen_Bp).TabIndex = 1295;
		lblTen_Bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtMa_Bp;
		location = new Point(158, 173);
		((Control)asTextBox11).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox12 = txtMa_Bp;
		size = new Size(95, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtMa_Bp).TabIndex = 6;
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_Bp.AutoSize = true;
		lblMa_Bp.ImeMode = (ImeMode)0;
		Label obj45 = lblMa_Bp;
		location = new Point(11, 180);
		((Control)obj45).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj46 = lblMa_Bp;
		size = new Size(64, 13);
		((Control)obj46).Size = size;
		((Control)lblMa_Bp).TabIndex = 1294;
		lblMa_Bp.Text = "Mã bộ phận";
		lblTen_tk_co.ImeMode = (ImeMode)0;
		Label obj47 = lblTen_tk_co;
		location = new Point(259, 124);
		((Control)obj47).Location = location;
		((Control)lblTen_tk_co).Name = "lblTen_tk_co";
		Label obj48 = lblTen_tk_co;
		size = new Size(387, 13);
		((Control)obj48).Size = size;
		((Control)lblTen_tk_co).TabIndex = 1293;
		lblTen_tk_co.TextAlign = (ContentAlignment)16;
		((TextBox)txtTk_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk_vt.AutoLookup = true;
		txtTk_vt.AutoValid = false;
		((TextBoxBase)txtTk_vt).BackColor = SystemColors.Info;
		((TextBox)txtTk_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox13 = txtTk_vt;
		location = new Point(158, 121);
		((Control)asTextBox13).Location = location;
		txtTk_vt.LookupCodeName = "TK";
		((Control)txtTk_vt).Name = "txtTk_vt";
		txtTk_vt.NameControl = lblTen_tk_co;
		AsTextBox asTextBox14 = txtTk_vt;
		size = new Size(95, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtTk_vt).TabIndex = 4;
		txtTk_vt.UseAutoCompleteSource = true;
		lblTk_no.AutoSize = true;
		lblTk_no.ImeMode = (ImeMode)0;
		Label obj49 = lblTk_no;
		location = new Point(11, 128);
		((Control)obj49).Location = location;
		((Control)lblTk_no).Name = "lblTk_no";
		Label obj50 = lblTk_no;
		size = new Size(36, 13);
		((Control)obj50).Size = size;
		((Control)lblTk_no).TabIndex = 1292;
		lblTk_no.Text = "TK có";
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj51 = lblTen_vt;
		location = new Point(259, 72);
		((Control)obj51).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj52 = lblTen_vt;
		size = new Size(387, 13);
		((Control)obj52).Size = size;
		((Control)lblTen_vt).TabIndex = 1291;
		lblTen_vt.TextAlign = (ContentAlignment)16;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox15 = txtMa_vt;
		location = new Point(158, 69);
		((Control)asTextBox15).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox16 = txtMa_vt;
		size = new Size(95, 20);
		((Control)asTextBox16).Size = size;
		((Control)txtMa_vt).TabIndex = 2;
		txtMa_vt.UseAutoCompleteSource = true;
		lblMa_vt.AutoSize = true;
		lblMa_vt.ImeMode = (ImeMode)0;
		Label obj53 = lblMa_vt;
		location = new Point(11, 76);
		((Control)obj53).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj54 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj54).Size = size;
		((Control)lblMa_vt).TabIndex = 1290;
		lblMa_vt.Text = "Mã vật tư";
		lblTen_kho.ImeMode = (ImeMode)0;
		Label obj55 = lblTen_kho;
		location = new Point(259, 21);
		((Control)obj55).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj56 = lblTen_kho;
		size = new Size(387, 13);
		((Control)obj56).Size = size;
		((Control)lblTen_kho).TabIndex = 1289;
		lblTen_kho.TextAlign = (ContentAlignment)16;
		txtMa_Kho.AutoLookup = true;
		txtMa_Kho.AutoValid = false;
		((TextBoxBase)txtMa_Kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox17 = txtMa_Kho;
		location = new Point(158, 17);
		((Control)asTextBox17).Location = location;
		txtMa_Kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_Kho).Name = "txtMa_Kho";
		txtMa_Kho.NameControl = lblTen_kho;
		AsTextBox asTextBox18 = txtMa_Kho;
		size = new Size(95, 20);
		((Control)asTextBox18).Size = size;
		((Control)txtMa_Kho).TabIndex = 0;
		txtMa_Kho.UseAutoCompleteSource = true;
		lblMa_kho.AutoSize = true;
		lblMa_kho.ImeMode = (ImeMode)0;
		Label obj57 = lblMa_kho;
		location = new Point(11, 21);
		((Control)obj57).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj58 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj58).Size = size;
		((Control)lblMa_kho).TabIndex = 1288;
		lblMa_kho.Text = "Mã kho";
		lblTen_Tk_vt.ImeMode = (ImeMode)0;
		Label obj59 = lblTen_Tk_vt;
		location = new Point(259, 98);
		((Control)obj59).Location = location;
		((Control)lblTen_Tk_vt).Name = "lblTen_Tk_vt";
		Label obj60 = lblTen_Tk_vt;
		size = new Size(387, 13);
		((Control)obj60).Size = size;
		((Control)lblTen_Tk_vt).TabIndex = 1287;
		lblTen_Tk_vt.TextAlign = (ContentAlignment)16;
		((TextBox)txtTk_no).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk_no.AutoLookup = true;
		txtTk_no.AutoValid = false;
		((TextBoxBase)txtTk_no).BackColor = SystemColors.Info;
		((TextBox)txtTk_no).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox19 = txtTk_no;
		location = new Point(158, 95);
		((Control)asTextBox19).Location = location;
		txtTk_no.LookupCodeName = "TK";
		((Control)txtTk_no).Name = "txtTk_no";
		txtTk_no.NameControl = lblTen_Tk_vt;
		AsTextBox asTextBox20 = txtTk_no;
		size = new Size(95, 20);
		((Control)asTextBox20).Size = size;
		((Control)txtTk_no).TabIndex = 3;
		txtTk_no.UseAutoCompleteSource = true;
		lblTk_vt.AutoSize = true;
		lblTk_vt.ImeMode = (ImeMode)0;
		Label obj61 = lblTk_vt;
		location = new Point(11, 102);
		((Control)obj61).Location = location;
		((Control)lblTk_vt).Name = "lblTk_vt";
		Label obj62 = lblTk_vt;
		size = new Size(36, 13);
		((Control)obj62).Size = size;
		((Control)lblTk_vt).TabIndex = 1286;
		lblTk_vt.Text = "TK nợ";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(690, 510);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		((Control)this).Name = "frmInVchIN5Find";
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
