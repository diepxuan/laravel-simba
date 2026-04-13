using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCACDKUEdit : frmOBEdit
{
	private IContainer components;

	[AccessedThroughProperty("lblMa_ku")]
	private Label _lblMa_ku;

	[AccessedThroughProperty("txtMa_ku")]
	private AsTextBox _txtMa_ku;

	[AccessedThroughProperty("txtMa_tk")]
	private AsTextBox _txtMa_tk;

	[AccessedThroughProperty("lblMa_tk")]
	private Label _lblMa_tk;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("lblTen_ku")]
	private Label _lblTen_ku;

	[AccessedThroughProperty("lblMa_nt")]
	private Label _lblMa_nt;

	[AccessedThroughProperty("txtTiendattVND")]
	private AsTextNumeric _txtTiendattVND;

	[AccessedThroughProperty("txtTiendvVND")]
	private AsTextNumeric _txtTiendvVND;

	[AccessedThroughProperty("txtTiendattNT")]
	private AsTextNumeric _txtTiendattNT;

	[AccessedThroughProperty("txtTiendvNT")]
	private AsTextNumeric _txtTiendvNT;

	[AccessedThroughProperty("lblTiendattVND")]
	private Label _lblTiendattVND;

	[AccessedThroughProperty("lblTiendvVND")]
	private Label _lblTiendvVND;

	[AccessedThroughProperty("lblTienDattNT")]
	private Label _lblTienDattNT;

	[AccessedThroughProperty("lblTiendvNT")]
	private Label _lblTiendvNT;

	[AccessedThroughProperty("txtNgayTT")]
	private AsMaskedTextBox _txtNgayTT;

	[AccessedThroughProperty("txtNgayKu")]
	private AsMaskedTextBox _txtNgayKu;

	[AccessedThroughProperty("lblNgayTT")]
	private Label _lblNgayTT;

	[AccessedThroughProperty("lblNgayKu")]
	private Label _lblNgayKu;

	[AccessedThroughProperty("txtYear")]
	private AsTextNumeric _txtYear;

	[AccessedThroughProperty("lblYear")]
	private Label _lblYear;

	[AccessedThroughProperty("txtMa_nt")]
	private TextBox _txtMa_nt;

	internal virtual Label lblMa_ku
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_ku = value;
		}
	}

	internal virtual AsTextBox txtMa_ku
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_ku_AfterCodeValidating;
			if (_txtMa_ku != null)
			{
				_txtMa_ku.AfterCodeValidating -= obj;
			}
			_txtMa_ku = value;
			if (_txtMa_ku != null)
			{
				_txtMa_ku.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual AsTextBox txtMa_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_tk = value;
		}
	}

	internal virtual Label lblMa_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_tk = value;
		}
	}

	internal virtual Label lblTen_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk = value;
		}
	}

	internal virtual Label lblTen_ku
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ku;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ku = value;
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

	internal virtual AsTextNumeric txtTiendattVND
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTiendattVND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTiendattVND = value;
		}
	}

	internal virtual AsTextNumeric txtTiendvVND
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTiendvVND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTiendvVND = value;
		}
	}

	internal virtual AsTextNumeric txtTiendattNT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTiendattNT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTiendattNT = value;
		}
	}

	internal virtual AsTextNumeric txtTiendvNT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTiendvNT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTiendvNT = value;
		}
	}

	internal virtual Label lblTiendattVND
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTiendattVND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTiendattVND = value;
		}
	}

	internal virtual Label lblTiendvVND
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTiendvVND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTiendvVND = value;
		}
	}

	internal virtual Label lblTienDattNT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTienDattNT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTienDattNT = value;
		}
	}

	internal virtual Label lblTiendvNT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTiendvNT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTiendvNT = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgayTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgayTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgayTT = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgayKu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgayKu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgayKu = value;
		}
	}

	internal virtual Label lblNgayTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgayTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgayTT = value;
		}
	}

	internal virtual Label lblNgayKu
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgayKu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgayKu = value;
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

	internal virtual TextBox txtMa_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMa_nt_TextChanged;
			if (_txtMa_nt != null)
			{
				((Control)_txtMa_nt).TextChanged -= eventHandler;
			}
			_txtMa_nt = value;
			if (_txtMa_nt != null)
			{
				((Control)_txtMa_nt).TextChanged += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public frmCACDKUEdit()
	{
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		lblMa_ku = new Label();
		txtMa_ku = new AsTextBox();
		lblTen_ku = new Label();
		lblTen_tk = new Label();
		lblMa_tk = new Label();
		txtMa_tk = new AsTextBox();
		lblMa_nt = new Label();
		txtTiendvNT = new AsTextNumeric();
		lblTiendvNT = new Label();
		lblTiendvVND = new Label();
		txtTiendvVND = new AsTextNumeric();
		lblTienDattNT = new Label();
		lblTiendattVND = new Label();
		txtTiendattNT = new AsTextNumeric();
		txtTiendattVND = new AsTextNumeric();
		txtNgayKu = new AsMaskedTextBox();
		lblNgayKu = new Label();
		lblNgayTT = new Label();
		txtNgayTT = new AsMaskedTextBox();
		lblYear = new Label();
		txtYear = new AsTextNumeric();
		txtMa_nt = new TextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(24, 321);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 240);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 240);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtMa_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtYear);
		((Control)gbLine).Controls.Add((Control)(object)lblYear);
		((Control)gbLine).Controls.Add((Control)(object)txtNgayTT);
		((Control)gbLine).Controls.Add((Control)(object)txtNgayKu);
		((Control)gbLine).Controls.Add((Control)(object)txtTiendattVND);
		((Control)gbLine).Controls.Add((Control)(object)txtTiendvVND);
		((Control)gbLine).Controls.Add((Control)(object)txtTiendattNT);
		((Control)gbLine).Controls.Add((Control)(object)txtTiendvNT);
		((Control)gbLine).Controls.Add((Control)(object)lblTiendattVND);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_ku);
		((Control)gbLine).Controls.Add((Control)(object)lblTiendvVND);
		((Control)gbLine).Controls.Add((Control)(object)lblTienDattNT);
		((Control)gbLine).Controls.Add((Control)(object)lblNgayTT);
		((Control)gbLine).Controls.Add((Control)(object)lblTiendvNT);
		((Control)gbLine).Controls.Add((Control)(object)lblNgayKu);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_tk);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_ku);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_ku);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_tk);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk);
		GroupBox obj3 = gbLine;
		Size size = new Size(482, 228);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_ku, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_ku, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgayKu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTiendvNT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgayTT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTienDattNT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTiendvVND, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_ku, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTiendattVND, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTiendvNT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTiendattNT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTiendvVND, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTiendattVND, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgayKu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgayTT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_nt, 0);
		lblMa_ku.AutoSize = true;
		Label obj4 = lblMa_ku;
		location = new Point(18, 47);
		((Control)obj4).Location = location;
		((Control)lblMa_ku).Name = "lblMa_ku";
		Label obj5 = lblMa_ku;
		size = new Size(64, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_ku).TabIndex = 100;
		lblMa_ku.Text = "Mã khế ước";
		txtMa_ku.AutoLookup = true;
		txtMa_ku.AutoValid = true;
		((TextBoxBase)txtMa_ku).BackColor = SystemColors.Info;
		((TextBox)txtMa_ku).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_ku;
		location = new Point(131, 44);
		((Control)asTextBox).Location = location;
		txtMa_ku.LookupCodeName = "MA_KU";
		((Control)txtMa_ku).Name = "txtMa_ku";
		txtMa_ku.NameControl = lblTen_ku;
		txtMa_ku.SD = true;
		AsTextBox asTextBox2 = txtMa_ku;
		size = new Size(108, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_ku).TabIndex = 1;
		txtMa_ku.UseAutoCompleteSource = true;
		txtMa_ku.ValidReturnFieldList = "TEN_KU,NGAY_VAY,TK_VAY,MA_NT";
		Label obj6 = lblTen_ku;
		location = new Point(250, 48);
		((Control)obj6).Location = location;
		((Control)lblTen_ku).Name = "lblTen_ku";
		Label obj7 = lblTen_ku;
		size = new Size(217, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_ku).TabIndex = 100;
		Label obj8 = lblTen_tk;
		location = new Point(250, 74);
		((Control)obj8).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj9 = lblTen_tk;
		size = new Size(217, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_tk).TabIndex = 100;
		lblMa_tk.AutoSize = true;
		Label obj10 = lblMa_tk;
		location = new Point(18, 73);
		((Control)obj10).Location = location;
		((Control)lblMa_tk).Name = "lblMa_tk";
		Label obj11 = lblMa_tk;
		size = new Size(39, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_tk).TabIndex = 100;
		lblMa_tk.Text = "Mã TK";
		txtMa_tk.AutoLookup = true;
		txtMa_tk.AutoValid = true;
		((TextBoxBase)txtMa_tk).BackColor = SystemColors.Info;
		((TextBox)txtMa_tk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_tk;
		location = new Point(131, 70);
		((Control)asTextBox3).Location = location;
		txtMa_tk.LookupCodeName = "TK";
		txtMa_tk.LookupWhereCondition = "chi_tiet=1";
		((Control)txtMa_tk).Name = "txtMa_tk";
		txtMa_tk.NameControl = lblTen_tk;
		txtMa_tk.SD = true;
		AsTextBox asTextBox4 = txtMa_tk;
		size = new Size(108, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_tk).TabIndex = 2;
		txtMa_tk.UseAutoCompleteSource = true;
		lblMa_nt.AutoSize = true;
		Label obj12 = lblMa_nt;
		location = new Point(18, 150);
		((Control)obj12).Location = location;
		((Control)lblMa_nt).Name = "lblMa_nt";
		Label obj13 = lblMa_nt;
		size = new Size(40, 13);
		((Control)obj13).Size = size;
		((Control)lblMa_nt).TabIndex = 100;
		lblMa_nt.Text = "Mã NT";
		txtTiendvNT.DecimalSymbol = ".";
		txtTiendvNT.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtTiendvNT;
		location = new Point(131, 173);
		((Control)asTextNumeric).Location = location;
		txtTiendvNT.Mask = "### ### ### ###.##";
		((Control)txtTiendvNT).Name = "txtTiendvNT";
		AsTextNumeric asTextNumeric2 = txtTiendvNT;
		size = new Size(108, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtTiendvNT).TabIndex = 6;
		((Control)txtTiendvNT).Tag = "FA";
		((TextBox)txtTiendvNT).Text = "0.00";
		((TextBox)txtTiendvNT).TextAlign = (HorizontalAlignment)1;
		txtTiendvNT.Value = 0;
		lblTiendvNT.AutoSize = true;
		Label obj14 = lblTiendvNT;
		location = new Point(18, 176);
		((Control)obj14).Location = location;
		((Control)lblTiendvNT).Name = "lblTiendvNT";
		Label obj15 = lblTiendvNT;
		size = new Size(64, 13);
		((Control)obj15).Size = size;
		((Control)lblTiendvNT).TabIndex = 100;
		lblTiendvNT.Text = "Tiền đã vay";
		lblTiendvVND.AutoSize = true;
		Label obj16 = lblTiendvVND;
		location = new Point(258, 177);
		((Control)obj16).Location = location;
		((Control)lblTiendvVND).Name = "lblTiendvVND";
		Label obj17 = lblTiendvVND;
		size = new Size(90, 13);
		((Control)obj17).Size = size;
		((Control)lblTiendvVND).TabIndex = 100;
		lblTiendvVND.Text = "Tiền đã vay VND";
		txtTiendvVND.DecimalSymbol = ".";
		txtTiendvVND.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtTiendvVND;
		location = new Point(359, 173);
		((Control)asTextNumeric3).Location = location;
		txtTiendvVND.Mask = "### ### ### ###";
		((Control)txtTiendvVND).Name = "txtTiendvVND";
		AsTextNumeric asTextNumeric4 = txtTiendvVND;
		size = new Size(108, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtTiendvVND).TabIndex = 7;
		((Control)txtTiendvVND).Tag = "OA";
		((TextBox)txtTiendvVND).Text = "0";
		((TextBox)txtTiendvVND).TextAlign = (HorizontalAlignment)1;
		txtTiendvVND.Value = 0;
		lblTienDattNT.AutoSize = true;
		Label obj18 = lblTienDattNT;
		location = new Point(18, 201);
		((Control)obj18).Location = location;
		((Control)lblTienDattNT).Name = "lblTienDattNT";
		Label obj19 = lblTienDattNT;
		size = new Size(61, 13);
		((Control)obj19).Size = size;
		((Control)lblTienDattNT).TabIndex = 100;
		lblTienDattNT.Text = "Tiền đã TT";
		lblTiendattVND.AutoSize = true;
		Label obj20 = lblTiendattVND;
		location = new Point(258, 202);
		((Control)obj20).Location = location;
		((Control)lblTiendattVND).Name = "lblTiendattVND";
		Label obj21 = lblTiendattVND;
		size = new Size(87, 13);
		((Control)obj21).Size = size;
		((Control)lblTiendattVND).TabIndex = 100;
		lblTiendattVND.Text = "Tiền đã TT VND";
		txtTiendattNT.DecimalSymbol = ".";
		txtTiendattNT.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtTiendattNT;
		location = new Point(131, 198);
		((Control)asTextNumeric5).Location = location;
		txtTiendattNT.Mask = "### ### ### ###.##";
		((Control)txtTiendattNT).Name = "txtTiendattNT";
		AsTextNumeric asTextNumeric6 = txtTiendattNT;
		size = new Size(108, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtTiendattNT).TabIndex = 8;
		((Control)txtTiendattNT).Tag = "FA";
		((TextBox)txtTiendattNT).Text = "0.00";
		((TextBox)txtTiendattNT).TextAlign = (HorizontalAlignment)1;
		txtTiendattNT.Value = 0;
		txtTiendattVND.DecimalSymbol = ".";
		txtTiendattVND.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtTiendattVND;
		location = new Point(359, 198);
		((Control)asTextNumeric7).Location = location;
		txtTiendattVND.Mask = "### ### ### ###";
		((Control)txtTiendattVND).Name = "txtTiendattVND";
		AsTextNumeric asTextNumeric8 = txtTiendattVND;
		size = new Size(108, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtTiendattVND).TabIndex = 9;
		((Control)txtTiendattVND).Tag = "OA";
		((TextBox)txtTiendattVND).Text = "0";
		((TextBox)txtTiendattVND).TextAlign = (HorizontalAlignment)1;
		txtTiendattVND.Value = 0;
		((Control)txtNgayKu).Enabled = false;
		txtNgayKu.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgayKu).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgayKu;
		location = new Point(131, 96);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgayKu).Mask = "##/##/####";
		((Control)txtNgayKu).Name = "txtNgayKu";
		((MaskedTextBox)txtNgayKu).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgayKu;
		size = new Size(108, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgayKu).TabIndex = 3;
		((Control)txtNgayKu).TabStop = false;
		((MaskedTextBox)txtNgayKu).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgayKu;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		lblNgayKu.AutoSize = true;
		Label obj22 = lblNgayKu;
		location = new Point(18, 99);
		((Control)obj22).Location = location;
		((Control)lblNgayKu).Name = "lblNgayKu";
		Label obj23 = lblNgayKu;
		size = new Size(74, 13);
		((Control)obj23).Size = size;
		((Control)lblNgayKu).TabIndex = 100;
		lblNgayKu.Text = "Ngày khế ước";
		lblNgayTT.AutoSize = true;
		Label obj24 = lblNgayTT;
		location = new Point(18, 124);
		((Control)obj24).Location = location;
		((Control)lblNgayTT).Name = "lblNgayTT";
		Label obj25 = lblNgayTT;
		size = new Size(86, 13);
		((Control)obj25).Size = size;
		((Control)lblNgayTT).TabIndex = 100;
		lblNgayTT.Text = "Ngày thanh toán";
		txtNgayTT.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgayTT).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgayTT;
		location = new Point(131, 121);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgayTT).Mask = "##/##/####";
		((Control)txtNgayTT).Name = "txtNgayTT";
		((MaskedTextBox)txtNgayTT).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgayTT;
		size = new Size(108, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgayTT).TabIndex = 4;
		((MaskedTextBox)txtNgayTT).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgayTT;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		lblYear.AutoSize = true;
		Label obj26 = lblYear;
		location = new Point(18, 21);
		((Control)obj26).Location = location;
		((Control)lblYear).Name = "lblYear";
		Label obj27 = lblYear;
		size = new Size(74, 13);
		((Control)obj27).Size = size;
		((Control)lblYear).TabIndex = 101;
		lblYear.Text = "Năm tài chính";
		txtYear.DecimalSymbol = ".";
		txtYear.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric9 = txtYear;
		location = new Point(131, 18);
		((Control)asTextNumeric9).Location = location;
		txtYear.Mask = "####";
		((Control)txtYear).Name = "txtYear";
		((TextBoxBase)txtYear).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtYear;
		size = new Size(108, 20);
		((Control)asTextNumeric10).Size = size;
		((Control)txtYear).TabIndex = 0;
		((Control)txtYear).TabStop = false;
		((TextBox)txtYear).Text = "0";
		((TextBox)txtYear).TextAlign = (HorizontalAlignment)1;
		txtYear.Value = 0;
		((Control)txtMa_nt).Enabled = false;
		TextBox obj28 = txtMa_nt;
		location = new Point(131, 147);
		((Control)obj28).Location = location;
		((Control)txtMa_nt).Name = "txtMa_nt";
		TextBox obj29 = txtMa_nt;
		size = new Size(108, 20);
		((Control)obj29).Size = size;
		((Control)txtMa_nt).TabIndex = 5;
		((Control)txtMa_nt).TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(506, 275);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCACDKUEdit";
		((Control)this).Tag = "FA";
		((Form)this).Text = "Số dư đầu kỳ khế ước";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			txtYear.Value = SystemInformations.FinancialYear;
			((Control)txtMa_ku).Select();
		}
		else
		{
			((Control)txtMa_tk).Select();
		}
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_ku).Enabled = false;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_ku))
		{
			epNotice.SetError((Control)(object)txtMa_ku, Helper.GetMess(50002).Description);
			((Control)txtMa_ku).Select();
			return false;
		}
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_tk))
		{
			epNotice.SetError((Control)(object)txtMa_tk, Helper.GetMess(50002).Description);
			((Control)txtMa_tk).Select();
			return false;
		}
		return base.ValidData();
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_ku).Select();
		}
		else
		{
			RowToEdit["ten_ku"] = lblTen_ku.Text;
			if (Operators.CompareString(txtMa_nt.Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				RowToEdit["da_vay"] = RuntimeHelpers.GetObjectValue(txtTiendvNT.Value);
				RowToEdit["da_tt"] = RuntimeHelpers.GetObjectValue(txtTiendattNT.Value);
			}
		}
		return flag;
	}

	protected override bool UpdateDB()
	{
		bool flag = base.UpdateDB();
		if (flag)
		{
			RowToEdit["ten_ku"] = lblTen_ku.Text;
			if (Operators.CompareString(txtMa_nt.Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				RowToEdit["da_vay"] = RuntimeHelpers.GetObjectValue(txtTiendvNT.Value);
				RowToEdit["da_tt"] = RuntimeHelpers.GetObjectValue(txtTiendattNT.Value);
			}
		}
		return flag;
	}

	protected override void DataBinding()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtYear;
		CreateDataBinding(ref ojb, "nam", "value");
		txtYear = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMa_ku;
		CreateDataBinding(ref ojb, "ma_ku");
		txtMa_ku = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_ku;
		CreateDataBinding(ref ojb, "ten_ku");
		lblTen_ku = (Label)ojb;
		ojb = (Control)(object)txtMa_tk;
		CreateDataBinding(ref ojb, "tk");
		txtMa_tk = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_tk;
		CreateDataBinding(ref ojb, "ten_tk");
		lblTen_tk = (Label)ojb;
		ojb = (Control)(object)txtNgayKu;
		CreateDataBinding(ref ojb, "ngay_ku", "value");
		txtNgayKu = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgayTT;
		CreateDataBinding(ref ojb, "ngay_tt", "value");
		txtNgayTT = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtTiendattNT;
		CreateDataBinding(ref ojb, "da_tt_nt", "value");
		txtTiendattNT = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTiendattVND;
		CreateDataBinding(ref ojb, "da_tt", "value");
		txtTiendattVND = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTiendvNT;
		CreateDataBinding(ref ojb, "da_vay_nt", "value");
		txtTiendvNT = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTiendvVND;
		CreateDataBinding(ref ojb, "da_vay", "value");
		txtTiendvVND = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMa_nt;
		CreateDataBinding(ref ojb, "ma_nt");
		txtMa_nt = (TextBox)ojb;
	}

	private void txtMa_nt_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(txtMa_nt.Text, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
		{
			InitControl(bShow: false);
		}
		else
		{
			InitControl(bShow: true);
		}
		MaskTextBoxAll(((Control)gbLine).Controls);
	}

	private void txtMa_ku_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (Operators.CompareString(((TextBox)txtMa_ku).Text, "", false) != 0)
		{
			txtNgayKu.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ngay_vay"]);
			((TextBox)txtMa_tk).Text = Conversions.ToString(e.ValidatedRow["tk_vay"]);
			txtMa_nt.Text = Conversions.ToString(e.ValidatedRow["ma_nt"]);
		}
	}

	protected void InitControl(bool bShow)
	{
		lblTiendvNT.Text = "Tiền đã vay " + txtMa_nt.Text;
		lblTienDattNT.Text = "Tiền đã TT " + txtMa_nt.Text;
		((Control)txtTiendvVND).Visible = bShow;
		((Control)txtTiendattVND).Visible = bShow;
		((Control)lblTiendvVND).Visible = bShow;
		((Control)lblTiendattVND).Visible = bShow;
		if (bShow)
		{
			((Control)txtTiendattNT).Tag = "FA";
			((Control)txtTiendvNT).Tag = "FA";
		}
		else
		{
			((Control)txtTiendattNT).Tag = "OA";
			((Control)txtTiendvNT).Tag = "OA";
		}
	}

	private void MaskTextBoxAll(ControlCollection ctl)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
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
