using System;
using System.Collections;
using System.Collections.Generic;
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
public class frmGLDKCTGS : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lblSeparate")]
	private Label _lblSeparate;

	[AccessedThroughProperty("lblKyKC")]
	private Label _lblKyKC;

	[AccessedThroughProperty("txtNgay2")]
	private AsMaskedTextBox _txtNgay2;

	[AccessedThroughProperty("txtNgay1")]
	private AsMaskedTextBox _txtNgay1;

	[AccessedThroughProperty("cboKyBc")]
	private AsComboBox _cboKyBc;

	[AccessedThroughProperty("dgvCTGS")]
	private AsDataGridView _dgvCTGS;

	[AccessedThroughProperty("cmdExecute")]
	private Button _cmdExecute;

	[AccessedThroughProperty("cmdExit")]
	private Button _cmdExit;

	[AccessedThroughProperty("dgvcTag")]
	private DataGridViewCheckBoxColumn _dgvcTag;

	[AccessedThroughProperty("dgvcMa_ct")]
	private DataGridViewTextBoxColumn _dgvcMa_ct;

	[AccessedThroughProperty("dgvcTk")]
	private DataGridViewTextBoxColumn _dgvcTk;

	[AccessedThroughProperty("dgvcTen_ctgs")]
	private DataGridViewTextBoxColumn _dgvcTen_ctgs;

	[AccessedThroughProperty("dgvcSo_hieu")]
	private DataGridViewTextBoxColumn _dgvcSo_hieu;

	[AccessedThroughProperty("dgvcNgay")]
	private DataGridViewAsTextNumericColumn _dgvcNgay;

	[AccessedThroughProperty("chkChon")]
	private CheckBox _chkChon;

	private DataTable oDt_CTHS;

	internal virtual Label lblSeparate
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSeparate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSeparate = value;
		}
	}

	internal virtual Label lblKyKC
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblKyKC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblKyKC = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay2 = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay1 = value;
		}
	}

	internal virtual AsComboBox cboKyBc
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboKyBc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboKyBc_SelectedValueChanged;
			if (_cboKyBc != null)
			{
				((ListControl)_cboKyBc).SelectedValueChanged -= eventHandler;
			}
			_cboKyBc = value;
			if (_cboKyBc != null)
			{
				((ListControl)_cboKyBc).SelectedValueChanged += eventHandler;
			}
		}
	}

	internal virtual AsDataGridView dgvCTGS
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvCTGS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvCTGS = value;
		}
	}

	internal virtual Button cmdExecute
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdExecute;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdExecute_Click;
			if (_cmdExecute != null)
			{
				((Control)_cmdExecute).Click -= eventHandler;
			}
			_cmdExecute = value;
			if (_cmdExecute != null)
			{
				((Control)_cmdExecute).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdExit_Click;
			if (_cmdExit != null)
			{
				((Control)_cmdExit).Click -= eventHandler;
			}
			_cmdExit = value;
			if (_cmdExit != null)
			{
				((Control)_cmdExit).Click += eventHandler;
			}
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

	internal virtual DataGridViewTextBoxColumn dgvcMa_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcMa_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcMa_ct = value;
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

	internal virtual DataGridViewTextBoxColumn dgvcTen_ctgs
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTen_ctgs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTen_ctgs = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcSo_hieu
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcSo_hieu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcSo_hieu = value;
		}
	}

	internal virtual DataGridViewAsTextNumericColumn dgvcNgay
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcNgay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcNgay = value;
		}
	}

	internal virtual CheckBox chkChon
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkChon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkChon_CheckedChanged;
			if (_chkChon != null)
			{
				_chkChon.CheckedChanged -= eventHandler;
			}
			_chkChon = value;
			if (_chkChon != null)
			{
				_chkChon.CheckedChanged += eventHandler;
			}
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

	public frmGLDKCTGS(string menuid)
		: base(menuid)
	{
		((Form)this).Load += frmGLDKCTGS_Load;
		__ENCAddToList(this);
		oDt_CTHS = new DataTable();
		InitializeComponent();
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		lblSeparate = new Label();
		lblKyKC = new Label();
		txtNgay2 = new AsMaskedTextBox();
		txtNgay1 = new AsMaskedTextBox();
		cboKyBc = new AsComboBox();
		dgvCTGS = new AsDataGridView();
		dgvcTag = new DataGridViewCheckBoxColumn();
		dgvcMa_ct = new DataGridViewTextBoxColumn();
		dgvcTk = new DataGridViewTextBoxColumn();
		dgvcTen_ctgs = new DataGridViewTextBoxColumn();
		dgvcSo_hieu = new DataGridViewTextBoxColumn();
		dgvcNgay = new DataGridViewAsTextNumericColumn();
		cmdExit = new Button();
		cmdExecute = new Button();
		chkChon = new CheckBox();
		((ISupportInitialize)dgvCTGS).BeginInit();
		((Control)this).SuspendLayout();
		lblSeparate.AutoSize = true;
		Label obj = lblSeparate;
		Point location = new Point(262, 16);
		((Control)obj).Location = location;
		((Control)lblSeparate).Name = "lblSeparate";
		Label obj2 = lblSeparate;
		Size size = new Size(10, 13);
		((Control)obj2).Size = size;
		((Control)lblSeparate).TabIndex = 3;
		lblSeparate.Text = "-";
		lblKyKC.AutoSize = true;
		Label obj3 = lblKyKC;
		location = new Point(13, 16);
		((Control)obj3).Location = location;
		((Control)lblKyKC).Name = "lblKyKC";
		Label obj4 = lblKyKC;
		size = new Size(61, 13);
		((Control)obj4).Size = size;
		((Control)lblKyKC).TabIndex = 0;
		lblKyKC.Text = "Kỳ đăng ký";
		txtNgay2.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay2).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay2;
		location = new Point(276, 12);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay2).Mask = "##/##/####";
		((Control)txtNgay2).Name = "txtNgay2";
		((MaskedTextBox)txtNgay2).PromptChar = ' ';
		((MaskedTextBox)txtNgay2).ReadOnly = true;
		AsMaskedTextBox asMaskedTextBox2 = txtNgay2;
		size = new Size(74, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay2).TabIndex = 4;
		((Control)txtNgay2).TabStop = false;
		((MaskedTextBox)txtNgay2).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay2;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtNgay1.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay1).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay1;
		location = new Point(185, 12);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay1).Mask = "##/##/####";
		((Control)txtNgay1).Name = "txtNgay1";
		((MaskedTextBox)txtNgay1).PromptChar = ' ';
		((MaskedTextBox)txtNgay1).ReadOnly = true;
		AsMaskedTextBox asMaskedTextBox5 = txtNgay1;
		size = new Size(74, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay1).TabIndex = 2;
		((Control)txtNgay1).TabStop = false;
		((MaskedTextBox)txtNgay1).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay1;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		((ComboBox)cboKyBc).DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cboKyBc).FormattingEnabled = true;
		AsComboBox asComboBox = cboKyBc;
		location = new Point(87, 12);
		((Control)asComboBox).Location = location;
		((Control)cboKyBc).Name = "cboKyBc";
		AsComboBox asComboBox2 = cboKyBc;
		size = new Size(90, 21);
		((Control)asComboBox2).Size = size;
		((Control)cboKyBc).TabIndex = 1;
		((DataGridView)dgvCTGS).AllowUserToAddRows = false;
		((DataGridView)dgvCTGS).AllowUserToDeleteRows = false;
		((DataGridView)dgvCTGS).AllowUserToResizeRows = false;
		((Control)dgvCTGS).Anchor = (AnchorStyles)15;
		((DataGridView)dgvCTGS).BackgroundColor = SystemColors.Window;
		((DataGridView)dgvCTGS).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvCTGS).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)dgvCTGS).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvCTGS).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)dgvcTag,
			(DataGridViewColumn)dgvcMa_ct,
			(DataGridViewColumn)dgvcTk,
			(DataGridViewColumn)dgvcTen_ctgs,
			(DataGridViewColumn)dgvcSo_hieu,
			dgvcNgay
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvCTGS).DefaultCellStyle = val2;
		dgvCTGS.DoubleBuffered = false;
		((DataGridView)dgvCTGS).EditMode = (DataGridViewEditMode)0;
		((DataGridView)dgvCTGS).GridColor = SystemColors.Control;
		AsDataGridView asDataGridView = dgvCTGS;
		location = new Point(12, 62);
		((Control)asDataGridView).Location = location;
		((Control)dgvCTGS).Name = "dgvCTGS";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvCTGS).RowHeadersDefaultCellStyle = val3;
		((DataGridView)dgvCTGS).RowHeadersVisible = false;
		dgvCTGS.RowIndex2StartFillOrdinalNumber = 1u;
		((DataGridView)dgvCTGS).RowTemplate.Height = 20;
		AsDataGridView asDataGridView2 = dgvCTGS;
		size = new Size(661, 318);
		((Control)asDataGridView2).Size = size;
		((Control)dgvCTGS).TabIndex = 6;
		((DataGridViewColumn)dgvcTag).DataPropertyName = "Tag";
		((DataGridViewColumn)dgvcTag).HeaderText = "Chọn";
		((DataGridViewColumn)dgvcTag).Name = "dgvcTag";
		((DataGridViewColumn)dgvcTag).Width = 40;
		((DataGridViewColumn)dgvcMa_ct).DataPropertyName = "ma_ct";
		((DataGridViewColumn)dgvcMa_ct).HeaderText = "Mã CT";
		((DataGridViewColumn)dgvcMa_ct).Name = "dgvcMa_ct";
		((DataGridViewColumn)dgvcMa_ct).ReadOnly = true;
		((DataGridViewColumn)dgvcMa_ct).Resizable = (DataGridViewTriState)1;
		dgvcMa_ct.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcMa_ct).Width = 80;
		((DataGridViewColumn)dgvcTk).DataPropertyName = "tk";
		((DataGridViewColumn)dgvcTk).HeaderText = "Tài khoản";
		((DataGridViewColumn)dgvcTk).Name = "dgvcTk";
		((DataGridViewColumn)dgvcTk).ReadOnly = true;
		((DataGridViewColumn)dgvcTk).Resizable = (DataGridViewTriState)1;
		dgvcTk.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)dgvcTk).Width = 80;
		((DataGridViewColumn)dgvcTen_ctgs).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)dgvcTen_ctgs).DataPropertyName = "ten_ctgs";
		((DataGridViewColumn)dgvcTen_ctgs).HeaderText = "Tên chứng từ";
		((DataGridViewColumn)dgvcTen_ctgs).Name = "dgvcTen_ctgs";
		((DataGridViewColumn)dgvcTen_ctgs).ReadOnly = true;
		((DataGridViewColumn)dgvcSo_hieu).DataPropertyName = "so_hieu";
		((DataGridViewColumn)dgvcSo_hieu).HeaderText = "Số hiệu";
		((DataGridViewColumn)dgvcSo_hieu).Name = "dgvcSo_hieu";
		((DataGridViewColumn)dgvcSo_hieu).ReadOnly = true;
		((DataGridViewColumn)dgvcNgay).DataPropertyName = "ngay";
		val4.Alignment = (DataGridViewContentAlignment)64;
		val4.Format = "### ### ### ###";
		((DataGridViewColumn)dgvcNgay).DefaultCellStyle = val4;
		((DataGridViewColumn)dgvcNgay).HeaderText = "Số ngày";
		dgvcNgay.Mask = "### ### ### ###";
		((DataGridViewColumn)dgvcNgay).Name = "dgvcNgay";
		((DataGridViewColumn)dgvcNgay).ReadOnly = true;
		dgvcNgay.SortMode = (DataGridViewColumnSortMode)0;
		dgvcNgay.SpecialType = Commons.NumericSpecialType.ACAmount;
		((Control)cmdExit).Anchor = (AnchorStyles)10;
		cmdExit.DialogResult = (DialogResult)2;
		((ButtonBase)cmdExit).Image = (Image)(object)Resources.imgExit;
		((ButtonBase)cmdExit).ImageAlign = (ContentAlignment)16;
		Button obj5 = cmdExit;
		location = new Point(601, 386);
		((Control)obj5).Location = location;
		((Control)cmdExit).Name = "cmdExit";
		Button obj6 = cmdExit;
		size = new Size(72, 23);
		((Control)obj6).Size = size;
		((Control)cmdExit).TabIndex = 8;
		((ButtonBase)cmdExit).Text = "&Thoát";
		((ButtonBase)cmdExit).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdExit).UseVisualStyleBackColor = true;
		((Control)cmdExecute).Anchor = (AnchorStyles)10;
		((ButtonBase)cmdExecute).Image = (Image)(object)Resources.imgExecute;
		((ButtonBase)cmdExecute).ImageAlign = (ContentAlignment)16;
		Button obj7 = cmdExecute;
		location = new Point(523, 386);
		((Control)obj7).Location = location;
		((Control)cmdExecute).Name = "cmdExecute";
		Button obj8 = cmdExecute;
		size = new Size(72, 23);
		((Control)obj8).Size = size;
		((Control)cmdExecute).TabIndex = 7;
		((ButtonBase)cmdExecute).Text = "Đă&ng Ký";
		((ButtonBase)cmdExecute).TextAlign = (ContentAlignment)64;
		((ButtonBase)cmdExecute).UseVisualStyleBackColor = true;
		((ButtonBase)chkChon).AutoSize = true;
		CheckBox obj9 = chkChon;
		location = new Point(28, 39);
		((Control)obj9).Location = location;
		((Control)chkChon).Name = "chkChon";
		CheckBox obj10 = chkChon;
		size = new Size(103, 17);
		((Control)obj10).Size = size;
		((Control)chkChon).TabIndex = 5;
		((ButtonBase)chkChon).Text = "Chọn/huỷ tất cả";
		((ButtonBase)chkChon).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)cmdExit;
		size = new Size(685, 421);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)chkChon);
		((Control)this).Controls.Add((Control)(object)cmdExit);
		((Control)this).Controls.Add((Control)(object)cmdExecute);
		((Control)this).Controls.Add((Control)(object)dgvCTGS);
		((Control)this).Controls.Add((Control)(object)lblSeparate);
		((Control)this).Controls.Add((Control)(object)lblKyKC);
		((Control)this).Controls.Add((Control)(object)txtNgay2);
		((Control)this).Controls.Add((Control)(object)txtNgay1);
		((Control)this).Controls.Add((Control)(object)cboKyBc);
		((Control)this).Name = "frmGLDKCTGS";
		((Form)this).Text = "Đăng ký chứng từ ghi sổ";
		((ISupportInitialize)dgvCTGS).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
			return true;
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void cboKyBc_SelectedValueChanged(object sender, EventArgs e)
	{
		if (((ComboBox)cboKyBc).DataSource != null)
		{
			txtNgay1.Value = ((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ngay1;
			txtNgay2.Value = ((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ngay2;
		}
	}

	private void chkChon_CheckedChanged(object sender, EventArgs e)
	{
		ChonHuy(chkChon.Checked);
	}

	private void frmGLDKCTGS_Load(object sender, EventArgs e)
	{
		((Form)this).Text = base.MyMenuInfo.bar;
		((DataGridView)dgvCTGS).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
		InitKyBaoCao();
		GetData();
	}

	private void cmdExecute_Click(object sender, EventArgs e)
	{
		InsertToDB();
	}

	private void cmdExit_Click(object sender, EventArgs e)
	{
		((Component)(object)this).Dispose();
	}

	private void InitKyBaoCao()
	{
		((ComboBox)cboKyBc).DataSource = AsiaErp.Framework.Environment.GetKyBaoCao(AsiaErp.Framework.Environment.GetSIConfiguration().Ngay_DnTc, "10000");
		((ListControl)cboKyBc).ValueMember = "ma";
		((ListControl)cboKyBc).DisplayMember = "ten_ky";
		if (Operators.ConditionalCompareObjectNotEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"", false))
		{
			if (Operators.ConditionalCompareObjectEqual(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao")), isNum: false), (object)"NGAY", false))
			{
				try
				{
					txtNgay1.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct1"));
					txtNgay2.Value = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("Ngay_Ct2"));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			((ListControl)cboKyBc).SelectedValue = RuntimeHelpers.GetObjectValue(AsiaErp.Framework.Environment.get_PublicVariables("KyBaoCao"));
		}
		else
		{
			((ComboBox)cboKyBc).SelectedIndex = 0;
		}
	}

	private void SaveKyBaoCao()
	{
		AsiaErp.Framework.Environment.set_PublicVariables("KyBaoCao", (object)((KyBaoCao)((ComboBox)cboKyBc).SelectedItem).ma);
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct1", RuntimeHelpers.GetObjectValue(txtNgay1.Value));
		AsiaErp.Framework.Environment.set_PublicVariables("Ngay_Ct2", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
	}

	private void ChonHuy(bool bChon)
	{
		if (oDt_CTHS == null || oDt_CTHS.Rows.Count < 1)
		{
			return;
		}
		foreach (DataRow row in oDt_CTHS.Rows)
		{
			row["tag"] = bChon;
		}
		chkChon.Checked = bChon;
	}

	private void GetData()
	{
		GLDKCTGSDAO gLDKCTGSDAO = (GLDKCTGSDAO)DAOFactory.CreateDAOInstance("GLDKCTGSDAO", "GLDKCTGS");
		oDt_CTHS = gLDKCTGSDAO.GetData();
		gLDKCTGSDAO.Destroy();
		dgvCTGS.DataSource = oDt_CTHS;
	}

	private void InsertToDB()
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		if (oDt_CTHS == null || oDt_CTHS.Rows.Count < 1)
		{
			return;
		}
		((Control)this).Cursor = Cursors.WaitCursor;
		int num = 0;
		ArrayList arrayList = new ArrayList();
		GLDKCTGSDAO gLDKCTGSDAO = (GLDKCTGSDAO)DAOFactory.CreateDAOInstance("GLDKCTGSDAO", "GLDKCTGS");
		foreach (DataRow row in oDt_CTHS.Rows)
		{
			if (!Operators.ConditionalCompareObjectEqual(row["tag"], (object)false, false))
			{
				arrayList.Clear();
				arrayList.Add(((ComboBox)cboKyBc).Text);
				arrayList.Add(RuntimeHelpers.GetObjectValue(row["ma_ct"]));
				arrayList.Add(RuntimeHelpers.GetObjectValue(row["tk"]));
				arrayList.Add(RuntimeHelpers.GetObjectValue(row["ten_ctgs"]));
				arrayList.Add(RuntimeHelpers.GetObjectValue(row["so_hieu"]));
				arrayList.Add(RuntimeHelpers.GetObjectValue(row["ngay"]));
				num = gLDKCTGSDAO.DangKyCTGS(arrayList.ToArray());
				if (num != 0)
				{
					((Control)this).Cursor = Cursors.Default;
					CMessageBox.Show(num);
					gLDKCTGSDAO.Destroy();
					return;
				}
			}
		}
		((Control)this).Cursor = Cursors.Default;
		gLDKCTGSDAO.Destroy();
		ChonHuy(bChon: false);
		CMessageBox.Show(50015);
	}
}
