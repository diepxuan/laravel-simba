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
public class frmCORptGt02 : frmReport
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

	[AccessedThroughProperty("lblTen_SPCT")]
	private Label _lblTen_SPCT;

	[AccessedThroughProperty("lblMa_SPCT")]
	private Label _lblMa_SPCT;

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

	private virtual Label lblTen_SPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_SPCT = value;
		}
	}

	private virtual Label lblMa_SPCT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_SPCT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_SPCT = value;
		}
	}

	public frmCORptGt02(string menuid)
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
		txtTk = new AsTextBox();
		lblTen_Tk = new Label();
		lblTk = new Label();
		Label1 = new Label();
		txtThang1 = new AsTextNumeric();
		txtThang2 = new AsTextNumeric();
		txtNam = new AsTextNumeric();
		txtMA_SPCT = new AsTextBox();
		lblTen_SPCT = new Label();
		lblMa_SPCT = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(564, 250);
		((Control)asTabControl).Size = size;
		((Control)tabFilter).Controls.Add((Control)(object)txtMA_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_SPCT);
		((Control)tabFilter).Controls.Add((Control)(object)txtNam);
		((Control)tabFilter).Controls.Add((Control)(object)txtThang2);
		((Control)tabFilter).Controls.Add((Control)(object)txtThang1);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		TabPage obj = tabFilter;
		size = new Size(556, 221);
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_SPCT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMA_SPCT, 0);
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
		((Control)cmdModifyReport).TabIndex = 7;
		((Control)txtNgay1).TabIndex = 1;
		((Control)cboKyBc).TabIndex = 0;
		myHelpProvider.SetHelpKeyword((Control)(object)cboMau_bc, "");
		myHelpProvider.SetHelpString((Control)(object)cboMau_bc, "");
		myHelpProvider.SetShowHelp((Control)(object)cboMau_bc, false);
		((Control)cboMau_bc).TabIndex = 6;
		((Control)cboMau_bc).TabStop = false;
		Label obj6 = lblMau_bc;
		location = new Point(24, 29);
		((Control)obj6).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(209, 165);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 4;
		((Control)txtMa_Nt).Visible = false;
		Label obj7 = lblMauBC;
		location = new Point(254, 164);
		((Control)obj7).Location = location;
		((Control)lblMauBC).Visible = false;
		RadioButton obj8 = optVND;
		location = new Point(341, 163);
		((Control)obj8).Location = location;
		((Control)optVND).TabIndex = 5;
		((Control)optVND).Visible = false;
		RadioButton obj9 = optNt;
		location = new Point(395, 164);
		((Control)obj9).Location = location;
		((Control)optNt).TabIndex = 6;
		((Control)optNt).Visible = false;
		Label obj10 = lblMa_nt;
		location = new Point(123, 167);
		((Control)obj10).Location = location;
		((Control)lblMa_nt).Visible = false;
		myHelpProvider.SetHelpKeyword((Control)(object)cmdOk, "");
		myHelpProvider.SetHelpString((Control)(object)cmdOk, "");
		Button obj11 = cmdOk;
		location = new Point(27, 167);
		((Control)obj11).Location = location;
		myHelpProvider.SetShowHelp((Control)(object)cmdOk, false);
		((Control)cmdOk).TabIndex = 5;
		((Control)txtTieu_De).TabIndex = 8;
		((Control)txtTieu_De).TabStop = false;
		TabPage obj12 = tabGrid;
		size = new Size(556, 221);
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
		txtMA_SPCT.NameControl = lblTen_SPCT;
		myHelpProvider.SetShowHelp((Control)(object)txtMA_SPCT, true);
		AsTextBox asTextBox5 = txtMA_SPCT;
		size = new Size(82, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMA_SPCT).TabIndex = 4;
		((Control)txtMA_SPCT).Tag = "@pTk";
		txtMA_SPCT.UseAutoCompleteSource = true;
		txtMA_SPCT.ValidReturnFieldList = "TEN_SPCT";
		lblTen_SPCT.ImeMode = (ImeMode)0;
		Label obj17 = lblTen_SPCT;
		location = new Point(198, 135);
		((Control)obj17).Location = location;
		((Control)lblTen_SPCT).Name = "lblTen_SPCT";
		Label obj18 = lblTen_SPCT;
		size = new Size(328, 13);
		((Control)obj18).Size = size;
		((Control)lblTen_SPCT).TabIndex = 1027;
		lblTen_SPCT.TextAlign = (ContentAlignment)16;
		lblMa_SPCT.AutoSize = true;
		lblMa_SPCT.ImeMode = (ImeMode)0;
		Label obj19 = lblMa_SPCT;
		location = new Point(24, 135);
		((Control)obj19).Location = location;
		((Control)lblMa_SPCT).Name = "lblMa_SPCT";
		Label obj20 = lblMa_SPCT;
		size = new Size(53, 13);
		((Control)obj20).Size = size;
		((Control)lblMa_SPCT).TabIndex = 1026;
		lblMa_SPCT.Text = "Mã SPCT";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(564, 275);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCORptGt02";
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
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
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

	private string GetFilterTitle()
	{
		string text = string.Empty;
		if (Operators.CompareString(((TextBox)txtTk).Text.Trim(), "", false) != 0)
		{
			text = text + lblTk.Text + ": [" + ((TextBox)txtTk).Text + " - " + lblTen_Tk.Text + "]; ";
		}
		if (Operators.CompareString(((TextBox)txtMA_SPCT).Text.Trim(), "", false) != 0)
		{
			text = text + lblMa_SPCT.Text + ": [" + ((TextBox)txtMA_SPCT).Text + " - " + lblTen_SPCT.Text + "]; ";
		}
		return text;
	}
}
