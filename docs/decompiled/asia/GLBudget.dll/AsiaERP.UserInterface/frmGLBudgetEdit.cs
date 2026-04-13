using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmGLBudgetEdit : frmDMEdit
{
	private IContainer components;

	[AccessedThroughProperty("grbThamSoDT")]
	private GroupBox _grbThamSoDT;

	[AccessedThroughProperty("radCo")]
	private RadioButton _radCo;

	[AccessedThroughProperty("radNo")]
	private RadioButton _radNo;

	[AccessedThroughProperty("txtTk_DoiUng")]
	private AsTextBox _txtTk_DoiUng;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("lblTen_phi")]
	private Label _lblTen_phi;

	[AccessedThroughProperty("lblTen_BP")]
	private Label _lblTen_BP;

	[AccessedThroughProperty("txtMa_phi")]
	private AsTextBox _txtMa_phi;

	[AccessedThroughProperty("txtMa_BP")]
	private AsTextBox _txtMa_BP;

	[AccessedThroughProperty("txtMa_TK")]
	private AsTextBox _txtMa_TK;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("grbPhuong_phap_dc")]
	private GroupBox _grbPhuong_phap_dc;

	[AccessedThroughProperty("txtGia_tri")]
	private AsTextNumeric _txtGia_tri;

	[AccessedThroughProperty("txtGiaTriCS")]
	private AsTextNumeric _txtGiaTriCS;

	[AccessedThroughProperty("lblGiatriCS")]
	private Label _lblGiatriCS;

	[AccessedThroughProperty("lblphantram")]
	private Label _lblphantram;

	[AccessedThroughProperty("lblGiatri")]
	private Label _lblGiatri;

	[AccessedThroughProperty("btnThem")]
	private Button _btnThem;

	[AccessedThroughProperty("btnThay_the")]
	private Button _btnThay_the;

	[AccessedThroughProperty("rbtOptional8")]
	private RadioButton _rbtOptional8;

	[AccessedThroughProperty("rbtOptional7")]
	private RadioButton _rbtOptional7;

	[AccessedThroughProperty("rbtOptional5")]
	private RadioButton _rbtOptional5;

	[AccessedThroughProperty("rbtOptional6")]
	private RadioButton _rbtOptional6;

	[AccessedThroughProperty("rbtOptional4")]
	private RadioButton _rbtOptional4;

	[AccessedThroughProperty("rbtOptional2")]
	private RadioButton _rbtOptional2;

	[AccessedThroughProperty("rbtOptional3")]
	private RadioButton _rbtOptional3;

	[AccessedThroughProperty("rbtOptional1")]
	private RadioButton _rbtOptional1;

	[AccessedThroughProperty("txtTongCu")]
	private AsTextNumeric _txtTongCu;

	[AccessedThroughProperty("txtTongMoi")]
	private AsTextNumeric _txtTongMoi;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("lblTen_spct_M")]
	private Label _lblTen_spct_M;

	[AccessedThroughProperty("txtMa_spct_M")]
	private AsTextBox _txtMa_spct_M;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txtTK_doiUng_M")]
	private AsTextBox _txtTK_doiUng_M;

	[AccessedThroughProperty("lblTK_doiUng_M")]
	private Label _lblTK_doiUng_M;

	[AccessedThroughProperty("txtMa_TK_M")]
	private AsTextBox _txtMa_TK_M;

	[AccessedThroughProperty("lblTen_TK_M")]
	private Label _lblTen_TK_M;

	[AccessedThroughProperty("txtMa_BP_M")]
	private AsTextBox _txtMa_BP_M;

	[AccessedThroughProperty("lblTen_BP_M")]
	private Label _lblTen_BP_M;

	[AccessedThroughProperty("txtMa_Phi_M")]
	private AsTextBox _txtMa_Phi_M;

	[AccessedThroughProperty("lblTen_phi_M")]
	private Label _lblTen_phi_M;

	[AccessedThroughProperty("cboNam_M")]
	private ComboBox _cboNam_M;

	[AccessedThroughProperty("rbtCo")]
	private RadioButton _rbtCo;

	[AccessedThroughProperty("rbtNo")]
	private RadioButton _rbtNo;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("grbDu_toan")]
	private GroupBox _grbDu_toan;

	[AccessedThroughProperty("adgBudget")]
	private AsDataGridView _adgBudget;

	[AccessedThroughProperty("btnMau")]
	private Button _btnMau;

	[AccessedThroughProperty("lblTK_DoiUng")]
	private Label _lblTK_DoiUng;

	[AccessedThroughProperty("dgvcThang")]
	private DataGridViewAsTextBoxColumn _dgvcThang;

	[AccessedThroughProperty("dgvcDu_toan")]
	private DataGridViewAsTextNumericColumn _dgvcDu_toan;

	[AccessedThroughProperty("dgvcThuc_te")]
	private DataGridViewAsTextNumericColumn _dgvcThuc_te;

	private int f_year;

	internal virtual GroupBox grbThamSoDT
	{
		[DebuggerNonUserCode]
		get
		{
			return _grbThamSoDT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grbThamSoDT = value;
		}
	}

	internal virtual RadioButton radCo
	{
		[DebuggerNonUserCode]
		get
		{
			return _radCo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = radCo_Click;
			if (_radCo != null)
			{
				((Control)_radCo).Click -= eventHandler;
			}
			_radCo = value;
			if (_radCo != null)
			{
				((Control)_radCo).Click += eventHandler;
			}
		}
	}

	internal virtual RadioButton radNo
	{
		[DebuggerNonUserCode]
		get
		{
			return _radNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = radNo_Click;
			if (_radNo != null)
			{
				((Control)_radNo).Click -= eventHandler;
			}
			_radNo = value;
			if (_radNo != null)
			{
				((Control)_radNo).Click += eventHandler;
			}
		}
	}

	internal virtual AsTextBox txtTk_DoiUng
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_DoiUng;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtTk_DoiUng_AfterCodeValidating;
			if (_txtTk_DoiUng != null)
			{
				_txtTk_DoiUng.AfterCodeValidating -= obj;
			}
			_txtTk_DoiUng = value;
			if (_txtTk_DoiUng != null)
			{
				_txtTk_DoiUng.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Label4
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

	internal virtual Label lblTen_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_spct = value;
		}
	}

	internal virtual AsTextBox txtMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_spct_AfterCodeValidating;
			if (_txtMa_spct != null)
			{
				_txtMa_spct.AfterCodeValidating -= obj;
			}
			_txtMa_spct = value;
			if (_txtMa_spct != null)
			{
				_txtMa_spct.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Label lblTen_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_phi = value;
		}
	}

	internal virtual Label lblTen_BP
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_BP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_BP = value;
		}
	}

	internal virtual AsTextBox txtMa_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_phi_AfterCodeValidating;
			if (_txtMa_phi != null)
			{
				_txtMa_phi.AfterCodeValidating -= obj;
			}
			_txtMa_phi = value;
			if (_txtMa_phi != null)
			{
				_txtMa_phi.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual AsTextBox txtMa_BP
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_BP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_BP_AfterCodeValidating;
			if (_txtMa_BP != null)
			{
				_txtMa_BP.AfterCodeValidating -= obj;
			}
			_txtMa_BP = value;
			if (_txtMa_BP != null)
			{
				_txtMa_BP.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual AsTextBox txtMa_TK
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_TK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AsTextBox.AfterCodeValidatingHandler obj = txtMa_TK_AfterCodeValidating;
			if (_txtMa_TK != null)
			{
				_txtMa_TK.AfterCodeValidating -= obj;
			}
			_txtMa_TK = value;
			if (_txtMa_TK != null)
			{
				_txtMa_TK.AfterCodeValidating += obj;
			}
		}
	}

	internal virtual Label lblTen_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk = value;
		}
	}

	internal virtual Label Label3
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

	internal virtual Label Label2
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

	internal virtual Label Label1
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

	internal virtual GroupBox grbPhuong_phap_dc
	{
		[DebuggerNonUserCode]
		get
		{
			return _grbPhuong_phap_dc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grbPhuong_phap_dc = value;
		}
	}

	internal virtual AsTextNumeric txtGia_tri
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGia_tri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGia_tri = value;
		}
	}

	internal virtual AsTextNumeric txtGiaTriCS
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGiaTriCS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtGiaTriCS = value;
		}
	}

	internal virtual Label lblGiatriCS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGiatriCS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGiatriCS = value;
		}
	}

	internal virtual Label lblphantram
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblphantram;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblphantram = value;
		}
	}

	internal virtual Label lblGiatri
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGiatri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGiatri = value;
		}
	}

	internal virtual Button btnThem
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnThem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnThem_Click;
			if (_btnThem != null)
			{
				((Control)_btnThem).Click -= eventHandler;
			}
			_btnThem = value;
			if (_btnThem != null)
			{
				((Control)_btnThem).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnThay_the
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnThay_the;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnThay_the_Click;
			if (_btnThay_the != null)
			{
				((Control)_btnThay_the).Click -= eventHandler;
			}
			_btnThay_the = value;
			if (_btnThay_the != null)
			{
				((Control)_btnThay_the).Click += eventHandler;
			}
		}
	}

	internal virtual RadioButton rbtOptional8
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtOptional8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbtOptional8_CheckedChanged;
			if (_rbtOptional8 != null)
			{
				_rbtOptional8.CheckedChanged -= eventHandler;
			}
			_rbtOptional8 = value;
			if (_rbtOptional8 != null)
			{
				_rbtOptional8.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton rbtOptional7
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtOptional7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbtOptional7_CheckedChanged;
			if (_rbtOptional7 != null)
			{
				_rbtOptional7.CheckedChanged -= eventHandler;
			}
			_rbtOptional7 = value;
			if (_rbtOptional7 != null)
			{
				_rbtOptional7.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton rbtOptional5
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtOptional5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbtOptional5_CheckedChanged;
			if (_rbtOptional5 != null)
			{
				_rbtOptional5.CheckedChanged -= eventHandler;
			}
			_rbtOptional5 = value;
			if (_rbtOptional5 != null)
			{
				_rbtOptional5.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton rbtOptional6
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtOptional6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbtOptional6_CheckedChanged;
			if (_rbtOptional6 != null)
			{
				_rbtOptional6.CheckedChanged -= eventHandler;
			}
			_rbtOptional6 = value;
			if (_rbtOptional6 != null)
			{
				_rbtOptional6.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton rbtOptional4
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtOptional4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbtOptional4_CheckedChanged;
			if (_rbtOptional4 != null)
			{
				_rbtOptional4.CheckedChanged -= eventHandler;
			}
			_rbtOptional4 = value;
			if (_rbtOptional4 != null)
			{
				_rbtOptional4.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton rbtOptional2
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtOptional2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbtOptional2_CheckedChanged;
			if (_rbtOptional2 != null)
			{
				_rbtOptional2.CheckedChanged -= eventHandler;
			}
			_rbtOptional2 = value;
			if (_rbtOptional2 != null)
			{
				_rbtOptional2.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton rbtOptional3
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtOptional3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbtOptional3_CheckedChanged;
			if (_rbtOptional3 != null)
			{
				_rbtOptional3.CheckedChanged -= eventHandler;
			}
			_rbtOptional3 = value;
			if (_rbtOptional3 != null)
			{
				_rbtOptional3.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton rbtOptional1
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtOptional1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = rbtOptional1_CheckedChanged;
			if (_rbtOptional1 != null)
			{
				_rbtOptional1.CheckedChanged -= eventHandler;
			}
			_rbtOptional1 = value;
			if (_rbtOptional1 != null)
			{
				_rbtOptional1.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtTongCu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTongCu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTongCu = value;
		}
	}

	internal virtual AsTextNumeric txtTongMoi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTongMoi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTongMoi = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Label lblTen_spct_M
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_spct_M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_spct_M = value;
		}
	}

	internal virtual AsTextBox txtMa_spct_M
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_spct_M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_spct_M = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual AsTextBox txtTK_doiUng_M
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_doiUng_M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_doiUng_M = value;
		}
	}

	internal virtual Label lblTK_doiUng_M
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_doiUng_M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_doiUng_M = value;
		}
	}

	internal virtual AsTextBox txtMa_TK_M
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_TK_M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_TK_M = value;
		}
	}

	internal virtual Label lblTen_TK_M
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_TK_M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_TK_M = value;
		}
	}

	internal virtual AsTextBox txtMa_BP_M
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_BP_M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_BP_M = value;
		}
	}

	internal virtual Label lblTen_BP_M
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_BP_M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_BP_M = value;
		}
	}

	internal virtual AsTextBox txtMa_Phi_M
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_Phi_M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_Phi_M = value;
		}
	}

	internal virtual Label lblTen_phi_M
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_phi_M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_phi_M = value;
		}
	}

	internal virtual ComboBox cboNam_M
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNam_M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboNam_M = value;
		}
	}

	internal virtual RadioButton rbtCo
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtCo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rbtCo = value;
		}
	}

	internal virtual RadioButton rbtNo
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rbtNo = value;
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual GroupBox grbDu_toan
	{
		[DebuggerNonUserCode]
		get
		{
			return _grbDu_toan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grbDu_toan = value;
		}
	}

	internal virtual AsDataGridView adgBudget
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgBudget;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = adgBudget_CurrentCellChanged;
			if (_adgBudget != null)
			{
				((DataGridView)_adgBudget).CurrentCellChanged -= eventHandler;
			}
			_adgBudget = value;
			if (_adgBudget != null)
			{
				((DataGridView)_adgBudget).CurrentCellChanged += eventHandler;
			}
		}
	}

	internal virtual Button btnMau
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnMau;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnMau_Click;
			if (_btnMau != null)
			{
				((Control)_btnMau).Click -= eventHandler;
			}
			_btnMau = value;
			if (_btnMau != null)
			{
				((Control)_btnMau).Click += eventHandler;
			}
		}
	}

	internal virtual Label lblTK_DoiUng
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_DoiUng;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_DoiUng = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcThang
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThang = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcDu_toan
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDu_toan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDu_toan = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThuc_te
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThuc_te;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThuc_te = value;
		}
	}

	public frmGLBudgetEdit()
	{
		f_year = SystemInformations.FinancialYear;
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1706: Unknown result type (might be due to invalid IL or missing references)
		//IL_1710: Expected O, but got Unknown
		//IL_29eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f5: Expected O, but got Unknown
		//IL_2a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a9b: Expected O, but got Unknown
		//IL_2b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b69: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		grbThamSoDT = new GroupBox();
		lblTK_DoiUng = new Label();
		radCo = new RadioButton();
		radNo = new RadioButton();
		txtTk_DoiUng = new AsTextBox();
		Label8 = new Label();
		Label4 = new Label();
		lblTen_spct = new Label();
		txtMa_spct = new AsTextBox();
		Label9 = new Label();
		lblTen_phi = new Label();
		lblTen_BP = new Label();
		txtMa_phi = new AsTextBox();
		txtMa_BP = new AsTextBox();
		txtMa_TK = new AsTextBox();
		lblTen_tk = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		txtTongCu = new AsTextNumeric();
		txtTongMoi = new AsTextNumeric();
		Label7 = new Label();
		grbPhuong_phap_dc = new GroupBox();
		txtGia_tri = new AsTextNumeric();
		txtGiaTriCS = new AsTextNumeric();
		lblGiatriCS = new Label();
		lblphantram = new Label();
		lblGiatri = new Label();
		btnThem = new Button();
		btnThay_the = new Button();
		rbtOptional8 = new RadioButton();
		rbtOptional7 = new RadioButton();
		rbtOptional5 = new RadioButton();
		rbtOptional6 = new RadioButton();
		rbtOptional4 = new RadioButton();
		rbtOptional2 = new RadioButton();
		rbtOptional3 = new RadioButton();
		rbtOptional1 = new RadioButton();
		GroupBox1 = new GroupBox();
		lblTen_spct_M = new Label();
		txtMa_spct_M = new AsTextBox();
		Label5 = new Label();
		lblTK_doiUng_M = new Label();
		txtTK_doiUng_M = new AsTextBox();
		txtMa_TK_M = new AsTextBox();
		lblTen_TK_M = new Label();
		txtMa_BP_M = new AsTextBox();
		lblTen_BP_M = new Label();
		txtMa_Phi_M = new AsTextBox();
		lblTen_phi_M = new Label();
		cboNam_M = new ComboBox();
		rbtCo = new RadioButton();
		rbtNo = new RadioButton();
		Label14 = new Label();
		Label15 = new Label();
		Label13 = new Label();
		Label10 = new Label();
		Label11 = new Label();
		Label12 = new Label();
		grbDu_toan = new GroupBox();
		adgBudget = new AsDataGridView();
		dgvcThang = new DataGridViewAsTextBoxColumn();
		dgvcDu_toan = new DataGridViewAsTextNumericColumn();
		dgvcThuc_te = new DataGridViewAsTextNumericColumn();
		btnMau = new Button();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)grbThamSoDT).SuspendLayout();
		((Control)grbPhuong_phap_dc).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((Control)grbDu_toan).SuspendLayout();
		((ISupportInitialize)adgBudget).BeginInit();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(762, 495);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 540);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 540);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Anchor = (AnchorStyles)5;
		((Control)gbLine).BackColor = SystemColors.Control;
		((Control)gbLine).Controls.Add((Control)(object)grbDu_toan);
		((Control)gbLine).Controls.Add((Control)(object)txtTongCu);
		((Control)gbLine).Controls.Add((Control)(object)grbPhuong_phap_dc);
		((Control)gbLine).Controls.Add((Control)(object)GroupBox1);
		((Control)gbLine).Controls.Add((Control)(object)Label7);
		((Control)gbLine).Controls.Add((Control)(object)txtTongMoi);
		((Control)gbLine).Controls.Add((Control)(object)grbThamSoDT);
		GroupBox obj3 = gbLine;
		location = new Point(12, 2);
		((Control)obj3).Location = location;
		GroupBox obj4 = gbLine;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(0);
		((Control)obj4).Padding = padding;
		GroupBox obj5 = gbLine;
		Size size = new Size(886, 532);
		((Control)obj5).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)grbThamSoDT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTongMoi, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label7, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)GroupBox1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)grbPhuong_phap_dc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTongCu, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)grbDu_toan, 0);
		((Control)grbThamSoDT).Controls.Add((Control)(object)lblTK_DoiUng);
		((Control)grbThamSoDT).Controls.Add((Control)(object)radCo);
		((Control)grbThamSoDT).Controls.Add((Control)(object)radNo);
		((Control)grbThamSoDT).Controls.Add((Control)(object)txtTk_DoiUng);
		((Control)grbThamSoDT).Controls.Add((Control)(object)Label8);
		((Control)grbThamSoDT).Controls.Add((Control)(object)Label4);
		((Control)grbThamSoDT).Controls.Add((Control)(object)lblTen_spct);
		((Control)grbThamSoDT).Controls.Add((Control)(object)txtMa_spct);
		((Control)grbThamSoDT).Controls.Add((Control)(object)Label9);
		((Control)grbThamSoDT).Controls.Add((Control)(object)lblTen_phi);
		((Control)grbThamSoDT).Controls.Add((Control)(object)lblTen_BP);
		((Control)grbThamSoDT).Controls.Add((Control)(object)txtMa_phi);
		((Control)grbThamSoDT).Controls.Add((Control)(object)txtMa_BP);
		((Control)grbThamSoDT).Controls.Add((Control)(object)txtMa_TK);
		((Control)grbThamSoDT).Controls.Add((Control)(object)lblTen_tk);
		((Control)grbThamSoDT).Controls.Add((Control)(object)Label3);
		((Control)grbThamSoDT).Controls.Add((Control)(object)Label2);
		((Control)grbThamSoDT).Controls.Add((Control)(object)Label1);
		GroupBox obj6 = grbThamSoDT;
		location = new Point(17, 10);
		((Control)obj6).Location = location;
		((Control)grbThamSoDT).Name = "grbThamSoDT";
		GroupBox obj7 = grbThamSoDT;
		size = new Size(417, 171);
		((Control)obj7).Size = size;
		((Control)grbThamSoDT).TabIndex = 0;
		grbThamSoDT.TabStop = false;
		grbThamSoDT.Text = "Tham số dự toán";
		lblTK_DoiUng.ImeMode = (ImeMode)0;
		Label obj8 = lblTK_DoiUng;
		location = new Point(186, 71);
		((Control)obj8).Location = location;
		((Control)lblTK_DoiUng).Name = "lblTK_DoiUng";
		Label obj9 = lblTK_DoiUng;
		size = new Size(192, 16);
		((Control)obj9).Size = size;
		((Control)lblTK_DoiUng).TabIndex = 43;
		((ButtonBase)radCo).ImeMode = (ImeMode)0;
		RadioButton obj10 = radCo;
		location = new Point(137, 43);
		((Control)obj10).Location = location;
		((Control)radCo).Name = "radCo";
		RadioButton obj11 = radCo;
		size = new Size(40, 16);
		((Control)obj11).Size = size;
		((Control)radCo).TabIndex = 42;
		((ButtonBase)radCo).Text = "Có";
		((ButtonBase)radNo).AutoSize = true;
		radNo.Checked = true;
		((ButtonBase)radNo).ImeMode = (ImeMode)0;
		RadioButton obj12 = radNo;
		location = new Point(89, 43);
		((Control)obj12).Location = location;
		((Control)radNo).Name = "radNo";
		RadioButton obj13 = radNo;
		size = new Size(39, 17);
		((Control)obj13).Size = size;
		((Control)radNo).TabIndex = 41;
		radNo.TabStop = true;
		((ButtonBase)radNo).Text = "Nợ";
		txtTk_DoiUng.AutoLookup = true;
		txtTk_DoiUng.AutoValid = true;
		((TextBoxBase)txtTk_DoiUng).BackColor = SystemColors.Info;
		((TextBox)txtTk_DoiUng).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTk_DoiUng;
		location = new Point(89, 68);
		((Control)asTextBox).Location = location;
		txtTk_DoiUng.LookupCodeName = "TK";
		((Control)txtTk_DoiUng).Name = "txtTk_DoiUng";
		txtTk_DoiUng.NameControl = lblTK_DoiUng;
		txtTk_DoiUng.SD = true;
		AsTextBox asTextBox2 = txtTk_DoiUng;
		size = new Size(88, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTk_DoiUng).TabIndex = 1;
		txtTk_DoiUng.UseAutoCompleteSource = true;
		txtTk_DoiUng.ValidReturnFieldList = "ma_nt,ten_tk";
		Label8.AutoSize = true;
		Label8.ImeMode = (ImeMode)0;
		Label label = Label8;
		location = new Point(13, 71);
		((Control)label).Location = location;
		((Control)Label8).Name = "Label8";
		Label label2 = Label8;
		size = new Size(60, 13);
		((Control)label2).Size = size;
		((Control)Label8).TabIndex = 38;
		Label8.Text = "TK đối ứng";
		Label4.AutoSize = true;
		Label4.ImeMode = (ImeMode)0;
		Label label3 = Label4;
		location = new Point(13, 47);
		((Control)label3).Location = location;
		((Control)Label4).Name = "Label4";
		Label label4 = Label4;
		size = new Size(57, 13);
		((Control)label4).Size = size;
		((Control)Label4).TabIndex = 36;
		Label4.Text = "PS thực tế";
		lblTen_spct.ImeMode = (ImeMode)0;
		Label obj14 = lblTen_spct;
		location = new Point(186, 146);
		((Control)obj14).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj15 = lblTen_spct;
		size = new Size(192, 16);
		((Control)obj15).Size = size;
		((Control)lblTen_spct).TabIndex = 30;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = true;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_spct;
		location = new Point(89, 141);
		((Control)asTextBox3).Location = location;
		txtMa_spct.LookupCodeName = "Ma_SPCT";
		txtMa_spct.LookupWhereCondition = "ksd=0";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox4 = txtMa_spct;
		size = new Size(88, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_spct).TabIndex = 4;
		txtMa_spct.UseAutoCompleteSource = true;
		txtMa_spct.ValidReturnFieldList = "ma_spct,ten_spct";
		Label9.AutoSize = true;
		Label9.ImeMode = (ImeMode)0;
		Label label5 = Label9;
		location = new Point(13, 146);
		((Control)label5).Location = location;
		((Control)Label9).Name = "Label9";
		Label label6 = Label9;
		size = new Size(35, 13);
		((Control)label6).Size = size;
		((Control)Label9).TabIndex = 29;
		Label9.Text = "SPCT";
		lblTen_phi.ImeMode = (ImeMode)0;
		Label obj16 = lblTen_phi;
		location = new Point(186, 121);
		((Control)obj16).Location = location;
		((Control)lblTen_phi).Name = "lblTen_phi";
		Label obj17 = lblTen_phi;
		size = new Size(192, 16);
		((Control)obj17).Size = size;
		((Control)lblTen_phi).TabIndex = 27;
		lblTen_BP.ImeMode = (ImeMode)0;
		Label obj18 = lblTen_BP;
		location = new Point(186, 96);
		((Control)obj18).Location = location;
		((Control)lblTen_BP).Name = "lblTen_BP";
		Label obj19 = lblTen_BP;
		size = new Size(192, 16);
		((Control)obj19).Size = size;
		((Control)lblTen_BP).TabIndex = 26;
		txtMa_phi.AutoLookup = true;
		txtMa_phi.AutoValid = true;
		((TextBoxBase)txtMa_phi).BackColor = SystemColors.Info;
		((TextBox)txtMa_phi).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMa_phi;
		location = new Point(89, 116);
		((Control)asTextBox5).Location = location;
		txtMa_phi.LookupCodeName = "Ma_PHI";
		txtMa_phi.LookupWhereCondition = "ksd=0";
		((Control)txtMa_phi).Name = "txtMa_phi";
		txtMa_phi.NameControl = lblTen_phi;
		AsTextBox asTextBox6 = txtMa_phi;
		size = new Size(88, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMa_phi).TabIndex = 3;
		txtMa_phi.UseAutoCompleteSource = true;
		txtMa_phi.ValidReturnFieldList = "ma_phi,ten_phi";
		txtMa_BP.AutoLookup = true;
		txtMa_BP.AutoValid = true;
		((TextBoxBase)txtMa_BP).BackColor = SystemColors.Info;
		((TextBox)txtMa_BP).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMa_BP;
		location = new Point(89, 92);
		((Control)asTextBox7).Location = location;
		txtMa_BP.LookupCodeName = "Ma_BP";
		txtMa_BP.LookupWhereCondition = "ksd=0";
		((Control)txtMa_BP).Name = "txtMa_BP";
		txtMa_BP.NameControl = lblTen_BP;
		AsTextBox asTextBox8 = txtMa_BP;
		size = new Size(88, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMa_BP).TabIndex = 2;
		txtMa_BP.UseAutoCompleteSource = true;
		txtMa_BP.ValidReturnFieldList = "ma_bp,ten_bp";
		txtMa_TK.AutoLookup = true;
		txtMa_TK.AutoValid = true;
		((TextBoxBase)txtMa_TK).BackColor = SystemColors.Info;
		((TextBox)txtMa_TK).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_TK;
		location = new Point(89, 17);
		((Control)asTextBox9).Location = location;
		txtMa_TK.LookupCodeName = "TK";
		((Control)txtMa_TK).Name = "txtMa_TK";
		txtMa_TK.NameControl = lblTen_tk;
		txtMa_TK.SD = true;
		AsTextBox asTextBox10 = txtMa_TK;
		size = new Size(88, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_TK).TabIndex = 0;
		txtMa_TK.UseAutoCompleteSource = true;
		txtMa_TK.ValidReturnFieldList = "ma_nt,ten_tk";
		lblTen_tk.ImeMode = (ImeMode)0;
		Label obj20 = lblTen_tk;
		location = new Point(183, 19);
		((Control)obj20).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj21 = lblTen_tk;
		size = new Size(216, 16);
		((Control)obj21).Size = size;
		((Control)lblTen_tk).TabIndex = 20;
		Label3.AutoSize = true;
		Label3.ImeMode = (ImeMode)0;
		Label label7 = Label3;
		location = new Point(13, 119);
		((Control)label7).Location = location;
		((Control)Label3).Name = "Label3";
		Label label8 = Label3;
		size = new Size(41, 13);
		((Control)label8).Size = size;
		((Control)Label3).TabIndex = 15;
		Label3.Text = "Mã phí";
		Label2.AutoSize = true;
		Label2.ImeMode = (ImeMode)0;
		Label label9 = Label2;
		location = new Point(13, 95);
		((Control)label9).Location = location;
		((Control)Label2).Name = "Label2";
		Label label10 = Label2;
		size = new Size(47, 13);
		((Control)label10).Size = size;
		((Control)Label2).TabIndex = 14;
		Label2.Text = "Bộ phận";
		Label1.AutoSize = true;
		Label1.ImeMode = (ImeMode)0;
		Label label11 = Label1;
		location = new Point(13, 21);
		((Control)label11).Location = location;
		((Control)Label1).Name = "Label1";
		Label label12 = Label1;
		size = new Size(55, 13);
		((Control)label12).Size = size;
		((Control)Label1).TabIndex = 13;
		Label1.Text = "Tài khoản";
		txtTongCu.DecimalSymbol = ".";
		txtTongCu.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtTongCu;
		location = new Point(281, 493);
		((Control)asTextNumeric).Location = location;
		txtTongCu.Mask = "### ### ### ###.##";
		((Control)txtTongCu).Name = "txtTongCu";
		((TextBoxBase)txtTongCu).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtTongCu;
		size = new Size(150, 20);
		((Control)asTextNumeric2).Size = size;
		txtTongCu.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTongCu).TabIndex = 6;
		((TextBox)txtTongCu).Text = "0.00";
		((TextBox)txtTongCu).TextAlign = (HorizontalAlignment)1;
		txtTongCu.Value = 0;
		txtTongMoi.DecimalSymbol = ".";
		txtTongMoi.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtTongMoi;
		location = new Point(142, 493);
		((Control)asTextNumeric3).Location = location;
		txtTongMoi.Mask = "### ### ### ###.##";
		((Control)txtTongMoi).Name = "txtTongMoi";
		((TextBoxBase)txtTongMoi).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtTongMoi;
		size = new Size(133, 20);
		((Control)asTextNumeric4).Size = size;
		txtTongMoi.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTongMoi).TabIndex = 5;
		((TextBox)txtTongMoi).Text = "0.00";
		((TextBox)txtTongMoi).TextAlign = (HorizontalAlignment)1;
		txtTongMoi.Value = 0;
		Label7.AutoSize = true;
		Label7.ImeMode = (ImeMode)0;
		Label label13 = Label7;
		location = new Point(94, 496);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(32, 13);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 4;
		Label7.Text = "Tổng";
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)txtGia_tri);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)txtGiaTriCS);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)lblGiatriCS);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)lblphantram);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)lblGiatri);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)btnThem);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)btnThay_the);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)rbtOptional8);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)rbtOptional7);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)rbtOptional5);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)rbtOptional6);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)rbtOptional4);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)rbtOptional2);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)rbtOptional3);
		((Control)grbPhuong_phap_dc).Controls.Add((Control)(object)rbtOptional1);
		GroupBox obj22 = grbPhuong_phap_dc;
		location = new Point(440, 187);
		((Control)obj22).Location = location;
		((Control)grbPhuong_phap_dc).Name = "grbPhuong_phap_dc";
		GroupBox obj23 = grbPhuong_phap_dc;
		size = new Size(432, 299);
		((Control)obj23).Size = size;
		((Control)grbPhuong_phap_dc).TabIndex = 3;
		grbPhuong_phap_dc.TabStop = false;
		grbPhuong_phap_dc.Text = "Phương pháp điều chỉnh";
		txtGia_tri.DecimalSymbol = ".";
		txtGia_tri.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtGia_tri;
		location = new Point(141, 254);
		((Control)asTextNumeric5).Location = location;
		txtGia_tri.Mask = "### ### ### ###.##";
		((Control)txtGia_tri).Name = "txtGia_tri";
		AsTextNumeric asTextNumeric6 = txtGia_tri;
		size = new Size(168, 20);
		((Control)asTextNumeric6).Size = size;
		txtGia_tri.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGia_tri).TabIndex = 0;
		((TextBox)txtGia_tri).Text = "0.00";
		((TextBox)txtGia_tri).TextAlign = (HorizontalAlignment)1;
		txtGia_tri.Value = 0;
		txtGiaTriCS.DecimalSymbol = ".";
		txtGiaTriCS.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtGiaTriCS;
		location = new Point(141, 224);
		((Control)asTextNumeric7).Location = location;
		txtGiaTriCS.Mask = "### ### ### ###.##";
		((Control)txtGiaTriCS).Name = "txtGiaTriCS";
		AsTextNumeric asTextNumeric8 = txtGiaTriCS;
		size = new Size(168, 20);
		((Control)asTextNumeric8).Size = size;
		txtGiaTriCS.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtGiaTriCS).TabIndex = 1;
		((TextBox)txtGiaTriCS).Text = "0.00";
		((TextBox)txtGiaTriCS).TextAlign = (HorizontalAlignment)1;
		txtGiaTriCS.Value = 0;
		lblGiatriCS.AutoSize = true;
		lblGiatriCS.ImeMode = (ImeMode)0;
		Label obj24 = lblGiatriCS;
		location = new Point(29, 228);
		((Control)obj24).Location = location;
		((Control)lblGiatriCS).Name = "lblGiatriCS";
		Label obj25 = lblGiatriCS;
		size = new Size(63, 13);
		((Control)obj25).Size = size;
		((Control)lblGiatriCS).TabIndex = 19;
		lblGiatriCS.Text = "Giá trị cơ sở";
		((Control)lblGiatriCS).Visible = false;
		((Control)lblphantram).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1);
		lblphantram.ImeMode = (ImeMode)0;
		Label obj26 = lblphantram;
		location = new Point(317, 256);
		((Control)obj26).Location = location;
		((Control)lblphantram).Name = "lblphantram";
		Label obj27 = lblphantram;
		size = new Size(16, 16);
		((Control)obj27).Size = size;
		((Control)lblphantram).TabIndex = 17;
		lblphantram.Text = "%";
		((Control)lblphantram).Visible = false;
		lblGiatri.AutoSize = true;
		lblGiatri.ImeMode = (ImeMode)0;
		Label obj28 = lblGiatri;
		location = new Point(29, 258);
		((Control)obj28).Location = location;
		((Control)lblGiatri).Name = "lblGiatri";
		Label obj29 = lblGiatri;
		size = new Size(73, 13);
		((Control)obj29).Size = size;
		((Control)lblGiatri).TabIndex = 11;
		lblGiatri.Text = "Giá trị cố định";
		((Control)lblGiatri).Visible = false;
		((Control)btnThem).Anchor = (AnchorStyles)0;
		((ButtonBase)btnThem).ImeMode = (ImeMode)0;
		Button obj30 = btnThem;
		location = new Point(339, 223);
		((Control)obj30).Location = location;
		((Control)btnThem).Name = "btnThem";
		Button obj31 = btnThem;
		size = new Size(75, 23);
		((Control)obj31).Size = size;
		((Control)btnThem).TabIndex = 2;
		((ButtonBase)btnThem).Text = "&Thêm";
		((Control)btnThay_the).Anchor = (AnchorStyles)0;
		((ButtonBase)btnThay_the).ImeMode = (ImeMode)0;
		Button obj32 = btnThay_the;
		location = new Point(339, 253);
		((Control)obj32).Location = location;
		((Control)btnThay_the).Name = "btnThay_the";
		Button obj33 = btnThay_the;
		size = new Size(75, 23);
		((Control)obj33).Size = size;
		((Control)btnThay_the).TabIndex = 3;
		((ButtonBase)btnThay_the).Text = "Th&ay thế";
		((ButtonBase)rbtOptional8).ImeMode = (ImeMode)0;
		RadioButton obj34 = rbtOptional8;
		location = new Point(32, 192);
		((Control)obj34).Location = location;
		((Control)rbtOptional8).Name = "rbtOptional8";
		RadioButton obj35 = rbtOptional8;
		size = new Size(304, 24);
		((Control)obj35).Size = size;
		((Control)rbtOptional8).TabIndex = 11;
		((ButtonBase)rbtOptional8).Text = "Phân chia theo trọng số giá trị";
		((ButtonBase)rbtOptional7).ImeMode = (ImeMode)0;
		RadioButton obj36 = rbtOptional7;
		location = new Point(32, 168);
		((Control)obj36).Location = location;
		((Control)rbtOptional7).Name = "rbtOptional7";
		RadioButton obj37 = rbtOptional7;
		size = new Size(304, 24);
		((Control)obj37).Size = size;
		((Control)rbtOptional7).TabIndex = 10;
		((ButtonBase)rbtOptional7).Text = "Tăng theo số lượng giá trị mẫu";
		((ButtonBase)rbtOptional5).ImeMode = (ImeMode)0;
		RadioButton obj38 = rbtOptional5;
		location = new Point(32, 120);
		((Control)obj38).Location = location;
		((Control)rbtOptional5).Name = "rbtOptional5";
		RadioButton obj39 = rbtOptional5;
		size = new Size(304, 24);
		((Control)obj39).Size = size;
		((Control)rbtOptional5).TabIndex = 8;
		((ButtonBase)rbtOptional5).Text = "Sao nguyên số liệu mẫu";
		((ButtonBase)rbtOptional6).ImeMode = (ImeMode)0;
		RadioButton obj40 = rbtOptional6;
		location = new Point(32, 144);
		((Control)obj40).Location = location;
		((Control)rbtOptional6).Name = "rbtOptional6";
		RadioButton obj41 = rbtOptional6;
		size = new Size(304, 24);
		((Control)obj41).Size = size;
		((Control)rbtOptional6).TabIndex = 9;
		((ButtonBase)rbtOptional6).Text = "Tăng theo % giá trị mẫu";
		((ButtonBase)rbtOptional4).ImeMode = (ImeMode)0;
		RadioButton obj42 = rbtOptional4;
		location = new Point(32, 96);
		((Control)obj42).Location = location;
		((Control)rbtOptional4).Name = "rbtOptional4";
		RadioButton obj43 = rbtOptional4;
		size = new Size(304, 24);
		((Control)obj43).Size = size;
		((Control)rbtOptional4).TabIndex = 7;
		((ButtonBase)rbtOptional4).Text = "Lũy kế theo giá trị";
		((ButtonBase)rbtOptional2).ImeMode = (ImeMode)0;
		RadioButton obj44 = rbtOptional2;
		location = new Point(32, 48);
		((Control)obj44).Location = location;
		((Control)rbtOptional2).Name = "rbtOptional2";
		RadioButton obj45 = rbtOptional2;
		size = new Size(304, 24);
		((Control)obj45).Size = size;
		((Control)rbtOptional2).TabIndex = 5;
		((ButtonBase)rbtOptional2).Text = "Phân chia giá trị";
		((ButtonBase)rbtOptional3).ImeMode = (ImeMode)0;
		RadioButton obj46 = rbtOptional3;
		location = new Point(32, 72);
		((Control)obj46).Location = location;
		((Control)rbtOptional3).Name = "rbtOptional3";
		RadioButton obj47 = rbtOptional3;
		size = new Size(304, 24);
		((Control)obj47).Size = size;
		((Control)rbtOptional3).TabIndex = 6;
		((ButtonBase)rbtOptional3).Text = "Lũy kế theo %";
		rbtOptional1.Checked = true;
		((ButtonBase)rbtOptional1).ImeMode = (ImeMode)0;
		RadioButton obj48 = rbtOptional1;
		location = new Point(32, 24);
		((Control)obj48).Location = location;
		((Control)rbtOptional1).Name = "rbtOptional1";
		RadioButton obj49 = rbtOptional1;
		size = new Size(304, 24);
		((Control)obj49).Size = size;
		((Control)rbtOptional1).TabIndex = 4;
		rbtOptional1.TabStop = true;
		((ButtonBase)rbtOptional1).Text = "Giá trị cố định";
		((Control)GroupBox1).Controls.Add((Control)(object)lblTen_spct_M);
		((Control)GroupBox1).Controls.Add((Control)(object)txtMa_spct_M);
		((Control)GroupBox1).Controls.Add((Control)(object)Label5);
		((Control)GroupBox1).Controls.Add((Control)(object)lblTK_doiUng_M);
		((Control)GroupBox1).Controls.Add((Control)(object)txtTK_doiUng_M);
		((Control)GroupBox1).Controls.Add((Control)(object)txtMa_TK_M);
		((Control)GroupBox1).Controls.Add((Control)(object)txtMa_BP_M);
		((Control)GroupBox1).Controls.Add((Control)(object)txtMa_Phi_M);
		((Control)GroupBox1).Controls.Add((Control)(object)cboNam_M);
		((Control)GroupBox1).Controls.Add((Control)(object)rbtCo);
		((Control)GroupBox1).Controls.Add((Control)(object)rbtNo);
		((Control)GroupBox1).Controls.Add((Control)(object)Label14);
		((Control)GroupBox1).Controls.Add((Control)(object)Label15);
		((Control)GroupBox1).Controls.Add((Control)(object)Label13);
		((Control)GroupBox1).Controls.Add((Control)(object)lblTen_phi_M);
		((Control)GroupBox1).Controls.Add((Control)(object)lblTen_BP_M);
		((Control)GroupBox1).Controls.Add((Control)(object)lblTen_TK_M);
		((Control)GroupBox1).Controls.Add((Control)(object)Label10);
		((Control)GroupBox1).Controls.Add((Control)(object)Label11);
		((Control)GroupBox1).Controls.Add((Control)(object)Label12);
		GroupBox groupBox = GroupBox1;
		location = new Point(440, 10);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(432, 171);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 2;
		GroupBox1.TabStop = false;
		GroupBox1.Text = "Số liệu mẫu";
		lblTen_spct_M.ImeMode = (ImeMode)0;
		Label obj50 = lblTen_spct_M;
		location = new Point(195, 141);
		((Control)obj50).Location = location;
		((Control)lblTen_spct_M).Name = "lblTen_spct_M";
		Label obj51 = lblTen_spct_M;
		size = new Size(188, 16);
		((Control)obj51).Size = size;
		((Control)lblTen_spct_M).TabIndex = 33;
		txtMa_spct_M.AutoLookup = true;
		txtMa_spct_M.AutoValid = true;
		((TextBoxBase)txtMa_spct_M).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct_M).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox11 = txtMa_spct_M;
		location = new Point(101, 141);
		((Control)asTextBox11).Location = location;
		txtMa_spct_M.LookupCodeName = "Ma_SPCT";
		txtMa_spct_M.LookupWhereCondition = "ksd=0";
		((Control)txtMa_spct_M).Name = "txtMa_spct_M";
		txtMa_spct_M.NameControl = lblTen_spct_M;
		AsTextBox asTextBox12 = txtMa_spct_M;
		size = new Size(88, 20);
		((Control)asTextBox12).Size = size;
		((Control)txtMa_spct_M).TabIndex = 4;
		txtMa_spct_M.UseAutoCompleteSource = true;
		txtMa_spct_M.ValidReturnFieldList = "ma_spct,ten_spct";
		Label5.AutoSize = true;
		Label5.ImeMode = (ImeMode)0;
		Label label15 = Label5;
		location = new Point(13, 146);
		((Control)label15).Location = location;
		((Control)Label5).Name = "Label5";
		Label label16 = Label5;
		size = new Size(35, 13);
		((Control)label16).Size = size;
		((Control)Label5).TabIndex = 32;
		Label5.Text = "SPCT";
		lblTK_doiUng_M.ImeMode = (ImeMode)0;
		Label obj52 = lblTK_doiUng_M;
		location = new Point(198, 71);
		((Control)obj52).Location = location;
		((Control)lblTK_doiUng_M).Name = "lblTK_doiUng_M";
		Label obj53 = lblTK_doiUng_M;
		size = new Size(185, 16);
		((Control)obj53).Size = size;
		((Control)lblTK_doiUng_M).TabIndex = 14;
		txtTK_doiUng_M.AutoLookup = true;
		txtTK_doiUng_M.AutoValid = true;
		((TextBoxBase)txtTK_doiUng_M).BackColor = SystemColors.Info;
		((TextBox)txtTK_doiUng_M).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox13 = txtTK_doiUng_M;
		location = new Point(101, 68);
		((Control)asTextBox13).Location = location;
		txtTK_doiUng_M.LookupCodeName = "TK";
		((Control)txtTK_doiUng_M).Name = "txtTK_doiUng_M";
		txtTK_doiUng_M.NameControl = lblTK_doiUng_M;
		txtTK_doiUng_M.SD = true;
		AsTextBox asTextBox14 = txtTK_doiUng_M;
		size = new Size(88, 20);
		((Control)asTextBox14).Size = size;
		((Control)txtTK_doiUng_M).TabIndex = 1;
		txtTK_doiUng_M.UseAutoCompleteSource = true;
		txtTK_doiUng_M.ValidReturnFieldList = "ma_nt,ten_tk";
		txtMa_TK_M.AutoLookup = true;
		txtMa_TK_M.AutoValid = true;
		((TextBoxBase)txtMa_TK_M).BackColor = SystemColors.Info;
		((TextBox)txtMa_TK_M).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox15 = txtMa_TK_M;
		location = new Point(101, 17);
		((Control)asTextBox15).Location = location;
		txtMa_TK_M.LookupCodeName = "TK";
		((Control)txtMa_TK_M).Name = "txtMa_TK_M";
		txtMa_TK_M.NameControl = lblTen_TK_M;
		txtMa_TK_M.SD = true;
		AsTextBox asTextBox16 = txtMa_TK_M;
		size = new Size(88, 20);
		((Control)asTextBox16).Size = size;
		((Control)txtMa_TK_M).TabIndex = 0;
		txtMa_TK_M.UseAutoCompleteSource = true;
		txtMa_TK_M.ValidReturnFieldList = "ma_nt,ten_tk";
		lblTen_TK_M.ImeMode = (ImeMode)0;
		Label obj54 = lblTen_TK_M;
		location = new Point(198, 20);
		((Control)obj54).Location = location;
		((Control)lblTen_TK_M).Name = "lblTen_TK_M";
		Label obj55 = lblTen_TK_M;
		size = new Size(222, 16);
		((Control)obj55).Size = size;
		((Control)lblTen_TK_M).TabIndex = 9;
		txtMa_BP_M.AutoLookup = true;
		txtMa_BP_M.AutoValid = true;
		((TextBoxBase)txtMa_BP_M).BackColor = SystemColors.Info;
		((TextBox)txtMa_BP_M).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox17 = txtMa_BP_M;
		location = new Point(101, 92);
		((Control)asTextBox17).Location = location;
		txtMa_BP_M.LookupCodeName = "Ma_BP";
		txtMa_BP_M.LookupWhereCondition = "ksd=0";
		((Control)txtMa_BP_M).Name = "txtMa_BP_M";
		txtMa_BP_M.NameControl = lblTen_BP_M;
		AsTextBox asTextBox18 = txtMa_BP_M;
		size = new Size(88, 20);
		((Control)asTextBox18).Size = size;
		((Control)txtMa_BP_M).TabIndex = 2;
		txtMa_BP_M.UseAutoCompleteSource = true;
		lblTen_BP_M.ImeMode = (ImeMode)0;
		Label obj56 = lblTen_BP_M;
		location = new Point(198, 92);
		((Control)obj56).Location = location;
		((Control)lblTen_BP_M).Name = "lblTen_BP_M";
		Label obj57 = lblTen_BP_M;
		size = new Size(185, 16);
		((Control)obj57).Size = size;
		((Control)lblTen_BP_M).TabIndex = 10;
		txtMa_Phi_M.AutoLookup = true;
		txtMa_Phi_M.AutoValid = true;
		((TextBoxBase)txtMa_Phi_M).BackColor = SystemColors.Info;
		((TextBox)txtMa_Phi_M).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox19 = txtMa_Phi_M;
		location = new Point(101, 116);
		((Control)asTextBox19).Location = location;
		txtMa_Phi_M.LookupCodeName = "Ma_PHI";
		txtMa_Phi_M.LookupWhereCondition = "ksd=0";
		((Control)txtMa_Phi_M).Name = "txtMa_Phi_M";
		txtMa_Phi_M.NameControl = lblTen_phi_M;
		AsTextBox asTextBox20 = txtMa_Phi_M;
		size = new Size(88, 20);
		((Control)asTextBox20).Size = size;
		((Control)txtMa_Phi_M).TabIndex = 3;
		txtMa_Phi_M.UseAutoCompleteSource = true;
		lblTen_phi_M.ImeMode = (ImeMode)0;
		Label obj58 = lblTen_phi_M;
		location = new Point(195, 116);
		((Control)obj58).Location = location;
		((Control)lblTen_phi_M).Name = "lblTen_phi_M";
		Label obj59 = lblTen_phi_M;
		size = new Size(188, 16);
		((Control)obj59).Size = size;
		((Control)lblTen_phi_M).TabIndex = 11;
		cboNam_M.DropDownStyle = (ComboBoxStyle)2;
		cboNam_M.ItemHeight = 13;
		ComboBox obj60 = cboNam_M;
		location = new Point(239, 44);
		((Control)obj60).Location = location;
		((Control)cboNam_M).Name = "cboNam_M";
		ComboBox obj61 = cboNam_M;
		size = new Size(80, 21);
		((Control)obj61).Size = size;
		((Control)cboNam_M).TabIndex = 7;
		((ButtonBase)rbtCo).ImeMode = (ImeMode)0;
		RadioButton obj62 = rbtCo;
		location = new Point(145, 43);
		((Control)obj62).Location = location;
		((Control)rbtCo).Name = "rbtCo";
		RadioButton obj63 = rbtCo;
		size = new Size(40, 16);
		((Control)obj63).Size = size;
		((Control)rbtCo).TabIndex = 6;
		((ButtonBase)rbtCo).Text = "Có";
		((ButtonBase)rbtNo).AutoSize = true;
		rbtNo.Checked = true;
		((ButtonBase)rbtNo).ImeMode = (ImeMode)0;
		RadioButton obj64 = rbtNo;
		location = new Point(100, 43);
		((Control)obj64).Location = location;
		((Control)rbtNo).Name = "rbtNo";
		RadioButton obj65 = rbtNo;
		size = new Size(39, 17);
		((Control)obj65).Size = size;
		((Control)rbtNo).TabIndex = 5;
		rbtNo.TabStop = true;
		((ButtonBase)rbtNo).Text = "Nợ";
		Label14.AutoSize = true;
		Label14.ImeMode = (ImeMode)0;
		Label label17 = Label14;
		location = new Point(204, 47);
		((Control)label17).Location = location;
		((Control)Label14).Name = "Label14";
		Label label18 = Label14;
		size = new Size(29, 13);
		((Control)label18).Size = size;
		((Control)Label14).TabIndex = 16;
		Label14.Text = "Năm";
		Label15.ImeMode = (ImeMode)0;
		Label label19 = Label15;
		location = new Point(13, 45);
		((Control)label19).Location = location;
		((Control)Label15).Name = "Label15";
		Label label20 = Label15;
		size = new Size(48, 16);
		((Control)label20).Size = size;
		((Control)Label15).TabIndex = 4;
		Label15.Text = "Loại PS";
		Label13.AutoSize = true;
		Label13.ImeMode = (ImeMode)0;
		Label label21 = Label13;
		location = new Point(13, 71);
		((Control)label21).Location = location;
		((Control)Label13).Name = "Label13";
		Label label22 = Label13;
		size = new Size(60, 13);
		((Control)label22).Size = size;
		((Control)Label13).TabIndex = 12;
		Label13.Text = "TK đối ứng";
		Label10.AutoSize = true;
		Label10.ImeMode = (ImeMode)0;
		Label label23 = Label10;
		location = new Point(13, 121);
		((Control)label23).Location = location;
		((Control)Label10).Name = "Label10";
		Label label24 = Label10;
		size = new Size(41, 13);
		((Control)label24).Size = size;
		((Control)Label10).TabIndex = 2;
		Label10.Text = "Mã phí";
		Label11.AutoSize = true;
		Label11.ImeMode = (ImeMode)0;
		Label label25 = Label11;
		location = new Point(13, 95);
		((Control)label25).Location = location;
		((Control)Label11).Name = "Label11";
		Label label26 = Label11;
		size = new Size(47, 13);
		((Control)label26).Size = size;
		((Control)Label11).TabIndex = 1;
		Label11.Text = "Bộ phận";
		Label12.AutoSize = true;
		Label12.ImeMode = (ImeMode)0;
		Label label27 = Label12;
		location = new Point(13, 21);
		((Control)label27).Location = location;
		((Control)Label12).Name = "Label12";
		Label label28 = Label12;
		size = new Size(55, 13);
		((Control)label28).Size = size;
		((Control)Label12).TabIndex = 0;
		Label12.Text = "Tài khoản";
		((Control)grbDu_toan).Controls.Add((Control)(object)adgBudget);
		GroupBox obj66 = grbDu_toan;
		location = new Point(17, 187);
		((Control)obj66).Location = location;
		((Control)grbDu_toan).Name = "grbDu_toan";
		GroupBox obj67 = grbDu_toan;
		size = new Size(417, 299);
		((Control)obj67).Size = size;
		((Control)grbDu_toan).TabIndex = 1;
		grbDu_toan.TabStop = false;
		grbDu_toan.Text = "Số liệu";
		((DataGridView)adgBudget).AllowUserToAddRows = false;
		((DataGridView)adgBudget).AllowUserToDeleteRows = false;
		val.BackColor = SystemColors.Info;
		((DataGridView)adgBudget).AlternatingRowsDefaultCellStyle = val;
		((DataGridView)adgBudget).BackgroundColor = SystemColors.Window;
		((DataGridView)adgBudget).BorderStyle = (BorderStyle)0;
		((DataGridView)adgBudget).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Control;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.WindowText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgBudget).ColumnHeadersDefaultCellStyle = val2;
		((DataGridView)adgBudget).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgBudget).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3] { dgvcThang, dgvcDu_toan, dgvcThuc_te });
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = SystemColors.Window;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.ControlText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgBudget).DefaultCellStyle = val3;
		((Control)adgBudget).Dock = (DockStyle)5;
		adgBudget.DoubleBuffered = false;
		((DataGridView)adgBudget).EditMode = (DataGridViewEditMode)0;
		((DataGridView)adgBudget).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = adgBudget;
		location = new Point(3, 16);
		((Control)asDataGridView).Location = location;
		((Control)adgBudget).Name = "adgBudget";
		((DataGridView)adgBudget).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val4.Alignment = (DataGridViewContentAlignment)32;
		val4.BackColor = SystemColors.Control;
		val4.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val4.ForeColor = SystemColors.WindowText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgBudget).RowHeadersDefaultCellStyle = val4;
		adgBudget.RowIndex2StartFillOrdinalNumber = 1u;
		val5.BackColor = Color.Snow;
		((DataGridView)adgBudget).RowsDefaultCellStyle = val5;
		((DataGridView)adgBudget).RowTemplate.Height = 20;
		((DataGridView)adgBudget).ScrollBars = (ScrollBars)0;
		AsDataGridView asDataGridView2 = adgBudget;
		size = new Size(411, 280);
		((Control)asDataGridView2).Size = size;
		((Control)adgBudget).TabIndex = 0;
		dgvcThang.AutoFill = false;
		dgvcThang.AutoLookup = false;
		dgvcThang.AutoValid = false;
		val6.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcThang).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcThang).HeaderText = "Tháng";
		dgvcThang.LookupCodeName = "";
		dgvcThang.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcThang).Name = "dgvcThang";
		((DataGridViewColumn)dgvcThang).ReadOnly = true;
		dgvcThang.ReceiverValidFieldList = "";
		((DataGridViewColumn)dgvcThang).Resizable = (DataGridViewTriState)1;
		dgvcThang.SD = false;
		dgvcThang.SortMode = (DataGridViewColumnSortMode)1;
		dgvcThang.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcThang).Width = 80;
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcDu_toan).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcDu_toan).HeaderText = "Dự Toán";
		dgvcDu_toan.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcDu_toan).Name = "dgvcDu_toan";
		((DataGridViewColumn)dgvcDu_toan).Resizable = (DataGridViewTriState)1;
		dgvcDu_toan.SortMode = (DataGridViewColumnSortMode)1;
		dgvcDu_toan.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)dgvcDu_toan).Width = 140;
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThuc_te).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcThuc_te).HeaderText = "Số liệu mẫu";
		dgvcThuc_te.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThuc_te).Name = "dgvcThuc_te";
		((DataGridViewColumn)dgvcThuc_te).ReadOnly = true;
		((DataGridViewColumn)dgvcThuc_te).Resizable = (DataGridViewTriState)1;
		dgvcThuc_te.SortMode = (DataGridViewColumnSortMode)1;
		dgvcThuc_te.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)dgvcThuc_te).Width = 150;
		((Control)btnMau).Anchor = (AnchorStyles)6;
		Button obj68 = btnMau;
		location = new Point(174, 540);
		((Control)obj68).Location = location;
		((Control)btnMau).Name = "btnMau";
		Button obj69 = btnMau;
		size = new Size(75, 23);
		((Control)obj69).Size = size;
		((Control)btnMau).TabIndex = 3;
		((ButtonBase)btnMau).Text = "Số liệu mẫu";
		((ButtonBase)btnMau).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(910, 575);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)btnMau);
		((Control)this).Name = "frmGLBudgetEdit";
		((Control)this).Controls.SetChildIndex((Control)(object)gbLine, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)btnMau, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSave, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)grbThamSoDT).ResumeLayout(false);
		((Control)grbThamSoDT).PerformLayout();
		((Control)grbPhuong_phap_dc).ResumeLayout(false);
		((Control)grbPhuong_phap_dc).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)grbDu_toan).ResumeLayout(false);
		((ISupportInitialize)adgBudget).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		int num = 1;
		checked
		{
			do
			{
				((DataGridView)adgBudget).Rows.Add(new object[3]
				{
					"Tháng " + num,
					0,
					0
				});
				num++;
			}
			while (num <= 12);
			((Control)txtMa_TK).Focus();
			double num2 = f_year - 5;
			double num3 = f_year + 10;
			for (double num4 = num2; num4 <= num3; num4 += 1.0)
			{
				cboNam_M.Items.Add((object)num4);
			}
			cboNam_M.Text = Conversions.ToString(f_year);
		}
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		UpdateSUM();
	}

	protected override void DataBinding()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_TK;
		CreateDataBinding(ref ojb, "tk");
		txtMa_TK = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_TK_M;
		CreateDataBinding(ref ojb, "tk");
		txtMa_TK_M = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTk_DoiUng;
		CreateDataBinding(ref ojb, "tk_du");
		txtTk_DoiUng = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTK_doiUng_M;
		CreateDataBinding(ref ojb, "tk_du");
		txtTK_doiUng_M = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTK_DoiUng;
		CreateDataBinding(ref ojb, "ten_tk_du");
		lblTK_DoiUng = (Label)ojb;
		ojb = (Control)(object)lblTK_doiUng_M;
		CreateDataBinding(ref ojb, "ten_tk_du");
		lblTK_doiUng_M = (Label)ojb;
		ojb = (Control)(object)txtMa_BP;
		CreateDataBinding(ref ojb, "ma_bp");
		txtMa_BP = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_BP_M;
		CreateDataBinding(ref ojb, "ma_bp");
		txtMa_BP_M = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_phi;
		CreateDataBinding(ref ojb, "ma_phi");
		txtMa_phi = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_Phi_M;
		CreateDataBinding(ref ojb, "ma_phi");
		txtMa_Phi_M = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_spct;
		CreateDataBinding(ref ojb, "ma_spct");
		txtMa_spct = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_spct_M;
		CreateDataBinding(ref ojb, "ma_spct");
		txtMa_spct_M = (AsTextBox)(object)ojb;
		ojb = (Control)(object)lblTen_tk;
		CreateDataBinding(ref ojb, "ten_tk");
		lblTen_tk = (Label)ojb;
		ojb = (Control)(object)lblTen_TK_M;
		CreateDataBinding(ref ojb, "ten_tk");
		lblTen_TK_M = (Label)ojb;
		ojb = (Control)(object)lblTen_BP;
		CreateDataBinding(ref ojb, "ten_bp");
		lblTen_BP = (Label)ojb;
		ojb = (Control)(object)lblTen_BP_M;
		CreateDataBinding(ref ojb, "ten_bp");
		lblTen_BP_M = (Label)ojb;
		ojb = (Control)(object)lblTen_phi;
		CreateDataBinding(ref ojb, "ten_phi");
		lblTen_phi = (Label)ojb;
		ojb = (Control)(object)lblTen_phi_M;
		CreateDataBinding(ref ojb, "ten_phi");
		lblTen_phi_M = (Label)ojb;
		ojb = (Control)(object)lblTen_spct;
		CreateDataBinding(ref ojb, "ten_spct");
		lblTen_spct = (Label)ojb;
		ojb = (Control)(object)lblTen_spct_M;
		CreateDataBinding(ref ojb, "ten_spct");
		lblTen_spct_M = (Label)ojb;
		GetPSNo_Co();
		GetBudgetOnMonth();
	}

	protected override bool UpdateDB()
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if (((TextBox)txtMa_TK).Text.Trim().Equals(""))
		{
			epNotice.SetError((Control)(object)txtMa_TK, "Bắt buộc");
			return false;
		}
		GLBUDGETDAO gLBUDGETDAO = (GLBUDGETDAO)DAOFactory.CreateDAOInstance("GLBudgetDAO", "GLBudget");
		GetInput();
		string upd_sp = base.MyController.MyDAOInfo.upd_sp;
		string text = gLBUDGETDAO.asUpdBudget(RowToEdit, upd_sp);
		gLBUDGETDAO.Destroy();
		if (text.Equals(""))
		{
			CMessageBox.Show(50011);
			return false;
		}
		return true;
	}

	protected override bool InsertToDB()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (((TextBox)txtMa_TK).Text.Trim().Equals(""))
		{
			epNotice.SetError((Control)(object)txtMa_TK, Helper.GetMess(50002).Description);
			return false;
		}
		GLBUDGETDAO gLBUDGETDAO = (GLBUDGETDAO)DAOFactory.CreateDAOInstance("GLBudgetDAO", "GLBudget");
		GetInput();
		string ins_sp = base.MyController.MyDAOInfo.ins_sp;
		string text = gLBUDGETDAO.asInsBudget(RowToEdit, ins_sp);
		gLBUDGETDAO.Destroy();
		if (text.Equals(""))
		{
			CMessageBox.Show(50011);
			return false;
		}
		RowToEdit["stt_rec"] = text;
		return true;
	}

	protected override bool SetToRow()
	{
		return base.SetToRow();
	}

	private void adgBudget_CurrentCellChanged(object sender, EventArgs e)
	{
		UpdateSUM();
	}

	private void txtMa_TK_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (e.ValidatedRow != null)
		{
			((TextBox)txtMa_TK_M).Text = Conversions.ToString(Helper.Repl_Null(((TextBox)txtMa_TK).Text, isNum: false));
			if (txtMa_TK.ValidReturnFieldList.ToString().ToUpper().Contains("TEN_TK"))
			{
				lblTen_tk.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ten_tk"]), isNum: false));
				lblTen_TK_M.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ten_tk"]), isNum: false));
			}
		}
	}

	private void txtMa_phi_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (e.ValidatedRow != null)
		{
			((TextBox)txtMa_Phi_M).Text = Conversions.ToString(Helper.Repl_Null(((TextBox)txtMa_phi).Text, isNum: false));
			if (txtMa_phi.ValidReturnFieldList.ToString().ToUpper().Contains("TEN_PHI"))
			{
				lblTen_phi.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ten_phi"]), isNum: false));
				lblTen_phi_M.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ten_phi"]), isNum: false));
			}
		}
	}

	private void txtMa_BP_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (e.ValidatedRow != null)
		{
			((TextBox)txtMa_BP_M).Text = Conversions.ToString(Helper.Repl_Null(((TextBox)txtMa_BP).Text, isNum: false));
			if (txtMa_BP.ValidReturnFieldList.ToString().ToUpper().Contains("TEN_BP"))
			{
				lblTen_BP.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ten_bp"]), isNum: false));
				lblTen_BP_M.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ten_bp"]), isNum: false));
			}
		}
	}

	private void txtMa_spct_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (e.ValidatedRow != null)
		{
			((TextBox)txtMa_spct_M).Text = Conversions.ToString(Helper.Repl_Null(((TextBox)txtMa_spct).Text, isNum: false));
			if (txtMa_spct.ValidReturnFieldList.ToString().ToUpper().Contains("TEN_SPCT"))
			{
				lblTen_spct.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ten_spct"]), isNum: false));
				lblTen_spct_M.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ten_spct"]), isNum: false));
			}
		}
	}

	private void txtTk_DoiUng_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
	{
		if (e.ValidatedRow != null)
		{
			((TextBox)txtTK_doiUng_M).Text = Conversions.ToString(Helper.Repl_Null(((TextBox)txtTk_DoiUng).Text, isNum: false));
			if (txtTk_DoiUng.ValidReturnFieldList.ToString().ToUpper().Contains("TEN_TK"))
			{
				lblTK_DoiUng.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ten_tk"]), isNum: false));
				lblTK_doiUng_M.Text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(e.ValidatedRow["ten_tk"]), isNum: false));
			}
		}
	}

	private void btnThem_Click(object sender, EventArgs e)
	{
		TinhToan(bolThem: true);
	}

	private void btnThay_the_Click(object sender, EventArgs e)
	{
		TinhToan(bolThem: false);
	}

	private void btnMau_Click(object sender, EventArgs e)
	{
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		GLBUDGETDAO gLBUDGETDAO = (GLBUDGETDAO)DAOFactory.CreateDAOInstance("GLBudgetDAO", "GLBudget");
		checked
		{
			try
			{
				string pLoai_ps = "N";
				if (rbtCo.Checked)
				{
					pLoai_ps = "C";
				}
				DataTable sample0Budget = gLBUDGETDAO.GetSample0Budget(CompanyInformations.CompanyID, ((TextBox)txtMa_TK_M).Text, pLoai_ps, ((TextBox)txtMa_BP_M).Text, ((TextBox)txtMa_Phi_M).Text, ((TextBox)txtTK_doiUng_M).Text, Conversions.ToInteger(cboNam_M.Text), ((TextBox)txtMa_spct_M).Text);
				if (sample0Budget.Rows.Count != 0)
				{
					double num = 0.0;
					do
					{
						string columnName = "actual";
						SetData4Month((int)Math.Round(num + 1.0), Conversions.ToDouble(sample0Budget.Rows[(int)Math.Round(num)][columnName]), bolDu_lieu_mau: true);
						num += 1.0;
					}
					while (num <= 11.0);
					UpdateSUM();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	private void radCo_Click(object sender, EventArgs e)
	{
		rbtCo.Checked = true;
	}

	private void radNo_Click(object sender, EventArgs e)
	{
		rbtNo.Checked = true;
	}

	protected void GetPSNo_Co()
	{
		string text = Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(RowToEdit["ttps_no_co"]), isNum: false));
		if (text.Equals("NO"))
		{
			radNo.Checked = true;
			rbtNo.Checked = true;
		}
		else
		{
			radCo.Checked = true;
			rbtCo.Checked = true;
		}
	}

	protected void GetBudgetOnMonth()
	{
		int num = 1;
		checked
		{
			do
			{
				((DataGridView)adgBudget).Rows[num - 1].Cells[((DataGridViewColumn)dgvcDu_toan).Name].Value = RuntimeHelpers.GetObjectValue(RowToEdit["t" + Conversions.ToString(num)]);
				num++;
			}
			while (num <= 12);
		}
	}

	private void GetInput()
	{
		string text = "";
		text = ((!radNo.Checked) ? "CO" : "NO");
		RowToEdit["ma_cty"] = CompanyInformations.CompanyID;
		RowToEdit["nam"] = f_year;
		RowToEdit["tk"] = ((TextBox)txtMa_TK).Text;
		RowToEdit["tk_du"] = ((TextBox)txtTk_DoiUng).Text;
		RowToEdit["ttps_no_co"] = text;
		RowToEdit["ma_bp"] = ((TextBox)txtMa_BP).Text;
		RowToEdit["ma_phi"] = ((TextBox)txtMa_phi).Text;
		RowToEdit["ma_spct"] = ((TextBox)txtMa_spct).Text;
		RowToEdit["luser"] = SystemInformations.UserName;
		int num = 1;
		checked
		{
			do
			{
				RowToEdit["t" + Conversions.ToString(num)] = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(((DataGridView)adgBudget).Rows[num - 1].Cells[((DataGridViewColumn)dgvcDu_toan).Name].Value), isNum: true)));
				num++;
			}
			while (num <= 12);
		}
	}

	private void rbtOptional1_CheckedChanged(object sender, EventArgs e)
	{
		((Control)lblGiatri).Visible = true;
		lblGiatri.Text = "Giá trị cố định";
		((Control)txtGia_tri).Visible = true;
		((Control)lblGiatriCS).Visible = false;
		((Control)txtGiaTriCS).Visible = false;
		((Control)lblphantram).Visible = false;
	}

	private void rbtOptional2_CheckedChanged(object sender, EventArgs e)
	{
		((Control)lblGiatri).Visible = true;
		lblGiatri.Text = "Giá trị cố định";
		((Control)txtGia_tri).Visible = true;
		((Control)lblGiatriCS).Visible = false;
		((Control)txtGiaTriCS).Visible = false;
		((Control)lblphantram).Visible = false;
	}

	private void rbtOptional3_CheckedChanged(object sender, EventArgs e)
	{
		((Control)lblGiatri).Visible = true;
		lblGiatri.Text = "Tỷ lệ phần trăm";
		((Control)txtGia_tri).Visible = true;
		((Control)lblphantram).Visible = true;
		((Control)lblGiatriCS).Visible = true;
		((Control)txtGiaTriCS).Visible = true;
	}

	private void rbtOptional4_CheckedChanged(object sender, EventArgs e)
	{
		((Control)lblGiatri).Visible = true;
		lblGiatri.Text = "Giá trị cố định";
		((Control)txtGia_tri).Visible = true;
		((Control)lblGiatriCS).Visible = true;
		((Control)txtGiaTriCS).Visible = true;
		((Control)lblphantram).Visible = false;
	}

	private void rbtOptional5_CheckedChanged(object sender, EventArgs e)
	{
		((Control)lblGiatri).Visible = false;
		lblGiatri.Text = "Giá trị cố định";
		((Control)txtGia_tri).Visible = false;
		((Control)lblGiatriCS).Visible = false;
		((Control)txtGiaTriCS).Visible = false;
		((Control)lblphantram).Visible = false;
	}

	private void rbtOptional6_CheckedChanged(object sender, EventArgs e)
	{
		((Control)lblGiatri).Visible = true;
		lblGiatri.Text = "Tỷ lệ phần trăm";
		((Control)txtGia_tri).Visible = true;
		((Control)lblphantram).Visible = true;
		((Control)lblGiatriCS).Visible = false;
		((Control)txtGiaTriCS).Visible = false;
	}

	private void rbtOptional7_CheckedChanged(object sender, EventArgs e)
	{
		((Control)lblGiatri).Visible = true;
		lblGiatri.Text = "Giá trị cố định";
		((Control)txtGia_tri).Visible = true;
		((Control)lblGiatriCS).Visible = false;
		((Control)txtGiaTriCS).Visible = false;
		((Control)lblphantram).Visible = false;
	}

	private void rbtOptional8_CheckedChanged(object sender, EventArgs e)
	{
		((Control)lblGiatri).Visible = true;
		lblGiatri.Text = "Giá trị cố định";
		((Control)txtGia_tri).Visible = true;
		((Control)lblGiatriCS).Visible = false;
		((Control)txtGiaTriCS).Visible = false;
		((Control)lblphantram).Visible = false;
	}

	public void UpdateSUM()
	{
		try
		{
			double num = 0.0;
			double num2 = 0.0;
			int num3 = 1;
			do
			{
				num2 += GetData4Month(num3, bolDu_lieu_mau: true);
				num += GetData4Month(num3);
				num3 = checked(num3 + 1);
			}
			while (num3 <= 12);
			((TextBox)txtTongCu).Text = Conversions.ToString(num2);
			((TextBox)txtTongMoi).Text = Conversions.ToString(num);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public double GetData4Month(int intMonth, bool bolDu_lieu_mau = false)
	{
		checked
		{
			if (bolDu_lieu_mau)
			{
				return Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(((DataGridView)adgBudget)[2, intMonth - 1].Value), isNum: true));
			}
			return Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(((DataGridView)adgBudget)[1, intMonth - 1].Value), isNum: true));
		}
	}

	public void SetData4Month(int intMonth, double intValues, bool bolDu_lieu_mau = false)
	{
		checked
		{
			if (bolDu_lieu_mau)
			{
				((DataGridView)adgBudget)[2, intMonth - 1].Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(intValues, isNum: true));
			}
			else
			{
				((DataGridView)adgBudget)[1, intMonth - 1].Value = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(intValues, isNum: true));
			}
		}
	}

	public void TinhToan(bool bolThem)
	{
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				double num = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtGia_tri.Value), isNum: true));
				if (rbtOptional1.Checked)
				{
					int num2 = 1;
					do
					{
						double num3 = GetData4Month(num2);
						if (!bolThem)
						{
							num3 = 0.0;
						}
						SetData4Month(num2, num3 + num);
						num2++;
					}
					while (num2 <= 12);
				}
				else if (rbtOptional2.Checked)
				{
					int num4 = 1;
					do
					{
						double num5 = GetData4Month(num4);
						if (!bolThem)
						{
							num5 = 0.0;
						}
						SetData4Month(num4, num5 + num / 12.0);
						num4++;
					}
					while (num4 <= 12);
				}
				else if (rbtOptional3.Checked)
				{
					double num6 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtGiaTriCS.Value), isNum: true));
					num = 1.0 + num / 100.0;
					if (bolThem)
					{
						SetData4Month(1, num6 + GetData4Month(1));
					}
					else
					{
						SetData4Month(1, num6);
					}
					int num7 = 2;
					do
					{
						double data4Month = GetData4Month(num7 - 1);
						num6 = data4Month * num;
						if (bolThem)
						{
							SetData4Month(num7, num6 + GetData4Month(num7));
						}
						else
						{
							SetData4Month(num7, num6);
						}
						num7++;
					}
					while (num7 <= 12);
				}
				else if (rbtOptional4.Checked)
				{
					double num8 = Conversions.ToDouble(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtGiaTriCS.Value), isNum: true));
					if (bolThem)
					{
						SetData4Month(1, num8 + GetData4Month(1));
					}
					else
					{
						SetData4Month(1, num8);
					}
					int num9 = 2;
					do
					{
						double num10 = GetData4Month(num9);
						num8 += num;
						if (!bolThem)
						{
							num10 = 0.0;
						}
						SetData4Month(num9, num8 + num10);
						num9++;
					}
					while (num9 <= 12);
				}
				else if (rbtOptional5.Checked)
				{
					int num11 = 1;
					do
					{
						double data4Month2 = GetData4Month(num11, bolDu_lieu_mau: true);
						SetData4Month(num11, data4Month2);
						num11++;
					}
					while (num11 <= 12);
				}
				else if (rbtOptional6.Checked)
				{
					num = 1.0 + num / 100.0;
					if (bolThem)
					{
						num -= 1.0;
					}
					int num12 = 1;
					do
					{
						double data4Month3 = GetData4Month(num12, bolDu_lieu_mau: true);
						if (bolThem)
						{
							SetData4Month(num12, GetData4Month(num12) + data4Month3 * num);
						}
						else
						{
							SetData4Month(num12, data4Month3 * num);
						}
						num12++;
					}
					while (num12 <= 12);
				}
				else if (rbtOptional7.Checked)
				{
					int num13 = 1;
					do
					{
						double data4Month4 = GetData4Month(num13, bolDu_lieu_mau: true);
						SetData4Month(num13, data4Month4 + num);
						num13++;
					}
					while (num13 <= 12);
				}
				else if (rbtOptional8.Checked)
				{
					if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTongCu.Value), isNum: true), (object)0, false))
					{
						return;
					}
					double num14 = num;
					if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(txtTongCu.Value), isNum: true), (object)0, false))
					{
						num14 = Conversions.ToDouble(Operators.DivideObject((object)num14, txtTongCu.Value));
					}
					int num15 = 1;
					do
					{
						double data4Month5 = GetData4Month(num15, bolDu_lieu_mau: true);
						SetData4Month(num15, data4Month5 * num14);
						num15++;
					}
					while (num15 <= 12);
				}
				UpdateSUM();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
	}

	public bool ValidMa(Control obj, bool blnShowMess = true)
	{
		if (obj.Text.Length == 0)
		{
			if (blnShowMess)
			{
				obj.Select();
				return false;
			}
			bool result = default(bool);
			return result;
		}
		return true;
	}
}
