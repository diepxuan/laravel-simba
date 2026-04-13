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
public class frmPOVchPO1SeachPO0 : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("dgvPh")]
	private AsDataGridView _dgvPh;

	[AccessedThroughProperty("dgvCt")]
	private AsDataGridView _dgvCt;

	[AccessedThroughProperty("tsslCountlbl")]
	private ToolStripStatusLabel _tsslCountlbl;

	[AccessedThroughProperty("tsslOther")]
	private ToolStripStatusLabel _tsslOther;

	[AccessedThroughProperty("tsslCount")]
	private ToolStripStatusLabel _tsslCount;

	[AccessedThroughProperty("stsVoucherView")]
	private StatusStrip _stsVoucherView;

	[AccessedThroughProperty("SplitContainer1")]
	private SplitContainer _SplitContainer1;

	[AccessedThroughProperty("cmdChon")]
	private Button _cmdChon;

	[AccessedThroughProperty("dgvcChon")]
	private DataGridViewCheckBoxColumn _dgvcChon;

	[AccessedThroughProperty("dgvcNgay_ct")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcNgay_ct;

	[AccessedThroughProperty("dgvcSo_ct")]
	private DataGridViewTextBoxColumn _dgvcSo_ct;

	[AccessedThroughProperty("dgvcNguoi_gd")]
	private DataGridViewTextBoxColumn _dgvcNguoi_gd;

	[AccessedThroughProperty("dgvcTen_kh")]
	private DataGridViewTextBoxColumn _dgvcTen_kh;

	[AccessedThroughProperty("dgvcMa_hd")]
	private DataGridViewTextBoxColumn _dgvcMa_hd;

	[AccessedThroughProperty("dgvcChonCt")]
	private DataGridViewCheckBoxColumn _dgvcChonCt;

	[AccessedThroughProperty("dgvcMa_vt")]
	private DataGridViewTextBoxColumn _dgvcMa_vt;

	[AccessedThroughProperty("dgvcTen_vt")]
	private DataGridViewTextBoxColumn _dgvcTen_vt;

	[AccessedThroughProperty("dgvcDvt")]
	private DataGridViewTextBoxColumn _dgvcDvt;

	[AccessedThroughProperty("dgvcMa_kho")]
	private DataGridViewTextBoxColumn _dgvcMa_kho;

	[AccessedThroughProperty("dgvcSo_luong")]
	private DataGridViewAsTextNumericColumn _dgvcSo_luong;

	[AccessedThroughProperty("dgvcSl_nhap")]
	private DataGridViewAsTextNumericColumn _dgvcSl_nhap;

	[AccessedThroughProperty("dgvcSl_ton")]
	private DataGridViewAsTextNumericColumn _dgvcSl_ton;

	[AccessedThroughProperty("dgvcVitri")]
	private DataGridViewTextBoxColumn _dgvcVitri;

	[AccessedThroughProperty("dgvcMa_lo")]
	private DataGridViewTextBoxColumn _dgvcMa_lo;

	[AccessedThroughProperty("dgvcMa_phi")]
	private DataGridViewTextBoxColumn _dgvcMa_phi;

	[AccessedThroughProperty("dgvcMa_spct")]
	private DataGridViewTextBoxColumn _dgvcMa_spct;

	private DataTable f_oTblPh;

	private DataTable f_oTblCt;

	private int f_iCurPost;

	private VoucherInformation f_vInfo;

	internal virtual AsDataGridView dgvPh
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvPh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(dgvPh_CellValueChanged);
			EventHandler eventHandler = dgvPh_CurrentCellChanged;
			if (_dgvPh != null)
			{
				((DataGridView)_dgvPh).CellValueChanged -= val;
				((DataGridView)_dgvPh).CurrentCellChanged -= eventHandler;
			}
			_dgvPh = value;
			if (_dgvPh != null)
			{
				((DataGridView)_dgvPh).CellValueChanged += val;
				((DataGridView)_dgvPh).CurrentCellChanged += eventHandler;
			}
		}
	}

	internal virtual AsDataGridView dgvCt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvCt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(dgvCt_CellValueChanged);
			if (_dgvCt != null)
			{
				((DataGridView)_dgvCt).CellValueChanged -= val;
			}
			_dgvCt = value;
			if (_dgvCt != null)
			{
				((DataGridView)_dgvCt).CellValueChanged += val;
			}
		}
	}

	internal virtual ToolStripStatusLabel tsslCountlbl
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsslCountlbl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tsslCountlbl = value;
		}
	}

	internal virtual ToolStripStatusLabel tsslOther
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsslOther;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tsslOther = value;
		}
	}

	internal virtual ToolStripStatusLabel tsslCount
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsslCount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tsslCount = value;
		}
	}

	protected internal virtual StatusStrip stsVoucherView
	{
		[DebuggerNonUserCode]
		get
		{
			return _stsVoucherView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_stsVoucherView = value;
		}
	}

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

	internal virtual Button cmdChon
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdChon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmdChon = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcChon
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcChon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcChon = value;
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

	internal virtual DataGridViewTextBoxColumn dgvcMa_hd
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

	internal virtual DataGridViewCheckBoxColumn dgvcChonCt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcChonCt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcChonCt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_vt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTen_vt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_vt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_vt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcDvt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDvt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDvt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_kho
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_kho;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_kho = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcSo_luong
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_luong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_luong = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcSl_nhap
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSl_nhap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSl_nhap = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcSl_ton
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSl_ton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSl_ton = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcVitri
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcVitri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcVitri = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_lo
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_lo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_lo = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcMa_phi
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

	internal virtual DataGridViewTextBoxColumn dgvcMa_spct
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

	public VoucherInformation MyVoucherInfo
	{
		get
		{
			return f_vInfo;
		}
		set
		{
			f_vInfo = value;
		}
	}

	public int CurrentPosition
	{
		get
		{
			return f_iCurPost;
		}
		set
		{
			f_iCurPost = value;
		}
	}

	public DataTable PHTable
	{
		get
		{
			return f_oTblPh;
		}
		set
		{
			f_oTblPh = value;
		}
	}

	public DataTable CTTable
	{
		get
		{
			return f_oTblCt;
		}
		set
		{
			f_oTblCt = value;
		}
	}

	public frmPOVchPO1SeachPO0()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmVoucherView_KeyDown);
		((Form)this).Load += frmVoucherView_Load;
		__ENCAddToList(this);
		f_iCurPost = 0;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected O, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected O, but got Unknown
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmPOVchPO1SeachPO0));
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		dgvPh = new AsDataGridView();
		dgvcChon = new DataGridViewCheckBoxColumn();
		dgvcNgay_ct = new DataGridViewAsMaskedTextBoxColumn();
		dgvcSo_ct = new DataGridViewTextBoxColumn();
		dgvcNguoi_gd = new DataGridViewTextBoxColumn();
		dgvcTen_kh = new DataGridViewTextBoxColumn();
		dgvcMa_hd = new DataGridViewTextBoxColumn();
		dgvCt = new AsDataGridView();
		stsVoucherView = new StatusStrip();
		tsslCountlbl = new ToolStripStatusLabel();
		tsslCount = new ToolStripStatusLabel();
		tsslOther = new ToolStripStatusLabel();
		SplitContainer1 = new SplitContainer();
		cmdChon = new Button();
		dgvcChonCt = new DataGridViewCheckBoxColumn();
		dgvcMa_vt = new DataGridViewTextBoxColumn();
		dgvcTen_vt = new DataGridViewTextBoxColumn();
		dgvcDvt = new DataGridViewTextBoxColumn();
		dgvcMa_kho = new DataGridViewTextBoxColumn();
		dgvcSo_luong = new DataGridViewAsTextNumericColumn();
		dgvcSl_nhap = new DataGridViewAsTextNumericColumn();
		dgvcSl_ton = new DataGridViewAsTextNumericColumn();
		dgvcVitri = new DataGridViewTextBoxColumn();
		dgvcMa_lo = new DataGridViewTextBoxColumn();
		dgvcMa_phi = new DataGridViewTextBoxColumn();
		dgvcMa_spct = new DataGridViewTextBoxColumn();
		((ISupportInitialize)dgvPh).BeginInit();
		((ISupportInitialize)dgvCt).BeginInit();
		((Control)stsVoucherView).SuspendLayout();
		((Control)SplitContainer1.Panel1).SuspendLayout();
		((Control)SplitContainer1.Panel2).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((Control)this).SuspendLayout();
		((DataGridView)dgvPh).AllowUserToAddRows = false;
		((DataGridView)dgvPh).AllowUserToDeleteRows = false;
		((DataGridView)dgvPh).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvPh).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvPh).ColumnHeadersHeight = 20;
		((DataGridView)dgvPh).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)1;
		((DataGridView)dgvPh).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)dgvcChon,
			dgvcNgay_ct,
			(DataGridViewColumn)dgvcSo_ct,
			(DataGridViewColumn)dgvcNguoi_gd,
			(DataGridViewColumn)dgvcTen_kh,
			(DataGridViewColumn)dgvcMa_hd
		});
		((Control)dgvPh).Dock = (DockStyle)5;
		dgvPh.DoubleBuffered = false;
		((DataGridView)dgvPh).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvPh).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvPh;
		Point location = new Point(0, 0);
		((Control)asDataGridView).Location = location;
		((Control)dgvPh).Name = "dgvPh";
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		((DataGridView)dgvPh).RowHeadersDefaultCellStyle = val;
		dgvPh.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvPh).RowTemplate.Height = 18;
		AsDataGridView asDataGridView2 = dgvPh;
		Size size = new Size(682, 228);
		((Control)asDataGridView2).Size = size;
		((Control)dgvPh).TabIndex = 0;
		((DataGridViewColumn)dgvcChon).DataPropertyName = "chon";
		((DataGridViewColumn)dgvcChon).HeaderText = "Chọn";
		((DataGridViewColumn)dgvcChon).Name = "dgvcChon";
		((DataGridViewColumn)dgvcChon).Width = 40;
		((DataGridViewColumn)dgvcNgay_ct).DataPropertyName = "ngay_ct";
		val2.Alignment = (DataGridViewContentAlignment)64;
		val2.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct).DefaultCellStyle = val2;
		dgvcNgay_ct.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct).HeaderText = "Ngày đ nghị";
		dgvcNgay_ct.Mask = "##/##/####";
		((DataGridViewColumn)dgvcNgay_ct).Name = "dgvcNgay_ct";
		((DataGridViewColumn)dgvcNgay_ct).ReadOnly = true;
		dgvcNgay_ct.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcNgay_ct).Width = 75;
		((DataGridViewColumn)dgvcSo_ct).DataPropertyName = "so_ct";
		((DataGridViewColumn)dgvcSo_ct).HeaderText = "Số phiếu";
		((DataGridViewColumn)dgvcSo_ct).Name = "dgvcSo_ct";
		((DataGridViewColumn)dgvcSo_ct).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_ct).Width = 65;
		((DataGridViewColumn)dgvcNguoi_gd).DataPropertyName = "nguoi_gd";
		((DataGridViewColumn)dgvcNguoi_gd).HeaderText = "BP đề nghị";
		((DataGridViewColumn)dgvcNguoi_gd).Name = "dgvcNguoi_gd";
		((DataGridViewColumn)dgvcNguoi_gd).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_kh).DataPropertyName = "ten_kh";
		((DataGridViewColumn)dgvcTen_kh).HeaderText = "Diễn giải";
		((DataGridViewColumn)dgvcTen_kh).Name = "dgvcTen_kh";
		((DataGridViewColumn)dgvcTen_kh).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_kh).Width = 180;
		((DataGridViewColumn)dgvcMa_hd).DataPropertyName = "ma_hd";
		((DataGridViewColumn)dgvcMa_hd).HeaderText = "Hợp đồng";
		((DataGridViewColumn)dgvcMa_hd).Name = "dgvcMa_hd";
		((DataGridViewColumn)dgvcMa_hd).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_hd).Width = 70;
		((DataGridView)dgvCt).AllowUserToAddRows = false;
		((DataGridView)dgvCt).AllowUserToDeleteRows = false;
		((DataGridView)dgvCt).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvCt).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvCt).ColumnHeadersHeight = 20;
		((DataGridView)dgvCt).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)1;
		((DataGridView)dgvCt).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[12]
		{
			(DataGridViewColumn)dgvcChonCt,
			(DataGridViewColumn)dgvcMa_vt,
			(DataGridViewColumn)dgvcTen_vt,
			(DataGridViewColumn)dgvcDvt,
			(DataGridViewColumn)dgvcMa_kho,
			dgvcSo_luong,
			dgvcSl_nhap,
			dgvcSl_ton,
			(DataGridViewColumn)dgvcVitri,
			(DataGridViewColumn)dgvcMa_lo,
			(DataGridViewColumn)dgvcMa_phi,
			(DataGridViewColumn)dgvcMa_spct
		});
		((Control)dgvCt).Dock = (DockStyle)5;
		dgvCt.DoubleBuffered = false;
		((DataGridView)dgvCt).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvCt).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView3 = dgvCt;
		location = new Point(0, 0);
		((Control)asDataGridView3).Location = location;
		((Control)dgvCt).Name = "dgvCt";
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		((DataGridView)dgvCt).RowHeadersDefaultCellStyle = val3;
		dgvCt.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvCt).RowTemplate.Height = 18;
		AsDataGridView asDataGridView4 = dgvCt;
		size = new Size(682, 143);
		((Control)asDataGridView4).Size = size;
		((Control)dgvCt).TabIndex = 1;
		((ToolStrip)stsVoucherView).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)tsslCountlbl,
			(ToolStripItem)tsslCount,
			(ToolStripItem)tsslOther
		});
		StatusStrip obj = stsVoucherView;
		location = new Point(0, 407);
		((Control)obj).Location = location;
		((Control)stsVoucherView).Name = "stsVoucherView";
		StatusStrip obj2 = stsVoucherView;
		size = new Size(682, 22);
		((Control)obj2).Size = size;
		stsVoucherView.SizingGrip = false;
		((Control)stsVoucherView).TabIndex = 2;
		((Control)stsVoucherView).Text = "stsVoucherView";
		((ToolStripItem)tsslCountlbl).Image = (Image)componentResourceManager.GetObject("tsslCountlbl.Image");
		((ToolStripItem)tsslCountlbl).Name = "tsslCountlbl";
		ToolStripStatusLabel obj3 = tsslCountlbl;
		size = new Size(120, 17);
		((ToolStripItem)obj3).Size = size;
		((ToolStripItem)tsslCountlbl).Text = "Tổng số chứng từ:";
		((ToolStripItem)tsslCount).AutoSize = false;
		tsslCount.BorderSides = (ToolStripStatusLabelBorderSides)4;
		tsslCount.BorderStyle = (Border3DStyle)6;
		((ToolStripItem)tsslCount).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ToolStripItem)tsslCount).Name = "tsslCount";
		ToolStripStatusLabel obj4 = tsslCount;
		size = new Size(40, 17);
		((ToolStripItem)obj4).Size = size;
		((ToolStripItem)tsslCount).Text = "0";
		((ToolStripItem)tsslCount).TextAlign = (ContentAlignment)16;
		((ToolStripItem)tsslOther).AutoSize = false;
		((ToolStripItem)tsslOther).Name = "tsslOther";
		ToolStripStatusLabel obj5 = tsslOther;
		size = new Size(100, 17);
		((ToolStripItem)obj5).Size = size;
		((Control)SplitContainer1).Anchor = (AnchorStyles)15;
		SplitContainer splitContainer = SplitContainer1;
		location = new Point(0, 0);
		((Control)splitContainer).Location = location;
		((Control)SplitContainer1).Name = "SplitContainer1";
		SplitContainer1.Orientation = (Orientation)0;
		((Control)SplitContainer1.Panel1).Controls.Add((Control)(object)dgvPh);
		((Control)SplitContainer1.Panel2).Controls.Add((Control)(object)dgvCt);
		SplitContainer splitContainer2 = SplitContainer1;
		size = new Size(682, 375);
		((Control)splitContainer2).Size = size;
		SplitContainer1.SplitterDistance = 228;
		((Control)SplitContainer1).TabIndex = 3;
		cmdChon.DialogResult = (DialogResult)1;
		Button obj6 = cmdChon;
		location = new Point(607, 381);
		((Control)obj6).Location = location;
		((Control)cmdChon).Name = "cmdChon";
		Button obj7 = cmdChon;
		size = new Size(75, 23);
		((Control)obj7).Size = size;
		((Control)cmdChon).TabIndex = 4;
		((ButtonBase)cmdChon).Text = "&Chọn";
		((ButtonBase)cmdChon).UseVisualStyleBackColor = true;
		((DataGridViewColumn)dgvcChonCt).DataPropertyName = "chon";
		((DataGridViewColumn)dgvcChonCt).HeaderText = "Chọn";
		((DataGridViewColumn)dgvcChonCt).Name = "dgvcChonCt";
		((DataGridViewColumn)dgvcChonCt).Width = 50;
		((DataGridViewColumn)dgvcMa_vt).DataPropertyName = "ma_vt";
		((DataGridViewColumn)dgvcMa_vt).HeaderText = "Mã Vt";
		((DataGridViewColumn)dgvcMa_vt).Name = "dgvcMa_vt";
		((DataGridViewColumn)dgvcMa_vt).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_vt).Width = 70;
		((DataGridViewColumn)dgvcTen_vt).DataPropertyName = "ten_vt";
		((DataGridViewColumn)dgvcTen_vt).HeaderText = "Tên vật tư";
		((DataGridViewColumn)dgvcTen_vt).Name = "dgvcTen_vt";
		((DataGridViewColumn)dgvcTen_vt).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_vt).Width = 150;
		((DataGridViewColumn)dgvcDvt).DataPropertyName = "dvt";
		((DataGridViewColumn)dgvcDvt).HeaderText = "ĐVT";
		((DataGridViewColumn)dgvcDvt).Name = "dgvcDvt";
		((DataGridViewColumn)dgvcDvt).ReadOnly = true;
		((DataGridViewColumn)dgvcDvt).Width = 40;
		((DataGridViewColumn)dgvcMa_kho).DataPropertyName = "ma_kho";
		((DataGridViewColumn)dgvcMa_kho).HeaderText = "Mã kho";
		((DataGridViewColumn)dgvcMa_kho).Name = "dgvcMa_kho";
		((DataGridViewColumn)dgvcMa_kho).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_kho).Width = 65;
		((DataGridViewColumn)dgvcSo_luong).DataPropertyName = "so_luong";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcSo_luong).HeaderText = "Số lượng";
		dgvcSo_luong.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSo_luong).Name = "dgvcSo_luong";
		((DataGridViewColumn)dgvcSo_luong).ReadOnly = true;
		dgvcSo_luong.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSo_luong.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcSo_luong).Width = 70;
		((DataGridViewColumn)dgvcSl_nhap).DataPropertyName = "sl_dh";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSl_nhap).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcSl_nhap).HeaderText = "Đã lập";
		dgvcSl_nhap.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSl_nhap).Name = "dgvcSl_nhap";
		((DataGridViewColumn)dgvcSl_nhap).ReadOnly = true;
		dgvcSl_nhap.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSl_nhap.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcSl_nhap).Width = 70;
		((DataGridViewColumn)dgvcSl_ton).DataPropertyName = "sl_ton";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSl_ton).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcSl_ton).HeaderText = "Còn tồn";
		dgvcSl_ton.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcSl_ton).Name = "dgvcSl_ton";
		((DataGridViewColumn)dgvcSl_ton).ReadOnly = true;
		dgvcSl_ton.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSl_ton.SpecialType = Commons.NumericSpecialType.Quantity;
		((DataGridViewColumn)dgvcSl_ton).Width = 70;
		((DataGridViewColumn)dgvcVitri).DataPropertyName = "ma_vitri";
		((DataGridViewColumn)dgvcVitri).HeaderText = "Vị trí";
		((DataGridViewColumn)dgvcVitri).Name = "dgvcVitri";
		((DataGridViewColumn)dgvcVitri).ReadOnly = true;
		((DataGridViewColumn)dgvcVitri).Width = 60;
		((DataGridViewColumn)dgvcMa_lo).DataPropertyName = "ma_lo";
		((DataGridViewColumn)dgvcMa_lo).HeaderText = "Lô";
		((DataGridViewColumn)dgvcMa_lo).Name = "dgvcMa_lo";
		((DataGridViewColumn)dgvcMa_lo).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_lo).Width = 70;
		((DataGridViewColumn)dgvcMa_phi).DataPropertyName = "ma_phi";
		((DataGridViewColumn)dgvcMa_phi).HeaderText = "Phí";
		((DataGridViewColumn)dgvcMa_phi).Name = "dgvcMa_phi";
		((DataGridViewColumn)dgvcMa_phi).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_phi).Width = 60;
		((DataGridViewColumn)dgvcMa_spct).DataPropertyName = "ma_spct";
		((DataGridViewColumn)dgvcMa_spct).HeaderText = "SPCT";
		((DataGridViewColumn)dgvcMa_spct).Name = "dgvcMa_spct";
		((DataGridViewColumn)dgvcMa_spct).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_spct).Width = 60;
		((Form)this).AcceptButton = (IButtonControl)(object)cmdChon;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(682, 429);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdChon);
		((Control)this).Controls.Add((Control)(object)SplitContainer1);
		((Control)this).Controls.Add((Control)(object)stsVoucherView);
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmPOVchPO1SeachPO0";
		((Form)this).ShowInTaskbar = false;
		((Form)this).Text = "Chọn phiếu đề nghị";
		((ISupportInitialize)dgvPh).EndInit();
		((ISupportInitialize)dgvCt).EndInit();
		((Control)stsVoucherView).ResumeLayout(false);
		((Control)stsVoucherView).PerformLayout();
		((Control)SplitContainer1.Panel1).ResumeLayout(false);
		((Control)SplitContainer1.Panel2).ResumeLayout(false);
		((Control)SplitContainer1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmVoucherView_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}

	private void frmVoucherView_Load(object sender, EventArgs e)
	{
		if (!((Component)(object)this).DesignMode)
		{
			dgvPh.DataSource = PHTable.DefaultView;
			dgvCt.DataSource = CTTable.DefaultView;
			FilterCt();
			SetStatusBar();
		}
	}

	private void dgvPh_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex == -1 || PHTable == null)
		{
			return;
		}
		DataRowView dataRowView = PHTable.DefaultView[e.RowIndex];
		string name = ((DataGridView)dgvPh).Columns[e.ColumnIndex].Name;
		if (Operators.CompareString(name, ((DataGridViewColumn)dgvcChon).Name, false) == 0)
		{
			DataRow[] array = f_oTblCt.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_rec='", dataRowView["Stt_Rec"]), (object)"'")));
			foreach (DataRow dataRow in array)
			{
				dataRow["chon"] = RuntimeHelpers.GetObjectValue(dataRowView["Chon"]);
			}
		}
	}

	private void dgvCt_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex == -1 || CTTable == null)
		{
			return;
		}
		DataRowView dataRowView = CTTable.DefaultView[e.RowIndex];
		string name = ((DataGridView)dgvCt).Columns[e.ColumnIndex].Name;
		if (Operators.CompareString(name, ((DataGridViewColumn)dgvcChonCt).Name, false) == 0)
		{
			bool flag = false;
			flag = !Operators.ConditionalCompareObjectEqual(CTTable.Compute("count(stt_rec)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"stt_rec='", dataRowView["stt_rec"]), (object)"' and chon=True"))), (object)0, false);
			DataRow[] array = PHTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Stt_rec='", dataRowView["Stt_Rec"]), (object)"'")));
			foreach (DataRow dataRow in array)
			{
				dataRow["chon"] = flag;
			}
		}
	}

	private void dgvPh_CurrentCellChanged(object sender, EventArgs e)
	{
		FilterCt();
	}

	private void FilterCt()
	{
		if (f_oTblPh.DefaultView.Count <= 0)
		{
			return;
		}
		try
		{
			if (((DataGridView)dgvPh).CurrentRow != null && ((DataGridViewBand)((DataGridView)dgvPh).CurrentRow).Index >= 0 && 0 == 0)
			{
				f_iCurPost = ((DataGridViewBand)((DataGridView)dgvPh).CurrentRow).Index;
				f_oTblCt.DefaultView.RowFilter = "Stt_rec = '" + f_oTblPh.DefaultView[f_iCurPost]["Stt_Rec"].ToString().Trim() + "'";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SetStatusBar()
	{
		((ToolStripItem)tsslCount).Text = Conversions.ToString(f_oTblPh.Rows.Count);
		if (Operators.CompareString(SystemInformations.CurrentCultureName, "vi-VN", false) != 0)
		{
			((ToolStripItem)tsslCountlbl).Text = AsiaErp.Framework.Environment.getLangFrameworkResX("#BASEVOUCHER_VIEWFORM_VOUCHER_COUNT_TEXT");
		}
	}
}
