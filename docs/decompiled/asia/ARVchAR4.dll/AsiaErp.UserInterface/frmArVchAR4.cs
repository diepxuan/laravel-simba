using System;
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
public class frmArVchAR4 : frmVoucher
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("adgvDetail")]
	private AsInputDGV _adgvDetail;

	[AccessedThroughProperty("lblNgay_Lct")]
	private Label _lblNgay_Lct;

	[AccessedThroughProperty("txtNgay_lct")]
	private AsMaskedTextBox _txtNgay_lct;

	[AccessedThroughProperty("txtT_Tien")]
	private AsTextNumeric _txtT_Tien;

	[AccessedThroughProperty("lblT_Tien_Nt")]
	private Label _lblT_Tien_Nt;

	[AccessedThroughProperty("txtT_tien_Nt")]
	private AsTextNumeric _txtT_tien_Nt;

	[AccessedThroughProperty("DMNTInformationBindingSource")]
	private BindingSource _DMNTInformationBindingSource;

	[AccessedThroughProperty("AsCheckBox2")]
	private AsCheckBox _AsCheckBox2;

	[AccessedThroughProperty("txtTy_gia")]
	private AsTextNumeric _txtTy_gia;

	[AccessedThroughProperty("cboMa_NT")]
	private AsComboBoxNT _cboMa_NT;

	[AccessedThroughProperty("chkNt_Ph")]
	private AsCheckBox _chkNt_Ph;

	[AccessedThroughProperty("dgvcTk")]
	private DataGridViewAsTextBoxColumn _dgvcTk;

	[AccessedThroughProperty("dgvcTen_tk")]
	private DataGridViewTextBoxColumn _dgvcTen_tk;

	[AccessedThroughProperty("dgvcMa_kh")]
	private DataGridViewAsTextBoxColumn _dgvcMa_kh;

	[AccessedThroughProperty("dgvcTen_Kh")]
	private DataGridViewTextBoxColumn _dgvcTen_Kh;

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

	internal virtual AsTextNumeric txtT_Tien
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_Tien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_Tien = value;
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

	internal virtual AsTextNumeric txtT_tien_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tien_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tien_Nt = value;
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

	internal virtual DataGridViewTextBoxColumn dgvcTen_Kh
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_Kh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_Kh = value;
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

	public frmArVchAR4(string menuid)
		: base(menuid)
	{
		__ENCAddToList(this);
		f_sPs_no_header = "";
		f_sPs_co_header = "";
		InitializeComponent();
	}

	public frmArVchAR4(string MenuID, string Stt_rec)
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
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Expected O, but got Unknown
		//IL_141f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1429: Expected O, but got Unknown
		//IL_1527: Unknown result type (might be due to invalid IL or missing references)
		//IL_1531: Expected O, but got Unknown
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
		dgvcTen_Kh = new DataGridViewTextBoxColumn();
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
		txtT_Tien = new AsTextNumeric();
		txtT_tien_Nt = new AsTextNumeric();
		lblT_Tien_Nt = new Label();
		AsCheckBox2 = new AsCheckBox();
		cboMa_NT = new AsComboBoxNT();
		txtTy_gia = new AsTextNumeric();
		chkNt_Ph = new AsCheckBox();
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
		((Control)this).SuspendLayout();
		Button obj = cmdAdd;
		Point location = new Point(9, 409);
		((Control)obj).Location = location;
		Button obj2 = cmdPrint;
		location = new Point(79, 409);
		((Control)obj2).Location = location;
		Button obj3 = cmdLast;
		location = new Point(693, 409);
		((Control)obj3).Location = location;
		Button obj4 = cmdNext;
		location = new Point(670, 409);
		((Control)obj4).Location = location;
		Button obj5 = cmdPrevious;
		location = new Point(647, 409);
		((Control)obj5).Location = location;
		Button obj6 = cmdFirst;
		location = new Point(624, 409);
		((Control)obj6).Location = location;
		((Control)lblSo_Ct).Anchor = (AnchorStyles)7;
		Label obj7 = lblSo_Ct;
		location = new Point(6, 42);
		((Control)obj7).Location = location;
		((Control)lblNgay_Ct).Anchor = (AnchorStyles)7;
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
		location = new Point(542, 409);
		((Control)splitButton).Location = location;
		AsTabControl asTabControl = AsTabControl;
		location = new Point(6, 129);
		((Control)asTabControl).Location = location;
		AsTabControl asTabControl2 = AsTabControl;
		size = new Size(714, 248);
		((Control)asTabControl2).Size = size;
		((Control)tabDetail).Controls.Add((Control)(object)adgvDetail);
		TabPage obj10 = tabDetail;
		size = new Size(706, 219);
		((Control)obj10).Size = size;
		TabPage obj11 = tabOptFields;
		size = new Size(706, 219);
		((Control)obj11).Size = size;
		Button obj12 = cmdCopy;
		location = new Point(289, 409);
		((Control)obj12).Location = location;
		Button obj13 = cmdDelete;
		location = new Point(219, 409);
		((Control)obj13).Location = location;
		Button obj14 = cmdEdit;
		location = new Point(149, 409);
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
			(DataGridViewColumn)dgvcTen_Kh,
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
		size = new Size(700, 213);
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
		dgvcTk.LookupWhereCondition = "chi_tiet=1 and tk_cn=1";
		((DataGridViewColumn)dgvcTk).Name = "dgvcTk";
		dgvcTk.ReceiverValidFieldList = "ten_tk,tk_cn";
		dgvcTk.SD = true;
		dgvcTk.SortMode = (DataGridViewColumnSortMode)0;
		dgvcTk.ValidReturnFieldList = "ten_tk,tk_cn";
		((DataGridViewColumn)dgvcTk).Width = 70;
		((DataGridViewColumn)dgvcTen_tk).DataPropertyName = "ten_tk";
		((DataGridViewColumn)dgvcTen_tk).HeaderText = "Tên tài khoản";
		((DataGridViewColumn)dgvcTen_tk).Name = "dgvcTen_tk";
		((DataGridViewColumn)dgvcTen_tk).ReadOnly = true;
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
		((DataGridViewColumn)dgvcTen_Kh).DataPropertyName = "ten_kh";
		((DataGridViewColumn)dgvcTen_Kh).HeaderText = "Tên khách";
		((DataGridViewColumn)dgvcTen_Kh).Name = "dgvcTen_Kh";
		((DataGridViewColumn)dgvcTen_Kh).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_Kh).Width = 150;
		((DataGridViewColumn)dgvcMa_nt).DataPropertyName = "ma_nt";
		dgvcMa_nt.DataSource = DMNTInformationBindingSource;
		dgvcMa_nt.DisplayMember = "ma_nt";
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
		val7.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_no).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcPs_no).HeaderText = "Ps nợ VNĐ";
		dgvcPs_no.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_no).Name = "dgvcPs_no";
		((DataGridViewColumn)dgvcPs_no).Resizable = (DataGridViewTriState)1;
		dgvcPs_no.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcPs_co).DataPropertyName = "ps_co";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcPs_co).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcPs_co).HeaderText = "Ps có VNĐ";
		dgvcPs_co.Mask = "### ### ### ###.##";
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
		((Control)lblNgay_Lct).Anchor = (AnchorStyles)7;
		lblNgay_Lct.ImeMode = (ImeMode)0;
		Label obj16 = lblNgay_Lct;
		location = new Point(6, 67);
		((Control)obj16).Location = location;
		((Control)lblNgay_Lct).Name = "lblNgay_Lct";
		Label obj17 = lblNgay_Lct;
		size = new Size(56, 15);
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
		((Control)txtT_Tien).Anchor = (AnchorStyles)2;
		txtT_Tien.DecimalSymbol = ".";
		((Control)txtT_Tien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric = txtT_Tien;
		location = new Point(621, 383);
		((Control)asTextNumeric).Location = location;
		txtT_Tien.Mask = "### ### ### ###";
		((Control)txtT_Tien).Name = "txtT_Tien";
		((TextBoxBase)txtT_Tien).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtT_Tien;
		size = new Size(95, 20);
		((Control)asTextNumeric2).Size = size;
		txtT_Tien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)txtT_Tien).TabIndex = 223;
		((Control)txtT_Tien).TabStop = false;
		((TextBox)txtT_Tien).Text = "0";
		((TextBox)txtT_Tien).TextAlign = (HorizontalAlignment)1;
		txtT_Tien.Value = 0.0;
		((Control)txtT_tien_Nt).Anchor = (AnchorStyles)2;
		txtT_tien_Nt.DecimalSymbol = ".";
		((Control)txtT_tien_Nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric3 = txtT_tien_Nt;
		location = new Point(520, 383);
		((Control)asTextNumeric3).Location = location;
		txtT_tien_Nt.Mask = "### ### ### ###.##";
		((Control)txtT_tien_Nt).Name = "txtT_tien_Nt";
		((TextBoxBase)txtT_tien_Nt).ReadOnly = true;
		AsTextNumeric asTextNumeric4 = txtT_tien_Nt;
		size = new Size(95, 20);
		((Control)asTextNumeric4).Size = size;
		txtT_tien_Nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((Control)txtT_tien_Nt).TabIndex = 10;
		((Control)txtT_tien_Nt).TabStop = false;
		((TextBox)txtT_tien_Nt).Text = "0.00";
		((TextBox)txtT_tien_Nt).TextAlign = (HorizontalAlignment)1;
		txtT_tien_Nt.Value = 0.0;
		((Control)lblT_Tien_Nt).Anchor = (AnchorStyles)2;
		lblT_Tien_Nt.AutoSize = true;
		lblT_Tien_Nt.ImeMode = (ImeMode)0;
		Label obj18 = lblT_Tien_Nt;
		location = new Point(449, 386);
		((Control)obj18).Location = location;
		((Control)lblT_Tien_Nt).Name = "lblT_Tien_Nt";
		Label obj19 = lblT_Tien_Nt;
		size = new Size(52, 13);
		((Control)obj19).Size = size;
		((Control)lblT_Tien_Nt).TabIndex = 227;
		lblT_Tien_Nt.Text = "Tổng tiền";
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
		size = new Size(725, 459);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtT_Tien);
		((Control)this).Controls.Add((Control)(object)lblT_Tien_Nt);
		((Control)this).Controls.Add((Control)(object)txtT_tien_Nt);
		dgvDetail = adgvDetail;
		((Control)this).Name = "frmArVchAR4";
		((Form)this).Text = "frmArVchAR4";
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDelete, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCopy, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_tien_Nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblT_Tien_Nt, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtT_Tien, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdNext, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrevious, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdFirst, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdLast, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbPH, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)AsTabControl, 0);
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
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void chkNt_Ph_CheckedChanged(object sender, EventArgs e)
	{
		if (!IsLoading)
		{
			RefreshCtrlWhenChkNt_PhChange();
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
			foreach (DataRowView item in CT1Voucher)
			{
				item["ma_nt"] = cboMa_NT.MA_NT;
				if (ActionMode == Commons.ApplicationMode.ADD_MODE)
				{
					V_Ma_Nt(item);
				}
			}
		}
		RefreshDGVInput();
		if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			RefreshValueByMa_Nt();
		}
	}

	private void txtTy_gia_Validated(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		if (((base.IsLoading || base.ActionMode == Commons.ApplicationMode.VIEW_MODE || IsValidateCalledFromValidData) ? true : false) || (int)((CheckBox)chkNt_Ph).CheckState != 1 || CT1Voucher == null || 1 == 0)
		{
			return;
		}
		foreach (DataRowView item in CT1Voucher)
		{
			item["ty_gia"] = RuntimeHelpers.GetObjectValue(txtTy_gia.Value);
			V_Ty_gia(item);
		}
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
		else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcPs_co).Name, false) == 0)
		{
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				currentCell.ReadOnly = !W_Ps_Co(dataRowView);
			}
		}
		else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcPs_no).Name, false) == 0)
		{
			if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
			{
				currentCell.ReadOnly = !W_Ps_No(dataRowView);
			}
		}
		else if (Operators.CompareString(name, ((DataGridViewColumn)dgvcMa_bp).Name, false) == 0)
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

	private void cmdPhan_bo_hd_Click(object sender, EventArgs e)
	{
	}

	private void V_Ma_Nt(DataRowView oDv)
	{
		if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_nt"]), isNum: false), (object)AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false))
		{
			oDv["ty_gia"] = 1;
		}
		else if (ActionMode == Commons.ApplicationMode.ADD_MODE)
		{
			oDv["ty_gia"] = Commons.Get_TyGia(Conversions.ToString(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(oDv["ma_nt"]), isNum: false)), Conversions.ToDate(txtNgay_Ct.Value));
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
		return true;
	}

	private bool W_Ps_Co(DataRowView oDv)
	{
		return true;
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

	protected void RefreshCtrlWhenChkNt_PhChange()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		if ((int)((CheckBox)chkNt_Ph).CheckState == 1)
		{
			((Control)cboMa_NT).Enabled = base.ActionMode != Commons.ApplicationMode.VIEW_MODE;
			((Control)txtTy_gia).Enabled = base.ActionMode != Commons.ApplicationMode.VIEW_MODE;
			((DataGridViewColumn)dgvcMa_nt).Visible = false;
			((DataGridViewColumn)dgvcTy_gia).Visible = false;
		}
		else
		{
			((DataGridViewColumn)dgvcMa_nt).Visible = true;
			((DataGridViewColumn)dgvcTy_gia).Visible = true;
			((Control)cboMa_NT).Enabled = false;
			((Control)txtTy_gia).Enabled = false;
		}
		RefreshDGVInput();
	}

	private void RefreshValueByMa_Nt()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		if (IsLoading || base.CT1Voucher == null || false || Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) != 0 || (int)((CheckBox)chkNt_Ph).CheckState != 1 || 1 == 0)
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
			string mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
			if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				((DataGridViewColumn)dgvcPs_no).Visible = false;
				((DataGridViewColumn)dgvcPs_co).Visible = false;
				((Control)txtT_Tien).Visible = false;
				txtTy_gia.Value = 1;
				((TextBoxBase)txtTy_gia).ReadOnly = true;
				((Control)txtTy_gia).TabStop = false;
				if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
				{
					txtTy_gia_Validated(null, null);
				}
			}
			else
			{
				mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
				((TextBoxBase)txtTy_gia).ReadOnly = ActionMode == Commons.ApplicationMode.VIEW_MODE;
				((Control)txtTy_gia).TabStop = true;
				if (ActionMode != Commons.ApplicationMode.VIEW_MODE)
				{
					txtTy_gia.Value = Commons.Get_TyGia(cboMa_NT.MA_NT, Conversions.ToDate(txtNgay_Ct.Value));
					txtTy_gia_Validated(null, null);
				}
				((DataGridViewColumn)dgvcPs_no).Visible = true;
				((DataGridViewColumn)dgvcPs_co).Visible = true;
				((Control)txtT_Tien).Visible = true;
			}
			dgvcPs_no_nt.Mask = mask;
			dgvcPs_co_nt.Mask = mask;
		}
		else
		{
			((DataGridViewColumn)dgvcPs_no).Visible = true;
			((DataGridViewColumn)dgvcPs_co).Visible = true;
			((Control)txtT_Tien).Visible = true;
			((DataGridViewColumn)dgvcPs_co_nt).HeaderText = f_sPs_co_header + " NT";
			((DataGridViewColumn)dgvcPs_no_nt).HeaderText = f_sPs_no_header + " NT";
			dgvcPs_no_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			dgvcPs_co_nt.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format;
			dgvcPs_no.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
			dgvcPs_co.Mask = AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format;
		}
	}

	protected override void UpdateList()
	{
		if (CurrentPHRow != null)
		{
			txtT_tien_Nt.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(ps_co_nt)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", base.CurrentPHRow["Stt_Rec"]), (object)"'"))));
			txtT_Tien.Value = RuntimeHelpers.GetObjectValue(CTTable.Compute("Sum(ps_co)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", base.CurrentPHRow["Stt_Rec"]), (object)"'"))));
		}
	}

	protected override bool ValidData()
	{
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		bool flag2 = false;
		checked
		{
			if (base.ValidData())
			{
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
		CreateDataBinding((Control)(object)txtT_tien_Nt, "t_tien_nt", "Value");
		CreateDataBinding((Control)(object)txtT_Tien, "t_tien", "Value");
	}

	protected override void Refresh_controls()
	{
		base.Refresh_controls();
		chkNt_Ph_CheckedChanged(null, null);
		if (base.ActionMode != Commons.ApplicationMode.VIEW_MODE)
		{
			if (Operators.CompareString(cboMa_NT.MA_NT, AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0, false) == 0)
			{
				txtTy_gia.Value = 1;
				((TextBoxBase)txtTy_gia).ReadOnly = true;
				((Control)txtTy_gia).TabStop = false;
			}
			else
			{
				((TextBoxBase)txtTy_gia).ReadOnly = false;
				((Control)txtTy_gia).TabStop = true;
			}
		}
	}

	protected override void InitOtherBeforeLoadData()
	{
		base.InitOtherBeforeLoadData();
		f_sPs_co_header = ((DataGridViewColumn)dgvcPs_co_nt).HeaderText;
		f_sPs_no_header = ((DataGridViewColumn)dgvcPs_no_nt).HeaderText;
		DMNTInformationBindingSource.DataSource = AsiaErp.Framework.Environment.GetDMNT();
	}

	protected override void InitOtherAfterLoadData()
	{
		base.InitOtherAfterLoadData();
		base.PHTable.Columns["nt_ph"].DefaultValue = true;
		base.CTTable.Columns["ma_nt"].DefaultValue = MyVoucherInfo.ma_nt_default;
		base.CTTable.Columns["ty_gia"].DefaultValue = 1;
		base.CTTable.Columns["nh_dk"].DefaultValue = "1";
		((DataGridViewColumn)dgvcPs_co).HeaderText = f_sPs_co_header + " " + AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		((DataGridViewColumn)dgvcPs_no).HeaderText = f_sPs_no_header + " " + AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0;
		AddAsTextNumeric2ListOfMaskDependOn_MA_NT(txtT_tien_Nt);
	}

	protected override void InsertDetail(bool isAutoAdded = false)
	{
		base.InsertDetail(isAutoAdded);
		if (isAutoAdded)
		{
			return;
		}
		string filter = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_Rec='", base.CurrentPHRow["stt_rec"]), (object)"'"));
		double num = Conversions.ToDouble(Operators.SubtractObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(Ps_No)", filter)), isNum: true), Helper.Repl_Null(RuntimeHelpers.GetObjectValue(base.CTTable.Compute("sum(Ps_Co)", filter)), isNum: true)));
		DataRowView dataRowView = base.CT1Voucher[((DataGridViewBand)((DataGridView)adgvDetail).CurrentRow).Index];
		int num2 = Conversions.ToInteger(Interaction.IIf(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_nt"]), isNum: false).Equals(AsiaErp.Framework.Environment.GetSIConfiguration().ma_nt0), (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round, (object)AsiaErp.Framework.Environment.GetSIConfiguration().Round_Nt));
		if (num < 0.0)
		{
			dataRowView["Ps_No"] = 0.0 - num;
			Type? typeFromHandle = typeof(Math);
			object[] array = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_no"]), isNum: true), Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ty_gia"]), isNum: true), (object)0, false), RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ty_gia"]), isNum: true)), (object)1)),
				num2,
				MidpointRounding.AwayFromZero
			};
			object[] array2 = array;
			bool[] array3 = new bool[3] { false, true, false };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Round", array2, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			dataRowView["Ps_No_Nt"] = RuntimeHelpers.GetObjectValue(obj);
		}
		else
		{
			dataRowView["Ps_Co"] = num;
			Type? typeFromHandle2 = typeof(Math);
			object[] array4 = new object[3]
			{
				Operators.DivideObject(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["Ps_Co"]), isNum: true), Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ty_gia"]), isNum: true), (object)0, false), RuntimeHelpers.GetObjectValue(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ty_gia"]), isNum: true)), (object)1)),
				num2,
				MidpointRounding.AwayFromZero
			};
			object[] array5 = array4;
			bool[] array3 = new bool[3] { false, true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "Round", array5, (string[])null, (Type[])null, array3);
			if (array3[1])
			{
				num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
			}
			dataRowView["Ps_Co_Nt"] = RuntimeHelpers.GetObjectValue(obj2);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	protected DataRow _0024VB_0024ClosureStub_get_CurrentPHRow_MyBase()
	{
		return base.CurrentPHRow;
	}
}
