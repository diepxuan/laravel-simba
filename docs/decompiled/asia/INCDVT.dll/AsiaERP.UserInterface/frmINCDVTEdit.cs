using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmINCDVTEdit : frmOBEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("lblMa_lo")]
	private Label _lblMa_lo;

	[AccessedThroughProperty("txtSo_luong")]
	private AsTextNumeric _txtSo_luong;

	[AccessedThroughProperty("lblMa_Tkvt")]
	private Label _lblMa_Tkvt;

	[AccessedThroughProperty("lblMa_nt")]
	private Label _lblMa_nt;

	[AccessedThroughProperty("lblSo_luong")]
	private Label _lblSo_luong;

	[AccessedThroughProperty("txtTien_nt")]
	private AsTextNumeric _txtTien_nt;

	[AccessedThroughProperty("txtTien_vnd")]
	private AsTextNumeric _txtTien_vnd;

	[AccessedThroughProperty("lblTien")]
	private Label _lblTien;

	[AccessedThroughProperty("lblTien_nt")]
	private Label _lblTien_nt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("lblTen_lo")]
	private Label _lblTen_lo;

	[AccessedThroughProperty("lblTen_tkvt")]
	private Label _lblTen_tkvt;

	[AccessedThroughProperty("lblYear")]
	private Label _lblYear;

	[AccessedThroughProperty("cboMa_Nt")]
	private AsComboBoxNT _cboMa_Nt;

	[AccessedThroughProperty("txtYear")]
	private AsTextNumeric _txtYear;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("txtMa_lo")]
	private AsTextBox _txtMa_lo;

	[AccessedThroughProperty("txtTk_vt")]
	private AsTextBox _txtTk_vt;

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

	internal virtual Label lblMa_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_lo = value;
		}
	}

	internal virtual AsTextNumeric txtSo_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_luong = value;
		}
	}

	internal virtual Label lblMa_Tkvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Tkvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Tkvt = value;
		}
	}

	internal virtual Label lblMa_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nt = value;
		}
	}

	internal virtual Label lblSo_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_luong = value;
		}
	}

	internal virtual AsTextNumeric txtTien_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTien_nt = value;
		}
	}

	internal virtual AsTextNumeric txtTien_vnd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_vnd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTien_vnd = value;
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

	internal virtual Label lblTien_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTien_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTien_nt = value;
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

	internal virtual Label lblTen_tkvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tkvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tkvt = value;
		}
	}

	internal virtual Label lblYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblYear = value;
		}
	}

	internal virtual AsComboBoxNT cboMa_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboMa_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboMa_Nt = value;
		}
	}

	internal virtual AsTextNumeric txtYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtYear = value;
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
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_vt_AfterCodeValidating;
			if (_txtMa_vt != null)
			{
				_txtMa_vt.AfterCodeValidating -= obj;
			}
			_txtMa_vt = value;
			if (_txtMa_vt != null)
			{
				_txtMa_vt.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual AsTextBox txtMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kho = value;
		}
	}

	internal virtual AsTextBox txtMa_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_lo = value;
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

	[DebuggerNonUserCode]
	public frmINCDVTEdit()
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		lblMa_vt = new Label();
		lblMa_kho = new Label();
		lblMa_lo = new Label();
		lblMa_Tkvt = new Label();
		lblMa_nt = new Label();
		txtSo_luong = new AsTextNumeric();
		lblSo_luong = new Label();
		lblTien_nt = new Label();
		txtTien_nt = new AsTextNumeric();
		lblTien = new Label();
		txtTien_vnd = new AsTextNumeric();
		lblTen_vt = new Label();
		lblTen_kho = new Label();
		lblTen_lo = new Label();
		lblTen_tkvt = new Label();
		lblYear = new Label();
		cboMa_Nt = new AsComboBoxNT();
		txtYear = new AsTextNumeric();
		txtMa_vt = new AsTextBox();
		txtMa_kho = new AsTextBox();
		txtMa_lo = new AsTextBox();
		txtTk_vt = new AsTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(504, 324);
		((Control)asCheckBox).Location = location;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 262);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 262);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblTen_lo);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbLine).Controls.Add((Control)(object)txtYear);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_kho);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_lo);
		((Control)gbLine).Controls.Add((Control)(object)cboMa_Nt);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_vt);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_luong);
		((Control)gbLine).Controls.Add((Control)(object)txtTien_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtTien_vnd);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_kho);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_vt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tkvt);
		((Control)gbLine).Controls.Add((Control)(object)lblYear);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_vt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_kho);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_lo);
		((Control)gbLine).Controls.Add((Control)(object)lblTien);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Tkvt);
		((Control)gbLine).Controls.Add((Control)(object)lblTien_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_luong);
		GroupBox obj3 = gbLine;
		Size size = new Size(544, 250);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_luong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTien_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Tkvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_lo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tkvt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTien_vnd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTien_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_luong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboMa_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_lo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_lo, 0);
		lblMa_vt.AutoSize = true;
		Label obj4 = lblMa_vt;
		location = new Point(17, 45);
		((Control)obj4).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj5 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_vt).TabIndex = 23;
		lblMa_vt.Text = "Mã vật tư";
		lblMa_kho.AutoSize = true;
		Label obj6 = lblMa_kho;
		location = new Point(17, 97);
		((Control)obj6).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj7 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj7).Size = size;
		((Control)lblMa_kho).TabIndex = 22;
		lblMa_kho.Text = "Mã kho";
		lblMa_lo.AutoSize = true;
		Label obj8 = lblMa_lo;
		location = new Point(17, 123);
		((Control)obj8).Location = location;
		((Control)lblMa_lo).Name = "lblMa_lo";
		Label obj9 = lblMa_lo;
		size = new Size(33, 13);
		((Control)obj9).Size = size;
		((Control)lblMa_lo).TabIndex = 20;
		lblMa_lo.Text = "Mã lô";
		lblMa_Tkvt.AutoSize = true;
		Label obj10 = lblMa_Tkvt;
		location = new Point(17, 71);
		((Control)obj10).Location = location;
		((Control)lblMa_Tkvt).Name = "lblMa_Tkvt";
		Label obj11 = lblMa_Tkvt;
		size = new Size(51, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_Tkvt).TabIndex = 19;
		lblMa_Tkvt.Text = "TK vật tư";
		lblMa_nt.AutoSize = true;
		Label obj12 = lblMa_nt;
		location = new Point(17, 149);
		((Control)obj12).Location = location;
		((Control)lblMa_nt).Name = "lblMa_nt";
		Label obj13 = lblMa_nt;
		size = new Size(40, 13);
		((Control)obj13).Size = size;
		((Control)lblMa_nt).TabIndex = 18;
		lblMa_nt.Text = "Mã NT";
		txtSo_luong.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtSo_luong;
		location = new Point(83, 172);
		((Control)asTextNumeric).Location = location;
		txtSo_luong.Mask = "### ### ### ###.####";
		((Control)txtSo_luong).Name = "txtSo_luong";
		AsTextNumeric asTextNumeric2 = txtSo_luong;
		size = new Size(112, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtSo_luong).TabIndex = 6;
		((Control)txtSo_luong).Tag = "QT";
		((TextBox)txtSo_luong).Text = "0.0000";
		((TextBox)txtSo_luong).TextAlign = (HorizontalAlignment)1;
		txtSo_luong.Value = 0.0;
		lblSo_luong.AutoSize = true;
		Label obj14 = lblSo_luong;
		location = new Point(17, 176);
		((Control)obj14).Location = location;
		((Control)lblSo_luong).Name = "lblSo_luong";
		Label obj15 = lblSo_luong;
		size = new Size(49, 13);
		((Control)obj15).Size = size;
		((Control)lblSo_luong).TabIndex = 17;
		lblSo_luong.Text = "Số lượng";
		lblTien_nt.AutoSize = true;
		Label obj16 = lblTien_nt;
		location = new Point(17, 202);
		((Control)obj16).Location = location;
		((Control)lblTien_nt).Name = "lblTien_nt";
		Label obj17 = lblTien_nt;
		size = new Size(46, 13);
		((Control)obj17).Size = size;
		((Control)lblTien_nt).TabIndex = 16;
		lblTien_nt.Text = "Tiền NT";
		txtTien_nt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric3 = txtTien_nt;
		location = new Point(83, 198);
		((Control)asTextNumeric3).Location = location;
		txtTien_nt.Mask = "### ### ### ###.####";
		((Control)txtTien_nt).Name = "txtTien_nt";
		AsTextNumeric asTextNumeric4 = txtTien_nt;
		size = new Size(112, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtTien_nt).TabIndex = 7;
		((Control)txtTien_nt).Tag = "FA";
		((TextBox)txtTien_nt).Text = "0.0000";
		((TextBox)txtTien_nt).TextAlign = (HorizontalAlignment)1;
		txtTien_nt.Value = 0.0;
		lblTien.AutoSize = true;
		Label obj18 = lblTien;
		location = new Point(17, 228);
		((Control)obj18).Location = location;
		((Control)lblTien).Name = "lblTien";
		Label obj19 = lblTien;
		size = new Size(54, 13);
		((Control)obj19).Size = size;
		((Control)lblTien).TabIndex = 15;
		lblTien.Text = "Tiền VND";
		txtTien_vnd.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric5 = txtTien_vnd;
		location = new Point(83, 224);
		((Control)asTextNumeric5).Location = location;
		txtTien_vnd.Mask = "### ### ### ###.####";
		((Control)txtTien_vnd).Name = "txtTien_vnd";
		AsTextNumeric asTextNumeric6 = txtTien_vnd;
		size = new Size(112, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtTien_vnd).TabIndex = 8;
		((Control)txtTien_vnd).Tag = "OA";
		((TextBox)txtTien_vnd).Text = "0.0000";
		((TextBox)txtTien_vnd).TextAlign = (HorizontalAlignment)1;
		txtTien_vnd.Value = 0.0;
		Label obj20 = lblTen_vt;
		location = new Point(201, 41);
		((Control)obj20).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj21 = lblTen_vt;
		size = new Size(333, 17);
		((Control)obj21).Size = size;
		((Control)lblTen_vt).TabIndex = 12;
		Label obj22 = lblTen_kho;
		location = new Point(164, 95);
		((Control)obj22).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj23 = lblTen_kho;
		size = new Size(370, 17);
		((Control)obj23).Size = size;
		((Control)lblTen_kho).TabIndex = 13;
		Label obj24 = lblTen_lo;
		location = new Point(164, 121);
		((Control)obj24).Location = location;
		((Control)lblTen_lo).Name = "lblTen_lo";
		Label obj25 = lblTen_lo;
		size = new Size(370, 17);
		((Control)obj25).Size = size;
		((Control)lblTen_lo).TabIndex = 15;
		Label obj26 = lblTen_tkvt;
		location = new Point(201, 70);
		((Control)obj26).Location = location;
		((Control)lblTen_tkvt).Name = "lblTen_tkvt";
		Label obj27 = lblTen_tkvt;
		size = new Size(333, 17);
		((Control)obj27).Size = size;
		((Control)lblTen_tkvt).TabIndex = 16;
		lblYear.AutoSize = true;
		Label obj28 = lblYear;
		location = new Point(17, 19);
		((Control)obj28).Location = location;
		((Control)lblYear).Name = "lblYear";
		Label obj29 = lblYear;
		size = new Size(29, 13);
		((Control)obj29).Size = size;
		((Control)lblYear).TabIndex = 24;
		lblYear.Text = "Năm";
		((ComboBox)cboMa_Nt).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMa_Nt).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_Nt;
		location = new Point(83, 145);
		((Control)asComboBoxNT).Location = location;
		cboMa_Nt.MA_NT = "";
		((Control)cboMa_Nt).Name = "cboMa_Nt";
		AsComboBoxNT asComboBoxNT2 = cboMa_Nt;
		size = new Size(53, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_Nt).TabIndex = 5;
		txtYear.DecimalSymbol = ".";
		((Control)txtYear).Enabled = false;
		AsTextNumeric asTextNumeric7 = txtYear;
		location = new Point(83, 15);
		((Control)asTextNumeric7).Location = location;
		txtYear.Mask = "####";
		((Control)txtYear).Name = "txtYear";
		AsTextNumeric asTextNumeric8 = txtYear;
		size = new Size(53, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtYear).TabIndex = 11;
		((Control)txtYear).TabStop = false;
		((TextBox)txtYear).Text = "0";
		((TextBox)txtYear).TextAlign = (HorizontalAlignment)1;
		txtYear.Value = 0.0;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = true;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_vt;
		location = new Point(83, 41);
		((Control)asTextBox).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		txtMa_vt.LookupWhereCondition = "ton_kho=1 and gia_ton<>'2'";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		txtMa_vt.SD = true;
		AsTextBox asTextBox2 = txtMa_vt;
		size = new Size(112, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_vt).TabIndex = 0;
		txtMa_vt.UseAutoCompleteSource = true;
		txtMa_vt.ValidReturnFieldList = "TK_VT,TEN_VT";
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = true;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_kho;
		location = new Point(83, 93);
		((Control)asTextBox3).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		txtMa_kho.SD = true;
		AsTextBox asTextBox4 = txtMa_kho;
		size = new Size(73, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_kho).TabIndex = 2;
		txtMa_kho.UseAutoCompleteSource = true;
		txtMa_lo.AutoLookup = true;
		txtMa_lo.AutoValid = true;
		((TextBoxBase)txtMa_lo).BackColor = SystemColors.Info;
		((TextBox)txtMa_lo).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_lo;
		location = new Point(83, 119);
		((Control)asTextBox5).Location = location;
		txtMa_lo.LookupCodeName = "MA_LO";
		((Control)txtMa_lo).Name = "txtMa_lo";
		txtMa_lo.NameControl = lblTen_lo;
		txtMa_lo.SD = true;
		AsTextBox asTextBox6 = txtMa_lo;
		size = new Size(73, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_lo).TabIndex = 4;
		txtMa_lo.UseAutoCompleteSource = true;
		txtTk_vt.AutoLookup = true;
		txtTk_vt.AutoValid = true;
		((TextBoxBase)txtTk_vt).BackColor = SystemColors.Info;
		((TextBox)txtTk_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtTk_vt;
		location = new Point(83, 67);
		((Control)asTextBox7).Location = location;
		txtTk_vt.LookupCodeName = "TK";
		txtTk_vt.LookupWhereCondition = "CHI_TIET='1'";
		((Control)txtTk_vt).Name = "txtTk_vt";
		txtTk_vt.NameControl = lblTen_tkvt;
		txtTk_vt.SD = true;
		AsTextBox asTextBox8 = txtTk_vt;
		size = new Size(112, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtTk_vt).TabIndex = 1;
		txtTk_vt.UseAutoCompleteSource = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(568, 297);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmINCDVTEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox((TextBox)(object)txtMa_vt) && ChkEmtyTextBox((TextBox)(object)txtMa_kho) && ChkEmtyTextBox((TextBox)(object)txtTk_vt) && base.ValidData()) ? true : false;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			txtYear.Value = SystemInformations.FinancialYear;
		}
		MaskTextBoxAll(((Control)gbLine).Controls);
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtYear).Enabled = false;
		((Control)txtMa_kho).Enabled = false;
		((Control)txtMa_lo).Enabled = false;
		((Control)txtTk_vt).Enabled = false;
		((Control)txtMa_vt).Enabled = false;
		((Control)cboMa_Nt).Enabled = false;
	}

	protected override void DataBinding()
	{
		base.DataBinding();
		Control ojb = (Control)(object)txtYear;
		CreateDataBinding(ref ojb, "nam", "value");
		txtYear = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMa_kho;
		CreateDataBinding(ref ojb, "ma_kho");
		txtMa_kho = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_lo;
		CreateDataBinding(ref ojb, "ma_lo");
		txtMa_lo = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_vt;
		CreateDataBinding(ref ojb, "ma_vt");
		txtMa_vt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)cboMa_Nt;
		CreateDataBinding(ref ojb, "ma_nt", "MA_NT");
		cboMa_Nt = (AsComboBoxNT)(object)ojb;
		ojb = (Control)(object)txtSo_luong;
		CreateDataBinding(ref ojb, "so_luong", "value");
		txtSo_luong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_nt;
		CreateDataBinding(ref ojb, "tien_nt", "value");
		txtTien_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_vnd;
		CreateDataBinding(ref ojb, "tien", "value");
		txtTien_vnd = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTk_vt;
		CreateDataBinding(ref ojb, "tk_vt");
		txtTk_vt = (AsTextBox)(object)ojb;
	}

	protected override bool SetToRow()
	{
		base.SetToRow();
		if (!EditMode)
		{
			RowToEdit["TEN_VT"] = lblTen_vt.Text;
		}
		return true;
	}

	private void txtMa_vt_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (e.ValidatedRow != null)
		{
			((TextBox)txtTk_vt).Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["TK_VT"]), isNum: false));
		}
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
