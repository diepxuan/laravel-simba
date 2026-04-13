using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmSIDMCTEdit : frmDMEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblMa_ct")]
	private Label _lblMa_ct;

	[AccessedThroughProperty("lblTen_ct")]
	private Label _lblTen_ct;

	[AccessedThroughProperty("lblMa_ct_me")]
	private Label _lblMa_ct_me;

	[AccessedThroughProperty("txtMa_ct_me")]
	private AsTextBox _txtMa_ct_me;

	[AccessedThroughProperty("txtTen_ct")]
	private TextBox _txtTen_ct;

	[AccessedThroughProperty("txtMa_ct")]
	private TextBox _txtMa_ct;

	[AccessedThroughProperty("lblPhan_he")]
	private Label _lblPhan_he;

	[AccessedThroughProperty("lblTen_ct_me")]
	private Label _lblTen_ct_me;

	[AccessedThroughProperty("lblTen_tk_no")]
	private Label _lblTen_tk_no;

	[AccessedThroughProperty("lblTen_tk_co")]
	private Label _lblTen_tk_co;

	[AccessedThroughProperty("lblTk_no")]
	private Label _lblTk_no;

	[AccessedThroughProperty("lblTK_co")]
	private Label _lblTK_co;

	[AccessedThroughProperty("txtTK_no")]
	private AsTextBox _txtTK_no;

	[AccessedThroughProperty("txtTen_tk_co")]
	private AsTextBox _txtTen_tk_co;

	[AccessedThroughProperty("lblMa_nt")]
	private Label _lblMa_nt;

	[AccessedThroughProperty("txtSo_lien")]
	private AsTextNumeric _txtSo_lien;

	[AccessedThroughProperty("txtSTT_NTXT")]
	private AsTextNumeric _txtSTT_NTXT;

	[AccessedThroughProperty("txtSoTT_nkc")]
	private AsTextNumeric _txtSoTT_nkc;

	[AccessedThroughProperty("lblSTT_NTXT")]
	private Label _lblSTT_NTXT;

	[AccessedThroughProperty("lblSoTT_nkc")]
	private Label _lblSoTT_nkc;

	[AccessedThroughProperty("lblSo_lien")]
	private Label _lblSo_lien;

	[AccessedThroughProperty("cboMa_nt")]
	private AsComboBoxNT _cboMa_nt;

	[AccessedThroughProperty("lblPrefix")]
	private Label _lblPrefix;

	[AccessedThroughProperty("txtPrefix")]
	private TextBox _txtPrefix;

	[AccessedThroughProperty("txtSequence")]
	private AsTextNumeric _txtSequence;

	[AccessedThroughProperty("lblSequence")]
	private Label _lblSequence;

	[AccessedThroughProperty("lblPattern")]
	private Label _lblPattern;

	[AccessedThroughProperty("txtPattern")]
	private TextBox _txtPattern;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("chkFilterByUser")]
	private AsCheckBox _chkFilterByUser;

	[AccessedThroughProperty("chkUse_Ma_spct")]
	private AsCheckBox _chkUse_Ma_spct;

	[AccessedThroughProperty("chkUse_ma_bo_phan")]
	private AsCheckBox _chkUse_ma_bo_phan;

	[AccessedThroughProperty("chkUse_ma_phi")]
	private AsCheckBox _chkUse_ma_phi;

	[AccessedThroughProperty("chkUse_ma_vu_viec")]
	private AsCheckBox _chkUse_ma_vu_viec;

	[AccessedThroughProperty("chkUse_ma_lo")]
	private AsCheckBox _chkUse_ma_lo;

	[AccessedThroughProperty("txtPhan_he")]
	private TextBox _txtPhan_he;

	[AccessedThroughProperty("txtVn_width")]
	private NumericUpDown _txtVn_width;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtVN")]
	private TextBox _txtVN;

	[AccessedThroughProperty("lblSct_view")]
	private Label _lblSct_view;

	[AccessedThroughProperty("cbo_kieu_trung_so_ct")]
	private AsComboBox _cbo_kieu_trung_so_ct;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("cmdAdvanceConfig")]
	private Button _cmdAdvanceConfig;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtPostfix")]
	private TextBox _txtPostfix;

	[AccessedThroughProperty("lblNote")]
	private Label _lblNote;

	internal virtual Label lblMa_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_ct = value;
		}
	}

	internal virtual Label lblTen_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ct = value;
		}
	}

	internal virtual Label lblMa_ct_me
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_ct_me;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_ct_me = value;
		}
	}

	internal virtual AsTextBox txtMa_ct_me
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ct_me;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_ct_me = value;
		}
	}

	internal virtual TextBox txtTen_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_ct = value;
		}
	}

	internal virtual TextBox txtMa_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_ct = value;
		}
	}

	internal virtual Label lblPhan_he
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPhan_he;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPhan_he = value;
		}
	}

	internal virtual Label lblTen_ct_me
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_ct_me;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_ct_me = value;
		}
	}

	internal virtual Label lblTen_tk_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk_no = value;
		}
	}

	internal virtual Label lblTen_tk_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk_co = value;
		}
	}

	internal virtual Label lblTk_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_no = value;
		}
	}

	internal virtual Label lblTK_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTK_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTK_co = value;
		}
	}

	internal virtual AsTextBox txtTK_no
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK_no;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK_no = value;
		}
	}

	internal virtual AsTextBox txtTen_tk_co
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_tk_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_tk_co = value;
		}
	}

	internal virtual Label lblMa_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_nt = value;
		}
	}

	internal virtual AsTextNumeric txtSo_lien
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_lien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_lien = value;
		}
	}

	internal virtual AsTextNumeric txtSTT_NTXT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSTT_NTXT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSTT_NTXT = value;
		}
	}

	internal virtual AsTextNumeric txtSoTT_nkc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSoTT_nkc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSoTT_nkc = value;
		}
	}

	internal virtual Label lblSTT_NTXT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSTT_NTXT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSTT_NTXT = value;
		}
	}

	internal virtual Label lblSoTT_nkc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSoTT_nkc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSoTT_nkc = value;
		}
	}

	internal virtual Label lblSo_lien
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_lien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_lien = value;
		}
	}

	internal virtual AsComboBoxNT cboMa_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboMa_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboMa_nt = value;
		}
	}

	internal virtual Label lblPrefix
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPrefix;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPrefix = value;
		}
	}

	internal virtual TextBox txtPrefix
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPrefix;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtVn_width_ValueChanged;
			if (_txtPrefix != null)
			{
				((Control)_txtPrefix).TextChanged -= eventHandler;
			}
			_txtPrefix = value;
			if (_txtPrefix != null)
			{
				((Control)_txtPrefix).TextChanged += eventHandler;
			}
		}
	}

	internal virtual AsTextNumeric txtSequence
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSequence;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtVn_width_ValueChanged;
			if (_txtSequence != null)
			{
				((Control)_txtSequence).TextChanged -= eventHandler;
			}
			_txtSequence = value;
			if (_txtSequence != null)
			{
				((Control)_txtSequence).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblSequence
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSequence;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSequence = value;
		}
	}

	internal virtual Label lblPattern
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPattern;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPattern = value;
		}
	}

	internal virtual TextBox txtPattern
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPattern;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtVn_width_ValueChanged;
			if (_txtPattern != null)
			{
				((Control)_txtPattern).TextChanged -= eventHandler;
			}
			_txtPattern = value;
			if (_txtPattern != null)
			{
				((Control)_txtPattern).TextChanged += eventHandler;
			}
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

	internal virtual AsCheckBox chkFilterByUser
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkFilterByUser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkFilterByUser = value;
		}
	}

	internal virtual AsCheckBox chkUse_Ma_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkUse_Ma_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkUse_Ma_spct = value;
		}
	}

	internal virtual AsCheckBox chkUse_ma_bo_phan
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkUse_ma_bo_phan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkUse_ma_bo_phan = value;
		}
	}

	internal virtual AsCheckBox chkUse_ma_phi
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkUse_ma_phi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkUse_ma_phi = value;
		}
	}

	internal virtual AsCheckBox chkUse_ma_vu_viec
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkUse_ma_vu_viec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkUse_ma_vu_viec = value;
		}
	}

	internal virtual AsCheckBox chkUse_ma_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkUse_ma_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkUse_ma_lo = value;
		}
	}

	internal virtual TextBox txtPhan_he
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPhan_he;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPhan_he = value;
		}
	}

	internal virtual NumericUpDown txtVn_width
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVn_width;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtVn_width_ValueChanged;
			if (_txtVn_width != null)
			{
				_txtVn_width.ValueChanged -= eventHandler;
			}
			_txtVn_width = value;
			if (_txtVn_width != null)
			{
				_txtVn_width.ValueChanged += eventHandler;
			}
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

	internal virtual TextBox txtVN
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtVN = value;
		}
	}

	internal virtual Label lblSct_view
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSct_view;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSct_view = value;
		}
	}

	internal virtual AsComboBox cbo_kieu_trung_so_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _cbo_kieu_trung_so_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cbo_kieu_trung_so_ct = value;
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

	internal virtual Button cmdAdvanceConfig
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdAdvanceConfig;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdAdvanceConfig_Click;
			if (_cmdAdvanceConfig != null)
			{
				((Control)_cmdAdvanceConfig).Click -= eventHandler;
			}
			_cmdAdvanceConfig = value;
			if (_cmdAdvanceConfig != null)
			{
				((Control)_cmdAdvanceConfig).Click += eventHandler;
			}
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

	internal virtual TextBox txtPostfix
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPostfix;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtVn_width_ValueChanged;
			if (_txtPostfix != null)
			{
				((Control)_txtPostfix).TextChanged -= eventHandler;
			}
			_txtPostfix = value;
			if (_txtPostfix != null)
			{
				((Control)_txtPostfix).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblNote
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNote;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNote = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSIDMCTEdit()
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_23a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b1: Expected O, but got Unknown
		lblMa_ct = new Label();
		txtMa_ct = new TextBox();
		lblTen_ct = new Label();
		txtTen_ct = new TextBox();
		txtMa_ct_me = new AsTextBox();
		lblTen_ct_me = new Label();
		lblMa_ct_me = new Label();
		lblPhan_he = new Label();
		txtTK_no = new AsTextBox();
		lblTen_tk_no = new Label();
		lblTk_no = new Label();
		txtTen_tk_co = new AsTextBox();
		lblTen_tk_co = new Label();
		lblTK_co = new Label();
		cboMa_nt = new AsComboBoxNT();
		lblMa_nt = new Label();
		txtSo_lien = new AsTextNumeric();
		lblSo_lien = new Label();
		lblSoTT_nkc = new Label();
		txtSoTT_nkc = new AsTextNumeric();
		lblSTT_NTXT = new Label();
		txtSTT_NTXT = new AsTextNumeric();
		txtPrefix = new TextBox();
		lblPrefix = new Label();
		lblSequence = new Label();
		txtSequence = new AsTextNumeric();
		txtPattern = new TextBox();
		lblPattern = new Label();
		GroupBox1 = new GroupBox();
		chkUse_ma_lo = new AsCheckBox();
		chkUse_Ma_spct = new AsCheckBox();
		chkUse_ma_bo_phan = new AsCheckBox();
		chkUse_ma_phi = new AsCheckBox();
		chkUse_ma_vu_viec = new AsCheckBox();
		chkFilterByUser = new AsCheckBox();
		txtPhan_he = new TextBox();
		Label1 = new Label();
		txtVn_width = new NumericUpDown();
		txtVN = new TextBox();
		lblSct_view = new Label();
		cbo_kieu_trung_so_ct = new AsComboBox();
		Label2 = new Label();
		cmdAdvanceConfig = new Button();
		Label3 = new Label();
		txtPostfix = new TextBox();
		Label4 = new Label();
		lblNote = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)txtVn_width).BeginInit();
		((Control)this).SuspendLayout();
		((Control)chkKsd).Enabled = false;
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(394, 456);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).Visible = false;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 490);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 3;
		Button obj2 = cmdSave;
		location = new Point(12, 490);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 2;
		((Control)gbLine).Controls.Add((Control)(object)Label4);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)txtPostfix);
		((Control)gbLine).Controls.Add((Control)(object)cbo_kieu_trung_so_ct);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)lblSct_view);
		((Control)gbLine).Controls.Add((Control)(object)txtVN);
		((Control)gbLine).Controls.Add((Control)(object)txtVn_width);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_lien);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_ct_me);
		((Control)gbLine).Controls.Add((Control)(object)txtSTT_NTXT);
		((Control)gbLine).Controls.Add((Control)(object)txtSequence);
		((Control)gbLine).Controls.Add((Control)(object)txtSoTT_nkc);
		((Control)gbLine).Controls.Add((Control)(object)cboMa_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_ct);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk_no);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk_co);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_ct);
		((Control)gbLine).Controls.Add((Control)(object)lblPrefix);
		((Control)gbLine).Controls.Add((Control)(object)lblPattern);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_ct_me);
		((Control)gbLine).Controls.Add((Control)(object)lblPhan_he);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_no);
		((Control)gbLine).Controls.Add((Control)(object)lblTK_co);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_nt);
		((Control)gbLine).Controls.Add((Control)(object)lblSTT_NTXT);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_ct_me);
		((Control)gbLine).Controls.Add((Control)(object)lblSequence);
		((Control)gbLine).Controls.Add((Control)(object)lblSoTT_nkc);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_lien);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtTK_no);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_tk_co);
		((Control)gbLine).Controls.Add((Control)(object)txtPattern);
		((Control)gbLine).Controls.Add((Control)(object)txtPhan_he);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtPrefix);
		GroupBox obj3 = gbLine;
		location = new Point(12, 5);
		((Control)obj3).Location = location;
		GroupBox obj4 = gbLine;
		Size size = new Size(447, 479);
		((Control)obj4).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtPrefix, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtPhan_he, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtPattern, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_tk_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK_no, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_lien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSoTT_nkc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSequence, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_ct_me, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSTT_NTXT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTK_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_no, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblPhan_he, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_ct_me, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblPattern, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblPrefix, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk_co, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk_no, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cboMa_nt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSoTT_nkc, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSequence, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSTT_NTXT, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_ct_me, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_lien, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtVn_width, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtVN, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSct_view, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)cbo_kieu_trung_so_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtPostfix, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label4, 0);
		lblMa_ct.AutoSize = true;
		Label obj5 = lblMa_ct;
		location = new Point(19, 20);
		((Control)obj5).Location = location;
		((Control)lblMa_ct).Name = "lblMa_ct";
		Label obj6 = lblMa_ct;
		size = new Size(67, 13);
		((Control)obj6).Size = size;
		((Control)lblMa_ct).TabIndex = 100;
		lblMa_ct.Text = "Mã chứng từ";
		txtMa_ct.CharacterCasing = (CharacterCasing)1;
		TextBox obj7 = txtMa_ct;
		location = new Point(156, 17);
		((Control)obj7).Location = location;
		((Control)txtMa_ct).Name = "txtMa_ct";
		TextBox obj8 = txtMa_ct;
		size = new Size(74, 20);
		((Control)obj8).Size = size;
		((Control)txtMa_ct).TabIndex = 101;
		lblTen_ct.AutoSize = true;
		Label obj9 = lblTen_ct;
		location = new Point(19, 46);
		((Control)obj9).Location = location;
		((Control)lblTen_ct).Name = "lblTen_ct";
		Label obj10 = lblTen_ct;
		size = new Size(71, 13);
		((Control)obj10).Size = size;
		((Control)lblTen_ct).TabIndex = 100;
		lblTen_ct.Text = "Tên chứng từ";
		TextBox obj11 = txtTen_ct;
		location = new Point(156, 43);
		((Control)obj11).Location = location;
		((Control)txtTen_ct).Name = "txtTen_ct";
		TextBox obj12 = txtTen_ct;
		size = new Size(280, 20);
		((Control)obj12).Size = size;
		((Control)txtTen_ct).TabIndex = 0;
		txtMa_ct_me.AutoLookup = true;
		txtMa_ct_me.AutoValid = false;
		((TextBoxBase)txtMa_ct_me).BackColor = SystemColors.Info;
		((TextBox)txtMa_ct_me).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_ct_me;
		location = new Point(156, 69);
		((Control)asTextBox).Location = location;
		txtMa_ct_me.LookupCodeName = "MA_CT";
		((Control)txtMa_ct_me).Name = "txtMa_ct_me";
		txtMa_ct_me.NameControl = lblTen_ct_me;
		AsTextBox asTextBox2 = txtMa_ct_me;
		size = new Size(74, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_ct_me).TabIndex = 1;
		txtMa_ct_me.UseAutoCompleteSource = true;
		Label obj13 = lblTen_ct_me;
		location = new Point(240, 72);
		((Control)obj13).Location = location;
		((Control)lblTen_ct_me).Name = "lblTen_ct_me";
		Label obj14 = lblTen_ct_me;
		size = new Size(173, 16);
		((Control)obj14).Size = size;
		((Control)lblTen_ct_me).TabIndex = 103;
		lblMa_ct_me.AutoSize = true;
		Label obj15 = lblMa_ct_me;
		location = new Point(19, 72);
		((Control)obj15).Location = location;
		((Control)lblMa_ct_me).Name = "lblMa_ct_me";
		Label obj16 = lblMa_ct_me;
		size = new Size(84, 13);
		((Control)obj16).Size = size;
		((Control)lblMa_ct_me).TabIndex = 100;
		lblMa_ct_me.Text = "Mã chứng từ mẹ";
		lblPhan_he.AutoSize = true;
		Label obj17 = lblPhan_he;
		location = new Point(19, 125);
		((Control)obj17).Location = location;
		((Control)lblPhan_he).Name = "lblPhan_he";
		Label obj18 = lblPhan_he;
		size = new Size(47, 13);
		((Control)obj18).Size = size;
		((Control)lblPhan_he).TabIndex = 100;
		lblPhan_he.Text = "Phân hệ";
		txtTK_no.AutoLookup = true;
		txtTK_no.AutoValid = true;
		((TextBoxBase)txtTK_no).BackColor = SystemColors.Info;
		((TextBox)txtTK_no).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtTK_no;
		location = new Point(156, 148);
		((Control)asTextBox3).Location = location;
		txtTK_no.LookupCodeName = "TK";
		((Control)txtTK_no).Name = "txtTK_no";
		txtTK_no.NameControl = lblTen_tk_no;
		AsTextBox asTextBox4 = txtTK_no;
		size = new Size(74, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtTK_no).TabIndex = 4;
		txtTK_no.UseAutoCompleteSource = true;
		Label obj19 = lblTen_tk_no;
		location = new Point(240, 150);
		((Control)obj19).Location = location;
		((Control)lblTen_tk_no).Name = "lblTen_tk_no";
		Label obj20 = lblTen_tk_no;
		size = new Size(173, 16);
		((Control)obj20).Size = size;
		((Control)lblTen_tk_no).TabIndex = 103;
		lblTk_no.AutoSize = true;
		Label obj21 = lblTk_no;
		location = new Point(19, 151);
		((Control)obj21).Location = location;
		((Control)lblTk_no).Name = "lblTk_no";
		Label obj22 = lblTk_no;
		size = new Size(70, 13);
		((Control)obj22).Size = size;
		((Control)lblTk_no).TabIndex = 100;
		lblTk_no.Text = "Tài khoản nợ";
		txtTen_tk_co.AutoLookup = true;
		txtTen_tk_co.AutoValid = true;
		((TextBoxBase)txtTen_tk_co).BackColor = SystemColors.Info;
		((TextBox)txtTen_tk_co).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTen_tk_co;
		location = new Point(156, 174);
		((Control)asTextBox5).Location = location;
		txtTen_tk_co.LookupCodeName = "TK";
		((Control)txtTen_tk_co).Name = "txtTen_tk_co";
		txtTen_tk_co.NameControl = lblTen_tk_co;
		AsTextBox asTextBox6 = txtTen_tk_co;
		size = new Size(74, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTen_tk_co).TabIndex = 5;
		txtTen_tk_co.UseAutoCompleteSource = true;
		Label obj23 = lblTen_tk_co;
		location = new Point(240, 176);
		((Control)obj23).Location = location;
		((Control)lblTen_tk_co).Name = "lblTen_tk_co";
		Label obj24 = lblTen_tk_co;
		size = new Size(173, 16);
		((Control)obj24).Size = size;
		((Control)lblTen_tk_co).TabIndex = 103;
		lblTK_co.AutoSize = true;
		Label obj25 = lblTK_co;
		location = new Point(19, 177);
		((Control)obj25).Location = location;
		((Control)lblTK_co).Name = "lblTK_co";
		Label obj26 = lblTK_co;
		size = new Size(70, 13);
		((Control)obj26).Size = size;
		((Control)lblTK_co).TabIndex = 100;
		lblTK_co.Text = "Tài khoản có";
		((ComboBox)cboMa_nt).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboMa_nt).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_nt;
		location = new Point(156, 200);
		((Control)asComboBoxNT).Location = location;
		cboMa_nt.MA_NT = "";
		((Control)cboMa_nt).Name = "cboMa_nt";
		AsComboBoxNT asComboBoxNT2 = cboMa_nt;
		size = new Size(74, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_nt).TabIndex = 6;
		lblMa_nt.AutoSize = true;
		Label obj27 = lblMa_nt;
		location = new Point(19, 204);
		((Control)obj27).Location = location;
		((Control)lblMa_nt).Name = "lblMa_nt";
		Label obj28 = lblMa_nt;
		size = new Size(40, 13);
		((Control)obj28).Size = size;
		((Control)lblMa_nt).TabIndex = 100;
		lblMa_nt.Text = "Mã NT";
		txtSo_lien.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric = txtSo_lien;
		location = new Point(156, 227);
		((Control)asTextNumeric).Location = location;
		txtSo_lien.Mask = "### ### ### ###";
		((Control)txtSo_lien).Name = "txtSo_lien";
		AsTextNumeric asTextNumeric2 = txtSo_lien;
		size = new Size(74, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtSo_lien).TabIndex = 7;
		((TextBox)txtSo_lien).Text = "0";
		((TextBox)txtSo_lien).TextAlign = (HorizontalAlignment)1;
		txtSo_lien.Value = 0.0;
		lblSo_lien.AutoSize = true;
		Label obj29 = lblSo_lien;
		location = new Point(19, 231);
		((Control)obj29).Location = location;
		((Control)lblSo_lien).Name = "lblSo_lien";
		Label obj30 = lblSo_lien;
		size = new Size(67, 13);
		((Control)obj30).Size = size;
		((Control)lblSo_lien).TabIndex = 100;
		lblSo_lien.Text = "Số liên khi in";
		lblSoTT_nkc.AutoSize = true;
		Label obj31 = lblSoTT_nkc;
		location = new Point(19, 257);
		((Control)obj31).Location = location;
		((Control)lblSoTT_nkc).Name = "lblSoTT_nkc";
		Label obj32 = lblSoTT_nkc;
		size = new Size(99, 13);
		((Control)obj32).Size = size;
		((Control)lblSoTT_nkc).TabIndex = 100;
		lblSoTT_nkc.Text = "STT nhật ký chung";
		txtSoTT_nkc.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric3 = txtSoTT_nkc;
		location = new Point(156, 253);
		((Control)asTextNumeric3).Location = location;
		txtSoTT_nkc.Mask = "### ### ### ###";
		((Control)txtSoTT_nkc).Name = "txtSoTT_nkc";
		AsTextNumeric asTextNumeric4 = txtSoTT_nkc;
		size = new Size(74, 20);
		((Control)asTextNumeric4).Size = size;
		((Control)txtSoTT_nkc).TabIndex = 8;
		((TextBox)txtSoTT_nkc).Text = "0";
		((TextBox)txtSoTT_nkc).TextAlign = (HorizontalAlignment)1;
		txtSoTT_nkc.Value = 0.0;
		lblSTT_NTXT.AutoSize = true;
		Label obj33 = lblSTT_NTXT;
		location = new Point(19, 283);
		((Control)obj33).Location = location;
		((Control)lblSTT_NTXT).Name = "lblSTT_NTXT";
		Label obj34 = lblSTT_NTXT;
		size = new Size(132, 13);
		((Control)obj34).Size = size;
		((Control)lblSTT_NTXT).TabIndex = 100;
		lblSTT_NTXT.Text = "STT nhập trước xuất trước";
		txtSTT_NTXT.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric5 = txtSTT_NTXT;
		location = new Point(156, 279);
		((Control)asTextNumeric5).Location = location;
		txtSTT_NTXT.Mask = "### ### ### ###";
		((Control)txtSTT_NTXT).Name = "txtSTT_NTXT";
		AsTextNumeric asTextNumeric6 = txtSTT_NTXT;
		size = new Size(74, 20);
		((Control)asTextNumeric6).Size = size;
		((Control)txtSTT_NTXT).TabIndex = 9;
		((TextBox)txtSTT_NTXT).Text = "0";
		((TextBox)txtSTT_NTXT).TextAlign = (HorizontalAlignment)1;
		txtSTT_NTXT.Value = 0.0;
		txtPrefix.CharacterCasing = (CharacterCasing)1;
		TextBox obj35 = txtPrefix;
		location = new Point(156, 371);
		((Control)obj35).Location = location;
		((Control)txtPrefix).Name = "txtPrefix";
		TextBox obj36 = txtPrefix;
		size = new Size(74, 20);
		((Control)obj36).Size = size;
		((Control)txtPrefix).TabIndex = 11;
		lblPrefix.AutoSize = true;
		Label obj37 = lblPrefix;
		location = new Point(58, 373);
		((Control)obj37).Location = location;
		((Control)lblPrefix).Name = "lblPrefix";
		Label obj38 = lblPrefix;
		size = new Size(54, 13);
		((Control)obj38).Size = size;
		((Control)lblPrefix).TabIndex = 100;
		lblPrefix.Text = "Phần đầu";
		lblSequence.AutoSize = true;
		Label obj39 = lblSequence;
		location = new Point(58, 399);
		((Control)obj39).Location = location;
		((Control)lblSequence).Name = "lblSequence";
		Label obj40 = lblSequence;
		size = new Size(68, 13);
		((Control)obj40).Size = size;
		((Control)lblSequence).TabIndex = 100;
		lblSequence.Text = "Phần tự tăng";
		((TextBox)txtSequence).CharacterCasing = (CharacterCasing)1;
		txtSequence.DecimalSymbol = ".";
		AsTextNumeric asTextNumeric7 = txtSequence;
		location = new Point(156, 397);
		((Control)asTextNumeric7).Location = location;
		txtSequence.Mask = "############";
		((Control)txtSequence).Name = "txtSequence";
		AsTextNumeric asTextNumeric8 = txtSequence;
		size = new Size(74, 20);
		((Control)asTextNumeric8).Size = size;
		((Control)txtSequence).TabIndex = 12;
		((TextBox)txtSequence).Text = "0";
		((TextBox)txtSequence).TextAlign = (HorizontalAlignment)1;
		txtSequence.Value = 0.0;
		TextBox obj41 = txtPattern;
		location = new Point(156, 449);
		((Control)obj41).Location = location;
		((TextBoxBase)txtPattern).MaxLength = 1;
		((Control)txtPattern).Name = "txtPattern";
		TextBox obj42 = txtPattern;
		size = new Size(33, 20);
		((Control)obj42).Size = size;
		((Control)txtPattern).TabIndex = 14;
		txtPattern.Text = "0";
		lblPattern.AutoSize = true;
		Label obj43 = lblPattern;
		location = new Point(58, 451);
		((Control)obj43).Location = location;
		((Control)lblPattern).Name = "lblPattern";
		Label obj44 = lblPattern;
		size = new Size(54, 13);
		((Control)obj44).Size = size;
		((Control)lblPattern).TabIndex = 100;
		lblPattern.Text = "Ký tự mẫu";
		((Control)GroupBox1).Controls.Add((Control)(object)chkUse_ma_lo);
		((Control)GroupBox1).Controls.Add((Control)(object)chkUse_Ma_spct);
		((Control)GroupBox1).Controls.Add((Control)(object)chkUse_ma_bo_phan);
		((Control)GroupBox1).Controls.Add((Control)(object)chkUse_ma_phi);
		((Control)GroupBox1).Controls.Add((Control)(object)chkUse_ma_vu_viec);
		((Control)GroupBox1).Controls.Add((Control)(object)chkFilterByUser);
		GroupBox groupBox = GroupBox1;
		location = new Point(467, 5);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(206, 479);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 1;
		GroupBox1.TabStop = false;
		GroupBox1.Text = "Có hay không sử dụng một số trường khi nhập liệu";
		((ButtonBase)chkUse_ma_lo).AutoSize = true;
		chkUse_ma_lo.Checked = false;
		AsCheckBox asCheckBox2 = chkUse_ma_lo;
		location = new Point(15, 189);
		((Control)asCheckBox2).Location = location;
		((Control)chkUse_ma_lo).Name = "chkUse_ma_lo";
		AsCheckBox asCheckBox3 = chkUse_ma_lo;
		size = new Size(127, 17);
		((Control)asCheckBox3).Size = size;
		((Control)chkUse_ma_lo).TabIndex = 5;
		((ButtonBase)chkUse_ma_lo).Text = "Sử dụng trường mã lô";
		chkUse_ma_lo.TextValue = "0";
		((ButtonBase)chkUse_ma_lo).UseVisualStyleBackColor = true;
		((ButtonBase)chkUse_Ma_spct).AutoSize = true;
		chkUse_Ma_spct.Checked = false;
		AsCheckBox asCheckBox4 = chkUse_Ma_spct;
		location = new Point(15, 160);
		((Control)asCheckBox4).Location = location;
		((Control)chkUse_Ma_spct).Name = "chkUse_Ma_spct";
		AsCheckBox asCheckBox5 = chkUse_Ma_spct;
		size = new Size(147, 17);
		((Control)asCheckBox5).Size = size;
		((Control)chkUse_Ma_spct).TabIndex = 4;
		((ButtonBase)chkUse_Ma_spct).Text = "Sử dụng trường mã SPCT";
		chkUse_Ma_spct.TextValue = "0";
		((ButtonBase)chkUse_Ma_spct).UseVisualStyleBackColor = true;
		((ButtonBase)chkUse_ma_bo_phan).AutoSize = true;
		chkUse_ma_bo_phan.Checked = false;
		AsCheckBox asCheckBox6 = chkUse_ma_bo_phan;
		location = new Point(15, 131);
		((Control)asCheckBox6).Location = location;
		((Control)chkUse_ma_bo_phan).Name = "chkUse_ma_bo_phan";
		AsCheckBox asCheckBox7 = chkUse_ma_bo_phan;
		size = new Size(158, 17);
		((Control)asCheckBox7).Size = size;
		((Control)chkUse_ma_bo_phan).TabIndex = 3;
		((ButtonBase)chkUse_ma_bo_phan).Text = "Sử dụng trường mã bộ phận";
		chkUse_ma_bo_phan.TextValue = "0";
		((ButtonBase)chkUse_ma_bo_phan).UseVisualStyleBackColor = true;
		((ButtonBase)chkUse_ma_phi).AutoSize = true;
		chkUse_ma_phi.Checked = false;
		AsCheckBox asCheckBox8 = chkUse_ma_phi;
		location = new Point(15, 103);
		((Control)asCheckBox8).Location = location;
		((Control)chkUse_ma_phi).Name = "chkUse_ma_phi";
		AsCheckBox asCheckBox9 = chkUse_ma_phi;
		size = new Size(135, 17);
		((Control)asCheckBox9).Size = size;
		((Control)chkUse_ma_phi).TabIndex = 2;
		((ButtonBase)chkUse_ma_phi).Text = "Sử dụng trường mã phí";
		chkUse_ma_phi.TextValue = "0";
		((ButtonBase)chkUse_ma_phi).UseVisualStyleBackColor = true;
		((ButtonBase)chkUse_ma_vu_viec).AutoSize = true;
		chkUse_ma_vu_viec.Checked = false;
		AsCheckBox asCheckBox10 = chkUse_ma_vu_viec;
		location = new Point(15, 76);
		((Control)asCheckBox10).Location = location;
		((Control)chkUse_ma_vu_viec).Name = "chkUse_ma_vu_viec";
		AsCheckBox asCheckBox11 = chkUse_ma_vu_viec;
		size = new Size(165, 17);
		((Control)asCheckBox11).Size = size;
		((Control)chkUse_ma_vu_viec).TabIndex = 1;
		((ButtonBase)chkUse_ma_vu_viec).Text = "Sử dụng trường mã hợp đồng";
		chkUse_ma_vu_viec.TextValue = "0";
		((ButtonBase)chkUse_ma_vu_viec).UseVisualStyleBackColor = true;
		((ButtonBase)chkFilterByUser).AutoSize = true;
		chkFilterByUser.Checked = false;
		AsCheckBox asCheckBox12 = chkFilterByUser;
		location = new Point(15, 47);
		((Control)asCheckBox12).Location = location;
		((Control)chkFilterByUser).Name = "chkFilterByUser";
		AsCheckBox asCheckBox13 = chkFilterByUser;
		size = new Size(138, 17);
		((Control)asCheckBox13).Size = size;
		((Control)chkFilterByUser).TabIndex = 0;
		((ButtonBase)chkFilterByUser).Text = "Lọc theo người sử dụng";
		chkFilterByUser.TextValue = "0";
		((ButtonBase)chkFilterByUser).UseVisualStyleBackColor = true;
		txtPhan_he.CharacterCasing = (CharacterCasing)1;
		TextBox obj45 = txtPhan_he;
		location = new Point(156, 122);
		((Control)obj45).Location = location;
		((Control)txtPhan_he).Name = "txtPhan_he";
		TextBox obj46 = txtPhan_he;
		size = new Size(74, 20);
		((Control)obj46).Size = size;
		((Control)txtPhan_he).TabIndex = 3;
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(58, 344);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(45, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 100;
		Label1.Text = "Độ rộng";
		NumericUpDown obj47 = txtVn_width;
		location = new Point(156, 342);
		((Control)obj47).Location = location;
		NumericUpDown obj48 = txtVn_width;
		decimal maximum = new decimal(new int[4] { 12, 0, 0, 0 });
		obj48.Maximum = maximum;
		maximum = (txtVn_width.Minimum = new decimal(new int[4] { 1, 0, 0, 0 }));
		((Control)txtVn_width).Name = "txtVn_width";
		NumericUpDown obj49 = txtVn_width;
		size = new Size(74, 20);
		((Control)obj49).Size = size;
		((Control)txtVn_width).TabIndex = 10;
		((UpDownBase)txtVn_width).TextAlign = (HorizontalAlignment)1;
		maximum = (txtVn_width.Value = new decimal(new int[4] { 1, 0, 0, 0 }));
		TextBox obj50 = txtVN;
		location = new Point(256, 449);
		((Control)obj50).Location = location;
		((Control)txtVN).Name = "txtVN";
		((TextBoxBase)txtVN).ReadOnly = true;
		TextBox obj51 = txtVN;
		size = new Size(180, 20);
		((Control)obj51).Size = size;
		((Control)txtVN).TabIndex = 100;
		lblSct_view.AutoSize = true;
		Label obj52 = lblSct_view;
		location = new Point(195, 453);
		((Control)obj52).Location = location;
		((Control)lblSct_view).Name = "lblSct_view";
		Label obj53 = lblSct_view;
		size = new Size(55, 13);
		((Control)obj53).Size = size;
		((Control)lblSct_view).TabIndex = 105;
		lblSct_view.Text = "Xem trước";
		((ComboBox)cbo_kieu_trung_so_ct).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cbo_kieu_trung_so_ct).FormattingEnabled = true;
		((ComboBox)cbo_kieu_trung_so_ct).Items.AddRange(new object[3] { "0 - Cho phép trùng", "1 - Theo tháng", "2 - Theo năm" });
		AsComboBox asComboBox = cbo_kieu_trung_so_ct;
		location = new Point(156, 95);
		((Control)asComboBox).Location = location;
		((Control)cbo_kieu_trung_so_ct).Name = "cbo_kieu_trung_so_ct";
		AsComboBox asComboBox2 = cbo_kieu_trung_so_ct;
		size = new Size(144, 21);
		((Control)asComboBox2).Size = size;
		((Control)cbo_kieu_trung_so_ct).TabIndex = 2;
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(19, 98);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(114, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 108;
		Label2.Text = "Kiểu trùng số chứng từ";
		Button obj54 = cmdAdvanceConfig;
		location = new Point(174, 427);
		((Control)obj54).Location = location;
		((Control)cmdAdvanceConfig).Name = "cmdAdvanceConfig";
		Button obj55 = cmdAdvanceConfig;
		size = new Size(83, 23);
		((Control)obj55).Size = size;
		((Control)cmdAdvanceConfig).TabIndex = 4;
		((ButtonBase)cmdAdvanceConfig).Text = "KB nâng cao";
		((ButtonBase)cmdAdvanceConfig).UseVisualStyleBackColor = true;
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(58, 425);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(55, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 110;
		Label3.Text = "Phần cuối";
		txtPostfix.CharacterCasing = (CharacterCasing)1;
		TextBox obj56 = txtPostfix;
		location = new Point(156, 423);
		((Control)obj56).Location = location;
		((Control)txtPostfix).Name = "txtPostfix";
		TextBox obj57 = txtPostfix;
		size = new Size(74, 20);
		((Control)obj57).Size = size;
		((Control)txtPostfix).TabIndex = 13;
		Label4.AutoSize = true;
		((Control)Label4).ForeColor = Color.DeepSkyBlue;
		Label label7 = Label4;
		location = new Point(19, 319);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(65, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 111;
		Label4.Text = "Số chứng từ";
		((Control)lblNote).ForeColor = Color.Red;
		Label obj58 = lblNote;
		location = new Point(207, 490);
		((Control)obj58).Location = location;
		((Control)lblNote).Name = "lblNote";
		Label obj59 = lblNote;
		size = new Size(466, 35);
		((Control)obj59).Size = size;
		((Control)lblNote).TabIndex = 101;
		lblNote.Text = "(Có thể sử dụng định dạng {DD}, {MM}, {YY}, {YYYY} cho phần đầu và phần cuối của chứng từ để xác định ngày, tháng, năm)";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(682, 525);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)lblNote);
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)cmdAdvanceConfig);
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		((Control)this).Name = "frmSIDMCTEdit";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdvanceConfig, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)GroupBox1, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbLine, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSave, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblNote, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)txtVn_width).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (AsiaErp.Framework.Environment.GetVoucherInformation(txtMa_ct.Text) == null)
		{
			((Control)cmdAdvanceConfig).Visible = false;
		}
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_ct;
		CreateDataBinding(ref ojb, "ma_ct");
		txtMa_ct = (TextBox)ojb;
		ojb = (Control)(object)txtMa_ct_me;
		CreateDataBinding(ref ojb, "ma_ct_me");
		txtMa_ct_me = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtPattern;
		CreateDataBinding(ref ojb, "vn_pattern");
		txtPattern = (TextBox)ojb;
		ojb = (Control)(object)txtPhan_he;
		CreateDataBinding(ref ojb, "phan_he");
		txtPhan_he = (TextBox)ojb;
		ojb = (Control)(object)txtPrefix;
		CreateDataBinding(ref ojb, "vn_prefix");
		txtPrefix = (TextBox)ojb;
		ojb = (Control)(object)txtSequence;
		CreateDataBinding(ref ojb, "vn_sequence");
		txtSequence = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtPostfix;
		CreateDataBinding(ref ojb, "vn_postfix");
		txtPostfix = (TextBox)ojb;
		ojb = (Control)(object)txtSo_lien;
		CreateDataBinding(ref ojb, "so_lien", "value");
		txtSo_lien = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSoTT_nkc;
		CreateDataBinding(ref ojb, "stt_nkc");
		txtSoTT_nkc = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSTT_NTXT;
		CreateDataBinding(ref ojb, "stt_ntxt");
		txtSTT_NTXT = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtTen_ct;
		CreateDataBinding(ref ojb, "ten_ct");
		txtTen_ct = (TextBox)ojb;
		ojb = (Control)(object)txtTen_tk_co;
		CreateDataBinding(ref ojb, "tk_co");
		txtTen_tk_co = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtTK_no;
		CreateDataBinding(ref ojb, "tk_no");
		txtTK_no = (AsTextBox)(object)ojb;
		ojb = (Control)(object)chkFilterByUser;
		CreateDataBinding(ref ojb, "loc_nsd", "Checked");
		chkFilterByUser = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkUse_ma_bo_phan;
		CreateDataBinding(ref ojb, "bp", "Checked");
		chkUse_ma_bo_phan = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkUse_ma_lo;
		CreateDataBinding(ref ojb, "lo", "Checked");
		chkUse_ma_lo = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkUse_ma_phi;
		CreateDataBinding(ref ojb, "phi", "Checked");
		chkUse_ma_phi = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkUse_Ma_spct;
		CreateDataBinding(ref ojb, "spct", "Checked");
		chkUse_Ma_spct = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkUse_ma_vu_viec;
		CreateDataBinding(ref ojb, "vv", "Checked");
		chkUse_ma_vu_viec = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)txtVn_width;
		CreateDataBinding(ref ojb, "Vn_width", "value");
		txtVn_width = (NumericUpDown)ojb;
		ojb = (Control)(object)cbo_kieu_trung_so_ct;
		CreateDataBinding(ref ojb, "kieu_trung_so_ct", "SelectedIndex");
		cbo_kieu_trung_so_ct = (AsComboBox)(object)ojb;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_ct).Enabled = false;
	}

	protected override bool SetToRow()
	{
		base.SetToRow();
		RowToEdit["loc_nsd"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Conversions.ToBoolean(chkFilterByUser.Checked), (object)1, (object)0));
		RowToEdit["bp"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Conversions.ToBoolean(chkUse_ma_bo_phan.Checked), (object)1, (object)0));
		RowToEdit["lo"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Conversions.ToBoolean(chkUse_ma_lo.Checked), (object)1, (object)0));
		RowToEdit["phi"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Conversions.ToBoolean(chkUse_ma_phi.Checked), (object)1, (object)0));
		RowToEdit["spct"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Conversions.ToBoolean(chkUse_Ma_spct.Checked), (object)1, (object)0));
		RowToEdit["vv"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Conversions.ToBoolean(chkUse_ma_vu_viec.Checked), (object)1, (object)0));
		return true;
	}

	protected override bool UpdateDB()
	{
		bool flag = base.UpdateDB();
		if (flag)
		{
			AsiaErp.Framework.Environment.RefreshSiDMCTByMa_Ct(txtMa_ct.Text);
		}
		return flag;
	}

	private void cmdAdvanceConfig_Click(object sender, EventArgs e)
	{
		UpdateVoucherResX();
	}

	private void txtVn_width_ValueChanged(object sender, EventArgs e)
	{
		PreviewSoct();
	}

	private void PreviewSoct()
	{
		DateTime now = DateAndTime.Now;
		string text = txtPrefix.Text.Trim();
		if (text.Contains("{"))
		{
			text = text.Replace("{DD}", now.Day.ToString().Trim().PadLeft(2, '0')).Replace("{MM}", now.Month.ToString().Trim().PadLeft(2, '0')).Replace("{YY}", now.Year.ToString().Trim().Remove(0, 2))
				.Replace("{YYYY}", now.Year.ToString().Trim());
		}
		string text2 = txtPostfix.Text.Trim();
		if (text2.Contains("{"))
		{
			text2 = text2.Replace("{DD}", now.Day.ToString().Trim().PadLeft(2, '0')).Replace("{MM}", now.Month.ToString().Trim().PadLeft(2, '0')).Replace("{YY}", now.Year.ToString().Trim().Remove(0, 2))
				.Replace("{YYYY}", now.Year.ToString().Trim());
		}
		int num = Convert.ToInt32(decimal.Subtract(decimal.Subtract(txtVn_width.Value, new decimal(text.Length)), new decimal(text2.Length)));
		if (num < 0)
		{
			num = 0;
		}
		txtVN.Text = text + Operators.AddObject(txtSequence.Value, (object)1).ToString().Trim()
			.PadLeft(num, Conversions.ToChar(txtPattern.Text.Trim())) + text2;
	}

	protected virtual void UpdateVoucherResX()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		frmVoucherUpdInfo frmVoucherUpdInfo2 = new frmVoucherUpdInfo();
		frmVoucherUpdInfo2.Ma_ct = txtMa_ct.Text;
		((Form)frmVoucherUpdInfo2).ShowDialog((IWin32Window)(object)this);
	}
}
