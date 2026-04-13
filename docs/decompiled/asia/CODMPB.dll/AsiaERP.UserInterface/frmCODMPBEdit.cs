using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaERP.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmCODMPBEdit : frmDMComplexEdit
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtTk_nhan")]
	private AsTextBox _txtTk_nhan;

	[AccessedThroughProperty("lblTen_tk_nhan")]
	private Label _lblTen_tk_nhan;

	[AccessedThroughProperty("lblMa_spct")]
	private Label _lblMa_spct;

	[AccessedThroughProperty("txtMa_spct")]
	private AsTextBox _txtMa_spct;

	[AccessedThroughProperty("lblTen_spct")]
	private Label _lblTen_spct;

	[AccessedThroughProperty("cmdDelete")]
	private Button _cmdDelete;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("chkSpct")]
	private AsCheckBox _chkSpct;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	[AccessedThroughProperty("lblTen_bt")]
	private Label _lblTen_bt;

	[AccessedThroughProperty("lblSo_ct")]
	private Label _lblSo_ct;

	[AccessedThroughProperty("txtSo_ct")]
	private TextBox _txtSo_ct;

	[AccessedThroughProperty("txtOrder")]
	private AsTextNumeric _txtOrder;

	[AccessedThroughProperty("txtTen_bt")]
	private TextBox _txtTen_bt;

	[AccessedThroughProperty("lblTk_pb")]
	private Label _lblTk_pb;

	[AccessedThroughProperty("txtTk_pb")]
	private AsTextBox _txtTk_pb;

	[AccessedThroughProperty("lblSo_tt")]
	private Label _lblSo_tt;

	[AccessedThroughProperty("dgvNhan_pb")]
	private AsInputDGV _dgvNhan_pb;

	[AccessedThroughProperty("dgvcTK_nhan_pb")]
	private DataGridViewTextBoxColumn _dgvcTK_nhan_pb;

	[AccessedThroughProperty("dgvcTen_tk")]
	private DataGridViewTextBoxColumn _dgvcTen_tk;

	[AccessedThroughProperty("pnlRadio")]
	private Panel _pnlRadio;

	[AccessedThroughProperty("rdbPB_BP")]
	private RadioButton _rdbPB_BP;

	[AccessedThroughProperty("rdbPB_TKDU")]
	private RadioButton _rdbPB_TKDU;

	internal static DataTable f_oTblPbCt = new DataTable();

	internal static int pID = 0;

	internal static int stt = 0;

	private const string PH_TONGHOP = "GL";

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

	internal virtual AsTextBox txtTk_nhan
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_nhan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_nhan = value;
		}
	}

	internal virtual Label lblTen_tk_nhan
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk_nhan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk_nhan = value;
		}
	}

	internal virtual Label lblMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMa_spct = value;
		}
	}

	internal virtual AsTextBox txtMa_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_spct = value;
		}
	}

	internal virtual Label lblTen_spct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_spct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_spct = value;
		}
	}

	internal virtual Button cmdDelete
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdDelete_Click;
			if (_cmdDelete != null)
			{
				((Control)_cmdDelete).Click -= eventHandler;
			}
			_cmdDelete = value;
			if (_cmdDelete != null)
			{
				((Control)_cmdDelete).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdAdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdAdd_Click;
			if (_cmdAdd != null)
			{
				((Control)_cmdAdd).Click -= eventHandler;
			}
			_cmdAdd = value;
			if (_cmdAdd != null)
			{
				((Control)_cmdAdd).Click += eventHandler;
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

	internal virtual AsCheckBox chkSpct
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkSpct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkSpct = value;
		}
	}

	internal virtual Label lblTen_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk = value;
		}
	}

	internal virtual Label lblTen_bt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_bt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_bt = value;
		}
	}

	internal virtual Label lblSo_ct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_ct = value;
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

	internal virtual AsTextNumeric txtOrder
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOrder;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOrder = value;
		}
	}

	internal virtual TextBox txtTen_bt
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_bt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_bt = value;
		}
	}

	internal virtual Label lblTk_pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTk_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTk_pb = value;
		}
	}

	internal virtual AsTextBox txtTk_pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTk_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTk_pb = value;
		}
	}

	internal virtual Label lblSo_tt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSo_tt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSo_tt = value;
		}
	}

	internal virtual AsInputDGV dgvNhan_pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvNhan_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvNhan_pb = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcTK_nhan_pb
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcTK_nhan_pb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcTK_nhan_pb = value;
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

	internal virtual Panel pnlRadio
	{
		[DebuggerNonUserCode]
		get
		{
			return _pnlRadio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_pnlRadio = value;
		}
	}

	internal virtual RadioButton rdbPB_BP
	{
		[DebuggerNonUserCode]
		get
		{
			return _rdbPB_BP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rdbPB_BP = value;
		}
	}

	internal virtual RadioButton rdbPB_TKDU
	{
		[DebuggerNonUserCode]
		get
		{
			return _rdbPB_TKDU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rdbPB_TKDU = value;
		}
	}

	[DebuggerNonUserCode]
	public frmCODMPBEdit()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		lblTen_tk_nhan = new Label();
		txtTk_nhan = new AsTextBox();
		Label2 = new Label();
		lblTen_spct = new Label();
		txtMa_spct = new AsTextBox();
		lblMa_spct = new Label();
		cmdAdd = new Button();
		cmdDelete = new Button();
		Panel1 = new Panel();
		dgvNhan_pb = new AsInputDGV();
		dgvcTK_nhan_pb = new DataGridViewTextBoxColumn();
		dgvcTen_tk = new DataGridViewTextBoxColumn();
		GroupBox2 = new GroupBox();
		chkSpct = new AsCheckBox();
		lblTen_tk = new Label();
		lblTen_bt = new Label();
		lblSo_ct = new Label();
		txtSo_ct = new TextBox();
		txtOrder = new AsTextNumeric();
		txtTen_bt = new TextBox();
		lblTk_pb = new Label();
		txtTk_pb = new AsTextBox();
		lblSo_tt = new Label();
		pnlRadio = new Panel();
		rdbPB_BP = new RadioButton();
		rdbPB_TKDU = new RadioButton();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)dgvNhan_pb).BeginInit();
		((Control)GroupBox2).SuspendLayout();
		((Control)pnlRadio).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(418, 98);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 5;
		((Control)chkKsd).TabStop = true;
		((ButtonBase)chkKsd).Text = "&Không sử dụng";
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 415);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 3;
		Button obj2 = cmdSave;
		location = new Point(12, 415);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 2;
		((Control)gbLine).Anchor = (AnchorStyles)13;
		((Control)gbLine).Controls.Add((Control)(object)pnlRadio);
		((Control)gbLine).Controls.Add((Control)(object)chkSpct);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_spct);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_bt);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtSo_ct);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_spct);
		((Control)gbLine).Controls.Add((Control)(object)txtOrder);
		((Control)gbLine).Controls.Add((Control)(object)lblMa_spct);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_bt);
		((Control)gbLine).Controls.Add((Control)(object)lblTk_pb);
		((Control)gbLine).Controls.Add((Control)(object)txtTk_pb);
		((Control)gbLine).Controls.Add((Control)(object)lblSo_tt);
		GroupBox obj3 = gbLine;
		Size size = new Size(648, 153);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		gbLine.Text = "Thông tin tài khoản phân bổ";
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_tt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTk_pb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTk_pb, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_bt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblMa_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtOrder, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblSo_ct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_bt, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_spct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkSpct, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)pnlRadio, 0);
		Label obj4 = lblTen_tk_nhan;
		location = new Point(210, 26);
		((Control)obj4).Location = location;
		((Control)lblTen_tk_nhan).Name = "lblTen_tk_nhan";
		Label obj5 = lblTen_tk_nhan;
		size = new Size(183, 13);
		((Control)obj5).Size = size;
		((Control)lblTen_tk_nhan).TabIndex = 100;
		txtTk_nhan.AutoLookup = true;
		txtTk_nhan.AutoValid = true;
		((TextBoxBase)txtTk_nhan).BackColor = SystemColors.Info;
		((TextBox)txtTk_nhan).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTk_nhan;
		location = new Point(101, 22);
		((Control)asTextBox).Location = location;
		txtTk_nhan.LookupCodeName = "TK";
		txtTk_nhan.LookupWhereCondition = "CHI_TIET='1' and ksd='0'";
		((Control)txtTk_nhan).Name = "txtTk_nhan";
		txtTk_nhan.NameControl = lblTen_tk_nhan;
		AsTextBox asTextBox2 = txtTk_nhan;
		size = new Size(98, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTk_nhan).TabIndex = 0;
		txtTk_nhan.UseAutoCompleteSource = true;
		Label2.AutoSize = true;
		Label label = Label2;
		location = new Point(29, 26);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(48, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 100;
		Label2.Text = "TK nhận";
		Label obj6 = lblTen_spct;
		location = new Point(440, 74);
		((Control)obj6).Location = location;
		((Control)lblTen_spct).Name = "lblTen_spct";
		Label obj7 = lblTen_spct;
		size = new Size(250, 13);
		((Control)obj7).Size = size;
		((Control)lblTen_spct).TabIndex = 100;
		((Control)lblTen_spct).Visible = false;
		txtMa_spct.AutoLookup = true;
		txtMa_spct.AutoValid = true;
		((TextBoxBase)txtMa_spct).BackColor = SystemColors.Info;
		((TextBox)txtMa_spct).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_spct;
		location = new Point(331, 70);
		((Control)asTextBox3).Location = location;
		txtMa_spct.LookupCodeName = "MA_SPCT";
		((Control)txtMa_spct).Name = "txtMa_spct";
		txtMa_spct.NameControl = lblTen_spct;
		AsTextBox asTextBox4 = txtMa_spct;
		size = new Size(98, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_spct).TabIndex = 1;
		txtMa_spct.UseAutoCompleteSource = true;
		((Control)txtMa_spct).Visible = false;
		lblMa_spct.AutoSize = true;
		Label obj8 = lblMa_spct;
		location = new Point(259, 74);
		((Control)obj8).Location = location;
		((Control)lblMa_spct).Name = "lblMa_spct";
		Label obj9 = lblMa_spct;
		size = new Size(53, 13);
		((Control)obj9).Size = size;
		((Control)lblMa_spct).TabIndex = 100;
		lblMa_spct.Text = "Mã SPCT";
		((Control)lblMa_spct).Visible = false;
		((Control)cmdAdd).Anchor = (AnchorStyles)9;
		Button obj10 = cmdAdd;
		location = new Point(502, 19);
		((Control)obj10).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		Button obj11 = cmdAdd;
		size = new Size(64, 23);
		((Control)obj11).Size = size;
		((Control)cmdAdd).TabIndex = 2;
		((ButtonBase)cmdAdd).Text = "&Thêm";
		((ButtonBase)cmdAdd).UseVisualStyleBackColor = true;
		((Control)cmdDelete).Anchor = (AnchorStyles)9;
		Button obj12 = cmdDelete;
		location = new Point(576, 19);
		((Control)obj12).Location = location;
		((Control)cmdDelete).Name = "cmdDelete";
		Button obj13 = cmdDelete;
		size = new Size(64, 23);
		((Control)obj13).Size = size;
		((Control)cmdDelete).TabIndex = 3;
		((ButtonBase)cmdDelete).Text = "&Xóa";
		((ButtonBase)cmdDelete).UseVisualStyleBackColor = true;
		((Control)Panel1).Anchor = (AnchorStyles)15;
		((Control)Panel1).Controls.Add((Control)(object)dgvNhan_pb);
		Panel panel = Panel1;
		location = new Point(6, 48);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(636, 189);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 106;
		((DataGridView)dgvNhan_pb).AllowUserToAddRows = false;
		((DataGridView)dgvNhan_pb).AllowUserToDeleteRows = false;
		((DataGridView)dgvNhan_pb).BackgroundColor = Color.White;
		((DataGridView)dgvNhan_pb).BorderStyle = (BorderStyle)2;
		((DataGridView)dgvNhan_pb).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvNhan_pb).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)dgvcTK_nhan_pb,
			(DataGridViewColumn)dgvcTen_tk
		});
		((Control)dgvNhan_pb).Dock = (DockStyle)5;
		((DataGridView)dgvNhan_pb).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = dgvNhan_pb;
		location = new Point(0, 0);
		((Control)asInputDGV).Location = location;
		((Control)dgvNhan_pb).Name = "dgvNhan_pb";
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvNhan_pb).RowHeadersDefaultCellStyle = val;
		((DataGridView)dgvNhan_pb).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = dgvNhan_pb;
		size = new Size(636, 189);
		((Control)asInputDGV2).Size = size;
		((Control)dgvNhan_pb).TabIndex = 0;
		((DataGridViewColumn)dgvcTK_nhan_pb).DataPropertyName = "tk_nhan_pb";
		((DataGridViewColumn)dgvcTK_nhan_pb).HeaderText = "TK nhận PB";
		((DataGridViewColumn)dgvcTK_nhan_pb).Name = "dgvcTK_nhan_pb";
		((DataGridViewColumn)dgvcTK_nhan_pb).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_tk).DataPropertyName = "ten_tk";
		((DataGridViewColumn)dgvcTen_tk).HeaderText = "Tên tài khoản";
		((DataGridViewColumn)dgvcTen_tk).Name = "dgvcTen_tk";
		((DataGridViewColumn)dgvcTen_tk).ReadOnly = true;
		((DataGridViewColumn)dgvcTen_tk).Width = 350;
		((Control)GroupBox2).Anchor = (AnchorStyles)14;
		((Control)GroupBox2).Controls.Add((Control)(object)lblTen_tk_nhan);
		((Control)GroupBox2).Controls.Add((Control)(object)cmdAdd);
		((Control)GroupBox2).Controls.Add((Control)(object)cmdDelete);
		((Control)GroupBox2).Controls.Add((Control)(object)txtTk_nhan);
		((Control)GroupBox2).Controls.Add((Control)(object)Label2);
		((Control)GroupBox2).Controls.Add((Control)(object)Panel1);
		GroupBox groupBox = GroupBox2;
		location = new Point(12, 165);
		((Control)groupBox).Location = location;
		((Control)GroupBox2).Name = "GroupBox2";
		GroupBox groupBox2 = GroupBox2;
		size = new Size(648, 243);
		((Control)groupBox2).Size = size;
		((Control)GroupBox2).TabIndex = 1;
		GroupBox2.TabStop = false;
		GroupBox2.Text = "Thông tin tài khoản nhận phân bổ";
		((ButtonBase)chkSpct).AutoSize = true;
		chkSpct.Checked = false;
		AsCheckBox asCheckBox2 = chkSpct;
		location = new Point(262, 98);
		((Control)asCheckBox2).Location = location;
		((Control)chkSpct).Name = "chkSpct";
		AsCheckBox asCheckBox3 = chkSpct;
		size = new Size(150, 17);
		((Control)asCheckBox3).Size = size;
		((Control)chkSpct).TabIndex = 4;
		((ButtonBase)chkSpct).Text = "Theo &sản phẩm công trình";
		chkSpct.TextValue = "0";
		((ButtonBase)chkSpct).UseVisualStyleBackColor = true;
		Label obj14 = lblTen_tk;
		location = new Point(208, 48);
		((Control)obj14).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj15 = lblTen_tk;
		size = new Size(221, 13);
		((Control)obj15).Size = size;
		((Control)lblTen_tk).TabIndex = 102;
		lblTen_bt.AutoSize = true;
		Label obj16 = lblTen_bt;
		location = new Point(28, 23);
		((Control)obj16).Location = location;
		((Control)lblTen_bt).Name = "lblTen_bt";
		Label obj17 = lblTen_bt;
		size = new Size(68, 13);
		((Control)obj17).Size = size;
		((Control)lblTen_bt).TabIndex = 107;
		lblTen_bt.Text = "Tên bút toán";
		lblSo_ct.AutoSize = true;
		Label obj18 = lblSo_ct;
		location = new Point(28, 98);
		((Control)obj18).Location = location;
		((Control)lblSo_ct).Name = "lblSo_ct";
		Label obj19 = lblSo_ct;
		size = new Size(65, 13);
		((Control)obj19).Size = size;
		((Control)lblSo_ct).TabIndex = 109;
		lblSo_ct.Text = "Số chứng từ";
		txtSo_ct.CharacterCasing = (CharacterCasing)1;
		TextBox obj20 = txtSo_ct;
		location = new Point(101, 94);
		((Control)obj20).Location = location;
		((Control)txtSo_ct).Name = "txtSo_ct";
		TextBox obj21 = txtSo_ct;
		size = new Size(101, 20);
		((Control)obj21).Size = size;
		((Control)txtSo_ct).TabIndex = 3;
		txtOrder.DecimalSymbol = ".";
		txtOrder.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtOrder;
		location = new Point(101, 69);
		((Control)asTextNumeric).Location = location;
		txtOrder.Mask = "### ### ### ###";
		((Control)txtOrder).Name = "txtOrder";
		AsTextNumeric asTextNumeric2 = txtOrder;
		size = new Size(101, 20);
		((Control)asTextNumeric2).Size = size;
		((Control)txtOrder).TabIndex = 2;
		((TextBox)txtOrder).Text = "0";
		((TextBox)txtOrder).TextAlign = (HorizontalAlignment)1;
		txtOrder.Value = 0;
		TextBox obj22 = txtTen_bt;
		location = new Point(101, 19);
		((Control)obj22).Location = location;
		((Control)txtTen_bt).Name = "txtTen_bt";
		TextBox obj23 = txtTen_bt;
		size = new Size(328, 20);
		((Control)obj23).Size = size;
		((Control)txtTen_bt).TabIndex = 0;
		lblTk_pb.AutoSize = true;
		Label obj24 = lblTk_pb;
		location = new Point(28, 48);
		((Control)obj24).Location = location;
		((Control)lblTk_pb).Name = "lblTk_pb";
		Label obj25 = lblTk_pb;
		size = new Size(63, 13);
		((Control)obj25).Size = size;
		((Control)lblTk_pb).TabIndex = 110;
		lblTk_pb.Text = "TK phân bổ";
		txtTk_pb.AutoLookup = true;
		txtTk_pb.AutoValid = true;
		((TextBoxBase)txtTk_pb).BackColor = SystemColors.Info;
		((TextBox)txtTk_pb).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtTk_pb;
		location = new Point(101, 44);
		((Control)asTextBox5).Location = location;
		txtTk_pb.LookupCodeName = "TK";
		((Control)txtTk_pb).Name = "txtTk_pb";
		txtTk_pb.NameControl = lblTen_tk;
		AsTextBox asTextBox6 = txtTk_pb;
		size = new Size(101, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtTk_pb).TabIndex = 1;
		txtTk_pb.UseAutoCompleteSource = true;
		txtTk_pb.ValidReturnFieldList = "ten_tk";
		lblSo_tt.AutoSize = true;
		Label obj26 = lblSo_tt;
		location = new Point(28, 73);
		((Control)obj26).Location = location;
		((Control)lblSo_tt).Name = "lblSo_tt";
		Label obj27 = lblSo_tt;
		size = new Size(50, 13);
		((Control)obj27).Size = size;
		((Control)lblSo_tt).TabIndex = 108;
		lblSo_tt.Text = "Số thứ tự";
		((Control)pnlRadio).Controls.Add((Control)(object)rdbPB_BP);
		((Control)pnlRadio).Controls.Add((Control)(object)rdbPB_TKDU);
		Panel obj28 = pnlRadio;
		location = new Point(6, 120);
		((Control)obj28).Location = location;
		((Control)pnlRadio).Name = "pnlRadio";
		Panel obj29 = pnlRadio;
		size = new Size(634, 24);
		((Control)obj29).Size = size;
		((Control)pnlRadio).TabIndex = 5;
		((ButtonBase)rdbPB_BP).AutoSize = true;
		RadioButton obj30 = rdbPB_BP;
		location = new Point(25, 3);
		((Control)obj30).Location = location;
		((Control)rdbPB_BP).Name = "rdbPB_BP";
		RadioButton obj31 = rdbPB_BP;
		size = new Size(131, 17);
		((Control)obj31).Size = size;
		((Control)rdbPB_BP).TabIndex = 1;
		((ButtonBase)rdbPB_BP).Text = "Phân bổ theo bộ phận";
		((ButtonBase)rdbPB_BP).UseVisualStyleBackColor = true;
		((ButtonBase)rdbPB_TKDU).AutoSize = true;
		RadioButton obj32 = rdbPB_TKDU;
		location = new Point(162, 3);
		((Control)obj32).Location = location;
		((Control)rdbPB_TKDU).Name = "rdbPB_TKDU";
		RadioButton obj33 = rdbPB_TKDU;
		size = new Size(175, 17);
		((Control)obj33).Size = size;
		((Control)rdbPB_TKDU).TabIndex = 2;
		((ButtonBase)rdbPB_TKDU).Text = "Phân bổ theo tài khoản đối ứng";
		((ButtonBase)rdbPB_TKDU).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(672, 450);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)GroupBox2);
		((Control)this).Name = "frmCODMPBEdit";
		((Control)this).Controls.SetChildIndex((Control)(object)GroupBox2, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSave, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdCancel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)gbLine, 0);
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)dgvNhan_pb).EndInit();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)pnlRadio).ResumeLayout(false);
		((Control)pnlRadio).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitAfterGetData()
	{
		base.InitAfterGetData();
		if (!EditMode)
		{
			f_oTblPbCt.DefaultView.RowFilter = "id<0";
			if (Operators.CompareString(MyMenuInfo.moduleid, "GL", false) == 0)
			{
				rdbPB_BP.Checked = true;
				RowToEdit["TheoBP"] = 1;
			}
			txtOrder.Value = stt;
		}
		else
		{
			f_oTblPbCt.DefaultView.RowFilter = "id=" + RowToEdit["id"].ToString();
		}
		((DataGridView)dgvNhan_pb).DataSource = f_oTblPbCt.DefaultView;
		((Control)cmdDelete).Enabled = ((DataGridView)dgvNhan_pb).Rows.Count > 0;
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		if (Operators.CompareString(MyMenuInfo.moduleid, "GL", false) == 0)
		{
			((Control)pnlRadio).Visible = true;
			((Control)chkSpct).Visible = false;
		}
		else
		{
			((Control)pnlRadio).Visible = false;
			((Control)chkSpct).Visible = true;
		}
	}

	protected override bool ValidData()
	{
		return (base.ValidData() && ChkEmtyTextBox(txtTen_bt) && ChkEmtyTextBox((TextBox)(object)txtTk_pb)) ? true : false;
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtTk_pb).Enabled = false;
	}

	protected override bool InsertToDB()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		ICODMPBDAO iCODMPBDAO = (ICODMPBDAO)DAOFactory.CreateDAOInstance("CODMPBDAO", "CODMPB");
		int num = iCODMPBDAO.Insert(RowToEdit, MyMenuInfo.moduleid);
		iCODMPBDAO.Destroy();
		if (num == 0)
		{
			CMessageBox.Show(50011);
			return false;
		}
		if (((DataGridView)dgvNhan_pb).Rows.Count > 0)
		{
			ICODMPB1DAO iCODMPB1DAO = (ICODMPB1DAO)DAOFactory.CreateDAOInstance("CODMPB1DAO", "CODMPB");
			DataRow[] array = f_oTblPbCt.Select("", "", DataViewRowState.Added);
			foreach (DataRow dataRow in array)
			{
				iCODMPB1DAO.Insert(CompanyInformations.CompanyID, num, Conversions.ToString(dataRow["tk_nhan_pb"]), base.MyMenuInfo.moduleid);
			}
			iCODMPB1DAO.Destroy();
		}
		base.RowToEdit["id"] = num;
		DataRow[] array2 = f_oTblPbCt.Select("id=-1");
		foreach (DataRow dataRow2 in array2)
		{
			dataRow2["id"] = num;
		}
		return true;
	}

	protected override bool UpdateDB()
	{
		ICODMPBDAO iCODMPBDAO = (ICODMPBDAO)DAOFactory.CreateDAOInstance("CODMPBDAO", "CODMPB");
		iCODMPBDAO.Update(RowToEdit, MyMenuInfo.moduleid);
		iCODMPBDAO.Destroy();
		ICODMPB1DAO iCODMPB1DAO = (ICODMPB1DAO)DAOFactory.CreateDAOInstance("CODMPB1DAO", "CODMPB");
		DataRow[] array = f_oTblPbCt.Select("", "", DataViewRowState.Added);
		foreach (DataRow dataRow in array)
		{
			iCODMPB1DAO.Insert(CompanyInformations.CompanyID, pID, Conversions.ToString(dataRow["tk_nhan_pb"]), base.MyMenuInfo.moduleid);
		}
		iCODMPB1DAO.Destroy();
		return true;
	}

	protected override void DataBinding()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtTen_bt;
		CreateDataBinding(ref ojb, "ten_bt");
		txtTen_bt = (TextBox)ojb;
		ojb = (Control)(object)txtTk_pb;
		CreateDataBinding(ref ojb, "tk_pb");
		txtTk_pb = (AsTextBox)(object)ojb;
		ojb = (Control)(object)txtOrder;
		CreateDataBinding(ref ojb, "stt", "value");
		txtOrder = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtSo_ct;
		CreateDataBinding(ref ojb, "so_ct");
		txtSo_ct = (TextBox)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "ksd", "checked");
		chkKsd = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)rdbPB_BP;
		CreateDataBinding(ref ojb, "TheoBP", "Checked");
		rdbPB_BP = (RadioButton)ojb;
		ojb = (Control)(object)rdbPB_TKDU;
		CreateDataBinding(ref ojb, "TheoTKDU", "Checked");
		rdbPB_TKDU = (RadioButton)ojb;
		ojb = (Control)(object)chkSpct;
		CreateDataBinding(ref ojb, "TheoSPCT", "Checked");
		chkSpct = (AsCheckBox)(object)ojb;
	}

	private void cmdAdd_Click(object sender, EventArgs e)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(((TextBox)txtTk_nhan).Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtTk_nhan, Helper.GetMessContent(50002));
			((Control)txtTk_nhan).Select();
			return;
		}
		SetControlError((Control)(object)txtTk_nhan, "");
		foreach (DataGridViewRow item in (IEnumerable)((DataGridView)dgvNhan_pb).Rows)
		{
			DataGridViewRow val = item;
			if (Operators.CompareString(val.Cells[0].Value.ToString(), ((TextBox)txtTk_nhan).Text.Trim(), false) == 0)
			{
				CMessageBox.Show(50011);
				return;
			}
		}
		DataRow dataRow = f_oTblPbCt.NewRow();
		dataRow["ma_cty"] = CompanyInformations.CompanyID;
		dataRow["id"] = pID;
		dataRow["ModuleId"] = MyMenuInfo.moduleid;
		if (!EditMode)
		{
			dataRow["id"] = -1;
		}
		dataRow["tk_nhan_pb"] = ((TextBox)txtTk_nhan).Text.Trim();
		dataRow["ten_tk"] = lblTen_tk_nhan.Text.Trim();
		f_oTblPbCt.Rows.Add(dataRow);
		((Control)cmdDelete).Enabled = f_oTblPbCt.Rows.Count > 0;
		((Control)txtTk_nhan).Focus();
	}

	private void cmdDelete_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		if ((((DataGridView)dgvNhan_pb).Rows.Count > 0) & ((int)CMessageBox.Show(50003, SystemInformations.ProductFullName, (MessageBoxButtons)4, (MessageBoxDefaultButton)256) == 6))
		{
			ICODMPB1DAO iCODMPB1DAO = (ICODMPB1DAO)DAOFactory.CreateDAOInstance("CODMPB1DAO", "CODMPB");
			if (iCODMPB1DAO.Delete(CompanyInformations.CompanyID, Conversions.ToInteger(RowToEdit["id"]), ((DataGridView)dgvNhan_pb).CurrentRow.Cells[0].Value.ToString(), "", MyMenuInfo.par1) == 0)
			{
				f_oTblPbCt.DefaultView[((DataGridViewBand)((DataGridView)dgvNhan_pb).CurrentRow).Index].Delete();
				f_oTblPbCt.AcceptChanges();
				iCODMPB1DAO.Destroy();
				((Control)cmdDelete).Enabled = ((DataGridView)dgvNhan_pb).Rows.Count > 0;
			}
			else
			{
				CMessageBox.Show(50045);
			}
		}
	}
}
