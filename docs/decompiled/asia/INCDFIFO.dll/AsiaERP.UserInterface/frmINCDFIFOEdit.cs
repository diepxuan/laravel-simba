using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaERP.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmINCDFIFOEdit : frmOBEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("lblMa_kho")]
	private Label _lblMa_kho;

	[AccessedThroughProperty("txtSo_luong")]
	private AsTextNumeric _txtSo_luong;

	[AccessedThroughProperty("lblMa_nt")]
	private Label _lblMa_nt;

	[AccessedThroughProperty("lblSo_luong")]
	private Label _lblSo_luong;

	[AccessedThroughProperty("txtTien_nt")]
	private AsTextNumeric _txtTien_nt;

	[AccessedThroughProperty("txtTien_vnd")]
	private AsTextNumeric _txtTien_vnd;

	[AccessedThroughProperty("lblTien")]
	private Label _lblTien;

	[AccessedThroughProperty("lblTien_nt")]
	private Label _lblTien_nt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("lblTen_kho")]
	private Label _lblTen_kho;

	[AccessedThroughProperty("cboMa_Nt")]
	private AsComboBoxNT _cboMa_Nt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("txtMa_kho")]
	private AsTextBox _txtMa_kho;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("txtNgay_ct")]
	private AsMaskedTextBox _txtNgay_ct;

	[AccessedThroughProperty("lblSo_ct")]
	private Label _lblSo_ct;

	[AccessedThroughProperty("lblNgay_ct")]
	private Label _lblNgay_ct;

	private bool isExistMa_vt;

	internal virtual Label lblMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_vt = value;
		}
	}

	internal virtual Label lblMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_kho = value;
		}
	}

	internal virtual AsTextNumeric txtSo_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_luong = value;
		}
	}

	internal virtual Label lblMa_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nt = value;
		}
	}

	internal virtual Label lblSo_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_luong = value;
		}
	}

	internal virtual AsTextNumeric txtTien_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTien_nt = value;
		}
	}

	internal virtual AsTextNumeric txtTien_vnd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTien_vnd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTien_vnd = value;
		}
	}

	internal virtual Label lblTien
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTien = value;
		}
	}

	internal virtual Label lblTien_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTien_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTien_nt = value;
		}
	}

	internal virtual Label lblTen_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_vt = value;
		}
	}

	internal virtual Label lblTen_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kho = value;
		}
	}

	internal virtual AsComboBoxNT cboMa_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboMa_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboMa_Nt = value;
		}
	}

	internal virtual AsTextBox txtMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_vt_AfterCodeValidating;
			if (_txtMa_vt != null)
			{
				_txtMa_vt.AfterCodeValidating -= obj;
			}
			_txtMa_vt = value;
			if (_txtMa_vt != null)
			{
				_txtMa_vt.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual AsTextBox txtMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kho = value;
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

	internal virtual AsMaskedTextBox txtNgay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_ct = value;
		}
	}

	internal virtual Label lblSo_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_ct = value;
		}
	}

	internal virtual Label lblNgay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_ct = value;
		}
	}

	public frmINCDFIFOEdit()
	{
		__ENCAddToList(this);
		isExistMa_vt = false;
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		lblMa_vt = new Label();
		lblMa_kho = new Label();
		lblMa_nt = new Label();
		txtSo_luong = new AsTextNumeric();
		lblSo_luong = new Label();
		lblTien_nt = new Label();
		txtTien_nt = new AsTextNumeric();
		lblTien = new Label();
		txtTien_vnd = new AsTextNumeric();
		lblTen_vt = new Label();
		lblTen_kho = new Label();
		cboMa_Nt = new AsComboBoxNT();
		txtMa_vt = new AsTextBox();
		txtMa_kho = new AsTextBox();
		lblNgay_ct = new Label();
		lblSo_ct = new Label();
		txtNgay_ct = new AsMaskedTextBox();
		txtSo_ct = new TextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(504, 324);
		((Control)asCheckBox).Location = location;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 248);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 248);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_ct);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_vt);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_kho);
		((Control)gbLine).Controls.Add((Control)(object)cboMa_Nt);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_luong);
		((Control)gbLine).Controls.Add((Control)(object)txtTien_nt);
		((Control)gbLine).Controls.Add((Control)(object)txtTien_vnd);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_kho);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_vt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_vt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_kho);
		((Control)gbLine).Controls.Add((Control)(object)lblTien);
		((Control)gbLine).Controls.Add((Control)(object)lblTien_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_luong);
		GroupBox obj3 = gbLine;
		Size size = new Size(560, 236);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_luong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTien_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTien_vnd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTien_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_luong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboMa_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_kho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct, 0);
		lblMa_vt.AutoSize = true;
		Label obj4 = lblMa_vt;
		location = new Point(17, 73);
		((Control)obj4).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj5 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_vt).TabIndex = 23;
		lblMa_vt.Text = "Mã vật tư";
		lblMa_kho.AutoSize = true;
		Label obj6 = lblMa_kho;
		location = new Point(17, 99);
		((Control)obj6).Location = location;
		((Control)lblMa_kho).Name = "lblMa_kho";
		Label obj7 = lblMa_kho;
		size = new Size(43, 13);
		((Control)obj7).Size = size;
		((Control)lblMa_kho).TabIndex = 22;
		lblMa_kho.Text = "Mã kho";
		lblMa_nt.AutoSize = true;
		Label obj8 = lblMa_nt;
		location = new Point(17, 125);
		((Control)obj8).Location = location;
		((Control)lblMa_nt).Name = "lblMa_nt";
		Label obj9 = lblMa_nt;
		size = new Size(40, 13);
		((Control)obj9).Size = size;
		((Control)lblMa_nt).TabIndex = 18;
		lblMa_nt.Text = "Mã NT";
		txtSo_luong.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtSo_luong;
		location = new Point(100, 149);
		((Control)asTextNumeric).Location = location;
		txtSo_luong.Mask = "### ### ### ###.####";
		((Control)txtSo_luong).Name = "txtSo_luong";
		AsTextNumeric asTextNumeric2 = txtSo_luong;
		size = new Size(112, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtSo_luong).TabIndex = 6;
		((Control)txtSo_luong).Tag = "QT";
		((TextBox)txtSo_luong).Text = "0.0000";
		((TextBox)txtSo_luong).TextAlign = (HorizontalAlignment)1;
		txtSo_luong.Value = 0.0;
		lblSo_luong.AutoSize = true;
		Label obj10 = lblSo_luong;
		location = new Point(17, 152);
		((Control)obj10).Location = location;
		((Control)lblSo_luong).Name = "lblSo_luong";
		Label obj11 = lblSo_luong;
		size = new Size(49, 13);
		((Control)obj11).Size = size;
		((Control)lblSo_luong).TabIndex = 17;
		lblSo_luong.Text = "Số lượng";
		lblTien_nt.AutoSize = true;
		Label obj12 = lblTien_nt;
		location = new Point(17, 178);
		((Control)obj12).Location = location;
		((Control)lblTien_nt).Name = "lblTien_nt";
		Label obj13 = lblTien_nt;
		size = new Size(46, 13);
		((Control)obj13).Size = size;
		((Control)lblTien_nt).TabIndex = 16;
		lblTien_nt.Text = "Tiền NT";
		txtTien_nt.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric3 = txtTien_nt;
		location = new Point(100, 175);
		((Control)asTextNumeric3).Location = location;
		txtTien_nt.Mask = "### ### ### ###.####";
		((Control)txtTien_nt).Name = "txtTien_nt";
		AsTextNumeric asTextNumeric4 = txtTien_nt;
		size = new Size(112, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtTien_nt).TabIndex = 7;
		((Control)txtTien_nt).Tag = "FA";
		((TextBox)txtTien_nt).Text = "0.0000";
		((TextBox)txtTien_nt).TextAlign = (HorizontalAlignment)1;
		txtTien_nt.Value = 0.0;
		lblTien.AutoSize = true;
		Label obj14 = lblTien;
		location = new Point(17, 204);
		((Control)obj14).Location = location;
		((Control)lblTien).Name = "lblTien";
		Label obj15 = lblTien;
		size = new Size(54, 13);
		((Control)obj15).Size = size;
		((Control)lblTien).TabIndex = 15;
		lblTien.Text = "Tiền VND";
		txtTien_vnd.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric5 = txtTien_vnd;
		location = new Point(100, 201);
		((Control)asTextNumeric5).Location = location;
		txtTien_vnd.Mask = "### ### ### ###.####";
		((Control)txtTien_vnd).Name = "txtTien_vnd";
		AsTextNumeric asTextNumeric6 = txtTien_vnd;
		size = new Size(112, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtTien_vnd).TabIndex = 8;
		((Control)txtTien_vnd).Tag = "OA";
		((TextBox)txtTien_vnd).Text = "0.0000";
		((TextBox)txtTien_vnd).TextAlign = (HorizontalAlignment)1;
		txtTien_vnd.Value = 0.0;
		Label obj16 = lblTen_vt;
		location = new Point(220, 71);
		((Control)obj16).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj17 = lblTen_vt;
		size = new Size(327, 17);
		((Control)obj17).Size = size;
		((Control)lblTen_vt).TabIndex = 12;
		Label obj18 = lblTen_kho;
		location = new Point(179, 96);
		((Control)obj18).Location = location;
		((Control)lblTen_kho).Name = "lblTen_kho";
		Label obj19 = lblTen_kho;
		size = new Size(363, 17);
		((Control)obj19).Size = size;
		((Control)lblTen_kho).TabIndex = 13;
		((ComboBox)cboMa_Nt).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMa_Nt).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_Nt;
		location = new Point(100, 122);
		((Control)asComboBoxNT).Location = location;
		cboMa_Nt.MA_NT = "";
		((Control)cboMa_Nt).Name = "cboMa_Nt";
		AsComboBoxNT asComboBoxNT2 = cboMa_Nt;
		size = new Size(53, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_Nt).TabIndex = 5;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = true;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_vt;
		location = new Point(100, 70);
		((Control)asTextBox).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		txtMa_vt.LookupWhereCondition = "ton_kho=1 and gia_ton='2'";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		txtMa_vt.SD = true;
		AsTextBox asTextBox2 = txtMa_vt;
		size = new Size(112, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_vt).TabIndex = 3;
		txtMa_vt.UseAutoCompleteSource = true;
		txtMa_vt.ValidReturnFieldList = "TK_VT,TEN_VT,DVT";
		txtMa_kho.AutoLookup = true;
		txtMa_kho.AutoValid = true;
		((TextBoxBase)txtMa_kho).BackColor = SystemColors.Info;
		((TextBox)txtMa_kho).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_kho;
		location = new Point(100, 96);
		((Control)asTextBox3).Location = location;
		txtMa_kho.LookupCodeName = "MA_KHO";
		((Control)txtMa_kho).Name = "txtMa_kho";
		txtMa_kho.NameControl = lblTen_kho;
		txtMa_kho.SD = true;
		AsTextBox asTextBox4 = txtMa_kho;
		size = new Size(73, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_kho).TabIndex = 4;
		txtMa_kho.UseAutoCompleteSource = true;
		lblNgay_ct.AutoSize = true;
		Label obj20 = lblNgay_ct;
		location = new Point(17, 21);
		((Control)obj20).Location = location;
		((Control)lblNgay_ct).Name = "lblNgay_ct";
		Label obj21 = lblNgay_ct;
		size = new Size(77, 13);
		((Control)obj21).Size = size;
		((Control)lblNgay_ct).TabIndex = 100;
		lblNgay_ct.Text = "Ngày chứng từ";
		lblSo_ct.AutoSize = true;
		Label obj22 = lblSo_ct;
		location = new Point(17, 47);
		((Control)obj22).Location = location;
		((Control)lblSo_ct).Name = "lblSo_ct";
		Label obj23 = lblSo_ct;
		size = new Size(65, 13);
		((Control)obj23).Size = size;
		((Control)lblSo_ct).TabIndex = 101;
		lblSo_ct.Text = "Số chứng từ";
		txtNgay_ct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct;
		location = new Point(100, 18);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ct).Mask = "##/##/####";
		((Control)txtNgay_ct).Name = "txtNgay_ct";
		((MaskedTextBox)txtNgay_ct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ct;
		size = new Size(90, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ct).TabIndex = 1;
		((MaskedTextBox)txtNgay_ct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		TextBox obj24 = txtSo_ct;
		location = new Point(100, 44);
		((Control)obj24).Location = location;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj25 = txtSo_ct;
		size = new Size(90, 20);
		((Control)obj25).Size = size;
		((Control)txtSo_ct).TabIndex = 2;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(584, 283);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmINCDFIFOEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ValidData()
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Invalid comparison between Unknown and I4
		if (Operators.ConditionalCompareObjectEqual(txtNgay_ct.Value, (object)new DateTime(599266080000000000L), false))
		{
			SetControlError((Control)(object)txtNgay_ct, Helper.GetMessContent(50002));
			((Control)txtNgay_ct).Select();
			((Control)txtNgay_ct).Focus();
			return false;
		}
		if ((!ChkEmtyTextBox(txtSo_ct) || !ChkEmtyTextBox((TextBox)(object)txtMa_vt) || !ChkEmtyTextBox((TextBox)(object)txtMa_kho)) && 0 == 0)
		{
			return false;
		}
		if (isExistMa_vt && (int)CMessageBox.Show(50207, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)256) == 7)
		{
			return false;
		}
		return base.ValidData();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		MaskTextBoxAll(((Control)gbLine).Controls);
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_kho).Enabled = false;
		((Control)txtMa_vt).Enabled = false;
		((Control)cboMa_Nt).Enabled = false;
		((Control)txtNgay_ct).Enabled = false;
		((Control)txtSo_ct).Enabled = false;
	}

	protected override void DataBinding()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_kho;
		CreateDataBinding(ref ojb, "ma_kho");
		txtMa_kho = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_ct;
		CreateDataBinding(ref ojb, "ngay_ct", "Value");
		txtNgay_ct = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "so_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)txtMa_vt;
		CreateDataBinding(ref ojb, "ma_vt");
		txtMa_vt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)cboMa_Nt;
		CreateDataBinding(ref ojb, "ma_nt", "MA_NT");
		cboMa_Nt = (AsComboBoxNT)(object)ojb;
		ojb = (Control)(object)txtSo_luong;
		CreateDataBinding(ref ojb, "so_luong", "value");
		txtSo_luong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_nt;
		CreateDataBinding(ref ojb, "tien_nt", "value");
		txtTien_nt = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTien_vnd;
		CreateDataBinding(ref ojb, "tien", "value");
		txtTien_vnd = (AsTextNumeric)(object)ojb;
	}

	protected override bool SetToRow()
	{
		base.SetToRow();
		if (!EditMode)
		{
			INCDFIFODAO iNCDFIFODAO = (INCDFIFODAO)DAOFactory.CreateDAOInstance("INCDFIFODAO", "INCDFIFO");
			DataTable stt_rec04CDFIFO = iNCDFIFODAO.GetStt_rec04CDFIFO(CompanyInformations.CompanyID, Conversions.ToDate(txtNgay_ct.Value), txtSo_ct.Text.Trim());
			iNCDFIFODAO.Destroy();
			string value;
			if (stt_rec04CDFIFO == null || stt_rec04CDFIFO.Rows.Count == 0)
			{
				value = "001";
				RowToEdit["stt_rec_nt"] = Commons.Get_SttRec(MyMenuInfo.par1);
			}
			else
			{
				DataRow[] array = stt_rec04CDFIFO.Select("ma_vt='" + ((TextBox)txtMa_vt).Text + "'");
				if (array == null || array.Length == 0)
				{
					isExistMa_vt = false;
				}
				else
				{
					isExistMa_vt = true;
				}
				string text = Conversions.ToString(stt_rec04CDFIFO.Compute("max(stt_rec0)", ""));
				int num = Conversions.ToInteger(text);
				value = Conversions.ToString(checked(num + 1));
				value = value.PadLeft(3, '0');
				value = Strings.Right(value.Trim(), 3);
				DataRow dataRow = stt_rec04CDFIFO.Rows[0];
				RowToEdit["stt_rec_nt"] = RuntimeHelpers.GetObjectValue(dataRow["stt_rec_nt"]);
			}
			RowToEdit["stt_rec0"] = value;
			RowToEdit["ma_ct"] = MyMenuInfo.par1;
		}
		if (!EditMode)
		{
			RowToEdit["TEN_VT"] = lblTen_vt.Text;
		}
		RowToEdit["ton_kho"] = RuntimeHelpers.GetObjectValue(RowToEdit["so_luong"]);
		RowToEdit["so_luong_qd"] = RuntimeHelpers.GetObjectValue(RowToEdit["so_luong"]);
		RowToEdit["so_du"] = RuntimeHelpers.GetObjectValue(RowToEdit["tien"]);
		RowToEdit["so_du_nt"] = RuntimeHelpers.GetObjectValue(RowToEdit["tien_nt"]);
		return true;
	}

	private void txtMa_vt_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (e.ValidatedRow != null)
		{
			if (txtMa_vt.ValidReturnFieldList.Contains("TEN_VT"))
			{
				RowToEdit["ten_vt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ten_vt"]), isNum: false));
			}
			if (txtMa_vt.ValidReturnFieldList.Contains("DVT"))
			{
				RowToEdit["dvt"] = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["dvt"]), isNum: false));
			}
		}
	}

	private void MaskTextBoxAll(ControlCollection ctl)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (Control item in ctl)
		{
			Control val = item;
			if (val is AsTextNumeric)
			{
				AsTextNumeric asTextNumeric = (AsTextNumeric)(object)val;
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCPrice_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"QT", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format;
				}
			}
		}
	}
}
