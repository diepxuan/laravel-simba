using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class frmCaVchCA5FindCA2 : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("dgvPh")]
	private AsDataGridView _dgvPh;

	[AccessedThroughProperty("bsPC")]
	private BindingSource _bsPC;

	[AccessedThroughProperty("dgvcChon")]
	private DataGridViewCheckBoxColumn _dgvcChon;

	[AccessedThroughProperty("dgvcNgay_ct")]
	private DataGridViewAsMaskedTextBoxColumn _dgvcNgay_ct;

	[AccessedThroughProperty("dgvcSo_ct")]
	private DataGridViewTextBoxColumn _dgvcSo_ct;

	[AccessedThroughProperty("dgvctien_pc")]
	private DataGridViewAsTextNumericColumn _dgvctien_pc;

	[AccessedThroughProperty("dgvcTien_pc_nt")]
	private DataGridViewAsTextNumericColumn _dgvcTien_pc_nt;

	[AccessedThroughProperty("dgvcTien_tt")]
	private DataGridViewAsTextNumericColumn _dgvcTien_tt;

	[AccessedThroughProperty("dgvcTien_tt_nt")]
	private DataGridViewAsTextNumericColumn _dgvcTien_tt_nt;

	[AccessedThroughProperty("dgvcDu_Pc")]
	private DataGridViewAsTextNumericColumn _dgvcDu_Pc;

	[AccessedThroughProperty("dgvcMa_kh")]
	private DataGridViewTextBoxColumn _dgvcMa_kh;

	[AccessedThroughProperty("dgvcTen_kh")]
	private DataGridViewTextBoxColumn _dgvcTen_kh;

	[AccessedThroughProperty("dgvcNguoi_gd")]
	private DataGridViewTextBoxColumn _dgvcNguoi_gd;

	[AccessedThroughProperty("dgvcMa_nt")]
	private DataGridViewTextBoxColumn _dgvcMa_nt;

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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(dgvPh_MouseDoubleClick);
			KeyEventHandler val2 = new KeyEventHandler(dgvPh_KeyDown);
			if (_dgvPh != null)
			{
				((Control)_dgvPh).MouseDoubleClick -= val;
				((Control)_dgvPh).KeyDown -= val2;
			}
			_dgvPh = value;
			if (_dgvPh != null)
			{
				((Control)_dgvPh).MouseDoubleClick += val;
				((Control)_dgvPh).KeyDown += val2;
			}
		}
	}

	internal virtual BindingSource bsPC
	{
		[DebuggerNonUserCode]
		get
		{
			return _bsPC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_bsPC = value;
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

	internal virtual DataGridViewAsTextNumericColumn dgvctien_pc
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvctien_pc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvctien_pc = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_pc_nt
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTien_pc_nt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTien_pc_nt = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcTien_tt
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

	internal virtual DataGridViewAsTextNumericColumn dgvcDu_Pc
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcDu_Pc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcDu_Pc = value;
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

	[DebuggerNonUserCode]
	public frmCaVchCA5FindCA2()
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		dgvPh = new AsDataGridView();
		dgvcChon = new DataGridViewCheckBoxColumn();
		dgvcNgay_ct = new DataGridViewAsMaskedTextBoxColumn();
		dgvcSo_ct = new DataGridViewTextBoxColumn();
		dgvctien_pc = new DataGridViewAsTextNumericColumn();
		dgvcTien_pc_nt = new DataGridViewAsTextNumericColumn();
		dgvcTien_tt = new DataGridViewAsTextNumericColumn();
		dgvcTien_tt_nt = new DataGridViewAsTextNumericColumn();
		dgvcDu_Pc = new DataGridViewAsTextNumericColumn();
		dgvcMa_kh = new DataGridViewTextBoxColumn();
		dgvcTen_kh = new DataGridViewTextBoxColumn();
		dgvcNguoi_gd = new DataGridViewTextBoxColumn();
		dgvcMa_nt = new DataGridViewTextBoxColumn();
		bsPC = new BindingSource(components);
		((ISupportInitialize)dgvPh).BeginInit();
		((ISupportInitialize)bsPC).BeginInit();
		((Control)this).SuspendLayout();
		((DataGridView)dgvPh).AllowUserToAddRows = false;
		((DataGridView)dgvPh).AllowUserToDeleteRows = false;
		((DataGridView)dgvPh).AutoGenerateColumns = false;
		((DataGridView)dgvPh).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvPh).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvPh).ColumnHeadersHeight = 20;
		((DataGridView)dgvPh).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)1;
		((DataGridView)dgvPh).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[12]
		{
			(DataGridViewColumn)dgvcChon,
			dgvcNgay_ct,
			(DataGridViewColumn)dgvcSo_ct,
			dgvctien_pc,
			dgvcTien_pc_nt,
			dgvcTien_tt,
			dgvcTien_tt_nt,
			dgvcDu_Pc,
			(DataGridViewColumn)dgvcMa_kh,
			(DataGridViewColumn)dgvcTen_kh,
			(DataGridViewColumn)dgvcNguoi_gd,
			(DataGridViewColumn)dgvcMa_nt
		});
		dgvPh.DataSource = bsPC;
		((Control)dgvPh).Dock = (DockStyle)5;
		dgvPh.DoubleBuffered = false;
		dgvPh.EnterKeyAsTabKey = false;
		((DataGridView)dgvPh).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvPh;
		Point location = new Point(0, 0);
		((Control)asDataGridView).Location = location;
		((DataGridView)dgvPh).MultiSelect = false;
		((Control)dgvPh).Name = "dgvPh";
		dgvPh.ReadOnly = true;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		((DataGridView)dgvPh).RowHeadersDefaultCellStyle = val;
		dgvPh.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvPh).RowTemplate.Height = 18;
		AsDataGridView asDataGridView2 = dgvPh;
		Size size = new Size(688, 403);
		((Control)asDataGridView2).Size = size;
		((Control)dgvPh).TabIndex = 1;
		((DataGridViewColumn)dgvcChon).DataPropertyName = "chon";
		((DataGridViewColumn)dgvcChon).HeaderText = "Chọn";
		((DataGridViewColumn)dgvcChon).Name = "dgvcChon";
		((DataGridViewColumn)dgvcChon).Visible = false;
		((DataGridViewColumn)dgvcChon).Width = 40;
		((DataGridViewColumn)dgvcNgay_ct).DataPropertyName = "ngay_ct";
		val2.Alignment = (DataGridViewContentAlignment)64;
		val2.Format = "dd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct).DefaultCellStyle = val2;
		dgvcNgay_ct.Format = "@Ddd/MM/yyyy";
		((DataGridViewColumn)dgvcNgay_ct).HeaderText = "Ngày ctừ";
		dgvcNgay_ct.Mask = "##/##/####";
		((DataGridViewColumn)dgvcNgay_ct).Name = "dgvcNgay_ct";
		((DataGridViewColumn)dgvcNgay_ct).ReadOnly = true;
		dgvcNgay_ct.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcNgay_ct).Width = 65;
		((DataGridViewColumn)dgvcSo_ct).DataPropertyName = "so_ct";
		((DataGridViewColumn)dgvcSo_ct).HeaderText = "Số ctừ";
		((DataGridViewColumn)dgvcSo_ct).Name = "dgvcSo_ct";
		((DataGridViewColumn)dgvcSo_ct).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_ct).Width = 65;
		((DataGridViewColumn)dgvctien_pc).DataPropertyName = "tien_pc";
		val3.Alignment = (DataGridViewContentAlignment)64;
		val3.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvctien_pc).DefaultCellStyle = val3;
		((DataGridViewColumn)dgvctien_pc).HeaderText = "Tiền PC";
		dgvctien_pc.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvctien_pc).Name = "dgvctien_pc";
		((DataGridViewColumn)dgvctien_pc).ReadOnly = true;
		((DataGridViewColumn)dgvctien_pc).Resizable = (DataGridViewTriState)1;
		dgvctien_pc.SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcTien_pc_nt).DataPropertyName = "Tien_pc_nt";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_pc_nt).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcTien_pc_nt).HeaderText = "Tiền PC NT";
		dgvcTien_pc_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_pc_nt).Name = "dgvcTien_pc_nt";
		((DataGridViewColumn)dgvcTien_pc_nt).ReadOnly = true;
		((DataGridViewColumn)dgvcTien_pc_nt).Resizable = (DataGridViewTriState)1;
		dgvcTien_pc_nt.SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcTien_pc_nt).Visible = false;
		((DataGridViewColumn)dgvcTien_tt).DataPropertyName = "Tien_tt";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_tt).DefaultCellStyle = val5;
		((DataGridViewColumn)dgvcTien_tt).HeaderText = "Tiền TT";
		dgvcTien_tt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_tt).Name = "dgvcTien_tt";
		((DataGridViewColumn)dgvcTien_tt).ReadOnly = true;
		((DataGridViewColumn)dgvcTien_tt).Resizable = (DataGridViewTriState)1;
		dgvcTien_tt.SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcTien_tt_nt).DataPropertyName = "Tien_tt_nt";
		val6.Alignment = (DataGridViewContentAlignment)64;
		val6.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_tt_nt).DefaultCellStyle = val6;
		((DataGridViewColumn)dgvcTien_tt_nt).HeaderText = "Tiền TT NT";
		dgvcTien_tt_nt.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcTien_tt_nt).Name = "dgvcTien_tt_nt";
		((DataGridViewColumn)dgvcTien_tt_nt).ReadOnly = true;
		((DataGridViewColumn)dgvcTien_tt_nt).Resizable = (DataGridViewTriState)1;
		dgvcTien_tt_nt.SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)dgvcTien_tt_nt).Visible = false;
		((DataGridViewColumn)dgvcDu_Pc).DataPropertyName = "du_pc";
		val7.Alignment = (DataGridViewContentAlignment)64;
		val7.Format = "### ### ### ###.##";
		((DataGridViewColumn)dgvcDu_Pc).DefaultCellStyle = val7;
		((DataGridViewColumn)dgvcDu_Pc).HeaderText = "Dư PC";
		dgvcDu_Pc.Mask = "### ### ### ###.##";
		((DataGridViewColumn)dgvcDu_Pc).Name = "dgvcDu_Pc";
		((DataGridViewColumn)dgvcDu_Pc).ReadOnly = true;
		dgvcDu_Pc.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_kh).DataPropertyName = "ma_kh";
		((DataGridViewColumn)dgvcMa_kh).HeaderText = "Mã KH";
		((DataGridViewColumn)dgvcMa_kh).Name = "dgvcMa_kh";
		((DataGridViewColumn)dgvcMa_kh).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_kh).Width = 70;
		((DataGridViewColumn)dgvcTen_kh).DataPropertyName = "ten_kh";
		((DataGridViewColumn)dgvcTen_kh).HeaderText = "Tên khách hàng";
		((DataGridViewColumn)dgvcTen_kh).Name = "dgvcTen_kh";
		((DataGridViewColumn)dgvcTen_kh).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_kh).Width = 180;
		((DataGridViewColumn)dgvcNguoi_gd).DataPropertyName = "nguoi_gd";
		((DataGridViewColumn)dgvcNguoi_gd).HeaderText = "Người gd";
		((DataGridViewColumn)dgvcNguoi_gd).Name = "dgvcNguoi_gd";
		((DataGridViewColumn)dgvcNguoi_gd).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_nt).DataPropertyName = "ma_nt";
		((DataGridViewColumn)dgvcMa_nt).HeaderText = "Mã NT";
		((DataGridViewColumn)dgvcMa_nt).Name = "dgvcMa_nt";
		((DataGridViewColumn)dgvcMa_nt).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_nt).Width = 50;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(688, 403);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)dgvPh);
		((Control)this).Name = "frmCaVchCA5FindCA2";
		((Form)this).Text = "Chon PC";
		((ISupportInitialize)dgvPh).EndInit();
		((ISupportInitialize)bsPC).EndInit();
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

	private void dgvPh_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			((Form)this).Close();
		}
	}

	private void dgvPh_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (((DataGridViewBand)((DataGridView)dgvPh).CurrentRow).Index >= 0)
		{
			((Form)this).Close();
		}
	}
}
