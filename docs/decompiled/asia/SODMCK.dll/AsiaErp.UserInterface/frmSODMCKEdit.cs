using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSODMCKEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("grbApdungcho")]
	private GroupBox _grbApdungcho;

	[AccessedThroughProperty("grbMucchietkhau")]
	private GroupBox _grbMucchietkhau;

	[AccessedThroughProperty("lblTen_Khachhang")]
	private Label _lblTen_Khachhang;

	[AccessedThroughProperty("lblMathang")]
	private Label _lblMathang;

	[AccessedThroughProperty("lblKhachhang")]
	private Label _lblKhachhang;

	[AccessedThroughProperty("lblTen_mathang")]
	private Label _lblTen_mathang;

	[AccessedThroughProperty("txtKhachhang")]
	private AsTextBox _txtKhachhang;

	[AccessedThroughProperty("txtMathang")]
	private AsTextBox _txtMathang;

	[AccessedThroughProperty("cboKhachhang")]
	private ComboBox _cboKhachhang;

	[AccessedThroughProperty("cboMathang")]
	private ComboBox _cboMathang;

	[AccessedThroughProperty("cboky")]
	private ComboBox _cboky;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("cboTb_TyLe")]
	private ComboBox _cboTb_TyLe;

	[AccessedThroughProperty("cboTb_SLuong")]
	private ComboBox _cboTb_SLuong;

	[AccessedThroughProperty("cboTinhtren")]
	private ComboBox _cboTinhtren;

	[AccessedThroughProperty("dgvChietKhau")]
	private AsDataGridView _dgvChietKhau;

	[AccessedThroughProperty("From")]
	private DataGridViewAsTextNumericColumn _From;

	[AccessedThroughProperty("Too")]
	private DataGridViewAsTextNumericColumn _Too;

	[AccessedThroughProperty("ChietKhau")]
	private DataGridViewAsTextNumericColumn _ChietKhau;

	[AccessedThroughProperty("txtgt1")]
	private AsTextNumeric _txtgt1;

	[AccessedThroughProperty("txtGt7")]
	private AsTextNumeric _txtGt7;

	[AccessedThroughProperty("txtGt5")]
	private AsTextNumeric _txtGt5;

	[AccessedThroughProperty("txtGt4")]
	private AsTextNumeric _txtGt4;

	[AccessedThroughProperty("txtGt3")]
	private AsTextNumeric _txtGt3;

	[AccessedThroughProperty("txtck1")]
	private AsTextNumeric _txtck1;

	[AccessedThroughProperty("txtGt11")]
	private AsTextNumeric _txtGt11;

	[AccessedThroughProperty("txtGt10")]
	private AsTextNumeric _txtGt10;

	[AccessedThroughProperty("txtGt9")]
	private AsTextNumeric _txtGt9;

	[AccessedThroughProperty("txtGt8")]
	private AsTextNumeric _txtGt8;

	[AccessedThroughProperty("txtGt6")]
	private AsTextNumeric _txtGt6;

	[AccessedThroughProperty("txtgt0")]
	private AsTextNumeric _txtgt0;

	[AccessedThroughProperty("txtGt15")]
	private AsTextNumeric _txtGt15;

	[AccessedThroughProperty("txtGt14")]
	private AsTextNumeric _txtGt14;

	[AccessedThroughProperty("txtGt13")]
	private AsTextNumeric _txtGt13;

	[AccessedThroughProperty("txtGt12")]
	private AsTextNumeric _txtGt12;

	[AccessedThroughProperty("txtCK12")]
	private AsTextNumeric _txtCK12;

	[AccessedThroughProperty("txtCK13")]
	private AsTextNumeric _txtCK13;

	[AccessedThroughProperty("txtCK14")]
	private AsTextNumeric _txtCK14;

	[AccessedThroughProperty("txtCK15")]
	private AsTextNumeric _txtCK15;

	[AccessedThroughProperty("txtCK6")]
	private AsTextNumeric _txtCK6;

	[AccessedThroughProperty("txtCK8")]
	private AsTextNumeric _txtCK8;

	[AccessedThroughProperty("txtCK9")]
	private AsTextNumeric _txtCK9;

	[AccessedThroughProperty("txtCK10")]
	private AsTextNumeric _txtCK10;

	[AccessedThroughProperty("txtCK11")]
	private AsTextNumeric _txtCK11;

	[AccessedThroughProperty("txtGt2")]
	private AsTextNumeric _txtGt2;

	[AccessedThroughProperty("txtCk3")]
	private AsTextNumeric _txtCk3;

	[AccessedThroughProperty("txtCK4")]
	private AsTextNumeric _txtCK4;

	[AccessedThroughProperty("txtCK5")]
	private AsTextNumeric _txtCK5;

	[AccessedThroughProperty("txtCK7")]
	private AsTextNumeric _txtCK7;

	[AccessedThroughProperty("txtCk2")]
	private AsTextNumeric _txtCk2;

	[AccessedThroughProperty("txtMa_NHKH")]
	private AsTextBox _txtMa_NHKH;

	[AccessedThroughProperty("txtMa_NHVT")]
	private AsTextBox _txtMa_NHVT;

	private bool isLoading;

	private const double MAXVALUE = 999999999999.0;

	private int c;

	private int r;

	private DataTable f_otblChiTiet;

	internal virtual GroupBox grbApdungcho
	{
		get
		{
			return _grbApdungcho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_grbApdungcho = value;
		}
	}

	internal virtual GroupBox grbMucchietkhau
	{
		get
		{
			return _grbMucchietkhau;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_grbMucchietkhau = value;
		}
	}

	internal virtual Label lblTen_Khachhang
	{
		get
		{
			return _lblTen_Khachhang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Khachhang = value;
		}
	}

	internal virtual Label lblMathang
	{
		get
		{
			return _lblMathang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMathang = value;
		}
	}

	internal virtual Label lblKhachhang
	{
		get
		{
			return _lblKhachhang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblKhachhang = value;
		}
	}

	internal virtual Label lblTen_mathang
	{
		get
		{
			return _lblTen_mathang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_mathang = value;
		}
	}

	internal virtual AsTextBox txtKhachhang
	{
		get
		{
			return _txtKhachhang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtKhachhang = value;
		}
	}

	internal virtual AsTextBox txtMathang
	{
		get
		{
			return _txtMathang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMathang = value;
		}
	}

	internal virtual ComboBox cboKhachhang
	{
		get
		{
			return _cboKhachhang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboKhachhang_SelectedIndexChanged;
			if (_cboKhachhang != null)
			{
				_cboKhachhang.SelectedIndexChanged -= eventHandler;
			}
			_cboKhachhang = value;
			if (_cboKhachhang != null)
			{
				_cboKhachhang.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual ComboBox cboMathang
	{
		get
		{
			return _cboMathang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboMathang_SelectedIndexChanged;
			if (_cboMathang != null)
			{
				_cboMathang.SelectedIndexChanged -= eventHandler;
			}
			_cboMathang = value;
			if (_cboMathang != null)
			{
				_cboMathang.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual ComboBox cboky
	{
		get
		{
			return _cboky;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboky = value;
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

	internal virtual ComboBox cboTb_TyLe
	{
		get
		{
			return _cboTb_TyLe;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cboTb_TyLe_SelectedIndexChanged;
			if (_cboTb_TyLe != null)
			{
				_cboTb_TyLe.SelectedIndexChanged -= eventHandler;
			}
			_cboTb_TyLe = value;
			if (_cboTb_TyLe != null)
			{
				_cboTb_TyLe.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual ComboBox cboTb_SLuong
	{
		get
		{
			return _cboTb_SLuong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboTb_SLuong = value;
		}
	}

	internal virtual ComboBox cboTinhtren
	{
		get
		{
			return _cboTinhtren;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cboTinhtren = value;
		}
	}

	internal virtual AsDataGridView dgvChietKhau
	{
		get
		{
			return _dgvChietKhau;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(dgvChietKhau_CellEndEdit);
			if (_dgvChietKhau != null)
			{
				((DataGridView)_dgvChietKhau).CellEndEdit -= val;
			}
			_dgvChietKhau = value;
			if (_dgvChietKhau != null)
			{
				((DataGridView)_dgvChietKhau).CellEndEdit += val;
			}
		}
	}

	internal virtual DataGridViewAsTextNumericColumn From
	{
		get
		{
			return _From;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_From = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn Too
	{
		get
		{
			return _Too;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Too = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn ChietKhau
	{
		get
		{
			return _ChietKhau;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ChietKhau = value;
		}
	}

	internal virtual AsTextNumeric txtgt1
	{
		get
		{
			return _txtgt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtgt1 = value;
		}
	}

	internal virtual AsTextNumeric txtGt7
	{
		get
		{
			return _txtGt7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt7 = value;
		}
	}

	internal virtual AsTextNumeric txtGt5
	{
		get
		{
			return _txtGt5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt5 = value;
		}
	}

	internal virtual AsTextNumeric txtGt4
	{
		get
		{
			return _txtGt4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt4 = value;
		}
	}

	internal virtual AsTextNumeric txtGt3
	{
		get
		{
			return _txtGt3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt3 = value;
		}
	}

	internal virtual AsTextNumeric txtck1
	{
		get
		{
			return _txtck1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtck1 = value;
		}
	}

	internal virtual AsTextNumeric txtGt11
	{
		get
		{
			return _txtGt11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt11 = value;
		}
	}

	internal virtual AsTextNumeric txtGt10
	{
		get
		{
			return _txtGt10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt10 = value;
		}
	}

	internal virtual AsTextNumeric txtGt9
	{
		get
		{
			return _txtGt9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt9 = value;
		}
	}

	internal virtual AsTextNumeric txtGt8
	{
		get
		{
			return _txtGt8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt8 = value;
		}
	}

	internal virtual AsTextNumeric txtGt6
	{
		get
		{
			return _txtGt6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt6 = value;
		}
	}

	internal virtual AsTextNumeric txtgt0
	{
		get
		{
			return _txtgt0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtgt0 = value;
		}
	}

	internal virtual AsTextNumeric txtGt15
	{
		get
		{
			return _txtGt15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt15 = value;
		}
	}

	internal virtual AsTextNumeric txtGt14
	{
		get
		{
			return _txtGt14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt14 = value;
		}
	}

	internal virtual AsTextNumeric txtGt13
	{
		get
		{
			return _txtGt13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt13 = value;
		}
	}

	internal virtual AsTextNumeric txtGt12
	{
		get
		{
			return _txtGt12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt12 = value;
		}
	}

	internal virtual AsTextNumeric txtCK12
	{
		get
		{
			return _txtCK12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCK12 = value;
		}
	}

	internal virtual AsTextNumeric txtCK13
	{
		get
		{
			return _txtCK13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCK13 = value;
		}
	}

	internal virtual AsTextNumeric txtCK14
	{
		get
		{
			return _txtCK14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCK14 = value;
		}
	}

	internal virtual AsTextNumeric txtCK15
	{
		get
		{
			return _txtCK15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCK15 = value;
		}
	}

	internal virtual AsTextNumeric txtCK6
	{
		get
		{
			return _txtCK6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCK6 = value;
		}
	}

	internal virtual AsTextNumeric txtCK8
	{
		get
		{
			return _txtCK8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCK8 = value;
		}
	}

	internal virtual AsTextNumeric txtCK9
	{
		get
		{
			return _txtCK9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCK9 = value;
		}
	}

	internal virtual AsTextNumeric txtCK10
	{
		get
		{
			return _txtCK10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCK10 = value;
		}
	}

	internal virtual AsTextNumeric txtCK11
	{
		get
		{
			return _txtCK11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCK11 = value;
		}
	}

	internal virtual AsTextNumeric txtGt2
	{
		get
		{
			return _txtGt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGt2 = value;
		}
	}

	internal virtual AsTextNumeric txtCk3
	{
		get
		{
			return _txtCk3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCk3 = value;
		}
	}

	internal virtual AsTextNumeric txtCK4
	{
		get
		{
			return _txtCK4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCK4 = value;
		}
	}

	internal virtual AsTextNumeric txtCK5
	{
		get
		{
			return _txtCK5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCK5 = value;
		}
	}

	internal virtual AsTextNumeric txtCK7
	{
		get
		{
			return _txtCK7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCK7 = value;
		}
	}

	internal virtual AsTextNumeric txtCk2
	{
		get
		{
			return _txtCk2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCk2 = value;
		}
	}

	internal virtual AsTextBox txtMa_NHKH
	{
		get
		{
			return _txtMa_NHKH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_NHKH = value;
		}
	}

	internal virtual AsTextBox txtMa_NHVT
	{
		get
		{
			return _txtMa_NHVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_NHVT = value;
		}
	}

	public frmSODMCKEdit()
	{
		isLoading = true;
		c = 0;
		r = 0;
		f_otblChiTiet = new DataTable();
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
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9e: Expected O, but got Unknown
		//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b44: Expected O, but got Unknown
		//IL_0bfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		grbApdungcho = new GroupBox();
		cboKhachhang = new ComboBox();
		cboMathang = new ComboBox();
		cboky = new ComboBox();
		grbMucchietkhau = new GroupBox();
		txtMa_NHKH = new AsTextBox();
		lblTen_Khachhang = new Label();
		txtMa_NHVT = new AsTextBox();
		lblTen_mathang = new Label();
		dgvChietKhau = new AsDataGridView();
		From = new DataGridViewAsTextNumericColumn();
		Too = new DataGridViewAsTextNumericColumn();
		ChietKhau = new DataGridViewAsTextNumericColumn();
		lblMathang = new Label();
		lblKhachhang = new Label();
		txtKhachhang = new AsTextBox();
		txtMathang = new AsTextBox();
		cboTinhtren = new ComboBox();
		cboTb_SLuong = new ComboBox();
		cboTb_TyLe = new ComboBox();
		Label1 = new Label();
		Label4 = new Label();
		txtgt1 = new AsTextNumeric();
		txtGt7 = new AsTextNumeric();
		txtGt5 = new AsTextNumeric();
		txtGt4 = new AsTextNumeric();
		txtGt3 = new AsTextNumeric();
		txtck1 = new AsTextNumeric();
		txtGt11 = new AsTextNumeric();
		txtGt10 = new AsTextNumeric();
		txtGt9 = new AsTextNumeric();
		txtGt8 = new AsTextNumeric();
		txtGt6 = new AsTextNumeric();
		txtgt0 = new AsTextNumeric();
		txtGt15 = new AsTextNumeric();
		txtGt14 = new AsTextNumeric();
		txtGt13 = new AsTextNumeric();
		txtGt12 = new AsTextNumeric();
		txtCK12 = new AsTextNumeric();
		txtCK13 = new AsTextNumeric();
		txtCK14 = new AsTextNumeric();
		txtCK15 = new AsTextNumeric();
		txtCK6 = new AsTextNumeric();
		txtCK8 = new AsTextNumeric();
		txtCK9 = new AsTextNumeric();
		txtCK10 = new AsTextNumeric();
		txtCK11 = new AsTextNumeric();
		txtGt2 = new AsTextNumeric();
		txtCk3 = new AsTextNumeric();
		txtCK4 = new AsTextNumeric();
		txtCK5 = new AsTextNumeric();
		txtCK7 = new AsTextNumeric();
		txtCk2 = new AsTextNumeric();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)grbApdungcho).SuspendLayout();
		((Control)grbMucchietkhau).SuspendLayout();
		((ISupportInitialize)dgvChietKhau).BeginInit();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Enabled = false;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(13, 332);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		((Control)cmdCancel).TabIndex = 2;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)cboTb_TyLe);
		((Control)gbLine).Controls.Add((Control)(object)cboTb_SLuong);
		((Control)gbLine).Controls.Add((Control)(object)cboTinhtren);
		((Control)gbLine).Controls.Add((Control)(object)grbApdungcho);
		((Control)gbLine).Controls.Add((Control)(object)grbMucchietkhau);
		GroupBox obj = gbLine;
		Size size = new Size(660, 367);
		((Control)obj).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)grbMucchietkhau, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)grbApdungcho, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboTinhtren, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboTb_SLuong, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboTb_TyLe, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		((Control)grbApdungcho).Controls.Add((Control)(object)cboKhachhang);
		((Control)grbApdungcho).Controls.Add((Control)(object)cboMathang);
		((Control)grbApdungcho).Controls.Add((Control)(object)cboky);
		GroupBox obj2 = grbApdungcho;
		location = new Point(13, 19);
		((Control)obj2).Location = location;
		((Control)grbApdungcho).Name = "grbApdungcho";
		GroupBox obj3 = grbApdungcho;
		size = new Size(181, 140);
		((Control)obj3).Size = size;
		((Control)grbApdungcho).TabIndex = 0;
		grbApdungcho.TabStop = false;
		grbApdungcho.Text = "Áp dụng cho";
		cboKhachhang.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKhachhang).FormattingEnabled = true;
		cboKhachhang.Items.AddRange(new object[3] { "Khách hàng", "Nhóm khách", "Tất cả" });
		ComboBox obj4 = cboKhachhang;
		location = new Point(22, 96);
		((Control)obj4).Location = location;
		((Control)cboKhachhang).Name = "cboKhachhang";
		ComboBox obj5 = cboKhachhang;
		size = new Size(121, 21);
		((Control)obj5).Size = size;
		((Control)cboKhachhang).TabIndex = 2;
		cboMathang.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMathang).FormattingEnabled = true;
		cboMathang.Items.AddRange(new object[2] { "Mặt hàng", "Nhóm hàng" });
		ComboBox obj6 = cboMathang;
		location = new Point(22, 63);
		((Control)obj6).Location = location;
		((Control)cboMathang).Name = "cboMathang";
		ComboBox obj7 = cboMathang;
		size = new Size(121, 21);
		((Control)obj7).Size = size;
		((Control)cboMathang).TabIndex = 1;
		cboky.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboky).FormattingEnabled = true;
		cboky.Items.AddRange(new object[4] { "Tuần", "Tháng", "Quý", "Năm" });
		ComboBox obj8 = cboky;
		location = new Point(22, 33);
		((Control)obj8).Location = location;
		((Control)cboky).Name = "cboky";
		ComboBox obj9 = cboky;
		size = new Size(121, 21);
		((Control)obj9).Size = size;
		((Control)cboky).TabIndex = 0;
		((Control)grbMucchietkhau).Controls.Add((Control)(object)txtMa_NHKH);
		((Control)grbMucchietkhau).Controls.Add((Control)(object)txtMa_NHVT);
		((Control)grbMucchietkhau).Controls.Add((Control)(object)dgvChietKhau);
		((Control)grbMucchietkhau).Controls.Add((Control)(object)lblTen_Khachhang);
		((Control)grbMucchietkhau).Controls.Add((Control)(object)lblMathang);
		((Control)grbMucchietkhau).Controls.Add((Control)(object)lblKhachhang);
		((Control)grbMucchietkhau).Controls.Add((Control)(object)lblTen_mathang);
		((Control)grbMucchietkhau).Controls.Add((Control)(object)txtKhachhang);
		((Control)grbMucchietkhau).Controls.Add((Control)(object)txtMathang);
		GroupBox obj10 = grbMucchietkhau;
		location = new Point(231, 17);
		((Control)obj10).Location = location;
		((Control)grbMucchietkhau).Name = "grbMucchietkhau";
		GroupBox obj11 = grbMucchietkhau;
		size = new Size(419, 332);
		((Control)obj11).Size = size;
		((Control)grbMucchietkhau).TabIndex = 4;
		grbMucchietkhau.TabStop = false;
		grbMucchietkhau.Text = "Mức chiết khấu";
		txtMa_NHKH.AutoLookup = true;
		txtMa_NHKH.AutoValid = true;
		((TextBoxBase)txtMa_NHKH).BackColor = SystemColors.Info;
		((TextBox)txtMa_NHKH).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_NHKH;
		location = new Point(220, 38);
		((Control)asTextBox).Location = location;
		txtMa_NHKH.LookupCodeName = "MA_NHKH";
		((Control)txtMa_NHKH).Name = "txtMa_NHKH";
		txtMa_NHKH.NameControl = lblTen_Khachhang;
		AsTextBox asTextBox2 = txtMa_NHKH;
		size = new Size(180, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_NHKH).TabIndex = 3;
		txtMa_NHKH.UseAutoCompleteSource = true;
		Label obj12 = lblTen_Khachhang;
		location = new Point(220, 64);
		((Control)obj12).Location = location;
		((Control)lblTen_Khachhang).Name = "lblTen_Khachhang";
		Label obj13 = lblTen_Khachhang;
		size = new Size(180, 12);
		((Control)obj13).Size = size;
		((Control)lblTen_Khachhang).TabIndex = 5;
		txtMa_NHVT.AutoLookup = true;
		txtMa_NHVT.AutoValid = true;
		((TextBoxBase)txtMa_NHVT).BackColor = SystemColors.Info;
		((TextBox)txtMa_NHVT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_NHVT;
		location = new Point(15, 38);
		((Control)asTextBox3).Location = location;
		txtMa_NHVT.LookupCodeName = "MA_NHVT";
		((Control)txtMa_NHVT).Name = "txtMa_NHVT";
		txtMa_NHVT.NameControl = lblTen_mathang;
		AsTextBox asTextBox4 = txtMa_NHVT;
		size = new Size(180, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_NHVT).TabIndex = 1;
		txtMa_NHVT.UseAutoCompleteSource = true;
		Label obj14 = lblTen_mathang;
		location = new Point(15, 64);
		((Control)obj14).Location = location;
		((Control)lblTen_mathang).Name = "lblTen_mathang";
		Label obj15 = lblTen_mathang;
		size = new Size(180, 12);
		((Control)obj15).Size = size;
		((Control)lblTen_mathang).TabIndex = 2;
		((DataGridView)dgvChietKhau).AllowUserToAddRows = false;
		((DataGridView)dgvChietKhau).AllowUserToDeleteRows = false;
		((DataGridView)dgvChietKhau).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvChietKhau).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvChietKhau).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)dgvChietKhau).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvChietKhau).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3] { From, Too, ChietKhau });
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvChietKhau).DefaultCellStyle = val2;
		dgvChietKhau.DoubleBuffered = false;
		((DataGridView)dgvChietKhau).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvChietKhau).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvChietKhau;
		location = new Point(17, 82);
		((Control)asDataGridView).Location = location;
		((Control)dgvChietKhau).Name = "dgvChietKhau";
		((DataGridView)dgvChietKhau).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvChietKhau).RowHeadersDefaultCellStyle = val3;
		dgvChietKhau.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvChietKhau).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvChietKhau;
		size = new Size(396, 244);
		((Control)asDataGridView2).Size = size;
		((Control)dgvChietKhau).TabIndex = 4;
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "### ### ### ##0.00";
		((DataGridViewColumn)From).DefaultCellStyle = val4;
		((DataGridViewColumn)From).HeaderText = "From";
		From.Mask = "### ### ### ##0.00";
		((DataGridViewColumn)From).Name = "From";
		From.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)From).Width = 115;
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "### ### ### ##0.00";
		((DataGridViewColumn)Too).DefaultCellStyle = val5;
		((DataGridViewColumn)Too).HeaderText = "To";
		Too.Mask = "### ### ### ##0.00";
		((DataGridViewColumn)Too).Name = "Too";
		Too.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Too).Width = 115;
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ##0.00";
		((DataGridViewColumn)ChietKhau).DefaultCellStyle = val6;
		((DataGridViewColumn)ChietKhau).HeaderText = "Chiết khấu";
		ChietKhau.Mask = "### ### ### ##0.00";
		((DataGridViewColumn)ChietKhau).Name = "ChietKhau";
		ChietKhau.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)ChietKhau).Width = 105;
		lblMathang.AutoSize = true;
		Label obj16 = lblMathang;
		location = new Point(15, 18);
		((Control)obj16).Location = location;
		((Control)lblMathang).Name = "lblMathang";
		Label obj17 = lblMathang;
		size = new Size(52, 13);
		((Control)obj17).Size = size;
		((Control)lblMathang).TabIndex = 4;
		lblMathang.Text = "Mặt hàng";
		lblKhachhang.AutoSize = true;
		Label obj18 = lblKhachhang;
		location = new Point(220, 16);
		((Control)obj18).Location = location;
		((Control)lblKhachhang).Name = "lblKhachhang";
		Label obj19 = lblKhachhang;
		size = new Size(65, 13);
		((Control)obj19).Size = size;
		((Control)lblKhachhang).TabIndex = 3;
		lblKhachhang.Text = "Khách hàng";
		txtKhachhang.AutoLookup = true;
		txtKhachhang.AutoValid = true;
		((TextBoxBase)txtKhachhang).BackColor = SystemColors.Info;
		((TextBox)txtKhachhang).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtKhachhang;
		location = new Point(220, 38);
		((Control)asTextBox5).Location = location;
		txtKhachhang.LookupCodeName = "MA_KH";
		((Control)txtKhachhang).Name = "txtKhachhang";
		txtKhachhang.NameControl = lblTen_Khachhang;
		AsTextBox asTextBox6 = txtKhachhang;
		size = new Size(180, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtKhachhang).TabIndex = 2;
		txtKhachhang.UseAutoCompleteSource = true;
		txtMathang.AutoLookup = true;
		txtMathang.AutoValid = true;
		((TextBoxBase)txtMathang).BackColor = SystemColors.Info;
		((TextBox)txtMathang).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMathang;
		location = new Point(15, 38);
		((Control)asTextBox7).Location = location;
		txtMathang.LookupCodeName = "MA_VT";
		((Control)txtMathang).Name = "txtMathang";
		txtMathang.NameControl = lblTen_mathang;
		AsTextBox asTextBox8 = txtMathang;
		size = new Size(180, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMathang).TabIndex = 0;
		txtMathang.UseAutoCompleteSource = true;
		cboTinhtren.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboTinhtren).FormattingEnabled = true;
		cboTinhtren.Items.AddRange(new object[2] { "Số lượng", "Doanh số" });
		ComboBox obj20 = cboTinhtren;
		location = new Point(73, 181);
		((Control)obj20).Location = location;
		((Control)cboTinhtren).Name = "cboTinhtren";
		ComboBox obj21 = cboTinhtren;
		size = new Size(72, 21);
		((Control)obj21).Size = size;
		((Control)cboTinhtren).TabIndex = 1;
		cboTb_SLuong.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboTb_SLuong).FormattingEnabled = true;
		cboTb_SLuong.Items.AddRange(new object[2] { "Số lượng", "Doanh số" });
		ComboBox obj22 = cboTb_SLuong;
		location = new Point(151, 213);
		((Control)obj22).Location = location;
		((Control)cboTb_SLuong).Name = "cboTb_SLuong";
		ComboBox obj23 = cboTb_SLuong;
		size = new Size(72, 21);
		((Control)obj23).Size = size;
		((Control)cboTb_SLuong).TabIndex = 3;
		cboTb_TyLe.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboTb_TyLe).FormattingEnabled = true;
		cboTb_TyLe.Items.AddRange(new object[2] { "Tỉ lệ", "Giá trị" });
		ComboBox obj24 = cboTb_TyLe;
		location = new Point(73, 213);
		((Control)obj24).Location = location;
		((Control)cboTb_TyLe).Name = "cboTb_TyLe";
		ComboBox obj25 = cboTb_TyLe;
		size = new Size(72, 21);
		((Control)obj25).Size = size;
		((Control)cboTb_TyLe).TabIndex = 2;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(10, 184);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(51, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 105;
		Label1.Text = "Tính trên";
		Label4.AutoSize = true;
		Label label3 = Label4;
		location = new Point(10, 216);
		((Control)label3).Location = location;
		((Control)Label4).Name = "Label4";
		Label label4 = Label4;
		size = new Size(57, 13);
		((Control)label4).Size = size;
		((Control)Label4).TabIndex = 106;
		Label4.Text = "Tính bằng";
		txtgt1.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtgt1;
		location = new Point(700, 12);
		((Control)asTextNumeric).Location = location;
		txtgt1.Mask = "### ### ### ###.##";
		((Control)txtgt1).Name = "txtgt1";
		((TextBoxBase)txtgt1).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtgt1;
		size = new Size(56, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtgt1).TabIndex = 3;
		((TextBox)txtgt1).Text = "0.00";
		((TextBox)txtgt1).TextAlign = (HorizontalAlignment)1;
		txtgt1.Value = 0.0;
		txtGt7.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric3 = txtGt7;
		location = new Point(700, 171);
		((Control)asTextNumeric3).Location = location;
		txtGt7.Mask = "### ### ### ###.##";
		((Control)txtGt7).Name = "txtGt7";
		((TextBoxBase)txtGt7).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtGt7;
		size = new Size(56, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtGt7).TabIndex = 4;
		((TextBox)txtGt7).Text = "0.00";
		((TextBox)txtGt7).TextAlign = (HorizontalAlignment)1;
		txtGt7.Value = 0.0;
		txtGt5.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric5 = txtGt5;
		location = new Point(700, 116);
		((Control)asTextNumeric5).Location = location;
		txtGt5.Mask = "### ### ### ###.##";
		((Control)txtGt5).Name = "txtGt5";
		((TextBoxBase)txtGt5).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtGt5;
		size = new Size(56, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtGt5).TabIndex = 5;
		((TextBox)txtGt5).Text = "0.00";
		((TextBox)txtGt5).TextAlign = (HorizontalAlignment)1;
		txtGt5.Value = 0.0;
		txtGt4.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric7 = txtGt4;
		location = new Point(700, 90);
		((Control)asTextNumeric7).Location = location;
		txtGt4.Mask = "### ### ### ###.##";
		((Control)txtGt4).Name = "txtGt4";
		((TextBoxBase)txtGt4).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtGt4;
		size = new Size(56, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtGt4).TabIndex = 6;
		((TextBox)txtGt4).Text = "0.00";
		((TextBox)txtGt4).TextAlign = (HorizontalAlignment)1;
		txtGt4.Value = 0.0;
		txtGt3.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric9 = txtGt3;
		location = new Point(700, 64);
		((Control)asTextNumeric9).Location = location;
		txtGt3.Mask = "### ### ### ###.##";
		((Control)txtGt3).Name = "txtGt3";
		((TextBoxBase)txtGt3).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtGt3;
		size = new Size(56, 20);
		((Control)asTextNumeric10).Size = size;
		((Control)txtGt3).TabIndex = 7;
		((TextBox)txtGt3).Text = "0.00";
		((TextBox)txtGt3).TextAlign = (HorizontalAlignment)1;
		txtGt3.Value = 0.0;
		txtck1.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric11 = txtck1;
		location = new Point(783, 12);
		((Control)asTextNumeric11).Location = location;
		txtck1.Mask = "### ### ### ###.##";
		((Control)txtck1).Name = "txtck1";
		((TextBoxBase)txtck1).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtck1;
		size = new Size(56, 20);
		((Control)asTextNumeric12).Size = size;
		((Control)txtck1).TabIndex = 8;
		((TextBox)txtck1).Text = "0.00";
		((TextBox)txtck1).TextAlign = (HorizontalAlignment)1;
		txtck1.Value = 0.0;
		txtGt11.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric13 = txtGt11;
		location = new Point(700, 282);
		((Control)asTextNumeric13).Location = location;
		txtGt11.Mask = "### ### ### ###.##";
		((Control)txtGt11).Name = "txtGt11";
		((TextBoxBase)txtGt11).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtGt11;
		size = new Size(56, 20);
		((Control)asTextNumeric14).Size = size;
		((Control)txtGt11).TabIndex = 9;
		((TextBox)txtGt11).Text = "0.00";
		((TextBox)txtGt11).TextAlign = (HorizontalAlignment)1;
		txtGt11.Value = 0.0;
		txtGt10.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric15 = txtGt10;
		location = new Point(700, 256);
		((Control)asTextNumeric15).Location = location;
		txtGt10.Mask = "### ### ### ###.##";
		((Control)txtGt10).Name = "txtGt10";
		((TextBoxBase)txtGt10).ReadOnly = true;
		AsTextNumeric asTextNumeric16 = txtGt10;
		size = new Size(56, 20);
		((Control)asTextNumeric16).Size = size;
		((Control)txtGt10).TabIndex = 10;
		((TextBox)txtGt10).Text = "0.00";
		((TextBox)txtGt10).TextAlign = (HorizontalAlignment)1;
		txtGt10.Value = 0.0;
		txtGt9.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric17 = txtGt9;
		location = new Point(700, 230);
		((Control)asTextNumeric17).Location = location;
		txtGt9.Mask = "### ### ### ###.##";
		((Control)txtGt9).Name = "txtGt9";
		((TextBoxBase)txtGt9).ReadOnly = true;
		AsTextNumeric asTextNumeric18 = txtGt9;
		size = new Size(56, 20);
		((Control)asTextNumeric18).Size = size;
		((Control)txtGt9).TabIndex = 11;
		((TextBox)txtGt9).Text = "0.00";
		((TextBox)txtGt9).TextAlign = (HorizontalAlignment)1;
		txtGt9.Value = 0.0;
		txtGt8.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric19 = txtGt8;
		location = new Point(700, 204);
		((Control)asTextNumeric19).Location = location;
		txtGt8.Mask = "### ### ### ###.##";
		((Control)txtGt8).Name = "txtGt8";
		((TextBoxBase)txtGt8).ReadOnly = true;
		AsTextNumeric asTextNumeric20 = txtGt8;
		size = new Size(56, 20);
		((Control)asTextNumeric20).Size = size;
		((Control)txtGt8).TabIndex = 12;
		((TextBox)txtGt8).Text = "0.00";
		((TextBox)txtGt8).TextAlign = (HorizontalAlignment)1;
		txtGt8.Value = 0.0;
		txtGt6.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric21 = txtGt6;
		location = new Point(700, 145);
		((Control)asTextNumeric21).Location = location;
		txtGt6.Mask = "### ### ### ###.##";
		((Control)txtGt6).Name = "txtGt6";
		((TextBoxBase)txtGt6).ReadOnly = true;
		AsTextNumeric asTextNumeric22 = txtGt6;
		size = new Size(56, 20);
		((Control)asTextNumeric22).Size = size;
		((Control)txtGt6).TabIndex = 13;
		((TextBox)txtGt6).Text = "0.00";
		((TextBox)txtGt6).TextAlign = (HorizontalAlignment)1;
		txtGt6.Value = 0.0;
		txtgt0.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric23 = txtgt0;
		location = new Point(861, 12);
		((Control)asTextNumeric23).Location = location;
		txtgt0.Mask = "### ### ### ###.##";
		((Control)txtgt0).Name = "txtgt0";
		((TextBoxBase)txtgt0).ReadOnly = true;
		AsTextNumeric asTextNumeric24 = txtgt0;
		size = new Size(56, 20);
		((Control)asTextNumeric24).Size = size;
		((Control)txtgt0).TabIndex = 14;
		((TextBox)txtgt0).Text = "0.00";
		((TextBox)txtgt0).TextAlign = (HorizontalAlignment)1;
		txtgt0.Value = 0.0;
		txtGt15.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric25 = txtGt15;
		location = new Point(700, 387);
		((Control)asTextNumeric25).Location = location;
		txtGt15.Mask = "### ### ### ###.##";
		((Control)txtGt15).Name = "txtGt15";
		((TextBoxBase)txtGt15).ReadOnly = true;
		AsTextNumeric asTextNumeric26 = txtGt15;
		size = new Size(56, 20);
		((Control)asTextNumeric26).Size = size;
		((Control)txtGt15).TabIndex = 15;
		((TextBox)txtGt15).Text = "0.00";
		((TextBox)txtGt15).TextAlign = (HorizontalAlignment)1;
		txtGt15.Value = 0.0;
		txtGt14.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric27 = txtGt14;
		location = new Point(700, 361);
		((Control)asTextNumeric27).Location = location;
		txtGt14.Mask = "### ### ### ###.##";
		((Control)txtGt14).Name = "txtGt14";
		((TextBoxBase)txtGt14).ReadOnly = true;
		AsTextNumeric asTextNumeric28 = txtGt14;
		size = new Size(56, 20);
		((Control)asTextNumeric28).Size = size;
		((Control)txtGt14).TabIndex = 16;
		((TextBox)txtGt14).Text = "0.00";
		((TextBox)txtGt14).TextAlign = (HorizontalAlignment)1;
		txtGt14.Value = 0.0;
		txtGt13.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric29 = txtGt13;
		location = new Point(700, 335);
		((Control)asTextNumeric29).Location = location;
		txtGt13.Mask = "### ### ### ###.##";
		((Control)txtGt13).Name = "txtGt13";
		((TextBoxBase)txtGt13).ReadOnly = true;
		AsTextNumeric asTextNumeric30 = txtGt13;
		size = new Size(56, 20);
		((Control)asTextNumeric30).Size = size;
		((Control)txtGt13).TabIndex = 17;
		((TextBox)txtGt13).Text = "0.00";
		((TextBox)txtGt13).TextAlign = (HorizontalAlignment)1;
		txtGt13.Value = 0.0;
		txtGt12.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric31 = txtGt12;
		location = new Point(700, 308);
		((Control)asTextNumeric31).Location = location;
		txtGt12.Mask = "### ### ### ###.##";
		((Control)txtGt12).Name = "txtGt12";
		((TextBoxBase)txtGt12).ReadOnly = true;
		AsTextNumeric asTextNumeric32 = txtGt12;
		size = new Size(56, 20);
		((Control)asTextNumeric32).Size = size;
		((Control)txtGt12).TabIndex = 18;
		((TextBox)txtGt12).Text = "0.00";
		((TextBox)txtGt12).TextAlign = (HorizontalAlignment)1;
		txtGt12.Value = 0.0;
		txtCK12.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric33 = txtCK12;
		location = new Point(783, 308);
		((Control)asTextNumeric33).Location = location;
		txtCK12.Mask = "### ### ### ###.##";
		((Control)txtCK12).Name = "txtCK12";
		((TextBoxBase)txtCK12).ReadOnly = true;
		AsTextNumeric asTextNumeric34 = txtCK12;
		size = new Size(56, 20);
		((Control)asTextNumeric34).Size = size;
		((Control)txtCK12).TabIndex = 33;
		((TextBox)txtCK12).Text = "0.00";
		((TextBox)txtCK12).TextAlign = (HorizontalAlignment)1;
		txtCK12.Value = 0.0;
		txtCK13.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric35 = txtCK13;
		location = new Point(783, 335);
		((Control)asTextNumeric35).Location = location;
		txtCK13.Mask = "### ### ### ###.##";
		((Control)txtCK13).Name = "txtCK13";
		((TextBoxBase)txtCK13).ReadOnly = true;
		AsTextNumeric asTextNumeric36 = txtCK13;
		size = new Size(56, 20);
		((Control)asTextNumeric36).Size = size;
		((Control)txtCK13).TabIndex = 32;
		((TextBox)txtCK13).Text = "0.00";
		((TextBox)txtCK13).TextAlign = (HorizontalAlignment)1;
		txtCK13.Value = 0.0;
		txtCK14.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric37 = txtCK14;
		location = new Point(783, 361);
		((Control)asTextNumeric37).Location = location;
		txtCK14.Mask = "### ### ### ###.##";
		((Control)txtCK14).Name = "txtCK14";
		((TextBoxBase)txtCK14).ReadOnly = true;
		AsTextNumeric asTextNumeric38 = txtCK14;
		size = new Size(56, 20);
		((Control)asTextNumeric38).Size = size;
		((Control)txtCK14).TabIndex = 31;
		((TextBox)txtCK14).Text = "0.00";
		((TextBox)txtCK14).TextAlign = (HorizontalAlignment)1;
		txtCK14.Value = 0.0;
		txtCK15.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric39 = txtCK15;
		location = new Point(783, 387);
		((Control)asTextNumeric39).Location = location;
		txtCK15.Mask = "### ### ### ###.##";
		((Control)txtCK15).Name = "txtCK15";
		((TextBoxBase)txtCK15).ReadOnly = true;
		AsTextNumeric asTextNumeric40 = txtCK15;
		size = new Size(56, 20);
		((Control)asTextNumeric40).Size = size;
		((Control)txtCK15).TabIndex = 30;
		((TextBox)txtCK15).Text = "0.00";
		((TextBox)txtCK15).TextAlign = (HorizontalAlignment)1;
		txtCK15.Value = 0.0;
		txtCK6.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric41 = txtCK6;
		location = new Point(783, 145);
		((Control)asTextNumeric41).Location = location;
		txtCK6.Mask = "### ### ### ###.##";
		((Control)txtCK6).Name = "txtCK6";
		((TextBoxBase)txtCK6).ReadOnly = true;
		AsTextNumeric asTextNumeric42 = txtCK6;
		size = new Size(56, 20);
		((Control)asTextNumeric42).Size = size;
		((Control)txtCK6).TabIndex = 29;
		((TextBox)txtCK6).Text = "0.00";
		((TextBox)txtCK6).TextAlign = (HorizontalAlignment)1;
		txtCK6.Value = 0.0;
		txtCK8.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric43 = txtCK8;
		location = new Point(783, 204);
		((Control)asTextNumeric43).Location = location;
		txtCK8.Mask = "### ### ### ###.##";
		((Control)txtCK8).Name = "txtCK8";
		((TextBoxBase)txtCK8).ReadOnly = true;
		AsTextNumeric asTextNumeric44 = txtCK8;
		size = new Size(56, 20);
		((Control)asTextNumeric44).Size = size;
		((Control)txtCK8).TabIndex = 28;
		((TextBox)txtCK8).Text = "0.00";
		((TextBox)txtCK8).TextAlign = (HorizontalAlignment)1;
		txtCK8.Value = 0.0;
		txtCK9.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric45 = txtCK9;
		location = new Point(783, 230);
		((Control)asTextNumeric45).Location = location;
		txtCK9.Mask = "### ### ### ###.##";
		((Control)txtCK9).Name = "txtCK9";
		((TextBoxBase)txtCK9).ReadOnly = true;
		AsTextNumeric asTextNumeric46 = txtCK9;
		size = new Size(56, 20);
		((Control)asTextNumeric46).Size = size;
		((Control)txtCK9).TabIndex = 27;
		((TextBox)txtCK9).Text = "0.00";
		((TextBox)txtCK9).TextAlign = (HorizontalAlignment)1;
		txtCK9.Value = 0.0;
		txtCK10.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric47 = txtCK10;
		location = new Point(783, 256);
		((Control)asTextNumeric47).Location = location;
		txtCK10.Mask = "### ### ### ###.##";
		((Control)txtCK10).Name = "txtCK10";
		((TextBoxBase)txtCK10).ReadOnly = true;
		AsTextNumeric asTextNumeric48 = txtCK10;
		size = new Size(56, 20);
		((Control)asTextNumeric48).Size = size;
		((Control)txtCK10).TabIndex = 26;
		((TextBox)txtCK10).Text = "0.00";
		((TextBox)txtCK10).TextAlign = (HorizontalAlignment)1;
		txtCK10.Value = 0.0;
		txtCK11.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric49 = txtCK11;
		location = new Point(783, 282);
		((Control)asTextNumeric49).Location = location;
		txtCK11.Mask = "### ### ### ###.##";
		((Control)txtCK11).Name = "txtCK11";
		((TextBoxBase)txtCK11).ReadOnly = true;
		AsTextNumeric asTextNumeric50 = txtCK11;
		size = new Size(56, 20);
		((Control)asTextNumeric50).Size = size;
		((Control)txtCK11).TabIndex = 25;
		((TextBox)txtCK11).Text = "0.00";
		((TextBox)txtCK11).TextAlign = (HorizontalAlignment)1;
		txtCK11.Value = 0.0;
		txtGt2.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric51 = txtGt2;
		location = new Point(700, 38);
		((Control)asTextNumeric51).Location = location;
		txtGt2.Mask = "### ### ### ###.##";
		((Control)txtGt2).Name = "txtGt2";
		((TextBoxBase)txtGt2).ReadOnly = true;
		AsTextNumeric asTextNumeric52 = txtGt2;
		size = new Size(56, 20);
		((Control)asTextNumeric52).Size = size;
		((Control)txtGt2).TabIndex = 24;
		((TextBox)txtGt2).Text = "0.00";
		((TextBox)txtGt2).TextAlign = (HorizontalAlignment)1;
		txtGt2.Value = 0.0;
		txtCk3.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric53 = txtCk3;
		location = new Point(783, 64);
		((Control)asTextNumeric53).Location = location;
		txtCk3.Mask = "### ### ### ###.##";
		((Control)txtCk3).Name = "txtCk3";
		((TextBoxBase)txtCk3).ReadOnly = true;
		AsTextNumeric asTextNumeric54 = txtCk3;
		size = new Size(56, 20);
		((Control)asTextNumeric54).Size = size;
		((Control)txtCk3).TabIndex = 23;
		((TextBox)txtCk3).Text = "0.00";
		((TextBox)txtCk3).TextAlign = (HorizontalAlignment)1;
		txtCk3.Value = 0.0;
		txtCK4.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric55 = txtCK4;
		location = new Point(783, 90);
		((Control)asTextNumeric55).Location = location;
		txtCK4.Mask = "### ### ### ###.##";
		((Control)txtCK4).Name = "txtCK4";
		((TextBoxBase)txtCK4).ReadOnly = true;
		AsTextNumeric asTextNumeric56 = txtCK4;
		size = new Size(56, 20);
		((Control)asTextNumeric56).Size = size;
		((Control)txtCK4).TabIndex = 22;
		((TextBox)txtCK4).Text = "0.00";
		((TextBox)txtCK4).TextAlign = (HorizontalAlignment)1;
		txtCK4.Value = 0.0;
		txtCK5.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric57 = txtCK5;
		location = new Point(783, 116);
		((Control)asTextNumeric57).Location = location;
		txtCK5.Mask = "### ### ### ###.##";
		((Control)txtCK5).Name = "txtCK5";
		((TextBoxBase)txtCK5).ReadOnly = true;
		AsTextNumeric asTextNumeric58 = txtCK5;
		size = new Size(56, 20);
		((Control)asTextNumeric58).Size = size;
		((Control)txtCK5).TabIndex = 21;
		((TextBox)txtCK5).Text = "0.00";
		((TextBox)txtCK5).TextAlign = (HorizontalAlignment)1;
		txtCK5.Value = 0.0;
		txtCK7.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric59 = txtCK7;
		location = new Point(783, 171);
		((Control)asTextNumeric59).Location = location;
		txtCK7.Mask = "### ### ### ###.##";
		((Control)txtCK7).Name = "txtCK7";
		((TextBoxBase)txtCK7).ReadOnly = true;
		AsTextNumeric asTextNumeric60 = txtCK7;
		size = new Size(56, 20);
		((Control)asTextNumeric60).Size = size;
		((Control)txtCK7).TabIndex = 20;
		((TextBox)txtCK7).Text = "0.00";
		((TextBox)txtCK7).TextAlign = (HorizontalAlignment)1;
		txtCK7.Value = 0.0;
		txtCk2.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric61 = txtCk2;
		location = new Point(783, 38);
		((Control)asTextNumeric61).Location = location;
		txtCk2.Mask = "### ### ### ###.##";
		((Control)txtCk2).Name = "txtCk2";
		((TextBoxBase)txtCk2).ReadOnly = true;
		AsTextNumeric asTextNumeric62 = txtCk2;
		size = new Size(56, 20);
		((Control)asTextNumeric62).Size = size;
		((Control)txtCk2).TabIndex = 19;
		((TextBox)txtCk2).Text = "0.00";
		((TextBox)txtCk2).TextAlign = (HorizontalAlignment)1;
		txtCk2.Value = 0.0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(689, 429);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtCK12);
		((Control)this).Controls.Add((Control)(object)txtCK13);
		((Control)this).Controls.Add((Control)(object)txtCK14);
		((Control)this).Controls.Add((Control)(object)txtCK15);
		((Control)this).Controls.Add((Control)(object)txtCK6);
		((Control)this).Controls.Add((Control)(object)txtCK8);
		((Control)this).Controls.Add((Control)(object)txtCK9);
		((Control)this).Controls.Add((Control)(object)txtCK10);
		((Control)this).Controls.Add((Control)(object)txtCK11);
		((Control)this).Controls.Add((Control)(object)txtGt2);
		((Control)this).Controls.Add((Control)(object)txtCk3);
		((Control)this).Controls.Add((Control)(object)txtCK4);
		((Control)this).Controls.Add((Control)(object)txtCK5);
		((Control)this).Controls.Add((Control)(object)txtCK7);
		((Control)this).Controls.Add((Control)(object)txtCk2);
		((Control)this).Controls.Add((Control)(object)txtGt12);
		((Control)this).Controls.Add((Control)(object)txtGt13);
		((Control)this).Controls.Add((Control)(object)txtGt14);
		((Control)this).Controls.Add((Control)(object)txtGt15);
		((Control)this).Controls.Add((Control)(object)txtgt0);
		((Control)this).Controls.Add((Control)(object)txtGt6);
		((Control)this).Controls.Add((Control)(object)txtGt8);
		((Control)this).Controls.Add((Control)(object)txtGt9);
		((Control)this).Controls.Add((Control)(object)txtGt10);
		((Control)this).Controls.Add((Control)(object)txtGt11);
		((Control)this).Controls.Add((Control)(object)txtck1);
		((Control)this).Controls.Add((Control)(object)txtGt3);
		((Control)this).Controls.Add((Control)(object)txtGt4);
		((Control)this).Controls.Add((Control)(object)txtGt5);
		((Control)this).Controls.Add((Control)(object)txtGt7);
		((Control)this).Controls.Add((Control)(object)txtgt1);
		((Control)this).Name = "frmSODMCKEdit";
		((Control)this).Controls.SetChildIndex((Control)(object)txtgt1, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbLine, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSave, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt7, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt5, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt4, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt3, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtck1, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt11, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt10, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt9, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt8, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt6, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtgt0, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt15, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt14, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt13, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt12, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCk2, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCK7, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCK5, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCK4, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCk3, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtGt2, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCK11, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCK10, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCK9, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCK8, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCK6, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCK15, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCK14, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCK13, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtCK12, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)grbApdungcho).ResumeLayout(false);
		((Control)grbMucchietkhau).ResumeLayout(false);
		((Control)grbMucchietkhau).PerformLayout();
		((ISupportInitialize)dgvChietKhau).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		isLoading = false;
	}

	protected override void InitBeforeGetData()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		base.InitBeforeGetData();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		ComboBox val = cboky;
		dictionary.Add("1", Conversions.ToString(val.Items[0]));
		dictionary.Add("2", Conversions.ToString(val.Items[1]));
		dictionary.Add("3", Conversions.ToString(val.Items[2]));
		dictionary.Add("4", Conversions.ToString(val.Items[3]));
		BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
		val.DataSource = dataSource;
		((ListControl)val).DisplayMember = "value";
		((ListControl)val).ValueMember = "key";
		val.SelectedIndex = 0;
		val = null;
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		ComboBox val2 = cboMathang;
		dictionary2.Add("1", Conversions.ToString(val2.Items[0]));
		dictionary2.Add("2", Conversions.ToString(val2.Items[1]));
		BindingSource dataSource2 = new BindingSource((object)dictionary2, (string)null);
		val2.DataSource = dataSource2;
		((ListControl)val2).DisplayMember = "value";
		((ListControl)val2).ValueMember = "key";
		val2.SelectedIndex = 0;
		val2 = null;
		Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
		ComboBox val3 = cboKhachhang;
		dictionary3.Add("1", Conversions.ToString(val3.Items[0]));
		dictionary3.Add("2", Conversions.ToString(val3.Items[1]));
		dictionary3.Add("3", Conversions.ToString(val3.Items[2]));
		BindingSource dataSource3 = new BindingSource((object)dictionary3, (string)null);
		val3.DataSource = dataSource3;
		((ListControl)val3).DisplayMember = "value";
		((ListControl)val3).ValueMember = "key";
		val3.SelectedIndex = 0;
		val3 = null;
		Dictionary<string, string> dictionary4 = new Dictionary<string, string>();
		ComboBox val4 = cboTinhtren;
		dictionary4.Add("1", Conversions.ToString(val4.Items[0]));
		dictionary4.Add("2", Conversions.ToString(val4.Items[1]));
		BindingSource dataSource4 = new BindingSource((object)dictionary4, (string)null);
		val4.DataSource = dataSource4;
		((ListControl)val4).DisplayMember = "value";
		((ListControl)val4).ValueMember = "key";
		val4.SelectedIndex = 0;
		val4 = null;
		Dictionary<string, string> dictionary5 = new Dictionary<string, string>();
		ComboBox val5 = cboTb_TyLe;
		dictionary5.Add("1", Conversions.ToString(val5.Items[0]));
		dictionary5.Add("2", Conversions.ToString(val5.Items[1]));
		BindingSource dataSource5 = new BindingSource((object)dictionary5, (string)null);
		val5.DataSource = dataSource5;
		((ListControl)val5).DisplayMember = "value";
		((ListControl)val5).ValueMember = "key";
		val5.SelectedIndex = 1;
		val5 = null;
		Dictionary<string, string> dictionary6 = new Dictionary<string, string>();
		ComboBox val6 = cboTb_SLuong;
		dictionary6.Add("1", Conversions.ToString(val6.Items[0]));
		dictionary6.Add("2", Conversions.ToString(val6.Items[1]));
		BindingSource dataSource6 = new BindingSource((object)dictionary6, (string)null);
		val6.DataSource = dataSource6;
		((ListControl)val6).DisplayMember = "value";
		((ListControl)val6).ValueMember = "key";
		val6.SelectedIndex = 1;
		val6 = null;
		((Control)cboky).Select();
		((Control)cboTb_SLuong).Visible = true;
		((DataGridView)dgvChietKhau).Rows.Add(new object[3] { 0, 0, 0 });
		int num = 1;
		do
		{
			((DataGridView)dgvChietKhau).Rows.Add(new object[3] { 0, 0, 0 });
			((DataGridView)dgvChietKhau)[0, num].ReadOnly = true;
			num = checked(num + 1);
		}
		while (num <= 14);
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)cboky).Enabled = false;
		((Control)cboMathang).Enabled = false;
		((Control)cboKhachhang).Enabled = false;
		((Control)cboTinhtren).Enabled = false;
		((Control)cboTb_TyLe).Enabled = false;
		((Control)cboTb_SLuong).Enabled = false;
		((Control)txtKhachhang).Enabled = false;
		((Control)txtMathang).Enabled = false;
		((Control)dgvChietKhau).Select();
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)cboky;
		CreateDataBinding(ref ojb, "MA_KYCK", "SelectedValue");
		cboky = (ComboBox)ojb;
		ojb = (Control)(object)cboMathang;
		CreateDataBinding(ref ojb, "VT_NHOMVT", "SelectedValue");
		cboMathang = (ComboBox)ojb;
		ojb = (Control)(object)cboKhachhang;
		CreateDataBinding(ref ojb, "KH_NHOMKH", "SelectedValue");
		cboKhachhang = (ComboBox)ojb;
		ojb = (Control)(object)cboTinhtren;
		CreateDataBinding(ref ojb, "SL_DS", "SelectedValue");
		cboTinhtren = (ComboBox)ojb;
		ojb = (Control)(object)cboTb_TyLe;
		CreateDataBinding(ref ojb, "TL_GT", "SelectedValue");
		cboTb_TyLe = (ComboBox)ojb;
		ojb = (Control)(object)cboTb_SLuong;
		CreateDataBinding(ref ojb, "TL_SL_DS", "SelectedValue");
		cboTb_SLuong = (ComboBox)ojb;
		ojb = (Control)(object)txtKhachhang;
		CreateDataBinding(ref ojb, "Ma_KH");
		txtKhachhang = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_NHKH;
		CreateDataBinding(ref ojb, "Ma_NHKH");
		txtMa_NHKH = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMathang;
		CreateDataBinding(ref ojb, "MA_VT");
		txtMathang = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtMa_NHVT;
		CreateDataBinding(ref ojb, "MA_NHVT");
		txtMa_NHVT = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtgt0;
		CreateDataBinding(ref ojb, "GT0", "Value");
		txtgt0 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtgt1;
		CreateDataBinding(ref ojb, "GT1", "Value");
		txtgt1 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt2;
		CreateDataBinding(ref ojb, "GT2", "Value");
		txtGt2 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt3;
		CreateDataBinding(ref ojb, "GT3", "Value");
		txtGt3 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt4;
		CreateDataBinding(ref ojb, "GT4", "Value");
		txtGt4 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt5;
		CreateDataBinding(ref ojb, "GT5", "Value");
		txtGt5 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt6;
		CreateDataBinding(ref ojb, "GT6", "Value");
		txtGt6 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt7;
		CreateDataBinding(ref ojb, "GT7", "Value");
		txtGt7 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt8;
		CreateDataBinding(ref ojb, "GT8", "Value");
		txtGt8 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt9;
		CreateDataBinding(ref ojb, "GT9", "Value");
		txtGt9 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt10;
		CreateDataBinding(ref ojb, "GT10", "Value");
		txtGt10 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt11;
		CreateDataBinding(ref ojb, "GT11", "Value");
		txtGt11 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt12;
		CreateDataBinding(ref ojb, "GT12", "Value");
		txtGt12 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt13;
		CreateDataBinding(ref ojb, "GT13", "Value");
		txtGt13 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt14;
		CreateDataBinding(ref ojb, "GT14", "Value");
		txtGt14 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtGt15;
		CreateDataBinding(ref ojb, "GT15", "Value");
		txtGt15 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtck1;
		CreateDataBinding(ref ojb, "CK1", "Value");
		txtck1 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCk2;
		CreateDataBinding(ref ojb, "CK2", "Value");
		txtCk2 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCk3;
		CreateDataBinding(ref ojb, "CK3", "Value");
		txtCk3 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCK4;
		CreateDataBinding(ref ojb, "CK4", "Value");
		txtCK4 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCK5;
		CreateDataBinding(ref ojb, "CK5", "Value");
		txtCK5 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCK6;
		CreateDataBinding(ref ojb, "CK6", "Value");
		txtCK6 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCK7;
		CreateDataBinding(ref ojb, "CK7", "Value");
		txtCK7 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCK9;
		CreateDataBinding(ref ojb, "CK9", "Value");
		txtCK9 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCK8;
		CreateDataBinding(ref ojb, "CK8", "Value");
		txtCK8 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCK10;
		CreateDataBinding(ref ojb, "CK10", "Value");
		txtCK10 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCK11;
		CreateDataBinding(ref ojb, "CK11", "Value");
		txtCK11 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCK12;
		CreateDataBinding(ref ojb, "CK12", "Value");
		txtCK12 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCK13;
		CreateDataBinding(ref ojb, "CK13", "Value");
		txtCK13 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCK14;
		CreateDataBinding(ref ojb, "CK14", "Value");
		txtCK14 = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtCK15;
		CreateDataBinding(ref ojb, "CK15", "Value");
		txtCK15 = (AsTextNumeric)(object)ojb;
		((DataGridView)dgvChietKhau)[0, 0].Value = RuntimeHelpers.GetObjectValue(txtgt0.Value);
		((DataGridView)dgvChietKhau)[1, 0].Value = RuntimeHelpers.GetObjectValue(txtgt1.Value);
		((DataGridView)dgvChietKhau)[1, 1].Value = RuntimeHelpers.GetObjectValue(txtGt2.Value);
		((DataGridView)dgvChietKhau)[1, 2].Value = RuntimeHelpers.GetObjectValue(txtGt3.Value);
		((DataGridView)dgvChietKhau)[1, 3].Value = RuntimeHelpers.GetObjectValue(txtGt4.Value);
		((DataGridView)dgvChietKhau)[1, 4].Value = RuntimeHelpers.GetObjectValue(txtGt5.Value);
		((DataGridView)dgvChietKhau)[1, 5].Value = RuntimeHelpers.GetObjectValue(txtGt6.Value);
		((DataGridView)dgvChietKhau)[1, 6].Value = RuntimeHelpers.GetObjectValue(txtGt7.Value);
		((DataGridView)dgvChietKhau)[1, 7].Value = RuntimeHelpers.GetObjectValue(txtGt8.Value);
		((DataGridView)dgvChietKhau)[1, 8].Value = RuntimeHelpers.GetObjectValue(txtGt9.Value);
		((DataGridView)dgvChietKhau)[1, 9].Value = RuntimeHelpers.GetObjectValue(txtGt10.Value);
		((DataGridView)dgvChietKhau)[1, 10].Value = RuntimeHelpers.GetObjectValue(txtGt11.Value);
		((DataGridView)dgvChietKhau)[1, 11].Value = RuntimeHelpers.GetObjectValue(txtGt12.Value);
		((DataGridView)dgvChietKhau)[1, 12].Value = RuntimeHelpers.GetObjectValue(txtGt13.Value);
		((DataGridView)dgvChietKhau)[1, 13].Value = RuntimeHelpers.GetObjectValue(txtGt14.Value);
		((DataGridView)dgvChietKhau)[1, 14].Value = RuntimeHelpers.GetObjectValue(txtGt15.Value);
		((DataGridView)dgvChietKhau)[0, 1].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 0].Value);
		((DataGridView)dgvChietKhau)[0, 2].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 1].Value);
		((DataGridView)dgvChietKhau)[0, 3].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 2].Value);
		((DataGridView)dgvChietKhau)[0, 4].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 3].Value);
		((DataGridView)dgvChietKhau)[0, 5].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 4].Value);
		((DataGridView)dgvChietKhau)[0, 6].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 5].Value);
		((DataGridView)dgvChietKhau)[0, 7].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 6].Value);
		((DataGridView)dgvChietKhau)[0, 8].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 7].Value);
		((DataGridView)dgvChietKhau)[0, 9].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 8].Value);
		((DataGridView)dgvChietKhau)[0, 10].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 9].Value);
		((DataGridView)dgvChietKhau)[0, 11].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 10].Value);
		((DataGridView)dgvChietKhau)[0, 12].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 11].Value);
		((DataGridView)dgvChietKhau)[0, 13].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 12].Value);
		((DataGridView)dgvChietKhau)[0, 14].Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 13].Value);
		((DataGridView)dgvChietKhau)[2, 0].Value = RuntimeHelpers.GetObjectValue(txtck1.Value);
		((DataGridView)dgvChietKhau)[2, 1].Value = RuntimeHelpers.GetObjectValue(txtCk2.Value);
		((DataGridView)dgvChietKhau)[2, 2].Value = RuntimeHelpers.GetObjectValue(txtCk3.Value);
		((DataGridView)dgvChietKhau)[2, 3].Value = RuntimeHelpers.GetObjectValue(txtCK4.Value);
		((DataGridView)dgvChietKhau)[2, 4].Value = RuntimeHelpers.GetObjectValue(txtCK5.Value);
		((DataGridView)dgvChietKhau)[2, 5].Value = RuntimeHelpers.GetObjectValue(txtCK6.Value);
		((DataGridView)dgvChietKhau)[2, 6].Value = RuntimeHelpers.GetObjectValue(txtCK7.Value);
		((DataGridView)dgvChietKhau)[2, 7].Value = RuntimeHelpers.GetObjectValue(txtCK8.Value);
		((DataGridView)dgvChietKhau)[2, 8].Value = RuntimeHelpers.GetObjectValue(txtCK9.Value);
		((DataGridView)dgvChietKhau)[2, 9].Value = RuntimeHelpers.GetObjectValue(txtCK10.Value);
		((DataGridView)dgvChietKhau)[2, 10].Value = RuntimeHelpers.GetObjectValue(txtCK11.Value);
		((DataGridView)dgvChietKhau)[2, 11].Value = RuntimeHelpers.GetObjectValue(txtCK12.Value);
		((DataGridView)dgvChietKhau)[2, 12].Value = RuntimeHelpers.GetObjectValue(txtCK13.Value);
		((DataGridView)dgvChietKhau)[2, 13].Value = RuntimeHelpers.GetObjectValue(txtCK14.Value);
		((DataGridView)dgvChietKhau)[2, 14].Value = RuntimeHelpers.GetObjectValue(txtCK15.Value);
		if (!EditMode)
		{
			cboky.SelectedIndex = 0;
			cboMathang.SelectedIndex = 0;
			cboKhachhang.SelectedIndex = 0;
			cboTinhtren.SelectedIndex = 0;
			cboTb_TyLe.SelectedIndex = 1;
			cboTb_SLuong.SelectedIndex = 1;
		}
		((Control)cboky).Select();
	}

	protected override bool ValidData()
	{
		if (cboMathang.SelectedIndex == 0)
		{
			if (Operators.CompareString(((TextBox)txtMathang).Text.Trim(), "", false) == 0)
			{
				SetControlError((Control)(object)txtMathang, Helper.GetMessContent(50002));
				((Control)txtMathang).Focus();
				return false;
			}
		}
		else if (Operators.CompareString(((TextBox)txtMa_NHVT).Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtMa_NHVT, Helper.GetMessContent(50002));
			((Control)txtMa_NHVT).Focus();
			return false;
		}
		if (cboKhachhang.SelectedIndex == 0)
		{
			if (Operators.CompareString(((TextBox)txtKhachhang).Text.Trim(), "", false) == 0)
			{
				SetControlError((Control)(object)txtKhachhang, Helper.GetMessContent(50002));
				((Control)txtKhachhang).Focus();
				return false;
			}
		}
		else if (cboKhachhang.SelectedIndex == 1 && Operators.CompareString(((TextBox)txtMa_NHKH).Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtMa_NHKH, Helper.GetMessContent(50002));
			((Control)txtMa_NHKH).Focus();
			return false;
		}
		return true;
	}

	private void cboMathang_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!isLoading)
		{
			Label obj = lblMathang;
			KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)cboMathang.SelectedItem;
			obj.Text = keyValuePair.Value;
			if (cboMathang.SelectedIndex == 0)
			{
				((Control)txtMathang).Visible = true;
				((Control)txtMathang).Enabled = true;
				((Control)txtMa_NHVT).Visible = false;
				((Control)txtMa_NHVT).Enabled = false;
				((TextBox)txtMa_NHVT).Text = "";
			}
			else
			{
				((Control)txtMathang).Visible = false;
				((Control)txtMathang).Enabled = false;
				((TextBox)txtMathang).Text = "";
				((Control)txtMa_NHVT).Visible = true;
				((Control)txtMa_NHVT).Enabled = true;
			}
		}
	}

	private void cboKhachhang_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!isLoading)
		{
			Label obj = lblKhachhang;
			KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)cboKhachhang.SelectedItem;
			obj.Text = keyValuePair.Value;
			if (cboKhachhang.SelectedIndex == 0)
			{
				((Control)lblKhachhang).Enabled = true;
				((Control)lblKhachhang).Visible = true;
				((Control)txtKhachhang).Enabled = true;
				((Control)txtKhachhang).Visible = true;
				((Control)lblTen_Khachhang).Enabled = true;
				((Control)lblTen_Khachhang).Visible = true;
				((Control)txtMa_NHKH).Visible = false;
				((Control)txtMa_NHKH).Enabled = false;
				((TextBox)txtMa_NHKH).Text = "";
			}
			else if (cboKhachhang.SelectedIndex == 1)
			{
				txtKhachhang.LookupCodeName = "MA_NHKH";
				((Control)lblKhachhang).Enabled = true;
				((Control)lblKhachhang).Visible = true;
				((Control)lblTen_Khachhang).Enabled = true;
				((Control)lblTen_Khachhang).Visible = true;
				((Control)txtMa_NHKH).Visible = true;
				((Control)txtMa_NHKH).Enabled = true;
				((Control)txtKhachhang).Enabled = false;
				((Control)txtKhachhang).Visible = false;
				((TextBox)txtKhachhang).Text = "";
			}
			else
			{
				((Control)lblKhachhang).Enabled = false;
				((Control)lblKhachhang).Visible = false;
				((Control)txtKhachhang).Enabled = false;
				((Control)txtKhachhang).Visible = false;
				((Control)txtMa_NHKH).Visible = false;
				((Control)txtMa_NHKH).Enabled = false;
				((Control)lblTen_Khachhang).Enabled = false;
				((Control)lblTen_Khachhang).Visible = false;
			}
		}
	}

	private void cboTb_TyLe_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboTb_TyLe.SelectedIndex == 0)
		{
			((Control)cboTb_SLuong).Visible = true;
		}
		else
		{
			((Control)cboTb_SLuong).Visible = false;
		}
	}

	public void updatedata()
	{
		int num = 0;
		checked
		{
			do
			{
				if (Operators.ConditionalCompareObjectEqual(((DataGridView)dgvChietKhau)[1, num].Value, (object)0, false))
				{
					((DataGridView)dgvChietKhau)[2, num].Value = 0;
				}
				num++;
			}
			while (num <= 14);
			int num2 = 0;
			do
			{
				if (Operators.ConditionalCompareObjectEqual(((DataGridView)dgvChietKhau)[1, num2].Value, (object)999999999999.0, false))
				{
					((DataGridView)dgvChietKhau)[1, num2 + 1].Value = 0;
				}
				num2++;
			}
			while (num2 <= 13);
			txtgt0.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[0, 0].Value);
			txtgt1.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 0].Value);
			txtck1.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 0].Value);
			txtGt2.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 1].Value);
			txtCk2.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 1].Value);
			txtGt3.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 2].Value);
			txtCk3.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 2].Value);
			txtGt4.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 3].Value);
			txtCK4.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 2].Value);
			txtGt5.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 4].Value);
			txtCK5.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 4].Value);
			txtGt6.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 5].Value);
			txtCK6.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 5].Value);
			txtGt7.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 6].Value);
			txtCK7.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 6].Value);
			txtGt8.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 7].Value);
			txtCK8.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 7].Value);
			txtGt9.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 8].Value);
			txtCK9.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 8].Value);
			txtGt10.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 9].Value);
			txtCK10.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 9].Value);
			txtGt11.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 10].Value);
			txtCK11.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 10].Value);
			txtGt12.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 11].Value);
			txtCK12.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 11].Value);
			txtGt13.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 12].Value);
			txtCK13.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 12].Value);
			txtGt14.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 13].Value);
			txtCK14.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 13].Value);
			txtGt15.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[1, 14].Value);
			txtCK15.Value = RuntimeHelpers.GetObjectValue(((DataGridView)dgvChietKhau)[2, 14].Value);
		}
	}

	private void dgvChietKhau_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		updatedata();
	}
}
