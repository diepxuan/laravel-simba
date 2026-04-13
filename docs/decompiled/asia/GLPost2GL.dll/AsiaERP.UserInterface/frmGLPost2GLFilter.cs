using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaERP.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmGLPost2GLFilter : frmDMFilter
{
	private IContainer components;

	[AccessedThroughProperty("txtSo_ct1")]
	private TextBox _txtSo_ct1;

	[AccessedThroughProperty("txtSo_ct2")]
	private TextBox _txtSo_ct2;

	[AccessedThroughProperty("lblFrom")]
	private Label _lblFrom;

	[AccessedThroughProperty("lblTo")]
	private Label _lblTo;

	[AccessedThroughProperty("cboMa_ct")]
	private AsComboBox _cboMa_ct;

	[AccessedThroughProperty("cboStatus")]
	private AsComboBox _cboStatus;

	[AccessedThroughProperty("lblStatus")]
	private Label _lblStatus;

	[AccessedThroughProperty("lblMa_ct")]
	private Label _lblMa_ct;

	[AccessedThroughProperty("bgWorker")]
	private BackgroundWorker _bgWorker;

	[AccessedThroughProperty("lbl2")]
	private Label _lbl2;

	[AccessedThroughProperty("cboKyBc")]
	private ComboBox _cboKyBc;

	[AccessedThroughProperty("lblKyBc")]
	private Label _lblKyBc;

	[AccessedThroughProperty("txtNgay2")]
	private AsMaskedTextBox _txtNgay2;

	[AccessedThroughProperty("txtNgay1")]
	private AsMaskedTextBox _txtNgay1;

	internal string f_strMa_ph;

	internal string f_strMa_ct;

	internal string f_strNhan_in;

	internal List<VoucherInfoDatasource> f_voucherList;

	internal virtual TextBox txtSo_ct1
	{
		get
		{
			return _txtSo_ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_ct1 = value;
		}
	}

	internal virtual TextBox txtSo_ct2
	{
		get
		{
			return _txtSo_ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSo_ct2 = value;
		}
	}

	internal virtual Label lblFrom
	{
		get
		{
			return _lblFrom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblFrom = value;
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

	internal virtual AsComboBox cboMa_ct
	{
		get
		{
			return _cboMa_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboMa_ct = value;
		}
	}

	internal virtual AsComboBox cboStatus
	{
		get
		{
			return _cboStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboStatus = value;
		}
	}

	internal virtual Label lblStatus
	{
		get
		{
			return _lblStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblStatus = value;
		}
	}

	internal virtual Label lblMa_ct
	{
		get
		{
			return _lblMa_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_ct = value;
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

	protected virtual Label lbl2
	{
		get
		{
			return _lbl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lbl2 = value;
		}
	}

	protected virtual ComboBox cboKyBc
	{
		get
		{
			return _cboKyBc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboKyBc_SelectedValueChanged;
			if (_cboKyBc != null)
			{
				((ListControl)_cboKyBc).SelectedValueChanged -= eventHandler;
			}
			_cboKyBc = value;
			if (_cboKyBc != null)
			{
				((ListControl)_cboKyBc).SelectedValueChanged += eventHandler;
			}
		}
	}

	protected virtual Label lblKyBc
	{
		get
		{
			return _lblKyBc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblKyBc = value;
		}
	}

	protected internal virtual AsMaskedTextBox txtNgay2
	{
		get
		{
			return _txtNgay2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNgay2 = value;
		}
	}

	protected internal virtual AsMaskedTextBox txtNgay1
	{
		get
		{
			return _txtNgay1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtNgay1 = value;
		}
	}

	public frmGLPost2GLFilter()
	{
		((Form)this).Load += frmGLPost2GLFilter_Load;
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		lblFrom = new Label();
		txtSo_ct1 = new TextBox();
		lblTo = new Label();
		txtSo_ct2 = new TextBox();
		cboMa_ct = new AsComboBox();
		lblMa_ct = new Label();
		lblStatus = new Label();
		cboStatus = new AsComboBox();
		bgWorker = new BackgroundWorker();
		lbl2 = new Label();
		txtNgay2 = new AsMaskedTextBox();
		txtNgay1 = new AsMaskedTextBox();
		cboKyBc = new ComboBox();
		lblKyBc = new Label();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		Point location = new Point(93, 144);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdOk;
		location = new Point(12, 144);
		((Control)obj2).Location = location;
		((Control)cmdOk).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lbl2);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay2);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay1);
		((Control)gbLine).Controls.Add((Control)(object)cboKyBc);
		((Control)gbLine).Controls.Add((Control)(object)lblKyBc);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct1);
		((Control)gbLine).Controls.Add((Control)(object)cboMa_ct);
		((Control)gbLine).Controls.Add((Control)(object)cboStatus);
		((Control)gbLine).Controls.Add((Control)(object)lblFrom);
		((Control)gbLine).Controls.Add((Control)(object)lblStatus);
		((Control)gbLine).Controls.Add((Control)(object)lblTo);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct2);
		GroupBox obj3 = gbLine;
		Size size = new Size(432, 134);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblStatus, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblFrom, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboStatus, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboMa_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lbl2, 0);
		lblFrom.AutoSize = true;
		Label obj4 = lblFrom;
		location = new Point(16, 50);
		((Control)obj4).Location = location;
		((Control)lblFrom).Name = "lblFrom";
		Label obj5 = lblFrom;
		size = new Size(49, 13);
		((Control)obj5).Size = size;
		((Control)lblFrom).TabIndex = 101;
		lblFrom.Text = "Ctừ từ số";
		TextBox obj6 = txtSo_ct1;
		location = new Point(102, 46);
		((Control)obj6).Location = location;
		((Control)txtSo_ct1).Name = "txtSo_ct1";
		TextBox obj7 = txtSo_ct1;
		size = new Size(80, 20);
		((Control)obj7).Size = size;
		((Control)txtSo_ct1).TabIndex = 3;
		lblTo.AutoSize = true;
		Label obj8 = lblTo;
		location = new Point(185, 50);
		((Control)obj8).Location = location;
		((Control)lblTo).Name = "lblTo";
		Label obj9 = lblTo;
		size = new Size(40, 13);
		((Control)obj9).Size = size;
		((Control)lblTo).TabIndex = 101;
		lblTo.Text = "đến số";
		TextBox obj10 = txtSo_ct2;
		location = new Point(229, 46);
		((Control)obj10).Location = location;
		((TextBoxBase)txtSo_ct2).MaxLength = 12;
		((Control)txtSo_ct2).Name = "txtSo_ct2";
		TextBox obj11 = txtSo_ct2;
		size = new Size(68, 20);
		((Control)obj11).Size = size;
		((Control)txtSo_ct2).TabIndex = 4;
		txtSo_ct2.Text = "zzzzzzzzzzzz";
		((ComboBox)cboMa_ct).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMa_ct).FormattingEnabled = true;
		((ComboBox)cboMa_ct).Items.AddRange(new object[1] { "Tất cả các chứng từ" });
		AsComboBox asComboBox = cboMa_ct;
		location = new Point(102, 72);
		((Control)asComboBox).Location = location;
		((Control)cboMa_ct).Name = "cboMa_ct";
		AsComboBox asComboBox2 = cboMa_ct;
		size = new Size(196, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboMa_ct).TabIndex = 5;
		lblMa_ct.AutoSize = true;
		Label obj12 = lblMa_ct;
		location = new Point(16, 76);
		((Control)obj12).Location = location;
		((Control)lblMa_ct).Name = "lblMa_ct";
		Label obj13 = lblMa_ct;
		size = new Size(67, 13);
		((Control)obj13).Size = size;
		((Control)lblMa_ct).TabIndex = 101;
		lblMa_ct.Text = "Mã chứng từ";
		lblStatus.AutoSize = true;
		Label obj14 = lblStatus;
		location = new Point(16, 103);
		((Control)obj14).Location = location;
		((Control)lblStatus).Name = "lblStatus";
		Label obj15 = lblStatus;
		size = new Size(55, 13);
		((Control)obj15).Size = size;
		((Control)lblStatus).TabIndex = 101;
		lblStatus.Text = "Trạng thái";
		((ComboBox)cboStatus).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboStatus).FormattingEnabled = true;
		((ComboBox)cboStatus).Items.AddRange(new object[2] { "Chưa chuyển vào sổ cái", "Đã chuyển vào sổ cái" });
		AsComboBox asComboBox3 = cboStatus;
		location = new Point(102, 99);
		((Control)asComboBox3).Location = location;
		((Control)cboStatus).Name = "cboStatus";
		AsComboBox asComboBox4 = cboStatus;
		size = new Size(196, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboStatus).TabIndex = 6;
		lbl2.AutoSize = true;
		Label obj16 = lbl2;
		location = new Point(300, 23);
		((Control)obj16).Location = location;
		((Control)lbl2).Name = "lbl2";
		Label obj17 = lbl2;
		size = new Size(10, 13);
		((Control)obj17).Size = size;
		((Control)lbl2).TabIndex = 1020;
		lbl2.Text = "-";
		txtNgay2.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay2).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(314, 19);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay2).Mask = "##/##/####";
		((Control)txtNgay2).Name = "txtNgay2";
		((MaskedTextBox)txtNgay2).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay2;
		size = new Size(67, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay2).TabIndex = 2;
		((MaskedTextBox)txtNgay2).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay2;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtNgay1.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay1).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay1;
		location = new Point(230, 19);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay1).Mask = "##/##/####";
		((Control)txtNgay1).Name = "txtNgay1";
		((MaskedTextBox)txtNgay1).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay1;
		size = new Size(67, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay1).TabIndex = 1;
		((MaskedTextBox)txtNgay1).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay1;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		cboKyBc.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyBc).FormattingEnabled = true;
		ComboBox obj18 = cboKyBc;
		location = new Point(102, 19);
		((Control)obj18).Location = location;
		((Control)cboKyBc).Name = "cboKyBc";
		ComboBox obj19 = cboKyBc;
		size = new Size(80, 21);
		((Control)obj19).Size = size;
		((Control)cboKyBc).TabIndex = 0;
		lblKyBc.AutoSize = true;
		Label obj20 = lblKyBc;
		location = new Point(16, 23);
		((Control)obj20).Location = location;
		((Control)lblKyBc).Name = "lblKyBc";
		Label obj21 = lblKyBc;
		size = new Size(61, 13);
		((Control)obj21).Size = size;
		((Control)lblKyBc).TabIndex = 1019;
		lblKyBc.Text = "Kỳ báo cáo";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(456, 179);
		((Form)this).ClientSize = size;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmGLPost2GLFilter";
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).Text = "Chuyển số liệu vào sổ cái";
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ValidData()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(AsiaErp.Framework.Environment.GetSIConfiguration().ngay_ks, Conversions.ToDate(txtNgay1.Value)) > 0)
		{
			CMessageBox.Show(50012);
			return false;
		}
		return base.ValidData();
	}

	private void frmGLPost2GLFilter_Load(object sender, EventArgs e)
	{
		InitKyBaoCao();
		initCbo();
	}

	private void initCbo()
	{
		IGLPost2GLDAO iGLPost2GLDAO = (IGLPost2GLDAO)DAOFactory.CreateDAOInstance("GLPost2GLDAO", "GLPost2GL");
		f_voucherList = iGLPost2GLDAO.GetSiCt4PostGl(CompanyInformations.CompanyID, f_strMa_ph, "", SystemInformations.CurrentCultureName);
		iGLPost2GLDAO.Destroy();
		string ten = Conversions.ToString(((ComboBox)cboMa_ct).Items[0]);
		if (AsiaErp.Framework.Environment.getLangSysMessageResX("#GLPOST2GL_ALLVOUCHER") != null)
		{
			ten = AsiaErp.Framework.Environment.getLangSysMessageResX("#GLPOST2GL_ALLVOUCHER").value;
		}
		VoucherInfoDatasource item = new VoucherInfoDatasource(f_strMa_ph, ten);
		f_voucherList.Add(item);
		((ListControl)cboMa_ct).DisplayMember = "ten_ct";
		((ListControl)cboMa_ct).ValueMember = "ma_ct";
		((ComboBox)cboMa_ct).DataSource = f_voucherList;
		((ListControl)cboMa_ct).SelectedValue = f_strMa_ph;
		((ComboBox)cboStatus).SelectedIndex = 0;
	}

	private void cboKyBc_SelectedValueChanged(object sender, EventArgs e)
	{
		if (cboKyBc.DataSource != null)
		{
			if (Operators.CompareString(((KyBaoCao)cboKyBc.SelectedItem).ma, "NGAY", false) != 0)
			{
				txtNgay1.Value = ((KyBaoCao)cboKyBc.SelectedItem).ngay1;
				txtNgay2.Value = ((KyBaoCao)cboKyBc.SelectedItem).ngay2;
				((MaskedTextBox)txtNgay1).ReadOnly = true;
				((Control)txtNgay1).TabStop = false;
				((MaskedTextBox)txtNgay2).ReadOnly = true;
				((Control)txtNgay2).TabStop = false;
			}
			else
			{
				((MaskedTextBox)txtNgay1).ReadOnly = false;
				((Control)txtNgay1).TabStop = true;
				((MaskedTextBox)txtNgay2).ReadOnly = false;
				((Control)txtNgay2).TabStop = true;
			}
			f_strNhan_in = Conversions.ToDate(txtNgay1.Value).ToShortDateString() + " - " + Conversions.ToDate(txtNgay2.Value).ToShortDateString();
		}
	}

	private void InitKyBaoCao()
	{
		cboKyBc.DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc);
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"", false))
		{
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"NGAY", false))
			{
				try
				{
					txtNgay1.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct1"));
					txtNgay2.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct2"));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			((ListControl)cboKyBc).SelectedValue = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao"));
		}
		else
		{
			cboKyBc.SelectedIndex = 0;
		}
	}

	private void SaveKyBaoCao()
	{
		AsiaErp.Framework.Environment.set_PublicVariables("KyBaoCao", (object)((KyBaoCao)cboKyBc.SelectedItem).ma);
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
	}
}
