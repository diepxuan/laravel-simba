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
public class frmFARptBCPT01 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_BPSD")]
	private AsTextBox _txtMa_BPSD;

	[AccessedThroughProperty("lblTen_BPSD")]
	private Label _lblTen_BPSD;

	[AccessedThroughProperty("lblMa_BPSD")]
	private Label _lblMa_BPSD;

	[AccessedThroughProperty("txtMa_ts")]
	private AsTextBox _txtMa_ts;

	[AccessedThroughProperty("lblTen_ts")]
	private Label _lblTen_ts;

	[AccessedThroughProperty("lblMa_ts")]
	private Label _lblMa_ts;

	[AccessedThroughProperty("txtMa_Nhts1")]
	private AsTextBox _txtMa_Nhts1;

	[AccessedThroughProperty("lblTen_Nhts1")]
	private Label _lblTen_Nhts1;

	[AccessedThroughProperty("lblMa_Nhts1")]
	private Label _lblMa_Nhts1;

	[AccessedThroughProperty("txtMa_Nhts3")]
	private AsTextBox _txtMa_Nhts3;

	[AccessedThroughProperty("lblTen_Nhts3")]
	private Label _lblTen_Nhts3;

	[AccessedThroughProperty("lblMa_Nhts3")]
	private Label _lblMa_Nhts3;

	[AccessedThroughProperty("txtMa_Phi")]
	private AsTextBox _txtMa_Phi;

	[AccessedThroughProperty("lblTen_Phi")]
	private Label _lblTen_Phi;

	[AccessedThroughProperty("lblMa_Phi")]
	private Label _lblMa_Phi;

	[AccessedThroughProperty("lblMa_SPCT")]
	private Label _lblMa_SPCT;

	[AccessedThroughProperty("txtMa_SPCT")]
	private AsTextBox _txtMa_SPCT;

	[AccessedThroughProperty("lblTen_SPCT")]
	private Label _lblTen_SPCT;

	[AccessedThroughProperty("txtMa_Nhts2")]
	private AsTextBox _txtMa_Nhts2;

	[AccessedThroughProperty("lblTen_Nhts2")]
	private Label _lblTen_Nhts2;

	[AccessedThroughProperty("lblMa_Nhts2")]
	private Label _lblMa_Nhts2;

	[AccessedThroughProperty("lblTheo_nhom")]
	private Label _lblTheo_nhom;

	[AccessedThroughProperty("cboTheo_nhom")]
	private ComboBox _cboTheo_nhom;

	internal virtual AsTextBox txtMa_BPSD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_BPSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_BPSD = value;
		}
	}

	internal virtual Label lblTen_BPSD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_BPSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_BPSD = value;
		}
	}

	internal virtual Label lblMa_BPSD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_BPSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_BPSD = value;
		}
	}

	internal virtual AsTextBox txtMa_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_ts = value;
		}
	}

	internal virtual Label lblTen_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ts = value;
		}
	}

	internal virtual Label lblMa_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_ts = value;
		}
	}

	internal virtual AsTextBox txtMa_Nhts1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Nhts1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Nhts1 = value;
		}
	}

	internal virtual Label lblTen_Nhts1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhts1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhts1 = value;
		}
	}

	internal virtual Label lblMa_Nhts1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nhts1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nhts1 = value;
		}
	}

	internal virtual AsTextBox txtMa_Nhts3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Nhts3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Nhts3 = value;
		}
	}

	internal virtual Label lblTen_Nhts3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhts3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhts3 = value;
		}
	}

	internal virtual Label lblMa_Nhts3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nhts3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nhts3 = value;
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

	internal virtual Label lblMa_SPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_SPCT = value;
		}
	}

	internal virtual AsTextBox txtMa_SPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_SPCT = value;
		}
	}

	internal virtual Label lblTen_SPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_SPCT = value;
		}
	}

	internal virtual AsTextBox txtMa_Nhts2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Nhts2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Nhts2 = value;
		}
	}

	internal virtual Label lblTen_Nhts2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Nhts2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Nhts2 = value;
		}
	}

	internal virtual Label lblMa_Nhts2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nhts2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nhts2 = value;
		}
	}

	internal virtual Label lblTheo_nhom
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTheo_nhom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTheo_nhom = value;
		}
	}

	internal virtual ComboBox cboTheo_nhom
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboTheo_nhom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboTheo_nhom = value;
		}
	}

	public frmFARptBCPT01(ref string MenuId)
		: base(MenuId)
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		txtMa_BPSD = new AsTextBox();
		lblTen_BPSD = new Label();
		lblMa_BPSD = new Label();
		txtMa_ts = new AsTextBox();
		lblTen_ts = new Label();
		lblMa_ts = new Label();
		txtMa_Nhts1 = new AsTextBox();
		lblTen_Nhts1 = new Label();
		lblMa_Nhts1 = new Label();
		txtMa_Nhts3 = new AsTextBox();
		lblTen_Nhts3 = new Label();
		lblMa_Nhts3 = new Label();
		txtMa_Phi = new AsTextBox();
		lblTen_Phi = new Label();
		lblMa_Phi = new Label();
		lblMa_SPCT = new Label();
		txtMa_SPCT = new AsTextBox();
		lblTen_SPCT = new Label();
		txtMa_Nhts2 = new AsTextBox();
		lblTen_Nhts2 = new Label();
		lblMa_Nhts2 = new Label();
		lblTheo_nhom = new Label();
		cboTheo_nhom = new ComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(581, 353);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)lblTheo_nhom);
		((Control)tabFilter).Controls.Add((Control)(object)cboTheo_nhom);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_BPSD);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_BPSD);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_BPSD);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_ts);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_ts);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Nhts1);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Nhts1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_ts);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nhts1);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Nhts3);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Nhts3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nhts3);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Nhts2);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Nhts2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Nhts2);
		TabPage obj = tabFilter;
		size = new Size(573, 324);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nhts2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Nhts2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nhts2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nhts3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Nhts3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nhts3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Nhts1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_ts, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Nhts1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nhts1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_ts, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_ts, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_BPSD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_BPSD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_BPSD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboTheo_nhom, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTheo_nhom, 0);
		Label obj2 = lbl2;
		Point location = new Point(290, 81);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 16;
		((Control)cmdExcel).Anchor = (AnchorStyles)10;
		Button obj3 = cmdExcel;
		location = new Point(489, 301);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 21;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(309, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		((Control)cmdCancel).Anchor = (AnchorStyles)10;
		Button obj4 = cmdCancel;
		location = new Point(408, 301);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 20;
		Button obj5 = cmdModifyReport;
		location = new Point(462, 23);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 12;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(219, 77);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(117, 77);
		((Control)obj6).Location = location;
		ComboBox obj7 = cboKyBc;
		size = new Size(87, 21);
		((Control)obj7).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		Label obj8 = lblKyBc;
		location = new Point(19, 81);
		((Control)obj8).Location = location;
		ComboBox obj9 = cboMau_bc;
		location = new Point(117, 24);
		((Control)obj9).Location = location;
		((Control)cboMau_bc).TabIndex = 13;
		Label obj10 = lblMau_bc;
		location = new Point(19, 28);
		((Control)obj10).Location = location;
		((Control)txtMa_Nt).Enabled = false;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(316, 334);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 11;
		((Control)txtMa_Nt).Visible = false;
		((Control)lblMauBC).Enabled = false;
		Label obj11 = lblMauBC;
		location = new Point(361, 333);
		((Control)obj11).Location = location;
		((Control)lblMauBC).TabIndex = 23;
		((Control)lblMauBC).Visible = false;
		((Control)optVND).Enabled = false;
		RadioButton obj12 = optVND;
		location = new Point(448, 332);
		((Control)obj12).Location = location;
		((Control)optVND).TabIndex = 12;
		((Control)optVND).Visible = false;
		((Control)optNt).Enabled = false;
		RadioButton obj13 = optNt;
		location = new Point(502, 333);
		((Control)obj13).Location = location;
		((Control)optNt).TabIndex = 13;
		((Control)optNt).Visible = false;
		((Control)lblMa_nt).Enabled = false;
		Label obj14 = lblMa_nt;
		location = new Point(246, 340);
		((Control)obj14).Location = location;
		((Control)lblMa_nt).TabIndex = 22;
		((Control)lblMa_nt).Visible = false;
		Button obj15 = cmdOk;
		location = new Point(22, 283);
		((Control)obj15).Location = location;
		((Control)cmdOk).TabIndex = 11;
		Label obj16 = lblTieu_de;
		location = new Point(19, 56);
		((Control)obj16).Location = location;
		((Control)lblTieu_de).TabIndex = 19;
		TextBox obj17 = txtTieu_De;
		location = new Point(117, 52);
		((Control)obj17).Location = location;
		((Control)txtTieu_De).TabIndex = 14;
		TabPage obj18 = tabGrid;
		size = new Size(603, 331);
		((Control)obj18).Size = size;
		txtMa_BPSD.AutoLookup = true;
		txtMa_BPSD.AutoValid = false;
		((TextBoxBase)txtMa_BPSD).BackColor = SystemColors.Info;
		((TextBox)txtMa_BPSD).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_BPSD;
		location = new Point(117, 199);
		((Control)asTextBox2).Location = location;
		txtMa_BPSD.LookupCodeName = "MA_BPSD";
		((TextBoxBase)txtMa_BPSD).MaxLength = 8;
		((Control)txtMa_BPSD).Name = "txtMa_BPSD";
		txtMa_BPSD.NameControl = lblTen_BPSD;
		AsTextBox asTextBox3 = txtMa_BPSD;
		size = new Size(87, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_BPSD).TabIndex = 7;
		((Control)lblTen_BPSD).BackColor = Color.Transparent;
		Label obj19 = lblTen_BPSD;
		location = new Point(219, 203);
		((Control)obj19).Location = location;
		((Control)lblTen_BPSD).Name = "lblTen_BPSD";
		Label obj20 = lblTen_BPSD;
		size = new Size(318, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_BPSD).TabIndex = 1302;
		lblMa_BPSD.AutoSize = true;
		Label obj21 = lblMa_BPSD;
		location = new Point(19, 203);
		((Control)obj21).Location = location;
		((Control)lblMa_BPSD).Name = "lblMa_BPSD";
		Label obj22 = lblMa_BPSD;
		size = new Size(54, 13);
		((Control)obj22).Size = size;
		((Control)lblMa_BPSD).TabIndex = 1301;
		lblMa_BPSD.Text = "Mã BPSD";
		txtMa_ts.AutoLookup = true;
		txtMa_ts.AutoValid = false;
		((TextBoxBase)txtMa_ts).BackColor = SystemColors.Info;
		((TextBox)txtMa_ts).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_ts;
		location = new Point(117, 103);
		((Control)asTextBox4).Location = location;
		txtMa_ts.LookupCodeName = "MA_TS";
		((TextBoxBase)txtMa_ts).MaxLength = 8;
		((Control)txtMa_ts).Name = "txtMa_ts";
		txtMa_ts.NameControl = lblTen_ts;
		AsTextBox asTextBox5 = txtMa_ts;
		size = new Size(87, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_ts).TabIndex = 3;
		((Control)lblTen_ts).BackColor = Color.Transparent;
		Label obj23 = lblTen_ts;
		location = new Point(219, 107);
		((Control)obj23).Location = location;
		((Control)lblTen_ts).Name = "lblTen_ts";
		Label obj24 = lblTen_ts;
		size = new Size(318, 13);
		((Control)obj24).Size = size;
		((Control)lblTen_ts).TabIndex = 1300;
		lblMa_ts.AutoSize = true;
		Label obj25 = lblMa_ts;
		location = new Point(19, 107);
		((Control)obj25).Location = location;
		((Control)lblMa_ts).Name = "lblMa_ts";
		Label obj26 = lblMa_ts;
		size = new Size(39, 13);
		((Control)obj26).Size = size;
		((Control)lblMa_ts).TabIndex = 1298;
		lblMa_ts.Text = "Mã TS";
		txtMa_Nhts1.AutoLookup = true;
		txtMa_Nhts1.AutoValid = false;
		((TextBoxBase)txtMa_Nhts1).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nhts1).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_Nhts1;
		location = new Point(117, 127);
		((Control)asTextBox6).Location = location;
		txtMa_Nhts1.LookupCodeName = "MA_NHTS";
		txtMa_Nhts1.LookupWhereCondition = "loai_nh=1";
		((TextBoxBase)txtMa_Nhts1).MaxLength = 8;
		((Control)txtMa_Nhts1).Name = "txtMa_Nhts1";
		txtMa_Nhts1.NameControl = lblTen_Nhts1;
		AsTextBox asTextBox7 = txtMa_Nhts1;
		size = new Size(87, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_Nhts1).TabIndex = 4;
		((Control)lblTen_Nhts1).BackColor = Color.Transparent;
		Label obj27 = lblTen_Nhts1;
		location = new Point(219, 131);
		((Control)obj27).Location = location;
		((Control)lblTen_Nhts1).Name = "lblTen_Nhts1";
		Label obj28 = lblTen_Nhts1;
		size = new Size(318, 13);
		((Control)obj28).Size = size;
		((Control)lblTen_Nhts1).TabIndex = 1299;
		lblMa_Nhts1.AutoSize = true;
		Label obj29 = lblMa_Nhts1;
		location = new Point(19, 131);
		((Control)obj29).Location = location;
		((Control)lblMa_Nhts1).Name = "lblMa_Nhts1";
		Label obj30 = lblMa_Nhts1;
		size = new Size(74, 13);
		((Control)obj30).Size = size;
		((Control)lblMa_Nhts1).TabIndex = 1297;
		lblMa_Nhts1.Text = "Mã nhóm TS1";
		txtMa_Nhts3.AutoLookup = true;
		txtMa_Nhts3.AutoValid = false;
		((TextBoxBase)txtMa_Nhts3).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nhts3).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_Nhts3;
		location = new Point(117, 175);
		((Control)asTextBox8).Location = location;
		txtMa_Nhts3.LookupCodeName = "MA_NHTS";
		txtMa_Nhts3.LookupWhereCondition = "loai_nh=3";
		((TextBoxBase)txtMa_Nhts3).MaxLength = 8;
		((Control)txtMa_Nhts3).Name = "txtMa_Nhts3";
		txtMa_Nhts3.NameControl = lblTen_Nhts3;
		AsTextBox asTextBox9 = txtMa_Nhts3;
		size = new Size(87, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_Nhts3).TabIndex = 6;
		((Control)lblTen_Nhts3).BackColor = Color.Transparent;
		Label obj31 = lblTen_Nhts3;
		location = new Point(219, 179);
		((Control)obj31).Location = location;
		((Control)lblTen_Nhts3).Name = "lblTen_Nhts3";
		Label obj32 = lblTen_Nhts3;
		size = new Size(318, 13);
		((Control)obj32).Size = size;
		((Control)lblTen_Nhts3).TabIndex = 1296;
		lblMa_Nhts3.AutoSize = true;
		Label obj33 = lblMa_Nhts3;
		location = new Point(19, 179);
		((Control)obj33).Location = location;
		((Control)lblMa_Nhts3).Name = "lblMa_Nhts3";
		Label obj34 = lblMa_Nhts3;
		size = new Size(74, 13);
		((Control)obj34).Size = size;
		((Control)lblMa_Nhts3).TabIndex = 1293;
		lblMa_Nhts3.Text = "Mã nhóm TS3";
		txtMa_Phi.AutoLookup = true;
		txtMa_Phi.AutoValid = false;
		((TextBoxBase)txtMa_Phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_Phi;
		location = new Point(117, 223);
		((Control)asTextBox10).Location = location;
		txtMa_Phi.LookupCodeName = "MA_PHI";
		((TextBoxBase)txtMa_Phi).MaxLength = 8;
		((Control)txtMa_Phi).Name = "txtMa_Phi";
		txtMa_Phi.NameControl = lblTen_Phi;
		AsTextBox asTextBox11 = txtMa_Phi;
		size = new Size(87, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_Phi).TabIndex = 8;
		((Control)lblTen_Phi).BackColor = Color.Transparent;
		Label obj35 = lblTen_Phi;
		location = new Point(219, 227);
		((Control)obj35).Location = location;
		((Control)lblTen_Phi).Name = "lblTen_Phi";
		Label obj36 = lblTen_Phi;
		size = new Size(318, 13);
		((Control)obj36).Size = size;
		((Control)lblTen_Phi).TabIndex = 1295;
		lblMa_Phi.AutoSize = true;
		Label obj37 = lblMa_Phi;
		location = new Point(19, 227);
		((Control)obj37).Location = location;
		((Control)lblMa_Phi).Name = "lblMa_Phi";
		Label obj38 = lblMa_Phi;
		size = new Size(41, 13);
		((Control)obj38).Size = size;
		((Control)lblMa_Phi).TabIndex = 1294;
		lblMa_Phi.Text = "Mã phí";
		lblMa_SPCT.AutoSize = true;
		Label obj39 = lblMa_SPCT;
		location = new Point(19, 251);
		((Control)obj39).Location = location;
		((Control)lblMa_SPCT).Name = "lblMa_SPCT";
		Label obj40 = lblMa_SPCT;
		size = new Size(53, 13);
		((Control)obj40).Size = size;
		((Control)lblMa_SPCT).TabIndex = 1291;
		lblMa_SPCT.Text = "Mã SPCT";
		txtMa_SPCT.AutoLookup = true;
		txtMa_SPCT.AutoValid = false;
		((TextBoxBase)txtMa_SPCT).BackColor = SystemColors.Info;
		((TextBox)txtMa_SPCT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_SPCT;
		location = new Point(117, 247);
		((Control)asTextBox12).Location = location;
		txtMa_SPCT.LookupCodeName = "MA_SPCT";
		((TextBoxBase)txtMa_SPCT).MaxLength = 8;
		((Control)txtMa_SPCT).Name = "txtMa_SPCT";
		txtMa_SPCT.NameControl = lblTen_SPCT;
		AsTextBox asTextBox13 = txtMa_SPCT;
		size = new Size(87, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_SPCT).TabIndex = 9;
		((Control)lblTen_SPCT).BackColor = Color.Transparent;
		Label obj41 = lblTen_SPCT;
		location = new Point(219, 251);
		((Control)obj41).Location = location;
		((Control)lblTen_SPCT).Name = "lblTen_SPCT";
		Label obj42 = lblTen_SPCT;
		size = new Size(318, 13);
		((Control)obj42).Size = size;
		((Control)lblTen_SPCT).TabIndex = 1292;
		txtMa_Nhts2.AutoLookup = true;
		txtMa_Nhts2.AutoValid = false;
		((TextBoxBase)txtMa_Nhts2).BackColor = SystemColors.Info;
		((TextBox)txtMa_Nhts2).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox14 = txtMa_Nhts2;
		location = new Point(117, 151);
		((Control)asTextBox14).Location = location;
		txtMa_Nhts2.LookupCodeName = "MA_NHTS";
		txtMa_Nhts2.LookupWhereCondition = "loai_nh=2";
		((TextBoxBase)txtMa_Nhts2).MaxLength = 8;
		((Control)txtMa_Nhts2).Name = "txtMa_Nhts2";
		txtMa_Nhts2.NameControl = lblTen_Nhts2;
		AsTextBox asTextBox15 = txtMa_Nhts2;
		size = new Size(87, 20);
		((Control)asTextBox15).Size = size;
		((Control)txtMa_Nhts2).TabIndex = 5;
		((Control)lblTen_Nhts2).BackColor = Color.Transparent;
		Label obj43 = lblTen_Nhts2;
		location = new Point(219, 155);
		((Control)obj43).Location = location;
		((Control)lblTen_Nhts2).Name = "lblTen_Nhts2";
		Label obj44 = lblTen_Nhts2;
		size = new Size(318, 13);
		((Control)obj44).Size = size;
		((Control)lblTen_Nhts2).TabIndex = 1290;
		lblMa_Nhts2.AutoSize = true;
		Label obj45 = lblMa_Nhts2;
		location = new Point(19, 155);
		((Control)obj45).Location = location;
		((Control)lblMa_Nhts2).Name = "lblMa_Nhts2";
		Label obj46 = lblMa_Nhts2;
		size = new Size(74, 13);
		((Control)obj46).Size = size;
		((Control)lblMa_Nhts2).TabIndex = 1289;
		lblMa_Nhts2.Text = "Mã nhóm TS2";
		lblTheo_nhom.AutoSize = true;
		Label obj47 = lblTheo_nhom;
		location = new Point(364, 327);
		((Control)obj47).Location = location;
		((Control)lblTheo_nhom).Name = "lblTheo_nhom";
		Label obj48 = lblTheo_nhom;
		size = new Size(61, 13);
		((Control)obj48).Size = size;
		((Control)lblTheo_nhom).TabIndex = 1304;
		lblTheo_nhom.Text = "Theo nhóm";
		((Control)lblTheo_nhom).Visible = false;
		cboTheo_nhom.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboTheo_nhom).FormattingEnabled = true;
		cboTheo_nhom.Items.AddRange(new object[3] { "BP sử dụng", "Mã phí", "Mã SPCT" });
		ComboBox obj49 = cboTheo_nhom;
		location = new Point(462, 323);
		((Control)obj49).Location = location;
		((Control)cboTheo_nhom).Name = "cboTheo_nhom";
		ComboBox obj50 = cboTheo_nhom;
		size = new Size(87, 21);
		((Control)obj50).Size = size;
		((Control)cboTheo_nhom).TabIndex = 10;
		((Control)cboTheo_nhom).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(581, 378);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFARptBCPT01";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		((Control)cboKyBc).Select();
		cboTheo_nhom.SelectedIndex = 0;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMa_ts).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Nhts1).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Nhts2).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Nhts3).Text.Trim());
		arrayList.Add(((TextBox)txtMa_BPSD).Text.Trim());
		arrayList.Add(((TextBox)txtMa_Phi).Text.Trim());
		arrayList.Add(((TextBox)txtMa_SPCT).Text.Trim());
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strSubTitle1", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = string.Empty;
		if (Operators.CompareString(((TextBox)txtMa_ts).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_ts.Text + ": " + ((TextBox)txtMa_ts).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nhts1).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Nhts1.Text + ": " + ((TextBox)txtMa_Nhts1).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nhts2).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Nhts2.Text + ": " + ((TextBox)txtMa_Nhts2).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nhts3).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Nhts3.Text + ": " + ((TextBox)txtMa_Nhts3).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_BPSD).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_BPSD.Text + ": " + ((TextBox)txtMa_BPSD).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Phi).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_Phi.Text + ": " + ((TextBox)txtMa_Phi).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_SPCT).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_SPCT.Text + ": " + ((TextBox)txtMa_SPCT).Text + "; ";
		}
		if (text.Length > 2)
		{
			text = text.Substring(0, checked(text.Length - 2));
		}
		return text;
	}
}
