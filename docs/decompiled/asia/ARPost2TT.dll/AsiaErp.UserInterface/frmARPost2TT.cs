using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmARPost2TT : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("gbCt")]
	private GroupBox _gbCt;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("adgvPhanbo_hd")]
	private AsInputDGV _adgvPhanbo_hd;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("txtMa_kh")]
	private TextBox _txtMa_kh;

	[AccessedThroughProperty("txtLoai_ct")]
	private TextBox _txtLoai_ct;

	[AccessedThroughProperty("lblTen_kh")]
	private Label _lblTen_kh;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtDien_giai")]
	private TextBox _txtDien_giai;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("txtMa_nt")]
	private TextBox _txtMa_nt;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("txtNgay_ct")]
	private AsMaskedTextBox _txtNgay_ct;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("btnNhan")]
	private Button _btnNhan;

	[AccessedThroughProperty("btnTim_ct")]
	private Button _btnTim_ct;

	[AccessedThroughProperty("btnHuy")]
	private Button _btnHuy;

	[AccessedThroughProperty("btnXoa")]
	private Button _btnXoa;

	[AccessedThroughProperty("txtT_tien_nt")]
	private AsTextNumeric _txtT_tien_nt;

	[AccessedThroughProperty("txtT_tien")]
	private AsTextNumeric _txtT_tien;

	[AccessedThroughProperty("txtTy_gia")]
	private AsTextNumeric _txtTy_gia;

	[AccessedThroughProperty("txtT_tien_cd")]
	private AsTextNumeric _txtT_tien_cd;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("txtT_tien_nt_cd")]
	private AsTextNumeric _txtT_tien_nt_cd;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("btnFirst")]
	private Button _btnFirst;

	[AccessedThroughProperty("btnPrev")]
	private Button _btnPrev;

	[AccessedThroughProperty("btnNext")]
	private Button _btnNext;

	[AccessedThroughProperty("btnLast")]
	private Button _btnLast;

	[AccessedThroughProperty("dgvcStt_rec")]
	private DataGridViewTextBoxColumn _dgvcStt_rec;

	[AccessedThroughProperty("dgvcStt_rec_hd")]
	private DataGridViewTextBoxColumn _dgvcStt_rec_hd;

	[AccessedThroughProperty("dgvcSo_ct")]
	private DataGridViewTextBoxColumn _dgvcSo_ct;

	[AccessedThroughProperty("dgvcNgay_ct")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcNgay_ct;

	[AccessedThroughProperty("dgvcTk")]
	private DataGridViewTextBoxColumn _dgvcTk;

	[AccessedThroughProperty("dgvcMa_kh")]
	private DataGridViewTextBoxColumn _dgvcMa_kh;

	[AccessedThroughProperty("dgvcMa_nt")]
	private DataGridViewTextBoxColumn _dgvcMa_nt;

	[AccessedThroughProperty("dgvcTy_gia")]
	private DataGridViewTextBoxColumn _dgvcTy_gia;

	[AccessedThroughProperty("dgvcT_tien")]
	private DataGridViewTextBoxColumn _dgvcT_tien;

	[AccessedThroughProperty("dgvcT_tien_nt")]
	private DataGridViewAsTextNumericColumn _dgvcT_tien_nt;

	[AccessedThroughProperty("dgvcTien_tt_nt")]
	private DataGridViewAsTextNumericColumn _dgvcTien_tt_nt;

	[AccessedThroughProperty("dgvcDu_hd_nt")]
	private DataGridViewAsTextNumericColumn _dgvcDu_hd_nt;

	[AccessedThroughProperty("dgvcThanhtoan")]
	private DataGridViewAsTextNumericColumn _dgvcThanhtoan;

	[AccessedThroughProperty("dgvcTien_tt_qd")]
	private DataGridViewAsTextNumericColumn _dgvcTien_tt_qd;

	[AccessedThroughProperty("dgvcDien_giai")]
	private DataGridViewTextBoxColumn _dgvcDien_giai;

	[AccessedThroughProperty("dgvcNguoi_gd")]
	private DataGridViewTextBoxColumn _dgvcNguoi_gd;

	[AccessedThroughProperty("dgvcTien_tt")]
	private DataGridViewTextBoxColumn _dgvcTien_tt;

	private bool bTrangthai;

	internal DataTable f_oDt;

	private int cIndex;

	private DataRowView oRow;

	private bool bEscape;

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

	internal virtual GroupBox gbCt
	{
		[DebuggerNonUserCode]
		get
		{
			return _gbCt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_gbCt = value;
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

	internal virtual AsInputDGV adgvPhanbo_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvPhanbo_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvPhanbo_hd_CellEndEdit);
			DataGridViewDataErrorEventHandler val2 = new DataGridViewDataErrorEventHandler(adgvPhanbo_hd_DataError);
			if (_adgvPhanbo_hd != null)
			{
				((DataGridView)_adgvPhanbo_hd).CellEndEdit -= val;
				((DataGridView)_adgvPhanbo_hd).DataError -= val2;
			}
			_adgvPhanbo_hd = value;
			if (_adgvPhanbo_hd != null)
			{
				((DataGridView)_adgvPhanbo_hd).CellEndEdit += val;
				((DataGridView)_adgvPhanbo_hd).DataError += val2;
			}
		}
	}

	internal virtual GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal virtual TextBox txtMa_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_kh = value;
		}
	}

	internal virtual TextBox txtLoai_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLoai_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtLoai_ct = value;
		}
	}

	internal virtual Label lblTen_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_kh = value;
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

	internal virtual TextBox txtDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDien_giai = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual TextBox txtMa_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nt = value;
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

	internal virtual AsMaskedTextBox txtNgay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_ct = value;
		}
	}

	internal virtual TextBox txtSo_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_ct = value;
		}
	}

	internal virtual Button btnNhan
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnNhan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnNhan_Click;
			if (_btnNhan != null)
			{
				((Control)_btnNhan).Click -= eventHandler;
			}
			_btnNhan = value;
			if (_btnNhan != null)
			{
				((Control)_btnNhan).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnTim_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnTim_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnTim_ct_Click;
			if (_btnTim_ct != null)
			{
				((Control)_btnTim_ct).Click -= eventHandler;
			}
			_btnTim_ct = value;
			if (_btnTim_ct != null)
			{
				((Control)_btnTim_ct).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnHuy
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnHuy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnHuy_Click;
			if (_btnHuy != null)
			{
				((Control)_btnHuy).Click -= eventHandler;
			}
			_btnHuy = value;
			if (_btnHuy != null)
			{
				((Control)_btnHuy).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnXoa
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnXoa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnXoa_Click;
			if (_btnXoa != null)
			{
				((Control)_btnXoa).Click -= eventHandler;
			}
			_btnXoa = value;
			if (_btnXoa != null)
			{
				((Control)_btnXoa).Click += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtT_tien_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tien_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tien_nt = value;
		}
	}

	internal virtual AsTextNumeric txtT_tien
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tien = value;
		}
	}

	internal virtual AsTextNumeric txtTy_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTy_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTy_gia = value;
		}
	}

	internal virtual AsTextNumeric txtT_tien_cd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tien_cd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tien_cd = value;
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

	internal virtual AsTextNumeric txtT_tien_nt_cd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tien_nt_cd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tien_nt_cd = value;
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

	internal virtual Button btnFirst
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnFirst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ChangeRow_Click;
			if (_btnFirst != null)
			{
				((Control)_btnFirst).Click -= eventHandler;
			}
			_btnFirst = value;
			if (_btnFirst != null)
			{
				((Control)_btnFirst).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnPrev
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnPrev;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ChangeRow_Click;
			if (_btnPrev != null)
			{
				((Control)_btnPrev).Click -= eventHandler;
			}
			_btnPrev = value;
			if (_btnPrev != null)
			{
				((Control)_btnPrev).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnNext
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnNext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ChangeRow_Click;
			if (_btnNext != null)
			{
				((Control)_btnNext).Click -= eventHandler;
			}
			_btnNext = value;
			if (_btnNext != null)
			{
				((Control)_btnNext).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnLast
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnLast;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ChangeRow_Click;
			if (_btnLast != null)
			{
				((Control)_btnLast).Click -= eventHandler;
			}
			_btnLast = value;
			if (_btnLast != null)
			{
				((Control)_btnLast).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcStt_rec
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcStt_rec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcStt_rec = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcStt_rec_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcStt_rec_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcStt_rec_hd = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_ct = value;
		}
	}

	internal virtual DataGridViewAsMaskedTextBoxColumn dgvcNgay_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcNgay_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcNgay_ct = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTk
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_kh = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_nt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTy_gia
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTy_gia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTy_gia = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcT_tien
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcT_tien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcT_tien = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcT_tien_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcT_tien_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcT_tien_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_tt_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_tt_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcDu_hd_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDu_hd_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDu_hd_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThanhtoan
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThanhtoan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThanhtoan = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_tt_qd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_tt_qd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_tt_qd = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDien_giai
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDien_giai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDien_giai = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcNguoi_gd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcNguoi_gd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcNguoi_gd = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTien_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_tt = value;
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

	protected frmARPost2TT(string menuid)
		: base(menuid)
	{
		((Form)this).Load += frmARPost2TT_Load;
		bTrangthai = true;
		cIndex = 0;
		bEscape = false;
		InitializeComponent();
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
		//IL_001b: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1134: Unknown result type (might be due to invalid IL or missing references)
		//IL_113e: Expected O, but got Unknown
		//IL_126f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1279: Expected O, but got Unknown
		//IL_1325: Unknown result type (might be due to invalid IL or missing references)
		//IL_132f: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		DataGridViewCellStyle val9 = new DataGridViewCellStyle();
		DataGridViewCellStyle val10 = new DataGridViewCellStyle();
		DataGridViewCellStyle val11 = new DataGridViewCellStyle();
		DataGridViewCellStyle val12 = new DataGridViewCellStyle();
		DataGridViewCellStyle val13 = new DataGridViewCellStyle();
		DataGridViewCellStyle val14 = new DataGridViewCellStyle();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		gbCt = new GroupBox();
		txtT_tien_nt_cd = new AsTextNumeric();
		Label4 = new Label();
		txtT_tien_cd = new AsTextNumeric();
		Label10 = new Label();
		txtT_tien_nt = new AsTextNumeric();
		txtT_tien = new AsTextNumeric();
		txtTy_gia = new AsTextNumeric();
		txtNgay_ct = new AsMaskedTextBox();
		txtMa_nt = new TextBox();
		Label7 = new Label();
		Label9 = new Label();
		Label8 = new Label();
		txtDien_giai = new TextBox();
		Label6 = new Label();
		lblTen_kh = new Label();
		txtLoai_ct = new TextBox();
		txtMa_kh = new TextBox();
		txtSo_ct = new TextBox();
		Label5 = new Label();
		adgvPhanbo_hd = new AsInputDGV();
		GroupBox2 = new GroupBox();
		btnFirst = new Button();
		btnXoa = new Button();
		btnHuy = new Button();
		btnTim_ct = new Button();
		btnNhan = new Button();
		btnPrev = new Button();
		btnNext = new Button();
		btnLast = new Button();
		dgvcStt_rec = new DataGridViewTextBoxColumn();
		dgvcStt_rec_hd = new DataGridViewTextBoxColumn();
		dgvcSo_ct = new DataGridViewTextBoxColumn();
		dgvcNgay_ct = new DataGridViewAsMaskedTextBoxColumn();
		dgvcTk = new DataGridViewTextBoxColumn();
		dgvcMa_kh = new DataGridViewTextBoxColumn();
		dgvcMa_nt = new DataGridViewTextBoxColumn();
		dgvcTy_gia = new DataGridViewTextBoxColumn();
		dgvcT_tien = new DataGridViewTextBoxColumn();
		dgvcT_tien_nt = new DataGridViewAsTextNumericColumn();
		dgvcTien_tt_nt = new DataGridViewAsTextNumericColumn();
		dgvcDu_hd_nt = new DataGridViewAsTextNumericColumn();
		dgvcThanhtoan = new DataGridViewAsTextNumericColumn();
		dgvcTien_tt_qd = new DataGridViewAsTextNumericColumn();
		dgvcDien_giai = new DataGridViewTextBoxColumn();
		dgvcNguoi_gd = new DataGridViewTextBoxColumn();
		dgvcTien_tt = new DataGridViewTextBoxColumn();
		((Control)gbCt).SuspendLayout();
		((ISupportInitialize)adgvPhanbo_hd).BeginInit();
		((Control)GroupBox2).SuspendLayout();
		((Control)this).SuspendLayout();
		Label1.AutoSize = true;
		Label label = Label1;
		Point location = new Point(16, 31);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(82, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 0;
		Label1.Text = "Mã khách hàng";
		((Control)Label2).Anchor = (AnchorStyles)8;
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(598, 31);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(65, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 1;
		Label2.Text = "Số chứng từ";
		((Control)Label3).Anchor = (AnchorStyles)8;
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(598, 55);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(77, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 2;
		Label3.Text = "Ngày chứng từ";
		((Control)gbCt).Anchor = (AnchorStyles)13;
		((Control)gbCt).Controls.Add((Control)(object)txtT_tien_nt_cd);
		((Control)gbCt).Controls.Add((Control)(object)Label4);
		((Control)gbCt).Controls.Add((Control)(object)txtT_tien_cd);
		((Control)gbCt).Controls.Add((Control)(object)Label10);
		((Control)gbCt).Controls.Add((Control)(object)txtT_tien_nt);
		((Control)gbCt).Controls.Add((Control)(object)txtT_tien);
		((Control)gbCt).Controls.Add((Control)(object)txtTy_gia);
		((Control)gbCt).Controls.Add((Control)(object)txtNgay_ct);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_nt);
		((Control)gbCt).Controls.Add((Control)(object)Label7);
		((Control)gbCt).Controls.Add((Control)(object)Label9);
		((Control)gbCt).Controls.Add((Control)(object)Label8);
		((Control)gbCt).Controls.Add((Control)(object)txtDien_giai);
		((Control)gbCt).Controls.Add((Control)(object)Label6);
		((Control)gbCt).Controls.Add((Control)(object)lblTen_kh);
		((Control)gbCt).Controls.Add((Control)(object)txtLoai_ct);
		((Control)gbCt).Controls.Add((Control)(object)txtMa_kh);
		((Control)gbCt).Controls.Add((Control)(object)txtSo_ct);
		((Control)gbCt).Controls.Add((Control)(object)Label5);
		((Control)gbCt).Controls.Add((Control)(object)Label1);
		((Control)gbCt).Controls.Add((Control)(object)Label2);
		((Control)gbCt).Controls.Add((Control)(object)Label3);
		GroupBox obj = gbCt;
		location = new Point(12, 12);
		((Control)obj).Location = location;
		((Control)gbCt).Name = "gbCt";
		GroupBox obj2 = gbCt;
		size = new Size(787, 159);
		((Control)obj2).Size = size;
		((Control)gbCt).TabIndex = 0;
		gbCt.TabStop = false;
		gbCt.Text = "Thông tin chứng từ phân bổ";
		txtT_tien_nt_cd.DecimalSymbol = ".";
		((Control)txtT_tien_nt_cd).Enabled = false;
		txtT_tien_nt_cd.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtT_tien_nt_cd;
		location = new Point(369, 126);
		((Control)asTextNumeric).Location = location;
		txtT_tien_nt_cd.Mask = "### ### ### ###.##";
		((Control)txtT_tien_nt_cd).Name = "txtT_tien_nt_cd";
		AsTextNumeric asTextNumeric2 = txtT_tien_nt_cd;
		size = new Size(88, 20);
		((Control)asTextNumeric2).Size = size;
		txtT_tien_nt_cd.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_tien_nt_cd).TabIndex = 6;
		((Control)txtT_tien_nt_cd).TabStop = false;
		((Control)txtT_tien_nt_cd).Tag = "FA";
		((TextBox)txtT_tien_nt_cd).Text = "0.00";
		((TextBox)txtT_tien_nt_cd).TextAlign = (HorizontalAlignment)1;
		txtT_tien_nt_cd.Value = 0;
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(217, 130);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(134, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 28;
		Label4.Text = "Số tiền phân bổ NT còn lại";
		txtT_tien_cd.DecimalSymbol = ".";
		((Control)txtT_tien_cd).Enabled = false;
		txtT_tien_cd.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric3 = txtT_tien_cd;
		location = new Point(369, 100);
		((Control)asTextNumeric3).Location = location;
		txtT_tien_cd.Mask = "### ### ### ###.##";
		((Control)txtT_tien_cd).Name = "txtT_tien_cd";
		AsTextNumeric asTextNumeric4 = txtT_tien_cd;
		size = new Size(88, 20);
		((Control)asTextNumeric4).Size = size;
		txtT_tien_cd.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_tien_cd).TabIndex = 5;
		((Control)txtT_tien_cd).TabStop = false;
		((Control)txtT_tien_cd).Tag = "OA";
		((TextBox)txtT_tien_cd).Text = "0.00";
		((TextBox)txtT_tien_cd).TextAlign = (HorizontalAlignment)1;
		txtT_tien_cd.Value = 0;
		Label10.AutoSize = true;
		Label label9 = Label10;
		location = new Point(217, 104);
		((Control)label9).Location = location;
		((Control)Label10).Name = "Label10";
		Label label10 = Label10;
		size = new Size(142, 13);
		((Control)label10).Size = size;
		((Control)Label10).TabIndex = 26;
		Label10.Text = "Số tiền phân bổ VND còn lại";
		txtT_tien_nt.DecimalSymbol = ".";
		((Control)txtT_tien_nt).Enabled = false;
		txtT_tien_nt.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric5 = txtT_tien_nt;
		location = new Point(108, 126);
		((Control)asTextNumeric5).Location = location;
		txtT_tien_nt.Mask = "### ### ### ###.##";
		((Control)txtT_tien_nt).Name = "txtT_tien_nt";
		AsTextNumeric asTextNumeric6 = txtT_tien_nt;
		size = new Size(88, 20);
		((Control)asTextNumeric6).Size = size;
		txtT_tien_nt.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_tien_nt).TabIndex = 4;
		((Control)txtT_tien_nt).TabStop = false;
		((Control)txtT_tien_nt).Tag = "FA";
		((TextBox)txtT_tien_nt).Text = "0.00";
		((TextBox)txtT_tien_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tien_nt.Value = 0;
		txtT_tien.DecimalSymbol = ".";
		((Control)txtT_tien).Enabled = false;
		txtT_tien.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric7 = txtT_tien;
		location = new Point(108, 100);
		((Control)asTextNumeric7).Location = location;
		txtT_tien.Mask = "### ### ### ###.##";
		((Control)txtT_tien).Name = "txtT_tien";
		AsTextNumeric asTextNumeric8 = txtT_tien;
		size = new Size(88, 20);
		((Control)asTextNumeric8).Size = size;
		txtT_tien.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtT_tien).TabIndex = 3;
		((Control)txtT_tien).TabStop = false;
		((Control)txtT_tien).Tag = "OA";
		((TextBox)txtT_tien).Text = "0.00";
		((TextBox)txtT_tien).TextAlign = (HorizontalAlignment)1;
		txtT_tien.Value = 0;
		((Control)txtTy_gia).Anchor = (AnchorStyles)8;
		txtTy_gia.DecimalSymbol = ".";
		((Control)txtTy_gia).Enabled = false;
		txtTy_gia.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric9 = txtTy_gia;
		location = new Point(690, 75);
		((Control)asTextNumeric9).Location = location;
		txtTy_gia.Mask = "### ### ### ###.##";
		((Control)txtTy_gia).Name = "txtTy_gia";
		AsTextNumeric asTextNumeric10 = txtTy_gia;
		size = new Size(86, 20);
		((Control)asTextNumeric10).Size = size;
		txtTy_gia.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtTy_gia).TabIndex = 10;
		((Control)txtTy_gia).TabStop = false;
		((TextBox)txtTy_gia).Text = "0.00";
		((TextBox)txtTy_gia).TextAlign = (HorizontalAlignment)1;
		txtTy_gia.Value = 0;
		((Control)txtNgay_ct).Anchor = (AnchorStyles)8;
		((Control)txtNgay_ct).Enabled = false;
		txtNgay_ct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_ct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_ct;
		location = new Point(690, 51);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_ct).Mask = "##/##/####";
		((Control)txtNgay_ct).Name = "txtNgay_ct";
		((MaskedTextBox)txtNgay_ct).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_ct;
		size = new Size(86, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_ct).TabIndex = 8;
		((MaskedTextBox)txtNgay_ct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_ct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		((Control)txtMa_nt).Anchor = (AnchorStyles)8;
		((Control)txtMa_nt).Enabled = false;
		TextBox obj3 = txtMa_nt;
		location = new Point(648, 75);
		((Control)obj3).Location = location;
		((Control)txtMa_nt).Name = "txtMa_nt";
		TextBox obj4 = txtMa_nt;
		size = new Size(40, 20);
		((Control)obj4).Size = size;
		((Control)txtMa_nt).TabIndex = 9;
		((Control)Label7).Anchor = (AnchorStyles)8;
		Label7.AutoSize = true;
		Label label11 = Label7;
		location = new Point(598, 79);
		((Control)label11).Location = location;
		((Control)Label7).Name = "Label7";
		Label label12 = Label7;
		size = new Size(36, 13);
		((Control)label12).Size = size;
		((Control)Label7).TabIndex = 25;
		Label7.Text = "Tỷ giá";
		Label9.AutoSize = true;
		Label label13 = Label9;
		location = new Point(16, 130);
		((Control)label13).Location = location;
		((Control)Label9).Name = "Label9";
		Label label14 = Label9;
		size = new Size(70, 13);
		((Control)label14).Size = size;
		((Control)Label9).TabIndex = 22;
		Label9.Text = "Tổng tiền NT";
		Label8.AutoSize = true;
		Label label15 = Label8;
		location = new Point(16, 104);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(78, 13);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 21;
		Label8.Text = "Tổng tiền VND";
		((Control)txtDien_giai).Enabled = false;
		TextBox obj5 = txtDien_giai;
		location = new Point(108, 75);
		((Control)obj5).Location = location;
		((Control)txtDien_giai).Name = "txtDien_giai";
		TextBox obj6 = txtDien_giai;
		size = new Size(349, 20);
		((Control)obj6).Size = size;
		((Control)txtDien_giai).TabIndex = 2;
		Label6.AutoSize = true;
		Label label17 = Label6;
		location = new Point(16, 79);
		((Control)label17).Location = location;
		((Control)Label6).Name = "Label6";
		Label label18 = Label6;
		size = new Size(48, 13);
		((Control)label18).Size = size;
		((Control)Label6).TabIndex = 18;
		Label6.Text = "Diễn giải";
		Label obj7 = lblTen_kh;
		location = new Point(203, 27);
		((Control)obj7).Location = location;
		Label obj8 = lblTen_kh;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Control)obj8).Margin = margin;
		((Control)lblTen_kh).Name = "lblTen_kh";
		Label obj9 = lblTen_kh;
		size = new Size(352, 20);
		((Control)obj9).Size = size;
		((Control)lblTen_kh).TabIndex = 16;
		lblTen_kh.TextAlign = (ContentAlignment)16;
		((Control)txtLoai_ct).Enabled = false;
		TextBox obj10 = txtLoai_ct;
		location = new Point(108, 51);
		((Control)obj10).Location = location;
		((Control)txtLoai_ct).Name = "txtLoai_ct";
		TextBox obj11 = txtLoai_ct;
		size = new Size(349, 20);
		((Control)obj11).Size = size;
		((Control)txtLoai_ct).TabIndex = 1;
		((Control)txtMa_kh).Enabled = false;
		TextBox obj12 = txtMa_kh;
		location = new Point(108, 27);
		((Control)obj12).Location = location;
		((Control)txtMa_kh).Name = "txtMa_kh";
		TextBox obj13 = txtMa_kh;
		size = new Size(88, 20);
		((Control)obj13).Size = size;
		((Control)txtMa_kh).TabIndex = 0;
		((Control)txtSo_ct).Anchor = (AnchorStyles)8;
		((Control)txtSo_ct).Enabled = false;
		TextBox obj14 = txtSo_ct;
		location = new Point(690, 27);
		((Control)obj14).Location = location;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj15 = txtSo_ct;
		size = new Size(86, 20);
		((Control)obj15).Size = size;
		((Control)txtSo_ct).TabIndex = 7;
		Label5.AutoSize = true;
		Label label19 = Label5;
		location = new Point(16, 55);
		((Control)label19).Location = location;
		((Control)Label5).Name = "Label5";
		Label label20 = Label5;
		size = new Size(72, 13);
		((Control)label20).Size = size;
		((Control)Label5).TabIndex = 10;
		Label5.Text = "Loại chứng từ";
		((DataGridView)adgvPhanbo_hd).AllowUserToAddRows = false;
		((DataGridView)adgvPhanbo_hd).AllowUserToDeleteRows = false;
		((DataGridView)adgvPhanbo_hd).AllowUserToResizeRows = false;
		((DataGridView)adgvPhanbo_hd).BackgroundColor = Color.White;
		((DataGridView)adgvPhanbo_hd).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvPhanbo_hd).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)adgvPhanbo_hd).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvPhanbo_hd).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[17]
		{
			(DataGridViewColumn)dgvcStt_rec,
			(DataGridViewColumn)dgvcStt_rec_hd,
			(DataGridViewColumn)dgvcSo_ct,
			dgvcNgay_ct,
			(DataGridViewColumn)dgvcTk,
			(DataGridViewColumn)dgvcMa_kh,
			(DataGridViewColumn)dgvcMa_nt,
			(DataGridViewColumn)dgvcTy_gia,
			(DataGridViewColumn)dgvcT_tien,
			dgvcT_tien_nt,
			dgvcTien_tt_nt,
			dgvcDu_hd_nt,
			dgvcThanhtoan,
			dgvcTien_tt_qd,
			(DataGridViewColumn)dgvcDien_giai,
			(DataGridViewColumn)dgvcNguoi_gd,
			(DataGridViewColumn)dgvcTien_tt
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)adgvPhanbo_hd).DefaultCellStyle = val2;
		((Control)adgvPhanbo_hd).Dock = (DockStyle)5;
		((DataGridView)adgvPhanbo_hd).EditMode = (DataGridViewEditMode)0;
		((DataGridView)adgvPhanbo_hd).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = adgvPhanbo_hd;
		location = new Point(3, 16);
		((Control)asInputDGV).Location = location;
		((Control)adgvPhanbo_hd).Name = "adgvPhanbo_hd";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvPhanbo_hd).RowHeadersDefaultCellStyle = val3;
		((DataGridView)adgvPhanbo_hd).RowHeadersVisible = false;
		((DataGridView)adgvPhanbo_hd).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = adgvPhanbo_hd;
		size = new Size(781, 310);
		((Control)asInputDGV2).Size = size;
		((Control)adgvPhanbo_hd).TabIndex = 0;
		((Control)adgvPhanbo_hd).TabStop = false;
		((Control)GroupBox2).Anchor = (AnchorStyles)15;
		((Control)GroupBox2).Controls.Add((Control)(object)adgvPhanbo_hd);
		GroupBox groupBox = GroupBox2;
		location = new Point(12, 177);
		((Control)groupBox).Location = location;
		((Control)GroupBox2).Name = "GroupBox2";
		GroupBox groupBox2 = GroupBox2;
		size = new Size(787, 329);
		((Control)groupBox2).Size = size;
		((Control)GroupBox2).TabIndex = 1;
		GroupBox2.TabStop = false;
		GroupBox2.Text = "Hoá đơn được phân bổ";
		((Control)btnFirst).Anchor = (AnchorStyles)10;
		((ButtonBase)btnFirst).Image = (Image)(object)Resources.imgFirst;
		Button obj16 = btnFirst;
		location = new Point(687, 513);
		((Control)obj16).Location = location;
		((Control)btnFirst).Name = "btnFirst";
		Button obj17 = btnFirst;
		size = new Size(23, 23);
		((Control)obj17).Size = size;
		((Control)btnFirst).TabIndex = 6;
		((ButtonBase)btnFirst).UseVisualStyleBackColor = true;
		((Control)btnXoa).Anchor = (AnchorStyles)10;
		((ButtonBase)btnXoa).Image = (Image)(object)Resources.imgDelete;
		((ButtonBase)btnXoa).ImageAlign = (ContentAlignment)16;
		Button obj18 = btnXoa;
		location = new Point(552, 513);
		((Control)obj18).Location = location;
		((Control)btnXoa).Name = "btnXoa";
		Button obj19 = btnXoa;
		size = new Size(60, 23);
		((Control)obj19).Size = size;
		((Control)btnXoa).TabIndex = 4;
		((ButtonBase)btnXoa).Text = "&Xoá";
		((ButtonBase)btnXoa).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnXoa).UseVisualStyleBackColor = true;
		((Control)btnHuy).Anchor = (AnchorStyles)6;
		((ButtonBase)btnHuy).Image = (Image)(object)Resources.imgPrint;
		((ButtonBase)btnHuy).ImageAlign = (ContentAlignment)16;
		Button obj20 = btnHuy;
		location = new Point(79, 513);
		((Control)obj20).Location = location;
		((Control)btnHuy).Name = "btnHuy";
		Button obj21 = btnHuy;
		size = new Size(60, 23);
		((Control)obj21).Size = size;
		((Control)btnHuy).TabIndex = 3;
		((ButtonBase)btnHuy).Text = "&In";
		((ButtonBase)btnHuy).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnHuy).UseVisualStyleBackColor = true;
		((Control)btnTim_ct).Anchor = (AnchorStyles)10;
		((ButtonBase)btnTim_ct).Image = (Image)(object)Resources.imgFind1;
		((ButtonBase)btnTim_ct).ImageAlign = (ContentAlignment)16;
		Button obj22 = btnTim_ct;
		location = new Point(619, 513);
		((Control)obj22).Location = location;
		((Control)btnTim_ct).Name = "btnTim_ct";
		Button obj23 = btnTim_ct;
		size = new Size(60, 23);
		((Control)obj23).Size = size;
		((Control)btnTim_ct).TabIndex = 5;
		((ButtonBase)btnTim_ct).Text = "&Tìm";
		((ButtonBase)btnTim_ct).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnTim_ct).UseVisualStyleBackColor = true;
		((Control)btnNhan).Anchor = (AnchorStyles)6;
		((ButtonBase)btnNhan).Image = (Image)(object)Resources.imgAdd;
		((ButtonBase)btnNhan).ImageAlign = (ContentAlignment)16;
		Button obj24 = btnNhan;
		location = new Point(12, 513);
		((Control)obj24).Location = location;
		((Control)btnNhan).Name = "btnNhan";
		Button obj25 = btnNhan;
		size = new Size(60, 23);
		((Control)obj25).Size = size;
		((Control)btnNhan).TabIndex = 2;
		((ButtonBase)btnNhan).Text = "&Mới";
		((ButtonBase)btnNhan).TextAlign = (ContentAlignment)64;
		((ButtonBase)btnNhan).UseVisualStyleBackColor = true;
		((Control)btnPrev).Anchor = (AnchorStyles)10;
		((ButtonBase)btnPrev).Image = (Image)(object)Resources.imgPrev;
		Button obj26 = btnPrev;
		location = new Point(716, 513);
		((Control)obj26).Location = location;
		((Control)btnPrev).Name = "btnPrev";
		Button obj27 = btnPrev;
		size = new Size(23, 23);
		((Control)obj27).Size = size;
		((Control)btnPrev).TabIndex = 7;
		((ButtonBase)btnPrev).UseVisualStyleBackColor = true;
		((Control)btnNext).Anchor = (AnchorStyles)10;
		((ButtonBase)btnNext).Image = (Image)(object)Resources.imgNext;
		Button obj28 = btnNext;
		location = new Point(745, 513);
		((Control)obj28).Location = location;
		((Control)btnNext).Name = "btnNext";
		Button obj29 = btnNext;
		size = new Size(23, 23);
		((Control)obj29).Size = size;
		((Control)btnNext).TabIndex = 8;
		((ButtonBase)btnNext).UseVisualStyleBackColor = true;
		((Control)btnLast).Anchor = (AnchorStyles)10;
		((ButtonBase)btnLast).Image = (Image)(object)Resources.imgLast;
		Button obj30 = btnLast;
		location = new Point(774, 513);
		((Control)obj30).Location = location;
		((Control)btnLast).Name = "btnLast";
		Button obj31 = btnLast;
		size = new Size(23, 23);
		((Control)obj31).Size = size;
		((Control)btnLast).TabIndex = 9;
		((ButtonBase)btnLast).UseVisualStyleBackColor = true;
		((DataGridViewColumn)dgvcStt_rec).DataPropertyName = "stt_rec";
		((DataGridViewColumn)dgvcStt_rec).HeaderText = "STT";
		((DataGridViewColumn)dgvcStt_rec).Name = "dgvcStt_rec";
		dgvcStt_rec.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcStt_rec).Visible = false;
		((DataGridViewColumn)dgvcStt_rec_hd).DataPropertyName = "stt_rec_hd";
		((DataGridViewColumn)dgvcStt_rec_hd).HeaderText = "STT";
		((DataGridViewColumn)dgvcStt_rec_hd).Name = "dgvcStt_rec_hd";
		((DataGridViewColumn)dgvcStt_rec_hd).Visible = false;
		((DataGridViewColumn)dgvcSo_ct).DataPropertyName = "so_ct";
		val4.Alignment = (DataGridViewContentAlignment)16;
		((DataGridViewColumn)dgvcSo_ct).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcSo_ct).HeaderText = "Số HĐ";
		((DataGridViewColumn)dgvcSo_ct).Name = "dgvcSo_ct";
		((DataGridViewColumn)dgvcSo_ct).ReadOnly = true;
		dgvcSo_ct.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcSo_ct).Width = 70;
		((DataGridViewColumn)dgvcNgay_ct).DataPropertyName = "ngay_ct";
		val5.Alignment = (DataGridViewContentAlignment)32;
		val5.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct).DefaultCellStyle = val5;
		dgvcNgay_ct.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct).HeaderText = "Ngày HĐ";
		dgvcNgay_ct.Mask = "##/##/####";
		((DataGridViewColumn)dgvcNgay_ct).Name = "dgvcNgay_ct";
		((DataGridViewColumn)dgvcNgay_ct).ReadOnly = true;
		((DataGridViewColumn)dgvcNgay_ct).Resizable = (DataGridViewTriState)1;
		dgvcNgay_ct.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcNgay_ct).Width = 80;
		((DataGridViewColumn)dgvcTk).DataPropertyName = "tk_pt";
		((DataGridViewColumn)dgvcTk).HeaderText = "Tài Khoản";
		((DataGridViewColumn)dgvcTk).Name = "dgvcTk";
		dgvcTk.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTk).Visible = false;
		((DataGridViewColumn)dgvcMa_kh).DataPropertyName = "ma_kh";
		val6.Alignment = (DataGridViewContentAlignment)32;
		((DataGridViewColumn)dgvcMa_kh).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcMa_kh).HeaderText = "Mã KH";
		((DataGridViewColumn)dgvcMa_kh).Name = "dgvcMa_kh";
		((DataGridViewColumn)dgvcMa_kh).ReadOnly = true;
		dgvcMa_kh.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_kh).Visible = false;
		((DataGridViewColumn)dgvcMa_kh).Width = 60;
		((DataGridViewColumn)dgvcMa_nt).DataPropertyName = "ma_nt";
		val7.Alignment = (DataGridViewContentAlignment)32;
		((DataGridViewColumn)dgvcMa_nt).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcMa_nt).HeaderText = "Mã NT";
		((DataGridViewColumn)dgvcMa_nt).Name = "dgvcMa_nt";
		((DataGridViewColumn)dgvcMa_nt).ReadOnly = true;
		dgvcMa_nt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_nt).Width = 65;
		((DataGridViewColumn)dgvcTy_gia).DataPropertyName = "ty_gia";
		((DataGridViewColumn)dgvcTy_gia).HeaderText = "Tỷ Giá";
		((DataGridViewColumn)dgvcTy_gia).Name = "dgvcTy_gia";
		dgvcTy_gia.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTy_gia).Visible = false;
		((DataGridViewColumn)dgvcT_tien).DataPropertyName = "t_tt";
		val8.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)dgvcT_tien).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcT_tien).HeaderText = "Tổng tiền VN";
		((DataGridViewColumn)dgvcT_tien).Name = "dgvcT_tien";
		((DataGridViewColumn)dgvcT_tien).ReadOnly = true;
		dgvcT_tien.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcT_tien).Visible = false;
		((DataGridViewColumn)dgvcT_tien_nt).DataPropertyName = "t_tt_nt";
		val9.Alignment = (DataGridViewContentAlignment)64;
		val9.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcT_tien_nt).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcT_tien_nt).HeaderText = "Tiền HĐ";
		dgvcT_tien_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcT_tien_nt).Name = "dgvcT_tien_nt";
		((DataGridViewColumn)dgvcT_tien_nt).ReadOnly = true;
		((DataGridViewColumn)dgvcT_tien_nt).Resizable = (DataGridViewTriState)1;
		dgvcT_tien_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcT_tien_nt.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)dgvcTien_tt_nt).DataPropertyName = "tien_tt_nt";
		val10.Alignment = (DataGridViewContentAlignment)64;
		val10.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_tt_nt).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcTien_tt_nt).HeaderText = "Đã TT";
		dgvcTien_tt_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_tt_nt).Name = "dgvcTien_tt_nt";
		((DataGridViewColumn)dgvcTien_tt_nt).ReadOnly = true;
		((DataGridViewColumn)dgvcTien_tt_nt).Resizable = (DataGridViewTriState)1;
		dgvcTien_tt_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_tt_nt.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)dgvcDu_hd_nt).DataPropertyName = "du_hd_nt";
		val11.Alignment = (DataGridViewContentAlignment)64;
		val11.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcDu_hd_nt).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcDu_hd_nt).HeaderText = "Còn phải TT";
		dgvcDu_hd_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcDu_hd_nt).Name = "dgvcDu_hd_nt";
		((DataGridViewColumn)dgvcDu_hd_nt).ReadOnly = true;
		((DataGridViewColumn)dgvcDu_hd_nt).Resizable = (DataGridViewTriState)1;
		dgvcDu_hd_nt.SortMode = (DataGridViewColumnSortMode)0;
		dgvcDu_hd_nt.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)dgvcThanhtoan).DataPropertyName = "thanhtoan";
		val12.Alignment = (DataGridViewContentAlignment)64;
		val12.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThanhtoan).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcThanhtoan).HeaderText = "Thanh toán";
		dgvcThanhtoan.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThanhtoan).Name = "dgvcThanhtoan";
		((DataGridViewColumn)dgvcThanhtoan).Resizable = (DataGridViewTriState)1;
		dgvcThanhtoan.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThanhtoan.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)dgvcTien_tt_qd).DataPropertyName = "tien_tt_qd";
		val13.Alignment = (DataGridViewContentAlignment)64;
		val13.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_tt_qd).DefaultCellStyle = val13;
		((DataGridViewColumn)dgvcTien_tt_qd).HeaderText = "TT quy đổi";
		dgvcTien_tt_qd.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_tt_qd).Name = "dgvcTien_tt_qd";
		((DataGridViewColumn)dgvcTien_tt_qd).ReadOnly = true;
		((DataGridViewColumn)dgvcTien_tt_qd).Resizable = (DataGridViewTriState)1;
		dgvcTien_tt_qd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTien_tt_qd.SpecialType = Commons.NumericSpecialType.Other;
		((DataGridViewColumn)dgvcDien_giai).DataPropertyName = "dien_giai";
		val14.Alignment = (DataGridViewContentAlignment)16;
		((DataGridViewColumn)dgvcDien_giai).DefaultCellStyle = val14;
		((DataGridViewColumn)dgvcDien_giai).HeaderText = "Diễn giải";
		((DataGridViewColumn)dgvcDien_giai).Name = "dgvcDien_giai";
		((DataGridViewColumn)dgvcDien_giai).ReadOnly = true;
		dgvcDien_giai.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcDien_giai).Width = 250;
		((DataGridViewColumn)dgvcNguoi_gd).DataPropertyName = "nguoi_gd";
		((DataGridViewColumn)dgvcNguoi_gd).HeaderText = "Người GD";
		((DataGridViewColumn)dgvcNguoi_gd).Name = "dgvcNguoi_gd";
		dgvcNguoi_gd.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcNguoi_gd).Visible = false;
		((DataGridViewColumn)dgvcTien_tt).DataPropertyName = "tien_tt";
		((DataGridViewColumn)dgvcTien_tt).HeaderText = "Tien_tt";
		((DataGridViewColumn)dgvcTien_tt).Name = "dgvcTien_tt";
		dgvcTien_tt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTien_tt).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(811, 542);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)btnLast);
		((Control)this).Controls.Add((Control)(object)btnNext);
		((Control)this).Controls.Add((Control)(object)btnPrev);
		((Control)this).Controls.Add((Control)(object)btnFirst);
		((Control)this).Controls.Add((Control)(object)btnXoa);
		((Control)this).Controls.Add((Control)(object)btnHuy);
		((Control)this).Controls.Add((Control)(object)btnTim_ct);
		((Control)this).Controls.Add((Control)(object)btnNhan);
		((Control)this).Controls.Add((Control)(object)GroupBox2);
		((Control)this).Controls.Add((Control)(object)gbCt);
		((Control)this).Name = "frmARPost2TT";
		((Form)this).Text = "Phân bổ tiền hàng cho hoá đơn";
		((Control)gbCt).ResumeLayout(false);
		((Control)gbCt).PerformLayout();
		((ISupportInitialize)adgvPhanbo_hd).EndInit();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		if ((int)keyData == 27)
		{
			if (!bTrangthai)
			{
				((DataGridView)adgvPhanbo_hd).EndEdit();
				if ((int)CMessageBox.Show(Helper.GetMessContent(50032), SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256) == 6)
				{
					bEscape = true;
					SetNormal();
					ClearFields();
					MoveRow();
				}
			}
			else
			{
				((Form)this).Close();
			}
		}
		if ((int)keyData == 13)
		{
			int rowCount = ((DataGridView)adgvPhanbo_hd).RowCount;
			if (rowCount > 0 && ((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, checked(rowCount - 1)].Selected)
			{
				((Control)btnNhan).Focus();
			}
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void frmARPost2TT_Load(object sender, EventArgs e)
	{
		((DataGridViewColumn)dgvcT_tien_nt).DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		((DataGridViewColumn)dgvcTien_tt_nt).DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		((DataGridViewColumn)dgvcDu_hd_nt).DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		((DataGridViewColumn)dgvcThanhtoan).DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		((DataGridViewColumn)dgvcTien_tt_qd).DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		MaskTextBoxAll(((Control)gbCt).Controls);
		GetRow();
		cIndex = -2;
		MoveRow();
	}

	private void adgvPhanbo_hd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		if ((e.ColumnIndex == 12) & (((DataGridView)adgvPhanbo_hd)[e.ColumnIndex, e.RowIndex].Value != null))
		{
			Init_adgvPhanbo_hd(e.RowIndex);
		}
	}

	private void adgvPhanbo_hd_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
	}

	private void btnTim_ct_Click(object sender, EventArgs e)
	{
		ShowFind(type: false);
	}

	private void btnNhan_Click(object sender, EventArgs e)
	{
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (bTrangthai)
			{
				((ButtonBase)btnNhan).Text = "&Lưu";
				((ButtonBase)btnNhan).Image = (Image)(object)Resources.save;
				((ButtonBase)btnHuy).Text = "&Huỷ";
				((ButtonBase)btnHuy).Image = (Image)(object)Resources.imgCancel;
				bTrangthai = false;
				bEscape = false;
				((Control)btnLast).Enabled = false;
				((Control)btnNext).Enabled = false;
				((Control)btnPrev).Enabled = false;
				((Control)btnFirst).Enabled = false;
				adgvPhanbo_hd.ReadOnly = false;
				((Control)btnXoa).Enabled = false;
				((Control)btnTim_ct).Enabled = false;
				ClearFields();
				ShowFind(type: true);
			}
			else
			{
				if (!ValidData(isView: false))
				{
					return;
				}
				int num = ((DataGridView)adgvPhanbo_hd).RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					ArrayList arrayList = new ArrayList();
					arrayList.Add(RuntimeHelpers.GetObjectValue(oRow["Stt_rec"]));
					arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcStt_rec).Name, i].Value));
					arrayList.Add(RuntimeHelpers.GetObjectValue(oRow["Ma_ct"]));
					arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcNguoi_gd).Name, i].Value));
					arrayList.Add(RuntimeHelpers.GetObjectValue(oRow["Dien_giai"]));
					arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcTk).Name, i].Value));
					arrayList.Add(RuntimeHelpers.GetObjectValue(oRow["Ma_kh"]));
					arrayList.Add(RuntimeHelpers.GetObjectValue(oRow["So_ct"]));
					arrayList.Add(RuntimeHelpers.GetObjectValue(oRow["Ngay_ct"]));
					arrayList.Add(RuntimeHelpers.GetObjectValue(oRow["Ma_nt"]));
					arrayList.Add(RuntimeHelpers.GetObjectValue(oRow["Ty_gia"]));
					arrayList.Add(RuntimeHelpers.GetObjectValue(oRow["T_tien"]));
					arrayList.Add(RuntimeHelpers.GetObjectValue(oRow["T_tien_nt"]));
					arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, i].Value));
					arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, i].Value));
					if (Operators.ConditionalCompareObjectEqual((object)txtMa_nt.Text, ((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcMa_nt).Name, i].Value, false))
					{
						arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, i].Value));
					}
					else if (Operators.ConditionalCompareObjectEqual(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcMa_nt).Name, i].Value, (object)"VND", false))
					{
						arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcTien_tt_qd).Name, i].Value));
					}
					else
					{
						arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcTien_tt_qd).Name, i].Value));
					}
					arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, i].Value));
					arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, i].Value));
					ARPost2TTDAO aRPost2TTDAO = (ARPost2TTDAO)DAOFactory.CreateDAOInstance("ARPost2TTDAO", "ARPost2TT");
					int num2 = aRPost2TTDAO.Insert(arrayList.ToArray());
					if (num2 != 0)
					{
						CMessageBox.Show(num2);
						bTrangthai = true;
						break;
					}
					aRPost2TTDAO.Destroy();
				}
				SetNormal();
				GetRow();
				GetIndex(Conversions.ToString(oRow["Stt_rec"]));
				MoveRow();
			}
		}
	}

	private void btnXoa_Click(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		if (!(bTrangthai & ValidData(isView: true)) || (int)CMessageBox.Show(Helper.GetMessContent(50003), SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256) == 7)
		{
			return;
		}
		checked
		{
			int num = ((DataGridView)adgvPhanbo_hd).RowCount - 1;
			for (int i = 0; i <= num; i++)
			{
				ArrayList arrayList = new ArrayList();
				arrayList.Add(RuntimeHelpers.GetObjectValue(oRow["Stt_rec"]));
				arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcStt_rec_hd).Name, i].Value));
				arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcTien_tt).Name, i].Value));
				arrayList.Add(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcTien_tt).Name, i].Value));
				ARPost2TTDAO aRPost2TTDAO = (ARPost2TTDAO)DAOFactory.CreateDAOInstance("ARPost2TTDAO", "ARPost2TT");
				int num2 = aRPost2TTDAO.Delete(arrayList.ToArray());
				if (num2 != 0)
				{
					CMessageBox.Show(num2);
					bTrangthai = true;
					break;
				}
				aRPost2TTDAO.Destroy();
			}
			cIndex--;
			SetNormal();
			GetRow();
			MoveRow();
		}
	}

	private void btnHuy_Click(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		if (!bTrangthai && (int)CMessageBox.Show(Helper.GetMessContent(50032), SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256) != 7)
		{
			SetNormal();
			ClearFields();
		}
	}

	private void ChangeRow_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		checked
		{
			if (f_oDt.Rows.Count != 0)
			{
				Button val = (Button)sender;
				switch (((Control)val).Name)
				{
				case "btnFirst":
					cIndex = 0;
					break;
				case "btnPrev":
					cIndex--;
					break;
				case "btnNext":
					cIndex++;
					break;
				case "btnLast":
					cIndex = -2;
					break;
				}
				MoveRow();
			}
		}
	}

	private void GetIndex(string Stt_rec)
	{
		int count = f_oDt.Rows.Count;
		for (int i = 0; i <= count; i = checked(i + 1))
		{
			if (Operators.ConditionalCompareObjectEqual(f_oDt.Rows[i]["stt_rec"], (object)Stt_rec, false))
			{
				cIndex = i;
				return;
			}
		}
		cIndex = -2;
	}

	private void GetRow()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add("");
		arrayList.Add("");
		arrayList.Add("");
		arrayList.Add("01/01/" + Conversions.ToString(SystemInformations.FinancialYear));
		arrayList.Add(DateTime.Now);
		arrayList.Add("");
		arrayList.Add(AsiaErp.Framework.Environment.GetSOConfiguration().tk_pt);
		arrayList.Add("");
		ARPost2TTDAO aRPost2TTDAO = (ARPost2TTDAO)DAOFactory.CreateDAOInstance("ARPost2TTDAO", "ARPost2TT");
		f_oDt = aRPost2TTDAO.GetDataCT(arrayList.ToArray());
		aRPost2TTDAO.Destroy();
	}

	private void MoveRow()
	{
		checked
		{
			if (bTrangthai && f_oDt.Rows.Count != 0)
			{
				if (cIndex == -2)
				{
					cIndex = f_oDt.Rows.Count - 1;
				}
				if (cIndex > f_oDt.Rows.Count - 1)
				{
					cIndex = f_oDt.Rows.Count - 1;
				}
				if (cIndex < 0)
				{
					cIndex = 0;
				}
				ClearFields();
				oRow = f_oDt.DefaultView[cIndex];
				GetPH(bIns: false);
				ARPost2TTDAO aRPost2TTDAO = (ARPost2TTDAO)DAOFactory.CreateDAOInstance("ARPost2TTDAO", "ARPost2TT");
				DataTable data = aRPost2TTDAO.GetData(AsiaErp.Framework.Environment.GetSOConfiguration().tk_pt, Conversions.ToString(oRow["Ma_kh"]), Conversions.ToDate(oRow["Ngay_ct"]), "2", Conversions.ToString(oRow["Stt_rec"]));
				((DataGridView)adgvPhanbo_hd).DataSource = data;
				adgvPhanbo_hd.ReadOnly = true;
				aRPost2TTDAO.Destroy();
				((DataGridView)adgvPhanbo_hd).DataSource = data;
			}
		}
	}

	protected void ShowFind(bool type)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		frmARPost2TTFind frmARPost2TTFind2 = new frmARPost2TTFind();
		if (type)
		{
			frmARPost2TTFind2.f_bIns = type;
		}
		else
		{
			frmARPost2TTFind2.f_bIns = type;
			adgvPhanbo_hd.ReadOnly = true;
		}
		((Form)frmARPost2TTFind2).ShowDialog();
		if (frmARPost2TTFind2.f_oDtct == null)
		{
			SetNormal();
			MoveRow();
			return;
		}
		if (frmARPost2TTFind2.f_oDtct.Rows.Count == 0)
		{
			SetNormal();
			MoveRow();
			return;
		}
		oRow = frmARPost2TTFind2.f_oRow;
		GetPH(frmARPost2TTFind2.f_bIns);
		((DataGridView)adgvPhanbo_hd).DataSource = frmARPost2TTFind2.f_oDtct;
		((DataGridView)adgvPhanbo_hd)[0, 0].Selected = true;
	}

	private void Init_adgvPhanbo_hd(int index)
	{
		Cal_Tien(txtMa_nt.Text, index);
	}

	private void Cal_Tien(string ma_nt, int index)
	{
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		if (bEscape)
		{
			return;
		}
		checked
		{
			try
			{
				double num = num + 0.0;
				int num2 = ((DataGridView)adgvPhanbo_hd).RowCount - 1;
				for (int i = 0; i <= num2; i++)
				{
					num = ((!Operators.ConditionalCompareObjectEqual(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcMa_nt).Name, i].Value, (object)"VND", false)) ? Conversions.ToDouble(Operators.AddObject((object)num, Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, i].Value), isNum: true), ((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcTy_gia).Name, i].Value))) : Conversions.ToDouble(Operators.AddObject((object)num, Helper.Repl_Null(RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, i].Value), isNum: true))));
				}
				if (Operators.ConditionalCompareObjectGreater((object)num, txtT_tien.Value, false))
				{
					CMessageBox.Show(50162);
					((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, index].Value = 0;
					((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, index].Selected = true;
					return;
				}
				if (Operators.ConditionalCompareObjectEqual((object)ma_nt, ((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcMa_nt).Name, index].Value, false))
				{
					((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcTien_tt_qd).Name, index].Value = RuntimeHelpers.GetObjectValue(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, index].Value);
				}
				else if (Operators.ConditionalCompareObjectEqual(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcMa_nt).Name, index].Value, (object)"VND", false))
				{
					((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcTien_tt_qd).Name, index].Value = Operators.DivideObject(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, index].Value, txtTy_gia.Value);
				}
				else
				{
					((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcTien_tt_qd).Name, index].Value = Operators.MultiplyObject(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, index].Value, ((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcTy_gia).Name, index].Value);
				}
				if (Operators.CompareString(ma_nt, "VND", false) == 0)
				{
					txtT_tien_cd.Value = Operators.SubtractObject(txtT_tien.Value, (object)num);
					txtT_tien_nt_cd.Value = Operators.SubtractObject(txtT_tien.Value, (object)num);
				}
				else
				{
					txtT_tien_cd.Value = Operators.SubtractObject(txtT_tien.Value, (object)num);
					txtT_tien_nt_cd.Value = Operators.SubtractObject(txtT_tien_nt.Value, Operators.DivideObject((object)num, txtTy_gia.Value));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	protected bool ValidData(bool isView)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(txtLoai_ct.Text, "", false) == 0)
		{
			return false;
		}
		if (((DataGridView)adgvPhanbo_hd).RowCount == 0)
		{
			CMessageBox.Show(50018);
			return false;
		}
		checked
		{
			if (!isView)
			{
				int num = ((DataGridView)adgvPhanbo_hd).RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcTien_tt_qd).Name, i].Value, (object)0, false))
					{
						((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, i].ErrorText = Helper.GetMess(50002).Description;
						((Control)adgvPhanbo_hd).Focus();
						((DataGridView)adgvPhanbo_hd).ClearSelection();
						((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, i].Selected = true;
						return false;
					}
					((DataGridView)adgvPhanbo_hd)[((DataGridViewColumn)dgvcThanhtoan).Name, i].ErrorText = "";
				}
			}
			return true;
		}
	}

	protected void GetPH(bool bIns)
	{
		if (oRow != null)
		{
			txtLoai_ct.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(oRow["Ma_ct"], (object)" - "), oRow["Ten_ct"]));
			txtSo_ct.Text = Conversions.ToString(oRow["So_ct"]);
			txtNgay_ct.Value = RuntimeHelpers.GetObjectValue(oRow["Ngay_ct"]);
			txtMa_nt.Text = Conversions.ToString(oRow["Ma_nt"]);
			((TextBox)txtTy_gia).Text = Conversions.ToString(oRow["Ty_gia"]);
			txtMa_kh.Text = Conversions.ToString(oRow["Ma_kh"]);
			lblTen_kh.Text = Conversions.ToString(oRow["Ten_kh"]);
			txtDien_giai.Text = Conversions.ToString(oRow["Dien_giai"]);
			if (bIns)
			{
				txtT_tien.Value = RuntimeHelpers.GetObjectValue(oRow["ST_tien"]);
				txtT_tien_nt.Value = RuntimeHelpers.GetObjectValue(oRow["ST_tien_nt"]);
			}
			else
			{
				txtT_tien.Value = RuntimeHelpers.GetObjectValue(oRow["T_tien"]);
				txtT_tien_nt.Value = RuntimeHelpers.GetObjectValue(oRow["T_tien_nt"]);
			}
		}
	}

	protected void SetNormal()
	{
		((ButtonBase)btnNhan).Text = "&Mới";
		((ButtonBase)btnNhan).Image = (Image)(object)Resources.imgAdd;
		((ButtonBase)btnHuy).Text = "&In";
		((ButtonBase)btnHuy).Image = (Image)(object)Resources.imgPrint;
		bTrangthai = true;
		adgvPhanbo_hd.ReadOnly = true;
		((Control)btnXoa).Enabled = true;
		((Control)btnTim_ct).Enabled = true;
		((Control)btnLast).Enabled = true;
		((Control)btnNext).Enabled = true;
		((Control)btnPrev).Enabled = true;
		((Control)btnFirst).Enabled = true;
	}

	protected void ClearFields()
	{
		txtDien_giai.Text = "";
		txtLoai_ct.Text = "";
		txtMa_kh.Text = "";
		lblTen_kh.Text = "";
		txtMa_nt.Text = "";
		((TextBox)txtTy_gia).Text = "";
		txtSo_ct.Text = "";
		txtNgay_ct.Value = null;
		txtT_tien.Value = null;
		txtT_tien_nt.Value = null;
		txtT_tien_cd.Value = null;
		txtT_tien_nt_cd.Value = null;
		((DataGridView)adgvPhanbo_hd).DataSource = null;
	}

	private void MaskTextBoxAll(ControlCollection ctl)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		foreach (Control item in ctl)
		{
			Control val = item;
			if (val is AsTextNumeric)
			{
				AsTextNumeric asTextNumeric = (AsTextNumeric)(object)val;
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FP", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCPrice_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"OA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"FA", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
				}
				if (Operators.ConditionalCompareObjectEqual(((Control)asTextNumeric).Tag, (object)"QT", false))
				{
					asTextNumeric.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format;
				}
			}
		}
	}
}
