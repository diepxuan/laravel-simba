using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmARCDKHFilter : frmOBFilter
{
	private IContainer components;

	[AccessedThroughProperty("lblMa_tk")]
	private Label _lblMa_tk;

	[AccessedThroughProperty("txtMa_tk")]
	private AsTextBox _txtMa_tk;

	[AccessedThroughProperty("lblMa_kh")]
	private Label _lblMa_kh;

	[AccessedThroughProperty("lblMa_hd")]
	private Label _lblMa_hd;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("txtMa_kh")]
	private AsTextBox _txtMa_kh;

	[AccessedThroughProperty("txtMa_hd")]
	private AsTextBox _txtMa_hd;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("txtYear")]
	private TextBox _txtYear;

	[AccessedThroughProperty("lblYear")]
	private Label _lblYear;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("lblTen_kh")]
	private Label _lblTen_kh;

	[AccessedThroughProperty("lblTen_hd")]
	private Label _lblTen_hd;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("cboCategory")]
	private ComboBox _cboCategory;

	[AccessedThroughProperty("lblCategory")]
	private Label _lblCategory;

	internal virtual Label lblMa_tk
	{
		get
		{
			return _lblMa_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_tk = value;
		}
	}

	internal virtual AsTextBox txtMa_tk
	{
		get
		{
			return _txtMa_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_tk = value;
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

	internal virtual TextBox txtYear
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

	internal virtual ComboBox cboCategory
	{
		get
		{
			return _cboCategory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboCategory = value;
		}
	}

	internal virtual Label lblCategory
	{
		get
		{
			return _lblCategory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblCategory = value;
		}
	}

	public frmARCDKHFilter()
	{
		((Form)this).Load += frmARCDKHFilter_Load;
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		lblMa_tk = new Label();
		txtMa_tk = new AsTextBox();
		lblTen_tk = new Label();
		txtMa_kh = new AsTextBox();
		lblTen_kh = new Label();
		lblMa_kh = new Label();
		txtMa_hd = new AsTextBox();
		lblTen_hd = new Label();
		lblMa_hd = new Label();
		txtMa_bp = new AsTextBox();
		lblTen_bp = new Label();
		lblMa_bp = new Label();
		txtMa_spct = new AsTextBox();
		lblTen_spct = new Label();
		lblMa_spct = new Label();
		lblYear = new Label();
		txtYear = new TextBox();
		cboCategory = new ComboBox();
		lblCategory = new Label();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		Point location = new Point(93, 211);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdOk;
		location = new Point(12, 211);
		((Control)obj2).Location = location;
		((Control)cmdOk).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)cboCategory);
		((Control)gbLine).Controls.Add((Control)(object)lblCategory);
		((Control)gbLine).Controls.Add((Control)(object)txtYear);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk);
		((Control)gbLine).Controls.Add((Control)(object)lblYear);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_kh);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_tk);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_hd);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_bp);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_kh);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_spct);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_hd);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_bp);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_tk);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_spct);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_spct);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_kh);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_hd);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_bp);
		GroupBox obj3 = gbLine;
		Size size = new Size(485, 201);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_hd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtYear, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblCategory, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboCategory, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		lblMa_tk.AutoSize = true;
		Label obj4 = lblMa_tk;
		location = new Point(19, 45);
		((Control)obj4).Location = location;
		((Control)lblMa_tk).Name = "lblMa_tk";
		Label obj5 = lblMa_tk;
		size = new Size(69, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_tk).TabIndex = 100;
		lblMa_tk.Text = "Mã tài khoản";
		txtMa_tk.AutoLookup = true;
		txtMa_tk.AutoValid = false;
		((TextBoxBase)txtMa_tk).BackColor = SystemColors.Info;
		((TextBox)txtMa_tk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_tk;
		location = new Point(106, 41);
		((Control)asTextBox).Location = location;
		txtMa_tk.LookupCodeName = "TK";
		txtMa_tk.LookupWhereCondition = "chi_tiet=1 and tk_cn=1";
		((Control)txtMa_tk).Name = "txtMa_tk";
		txtMa_tk.NameControl = lblTen_tk;
		AsTextBox asTextBox2 = txtMa_tk;
		size = new Size(111, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_tk).TabIndex = 0;
		((Control)txtMa_tk).Tag = "TK";
		txtMa_tk.UseAutoCompleteSource = true;
		Label obj6 = lblTen_tk;
		location = new Point(223, 41);
		((Control)obj6).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj7 = lblTen_tk;
		size = new Size(245, 17);
		((Control)obj7).Size = size;
		((Control)lblTen_tk).TabIndex = 104;
		txtMa_kh.AutoLookup = true;
		txtMa_kh.AutoValid = false;
		((TextBoxBase)txtMa_kh).BackColor = SystemColors.Info;
		((TextBox)txtMa_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_kh;
		location = new Point(106, 67);
		((Control)asTextBox3).Location = location;
		txtMa_kh.LookupCodeName = "MA_KH";
		((Control)txtMa_kh).Name = "txtMa_kh";
		txtMa_kh.NameControl = lblTen_kh;
		AsTextBox asTextBox4 = txtMa_kh;
		size = new Size(111, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_kh).TabIndex = 1;
		txtMa_kh.UseAutoCompleteSource = true;
		Label obj8 = lblTen_kh;
		location = new Point(223, 67);
		((Control)obj8).Location = location;
		((Control)lblTen_kh).Name = "lblTen_kh";
		Label obj9 = lblTen_kh;
		size = new Size(245, 17);
		((Control)obj9).Size = size;
		((Control)lblTen_kh).TabIndex = 104;
		lblMa_kh.AutoSize = true;
		Label obj10 = lblMa_kh;
		location = new Point(19, 71);
		((Control)obj10).Location = location;
		((Control)lblMa_kh).Name = "lblMa_kh";
		Label obj11 = lblMa_kh;
		size = new Size(82, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_kh).TabIndex = 100;
		lblMa_kh.Text = "Mã khách hàng";
		txtMa_hd.AutoLookup = true;
		txtMa_hd.AutoValid = false;
		((TextBoxBase)txtMa_hd).BackColor = SystemColors.Info;
		((TextBox)txtMa_hd).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_hd;
		location = new Point(106, 93);
		((Control)asTextBox5).Location = location;
		txtMa_hd.LookupCodeName = "MA_HD";
		((Control)txtMa_hd).Name = "txtMa_hd";
		txtMa_hd.NameControl = lblTen_hd;
		AsTextBox asTextBox6 = txtMa_hd;
		size = new Size(111, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_hd).TabIndex = 2;
		txtMa_hd.UseAutoCompleteSource = true;
		Label obj12 = lblTen_hd;
		location = new Point(223, 93);
		((Control)obj12).Location = location;
		((Control)lblTen_hd).Name = "lblTen_hd";
		Label obj13 = lblTen_hd;
		size = new Size(245, 17);
		((Control)obj13).Size = size;
		((Control)lblTen_hd).TabIndex = 104;
		lblMa_hd.AutoSize = true;
		Label obj14 = lblMa_hd;
		location = new Point(19, 97);
		((Control)obj14).Location = location;
		((Control)lblMa_hd).Name = "lblMa_hd";
		Label obj15 = lblMa_hd;
		size = new Size(71, 13);
		((Control)obj15).Size = size;
		((Control)lblMa_hd).TabIndex = 100;
		lblMa_hd.Text = "Mã hợp đồng";
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_bp;
		location = new Point(106, 119);
		((Control)asTextBox7).Location = location;
		txtMa_bp.LookupCodeName = "MA_BP";
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox8 = txtMa_bp;
		size = new Size(111, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_bp).TabIndex = 3;
		txtMa_bp.UseAutoCompleteSource = true;
		Label obj16 = lblTen_bp;
		location = new Point(223, 119);
		((Control)obj16).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj17 = lblTen_bp;
		size = new Size(245, 17);
		((Control)obj17).Size = size;
		((Control)lblTen_bp).TabIndex = 104;
		lblMa_bp.AutoSize = true;
		Label obj18 = lblMa_bp;
		location = new Point(19, 123);
		((Control)obj18).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj19 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_bp).TabIndex = 100;
		lblMa_bp.Text = "Mã bộ phận";
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_spct;
		location = new Point(106, 145);
		((Control)asTextBox9).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox10 = txtMa_spct;
		size = new Size(111, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_spct).TabIndex = 4;
		txtMa_spct.UseAutoCompleteSource = true;
		Label obj20 = lblTen_spct;
		location = new Point(223, 145);
		((Control)obj20).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj21 = lblTen_spct;
		size = new Size(245, 17);
		((Control)obj21).Size = size;
		((Control)lblTen_spct).TabIndex = 104;
		lblMa_spct.AutoSize = true;
		Label obj22 = lblMa_spct;
		location = new Point(19, 149);
		((Control)obj22).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj23 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj23).Size = size;
		((Control)lblMa_spct).TabIndex = 100;
		lblMa_spct.Text = "Mã SPCT";
		lblYear.AutoSize = true;
		Label obj24 = lblYear;
		location = new Point(19, 18);
		((Control)obj24).Location = location;
		((Control)lblYear).Name = "lblYear";
		Label obj25 = lblYear;
		size = new Size(29, 13);
		((Control)obj25).Size = size;
		((Control)lblYear).TabIndex = 102;
		lblYear.Text = "Năm";
		TextBox obj26 = txtYear;
		location = new Point(106, 15);
		((Control)obj26).Location = location;
		((Control)txtYear).Name = "txtYear";
		((TextBoxBase)txtYear).ReadOnly = true;
		TextBox obj27 = txtYear;
		size = new Size(111, 20);
		((Control)obj27).Size = size;
		((Control)txtYear).TabIndex = 5;
		((Control)txtYear).TabStop = false;
		cboCategory.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboCategory).FormattingEnabled = true;
		cboCategory.Items.AddRange(new object[4] { "0 - Tất cả", "1 - Khách hàng", "2 - Nhà cung cấp", "3 - Nhân viên" });
		ComboBox obj28 = cboCategory;
		location = new Point(106, 171);
		((Control)obj28).Location = location;
		((Control)cboCategory).Name = "cboCategory";
		ComboBox obj29 = cboCategory;
		size = new Size(185, 21);
		((Control)obj29).Size = size;
		((Control)cboCategory).TabIndex = 5;
		lblCategory.AutoSize = true;
		Label obj30 = lblCategory;
		location = new Point(19, 175);
		((Control)obj30).Location = location;
		((Control)lblCategory).Name = "lblCategory";
		Label obj31 = lblCategory;
		size = new Size(27, 13);
		((Control)obj31).Size = size;
		((Control)lblCategory).TabIndex = 106;
		lblCategory.Text = "Loại";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(509, 246);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmARCDKHFilter";
		((Form)this).Text = "Số dư đầu kỳ công nợ";
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ValidData()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc, AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks) <= 0)
		{
			CMessageBox.Show(50136);
			return false;
		}
		return base.ValidData();
	}

	private void frmARCDKHFilter_Load(object sender, EventArgs e)
	{
		cboCategory.SelectedIndex = 0;
	}
}
