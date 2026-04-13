using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using AsiaErp.POUtilities;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmPOVchPO4FindPO2PO3PO7 : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("gbPh")]
	private GroupBox _gbPh;

	[AccessedThroughProperty("gbCt")]
	private GroupBox _gbCt;

	[AccessedThroughProperty("txtSo_Ct1")]
	private TextBox _txtSo_Ct1;

	[AccessedThroughProperty("lblSo_Ct2")]
	private Label _lblSo_Ct2;

	[AccessedThroughProperty("lblSo_Ct1")]
	private Label _lblSo_Ct1;

	[AccessedThroughProperty("txtNgay_Ct2")]
	private AsMaskedTextBox _txtNgay_Ct2;

	[AccessedThroughProperty("lblNgay_Ct2")]
	private Label _lblNgay_Ct2;

	[AccessedThroughProperty("txtNgay_Ct1")]
	private AsMaskedTextBox _txtNgay_Ct1;

	[AccessedThroughProperty("lblNgay_Ct1")]
	private Label _lblNgay_Ct1;

	[AccessedThroughProperty("txtSo_Ct2")]
	private TextBox _txtSo_Ct2;

	[AccessedThroughProperty("lblNguoi_Gd")]
	private Label _lblNguoi_Gd;

	[AccessedThroughProperty("txtNguoi_Gd")]
	private TextBox _txtNguoi_Gd;

	[AccessedThroughProperty("lblTen_Hd")]
	private Label _lblTen_Hd;

	[AccessedThroughProperty("txtMa_Hd")]
	private AsTextBox _txtMa_Hd;

	[AccessedThroughProperty("lblMa_Hd")]
	private Label _lblMa_Hd;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("lblDien_giai")]
	private Label _lblDien_giai;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

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

	[AccessedThroughProperty("txtTk_vt")]
	private AsTextBox _txtTk_vt;

	[AccessedThroughProperty("lblTk_vt")]
	private Label _lblTk_vt;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("cboLoai_Ct")]
	private ComboBox _cboLoai_Ct;

	internal DataTable f_oTblPh;

	internal DataTable f_oTblCt;

	private bool f_isOk;

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

	protected virtual Button cmdOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOk_Click;
			if (_cmdOk != null)
			{
				((Control)_cmdOk).Click -= eventHandler;
			}
			_cmdOk = value;
			if (_cmdOk != null)
			{
				((Control)_cmdOk).Click += eventHandler;
			}
		}
	}

	protected virtual GroupBox gbPh
	{
		[DebuggerNonUserCode]
		get
		{
			return _gbPh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_gbPh = value;
		}
	}

	protected virtual GroupBox gbCt
	{
		[DebuggerNonUserCode]
		get
		{
			return _gbCt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_gbCt = value;
		}
	}

	internal virtual TextBox txtSo_Ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_Ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_Ct1 = value;
		}
	}

	internal virtual Label lblSo_Ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_Ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_Ct2 = value;
		}
	}

	internal virtual Label lblSo_Ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_Ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_Ct1 = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_Ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_Ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_Ct2 = value;
		}
	}

	internal virtual Label lblNgay_Ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_Ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_Ct2 = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_Ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_Ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_Ct1 = value;
		}
	}

	internal virtual Label lblNgay_Ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_Ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_Ct1 = value;
		}
	}

	internal virtual TextBox txtSo_Ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_Ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_Ct2 = value;
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

	internal virtual ComboBox cboLoai_Ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_Ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_Ct = value;
		}
	}

	protected internal bool SearchOK => f_isOk;

	internal DataTable PhTable => f_oTblPh;

	internal DataTable CtTable => f_oTblCt;

	public frmPOVchPO4FindPO2PO3PO7()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		((Form)this).Load += frmVoucherFind_Load;
		((Control)this).KeyDown += new KeyEventHandler(frmVoucherFind_KeyDown);
		__ENCAddToList(this);
		f_isOk = false;
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
		if (disposing)
		{
			ReleaseMyResources();
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
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
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
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmPOVchPO4FindPO2PO3PO7));
		cmdCancel = new Button();
		cmdOk = new Button();
		gbPh = new GroupBox();
		Label1 = new Label();
		cboLoai_Ct = new ComboBox();
		lblNguoi_Gd = new Label();
		txtNguoi_Gd = new TextBox();
		lblTen_Hd = new Label();
		txtMa_Hd = new AsTextBox();
		lblMa_Hd = new Label();
		lblTen_Kh = new Label();
		txtMa_Kh = new AsTextBox();
		txtDien_giai = new TextBox();
		lblDien_giai = new Label();
		lblMa_Kh = new Label();
		txtSo_Ct2 = new TextBox();
		txtSo_Ct1 = new TextBox();
		lblSo_Ct2 = new Label();
		lblSo_Ct1 = new Label();
		txtNgay_Ct2 = new AsMaskedTextBox();
		lblNgay_Ct2 = new Label();
		txtNgay_Ct1 = new AsMaskedTextBox();
		lblNgay_Ct1 = new Label();
		gbCt = new GroupBox();
		lblTen_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblMa_vt = new Label();
		lblTen_kho = new Label();
		txtMa_Kho = new AsTextBox();
		lblMa_kho = new Label();
		lblTen_Tk_vt = new Label();
		txtTk_vt = new AsTextBox();
		lblTk_vt = new Label();
		((Control)gbPh).SuspendLayout();
		((Control)gbCt).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		((ButtonBase)cmdCancel).Image = (Image)componentResourceManager.GetObject("cmdCancel.Image");
		((ButtonBase)cmdCancel).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdCancel).ImeMode = (ImeMode)0;
		Button obj = cmdCancel;
		Point location = new Point(93, 319);
		((Control)obj).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj2 = cmdCancel;
		Size size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)cmdCancel).TabIndex = 3;
		((ButtonBase)cmdCancel).Text = "&Quay ra";
		((ButtonBase)cmdCancel).TextAlign = (ContentAlignment)64;
		((Control)cmdOk).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdOk).Image = (Image)componentResourceManager.GetObject("cmdOk.Image");
		((ButtonBase)cmdOk).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdOk).ImeMode = (ImeMode)0;
		Button obj3 = cmdOk;
		location = new Point(12, 319);
		((Control)obj3).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		Button obj4 = cmdOk;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)cmdOk).TabIndex = 2;
		((ButtonBase)cmdOk).Text = "&Nhận";
		((ButtonBase)cmdOk).TextAlign = (ContentAlignment)64;
		((Control)gbPh).Anchor = (AnchorStyles)13;
		((Control)gbPh).Controls.Add((Control)(object)Label1);
		((Control)gbPh).Controls.Add((Control)(object)cboLoai_Ct);
		((Control)gbPh).Controls.Add((Control)(object)lblNguoi_Gd);
		((Control)gbPh).Controls.Add((Control)(object)txtNguoi_Gd);
		((Control)gbPh).Controls.Add((Control)(object)lblTen_Hd);
		((Control)gbPh).Controls.Add((Control)(object)txtMa_Hd);
		((Control)gbPh).Controls.Add((Control)(object)lblMa_Hd);
		((Control)gbPh).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbPh).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbPh).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbPh).Controls.Add((Control)(object)lblDien_giai);
		((Control)gbPh).Controls.Add((Control)(object)lblMa_Kh);
		((Control)gbPh).Controls.Add((Control)(object)txtSo_Ct2);
		((Control)gbPh).Controls.Add((Control)(object)txtSo_Ct1);
		((Control)gbPh).Controls.Add((Control)(object)lblSo_Ct2);
		((Control)gbPh).Controls.Add((Control)(object)lblSo_Ct1);
		((Control)gbPh).Controls.Add((Control)(object)txtNgay_Ct2);
		((Control)gbPh).Controls.Add((Control)(object)lblNgay_Ct2);
		((Control)gbPh).Controls.Add((Control)(object)txtNgay_Ct1);
		((Control)gbPh).Controls.Add((Control)(object)lblNgay_Ct1);
		GroupBox obj5 = gbPh;
		location = new Point(12, 4);
		((Control)obj5).Location = location;
		((Control)gbPh).Name = "gbPh";
		GroupBox obj6 = gbPh;
		size = new Size(584, 205);
		((Control)obj6).Size = size;
		((Control)gbPh).TabIndex = 0;
		gbPh.TabStop = false;
		gbPh.Text = "Thông tin chung";
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(6, 22);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(72, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 247;
		Label1.Text = "Loại chứng từ";
		cboLoai_Ct.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_Ct).FormattingEnabled = true;
		cboLoai_Ct.Items.AddRange(new object[4] { "Tất cả", "Phiếu nhập", "Hoá đơn trong nước", "Hoá đơn nhập khẩu" });
		ComboBox obj7 = cboLoai_Ct;
		location = new Point(105, 19);
		((Control)obj7).Location = location;
		((Control)cboLoai_Ct).Name = "cboLoai_Ct";
		ComboBox obj8 = cboLoai_Ct;
		size = new Size(228, 21);
		((Control)obj8).Size = size;
		((Control)cboLoai_Ct).TabIndex = 0;
		lblNguoi_Gd.ImeMode = (ImeMode)0;
		Label obj9 = lblNguoi_Gd;
		location = new Point(6, 126);
		((Control)obj9).Location = location;
		((Control)lblNguoi_Gd).Name = "lblNguoi_Gd";
		Label obj10 = lblNguoi_Gd;
		size = new Size(98, 14);
		((Control)obj10).Size = size;
		((Control)lblNguoi_Gd).TabIndex = 242;
		lblNguoi_Gd.Text = "Người giao dịch";
		TextBox obj11 = txtNguoi_Gd;
		location = new Point(105, 123);
		((Control)obj11).Location = location;
		((TextBoxBase)txtNguoi_Gd).MaxLength = 30;
		((Control)txtNguoi_Gd).Name = "txtNguoi_Gd";
		TextBox obj12 = txtNguoi_Gd;
		size = new Size(128, 20);
		((Control)obj12).Size = size;
		((Control)txtNguoi_Gd).TabIndex = 6;
		lblTen_Hd.ImeMode = (ImeMode)0;
		Label obj13 = lblTen_Hd;
		location = new Point(193, 152);
		((Control)obj13).Location = location;
		((Control)lblTen_Hd).Name = "lblTen_Hd";
		Label obj14 = lblTen_Hd;
		size = new Size(366, 13);
		((Control)obj14).Size = size;
		((Control)lblTen_Hd).TabIndex = 244;
		lblTen_Hd.TextAlign = (ContentAlignment)16;
		txtMa_Hd.AutoLookup = true;
		txtMa_Hd.AutoValid = false;
		((TextBoxBase)txtMa_Hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_Hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_Hd;
		location = new Point(105, 149);
		((Control)asTextBox).Location = location;
		txtMa_Hd.LookupCodeName = "MA_HD";
		((Control)txtMa_Hd).Name = "txtMa_Hd";
		txtMa_Hd.NameControl = lblTen_Hd;
		AsTextBox asTextBox2 = txtMa_Hd;
		size = new Size(82, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Hd).TabIndex = 7;
		lblMa_Hd.AutoSize = true;
		lblMa_Hd.ImeMode = (ImeMode)0;
		Label obj15 = lblMa_Hd;
		location = new Point(6, 152);
		((Control)obj15).Location = location;
		((Control)lblMa_Hd).Name = "lblMa_Hd";
		Label obj16 = lblMa_Hd;
		size = new Size(55, 13);
		((Control)obj16).Size = size;
		((Control)lblMa_Hd).TabIndex = 243;
		lblMa_Hd.Text = "Hợp đồng";
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj17 = lblTen_Kh;
		location = new Point(193, 100);
		((Control)obj17).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj18 = lblTen_Kh;
		size = new Size(366, 13);
		((Control)obj18).Size = size;
		((Control)lblTen_Kh).TabIndex = 241;
		((TextBox)txtMa_Kh).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = false;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_Kh;
		location = new Point(105, 97);
		((Control)asTextBox3).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		AsTextBox asTextBox4 = txtMa_Kh;
		size = new Size(82, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_Kh).TabIndex = 5;
		txtDien_giai.AutoCompleteMode = (AutoCompleteMode)3;
		txtDien_giai.AutoCompleteSource = (AutoCompleteSource)4;
		TextBox obj19 = txtDien_giai;
		location = new Point(105, 175);
		((Control)obj19).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj20 = txtDien_giai;
		size = new Size(454, 20);
		((Control)obj20).Size = size;
		((Control)txtDien_giai).TabIndex = 8;
		lblDien_giai.AutoSize = true;
		lblDien_giai.ImeMode = (ImeMode)0;
		Label obj21 = lblDien_giai;
		location = new Point(6, 178);
		((Control)obj21).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj22 = lblDien_giai;
		size = new Size(48, 13);
		((Control)obj22).Size = size;
		((Control)lblDien_giai).TabIndex = 245;
		lblDien_giai.Text = "Diễn giải";
		lblMa_Kh.AutoSize = true;
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj23 = lblMa_Kh;
		location = new Point(6, 100);
		((Control)obj23).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj24 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj24).Size = size;
		((Control)lblMa_Kh).TabIndex = 240;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		TextBox obj25 = txtSo_Ct2;
		location = new Point(251, 72);
		((Control)obj25).Location = location;
		((Control)txtSo_Ct2).Name = "txtSo_Ct2";
		TextBox obj26 = txtSo_Ct2;
		size = new Size(82, 20);
		((Control)obj26).Size = size;
		((Control)txtSo_Ct2).TabIndex = 4;
		TextBox obj27 = txtSo_Ct1;
		location = new Point(105, 72);
		((Control)obj27).Location = location;
		((Control)txtSo_Ct1).Name = "txtSo_Ct1";
		TextBox obj28 = txtSo_Ct1;
		size = new Size(82, 20);
		((Control)obj28).Size = size;
		((Control)txtSo_Ct1).TabIndex = 3;
		lblSo_Ct2.AutoSize = true;
		Label obj29 = lblSo_Ct2;
		location = new Point(193, 75);
		((Control)obj29).Location = location;
		((Control)lblSo_Ct2).Name = "lblSo_Ct2";
		Label obj30 = lblSo_Ct2;
		size = new Size(40, 13);
		((Control)obj30).Size = size;
		((Control)lblSo_Ct2).TabIndex = 5;
		lblSo_Ct2.Text = "đến số";
		lblSo_Ct1.AutoSize = true;
		Label obj31 = lblSo_Ct1;
		location = new Point(6, 75);
		((Control)obj31).Location = location;
		((Control)lblSo_Ct1).Name = "lblSo_Ct1";
		Label obj32 = lblSo_Ct1;
		size = new Size(64, 13);
		((Control)obj32).Size = size;
		((Control)lblSo_Ct1).TabIndex = 4;
		lblSo_Ct1.Text = "Chứng từ số";
		txtNgay_Ct2.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_Ct2).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct2;
		location = new Point(251, 47);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_Ct2).Mask = "##/##/####";
		((Control)txtNgay_Ct2).Name = "txtNgay_Ct2";
		((MaskedTextBox)txtNgay_Ct2).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_Ct2;
		size = new Size(82, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_Ct2).TabIndex = 2;
		((MaskedTextBox)txtNgay_Ct2).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_Ct2;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		lblNgay_Ct2.AutoSize = true;
		Label obj33 = lblNgay_Ct2;
		location = new Point(193, 49);
		((Control)obj33).Location = location;
		((Control)lblNgay_Ct2).Name = "lblNgay_Ct2";
		Label obj34 = lblNgay_Ct2;
		size = new Size(52, 13);
		((Control)obj34).Size = size;
		((Control)lblNgay_Ct2).TabIndex = 2;
		lblNgay_Ct2.Text = "đến ngày";
		txtNgay_Ct1.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_Ct1).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_Ct1;
		location = new Point(105, 46);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_Ct1).Mask = "##/##/####";
		((Control)txtNgay_Ct1).Name = "txtNgay_Ct1";
		((MaskedTextBox)txtNgay_Ct1).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_Ct1;
		size = new Size(82, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_Ct1).TabIndex = 1;
		((MaskedTextBox)txtNgay_Ct1).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_Ct1;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		lblNgay_Ct1.AutoSize = true;
		Label obj35 = lblNgay_Ct1;
		location = new Point(6, 50);
		((Control)obj35).Location = location;
		((Control)lblNgay_Ct1).Name = "lblNgay_Ct1";
		Label obj36 = lblNgay_Ct1;
		size = new Size(76, 13);
		((Control)obj36).Size = size;
		((Control)lblNgay_Ct1).TabIndex = 0;
		lblNgay_Ct1.Text = "Chứng từ ngày";
		((Control)gbCt).Anchor = (AnchorStyles)14;
		((Control)gbCt).Controls.Add((Control)(object)lblTen_vt);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_vt);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_kho);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_Kho);
		((Control)gbCt).Controls.Add((Control)(object)lblMa_kho);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_Tk_vt);
		((Control)gbCt).Controls.Add((Control)(object)txtTk_vt);
		((Control)gbCt).Controls.Add((Control)(object)lblTk_vt);
		GroupBox obj37 = gbCt;
		location = new Point(12, 213);
		((Control)obj37).Location = location;
		((Control)gbCt).Name = "gbCt";
		GroupBox obj38 = gbCt;
		size = new Size(584, 100);
		((Control)obj38).Size = size;
		((Control)gbCt).TabIndex = 1;
		gbCt.TabStop = false;
		gbCt.Text = "Thông tin chi tiết";
		lblTen_vt.ImeMode = (ImeMode)0;
		Label obj39 = lblTen_vt;
		location = new Point(190, 74);
		((Control)obj39).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj40 = lblTen_vt;
		size = new Size(366, 13);
		((Control)obj40).Size = size;
		((Control)lblTen_vt).TabIndex = 242;
		lblTen_vt.TextAlign = (ContentAlignment)16;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_vt;
		location = new Point(105, 45);
		((Control)asTextBox5).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox6 = txtMa_vt;
		size = new Size(82, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_vt).TabIndex = 1;
		lblMa_vt.AutoSize = true;
		lblMa_vt.ImeMode = (ImeMode)0;
		Label obj41 = lblMa_vt;
		location = new Point(6, 49);
		((Control)obj41).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj42 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj42).Size = size;
		((Control)lblMa_vt).TabIndex = 241;
		lblMa_vt.Text = "Mã vật tư";
		lblTen_kho.ImeMode = (ImeMode)0;
		Label obj43 = lblTen_kho;
		location = new Point(190, 48);
		((Control)obj43).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj44 = lblTen_kho;
		size = new Size(366, 13);
		((Control)obj44).Size = size;
		((Control)lblTen_kho).TabIndex = 240;
		lblTen_kho.TextAlign = (ContentAlignment)16;
		txtMa_Kho.AutoLookup = true;
		txtMa_Kho.AutoValid = false;
		((TextBoxBase)txtMa_Kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_Kho;
		location = new Point(105, 19);
		((Control)asTextBox7).Location = location;
		txtMa_Kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_Kho).Name = "txtMa_Kho";
		txtMa_Kho.NameControl = lblTen_kho;
		AsTextBox asTextBox8 = txtMa_Kho;
		size = new Size(82, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_Kho).TabIndex = 0;
		lblMa_kho.AutoSize = true;
		lblMa_kho.ImeMode = (ImeMode)0;
		Label obj45 = lblMa_kho;
		location = new Point(6, 23);
		((Control)obj45).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj46 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj46).Size = size;
		((Control)lblMa_kho).TabIndex = 239;
		lblMa_kho.Text = "Mã kho";
		lblTen_Tk_vt.ImeMode = (ImeMode)0;
		Label obj47 = lblTen_Tk_vt;
		location = new Point(190, 100);
		((Control)obj47).Location = location;
		((Control)lblTen_Tk_vt).Name = "lblTen_Tk_vt";
		Label obj48 = lblTen_Tk_vt;
		size = new Size(366, 13);
		((Control)obj48).Size = size;
		((Control)lblTen_Tk_vt).TabIndex = 238;
		lblTen_Tk_vt.TextAlign = (ContentAlignment)16;
		((TextBox)txtTk_vt).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk_vt.AutoLookup = true;
		txtTk_vt.AutoValid = false;
		((TextBoxBase)txtTk_vt).BackColor = SystemColors.Info;
		((TextBox)txtTk_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtTk_vt;
		location = new Point(105, 71);
		((Control)asTextBox9).Location = location;
		txtTk_vt.LookupCodeName = "TK";
		((Control)txtTk_vt).Name = "txtTk_vt";
		txtTk_vt.NameControl = lblTen_Tk_vt;
		AsTextBox asTextBox10 = txtTk_vt;
		size = new Size(82, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtTk_vt).TabIndex = 2;
		lblTk_vt.AutoSize = true;
		lblTk_vt.ImeMode = (ImeMode)0;
		Label obj49 = lblTk_vt;
		location = new Point(6, 75);
		((Control)obj49).Location = location;
		((Control)lblTk_vt).Name = "lblTk_vt";
		Label obj50 = lblTk_vt;
		size = new Size(42, 13);
		((Control)obj50).Size = size;
		((Control)lblTk_vt).TabIndex = 237;
		lblTk_vt.Text = "TK kho";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(608, 354);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)gbCt);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)gbPh);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmVoucherFindPO2PO3PO7";
		((Form)this).ShowInTaskbar = false;
		((Form)this).Text = "Chon PN/HD";
		((Control)gbPh).ResumeLayout(false);
		((Control)gbPh).PerformLayout();
		((Control)gbCt).ResumeLayout(false);
		((Control)gbCt).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void cmdOk_Click(object sender, EventArgs e)
	{
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		string text = "p.Ma_Cty='" + CompanyInformations.CompanyID + "'";
		switch (cboLoai_Ct.SelectedIndex)
		{
		case 0:
			text += " and (p.Ma_Ct='PO2' or p.Ma_Ct='PO3' or p.Ma_Ct='PO7')";
			break;
		case 1:
			text += " and p.Ma_Ct='PO2'";
			break;
		case 2:
			text += " and p.Ma_Ct='PO3'";
			break;
		case 3:
			text += " and p.Ma_Ct='PO7'";
			break;
		}
		if (Operators.ConditionalCompareObjectNotEqual(txtNgay_Ct1.Value, (object)new DateTime(599266080000000000L), false))
		{
			string text2 = text;
			DateTime dateTime = (DateTime)txtNgay_Ct1.Value;
			text = text2 + " and p.Ngay_Ct>= '" + dateTime.ToString("MM/dd/yyyy") + "'";
		}
		if (Operators.ConditionalCompareObjectNotEqual(txtNgay_Ct2.Value, (object)new DateTime(599266080000000000L), false))
		{
			string text3 = text;
			DateTime dateTime = (DateTime)txtNgay_Ct2.Value;
			text = text3 + " and p.Ngay_Ct <= '" + dateTime.ToString("MM/dd/yyyy") + "'";
		}
		if (Operators.CompareString(txtSo_Ct1.Text, "", false) != 0)
		{
			text = text + " and p.So_Ct>= '" + txtSo_Ct1.Text + "'";
		}
		if (Operators.CompareString(txtSo_Ct2.Text, "", false) != 0)
		{
			text = text + " and p.So_Ct<= '" + txtSo_Ct2.Text + "'";
		}
		if (Operators.CompareString(txtDien_giai.Text, "", false) != 0)
		{
			text = text + " and p.dien_giai like '%" + txtDien_giai.Text + "%'";
		}
		if (Operators.CompareString(((TextBox)txtMa_Kh).Text, "", false) != 0)
		{
			text = text + " and p.ma_kh like '" + ((TextBox)txtMa_Kh).Text + "%'";
		}
		if (Operators.CompareString(((TextBox)txtMa_Hd).Text, "", false) != 0)
		{
			text = text + " and p.ma_hd like '" + ((TextBox)txtMa_Hd).Text + "%'";
		}
		if (Operators.CompareString(txtNguoi_Gd.Text, "", false) != 0)
		{
			text = text + " and p.nguoi_gd like '%" + txtNguoi_Gd.Text + "%'";
		}
		if (Operators.CompareString(((TextBox)txtMa_Kho).Text, "", false) != 0)
		{
			text = text + " and p.ma_kho like '" + ((TextBox)txtMa_Kho).Text + "%'";
		}
		if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
		{
			text = text + " and p.ma_vt like '" + ((TextBox)txtMa_vt).Text + "%'";
		}
		if (Operators.CompareString(((TextBox)txtTk_vt).Text, "", false) != 0)
		{
			text = text + " and p.tk_vt like '" + ((TextBox)txtTk_vt).Text + "%'";
		}
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct1", RuntimeHelpers.GetObjectValue(txtNgay_Ct1.Value));
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct2", RuntimeHelpers.GetObjectValue(txtNgay_Ct2.Value));
		if (POCommon.POLookupPNHD4CP(text, ref f_oTblPh, ref f_oTblCt))
		{
			f_isOk = true;
			((Form)this).Close();
		}
		else
		{
			CMessageBox.Show(50035);
		}
	}

	private void frmVoucherFind_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}

	private void frmVoucherFind_Load(object sender, EventArgs e)
	{
		txtNgay_Ct1.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct1"));
		txtNgay_Ct2.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct2"));
		cboLoai_Ct.SelectedIndex = 0;
	}

	private void ReleaseMyResources()
	{
		if (f_oTblPh != null)
		{
			f_oTblPh.Dispose();
		}
		if (f_oTblCt != null)
		{
			f_oTblCt.Dispose();
		}
	}
}
