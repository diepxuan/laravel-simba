using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmARCDKHEdit : frmOBEdit
{
	private IContainer components;

	[AccessedThroughProperty("lblYear")]
	private Label _lblYear;

	[AccessedThroughProperty("txtYear")]
	private AsTextNumeric _txtYear;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("lblTen_nt")]
	private Label _lblTen_nt;

	[AccessedThroughProperty("lblNt")]
	private Label _lblNt;

	[AccessedThroughProperty("txtMa_kh")]
	private AsTextBox _txtMa_kh;

	[AccessedThroughProperty("lblTen_kh")]
	private Label _lblTen_kh;

	[AccessedThroughProperty("lblMa_kh")]
	private Label _lblMa_kh;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("txtDuCoNt")]
	private AsTextNumeric _txtDuCoNt;

	[AccessedThroughProperty("txtDuNoNt")]
	private AsTextNumeric _txtDuNoNt;

	[AccessedThroughProperty("txtDuCo")]
	private AsTextNumeric _txtDuCo;

	[AccessedThroughProperty("txtDuNo")]
	private AsTextNumeric _txtDuNo;

	[AccessedThroughProperty("lblDuCoNt")]
	private Label _lblDuCoNt;

	[AccessedThroughProperty("lblDuNoNt")]
	private Label _lblDuNoNt;

	[AccessedThroughProperty("lblDuCo")]
	private Label _lblDuCo;

	[AccessedThroughProperty("lblDuNo")]
	private Label _lblDuNo;

	[AccessedThroughProperty("cboNt")]
	private AsComboBoxNT _cboNt;

	private string _price;

	private string _priceNt;

	internal virtual Label lblYear
	{
		get
		{
			return _lblYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblYear = value;
		}
	}

	internal virtual AsTextNumeric txtYear
	{
		get
		{
			return _txtYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtYear = value;
		}
	}

	internal virtual AsTextBox txtTk
	{
		get
		{
			return _txtTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTk = value;
		}
	}

	internal virtual Label lblTen_tk
	{
		get
		{
			return _lblTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_tk = value;
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

	internal virtual Label lblTen_nt
	{
		get
		{
			return _lblTen_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_nt = value;
		}
	}

	internal virtual Label lblNt
	{
		get
		{
			return _lblNt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNt = value;
		}
	}

	internal virtual AsTextBox txtMa_kh
	{
		get
		{
			return _txtMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_kh = value;
		}
	}

	internal virtual Label lblTen_kh
	{
		get
		{
			return _lblTen_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_kh = value;
		}
	}

	internal virtual Label lblMa_kh
	{
		get
		{
			return _lblMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_kh = value;
		}
	}

	internal virtual AsTextBox txtMa_hd
	{
		get
		{
			return _txtMa_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_hd = value;
		}
	}

	internal virtual Label lblTen_hd
	{
		get
		{
			return _lblTen_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_hd = value;
		}
	}

	internal virtual AsTextBox txtMa_bp
	{
		get
		{
			return _txtMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_bp = value;
		}
	}

	internal virtual Label lblTen_bp
	{
		get
		{
			return _lblTen_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_bp = value;
		}
	}

	internal virtual Label lblMa_hd
	{
		get
		{
			return _lblMa_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_hd = value;
		}
	}

	internal virtual Label lblMa_bp
	{
		get
		{
			return _lblMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_bp = value;
		}
	}

	internal virtual AsTextBox txtMa_spct
	{
		get
		{
			return _txtMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_spct = value;
		}
	}

	internal virtual Label lblTen_spct
	{
		get
		{
			return _lblTen_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_spct = value;
		}
	}

	internal virtual Label lblMa_spct
	{
		get
		{
			return _lblMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_spct = value;
		}
	}

	internal virtual AsTextNumeric txtDuCoNt
	{
		get
		{
			return _txtDuCoNt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtDuCoNt = value;
		}
	}

	internal virtual AsTextNumeric txtDuNoNt
	{
		get
		{
			return _txtDuNoNt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtDuNoNt = value;
		}
	}

	internal virtual AsTextNumeric txtDuCo
	{
		get
		{
			return _txtDuCo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtDuCo_Validated;
			if (_txtDuCo != null)
			{
				((Control)_txtDuCo).Validated -= eventHandler;
			}
			_txtDuCo = value;
			if (_txtDuCo != null)
			{
				((Control)_txtDuCo).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtDuNo
	{
		get
		{
			return _txtDuNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = txtDuNo_Validated;
			if (_txtDuNo != null)
			{
				((Control)_txtDuNo).Validated -= eventHandler;
			}
			_txtDuNo = value;
			if (_txtDuNo != null)
			{
				((Control)_txtDuNo).Validated += eventHandler;
			}
		}
	}

	internal virtual Label lblDuCoNt
	{
		get
		{
			return _lblDuCoNt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblDuCoNt = value;
		}
	}

	internal virtual Label lblDuNoNt
	{
		get
		{
			return _lblDuNoNt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblDuNoNt = value;
		}
	}

	internal virtual Label lblDuCo
	{
		get
		{
			return _lblDuCo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblDuCo = value;
		}
	}

	internal virtual Label lblDuNo
	{
		get
		{
			return _lblDuNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblDuNo = value;
		}
	}

	internal virtual AsComboBoxNT cboNt
	{
		get
		{
			return _cboNt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboNt_SelectedIndexChanged;
			if (_cboNt != null)
			{
				((ComboBox)_cboNt).SelectedIndexChanged -= eventHandler;
			}
			_cboNt = value;
			if (_cboNt != null)
			{
				((ComboBox)_cboNt).SelectedIndexChanged += eventHandler;
			}
		}
	}

	public frmARCDKHEdit()
	{
		_price = "";
		_priceNt = "";
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		lblYear = new Label();
		txtYear = new AsTextNumeric();
		txtTk = new AsTextBox();
		lblTen_tk = new Label();
		lblTk = new Label();
		cboNt = new AsComboBoxNT();
		lblNt = new Label();
		lblTen_nt = new Label();
		lblMa_kh = new Label();
		lblTen_kh = new Label();
		txtMa_kh = new AsTextBox();
		lblMa_bp = new Label();
		lblTen_bp = new Label();
		txtMa_bp = new AsTextBox();
		lblMa_hd = new Label();
		lblTen_hd = new Label();
		txtMa_hd = new AsTextBox();
		lblMa_spct = new Label();
		lblTen_spct = new Label();
		txtMa_spct = new AsTextBox();
		txtDuNo = new AsTextNumeric();
		lblDuNo = new Label();
		lblDuCo = new Label();
		txtDuCo = new AsTextNumeric();
		lblDuNoNt = new Label();
		txtDuNoNt = new AsTextNumeric();
		lblDuCoNt = new Label();
		txtDuCoNt = new AsTextNumeric();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(426, 344);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 324);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 324);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtDuCoNt);
		((Control)gbLine).Controls.Add((Control)(object)txtDuNoNt);
		((Control)gbLine).Controls.Add((Control)(object)txtDuCo);
		((Control)gbLine).Controls.Add((Control)(object)txtDuNo);
		((Control)gbLine).Controls.Add((Control)(object)cboNt);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_spct);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_hd);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_bp);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_kh);
		((Control)gbLine).Controls.Add((Control)(object)txtTk);
		((Control)gbLine).Controls.Add((Control)(object)txtYear);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_spct);
		((Control)gbLine).Controls.Add((Control)(object)lblDuCoNt);
		((Control)gbLine).Controls.Add((Control)(object)lblDuNoNt);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_hd);
		((Control)gbLine).Controls.Add((Control)(object)lblDuCo);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblDuNo);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_spct);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_bp);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_hd);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_kh);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_bp);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_kh);
		((Control)gbLine).Controls.Add((Control)(object)lblNt);
		((Control)gbLine).Controls.Add((Control)(object)lblTk);
		((Control)gbLine).Controls.Add((Control)(object)lblYear);
		GroupBox obj3 = gbLine;
		Size size = new Size(572, 312);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDuNo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDuCo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDuNoNt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDuCoNt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboNt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDuNo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDuCo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDuNoNt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDuCoNt, 0);
		lblYear.AutoSize = true;
		Label obj4 = lblYear;
		location = new Point(22, 23);
		((Control)obj4).Location = location;
		((Control)lblYear).Name = "lblYear";
		Label obj5 = lblYear;
		size = new Size(29, 13);
		((Control)obj5).Size = size;
		((Control)lblYear).TabIndex = 100;
		lblYear.Text = "Năm";
		txtYear.DecimalSymbol = ".";
		txtYear.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtYear;
		location = new Point(105, 19);
		((Control)asTextNumeric).Location = location;
		txtYear.Mask = "####";
		((Control)txtYear).Name = "txtYear";
		((TextBoxBase)txtYear).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtYear;
		size = new Size(51, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtYear).TabIndex = 101;
		((Control)txtYear).TabStop = false;
		((TextBox)txtYear).Text = "0";
		((TextBox)txtYear).TextAlign = (HorizontalAlignment)1;
		txtYear.Value = 0;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = true;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTk;
		location = new Point(105, 72);
		((Control)asTextBox).Location = location;
		txtTk.LookupCodeName = "TK";
		txtTk.LookupWhereCondition = "chi_tiet=1 and tk_cn=1";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_tk;
		AsTextBox asTextBox2 = txtTk;
		size = new Size(74, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTk).TabIndex = 1;
		txtTk.UseAutoCompleteSource = true;
		Label obj6 = lblTen_tk;
		location = new Point(185, 76);
		((Control)obj6).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj7 = lblTen_tk;
		size = new Size(381, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_tk).TabIndex = 100;
		lblTk.AutoSize = true;
		Label obj8 = lblTk;
		location = new Point(22, 76);
		((Control)obj8).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj9 = lblTk;
		size = new Size(39, 13);
		((Control)obj9).Size = size;
		((Control)lblTk).TabIndex = 100;
		lblTk.Text = "Mã TK";
		((ComboBox)cboNt).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNt).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboNt;
		location = new Point(105, 45);
		((Control)asComboBoxNT).Location = location;
		cboNt.MA_NT = "";
		((Control)cboNt).Name = "cboNt";
		AsComboBoxNT asComboBoxNT2 = cboNt;
		size = new Size(51, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboNt).TabIndex = 0;
		lblNt.AutoSize = true;
		Label obj10 = lblNt;
		location = new Point(22, 49);
		((Control)obj10).Location = location;
		((Control)lblNt).Name = "lblNt";
		Label obj11 = lblNt;
		size = new Size(40, 13);
		((Control)obj11).Size = size;
		((Control)lblNt).TabIndex = 100;
		lblNt.Text = "Mã NT";
		Label obj12 = lblTen_nt;
		location = new Point(162, 49);
		((Control)obj12).Location = location;
		((Control)lblTen_nt).Name = "lblTen_nt";
		Label obj13 = lblTen_nt;
		size = new Size(154, 13);
		((Control)obj13).Size = size;
		((Control)lblTen_nt).TabIndex = 100;
		lblMa_kh.AutoSize = true;
		Label obj14 = lblMa_kh;
		location = new Point(22, 102);
		((Control)obj14).Location = location;
		((Control)lblMa_kh).Name = "lblMa_kh";
		Label obj15 = lblMa_kh;
		size = new Size(40, 13);
		((Control)obj15).Size = size;
		((Control)lblMa_kh).TabIndex = 100;
		lblMa_kh.Text = "Mã KH";
		Label obj16 = lblTen_kh;
		location = new Point(185, 102);
		((Control)obj16).Location = location;
		((Control)lblTen_kh).Name = "lblTen_kh";
		Label obj17 = lblTen_kh;
		size = new Size(381, 13);
		((Control)obj17).Size = size;
		((Control)lblTen_kh).TabIndex = 100;
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = true;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_kh;
		location = new Point(105, 98);
		((Control)asTextBox3).Location = location;
		txtMa_kh.LookupCodeName = "MA_KH";
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = lblTen_kh;
		AsTextBox asTextBox4 = txtMa_kh;
		size = new Size(74, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_kh).TabIndex = 2;
		txtMa_kh.UseAutoCompleteSource = true;
		lblMa_bp.AutoSize = true;
		Label obj18 = lblMa_bp;
		location = new Point(22, 128);
		((Control)obj18).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj19 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_bp).TabIndex = 100;
		lblMa_bp.Text = "Mã bộ phận";
		Label obj20 = lblTen_bp;
		location = new Point(185, 128);
		((Control)obj20).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj21 = lblTen_bp;
		size = new Size(381, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_bp).TabIndex = 100;
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = true;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_bp;
		location = new Point(105, 124);
		((Control)asTextBox5).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox6 = txtMa_bp;
		size = new Size(74, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_bp).TabIndex = 3;
		txtMa_bp.UseAutoCompleteSource = true;
		lblMa_hd.AutoSize = true;
		Label obj22 = lblMa_hd;
		location = new Point(22, 154);
		((Control)obj22).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj23 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj23).Size = size;
		((Control)lblMa_hd).TabIndex = 100;
		lblMa_hd.Text = "Mã hợp đồng";
		Label obj24 = lblTen_hd;
		location = new Point(185, 154);
		((Control)obj24).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj25 = lblTen_hd;
		size = new Size(381, 13);
		((Control)obj25).Size = size;
		((Control)lblTen_hd).TabIndex = 100;
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = true;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_hd;
		location = new Point(105, 150);
		((Control)asTextBox7).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox8 = txtMa_hd;
		size = new Size(74, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_hd).TabIndex = 4;
		txtMa_hd.UseAutoCompleteSource = true;
		lblMa_spct.AutoSize = true;
		Label obj26 = lblMa_spct;
		location = new Point(22, 180);
		((Control)obj26).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj27 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj27).Size = size;
		((Control)lblMa_spct).TabIndex = 100;
		lblMa_spct.Text = "Mã SPCT";
		Label obj28 = lblTen_spct;
		location = new Point(185, 180);
		((Control)obj28).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj29 = lblTen_spct;
		size = new Size(381, 13);
		((Control)obj29).Size = size;
		((Control)lblTen_spct).TabIndex = 100;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = true;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_spct;
		location = new Point(105, 176);
		((Control)asTextBox9).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox10 = txtMa_spct;
		size = new Size(74, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_spct).TabIndex = 5;
		txtMa_spct.UseAutoCompleteSource = true;
		txtDuNo.DecimalSymbol = ".";
		txtDuNo.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtDuNo;
		location = new Point(105, 202);
		((Control)asTextNumeric3).Location = location;
		txtDuNo.Mask = "### ### ### ###.##";
		((Control)txtDuNo).Name = "txtDuNo";
		AsTextNumeric asTextNumeric4 = txtDuNo;
		size = new Size(124, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtDuNo).TabIndex = 6;
		((TextBox)txtDuNo).Text = "0.00";
		((TextBox)txtDuNo).TextAlign = (HorizontalAlignment)1;
		txtDuNo.Value = 0;
		lblDuNo.AutoSize = true;
		Label obj30 = lblDuNo;
		location = new Point(22, 206);
		((Control)obj30).Location = location;
		((Control)lblDuNo).Name = "lblDuNo";
		Label obj31 = lblDuNo;
		size = new Size(36, 13);
		((Control)obj31).Size = size;
		((Control)lblDuNo).TabIndex = 100;
		lblDuNo.Text = "Dư nợ";
		lblDuCo.AutoSize = true;
		Label obj32 = lblDuCo;
		location = new Point(22, 232);
		((Control)obj32).Location = location;
		((Control)lblDuCo).Name = "lblDuCo";
		Label obj33 = lblDuCo;
		size = new Size(36, 13);
		((Control)obj33).Size = size;
		((Control)lblDuCo).TabIndex = 100;
		lblDuCo.Text = "Dư có";
		txtDuCo.DecimalSymbol = ".";
		txtDuCo.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtDuCo;
		location = new Point(105, 228);
		((Control)asTextNumeric5).Location = location;
		txtDuCo.Mask = "### ### ### ###.##";
		((Control)txtDuCo).Name = "txtDuCo";
		AsTextNumeric asTextNumeric6 = txtDuCo;
		size = new Size(124, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtDuCo).TabIndex = 7;
		((TextBox)txtDuCo).Text = "0.00";
		((TextBox)txtDuCo).TextAlign = (HorizontalAlignment)1;
		txtDuCo.Value = 0;
		lblDuNoNt.AutoSize = true;
		Label obj34 = lblDuNoNt;
		location = new Point(22, 258);
		((Control)obj34).Location = location;
		((Control)lblDuNoNt).Name = "lblDuNoNt";
		Label obj35 = lblDuNoNt;
		size = new Size(54, 13);
		((Control)obj35).Size = size;
		((Control)lblDuNoNt).TabIndex = 100;
		lblDuNoNt.Text = "Dư nợ NT";
		txtDuNoNt.DecimalSymbol = ".";
		txtDuNoNt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtDuNoNt;
		location = new Point(105, 254);
		((Control)asTextNumeric7).Location = location;
		txtDuNoNt.Mask = "### ### ### ###.##";
		((Control)txtDuNoNt).Name = "txtDuNoNt";
		AsTextNumeric asTextNumeric8 = txtDuNoNt;
		size = new Size(124, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtDuNoNt).TabIndex = 8;
		((TextBox)txtDuNoNt).Text = "0.00";
		((TextBox)txtDuNoNt).TextAlign = (HorizontalAlignment)1;
		txtDuNoNt.Value = 0;
		lblDuCoNt.AutoSize = true;
		Label obj36 = lblDuCoNt;
		location = new Point(22, 284);
		((Control)obj36).Location = location;
		((Control)lblDuCoNt).Name = "lblDuCoNt";
		Label obj37 = lblDuCoNt;
		size = new Size(54, 13);
		((Control)obj37).Size = size;
		((Control)lblDuCoNt).TabIndex = 100;
		lblDuCoNt.Text = "Dư có NT";
		txtDuCoNt.DecimalSymbol = ".";
		txtDuCoNt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric9 = txtDuCoNt;
		location = new Point(105, 280);
		((Control)asTextNumeric9).Location = location;
		txtDuCoNt.Mask = "### ### ### ###.##";
		((Control)txtDuCoNt).Name = "txtDuCoNt";
		AsTextNumeric asTextNumeric10 = txtDuCoNt;
		size = new Size(124, 20);
		((Control)asTextNumeric10).Size = size;
		((Control)txtDuCoNt).TabIndex = 9;
		((TextBox)txtDuCoNt).Text = "0.00";
		((TextBox)txtDuCoNt).TextAlign = (HorizontalAlignment)1;
		txtDuCoNt.Value = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(596, 359);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmARCDKHEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitAfterGetData()
	{
		_price = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		_priceNt = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		txtDuNo.Mask = _price;
		txtDuCo.Mask = _price;
		txtDuNoNt.Mask = _priceNt;
		txtDuCoNt.Mask = _priceNt;
		if (!EditMode)
		{
			ArrayList arrayList = new ArrayList();
			foreach (DMNTInformation item in (ArrayList)((ComboBox)cboNt).DataSource)
			{
				if (!item.ksd)
				{
					arrayList.Add(item);
				}
			}
			((ComboBox)cboNt).DataSource = arrayList;
			txtYear.Value = SystemInformations.FinancialYear;
			((ListControl)cboNt).SelectedValue = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		}
		if (Operators.CompareString(MyMenuInfo.moduleid, "PO", false) == 0)
		{
			((Form)this).Text = "Số dư đầu kỳ công nợ phải trả";
		}
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtTk).Enabled = false;
		((Control)cboNt).Enabled = false;
		((Control)txtMa_kh).Enabled = false;
		((Control)txtMa_bp).Enabled = false;
		((Control)txtMa_spct).Enabled = false;
		((Control)txtMa_hd).Enabled = false;
	}

	protected override void DataBinding()
	{
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtYear;
		CreateDataBinding(ref ojb, "nam", "Value");
		txtYear = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDuCo;
		CreateDataBinding(ref ojb, "du_co", "Value");
		txtDuCo = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDuCoNt;
		CreateDataBinding(ref ojb, "du_co_nt", "Value");
		txtDuCoNt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDuNo;
		CreateDataBinding(ref ojb, "du_no", "Value");
		txtDuNo = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtDuNoNt;
		CreateDataBinding(ref ojb, "du_no_nt", "Value");
		txtDuNoNt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtMa_bp;
		CreateDataBinding(ref ojb, "ma_bp");
		txtMa_bp = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_hd;
		CreateDataBinding(ref ojb, "ma_hd");
		txtMa_hd = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_kh;
		CreateDataBinding(ref ojb, "ma_kh");
		txtMa_kh = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_kh;
		CreateDataBinding(ref ojb, "ten_kh");
		lblTen_kh = (Label)ojb;
		ojb = (Control)(object)txtMa_spct;
		CreateDataBinding(ref ojb, "ma_spct");
		txtMa_spct = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk;
		CreateDataBinding(ref ojb, "tk");
		txtTk = (AsTextBox)(object)ojb;
		ojb = (Control)(object)cboNt;
		CreateDataBinding(ref ojb, "ma_nt", "SelectedValue");
		cboNt = (AsComboBoxNT)(object)ojb;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox((TextBox)(object)txtTk) || !ChkEmtyTextBox((TextBox)(object)txtMa_kh))
		{
			return false;
		}
		return true;
	}

	private void cboNt_SelectedIndexChanged(object sender, EventArgs e)
	{
		lblTen_nt.Text = ((ComboBox)cboNt).Text;
		bool enabled = Operators.CompareString(AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, ((ComboBox)cboNt).Text, false) != 0;
		((Control)txtDuCoNt).Enabled = enabled;
		((Control)txtDuNoNt).Enabled = enabled;
	}

	protected override bool SetToRow()
	{
		return base.SetToRow();
	}

	private void txtDuNo_Validated(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(Helper.Repl_Null(Strings.Trim(Conversions.ToString(txtDuCo.Value)), isNum: true), (object)0, false), Operators.CompareObjectGreater(Helper.Repl_Null(Strings.Trim(Conversions.ToString(txtDuNo.Value)), isNum: true), (object)0, false))))
		{
			txtDuCo.Value = 0;
		}
	}

	private void txtDuCo_Validated(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(Helper.Repl_Null(Strings.Trim(Conversions.ToString(txtDuNo.Value)), isNum: true), (object)0, false), Operators.CompareObjectGreater(Helper.Repl_Null(Strings.Trim(Conversions.ToString(txtDuCo.Value)), isNum: true), (object)0, false))))
		{
			txtDuNo.Value = 0;
		}
	}
}
