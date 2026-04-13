using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCoRptCTPBCPTT : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("lblTen_phi")]
	private Label _lblTen_phi;

	[AccessedThroughProperty("lblTen_tkcp")]
	private Label _lblTen_tkcp;

	[AccessedThroughProperty("lblTen_tkpb")]
	private Label _lblTen_tkpb;

	[AccessedThroughProperty("lblTen_cp")]
	private Label _lblTen_cp;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("txtMa_phi")]
	private AsTextBox _txtMa_phi;

	[AccessedThroughProperty("lblMa_phi")]
	private Label _lblMa_phi;

	[AccessedThroughProperty("txtTk_cp")]
	private AsTextBox _txtTk_cp;

	[AccessedThroughProperty("lblTk_cp")]
	private Label _lblTk_cp;

	[AccessedThroughProperty("txtTk_pb")]
	private AsTextBox _txtTk_pb;

	[AccessedThroughProperty("lblTk_pb")]
	private Label _lblTk_pb;

	[AccessedThroughProperty("txtMa_cp")]
	private AsTextBox _txtMa_cp;

	[AccessedThroughProperty("lblMa_cp")]
	private Label _lblMa_cp;

	[AccessedThroughProperty("txtMa_bpsd")]
	private AsTextBox _txtMa_bpsd;

	[AccessedThroughProperty("lblTen_bpsd")]
	private Label _lblTen_bpsd;

	[AccessedThroughProperty("lblMa_bpsd")]
	private Label _lblMa_bpsd;

	private string sTabName;

	private string sMenuID;

	private bool DataLoading;

	internal virtual Label lblTen_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_spct = value;
		}
	}

	internal virtual Label lblTen_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_phi = value;
		}
	}

	internal virtual Label lblTen_tkcp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tkcp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tkcp = value;
		}
	}

	internal virtual Label lblTen_tkpb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tkpb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tkpb = value;
		}
	}

	internal virtual Label lblTen_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_cp = value;
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

	internal virtual Label lblMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_spct = value;
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

	internal virtual AsTextBox txtTk_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_cp = value;
		}
	}

	internal virtual Label lblTk_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_cp = value;
		}
	}

	internal virtual AsTextBox txtTk_pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_pb = value;
		}
	}

	internal virtual Label lblTk_pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_pb = value;
		}
	}

	internal virtual AsTextBox txtMa_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_cp = value;
		}
	}

	internal virtual Label lblMa_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_cp = value;
		}
	}

	internal virtual AsTextBox txtMa_bpsd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_bpsd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_bpsd = value;
		}
	}

	internal virtual Label lblTen_bpsd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_bpsd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_bpsd = value;
		}
	}

	internal virtual Label lblMa_bpsd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_bpsd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_bpsd = value;
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public frmCoRptCTPBCPTT(string MenuID)
		: base(MenuID)
	{
		DataLoading = true;
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		lblTen_spct = new Label();
		lblTen_phi = new Label();
		lblTen_tkcp = new Label();
		lblTen_tkpb = new Label();
		lblTen_cp = new Label();
		txtMa_spct = new AsTextBox();
		lblMa_spct = new Label();
		txtMa_phi = new AsTextBox();
		lblMa_phi = new Label();
		txtTk_cp = new AsTextBox();
		lblTk_cp = new Label();
		txtTk_pb = new AsTextBox();
		lblTk_pb = new Label();
		txtMa_cp = new AsTextBox();
		lblMa_cp = new Label();
		txtMa_bpsd = new AsTextBox();
		lblTen_bpsd = new Label();
		lblMa_bpsd = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tkcp);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_tkpb);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_cp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_phi);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk_cp);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk_cp);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk_pb);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk_pb);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_cp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_cp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_bpsd);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bpsd);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bpsd);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bpsd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bpsd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bpsd, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_cp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_cp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk_pb, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk_pb, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk_cp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk_cp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_cp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tkpb, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_tkcp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		((Control)lbl2).TabIndex = 5;
		((Control)cmdModifyReport).TabIndex = 1;
		((Control)txtNgay1).TabIndex = 4;
		((Control)cboKyBc).TabIndex = 3;
		AsTextBox asTextBox = txtMa_Nt;
		Point location = new Point(146, 397);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).Visible = false;
		Label obj = lblMauBC;
		location = new Point(191, 396);
		((Control)obj).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj2 = optVND;
		location = new Point(278, 395);
		((Control)obj2).Location = location;
		((Control)optVND).Visible = false;
		RadioButton obj3 = optNt;
		location = new Point(332, 396);
		((Control)obj3).Location = location;
		((Control)optNt).Visible = false;
		Label obj4 = lblMa_nt;
		location = new Point(60, 399);
		((Control)obj4).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj5 = cmdOk;
		location = new Point(24, 269);
		((Control)obj5).Location = location;
		((Control)cmdOk).TabIndex = 12;
		((Control)txtTieu_De).TabIndex = 2;
		Label obj6 = lblTen_spct;
		location = new Point(206, 237);
		((Control)obj6).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj7 = lblTen_spct;
		Size size = new Size(324, 17);
		((Control)obj7).Size = size;
		((Control)lblTen_spct).TabIndex = 1051;
		Label obj8 = lblTen_phi;
		location = new Point(206, 211);
		((Control)obj8).Location = location;
		((Control)lblTen_phi).Name = "lblTen_phi";
		Label obj9 = lblTen_phi;
		size = new Size(324, 17);
		((Control)obj9).Size = size;
		((Control)lblTen_phi).TabIndex = 1050;
		Label obj10 = lblTen_tkcp;
		location = new Point(206, 185);
		((Control)obj10).Location = location;
		((Control)lblTen_tkcp).Name = "lblTen_tkcp";
		Label obj11 = lblTen_tkcp;
		size = new Size(324, 17);
		((Control)obj11).Size = size;
		((Control)lblTen_tkcp).TabIndex = 1049;
		Label obj12 = lblTen_tkpb;
		location = new Point(206, 159);
		((Control)obj12).Location = location;
		((Control)lblTen_tkpb).Name = "lblTen_tkpb";
		Label obj13 = lblTen_tkpb;
		size = new Size(324, 17);
		((Control)obj13).Size = size;
		((Control)lblTen_tkpb).TabIndex = 1048;
		Label obj14 = lblTen_cp;
		location = new Point(206, 133);
		((Control)obj14).Location = location;
		((Control)lblTen_cp).Name = "lblTen_cp";
		Label obj15 = lblTen_cp;
		size = new Size(324, 17);
		((Control)obj15).Size = size;
		((Control)lblTen_cp).TabIndex = 1047;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_spct;
		location = new Point(110, 235);
		((Control)asTextBox2).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox3 = txtMa_spct;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_spct).TabIndex = 11;
		txtMa_spct.UseAutoCompleteSource = true;
		lblMa_spct.AutoSize = true;
		Label obj16 = lblMa_spct;
		location = new Point(24, 238);
		((Control)obj16).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj17 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj17).Size = size;
		((Control)lblMa_spct).TabIndex = 1046;
		lblMa_spct.Text = "Mã SPCT";
		txtMa_phi.AutoLookup = true;
		txtMa_phi.AutoValid = false;
		((TextBoxBase)txtMa_phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_phi;
		location = new Point(110, 209);
		((Control)asTextBox4).Location = location;
		txtMa_phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_phi).Name = "txtMa_phi";
		txtMa_phi.NameControl = lblTen_phi;
		AsTextBox asTextBox5 = txtMa_phi;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_phi).TabIndex = 10;
		txtMa_phi.UseAutoCompleteSource = true;
		lblMa_phi.AutoSize = true;
		Label obj18 = lblMa_phi;
		location = new Point(24, 212);
		((Control)obj18).Location = location;
		((Control)lblMa_phi).Name = "lblMa_phi";
		Label obj19 = lblMa_phi;
		size = new Size(41, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_phi).TabIndex = 1045;
		lblMa_phi.Text = "Mã phí";
		txtTk_cp.AutoLookup = true;
		txtTk_cp.AutoValid = false;
		((TextBoxBase)txtTk_cp).BackColor = SystemColors.Info;
		((TextBox)txtTk_cp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtTk_cp;
		location = new Point(110, 183);
		((Control)asTextBox6).Location = location;
		txtTk_cp.LookupCodeName = "TK";
		((Control)txtTk_cp).Name = "txtTk_cp";
		txtTk_cp.NameControl = lblTen_tkcp;
		AsTextBox asTextBox7 = txtTk_cp;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtTk_cp).TabIndex = 9;
		txtTk_cp.UseAutoCompleteSource = true;
		lblTk_cp.AutoSize = true;
		Label obj20 = lblTk_cp;
		location = new Point(24, 186);
		((Control)obj20).Location = location;
		((Control)lblTk_cp).Name = "lblTk_cp";
		Label obj21 = lblTk_cp;
		size = new Size(57, 13);
		((Control)obj21).Size = size;
		((Control)lblTk_cp).TabIndex = 1044;
		lblTk_cp.Text = "TK chi phí";
		txtTk_pb.AutoLookup = true;
		txtTk_pb.AutoValid = false;
		((TextBoxBase)txtTk_pb).BackColor = SystemColors.Info;
		((TextBox)txtTk_pb).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtTk_pb;
		location = new Point(110, 157);
		((Control)asTextBox8).Location = location;
		txtTk_pb.LookupCodeName = "TK";
		((Control)txtTk_pb).Name = "txtTk_pb";
		txtTk_pb.NameControl = lblTen_tkpb;
		AsTextBox asTextBox9 = txtTk_pb;
		size = new Size(90, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtTk_pb).TabIndex = 8;
		txtTk_pb.UseAutoCompleteSource = true;
		lblTk_pb.AutoSize = true;
		Label obj22 = lblTk_pb;
		location = new Point(24, 160);
		((Control)obj22).Location = location;
		((Control)lblTk_pb).Name = "lblTk_pb";
		Label obj23 = lblTk_pb;
		size = new Size(63, 13);
		((Control)obj23).Size = size;
		((Control)lblTk_pb).TabIndex = 1043;
		lblTk_pb.Text = "TK phân bổ";
		txtMa_cp.AutoLookup = true;
		txtMa_cp.AutoValid = false;
		((TextBoxBase)txtMa_cp).BackColor = SystemColors.Info;
		((TextBox)txtMa_cp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox10 = txtMa_cp;
		location = new Point(110, 131);
		((Control)asTextBox10).Location = location;
		txtMa_cp.LookupCodeName = "MA_CPTT";
		txtMa_cp.LookupWhereCondition = "MODULEID = 'CO'";
		((Control)txtMa_cp).Name = "txtMa_cp";
		txtMa_cp.NameControl = lblTen_cp;
		AsTextBox asTextBox11 = txtMa_cp;
		size = new Size(90, 20);
		((Control)asTextBox11).Size = size;
		((Control)txtMa_cp).TabIndex = 7;
		txtMa_cp.UseAutoCompleteSource = true;
		lblMa_cp.AutoSize = true;
		Label obj24 = lblMa_cp;
		location = new Point(24, 134);
		((Control)obj24).Location = location;
		((Control)lblMa_cp).Name = "lblMa_cp";
		Label obj25 = lblMa_cp;
		size = new Size(58, 13);
		((Control)obj25).Size = size;
		((Control)lblMa_cp).TabIndex = 1042;
		lblMa_cp.Text = "Mã chi phí";
		txtMa_bpsd.AutoLookup = true;
		txtMa_bpsd.AutoValid = false;
		((TextBoxBase)txtMa_bpsd).BackColor = SystemColors.Info;
		((TextBox)txtMa_bpsd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox12 = txtMa_bpsd;
		location = new Point(110, 105);
		((Control)asTextBox12).Location = location;
		txtMa_bpsd.LookupCodeName = "MA_BPSD";
		((Control)txtMa_bpsd).Name = "txtMa_bpsd";
		txtMa_bpsd.NameControl = lblTen_bpsd;
		AsTextBox asTextBox13 = txtMa_bpsd;
		size = new Size(90, 20);
		((Control)asTextBox13).Size = size;
		((Control)txtMa_bpsd).TabIndex = 6;
		txtMa_bpsd.UseAutoCompleteSource = true;
		Label obj26 = lblTen_bpsd;
		location = new Point(206, 107);
		((Control)obj26).Location = location;
		((Control)lblTen_bpsd).Name = "lblTen_bpsd";
		Label obj27 = lblTen_bpsd;
		size = new Size(324, 17);
		((Control)obj27).Size = size;
		((Control)lblTen_bpsd).TabIndex = 1040;
		lblMa_bpsd.AutoSize = true;
		Label obj28 = lblMa_bpsd;
		location = new Point(24, 108);
		((Control)obj28).Location = location;
		((Control)lblMa_bpsd).Name = "lblMa_bpsd";
		Label obj29 = lblMa_bpsd;
		size = new Size(54, 13);
		((Control)obj29).Size = size;
		((Control)lblMa_bpsd).TabIndex = 1041;
		lblMa_bpsd.Text = "Mã BPSD";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(790, 510);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCoRptCTPBCPTT";
		((Form)this).Text = "frmCORptCTPBTT1";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay1.Value)));
		arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay2.Value)));
		arrayList.Add(((TextBox)txtMa_bpsd).Text);
		arrayList.Add(((TextBox)txtMa_cp).Text);
		arrayList.Add(((TextBox)txtTk_pb).Text);
		arrayList.Add(((TextBox)txtTk_cp).Text);
		arrayList.Add(((TextBox)txtMa_phi).Text);
		arrayList.Add(((TextBox)txtMa_spct).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (Operators.CompareString(((TextBox)txtMa_bpsd).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_bpsd.Text + ": [" + ((TextBox)txtMa_bpsd).Text + " - " + lblTen_bpsd.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_cp).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_cp.Text + ": [" + ((TextBox)txtMa_cp).Text + " - " + lblTen_cp.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtTk_pb).Text.Trim(), "", false) != 0)
		{
			text = text + lblTk_pb.Text + ": [" + ((TextBox)txtTk_pb).Text + " - " + lblTen_tkpb.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtTk_cp).Text.Trim(), "", false) != 0)
		{
			text = text + lblTk_cp.Text + ": [" + ((TextBox)txtTk_cp).Text + " - " + lblTen_tkcp.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_phi).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_phi.Text + ": [" + ((TextBox)txtMa_phi).Text + " - " + lblTen_phi.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_spct).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_spct.Text + ": [" + ((TextBox)txtMa_spct).Text + " - " + lblTen_spct.Text + "]; ";
		}
		return text;
	}
}
