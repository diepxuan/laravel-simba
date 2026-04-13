using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCoNgungKhCPTTEdit : frmDMComplexEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("txtNguyen_gia")]
	private AsTextNumeric _txtNguyen_gia;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("chkKh_so_du")]
	private CheckBox _chkKh_so_du;

	[AccessedThroughProperty("txtMa_cptt")]
	private AsTextBox _txtMa_cptt;

	[AccessedThroughProperty("lblTen_cptt")]
	private Label _lblTen_cptt;

	[AccessedThroughProperty("txtNgay_bd_kh")]
	private AsMaskedTextBox _txtNgay_bd_kh;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtNgay_tkh")]
	private DateTimePicker _txtNgay_tkh;

	[AccessedThroughProperty("txtID")]
	private AsTextNumeric _txtID;

	private string strDvt;

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

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	internal virtual AsTextNumeric txtNguyen_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNguyen_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNguyen_gia = value;
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

	internal virtual CheckBox chkKh_so_du
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkKh_so_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkKh_so_du = value;
		}
	}

	internal virtual AsTextBox txtMa_cptt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_cptt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_cptt_AfterCodeValidating;
			if (_txtMa_cptt != null)
			{
				_txtMa_cptt.AfterCodeValidating -= obj;
			}
			_txtMa_cptt = value;
			if (_txtMa_cptt != null)
			{
				_txtMa_cptt.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual Label lblTen_cptt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_cptt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_cptt = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_bd_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_bd_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_bd_kh = value;
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

	internal virtual DateTimePicker txtNgay_tkh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_tkh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNgay_tkh_Validated;
			if (_txtNgay_tkh != null)
			{
				((Control)_txtNgay_tkh).Validated -= eventHandler;
			}
			_txtNgay_tkh = value;
			if (_txtNgay_tkh != null)
			{
				((Control)_txtNgay_tkh).Validated += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtID
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtID = value;
		}
	}

	public frmCoNgungKhCPTTEdit()
	{
		__ENCAddToList(this);
		strDvt = "";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
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
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		Label1 = new Label();
		Label16 = new Label();
		Label5 = new Label();
		txtNguyen_gia = new AsTextNumeric();
		chkKh_so_du = new CheckBox();
		txtMa_cptt = new AsTextBox();
		lblTen_cptt = new Label();
		txtNgay_bd_kh = new AsMaskedTextBox();
		Label2 = new Label();
		txtNgay_tkh = new DateTimePicker();
		txtID = new AsTextNumeric();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Enabled = false;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(445, 48);
		((Control)asCheckBox).Location = location;
		AsCheckBox asCheckBox2 = chkKsd;
		Size size = new Size(15, 14);
		((Control)asCheckBox2).Size = size;
		((Control)chkKsd).TabIndex = 19;
		((ButtonBase)chkKsd).Text = "";
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 156);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 156);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtID);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_tkh);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_cptt);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_cptt);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_bd_kh);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)Label5);
		((Control)gbLine).Controls.Add((Control)(object)txtNguyen_gia);
		((Control)gbLine).Controls.Add((Control)(object)Label16);
		((Control)gbLine).Controls.Add((Control)(object)chkKh_so_du);
		GroupBox obj3 = gbLine;
		size = new Size(472, 144);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKh_so_du, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label16, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNguyen_gia, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label5, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_bd_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_cptt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_cptt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_tkh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtID, 0);
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(6, 24);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(58, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 100;
		Label1.Text = "Mã chi phí";
		Label16.AutoSize = true;
		Label label3 = Label16;
		location = new Point(6, 99);
		((Control)label3).Location = location;
		((Control)Label16).Name = "Label16";
		Label label4 = Label16;
		size = new Size(142, 13);
		((Control)label4).Size = size;
		((Control)Label16).TabIndex = 115;
		Label16.Text = "Dừng phân bổ tại cuối tháng";
		Label5.AutoSize = true;
		Label label5 = Label5;
		location = new Point(6, 48);
		((Control)label5).Location = location;
		((Control)Label5).Name = "Label5";
		Label label6 = Label5;
		size = new Size(61, 13);
		((Control)label6).Size = size;
		((Control)Label5).TabIndex = 104;
		Label5.Text = "Nguyên giá";
		txtNguyen_gia.DecimalSymbol = ".";
		txtNguyen_gia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtNguyen_gia;
		location = new Point(153, 45);
		((Control)asTextNumeric).Location = location;
		txtNguyen_gia.Mask = "### ### ### ###";
		((Control)txtNguyen_gia).Name = "txtNguyen_gia";
		((TextBoxBase)txtNguyen_gia).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtNguyen_gia;
		size = new Size(80, 20);
		((Control)asTextNumeric2).Size = size;
		txtNguyen_gia.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNguyen_gia).TabIndex = 2;
		((Control)txtNguyen_gia).TabStop = false;
		((TextBox)txtNguyen_gia).Text = "0";
		((TextBox)txtNguyen_gia).TextAlign = (HorizontalAlignment)1;
		txtNguyen_gia.Value = 0;
		((ButtonBase)chkKh_so_du).AutoSize = true;
		CheckBox obj4 = chkKh_so_du;
		location = new Point(153, 121);
		((Control)obj4).Location = location;
		((Control)chkKh_so_du).Name = "chkKh_so_du";
		CheckBox obj5 = chkKh_so_du;
		size = new Size(239, 17);
		((Control)obj5).Size = size;
		((Control)chkKh_so_du).TabIndex = 5;
		((ButtonBase)chkKh_so_du).Text = "Phân bổ nốt số dư vào tháng ngừng phân bổ";
		((ButtonBase)chkKh_so_du).UseVisualStyleBackColor = true;
		txtMa_cptt.AutoLookup = true;
		txtMa_cptt.AutoValid = true;
		((TextBoxBase)txtMa_cptt).BackColor = SystemColors.Info;
		((TextBox)txtMa_cptt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_cptt;
		location = new Point(153, 19);
		((Control)asTextBox).Location = location;
		txtMa_cptt.LookupCodeName = "MA_CPTT";
		((TextBoxBase)txtMa_cptt).MaxLength = 10;
		((Control)txtMa_cptt).Name = "txtMa_cptt";
		txtMa_cptt.NameControl = lblTen_cptt;
		AsTextBox asTextBox2 = txtMa_cptt;
		size = new Size(80, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_cptt).TabIndex = 0;
		txtMa_cptt.UseAutoCompleteSource = true;
		txtMa_cptt.ValidReturnFieldList = "id,ten_cptt,ng_gia,ngay_bdkh,dvt";
		Label obj6 = lblTen_cptt;
		location = new Point(239, 18);
		((Control)obj6).Location = location;
		((Control)lblTen_cptt).Name = "lblTen_cptt";
		Label obj7 = lblTen_cptt;
		size = new Size(223, 19);
		((Control)obj7).Size = size;
		((Control)lblTen_cptt).TabIndex = 1;
		lblTen_cptt.TextAlign = (ContentAlignment)16;
		txtNgay_bd_kh.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_bd_kh).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_bd_kh;
		location = new Point(153, 69);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_bd_kh).Mask = "##/##/####";
		((Control)txtNgay_bd_kh).Name = "txtNgay_bd_kh";
		((MaskedTextBox)txtNgay_bd_kh).PromptChar = ' ';
		((MaskedTextBox)txtNgay_bd_kh).ReadOnly = true;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_bd_kh;
		size = new Size(80, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_bd_kh).TabIndex = 3;
		((Control)txtNgay_bd_kh).TabStop = false;
		((MaskedTextBox)txtNgay_bd_kh).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_bd_kh;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		Label2.AutoSize = true;
		Label label7 = Label2;
		location = new Point(6, 73);
		((Control)label7).Location = location;
		((Control)Label2).Name = "Label2";
		Label label8 = Label2;
		size = new Size(114, 13);
		((Control)label8).Size = size;
		((Control)Label2).TabIndex = 120;
		Label2.Text = "Ngày bắt đầu phân bổ";
		txtNgay_tkh.CustomFormat = "MM/yyyy";
		txtNgay_tkh.Format = (DateTimePickerFormat)8;
		DateTimePicker obj8 = txtNgay_tkh;
		location = new Point(153, 95);
		((Control)obj8).Location = location;
		((Control)txtNgay_tkh).Name = "txtNgay_tkh";
		txtNgay_tkh.ShowUpDown = true;
		DateTimePicker obj9 = txtNgay_tkh;
		size = new Size(80, 20);
		((Control)obj9).Size = size;
		((Control)txtNgay_tkh).TabIndex = 4;
		txtID.DecimalSymbol = ".";
		txtID.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtID;
		location = new Point(231, 439);
		((Control)asTextNumeric3).Location = location;
		txtID.Mask = "############";
		((Control)txtID).Name = "txtID";
		((TextBoxBase)txtID).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtID;
		size = new Size(80, 20);
		((Control)asTextNumeric4).Size = size;
		txtID.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtID).TabIndex = 121;
		((Control)txtID).TabStop = false;
		((TextBox)txtID).Text = "0";
		((TextBox)txtID).TextAlign = (HorizontalAlignment)1;
		txtID.Value = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(496, 191);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCoNgungKhCPTTEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_cptt).MaxLength = MyDictComplexInfo.code_length;
		DateTimePicker obj = txtNgay_tkh;
		DateTime value = new DateTime(DateAndTime.Now.Year, DateAndTime.Now.Month, DateAndTime.Now.Day, 0, 0, 0, 0);
		obj.Value = value;
		((Control)txtMa_cptt).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_cptt).Enabled = false;
		((Control)txtNgay_tkh).Select();
	}

	protected override void DataBinding()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_cptt;
		CreateDataBinding(ref ojb, "ma_cptt");
		txtMa_cptt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_cptt;
		CreateDataBinding(ref ojb, "ten_cptt");
		lblTen_cptt = (Label)ojb;
		ojb = (Control)(object)txtNgay_bd_kh;
		CreateDataBinding(ref ojb, "ngay_bdkh", "Value");
		txtNgay_bd_kh = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_tkh;
		CreateDataBinding(ref ojb, "ngay_tkh", "Value");
		txtNgay_tkh = (DateTimePicker)ojb;
		ojb = (Control)(object)txtNguyen_gia;
		CreateDataBinding(ref ojb, "ng_gia", "Value");
		txtNguyen_gia = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)chkKh_so_du;
		CreateDataBinding(ref ojb, "kh_so_du", "Checked");
		chkKh_so_du = (CheckBox)ojb;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			DateTimePicker obj = txtNgay_tkh;
			DateTime value = new DateTime(DateAndTime.Now.Year, DateAndTime.Now.Month, DateAndTime.Now.Day, 0, 0, 0);
			obj.Value = value;
		}
	}

	protected override bool ValidData()
	{
		if (Operators.CompareString(((TextBox)txtMa_cptt).Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtMa_cptt, Helper.GetMessContent(50002));
			((Control)txtMa_cptt).Focus();
			return false;
		}
		DateTime value = txtNgay_tkh.Value;
		DateTime t = new DateTime(1900, 1, 1, 0, 0, 0);
		if (DateTime.Compare(value, t) == 0)
		{
			SetControlError((Control)(object)txtNgay_tkh, Helper.GetMessContent(50034));
			((Control)txtNgay_tkh).Focus();
			return false;
		}
		return true;
	}

	protected override bool InsertToDB()
	{
		return Conversions.ToBoolean(UpdateNgungKH(IsUpd: false));
	}

	protected override bool UpdateDB()
	{
		return Conversions.ToBoolean(UpdateNgungKH(IsUpd: true));
	}

	private object UpdateNgungKH(bool IsUpd)
	{
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		COPBDAO cOPBDAO = (COPBDAO)DAOFactory.CreateDAOInstance("COPBDAO", "CoNgungKHCPTT");
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(((TextBox)txtMa_cptt).Text);
		arrayList.Add(txtNgay_tkh.Value);
		arrayList.Add(chkKh_so_du.Checked);
		arrayList.Add(IsUpd);
		int num = cOPBDAO.CoUpdNgungKH_CPTT(arrayList.ToArray());
		cOPBDAO.Destroy();
		if (num == 0)
		{
			RowToEdit["thang_tkh"] = txtNgay_tkh.Text;
			RowToEdit["id"] = RuntimeHelpers.GetObjectValue(txtID.Value);
			return true;
		}
		CMessageBox.ShowWithFormat(num, new object[1] { ((TextBox)txtMa_cptt).Text });
		((Control)txtMa_cptt).Select();
		return false;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if ((((Control)txtNgay_tkh).Focused && (int)keyData == 13) ? true : false)
		{
			((Control)chkKh_so_du).Select();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void txtMa_cptt_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		lblTen_cptt.Text = Conversions.ToString(e.ValidatedRow["ten_cptt"]);
		txtNguyen_gia.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ng_gia"]);
		txtNgay_bd_kh.Value = RuntimeHelpers.GetObjectValue(e.ValidatedRow["ngay_bdkh"]);
		strDvt = Conversions.ToString(e.ValidatedRow["DVT"]);
		((TextBox)txtID).Text = Conversions.ToString(e.ValidatedRow["id"]);
	}

	private void txtNgay_tkh_Validated(object sender, EventArgs e)
	{
		DateTimePicker obj = txtNgay_tkh;
		DateTime value = new DateTime(SystemInformations.FinancialYear, int.Parse(txtNgay_tkh.Text.Substring(0, 2)), 1);
		obj.Value = value;
	}
}
