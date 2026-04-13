using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCORptGt01 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtNam")]
	private AsTextNumeric _txtNam;

	[AccessedThroughProperty("txtThang2")]
	private AsTextNumeric _txtThang2;

	[AccessedThroughProperty("txtThang1")]
	private AsTextNumeric _txtThang1;

	[AccessedThroughProperty("txtMA_SPCT")]
	private AsTextBox _txtMA_SPCT;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("chkCt_vt")]
	private CheckBox _chkCt_vt;

	private string Ten_tk;

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

	private virtual Label Label1
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

	internal virtual AsTextNumeric txtNam
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNam = value;
		}
	}

	internal virtual AsTextNumeric txtThang2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtThang2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtThang2 = value;
		}
	}

	internal virtual AsTextNumeric txtThang1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtThang1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtThang1 = value;
		}
	}

	private virtual AsTextBox txtMA_SPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMA_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMA_SPCT = value;
		}
	}

	private virtual Label Label2
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

	private virtual Label Label3
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

	private virtual Label Label4
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

	internal virtual CheckBox chkCt_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkCt_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkCt_vt = value;
		}
	}

	public frmCORptGt01(string menuid)
		: base(menuid)
	{
		((Form)this).Load += frmCOGDBGT_Load;
		Ten_tk = "";
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		txtTk = new AsTextBox();
		lblTen_Tk = new Label();
		lblTk = new Label();
		Label1 = new Label();
		txtThang1 = new AsTextNumeric();
		txtThang2 = new AsTextNumeric();
		txtNam = new AsTextNumeric();
		txtMA_SPCT = new AsTextBox();
		Label2 = new Label();
		Label3 = new Label();
		chkCt_vt = new CheckBox();
		Label4 = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(564, 260);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)Label4);
		((Control)tabFilter).Controls.Add((Control)(object)chkCt_vt);
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)Label2);
		((Control)tabFilter).Controls.Add((Control)(object)Label3);
		((Control)tabFilter).Controls.Add((Control)(object)txtNam);
		((Control)tabFilter).Controls.Add((Control)(object)txtThang2);
		((Control)tabFilter).Controls.Add((Control)(object)txtThang1);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		TabPage obj = tabFilter;
		size = new Size(556, 231);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtThang1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtThang2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNam, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)chkCt_vt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label4, 0);
		Label obj2 = lbl2;
		Point location = new Point(148, 272);
		((Control)obj2).Location = location;
		((Control)lbl2).Visible = false;
		Button obj3 = cmdExcel;
		location = new Point(700, 266);
		((Control)obj3).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new Point(619, 266);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new Point(455, 24);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 10;
		((Control)txtNgay1).TabIndex = 1;
		((Control)cboKyBc).TabIndex = 0;
		myHelpProvider.SetHelpKeyword((Control)(object)cboMau_bc, "");
		myHelpProvider.SetHelpString((Control)(object)cboMau_bc, "");
		myHelpProvider.SetShowHelp((Control)(object)cboMau_bc, false);
		((Control)cboMau_bc).TabIndex = 9;
		((Control)cboMau_bc).TabStop = false;
		Label obj6 = lblMau_bc;
		location = new Point(24, 29);
		((Control)obj6).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(209, 192);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 6;
		((Control)txtMa_Nt).Visible = false;
		Label obj7 = lblMauBC;
		location = new Point(254, 191);
		((Control)obj7).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj8 = optVND;
		location = new Point(341, 190);
		((Control)obj8).Location = location;
		((Control)optVND).Visible = false;
		RadioButton obj9 = optNt;
		location = new Point(395, 191);
		((Control)obj9).Location = location;
		((Control)optNt).Visible = false;
		Label obj10 = lblMa_nt;
		location = new Point(123, 194);
		((Control)obj10).Location = location;
		((Control)lblMa_nt).Visible = false;
		myHelpProvider.SetHelpKeyword((Control)(object)cmdOk, "");
		myHelpProvider.SetHelpString((Control)(object)cmdOk, "");
		Button obj11 = cmdOk;
		location = new Point(27, 187);
		((Control)obj11).Location = location;
		myHelpProvider.SetShowHelp((Control)(object)cmdOk, false);
		((Control)txtTieu_De).TabIndex = 11;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj12 = tabGrid;
		size = new Size(556, 231);
		((Control)obj12).Size = size;
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = true;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		myHelpProvider.SetHelpKeyword((Control)(object)txtTk, "Tài khoản lên báo cáo");
		myHelpProvider.SetHelpString((Control)(object)txtTk, "Tài khoản lên báo cáo");
		AsTextBox asTextBox2 = txtTk;
		location = new Point(110, 105);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk;
		myHelpProvider.SetShowHelp((Control)(object)txtTk, true);
		AsTextBox asTextBox3 = txtTk;
		size = new Size(82, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 3;
		((Control)txtTk).Tag = "@pTk";
		txtTk.UseAutoCompleteSource = true;
		txtTk.ValidReturnFieldList = "TEN_TK";
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj13 = lblTen_Tk;
		location = new Point(198, 109);
		((Control)obj13).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj14 = lblTen_Tk;
		size = new Size(328, 13);
		((Control)obj14).Size = size;
		((Control)lblTen_Tk).TabIndex = 1017;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj15 = lblTk;
		location = new Point(24, 109);
		((Control)obj15).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj16 = lblTk;
		size = new Size(55, 13);
		((Control)obj16).Size = size;
		((Control)lblTk).TabIndex = 1016;
		lblTk.Text = "Tài khoản";
		Label1.AutoSize = true;
		Label1.ImeMode = (ImeMode)0;
		Label label = Label1;
		location = new Point(29, 272);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(50, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1018;
		Label1.Text = "Từ tháng";
		((Control)Label1).Visible = false;
		txtThang1.DecimalSymbol = ".";
		txtThang1.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtThang1;
		location = new Point(115, 269);
		((Control)asTextNumeric).Location = location;
		txtThang1.Mask = "##";
		((Control)txtThang1).Name = "txtThang1";
		AsTextNumeric asTextNumeric2 = txtThang1;
		size = new Size(27, 20);
		((Control)asTextNumeric2).Size = size;
		txtThang1.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtThang1).TabIndex = 1019;
		((TextBox)txtThang1).Text = "0";
		((TextBox)txtThang1).TextAlign = (HorizontalAlignment)1;
		txtThang1.Value = 0;
		((Control)txtThang1).Visible = false;
		txtThang2.DecimalSymbol = ".";
		txtThang2.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtThang2;
		location = new Point(170, 269);
		((Control)asTextNumeric3).Location = location;
		txtThang2.Mask = "##";
		((Control)txtThang2).Name = "txtThang2";
		AsTextNumeric asTextNumeric4 = txtThang2;
		size = new Size(27, 20);
		((Control)asTextNumeric4).Size = size;
		txtThang2.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtThang2).TabIndex = 1020;
		((TextBox)txtThang2).Text = "0";
		((TextBox)txtThang2).TextAlign = (HorizontalAlignment)1;
		txtThang2.Value = 0;
		((Control)txtThang2).Visible = false;
		txtNam.DecimalSymbol = ".";
		txtNam.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtNam;
		location = new Point(203, 269);
		((Control)asTextNumeric5).Location = location;
		txtNam.Mask = "####";
		((Control)txtNam).Name = "txtNam";
		AsTextNumeric asTextNumeric6 = txtNam;
		size = new Size(36, 20);
		((Control)asTextNumeric6).Size = size;
		txtNam.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtNam).TabIndex = 1021;
		((TextBox)txtNam).Text = "0";
		((TextBox)txtNam).TextAlign = (HorizontalAlignment)1;
		txtNam.Value = 0;
		((Control)txtNam).Visible = false;
		((TextBox)txtMA_SPCT).AutoCompleteSource = (AutoCompleteSource)64;
		txtMA_SPCT.AutoLookup = true;
		txtMA_SPCT.AutoValid = false;
		((TextBoxBase)txtMA_SPCT).BackColor = SystemColors.Info;
		((TextBox)txtMA_SPCT).CharacterCasing = (CharacterCasing)1;
		myHelpProvider.SetHelpKeyword((Control)(object)txtMA_SPCT, "Tài khoản lên báo cáo");
		myHelpProvider.SetHelpString((Control)(object)txtMA_SPCT, "Tài khoản lên báo cáo");
		AsTextBox asTextBox4 = txtMA_SPCT;
		location = new Point(110, 131);
		((Control)asTextBox4).Location = location;
		txtMA_SPCT.LookupCodeName = "MA_SPCT";
		((Control)txtMA_SPCT).Name = "txtMA_SPCT";
		txtMA_SPCT.NameControl = Label2;
		myHelpProvider.SetShowHelp((Control)(object)txtMA_SPCT, true);
		AsTextBox asTextBox5 = txtMA_SPCT;
		size = new Size(82, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMA_SPCT).TabIndex = 4;
		((Control)txtMA_SPCT).Tag = "@pTk";
		txtMA_SPCT.UseAutoCompleteSource = true;
		txtMA_SPCT.ValidReturnFieldList = "TEN_SPCT";
		Label2.ImeMode = (ImeMode)0;
		Label label3 = Label2;
		location = new Point(198, 135);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(328, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 1024;
		Label2.TextAlign = (ContentAlignment)16;
		Label3.AutoSize = true;
		Label3.ImeMode = (ImeMode)0;
		Label label5 = Label3;
		location = new Point(24, 135);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(53, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 1023;
		Label3.Text = "Mã SPCT";
		((ButtonBase)chkCt_vt).AutoSize = true;
		CheckBox obj17 = chkCt_vt;
		location = new Point(110, 158);
		((Control)obj17).Location = location;
		((Control)chkCt_vt).Name = "chkCt_vt";
		CheckBox obj18 = chkCt_vt;
		size = new Size(15, 14);
		((Control)obj18).Size = size;
		((Control)chkCt_vt).TabIndex = 5;
		((ButtonBase)chkCt_vt).UseVisualStyleBackColor = true;
		Label4.AutoSize = true;
		Label4.ImeMode = (ImeMode)0;
		Label label7 = Label4;
		location = new Point(24, 158);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(80, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 1026;
		Label4.Text = "Chi tiết theo VT";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(564, 285);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCORptGt01";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool LoadData()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(((TextBox)txtMA_SPCT).Text);
		arrayList.Add(((TextBox)txtTk).Text);
		arrayList.Add(chkCt_vt.Checked);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		return true;
	}

	protected override bool ValidData()
	{
		if (!base.ValidData() || !ChkEmtyTextBox((TextBox)(object)txtTk))
		{
			return false;
		}
		return true;
	}

	private void frmCOGDBGT_Load(object sender, EventArgs e)
	{
		((TextBox)txtTk).Text = MyMenuInfo.par1;
	}
}
