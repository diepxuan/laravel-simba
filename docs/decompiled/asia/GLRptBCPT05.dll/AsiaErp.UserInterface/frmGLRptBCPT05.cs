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
public class frmGLRptBCPT05 : frmReport
{
	private IContainer components;

	[AccessedThroughProperty("txtTk")]
	private AsTextBox _txtTk;

	[AccessedThroughProperty("lblTen_Tk")]
	private Label _lblTen_Tk;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("lblKieu_DT")]
	private Label _lblKieu_DT;

	[AccessedThroughProperty("txtMa_phi")]
	private AsTextBox _txtMa_phi;

	[AccessedThroughProperty("lblTen_phi")]
	private Label _lblTen_phi;

	[AccessedThroughProperty("lblMa_phi")]
	private Label _lblMa_phi;

	[AccessedThroughProperty("txtMa_bp")]
	private AsTextBox _txtMa_bp;

	[AccessedThroughProperty("lblTen_bp")]
	private Label _lblTen_bp;

	[AccessedThroughProperty("lblMa_bp")]
	private Label _lblMa_bp;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("cboNhom_cap4")]
	private AsComboBox _cboNhom_cap4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("cboNhom_cap3")]
	private AsComboBox _cboNhom_cap3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("cboNhom_cap2")]
	private AsComboBox _cboNhom_cap2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("cboNhom_cap1")]
	private AsComboBox _cboNhom_cap1;

	[AccessedThroughProperty("cboKieu_DT")]
	private AsComboBox _cboKieu_DT;

	private List<DictionaryEntry> DataSource4CBO;

	private bool isCboDatasourceLoading;

	private const string sDefaultSelected = "";

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

	internal virtual Label lblKieu_DT
	{
		get
		{
			return _lblKieu_DT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblKieu_DT = value;
		}
	}

	private virtual AsTextBox txtMa_phi
	{
		get
		{
			return _txtMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_phi = value;
		}
	}

	private virtual Label lblTen_phi
	{
		get
		{
			return _lblTen_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_phi = value;
		}
	}

	private virtual Label lblMa_phi
	{
		get
		{
			return _lblMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_phi = value;
		}
	}

	private virtual AsTextBox txtMa_bp
	{
		get
		{
			return _txtMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_bp = value;
		}
	}

	private virtual Label lblTen_bp
	{
		get
		{
			return _lblTen_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_bp = value;
		}
	}

	private virtual Label lblMa_bp
	{
		get
		{
			return _lblMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_bp = value;
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual AsComboBox cboNhom_cap4
	{
		get
		{
			return _cboNhom_cap4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboNhom_cap4 = value;
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual AsComboBox cboNhom_cap3
	{
		get
		{
			return _cboNhom_cap3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboNhom_cap3_SelectedIndexChanged;
			if (_cboNhom_cap3 != null)
			{
				((ListControl)_cboNhom_cap3).SelectedValueChanged -= eventHandler;
			}
			_cboNhom_cap3 = value;
			if (_cboNhom_cap3 != null)
			{
				((ListControl)_cboNhom_cap3).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual AsComboBox cboNhom_cap2
	{
		get
		{
			return _cboNhom_cap2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboNhom_cap2_SelectedIndexChanged;
			if (_cboNhom_cap2 != null)
			{
				((ListControl)_cboNhom_cap2).SelectedValueChanged -= eventHandler;
			}
			_cboNhom_cap2 = value;
			if (_cboNhom_cap2 != null)
			{
				((ListControl)_cboNhom_cap2).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	private virtual Label lblTen_spct
	{
		get
		{
			return _lblTen_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_spct = value;
		}
	}

	private virtual AsTextBox txtMa_spct
	{
		get
		{
			return _txtMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_spct = value;
		}
	}

	private virtual Label Label6
	{
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual AsComboBox cboNhom_cap1
	{
		get
		{
			return _cboNhom_cap1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboNhom_cap1_SelectedIndexChanged;
			if (_cboNhom_cap1 != null)
			{
				((ListControl)_cboNhom_cap1).SelectedValueChanged -= eventHandler;
			}
			_cboNhom_cap1 = value;
			if (_cboNhom_cap1 != null)
			{
				((ListControl)_cboNhom_cap1).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual AsComboBox cboKieu_DT
	{
		get
		{
			return _cboKieu_DT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboKieu_DT_SelectedIndexChanged;
			if (_cboKieu_DT != null)
			{
				((ComboBox)_cboKieu_DT).SelectedIndexChanged -= eventHandler;
			}
			_cboKieu_DT = value;
			if (_cboKieu_DT != null)
			{
				((ComboBox)_cboKieu_DT).SelectedIndexChanged += eventHandler;
			}
		}
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_14b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bb: Expected O, but got Unknown
		txtTk = new AsTextBox();
		lblTen_Tk = new Label();
		lblTk = new Label();
		lblKieu_DT = new Label();
		txtMa_bp = new AsTextBox();
		lblTen_bp = new Label();
		lblMa_bp = new Label();
		txtMa_phi = new AsTextBox();
		lblTen_phi = new Label();
		lblMa_phi = new Label();
		Label1 = new Label();
		Label2 = new Label();
		cboNhom_cap2 = new AsComboBox();
		Label3 = new Label();
		cboNhom_cap3 = new AsComboBox();
		Label4 = new Label();
		cboNhom_cap4 = new AsComboBox();
		txtMa_spct = new AsTextBox();
		lblTen_spct = new Label();
		Label6 = new Label();
		cboNhom_cap1 = new AsComboBox();
		cboKieu_DT = new AsComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabFilter).SuspendLayout();
		((Control)this).SuspendLayout();
		AsTabControl asTabControl = AsTabControl;
		Size size = new Size(728, 569);
		((Control)asTabControl).Size = size;
		((Control)AsTabControl).TabIndex = 0;
		((Control)tabFilter).Controls.Add((Control)(object)txtTk);
		((Control)tabFilter).Controls.Add((Control)(object)lblKieu_DT);
		((Control)tabFilter).Controls.Add((Control)(object)cboKieu_DT);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_spct);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_spct);
		((Control)tabFilter).Controls.Add((Control)(object)Label1);
		((Control)tabFilter).Controls.Add((Control)(object)Label6);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_phi);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_cap2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_phi);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_phi);
		((Control)tabFilter).Controls.Add((Control)(object)txtMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_bp);
		((Control)tabFilter).Controls.Add((Control)(object)lblMa_bp);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_cap1);
		((Control)tabFilter).Controls.Add((Control)(object)Label2);
		((Control)tabFilter).Controls.Add((Control)(object)lblTen_Tk);
		((Control)tabFilter).Controls.Add((Control)(object)lblTk);
		((Control)tabFilter).Controls.Add((Control)(object)Label4);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_cap4);
		((Control)tabFilter).Controls.Add((Control)(object)Label3);
		((Control)tabFilter).Controls.Add((Control)(object)cboNhom_cap3);
		TabPage obj = tabFilter;
		size = new Size(720, 540);
		((Control)obj).Size = size;
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_cap3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_cap4, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdOk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_Tk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_cap1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_bp, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMa_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboNhom_cap2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_phi, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label6, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optNt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)optVND, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtMa_Nt, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMauBC, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKieu_DT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKieu_DT, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdExcel, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtTieu_De, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblTieu_de, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboMau_bc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lblKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cboKyBc, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)cmdModifyReport, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)tabFilter).Controls.SetChildIndex((Control)(object)lbl2, 0);
		Button obj2 = cmdExcel;
		Point location = new Point(609, 514);
		((Control)obj2).Location = location;
		((Control)cmdExcel).TabIndex = 11;
		((Control)txtNgay2).TabIndex = 2;
		Button obj3 = cmdCancel;
		location = new Point(528, 497);
		((Control)obj3).Location = location;
		((Control)cmdCancel).TabIndex = 18;
		Button obj4 = cmdModifyReport;
		location = new Point(455, 24);
		((Control)obj4).Location = location;
		((Control)cmdModifyReport).TabIndex = 12;
		((Control)txtNgay1).TabIndex = 1;
		((Control)cboKyBc).TabIndex = 0;
		((Control)cboMau_bc).TabIndex = 14;
		AsTextBox asTextBox = txtMa_Nt;
		location = new Point(317, 318);
		((Control)asTextBox).Location = location;
		((Control)txtMa_Nt).TabIndex = 14;
		((Control)txtMa_Nt).Visible = false;
		Label obj5 = lblMauBC;
		location = new Point(362, 318);
		((Control)obj5).Location = location;
		((Control)lblMauBC).TabIndex = 15;
		((Control)lblMauBC).Visible = false;
		RadioButton obj6 = optVND;
		location = new Point(108, 315);
		((Control)obj6).Location = location;
		((Control)optVND).TabIndex = 11;
		RadioButton obj7 = optNt;
		location = new Point(162, 316);
		((Control)obj7).Location = location;
		((Control)optNt).TabIndex = 12;
		Label obj8 = lblMa_nt;
		location = new Point(24, 319);
		((Control)obj8).Location = location;
		((Control)lblMa_nt).TabIndex = 13;
		Button obj9 = cmdOk;
		location = new Point(27, 346);
		((Control)obj9).Location = location;
		((Control)cmdOk).TabIndex = 10;
		Label obj10 = lblTieu_de;
		location = new Point(24, 55);
		((Control)obj10).Location = location;
		((Control)lblTieu_de).TabIndex = 13;
		((Control)txtTieu_De).TabIndex = 15;
		TabPage obj11 = tabGrid;
		size = new Size(720, 540);
		((Control)obj11).Size = size;
		((TextBox)txtTk).AutoCompleteSource = (AutoCompleteSource)64;
		txtTk.AutoLookup = true;
		txtTk.AutoValid = false;
		((TextBoxBase)txtTk).BackColor = SystemColors.Info;
		((TextBox)txtTk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox2 = txtTk;
		location = new Point(110, 105);
		((Control)asTextBox2).Location = location;
		txtTk.LookupCodeName = "TK";
		((Control)txtTk).Name = "txtTk";
		txtTk.NameControl = lblTen_Tk;
		AsTextBox asTextBox3 = txtTk;
		size = new Size(82, 20);
		((Control)asTextBox3).Size = size;
		((Control)txtTk).TabIndex = 2;
		((Control)txtTk).Tag = "@pTk";
		txtTk.UseAutoCompleteSource = true;
		lblTen_Tk.ImeMode = (ImeMode)0;
		Label obj12 = lblTen_Tk;
		location = new Point(198, 108);
		((Control)obj12).Location = location;
		((Control)lblTen_Tk).Name = "lblTen_Tk";
		Label obj13 = lblTen_Tk;
		size = new Size(366, 13);
		((Control)obj13).Size = size;
		((Control)lblTen_Tk).TabIndex = 1083;
		lblTen_Tk.TextAlign = (ContentAlignment)16;
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj14 = lblTk;
		location = new Point(24, 109);
		((Control)obj14).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj15 = lblTk;
		size = new Size(55, 13);
		((Control)obj15).Size = size;
		((Control)lblTk).TabIndex = 1082;
		lblTk.Text = "Tài khoản";
		lblKieu_DT.AutoSize = true;
		Label obj16 = lblKieu_DT;
		location = new Point(345, 474);
		((Control)obj16).Location = location;
		((Control)lblKieu_DT).Name = "lblKieu_DT";
		Label obj17 = lblKieu_DT;
		size = new Size(67, 13);
		((Control)obj17).Size = size;
		((Control)lblKieu_DT).TabIndex = 1085;
		lblKieu_DT.Text = "Kiểu dự toán";
		((Control)lblKieu_DT).Visible = false;
		((TextBox)txtMa_bp).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_bp.AutoLookup = true;
		txtMa_bp.AutoValid = false;
		((TextBoxBase)txtMa_bp).BackColor = SystemColors.Info;
		((TextBox)txtMa_bp).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox4 = txtMa_bp;
		location = new Point(110, 131);
		((Control)asTextBox4).Location = location;
		txtMa_bp.LookupCodeName = "Ma_bp";
		((Control)txtMa_bp).Name = "txtMa_bp";
		txtMa_bp.NameControl = lblTen_bp;
		AsTextBox asTextBox5 = txtMa_bp;
		size = new Size(82, 20);
		((Control)asTextBox5).Size = size;
		((Control)txtMa_bp).TabIndex = 3;
		((Control)txtMa_bp).Tag = "@pMa_bp";
		txtMa_bp.UseAutoCompleteSource = true;
		lblTen_bp.ImeMode = (ImeMode)0;
		Label obj18 = lblTen_bp;
		location = new Point(198, 135);
		((Control)obj18).Location = location;
		((Control)lblTen_bp).Name = "lblTen_bp";
		Label obj19 = lblTen_bp;
		size = new Size(366, 13);
		((Control)obj19).Size = size;
		((Control)lblTen_bp).TabIndex = 1088;
		lblTen_bp.TextAlign = (ContentAlignment)16;
		lblMa_bp.AutoSize = true;
		lblMa_bp.ImeMode = (ImeMode)0;
		Label obj20 = lblMa_bp;
		location = new Point(24, 136);
		((Control)obj20).Location = location;
		((Control)lblMa_bp).Name = "lblMa_bp";
		Label obj21 = lblMa_bp;
		size = new Size(64, 13);
		((Control)obj21).Size = size;
		((Control)lblMa_bp).TabIndex = 1087;
		lblMa_bp.Text = "Mã bộ phận";
		((TextBox)txtMa_phi).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_phi.AutoLookup = true;
		txtMa_phi.AutoValid = false;
		((TextBoxBase)txtMa_phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox6 = txtMa_phi;
		location = new Point(110, 157);
		((Control)asTextBox6).Location = location;
		txtMa_phi.LookupCodeName = "Ma_phi";
		((Control)txtMa_phi).Name = "txtMa_phi";
		txtMa_phi.NameControl = lblTen_phi;
		AsTextBox asTextBox7 = txtMa_phi;
		size = new Size(82, 20);
		((Control)asTextBox7).Size = size;
		((Control)txtMa_phi).TabIndex = 4;
		((Control)txtMa_phi).Tag = "@pMa_phi";
		txtMa_phi.UseAutoCompleteSource = true;
		lblTen_phi.ImeMode = (ImeMode)0;
		Label obj22 = lblTen_phi;
		location = new Point(198, 162);
		((Control)obj22).Location = location;
		((Control)lblTen_phi).Name = "lblTen_phi";
		Label obj23 = lblTen_phi;
		size = new Size(366, 13);
		((Control)obj23).Size = size;
		((Control)lblTen_phi).TabIndex = 1091;
		lblTen_phi.TextAlign = (ContentAlignment)16;
		lblMa_phi.AutoSize = true;
		lblMa_phi.ImeMode = (ImeMode)0;
		Label obj24 = lblMa_phi;
		location = new Point(24, 163);
		((Control)obj24).Location = location;
		((Control)lblMa_phi).Name = "lblMa_phi";
		Label obj25 = lblMa_phi;
		size = new Size(41, 13);
		((Control)obj25).Size = size;
		((Control)lblMa_phi).TabIndex = 1090;
		lblMa_phi.Text = "Mã phí";
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(24, 212);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(65, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1093;
		Label1.Text = "Nhóm cấp 1";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(24, 239);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(65, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 1095;
		Label2.Text = "Nhóm cấp 2";
		((ComboBox)cboNhom_cap2).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_cap2).FormattingEnabled = true;
		AsComboBox asComboBox = cboNhom_cap2;
		location = new Point(110, 235);
		((Control)asComboBox).Location = location;
		((Control)cboNhom_cap2).Name = "cboNhom_cap2";
		AsComboBox asComboBox2 = cboNhom_cap2;
		size = new Size(248, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboNhom_cap2).TabIndex = 7;
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(24, 266);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(65, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 1097;
		Label3.Text = "Nhóm cấp 3";
		((ComboBox)cboNhom_cap3).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_cap3).FormattingEnabled = true;
		AsComboBox asComboBox3 = cboNhom_cap3;
		location = new Point(110, 262);
		((Control)asComboBox3).Location = location;
		((Control)cboNhom_cap3).Name = "cboNhom_cap3";
		AsComboBox asComboBox4 = cboNhom_cap3;
		size = new Size(248, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboNhom_cap3).TabIndex = 8;
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(24, 293);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(65, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 1099;
		Label4.Text = "Nhóm cấp 4";
		((ComboBox)cboNhom_cap4).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_cap4).FormattingEnabled = true;
		AsComboBox asComboBox5 = cboNhom_cap4;
		location = new Point(110, 289);
		((Control)asComboBox5).Location = location;
		((Control)cboNhom_cap4).Name = "cboNhom_cap4";
		AsComboBox asComboBox6 = cboNhom_cap4;
		size = new Size(248, 21);
		((Control)asComboBox6).Size = size;
		((Control)cboNhom_cap4).TabIndex = 9;
		((TextBox)txtMa_spct).AutoCompleteSource = (AutoCompleteSource)64;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = false;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox8 = txtMa_spct;
		location = new Point(110, 183);
		((Control)asTextBox8).Location = location;
		txtMa_spct.LookupCodeName = "Ma_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox9 = txtMa_spct;
		size = new Size(82, 20);
		((Control)asTextBox9).Size = size;
		((Control)txtMa_spct).TabIndex = 5;
		((Control)txtMa_spct).Tag = "@pMa_spct";
		txtMa_spct.UseAutoCompleteSource = true;
		lblTen_spct.ImeMode = (ImeMode)0;
		Label obj26 = lblTen_spct;
		location = new Point(198, 186);
		((Control)obj26).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj27 = lblTen_spct;
		size = new Size(366, 13);
		((Control)obj27).Size = size;
		((Control)lblTen_spct).TabIndex = 1103;
		lblTen_spct.TextAlign = (ContentAlignment)16;
		Label6.AutoSize = true;
		Label6.ImeMode = (ImeMode)0;
		Label label9 = Label6;
		location = new Point(24, 189);
		((Control)label9).Location = location;
		((Control)Label6).Name = "Label6";
		Label label10 = Label6;
		size = new Size(45, 13);
		((Control)label10).Size = size;
		((Control)Label6).TabIndex = 1102;
		Label6.Text = "Mã spct";
		((ComboBox)cboNhom_cap1).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboNhom_cap1).FormattingEnabled = true;
		((ComboBox)cboNhom_cap1).Items.AddRange(new object[4] { "Theo tài khoản", "Theo bộ phận", "Theo mã phí", "Theo sản phẩm công trình" });
		AsComboBox asComboBox7 = cboNhom_cap1;
		location = new Point(110, 209);
		((Control)asComboBox7).Location = location;
		((Control)cboNhom_cap1).Name = "cboNhom_cap1";
		AsComboBox asComboBox8 = cboNhom_cap1;
		size = new Size(248, 21);
		((Control)asComboBox8).Size = size;
		((Control)cboNhom_cap1).TabIndex = 6;
		((ComboBox)cboKieu_DT).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKieu_DT).FormattingEnabled = true;
		((ComboBox)cboKieu_DT).Items.AddRange(new object[4] { "1. Theo tài khoản", "2. Theo tài khoản và bộ phận", "3. Theo tài khoản, bộ phận và mã phí", "4. Theo tài khoản và mã phí" });
		AsComboBox asComboBox9 = cboKieu_DT;
		location = new Point(431, 470);
		((Control)asComboBox9).Location = location;
		((Control)cboKieu_DT).Name = "cboKieu_DT";
		AsComboBox asComboBox10 = cboKieu_DT;
		size = new Size(253, 21);
		((Control)asComboBox10).Size = size;
		((Control)cboKieu_DT).TabIndex = 1;
		((Control)cboKieu_DT).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(728, 594);
		((Form)this).ClientSize = size;
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = "frmGLRptBCPT05";
		((Form)this).Text = "frmGLRptBCPT05";
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabFilter).ResumeLayout(false);
		((Control)tabFilter).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public frmGLRptBCPT05(string Menuid)
		: base(Menuid)
	{
		DataSource4CBO = new List<DictionaryEntry>();
		isCboDatasourceLoading = true;
		InitializeComponent();
	}

	protected override void InitOtherComponents()
	{
		List<DictionaryEntry> dataSource4CBO = DataSource4CBO;
		DictionaryEntry item = new DictionaryEntry("", "");
		dataSource4CBO.Add(item);
		List<DictionaryEntry> dataSource4CBO2 = DataSource4CBO;
		item = new DictionaryEntry("TK", RuntimeHelpers.GetObjectValue(((ComboBox)cboNhom_cap1).Items[0]));
		dataSource4CBO2.Add(item);
		List<DictionaryEntry> dataSource4CBO3 = DataSource4CBO;
		item = new DictionaryEntry("ma_bo", RuntimeHelpers.GetObjectValue(((ComboBox)cboNhom_cap1).Items[1]));
		dataSource4CBO3.Add(item);
		List<DictionaryEntry> dataSource4CBO4 = DataSource4CBO;
		item = new DictionaryEntry("ma_phi", RuntimeHelpers.GetObjectValue(((ComboBox)cboNhom_cap1).Items[2]));
		dataSource4CBO4.Add(item);
		List<DictionaryEntry> dataSource4CBO5 = DataSource4CBO;
		item = new DictionaryEntry("ma_spct", RuntimeHelpers.GetObjectValue(((ComboBox)cboNhom_cap1).Items[3]));
		dataSource4CBO5.Add(item);
		((ComboBox)cboNhom_cap1).DataSource = DataSource4CBO;
		((ListControl)cboNhom_cap1).ValueMember = "Key";
		((ListControl)cboNhom_cap1).DisplayMember = "Value";
		((ComboBox)cboNhom_cap1).SelectedIndex = 0;
		isCboDatasourceLoading = false;
	}

	protected override bool LoadData()
	{
		DictionaryEntry dictionaryEntry = (DictionaryEntry)((ComboBox)cboNhom_cap1).SelectedItem;
		string value = Conversions.ToString(dictionaryEntry.Key);
		string value2 = "";
		string value3 = "";
		string value4 = "";
		if (((ComboBox)cboNhom_cap2).SelectedItem != null)
		{
			dictionaryEntry = (DictionaryEntry)((ComboBox)cboNhom_cap2).SelectedItem;
			value2 = Conversions.ToString(dictionaryEntry.Key);
		}
		if (((ComboBox)cboNhom_cap3).SelectedItem != null)
		{
			dictionaryEntry = (DictionaryEntry)((ComboBox)cboNhom_cap3).SelectedItem;
			value3 = Conversions.ToString(dictionaryEntry.Key);
		}
		if (((ComboBox)cboNhom_cap4).SelectedItem != null)
		{
			dictionaryEntry = (DictionaryEntry)((ComboBox)cboNhom_cap4).SelectedItem;
			value4 = Conversions.ToString(dictionaryEntry.Key);
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(DateAndTime.Year(Conversions.ToDate(txtNgay1.Value)));
		arrayList.Add(((TextBox)txtTk).Text);
		arrayList.Add(((TextBox)txtMa_phi).Text);
		arrayList.Add(((TextBox)txtMa_bp).Text);
		arrayList.Add(((TextBox)txtMa_spct).Text);
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
		arrayList.Add(value);
		arrayList.Add(value2);
		arrayList.Add(value3);
		arrayList.Add(value4);
		set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
		base.MyFomularFields.Clear();
		base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
		return true;
	}

	protected override bool ValidData()
	{
		return true;
	}

	private string GetFilterTitle()
	{
		string text = "";
		if (((ComboBox)cboKieu_DT).SelectedIndex == 0)
		{
			text = text + lblKieu_DT.Text + ": " + ((ComboBox)cboKieu_DT).Text + ";";
			text = text + lblTk.Text + ": " + ((TextBox)txtTk).Text + ";";
		}
		if (((ComboBox)cboKieu_DT).SelectedIndex == 1)
		{
			text = text + lblKieu_DT.Text + ": " + ((ComboBox)cboKieu_DT).Text + ";";
			text = text + lblTk.Text + ": " + ((TextBox)txtTk).Text + ";";
			text = text + lblMa_bp.Text + ": " + ((TextBox)txtMa_bp).Text + ";";
			if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
			{
				text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text;
			}
		}
		if (((ComboBox)cboKieu_DT).SelectedIndex == 2)
		{
			text = text + lblKieu_DT.Text + ": " + ((ComboBox)cboKieu_DT).Text + ";";
			text = text + lblTk.Text + ": " + ((TextBox)txtTk).Text + ";";
			text = text + lblMa_bp.Text + ": " + ((TextBox)txtMa_bp).Text + ";";
			text = text + lblMa_phi.Text + ": " + ((TextBox)txtMa_phi).Text + ";";
			if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
			{
				text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text;
			}
		}
		if (((ComboBox)cboKieu_DT).SelectedIndex == 3)
		{
			text = text + lblKieu_DT.Text + ": " + ((ComboBox)cboKieu_DT).Text + ";";
			text = text + lblTk.Text + ": " + ((TextBox)txtTk).Text + ";";
			text = text + lblMa_phi.Text + ": " + ((TextBox)txtMa_phi).Text + ";";
			if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
			{
				text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text;
			}
		}
		return text;
	}

	private void cboNhom_cap1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (isCboDatasourceLoading)
		{
			return;
		}
		isCboDatasourceLoading = true;
		((ComboBox)cboNhom_cap2).Items.Clear();
		((ComboBox)cboNhom_cap3).Items.Clear();
		((ComboBox)cboNhom_cap4).Items.Clear();
		checked
		{
			int num = DataSource4CBO.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (!Operators.ConditionalCompareObjectEqual(DataSource4CBO[i].Key, ((ListControl)cboNhom_cap1).SelectedValue, false))
				{
					((ComboBox)cboNhom_cap2).Items.Add((object)DataSource4CBO[i]);
				}
			}
			((ListControl)cboNhom_cap2).ValueMember = "Key";
			((ListControl)cboNhom_cap2).DisplayMember = "Value";
			((ListControl)cboNhom_cap2).SelectedValue = "";
			isCboDatasourceLoading = false;
		}
	}

	private void cboNhom_cap2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (isCboDatasourceLoading)
		{
			return;
		}
		isCboDatasourceLoading = true;
		((ComboBox)cboNhom_cap3).Items.Clear();
		((ComboBox)cboNhom_cap4).Items.Clear();
		DictionaryEntry dictionaryEntry = (DictionaryEntry)((ComboBox)cboNhom_cap1).SelectedItem;
		string text = Conversions.ToString(dictionaryEntry.Key);
		dictionaryEntry = (DictionaryEntry)((ComboBox)cboNhom_cap2).SelectedItem;
		string text2 = Conversions.ToString(dictionaryEntry.Key);
		checked
		{
			int num = DataSource4CBO.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (!Operators.ConditionalCompareObjectEqual(DataSource4CBO[i].Key, (object)text, false) && !Operators.ConditionalCompareObjectEqual(DataSource4CBO[i].Key, (object)text2, false))
				{
					((ComboBox)cboNhom_cap3).Items.Add((object)DataSource4CBO[i]);
				}
			}
			((ListControl)cboNhom_cap3).ValueMember = "Key";
			((ListControl)cboNhom_cap3).DisplayMember = "Value";
			((ListControl)cboNhom_cap3).SelectedValue = "";
			isCboDatasourceLoading = false;
		}
	}

	private void cboNhom_cap3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (isCboDatasourceLoading)
		{
			return;
		}
		((ComboBox)cboNhom_cap4).Items.Clear();
		DictionaryEntry dictionaryEntry = (DictionaryEntry)((ComboBox)cboNhom_cap1).SelectedItem;
		string text = Conversions.ToString(dictionaryEntry.Key);
		dictionaryEntry = (DictionaryEntry)((ComboBox)cboNhom_cap2).SelectedItem;
		string text2 = Conversions.ToString(dictionaryEntry.Key);
		dictionaryEntry = (DictionaryEntry)((ComboBox)cboNhom_cap3).SelectedItem;
		string text3 = Conversions.ToString(dictionaryEntry.Key);
		checked
		{
			int num = DataSource4CBO.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (!Operators.ConditionalCompareObjectEqual(DataSource4CBO[i].Key, (object)text, false) && !Operators.ConditionalCompareObjectEqual(DataSource4CBO[i].Key, (object)text2, false) && !Operators.ConditionalCompareObjectEqual(DataSource4CBO[i].Key, (object)text3, false))
				{
					((ComboBox)cboNhom_cap4).Items.Add((object)DataSource4CBO[i]);
				}
			}
			((ListControl)cboNhom_cap4).ValueMember = "Key";
			((ListControl)cboNhom_cap4).DisplayMember = "Value";
			((ListControl)cboNhom_cap4).SelectedValue = "";
		}
	}

	private void cboKieu_DT_SelectedIndexChanged(object sender, EventArgs e)
	{
	}
}
