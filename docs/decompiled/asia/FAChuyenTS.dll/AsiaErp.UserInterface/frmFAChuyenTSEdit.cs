using System;
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
public class frmFAChuyenTSEdit : frmDMComplexEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblMA_PHI")]
	private Label _lblMA_PHI;

	[AccessedThroughProperty("lblMA_SPCT")]
	private Label _lblMA_SPCT;

	[AccessedThroughProperty("lblMa_bpsd")]
	private Label _lblMa_bpsd;

	[AccessedThroughProperty("lblNgay_chuyen")]
	private Label _lblNgay_chuyen;

	[AccessedThroughProperty("lblCP")]
	private Label _lblCP;

	[AccessedThroughProperty("lblTK_CP")]
	private Label _lblTK_CP;

	[AccessedThroughProperty("txtTk_cp")]
	private AsTextBox _txtTk_cp;

	[AccessedThroughProperty("lblKH")]
	private Label _lblKH;

	[AccessedThroughProperty("lblTK_KH")]
	private Label _lblTK_KH;

	[AccessedThroughProperty("txtTk_kh")]
	private AsTextBox _txtTk_kh;

	[AccessedThroughProperty("lblTS")]
	private Label _lblTS;

	[AccessedThroughProperty("lblTK_TS")]
	private Label _lblTK_TS;

	[AccessedThroughProperty("txtTk_ts")]
	private AsTextBox _txtTk_ts;

	[AccessedThroughProperty("txtMa_ts")]
	private AsTextBox _txtMa_ts;

	[AccessedThroughProperty("lblMa_ts")]
	private Label _lblMa_ts;

	[AccessedThroughProperty("txtNgay")]
	private AsMaskedTextBox _txtNgay;

	[AccessedThroughProperty("txtMa_phi")]
	private AsTextBox _txtMa_phi;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("txtMa_bpsd")]
	private AsTextBox _txtMa_bpsd;

	[AccessedThroughProperty("lblPhi")]
	private Label _lblPhi;

	[AccessedThroughProperty("lblSPCT")]
	private Label _lblSPCT;

	[AccessedThroughProperty("lblBPSD")]
	private Label _lblBPSD;

	[AccessedThroughProperty("lblMaTS")]
	private Label _lblMaTS;

	[AccessedThroughProperty("lblLoai_chuyen")]
	private Label _lblLoai_chuyen;

	[AccessedThroughProperty("cboLoai_dt")]
	private AsComboBoxTT _cboLoai_dt;

	internal virtual Label lblMA_PHI
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMA_PHI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMA_PHI = value;
		}
	}

	internal virtual Label lblMA_SPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMA_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMA_SPCT = value;
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

	internal virtual Label lblNgay_chuyen
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_chuyen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_chuyen = value;
		}
	}

	internal virtual Label lblCP
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCP = value;
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

	internal virtual Label lblKH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblKH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblKH = value;
		}
	}

	internal virtual Label lblTK_KH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_KH = value;
		}
	}

	internal virtual AsTextBox txtTk_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_kh = value;
		}
	}

	internal virtual Label lblTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTS = value;
		}
	}

	internal virtual Label lblTK_TS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_TS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_TS = value;
		}
	}

	internal virtual AsTextBox txtTk_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_ts = value;
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

	internal virtual AsMaskedTextBox txtNgay
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay = value;
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

	internal virtual Label lblPhi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPhi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPhi = value;
		}
	}

	internal virtual Label lblSPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSPCT = value;
		}
	}

	internal virtual Label lblBPSD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblBPSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblBPSD = value;
		}
	}

	internal virtual Label lblMaTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMaTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMaTS = value;
		}
	}

	internal virtual Label lblLoai_chuyen
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLoai_chuyen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLoai_chuyen = value;
		}
	}

	internal virtual AsComboBoxTT cboLoai_dt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_dt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cbCode_name_SelectedValueChanged;
			if (_cboLoai_dt != null)
			{
				((ListControl)_cboLoai_dt).SelectedValueChanged -= eventHandler;
			}
			_cboLoai_dt = value;
			if (_cboLoai_dt != null)
			{
				((ListControl)_cboLoai_dt).SelectedValueChanged += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public frmFAChuyenTSEdit()
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
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
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
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		lblMA_PHI = new Label();
		lblMA_SPCT = new Label();
		lblMa_bpsd = new Label();
		lblNgay_chuyen = new Label();
		lblCP = new Label();
		lblTK_CP = new Label();
		txtTk_cp = new AsTextBox();
		lblKH = new Label();
		lblTK_KH = new Label();
		txtTk_kh = new AsTextBox();
		lblTS = new Label();
		lblTK_TS = new Label();
		txtTk_ts = new AsTextBox();
		txtMa_ts = new AsTextBox();
		lblMaTS = new Label();
		lblMa_ts = new Label();
		txtMa_bpsd = new AsTextBox();
		lblBPSD = new Label();
		txtMa_spct = new AsTextBox();
		lblSPCT = new Label();
		txtMa_phi = new AsTextBox();
		lblPhi = new Label();
		txtNgay = new AsMaskedTextBox();
		lblLoai_chuyen = new Label();
		cboLoai_dt = new AsComboBoxTT();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(285, 45);
		((Control)asCheckBox).Location = location;
		AsCheckBox asCheckBox2 = chkKsd;
		Size size = new Size(73, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkKsd).TabStop = true;
		((ButtonBase)chkKsd).Text = "IS_DMTS";
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 272);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 216;
		Button obj2 = cmdSave;
		location = new Point(12, 272);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 215;
		((Control)gbLine).Controls.Add((Control)(object)cboLoai_dt);
		((Control)gbLine).Controls.Add((Control)(object)lblLoai_chuyen);
		((Control)gbLine).Controls.Add((Control)(object)lblMaTS);
		((Control)gbLine).Controls.Add((Control)(object)lblPhi);
		((Control)gbLine).Controls.Add((Control)(object)lblSPCT);
		((Control)gbLine).Controls.Add((Control)(object)lblBPSD);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_phi);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_spct);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_bpsd);
		((Control)gbLine).Controls.Add((Control)(object)lblMA_PHI);
		((Control)gbLine).Controls.Add((Control)(object)lblMA_SPCT);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_bpsd);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_chuyen);
		((Control)gbLine).Controls.Add((Control)(object)lblCP);
		((Control)gbLine).Controls.Add((Control)(object)lblTK_CP);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_cp);
		((Control)gbLine).Controls.Add((Control)(object)lblKH);
		((Control)gbLine).Controls.Add((Control)(object)lblTK_KH);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_kh);
		((Control)gbLine).Controls.Add((Control)(object)lblTS);
		((Control)gbLine).Controls.Add((Control)(object)lblTK_TS);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_ts);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_ts);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_ts);
		GroupBox obj3 = gbLine;
		size = new Size(508, 260);
		((Control)obj3).Size = size;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK_TS, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTS, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK_KH, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblKH, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_cp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK_CP, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblCP, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_chuyen, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_bpsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMA_SPCT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMA_PHI, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_bpsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_phi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblBPSD, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSPCT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblPhi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMaTS, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblLoai_chuyen, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai_dt, 0);
		lblMA_PHI.AutoSize = true;
		Label obj4 = lblMA_PHI;
		location = new Point(10, 153);
		((Control)obj4).Location = location;
		((Control)lblMA_PHI).Name = "lblMA_PHI";
		Label obj5 = lblMA_PHI;
		size = new Size(41, 13);
		((Control)obj5).Size = size;
		((Control)lblMA_PHI).TabIndex = 227;
		lblMA_PHI.Text = "Mã phí";
		lblMA_SPCT.AutoSize = true;
		Label obj6 = lblMA_SPCT;
		location = new Point(10, 126);
		((Control)obj6).Location = location;
		((Control)lblMA_SPCT).Name = "lblMA_SPCT";
		Label obj7 = lblMA_SPCT;
		size = new Size(53, 13);
		((Control)obj7).Size = size;
		((Control)lblMA_SPCT).TabIndex = 226;
		lblMA_SPCT.Text = "Mã SPCT";
		lblMa_bpsd.AutoSize = true;
		Label obj8 = lblMa_bpsd;
		location = new Point(10, 100);
		((Control)obj8).Location = location;
		((Control)lblMa_bpsd).Name = "lblMa_bpsd";
		Label obj9 = lblMa_bpsd;
		size = new Size(54, 13);
		((Control)obj9).Size = size;
		((Control)lblMa_bpsd).TabIndex = 224;
		lblMa_bpsd.Text = "Mã BPSD";
		lblNgay_chuyen.AutoSize = true;
		Label obj10 = lblNgay_chuyen;
		location = new Point(10, 47);
		((Control)obj10).Location = location;
		((Control)lblNgay_chuyen).Name = "lblNgay_chuyen";
		Label obj11 = lblNgay_chuyen;
		size = new Size(70, 13);
		((Control)obj11).Size = size;
		((Control)lblNgay_chuyen).TabIndex = 223;
		lblNgay_chuyen.Text = "Ngày chuyển";
		Label obj12 = lblCP;
		location = new Point(220, 228);
		((Control)obj12).Location = location;
		((Control)lblCP).Name = "lblCP";
		Label obj13 = lblCP;
		size = new Size(214, 20);
		((Control)obj13).Size = size;
		((Control)lblCP).TabIndex = 216;
		lblCP.TextAlign = (ContentAlignment)16;
		lblTK_CP.AutoSize = true;
		Label obj14 = lblTK_CP;
		location = new Point(10, 231);
		((Control)obj14).Location = location;
		((Control)lblTK_CP).Name = "lblTK_CP";
		Label obj15 = lblTK_CP;
		size = new Size(91, 13);
		((Control)obj15).Size = size;
		((Control)lblTK_CP).TabIndex = 215;
		lblTK_CP.Text = "Tài khoản chi phí";
		txtTk_cp.AutoLookup = true;
		txtTk_cp.AutoValid = true;
		((TextBoxBase)txtTk_cp).BackColor = SystemColors.Info;
		((TextBox)txtTk_cp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTk_cp;
		location = new Point(119, 227);
		((Control)asTextBox).Location = location;
		txtTk_cp.LookupCodeName = "TK";
		txtTk_cp.LookupWhereCondition = "CHI_TIET = 1";
		((Control)txtTk_cp).Name = "txtTk_cp";
		txtTk_cp.NameControl = lblCP;
		AsTextBox asTextBox2 = txtTk_cp;
		size = new Size(95, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTk_cp).TabIndex = 214;
		txtTk_cp.UseAutoCompleteSource = true;
		Label obj16 = lblKH;
		location = new Point(220, 202);
		((Control)obj16).Location = location;
		((Control)lblKH).Name = "lblKH";
		Label obj17 = lblKH;
		size = new Size(214, 20);
		((Control)obj17).Size = size;
		((Control)lblKH).TabIndex = 213;
		lblKH.TextAlign = (ContentAlignment)16;
		lblTK_KH.AutoSize = true;
		Label obj18 = lblTK_KH;
		location = new Point(10, 205);
		((Control)obj18).Location = location;
		((Control)lblTK_KH).Name = "lblTK_KH";
		Label obj19 = lblTK_KH;
		size = new Size(103, 13);
		((Control)obj19).Size = size;
		((Control)lblTK_KH).TabIndex = 212;
		lblTK_KH.Text = "Tài khoản khấu hao";
		txtTk_kh.AutoLookup = true;
		txtTk_kh.AutoValid = true;
		((TextBoxBase)txtTk_kh).BackColor = SystemColors.Info;
		((TextBox)txtTk_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk_kh;
		location = new Point(119, 201);
		((Control)asTextBox3).Location = location;
		txtTk_kh.LookupCodeName = "TK";
		txtTk_kh.LookupWhereCondition = "CHI_TIET = 1";
		((Control)txtTk_kh).Name = "txtTk_kh";
		txtTk_kh.NameControl = lblKH;
		AsTextBox asTextBox4 = txtTk_kh;
		size = new Size(95, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk_kh).TabIndex = 211;
		txtTk_kh.UseAutoCompleteSource = true;
		Label obj20 = lblTS;
		location = new Point(220, 176);
		((Control)obj20).Location = location;
		((Control)lblTS).Name = "lblTS";
		Label obj21 = lblTS;
		size = new Size(214, 20);
		((Control)obj21).Size = size;
		((Control)lblTS).TabIndex = 209;
		lblTS.TextAlign = (ContentAlignment)16;
		lblTK_TS.AutoSize = true;
		Label obj22 = lblTK_TS;
		location = new Point(10, 179);
		((Control)obj22).Location = location;
		((Control)lblTK_TS).Name = "lblTK_TS";
		Label obj23 = lblTK_TS;
		size = new Size(89, 13);
		((Control)obj23).Size = size;
		((Control)lblTK_TS).TabIndex = 208;
		lblTK_TS.Text = "Tài khoản tài sản";
		txtTk_ts.AutoLookup = true;
		txtTk_ts.AutoValid = true;
		((TextBoxBase)txtTk_ts).BackColor = SystemColors.Info;
		((TextBox)txtTk_ts).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTk_ts;
		location = new Point(119, 175);
		((Control)asTextBox5).Location = location;
		txtTk_ts.LookupCodeName = "TK";
		txtTk_ts.LookupWhereCondition = "CHI_TIET = 1";
		((Control)txtTk_ts).Name = "txtTk_ts";
		txtTk_ts.NameControl = lblTS;
		AsTextBox asTextBox6 = txtTk_ts;
		size = new Size(95, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTk_ts).TabIndex = 210;
		txtTk_ts.UseAutoCompleteSource = true;
		txtMa_ts.AutoLookup = true;
		txtMa_ts.AutoValid = true;
		((TextBoxBase)txtMa_ts).BackColor = SystemColors.Info;
		((TextBox)txtMa_ts).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_ts;
		location = new Point(119, 17);
		((Control)asTextBox7).Location = location;
		txtMa_ts.LookupCodeName = "MA_TS";
		((Control)txtMa_ts).Name = "txtMa_ts";
		txtMa_ts.NameControl = lblMaTS;
		AsTextBox asTextBox8 = txtMa_ts;
		size = new Size(95, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_ts).TabIndex = 201;
		txtMa_ts.UseAutoCompleteSource = true;
		Label obj24 = lblMaTS;
		location = new Point(282, 17);
		((Control)obj24).Location = location;
		((Control)lblMaTS).Name = "lblMaTS";
		Label obj25 = lblMaTS;
		size = new Size(214, 20);
		((Control)obj25).Size = size;
		((Control)lblMaTS).TabIndex = 236;
		lblMaTS.TextAlign = (ContentAlignment)16;
		lblMa_ts.AutoSize = true;
		Label obj26 = lblMa_ts;
		location = new Point(10, 21);
		((Control)obj26).Location = location;
		((Control)lblMa_ts).Name = "lblMa_ts";
		Label obj27 = lblMa_ts;
		size = new Size(56, 13);
		((Control)obj27).Size = size;
		((Control)lblMa_ts).TabIndex = 200;
		lblMa_ts.Text = "Mã tài sản";
		txtMa_bpsd.AutoLookup = true;
		txtMa_bpsd.AutoValid = true;
		((TextBoxBase)txtMa_bpsd).BackColor = SystemColors.Info;
		((TextBox)txtMa_bpsd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_bpsd;
		location = new Point(119, 96);
		((Control)asTextBox9).Location = location;
		txtMa_bpsd.LookupCodeName = "MA_BPSD";
		((Control)txtMa_bpsd).Name = "txtMa_bpsd";
		txtMa_bpsd.NameControl = lblBPSD;
		AsTextBox asTextBox10 = txtMa_bpsd;
		size = new Size(95, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_bpsd).TabIndex = 204;
		txtMa_bpsd.UseAutoCompleteSource = true;
		Label obj28 = lblBPSD;
		location = new Point(220, 96);
		((Control)obj28).Location = location;
		((Control)lblBPSD).Name = "lblBPSD";
		Label obj29 = lblBPSD;
		size = new Size(214, 20);
		((Control)obj29).Size = size;
		((Control)lblBPSD).TabIndex = 233;
		lblBPSD.TextAlign = (ContentAlignment)16;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = true;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtMa_spct;
		location = new Point(119, 122);
		((Control)asTextBox11).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblSPCT;
		AsTextBox asTextBox12 = txtMa_spct;
		size = new Size(95, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtMa_spct).TabIndex = 205;
		txtMa_spct.UseAutoCompleteSource = true;
		Label obj30 = lblSPCT;
		location = new Point(220, 122);
		((Control)obj30).Location = location;
		((Control)lblSPCT).Name = "lblSPCT";
		Label obj31 = lblSPCT;
		size = new Size(214, 20);
		((Control)obj31).Size = size;
		((Control)lblSPCT).TabIndex = 234;
		lblSPCT.TextAlign = (ContentAlignment)16;
		txtMa_phi.AutoLookup = true;
		txtMa_phi.AutoValid = true;
		((TextBoxBase)txtMa_phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox13 = txtMa_phi;
		location = new Point(119, 149);
		((Control)asTextBox13).Location = location;
		txtMa_phi.LookupCodeName = "MA_PHI";
		((Control)txtMa_phi).Name = "txtMa_phi";
		txtMa_phi.NameControl = lblPhi;
		AsTextBox asTextBox14 = txtMa_phi;
		size = new Size(95, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtMa_phi).TabIndex = 206;
		txtMa_phi.UseAutoCompleteSource = true;
		Label obj32 = lblPhi;
		location = new Point(220, 149);
		((Control)obj32).Location = location;
		((Control)lblPhi).Name = "lblPhi";
		Label obj33 = lblPhi;
		size = new Size(214, 20);
		((Control)obj33).Size = size;
		((Control)lblPhi).TabIndex = 235;
		lblPhi.TextAlign = (ContentAlignment)16;
		txtNgay.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay;
		location = new Point(119, 43);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay).Mask = "##/##/####";
		((Control)txtNgay).Name = "txtNgay";
		((MaskedTextBox)txtNgay).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay;
		size = new Size(76, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay).TabIndex = 202;
		((MaskedTextBox)txtNgay).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		lblLoai_chuyen.AutoSize = true;
		Label obj34 = lblLoai_chuyen;
		location = new Point(10, 73);
		((Control)obj34).Location = location;
		((Control)lblLoai_chuyen).Name = "lblLoai_chuyen";
		Label obj35 = lblLoai_chuyen;
		size = new Size(65, 13);
		((Control)obj35).Size = size;
		((Control)lblLoai_chuyen).TabIndex = 237;
		lblLoai_chuyen.Text = "Loại chuyển";
		((ComboBox)cboLoai_dt).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_dt).FormattingEnabled = true;
		AsComboBoxTT asComboBoxTT = cboLoai_dt;
		location = new Point(119, 69);
		((Control)asComboBoxTT).Location = location;
		cboLoai_dt.Ma_Ct = null;
		((Control)cboLoai_dt).Name = "cboLoai_dt";
		AsComboBoxTT asComboBoxTT2 = cboLoai_dt;
		size = new Size(153, 21);
		((Control)asComboBoxTT2).Size = size;
		((Control)cboLoai_dt).TabIndex = 203;
		cboLoai_dt.Trang_Thai = "";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(532, 307);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFAChuyenTSEdit";
		((Form)this).Text = "frmFADMTSCDEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_ts).MaxLength = base.MyDictComplexInfo.code_length;
		((Control)txtMa_ts).Select();
		NapCombo();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			txtNgay.Value = DateTime.Now;
		}
		Disable();
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_ts))
		{
			epNotice.SetError((Control)(object)txtMa_ts, Helper.GetMess(50002).Description);
			return false;
		}
		if (Operators.CompareString(((MaskedTextBox)txtNgay).Text.ToString().Replace("/", "").Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtNgay, Helper.GetMess(50002).Description);
			((Control)txtNgay).Select();
			return false;
		}
		object selectedValue = ((ListControl)cboLoai_dt).SelectedValue;
		if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"MA_BPSD", false))
		{
			if (!ChkEmtyTextBox((TextBox)(object)txtMa_bpsd))
			{
				epNotice.SetError((Control)(object)txtMa_bpsd, Helper.GetMess(50002).Description);
				return false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"MA_SPCT", false))
		{
			if (!ChkEmtyTextBox((TextBox)(object)txtMa_spct))
			{
				epNotice.SetError((Control)(object)txtMa_spct, Helper.GetMess(50002).Description);
				return false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"MA_PHI", false))
		{
			if (!ChkEmtyTextBox((TextBox)(object)txtMa_phi))
			{
				epNotice.SetError((Control)(object)txtMa_phi, Helper.GetMess(50002).Description);
				return false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"TK_TS", false))
		{
			if (!ChkEmtyTextBox((TextBox)(object)txtTk_ts))
			{
				epNotice.SetError((Control)(object)txtTk_ts, Helper.GetMess(50002).Description);
				return false;
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"TK_KH", false))
		{
			if (!ChkEmtyTextBox((TextBox)(object)txtTk_kh))
			{
				epNotice.SetError((Control)(object)txtTk_kh, Helper.GetMess(50002).Description);
				return false;
			}
		}
		else
		{
			if (!Operators.ConditionalCompareObjectEqual(selectedValue, (object)"TK_CP", false))
			{
				epNotice.SetError((Control)(object)cboLoai_dt, Helper.GetMess(50002).Description);
				((Control)cboLoai_dt).Select();
				return false;
			}
			if (!ChkEmtyTextBox((TextBox)(object)txtTk_cp))
			{
				epNotice.SetError((Control)(object)txtTk_cp, Helper.GetMess(50002).Description);
				return false;
			}
		}
		return base.ValidData();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_ts).Enabled = false;
		((Control)txtNgay).Enabled = false;
		((Control)cboLoai_dt).Enabled = false;
	}

	protected override void DataBinding()
	{
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_ts;
		CreateDataBinding(ref ojb, "ma_ts");
		txtMa_ts = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay;
		CreateDataBinding(ref ojb, "ngay", "Value");
		txtNgay = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)cboLoai_dt;
		CreateDataBinding(ref ojb, "loai_dt", "SelectedValue");
		cboLoai_dt = (AsComboBoxTT)(object)ojb;
		ojb = (Control)(object)txtMa_bpsd;
		CreateDataBinding(ref ojb, "ma_bpsd");
		txtMa_bpsd = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_spct;
		CreateDataBinding(ref ojb, "ma_spct");
		txtMa_spct = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_phi;
		CreateDataBinding(ref ojb, "ma_phi");
		txtMa_phi = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk_ts;
		CreateDataBinding(ref ojb, "tk_ts");
		txtTk_ts = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk_kh;
		CreateDataBinding(ref ojb, "tk_kh");
		txtTk_kh = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk_cp;
		CreateDataBinding(ref ojb, "tk_cp");
		txtTk_cp = (AsTextBox)(object)ojb;
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_ts).Select();
		}
		return flag;
	}

	protected void NapCombo()
	{
		DataTable dataTable = new DataTable();
		DataColumn column = new DataColumn("Dis");
		DataColumn column2 = new DataColumn("Val");
		dataTable.Columns.Add(column);
		dataTable.Columns.Add(column2);
		DataRow dataRow = dataTable.NewRow();
		dataRow["Dis"] = "Mã bộ phận sử dụng";
		dataRow["Val"] = "MA_BPSD";
		dataTable.Rows.Add(dataRow);
		dataRow = dataTable.NewRow();
		dataRow["Dis"] = "Mã sản phẩm công trình";
		dataRow["Val"] = "MA_SPCT";
		dataTable.Rows.Add(dataRow);
		dataRow = dataTable.NewRow();
		dataRow["Dis"] = "Mã phí";
		dataRow["Val"] = "MA_PHI";
		dataTable.Rows.Add(dataRow);
		dataRow = dataTable.NewRow();
		dataRow["Dis"] = "Tài khoản tài sản";
		dataRow["Val"] = "TK_TS";
		dataTable.Rows.Add(dataRow);
		dataRow = dataTable.NewRow();
		dataRow["Dis"] = "Tài khoản khấu hao";
		dataRow["Val"] = "TK_KH";
		dataTable.Rows.Add(dataRow);
		dataRow = dataTable.NewRow();
		dataRow["Dis"] = "Tài khoản chi phí";
		dataRow["Val"] = "TK_CP";
		dataTable.Rows.Add(dataRow);
		((ListControl)cboLoai_dt).DisplayMember = "Dis";
		((ListControl)cboLoai_dt).ValueMember = "Val";
		((ComboBox)cboLoai_dt).DataSource = dataTable;
	}

	protected void Disable()
	{
		if (!EditMode)
		{
			((TextBox)txtMa_bpsd).Text = "";
			((TextBox)txtMa_spct).Text = "";
			((TextBox)txtMa_phi).Text = "";
			((TextBox)txtTk_ts).Text = "";
			((TextBox)txtTk_kh).Text = "";
			((TextBox)txtTk_cp).Text = "";
			lblBPSD.Text = "";
			lblSPCT.Text = "";
			lblPhi.Text = "";
			lblTS.Text = "";
			lblKH.Text = "";
			lblCP.Text = "";
		}
		((Control)txtMa_bpsd).Enabled = false;
		((Control)txtMa_spct).Enabled = false;
		((Control)txtMa_phi).Enabled = false;
		((Control)txtTk_ts).Enabled = false;
		((Control)txtTk_kh).Enabled = false;
		((Control)txtTk_cp).Enabled = false;
		object selectedValue = ((ListControl)cboLoai_dt).SelectedValue;
		if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"MA_BPSD", false))
		{
			((Control)txtMa_bpsd).Enabled = true;
			if (EditMode)
			{
				((Control)txtMa_bpsd).Select();
				((Control)cmdSave).Select();
				((Control)txtMa_bpsd).Select();
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"MA_SPCT", false))
		{
			((Control)txtMa_spct).Enabled = true;
			if (EditMode)
			{
				((Control)txtMa_spct).Select();
				((Control)cmdSave).Select();
				((Control)txtMa_spct).Select();
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"MA_PHI", false))
		{
			((Control)txtMa_phi).Enabled = true;
			if (EditMode)
			{
				((Control)txtMa_phi).Select();
				((Control)cmdSave).Select();
				((Control)txtMa_phi).Select();
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"TK_TS", false))
		{
			((Control)txtTk_ts).Enabled = true;
			if (EditMode)
			{
				((Control)txtTk_ts).Select();
				((Control)cmdSave).Select();
				((Control)txtTk_ts).Select();
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"TK_KH", false))
		{
			((Control)txtTk_kh).Enabled = true;
			if (EditMode)
			{
				((Control)txtTk_kh).Select();
				((Control)cmdSave).Select();
				((Control)txtTk_kh).Select();
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"TK_CP", false))
		{
			((Control)txtTk_cp).Enabled = true;
			if (EditMode)
			{
				((Control)txtTk_cp).Select();
				((Control)cmdSave).Select();
				((Control)txtTk_cp).Select();
			}
		}
	}

	private void cbCode_name_SelectedValueChanged(object sender, EventArgs e)
	{
		Disable();
	}
}
