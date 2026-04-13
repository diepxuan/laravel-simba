using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmINCalGiaTB : frmCalc
{
	private IContainer components;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("lblTo")]
	private Label _lblTo;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("lblTen_Vt")]
	private Label _lblTen_Vt;

	[AccessedThroughProperty("lblTen_Kho")]
	private Label _lblTen_Kho;

	[AccessedThroughProperty("lblTen_tkvt")]
	private Label _lblTen_tkvt;

	[AccessedThroughProperty("txtNh_vt")]
	private AsTextBox _txtNh_vt;

	[AccessedThroughProperty("txtMa_tkvt")]
	private AsTextBox _txtMa_tkvt;

	[AccessedThroughProperty("lblNh_vt")]
	private Label _lblNh_vt;

	[AccessedThroughProperty("lblMa_tk")]
	private Label _lblMa_tk;

	[AccessedThroughProperty("cboKieu_ps")]
	private ComboBox _cboKieu_ps;

	[AccessedThroughProperty("lblKieu_pscl")]
	private Label _lblKieu_pscl;

	[AccessedThroughProperty("lblTen_tkcl")]
	private Label _lblTen_tkcl;

	[AccessedThroughProperty("txttk_cl")]
	private AsTextBox _txttk_cl;

	[AccessedThroughProperty("lblMa_tkcl")]
	private Label _lblMa_tkcl;

	[AccessedThroughProperty("bgWorker")]
	private BackgroundWorker _bgWorker;

	[AccessedThroughProperty("lblTen_Nhvt")]
	private Label _lblTen_Nhvt;

	[AccessedThroughProperty("cboKyBc")]
	private AsComboBox _cboKyBc;

	internal virtual AsTextBox txtMa_kho
	{
		get
		{
			return _txtMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_kho = value;
		}
	}

	internal virtual Label lblMa_kho
	{
		get
		{
			return _lblMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_kho = value;
		}
	}

	internal virtual Label lblTo
	{
		get
		{
			return _lblTo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTo = value;
		}
	}

	internal virtual AsTextBox txtMa_vt
	{
		get
		{
			return _txtMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_vt = value;
		}
	}

	internal virtual Label lblMa_vt
	{
		get
		{
			return _lblMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_vt = value;
		}
	}

	internal virtual Label lblTen_Vt
	{
		get
		{
			return _lblTen_Vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Vt = value;
		}
	}

	internal virtual Label lblTen_Kho
	{
		get
		{
			return _lblTen_Kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Kho = value;
		}
	}

	internal virtual Label lblTen_tkvt
	{
		get
		{
			return _lblTen_tkvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_tkvt = value;
		}
	}

	internal virtual AsTextBox txtNh_vt
	{
		get
		{
			return _txtNh_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNh_vt = value;
		}
	}

	internal virtual AsTextBox txtMa_tkvt
	{
		get
		{
			return _txtMa_tkvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_tkvt = value;
		}
	}

	internal virtual Label lblNh_vt
	{
		get
		{
			return _lblNh_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNh_vt = value;
		}
	}

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

	internal virtual ComboBox cboKieu_ps
	{
		get
		{
			return _cboKieu_ps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboKieu_ps = value;
		}
	}

	internal virtual Label lblKieu_pscl
	{
		get
		{
			return _lblKieu_pscl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblKieu_pscl = value;
		}
	}

	internal virtual Label lblTen_tkcl
	{
		get
		{
			return _lblTen_tkcl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_tkcl = value;
		}
	}

	internal virtual AsTextBox txttk_cl
	{
		get
		{
			return _txttk_cl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txttk_cl = value;
		}
	}

	internal virtual Label lblMa_tkcl
	{
		get
		{
			return _lblMa_tkcl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_tkcl = value;
		}
	}

	internal virtual BackgroundWorker bgWorker
	{
		get
		{
			return _bgWorker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_bgWorker = value;
		}
	}

	internal virtual Label lblTen_Nhvt
	{
		get
		{
			return _lblTen_Nhvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Nhvt = value;
		}
	}

	internal virtual AsComboBox cboKyBc
	{
		get
		{
			return _cboKyBc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboKyBc = value;
		}
	}

	public frmINCalGiaTB(string MenuID)
		: base(MenuID)
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
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
		lblTo = new Label();
		lblMa_kho = new Label();
		txtMa_kho = new AsTextBox();
		lblTen_Kho = new Label();
		lblMa_vt = new Label();
		txtMa_vt = new AsTextBox();
		lblTen_Vt = new Label();
		lblMa_tk = new Label();
		txtMa_tkvt = new AsTextBox();
		lblTen_tkvt = new Label();
		lblNh_vt = new Label();
		txtNh_vt = new AsTextBox();
		lblTen_Nhvt = new Label();
		lblKieu_pscl = new Label();
		cboKieu_ps = new ComboBox();
		lblMa_tkcl = new Label();
		txttk_cl = new AsTextBox();
		lblTen_tkcl = new Label();
		bgWorker = new BackgroundWorker();
		cboKyBc = new AsComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 220);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		((Control)gbInput).Controls.Add((Control)(object)cboKyBc);
		((Control)gbInput).Controls.Add((Control)(object)cboKieu_ps);
		((Control)gbInput).Controls.Add((Control)(object)lblKieu_pscl);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_Nhvt);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_tkcl);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_tkvt);
		((Control)gbInput).Controls.Add((Control)(object)txtNh_vt);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_Vt);
		((Control)gbInput).Controls.Add((Control)(object)txttk_cl);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_tkvt);
		((Control)gbInput).Controls.Add((Control)(object)lblNh_vt);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_tkcl);
		((Control)gbInput).Controls.Add((Control)(object)lblTen_Kho);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_tk);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_vt);
		((Control)gbInput).Controls.Add((Control)(object)txtMa_kho);
		((Control)gbInput).Controls.Add((Control)(object)lblMa_kho);
		((Control)gbInput).Controls.Add((Control)(object)lblTo);
		GroupBox obj2 = gbInput;
		Size size = new Size(510, 205);
		((Control)obj2).Size = size;
		((Control)gbInput).TabIndex = 0;
		Button obj3 = cmdOK;
		location = new Point(12, 220);
		((Control)obj3).Location = location;
		((Control)cmdOK).TabIndex = 1;
		lblTo.AutoSize = true;
		Label obj4 = lblTo;
		location = new Point(17, 21);
		((Control)obj4).Location = location;
		((Control)lblTo).Name = "lblTo";
		Label obj5 = lblTo;
		size = new Size(41, 13);
		((Control)obj5).Size = size;
		((Control)lblTo).TabIndex = 0;
		lblTo.Text = "Kỳ tính";
		lblMa_kho.AutoSize = true;
		Label obj6 = lblMa_kho;
		location = new Point(17, 47);
		((Control)obj6).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj7 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj7).Size = size;
		((Control)lblMa_kho).TabIndex = 2;
		lblMa_kho.Text = "Mã kho";
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = false;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_kho;
		location = new Point(141, 43);
		((Control)asTextBox).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_Kho;
		AsTextBox asTextBox2 = txtMa_kho;
		size = new Size(136, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_kho).TabIndex = 2;
		((Control)txtMa_kho).Tag = "MA_KHO";
		txtMa_kho.UseAutoCompleteSource = true;
		Label obj8 = lblTen_Kho;
		location = new Point(283, 44);
		((Control)obj8).Location = location;
		((Control)lblTen_Kho).Name = "lblTen_Kho";
		Label obj9 = lblTen_Kho;
		size = new Size(207, 18);
		((Control)obj9).Size = size;
		((Control)lblTen_Kho).TabIndex = 4;
		lblMa_vt.AutoSize = true;
		Label obj10 = lblMa_vt;
		location = new Point(17, 99);
		((Control)obj10).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj11 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_vt).TabIndex = 2;
		lblMa_vt.Text = "Mã vật tư";
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = false;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_vt;
		location = new Point(141, 95);
		((Control)asTextBox3).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_Vt;
		AsTextBox asTextBox4 = txtMa_vt;
		size = new Size(136, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_vt).TabIndex = 4;
		((Control)txtMa_vt).Tag = "MA_VT";
		txtMa_vt.UseAutoCompleteSource = true;
		Label obj12 = lblTen_Vt;
		location = new Point(283, 96);
		((Control)obj12).Location = location;
		((Control)lblTen_Vt).Name = "lblTen_Vt";
		Label obj13 = lblTen_Vt;
		size = new Size(207, 18);
		((Control)obj13).Size = size;
		((Control)lblTen_Vt).TabIndex = 4;
		lblMa_tk.AutoSize = true;
		Label obj14 = lblMa_tk;
		location = new Point(17, 125);
		((Control)obj14).Location = location;
		((Control)lblMa_tk).Name = "lblMa_tk";
		Label obj15 = lblMa_tk;
		size = new Size(85, 13);
		((Control)obj15).Size = size;
		((Control)lblMa_tk).TabIndex = 2;
		lblMa_tk.Text = "Tài khoản vật tư";
		txtMa_tkvt.AutoLookup = true;
		txtMa_tkvt.AutoValid = false;
		((TextBoxBase)txtMa_tkvt).BackColor = SystemColors.Info;
		((TextBox)txtMa_tkvt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_tkvt;
		location = new Point(141, 121);
		((Control)asTextBox5).Location = location;
		txtMa_tkvt.LookupCodeName = "TK";
		((Control)txtMa_tkvt).Name = "txtMa_tkvt";
		txtMa_tkvt.NameControl = lblTen_tkvt;
		AsTextBox asTextBox6 = txtMa_tkvt;
		size = new Size(136, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_tkvt).TabIndex = 5;
		((Control)txtMa_tkvt).Tag = "TK";
		txtMa_tkvt.UseAutoCompleteSource = true;
		Label obj16 = lblTen_tkvt;
		location = new Point(283, 122);
		((Control)obj16).Location = location;
		((Control)lblTen_tkvt).Name = "lblTen_tkvt";
		Label obj17 = lblTen_tkvt;
		size = new Size(207, 18);
		((Control)obj17).Size = size;
		((Control)lblTen_tkvt).TabIndex = 4;
		lblNh_vt.AutoSize = true;
		Label obj18 = lblNh_vt;
		location = new Point(17, 73);
		((Control)obj18).Location = location;
		((Control)lblNh_vt).Name = "lblNh_vt";
		Label obj19 = lblNh_vt;
		size = new Size(65, 13);
		((Control)obj19).Size = size;
		((Control)lblNh_vt).TabIndex = 2;
		lblNh_vt.Text = "Nhóm vật tư";
		txtNh_vt.AutoLookup = true;
		txtNh_vt.AutoValid = false;
		((TextBoxBase)txtNh_vt).BackColor = SystemColors.Info;
		((TextBox)txtNh_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtNh_vt;
		location = new Point(141, 69);
		((Control)asTextBox7).Location = location;
		txtNh_vt.LookupCodeName = "MA_NHVT";
		((Control)txtNh_vt).Name = "txtNh_vt";
		txtNh_vt.NameControl = lblTen_Nhvt;
		AsTextBox asTextBox8 = txtNh_vt;
		size = new Size(136, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtNh_vt).TabIndex = 3;
		((Control)txtNh_vt).Tag = "MA_NHVT";
		txtNh_vt.UseAutoCompleteSource = true;
		Label obj20 = lblTen_Nhvt;
		location = new Point(283, 70);
		((Control)obj20).Location = location;
		((Control)lblTen_Nhvt).Name = "lblTen_Nhvt";
		Label obj21 = lblTen_Nhvt;
		size = new Size(207, 18);
		((Control)obj21).Size = size;
		((Control)lblTen_Nhvt).TabIndex = 4;
		lblKieu_pscl.AutoSize = true;
		Label obj22 = lblKieu_pscl;
		location = new Point(17, 151);
		((Control)obj22).Location = location;
		((Control)lblKieu_pscl).Name = "lblKieu_pscl";
		Label obj23 = lblKieu_pscl;
		size = new Size(119, 13);
		((Control)obj23).Size = size;
		((Control)lblKieu_pscl).TabIndex = 5;
		lblKieu_pscl.Text = "Kiểu tạo PS chênh lệch";
		cboKieu_ps.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKieu_ps).FormattingEnabled = true;
		cboKieu_ps.Items.AddRange(new object[3] { "0 - Không tạo", "1 - Tạo cho các trường hợp số lượng = 0,số tiền #0", "2 - Tạo cho các trường hợp có phát sinh chênh lệch " });
		ComboBox obj24 = cboKieu_ps;
		location = new Point(141, 147);
		((Control)obj24).Location = location;
		((Control)cboKieu_ps).Name = "cboKieu_ps";
		ComboBox obj25 = cboKieu_ps;
		size = new Size(313, 21);
		((Control)obj25).Size = size;
		((Control)cboKieu_ps).TabIndex = 6;
		lblMa_tkcl.AutoSize = true;
		Label obj26 = lblMa_tkcl;
		location = new Point(17, 178);
		((Control)obj26).Location = location;
		((Control)lblMa_tkcl).Name = "lblMa_tkcl";
		Label obj27 = lblMa_tkcl;
		size = new Size(111, 13);
		((Control)obj27).Size = size;
		((Control)lblMa_tkcl).TabIndex = 2;
		lblMa_tkcl.Text = "Tài khoản chênh lệch";
		txttk_cl.AutoLookup = true;
		txttk_cl.AutoValid = true;
		((TextBoxBase)txttk_cl).BackColor = SystemColors.Info;
		((TextBox)txttk_cl).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txttk_cl;
		location = new Point(141, 174);
		((Control)asTextBox9).Location = location;
		txttk_cl.LookupCodeName = "TK";
		txttk_cl.LookupWhereCondition = "chi_tiet ='1'";
		((Control)txttk_cl).Name = "txttk_cl";
		txttk_cl.NameControl = lblTen_tkcl;
		AsTextBox asTextBox10 = txttk_cl;
		size = new Size(64, 20);
		((Control)asTextBox10).Size = size;
		((Control)txttk_cl).TabIndex = 7;
		((Control)txttk_cl).Tag = "TK";
		((TextBox)txttk_cl).Text = "632";
		txttk_cl.UseAutoCompleteSource = true;
		Label obj28 = lblTen_tkcl;
		location = new Point(211, 177);
		((Control)obj28).Location = location;
		((Control)lblTen_tkcl).Name = "lblTen_tkcl";
		Label obj29 = lblTen_tkcl;
		size = new Size(279, 15);
		((Control)obj29).Size = size;
		((Control)lblTen_tkcl).TabIndex = 4;
		((ComboBox)cboKyBc).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyBc).FormattingEnabled = true;
		AsComboBox asComboBox = cboKyBc;
		location = new Point(141, 17);
		((Control)asComboBox).Location = location;
		((Control)cboKyBc).Name = "cboKyBc";
		AsComboBox asComboBox2 = cboKyBc;
		size = new Size(106, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(532, 252);
		((Form)this).ClientSize = size;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmINCalGiaTB";
		((Form)this).Text = "Tính giá trung bình tháng";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ValidData()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ngay2, AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks) <= 0)
		{
			CMessageBox.Show(50136);
			return false;
		}
		if (Conversion.Val(cboKieu_ps.Text[0]) != 0 && Operators.CompareString(((TextBox)txttk_cl).Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txttk_cl, Helper.GetMessContent(50002));
			return false;
		}
		DataRow pDrw = null;
		if (!Commons.ValidMa(ref pDrw, "tk", ((TextBox)txttk_cl).Text, "chi_tiet = '1'", "tk,ten_tk"))
		{
			epNotice.SetError((Control)(object)txttk_cl, Helper.GetMess(50160).Description);
			((Control)txttk_cl).Select();
			return false;
		}
		return true;
	}

	protected override bool Execute()
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		((Control)cmdCancel).Enabled = false;
		((Control)cmdOK).Enabled = false;
		bool result = false;
		try
		{
			((Control)this).Cursor = Cursors.WaitCursor;
			ArrayList arrayList = new ArrayList();
			KyBaoCao kyBaoCao = (KyBaoCao)((ComboBox)cboKyBc).SelectedItem;
			arrayList.Add(CompanyInformations.CompanyID);
			arrayList.Add(kyBaoCao.ngay1);
			arrayList.Add(kyBaoCao.ngay2);
			arrayList.Add(((TextBox)txtMa_vt).Text);
			arrayList.Add(((TextBox)txtMa_tkvt).Text);
			arrayList.Add(((TextBox)txtNh_vt).Text);
			arrayList.Add(((TextBox)txtMa_kho).Text);
			arrayList.Add(((TextBox)txttk_cl).Text);
			arrayList.Add(cboKieu_ps.Text.ToString().Substring(0, 1));
			switch (AsiaErp.Framework.Environment.GetCalcInformation(MyMenuID).rettype)
			{
			case Commons.QueryReturnType.NONE_QUERY:
				result = Conversions.ToBoolean(base.MyController.Execute(arrayList.ToArray()));
				break;
			case Commons.QueryReturnType.DATATABLE:
				ResultSource = (DataTable)base.MyController.Execute(arrayList.ToArray());
				break;
			}
			((Control)this).Cursor = Cursors.Default;
			CMessageBox.Show(50015);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			result = false;
			((Control)this).Cursor = Cursors.Default;
			CMessageBox.Show(50010);
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
		return result;
	}

	protected override void InitComponents()
	{
		base.InitComponents();
		cboKieu_ps.SelectedIndex = 1;
		InitKyBaoCao();
		((ComboBox)cboKyBc).Text = Conversions.ToString(AsiaErp.Framework.Environment.get_PublicVariables("thang1"));
		if (((ListControl)cboKyBc).SelectedValue == null)
		{
			((ComboBox)cboKyBc).SelectedIndex = 1;
		}
		((Control)cboKyBc).Select();
		((TextBox)txttk_cl).Text = AsiaErp.Framework.Environment.GetINConfiguration().tk_gv;
	}

	private void InitKyBaoCao()
	{
		((ComboBox)cboKyBc).DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc, "11110");
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
	}
}
