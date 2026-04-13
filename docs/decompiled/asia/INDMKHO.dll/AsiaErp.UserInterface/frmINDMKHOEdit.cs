using System;
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
public class frmINDMKHOEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtTen_Kho")]
	private TextBox _txtTen_Kho;

	[AccessedThroughProperty("lblTen_Kho")]
	private Label _lblTen_Kho;

	[AccessedThroughProperty("txtMa_Kho")]
	private TextBox _txtMa_Kho;

	[AccessedThroughProperty("lblMa_Kho")]
	private Label _lblMa_Kho;

	[AccessedThroughProperty("txtTk_Dl")]
	private AsTextBox _txtTk_Dl;

	[AccessedThroughProperty("txtStt_Ntxt")]
	private AsTextNumeric _txtStt_Ntxt;

	[AccessedThroughProperty("lblNguoi_Lh")]
	private Label _lblNguoi_Lh;

	[AccessedThroughProperty("lblDia_Chi")]
	private Label _lblDia_Chi;

	[AccessedThroughProperty("lblStt_Ntxt")]
	private Label _lblStt_Ntxt;

	[AccessedThroughProperty("txtEmail")]
	private TextBox _txtEmail;

	[AccessedThroughProperty("txtFax")]
	private MaskedTextBox _txtFax;

	[AccessedThroughProperty("txttTel")]
	private MaskedTextBox _txttTel;

	[AccessedThroughProperty("txtNguoi_Lh")]
	private TextBox _txtNguoi_Lh;

	[AccessedThroughProperty("txtDia_Chi")]
	private TextBox _txtDia_Chi;

	[AccessedThroughProperty("lblEmail")]
	private Label _lblEmail;

	[AccessedThroughProperty("lblFax")]
	private Label _lblFax;

	[AccessedThroughProperty("lblTel")]
	private Label _lblTel;

	[AccessedThroughProperty("lblTen_Tk_Dl")]
	private Label _lblTen_Tk_Dl;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("chkKho_dl")]
	private CheckBox _chkKho_dl;

	[AccessedThroughProperty("lblTk_Dl")]
	private Label _lblTk_Dl;

	internal virtual TextBox txtTen_Kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Kho = value;
		}
	}

	internal virtual Label lblTen_Kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Kho = value;
		}
	}

	internal virtual TextBox txtMa_Kho
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

	internal virtual Label lblMa_Kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Kho = value;
		}
	}

	internal virtual AsTextBox txtTk_Dl
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_Dl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_Dl = value;
		}
	}

	internal virtual AsTextNumeric txtStt_Ntxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtStt_Ntxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtStt_Ntxt = value;
		}
	}

	internal virtual Label lblNguoi_Lh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNguoi_Lh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNguoi_Lh = value;
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

	internal virtual Label lblStt_Ntxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblStt_Ntxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblStt_Ntxt = value;
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

	internal virtual MaskedTextBox txtFax
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

	internal virtual MaskedTextBox txttTel
	{
		[DebuggerNonUserCode]
		get
		{
			return _txttTel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txttTel = value;
		}
	}

	internal virtual TextBox txtNguoi_Lh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNguoi_Lh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNguoi_Lh = value;
		}
	}

	internal virtual TextBox txtDia_Chi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDia_Chi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDia_Chi = value;
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

	internal virtual Label lblTen_Tk_Dl
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_Dl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_Dl = value;
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

	internal virtual CheckBox chkKho_dl
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkKho_dl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkKho_dl_CheckedChanged;
			if (_chkKho_dl != null)
			{
				_chkKho_dl.CheckedChanged -= eventHandler;
			}
			_chkKho_dl = value;
			if (_chkKho_dl != null)
			{
				_chkKho_dl.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblTk_Dl
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_Dl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_Dl = value;
		}
	}

	[DebuggerNonUserCode]
	public frmINDMKHOEdit()
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
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
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		txtTen_Kho = new TextBox();
		lblTen_Kho = new Label();
		txtMa_Kho = new TextBox();
		lblMa_Kho = new Label();
		txtTk_Dl = new AsTextBox();
		lblTen_Tk_Dl = new Label();
		lblStt_Ntxt = new Label();
		lblNguoi_Lh = new Label();
		lblDia_Chi = new Label();
		txtStt_Ntxt = new AsTextNumeric();
		lblEmail = new Label();
		lblFax = new Label();
		lblTel = new Label();
		txtDia_Chi = new TextBox();
		txtNguoi_Lh = new TextBox();
		txttTel = new MaskedTextBox();
		txtFax = new MaskedTextBox();
		txtEmail = new TextBox();
		chkKho_dl = new CheckBox();
		lblTk_Dl = new Label();
		Label1 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(107, 273);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 10;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 318);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 318);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_Dl);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtEmail);
		((Control)gbLine).Controls.Add((Control)(object)chkKho_dl);
		((Control)gbLine).Controls.Add((Control)(object)txtFax);
		((Control)gbLine).Controls.Add((Control)(object)txttTel);
		((Control)gbLine).Controls.Add((Control)(object)lblEmail);
		((Control)gbLine).Controls.Add((Control)(object)txtNguoi_Lh);
		((Control)gbLine).Controls.Add((Control)(object)txtDia_Chi);
		((Control)gbLine).Controls.Add((Control)(object)lblFax);
		((Control)gbLine).Controls.Add((Control)(object)lblTel);
		((Control)gbLine).Controls.Add((Control)(object)txtStt_Ntxt);
		((Control)gbLine).Controls.Add((Control)(object)lblNguoi_Lh);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_Dl);
		((Control)gbLine).Controls.Add((Control)(object)lblDia_Chi);
		((Control)gbLine).Controls.Add((Control)(object)lblStt_Ntxt);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_Dl);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Kho);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_Kho);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Kho);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Kho);
		GroupBox obj3 = gbLine;
		Size size = new Size(515, 305);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_Kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_Dl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblStt_Ntxt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDia_Chi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_Dl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNguoi_Lh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtStt_Ntxt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTel, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblFax, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDia_Chi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNguoi_Lh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblEmail, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txttTel, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtFax, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKho_dl, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtEmail, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_Dl, 0);
		TextBox obj4 = txtTen_Kho;
		location = new Point(107, 45);
		((Control)obj4).Location = location;
		((TextBoxBase)txtTen_Kho).MaxLength = 50;
		((Control)txtTen_Kho).Name = "txtTen_Kho";
		TextBox obj5 = txtTen_Kho;
		size = new Size(392, 20);
		((Control)obj5).Size = size;
		((Control)txtTen_Kho).TabIndex = 1;
		lblTen_Kho.AutoSize = true;
		Label obj6 = lblTen_Kho;
		location = new Point(14, 49);
		((Control)obj6).Location = location;
		((Control)lblTen_Kho).Name = "lblTen_Kho";
		Label obj7 = lblTen_Kho;
		size = new Size(47, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_Kho).TabIndex = 103;
		lblTen_Kho.Text = "Tên kho";
		txtMa_Kho.CharacterCasing = (CharacterCasing)1;
		TextBox obj8 = txtMa_Kho;
		location = new Point(107, 19);
		((Control)obj8).Location = location;
		((Control)txtMa_Kho).Name = "txtMa_Kho";
		TextBox obj9 = txtMa_Kho;
		size = new Size(98, 20);
		((Control)obj9).Size = size;
		((Control)txtMa_Kho).TabIndex = 0;
		lblMa_Kho.AutoSize = true;
		Label obj10 = lblMa_Kho;
		location = new Point(14, 23);
		((Control)obj10).Location = location;
		((Control)lblMa_Kho).Name = "lblMa_Kho";
		Label obj11 = lblMa_Kho;
		size = new Size(43, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_Kho).TabIndex = 102;
		lblMa_Kho.Text = "Mã kho";
		txtTk_Dl.AutoLookup = true;
		txtTk_Dl.AutoValid = true;
		((TextBoxBase)txtTk_Dl).BackColor = SystemColors.Info;
		((TextBox)txtTk_Dl).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTk_Dl;
		location = new Point(107, 91);
		((Control)asTextBox).Location = location;
		txtTk_Dl.LookupCodeName = "TK";
		txtTk_Dl.LookupWhereCondition = "chi_tiet=1";
		((Control)txtTk_Dl).Name = "txtTk_Dl";
		txtTk_Dl.NameControl = lblTen_Tk_Dl;
		txtTk_Dl.SD = true;
		AsTextBox asTextBox2 = txtTk_Dl;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTk_Dl).TabIndex = 3;
		txtTk_Dl.UseAutoCompleteSource = true;
		Label obj12 = lblTen_Tk_Dl;
		location = new Point(213, 94);
		((Control)obj12).Location = location;
		((Control)lblTen_Tk_Dl).Name = "lblTen_Tk_Dl";
		Label obj13 = lblTen_Tk_Dl;
		size = new Size(286, 13);
		((Control)obj13).Size = size;
		((Control)lblTen_Tk_Dl).TabIndex = 113;
		lblStt_Ntxt.AutoSize = true;
		Label obj14 = lblStt_Ntxt;
		location = new Point(14, 121);
		((Control)obj14).Location = location;
		((Control)lblStt_Ntxt).Name = "lblStt_Ntxt";
		Label obj15 = lblStt_Ntxt;
		size = new Size(52, 13);
		((Control)obj15).Size = size;
		((Control)lblStt_Ntxt).TabIndex = 106;
		lblStt_Ntxt.Text = "Stt NTXT";
		lblNguoi_Lh.AutoSize = true;
		Label obj16 = lblNguoi_Lh;
		location = new Point(14, 173);
		((Control)obj16).Location = location;
		((Control)lblNguoi_Lh).Name = "lblNguoi_Lh";
		Label obj17 = lblNguoi_Lh;
		size = new Size(69, 13);
		((Control)obj17).Size = size;
		((Control)lblNguoi_Lh).TabIndex = 108;
		lblNguoi_Lh.Text = "Người liên hệ";
		lblDia_Chi.AutoSize = true;
		Label obj18 = lblDia_Chi;
		location = new Point(14, 147);
		((Control)obj18).Location = location;
		((Control)lblDia_Chi).Name = "lblDia_Chi";
		Label obj19 = lblDia_Chi;
		size = new Size(40, 13);
		((Control)obj19).Size = size;
		((Control)lblDia_Chi).TabIndex = 107;
		lblDia_Chi.Text = "Địa chỉ";
		txtStt_Ntxt.DecimalSymbol = ".";
		txtStt_Ntxt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtStt_Ntxt;
		location = new Point(107, 117);
		((Control)asTextNumeric).Location = location;
		txtStt_Ntxt.Mask = "### ### ### ###";
		((Control)txtStt_Ntxt).Name = "txtStt_Ntxt";
		txtStt_Ntxt.SelectionWhenFocus = false;
		AsTextNumeric asTextNumeric2 = txtStt_Ntxt;
		size = new Size(98, 20);
		((Control)asTextNumeric2).Size = size;
		txtStt_Ntxt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtStt_Ntxt).TabIndex = 4;
		((TextBox)txtStt_Ntxt).Text = "0";
		((TextBox)txtStt_Ntxt).TextAlign = (HorizontalAlignment)1;
		txtStt_Ntxt.Type = Commons.NumericType.ORTHER_;
		txtStt_Ntxt.Value = 0.0;
		lblEmail.AutoSize = true;
		Label obj20 = lblEmail;
		location = new Point(14, 251);
		((Control)obj20).Location = location;
		((Control)lblEmail).Name = "lblEmail";
		Label obj21 = lblEmail;
		size = new Size(32, 13);
		((Control)obj21).Size = size;
		((Control)lblEmail).TabIndex = 112;
		lblEmail.Text = "Email";
		lblFax.AutoSize = true;
		Label obj22 = lblFax;
		location = new Point(14, 225);
		((Control)obj22).Location = location;
		((Control)lblFax).Name = "lblFax";
		Label obj23 = lblFax;
		size = new Size(24, 13);
		((Control)obj23).Size = size;
		((Control)lblFax).TabIndex = 111;
		lblFax.Text = "Fax";
		lblTel.AutoSize = true;
		Label obj24 = lblTel;
		location = new Point(14, 199);
		((Control)obj24).Location = location;
		((Control)lblTel).Name = "lblTel";
		Label obj25 = lblTel;
		size = new Size(55, 13);
		((Control)obj25).Size = size;
		((Control)lblTel).TabIndex = 110;
		lblTel.Text = "Điện thoại";
		TextBox obj26 = txtDia_Chi;
		location = new Point(107, 143);
		((Control)obj26).Location = location;
		((TextBoxBase)txtDia_Chi).MaxLength = 128;
		((Control)txtDia_Chi).Name = "txtDia_Chi";
		TextBox obj27 = txtDia_Chi;
		size = new Size(392, 20);
		((Control)obj27).Size = size;
		((Control)txtDia_Chi).TabIndex = 5;
		TextBox obj28 = txtNguoi_Lh;
		location = new Point(107, 169);
		((Control)obj28).Location = location;
		((TextBoxBase)txtNguoi_Lh).MaxLength = 128;
		((Control)txtNguoi_Lh).Name = "txtNguoi_Lh";
		TextBox obj29 = txtNguoi_Lh;
		size = new Size(199, 20);
		((Control)obj29).Size = size;
		((Control)txtNguoi_Lh).TabIndex = 6;
		MaskedTextBox obj30 = txttTel;
		location = new Point(107, 195);
		((Control)obj30).Location = location;
		((Control)txttTel).Name = "txttTel";
		MaskedTextBox obj31 = txttTel;
		size = new Size(199, 20);
		((Control)obj31).Size = size;
		((Control)txttTel).TabIndex = 7;
		MaskedTextBox obj32 = txtFax;
		location = new Point(107, 221);
		((Control)obj32).Location = location;
		((Control)txtFax).Name = "txtFax";
		MaskedTextBox obj33 = txtFax;
		size = new Size(199, 20);
		((Control)obj33).Size = size;
		((Control)txtFax).TabIndex = 8;
		TextBox obj34 = txtEmail;
		location = new Point(107, 247);
		((Control)obj34).Location = location;
		((TextBoxBase)txtEmail).MaxLength = 128;
		((Control)txtEmail).Name = "txtEmail";
		TextBox obj35 = txtEmail;
		size = new Size(199, 20);
		((Control)obj35).Size = size;
		((Control)txtEmail).TabIndex = 9;
		((ButtonBase)chkKho_dl).AutoSize = true;
		CheckBox obj36 = chkKho_dl;
		location = new Point(107, 71);
		((Control)obj36).Location = location;
		((Control)chkKho_dl).Name = "chkKho_dl";
		CheckBox obj37 = chkKho_dl;
		size = new Size(15, 14);
		((Control)obj37).Size = size;
		((Control)chkKho_dl).TabIndex = 2;
		((ButtonBase)chkKho_dl).UseVisualStyleBackColor = true;
		lblTk_Dl.AutoSize = true;
		Label obj38 = lblTk_Dl;
		location = new Point(14, 95);
		((Control)obj38).Location = location;
		((Control)lblTk_Dl).Name = "lblTk_Dl";
		Label obj39 = lblTk_Dl;
		size = new Size(48, 13);
		((Control)obj39).Size = size;
		((Control)lblTk_Dl).TabIndex = 105;
		lblTk_Dl.Text = "Tk đại lý";
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(14, 72);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(54, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 115;
		Label1.Text = "Kho đại lý";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(537, 348);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmINDMKHOEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_Kho).MaxLength = base.MyDictInfo.code_length;
		((Control)txtMa_Kho).Select();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		InitKho();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_Kho).Enabled = false;
		((Control)txtTen_Kho).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_Kho;
		CreateDataBinding(ref ojb, "Ma_Kho");
		txtMa_Kho = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Kho;
		CreateDataBinding(ref ojb, "Ten_Kho");
		txtTen_Kho = (TextBox)ojb;
		ojb = (Control)(object)chkKho_dl;
		CreateDataBinding(ref ojb, "Kho_dl", "Checked");
		chkKho_dl = (CheckBox)ojb;
		ojb = (Control)(object)txtTk_Dl;
		CreateDataBinding(ref ojb, "Tk_Dl");
		txtTk_Dl = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtStt_Ntxt;
		CreateDataBinding(ref ojb, "Stt_Ntxt", "Value");
		txtStt_Ntxt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDia_Chi;
		CreateDataBinding(ref ojb, "Dia_Chi");
		txtDia_Chi = (TextBox)ojb;
		ojb = (Control)(object)txtNguoi_Lh;
		CreateDataBinding(ref ojb, "Nguoi_Lh");
		txtNguoi_Lh = (TextBox)ojb;
		ojb = (Control)(object)txttTel;
		CreateDataBinding(ref ojb, "Tel");
		txttTel = (MaskedTextBox)ojb;
		ojb = (Control)(object)txtFax;
		CreateDataBinding(ref ojb, "Fax");
		txtFax = (MaskedTextBox)ojb;
		ojb = (Control)(object)txtEmail;
		CreateDataBinding(ref ojb, "Email");
		txtEmail = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		return (ChkEmtyTextBox(txtMa_Kho) && ChkEmtyTextBox(txtTen_Kho) && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_Kho).Select();
		}
		return flag;
	}

	private void chkKho_dl_CheckedChanged(object sender, EventArgs e)
	{
		InitKho();
	}

	protected void InitKho()
	{
		if (chkKho_dl.Checked)
		{
			((Control)txtTk_Dl).Enabled = true;
			((Control)txtTk_Dl).Select();
			if (EditMode)
			{
				((Control)txtTen_Kho).Select();
			}
			else
			{
				((Control)txtMa_Kho).Select();
			}
		}
		else
		{
			((Control)txtTk_Dl).Enabled = false;
			((TextBox)txtTk_Dl).Text = "";
			lblTen_Tk_Dl.Text = "";
		}
	}
}
