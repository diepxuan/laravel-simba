using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmGlVchGL1 : frmVoucher
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("adgvDetail")]
	private AsInputDGV _adgvDetail;

	[AccessedThroughProperty("lblNgay_Lct")]
	private Label _lblNgay_Lct;

	[AccessedThroughProperty("txtNgay_lct")]
	private AsMaskedTextBox _txtNgay_lct;

	[AccessedThroughProperty("txtT_Tien_Co")]
	private AsTextNumeric _txtT_Tien_Co;

	[AccessedThroughProperty("lblT_Tien_Nt")]
	private Label _lblT_Tien_Nt;

	[AccessedThroughProperty("txtT_tien_Nt_Co")]
	private AsTextNumeric _txtT_tien_Nt_Co;

	[AccessedThroughProperty("DMNTInformationBindingSource")]
	private BindingSource _DMNTInformationBindingSource;

	[AccessedThroughProperty("tabTaIn")]
	private TabPage _tabTaIn;

	[AccessedThroughProperty("ctlTaIn")]
	private ctlTaIn _ctlTaIn;

	[AccessedThroughProperty("tabTaOut")]
	private TabPage _tabTaOut;

	[AccessedThroughProperty("AsCheckBox2")]
	private AsCheckBox _AsCheckBox2;

	[AccessedThroughProperty("txtTy_gia")]
	private AsTextNumeric _txtTy_gia;

	[AccessedThroughProperty("cboMa_NT")]
	private AsComboBoxNT _cboMa_NT;

	[AccessedThroughProperty("chkNt_Ph")]
	private AsCheckBox _chkNt_Ph;

	[AccessedThroughProperty("lblT_Tt")]
	private Label _lblT_Tt;

	[AccessedThroughProperty("txtT_Thue_ra")]
	private AsTextNumeric _txtT_Thue_ra;

	[AccessedThroughProperty("txtT_Thue_ra_nt")]
	private AsTextNumeric _txtT_Thue_ra_nt;

	[AccessedThroughProperty("lblT_Thue_vao_nt")]
	private Label _lblT_Thue_vao_nt;

	[AccessedThroughProperty("txtT_Thue_vao")]
	private AsTextNumeric _txtT_Thue_vao;

	[AccessedThroughProperty("txtT_Thue_vao_nt")]
	private AsTextNumeric _txtT_Thue_vao_nt;

	[AccessedThroughProperty("ctlTaOut")]
	private ctlTaOut _ctlTaOut;

	[AccessedThroughProperty("txtT_tien_Nt_No")]
	private AsTextNumeric _txtT_tien_Nt_No;

	[AccessedThroughProperty("txtT_Tien_No")]
	private AsTextNumeric _txtT_Tien_No;

	[AccessedThroughProperty("txtT_tt_nt")]
	private AsTextNumeric _txtT_tt_nt;

	[AccessedThroughProperty("txtT_tt")]
	private AsTextNumeric _txtT_tt;

	[AccessedThroughProperty("dgvcTk")]
	private DataGridViewAsTextBoxColumn _dgvcTk;

	[AccessedThroughProperty("dgvcTen_tk")]
	private DataGridViewTextBoxColumn _dgvcTen_tk;

	[AccessedThroughProperty("dgvcMa_kh")]
	private DataGridViewAsTextBoxColumn _dgvcMa_kh;

	[AccessedThroughProperty("dgvcTen_kh")]
	private DataGridViewTextBoxColumn _dgvcTen_kh;

	[AccessedThroughProperty("dgvcMa_nt")]
	private DataGridViewComboBoxColumn _dgvcMa_nt;

	[AccessedThroughProperty("dgvcTy_gia")]
	private DataGridViewAsTextNumericColumn _dgvcTy_gia;

	[AccessedThroughProperty("dgvcPs_no_nt")]
	private DataGridViewAsTextNumericColumn _dgvcPs_no_nt;

	[AccessedThroughProperty("dgvcPs_co_nt")]
	private DataGridViewAsTextNumericColumn _dgvcPs_co_nt;

	[AccessedThroughProperty("dgvcPs_no")]
	private DataGridViewAsTextNumericColumn _dgvcPs_no;

	[AccessedThroughProperty("dgvcPs_co")]
	private DataGridViewAsTextNumericColumn _dgvcPs_co;

	[AccessedThroughProperty("dgvcDien_giai")]
	private DataGridViewTextBoxColumn _dgvcDien_giai;

	[AccessedThroughProperty("dgvcMa_bp")]
	private DataGridViewAsTextBoxColumn _dgvcMa_bp;

	[AccessedThroughProperty("dgvcMa_phi")]
	private DataGridViewAsTextBoxColumn _dgvcMa_phi;

	[AccessedThroughProperty("dgvcMa_hd")]
	private DataGridViewAsTextBoxColumn _dgvcMa_hd;

	[AccessedThroughProperty("dgvcMa_spct")]
	private DataGridViewAsTextBoxColumn _dgvcMa_spct;

	[AccessedThroughProperty("dgvcNh_dk")]
	private DataGridViewTextBoxColumn _dgvcNh_dk;

	private string f_sPs_no_header;

	private string f_sPs_co_header;

	internal virtual AsInputDGV adgvDetail
	{
		[DebuggerNonUserCode]
		get
		{
			return _adgvDetail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(adgvDetail_CellEnter);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(adgvDetail_CellValueChanged);
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellEnter -= val;
				((DataGridView)_adgvDetail).CellValueChanged -= val2;
			}
			_adgvDetail = value;
			if (_adgvDetail != null)
			{
				((DataGridView)_adgvDetail).CellEnter += val;
				((DataGridView)_adgvDetail).CellValueChanged += val2;
			}
		}
	}

	internal virtual Label lblNgay_Lct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNgay_Lct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNgay_Lct = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_lct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_lct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_lct = value;
		}
	}

	internal virtual AsTextNumeric txtT_Tien_Co
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Tien_Co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Tien_Co = value;
		}
	}

	private virtual Label lblT_Tien_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_Tien_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_Tien_Nt = value;
		}
	}

	internal virtual AsTextNumeric txtT_tien_Nt_Co
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tien_Nt_Co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tien_Nt_Co = value;
		}
	}

	internal virtual BindingSource DMNTInformationBindingSource
	{
		[DebuggerNonUserCode]
		get
		{
			return _DMNTInformationBindingSource;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DMNTInformationBindingSource = value;
		}
	}

	internal virtual TabPage tabTaIn
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabTaIn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabTaIn = value;
		}
	}

	internal virtual ctlTaIn ctlTaIn
	{
		[DebuggerNonUserCode]
		get
		{
			return _ctlTaIn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			ctlTaIn.TAINValueChangedEventHandler obj = ctlTaIn_TAINValueChanged;
			if (_ctlTaIn != null)
			{
				_ctlTaIn.TAINValueChanged -= obj;
			}
			_ctlTaIn = value;
			if (_ctlTaIn != null)
			{
				_ctlTaIn.TAINValueChanged += obj;
			}
		}
	}

	internal virtual TabPage tabTaOut
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabTaOut;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabTaOut = value;
		}
	}

	internal virtual AsCheckBox AsCheckBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _AsCheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AsCheckBox2 = value;
		}
	}

	private virtual AsTextNumeric txtTy_gia
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
			EventHandler eventHandler = txtTy_gia_Validated;
			if (_txtTy_gia != null)
			{
				((Control)_txtTy_gia).Validated -= eventHandler;
			}
			_txtTy_gia = value;
			if (_txtTy_gia != null)
			{
				((Control)_txtTy_gia).Validated += eventHandler;
			}
		}
	}

	private virtual AsComboBoxNT cboMa_NT
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboMa_NT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboMa_NT_SelectedValueChanged;
			if (_cboMa_NT != null)
			{
				((ListControl)_cboMa_NT).SelectedValueChanged -= eventHandler;
			}
			_cboMa_NT = value;
			if (_cboMa_NT != null)
			{
				((ListControl)_cboMa_NT).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual AsCheckBox chkNt_Ph
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkNt_Ph;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkNt_Ph_CheckedChanged;
			if (_chkNt_Ph != null)
			{
				((CheckBox)_chkNt_Ph).CheckedChanged -= eventHandler;
			}
			_chkNt_Ph = value;
			if (_chkNt_Ph != null)
			{
				((CheckBox)_chkNt_Ph).CheckedChanged += eventHandler;
			}
		}
	}

	private virtual Label lblT_Tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_Tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_Tt = value;
		}
	}

	internal virtual AsTextNumeric txtT_Thue_ra
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Thue_ra;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Thue_ra = value;
		}
	}

	internal virtual AsTextNumeric txtT_Thue_ra_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Thue_ra_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Thue_ra_nt = value;
		}
	}

	private virtual Label lblT_Thue_vao_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblT_Thue_vao_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblT_Thue_vao_nt = value;
		}
	}

	internal virtual AsTextNumeric txtT_Thue_vao
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Thue_vao;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Thue_vao = value;
		}
	}

	internal virtual AsTextNumeric txtT_Thue_vao_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Thue_vao_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Thue_vao_nt = value;
		}
	}

	internal virtual ctlTaOut ctlTaOut
	{
		[DebuggerNonUserCode]
		get
		{
			return _ctlTaOut;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			ctlTaOut.TAOUTValueChangedEventHandler obj = CtlTaOut_TAOUTValueChanged;
			if (_ctlTaOut != null)
			{
				_ctlTaOut.TAOUTValueChanged -= obj;
			}
			_ctlTaOut = value;
			if (_ctlTaOut != null)
			{
				_ctlTaOut.TAOUTValueChanged += obj;
			}
		}
	}

	internal virtual AsTextNumeric txtT_tien_Nt_No
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tien_Nt_No;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tien_Nt_No = value;
		}
	}

	internal virtual AsTextNumeric txtT_Tien_No
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Tien_No;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Tien_No = value;
		}
	}

	internal virtual AsTextNumeric txtT_tt_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tt_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tt_nt = value;
		}
	}

	internal virtual AsTextNumeric txtT_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tt = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcTk
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

	internal virtual DataGridViewTextBoxColumn dgvcTen_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_tk = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_kh
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

	internal virtual DataGridViewTextBoxColumn dgvcTen_kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_kh = value;
		}
	}

	internal virtual DataGridViewComboBoxColumn dgvcMa_nt
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

	internal virtual DataGridViewAsTextNumericColumn dgvcTy_gia
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

	internal virtual DataGridViewAsTextNumericColumn dgvcPs_no_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPs_no_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPs_no_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcPs_co_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPs_co_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPs_co_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcPs_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPs_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPs_no = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcPs_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPs_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPs_co = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_bp
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_bp = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_phi = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_hd
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_hd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_hd = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_spct = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcNh_dk
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcNh_dk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcNh_dk = value;
		}
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

	public frmGlVchGL1(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_sPs_no_header = "";
		f_sPs_co_header = "";
		InitializeComponent();
	}

	public frmGlVchGL1(string MenuID, string Stt_rec)
		: base(MenuID, Stt_rec)
	{
		__ENCAddToList(this);
		f_sPs_no_header = "";
		f_sPs_co_header = "";
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected O, but got Unknown
		//IL_1553: Unknown result type (might be due to invalid IL or missing references)
		//IL_155d: Expected O, but got Unknown
		//IL_164e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1658: Expected O, but got Unknown
		//IL_17fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1998: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e19: Expected O, but got Unknown
		//IL_1f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f14: Expected O, but got Unknown
		//IL_208c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2096: Expected O, but got Unknown
		//IL_2187: Unknown result type (might be due to invalid IL or missing references)
		//IL_2191: Expected O, but got Unknown
		//IL_2282: Unknown result type (might be due to invalid IL or missing references)
		//IL_228c: Expected O, but got Unknown
		//IL_237d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2387: Expected O, but got Unknown
		//IL_2478: Unknown result type (might be due to invalid IL or missing references)
		//IL_2482: Expected O, but got Unknown
		//IL_2580: Unknown result type (might be due to invalid IL or missing references)
		//IL_258a: Expected O, but got Unknown
		components = new Container();
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
		adgvDetail = new AsInputDGV();
		dgvcTk = new DataGridViewAsTextBoxColumn();
		dgvcTen_tk = new DataGridViewTextBoxColumn();
		dgvcMa_kh = new DataGridViewAsTextBoxColumn();
		dgvcTen_kh = new DataGridViewTextBoxColumn();
		dgvcMa_nt = new DataGridViewComboBoxColumn();
		DMNTInformationBindingSource = new BindingSource(components);
		dgvcTy_gia = new DataGridViewAsTextNumericColumn();
		dgvcPs_no_nt = new DataGridViewAsTextNumericColumn();
		dgvcPs_co_nt = new DataGridViewAsTextNumericColumn();
		dgvcPs_no = new DataGridViewAsTextNumericColumn();
		dgvcPs_co = new DataGridViewAsTextNumericColumn();
		dgvcDien_giai = new DataGridViewTextBoxColumn();
		dgvcMa_bp = new DataGridViewAsTextBoxColumn();
		dgvcMa_phi = new DataGridViewAsTextBoxColumn();
		dgvcMa_hd = new DataGridViewAsTextBoxColumn();
		dgvcMa_spct = new DataGridViewAsTextBoxColumn();
		dgvcNh_dk = new DataGridViewTextBoxColumn();
		lblNgay_Lct = new Label();
		txtNgay_lct = new AsMaskedTextBox();
		txtT_Tien_Co = new AsTextNumeric();
		txtT_tien_Nt_Co = new AsTextNumeric();
		lblT_Tien_Nt = new Label();
		tabTaIn = new TabPage();
		ctlTaIn = new ctlTaIn();
		tabTaOut = new TabPage();
		ctlTaOut = new ctlTaOut();
		AsCheckBox2 = new AsCheckBox();
		cboMa_NT = new AsComboBoxNT();
		txtTy_gia = new AsTextNumeric();
		chkNt_Ph = new AsCheckBox();
		lblT_Thue_vao_nt = new Label();
		txtT_Thue_vao = new AsTextNumeric();
		txtT_Thue_vao_nt = new AsTextNumeric();
		lblT_Tt = new Label();
		txtT_Thue_ra = new AsTextNumeric();
		txtT_Thue_ra_nt = new AsTextNumeric();
		txtT_tien_Nt_No = new AsTextNumeric();
		txtT_Tien_No = new AsTextNumeric();
		txtT_tt_nt = new AsTextNumeric();
		txtT_tt = new AsTextNumeric();
		((Control)gbPH).SuspendLayout();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)AsTabControl).SuspendLayout();
		((Control)tabDetail).SuspendLayout();
		((ISupportInitialize)bsPH).BeginInit();
		((ISupportInitialize)bsCT).BeginInit();
		((ISupportInitialize)bsCP).BeginInit();
		((ISupportInitialize)bsTain).BeginInit();
		((ISupportInitialize)bsTaout).BeginInit();
		((ISupportInitialize)adgvDetail).BeginInit();
		((ISupportInitialize)DMNTInformationBindingSource).BeginInit();
		((Control)tabTaIn).SuspendLayout();
		((Control)tabTaOut).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdAdd;
		Point location = new Point(9, 448);
		((Control)obj).Location = location;
		Button obj2 = cmdPrint;
		location = new Point(79, 448);
		((Control)obj2).Location = location;
		Button obj3 = cmdLast;
		location = new Point(693, 448);
		((Control)obj3).Location = location;
		Button obj4 = cmdNext;
		location = new Point(670, 448);
		((Control)obj4).Location = location;
		Button obj5 = cmdPrevious;
		location = new Point(647, 448);
		((Control)obj5).Location = location;
		Button obj6 = cmdFirst;
		location = new Point(624, 448);
		((Control)obj6).Location = location;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)5;
		Label obj7 = lblSo_Ct;
		location = new Point(6, 42);
		((Control)obj7).Location = location;
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)5;
		Label obj8 = lblNgay_Ct;
		location = new Point(6, 16);
		((Control)obj8).Location = location;
		((Control)txtNgay_Ct).Anchor = (AnchorStyles)7;
		AsMaskedTextBox asMaskedTextBox = txtNgay_Ct;
		location = new Point(129, 13);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_Ct).ReadOnly = true;
		((Control)txtNgay_Ct).TabIndex = 5;
		((Control)gbPH).BackColor = Color.Transparent;
		((Control)gbPH).Controls.Add((Control)(object)chkNt_Ph);
		((Control)gbPH).Controls.Add((Control)(object)txtTy_gia);
		((Control)gbPH).Controls.Add((Control)(object)lblNgay_Lct);
		((Control)gbPH).Controls.Add((Control)(object)cboMa_NT);
		((Control)gbPH).Controls.Add((Control)(object)txtNgay_lct);
		GroupBox obj9 = gbPH;
		Size size = new Size(707, 124);
		((Control)obj9).Size = size;
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)cboMa_NT, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Lct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtTy_gia, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)chkNt_Ph, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)txtNgay_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblSo_Ct, 0);
		((Control)gbPH).Controls.SetChildIndex((Control)(object)lblNgay_Ct, 0);
		SplitButton splitButton = cmdSearch;
		location = new Point(542, 448);
		((Control)splitButton).Location = location;
		((Control)AsTabControl).Controls.Add((Control)(object)tabTaIn);
		((Control)AsTabControl).Controls.Add((Control)(object)tabTaOut);
		AsTabControl asTabControl = AsTabControl;
		location = new Point(6, 129);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(714, 239);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabOptFields, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabTaOut, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabTaIn, 0);
		((Control)AsTabControl).Controls.SetChildIndex((Control)(object)tabDetail, 0);
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj10 = tabDetail;
		size = new Size(706, 210);
		((Control)obj10).Size = size;
		TabPage obj11 = tabOptFields;
		size = new Size(706, 210);
		((Control)obj11).Size = size;
		Button obj12 = cmdCopy;
		location = new Point(289, 448);
		((Control)obj12).Location = location;
		Button obj13 = cmdDelete;
		location = new Point(219, 448);
		((Control)obj13).Location = location;
		Button obj14 = cmdEdit;
		location = new Point(149, 448);
		((Control)obj14).Location = location;
		((Control)txtSo_Ct).Anchor = (AnchorStyles)7;
		TextBox obj15 = txtSo_Ct;
		location = new Point(129, 39);
		((Control)obj15).Location = location;
		((TextBoxBase)txtSo_Ct).ReadOnly = true;
		((Control)txtSo_Ct).TabIndex = 6;
		((DataGridView)adgvDetail).AllowUserToAddRows = false;
		((DataGridView)adgvDetail).AllowUserToDeleteRows = false;
		((DataGridView)adgvDetail).BackgroundColor = SystemColors.Window;
		((DataGridView)adgvDetail).BorderStyle = (BorderStyle)2;
		((DataGridView)adgvDetail).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)adgvDetail).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[16]
		{
			dgvcTk,
			(DataGridViewColumn)dgvcTen_tk,
			dgvcMa_kh,
			(DataGridViewColumn)dgvcTen_kh,
			(DataGridViewColumn)dgvcMa_nt,
			dgvcTy_gia,
			dgvcPs_no_nt,
			dgvcPs_co_nt,
			dgvcPs_no,
			dgvcPs_co,
			(DataGridViewColumn)dgvcDien_giai,
			dgvcMa_bp,
			dgvcMa_phi,
			dgvcMa_hd,
			dgvcMa_spct,
			(DataGridViewColumn)dgvcNh_dk
		});
		((Control)adgvDetail).Dock = (DockStyle)5;
		((DataGridView)adgvDetail).GridColor = SystemColors.Control;
		adgvDetail.IgnoreReadonlyCell = true;
		AsInputDGV asInputDGV = adgvDetail;
		location = new Point(3, 3);
		((Control)asInputDGV).Location = location;
		((Control)adgvDetail).Name = "adgvDetail";
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)adgvDetail).RowHeadersDefaultCellStyle = val;
		((DataGridView)adgvDetail).RowTemplate.Height = 20;
		((DataGridView)adgvDetail).ShowEditingIcon = false;
		((DataGridView)adgvDetail).ShowRowErrors = false;
		AsInputDGV asInputDGV2 = adgvDetail;
		size = new Size(700, 204);
		((Control)asInputDGV2).Size = size;
		((Control)adgvDetail).TabIndex = 1;
		dgvcTk.AutoFill = true;
		dgvcTk.AutoLookup = true;
		dgvcTk.AutoValid = true;
		((DataGridViewColumn)dgvcTk).DataPropertyName = "tk";
		val2.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcTk).DefaultCellStyle = val2;
		((DataGridViewColumn)dgvcTk).HeaderText = "TK";
		dgvcTk.LookupCodeName = "TK";
		dgvcTk.LookupWhereCondition = "chi_tiet=1";
		((DataGridViewColumn)dgvcTk).Name = "dgvcTk";
		dgvcTk.ReceiverValidFieldList = "ten_tk,tk_cn";
		dgvcTk.SD = true;
		dgvcTk.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk.ValidReturnFieldList = "ten_tk,tk_cn";
		((DataGridViewColumn)dgvcTk).Width = 70;
		((DataGridViewColumn)dgvcTen_tk).DataPropertyName = "ten_tk";
		((DataGridViewColumn)dgvcTen_tk).HeaderText = "Tên tài khoản";
		((DataGridViewColumn)dgvcTen_tk).Name = "dgvcTen_tk";
		dgvcTen_tk.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTen_tk).Visible = false;
		((DataGridViewColumn)dgvcTen_tk).Width = 150;
		dgvcMa_kh.AutoFill = true;
		dgvcMa_kh.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_kh).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_kh.AutoValid = true;
		((DataGridViewColumn)dgvcMa_kh).DataPropertyName = "ma_kh";
		val3.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_kh).DefaultCellStyle = val3;
		((DataGridViewColumn)dgvcMa_kh).HeaderText = "Mã KH";
		dgvcMa_kh.LookupCodeName = "MA_KH";
		dgvcMa_kh.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_kh).Name = "dgvcMa_kh";
		dgvcMa_kh.ReceiverValidFieldList = "ten_kh";
		dgvcMa_kh.SD = true;
		dgvcMa_kh.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_kh.ValidReturnFieldList = "ten_kh";
		((DataGridViewColumn)dgvcMa_kh).Width = 46;
		((DataGridViewColumn)dgvcTen_kh).DataPropertyName = "ten_kh";
		((DataGridViewColumn)dgvcTen_kh).HeaderText = "Tên khách";
		((DataGridViewColumn)dgvcTen_kh).Name = "dgvcTen_kh";
		((DataGridViewColumn)dgvcTen_kh).Width = 180;
		((DataGridViewColumn)dgvcMa_nt).DataPropertyName = "ma_nt";
		dgvcMa_nt.DataSource = DMNTInformationBindingSource;
		dgvcMa_nt.DisplayMember = "ma_nt";
		dgvcMa_nt.DisplayStyleForCurrentCellOnly = true;
		((DataGridViewColumn)dgvcMa_nt).HeaderText = "N.tệ";
		dgvcMa_nt.MaxDropDownItems = 10;
		((DataGridViewColumn)dgvcMa_nt).Name = "dgvcMa_nt";
		((DataGridViewColumn)dgvcMa_nt).ToolTipText = "Mã ngoại tệ";
		dgvcMa_nt.ValueMember = "ma_nt";
		((DataGridViewColumn)dgvcMa_nt).Width = 55;
		DMNTInformationBindingSource.DataSource = typeof(DMNTInformation);
		((DataGridViewColumn)dgvcTy_gia).DataPropertyName = "ty_gia";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "### ###.##";
		((DataGridViewColumn)dgvcTy_gia).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcTy_gia).HeaderText = "Tỷ giá";
		dgvcTy_gia.Mask = "### ###.##";
		((DataGridViewColumn)dgvcTy_gia).Name = "dgvcTy_gia";
		dgvcTy_gia.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTy_gia).Width = 50;
		((DataGridViewColumn)dgvcPs_no_nt).DataPropertyName = "ps_no_nt";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_no_nt).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcPs_no_nt).HeaderText = "Ps nợ";
		dgvcPs_no_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_no_nt).Name = "dgvcPs_no_nt";
		dgvcPs_no_nt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcPs_co_nt).DataPropertyName = "ps_co_nt";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_co_nt).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcPs_co_nt).HeaderText = "Ps có";
		dgvcPs_co_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_co_nt).Name = "dgvcPs_co_nt";
		dgvcPs_co_nt.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcPs_no).DataPropertyName = "ps_no";
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcPs_no).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcPs_no).HeaderText = "Ps nợ VND";
		dgvcPs_no.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcPs_no).Name = "dgvcPs_no";
		((DataGridViewColumn)dgvcPs_no).Resizable = (DataGridViewTriState)1;
		dgvcPs_no.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcPs_co).DataPropertyName = "ps_co";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcPs_co).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcPs_co).HeaderText = "Ps có VND";
		dgvcPs_co.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcPs_co).Name = "dgvcPs_co";
		dgvcPs_co.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcDien_giai).DataPropertyName = "dien_giai";
		((DataGridViewColumn)dgvcDien_giai).HeaderText = "Diễn giải";
		dgvcDien_giai.MaxInputLength = 128;
		((DataGridViewColumn)dgvcDien_giai).Name = "dgvcDien_giai";
		((DataGridViewColumn)dgvcDien_giai).Resizable = (DataGridViewTriState)1;
		dgvcDien_giai.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcDien_giai).Width = 150;
		dgvcMa_bp.AutoFill = true;
		dgvcMa_bp.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_bp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_bp.AutoValid = true;
		((DataGridViewColumn)dgvcMa_bp).DataPropertyName = "ma_bp";
		val9.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_bp).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcMa_bp).HeaderText = "B. phận";
		dgvcMa_bp.LookupCodeName = "MA_BP";
		dgvcMa_bp.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_bp).Name = "dgvcMa_bp";
		dgvcMa_bp.ReceiverValidFieldList = "ten_bp";
		dgvcMa_bp.SD = true;
		dgvcMa_bp.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_bp.ValidReturnFieldList = "ten_bp";
		((DataGridViewColumn)dgvcMa_bp).Width = 50;
		dgvcMa_phi.AutoFill = true;
		dgvcMa_phi.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_phi).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_phi.AutoValid = true;
		((DataGridViewColumn)dgvcMa_phi).DataPropertyName = "ma_phi";
		val10.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_phi).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcMa_phi).HeaderText = "Phí";
		dgvcMa_phi.LookupCodeName = "MA_PHI";
		dgvcMa_phi.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_phi).Name = "dgvcMa_phi";
		dgvcMa_phi.ReceiverValidFieldList = "ten_phi";
		dgvcMa_phi.SD = true;
		dgvcMa_phi.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_phi.ValidReturnFieldList = "ten_phi";
		((DataGridViewColumn)dgvcMa_phi).Width = 30;
		dgvcMa_hd.AutoFill = true;
		dgvcMa_hd.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_hd).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_hd.AutoValid = true;
		((DataGridViewColumn)dgvcMa_hd).DataPropertyName = "ma_hd";
		val11.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_hd).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcMa_hd).HeaderText = "H. đồng";
		dgvcMa_hd.LookupCodeName = "MA_HD";
		dgvcMa_hd.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_hd).Name = "dgvcMa_hd";
		dgvcMa_hd.ReceiverValidFieldList = "ten_hd";
		dgvcMa_hd.SD = true;
		dgvcMa_hd.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_hd.ValidReturnFieldList = "ten_hd";
		((DataGridViewColumn)dgvcMa_hd).Width = 52;
		dgvcMa_spct.AutoFill = true;
		dgvcMa_spct.AutoLookup = true;
		((DataGridViewColumn)dgvcMa_spct).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		dgvcMa_spct.AutoValid = true;
		((DataGridViewColumn)dgvcMa_spct).DataPropertyName = "ma_spct";
		val12.BackColor = SystemColors.Info;
		((DataGridViewColumn)dgvcMa_spct).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcMa_spct).HeaderText = "SPCT";
		dgvcMa_spct.LookupCodeName = "MA_SPCT";
		dgvcMa_spct.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_spct).Name = "dgvcMa_spct";
		dgvcMa_spct.ReceiverValidFieldList = "ten_spct";
		dgvcMa_spct.SD = true;
		dgvcMa_spct.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_spct.ValidReturnFieldList = "ten_spct";
		((DataGridViewColumn)dgvcMa_spct).Width = 41;
		((DataGridViewColumn)dgvcNh_dk).DataPropertyName = "nh_dk";
		((DataGridViewColumn)dgvcNh_dk).HeaderText = "ĐK";
		((DataGridViewColumn)dgvcNh_dk).Name = "dgvcNh_dk";
		((DataGridViewColumn)dgvcNh_dk).ToolTipText = "Nhóm định khoản";
		((DataGridViewColumn)dgvcNh_dk).Width = 40;
		lblNgay_Lct.ImeMode = (ImeMode)0;
		Label obj16 = lblNgay_Lct;
		location = new Point(6, 67);
		((Control)obj16).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj17 = lblNgay_Lct;
		size = new Size(117, 15);
		((Control)obj17).Size = size;
		((Control)lblNgay_Lct).TabIndex = 115;
		lblNgay_Lct.Text = "Ngày lập";
		((Control)txtNgay_lct).Anchor = (AnchorStyles)7;
		txtNgay_lct.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_lct).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_lct;
		location = new Point(129, 65);
		((Control)asMaskedTextBox2).Location = location;
		((MaskedTextBox)txtNgay_lct).Mask = "##/##/####";
		((Control)txtNgay_lct).Name = "txtNgay_lct";
		((MaskedTextBox)txtNgay_lct).PromptChar = ' ';
		((MaskedTextBox)txtNgay_lct).ReadOnly = true;
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_lct;
		size = new Size(78, 20);
		((Control)asMaskedTextBox3).Size = size;
		((Control)txtNgay_lct).TabIndex = 7;
		((MaskedTextBox)txtNgay_lct).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox4 = txtNgay_lct;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox4.Value = dateTime;
		((Control)txtT_Tien_Co).Anchor = (AnchorStyles)2;
		txtT_Tien_Co.DecimalSymbol = ".";
		((Control)txtT_Tien_Co).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric = txtT_Tien_Co;
		location = new Point(544, 369);
		((Control)asTextNumeric).Location = location;
		txtT_Tien_Co.Mask = "### ### ### ###";
		((Control)txtT_Tien_Co).Name = "txtT_Tien_Co";
		((TextBoxBase)txtT_Tien_Co).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtT_Tien_Co;
		size = new Size(95, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtT_Tien_Co).TabIndex = 223;
		((Control)txtT_Tien_Co).TabStop = false;
		((TextBox)txtT_Tien_Co).Text = "0";
		((TextBox)txtT_Tien_Co).TextAlign = (HorizontalAlignment)1;
		txtT_Tien_Co.Value = 0.0;
		((Control)txtT_tien_Nt_Co).Anchor = (AnchorStyles)2;
		txtT_tien_Nt_Co.DecimalSymbol = ".";
		((Control)txtT_tien_Nt_Co).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtT_tien_Nt_Co;
		location = new Point(338, 369);
		((Control)asTextNumeric3).Location = location;
		txtT_tien_Nt_Co.Mask = "### ### ### ###.##";
		((Control)txtT_tien_Nt_Co).Name = "txtT_tien_Nt_Co";
		((TextBoxBase)txtT_tien_Nt_Co).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtT_tien_Nt_Co;
		size = new Size(95, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtT_tien_Nt_Co).TabIndex = 10;
		((Control)txtT_tien_Nt_Co).TabStop = false;
		((TextBox)txtT_tien_Nt_Co).Text = "0.00";
		((TextBox)txtT_tien_Nt_Co).TextAlign = (HorizontalAlignment)1;
		txtT_tien_Nt_Co.Value = 0.0;
		((Control)lblT_Tien_Nt).Anchor = (AnchorStyles)6;
		lblT_Tien_Nt.ImeMode = (ImeMode)0;
		Label obj18 = lblT_Tien_Nt;
		location = new Point(157, 372);
		((Control)obj18).Location = location;
		((Control)lblT_Tien_Nt).Name = "lblT_Tien_Nt";
		Label obj19 = lblT_Tien_Nt;
		size = new Size(74, 13);
		((Control)obj19).Size = size;
		((Control)lblT_Tien_Nt).TabIndex = 227;
		lblT_Tien_Nt.Text = "Phát sinh N/C";
		tabTaIn.BackColor = SystemColors.Control;
		((Control)tabTaIn).Controls.Add((Control)(object)ctlTaIn);
		TabPage obj20 = tabTaIn;
		location = new Point(4, 25);
		obj20.Location = location;
		((Control)tabTaIn).Name = "tabTaIn";
		TabPage obj21 = tabTaIn;
		Padding val13 = default(Padding);
		((Padding)(ref val13))._002Ector(3);
		((Control)obj21).Padding = val13;
		TabPage obj22 = tabTaIn;
		size = new Size(687, 221);
		((Control)obj22).Size = size;
		tabTaIn.TabIndex = 1;
		tabTaIn.Text = "Thuế &vào";
		ctlTaIn.DataSource = bsTain;
		((Control)ctlTaIn).Dock = (DockStyle)5;
		ctlTaIn.HasThueNK = false;
		ctlTaIn.HasThueTTDB = false;
		ctlTaIn obj23 = ctlTaIn;
		location = new Point(3, 3);
		((Control)obj23).Location = location;
		ctlTaIn.MA_NT_Visiable = true;
		ctlTaIn obj24 = ctlTaIn;
		((Padding)(ref val13))._002Ector(0);
		((Control)obj24).Margin = val13;
		((Control)ctlTaIn).Name = "ctlTaIn";
		ctlTaIn.PHDataSource = bsPH;
		ctlTaIn obj25 = ctlTaIn;
		size = new Size(681, 215);
		((Control)obj25).Size = size;
		((Control)ctlTaIn).TabIndex = 0;
		ctlTaIn.TAINTable = null;
		ctlTaIn.Tk_Du = "";
		ctlTaIn.Tk_Thue = "";
		tabTaOut.BackColor = SystemColors.Control;
		((Control)tabTaOut).Controls.Add((Control)(object)ctlTaOut);
		TabPage obj26 = tabTaOut;
		location = new Point(4, 25);
		obj26.Location = location;
		((Control)tabTaOut).Name = "tabTaOut";
		TabPage obj27 = tabTaOut;
		((Padding)(ref val13))._002Ector(3);
		((Control)obj27).Padding = val13;
		TabPage obj28 = tabTaOut;
		size = new Size(687, 221);
		((Control)obj28).Size = size;
		tabTaOut.TabIndex = 2;
		tabTaOut.Text = "Thuế &ra";
		ctlTaOut.DataSource = null;
		((Control)ctlTaOut).Dock = (DockStyle)5;
		ctlTaOut obj29 = ctlTaOut;
		location = new Point(3, 3);
		((Control)obj29).Location = location;
		ctlTaOut.MA_NT_Visiable = true;
		ctlTaOut obj30 = ctlTaOut;
		((Padding)(ref val13))._002Ector(0);
		((Control)obj30).Margin = val13;
		((Control)ctlTaOut).Name = "ctlTaOut";
		ctlTaOut.PHDataSource = bsPH;
		ctlTaOut obj31 = ctlTaOut;
		size = new Size(681, 215);
		((Control)obj31).Size = size;
		((Control)ctlTaOut).TabIndex = 1;
		ctlTaOut.TAOUTTable = null;
		((ButtonBase)AsCheckBox2).AutoSize = true;
		AsCheckBox2.Checked = false;
		AsCheckBox asCheckBox = AsCheckBox2;
		location = new Point(141, 3);
		((Control)asCheckBox).Location = location;
		((Control)AsCheckBox2).Name = "AsCheckBox2";
		AsCheckBox asCheckBox2 = AsCheckBox2;
		size = new Size(143, 17);
		((Control)asCheckBox2).Size = size;
		((Control)AsCheckBox2).TabIndex = 0;
		((ButtonBase)AsCheckBox2).Text = "Chỉ kê, không hạch toán";
		AsCheckBox2.TextValue = "0";
		((ButtonBase)AsCheckBox2).UseVisualStyleBackColor = true;
		((Control)cboMa_NT).Anchor = (AnchorStyles)7;
		((ComboBox)cboMa_NT).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboMa_NT).Enabled = false;
		((ListControl)cboMa_NT).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_NT;
		location = new Point(129, 91);
		((Control)asComboBoxNT).Location = location;
		cboMa_NT.MA_NT = "";
		((Control)cboMa_NT).Name = "cboMa_NT";
		AsComboBoxNT asComboBoxNT2 = cboMa_NT;
		size = new Size(47, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_NT).TabIndex = 227;
		((Control)txtTy_gia).Anchor = (AnchorStyles)7;
		txtTy_gia.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric5 = txtTy_gia;
		location = new Point(179, 91);
		((Control)asTextNumeric5).Location = location;
		txtTy_gia.Mask = "### ###.##";
		((Control)txtTy_gia).Name = "txtTy_gia";
		((TextBoxBase)txtTy_gia).ReadOnly = true;
		AsTextNumeric asTextNumeric6 = txtTy_gia;
		size = new Size(60, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtTy_gia).TabIndex = 228;
		((TextBox)txtTy_gia).Text = "0.00";
		((TextBox)txtTy_gia).TextAlign = (HorizontalAlignment)1;
		txtTy_gia.Value = 0.0;
		((Control)chkNt_Ph).Anchor = (AnchorStyles)7;
		((ButtonBase)chkNt_Ph).AutoSize = true;
		chkNt_Ph.Checked = true;
		((CheckBox)chkNt_Ph).CheckState = (CheckState)1;
		AsCheckBox asCheckBox3 = chkNt_Ph;
		location = new Point(9, 93);
		((Control)asCheckBox3).Location = location;
		((Control)chkNt_Ph).Name = "chkNt_Ph";
		AsCheckBox asCheckBox4 = chkNt_Ph;
		size = new Size(99, 17);
		((Control)asCheckBox4).Size = size;
		((Control)chkNt_Ph).TabIndex = 2;
		((Control)chkNt_Ph).TabStop = false;
		((ButtonBase)chkNt_Ph).Text = "&Ngoại tệ chung";
		((ButtonBase)chkNt_Ph).UseVisualStyleBackColor = true;
		((Control)lblT_Thue_vao_nt).Anchor = (AnchorStyles)6;
		lblT_Thue_vao_nt.ImeMode = (ImeMode)0;
		Label obj32 = lblT_Thue_vao_nt;
		location = new Point(157, 398);
		((Control)obj32).Location = location;
		((Control)lblT_Thue_vao_nt).Name = "lblT_Thue_vao_nt";
		Label obj33 = lblT_Thue_vao_nt;
		size = new Size(74, 13);
		((Control)obj33).Size = size;
		((Control)lblT_Thue_vao_nt).TabIndex = 232;
		lblT_Thue_vao_nt.Text = "VAT vào/ra";
		((Control)txtT_Thue_vao).Anchor = (AnchorStyles)2;
		txtT_Thue_vao.DecimalSymbol = ".";
		((Control)txtT_Thue_vao).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric7 = txtT_Thue_vao;
		location = new Point(443, 395);
		((Control)asTextNumeric7).Location = location;
		txtT_Thue_vao.Mask = "### ### ### ###";
		((Control)txtT_Thue_vao).Name = "txtT_Thue_vao";
		((TextBoxBase)txtT_Thue_vao).ReadOnly = true;
		AsTextNumeric asTextNumeric8 = txtT_Thue_vao;
		size = new Size(95, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtT_Thue_vao).TabIndex = 231;
		((Control)txtT_Thue_vao).TabStop = false;
		((TextBox)txtT_Thue_vao).Text = "0";
		((TextBox)txtT_Thue_vao).TextAlign = (HorizontalAlignment)1;
		txtT_Thue_vao.Value = 0.0;
		((Control)txtT_Thue_vao_nt).Anchor = (AnchorStyles)2;
		txtT_Thue_vao_nt.DecimalSymbol = ".";
		((Control)txtT_Thue_vao_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric9 = txtT_Thue_vao_nt;
		location = new Point(237, 395);
		((Control)asTextNumeric9).Location = location;
		txtT_Thue_vao_nt.Mask = "### ### ### ###.##";
		((Control)txtT_Thue_vao_nt).Name = "txtT_Thue_vao_nt";
		((TextBoxBase)txtT_Thue_vao_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric10 = txtT_Thue_vao_nt;
		size = new Size(95, 20);
		((Control)asTextNumeric10).Size = size;
		((Control)txtT_Thue_vao_nt).TabIndex = 229;
		((Control)txtT_Thue_vao_nt).TabStop = false;
		((TextBox)txtT_Thue_vao_nt).Text = "0.00";
		((TextBox)txtT_Thue_vao_nt).TextAlign = (HorizontalAlignment)1;
		txtT_Thue_vao_nt.Value = 0.0;
		((Control)lblT_Tt).Anchor = (AnchorStyles)6;
		lblT_Tt.ImeMode = (ImeMode)0;
		Label obj34 = lblT_Tt;
		location = new Point(157, 424);
		((Control)obj34).Location = location;
		((Control)lblT_Tt).Name = "lblT_Tt";
		Label obj35 = lblT_Tt;
		size = new Size(74, 13);
		((Control)obj35).Size = size;
		((Control)lblT_Tt).TabIndex = 236;
		lblT_Tt.Text = "Tổng";
		((Control)txtT_Thue_ra).Anchor = (AnchorStyles)2;
		txtT_Thue_ra.DecimalSymbol = ".";
		((Control)txtT_Thue_ra).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric11 = txtT_Thue_ra;
		location = new Point(544, 395);
		((Control)asTextNumeric11).Location = location;
		txtT_Thue_ra.Mask = "### ### ### ###";
		((Control)txtT_Thue_ra).Name = "txtT_Thue_ra";
		((TextBoxBase)txtT_Thue_ra).ReadOnly = true;
		AsTextNumeric asTextNumeric12 = txtT_Thue_ra;
		size = new Size(95, 20);
		((Control)asTextNumeric12).Size = size;
		((Control)txtT_Thue_ra).TabIndex = 235;
		((Control)txtT_Thue_ra).TabStop = false;
		((TextBox)txtT_Thue_ra).Text = "0";
		((TextBox)txtT_Thue_ra).TextAlign = (HorizontalAlignment)1;
		txtT_Thue_ra.Value = 0.0;
		((Control)txtT_Thue_ra_nt).Anchor = (AnchorStyles)2;
		txtT_Thue_ra_nt.DecimalSymbol = ".";
		((Control)txtT_Thue_ra_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric13 = txtT_Thue_ra_nt;
		location = new Point(338, 395);
		((Control)asTextNumeric13).Location = location;
		txtT_Thue_ra_nt.Mask = "### ### ### ###.##";
		((Control)txtT_Thue_ra_nt).Name = "txtT_Thue_ra_nt";
		((TextBoxBase)txtT_Thue_ra_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric14 = txtT_Thue_ra_nt;
		size = new Size(95, 20);
		((Control)asTextNumeric14).Size = size;
		((Control)txtT_Thue_ra_nt).TabIndex = 233;
		((Control)txtT_Thue_ra_nt).TabStop = false;
		((TextBox)txtT_Thue_ra_nt).Text = "0.00";
		((TextBox)txtT_Thue_ra_nt).TextAlign = (HorizontalAlignment)1;
		txtT_Thue_ra_nt.Value = 0.0;
		((Control)txtT_tien_Nt_No).Anchor = (AnchorStyles)2;
		txtT_tien_Nt_No.DecimalSymbol = ".";
		((Control)txtT_tien_Nt_No).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric15 = txtT_tien_Nt_No;
		location = new Point(237, 369);
		((Control)asTextNumeric15).Location = location;
		txtT_tien_Nt_No.Mask = "### ### ### ###.##";
		((Control)txtT_tien_Nt_No).Name = "txtT_tien_Nt_No";
		((TextBoxBase)txtT_tien_Nt_No).ReadOnly = true;
		AsTextNumeric asTextNumeric16 = txtT_tien_Nt_No;
		size = new Size(95, 20);
		((Control)asTextNumeric16).Size = size;
		((Control)txtT_tien_Nt_No).TabIndex = 237;
		((Control)txtT_tien_Nt_No).TabStop = false;
		((TextBox)txtT_tien_Nt_No).Text = "0.00";
		((TextBox)txtT_tien_Nt_No).TextAlign = (HorizontalAlignment)1;
		txtT_tien_Nt_No.Value = 0.0;
		((Control)txtT_Tien_No).Anchor = (AnchorStyles)2;
		txtT_Tien_No.DecimalSymbol = ".";
		((Control)txtT_Tien_No).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric17 = txtT_Tien_No;
		location = new Point(443, 369);
		((Control)asTextNumeric17).Location = location;
		txtT_Tien_No.Mask = "### ### ### ###";
		((Control)txtT_Tien_No).Name = "txtT_Tien_No";
		((TextBoxBase)txtT_Tien_No).ReadOnly = true;
		AsTextNumeric asTextNumeric18 = txtT_Tien_No;
		size = new Size(95, 20);
		((Control)asTextNumeric18).Size = size;
		((Control)txtT_Tien_No).TabIndex = 238;
		((Control)txtT_Tien_No).TabStop = false;
		((TextBox)txtT_Tien_No).Text = "0";
		((TextBox)txtT_Tien_No).TextAlign = (HorizontalAlignment)1;
		txtT_Tien_No.Value = 0.0;
		((Control)txtT_tt_nt).Anchor = (AnchorStyles)2;
		txtT_tt_nt.DecimalSymbol = ".";
		((Control)txtT_tt_nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric19 = txtT_tt_nt;
		location = new Point(237, 421);
		((Control)asTextNumeric19).Location = location;
		txtT_tt_nt.Mask = "### ### ### ###";
		((Control)txtT_tt_nt).Name = "txtT_tt_nt";
		((TextBoxBase)txtT_tt_nt).ReadOnly = true;
		AsTextNumeric asTextNumeric20 = txtT_tt_nt;
		size = new Size(95, 20);
		((Control)asTextNumeric20).Size = size;
		txtT_tt_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tt_nt).TabIndex = 240;
		((Control)txtT_tt_nt).TabStop = false;
		((TextBox)txtT_tt_nt).Text = "0";
		((TextBox)txtT_tt_nt).TextAlign = (HorizontalAlignment)1;
		txtT_tt_nt.Value = 0.0;
		((Control)txtT_tt).Anchor = (AnchorStyles)2;
		txtT_tt.DecimalSymbol = ".";
		((Control)txtT_tt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric21 = txtT_tt;
		location = new Point(443, 421);
		((Control)asTextNumeric21).Location = location;
		txtT_tt.Mask = "### ### ### ###";
		((Control)txtT_tt).Name = "txtT_tt";
		((TextBoxBase)txtT_tt).ReadOnly = true;
		AsTextNumeric asTextNumeric22 = txtT_tt;
		size = new Size(95, 20);
		((Control)asTextNumeric22).Size = size;
		((Control)txtT_tt).TabIndex = 239;
		((Control)txtT_tt).TabStop = false;
		((TextBox)txtT_tt).Text = "0";
		((TextBox)txtT_tt).TextAlign = (HorizontalAlignment)1;
		txtT_tt.Value = 0.0;
		size = new Size(725, 498);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtT_tt_nt);
		((Control)this).Controls.Add((Control)(object)txtT_tt);
		((Control)this).Controls.Add((Control)(object)txtT_Tien_No);
		((Control)this).Controls.Add((Control)(object)txtT_tien_Nt_No);
		((Control)this).Controls.Add((Control)(object)lblT_Tt);
		((Control)this).Controls.Add((Control)(object)txtT_Thue_ra);
		((Control)this).Controls.Add((Control)(object)txtT_Thue_ra_nt);
		((Control)this).Controls.Add((Control)(object)lblT_Thue_vao_nt);
		((Control)this).Controls.Add((Control)(object)txtT_Thue_vao);
		((Control)this).Controls.Add((Control)(object)txtT_Thue_vao_nt);
		((Control)this).Controls.Add((Control)(object)txtT_Tien_Co);
		((Control)this).Controls.Add((Control)(object)txtT_tien_Nt_Co);
		((Control)this).Controls.Add((Control)(object)lblT_Tien_Nt);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmGlVchGL1";
		((Form)this).Text = "frmGL1Input";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tien_Nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tien_Nt_Co, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien_Co, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue_vao_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue_vao, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Thue_vao_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue_ra_nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Thue_ra, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tien_Nt_No, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien_No, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tt_nt, 0);
		((Control)gbPH).ResumeLayout(false);
		((Control)gbPH).PerformLayout();
		((ISupportInitialize)epNotice).EndInit();
		((Control)AsTabControl).ResumeLayout(false);
		((Control)tabDetail).ResumeLayout(false);
		((ISupportInitialize)bsPH).EndInit();
		((ISupportInitialize)bsCT).EndInit();
		((ISupportInitialize)bsCP).EndInit();
		((ISupportInitialize)bsTain).EndInit();
		((ISupportInitialize)bsTaout).EndInit();
		((ISupportInitialize)adgvDetail).EndInit();
		((ISupportInitialize)DMNTInformationBindingSource).EndInit();
		((Control)tabTaIn).ResumeLayout(false);
		((Control)tabTaOut).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void chkNt_Ph_CheckedChanged(object sender, EventArgs e)
	{
		if (IsLoading)
		{
			return;
		}
		if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			foreach (DataRowView item in CT1Voucher)
			{
				item["ma_nt"] = cboMa_NT.MA_NT;
				if (ActionMode == Commons.ApplicationMode.ADD_MODE)
				{
					V_Ma_Nt(item);
				}
			}
		}
		if (((DataGridView)adgvDetail).RowCount != 0)
		{
			RefreshDGVInput();
		}
		RefreshCtrlWhenChkNt_PhChange();
		if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			RefreshValueByMa_Nt();
		}
	}

	private void cboMa_NT_SelectedValueChanged(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		if (IsLoading)
		{
			return;
		}
		if (((int)((CheckBox)chkNt_Ph).CheckState == 1 && CT1Voucher != null) ? true : false)
		{
			if (ActionMode == Commons.ApplicationMode.ADD_MODE)
			{
				txtTy_gia.Value = Commons.Get_TyGia(cboMa_NT.MA_NT, Conversions.ToDate(txtNgay_Ct.Value));
			}
			foreach (DataRowView item in CT1Voucher)
			{
				item["ma_nt"] = cboMa_NT.MA_NT;
				if (ActionMode == Commons.ApplicationMode.ADD_MODE)
				{
					V_Ma_Nt(item);
				}
			}
		}
		ctlTaIn.Ma_Nt = cboMa_NT.MA_NT;
		ctlTaOut.Ma_Nt = cboMa_NT.MA_NT;
		RefreshDGVInput();
		if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			RefreshValueByMa_Nt();
		}
		RefreshCtrlWhenChkNt_PhChange();
	}

	private void txtTy_gia_Validated(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		if (((base.IsLoading || base.ActionMode == Commons.ApplicationMode.VIEW_MODE || IsValidateCalledFromValidData) ? true : false) || (int)((CheckBox)chkNt_Ph).CheckState != 1)
		{
			return;
		}
		foreach (DataRowView item in CT1Voucher)
		{
			item["ma_nt"] = cboMa_NT.MA_NT;
			item["ty_gia"] = RuntimeHelpers.GetObjectValue(txtTy_gia.Value);
			V_Ty_gia(item);
		}
		ctlTaIn.Ma_Nt = cboMa_NT.MA_NT;
		ctlTaIn.Ty_Gia = Conversions.ToDouble(txtTy_gia.Value);
		ctlTaOut.Ma_Nt = cboMa_NT.MA_NT;
		ctlTaOut.Ty_Gia = Conversions.ToDouble(txtTy_gia.Value);
		UpdateList();
	}

	private void adgvDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if ((CTTable != null && e.RowIndex >= 0 && !base.IsLoading) || 1 == 0)
		{
			bool flag = true;
			DataRowView oDv = CT1Voucher[e.RowIndex];
			string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_nt).Name, false) == 0)
			{
				V_Ma_Nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTy_gia).Name, false) == 0)
			{
				V_Ty_gia(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcPs_co_nt).Name, false) == 0)
			{
				V_Ps_Co_Nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcPs_no_nt).Name, false) == 0)
			{
				V_Ps_No_Nt(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcPs_no).Name, false) == 0)
			{
				V_Ps_No(oDv);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcPs_co).Name, false) == 0)
			{
				V_Ps_Co(oDv);
			}
			else
			{
				flag = false;
			}
			if (flag)
			{
				((DataGridView)adgvDetail).InvalidateRow(e.RowIndex);
			}
		}
	}

	private void adgvDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (CTTable == null || (base.IsLoading ? true : false))
		{
			return;
		}
		DataRowView dataRowView = CT1Voucher[e.RowIndex];
		DataGridViewCell currentCell = ((DataGridView)adgvDetail).CurrentCell;
		object obj = null;
		string name = ((DataGridView)adgvDetail).Columns[e.ColumnIndex].Name;
		if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTy_gia).Name, false) == 0)
		{
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				currentCell.ReadOnly = !W_Ty_gia(dataRowView);
			}
		}
		else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcPs_co).Name, false) != 0 && Operators.CompareString(name, ((DataGridViewColumn)dgvcPs_no).Name, false) != 0)
		{
			if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_bp).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Bp"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_hd).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Hd"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_phi).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Phi"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_spct).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Spct"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcTk).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_Tk"]);
			}
			else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_kh).Name, false) == 0)
			{
				obj = RuntimeHelpers.GetObjectValue(dataRowView["Ten_kh"]);
			}
		}
		obj = RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(obj), isNum: false));
		((ToolStripItem)tsslInfo).Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(obj, (object)"", false), (object)frmVoucher.BASEVOUCHER_INPUTGRID_TIP_TEXT, RuntimeHelpers.GetObjectValue(obj)));
	}

	private void ctlTaIn_TAINValueChanged(object sender, EventArgs e)
	{
		UpdateList();
	}

	private void CtlTaOut_TAOUTValueChanged(object sender, EventArgs e)
	{
		UpdateList();
	}

	private void RefreshValueByMa_Nt()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) != 0 || (int)((CheckBox)chkNt_Ph).CheckState != 1 || 1 == 0)
		{
			return;
		}
		foreach (DataRowView item in base.CT1Voucher)
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["ps_no_nt"]), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			item["ps_no_nt"] = RuntimeHelpers.GetObjectValue(obj);
			Type? typeFromHandle2 = typeof(Math);
			array3 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(item["ps_co_nt"]), isNum: true)),
				null,
				null
			};
			object[] array6 = array3;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			array = array3;
			object[] array7 = array;
			array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			item["ps_co_nt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
	}

	private void V_Ma_Nt(DataRowView oDv)
	{
		if (ActionMode == Commons.ApplicationMode.ADD_MODE)
		{
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_nt"]), isNum: false), (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false))
			{
				oDv["ty_gia"] = 1;
			}
			else
			{
				oDv["ty_gia"] = Commons.Get_TyGia(Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_nt"]), isNum: false)), Conversions.ToDate(txtNgay_Ct.Value));
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_nt"]), isNum: false), (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false))
		{
			oDv["ty_gia"] = 1;
		}
		if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_nt"]), isNum: false), (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ps_no_nt"]), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			oDv["ps_no_nt"] = RuntimeHelpers.GetObjectValue(obj);
			Type? typeFromHandle2 = typeof(Math);
			array3 = new object[3]
			{
				RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ps_co_nt"]), isNum: true)),
				null,
				null
			};
			object[] array6 = array3;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			array = array3;
			object[] array7 = array;
			array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["ps_co_nt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		V_Ty_gia(oDv);
	}

	private void V_Ty_gia(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ty_gia"]), isNum: true), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ps_co_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ty_gia"]), isNum: true)),
				null,
				null
			};
			object[] array2 = array;
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array2[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
			}
			oDv["ps_co"] = RuntimeHelpers.GetObjectValue(obj);
			Type? typeFromHandle2 = typeof(Math);
			array3 = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ps_no_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ty_gia"]), isNum: true)),
				null,
				null
			};
			object[] array6 = array3;
			sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array6[1] = sIConfiguration.Round;
			array3[2] = MidpointRounding.AwayFromZero;
			array = array3;
			object[] array7 = array;
			array5 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
			if (array5[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			oDv["ps_no"] = RuntimeHelpers.GetObjectValue(obj2);
		}
		UpdateList();
	}

	private void V_Ps_Co_Nt(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ty_gia"]), isNum: true), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ps_co_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ty_gia"]), isNum: true)),
				null,
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array2 = array;
			bool[] array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			oDv["ps_co"] = RuntimeHelpers.GetObjectValue(obj);
		}
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ps_co_nt"]), isNum: true), (object)0, false))
		{
			oDv["ps_no_nt"] = 0;
			oDv["ps_no"] = 0;
		}
		UpdateList();
	}

	private void V_Ps_No_Nt(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ty_gia"]), isNum: true), (object)0, false))
		{
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ps_no_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ty_gia"]), isNum: true)),
				null,
				null
			};
			SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
			array[1] = sIConfiguration.Round;
			array[2] = MidpointRounding.AwayFromZero;
			object[] array2 = array;
			bool[] array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			oDv["ps_no"] = RuntimeHelpers.GetObjectValue(obj);
		}
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ps_no_nt"]), isNum: true), (object)0, false))
		{
			oDv["ps_co_nt"] = 0;
			oDv["ps_co"] = 0;
		}
		UpdateList();
	}

	private void V_Ps_Co(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ps_co"]), isNum: true), (object)0, false))
		{
			oDv["ps_no"] = 0;
		}
		UpdateList();
	}

	private void V_Ps_No(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ps_no"]), isNum: true), (object)0, false))
		{
			oDv["ps_co"] = 0;
		}
		UpdateList();
	}

	private bool W_Ty_gia(DataRowView oDv)
	{
		return Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_nt"]), isNum: false), (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false);
	}

	private bool W_Ps_No(DataRowView oDv)
	{
		return Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_nt"]), isNum: false), (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false);
	}

	private bool W_Ps_Co(DataRowView oDv)
	{
		return Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_nt"]), isNum: false), (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false);
	}

	private void InvalidatedDGVCell(DataGridViewCell dgvc, int errId)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		((Control)adgvDetail).Select();
		((DataGridView)adgvDetail).CurrentCell = dgvc;
		CMessageBox.Show(errId);
	}

	private bool ChkNh_Dk(ref bool blnNN, ref bool blnLechNC, ref string strNh_Dk)
	{
		bool result;
		try
		{
			IEnumerable<VB_0024AnonymousType_2<object, decimal, decimal, decimal, decimal, int, int>> enumerable = from _0024VB_0024It in (from row in base.CTTable.AsEnumerable()
					where Operators.ConditionalCompareObjectEqual(row["Stt_Rec"], _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()["stt_rec"], false)
					select row).GroupBy([SpecialName] (DataRow row) => Helper.Repl_Null(RuntimeHelpers.GetObjectValue(row["Nh_dk"]), isNum: false), [SpecialName] (DataRow row) => row, [SpecialName] (object nhom_dk, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_1<object, IEnumerable<DataRow>, decimal, decimal, decimal, decimal, int, int>(RuntimeHelpers.GetObjectValue(nhom_dk), _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("ps_no_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("ps_co_nt") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("ps_no") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("ps_co") ?? 0m), _0024VB_0024Group.Count([SpecialName] (DataRow row) => Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(row["ps_no"]), isNum: true), (object)0, false)), _0024VB_0024Group.Count([SpecialName] (DataRow row) => Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(row["ps_co"]), isNum: true), (object)0, false))))
				select new VB_0024AnonymousType_2<object, decimal, decimal, decimal, decimal, int, int>(RuntimeHelpers.GetObjectValue(_0024VB_0024It.nhom_dk), _0024VB_0024It.ps_no, _0024VB_0024It.ps_co, _0024VB_0024It.ps_no_nt, _0024VB_0024It.ps_co_nt, _0024VB_0024It.countNo, _0024VB_0024It.countCo);
			foreach (VB_0024AnonymousType_2<object, decimal, decimal, decimal, decimal, int, int> item in enumerable)
			{
				if (decimal.Compare(item.ps_no, item.ps_co) != 0 || ((decimal.Compare(item.ps_no_nt, item.ps_co_nt) != 0) ? true : false))
				{
					blnLechNC = true;
					strNh_Dk = Conversions.ToString(item.nhom_dk);
					break;
				}
				if ((item.countNo > 1 && item.countCo > 1) ? true : false)
				{
					blnNN = true;
					strNh_Dk = Conversions.ToString(item.nhom_dk);
					break;
				}
			}
			result = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private bool ChkNh_Dk_New(ref bool blnNN, ref bool blnLechNC, ref string strNh_Dk)
	{
		bool result;
		try
		{
			IEnumerable<VB_0024AnonymousType_4<object, decimal, decimal, int, int>> enumerable = from _0024VB_0024It in (from row in base.CTTable.AsEnumerable()
					where Operators.ConditionalCompareObjectEqual(row["Stt_Rec"], _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()["stt_rec"], false)
					select row).GroupBy([SpecialName] (DataRow row) => Helper.Repl_Null(RuntimeHelpers.GetObjectValue(row["Nh_dk"]), isNum: false), [SpecialName] (DataRow row) => row, [SpecialName] (object nhom_dk, IEnumerable<DataRow> _0024VB_0024Group) => new VB_0024AnonymousType_3<object, IEnumerable<DataRow>, decimal, decimal, int, int>(RuntimeHelpers.GetObjectValue(nhom_dk), _0024VB_0024Group, _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("pn_co") ?? 0m), _0024VB_0024Group.Sum([SpecialName] (DataRow row) => row.Field<decimal?>("ps_co") ?? 0m), _0024VB_0024Group.Count([SpecialName] (DataRow row) => Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(row["ps_no"]), isNum: true), (object)0, false)), _0024VB_0024Group.Count([SpecialName] (DataRow row) => Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(row["ps_co"]), isNum: true), (object)0, false))))
				select new VB_0024AnonymousType_4<object, decimal, decimal, int, int>(RuntimeHelpers.GetObjectValue(_0024VB_0024It.nhom_dk), _0024VB_0024It.ps_no, _0024VB_0024It.ps_co, _0024VB_0024It.countNo, _0024VB_0024It.countCo);
			foreach (VB_0024AnonymousType_4<object, decimal, decimal, int, int> item in enumerable)
			{
				if (decimal.Compare(item.ps_no, item.ps_co) != 0)
				{
					blnLechNC = true;
					strNh_Dk = Conversions.ToString(item.nhom_dk);
					break;
				}
				if ((item.countNo > 1 && item.countCo > 1) ? true : false)
				{
					blnNN = true;
					strNh_Dk = Conversions.ToString(item.nhom_dk);
					break;
				}
			}
			result = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected void RefreshCtrlWhenChkNt_PhChange()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		bool flag = true;
		bool flag2 = false;
		string fCAmount_Input_Format = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
		if ((int)((CheckBox)chkNt_Ph).CheckState == 0)
		{
			((Control)cboMa_NT).Enabled = false;
			((Control)txtTy_gia).Enabled = false;
			flag2 = true;
			fCAmount_Input_Format = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			flag = false;
		}
		else
		{
			((Control)cboMa_NT).Enabled = ActionMode != Commons.ApplicationMode.VIEW_MODE;
			if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				((Control)txtTy_gia).Enabled = false;
				flag2 = false;
				fCAmount_Input_Format = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
			}
			else
			{
				((Control)txtTy_gia).Enabled = ActionMode != Commons.ApplicationMode.VIEW_MODE;
				fCAmount_Input_Format = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
				flag2 = true;
			}
		}
		((Control)txtT_Tien_Co).Visible = flag2;
		((Control)txtT_Tien_No).Visible = flag2;
		((Control)txtT_Thue_vao).Visible = flag2;
		((Control)txtT_Thue_ra).Visible = flag2;
		((Control)txtT_tt).Visible = flag2;
		txtT_tien_Nt_No.Mask = fCAmount_Input_Format;
		txtT_tien_Nt_Co.Mask = fCAmount_Input_Format;
		txtT_Thue_ra_nt.Mask = fCAmount_Input_Format;
		txtT_Thue_vao_nt.Mask = fCAmount_Input_Format;
		txtT_tt_nt.Mask = fCAmount_Input_Format;
		ctlTaIn.MA_NT_Visiable = !flag;
		ctlTaOut.MA_NT_Visiable = !flag;
	}

	protected override void SetFocus4FirstEditControl()
	{
		((Control)txtNgay_Ct).Focus();
	}

	protected override void RefreshDGVInput()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		base.RefreshDGVInput();
		if (CTTable == null)
		{
			return;
		}
		if ((int)((CheckBox)chkNt_Ph).CheckState == 1)
		{
			((DataGridViewColumn)dgvcPs_co_nt).HeaderText = f_sPs_co_header + " " + cboMa_NT.MA_NT;
			((DataGridViewColumn)dgvcPs_no_nt).HeaderText = f_sPs_no_header + " " + cboMa_NT.MA_NT;
			((DataGridViewColumn)dgvcMa_nt).Visible = false;
			((DataGridViewColumn)dgvcTy_gia).Visible = false;
			if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				((DataGridViewColumn)dgvcPs_no).Visible = false;
				((DataGridViewColumn)dgvcPs_co).Visible = false;
				((Control)txtT_tt).Visible = false;
				txtTy_gia.Value = 1;
				((Control)txtTy_gia).Enabled = false;
				if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
				{
					txtTy_gia_Validated(null, null);
				}
				dgvcPs_no_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
				dgvcPs_co_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
			}
			else
			{
				((Control)txtTy_gia).Enabled = true;
				((TextBoxBase)txtTy_gia).ReadOnly = false;
				((DataGridViewColumn)dgvcPs_no).Visible = true;
				((DataGridViewColumn)dgvcPs_co).Visible = true;
				if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
				{
					txtTy_gia.Value = Commons.Get_TyGia(cboMa_NT.MA_NT, Conversions.ToDate(txtNgay_Ct.Value));
					txtTy_gia_Validated(null, null);
				}
				dgvcPs_no_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
				dgvcPs_co_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			}
		}
		else
		{
			((DataGridViewColumn)dgvcMa_nt).Visible = true;
			((DataGridViewColumn)dgvcTy_gia).Visible = true;
			((DataGridViewColumn)dgvcPs_co_nt).HeaderText = f_sPs_co_header;
			((DataGridViewColumn)dgvcPs_no_nt).HeaderText = f_sPs_no_header;
			((DataGridViewColumn)dgvcPs_no).Visible = true;
			((DataGridViewColumn)dgvcPs_co).Visible = true;
			((Control)txtT_tt).Visible = true;
			dgvcPs_no_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			dgvcPs_co_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			ctlTaIn.Ma_Nt = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		}
	}

	protected override void UpdateList()
	{
		if (base.CurrentPHRow != null)
		{
			string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", base.CurrentPHRow["Stt_Rec"]), (object)"'"));
			txtT_tien_Nt_Co.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(ps_co_nt)", filter));
			txtT_Tien_Co.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(ps_co)", filter));
			txtT_tien_Nt_No.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(ps_no_nt)", filter));
			txtT_Tien_No.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(ps_no)", filter));
			txtT_Thue_vao_nt.Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(ctlTaIn.chkKe_tain.Checked, (object)true, false), (object)0, (object)ctlTaIn.get_T_Thue_Nt("")));
			txtT_Thue_vao.Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(ctlTaIn.chkKe_tain.Checked, (object)true, false), (object)0, (object)ctlTaIn.get_T_Thue("")));
			txtT_Thue_ra_nt.Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(ctlTaOut.chkKe_taout.Checked, (object)true, false), (object)0, (object)ctlTaOut.T_Thue_NT));
			txtT_Thue_ra.Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(ctlTaOut.chkKe_taout.Checked, (object)true, false), (object)0, (object)ctlTaOut.T_Thue));
			txtT_tt.Value = Operators.AddObject(Operators.AddObject(txtT_Tien_Co.Value, txtT_Thue_vao.Value), txtT_Thue_ra.Value);
			txtT_tt_nt.Value = Operators.AddObject(Operators.AddObject(txtT_tien_Nt_Co.Value, txtT_Thue_vao_nt.Value), txtT_Thue_ra_nt.Value);
		}
	}

	protected override bool ValidData()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		bool flag2 = false;
		checked
		{
			if ((base.ValidData() && ctlTaIn.ValidData() && ctlTaOut.ValidData()) ? true : false)
			{
				bool blnNN = false;
				bool blnLechNC = false;
				string strNh_Dk = "";
				if (ChkNh_Dk(ref blnNN, ref blnLechNC, ref strNh_Dk))
				{
					if (blnNN)
					{
						CMessageBox.ShowWithFormat(50093, new object[1] { strNh_Dk });
						return false;
					}
					if (blnLechNC)
					{
						CMessageBox.ShowWithFormat(50094, new object[1] { strNh_Dk });
						return false;
					}
					int num = CT1Voucher.Count - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						DataRowView dataRowView = CT1Voucher[num2];
						if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk"]), isNum: false), (object)"", false))
						{
							InvalidatedDGVCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcTk).Name, num2], 50018);
							return false;
						}
						if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Tk_Cn"]), isNum: false), (object)"1", false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ma_Kh"]), isNum: false), (object)"", false)) ? true : false)
						{
							InvalidatedDGVCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcMa_kh).Name, num2], 50092);
							return false;
						}
						if ((Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ty_gia"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_co"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_no"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_co_nt"]), isNum: true), (object)0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_no_nt"]), isNum: true), (object)0, false)) ? true : false)
						{
							InvalidatedDGVCell(((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcPs_co).Name, num2], 50018);
							return false;
						}
						if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh, isNum: false), (object)"0", false))
						{
							bool flag3 = (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh, isNum: false), (object)"1", false) ? true : false);
							double num5 = Conversions.ToDouble(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_toi_da, isNum: true));
							double num6 = Conversions.ToDouble(Helper.Repl_Null(AsiaErp.Framework.Environment.GetSIConfiguration().gia_tri_dieu_chinh_tien_nt_toi_da, isNum: true));
							double num7 = 0.0;
							double num8 = 0.0;
							if ((Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_nt"]), isNum: false), (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) && Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ty_gia"]), isNum: true), (object)0, false)) ? true : false)
							{
								Type? typeFromHandle = typeof(Math);
								object[] array = new object[3]
								{
									Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_no_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ty_gia"]), isNum: true)),
									null,
									null
								};
								object[] array2 = array;
								SIConfiguration sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
								array2[1] = sIConfiguration.Round;
								array[2] = MidpointRounding.AwayFromZero;
								object[] array3 = array;
								object[] array4 = array3;
								bool[] array5 = new bool[3] { false, true, false };
								object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array4, (string[])null, (Type[])null, array5);
								if (array5[1])
								{
									sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
								}
								num7 = Conversions.ToDouble(obj);
								Type? typeFromHandle2 = typeof(Math);
								array3 = new object[3]
								{
									Operators.MultiplyObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_co_nt"]), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ty_gia"]), isNum: true)),
									null,
									null
								};
								object[] array6 = array3;
								sIConfiguration = AsiaErp.Framework.Environment.GetSIConfiguration();
								array6[1] = sIConfiguration.Round;
								array3[2] = MidpointRounding.AwayFromZero;
								array = array3;
								object[] array7 = array;
								array5 = new bool[3] { false, true, false };
								object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array7, (string[])null, (Type[])null, array5);
								if (array5[1])
								{
									sIConfiguration.Round = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
								}
								num8 = Conversions.ToDouble(obj2);
								if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_no"]), isNum: true), (object)num7) }, (string[])null, (Type[])null, (bool[])null), (object)num5, false))
								{
									((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcPs_no).Name, num2].ErrorText = Helper.GetMessContent(50047);
									flag = flag3;
									flag2 = true;
								}
								if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_co"]), isNum: true), (object)num8) }, (string[])null, (Type[])null, (bool[])null), (object)num5, false))
								{
									((DataGridView)adgvDetail)[((DataGridViewColumn)dgvcPs_co).Name, num2].ErrorText = Helper.GetMessContent(50047);
									flag = flag3;
									flag2 = true;
								}
							}
						}
						num2++;
					}
					if ((flag2 && Operators.CompareString(AsiaErp.Framework.Environment.GetSIConfiguration().canh_bao_dieu_chinh, "0", false) != 0) ? true : false)
					{
						CMessageBox.Show(50047);
					}
					if (!flag)
					{
						return false;
					}
					return true;
				}
				CMessageBox.Show(50010);
				return false;
			}
			return false;
		}
	}

	protected override void PHDataBinding()
	{
		base.PHDataBinding();
		CreateDataBinding((Control)(object)chkNt_Ph, "nt_ph", "Checked");
		CreateDataBinding((Control)(object)txtTy_gia, "ty_gia", "Value");
		CreateDataBinding((Control)(object)cboMa_NT, "ma_nt", "MA_NT");
		CreateDataBinding((Control)(object)txtNgay_Ct, "ngay_ct", "Value");
		CreateDataBinding((Control)(object)txtSo_Ct, "so_ct");
		CreateDataBinding((Control)(object)txtNgay_lct, "ngay_lct", "Value");
		CreateDataBinding((Control)(object)txtT_tien_Nt_Co, "t_tien_nt", "Value");
		CreateDataBinding((Control)(object)txtT_Tien_Co, "t_tien", "Value");
		CreateDataBinding((Control)(object)ctlTaIn.chkKe_tain, "kht_thue_vao", "Checked");
		CreateDataBinding((Control)(object)ctlTaOut.chkKe_taout, "kht_thue_ra", "Checked");
		CreateDataBinding((Control)(object)txtT_Thue_ra_nt, "t_thue_ra_nt", "Value");
		CreateDataBinding((Control)(object)txtT_Thue_ra, "t_thue_ra", "Value");
		CreateDataBinding((Control)(object)txtT_Thue_vao_nt, "t_thue_vao_nt", "Value");
		CreateDataBinding((Control)(object)txtT_Thue_vao, "t_thue_vao", "Value");
		CreateDataBinding((Control)(object)txtT_tt, "t_tt", "Value");
		CreateDataBinding((Control)(object)txtT_tt_nt, "t_tt_nt", "Value");
	}

	protected override void Refresh_controls()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		base.Refresh_controls();
		if (base.ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			if ((int)((CheckBox)chkNt_Ph).CheckState == 0)
			{
				if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
				{
					txtTy_gia.Value = 1;
				}
				((TextBoxBase)txtTy_gia).ReadOnly = true;
				((Control)txtTy_gia).Enabled = false;
				((Control)txtTy_gia).TabStop = false;
				((Control)cboMa_NT).Enabled = false;
			}
			else
			{
				((Control)cboMa_NT).Enabled = true;
				if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
				{
					txtTy_gia.Value = 1;
					((Control)txtTy_gia).Enabled = false;
				}
				else
				{
					((Control)txtTy_gia).Enabled = true;
				}
			}
		}
		ctlTaIn.UpdateList();
		ctlTaOut.UpdateList();
	}

	protected override void InitOtherBeforeLoadData()
	{
		base.InitOtherBeforeLoadData();
		DMNTInformationBindingSource.DataSource = AsiaErp.Framework.Environment.GetDMNT();
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		base.CTTable.Columns["ma_nt"].DefaultValue = MyVoucherInfo.ma_nt_default;
		base.CTTable.Columns["ty_gia"].DefaultValue = 1;
		base.CTTable.Columns["nh_dk"].DefaultValue = "1";
		ctlTaIn.DataSource = bsTain;
		ctlTaIn.TAINTable = base.TAINTable;
		ctlTaOut.DataSource = bsTaout;
		ctlTaOut.TAOUTTable = base.TAOUTTable;
		f_sPs_co_header = ((DataGridViewColumn)dgvcPs_co_nt).HeaderText;
		f_sPs_no_header = ((DataGridViewColumn)dgvcPs_no_nt).HeaderText;
		((DataGridViewColumn)dgvcPs_co).HeaderText = f_sPs_co_header + " " + AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		((DataGridViewColumn)dgvcPs_no).HeaderText = f_sPs_no_header + " " + AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		AddControl2ListOfDrivedControls((Control)(object)chkNt_Ph);
		AddControl2ListOfDrivedControls((Control)(object)ctlTaIn.chkKe_tain);
		AddControl2ListOfDrivedControls((Control)(object)ctlTaOut.chkKe_taout);
		AddControl2ListOfDrivedControls((Control)(object)ctlTaIn.adgvTaIn);
		AddControl2ListOfDrivedControls((Control)(object)ctlTaOut.adgvTaOut);
		RefreshCtrlWhenChkNt_PhChange();
	}

	protected override void SetPHDefaultValues(DataRow drwPh)
	{
		base.SetPHDefaultValues(drwPh);
		drwPh["ngay_lct"] = RuntimeHelpers.GetObjectValue(drwPh["ngay_ct"]);
		drwPh["nt_ph"] = true;
		cboMa_NT.MA_NT = AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
	}

	protected override void InsertDetail(bool isAutoAdded = false)
	{
		base.InsertDetail(isAutoAdded);
		if (!isAutoAdded)
		{
			string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
			double num = Conversions.ToDouble(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(Ps_No)", filter)), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(Ps_Co)", filter)), isNum: true)));
			double num2 = Conversions.ToDouble(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(Ps_No_nt)", filter)), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(Ps_Co_nt)", filter)), isNum: true)));
			DataRowView dataRowView = base.CT1Voucher[((DataGridViewBand)((DataGridView)adgvDetail).CurrentRow).Index];
			int num3 = Conversions.ToInteger(Interaction.IIf(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_nt"]), isNum: false).Equals(AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0), (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
			if (num < 0.0)
			{
				dataRowView["Ps_No"] = 0.0 - num;
				dataRowView["Ps_no_nt"] = 0.0 - num2;
			}
			else
			{
				dataRowView["Ps_Co"] = num;
				dataRowView["Ps_Co_NT"] = num2;
			}
		}
	}

	protected override void Cancel()
	{
		((DataGridView)ctlTaIn.adgvTaIn).CancelEdit();
		((DataGridView)ctlTaOut.adgvTaOut).CancelEdit();
		base.Cancel();
	}

	protected override void SetReportDataSource(DataRow odrPrintPHRow)
	{
		string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", odrPrintPHRow["Stt_Rec"]), (object)"'"));
		DataTable dataTable = CTTable.Copy();
		dataTable.DefaultView.RowFilter = text;
		DataTable dataTable2 = dataTable.DefaultView.ToTable().Copy();
		DataRow dataRow = null;
		if ((TAINTable != null && Operators.ConditionalCompareObjectEqual(ctlTaIn.chkKe_tain.Checked, (object)false, false)) ? true : false)
		{
			DataRow[] array = TAINTable.Select(text);
			foreach (DataRow dataRow2 in array)
			{
				dataRow = dataTable2.NewRow();
				dataRow["stt_rec0"] = "TAI";
				dataRow["ma_kh"] = RuntimeHelpers.GetObjectValue(dataRow2["ma_kh"]);
				dataRow["ten_kh"] = RuntimeHelpers.GetObjectValue(dataRow2["ten_kh"]);
				dataRow["dien_giai"] = RuntimeHelpers.GetObjectValue(dataRow2["ten_vt"]);
				dataRow["tk"] = RuntimeHelpers.GetObjectValue(dataRow2["tk_thue_no"]);
				dataRow["ps_no"] = RuntimeHelpers.GetObjectValue(dataRow2["t_thue"]);
				dataRow["ps_no_nt"] = RuntimeHelpers.GetObjectValue(dataRow2["t_thue_nt"]);
				dataRow["ps_co"] = 0;
				dataRow["ps_co_nt"] = 0;
				dataTable2.Rows.Add(dataRow);
				dataRow = dataTable2.NewRow();
				dataRow["stt_rec0"] = "TAI";
				dataRow["ma_kh"] = RuntimeHelpers.GetObjectValue(dataRow2["ma_kh"]);
				dataRow["ten_kh"] = RuntimeHelpers.GetObjectValue(dataRow2["ten_kh"]);
				dataRow["dien_giai"] = RuntimeHelpers.GetObjectValue(dataRow2["ten_vt"]);
				dataRow["tk"] = RuntimeHelpers.GetObjectValue(dataRow2["tk_du"]);
				dataRow["ps_no"] = 0;
				dataRow["ps_no_nt"] = 0;
				dataRow["ps_co"] = RuntimeHelpers.GetObjectValue(dataRow2["t_thue"]);
				dataRow["ps_co_nt"] = RuntimeHelpers.GetObjectValue(dataRow2["t_thue_nt"]);
				dataTable2.Rows.Add(dataRow);
			}
		}
		if ((TAOUTTable != null && Operators.ConditionalCompareObjectEqual(ctlTaOut.chkKe_taout.Checked, (object)false, false)) ? true : false)
		{
			DataRow[] array2 = TAOUTTable.Select(text);
			foreach (DataRow dataRow3 in array2)
			{
				dataRow = dataTable2.NewRow();
				dataRow["stt_rec0"] = "TAO";
				dataRow["ma_kh"] = RuntimeHelpers.GetObjectValue(dataRow3["ma_kh"]);
				dataRow["ten_kh"] = RuntimeHelpers.GetObjectValue(dataRow3["ten_kh"]);
				dataRow["dien_giai"] = RuntimeHelpers.GetObjectValue(dataRow3["ten_vt"]);
				dataRow["tk"] = RuntimeHelpers.GetObjectValue(dataRow3["tk_du"]);
				dataRow["ps_no"] = RuntimeHelpers.GetObjectValue(dataRow3["t_thue"]);
				dataRow["ps_no_nt"] = RuntimeHelpers.GetObjectValue(dataRow3["t_thue_nt"]);
				dataRow["ps_co"] = 0;
				dataRow["ps_co_nt"] = 0;
				dataTable2.Rows.Add(dataRow);
				dataRow = dataTable2.NewRow();
				dataRow["stt_rec0"] = "TAO";
				dataRow["ma_kh"] = RuntimeHelpers.GetObjectValue(dataRow3["ma_kh"]);
				dataRow["ten_kh"] = RuntimeHelpers.GetObjectValue(dataRow3["ten_kh"]);
				dataRow["dien_giai"] = RuntimeHelpers.GetObjectValue(dataRow3["ten_vt"]);
				dataRow["tk"] = RuntimeHelpers.GetObjectValue(dataRow3["tk_thue"]);
				dataRow["ps_no"] = 0;
				dataRow["ps_no_nt"] = 0;
				dataRow["ps_co"] = RuntimeHelpers.GetObjectValue(dataRow3["t_thue"]);
				dataRow["ps_co_nt"] = RuntimeHelpers.GetObjectValue(dataRow3["t_thue_nt"]);
				dataTable2.Rows.Add(dataRow);
			}
		}
		checked
		{
			int num = base.MyVoucherInfo.row_per_page - dataTable2.Rows.Count;
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				dataRow = dataTable2.NewRow();
				dataTable2.Rows.Add(dataRow);
				num2++;
			}
			base.MyReportDocument.SetDataSource((IEnumerable)dataTable2.DefaultView);
		}
	}

	protected override void VoucherPositionChanged()
	{
		base.VoucherPositionChanged();
		if ((!IsLoading && CurrentPHRow != null) ? true : false)
		{
			bool mA_NT_Visiable = Conversions.ToBoolean(Operators.NotObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(CurrentPHRow["nt_ph"]), isNum: false)));
			ctlTaIn.MA_NT_Visiable = mA_NT_Visiable;
			ctlTaIn.MA_NT_Visiable = mA_NT_Visiable;
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	protected DataRow _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()
	{
		return base.CurrentPHRow;
	}
}
