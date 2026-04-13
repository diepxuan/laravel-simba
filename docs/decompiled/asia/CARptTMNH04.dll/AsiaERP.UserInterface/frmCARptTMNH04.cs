using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmCARptTMNH04 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("lblTen_nv")]
	private Label _lblTen_nv;

	[AccessedThroughProperty("lblMa_nv")]
	private Label _lblMa_nv;

	[AccessedThroughProperty("lblTen_nh_kh")]
	private Label _lblTen_nh_kh;

	[AccessedThroughProperty("lblMa_Nh_kh")]
	private Label _lblMa_Nh_kh;

	[AccessedThroughProperty("txtNh_kh")]
	private AsTextBox _txtNh_kh;

	[AccessedThroughProperty("txtNV")]
	private AsTextBox _txtNV;

	private virtual AsTextBox txtTk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk = value;
		}
	}

	private virtual Label lblTen_Tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Tk = value;
		}
	}

	private virtual Label lblTk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk = value;
		}
	}

	private virtual Label lblTen_nv
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nv = value;
		}
	}

	private virtual Label lblMa_nv
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nv = value;
		}
	}

	private virtual Label lblTen_nh_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_nh_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_nh_kh = value;
		}
	}

	private virtual Label lblMa_Nh_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nh_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nh_kh = value;
		}
	}

	internal virtual AsTextBox txtNh_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNh_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNh_kh = value;
		}
	}

	internal virtual AsTextBox txtNV
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNV = value;
		}
	}

	public frmCARptTMNH04(string menuid)
		: base(menuid)
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		txtTk = new AsTextBox();
		lblTen_Tk = new Label();
		lblTk = new Label();
		lblTen_nv = new Label();
		lblMa_nv = new Label();
		lblTen_nh_kh = new Label();
		lblMa_Nh_kh = new Label();
		txtNV = new AsTextBox();
		txtNh_kh = new AsTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(686, 317);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)txtNh_kh);
		((Control)tabFilter).Controls.Add((Control)(object)txtNV);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nh_kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Nh_kh);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_nv);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_nv);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		TabPage obj = tabFilter;
		size = new Size(678, 288);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nv, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nv, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Nh_kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_nh_kh, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNV, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNh_kh, 0);
		Label obj2 = lbl2;
		Point location = new Point(292, 82);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 265);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(311, 78);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 265);
		((Control)obj4).Location = location;
		((Control)cmdCancel).TabIndex = 14;
		Button obj5 = cmdModifyReport;
		location = new Point(470, 23);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 11;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(221, 78);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(125, 78);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		ComboBox obj7 = cboMau_bc;
		location = new Point(125, 25);
		((Control)obj7).Location = location;
		((Control)cboMau_bc).TabIndex = 9;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(125, 185);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 6;
		Label obj8 = lblMauBC;
		location = new Point(176, 184);
		((Control)obj8).Location = location;
		RadioButton obj9 = optVND;
		location = new Point(263, 183);
		((Control)obj9).Location = location;
		RadioButton obj10 = optNt;
		location = new Point(317, 184);
		((Control)obj10).Location = location;
		((Control)optNt).TabIndex = 7;
		Label obj11 = lblMa_nt;
		location = new Point(24, 187);
		((Control)obj11).Location = location;
		Button obj12 = cmdOk;
		location = new Point(24, 229);
		((Control)obj12).Location = location;
		((Control)cmdOk).TabIndex = 8;
		((Control)lblTieu_de).TabIndex = 12;
		TextBox obj13 = txtTieu_De;
		location = new Point(125, 52);
		((Control)obj13).Location = location;
		((Control)txtTieu_De).TabIndex = 13;
		TabPage obj14 = tabGrid;
		size = new Size(678, 288);
		((Control)obj14).Size = size;
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = true;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTk;
		location = new Point(125, 105);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		((TextBoxBase)txtTk).MaxLength = 20;
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk;
		AsTextBox asTextBox3 = txtTk;
		size = new Size(90, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 3;
		((Control)txtTk).Tag = "@pTk";
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj15 = lblTen_Tk;
		location = new Point(221, 108);
		((Control)obj15).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj16 = lblTen_Tk;
		size = new Size(324, 13);
		((Control)obj16).Size = size;
		((Control)lblTen_Tk).TabIndex = 1025;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj17 = lblTk;
		location = new Point(24, 108);
		((Control)obj17).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj18 = lblTk;
		size = new Size(58, 13);
		((Control)obj18).Size = size;
		((Control)lblTk).TabIndex = 1024;
		lblTk.Text = "Tài khoản ";
		lblTen_nv.ImeMode = (ImeMode)0;
		Label obj19 = lblTen_nv;
		location = new Point(221, 134);
		((Control)obj19).Location = location;
		((Control)lblTen_nv).Name = "lblTen_nv";
		Label obj20 = lblTen_nv;
		size = new Size(324, 13);
		((Control)obj20).Size = size;
		((Control)lblTen_nv).TabIndex = 1028;
		lblTen_nv.TextAlign = (ContentAlignment)16;
		lblMa_nv.AutoSize = true;
		lblMa_nv.ImeMode = (ImeMode)0;
		Label obj21 = lblMa_nv;
		location = new Point(24, 134);
		((Control)obj21).Location = location;
		((Control)lblMa_nv).Name = "lblMa_nv";
		Label obj22 = lblMa_nv;
		size = new Size(56, 13);
		((Control)obj22).Size = size;
		((Control)lblMa_nv).TabIndex = 1027;
		lblMa_nv.Text = "Nhân viên";
		lblTen_nh_kh.ImeMode = (ImeMode)0;
		Label obj23 = lblTen_nh_kh;
		location = new Point(221, 160);
		((Control)obj23).Location = location;
		((Control)lblTen_nh_kh).Name = "lblTen_nh_kh";
		Label obj24 = lblTen_nh_kh;
		size = new Size(324, 13);
		((Control)obj24).Size = size;
		((Control)lblTen_nh_kh).TabIndex = 1031;
		lblTen_nh_kh.TextAlign = (ContentAlignment)16;
		lblMa_Nh_kh.AutoSize = true;
		lblMa_Nh_kh.ImeMode = (ImeMode)0;
		Label obj25 = lblMa_Nh_kh;
		location = new Point(24, 160);
		((Control)obj25).Location = location;
		((Control)lblMa_Nh_kh).Name = "lblMa_Nh_kh";
		Label obj26 = lblMa_Nh_kh;
		size = new Size(95, 13);
		((Control)obj26).Size = size;
		((Control)lblMa_Nh_kh).TabIndex = 1030;
		lblMa_Nh_kh.Text = "Nhóm khách hàng";
		txtNV.AutoLookup = true;
		txtNV.AutoValid = false;
		((TextBoxBase)txtNV).BackColor = SystemColors.Info;
		((TextBox)txtNV).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtNV;
		location = new Point(125, 131);
		((Control)asTextBox4).Location = location;
		txtNV.LookupCodeName = "MA_KH";
		((TextBoxBase)txtNV).MaxLength = 20;
		((Control)txtNV).Name = "txtNV";
		txtNV.NameControl = lblTen_nv;
		AsTextBox asTextBox5 = txtNV;
		size = new Size(90, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtNV).TabIndex = 4;
		txtNh_kh.AutoLookup = true;
		txtNh_kh.AutoValid = false;
		((TextBoxBase)txtNh_kh).BackColor = SystemColors.Info;
		((TextBox)txtNh_kh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtNh_kh;
		location = new Point(125, 157);
		((Control)asTextBox6).Location = location;
		txtNh_kh.LookupCodeName = "MA_NHKH";
		((TextBoxBase)txtNh_kh).MaxLength = 20;
		((Control)txtNh_kh).Name = "txtNh_kh";
		txtNh_kh.NameControl = lblTen_nh_kh;
		AsTextBox asTextBox7 = txtNh_kh;
		size = new Size(90, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtNh_kh).TabIndex = 5;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(686, 342);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCARptTMNH04";
		((Form)this).Text = "frmCARptTMNH04";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		base.InitOtherComponents();
		((TextBox)txtTk).Text = base.MyMenuInfo.par1;
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(((TextBox)txtTk).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtNV).Text);
		arrayList.Add(((TextBox)txtNh_kh).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		text = text + lblKyBc.Text + ": " + ((MaskedTextBox)txtNgay1).Text + lbl2.Text + ((MaskedTextBox)txtNgay2).Text + "; ";
		if (Operators.CompareString(((TextBox)txtTk).Text, "", false) != 0)
		{
			text = text + lblTk.Text + ": " + ((TextBox)txtTk).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtNV).Text, "", false) != 0)
		{
			text = text + lblMa_nv.Text + ": " + ((TextBox)txtNV).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtNh_kh).Text, "", false) != 0)
		{
			text = text + lblMa_Nh_kh.Text + ": " + ((TextBox)txtNh_kh).Text + "; ";
		}
		if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
		{
			text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
		}
		if (text.Length > 2)
		{
			text = text.Substring(0, checked(text.Length - 2));
		}
		return text;
	}
}
