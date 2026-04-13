using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSIDMHDEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lbTen_Hd")]
	private Label _lbTen_Hd;

	[AccessedThroughProperty("lblLoai_Hd")]
	private Label _lblLoai_Hd;

	[AccessedThroughProperty("lbMa_Hd")]
	private Label _lbMa_Hd;

	[AccessedThroughProperty("txtTen_Hd")]
	private TextBox _txtTen_Hd;

	[AccessedThroughProperty("txtMa_Hd")]
	private TextBox _txtMa_Hd;

	[AccessedThroughProperty("lblMa_Kh")]
	private Label _lblMa_Kh;

	[AccessedThroughProperty("lblTien_Nt")]
	private Label _lblTien_Nt;

	[AccessedThroughProperty("lblMa_Nt")]
	private Label _lblMa_Nt;

	[AccessedThroughProperty("lblNoi_Dung")]
	private Label _lblNoi_Dung;

	[AccessedThroughProperty("lblSo_Hd")]
	private Label _lblSo_Hd;

	[AccessedThroughProperty("lblNgay_Hh")]
	private Label _lblNgay_Hh;

	[AccessedThroughProperty("lblMa_NhHd")]
	private Label _lblMa_NhHd;

	[AccessedThroughProperty("lblNgay_Hd")]
	private Label _lblNgay_Hd;

	[AccessedThroughProperty("txtSo_Hd")]
	private TextBox _txtSo_Hd;

	[AccessedThroughProperty("txtMa_Kh")]
	private AsTextBox _txtMa_Kh;

	[AccessedThroughProperty("txtMa_NhHd")]
	private AsTextBox _txtMa_NhHd;

	[AccessedThroughProperty("txtNgay_Hh")]
	private AsMaskedTextBox _txtNgay_Hh;

	[AccessedThroughProperty("txtNgay_Hd")]
	private AsMaskedTextBox _txtNgay_Hd;

	[AccessedThroughProperty("txtNoi_Dung")]
	private TextBox _txtNoi_Dung;

	[AccessedThroughProperty("txtTien_Nt")]
	private AsTextNumeric _txtTien_Nt;

	[AccessedThroughProperty("txtTien")]
	private AsTextNumeric _txtTien;

	[AccessedThroughProperty("lblTien")]
	private Label _lblTien;

	[AccessedThroughProperty("cboMa_NT")]
	private AsComboBoxNT _cboMa_NT;

	[AccessedThroughProperty("lblTen_NhHd")]
	private Label _lblTen_NhHd;

	[AccessedThroughProperty("lblTen_Kh")]
	private Label _lblTen_Kh;

	[AccessedThroughProperty("cboLoai_Hd")]
	private AsComboBox _cboLoai_Hd;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("txtMa_Bp")]
	private AsTextBox _txtMa_Bp;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	internal virtual Label lbTen_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbTen_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbTen_Hd = value;
		}
	}

	internal virtual Label lblLoai_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai_Hd = value;
		}
	}

	internal virtual Label lbMa_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbMa_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbMa_Hd = value;
		}
	}

	internal virtual TextBox txtTen_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Hd = value;
		}
	}

	internal virtual TextBox txtMa_Hd
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

	internal virtual Label lblTien_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTien_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTien_Nt = value;
		}
	}

	internal virtual Label lblMa_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nt = value;
		}
	}

	internal virtual Label lblNoi_Dung
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNoi_Dung;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNoi_Dung = value;
		}
	}

	internal virtual Label lblSo_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_Hd = value;
		}
	}

	internal virtual Label lblNgay_Hh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_Hh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_Hh = value;
		}
	}

	internal virtual Label lblMa_NhHd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_NhHd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_NhHd = value;
		}
	}

	internal virtual Label lblNgay_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_Hd = value;
		}
	}

	internal virtual TextBox txtSo_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_Hd = value;
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

	internal virtual AsTextBox txtMa_NhHd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_NhHd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_NhHd = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_Hh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_Hh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_Hh = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_Hd = value;
		}
	}

	internal virtual TextBox txtNoi_Dung
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNoi_Dung;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNoi_Dung = value;
		}
	}

	internal virtual AsTextNumeric txtTien_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTien_Nt = value;
		}
	}

	internal virtual AsTextNumeric txtTien
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTien = value;
		}
	}

	internal virtual Label lblTien
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTien = value;
		}
	}

	internal virtual AsComboBoxNT cboMa_NT
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboMa_NT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboMa_NT = value;
		}
	}

	internal virtual Label lblTen_NhHd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_NhHd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_NhHd = value;
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

	internal virtual AsComboBox cboLoai_Hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_Hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_Hd = value;
		}
	}

	internal virtual Label lblTen_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_bp = value;
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

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSIDMHDEdit()
	{
		__ENCAddToList(this);
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
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_1afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b08: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSIDMHDEdit));
		lbTen_Hd = new Label();
		lblLoai_Hd = new Label();
		lbMa_Hd = new Label();
		txtTen_Hd = new TextBox();
		txtMa_Hd = new TextBox();
		lblMa_Kh = new Label();
		lblTien_Nt = new Label();
		lblMa_Nt = new Label();
		lblNoi_Dung = new Label();
		lblSo_Hd = new Label();
		lblNgay_Hh = new Label();
		lblNgay_Hd = new Label();
		lblMa_NhHd = new Label();
		txtSo_Hd = new TextBox();
		txtMa_Kh = new AsTextBox();
		lblTen_Kh = new Label();
		txtMa_NhHd = new AsTextBox();
		lblTen_NhHd = new Label();
		txtNgay_Hd = new AsMaskedTextBox();
		txtNgay_Hh = new AsMaskedTextBox();
		txtTien_Nt = new AsTextNumeric();
		txtNoi_Dung = new TextBox();
		txtTien = new AsTextNumeric();
		lblTien = new Label();
		cboMa_NT = new AsComboBoxNT();
		cboLoai_Hd = new AsComboBox();
		lblTen_bp = new Label();
		txtMa_Bp = new AsTextBox();
		Label2 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		epNotice.SetIconAlignment((Control)(object)chkKsd, (ErrorIconAlignment)0);
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(142, 430);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 13;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		epNotice.SetIconAlignment((Control)(object)cmdCancel, (ErrorIconAlignment)0);
		Button obj = cmdCancel;
		location = new Point(93, 469);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		epNotice.SetIconAlignment((Control)(object)cmdSave, (ErrorIconAlignment)0);
		Button obj2 = cmdSave;
		location = new Point(12, 469);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblTen_bp);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Bp);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)cboLoai_Hd);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Kh);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_NhHd);
		((Control)gbLine).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbLine).Controls.Add((Control)(object)txtTien);
		((Control)gbLine).Controls.Add((Control)(object)lblTien);
		((Control)gbLine).Controls.Add((Control)(object)txtNoi_Dung);
		((Control)gbLine).Controls.Add((Control)(object)txtTien_Nt);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_Hh);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_Hd);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_NhHd);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Kh);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_Hd);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_NhHd);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_Hd);
		((Control)gbLine).Controls.Add((Control)(object)lbTen_Hd);
		((Control)gbLine).Controls.Add((Control)(object)lblLoai_Hd);
		((Control)gbLine).Controls.Add((Control)(object)lbMa_Hd);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Hd);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Hd);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Kh);
		((Control)gbLine).Controls.Add((Control)(object)lblTien_Nt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Nt);
		((Control)gbLine).Controls.Add((Control)(object)lblNoi_Dung);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_Hd);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_Hh);
		epNotice.SetIconAlignment((Control)(object)gbLine, (ErrorIconAlignment)0);
		GroupBox obj3 = gbLine;
		Size size = new Size(722, 457);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_Hh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_Hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNoi_Dung, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTien_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lbMa_Hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblLoai_Hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lbTen_Hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_Hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_NhHd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_Hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_NhHd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_Hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_Hh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTien_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNoi_Dung, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_NhHd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai_Hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		lbTen_Hd.AutoSize = true;
		epNotice.SetIconAlignment((Control)(object)lbTen_Hd, (ErrorIconAlignment)0);
		lbTen_Hd.ImeMode = (ImeMode)0;
		Label obj4 = lbTen_Hd;
		location = new Point(18, 76);
		((Control)obj4).Location = location;
		((Control)lbTen_Hd).Name = "lbTen_Hd";
		Label obj5 = lbTen_Hd;
		size = new Size(75, 13);
		((Control)obj5).Size = size;
		((Control)lbTen_Hd).TabIndex = 113;
		lbTen_Hd.Text = "Tên hợp đồng";
		lblLoai_Hd.AutoSize = true;
		epNotice.SetIconAlignment((Control)(object)lblLoai_Hd, (ErrorIconAlignment)0);
		lblLoai_Hd.ImeMode = (ImeMode)0;
		Label obj6 = lblLoai_Hd;
		location = new Point(18, 23);
		((Control)obj6).Location = location;
		((Control)lblLoai_Hd).Name = "lblLoai_Hd";
		Label obj7 = lblLoai_Hd;
		size = new Size(76, 13);
		((Control)obj7).Size = size;
		((Control)lblLoai_Hd).TabIndex = 114;
		lblLoai_Hd.Text = "Loại hợp đồng";
		lbMa_Hd.AutoSize = true;
		epNotice.SetIconAlignment((Control)(object)lbMa_Hd, (ErrorIconAlignment)0);
		lbMa_Hd.ImeMode = (ImeMode)0;
		Label obj8 = lbMa_Hd;
		location = new Point(18, 50);
		((Control)obj8).Location = location;
		((Control)lbMa_Hd).Name = "lbMa_Hd";
		Label obj9 = lbMa_Hd;
		size = new Size(71, 13);
		((Control)obj9).Size = size;
		((Control)lbMa_Hd).TabIndex = 111;
		lbMa_Hd.Text = "Mã hợp đồng";
		epNotice.SetIconAlignment((Control)(object)txtTen_Hd, (ErrorIconAlignment)0);
		TextBox obj10 = txtTen_Hd;
		location = new Point(140, 72);
		((Control)obj10).Location = location;
		((Control)txtTen_Hd).Name = "txtTen_Hd";
		TextBox obj11 = txtTen_Hd;
		size = new Size(576, 20);
		((Control)obj11).Size = size;
		((Control)txtTen_Hd).TabIndex = 2;
		txtMa_Hd.CharacterCasing = (CharacterCasing)1;
		epNotice.SetIconAlignment((Control)(object)txtMa_Hd, (ErrorIconAlignment)0);
		TextBox obj12 = txtMa_Hd;
		location = new Point(140, 46);
		((Control)obj12).Location = location;
		((TextBoxBase)txtMa_Hd).MaxLength = 20;
		((Control)txtMa_Hd).Name = "txtMa_Hd";
		TextBox obj13 = txtMa_Hd;
		size = new Size(100, 20);
		((Control)obj13).Size = size;
		((Control)txtMa_Hd).TabIndex = 1;
		lblMa_Kh.AutoSize = true;
		epNotice.SetIconAlignment((Control)(object)lblMa_Kh, (ErrorIconAlignment)0);
		lblMa_Kh.ImeMode = (ImeMode)0;
		Label obj14 = lblMa_Kh;
		location = new Point(18, 152);
		((Control)obj14).Location = location;
		((Control)lblMa_Kh).Name = "lblMa_Kh";
		Label obj15 = lblMa_Kh;
		size = new Size(82, 13);
		((Control)obj15).Size = size;
		((Control)lblMa_Kh).TabIndex = 103;
		lblMa_Kh.Text = "Mã khách hàng";
		lblMa_Kh.TextAlign = (ContentAlignment)16;
		lblTien_Nt.AutoSize = true;
		epNotice.SetIconAlignment((Control)(object)lblTien_Nt, (ErrorIconAlignment)0);
		lblTien_Nt.ImeMode = (ImeMode)0;
		Label obj16 = lblTien_Nt;
		location = new Point(18, 283);
		((Control)obj16).Location = location;
		((Control)lblTien_Nt).Name = "lblTien_Nt";
		Label obj17 = lblTien_Nt;
		size = new Size(91, 13);
		((Control)obj17).Size = size;
		((Control)lblTien_Nt).TabIndex = 112;
		lblTien_Nt.Text = "Tiền hợp đồng Nt";
		lblTien_Nt.TextAlign = (ContentAlignment)16;
		lblMa_Nt.AutoSize = true;
		epNotice.SetIconAlignment((Control)(object)lblMa_Nt, (ErrorIconAlignment)0);
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj18 = lblMa_Nt;
		location = new Point(18, 256);
		((Control)obj18).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj19 = lblMa_Nt;
		size = new Size(63, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_Nt).TabIndex = 116;
		lblMa_Nt.Text = "Mã ngoại tệ";
		lblMa_Nt.TextAlign = (ContentAlignment)16;
		lblNoi_Dung.AutoSize = true;
		epNotice.SetIconAlignment((Control)(object)lblNoi_Dung, (ErrorIconAlignment)0);
		lblNoi_Dung.ImeMode = (ImeMode)0;
		Label obj20 = lblNoi_Dung;
		location = new Point(18, 331);
		((Control)obj20).Location = location;
		((Control)lblNoi_Dung).Name = "lblNoi_Dung";
		Label obj21 = lblNoi_Dung;
		size = new Size(50, 13);
		((Control)obj21).Size = size;
		((Control)lblNoi_Dung).TabIndex = 118;
		lblNoi_Dung.Text = "Nội dung";
		lblNoi_Dung.TextAlign = (ContentAlignment)16;
		lblSo_Hd.AutoSize = true;
		epNotice.SetIconAlignment((Control)(object)lblSo_Hd, (ErrorIconAlignment)0);
		lblSo_Hd.ImeMode = (ImeMode)0;
		Label obj22 = lblSo_Hd;
		location = new Point(18, 100);
		((Control)obj22).Location = location;
		((Control)lblSo_Hd).Name = "lblSo_Hd";
		Label obj23 = lblSo_Hd;
		size = new Size(69, 13);
		((Control)obj23).Size = size;
		((Control)lblSo_Hd).TabIndex = 117;
		lblSo_Hd.Text = "Số hợp đồng";
		lblSo_Hd.TextAlign = (ContentAlignment)16;
		lblNgay_Hh.AutoSize = true;
		epNotice.SetIconAlignment((Control)(object)lblNgay_Hh, (ErrorIconAlignment)0);
		lblNgay_Hh.ImeMode = (ImeMode)0;
		Label obj24 = lblNgay_Hh;
		location = new Point(18, 230);
		((Control)obj24).Location = location;
		((Control)lblNgay_Hh).Name = "lblNgay_Hh";
		Label obj25 = lblNgay_Hh;
		size = new Size(71, 13);
		((Control)obj25).Size = size;
		((Control)lblNgay_Hh).TabIndex = 115;
		lblNgay_Hh.Text = "Ngày hết hạn";
		lblNgay_Hh.TextAlign = (ContentAlignment)16;
		lblNgay_Hd.AutoSize = true;
		epNotice.SetIconAlignment((Control)(object)lblNgay_Hd, (ErrorIconAlignment)0);
		lblNgay_Hd.ImeMode = (ImeMode)0;
		Label obj26 = lblNgay_Hd;
		location = new Point(18, 204);
		((Control)obj26).Location = location;
		((Control)lblNgay_Hd).Name = "lblNgay_Hd";
		Label obj27 = lblNgay_Hd;
		size = new Size(81, 13);
		((Control)obj27).Size = size;
		((Control)lblNgay_Hd).TabIndex = 120;
		lblNgay_Hd.Text = "Ngày hợp đồng";
		lblNgay_Hd.TextAlign = (ContentAlignment)16;
		lblMa_NhHd.AutoSize = true;
		epNotice.SetIconAlignment((Control)(object)lblMa_NhHd, (ErrorIconAlignment)0);
		lblMa_NhHd.ImeMode = (ImeMode)0;
		Label obj28 = lblMa_NhHd;
		location = new Point(18, 126);
		((Control)obj28).Location = location;
		((Control)lblMa_NhHd).Name = "lblMa_NhHd";
		Label obj29 = lblMa_NhHd;
		size = new Size(84, 13);
		((Control)obj29).Size = size;
		((Control)lblMa_NhHd).TabIndex = 121;
		lblMa_NhHd.Text = "Nhóm hợp đồng";
		txtSo_Hd.CharacterCasing = (CharacterCasing)1;
		epNotice.SetIconAlignment((Control)(object)txtSo_Hd, (ErrorIconAlignment)0);
		TextBox obj30 = txtSo_Hd;
		location = new Point(140, 96);
		((Control)obj30).Location = location;
		((TextBoxBase)txtSo_Hd).MaxLength = 50;
		((Control)txtSo_Hd).Name = "txtSo_Hd";
		TextBox obj31 = txtSo_Hd;
		size = new Size(100, 20);
		((Control)obj31).Size = size;
		((Control)txtSo_Hd).TabIndex = 3;
		((Control)txtSo_Hd).Tag = "MA_NHKH";
		txtMa_Kh.AutoLookup = true;
		txtMa_Kh.AutoValid = true;
		((TextBoxBase)txtMa_Kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_Kh).CharacterCasing = (CharacterCasing)1;
		epNotice.SetIconAlignment((Control)(object)txtMa_Kh, (ErrorIconAlignment)0);
		AsTextBox asTextBox = txtMa_Kh;
		location = new Point(140, 148);
		((Control)asTextBox).Location = location;
		txtMa_Kh.LookupCodeName = "MA_KH";
		((Control)txtMa_Kh).Name = "txtMa_Kh";
		txtMa_Kh.NameControl = lblTen_Kh;
		txtMa_Kh.SD = true;
		AsTextBox asTextBox2 = txtMa_Kh;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_Kh).TabIndex = 5;
		txtMa_Kh.UseAutoCompleteSource = true;
		epNotice.SetIconAlignment((Control)(object)lblTen_Kh, (ErrorIconAlignment)0);
		lblTen_Kh.ImeMode = (ImeMode)0;
		Label obj32 = lblTen_Kh;
		location = new Point(246, 152);
		((Control)obj32).Location = location;
		((Control)lblTen_Kh).Name = "lblTen_Kh";
		Label obj33 = lblTen_Kh;
		size = new Size(470, 13);
		((Control)obj33).Size = size;
		((Control)lblTen_Kh).TabIndex = 134;
		txtMa_NhHd.AutoLookup = true;
		txtMa_NhHd.AutoValid = true;
		((TextBoxBase)txtMa_NhHd).BackColor = SystemColors.Info;
		((TextBox)txtMa_NhHd).CharacterCasing = (CharacterCasing)1;
		epNotice.SetIconAlignment((Control)(object)txtMa_NhHd, (ErrorIconAlignment)0);
		AsTextBox asTextBox3 = txtMa_NhHd;
		location = new Point(140, 122);
		((Control)asTextBox3).Location = location;
		txtMa_NhHd.LookupCodeName = "MA_NHHD";
		((Control)txtMa_NhHd).Name = "txtMa_NhHd";
		txtMa_NhHd.NameControl = lblTen_NhHd;
		txtMa_NhHd.SD = true;
		AsTextBox asTextBox4 = txtMa_NhHd;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_NhHd).TabIndex = 4;
		txtMa_NhHd.UseAutoCompleteSource = true;
		epNotice.SetIconAlignment((Control)(object)lblTen_NhHd, (ErrorIconAlignment)0);
		lblTen_NhHd.ImeMode = (ImeMode)0;
		Label obj34 = lblTen_NhHd;
		location = new Point(246, 125);
		((Control)obj34).Location = location;
		((Control)lblTen_NhHd).Name = "lblTen_NhHd";
		Label obj35 = lblTen_NhHd;
		size = new Size(470, 13);
		((Control)obj35).Size = size;
		((Control)lblTen_NhHd).TabIndex = 133;
		txtNgay_Hd.Format = "@Ddd/MM/yyyy";
		epNotice.SetIconAlignment((Control)(object)txtNgay_Hd, (ErrorIconAlignment)0);
		((MaskedTextBox)txtNgay_Hd).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Hd;
		location = new Point(140, 200);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_Hd).Mask = "##/##/####";
		((Control)txtNgay_Hd).Name = "txtNgay_Hd";
		((MaskedTextBox)txtNgay_Hd).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_Hd;
		size = new Size(100, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_Hd).TabIndex = 7;
		((MaskedTextBox)txtNgay_Hd).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_Hd;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtNgay_Hh.Format = "@Ddd/MM/yyyy";
		epNotice.SetIconAlignment((Control)(object)txtNgay_Hh, (ErrorIconAlignment)0);
		((MaskedTextBox)txtNgay_Hh).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_Hh;
		location = new Point(140, 226);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_Hh).Mask = "##/##/####";
		((Control)txtNgay_Hh).Name = "txtNgay_Hh";
		((MaskedTextBox)txtNgay_Hh).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_Hh;
		size = new Size(100, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_Hh).TabIndex = 8;
		((MaskedTextBox)txtNgay_Hh).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_Hh;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		txtTien_Nt.DecimalSymbol = ".";
		epNotice.SetIconAlignment((Control)(object)txtTien_Nt, (ErrorIconAlignment)0);
		AsTextNumeric asTextNumeric = txtTien_Nt;
		location = new Point(140, 279);
		((Control)asTextNumeric).Location = location;
		txtTien_Nt.Mask = "### ### ### ###.##";
		((Control)txtTien_Nt).Name = "txtTien_Nt";
		AsTextNumeric asTextNumeric2 = txtTien_Nt;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTien_Nt).TabIndex = 10;
		((Control)txtTien_Nt).Tag = "FA";
		((TextBox)txtTien_Nt).Text = "0.00";
		((TextBox)txtTien_Nt).TextAlign = (HorizontalAlignment)1;
		txtTien_Nt.Value = 0.0;
		epNotice.SetIconAlignment((Control)(object)txtNoi_Dung, (ErrorIconAlignment)0);
		TextBox obj36 = txtNoi_Dung;
		location = new Point(140, 331);
		((Control)obj36).Location = location;
		txtNoi_Dung.Multiline = true;
		((Control)txtNoi_Dung).Name = "txtNoi_Dung";
		TextBox obj37 = txtNoi_Dung;
		size = new Size(576, 92);
		((Control)obj37).Size = size;
		((Control)txtNoi_Dung).TabIndex = 12;
		txtTien.DecimalSymbol = ".";
		epNotice.SetIconAlignment((Control)(object)txtTien, (ErrorIconAlignment)0);
		AsTextNumeric asTextNumeric3 = txtTien;
		location = new Point(140, 305);
		((Control)asTextNumeric3).Location = location;
		txtTien.Mask = "### ### ### ###";
		((Control)txtTien).Name = "txtTien";
		AsTextNumeric asTextNumeric4 = txtTien;
		size = new Size(100, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtTien).TabIndex = 11;
		((Control)txtTien).Tag = "OA";
		((TextBox)txtTien).Text = "0";
		((TextBox)txtTien).TextAlign = (HorizontalAlignment)1;
		txtTien.Value = 0.0;
		lblTien.AutoSize = true;
		epNotice.SetIconAlignment((Control)(object)lblTien, (ErrorIconAlignment)0);
		lblTien.ImeMode = (ImeMode)0;
		Label obj38 = lblTien;
		location = new Point(18, 309);
		((Control)obj38).Location = location;
		((Control)lblTien).Name = "lblTien";
		Label obj39 = lblTien;
		size = new Size(77, 13);
		((Control)obj39).Size = size;
		((Control)lblTien).TabIndex = 132;
		lblTien.Text = "Tiền hợp đồng";
		lblTien.TextAlign = (ContentAlignment)16;
		((ComboBox)cboMa_NT).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMa_NT).FormattingEnabled = true;
		epNotice.SetIconAlignment((Control)(object)cboMa_NT, (ErrorIconAlignment)0);
		AsComboBoxNT asComboBoxNT = cboMa_NT;
		location = new Point(140, 252);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(100, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 9;
		((ComboBox)cboLoai_Hd).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_Hd).FormattingEnabled = true;
		epNotice.SetIconAlignment((Control)(object)cboLoai_Hd, (ErrorIconAlignment)0);
		((ComboBox)cboLoai_Hd).Items.AddRange(new object[2] { "Mua", "Bán" });
		AsComboBox asComboBox = cboLoai_Hd;
		location = new Point(140, 19);
		((Control)asComboBox).Location = location;
		((Control)cboLoai_Hd).Name = "cboLoai_Hd";
		AsComboBox asComboBox2 = cboLoai_Hd;
		size = new Size(100, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboLoai_Hd).TabIndex = 0;
		epNotice.SetIconAlignment((Control)(object)lblTen_bp, (ErrorIconAlignment)0);
		lblTen_bp.ImeMode = (ImeMode)0;
		Label obj40 = lblTen_bp;
		location = new Point(249, 178);
		((Control)obj40).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj41 = lblTen_bp;
		size = new Size(467, 13);
		((Control)obj41).Size = size;
		((Control)lblTen_bp).TabIndex = 138;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = true;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		epNotice.SetIconAlignment((Control)(object)txtMa_Bp, (ErrorIconAlignment)0);
		AsTextBox asTextBox5 = txtMa_Bp;
		location = new Point(140, 174);
		((Control)asTextBox5).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_bp;
		txtMa_Bp.SD = true;
		AsTextBox asTextBox6 = txtMa_Bp;
		size = new Size(100, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_Bp).TabIndex = 6;
		txtMa_Bp.UseAutoCompleteSource = true;
		Label2.AutoSize = true;
		epNotice.SetIconAlignment((Control)(object)Label2, (ErrorIconAlignment)0);
		Label2.ImeMode = (ImeMode)0;
		Label label = Label2;
		location = new Point(18, 178);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(55, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 137;
		Label2.Text = "Mã phòng";
		Label2.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(746, 499);
		((Form)this).ClientSize = size;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "frmSIDMHDEdit";
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		DictionaryEntry[] dataSource = new DictionaryEntry[2]
		{
			new DictionaryEntry("2", RuntimeHelpers.GetObjectValue(((ComboBox)cboLoai_Hd).Items[0])),
			new DictionaryEntry("1", RuntimeHelpers.GetObjectValue(((ComboBox)cboLoai_Hd).Items[1]))
		};
		((ListControl)cboLoai_Hd).ValueMember = "Key";
		((ListControl)cboLoai_Hd).DisplayMember = "Value";
		((ComboBox)cboLoai_Hd).DataSource = dataSource;
		((TextBoxBase)txtMa_Hd).MaxLength = MyDictInfo.code_length;
		((Control)txtMa_Hd).Select();
		ArrayList arrayList = new ArrayList();
		foreach (DMNTInformation item in (ArrayList)((ComboBox)cboMa_NT).DataSource)
		{
			if (!item.ksd)
			{
				arrayList.Add(item);
			}
		}
		((ComboBox)cboMa_NT).DataSource = arrayList;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			((ListControl)cboLoai_Hd).SelectedValue = "1";
		}
		MaskTextBoxAll(((Control)gbLine).Controls);
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_Hd).Enabled = false;
		((Control)txtTen_Hd).Select();
	}

	protected override void DataBinding()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_Kh;
		CreateDataBinding(ref ojb, "Ma_Kh");
		txtMa_Kh = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_Bp;
		CreateDataBinding(ref ojb, "Ma_Bp");
		txtMa_Bp = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_bp;
		CreateDataBinding(ref ojb, "Ten_Bp");
		lblTen_bp = (Label)ojb;
		ojb = (Control)(object)lblTen_Kh;
		CreateDataBinding(ref ojb, "Ten_Kh");
		lblTen_Kh = (Label)ojb;
		ojb = (Control)(object)txtMa_Hd;
		CreateDataBinding(ref ojb, "Ma_Hd");
		txtMa_Hd = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Hd;
		CreateDataBinding(ref ojb, "Ten_Hd");
		txtTen_Hd = (TextBox)ojb;
		ojb = (Control)(object)txtMa_NhHd;
		CreateDataBinding(ref ojb, "Ma_NhHd");
		txtMa_NhHd = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_NhHd;
		CreateDataBinding(ref ojb, "Ten_NhHd");
		lblTen_NhHd = (Label)ojb;
		ojb = (Control)(object)txtSo_Hd;
		CreateDataBinding(ref ojb, "So_Hd");
		txtSo_Hd = (TextBox)ojb;
		ojb = (Control)(object)txtNgay_Hd;
		CreateDataBinding(ref ojb, "Ngay_Hd", "Value");
		txtNgay_Hd = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_Hh;
		CreateDataBinding(ref ojb, "Ngay_Hh", "Value");
		txtNgay_Hh = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNoi_Dung;
		CreateDataBinding(ref ojb, "Noi_Dung");
		txtNoi_Dung = (TextBox)ojb;
		ojb = (Control)(object)txtTien;
		CreateDataBinding(ref ojb, "Tien", "Value");
		txtTien = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)cboMa_NT;
		CreateDataBinding(ref ojb, "Ma_Nt", "MA_NT");
		cboMa_NT = (AsComboBoxNT)(object)ojb;
		ojb = (Control)(object)cboLoai_Hd;
		CreateDataBinding(ref ojb, "Loai", "SelectedValue");
		cboLoai_Hd = (AsComboBox)(object)ojb;
		ojb = (Control)(object)txtTien_Nt;
		CreateDataBinding(ref ojb, "Tien_Nt", "Value");
		txtTien_Nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.ConditionalCompareObjectGreater(txtNgay_Hd.Value, txtNgay_Hh.Value, false) && Operators.CompareString(((MaskedTextBox)txtNgay_Hh).Text.Replace("/", "").Trim(), "", false) != 0) ? true : false)
		{
			CMessageBox.Show("Ngày hết hạn phải lớn hơn ngày hợp đồng");
		}
		return (ChkEmtyTextBox(txtMa_Hd) && ChkEmtyTextBox(txtTen_Hd) && base.ValidData()) ? true : false;
	}

	protected override bool SetToRow()
	{
		bool result = base.SetToRow();
		DataRow rowToEdit = RowToEdit;
		DictionaryEntry dictionaryEntry = (DictionaryEntry)((ComboBox)cboLoai_Hd).Items[((ComboBox)cboLoai_Hd).SelectedIndex];
		rowToEdit["loai"] = RuntimeHelpers.GetObjectValue(dictionaryEntry.Key);
		if (Operators.ConditionalCompareObjectEqual(RowToEdit["loai"], (object)"1", false))
		{
			RowToEdit["ten_loai"] = "Bán";
		}
		else
		{
			RowToEdit["ten_loai"] = "Mua";
		}
		RowToEdit["noi_dung"] = txtNoi_Dung.Text.Replace("\n", "").Replace("\r", "").Trim();
		return result;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_Hd).Select();
		}
		return flag;
	}

	private void MaskTextBoxAll(ControlCollection ctl)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (Control item in ctl)
		{
			Control val = item;
			if (val is AsTextNumeric)
			{
				AsTextNumeric asTextNumeric = (AsTextNumeric)(object)val;
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCPrice_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"QT", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format;
				}
			}
		}
	}
}
