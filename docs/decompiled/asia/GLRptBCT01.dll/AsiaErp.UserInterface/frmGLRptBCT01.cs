using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGLRptBCT01 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("lblSo_Ct1")]
	private Label _lblSo_Ct1;

	[AccessedThroughProperty("txtTk_Du")]
	private AsTextBox _txtTk_Du;

	[AccessedThroughProperty("lblTen_Tk_Du")]
	private Label _lblTen_Tk_Du;

	[AccessedThroughProperty("lblTk_Du")]
	private Label _lblTk_Du;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

	[AccessedThroughProperty("txtMa_Bp")]
	private AsTextBox _txtMa_Bp;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	[AccessedThroughProperty("txtThue_suat")]
	private AsTextNumeric _txtThue_suat;

	private Application excelapp;

	private Workbook wBook;

	private Worksheet wSheet;

	private Microsoft.Office.Interop.Excel.Range range;

	private int colIndex;

	private int rowIndex;

	private int startIndex;

	private int i;

	internal virtual Label lblSo_Ct1
	{
		get
		{
			return _lblSo_Ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblSo_Ct1 = value;
		}
	}

	private virtual AsTextBox txtTk_Du
	{
		get
		{
			return _txtTk_Du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTk_Du = value;
		}
	}

	private virtual Label lblTen_Tk_Du
	{
		get
		{
			return _lblTen_Tk_Du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Tk_Du = value;
		}
	}

	private virtual Label lblTk_Du
	{
		get
		{
			return _lblTk_Du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTk_Du = value;
		}
	}

	private virtual AsTextBox txtTk
	{
		get
		{
			return _txtTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTk = value;
		}
	}

	private virtual Label lblTen_Tk
	{
		get
		{
			return _lblTen_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Tk = value;
		}
	}

	private virtual Label lblTk
	{
		get
		{
			return _lblTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTk = value;
		}
	}

	internal virtual Label lblTen_Bp
	{
		get
		{
			return _lblTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Bp = value;
		}
	}

	internal virtual AsTextBox txtMa_Bp
	{
		get
		{
			return _txtMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_Bp = value;
		}
	}

	internal virtual Label lblMa_Bp
	{
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_Bp = value;
		}
	}

	internal virtual AsTextNumeric txtThue_suat
	{
		get
		{
			return _txtThue_suat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtThue_suat = value;
		}
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

	public frmGLRptBCT01(string MenuId)
		: base(MenuId)
	{
		colIndex = 1;
		rowIndex = 1;
		startIndex = 18;
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8d: Expected O, but got Unknown
		lblSo_Ct1 = new Label();
		txtTk = new AsTextBox();
		lblTen_Tk = new Label();
		lblTk = new Label();
		txtTk_Du = new AsTextBox();
		lblTen_Tk_Du = new Label();
		lblTk_Du = new Label();
		lblTen_Bp = new Label();
		txtMa_Bp = new AsTextBox();
		lblMa_Bp = new Label();
		txtThue_suat = new AsTextNumeric();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(754, 392);
		((Control)asTabControl).Size = size;
		((ScrollableControl)tabFilter).AutoScroll = false;
		((Control)tabFilter).Controls.Add((Control)(object)txtThue_suat);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_Bp);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk_Du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk_Du);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk_Du);
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblSo_Ct1);
		TabPage obj = tabFilter;
		size = new Size(746, 363);
		((Control)obj).Size = size;
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
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblSo_Ct1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk_Du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk_Du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk_Du, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtThue_suat, 0);
		Label obj2 = lbl2;
		System.Drawing.Point location = new System.Drawing.Point(280, 81);
		((Control)obj2).Location = location;
		Button obj3 = cmdExcel;
		location = new System.Drawing.Point(700, 564);
		((Control)obj3).Location = location;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new System.Drawing.Point(299, 77);
		((Control)asMaskedTextBox).Location = location;
		((Control)txtNgay2).TabIndex = 2;
		Button obj4 = cmdCancel;
		location = new System.Drawing.Point(619, 564);
		((Control)obj4).Location = location;
		Button obj5 = cmdModifyReport;
		location = new System.Drawing.Point(458, 23);
		((Control)obj5).Location = location;
		((Control)cmdModifyReport).TabIndex = 25;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		location = new System.Drawing.Point(209, 77);
		((Control)asMaskedTextBox2).Location = location;
		((Control)txtNgay1).TabIndex = 1;
		ComboBox obj6 = cboKyBc;
		location = new System.Drawing.Point(113, 77);
		((Control)obj6).Location = location;
		((Control)cboKyBc).TabIndex = 0;
		Label obj7 = lblKyBc;
		location = new System.Drawing.Point(27, 81);
		((Control)obj7).Location = location;
		ComboBox obj8 = cboMau_bc;
		location = new System.Drawing.Point(113, 24);
		((Control)obj8).Location = location;
		((Control)cboMau_bc).TabIndex = 24;
		Label obj9 = lblMau_bc;
		location = new System.Drawing.Point(27, 28);
		((Control)obj9).Location = location;
		AsTextBox asTextBox = txtMa_Nt;
		location = new System.Drawing.Point(264, 260);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 20;
		((Control)txtMa_Nt).Visible = false;
		Label obj10 = lblMauBC;
		location = new System.Drawing.Point(186, 257);
		((Control)obj10).Location = location;
		((Control)lblMauBC).TabIndex = 21;
		((Control)lblMauBC).Visible = false;
		RadioButton obj11 = optVND;
		location = new System.Drawing.Point(469, 257);
		((Control)obj11).Location = location;
		((Control)optVND).TabIndex = 22;
		((Control)optVND).Visible = false;
		RadioButton obj12 = optNt;
		location = new System.Drawing.Point(392, 258);
		((Control)obj12).Location = location;
		((Control)optNt).TabIndex = 23;
		((Control)optNt).Visible = false;
		Label obj13 = lblMa_nt;
		location = new System.Drawing.Point(322, 262);
		((Control)obj13).Location = location;
		((Control)lblMa_nt).Visible = false;
		Button obj14 = cmdOk;
		location = new System.Drawing.Point(30, 214);
		((Control)obj14).Location = location;
		((Control)cmdOk).TabIndex = 9;
		Label obj15 = lblTieu_de;
		location = new System.Drawing.Point(27, 55);
		((Control)obj15).Location = location;
		TextBox obj16 = txtTieu_De;
		location = new System.Drawing.Point(113, 51);
		((Control)obj16).Location = location;
		((Control)txtTieu_De).TabIndex = 26;
		TabPage obj17 = tabGrid;
		size = new Size(589, 296);
		((Control)obj17).Size = size;
		lblSo_Ct1.AutoSize = true;
		Label obj18 = lblSo_Ct1;
		location = new System.Drawing.Point(27, 108);
		((Control)obj18).Location = location;
		((Control)lblSo_Ct1).Name = "lblSo_Ct1";
		Label obj19 = lblSo_Ct1;
		size = new Size(55, 13);
		((Control)obj19).Size = size;
		((Control)lblSo_Ct1).TabIndex = 1022;
		lblSo_Ct1.Text = "Thuế suất";
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = true;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTk;
		location = new System.Drawing.Point(113, 130);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk;
		AsTextBox asTextBox3 = txtTk;
		size = new Size(82, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 4;
		((Control)txtTk).Tag = "@pTk";
		txtTk.UseAutoCompleteSource = true;
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj20 = lblTen_Tk;
		location = new System.Drawing.Point(201, 134);
		((Control)obj20).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj21 = lblTen_Tk;
		size = new Size(332, 13);
		((Control)obj21).Size = size;
		((Control)lblTen_Tk).TabIndex = 1026;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj22 = lblTk;
		location = new System.Drawing.Point(27, 134);
		((Control)obj22).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj23 = lblTk;
		size = new Size(79, 13);
		((Control)obj23).Size = size;
		((Control)lblTk).TabIndex = 1025;
		lblTk.Text = "Tài khoản thuế";
		((TextBox)txtTk_Du).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk_Du.AutoLookup = true;
		txtTk_Du.AutoValid = true;
		((TextBoxBase)txtTk_Du).BackColor = SystemColors.Info;
		((TextBox)txtTk_Du).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtTk_Du;
		location = new System.Drawing.Point(113, 156);
		((Control)asTextBox4).Location = location;
		txtTk_Du.LookupCodeName = "TK";
		((Control)txtTk_Du).Name = "txtTk_Du";
		txtTk_Du.NameControl = lblTen_Tk_Du;
		AsTextBox asTextBox5 = txtTk_Du;
		size = new Size(82, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtTk_Du).TabIndex = 5;
		((Control)txtTk_Du).Tag = "@pTk";
		txtTk_Du.UseAutoCompleteSource = true;
		lblTen_Tk_Du.ImeMode = (ImeMode)0;
		Label obj24 = lblTen_Tk_Du;
		location = new System.Drawing.Point(201, 160);
		((Control)obj24).Location = location;
		((Control)lblTen_Tk_Du).Name = "lblTen_Tk_Du";
		Label obj25 = lblTen_Tk_Du;
		size = new Size(332, 13);
		((Control)obj25).Size = size;
		((Control)lblTen_Tk_Du).TabIndex = 1030;
		lblTen_Tk_Du.TextAlign = (ContentAlignment)16;
		lblTk_Du.AutoSize = true;
		lblTk_Du.ImeMode = (ImeMode)0;
		Label obj26 = lblTk_Du;
		location = new System.Drawing.Point(27, 160);
		((Control)obj26).Location = location;
		((Control)lblTk_Du).Name = "lblTk_Du";
		Label obj27 = lblTk_Du;
		size = new Size(76, 13);
		((Control)obj27).Size = size;
		((Control)lblTk_Du).TabIndex = 1029;
		lblTk_Du.Text = "Tài khoản đ/ư";
		lblTen_Bp.ImeMode = (ImeMode)0;
		Label obj28 = lblTen_Bp;
		location = new System.Drawing.Point(201, 186);
		((Control)obj28).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj29 = lblTen_Bp;
		size = new Size(332, 13);
		((Control)obj29).Size = size;
		((Control)lblTen_Bp).TabIndex = 1062;
		lblTen_Bp.TextAlign = (ContentAlignment)16;
		((TextBox)txtMa_Bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_Bp.AutoLookup = true;
		txtMa_Bp.AutoValid = false;
		((TextBoxBase)txtMa_Bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_Bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_Bp;
		location = new System.Drawing.Point(113, 182);
		((Control)asTextBox6).Location = location;
		txtMa_Bp.LookupCodeName = "MA_BP";
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		txtMa_Bp.NameControl = lblTen_Bp;
		AsTextBox asTextBox7 = txtMa_Bp;
		size = new Size(82, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_Bp).TabIndex = 6;
		txtMa_Bp.UseAutoCompleteSource = true;
		lblMa_Bp.AutoSize = true;
		lblMa_Bp.ImeMode = (ImeMode)0;
		Label obj30 = lblMa_Bp;
		location = new System.Drawing.Point(27, 186);
		((Control)obj30).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj31 = lblMa_Bp;
		size = new Size(64, 13);
		((Control)obj31).Size = size;
		((Control)lblMa_Bp).TabIndex = 1061;
		lblMa_Bp.Text = "Mã bộ phận";
		txtThue_suat.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtThue_suat;
		location = new System.Drawing.Point(113, 104);
		((Control)asTextNumeric).Location = location;
		txtThue_suat.Mask = "### ### ### ###.##";
		((Control)txtThue_suat).Name = "txtThue_suat";
		AsTextNumeric asTextNumeric2 = txtThue_suat;
		size = new Size(82, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtThue_suat).TabIndex = 3;
		((TextBox)txtThue_suat).Text = "0.00";
		((TextBox)txtThue_suat).TextAlign = (HorizontalAlignment)1;
		txtThue_suat.Value = 0.0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(754, 417);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmGLRptBCT01";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitOtherComponents()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		base.InitOtherComponents();
		((Control)txtTieu_De).TabStop = false;
		((Control)cboMau_bc).TabStop = false;
		string value = AsiaErp.Framework.Environment.getLangSysMessageResX("#GLRPTBCT_2EXCELHTKK_TEXT").value;
		((ToolStripDropDownItem)tsdbExt).DropDownItems.Add((ToolStripItem)new ToolStripMenuItem(value, (Image)null, (EventHandler)([SpecialName] [DebuggerStepThrough] (object a0, EventArgs a1) =>
		{
			Ex2Excel_HTKK();
		})));
	}

	protected override bool LoadData()
	{
		if (cboMau_bc.SelectedIndex == -1)
		{
			return false;
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtThue_suat.Value));
		arrayList.Add(((TextBox)txtTk).Text);
		arrayList.Add(((TextBox)txtTk_Du).Text);
		arrayList.Add(((TextBox)txtMa_Bp).Text);
		arrayList.Add(cboMau_bc.SelectedIndex);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		return true;
	}

	private void Ex2Excel_HTKK()
	{
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (get_MyDGVSource(isSet2Print: true) == null || get_MyDGVSource(isSet2Print: true).Columns.Count == 0 || get_MyDGVSource(isSet2Print: true).Rows.Count == 0 || get_MyDGVSource(isSet2Print: true) == null || get_MyDGVSource(isSet2Print: true).Rows.Count == 0)
		{
			return;
		}
		string text = SystemInformations.ReportPath + "uTaIn.xls";
		if (!File.Exists(text))
		{
			CMessageBox.ShowWithFormat(50110, new object[1] { text });
			return;
		}
		string text2 = SystemInformations.RootPath + "\\Excels\\";
		string text3 = text2 + "BangKeThueVao_Thang" + Conversions.ToString(Conversions.ToDate(txtNgay1.Value).Month).Trim() + "_Nam_" + Conversions.ToDate(txtNgay1.Value).Year.ToString().Trim() + ".xls";
		try
		{
			if (!Directory.Exists(text2))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(text2);
			}
			else
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(text2);
			}
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
		}
		catch (IOException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			IOException ex2 = ex;
			CMessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
			return;
		}
		CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
		Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
		excelapp = new ApplicationClass();
		try
		{
			wBook = excelapp.Workbooks.Open(text, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
			wSheet = (Worksheet)wBook.ActiveSheet;
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[18, 1]), RuntimeHelpers.GetObjectValue(wSheet.Cells[40, 13]));
			range.Clear();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			CMessageBox.Show(50010);
			ProjectData.ClearProjectError();
			return;
		}
		colIndex = 1;
		rowIndex = 1;
		startIndex = 18;
		WriteOneGroupData("1", "2. Hàng hoá, dịch vụ không đủ điều kiện khấu trừ:");
		WriteOneGroupData("2", "3. Hàng hoá, dịch vụ dùng chung cho SXKD chịu thuế và không chịu thuế đủ điều kiện khấu trừ thuế:");
		WriteOneGroupData("3", "4.  Hàng hóa, dịch vụ dùng cho dự án đầu tư đủ điều kiện được khấu trừ thuế:");
		WriteOneGroupData("4", "5. Hàng hóa, dịch vụ không phải tổng hợp trên tờ khai 01/GTGT:");
		WriteOneGroupData("5", "");
		checked
		{
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 2]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 8]));
			range.Merge(true);
			NewLateBinding.LateSetComplex(range.Cells[1, 1], (Type)null, "value", new object[1] { "Tổng giá trị hàng hoá, dịch vụ mua vào:             ............................" }, (string[])null, (Type[])null, false, true);
			rowIndex++;
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 2]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 8]));
			range.Merge(true);
			NewLateBinding.LateSetComplex(range.Cells[1, 1], (Type)null, "value", new object[1] { "Tổng thuế GTGT của hàng hoá, dịch vụ mua vào:    ............................" }, (string[])null, (Type[])null, false, true);
			rowIndex += 2;
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 10]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 13]));
			range.Merge(true);
			range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
			NewLateBinding.LateSetComplex(range.Cells[1, 1], (Type)null, "value", new object[1] { "..............., ngày......... tháng........... năm.........." }, (string[])null, (Type[])null, false, true);
			rowIndex++;
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 10]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 14]));
			range.Merge(true);
			range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
			NewLateBinding.LateSetComplex(range.Cells[1, 1], (Type)null, "value", new object[1] { "NGƯỜI NỘP THUẾ HOẶC" }, (string[])null, (Type[])null, false, true);
			rowIndex++;
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 10]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 14]));
			range.Merge(true);
			range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
			NewLateBinding.LateSetComplex(range.Cells[1, 1], (Type)null, "value", new object[1] { "ĐẠI DIỆN HỢP PHÁP CỦA NGƯỜI NỘP THUẾ" }, (string[])null, (Type[])null, false, true);
			rowIndex++;
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 10]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 14]));
			range.Merge(true);
			range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
			NewLateBinding.LateSetComplex(range.Cells[1, 1], (Type)null, "value", new object[1] { "Ký tên, đóng dấu (ghi rõ họ tên và chức vụ)" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(wSheet.Columns[10, Missing.Value], (Type)null, "AutoFit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(wSheet.Columns[11, Missing.Value], (Type)null, "AutoFit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(wSheet.Columns[12, Missing.Value], (Type)null, "AutoFit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			wBook.SaveAs(text3, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
			excelapp.Visible = true;
			Marshal.ReleaseComObject(wSheet);
			wSheet = null;
			Marshal.ReleaseComObject(wBook);
			wBook = null;
			Marshal.ReleaseComObject(excelapp);
			excelapp = null;
			Thread.CurrentThread.CurrentCulture = currentCulture;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	private void WriteOneGroupData(string sMau_bc, string sNextGroupTitle)
	{
		string filterExpression = "mau_bc='" + sMau_bc + "' and ma_ct<>'' and bold='0'";
		this.i = 1;
		DataRow[] array = get_MyDGVSource(isSet2Print: true).Select(filterExpression, "ngay_hd,so_hd");
		checked
		{
			if (array.Length > 0)
			{
				int num = array.Length;
				int count = get_MyDGVSource(isSet2Print: true).Columns.Count;
				object[,] array2 = new object[num - 1 + 1, count - 1 + 1];
				range = null;
				int num2 = num - 1;
				for (int i = 0; i <= num2; i++)
				{
					rowIndex++;
					DataRow dataRow = array[i];
					int num3 = count - 1;
					for (int j = 0; j <= num3; j++)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(dataRow[j]);
						array2[i, j] = RuntimeHelpers.GetObjectValue(objectValue);
					}
				}
				range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - 2, 2]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - num - 1, 13]));
				range.Clear();
				range.NumberFormat = "@";
				range.Value2 = array2;
				range.WrapText = false;
				try
				{
					range.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
					range.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
					range.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
					range.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
					range.Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - 2, 2]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - num - 1, 5]));
				range.NumberFormat = "@";
				range.HorizontalAlignment = XlHAlign.xlHAlignLeft;
				range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - 2, 6]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - num - 1, 6]));
				range.NumberFormat = "dd/mm/yyyy";
				range.HorizontalAlignment = XlHAlign.xlHAlignLeft;
				range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - 2, 7]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - num - 1, 9]));
				range.NumberFormat = "@";
				range.HorizontalAlignment = XlHAlign.xlHAlignLeft;
				range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - 2, 10]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - num - 1, 10]));
				range.NumberFormat = "#,##";
				range.HorizontalAlignment = XlHAlign.xlHAlignRight;
				range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - 2, 11]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - num - 1, 11]));
				range.NumberFormat = "@";
				range.HorizontalAlignment = XlHAlign.xlHAlignLeft;
				range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - 2, 12]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - num - 1, 12]));
				range.NumberFormat = "#,##";
				range.HorizontalAlignment = XlHAlign.xlHAlignRight;
				range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - 2, 13]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - num - 1, 13]));
				range.NumberFormat = "@";
				range.HorizontalAlignment = XlHAlign.xlHAlignLeft;
				rowIndex--;
			}
			else
			{
				range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - 1, 2]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex - 1, 13]));
				try
				{
					range.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
					range.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
					range.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
					range.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
					range.Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
			}
			range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 2]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 13]));
			range.Font.Bold = true;
			try
			{
				range.Borders.LineStyle = XlLineStyle.xlContinuous;
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
			NewLateBinding.LateSetComplex(range.Cells[1, 1], (Type)null, "value", new object[1] { "Tổng" }, (string[])null, (Type[])null, false, true);
			if (Operators.CompareString(sNextGroupTitle, "", false) != 0)
			{
				rowIndex++;
				range = ((_Worksheet)wSheet).get_Range(RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 2]), RuntimeHelpers.GetObjectValue(wSheet.Cells[startIndex + rowIndex, 13]));
				try
				{
					range.Borders.LineStyle = XlLineStyle.xlContinuous;
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.ClearProjectError();
				}
				range.Merge(true);
				NewLateBinding.LateSetComplex(range.Cells[1, 1], (Type)null, "value", new object[1] { sNextGroupTitle }, (string[])null, (Type[])null, false, true);
			}
			rowIndex += 2;
		}
	}
}
