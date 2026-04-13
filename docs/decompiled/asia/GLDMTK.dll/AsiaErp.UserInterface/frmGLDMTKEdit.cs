using System;
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
public class frmGLDMTKEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lbTen_Tk")]
	private Label _lbTen_Tk;

	[AccessedThroughProperty("lblTk")]
	private Label _lblTk;

	[AccessedThroughProperty("txtTen_Tk")]
	private TextBox _txtTen_Tk;

	[AccessedThroughProperty("txtTk")]
	private TextBox _txtTk;

	[AccessedThroughProperty("lblMa_Nt")]
	private Label _lblMa_Nt;

	[AccessedThroughProperty("chkTk_Cn")]
	private AsCheckBox _chkTk_Cn;

	[AccessedThroughProperty("chkTk_Sc")]
	private AsCheckBox _chkTk_Sc;

	[AccessedThroughProperty("cboMa_Nt")]
	private AsComboBoxNT _cboMa_Nt;

	[AccessedThroughProperty("cboCach_tinh_tygia_co")]
	private AsComboBox _cboCach_tinh_tygia_co;

	[AccessedThroughProperty("lblCach_tinh_no")]
	private Label _lblCach_tinh_no;

	[AccessedThroughProperty("cboCach_Tinh_tygia_no")]
	private AsComboBox _cboCach_Tinh_tygia_no;

	[AccessedThroughProperty("lblCach_tinh_co")]
	private Label _lblCach_tinh_co;

	[AccessedThroughProperty("cboKieu_sd")]
	private AsComboBox _cboKieu_sd;

	[AccessedThroughProperty("lblKieu_sd_cuoi_ky")]
	private Label _lblKieu_sd_cuoi_ky;

	[AccessedThroughProperty("txtSo_tk")]
	private AsTextBox _txtSo_tk;

	[AccessedThroughProperty("lblSo_TK_NH")]
	private Label _lblSo_TK_NH;

	[AccessedThroughProperty("lblTinh_tp")]
	private Label _lblTinh_tp;

	[AccessedThroughProperty("txtTinh_tp")]
	private TextBox _txtTinh_tp;

	[AccessedThroughProperty("lblTen_ngh")]
	private Label _lblTen_ngh;

	[AccessedThroughProperty("txtTen_ngh")]
	private TextBox _txtTen_ngh;

	[AccessedThroughProperty("lblDG_CL_TG")]
	private Label _lblDG_CL_TG;

	[AccessedThroughProperty("lblInfoBank")]
	private Label _lblInfoBank;

	[AccessedThroughProperty("lblMa_NH")]
	private Label _lblMa_NH;

	[AccessedThroughProperty("txtMa_ngh")]
	private AsTextBox _txtMa_ngh;

	[AccessedThroughProperty("chkYc_spct")]
	private AsCheckBox _chkYc_spct;

	[AccessedThroughProperty("chkYc_phi")]
	private AsCheckBox _chkYc_phi;

	private string sTen_ngh;

	internal virtual Label lbTen_Tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbTen_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbTen_Tk = value;
		}
	}

	internal virtual Label lblTk
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

	internal virtual TextBox txtTen_Tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_Tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_Tk = value;
		}
	}

	internal virtual TextBox txtTk
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

	internal virtual Label lblMa_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_Nt = value;
		}
	}

	internal virtual AsCheckBox chkTk_Cn
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkTk_Cn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkTk_Cn = value;
		}
	}

	internal virtual AsCheckBox chkTk_Sc
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkTk_Sc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkTk_Sc = value;
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

	internal virtual AsComboBox cboCach_tinh_tygia_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboCach_tinh_tygia_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboCach_tinh_tygia_co = value;
		}
	}

	internal virtual Label lblCach_tinh_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCach_tinh_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCach_tinh_no = value;
		}
	}

	internal virtual AsComboBox cboCach_Tinh_tygia_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboCach_Tinh_tygia_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboCach_Tinh_tygia_no = value;
		}
	}

	internal virtual Label lblCach_tinh_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCach_tinh_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCach_tinh_co = value;
		}
	}

	internal virtual AsComboBox cboKieu_sd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboKieu_sd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboKieu_sd = value;
		}
	}

	internal virtual Label lblKieu_sd_cuoi_ky
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblKieu_sd_cuoi_ky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblKieu_sd_cuoi_ky = value;
		}
	}

	internal virtual AsTextBox txtSo_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_tk = value;
		}
	}

	internal virtual Label lblSo_TK_NH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_TK_NH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_TK_NH = value;
		}
	}

	internal virtual Label lblTinh_tp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTinh_tp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTinh_tp = value;
		}
	}

	internal virtual TextBox txtTinh_tp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTinh_tp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTinh_tp = value;
		}
	}

	internal virtual Label lblTen_ngh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ngh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ngh = value;
		}
	}

	internal virtual TextBox txtTen_ngh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_ngh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_ngh = value;
		}
	}

	internal virtual Label lblDG_CL_TG
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDG_CL_TG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDG_CL_TG = value;
		}
	}

	internal virtual Label lblInfoBank
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblInfoBank;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblInfoBank = value;
		}
	}

	internal virtual Label lblMa_NH
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_NH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_NH = value;
		}
	}

	internal virtual AsTextBox txtMa_ngh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ngh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_ngh_AfterCodeValidating;
			if (_txtMa_ngh != null)
			{
				_txtMa_ngh.AfterCodeValidating -= obj;
			}
			_txtMa_ngh = value;
			if (_txtMa_ngh != null)
			{
				_txtMa_ngh.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual AsCheckBox chkYc_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkYc_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkYc_spct = value;
		}
	}

	internal virtual AsCheckBox chkYc_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkYc_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkYc_phi = value;
		}
	}

	[DebuggerNonUserCode]
	public frmGLDMTKEdit()
	{
		__ENCAddToList(this);
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
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_1242: Unknown result type (might be due to invalid IL or missing references)
		//IL_124c: Expected O, but got Unknown
		//IL_12f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fd: Expected O, but got Unknown
		lbTen_Tk = new Label();
		lblTk = new Label();
		txtTen_Tk = new TextBox();
		txtTk = new TextBox();
		lblMa_Nt = new Label();
		cboMa_Nt = new AsComboBoxNT();
		chkTk_Cn = new AsCheckBox();
		chkTk_Sc = new AsCheckBox();
		cboCach_tinh_tygia_co = new AsComboBox();
		lblCach_tinh_no = new Label();
		lblCach_tinh_co = new Label();
		cboCach_Tinh_tygia_no = new AsComboBox();
		lblKieu_sd_cuoi_ky = new Label();
		cboKieu_sd = new AsComboBox();
		txtSo_tk = new AsTextBox();
		lblSo_TK_NH = new Label();
		lblTinh_tp = new Label();
		txtTinh_tp = new TextBox();
		lblTen_ngh = new Label();
		txtTen_ngh = new TextBox();
		lblInfoBank = new Label();
		lblDG_CL_TG = new Label();
		lblMa_NH = new Label();
		txtMa_ngh = new AsTextBox();
		chkYc_phi = new AsCheckBox();
		chkYc_spct = new AsCheckBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(192, 450);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 14;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(92, 499);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(11, 499);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)chkYc_spct);
		((Control)gbLine).Controls.Add((Control)(object)chkYc_phi);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_ngh);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_NH);
		((Control)gbLine).Controls.Add((Control)(object)lblDG_CL_TG);
		((Control)gbLine).Controls.Add((Control)(object)lblInfoBank);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_tk);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_TK_NH);
		((Control)gbLine).Controls.Add((Control)(object)lblTinh_tp);
		((Control)gbLine).Controls.Add((Control)(object)txtTinh_tp);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_ngh);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_ngh);
		((Control)gbLine).Controls.Add((Control)(object)cboKieu_sd);
		((Control)gbLine).Controls.Add((Control)(object)cboCach_Tinh_tygia_no);
		((Control)gbLine).Controls.Add((Control)(object)cboCach_tinh_tygia_co);
		((Control)gbLine).Controls.Add((Control)(object)cboMa_Nt);
		((Control)gbLine).Controls.Add((Control)(object)lbTen_Tk);
		((Control)gbLine).Controls.Add((Control)(object)chkTk_Cn);
		((Control)gbLine).Controls.Add((Control)(object)chkTk_Sc);
		((Control)gbLine).Controls.Add((Control)(object)lblTk);
		((Control)gbLine).Controls.Add((Control)(object)lblKieu_sd_cuoi_ky);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_Tk);
		((Control)gbLine).Controls.Add((Control)(object)lblCach_tinh_co);
		((Control)gbLine).Controls.Add((Control)(object)txtTk);
		((Control)gbLine).Controls.Add((Control)(object)lblCach_tinh_no);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_Nt);
		GroupBox obj3 = gbLine;
		Size size = new Size(819, 486);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblCach_tinh_no, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblCach_tinh_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_Tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblKieu_sd_cuoi_ky, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkTk_Sc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkTk_Cn, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lbTen_Tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboMa_Nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboCach_tinh_tygia_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboCach_Tinh_tygia_no, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboKieu_sd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_ngh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_ngh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTinh_tp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTinh_tp, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_TK_NH, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblInfoBank, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblDG_CL_TG, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_NH, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_ngh, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkYc_phi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkYc_spct, 0);
		lbTen_Tk.AutoSize = true;
		lbTen_Tk.ImeMode = (ImeMode)0;
		Label obj4 = lbTen_Tk;
		location = new Point(19, 49);
		((Control)obj4).Location = location;
		((Control)lbTen_Tk).Name = "lbTen_Tk";
		Label obj5 = lbTen_Tk;
		size = new Size(73, 13);
		((Control)obj5).Size = size;
		((Control)lbTen_Tk).TabIndex = 148;
		lbTen_Tk.Text = "Tên tài khoản";
		lblTk.AutoSize = true;
		lblTk.ImeMode = (ImeMode)0;
		Label obj6 = lblTk;
		location = new Point(19, 23);
		((Control)obj6).Location = location;
		((Control)lblTk).Name = "lblTk";
		Label obj7 = lblTk;
		size = new Size(55, 13);
		((Control)obj7).Size = size;
		((Control)lblTk).TabIndex = 146;
		lblTk.Text = "Tài khoản";
		TextBox obj8 = txtTen_Tk;
		location = new Point(179, 45);
		((Control)obj8).Location = location;
		((TextBoxBase)txtTen_Tk).MaxLength = 50;
		((Control)txtTen_Tk).Name = "txtTen_Tk";
		TextBox obj9 = txtTen_Tk;
		size = new Size(473, 20);
		((Control)obj9).Size = size;
		((Control)txtTen_Tk).TabIndex = 1;
		txtTk.CharacterCasing = (CharacterCasing)1;
		TextBox obj10 = txtTk;
		location = new Point(179, 19);
		((Control)obj10).Location = location;
		((TextBoxBase)txtTk).MaxLength = 20;
		((Control)txtTk).Name = "txtTk";
		TextBox obj11 = txtTk;
		size = new Size(100, 20);
		((Control)obj11).Size = size;
		((Control)txtTk).TabIndex = 0;
		lblMa_Nt.AutoSize = true;
		lblMa_Nt.ImeMode = (ImeMode)0;
		Label obj12 = lblMa_Nt;
		location = new Point(19, 75);
		((Control)obj12).Location = location;
		((Control)lblMa_Nt).Name = "lblMa_Nt";
		Label obj13 = lblMa_Nt;
		size = new Size(63, 13);
		((Control)obj13).Size = size;
		((Control)lblMa_Nt).TabIndex = 151;
		lblMa_Nt.Text = "Mã ngoại tệ";
		lblMa_Nt.TextAlign = (ContentAlignment)16;
		((ComboBox)cboMa_Nt).DropDownHeight = 200;
		((ComboBox)cboMa_Nt).DropDownStyle = (ComboBoxStyle)2;
		((ComboBox)cboMa_Nt).DropDownWidth = 100;
		((ListControl)cboMa_Nt).FormattingEnabled = true;
		((ComboBox)cboMa_Nt).IntegralHeight = false;
		AsComboBoxNT asComboBoxNT = cboMa_Nt;
		location = new Point(179, 71);
		((Control)asComboBoxNT).Location = location;
		cboMa_Nt.MA_NT = "";
		((ComboBox)cboMa_Nt).MaxDropDownItems = 2;
		((Control)cboMa_Nt).Name = "cboMa_Nt";
		AsComboBoxNT asComboBoxNT2 = cboMa_Nt;
		size = new Size(100, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_Nt).TabIndex = 2;
		((ButtonBase)chkTk_Cn).AutoSize = true;
		chkTk_Cn.Checked = false;
		AsCheckBox asCheckBox2 = chkTk_Cn;
		location = new Point(179, 98);
		((Control)asCheckBox2).Location = location;
		((Control)chkTk_Cn).Name = "chkTk_Cn";
		AsCheckBox asCheckBox3 = chkTk_Cn;
		size = new Size(81, 17);
		((Control)asCheckBox3).Size = size;
		((Control)chkTk_Cn).TabIndex = 3;
		((ButtonBase)chkTk_Cn).Text = "Tk công nợ";
		chkTk_Cn.TextValue = "0";
		((ButtonBase)chkTk_Cn).UseVisualStyleBackColor = true;
		((ButtonBase)chkTk_Sc).AutoSize = true;
		chkTk_Sc.Checked = false;
		AsCheckBox asCheckBox4 = chkTk_Sc;
		location = new Point(179, 121);
		((Control)asCheckBox4).Location = location;
		((Control)chkTk_Sc).Name = "chkTk_Sc";
		AsCheckBox asCheckBox5 = chkTk_Sc;
		size = new Size(70, 17);
		((Control)asCheckBox5).Size = size;
		((Control)chkTk_Sc).TabIndex = 4;
		((ButtonBase)chkTk_Sc).Text = "Tk sổ cái";
		chkTk_Sc.TextValue = "0";
		((ButtonBase)chkTk_Sc).UseVisualStyleBackColor = true;
		((ComboBox)cboCach_tinh_tygia_co).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboCach_tinh_tygia_co).FormattingEnabled = true;
		((ComboBox)cboCach_tinh_tygia_co).Items.AddRange(new object[4] { "0 - Không tính", "1 - Trung bình tháng", "2 - Nhập trước xuất trước", "3 - Bình quân di động" });
		AsComboBox asComboBox = cboCach_tinh_tygia_co;
		location = new Point(192, 256);
		((Control)asComboBox).Location = location;
		((ComboBox)cboCach_tinh_tygia_co).MaxDropDownItems = 4;
		((Control)cboCach_tinh_tygia_co).Name = "cboCach_tinh_tygia_co";
		AsComboBox asComboBox2 = cboCach_tinh_tygia_co;
		size = new Size(165, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboCach_tinh_tygia_co).TabIndex = 8;
		lblCach_tinh_no.AutoSize = true;
		lblCach_tinh_no.ImeMode = (ImeMode)0;
		Label obj14 = lblCach_tinh_no;
		location = new Point(32, 259);
		((Control)obj14).Location = location;
		((Control)lblCach_tinh_no).Name = "lblCach_tinh_no";
		Label obj15 = lblCach_tinh_no;
		size = new Size(149, 13);
		((Control)obj15).Size = size;
		((Control)lblCach_tinh_no).TabIndex = 151;
		lblCach_tinh_no.Text = "Cách tính tỷ giá ghi sổ bên nợ";
		lblCach_tinh_no.TextAlign = (ContentAlignment)16;
		lblCach_tinh_co.AutoSize = true;
		lblCach_tinh_co.ImeMode = (ImeMode)0;
		Label obj16 = lblCach_tinh_co;
		location = new Point(32, 289);
		((Control)obj16).Location = location;
		((Control)lblCach_tinh_co).Name = "lblCach_tinh_co";
		Label obj17 = lblCach_tinh_co;
		size = new Size(149, 13);
		((Control)obj17).Size = size;
		((Control)lblCach_tinh_co).TabIndex = 151;
		lblCach_tinh_co.Text = "Cách tính tỷ giá ghi sổ bên có";
		lblCach_tinh_co.TextAlign = (ContentAlignment)16;
		((ComboBox)cboCach_Tinh_tygia_no).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboCach_Tinh_tygia_no).FormattingEnabled = true;
		((ComboBox)cboCach_Tinh_tygia_no).Items.AddRange(new object[4] { "0 - Không tính", "1 - Trung bình tháng", "2 - Nhập trước xuất trước", "3 - Bình quân di động" });
		AsComboBox asComboBox3 = cboCach_Tinh_tygia_no;
		location = new Point(192, 286);
		((Control)asComboBox3).Location = location;
		((ComboBox)cboCach_Tinh_tygia_no).MaxDropDownItems = 4;
		((Control)cboCach_Tinh_tygia_no).Name = "cboCach_Tinh_tygia_no";
		AsComboBox asComboBox4 = cboCach_Tinh_tygia_no;
		size = new Size(165, 21);
		((Control)asComboBox4).Size = size;
		((Control)cboCach_Tinh_tygia_no).TabIndex = 9;
		lblKieu_sd_cuoi_ky.AutoSize = true;
		lblKieu_sd_cuoi_ky.ImeMode = (ImeMode)0;
		Label obj18 = lblKieu_sd_cuoi_ky;
		location = new Point(19, 148);
		((Control)obj18).Location = location;
		((Control)lblKieu_sd_cuoi_ky).Name = "lblKieu_sd_cuoi_ky";
		Label obj19 = lblKieu_sd_cuoi_ky;
		size = new Size(57, 13);
		((Control)obj19).Size = size;
		((Control)lblKieu_sd_cuoi_ky).TabIndex = 151;
		lblKieu_sd_cuoi_ky.Text = "Kiểu số dư";
		lblKieu_sd_cuoi_ky.TextAlign = (ContentAlignment)16;
		((ComboBox)cboKieu_sd).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKieu_sd).FormattingEnabled = true;
		((ComboBox)cboKieu_sd).Items.AddRange(new object[4] { "0 - Không có số dư", "1 - Dư nợ", "2 - Dư có", "3 - Lưỡng tính" });
		AsComboBox asComboBox5 = cboKieu_sd;
		location = new Point(179, 144);
		((Control)asComboBox5).Location = location;
		((ComboBox)cboKieu_sd).MaxDropDownItems = 4;
		((Control)cboKieu_sd).Name = "cboKieu_sd";
		AsComboBox asComboBox6 = cboKieu_sd;
		size = new Size(165, 21);
		((Control)asComboBox6).Size = size;
		((Control)cboKieu_sd).TabIndex = 5;
		txtSo_tk.AutoLookup = false;
		txtSo_tk.AutoValid = false;
		((TextBoxBase)txtSo_tk).BackColor = SystemColors.Window;
		((TextBox)txtSo_tk).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtSo_tk;
		location = new Point(192, 372);
		((Control)asTextBox).Location = location;
		txtSo_tk.LookupCodeName = "";
		((Control)txtSo_tk).Name = "txtSo_tk";
		txtSo_tk.NameControl = null;
		AsTextBox asTextBox2 = txtSo_tk;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtSo_tk).TabIndex = 11;
		txtSo_tk.UseAutoCompleteSource = true;
		lblSo_TK_NH.AutoSize = true;
		Label obj20 = lblSo_TK_NH;
		location = new Point(32, 375);
		((Control)obj20).Location = location;
		((Control)lblSo_TK_NH).Name = "lblSo_TK_NH";
		Label obj21 = lblSo_TK_NH;
		size = new Size(121, 13);
		((Control)obj21).Size = size;
		((Control)lblSo_TK_NH).TabIndex = 175;
		lblSo_TK_NH.Text = "Số tài khoản ngân hàng";
		lblTinh_tp.AutoSize = true;
		Label obj22 = lblTinh_tp;
		location = new Point(32, 427);
		((Control)obj22).Location = location;
		((Control)lblTinh_tp).Name = "lblTinh_tp";
		Label obj23 = lblTinh_tp;
		size = new Size(82, 13);
		((Control)obj23).Size = size;
		((Control)lblTinh_tp).TabIndex = 177;
		lblTinh_tp.Text = "Tỉnh, thành phố";
		TextBox obj24 = txtTinh_tp;
		location = new Point(192, 424);
		((Control)obj24).Location = location;
		((Control)txtTinh_tp).Name = "txtTinh_tp";
		TextBox obj25 = txtTinh_tp;
		size = new Size(232, 20);
		((Control)obj25).Size = size;
		((Control)txtTinh_tp).TabIndex = 13;
		lblTen_ngh.AutoSize = true;
		Label obj26 = lblTen_ngh;
		location = new Point(32, 401);
		((Control)obj26).Location = location;
		((Control)lblTen_ngh).Name = "lblTen_ngh";
		Label obj27 = lblTen_ngh;
		size = new Size(76, 13);
		((Control)obj27).Size = size;
		((Control)lblTen_ngh).TabIndex = 176;
		lblTen_ngh.Text = "Tại ngân hàng";
		TextBox obj28 = txtTen_ngh;
		location = new Point(192, 398);
		((Control)obj28).Location = location;
		((Control)txtTen_ngh).Name = "txtTen_ngh";
		TextBox obj29 = txtTen_ngh;
		size = new Size(460, 20);
		((Control)obj29).Size = size;
		((Control)txtTen_ngh).TabIndex = 12;
		lblInfoBank.AutoSize = true;
		((Control)lblInfoBank).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		lblInfoBank.ImeMode = (ImeMode)0;
		Label obj30 = lblInfoBank;
		location = new Point(19, 325);
		((Control)obj30).Location = location;
		((Control)lblInfoBank).Name = "lblInfoBank";
		Label obj31 = lblInfoBank;
		size = new Size(129, 13);
		((Control)obj31).Size = size;
		((Control)lblInfoBank).TabIndex = 178;
		lblInfoBank.Text = "Thông tin ngân hàng:";
		lblInfoBank.TextAlign = (ContentAlignment)16;
		lblDG_CL_TG.AutoSize = true;
		((Control)lblDG_CL_TG).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		lblDG_CL_TG.ImeMode = (ImeMode)0;
		Label obj32 = lblDG_CL_TG;
		location = new Point(19, 231);
		((Control)obj32).Location = location;
		((Control)lblDG_CL_TG).Name = "lblDG_CL_TG";
		Label obj33 = lblDG_CL_TG;
		size = new Size(164, 13);
		((Control)obj33).Size = size;
		((Control)lblDG_CL_TG).TabIndex = 179;
		lblDG_CL_TG.Text = "Đánh giá chênh lệch tỷ giá:";
		lblDG_CL_TG.TextAlign = (ContentAlignment)16;
		lblMa_NH.AutoSize = true;
		Label obj34 = lblMa_NH;
		location = new Point(32, 349);
		((Control)obj34).Location = location;
		((Control)lblMa_NH).Name = "lblMa_NH";
		Label obj35 = lblMa_NH;
		size = new Size(76, 13);
		((Control)obj35).Size = size;
		((Control)lblMa_NH).TabIndex = 180;
		lblMa_NH.Text = "Mã ngân hàng";
		txtMa_ngh.AutoLookup = true;
		txtMa_ngh.AutoValid = true;
		((TextBoxBase)txtMa_ngh).BackColor = SystemColors.Info;
		((TextBox)txtMa_ngh).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_ngh;
		location = new Point(192, 346);
		((Control)asTextBox3).Location = location;
		txtMa_ngh.LookupCodeName = "MA_NGH";
		((Control)txtMa_ngh).Name = "txtMa_ngh";
		txtMa_ngh.NameControl = null;
		AsTextBox asTextBox4 = txtMa_ngh;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_ngh).TabIndex = 10;
		txtMa_ngh.UseAutoCompleteSource = true;
		txtMa_ngh.ValidReturnFieldList = "TEN_NGH";
		((ButtonBase)chkYc_phi).AutoSize = true;
		chkYc_phi.Checked = false;
		AsCheckBox asCheckBox6 = chkYc_phi;
		location = new Point(179, 171);
		((Control)asCheckBox6).Location = location;
		((Control)chkYc_phi).Name = "chkYc_phi";
		AsCheckBox asCheckBox7 = chkYc_phi;
		size = new Size(132, 17);
		((Control)asCheckBox7).Size = size;
		((Control)chkYc_phi).TabIndex = 6;
		((ButtonBase)chkYc_phi).Text = "Bắt buộc nhập mã phí";
		chkYc_phi.TextValue = "0";
		((ButtonBase)chkYc_phi).UseVisualStyleBackColor = true;
		((ButtonBase)chkYc_spct).AutoSize = true;
		chkYc_spct.Checked = false;
		AsCheckBox asCheckBox8 = chkYc_spct;
		location = new Point(179, 194);
		((Control)asCheckBox8).Location = location;
		((Control)chkYc_spct).Name = "chkYc_spct";
		AsCheckBox asCheckBox9 = chkYc_spct;
		size = new Size(214, 17);
		((Control)asCheckBox9).Size = size;
		((Control)chkYc_spct).TabIndex = 7;
		((ButtonBase)chkYc_spct).Text = "Bắt buộc nhập mã sản phẩm/công trình";
		chkYc_spct.TextValue = "0";
		((ButtonBase)chkYc_spct).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(842, 529);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmGLDMTKEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtTk).MaxLength = base.MyDictInfo.code_length;
		((Control)txtTk).Select();
		InitCombobox();
		base.RowToEdit["ten_tk"] = base.RowToEdit["ten_tk"].ToString().Trim();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			((ComboBox)cboCach_tinh_tygia_co).SelectedIndex = 0;
			((ComboBox)cboCach_Tinh_tygia_no).SelectedIndex = 0;
			((ComboBox)cboKieu_sd).SelectedIndex = 0;
			txtTen_Tk.Text = Strings.LTrim(txtTen_Tk.Text);
		}
		else
		{
			txtTen_Tk.Text = Strings.LTrim(txtTen_Tk.Text);
		}
		RowToEdit["isSave"] = 1;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtTk).Enabled = false;
		((Control)txtTen_Tk).Select();
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtTk;
		CreateDataBinding(ref ojb, "Tk");
		txtTk = (TextBox)ojb;
		ojb = (Control)(object)txtTen_Tk;
		CreateDataBinding(ref ojb, "Ten_Tk");
		txtTen_Tk = (TextBox)ojb;
		ojb = (Control)(object)chkTk_Cn;
		CreateDataBinding(ref ojb, "Tk_Cn", "Checked");
		chkTk_Cn = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkTk_Sc;
		CreateDataBinding(ref ojb, "Tk_Sc", "Checked");
		chkTk_Sc = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkYc_phi;
		CreateDataBinding(ref ojb, "Yc_phi", "Checked");
		chkYc_phi = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkYc_spct;
		CreateDataBinding(ref ojb, "Yc_spct", "Checked");
		chkYc_spct = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)cboMa_Nt;
		CreateDataBinding(ref ojb, "Ma_Nt", "MA_NT");
		cboMa_Nt = (AsComboBoxNT)(object)ojb;
		ojb = (Control)(object)cboCach_tinh_tygia_co;
		CreateDataBinding(ref ojb, "pp_tinh_tggs_co", "SelectedValue");
		cboCach_tinh_tygia_co = (AsComboBox)(object)ojb;
		ojb = (Control)(object)cboCach_Tinh_tygia_no;
		CreateDataBinding(ref ojb, "pp_tinh_tggs_no", "SelectedValue");
		cboCach_Tinh_tygia_no = (AsComboBox)(object)ojb;
		ojb = (Control)(object)cboKieu_sd;
		CreateDataBinding(ref ojb, "kieu_sd", "SelectedValue");
		cboKieu_sd = (AsComboBox)(object)ojb;
		ojb = (Control)(object)txtSo_tk;
		CreateDataBinding(ref ojb, "So_Tk");
		txtSo_tk = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTen_ngh;
		CreateDataBinding(ref ojb, "Ten_Ngh");
		txtTen_ngh = (TextBox)ojb;
		ojb = (Control)(object)txtTinh_tp;
		CreateDataBinding(ref ojb, "Tinh_Tp");
		txtTinh_tp = (TextBox)ojb;
		ojb = (Control)(object)txtMa_ngh;
		CreateDataBinding(ref ojb, "Ma_ngh");
		txtMa_ngh = (AsTextBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		sTen_ngh = txtTen_ngh.Text;
		return (ChkEmtyTextBox(txtTk) && ChkEmtyTextBox(txtTen_Tk) && CheckTkMe() && base.ValidData()) ? true : false;
	}

	protected override bool InsertToDB()
	{
		base.RowToEdit["ten_ngh"] = sTen_ngh;
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtTk).Select();
		}
		return flag;
	}

	protected override bool UpdateDB()
	{
		base.RowToEdit["ten_ngh"] = sTen_ngh;
		bool result = base.UpdateDB();
		base.RowToEdit["ten_tk"] = Operators.AddObject((object)Strings.Space(Conversions.ToInteger(Operators.MultiplyObject(Operators.SubtractObject(base.RowToEdit["bac_tk"], (object)1), (object)3))), base.RowToEdit["ten_tk"]);
		return result;
	}

	private bool ChkKsds()
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(true);
		if ((Operators.ConditionalCompareObjectEqual(((ListControl)cboKieu_sd).SelectedValue, (object)3, false) && Operators.ConditionalCompareObjectEqual(chkTk_Cn.Checked, (object)false, false)) ? true : false)
		{
			text = Conversions.ToString(false);
			CMessageBox.Show(50147);
		}
		return Conversions.ToBoolean(text);
	}

	private bool CheckTkMe()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		IGLDMTKDAO iGLDMTKDAO = (IGLDMTKDAO)DAOFactory.CreateDAOInstance("GLDMTKDAO", "GLDMTK");
		int num = iGLDMTKDAO.CheckTkMe(Conversions.ToString(Helper.Repl_Null(txtTk.Text.Trim(), isNum: false)));
		if (num == 0)
		{
			return true;
		}
		if ((int)CMessageBox.Show(num, SystemInformations.ProductName, (MessageBoxButtons)4) == 6)
		{
			return true;
		}
		return false;
	}

	private void InitCombobox()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		Dictionary<string, string>[] array = new Dictionary<string, string>[3];
		BindingSource[] array2 = (BindingSource[])(object)new BindingSource[3];
		AsComboBox asComboBox = cboCach_tinh_tygia_co;
		array[0] = new Dictionary<string, string>();
		array[0].Add("0", Conversions.ToString(((ComboBox)asComboBox).Items[0]));
		array[0].Add("1", Conversions.ToString(((ComboBox)asComboBox).Items[1]));
		array[0].Add("2", Conversions.ToString(((ComboBox)asComboBox).Items[2]));
		array[0].Add("3", Conversions.ToString(((ComboBox)asComboBox).Items[3]));
		array2[0] = new BindingSource((object)array[0], (string)null);
		((ListControl)asComboBox).DisplayMember = "value";
		((ListControl)asComboBox).ValueMember = "key";
		((ComboBox)asComboBox).DataSource = array2[0];
		asComboBox = null;
		AsComboBox asComboBox2 = cboKieu_sd;
		array[1] = new Dictionary<string, string>();
		array[1].Add("0", Conversions.ToString(((ComboBox)asComboBox2).Items[0]));
		array[1].Add("1", Conversions.ToString(((ComboBox)asComboBox2).Items[1]));
		array[1].Add("2", Conversions.ToString(((ComboBox)asComboBox2).Items[2]));
		array[1].Add("3", Conversions.ToString(((ComboBox)asComboBox2).Items[3]));
		array2[1] = new BindingSource((object)array[1], (string)null);
		((ListControl)asComboBox2).DisplayMember = "value";
		((ListControl)asComboBox2).ValueMember = "key";
		((ComboBox)asComboBox2).DataSource = array2[1];
		asComboBox2 = null;
		AsComboBox asComboBox3 = cboCach_Tinh_tygia_no;
		array[2] = new Dictionary<string, string>();
		array[2].Add("0", Conversions.ToString(((ComboBox)asComboBox3).Items[0]));
		array[2].Add("1", Conversions.ToString(((ComboBox)asComboBox3).Items[1]));
		array[2].Add("2", Conversions.ToString(((ComboBox)asComboBox3).Items[2]));
		array[2].Add("3", Conversions.ToString(((ComboBox)asComboBox3).Items[3]));
		array2[2] = new BindingSource((object)array[2], (string)null);
		((ListControl)asComboBox3).DisplayMember = "value";
		((ListControl)asComboBox3).ValueMember = "key";
		((ComboBox)asComboBox3).DataSource = array2[2];
		asComboBox3 = null;
	}

	private void txtMa_ngh_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (((TextBox)txtMa_ngh).Text.Trim().Length > 0 && Helper.Repl_Null(txtMa_ngh.ValidReturnFieldList, isNum: false).ToString().ToUpper()
			.Contains("TEN_NGH"))
		{
			txtTen_ngh.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["TEN_NGH"]), isNum: false));
		}
	}
}
