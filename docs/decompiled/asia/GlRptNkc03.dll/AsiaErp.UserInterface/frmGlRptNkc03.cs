using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGlRptNkc03 : frmReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

	[AccessedThroughProperty("txtMa_Bp")]
	private AsTextBox _txtMa_Bp;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	[AccessedThroughProperty("lblDs_Tk_Du")]
	private Label _lblDs_Tk_Du;

	[AccessedThroughProperty("lblDs_Tk")]
	private Label _lblDs_Tk;

	[AccessedThroughProperty("txtDs_Tk_Du")]
	private AsTextBox _txtDs_Tk_Du;

	[AccessedThroughProperty("txtDs_Tk")]
	private AsTextBox _txtDs_Tk;

	private bool Is_close;

	internal virtual Label lblTen_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_Bp = value;
		}
	}

	internal virtual AsTextBox txtMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Bp = value;
		}
	}

	internal virtual Label lblMa_Bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Bp = value;
		}
	}

	private virtual Label lblDs_Tk_Du
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDs_Tk_Du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDs_Tk_Du = value;
		}
	}

	private virtual Label lblDs_Tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDs_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDs_Tk = value;
		}
	}

	internal virtual AsTextBox txtDs_Tk_Du
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDs_Tk_Du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDs_Tk_Du = value;
		}
	}

	internal virtual AsTextBox txtDs_Tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDs_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDs_Tk_Validated;
			if (_txtDs_Tk != null)
			{
				((Control)_txtDs_Tk).Validated -= eventHandler;
			}
			_txtDs_Tk = value;
			if (_txtDs_Tk != null)
			{
				((Control)_txtDs_Tk).Validated += eventHandler;
			}
		}
	}

	public frmGlRptNkc03(string menuid)
		: base(menuid)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(frmGlRptNkc03_FormClosing);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		Is_close = false;
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
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_Bp = new Label();
		lblDs_Tk = new Label();
		lblDs_Tk_Du = new Label();
		txtDs_Tk = new AsTextBox();
		txtDs_Tk_Du = new AsTextBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(564, 287);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)txtDs_Tk_Du);
		((Control)tabFilter).Controls.Add((Control)(object)txtDs_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblDs_Tk_Du);
		((Control)tabFilter).Controls.Add((Control)(object)lblDs_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Bp);
		TabPage obj = tabFilter;
		size = new Size(556, 258);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDs_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblDs_Tk_Du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtDs_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtDs_Tk_Du, 0);
		Label obj2 = lbl2;
		Point location = new Point(279, 83);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new Point(700, 235);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(298, 79);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 235);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(457, 25);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 8;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new Point(208, 79);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new Point(112, 79);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		ComboBox obj7 = cboMau_bc;
		location = new Point(112, 26);
		((Control)obj7).Location = location;
		((Control)cboMau_bc).TabIndex = 7;
		((Control)cboMau_bc).TabStop = false;
		Label obj8 = lblMau_bc;
		location = new Point(24, 29);
		((Control)obj8).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(112, 184);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 6;
		Label obj9 = lblMauBC;
		location = new Point(157, 183);
		((Control)obj9).Location = location;
		RadioButton obj10 = optVND;
		location = new Point(244, 182);
		((Control)obj10).Location = location;
		RadioButton obj11 = optNt;
		location = new Point(298, 183);
		((Control)obj11).Location = location;
		Label obj12 = lblMa_nt;
		location = new Point(24, 185);
		((Control)obj12).Location = location;
		Button obj13 = cmdOk;
		location = new Point(27, 218);
		((Control)obj13).Location = location;
		((Control)cmdOk).TabIndex = 9;
		TextBox obj14 = txtTieu_De;
		location = new Point(112, 53);
		((Control)obj14).Location = location;
		((Control)txtTieu_De).TabIndex = 9;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj15 = tabGrid;
		size = new Size(556, 258);
		((Control)obj15).Size = size;
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj16 = lblTen_Bp;
		location = new Point(200, 162);
		((Control)obj16).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj17 = lblTen_Bp;
		size = new Size(366, 13);
		((Control)obj17).Size = size;
		((Control)lblTen_Bp).TabIndex = 1043;
		lblTen_Bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtMa_Bp;
		location = new Point(112, 158);
		((Control)asTextBox2).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox3 = txtMa_Bp;
		size = new Size(82, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtMa_Bp).TabIndex = 5;
		lblMa_Bp.AutoSize = true;
		lblMa_Bp.ImeMode = (ImeMode)0;
		Label obj18 = lblMa_Bp;
		location = new Point(24, 161);
		((Control)obj18).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj19 = lblMa_Bp;
		size = new Size(64, 13);
		((Control)obj19).Size = size;
		((Control)lblMa_Bp).TabIndex = 1042;
		lblMa_Bp.Text = "Mã bộ phận";
		lblDs_Tk.AutoSize = true;
		lblDs_Tk.ImeMode = (ImeMode)0;
		Label obj20 = lblDs_Tk;
		location = new Point(24, 109);
		((Control)obj20).Location = location;
		((Control)lblDs_Tk).Name = "lblDs_Tk";
		Label obj21 = lblDs_Tk;
		size = new Size(82, 13);
		((Control)obj21).Size = size;
		((Control)lblDs_Tk).TabIndex = 1045;
		lblDs_Tk.Text = "Ds tài khoản nợ";
		lblDs_Tk_Du.AutoSize = true;
		lblDs_Tk_Du.ImeMode = (ImeMode)0;
		Label obj22 = lblDs_Tk_Du;
		location = new Point(24, 135);
		((Control)obj22).Location = location;
		((Control)lblDs_Tk_Du).Name = "lblDs_Tk_Du";
		Label obj23 = lblDs_Tk_Du;
		size = new Size(82, 13);
		((Control)obj23).Size = size;
		((Control)lblDs_Tk_Du).TabIndex = 1047;
		lblDs_Tk_Du.Text = "Ds tài khoản có";
		txtDs_Tk.AutoLookup = true;
		txtDs_Tk.AutoValid = false;
		((TextBoxBase)txtDs_Tk).BackColor = Color.White;
		((TextBox)txtDs_Tk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtDs_Tk;
		location = new Point(112, 106);
		((Control)asTextBox4).Location = location;
		txtDs_Tk.LookupCodeName = "TK";
		((Control)txtDs_Tk).Name = "txtDs_Tk";
		txtDs_Tk.NameControl = null;
		AsTextBox asTextBox5 = txtDs_Tk;
		size = new Size(163, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtDs_Tk).TabIndex = 3;
		((Control)txtDs_Tk).Tag = "@pTk";
		txtDs_Tk_Du.AutoLookup = true;
		txtDs_Tk_Du.AutoValid = false;
		((TextBoxBase)txtDs_Tk_Du).BackColor = Color.White;
		((TextBox)txtDs_Tk_Du).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtDs_Tk_Du;
		location = new Point(112, 132);
		((Control)asTextBox6).Location = location;
		txtDs_Tk_Du.LookupCodeName = "TK";
		((Control)txtDs_Tk_Du).Name = "txtDs_Tk_Du";
		txtDs_Tk_Du.NameControl = null;
		AsTextBox asTextBox7 = txtDs_Tk_Du;
		size = new Size(163, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtDs_Tk_Du).TabIndex = 4;
		((Control)txtDs_Tk_Du).Tag = "@pTK";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(564, 312);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGlRptNkc03";
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
		((TextBox)txtDs_Tk).Text = base.MyMenuInfo.par2;
		((TextBox)txtDs_Tk_Du).Text = base.MyMenuInfo.par3;
	}

	protected override bool ValidData()
	{
		return base.ValidData();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtDs_Tk).Text);
		arrayList.Add(((TextBox)txtDs_Tk_Du).Text);
		arrayList.Add(((TextBox)txtMa_Bp).Text);
		arrayList.Add(((TextBox)txtMa_Nt).Text);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		return true;
	}

	private void txtDs_Tk_Validated(object sender, EventArgs e)
	{
		char[] array = ((TextBox)txtDs_Tk).Text.ToCharArray();
		checked
		{
			int num = ((TextBoxBase)txtDs_Tk).TextLength - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					if (((Strings.Asc(array[num2]) > 57 || Strings.Asc(array[num2]) < 48) && Strings.Asc(array[num2]) != 44) ? true : false)
					{
						epNotice.SetError((Control)(object)txtDs_Tk, Helper.GetMessContent(50017));
						((Control)txtDs_Tk).Select();
						break;
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void frmGlRptNkc03_FormClosing(object sender, FormClosingEventArgs e)
	{
		Is_close = true;
	}
}
