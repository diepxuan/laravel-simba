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
public class frmFAThoiKHTSEdit : frmDMComplexEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtMa_ts")]
	private AsTextBox _txtMa_ts;

	[AccessedThroughProperty("lblMa_ts")]
	private Label _lblMa_ts;

	[AccessedThroughProperty("lblTen_ts")]
	private Label _lblTen_ts;

	[AccessedThroughProperty("lblNgay_thoi_kh")]
	private Label _lblNgay_thoi_kh;

	[AccessedThroughProperty("txtNgay_thoi_kh")]
	private AsMaskedTextBox _txtNgay_thoi_kh;

	[AccessedThroughProperty("lblDien_giai")]
	private Label _lblDien_giai;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("lblNgay_KH_lai")]
	private Label _lblNgay_KH_lai;

	[AccessedThroughProperty("txtNgay_kh_lai")]
	private AsMaskedTextBox _txtNgay_kh_lai;

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

	internal virtual Label lblTen_ts
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ts = value;
		}
	}

	internal virtual Label lblNgay_thoi_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_thoi_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_thoi_kh = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_thoi_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_thoi_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_thoi_kh = value;
		}
	}

	internal virtual Label lblDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDien_giai = value;
		}
	}

	internal virtual TextBox txtDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDien_giai = value;
		}
	}

	internal virtual Label lblNgay_KH_lai
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_KH_lai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_KH_lai = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_kh_lai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_kh_lai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_kh_lai = value;
		}
	}

	[DebuggerNonUserCode]
	public frmFAThoiKHTSEdit()
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
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		lblMa_ts = new Label();
		txtMa_ts = new AsTextBox();
		lblTen_ts = new Label();
		txtNgay_thoi_kh = new AsMaskedTextBox();
		lblNgay_thoi_kh = new Label();
		lblNgay_KH_lai = new Label();
		txtNgay_kh_lai = new AsMaskedTextBox();
		txtDien_giai = new TextBox();
		lblDien_giai = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(386, 228);
		((Control)asCheckBox).Location = location;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 207);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 207);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblDien_giai);
		((Control)gbLine).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_KH_lai);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_kh_lai);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_ts);
		((Control)gbLine).Controls.Add((Control)(object)lblNgay_thoi_kh);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_ts);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay_thoi_kh);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_ts);
		GroupBox obj3 = gbLine;
		Size size = new Size(516, 195);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_thoi_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_thoi_kh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_ts, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay_kh_lai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblNgay_KH_lai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtDien_giai, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDien_giai, 0);
		lblMa_ts.AutoSize = true;
		Label obj4 = lblMa_ts;
		location = new Point(19, 25);
		((Control)obj4).Location = location;
		((Control)lblMa_ts).Name = "lblMa_ts";
		Label obj5 = lblMa_ts;
		size = new Size(56, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_ts).TabIndex = 100;
		lblMa_ts.Text = "Mã tài sản";
		txtMa_ts.AutoLookup = true;
		txtMa_ts.AutoValid = true;
		((TextBoxBase)txtMa_ts).BackColor = SystemColors.Info;
		((TextBox)txtMa_ts).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_ts;
		location = new Point(127, 21);
		((Control)asTextBox).Location = location;
		txtMa_ts.LookupCodeName = "MA_TS";
		((Control)txtMa_ts).Name = "txtMa_ts";
		txtMa_ts.NameControl = lblTen_ts;
		AsTextBox asTextBox2 = txtMa_ts;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_ts).TabIndex = 0;
		txtMa_ts.UseAutoCompleteSource = true;
		txtMa_ts.ValidReturnFieldList = "MA_TS,TEN_TS";
		Label obj6 = lblTen_ts;
		location = new Point(233, 24);
		((Control)obj6).Location = location;
		((Control)lblTen_ts).Name = "lblTen_ts";
		Label obj7 = lblTen_ts;
		size = new Size(200, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_ts).TabIndex = 100;
		txtNgay_thoi_kh.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_thoi_kh).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_thoi_kh;
		location = new Point(127, 47);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_thoi_kh).Mask = "##/##/####";
		((Control)txtNgay_thoi_kh).Name = "txtNgay_thoi_kh";
		((MaskedTextBox)txtNgay_thoi_kh).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_thoi_kh;
		size = new Size(100, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_thoi_kh).TabIndex = 2;
		((MaskedTextBox)txtNgay_thoi_kh).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_thoi_kh;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		lblNgay_thoi_kh.AutoSize = true;
		Label obj8 = lblNgay_thoi_kh;
		location = new Point(19, 51);
		((Control)obj8).Location = location;
		((Control)lblNgay_thoi_kh).Name = "lblNgay_thoi_kh";
		Label obj9 = lblNgay_thoi_kh;
		size = new Size(107, 13);
		((Control)obj9).Size = size;
		((Control)lblNgay_thoi_kh).TabIndex = 100;
		lblNgay_thoi_kh.Text = "Ngày dừng khấu hao";
		lblNgay_KH_lai.AutoSize = true;
		Label obj10 = lblNgay_KH_lai;
		location = new Point(19, 77);
		((Control)obj10).Location = location;
		((Control)lblNgay_KH_lai).Name = "lblNgay_KH_lai";
		Label obj11 = lblNgay_KH_lai;
		size = new Size(93, 13);
		((Control)obj11).Size = size;
		((Control)lblNgay_KH_lai).TabIndex = 102;
		lblNgay_KH_lai.Text = "Ngày khấu hao lại";
		txtNgay_kh_lai.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_kh_lai).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_kh_lai;
		location = new Point(127, 73);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay_kh_lai).Mask = "##/##/####";
		((Control)txtNgay_kh_lai).Name = "txtNgay_kh_lai";
		((MaskedTextBox)txtNgay_kh_lai).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay_kh_lai;
		size = new Size(100, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay_kh_lai).TabIndex = 3;
		((MaskedTextBox)txtNgay_kh_lai).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay_kh_lai;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		TextBox obj12 = txtDien_giai;
		location = new Point(127, 99);
		((Control)obj12).Location = location;
		txtDien_giai.Multiline = true;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj13 = txtDien_giai;
		size = new Size(378, 90);
		((Control)obj13).Size = size;
		((Control)txtDien_giai).TabIndex = 4;
		lblDien_giai.AutoSize = true;
		Label obj14 = lblDien_giai;
		location = new Point(19, 102);
		((Control)obj14).Location = location;
		((Control)lblDien_giai).Name = "lblDien_giai";
		Label obj15 = lblDien_giai;
		size = new Size(51, 13);
		((Control)obj15).Size = size;
		((Control)lblDien_giai).TabIndex = 104;
		lblDien_giai.Text = "Diễn giải ";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(540, 242);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFAThoiKHTSEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_ts).Enabled = false;
		((Control)txtNgay_thoi_kh).Enabled = false;
		((Control)txtNgay_kh_lai).Select();
	}

	protected override bool ValidData()
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_ts))
		{
			return false;
		}
		if (Operators.ConditionalCompareObjectEqual(txtNgay_thoi_kh.Value, (object)new DateTime(599266080000000000L), false))
		{
			SetControlError((Control)(object)txtNgay_thoi_kh, Helper.GetMessContent(50002));
			return false;
		}
		if (Operators.ConditionalCompareObjectNotEqual(txtNgay_kh_lai.Value, (object)new DateTime(599266080000000000L), false) && DateTime.Compare(Conversions.ToDate(txtNgay_kh_lai.Value), Conversions.ToDate(txtNgay_thoi_kh.Value)) < 0)
		{
			CMessageBox.Show(50067);
			return false;
		}
		if (EditMode)
		{
			if (Operators.ConditionalCompareObjectNotEqual(txtNgay_kh_lai.Value, (object)new DateTime(599266080000000000L), false) && DateTime.Compare(Conversions.ToDate(txtNgay_kh_lai.Value), Conversions.ToDate(txtNgay_thoi_kh.Value)) < 0)
			{
				CMessageBox.Show(50067);
				return false;
			}
		}
		else
		{
			IFAThoiKHTSDAO iFAThoiKHTSDAO = (IFAThoiKHTSDAO)DAOFactory.CreateDAOInstance("FAThoiKHTSDAO", "FAThoiKHTS");
			if (iFAThoiKHTSDAO.Check(CompanyInformations.CompanyID, ((TextBox)txtMa_ts).Text.Trim(), Conversions.ToDate(txtNgay_thoi_kh.Value)) > 0)
			{
				CMessageBox.Show(50046);
				return false;
			}
			iFAThoiKHTSDAO.Destroy();
		}
		return base.ValidData();
	}

	protected override void DataBinding()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		Control ojb = (Control)(object)txtMa_ts;
		CreateDataBinding(ref ojb, "ma_ts");
		txtMa_ts = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_ts;
		CreateDataBinding(ref ojb, "ten_ts");
		lblTen_ts = (Label)ojb;
		ojb = (Control)(object)txtNgay_thoi_kh;
		CreateDataBinding(ref ojb, "ngay_dung_kh", "value");
		txtNgay_thoi_kh = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtNgay_kh_lai;
		CreateDataBinding(ref ojb, "Ngay_kh_lai", "value");
		txtNgay_kh_lai = (AsMaskedTextBox)(object)ojb;
		ojb = (Control)(object)txtDien_giai;
		CreateDataBinding(ref ojb, "Dien_giai");
		txtDien_giai = (TextBox)ojb;
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			txtNgay_thoi_kh.Value = DateTime.Now;
		}
	}
}
