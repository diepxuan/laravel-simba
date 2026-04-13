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
public class frmCaVchCa2FindPO7TAIN : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("btnChon")]
	private Button _btnChon;

	[AccessedThroughProperty("asDGV")]
	private AsInputDGV _asDGV;

	[AccessedThroughProperty("lblText")]
	private Label _lblText;

	[AccessedThroughProperty("dgvcTag")]
	private DataGridViewCheckBoxColumn _dgvcTag;

	[AccessedThroughProperty("dgvcNgay_ct")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcNgay_ct;

	[AccessedThroughProperty("dgvcSo_ct")]
	private DataGridViewAsTextBoxColumn _dgvcSo_ct;

	[AccessedThroughProperty("dgvcMau_bc")]
	private DataGridViewAsTextBoxColumn _dgvcMau_bc;

	[AccessedThroughProperty("dgvcMa_kh")]
	private DataGridViewAsTextBoxColumn _dgvcMa_kh;

	[AccessedThroughProperty("dgvcTen_kh")]
	private DataGridViewAsTextBoxColumn _dgvcTen_kh;

	[AccessedThroughProperty("dgvcDia_chi")]
	private DataGridViewAsTextBoxColumn _dgvcDia_chi;

	[AccessedThroughProperty("dgvcMST")]
	private DataGridViewAsTextBoxColumn _dgvcMST;

	[AccessedThroughProperty("dgvcT_tien")]
	private DataGridViewAsTextNumericColumn _dgvcT_tien;

	[AccessedThroughProperty("dgvcT_tien_nt")]
	private DataGridViewAsTextNumericColumn _dgvcT_tien_nt;

	[AccessedThroughProperty("dgvcThue_gtgt")]
	private DataGridViewAsTextNumericColumn _dgvcThue_gtgt;

	[AccessedThroughProperty("dgvcT_thue_nt")]
	private DataGridViewAsTextNumericColumn _dgvcT_thue_nt;

	[AccessedThroughProperty("dgvcThue_nk")]
	private DataGridViewAsTextNumericColumn _dgvcThue_nk;

	[AccessedThroughProperty("dgvcThue_NK_NT")]
	private DataGridViewAsTextNumericColumn _dgvcThue_NK_NT;

	[AccessedThroughProperty("bsTain")]
	private BindingSource _bsTain;

	[AccessedThroughProperty("txtT_tt_Nt")]
	private AsTextNumeric _txtT_tt_Nt;

	public bool is_ok;

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
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

	internal virtual AsInputDGV asDGV
	{
		[DebuggerNonUserCode]
		get
		{
			return _asDGV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_asDGV = value;
		}
	}

	internal virtual Label lblText
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblText;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblText = value;
		}
	}

	internal virtual DataGridViewCheckBoxColumn dgvcTag
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTag;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTag = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcSo_ct
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

	internal virtual DataGridViewAsTextBoxColumn dgvcMau_bc
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMau_bc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMau_bc = value;
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

	internal virtual DataGridViewAsTextBoxColumn dgvcTen_kh
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

	internal virtual DataGridViewAsTextBoxColumn dgvcDia_chi
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDia_chi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDia_chi = value;
		}
	}

	internal virtual DataGridViewAsTextBoxColumn dgvcMST
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMST;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMST = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcT_tien
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

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_gtgt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_gtgt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_gtgt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcT_thue_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcT_thue_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcT_thue_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_nk
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_nk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_nk = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcThue_NK_NT
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcThue_NK_NT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcThue_NK_NT = value;
		}
	}

	public virtual BindingSource bsTain
	{
		[DebuggerNonUserCode]
		get
		{
			return _bsTain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_bsTain = value;
		}
	}

	public virtual AsTextNumeric txtT_tt_Nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtT_tt_Nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtT_tt_Nt = value;
		}
	}

	public frmCaVchCa2FindPO7TAIN()
	{
		__ENCAddToList(this);
		is_ok = false;
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
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
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
		DataGridViewCellStyle val13 = new DataGridViewCellStyle();
		DataGridViewCellStyle val14 = new DataGridViewCellStyle();
		DataGridViewCellStyle val15 = new DataGridViewCellStyle();
		DataGridViewCellStyle val16 = new DataGridViewCellStyle();
		Panel1 = new Panel();
		txtT_tt_Nt = new AsTextNumeric();
		lblText = new Label();
		btnChon = new Button();
		asDGV = new AsInputDGV();
		dgvcTag = new DataGridViewCheckBoxColumn();
		dgvcNgay_ct = new DataGridViewAsMaskedTextBoxColumn();
		dgvcSo_ct = new DataGridViewAsTextBoxColumn();
		dgvcMau_bc = new DataGridViewAsTextBoxColumn();
		dgvcMa_kh = new DataGridViewAsTextBoxColumn();
		dgvcTen_kh = new DataGridViewAsTextBoxColumn();
		dgvcDia_chi = new DataGridViewAsTextBoxColumn();
		dgvcMST = new DataGridViewAsTextBoxColumn();
		dgvcT_tien = new DataGridViewAsTextNumericColumn();
		dgvcT_tien_nt = new DataGridViewAsTextNumericColumn();
		dgvcThue_gtgt = new DataGridViewAsTextNumericColumn();
		dgvcT_thue_nt = new DataGridViewAsTextNumericColumn();
		dgvcThue_nk = new DataGridViewAsTextNumericColumn();
		dgvcThue_NK_NT = new DataGridViewAsTextNumericColumn();
		bsTain = new BindingSource(components);
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)asDGV).BeginInit();
		((ISupportInitialize)bsTain).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).Controls.Add((Control)(object)txtT_tt_Nt);
		((Control)Panel1).Controls.Add((Control)(object)lblText);
		((Control)Panel1).Controls.Add((Control)(object)btnChon);
		((Control)Panel1).Dock = (DockStyle)2;
		Panel panel = Panel1;
		Point location = new Point(0, 333);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		Size size = new Size(774, 33);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 1;
		((Control)txtT_tt_Nt).Anchor = (AnchorStyles)6;
		txtT_tt_Nt.DecimalSymbol = ".";
		((Control)txtT_tt_Nt).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextNumeric asTextNumeric = txtT_tt_Nt;
		location = new Point(80, 8);
		((Control)asTextNumeric).Location = location;
		txtT_tt_Nt.Mask = "### ### ### ###.##";
		((Control)txtT_tt_Nt).Name = "txtT_tt_Nt";
		((TextBoxBase)txtT_tt_Nt).ReadOnly = true;
		AsTextNumeric asTextNumeric2 = txtT_tt_Nt;
		size = new Size(100, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtT_tt_Nt).TabIndex = 230;
		((Control)txtT_tt_Nt).TabStop = false;
		((TextBox)txtT_tt_Nt).Text = "0.00";
		((TextBox)txtT_tt_Nt).TextAlign = (HorizontalAlignment)1;
		txtT_tt_Nt.Value = 0.0;
		lblText.AutoSize = true;
		Label obj = lblText;
		location = new Point(12, 11);
		((Control)obj).Location = location;
		((Control)lblText).Name = "lblText";
		Label obj2 = lblText;
		size = new Size(62, 13);
		((Control)obj2).Size = size;
		((Control)lblText).TabIndex = 1;
		lblText.Text = "Thanh toán";
		((Control)btnChon).Anchor = (AnchorStyles)10;
		Button obj3 = btnChon;
		location = new Point(687, 6);
		((Control)obj3).Location = location;
		((Control)btnChon).Name = "btnChon";
		Button obj4 = btnChon;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)btnChon).TabIndex = 0;
		((ButtonBase)btnChon).Text = "&Chọn";
		((DataGridView)asDGV).AllowUserToAddRows = false;
		((DataGridView)asDGV).AllowUserToDeleteRows = false;
		((DataGridView)asDGV).AutoGenerateColumns = false;
		((DataGridView)asDGV).BackgroundColor = Color.White;
		((DataGridView)asDGV).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDGV).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)asDGV).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)asDGV).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[14]
		{
			(DataGridViewColumn)dgvcTag,
			dgvcNgay_ct,
			dgvcSo_ct,
			dgvcMau_bc,
			dgvcMa_kh,
			dgvcTen_kh,
			dgvcDia_chi,
			dgvcMST,
			dgvcT_tien,
			dgvcT_tien_nt,
			dgvcThue_gtgt,
			dgvcT_thue_nt,
			dgvcThue_nk,
			dgvcThue_NK_NT
		});
		((DataGridView)asDGV).DataSource = bsTain;
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)asDGV).DefaultCellStyle = val2;
		((Control)asDGV).Dock = (DockStyle)5;
		((DataGridView)asDGV).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = asDGV;
		location = new Point(0, 0);
		((Control)asInputDGV).Location = location;
		((Control)asDGV).Name = "asDGV";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)asDGV).RowHeadersDefaultCellStyle = val3;
		((DataGridView)asDGV).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = asDGV;
		size = new Size(774, 333);
		((Control)asInputDGV2).Size = size;
		((Control)asDGV).TabIndex = 0;
		((DataGridViewColumn)dgvcTag).DataPropertyName = "TAg";
		((DataGridViewColumn)dgvcTag).HeaderText = "Chọn";
		((DataGridViewColumn)dgvcTag).Name = "dgvcTag";
		((DataGridViewColumn)dgvcTag).Width = 40;
		((DataGridViewColumn)dgvcNgay_ct).DataPropertyName = "ngay_ct";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct).DefaultCellStyle = val4;
		dgvcNgay_ct.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct).HeaderText = "Ngày HĐ";
		dgvcNgay_ct.Mask = "##/##/####";
		((DataGridViewColumn)dgvcNgay_ct).Name = "dgvcNgay_ct";
		((DataGridViewColumn)dgvcNgay_ct).ReadOnly = true;
		dgvcNgay_ct.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcNgay_ct).Width = 80;
		dgvcSo_ct.AutoFill = false;
		dgvcSo_ct.AutoLookup = false;
		dgvcSo_ct.AutoValid = false;
		((DataGridViewColumn)dgvcSo_ct).DataPropertyName = "so_ct";
		val5.BackColor = SystemColors.Window;
		((DataGridViewColumn)dgvcSo_ct).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcSo_ct).HeaderText = "Số HĐ";
		dgvcSo_ct.LookupCodeName = "";
		dgvcSo_ct.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcSo_ct).Name = "dgvcSo_ct";
		((DataGridViewColumn)dgvcSo_ct).ReadOnly = true;
		dgvcSo_ct.ReceiverValidFieldList = "";
		dgvcSo_ct.SD = false;
		dgvcSo_ct.SortMode = (DataGridViewColumnSortMode)0;
		dgvcSo_ct.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcSo_ct).Width = 50;
		dgvcMau_bc.AutoFill = false;
		dgvcMau_bc.AutoLookup = false;
		dgvcMau_bc.AutoValid = false;
		val6.BackColor = SystemColors.Window;
		((DataGridViewColumn)dgvcMau_bc).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcMau_bc).HeaderText = "Mẫu";
		dgvcMau_bc.LookupCodeName = "";
		dgvcMau_bc.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMau_bc).Name = "dgvcMau_bc";
		((DataGridViewColumn)dgvcMau_bc).ReadOnly = true;
		dgvcMau_bc.ReceiverValidFieldList = "";
		dgvcMau_bc.SD = false;
		dgvcMau_bc.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMau_bc.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcMau_bc).Visible = false;
		dgvcMa_kh.AutoFill = false;
		dgvcMa_kh.AutoLookup = false;
		dgvcMa_kh.AutoValid = false;
		((DataGridViewColumn)dgvcMa_kh).DataPropertyName = "ma_kh";
		val7.BackColor = SystemColors.Window;
		((DataGridViewColumn)dgvcMa_kh).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcMa_kh).HeaderText = "Mã kh";
		dgvcMa_kh.LookupCodeName = "";
		dgvcMa_kh.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMa_kh).Name = "dgvcMa_kh";
		((DataGridViewColumn)dgvcMa_kh).ReadOnly = true;
		dgvcMa_kh.ReceiverValidFieldList = "";
		dgvcMa_kh.SD = false;
		dgvcMa_kh.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMa_kh.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcMa_kh).Width = 60;
		dgvcTen_kh.AutoFill = false;
		dgvcTen_kh.AutoLookup = false;
		dgvcTen_kh.AutoValid = false;
		((DataGridViewColumn)dgvcTen_kh).DataPropertyName = "ten_kh";
		val8.BackColor = SystemColors.Window;
		((DataGridViewColumn)dgvcTen_kh).DefaultCellStyle = val8;
		((DataGridViewColumn)dgvcTen_kh).HeaderText = "Tên khách";
		dgvcTen_kh.LookupCodeName = "";
		dgvcTen_kh.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcTen_kh).Name = "dgvcTen_kh";
		((DataGridViewColumn)dgvcTen_kh).ReadOnly = true;
		dgvcTen_kh.ReceiverValidFieldList = "";
		((DataGridViewColumn)dgvcTen_kh).Resizable = (DataGridViewTriState)1;
		dgvcTen_kh.SD = false;
		dgvcTen_kh.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcTen_kh).Visible = false;
		dgvcDia_chi.AutoFill = false;
		dgvcDia_chi.AutoLookup = false;
		dgvcDia_chi.AutoValid = false;
		((DataGridViewColumn)dgvcDia_chi).DataPropertyName = "dia_chi";
		val9.BackColor = SystemColors.Window;
		((DataGridViewColumn)dgvcDia_chi).DefaultCellStyle = val9;
		((DataGridViewColumn)dgvcDia_chi).HeaderText = "Địa chỉ";
		dgvcDia_chi.LookupCodeName = "";
		dgvcDia_chi.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcDia_chi).Name = "dgvcDia_chi";
		((DataGridViewColumn)dgvcDia_chi).ReadOnly = true;
		dgvcDia_chi.ReceiverValidFieldList = "";
		dgvcDia_chi.SD = false;
		dgvcDia_chi.SortMode = (DataGridViewColumnSortMode)0;
		dgvcDia_chi.ValidReturnFieldList = "";
		dgvcMST.AutoFill = false;
		dgvcMST.AutoLookup = false;
		dgvcMST.AutoValid = false;
		((DataGridViewColumn)dgvcMST).DataPropertyName = "ma_so_thue";
		val10.BackColor = SystemColors.Window;
		((DataGridViewColumn)dgvcMST).DefaultCellStyle = val10;
		((DataGridViewColumn)dgvcMST).HeaderText = "Mã số thuế";
		dgvcMST.LookupCodeName = "";
		dgvcMST.LookupWhereCondition = "";
		((DataGridViewColumn)dgvcMST).Name = "dgvcMST";
		((DataGridViewColumn)dgvcMST).ReadOnly = true;
		dgvcMST.ReceiverValidFieldList = "";
		dgvcMST.SD = false;
		dgvcMST.SortMode = (DataGridViewColumnSortMode)0;
		dgvcMST.ValidReturnFieldList = "";
		((DataGridViewColumn)dgvcT_tien).DataPropertyName = "t_tien";
		val11.Alignment = (DataGridViewContentAlignment)64;
		val11.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcT_tien).DefaultCellStyle = val11;
		((DataGridViewColumn)dgvcT_tien).HeaderText = "Tổng tiền";
		dgvcT_tien.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcT_tien).Name = "dgvcT_tien";
		((DataGridViewColumn)dgvcT_tien).Resizable = (DataGridViewTriState)1;
		dgvcT_tien.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcT_tien_nt).DataPropertyName = "t_tien_nt";
		val12.Alignment = (DataGridViewContentAlignment)64;
		val12.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcT_tien_nt).DefaultCellStyle = val12;
		((DataGridViewColumn)dgvcT_tien_nt).HeaderText = "Tiền hàng NT";
		dgvcT_tien_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcT_tien_nt).Name = "dgvcT_tien_nt";
		((DataGridViewColumn)dgvcT_tien_nt).Resizable = (DataGridViewTriState)1;
		dgvcT_tien_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_gtgt).DataPropertyName = "t_thue";
		val13.Alignment = (DataGridViewContentAlignment)64;
		val13.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt).DefaultCellStyle = val13;
		((DataGridViewColumn)dgvcThue_gtgt).HeaderText = "Thuế GTGT";
		dgvcThue_gtgt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_gtgt).Name = "dgvcThue_gtgt";
		((DataGridViewColumn)dgvcThue_gtgt).Resizable = (DataGridViewTriState)1;
		dgvcThue_gtgt.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcT_thue_nt).DataPropertyName = "T_THUE_NT";
		val14.Alignment = (DataGridViewContentAlignment)64;
		val14.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcT_thue_nt).DefaultCellStyle = val14;
		((DataGridViewColumn)dgvcT_thue_nt).HeaderText = "Thuế GTGT NT";
		dgvcT_thue_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcT_thue_nt).Name = "dgvcT_thue_nt";
		((DataGridViewColumn)dgvcT_thue_nt).Resizable = (DataGridViewTriState)1;
		dgvcT_thue_nt.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_nk).DataPropertyName = "thue_nk";
		val15.Alignment = (DataGridViewContentAlignment)64;
		val15.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_nk).DefaultCellStyle = val15;
		((DataGridViewColumn)dgvcThue_nk).HeaderText = "Thuế NK";
		dgvcThue_nk.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_nk).Name = "dgvcThue_nk";
		((DataGridViewColumn)dgvcThue_nk).ReadOnly = true;
		((DataGridViewColumn)dgvcThue_nk).Resizable = (DataGridViewTriState)1;
		dgvcThue_nk.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_nk.SpecialType = Commons.NumericSpecialType.ACAmount;
		((DataGridViewColumn)dgvcThue_nk).Visible = false;
		((DataGridViewColumn)dgvcThue_NK_NT).DataPropertyName = "thue_nk_nt";
		val16.Alignment = (DataGridViewContentAlignment)64;
		val16.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_NK_NT).DefaultCellStyle = val16;
		((DataGridViewColumn)dgvcThue_NK_NT).HeaderText = "Thuế NK NT";
		dgvcThue_NK_NT.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcThue_NK_NT).Name = "dgvcThue_NK_NT";
		((DataGridViewColumn)dgvcThue_NK_NT).ReadOnly = true;
		((DataGridViewColumn)dgvcThue_NK_NT).Resizable = (DataGridViewTriState)1;
		dgvcThue_NK_NT.SortMode = (DataGridViewColumnSortMode)0;
		dgvcThue_NK_NT.SpecialType = Commons.NumericSpecialType.FCAmount;
		((DataGridViewColumn)dgvcThue_NK_NT).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(774, 366);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)asDGV);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmCaVchCa2FindPO7TAIN";
		((Form)this).Text = "Kế thuế VAT nhập khẩu";
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)asDGV).EndInit();
		((ISupportInitialize)bsTain).EndInit();
		((Control)this).ResumeLayout(false);
	}

	protected override bool ProcessKeyPreview(ref Message m)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		Keys val = (Keys)(((Message)(ref m)).WParam.ToInt32() & 0xFFFF);
		if (((Message)(ref m)).Msg == 256 && (int)val == 27)
		{
			((Form)this).Close();
			return false;
		}
		return base.ProcessKeyPreview(ref m);
	}

	private void btnChon_Click(object sender, EventArgs e)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		if (Operators.ConditionalCompareObjectGreater(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(((DataTable)bsTain.DataSource).Compute("sum(t_thue)", "tag=1")), isNum: true), txtT_tt_Nt.Value, false))
		{
			if ((int)CMessageBox.Show(50169, SystemInformations.ProductName, (MessageBoxButtons)4) == 6)
			{
				is_ok = true;
				((Form)this).Close();
			}
			else
			{
				is_ok = false;
			}
		}
		else
		{
			is_ok = true;
			((Form)this).Close();
		}
	}
}
