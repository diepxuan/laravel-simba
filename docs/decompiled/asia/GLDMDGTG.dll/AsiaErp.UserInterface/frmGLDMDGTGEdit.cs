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
public class frmGLDMDGTGEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("chkdg_kh")]
	private AsCheckBox _chkdg_kh;

	[AccessedThroughProperty("chkdg_phi")]
	private AsCheckBox _chkdg_phi;

	[AccessedThroughProperty("chkdg_spct")]
	private AsCheckBox _chkdg_spct;

	[AccessedThroughProperty("chkdg_hd")]
	private AsCheckBox _chkdg_hd;

	[AccessedThroughProperty("chkdg_bp")]
	private AsCheckBox _chkdg_bp;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtTk_lo_cltg")]
	private AsTextBox _txtTk_lo_cltg;

	[AccessedThroughProperty("txtTk_lai_cltg")]
	private AsTextBox _txtTk_lai_cltg;

	[AccessedThroughProperty("txtTen_bt")]
	private TextBox _txtTen_bt;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("cboLoai_dg")]
	private AsComboBox _cboLoai_dg;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txTk_cltg_cn")]
	private AsTextBox _txTk_cltg_cn;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("txtTk_dgtg")]
	private AsTextBox _txtTk_dgtg;

	[AccessedThroughProperty("lblTen_Tk_cltg_cn")]
	private Label _lblTen_Tk_cltg_cn;

	[AccessedThroughProperty("lblTen_Tk_lo_cltg")]
	private Label _lblTen_Tk_lo_cltg;

	[AccessedThroughProperty("lblTen_Tk_lai_cltg")]
	private Label _lblTen_Tk_lai_cltg;

	[AccessedThroughProperty("lblTen_Tk_dgtg")]
	private Label _lblTen_Tk_dgtg;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtSTT")]
	private AsTextNumeric _txtSTT;

	public static int iSttMax = 0;

	internal virtual AsCheckBox chkdg_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkdg_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkdg_kh = value;
		}
	}

	internal virtual AsCheckBox chkdg_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkdg_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkdg_phi = value;
		}
	}

	internal virtual AsCheckBox chkdg_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkdg_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkdg_spct = value;
		}
	}

	internal virtual AsCheckBox chkdg_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkdg_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkdg_hd = value;
		}
	}

	internal virtual AsCheckBox chkdg_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkdg_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkdg_bp = value;
		}
	}

	internal virtual TextBox txtSo_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ct = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
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

	internal virtual AsTextBox txtTk_lo_cltg
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_lo_cltg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_lo_cltg = value;
		}
	}

	internal virtual AsTextBox txtTk_lai_cltg
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_lai_cltg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_lai_cltg = value;
		}
	}

	internal virtual TextBox txtTen_bt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_bt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_bt = value;
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

	internal virtual AsComboBox cboLoai_dg
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboLoai_dg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboLoai_dg = value;
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

	internal virtual AsTextBox txTk_cltg_cn
	{
		[DebuggerNonUserCode]
		get
		{
			return _txTk_cltg_cn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txTk_cltg_cn = value;
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

	internal virtual AsTextBox txtTk_dgtg
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_dgtg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtTk_dgtg_AfterCodeValidating;
			if (_txtTk_dgtg != null)
			{
				_txtTk_dgtg.AfterCodeValidating -= obj;
			}
			_txtTk_dgtg = value;
			if (_txtTk_dgtg != null)
			{
				_txtTk_dgtg.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual Label lblTen_Tk_cltg_cn
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_cltg_cn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_cltg_cn = value;
		}
	}

	internal virtual Label lblTen_Tk_lo_cltg
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_lo_cltg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_lo_cltg = value;
		}
	}

	internal virtual Label lblTen_Tk_lai_cltg
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_lai_cltg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_lai_cltg = value;
		}
	}

	internal virtual Label lblTen_Tk_dgtg
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk_dgtg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk_dgtg = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual AsTextNumeric txtSTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSTT = value;
		}
	}

	[DebuggerNonUserCode]
	public frmGLDMDGTGEdit()
	{
		InitializeComponent();
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		chkdg_kh = new AsCheckBox();
		chkdg_bp = new AsCheckBox();
		chkdg_hd = new AsCheckBox();
		chkdg_spct = new AsCheckBox();
		chkdg_phi = new AsCheckBox();
		Label1 = new Label();
		txtTen_bt = new TextBox();
		Label2 = new Label();
		txtTk_lai_cltg = new AsTextBox();
		lblTen_Tk_lai_cltg = new Label();
		txtTk_lo_cltg = new AsTextBox();
		lblTen_Tk_lo_cltg = new Label();
		Label3 = new Label();
		Label4 = new Label();
		txtSo_ct = new TextBox();
		Label6 = new Label();
		cboLoai_dg = new AsComboBox();
		Label7 = new Label();
		txtTk_dgtg = new AsTextBox();
		lblTen_Tk_dgtg = new Label();
		Label5 = new Label();
		txTk_cltg_cn = new AsTextBox();
		lblTen_Tk_cltg_cn = new Label();
		txtSTT = new AsTextNumeric();
		Label8 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(194, 343);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 13;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 385);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 385);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)Label8);
		((Control)gbLine).Controls.Add((Control)(object)txtSTT);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_cltg_cn);
		((Control)gbLine).Controls.Add((Control)(object)cboLoai_dg);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_lo_cltg);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_lai_cltg);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_Tk_dgtg);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)txTk_cltg_cn);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_dgtg);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)Label6);
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_lo_cltg);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_lai_cltg);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_bt);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)chkdg_phi);
		((Control)gbLine).Controls.Add((Control)(object)chkdg_spct);
		((Control)gbLine).Controls.Add((Control)(object)chkdg_hd);
		((Control)gbLine).Controls.Add((Control)(object)chkdg_bp);
		((Control)gbLine).Controls.Add((Control)(object)chkdg_kh);
		GroupBox obj3 = gbLine;
		Size size = new Size(623, 373);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkdg_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkdg_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkdg_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkdg_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkdg_phi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_bt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_lai_cltg, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_lo_cltg, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_dgtg, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txTk_cltg_cn, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_dgtg, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_lai_cltg, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_lo_cltg, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboLoai_dg, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_Tk_cltg_cn, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSTT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label8, 0);
		((ButtonBase)chkdg_kh).AutoSize = true;
		chkdg_kh.Checked = false;
		AsCheckBox asCheckBox2 = chkdg_kh;
		location = new Point(194, 228);
		((Control)asCheckBox2).Location = location;
		((Control)chkdg_kh).Name = "chkdg_kh";
		AsCheckBox asCheckBox3 = chkdg_kh;
		size = new Size(153, 17);
		((Control)asCheckBox3).Size = size;
		((Control)chkdg_kh).TabIndex = 8;
		((ButtonBase)chkdg_kh).Text = "Đánh giá theo khách hàng";
		chkdg_kh.TextValue = "0";
		((ButtonBase)chkdg_kh).UseVisualStyleBackColor = true;
		((ButtonBase)chkdg_bp).AutoSize = true;
		chkdg_bp.Checked = false;
		AsCheckBox asCheckBox4 = chkdg_bp;
		location = new Point(194, 251);
		((Control)asCheckBox4).Location = location;
		((Control)chkdg_bp).Name = "chkdg_bp";
		AsCheckBox asCheckBox5 = chkdg_bp;
		size = new Size(135, 17);
		((Control)asCheckBox5).Size = size;
		((Control)chkdg_bp).TabIndex = 9;
		((ButtonBase)chkdg_bp).Text = "Đánh giá theo bộ phận";
		chkdg_bp.TextValue = "0";
		((ButtonBase)chkdg_bp).UseVisualStyleBackColor = true;
		((ButtonBase)chkdg_hd).AutoSize = true;
		chkdg_hd.Checked = false;
		AsCheckBox asCheckBox6 = chkdg_hd;
		location = new Point(194, 274);
		((Control)asCheckBox6).Location = location;
		((Control)chkdg_hd).Name = "chkdg_hd";
		AsCheckBox asCheckBox7 = chkdg_hd;
		size = new Size(142, 17);
		((Control)asCheckBox7).Size = size;
		((Control)chkdg_hd).TabIndex = 10;
		((ButtonBase)chkdg_hd).Text = "Đánh giá theo hợp đồng";
		chkdg_hd.TextValue = "0";
		((ButtonBase)chkdg_hd).UseVisualStyleBackColor = true;
		((ButtonBase)chkdg_spct).AutoSize = true;
		chkdg_spct.Checked = false;
		AsCheckBox asCheckBox8 = chkdg_spct;
		location = new Point(194, 297);
		((Control)asCheckBox8).Location = location;
		((Control)chkdg_spct).Name = "chkdg_spct";
		AsCheckBox asCheckBox9 = chkdg_spct;
		size = new Size(192, 17);
		((Control)asCheckBox9).Size = size;
		((Control)chkdg_spct).TabIndex = 11;
		((ButtonBase)chkdg_spct).Text = "Đánh giá theo sản phẩm công trình";
		chkdg_spct.TextValue = "0";
		((ButtonBase)chkdg_spct).UseVisualStyleBackColor = true;
		((ButtonBase)chkdg_phi).AutoSize = true;
		chkdg_phi.Checked = false;
		AsCheckBox asCheckBox10 = chkdg_phi;
		location = new Point(194, 320);
		((Control)asCheckBox10).Location = location;
		((Control)chkdg_phi).Name = "chkdg_phi";
		AsCheckBox asCheckBox11 = chkdg_phi;
		size = new Size(112, 17);
		((Control)asCheckBox11).Size = size;
		((Control)chkdg_phi).TabIndex = 12;
		((ButtonBase)chkdg_phi).Text = "Đánh giá theo phí";
		chkdg_phi.TextValue = "0";
		((ButtonBase)chkdg_phi).UseVisualStyleBackColor = true;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(17, 100);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(72, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 105;
		Label1.Text = "Loại đánh giá";
		TextBox obj4 = txtTen_bt;
		location = new Point(194, 45);
		((Control)obj4).Location = location;
		((TextBoxBase)txtTen_bt).MaxLength = 50;
		((Control)txtTen_bt).Name = "txtTen_bt";
		TextBox obj5 = txtTen_bt;
		size = new Size(410, 20);
		((Control)obj5).Size = size;
		((Control)txtTen_bt).TabIndex = 1;
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(15, 47);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(68, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 107;
		Label2.Text = "Tên bút toán";
		txtTk_lai_cltg.AutoLookup = true;
		txtTk_lai_cltg.AutoValid = true;
		((TextBoxBase)txtTk_lai_cltg).BackColor = SystemColors.Info;
		((TextBox)txtTk_lai_cltg).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTk_lai_cltg;
		location = new Point(194, 124);
		((Control)asTextBox).Location = location;
		txtTk_lai_cltg.LookupCodeName = "TK";
		txtTk_lai_cltg.LookupWhereCondition = "chi_tiet=1";
		((TextBoxBase)txtTk_lai_cltg).MaxLength = 20;
		((Control)txtTk_lai_cltg).Name = "txtTk_lai_cltg";
		txtTk_lai_cltg.NameControl = lblTen_Tk_lai_cltg;
		AsTextBox asTextBox2 = txtTk_lai_cltg;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTk_lai_cltg).TabIndex = 4;
		txtTk_lai_cltg.UseAutoCompleteSource = true;
		Label obj6 = lblTen_Tk_lai_cltg;
		location = new Point(301, 127);
		((Control)obj6).Location = location;
		((Control)lblTen_Tk_lai_cltg).Name = "lblTen_Tk_lai_cltg";
		Label obj7 = lblTen_Tk_lai_cltg;
		size = new Size(303, 14);
		((Control)obj7).Size = size;
		((Control)lblTen_Tk_lai_cltg).TabIndex = 123;
		txtTk_lo_cltg.AutoLookup = true;
		txtTk_lo_cltg.AutoValid = true;
		((TextBoxBase)txtTk_lo_cltg).BackColor = SystemColors.Info;
		((TextBox)txtTk_lo_cltg).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTk_lo_cltg;
		location = new Point(194, 150);
		((Control)asTextBox3).Location = location;
		txtTk_lo_cltg.LookupCodeName = "TK";
		txtTk_lo_cltg.LookupWhereCondition = "chi_tiet=1";
		((TextBoxBase)txtTk_lo_cltg).MaxLength = 20;
		((Control)txtTk_lo_cltg).Name = "txtTk_lo_cltg";
		txtTk_lo_cltg.NameControl = lblTen_Tk_lo_cltg;
		AsTextBox asTextBox4 = txtTk_lo_cltg;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTk_lo_cltg).TabIndex = 5;
		txtTk_lo_cltg.UseAutoCompleteSource = true;
		Label obj8 = lblTen_Tk_lo_cltg;
		location = new Point(301, 154);
		((Control)obj8).Location = location;
		((Control)lblTen_Tk_lo_cltg).Name = "lblTen_Tk_lo_cltg";
		Label obj9 = lblTen_Tk_lo_cltg;
		size = new Size(303, 14);
		((Control)obj9).Size = size;
		((Control)lblTen_Tk_lo_cltg).TabIndex = 124;
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(15, 126);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(158, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 111;
		Label3.Text = "TK  lãi chênh lệch tỷ giá cuối kỳ";
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(15, 152);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(156, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 112;
		Label4.Text = "TK  lỗ chênh lệch tỷ giá cuối kỳ";
		TextBox obj10 = txtSo_ct;
		location = new Point(194, 202);
		((Control)obj10).Location = location;
		((TextBoxBase)txtSo_ct).MaxLength = 12;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj11 = txtSo_ct;
		size = new Size(100, 20);
		((Control)obj11).Size = size;
		((Control)txtSo_ct).TabIndex = 7;
		Label6.AutoSize = true;
		Label label9 = Label6;
		location = new Point(15, 204);
		((Control)label9).Location = location;
		((Control)Label6).Name = "Label6";
		Label label10 = Label6;
		size = new Size(65, 13);
		((Control)label10).Size = size;
		((Control)Label6).TabIndex = 115;
		Label6.Text = "Số chứng từ";
		((ComboBox)cboLoai_dg).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboLoai_dg).FormattingEnabled = true;
		((ComboBox)cboLoai_dg).Items.AddRange(new object[2] { "1 - Dư nợ", "2 - Dư có" });
		AsComboBox asComboBox = cboLoai_dg;
		location = new Point(196, 97);
		((Control)asComboBox).Location = location;
		((Control)cboLoai_dg).Name = "cboLoai_dg";
		AsComboBox asComboBox2 = cboLoai_dg;
		size = new Size(98, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboLoai_dg).TabIndex = 3;
		Label7.AutoSize = true;
		Label label11 = Label7;
		location = new Point(15, 73);
		((Control)label11).Location = location;
		((Control)Label7).Name = "Label7";
		Label label12 = Label7;
		size = new Size(94, 13);
		((Control)label12).Size = size;
		((Control)Label7).TabIndex = 119;
		Label7.Text = "TK đánh giá tỷ giá";
		txtTk_dgtg.AutoLookup = true;
		txtTk_dgtg.AutoValid = true;
		((TextBoxBase)txtTk_dgtg).BackColor = SystemColors.Info;
		((TextBox)txtTk_dgtg).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTk_dgtg;
		location = new Point(194, 71);
		((Control)asTextBox5).Location = location;
		txtTk_dgtg.LookupCodeName = "TK";
		txtTk_dgtg.LookupWhereCondition = "chi_tiet=1";
		((TextBoxBase)txtTk_dgtg).MaxLength = 20;
		((Control)txtTk_dgtg).Name = "txtTk_dgtg";
		txtTk_dgtg.NameControl = lblTen_Tk_dgtg;
		AsTextBox asTextBox6 = txtTk_dgtg;
		size = new Size(100, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTk_dgtg).TabIndex = 2;
		txtTk_dgtg.UseAutoCompleteSource = true;
		txtTk_dgtg.ValidReturnFieldList = "ma_nt";
		Label obj12 = lblTen_Tk_dgtg;
		location = new Point(301, 75);
		((Control)obj12).Location = location;
		((Control)lblTen_Tk_dgtg).Name = "lblTen_Tk_dgtg";
		Label obj13 = lblTen_Tk_dgtg;
		size = new Size(303, 14);
		((Control)obj13).Size = size;
		((Control)lblTen_Tk_dgtg).TabIndex = 122;
		Label5.AutoSize = true;
		Label label13 = Label5;
		location = new Point(15, 178);
		((Control)label13).Location = location;
		((Control)Label5).Name = "Label5";
		Label label14 = Label5;
		size = new Size(170, 13);
		((Control)label14).Size = size;
		((Control)Label5).TabIndex = 121;
		Label5.Text = "TK ĐG chênh lệch tỷ giá cuối năm";
		txTk_cltg_cn.AutoLookup = true;
		txTk_cltg_cn.AutoValid = true;
		((TextBoxBase)txTk_cltg_cn).BackColor = SystemColors.Info;
		((TextBox)txTk_cltg_cn).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txTk_cltg_cn;
		location = new Point(194, 176);
		((Control)asTextBox7).Location = location;
		txTk_cltg_cn.LookupCodeName = "TK";
		txTk_cltg_cn.LookupWhereCondition = "chi_tiet=1";
		((TextBoxBase)txTk_cltg_cn).MaxLength = 20;
		((Control)txTk_cltg_cn).Name = "txTk_cltg_cn";
		txTk_cltg_cn.NameControl = lblTen_Tk_cltg_cn;
		AsTextBox asTextBox8 = txTk_cltg_cn;
		size = new Size(100, 20);
		((Control)asTextBox8).Size = size;
		((Control)txTk_cltg_cn).TabIndex = 6;
		txTk_cltg_cn.UseAutoCompleteSource = true;
		Label obj14 = lblTen_Tk_cltg_cn;
		location = new Point(301, 179);
		((Control)obj14).Location = location;
		((Control)lblTen_Tk_cltg_cn).Name = "lblTen_Tk_cltg_cn";
		Label obj15 = lblTen_Tk_cltg_cn;
		size = new Size(303, 14);
		((Control)obj15).Size = size;
		((Control)lblTen_Tk_cltg_cn).TabIndex = 125;
		txtSTT.DecimalSymbol = ".";
		txtSTT.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtSTT;
		location = new Point(194, 19);
		((Control)asTextNumeric).Location = location;
		txtSTT.Mask = "### ### ### ###";
		((Control)txtSTT).Name = "txtSTT";
		AsTextNumeric asTextNumeric2 = txtSTT;
		size = new Size(62, 20);
		((Control)asTextNumeric2).Size = size;
		txtSTT.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtSTT).TabIndex = 0;
		((TextBox)txtSTT).Text = "0";
		((TextBox)txtSTT).TextAlign = (HorizontalAlignment)1;
		txtSTT.Value = 0;
		Label8.AutoSize = true;
		Label label15 = Label8;
		location = new Point(15, 22);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(50, 13);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 127;
		Label8.Text = "Số thứ tự";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(647, 420);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGLDMDGTGEdit";
		((Form)this).Text = "frmGLDMDGTGEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		base.InitBeforeGetData();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		AsComboBox asComboBox = cboLoai_dg;
		dictionary.Add("1", Conversions.ToString(((ComboBox)asComboBox).Items[0]));
		dictionary.Add("2", Conversions.ToString(((ComboBox)asComboBox).Items[1]));
		BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
		((ComboBox)asComboBox).DataSource = dataSource;
		((ListControl)asComboBox).DisplayMember = "value";
		((ListControl)asComboBox).ValueMember = "key";
		asComboBox = null;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			IndexValue();
			((ComboBox)cboLoai_dg).SelectedIndex = 0;
		}
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtSTT).Enabled = false;
		((Control)cboLoai_dg).Enabled = false;
		((Control)txtTk_dgtg).Enabled = false;
		((Control)txtTen_bt).Select();
	}

	protected override void DataBinding()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtSTT;
		CreateDataBinding(ref ojb, "stt", "Value");
		txtSTT = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)cboLoai_dg;
		CreateDataBinding(ref ojb, "loai_dg", "SelectedValue");
		cboLoai_dg = (AsComboBox)(object)ojb;
		ojb = (Control)(object)txtTen_bt;
		CreateDataBinding(ref ojb, "ten_bt");
		txtTen_bt = (TextBox)ojb;
		ojb = (Control)(object)txtTk_dgtg;
		CreateDataBinding(ref ojb, "tk_dgtg");
		txtTk_dgtg = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk_lai_cltg;
		CreateDataBinding(ref ojb, "tk_lai_cltg");
		txtTk_lai_cltg = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk_lo_cltg;
		CreateDataBinding(ref ojb, "tk_lo_cltg");
		txtTk_lo_cltg = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txTk_cltg_cn;
		CreateDataBinding(ref ojb, "tk_cltg_cn");
		txTk_cltg_cn = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "so_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)chkdg_kh;
		CreateDataBinding(ref ojb, "dg_kh", "Checked");
		chkdg_kh = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkdg_bp;
		CreateDataBinding(ref ojb, "dg_bp", "Checked");
		chkdg_bp = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkdg_hd;
		CreateDataBinding(ref ojb, "dg_hd", "Checked");
		chkdg_hd = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkdg_spct;
		CreateDataBinding(ref ojb, "dg_spct", "Checked");
		chkdg_spct = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkdg_phi;
		CreateDataBinding(ref ojb, "dg_phi", "Checked");
		chkdg_phi = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox(txtTen_bt) || !ChkEmtyTextBox((TextBox)(object)txtTk_dgtg) || !ChkEmtyTextBox((TextBox)(object)txTk_cltg_cn) || !base.ValidData())
		{
			return false;
		}
		return true;
	}

	private void IndexValue()
	{
		RowToEdit["STT"] = iSttMax;
	}

	private void txtTk_dgtg_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (Operators.CompareString(((TextBox)txtTk_dgtg).Text.Trim(), "", false) != 0 && e.ValidatedRow != null)
		{
			RowToEdit["Tk_dgtg"] = ((TextBox)txtTk_dgtg).Text;
			RowToEdit["Ma_nt"] = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ma_nt"]);
		}
	}
}
