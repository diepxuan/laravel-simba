using System;
using System.Collections;
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
public class frmGLDMKCEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	[AccessedThroughProperty("txtTen_bt")]
	private TextBox _txtTen_bt;

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtTK_du")]
	private AsTextBox _txtTK_du;

	[AccessedThroughProperty("txtTK")]
	private AsTextBox _txtTK;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("lblTk_du")]
	private Label _lblTk_du;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("chkKC_phi")]
	private AsCheckBox _chkKC_phi;

	[AccessedThroughProperty("chkKC_spct")]
	private AsCheckBox _chkKC_spct;

	[AccessedThroughProperty("chkKC_bp")]
	private AsCheckBox _chkKC_bp;

	[AccessedThroughProperty("chkKC_hd")]
	private AsCheckBox _chkKC_hd;

	[AccessedThroughProperty("lblTen_TK")]
	private Label _lblTen_TK;

	[AccessedThroughProperty("lblTen_TKdu")]
	private Label _lblTen_TKdu;

	[AccessedThroughProperty("txtStt")]
	private AsTextNumeric _txtStt;

	[AccessedThroughProperty("cboLoai_kc")]
	private AsComboBox _cboLoai_kc;

	[AccessedThroughProperty("chkKcDtPs")]
	private CheckBox _chkKcDtPs;

	internal virtual Label lblMa_Bp
	{
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_Bp = value;
		}
	}

	internal virtual TextBox txtTen_bt
	{
		get
		{
			return _txtTen_bt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTen_bt = value;
		}
	}

	internal virtual Label lblTen_Bp
	{
		get
		{
			return _lblTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Bp = value;
		}
	}

	internal virtual TextBox txtSo_ct
	{
		get
		{
			return _txtSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_ct = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual AsTextBox txtTK_du
	{
		get
		{
			return _txtTK_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTK_du = value;
		}
	}

	internal virtual AsTextBox txtTK
	{
		get
		{
			return _txtTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTK = value;
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label lblTk_du
	{
		get
		{
			return _lblTk_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTk_du = value;
		}
	}

	internal virtual Label lblTk
	{
		get
		{
			return _lblTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTk = value;
		}
	}

	internal virtual AsCheckBox chkKC_phi
	{
		get
		{
			return _chkKC_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = chkKC_phi_CheckedChanged;
			if (_chkKC_phi != null)
			{
				((CheckBox)_chkKC_phi).CheckedChanged -= eventHandler;
			}
			_chkKC_phi = value;
			if (_chkKC_phi != null)
			{
				((CheckBox)_chkKC_phi).CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual AsCheckBox chkKC_spct
	{
		get
		{
			return _chkKC_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = chkKC_phi_CheckedChanged;
			if (_chkKC_spct != null)
			{
				((CheckBox)_chkKC_spct).CheckedChanged -= eventHandler;
			}
			_chkKC_spct = value;
			if (_chkKC_spct != null)
			{
				((CheckBox)_chkKC_spct).CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual AsCheckBox chkKC_bp
	{
		get
		{
			return _chkKC_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = chkKC_phi_CheckedChanged;
			if (_chkKC_bp != null)
			{
				((CheckBox)_chkKC_bp).CheckedChanged -= eventHandler;
			}
			_chkKC_bp = value;
			if (_chkKC_bp != null)
			{
				((CheckBox)_chkKC_bp).CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual AsCheckBox chkKC_hd
	{
		get
		{
			return _chkKC_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = chkKC_phi_CheckedChanged;
			if (_chkKC_hd != null)
			{
				((CheckBox)_chkKC_hd).CheckedChanged -= eventHandler;
			}
			_chkKC_hd = value;
			if (_chkKC_hd != null)
			{
				((CheckBox)_chkKC_hd).CheckedChanged += eventHandler;
			}
		}
	}

	private virtual Label lblTen_TK
	{
		get
		{
			return _lblTen_TK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_TK = value;
		}
	}

	private virtual Label lblTen_TKdu
	{
		get
		{
			return _lblTen_TKdu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_TKdu = value;
		}
	}

	internal virtual AsTextNumeric txtStt
	{
		get
		{
			return _txtStt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtStt = value;
		}
	}

	internal virtual AsComboBox cboLoai_kc
	{
		get
		{
			return _cboLoai_kc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboLoai_kc = value;
		}
	}

	internal virtual CheckBox chkKcDtPs
	{
		get
		{
			return _chkKcDtPs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkKcDtPs = value;
		}
	}

	public frmGLDMKCEdit()
	{
		((Form)this).Load += frmGLDMKCEdit_Load;
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		lblMa_Bp = new Label();
		txtTen_bt = new TextBox();
		lblTen_Bp = new Label();
		txtSo_ct = new TextBox();
		Label1 = new Label();
		txtTK = new AsTextBox();
		lblTen_TK = new Label();
		txtTK_du = new AsTextBox();
		lblTen_TKdu = new Label();
		lblTk = new Label();
		lblTk_du = new Label();
		Label4 = new Label();
		chkKC_hd = new AsCheckBox();
		chkKC_bp = new AsCheckBox();
		chkKC_spct = new AsCheckBox();
		chkKC_phi = new AsCheckBox();
		txtStt = new AsTextNumeric();
		cboLoai_kc = new AsComboBox();
		chkKcDtPs = new CheckBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(112, 331);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 11;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 377);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 377);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)chkKcDtPs);
		((Control)gbLine).Controls.Add((Control)(object)cboLoai_kc);
		((Control)gbLine).Controls.Add((Control)(object)txtStt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_TK);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_TKdu);
		((Control)gbLine).Controls.Add((Control)(object)chkKC_phi);
		((Control)gbLine).Controls.Add((Control)(object)chkKC_spct);
		((Control)gbLine).Controls.Add((Control)(object)chkKC_bp);
		((Control)gbLine).Controls.Add((Control)(object)chkKC_hd);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_du);
		((Control)gbLine).Controls.Add((Control)(object)lblTk);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_du);
		((Control)gbLine).Controls.Add((Control)(object)txtTK);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_bt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Bp);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Bp);
		GroupBox obj3 = gbLine;
		Size size = new Size(640, 354);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_bt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_du, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_du, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKC_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKC_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKC_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKC_phi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_TKdu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_TK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtStt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai_kc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKcDtPs, 0);
		lblMa_Bp.AutoSize = true;
		Label obj4 = lblMa_Bp;
		location = new Point(15, 22);
		((Control)obj4).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj5 = lblMa_Bp;
		size = new Size(50, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_Bp).TabIndex = 16;
		lblMa_Bp.Text = "Số thứ tự";
		TextBox obj6 = txtTen_bt;
		location = new Point(112, 70);
		((Control)obj6).Location = location;
		((TextBoxBase)txtTen_bt).MaxLength = 150;
		((Control)txtTen_bt).Name = "txtTen_bt";
		TextBox obj7 = txtTen_bt;
		size = new Size(283, 20);
		((Control)obj7).Size = size;
		((Control)txtTen_bt).TabIndex = 2;
		lblTen_Bp.AutoSize = true;
		Label obj8 = lblTen_Bp;
		location = new Point(15, 73);
		((Control)obj8).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj9 = lblTen_Bp;
		size = new Size(68, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_Bp).TabIndex = 15;
		lblTen_Bp.Text = "Tên bút toán";
		TextBox obj10 = txtSo_ct;
		location = new Point(112, 45);
		((Control)obj10).Location = location;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj11 = txtSo_ct;
		size = new Size(119, 20);
		((Control)obj11).Size = size;
		((Control)txtSo_ct).TabIndex = 1;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(15, 48);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(65, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 11;
		Label1.Text = "Số chứng từ";
		txtTK.AutoLookup = true;
		txtTK.AutoValid = true;
		((TextBoxBase)txtTK).BackColor = SystemColors.Info;
		((TextBox)txtTK).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTK;
		location = new Point(112, 126);
		((Control)asTextBox).Location = location;
		txtTK.LookupCodeName = "TK";
		((Control)txtTK).Name = "txtTK";
		txtTK.NameControl = lblTen_TK;
		AsTextBox asTextBox2 = txtTK;
		size = new Size(119, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTK).TabIndex = 4;
		txtTK.UseAutoCompleteSource = true;
		lblTen_TK.ImeMode = (ImeMode)0;
		Label obj12 = lblTen_TK;
		location = new Point(237, 130);
		((Control)obj12).Location = location;
		((Control)lblTen_TK).Name = "lblTen_TK";
		Label obj13 = lblTen_TK;
		size = new Size(321, 13);
		((Control)obj13).Size = size;
		((Control)lblTen_TK).TabIndex = 1211;
		lblTen_TK.TextAlign = (ContentAlignment)16;
		txtTK_du.AutoLookup = true;
		txtTK_du.AutoValid = true;
		((TextBoxBase)txtTK_du).BackColor = SystemColors.Info;
		((TextBox)txtTK_du).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTK_du;
		location = new Point(112, 152);
		((Control)asTextBox3).Location = location;
		txtTK_du.LookupCodeName = "TK";
		((Control)txtTK_du).Name = "txtTK_du";
		txtTK_du.NameControl = lblTen_TKdu;
		AsTextBox asTextBox4 = txtTK_du;
		size = new Size(119, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTK_du).TabIndex = 5;
		txtTK_du.UseAutoCompleteSource = true;
		lblTen_TKdu.ImeMode = (ImeMode)0;
		Label obj14 = lblTen_TKdu;
		location = new Point(237, 156);
		((Control)obj14).Location = location;
		((Control)lblTen_TKdu).Name = "lblTen_TKdu";
		Label obj15 = lblTen_TKdu;
		size = new Size(321, 13);
		((Control)obj15).Size = size;
		((Control)lblTen_TKdu).TabIndex = 1210;
		lblTen_TKdu.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		Label obj16 = lblTk;
		location = new Point(15, 130);
		((Control)obj16).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj17 = lblTk;
		size = new Size(55, 13);
		((Control)obj17).Size = size;
		((Control)lblTk).TabIndex = 14;
		lblTk.Text = "Tài khoản";
		lblTk_du.AutoSize = true;
		Label obj18 = lblTk_du;
		location = new Point(15, 156);
		((Control)obj18).Location = location;
		((Control)lblTk_du).Name = "lblTk_du";
		Label obj19 = lblTk_du;
		size = new Size(60, 13);
		((Control)obj19).Size = size;
		((Control)lblTk_du).TabIndex = 13;
		lblTk_du.Text = "TK đối ứng";
		Label4.AutoSize = true;
		Label label3 = Label4;
		location = new Point(15, 99);
		((Control)label3).Location = location;
		((Control)Label4).Name = "Label4";
		Label label4 = Label4;
		size = new Size(84, 13);
		((Control)label4).Size = size;
		((Control)Label4).TabIndex = 12;
		Label4.Text = "Kiểu kết chuyển";
		((ButtonBase)chkKC_hd).AutoSize = true;
		chkKC_hd.Checked = false;
		AsCheckBox asCheckBox2 = chkKC_hd;
		location = new Point(112, 196);
		((Control)asCheckBox2).Location = location;
		((Control)chkKC_hd).Name = "chkKC_hd";
		AsCheckBox asCheckBox3 = chkKC_hd;
		size = new Size(155, 17);
		((Control)asCheckBox3).Size = size;
		((Control)chkKC_hd).TabIndex = 7;
		((ButtonBase)chkKC_hd).Text = "Kết chuyển theo Hợp đồng";
		chkKC_hd.TextValue = "0";
		((ButtonBase)chkKC_hd).UseVisualStyleBackColor = true;
		((ButtonBase)chkKC_bp).AutoSize = true;
		chkKC_bp.Checked = false;
		AsCheckBox asCheckBox4 = chkKC_bp;
		location = new Point(112, 219);
		((Control)asCheckBox4).Location = location;
		((Control)chkKC_bp).Name = "chkKC_bp";
		AsCheckBox asCheckBox5 = chkKC_bp;
		size = new Size(147, 17);
		((Control)asCheckBox5).Size = size;
		((Control)chkKC_bp).TabIndex = 8;
		((ButtonBase)chkKC_bp).Text = "Kết chuyển theo Bộ phận";
		chkKC_bp.TextValue = "0";
		((ButtonBase)chkKC_bp).UseVisualStyleBackColor = true;
		((ButtonBase)chkKC_spct).AutoSize = true;
		chkKC_spct.Checked = false;
		AsCheckBox asCheckBox6 = chkKC_spct;
		location = new Point(112, 242);
		((Control)asCheckBox6).Location = location;
		((Control)chkKC_spct).Name = "chkKC_spct";
		AsCheckBox asCheckBox7 = chkKC_spct;
		size = new Size(205, 17);
		((Control)asCheckBox7).Size = size;
		((Control)chkKC_spct).TabIndex = 9;
		((ButtonBase)chkKC_spct).Text = "Kết chuyển theo Sản phẩm công trình";
		chkKC_spct.TextValue = "0";
		((ButtonBase)chkKC_spct).UseVisualStyleBackColor = true;
		((ButtonBase)chkKC_phi).AutoSize = true;
		chkKC_phi.Checked = false;
		AsCheckBox asCheckBox8 = chkKC_phi;
		location = new Point(112, 265);
		((Control)asCheckBox8).Location = location;
		((Control)chkKC_phi).Name = "chkKC_phi";
		AsCheckBox asCheckBox9 = chkKC_phi;
		size = new Size(180, 17);
		((Control)asCheckBox9).Size = size;
		((Control)chkKC_phi).TabIndex = 10;
		((ButtonBase)chkKC_phi).Text = "Kết chuyển theo Khoản mục phí";
		chkKC_phi.TextValue = "0";
		((ButtonBase)chkKC_phi).UseVisualStyleBackColor = true;
		txtStt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtStt;
		location = new Point(112, 19);
		((Control)asTextNumeric).Location = location;
		txtStt.Mask = "### ### ### ###";
		((Control)txtStt).Name = "txtStt";
		AsTextNumeric asTextNumeric2 = txtStt;
		size = new Size(59, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtStt).TabIndex = 0;
		((TextBox)txtStt).Text = "0";
		((TextBox)txtStt).TextAlign = (HorizontalAlignment)1;
		txtStt.Value = 0.0;
		((ComboBox)cboLoai_kc).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_kc).FormattingEnabled = true;
		((ComboBox)cboLoai_kc).Items.AddRange(new object[4] { "Ghi nợ", "Ghi có", "Kết chuyển lãi-lỗ", "Kết chuyển thuế GTGT" });
		AsComboBox asComboBox = cboLoai_kc;
		location = new Point(112, 96);
		((Control)asComboBox).Location = location;
		((Control)cboLoai_kc).Name = "cboLoai_kc";
		AsComboBox asComboBox2 = cboLoai_kc;
		size = new Size(180, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboLoai_kc).TabIndex = 3;
		((ButtonBase)chkKcDtPs).AutoSize = true;
		CheckBox obj20 = chkKcDtPs;
		location = new Point(359, 196);
		((Control)obj20).Location = location;
		((Control)chkKcDtPs).Name = "chkKcDtPs";
		CheckBox obj21 = chkKcDtPs;
		size = new Size(249, 17);
		((Control)obj21).Size = size;
		((Control)chkKcDtPs).TabIndex = 1212;
		((ButtonBase)chkKcDtPs).Text = "Không k/c các giao dịch không theo đối tượng";
		((ButtonBase)chkKcDtPs).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(662, 412);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGLDMKCEdit";
		((Form)this).Text = "frmSiDMBpEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		if (!EditMode)
		{
			((Control)txtStt).Select();
			txtSo_ct.Text = "KC";
			loadCboKC();
		}
		else
		{
			((Control)txtTK_du).Tag = RuntimeHelpers.GetObjectValue(RowToEdit["tk_du"]);
			((Control)txtTK).Tag = RuntimeHelpers.GetObjectValue(RowToEdit["tk"]);
			loadCboKC();
			((ComboBox)cboLoai_kc).SelectedIndex = Conversions.ToInteger(Operators.SubtractObject(RowToEdit["Loai_kc"], (object)1));
		}
	}

	protected override bool SetToRow()
	{
		base.SetToRow();
		if (!EditMode)
		{
			RowToEdit["Moduleid"] = MyMenuInfo.moduleid;
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RowToEdit["Stt"].ToString().Trim(), isNum: false), (object)"", false))
			{
				RowToEdit["Stt"] = "1";
			}
		}
		else
		{
			DataRow rowToEdit = RowToEdit;
			DataRow dataRow = rowToEdit;
			string columnName = "tk_du";
			dataRow[columnName] = Operators.ConcatenateObject(rowToEdit[columnName], (object)("," + ((Control)txtTK_du).Tag.ToString()));
			rowToEdit = RowToEdit;
			DataRow dataRow2 = rowToEdit;
			columnName = "tk";
			dataRow2[columnName] = Operators.ConcatenateObject(rowToEdit[columnName], (object)("," + ((Control)txtTK).Tag.ToString()));
		}
		RowToEdit["ten_loai"] = ((ComboBox)cboLoai_kc).Text;
		bool result = default(bool);
		return result;
	}

	protected override bool UpdateDB()
	{
		bool result = base.UpdateDB();
		string text = Conversions.ToString(RowToEdit["tk_du"]);
		string text2 = Conversions.ToString(RowToEdit["tk"]);
		RowToEdit["tk_du"] = text.Remove(text.IndexOf(","));
		RowToEdit["tk"] = text2.Remove(text2.IndexOf(","));
		return result;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtStt).Enabled = false;
		((Control)txtTK).Enabled = false;
		((Control)txtTK_du).Enabled = false;
		((Control)txtTen_bt).Select();
	}

	protected override void DataBinding()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtStt;
		CreateDataBinding(ref ojb, "Stt", "Value");
		txtStt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTen_bt;
		CreateDataBinding(ref ojb, "ten_bt");
		txtTen_bt = (TextBox)ojb;
		ojb = (Control)(object)txtTK;
		CreateDataBinding(ref ojb, "tk");
		txtTK = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTK_du;
		CreateDataBinding(ref ojb, "tk_du");
		txtTK_du = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "So_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)cboLoai_kc;
		CreateDataBinding(ref ojb, "loai_kc", "SelectedValue");
		cboLoai_kc = (AsComboBox)(object)ojb;
		ojb = (Control)(object)chkKC_bp;
		CreateDataBinding(ref ojb, "kc_bp", "Checked");
		chkKC_bp = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkKC_hd;
		CreateDataBinding(ref ojb, "kc_hd", "Checked");
		chkKC_hd = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkKC_spct;
		CreateDataBinding(ref ojb, "kc_spct", "Checked");
		chkKC_spct = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkKC_phi;
		CreateDataBinding(ref ojb, "kc_phi", "Checked");
		chkKC_phi = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkKcDtPs;
		CreateDataBinding(ref ojb, "Kc_dt_ps", "Checked");
		chkKcDtPs = (CheckBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox((TextBox)(object)txtStt) || !ChkEmtyTextBox(txtTen_bt) || !ChkEmtyTextBox((TextBox)(object)txtTK) || !ChkEmtyTextBox((TextBox)(object)txtTK_du) || !base.ValidData())
		{
			return false;
		}
		return true;
	}

	private void frmGLDMKCEdit_Load(object sender, EventArgs e)
	{
		if (!EditMode)
		{
			((TextBox)txtStt).Text = frmGLDMKC.GetSttMax;
		}
	}

	private void chkKC_phi_CheckedChanged(object sender, EventArgs e)
	{
		CheckKcDtPs();
	}

	private void loadCboKC()
	{
		ArrayList arrayList = new ArrayList();
		DictionaryEntry dictionaryEntry = new DictionaryEntry("1", RuntimeHelpers.GetObjectValue(((ComboBox)cboLoai_kc).Items[0]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("2", RuntimeHelpers.GetObjectValue(((ComboBox)cboLoai_kc).Items[1]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("3", RuntimeHelpers.GetObjectValue(((ComboBox)cboLoai_kc).Items[2]));
		arrayList.Add(dictionaryEntry);
		dictionaryEntry = new DictionaryEntry("4", RuntimeHelpers.GetObjectValue(((ComboBox)cboLoai_kc).Items[3]));
		arrayList.Add(dictionaryEntry);
		((ComboBox)cboLoai_kc).DataSource = arrayList;
		((ListControl)cboLoai_kc).DisplayMember = "Value";
		((ListControl)cboLoai_kc).ValueMember = "Key";
	}

	private void CheckKcDtPs()
	{
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(chkKC_bp.Checked, chkKC_hd.Checked), chkKC_phi.Checked), chkKC_spct.Checked)))
		{
			((Control)chkKcDtPs).Enabled = true;
			return;
		}
		chkKcDtPs.Checked = false;
		((Control)chkKcDtPs).Enabled = false;
	}
}
