using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmSODMTKMEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("lblMa_km")]
	private Label _lblMa_km;

	[AccessedThroughProperty("txtMa_km")]
	private AsTextBox _txtMa_km;

	[AccessedThroughProperty("lblTen_km")]
	private Label _lblTen_km;

	[AccessedThroughProperty("lblMa_vt")]
	private Label _lblMa_vt;

	[AccessedThroughProperty("lblTen_vt")]
	private Label _lblTen_vt;

	[AccessedThroughProperty("txtMa_vt")]
	private AsTextBox _txtMa_vt;

	[AccessedThroughProperty("txtSo_luong")]
	private AsTextNumeric _txtSo_luong;

	[AccessedThroughProperty("lblSo_luong")]
	private Label _lblSo_luong;

	internal virtual Label lblMa_km
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_km;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_km = value;
		}
	}

	internal virtual AsTextBox txtMa_km
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_km;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_km = value;
		}
	}

	internal virtual Label lblTen_km
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_km;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_km = value;
		}
	}

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
			_txtMa_vt = value;
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

	[DebuggerNonUserCode]
	public frmSODMTKMEdit()
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		lblMa_km = new Label();
		txtMa_km = new AsTextBox();
		lblTen_km = new Label();
		txtMa_vt = new AsTextBox();
		lblTen_vt = new Label();
		lblMa_vt = new Label();
		txtSo_luong = new AsTextNumeric();
		lblSo_luong = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(90, 97);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 3;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 136);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 136);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)txtSo_luong);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_km);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_vt);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_luong);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_km);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_km);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_vt);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_vt);
		GroupBox obj3 = gbLine;
		Size size = new Size(415, 124);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_km, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_km, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_luong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_vt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_km, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_luong, 0);
		lblMa_km.AutoSize = true;
		Label obj4 = lblMa_km;
		location = new Point(29, 23);
		((Control)obj4).Location = location;
		((Control)lblMa_km).Name = "lblMa_km";
		Label obj5 = lblMa_km;
		size = new Size(41, 13);
		((Control)obj5).Size = size;
		((Control)lblMa_km).TabIndex = 100;
		lblMa_km.Text = "Mã KM";
		txtMa_km.AutoLookup = true;
		txtMa_km.AutoValid = true;
		((TextBoxBase)txtMa_km).BackColor = SystemColors.Info;
		((TextBox)txtMa_km).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_km;
		location = new Point(90, 19);
		((Control)asTextBox).Location = location;
		txtMa_km.LookupCodeName = "MA_KM";
		((Control)txtMa_km).Name = "txtMa_km";
		txtMa_km.NameControl = lblTen_km;
		AsTextBox asTextBox2 = txtMa_km;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_km).TabIndex = 0;
		Label obj6 = lblTen_km;
		location = new Point(196, 23);
		((Control)obj6).Location = location;
		((Control)lblTen_km).Name = "lblTen_km";
		Label obj7 = lblTen_km;
		size = new Size(214, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_km).TabIndex = 100;
		txtMa_vt.AutoLookup = true;
		txtMa_vt.AutoValid = true;
		((TextBoxBase)txtMa_vt).BackColor = SystemColors.Info;
		((TextBox)txtMa_vt).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_vt;
		location = new Point(90, 45);
		((Control)asTextBox3).Location = location;
		txtMa_vt.LookupCodeName = "MA_VT";
		((Control)txtMa_vt).Name = "txtMa_vt";
		txtMa_vt.NameControl = lblTen_vt;
		AsTextBox asTextBox4 = txtMa_vt;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_vt).TabIndex = 1;
		Label obj8 = lblTen_vt;
		location = new Point(196, 49);
		((Control)obj8).Location = location;
		((Control)lblTen_vt).Name = "lblTen_vt";
		Label obj9 = lblTen_vt;
		size = new Size(214, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_vt).TabIndex = 100;
		lblMa_vt.AutoSize = true;
		Label obj10 = lblMa_vt;
		location = new Point(29, 49);
		((Control)obj10).Location = location;
		((Control)lblMa_vt).Name = "lblMa_vt";
		Label obj11 = lblMa_vt;
		size = new Size(52, 13);
		((Control)obj11).Size = size;
		((Control)lblMa_vt).TabIndex = 100;
		lblMa_vt.Text = "Mã vật tư";
		txtSo_luong.DecimalSymbol = ".";
		txtSo_luong.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtSo_luong;
		location = new Point(90, 71);
		((Control)asTextNumeric).Location = location;
		txtSo_luong.Mask = "### ### ### ###.##";
		((Control)txtSo_luong).Name = "txtSo_luong";
		AsTextNumeric asTextNumeric2 = txtSo_luong;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtSo_luong).TabIndex = 2;
		((TextBox)txtSo_luong).Text = "0.00";
		((TextBox)txtSo_luong).TextAlign = (HorizontalAlignment)1;
		txtSo_luong.Value = 0;
		lblSo_luong.AutoSize = true;
		Label obj12 = lblSo_luong;
		location = new Point(29, 75);
		((Control)obj12).Location = location;
		((Control)lblSo_luong).Name = "lblSo_luong";
		Label obj13 = lblSo_luong;
		size = new Size(49, 13);
		((Control)obj13).Size = size;
		((Control)lblSo_luong).TabIndex = 100;
		lblSo_luong.Text = "Số lượng";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(439, 171);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSODMTKMEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_km).Enabled = false;
		((Control)txtMa_vt).Enabled = false;
		((Control)txtSo_luong).Select();
	}

	protected override void DataBinding()
	{
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_km;
		CreateDataBinding(ref ojb, "ma_km");
		txtMa_km = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_vt;
		CreateDataBinding(ref ojb, "ma_vt");
		txtMa_vt = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtSo_luong;
		CreateDataBinding(ref ojb, "sl_km", "value");
		txtSo_luong = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "ksd", "checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox((TextBox)(object)txtMa_km) || !ChkEmtyTextBox((TextBox)(object)txtMa_vt) || !base.ValidData())
		{
			return false;
		}
		return true;
	}
}
