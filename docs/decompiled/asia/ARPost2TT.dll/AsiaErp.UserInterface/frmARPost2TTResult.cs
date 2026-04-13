using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmARPost2TTResult : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("SplitContainer1")]
	private SplitContainer _SplitContainer1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("dgvChungtu")]
	private AsInputDGV _dgvChungtu;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("dgvHoadon")]
	private AsInputDGV _dgvHoadon;

	[AccessedThroughProperty("dgvcStt_rec1")]
	private DataGridViewTextBoxColumn _dgvcStt_rec1;

	[AccessedThroughProperty("dgvcStt_rec_hd1")]
	private DataGridViewTextBoxColumn _dgvcStt_rec_hd1;

	[AccessedThroughProperty("dgvcMa_ct1")]
	private DataGridViewTextBoxColumn _dgvcMa_ct1;

	[AccessedThroughProperty("dgvcTen_ct1")]
	private DataGridViewTextBoxColumn _dgvcTen_ct1;

	[AccessedThroughProperty("dgvcSo_ct1")]
	private DataGridViewTextBoxColumn _dgvcSo_ct1;

	[AccessedThroughProperty("dgvcNgay_ct1")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcNgay_ct1;

	[AccessedThroughProperty("dgvcMa_kh1")]
	private DataGridViewTextBoxColumn _dgvcMa_kh1;

	[AccessedThroughProperty("dgvcTen_kh1")]
	private DataGridViewTextBoxColumn _dgvcTen_kh1;

	[AccessedThroughProperty("dgvcdien_giai1")]
	private DataGridViewTextBoxColumn _dgvcdien_giai1;

	[AccessedThroughProperty("dgvcST_tien1")]
	private DataGridViewTextBoxColumn _dgvcST_tien1;

	[AccessedThroughProperty("dgvcST_tien_nt1")]
	private DataGridViewTextBoxColumn _dgvcST_tien_nt1;

	[AccessedThroughProperty("dgvcT_tien1")]
	private DataGridViewTextBoxColumn _dgvcT_tien1;

	[AccessedThroughProperty("dgvcT_tien_nt1")]
	private DataGridViewTextBoxColumn _dgvcT_tien_nt1;

	[AccessedThroughProperty("dgvcMa_nt1")]
	private DataGridViewTextBoxColumn _dgvcMa_nt1;

	[AccessedThroughProperty("dgvcTy_gia1")]
	private DataGridViewTextBoxColumn _dgvcTy_gia1;

	[AccessedThroughProperty("dgvcChk")]
	private DataGridViewCheckBoxColumn _dgvcChk;

	[AccessedThroughProperty("dgvcStt_rec2")]
	private DataGridViewTextBoxColumn _dgvcStt_rec2;

	[AccessedThroughProperty("dgvcStt_rec_hd")]
	private DataGridViewTextBoxColumn _dgvcStt_rec_hd;

	[AccessedThroughProperty("dgvcSo_ct2")]
	private DataGridViewTextBoxColumn _dgvcSo_ct2;

	[AccessedThroughProperty("dgvcNgay_ct2")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcNgay_ct2;

	[AccessedThroughProperty("dgvcTk2")]
	private DataGridViewTextBoxColumn _dgvcTk2;

	[AccessedThroughProperty("dgvcMa_kh2")]
	private DataGridViewTextBoxColumn _dgvcMa_kh2;

	[AccessedThroughProperty("dgvcDien_giai2")]
	private DataGridViewTextBoxColumn _dgvcDien_giai2;

	[AccessedThroughProperty("dgvcT_tt")]
	private DataGridViewTextBoxColumn _dgvcT_tt;

	[AccessedThroughProperty("dgvcT_tt_nt")]
	private DataGridViewTextBoxColumn _dgvcT_tt_nt;

	[AccessedThroughProperty("dgvcMa_nt2")]
	private DataGridViewTextBoxColumn _dgvcMa_nt2;

	[AccessedThroughProperty("dgvcTy_gia")]
	private DataGridViewTextBoxColumn _dgvcTy_gia;

	[AccessedThroughProperty("dgvcTien_tt")]
	private DataGridViewTextBoxColumn _dgvcTien_tt;

	[AccessedThroughProperty("dgvcTien_tt_nt")]
	private DataGridViewTextBoxColumn _dgvcTien_tt_nt;

	[AccessedThroughProperty("dgvcTien_tt_qd")]
	private DataGridViewTextBoxColumn _dgvcTien_tt_qd;

	[AccessedThroughProperty("dgvcDu_hd_nt")]
	private DataGridViewTextBoxColumn _dgvcDu_hd_nt;

	[AccessedThroughProperty("dgvcNguoi_gd")]
	private DataGridViewTextBoxColumn _dgvcNguoi_gd;

	[AccessedThroughProperty("btnChon")]
	private Button _btnChon;

	internal DataTable f_oDt;

	internal DataRowView f_oRow;

	internal DataTable f_oDtct;

	internal bool f_bIns;

	internal string f_Tk;

	private DataTable oDt;

	internal virtual SplitContainer SplitContainer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SplitContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SplitContainer1 = value;
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

	internal virtual AsInputDGV dgvChungtu
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvChungtu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = dgvChungtu_SelectionChanged;
			if (_dgvChungtu != null)
			{
				((DataGridView)_dgvChungtu).SelectionChanged -= eventHandler;
			}
			_dgvChungtu = value;
			if (_dgvChungtu != null)
			{
				((DataGridView)_dgvChungtu).SelectionChanged += eventHandler;
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

	internal virtual AsInputDGV dgvHoadon
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvHoadon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvHoadon = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcStt_rec1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcStt_rec1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcStt_rec1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcStt_rec_hd1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcStt_rec_hd1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcStt_rec_hd1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_ct1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_ct1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_ct1 = value;
		}
	}

	internal virtual DataGridViewAsMaskedTextBoxColumn dgvcNgay_ct1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcNgay_ct1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcNgay_ct1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_kh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_kh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_kh1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_kh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_kh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_kh1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcdien_giai1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcdien_giai1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcdien_giai1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcST_tien1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcST_tien1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcST_tien1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcST_tien_nt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcST_tien_nt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcST_tien_nt1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcT_tien1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcT_tien1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcT_tien1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcT_tien_nt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcT_tien_nt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcT_tien_nt1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_nt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_nt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_nt1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTy_gia1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTy_gia1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTy_gia1 = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcChk
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcChk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcChk = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcStt_rec2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcStt_rec2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcStt_rec2 = value;
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

	internal virtual DataGridViewTextBoxColumn dgvcSo_ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_ct2 = value;
		}
	}

	internal virtual DataGridViewAsMaskedTextBoxColumn dgvcNgay_ct2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcNgay_ct2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcNgay_ct2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTk2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTk2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTk2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_kh2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_kh2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_kh2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDien_giai2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDien_giai2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDien_giai2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcT_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcT_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcT_tt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcT_tt_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcT_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcT_tt_nt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_nt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_nt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_nt2 = value;
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

	internal virtual DataGridViewTextBoxColumn dgvcTien_tt_nt
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

	internal virtual DataGridViewTextBoxColumn dgvcTien_tt_qd
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

	internal virtual DataGridViewTextBoxColumn dgvcDu_hd_nt
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

	internal virtual Button btnChon
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnChon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnChon_Click;
			if (_btnChon != null)
			{
				((Control)_btnChon).Click -= eventHandler;
			}
			_btnChon = value;
			if (_btnChon != null)
			{
				((Control)_btnChon).Click += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public frmARPost2TTResult()
	{
		((Form)this).Load += frmARPost2TTResult_Load;
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
		//IL_0036: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3f: Expected O, but got Unknown
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected O, but got Unknown
		//IL_0e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1e: Expected O, but got Unknown
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
		SplitContainer1 = new SplitContainer();
		GroupBox1 = new GroupBox();
		dgvChungtu = new AsInputDGV();
		dgvcStt_rec1 = new DataGridViewTextBoxColumn();
		dgvcStt_rec_hd1 = new DataGridViewTextBoxColumn();
		dgvcMa_ct1 = new DataGridViewTextBoxColumn();
		dgvcTen_ct1 = new DataGridViewTextBoxColumn();
		dgvcSo_ct1 = new DataGridViewTextBoxColumn();
		dgvcNgay_ct1 = new DataGridViewAsMaskedTextBoxColumn();
		dgvcMa_kh1 = new DataGridViewTextBoxColumn();
		dgvcTen_kh1 = new DataGridViewTextBoxColumn();
		dgvcdien_giai1 = new DataGridViewTextBoxColumn();
		dgvcST_tien1 = new DataGridViewTextBoxColumn();
		dgvcST_tien_nt1 = new DataGridViewTextBoxColumn();
		dgvcT_tien1 = new DataGridViewTextBoxColumn();
		dgvcT_tien_nt1 = new DataGridViewTextBoxColumn();
		dgvcMa_nt1 = new DataGridViewTextBoxColumn();
		dgvcTy_gia1 = new DataGridViewTextBoxColumn();
		GroupBox2 = new GroupBox();
		dgvHoadon = new AsInputDGV();
		dgvcChk = new DataGridViewCheckBoxColumn();
		dgvcStt_rec2 = new DataGridViewTextBoxColumn();
		dgvcStt_rec_hd = new DataGridViewTextBoxColumn();
		dgvcSo_ct2 = new DataGridViewTextBoxColumn();
		dgvcNgay_ct2 = new DataGridViewAsMaskedTextBoxColumn();
		dgvcTk2 = new DataGridViewTextBoxColumn();
		dgvcMa_kh2 = new DataGridViewTextBoxColumn();
		dgvcDien_giai2 = new DataGridViewTextBoxColumn();
		dgvcT_tt = new DataGridViewTextBoxColumn();
		dgvcT_tt_nt = new DataGridViewTextBoxColumn();
		dgvcMa_nt2 = new DataGridViewTextBoxColumn();
		dgvcTy_gia = new DataGridViewTextBoxColumn();
		dgvcTien_tt = new DataGridViewTextBoxColumn();
		dgvcTien_tt_nt = new DataGridViewTextBoxColumn();
		dgvcTien_tt_qd = new DataGridViewTextBoxColumn();
		dgvcDu_hd_nt = new DataGridViewTextBoxColumn();
		dgvcNguoi_gd = new DataGridViewTextBoxColumn();
		btnChon = new Button();
		((Control)SplitContainer1.Panel1).SuspendLayout();
		((Control)SplitContainer1.Panel2).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)dgvChungtu).BeginInit();
		((Control)GroupBox2).SuspendLayout();
		((ISupportInitialize)dgvHoadon).BeginInit();
		((Control)this).SuspendLayout();
		((Control)SplitContainer1).Anchor = (AnchorStyles)15;
		SplitContainer splitContainer = SplitContainer1;
		Point location = new Point(12, 12);
		((Control)splitContainer).Location = location;
		((Control)SplitContainer1).Name = "SplitContainer1";
		SplitContainer1.Orientation = (Orientation)0;
		((Control)SplitContainer1.Panel1).Controls.Add((Control)(object)GroupBox1);
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)GroupBox2);
		SplitContainer splitContainer2 = SplitContainer1;
		Size size = new Size(699, 423);
		((Control)splitContainer2).Size = size;
		SplitContainer1.SplitterDistance = 158;
		((Control)SplitContainer1).TabIndex = 4;
		((Control)GroupBox1).Controls.Add((Control)(object)dgvChungtu);
		((Control)GroupBox1).Dock = (DockStyle)5;
		GroupBox groupBox = GroupBox1;
		location = new Point(0, 0);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(699, 158);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 1;
		GroupBox1.TabStop = false;
		GroupBox1.Text = "Danh sách chứng từ cần phân bổ";
		((DataGridView)dgvChungtu).AllowUserToAddRows = false;
		((DataGridView)dgvChungtu).AllowUserToDeleteRows = false;
		((DataGridView)dgvChungtu).AllowUserToResizeRows = false;
		((DataGridView)dgvChungtu).BackgroundColor = Color.White;
		((DataGridView)dgvChungtu).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvChungtu).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)dgvChungtu).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvChungtu).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[15]
		{
			(DataGridViewColumn)dgvcStt_rec1,
			(DataGridViewColumn)dgvcStt_rec_hd1,
			(DataGridViewColumn)dgvcMa_ct1,
			(DataGridViewColumn)dgvcTen_ct1,
			(DataGridViewColumn)dgvcSo_ct1,
			dgvcNgay_ct1,
			(DataGridViewColumn)dgvcMa_kh1,
			(DataGridViewColumn)dgvcTen_kh1,
			(DataGridViewColumn)dgvcdien_giai1,
			(DataGridViewColumn)dgvcST_tien1,
			(DataGridViewColumn)dgvcST_tien_nt1,
			(DataGridViewColumn)dgvcT_tien1,
			(DataGridViewColumn)dgvcT_tien_nt1,
			(DataGridViewColumn)dgvcMa_nt1,
			(DataGridViewColumn)dgvcTy_gia1
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvChungtu).DefaultCellStyle = val2;
		((Control)dgvChungtu).Dock = (DockStyle)5;
		((DataGridView)dgvChungtu).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = dgvChungtu;
		location = new Point(3, 16);
		((Control)asInputDGV).Location = location;
		((Control)dgvChungtu).Name = "dgvChungtu";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvChungtu).RowHeadersDefaultCellStyle = val3;
		((DataGridView)dgvChungtu).RowHeadersVisible = false;
		((DataGridView)dgvChungtu).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)dgvChungtu).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = dgvChungtu;
		size = new Size(693, 139);
		((Control)asInputDGV2).Size = size;
		((Control)dgvChungtu).TabIndex = 0;
		((DataGridViewColumn)dgvcStt_rec1).DataPropertyName = "stt_rec";
		((DataGridViewColumn)dgvcStt_rec1).HeaderText = "STT";
		((DataGridViewColumn)dgvcStt_rec1).Name = "dgvcStt_rec1";
		((DataGridViewColumn)dgvcStt_rec1).ReadOnly = true;
		((DataGridViewColumn)dgvcStt_rec1).Visible = false;
		((DataGridViewColumn)dgvcStt_rec_hd1).DataPropertyName = "stt_rec_hd";
		((DataGridViewColumn)dgvcStt_rec_hd1).HeaderText = "STT1";
		((DataGridViewColumn)dgvcStt_rec_hd1).Name = "dgvcStt_rec_hd1";
		((DataGridViewColumn)dgvcStt_rec_hd1).Visible = false;
		((DataGridViewColumn)dgvcMa_ct1).DataPropertyName = "ma_ct";
		((DataGridViewColumn)dgvcMa_ct1).HeaderText = "Mã CT";
		((DataGridViewColumn)dgvcMa_ct1).Name = "dgvcMa_ct1";
		((DataGridViewColumn)dgvcMa_ct1).Visible = false;
		((DataGridViewColumn)dgvcTen_ct1).DataPropertyName = "ten_ct";
		((DataGridViewColumn)dgvcTen_ct1).HeaderText = "Tên CT";
		((DataGridViewColumn)dgvcTen_ct1).Name = "dgvcTen_ct1";
		((DataGridViewColumn)dgvcTen_ct1).Visible = false;
		((DataGridViewColumn)dgvcSo_ct1).DataPropertyName = "so_ct";
		((DataGridViewColumn)dgvcSo_ct1).HeaderText = "Số ctừ";
		((DataGridViewColumn)dgvcSo_ct1).Name = "dgvcSo_ct1";
		((DataGridViewColumn)dgvcSo_ct1).ReadOnly = true;
		dgvcSo_ct1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcSo_ct1).Width = 80;
		((DataGridViewColumn)dgvcNgay_ct1).DataPropertyName = "ngay_ct";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct1).DefaultCellStyle = val4;
		dgvcNgay_ct1.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct1).HeaderText = "Ngày CT";
		dgvcNgay_ct1.Mask = "##/##/####";
		((DataGridViewColumn)dgvcNgay_ct1).Name = "dgvcNgay_ct1";
		((DataGridViewColumn)dgvcNgay_ct1).ReadOnly = true;
		((DataGridViewColumn)dgvcNgay_ct1).Resizable = (DataGridViewTriState)1;
		dgvcNgay_ct1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcNgay_ct1).Width = 80;
		((DataGridViewColumn)dgvcMa_kh1).DataPropertyName = "ma_kh";
		((DataGridViewColumn)dgvcMa_kh1).HeaderText = "Mã KH";
		((DataGridViewColumn)dgvcMa_kh1).Name = "dgvcMa_kh1";
		((DataGridViewColumn)dgvcMa_kh1).ReadOnly = true;
		dgvcMa_kh1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_kh1).Width = 75;
		((DataGridViewColumn)dgvcTen_kh1).DataPropertyName = "ten_kh";
		((DataGridViewColumn)dgvcTen_kh1).HeaderText = "Tên KH";
		((DataGridViewColumn)dgvcTen_kh1).Name = "dgvcTen_kh1";
		((DataGridViewColumn)dgvcTen_kh1).Visible = false;
		((DataGridViewColumn)dgvcdien_giai1).DataPropertyName = "dien_giai";
		((DataGridViewColumn)dgvcdien_giai1).HeaderText = "Diễn giải";
		((DataGridViewColumn)dgvcdien_giai1).Name = "dgvcdien_giai1";
		((DataGridViewColumn)dgvcdien_giai1).ReadOnly = true;
		dgvcdien_giai1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcdien_giai1).Width = 145;
		((DataGridViewColumn)dgvcST_tien1).DataPropertyName = "st_tien";
		val5.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)dgvcST_tien1).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcST_tien1).HeaderText = "Tổng tiền VN";
		((DataGridViewColumn)dgvcST_tien1).Name = "dgvcST_tien1";
		((DataGridViewColumn)dgvcST_tien1).ReadOnly = true;
		dgvcST_tien1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcST_tien1).Visible = false;
		((DataGridViewColumn)dgvcST_tien1).Width = 120;
		((DataGridViewColumn)dgvcST_tien_nt1).DataPropertyName = "st_tien_nt";
		val6.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)dgvcST_tien_nt1).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcST_tien_nt1).HeaderText = "Tổng tiền NT";
		((DataGridViewColumn)dgvcST_tien_nt1).Name = "dgvcST_tien_nt1";
		((DataGridViewColumn)dgvcST_tien_nt1).ReadOnly = true;
		dgvcST_tien_nt1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcST_tien_nt1).Visible = false;
		((DataGridViewColumn)dgvcST_tien_nt1).Width = 120;
		((DataGridViewColumn)dgvcT_tien1).DataPropertyName = "t_tien";
		((DataGridViewColumn)dgvcT_tien1).HeaderText = "Tổng tiền VN";
		((DataGridViewColumn)dgvcT_tien1).Name = "dgvcT_tien1";
		((DataGridViewColumn)dgvcT_tien1).Visible = false;
		((DataGridViewColumn)dgvcT_tien1).Width = 120;
		((DataGridViewColumn)dgvcT_tien_nt1).DataPropertyName = "t_tien_nt";
		((DataGridViewColumn)dgvcT_tien_nt1).HeaderText = "Tổng tiền NT";
		((DataGridViewColumn)dgvcT_tien_nt1).Name = "dgvcT_tien_nt1";
		((DataGridViewColumn)dgvcT_tien_nt1).Visible = false;
		((DataGridViewColumn)dgvcT_tien_nt1).Width = 120;
		((DataGridViewColumn)dgvcMa_nt1).DataPropertyName = "ma_nt";
		((DataGridViewColumn)dgvcMa_nt1).HeaderText = "Mã NT";
		((DataGridViewColumn)dgvcMa_nt1).Name = "dgvcMa_nt1";
		((DataGridViewColumn)dgvcMa_nt1).ReadOnly = true;
		dgvcMa_nt1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_nt1).Width = 70;
		((DataGridViewColumn)dgvcTy_gia1).DataPropertyName = "ty_gia";
		((DataGridViewColumn)dgvcTy_gia1).HeaderText = "Tỷ giá";
		((DataGridViewColumn)dgvcTy_gia1).Name = "dgvcTy_gia1";
		((DataGridViewColumn)dgvcTy_gia1).Visible = false;
		((Control)GroupBox2).Controls.Add((Control)(object)dgvHoadon);
		((Control)GroupBox2).Dock = (DockStyle)5;
		GroupBox groupBox3 = GroupBox2;
		location = new Point(0, 0);
		((Control)groupBox3).Location = location;
		((Control)GroupBox2).Name = "GroupBox2";
		GroupBox groupBox4 = GroupBox2;
		size = new Size(699, 261);
		((Control)groupBox4).Size = size;
		((Control)GroupBox2).TabIndex = 2;
		GroupBox2.TabStop = false;
		GroupBox2.Text = "Danh sách chứng từ được phân bổ";
		((DataGridView)dgvHoadon).AllowUserToAddRows = false;
		((DataGridView)dgvHoadon).AllowUserToDeleteRows = false;
		((DataGridView)dgvHoadon).AllowUserToResizeRows = false;
		((DataGridView)dgvHoadon).BackgroundColor = Color.White;
		((DataGridView)dgvHoadon).BorderStyle = (BorderStyle)2;
		val7.Alignment = (DataGridViewContentAlignment)16;
		val7.BackColor = SystemColors.Control;
		val7.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val7.ForeColor = SystemColors.WindowText;
		val7.SelectionBackColor = SystemColors.Highlight;
		val7.SelectionForeColor = SystemColors.HighlightText;
		val7.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvHoadon).ColumnHeadersDefaultCellStyle = val7;
		((DataGridView)dgvHoadon).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvHoadon).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[17]
		{
			(DataGridViewColumn)dgvcChk,
			(DataGridViewColumn)dgvcStt_rec2,
			(DataGridViewColumn)dgvcStt_rec_hd,
			(DataGridViewColumn)dgvcSo_ct2,
			dgvcNgay_ct2,
			(DataGridViewColumn)dgvcTk2,
			(DataGridViewColumn)dgvcMa_kh2,
			(DataGridViewColumn)dgvcDien_giai2,
			(DataGridViewColumn)dgvcT_tt,
			(DataGridViewColumn)dgvcT_tt_nt,
			(DataGridViewColumn)dgvcMa_nt2,
			(DataGridViewColumn)dgvcTy_gia,
			(DataGridViewColumn)dgvcTien_tt,
			(DataGridViewColumn)dgvcTien_tt_nt,
			(DataGridViewColumn)dgvcTien_tt_qd,
			(DataGridViewColumn)dgvcDu_hd_nt,
			(DataGridViewColumn)dgvcNguoi_gd
		});
		val8.Alignment = (DataGridViewContentAlignment)16;
		val8.BackColor = SystemColors.Window;
		val8.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val8.ForeColor = SystemColors.ControlText;
		val8.SelectionBackColor = SystemColors.Highlight;
		val8.SelectionForeColor = SystemColors.HighlightText;
		val8.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvHoadon).DefaultCellStyle = val8;
		((Control)dgvHoadon).Dock = (DockStyle)5;
		((DataGridView)dgvHoadon).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV3 = dgvHoadon;
		location = new Point(3, 16);
		((Control)asInputDGV3).Location = location;
		((Control)dgvHoadon).Name = "dgvHoadon";
		val9.Alignment = (DataGridViewContentAlignment)32;
		val9.BackColor = SystemColors.Control;
		val9.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val9.ForeColor = SystemColors.WindowText;
		val9.SelectionBackColor = SystemColors.Highlight;
		val9.SelectionForeColor = SystemColors.HighlightText;
		val9.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvHoadon).RowHeadersDefaultCellStyle = val9;
		((DataGridView)dgvHoadon).RowHeadersVisible = false;
		((DataGridView)dgvHoadon).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)dgvHoadon).RowTemplate.Height = 20;
		AsInputDGV asInputDGV4 = dgvHoadon;
		size = new Size(693, 242);
		((Control)asInputDGV4).Size = size;
		((Control)dgvHoadon).TabIndex = 0;
		((DataGridViewColumn)dgvcChk).DataPropertyName = "chk";
		((DataGridViewColumn)dgvcChk).HeaderText = "";
		((DataGridViewColumn)dgvcChk).Name = "dgvcChk";
		((DataGridViewColumn)dgvcChk).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)dgvcChk).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcChk).Width = 20;
		((DataGridViewColumn)dgvcStt_rec2).DataPropertyName = "stt_rec";
		((DataGridViewColumn)dgvcStt_rec2).HeaderText = "STT";
		((DataGridViewColumn)dgvcStt_rec2).Name = "dgvcStt_rec2";
		((DataGridViewColumn)dgvcStt_rec2).ReadOnly = true;
		((DataGridViewColumn)dgvcStt_rec2).Visible = false;
		((DataGridViewColumn)dgvcStt_rec_hd).DataPropertyName = "stt_rec_hd";
		((DataGridViewColumn)dgvcStt_rec_hd).HeaderText = "STT1";
		((DataGridViewColumn)dgvcStt_rec_hd).Name = "dgvcStt_rec_hd";
		((DataGridViewColumn)dgvcStt_rec_hd).ReadOnly = true;
		((DataGridViewColumn)dgvcStt_rec_hd).Visible = false;
		((DataGridViewColumn)dgvcSo_ct2).DataPropertyName = "so_ct";
		((DataGridViewColumn)dgvcSo_ct2).HeaderText = "Số ctừ";
		((DataGridViewColumn)dgvcSo_ct2).Name = "dgvcSo_ct2";
		((DataGridViewColumn)dgvcSo_ct2).ReadOnly = true;
		dgvcSo_ct2.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcSo_ct2).Width = 80;
		((DataGridViewColumn)dgvcNgay_ct2).DataPropertyName = "ngay_ct";
		val10.Alignment = (DataGridViewContentAlignment)64;
		val10.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct2).DefaultCellStyle = val10;
		dgvcNgay_ct2.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct2).HeaderText = "Ngày CT";
		dgvcNgay_ct2.Mask = "##/##/####";
		((DataGridViewColumn)dgvcNgay_ct2).Name = "dgvcNgay_ct2";
		((DataGridViewColumn)dgvcNgay_ct2).ReadOnly = true;
		((DataGridViewColumn)dgvcNgay_ct2).Resizable = (DataGridViewTriState)1;
		dgvcNgay_ct2.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcNgay_ct2).Width = 80;
		((DataGridViewColumn)dgvcTk2).DataPropertyName = "tk_pt";
		((DataGridViewColumn)dgvcTk2).HeaderText = "Tài khoản";
		((DataGridViewColumn)dgvcTk2).Name = "dgvcTk2";
		dgvcTk2.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTk2).Visible = false;
		((DataGridViewColumn)dgvcMa_kh2).DataPropertyName = "ma_kh";
		((DataGridViewColumn)dgvcMa_kh2).HeaderText = "Mã KH";
		((DataGridViewColumn)dgvcMa_kh2).Name = "dgvcMa_kh2";
		((DataGridViewColumn)dgvcMa_kh2).ReadOnly = true;
		dgvcMa_kh2.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_kh2).Width = 70;
		((DataGridViewColumn)dgvcDien_giai2).DataPropertyName = "dien_giai";
		((DataGridViewColumn)dgvcDien_giai2).HeaderText = "Diễn giải";
		((DataGridViewColumn)dgvcDien_giai2).Name = "dgvcDien_giai2";
		((DataGridViewColumn)dgvcDien_giai2).ReadOnly = true;
		dgvcDien_giai2.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcDien_giai2).Width = 125;
		((DataGridViewColumn)dgvcT_tt).DataPropertyName = "t_tt";
		val11.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)dgvcT_tt).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcT_tt).HeaderText = "Tổng tiền VN";
		((DataGridViewColumn)dgvcT_tt).Name = "dgvcT_tt";
		((DataGridViewColumn)dgvcT_tt).ReadOnly = true;
		dgvcT_tt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcT_tt).Width = 120;
		((DataGridViewColumn)dgvcT_tt_nt).DataPropertyName = "t_tt_nt";
		val12.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)dgvcT_tt_nt).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcT_tt_nt).HeaderText = "Tổng tiền NT";
		((DataGridViewColumn)dgvcT_tt_nt).Name = "dgvcT_tt_nt";
		((DataGridViewColumn)dgvcT_tt_nt).ReadOnly = true;
		dgvcT_tt_nt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcT_tt_nt).Width = 120;
		((DataGridViewColumn)dgvcMa_nt2).DataPropertyName = "ma_nt";
		((DataGridViewColumn)dgvcMa_nt2).HeaderText = "Mã NT";
		((DataGridViewColumn)dgvcMa_nt2).Name = "dgvcMa_nt2";
		((DataGridViewColumn)dgvcMa_nt2).ReadOnly = true;
		dgvcMa_nt2.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_nt2).Width = 75;
		((DataGridViewColumn)dgvcTy_gia).DataPropertyName = "ty_gia";
		((DataGridViewColumn)dgvcTy_gia).HeaderText = "Tỷ Giá";
		((DataGridViewColumn)dgvcTy_gia).Name = "dgvcTy_gia";
		((DataGridViewColumn)dgvcTy_gia).ReadOnly = true;
		((DataGridViewColumn)dgvcTy_gia).Visible = false;
		((DataGridViewColumn)dgvcTien_tt).DataPropertyName = "tien_tt";
		((DataGridViewColumn)dgvcTien_tt).HeaderText = "Tien_tt";
		((DataGridViewColumn)dgvcTien_tt).Name = "dgvcTien_tt";
		((DataGridViewColumn)dgvcTien_tt).Visible = false;
		((DataGridViewColumn)dgvcTien_tt_nt).DataPropertyName = "tien_tt_nt";
		((DataGridViewColumn)dgvcTien_tt_nt).HeaderText = "Tien_tt_nt";
		((DataGridViewColumn)dgvcTien_tt_nt).Name = "dgvcTien_tt_nt";
		((DataGridViewColumn)dgvcTien_tt_nt).ReadOnly = true;
		((DataGridViewColumn)dgvcTien_tt_nt).Visible = false;
		((DataGridViewColumn)dgvcTien_tt_qd).DataPropertyName = "tien_tt_qd";
		((DataGridViewColumn)dgvcTien_tt_qd).HeaderText = "Tien_tt_qd";
		((DataGridViewColumn)dgvcTien_tt_qd).Name = "dgvcTien_tt_qd";
		((DataGridViewColumn)dgvcTien_tt_qd).ReadOnly = true;
		((DataGridViewColumn)dgvcTien_tt_qd).Visible = false;
		((DataGridViewColumn)dgvcDu_hd_nt).DataPropertyName = "du_hd_nt";
		((DataGridViewColumn)dgvcDu_hd_nt).HeaderText = "Còn phải TT";
		((DataGridViewColumn)dgvcDu_hd_nt).Name = "dgvcDu_hd_nt";
		((DataGridViewColumn)dgvcDu_hd_nt).ReadOnly = true;
		((DataGridViewColumn)dgvcDu_hd_nt).Visible = false;
		((DataGridViewColumn)dgvcNguoi_gd).DataPropertyName = "nguoi_gd";
		((DataGridViewColumn)dgvcNguoi_gd).HeaderText = "Người GD";
		((DataGridViewColumn)dgvcNguoi_gd).Name = "dgvcNguoi_gd";
		((DataGridViewColumn)dgvcNguoi_gd).ReadOnly = true;
		((DataGridViewColumn)dgvcNguoi_gd).Visible = false;
		((Control)btnChon).Anchor = (AnchorStyles)6;
		((ButtonBase)btnChon).ImageAlign = (ContentAlignment)16;
		Button obj = btnChon;
		location = new Point(15, 441);
		((Control)obj).Location = location;
		((Control)btnChon).Name = "btnChon";
		Button obj2 = btnChon;
		size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)btnChon).TabIndex = 6;
		((ButtonBase)btnChon).Text = "&Chọn";
		((ButtonBase)btnChon).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(723, 470);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)btnChon);
		((Control)this).Controls.Add((Control)(object)SplitContainer1);
		((Control)this).Name = "frmARPost2TTResult";
		((Form)this).Text = "Danh sách kết quả lọc chứng từ";
		((Control)SplitContainer1.Panel1).ResumeLayout(false);
		((Control)SplitContainer1.Panel2).ResumeLayout(false);
		((Control)SplitContainer1).ResumeLayout(false);
		((Control)GroupBox1).ResumeLayout(false);
		((ISupportInitialize)dgvChungtu).EndInit();
		((Control)GroupBox2).ResumeLayout(false);
		((ISupportInitialize)dgvHoadon).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			if (!f_bIns)
			{
				OnClose();
			}
			else
			{
				((Form)this).Close();
			}
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void frmARPost2TTResult_Load(object sender, EventArgs e)
	{
		((DataGridView)dgvChungtu).DataSource = f_oDt;
		if (((DataGridView)dgvChungtu).RowCount != 0)
		{
			((DataGridView)dgvChungtu).CurrentCell = ((DataGridView)dgvChungtu)[4, 0];
			f_oRow = (DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvChungtu).DataSource)].Current;
		}
		else
		{
			f_oRow = null;
		}
		if (f_bIns)
		{
			((DataGridViewColumn)dgvcT_tien1).Visible = false;
			((DataGridViewColumn)dgvcT_tien_nt1).Visible = false;
			((DataGridViewColumn)dgvcST_tien1).Visible = true;
			((DataGridViewColumn)dgvcST_tien_nt1).Visible = true;
		}
		else
		{
			((DataGridViewColumn)dgvcT_tien1).Visible = true;
			((DataGridViewColumn)dgvcT_tien_nt1).Visible = true;
			((DataGridViewColumn)dgvcST_tien1).Visible = false;
			((DataGridViewColumn)dgvcST_tien_nt1).Visible = false;
		}
		((DataGridViewColumn)dgvcT_tien1).DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		((DataGridViewColumn)dgvcT_tien_nt1).DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		((DataGridViewColumn)dgvcST_tien1).DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		((DataGridViewColumn)dgvcST_tien_nt1).DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		((DataGridViewColumn)dgvcT_tt).DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		((DataGridViewColumn)dgvcT_tt_nt).DefaultCellStyle.Format = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
	}

	private void dgvChungtu_SelectionChanged(object sender, EventArgs e)
	{
		if (((DataGridView)dgvChungtu).CurrentRow != null)
		{
			f_oRow = (DataRowView)((ContainerControl)this).BindingContext[RuntimeHelpers.GetObjectValue(((DataGridView)dgvChungtu).DataSource)].Current;
			LoadChitiet();
		}
	}

	private void btnChon_Click(object sender, EventArgs e)
	{
		OnClose();
	}

	protected void LoadChitiet()
	{
		ARPost2TTDAO aRPost2TTDAO = (ARPost2TTDAO)DAOFactory.CreateDAOInstance("ARPost2TTDAO", "ARPost2TT");
		if (f_bIns)
		{
			oDt = aRPost2TTDAO.GetData(f_Tk, Conversions.ToString(((DataGridView)dgvChungtu).CurrentRow.Cells[((DataGridViewColumn)dgvcMa_kh1).Name].Value), Conversions.ToDate(((DataGridView)dgvChungtu).CurrentRow.Cells[((DataGridViewColumn)dgvcNgay_ct1).Name].Value), "1");
			((DataGridView)dgvHoadon).DataSource = oDt;
			dgvHoadon.ReadOnly = false;
		}
		else
		{
			oDt = aRPost2TTDAO.GetData(f_Tk, Conversions.ToString(((DataGridView)dgvChungtu).CurrentRow.Cells[((DataGridViewColumn)dgvcMa_kh1).Name].Value), Conversions.ToDate(((DataGridView)dgvChungtu).CurrentRow.Cells[((DataGridViewColumn)dgvcNgay_ct1).Name].Value), "2", Conversions.ToString(((DataGridView)dgvChungtu).CurrentRow.Cells[((DataGridViewColumn)dgvcStt_rec1).Name].Value));
			((DataGridView)dgvHoadon).DataSource = oDt;
			dgvHoadon.ReadOnly = true;
		}
		aRPost2TTDAO.Destroy();
	}

	protected void OnClose()
	{
		checked
		{
			if (oDt != null)
			{
				((DataGridView)dgvHoadon).EndEdit();
				oDt.AcceptChanges();
				f_oDtct = oDt.Clone();
				int num = 0;
				int num2 = oDt.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (f_bIns)
					{
						if (Conversions.ToBoolean(oDt.Rows[i]["chk"]))
						{
							f_oDtct.ImportRow(oDt.Rows[i]);
							f_oDtct.Rows[num]["tien_tt_nt"] = RuntimeHelpers.GetObjectValue(f_oDtct.Rows[num]["thanhtoan"]);
							f_oDtct.Rows[num]["thanhtoan"] = 0;
							num++;
						}
					}
					else
					{
						f_oDtct.ImportRow(oDt.Rows[i]);
					}
				}
			}
			((Form)this).Close();
		}
	}
}
