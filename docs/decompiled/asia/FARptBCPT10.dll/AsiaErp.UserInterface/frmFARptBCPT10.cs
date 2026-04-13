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
public class frmFARptBCPT10 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTheo_nhom")]
	private Label _lblTheo_nhom;

	[AccessedThroughProperty("cboTheo_nhom")]
	private ComboBox _cboTheo_nhom;

	[AccessedThroughProperty("txtMa_BPSD")]
	private AsTextBox _txtMa_BPSD;

	[AccessedThroughProperty("lblTen_BPSD")]
	private Label _lblTen_BPSD;

	[AccessedThroughProperty("lblMa_BPSD")]
	private Label _lblMa_BPSD;

	[AccessedThroughProperty("txtTK_CP")]
	private AsTextBox _txtTK_CP;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("lblTK_CP")]
	private Label _lblTK_CP;

	[AccessedThroughProperty("txtTK_PB")]
	private AsTextBox _txtTK_PB;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("lblTK_PB")]
	private Label _lblTK_PB;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("lblMa_SPCT")]
	private Label _lblMa_SPCT;

	[AccessedThroughProperty("txtMa_phi")]
	private AsTextBox _txtMa_phi;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("lblMa_phi")]
	private Label _lblMa_phi;

	[AccessedThroughProperty("txtMa_cc")]
	private AsTextBox _txtMa_cc;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblMa_cc")]
	private Label _lblMa_cc;

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

	internal virtual AsTextBox txtTK_CP
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_CP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_CP = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Label lblTK_CP
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_CP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_CP = value;
		}
	}

	internal virtual AsTextBox txtTK_PB
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_PB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_PB = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label lblTK_PB
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_PB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_PB = value;
		}
	}

	internal virtual AsTextBox txtMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_spct = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
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

	internal virtual AsTextBox txtMa_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_phi = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label lblMa_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_phi = value;
		}
	}

	internal virtual AsTextBox txtMa_cc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_cc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_cc = value;
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

	internal virtual Label lblMa_cc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_cc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_cc = value;
		}
	}

	public frmFARptBCPT10(ref string MenuId)
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		lblTheo_nhom = new Label();
		cboTheo_nhom = new ComboBox();
		txtMa_BPSD = new AsTextBox();
		lblTen_BPSD = new Label();
		lblMa_BPSD = new Label();
		txtMa_cc = new AsTextBox();
		Label1 = new Label();
		lblMa_cc = new Label();
		txtMa_phi = new AsTextBox();
		Label3 = new Label();
		lblMa_phi = new Label();
		txtMa_spct = new AsTextBox();
		Label5 = new Label();
		lblMa_SPCT = new Label();
		txtTK_PB = new AsTextBox();
		Label7 = new Label();
		lblTK_PB = new Label();
		txtTK_CP = new AsTextBox();
		Label9 = new Label();
		lblTK_CP = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(644, 349);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)txtTK_CP);
		((Control)tabFilter).Controls.Add((Control)(object)lblTK_CP);
		((Control)tabFilter).Controls.Add((Control)(object)Label9);
		((Control)tabFilter).Controls.Add((Control)(object)txtTK_PB);
		((Control)tabFilter).Controls.Add((Control)(object)lblTK_PB);
		((Control)tabFilter).Controls.Add((Control)(object)Label7);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)Label5);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_phi);
		((Control)tabFilter).Controls.Add((Control)(object)Label3);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_cc);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_cc);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)lblTheo_nhom);
		((Control)tabFilter).Controls.Add((Control)(object)cboTheo_nhom);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_BPSD);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_BPSD);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_BPSD);
		TabPage obj = tabFilter;
		size = new Size(636, 320);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_BPSD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_BPSD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_BPSD, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboTheo_nhom, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTheo_nhom, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_cc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_cc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK_PB, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK_PB, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label9, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTK_CP, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTK_CP, 0);
		Label obj2 = lbl2;
		Point location = new Point(286, 82);
		((Control)obj2).Location = location;
		((Control)lbl2).TabIndex = 6;
		((Control)cmdExcel).Anchor = (AnchorStyles)10;
		Button obj3 = cmdExcel;
		location = new Point(524, 352);
		((Control)obj3).Location = location;
		((Control)cmdExcel).TabIndex = 15;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(302, 78);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		((Control)cmdCancel).Anchor = (AnchorStyles)10;
		Button obj4 = cmdCancel;
		location = new Point(443, 352);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 14;
		Button obj5 = cmdModifyReport;
		location = new Point(462, 24);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 11;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(215, 78);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(117, 78);
		((Control)obj6).Location = location;
		ComboBox obj7 = cboKyBc;
		size = new Size(87, 21);
		((Control)obj7).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		ComboBox obj8 = cboMau_bc;
		location = new Point(117, 25);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 10;
		Label obj9 = lblMau_bc;
		location = new Point(24, 29);
		((Control)obj9).Location = location;
		((Control)txtMa_Nt).Enabled = false;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(373, 309);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 11;
		((Control)txtMa_Nt).Visible = false;
		((Control)lblMauBC).Enabled = false;
		Label obj10 = lblMauBC;
		location = new Point(418, 321);
		((Control)obj10).Location = location;
		Label obj11 = lblMauBC;
		size = new Size(72, 10);
		((Control)obj11).Size = size;
		((Control)lblMauBC).Visible = false;
		((Control)optVND).Enabled = false;
		RadioButton obj12 = optVND;
		location = new Point(505, 321);
		((Control)obj12).Location = location;
		RadioButton obj13 = optVND;
		size = new Size(48, 10);
		((Control)obj13).Size = size;
		((Control)optVND).TabIndex = 12;
		((Control)optVND).Visible = false;
		((Control)optNt).Enabled = false;
		RadioButton obj14 = optNt;
		location = new Point(559, 320);
		((Control)obj14).Location = location;
		RadioButton obj15 = optNt;
		size = new Size(71, 10);
		((Control)obj15).Size = size;
		((Control)optNt).TabIndex = 13;
		((Control)optNt).Visible = false;
		((Control)lblMa_nt).Enabled = false;
		Label obj16 = lblMa_nt;
		location = new Point(287, 317);
		((Control)obj16).Location = location;
		Label obj17 = lblMa_nt;
		size = new Size(64, 10);
		((Control)obj17).Size = size;
		((Control)lblMa_nt).TabIndex = 16;
		((Control)lblMa_nt).Visible = false;
		Button obj18 = cmdOk;
		location = new Point(27, 270);
		((Control)obj18).Location = location;
		((Control)cmdOk).TabIndex = 9;
		((Control)lblTieu_de).TabIndex = 17;
		TextBox obj19 = txtTieu_De;
		location = new Point(117, 52);
		((Control)obj19).Location = location;
		((Control)txtTieu_De).TabIndex = 12;
		TabPage obj20 = tabGrid;
		size = new Size(636, 320);
		((Control)obj20).Size = size;
		lblTheo_nhom.AutoSize = true;
		Label obj21 = lblTheo_nhom;
		location = new Point(373, 299);
		((Control)obj21).Location = location;
		((Control)lblTheo_nhom).Name = "lblTheo_nhom";
		Label obj22 = lblTheo_nhom;
		size = new Size(61, 13);
		((Control)obj22).Size = size;
		((Control)lblTheo_nhom).TabIndex = 1347;
		lblTheo_nhom.Text = "Theo nhóm";
		((Control)lblTheo_nhom).Visible = false;
		cboTheo_nhom.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboTheo_nhom).FormattingEnabled = true;
		cboTheo_nhom.Items.AddRange(new object[3] { "BP sử dụng", "Mã phí", "Mã SPCT" });
		ComboBox obj23 = cboTheo_nhom;
		location = new Point(466, 295);
		((Control)obj23).Location = location;
		((Control)cboTheo_nhom).Name = "cboTheo_nhom";
		ComboBox obj24 = cboTheo_nhom;
		size = new Size(87, 21);
		((Control)obj24).Size = size;
		((Control)cboTheo_nhom).TabIndex = 4;
		((Control)cboTheo_nhom).Visible = false;
		txtMa_BPSD.AutoLookup = true;
		txtMa_BPSD.AutoValid = false;
		((TextBoxBase)txtMa_BPSD).BackColor = SystemColors.Info;
		((TextBox)txtMa_BPSD).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_BPSD;
		location = new Point(117, 105);
		((Control)asTextBox2).Location = location;
		txtMa_BPSD.LookupCodeName = "MA_BPSD";
		((TextBoxBase)txtMa_BPSD).MaxLength = 20;
		((Control)txtMa_BPSD).Name = "txtMa_BPSD";
		txtMa_BPSD.NameControl = lblTen_BPSD;
		AsTextBox asTextBox3 = txtMa_BPSD;
		size = new Size(87, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_BPSD).TabIndex = 3;
		txtMa_BPSD.UseAutoCompleteSource = true;
		((Control)lblTen_BPSD).BackColor = Color.Transparent;
		Label obj25 = lblTen_BPSD;
		location = new Point(215, 110);
		((Control)obj25).Location = location;
		((Control)lblTen_BPSD).Name = "lblTen_BPSD";
		Label obj26 = lblTen_BPSD;
		size = new Size(322, 13);
		((Control)obj26).Size = size;
		((Control)lblTen_BPSD).TabIndex = 7;
		lblMa_BPSD.AutoSize = true;
		Label obj27 = lblMa_BPSD;
		location = new Point(24, 109);
		((Control)obj27).Location = location;
		((Control)lblMa_BPSD).Name = "lblMa_BPSD";
		Label obj28 = lblMa_BPSD;
		size = new Size(54, 13);
		((Control)obj28).Size = size;
		((Control)lblMa_BPSD).TabIndex = 1346;
		lblMa_BPSD.Text = "Mã BPSD";
		txtMa_cc.AutoLookup = true;
		txtMa_cc.AutoValid = false;
		((TextBoxBase)txtMa_cc).BackColor = SystemColors.Info;
		((TextBox)txtMa_cc).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_cc;
		location = new Point(117, 131);
		((Control)asTextBox4).Location = location;
		txtMa_cc.LookupCodeName = "MA_CC";
		((TextBoxBase)txtMa_cc).MaxLength = 20;
		((Control)txtMa_cc).Name = "txtMa_cc";
		txtMa_cc.NameControl = Label1;
		AsTextBox asTextBox5 = txtMa_cc;
		size = new Size(87, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_cc).TabIndex = 4;
		txtMa_cc.UseAutoCompleteSource = true;
		((Control)Label1).BackColor = Color.Transparent;
		Label label = Label1;
		location = new Point(215, 136);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(322, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1349;
		lblMa_cc.AutoSize = true;
		Label obj29 = lblMa_cc;
		location = new Point(24, 135);
		((Control)obj29).Location = location;
		((Control)lblMa_cc).Name = "lblMa_cc";
		Label obj30 = lblMa_cc;
		size = new Size(64, 13);
		((Control)obj30).Size = size;
		((Control)lblMa_cc).TabIndex = 1350;
		lblMa_cc.Text = "Mã công cụ";
		txtMa_phi.AutoLookup = true;
		txtMa_phi.AutoValid = false;
		((TextBoxBase)txtMa_phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_phi;
		location = new Point(117, 157);
		((Control)asTextBox6).Location = location;
		txtMa_phi.LookupCodeName = "MA_phi";
		((TextBoxBase)txtMa_phi).MaxLength = 20;
		((Control)txtMa_phi).Name = "txtMa_phi";
		txtMa_phi.NameControl = Label3;
		AsTextBox asTextBox7 = txtMa_phi;
		size = new Size(87, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_phi).TabIndex = 5;
		txtMa_phi.UseAutoCompleteSource = true;
		((Control)Label3).BackColor = Color.Transparent;
		Label label3 = Label3;
		location = new Point(215, 162);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		Label label4 = Label3;
		size = new Size(322, 13);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 1352;
		lblMa_phi.AutoSize = true;
		Label obj31 = lblMa_phi;
		location = new Point(24, 161);
		((Control)obj31).Location = location;
		((Control)lblMa_phi).Name = "lblMa_phi";
		Label obj32 = lblMa_phi;
		size = new Size(41, 13);
		((Control)obj32).Size = size;
		((Control)lblMa_phi).TabIndex = 1353;
		lblMa_phi.Text = "Mã phí";
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_spct;
		location = new Point(117, 183);
		((Control)asTextBox8).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((TextBoxBase)txtMa_spct).MaxLength = 20;
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = Label5;
		AsTextBox asTextBox9 = txtMa_spct;
		size = new Size(87, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_spct).TabIndex = 6;
		txtMa_spct.UseAutoCompleteSource = true;
		((Control)Label5).BackColor = Color.Transparent;
		Label label5 = Label5;
		location = new Point(215, 188);
		((Control)label5).Location = location;
		((Control)Label5).Name = "Label5";
		Label label6 = Label5;
		size = new Size(322, 13);
		((Control)label6).Size = size;
		((Control)Label5).TabIndex = 1355;
		lblMa_SPCT.AutoSize = true;
		Label obj33 = lblMa_SPCT;
		location = new Point(24, 187);
		((Control)obj33).Location = location;
		((Control)lblMa_SPCT).Name = "lblMa_SPCT";
		Label obj34 = lblMa_SPCT;
		size = new Size(53, 13);
		((Control)obj34).Size = size;
		((Control)lblMa_SPCT).TabIndex = 1356;
		lblMa_SPCT.Text = "Mã SPCT";
		txtTK_PB.AutoLookup = true;
		txtTK_PB.AutoValid = false;
		((TextBoxBase)txtTK_PB).BackColor = SystemColors.Info;
		((TextBox)txtTK_PB).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtTK_PB;
		location = new Point(117, 209);
		((Control)asTextBox10).Location = location;
		txtTK_PB.LookupCodeName = "TK";
		((TextBoxBase)txtTK_PB).MaxLength = 8;
		((Control)txtTK_PB).Name = "txtTK_PB";
		txtTK_PB.NameControl = Label7;
		AsTextBox asTextBox11 = txtTK_PB;
		size = new Size(87, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtTK_PB).TabIndex = 7;
		txtTK_PB.UseAutoCompleteSource = true;
		((Control)Label7).BackColor = Color.Transparent;
		Label label7 = Label7;
		location = new Point(215, 214);
		((Control)label7).Location = location;
		((Control)Label7).Name = "Label7";
		Label label8 = Label7;
		size = new Size(322, 13);
		((Control)label8).Size = size;
		((Control)Label7).TabIndex = 1358;
		lblTK_PB.AutoSize = true;
		Label obj35 = lblTK_PB;
		location = new Point(24, 213);
		((Control)obj35).Location = location;
		((Control)lblTK_PB).Name = "lblTK_PB";
		Label obj36 = lblTK_PB;
		size = new Size(66, 13);
		((Control)obj36).Size = size;
		((Control)lblTK_PB).TabIndex = 1359;
		lblTK_PB.Text = "TK phân bổ ";
		txtTK_CP.AutoLookup = true;
		txtTK_CP.AutoValid = false;
		((TextBoxBase)txtTK_CP).BackColor = SystemColors.Info;
		((TextBox)txtTK_CP).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtTK_CP;
		location = new Point(117, 235);
		((Control)asTextBox12).Location = location;
		txtTK_CP.LookupCodeName = "TK";
		((TextBoxBase)txtTK_CP).MaxLength = 8;
		((Control)txtTK_CP).Name = "txtTK_CP";
		txtTK_CP.NameControl = Label9;
		AsTextBox asTextBox13 = txtTK_CP;
		size = new Size(87, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtTK_CP).TabIndex = 8;
		txtTK_CP.UseAutoCompleteSource = true;
		((Control)Label9).BackColor = Color.Transparent;
		Label label9 = Label9;
		location = new Point(215, 240);
		((Control)label9).Location = location;
		((Control)Label9).Name = "Label9";
		Label label10 = Label9;
		size = new Size(322, 13);
		((Control)label10).Size = size;
		((Control)Label9).TabIndex = 1361;
		lblTK_CP.AutoSize = true;
		Label obj37 = lblTK_CP;
		location = new Point(24, 239);
		((Control)obj37).Location = location;
		((Control)lblTK_CP).Name = "lblTK_CP";
		Label obj38 = lblTK_CP;
		size = new Size(57, 13);
		((Control)obj38).Size = size;
		((Control)lblTK_CP).TabIndex = 1362;
		lblTK_CP.Text = "TK chi phí";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(644, 374);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFARptBCPT10";
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
		arrayList.Add(((TextBox)txtMa_BPSD).Text.Trim());
		arrayList.Add(((TextBox)txtMa_cc).Text.Trim());
		arrayList.Add(((TextBox)txtMa_phi).Text.Trim());
		arrayList.Add(((TextBox)txtMa_spct).Text.Trim());
		arrayList.Add(((TextBox)txtTK_PB).Text.Trim());
		arrayList.Add(((TextBox)txtTK_CP).Text.Trim());
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strSubTitle1", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = string.Empty;
		if (Operators.CompareString(((TextBox)txtMa_BPSD).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_BPSD.Text + ": " + ((TextBox)txtMa_BPSD).Text;
		}
		return text;
	}
}
